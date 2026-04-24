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
        public 0x6639DF40 ScrollDirection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EC7C1A0 | overloaded x2
    }

    public class UIAutomationCommand : Object
    {
        public string Container; // 0x10
        public string Control; // 0x18
        public string ChildControl; // 0x20
        public System.Nullable`1<float> ActionDelay; // 0x28
        public System.Nullable`1<float> StartDelay; // 0x30
        public System.Nullable`1<bool> OpenQuickMenu; // 0x38
        public System.Nullable`1<bool> CloseMenu; // 0x3A
        public System.Nullable`1<bool> ShallowSearch; // 0x3C
        public System.Nullable`1<0x6639DEE8> PointerAction; // 0x40
        public System.Nullable`1<float> SliderValue; // 0x48
        public System.Nullable`1<bool> ToggleValue; // 0x50
        public VRC.UI.Client.OSCAutomation.ScrollLogic ScrollLogic; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EC7BFE0 | overloaded x2
    }

}