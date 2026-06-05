// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 49

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7FFAF95F82A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DigestClient
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAF95FA480
        public void CheckExpired(){} // RVA: 0x7FFAF95FA6A0
        public void Authenticate(){} // RVA: 0x7FFAF95FAE50
        public void PreAuthenticate(){} // RVA: 0x7FFAF95FB1D0
        public void get_AuthenticationType(){} // RVA: 0x7FFAF95FB3A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF95FB3E0
    }

    public class DigestHeaderParser
    {
        public object Algorithm;
        public object Realm;
        public object Nonce;
        public object Opaque;
        public object QOP;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F8310
        public void get_Realm(){} // RVA: 0x7FFAF886E990
        public void get_Opaque(){} // RVA: 0x7FFAF886E9C0
        public void get_Nonce(){} // RVA: 0x7FFAF886E9F0
        public void get_Algorithm(){} // RVA: 0x7FFAF886EA20
        public void get_QOP(){} // RVA: 0x7FFAF886EA50
        public void Parse(){} // RVA: 0x7FFAF95F8460
        public void SkipWhitespace(){} // RVA: 0x7FFAF95F86D0
        public void GetKey(){} // RVA: 0x7FFAF95F8750
        public void GetKeywordAndValue(){} // RVA: 0x7FFAF95F8800
        public void .cctor(){} // RVA: 0x7FFAF95F8B30
    }

    public class DigestSession
    {
        public object Cache;
        public object AuthenticationType;
        public object .ctor;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF95F8CB0
        public void .ctor(){} // RVA: 0x7FFAF95F8D50
        public void get_Algorithm(){} // RVA: 0x7FFAF95F8DB0
        public void get_Realm(){} // RVA: 0x7FFAF95F8DF0
        public void get_Nonce(){} // RVA: 0x7FFAF95F8E30
        public void get_Opaque(){} // RVA: 0x7FFAF95F8E70
        public void get_QOP(){} // RVA: 0x7FFAF95F8EB0
        public void get_CNonce(){} // RVA: 0x7FFAF95F8EF0
        public void Parse(){} // RVA: 0x7FFAF95F9100
        public void HashToHexString(){} // RVA: 0x7FFAF95F9440
        public void HA1(){} // RVA: 0x7FFAF95F9730
        public void HA2(){} // RVA: 0x7FFAF95F9970
        public void Response(){} // RVA: 0x7FFAF95F9AA0
        public void Authenticate(){} // RVA: 0x7FFAF95F9DA0
        public void get_LastUse(){} // RVA: 0x7FFAF2DA8380
    }

    public class Dns
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x7FFAF95FB4B0
        public void EndGetHostAddresses(){} // RVA: 0x7FFAF95FB760
        public void GetHostByName_icall(){} // RVA: 0x7FFAF95FB890
        public void GetHostByAddr_icall(){} // RVA: 0x7FFAF95FB8A0
        public void GetHostName_icall(){} // RVA: 0x7FFAF95FB8B0
        public void Error_11001(){} // RVA: 0x7FFAF95FB9F0
        public void hostent_to_IPHostEntry(){} // RVA: 0x7FFAF95FBA60
        public void GetHostByAddressFromString(){} // RVA: 0x7FFAF95FBE50
        public void GetHostEntry(){} // RVA: 0x7FFAF95FC2D0 | overloaded x2
        public void GetHostAddresses(){} // RVA: 0x7FFAF95FC350
        public void GetHostByName(){} // RVA: 0x7FFAF95FC6B0
        public void GetHostName(){} // RVA: 0x7FFAF95FC7B0
        public void GetHostAddressesAsync(){} // RVA: 0x7FFAF95FC910
    }

}