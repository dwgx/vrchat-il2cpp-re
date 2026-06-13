// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
// Classes: 7
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
    public class CipherStream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher inCipher; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher outCipher; // 0x38
        public byte[] mInBuf; // 0x40
        public int mInPos; // 0x48
        public bool inStreamEnded; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CD880
        public void get_ReadCipher(){} // RVA: 0x6374D0
        public void get_WriteCipher(){} // RVA: 0x4976A0
        public void ReadByte(){} // RVA: 0x95CDA40
        public void Read(){} // RVA: 0x95CDAD0
        public void FillInBuf(){} // RVA: 0x95CDC10
        public void ReadAndProcessBlock(){} // RVA: 0x95CDDF0
        public void Write(){} // RVA: 0x95CDF40
        public void WriteByte(){} // RVA: 0x95CE020
        public void get_CanRead(){} // RVA: 0x95CE0E0
        public void get_CanWrite(){} // RVA: 0x95CE130
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x95CE180
        public void get_Position(){} // RVA: 0x95CE1C0
        public void set_Position(){} // RVA: 0x95CE200
        public void Close(){} // RVA: 0x95CE240
        public void Flush(){} // RVA: 0x6415940
        public void Seek(){} // RVA: 0x95CE340
        public void SetLength(){} // RVA: 0x95CE380
    }

    public class DigestSink
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521B90
        public void get_Digest(){} // RVA: 0x6374D0
        public void WriteByte(){} // RVA: 0x95CE3C0
        public void Write(){} // RVA: 0x95CE420
    }

    public class DigestStream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest inDigest; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest outDigest; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CE4B0
        public void ReadDigest(){} // RVA: 0x6374D0
        public void WriteDigest(){} // RVA: 0x4976A0
        public void Read(){} // RVA: 0x95CE610
        public void ReadByte(){} // RVA: 0x95CE6D0
        public void Write(){} // RVA: 0x95CE760
        public void WriteByte(){} // RVA: 0x95CE820
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanWrite(){} // RVA: 0x6A89DD0
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x6A142C0
        public void Close(){} // RVA: 0x95CE8B0
        public void Flush(){} // RVA: 0x6415940
        public void Seek(){} // RVA: 0x6A89D40
        public void SetLength(){} // RVA: 0x668EB50
    }

    public class MacSink
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mMac; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521B90
        public void get_Mac(){} // RVA: 0x6374D0
        public void WriteByte(){} // RVA: 0x95CE930
        public void Write(){} // RVA: 0x95CE990
    }

    public class MacStream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac inMac; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac outMac; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CEA20
        public void ReadMac(){} // RVA: 0x6374D0
        public void WriteMac(){} // RVA: 0x4976A0
        public void Read(){} // RVA: 0x95CEB80
        public void ReadByte(){} // RVA: 0x95CEC40
        public void Write(){} // RVA: 0x95CECD0
        public void WriteByte(){} // RVA: 0x95CED90
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanWrite(){} // RVA: 0x6A89DD0
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x6A142C0
        public void Close(){} // RVA: 0x95CEE20
        public void Flush(){} // RVA: 0x6415940
        public void Seek(){} // RVA: 0x6A89D40
        public void SetLength(){} // RVA: 0x668EB50
    }

    public class SignerSink
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner mSigner; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9521B90
        public void get_Signer(){} // RVA: 0x6374D0
        public void WriteByte(){} // RVA: 0x95CEEA0
        public void Write(){} // RVA: 0x95CEF00
    }

    public class SignerStream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner inSigner; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner outSigner; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CEF90
        public void ReadSigner(){} // RVA: 0x6374D0
        public void WriteSigner(){} // RVA: 0x4976A0
        public void Read(){} // RVA: 0x95CF0F0
        public void ReadByte(){} // RVA: 0x95CF1B0
        public void Write(){} // RVA: 0x95CF240
        public void WriteByte(){} // RVA: 0x95CF300
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanWrite(){} // RVA: 0x6A89DD0
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x6A142C0
        public void Close(){} // RVA: 0x95CF390
        public void Flush(){} // RVA: 0x6415940
        public void Seek(){} // RVA: 0x6A89D40
        public void SetLength(){} // RVA: 0x668EB50
    }

}