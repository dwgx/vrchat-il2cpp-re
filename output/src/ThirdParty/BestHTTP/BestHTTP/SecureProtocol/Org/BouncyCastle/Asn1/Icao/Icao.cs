// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
// Classes: 5
// Methods: 26

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Icao
{
    public class CscaMasterList : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D8300
        public void .ctor(){} // RVA: 0x7B15D8760
        public void get_Version(){} // RVA: 0x7B15CC550
        public void GetCertStructs(){} // RVA: 0x7B15D88F0
        public void CopyCertList(){} // RVA: 0x7B15D8970
        public void ToAsn1Object(){} // RVA: 0x7B15D89F0
    }

    public class DataGroupHash : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D8B30
        public void .ctor(){} // RVA: 0x7B15D8F20
        public void get_DataGroupNumber(){} // RVA: 0x7B15CC550
        public void get_DataGroupHashValue(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15D9040
    }

    public class IcaoObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15D9150
    }

    public class LdsSecurityObject : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D9850
        public void .ctor(){} // RVA: 0x7B15DA030
        public void CheckDatagroupHashSeqSize(){} // RVA: 0x7B15DA280
        public void get_Version(){} // RVA: 0x7B15B3D20
        public void get_DigestAlgorithmIdentifier(){} // RVA: 0x7A80DA7B0
        public void GetDatagroupHash(){} // RVA: 0x7A81052C0
        public void get_VersionInfo(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15DA330
    }

    public class LdsVersionInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15DA840
        public void GetInstance(){} // RVA: 0x7B15DA9E0
        public void GetLdsVersion(){} // RVA: 0x7ADB00F00
        public void GetUnicodeVersion(){} // RVA: 0x7ADAB0020
        public void ToAsn1Object(){} // RVA: 0x7B15DAC30
    }

}