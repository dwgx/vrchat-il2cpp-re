// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
// Classes: 7
// Methods: 31

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
{
    public class IPasswordFinder
    {
        // ── Methods ──
        public void GetPassword(){} // RVA: 0x87C0A0
    }

    public class MiscPemGenerator : Object
    {
        public object obj;
        public object algorithm;
        public object password;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
        public void CreatePemObject(){} // RVA: 0xA560EC0
        public void EncodePrivateKey(){} // RVA: 0xA5616F0
        public void Generate(){} // RVA: 0xA5621B0
    }

    public class PemException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class PemReader : PemReader
    {
        public object pFinder;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xA562370
        public void ReadObject(){} // RVA: 0xA562480
        public void ReadRsaPublicKey(){} // RVA: 0xA562C00
        public void ReadPublicKey(){} // RVA: 0xA562CA0
        public void ReadCertificate(){} // RVA: 0xA562CE0
        public void ReadCrl(){} // RVA: 0xA562DE0
        public void ReadCertificateRequest(){} // RVA: 0xA562EE0
        public void ReadAttributeCertificate(){} // RVA: 0xA562FE0
        public void ReadPkcs7(){} // RVA: 0xA563050
        public void ReadPrivateKey(){} // RVA: 0xA563120
        public void GetCurveParameters(){} // RVA: 0xA564370
    }

    public class PemUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0xA5FB090
        public void ParseDekAlgName(){} // RVA: 0xA5FB230
        public void Crypt(){} // RVA: 0xA5FB570
        public void GetCipherParameters(){} // RVA: 0xA5FBA40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PemWriter : PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA387680
        public void WriteObject(){} // RVA: 0xA5FBDC0
    }

    public class Pkcs8Generator : Object
    {
        public object PbeSha1_RC4_128;
        public object PbeSha1_RC4_40;
        public object PbeSha1_3DES;
        public object PbeSha1_2DES;
        public object PbeSha1_RC2_128;
        public object PbeSha1_RC2_40;
        public object password;
        public object algorithm;
        public object iterationCount;
        public object privKey;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5FBF80
        public void set_SecureRandom(){} // RVA: 0xB708C0
        public void set_Password(){} // RVA: 0xB44D60
        public void set_IterationCount(){} // RVA: 0x1269760
        public void Generate(){} // RVA: 0xA5FC040
        public void .cctor(){} // RVA: 0xA5FC2C0
    }

}