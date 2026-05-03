// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 18
// Methods: 134

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class ClientReportExtensions : Object
    {
        // ── Methods ──
        public void RecordDiscardedEvents(){} // RVA: 0x7FFE86F6E900
    }

    public class CollectionsExtensions : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFE810A1420
        public void TryCopyTo(){} // RVA: 0x7FFE80E462E0
        public void ToDict(){} // RVA: 0x7FFE80E2E3D0
        public void WhereNotNullValue(){} // RVA: 0x7FFE80E2E3D0
        public void Append(){} // RVA: 0x7FFE810A1420
        public void AsReadOnly(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void ExceptNulls(){} // RVA: 0x7FFE80E2E3D0
        public void TryGetTypedValue(){} // RVA: 0x7FFE80E329F0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0x7FFE810A1420
    }

    public class DisposableExtensions : Object
    {
        // ── Methods ──
        public void DisposeAll(){} // RVA: 0x7FFE86F6ED50
    }

    public class EnumExtensions : Object
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0x7FFE810A1420
    }

    public class HashExtensions : Object
    {
        // ── Methods ──
        public void GetHashString(){} // RVA: 0x7FFE86F6EFC0
    }

    public class HttpClientExtensions : Object
    {
        // ── Methods ──
        public void ReadAsJsonAsync(){} // RVA: 0x7FFE86F6F2A0
        public void ReadAsJson(){} // RVA: 0x7FFE86F6F4A0
        public void ReadAsString(){} // RVA: 0x7FFE86F6F6F0
    }

    public class HttpStatusExtensions : Object
    {
        // ── Methods ──
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFE86F70240
    }

    public class JsonExtensions : Object
    {
        public System.Text.Json.Serialization.JsonConverter[] DefaultConverters;

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFE86F70300
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFE86F70360
        public void .cctor(){} // RVA: 0x7FFE86F703C0
        public void BuildOptions(){} // RVA: 0x7FFE86F70BD0
        public void AddJsonSerializerContext(){} // RVA: 0x7FFE80E46070
        public void ResetSerializerOptions(){} // RVA: 0x7FFE86F710B0
        public void AddJsonConverter(){} // RVA: 0x7FFE86F714F0
        public void Deconstruct(){} // RVA: 0x7FFE86F715D0
        public void GetDictionaryOrNull(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetStringDictionaryOrNull(){} // RVA: 0x7FFE86F71A50
        public void GetPropertyOrNull(){} // RVA: 0x7FFE86F71E70
        public void GetDynamicOrNull(){} // RVA: 0x7FFE86F71FB0
        public void GetNumber(){} // RVA: 0x7FFE86F72310
        public void GetHexAsLong(){} // RVA: 0x7FFE86F72520
        public void GetStringOrThrow(){} // RVA: 0x7FFE86F726D0
        public void WriteDictionaryValue(){} // RVA: 0x7FFE80E509F0 | overloaded x2
        public void WriteStringDictionaryValue(){} // RVA: 0x7FFE86F72DA0
        public void WriteDictionary(){} // RVA: 0x7FFE80E51010 | overloaded x2
        public void WriteStringDictionary(){} // RVA: 0x7FFE86F73660
        public void WriteArrayValue(){} // RVA: 0x7FFE80E4B8F0
        public void WriteArray(){} // RVA: 0x7FFE80E51010
        public void WriteStringArrayValue(){} // RVA: 0x7FFE86F73790
        public void WriteStringArray(){} // RVA: 0x7FFE86F73A20
        public void WriteSerializableValue(){} // RVA: 0x7FFE86F73B50
        public void WriteSerializable(){} // RVA: 0x7FFE86F73BC0
        public void WriteDynamicValue(){} // RVA: 0x7FFE86F73D30
        public void ToUtf8Json(){} // RVA: 0x7FFE86F74710
        public void GetSerializerContext(){} // RVA: 0x7FFE86F74970
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x7FFE86F74B40
        public void InternalSerialize(){} // RVA: 0x7FFE86F74CF0
        public void WriteDynamic(){} // RVA: 0x7FFE86F74FA0
        public void WriteBooleanIfNotNull(){} // RVA: 0x7FFE86F751B0
        public void WriteBooleanIfTrue(){} // RVA: 0x7FFE86F75240
        public void WriteNumberIfNotNull(){} // RVA: 0x7FFE86F75700 | overloaded x5
        public void WriteNumberIfNotZero(){} // RVA: 0x7FFE86F75AA0 | overloaded x5
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x7FFE86F75AD0
        public void WriteStringIfNotNull(){} // RVA: 0x7FFE86F75B30
        public void WriteSerializableIfNotNull(){} // RVA: 0x7FFE86F75BC0
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x7FFE80E51010 | overloaded x2
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x7FFE86F75E70
        public void WriteArrayIfNotEmpty(){} // RVA: 0x7FFE80E51010
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x7FFE86F76070
        public void WriteDynamicIfNotNull(){} // RVA: 0x7FFE86F762B0
        public void WriteString(){} // RVA: 0x7FFE86F76340
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x7FFE86F76490
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x7FFE86F765C0
    }

    public class MiscExtensions : Object
    {
        // ── Methods ──
        public void Pipe(){} // RVA: 0x7FFE810A1420
        public void NullIfDefault(){} // RVA: 0x7FFE810A1420
        public void ToHexString(){} // RVA: 0x7FFE86F79290 | overloaded x4
        public void CancelAfterSafe(){} // RVA: 0x7FFE86F79530
        public void IsNull(){} // RVA: 0x7FFE842EDEB0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void GetRawMessage(){} // RVA: 0x7FFE86F796C0
        public void .cctor(){} // RVA: 0x7FFE86F79950
    }

    public class PEDebugImageData : Object
    {
        public string _imageAddress; // 0x10
        public System.Nullable`1<long> _imageSize; // 0x18
        public string _debugId; // 0x28
        public string _debugChecksum; // 0x30
        public string _debugFile; // 0x38
        public string _codeId; // 0x40
        public object field_6; // 0x35E

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE86F7A100
        public void get_ImageAddress(){} // RVA: 0x7FFE81116380
        public void set_ImageAddress(){} // RVA: 0x7FFE810FCE30
        public void get_ImageSize(){} // RVA: 0x7FFE81703940
        public void set_ImageSize(){} // RVA: 0x7FFE817036E0
        public void get_DebugId(){} // RVA: 0x7FFE81129130
        public void set_DebugId(){} // RVA: 0x7FFE810FCE90
        public void get_DebugChecksum(){} // RVA: 0x7FFE8144E200
        public void set_DebugChecksum(){} // RVA: 0x7FFE81129890
        public void get_DebugFile(){} // RVA: 0x7FFE8143BA80
        public void set_DebugFile(){} // RVA: 0x7FFE81437330
        public void get_CodeId(){} // RVA: 0x7FFE81178740
        public void set_CodeId(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PEDebugImageDataExtensions : Object
    {
        // ── Methods ──
        public void ToDebugImage(){} // RVA: 0x7FFE86F7A140
    }

    public class PEReaderExtensions : Object
    {
        // ── Methods ──
        public void TryGetPEDebugImageData(){} // RVA: 0x7FFE86F79A00
        public void GetPEDebugImageData(){} // RVA: 0x7FFE86F79A20
    }

    public class ReadOnlyDictionaryExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
    }

    public class SentryJsonContext : JsonSerializerContext
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<int> _Int32; // 0x20
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Sentry.Internal.GrowableArray`1<int>> _GrowableArrayInt32; // 0x28
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<string> _String; // 0x30
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<bool> _Boolean; // 0x38
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Dictionary`2<string,bool>> _DictionaryStringBoolean; // 0x40
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<object> _Object; // 0x48
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.Generic.Dictionary`2<string,object>> _DictionaryStringObject; // 0x50
        public System.Text.Json.JsonSerializerOptions _s_defaultOptions;
        public Sentry.Internal.Extensions.SentryJsonContext s_defaultContext; // 0x8
        public System.Text.Json.JsonSerializerOptions _generatedSerializerOptions; // 0x58

        // ── Methods ──
        public void get_Int32(){} // RVA: 0x7FFE86F768B0
        public void get_GrowableArrayInt32(){} // RVA: 0x7FFE86F76A50
        public void GrowableArrayInt32SerializeHandler(){} // RVA: 0x7FFE86F770D0
        public void get_String(){} // RVA: 0x7FFE86F77300
        public void get_Boolean(){} // RVA: 0x7FFE86F774A0
        public void get_DictionaryStringBoolean(){} // RVA: 0x7FFE86F77640
        public void DictionaryStringBooleanSerializeHandler(){} // RVA: 0x7FFE86F77C10
        public void get_Object(){} // RVA: 0x7FFE86F77E00
        public void get_DictionaryStringObject(){} // RVA: 0x7FFE86F77FA0
        public void get_s_defaultOptions(){} // RVA: 0x7FFE86F78480
        public void get_Default(){} // RVA: 0x7FFE86F784E0
        public void get_GeneratedSerializerOptions(){} // RVA: 0x7FFE811C3500
        public void .ctor(){} // RVA: 0x7FFE86F78700 | overloaded x2
        public void GetRuntimeProvidedCustomConverter(){} // RVA: 0x7FFE86F78800
        public void GetTypeInfo(){} // RVA: 0x7FFE86F78A70
        public void .cctor(){} // RVA: 0x7FFE86F78C10
    }

    public class StreamExtensions : Object
    {
        // ── Methods ──
        public void ReadLineAsync(){} // RVA: 0x7FFE86F7A260
        public void SkipNewlinesAsync(){} // RVA: 0x7FFE86F7A460
        public void ReadByteChunkAsync(){} // RVA: 0x7FFE86F7A670
        public void WriteNewlineAsync(){} // RVA: 0x7FFE86F7A870
        public void WriteNewline(){} // RVA: 0x7FFE86F7A910
        public void TryGetLength(){} // RVA: 0x7FFE86F7A9A0
        public void IsFileStream(){} // RVA: 0x7FFE86F7AA40
        public void .cctor(){} // RVA: 0x7FFE86F7AB30
    }

    public class StringExtensions : Object
    {
        // ── Methods ──
        public void ToSnakeCase(){} // RVA: 0x7FFE86F7C1F0
        public void NullIfWhitespace(){} // RVA: 0x7FFE86F7C290
        public void ParseHexAsLong(){} // RVA: 0x7FFE86F7C2C0
    }

    public class UriExtensions : Object
    {
        // ── Methods ──
        public void HttpRequestUrl(){} // RVA: 0x7FFE86F7C490
    }

}