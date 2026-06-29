// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 2
// Methods: 29

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class DefaultInputActions : Object
    {
        public object _asset;
        public object m_Player;
        public object m_PlayerActionsCallbackInterface;
        public object m_Player_Move;
        public object m_Player_Look;
        public object m_Player_Fire;
        public object m_UI;
        public object m_UIActionsCallbackInterface;
        public object m_UI_Navigate;
        public object m_UI_Submit;
        public object m_UI_Cancel;
        public object m_UI_Point;
        public object m_UI_Click;
        public object m_UI_ScrollWheel;
        public object m_UI_MiddleClick;
        public object m_UI_RightClick;
        public object m_UI_TrackedDevicePosition;
        public object m_UI_TrackedDeviceOrientation;
        public object m_KeyboardMouseSchemeIndex;
        public object m_GamepadSchemeIndex;
        public object m_TouchSchemeIndex;
        public object m_JoystickSchemeIndex;
        public object m_XRSchemeIndex;

        // ── Methods ──
        public void get_asset(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x78D4860
        public void Dispose(){} // RVA: 0x78D50C0
        public void get_bindingMask(){} // RVA: 0x18D9E60
        public void set_bindingMask(){} // RVA: 0x18D7720
        public void get_devices(){} // RVA: 0x18D9EB0
        public void set_devices(){} // RVA: 0x18D7780
        public void get_controlSchemes(){} // RVA: 0x18D7AD0
        public void Contains(){} // RVA: 0x18D7860
        public void GetEnumerator(){} // RVA: 0x18D76E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x18D76E0
        public void Enable(){} // RVA: 0x18D7AB0
        public void Disable(){} // RVA: 0x18D7B10
        public void get_bindings(){} // RVA: 0x18D7700
        public void FindAction(){} // RVA: 0x18D7A90
        public void FindBinding(){} // RVA: 0x18D7800
        public void get_Player(){} // RVA: 0x18D7680
        public void get_UI(){} // RVA: 0x18D7680
        public void get_KeyboardMouseScheme(){} // RVA: 0x78D5150
        public void get_GamepadScheme(){} // RVA: 0x78D52D0
        public void get_TouchScheme(){} // RVA: 0x78D5450
        public void get_JoystickScheme(){} // RVA: 0x78D55D0
        public void get_XRScheme(){} // RVA: 0x78D5750
    }

    public class DynamicBitfield : ValueType
    {
        public object array;
        public object length;

        // ── Methods ──
        public void SetLength(){} // RVA: 0x935430
        public void SetBit(){} // RVA: 0x935440
        public void TestBit(){} // RVA: 0x935450
        public void ClearBit(){} // RVA: 0x935460
        public void AnyBitIsSet(){} // RVA: 0x935470
        public void BitCountToULongCount(){} // RVA: 0x78E63A0
    }

}