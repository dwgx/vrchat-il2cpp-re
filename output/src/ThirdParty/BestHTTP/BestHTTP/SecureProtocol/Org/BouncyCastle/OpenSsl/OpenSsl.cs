// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
// Classes: 7
// Methods: 37

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
{
    public class IPasswordFinder
    {
        // ── Methods ──
        public void GetPassword(){} // RVA: 0x7FFE80E2E2E0
    }

    public class MiscPemGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50 | overloaded x2
        public void CreatePemObject(){} // RVA: 0x7FFE8A31C0C0 | overloaded x2
        public void EncodePrivateKey(){} // RVA: 0x7FFE8A31C930
        public void Generate(){} // RVA: 0x7FFE8A31D3F0
    }

    public class PemException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x2
    }

    public class PemReader : PemReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8A31D5B0 | overloaded x2
        public void ReadObject(){} // RVA: 0x7FFE8A31D6C0
        public void ReadRsaPublicKey(){} // RVA: 0x7FFE8A31DE40
        public void ReadPublicKey(){} // RVA: 0x7FFE8A31DEE0
        public void ReadCertificate(){} // RVA: 0x7FFE8A31DF20
        public void ReadCrl(){} // RVA: 0x7FFE8A31E020
        public void ReadCertificateRequest(){} // RVA: 0x7FFE8A31E110
        public void ReadAttributeCertificate(){} // RVA: 0x7FFE8A31E210
        public void ReadPkcs7(){} // RVA: 0x7FFE8A31E280
        public void ReadPrivateKey(){} // RVA: 0x7FFE8A31E350
        public void GetCurveParameters(){} // RVA: 0x7FFE8A31F5C0
    }

    public class PemUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A3AEE00
        public void ParseDekAlgName(){} // RVA: 0x7FFE8A3AEFF0
        public void Crypt(){} // RVA: 0x7FFE8A3AF320
        public void GetCipherParameters(){} // RVA: 0x7FFE8A3AF7F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PemWriter : PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A144C50
        public void WriteObject(){} // RVA: 0x7FFE8A3AFB70 | overloaded x2
    }

    public class Pkcs8Generator : Object
    {
        public string PbeSha1_RC4_128;
        public string PbeSha1_RC4_40; // 0x8
        public string PbeSha1_3DES; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3AFD30 | overloaded x2
        public void set_SecureRandom(){} // RVA: 0x7FFE81129890
        public void set_Password(){} // RVA: 0x7FFE810FCE30
        public void set_IterationCount(){} // RVA: 0x7FFE8170B670
        public void Generate(){} // RVA: 0x7FFE8A3AFDF0
        public void .cctor(){} // RVA: 0x7FFE8A3B0070
    }

}