// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
// Classes: 82
// Methods: 552

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
    public class Asn1Encodable : Object
    {
        public string Der;
        public string Ber;

        // ── Methods ──
        public void GetEncoded(){} // RVA: 0x7FFACBCD0650 | overloaded x2
        public void GetDerEncoded(){} // RVA: 0x7FFACBCD0790
        public void GetHashCode(){} // RVA: 0x7FFACBCD07E0
        public void Equals(){} // RVA: 0x7FFACBCD0820
        public void ToAsn1Object(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Asn1EncodableVector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] Item;
        public int Count;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] elements; // 0x10
        public int elementCount; // 0x18
        public bool copyOnWrite; // 0x1C

        // ── Methods ──
        public void FromEnumerable(){} // RVA: 0x7FFACBCD0910
        public void .ctor(){} // RVA: 0x7FFACBCD0DA0 | overloaded x3
        public void Add(){} // RVA: 0x7FFACBCD0EE0 | overloaded x2
        public void AddOptional(){} // RVA: 0x7FFACBCD1030
        public void AddOptionalTagged(){} // RVA: 0x7FFACBCD1090
        public void AddAll(){} // RVA: 0x7FFACBCD1130
        public void get_Item(){} // RVA: 0x7FFACBCD1340
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void GetEnumerator(){} // RVA: 0x7FFACBCD1410
        public void CopyElements(){} // RVA: 0x7FFACBCD14E0
        public void TakeElements(){} // RVA: 0x7FFACBCD15A0
        public void Reallocate(){} // RVA: 0x7FFACBCD1680
        public void CloneElements(){} // RVA: 0x7FFACBCD1790
        public void .cctor(){} // RVA: 0x7FFACBCD1850
    }

    public class Asn1Exception : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x3
    }

    public class Asn1Generator : Object
    {
        public System.IO.Stream Out; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Out(){} // RVA: 0x7FFAC2F3C380
        public void AddObject(){} // RVA: 0x7FFAC2C70A40
        public void GetRawOutputStream(){} // RVA: 0x7FFAC2C58E90
        public void Close(){} // RVA: 0x7FFAC2C70980
    }

    public class Asn1InputStream : FilterStream
    {
        public int limit; // 0x30
        public byte[][] tmpBuffers; // 0x38

        // ── Methods ──
        public void FindLimit(){} // RVA: 0x7FFACBCD1900
        public void .ctor(){} // RVA: 0x7FFACBCD1B60 | overloaded x3
        public void BuildObject(){} // RVA: 0x7FFACBCD1BF0
        public void ReadVector(){} // RVA: 0x7FFACBCD1F00
        public void CreateDerSequence(){} // RVA: 0x7FFACBCD21B0
        public void CreateDerSet(){} // RVA: 0x7FFACBCD2230
        public void ReadObject(){} // RVA: 0x7FFACBCD2380
        public void ReadTagNumber(){} // RVA: 0x7FFACBCD29E0
        public void ReadLength(){} // RVA: 0x7FFACBCD2B00
        public void GetBuffer(){} // RVA: 0x7FFACBCD2D70
        public void CreatePrimitiveDerObject(){} // RVA: 0x7FFACBCD2E50
    }

    public class Asn1Null : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFACBCD3510
    }

    public class Asn1Object : Asn1Encodable
    {
        // ── Methods ──
        public void FromByteArray(){} // RVA: 0x7FFACBCD3550
        public void FromStream(){} // RVA: 0x7FFACBCD36F0
        public void ToAsn1Object(){} // RVA: 0x7FFAC44F81E0
        public void Encode(){} // RVA: 0x7FFAC2C70A40
        public void Asn1Equals(){} // RVA: 0x7FFAC2C59F60
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CallAsn1Equals(){} // RVA: 0x7FFAC77C53C0
        public void CallAsn1GetHashCode(){} // RVA: 0x7FFAC30FEBD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Asn1OctetString : Asn1Object
    {
        public byte[] Parser; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCD3890 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCD3B10 | overloaded x2
        public void GetOctetStream(){} // RVA: 0x7FFACBCD3C40
        public void get_Parser(){} // RVA: 0x7FFAC44F81E0
        public void GetOctets(){} // RVA: 0x7FFAC2F3C380
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCD3CA0
        public void Asn1Equals(){} // RVA: 0x7FFACBCD3D50
        public void ToString(){} // RVA: 0x7FFACBCD3ED0
    }

    public class Asn1OctetStringParser
    {
        // ── Methods ──
        public void GetOctetStream(){} // RVA: 0x7FFAC2C58E90
    }

    public class Asn1OutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCBF3D0
        public void WriteObject(){} // RVA: 0x7FFACBCD3F90
    }

    public class Asn1ParsingException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8632840 | overloaded x3
    }

    public class Asn1Sequence : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] Parser; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCD4570 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCD4BC0 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x7FFAC47D1B80
        public void get_Parser(){} // RVA: 0x7FFACBCD4C70
        public void get_Item(){} // RVA: 0x7FFAC926F060
        public void get_Count(){} // RVA: 0x7FFAC3510620
        public void ToArray(){} // RVA: 0x7FFACBCD4D40
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCD4DA0
        public void Asn1Equals(){} // RVA: 0x7FFACBCD4E50
        public void ToString(){} // RVA: 0x7FFACBCD4FF0
    }

    public class Asn1SequenceParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFAC2C58E90
    }

    public class Asn1Set : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable[] Item; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCD55E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCD5EA0 | overloaded x4
        public void GetEnumerator(){} // RVA: 0x7FFAC47D1B80
        public void get_Item(){} // RVA: 0x7FFAC926F060
        public void get_Count(){} // RVA: 0x7FFAC3510620
        public void ToArray(){} // RVA: 0x7FFACBCD5F50
        public void get_Parser(){} // RVA: 0x7FFACBCD5FB0
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCD4DA0
        public void Asn1Equals(){} // RVA: 0x7FFACBCD6080
        public void Sort(){} // RVA: 0x7FFACBCD6220
        public void ToString(){} // RVA: 0x7FFACBCD4FF0
    }

    public class Asn1SetParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFAC2C58E90
    }

    public class Asn1StreamParser : Object
    {
        public System.IO.Stream _in; // 0x10
        public int _limit; // 0x18
        public byte[][] tmpBuffers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD6960 | overloaded x3
        public void ReadIndef(){} // RVA: 0x7FFACBCD69F0
        public void ReadImplicit(){} // RVA: 0x7FFACBCD6BA0
        public void ReadTaggedObject(){} // RVA: 0x7FFACBCD6EF0
        public void ReadObject(){} // RVA: 0x7FFACBCD72D0
        public void Set00Check(){} // RVA: 0x7FFACBCD7960
        public void ReadVector(){} // RVA: 0x7FFACBCD7A20
    }

    public class Asn1TaggedObject : Asn1Object
    {
        public int TagNo; // 0x10
        public bool explicitly; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x18

        // ── Methods ──
        public void IsConstructed(){} // RVA: 0x7FFACBCD7C40
        public void GetInstance(){} // RVA: 0x7FFACBCD7E30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCD7FC0 | overloaded x2
        public void Asn1Equals(){} // RVA: 0x7FFACBCD8090
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCD81C0
        public void get_TagNo(){} // RVA: 0x7FFAC2F6E5C0
        public void IsExplicit(){} // RVA: 0x7FFAC3070BD0
        public void IsEmpty(){} // RVA: 0x7FFAC2F21320
        public void GetObject(){} // RVA: 0x7FFACBCD8200
        public void GetObjectParser(){} // RVA: 0x7FFACBCD8230
        public void ToString(){} // RVA: 0x7FFACBCD8350
    }

    public class Asn1TaggedObjectParser
    {
        public object TagNo;

        // ── Methods ──
        public void get_TagNo(){} // RVA: 0x7FFAC2C59960
        public void GetObjectParser(){}
    }

    public class Asn1Tags : Object
    {
        public int Boolean;
        public int Integer;
        public int BitString;
        public int OctetString;
        public int Null;
        public int ObjectIdentifier;
        public int External;
        public int Enumerated;
        public int Sequence;
        public int SequenceOf;
        public int Set;
        public int SetOf;
        public int NumericString;
        public int PrintableString;
        public int T61String;
        public int VideotexString;
        public int IA5String;
        public int UtcTime;
        public int GeneralizedTime;
        public int GraphicString;
        public int VisibleString;
        public int GeneralString;
        public int UniversalString;
        public int BmpString;
        public int Utf8String;
        public int Constructed;
        public int Application;
        public int Tagged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BerApplicationSpecific : DerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD8400
    }

    public class BerApplicationSpecificParser : Object
    {
        public int tag; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser parser; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void ReadObject(){} // RVA: 0x7FFACBCD8410
        public void ToAsn1Object(){} // RVA: 0x7FFACBCD8440
    }

    public class BerBitString : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD8610 | overloaded x4
        public void Encode(){} // RVA: 0x7FFACBCD8690
    }

    public class BerGenerator : Asn1Generator
    {
        public bool _tagged; // 0x18
        public bool _isExplicit; // 0x19
        public int _tagNo; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD87E0 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFACBCD8840
        public void GetRawOutputStream(){} // RVA: 0x7FFAC2F3C380
        public void Close(){} // RVA: 0x7FFACBCD88D0
        public void WriteHdr(){} // RVA: 0x7FFACBCD88E0
        public void WriteBerHeader(){} // RVA: 0x7FFACBCD8930
        public void WriteBerBody(){} // RVA: 0x7FFACBCD8A10
        public void WriteBerEnd(){} // RVA: 0x7FFACBCD8AE0
    }

    public class BerNull : DerNull
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerNull Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD8C60 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCD8CC0
        public void .cctor(){} // RVA: 0x7FFACBCD8DF0
    }

    public class BerOctetString : DerOctetString
    {
        public int MaxLength;
        public System.Collections.IEnumerable octs; // 0x18

        // ── Methods ──
        public void FromSequence(){} // RVA: 0x7FFACBCD8EE0
        public void ToBytes(){} // RVA: 0x7FFACBCD9230
        public void .ctor(){} // RVA: 0x7FFACBCD9650 | overloaded x4
        public void GetOctets(){} // RVA: 0x7FFAC2F3C380
        public void GetEnumerator(){} // RVA: 0x7FFACBCD9690
        public void GetObjects(){} // RVA: 0x7FFACBCD9710
        public void GenerateOcts(){} // RVA: 0x7FFACBCD9720
        public void Encode(){} // RVA: 0x7FFACBCD9990
    }

    public class BerOctetStringGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD9D90 | overloaded x2
        public void GetOctetOutputStream(){} // RVA: 0x7FFACBCD9F80 | overloaded x3
    }

    public class BerOctetStringParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetOctetStream(){} // RVA: 0x7FFACBCDA4B0
        public void ToAsn1Object(){} // RVA: 0x7FFACBCDA580
    }

    public class BerOutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCBF3D0
        public void WriteObject(){} // RVA: 0x7FFACBCDA7D0
    }

    public class BerSequence : DerSequence
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSequence Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFACBCDA9D0
        public void .ctor(){} // RVA: 0x7FFACBCDAB80 | overloaded x4
        public void Encode(){} // RVA: 0x7FFACBCDAC80
        public void .cctor(){} // RVA: 0x7FFACBCDAFD0
    }

    public class BerSequenceGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDB130 | overloaded x2
    }

    public class BerSequenceParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ReadObject(){} // RVA: 0x7FFAC84E9CA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBCDB240
    }

    public class BerSet : DerSet
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerSet Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFACBCDB360 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCDB5C0 | overloaded x4
        public void Encode(){} // RVA: 0x7FFACBCDB6E0
        public void .cctor(){} // RVA: 0x7FFACBCDBA30
    }

    public class BerSetGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDBB90 | overloaded x2
    }

    public class BerSetParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ReadObject(){} // RVA: 0x7FFAC84E9CA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBCDBCA0
    }

    public class BerTaggedObject : DerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDBDF0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBCDBE70
    }

    public class BerTaggedObjectParser : Object
    {
        public bool IsConstructed; // 0x10
        public int TagNo; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDC630 | overloaded x2
        public void get_IsConstructed(){} // RVA: 0x7FFAC2FEB5E0
        public void get_TagNo(){} // RVA: 0x7FFAC33D5A20
        public void GetObjectParser(){} // RVA: 0x7FFACBCDC690
        public void ToAsn1Object(){} // RVA: 0x7FFACBCDC740
    }

    public class ConstructedOctetStream : BaseInputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x30
        public bool _first; // 0x38
        public System.IO.Stream _currentStream; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDC7F0
        public void Read(){} // RVA: 0x7FFACBCDC890
        public void ReadByte(){} // RVA: 0x7FFACBCDCB90
    }

    public class DefiniteLengthInputStream : LimitedInputStream
    {
        public byte[] Remaining;
        public int _originalLength; // 0x40
        public int _remaining; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDCE60
        public void get_Remaining(){} // RVA: 0x7FFAC2FC20A0
        public void ReadByte(){} // RVA: 0x7FFACBCDCF10
        public void Read(){} // RVA: 0x7FFACBCDD030
        public void ReadAllIntoByteArray(){} // RVA: 0x7FFACBCDD1B0
        public void ToArray(){} // RVA: 0x7FFACBCDD350
        public void .cctor(){} // RVA: 0x7FFACBCDD530
    }

    public class DerApplicationSpecific : Asn1Object
    {
        public bool ApplicationTag; // 0x10
        public int tag; // 0x14
        public byte[] octets; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCDD8B0 | overloaded x5
        public void GetLengthOfHeader(){} // RVA: 0x7FFACBCDDA70
        public void IsConstructed(){} // RVA: 0x7FFAC2FEB5E0
        public void GetContents(){} // RVA: 0x7FFAC2F247C0
        public void get_ApplicationTag(){} // RVA: 0x7FFAC33D5A20
        public void GetObject(){} // RVA: 0x7FFACBCDDB50 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCDDD40
        public void Asn1Equals(){} // RVA: 0x7FFACBCDDDC0
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCDDEA0
        public void ReplaceTagNumber(){} // RVA: 0x7FFACBCDDF80
    }

    public class DerBitString : DerStringBase
    {
        public char[] PadBits;
        public byte[] IntValue; // 0x10
        public int mPadBits; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCDE360 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCDE840 | overloaded x4
        public void GetOctets(){} // RVA: 0x7FFACBCDE880
        public void GetBytes(){} // RVA: 0x7FFACBCDE980
        public void get_PadBits(){} // RVA: 0x7FFAC3157800
        public void get_IntValue(){} // RVA: 0x7FFACBCDEA80
        public void Encode(){} // RVA: 0x7FFACBCDEB70
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCDED20
        public void Asn1Equals(){} // RVA: 0x7FFACBCDEDD0
        public void GetString(){} // RVA: 0x7FFACBCDEF30
        public void FromAsn1Octets(){} // RVA: 0x7FFACBCDF170
        public void .cctor(){} // RVA: 0x7FFACBCDF350
    }

    public class DerBmpString : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCDF550 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCDF8D0 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void Asn1Equals(){} // RVA: 0x7FFACBCDF980
        public void Encode(){} // RVA: 0x7FFACBCDFA60
    }

    public class DerBoolean : Asn1Object
    {
        public byte IsTrue; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean False;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean True; // 0x8

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCDFD60 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFACBCDFF50 | overloaded x2
        public void get_IsTrue(){} // RVA: 0x7FFACBCDFF70
        public void Encode(){} // RVA: 0x7FFACBCDFF80
        public void Asn1Equals(){} // RVA: 0x7FFACBCE0050
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCE00F0
        public void ToString(){} // RVA: 0x7FFACBCE0140
        public void FromOctetString(){} // RVA: 0x7FFACBCE01A0
        public void .cctor(){} // RVA: 0x7FFACBCE0350
    }

    public class DerEnumerated : Asn1Object
    {
        public byte[] Value; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerEnumerated[] cache;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE05C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE0860 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFACBCE0A10
        public void Encode(){} // RVA: 0x7FFACBCE0A90
        public void Asn1Equals(){} // RVA: 0x7FFACBCE0B10
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCE0C60
        public void FromOctetString(){} // RVA: 0x7FFACBCE0D00
        public void .cctor(){} // RVA: 0x7FFACBCE0FF0
    }

    public class DerExternal : Asn1Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DataValueDescriptor; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DirectReference; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object Encoding; // 0x20
        public int ExternalContent; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object IndirectReference; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE1660 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBCE1800
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCE1A90
        public void Asn1Equals(){} // RVA: 0x7FFACBCE1B40
        public void get_DataValueDescriptor(){} // RVA: 0x7FFAC2F4F0C0
        public void set_DataValueDescriptor(){} // RVA: 0x7FFAC2F4F0D0
        public void get_DirectReference(){} // RVA: 0x7FFAC2F3C380
        public void set_DirectReference(){} // RVA: 0x7FFAC2F22E30
        public void get_Encoding(){} // RVA: 0x7FFAC32EC4C0
        public void set_Encoding(){} // RVA: 0x7FFACBCE1CC0
        public void get_ExternalContent(){} // RVA: 0x7FFAC31D95E0
        public void set_ExternalContent(){} // RVA: 0x7FFAC2F4F890
        public void get_IndirectReference(){} // RVA: 0x7FFAC2F247C0
        public void set_IndirectReference(){} // RVA: 0x7FFAC2F87E80
        public void GetObjFromVector(){} // RVA: 0x7FFACBCE1D60
        public void WriteEncodable(){} // RVA: 0x7FFACBCE1E10
    }

    public class DerExternalParser : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ReadObject(){} // RVA: 0x7FFAC84E9CA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBCE1E70
    }

    public class DerGeneralString : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE33C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE3700 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBCE37B0
        public void Asn1Equals(){} // RVA: 0x7FFACBCE3860
    }

    public class DerGeneralizedTime : Asn1Object
    {
        public string TimeString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE2020 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE2370 | overloaded x3
        public void get_TimeString(){} // RVA: 0x7FFAC2F3C380
        public void GetTime(){} // RVA: 0x7FFACBCE2420
        public void CalculateGmtOffset(){} // RVA: 0x7FFACBCE26E0
        public void Convert(){} // RVA: 0x7FFACBCE2A10
        public void ToDateTime(){} // RVA: 0x7FFACBCE2A70
        public void FString(){} // RVA: 0x7FFACBCE2D80
        public void ParseDateString(){} // RVA: 0x7FFACBCE2E70
        public void get_HasFractionalSeconds(){} // RVA: 0x7FFACBCE3090
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBCE3110
        public void Asn1Equals(){} // RVA: 0x7FFACBCE31C0
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class DerGenerator : Asn1Generator
    {
        public bool _tagged; // 0x18
        public bool _isExplicit; // 0x19
        public int _tagNo; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD87E0 | overloaded x2
        public void WriteLength(){} // RVA: 0x7FFACBCE3940
        public void WriteDerEncoded(){} // RVA: 0x7FFACBCE3C20 | overloaded x3
    }

    public class DerGraphicString : DerStringBase
    {
        public byte[] mString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE3EF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE4030
        public void GetString(){} // RVA: 0x7FFACBCE4130
        public void GetOctets(){} // RVA: 0x7FFACBCE4140
        public void Encode(){} // RVA: 0x7FFACBCE41F0
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCE4270
        public void Asn1Equals(){} // RVA: 0x7FFACBCE4310
    }

    public class DerIA5String : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE4580 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE4870 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBCE49D0
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void Asn1Equals(){} // RVA: 0x7FFACBCE4A80
        public void IsIA5String(){} // RVA: 0x7FFACBCE4B60
    }

    public class DerInteger : Asn1Object
    {
        public string Value;
        public byte[] PositiveValue; // 0x10

        // ── Methods ──
        public void AllowUnsafe(){} // RVA: 0x7FFACBCE4BC0
        public void GetInstance(){} // RVA: 0x7FFACBCE4D90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE5080 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFACBCE5230
        public void get_PositiveValue(){} // RVA: 0x7FFACBCE52B0
        public void Encode(){} // RVA: 0x7FFACBCE5330
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBCE53B0
        public void Asn1Equals(){} // RVA: 0x7FFACBCE5450
        public void ToString(){} // RVA: 0x7FFACBCE55A0
    }

    public class DerNull : Asn1Null
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerNull Instance;
        public byte[] zeroBytes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE5670 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCE5700
        public void Asn1Equals(){} // RVA: 0x7FFACBCE5780
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC32BD0E0
        public void .cctor(){} // RVA: 0x7FFACBCE5810
    }

    public class DerNumericString : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE59E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE5D90 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBCE5F40
        public void Asn1Equals(){} // RVA: 0x7FFACBCE5FF0
        public void IsNumericString(){} // RVA: 0x7FFACBCE60D0
    }

    public class DerObjectIdentifier : Asn1Object
    {
        public string Id; // 0x10
        public byte[] body; // 0x18
        public long LONG_LIMIT;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier[] cache;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE6330 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE69E0 | overloaded x3
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void Branch(){} // RVA: 0x7FFACBCE6790
        public void On(){} // RVA: 0x7FFACBCE6930
        public void WriteField(){} // RVA: 0x7FFACBCE6C70 | overloaded x2
        public void DoOutput(){} // RVA: 0x7FFACBCE6E00
        public void GetBody(){} // RVA: 0x7FFACBCE7000
        public void Encode(){} // RVA: 0x7FFACBCE7210
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void Asn1Equals(){} // RVA: 0x7FFACBCE7290
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void IsValidBranchID(){} // RVA: 0x7FFACBCE7370
        public void IsValidIdentifier(){} // RVA: 0x7FFACBCE7460
        public void MakeOidStringFromBytes(){} // RVA: 0x7FFACBCE74F0
        public void FromOctetString(){} // RVA: 0x7FFACBCE77C0
        public void .cctor(){} // RVA: 0x7FFACBCE7D40
    }

    public class DerOctetString : Asn1OctetString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD9640 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCE7E80 | overloaded x2
    }

    public class DerOctetStringParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DefiniteLengthInputStream stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetOctetStream(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBCE7F10
    }

    public class DerOutputStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCBF3D0
        public void WriteLength(){} // RVA: 0x7FFACBCE80B0
        public void WriteEncoded(){} // RVA: 0x7FFACBCE8440 | overloaded x4
        public void WriteTag(){} // RVA: 0x7FFACBCE82E0
        public void WriteNull(){} // RVA: 0x7FFACBCE84B0
        public void WriteObject(){} // RVA: 0x7FFACBCE8780 | overloaded x3
    }

    public class DerPrintableString : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBCE8910 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE8BD0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBCE8D00
        public void Asn1Equals(){} // RVA: 0x7FFACBCE8DB0
        public void IsPrintableString(){} // RVA: 0x7FFACBCE8E90
    }

    public class DerSequence : Asn1Sequence
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerSequence Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFACBD13B50
        public void .ctor(){} // RVA: 0x7FFACBCD4BC0 | overloaded x4
        public void Encode(){} // RVA: 0x7FFACBD13C40
        public void .cctor(){} // RVA: 0x7FFACBD13FC0
    }

    public class DerSequenceGenerator : DerGenerator
    {
        public System.IO.MemoryStream _bOut; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD14180 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFACBD142B0
        public void GetRawOutputStream(){} // RVA: 0x7FFAC2F4F0C0
        public void Close(){} // RVA: 0x7FFACBD14340
    }

    public class DerSequenceParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ReadObject(){} // RVA: 0x7FFAC84E9CA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD14390
    }

    public class DerSet : Asn1Set
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerSet Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0x7FFACBD14590 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD148C0 | overloaded x5
        public void Encode(){} // RVA: 0x7FFACBD149A0
        public void .cctor(){} // RVA: 0x7FFACBD14D20
    }

    public class DerSetGenerator : DerGenerator
    {
        public System.IO.MemoryStream _bOut; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD14EE0 | overloaded x2
        public void AddObject(){} // RVA: 0x7FFACBD15010
        public void GetRawOutputStream(){} // RVA: 0x7FFAC2F4F0C0
        public void Close(){} // RVA: 0x7FFACBD150A0
    }

    public class DerSetParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1StreamParser _parser; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ReadObject(){} // RVA: 0x7FFAC84E9CA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD150F0
    }

    public class DerStringBase : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetString(){} // RVA: 0x7FFAC2C58E90
        public void ToString(){} // RVA: 0x7FFAC3F5BE50
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBD15200
    }

    public class DerT61String : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD15360 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD15610 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void Encode(){} // RVA: 0x7FFACBD156C0
        public void GetOctets(){} // RVA: 0x7FFACBD15750
        public void Asn1Equals(){} // RVA: 0x7FFACBD15760
    }

    public class DerTaggedObject : Asn1TaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD15840 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBD158C0
    }

    public class DerUniversalString : DerStringBase
    {
        public char[] table;
        public byte[] str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD15B00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD15DC0
        public void GetString(){} // RVA: 0x7FFACBD15E70
        public void GetOctets(){} // RVA: 0x7FFACBD160B0
        public void Encode(){} // RVA: 0x7FFACBD16130
        public void Asn1Equals(){} // RVA: 0x7FFACBD161B0
        public void .cctor(){} // RVA: 0x7FFACBD16300
    }

    public class DerUtcTime : Asn1Object
    {
        public string TimeString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD16500 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBCE2370 | overloaded x3
        public void ToDateTime(){} // RVA: 0x7FFACBD16980
        public void ToAdjustedDateTime(){} // RVA: 0x7FFACBD169D0
        public void ParseDateString(){} // RVA: 0x7FFACBD16A20
        public void get_TimeString(){} // RVA: 0x7FFACBD16AD0
        public void get_AdjustedTime(){} // RVA: 0x7FFACBD16E00
        public void get_AdjustedTimeString(){} // RVA: 0x7FFACBD16E10
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBD16EA0
        public void Asn1Equals(){} // RVA: 0x7FFACBD16F50
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void ToString(){} // RVA: 0x7FFAC2F3C380
    }

    public class DerUtf8String : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD17150 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD17360 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void Asn1Equals(){} // RVA: 0x7FFACBD17410
        public void Encode(){} // RVA: 0x7FFACBD174F0
    }

    public class DerVideotexString : DerStringBase
    {
        public byte[] mString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD17830 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD17970
        public void GetString(){} // RVA: 0x7FFACBCE4130
        public void GetOctets(){} // RVA: 0x7FFACBD17A70
        public void Encode(){} // RVA: 0x7FFACBD17B20
        public void Asn1GetHashCode(){} // RVA: 0x7FFACBD17BA0
        public void Asn1Equals(){} // RVA: 0x7FFACBD17C40
    }

    public class DerVisibleString : DerStringBase
    {
        public string str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD18010 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD18160 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC2F3C380
        public void GetOctets(){} // RVA: 0x7FFACBCE30D0
        public void Encode(){} // RVA: 0x7FFACBD18210
        public void Asn1Equals(){} // RVA: 0x7FFACBD182C0
        public void Asn1GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class IAsn1ApplicationSpecificParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7FFAC2C58E90
    }

    public class IAsn1Choice
    {
    }

    public class IAsn1Convertible
    {
        // ── Methods ──
        public void ToAsn1Object(){} // RVA: 0x7FFAC2C58E90
    }

    public class IAsn1String
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x7FFAC2C58E90
    }

    public class IndefiniteLengthInputStream : LimitedInputStream
    {
        public int _lookAhead; // 0x40
        public bool _eofOn00; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD183A0
        public void SetEofOn00(){} // RVA: 0x7FFACBD183E0
        public void CheckForEof(){} // RVA: 0x7FFACBD183F0
        public void Read(){} // RVA: 0x7FFACBD18490
        public void ReadByte(){} // RVA: 0x7FFACBD185B0
        public void RequireByte(){} // RVA: 0x7FFACBD18600
    }

    public class LazyAsn1InputStream : Asn1InputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCD1A60 | overloaded x2
        public void CreateDerSequence(){} // RVA: 0x7FFACBD18680
        public void CreateDerSet(){} // RVA: 0x7FFACBD18770
    }

    public class LazyDerSequence : DerSequence
    {
        public byte[] Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD18860
        public void Parse(){} // RVA: 0x7FFACBD18910
        public void get_Item(){} // RVA: 0x7FFACBD18D40
        public void GetEnumerator(){} // RVA: 0x7FFACBD18D90
        public void get_Count(){} // RVA: 0x7FFACBD18DC0
        public void Encode(){} // RVA: 0x7FFACBD18DF0
    }

    public class LazyDerSet : DerSet
    {
        public byte[] Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD18FD0
        public void Parse(){} // RVA: 0x7FFACBD19080
        public void get_Item(){} // RVA: 0x7FFACBD194B0
        public void GetEnumerator(){} // RVA: 0x7FFACBD19500
        public void get_Count(){} // RVA: 0x7FFACBD19530
        public void Encode(){} // RVA: 0x7FFACBD19560
    }

    public class LimitedInputStream : BaseInputStream
    {
        public System.IO.Stream _in; // 0x30
        public int _limit; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD19740
        public void GetRemaining(){} // RVA: 0x7FFAC358A870
        public void SetParentEofDetect(){} // RVA: 0x7FFACBD19800
    }

    public class OidTokenizer : Object
    {
        public string HasMoreTokens; // 0x10
        public int index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_HasMoreTokens(){} // RVA: 0x7FFACBD198C0
        public void NextToken(){} // RVA: 0x7FFACBD198D0
    }

}