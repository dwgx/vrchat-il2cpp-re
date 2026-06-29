// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
// Classes: 7
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
    public class CipherStream : Stream
    {
        public object stream;
        public object inCipher;
        public object outCipher;
        public object mInBuf;
        public object mInPos;
        public object inStreamEnded;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA270220
        public void get_ReadCipher(){} // RVA: 0xD33E60
        public void get_WriteCipher(){} // RVA: 0xD05CA0
        public void ReadByte(){} // RVA: 0xA2703E0
        public void Read(){} // RVA: 0xA270470
        public void FillInBuf(){} // RVA: 0xA2705B0
        public void ReadAndProcessBlock(){} // RVA: 0xA270780
        public void Write(){} // RVA: 0xA2708C0
        public void WriteByte(){} // RVA: 0xA2709A0
        public void get_CanRead(){} // RVA: 0xA270A60
        public void get_CanWrite(){} // RVA: 0xA270AB0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0xA270B00
        public void get_Position(){} // RVA: 0xA270B40
        public void set_Position(){} // RVA: 0xA270B80
        public void Close(){} // RVA: 0xA270BC0
        public void Flush(){} // RVA: 0x6E861D0
        public void Seek(){} // RVA: 0xA270CC0
        public void SetLength(){} // RVA: 0xA270D00
    }

    public class DigestSink : BaseOutputStream
    {
        public object mDigest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C37F0
        public void get_Digest(){} // RVA: 0xD33E60
        public void WriteByte(){} // RVA: 0xA270D40
        public void Write(){} // RVA: 0xA270DA0
    }

    public class DigestStream : Stream
    {
        public object stream;
        public object inDigest;
        public object outDigest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA270E30
        public void ReadDigest(){} // RVA: 0xD33E60
        public void WriteDigest(){} // RVA: 0xD05CA0
        public void Read(){} // RVA: 0xA270F90
        public void ReadByte(){} // RVA: 0xA271050
        public void Write(){} // RVA: 0xA2710E0
        public void WriteByte(){} // RVA: 0xA2711A0
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
        public void Close(){} // RVA: 0xA271230
        public void Flush(){} // RVA: 0x6E861D0
        public void Seek(){} // RVA: 0x74EEE80
        public void SetLength(){} // RVA: 0x70F92B0
    }

    public class MacSink : BaseOutputStream
    {
        public object mMac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C37F0
        public void get_Mac(){} // RVA: 0xD33E60
        public void WriteByte(){} // RVA: 0xA2712B0
        public void Write(){} // RVA: 0xA271310
    }

    public class MacStream : Stream
    {
        public object stream;
        public object inMac;
        public object outMac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2713A0
        public void ReadMac(){} // RVA: 0xD33E60
        public void WriteMac(){} // RVA: 0xD05CA0
        public void Read(){} // RVA: 0xA271500
        public void ReadByte(){} // RVA: 0xA2715C0
        public void Write(){} // RVA: 0xA271650
        public void WriteByte(){} // RVA: 0xA271710
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
        public void Close(){} // RVA: 0xA2717A0
        public void Flush(){} // RVA: 0x6E861D0
        public void Seek(){} // RVA: 0x74EEE80
        public void SetLength(){} // RVA: 0x70F92B0
    }

    public class SignerSink : BaseOutputStream
    {
        public object mSigner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1C37F0
        public void get_Signer(){} // RVA: 0xD33E60
        public void WriteByte(){} // RVA: 0xA271820
        public void Write(){} // RVA: 0xA271880
    }

    public class SignerStream : Stream
    {
        public object stream;
        public object inSigner;
        public object outSigner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA271910
        public void ReadSigner(){} // RVA: 0xD33E60
        public void WriteSigner(){} // RVA: 0xD05CA0
        public void Read(){} // RVA: 0xA271A70
        public void ReadByte(){} // RVA: 0xA271B30
        public void Write(){} // RVA: 0xA271BC0
        public void WriteByte(){} // RVA: 0xA271C80
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
        public void Close(){} // RVA: 0xA271D10
        public void Flush(){} // RVA: 0x6E861D0
        public void Seek(){} // RVA: 0x74EEE80
        public void SetLength(){} // RVA: 0x70F92B0
    }

}