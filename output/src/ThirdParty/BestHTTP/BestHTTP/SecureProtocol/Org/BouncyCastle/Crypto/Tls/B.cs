// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class BasicTlsPskIdentity : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9515510 | overloaded x2
        public void SkipIdentityHint(){} // RVA: 0x2DD310
        public void NotifyIdentityHint(){} // RVA: 0x2DD310
        public void GetPskIdentity(){} // RVA: 0x2F8380
        public void GetPsk(){} // RVA: 0x95156C0
    }

    public class BulkCipherAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ByteQueue
    {
        public int DefaultCapacity;

        // ── Methods ──
        public void NextTwoPow(){} // RVA: 0x9515770
        public void .ctor(){} // RVA: 0x9515940 | overloaded x3
        public void AddData(){} // RVA: 0x95159A0
        public void get_Available(){} // RVA: 0x197C3B0
        public void CopyTo(){} // RVA: 0x9515B30
        public void Read(){} // RVA: 0x9515C30
        public void ReadFrom(){} // RVA: 0x9515E10
        public void RemoveData(){} // RVA: 0x9516070 | overloaded x3
        public void Shrink(){} // RVA: 0x9516110
    }

    public class ByteQueueStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue buffer; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95162D0
        public void get_Available(){} // RVA: 0x95163A0
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void Flush(){} // RVA: 0x2DD310
        public void get_Length(){} // RVA: 0x95163C0
        public void Peek(){} // RVA: 0x9516400
        public void get_Position(){} // RVA: 0x95164A0
        public void set_Position(){} // RVA: 0x95164E0
        public void Read(){} // RVA: 0x9516520 | overloaded x2
        public void ReadByte(){} // RVA: 0x95165F0
        public void Seek(){} // RVA: 0x9516640
        public void SetLength(){} // RVA: 0x9516680
        public void Skip(){} // RVA: 0x95166C0
        public void Write(){} // RVA: 0x9516790 | overloaded x2
        public void WriteByte(){} // RVA: 0x95167C0
    }

}