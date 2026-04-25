// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
// Classes: 7
// Methods: 37

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
{
    public class IPasswordFinder
    {
        // ── Methods ──
        public void GetPassword(){} // RVA: 0x7FFAC2C58E90
    }

    public class MiscPemGenerator : Object
    {
        public object obj; // 0x10
        public string algorithm; // 0x18
        public char[] password; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50 | overloaded x2
        public void CreatePemObject(){} // RVA: 0x7FFACBEBE520 | overloaded x2
        public void EncodePrivateKey(){} // RVA: 0x7FFACBEBED90
        public void Generate(){} // RVA: 0x7FFACBEBF850
    }

    public class PemException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x2
    }

    public class PemReader : PemReader
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl.IPasswordFinder pFinder; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFACBEBFA10 | overloaded x2
        public void ReadObject(){} // RVA: 0x7FFACBEBFB20
        public void ReadRsaPublicKey(){} // RVA: 0x7FFACBEC02A0
        public void ReadPublicKey(){} // RVA: 0x7FFACBEC0340
        public void ReadCertificate(){} // RVA: 0x7FFACBEC0380
        public void ReadCrl(){} // RVA: 0x7FFACBEC0480
        public void ReadCertificateRequest(){} // RVA: 0x7FFACBEC0570
        public void ReadAttributeCertificate(){} // RVA: 0x7FFACBEC0670
        public void ReadPkcs7(){} // RVA: 0x7FFACBEC06E0
        public void ReadPrivateKey(){} // RVA: 0x7FFACBEC07B0
        public void GetCurveParameters(){} // RVA: 0x7FFACBEC1A20
    }

    public class PemUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBF4E290
        public void ParseDekAlgName(){} // RVA: 0x7FFACBF4E480
        public void Crypt(){} // RVA: 0x7FFACBF4E7B0
        public void GetCipherParameters(){} // RVA: 0x7FFACBF4EC80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PemWriter : PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEB630
        public void WriteObject(){} // RVA: 0x7FFACBF4F000 | overloaded x2
    }

    public class Pkcs8Generator : Object
    {
        public string SecureRandom;
        public string Password; // 0x8
        public string IterationCount; // 0x10
        public string PbeSha1_2DES; // 0x18
        public string PbeSha1_RC2_128; // 0x20
        public string PbeSha1_RC2_40; // 0x28
        public char[] password; // 0x10
        public string algorithm; // 0x18
        public int iterationCount; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF4F1C0 | overloaded x2
        public void set_SecureRandom(){} // RVA: 0x7FFAC2F4F890
        public void set_Password(){} // RVA: 0x7FFAC2F22E30
        public void set_IterationCount(){} // RVA: 0x7FFAC35DB7A0
        public void Generate(){} // RVA: 0x7FFACBF4F280
        public void .cctor(){} // RVA: 0x7FFACBF4F500
    }

}