// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Playermap"",
            ""id"": ""9bc0b61a-9bc5-46ea-9499-086cfc042264"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""21720a45-4226-41b2-b427-1abb3000b20e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""f7e598ac-9941-4175-bac9-e7722a796ee3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Takedown"",
                    ""type"": ""Button"",
                    ""id"": ""667e4f7f-c500-45a2-8a48-481160577fff"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""b1324301-e105-47c3-8c94-da7fa5ce99f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dcd61829-e7c3-46f6-8ae6-f1189bcf49e1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""29e43f24-4a0d-4b2e-a85e-e7ef6c6a9580"",
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
                    ""id"": ""88c45c10-125e-4d25-937f-c916a70c787e"",
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
                    ""id"": ""21913dfb-2ef2-417f-9ebf-54cd53aa7603"",
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
                    ""id"": ""de599712-550c-401c-9444-f47712a1b97c"",
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
                    ""id"": ""1a7ad86f-fe90-405e-b8df-6cb5dabc2a41"",
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
                    ""id"": ""5497998e-ded0-44b0-9c19-91a6a161b3cf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97049e6c-d24c-4ef0-94fb-396faba94192"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5c30799-f9ca-450d-801b-96cb2dc802cb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Takedown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b88f967b-adeb-473b-8d07-b492dfca9057"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Takedown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40046e80-9cc2-468f-bf13-52ca60410c3c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""961280fa-20b0-487e-8316-21accc9e7653"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Playermap
        m_Playermap = asset.FindActionMap("Playermap", throwIfNotFound: true);
        m_Playermap_Move = m_Playermap.FindAction("Move", throwIfNotFound: true);
        m_Playermap_Dash = m_Playermap.FindAction("Dash", throwIfNotFound: true);
        m_Playermap_Takedown = m_Playermap.FindAction("Takedown", throwIfNotFound: true);
        m_Playermap_Restart = m_Playermap.FindAction("Restart", throwIfNotFound: true);
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

    // Playermap
    private readonly InputActionMap m_Playermap;
    private IPlayermapActions m_PlayermapActionsCallbackInterface;
    private readonly InputAction m_Playermap_Move;
    private readonly InputAction m_Playermap_Dash;
    private readonly InputAction m_Playermap_Takedown;
    private readonly InputAction m_Playermap_Restart;
    public struct PlayermapActions
    {
        private @PlayerControl m_Wrapper;
        public PlayermapActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Playermap_Move;
        public InputAction @Dash => m_Wrapper.m_Playermap_Dash;
        public InputAction @Takedown => m_Wrapper.m_Playermap_Takedown;
        public InputAction @Restart => m_Wrapper.m_Playermap_Restart;
        public InputActionMap Get() { return m_Wrapper.m_Playermap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayermapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayermapActions instance)
        {
            if (m_Wrapper.m_PlayermapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnMove;
                @Dash.started -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnDash;
                @Takedown.started -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnTakedown;
                @Takedown.performed -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnTakedown;
                @Takedown.canceled -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnTakedown;
                @Restart.started -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_PlayermapActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_PlayermapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Takedown.started += instance.OnTakedown;
                @Takedown.performed += instance.OnTakedown;
                @Takedown.canceled += instance.OnTakedown;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public PlayermapActions @Playermap => new PlayermapActions(this);
    public interface IPlayermapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnTakedown(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
