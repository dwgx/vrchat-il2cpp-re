// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
// Classes: 7
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
    public class CipherStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1404C40
        public void get_ReadCipher(){} // RVA: 0x7A83F69F0
        public void get_WriteCipher(){} // RVA: 0x7A8292C30
        public void ReadByte(){} // RVA: 0x7B1404E00
        public void Read(){} // RVA: 0x7B1404E90
        public void FillInBuf(){} // RVA: 0x7B1404FD0
        public void ReadAndProcessBlock(){} // RVA: 0x7B14051A0
        public void Write(){} // RVA: 0x7B14052E0
        public void WriteByte(){} // RVA: 0x7B14053C0
        public void get_CanRead(){} // RVA: 0x7B1405480
        public void get_CanWrite(){} // RVA: 0x7B14054D0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7B1405520
        public void get_Position(){} // RVA: 0x7B1405560
        public void set_Position(){} // RVA: 0x7B14055A0
        public void Close(){} // RVA: 0x7B14055E0
        public void Flush(){} // RVA: 0x7AE203670
        public void Seek(){} // RVA: 0x7B14056E0
        public void SetLength(){} // RVA: 0x7B1405720
    }

    public class DigestSink : BaseOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1357EA0
        public void get_Digest(){} // RVA: 0x7A83F69F0
        public void WriteByte(){} // RVA: 0x7B1405760
        public void Write(){} // RVA: 0x7B14057C0
    }

    public class DigestStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1405850
        public void ReadDigest(){} // RVA: 0x7A83F69F0
        public void WriteDigest(){} // RVA: 0x7A8292C30
        public void Read(){} // RVA: 0x7B14059B0
        public void ReadByte(){} // RVA: 0x7B1405A70
        public void Write(){} // RVA: 0x7B1405B00
        public void WriteByte(){} // RVA: 0x7B1405BC0
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
        public void Close(){} // RVA: 0x7B1405C50
        public void Flush(){} // RVA: 0x7AE203670
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void SetLength(){} // RVA: 0x7AE47D1C0
    }

    public class MacSink : BaseOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1357EA0
        public void get_Mac(){} // RVA: 0x7A83F69F0
        public void WriteByte(){} // RVA: 0x7B1405CD0
        public void Write(){} // RVA: 0x7B1405D30
    }

    public class MacStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1405DC0
        public void ReadMac(){} // RVA: 0x7A83F69F0
        public void WriteMac(){} // RVA: 0x7A8292C30
        public void Read(){} // RVA: 0x7B1405F20
        public void ReadByte(){} // RVA: 0x7B1405FE0
        public void Write(){} // RVA: 0x7B1406070
        public void WriteByte(){} // RVA: 0x7B1406130
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
        public void Close(){} // RVA: 0x7B14061C0
        public void Flush(){} // RVA: 0x7AE203670
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void SetLength(){} // RVA: 0x7AE47D1C0
    }

    public class SignerSink : BaseOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1357EA0
        public void get_Signer(){} // RVA: 0x7A83F69F0
        public void WriteByte(){} // RVA: 0x7B1406240
        public void Write(){} // RVA: 0x7B14062A0
    }

    public class SignerStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1406330
        public void ReadSigner(){} // RVA: 0x7A83F69F0
        public void WriteSigner(){} // RVA: 0x7A8292C30
        public void Read(){} // RVA: 0x7B1406490
        public void ReadByte(){} // RVA: 0x7B1406550
        public void Write(){} // RVA: 0x7B14065E0
        public void WriteByte(){} // RVA: 0x7B14066A0
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
        public void Close(){} // RVA: 0x7B1406730
        public void Flush(){} // RVA: 0x7AE203670
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void SetLength(){} // RVA: 0x7AE47D1C0
    }

}