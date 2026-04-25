// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 18
// Methods: 134

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class ClientReportExtensions : Object
    {
        // ── Methods ──
        public void RecordDiscardedEvents(){} // RVA: 0x7FFAC8BC5280
    }

    public class CollectionsExtensions : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFAC2E8DC40
        public void TryCopyTo(){} // RVA: 0x7FFAC2C70C80
        public void ToDict(){} // RVA: 0x7FFAC2C58F80
        public void WhereNotNullValue(){} // RVA: 0x7FFAC2C58F80
        public void Append(){} // RVA: 0x7FFAC2E8DC40
        public void AsReadOnly(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void ExceptNulls(){} // RVA: 0x7FFAC2C58F80
        public void TryGetTypedValue(){} // RVA: 0x7FFAC2C5D5A0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DisposableExtensions : Object
    {
        // ── Methods ──
        public void DisposeAll(){} // RVA: 0x7FFAC8BC56D0
    }

    public class EnumExtensions : Object
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0x7FFAC2E8DC40
    }

    public class HashExtensions : Object
    {
        // ── Methods ──
        public void GetHashString(){} // RVA: 0x7FFAC8BC5940
    }

    public class HttpClientExtensions : Object
    {
        // ── Methods ──
        public void ReadAsJsonAsync(){} // RVA: 0x7FFAC8BC5C20
        public void ReadAsJson(){} // RVA: 0x7FFAC8BC5E20
        public void ReadAsString(){} // RVA: 0x7FFAC8BC6070
    }

    public class HttpStatusExtensions : Object
    {
        public string HttpRequestExceptionMessage;

        // ── Methods ──
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFAC8BC6BC0
    }

    public class JsonExtensions : Object
    {
        public System.Text.Json.Serialization.JsonConverter[] JsonPreserveReferences;
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonConverter> CustomConverters; // 0x8
        public bool <JsonPreserveReferences>k__BackingField; // 0x10
        public System.Text.Json.JsonSerializerOptions SerializerOptions; // 0x18
        public System.Text.Json.JsonSerializerOptions AltSerializerOptions; // 0x20
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonSerializerContext> DefaultSerializerContexts; // 0x28
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonSerializerContext> ReferencePreservingSerializerContexts; // 0x30
        public System.Collections.Generic.List`1<System.Func`2<System.Text.Json.JsonSerializerOptions,System.Text.Json.Serialization.JsonSerializerContext>> JsonSerializerContextBuilders; // 0x38

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAC8BC6C80
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAC8BC6CE0
        public void .cctor(){} // RVA: 0x7FFAC8BC6D40
        public void BuildOptions(){} // RVA: 0x7FFAC8BC7550
        public void AddJsonSerializerContext(){} // RVA: 0x7FFAC2C70A10
        public void ResetSerializerOptions(){} // RVA: 0x7FFAC8BC7A30
        public void AddJsonConverter(){} // RVA: 0x7FFAC8BC7E70
        public void Deconstruct(){} // RVA: 0x7FFAC8BC7F50
        public void GetDictionaryOrNull(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetStringDictionaryOrNull(){} // RVA: 0x7FFAC8BC83D0
        public void GetPropertyOrNull(){} // RVA: 0x7FFAC8BC87F0
        public void GetDynamicOrNull(){} // RVA: 0x7FFAC8BC8930
        public void GetNumber(){} // RVA: 0x7FFAC8BC8C90
        public void GetHexAsLong(){} // RVA: 0x7FFAC8BC8EA0
        public void GetStringOrThrow(){} // RVA: 0x7FFAC8BC9050
        public void WriteDictionaryValue(){} // RVA: 0x7FFAC2C7B2F0 | overloaded x2
        public void WriteStringDictionaryValue(){} // RVA: 0x7FFAC8BC9720
        public void WriteDictionary(){} // RVA: 0x7FFAC2C7B910 | overloaded x2
        public void WriteStringDictionary(){} // RVA: 0x7FFAC8BC9FE0
        public void WriteArrayValue(){} // RVA: 0x7FFAC2C761F0
        public void WriteArray(){} // RVA: 0x7FFAC2C7B910
        public void WriteStringArrayValue(){} // RVA: 0x7FFAC8BCA110
        public void WriteStringArray(){} // RVA: 0x7FFAC8BCA3A0
        public void WriteSerializableValue(){} // RVA: 0x7FFAC8BCA4D0
        public void WriteSerializable(){} // RVA: 0x7FFAC8BCA540
        public void WriteDynamicValue(){} // RVA: 0x7FFAC8BCA6B0
        public void ToUtf8Json(){} // RVA: 0x7FFAC8BCB090
        public void GetSerializerContext(){} // RVA: 0x7FFAC8BCB2F0
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x7FFAC8BCB4C0
        public void InternalSerialize(){} // RVA: 0x7FFAC8BCB670
        public void WriteDynamic(){} // RVA: 0x7FFAC8BCB920
        public void WriteBooleanIfNotNull(){} // RVA: 0x7FFAC8BCBB30
        public void WriteBooleanIfTrue(){} // RVA: 0x7FFAC8BCBBC0
        public void WriteNumberIfNotNull(){} // RVA: 0x7FFAC8BCC080 | overloaded x5
        public void WriteNumberIfNotZero(){} // RVA: 0x7FFAC8BCC420 | overloaded x5
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x7FFAC8BCC450
        public void WriteStringIfNotNull(){} // RVA: 0x7FFAC8BCC4B0
        public void WriteSerializableIfNotNull(){} // RVA: 0x7FFAC8BCC540
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x7FFAC2C7B910 | overloaded x2
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x7FFAC8BCC7F0
        public void WriteArrayIfNotEmpty(){} // RVA: 0x7FFAC2C7B910
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x7FFAC8BCC9F0
        public void WriteDynamicIfNotNull(){} // RVA: 0x7FFAC8BCCC30
        public void WriteString(){} // RVA: 0x7FFAC8BCCCC0
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x7FFAC8BCCE10
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x7FFAC8BCCF40
    }

    public class MiscExtensions : Object
    {
        public System.TimeSpan MaxTimeout;

        // ── Methods ──
        public void Pipe(){} // RVA: 0x7FFAC2E8DC40
        public void NullIfDefault(){} // RVA: 0x7FFAC2E8DC40
        public void ToHexString(){} // RVA: 0x7FFAC8BCFC10 | overloaded x4
        public void CancelAfterSafe(){} // RVA: 0x7FFAC8BCFEB0
        public void IsNull(){} // RVA: 0x7FFAC5FA0F10
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void GetRawMessage(){} // RVA: 0x7FFAC8BD0040
        public void .cctor(){} // RVA: 0x7FFAC8BD02D0
    }

    public class PEDebugImageData : Object
    {
        public string Type; // 0x10
        public System.Nullable`1<long> ImageAddress; // 0x18
        public string ImageSize; // 0x28
        public string DebugId; // 0x30
        public string DebugChecksum; // 0x38
        public string DebugFile; // 0x40

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC8BD0A80
        public void get_ImageAddress(){} // RVA: 0x7FFAC2F3C380
        public void set_ImageAddress(){} // RVA: 0x7FFAC2F22E30
        public void get_ImageSize(){} // RVA: 0x7FFAC35D3330
        public void set_ImageSize(){} // RVA: 0x7FFAC35D34F0
        public void get_DebugId(){} // RVA: 0x7FFAC2F4F130
        public void set_DebugId(){} // RVA: 0x7FFAC2F22E90
        public void get_DebugChecksum(){} // RVA: 0x7FFAC31D95E0
        public void set_DebugChecksum(){} // RVA: 0x7FFAC2F4F890
        public void get_DebugFile(){} // RVA: 0x7FFAC31D0140
        public void set_DebugFile(){} // RVA: 0x7FFAC31D0C20
        public void get_CodeId(){} // RVA: 0x7FFAC2F9E740
        public void set_CodeId(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PEDebugImageDataExtensions : Object
    {
        // ── Methods ──
        public void ToDebugImage(){} // RVA: 0x7FFAC8BD0AC0
    }

    public class PEReaderExtensions : Object
    {
        // ── Methods ──
        public void TryGetPEDebugImageData(){} // RVA: 0x7FFAC8BD0380
        public void GetPEDebugImageData(){} // RVA: 0x7FFAC8BD03A0
    }

    public class ReadOnlyDictionaryExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SentryJsonContext : JsonSerializerContext
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<int> Int32; // 0x20
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Sentry.Internal.GrowableArray`1<int>> GrowableArrayInt32; // 0x28
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<string> String; // 0x30
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<bool> Boolean; // 0x38
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Dictionary`2<string,bool>> DictionaryStringBoolean; // 0x40
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<object> Object; // 0x48
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Dictionary`2<string,object>> DictionaryStringObject; // 0x50
        public System.Text.Json.JsonSerializerOptions s_defaultOptions;
        public Sentry.Internal.Extensions.SentryJsonContext Default; // 0x8
        public System.Text.Json.JsonSerializerOptions GeneratedSerializerOptions; // 0x58

        // ── Methods ──
        public void get_Int32(){} // RVA: 0x7FFAC8BCD230
        public void get_GrowableArrayInt32(){} // RVA: 0x7FFAC8BCD3D0
        public void GrowableArrayInt32SerializeHandler(){} // RVA: 0x7FFAC8BCDA50
        public void get_String(){} // RVA: 0x7FFAC8BCDC80
        public void get_Boolean(){} // RVA: 0x7FFAC8BCDE20
        public void get_DictionaryStringBoolean(){} // RVA: 0x7FFAC8BCDFC0
        public void DictionaryStringBooleanSerializeHandler(){} // RVA: 0x7FFAC8BCE590
        public void get_Object(){} // RVA: 0x7FFAC8BCE780
        public void get_DictionaryStringObject(){} // RVA: 0x7FFAC8BCE920
        public void get_s_defaultOptions(){} // RVA: 0x7FFAC8BCEE00
        public void get_Default(){} // RVA: 0x7FFAC8BCEE60
        public void get_GeneratedSerializerOptions(){} // RVA: 0x7FFAC2FE9500
        public void .ctor(){} // RVA: 0x7FFAC8BCF080 | overloaded x2
        public void GetRuntimeProvidedCustomConverter(){} // RVA: 0x7FFAC8BCF180
        public void GetTypeInfo(){} // RVA: 0x7FFAC8BCF3F0
        public void .cctor(){} // RVA: 0x7FFAC8BCF590
    }

    public class StreamExtensions : Object
    {
        public byte[] NewlineBuffer;

        // ── Methods ──
        public void ReadLineAsync(){} // RVA: 0x7FFAC8BD0BE0
        public void SkipNewlinesAsync(){} // RVA: 0x7FFAC8BD0DE0
        public void ReadByteChunkAsync(){} // RVA: 0x7FFAC8BD0FF0
        public void WriteNewlineAsync(){} // RVA: 0x7FFAC8BD11F0
        public void WriteNewline(){} // RVA: 0x7FFAC8BD1290
        public void TryGetLength(){} // RVA: 0x7FFAC8BD1320
        public void IsFileStream(){} // RVA: 0x7FFAC8BD13C0
        public void .cctor(){} // RVA: 0x7FFAC8BD14B0
    }

    public class StringExtensions : Object
    {
        // ── Methods ──
        public void ToSnakeCase(){} // RVA: 0x7FFAC8BD2B70
        public void NullIfWhitespace(){} // RVA: 0x7FFAC8BD2C10
        public void ParseHexAsLong(){} // RVA: 0x7FFAC8BD2C40
    }

    public class UriExtensions : Object
    {
        // ── Methods ──
        public void HttpRequestUrl(){} // RVA: 0x7FFAC8BD2E10
    }

}