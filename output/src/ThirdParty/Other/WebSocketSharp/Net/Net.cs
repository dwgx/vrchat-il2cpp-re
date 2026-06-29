// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp.Net
// Classes: 14
// Methods: 152

namespace ThirdParty.Other.WebSocketSharp.Net
{
    public class AuthenticationBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void get_Scheme(){} // RVA: 0x7AEE980C0
        public void CreateNonceValue(){} // RVA: 0x7B1927A50
        public void ParseParameters(){} // RVA: 0x7B1927D00
        public void ToBasicString(){} // RVA: 0x7A7E00680
        public void ToDigestString(){} // RVA: 0x7A7E00680
        public void ToString(){} // RVA: 0x7B19281F0
    }

    public class AuthenticationChallenge : AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void Parse(){} // RVA: 0x7B1928280
        public void ToBasicString(){} // RVA: 0x7B1928540
        public void ToDigestString(){} // RVA: 0x7B1928600
    }

    public class AuthenticationResponse : AuthenticationBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1928AA0
        public void get_NonceCount(){} // RVA: 0x7B1928C80
        public void createA1(){} // RVA: 0x7B1928D40
        public void createA2(){} // RVA: 0x7B1928EB0
        public void hash(){} // RVA: 0x7B1928F60
        public void initAsDigest(){} // RVA: 0x7B19292B0
        public void CreateRequestDigest(){} // RVA: 0x7B1929750
        public void ToBasicString(){} // RVA: 0x7B1929F10
        public void ToDigestString(){} // RVA: 0x7B192A150
        public void <initAsDigest>b__0(){} // RVA: 0x7B192A6D0
    }

    public class ClientSslConfiguration : SslConfiguration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B192D290
        public void get_ClientCertificates(){} // RVA: 0x7AEF244A0
        public void get_ClientCertificateSelectionCallback(){} // RVA: 0x7B192CEA0
        public void get_ServerCertificateValidationCallback(){} // RVA: 0x7B192D030
        public void set_ServerCertificateValidationCallback(){} // RVA: 0x7A813E420
        public void get_TargetHost(){} // RVA: 0x7AEF24D90
    }

    public class Cookie : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1916950
        public void .ctor(){} // RVA: 0x7B1916E40
        public void set_ExactDomain(){} // RVA: 0x7A86616D0
        public void set_Comment(){} // RVA: 0x7B1917080
        public void set_CommentUri(){} // RVA: 0x7A813E420
        public void set_Discard(){} // RVA: 0x7A81C68E0
        public void get_Domain(){} // RVA: 0x7AEF244A0
        public void set_Domain(){} // RVA: 0x7B1917130
        public void get_Expired(){} // RVA: 0x7B1917290
        public void get_Expires(){} // RVA: 0x7AEF24D90
        public void set_Expires(){} // RVA: 0x7A9D7F900
        public void set_HttpOnly(){} // RVA: 0x7A82A2C90
        public void get_Name(){} // RVA: 0x7AEF66FF0
        public void set_Name(){} // RVA: 0x7B1917390
        public void get_Path(){} // RVA: 0x7AEF67060
        public void set_Path(){} // RVA: 0x7B1917490
        public void set_Port(){} // RVA: 0x7B1917540
        public void set_Secure(){} // RVA: 0x7A8100270
        public void get_Value(){} // RVA: 0x7AEF673C0
        public void set_Value(){} // RVA: 0x7B19177F0
        public void get_Version(){} // RVA: 0x7AF094E10
        public void set_Version(){} // RVA: 0x7B1917930
        public void canSetName(){} // RVA: 0x7B19179C0
        public void canSetValue(){} // RVA: 0x7B1917C50
        public void hash(){} // RVA: 0x7B1917EF0
        public void tryCreatePorts(){} // RVA: 0x7B1917F40
        public void ToRequestString(){} // RVA: 0x7B19182D0
        public void Equals(){} // RVA: 0x7B1918840
        public void GetHashCode(){} // RVA: 0x7B1918B50
        public void ToString(){} // RVA: 0x7B1918D40
    }

    public class CookieCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1918D50
        public void get_Sorted(){} // RVA: 0x7B1918E10
        public void get_Count(){} // RVA: 0x7B1918F10
        public void get_IsSynchronized(){} // RVA: 0x7AA57AB40
        public void get_SyncRoot(){} // RVA: 0x7B1918F60
        public void compareCookieWithinSorted(){} // RVA: 0x7B1919010
        public void parseRequest(){} // RVA: 0x7B1919080
        public void parseResponse(){} // RVA: 0x7B1919B20
        public void searchCookie(){} // RVA: 0x7B191AD90
        public void splitCookieHeaderValue(){} // RVA: 0x7B191B0A0
        public void Parse(){} // RVA: 0x7B191B1C0
        public void SetOrRemove(){} // RVA: 0x7B191B300
        public void Add(){} // RVA: 0x7B191B630
        public void CopyTo(){} // RVA: 0x7B191B740
        public void GetEnumerator(){} // RVA: 0x7B191BA40
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC6BF30
        public void GetObjectData(){} // RVA: 0x7AE912010
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE912010
    }

    public class Cookie[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class HttpHeaderInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
        public void get_IsMultiValueInRequest(){} // RVA: 0x7B1921E30
        public void get_IsMultiValueInResponse(){} // RVA: 0x7B1921E40
        public void get_IsRequest(){} // RVA: 0x7B1921E50
        public void get_IsResponse(){} // RVA: 0x7B1921E60
        public void get_Name(){} // RVA: 0x7AB1AC740
        public void IsMultiValue(){} // RVA: 0x7B1921E70
        public void IsRestricted(){} // RVA: 0x7B1921EA0
    }

    public class HttpUtility : Object
    {
        // ── Methods ──
        public void getChar(){} // RVA: 0x7B191BB30
        public void getInt(){} // RVA: 0x7B191BC50
        public void writeCharBytes(){} // RVA: 0x7B191BC80
        public void GetEncoding(){} // RVA: 0x7B191BE70
        public void UrlDecode(){} // RVA: 0x7B191C1B0
        public void .cctor(){} // RVA: 0x7B191C5C0
    }

    public class HttpVersion : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B19213D0
    }

    public class NetworkCredential : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B19238A0
        public void get_Domain(){} // RVA: 0x7B1923AC0
        public void get_Password(){} // RVA: 0x7B1923B10
        public void get_UserName(){} // RVA: 0x7AEF244A0
    }

    public class SslConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B192CE90
        public void get_CertificateSelectionCallback(){} // RVA: 0x7B192CEA0
        public void get_CertificateValidationCallback(){} // RVA: 0x7B192D030
        public void set_CertificateValidationCallback(){} // RVA: 0x7A813E420
        public void get_CheckCertificateRevocation(){} // RVA: 0x7B192D1C0
        public void get_EnabledSslProtocols(){} // RVA: 0x7AEE58D60
        public void set_EnabledSslProtocols(){} // RVA: 0x7A94794D0
        public void <get_CertificateSelectionCallback>b__0(){} // RVA: 0x7ABC0A600
        public void <get_CertificateValidationCallback>b__2(){} // RVA: 0x7A9EEB150
    }

    public class WebHeaderCollection : NameValueCollection
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B191C730
        public void .ctor(){} // RVA: 0x7B191EF00
        public void get_AllKeys(){} // RVA: 0x7AEAA6280
        public void get_Count(){} // RVA: 0x7ADA52F20
        public void add(){} // RVA: 0x7B191EF10
        public void addWithoutCheckingName(){} // RVA: 0x7B191F010
        public void addWithoutCheckingNameAndRestricted(){} // RVA: 0x7B191F110
        public void checkColonSeparated(){} // RVA: 0x7B191F190
        public void checkHeaderType(){} // RVA: 0x7B191F240
        public void checkName(){} // RVA: 0x7B191F2D0
        public void checkRestricted(){} // RVA: 0x7B191F440
        public void checkState(){} // RVA: 0x7B191F540
        public void checkValue(){} // RVA: 0x7B191F600
        public void doWithCheckingState(){} // RVA: 0x7B191F9D0
        public void doWithoutCheckingName(){} // RVA: 0x7B191FAE0
        public void getHeaderInfo(){} // RVA: 0x7B191FB90
        public void isRestricted(){} // RVA: 0x7B191FEC0
        public void removeWithoutCheckingName(){} // RVA: 0x7B191FF40
        public void setWithoutCheckingName(){} // RVA: 0x7B191FF80
        public void InternalSet(){} // RVA: 0x7B1920290
        public void IsHeaderName(){} // RVA: 0x7B19203B0
        public void IsHeaderValue(){} // RVA: 0x7B1920420
        public void IsMultiValue(){} // RVA: 0x7B1920470
        public void Add(){} // RVA: 0x7B1920530
        public void Get(){} // RVA: 0x7AEAA5D30
        public void GetEnumerator(){} // RVA: 0x7AEAAC270
        public void GetKey(){} // RVA: 0x7B1920620
        public void GetValues(){} // RVA: 0x7B19206D0
        public void GetObjectData(){} // RVA: 0x7B1920780
        public void OnDeserialization(){} // RVA: 0x7A80D7310
        public void Remove(){} // RVA: 0x7B1920A20
        public void Set(){} // RVA: 0x7B1920AF0
        public void ToString(){} // RVA: 0x7B1920BD0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE916330
    }

}