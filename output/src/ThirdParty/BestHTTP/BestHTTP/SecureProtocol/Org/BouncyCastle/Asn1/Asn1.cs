// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
// Classes: 82
// Methods: 552

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
    public class Asn1Encodable : Object
    {
        // ── Methods ──
        public void GetEncoded(){} // RVA: 0x7FFE8A129C70 | overloaded x2
        public void GetDerEncoded(){} // RVA: 0x7FFE8A129DB0
        public void GetHashCode(){} // RVA: 0x7FFE8A129E00
        public void Equals(){} // RVA: 0x7FFE8A129E40
        public void ToAsn1Object(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Asn1EncodableVector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] EmptyElements;
        public int DefaultCapacity;

        // ── Methods ──
        public void FromEnumerable(){} // RVA: 0x7FFE8A129F30
        public void .ctor(){} // RVA: 0x7FFE8A12A3C0 | overloaded x3
        public void Add(){} // RVA: 0x7FFE8A12A500 | overloaded x2
        public void AddOptional(){} // RVA: 0x7FFE8A12A650
        public void AddOptionalTagged(){} // RVA: 0x7FFE8A12A6B0
        public void AddAll(){} // RVA: 0x7FFE8A12A750
        public void get_Item(){} // RVA: 0x7FFE8A12A960
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void GetEnumerator(){} // RVA: 0x7FFE8A12AA30
        public void CopyElements(){} // RVA: 0x7FFE8A12AB00
        public void TakeElements(){} // RVA: 0x7FFE8A12ABC0
        public void Reallocate(){} // RVA: 0x7FFE8A12ACA0
        public void CloneElements(){} // RVA: 0x7FFE8A12ADB0
        public void .cctor(){} // RVA: 0x7FFE8A12AE70
    }

    public class Asn1Exception : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x3
    }

    public class Asn1Generator : Object
    {
        public System.IO.Stream _out; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Out(){} // RVA: 0x7FFE81116380
        public void AddObject(){} // RVA: 0x7FFE80E460A0
        public void GetRawOutputStream(){} // RVA: 0x7FFE80E2E2E0
        public void Close(){} // RVA: 0x7FFE80E45FE0
    }

    public class Asn1InputStream : FilterStream
    {
        // ── Methods ──
        public void FindLimit(){} // RVA: 0x7FFE8A12AF20
        public void .ctor(){} // RVA: 0x7FFE8A12B180 | overloaded x3
        public void BuildObject(){} // RVA: 0x7FFE8A12B210
        public void ReadVector(){} // RVA: 0x7FFE8A12B520
        public void CreateDerSequence(){} // RVA: 0x7FFE8A12B7D0
        public void CreateDerSet(){} // RVA: 0x7FFE8A12B850
        public void ReadObject(){} // RVA: 0x7FFE8A12B9A0
        public void ReadTagNumber(){} // RVA: 0x7FFE8A12C000
        public void ReadLength(){} // RVA: 0x7FFE8A12C120
        public void GetBuffer(){} // RVA: 0x7FFE8A12C390
        public void CreatePrimitiveDerObject(){} // RVA: 0x7FFE8A12C470
    }

    public class Asn1Null : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE8A12CB30
    }

    public class Asn1Object : Asn1Encodable
    {
        // ── Methods ──
        public void FromByteArray(){} // RVA: 0x7FFE8A12CB70
        public void FromStream(){} // RVA: 0x7FFE8A12CD10
        public void ToAsn1Object(){} // RVA: 0x7FFE827C4A80
        public void Encode(){} // RVA: 0x7FFE80E460A0
        public void Asn1Equals(){} // RVA: 0x7FFE80E2F3B0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CallAsn1Equals(){} // RVA: 0x7FFE85B3A4A0
        public void CallAsn1GetHashCode(){} // RVA: 0x7FFE81768340
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Asn1OctetString : Asn1Object
    {
        public byte[] str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A12CEB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A12D130 | overloaded x2
        public void GetOctetStream(){} // RVA: 0x7FFE8A12D260
        public void get_Parser(){} // RVA: 0x7FFE827C4A80
        public void GetOctets(){} // RVA: 0x7FFE81116380
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A12D2C0
        public void Asn1Equals(){} // RVA: 0x7FFE8A12D370
        public void ToString(){} // RVA: 0x7FFE8A12D4F0
    }

    public class Asn1OctetStringParser
    {
        // ── Methods ──
        public void GetOctetStream(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Asn1OutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1189F0
        public void WriteObject(){} // RVA: 0x7FFE8A12D5B0
    }

    public class Asn1ParsingException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869DC010 | overloaded x3
    }

    public class Asn1Sequence : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] elements; // 0x10
        public object field_1; // 0x673
        public object field_2; // 0x674

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A12DB90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A12E1E0 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x7FFE82A39F20
        public void get_Parser(){} // RVA: 0x7FFE8A12E290
        public void get_Item(){} // RVA: 0x7FFE876177D0
        public void get_Count(){} // RVA: 0x7FFE81CCB610
        public void ToArray(){} // RVA: 0x7FFE8A12E360
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A12E3C0
        public void Asn1Equals(){} // RVA: 0x7FFE8A12E470
        public void ToString(){} // RVA: 0x7FFE8A12E610
    }

    public class Asn1SequenceParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Asn1Set : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] elements; // 0x10
        public object field_1; // 0x676
        public object field_2; // 0x677

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A12EC00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A12F4C0 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x7FFE82A39F20
        public void get_Item(){} // RVA: 0x7FFE876177D0
        public void get_Count(){} // RVA: 0x7FFE81CCB610
        public void ToArray(){} // RVA: 0x7FFE8A12F570
        public void get_Parser(){} // RVA: 0x7FFE8A12F5D0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A12E3C0
        public void Asn1Equals(){} // RVA: 0x7FFE8A12F6A0
        public void Sort(){} // RVA: 0x7FFE8A12F840
        public void ToString(){} // RVA: 0x7FFE8A12E610
    }

    public class Asn1SetParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Asn1StreamParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A12FF80 | overloaded x3
        public void ReadIndef(){} // RVA: 0x7FFE8A130010
        public void ReadImplicit(){} // RVA: 0x7FFE8A1301C0
        public void ReadTaggedObject(){} // RVA: 0x7FFE8A130510
        public void ReadObject(){} // RVA: 0x7FFE8A1308F0
        public void Set00Check(){} // RVA: 0x7FFE8A130F80
        public void ReadVector(){} // RVA: 0x7FFE8A131040
    }

    public class Asn1TaggedObject : Asn1Object
    {
        public int tagNo; // 0x10

        // ── Methods ──
        public void IsConstructed(){} // RVA: 0x7FFE8A131260
        public void GetInstance(){} // RVA: 0x7FFE8A131450 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1315E0 | overloaded x2
        public void Asn1Equals(){} // RVA: 0x7FFE8A1316B0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A1317E0
        public void get_TagNo(){} // RVA: 0x7FFE811485C0
        public void IsExplicit(){} // RVA: 0x7FFE8124ABD0
        public void IsEmpty(){} // RVA: 0x7FFE810FB320
        public void GetObject(){} // RVA: 0x7FFE8A131820
        public void GetObjectParser(){} // RVA: 0x7FFE8A131850
        public void ToString(){} // RVA: 0x7FFE8A131970
    }

    public class Asn1TaggedObjectParser
    {
        // ── Methods ──
        public void get_TagNo(){} // RVA: 0x7FFE80E2EDB0
        public void GetObjectParser(){}
    }

    public class Asn1Tags : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BerApplicationSpecific : DerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A131A20
    }

    public class BerApplicationSpecificParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void ReadObject(){} // RVA: 0x7FFE8A131A30
        public void ToAsn1Object(){} // RVA: 0x7FFE8A131A60
    }

    public class BerBitString : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A131C30 | overloaded x4
        public void Encode(){} // RVA: 0x7FFE8A131CB0
    }

    public class BerGenerator : Asn1Generator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A131E00 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFE8A131E60
        public void GetRawOutputStream(){} // RVA: 0x7FFE81116380
        public void Close(){} // RVA: 0x7FFE8A131EF0
        public void WriteHdr(){} // RVA: 0x7FFE8A131F00
        public void WriteBerHeader(){} // RVA: 0x7FFE8A131F50
        public void WriteBerBody(){} // RVA: 0x7FFE8A132030
        public void WriteBerEnd(){} // RVA: 0x7FFE8A132100
    }

    public class BerNull : DerNull
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A132280 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A1322E0
        public void .cctor(){} // RVA: 0x7FFE8A132410
    }

    public class BerOctetString : DerOctetString
    {
        // ── Methods ──
        public void FromSequence(){} // RVA: 0x7FFE8A132500
        public void ToBytes(){} // RVA: 0x7FFE8A132850
        public void .ctor(){} // RVA: 0x7FFE8A132C70 | overloaded x4
        public void GetOctets(){} // RVA: 0x7FFE81116380
        public void GetEnumerator(){} // RVA: 0x7FFE8A132CB0
        public void GetObjects(){} // RVA: 0x7FFE8A132D30
        public void GenerateOcts(){} // RVA: 0x7FFE8A132D40
        public void Encode(){} // RVA: 0x7FFE8A132FB0
    }

    public class BerOctetStringGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1333B0 | overloaded x2
        public void GetOctetOutputStream(){} // RVA: 0x7FFE8A1335A0 | overloaded x3
    }

    public class BerOctetStringParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetOctetStream(){} // RVA: 0x7FFE8A133AD0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A133BA0
    }

    public class BerOutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1189F0
        public void WriteObject(){} // RVA: 0x7FFE8A133DF0
    }

    public class BerSequence : DerSequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFE8A133FF0
        public void .ctor(){} // RVA: 0x7FFE8A1341A0 | overloaded x4
        public void Encode(){} // RVA: 0x7FFE8A1342A0
        public void .cctor(){} // RVA: 0x7FFE8A1345F0
    }

    public class BerSequenceGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A134750 | overloaded x2
    }

    public class BerSequenceParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ReadObject(){} // RVA: 0x7FFE81588A80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A134860
    }

    public class BerSet : DerSet
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFE8A134980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A134BE0 | overloaded x4
        public void Encode(){} // RVA: 0x7FFE8A134D00
        public void .cctor(){} // RVA: 0x7FFE8A135050
    }

    public class BerSetGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1351B0 | overloaded x2
    }

    public class BerSetParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ReadObject(){} // RVA: 0x7FFE81588A80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1352C0
    }

    public class BerTaggedObject : DerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A135410 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE8A135490
    }

    public class BerTaggedObjectParser : Object
    {
        public bool _constructed; // 0x10
        public int _tagNumber; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A135C50 | overloaded x2
        public void get_IsConstructed(){} // RVA: 0x7FFE811C55E0
        public void get_TagNo(){} // RVA: 0x7FFE8164B230
        public void GetObjectParser(){} // RVA: 0x7FFE8A135CB0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A135D60
    }

    public class ConstructedOctetStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A135E10
        public void Read(){} // RVA: 0x7FFE8A135EB0
        public void ReadByte(){} // RVA: 0x7FFE8A1361B0
    }

    public class DefiniteLengthInputStream : LimitedInputStream
    {
        public byte[] EmptyBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A136480
        public void get_Remaining(){} // RVA: 0x7FFE8119C0A0
        public void ReadByte(){} // RVA: 0x7FFE8A136530
        public void Read(){} // RVA: 0x7FFE8A136650
        public void ReadAllIntoByteArray(){} // RVA: 0x7FFE8A1367D0
        public void ToArray(){} // RVA: 0x7FFE8A136970
        public void .cctor(){} // RVA: 0x7FFE8A136B50
    }

    public class DerApplicationSpecific : Asn1Object
    {
        public bool isConstructed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A136ED0 | overloaded x5
        public void GetLengthOfHeader(){} // RVA: 0x7FFE8A137090
        public void IsConstructed(){} // RVA: 0x7FFE811C55E0
        public void GetContents(){} // RVA: 0x7FFE810FE7C0
        public void get_ApplicationTag(){} // RVA: 0x7FFE8164B230
        public void GetObject(){} // RVA: 0x7FFE8A137170 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A137360
        public void Asn1Equals(){} // RVA: 0x7FFE8A1373E0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A1374C0
        public void ReplaceTagNumber(){} // RVA: 0x7FFE8A1375A0
    }

    public class DerBitString : DerStringBase
    {
        public char[] table;
        public byte[] mData; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A137980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A137E60 | overloaded x4
        public void GetOctets(){} // RVA: 0x7FFE8A137EA0
        public void GetBytes(){} // RVA: 0x7FFE8A137FA0
        public void get_PadBits(){} // RVA: 0x7FFE813DB630
        public void get_IntValue(){} // RVA: 0x7FFE8A1380A0
        public void Encode(){} // RVA: 0x7FFE8A138190
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A138340
        public void Asn1Equals(){} // RVA: 0x7FFE8A1383F0
        public void GetString(){} // RVA: 0x7FFE8A138550
        public void FromAsn1Octets(){} // RVA: 0x7FFE8A138790
        public void .cctor(){} // RVA: 0x7FFE8A138970
    }

    public class DerBmpString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A138B70 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A138EF0 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE81116380
        public void Asn1Equals(){} // RVA: 0x7FFE8A138FA0
        public void Encode(){} // RVA: 0x7FFE8A139080
    }

    public class DerBoolean : Asn1Object
    {
        public byte value; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A139380 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE8A139570 | overloaded x2
        public void get_IsTrue(){} // RVA: 0x7FFE8A139590
        public void Encode(){} // RVA: 0x7FFE8A1395A0
        public void Asn1Equals(){} // RVA: 0x7FFE8A139670
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A139710
        public void ToString(){} // RVA: 0x7FFE8A139760
        public void FromOctetString(){} // RVA: 0x7FFE8A1397C0
        public void .cctor(){} // RVA: 0x7FFE8A139970
    }

    public class DerEnumerated : Asn1Object
    {
        public byte[] bytes; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A139BE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A139E80 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFE8A13A030
        public void Encode(){} // RVA: 0x7FFE8A13A0B0
        public void Asn1Equals(){} // RVA: 0x7FFE8A13A130
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A13A280
        public void FromOctetString(){} // RVA: 0x7FFE8A13A320
        public void .cctor(){} // RVA: 0x7FFE8A13A610
    }

    public class DerExternal : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier directReference; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger indirectReference; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor; // 0x20
        public int encoding; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object externalContent; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A13AC80 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE8A13AE20
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A13B0B0
        public void Asn1Equals(){} // RVA: 0x7FFE8A13B160
        public void get_DataValueDescriptor(){} // RVA: 0x7FFE811290C0
        public void set_DataValueDescriptor(){} // RVA: 0x7FFE811290D0
        public void get_DirectReference(){} // RVA: 0x7FFE81116380
        public void set_DirectReference(){} // RVA: 0x7FFE810FCE30
        public void get_Encoding(){} // RVA: 0x7FFE81549710
        public void set_Encoding(){} // RVA: 0x7FFE8A13B2E0
        public void get_ExternalContent(){} // RVA: 0x7FFE8144E200
        public void set_ExternalContent(){} // RVA: 0x7FFE81129890
        public void get_IndirectReference(){} // RVA: 0x7FFE810FE7C0
        public void set_IndirectReference(){} // RVA: 0x7FFE81161E80
        public void GetObjFromVector(){} // RVA: 0x7FFE8A13B380
        public void WriteEncodable(){} // RVA: 0x7FFE8A13B430
    }

    public class DerExternalParser : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ReadObject(){} // RVA: 0x7FFE81588A80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A13B490
    }

    public class DerGeneralString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13C9E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13CD20 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE81116380
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A13CDD0
        public void Asn1Equals(){} // RVA: 0x7FFE8A13CE80
    }

    public class DerGeneralizedTime : Asn1Object
    {
        public string time; // 0x10
        public object field_1; // 0x688

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13B640 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13B990 | overloaded x3
        public void get_TimeString(){} // RVA: 0x7FFE81116380
        public void GetTime(){} // RVA: 0x7FFE8A13BA40
        public void CalculateGmtOffset(){} // RVA: 0x7FFE8A13BD00
        public void Convert(){} // RVA: 0x7FFE8A13C030
        public void ToDateTime(){} // RVA: 0x7FFE8A13C090
        public void FString(){} // RVA: 0x7FFE8A13C3A0
        public void ParseDateString(){} // RVA: 0x7FFE8A13C490
        public void get_HasFractionalSeconds(){} // RVA: 0x7FFE8A13C6B0
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A13C730
        public void Asn1Equals(){} // RVA: 0x7FFE8A13C7E0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class DerGenerator : Asn1Generator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A131E00 | overloaded x2
        public void WriteLength(){} // RVA: 0x7FFE8A13CF60
        public void WriteDerEncoded(){} // RVA: 0x7FFE8A13D240 | overloaded x3
    }

    public class DerGraphicString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13D510 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13D650
        public void GetString(){} // RVA: 0x7FFE8A13D750
        public void GetOctets(){} // RVA: 0x7FFE8A13D760
        public void Encode(){} // RVA: 0x7FFE8A13D810
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A13D890
        public void Asn1Equals(){} // RVA: 0x7FFE8A13D930
    }

    public class DerIA5String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13DBA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13DE90 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE81116380
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A13DFF0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8170B620
        public void Asn1Equals(){} // RVA: 0x7FFE8A13E0A0
        public void IsIA5String(){} // RVA: 0x7FFE8A13E180
    }

    public class DerInteger : Asn1Object
    {
        public string AllowUnsafeProperty;
        public byte[] bytes; // 0x10

        // ── Methods ──
        public void AllowUnsafe(){} // RVA: 0x7FFE8A13E1E0
        public void GetInstance(){} // RVA: 0x7FFE8A13E3B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13E6A0 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFE8A13E850
        public void get_PositiveValue(){} // RVA: 0x7FFE8A13E8D0
        public void Encode(){} // RVA: 0x7FFE8A13E950
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A13E9D0
        public void Asn1Equals(){} // RVA: 0x7FFE8A13EA70
        public void ToString(){} // RVA: 0x7FFE8A13EBC0
    }

    public class DerNull : Asn1Null
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A13EC90 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A13ED20
        public void Asn1Equals(){} // RVA: 0x7FFE8A13EDA0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE81517DA0
        public void .cctor(){} // RVA: 0x7FFE8A13EE30
    }

    public class DerNumericString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13F000 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13F3B0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE81116380
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A13F560
        public void Asn1Equals(){} // RVA: 0x7FFE8A13F610
        public void IsNumericString(){} // RVA: 0x7FFE8A13F6F0
    }

    public class DerObjectIdentifier : Asn1Object
    {
        public string identifier; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A13F950 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A140000 | overloaded x3
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void Branch(){} // RVA: 0x7FFE8A13FDB0
        public void On(){} // RVA: 0x7FFE8A13FF50
        public void WriteField(){} // RVA: 0x7FFE8A140290 | overloaded x2
        public void DoOutput(){} // RVA: 0x7FFE8A140420
        public void GetBody(){} // RVA: 0x7FFE8A140620
        public void Encode(){} // RVA: 0x7FFE8A140830
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8170B620
        public void Asn1Equals(){} // RVA: 0x7FFE8A1408B0
        public void ToString(){} // RVA: 0x7FFE81116380
        public void IsValidBranchID(){} // RVA: 0x7FFE8A140990
        public void IsValidIdentifier(){} // RVA: 0x7FFE8A140A80
        public void MakeOidStringFromBytes(){} // RVA: 0x7FFE8A140B10
        public void FromOctetString(){} // RVA: 0x7FFE8A140DE0
        public void .cctor(){} // RVA: 0x7FFE8A141360
    }

    public class DerOctetString : Asn1OctetString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A132C60 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A1414A0 | overloaded x2
    }

    public class DerOctetStringParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetOctetStream(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A141530
    }

    public class DerOutputStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1189F0
        public void WriteLength(){} // RVA: 0x7FFE8A1416D0
        public void WriteEncoded(){} // RVA: 0x7FFE8A141A60 | overloaded x4
        public void WriteTag(){} // RVA: 0x7FFE8A141900
        public void WriteNull(){} // RVA: 0x7FFE8A141AD0
        public void WriteObject(){} // RVA: 0x7FFE8A141DA0 | overloaded x3
    }

    public class DerPrintableString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A141F30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1421F0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE81116380
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A142320
        public void Asn1Equals(){} // RVA: 0x7FFE8A1423D0
        public void IsPrintableString(){} // RVA: 0x7FFE8A1424B0
    }

    public class DerSequence : Asn1Sequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFE8A16D170
        public void .ctor(){} // RVA: 0x7FFE8A12E1E0 | overloaded x4
        public void Encode(){} // RVA: 0x7FFE8A16D260
        public void .cctor(){} // RVA: 0x7FFE8A16D5E0
    }

    public class DerSequenceGenerator : DerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A16D7A0 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFE8A16D8D0
        public void GetRawOutputStream(){} // RVA: 0x7FFE811290C0
        public void Close(){} // RVA: 0x7FFE8A16D960
    }

    public class DerSequenceParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ReadObject(){} // RVA: 0x7FFE81588A80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A16D9B0
    }

    public class DerSet : Asn1Set
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFE8A16DBB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A16DEE0 | overloaded x5
        public void Encode(){} // RVA: 0x7FFE8A16DFC0
        public void .cctor(){} // RVA: 0x7FFE8A16E340
    }

    public class DerSetGenerator : DerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A16E500 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFE8A16E630
        public void GetRawOutputStream(){} // RVA: 0x7FFE811290C0
        public void Close(){} // RVA: 0x7FFE8A16E6C0
    }

    public class DerSetParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ReadObject(){} // RVA: 0x7FFE81588A80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A16E710
    }

    public class DerStringBase : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetString(){} // RVA: 0x7FFE80E2E2E0
        public void ToString(){} // RVA: 0x7FFE844800F0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A16E820
    }

    public class DerT61String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A16E980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A16EC30 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE81116380
        public void Encode(){} // RVA: 0x7FFE8A16ECE0
        public void GetOctets(){} // RVA: 0x7FFE8A16ED70
        public void Asn1Equals(){} // RVA: 0x7FFE8A16ED80
    }

    public class DerTaggedObject : Asn1TaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A16EE60 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE8A16EEE0
    }

    public class DerUniversalString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A16F120 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A16F3E0
        public void GetString(){} // RVA: 0x7FFE8A16F490
        public void GetOctets(){} // RVA: 0x7FFE8A16F6D0
        public void Encode(){} // RVA: 0x7FFE8A16F750
        public void Asn1Equals(){} // RVA: 0x7FFE8A16F7D0
        public void .cctor(){} // RVA: 0x7FFE8A16F920
    }

    public class DerUtcTime : Asn1Object
    {
        public string time; // 0x10
        public object field_1; // 0x68D
        public object field_2; // 0x68E

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A16FB20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A13B990 | overloaded x3
        public void ToDateTime(){} // RVA: 0x7FFE8A16FFA0
        public void ToAdjustedDateTime(){} // RVA: 0x7FFE8A16FFF0
        public void ParseDateString(){} // RVA: 0x7FFE8A170040
        public void get_TimeString(){} // RVA: 0x7FFE8A1700F0
        public void get_AdjustedTime(){} // RVA: 0x7FFE8A170420
        public void get_AdjustedTimeString(){} // RVA: 0x7FFE8A170430
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A1704C0
        public void Asn1Equals(){} // RVA: 0x7FFE8A170570
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8170B620
        public void ToString(){} // RVA: 0x7FFE81116380
    }

    public class DerUtf8String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A170770 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A170980 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE81116380
        public void Asn1Equals(){} // RVA: 0x7FFE8A170A30
        public void Encode(){} // RVA: 0x7FFE8A170B10
    }

    public class DerVideotexString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A170E50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A170F90
        public void GetString(){} // RVA: 0x7FFE8A13D750
        public void GetOctets(){} // RVA: 0x7FFE8A171090
        public void Encode(){} // RVA: 0x7FFE8A171140
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8A1711C0
        public void Asn1Equals(){} // RVA: 0x7FFE8A171260
    }

    public class DerVisibleString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A171630 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A171780 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE81116380
        public void GetOctets(){} // RVA: 0x7FFE8A13C6F0
        public void Encode(){} // RVA: 0x7FFE8A171830
        public void Asn1Equals(){} // RVA: 0x7FFE8A1718E0
        public void Asn1GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class IAsn1ApplicationSpecificParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IAsn1Choice
    {
    }

    public class IAsn1Convertible
    {
        // ── Methods ──
        public void ToAsn1Object(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IAsn1String
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IndefiniteLengthInputStream : LimitedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1719C0
        public void SetEofOn00(){} // RVA: 0x7FFE8A171A00
        public void CheckForEof(){} // RVA: 0x7FFE8A171A10
        public void Read(){} // RVA: 0x7FFE8A171AB0
        public void ReadByte(){} // RVA: 0x7FFE8A171BD0
        public void RequireByte(){} // RVA: 0x7FFE8A171C20
    }

    public class LazyAsn1InputStream : Asn1InputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A12B080 | overloaded x2
        public void CreateDerSequence(){} // RVA: 0x7FFE8A171CA0
        public void CreateDerSet(){} // RVA: 0x7FFE8A171D90
    }

    public class LazyDerSequence : DerSequence
    {
        public byte[] encoded; // 0x18
        public object field_1; // 0x690

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A171E80
        public void Parse(){} // RVA: 0x7FFE8A171F30
        public void get_Item(){} // RVA: 0x7FFE8A172360
        public void GetEnumerator(){} // RVA: 0x7FFE8A1723B0
        public void get_Count(){} // RVA: 0x7FFE8A1723E0
        public void Encode(){} // RVA: 0x7FFE8A172410
    }

    public class LazyDerSet : DerSet
    {
        public byte[] encoded; // 0x18
        public object field_1; // 0x692

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1725F0
        public void Parse(){} // RVA: 0x7FFE8A1726A0
        public void get_Item(){} // RVA: 0x7FFE8A172AD0
        public void GetEnumerator(){} // RVA: 0x7FFE8A172B20
        public void get_Count(){} // RVA: 0x7FFE8A172B50
        public void Encode(){} // RVA: 0x7FFE8A172B80
    }

    public class LimitedInputStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A172D60
        public void GetRemaining(){} // RVA: 0x7FFE81D46090
        public void SetParentEofDetect(){} // RVA: 0x7FFE8A172E20
    }

    public class OidTokenizer : Object
    {
        public string oid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_HasMoreTokens(){} // RVA: 0x7FFE8A172EE0
        public void NextToken(){} // RVA: 0x7FFE8A172EF0
    }

}