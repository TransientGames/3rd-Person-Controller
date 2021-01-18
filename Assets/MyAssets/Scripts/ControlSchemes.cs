// GENERATED AUTOMATICALLY FROM 'Assets/MyAssets/Scripts/ControlSchemes.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlSchemes : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlSchemes()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlSchemes"",
    ""maps"": [
        {
            ""name"": ""Walk"",
            ""id"": ""72d3c574-6fdf-41fd-964f-e3e6a53763cf"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""179919ca-847b-45b0-90a9-d765eff71e77"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""86517165-0bce-4d83-a173-0e8ac45564ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9f9846cb-5119-42d5-83b5-b54e4630a24b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""1a721ba8-6dcf-4db6-9a1e-da82f3f138ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c9ad472a-13c7-461d-a190-1df40f9238dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TogglePerspective"",
                    ""type"": ""Button"",
                    ""id"": ""a72aab3a-b6af-4255-9f31-771d4ce8d5a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""daf74a27-6e00-424b-8f8b-30377d1f21b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""3df25fc2-6c09-4a18-b338-36f6f51050c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e94cf11-0548-4d76-b6ff-3417e01f1736"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""88846e80-0f3b-41e7-b733-bc9f4d89b16e"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""232112bc-5431-443d-91ca-c818fca5ac1a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d60ce353-b46b-4a09-b599-6870a3e53199"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fc9042ad-fb07-447d-b83c-99fb53ea8c82"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0d2bb217-78b1-4792-942c-46d47cdf74dd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2ec63a1f-21b3-43b5-94df-b2915f963773"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ff72e64-45e2-4982-87f5-3bbb500a6ec4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17983a0d-a8cf-43a5-85be-d35774169c84"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c040c21-a766-4f8b-8056-66ab35fd0ad8"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bd1d887-38d1-4f0f-b4f7-8b4b078a8a9a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TogglePerspective"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53f07f4e-895f-4956-868b-9d5e5b1cfb15"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a2b2d0e-c10c-49eb-b97e-5e87cf2deabd"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ac13cca-364c-4044-be6f-ab0fbbf7a34e"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walk
        m_Walk = asset.FindActionMap("Walk", throwIfNotFound: true);
        m_Walk_Move = m_Walk.FindAction("Move", throwIfNotFound: true);
        m_Walk_Aim = m_Walk.FindAction("Aim", throwIfNotFound: true);
        m_Walk_Jump = m_Walk.FindAction("Jump", throwIfNotFound: true);
        m_Walk_Sprint = m_Walk.FindAction("Sprint", throwIfNotFound: true);
        m_Walk_Crouch = m_Walk.FindAction("Crouch", throwIfNotFound: true);
        m_Walk_TogglePerspective = m_Walk.FindAction("TogglePerspective", throwIfNotFound: true);
        m_Walk_PrimaryAttack = m_Walk.FindAction("PrimaryAttack", throwIfNotFound: true);
        m_Walk_SecondaryAttack = m_Walk.FindAction("SecondaryAttack", throwIfNotFound: true);
        m_Walk_Scroll = m_Walk.FindAction("Scroll", throwIfNotFound: true);
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

    // Walk
    private readonly InputActionMap m_Walk;
    private IWalkActions m_WalkActionsCallbackInterface;
    private readonly InputAction m_Walk_Move;
    private readonly InputAction m_Walk_Aim;
    private readonly InputAction m_Walk_Jump;
    private readonly InputAction m_Walk_Sprint;
    private readonly InputAction m_Walk_Crouch;
    private readonly InputAction m_Walk_TogglePerspective;
    private readonly InputAction m_Walk_PrimaryAttack;
    private readonly InputAction m_Walk_SecondaryAttack;
    private readonly InputAction m_Walk_Scroll;
    public struct WalkActions
    {
        private @ControlSchemes m_Wrapper;
        public WalkActions(@ControlSchemes wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Walk_Move;
        public InputAction @Aim => m_Wrapper.m_Walk_Aim;
        public InputAction @Jump => m_Wrapper.m_Walk_Jump;
        public InputAction @Sprint => m_Wrapper.m_Walk_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Walk_Crouch;
        public InputAction @TogglePerspective => m_Wrapper.m_Walk_TogglePerspective;
        public InputAction @PrimaryAttack => m_Wrapper.m_Walk_PrimaryAttack;
        public InputAction @SecondaryAttack => m_Wrapper.m_Walk_SecondaryAttack;
        public InputAction @Scroll => m_Wrapper.m_Walk_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_Walk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkActions set) { return set.Get(); }
        public void SetCallbacks(IWalkActions instance)
        {
            if (m_Wrapper.m_WalkActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Jump.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @TogglePerspective.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @TogglePerspective.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @TogglePerspective.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @PrimaryAttack.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnPrimaryAttack;
                @PrimaryAttack.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnPrimaryAttack;
                @PrimaryAttack.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnPrimaryAttack;
                @SecondaryAttack.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnSecondaryAttack;
                @SecondaryAttack.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnSecondaryAttack;
                @SecondaryAttack.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnSecondaryAttack;
                @Scroll.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_WalkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @TogglePerspective.started += instance.OnTogglePerspective;
                @TogglePerspective.performed += instance.OnTogglePerspective;
                @TogglePerspective.canceled += instance.OnTogglePerspective;
                @PrimaryAttack.started += instance.OnPrimaryAttack;
                @PrimaryAttack.performed += instance.OnPrimaryAttack;
                @PrimaryAttack.canceled += instance.OnPrimaryAttack;
                @SecondaryAttack.started += instance.OnSecondaryAttack;
                @SecondaryAttack.performed += instance.OnSecondaryAttack;
                @SecondaryAttack.canceled += instance.OnSecondaryAttack;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public WalkActions @Walk => new WalkActions(this);
    public interface IWalkActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnTogglePerspective(InputAction.CallbackContext context);
        void OnPrimaryAttack(InputAction.CallbackContext context);
        void OnSecondaryAttack(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}
