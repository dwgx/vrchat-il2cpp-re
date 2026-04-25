// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 46

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream : Object
    {
        public int MemoryStream;
        public int MaxCapacity; // 0x4
        public System.IO.MemoryStream memoryStream; // 0x10

        // ── Methods ──
        public void get_MemoryStream(){} // RVA: 0x7FFAC9FE9FC0
        public void .ctor(){} // RVA: 0x7FFAC9FEA0E0
        public void OnFreed(){} // RVA: 0x7FFAC9FEA1D0
        public void OnClaimed(){} // RVA: 0x7FFAC9FEA2F0
        public void Claim(){} // RVA: 0x7FFAC9FEA430 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9FEA520
    }

    public class CharSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA002470
        public void WriteValue(){} // RVA: 0x7FFACA003140
        public void .ctor(){} // RVA: 0x7FFACA003210
    }

    public class Color32Formatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<byte> ByteSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA017DC0
        public void Write(){} // RVA: 0x7FFACA017EE0
        public void .ctor(){} // RVA: 0x7FFACA018040
        public void .cctor(){} // RVA: 0x7FFACA0180A0
    }

    public class ColorBlockFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFACA018180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ColorBlockFormatter`1 : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.Color> ColorSerializer;
        public System.Reflection.PropertyInfo normalColor;
        public System.Reflection.PropertyInfo highlightedColor;
        public System.Reflection.PropertyInfo pressedColor;
        public System.Reflection.PropertyInfo disabledColor;
        public System.Reflection.PropertyInfo colorMultiplier;
        public System.Reflection.PropertyInfo fadeDuration;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2C79B30
        public void Write(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ColorFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA018440
        public void Write(){} // RVA: 0x7FFACA018570
        public void .ctor(){} // RVA: 0x7FFACA0186D0
        public void .cctor(){} // RVA: 0x7FFACA018730
    }

    public class ComplexTypeSerializer`1 : Serializer`1
    {
        public bool ComplexTypeMayBeBoxedValueType;
        public bool ComplexTypeIsAbstract;
        public bool ComplexTypeIsNullable;
        public bool ComplexTypeIsValueType;
        public System.Type TypeOf_T;
        public bool AllowDeserializeInvalidDataForT;
        public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<T>> FormattersByPolicy;
        public object FormattersByPolicy_LOCK;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy UnityPolicy;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy StrictPolicy;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy EverythingPolicy;
        public VRC.Udon.Serialization.OdinSerializer.IFormatter`1<T> UnityPolicyFormatter;
        public VRC.Udon.Serialization.OdinSerializer.IFormatter`1<T> StrictPolicyFormatter;
        public VRC.Udon.Serialization.OdinSerializer.IFormatter`1<T> EverythingPolicyFormatter;

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void GetBaseFormatter(){} // RVA: 0x7FFAC2C58F80
        public void WriteValue(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class CoroutineFormatter : Object
    {
        public object SerializedType;

        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFACA018810
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAC34F9180
        public void Deserialize(){} // RVA: 0x7FFAC34F9180
        public void Serialize(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CustomFormatterAttribute : Attribute
    {
        public int Priority; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
    }

    public class CustomGenericFormatterAttribute : CustomFormatterAttribute
    {
        public System.Type SerializedGenericTypeDefinition; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FEA580
    }

    public class CustomLogger : Object
    {
        public System.Action`1<string> logWarningDelegate; // 0x10
        public System.Action`1<string> logErrorDelegate; // 0x18
        public System.Action`1<System.Exception> logExceptionDelegate; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FEA710
        public void LogWarning(){} // RVA: 0x7FFAC7793490
        public void LogError(){} // RVA: 0x7FFAC3584BC0
        public void LogException(){} // RVA: 0x7FFAC64FAEC0
    }

    public class CustomSerializationPolicy : Object
    {
        public string ID; // 0x10
        public bool AllowNonSerializableTypes; // 0x18
        public System.Func`2<System.Reflection.MemberInfo,bool> shouldSerializeFunc; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FEA840
        public void get_ID(){} // RVA: 0x7FFAC2F3C380
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFAC2F3C4E0
        public void ShouldSerializeMember(){} // RVA: 0x7FFAC64FAEC0
    }

}