using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectInventario : MonoBehaviour
{
    public GameObject thePlayer;
    public Inventario inventario;

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
        inventario = thePlayer.GetComponent<Inventario>();



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

                Item item = gameObject.GetComponent<Item>();

                inventario.AddItem(gameObject, item.ID, item.type, item.description, item.icon);
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
        if (countColor == 7) { countColor = -1; };
        countColor++;
    }
}
