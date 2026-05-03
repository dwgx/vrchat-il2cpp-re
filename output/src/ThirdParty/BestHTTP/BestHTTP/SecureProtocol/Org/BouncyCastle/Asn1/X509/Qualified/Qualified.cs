// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
// Classes: 8
// Methods: 49

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
{
    public class BiometricData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData typeOfBiometricData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString biometricDataHash; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String sourceDataUri; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B2FA0
        public void .ctor(){} // RVA: 0x7FFE8A1B3360 | overloaded x3
        public void get_TypeOfBiometricData(){} // RVA: 0x7FFE81116380
        public void get_HashAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_BiometricDataHash(){} // RVA: 0x7FFE811290C0
        public void get_SourceDataUri(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B34B0
    }

    public class EtsiQCObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1B3730
    }

    public class Iso4217CurrencyCode : Asn1Encodable
    {
        public int AlphabeticMaxSize;
        public int NumericMinSize;
        public int NumericMaxSize;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B3BC0
        public void .ctor(){} // RVA: 0x7FFE8A1B4150 | overloaded x2
        public void get_IsAlphabetic(){} // RVA: 0x7FFE8A1B42D0
        public void get_Alphabetic(){} // RVA: 0x7FFE8A1B4360
        public void get_Numeric(){} // RVA: 0x7FFE8A1B43F0
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class MonetaryValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode currency; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger amount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger exponent; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B44B0
        public void .ctor(){} // RVA: 0x7FFE8A1B4890 | overloaded x2
        public void get_Currency(){} // RVA: 0x7FFE81116380
        public void get_Amount(){} // RVA: 0x7FFE8A1B4A20
        public void get_Exponent(){} // RVA: 0x7FFE8A1B4A40
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B4A60
    }

    public class QCStatement : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier qcStatementId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable qcStatementInfo; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B4BC0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_StatementId(){} // RVA: 0x7FFE81116380
        public void get_StatementInfo(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B5010
    }

    public class Rfc3739QCObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1B5210
    }

    public class SemanticsInformation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier semanticsIdentifier; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B54D0
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x4
        public void get_SemanticsIdentifier(){} // RVA: 0x7FFE81116380
        public void GetNameRegistrationAuthorities(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B5A10
    }

    public class TypeOfBiometricData : Asn1Encodable
    {
        public int Picture;
        public int HandwrittenSignature;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B5BE0
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_IsPredefined(){} // RVA: 0x7FFE8A1B60B0
        public void get_PredefinedBiometricType(){} // RVA: 0x7FFE8A1B6140
        public void get_BiometricDataOid(){} // RVA: 0x7FFE8A1B6200
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

}