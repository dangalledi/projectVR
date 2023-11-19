using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<ItemComponent> items = new List<ItemComponent>(); // La lista de ítems en el inventario
    public GameObject slotPrefab; // El prefab del slot de inventario
    public Transform inventoryPanel; // La referencia al panel que contiene los slots

    void Start()
    {
        UpdateInventoryUI();
    }

    public void AddItem(ItemComponent itemToAdd)
    {
        items.Add(itemToAdd);
        UpdateInventoryUI();
    }

    public void RemoveItem(ItemComponent itemToRemove)
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
        foreach (ItemComponent item in items)
        {
            GameObject newSlot = Instantiate(slotPrefab, inventoryPanel.transform);
            newSlot.GetComponentInChildren<Image>().sprite = item.itemData.icon;
            // Configura otros elementos del slot aquí, como texto o cantidad
        }
    }

    private void UseItem(ItemComponent item)
    {
        // Implementa la lógica para usar el ítem aquí
    }
}