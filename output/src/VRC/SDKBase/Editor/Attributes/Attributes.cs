// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Editor.Attributes
// Classes: 2
// Methods: 2

namespace VRC.SDKBase.Editor.Attributes
{
    public class CurveAttribute : PropertyAttribute
    {
        public float PosX; // 0x10
        public float PosY; // 0x14
        public float RangeX; // 0x18
        public float RangeY; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CF3EB0
    }

    public class HelpBoxAttribute : PropertyAttribute
    {
        public string text; // 0x10
        public 0x6B2542F0 messageType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

}