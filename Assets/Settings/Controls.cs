// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6e634086-f920-46cf-8d4c-e2e3f6bf9209"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a7da3466-b450-4a6a-b2be-a63cca7aa5b0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""722a8f61-d903-48a0-94d7-9b037e8e5201"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1d7a39c0-fd84-4aef-8810-2c91228e168b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""20f871aa-3776-496e-b612-1e21c4ad839b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugReload"",
                    ""type"": ""Button"",
                    ""id"": ""7f28f238-abaf-41ae-b057-e380abad1b80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugAir"",
                    ""type"": ""Button"",
                    ""id"": ""6837ef8c-06ff-4019-9e78-223012c6d0cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugFire"",
                    ""type"": ""Button"",
                    ""id"": ""1132c7c7-469f-4e0d-83f5-2bb443ce366d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugEarth"",
                    ""type"": ""Button"",
                    ""id"": ""14c1b145-bf98-44f1-b5af-b59c69a22ea7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugWater"",
                    ""type"": ""Button"",
                    ""id"": ""c25625a8-eb54-4e3f-b0a1-3c657d7e14cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugReset"",
                    ""type"": ""Button"",
                    ""id"": ""5160399b-2856-4572-be01-3a5acee62fe5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuA"",
                    ""type"": ""Button"",
                    ""id"": ""09766ec3-f04d-41dc-af26-fc38afd1c63d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuB"",
                    ""type"": ""Button"",
                    ""id"": ""38e75ffe-db80-4be1-968d-72c7f10aa4d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuX"",
                    ""type"": ""Button"",
                    ""id"": ""6e79a2c7-b0ec-4543-9b53-b9aadf7f8a51"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuY"",
                    ""type"": ""Button"",
                    ""id"": ""8898212f-962d-4e48-b151-8a64a80a142b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1045c23d-1ec6-4799-ab9a-f45f4de50bae"",
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
                    ""id"": ""5cd78003-5fee-4176-a204-85a85092ef01"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f9124121-3691-4a42-8417-e6bd1f865de2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""180b7c26-070f-4e78-88bb-2e8aa1bcd010"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f1ae58da-c4b6-4a31-86f1-b550e1769fe1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1414f86-caa4-47e6-8869-5685f7cdf2b5"",
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
                    ""id"": ""fa343517-56fb-41bb-aaac-6b9b82c3b6cd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97031120-9f61-429e-b7e0-d8f6545ef51e"",
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
                    ""id"": ""883d306d-fa99-4067-b116-c00b7cc0d316"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f52392-eacd-45e2-8609-e47a1be2147d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c84fd62-9586-424b-97a7-4f12b9c96eb5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83a815df-bc0a-4474-b9bf-ea298f432db2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""794c8b52-503f-4c1e-9558-ab1d51fb3cc7"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""DebugReload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c634c5e4-317e-4a9f-ba9f-8f823c96bd67"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugReload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54ad0925-9eaf-4061-b1f6-e68203d28a55"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""DebugAir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""734a6c8c-fcff-487d-b2ed-083d5dadaad0"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""DebugFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6587190b-7d11-4c02-9c3b-550cdd2eb178"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""DebugEarth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""311484f3-ff9b-4af6-9e4a-541421298f0d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""DebugWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f6962fa-89c8-4297-8ce5-9b1f64a4bee7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugAir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38a460f1-0380-4b95-8668-4756a7c20e1c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58085b0b-03db-4787-bb06-92c467500a97"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugEarth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aea1467-6c92-42dd-9ab6-65c834089e22"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44815fd0-d6ee-41cb-b345-cebab9cb40c2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse;Gamepad"",
                    ""action"": ""DebugReset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0c78dde-96c2-4d85-92e6-13a4b765c473"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugReset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04ad86ff-a753-4484-8429-e35895e8ea75"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e0c7868-aad1-48bb-b4de-a6d30d4ddb11"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa675002-401b-49ae-b731-e2593ac9fb5c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce492ee3-af5e-4555-ab90-94ed7cece34e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_DebugReload = m_Player.FindAction("DebugReload", throwIfNotFound: true);
        m_Player_DebugAir = m_Player.FindAction("DebugAir", throwIfNotFound: true);
        m_Player_DebugFire = m_Player.FindAction("DebugFire", throwIfNotFound: true);
        m_Player_DebugEarth = m_Player.FindAction("DebugEarth", throwIfNotFound: true);
        m_Player_DebugWater = m_Player.FindAction("DebugWater", throwIfNotFound: true);
        m_Player_DebugReset = m_Player.FindAction("DebugReset", throwIfNotFound: true);
        m_Player_MenuA = m_Player.FindAction("MenuA", throwIfNotFound: true);
        m_Player_MenuB = m_Player.FindAction("MenuB", throwIfNotFound: true);
        m_Player_MenuX = m_Player.FindAction("MenuX", throwIfNotFound: true);
        m_Player_MenuY = m_Player.FindAction("MenuY", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_DebugReload;
    private readonly InputAction m_Player_DebugAir;
    private readonly InputAction m_Player_DebugFire;
    private readonly InputAction m_Player_DebugEarth;
    private readonly InputAction m_Player_DebugWater;
    private readonly InputAction m_Player_DebugReset;
    private readonly InputAction m_Player_MenuA;
    private readonly InputAction m_Player_MenuB;
    private readonly InputAction m_Player_MenuX;
    private readonly InputAction m_Player_MenuY;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @DebugReload => m_Wrapper.m_Player_DebugReload;
        public InputAction @DebugAir => m_Wrapper.m_Player_DebugAir;
        public InputAction @DebugFire => m_Wrapper.m_Player_DebugFire;
        public InputAction @DebugEarth => m_Wrapper.m_Player_DebugEarth;
        public InputAction @DebugWater => m_Wrapper.m_Player_DebugWater;
        public InputAction @DebugReset => m_Wrapper.m_Player_DebugReset;
        public InputAction @MenuA => m_Wrapper.m_Player_MenuA;
        public InputAction @MenuB => m_Wrapper.m_Player_MenuB;
        public InputAction @MenuX => m_Wrapper.m_Player_MenuX;
        public InputAction @MenuY => m_Wrapper.m_Player_MenuY;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @DebugReload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReload;
                @DebugReload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReload;
                @DebugReload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReload;
                @DebugAir.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugAir;
                @DebugAir.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugAir;
                @DebugAir.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugAir;
                @DebugFire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugFire;
                @DebugFire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugFire;
                @DebugFire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugFire;
                @DebugEarth.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugEarth;
                @DebugEarth.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugEarth;
                @DebugEarth.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugEarth;
                @DebugWater.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugWater;
                @DebugWater.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugWater;
                @DebugWater.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugWater;
                @DebugReset.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReset;
                @DebugReset.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReset;
                @DebugReset.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugReset;
                @MenuA.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuA;
                @MenuA.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuA;
                @MenuA.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuA;
                @MenuB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuB;
                @MenuB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuB;
                @MenuB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuB;
                @MenuX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuX;
                @MenuX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuX;
                @MenuX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuX;
                @MenuY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuY;
                @MenuY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuY;
                @MenuY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuY;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @DebugReload.started += instance.OnDebugReload;
                @DebugReload.performed += instance.OnDebugReload;
                @DebugReload.canceled += instance.OnDebugReload;
                @DebugAir.started += instance.OnDebugAir;
                @DebugAir.performed += instance.OnDebugAir;
                @DebugAir.canceled += instance.OnDebugAir;
                @DebugFire.started += instance.OnDebugFire;
                @DebugFire.performed += instance.OnDebugFire;
                @DebugFire.canceled += instance.OnDebugFire;
                @DebugEarth.started += instance.OnDebugEarth;
                @DebugEarth.performed += instance.OnDebugEarth;
                @DebugEarth.canceled += instance.OnDebugEarth;
                @DebugWater.started += instance.OnDebugWater;
                @DebugWater.performed += instance.OnDebugWater;
                @DebugWater.canceled += instance.OnDebugWater;
                @DebugReset.started += instance.OnDebugReset;
                @DebugReset.performed += instance.OnDebugReset;
                @DebugReset.canceled += instance.OnDebugReset;
                @MenuA.started += instance.OnMenuA;
                @MenuA.performed += instance.OnMenuA;
                @MenuA.canceled += instance.OnMenuA;
                @MenuB.started += instance.OnMenuB;
                @MenuB.performed += instance.OnMenuB;
                @MenuB.canceled += instance.OnMenuB;
                @MenuX.started += instance.OnMenuX;
                @MenuX.performed += instance.OnMenuX;
                @MenuX.canceled += instance.OnMenuX;
                @MenuY.started += instance.OnMenuY;
                @MenuY.performed += instance.OnMenuY;
                @MenuY.canceled += instance.OnMenuY;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
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
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnDebugReload(InputAction.CallbackContext context);
        void OnDebugAir(InputAction.CallbackContext context);
        void OnDebugFire(InputAction.CallbackContext context);
        void OnDebugEarth(InputAction.CallbackContext context);
        void OnDebugWater(InputAction.CallbackContext context);
        void OnDebugReset(InputAction.CallbackContext context);
        void OnMenuA(InputAction.CallbackContext context);
        void OnMenuB(InputAction.CallbackContext context);
        void OnMenuX(InputAction.CallbackContext context);
        void OnMenuY(InputAction.CallbackContext context);
    }
}
