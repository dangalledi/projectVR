using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<ItemInventario> items = new List<ItemInventario>(); // La lista de ítems en el inventario
    public GameObject slotPrefab; // El prefab del slot de inventario
    public Transform inventoryPanel; // La referencia al panel que contiene los slots

    void Start()
    {
        UpdateInventoryUI();
    }

    public void AddItem(ItemInventario itemToAdd)
    {
        items.Add(itemToAdd);
        UpdateInventoryUI();
    }

    public void RemoveItem(ItemInventario itemToRemove)
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

        // Crea un nuevo slot para cada ítem en el inventario
        foreach (ItemInventario item in items)
        {
            GameObject newSlot = Instantiate(slotPrefab, inventoryPanel.transform);
            newSlot.GetComponentInChildren<Image>().sprite = item.icon;
            // Configura otros elementos del slot aquí, como texto o cantidad
        }
    }

    private void UseItem(Item item)
    {
        // Implementa la lógica para usar el ítem aquí
    }
}

[System.Serializable]
public class Item
{
    public string name;
    public Sprite icon;
    // Añade aquí más propiedades según sea necesario
}