using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Inventario inventario;
    public GameObject thePlayer;

    private void Start()
    {
        inventario = thePlayer.GetComponent<Inventario>();
    }

    public void OnPointerClick()
    {
        inventario.AddObject(gameObject);
        //Destroy(gameObject);
    }

}
