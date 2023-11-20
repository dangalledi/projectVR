using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Progress;

public class Inventario : MonoBehaviour
{
    private bool inventarioActivo;
    public GameObject inventario;
    private int allSlots;
    private int enableSlots;
    private GameObject[] slot;
    public GameObject slotHolder;
    private ControlesMando controlesMando;


    public void Start()
    {
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
        }
        else
        {
            inventario.SetActive(false);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            GameObject itemPickedUp = other.gameObject;

            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }

    private void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
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
}