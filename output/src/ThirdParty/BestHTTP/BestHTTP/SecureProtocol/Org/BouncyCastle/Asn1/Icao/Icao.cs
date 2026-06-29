// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
// Classes: 5
// Methods: 26

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
{
    public class CscaMasterList : Asn1Encodable
    {
        public object version;
        public object certList;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4438A0
        public void .ctor(){} // RVA: 0xA443D00
        public void get_Version(){} // RVA: 0xA437AF0
        public void GetCertStructs(){} // RVA: 0xA443E90
        public void CopyCertList(){} // RVA: 0xA443F10
        public void ToAsn1Object(){} // RVA: 0xA443F90
    }

    public class DataGroupHash : Asn1Encodable
    {
        public object dataGroupNumber;
        public object dataGroupHashValue;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4440D0
        public void .ctor(){} // RVA: 0xA4444C0
        public void get_DataGroupNumber(){} // RVA: 0xA437AF0
        public void get_DataGroupHashValue(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4445E0
    }

    public class IcaoObjectIdentifiers : Object
    {
        public object IdIcao;
        public object IdIcaoMrtd;
        public object IdIcaoMrtdSecurity;
        public object IdIcaoLdsSecurityObject;
        public object IdIcaoCscaMasterList;
        public object IdIcaoCscaMasterListSigningKey;
        public object IdIcaoDocumentTypeList;
        public object IdIcaoAAProtocolObject;
        public object IdIcaoExtensions;
        public object IdIcaoExtensionsNamechangekeyrollover;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4446F0
    }

    public class LdsSecurityObject : Asn1Encodable
    {
        public object UBDataGroups;
        public object version;
        public object digestAlgorithmIdentifier;
        public object datagroupHash;
        public object versionInfo;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA444DF0
        public void .ctor(){} // RVA: 0xA4455D0
        public void CheckDatagroupHashSeqSize(){} // RVA: 0xA445820
        public void get_Version(){} // RVA: 0xA41F2D0
        public void get_DigestAlgorithmIdentifier(){} // RVA: 0xB465B0
        public void GetDatagroupHash(){} // RVA: 0xB700F0
        public void get_VersionInfo(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA4458D0
    }

    public class LdsVersionInfo : Asn1Encodable
    {
        public object ldsVersion;
        public object unicodeVersion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA445DE0
        public void GetInstance(){} // RVA: 0xA445F80
        public void GetLdsVersion(){} // RVA: 0x678C250
        public void GetUnicodeVersion(){} // RVA: 0x673B450
        public void ToAsn1Object(){} // RVA: 0xA4461D0
    }

}