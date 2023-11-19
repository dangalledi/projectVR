//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/ControlesMando.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ControlesMando: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlesMando()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlesMando"",
    ""maps"": [
        {
            ""name"": ""Juego"",
            ""id"": ""5e22b60b-284e-44c8-8bba-105710880748"",
            ""actions"": [
                {
                    ""name"": ""Aumentar"",
                    ""type"": ""Button"",
                    ""id"": ""65c707b0-3764-445e-9b89-23efb0599bae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Disminuir"",
                    ""type"": ""Button"",
                    ""id"": ""d00fabfc-638b-4394-aa92-9de307f29f37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""280ed8c3-baf1-4ffe-bc7d-4aa9d38b5427"",
                    ""path"": ""<DualSenseGamepadHID>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aumentar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ede68a6-cc3d-4b30-b5fb-6fd669f0a1fa"",
                    ""path"": ""<DualSenseGamepadHID>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disminuir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Personaje"",
            ""id"": ""e5507cdb-9960-432d-b5dd-07e2bad25f70"",
            ""actions"": [
                {
                    ""name"": ""Seleccionar"",
                    ""type"": ""Button"",
                    ""id"": ""80b7885f-95d0-49b4-9401-d7a0b5264494"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Derecha"",
                    ""type"": ""Button"",
                    ""id"": ""ea6f5a06-9bcd-4539-82db-46fbc740585e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Izquierda"",
                    ""type"": ""Button"",
                    ""id"": ""d5d9e392-0ade-41d4-bd35-e64274458fa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Deseleccionar"",
                    ""type"": ""Button"",
                    ""id"": ""d0010676-db6f-4fd0-a04c-24dbb25f8720"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jock2"",
                    ""type"": ""Value"",
                    ""id"": ""cd94b17b-9653-406b-880d-a355f707573a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Inventario"",
                    ""type"": ""Button"",
                    ""id"": ""5c46e0ed-ab48-49cb-8536-555ea60b8bf9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveObjUpDown"",
                    ""type"": ""Value"",
                    ""id"": ""fcf94bc5-b54e-428f-8e8f-3ac15527814e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eda4d834-00cf-4397-bd88-271d1f857d48"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d94af1e8-9df9-4dea-a85c-2d3e5c1c0c1b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Derecha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50cde4b5-e019-4b0b-9f6a-8f4328efac22"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Izquierda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07a05ee7-c4e6-4db3-966e-7a6406c261fa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deseleccionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""732d6ea0-888d-41cc-84af-3bfc857c43f8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jock2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""52e1c070-c292-4e78-abaf-449fac2403d9"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jock2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""31f0195e-35c5-4f85-b76b-5b4cfe29fcca"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jock2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c46b563-fddc-4f8d-b656-f66c62c972e1"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jock2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""59f42e48-3ed3-4996-bf4b-be2ed26d709e"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jock2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""88da2642-2e00-4a43-83e8-b7b12ec35ae5"",
                    ""path"": ""1DAxis(minValue=-0.2,maxValue=0.2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveObjUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b25d63e-b9e5-477a-8aa9-2a119d0c3b98"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveObjUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""01f2f454-139a-48de-b85c-60fb075dfca7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveObjUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""53a99109-582c-4b89-b184-74d367486476"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventario"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Juego
        m_Juego = asset.FindActionMap("Juego", throwIfNotFound: true);
        m_Juego_Aumentar = m_Juego.FindAction("Aumentar", throwIfNotFound: true);
        m_Juego_Disminuir = m_Juego.FindAction("Disminuir", throwIfNotFound: true);
        // Personaje
        m_Personaje = asset.FindActionMap("Personaje", throwIfNotFound: true);
        m_Personaje_Seleccionar = m_Personaje.FindAction("Seleccionar", throwIfNotFound: true);
        m_Personaje_Derecha = m_Personaje.FindAction("Derecha", throwIfNotFound: true);
        m_Personaje_Izquierda = m_Personaje.FindAction("Izquierda", throwIfNotFound: true);
        m_Personaje_Deseleccionar = m_Personaje.FindAction("Deseleccionar", throwIfNotFound: true);
        m_Personaje_Jock2 = m_Personaje.FindAction("Jock2", throwIfNotFound: true);
        m_Personaje_Inventario = m_Personaje.FindAction("Inventario", throwIfNotFound: true);
        m_Personaje_MoveObjUpDown = m_Personaje.FindAction("MoveObjUpDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Juego
    private readonly InputActionMap m_Juego;
    private List<IJuegoActions> m_JuegoActionsCallbackInterfaces = new List<IJuegoActions>();
    private readonly InputAction m_Juego_Aumentar;
    private readonly InputAction m_Juego_Disminuir;
    public struct JuegoActions
    {
        private @ControlesMando m_Wrapper;
        public JuegoActions(@ControlesMando wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aumentar => m_Wrapper.m_Juego_Aumentar;
        public InputAction @Disminuir => m_Wrapper.m_Juego_Disminuir;
        public InputActionMap Get() { return m_Wrapper.m_Juego; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JuegoActions set) { return set.Get(); }
        public void AddCallbacks(IJuegoActions instance)
        {
            if (instance == null || m_Wrapper.m_JuegoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JuegoActionsCallbackInterfaces.Add(instance);
            @Aumentar.started += instance.OnAumentar;
            @Aumentar.performed += instance.OnAumentar;
            @Aumentar.canceled += instance.OnAumentar;
            @Disminuir.started += instance.OnDisminuir;
            @Disminuir.performed += instance.OnDisminuir;
            @Disminuir.canceled += instance.OnDisminuir;
        }

        private void UnregisterCallbacks(IJuegoActions instance)
        {
            @Aumentar.started -= instance.OnAumentar;
            @Aumentar.performed -= instance.OnAumentar;
            @Aumentar.canceled -= instance.OnAumentar;
            @Disminuir.started -= instance.OnDisminuir;
            @Disminuir.performed -= instance.OnDisminuir;
            @Disminuir.canceled -= instance.OnDisminuir;
        }

        public void RemoveCallbacks(IJuegoActions instance)
        {
            if (m_Wrapper.m_JuegoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJuegoActions instance)
        {
            foreach (var item in m_Wrapper.m_JuegoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JuegoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JuegoActions @Juego => new JuegoActions(this);

    // Personaje
    private readonly InputActionMap m_Personaje;
    private List<IPersonajeActions> m_PersonajeActionsCallbackInterfaces = new List<IPersonajeActions>();
    private readonly InputAction m_Personaje_Seleccionar;
    private readonly InputAction m_Personaje_Derecha;
    private readonly InputAction m_Personaje_Izquierda;
    private readonly InputAction m_Personaje_Deseleccionar;
    private readonly InputAction m_Personaje_Jock2;
    private readonly InputAction m_Personaje_Inventario;
    private readonly InputAction m_Personaje_MoveObjUpDown;
    public struct PersonajeActions
    {
        private @ControlesMando m_Wrapper;
        public PersonajeActions(@ControlesMando wrapper) { m_Wrapper = wrapper; }
        public InputAction @Seleccionar => m_Wrapper.m_Personaje_Seleccionar;
        public InputAction @Derecha => m_Wrapper.m_Personaje_Derecha;
        public InputAction @Izquierda => m_Wrapper.m_Personaje_Izquierda;
        public InputAction @Deseleccionar => m_Wrapper.m_Personaje_Deseleccionar;
        public InputAction @Jock2 => m_Wrapper.m_Personaje_Jock2;
        public InputAction @Inventario => m_Wrapper.m_Personaje_Inventario;
        public InputAction @MoveObjUpDown => m_Wrapper.m_Personaje_MoveObjUpDown;
        public InputActionMap Get() { return m_Wrapper.m_Personaje; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PersonajeActions set) { return set.Get(); }
        public void AddCallbacks(IPersonajeActions instance)
        {
            if (instance == null || m_Wrapper.m_PersonajeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PersonajeActionsCallbackInterfaces.Add(instance);
            @Seleccionar.started += instance.OnSeleccionar;
            @Seleccionar.performed += instance.OnSeleccionar;
            @Seleccionar.canceled += instance.OnSeleccionar;
            @Derecha.started += instance.OnDerecha;
            @Derecha.performed += instance.OnDerecha;
            @Derecha.canceled += instance.OnDerecha;
            @Izquierda.started += instance.OnIzquierda;
            @Izquierda.performed += instance.OnIzquierda;
            @Izquierda.canceled += instance.OnIzquierda;
            @Deseleccionar.started += instance.OnDeseleccionar;
            @Deseleccionar.performed += instance.OnDeseleccionar;
            @Deseleccionar.canceled += instance.OnDeseleccionar;
            @Jock2.started += instance.OnJock2;
            @Jock2.performed += instance.OnJock2;
            @Jock2.canceled += instance.OnJock2;
            @Inventario.started += instance.OnInventario;
            @Inventario.performed += instance.OnInventario;
            @Inventario.canceled += instance.OnInventario;
            @MoveObjUpDown.started += instance.OnMoveObjUpDown;
            @MoveObjUpDown.performed += instance.OnMoveObjUpDown;
            @MoveObjUpDown.canceled += instance.OnMoveObjUpDown;
        }

        private void UnregisterCallbacks(IPersonajeActions instance)
        {
            @Seleccionar.started -= instance.OnSeleccionar;
            @Seleccionar.performed -= instance.OnSeleccionar;
            @Seleccionar.canceled -= instance.OnSeleccionar;
            @Derecha.started -= instance.OnDerecha;
            @Derecha.performed -= instance.OnDerecha;
            @Derecha.canceled -= instance.OnDerecha;
            @Izquierda.started -= instance.OnIzquierda;
            @Izquierda.performed -= instance.OnIzquierda;
            @Izquierda.canceled -= instance.OnIzquierda;
            @Deseleccionar.started -= instance.OnDeseleccionar;
            @Deseleccionar.performed -= instance.OnDeseleccionar;
            @Deseleccionar.canceled -= instance.OnDeseleccionar;
            @Jock2.started -= instance.OnJock2;
            @Jock2.performed -= instance.OnJock2;
            @Jock2.canceled -= instance.OnJock2;
            @Inventario.started -= instance.OnInventario;
            @Inventario.performed -= instance.OnInventario;
            @Inventario.canceled -= instance.OnInventario;
            @MoveObjUpDown.started -= instance.OnMoveObjUpDown;
            @MoveObjUpDown.performed -= instance.OnMoveObjUpDown;
            @MoveObjUpDown.canceled -= instance.OnMoveObjUpDown;
        }

        public void RemoveCallbacks(IPersonajeActions instance)
        {
            if (m_Wrapper.m_PersonajeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPersonajeActions instance)
        {
            foreach (var item in m_Wrapper.m_PersonajeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PersonajeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PersonajeActions @Personaje => new PersonajeActions(this);
    public interface IJuegoActions
    {
        void OnAumentar(InputAction.CallbackContext context);
        void OnDisminuir(InputAction.CallbackContext context);
    }
    public interface IPersonajeActions
    {
        void OnSeleccionar(InputAction.CallbackContext context);
        void OnDerecha(InputAction.CallbackContext context);
        void OnIzquierda(InputAction.CallbackContext context);
        void OnDeseleccionar(InputAction.CallbackContext context);
        void OnJock2(InputAction.CallbackContext context);
        void OnInventario(InputAction.CallbackContext context);
        void OnMoveObjUpDown(InputAction.CallbackContext context);
    }
}
