// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 6
// Methods: 81

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class CollectionsExtensions : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFD4E2ADC40
        public void TryCopyTo(){} // RVA: 0x7FFD4E090C80
        public void ToDict(){} // RVA: 0x7FFD4E078F80
        public void WhereNotNullValue(){} // RVA: 0x7FFD4E078F80
        public void Append(){} // RVA: 0x7FFD4E2ADC40
        public void AsReadOnly(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void ExceptNulls(){} // RVA: 0x7FFD4E078F80
        public void TryGetTypedValue(){} // RVA: 0x7FFD4E07D5A0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0x7FFD4E2ADC40
    }

    public class EnumExtensions : Object
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0x7FFD4E2ADC40
    }

    public class JsonExtensions : Object
    {
        public System.Text.Json.Serialization.JsonConverter[] JsonPreserveReferences;
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonConverter> CustomConverters; // 0x8
        public bool <JsonPreserveReferences>k__BackingField; // 0x10
        public 0x6657DBE0 SerializerOptions; // 0x18
        public 0x6657DBE0 AltSerializerOptions; // 0x20
        public System.Collections.Generic.List`1<0x6657EB58> DefaultSerializerContexts; // 0x28
        public System.Collections.Generic.List`1<0x6657EB58> ReferencePreservingSerializerContexts; // 0x30
        public System.Collections.Generic.List`1<System.Func`2<0x6657DBE0,0x6657EB58>> JsonSerializerContextBuilders; // 0x38

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFD53FE6C80
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFD53FE6CE0
        public void .cctor(){} // RVA: 0x7FFD53FE6D40
        public void BuildOptions(){} // RVA: 0x7FFD53FE7550
        public void AddJsonSerializerContext(){} // RVA: 0x7FFD4E090A10
        public void ResetSerializerOptions(){} // RVA: 0x7FFD53FE7A30
        public void AddJsonConverter(){} // RVA: 0x7FFD53FE7E70
        public void Deconstruct(){} // RVA: 0x7FFD53FE7F50
        public void GetDictionaryOrNull(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetStringDictionaryOrNull(){} // RVA: 0x7FFD53FE83D0
        public void GetPropertyOrNull(){} // RVA: 0x7FFD53FE87F0
        public void GetDynamicOrNull(){} // RVA: 0x7FFD53FE8930
        public void GetNumber(){} // RVA: 0x7FFD53FE8C90
        public void GetHexAsLong(){} // RVA: 0x7FFD53FE8EA0
        public void GetStringOrThrow(){} // RVA: 0x7FFD53FE9050
        public void WriteDictionaryValue(){} // RVA: 0x7FFD4E09B2F0 | overloaded x2
        public void WriteStringDictionaryValue(){} // RVA: 0x7FFD53FE9720
        public void WriteDictionary(){} // RVA: 0x7FFD4E09B910 | overloaded x2
        public void WriteStringDictionary(){} // RVA: 0x7FFD53FE9FE0
        public void WriteArrayValue(){} // RVA: 0x7FFD4E0961F0
        public void WriteArray(){} // RVA: 0x7FFD4E09B910
        public void WriteStringArrayValue(){} // RVA: 0x7FFD53FEA110
        public void WriteStringArray(){} // RVA: 0x7FFD53FEA3A0
        public void WriteSerializableValue(){} // RVA: 0x7FFD53FEA4D0
        public void WriteSerializable(){} // RVA: 0x7FFD53FEA540
        public void WriteDynamicValue(){} // RVA: 0x7FFD53FEA6B0
        public void ToUtf8Json(){} // RVA: 0x7FFD53FEB090
        public void GetSerializerContext(){} // RVA: 0x7FFD53FEB2F0
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x7FFD53FEB4C0
        public void InternalSerialize(){} // RVA: 0x7FFD53FEB670
        public void WriteDynamic(){} // RVA: 0x7FFD53FEB920
        public void WriteBooleanIfNotNull(){} // RVA: 0x7FFD53FEBB30
        public void WriteBooleanIfTrue(){} // RVA: 0x7FFD53FEBBC0
        public void WriteNumberIfNotNull(){} // RVA: 0x7FFD53FEC080 | overloaded x5
        public void WriteNumberIfNotZero(){} // RVA: 0x7FFD53FEC420 | overloaded x5
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x7FFD53FEC450
        public void WriteStringIfNotNull(){} // RVA: 0x7FFD53FEC4B0
        public void WriteSerializableIfNotNull(){} // RVA: 0x7FFD53FEC540
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x7FFD4E09B910 | overloaded x2
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x7FFD53FEC7F0
        public void WriteArrayIfNotEmpty(){} // RVA: 0x7FFD4E09B910
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x7FFD53FEC9F0
        public void WriteDynamicIfNotNull(){} // RVA: 0x7FFD53FECC30
        public void WriteString(){} // RVA: 0x7FFD53FECCC0
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x7FFD53FECE10
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x7FFD53FECF40
    }

    public class MiscExtensions : Object
    {
        public System.TimeSpan MaxTimeout;

        // ── Methods ──
        public void Pipe(){} // RVA: 0x7FFD4E2ADC40
        public void NullIfDefault(){} // RVA: 0x7FFD4E2ADC40
        public void ToHexString(){} // RVA: 0x7FFD53FEFC10 | overloaded x4
        public void CancelAfterSafe(){} // RVA: 0x7FFD53FEFEB0
        public void IsNull(){} // RVA: 0x7FFD513C0F10
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void GetRawMessage(){} // RVA: 0x7FFD53FF0040
        public void .cctor(){} // RVA: 0x7FFD53FF02D0
    }

    public class ReadOnlyDictionaryExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
    }

}