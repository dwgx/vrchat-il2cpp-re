// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
// Classes: 8
// Methods: 49

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
{
    public class BiometricData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData typeOfBiometricData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString biometricDataHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String sourceDataUri; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9750BA0
        public void .ctor(){} // RVA: 0x9750F60 | overloaded x3
        public void get_TypeOfBiometricData(){} // RVA: 0x2F8380
        public void get_HashAlgorithm(){} // RVA: 0x2E07C0
        public void get_BiometricDataHash(){} // RVA: 0x30B0C0
        public void get_SourceDataUri(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97510B0
    }

    public class EtsiQCObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9751330
    }

    public class Iso4217CurrencyCode
    {
        public int AlphabeticMaxSize;
        public int NumericMinSize;
        public int NumericMaxSize;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97517C0
        public void .ctor(){} // RVA: 0x9751D50 | overloaded x2
        public void get_IsAlphabetic(){} // RVA: 0x9751ED0
        public void get_Alphabetic(){} // RVA: 0x9751F60
        public void get_Numeric(){} // RVA: 0x9751FF0
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class MonetaryValue
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97520B0
        public void .ctor(){} // RVA: 0x9752490 | overloaded x2
        public void get_Currency(){} // RVA: 0x2F8380
        public void get_Amount(){} // RVA: 0x9752620
        public void get_Exponent(){} // RVA: 0x9752640
        public void ToAsn1Object(){} // RVA: 0x9752660
    }

    public class QCStatement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier qcStatementId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable qcStatementInfo; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97527C0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_StatementId(){} // RVA: 0x2F8380
        public void get_StatementInfo(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9752C10
    }

    public class Rfc3739QCObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9752E10
    }

    public class SemanticsInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier semanticsIdentifier; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97530D0
        public void .ctor(){} // RVA: 0x343E80 | overloaded x4
        public void get_SemanticsIdentifier(){} // RVA: 0x2F8380
        public void GetNameRegistrationAuthorities(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9753610
    }

    public class TypeOfBiometricData
    {
        public int Picture;
        public int HandwrittenSignature;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97537E0
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_IsPredefined(){} // RVA: 0x9753CB0
        public void get_PredefinedBiometricType(){} // RVA: 0x9753D40
        public void get_BiometricDataOid(){} // RVA: 0x9753E00
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

}