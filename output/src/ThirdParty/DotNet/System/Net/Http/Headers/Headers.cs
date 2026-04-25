// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 35
// Methods: 348

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class AuthenticationHeaderValue : Object
    {
        public string Parameter; // 0x10
        public string Scheme; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Parameter(){} // RVA: 0x7FFAC2F3C380
        public void set_Parameter(){} // RVA: 0x7FFAC2F22E30
        public void get_Scheme(){} // RVA: 0x7FFAC2F247C0
        public void set_Scheme(){} // RVA: 0x7FFAC2F87E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8F9FE10
        public void GetHashCode(){} // RVA: 0x7FFAC8F9FFC0
        public void TryParse(){} // RVA: 0x7FFAC8FA01B0 | overloaded x2
        public void TryParseElement(){} // RVA: 0x7FFAC8FA0270
        public void ToString(){} // RVA: 0x7FFAC8FA05F0
    }

    public class CacheControlHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> Extensions; // 0x10
        public System.Collections.Generic.List`1<string> MaxAge; // 0x18
        public System.Collections.Generic.List`1<string> MaxStale; // 0x20
        public System.Nullable`1<System.TimeSpan> MaxStaleLimit; // 0x28
        public bool MinFresh; // 0x38
        public System.Nullable`1<System.TimeSpan> MustRevalidate; // 0x40
        public System.Nullable`1<System.TimeSpan> NoCache; // 0x50
        public bool NoCacheHeaders; // 0x60
        public bool NoStore; // 0x61
        public bool NoTransform; // 0x62
        public bool OnlyIfCached; // 0x63
        public bool Private; // 0x64
        public bool PrivateHeaders; // 0x65
        public bool ProxyRevalidate; // 0x66
        public bool Public; // 0x67
        public System.Nullable`1<System.TimeSpan> SharedMaxAge; // 0x68

        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7FFAC8FA0650
        public void get_MaxAge(){} // RVA: 0x7FFAC3BCF020
        public void set_MaxAge(){} // RVA: 0x7FFAC3BCC210
        public void get_MaxStale(){} // RVA: 0x7FFAC31D95D0
        public void set_MaxStale(){} // RVA: 0x7FFAC31D95C0
        public void get_MaxStaleLimit(){} // RVA: 0x7FFAC4AC8580
        public void set_MaxStaleLimit(){} // RVA: 0x7FFAC6D1E430
        public void get_MinFresh(){} // RVA: 0x7FFAC6AD4D90
        public void set_MinFresh(){} // RVA: 0x7FFAC82D1E00
        public void get_MustRevalidate(){} // RVA: 0x7FFAC2F4A020
        public void set_MustRevalidate(){} // RVA: 0x7FFAC2F4A030
        public void get_NoCache(){} // RVA: 0x7FFAC3C11000
        public void set_NoCache(){} // RVA: 0x7FFAC3C04530
        public void get_NoCacheHeaders(){} // RVA: 0x7FFAC8FA0710
        public void get_NoStore(){} // RVA: 0x7FFAC2F55E50
        public void set_NoStore(){} // RVA: 0x7FFAC3F24840
        public void get_NoTransform(){} // RVA: 0x7FFAC2F55E40
        public void set_NoTransform(){} // RVA: 0x7FFAC8FA07D0
        public void get_OnlyIfCached(){} // RVA: 0x7FFAC3F45FE0
        public void set_OnlyIfCached(){} // RVA: 0x7FFAC47BAB40
        public void get_Private(){} // RVA: 0x7FFAC8EA0370
        public void set_Private(){} // RVA: 0x7FFAC8FA07E0
        public void get_PrivateHeaders(){} // RVA: 0x7FFAC8FA07F0
        public void get_ProxyRevalidate(){} // RVA: 0x7FFAC8EA02D0
        public void set_ProxyRevalidate(){} // RVA: 0x7FFAC8FA08B0
        public void get_Public(){} // RVA: 0x7FFAC8EA02C0
        public void set_Public(){} // RVA: 0x7FFAC8FA08C0
        public void get_SharedMaxAge(){} // RVA: 0x7FFAC5FD87B0
        public void set_SharedMaxAge(){} // RVA: 0x7FFAC5FD8C20
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FA08D0
        public void Equals(){} // RVA: 0x7FFAC8FA1050
        public void GetHashCode(){} // RVA: 0x7FFAC8FA1410
        public void TryParse(){} // RVA: 0x7FFAC8FA17F0
        public void ToString(){} // RVA: 0x7FFAC8FA27D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void SequenceEqual(){} // RVA: 0x7FFAC2C5A350
        public void SetValue(){} // RVA: 0x7FFAC8FA3210
        public void ToString(){} // RVA: 0x7FFAC2C58F80
        public void ToStringBuilder(){} // RVA: 0x7FFAC2C70C80
    }

    public class CollectionParser : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFAC8FA3490 | overloaded x2
        public void TryParseStringElement(){} // RVA: 0x7FFAC8FA3550
    }

    public class ContentDispositionHeaderValue : Object
    {
        public string Parameters; // 0x10
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FA3790 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC8FA3B30
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FA3BF0
        public void Equals(){} // RVA: 0x7FFAC8FA3C50
        public void GetHashCode(){} // RVA: 0x7FFAC8FA3E50
        public void ToString(){} // RVA: 0x7FFAC8FA3ED0
        public void TryParse(){} // RVA: 0x7FFAC8FA3F30
    }

    public class ContentRangeHeaderValue : Object
    {
        public string From; // 0x10
        public System.Nullable`1<long> Length; // 0x18
        public System.Nullable`1<long> To; // 0x28
        public System.Nullable`1<long> Unit; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FA42A0
        public void get_From(){} // RVA: 0x7FFAC35D3330
        public void set_From(){} // RVA: 0x7FFAC35D34F0
        public void get_Length(){} // RVA: 0x7FFAC3BCF020
        public void set_Length(){} // RVA: 0x7FFAC3BCC210
        public void get_To(){} // RVA: 0x7FFAC4426F60
        public void set_To(){} // RVA: 0x7FFAC4A97FB0
        public void get_Unit(){} // RVA: 0x7FFAC2F3C380
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FA4330
        public void GetHashCode(){} // RVA: 0x7FFAC8FA4520
        public void TryParse(){} // RVA: 0x7FFAC8FA46B0
        public void ToString(){} // RVA: 0x7FFAC8FA4D40
    }

    public class ElementTryParser`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class EntityTagHeaderValue : Object
    {
        public System.Net.Http.Headers.EntityTagHeaderValue IsWeak;
        public bool Tag; // 0x10
        public string <Tag>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_IsWeak(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsWeak(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Tag(){} // RVA: 0x7FFAC2F247C0
        public void set_Tag(){} // RVA: 0x7FFAC2F87E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FA4FB0
        public void GetHashCode(){} // RVA: 0x7FFAC8FA5120
        public void TryParse(){} // RVA: 0x7FFAC8FA5750 | overloaded x2
        public void TryParseElement(){} // RVA: 0x7FFAC8FA5320
        public void ToString(){} // RVA: 0x7FFAC8FA5810
        public void .cctor(){} // RVA: 0x7FFAC8FA5870
    }

    public class HashCodeCalculator : Object
    {
        // ── Methods ──
        public void Calculate(){} // RVA: 0x7FFAC2C59A40
    }

    public class HeaderInfo : Object
    {
        public bool CustomToString; // 0x10
        public 0x6B2A3340 Separator; // 0x14
        public string Name; // 0x18
        public System.Func`2<object,string> <CustomToString>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FA5990
        public void CreateSingle(){} // RVA: 0x7FFAC2C6AC80
        public void CreateMulti(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCollection(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void get_CustomToString(){} // RVA: 0x7FFAC2F4F0C0
        public void set_CustomToString(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Separator(){} // RVA: 0x7FFAC8FA5A10
        public void AddToCollection(){} // RVA: 0x7FFAC2C79B30
        public void ToStringCollection(){} // RVA: 0x7FFAC2C58F40
        public void TryParse(){} // RVA: 0x7FFAC2C5D200
    }

    public class HttpContentHeaders : HttpHeaders
    {
        public System.Net.Http.HttpContent ContentEncoding; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FA5A50
        public void get_ContentEncoding(){} // RVA: 0x7FFAC8FA5B00
        public void get_ContentLength(){} // RVA: 0x7FFAC8FA5B60
        public void get_ContentType(){} // RVA: 0x7FFAC8FA5E80
        public void set_ContentType(){} // RVA: 0x7FFAC8FA5EE0
    }

    public class HttpHeaderValueCollection`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;
        public System.Net.Http.Headers.HttpHeaders InvalidValues;
        public System.Net.Http.Headers.HeaderInfo IsReadOnly;
        public System.Collections.Generic.List`1<string> invalidValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_InvalidValues(){} // RVA: 0x7FFAC2C58E90
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddRange(){} // RVA: 0x7FFAC2C70A40
        public void AddInvalidValue(){} // RVA: 0x7FFAC2C70A40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Find(){} // RVA: 0x7FFAC2E8DC40
    }

    public class HttpHeaders : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Net.Http.Headers.HeaderInfo> known_headers;
        public System.Collections.Generic.Dictionary`2<string,HeaderBucket> headers; // 0x10
        public 0x6B2A3340 HeaderKind; // 0x18
        public System.Nullable`1<bool> connectionclose; // 0x1C
        public System.Nullable`1<bool> transferEncodingChunked; // 0x1E

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8FA6020
        public void .ctor(){} // RVA: 0x7FFAC8FA8CC0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC8FA8EB0 | overloaded x2
        public void AddInternal(){} // RVA: 0x7FFAC8FA8F50
        public void TryAddWithoutValidation(){} // RVA: 0x7FFAC8FA9400
        public void CheckName(){} // RVA: 0x7FFAC8FA94D0
        public void TryCheckName(){} // RVA: 0x7FFAC8FA9650
        public void Contains(){} // RVA: 0x7FFAC8FA97D0
        public void GetEnumerator(){} // RVA: 0x7FFAC8FA9850
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8FA98F0
        public void Remove(){} // RVA: 0x7FFAC8FA9900
        public void TryGetValues(){} // RVA: 0x7FFAC8FA9970
        public void GetSingleHeaderString(){} // RVA: 0x7FFAC8FA9B30
        public void ToString(){} // RVA: 0x7FFAC8FA9ED0
        public void AddOrRemove(){} // RVA: 0x7FFAC2E8DC40
        public void GetAllHeaderValues(){} // RVA: 0x7FFAC8FAA1B0
        public void GetKnownHeaderKind(){} // RVA: 0x7FFAC8FAA390
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void GetValues(){} // RVA: 0x7FFAC2C58F40
        public void SetValue(){} // RVA: 0x7FFAC2E8DC40
    }

    public class HttpRequestHeaders : HttpHeaders
    {
        public System.Nullable`1<bool> Connection; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FAAB90
        public void get_Connection(){} // RVA: 0x7FFAC8FAABF0
        public void get_ConnectionClose(){} // RVA: 0x7FFAC8FAAC50
        public void get_ExpectContinue(){} // RVA: 0x7FFAC8FAAEA0
        public void get_Host(){} // RVA: 0x7FFAC8FAB0E0
        public void get_TransferEncoding(){} // RVA: 0x7FFAC8FAB140
        public void get_TransferEncodingChunked(){} // RVA: 0x7FFAC8FAB1A0
        public void AddHeaders(){} // RVA: 0x7FFAC8FAB3E0
    }

    public class HttpResponseHeaders : HttpHeaders
    {
        public object RetryAfter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FABA20
        public void get_RetryAfter(){} // RVA: 0x7FFAC8FABA80
    }

    public class Lexer : Object
    {
        public bool[] Position;
        public int last_token_char; // 0x8
        public string[] dt_formats; // 0x10
        public string s; // 0x10
        public int pos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Position(){} // RVA: 0x7FFAC3157800
        public void set_Position(){} // RVA: 0x7FFAC392CD10
        public void GetStringValue(){} // RVA: 0x7FFAC8FABCD0 | overloaded x2
        public void GetQuotedStringValue(){} // RVA: 0x7FFAC8FABD60
        public void GetRemainingStringValue(){} // RVA: 0x7FFAC8FABDE0
        public void IsStarStringValue(){} // RVA: 0x7FFAC8FABE20
        public void TryGetNumericValue(){} // RVA: 0x7FFAC8FAC010 | overloaded x2
        public void TryGetTimeSpanValue(){} // RVA: 0x7FFAC8FAC150
        public void TryGetDateValue(){} // RVA: 0x7FFAC8FAC3D0 | overloaded x2
        public void TryGetDoubleValue(){} // RVA: 0x7FFAC8FAC4D0
        public void IsValidToken(){} // RVA: 0x7FFAC8FAC610
        public void IsValidCharacter(){} // RVA: 0x7FFAC8FAC760
        public void EatChar(){} // RVA: 0x7FFAC8FAC810
        public void PeekChar(){} // RVA: 0x7FFAC8FAC820
        public void ScanCommentOptional(){} // RVA: 0x7FFAC8FAC870
        public void Scan(){} // RVA: 0x7FFAC8FACAA0
        public void .cctor(){} // RVA: 0x7FFAC8FACE40
    }

    public class MediaTypeHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> CharSet; // 0x10
        public string MediaType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void get_CharSet(){} // RVA: 0x7FFAC8FAD620
        public void set_CharSet(){} // RVA: 0x7FFAC8FAD7B0
        public void get_MediaType(){} // RVA: 0x7FFAC2F247C0
        public void set_MediaType(){} // RVA: 0x7FFAC8FAD0B0
        public void get_Parameters(){} // RVA: 0x7FFAC8FAD8B0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FAD970
        public void Equals(){} // RVA: 0x7FFAC8FAD9D0
        public void GetHashCode(){} // RVA: 0x7FFAC8FADBD0
        public void Parse(){} // RVA: 0x7FFAC8FADC50
        public void ToString(){} // RVA: 0x7FFAC8FADCD0
        public void TryParse(){} // RVA: 0x7FFAC8FADD40
        public void TryParseMediaType(){} // RVA: 0x7FFAC8FAE050
    }

    public class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void TryParseElement(){} // RVA: 0x7FFAC8FAE4D0
        public void TryParse(){} // RVA: 0x7FFAC8FAE7D0
    }

    public class NameValueHeaderValue : Object
    {
        public string Name; // 0x10
        public string Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC8FAEA00
        public void Create(){} // RVA: 0x7FFAC8FAEC70
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FAED80
        public void GetHashCode(){} // RVA: 0x7FFAC8F9FFC0
        public void Equals(){} // RVA: 0x7FFAC8FAEDE0
        public void TryParsePragma(){} // RVA: 0x7FFAC8FAF000
        public void TryParseParameters(){} // RVA: 0x7FFAC8FAF0C0
        public void ToString(){} // RVA: 0x7FFAC8FAF5D0
        public void TryParseElement(){} // RVA: 0x7FFAC8FAF630
    }

    public class NameValueWithParametersHeaderValue : NameValueHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC8FAFD00
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FAFDC0
        public void Equals(){} // RVA: 0x7FFAC8FAFE20
        public void GetHashCode(){} // RVA: 0x7FFAC8FAFF70
        public void ToString(){} // RVA: 0x7FFAC8FB0030
        public void TryParse(){} // RVA: 0x7FFAC8FB0150
        public void TryParseElement(){} // RVA: 0x7FFAC8FB0210
    }

    public class Parser : Object
    {
    }

    public class ProductHeaderValue : Object
    {
        public string Name; // 0x10
        public string Version; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void set_Version(){} // RVA: 0x7FFAC2F87E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB14F0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB1700
        public void TryParse(){} // RVA: 0x7FFAC8FB1780
        public void TryParseElement(){} // RVA: 0x7FFAC8FB1840
        public void ToString(){} // RVA: 0x7FFAC8FB1BB0
    }

    public class ProductInfoHeaderValue : Object
    {
        public string Comment; // 0x10
        public System.Net.Http.Headers.ProductHeaderValue Product; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Comment(){} // RVA: 0x7FFAC2F3C380
        public void set_Comment(){} // RVA: 0x7FFAC2F22E30
        public void get_Product(){} // RVA: 0x7FFAC2F247C0
        public void set_Product(){} // RVA: 0x7FFAC2F87E80
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB1CB0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB1DB0
        public void TryParse(){} // RVA: 0x7FFAC8FB1DF0
        public void TryParseElement(){} // RVA: 0x7FFAC8FB2050
        public void ToString(){} // RVA: 0x7FFAC8FB2450
    }

    public class RangeConditionHeaderValue : Object
    {
        public System.Nullable`1<System.DateTimeOffset> Date; // 0x10
        public System.Net.Http.Headers.EntityTagHeaderValue EntityTag; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FB24F0 | overloaded x2
        public void get_Date(){} // RVA: 0x7FFAC4AB3E90
        public void set_Date(){} // RVA: 0x7FFAC4AB3EB0
        public void get_EntityTag(){} // RVA: 0x7FFAC2F4F130
        public void set_EntityTag(){} // RVA: 0x7FFAC2F22E90
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB25A0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB2720
        public void TryParse(){} // RVA: 0x7FFAC8FB2810
        public void ToString(){} // RVA: 0x7FFAC8FB2CA0
    }

    public class RangeHeaderValue : Object
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.RangeItemHeaderValue> Ranges; // 0x10
        public string Unit; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FB2E40 | overloaded x2
        public void get_Ranges(){} // RVA: 0x7FFAC8FB3080
        public void get_Unit(){} // RVA: 0x7FFAC2F247C0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FB3140
        public void Equals(){} // RVA: 0x7FFAC8FB31A0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB33A0
        public void TryParse(){} // RVA: 0x7FFAC8FB3420
        public void ToString(){} // RVA: 0x7FFAC8FB3C00
    }

    public class RangeItemHeaderValue : Object
    {
        public System.Nullable`1<long> From; // 0x10
        public System.Nullable`1<long> To; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FB3E40
        public void get_From(){} // RVA: 0x7FFAC4422E80
        public void set_From(){} // RVA: 0x7FFAC4422E90
        public void get_To(){} // RVA: 0x7FFAC4A19630
        public void set_To(){} // RVA: 0x7FFAC8370D10
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB4020
        public void GetHashCode(){} // RVA: 0x7FFAC8FB4110
        public void ToString(){} // RVA: 0x7FFAC8FB41F0
    }

    public class RetryConditionHeaderValue : Object
    {
        public System.Nullable`1<System.DateTimeOffset> Date; // 0x10
        public System.Nullable`1<System.TimeSpan> Delta; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FB4450 | overloaded x2
        public void get_Date(){} // RVA: 0x7FFAC4AB3E90
        public void set_Date(){} // RVA: 0x7FFAC4AB3EB0
        public void get_Delta(){} // RVA: 0x7FFAC3BCF020
        public void set_Delta(){} // RVA: 0x7FFAC3BCC210
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB4530
        public void GetHashCode(){} // RVA: 0x7FFAC8FB4700
        public void TryParse(){} // RVA: 0x7FFAC8FB4870
        public void ToString(){} // RVA: 0x7FFAC8FB4C00
    }

    public class StringWithQualityHeaderValue : Object
    {
        public System.Nullable`1<double> Quality; // 0x10
        public string Value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Quality(){} // RVA: 0x7FFAC4422E80
        public void set_Quality(){} // RVA: 0x7FFAC4422E90
        public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Value(){} // RVA: 0x7FFAC2F4F0D0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB4DE0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB4F90
        public void TryParse(){} // RVA: 0x7FFAC8FB5080
        public void TryParseElement(){} // RVA: 0x7FFAC8FB5140
        public void ToString(){} // RVA: 0x7FFAC8FB56F0
    }

    public class Token : ValueType
    {
        public System.Net.Http.Headers.Token StartPosition;
        public 0x6B2A3600 EndPosition; // 0x10
        public int Kind; // 0x14
        public int <EndPosition>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FABAE0
        public void get_StartPosition(){} // RVA: 0x7FFAC44202A0
        public void set_StartPosition(){} // RVA: 0x7FFAC4420230
        public void get_EndPosition(){} // RVA: 0x7FFAC49C7500
        public void set_EndPosition(){} // RVA: 0x7FFAC49C7510
        public void get_Kind(){} // RVA: 0x7FFAC4420210
        public void op_Implicit(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC8FABB60
        public void .cctor(){} // RVA: 0x7FFAC8FABBC0
    }

    public class TransferCodingHeaderValue : Object
    {
        public string Parameters; // 0x10
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC8FB5BB0
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8FB5C70
        public void Equals(){} // RVA: 0x7FFAC8FB5CD0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB5ED0
        public void ToString(){} // RVA: 0x7FFAC8FB5F60
        public void TryParse(){} // RVA: 0x7FFAC8FB5FC0
        public void TryParseElement(){} // RVA: 0x7FFAC8FB6080
    }

    public class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void TryParse(){} // RVA: 0x7FFAC8FB6350
        public void TryParseElement(){} // RVA: 0x7FFAC8FB6410
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C5D200
    }

    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class ViaHeaderValue : Object
    {
        public string Comment; // 0x10
        public string ProtocolName; // 0x18
        public string ProtocolVersion; // 0x20
        public string ReceivedBy; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Comment(){} // RVA: 0x7FFAC2F3C380
        public void set_Comment(){} // RVA: 0x7FFAC2F22E30
        public void get_ProtocolName(){} // RVA: 0x7FFAC2F247C0
        public void set_ProtocolName(){} // RVA: 0x7FFAC2F87E80
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ProtocolVersion(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ReceivedBy(){} // RVA: 0x7FFAC2F4F130
        public void set_ReceivedBy(){} // RVA: 0x7FFAC2F22E90
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB66E0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB69F0
        public void TryParse(){} // RVA: 0x7FFAC8FB6AF0
        public void TryParseElement(){} // RVA: 0x7FFAC8FB6BB0
        public void ToString(){} // RVA: 0x7FFAC8FB7170
    }

    public class WarningHeaderValue : Object
    {
        public string Agent; // 0x10
        public int Code; // 0x18
        public System.Nullable`1<System.DateTimeOffset> Date; // 0x20
        public string Text; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Agent(){} // RVA: 0x7FFAC2F3C380
        public void set_Agent(){} // RVA: 0x7FFAC2F22E30
        public void get_Code(){} // RVA: 0x7FFAC3157800
        public void set_Code(){} // RVA: 0x7FFAC392CD10
        public void get_Date(){} // RVA: 0x7FFAC4A21280
        public void set_Date(){} // RVA: 0x7FFAC4A21240
        public void get_Text(){} // RVA: 0x7FFAC31D0140
        public void set_Text(){} // RVA: 0x7FFAC31D0C20
        public void IsCodeValid(){} // RVA: 0x7FFAC8FB72A0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC8FB72C0
        public void GetHashCode(){} // RVA: 0x7FFAC8FB7540
        public void TryParse(){} // RVA: 0x7FFAC8FB7680
        public void TryParseElement(){} // RVA: 0x7FFAC8FB7740
        public void ToString(){} // RVA: 0x7FFAC8FB7CF0
    }

}