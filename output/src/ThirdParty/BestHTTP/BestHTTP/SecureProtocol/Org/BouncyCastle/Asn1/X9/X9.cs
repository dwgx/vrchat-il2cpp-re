// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 112

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9710DC0 | overloaded x2
        public void .ctor(){} // RVA: 0x97110E0 | overloaded x2
        public void GetNext(){} // RVA: 0x97113F0
        public void get_P(){} // RVA: 0x2F8380
        public void get_G(){} // RVA: 0x2E07C0
        public void get_Q(){} // RVA: 0x30B0C0
        public void get_J(){} // RVA: 0x30B130
        public void get_ValidationParms(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x97114B0
    }

    public class DHPublicKey
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9711790 | overloaded x2
        public void .ctor(){} // RVA: 0x97119A0
        public void get_Y(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class DHValidationParms
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9711A70 | overloaded x2
        public void .ctor(){} // RVA: 0x9711DB0 | overloaded x2
        public void get_Seed(){} // RVA: 0x2F8380
        public void get_PgenCounter(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9711FB0
    }

    public class ECNamedCurveTable
    {
        public object Algorithm;

        // ── Methods ──
        public void GetByName(){} // RVA: 0x97120C0
        public void GetName(){} // RVA: 0x9712650
        public void GetOid(){} // RVA: 0x9712C50
        public void GetByOid(){} // RVA: 0x9712EC0
        public void get_Names(){} // RVA: 0x9713030
        public void FromDomainParameters(){} // RVA: 0x9713AC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class KeySpecificInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9713B90 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_Counter(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9713E40
    }

    public class OtherInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9713F50 | overloaded x2
        public void get_KeyInfo(){} // RVA: 0x2F8380
        public void get_PartyAInfo(){} // RVA: 0x2E07C0
        public void get_SuppPubInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97143C0
    }

    public class X962NamedCurves
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ConfigureBasepoint(){} // RVA: 0x9714690
        public void ConfigureCurve(){} // RVA: 0x1A3F520
        public void DefineCurve(){} // RVA: 0x9714780
        public void .cctor(){} // RVA: 0x97148D0
        public void GetByName(){} // RVA: 0x97155D0
        public void GetByOid(){} // RVA: 0x9715650
        public void GetOid(){} // RVA: 0x9715740
        public void GetName(){} // RVA: 0x9715860
        public void get_Names(){} // RVA: 0x9715920
    }

    public class X962Parameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9719C60
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsNamedCurve(){} // RVA: 0x9719F90
        public void get_IsImplicitlyCA(){} // RVA: 0x971A020
        public void get_Parameters(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class X9Curve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x971A440 | overloaded x4
        public void get_Curve(){} // RVA: 0x2F8380
        public void GetSeed(){} // RVA: 0x971AE90
        public void ToAsn1Object(){} // RVA: 0x971AF40
    }

    public class X9ECParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x971B310
        public void .ctor(){} // RVA: 0x971BBC0 | overloaded x6
        public void get_Curve(){} // RVA: 0x2E07C0
        public void get_G(){} // RVA: 0x971C150
        public void get_N(){} // RVA: 0x30B130
        public void get_H(){} // RVA: 0x6374D0
        public void GetSeed(){} // RVA: 0x4976A0
        public void get_CurveEntry(){} // RVA: 0x971C170
        public void get_FieldIDEntry(){} // RVA: 0x2F8380
        public void get_BaseEntry(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x971C1E0
    }

    public class X9ECParametersHolder
    {
        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x971C750
        public void CreateParameters(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X9ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x971CD60 | overloaded x4
        public void GetPointEncoding(){} // RVA: 0x971CDB0
        public void get_Point(){} // RVA: 0x971CE90
        public void get_IsPointCompressed(){} // RVA: 0x971CF70
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class X9FieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x971D110 | overloaded x3
        public void get_Value(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x971D270
    }

    public class X9FieldID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x971DC50 | overloaded x4
        public void GetInstance(){} // RVA: 0x971DDC0
        public void get_Identifier(){} // RVA: 0x2F8380
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x971E000
    }

    public class X9IntegerConverter
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0x971E150 | overloaded x2
        public void IntegerToBytes(){} // RVA: 0x971E190
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X9ObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x971E270
    }

}