using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel; // Arrastra tu panel de inventario aqu� desde el Inspector
    private bool isInventoryActive = false;
    ControlesMando control;

    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
    }

    void Update()
    {
        // Comprueba si el bot�n del joystick ha sido presionado
        if (control.Personaje.Inventario.WasPerformedThisFrame())
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
    private void OnEnabled()
    {
        control.Personaje.Enable();
    }
}