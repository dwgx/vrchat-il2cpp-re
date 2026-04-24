// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 2
// Methods: 25

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyboardEventBase`1 : EventBase`1
    {
        public object modifiers;
        public object character;
        public object keyCode;
        public object shiftKey;
        public object ctrlKey;
        public object commandKey;
        public object altKey;
        public object functionKey;
        public object actionKey;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFD4E079960
        public void set_modifiers(){} // RVA: 0x7FFD4E090ED0
        public void get_character(){} // RVA: 0x7FFD4E078DC0
        public void set_character(){} // RVA: 0x7FFD4E090B70
        public void get_keyCode(){} // RVA: 0x7FFD4E079960
        public void set_keyCode(){} // RVA: 0x7FFD4E090ED0
        public void get_shiftKey(){} // RVA: 0x7FFD4E079D00
        public void get_ctrlKey(){} // RVA: 0x7FFD4E079D00
        public void get_commandKey(){} // RVA: 0x7FFD4E079D00
        public void get_altKey(){} // RVA: 0x7FFD4E079D00
        public void get_functionKey(){} // RVA: 0x7FFD4E079D00
        public void get_actionKey(){} // RVA: 0x7FFD4E079D00
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54F593E0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFD54F59530
        public void OnFocus(){} // RVA: 0x7FFD54F59A20
        public void OnBlur(){} // RVA: 0x7FFD54F59AE0
        public void OnKeyDown(){} // RVA: 0x7FFD54F59B60
        public void UpdateLabel(){} // RVA: 0x7FFD54F5A190
        public void OnValidateCommandEvent(){} // RVA: 0x7FFD54F5A5A0
        public void OnExecuteCommandEvent(){} // RVA: 0x7FFD54F5A7D0
        public void OnNavigationEvent(){} // RVA: 0x7FFD4E090A40
    }

}