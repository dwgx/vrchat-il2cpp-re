// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class BasicTlsPskIdentity : Object
    {
        public byte[] mIdentity; // 0x10
        public byte[] mPsk; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB1E2C0 | overloaded x2
        public void SkipIdentityHint(){} // RVA: 0x7FFAC2F21310
        public void NotifyIdentityHint(){} // RVA: 0x7FFAC2F21310
        public void GetPskIdentity(){} // RVA: 0x7FFAC2F3C380
        public void GetPsk(){} // RVA: 0x7FFACBB1E470
    }

    public class BulkCipherAlgorithm : Object
    {
        public int cls_null;
        public int rc4;
        public int rc2;
        public int des;
        public int cls_3des;
        public int des40;
        public int aes;
        public int idea;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ByteQueue : Object
    {
        public int Available;
        public byte[] databuf; // 0x10
        public int skipped; // 0x18
        public int available; // 0x1C
        public bool readOnlyBuf; // 0x20

        // ── Methods ──
        public void NextTwoPow(){} // RVA: 0x7FFACBB1E520
        public void .ctor(){} // RVA: 0x7FFACBB1E6F0 | overloaded x3
        public void AddData(){} // RVA: 0x7FFACBB1E750
        public void get_Available(){} // RVA: 0x7FFAC44357F0
        public void CopyTo(){} // RVA: 0x7FFACBB1E8E0
        public void Read(){} // RVA: 0x7FFACBB1E9E0
        public void ReadFrom(){} // RVA: 0x7FFACBB1EBC0
        public void RemoveData(){} // RVA: 0x7FFACBB1EE20 | overloaded x3
        public void Shrink(){} // RVA: 0x7FFACBB1EEC0
    }

    public class ByteQueueStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue Available; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB1F080
        public void get_Available(){} // RVA: 0x7FFACBB1F150
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_Length(){} // RVA: 0x7FFACBB1F170
        public void Peek(){} // RVA: 0x7FFACBB1F1B0
        public void get_Position(){} // RVA: 0x7FFACBB1F250
        public void set_Position(){} // RVA: 0x7FFACBB1F290
        public void Read(){} // RVA: 0x7FFACBB1F2D0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFACBB1F3A0
        public void Seek(){} // RVA: 0x7FFACBB1F3F0
        public void SetLength(){} // RVA: 0x7FFACBB1F430
        public void Skip(){} // RVA: 0x7FFACBB1F470
        public void Write(){} // RVA: 0x7FFACBB1F540 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFACBB1F570
    }

}