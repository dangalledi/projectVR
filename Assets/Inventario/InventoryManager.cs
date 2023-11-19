using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // La lista de �tems en el inventario
    public GameObject slotPrefab; // El prefab del slot de inventario
    public Transform inventoryPanel; // La referencia al panel que contiene los slots

    void Start()
    {
        UpdateInventoryUI();
    }

    public void AddItem(Item itemToAdd)
    {
        items.Add(itemToAdd);
        UpdateInventoryUI();
    }

    public void RemoveItem(Item itemToRemove)
    {
        items.Remove(itemToRemove);
        UpdateInventoryUI();
    }

    private void UpdateInventoryUI()
    {
        // Elimina los slots actuales
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // Crea un nuevo slot para cada �tem en el inventario
        foreach (Item item in items)
        {
            GameObject slot = Instantiate(slotPrefab, inventoryPanel);
            slot.GetComponent<Image>().sprite = item.icon; // Suponiendo que tu clase Item tiene un Sprite icon
            slot.GetComponent<Button>().onClick.AddListener(() => UseItem(item)); // Suponiendo que tienes un m�todo UseItem
        }
    }

    private void UseItem(Item item)
    {
        // Implementa la l�gica para usar el �tem aqu�
    }
}

[System.Serializable]
public class Item
{
    public string name;
    public Sprite icon;
    // A�ade aqu� m�s propiedades seg�n sea necesario
}