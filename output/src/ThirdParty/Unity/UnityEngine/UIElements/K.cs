// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyDownEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73ECB20
        public void GetEquivalentImguiEvent(){} // RVA: 0x73ECC10
        public void PostDispatch(){} // RVA: 0x73ECE50
        public void SendEquivalentNavigationEventIfAny(){} // RVA: 0x73ECF50
        public void .ctor(){} // RVA: 0x73ED4F0
    }

    public class KeyUpEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73ED8A0
        public void .ctor(){} // RVA: 0x73ED990
    }

    public class KeyboardEventBase`1
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xD840
        public void set_modifiers(){} // RVA: 0x24FA0
        public void get_character(){} // RVA: 0xCC90
        public void set_character(){} // RVA: 0x24C40
        public void get_keyCode(){} // RVA: 0xD840
        public void set_keyCode(){} // RVA: 0x24FA0
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_ctrlKey(){} // RVA: 0xDBE0
        public void get_commandKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
        public void get_functionKey(){} // RVA: 0xDBE0
        public void get_actionKey(){} // RVA: 0xDBE0
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class KeyboardEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73EC920
        public void DispatchEvent(){} // RVA: 0x73EC970
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class KeyboardEventExtensions
    {
        // ── Methods ──
        public void ShouldSendNavigationMoveEvent(){} // RVA: 0x73ED720
        public void ShouldSendNavigationMoveEventRuntime(){} // RVA: 0x73ED7E0
    }

    public class KeyboardNavigationManipulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80
        public void RegisterCallbacksOnTarget(){} // RVA: 0x740D0C0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x740D2E0
        public void OnKeyDown(){} // RVA: 0x740D590
        public void OnNavigationCancel(){} // RVA: 0x740D6F0
        public void OnNavigationSubmit(){} // RVA: 0x740D720
        public void OnNavigationMove(){} // RVA: 0x740D750
        public void Invoke(){} // RVA: 0x4EC5180
        public void <OnKeyDown>g__GetOperation|4_0(){} // RVA: 0x740D820
    }

    public class KeyboardTextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A1B00
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x73A1C50
        public void OnFocus(){} // RVA: 0x73A2140
        public void OnBlur(){} // RVA: 0x73A2200
        public void OnKeyDown(){} // RVA: 0x73A2280
        public void UpdateLabel(){} // RVA: 0x73A28B0
        public void OnValidateCommandEvent(){} // RVA: 0x73A2CC0
        public void OnExecuteCommandEvent(){} // RVA: 0x73A2EF0
        public void OnNavigationEvent(){} // RVA: 0x24B10
    }

}