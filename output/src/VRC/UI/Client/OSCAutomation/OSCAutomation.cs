// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Client.OSCAutomation
// Classes: 2
// Methods: 4

namespace VRC.UI.Client.OSCAutomation
{
    public class ScrollLogic : Object
    {
        public float Distance; // 0x10
        public float Duration; // 0x14
        public object ScrollDirection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EC7C1A0 | overloaded x2
    }

    public class UIAutomationCommand : Object
    {
        public string Container; // 0x10
        public string Control; // 0x18
        public string ChildControl; // 0x20
        public aphy<float> ActionDelay; // 0x28
        public aphy<float> StartDelay; // 0x30
        public aphy<bool> OpenQuickMenu; // 0x38
        public aphy<bool> CloseMenu; // 0x3A
        public aphy<bool> ShallowSearch; // 0x3C
        public aphy<ÎÎÏÏÏÎÎÌÌÎ> PointerAction; // 0x40
        public aphy<float> SliderValue; // 0x48
        public aphy<bool> ToggleValue; // 0x50
        public ÌÏÎÎÍ.? ScrollLogic; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EC7BFE0 | overloaded x2
    }

}