// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
// Classes: 5
// Methods: 31

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
{
    public class CscaMasterList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certList; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA68D0
        public void .ctor(){} // RVA: 0x7FFACBDA6D30 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFACBD9AB80
        public void GetCertStructs(){} // RVA: 0x7FFACBDA6EC0
        public void CopyCertList(){} // RVA: 0x7FFACBDA6F40
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA6FC0
    }

    public class DataGroupHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DataGroupNumber; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString DataGroupHashValue; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA7100
        public void .ctor(){} // RVA: 0x7FFACBDA7380 | overloaded x2
        public void get_DataGroupNumber(){} // RVA: 0x7FFACBD9AB80
        public void get_DataGroupHashValue(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA74A0
    }

    public class IcaoObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcao;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoMrtd; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoMrtdSecurity; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoLdsSecurityObject; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoCscaMasterList; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoCscaMasterListSigningKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoDocumentTypeList; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoAAProtocolObject; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoExtensions; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoExtensionsNamechangekeyrollover; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDA75B0
    }

    public class LdsSecurityObject : Asn1Encodable
    {
        public int Version;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DigestAlgorithmIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier VersionInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao.DataGroupHash[] datagroupHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao.LdsVersionInfo versionInfo; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA7CB0
        public void .ctor(){} // RVA: 0x7FFACBDA85D0 | overloaded x3
        public void CheckDatagroupHashSeqSize(){} // RVA: 0x7FFACBDA8820
        public void get_Version(){} // RVA: 0x7FFACBD827B0
        public void get_DigestAlgorithmIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void GetDatagroupHash(){} // RVA: 0x7FFAC2F4F0C0
        public void get_VersionInfo(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA88D0
    }

    public class LdsVersionInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerPrintableString ldsVersion; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerPrintableString unicodeVersion; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDA8DD0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDA8F70
        public void GetLdsVersion(){} // RVA: 0x7FFAC84AA530
        public void GetUnicodeVersion(){} // RVA: 0x7FFAC8459460
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA9050
    }

}