// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 1
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class RecordStream : Object
    {
        public int ReadVersion;
        public int HandshakeHash;
        public int HandshakeHashUpdater;
        public int TLS_HEADER_VERSION_OFFSET;
        public int TLS_HEADER_LENGTH_OFFSET;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsProtocol mHandler; // 0x10
        public System.IO.Stream mInput; // 0x18
        public System.IO.Stream mOutput; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCompression mPendingCompression; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCompression mReadCompression; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCompression mWriteCompression; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher mPendingCipher; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher mReadCipher; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsCipher mWriteCipher; // 0x50
        public SequenceNumber mReadSeqNo; // 0x58
        public SequenceNumber mWriteSeqNo; // 0x60
        public System.IO.MemoryStream mBuffer; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mHandshakeHash; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.BaseOutputStream mHandshakeHashUpdater; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mReadVersion; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ProtocolVersion mWriteVersion; // 0x88
        public bool mRestrictReadVersion; // 0x90
        public int mPlaintextLimit; // 0x94
        public int mCompressedLimit; // 0x98
        public int mCiphertextLimit; // 0x9C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB3A160
        public void Init(){} // RVA: 0x7FFACBB3A5C0
        public void GetPlaintextLimit(){} // RVA: 0x7FFAC3220670
        public void SetPlaintextLimit(){} // RVA: 0x7FFACBB3A7C0
        public void get_ReadVersion(){} // RVA: 0x7FFAC32EF410
        public void set_ReadVersion(){} // RVA: 0x7FFAC34D4AA0
        public void SetWriteVersion(){} // RVA: 0x7FFAC354E300
        public void SetRestrictReadVersion(){} // RVA: 0x7FFAC3E089B0
        public void SetPendingConnectionState(){} // RVA: 0x7FFACBB3A7E0
        public void SentWriteCipherSpec(){} // RVA: 0x7FFACBB3A890
        public void ReceivedReadCipherSpec(){} // RVA: 0x7FFACBB3AA30
        public void FinaliseHandshake(){} // RVA: 0x7FFACBB3ABD0
        public void CheckRecordHeader(){} // RVA: 0x7FFACBB3AC60
        public void ReadRecord(){} // RVA: 0x7FFACBB3AF00
        public void DecodeAndVerify(){} // RVA: 0x7FFACBB3B310
        public void WriteRecord(){} // RVA: 0x7FFACBB3B5C0
        public void NotifyHelloComplete(){} // RVA: 0x7FFACBB3BA20
        public void get_HandshakeHash(){} // RVA: 0x7FFAC2FE9590
        public void get_HandshakeHashUpdater(){} // RVA: 0x7FFAC30E5600
        public void PrepareToFinish(){} // RVA: 0x7FFACBB3BAC0
        public void SafeClose(){} // RVA: 0x7FFACBB3BB70
        public void Flush(){} // RVA: 0x7FFAC9145E70
        public void GetBufferContents(){} // RVA: 0x7FFACBB3BC30
        public void CheckType(){} // RVA: 0x7FFACBB3BC90
        public void CheckLength(){} // RVA: 0x7FFACBB3BD00
    }

}