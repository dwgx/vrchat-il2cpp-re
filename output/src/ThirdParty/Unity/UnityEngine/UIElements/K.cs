// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyDownEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2CCC0
        public void GetEquivalentImguiEvent(){} // RVA: 0x7FFE87F2CDB0
        public void PostDispatch(){} // RVA: 0x7FFE87F2CFF0
        public void SendEquivalentNavigationEventIfAny(){} // RVA: 0x7FFE87F2D0F0
        public void .ctor(){} // RVA: 0x7FFE87F2D690
    }

    public class KeyUpEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2DA40
        public void .ctor(){} // RVA: 0x7FFE87F2DB30
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        public 0x66679374 _modifiers;
        public char _character;
        public 0x66576A14 _keyCode;
        public object field_3; // 0x210
        public object field_4; // 0x211
        public object field_5; // 0x212
        public object field_6; // 0x213
        public object field_7; // 0x214
        public object field_8; // 0x215

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void set_modifiers(){} // RVA: 0x7FFE80E46530
        public void get_character(){} // RVA: 0x7FFE80E2E210
        public void set_character(){} // RVA: 0x7FFE80E461D0
        public void get_keyCode(){} // RVA: 0x7FFE80E2EDB0
        public void set_keyCode(){} // RVA: 0x7FFE80E46530
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_ctrlKey(){} // RVA: 0x7FFE80E2F150
        public void get_commandKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
        public void get_functionKey(){} // RVA: 0x7FFE80E2F150
        public void get_actionKey(){} // RVA: 0x7FFE80E2F150
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class KeyboardEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F2CAC0
        public void DispatchEvent(){} // RVA: 0x7FFE87F2CB10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class KeyboardEventExtensions : Object
    {
        // ── Methods ──
        public void ShouldSendNavigationMoveEvent(){} // RVA: 0x7FFE87F2D8C0
        public void ShouldSendNavigationMoveEventRuntime(){} // RVA: 0x7FFE87F2D980
    }

    public class KeyboardNavigationManipulator : Manipulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87F4D260
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87F4D480
        public void OnKeyDown(){} // RVA: 0x7FFE87F4D730
        public void OnNavigationCancel(){} // RVA: 0x7FFE87F4D890
        public void OnNavigationSubmit(){} // RVA: 0x7FFE87F4D8C0
        public void OnNavigationMove(){} // RVA: 0x7FFE87F4D8F0
        public void Invoke(){} // RVA: 0x7FFE85A88580
        public void <OnKeyDown>g__GetOperation|4_0(){} // RVA: 0x7FFE87F4D9C0
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EE1C80
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE87EE1DD0
        public void OnFocus(){} // RVA: 0x7FFE87EE22C0
        public void OnBlur(){} // RVA: 0x7FFE87EE2380
        public void OnKeyDown(){} // RVA: 0x7FFE87EE2400
        public void UpdateLabel(){} // RVA: 0x7FFE87EE2A30
        public void OnValidateCommandEvent(){} // RVA: 0x7FFE87EE2E40
        public void OnExecuteCommandEvent(){} // RVA: 0x7FFE87EE3070
        public void OnNavigationEvent(){} // RVA: 0x7FFE80E460A0
    }

}