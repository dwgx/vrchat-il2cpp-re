// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 112

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger j; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.DHValidationParms validationParms; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1731C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1734E0 | overloaded x2
        public void GetNext(){} // RVA: 0x7FFE8A1737F0
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_Q(){} // RVA: 0x7FFE811290C0
        public void get_J(){} // RVA: 0x7FFE81129130
        public void get_ValidationParms(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1738B0
    }

    public class DHPublicKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger y; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A173B90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A173DA0
        public void get_Y(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class DHValidationParms : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString seed; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger pgenCounter; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A173E70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1741B0 | overloaded x2
        public void get_Seed(){} // RVA: 0x7FFE81116380
        public void get_PgenCounter(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1743B0
    }

    public class ECNamedCurveTable : Object
    {
        // ── Methods ──
        public void GetByName(){} // RVA: 0x7FFE8A1744C0
        public void GetName(){} // RVA: 0x7FFE8A174A50
        public void GetOid(){} // RVA: 0x7FFE8A175050
        public void GetByOid(){} // RVA: 0x7FFE8A1752C0
        public void get_Names(){} // RVA: 0x7FFE8A175430
        public void FromDomainParameters(){} // RVA: 0x7FFE8A175EC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class KeySpecificInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString counter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A175F90 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFE81116380
        public void get_Counter(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A176240
    }

    public class OtherInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.KeySpecificInfo keyInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString partyAInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString suppPubInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A176350 | overloaded x2
        public void get_KeyInfo(){} // RVA: 0x7FFE81116380
        public void get_PartyAInfo(){} // RVA: 0x7FFE810FE7C0
        public void get_SuppPubInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1767C0
    }

    public class X962NamedCurves : Object
    {
        public System.Collections.IDictionary objIds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ConfigureBasepoint(){} // RVA: 0x7FFE8A176A90
        public void ConfigureCurve(){} // RVA: 0x7FFE827C4A80
        public void DefineCurve(){} // RVA: 0x7FFE8A176B80
        public void .cctor(){} // RVA: 0x7FFE8A176CD0
        public void GetByName(){} // RVA: 0x7FFE8A1779D0
        public void GetByOid(){} // RVA: 0x7FFE8A177A50
        public void GetOid(){} // RVA: 0x7FFE8A177B40
        public void GetName(){} // RVA: 0x7FFE8A177C60
        public void get_Names(){} // RVA: 0x7FFE8A177D20
    }

    public class X962Parameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object _params; // 0x10
        public object field_1; // 0x6A4
        public object field_2; // 0x6A5

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A17C060
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsNamedCurve(){} // RVA: 0x7FFE8A17C390
        public void get_IsImplicitlyCA(){} // RVA: 0x7FFE8A17C420
        public void get_Parameters(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class X9Curve : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve curve; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A17C840 | overloaded x4
        public void get_Curve(){} // RVA: 0x7FFE81116380
        public void GetSeed(){} // RVA: 0x7FFE8A17D290
        public void ToAsn1Object(){} // RVA: 0x7FFE8A17D340
    }

    public class X9ECParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9FieldID fieldID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve curve; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECPoint g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger h; // 0x30
        public byte[] seed; // 0x38
        public object field_6; // 0x6A8

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A17D710
        public void .ctor(){} // RVA: 0x7FFE8A17DFC0 | overloaded x6
        public void get_Curve(){} // RVA: 0x7FFE810FE7C0
        public void get_G(){} // RVA: 0x7FFE8A17E550
        public void get_N(){} // RVA: 0x7FFE81129130
        public void get_H(){} // RVA: 0x7FFE8144E200
        public void GetSeed(){} // RVA: 0x7FFE8143BA80
        public void get_CurveEntry(){} // RVA: 0x7FFE8A17E570
        public void get_FieldIDEntry(){} // RVA: 0x7FFE81116380
        public void get_BaseEntry(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A17E5E0
    }

    public class X9ECParametersHolder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParameters parameters; // 0x10

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFE8A17EB50
        public void CreateParameters(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X9ECPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encoding; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve c; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A17F160 | overloaded x4
        public void GetPointEncoding(){} // RVA: 0x7FFE8A17F1B0
        public void get_Point(){} // RVA: 0x7FFE8A17F290
        public void get_IsPointCompressed(){} // RVA: 0x7FFE8A17F370
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class X9FieldElement : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement f; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A17F510 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A17F670
    }

    public class X9FieldID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A180050 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A1801C0
        public void get_Identifier(){} // RVA: 0x7FFE81116380
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A180400
    }

    public class X9IntegerConverter : Object
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0x7FFE8A180550 | overloaded x2
        public void IntegerToBytes(){} // RVA: 0x7FFE8A180590
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X9ObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A180670
    }

}