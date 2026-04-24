// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 2
// Methods: 25

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class KeyboardEventBase`1 : EventBase`1
    {
        public object _keyCode; // 0x31135B30, was: <keyCode>k__BackingField
        public object modifiers; // 0x17000210

        // ── Original Methods ──
        public void get_modifiers(){} // RVA: 0x7ffaa8649ca0
        public void set_modifiers(){} // RVA: 0x7ffaa8661210
        public void get_character(){} // RVA: 0x7ffaa8649100
        public void set_character(){} // RVA: 0x7ffaa8660eb0
        public void get_keyCode(){} // RVA: 0x7ffaa8649ca0
        public void set_keyCode(){} // RVA: 0x7ffaa8661210
        public void get_shiftKey(){} // RVA: 0x7ffaa864a040
        public void get_ctrlKey(){} // RVA: 0x7ffaa864a040
        public void get_commandKey(){} // RVA: 0x7ffaa864a040
        public void get_altKey(){} // RVA: 0x7ffaa864a040
        public void get_functionKey(){} // RVA: 0x7ffaa864a040
        public void get_actionKey(){} // RVA: 0x7ffaa864a040
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf55b340
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaaf55b490
        public void OnFocus(){} // RVA: 0x7ffaaf55b980
        public void OnBlur(){} // RVA: 0x7ffaaf55ba40
        public void OnKeyDown(){} // RVA: 0x7ffaaf55bac0
        public void UpdateLabel(){} // RVA: 0x7ffaaf55c0f0
        public void OnValidateCommandEvent(){} // RVA: 0x7ffaaf55c500
        public void OnExecuteCommandEvent(){} // RVA: 0x7ffaaf55c730
        public void OnNavigationEvent(){} // RVA: 0x7ffaa8660d80
    }

}