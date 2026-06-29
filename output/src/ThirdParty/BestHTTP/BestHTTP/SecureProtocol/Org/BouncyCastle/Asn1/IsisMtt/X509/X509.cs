// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
// Classes: 9
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IsisMtt.X509
{
    public class AdditionalInformationSyntax : Asn1Encodable
    {
        public object information;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43BA80
        public void .ctor(){} // RVA: 0xA43BC40
        public void get_Information(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class AdmissionSyntax : Asn1Encodable
    {
        public object admissionAuthority;
        public object contentsOfAdmissions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43CD90
        public void .ctor(){} // RVA: 0x17C92C0
        public void ToAsn1Object(){} // RVA: 0xA43D1C0
        public void get_AdmissionAuthority(){} // RVA: 0xB5DBF0
        public void GetContentsOfAdmissions(){} // RVA: 0xA43D370
    }

    public class Admissions : Asn1Encodable
    {
        public object admissionAuthority;
        public object namingAuthority;
        public object professionInfos;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43BD00
        public void .ctor(){} // RVA: 0xA43C5F0
        public void get_AdmissionAuthority(){} // RVA: 0xB5DBF0
        public void get_NamingAuthority(){} // RVA: 0xB465B0
        public void GetProfessionInfos(){} // RVA: 0xA43C770
        public void ToAsn1Object(){} // RVA: 0xA43CAE0
    }

    public class DeclarationOfMajority : Asn1Encodable
    {
        public object declaration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA43DC20
        public void GetInstance(){} // RVA: 0xA43D980
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void get_Type(){} // RVA: 0x66B3620
        public void get_NotYoungerThan(){} // RVA: 0xA43DD20
        public void get_FullAgeAtCountry(){} // RVA: 0xA43DDB0
        public void get_DateOfBirth(){} // RVA: 0xA43DDF0
    }

    public class MonetaryLimit : Asn1Encodable
    {
        public object currency;
        public object amount;
        public object exponent;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43DE30
        public void .ctor(){} // RVA: 0xA43E200
        public void get_Currency(){} // RVA: 0x678C250
        public void get_Amount(){} // RVA: 0xA3F7900
        public void get_Exponent(){} // RVA: 0xA3F7920
        public void ToAsn1Object(){} // RVA: 0xA43E3D0
    }

    public class NamingAuthority : Asn1Encodable
    {
        public object IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
        public object namingAuthorityID;
        public object namingAuthorityUrl;
        public object namingAuthorityText;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43E700
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_NamingAuthorityID(){} // RVA: 0xB5DBF0
        public void get_NamingAuthorityText(){} // RVA: 0xB700F0
        public void get_NamingAuthorityUrl(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA43EDC0
        public void .cctor(){} // RVA: 0xA43F040
    }

    public class ProcurationSyntax : Asn1Encodable
    {
        public object country;
        public object typeOfSubstitution;
        public object thirdPerson;
        public object certRef;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43F190
        public void .ctor(){} // RVA: 0xA3F6230
        public void get_Country(){} // RVA: 0xB5DBF0
        public void get_TypeOfSubstitution(){} // RVA: 0xB465B0
        public void get_ThirdPerson(){} // RVA: 0xB700F0
        public void get_CertRef(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA43F6D0
    }

    public class ProfessionInfo : Asn1Encodable
    {
        public object Rechtsanwltin;
        public object Rechtsanwalt;
        public object Rechtsbeistand;
        public object Steuerberaterin;
        public object Steuerberater;
        public object Steuerbevollmchtigte;
        public object Steuerbevollmchtigter;
        public object Notarin;
        public object Notar;
        public object Notarvertreterin;
        public object Notarvertreter;
        public object Notariatsverwalterin;
        public object Notariatsverwalter;
        public object Wirtschaftsprferin;
        public object Wirtschaftsprfer;
        public object VereidigteBuchprferin;
        public object VereidigterBuchprfer;
        public object Patentanwltin;
        public object Patentanwalt;
        public object namingAuthority;
        public object professionItems;
        public object professionOids;
        public object registrationNumber;
        public object addProfessionInfo;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA43FAD0
        public void .ctor(){} // RVA: 0xA440610
        public void ToAsn1Object(){} // RVA: 0xA440850
        public void get_AddProfessionInfo(){} // RVA: 0xD33E60
        public void get_NamingAuthority(){} // RVA: 0xB5DBF0
        public void GetProfessionItems(){} // RVA: 0xA440BC0
        public void GetProfessionOids(){} // RVA: 0xA440D70
        public void get_RegistrationNumber(){} // RVA: 0xB70160
        public void .cctor(){} // RVA: 0xA440F60
    }

    public class Restriction : Asn1Encodable
    {
        public object restriction;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4422E0
        public void .ctor(){} // RVA: 0xA4424A0
        public void get_RestrictionString(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

}