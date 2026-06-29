// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
// Classes: 83
// Methods: 459

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
    public class Asn1Encodable : Object
    {
        public object Der;
        public object Ber;

        // ── Methods ──
        public void GetEncoded(){} // RVA: 0xA36C250
        public void GetDerEncoded(){} // RVA: 0xA36C390
        public void GetHashCode(){} // RVA: 0xA36C3E0
        public void Equals(){} // RVA: 0xA36C420
        public void ToAsn1Object(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Asn1EncodableVector : Object
    {
        public object EmptyElements;
        public object DefaultCapacity;
        public object elements;
        public object elementCount;
        public object copyOnWrite;

        // ── Methods ──
        public void FromEnumerable(){} // RVA: 0xA36C510
        public void .ctor(){} // RVA: 0xA36C990
        public void Add(){} // RVA: 0xA36CAD0
        public void AddOptional(){} // RVA: 0xA36CC20
        public void AddOptionalTagged(){} // RVA: 0xA36CC90
        public void AddAll(){} // RVA: 0xA36CD30
        public void get_Item(){} // RVA: 0xA36CF30
        public void get_Count(){} // RVA: 0xE62D00
        public void GetEnumerator(){} // RVA: 0xA36D000
        public void CopyElements(){} // RVA: 0xA36D0D0
        public void TakeElements(){} // RVA: 0xA36D190
        public void Reallocate(){} // RVA: 0xA36D270
        public void CloneElements(){} // RVA: 0xA36D380
        public void .cctor(){} // RVA: 0xA36D440
    }

    public class Asn1Encodable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Asn1Exception : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class Asn1Generator : Object
    {
        public object _out;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Out(){} // RVA: 0xB5DBF0
        public void AddObject(){} // RVA: 0x894320
        public void GetRawOutputStream(){} // RVA: 0x87C0A0
        public void Close(){} // RVA: 0x894290
    }

    public class Asn1InputStream : FilterStream
    {
        public object limit;
        public object tmpBuffers;

        // ── Methods ──
        public void FindLimit(){} // RVA: 0xA36D4F0
        public void .ctor(){} // RVA: 0xA36D750
        public void BuildObject(){} // RVA: 0xA36D7E0
        public void ReadVector(){} // RVA: 0xA36DB00
        public void CreateDerSequence(){} // RVA: 0xA36DDB0
        public void CreateDerSet(){} // RVA: 0xA36DE30
        public void ReadObject(){} // RVA: 0xA36DF80
        public void ReadTagNumber(){} // RVA: 0xA36E5E0
        public void ReadLength(){} // RVA: 0xA36E700
        public void GetBuffer(){} // RVA: 0xA36E970
        public void CreatePrimitiveDerObject(){} // RVA: 0xA36EA50
    }

    public class Asn1Null : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ToString(){} // RVA: 0xA36F230
    }

    public class Asn1Object : Asn1Encodable
    {
        // ── Methods ──
        public void FromByteArray(){} // RVA: 0xA36F270
        public void FromStream(){} // RVA: 0xA36F410
        public void ToAsn1Object(){} // RVA: 0x2303260
        public void Encode(){} // RVA: 0x894320
        public void Asn1Equals(){} // RVA: 0x87D350
        public void Asn1GetHashCode(){} // RVA: 0x87C130
        public void CallAsn1Equals(){} // RVA: 0x5BA5570
        public void CallAsn1GetHashCode(){} // RVA: 0x2538380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Asn1OctetString : Asn1Object
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA36F5B0
        public void .ctor(){} // RVA: 0xA36F830
        public void GetOctetStream(){} // RVA: 0xA36F960
        public void get_Parser(){} // RVA: 0x2303260
        public void GetOctets(){} // RVA: 0xB5DBF0
        public void Asn1GetHashCode(){} // RVA: 0xA36F9C0
        public void Asn1Equals(){} // RVA: 0xA36FA70
        public void ToString(){} // RVA: 0xA36FBD0
    }

    public class Asn1OctetStringParser
    {
        // ── Methods ──
        public void GetOctetStream(){} // RVA: 0x87C0A0
    }

    public class Asn1OutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35AA10
        public void WriteObject(){} // RVA: 0xA36FC90
    }

    public class Asn1ParsingException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6914700
    }

    public class Asn1Sequence : Asn1Object
    {
        public object elements;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA370270
        public void .ctor(){} // RVA: 0xA3708C0
        public void GetEnumerator(){} // RVA: 0x2556F20
        public void get_Parser(){} // RVA: 0xA370970
        public void get_Item(){} // RVA: 0x753C8F0
        public void get_Count(){} // RVA: 0x17F0080
        public void ToArray(){} // RVA: 0xA370A40
        public void Asn1GetHashCode(){} // RVA: 0xA370AA0
        public void Asn1Equals(){} // RVA: 0xA370B60
        public void ToString(){} // RVA: 0xA370D30
    }

    public class Asn1SequenceParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x87C0A0
    }

    public class Asn1Set : Asn1Object
    {
        public object elements;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA371320
        public void .ctor(){} // RVA: 0xA371BC0
        public void GetEnumerator(){} // RVA: 0x2556F20
        public void get_Item(){} // RVA: 0x753C8F0
        public void get_Count(){} // RVA: 0x17F0080
        public void ToArray(){} // RVA: 0xA371C70
        public void get_Parser(){} // RVA: 0xA371CD0
        public void Asn1GetHashCode(){} // RVA: 0xA370AA0
        public void Asn1Equals(){} // RVA: 0xA371DA0
        public void Sort(){} // RVA: 0xA371F70
        public void ToString(){} // RVA: 0xA370D30
    }

    public class Asn1SetParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x87C0A0
    }

    public class Asn1StreamParser : Object
    {
        public object _in;
        public object _limit;
        public object tmpBuffers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3726D0
        public void ReadIndef(){} // RVA: 0xA372760
        public void ReadImplicit(){} // RVA: 0xA372910
        public void ReadTaggedObject(){} // RVA: 0xA372C60
        public void ReadObject(){} // RVA: 0xA373120
        public void Set00Check(){} // RVA: 0xA3737B0
        public void ReadVector(){} // RVA: 0xA373860
    }

    public class Asn1TaggedObject : Asn1Object
    {
        public object tagNo;
        public object explicitly;
        public object obj;

        // ── Methods ──
        public void IsConstructed(){} // RVA: 0xA373A80
        public void GetInstance(){} // RVA: 0xA373C80
        public void .ctor(){} // RVA: 0xA373E10
        public void Asn1Equals(){} // RVA: 0xA373EE0
        public void Asn1GetHashCode(){} // RVA: 0xA374020
        public void get_TagNo(){} // RVA: 0xB8F8F0
        public void IsExplicit(){} // RVA: 0xC9C250
        public void IsEmpty(){} // RVA: 0xB43320
        public void GetObject(){} // RVA: 0xA374060
        public void GetObjectParser(){} // RVA: 0xA374090
        public void ToString(){} // RVA: 0xA3741B0
    }

    public class Asn1TaggedObjectParser
    {
        // ── Methods ──
        public void get_TagNo(){} // RVA: 0x87C130
        public void GetObjectParser(){} // RVA: 0x88C4E0
    }

    public class Asn1Tags : Object
    {
        public object Boolean;
        public object Integer;
        public object BitString;
        public object OctetString;
        public object Null;
        public object ObjectIdentifier;
        public object External;
        public object Enumerated;
        public object Sequence;
        public object SequenceOf;
        public object Set;
        public object SetOf;
        public object NumericString;
        public object PrintableString;
        public object T61String;
        public object VideotexString;
        public object IA5String;
        public object UtcTime;
        public object GeneralizedTime;
        public object GraphicString;
        public object VisibleString;
        public object GeneralString;
        public object UniversalString;
        public object BmpString;
        public object Utf8String;
        public object Constructed;
        public object Application;
        public object Tagged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BerApplicationSpecific : DerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA374260
    }

    public class BerApplicationSpecificParser : Object
    {
        public object tag;
        public object parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void ReadObject(){} // RVA: 0xA374270
        public void ToAsn1Object(){} // RVA: 0xA3742A0
    }

    public class BerBitString : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA374470
        public void Encode(){} // RVA: 0xA3744F0
    }

    public class BerGenerator : Asn1Generator
    {
        public object _tagged;
        public object _isExplicit;
        public object _tagNo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA374640
        public void AddObject(){} // RVA: 0xA3746A0
        public void GetRawOutputStream(){} // RVA: 0xB5DBF0
        public void Close(){} // RVA: 0xA374730
        public void WriteHdr(){} // RVA: 0xA374740
        public void WriteBerHeader(){} // RVA: 0xA374790
        public void WriteBerBody(){} // RVA: 0xA374870
        public void WriteBerEnd(){} // RVA: 0xA374940
    }

    public class BerNull : DerNull
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA374AC0
        public void Encode(){} // RVA: 0xA374B20
        public void .cctor(){} // RVA: 0xA374C50
    }

    public class BerOctetString : DerOctetString
    {
        public object MaxLength;
        public object octs;

        // ── Methods ──
        public void FromSequence(){} // RVA: 0xA374D40
        public void ToBytes(){} // RVA: 0xA375080
        public void .ctor(){} // RVA: 0xA3754A0
        public void GetOctets(){} // RVA: 0xB5DBF0
        public void GetEnumerator(){} // RVA: 0xA3754E0
        public void GetObjects(){} // RVA: 0xA375560
        public void GenerateOcts(){} // RVA: 0xA375570
        public void Encode(){} // RVA: 0xA3757E0
    }

    public class BerOctetStringGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA375BD0
        public void GetOctetOutputStream(){} // RVA: 0xA375DC0
    }

    public class BerOctetStringParser : Object
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetOctetStream(){} // RVA: 0xA376490
        public void ToAsn1Object(){} // RVA: 0xA376560
    }

    public class BerOutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35AA10
        public void WriteObject(){} // RVA: 0xA3767B0
    }

    public class BerSequence : DerSequence
    {
        public object Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0xA3769B0
        public void .ctor(){} // RVA: 0xA376B60
        public void Encode(){} // RVA: 0xA376C60
        public void .cctor(){} // RVA: 0xA376F90
    }

    public class BerSequenceGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3770F0
    }

    public class BerSequenceParser : Object
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ReadObject(){} // RVA: 0x10AD380
        public void ToAsn1Object(){} // RVA: 0xA377200
    }

    public class BerSet : DerSet
    {
        public object Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0xA377320
        public void .ctor(){} // RVA: 0xA377580
        public void Encode(){} // RVA: 0xA3776A0
        public void .cctor(){} // RVA: 0xA3779D0
    }

    public class BerSetGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA377B30
    }

    public class BerSetParser : Object
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ReadObject(){} // RVA: 0x10AD380
        public void ToAsn1Object(){} // RVA: 0xA377C40
    }

    public class BerTaggedObject : DerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA377D90
        public void Encode(){} // RVA: 0xA377E10
    }

    public class BerTaggedObjectParser : Object
    {
        public object _constructed;
        public object _tagNumber;
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA378670
        public void get_IsConstructed(){} // RVA: 0xC120A0
        public void get_TagNo(){} // RVA: 0x116A650
        public void GetObjectParser(){} // RVA: 0xA3786D0
        public void ToAsn1Object(){} // RVA: 0xA378780
    }

    public class ConstructedOctetStream : BaseInputStream
    {
        public object _parser;
        public object _first;
        public object _currentStream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA378830
        public void Read(){} // RVA: 0xA3788D0
        public void ReadByte(){} // RVA: 0xA378BD0
    }

    public class DefiniteLengthInputStream : LimitedInputStream
    {
        public object EmptyBytes;
        public object _originalLength;
        public object _remaining;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA378EA0
        public void get_Remaining(){} // RVA: 0xBE5870
        public void ReadByte(){} // RVA: 0xA378F50
        public void Read(){} // RVA: 0xA379070
        public void ReadAllIntoByteArray(){} // RVA: 0xA3791F0
        public void ToArray(){} // RVA: 0xA379390
        public void .cctor(){} // RVA: 0xA379570
    }

    public class DerApplicationSpecific : Asn1Object
    {
        public object isConstructed;
        public object tag;
        public object octets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3798F0
        public void GetLengthOfHeader(){} // RVA: 0xA379AB0
        public void IsConstructed(){} // RVA: 0xC120A0
        public void GetContents(){} // RVA: 0xB465B0
        public void get_ApplicationTag(){} // RVA: 0x116A650
        public void GetObject(){} // RVA: 0xA379B90
        public void Encode(){} // RVA: 0xA379D80
        public void Asn1Equals(){} // RVA: 0xA379E00
        public void Asn1GetHashCode(){} // RVA: 0xA379ED0
        public void ReplaceTagNumber(){} // RVA: 0xA379FA0
    }

    public class DerBitString : DerStringBase
    {
        public object table;
        public object mData;
        public object mPadBits;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37A380
        public void .ctor(){} // RVA: 0xA37A860
        public void GetOctets(){} // RVA: 0xA37A8A0
        public void GetBytes(){} // RVA: 0xA37A9A0
        public void get_PadBits(){} // RVA: 0xE62D00
        public void get_IntValue(){} // RVA: 0xA37AAA0
        public void Encode(){} // RVA: 0xA37ABA0
        public void Asn1GetHashCode(){} // RVA: 0xA37AD50
        public void Asn1Equals(){} // RVA: 0xA37AE00
        public void GetString(){} // RVA: 0xA37AF50
        public void FromAsn1Octets(){} // RVA: 0xA37B1B0
        public void .cctor(){} // RVA: 0xA37B390
    }

    public class DerBmpString : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37B590
        public void .ctor(){} // RVA: 0xA37B980
        public void GetString(){} // RVA: 0xB5DBF0
        public void Asn1Equals(){} // RVA: 0xA37BA30
        public void Encode(){} // RVA: 0xA37BB00
    }

    public class DerBoolean : Asn1Object
    {
        public object value;
        public object False;
        public object True;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37BE00
        public void .ctor(){} // RVA: 0xA37BFF0
        public void get_IsTrue(){} // RVA: 0xA37C010
        public void Encode(){} // RVA: 0xA37C020
        public void Asn1Equals(){} // RVA: 0xA37C0F0
        public void Asn1GetHashCode(){} // RVA: 0x76ADE20
        public void ToString(){} // RVA: 0xA37C180
        public void FromOctetString(){} // RVA: 0xA37C1E0
        public void .cctor(){} // RVA: 0xA37C390
    }

    public class DerEnumerated : Asn1Object
    {
        public object bytes;
        public object cache;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37C600
        public void .ctor(){} // RVA: 0xA37C8A0
        public void get_Value(){} // RVA: 0xA37CA50
        public void Encode(){} // RVA: 0xA37CAD0
        public void Asn1Equals(){} // RVA: 0xA37CB50
        public void Asn1GetHashCode(){} // RVA: 0xA37CC90
        public void FromOctetString(){} // RVA: 0xA37CD30
        public void .cctor(){} // RVA: 0xA37D020
    }

    public class DerExternal : Asn1Object
    {
        public object directReference;
        public object indirectReference;
        public object dataValueDescriptor;
        public object encoding;
        public object externalContent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA37D7F0
        public void Encode(){} // RVA: 0xA37D990
        public void Asn1GetHashCode(){} // RVA: 0xA37DC20
        public void Asn1Equals(){} // RVA: 0xA37DCD0
        public void get_DataValueDescriptor(){} // RVA: 0xB700F0
        public void set_DataValueDescriptor(){} // RVA: 0xB70100
        public void get_DirectReference(){} // RVA: 0xB5DBF0
        public void set_DirectReference(){} // RVA: 0xB44D60
        public void get_Encoding(){} // RVA: 0x1065D50
        public void set_Encoding(){} // RVA: 0xA37DE30
        public void get_ExternalContent(){} // RVA: 0xD33E60
        public void set_ExternalContent(){} // RVA: 0xB708C0
        public void get_IndirectReference(){} // RVA: 0xB465B0
        public void set_IndirectReference(){} // RVA: 0xBA9BA0
        public void GetObjFromVector(){} // RVA: 0xA37DED0
        public void WriteEncodable(){} // RVA: 0xA37DF80
    }

    public class DerExternalParser : Asn1Encodable
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ReadObject(){} // RVA: 0x10AD380
        public void ToAsn1Object(){} // RVA: 0xA37DFE0
    }

    public class DerGeneralString : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37F4F0
        public void .ctor(){} // RVA: 0xA37F830
        public void GetString(){} // RVA: 0xB5DBF0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA37F8E0
        public void Asn1Equals(){} // RVA: 0xA37F990
    }

    public class DerGeneralizedTime : Asn1Object
    {
        public object time;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA37E190
        public void .ctor(){} // RVA: 0xA37E4E0
        public void get_TimeString(){} // RVA: 0xB5DBF0
        public void GetTime(){} // RVA: 0xA37E590
        public void CalculateGmtOffset(){} // RVA: 0xA37E850
        public void Convert(){} // RVA: 0xA37EB40
        public void ToDateTime(){} // RVA: 0xA37EBA0
        public void FString(){} // RVA: 0xA37EEB0
        public void ParseDateString(){} // RVA: 0xA37EFA0
        public void get_HasFractionalSeconds(){} // RVA: 0xA37F1D0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA37F250
        public void Asn1Equals(){} // RVA: 0xA37F300
        public void Asn1GetHashCode(){} // RVA: 0x1269730
    }

    public class DerGenerator : Asn1Generator
    {
        public object _tagged;
        public object _isExplicit;
        public object _tagNo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA374640
        public void WriteLength(){} // RVA: 0xA37FA60
        public void WriteDerEncoded(){} // RVA: 0xA37FD40
    }

    public class DerGraphicString : DerStringBase
    {
        public object mString;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA380010
        public void .ctor(){} // RVA: 0xA380150
        public void GetString(){} // RVA: 0xA380250
        public void GetOctets(){} // RVA: 0xA380260
        public void Encode(){} // RVA: 0xA380310
        public void Asn1GetHashCode(){} // RVA: 0xA380390
        public void Asn1Equals(){} // RVA: 0xA380430
    }

    public class DerIA5String : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA380690
        public void .ctor(){} // RVA: 0xA380980
        public void GetString(){} // RVA: 0xB5DBF0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA380AE0
        public void Asn1GetHashCode(){} // RVA: 0x1269730
        public void Asn1Equals(){} // RVA: 0xA380B90
        public void IsIA5String(){} // RVA: 0xA380C60
    }

    public class DerInteger : Asn1Object
    {
        public object AllowUnsafeProperty;
        public object bytes;

        // ── Methods ──
        public void AllowUnsafe(){} // RVA: 0xA380CC0
        public void GetInstance(){} // RVA: 0xA380E90
        public void .ctor(){} // RVA: 0xA381180
        public void get_Value(){} // RVA: 0xA381330
        public void get_PositiveValue(){} // RVA: 0xA3813B0
        public void Encode(){} // RVA: 0xA381430
        public void Asn1GetHashCode(){} // RVA: 0xA3814B0
        public void Asn1Equals(){} // RVA: 0xA381550
        public void ToString(){} // RVA: 0xA381690
    }

    public class DerNull : Asn1Null
    {
        public object Instance;
        public object zeroBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA381760
        public void Encode(){} // RVA: 0xA3817F0
        public void Asn1Equals(){} // RVA: 0xA381870
        public void Asn1GetHashCode(){} // RVA: 0xFE6B70
        public void .cctor(){} // RVA: 0xA3818F0
    }

    public class DerNumericString : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA381AC0
        public void .ctor(){} // RVA: 0xA381E70
        public void GetString(){} // RVA: 0xB5DBF0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA382010
        public void Asn1Equals(){} // RVA: 0xA3820C0
        public void IsNumericString(){} // RVA: 0xA382190
    }

    public class DerObjectIdentifier : Asn1Object
    {
        public object identifier;
        public object body;
        public object LONG_LIMIT;
        public object cache;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3823D0
        public void .ctor(){} // RVA: 0xA382A80
        public void get_Id(){} // RVA: 0xB5DBF0
        public void Branch(){} // RVA: 0xA382830
        public void On(){} // RVA: 0xA3829D0
        public void WriteField(){} // RVA: 0xA382D20
        public void DoOutput(){} // RVA: 0xA382EB0
        public void GetBody(){} // RVA: 0xA3830B0
        public void Encode(){} // RVA: 0xA383290
        public void Asn1GetHashCode(){} // RVA: 0x1269730
        public void Asn1Equals(){} // RVA: 0xA383310
        public void ToString(){} // RVA: 0xB5DBF0
        public void IsValidBranchID(){} // RVA: 0xA3833E0
        public void IsValidIdentifier(){} // RVA: 0xA3834D0
        public void MakeOidStringFromBytes(){} // RVA: 0xA383560
        public void FromOctetString(){} // RVA: 0xA383830
        public void .cctor(){} // RVA: 0xA383DA0
    }

    public class DerObjectIdentifier[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DerOctetString : Asn1OctetString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA375490
        public void Encode(){} // RVA: 0xA383EE0
    }

    public class DerOctetStringParser : Object
    {
        public object stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetOctetStream(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA383F70
    }

    public class DerOutputStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA35AA10
        public void WriteLength(){} // RVA: 0xA384110
        public void WriteEncoded(){} // RVA: 0xA3844A0
        public void WriteTag(){} // RVA: 0xA384340
        public void WriteNull(){} // RVA: 0xA384510
        public void WriteObject(){} // RVA: 0xA3847E0
    }

    public class DerPrintableString : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA384970
        public void .ctor(){} // RVA: 0xA384C30
        public void GetString(){} // RVA: 0xB5DBF0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA384D60
        public void Asn1Equals(){} // RVA: 0xA384E10
        public void IsPrintableString(){} // RVA: 0xA384EE0
    }

    public class DerSequence : Asn1Sequence
    {
        public object Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0xA3AFAE0
        public void .ctor(){} // RVA: 0xA3708C0
        public void Encode(){} // RVA: 0xA3AFBD0
        public void .cctor(){} // RVA: 0xA3AFF80
    }

    public class DerSequenceGenerator : DerGenerator
    {
        public object _bOut;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B0140
        public void AddObject(){} // RVA: 0xA3B0270
        public void GetRawOutputStream(){} // RVA: 0xB700F0
        public void Close(){} // RVA: 0xA3B0300
    }

    public class DerSequenceParser : Object
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ReadObject(){} // RVA: 0x10AD380
        public void ToAsn1Object(){} // RVA: 0xA3B0350
    }

    public class DerSet : Asn1Set
    {
        public object Empty;

        // ── Methods ──
        public void FromVector(){} // RVA: 0xA3B0550
        public void .ctor(){} // RVA: 0xA3B0890
        public void Encode(){} // RVA: 0xA3B0970
        public void .cctor(){} // RVA: 0xA3B0D20
    }

    public class DerSetGenerator : DerGenerator
    {
        public object _bOut;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B0EE0
        public void AddObject(){} // RVA: 0xA3B1010
        public void GetRawOutputStream(){} // RVA: 0xB700F0
        public void Close(){} // RVA: 0xA3B10A0
    }

    public class DerSetParser : Object
    {
        public object _parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ReadObject(){} // RVA: 0x10AD380
        public void ToAsn1Object(){} // RVA: 0xA3B10F0
    }

    public class DerStringBase : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetString(){} // RVA: 0x87C0A0
        public void ToString(){} // RVA: 0x11F4110
        public void Asn1GetHashCode(){} // RVA: 0xA3B1200
    }

    public class DerT61String : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B1360
        public void .ctor(){} // RVA: 0xA3B1610
        public void GetString(){} // RVA: 0xB5DBF0
        public void Encode(){} // RVA: 0xA3B16C0
        public void GetOctets(){} // RVA: 0xA3B1750
        public void Asn1Equals(){} // RVA: 0xA3B1760
    }

    public class DerTaggedObject : Asn1TaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B1830
        public void Encode(){} // RVA: 0xA3B18B0
    }

    public class DerUniversalString : DerStringBase
    {
        public object table;
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B1AF0
        public void .ctor(){} // RVA: 0xA3B1DB0
        public void GetString(){} // RVA: 0xA3B1E60
        public void GetOctets(){} // RVA: 0xA3B20C0
        public void Encode(){} // RVA: 0xA3B2140
        public void Asn1Equals(){} // RVA: 0xA3B21C0
        public void .cctor(){} // RVA: 0xA3B2300
    }

    public class DerUtcTime : Asn1Object
    {
        public object time;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B2500
        public void .ctor(){} // RVA: 0xA37E4E0
        public void ToDateTime(){} // RVA: 0xA3B2980
        public void ToAdjustedDateTime(){} // RVA: 0xA3B29D0
        public void ParseDateString(){} // RVA: 0xA3B2A20
        public void get_TimeString(){} // RVA: 0xA3B2AD0
        public void get_AdjustedTime(){} // RVA: 0xA3B32E0
        public void get_AdjustedTimeString(){} // RVA: 0xA3B32F0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA3B3380
        public void Asn1Equals(){} // RVA: 0xA3B3430
        public void Asn1GetHashCode(){} // RVA: 0x1269730
        public void ToString(){} // RVA: 0xB5DBF0
    }

    public class DerUtf8String : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B3620
        public void .ctor(){} // RVA: 0xA3B3830
        public void GetString(){} // RVA: 0xB5DBF0
        public void Asn1Equals(){} // RVA: 0xA3B38E0
        public void Encode(){} // RVA: 0xA3B39B0
    }

    public class DerVideotexString : DerStringBase
    {
        public object mString;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B3CF0
        public void .ctor(){} // RVA: 0xA3B3E30
        public void GetString(){} // RVA: 0xA380250
        public void GetOctets(){} // RVA: 0xA3B3F30
        public void Encode(){} // RVA: 0xA3B3FE0
        public void Asn1GetHashCode(){} // RVA: 0xA3B4060
        public void Asn1Equals(){} // RVA: 0xA3B4100
    }

    public class DerVisibleString : DerStringBase
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3B44C0
        public void .ctor(){} // RVA: 0xA3B4610
        public void GetString(){} // RVA: 0xB5DBF0
        public void GetOctets(){} // RVA: 0xA37F210
        public void Encode(){} // RVA: 0xA3B46C0
        public void Asn1Equals(){} // RVA: 0xA3B4770
        public void Asn1GetHashCode(){} // RVA: 0x1269730
    }

    public class IAsn1ApplicationSpecificParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x87C0A0
    }

    public class IAsn1Convertible
    {
        // ── Methods ──
        public void ToAsn1Object(){} // RVA: 0x87C0A0
    }

    public class IAsn1String
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x87C0A0
    }

    public class IndefiniteLengthInputStream : LimitedInputStream
    {
        public object _lookAhead;
        public object _eofOn00;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B4840
        public void SetEofOn00(){} // RVA: 0xA3B4880
        public void CheckForEof(){} // RVA: 0xA3B4890
        public void Read(){} // RVA: 0xA3B4930
        public void ReadByte(){} // RVA: 0xA3B4A50
        public void RequireByte(){} // RVA: 0xA3B4AA0
    }

    public class LazyAsn1InputStream : Asn1InputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA36D650
        public void CreateDerSequence(){} // RVA: 0xA3B4B20
        public void CreateDerSet(){} // RVA: 0xA3B4C10
    }

    public class LazyDerSequence : DerSequence
    {
        public object encoded;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B4D00
        public void Parse(){} // RVA: 0xA3B4DB0
        public void get_Item(){} // RVA: 0xA3B51B0
        public void GetEnumerator(){} // RVA: 0xA3B5200
        public void get_Count(){} // RVA: 0xA3B5230
        public void Encode(){} // RVA: 0xA3B5260
    }

    public class LazyDerSet : DerSet
    {
        public object encoded;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B5410
        public void Parse(){} // RVA: 0xA3B54C0
        public void get_Item(){} // RVA: 0xA3B58C0
        public void GetEnumerator(){} // RVA: 0xA3B5910
        public void get_Count(){} // RVA: 0xA3B5940
        public void Encode(){} // RVA: 0xA3B5970
    }

    public class LimitedInputStream : BaseInputStream
    {
        public object _in;
        public object _limit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3B5B20
        public void GetRemaining(){} // RVA: 0x18A0130
        public void SetParentEofDetect(){} // RVA: 0xA3B5BE0
    }

    public class OidTokenizer : Object
    {
        public object oid;
        public object index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_HasMoreTokens(){} // RVA: 0xA3B5C90
        public void NextToken(){} // RVA: 0xA3B5CA0
    }

}