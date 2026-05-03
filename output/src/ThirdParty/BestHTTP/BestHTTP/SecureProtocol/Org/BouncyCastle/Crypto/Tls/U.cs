// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 3
// Methods: 9

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class UrlAndHash : Object
    {
        public string mUrl; // 0x10
        public byte[] mSha1Hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FC70B0
        public void get_Url(){} // RVA: 0x7FFE81116380
        public void get_Sha1Hash(){} // RVA: 0x7FFE810FE7C0
        public void Encode(){} // RVA: 0x7FFE89FC71C0
        public void Parse(){} // RVA: 0x7FFE89FC72F0
    }

    public class UseSrtpData : Object
    {
        public int[] mProtectionProfiles; // 0x10
        public byte[] mMki; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FC7630
        public void get_ProtectionProfiles(){} // RVA: 0x7FFE81116380
        public void get_Mki(){} // RVA: 0x7FFE810FE7C0
    }

    public class UserMappingType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}