// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 18
// Methods: 117

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class ClientReportExtensions : Object
    {
        // ── Methods ──
        public void RecordDiscardedEvents(){} // RVA: 0x6E9E660
    }

    public class CollectionsExtensions : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0xA94080
        public void TryCopyTo(){} // RVA: 0x8945C0
        public void ToDict(){} // RVA: 0x87C5C0
        public void WhereNotNullValue(){} // RVA: 0x87C5C0
        public void Append(){} // RVA: 0xA94080
        public void AsReadOnly(){} // RVA: 0x87C5C0
        public void ExceptNulls(){} // RVA: 0x87C5C0
        public void TryGetTypedValue(){} // RVA: 0x880B90
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0xA94080
    }

    public class DisposableExtensions : Object
    {
        // ── Methods ──
        public void DisposeAll(){} // RVA: 0x6E9EAB0
    }

    public class EnumExtensions : Object
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0xA94080
    }

    public class HashExtensions : Object
    {
        // ── Methods ──
        public void GetHashString(){} // RVA: 0x6E9ED20
    }

    public class HttpClientExtensions : Object
    {
        // ── Methods ──
        public void ReadAsJsonAsync(){} // RVA: 0x6E9F010
        public void ReadAsJson(){} // RVA: 0x6E9F210
        public void ReadAsString(){} // RVA: 0x6E9F470
    }

    public class HttpStatusExtensions : Object
    {
        public object HttpRequestExceptionMessage;

        // ── Methods ──
        public void EnsureSuccessStatusCode(){} // RVA: 0x6E9FFD0
    }

    public class JsonExtensions : Object
    {
        public object DefaultConverters;
        public object CustomConverters;
        public object _jsonPreserveReferences;
        public object SerializerOptions;
        public object AltSerializerOptions;
        public object DefaultSerializerContexts;
        public object ReferencePreservingSerializerContexts;
        public object JsonSerializerContextBuilders;

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x6EA0090
        public void set_JsonPreserveReferences(){} // RVA: 0x6EA00F0
        public void .cctor(){} // RVA: 0x6EA0150
        public void BuildOptions(){} // RVA: 0x6EA0960
        public void AddJsonSerializerContext(){} // RVA: 0x894350
        public void ResetSerializerOptions(){} // RVA: 0x6EA0E30
        public void AddJsonConverter(){} // RVA: 0x6EA1280
        public void Deconstruct(){} // RVA: 0x6EA1360
        public void GetDictionaryOrNull(){} // RVA: 0xA94080
        public void GetStringDictionaryOrNull(){} // RVA: 0x6EA17F0
        public void GetPropertyOrNull(){} // RVA: 0x6EA1C20
        public void GetDynamicOrNull(){} // RVA: 0x6EA1E40
        public void GetNumber(){} // RVA: 0x6EA2180
        public void GetHexAsLong(){} // RVA: 0x6EA2360
        public void GetStringOrThrow(){} // RVA: 0x6EA2510
        public void WriteDictionaryValue(){} // RVA: 0x89EDE0
        public void WriteStringDictionaryValue(){} // RVA: 0x6EA2C10
        public void WriteDictionary(){} // RVA: 0x89F3A0
        public void WriteStringDictionary(){} // RVA: 0x6EA3500
        public void WriteArrayValue(){} // RVA: 0x899D10
        public void WriteArray(){} // RVA: 0x89F3A0
        public void WriteStringArrayValue(){} // RVA: 0x6EA3630
        public void WriteStringArray(){} // RVA: 0x6EA38E0
        public void WriteSerializableValue(){} // RVA: 0x6EA3A10
        public void WriteSerializable(){} // RVA: 0x6EA3A80
        public void WriteDynamicValue(){} // RVA: 0x6EA3BF0
        public void ToUtf8Json(){} // RVA: 0x6EA4580
        public void GetSerializerContext(){} // RVA: 0x6EA47E0
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x6EA49B0
        public void InternalSerialize(){} // RVA: 0x6EA4B60
        public void WriteDynamic(){} // RVA: 0x6EA4E10
        public void WriteBooleanIfNotNull(){} // RVA: 0x6EA5010
        public void WriteBooleanIfTrue(){} // RVA: 0x6EA50A0
        public void WriteNumberIfNotNull(){} // RVA: 0x6EA5560
        public void WriteNumberIfNotZero(){} // RVA: 0x6EA5900
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x6EA5930
        public void WriteStringIfNotNull(){} // RVA: 0x6EA59E0
        public void WriteSerializableIfNotNull(){} // RVA: 0x6EA5A70
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x89F3A0
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x6EA5D20
        public void WriteArrayIfNotEmpty(){} // RVA: 0x89F3A0
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x6EA5F20
        public void WriteDynamicIfNotNull(){} // RVA: 0x6EA6160
        public void WriteString(){} // RVA: 0x6EA61F0
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x6EA6340
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x6EA6470
    }

    public class MiscExtensions : Object
    {
        public object MaxTimeout;

        // ── Methods ──
        public void Pipe(){} // RVA: 0xA94080
        public void NullIfDefault(){} // RVA: 0xA94080
        public void ToHexString(){} // RVA: 0x6EA91E0
        public void CancelAfterSafe(){} // RVA: 0x6EA9480
        public void IsNull(){} // RVA: 0x40DDDC0
        public void Add(){} // RVA: 0xA94080
        public void GetRawMessage(){} // RVA: 0x6EA9610
        public void .cctor(){} // RVA: 0x6EA98A0
    }

    public class PEDebugImageData : Object
    {
        public object _imageAddress;
        public object _imageSize;
        public object _debugId;
        public object _debugChecksum;
        public object _debugFile;
        public object _codeId;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x6EAA040
        public void get_ImageAddress(){} // RVA: 0xB5DBF0
        public void set_ImageAddress(){} // RVA: 0xB44D60
        public void get_ImageSize(){} // RVA: 0x125EE60
        public void set_ImageSize(){} // RVA: 0x125D9D0
        public void get_DebugId(){} // RVA: 0xB70160
        public void set_DebugId(){} // RVA: 0xB44DC0
        public void get_DebugChecksum(){} // RVA: 0xD33E60
        public void set_DebugChecksum(){} // RVA: 0xB708C0
        public void get_DebugFile(){} // RVA: 0xD05CA0
        public void set_DebugFile(){} // RVA: 0xD09D70
        public void get_CodeId(){} // RVA: 0xBC1B30
        public void set_CodeId(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PEDebugImageDataExtensions : Object
    {
        // ── Methods ──
        public void ToDebugImage(){} // RVA: 0x6EAA080
    }

    public class PEReaderExtensions : Object
    {
        // ── Methods ──
        public void TryGetPEDebugImageData(){} // RVA: 0x6EA9950
        public void GetPEDebugImageData(){} // RVA: 0x6EA9970
    }

    public class ReadOnlyDictionaryExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0xA94080
    }

    public class SentryJsonContext : JsonSerializerContext
    {
        public object _Int32;
        public object _GrowableArrayInt32;
        public object _String;
        public object _Boolean;
        public object _DictionaryStringBoolean;
        public object _Object;
        public object _DictionaryStringObject;
        public object _s_defaultOptions;
        public object s_defaultContext;
        public object _generatedSerializerOptions;

        // ── Methods ──
        public void get_Int32(){} // RVA: 0x6EA6760
        public void get_GrowableArrayInt32(){} // RVA: 0x6EA6910
        public void GrowableArrayInt32SerializeHandler(){} // RVA: 0x6EA6FB0
        public void get_String(){} // RVA: 0x6EA71C0
        public void get_Boolean(){} // RVA: 0x6EA7370
        public void get_DictionaryStringBoolean(){} // RVA: 0x6EA7520
        public void DictionaryStringBooleanSerializeHandler(){} // RVA: 0x6EA7B00
        public void get_Object(){} // RVA: 0x6EA7D20
        public void get_DictionaryStringObject(){} // RVA: 0x6EA7ED0
        public void get_s_defaultOptions(){} // RVA: 0x6EA83E0
        public void get_Default(){} // RVA: 0x6EA8440
        public void get_GeneratedSerializerOptions(){} // RVA: 0xC0FFC0
        public void .ctor(){} // RVA: 0x6EA8660
        public void GetRuntimeProvidedCustomConverter(){} // RVA: 0x6EA8760
        public void GetTypeInfo(){} // RVA: 0x6EA89D0
        public void .cctor(){} // RVA: 0x6EA8B60
    }

    public class StreamExtensions : Object
    {
        public object NewlineBuffer;

        // ── Methods ──
        public void ReadLineAsync(){} // RVA: 0x6EAA1A0
        public void SkipNewlinesAsync(){} // RVA: 0x6EAA3A0
        public void ReadByteChunkAsync(){} // RVA: 0x6EAA5B0
        public void WriteNewlineAsync(){} // RVA: 0x6EAA7B0
        public void WriteNewline(){} // RVA: 0x6EAA850
        public void TryGetLength(){} // RVA: 0x6EAA8E0
        public void IsFileStream(){} // RVA: 0x6EAA980
        public void .cctor(){} // RVA: 0x6EAAA70
    }

    public class StringExtensions : Object
    {
        // ── Methods ──
        public void ToSnakeCase(){} // RVA: 0x6EAC210
        public void NullIfWhitespace(){} // RVA: 0x6EAC2B0
        public void ParseHexAsLong(){} // RVA: 0x6EAC340
    }

    public class UriExtensions : Object
    {
        // ── Methods ──
        public void HttpRequestUrl(){} // RVA: 0x6EAC510
    }

}