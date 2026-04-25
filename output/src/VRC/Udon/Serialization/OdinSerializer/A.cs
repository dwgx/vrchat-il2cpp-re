// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class AllowDeserializeInvalidDataAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AlwaysFormatsSelfAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AnimationCurveFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.Keyframe[]> KeyframeSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<0x6B179058> WrapModeSerializer; // 0x8

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC34F9180
        public void Read(){} // RVA: 0x7FFACA0173F0
        public void Write(){} // RVA: 0x7FFACA017650
        public void .ctor(){} // RVA: 0x7FFACA017880
        public void .cctor(){} // RVA: 0x7FFACA0178E0
    }

    public class ArchitectureInfo : Object
    {
        public bool Architecture_Supports_Unaligned_Float32_Reads;
        public bool Architecture_Supports_All_Unaligned_ReadWrites; // 0x1

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9FE9B80
        public void SetRuntimePlatform(){} // RVA: 0x7FFAC9FE9C20
    }

    public class ArrayFormatterLocator : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,VRC.Udon.Serialization.OdinSerializer.IFormatter> FormatterInstances;

        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAC9FE1D00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9FE2300
    }

    public class ArrayFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> valueReaderWriter;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ArrayListFormatter : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<object> ObjectSerializer;

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC34F9180
        public void DeserializeImplementation(){} // RVA: 0x7FFAC9FE79D0
        public void SerializeImplementation(){} // RVA: 0x7FFAC9FE80B0
        public void .ctor(){} // RVA: 0x7FFAC9FE8340
        public void .cctor(){} // RVA: 0x7FFAC9FE83A0
    }

}