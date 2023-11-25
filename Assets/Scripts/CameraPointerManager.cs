using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class CameraPointerManager : MonoBehaviour
{
    public static CameraPointerManager Instance;
    private EventSystem eventSystem; // Sistema de eventos de Unity

    readonly string interactableTag = "interactable", doorTag= "door", interactableInventarioTag= "Item";
    ControlesMando control;

    LayerMask mask;
    public float distancia = 6.0f;

    GameObject ultimoReconocido = null;

    private GameObject _gazeAtObject;

    [HideInInspector]
    public Vector3 hitPoint;

    private void Awake()
    {
        control = new ControlesMando();

        OnEnabled();

        //control.Personaje.Seleccionar.performed += ctx => Seleccionar();

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

  /*  void Seleccionar()
    {
        selecct = true;
    }*/

    private void OnEnabled()
    {
        control.Personaje.Enable();
    }

    private void Start()
    {
        eventSystem = EventSystem.current;

        mask = LayerMask.GetMask("Raycast Detect");
    }

    // Update is called once per frame
    private void Update()
    {
        // Casts ray towards camera's forward direction, to detect if a GameObject is being gazed
        // at.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, mask))
        {
            hitPoint = hit.point;
            Deselect();
            SelectObject(hit.transform);

            if(_gazeAtObject != hit.transform.gameObject)
            {
                _gazeAtObject?.SendMessage("OnPointerExit");
                _gazeAtObject = hit.transform.gameObject;
                _gazeAtObject?.SendMessage("OnPointerEnter");
            }

            if (hit.transform.CompareTag(interactableTag))
            {
                if (control.Personaje.Seleccionar.WasPerformedThisFrame())
                {
                    hit.collider.transform.GetComponent<MoveObject>().ActivarObjeto();
                }
            }
            if (hit.transform.CompareTag(doorTag))
            {
                if (control.Personaje.Seleccionar.WasPerformedThisFrame())
                {
                    hit.collider.transform.GetComponent<OpenDoor>().ActivarObjeto();
                }
            }
            if (hit.transform.CompareTag(interactableInventarioTag))
            {
                if (control.Personaje.Seleccionar.WasPerformedThisFrame())
                {
                    hit.collider.transform.GetComponent<MoveObjectInventario>().ActivarObjeto();
                }
            }
            if (hit.transform.CompareTag("slot"))
            {
/*                GameObject slotUnderCursor = hit.transform.gameObject;
*/                if (control.Personaje.Seleccionar.WasPerformedThisFrame())
                {
                    /*Debug.Log("LLego aca ");
                    Debug.Log(slotUnderCursor.ToString());
                    eventSystem.SetSelectedGameObject(slotUnderCursor);*/

                    if (control.Personaje.Seleccionar.WasPerformedThisFrame()) // Click button Start
                    {
                        /*PointerEventData pointerData = new PointerEventData(eventSystem);
                        pointerData.position = hit.collider.transform.position; // Asegúrate de que esta es la posición correcta
                        ExecuteEvents.Execute(slotUnderCursor, pointerData, ExecuteEvents.pointerClickHandler);*/
                        //hit.collider.transform.GetComponent<Slot>().Active();
                        _gazeAtObject?.SendMessage("OnPointerClick", null, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }


            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distancia, Color.red);
        }
        else
        {
            Deselect();
        }
    }

    void SelectObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }

    void Deselect()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido.GetComponent<MeshRenderer>().material.color = Color.white;
            ultimoReconocido = null;
        }
    }
}
