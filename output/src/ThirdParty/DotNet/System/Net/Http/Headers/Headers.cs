// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Http.Headers
// Classes: 36
// Methods: 348

namespace ThirdParty.DotNet.System.Net.Http.Headers
{
    public class AuthenticationHeaderValue
    {
        public string <Parameter>k__BackingField; // 0x10
        public string <Scheme>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Parameter(){} // RVA: 0x2F8380
        public void set_Parameter(){} // RVA: 0x2DEE30
        public void get_Scheme(){} // RVA: 0x2E07C0
        public void set_Scheme(){} // RVA: 0x343E80
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x6808F50
        public void GetHashCode(){} // RVA: 0x6809100
        public void TryParse(){} // RVA: 0x68092F0 | overloaded x2
        public void TryParseElement(){} // RVA: 0x68093B0
        public void ToString(){} // RVA: 0x6809730
    }

    public class CacheControlHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> extensions; // 0x10
        public System.Collections.Generic.List`1<string> no_cache_headers; // 0x18
        public System.Collections.Generic.List`1<string> private_headers; // 0x20
        public System.Nullable`1<System.TimeSpan> <MaxAge>k__BackingField; // 0x28
        public bool <MaxStale>k__BackingField; // 0x38
        public System.Nullable`1<System.TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
        public System.Nullable`1<System.TimeSpan> <MinFresh>k__BackingField; // 0x50
        public bool <MustRevalidate>k__BackingField; // 0x60
        public bool <NoCache>k__BackingField; // 0x61
        public bool <NoStore>k__BackingField; // 0x62
        public bool <NoTransform>k__BackingField; // 0x63
        public bool <OnlyIfCached>k__BackingField; // 0x64
        public bool <Private>k__BackingField; // 0x65
        public bool <ProxyRevalidate>k__BackingField; // 0x66
        public bool <Public>k__BackingField; // 0x67
        public System.Nullable`1<System.TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x6809790
        public void get_MaxAge(){} // RVA: 0x111F520
        public void set_MaxAge(){} // RVA: 0x111C380
        public void get_MaxStale(){} // RVA: 0x4A6500
        public void set_MaxStale(){} // RVA: 0x4A78C0
        public void get_MaxStaleLimit(){} // RVA: 0x1FA6340
        public void set_MaxStaleLimit(){} // RVA: 0x4469B20
        public void get_MinFresh(){} // RVA: 0x41E0130
        public void set_MinFresh(){} // RVA: 0x5B3A8D0
        public void get_MustRevalidate(){} // RVA: 0x306020
        public void set_MustRevalidate(){} // RVA: 0x306030
        public void get_NoCache(){} // RVA: 0x115A230
        public void set_NoCache(){} // RVA: 0x114F200
        public void get_NoCacheHeaders(){} // RVA: 0x6809850
        public void get_NoStore(){} // RVA: 0x311E50
        public void set_NoStore(){} // RVA: 0x1470E80
        public void get_NoTransform(){} // RVA: 0x311E40
        public void set_NoTransform(){} // RVA: 0x6809910
        public void get_OnlyIfCached(){} // RVA: 0x1498640
        public void set_OnlyIfCached(){} // RVA: 0x1C91430
        public void get_Private(){} // RVA: 0x67098B0
        public void set_Private(){} // RVA: 0x6809920
        public void get_PrivateHeaders(){} // RVA: 0x6809930
        public void get_ProxyRevalidate(){} // RVA: 0x6709810
        public void set_ProxyRevalidate(){} // RVA: 0x68099F0
        public void get_Public(){} // RVA: 0x6709800
        public void set_Public(){} // RVA: 0x6809A00
        public void get_SharedMaxAge(){} // RVA: 0x36ABC50
        public void set_SharedMaxAge(){} // RVA: 0x36AC0C0
        public void System.ICloneable.Clone(){} // RVA: 0x6809A10
        public void Equals(){} // RVA: 0x680A190
        public void GetHashCode(){} // RVA: 0x680A550
        public void TryParse(){} // RVA: 0x680A930
        public void ToString(){} // RVA: 0x680B910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CollectionExtensions
    {
        // ── Methods ──
        public void SequenceEqual(){} // RVA: 0xE230
        public void SetValue(){} // RVA: 0x680C350
        public void ToString(){} // RVA: 0xCE50
        public void ToStringBuilder(){} // RVA: 0x24D50
    }

    public class CollectionParser
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x680C5D0 | overloaded x2
        public void TryParseStringElement(){} // RVA: 0x680C690
    }

    public class ContentDispositionHeaderValue
    {
        public string dispositionType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x680C8D0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x680CC70
        public void System.ICloneable.Clone(){} // RVA: 0x680CD30
        public void Equals(){} // RVA: 0x680CD90
        public void GetHashCode(){} // RVA: 0x680CF90
        public void ToString(){} // RVA: 0x680D010
        public void TryParse(){} // RVA: 0x680D070
    }

    public class ContentRangeHeaderValue
    {
        public string unit; // 0x10
        public System.Nullable`1<long> <From>k__BackingField; // 0x18
        public System.Nullable`1<long> <Length>k__BackingField; // 0x28
        public System.Nullable`1<long> <To>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x680D3E0
        public void get_From(){} // RVA: 0x994EE0
        public void set_From(){} // RVA: 0x9949A0
        public void get_Length(){} // RVA: 0x111F520
        public void set_Length(){} // RVA: 0x111C380
        public void get_To(){} // RVA: 0x196F080
        public void set_To(){} // RVA: 0x1F74CD0
        public void get_Unit(){} // RVA: 0x2F8380
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x680D470
        public void GetHashCode(){} // RVA: 0x680D660
        public void TryParse(){} // RVA: 0x680D7F0
        public void ToString(){} // RVA: 0x680DE80
    }

    public class ElementTryParser`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class EntityTagHeaderValue
    {
        public System.Net.Http.Headers.EntityTagHeaderValue any;
        public bool <IsWeak>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_IsWeak(){} // RVA: 0x3A75E0
        public void set_IsWeak(){} // RVA: 0x3A75F0
        public void get_Tag(){} // RVA: 0x2E07C0
        public void set_Tag(){} // RVA: 0x343E80
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x680E0F0
        public void GetHashCode(){} // RVA: 0x680E260
        public void TryParse(){} // RVA: 0x680E890 | overloaded x2
        public void TryParseElement(){} // RVA: 0x680E460
        public void ToString(){} // RVA: 0x680E950
        public void .cctor(){} // RVA: 0x680E9B0
    }

    public class HashCodeCalculator
    {
        // ── Methods ──
        public void Calculate(){} // RVA: 0xD920
    }

    public class HeaderInfo
    {
        public bool AllowsMany; // 0x10
        public 0x659C7320 HeaderKind; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x680EAD0
        public void CreateSingle(){} // RVA: 0x1EC30
        public void CreateMulti(){} // RVA: 0x283FA0
        public void CreateCollection(){} // RVA: 0x1E6A0 | overloaded x2
        public void get_CustomToString(){} // RVA: 0x30B0C0
        public void set_CustomToString(){} // RVA: 0x30B0D0
        public void get_Separator(){} // RVA: 0x680EB50
        public void AddToCollection(){} // RVA: 0x2DC60
        public void ToStringCollection(){} // RVA: 0xCE10
        public void TryParse(){} // RVA: 0x11120
    }

    public class HttpContentHeaders
    {
        public System.Net.Http.HttpContent content; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x680EB90
        public void get_ContentEncoding(){} // RVA: 0x680EC40
        public void get_ContentLength(){} // RVA: 0x680ECA0
        public void get_ContentType(){} // RVA: 0x680EFC0
        public void set_ContentType(){} // RVA: 0x680F020
    }

    public class HttpHeaderValueCollection`1
    {
        public System.Collections.Generic.List`1<T> list;
        public System.Net.Http.Headers.HttpHeaders headers;
        public System.Net.Http.Headers.HeaderInfo headerInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void get_Count(){} // RVA: 0xD840
        public void get_InvalidValues(){} // RVA: 0xCD60
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0x283FA0
        public void AddRange(){} // RVA: 0x24B10
        public void AddInvalidValue(){} // RVA: 0x24B10
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Find(){} // RVA: 0x283FA0
    }

    public class HttpHeaders
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x680F160
        public void .ctor(){} // RVA: 0x6811E00 | overloaded x2
        public void Add(){} // RVA: 0x6811FF0 | overloaded x2
        public void AddInternal(){} // RVA: 0x6812090
        public void TryAddWithoutValidation(){} // RVA: 0x6812540
        public void CheckName(){} // RVA: 0x6812610
        public void TryCheckName(){} // RVA: 0x6812790
        public void Contains(){} // RVA: 0x6812910
        public void GetEnumerator(){} // RVA: 0x6812990
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6812A30
        public void Remove(){} // RVA: 0x6812A40
        public void TryGetValues(){} // RVA: 0x6812AB0
        public void GetSingleHeaderString(){} // RVA: 0x6812C70
        public void ToString(){} // RVA: 0x6813010
        public void AddOrRemove(){} // RVA: 0x283FA0
        public void GetAllHeaderValues(){} // RVA: 0x68132F0
        public void GetKnownHeaderKind(){} // RVA: 0x68134D0
        public void GetValue(){} // RVA: 0x283FA0
        public void GetValues(){} // RVA: 0xCE10
        public void SetValue(){} // RVA: 0x283FA0
    }

    public class HttpRequestHeaders
    {
        public System.Nullable`1<bool> expectContinue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6813CD0
        public void get_Connection(){} // RVA: 0x6813D30
        public void get_ConnectionClose(){} // RVA: 0x6813D90
        public void get_ExpectContinue(){} // RVA: 0x6813FE0
        public void get_Host(){} // RVA: 0x6814220
        public void get_TransferEncoding(){} // RVA: 0x6814280
        public void get_TransferEncodingChunked(){} // RVA: 0x68142E0
        public void AddHeaders(){} // RVA: 0x6814520
    }

    public class HttpResponseHeaders
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6814B60
        public void get_RetryAfter(){} // RVA: 0x6814BC0
    }

    public class Lexer
    {
        public bool[] token_chars;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Position(){} // RVA: 0x5BED50
        public void set_Position(){} // RVA: 0x6374E0
        public void GetStringValue(){} // RVA: 0x6814E10 | overloaded x2
        public void GetQuotedStringValue(){} // RVA: 0x6814EA0
        public void GetRemainingStringValue(){} // RVA: 0x6814F20
        public void IsStarStringValue(){} // RVA: 0x6814F60
        public void TryGetNumericValue(){} // RVA: 0x6815150 | overloaded x2
        public void TryGetTimeSpanValue(){} // RVA: 0x6815290
        public void TryGetDateValue(){} // RVA: 0x6815510 | overloaded x2
        public void TryGetDoubleValue(){} // RVA: 0x6815610
        public void IsValidToken(){} // RVA: 0x6815750
        public void IsValidCharacter(){} // RVA: 0x68158A0
        public void EatChar(){} // RVA: 0x6815950
        public void PeekChar(){} // RVA: 0x6815960
        public void ScanCommentOptional(){} // RVA: 0x68159B0
        public void Scan(){} // RVA: 0x6815BE0
        public void .cctor(){} // RVA: 0x6815F80
    }

    public class MediaTypeHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x10
        public string media_type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x3
        public void get_CharSet(){} // RVA: 0x6816760
        public void set_CharSet(){} // RVA: 0x68168F0
        public void get_MediaType(){} // RVA: 0x2E07C0
        public void set_MediaType(){} // RVA: 0x68161F0
        public void get_Parameters(){} // RVA: 0x68169F0
        public void System.ICloneable.Clone(){} // RVA: 0x6816AB0
        public void Equals(){} // RVA: 0x6816B10
        public void GetHashCode(){} // RVA: 0x6816D10
        public void Parse(){} // RVA: 0x6816D90
        public void ToString(){} // RVA: 0x6816E10
        public void TryParse(){} // RVA: 0x6816E80
        public void TryParseMediaType(){} // RVA: 0x6817190
    }

    public class MediaTypeWithQualityHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void TryParseElement(){} // RVA: 0x6817610
        public void TryParse(){} // RVA: 0x6817910
    }

    public class NameValueHeaderValue
    {
        public string value; // 0x10
        public string <Name>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x3
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x6817B40
        public void Create(){} // RVA: 0x6817DB0
        public void System.ICloneable.Clone(){} // RVA: 0x6817EC0
        public void GetHashCode(){} // RVA: 0x6809100
        public void Equals(){} // RVA: 0x6817F20
        public void TryParsePragma(){} // RVA: 0x6818140
        public void TryParseParameters(){} // RVA: 0x6818200
        public void ToString(){} // RVA: 0x6818710
        public void TryParseElement(){} // RVA: 0x6818770
    }

    public class NameValueWithParametersHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x6818E40
        public void System.ICloneable.Clone(){} // RVA: 0x6818F00
        public void Equals(){} // RVA: 0x6818F60
        public void GetHashCode(){} // RVA: 0x68190B0
        public void ToString(){} // RVA: 0x6819170
        public void TryParse(){} // RVA: 0x6819290
        public void TryParseElement(){} // RVA: 0x6819350
    }

    public class Parser
    {
    }

    public class ProductHeaderValue
    {
        public string <Name>k__BackingField; // 0x10
        public string <Version>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x2E07C0
        public void set_Version(){} // RVA: 0x343E80
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681A630
        public void GetHashCode(){} // RVA: 0x681A840
        public void TryParse(){} // RVA: 0x681A8C0
        public void TryParseElement(){} // RVA: 0x681A980
        public void ToString(){} // RVA: 0x681ACF0
    }

    public class ProductInfoHeaderValue
    {
        public string <Comment>k__BackingField; // 0x10
        public System.Net.Http.Headers.ProductHeaderValue <Product>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void get_Comment(){} // RVA: 0x2F8380
        public void set_Comment(){} // RVA: 0x2DEE30
        public void get_Product(){} // RVA: 0x2E07C0
        public void set_Product(){} // RVA: 0x343E80
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681ADF0
        public void GetHashCode(){} // RVA: 0x681AEF0
        public void TryParse(){} // RVA: 0x681AF30
        public void TryParseElement(){} // RVA: 0x681B190
        public void ToString(){} // RVA: 0x681B590
    }

    public class RangeConditionHeaderValue
    {
        public System.Nullable`1<System.DateTimeOffset> <Date>k__BackingField; // 0x10
        public System.Net.Http.Headers.EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681B630 | overloaded x2
        public void get_Date(){} // RVA: 0x1F90220
        public void set_Date(){} // RVA: 0x1F90200
        public void get_EntityTag(){} // RVA: 0x30B130
        public void set_EntityTag(){} // RVA: 0x2DEE90
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681B6E0
        public void GetHashCode(){} // RVA: 0x681B860
        public void TryParse(){} // RVA: 0x681B950
        public void ToString(){} // RVA: 0x681BDE0
    }

    public class RangeHeaderValue
    {
        public System.Collections.Generic.List`1<System.Net.Http.Headers.RangeItemHeaderValue> ranges; // 0x10
        public string unit; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681BF80 | overloaded x2
        public void get_Ranges(){} // RVA: 0x681C1C0
        public void get_Unit(){} // RVA: 0x2E07C0
        public void System.ICloneable.Clone(){} // RVA: 0x681C280
        public void Equals(){} // RVA: 0x681C2E0
        public void GetHashCode(){} // RVA: 0x681C4E0
        public void TryParse(){} // RVA: 0x681C560
        public void ToString(){} // RVA: 0x681CD40
    }

    public class RangeItemHeaderValue
    {
        public System.Nullable`1<long> <From>k__BackingField; // 0x10
        public System.Nullable`1<long> <To>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681CF80
        public void get_From(){} // RVA: 0x196ABE0
        public void set_From(){} // RVA: 0x196ABF0
        public void get_To(){} // RVA: 0x1EFB630
        public void set_To(){} // RVA: 0x5BD97C0
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681D160
        public void GetHashCode(){} // RVA: 0x681D250
        public void ToString(){} // RVA: 0x681D330
    }

    public class RetryConditionHeaderValue
    {
        public System.Nullable`1<System.DateTimeOffset> <Date>k__BackingField; // 0x10
        public System.Nullable`1<System.TimeSpan> <Delta>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681D590 | overloaded x2
        public void get_Date(){} // RVA: 0x1F90220
        public void set_Date(){} // RVA: 0x1F90200
        public void get_Delta(){} // RVA: 0x111F520
        public void set_Delta(){} // RVA: 0x111C380
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681D670
        public void GetHashCode(){} // RVA: 0x681D840
        public void TryParse(){} // RVA: 0x681D9B0
        public void ToString(){} // RVA: 0x681DD40
    }

    public class StringWithQualityHeaderValue
    {
        public System.Nullable`1<double> <Quality>k__BackingField; // 0x10
        public string <Value>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Quality(){} // RVA: 0x196ABE0
        public void set_Quality(){} // RVA: 0x196ABF0
        public void get_Value(){} // RVA: 0x30B0C0
        public void set_Value(){} // RVA: 0x30B0D0
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681DF20
        public void GetHashCode(){} // RVA: 0x681E0D0
        public void TryParse(){} // RVA: 0x681E1C0
        public void TryParseElement(){} // RVA: 0x681E280
        public void ToString(){} // RVA: 0x681E830
    }

    public class Token
    {
        public System.Net.Http.Headers.Token Position;
        public 0x659C75E0 type; // 0x10
        public int <StartPosition>k__BackingField; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6814C20
        public void get_StartPosition(){} // RVA: 0x19689E0
        public void set_StartPosition(){} // RVA: 0x19689D0
        public void get_EndPosition(){} // RVA: 0x1EA9890
        public void set_EndPosition(){} // RVA: 0x1EA98A0
        public void get_Kind(){} // RVA: 0x19689B0
        public void op_Implicit(){} // RVA: 0x19689B0
        public void ToString(){} // RVA: 0x6814CA0
        public void .cctor(){} // RVA: 0x6814D00
    }

    public class TransferCodingHeaderValue
    {
        public string value; // 0x10
        public System.Collections.Generic.List`1<System.Net.Http.Headers.NameValueHeaderValue> parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void get_Parameters(){} // RVA: 0x681ECF0
        public void get_Value(){} // RVA: 0x2F8380
        public void System.ICloneable.Clone(){} // RVA: 0x681EDB0
        public void Equals(){} // RVA: 0x681EE10
        public void GetHashCode(){} // RVA: 0x681F010
        public void ToString(){} // RVA: 0x681F0A0
        public void TryParse(){} // RVA: 0x681F100
        public void TryParseElement(){} // RVA: 0x681F1C0
    }

    public class TransferCodingWithQualityHeaderValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void TryParse(){} // RVA: 0x681F490
        public void TryParseElement(){} // RVA: 0x681F550
    }

    public class TryParseDelegate`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x11120
    }

    public class TryParseDelegate`1
    {
    }

    public class TryParseListDelegate`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){}
    }

    public class ViaHeaderValue
    {
        public string <Comment>k__BackingField; // 0x10
        public string <ProtocolName>k__BackingField; // 0x18
        public string <ProtocolVersion>k__BackingField; // 0x20
        public string <ReceivedBy>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Comment(){} // RVA: 0x2F8380
        public void set_Comment(){} // RVA: 0x2DEE30
        public void get_ProtocolName(){} // RVA: 0x2E07C0
        public void set_ProtocolName(){} // RVA: 0x343E80
        public void get_ProtocolVersion(){} // RVA: 0x30B0C0
        public void set_ProtocolVersion(){} // RVA: 0x30B0D0
        public void get_ReceivedBy(){} // RVA: 0x30B130
        public void set_ReceivedBy(){} // RVA: 0x2DEE90
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x681F820
        public void GetHashCode(){} // RVA: 0x681FB30
        public void TryParse(){} // RVA: 0x681FC30
        public void TryParseElement(){} // RVA: 0x681FCF0
        public void ToString(){} // RVA: 0x68202B0
    }

    public class WarningHeaderValue
    {
        public string <Agent>k__BackingField; // 0x10
        public int <Code>k__BackingField; // 0x18
        public System.Nullable`1<System.DateTimeOffset> <Date>k__BackingField; // 0x20
        public string <Text>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Agent(){} // RVA: 0x2F8380
        public void set_Agent(){} // RVA: 0x2DEE30
        public void get_Code(){} // RVA: 0x5BED50
        public void set_Code(){} // RVA: 0x6374E0
        public void get_Date(){} // RVA: 0x1B501E0
        public void set_Date(){} // RVA: 0x1B50090
        public void get_Text(){} // RVA: 0x4976A0
        public void set_Text(){} // RVA: 0x49B830
        public void IsCodeValid(){} // RVA: 0x68203E0
        public void System.ICloneable.Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x6820400
        public void GetHashCode(){} // RVA: 0x6820680
        public void TryParse(){} // RVA: 0x68207C0
        public void TryParseElement(){} // RVA: 0x6820880
        public void ToString(){} // RVA: 0x6820E30
    }

}