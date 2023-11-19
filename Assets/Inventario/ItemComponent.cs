using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    public Item itemData;
}

[System.Serializable]
public class Item
{
    public string name;
    public Sprite icon;
    // Añade aquí más propiedades según sea necesario
}