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

    // Update is called once per frame
    void Update()
    {
        if (inventario != null)
        {
            inve = "inventario: ";
            inventario.objetosInventario.ForEach(obj =>
            {
                inve += obj.name + " ";
            });
            miText.text = inve;
        }
    }
}
