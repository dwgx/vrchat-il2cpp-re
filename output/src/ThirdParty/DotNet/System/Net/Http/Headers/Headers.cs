// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 35
// Methods: 348

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class AuthenticationHeaderValue : Object
    {
        public string _parameter; // 0x10
        public string _scheme; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Parameter(){} // RVA: 0x7FFE81116380
        public void set_Parameter(){} // RVA: 0x7FFE810FCE30
        public void get_Scheme(){} // RVA: 0x7FFE810FE7C0
        public void set_Scheme(){} // RVA: 0x7FFE81161E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE87348230
        public void GetHashCode(){} // RVA: 0x7FFE873483E0
        public void TryParse(){} // RVA: 0x7FFE873485D0 | overloaded x2
        public void TryParseElement(){} // RVA: 0x7FFE87348690
        public void ToString(){} // RVA: 0x7FFE87348A10
    }

    public class CacheControlHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> extensions; // 0x10
        public System.Collections.Generic.List`1<string> no_cache_headers; // 0x18
        public System.Collections.Generic.List`1<string> private_headers; // 0x20
        public System.Nullable`1<System.TimeSpan> _maxAge; // 0x28
        public bool _maxStale; // 0x38
        public System.Nullable`1<System.TimeSpan> _maxStaleLimit; // 0x40
        public System.Nullable`1<System.TimeSpan> _minFresh; // 0x50
        public bool _mustRevalidate; // 0x60
        public bool _noCache; // 0x61
        public bool _noStore; // 0x62
        public bool _noTransform; // 0x63
        public bool _onlyIfCached; // 0x64
        public bool _private; // 0x65
        public bool _proxyRevalidate; // 0x66
        public bool _public; // 0x67
        public System.Nullable`1<System.TimeSpan> _sharedMaxAge; // 0x68

        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7FFE87348A70
        public void get_MaxAge(){} // RVA: 0x7FFE81E90600
        public void set_MaxAge(){} // RVA: 0x7FFE81E8E800
        public void get_MaxStale(){} // RVA: 0x7FFE812CF770
        public void set_MaxStale(){} // RVA: 0x7FFE812D0010
        public void get_MaxStaleLimit(){} // RVA: 0x7FFE82D32FA0
        public void set_MaxStaleLimit(){} // RVA: 0x7FFE850A4980
        public void get_MinFresh(){} // RVA: 0x7FFE84E45FD0
        public void set_MinFresh(){} // RVA: 0x7FFE8667B700
        public void get_MustRevalidate(){} // RVA: 0x7FFE81124020
        public void set_MustRevalidate(){} // RVA: 0x7FFE81124030
        public void get_NoCache(){} // RVA: 0x7FFE81EC3970
        public void set_NoCache(){} // RVA: 0x7FFE81EB6360
        public void get_NoCacheHeaders(){} // RVA: 0x7FFE87348B30
        public void get_NoStore(){} // RVA: 0x7FFE8112FE50
        public void set_NoStore(){} // RVA: 0x7FFE821D5E70
        public void get_NoTransform(){} // RVA: 0x7FFE8112FE40
        public void set_NoTransform(){} // RVA: 0x7FFE87348BF0
        public void get_OnlyIfCached(){} // RVA: 0x7FFE821FF050
        public void set_OnlyIfCached(){} // RVA: 0x7FFE82A22EE0
        public void get_Private(){} // RVA: 0x7FFE872487A0
        public void set_Private(){} // RVA: 0x7FFE87348C00
        public void get_PrivateHeaders(){} // RVA: 0x7FFE87348C10
        public void get_ProxyRevalidate(){} // RVA: 0x7FFE87248700
        public void set_ProxyRevalidate(){} // RVA: 0x7FFE87348CD0
        public void get_Public(){} // RVA: 0x7FFE872486F0
        public void set_Public(){} // RVA: 0x7FFE87348CE0
        public void get_SharedMaxAge(){} // RVA: 0x7FFE8432FD10
        public void set_SharedMaxAge(){} // RVA: 0x7FFE84330180
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE87348CF0
        public void Equals(){} // RVA: 0x7FFE87349470
        public void GetHashCode(){} // RVA: 0x7FFE87349830
        public void TryParse(){} // RVA: 0x7FFE87349C10
        public void ToString(){} // RVA: 0x7FFE8734ABF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void SequenceEqual(){} // RVA: 0x7FFE80E2F7A0
        public void SetValue(){} // RVA: 0x7FFE8734B630
        public void ToString(){} // RVA: 0x7FFE80E2E3D0
        public void ToStringBuilder(){} // RVA: 0x7FFE80E462E0
    }

    public class CollectionParser : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFE8734B8B0 | overloaded x2
        public void TryParseStringElement(){} // RVA: 0x7FFE8734B970
    }

    public class ContentDispositionHeaderValue : Object
    {
        public string dispositionType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8734BBB0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE8734BF50
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE8734C010
        public void Equals(){} // RVA: 0x7FFE8734C070
        public void GetHashCode(){} // RVA: 0x7FFE8734C270
        public void ToString(){} // RVA: 0x7FFE8734C2F0
        public void TryParse(){} // RVA: 0x7FFE8734C350
    }

    public class ContentRangeHeaderValue : Object
    {
        public string unit; // 0x10
        public System.Nullable`1<long> _from; // 0x18
        public System.Nullable`1<long> _length; // 0x28
        public System.Nullable`1<long> _to; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8734C6C0
        public void get_From(){} // RVA: 0x7FFE81703940
        public void set_From(){} // RVA: 0x7FFE817036E0
        public void get_Length(){} // RVA: 0x7FFE81E90600
        public void set_Length(){} // RVA: 0x7FFE81E8E800
        public void get_To(){} // RVA: 0x7FFE826F9FB0
        public void set_To(){} // RVA: 0x7FFE82D001B0
        public void get_Unit(){} // RVA: 0x7FFE81116380
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8734C750
        public void GetHashCode(){} // RVA: 0x7FFE8734C940
        public void TryParse(){} // RVA: 0x7FFE8734CAD0
        public void ToString(){} // RVA: 0x7FFE8734D160
    }

    public class ElementTryParser`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class EntityTagHeaderValue : Object
    {
        public System.Net.Http.Headers.EntityTagHeaderValue any;
        public bool _isWeak; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_IsWeak(){} // RVA: 0x7FFE811C55E0
        public void set_IsWeak(){} // RVA: 0x7FFE811C55F0
        public void get_Tag(){} // RVA: 0x7FFE810FE7C0
        public void set_Tag(){} // RVA: 0x7FFE81161E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8734D3D0
        public void GetHashCode(){} // RVA: 0x7FFE8734D540
        public void TryParse(){} // RVA: 0x7FFE8734DB70 | overloaded x2
        public void TryParseElement(){} // RVA: 0x7FFE8734D740
        public void ToString(){} // RVA: 0x7FFE8734DC30
        public void .cctor(){} // RVA: 0x7FFE8734DC90
    }

    public class HashCodeCalculator : Object
    {
        // ── Methods ──
        public void Calculate(){} // RVA: 0x7FFE80E2EE90
    }

    public class HeaderInfo : Object
    {
        public bool AllowsMany; // 0x10
        public 0x6669D12C HeaderKind; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8734DDB0
        public void CreateSingle(){} // RVA: 0x7FFE80E401A0
        public void CreateMulti(){} // RVA: 0x7FFE810A1420
        public void CreateCollection(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void get_CustomToString(){} // RVA: 0x7FFE811290C0
        public void set_CustomToString(){} // RVA: 0x7FFE811290D0
        public void get_Separator(){} // RVA: 0x7FFE8734DE30
        public void AddToCollection(){} // RVA: 0x7FFE80E4F230
        public void ToStringCollection(){} // RVA: 0x7FFE80E2E390
        public void TryParse(){} // RVA: 0x7FFE80E32650
    }

    public class HttpContentHeaders : HttpHeaders
    {
        public System.Net.Http.HttpContent content; // 0x20
        public object field_1; // 0x41
        public object field_2; // 0x42

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8734DE70
        public void get_ContentEncoding(){} // RVA: 0x7FFE8734DF20
        public void get_ContentLength(){} // RVA: 0x7FFE8734DF80
        public void get_ContentType(){} // RVA: 0x7FFE8734E2A0
        public void set_ContentType(){} // RVA: 0x7FFE8734E300
    }

    public class HttpHeaderValueCollection`1 : Object
    {
        public System.Collections.Generic.List`1<T> list;
        public System.Net.Http.Headers.HttpHeaders headers;
        public System.Net.Http.Headers.HeaderInfo headerInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_InvalidValues(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddRange(){} // RVA: 0x7FFE80E460A0
        public void AddInvalidValue(){} // RVA: 0x7FFE80E460A0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Find(){} // RVA: 0x7FFE810A1420
    }

    public class HttpHeaders : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8734E440
        public void .ctor(){} // RVA: 0x7FFE873510E0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE873512D0 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFE87351370
        public void TryAddWithoutValidation(){} // RVA: 0x7FFE87351820
        public void CheckName(){} // RVA: 0x7FFE873518F0
        public void TryCheckName(){} // RVA: 0x7FFE87351A70
        public void Contains(){} // RVA: 0x7FFE87351BF0
        public void GetEnumerator(){} // RVA: 0x7FFE87351C70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87351D10
        public void Remove(){} // RVA: 0x7FFE87351D20
        public void TryGetValues(){} // RVA: 0x7FFE87351D90
        public void GetSingleHeaderString(){} // RVA: 0x7FFE87351F50
        public void ToString(){} // RVA: 0x7FFE873522F0
        public void AddOrRemove(){} // RVA: 0x7FFE810A1420
        public void GetAllHeaderValues(){} // RVA: 0x7FFE873525D0
        public void GetKnownHeaderKind(){} // RVA: 0x7FFE873527B0
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void GetValues(){} // RVA: 0x7FFE80E2E390
        public void SetValue(){} // RVA: 0x7FFE810A1420
    }

    public class HttpRequestHeaders : HttpHeaders
    {
        public System.Nullable`1<bool> expectContinue; // 0x20
        public object field_1; // 0x4B
        public object field_2; // 0x4C
        public object field_3; // 0x4D
        public object field_4; // 0x4E
        public object field_5; // 0x4F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87352FB0
        public void get_Connection(){} // RVA: 0x7FFE87353010
        public void get_ConnectionClose(){} // RVA: 0x7FFE87353070
        public void get_ExpectContinue(){} // RVA: 0x7FFE873532C0
        public void get_Host(){} // RVA: 0x7FFE87353500
        public void get_TransferEncoding(){} // RVA: 0x7FFE87353560
        public void get_TransferEncodingChunked(){} // RVA: 0x7FFE873535C0
        public void AddHeaders(){} // RVA: 0x7FFE87353800
    }

    public class HttpResponseHeaders : HttpHeaders
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87353E40
        public void get_RetryAfter(){} // RVA: 0x7FFE87353EA0
    }

    public class Lexer : Object
    {
        public bool[] token_chars;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Position(){} // RVA: 0x7FFE813DB630
        public void set_Position(){} // RVA: 0x7FFE8144DF00
        public void GetStringValue(){} // RVA: 0x7FFE873540F0 | overloaded x2
        public void GetQuotedStringValue(){} // RVA: 0x7FFE87354180
        public void GetRemainingStringValue(){} // RVA: 0x7FFE87354200
        public void IsStarStringValue(){} // RVA: 0x7FFE87354240
        public void TryGetNumericValue(){} // RVA: 0x7FFE87354430 | overloaded x2
        public void TryGetTimeSpanValue(){} // RVA: 0x7FFE87354570
        public void TryGetDateValue(){} // RVA: 0x7FFE873547F0 | overloaded x2
        public void TryGetDoubleValue(){} // RVA: 0x7FFE873548F0
        public void IsValidToken(){} // RVA: 0x7FFE87354A30
        public void IsValidCharacter(){} // RVA: 0x7FFE87354B80
        public void EatChar(){} // RVA: 0x7FFE87354C30
        public void PeekChar(){} // RVA: 0x7FFE87354C40
        public void ScanCommentOptional(){} // RVA: 0x7FFE87354C90
        public void Scan(){} // RVA: 0x7FFE87354EC0
        public void .cctor(){} // RVA: 0x7FFE87355260
    }

    public class MediaTypeHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x10
        public string media_type; // 0x18
        public object field_2; // 0x56

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void get_CharSet(){} // RVA: 0x7FFE87355A40
        public void set_CharSet(){} // RVA: 0x7FFE87355BD0
        public void get_MediaType(){} // RVA: 0x7FFE810FE7C0
        public void set_MediaType(){} // RVA: 0x7FFE873554D0
        public void get_Parameters(){} // RVA: 0x7FFE87355CD0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE87355D90
        public void Equals(){} // RVA: 0x7FFE87355DF0
        public void GetHashCode(){} // RVA: 0x7FFE87355FF0
        public void Parse(){} // RVA: 0x7FFE87356070
        public void ToString(){} // RVA: 0x7FFE873560F0
        public void TryParse(){} // RVA: 0x7FFE87356160
        public void TryParseMediaType(){} // RVA: 0x7FFE87356470
    }

    public class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void TryParseElement(){} // RVA: 0x7FFE873568F0
        public void TryParse(){} // RVA: 0x7FFE87356BF0
    }

    public class NameValueHeaderValue : Object
    {
        public string value; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE87356E20
        public void Create(){} // RVA: 0x7FFE87357090
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE873571A0
        public void GetHashCode(){} // RVA: 0x7FFE873483E0
        public void Equals(){} // RVA: 0x7FFE87357200
        public void TryParsePragma(){} // RVA: 0x7FFE87357420
        public void TryParseParameters(){} // RVA: 0x7FFE873574E0
        public void ToString(){} // RVA: 0x7FFE873579F0
        public void TryParseElement(){} // RVA: 0x7FFE87357A50
    }

    public class NameValueWithParametersHeaderValue : NameValueHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE87358120
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE873581E0
        public void Equals(){} // RVA: 0x7FFE87358240
        public void GetHashCode(){} // RVA: 0x7FFE87358390
        public void ToString(){} // RVA: 0x7FFE87358450
        public void TryParse(){} // RVA: 0x7FFE87358570
        public void TryParseElement(){} // RVA: 0x7FFE87358630
    }

    public class Parser : Object
    {
    }

    public class ProductHeaderValue : Object
    {
        public string _name; // 0x10
        public string _version; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void set_Version(){} // RVA: 0x7FFE81161E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE87359910
        public void GetHashCode(){} // RVA: 0x7FFE87359B20
        public void TryParse(){} // RVA: 0x7FFE87359BA0
        public void TryParseElement(){} // RVA: 0x7FFE87359C60
        public void ToString(){} // RVA: 0x7FFE87359FD0
    }

    public class ProductInfoHeaderValue : Object
    {
        public string _comment; // 0x10
        public System.Net.Http.Headers.ProductHeaderValue _product; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Comment(){} // RVA: 0x7FFE81116380
        public void set_Comment(){} // RVA: 0x7FFE810FCE30
        public void get_Product(){} // RVA: 0x7FFE810FE7C0
        public void set_Product(){} // RVA: 0x7FFE81161E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735A0D0
        public void GetHashCode(){} // RVA: 0x7FFE8735A1D0
        public void TryParse(){} // RVA: 0x7FFE8735A210
        public void TryParseElement(){} // RVA: 0x7FFE8735A470
        public void ToString(){} // RVA: 0x7FFE8735A870
    }

    public class RangeConditionHeaderValue : Object
    {
        public System.Nullable`1<System.DateTimeOffset> _date; // 0x10
        public System.Net.Http.Headers.EntityTagHeaderValue _entityTag; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8735A910 | overloaded x2
        public void get_Date(){} // RVA: 0x7FFE82D1D7C0
        public void set_Date(){} // RVA: 0x7FFE82D1D7E0
        public void get_EntityTag(){} // RVA: 0x7FFE81129130
        public void set_EntityTag(){} // RVA: 0x7FFE810FCE90
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735A9C0
        public void GetHashCode(){} // RVA: 0x7FFE8735AB40
        public void TryParse(){} // RVA: 0x7FFE8735AC30
        public void ToString(){} // RVA: 0x7FFE8735B0C0
    }

    public class RangeHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.RangeItemHeaderValue> ranges; // 0x10
        public string unit; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8735B260 | overloaded x2
        public void get_Ranges(){} // RVA: 0x7FFE8735B4A0
        public void get_Unit(){} // RVA: 0x7FFE810FE7C0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE8735B560
        public void Equals(){} // RVA: 0x7FFE8735B5C0
        public void GetHashCode(){} // RVA: 0x7FFE8735B7C0
        public void TryParse(){} // RVA: 0x7FFE8735B840
        public void ToString(){} // RVA: 0x7FFE8735C020
    }

    public class RangeItemHeaderValue : Object
    {
        public System.Nullable`1<long> _from; // 0x10
        public System.Nullable`1<long> _to; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8735C260
        public void get_From(){} // RVA: 0x7FFE826F6B90
        public void set_From(){} // RVA: 0x7FFE826F6BA0
        public void get_To(){} // RVA: 0x7FFE82C84C90
        public void set_To(){} // RVA: 0x7FFE8671A610
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735C440
        public void GetHashCode(){} // RVA: 0x7FFE8735C530
        public void ToString(){} // RVA: 0x7FFE8735C610
    }

    public class RetryConditionHeaderValue : Object
    {
        public System.Nullable`1<System.DateTimeOffset> _date; // 0x10
        public System.Nullable`1<System.TimeSpan> _delta; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8735C870 | overloaded x2
        public void get_Date(){} // RVA: 0x7FFE82D1D7C0
        public void set_Date(){} // RVA: 0x7FFE82D1D7E0
        public void get_Delta(){} // RVA: 0x7FFE81E90600
        public void set_Delta(){} // RVA: 0x7FFE81E8E800
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735C950
        public void GetHashCode(){} // RVA: 0x7FFE8735CB20
        public void TryParse(){} // RVA: 0x7FFE8735CC90
        public void ToString(){} // RVA: 0x7FFE8735D020
    }

    public class StringWithQualityHeaderValue : Object
    {
        public System.Nullable`1<double> _quality; // 0x10
        public string _value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Quality(){} // RVA: 0x7FFE826F6B90
        public void set_Quality(){} // RVA: 0x7FFE826F6BA0
        public void get_Value(){} // RVA: 0x7FFE811290C0
        public void set_Value(){} // RVA: 0x7FFE811290D0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735D200
        public void GetHashCode(){} // RVA: 0x7FFE8735D3B0
        public void TryParse(){} // RVA: 0x7FFE8735D4A0
        public void TryParseElement(){} // RVA: 0x7FFE8735D560
        public void ToString(){} // RVA: 0x7FFE8735DB10
    }

    public class Token : ValueType
    {
        public System.Net.Http.Headers.Token Empty;
        public dFixup.ties type; // 0x10
        public int _startPosition; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87353F00
        public void get_StartPosition(){} // RVA: 0x7FFE826F42A0
        public void set_StartPosition(){} // RVA: 0x7FFE826F4290
        public void get_EndPosition(){} // RVA: 0x7FFE82C33000
        public void set_EndPosition(){} // RVA: 0x7FFE82C33010
        public void get_Kind(){} // RVA: 0x7FFE826F4220
        public void op_Implicit(){} // RVA: 0x7FFE826F4220
        public void ToString(){} // RVA: 0x7FFE87353F80
        public void .cctor(){} // RVA: 0x7FFE87353FE0
    }

    public class TransferCodingHeaderValue : Object
    {
        public string value; // 0x10
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE8735DFD0
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE8735E090
        public void Equals(){} // RVA: 0x7FFE8735E0F0
        public void GetHashCode(){} // RVA: 0x7FFE8735E2F0
        public void ToString(){} // RVA: 0x7FFE8735E380
        public void TryParse(){} // RVA: 0x7FFE8735E3E0
        public void TryParseElement(){} // RVA: 0x7FFE8735E4A0
    }

    public class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void TryParse(){} // RVA: 0x7FFE8735E770
        public void TryParseElement(){} // RVA: 0x7FFE8735E830
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E32650
    }

    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class ViaHeaderValue : Object
    {
        public string _comment; // 0x10
        public string _protocolName; // 0x18
        public string _protocolVersion; // 0x20
        public string _receivedBy; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Comment(){} // RVA: 0x7FFE81116380
        public void set_Comment(){} // RVA: 0x7FFE810FCE30
        public void get_ProtocolName(){} // RVA: 0x7FFE810FE7C0
        public void set_ProtocolName(){} // RVA: 0x7FFE81161E80
        public void get_ProtocolVersion(){} // RVA: 0x7FFE811290C0
        public void set_ProtocolVersion(){} // RVA: 0x7FFE811290D0
        public void get_ReceivedBy(){} // RVA: 0x7FFE81129130
        public void set_ReceivedBy(){} // RVA: 0x7FFE810FCE90
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735EB00
        public void GetHashCode(){} // RVA: 0x7FFE8735EE10
        public void TryParse(){} // RVA: 0x7FFE8735EF10
        public void TryParseElement(){} // RVA: 0x7FFE8735EFD0
        public void ToString(){} // RVA: 0x7FFE8735F590
    }

    public class WarningHeaderValue : Object
    {
        public string _agent; // 0x10
        public int _code; // 0x18
        public System.Nullable`1<System.DateTimeOffset> _date; // 0x20
        public string _text; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Agent(){} // RVA: 0x7FFE81116380
        public void set_Agent(){} // RVA: 0x7FFE810FCE30
        public void get_Code(){} // RVA: 0x7FFE813DB630
        public void set_Code(){} // RVA: 0x7FFE8144DF00
        public void get_Date(){} // RVA: 0x7FFE828DAC10
        public void set_Date(){} // RVA: 0x7FFE828DAED0
        public void get_Text(){} // RVA: 0x7FFE8143BA80
        public void set_Text(){} // RVA: 0x7FFE81437330
        public void IsCodeValid(){} // RVA: 0x7FFE8735F6C0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE8735F6E0
        public void GetHashCode(){} // RVA: 0x7FFE8735F960
        public void TryParse(){} // RVA: 0x7FFE8735FAA0
        public void TryParseElement(){} // RVA: 0x7FFE8735FB60
        public void ToString(){} // RVA: 0x7FFE87360110
    }

}