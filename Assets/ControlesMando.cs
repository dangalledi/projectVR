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
                    ""name"": ""Arriba"",
                    ""type"": ""Button"",
                    ""id"": ""213da576-178a-44c6-b03e-d182c2bad703"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Abajo"",
                    ""type"": ""Button"",
                    ""id"": ""fa9e1e15-b183-489d-b92d-f701b3b59a2b"",
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eda4d834-00cf-4397-bd88-271d1f857d48"",
                    ""path"": ""<DualSenseGamepadHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b0e8568-e4c8-4b4b-8b0e-0d8ac79f106e"",
                    ""path"": ""<DualSenseGamepadHID>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arriba"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c015ca7-656c-4ea4-88c6-36533bbcd976"",
                    ""path"": ""<DualSenseGamepadHID>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Abajo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d94af1e8-9df9-4dea-a85c-2d3e5c1c0c1b"",
                    ""path"": ""<DualSenseGamepadHID>/dpad/right"",
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
                    ""path"": ""<DualSenseGamepadHID>/dpad/left"",
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
                    ""path"": ""<DualSenseGamepadHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deseleccionar"",
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
        m_Personaje_Arriba = m_Personaje.FindAction("Arriba", throwIfNotFound: true);
        m_Personaje_Abajo = m_Personaje.FindAction("Abajo", throwIfNotFound: true);
        m_Personaje_Derecha = m_Personaje.FindAction("Derecha", throwIfNotFound: true);
        m_Personaje_Izquierda = m_Personaje.FindAction("Izquierda", throwIfNotFound: true);
        m_Personaje_Deseleccionar = m_Personaje.FindAction("Deseleccionar", throwIfNotFound: true);
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
    private readonly InputAction m_Personaje_Arriba;
    private readonly InputAction m_Personaje_Abajo;
    private readonly InputAction m_Personaje_Derecha;
    private readonly InputAction m_Personaje_Izquierda;
    private readonly InputAction m_Personaje_Deseleccionar;
    public struct PersonajeActions
    {
        private @ControlesMando m_Wrapper;
        public PersonajeActions(@ControlesMando wrapper) { m_Wrapper = wrapper; }
        public InputAction @Seleccionar => m_Wrapper.m_Personaje_Seleccionar;
        public InputAction @Arriba => m_Wrapper.m_Personaje_Arriba;
        public InputAction @Abajo => m_Wrapper.m_Personaje_Abajo;
        public InputAction @Derecha => m_Wrapper.m_Personaje_Derecha;
        public InputAction @Izquierda => m_Wrapper.m_Personaje_Izquierda;
        public InputAction @Deseleccionar => m_Wrapper.m_Personaje_Deseleccionar;
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
            @Arriba.started += instance.OnArriba;
            @Arriba.performed += instance.OnArriba;
            @Arriba.canceled += instance.OnArriba;
            @Abajo.started += instance.OnAbajo;
            @Abajo.performed += instance.OnAbajo;
            @Abajo.canceled += instance.OnAbajo;
            @Derecha.started += instance.OnDerecha;
            @Derecha.performed += instance.OnDerecha;
            @Derecha.canceled += instance.OnDerecha;
            @Izquierda.started += instance.OnIzquierda;
            @Izquierda.performed += instance.OnIzquierda;
            @Izquierda.canceled += instance.OnIzquierda;
            @Deseleccionar.started += instance.OnDeseleccionar;
            @Deseleccionar.performed += instance.OnDeseleccionar;
            @Deseleccionar.canceled += instance.OnDeseleccionar;
        }

        private void UnregisterCallbacks(IPersonajeActions instance)
        {
            @Seleccionar.started -= instance.OnSeleccionar;
            @Seleccionar.performed -= instance.OnSeleccionar;
            @Seleccionar.canceled -= instance.OnSeleccionar;
            @Arriba.started -= instance.OnArriba;
            @Arriba.performed -= instance.OnArriba;
            @Arriba.canceled -= instance.OnArriba;
            @Abajo.started -= instance.OnAbajo;
            @Abajo.performed -= instance.OnAbajo;
            @Abajo.canceled -= instance.OnAbajo;
            @Derecha.started -= instance.OnDerecha;
            @Derecha.performed -= instance.OnDerecha;
            @Derecha.canceled -= instance.OnDerecha;
            @Izquierda.started -= instance.OnIzquierda;
            @Izquierda.performed -= instance.OnIzquierda;
            @Izquierda.canceled -= instance.OnIzquierda;
            @Deseleccionar.started -= instance.OnDeseleccionar;
            @Deseleccionar.performed -= instance.OnDeseleccionar;
            @Deseleccionar.canceled -= instance.OnDeseleccionar;
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
        void OnArriba(InputAction.CallbackContext context);
        void OnAbajo(InputAction.CallbackContext context);
        void OnDerecha(InputAction.CallbackContext context);
        void OnIzquierda(InputAction.CallbackContext context);
        void OnDeseleccionar(InputAction.CallbackContext context);
    }
}
