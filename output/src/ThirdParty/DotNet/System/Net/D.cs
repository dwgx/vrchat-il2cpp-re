// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 49

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy : Object
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7FFAC92DEE20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DigestClient : Object
    {
        public System.Collections.Hashtable Cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC92E1000
        public void CheckExpired(){} // RVA: 0x7FFAC92E1220
        public void Authenticate(){} // RVA: 0x7FFAC92E19D0
        public void PreAuthenticate(){} // RVA: 0x7FFAC92E1D50
        public void get_AuthenticationType(){} // RVA: 0x7FFAC92E1F20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC92E1F60
    }

    public class DigestHeaderParser : Object
    {
        public string Realm; // 0x10
        public int Opaque; // 0x18
        public int Nonce; // 0x1C
        public string[] Algorithm;
        public string[] QOP; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92DEE90
        public void get_Realm(){} // RVA: 0x7FFAC8555FF0
        public void get_Opaque(){} // RVA: 0x7FFAC8556020
        public void get_Nonce(){} // RVA: 0x7FFAC8556050
        public void get_Algorithm(){} // RVA: 0x7FFAC8556080
        public void get_QOP(){} // RVA: 0x7FFAC85560B0
        public void Parse(){} // RVA: 0x7FFAC92DEFE0
        public void SkipWhitespace(){} // RVA: 0x7FFAC92DF250
        public void GetKey(){} // RVA: 0x7FFAC92DF2D0
        public void GetKeywordAndValue(){} // RVA: 0x7FFAC92DF380
        public void .cctor(){} // RVA: 0x7FFAC92DF6B0
    }

    public class DigestSession : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator Algorithm;
        public System.DateTime Realm; // 0x10
        public int Nonce; // 0x18
        public System.Security.Cryptography.HashAlgorithm Opaque; // 0x20
        public System.Net.DigestHeaderParser QOP; // 0x28
        public string CNonce; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC92DF830
        public void .ctor(){} // RVA: 0x7FFAC92DF8D0
        public void get_Algorithm(){} // RVA: 0x7FFAC92DF930
        public void get_Realm(){} // RVA: 0x7FFAC92DF970
        public void get_Nonce(){} // RVA: 0x7FFAC92DF9B0
        public void get_Opaque(){} // RVA: 0x7FFAC92DF9F0
        public void get_QOP(){} // RVA: 0x7FFAC92DFA30
        public void get_CNonce(){} // RVA: 0x7FFAC92DFA70
        public void Parse(){} // RVA: 0x7FFAC92DFC80
        public void HashToHexString(){} // RVA: 0x7FFAC92DFFC0
        public void HA1(){} // RVA: 0x7FFAC92E02B0
        public void HA2(){} // RVA: 0x7FFAC92E04F0
        public void Response(){} // RVA: 0x7FFAC92E0620
        public void Authenticate(){} // RVA: 0x7FFAC92E0920
        public void get_LastUse(){} // RVA: 0x7FFAC2F3C380
    }

    public class Dns : Object
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x7FFAC92E2030
        public void EndGetHostAddresses(){} // RVA: 0x7FFAC92E22E0
        public void GetHostByName_icall(){} // RVA: 0x7FFAC92E2410
        public void GetHostByAddr_icall(){} // RVA: 0x7FFAC92E2420
        public void GetHostName_icall(){} // RVA: 0x7FFAC92E2430
        public void Error_11001(){} // RVA: 0x7FFAC92E2570
        public void hostent_to_IPHostEntry(){} // RVA: 0x7FFAC92E25E0
        public void GetHostByAddressFromString(){} // RVA: 0x7FFAC92E29D0
        public void GetHostEntry(){} // RVA: 0x7FFAC92E2E50 | overloaded x2
        public void GetHostAddresses(){} // RVA: 0x7FFAC92E2ED0
        public void GetHostByName(){} // RVA: 0x7FFAC92E3230
        public void GetHostName(){} // RVA: 0x7FFAC92E3330
        public void GetHostAddressesAsync(){} // RVA: 0x7FFAC92E3490
    }

}