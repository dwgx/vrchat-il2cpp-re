// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 34
// Methods: 328

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class AuthenticationHeaderValue : Object
    {
        public object _parameter;
        public object _scheme;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Parameter(){} // RVA: 0xB5DBF0
        public void set_Parameter(){} // RVA: 0xB44D60
        public void get_Scheme(){} // RVA: 0xB465B0
        public void set_Scheme(){} // RVA: 0xBA9BA0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x726E600
        public void GetHashCode(){} // RVA: 0x726E7A0
        public void TryParse(){} // RVA: 0x726E990
        public void TryParseElement(){} // RVA: 0x726EA50
        public void ToString(){} // RVA: 0x726EDD0
    }

    public class CacheControlHeaderValue : Object
    {
        public object extensions;
        public object no_cache_headers;
        public object private_headers;
        public object _maxAge;
        public object _maxStale;
        public object _maxStaleLimit;
        public object _minFresh;
        public object _mustRevalidate;
        public object _noCache;
        public object _noStore;
        public object _noTransform;
        public object _onlyIfCached;
        public object _private;
        public object _proxyRevalidate;
        public object _public;
        public object _sharedMaxAge;

        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x726EE30
        public void get_MaxAge(){} // RVA: 0x19F92B0
        public void set_MaxAge(){} // RVA: 0x19F35A0
        public void get_MaxStale(){} // RVA: 0xD16660
        public void set_MaxStale(){} // RVA: 0xD14C10
        public void get_MaxStaleLimit(){} // RVA: 0x16DCC90
        public void set_MaxStaleLimit(){} // RVA: 0x16DCEE0
        public void get_MinFresh(){} // RVA: 0x4CBDC80
        public void set_MinFresh(){} // RVA: 0x65B4B90
        public void get_MustRevalidate(){} // RVA: 0xB6B1A0
        public void set_MustRevalidate(){} // RVA: 0xB6B1B0
        public void get_NoCache(){} // RVA: 0x1A1E0A0
        public void set_NoCache(){} // RVA: 0x1A194B0
        public void get_NoCacheHeaders(){} // RVA: 0x726EEF0
        public void get_NoStore(){} // RVA: 0xB76DA0
        public void set_NoStore(){} // RVA: 0x1D44010
        public void get_NoTransform(){} // RVA: 0xB76D90
        public void set_NoTransform(){} // RVA: 0x1D44020
        public void get_OnlyIfCached(){} // RVA: 0x1D450E0
        public void set_OnlyIfCached(){} // RVA: 0x1D43780
        public void get_Private(){} // RVA: 0x1D3EFC0
        public void set_Private(){} // RVA: 0x726EFB0
        public void get_PrivateHeaders(){} // RVA: 0x726EFC0
        public void get_ProxyRevalidate(){} // RVA: 0x7171AF0
        public void set_ProxyRevalidate(){} // RVA: 0x726F080
        public void get_Public(){} // RVA: 0x7171AE0
        public void set_Public(){} // RVA: 0x726F090
        public void get_SharedMaxAge(){} // RVA: 0x4127AD0
        public void set_SharedMaxAge(){} // RVA: 0x4127F60
        public void System.ICloneable.Clone(){} // RVA: 0x726F0A0
        public void Equals(){} // RVA: 0x726F820
        public void GetHashCode(){} // RVA: 0x726FBD0
        public void TryParse(){} // RVA: 0x726FFA0
        public void ToString(){} // RVA: 0x7270F30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void SequenceEqual(){} // RVA: 0x87D880
        public void SetValue(){} // RVA: 0x7271970
        public void ToString(){} // RVA: 0x87C5C0
        public void ToStringBuilder(){} // RVA: 0x8945C0
    }

    public class CollectionParser : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7271BF0
        public void TryParseStringElement(){} // RVA: 0x7271CB0
    }

    public class ContentDispositionHeaderValue : Object
    {
        public object dispositionType;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7271F00
        public void get_Parameters(){} // RVA: 0x72722B0
        public void System.ICloneable.Clone(){} // RVA: 0x7272370
        public void Equals(){} // RVA: 0x72723D0
        public void GetHashCode(){} // RVA: 0x72725B0
        public void ToString(){} // RVA: 0x7272630
        public void TryParse(){} // RVA: 0x7272690
    }

    public class ContentRangeHeaderValue : Object
    {
        public object unit;
        public object _from;
        public object _length;
        public object _to;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7272A00
        public void get_From(){} // RVA: 0x125EE60
        public void set_From(){} // RVA: 0x125D9D0
        public void get_Length(){} // RVA: 0x19F92B0
        public void set_Length(){} // RVA: 0x19F35A0
        public void get_To(){} // RVA: 0x2237C00
        public void set_To(){} // RVA: 0x27FA8A0
        public void get_Unit(){} // RVA: 0xB5DBF0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7272A90
        public void GetHashCode(){} // RVA: 0x7272C60
        public void TryParse(){} // RVA: 0x7272DF0
        public void ToString(){} // RVA: 0x7273480
    }

    public class ElementTryParser`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x87D710
    }

    public class EntityTagHeaderValue : Object
    {
        public object any;
        public object _isWeak;
        public object _tag;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_IsWeak(){} // RVA: 0xC120A0
        public void set_IsWeak(){} // RVA: 0xC120B0
        public void get_Tag(){} // RVA: 0xB465B0
        public void set_Tag(){} // RVA: 0xBA9BA0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x72736F0
        public void GetHashCode(){} // RVA: 0x7273830
        public void TryParse(){} // RVA: 0x7273E40
        public void TryParseElement(){} // RVA: 0x7273A10
        public void ToString(){} // RVA: 0x7273F00
        public void .cctor(){} // RVA: 0x7273F60
    }

    public class HashCodeCalculator : Object
    {
        // ── Methods ──
        public void Calculate(){} // RVA: 0x87D090
    }

    public class HeaderInfo : Object
    {
        public object AllowsMany;
        public object HeaderKind;
        public object Name;
        public object _customToString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7274080
        public void CreateSingle(){} // RVA: 0x88E410
        public void CreateMulti(){} // RVA: 0xA94080
        public void CreateCollection(){} // RVA: 0x87C5F0
        public void get_CustomToString(){} // RVA: 0xB700F0
        public void set_CustomToString(){} // RVA: 0xB70100
        public void get_Separator(){} // RVA: 0x7274100
        public void AddToCollection(){} // RVA: 0x8943B0
        public void ToStringCollection(){} // RVA: 0x87C540
        public void TryParse(){} // RVA: 0x87D3C0
    }

    public class HttpContentHeaders : HttpHeaders
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7274140
        public void get_ContentEncoding(){} // RVA: 0x72741F0
        public void get_ContentLength(){} // RVA: 0x7274250
        public void get_ContentType(){} // RVA: 0x7274570
        public void set_ContentType(){} // RVA: 0x72745D0
    }

    public class HttpHeaderValueCollection`1 : Object
    {
        public object list;
        public object headers;
        public object headerInfo;
        public object invalidValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void get_Count(){} // RVA: 0x87C130
        public void get_InvalidValues(){} // RVA: 0x87C0A0
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x894320
        public void AddInvalidValue(){} // RVA: 0x894320
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void Remove(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void Find(){} // RVA: 0xA94080
    }

    public class HttpHeaders : Object
    {
        public object known_headers;
        public object headers;
        public object HeaderKind;
        public object connectionclose;
        public object transferEncodingChunked;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7274710
        public void .ctor(){} // RVA: 0x72773B0
        public void Add(){} // RVA: 0x72775A0
        public void AddInternal(){} // RVA: 0x7277640
        public void TryAddWithoutValidation(){} // RVA: 0x7277AE0
        public void CheckName(){} // RVA: 0x7277BB0
        public void TryCheckName(){} // RVA: 0x7277D30
        public void Contains(){} // RVA: 0x7277EB0
        public void GetEnumerator(){} // RVA: 0x7277F30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7277FD0
        public void Remove(){} // RVA: 0x7277FE0
        public void TryGetValues(){} // RVA: 0x7278050
        public void GetSingleHeaderString(){} // RVA: 0x7278210
        public void ToString(){} // RVA: 0x72785C0
        public void AddOrRemove(){} // RVA: 0xA94080
        public void GetAllHeaderValues(){} // RVA: 0x72788C0
        public void GetKnownHeaderKind(){} // RVA: 0x7278AA0
        public void GetValue(){} // RVA: 0xA94080
        public void GetValues(){} // RVA: 0x87C540
        public void SetValue(){} // RVA: 0xA94080
    }

    public class HttpRequestHeaders : HttpHeaders
    {
        public object expectContinue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72792A0
        public void get_Connection(){} // RVA: 0x7279300
        public void get_ConnectionClose(){} // RVA: 0x7279360
        public void get_ExpectContinue(){} // RVA: 0x72795B0
        public void get_Host(){} // RVA: 0x72797F0
        public void get_TransferEncoding(){} // RVA: 0x7279850
        public void get_TransferEncodingChunked(){} // RVA: 0x72798B0
        public void AddHeaders(){} // RVA: 0x7279AF0
    }

    public class HttpResponseHeaders : HttpHeaders
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x727A140
        public void get_RetryAfter(){} // RVA: 0x727A1A0
    }

    public class Lexer : Object
    {
        public object token_chars;
        public object last_token_char;
        public object dt_formats;
        public object s;
        public object pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Position(){} // RVA: 0xE62D00
        public void set_Position(){} // RVA: 0x1033F40
        public void GetStringValue(){} // RVA: 0x727A3F0
        public void GetQuotedStringValue(){} // RVA: 0x727A480
        public void GetRemainingStringValue(){} // RVA: 0x727A500
        public void IsStarStringValue(){} // RVA: 0x727A540
        public void TryGetNumericValue(){} // RVA: 0x727A730
        public void TryGetTimeSpanValue(){} // RVA: 0x727A870
        public void TryGetDateValue(){} // RVA: 0x727AAF0
        public void TryGetDoubleValue(){} // RVA: 0x727ABF0
        public void IsValidToken(){} // RVA: 0x727AD30
        public void IsValidCharacter(){} // RVA: 0x727AE80
        public void EatChar(){} // RVA: 0x26666F0
        public void PeekChar(){} // RVA: 0x727AF30
        public void ScanCommentOptional(){} // RVA: 0x727AF80
        public void Scan(){} // RVA: 0x727B1B0
        public void .cctor(){} // RVA: 0x727B550
    }

    public class MediaTypeHeaderValue : Object
    {
        public object parameters;
        public object media_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_CharSet(){} // RVA: 0x727BD40
        public void set_CharSet(){} // RVA: 0x727BED0
        public void get_MediaType(){} // RVA: 0xB465B0
        public void set_MediaType(){} // RVA: 0x727B7C0
        public void get_Parameters(){} // RVA: 0x727BFD0
        public void System.ICloneable.Clone(){} // RVA: 0x727C090
        public void Equals(){} // RVA: 0x727C0F0
        public void GetHashCode(){} // RVA: 0x727C2D0
        public void Parse(){} // RVA: 0x727C350
        public void ToString(){} // RVA: 0x727C3D0
        public void TryParse(){} // RVA: 0x727C440
        public void TryParseMediaType(){} // RVA: 0x727C760
    }

    public class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void TryParseElement(){} // RVA: 0x727CBE0
        public void TryParse(){} // RVA: 0x727CEF0
    }

    public class NameValueHeaderValue : Object
    {
        public object value;
        public object _name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x727D120
        public void Create(){} // RVA: 0x727D3A0
        public void System.ICloneable.Clone(){} // RVA: 0x727D4B0
        public void GetHashCode(){} // RVA: 0x726E7A0
        public void Equals(){} // RVA: 0x727D510
        public void TryParsePragma(){} // RVA: 0x727D720
        public void TryParseParameters(){} // RVA: 0x727D7E0
        public void ToString(){} // RVA: 0x727DCF0
        public void TryParseElement(){} // RVA: 0x727DD50
    }

    public class NameValueWithParametersHeaderValue : NameValueHeaderValue
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Parameters(){} // RVA: 0x727E440
        public void System.ICloneable.Clone(){} // RVA: 0x727E500
        public void Equals(){} // RVA: 0x727E560
        public void GetHashCode(){} // RVA: 0x727E6A0
        public void ToString(){} // RVA: 0x727E760
        public void TryParse(){} // RVA: 0x727E880
        public void TryParseElement(){} // RVA: 0x727E940
    }

    public class ProductHeaderValue : Object
    {
        public object _name;
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xB465B0
        public void set_Version(){} // RVA: 0xBA9BA0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x727FC20
        public void GetHashCode(){} // RVA: 0x727FE10
        public void TryParse(){} // RVA: 0x727FE90
        public void TryParseElement(){} // RVA: 0x727FF50
        public void ToString(){} // RVA: 0x72802D0
    }

    public class ProductInfoHeaderValue : Object
    {
        public object _comment;
        public object _product;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Comment(){} // RVA: 0xB5DBF0
        public void set_Comment(){} // RVA: 0xB44D60
        public void get_Product(){} // RVA: 0xB465B0
        public void set_Product(){} // RVA: 0xBA9BA0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x72803D0
        public void GetHashCode(){} // RVA: 0x72804C0
        public void TryParse(){} // RVA: 0x7280500
        public void TryParseElement(){} // RVA: 0x7280770
        public void ToString(){} // RVA: 0x7280B70
    }

    public class RangeConditionHeaderValue : Object
    {
        public object _date;
        public object _entityTag;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7280C10
        public void get_Date(){} // RVA: 0x2817240
        public void set_Date(){} // RVA: 0x2817210
        public void get_EntityTag(){} // RVA: 0xB70160
        public void set_EntityTag(){} // RVA: 0xB44DC0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7280CC0
        public void GetHashCode(){} // RVA: 0x7280E40
        public void TryParse(){} // RVA: 0x7280F30
        public void ToString(){} // RVA: 0x72813C0
    }

    public class RangeHeaderValue : Object
    {
        public object ranges;
        public object unit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7281560
        public void get_Ranges(){} // RVA: 0x72817A0
        public void get_Unit(){} // RVA: 0xB465B0
        public void System.ICloneable.Clone(){} // RVA: 0x7281860
        public void Equals(){} // RVA: 0x72818C0
        public void GetHashCode(){} // RVA: 0x7281AA0
        public void TryParse(){} // RVA: 0x7281B20
        public void ToString(){} // RVA: 0x72822F0
    }

    public class RangeItemHeaderValue : Object
    {
        public object _from;
        public object _to;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7282530
        public void get_From(){} // RVA: 0x22343B0
        public void set_From(){} // RVA: 0x22343C0
        public void get_To(){} // RVA: 0x16CD810
        public void set_To(){} // RVA: 0x16DCCA0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7282710
        public void GetHashCode(){} // RVA: 0x72827F0
        public void ToString(){} // RVA: 0x72828D0
    }

    public class RetryConditionHeaderValue : Object
    {
        public object _date;
        public object _delta;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7282B30
        public void get_Date(){} // RVA: 0x2817240
        public void set_Date(){} // RVA: 0x2817210
        public void get_Delta(){} // RVA: 0x19F92B0
        public void set_Delta(){} // RVA: 0x19F35A0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7282C10
        public void GetHashCode(){} // RVA: 0x7282DD0
        public void TryParse(){} // RVA: 0x7282F40
        public void ToString(){} // RVA: 0x72832D0
    }

    public class StringWithQualityHeaderValue : Object
    {
        public object _quality;
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Quality(){} // RVA: 0x22343B0
        public void set_Quality(){} // RVA: 0x22343C0
        public void get_Value(){} // RVA: 0xB700F0
        public void set_Value(){} // RVA: 0xB70100
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x72834B0
        public void GetHashCode(){} // RVA: 0x7283660
        public void TryParse(){} // RVA: 0x7283750
        public void TryParseElement(){} // RVA: 0x7283810
        public void ToString(){} // RVA: 0x7283DC0
    }

    public class Token : ValueType
    {
        public object Empty;
        public object type;
        public object _startPosition;
        public object _endPosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x90B160
        public void get_StartPosition(){} // RVA: 0x77E50
        public void set_StartPosition(){} // RVA: 0x77EE0
        public void get_EndPosition(){} // RVA: 0x14790
        public void set_EndPosition(){} // RVA: 0x92DD0
        public void get_Kind(){} // RVA: 0x77E60
        public void op_Implicit(){} // RVA: 0x2231FC0
        public void ToString(){} // RVA: 0x90B170
        public void .cctor(){} // RVA: 0x727A2E0
    }

    public class TransferCodingHeaderValue : Object
    {
        public object value;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Parameters(){} // RVA: 0x7284290
        public void get_Value(){} // RVA: 0xB5DBF0
        public void System.ICloneable.Clone(){} // RVA: 0x7284350
        public void Equals(){} // RVA: 0x72843B0
        public void GetHashCode(){} // RVA: 0x7284590
        public void ToString(){} // RVA: 0x7284620
        public void TryParse(){} // RVA: 0x7284680
        public void TryParseElement(){} // RVA: 0x7284740
    }

    public class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void TryParse(){} // RVA: 0x7284A20
        public void TryParseElement(){} // RVA: 0x7284AE0
    }

    public class TryParseDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x87D3C0
    }

    public class TryParseListDelegate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x880270
    }

    public class ViaHeaderValue : Object
    {
        public object _comment;
        public object _protocolName;
        public object _protocolVersion;
        public object _receivedBy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Comment(){} // RVA: 0xB5DBF0
        public void set_Comment(){} // RVA: 0xB44D60
        public void get_ProtocolName(){} // RVA: 0xB465B0
        public void set_ProtocolName(){} // RVA: 0xBA9BA0
        public void get_ProtocolVersion(){} // RVA: 0xB700F0
        public void set_ProtocolVersion(){} // RVA: 0xB70100
        public void get_ReceivedBy(){} // RVA: 0xB70160
        public void set_ReceivedBy(){} // RVA: 0xB44DC0
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7284DC0
        public void GetHashCode(){} // RVA: 0x72850C0
        public void TryParse(){} // RVA: 0x72851C0
        public void TryParseElement(){} // RVA: 0x7285280
        public void ToString(){} // RVA: 0x7285840
    }

    public class WarningHeaderValue : Object
    {
        public object _agent;
        public object _code;
        public object _date;
        public object _text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Agent(){} // RVA: 0xB5DBF0
        public void set_Agent(){} // RVA: 0xB44D60
        public void get_Code(){} // RVA: 0xE62D00
        public void set_Code(){} // RVA: 0x1033F40
        public void get_Date(){} // RVA: 0x2418230
        public void set_Date(){} // RVA: 0x24184F0
        public void get_Text(){} // RVA: 0xD05CA0
        public void set_Text(){} // RVA: 0xD09D70
        public void IsCodeValid(){} // RVA: 0x7285970
        public void System.ICloneable.Clone(){} // RVA: 0x67F43E0
        public void Equals(){} // RVA: 0x7285990
        public void GetHashCode(){} // RVA: 0x7285BF0
        public void TryParse(){} // RVA: 0x7285D30
        public void TryParseElement(){} // RVA: 0x7285DF0
        public void ToString(){} // RVA: 0x72863A0
    }

}