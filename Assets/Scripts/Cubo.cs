using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cubo : MonoBehaviour
{
    ControlesMando control;
    
    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
        control.Juego.Aumentar.performed += ctx => Aumentar();

        control.Juego.Disminuir.performed += ctx => Disminuir();
        
    }

    private void Update()
    {

        float z = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw ("Vertical");

        transform.Translate(0, y * Time.deltaTime, z * Time.deltaTime);
    }

    void Aumentar()
    {
        transform.localScale += Vector3.one / 10;
    }

    void Disminuir()
    {
        transform.localScale -= Vector3.one / 10;
    }

    private void OnEnabled()
    {
        control.Juego.Enable();
    }

    private void OnDisabled()
    {
        control.Juego.Disable();
    }


}