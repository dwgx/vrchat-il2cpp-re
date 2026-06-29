// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 14
// Methods: 152

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase : Object
    {
        public object _scheme;
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void get_Scheme(){} // RVA: 0x7B51740
        public void CreateNonceValue(){} // RVA: 0xA7954C0
        public void ParseParameters(){} // RVA: 0xA795770
        public void ToBasicString(){} // RVA: 0x87C0A0
        public void ToDigestString(){} // RVA: 0x87C0A0
        public void ToString(){} // RVA: 0xA795C40
    }

    public class AuthenticationChallenge : AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void Parse(){} // RVA: 0xA795CA0
        public void ToBasicString(){} // RVA: 0xA795F60
        public void ToDigestString(){} // RVA: 0xA796020
    }

    public class AuthenticationResponse : AuthenticationBase
    {
        public object _nonceCount;
        public object CS$<>9__CachedAnonymousMethodDelegate1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7964C0
        public void get_NonceCount(){} // RVA: 0xA796660
        public void createA1(){} // RVA: 0xA796720
        public void createA2(){} // RVA: 0xA796890
        public void hash(){} // RVA: 0xA796940
        public void initAsDigest(){} // RVA: 0xA796C90
        public void CreateRequestDigest(){} // RVA: 0xA797110
        public void ToBasicString(){} // RVA: 0xA7978D0
        public void ToDigestString(){} // RVA: 0xA797B10
        public void <initAsDigest>b__0(){} // RVA: 0xA798090
    }

    public class ClientSslConfiguration : SslConfiguration
    {
        public object _certs;
        public object _host;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79AC30
        public void get_ClientCertificates(){} // RVA: 0x7C246A0
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0xA79A840
        public void get_ServerCertificateValidationCallback(){} // RVA: 0xA79A9D0
        public void set_ServerCertificateValidationCallback(){} // RVA: 0xBA9BA0
        public void get_TargetHost(){} // RVA: 0x7C24F60
    }

    public class Cookie : Object
    {
        public object _comment;
        public object _commentUri;
        public object _discard;
        public object _domain;
        public object _expires;
        public object _httpOnly;
        public object _name;
        public object _path;
        public object _port;
        public object _ports;
        public object _reservedCharsForName;
        public object _reservedCharsForValue;
        public object _secure;
        public object _timestamp;
        public object _value;
        public object _version;
        public object _exactDomain;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA784820
        public void .ctor(){} // RVA: 0xA784D00
        public void set_ExactDomain(){} // RVA: 0x1164780
        public void set_Comment(){} // RVA: 0x7AA8900
        public void set_CommentUri(){} // RVA: 0xBA9BA0
        public void set_Discard(){} // RVA: 0xC38370
        public void get_Domain(){} // RVA: 0x7C246A0
        public void set_Domain(){} // RVA: 0xA784F40
        public void get_Expired(){} // RVA: 0xA785090
        public void get_Expires(){} // RVA: 0x7C24F60
        public void set_Expires(){} // RVA: 0x27FA7C0
        public void set_HttpOnly(){} // RVA: 0xD14C10
        public void get_Name(){} // RVA: 0x7C7DFA0
        public void set_Name(){} // RVA: 0xA785190
        public void get_Path(){} // RVA: 0x7C7E010
        public void set_Path(){} // RVA: 0xA785290
        public void set_Port(){} // RVA: 0xA785310
        public void set_Secure(){} // RVA: 0xB6B1B0
        public void get_Value(){} // RVA: 0x7C7E370
        public void set_Value(){} // RVA: 0xA7855B0
        public void get_Version(){} // RVA: 0x7E22E30
        public void set_Version(){} // RVA: 0xA7856F0
        public void canSetName(){} // RVA: 0xA785780
        public void canSetValue(){} // RVA: 0xA785A00
        public void hash(){} // RVA: 0xA785C90
        public void tryCreatePorts(){} // RVA: 0xA785CE0
        public void ToRequestString(){} // RVA: 0xA786060
        public void Equals(){} // RVA: 0xA7865B0
        public void GetHashCode(){} // RVA: 0xA7868C0
        public void ToString(){} // RVA: 0xA786AB0
    }

    public class CookieCollection : Object
    {
        public object _list;
        public object _sync;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA786AC0
        public void get_Sorted(){} // RVA: 0xA786B80
        public void get_Count(){} // RVA: 0xA786C80
        public void get_IsSynchronized(){} // RVA: 0x263B110
        public void get_SyncRoot(){} // RVA: 0xA786CD0
        public void compareCookieWithinSorted(){} // RVA: 0xA786D80
        public void parseRequest(){} // RVA: 0xA786DF0
        public void parseResponse(){} // RVA: 0xA787860
        public void searchCookie(){} // RVA: 0xA788A70
        public void splitCookieHeaderValue(){} // RVA: 0xA788D80
        public void Parse(){} // RVA: 0xA788EA0
        public void SetOrRemove(){} // RVA: 0xA788FE0
        public void Add(){} // RVA: 0xA789310
        public void CopyTo(){} // RVA: 0xA789420
        public void GetEnumerator(){} // RVA: 0xA789710
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68F6690
        public void GetObjectData(){} // RVA: 0x7585810
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7585810
    }

    public class Cookie[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class HttpHeaderInfo : Object
    {
        public object _name;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void get_IsMultiValueInRequest(){} // RVA: 0xA78FAB0
        public void get_IsMultiValueInResponse(){} // RVA: 0xA78FAC0
        public void get_IsRequest(){} // RVA: 0xA78FAD0
        public void get_IsResponse(){} // RVA: 0xA78FAE0
        public void get_Name(){} // RVA: 0x3E42230
        public void IsMultiValue(){} // RVA: 0xA78FAF0
        public void IsRestricted(){} // RVA: 0xA78FB20
    }

    public class HttpUtility : Object
    {
        public object _hexChars;
        public object _sync;

        // ── Methods ──
        public void getChar(){} // RVA: 0xA789800
        public void getInt(){} // RVA: 0xA789920
        public void writeCharBytes(){} // RVA: 0xA789950
        public void GetEncoding(){} // RVA: 0xA789B30
        public void UrlDecode(){} // RVA: 0xA789E70
        public void .cctor(){} // RVA: 0xA78A280
    }

    public class HttpVersion : Object
    {
        public object Version10;
        public object Version11;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA78F070
    }

    public class NetworkCredential : Object
    {
        public object _domain;
        public object _password;
        public object _roles;
        public object _userName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7914C0
        public void get_Domain(){} // RVA: 0xA7916E0
        public void get_Password(){} // RVA: 0x67D9AC0
        public void get_UserName(){} // RVA: 0x7C246A0
    }

    public class SslConfiguration : Object
    {
        public object _certSelectionCallback;
        public object _certValidationCallback;
        public object _checkCertRevocation;
        public object _enabledProtocols;
        public object CS$<>9__CachedAnonymousMethodDelegate1;
        public object CS$<>9__CachedAnonymousMethodDelegate3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79A830
        public void get_CertificateSelectionCallback(){} // RVA: 0xA79A840
        public void get_CertificateValidationCallback(){} // RVA: 0xA79A9D0
        public void set_CertificateValidationCallback(){} // RVA: 0xBA9BA0
        public void get_CheckCertificateRevocation(){} // RVA: 0xA79AB60
        public void get_EnabledSslProtocols(){} // RVA: 0x7CA9110
        public void set_EnabledSslProtocols(){} // RVA: 0x1FAA840
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x4005650
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x295D5B0
    }

    public class WebHeaderCollection : NameValueCollection
    {
        public object _headers;
        public object _internallyUsed;
        public object _state;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA78A3F0
        public void .ctor(){} // RVA: 0xA78CBC0
        public void get_AllKeys(){} // RVA: 0x7715AF0
        public void get_Count(){} // RVA: 0x66DD600
        public void add(){} // RVA: 0xA78CBD0
        public void addWithoutCheckingName(){} // RVA: 0xA78CCD0
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0xA78CDD0
        public void checkColonSeparated(){} // RVA: 0xA78CE50
        public void checkHeaderType(){} // RVA: 0xA78CF00
        public void checkName(){} // RVA: 0xA78CF90
        public void checkRestricted(){} // RVA: 0xA78D100
        public void checkState(){} // RVA: 0xA78D200
        public void checkValue(){} // RVA: 0xA78D2C0
        public void doWithCheckingState(){} // RVA: 0xA78D680
        public void doWithoutCheckingName(){} // RVA: 0xA78D790
        public void getHeaderInfo(){} // RVA: 0xA78D840
        public void isRestricted(){} // RVA: 0xA78DB70
        public void removeWithoutCheckingName(){} // RVA: 0xA78DBF0
        public void setWithoutCheckingName(){} // RVA: 0xA78DC30
        public void InternalSet(){} // RVA: 0xA78DF40
        public void IsHeaderName(){} // RVA: 0xA78E060
        public void IsHeaderValue(){} // RVA: 0xA78E0D0
        public void IsMultiValue(){} // RVA: 0xA78E120
        public void Add(){} // RVA: 0xA78E1E0
        public void Get(){} // RVA: 0x77155A0
        public void GetEnumerator(){} // RVA: 0x771BB90
        public void GetKey(){} // RVA: 0xA78E2D0
        public void GetValues(){} // RVA: 0xA78E380
        public void GetObjectData(){} // RVA: 0xA78E430
        public void OnDeserialization(){} // RVA: 0xB43310
        public void Remove(){} // RVA: 0xA78E6D0
        public void Set(){} // RVA: 0xA78E7A0
        public void ToString(){} // RVA: 0xA78E880
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7589B00
    }

}