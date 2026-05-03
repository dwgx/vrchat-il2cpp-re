// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
// Classes: 7
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
    public class CipherStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher inCipher; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher outCipher; // 0x38
        public byte[] mInBuf; // 0x40
        public int mInPos; // 0x48
        public bool inStreamEnded; // 0x4C
        public object field_6; // 0x56E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A02FC60
        public void get_ReadCipher(){} // RVA: 0x7FFE8144E200
        public void get_WriteCipher(){} // RVA: 0x7FFE8143BA80
        public void ReadByte(){} // RVA: 0x7FFE8A02FE20
        public void Read(){} // RVA: 0x7FFE8A02FEB0
        public void FillInBuf(){} // RVA: 0x7FFE8A02FFF0
        public void ReadAndProcessBlock(){} // RVA: 0x7FFE8A0301D0
        public void Write(){} // RVA: 0x7FFE8A030320
        public void WriteByte(){} // RVA: 0x7FFE8A030400
        public void get_CanRead(){} // RVA: 0x7FFE8A0304C0
        public void get_CanWrite(){} // RVA: 0x7FFE8A030510
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE8A030560
        public void get_Position(){} // RVA: 0x7FFE8A0305A0
        public void set_Position(){} // RVA: 0x7FFE8A0305E0
        public void Close(){} // RVA: 0x7FFE8A030620
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Seek(){} // RVA: 0x7FFE8A030720
        public void SetLength(){} // RVA: 0x7FFE8A030760
    }

    public class DigestSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F83F60
        public void get_Digest(){} // RVA: 0x7FFE8144E200
        public void WriteByte(){} // RVA: 0x7FFE8A0307A0
        public void Write(){} // RVA: 0x7FFE8A030800
    }

    public class DigestStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest inDigest; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest outDigest; // 0x38
        public object field_3; // 0x576
        public object field_4; // 0x577

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A030890
        public void ReadDigest(){} // RVA: 0x7FFE8144E200
        public void WriteDigest(){} // RVA: 0x7FFE8143BA80
        public void Read(){} // RVA: 0x7FFE8A0309F0
        public void ReadByte(){} // RVA: 0x7FFE8A030AB0
        public void Write(){} // RVA: 0x7FFE8A030B40
        public void WriteByte(){} // RVA: 0x7FFE8A030C00
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
        public void Close(){} // RVA: 0x7FFE8A030C90
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void SetLength(){} // RVA: 0x7FFE871CDA40
    }

    public class MacSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mMac; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F83F60
        public void get_Mac(){} // RVA: 0x7FFE8144E200
        public void WriteByte(){} // RVA: 0x7FFE8A030D10
        public void Write(){} // RVA: 0x7FFE8A030D70
    }

    public class MacStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac inMac; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac outMac; // 0x38
        public object field_3; // 0x57C
        public object field_4; // 0x57D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A030E00
        public void ReadMac(){} // RVA: 0x7FFE8144E200
        public void WriteMac(){} // RVA: 0x7FFE8143BA80
        public void Read(){} // RVA: 0x7FFE8A030F60
        public void ReadByte(){} // RVA: 0x7FFE8A031020
        public void Write(){} // RVA: 0x7FFE8A0310B0
        public void WriteByte(){} // RVA: 0x7FFE8A031170
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
        public void Close(){} // RVA: 0x7FFE8A031200
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void SetLength(){} // RVA: 0x7FFE871CDA40
    }

    public class SignerSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner mSigner; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F83F60
        public void get_Signer(){} // RVA: 0x7FFE8144E200
        public void WriteByte(){} // RVA: 0x7FFE8A031280
        public void Write(){} // RVA: 0x7FFE8A0312E0
    }

    public class SignerStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner inSigner; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner outSigner; // 0x38
        public object field_3; // 0x582
        public object field_4; // 0x583

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A031370
        public void ReadSigner(){} // RVA: 0x7FFE8144E200
        public void WriteSigner(){} // RVA: 0x7FFE8143BA80
        public void Read(){} // RVA: 0x7FFE8A0314D0
        public void ReadByte(){} // RVA: 0x7FFE8A031590
        public void Write(){} // RVA: 0x7FFE8A031620
        public void WriteByte(){} // RVA: 0x7FFE8A0316E0
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
        public void Close(){} // RVA: 0x7FFE8A031770
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void SetLength(){} // RVA: 0x7FFE871CDA40
    }

}