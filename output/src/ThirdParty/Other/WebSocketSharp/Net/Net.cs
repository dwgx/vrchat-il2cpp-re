// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 13
// Methods: 152

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
        public void get_Scheme(){} // RVA: 0x7FFAF9B692A0
        public void CreateNonceValue(){} // RVA: 0x7FFAFC595ED0
        public void ParseParameters(){} // RVA: 0x7FFAFC596160
        public void ToBasicString(){} // RVA: 0x7FFAF2ABCD60
        public void ToDigestString(){} // RVA: 0x7FFAF2ABCD60
        public void ToString(){} // RVA: 0x7FFAFC596660
    }

    public class AuthenticationChallenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
        public void Parse(){} // RVA: 0x7FFAFC5966F0
        public void ToBasicString(){} // RVA: 0x7FFAFC5969B0
        public void ToDigestString(){} // RVA: 0x7FFAFC596A70
    }

    public class AuthenticationResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC596F00 | overloaded x3
        public void get_NonceCount(){} // RVA: 0x7FFAFC5970E0
        public void createA1(){} // RVA: 0x7FFAFC5971A0 | overloaded x2
        public void createA2(){} // RVA: 0x7FFAFC597310 | overloaded x2
        public void hash(){} // RVA: 0x7FFAFC5973C0
        public void initAsDigest(){} // RVA: 0x7FFAFC5976F0
        public void CreateRequestDigest(){} // RVA: 0x7FFAFC597B90
        public void ToBasicString(){} // RVA: 0x7FFAFC598350
        public void ToDigestString(){} // RVA: 0x7FFAFC598590
        public void <initAsDigest>b__0(){} // RVA: 0x7FFAFC598B10
    }

    public class ClientSslConfiguration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC59B6A0 | overloaded x2
        public void get_ClientCertificates(){} // RVA: 0x7FFAF9BF5590
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7FFAFC59B2B0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7FFAFC59B440
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7FFAF2DF3E80
        public void get_TargetHost(){} // RVA: 0x7FFAF9BF5E90
    }

    public class Cookie
    {
        public object Sorted;
        public object Count;
        public object IsSynchronized;
        public object SyncRoot;
        public object .ctor;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC585000
        public void .ctor(){} // RVA: 0x7FFAFC5854F0 | overloaded x2
        public void set_ExactDomain(){} // RVA: 0x7FFAF3354A90
        public void set_Comment(){} // RVA: 0x7FFAFC585730
        public void set_CommentUri(){} // RVA: 0x7FFAF2DF3E80
        public void set_Discard(){} // RVA: 0x7FFAF2E7B9E0
        public void get_Domain(){} // RVA: 0x7FFAF9BF5590
        public void set_Domain(){} // RVA: 0x7FFAFC5857E0
        public void get_Expired(){} // RVA: 0x7FFAFC585940
        public void get_Expires(){} // RVA: 0x7FFAF9BF5E90
        public void set_Expires(){} // RVA: 0x7FFAF4A24DF0
        public void set_HttpOnly(){} // RVA: 0x7FFAF2F578C0
        public void get_Name(){} // RVA: 0x7FFAF9C37E30
        public void set_Name(){} // RVA: 0x7FFAFC585A40
        public void get_Path(){} // RVA: 0x7FFAF9C37EA0
        public void set_Path(){} // RVA: 0x7FFAFC585B40
        public void set_Port(){} // RVA: 0x7FFAFC585BF0
        public void set_Secure(){} // RVA: 0x7FFAF2DB6030
        public void get_Value(){} // RVA: 0x7FFAF9C38200
        public void set_Value(){} // RVA: 0x7FFAFC585EB0
        public void get_Version(){} // RVA: 0x7FFAF9D64D80
        public void set_Version(){} // RVA: 0x7FFAFC585FF0
        public void canSetName(){} // RVA: 0x7FFAFC586080
        public void canSetValue(){} // RVA: 0x7FFAFC5862F0
        public void hash(){} // RVA: 0x7FFAFC586570
        public void tryCreatePorts(){} // RVA: 0x7FFAFC5865C0
        public void ToRequestString(){} // RVA: 0x7FFAFC586900
        public void Equals(){} // RVA: 0x7FFAFC586E50
        public void GetHashCode(){} // RVA: 0x7FFAFC587160
        public void ToString(){} // RVA: 0x7FFAFC587350
    }

    public class CookieCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC587360
        public void get_Sorted(){} // RVA: 0x7FFAFC587420
        public void get_Count(){} // RVA: 0x7FFAFC587520
        public void get_IsSynchronized(){} // RVA: 0x7FFAF52194F0
        public void get_SyncRoot(){} // RVA: 0x7FFAFC587570
        public void compareCookieWithinSorted(){} // RVA: 0x7FFAFC587620
        public void parseRequest(){} // RVA: 0x7FFAFC587690
        public void parseResponse(){} // RVA: 0x7FFAFC588120
        public void searchCookie(){} // RVA: 0x7FFAFC589370
        public void splitCookieHeaderValue(){} // RVA: 0x7FFAFC589660
        public void Parse(){} // RVA: 0x7FFAFC589780
        public void SetOrRemove(){} // RVA: 0x7FFAFC5898C0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAFC589BF0
        public void CopyTo(){} // RVA: 0x7FFAFC589D00
        public void GetEnumerator(){} // RVA: 0x7FFAFC58A000
    }

    public class CookieException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF892D530 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAF95D1340
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D1340
    }

    public class HttpHeaderInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50
        public void get_IsMultiValueInRequest(){} // RVA: 0x7FFAFC590430
        public void get_IsMultiValueInResponse(){} // RVA: 0x7FFAFC590440
        public void get_IsRequest(){} // RVA: 0x7FFAFC590450
        public void get_IsResponse(){} // RVA: 0x7FFAFC590460
        public void get_Name(){} // RVA: 0x7FFAF5E66D40
        public void IsMultiValue(){} // RVA: 0x7FFAFC590470
        public void IsRestricted(){} // RVA: 0x7FFAFC5904B0
    }

    public class HttpUtility
    {
        // ── Methods ──
        public void getChar(){} // RVA: 0x7FFAFC58A0F0
        public void getInt(){} // RVA: 0x7FFAFC58A210
        public void writeCharBytes(){} // RVA: 0x7FFAFC58A240
        public void GetEncoding(){} // RVA: 0x7FFAFC58A420
        public void UrlDecode(){} // RVA: 0x7FFAFC58A750 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAFC58AB60
    }

    public class HttpVersion
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC58F9D0
    }

    public class NetworkCredential
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC591D40
        public void get_Domain(){} // RVA: 0x7FFAFC591F60
        public void get_Password(){} // RVA: 0x7FFAFC591FB0
        public void get_UserName(){} // RVA: 0x7FFAF9BF5590
    }

    public class SslConfiguration
    {
        public object ClientCertificates;
        public object ClientCertificateSelectionCallback;
        public object ServerCertificateValidationCallback;
        public object TargetHost;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC59B2A0
        public void get_CertificateSelectionCallback(){} // RVA: 0x7FFAFC59B2B0
        public void get_CertificateValidationCallback(){} // RVA: 0x7FFAFC59B440
        public void set_CertificateValidationCallback(){} // RVA: 0x7FFAF2DF3E80
        public void get_CheckCertificateRevocation(){} // RVA: 0x7FFAFC59B5D0
        public void get_EnabledSslProtocols(){} // RVA: 0x7FFAF9B29D00
        public void set_EnabledSslProtocols(){} // RVA: 0x7FFAF4191F00
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x7FFAF68BF620
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x7FFAF4B868C0
    }

    public class WebHeaderCollection
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC58ACD0
        public void .ctor(){} // RVA: 0x7FFAFC58D4A0 | overloaded x2
        public void get_AllKeys(){} // RVA: 0x7FFAF9767090
        public void get_Count(){} // RVA: 0x7FFAF8714F90
        public void add(){} // RVA: 0x7FFAFC58D4B0
        public void addWithoutCheckingName(){} // RVA: 0x7FFAFC58D5B0
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0x7FFAFC58D6B0
        public void checkColonSeparated(){} // RVA: 0x7FFAFC58D730
        public void checkHeaderType(){} // RVA: 0x7FFAFC58D7E0
        public void checkName(){} // RVA: 0x7FFAFC58D870
        public void checkRestricted(){} // RVA: 0x7FFAFC58D9E0
        public void checkState(){} // RVA: 0x7FFAFC58DAE0
        public void checkValue(){} // RVA: 0x7FFAFC58DBA0
        public void doWithCheckingState(){} // RVA: 0x7FFAFC58DF80 | overloaded x2
        public void doWithoutCheckingName(){} // RVA: 0x7FFAFC58E090
        public void getHeaderInfo(){} // RVA: 0x7FFAFC58E140
        public void isRestricted(){} // RVA: 0x7FFAFC58E450
        public void removeWithoutCheckingName(){} // RVA: 0x7FFAFC58E4E0
        public void setWithoutCheckingName(){} // RVA: 0x7FFAFC58E520
        public void InternalSet(){} // RVA: 0x7FFAFC58E850 | overloaded x2
        public void IsHeaderName(){} // RVA: 0x7FFAFC58E980
        public void IsHeaderValue(){} // RVA: 0x7FFAFC58E9F0
        public void IsMultiValue(){} // RVA: 0x7FFAFC58EA40
        public void Add(){} // RVA: 0x7FFAFC58EB30
        public void Get(){} // RVA: 0x7FFAF9766B50 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF976CFF0
        public void GetKey(){} // RVA: 0x7FFAFC58EC20
        public void GetValues(){} // RVA: 0x7FFAFC58ECD0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAFC58ED80
        public void OnDeserialization(){} // RVA: 0x7FFAF2D8D310
        public void Remove(){} // RVA: 0x7FFAFC58F020
        public void Set(){} // RVA: 0x7FFAFC58F0F0
        public void ToString(){} // RVA: 0x7FFAFC58F1D0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D5660
    }

}