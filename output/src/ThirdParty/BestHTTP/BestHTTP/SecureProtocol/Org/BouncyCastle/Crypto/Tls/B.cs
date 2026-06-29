// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 32

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class BasicTlsPskIdentity : Object
    {
        public object mIdentity;
        public object mPsk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1B7070
        public void SkipIdentityHint(){} // RVA: 0xB43310
        public void NotifyIdentityHint(){} // RVA: 0xB43310
        public void GetPskIdentity(){} // RVA: 0xB5DBF0
        public void GetPsk(){} // RVA: 0xA1B7220
    }

    public class BulkCipherAlgorithm : Object
    {
        public object cls_null;
        public object rc4;
        public object rc2;
        public object des;
        public object cls_3des;
        public object des40;
        public object aes;
        public object idea;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ByteQueue : Object
    {
        public object DefaultCapacity;
        public object databuf;
        public object skipped;
        public object available;
        public object readOnlyBuf;

        // ── Methods ──
        public void NextTwoPow(){} // RVA: 0xA1B72D0
        public void .ctor(){} // RVA: 0xA1B74A0
        public void AddData(){} // RVA: 0xA1B7500
        public void get_Available(){} // RVA: 0x2244FB0
        public void CopyTo(){} // RVA: 0xA1B7690
        public void Read(){} // RVA: 0xA1B7790
        public void ReadFrom(){} // RVA: 0xA1B7970
        public void RemoveData(){} // RVA: 0xA1B7BD0
        public void Shrink(){} // RVA: 0xA1B7C70
    }

    public class ByteQueueStream : Stream
    {
        public object buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1B7E30
        public void get_Available(){} // RVA: 0xA1B7F00
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void Flush(){} // RVA: 0xB43310
        public void get_Length(){} // RVA: 0xA1B7F20
        public void Peek(){} // RVA: 0xA1B7F60
        public void get_Position(){} // RVA: 0xA1B8000
        public void set_Position(){} // RVA: 0xA1B8040
        public void Read(){} // RVA: 0xA1B8080
        public void ReadByte(){} // RVA: 0xA1B8150
        public void Seek(){} // RVA: 0xA1B81A0
        public void SetLength(){} // RVA: 0xA1B81E0
        public void Skip(){} // RVA: 0xA1B8220
        public void Write(){} // RVA: 0xA1B82F0
        public void WriteByte(){} // RVA: 0xA1B8320
    }

}