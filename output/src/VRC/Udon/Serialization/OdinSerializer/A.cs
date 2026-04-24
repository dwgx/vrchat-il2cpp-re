// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class AllowDeserializeInvalidDataAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AlwaysFormatsSelfAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AnimationCurveFormatter : MinimalBaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<ÏÌÍÌÍÎÍÌÏÍÍÌÌÎÍÍ[]> KeyframeSerializer;
        public tSupportedException_ConstructorMaxOf64Parameters<ÌÏ> WrapModeSerializer; // 0x8

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void Read(){} // RVA: 0x7FFD554373F0
        public void Write(){} // RVA: 0x7FFD55437650
        public void .ctor(){} // RVA: 0x7FFD55437880
        public void .cctor(){} // RVA: 0x7FFD554378E0
    }

    public class ArchitectureInfo : Object
    {
        public bool Architecture_Supports_Unaligned_Float32_Reads;
        public bool Architecture_Supports_All_Unaligned_ReadWrites; // 0x1

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55409B80
        public void SetRuntimePlatform(){} // RVA: 0x7FFD55409C20
    }

    public class ArrayFormatterLocator : Object
    {
        public URA.DateTime<?,CanonicalExplicitAceCount> FormatterInstances;

        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFD55401D00
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD55402300
    }

    public class ArrayFormatter`1 : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<T1717696640> valueReaderWriter;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E078E90
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ArrayListFormatter : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<object> ObjectSerializer;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
        public void DeserializeImplementation(){} // RVA: 0x7FFD554079D0
        public void SerializeImplementation(){} // RVA: 0x7FFD554080B0
        public void .ctor(){} // RVA: 0x7FFD55408340
        public void .cctor(){} // RVA: 0x7FFD554083A0
    }

}