using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    ControlesMando control;

    private new Rigidbody rigidbody;

    public float movementSpeed;

    private void Awake()
    {
        /*control = new ControlesMando();
        OnEnabled();

        control.Personaje.Seleccionar.performed += ctx => Seleccionar();*/

        rigidbody = GetComponent<Rigidbody>();


    }
    private void UpdateMovement()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 velocity = Vector3.zero;

        if (ver != 0 || hor != 0)
        {
            // Obtener la cámara del jugador (deberías cachear esto en Awake o Start si es posible)
            Camera playerCamera = Camera.main;

            // Usar la dirección en la que está mirando la cámara
            Vector3 cameraForward = playerCamera.transform.forward;
            Vector3 cameraRight = playerCamera.transform.right;

            // Asegurarse de que el movimiento solo afecte al plano XZ, no a Y (arriba/abajo)
            cameraForward.y = 0;
            cameraRight.y = 0;

            Vector3 direccion = (cameraForward * ver + cameraRight * hor).normalized;

            velocity = direccion * movementSpeed;
        }

        velocity.y = rigidbody.velocity.y; // Mantener la componente vertical de la velocidad
        rigidbody.velocity = velocity;


    }

    private void UpdateCameraLook()
    {
        float hor = Input.GetAxis("");
    }

    private void Update()
    {
        UpdateMovement();
        UpdateCameraLook();
    }
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
