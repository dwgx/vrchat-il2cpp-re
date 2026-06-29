// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 48

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy : Object
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x75AB4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DigestClient : Object
    {
        public object cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x75AD670
        public void CheckExpired(){} // RVA: 0x75AD860
        public void Authenticate(){} // RVA: 0x75ADFC0
        public void PreAuthenticate(){} // RVA: 0x75AE330
        public void get_AuthenticationType(){} // RVA: 0x75AE4E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x75AE520
    }

    public class DigestHeaderParser : Object
    {
        public object header;
        public object length;
        public object pos;
        public object keywords;
        public object values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75AB530
        public void get_Realm(){} // RVA: 0x6837EB0
        public void get_Opaque(){} // RVA: 0x6837EE0
        public void get_Nonce(){} // RVA: 0x6837F10
        public void get_Algorithm(){} // RVA: 0x6837F40
        public void get_QOP(){} // RVA: 0x6837F70
        public void Parse(){} // RVA: 0x75AB680
        public void SkipWhitespace(){} // RVA: 0x75AB8F0
        public void GetKey(){} // RVA: 0x75AB970
        public void GetKeywordAndValue(){} // RVA: 0x75ABA20
        public void .cctor(){} // RVA: 0x75ABD60
    }

    public class DigestSession : Object
    {
        public object rng;
        public object lastUse;
        public object _nc;
        public object hash;
        public object parser;
        public object _cnonce;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75ABEE0
        public void .ctor(){} // RVA: 0x75ABF80
        public void get_Algorithm(){} // RVA: 0x75ABFE0
        public void get_Realm(){} // RVA: 0x75AC020
        public void get_Nonce(){} // RVA: 0x75AC060
        public void get_Opaque(){} // RVA: 0x75AC0A0
        public void get_QOP(){} // RVA: 0x75AC0E0
        public void get_CNonce(){} // RVA: 0x75AC120
        public void Parse(){} // RVA: 0x75AC330
        public void HashToHexString(){} // RVA: 0x75AC670
        public void HA1(){} // RVA: 0x75AC970
        public void HA2(){} // RVA: 0x75ACBB0
        public void Response(){} // RVA: 0x75ACCE0
        public void Authenticate(){} // RVA: 0x75ACFE0
        public void get_LastUse(){} // RVA: 0xB5DBF0
    }

    public class Dns : Object
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x75AE5F0
        public void EndGetHostAddresses(){} // RVA: 0x75AE890
        public void GetHostByName_icall(){} // RVA: 0x75AE9C0
        public void GetHostByAddr_icall(){} // RVA: 0x75AE9D0
        public void GetHostName_icall(){} // RVA: 0x75AE9E0
        public void Error_11001(){} // RVA: 0x75AE9F0
        public void hostent_to_IPHostEntry(){} // RVA: 0x75AEA60
        public void GetHostByAddressFromString(){} // RVA: 0x75AEE70
        public void GetHostEntry(){} // RVA: 0x75AF2F0
        public void GetHostAddresses(){} // RVA: 0x75AF370
        public void GetHostByName(){} // RVA: 0x75AF6D0
        public void GetHostName(){} // RVA: 0x75AF7D0
        public void GetHostAddressesAsync(){} // RVA: 0x75AF810
    }

}