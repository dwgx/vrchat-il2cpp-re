// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
// Classes: 8
// Methods: 49

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
{
    public class BiometricData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData TypeOfBiometricData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString BiometricDataHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String SourceDataUri; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD59980
        public void .ctor(){} // RVA: 0x7FFACBD59D40 | overloaded x3
        public void get_TypeOfBiometricData(){} // RVA: 0x7FFAC2F3C380
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_BiometricDataHash(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SourceDataUri(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD59E90
    }

    public class EtsiQCObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcs;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsQcCompliance; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsLimitValue; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsRetentionPeriod; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsQcSscd; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD5A110
    }

    public class Iso4217CurrencyCode : Asn1Encodable
    {
        public int IsAlphabetic;
        public int Alphabetic;
        public int Numeric;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5A5A0
        public void .ctor(){} // RVA: 0x7FFACBD5AB30 | overloaded x2
        public void get_IsAlphabetic(){} // RVA: 0x7FFACBD5ACB0
        public void get_Alphabetic(){} // RVA: 0x7FFACBD5AD40
        public void get_Numeric(){} // RVA: 0x7FFACBD5ADD0
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class MonetaryValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode Currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5AE90
        public void .ctor(){} // RVA: 0x7FFACBD5B270 | overloaded x2
        public void get_Currency(){} // RVA: 0x7FFAC2F3C380
        public void get_Amount(){} // RVA: 0x7FFACBD5B400
        public void get_Exponent(){} // RVA: 0x7FFACBD5B420
        public void ToAsn1Object(){} // RVA: 0x7FFACBD5B440
    }

    public class QCStatement : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier StatementId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable StatementInfo; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5B5A0
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_StatementId(){} // RVA: 0x7FFAC2F3C380
        public void get_StatementInfo(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD5B9F0
    }

    public class Rfc3739QCObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcs;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcsPkixQCSyntaxV1; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcsPkixQCSyntaxV2; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD5BBF0
    }

    public class SemanticsInformation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SemanticsIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName[] nameRegistrationAuthorities; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5BEB0
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x4
        public void get_SemanticsIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void GetNameRegistrationAuthorities(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD5C3F0
    }

    public class TypeOfBiometricData : Asn1Encodable
    {
        public int IsPredefined;
        public int PredefinedBiometricType;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable BiometricDataOid; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5C5C0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_IsPredefined(){} // RVA: 0x7FFACBD5CA90
        public void get_PredefinedBiometricType(){} // RVA: 0x7FFACBD5CB20
        public void get_BiometricDataOid(){} // RVA: 0x7FFACBD5CBE0
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

}