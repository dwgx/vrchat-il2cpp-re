// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
// Classes: 7
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
    public class CipherStream : Stream
    {
        public System.IO.Stream ReadCipher; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher WriteCipher; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher CanRead; // 0x38
        public byte[] CanWrite; // 0x40
        public int CanSeek; // 0x48
        public bool Length; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD6640
        public void get_ReadCipher(){} // RVA: 0x7FFAC31D95E0
        public void get_WriteCipher(){} // RVA: 0x7FFAC31D0140
        public void ReadByte(){} // RVA: 0x7FFACBBD6800
        public void Read(){} // RVA: 0x7FFACBBD6890
        public void FillInBuf(){} // RVA: 0x7FFACBBD69D0
        public void ReadAndProcessBlock(){} // RVA: 0x7FFACBBD6BB0
        public void Write(){} // RVA: 0x7FFACBBD6D00
        public void WriteByte(){} // RVA: 0x7FFACBBD6DE0
        public void get_CanRead(){} // RVA: 0x7FFACBBD6EA0
        public void get_CanWrite(){} // RVA: 0x7FFACBBD6EF0
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFACBBD6F40
        public void get_Position(){} // RVA: 0x7FFACBBD6F80
        public void set_Position(){} // RVA: 0x7FFACBBD6FC0
        public void Close(){} // RVA: 0x7FFACBBD7000
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFACBBD7100
        public void SetLength(){} // RVA: 0x7FFACBBD7140
    }

    public class DigestSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest Digest; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2A940
        public void get_Digest(){} // RVA: 0x7FFAC31D95E0
        public void WriteByte(){} // RVA: 0x7FFACBBD7180
        public void Write(){} // RVA: 0x7FFACBBD71E0
    }

    public class DigestStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest CanWrite; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest CanSeek; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD7270
        public void ReadDigest(){} // RVA: 0x7FFAC31D95E0
        public void WriteDigest(){} // RVA: 0x7FFAC31D0140
        public void Read(){} // RVA: 0x7FFACBBD73D0
        public void ReadByte(){} // RVA: 0x7FFACBBD7490
        public void Write(){} // RVA: 0x7FFACBBD7520
        public void WriteByte(){} // RVA: 0x7FFACBBD75E0
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Close(){} // RVA: 0x7FFACBBD7670
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
    }

    public class MacSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac Mac; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2A940
        public void get_Mac(){} // RVA: 0x7FFAC31D95E0
        public void WriteByte(){} // RVA: 0x7FFACBBD76F0
        public void Write(){} // RVA: 0x7FFACBBD7750
    }

    public class MacStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac CanWrite; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac CanSeek; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD77E0
        public void ReadMac(){} // RVA: 0x7FFAC31D95E0
        public void WriteMac(){} // RVA: 0x7FFAC31D0140
        public void Read(){} // RVA: 0x7FFACBBD7940
        public void ReadByte(){} // RVA: 0x7FFACBBD7A00
        public void Write(){} // RVA: 0x7FFACBBD7A90
        public void WriteByte(){} // RVA: 0x7FFACBBD7B50
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Close(){} // RVA: 0x7FFACBBD7BE0
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
    }

    public class SignerSink : BaseOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner Signer; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB2A940
        public void get_Signer(){} // RVA: 0x7FFAC31D95E0
        public void WriteByte(){} // RVA: 0x7FFACBBD7C60
        public void Write(){} // RVA: 0x7FFACBBD7CC0
    }

    public class SignerStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner CanWrite; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner CanSeek; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD7D50
        public void ReadSigner(){} // RVA: 0x7FFAC31D95E0
        public void WriteSigner(){} // RVA: 0x7FFAC31D0140
        public void Read(){} // RVA: 0x7FFACBBD7EB0
        public void ReadByte(){} // RVA: 0x7FFACBBD7F70
        public void Write(){} // RVA: 0x7FFACBBD8000
        public void WriteByte(){} // RVA: 0x7FFACBBD80C0
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Close(){} // RVA: 0x7FFACBBD8150
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
    }

}