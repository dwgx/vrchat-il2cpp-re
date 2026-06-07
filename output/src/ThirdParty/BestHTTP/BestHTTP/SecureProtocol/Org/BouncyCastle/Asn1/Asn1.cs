// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
// Classes: 82
// Methods: 552

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
    public class Asn1Encodable
    {
        // ── Methods ──
        public void GetEncoded(){} // RVA: 0x96C7890 | overloaded x2
        public void GetDerEncoded(){} // RVA: 0x96C79D0
        public void GetHashCode(){} // RVA: 0x96C7A20
        public void Equals(){} // RVA: 0x96C7A60
        public void ToAsn1Object(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Asn1EncodableVector
    {
        // ── Methods ──
        public void FromEnumerable(){} // RVA: 0x96C7B50
        public void .ctor(){} // RVA: 0x96C7FE0 | overloaded x3
        public void Add(){} // RVA: 0x96C8120 | overloaded x2
        public void AddOptional(){} // RVA: 0x96C8270
        public void AddOptionalTagged(){} // RVA: 0x96C82D0
        public void AddAll(){} // RVA: 0x96C8370
        public void get_Item(){} // RVA: 0x96C8580
        public void get_Count(){} // RVA: 0x5BED50
        public void GetEnumerator(){} // RVA: 0x96C8650
        public void CopyElements(){} // RVA: 0x96C8720
        public void TakeElements(){} // RVA: 0x96C87E0
        public void Reallocate(){} // RVA: 0x96C88C0
        public void CloneElements(){} // RVA: 0x96C89D0
        public void .cctor(){} // RVA: 0x96C8A90
    }

    public class Asn1Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x3
    }

    public class Asn1Generator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Out(){} // RVA: 0x2F8380
        public void AddObject(){} // RVA: 0x24B10
        public void GetRawOutputStream(){} // RVA: 0xCD60
        public void Close(){} // RVA: 0x24A50
    }

    public class Asn1InputStream
    {
        // ── Methods ──
        public void FindLimit(){} // RVA: 0x96C8B40
        public void .ctor(){} // RVA: 0x96C8DA0 | overloaded x3
        public void BuildObject(){} // RVA: 0x96C8E30
        public void ReadVector(){} // RVA: 0x96C9140
        public void CreateDerSequence(){} // RVA: 0x96C93F0
        public void CreateDerSet(){} // RVA: 0x96C9470
        public void ReadObject(){} // RVA: 0x96C95C0
        public void ReadTagNumber(){} // RVA: 0x96C9C20
        public void ReadLength(){} // RVA: 0x96C9D40
        public void GetBuffer(){} // RVA: 0x96C9FB0
        public void CreatePrimitiveDerObject(){} // RVA: 0x96CA090
    }

    public class Asn1Null
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ToString(){} // RVA: 0x96CA750
    }

    public class Asn1Object
    {
        // ── Methods ──
        public void FromByteArray(){} // RVA: 0x96CA790
        public void FromStream(){} // RVA: 0x96CA930
        public void ToAsn1Object(){} // RVA: 0x1A3F520
        public void Encode(){} // RVA: 0x24B10
        public void Asn1Equals(){} // RVA: 0xDE40
        public void Asn1GetHashCode(){} // RVA: 0xD840
        public void CallAsn1Equals(){} // RVA: 0x4EE62A0
        public void CallAsn1GetHashCode(){} // RVA: 0x950560
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Asn1OctetString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96CAAD0 | overloaded x2
        public void .ctor(){} // RVA: 0x96CAD50 | overloaded x2
        public void GetOctetStream(){} // RVA: 0x96CAE80
        public void get_Parser(){} // RVA: 0x1A3F520
        public void GetOctets(){} // RVA: 0x2F8380
        public void Asn1GetHashCode(){} // RVA: 0x96CAEE0
        public void Asn1Equals(){} // RVA: 0x96CAF90
        public void ToString(){} // RVA: 0x96CB110
    }

    public class Asn1OctetStringParser
    {
        // ── Methods ──
        public void GetOctetStream(){} // RVA: 0xCD60
    }

    public class Asn1OutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B6610
        public void WriteObject(){} // RVA: 0x96CB1D0
    }

    public class Asn1ParsingException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E9B1D0 | overloaded x3
    }

    public class Asn1Sequence
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96CB7B0 | overloaded x2
        public void .ctor(){} // RVA: 0x96CBE00 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x1CA8480
        public void get_Parser(){} // RVA: 0x96CBEB0
        public void get_Item(){} // RVA: 0x6AD84E0
        public void get_Count(){} // RVA: 0xF3F910
        public void ToArray(){} // RVA: 0x96CBF80
        public void Asn1GetHashCode(){} // RVA: 0x96CBFE0
        public void Asn1Equals(){} // RVA: 0x96CC090
        public void ToString(){} // RVA: 0x96CC230
    }

    public class Asn1SequenceParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0xCD60
    }

    public class Asn1Set
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96CC820 | overloaded x2
        public void .ctor(){} // RVA: 0x96CD0E0 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x1CA8480
        public void get_Item(){} // RVA: 0x6AD84E0
        public void get_Count(){} // RVA: 0xF3F910
        public void ToArray(){} // RVA: 0x96CD190
        public void get_Parser(){} // RVA: 0x96CD1F0
        public void Asn1GetHashCode(){} // RVA: 0x96CBFE0
        public void Asn1Equals(){} // RVA: 0x96CD2C0
        public void Sort(){} // RVA: 0x96CD460
        public void ToString(){} // RVA: 0x96CC230
    }

    public class Asn1SetParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0xCD60
    }

    public class Asn1StreamParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CDBA0 | overloaded x3
        public void ReadIndef(){} // RVA: 0x96CDC30
        public void ReadImplicit(){} // RVA: 0x96CDDE0
        public void ReadTaggedObject(){} // RVA: 0x96CE130
        public void ReadObject(){} // RVA: 0x96CE510
        public void Set00Check(){} // RVA: 0x96CEBA0
        public void ReadVector(){} // RVA: 0x96CEC60
    }

    public class Asn1TaggedObject
    {
        // ── Methods ──
        public void IsConstructed(){} // RVA: 0x96CEE80
        public void GetInstance(){} // RVA: 0x96CF070 | overloaded x2
        public void .ctor(){} // RVA: 0x96CF200 | overloaded x2
        public void Asn1Equals(){} // RVA: 0x96CF2D0
        public void Asn1GetHashCode(){} // RVA: 0x96CF400
        public void get_TagNo(){} // RVA: 0x32A5C0
        public void IsExplicit(){} // RVA: 0x42CBD0
        public void IsEmpty(){} // RVA: 0x2DD320
        public void GetObject(){} // RVA: 0x96CF440
        public void GetObjectParser(){} // RVA: 0x96CF470
        public void ToString(){} // RVA: 0x96CF590
    }

    public class Asn1TaggedObjectParser : ?
    {
        // ── Methods ──
        public void get_TagNo(){} // RVA: 0xD840
        public void GetObjectParser(){}
    }

    public class Asn1Tags
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CF640
    }

    public class BerApplicationSpecificParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void ReadObject(){} // RVA: 0x96CF650
        public void ToAsn1Object(){} // RVA: 0x96CF680
    }

    public class BerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CF850 | overloaded x4
        public void Encode(){} // RVA: 0x96CF8D0
    }

    public class BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CFA20 | overloaded x2
        public void AddObject(){} // RVA: 0x96CFA80
        public void GetRawOutputStream(){} // RVA: 0x2F8380
        public void Close(){} // RVA: 0x96CFB10
        public void WriteHdr(){} // RVA: 0x96CFB20
        public void WriteBerHeader(){} // RVA: 0x96CFB70
        public void WriteBerBody(){} // RVA: 0x96CFC50
        public void WriteBerEnd(){} // RVA: 0x96CFD20
    }

    public class BerNull
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CFEA0 | overloaded x2
        public void Encode(){} // RVA: 0x96CFF00
        public void .cctor(){} // RVA: 0x96D0030
    }

    public class BerOctetString
    {
        // ── Methods ──
        public void FromSequence(){} // RVA: 0x96D0120
        public void ToBytes(){} // RVA: 0x96D0470
        public void .ctor(){} // RVA: 0x96D0890 | overloaded x4
        public void GetOctets(){} // RVA: 0x2F8380
        public void GetEnumerator(){} // RVA: 0x96D08D0
        public void GetObjects(){} // RVA: 0x96D0950
        public void GenerateOcts(){} // RVA: 0x96D0960
        public void Encode(){} // RVA: 0x96D0BD0
    }

    public class BerOctetStringGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D0FD0 | overloaded x2
        public void GetOctetOutputStream(){} // RVA: 0x96D11C0 | overloaded x3
    }

    public class BerOctetStringParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetOctetStream(){} // RVA: 0x96D16F0
        public void ToAsn1Object(){} // RVA: 0x96D17C0
    }

    public class BerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B6610
        public void WriteObject(){} // RVA: 0x96D1A10
    }

    public class BerSequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x96D1C10
        public void .ctor(){} // RVA: 0x96D1DC0 | overloaded x4
        public void Encode(){} // RVA: 0x96D1EC0
        public void .cctor(){} // RVA: 0x96D2210
    }

    public class BerSequenceGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D2370 | overloaded x2
    }

    public class BerSequenceParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ReadObject(){} // RVA: 0x7F01B0
        public void ToAsn1Object(){} // RVA: 0x96D2480
    }

    public class BerSet
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x96D25A0 | overloaded x2
        public void .ctor(){} // RVA: 0x96D2800 | overloaded x4
        public void Encode(){} // RVA: 0x96D2920
        public void .cctor(){} // RVA: 0x96D2C70
    }

    public class BerSetGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D2DD0 | overloaded x2
    }

    public class BerSetParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ReadObject(){} // RVA: 0x7F01B0
        public void ToAsn1Object(){} // RVA: 0x96D2EE0
    }

    public class BerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D3030 | overloaded x3
        public void Encode(){} // RVA: 0x96D30B0
    }

    public class BerTaggedObjectParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D3870 | overloaded x2
        public void get_IsConstructed(){} // RVA: 0x3A75E0
        public void get_TagNo(){} // RVA: 0x8ABED0
        public void GetObjectParser(){} // RVA: 0x96D38D0
        public void ToAsn1Object(){} // RVA: 0x96D3980
    }

    public class ConstructedOctetStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D3A30
        public void Read(){} // RVA: 0x96D3AD0
        public void ReadByte(){} // RVA: 0x96D3DD0
    }

    public class DefiniteLengthInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D40A0
        public void get_Remaining(){} // RVA: 0x37E0A0
        public void ReadByte(){} // RVA: 0x96D4150
        public void Read(){} // RVA: 0x96D4270
        public void ReadAllIntoByteArray(){} // RVA: 0x96D43F0
        public void ToArray(){} // RVA: 0x96D4590
        public void .cctor(){} // RVA: 0x96D4770
    }

    public class DerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D4AF0 | overloaded x5
        public void GetLengthOfHeader(){} // RVA: 0x96D4CB0
        public void IsConstructed(){} // RVA: 0x3A75E0
        public void GetContents(){} // RVA: 0x2E07C0
        public void get_ApplicationTag(){} // RVA: 0x8ABED0
        public void GetObject(){} // RVA: 0x96D4D90 | overloaded x2
        public void Encode(){} // RVA: 0x96D4F80
        public void Asn1Equals(){} // RVA: 0x96D5000
        public void Asn1GetHashCode(){} // RVA: 0x96D50E0
        public void ReplaceTagNumber(){} // RVA: 0x96D51C0
    }

    public class DerBitString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96D55A0 | overloaded x2
        public void .ctor(){} // RVA: 0x96D5A80 | overloaded x4
        public void GetOctets(){} // RVA: 0x96D5AC0
        public void GetBytes(){} // RVA: 0x96D5BC0
        public void get_PadBits(){} // RVA: 0x5BED50
        public void get_IntValue(){} // RVA: 0x96D5CC0
        public void Encode(){} // RVA: 0x96D5DB0
        public void Asn1GetHashCode(){} // RVA: 0x96D5F60
        public void Asn1Equals(){} // RVA: 0x96D6010
        public void GetString(){} // RVA: 0x96D6170
        public void FromAsn1Octets(){} // RVA: 0x96D63B0
        public void .cctor(){} // RVA: 0x96D6590
    }

    public class DerBmpString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96D6790 | overloaded x2
        public void .ctor(){} // RVA: 0x96D6B10 | overloaded x2
        public void GetString(){} // RVA: 0x2F8380
        public void Asn1Equals(){} // RVA: 0x96D6BC0
        public void Encode(){} // RVA: 0x96D6CA0
    }

    public class DerBoolean
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96D6FA0 | overloaded x3
        public void .ctor(){} // RVA: 0x96D7190 | overloaded x2
        public void get_IsTrue(){} // RVA: 0x96D71B0
        public void Encode(){} // RVA: 0x96D71C0
        public void Asn1Equals(){} // RVA: 0x96D7290
        public void Asn1GetHashCode(){} // RVA: 0x96D7330
        public void ToString(){} // RVA: 0x96D7380
        public void FromOctetString(){} // RVA: 0x96D73E0
        public void .cctor(){} // RVA: 0x96D7590
    }

    public class DerEnumerated
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96D7800 | overloaded x2
        public void .ctor(){} // RVA: 0x96D7AA0 | overloaded x3
        public void get_Value(){} // RVA: 0x96D7C50
        public void Encode(){} // RVA: 0x96D7CD0
        public void Asn1Equals(){} // RVA: 0x96D7D50
        public void Asn1GetHashCode(){} // RVA: 0x96D7EA0
        public void FromOctetString(){} // RVA: 0x96D7F40
        public void .cctor(){} // RVA: 0x96D8230
    }

    public class DerExternal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D88A0 | overloaded x3
        public void Encode(){} // RVA: 0x96D8A40
        public void Asn1GetHashCode(){} // RVA: 0x96D8CD0
        public void Asn1Equals(){} // RVA: 0x96D8D80
        public void get_DataValueDescriptor(){} // RVA: 0x30B0C0
        public void set_DataValueDescriptor(){} // RVA: 0x30B0D0
        public void get_DirectReference(){} // RVA: 0x2F8380
        public void set_DirectReference(){} // RVA: 0x2DEE30
        public void get_Encoding(){} // RVA: 0x791DC0
        public void set_Encoding(){} // RVA: 0x96D8F00
        public void get_ExternalContent(){} // RVA: 0x6374D0
        public void set_ExternalContent(){} // RVA: 0x30B890
        public void get_IndirectReference(){} // RVA: 0x2E07C0
        public void set_IndirectReference(){} // RVA: 0x343E80
        public void GetObjFromVector(){} // RVA: 0x96D8FA0
        public void WriteEncodable(){} // RVA: 0x96D9050
    }

    public class DerExternalParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ReadObject(){} // RVA: 0x7F01B0
        public void ToAsn1Object(){} // RVA: 0x96D90B0
    }

    public class DerGeneralString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DA600 | overloaded x2
        public void .ctor(){} // RVA: 0x96DA940 | overloaded x2
        public void GetString(){} // RVA: 0x2F8380
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x96DA9F0
        public void Asn1Equals(){} // RVA: 0x96DAAA0
    }

    public class DerGeneralizedTime
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96D9260 | overloaded x2
        public void .ctor(){} // RVA: 0x96D95B0 | overloaded x3
        public void get_TimeString(){} // RVA: 0x2F8380
        public void GetTime(){} // RVA: 0x96D9660
        public void CalculateGmtOffset(){} // RVA: 0x96D9920
        public void Convert(){} // RVA: 0x96D9C50
        public void ToDateTime(){} // RVA: 0x96D9CB0
        public void FString(){} // RVA: 0x96D9FC0
        public void ParseDateString(){} // RVA: 0x96DA0B0
        public void get_HasFractionalSeconds(){} // RVA: 0x96DA2D0
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x96DA350
        public void Asn1Equals(){} // RVA: 0x96DA400
        public void Asn1GetHashCode(){} // RVA: 0x99E0E0
    }

    public class DerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96CFA20 | overloaded x2
        public void WriteLength(){} // RVA: 0x96DAB80
        public void WriteDerEncoded(){} // RVA: 0x96DAE60 | overloaded x3
    }

    public class DerGraphicString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DB130 | overloaded x2
        public void .ctor(){} // RVA: 0x96DB270
        public void GetString(){} // RVA: 0x96DB370
        public void GetOctets(){} // RVA: 0x96DB380
        public void Encode(){} // RVA: 0x96DB430
        public void Asn1GetHashCode(){} // RVA: 0x96DB4B0
        public void Asn1Equals(){} // RVA: 0x96DB550
    }

    public class DerIA5String
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DB7C0 | overloaded x2
        public void .ctor(){} // RVA: 0x96DBAB0 | overloaded x3
        public void GetString(){} // RVA: 0x2F8380
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x96DBC10
        public void Asn1GetHashCode(){} // RVA: 0x99E0E0
        public void Asn1Equals(){} // RVA: 0x96DBCC0
        public void IsIA5String(){} // RVA: 0x96DBDA0
    }

    public class DerInteger
    {
        // ── Methods ──
        public void AllowUnsafe(){} // RVA: 0x96DBE00
        public void GetInstance(){} // RVA: 0x96DBFD0 | overloaded x2
        public void .ctor(){} // RVA: 0x96DC2C0 | overloaded x3
        public void get_Value(){} // RVA: 0x96DC470
        public void get_PositiveValue(){} // RVA: 0x96DC4F0
        public void Encode(){} // RVA: 0x96DC570
        public void Asn1GetHashCode(){} // RVA: 0x96DC5F0
        public void Asn1Equals(){} // RVA: 0x96DC690
        public void ToString(){} // RVA: 0x96DC7E0
    }

    public class DerNull
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96DC8B0 | overloaded x2
        public void Encode(){} // RVA: 0x96DC940
        public void Asn1Equals(){} // RVA: 0x96DC9C0
        public void Asn1GetHashCode(){} // RVA: 0x75BB20
        public void .cctor(){} // RVA: 0x96DCA50
    }

    public class DerNumericString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DCC20 | overloaded x2
        public void .ctor(){} // RVA: 0x96DCFD0 | overloaded x3
        public void GetString(){} // RVA: 0x2F8380
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x96DD180
        public void Asn1Equals(){} // RVA: 0x96DD230
        public void IsNumericString(){} // RVA: 0x96DD310
    }

    public class DerObjectIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DD570 | overloaded x2
        public void .ctor(){} // RVA: 0x96DDC20 | overloaded x3
        public void get_Id(){} // RVA: 0x2F8380
        public void Branch(){} // RVA: 0x96DD9D0
        public void On(){} // RVA: 0x96DDB70
        public void WriteField(){} // RVA: 0x96DDEB0 | overloaded x2
        public void DoOutput(){} // RVA: 0x96DE040
        public void GetBody(){} // RVA: 0x96DE240
        public void Encode(){} // RVA: 0x96DE450
        public void Asn1GetHashCode(){} // RVA: 0x99E0E0
        public void Asn1Equals(){} // RVA: 0x96DE4D0
        public void ToString(){} // RVA: 0x2F8380
        public void IsValidBranchID(){} // RVA: 0x96DE5B0
        public void IsValidIdentifier(){} // RVA: 0x96DE6A0
        public void MakeOidStringFromBytes(){} // RVA: 0x96DE730
        public void FromOctetString(){} // RVA: 0x96DEA00
        public void .cctor(){} // RVA: 0x96DEF80
    }

    public class DerOctetString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D0880 | overloaded x2
        public void Encode(){} // RVA: 0x96DF0C0 | overloaded x2
    }

    public class DerOctetStringParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetOctetStream(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x96DF150
    }

    public class DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96B6610
        public void WriteLength(){} // RVA: 0x96DF2F0
        public void WriteEncoded(){} // RVA: 0x96DF680 | overloaded x4
        public void WriteTag(){} // RVA: 0x96DF520
        public void WriteNull(){} // RVA: 0x96DF6F0
        public void WriteObject(){} // RVA: 0x96DF9C0 | overloaded x3
    }

    public class DerPrintableString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x96DFB50 | overloaded x2
        public void .ctor(){} // RVA: 0x96DFE10 | overloaded x3
        public void GetString(){} // RVA: 0x2F8380
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x96DFF40
        public void Asn1Equals(){} // RVA: 0x96DFFF0
        public void IsPrintableString(){} // RVA: 0x96E00D0
    }

    public class DerSequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x970AD70
        public void .ctor(){} // RVA: 0x96CBE00 | overloaded x4
        public void Encode(){} // RVA: 0x970AE60
        public void .cctor(){} // RVA: 0x970B1E0
    }

    public class DerSequenceGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x970B3A0 | overloaded x2
        public void AddObject(){} // RVA: 0x970B4D0
        public void GetRawOutputStream(){} // RVA: 0x30B0C0
        public void Close(){} // RVA: 0x970B560
    }

    public class DerSequenceParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ReadObject(){} // RVA: 0x7F01B0
        public void ToAsn1Object(){} // RVA: 0x970B5B0
    }

    public class DerSet
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x970B7B0 | overloaded x2
        public void .ctor(){} // RVA: 0x970BAE0 | overloaded x5
        public void Encode(){} // RVA: 0x970BBC0
        public void .cctor(){} // RVA: 0x970BF40
    }

    public class DerSetGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x970C100 | overloaded x2
        public void AddObject(){} // RVA: 0x970C230
        public void GetRawOutputStream(){} // RVA: 0x30B0C0
        public void Close(){} // RVA: 0x970C2C0
    }

    public class DerSetParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ReadObject(){} // RVA: 0x7F01B0
        public void ToAsn1Object(){} // RVA: 0x970C310
    }

    public class DerStringBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void GetString(){} // RVA: 0xCD60
        public void ToString(){} // RVA: 0x37EF790
        public void Asn1GetHashCode(){} // RVA: 0x970C420
    }

    public class DerT61String
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970C580 | overloaded x2
        public void .ctor(){} // RVA: 0x970C830 | overloaded x2
        public void GetString(){} // RVA: 0x2F8380
        public void Encode(){} // RVA: 0x970C8E0
        public void GetOctets(){} // RVA: 0x970C970
        public void Asn1Equals(){} // RVA: 0x970C980
    }

    public class DerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x970CA60 | overloaded x3
        public void Encode(){} // RVA: 0x970CAE0
    }

    public class DerUniversalString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970CD20 | overloaded x2
        public void .ctor(){} // RVA: 0x970CFE0
        public void GetString(){} // RVA: 0x970D090
        public void GetOctets(){} // RVA: 0x970D2D0
        public void Encode(){} // RVA: 0x970D350
        public void Asn1Equals(){} // RVA: 0x970D3D0
        public void .cctor(){} // RVA: 0x970D520
    }

    public class DerUtcTime
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970D720 | overloaded x2
        public void .ctor(){} // RVA: 0x96D95B0 | overloaded x3
        public void ToDateTime(){} // RVA: 0x970DBA0
        public void ToAdjustedDateTime(){} // RVA: 0x970DBF0
        public void ParseDateString(){} // RVA: 0x970DC40
        public void get_TimeString(){} // RVA: 0x970DCF0
        public void get_AdjustedTime(){} // RVA: 0x970E020
        public void get_AdjustedTimeString(){} // RVA: 0x970E030
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x970E0C0
        public void Asn1Equals(){} // RVA: 0x970E170
        public void Asn1GetHashCode(){} // RVA: 0x99E0E0
        public void ToString(){} // RVA: 0x2F8380
    }

    public class DerUtf8String
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970E370 | overloaded x2
        public void .ctor(){} // RVA: 0x970E580 | overloaded x2
        public void GetString(){} // RVA: 0x2F8380
        public void Asn1Equals(){} // RVA: 0x970E630
        public void Encode(){} // RVA: 0x970E710
    }

    public class DerVideotexString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970EA50 | overloaded x2
        public void .ctor(){} // RVA: 0x970EB90
        public void GetString(){} // RVA: 0x96DB370
        public void GetOctets(){} // RVA: 0x970EC90
        public void Encode(){} // RVA: 0x970ED40
        public void Asn1GetHashCode(){} // RVA: 0x970EDC0
        public void Asn1Equals(){} // RVA: 0x970EE60
    }

    public class DerVisibleString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x970F230 | overloaded x2
        public void .ctor(){} // RVA: 0x970F380 | overloaded x2
        public void GetString(){} // RVA: 0x2F8380
        public void GetOctets(){} // RVA: 0x96DA310
        public void Encode(){} // RVA: 0x970F430
        public void Asn1Equals(){} // RVA: 0x970F4E0
        public void Asn1GetHashCode(){} // RVA: 0x99E0E0
    }

    public class IAsn1ApplicationSpecificParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0xCD60
    }

    public class IAsn1Choice
    {
    }

    public class IAsn1Convertible
    {
        // ── Methods ──
        public void ToAsn1Object(){} // RVA: 0xCD60
    }

    public class IAsn1String
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0xCD60
    }

    public class IndefiniteLengthInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x970F5C0
        public void SetEofOn00(){} // RVA: 0x970F600
        public void CheckForEof(){} // RVA: 0x970F610
        public void Read(){} // RVA: 0x970F6B0
        public void ReadByte(){} // RVA: 0x970F7D0
        public void RequireByte(){} // RVA: 0x970F820
    }

    public class LazyAsn1InputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96C8CA0 | overloaded x2
        public void CreateDerSequence(){} // RVA: 0x970F8A0
        public void CreateDerSet(){} // RVA: 0x970F990
    }

    public class LazyDerSequence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x970FA80
        public void Parse(){} // RVA: 0x970FB30
        public void get_Item(){} // RVA: 0x970FF60
        public void GetEnumerator(){} // RVA: 0x970FFB0
        public void get_Count(){} // RVA: 0x970FFE0
        public void Encode(){} // RVA: 0x9710010
    }

    public class LazyDerSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97101F0
        public void Parse(){} // RVA: 0x97102A0
        public void get_Item(){} // RVA: 0x97106D0
        public void GetEnumerator(){} // RVA: 0x9710720
        public void get_Count(){} // RVA: 0x9710750
        public void Encode(){} // RVA: 0x9710780
    }

    public class LimitedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9710960
        public void GetRemaining(){} // RVA: 0xFDC9F0
        public void SetParentEofDetect(){} // RVA: 0x9710A20
    }

    public class OidTokenizer
    {
        public object P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_HasMoreTokens(){} // RVA: 0x9710AE0
        public void NextToken(){} // RVA: 0x9710AF0
    }

}