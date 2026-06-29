// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
// Classes: 8
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
{
    public class BiometricData : Asn1Encodable
    {
        public object typeOfBiometricData;
        public object hashAlgorithm;
        public object biometricDataHash;
        public object sourceDataUri;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F5E70
        public void .ctor(){} // RVA: 0xA3F6230
        public void get_TypeOfBiometricData(){} // RVA: 0xB5DBF0
        public void get_HashAlgorithm(){} // RVA: 0xB465B0
        public void get_BiometricDataHash(){} // RVA: 0xB700F0
        public void get_SourceDataUri(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA3F6380
    }

    public class EtsiQCObjectIdentifiers : Object
    {
        public object IdEtsiQcs;
        public object IdEtsiQcsQcCompliance;
        public object IdEtsiQcsLimitValue;
        public object IdEtsiQcsRetentionPeriod;
        public object IdEtsiQcsQcSscd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3F6610
    }

    public class Iso4217CurrencyCode : Asn1Encodable
    {
        public object AlphabeticMaxSize;
        public object NumericMinSize;
        public object NumericMaxSize;
        public object obj;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F6AA0
        public void .ctor(){} // RVA: 0xA3F7030
        public void get_IsAlphabetic(){} // RVA: 0xA3F71B0
        public void get_Alphabetic(){} // RVA: 0xA3F7230
        public void get_Numeric(){} // RVA: 0xA3F72C0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class MonetaryValue : Asn1Encodable
    {
        public object currency;
        public object amount;
        public object exponent;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F7380
        public void .ctor(){} // RVA: 0xA3F7760
        public void get_Currency(){} // RVA: 0xB5DBF0
        public void get_Amount(){} // RVA: 0xA3F7900
        public void get_Exponent(){} // RVA: 0xA3F7920
        public void ToAsn1Object(){} // RVA: 0xA3F7940
    }

    public class QCStatement : Asn1Encodable
    {
        public object qcStatementId;
        public object qcStatementInfo;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F7AA0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_StatementId(){} // RVA: 0xB5DBF0
        public void get_StatementInfo(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3F7EF0
    }

    public class Rfc3739QCObjectIdentifiers : Object
    {
        public object IdQcs;
        public object IdQcsPkixQCSyntaxV1;
        public object IdQcsPkixQCSyntaxV2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3F8100
    }

    public class SemanticsInformation : Asn1Encodable
    {
        public object semanticsIdentifier;
        public object nameRegistrationAuthorities;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F83C0
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_SemanticsIdentifier(){} // RVA: 0xB5DBF0
        public void GetNameRegistrationAuthorities(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3F8910
    }

    public class TypeOfBiometricData : Asn1Encodable
    {
        public object Picture;
        public object HandwrittenSignature;
        public object obj;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F8AF0
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsPredefined(){} // RVA: 0xA3F8FC0
        public void get_PredefinedBiometricType(){} // RVA: 0xA3F9040
        public void get_BiometricDataOid(){} // RVA: 0xA3F9100
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

}