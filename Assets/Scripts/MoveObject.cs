using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;


public class MoveObject : MonoBehaviour
{
    public Inventario inventario;
    public GameObject thePlayer;

    private bool activeObj = false;
    ControlesMando control;

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

            // Aplica la rotación
            transform.Rotate(Vector3.up, horizontalRotation);
            transform.Rotate(Vector3.right, verticalRotation);

            float cantidadMove = control.Personaje.MoveObjUpDown.ReadValue<float>();

            // Aplica la traslación
            gameObject.transform.localPosition += new Vector3(0, cantidadMove, 0) * Time.deltaTime;


            if (control.Personaje.Deseleccionar.WasPerformedThisFrame())
            {
                activeObj = false;
                inventario.AddObject(gameObject);
                gameObject.SetActive(false);
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
        gameObject.transform.localPosition += new Vector3(0,0.5f,0);
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
