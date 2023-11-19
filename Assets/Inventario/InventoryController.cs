using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel; // Arrastra tu panel de inventario aquí desde el Inspector
    private bool isInventoryActive = false;
    ControlesMando control;

    private void Awake()
    {
        control = new ControlesMando();
        OnEnabled();
    }

    void Update()
    {
        // Comprueba si el botón del joystick ha sido presionado
        if (control.Personaje.Inventario.WasPerformedThisFrame())
        {
            // Cambia el estado de la activación del inventario
            isInventoryActive = !isInventoryActive;
            inventoryPanel.SetActive(isInventoryActive);

            // Si deseas pausar el juego cuando el inventario esté activo, descomenta la siguiente línea
            // Time.timeScale = isInventoryActive ? 0 : 1;

            // Opcional: desactivar la entrada del jugador si el inventario está activo
            // playerController.enabled = !isInventoryActive;

            Debug.Log("Botón presionado");
        }
    }
    private void OnEnabled()
    {
        control.Personaje.Enable();
    }
}