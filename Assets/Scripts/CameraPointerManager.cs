using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPointerManager : MonoBehaviour
{
    public static CameraPointerManager Instance;

    readonly string interactableTag = "interactable";

    [HideInInspector]
    public Vector3 hitPoint;

    ControlesMando control;

    LayerMask mask;
    public float distancia = 4.0f;


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
            if (hit.transform.CompareTag(interactableTag))
            {
                if (control.Personaje.Seleccionar.WasPerformedThisFrame())
                {
                    hit.collider.transform.GetComponent<AvanceObject>().ActivarObjeto();
                }
            }
        }

    }
}
