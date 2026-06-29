// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 1
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class RecordStream : Object
    {
        public object DEFAULT_PLAINTEXT_LIMIT;
        public object TLS_HEADER_SIZE;
        public object TLS_HEADER_TYPE_OFFSET;
        public object TLS_HEADER_VERSION_OFFSET;
        public object TLS_HEADER_LENGTH_OFFSET;
        public object mHandler;
        public object mInput;
        public object mOutput;
        public object mPendingCompression;
        public object mReadCompression;
        public object mWriteCompression;
        public object mPendingCipher;
        public object mReadCipher;
        public object mWriteCipher;
        public object mReadSeqNo;
        public object mWriteSeqNo;
        public object mBuffer;
        public object mHandshakeHash;
        public object mHandshakeHashUpdater;
        public object mReadVersion;
        public object mWriteVersion;
        public object mRestrictReadVersion;
        public object mPlaintextLimit;
        public object mCompressedLimit;
        public object mCiphertextLimit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D2FD0
        public void Init(){} // RVA: 0xA1D3430
        public void GetPlaintextLimit(){} // RVA: 0xF3A940
        public void SetPlaintextLimit(){} // RVA: 0xA1D3630
        public void get_ReadVersion(){} // RVA: 0xCD48B0
        public void set_ReadVersion(){} // RVA: 0xCD3600
        public void SetWriteVersion(){} // RVA: 0xD5CBB0
        public void SetRestrictReadVersion(){} // RVA: 0x1C4DB10
        public void SetPendingConnectionState(){} // RVA: 0xA1D3650
        public void SentWriteCipherSpec(){} // RVA: 0xA1D3700
        public void ReceivedReadCipherSpec(){} // RVA: 0xA1D38A0
        public void FinaliseHandshake(){} // RVA: 0xA1D3A40
        public void CheckRecordHeader(){} // RVA: 0xA1D3AD0
        public void ReadRecord(){} // RVA: 0xA1D3D70
        public void DecodeAndVerify(){} // RVA: 0xA1D4180
        public void WriteRecord(){} // RVA: 0xA1D4430
        public void NotifyHelloComplete(){} // RVA: 0xA1D4890
        public void get_HandshakeHash(){} // RVA: 0xC10050
        public void get_HandshakeHashUpdater(){} // RVA: 0xCD3320
        public void PrepareToFinish(){} // RVA: 0xA1D4930
        public void SafeClose(){} // RVA: 0xA1D49E0
        public void Flush(){} // RVA: 0x7414FA0
        public void GetBufferContents(){} // RVA: 0xA1D4AA0
        public void CheckType(){} // RVA: 0xA1D4B00
        public void CheckLength(){} // RVA: 0xA1D4B70
    }

}