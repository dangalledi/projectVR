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
        control = new ControlesMando();
        OnEnabled();

        control.Personaje.Seleccionar.performed += ctx => Seleccionar();

        rigidbody = GetComponent<Rigidbody>();


    }
    private void Update()
    {

        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(ver != 0  || hor != 0 )
        {
            Vector3 direccion = (transform.forward * ver + transform.right * hor).normalized;

            rigidbody.velocity = direccion * movementSpeed;
        }

        //transform.Translate(x * Time.deltaTime, 0, z * Time.deltaTime);
    }
    void Seleccionar()
    {
        //transform.localScale -= Vector3.one / 10;
    }

    private void OnEnabled()
    {
        control.Personaje.Enable();
    }
    private void OnDisabled()
    {
        control.Personaje.Disable();
    }
}
