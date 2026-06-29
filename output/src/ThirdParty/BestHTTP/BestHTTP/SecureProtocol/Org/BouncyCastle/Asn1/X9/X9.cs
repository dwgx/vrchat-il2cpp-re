// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
// Classes: 16
// Methods: 86

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
    public class DHDomainParameters : Asn1Encodable
    {
        public object p;
        public object g;
        public object q;
        public object j;
        public object validationParms;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B5F30
        public void .ctor(){} // RVA: 0xA3B6250
        public void GetNext(){} // RVA: 0xA3B6560
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_G(){} // RVA: 0xB465B0
        public void get_Q(){} // RVA: 0xB700F0
        public void get_J(){} // RVA: 0xB70160
        public void get_ValidationParms(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA3B6620
    }

    public class DHPublicKey : Asn1Encodable
    {
        public object y;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B6910
        public void .ctor(){} // RVA: 0xA3B6B20
        public void get_Y(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class DHValidationParms : Asn1Encodable
    {
        public object seed;
        public object pgenCounter;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B6BF0
        public void .ctor(){} // RVA: 0xA3B6F30
        public void get_Seed(){} // RVA: 0xB5DBF0
        public void get_PgenCounter(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3B7130
    }

    public class ECNamedCurveTable : Object
    {
        // ── Methods ──
        public void GetByName(){} // RVA: 0xA3B7240
        public void GetName(){} // RVA: 0xA3B77D0
        public void GetOid(){} // RVA: 0xA3B7D70
        public void GetByOid(){} // RVA: 0xA3B7FE0
        public void get_Names(){} // RVA: 0xA3B8150
        public void FromDomainParameters(){} // RVA: 0xA3B8BE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class KeySpecificInfo : Asn1Encodable
    {
        public object algorithm;
        public object counter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B8CB0
        public void get_Algorithm(){} // RVA: 0xB5DBF0
        public void get_Counter(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3B8F60
    }

    public class OtherInfo : Asn1Encodable
    {
        public object keyInfo;
        public object partyAInfo;
        public object suppPubInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B9070
        public void get_KeyInfo(){} // RVA: 0xB5DBF0
        public void get_PartyAInfo(){} // RVA: 0xB465B0
        public void get_SuppPubInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3B94F0
    }

    public class X962NamedCurves : Object
    {
        public object objIds;
        public object curves;
        public object names;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ConfigureBasepoint(){} // RVA: 0xA3B97C0
        public void ConfigureCurve(){} // RVA: 0x2303260
        public void DefineCurve(){} // RVA: 0xA3B98B0
        public void .cctor(){} // RVA: 0xA3B9A00
        public void GetByName(){} // RVA: 0xA3BA700
        public void GetByOid(){} // RVA: 0xA3BA780
        public void GetOid(){} // RVA: 0xA3BA870
        public void GetName(){} // RVA: 0xA3BA990
        public void get_Names(){} // RVA: 0xA3BAA40
    }

    public class X962Parameters : Asn1Encodable
    {
        public object _params;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3BED80
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsNamedCurve(){} // RVA: 0xA3BF0B0
        public void get_IsImplicitlyCA(){} // RVA: 0xA3BF130
        public void get_Parameters(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class X9Curve : Asn1Encodable
    {
        public object curve;
        public object seed;
        public object fieldIdentifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3BF550
        public void get_Curve(){} // RVA: 0xB5DBF0
        public void GetSeed(){} // RVA: 0xA3BFFA0
        public void ToAsn1Object(){} // RVA: 0xA3C0050
    }

    public class X9ECParameters : Asn1Encodable
    {
        public object fieldID;
        public object curve;
        public object g;
        public object n;
        public object h;
        public object seed;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C0440
        public void .ctor(){} // RVA: 0xA3C0CF0
        public void get_Curve(){} // RVA: 0xB465B0
        public void get_G(){} // RVA: 0xA3C1230
        public void get_N(){} // RVA: 0xB70160
        public void get_H(){} // RVA: 0xD33E60
        public void GetSeed(){} // RVA: 0xD05CA0
        public void get_CurveEntry(){} // RVA: 0xA3C1250
        public void get_FieldIDEntry(){} // RVA: 0xB5DBF0
        public void get_BaseEntry(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3C12C0
    }

    public class X9ECParametersHolder : Object
    {
        public object parameters;

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0xA3C1830
        public void CreateParameters(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X9ECPoint : Asn1Encodable
    {
        public object encoding;
        public object c;
        public object p;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3C1E10
        public void GetPointEncoding(){} // RVA: 0xA3C1E60
        public void get_Point(){} // RVA: 0xA3C1F40
        public void get_IsPointCompressed(){} // RVA: 0xA3C2020
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class X9FieldElement : Asn1Encodable
    {
        public object f;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3C21C0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA3C2320
    }

    public class X9FieldID : Asn1Encodable
    {
        public object id;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3C2D00
        public void GetInstance(){} // RVA: 0xA3C2E70
        public void get_Identifier(){} // RVA: 0xB5DBF0
        public void get_Parameters(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3C30B0
    }

    public class X9IntegerConverter : Object
    {
        // ── Methods ──
        public void GetByteLength(){} // RVA: 0xA3C3200
        public void IntegerToBytes(){} // RVA: 0xA3C3240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X9ObjectIdentifiers : Object
    {
        public object AnsiX962;
        public object ansi_X9_62;
        public object IdFieldType;
        public object PrimeField;
        public object CharacteristicTwoField;
        public object GNBasis;
        public object TPBasis;
        public object PPBasis;
        public object IdECSigType;
        public object id_ecSigType;
        public object ECDsaWithSha1;
        public object IdPublicKeyType;
        public object id_publicKeyType;
        public object IdECPublicKey;
        public object ECDsaWithSha2;
        public object ECDsaWithSha224;
        public object ECDsaWithSha256;
        public object ECDsaWithSha384;
        public object ECDsaWithSha512;
        public object EllipticCurve;
        public object CTwoCurve;
        public object C2Pnb163v1;
        public object C2Pnb163v2;
        public object C2Pnb163v3;
        public object C2Pnb176w1;
        public object C2Tnb191v1;
        public object C2Tnb191v2;
        public object C2Tnb191v3;
        public object C2Onb191v4;
        public object C2Onb191v5;
        public object C2Pnb208w1;
        public object C2Tnb239v1;
        public object C2Tnb239v2;
        public object C2Tnb239v3;
        public object C2Onb239v4;
        public object C2Onb239v5;
        public object C2Pnb272w1;
        public object C2Pnb304w1;
        public object C2Tnb359v1;
        public object C2Pnb368w1;
        public object C2Tnb431r1;
        public object PrimeCurve;
        public object Prime192v1;
        public object Prime192v2;
        public object Prime192v3;
        public object Prime239v1;
        public object Prime239v2;
        public object Prime239v3;
        public object Prime256v1;
        public object IdDsa;
        public object IdDsaWithSha1;
        public object X9x63Scheme;
        public object DHSinglePassStdDHSha1KdfScheme;
        public object DHSinglePassCofactorDHSha1KdfScheme;
        public object MqvSinglePassSha1KdfScheme;
        public object ansi_x9_42;
        public object DHPublicNumber;
        public object X9x42Schemes;
        public object DHStatic;
        public object DHEphem;
        public object DHOneFlow;
        public object DHHybrid1;
        public object DHHybrid2;
        public object DHHybridOneFlow;
        public object Mqv2;
        public object Mqv1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3C3320
    }

}