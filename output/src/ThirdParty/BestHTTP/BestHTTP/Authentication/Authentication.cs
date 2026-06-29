// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Authentication
// Classes: 3
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.Authentication
{
    public class Credentials : Object
    {
        public object _type;
        public object _userName;
        public object _password;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB8F8F0
        public void set_Type(){} // RVA: 0xB460A0
        public void get_UserName(){} // RVA: 0xB465B0
        public void set_UserName(){} // RVA: 0xBA9BA0
        public void get_Password(){} // RVA: 0xB700F0
        public void set_Password(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x38BA2E0
    }

    public class Digest : Object
    {
        public object _uri;
        public object _type;
        public object _realm;
        public object _stale;
        public object _nonce;
        public object _opaque;
        public object _algorithm;
        public object _protectedUris;
        public object _qualityOfProtections;
        public object _nonceCount;
        public object _hA1Sess;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0xB5DBF0
        public void set_Uri(){} // RVA: 0xB44D60
        public void get_Type(){} // RVA: 0xE62D00
        public void set_Type(){} // RVA: 0x1033F40
        public void get_Realm(){} // RVA: 0xB700F0
        public void set_Realm(){} // RVA: 0xB70100
        public void get_Stale(){} // RVA: 0xF73960
        public void set_Stale(){} // RVA: 0xF73A60
        public void get_Nonce(){} // RVA: 0xD33E60
        public void set_Nonce(){} // RVA: 0xB708C0
        public void get_Opaque(){} // RVA: 0xD05CA0
        public void set_Opaque(){} // RVA: 0xD09D70
        public void get_Algorithm(){} // RVA: 0xBC1B30
        public void set_Algorithm(){} // RVA: 0xB6A8C0
        public void get_ProtectedUris(){} // RVA: 0xBBF8F0
        public void set_ProtectedUris(){} // RVA: 0xBBF900
        public void get_QualityOfProtections(){} // RVA: 0xBE58B0
        public void set_QualityOfProtections(){} // RVA: 0xCA4DF0
        public void get_NonceCount(){} // RVA: 0x12BB630
        public void set_NonceCount(){} // RVA: 0x12BB640
        public void get_HA1Sess(){} // RVA: 0xBE2C60
        public void set_HA1Sess(){} // RVA: 0xBE2C70
        public void .ctor(){} // RVA: 0xA4DEE70
        public void ParseChallange(){} // RVA: 0xA4DEF70
        public void GenerateResponseHeader(){} // RVA: 0xA4DF820
        public void IsUriProtected(){} // RVA: 0xA4E0AF0
    }

    public class DigestStore : Object
    {
        public object Digests;
        public object rwLock;
        public object SupportedAlgorithms;

        // ── Methods ──
        public void Get(){} // RVA: 0xA4E0C60
        public void GetOrCreate(){} // RVA: 0xA4E0EB0
        public void Remove(){} // RVA: 0xA4E1340
        public void FindBest(){} // RVA: 0xA4E14A0
        public void .cctor(){} // RVA: 0xA4E1780
    }

}