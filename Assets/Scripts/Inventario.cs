using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Inventario : MonoBehaviour
{
    private bool inventarioActivo;
    public GameObject inventario;
    private int allSlots;
    private int enableSlots;
    private GameObject[] slot;
    public GameObject slotHolder;
    private ControlesMando controlesMando;
    public MovPersonaje movP;

    public RectTransform cursorRectTransform; // Asigna el RectTransform del objeto cursor
    public float cursorSpeed = 500.0f; // Velocidad del cursor

    private int selectedSlotIndex = 0; // Índice del slot seleccionado

    private EventSystem eventSystem; // Sistema de eventos de Unity

    ControlesMando control;
    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();

    }

    public void Start()
    {
        eventSystem = EventSystem.current;

        controlesMando = new ControlesMando();
        controlesMando.Enable();

        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
            else
            {
                eventSystem.SetSelectedGameObject(slot[0]);
            }
        }
    }

    public void Update()
    {
        if (controlesMando != null && controlesMando.Personaje.Inventario.WasPerformedThisFrame())
        {
            Debug.Log(" Triangulo precionado -> Inventario ");
            inventarioActivo = !inventarioActivo;
        }
        if (inventarioActivo)
        {
            inventario.SetActive(true);
            HandleJoystickInput();
        }
        else
        {
            inventario.SetActive(false);
            movP.UpdateMovement();

        }

    }
    private void OnEnable()
    {
        controlesMando.Personaje.Inventario.performed += HandleInventarioPerformed;
    }

    private void OnDisable()
    {
        controlesMando.Personaje.Inventario.performed -= HandleInventarioPerformed;
    }

    private void HandleInventarioPerformed(InputAction.CallbackContext context)
    {
        inventarioActivo = !inventarioActivo;
        inventario.SetActive(inventarioActivo);
        Debug.Log("Inventario toggle: " + inventarioActivo);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            GameObject itemPickedUp = other.gameObject;

            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }*/

    public void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (int i = 0; i < allSlots; i++)
        {
            if (slot[i].GetComponent<Slot>().empty)
            {
                itemObject.GetComponent<Item>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().description = itemDescription;
                slot[i].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);


                slot[i].GetComponent<Slot>().UpdateSlot();

                slot[i].GetComponent<Slot>().empty = false;
            }
            return;
        }
    }

    public void RemoveItem(int itemID)
    {
        for (int i = 0; i < allSlots; i++)
        {
            Slot slotScript = slot[i].GetComponent<Slot>();
            if (!slotScript.empty && slotScript.ID == itemID)
            {
                // Eliminar el ítem de la lógica del inventario
                slotScript.item.SetActive(true); // Si quieres que el ítem vuelva a la escena
                slotScript.item = null;
                slotScript.ID = -1; // Suponiendo que -1 significa que no hay ítem
                slotScript.type = string.Empty;
                slotScript.description = string.Empty;
                slotScript.icon = null;
                slotScript.empty = true;

                // Actualizar la UI del slot para reflejar que está vacío
                slotScript.UpdateSlot();
                return; // Suponiendo que solo quieres eliminar un ítem a la vez
            }
        }
    }

    private void HandleJoystickInput()
    {

        // Obtener entrada del joystick
        float x = Input.GetAxis("Horizontal") * cursorSpeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * cursorSpeed * Time.deltaTime;

        // Mover el cursor
        cursorRectTransform.anchoredPosition += new Vector2(x, y);

        if (control.Personaje.Seleccionar.WasPerformedThisFrame()) // Click button Start
        {
            GameObject slotUnderCursor = DetectSlotUnderCursor();

            if (slotUnderCursor != null)
            {
                eventSystem.SetSelectedGameObject(slotUnderCursor);

                if (control.Personaje.Seleccionar.WasPerformedThisFrame()) // Click button Start
                {
                    PointerEventData pointerData = new PointerEventData(eventSystem);
                    pointerData.position = cursorRectTransform.position; // Asegúrate de que esta es la posición correcta
                    ExecuteEvents.Execute(slotUnderCursor, pointerData, ExecuteEvents.pointerClickHandler);
                }
            }
        }
    }

    private GameObject DetectSlotUnderCursor()
    {
        // Crea un PointerEventData con la posición actual del cursor
        PointerEventData pointerData = new PointerEventData(eventSystem)
        {
            position = cursorRectTransform.position
        };

        // Crea una lista para recibir los resultados del raycast
        List<RaycastResult> results = new List<RaycastResult>();

        // Hacer el raycast
        eventSystem.RaycastAll(pointerData, results);

        // Devuelve el primer slot válido detectado, si hay alguno
        foreach (RaycastResult result in results)
        {
            if (result.gameObject.CompareTag("slot")) // Asegúrate de que tus slots tengan esta etiqueta
            {
                return result.gameObject;
            }
        }

        // Si no se encuentra ningún slot, devuelve null
        return null;
    }
    private void OnEnabled()
    {
        control.Personaje.Enable();
    }

}

