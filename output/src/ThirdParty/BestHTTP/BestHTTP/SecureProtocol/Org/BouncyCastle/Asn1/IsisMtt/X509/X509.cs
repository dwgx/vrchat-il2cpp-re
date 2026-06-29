// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
// Classes: 9
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
    public class AdditionalInformationSyntax : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D04E0
        public void .ctor(){} // RVA: 0x7B15D06A0
        public void get_Information(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class AdmissionSyntax : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D17F0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void ToAsn1Object(){} // RVA: 0x7B15D1C20
        public void get_AdmissionAuthority(){} // RVA: 0x7A80F2570
        public void GetContentsOfAdmissions(){} // RVA: 0x7B15D1DD0
    }

    public class Admissions : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D0760
        public void .ctor(){} // RVA: 0x7B15D1050
        public void get_AdmissionAuthority(){} // RVA: 0x7A80F2570
        public void get_NamingAuthority(){} // RVA: 0x7A80DA7B0
        public void GetProfessionInfos(){} // RVA: 0x7B15D11D0
        public void ToAsn1Object(){} // RVA: 0x7B15D1540
    }

    public class DeclarationOfMajority : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15D2680
        public void GetInstance(){} // RVA: 0x7B15D23E0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void get_Type(){} // RVA: 0x7ADA292A0
        public void get_NotYoungerThan(){} // RVA: 0x7B15D2780
        public void get_FullAgeAtCountry(){} // RVA: 0x7B15D2810
        public void get_DateOfBirth(){} // RVA: 0x7B15D2850
    }

    public class MonetaryLimit : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D2890
        public void .ctor(){} // RVA: 0x7B15D2C60
        public void get_Currency(){} // RVA: 0x7ADB00F00
        public void get_Amount(){} // RVA: 0x7B158C310
        public void get_Exponent(){} // RVA: 0x7B158C330
        public void ToAsn1Object(){} // RVA: 0x7B15D2E30
    }

    public class NamingAuthority : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D3160
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_NamingAuthorityID(){} // RVA: 0x7A80F2570
        public void get_NamingAuthorityText(){} // RVA: 0x7A81052C0
        public void get_NamingAuthorityUrl(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15D3820
        public void .cctor(){} // RVA: 0x7B15D3AA0
    }

    public class ProcurationSyntax : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D3BF0
        public void .ctor(){} // RVA: 0x7B158AC40
        public void get_Country(){} // RVA: 0x7A80F2570
        public void get_TypeOfSubstitution(){} // RVA: 0x7A80DA7B0
        public void get_ThirdPerson(){} // RVA: 0x7A81052C0
        public void get_CertRef(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B15D4130
    }

    public class ProfessionInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D4530
        public void .ctor(){} // RVA: 0x7B15D5070
        public void ToAsn1Object(){} // RVA: 0x7B15D52B0
        public void get_AddProfessionInfo(){} // RVA: 0x7A83F69F0
        public void get_NamingAuthority(){} // RVA: 0x7A80F2570
        public void GetProfessionItems(){} // RVA: 0x7B15D5620
        public void GetProfessionOids(){} // RVA: 0x7B15D57D0
        public void get_RegistrationNumber(){} // RVA: 0x7A8105330
        public void .cctor(){} // RVA: 0x7B15D59C0
    }

    public class Restriction : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15D6D40
        public void .ctor(){} // RVA: 0x7B15D6F00
        public void get_RestrictionString(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

}