// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 18
// Methods: 134

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class ClientReportExtensions
    {
        // ── Methods ──
        public void RecordDiscardedEvents(){} // RVA: 0x7FFAF8EDDF00
    }

    public class CollectionsExtensions
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFAF2D33FA0
        public void TryCopyTo(){} // RVA: 0x7FFAF2AD4D50
        public void ToDict(){} // RVA: 0x7FFAF2ABCE50
        public void WhereNotNullValue(){} // RVA: 0x7FFAF2ABCE50
        public void Append(){} // RVA: 0x7FFAF2D33FA0
        public void AsReadOnly(){} // RVA: 0x7FFAF2ABCE50 | overloaded x2
        public void ExceptNulls(){} // RVA: 0x7FFAF2ABCE50
        public void TryGetTypedValue(){} // RVA: 0x7FFAF2AC14C0
    }

    public class DictionaryExtensions
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0x7FFAF2D33FA0
    }

    public class DisposableExtensions
    {
        // ── Methods ──
        public void DisposeAll(){} // RVA: 0x7FFAF8EDE350
    }

    public class EnumExtensions
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0x7FFAF2D33FA0
    }

    public class HashExtensions
    {
        // ── Methods ──
        public void GetHashString(){} // RVA: 0x7FFAF8EDE5C0
    }

    public class HttpClientExtensions
    {
        // ── Methods ──
        public void ReadAsJsonAsync(){} // RVA: 0x7FFAF8EDE8A0
        public void ReadAsJson(){} // RVA: 0x7FFAF8EDEAA0
        public void ReadAsString(){} // RVA: 0x7FFAF8EDECF0
    }

    public class HttpStatusExtensions
    {
        // ── Methods ──
        public void EnsureSuccessStatusCode(){} // RVA: 0x7FFAF8EDF840
    }

    public class JsonExtensions
    {
        public object TokenType;

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAF8EDF900
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAF8EDF960
        public void .cctor(){} // RVA: 0x7FFAF8EDF9C0
        public void BuildOptions(){} // RVA: 0x7FFAF8EE01D0
        public void AddJsonSerializerContext(){} // RVA: 0x7FFAF2AD4AE0
        public void ResetSerializerOptions(){} // RVA: 0x7FFAF8EE06B0
        public void AddJsonConverter(){} // RVA: 0x7FFAF8EE0AF0
        public void Deconstruct(){} // RVA: 0x7FFAF8EE0BD0
        public void GetDictionaryOrNull(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetStringDictionaryOrNull(){} // RVA: 0x7FFAF8EE1050
        public void GetPropertyOrNull(){} // RVA: 0x7FFAF8EE1470
        public void GetDynamicOrNull(){} // RVA: 0x7FFAF8EE15B0
        public void GetNumber(){} // RVA: 0x7FFAF8EE1910
        public void GetHexAsLong(){} // RVA: 0x7FFAF8EE1B20
        public void GetStringOrThrow(){} // RVA: 0x7FFAF8EE1CD0
        public void WriteDictionaryValue(){} // RVA: 0x7FFAF2ADF420 | overloaded x2
        public void WriteStringDictionaryValue(){} // RVA: 0x7FFAF8EE23A0
        public void WriteDictionary(){} // RVA: 0x7FFAF2ADFA40 | overloaded x2
        public void WriteStringDictionary(){} // RVA: 0x7FFAF8EE2C60
        public void WriteArrayValue(){} // RVA: 0x7FFAF2ADA310
        public void WriteArray(){} // RVA: 0x7FFAF2ADFA40
        public void WriteStringArrayValue(){} // RVA: 0x7FFAF8EE2D90
        public void WriteStringArray(){} // RVA: 0x7FFAF8EE3020
        public void WriteSerializableValue(){} // RVA: 0x7FFAF8EE3150
        public void WriteSerializable(){} // RVA: 0x7FFAF8EE31C0
        public void WriteDynamicValue(){} // RVA: 0x7FFAF8EE3330
        public void ToUtf8Json(){} // RVA: 0x7FFAF8EE3D10
        public void GetSerializerContext(){} // RVA: 0x7FFAF8EE3F70
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x7FFAF8EE4140
        public void InternalSerialize(){} // RVA: 0x7FFAF8EE42F0
        public void WriteDynamic(){} // RVA: 0x7FFAF8EE45A0
        public void WriteBooleanIfNotNull(){} // RVA: 0x7FFAF8EE47B0
        public void WriteBooleanIfTrue(){} // RVA: 0x7FFAF8EE4840
        public void WriteNumberIfNotNull(){} // RVA: 0x7FFAF8EE4D00 | overloaded x5
        public void WriteNumberIfNotZero(){} // RVA: 0x7FFAF8EE50A0 | overloaded x5
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x7FFAF8EE50D0
        public void WriteStringIfNotNull(){} // RVA: 0x7FFAF8EE5130
        public void WriteSerializableIfNotNull(){} // RVA: 0x7FFAF8EE51C0
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x7FFAF2ADFA40 | overloaded x2
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x7FFAF8EE5470
        public void WriteArrayIfNotEmpty(){} // RVA: 0x7FFAF2ADFA40
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x7FFAF8EE5670
        public void WriteDynamicIfNotNull(){} // RVA: 0x7FFAF8EE58B0
        public void WriteString(){} // RVA: 0x7FFAF8EE5940
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x7FFAF8EE5A90
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x7FFAF8EE5BC0
    }

    public class MiscExtensions
    {
        // ── Methods ──
        public void Pipe(){} // RVA: 0x7FFAF2D33FA0
        public void NullIfDefault(){} // RVA: 0x7FFAF2D33FA0
        public void ToHexString(){} // RVA: 0x7FFAF8EE8890 | overloaded x4
        public void CancelAfterSafe(){} // RVA: 0x7FFAF8EE8B30
        public void IsNull(){} // RVA: 0x7FFAF61243B0
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void GetRawMessage(){} // RVA: 0x7FFAF8EE8CC0
        public void .cctor(){} // RVA: 0x7FFAF8EE8F50
    }

    public class PEDebugImageData
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF8EE9700
        public void get_ImageAddress(){} // RVA: 0x7FFAF2DA8380
        public void set_ImageAddress(){} // RVA: 0x7FFAF2D8EE30
        public void get_ImageSize(){} // RVA: 0x7FFAF3444EE0
        public void set_ImageSize(){} // RVA: 0x7FFAF34449A0
        public void get_DebugId(){} // RVA: 0x7FFAF2DBB130
        public void set_DebugId(){} // RVA: 0x7FFAF2D8EE90
        public void get_DebugChecksum(){} // RVA: 0x7FFAF30E74D0
        public void set_DebugChecksum(){} // RVA: 0x7FFAF2DBB890
        public void get_DebugFile(){} // RVA: 0x7FFAF2F476A0
        public void set_DebugFile(){} // RVA: 0x7FFAF2F4B830
        public void get_CodeId(){} // RVA: 0x7FFAF2E0A740
        public void set_CodeId(){} // RVA: 0x7FFAF2DB5200
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PEDebugImageDataExtensions
    {
        // ── Methods ──
        public void ToDebugImage(){} // RVA: 0x7FFAF8EE9740
    }

    public class PEReaderExtensions
    {
        // ── Methods ──
        public void TryGetPEDebugImageData(){} // RVA: 0x7FFAF8EE9000
        public void GetPEDebugImageData(){} // RVA: 0x7FFAF8EE9020
    }

    public class ReadOnlyDictionaryExtensions
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAF2D33FA0
    }

    public class SentryJsonContext
    {
        // ── Methods ──
        public void get_Int32(){} // RVA: 0x7FFAF8EE5EB0
        public void get_GrowableArrayInt32(){} // RVA: 0x7FFAF8EE6050
        public void GrowableArrayInt32SerializeHandler(){} // RVA: 0x7FFAF8EE66D0
        public void get_String(){} // RVA: 0x7FFAF8EE6900
        public void get_Boolean(){} // RVA: 0x7FFAF8EE6AA0
        public void get_DictionaryStringBoolean(){} // RVA: 0x7FFAF8EE6C40
        public void DictionaryStringBooleanSerializeHandler(){} // RVA: 0x7FFAF8EE7210
        public void get_Object(){} // RVA: 0x7FFAF8EE7400
        public void get_DictionaryStringObject(){} // RVA: 0x7FFAF8EE75A0
        public void get_s_defaultOptions(){} // RVA: 0x7FFAF8EE7A80
        public void get_Default(){} // RVA: 0x7FFAF8EE7AE0
        public void get_GeneratedSerializerOptions(){} // RVA: 0x7FFAF2E55500
        public void .ctor(){} // RVA: 0x7FFAF8EE7D00 | overloaded x2
        public void GetRuntimeProvidedCustomConverter(){} // RVA: 0x7FFAF8EE7E00
        public void GetTypeInfo(){} // RVA: 0x7FFAF8EE8070
        public void .cctor(){} // RVA: 0x7FFAF8EE8210
    }

    public class StreamExtensions
    {
        // ── Methods ──
        public void ReadLineAsync(){} // RVA: 0x7FFAF8EE9860
        public void SkipNewlinesAsync(){} // RVA: 0x7FFAF8EE9A60
        public void ReadByteChunkAsync(){} // RVA: 0x7FFAF8EE9C70
        public void WriteNewlineAsync(){} // RVA: 0x7FFAF8EE9E70
        public void WriteNewline(){} // RVA: 0x7FFAF8EE9F10
        public void TryGetLength(){} // RVA: 0x7FFAF8EE9FA0
        public void IsFileStream(){} // RVA: 0x7FFAF8EEA040
        public void .cctor(){} // RVA: 0x7FFAF8EEA130
    }

    public class StringExtensions
    {
        // ── Methods ──
        public void ToSnakeCase(){} // RVA: 0x7FFAF8EEB7F0
        public void NullIfWhitespace(){} // RVA: 0x7FFAF8EEB890
        public void ParseHexAsLong(){} // RVA: 0x7FFAF8EEB8C0
    }

    public class UriExtensions
    {
        // ── Methods ──
        public void HttpRequestUrl(){} // RVA: 0x7FFAF8EEBA90
    }

}