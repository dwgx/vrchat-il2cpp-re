// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
// Classes: 43
// Methods: 374

namespace ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
{
    public class BinaryArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4B070 | overloaded x2
        public void Set(){} // RVA: 0x7FFE8685AFA0
        public void Write(){} // RVA: 0x7FFE8685B120
        public void Read(){} // RVA: 0x7FFE8685B490
    }

    public class BinaryAssembly : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE82A53990
        public void Write(){} // RVA: 0x7FFE868596C0
        public void Read(){} // RVA: 0x7FFE86859750
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryAssemblyInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void GetAssembly(){} // RVA: 0x7FFE868591F0
    }

    public class BinaryConverter : Object
    {
        // ── Methods ──
        public void GetBinaryTypeInfo(){} // RVA: 0x7FFE86857F60
        public void GetParserBinaryTypeInfo(){} // RVA: 0x7FFE86858340
        public void WriteTypeInfo(){} // RVA: 0x7FFE86858660
        public void ReadTypeInfo(){} // RVA: 0x7FFE868588E0
        public void TypeFromInfo(){} // RVA: 0x7FFE86858B00
    }

    public class BinaryCrossAppDomainAssembly : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE86859810
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryCrossAppDomainMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE8685A0E0
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryCrossAppDomainString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE86859810
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryFormatter : Object
    {
        public System.Runtime.Serialization.ISurrogateSelector m_surrogates; // 0x10
        public System.Runtime.Serialization.StreamingContext m_context; // 0x18

        // ── Methods ──
        public void set_AssemblyFormat(){} // RVA: 0x7FFE82443340
        public void set_SurrogateSelector(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE868619A0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFE86861D90 | overloaded x3
        public void Serialize(){} // RVA: 0x7FFE86861DF0 | overloaded x3
        public void GetTypeInformation(){} // RVA: 0x7FFE868621C0
        public void .cctor(){} // RVA: 0x7FFE86862600
    }

    public class BinaryMethodCall : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE86859910
        public void Dump(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81F0FA70
    }

    public class BinaryMethodReturn : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86859C90
        public void .ctor(){} // RVA: 0x7FFE825203D0
        public void Write(){} // RVA: 0x7FFE86859D90
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE85072A80
        public void Write(){} // RVA: 0x7FFE86859880
        public void Read(){} // RVA: 0x7FFE86859810
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryObjectString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE82A53990
        public void Write(){} // RVA: 0x7FFE8685A050
        public void Read(){} // RVA: 0x7FFE86859750
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryObjectWithMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFE8685A240
        public void Write(){} // RVA: 0x7FFE8685A310
        public void Read(){} // RVA: 0x7FFE8685A440
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryObjectWithMapTyped : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFE8685A690
        public void Write(){} // RVA: 0x7FFE8685A880
        public void Read(){} // RVA: 0x7FFE8685AA90
    }

    public class Converter : Object
    {
        // ── Methods ──
        public void ToCode(){} // RVA: 0x7FFE8685D7B0
        public void IsWriteAsByteArray(){} // RVA: 0x7FFE8685DA10
        public void TypeLength(){} // RVA: 0x7FFE8685DA80
        public void ToArrayType(){} // RVA: 0x7FFE8685DB00
        public void InitTypeA(){} // RVA: 0x7FFE8685DBD0
        public void InitArrayTypeA(){} // RVA: 0x7FFE8685E210
        public void ToType(){} // RVA: 0x7FFE8685E860
        public void CreatePrimitiveArray(){} // RVA: 0x7FFE8685E930
        public void IsPrimitiveArray(){} // RVA: 0x7FFE8685EB60
        public void InitValueA(){} // RVA: 0x7FFE8685EF50
        public void ToComType(){} // RVA: 0x7FFE8685F300
        public void InitTypeCodeA(){} // RVA: 0x7FFE8685F3D0
        public void ToTypeCode(){} // RVA: 0x7FFE8685F5E0
        public void InitCodeA(){} // RVA: 0x7FFE8685F6B0
        public void ToPrimitiveTypeEnum(){} // RVA: 0x7FFE8685F8D0
        public void FromString(){} // RVA: 0x7FFE8685F9A0
        public void .cctor(){} // RVA: 0x7FFE8685FB30
    }

    public class IOUtil : Object
    {
        // ── Methods ──
        public void FlagTest(){} // RVA: 0x7FFE826077A0
        public void WriteStringWithCode(){} // RVA: 0x7FFE86859000
        public void WriteWithCode(){} // RVA: 0x7FFE86859090
    }

    public class IntSizedArray : Object
    {
        public int[] objects; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687C4C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8687C6F0
        public void get_Item(){} // RVA: 0x7FFE8687C750
        public void set_Item(){} // RVA: 0x7FFE8687C7C0
        public void IncreaseCapacity(){} // RVA: 0x7FFE8687C870
    }

    public class InternalFE : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MemberPrimitiveTyped : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE82A53990
        public void Write(){} // RVA: 0x7FFE8685A120
        public void Read(){} // RVA: 0x7FFE8685A1A0
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class MemberPrimitiveUnTyped : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void Write(){} // RVA: 0x7FFE8685BE10
        public void Read(){} // RVA: 0x7FFE8685BE40
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class MemberReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE810FE0C0
        public void Write(){} // RVA: 0x7FFE8685BEC0
        public void Read(){} // RVA: 0x7FFE8685A0E0
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class MessageEnd : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Write(){} // RVA: 0x7FFE8685C0D0
        public void Read(){} // RVA: 0x7FFE810FB310
        public void Dump(){} // RVA: 0x7FFE810FB310 | overloaded x2
    }

    public class NameCache : Object
    {
        // ── Methods ──
        public void GetCachedValue(){} // RVA: 0x7FFE8687CAE0
        public void SetCachedValue(){} // RVA: 0x7FFE8687CC80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8687CD20
    }

    public class NameInfo : Object
    {
        public string NIFullName; // 0x10
        public long NIobjectId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8687D380
        public void get_IsSealed(){} // RVA: 0x7FFE8687D460
        public void get_NIname(){} // RVA: 0x7FFE8687D4B0
        public void set_NIname(){} // RVA: 0x7FFE810FCE30
    }

    public class ObjectMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8685C720 | overloaded x2
        public void CreateObjectInfo(){} // RVA: 0x7FFE8685CF50
        public void Create(){} // RVA: 0x7FFE8685D050 | overloaded x2
    }

    public class ObjectMapInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86865900
        public void isCompatible(){} // RVA: 0x7FFE868659C0
    }

    public class ObjectNull : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void SetNullCount(){} // RVA: 0x7FFE810FE0C0
        public void Write(){} // RVA: 0x7FFE8685BF30
        public void Read(){} // RVA: 0x7FFE8685C030
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class ObjectProgress : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8685D130
        public void Init(){} // RVA: 0x7FFE8685D1D0
        public void ArrayCountIncrement(){} // RVA: 0x7FFE8685D4C0
        public void GetNext(){} // RVA: 0x7FFE8685D4D0
        public void .cctor(){} // RVA: 0x7FFE8685D770
    }

    public class ObjectReader : Object
    {
        public System.IO.Stream m_stream; // 0x10
        public System.Runtime.Serialization.ISurrogateSelector m_surrogates; // 0x18

        // ── Methods ──
        public void get_ValueFixupStack(){} // RVA: 0x7FFE8686A990
        public void get_TopObject(){} // RVA: 0x7FFE81199370
        public void set_TopObject(){} // RVA: 0x7FFE8686AA60
        public void .ctor(){} // RVA: 0x7FFE8686AB20
        public void Deserialize(){} // RVA: 0x7FFE8686ADF0
        public void HasSurrogate(){} // RVA: 0x7FFE8686B2A0
        public void CheckSerializable(){} // RVA: 0x7FFE8686B3A0
        public void InitFullDeserialization(){} // RVA: 0x7FFE8686B4E0
        public void CrossAppDomainArray(){} // RVA: 0x7FFE8686B700
        public void CreateReadObjectInfo(){} // RVA: 0x7FFE8686B780 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE8686B8A0
        public void ParseError(){} // RVA: 0x7FFE8686BAD0
        public void ParseSerializedStreamHeader(){} // RVA: 0x7FFE8686BD40
        public void ParseSerializedStreamHeaderEnd(){} // RVA: 0x7FFE8686BD70
        public void ParseObject(){} // RVA: 0x7FFE8686BDA0
        public void ParseObjectEnd(){} // RVA: 0x7FFE8686C290
        public void ParseArray(){} // RVA: 0x7FFE8686C640
        public void NextRectangleMap(){} // RVA: 0x7FFE8686D1D0
        public void ParseArrayMember(){} // RVA: 0x7FFE8686D2C0
        public void ParseArrayMemberEnd(){} // RVA: 0x7FFE8686E030
        public void ParseMember(){} // RVA: 0x7FFE8686E060
        public void ParseMemberEnd(){} // RVA: 0x7FFE8686EA20
        public void ParseString(){} // RVA: 0x7FFE8686EAD0
        public void RegisterObject(){} // RVA: 0x7FFE8686EC10 | overloaded x2
        public void GetId(){} // RVA: 0x7FFE8686EE40
        public void Bind(){} // RVA: 0x7FFE8686F170
        public void FastBindToType(){} // RVA: 0x7FFE8686F1D0
        public void ResolveSimpleAssemblyName(){} // RVA: 0x7FFE8686F740
        public void GetSimplyNamedTypeFromAssembly(){} // RVA: 0x7FFE8686F800
        public void GetType(){} // RVA: 0x7FFE8686FAF0
        public void CheckTypeForwardedTo(){} // RVA: 0x7FFE8686FFF0
    }

    public class ObjectWriter : Object
    {
        public System.Collections.Queue m_objectQueue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86870140
        public void Serialize(){} // RVA: 0x7FFE868704F0
        public void get_ObjectManager(){} // RVA: 0x7FFE81176730
        public void Write(){} // RVA: 0x7FFE86871450 | overloaded x2
        public void WriteMemberSetup(){} // RVA: 0x7FFE86871840
        public void WriteMembers(){} // RVA: 0x7FFE868719E0
        public void WriteArray(){} // RVA: 0x7FFE868720E0
        public void WriteArrayMember(){} // RVA: 0x7FFE86872C60
        public void WriteRectangle(){} // RVA: 0x7FFE86873130
        public void GetNext(){} // RVA: 0x7FFE86873340
        public void InternalGetId(){} // RVA: 0x7FFE86873500
        public void Schedule(){} // RVA: 0x7FFE868736C0 | overloaded x2
        public void WriteKnownValueClass(){} // RVA: 0x7FFE86873780
        public void WriteObjectRef(){} // RVA: 0x7FFE86873890
        public void WriteString(){} // RVA: 0x7FFE868738B0
        public void CheckForNull(){} // RVA: 0x7FFE86873A60
        public void WriteSerializedStreamHeader(){} // RVA: 0x7FFE86873C30
        public void TypeToNameInfo(){} // RVA: 0x7FFE86873FD0 | overloaded x5
        public void MemberToNameInfo(){} // RVA: 0x7FFE86874080
        public void ToCode(){} // RVA: 0x7FFE868740F0
        public void GetAssemblyId(){} // RVA: 0x7FFE868741D0
        public void GetType(){} // RVA: 0x7FFE81408130
        public void GetNameInfo(){} // RVA: 0x7FFE868744A0
        public void CheckTypeFormat(){} // RVA: 0x7FFE86874540
        public void PutNameInfo(){} // RVA: 0x7FFE86874550
    }

    public class ParseRecord : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8687AF40
        public void .cctor(){} // RVA: 0x7FFE8687B5F0
    }

    public class PrimitiveArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687D540
        public void Init(){} // RVA: 0x7FFE8687D550
        public void SetValue(){} // RVA: 0x7FFE8687DB20
    }

    public class ReadObjectInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ObjectEnd(){} // RVA: 0x7FFE810FB310
        public void PrepareForReuse(){} // RVA: 0x7FFE8118B4E0
        public void Create(){} // RVA: 0x7FFE868684A0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE868685B0 | overloaded x2
        public void InitReadConstructor(){} // RVA: 0x7FFE868688E0
        public void InitSiRead(){} // RVA: 0x7FFE86868CF0
        public void InitNoMembers(){} // RVA: 0x7FFE86868E30
        public void InitMemberInfo(){} // RVA: 0x7FFE86868EF0
        public void GetMemberInfo(){} // RVA: 0x7FFE86869360
        public void GetType(){} // RVA: 0x7FFE868695D0
        public void AddValue(){} // RVA: 0x7FFE86869790
        public void InitDataStore(){} // RVA: 0x7FFE86869840
        public void RecordFixup(){} // RVA: 0x7FFE86869990
        public void PopulateObjectMembers(){} // RVA: 0x7FFE86869A60
        public void Position(){} // RVA: 0x7FFE86869AF0
        public void GetMemberTypes(){} // RVA: 0x7FFE86869CE0
        public void GetMemberType(){} // RVA: 0x7FFE8686A3F0
        public void GetObjectInfo(){} // RVA: 0x7FFE8686A5E0
    }

    public class SerObjectInfoCache : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8686A860 | overloaded x2
    }

    public class SerObjectInfoInit : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8686A640
    }

    public class SerStack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687B630
        public void Push(){} // RVA: 0x7FFE8687B740
        public void Pop(){} // RVA: 0x7FFE8687B8A0
        public void IncreaseCapacity(){} // RVA: 0x7FFE8687B910
        public void Peek(){} // RVA: 0x7FFE8687B9F0
        public void PeekPeek(){} // RVA: 0x7FFE8687BA30
        public void IsEmpty(){} // RVA: 0x7FFE8687BA70
    }

    public class SerializationHeaderRecord : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86859350 | overloaded x2
        public void Write(){} // RVA: 0x7FFE86859380
        public void GetInt32(){} // RVA: 0x7FFE86807060
        public void Read(){} // RVA: 0x7FFE86859460
        public void Dump(){} // RVA: 0x7FFE810FB310
    }

    public class SizedArray : Object
    {
        public object[] objects; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687BCA0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFE8687BE20
        public void get_Item(){} // RVA: 0x7FFE8687BFC0
        public void set_Item(){} // RVA: 0x7FFE8687C030
        public void IncreaseCapacity(){} // RVA: 0x7FFE8687C140
    }

    public class TypeInformation : Object
    {
        public string fullTypeName; // 0x10
        public string assemblyString; // 0x18
        public bool hasTypeForwardedFrom; // 0x20

        // ── Methods ──
        public void get_FullTypeName(){} // RVA: 0x7FFE81116380
        public void get_AssemblyString(){} // RVA: 0x7FFE810FE7C0
        public void get_HasTypeForwardedFrom(){} // RVA: 0x7FFE811E99D0
        public void .ctor(){} // RVA: 0x7FFE8686A7A0
    }

    public class ValueFixup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687CEC0 | overloaded x2
        public void Fixup(){} // RVA: 0x7FFE8687CFD0
    }

    public class WriteObjectInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ObjectEnd(){} // RVA: 0x7FFE86865B20
        public void InternalInit(){} // RVA: 0x7FFE86865B50
        public void Serialize(){} // RVA: 0x7FFE868665B0 | overloaded x2
        public void InitSerialize(){} // RVA: 0x7FFE86866650 | overloaded x2
        public void InitSiWrite(){} // RVA: 0x7FFE86866CB0
        public void CheckTypeForwardedFrom(){} // RVA: 0x7FFE86867390
        public void InitNoMembers(){} // RVA: 0x7FFE86867460
        public void InitMemberInfo(){} // RVA: 0x7FFE86867640
        public void GetTypeFullName(){} // RVA: 0x7FFE86867C40
        public void GetAssemblyString(){} // RVA: 0x7FFE86867C70
        public void InvokeSerializationBinder(){} // RVA: 0x7FFE86867CA0
        public void GetMemberType(){} // RVA: 0x7FFE86867CE0
        public void GetMemberInfo(){} // RVA: 0x7FFE86867ED0
        public void GetObjectInfo(){} // RVA: 0x7FFE86868070
        public void PutObjectInfo(){} // RVA: 0x7FFE86868140
    }

    public class __BinaryParser : Object
    {
        public System.Runtime.Serialization.Formatters.Binary.ObjectReader objectReader; // 0x10
        public System.IO.Stream input; // 0x18
        public long topId; // 0x20
        public long headerId; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86874580
        public void get_SystemAssemblyInfo(){} // RVA: 0x7FFE868747D0
        public void get_ObjectMapIdTable(){} // RVA: 0x7FFE86874970
        public void get_AssemIdToAssemblyTable(){} // RVA: 0x7FFE86874B20
        public void get_prs(){} // RVA: 0x7FFE86874CD0
        public void Run(){} // RVA: 0x7FFE86874D70
        public void ReadBegin(){} // RVA: 0x7FFE810FB310
        public void ReadEnd(){} // RVA: 0x7FFE810FB310
        public void ReadBoolean(){} // RVA: 0x7FFE86875370
        public void ReadByte(){} // RVA: 0x7FFE868753A0
        public void ReadBytes(){} // RVA: 0x7FFE86875400 | overloaded x2
        public void ReadChar(){} // RVA: 0x7FFE86875480
        public void ReadChars(){} // RVA: 0x7FFE868754B0
        public void ReadDecimal(){} // RVA: 0x7FFE868754E0
        public void ReadSingle(){} // RVA: 0x7FFE868756A0
        public void ReadDouble(){} // RVA: 0x7FFE868756D0
        public void ReadInt16(){} // RVA: 0x7FFE86875700
        public void ReadInt32(){} // RVA: 0x7FFE86875730
        public void ReadInt64(){} // RVA: 0x7FFE86875760
        public void ReadSByte(){} // RVA: 0x7FFE868753A0
        public void ReadString(){} // RVA: 0x7FFE86875790
        public void ReadTimeSpan(){} // RVA: 0x7FFE86875760
        public void ReadDateTime(){} // RVA: 0x7FFE868757C0
        public void ReadUInt16(){} // RVA: 0x7FFE86875840
        public void ReadUInt32(){} // RVA: 0x7FFE86875870
        public void ReadUInt64(){} // RVA: 0x7FFE868758A0
        public void ReadSerializationHeaderRecord(){} // RVA: 0x7FFE868758D0
        public void ReadAssembly(){} // RVA: 0x7FFE86875980
        public void ReadObject(){} // RVA: 0x7FFE86875D80
        public void ReadCrossAppDomainMap(){} // RVA: 0x7FFE86876530
        public void ReadObjectWithMap(){} // RVA: 0x7FFE86876810 | overloaded x2
        public void ReadObjectWithMapTyped(){} // RVA: 0x7FFE868771A0 | overloaded x2
        public void ReadObjectString(){} // RVA: 0x7FFE86877A80
        public void ReadMemberPrimitiveTyped(){} // RVA: 0x7FFE868784D0
        public void ReadArray(){} // RVA: 0x7FFE86878B20
        public void ReadArrayAsBytes(){} // RVA: 0x7FFE86879350
        public void ReadMemberPrimitiveUnTyped(){} // RVA: 0x7FFE868797C0
        public void ReadMemberReference(){} // RVA: 0x7FFE86879C70
        public void ReadObjectNull(){} // RVA: 0x7FFE86879FC0
        public void ReadMessageEnd(){} // RVA: 0x7FFE8687A360
        public void ReadValue(){} // RVA: 0x7FFE8687A540
        public void GetOp(){} // RVA: 0x7FFE8687AC30
        public void PutOp(){} // RVA: 0x7FFE8687AD60
        public void .cctor(){} // RVA: 0x7FFE8687AE50
    }

    public class __BinaryWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868626E0
        public void WriteBegin(){} // RVA: 0x7FFE810FB310
        public void WriteEnd(){} // RVA: 0x7FFE86862880
        public void WriteBoolean(){} // RVA: 0x7FFE868628B0
        public void WriteByte(){} // RVA: 0x7FFE868628E0
        public void WriteBytes(){} // RVA: 0x7FFE86862940 | overloaded x2
        public void WriteChar(){} // RVA: 0x7FFE86862970
        public void WriteChars(){} // RVA: 0x7FFE868629A0
        public void WriteDecimal(){} // RVA: 0x7FFE868629D0
        public void WriteSingle(){} // RVA: 0x7FFE867E8740
        public void WriteDouble(){} // RVA: 0x7FFE86862AD0
        public void WriteInt16(){} // RVA: 0x7FFE86862B00
        public void WriteInt32(){} // RVA: 0x7FFE86862B30
        public void WriteInt64(){} // RVA: 0x7FFE86862B60
        public void WriteSByte(){} // RVA: 0x7FFE868628E0
        public void WriteString(){} // RVA: 0x7FFE86862B90
        public void WriteTimeSpan(){} // RVA: 0x7FFE86862BC0
        public void WriteDateTime(){} // RVA: 0x7FFE86862C40
        public void WriteUInt16(){} // RVA: 0x7FFE86862CC0
        public void WriteUInt32(){} // RVA: 0x7FFE86862CF0
        public void WriteUInt64(){} // RVA: 0x7FFE86862D20
        public void WriteObjectEnd(){} // RVA: 0x7FFE810FB310
        public void WriteSerializationHeaderEnd(){} // RVA: 0x7FFE86862D50
        public void WriteSerializationHeader(){} // RVA: 0x7FFE86862DC0
        public void WriteMethodCall(){} // RVA: 0x7FFE86862F00
        public void WriteMethodReturn(){} // RVA: 0x7FFE86862FC0
        public void WriteObject(){} // RVA: 0x7FFE86863080
        public void WriteObjectString(){} // RVA: 0x7FFE86863B20
        public void WriteSingleArray(){} // RVA: 0x7FFE86863CD0
        public void WriteArrayAsBytes(){} // RVA: 0x7FFE86864080
        public void WriteJaggedArray(){} // RVA: 0x7FFE86864250
        public void WriteRectangleArray(){} // RVA: 0x7FFE86864490
        public void WriteObjectByteArray(){} // RVA: 0x7FFE86864670
        public void WriteMember(){} // RVA: 0x7FFE868646D0
        public void WriteNullMember(){} // RVA: 0x7FFE86864980
        public void WriteMemberObjectRef(){} // RVA: 0x7FFE86864A80
        public void WriteMemberNested(){} // RVA: 0x7FFE86864BB0
        public void WriteMemberString(){} // RVA: 0x7FFE86864BE0
        public void WriteItem(){} // RVA: 0x7FFE86864C40
        public void WriteNullItem(){} // RVA: 0x7FFE86864CA0
        public void WriteDelayedNullItem(){} // RVA: 0x7FFE86864CB0
        public void WriteItemEnd(){} // RVA: 0x7FFE86864CC0
        public void InternalWriteItemNull(){} // RVA: 0x7FFE86864CD0
        public void WriteItemObjectRef(){} // RVA: 0x7FFE86864DC0
        public void WriteAssembly(){} // RVA: 0x7FFE86864E00
        public void WriteValue(){} // RVA: 0x7FFE86865000
    }

}