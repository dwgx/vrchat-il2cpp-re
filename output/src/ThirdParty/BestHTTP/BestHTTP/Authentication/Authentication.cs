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
        public void get_Type(){} // RVA: 0x32A5C0
        public void set_Type(){} // RVA: 0x2E00C0
        public void get_UserName(){} // RVA: 0x2E07C0
        public void set_UserName(){} // RVA: 0x343E80
        public void get_Password(){} // RVA: 0x30B0C0
        public void set_Password(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2E766D0 | overloaded x2
    }

    public class Digest
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x2F8380
        public void set_Uri(){} // RVA: 0x2DEE30
        public void get_Type(){} // RVA: 0x5BED50
        public void set_Type(){} // RVA: 0x6374E0
        public void get_Realm(){} // RVA: 0x30B0C0
        public void set_Realm(){} // RVA: 0x30B0D0
        public void get_Stale(){} // RVA: 0x6E8A80
        public void set_Stale(){} // RVA: 0x6E8B80
        public void get_Nonce(){} // RVA: 0x6374D0
        public void set_Nonce(){} // RVA: 0x30B890
        public void get_Opaque(){} // RVA: 0x4976A0
        public void set_Opaque(){} // RVA: 0x49B830
        public void get_Algorithm(){} // RVA: 0x35A740
        public void set_Algorithm(){} // RVA: 0x305200
        public void get_ProtectedUris(){} // RVA: 0x358730
        public void set_ProtectedUris(){} // RVA: 0x358740
        public void get_QualityOfProtections(){} // RVA: 0x37E0E0
        public void set_QualityOfProtections(){} // RVA: 0x4354D0
        public void get_NonceCount(){} // RVA: 0x9EAB90
        public void set_NonceCount(){} // RVA: 0x9EAAE0
        public void get_HA1Sess(){} // RVA: 0x37B370
        public void set_HA1Sess(){} // RVA: 0x37B380
        public void .ctor(){} // RVA: 0x9839180
        public void ParseChallange(){} // RVA: 0x9839280
        public void GenerateResponseHeader(){} // RVA: 0x9839B30
        public void IsUriProtected(){} // RVA: 0x983ADC0
    }

    public class DigestStore
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x983AF30
        public void GetOrCreate(){} // RVA: 0x983B170
        public void Remove(){} // RVA: 0x983B5F0
        public void FindBest(){} // RVA: 0x983B750
        public void .cctor(){} // RVA: 0x983BA20
    }

}