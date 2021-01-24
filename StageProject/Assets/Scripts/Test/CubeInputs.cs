// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Test/CubeInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CubeInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CubeInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CubeInputs"",
    ""maps"": [
        {
            ""name"": ""cube"",
            ""id"": ""0543751f-62f6-4e44-908a-7a444c5ff328"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""2e45017b-7001-4875-9a4d-7ba2ea14bc6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c970eeb3-4841-4a00-9cfe-de4478295739"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""b44a2748-e003-4be3-870f-f94f98506a3f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shrink"",
                    ""type"": ""Button"",
                    ""id"": ""caf357da-4827-4b9d-91a2-eb19015aa141"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a5720e1b-ad19-4f9d-b477-6b73d068b087"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdb886bb-e69d-420a-9c27-cb1160e56c77"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b24fa72a-fc60-4af6-acff-c5073efb788e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6080ff9c-5063-4d33-b2fe-f0b414038ae1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // cube
        m_cube = asset.FindActionMap("cube", throwIfNotFound: true);
        m_cube_Grow = m_cube.FindAction("Grow", throwIfNotFound: true);
        m_cube_Move = m_cube.FindAction("Move", throwIfNotFound: true);
        m_cube_Rotation = m_cube.FindAction("Rotation", throwIfNotFound: true);
        m_cube_shrink = m_cube.FindAction("shrink", throwIfNotFound: true);
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

    // cube
    private readonly InputActionMap m_cube;
    private ICubeActions m_CubeActionsCallbackInterface;
    private readonly InputAction m_cube_Grow;
    private readonly InputAction m_cube_Move;
    private readonly InputAction m_cube_Rotation;
    private readonly InputAction m_cube_shrink;
    public struct CubeActions
    {
        private @CubeInputs m_Wrapper;
        public CubeActions(@CubeInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_cube_Grow;
        public InputAction @Move => m_Wrapper.m_cube_Move;
        public InputAction @Rotation => m_Wrapper.m_cube_Rotation;
        public InputAction @shrink => m_Wrapper.m_cube_shrink;
        public InputActionMap Get() { return m_Wrapper.m_cube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CubeActions set) { return set.Get(); }
        public void SetCallbacks(ICubeActions instance)
        {
            if (m_Wrapper.m_CubeActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnGrow;
                @Move.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnMove;
                @Rotation.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnRotation;
                @shrink.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnShrink;
                @shrink.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnShrink;
                @shrink.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnShrink;
            }
            m_Wrapper.m_CubeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @shrink.started += instance.OnShrink;
                @shrink.performed += instance.OnShrink;
                @shrink.canceled += instance.OnShrink;
            }
        }
    }
    public CubeActions @cube => new CubeActions(this);
    public interface ICubeActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
    }
}
