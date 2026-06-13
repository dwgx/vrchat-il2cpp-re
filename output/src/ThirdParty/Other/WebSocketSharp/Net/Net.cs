// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 13
// Methods: 152

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase
    {
        public 0x659C2BF8 _scheme; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void get_Scheme(){} // RVA: 0x70B92A0
        public void CreateNonceValue(){} // RVA: 0x9AE5ED0
        public void ParseParameters(){} // RVA: 0x9AE6160
        public void ToBasicString(){} // RVA: 0xCD60
        public void ToDigestString(){} // RVA: 0xCD60
        public void ToString(){} // RVA: 0x9AE6660
    }

    public class AuthenticationChallenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void Parse(){} // RVA: 0x9AE66F0
        public void ToBasicString(){} // RVA: 0x9AE69B0
        public void ToDigestString(){} // RVA: 0x9AE6A70
    }

    public class AuthenticationResponse
    {
        public uint _nonceCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE6F00 | overloaded x3
        public void get_NonceCount(){} // RVA: 0x9AE70E0
        public void createA1(){} // RVA: 0x9AE71A0 | overloaded x2
        public void createA2(){} // RVA: 0x9AE7310 | overloaded x2
        public void hash(){} // RVA: 0x9AE73C0
        public void initAsDigest(){} // RVA: 0x9AE76F0
        public void CreateRequestDigest(){} // RVA: 0x9AE7B90
        public void ToBasicString(){} // RVA: 0x9AE8350
        public void ToDigestString(){} // RVA: 0x9AE8590
        public void <initAsDigest>b__0(){} // RVA: 0x9AE8B10
    }

    public class ClientSslConfiguration
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _certs; // 0x28
        public string _host; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AEB6A0 | overloaded x2
        public void get_ClientCertificates(){} // RVA: 0x7145590
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x9AEB2B0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x9AEB440
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x343E80
        public void get_TargetHost(){} // RVA: 0x7145E90
    }

    public class Cookie
    {
        public string Sorted; // 0x10
        public System.Uri Count; // 0x18
        public bool IsSynchronized; // 0x20
        public string SyncRoot; // 0x28
        public System.DateTime .ctor; // 0x30
        public bool _httpOnly; // 0x38
        public string _name; // 0x40
        public string _path; // 0x48
        public string _port; // 0x50
        public int[] _ports; // 0x58
        public char[] _reservedCharsForName;
        public char[] _reservedCharsForValue; // 0x8
        public bool _secure; // 0x60
        public System.DateTime _timestamp; // 0x68

        // ── Methods ──
        public void .cctor(){} // RVA: 0x9AD5000
        public void .ctor(){} // RVA: 0x9AD54F0 | overloaded x2
        public void set_ExactDomain(){} // RVA: 0x8A4A90
        public void set_Comment(){} // RVA: 0x9AD5730
        public void set_CommentUri(){} // RVA: 0x343E80
        public void set_Discard(){} // RVA: 0x3CB9E0
        public void get_Domain(){} // RVA: 0x7145590
        public void set_Domain(){} // RVA: 0x9AD57E0
        public void get_Expired(){} // RVA: 0x9AD5940
        public void get_Expires(){} // RVA: 0x7145E90
        public void set_Expires(){} // RVA: 0x1F74DF0
        public void set_HttpOnly(){} // RVA: 0x4A78C0
        public void get_Name(){} // RVA: 0x7187E30
        public void set_Name(){} // RVA: 0x9AD5A40
        public void get_Path(){} // RVA: 0x7187EA0
        public void set_Path(){} // RVA: 0x9AD5B40
        public void set_Port(){} // RVA: 0x9AD5BF0
        public void set_Secure(){} // RVA: 0x306030
        public void get_Value(){} // RVA: 0x7188200
        public void set_Value(){} // RVA: 0x9AD5EB0
        public void get_Version(){} // RVA: 0x72B4D80
        public void set_Version(){} // RVA: 0x9AD5FF0
        public void canSetName(){} // RVA: 0x9AD6080
        public void canSetValue(){} // RVA: 0x9AD62F0
        public void hash(){} // RVA: 0x9AD6570
        public void tryCreatePorts(){} // RVA: 0x9AD65C0
        public void ToRequestString(){} // RVA: 0x9AD6900
        public void Equals(){} // RVA: 0x9AD6E50
        public void GetHashCode(){} // RVA: 0x9AD7160
        public void ToString(){} // RVA: 0x9AD7350
    }

    public class CookieCollection
    {
        public System.Collections.Generic.List`1<WebSocketSharp.Net.Cookie> _list; // 0x10
        public object _sync; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AD7360
        public void get_Sorted(){} // RVA: 0x9AD7420
        public void get_Count(){} // RVA: 0x9AD7520
        public void get_IsSynchronized(){} // RVA: 0x27694F0
        public void get_SyncRoot(){} // RVA: 0x9AD7570
        public void compareCookieWithinSorted(){} // RVA: 0x9AD7620
        public void parseRequest(){} // RVA: 0x9AD7690
        public void parseResponse(){} // RVA: 0x9AD8120
        public void searchCookie(){} // RVA: 0x9AD9370
        public void splitCookieHeaderValue(){} // RVA: 0x9AD9660
        public void Parse(){} // RVA: 0x9AD9780
        public void SetOrRemove(){} // RVA: 0x9AD98C0 | overloaded x2
        public void Add(){} // RVA: 0x9AD9BF0
        public void CopyTo(){} // RVA: 0x9AD9D00
        public void GetEnumerator(){} // RVA: 0x9ADA000
    }

    public class CookieException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E7D530 | overloaded x3
        public void GetObjectData(){} // RVA: 0x6B21340
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B21340
    }

    public class HttpHeaderInfo
    {
        public string _name; // 0x10
        public 0x659C31D0 _type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_IsMultiValueInRequest(){} // RVA: 0x9AE0430
        public void get_IsMultiValueInResponse(){} // RVA: 0x9AE0440
        public void get_IsRequest(){} // RVA: 0x9AE0450
        public void get_IsResponse(){} // RVA: 0x9AE0460
        public void get_Name(){} // RVA: 0x33B6D40
        public void IsMultiValue(){} // RVA: 0x9AE0470
        public void IsRestricted(){} // RVA: 0x9AE04B0
    }

    public class HttpUtility
    {
        // ── Methods ──
        public void getChar(){} // RVA: 0x9ADA0F0
        public void getInt(){} // RVA: 0x9ADA210
        public void writeCharBytes(){} // RVA: 0x9ADA240
        public void GetEncoding(){} // RVA: 0x9ADA420
        public void UrlDecode(){} // RVA: 0x9ADA750 | overloaded x2
        public void .cctor(){} // RVA: 0x9ADAB60
    }

    public class HttpVersion
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9ADF9D0
    }

    public class NetworkCredential
    {
        public string _domain; // 0x10
        public string _password; // 0x18
        public string[] _roles; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE1D40
        public void get_Domain(){} // RVA: 0x9AE1F60
        public void get_Password(){} // RVA: 0x9AE1FB0
        public void get_UserName(){} // RVA: 0x7145590
    }

    public class SslConfiguration
    {
        public System.Net.Security.LocalCertificateSelectionCallback ClientCertificates; // 0x10
        public System.Net.Security.RemoteCertificateValidationCallback ClientCertificateSelectionCallback; // 0x18
        public bool ServerCertificateValidationCallback; // 0x20
        public 0x6584C200 TargetHost; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AEB2A0
        public void get_CertificateSelectionCallback(){} // RVA: 0x9AEB2B0
        public void get_CertificateValidationCallback(){} // RVA: 0x9AEB440
        public void set_CertificateValidationCallback(){} // RVA: 0x343E80
        public void get_CheckCertificateRevocation(){} // RVA: 0x9AEB5D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7079D00
        public void set_EnabledSslProtocols(){} // RVA: 0x16E1F00
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x3E0F620
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x20D68C0
    }

    public class WebHeaderCollection
    {
        public System.Collections.Generic.Dictionary`2<string,WebSocketSharp.Net.HttpHeaderInfo> _headers;
        public bool _internallyUsed; // 0x68

        // ── Methods ──
        public void .cctor(){} // RVA: 0x9ADACD0
        public void .ctor(){} // RVA: 0x9ADD4A0 | overloaded x2
        public void get_AllKeys(){} // RVA: 0x6CB7090
        public void get_Count(){} // RVA: 0x5C64F90
        public void add(){} // RVA: 0x9ADD4B0
        public void addWithoutCheckingName(){} // RVA: 0x9ADD5B0
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0x9ADD6B0
        public void checkColonSeparated(){} // RVA: 0x9ADD730
        public void checkHeaderType(){} // RVA: 0x9ADD7E0
        public void checkName(){} // RVA: 0x9ADD870
        public void checkRestricted(){} // RVA: 0x9ADD9E0
        public void checkState(){} // RVA: 0x9ADDAE0
        public void checkValue(){} // RVA: 0x9ADDBA0
        public void doWithCheckingState(){} // RVA: 0x9ADDF80 | overloaded x2
        public void doWithoutCheckingName(){} // RVA: 0x9ADE090
        public void getHeaderInfo(){} // RVA: 0x9ADE140
        public void isRestricted(){} // RVA: 0x9ADE450
        public void removeWithoutCheckingName(){} // RVA: 0x9ADE4E0
        public void setWithoutCheckingName(){} // RVA: 0x9ADE520
        public void InternalSet(){} // RVA: 0x9ADE850 | overloaded x2
        public void IsHeaderName(){} // RVA: 0x9ADE980
        public void IsHeaderValue(){} // RVA: 0x9ADE9F0
        public void IsMultiValue(){} // RVA: 0x9ADEA40
        public void Add(){} // RVA: 0x9ADEB30
        public void Get(){} // RVA: 0x6CB6B50 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x6CBCFF0
        public void GetKey(){} // RVA: 0x9ADEC20
        public void GetValues(){} // RVA: 0x9ADECD0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x9ADED80
        public void OnDeserialization(){} // RVA: 0x2DD310
        public void Remove(){} // RVA: 0x9ADF020
        public void Set(){} // RVA: 0x9ADF0F0
        public void ToString(){} // RVA: 0x9ADF1D0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B25660
    }

}