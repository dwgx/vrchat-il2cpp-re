// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 112

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger J; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.DHValidationParms ValidationParms; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD19BA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD19EC0 | overloaded x2
        public void GetNext(){} // RVA: 0x7FFACBD1A1D0
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_Q(){} // RVA: 0x7FFAC2F4F0C0
        public void get_J(){} // RVA: 0x7FFAC2F4F130
        public void get_ValidationParms(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD1A290
    }

    public class DHPublicKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Y; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD1A570 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD1A780
        public void get_Y(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class DHValidationParms : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Seed; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger PgenCounter; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD1A850 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD1AB90 | overloaded x2
        public void get_Seed(){} // RVA: 0x7FFAC2F3C380
        public void get_PgenCounter(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD1AD90
    }

    public class ECNamedCurveTable : Object
    {
        public object Names;

        // ── Methods ──
        public void GetByName(){} // RVA: 0x7FFACBD1AEA0
        public void GetName(){} // RVA: 0x7FFACBD1B430
        public void GetOid(){} // RVA: 0x7FFACBD1BA30
        public void GetByOid(){} // RVA: 0x7FFACBD1BCA0
        public void get_Names(){} // RVA: 0x7FFACBD1BE10
        public void FromDomainParameters(){} // RVA: 0x7FFACBD1C8A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class KeySpecificInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Counter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD1C970 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_Counter(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD1CC20
    }

    public class OtherInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.KeySpecificInfo KeyInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString PartyAInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString SuppPubInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD1CD30 | overloaded x2
        public void get_KeyInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_PartyAInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_SuppPubInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD1D1A0
    }

    public class X962NamedCurves : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary curves; // 0x8
        public System.Collections.IDictionary names; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBD1D470
        public void ConfigureCurve(){} // RVA: 0x7FFAC44F81E0
        public void DefineCurve(){} // RVA: 0x7FFACBD1D560
        public void .cctor(){} // RVA: 0x7FFACBD1D6B0
        public void GetByName(){} // RVA: 0x7FFACBD1E3B0
        public void GetByOid(){} // RVA: 0x7FFACBD1E430
        public void GetOid(){} // RVA: 0x7FFACBD1E520
        public void GetName(){} // RVA: 0x7FFACBD1E640
        public void get_Names(){} // RVA: 0x7FFACBD1E700
    }

    public class X962Parameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object IsNamedCurve; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD22A40
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsNamedCurve(){} // RVA: 0x7FFACBD22D70
        public void get_IsImplicitlyCA(){} // RVA: 0x7FFACBD22E00
        public void get_Parameters(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class X9Curve : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve Curve; // 0x10
        public byte[] seed; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier fieldIdentifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD23220 | overloaded x4
        public void get_Curve(){} // RVA: 0x7FFAC2F3C380
        public void GetSeed(){} // RVA: 0x7FFACBD23C70
        public void ToAsn1Object(){} // RVA: 0x7FFACBD23D20
    }

    public class X9ECParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9FieldID Curve; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECPoint N; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger H; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger CurveEntry; // 0x30
        public byte[] FieldIDEntry; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD240F0
        public void .ctor(){} // RVA: 0x7FFACBD249A0 | overloaded x6
        public void get_Curve(){} // RVA: 0x7FFAC2F247C0
        public void get_G(){} // RVA: 0x7FFACBD24F30
        public void get_N(){} // RVA: 0x7FFAC2F4F130
        public void get_H(){} // RVA: 0x7FFAC31D95E0
        public void GetSeed(){} // RVA: 0x7FFAC31D0140
        public void get_CurveEntry(){} // RVA: 0x7FFACBD24F50
        public void get_FieldIDEntry(){} // RVA: 0x7FFAC2F3C380
        public void get_BaseEntry(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD24FC0
    }

    public class X9ECParametersHolder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParameters Parameters; // 0x10

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFACBD25530
        public void CreateParameters(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X9ECPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Point; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve IsPointCompressed; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint p; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD25B40 | overloaded x4
        public void GetPointEncoding(){} // RVA: 0x7FFACBD25B90
        public void get_Point(){} // RVA: 0x7FFACBD25C70
        public void get_IsPointCompressed(){} // RVA: 0x7FFACBD25D50
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class X9FieldElement : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD25EF0 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBD26050
    }

    public class X9FieldID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Identifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD26A30 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBD26BA0
        public void get_Identifier(){} // RVA: 0x7FFAC2F3C380
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD26DE0
    }

    public class X9IntegerConverter : Object
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0x7FFACBD26F30 | overloaded x2
        public void IntegerToBytes(){} // RVA: 0x7FFACBD26F70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X9ObjectIdentifiers : Object
    {
        public string AnsiX962;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_X9_62;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdFieldType; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeField; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CharacteristicTwoField; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GNBasis; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier TPBasis; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PPBasis; // 0x30
        public string IdECSigType;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_ecSigType; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha1; // 0x40
        public string IdPublicKeyType;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_publicKeyType; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdECPublicKey; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha2; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha224; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha256; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha384; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha512; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CTwoCurve; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v1; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v2; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v3; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb176w1; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v1; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v2; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v3; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v4; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v5; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb208w1; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v1; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v2; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v3; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v4; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v5; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb272w1; // 0x108
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb304w1; // 0x110
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb359v1; // 0x118
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb368w1; // 0x120
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb431r1; // 0x128
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeCurve; // 0x130
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v1; // 0x138
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v2; // 0x140
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v3; // 0x148
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v1; // 0x150
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v2; // 0x158
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v3; // 0x160
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Prime256v1; // 0x168
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsa; // 0x170
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha1; // 0x178
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier X9x63Scheme; // 0x180
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassStdDHSha1KdfScheme; // 0x188
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassCofactorDHSha1KdfScheme; // 0x190
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MqvSinglePassSha1KdfScheme; // 0x198
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_x9_42; // 0x1A0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHPublicNumber; // 0x1A8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier X9x42Schemes; // 0x1B0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHStatic; // 0x1B8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHEphem; // 0x1C0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHOneFlow; // 0x1C8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid1; // 0x1D0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid2; // 0x1D8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybridOneFlow; // 0x1E0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv2; // 0x1E8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv1; // 0x1F0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD27050
    }

}