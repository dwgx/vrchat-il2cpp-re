// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
// Classes: 9
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
    public class AdditionalInformationSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString Information; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD9EAF0
        public void .ctor(){} // RVA: 0x7FFACBD9ECB0 | overloaded x2
        public void get_Information(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class AdmissionSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName AdmissionAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence contentsOfAdmissions; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD9FE50
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA0280
        public void get_AdmissionAuthority(){} // RVA: 0x7FFAC2F3C380
        public void GetContentsOfAdmissions(){} // RVA: 0x7FFACBDA0430
    }

    public class Admissions : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName AdmissionAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority NamingAuthority; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence professionInfos; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD9ED70
        public void .ctor(){} // RVA: 0x7FFACBD9F6D0 | overloaded x2
        public void get_AdmissionAuthority(){} // RVA: 0x7FFAC2F3C380
        public void get_NamingAuthority(){} // RVA: 0x7FFAC2F247C0
        public void GetProfessionInfos(){} // RVA: 0x7FFACBD9F840
        public void ToAsn1Object(){} // RVA: 0x7FFACBD9FBB0
    }

    public class DeclarationOfMajority : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1TaggedObject Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDA0CD0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBDA0A30
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void get_Type(){} // RVA: 0x7FFAC83D27B0
        public void get_NotYoungerThan(){} // RVA: 0x7FFACBDA0DD0
        public void get_FullAgeAtCountry(){} // RVA: 0x7FFACBDA0E60
        public void get_DateOfBirth(){} // RVA: 0x7FFACBDA0EA0
    }

    public class MonetaryLimit : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerPrintableString Currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA0EE0
        public void .ctor(){} // RVA: 0x7FFACBDA12B0 | overloaded x2
        public void get_Currency(){} // RVA: 0x7FFAC84AA530
        public void get_Amount(){} // RVA: 0x7FFACBD5B400
        public void get_Exponent(){} // RVA: 0x7FFACBD5B420
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA1470
    }

    public class NamingAuthority : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NamingAuthorityID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NamingAuthorityText; // 0x10
        public string NamingAuthorityUrl; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString namingAuthorityText; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA17A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void get_NamingAuthorityID(){} // RVA: 0x7FFAC2F3C380
        public void get_NamingAuthorityText(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NamingAuthorityUrl(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA1E60
        public void .cctor(){} // RVA: 0x7FFACBDA20D0
    }

    public class ProcurationSyntax : Asn1Encodable
    {
        public string Country; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString TypeOfSubstitution; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName ThirdPerson; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial CertRef; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA2220
        public void .ctor(){} // RVA: 0x7FFACBD59D40 | overloaded x3
        public void get_Country(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeOfSubstitution(){} // RVA: 0x7FFAC2F247C0
        public void get_ThirdPerson(){} // RVA: 0x7FFAC2F4F0C0
        public void get_CertRef(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA2760
    }

    public class ProfessionInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AddProfessionInfo;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NamingAuthority; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RegistrationNumber; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerberaterin; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerberater; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerbevollmchtigte; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerbevollmchtigter; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notarin; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notar; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notarvertreterin; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notarvertreter; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notariatsverwalterin; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Notariatsverwalter; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Wirtschaftsprferin; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Wirtschaftsprfer; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VereidigteBuchprferin; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier VereidigterBuchprfer; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Patentanwltin; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Patentanwalt; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence professionItems; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence professionOids; // 0x20
        public string registrationNumber; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString addProfessionInfo; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA2B60
        public void .ctor(){} // RVA: 0x7FFACBDA36A0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFACBDA38D0
        public void get_AddProfessionInfo(){} // RVA: 0x7FFAC31D95E0
        public void get_NamingAuthority(){} // RVA: 0x7FFAC2F3C380
        public void GetProfessionItems(){} // RVA: 0x7FFACBDA3C10
        public void GetProfessionOids(){} // RVA: 0x7FFACBDA3DB0
        public void get_RegistrationNumber(){} // RVA: 0x7FFAC2F4F130
        public void .cctor(){} // RVA: 0x7FFACBDA3F90
    }

    public class Restriction : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString RestrictionString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDA5310
        public void .ctor(){} // RVA: 0x7FFACBDA54D0 | overloaded x2
        public void get_RestrictionString(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

}