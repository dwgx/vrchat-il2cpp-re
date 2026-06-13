// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 18

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9686F00
        public void Init(){} // RVA: 0x9686FB0
        public void get_Digest(){} // RVA: 0x2F8380
        public void GenerateBytes(){} // RVA: 0x9687160
    }

    public class DHKdfParameters : .ctor
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Digest; // 0x10
        public int keySize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6714790 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_KeySize(){} // RVA: 0x5BED50
        public void GetZ(){} // RVA: 0x30B0C0
        public void GetExtraInfo(){} // RVA: 0x30B130
    }

    public class DHKekGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Init(){} // RVA: 0x9687860
        public void get_Digest(){} // RVA: 0x2F8380
        public void GenerateBytes(){} // RVA: 0x9687A00
    }

    public class ECDHKekGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction kdf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9688180
        public void Init(){} // RVA: 0x9688280
        public void get_Digest(){} // RVA: 0x96883D0
        public void GenerateBytes(){} // RVA: 0x9688420
    }

}