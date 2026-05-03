// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 1
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class RecordStream : Object
    {
        public int DEFAULT_PLAINTEXT_LIMIT;
        public int TLS_HEADER_SIZE;
        public int TLS_HEADER_TYPE_OFFSET;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F93780
        public void Init(){} // RVA: 0x7FFE89F93BE0
        public void GetPlaintextLimit(){} // RVA: 0x7FFE814AA230
        public void SetPlaintextLimit(){} // RVA: 0x7FFE89F93DE0
        public void get_ReadVersion(){} // RVA: 0x7FFE81280C30
        public void set_ReadVersion(){} // RVA: 0x7FFE81282380
        public void SetWriteVersion(){} // RVA: 0x7FFE81280F90
        public void SetRestrictReadVersion(){} // RVA: 0x7FFE820BFEB0
        public void SetPendingConnectionState(){} // RVA: 0x7FFE89F93E00
        public void SentWriteCipherSpec(){} // RVA: 0x7FFE89F93EB0
        public void ReceivedReadCipherSpec(){} // RVA: 0x7FFE89F94050
        public void FinaliseHandshake(){} // RVA: 0x7FFE89F941F0
        public void CheckRecordHeader(){} // RVA: 0x7FFE89F94280
        public void ReadRecord(){} // RVA: 0x7FFE89F94520
        public void DecodeAndVerify(){} // RVA: 0x7FFE89F94930
        public void WriteRecord(){} // RVA: 0x7FFE89F94BE0
        public void NotifyHelloComplete(){} // RVA: 0x7FFE89F95040
        public void get_HandshakeHash(){} // RVA: 0x7FFE811C3590
        public void get_HandshakeHashUpdater(){} // RVA: 0x7FFE81463AE0
        public void PrepareToFinish(){} // RVA: 0x7FFE89F950E0
        public void SafeClose(){} // RVA: 0x7FFE89F95190
        public void Flush(){} // RVA: 0x7FFE874EE620
        public void GetBufferContents(){} // RVA: 0x7FFE89F95250
        public void CheckType(){} // RVA: 0x7FFE89F952B0
        public void CheckLength(){} // RVA: 0x7FFE89F95320
    }

}