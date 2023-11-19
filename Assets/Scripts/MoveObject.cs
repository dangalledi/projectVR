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

            control.Personaje.Izquierda.performed += ctx => RotarVertical();
            control.Personaje.Derecha.performed += ctx => RotarHorizontal();

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

    public void RotarVertical()
    {
        inicialY += paso;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, inicialY, inicialZ));
    }

    public void RotarHorizontal()
    {
        inicialZ += paso;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, inicialY, inicialZ));
    }

    private void OnDisabled()
    {
        control.Personaje.Disable();
    }
}
