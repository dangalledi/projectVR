using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AvanceObject : MonoBehaviour
{
    //public Transform teleportTarget;
    //public GameObject thePlayer;

    private bool activeObj = false;

    ControlesMando control;

    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
    }

    private void Start()
    {
        activeObj = false;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (activeObj)
        {
            control.Personaje.Arriba.performed += ctx => MoverArriba();
            control.Personaje.Abajo.performed += ctx => MoverAbajo();

            //control.Personaje.Izquierda.performed += ctx => MoveIzquierda();
            //control.Personaje.Derecha.performed += ctx => MoveDerecha();

            if (control.Personaje.Deseleccionar.WasPerformedThisFrame())
            {
                activeObj = false;
                gameObject.SetActive(false);
            }
        }
    }

    public void ActivarObjeto()
    {
        //Destroy(gameObject);
        activeObj = true;
    }
    private void OnEnabled()
    {
        control.Personaje.Enable();
    }

    void Aumentar()
    {
        gameObject.transform.localScale += Vector3.one / 10;
    }

    void MoverArriba()
    {
        gameObject.transform.localPosition += new Vector3(0,1,0);
    }
    void MoverAbajo()
    {
        gameObject.transform.localPosition += new Vector3(0, -1, 0);
    }

    void Disminuir()
    {
        gameObject.transform.localScale -= Vector3.one / 10;
    }

    private void OnDisabled()
    {
        control.Personaje.Disable();
    }
}
