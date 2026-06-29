// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 8
// Methods: 80

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyDownEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805E910
        public void GetEquivalentImguiEvent(){} // RVA: 0x805EA00
        public void PostDispatch(){} // RVA: 0x805EC80
        public void SendEquivalentNavigationEventIfAny(){} // RVA: 0x805ED80
        public void .ctor(){} // RVA: 0x805F340
    }

    public class KeyUpEvent : KeyboardEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805F6C0
        public void .ctor(){} // RVA: 0x805F7B0
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        public object _modifiers;
        public object _character;
        public object _keyCode;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x87C130
        public void set_modifiers(){} // RVA: 0x8944F0
        public void get_character(){} // RVA: 0x87C100
        public void set_character(){} // RVA: 0x894470
        public void get_keyCode(){} // RVA: 0x87C130
        public void set_keyCode(){} // RVA: 0x8944F0
        public void get_shiftKey(){} // RVA: 0x87D280
        public void get_ctrlKey(){} // RVA: 0x87D280
        public void get_commandKey(){} // RVA: 0x87D280
        public void get_altKey(){} // RVA: 0x87D280
        public void get_functionKey(){} // RVA: 0x87D280
        public void get_actionKey(){} // RVA: 0x87D280
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
        public void Dispatch(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        public object _modifiers;
        public object _character;
        public object _keyCode;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_character(){} // RVA: 0x4264D60
        public void set_character(){} // RVA: 0x4264D70
        public void get_keyCode(){} // RVA: 0x19C6270
        public void set_keyCode(){} // RVA: 0xCE5450
        public void get_shiftKey(){} // RVA: 0x4264D80
        public void get_ctrlKey(){} // RVA: 0x4264D90
        public void get_commandKey(){} // RVA: 0x4264DA0
        public void get_altKey(){} // RVA: 0x4264DB0
        public void get_functionKey(){} // RVA: 0x4264DC0
        public void get_actionKey(){} // RVA: 0x4264DD0
        public void Init(){} // RVA: 0x4264ED0
        public void LocalInit(){} // RVA: 0x4264F80
        public void GetPooled(){} // RVA: 0x42650B0
        public void Dispatch(){} // RVA: 0x4265270
        public void .ctor(){} // RVA: 0x4265280
    }

    public class KeyboardEventBase`1 : EventBase`1
    {
        public object _modifiers;
        public object _character;
        public object _keyCode;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x2536460
        public void set_modifiers(){} // RVA: 0x25406E0
        public void get_character(){} // RVA: 0x4264D60
        public void set_character(){} // RVA: 0x4264D70
        public void get_keyCode(){} // RVA: 0x19C6270
        public void set_keyCode(){} // RVA: 0xCE5450
        public void get_shiftKey(){} // RVA: 0x4264D80
        public void get_ctrlKey(){} // RVA: 0x4264D90
        public void get_commandKey(){} // RVA: 0x4264DA0
        public void get_altKey(){} // RVA: 0x4264DB0
        public void get_functionKey(){} // RVA: 0x4264DC0
        public void get_actionKey(){} // RVA: 0x4264DD0
        public void Init(){} // RVA: 0x4264ED0
        public void LocalInit(){} // RVA: 0x4264F80
        public void GetPooled(){} // RVA: 0x42650B0
        public void Dispatch(){} // RVA: 0x4265270
        public void .ctor(){} // RVA: 0x4265280
    }

    public class KeyboardEventExtensions : Object
    {
        // ── Methods ──
        public void ShouldSendNavigationMoveEvent(){} // RVA: 0x805F570
        public void ShouldSendNavigationMoveEventRuntime(){} // RVA: 0x805F620
    }

    public class KeyboardNavigationManipulator : Manipulator
    {
        public object m_Action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x80828C0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x8082AE0
        public void OnKeyDown(){} // RVA: 0x8082FE0
        public void OnNavigationCancel(){} // RVA: 0x8083140
        public void OnNavigationSubmit(){} // RVA: 0x8083170
        public void OnNavigationMove(){} // RVA: 0x80831A0
        public void Invoke(){} // RVA: 0x59516C0
        public void <OnKeyDown>g__GetOperation|4_0(){} // RVA: 0x8083270
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        public object m_ImguiEvent;
        public object m_Changed;
        public object m_ShouldInvokeUpdateValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FEDC00
        public void HandleEventBubbleUp(){} // RVA: 0x7FEDD50
        public void OnFocus(){} // RVA: 0x7FEE210
        public void OnBlur(){} // RVA: 0x7FEE2D0
        public void OnIMEInput(){} // RVA: 0x7FEE350
        public void OnKeyDown(){} // RVA: 0x7FEE3B0
        public void ApplyTextIfNeeded(){} // RVA: 0x7FEE940
        public void UpdateLabel(){} // RVA: 0x7FEE9B0
        public void OnValidateCommandEvent(){} // RVA: 0x7FEEE60
        public void OnExecuteCommandEvent(){} // RVA: 0x7FEF0A0
        public void OnNavigationEvent(){} // RVA: 0x894320
    }

}