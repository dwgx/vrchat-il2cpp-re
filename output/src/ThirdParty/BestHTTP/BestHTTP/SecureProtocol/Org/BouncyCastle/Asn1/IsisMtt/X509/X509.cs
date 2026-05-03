// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
// Classes: 9
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
    public class AdditionalInformationSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString information; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1F8110
        public void .ctor(){} // RVA: 0x7FFE8A1F82D0 | overloaded x2
        public void get_Information(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class AdmissionSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1F9470
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1F98A0
        public void get_AdmissionAuthority(){} // RVA: 0x7FFE81116380
        public void GetContentsOfAdmissions(){} // RVA: 0x7FFE8A1F9A50
    }

    public class Admissions : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1F8390
        public void .ctor(){} // RVA: 0x7FFE8A1F8CF0 | overloaded x2
        public void get_AdmissionAuthority(){} // RVA: 0x7FFE81116380
        public void get_NamingAuthority(){} // RVA: 0x7FFE810FE7C0
        public void GetProfessionInfos(){} // RVA: 0x7FFE8A1F8E60
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1F91D0
    }

    public class DeclarationOfMajority : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1TaggedObject declaration; // 0x10
        public object field_1; // 0x7ED
        public object field_2; // 0x7EE
        public object field_3; // 0x7EF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1FA2F0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A1FA050
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void get_Type(){} // RVA: 0x7FFE8677C0B0
        public void get_NotYoungerThan(){} // RVA: 0x7FFE8A1FA3F0
        public void get_FullAgeAtCountry(){} // RVA: 0x7FFE8A1FA480
        public void get_DateOfBirth(){} // RVA: 0x7FFE8A1FA4C0
    }

    public class MonetaryLimit : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerPrintableString currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FA500
        public void .ctor(){} // RVA: 0x7FFE8A1FA8D0 | overloaded x2
        public void get_Currency(){} // RVA: 0x7FFE86853DF0
        public void get_Amount(){} // RVA: 0x7FFE8A1B4A20
        public void get_Exponent(){} // RVA: 0x7FFE8A1B4A40
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FAA90
    }

    public class NamingAuthority : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier namingAuthorityID; // 0x10
        public string namingAuthorityUrl; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FADC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void get_NamingAuthorityID(){} // RVA: 0x7FFE81116380
        public void get_NamingAuthorityText(){} // RVA: 0x7FFE811290C0
        public void get_NamingAuthorityUrl(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FB480
        public void .cctor(){} // RVA: 0x7FFE8A1FB6F0
    }

    public class ProcurationSyntax : Asn1Encodable
    {
        public string country; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString typeOfSubstitution; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName thirdPerson; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial certRef; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FB840
        public void .ctor(){} // RVA: 0x7FFE8A1B3360 | overloaded x3
        public void get_Country(){} // RVA: 0x7FFE81116380
        public void get_TypeOfSubstitution(){} // RVA: 0x7FFE810FE7C0
        public void get_ThirdPerson(){} // RVA: 0x7FFE811290C0
        public void get_CertRef(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FBD80
    }

    public class ProfessionInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwltin;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwalt; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsbeistand; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FC180
        public void .ctor(){} // RVA: 0x7FFE8A1FCCC0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1FCEF0
        public void get_AddProfessionInfo(){} // RVA: 0x7FFE8144E200
        public void get_NamingAuthority(){} // RVA: 0x7FFE81116380
        public void GetProfessionItems(){} // RVA: 0x7FFE8A1FD230
        public void GetProfessionOids(){} // RVA: 0x7FFE8A1FD3D0
        public void get_RegistrationNumber(){} // RVA: 0x7FFE81129130
        public void .cctor(){} // RVA: 0x7FFE8A1FD5B0
    }

    public class Restriction : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString restriction; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1FE930
        public void .ctor(){} // RVA: 0x7FFE8A1FEAF0 | overloaded x2
        public void get_RestrictionString(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

}