// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 112

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1C0DC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1C10E0 | overloaded x2
        public void GetNext(){} // RVA: 0x7FFAFC1C13F0
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_Q(){} // RVA: 0x7FFAF2DBB0C0
        public void get_J(){} // RVA: 0x7FFAF2DBB130
        public void get_ValidationParms(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1C14B0
    }

    public class DHPublicKey
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1C1790 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1C19A0
        public void get_Y(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class DHValidationParms
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1C1A70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1C1DB0 | overloaded x2
        public void get_Seed(){} // RVA: 0x7FFAF2DA8380
        public void get_PgenCounter(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1C1FB0
    }

    public class ECNamedCurveTable
    {
        public object Algorithm;

        // ── Methods ──
        public void GetByName(){} // RVA: 0x7FFAFC1C20C0
        public void GetName(){} // RVA: 0x7FFAFC1C2650
        public void GetOid(){} // RVA: 0x7FFAFC1C2C50
        public void GetByOid(){} // RVA: 0x7FFAFC1C2EC0
        public void get_Names(){} // RVA: 0x7FFAFC1C3030
        public void FromDomainParameters(){} // RVA: 0x7FFAFC1C3AC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class KeySpecificInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1C3B90 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_Counter(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1C3E40
    }

    public class OtherInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1C3F50 | overloaded x2
        public void get_KeyInfo(){} // RVA: 0x7FFAF2DA8380
        public void get_PartyAInfo(){} // RVA: 0x7FFAF2D907C0
        public void get_SuppPubInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1C43C0
    }

    public class X962NamedCurves
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ConfigureBasepoint(){} // RVA: 0x7FFAFC1C4690
        public void ConfigureCurve(){} // RVA: 0x7FFAF44EF520
        public void DefineCurve(){} // RVA: 0x7FFAFC1C4780
        public void .cctor(){} // RVA: 0x7FFAFC1C48D0
        public void GetByName(){} // RVA: 0x7FFAFC1C55D0
        public void GetByOid(){} // RVA: 0x7FFAFC1C5650
        public void GetOid(){} // RVA: 0x7FFAFC1C5740
        public void GetName(){} // RVA: 0x7FFAFC1C5860
        public void get_Names(){} // RVA: 0x7FFAFC1C5920
    }

    public class X962Parameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1C9C60
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void get_IsNamedCurve(){} // RVA: 0x7FFAFC1C9F90
        public void get_IsImplicitlyCA(){} // RVA: 0x7FFAFC1CA020
        public void get_Parameters(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class X9Curve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1CA440 | overloaded x4
        public void get_Curve(){} // RVA: 0x7FFAF2DA8380
        public void GetSeed(){} // RVA: 0x7FFAFC1CAE90
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1CAF40
    }

    public class X9ECParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1CB310
        public void .ctor(){} // RVA: 0x7FFAFC1CBBC0 | overloaded x6
        public void get_Curve(){} // RVA: 0x7FFAF2D907C0
        public void get_G(){} // RVA: 0x7FFAFC1CC150
        public void get_N(){} // RVA: 0x7FFAF2DBB130
        public void get_H(){} // RVA: 0x7FFAF30E74D0
        public void GetSeed(){} // RVA: 0x7FFAF2F476A0
        public void get_CurveEntry(){} // RVA: 0x7FFAFC1CC170
        public void get_FieldIDEntry(){} // RVA: 0x7FFAF2DA8380
        public void get_BaseEntry(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1CC1E0
    }

    public class X9ECParametersHolder
    {
        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFAFC1CC750
        public void CreateParameters(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X9ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1CCD60 | overloaded x4
        public void GetPointEncoding(){} // RVA: 0x7FFAFC1CCDB0
        public void get_Point(){} // RVA: 0x7FFAFC1CCE90
        public void get_IsPointCompressed(){} // RVA: 0x7FFAFC1CCF70
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class X9FieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1CD110 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1CD270
    }

    public class X9FieldID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1CDC50 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC1CDDC0
        public void get_Identifier(){} // RVA: 0x7FFAF2DA8380
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1CE000
    }

    public class X9IntegerConverter
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0x7FFAFC1CE150 | overloaded x2
        public void IntegerToBytes(){} // RVA: 0x7FFAFC1CE190
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X9ObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC1CE270
    }

}