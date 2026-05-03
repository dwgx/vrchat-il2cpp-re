// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
// Classes: 5
// Methods: 31

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
{
    public class CscaMasterList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FFEF0
        public void .ctor(){} // RVA: 0x7FFE8A200350 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE8A1F41A0
        public void GetCertStructs(){} // RVA: 0x7FFE8A2004E0
        public void CopyCertList(){} // RVA: 0x7FFE8A200560
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2005E0
    }

    public class DataGroupHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger dataGroupNumber; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString dataGroupHashValue; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A200720
        public void .ctor(){} // RVA: 0x7FFE8A2009A0 | overloaded x2
        public void get_DataGroupNumber(){} // RVA: 0x7FFE8A1F41A0
        public void get_DataGroupHashValue(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A200AC0
    }

    public class IcaoObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A200BD0
    }

    public class LdsSecurityObject : Asn1Encodable
    {
        public int UBDataGroups;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2012D0
        public void .ctor(){} // RVA: 0x7FFE8A201BF0 | overloaded x3
        public void CheckDatagroupHashSeqSize(){} // RVA: 0x7FFE8A201E40
        public void get_Version(){} // RVA: 0x7FFE8A1DBDD0
        public void get_DigestAlgorithmIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void GetDatagroupHash(){} // RVA: 0x7FFE811290C0
        public void get_VersionInfo(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A201EF0
    }

    public class LdsVersionInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2023F0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A202590
        public void GetLdsVersion(){} // RVA: 0x7FFE86853DF0
        public void GetUnicodeVersion(){} // RVA: 0x7FFE86802D70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A202670
    }

}