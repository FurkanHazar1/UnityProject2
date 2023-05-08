//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/Concretes/Inputs/DefaultAction.inputactions
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

namespace UnityProject2.Inputs
{
    public partial class @DefaultAction: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""03098a8e-7ef0-431c-98d2-131aea6b6f92"",
            ""actions"": [
                {
                    ""name"": ""ForceUP"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a0c8995c-3896-4cb0-a373-61b7ffee710b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6b91ce3-e13e-46c3-977e-16157ebaf4c7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUP = m_Rocket.FindAction("ForceUP", throwIfNotFound: true);
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
        private readonly InputAction m_Rocket_ForceUP;
        public struct RocketActions
        {
            private @DefaultAction m_Wrapper;
            public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUP => m_Wrapper.m_Rocket_ForceUP;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void AddCallbacks(IRocketActions instance)
            {
                if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
                @ForceUP.started += instance.OnForceUP;
                @ForceUP.performed += instance.OnForceUP;
                @ForceUP.canceled += instance.OnForceUP;
            }

            private void UnregisterCallbacks(IRocketActions instance)
            {
                @ForceUP.started -= instance.OnForceUP;
                @ForceUP.performed -= instance.OnForceUP;
                @ForceUP.canceled -= instance.OnForceUP;
            }

            public void RemoveCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IRocketActions instance)
            {
                foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUP(InputAction.CallbackContext context);
        }
    }
}
