// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase : Object
    {
        public 0x66698A04 _scheme; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void get_Scheme(){} // RVA: 0x7FFE87BFA280
        public void CreateNonceValue(){} // RVA: 0x7FFE8A525560
        public void ParseParameters(){} // RVA: 0x7FFE8A5257F0
        public void ToBasicString(){} // RVA: 0x7FFE80E2E2E0
        public void ToDigestString(){} // RVA: 0x7FFE80E2E2E0
        public void ToString(){} // RVA: 0x7FFE8A525CF0
    }

    public class AuthenticationChallenge : AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void Parse(){} // RVA: 0x7FFE8A525D80
        public void ToBasicString(){} // RVA: 0x7FFE8A526040
        public void ToDigestString(){} // RVA: 0x7FFE8A526100
    }

    public class AuthenticationResponse : AuthenticationBase
    {
        public uint _nonceCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A526590 | overloaded x3
        public void get_NonceCount(){} // RVA: 0x7FFE8A526770
        public void createA1(){} // RVA: 0x7FFE8A526830 | overloaded x2
        public void createA2(){} // RVA: 0x7FFE8A5269A0 | overloaded x2
        public void hash(){} // RVA: 0x7FFE8A526A50
        public void initAsDigest(){} // RVA: 0x7FFE8A526D80
        public void CreateRequestDigest(){} // RVA: 0x7FFE8A527220
        public void ToBasicString(){} // RVA: 0x7FFE8A5279E0
        public void ToDigestString(){} // RVA: 0x7FFE8A527C20
        public void <initAsDigest>b__0(){} // RVA: 0x7FFE8A5281A0
    }

    public class ClientSslConfiguration : SslConfiguration
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection _certs; // 0x28
        public string _host; // 0x30
        public object field_2; // 0x52
        public object field_3; // 0x53

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52AD30 | overloaded x2
        public void get_ClientCertificates(){} // RVA: 0x7FFE87C86200
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFE8A52A940
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFE8A52AAD0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFE81161E80
        public void get_TargetHost(){} // RVA: 0x7FFE87C86B00
    }

    public class Cookie : Object
    {
        public string _comment; // 0x10
        public System.Uri _commentUri; // 0x18
        public bool _discard; // 0x20
        public string _domain; // 0x28
        public System.DateTime _expires; // 0x30
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
        public void .cctor(){} // RVA: 0x7FFE8A514B60
        public void .ctor(){} // RVA: 0x7FFE8A515050 | overloaded x2
        public void set_ExactDomain(){} // RVA: 0x7FFE81641190
        public void set_Comment(){} // RVA: 0x7FFE8A515290
        public void set_CommentUri(){} // RVA: 0x7FFE81161E80
        public void set_Discard(){} // RVA: 0x7FFE811E99E0
        public void get_Domain(){} // RVA: 0x7FFE87C86200
        public void set_Domain(){} // RVA: 0x7FFE8A515340
        public void get_Expired(){} // RVA: 0x7FFE8A5154A0
        public void get_Expires(){} // RVA: 0x7FFE87C86B00
        public void set_Expires(){} // RVA: 0x7FFE82D00170
        public void set_HttpOnly(){} // RVA: 0x7FFE812D0010
        public void get_Name(){} // RVA: 0x7FFE87CC7FD0
        public void set_Name(){} // RVA: 0x7FFE8A5155A0
        public void get_Path(){} // RVA: 0x7FFE87CC8040
        public void set_Path(){} // RVA: 0x7FFE8A5156A0
        public void set_Port(){} // RVA: 0x7FFE8A515750
        public void set_Secure(){} // RVA: 0x7FFE81124030
        public void get_Value(){} // RVA: 0x7FFE87CC83A0
        public void set_Value(){} // RVA: 0x7FFE8A515A10
        public void get_Version(){} // RVA: 0x7FFE87DF4F20
        public void set_Version(){} // RVA: 0x7FFE8A515B50
        public void canSetName(){} // RVA: 0x7FFE8A515BE0
        public void canSetValue(){} // RVA: 0x7FFE8A515E50
        public void hash(){} // RVA: 0x7FFE8A5160D0
        public void tryCreatePorts(){} // RVA: 0x7FFE8A516120
        public void ToRequestString(){} // RVA: 0x7FFE8A516460
        public void Equals(){} // RVA: 0x7FFE8A5169B0
        public void GetHashCode(){} // RVA: 0x7FFE8A516CC0
        public void ToString(){} // RVA: 0x7FFE8A516EB0
    }

    public class CookieCollection : Object
    {
        public System.Collections.Generic.List`1<WebSocketSharp.Net.Cookie> _list; // 0x10
        public object _sync; // 0x18
        public object field_2; // 0x1B
        public object field_3; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A516EC0
        public void get_Sorted(){} // RVA: 0x7FFE8A516F80
        public void get_Count(){} // RVA: 0x7FFE8A517080
        public void get_IsSynchronized(){} // RVA: 0x7FFE834BA0A0
        public void get_SyncRoot(){} // RVA: 0x7FFE8A5170D0
        public void compareCookieWithinSorted(){} // RVA: 0x7FFE8A517180
        public void parseRequest(){} // RVA: 0x7FFE8A5171F0
        public void parseResponse(){} // RVA: 0x7FFE8A517C80
        public void searchCookie(){} // RVA: 0x7FFE8A518ED0
        public void splitCookieHeaderValue(){} // RVA: 0x7FFE8A5191C0
        public void Parse(){} // RVA: 0x7FFE8A5192E0
        public void SetOrRemove(){} // RVA: 0x7FFE8A519420 | overloaded x2
        public void Add(){} // RVA: 0x7FFE8A519750
        public void CopyTo(){} // RVA: 0x7FFE8A519860
        public void GetEnumerator(){} // RVA: 0x7FFE8A519B60
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869BE370 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFE87660600
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87660600
    }

    public class HttpHeaderInfo : Object
    {
        public string _name; // 0x10
        public 0x66698FDC _type; // 0x18
        public object field_2; // 0x26
        public object field_3; // 0x27
        public object field_4; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_IsMultiValueInRequest(){} // RVA: 0x7FFE8A51FF90
        public void get_IsMultiValueInResponse(){} // RVA: 0x7FFE8A51FFA0
        public void get_IsRequest(){} // RVA: 0x7FFE8A51FFB0
        public void get_IsResponse(){} // RVA: 0x7FFE8A51FFC0
        public void get_Name(){} // RVA: 0x7FFE84022BE0
        public void IsMultiValue(){} // RVA: 0x7FFE8A51FFD0
        public void IsRestricted(){} // RVA: 0x7FFE8A520010
    }

    public class HttpUtility : Object
    {
        // ── Methods ──
        public void getChar(){} // RVA: 0x7FFE8A519C50
        public void getInt(){} // RVA: 0x7FFE8A519D70
        public void writeCharBytes(){} // RVA: 0x7FFE8A519DA0
        public void GetEncoding(){} // RVA: 0x7FFE8A519F80
        public void UrlDecode(){} // RVA: 0x7FFE8A51A2B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A51A6C0
    }

    public class HttpVersion : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A51F530
    }

    public class NetworkCredential : Object
    {
        public string _domain; // 0x10
        public string _password; // 0x18
        public string _userName; // 0x20

        // ── Methods ──
        public void get_Domain(){} // RVA: 0x7FFE8A521700
        public void get_Password(){} // RVA: 0x7FFE8A521750
        public void get_UserName(){} // RVA: 0x7FFE87563690
    }

    public class SslConfiguration : Object
    {
        public System.Net.Security.LocalCertificateSelectionCallback _certSelectionCallback; // 0x10
        public System.Net.Security.RemoteCertificateValidationCallback _certValidationCallback; // 0x18
        public bool _checkCertRevocation; // 0x20
        public 0x6652A1A4 _enabledProtocols; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52A930
        public void get_CertificateSelectionCallback(){} // RVA: 0x7FFE8A52A940
        public void get_CertificateValidationCallback(){} // RVA: 0x7FFE8A52AAD0
        public void set_CertificateValidationCallback(){} // RVA: 0x7FFE81161E80
        public void get_CheckCertificateRevocation(){} // RVA: 0x7FFE8A52AC60
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFE87BBABC0
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFE82447980
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x7FFE84A912C0
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x7FFE82E64CC0
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public System.Collections.Generic.Dictionary`2<string,WebSocketSharp.Net.HttpHeaderInfo> _headers;
        public bool _internallyUsed; // 0x68

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A51A830
        public void .ctor(){} // RVA: 0x7FFE8A51D000 | overloaded x2
        public void get_AllKeys(){} // RVA: 0x7FFE877F7F30
        public void get_Count(){} // RVA: 0x7FFE85B0C750
        public void add(){} // RVA: 0x7FFE8A51D010
        public void addWithoutCheckingName(){} // RVA: 0x7FFE8A51D110
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0x7FFE8A51D210
        public void checkColonSeparated(){} // RVA: 0x7FFE8A51D290
        public void checkHeaderType(){} // RVA: 0x7FFE8A51D340
        public void checkName(){} // RVA: 0x7FFE8A51D3D0
        public void checkRestricted(){} // RVA: 0x7FFE8A51D540
        public void checkState(){} // RVA: 0x7FFE8A51D640
        public void checkValue(){} // RVA: 0x7FFE8A51D700
        public void doWithCheckingState(){} // RVA: 0x7FFE8A51DAE0 | overloaded x2
        public void doWithoutCheckingName(){} // RVA: 0x7FFE8A51DBF0
        public void getHeaderInfo(){} // RVA: 0x7FFE8A51DCA0
        public void isRestricted(){} // RVA: 0x7FFE8A51DFB0
        public void removeWithoutCheckingName(){} // RVA: 0x7FFE8A51E040
        public void setWithoutCheckingName(){} // RVA: 0x7FFE8A51E080
        public void InternalSet(){} // RVA: 0x7FFE8A51E3B0 | overloaded x2
        public void IsHeaderName(){} // RVA: 0x7FFE8A51E4E0
        public void IsHeaderValue(){} // RVA: 0x7FFE8A51E550
        public void IsMultiValue(){} // RVA: 0x7FFE8A51E5A0
        public void Add(){} // RVA: 0x7FFE8A51E690
        public void Get(){} // RVA: 0x7FFE877F79F0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE877FDE90
        public void GetKey(){} // RVA: 0x7FFE8A51E780
        public void GetValues(){} // RVA: 0x7FFE8A51E830 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE8A51E8E0
        public void OnDeserialization(){} // RVA: 0x7FFE810FB310
        public void Remove(){} // RVA: 0x7FFE8A51EB80
        public void Set(){} // RVA: 0x7FFE8A51EC50
        public void ToString(){} // RVA: 0x7FFE8A51ED30
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87664920
    }

}