// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 4
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class BasicTlsPskIdentity : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F778E0 | overloaded x2
        public void SkipIdentityHint(){} // RVA: 0x7FFE810FB310
        public void NotifyIdentityHint(){} // RVA: 0x7FFE810FB310
        public void GetPskIdentity(){} // RVA: 0x7FFE81116380
        public void GetPsk(){} // RVA: 0x7FFE89F77A90
    }

    public class BulkCipherAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ByteQueue : Object
    {
        public int DefaultCapacity;

        // ── Methods ──
        public void NextTwoPow(){} // RVA: 0x7FFE89F77B40
        public void .ctor(){} // RVA: 0x7FFE89F77D10 | overloaded x3
        public void AddData(){} // RVA: 0x7FFE89F77D70
        public void get_Available(){} // RVA: 0x7FFE82707EE0
        public void CopyTo(){} // RVA: 0x7FFE89F77F00
        public void Read(){} // RVA: 0x7FFE89F78000
        public void ReadFrom(){} // RVA: 0x7FFE89F781E0
        public void RemoveData(){} // RVA: 0x7FFE89F78440 | overloaded x3
        public void Shrink(){} // RVA: 0x7FFE89F784E0
    }

    public class ByteQueueStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ByteQueue buffer; // 0x28
        public object field_1; // 0x403
        public object field_2; // 0x404
        public object field_3; // 0x405
        public object field_4; // 0x406
        public object field_5; // 0x407

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F786A0
        public void get_Available(){} // RVA: 0x7FFE89F78770
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_Length(){} // RVA: 0x7FFE89F78790
        public void Peek(){} // RVA: 0x7FFE89F787D0
        public void get_Position(){} // RVA: 0x7FFE89F78870
        public void set_Position(){} // RVA: 0x7FFE89F788B0
        public void Read(){} // RVA: 0x7FFE89F788F0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFE89F789C0
        public void Seek(){} // RVA: 0x7FFE89F78A10
        public void SetLength(){} // RVA: 0x7FFE89F78A50
        public void Skip(){} // RVA: 0x7FFE89F78A90
        public void Write(){} // RVA: 0x7FFE89F78B60 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE89F78B90
    }

}