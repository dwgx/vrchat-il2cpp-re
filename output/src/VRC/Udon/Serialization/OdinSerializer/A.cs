// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class AllowDeserializeInvalidDataAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AlwaysFormatsSelfAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AnimationCurveFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0xDAC980
        public void Read(){} // RVA: 0x84C8610
        public void Write(){} // RVA: 0x84C8860
        public void .ctor(){} // RVA: 0x84C8A80
        public void .cctor(){} // RVA: 0x84C8AE0
    }

    public class ArchitectureInfo : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x849C9C0
        public void SetRuntimePlatform(){} // RVA: 0x849CA60
    }

    public class ArrayFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x8494DD0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x84953D0
    }

    public class ArrayFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x87C0A0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ArrayListFormatter : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0xDAC980
        public void DeserializeImplementation(){} // RVA: 0x849AA80
        public void SerializeImplementation(){} // RVA: 0x849B0F0
        public void .ctor(){} // RVA: 0x849B380
        public void .cctor(){} // RVA: 0x849B3E0
    }

}