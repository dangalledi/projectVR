using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;


public class MoveObject : MonoBehaviour
{
    public GameObject thePlayer;
    public InventoryManager inventoryManager;

    private bool activeObj = false;
    ControlesMando control;
  
    private List<Color> colorList;
    private int countColor = 0;
    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
    }

    private void Start()
    {
        colorList = new List<Color>() {
        Color.red, Color.green, Color.blue, Color.gray,
        Color.black, Color.cyan, Color.magenta, Color.white };
        activeObj = false;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (activeObj)
        {
            control.Personaje.ChangeColor.performed += ctx => ChangeColor();

            control.Personaje.Aumentar.performed += ctx => Aumentar();
            control.Personaje.Disminuir.performed += ctx => Disminuir();

            Vector2 vars = control.Personaje.Jock2.ReadValue<Vector2>();

            float horizontalRotation = vars.x * 100f * Time.deltaTime;
            float verticalRotation = vars.y * 100f * Time.deltaTime;

            // Aplica la rotaci�n
            transform.Rotate(Vector3.up, horizontalRotation);
            transform.Rotate(Vector3.right, verticalRotation);

            float cantidadMovey = control.Personaje.MoveObjUpDown.ReadValue<float>();
            float cantidadMovex = control.Personaje.MoveObjLeftRigth.ReadValue<float>();

            // Aplica la traslaci�n
            gameObject.transform.localPosition += new Vector3(0, cantidadMovey, cantidadMovex) * Time.deltaTime;
           

            if (control.Personaje.Deseleccionar.WasPerformedThisFrame())
            {
                ItemComponent item = gameObject.GetComponent<ItemComponent>();
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

    private void OnDisabled()
    {
        control.Personaje.Disable();
    }

    void Aumentar()
    {
        transform.localScale += Vector3.one / 10;
    }

    void Disminuir()
    {
        transform.localScale -= Vector3.one / 10;
    }

    void ChangeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = colorList[countColor];
        if(countColor == 7) { countColor = -1; };
        countColor++;
    }
}
