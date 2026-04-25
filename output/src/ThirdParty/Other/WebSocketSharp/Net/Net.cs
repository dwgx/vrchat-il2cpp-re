// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase : Object
    {
        public 0x6B29EC18 Scheme; // 0x10
        public System.Collections.Specialized.NameValueCollection Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void get_Scheme(){} // RVA: 0x7FFAC9851CE0
        public void CreateNonceValue(){} // RVA: 0x7FFACC0BF590
        public void ParseParameters(){} // RVA: 0x7FFACC0BF820
        public void ToBasicString(){} // RVA: 0x7FFAC2C58E90
        public void ToDigestString(){} // RVA: 0x7FFAC2C58E90
        public void ToString(){} // RVA: 0x7FFACC0BFD20
    }

    public class AuthenticationChallenge : AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void Parse(){} // RVA: 0x7FFACC0BFDB0
        public void ToBasicString(){} // RVA: 0x7FFACC0C0070
        public void ToDigestString(){} // RVA: 0x7FFACC0C0130
    }

    public class AuthenticationResponse : AuthenticationBase
    {
        public uint NonceCount; // 0x20
        public System.Func`2<string,bool> CS$<>9__CachedAnonymousMethodDelegate1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C05C0 | overloaded x3
        public void get_NonceCount(){} // RVA: 0x7FFACC0C07A0
        public void createA1(){} // RVA: 0x7FFACC0C0860 | overloaded x2
        public void createA2(){} // RVA: 0x7FFACC0C09D0 | overloaded x2
        public void hash(){} // RVA: 0x7FFACC0C0A80
        public void initAsDigest(){} // RVA: 0x7FFACC0C0DB0
        public void CreateRequestDigest(){} // RVA: 0x7FFACC0C1250
        public void ToBasicString(){} // RVA: 0x7FFACC0C1A10
        public void ToDigestString(){} // RVA: 0x7FFACC0C1C50
        public void <initAsDigest>b__0(){} // RVA: 0x7FFACC0C21D0
    }

    public class ClientSslConfiguration : SslConfiguration
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates; // 0x28
        public string ClientCertificateSelectionCallback; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C4D60 | overloaded x2
        public void get_ClientCertificates(){} // RVA: 0x7FFAC98DDAD0
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFACC0C4970
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFACC0C4B00
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAC2F87E80
        public void get_TargetHost(){} // RVA: 0x7FFAC98DE3D0
    }

    public class Cookie : Object
    {
        public string ExactDomain; // 0x10
        public System.Uri Comment; // 0x18
        public bool CommentUri; // 0x20
        public string Discard; // 0x28
        public System.DateTime Domain; // 0x30
        public bool Expired; // 0x38
        public string Expires; // 0x40
        public string HttpOnly; // 0x48
        public string Name; // 0x50
        public int[] Path; // 0x58
        public char[] Port;
        public char[] Secure; // 0x8
        public bool Value; // 0x60
        public System.DateTime Version; // 0x68
        public string _value; // 0x70
        public int _version; // 0x78
        public bool <ExactDomain>k__BackingField; // 0x7C

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0AEB90
        public void .ctor(){} // RVA: 0x7FFACC0AF080 | overloaded x2
        public void set_ExactDomain(){} // RVA: 0x7FFAC33C9B20
        public void set_Comment(){} // RVA: 0x7FFACC0AF2C0
        public void set_CommentUri(){} // RVA: 0x7FFAC2F87E80
        public void set_Discard(){} // RVA: 0x7FFAC300F9E0
        public void get_Domain(){} // RVA: 0x7FFAC98DDAD0
        public void set_Domain(){} // RVA: 0x7FFACC0AF370
        public void get_Expired(){} // RVA: 0x7FFACC0AF4D0
        public void get_Expires(){} // RVA: 0x7FFAC98DE3D0
        public void set_Expires(){} // RVA: 0x7FFAC4A98000
        public void set_HttpOnly(){} // RVA: 0x7FFAC31D95C0
        public void get_Name(){} // RVA: 0x7FFAC991F730
        public void set_Name(){} // RVA: 0x7FFACC0AF5D0
        public void get_Path(){} // RVA: 0x7FFAC991F7A0
        public void set_Path(){} // RVA: 0x7FFACC0AF6D0
        public void set_Port(){} // RVA: 0x7FFACC0AF780
        public void set_Secure(){} // RVA: 0x7FFAC2F4A030
        public void get_Value(){} // RVA: 0x7FFAC991FB00
        public void set_Value(){} // RVA: 0x7FFACC0AFA40
        public void get_Version(){} // RVA: 0x7FFAC9A4C680
        public void set_Version(){} // RVA: 0x7FFACC0AFB80
        public void canSetName(){} // RVA: 0x7FFACC0AFC10
        public void canSetValue(){} // RVA: 0x7FFACC0AFE80
        public void hash(){} // RVA: 0x7FFACC0B0100
        public void tryCreatePorts(){} // RVA: 0x7FFACC0B0150
        public void ToRequestString(){} // RVA: 0x7FFACC0B0490
        public void Equals(){} // RVA: 0x7FFACC0B09E0
        public void GetHashCode(){} // RVA: 0x7FFACC0B0CF0
        public void ToString(){} // RVA: 0x7FFACC0B0EE0
    }

    public class CookieCollection : Object
    {
        public System.Collections.Generic.List`1<WebSocketSharp.Net.Cookie> Sorted; // 0x10
        public object Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0B0EF0
        public void get_Sorted(){} // RVA: 0x7FFACC0B0FB0
        public void get_Count(){} // RVA: 0x7FFACC0B10B0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC52088B0
        public void get_SyncRoot(){} // RVA: 0x7FFACC0B1100
        public void compareCookieWithinSorted(){} // RVA: 0x7FFACC0B11B0
        public void parseRequest(){} // RVA: 0x7FFACC0B1220
        public void parseResponse(){} // RVA: 0x7FFACC0B1CB0
        public void searchCookie(){} // RVA: 0x7FFACC0B2F00
        public void splitCookieHeaderValue(){} // RVA: 0x7FFACC0B31F0
        public void Parse(){} // RVA: 0x7FFACC0B3310
        public void SetOrRemove(){} // RVA: 0x7FFACC0B3450 | overloaded x2
        public void Add(){} // RVA: 0x7FFACC0B3780
        public void CopyTo(){} // RVA: 0x7FFACC0B3890
        public void GetEnumerator(){} // RVA: 0x7FFACC0B3B90
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8614BA0 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAC92B7EC0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92B7EC0
    }

    public class HttpHeaderInfo : Object
    {
        public string IsMultiValueInRequest; // 0x10
        public 0x6B29F1F0 IsMultiValueInResponse; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_IsMultiValueInRequest(){} // RVA: 0x7FFACC0B9FC0
        public void get_IsMultiValueInResponse(){} // RVA: 0x7FFACC0B9FD0
        public void get_IsRequest(){} // RVA: 0x7FFACC0B9FE0
        public void get_IsResponse(){} // RVA: 0x7FFACC0B9FF0
        public void get_Name(){} // RVA: 0x7FFAC5CC4750
        public void IsMultiValue(){} // RVA: 0x7FFACC0BA000
        public void IsRestricted(){} // RVA: 0x7FFACC0BA040
    }

    public class HttpUtility : Object
    {
        public char[] _hexChars;
        public object _sync; // 0x8

        // ── Methods ──
        public void getChar(){} // RVA: 0x7FFACC0B3C80
        public void getInt(){} // RVA: 0x7FFACC0B3DA0
        public void writeCharBytes(){} // RVA: 0x7FFACC0B3DD0
        public void GetEncoding(){} // RVA: 0x7FFACC0B3FB0
        public void UrlDecode(){} // RVA: 0x7FFACC0B42E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACC0B46F0
    }

    public class HttpVersion : Object
    {
        public System.Version Version10;
        public System.Version Version11; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0B9560
    }

    public class NetworkCredential : Object
    {
        public string Domain; // 0x10
        public string Password; // 0x18
        public string UserName; // 0x20

        // ── Methods ──
        public void get_Domain(){} // RVA: 0x7FFACC0BB730
        public void get_Password(){} // RVA: 0x7FFACC0BB780
        public void get_UserName(){} // RVA: 0x7FFAC91BAEE0
    }

    public class SslConfiguration : Object
    {
        public System.Net.Security.LocalCertificateSelectionCallback CertificateSelectionCallback; // 0x10
        public System.Net.Security.RemoteCertificateValidationCallback CertificateValidationCallback; // 0x18
        public bool CheckCertificateRevocation; // 0x20
        public 0x6B131280 EnabledSslProtocols; // 0x24
        public System.Net.Security.LocalCertificateSelectionCallback CS$<>9__CachedAnonymousMethodDelegate1;
        public System.Net.Security.RemoteCertificateValidationCallback CS$<>9__CachedAnonymousMethodDelegate3; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C4960
        public void get_CertificateSelectionCallback(){} // RVA: 0x7FFACC0C4970
        public void get_CertificateValidationCallback(){} // RVA: 0x7FFACC0C4B00
        public void set_CertificateValidationCallback(){} // RVA: 0x7FFAC2F87E80
        public void get_CheckCertificateRevocation(){} // RVA: 0x7FFACC0C4C90
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAC9812650
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAC41674D0
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x7FFAC67332B0
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x7FFAC4BF82C0
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public System.Collections.Generic.Dictionary`2<string,WebSocketSharp.Net.HttpHeaderInfo> AllKeys;
        public bool Count; // 0x68
        public 0x6B29F1F0 _state; // 0x6C

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0B4860
        public void .ctor(){} // RVA: 0x7FFACC0B7030 | overloaded x2
        public void get_AllKeys(){} // RVA: 0x7FFAC944F7F0
        public void get_Count(){} // RVA: 0x7FFAC83FC4F0
        public void add(){} // RVA: 0x7FFACC0B7040
        public void addWithoutCheckingName(){} // RVA: 0x7FFACC0B7140
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0x7FFACC0B7240
        public void checkColonSeparated(){} // RVA: 0x7FFACC0B72C0
        public void checkHeaderType(){} // RVA: 0x7FFACC0B7370
        public void checkName(){} // RVA: 0x7FFACC0B7400
        public void checkRestricted(){} // RVA: 0x7FFACC0B7570
        public void checkState(){} // RVA: 0x7FFACC0B7670
        public void checkValue(){} // RVA: 0x7FFACC0B7730
        public void doWithCheckingState(){} // RVA: 0x7FFACC0B7B10 | overloaded x2
        public void doWithoutCheckingName(){} // RVA: 0x7FFACC0B7C20
        public void getHeaderInfo(){} // RVA: 0x7FFACC0B7CD0
        public void isRestricted(){} // RVA: 0x7FFACC0B7FE0
        public void removeWithoutCheckingName(){} // RVA: 0x7FFACC0B8070
        public void setWithoutCheckingName(){} // RVA: 0x7FFACC0B80B0
        public void InternalSet(){} // RVA: 0x7FFACC0B83E0 | overloaded x2
        public void IsHeaderName(){} // RVA: 0x7FFACC0B8510
        public void IsHeaderValue(){} // RVA: 0x7FFACC0B8580
        public void IsMultiValue(){} // RVA: 0x7FFACC0B85D0
        public void Add(){} // RVA: 0x7FFACC0B86C0
        public void Get(){} // RVA: 0x7FFAC944F2B0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC9455750
        public void GetKey(){} // RVA: 0x7FFACC0B87B0
        public void GetValues(){} // RVA: 0x7FFACC0B8860 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFACC0B8910
        public void OnDeserialization(){} // RVA: 0x7FFAC2F21310
        public void Remove(){} // RVA: 0x7FFACC0B8BB0
        public void Set(){} // RVA: 0x7FFACC0B8C80
        public void ToString(){} // RVA: 0x7FFACC0B8D60
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92BC1E0
    }

}