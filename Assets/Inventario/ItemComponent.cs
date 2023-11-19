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
    // A�ade aqu� m�s propiedades seg�n sea necesario
}