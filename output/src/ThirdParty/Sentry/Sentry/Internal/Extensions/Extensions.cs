// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Extensions
// Classes: 18
// Methods: 134

namespace ThirdParty.Sentry.Sentry.Internal.Extensions
{
    public class ClientReportExtensions
    {
        // ── Methods ──
        public void RecordDiscardedEvents(){} // RVA: 0x642DF00
    }

    public class CollectionsExtensions
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x283FA0
        public void TryCopyTo(){} // RVA: 0x24D50
        public void ToDict(){} // RVA: 0xCE50
        public void WhereNotNullValue(){} // RVA: 0xCE50
        public void Append(){} // RVA: 0x283FA0
        public void AsReadOnly(){} // RVA: 0xCE50 | overloaded x2
        public void ExceptNulls(){} // RVA: 0xCE50
        public void TryGetTypedValue(){} // RVA: 0x114C0
    }

    public class DictionaryExtensions
    {
        // ── Methods ──
        public void AddIfNotNullOrEmpty(){} // RVA: 0x283FA0
    }

    public class DisposableExtensions
    {
        // ── Methods ──
        public void DisposeAll(){} // RVA: 0x642E350
    }

    public class EnumExtensions
    {
        // ── Methods ──
        public void ParseEnum(){} // RVA: 0x283FA0
    }

    public class HashExtensions
    {
        // ── Methods ──
        public void GetHashString(){} // RVA: 0x642E5C0
    }

    public class HttpClientExtensions
    {
        // ── Methods ──
        public void ReadAsJsonAsync(){} // RVA: 0x642E8A0
        public void ReadAsJson(){} // RVA: 0x642EAA0
        public void ReadAsString(){} // RVA: 0x642ECF0
    }

    public class HttpStatusExtensions
    {
        // ── Methods ──
        public void EnsureSuccessStatusCode(){} // RVA: 0x642F840
    }

    public class JsonExtensions
    {
        public object TokenType;

        // ── Methods ──
        public void get_JsonPreserveReferences(){} // RVA: 0x642F900
        public void set_JsonPreserveReferences(){} // RVA: 0x642F960
        public void .cctor(){} // RVA: 0x642F9C0
        public void BuildOptions(){} // RVA: 0x64301D0
        public void AddJsonSerializerContext(){} // RVA: 0x24AE0
        public void ResetSerializerOptions(){} // RVA: 0x64306B0
        public void AddJsonConverter(){} // RVA: 0x6430AF0
        public void Deconstruct(){} // RVA: 0x6430BD0
        public void GetDictionaryOrNull(){} // RVA: 0x283FA0 | overloaded x2
        public void GetStringDictionaryOrNull(){} // RVA: 0x6431050
        public void GetPropertyOrNull(){} // RVA: 0x6431470
        public void GetDynamicOrNull(){} // RVA: 0x64315B0
        public void GetNumber(){} // RVA: 0x6431910
        public void GetHexAsLong(){} // RVA: 0x6431B20
        public void GetStringOrThrow(){} // RVA: 0x6431CD0
        public void WriteDictionaryValue(){} // RVA: 0x2F420 | overloaded x2
        public void WriteStringDictionaryValue(){} // RVA: 0x64323A0
        public void WriteDictionary(){} // RVA: 0x2FA40 | overloaded x2
        public void WriteStringDictionary(){} // RVA: 0x6432C60
        public void WriteArrayValue(){} // RVA: 0x2A310
        public void WriteArray(){} // RVA: 0x2FA40
        public void WriteStringArrayValue(){} // RVA: 0x6432D90
        public void WriteStringArray(){} // RVA: 0x6433020
        public void WriteSerializableValue(){} // RVA: 0x6433150
        public void WriteSerializable(){} // RVA: 0x64331C0
        public void WriteDynamicValue(){} // RVA: 0x6433330
        public void ToUtf8Json(){} // RVA: 0x6433D10
        public void GetSerializerContext(){} // RVA: 0x6433F70
        public void InternalSerializeToUtf8Bytes(){} // RVA: 0x6434140
        public void InternalSerialize(){} // RVA: 0x64342F0
        public void WriteDynamic(){} // RVA: 0x64345A0
        public void WriteBooleanIfNotNull(){} // RVA: 0x64347B0
        public void WriteBooleanIfTrue(){} // RVA: 0x6434840
        public void WriteNumberIfNotNull(){} // RVA: 0x6434D00 | overloaded x5
        public void WriteNumberIfNotZero(){} // RVA: 0x64350A0 | overloaded x5
        public void WriteStringIfNotWhiteSpace(){} // RVA: 0x64350D0
        public void WriteStringIfNotNull(){} // RVA: 0x6435130
        public void WriteSerializableIfNotNull(){} // RVA: 0x64351C0
        public void WriteDictionaryIfNotEmpty(){} // RVA: 0x2FA40 | overloaded x2
        public void WriteStringDictionaryIfNotEmpty(){} // RVA: 0x6435470
        public void WriteArrayIfNotEmpty(){} // RVA: 0x2FA40
        public void WriteStringArrayIfNotEmpty(){} // RVA: 0x6435670
        public void WriteDynamicIfNotNull(){} // RVA: 0x64358B0
        public void WriteString(){} // RVA: 0x6435940
        public void <InternalSerializeToUtf8Bytes>g__JitSerializeToUtf8Bytes|40_0(){} // RVA: 0x6435A90
        public void <InternalSerialize>g__JitSerialize|41_0(){} // RVA: 0x6435BC0
    }

    public class MiscExtensions
    {
        // ── Methods ──
        public void Pipe(){} // RVA: 0x283FA0
        public void NullIfDefault(){} // RVA: 0x283FA0
        public void ToHexString(){} // RVA: 0x6438890 | overloaded x4
        public void CancelAfterSafe(){} // RVA: 0x6438B30
        public void IsNull(){} // RVA: 0x36743B0
        public void Add(){} // RVA: 0x283FA0
        public void GetRawMessage(){} // RVA: 0x6438CC0
        public void .cctor(){} // RVA: 0x6438F50
    }

    public class PEDebugImageData
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x6439700
        public void get_ImageAddress(){} // RVA: 0x2F8380
        public void set_ImageAddress(){} // RVA: 0x2DEE30
        public void get_ImageSize(){} // RVA: 0x994EE0
        public void set_ImageSize(){} // RVA: 0x9949A0
        public void get_DebugId(){} // RVA: 0x30B130
        public void set_DebugId(){} // RVA: 0x2DEE90
        public void get_DebugChecksum(){} // RVA: 0x6374D0
        public void set_DebugChecksum(){} // RVA: 0x30B890
        public void get_DebugFile(){} // RVA: 0x4976A0
        public void set_DebugFile(){} // RVA: 0x49B830
        public void get_CodeId(){} // RVA: 0x35A740
        public void set_CodeId(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PEDebugImageDataExtensions
    {
        // ── Methods ──
        public void ToDebugImage(){} // RVA: 0x6439740
    }

    public class PEReaderExtensions
    {
        // ── Methods ──
        public void TryGetPEDebugImageData(){} // RVA: 0x6439000
        public void GetPEDebugImageData(){} // RVA: 0x6439020
    }

    public class ReadOnlyDictionaryExtensions
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x283FA0
    }

    public class SentryJsonContext
    {
        // ── Methods ──
        public void get_Int32(){} // RVA: 0x6435EB0
        public void get_GrowableArrayInt32(){} // RVA: 0x6436050
        public void GrowableArrayInt32SerializeHandler(){} // RVA: 0x64366D0
        public void get_String(){} // RVA: 0x6436900
        public void get_Boolean(){} // RVA: 0x6436AA0
        public void get_DictionaryStringBoolean(){} // RVA: 0x6436C40
        public void DictionaryStringBooleanSerializeHandler(){} // RVA: 0x6437210
        public void get_Object(){} // RVA: 0x6437400
        public void get_DictionaryStringObject(){} // RVA: 0x64375A0
        public void get_s_defaultOptions(){} // RVA: 0x6437A80
        public void get_Default(){} // RVA: 0x6437AE0
        public void get_GeneratedSerializerOptions(){} // RVA: 0x3A5500
        public void .ctor(){} // RVA: 0x6437D00 | overloaded x2
        public void GetRuntimeProvidedCustomConverter(){} // RVA: 0x6437E00
        public void GetTypeInfo(){} // RVA: 0x6438070
        public void .cctor(){} // RVA: 0x6438210
    }

    public class StreamExtensions
    {
        // ── Methods ──
        public void ReadLineAsync(){} // RVA: 0x6439860
        public void SkipNewlinesAsync(){} // RVA: 0x6439A60
        public void ReadByteChunkAsync(){} // RVA: 0x6439C70
        public void WriteNewlineAsync(){} // RVA: 0x6439E70
        public void WriteNewline(){} // RVA: 0x6439F10
        public void TryGetLength(){} // RVA: 0x6439FA0
        public void IsFileStream(){} // RVA: 0x643A040
        public void .cctor(){} // RVA: 0x643A130
    }

    public class StringExtensions
    {
        // ── Methods ──
        public void ToSnakeCase(){} // RVA: 0x643B7F0
        public void NullIfWhitespace(){} // RVA: 0x643B890
        public void ParseHexAsLong(){} // RVA: 0x643B8C0
    }

    public class UriExtensions
    {
        // ── Methods ──
        public void HttpRequestUrl(){} // RVA: 0x643BA90
    }

}