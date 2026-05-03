// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class AllowDeserializeInvalidDataAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AlwaysFormatsSelfAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AnimationCurveFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFE813240E0
        public void Read(){} // RVA: 0x7FFE883C9F00
        public void Write(){} // RVA: 0x7FFE883CA160
        public void .ctor(){} // RVA: 0x7FFE883CA390
        public void .cctor(){} // RVA: 0x7FFE883CA3F0
    }

    public class ArchitectureInfo : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8839C670
        public void SetRuntimePlatform(){} // RVA: 0x7FFE8839C710
    }

    public class ArrayFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE883947F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE88394DF0
    }

    public class ArrayFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFE80E2E2E0
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ArrayListFormatter : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFE813240E0
        public void DeserializeImplementation(){} // RVA: 0x7FFE8839A4C0
        public void SerializeImplementation(){} // RVA: 0x7FFE8839ABA0
        public void .ctor(){} // RVA: 0x7FFE8839AE30
        public void .cctor(){} // RVA: 0x7FFE8839AE90
    }

}