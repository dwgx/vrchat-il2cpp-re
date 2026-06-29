// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 43

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream : Object
    {
        public object InitialCapacity;
        public object MaxCapacity;
        public object memoryStream;

        // ── Methods ──
        public void get_MemoryStream(){} // RVA: 0x849CE10
        public void .ctor(){} // RVA: 0x849CF30
        public void OnFreed(){} // RVA: 0x849D020
        public void OnClaimed(){} // RVA: 0x849D140
        public void Claim(){} // RVA: 0x849D280
        public void .cctor(){} // RVA: 0x849D370
    }

    public class CharSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B4A10
        public void WriteValue(){} // RVA: 0x84B5680
        public void .ctor(){} // RVA: 0x84B5750
    }

    public class Color32Formatter : MinimalBaseFormatter`1
    {
        public object ByteSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84C8FC0
        public void Write(){} // RVA: 0x84C90E0
        public void .ctor(){} // RVA: 0x84C9240
        public void .cctor(){} // RVA: 0x84C92A0
    }

    public class ColorBlockFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x84C9380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ColorBlockFormatter`1 : MinimalBaseFormatter`1
    {
        public object FloatSerializer;
        public object ColorSerializer;
        public object normalColor;
        public object highlightedColor;
        public object pressedColor;
        public object disabledColor;
        public object colorMultiplier;
        public object fadeDuration;

        // ── Methods ──
        public void Read(){} // RVA: 0x8943B0
        public void Write(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ColorFormatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84C9650
        public void Write(){} // RVA: 0x84C9780
        public void .ctor(){} // RVA: 0x84C98E0
        public void .cctor(){} // RVA: 0x84C9940
    }

    public class ComplexTypeSerializer`1 : Serializer`1
    {
        public object ComplexTypeMayBeBoxedValueType;
        public object ComplexTypeIsAbstract;
        public object ComplexTypeIsNullable;
        public object ComplexTypeIsValueType;
        public object TypeOf_T;
        public object AllowDeserializeInvalidDataForT;
        public object FormattersByPolicy;
        public object FormattersByPolicy_LOCK;
        public object UnityPolicy;
        public object StrictPolicy;
        public object EverythingPolicy;
        public object UnityPolicyFormatter;
        public object StrictPolicyFormatter;
        public object EverythingPolicyFormatter;

        // ── Methods ──
        public void ReadValue(){} // RVA: 0xA94080
        public void GetBaseFormatter(){} // RVA: 0x87C5C0
        public void WriteValue(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class CoroutineFormatter : Object
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x84C9A20
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0xDAC980
        public void Deserialize(){} // RVA: 0xDAC980
        public void Serialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CustomFormatterAttribute : Attribute
    {
        public object Priority;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class CustomGenericFormatterAttribute : CustomFormatterAttribute
    {
        public object SerializedGenericTypeDefinition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x849D3D0
    }

    public class CustomLogger : Object
    {
        public object logWarningDelegate;
        public object logErrorDelegate;
        public object logExceptionDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x849D530
        public void LogWarning(){} // RVA: 0x31D2090
        public void LogError(){} // RVA: 0x12751C0
        public void LogException(){} // RVA: 0x46849E0
    }

    public class CustomSerializationPolicy : Object
    {
        public object id;
        public object allowNonSerializableTypes;
        public object shouldSerializeFunc;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x849D660
        public void get_ID(){} // RVA: 0xB5DBF0
        public void get_AllowNonSerializableTypes(){} // RVA: 0xB5DD50
        public void ShouldSerializeMember(){} // RVA: 0x46849E0
    }

}