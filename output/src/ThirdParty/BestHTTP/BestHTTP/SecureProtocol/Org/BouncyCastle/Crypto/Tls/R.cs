// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 1
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class RecordStream
    {
        public int DEFAULT_PLAINTEXT_LIMIT;
        public int TLS_HEADER_SIZE;
        public int TLS_HEADER_TYPE_OFFSET;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95313B0
        public void Init(){} // RVA: 0x9531810
        public void GetPlaintextLimit(){} // RVA: 0x6AFD30
        public void SetPlaintextLimit(){} // RVA: 0x9531A10
        public void get_ReadVersion(){} // RVA: 0x462D00
        public void set_ReadVersion(){} // RVA: 0x464450
        public void SetWriteVersion(){} // RVA: 0x463060
        public void SetRestrictReadVersion(){} // RVA: 0x1348E00
        public void SetPendingConnectionState(){} // RVA: 0x9531A30
        public void SentWriteCipherSpec(){} // RVA: 0x9531AE0
        public void ReceivedReadCipherSpec(){} // RVA: 0x9531C80
        public void FinaliseHandshake(){} // RVA: 0x9531E20
        public void CheckRecordHeader(){} // RVA: 0x9531EB0
        public void ReadRecord(){} // RVA: 0x9532150
        public void DecodeAndVerify(){} // RVA: 0x9532560
        public void WriteRecord(){} // RVA: 0x9532810
        public void NotifyHelloComplete(){} // RVA: 0x9532C70
        public void get_HandshakeHash(){} // RVA: 0x3A5590
        public void get_HandshakeHashUpdater(){} // RVA: 0x4C7C50
        public void PrepareToFinish(){} // RVA: 0x9532D10
        public void SafeClose(){} // RVA: 0x9532DC0
        public void Flush(){} // RVA: 0x69AF350
        public void GetBufferContents(){} // RVA: 0x9532E80
        public void CheckType(){} // RVA: 0x9532EE0
        public void CheckLength(){} // RVA: 0x9532F50
    }

}