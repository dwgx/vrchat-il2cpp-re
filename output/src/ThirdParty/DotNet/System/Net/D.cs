// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 48

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy : Object
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7AE9383E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DigestClient : Object
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7AE93A5A0
        public void CheckExpired(){} // RVA: 0x7AE93A790
        public void Authenticate(){} // RVA: 0x7AE93AF00
        public void PreAuthenticate(){} // RVA: 0x7AE93B280
        public void get_AuthenticationType(){} // RVA: 0x7AE93B440
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE93B480
    }

    public class DigestHeaderParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE938450
        public void get_Realm(){} // RVA: 0x7ADBACF90
        public void get_Opaque(){} // RVA: 0x7ADBACFC0
        public void get_Nonce(){} // RVA: 0x7ADBACFF0
        public void get_Algorithm(){} // RVA: 0x7ADBAD020
        public void get_QOP(){} // RVA: 0x7ADBAD050
        public void Parse(){} // RVA: 0x7AE9385A0
        public void SkipWhitespace(){} // RVA: 0x7AE938810
        public void GetKey(){} // RVA: 0x7AE938890
        public void GetKeywordAndValue(){} // RVA: 0x7AE938940
        public void .cctor(){} // RVA: 0x7AE938C80
    }

    public class DigestSession : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE938E00
        public void .ctor(){} // RVA: 0x7AE938EA0
        public void get_Algorithm(){} // RVA: 0x7AE938F00
        public void get_Realm(){} // RVA: 0x7AE938F40
        public void get_Nonce(){} // RVA: 0x7AE938F80
        public void get_Opaque(){} // RVA: 0x7AE938FC0
        public void get_QOP(){} // RVA: 0x7AE939000
        public void get_CNonce(){} // RVA: 0x7AE939040
        public void Parse(){} // RVA: 0x7AE939250
        public void HashToHexString(){} // RVA: 0x7AE939590
        public void HA1(){} // RVA: 0x7AE939890
        public void HA2(){} // RVA: 0x7AE939AD0
        public void Response(){} // RVA: 0x7AE939C00
        public void Authenticate(){} // RVA: 0x7AE939F00
        public void get_LastUse(){} // RVA: 0x7A80F2570
    }

    public class Dns : Object
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x7AE93B550
        public void EndGetHostAddresses(){} // RVA: 0x7AE93B7F0
        public void GetHostByName_icall(){} // RVA: 0x7AE93B920
        public void GetHostByAddr_icall(){} // RVA: 0x7AE93B930
        public void GetHostName_icall(){} // RVA: 0x7AE93B940
        public void Error_11001(){} // RVA: 0x7AE93B950
        public void hostent_to_IPHostEntry(){} // RVA: 0x7AE93B9C0
        public void GetHostByAddressFromString(){} // RVA: 0x7AE93BDD0
        public void GetHostEntry(){} // RVA: 0x7AE93C250
        public void GetHostAddresses(){} // RVA: 0x7AE93C2D0
        public void GetHostByName(){} // RVA: 0x7AE93C630
        public void GetHostName(){} // RVA: 0x7AE93C730
        public void GetHostAddressesAsync(){} // RVA: 0x7AE93C770
    }

}