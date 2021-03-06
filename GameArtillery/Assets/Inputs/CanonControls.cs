// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/CanonControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CanonControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CanonControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CanonControls"",
    ""maps"": [
        {
            ""name"": ""Canon"",
            ""id"": ""cb03118a-62be-4027-a4a4-138859e89a26"",
            ""actions"": [
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""7e3b7e1b-1829-43b7-b95e-389b77287bee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""be74fc1a-3728-44d8-b9e7-e06c779a2a91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModificarFuerza"",
                    ""type"": ""Button"",
                    ""id"": ""82a4de7d-620e-4e9a-9d69-3c25db90877b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""65132af7-3445-4a00-a673-95e9c3b722a0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56e9789a-d544-47a9-ae33-252c43a1a675"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""6c1b2e7d-e9b5-47e3-bc8b-57a50323d738"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2b93a537-0bb1-420a-be92-10176a3a93b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80d5ee1e-7ceb-4717-9f2e-deaeda100fe9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""9ac77ef4-def9-4dd7-bae9-8ba5a89cb2ba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8bbe30c5-fd64-462e-8d7f-d680d1e05bbb"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""63e4da7c-0940-4d0b-825b-dc6c214aeba2"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""9f544b40-9014-4175-a45d-be2f44dc052a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3f417dd4-f3cb-4c5b-a984-02a64b200feb"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""58d94bd3-2794-4132-942f-fed2d784882b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""d55b5fd6-52d5-4a95-affc-7873c67fb03d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a83e0bde-f377-427c-a3bd-fef1ca4c52e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ab3669af-bd26-4c4f-b53c-21758a59d51d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generica"",
            ""bindingGroup"": ""Generica"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_Apuntar = m_Canon.FindAction("Apuntar", throwIfNotFound: true);
        m_Canon_Disparar = m_Canon.FindAction("Disparar", throwIfNotFound: true);
        m_Canon_ModificarFuerza = m_Canon.FindAction("ModificarFuerza", throwIfNotFound: true);
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

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_Apuntar;
    private readonly InputAction m_Canon_Disparar;
    private readonly InputAction m_Canon_ModificarFuerza;
    public struct CanonActions
    {
        private @CanonControls m_Wrapper;
        public CanonActions(@CanonControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntar => m_Wrapper.m_Canon_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Canon_Disparar;
        public InputAction @ModificarFuerza => m_Wrapper.m_Canon_ModificarFuerza;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @Apuntar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @ModificarFuerza.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @ModificarFuerza.started += instance.OnModificarFuerza;
                @ModificarFuerza.performed += instance.OnModificarFuerza;
                @ModificarFuerza.canceled += instance.OnModificarFuerza;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    private int m_GenericaSchemeIndex = -1;
    public InputControlScheme GenericaScheme
    {
        get
        {
            if (m_GenericaSchemeIndex == -1) m_GenericaSchemeIndex = asset.FindControlSchemeIndex("Generica");
            return asset.controlSchemes[m_GenericaSchemeIndex];
        }
    }
    public interface ICanonActions
    {
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
        void OnModificarFuerza(InputAction.CallbackContext context);
    }
}
