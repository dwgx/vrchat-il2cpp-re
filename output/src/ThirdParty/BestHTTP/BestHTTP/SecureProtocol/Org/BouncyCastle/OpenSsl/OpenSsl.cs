// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
// Classes: 7
// Methods: 31

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
{
    public class IPasswordFinder
    {
        // ── Methods ──
        public void GetPassword(){} // RVA: 0x7A7E00680
    }

    public class MiscPemGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void CreatePemObject(){} // RVA: 0x7B16F58D0
        public void EncodePrivateKey(){} // RVA: 0x7B16F6120
        public void Generate(){} // RVA: 0x7B16F6BE0
    }

    public class PemException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class PemReader : PemReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7B16F6DA0
        public void ReadObject(){} // RVA: 0x7B16F6EB0
        public void ReadRsaPublicKey(){} // RVA: 0x7B16F7630
        public void ReadPublicKey(){} // RVA: 0x7B16F76D0
        public void ReadCertificate(){} // RVA: 0x7B16F7710
        public void ReadCrl(){} // RVA: 0x7B16F7810
        public void ReadCertificateRequest(){} // RVA: 0x7B16F7910
        public void ReadAttributeCertificate(){} // RVA: 0x7B16F7A10
        public void ReadPkcs7(){} // RVA: 0x7B16F7A80
        public void ReadPrivateKey(){} // RVA: 0x7B16F7B50
        public void GetCurveParameters(){} // RVA: 0x7B16F8DB0
    }

    public class PemUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B178EE10
        public void ParseDekAlgName(){} // RVA: 0x7B178F000
        public void Crypt(){} // RVA: 0x7B178F330
        public void GetCipherParameters(){} // RVA: 0x7B178F800
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PemWriter : PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151C310
        public void WriteObject(){} // RVA: 0x7B178FB80
    }

    public class Pkcs8Generator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B178FD40
        public void set_SecureRandom(){} // RVA: 0x7A8105A90
        public void set_Password(){} // RVA: 0x7A80D8E20
        public void set_IterationCount(){} // RVA: 0x7A8738180
        public void Generate(){} // RVA: 0x7B178FE00
        public void .cctor(){} // RVA: 0x7B1790080
    }

}