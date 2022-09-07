//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c749843d-81c5-48ab-ac4d-1a6e3dd1ac84"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""16e3e7f1-2141-4880-b56d-5259b35f12f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""bd89b691-7f35-4a4b-b2df-4432d0d8dacb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f8bb97e3-db9d-40dd-af3e-cc7113276625"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slow Attack"",
                    ""type"": ""Button"",
                    ""id"": ""199e0712-7519-4808-bc5f-2e5fdecd3924"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Throw Knife"",
                    ""type"": ""Button"",
                    ""id"": ""30e3493c-92aa-41d1-80ca-3f9bdab634d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Light Attack Left"",
                    ""type"": ""Button"",
                    ""id"": ""1a934c8e-ab00-42af-8774-1433eadb4694"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Light Attack Right"",
                    ""type"": ""Button"",
                    ""id"": ""4dafb3f4-7df2-4cac-80b4-d4e7eeb94693"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d8110f12-6bf9-4dcc-87d4-5523f26a4469"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3380d34e-0370-4436-9978-d825f63175d7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e05327f6-dcdf-4b3b-88dc-8bf0921b841f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""03bf3e60-f512-4fa2-b446-e2b4f2f2eb65"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec503cb6-6178-49e9-8e2e-92fb2041b1ca"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6fd543b7-7160-412d-98c8-ffa328e9554b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""93e703f9-878b-46b0-bbee-b8d7f43eb880"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""935d3f73-6ee6-4c9f-b776-7e452cf1b9f4"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Slow Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b51999db-883e-433c-a4d2-e20aa026729e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Throw Knife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca500ea1-d50b-4ef5-bc2e-6fafd4413eac"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Light Attack Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""027532b0-d1eb-4912-87ee-1a0061571da4"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Light Attack Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_SlowAttack = m_Player.FindAction("Slow Attack", throwIfNotFound: true);
        m_Player_ThrowKnife = m_Player.FindAction("Throw Knife", throwIfNotFound: true);
        m_Player_LightAttackLeft = m_Player.FindAction("Light Attack Left", throwIfNotFound: true);
        m_Player_LightAttackRight = m_Player.FindAction("Light Attack Right", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_SlowAttack;
    private readonly InputAction m_Player_ThrowKnife;
    private readonly InputAction m_Player_LightAttackLeft;
    private readonly InputAction m_Player_LightAttackRight;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @SlowAttack => m_Wrapper.m_Player_SlowAttack;
        public InputAction @ThrowKnife => m_Wrapper.m_Player_ThrowKnife;
        public InputAction @LightAttackLeft => m_Wrapper.m_Player_LightAttackLeft;
        public InputAction @LightAttackRight => m_Wrapper.m_Player_LightAttackRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @SlowAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowAttack;
                @SlowAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowAttack;
                @SlowAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlowAttack;
                @ThrowKnife.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowKnife;
                @ThrowKnife.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowKnife;
                @ThrowKnife.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowKnife;
                @LightAttackLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackLeft;
                @LightAttackLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackLeft;
                @LightAttackLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackLeft;
                @LightAttackRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackRight;
                @LightAttackRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackRight;
                @LightAttackRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLightAttackRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @SlowAttack.started += instance.OnSlowAttack;
                @SlowAttack.performed += instance.OnSlowAttack;
                @SlowAttack.canceled += instance.OnSlowAttack;
                @ThrowKnife.started += instance.OnThrowKnife;
                @ThrowKnife.performed += instance.OnThrowKnife;
                @ThrowKnife.canceled += instance.OnThrowKnife;
                @LightAttackLeft.started += instance.OnLightAttackLeft;
                @LightAttackLeft.performed += instance.OnLightAttackLeft;
                @LightAttackLeft.canceled += instance.OnLightAttackLeft;
                @LightAttackRight.started += instance.OnLightAttackRight;
                @LightAttackRight.performed += instance.OnLightAttackRight;
                @LightAttackRight.canceled += instance.OnLightAttackRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSlowAttack(InputAction.CallbackContext context);
        void OnThrowKnife(InputAction.CallbackContext context);
        void OnLightAttackLeft(InputAction.CallbackContext context);
        void OnLightAttackRight(InputAction.CallbackContext context);
    }
}
