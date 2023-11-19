using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel; // Arrastra tu panel de inventario aqu� desde el Inspector
    private bool isInventoryActive = false;

    void Update()
    {
        // Comprueba si el bot�n del joystick ha sido presionado
        if (Input.GetButtonDown("Jump")) // Aseg�rate de que "Jump" es el nombre del bot�n que configuraste
        {
            // Cambia el estado de la activaci�n del inventario
            isInventoryActive = !isInventoryActive;
            inventoryPanel.SetActive(isInventoryActive);

            // Si deseas pausar el juego cuando el inventario est� activo, descomenta la siguiente l�nea
            // Time.timeScale = isInventoryActive ? 0 : 1;

            // Opcional: desactivar la entrada del jugador si el inventario est� activo
            // playerController.enabled = !isInventoryActive;

            Debug.Log("Bot�n presionado");
        }
    }
}