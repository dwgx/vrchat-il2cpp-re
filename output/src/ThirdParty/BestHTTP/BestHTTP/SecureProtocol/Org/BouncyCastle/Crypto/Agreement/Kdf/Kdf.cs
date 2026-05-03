// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 18

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0E92E0
        public void Init(){} // RVA: 0x7FFE8A0E9390
        public void get_Digest(){} // RVA: 0x7FFE81116380
        public void GenerateBytes(){} // RVA: 0x7FFE8A0E9540
    }

    public class DHKdfParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x10
        public int keySize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87253690 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFE81116380
        public void get_KeySize(){} // RVA: 0x7FFE813DB630
        public void GetZ(){} // RVA: 0x7FFE811290C0
        public void GetExtraInfo(){} // RVA: 0x7FFE81129130
    }

    public class DHKekGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Init(){} // RVA: 0x7FFE8A0E9C40
        public void get_Digest(){} // RVA: 0x7FFE81116380
        public void GenerateBytes(){} // RVA: 0x7FFE8A0E9DE0
    }

    public class ECDHKekGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction kdf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0EA560
        public void Init(){} // RVA: 0x7FFE8A0EA660
        public void get_Digest(){} // RVA: 0x7FFE8A0EA7B0
        public void GenerateBytes(){} // RVA: 0x7FFE8A0EA800
    }

}