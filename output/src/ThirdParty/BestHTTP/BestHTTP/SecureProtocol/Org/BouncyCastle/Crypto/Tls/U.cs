// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class UrlAndHash
    {
        public string mUrl; // 0x10
        public byte[] mSha1Hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9564CE0
        public void get_Url(){} // RVA: 0x2F8380
        public void get_Sha1Hash(){} // RVA: 0x2E07C0
        public void Encode(){} // RVA: 0x9564DF0
        public void Parse(){} // RVA: 0x9564F20
    }

    public class UseSrtpData
    {
        public int[] mProtectionProfiles; // 0x10
        public byte[] mMki; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9565260
        public void get_ProtectionProfiles(){} // RVA: 0x2F8380
        public void get_Mki(){} // RVA: 0x2E07C0
    }

    public class UserMappingType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}