// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyDownEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B84410
        public void GetEquivalentImguiEvent(){} // RVA: 0x7FFAC9B84500
        public void PostDispatch(){} // RVA: 0x7FFAC9B84740
        public void SendEquivalentNavigationEventIfAny(){} // RVA: 0x7FFAC9B84840
        public void .ctor(){} // RVA: 0x7FFAC9B84DE0
    }

    public class KeyUpEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B85190
        public void .ctor(){} // RVA: 0x7FFAC9B85280
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        public 0x6B27F588 modifiers;
        public char character;
        public 0x6B17D1A8 keyCode;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void set_modifiers(){} // RVA: 0x7FFAC2C70ED0
        public void get_character(){} // RVA: 0x7FFAC2C58DC0
        public void set_character(){} // RVA: 0x7FFAC2C70B70
        public void get_keyCode(){} // RVA: 0x7FFAC2C59960
        public void set_keyCode(){} // RVA: 0x7FFAC2C70ED0
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_ctrlKey(){} // RVA: 0x7FFAC2C59D00
        public void get_commandKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
        public void get_functionKey(){} // RVA: 0x7FFAC2C59D00
        public void get_actionKey(){} // RVA: 0x7FFAC2C59D00
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class KeyboardEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B84210
        public void DispatchEvent(){} // RVA: 0x7FFAC9B84260
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class KeyboardEventExtensions : Object
    {
        // ── Methods ──
        public void ShouldSendNavigationMoveEvent(){} // RVA: 0x7FFAC9B85010
        public void ShouldSendNavigationMoveEventRuntime(){} // RVA: 0x7FFAC9B850D0
    }

    public class KeyboardNavigationManipulator : Manipulator
    {
        public System.Action`2<0x6B11F8A0,UnityEngine.UIElements.EventBase> m_Action; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9BA49B0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9BA4BD0
        public void OnKeyDown(){} // RVA: 0x7FFAC9BA4E80
        public void OnNavigationCancel(){} // RVA: 0x7FFAC9BA4FE0
        public void OnNavigationSubmit(){} // RVA: 0x7FFAC9BA5010
        public void OnNavigationMove(){} // RVA: 0x7FFAC9BA5040
        public void Invoke(){} // RVA: 0x7FFAC7797E30
        public void <OnKeyDown>g__GetOperation|4_0(){} // RVA: 0x7FFAC9BA5110
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        public UnityEngine.Event m_ImguiEvent; // 0x20
        public bool m_Changed; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B393E0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC9B39530
        public void OnFocus(){} // RVA: 0x7FFAC9B39A20
        public void OnBlur(){} // RVA: 0x7FFAC9B39AE0
        public void OnKeyDown(){} // RVA: 0x7FFAC9B39B60
        public void UpdateLabel(){} // RVA: 0x7FFAC9B3A190
        public void OnValidateCommandEvent(){} // RVA: 0x7FFAC9B3A5A0
        public void OnExecuteCommandEvent(){} // RVA: 0x7FFAC9B3A7D0
        public void OnNavigationEvent(){} // RVA: 0x7FFAC2C70A40
    }

}