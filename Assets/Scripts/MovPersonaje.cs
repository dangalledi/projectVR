using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    ControlesMando control;

    private Rigidbody _rigidbody;

    public float movementSpeed;

    private void Awake()
    {
        /*control = new ControlesMando();
        OnEnabled();

        control.Personaje.Seleccionar.performed += ctx => Seleccionar();*/

        _rigidbody = GetComponent<Rigidbody>();


    }
    public void UpdateMovement()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 velocity = Vector3.zero;

        if (ver != 0 || hor != 0)
        {
            // Obtener la c�mara del jugador (deber�as cachear esto en Awake o Start si es posible)
            Camera playerCamera = Camera.main;

            // Usar la direcci�n en la que est� mirando la c�mara
            Vector3 cameraForward = playerCamera.transform.forward;
            Vector3 cameraRight = playerCamera.transform.right;

            // Asegurarse de que el movimiento solo afecte al plano XZ, no a Y (arriba/abajo)
            cameraForward.y = 0;
            cameraRight.y = 0;

            Vector3 direccion = (cameraForward * ver + cameraRight * hor).normalized;

            velocity = direccion * movementSpeed;
        }

        velocity.y = _rigidbody.velocity.y; // Mantener la componente vertical de la velocidad
        _rigidbody.velocity = velocity;
    }

    /*private void Update()
    {
        UpdateMovement();
    }*/

    /*void Seleccionar()
    {
        //transform.localScale -= Vector3.one / 10;
    }*/

    private void OnEnabled()
    {
        control.Personaje.Enable();
    }
    private void OnDisabled()
    {
        control.Personaje.Disable();
    }
}
