// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class AllowDeserializeInvalidDataAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AlwaysFormatsSelfAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AnimationCurveFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void Read(){} // RVA: 0x7AF66C310
        public void Write(){} // RVA: 0x7AF66C570
        public void .ctor(){} // RVA: 0x7AF66C7A0
        public void .cctor(){} // RVA: 0x7AF66C800
    }

    public class ArchitectureInfo : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF63EF10
        public void SetRuntimePlatform(){} // RVA: 0x7AF63EFB0
    }

    public class ArrayFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7AF6372D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF6378E0
    }

    public class ArrayFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7A7E00680
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A7E18770
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class ArrayListFormatter : BaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void DeserializeImplementation(){} // RVA: 0x7AF63CFB0
        public void SerializeImplementation(){} // RVA: 0x7AF63D620
        public void .ctor(){} // RVA: 0x7AF63D8B0
        public void .cctor(){} // RVA: 0x7AF63D910
    }

}