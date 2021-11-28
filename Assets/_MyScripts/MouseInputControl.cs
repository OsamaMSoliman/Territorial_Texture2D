// GENERATED AUTOMATICALLY FROM 'Assets/_MyScripts/MouseInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseInputControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseInputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseInputActions"",
    ""maps"": [
        {
            ""name"": ""MouseActionMap"",
            ""id"": ""1eb46ca1-e95a-4c6e-8332-5750095676fe"",
            ""actions"": [
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""0aa35a75-4d5c-45f2-90f0-122a208ca9d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""1c3127bb-35cf-46d6-9230-57e5b06d9c98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseWheel"",
                    ""type"": ""Value"",
                    ""id"": ""2a1be042-86f3-4b36-9c0d-aaabd328073d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Normalize(min=-120,max=120),Invert"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7e2e556-404d-4639-8c61-e396f85ac9f7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbad4f59-1999-47ef-9a51-5baa64b9db62"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a910db45-62d4-4a22-bc2c-329c34d6ded8"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseActionMap
        m_MouseActionMap = asset.FindActionMap("MouseActionMap", throwIfNotFound: true);
        m_MouseActionMap_MouseClick = m_MouseActionMap.FindAction("MouseClick", throwIfNotFound: true);
        m_MouseActionMap_MousePosition = m_MouseActionMap.FindAction("MousePosition", throwIfNotFound: true);
        m_MouseActionMap_MouseWheel = m_MouseActionMap.FindAction("MouseWheel", throwIfNotFound: true);
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

    // MouseActionMap
    private readonly InputActionMap m_MouseActionMap;
    private IMouseActionMapActions m_MouseActionMapActionsCallbackInterface;
    private readonly InputAction m_MouseActionMap_MouseClick;
    private readonly InputAction m_MouseActionMap_MousePosition;
    private readonly InputAction m_MouseActionMap_MouseWheel;
    public struct MouseActionMapActions
    {
        private @MouseInputControl m_Wrapper;
        public MouseActionMapActions(@MouseInputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClick => m_Wrapper.m_MouseActionMap_MouseClick;
        public InputAction @MousePosition => m_Wrapper.m_MouseActionMap_MousePosition;
        public InputAction @MouseWheel => m_Wrapper.m_MouseActionMap_MouseWheel;
        public InputActionMap Get() { return m_Wrapper.m_MouseActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActionMapActions instance)
        {
            if (m_Wrapper.m_MouseActionMapActionsCallbackInterface != null)
            {
                @MouseClick.started -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseClick;
                @MousePosition.started -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMousePosition;
                @MouseWheel.started -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.performed -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.canceled -= m_Wrapper.m_MouseActionMapActionsCallbackInterface.OnMouseWheel;
            }
            m_Wrapper.m_MouseActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MouseWheel.started += instance.OnMouseWheel;
                @MouseWheel.performed += instance.OnMouseWheel;
                @MouseWheel.canceled += instance.OnMouseWheel;
            }
        }
    }
    public MouseActionMapActions @MouseActionMap => new MouseActionMapActions(this);
    public interface IMouseActionMapActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMouseWheel(InputAction.CallbackContext context);
    }
}
