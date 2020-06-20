// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/MenuPrincipal/Pruebas/MenuIA.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuIA : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuIA()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuIA"",
    ""maps"": [
        {
            ""name"": ""UI Controlls"",
            ""id"": ""57dee710-2630-45b9-ac3e-932ae9b16594"",
            ""actions"": [
                {
                    ""name"": ""MoveP1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""49f500d9-1db1-425c-a7e4-3b0f5138fcc0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveP2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""93ade506-1819-4485-a7db-d397bb449259"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AcceptP1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f0ace78e-9338-4343-b2f7-229c5d257dd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AcceptP2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e441bbf0-21ab-400f-b8aa-be0ab34b3751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReturnP1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""19abdd85-079f-408b-b9e1-f740323cf42b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReturnP2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""194eaab8-3608-4f16-b58e-c725b52b0147"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ba4e0c98-24c4-4708-8437-2728094f083a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""04994e9c-0f18-4957-9078-b29b889fd1a3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b9e770b2-1052-4f13-a98b-cb0f2318edc0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""de541122-75ed-4c99-94c7-401e621b5223"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""53400e48-617d-455e-bbe5-5e88f80e5844"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d0bcaddc-c441-464f-96d4-cba431dd1905"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""07c58560-494f-4093-baf0-2fc1f60f4c8f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Flechas"",
                    ""id"": ""542cba3d-19d0-43d9-bbad-395e2dfcbba3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aea18f91-c3ad-4548-ae30-f779c9b00bc0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d62de00b-0af4-437a-86f6-1371d28fce69"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6d1cf3a4-e43b-4e52-85ed-22a980c76172"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aae1ee46-a554-4130-9198-753841716c8a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a087e1ae-bb86-4bf9-9bde-4b6c18097a8d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AcceptP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86bf2466-ee00-44f3-91f7-4ab67a4445fb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AcceptP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3309921-1338-4647-9283-4d3394ef9a87"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReturnP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d5fadf7-cbf4-4651-b505-a44a703610c5"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReturnP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI Controlls
        m_UIControlls = asset.FindActionMap("UI Controlls", throwIfNotFound: true);
        m_UIControlls_MoveP1 = m_UIControlls.FindAction("MoveP1", throwIfNotFound: true);
        m_UIControlls_MoveP2 = m_UIControlls.FindAction("MoveP2", throwIfNotFound: true);
        m_UIControlls_AcceptP1 = m_UIControlls.FindAction("AcceptP1", throwIfNotFound: true);
        m_UIControlls_AcceptP2 = m_UIControlls.FindAction("AcceptP2", throwIfNotFound: true);
        m_UIControlls_ReturnP1 = m_UIControlls.FindAction("ReturnP1", throwIfNotFound: true);
        m_UIControlls_ReturnP2 = m_UIControlls.FindAction("ReturnP2", throwIfNotFound: true);
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

    // UI Controlls
    private readonly InputActionMap m_UIControlls;
    private IUIControllsActions m_UIControllsActionsCallbackInterface;
    private readonly InputAction m_UIControlls_MoveP1;
    private readonly InputAction m_UIControlls_MoveP2;
    private readonly InputAction m_UIControlls_AcceptP1;
    private readonly InputAction m_UIControlls_AcceptP2;
    private readonly InputAction m_UIControlls_ReturnP1;
    private readonly InputAction m_UIControlls_ReturnP2;
    public struct UIControllsActions
    {
        private @MenuIA m_Wrapper;
        public UIControllsActions(@MenuIA wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveP1 => m_Wrapper.m_UIControlls_MoveP1;
        public InputAction @MoveP2 => m_Wrapper.m_UIControlls_MoveP2;
        public InputAction @AcceptP1 => m_Wrapper.m_UIControlls_AcceptP1;
        public InputAction @AcceptP2 => m_Wrapper.m_UIControlls_AcceptP2;
        public InputAction @ReturnP1 => m_Wrapper.m_UIControlls_ReturnP1;
        public InputAction @ReturnP2 => m_Wrapper.m_UIControlls_ReturnP2;
        public InputActionMap Get() { return m_Wrapper.m_UIControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControllsActions set) { return set.Get(); }
        public void SetCallbacks(IUIControllsActions instance)
        {
            if (m_Wrapper.m_UIControllsActionsCallbackInterface != null)
            {
                @MoveP1.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP1;
                @MoveP1.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP1;
                @MoveP1.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP1;
                @MoveP2.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP2;
                @MoveP2.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP2;
                @MoveP2.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnMoveP2;
                @AcceptP1.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP1;
                @AcceptP1.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP1;
                @AcceptP1.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP1;
                @AcceptP2.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP2;
                @AcceptP2.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP2;
                @AcceptP2.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnAcceptP2;
                @ReturnP1.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP1;
                @ReturnP1.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP1;
                @ReturnP1.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP1;
                @ReturnP2.started -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP2;
                @ReturnP2.performed -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP2;
                @ReturnP2.canceled -= m_Wrapper.m_UIControllsActionsCallbackInterface.OnReturnP2;
            }
            m_Wrapper.m_UIControllsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveP1.started += instance.OnMoveP1;
                @MoveP1.performed += instance.OnMoveP1;
                @MoveP1.canceled += instance.OnMoveP1;
                @MoveP2.started += instance.OnMoveP2;
                @MoveP2.performed += instance.OnMoveP2;
                @MoveP2.canceled += instance.OnMoveP2;
                @AcceptP1.started += instance.OnAcceptP1;
                @AcceptP1.performed += instance.OnAcceptP1;
                @AcceptP1.canceled += instance.OnAcceptP1;
                @AcceptP2.started += instance.OnAcceptP2;
                @AcceptP2.performed += instance.OnAcceptP2;
                @AcceptP2.canceled += instance.OnAcceptP2;
                @ReturnP1.started += instance.OnReturnP1;
                @ReturnP1.performed += instance.OnReturnP1;
                @ReturnP1.canceled += instance.OnReturnP1;
                @ReturnP2.started += instance.OnReturnP2;
                @ReturnP2.performed += instance.OnReturnP2;
                @ReturnP2.canceled += instance.OnReturnP2;
            }
        }
    }
    public UIControllsActions @UIControlls => new UIControllsActions(this);
    public interface IUIControllsActions
    {
        void OnMoveP1(InputAction.CallbackContext context);
        void OnMoveP2(InputAction.CallbackContext context);
        void OnAcceptP1(InputAction.CallbackContext context);
        void OnAcceptP2(InputAction.CallbackContext context);
        void OnReturnP1(InputAction.CallbackContext context);
        void OnReturnP2(InputAction.CallbackContext context);
    }
}
