using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MoveObject : MonoBehaviour
{
    public Inventario inventario;
    public GameObject thePlayer;

    private bool activeObj = false;
    private readonly float paso = 10.0f;
    private float inicialY = 0, inicialZ = 0;
    private Vector2 inicial = Vector2.zero;
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
        inicialY = 0;
        inicialZ = 0;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (activeObj)
        {
            control.Personaje.Arriba.performed += ctx => MoverArriba();
            control.Personaje.Abajo.performed += ctx => MoverAbajo();

            Vector2 vars = control.Personaje.Jock2.ReadValue<Vector2>();
            
            float horizontalRotation = vars.x * 100f * Time.deltaTime;
            float verticalRotation = vars.y * 100f * Time.deltaTime;

            // Aplica la rotaci�n
            transform.Rotate(Vector3.up, horizontalRotation);
            transform.Rotate(Vector3.right, verticalRotation);
            

            if (control.Personaje.Deseleccionar.WasPerformedThisFrame())
            {
                activeObj = false;
                inventario.AddObject(gameObject);
                gameObject.SetActive(false);
            }
        }
    }

    private void Rotacion(Func<Vector2> readValue)
    {
        throw new NotImplementedException();
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
