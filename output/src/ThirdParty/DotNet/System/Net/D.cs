// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 5
// Methods: 49

namespace ThirdParty.DotNet.System.Net
{
    public class DefaultCertificatePolicy : Object
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7FFE87687550
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DigestClient : Object
    {
        public System.Collections.Hashtable cache;
        public object field_1; // 0x4CB

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE87689730
        public void CheckExpired(){} // RVA: 0x7FFE87689950
        public void Authenticate(){} // RVA: 0x7FFE8768A100
        public void PreAuthenticate(){} // RVA: 0x7FFE8768A480
        public void get_AuthenticationType(){} // RVA: 0x7FFE8768A650
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8768A690
    }

    public class DigestHeaderParser : Object
    {
        public string header; // 0x10
        public int length; // 0x18
        public int pos; // 0x1C
        public string[] keywords;
        public string[] values; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876875C0
        public void get_Realm(){} // RVA: 0x7FFE868FF820
        public void get_Opaque(){} // RVA: 0x7FFE868FF850
        public void get_Nonce(){} // RVA: 0x7FFE868FF880
        public void get_Algorithm(){} // RVA: 0x7FFE868FF8B0
        public void get_QOP(){} // RVA: 0x7FFE868FF8E0
        public void Parse(){} // RVA: 0x7FFE87687710
        public void SkipWhitespace(){} // RVA: 0x7FFE87687980
        public void GetKey(){} // RVA: 0x7FFE87687A00
        public void GetKeywordAndValue(){} // RVA: 0x7FFE87687AB0
        public void .cctor(){} // RVA: 0x7FFE87687DE0
    }

    public class DigestSession : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator rng;
        public System.DateTime lastUse; // 0x10
        public int _nc; // 0x18
        public System.Security.Cryptography.HashAlgorithm hash; // 0x20
        public System.Net.DigestHeaderParser parser; // 0x28
        public string _cnonce; // 0x30
        public object field_6; // 0x4C4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87687F60
        public void .ctor(){} // RVA: 0x7FFE87688000
        public void get_Algorithm(){} // RVA: 0x7FFE87688060
        public void get_Realm(){} // RVA: 0x7FFE876880A0
        public void get_Nonce(){} // RVA: 0x7FFE876880E0
        public void get_Opaque(){} // RVA: 0x7FFE87688120
        public void get_QOP(){} // RVA: 0x7FFE87688160
        public void get_CNonce(){} // RVA: 0x7FFE876881A0
        public void Parse(){} // RVA: 0x7FFE876883B0
        public void HashToHexString(){} // RVA: 0x7FFE876886F0
        public void HA1(){} // RVA: 0x7FFE876889E0
        public void HA2(){} // RVA: 0x7FFE87688C20
        public void Response(){} // RVA: 0x7FFE87688D50
        public void Authenticate(){} // RVA: 0x7FFE87689050
        public void get_LastUse(){} // RVA: 0x7FFE81116380
    }

    public class Dns : Object
    {
        // ── Methods ──
        public void BeginGetHostAddresses(){} // RVA: 0x7FFE8768A760
        public void EndGetHostAddresses(){} // RVA: 0x7FFE8768AA10
        public void GetHostByName_icall(){} // RVA: 0x7FFE8768AB40
        public void GetHostByAddr_icall(){} // RVA: 0x7FFE8768AB50
        public void GetHostName_icall(){} // RVA: 0x7FFE8768AB60
        public void Error_11001(){} // RVA: 0x7FFE8768ACA0
        public void hostent_to_IPHostEntry(){} // RVA: 0x7FFE8768AD10
        public void GetHostByAddressFromString(){} // RVA: 0x7FFE8768B100
        public void GetHostEntry(){} // RVA: 0x7FFE8768B580 | overloaded x2
        public void GetHostAddresses(){} // RVA: 0x7FFE8768B600
        public void GetHostByName(){} // RVA: 0x7FFE8768B960
        public void GetHostName(){} // RVA: 0x7FFE8768BA60
        public void GetHostAddressesAsync(){} // RVA: 0x7FFE8768BBC0
    }

}