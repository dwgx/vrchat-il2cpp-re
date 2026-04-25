// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Authentication
// Classes: 3
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Authentication
{
    public class Credentials : Object
    {
        public 0x6B0AB3E8 Type; // 0x10
        public string UserName; // 0x18
        public string Password; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Type(){} // RVA: 0x7FFAC2F240C0
        public void get_UserName(){} // RVA: 0x7FFAC2F247C0
        public void set_UserName(){} // RVA: 0x7FFAC2F87E80
        public void get_Password(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Password(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC5808D30 | overloaded x2
    }

    public class Digest : Object
    {
        public System.Uri Uri; // 0x10
        public 0x6B0AB3E8 Type; // 0x18
        public string Realm; // 0x20
        public bool Stale; // 0x28
        public string Nonce; // 0x30
        public string Opaque; // 0x38
        public string Algorithm; // 0x40
        public System.Collections.Generic.List`1<string> ProtectedUris; // 0x48
        public string QualityOfProtections; // 0x50
        public int NonceCount; // 0x58
        public string HA1Sess; // 0x60

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void set_Uri(){} // RVA: 0x7FFAC2F22E30
        public void get_Type(){} // RVA: 0x7FFAC3157800
        public void set_Type(){} // RVA: 0x7FFAC392CD10
        public void get_Realm(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Realm(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Stale(){} // RVA: 0x7FFAC30F6BA0
        public void set_Stale(){} // RVA: 0x7FFAC3C24F40
        public void get_Nonce(){} // RVA: 0x7FFAC31D95E0
        public void set_Nonce(){} // RVA: 0x7FFAC2F4F890
        public void get_Opaque(){} // RVA: 0x7FFAC31D0140
        public void set_Opaque(){} // RVA: 0x7FFAC31D0C20
        public void get_Algorithm(){} // RVA: 0x7FFAC2F9E740
        public void set_Algorithm(){} // RVA: 0x7FFAC2F49200
        public void get_ProtectedUris(){} // RVA: 0x7FFAC2F9C730
        public void set_ProtectedUris(){} // RVA: 0x7FFAC2F9C740
        public void get_QualityOfProtections(){} // RVA: 0x7FFAC2FC20E0
        public void set_QualityOfProtections(){} // RVA: 0x7FFAC30794D0
        public void get_NonceCount(){} // RVA: 0x7FFAC362EA40
        public void set_NonceCount(){} // RVA: 0x7FFAC362EA00
        public void get_HA1Sess(){} // RVA: 0x7FFAC2FBF370
        public void set_HA1Sess(){} // RVA: 0x7FFAC2FBF380
        public void .ctor(){} // RVA: 0x7FFACBE41EA0
        public void ParseChallange(){} // RVA: 0x7FFACBE41FA0
        public void GenerateResponseHeader(){} // RVA: 0x7FFACBE42850
        public void IsUriProtected(){} // RVA: 0x7FFACBE43AE0
    }

    public class DigestStore : Object
    {
        public System.Collections.Generic.Dictionary`2<string,BestHTTP.Authentication.Digest> Digests;
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x8
        public string[] SupportedAlgorithms; // 0x10

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFACBE43C50
        public void GetOrCreate(){} // RVA: 0x7FFACBE43E90
        public void Remove(){} // RVA: 0x7FFACBE44310
        public void FindBest(){} // RVA: 0x7FFACBE44470
        public void .cctor(){} // RVA: 0x7FFACBE44740
    }

}