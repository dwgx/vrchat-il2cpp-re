// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 18

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest Digest; // 0x10
        public byte[] mShared; // 0x18
        public byte[] mOtherInfo; // 0x20
        public int mHLen; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC8FCC0
        public void Init(){} // RVA: 0x7FFACBC8FD70
        public void get_Digest(){} // RVA: 0x7FFAC2F3C380
        public void GenerateBytes(){} // RVA: 0x7FFACBC8FF20
    }

    public class DHKdfParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm; // 0x10
        public int KeySize; // 0x18
        public byte[] z; // 0x20
        public byte[] extraInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EAB260 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_KeySize(){} // RVA: 0x7FFAC3157800
        public void GetZ(){} // RVA: 0x7FFAC2F4F0C0
        public void GetExtraInfo(){} // RVA: 0x7FFAC2F4F130
    }

    public class DHKekGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest Digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x18
        public int keySize; // 0x20
        public byte[] z; // 0x28
        public byte[] partyAInfo; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Init(){} // RVA: 0x7FFACBC90620
        public void get_Digest(){} // RVA: 0x7FFAC2F3C380
        public void GenerateBytes(){} // RVA: 0x7FFACBC907C0
    }

    public class ECDHKekGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction Digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x18
        public int keySize; // 0x20
        public byte[] z; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC90F40
        public void Init(){} // RVA: 0x7FFACBC91040
        public void get_Digest(){} // RVA: 0x7FFACBC91190
        public void GenerateBytes(){} // RVA: 0x7FFACBC911E0
    }

}