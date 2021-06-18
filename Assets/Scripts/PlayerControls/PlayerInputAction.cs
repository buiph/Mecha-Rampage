// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""MechControls"",
            ""id"": ""0c4e29c9-7756-4f87-b83b-2c59adb6bd4e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""77811f97-acf2-4597-a5f2-16a89f7ccc55"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f621d262-e904-4b3f-b998-b28762b47409"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unequip"",
                    ""type"": ""Button"",
                    ""id"": ""823757f5-dc26-4e12-9f92-302ab99641bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""437e1303-302c-43a8-a0bc-0d57f502dcc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""efcbb343-ab4e-45dc-8ad1-92e0143d8030"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ChangeActiveWeapon"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4f34b6ab-87bc-4e78-8606-46c9f80edbd3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""0cf69756-76d9-4fc8-b359-a918ac2021a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""57802981-39a8-4da4-9801-552fdc521cbe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""821146a7-dca9-4152-9a8a-85d6c937c2aa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ba246a1-cd92-4e78-acb1-03d3404a83a6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3847c0b8-9ff2-4594-8deb-fdcc8bf584d1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""13fd8cc4-7c11-4008-941a-b5c9e52b0d5e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94d5f394-2b2b-4d7f-8f3a-1d025a7a6291"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""071d9a59-eb11-46b8-9b2a-10be60a9a66f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb5f97cc-6ea4-4a8c-8598-57e77e1d4d98"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fdcfcf8-eff7-480c-a8a1-f6344efd654b"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fc8d01b-d5f2-4921-8acf-211f94161eb6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04905809-0b46-499c-afc6-058110f83d7d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61293c03-4885-441d-bb7d-6f29932b90cf"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ChangeActiveWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""05055684-a4f2-41ff-b503-c0009555e27e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeActiveWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fe6684ee-23b6-4a30-be13-ea9e39876ceb"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeActiveWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""64e101d5-09e0-447f-9fa6-936ab70cd0e7"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeActiveWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c26f3ef4-dc3f-4249-ae20-ed2bc253ca98"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Unequip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameControls"",
            ""id"": ""e3cdb094-b16f-4b70-9ddf-44012dc3890c"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3fab0f4f-4ee2-461e-b8d7-49f132ff01e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ec4d4f8-3a91-4ccb-b811-91e8fd0436cb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2b4e790-1327-4443-bfba-8b97d9f83fdf"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MechControls
        m_MechControls = asset.FindActionMap("MechControls", throwIfNotFound: true);
        m_MechControls_Move = m_MechControls.FindAction("Move", throwIfNotFound: true);
        m_MechControls_Look = m_MechControls.FindAction("Look", throwIfNotFound: true);
        m_MechControls_Unequip = m_MechControls.FindAction("Unequip", throwIfNotFound: true);
        m_MechControls_Interact = m_MechControls.FindAction("Interact", throwIfNotFound: true);
        m_MechControls_Shoot = m_MechControls.FindAction("Shoot", throwIfNotFound: true);
        m_MechControls_ChangeActiveWeapon = m_MechControls.FindAction("ChangeActiveWeapon", throwIfNotFound: true);
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Pause = m_GameControls.FindAction("Pause", throwIfNotFound: true);
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

    // MechControls
    private readonly InputActionMap m_MechControls;
    private IMechControlsActions m_MechControlsActionsCallbackInterface;
    private readonly InputAction m_MechControls_Move;
    private readonly InputAction m_MechControls_Look;
    private readonly InputAction m_MechControls_Unequip;
    private readonly InputAction m_MechControls_Interact;
    private readonly InputAction m_MechControls_Shoot;
    private readonly InputAction m_MechControls_ChangeActiveWeapon;
    public struct MechControlsActions
    {
        private @PlayerInputAction m_Wrapper;
        public MechControlsActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MechControls_Move;
        public InputAction @Look => m_Wrapper.m_MechControls_Look;
        public InputAction @Unequip => m_Wrapper.m_MechControls_Unequip;
        public InputAction @Interact => m_Wrapper.m_MechControls_Interact;
        public InputAction @Shoot => m_Wrapper.m_MechControls_Shoot;
        public InputAction @ChangeActiveWeapon => m_Wrapper.m_MechControls_ChangeActiveWeapon;
        public InputActionMap Get() { return m_Wrapper.m_MechControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MechControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMechControlsActions instance)
        {
            if (m_Wrapper.m_MechControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnLook;
                @Unequip.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnUnequip;
                @Unequip.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnUnequip;
                @Unequip.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnUnequip;
                @Interact.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnInteract;
                @Shoot.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnShoot;
                @ChangeActiveWeapon.started -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnChangeActiveWeapon;
                @ChangeActiveWeapon.performed -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnChangeActiveWeapon;
                @ChangeActiveWeapon.canceled -= m_Wrapper.m_MechControlsActionsCallbackInterface.OnChangeActiveWeapon;
            }
            m_Wrapper.m_MechControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Unequip.started += instance.OnUnequip;
                @Unequip.performed += instance.OnUnequip;
                @Unequip.canceled += instance.OnUnequip;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @ChangeActiveWeapon.started += instance.OnChangeActiveWeapon;
                @ChangeActiveWeapon.performed += instance.OnChangeActiveWeapon;
                @ChangeActiveWeapon.canceled += instance.OnChangeActiveWeapon;
            }
        }
    }
    public MechControlsActions @MechControls => new MechControlsActions(this);

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Pause;
    public struct GameControlsActions
    {
        private @PlayerInputAction m_Wrapper;
        public GameControlsActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_GameControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMechControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnUnequip(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnChangeActiveWeapon(InputAction.CallbackContext context);
    }
    public interface IGameControlsActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
