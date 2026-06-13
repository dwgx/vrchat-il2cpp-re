// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
// Classes: 9
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
    public class AdditionalInformationSyntax
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString information; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9795D10
        public void .ctor(){} // RVA: 0x9795ED0 | overloaded x2
        public void get_Information(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class AdmissionSyntax
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9797070
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x97974A0
        public void get_AdmissionAuthority(){} // RVA: 0x2F8380
        public void GetContentsOfAdmissions(){} // RVA: 0x9797650
    }

    public class Admissions
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9795F90
        public void .ctor(){} // RVA: 0x97968F0 | overloaded x2
        public void get_AdmissionAuthority(){} // RVA: 0x2F8380
        public void get_NamingAuthority(){} // RVA: 0x2E07C0
        public void GetProfessionInfos(){} // RVA: 0x9796A60
        public void ToAsn1Object(){} // RVA: 0x9796DD0
    }

    public class DeclarationOfMajority
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1TaggedObject declaration; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9797EF0 | overloaded x4
        public void GetInstance(){} // RVA: 0x9797C50
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void get_Type(){} // RVA: 0x5C3B260
        public void get_NotYoungerThan(){} // RVA: 0x9797FF0
        public void get_FullAgeAtCountry(){} // RVA: 0x9798080
        public void get_DateOfBirth(){} // RVA: 0x97980C0
    }

    public class MonetaryLimit
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerPrintableString currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9798100
        public void .ctor(){} // RVA: 0x97984D0 | overloaded x2
        public void get_Currency(){} // RVA: 0x5D12EF0
        public void get_Amount(){} // RVA: 0x9752620
        public void get_Exponent(){} // RVA: 0x9752640
        public void ToAsn1Object(){} // RVA: 0x9798690
    }

    public class NamingAuthority
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier namingAuthorityID; // 0x10
        public string namingAuthorityUrl; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97989C0 | overloaded x2
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void get_NamingAuthorityID(){} // RVA: 0x2F8380
        public void get_NamingAuthorityText(){} // RVA: 0x30B0C0
        public void get_NamingAuthorityUrl(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9799080
        public void .cctor(){} // RVA: 0x97992F0
    }

    public class ProcurationSyntax
    {
        public string country; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString typeOfSubstitution; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName thirdPerson; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial certRef; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9799440
        public void .ctor(){} // RVA: 0x9750F60 | overloaded x3
        public void get_Country(){} // RVA: 0x2F8380
        public void get_TypeOfSubstitution(){} // RVA: 0x2E07C0
        public void get_ThirdPerson(){} // RVA: 0x30B0C0
        public void get_CertRef(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x9799980
    }

    public class ProfessionInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwltin;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwalt; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsbeistand; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9799D80
        public void .ctor(){} // RVA: 0x979A8C0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x979AAF0
        public void get_AddProfessionInfo(){} // RVA: 0x6374D0
        public void get_NamingAuthority(){} // RVA: 0x2F8380
        public void GetProfessionItems(){} // RVA: 0x979AE30
        public void GetProfessionOids(){} // RVA: 0x979AFD0
        public void get_RegistrationNumber(){} // RVA: 0x30B130
        public void .cctor(){} // RVA: 0x979B1B0
    }

    public class Restriction
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString restriction; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x979C530
        public void .ctor(){} // RVA: 0x979C6F0 | overloaded x2
        public void get_RestrictionString(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

}