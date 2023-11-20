using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextInventario : MonoBehaviour
{

    public TextMeshProUGUI miText;
    public Inventario inventario;
    public GameObject thePlayer;
    public string inve = "inventario: ";
    private void Start()
    {
        inventario = thePlayer.GetComponent<Inventario>();
        miText.text = "inventario: vacio";
    }

    void Update()
    {

    }
}
