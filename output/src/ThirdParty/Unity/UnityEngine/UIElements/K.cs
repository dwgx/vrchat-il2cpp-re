// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 9
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyDownEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CBDE0
        public void GetEquivalentImguiEvent(){} // RVA: 0x7AF1CBED0
        public void PostDispatch(){} // RVA: 0x7AF1CC110
        public void SendEquivalentNavigationEventIfAny(){} // RVA: 0x7AF1CC200
        public void .ctor(){} // RVA: 0x7AF1CC7C0
    }

    public class KeyUpEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CCB70
        public void .ctor(){} // RVA: 0x7AF1CCC60
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A7E00710
        public void set_modifiers(){} // RVA: 0x7A7E189D0
        public void get_character(){} // RVA: 0x7A7E006E0
        public void set_character(){} // RVA: 0x7A7E18950
        public void get_keyCode(){} // RVA: 0x7A7E00710
        public void set_keyCode(){} // RVA: 0x7A7E189D0
        public void get_shiftKey(){} // RVA: 0x7A7E01900
        public void get_ctrlKey(){} // RVA: 0x7A7E01900
        public void get_commandKey(){} // RVA: 0x7A7E01900
        public void get_altKey(){} // RVA: 0x7A7E01900
        public void get_functionKey(){} // RVA: 0x7A7E01900
        public void get_actionKey(){} // RVA: 0x7A7E01900
        public void Init(){} // RVA: 0x7A7E18770
        public void LocalInit(){} // RVA: 0x7A7E18770
        public void GetPooled(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_character(){} // RVA: 0x7AB5BA7B0
        public void set_character(){} // RVA: 0x7AB5BA7C0
        public void get_keyCode(){} // RVA: 0x7A846C760
        public void set_keyCode(){} // RVA: 0x7A8CCD330
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void get_functionKey(){} // RVA: 0x7AB5BA810
        public void get_actionKey(){} // RVA: 0x7AB5BA820
        public void Init(){} // RVA: 0x7AB5BA920
        public void LocalInit(){} // RVA: 0x7AB5BA9D0
        public void GetPooled(){} // RVA: 0x7AB5BAA00
        public void .ctor(){} // RVA: 0x7AB5BABE0
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A897F560
        public void set_modifiers(){} // RVA: 0x7A8980300
        public void get_character(){} // RVA: 0x7AB5BA7B0
        public void set_character(){} // RVA: 0x7AB5BA7C0
        public void get_keyCode(){} // RVA: 0x7A846C760
        public void set_keyCode(){} // RVA: 0x7A8CCD330
        public void get_shiftKey(){} // RVA: 0x7AB5BA7D0
        public void get_ctrlKey(){} // RVA: 0x7AB5BA7E0
        public void get_commandKey(){} // RVA: 0x7AB5BA7F0
        public void get_altKey(){} // RVA: 0x7AB5BA800
        public void get_functionKey(){} // RVA: 0x7AB5BA810
        public void get_actionKey(){} // RVA: 0x7AB5BA820
        public void Init(){} // RVA: 0x7AB5BA920
        public void LocalInit(){} // RVA: 0x7AB5BA9D0
        public void GetPooled(){} // RVA: 0x7AB5BAA00
        public void .ctor(){} // RVA: 0x7AB5BABE0
    }

    public class KeyboardEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7AF1CBBF0
        public void DispatchEvent(){} // RVA: 0x7AF1CBC40
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class KeyboardEventExtensions : Object
    {
        // ── Methods ──
        public void ShouldSendNavigationMoveEvent(){} // RVA: 0x7AF1CC9F0
        public void ShouldSendNavigationMoveEventRuntime(){} // RVA: 0x7AF1CCAB0
    }

    public class KeyboardNavigationManipulator : Manipulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7AF1EC180
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7AF1EC3A0
        public void OnKeyDown(){} // RVA: 0x7AF1EC650
        public void OnNavigationCancel(){} // RVA: 0x7AF1EC7C0
        public void OnNavigationSubmit(){} // RVA: 0x7AF1EC7F0
        public void OnNavigationMove(){} // RVA: 0x7AF1EC820
        public void Invoke(){} // RVA: 0x7ACD587F0
        public void <OnKeyDown>g__GetOperation|4_0(){} // RVA: 0x7AF1EC8F0
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF180F80
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7AF1810D0
        public void OnFocus(){} // RVA: 0x7AF1814E0
        public void OnBlur(){} // RVA: 0x7AF1815A0
        public void OnKeyDown(){} // RVA: 0x7AF181620
        public void UpdateLabel(){} // RVA: 0x7AF181C30
        public void OnValidateCommandEvent(){} // RVA: 0x7AF182040
        public void OnExecuteCommandEvent(){} // RVA: 0x7AF182270
        public void OnNavigationEvent(){} // RVA: 0x7A7E18800
    }

}