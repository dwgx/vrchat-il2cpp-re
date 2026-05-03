// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Authentication
// Classes: 3
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Authentication
{
    public class Credentials : Object
    {
        public 0x664A3B7C _type; // 0x10
        public string _userName; // 0x18
        public string _password; // 0x20

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void set_Type(){} // RVA: 0x7FFE810FE0C0
        public void get_UserName(){} // RVA: 0x7FFE810FE7C0
        public void set_UserName(){} // RVA: 0x7FFE81161E80
        public void get_Password(){} // RVA: 0x7FFE811290C0
        public void set_Password(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE83B45810 | overloaded x2
    }

    public class Digest : Object
    {
        public System.Uri _uri; // 0x10
        public 0x664A3B7C _type; // 0x18
        public string _realm; // 0x20
        public bool _stale; // 0x28
        public string _nonce; // 0x30
        public string _opaque; // 0x38
        public string _algorithm; // 0x40
        public System.Collections.Generic.List`1<string> _protectedUris; // 0x48
        public string _qualityOfProtections; // 0x50
        public int _nonceCount; // 0x58
        public string _hA1Sess; // 0x60

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFE81116380
        public void set_Uri(){} // RVA: 0x7FFE810FCE30
        public void get_Type(){} // RVA: 0x7FFE813DB630
        public void set_Type(){} // RVA: 0x7FFE8144DF00
        public void get_Realm(){} // RVA: 0x7FFE811290C0
        public void set_Realm(){} // RVA: 0x7FFE811290D0
        public void get_Stale(){} // RVA: 0x7FFE815F1380
        public void set_Stale(){} // RVA: 0x7FFE81C15740
        public void get_Nonce(){} // RVA: 0x7FFE8144E200
        public void set_Nonce(){} // RVA: 0x7FFE81129890
        public void get_Opaque(){} // RVA: 0x7FFE8143BA80
        public void set_Opaque(){} // RVA: 0x7FFE81437330
        public void get_Algorithm(){} // RVA: 0x7FFE81178740
        public void set_Algorithm(){} // RVA: 0x7FFE81123200
        public void get_ProtectedUris(){} // RVA: 0x7FFE81176730
        public void set_ProtectedUris(){} // RVA: 0x7FFE81176740
        public void get_QualityOfProtections(){} // RVA: 0x7FFE8119C0E0
        public void set_QualityOfProtections(){} // RVA: 0x7FFE812534D0
        public void get_NonceCount(){} // RVA: 0x7FFE8175AC90
        public void set_NonceCount(){} // RVA: 0x7FFE8175AE70
        public void get_HA1Sess(){} // RVA: 0x7FFE81199370
        public void set_HA1Sess(){} // RVA: 0x7FFE81199380
        public void .ctor(){} // RVA: 0x7FFE8A29B4C0
        public void ParseChallange(){} // RVA: 0x7FFE8A29B5C0
        public void GenerateResponseHeader(){} // RVA: 0x7FFE8A29BE70
        public void IsUriProtected(){} // RVA: 0x7FFE8A29D100
    }

    public class DigestStore : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE8A29D270
        public void GetOrCreate(){} // RVA: 0x7FFE8A29D4B0
        public void Remove(){} // RVA: 0x7FFE8A29D930
        public void FindBest(){} // RVA: 0x7FFE8A29DA90
        public void .cctor(){} // RVA: 0x7FFE8A29DD60
    }

}