// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Authentication
// Classes: 3
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Authentication
{
    public class Credentials
    {
        public object Uri;
        public object Type;
        public object Realm;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Type(){} // RVA: 0x7FFAF2D900C0
        public void get_UserName(){} // RVA: 0x7FFAF2D907C0
        public void set_UserName(){} // RVA: 0x7FFAF2DF3E80
        public void get_Password(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Password(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF59266D0 | overloaded x2
    }

    public class Digest
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void set_Uri(){} // RVA: 0x7FFAF2D8EE30
        public void get_Type(){} // RVA: 0x7FFAF306ED50
        public void set_Type(){} // RVA: 0x7FFAF30E74E0
        public void get_Realm(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Realm(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Stale(){} // RVA: 0x7FFAF3198A80
        public void set_Stale(){} // RVA: 0x7FFAF3198B80
        public void get_Nonce(){} // RVA: 0x7FFAF30E74D0
        public void set_Nonce(){} // RVA: 0x7FFAF2DBB890
        public void get_Opaque(){} // RVA: 0x7FFAF2F476A0
        public void set_Opaque(){} // RVA: 0x7FFAF2F4B830
        public void get_Algorithm(){} // RVA: 0x7FFAF2E0A740
        public void set_Algorithm(){} // RVA: 0x7FFAF2DB5200
        public void get_ProtectedUris(){} // RVA: 0x7FFAF2E08730
        public void set_ProtectedUris(){} // RVA: 0x7FFAF2E08740
        public void get_QualityOfProtections(){} // RVA: 0x7FFAF2E2E0E0
        public void set_QualityOfProtections(){} // RVA: 0x7FFAF2EE54D0
        public void get_NonceCount(){} // RVA: 0x7FFAF349AB90
        public void set_NonceCount(){} // RVA: 0x7FFAF349AAE0
        public void get_HA1Sess(){} // RVA: 0x7FFAF2E2B370
        public void set_HA1Sess(){} // RVA: 0x7FFAF2E2B380
        public void .ctor(){} // RVA: 0x7FFAFC2E9180
        public void ParseChallange(){} // RVA: 0x7FFAFC2E9280
        public void GenerateResponseHeader(){} // RVA: 0x7FFAFC2E9B30
        public void IsUriProtected(){} // RVA: 0x7FFAFC2EADC0
    }

    public class DigestStore
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAFC2EAF30
        public void GetOrCreate(){} // RVA: 0x7FFAFC2EB170
        public void Remove(){} // RVA: 0x7FFAFC2EB5F0
        public void FindBest(){} // RVA: 0x7FFAFC2EB750
        public void .cctor(){} // RVA: 0x7FFAFC2EBA20
    }

}