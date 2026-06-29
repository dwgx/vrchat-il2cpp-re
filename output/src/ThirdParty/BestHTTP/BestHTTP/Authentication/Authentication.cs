// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Authentication
// Classes: 3
// Methods: 38

namespace ThirdParty.BestHTTP.BestHTTP.Authentication
{
    public class Credentials : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A8124910
        public void set_Type(){} // RVA: 0x7A80DA0C0
        public void get_UserName(){} // RVA: 0x7A80DA7B0
        public void set_UserName(){} // RVA: 0x7A813E420
        public void get_Password(){} // RVA: 0x7A81052C0
        public void set_Password(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AAC6DFD0
    }

    public class Digest : Object
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7A80F2570
        public void set_Uri(){} // RVA: 0x7A80D8E20
        public void get_Type(){} // RVA: 0x7A83782A0
        public void set_Type(){} // RVA: 0x7A84385B0
        public void get_Realm(){} // RVA: 0x7A81052C0
        public void set_Realm(){} // RVA: 0x7A81052D0
        public void get_Stale(){} // RVA: 0x7A84A5BD0
        public void set_Stale(){} // RVA: 0x7A84A5CD0
        public void get_Nonce(){} // RVA: 0x7A83F69F0
        public void set_Nonce(){} // RVA: 0x7A8105A90
        public void get_Opaque(){} // RVA: 0x7A8292C30
        public void set_Opaque(){} // RVA: 0x7A8296DE0
        public void get_Algorithm(){} // RVA: 0x7A8154D80
        public void set_Algorithm(){} // RVA: 0x7A80FF440
        public void get_ProtectedUris(){} // RVA: 0x7A8152D80
        public void set_ProtectedUris(){} // RVA: 0x7A8152D90
        public void get_QualityOfProtections(){} // RVA: 0x7A8178B90
        public void set_QualityOfProtections(){} // RVA: 0x7A8230620
        public void get_NonceCount(){} // RVA: 0x7A87A7DA0
        public void set_NonceCount(){} // RVA: 0x7A87A7CF0
        public void get_HA1Sess(){} // RVA: 0x7A8175DF0
        public void set_HA1Sess(){} // RVA: 0x7A8175E00
        public void .ctor(){} // RVA: 0x7B1673BE0
        public void ParseChallange(){} // RVA: 0x7B1673CE0
        public void GenerateResponseHeader(){} // RVA: 0x7B16745A0
        public void IsUriProtected(){} // RVA: 0x7B1675880
    }

    public class DigestStore : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7B16759F0
        public void GetOrCreate(){} // RVA: 0x7B1675C40
        public void Remove(){} // RVA: 0x7B16760D0
        public void FindBest(){} // RVA: 0x7B1676230
        public void .cctor(){} // RVA: 0x7B1676520
    }

}