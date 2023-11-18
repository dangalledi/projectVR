using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    ControlesMando control;

    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();

        control.Personaje.Seleccionar.performed += ctx => Seleccionar();
        
    }
    private void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.Translate(x * Time.deltaTime * 2, 0, z * Time.deltaTime * 2);
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
