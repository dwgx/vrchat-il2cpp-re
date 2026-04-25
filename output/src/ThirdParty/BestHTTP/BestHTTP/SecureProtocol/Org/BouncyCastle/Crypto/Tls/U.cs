// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class UrlAndHash : Object
    {
        public string Url; // 0x10
        public byte[] Sha1Hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB6DA90
        public void get_Url(){} // RVA: 0x7FFAC2F3C380
        public void get_Sha1Hash(){} // RVA: 0x7FFAC2F247C0
        public void Encode(){} // RVA: 0x7FFACBB6DBA0
        public void Parse(){} // RVA: 0x7FFACBB6DCD0
    }

    public class UseSrtpData : Object
    {
        public int[] ProtectionProfiles; // 0x10
        public byte[] Mki; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB6E010
        public void get_ProtectionProfiles(){} // RVA: 0x7FFAC2F3C380
        public void get_Mki(){} // RVA: 0x7FFAC2F247C0
    }

    public class UserMappingType : Object
    {
        public byte upn_domain_hint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}