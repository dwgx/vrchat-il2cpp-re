// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
// Classes: 8
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Qualified
{
    public class BiometricData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158A880
        public void .ctor(){} // RVA: 0x7B158AC40
        public void get_TypeOfBiometricData(){} // RVA: 0x7A80F2570
        public void get_HashAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_BiometricDataHash(){} // RVA: 0x7A81052C0
        public void get_SourceDataUri(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B158AD90
    }

    public class EtsiQCObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B158B020
    }

    public class Iso4217CurrencyCode : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158B4B0
        public void .ctor(){} // RVA: 0x7B158BA40
        public void get_IsAlphabetic(){} // RVA: 0x7B158BBC0
        public void get_Alphabetic(){} // RVA: 0x7B158BC40
        public void get_Numeric(){} // RVA: 0x7B158BCD0
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class MonetaryValue : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158BD90
        public void .ctor(){} // RVA: 0x7B158C170
        public void get_Currency(){} // RVA: 0x7A80F2570
        public void get_Amount(){} // RVA: 0x7B158C310
        public void get_Exponent(){} // RVA: 0x7B158C330
        public void ToAsn1Object(){} // RVA: 0x7B158C350
    }

    public class QCStatement : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158C4B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_StatementId(){} // RVA: 0x7A80F2570
        public void get_StatementInfo(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B158C900
    }

    public class Rfc3739QCObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B158CB10
    }

    public class SemanticsInformation : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158CDD0
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_SemanticsIdentifier(){} // RVA: 0x7A80F2570
        public void GetNameRegistrationAuthorities(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B158D320
    }

    public class TypeOfBiometricData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B158D500
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_IsPredefined(){} // RVA: 0x7B158D9D0
        public void get_PredefinedBiometricType(){} // RVA: 0x7B158DA50
        public void get_BiometricDataOid(){} // RVA: 0x7B158DB10
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

}