// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 49

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x6B482A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DigestClient
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x6B4A480
        public void CheckExpired(){} // RVA: 0x6B4A6A0
        public void Authenticate(){} // RVA: 0x6B4AE50
        public void PreAuthenticate(){} // RVA: 0x6B4B1D0
        public void get_AuthenticationType(){} // RVA: 0x6B4B3A0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6B4B3E0
    }

    public class DigestHeaderParser
    {
        public object Algorithm;
        public object Realm;
        public object Nonce;
        public object Opaque;
        public object QOP;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B48310
        public void get_Realm(){} // RVA: 0x5DBE990
        public void get_Opaque(){} // RVA: 0x5DBE9C0
        public void get_Nonce(){} // RVA: 0x5DBE9F0
        public void get_Algorithm(){} // RVA: 0x5DBEA20
        public void get_QOP(){} // RVA: 0x5DBEA50
        public void Parse(){} // RVA: 0x6B48460
        public void SkipWhitespace(){} // RVA: 0x6B486D0
        public void GetKey(){} // RVA: 0x6B48750
        public void GetKeywordAndValue(){} // RVA: 0x6B48800
        public void .cctor(){} // RVA: 0x6B48B30
    }

    public class DigestSession
    {
        public object Cache;
        public object AuthenticationType;
        public object .ctor;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6B48CB0
        public void .ctor(){} // RVA: 0x6B48D50
        public void get_Algorithm(){} // RVA: 0x6B48DB0
        public void get_Realm(){} // RVA: 0x6B48DF0
        public void get_Nonce(){} // RVA: 0x6B48E30
        public void get_Opaque(){} // RVA: 0x6B48E70
        public void get_QOP(){} // RVA: 0x6B48EB0
        public void get_CNonce(){} // RVA: 0x6B48EF0
        public void Parse(){} // RVA: 0x6B49100
        public void HashToHexString(){} // RVA: 0x6B49440
        public void HA1(){} // RVA: 0x6B49730
        public void HA2(){} // RVA: 0x6B49970
        public void Response(){} // RVA: 0x6B49AA0
        public void Authenticate(){} // RVA: 0x6B49DA0
        public void get_LastUse(){} // RVA: 0x2F8380
    }

    public class Dns
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x6B4B4B0
        public void EndGetHostAddresses(){} // RVA: 0x6B4B760
        public void GetHostByName_icall(){} // RVA: 0x6B4B890
        public void GetHostByAddr_icall(){} // RVA: 0x6B4B8A0
        public void GetHostName_icall(){} // RVA: 0x6B4B8B0
        public void Error_11001(){} // RVA: 0x6B4B9F0
        public void hostent_to_IPHostEntry(){} // RVA: 0x6B4BA60
        public void GetHostByAddressFromString(){} // RVA: 0x6B4BE50
        public void GetHostEntry(){} // RVA: 0x6B4C2D0 | overloaded x2
        public void GetHostAddresses(){} // RVA: 0x6B4C350
        public void GetHostByName(){} // RVA: 0x6B4C6B0
        public void GetHostName(){} // RVA: 0x6B4C7B0
        public void GetHostAddressesAsync(){} // RVA: 0x6B4C910
    }

}