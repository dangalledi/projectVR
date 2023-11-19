using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;


public class MoveObject : MonoBehaviour
{
    public Inventario inventario;
    public GameObject thePlayer;
    public InventoryManager inventoryManager;

    private bool activeObj = false;
    ControlesMando control;
    public ItemInventario item;

    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
    }

    private void Start()
    {
        inventario = thePlayer.GetComponent<Inventario>();
        activeObj = false;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (activeObj)
        { 

            Vector2 vars = control.Personaje.Jock2.ReadValue<Vector2>();

            float horizontalRotation = vars.x * 100f * Time.deltaTime;
            float verticalRotation = vars.y * 100f * Time.deltaTime;

            // Aplica la rotaci�n
            transform.Rotate(Vector3.up, horizontalRotation);
            transform.Rotate(Vector3.right, verticalRotation);

            float cantidadMove = control.Personaje.MoveObjUpDown.ReadValue<float>();

            // Aplica la traslaci�n
            gameObject.transform.localPosition += new Vector3(0, cantidadMove, 0) * Time.deltaTime;


            if (control.Personaje.Deseleccionar.WasPerformedThisFrame())
            {
                item = gameObject.GetComponent<ItemInventario>();
                activeObj = false;
                if (item != null)
                {
                    inventoryManager.AddItem(item);
                    Destroy(gameObject); // Destruye el objeto de la llave para que no se pueda recoger de nuevo
                }
                //gameObject.SetActive(false);

                if (inventoryManager == null)
                {
                    Debug.Log("inventoryManager es null");
                }
                if (item == null)
                {
                    Debug.Log("item es null");
                }
            }
        }
    }

    public void ActivarObjeto()
    {
        activeObj = true;
    }
    private void OnEnabled()
    {
        control.Personaje.Enable();
    }

    public void MoverArriba()
    {
        gameObject.transform.localPosition += new Vector3(0, 0.5f, 0);
    }
    public void MoverAbajo()
    {
        gameObject.transform.localPosition += new Vector3(0, -0.5f, 0);
    }

    private void OnDisabled()
    {
        control.Personaje.Disable();
    }
}
