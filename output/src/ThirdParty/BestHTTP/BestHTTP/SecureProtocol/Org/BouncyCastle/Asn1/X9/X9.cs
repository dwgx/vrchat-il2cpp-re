// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 86

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B154A920
        public void .ctor(){} // RVA: 0x7B154AC40
        public void GetNext(){} // RVA: 0x7B154AF50
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_Q(){} // RVA: 0x7A81052C0
        public void get_J(){} // RVA: 0x7A8105330
        public void get_ValidationParms(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B154B010
    }

    public class DHPublicKey : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B154B300
        public void .ctor(){} // RVA: 0x7B154B510
        public void get_Y(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class DHValidationParms : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B154B5E0
        public void .ctor(){} // RVA: 0x7B154B920
        public void get_Seed(){} // RVA: 0x7A80F2570
        public void get_PgenCounter(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B154BB20
    }

    public class ECNamedCurveTable : Object
    {
        // ── Methods ──
        public void GetByName(){} // RVA: 0x7B154BC30
        public void GetName(){} // RVA: 0x7B154C1C0
        public void GetOid(){} // RVA: 0x7B154C7D0
        public void GetByOid(){} // RVA: 0x7B154CA40
        public void get_Names(){} // RVA: 0x7B154CBB0
        public void FromDomainParameters(){} // RVA: 0x7B154D640
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class KeySpecificInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B154D710
        public void get_Algorithm(){} // RVA: 0x7A80F2570
        public void get_Counter(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B154D9C0
    }

    public class OtherInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B154DAD0
        public void get_KeyInfo(){} // RVA: 0x7A80F2570
        public void get_PartyAInfo(){} // RVA: 0x7A80DA7B0
        public void get_SuppPubInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B154DF50
    }

    public class X962NamedCurves : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ConfigureBasepoint(){} // RVA: 0x7B154E220
        public void ConfigureCurve(){} // RVA: 0x7A97F8BA0
        public void DefineCurve(){} // RVA: 0x7B154E310
        public void .cctor(){} // RVA: 0x7B154E460
        public void GetByName(){} // RVA: 0x7B154F160
        public void GetByOid(){} // RVA: 0x7B154F1E0
        public void GetOid(){} // RVA: 0x7B154F2D0
        public void GetName(){} // RVA: 0x7B154F3F0
        public void get_Names(){} // RVA: 0x7B154F4B0
    }

    public class X962Parameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15537F0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_IsNamedCurve(){} // RVA: 0x7B1553B20
        public void get_IsImplicitlyCA(){} // RVA: 0x7B1553BA0
        public void get_Parameters(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class X9Curve : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1553FC0
        public void get_Curve(){} // RVA: 0x7A80F2570
        public void GetSeed(){} // RVA: 0x7B1554A10
        public void ToAsn1Object(){} // RVA: 0x7B1554AC0
    }

    public class X9ECParameters : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1554EB0
        public void .ctor(){} // RVA: 0x7B1555760
        public void get_Curve(){} // RVA: 0x7A80DA7B0
        public void get_G(){} // RVA: 0x7B1555CA0
        public void get_N(){} // RVA: 0x7A8105330
        public void get_H(){} // RVA: 0x7A83F69F0
        public void GetSeed(){} // RVA: 0x7A8292C30
        public void get_CurveEntry(){} // RVA: 0x7B1555CC0
        public void get_FieldIDEntry(){} // RVA: 0x7A80F2570
        public void get_BaseEntry(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B1555D30
    }

    public class X9ECParametersHolder : Object
    {
        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7B15562A0
        public void CreateParameters(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X9ECPoint : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1556880
        public void GetPointEncoding(){} // RVA: 0x7B15568D0
        public void get_Point(){} // RVA: 0x7B15569B0
        public void get_IsPointCompressed(){} // RVA: 0x7B1556A90
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class X9FieldElement : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1556C30
        public void get_Value(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1556D90
    }

    public class X9FieldID : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1557770
        public void GetInstance(){} // RVA: 0x7B15578E0
        public void get_Identifier(){} // RVA: 0x7A80F2570
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1557B20
    }

    public class X9IntegerConverter : Object
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0x7B1557C70
        public void IntegerToBytes(){} // RVA: 0x7B1557CB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X9ObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1557D90
    }

}