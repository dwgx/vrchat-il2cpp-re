// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
// Classes: 83
// Methods: 459

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
    public class Asn1Encodable : Object
    {
        // ── Methods ──
        public void GetEncoded(){} // RVA: 0x7B1500E60
        public void GetDerEncoded(){} // RVA: 0x7B1500FA0
        public void GetHashCode(){} // RVA: 0x7B1500FF0
        public void Equals(){} // RVA: 0x7B1501030
        public void ToAsn1Object(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Asn1EncodableVector : Object
    {
        // ── Methods ──
        public void FromEnumerable(){} // RVA: 0x7B1501120
        public void .ctor(){} // RVA: 0x7B15015A0
        public void Add(){} // RVA: 0x7B15016E0
        public void AddOptional(){} // RVA: 0x7B1501830
        public void AddOptionalTagged(){} // RVA: 0x7B15018A0
        public void AddAll(){} // RVA: 0x7B1501940
        public void get_Item(){} // RVA: 0x7B1501B40
        public void get_Count(){} // RVA: 0x7A83782A0
        public void GetEnumerator(){} // RVA: 0x7B1501C10
        public void CopyElements(){} // RVA: 0x7B1501CE0
        public void TakeElements(){} // RVA: 0x7B1501DA0
        public void Reallocate(){} // RVA: 0x7B1501E80
        public void CloneElements(){} // RVA: 0x7B1501F90
        public void .cctor(){} // RVA: 0x7B1502050
    }

    public class Asn1Encodable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Asn1Exception : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class Asn1Generator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Out(){} // RVA: 0x7A80F2570
        public void AddObject(){} // RVA: 0x7A7E18800
        public void GetRawOutputStream(){} // RVA: 0x7A7E00680
        public void Close(){} // RVA: 0x7A7E18770
    }

    public class Asn1InputStream : FilterStream
    {
        // ── Methods ──
        public void FindLimit(){} // RVA: 0x7B1502100
        public void .ctor(){} // RVA: 0x7B1502360
        public void BuildObject(){} // RVA: 0x7B15023F0
        public void ReadVector(){} // RVA: 0x7B1502710
        public void CreateDerSequence(){} // RVA: 0x7B15029C0
        public void CreateDerSet(){} // RVA: 0x7B1502A40
        public void ReadObject(){} // RVA: 0x7B1502B90
        public void ReadTagNumber(){} // RVA: 0x7B15031F0
        public void ReadLength(){} // RVA: 0x7B1503310
        public void GetBuffer(){} // RVA: 0x7B1503580
        public void CreatePrimitiveDerObject(){} // RVA: 0x7B1503660
    }

    public class Asn1Null : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ToString(){} // RVA: 0x7B1503E40
    }

    public class Asn1Object : Asn1Encodable
    {
        // ── Methods ──
        public void FromByteArray(){} // RVA: 0x7B1503E80
        public void FromStream(){} // RVA: 0x7B1504020
        public void ToAsn1Object(){} // RVA: 0x7A97F8BA0
        public void Encode(){} // RVA: 0x7A7E18800
        public void Asn1Equals(){} // RVA: 0x7A7E019D0
        public void Asn1GetHashCode(){} // RVA: 0x7A7E00710
        public void CallAsn1Equals(){} // RVA: 0x7ACF03DA0
        public void CallAsn1GetHashCode(){} // RVA: 0x7A874BF50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Asn1OctetString : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15041C0
        public void .ctor(){} // RVA: 0x7B1504440
        public void GetOctetStream(){} // RVA: 0x7B1504570
        public void get_Parser(){} // RVA: 0x7A97F8BA0
        public void GetOctets(){} // RVA: 0x7A80F2570
        public void Asn1GetHashCode(){} // RVA: 0x7B15045D0
        public void Asn1Equals(){} // RVA: 0x7B1504680
        public void ToString(){} // RVA: 0x7B15047E0
    }

    public class Asn1OctetStringParser
    {
        // ── Methods ──
        public void GetOctetStream(){} // RVA: 0x7A7E00680
    }

    public class Asn1OutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14EF610
        public void WriteObject(){} // RVA: 0x7B15048A0
    }

    public class Asn1ParsingException : InvalidOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC89D20
    }

    public class Asn1Sequence : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1504E80
        public void .ctor(){} // RVA: 0x7B15054D0
        public void GetEnumerator(){} // RVA: 0x7A9AAAAE0
        public void get_Parser(){} // RVA: 0x7B1505580
        public void get_Item(){} // RVA: 0x7AE8C8950
        public void get_Count(){} // RVA: 0x7A8D0A110
        public void ToArray(){} // RVA: 0x7B1505650
        public void Asn1GetHashCode(){} // RVA: 0x7B15056B0
        public void Asn1Equals(){} // RVA: 0x7B1505770
        public void ToString(){} // RVA: 0x7B1505940
    }

    public class Asn1SequenceParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7A7E00680
    }

    public class Asn1Set : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1505F30
        public void .ctor(){} // RVA: 0x7B15067D0
        public void GetEnumerator(){} // RVA: 0x7A9AAAAE0
        public void get_Item(){} // RVA: 0x7AE8C8950
        public void get_Count(){} // RVA: 0x7A8D0A110
        public void ToArray(){} // RVA: 0x7B1506880
        public void get_Parser(){} // RVA: 0x7B15068E0
        public void Asn1GetHashCode(){} // RVA: 0x7B15056B0
        public void Asn1Equals(){} // RVA: 0x7B15069B0
        public void Sort(){} // RVA: 0x7B1506B80
        public void ToString(){} // RVA: 0x7B1505940
    }

    public class Asn1SetParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7A7E00680
    }

    public class Asn1StreamParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15072E0
        public void ReadIndef(){} // RVA: 0x7B1507370
        public void ReadImplicit(){} // RVA: 0x7B1507520
        public void ReadTaggedObject(){} // RVA: 0x7B1507870
        public void ReadObject(){} // RVA: 0x7B1507D30
        public void Set00Check(){} // RVA: 0x7B15083C0
        public void ReadVector(){} // RVA: 0x7B1508470
    }

    public class Asn1TaggedObject : Asn1Object
    {
        // ── Methods ──
        public void IsConstructed(){} // RVA: 0x7B1508690
        public void GetInstance(){} // RVA: 0x7B1508890
        public void .ctor(){} // RVA: 0x7B1508A20
        public void Asn1Equals(){} // RVA: 0x7B1508AF0
        public void Asn1GetHashCode(){} // RVA: 0x7B1508C30
        public void get_TagNo(){} // RVA: 0x7A8124910
        public void IsExplicit(){} // RVA: 0x7A8227C00
        public void IsEmpty(){} // RVA: 0x7A80D7320
        public void GetObject(){} // RVA: 0x7B1508C70
        public void GetObjectParser(){} // RVA: 0x7B1508CA0
        public void ToString(){} // RVA: 0x7B1508DC0
    }

    public class Asn1TaggedObjectParser
    {
        // ── Methods ──
        public void get_TagNo(){} // RVA: 0x7A7E00710
        public void GetObjectParser(){} // RVA: 0x7A7E10AC0
    }

    public class Asn1Tags : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BerApplicationSpecific : DerApplicationSpecific
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1508E70
    }

    public class BerApplicationSpecificParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void ReadObject(){} // RVA: 0x7B1508E80
        public void ToAsn1Object(){} // RVA: 0x7B1508EB0
    }

    public class BerBitString : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1509080
        public void Encode(){} // RVA: 0x7B1509100
    }

    public class BerGenerator : Asn1Generator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1509250
        public void AddObject(){} // RVA: 0x7B15092B0
        public void GetRawOutputStream(){} // RVA: 0x7A80F2570
        public void Close(){} // RVA: 0x7B1509340
        public void WriteHdr(){} // RVA: 0x7B1509350
        public void WriteBerHeader(){} // RVA: 0x7B15093A0
        public void WriteBerBody(){} // RVA: 0x7B1509480
        public void WriteBerEnd(){} // RVA: 0x7B1509550
    }

    public class BerNull : DerNull
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15096D0
        public void Encode(){} // RVA: 0x7B1509730
        public void .cctor(){} // RVA: 0x7B1509860
    }

    public class BerOctetString : DerOctetString
    {
        // ── Methods ──
        public void FromSequence(){} // RVA: 0x7B1509950
        public void ToBytes(){} // RVA: 0x7B1509C90
        public void .ctor(){} // RVA: 0x7B150A0B0
        public void GetOctets(){} // RVA: 0x7A80F2570
        public void GetEnumerator(){} // RVA: 0x7B150A0F0
        public void GetObjects(){} // RVA: 0x7B150A170
        public void GenerateOcts(){} // RVA: 0x7B150A180
        public void Encode(){} // RVA: 0x7B150A3F0
    }

    public class BerOctetStringGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150A7E0
        public void GetOctetOutputStream(){} // RVA: 0x7B150A9D0
    }

    public class BerOctetStringParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetOctetStream(){} // RVA: 0x7B150B0A0
        public void ToAsn1Object(){} // RVA: 0x7B150B170
    }

    public class BerOutputStream : DerOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14EF610
        public void WriteObject(){} // RVA: 0x7B150B3C0
    }

    public class BerSequence : DerSequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7B150B5C0
        public void .ctor(){} // RVA: 0x7B150B770
        public void Encode(){} // RVA: 0x7B150B870
        public void .cctor(){} // RVA: 0x7B150BBA0
    }

    public class BerSequenceGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150BD00
    }

    public class BerSequenceParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ReadObject(){} // RVA: 0x7A858AA80
        public void ToAsn1Object(){} // RVA: 0x7B150BE10
    }

    public class BerSet : DerSet
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7B150BF30
        public void .ctor(){} // RVA: 0x7B150C190
        public void Encode(){} // RVA: 0x7B150C2B0
        public void .cctor(){} // RVA: 0x7B150C5E0
    }

    public class BerSetGenerator : BerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150C740
    }

    public class BerSetParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ReadObject(){} // RVA: 0x7A858AA80
        public void ToAsn1Object(){} // RVA: 0x7B150C850
    }

    public class BerTaggedObject : DerTaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150C9A0
        public void Encode(){} // RVA: 0x7B150CA20
    }

    public class BerTaggedObjectParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150D280
        public void get_IsConstructed(){} // RVA: 0x7A81A2200
        public void get_TagNo(){} // RVA: 0x7A8668BC0
        public void GetObjectParser(){} // RVA: 0x7B150D2E0
        public void ToAsn1Object(){} // RVA: 0x7B150D390
    }

    public class ConstructedOctetStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150D440
        public void Read(){} // RVA: 0x7B150D4E0
        public void ReadByte(){} // RVA: 0x7B150D7E0
    }

    public class DefiniteLengthInputStream : LimitedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150DAB0
        public void get_Remaining(){} // RVA: 0x7A8178B50
        public void ReadByte(){} // RVA: 0x7B150DB60
        public void Read(){} // RVA: 0x7B150DC80
        public void ReadAllIntoByteArray(){} // RVA: 0x7B150DE00
        public void ToArray(){} // RVA: 0x7B150DFA0
        public void .cctor(){} // RVA: 0x7B150E180
    }

    public class DerApplicationSpecific : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150E500
        public void GetLengthOfHeader(){} // RVA: 0x7B150E6C0
        public void IsConstructed(){} // RVA: 0x7A81A2200
        public void GetContents(){} // RVA: 0x7A80DA7B0
        public void get_ApplicationTag(){} // RVA: 0x7A8668BC0
        public void GetObject(){} // RVA: 0x7B150E7A0
        public void Encode(){} // RVA: 0x7B150E990
        public void Asn1Equals(){} // RVA: 0x7B150EA10
        public void Asn1GetHashCode(){} // RVA: 0x7B150EAE0
        public void ReplaceTagNumber(){} // RVA: 0x7B150EBC0
    }

    public class DerBitString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B150EFA0
        public void .ctor(){} // RVA: 0x7B150F480
        public void GetOctets(){} // RVA: 0x7B150F4C0
        public void GetBytes(){} // RVA: 0x7B150F5C0
        public void get_PadBits(){} // RVA: 0x7A83782A0
        public void get_IntValue(){} // RVA: 0x7B150F6C0
        public void Encode(){} // RVA: 0x7B150F7C0
        public void Asn1GetHashCode(){} // RVA: 0x7B150F970
        public void Asn1Equals(){} // RVA: 0x7B150FA20
        public void GetString(){} // RVA: 0x7B150FB70
        public void FromAsn1Octets(){} // RVA: 0x7B150FDD0
        public void .cctor(){} // RVA: 0x7B150FFB0
    }

    public class DerBmpString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15101B0
        public void .ctor(){} // RVA: 0x7B1510530
        public void GetString(){} // RVA: 0x7A80F2570
        public void Asn1Equals(){} // RVA: 0x7B15105E0
        public void Encode(){} // RVA: 0x7B15106B0
    }

    public class DerBoolean : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15109B0
        public void .ctor(){} // RVA: 0x7B1510BA0
        public void get_IsTrue(){} // RVA: 0x7B1510BC0
        public void Encode(){} // RVA: 0x7B1510BD0
        public void Asn1Equals(){} // RVA: 0x7B1510CA0
        public void Asn1GetHashCode(){} // RVA: 0x7B1510D30
        public void ToString(){} // RVA: 0x7B1510D80
        public void FromOctetString(){} // RVA: 0x7B1510DE0
        public void .cctor(){} // RVA: 0x7B1510F90
    }

    public class DerEnumerated : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1511200
        public void .ctor(){} // RVA: 0x7B15114A0
        public void get_Value(){} // RVA: 0x7B1511650
        public void Encode(){} // RVA: 0x7B15116D0
        public void Asn1Equals(){} // RVA: 0x7B1511750
        public void Asn1GetHashCode(){} // RVA: 0x7B1511890
        public void FromOctetString(){} // RVA: 0x7B1511930
        public void .cctor(){} // RVA: 0x7B1511C20
    }

    public class DerExternal : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15123F0
        public void Encode(){} // RVA: 0x7B1512590
        public void Asn1GetHashCode(){} // RVA: 0x7B1512820
        public void Asn1Equals(){} // RVA: 0x7B15128D0
        public void get_DataValueDescriptor(){} // RVA: 0x7A81052C0
        public void set_DataValueDescriptor(){} // RVA: 0x7A81052D0
        public void get_DirectReference(){} // RVA: 0x7A80F2570
        public void set_DirectReference(){} // RVA: 0x7A80D8E20
        public void get_Encoding(){} // RVA: 0x7A854FDE0
        public void set_Encoding(){} // RVA: 0x7B1512A30
        public void get_ExternalContent(){} // RVA: 0x7A83F69F0
        public void set_ExternalContent(){} // RVA: 0x7A8105A90
        public void get_IndirectReference(){} // RVA: 0x7A80DA7B0
        public void set_IndirectReference(){} // RVA: 0x7A813E420
        public void GetObjFromVector(){} // RVA: 0x7B1512AD0
        public void WriteEncodable(){} // RVA: 0x7B1512B80
    }

    public class DerExternalParser : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ReadObject(){} // RVA: 0x7A858AA80
        public void ToAsn1Object(){} // RVA: 0x7B1512BE0
    }

    public class DerGeneralString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1514110
        public void .ctor(){} // RVA: 0x7B1514450
        public void GetString(){} // RVA: 0x7A80F2570
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1514500
        public void Asn1Equals(){} // RVA: 0x7B15145B0
    }

    public class DerGeneralizedTime : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1512D90
        public void .ctor(){} // RVA: 0x7B15130E0
        public void get_TimeString(){} // RVA: 0x7A80F2570
        public void GetTime(){} // RVA: 0x7B1513190
        public void CalculateGmtOffset(){} // RVA: 0x7B1513450
        public void Convert(){} // RVA: 0x7B1513770
        public void ToDateTime(){} // RVA: 0x7B15137D0
        public void FString(){} // RVA: 0x7B1513AE0
        public void ParseDateString(){} // RVA: 0x7B1513BD0
        public void get_HasFractionalSeconds(){} // RVA: 0x7B1513DF0
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1513E70
        public void Asn1Equals(){} // RVA: 0x7B1513F20
        public void Asn1GetHashCode(){} // RVA: 0x7A8738190
    }

    public class DerGenerator : Asn1Generator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1509250
        public void WriteLength(){} // RVA: 0x7B1514680
        public void WriteDerEncoded(){} // RVA: 0x7B1514960
    }

    public class DerGraphicString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1514C30
        public void .ctor(){} // RVA: 0x7B1514D70
        public void GetString(){} // RVA: 0x7B1514E70
        public void GetOctets(){} // RVA: 0x7B1514E80
        public void Encode(){} // RVA: 0x7B1514F30
        public void Asn1GetHashCode(){} // RVA: 0x7B1514FB0
        public void Asn1Equals(){} // RVA: 0x7B1515050
    }

    public class DerIA5String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15152B0
        public void .ctor(){} // RVA: 0x7B15155A0
        public void GetString(){} // RVA: 0x7A80F2570
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1515700
        public void Asn1GetHashCode(){} // RVA: 0x7A8738190
        public void Asn1Equals(){} // RVA: 0x7B15157B0
        public void IsIA5String(){} // RVA: 0x7B1515880
    }

    public class DerInteger : Asn1Object
    {
        // ── Methods ──
        public void AllowUnsafe(){} // RVA: 0x7B15158E0
        public void GetInstance(){} // RVA: 0x7B1515AB0
        public void .ctor(){} // RVA: 0x7B1515DA0
        public void get_Value(){} // RVA: 0x7B1515F50
        public void get_PositiveValue(){} // RVA: 0x7B1515FD0
        public void Encode(){} // RVA: 0x7B1516050
        public void Asn1GetHashCode(){} // RVA: 0x7B15160D0
        public void Asn1Equals(){} // RVA: 0x7B1516170
        public void ToString(){} // RVA: 0x7B15162B0
    }

    public class DerNull : Asn1Null
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1516380
        public void Encode(){} // RVA: 0x7B1516410
        public void Asn1Equals(){} // RVA: 0x7B1516490
        public void Asn1GetHashCode(){} // RVA: 0x7A85193D0
        public void .cctor(){} // RVA: 0x7B1516510
    }

    public class DerNumericString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15166E0
        public void .ctor(){} // RVA: 0x7B1516A90
        public void GetString(){} // RVA: 0x7A80F2570
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1516C60
        public void Asn1Equals(){} // RVA: 0x7B1516D10
        public void IsNumericString(){} // RVA: 0x7B1516DE0
    }

    public class DerObjectIdentifier : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1517040
        public void .ctor(){} // RVA: 0x7B15176F0
        public void get_Id(){} // RVA: 0x7A80F2570
        public void Branch(){} // RVA: 0x7B15174A0
        public void On(){} // RVA: 0x7B1517640
        public void WriteField(){} // RVA: 0x7B1517990
        public void DoOutput(){} // RVA: 0x7B1517B20
        public void GetBody(){} // RVA: 0x7B1517D20
        public void Encode(){} // RVA: 0x7B1517F00
        public void Asn1GetHashCode(){} // RVA: 0x7A8738190
        public void Asn1Equals(){} // RVA: 0x7B1517F80
        public void ToString(){} // RVA: 0x7A80F2570
        public void IsValidBranchID(){} // RVA: 0x7B1518050
        public void IsValidIdentifier(){} // RVA: 0x7B1518140
        public void MakeOidStringFromBytes(){} // RVA: 0x7B15181D0
        public void FromOctetString(){} // RVA: 0x7B15184A0
        public void .cctor(){} // RVA: 0x7B1518A10
    }

    public class DerObjectIdentifier[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class DerOctetString : Asn1OctetString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B150A0A0
        public void Encode(){} // RVA: 0x7B1518B50
    }

    public class DerOctetStringParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetOctetStream(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1518BE0
    }

    public class DerOutputStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14EF610
        public void WriteLength(){} // RVA: 0x7B1518D80
        public void WriteEncoded(){} // RVA: 0x7B1519110
        public void WriteTag(){} // RVA: 0x7B1518FB0
        public void WriteNull(){} // RVA: 0x7B1519180
        public void WriteObject(){} // RVA: 0x7B1519450
    }

    public class DerPrintableString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15195E0
        public void .ctor(){} // RVA: 0x7B15198A0
        public void GetString(){} // RVA: 0x7A80F2570
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B15199D0
        public void Asn1Equals(){} // RVA: 0x7B1519A80
        public void IsPrintableString(){} // RVA: 0x7B1519B50
    }

    public class DerSequence : Asn1Sequence
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7B1544970
        public void .ctor(){} // RVA: 0x7B15054D0
        public void Encode(){} // RVA: 0x7B1544A60
        public void .cctor(){} // RVA: 0x7B1544E10
    }

    public class DerSequenceGenerator : DerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1544FD0
        public void AddObject(){} // RVA: 0x7B1545100
        public void GetRawOutputStream(){} // RVA: 0x7A81052C0
        public void Close(){} // RVA: 0x7B1545190
    }

    public class DerSequenceParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ReadObject(){} // RVA: 0x7A858AA80
        public void ToAsn1Object(){} // RVA: 0x7B15451E0
    }

    public class DerSet : Asn1Set
    {
        // ── Methods ──
        public void FromVector(){} // RVA: 0x7B15453E0
        public void .ctor(){} // RVA: 0x7B1545720
        public void Encode(){} // RVA: 0x7B1545800
        public void .cctor(){} // RVA: 0x7B1545BB0
    }

    public class DerSetGenerator : DerGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1545D70
        public void AddObject(){} // RVA: 0x7B1545EA0
        public void GetRawOutputStream(){} // RVA: 0x7A81052C0
        public void Close(){} // RVA: 0x7B1545F30
    }

    public class DerSetParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ReadObject(){} // RVA: 0x7A858AA80
        public void ToAsn1Object(){} // RVA: 0x7B1545F80
    }

    public class DerStringBase : Asn1Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetString(){} // RVA: 0x7A7E00680
        public void ToString(){} // RVA: 0x7AB5DC320
        public void Asn1GetHashCode(){} // RVA: 0x7B1546090
    }

    public class DerT61String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15461F0
        public void .ctor(){} // RVA: 0x7B15464A0
        public void GetString(){} // RVA: 0x7A80F2570
        public void Encode(){} // RVA: 0x7B1546550
        public void GetOctets(){} // RVA: 0x7B15465E0
        public void Asn1Equals(){} // RVA: 0x7B15465F0
    }

    public class DerTaggedObject : Asn1TaggedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15466C0
        public void Encode(){} // RVA: 0x7B1546740
    }

    public class DerUniversalString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1546980
        public void .ctor(){} // RVA: 0x7B1546C40
        public void GetString(){} // RVA: 0x7B1546CF0
        public void GetOctets(){} // RVA: 0x7B1546F50
        public void Encode(){} // RVA: 0x7B1546FD0
        public void Asn1Equals(){} // RVA: 0x7B1547050
        public void .cctor(){} // RVA: 0x7B1547190
    }

    public class DerUtcTime : Asn1Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1547390
        public void .ctor(){} // RVA: 0x7B15130E0
        public void ToDateTime(){} // RVA: 0x7B1547810
        public void ToAdjustedDateTime(){} // RVA: 0x7B1547860
        public void ParseDateString(){} // RVA: 0x7B15478B0
        public void get_TimeString(){} // RVA: 0x7B1547960
        public void get_AdjustedTime(){} // RVA: 0x7B1547C90
        public void get_AdjustedTimeString(){} // RVA: 0x7B1547CA0
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1547D30
        public void Asn1Equals(){} // RVA: 0x7B1547DE0
        public void Asn1GetHashCode(){} // RVA: 0x7A8738190
        public void ToString(){} // RVA: 0x7A80F2570
    }

    public class DerUtf8String : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1547FD0
        public void .ctor(){} // RVA: 0x7B15481E0
        public void GetString(){} // RVA: 0x7A80F2570
        public void Asn1Equals(){} // RVA: 0x7B1548290
        public void Encode(){} // RVA: 0x7B1548360
    }

    public class DerVideotexString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15486A0
        public void .ctor(){} // RVA: 0x7B15487E0
        public void GetString(){} // RVA: 0x7B1514E70
        public void GetOctets(){} // RVA: 0x7B15488E0
        public void Encode(){} // RVA: 0x7B1548990
        public void Asn1GetHashCode(){} // RVA: 0x7B1548A10
        public void Asn1Equals(){} // RVA: 0x7B1548AB0
    }

    public class DerVisibleString : DerStringBase
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1548E70
        public void .ctor(){} // RVA: 0x7B1548FC0
        public void GetString(){} // RVA: 0x7A80F2570
        public void GetOctets(){} // RVA: 0x7B1513E30
        public void Encode(){} // RVA: 0x7B1549070
        public void Asn1Equals(){} // RVA: 0x7B1549120
        public void Asn1GetHashCode(){} // RVA: 0x7A8738190
    }

    public class IAsn1ApplicationSpecificParser
    {
        // ── Methods ──
        public void ReadObject(){} // RVA: 0x7A7E00680
    }

    public class IAsn1Convertible
    {
        // ── Methods ──
        public void ToAsn1Object(){} // RVA: 0x7A7E00680
    }

    public class IAsn1String
    {
        // ── Methods ──
        public void GetString(){} // RVA: 0x7A7E00680
    }

    public class IndefiniteLengthInputStream : LimitedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15491F0
        public void SetEofOn00(){} // RVA: 0x7B1549230
        public void CheckForEof(){} // RVA: 0x7B1549240
        public void Read(){} // RVA: 0x7B15492E0
        public void ReadByte(){} // RVA: 0x7B1549400
        public void RequireByte(){} // RVA: 0x7B1549450
    }

    public class LazyAsn1InputStream : Asn1InputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1502260
        public void CreateDerSequence(){} // RVA: 0x7B15494D0
        public void CreateDerSet(){} // RVA: 0x7B15495C0
    }

    public class LazyDerSequence : DerSequence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15496B0
        public void Parse(){} // RVA: 0x7B1549760
        public void get_Item(){} // RVA: 0x7B1549B60
        public void GetEnumerator(){} // RVA: 0x7B1549BB0
        public void get_Count(){} // RVA: 0x7B1549BE0
        public void Encode(){} // RVA: 0x7B1549C10
    }

    public class LazyDerSet : DerSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1549DC0
        public void Parse(){} // RVA: 0x7B1549E70
        public void get_Item(){} // RVA: 0x7B154A270
        public void GetEnumerator(){} // RVA: 0x7B154A2C0
        public void get_Count(){} // RVA: 0x7B154A2F0
        public void Encode(){} // RVA: 0x7B154A320
    }

    public class LimitedInputStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B154A4D0
        public void GetRemaining(){} // RVA: 0x7A8D863F0
        public void SetParentEofDetect(){} // RVA: 0x7B154A590
    }

    public class OidTokenizer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_HasMoreTokens(){} // RVA: 0x7B154A640
        public void NextToken(){} // RVA: 0x7B154A650
    }

}