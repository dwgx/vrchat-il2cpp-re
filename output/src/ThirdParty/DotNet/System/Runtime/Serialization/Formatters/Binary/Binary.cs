// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
// Classes: 43
// Methods: 374

namespace ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
{
    public class BinaryArray : Object
    {
        public int objectId; // 0x10
        public int rank; // 0x14
        public int[] lengthA; // 0x18
        public int[] lowerBoundA; // 0x20
        public 0x6B0D36B8 binaryTypeEnum; // 0x28
        public object typeInformation; // 0x30
        public int assemId; // 0x38
        public 0x6B0D3660 binaryHeaderEnum; // 0x3C
        public 0x6B0D3710 binaryArrayTypeEnum; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E2CD0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC84B1770
        public void Write(){} // RVA: 0x7FFAC84B18F0
        public void Read(){} // RVA: 0x7FFAC84B1C60
    }

    public class BinaryAssembly : Object
    {
        public int assemId; // 0x10
        public string assemblyString; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC47EB5F0
        public void Write(){} // RVA: 0x7FFAC84AFE90
        public void Read(){} // RVA: 0x7FFAC84AFF20
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryAssemblyInfo : Object
    {
        public string assemblyString; // 0x10
        public System.Reflection.Assembly assembly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void GetAssembly(){} // RVA: 0x7FFAC84AF9C0
    }

    public class BinaryConverter : Object
    {
        // ── Methods ──
        public void GetBinaryTypeInfo(){} // RVA: 0x7FFAC84AE730
        public void GetParserBinaryTypeInfo(){} // RVA: 0x7FFAC84AEB10
        public void WriteTypeInfo(){} // RVA: 0x7FFAC84AEE30
        public void ReadTypeInfo(){} // RVA: 0x7FFAC84AF0B0
        public void TypeFromInfo(){} // RVA: 0x7FFAC84AF2D0
    }

    public class BinaryCrossAppDomainAssembly : Object
    {
        public int assemId; // 0x10
        public int assemblyIndex; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFAC84AFFE0
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryCrossAppDomainMap : Object
    {
        public int crossAppDomainArrayIndex; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFAC84B08B0
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryCrossAppDomainString : Object
    {
        public int objectId; // 0x10
        public int value; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFAC84AFFE0
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryFormatter : Object
    {
        public System.Runtime.Serialization.ISurrogateSelector AssemblyFormat; // 0x10
        public System.Runtime.Serialization.StreamingContext SurrogateSelector; // 0x18
        public System.Runtime.Serialization.SerializationBinder m_binder; // 0x28
        public 0x6B0D3558 m_typeFormat; // 0x30
        public 0x6B0D35B0 m_assemblyFormat; // 0x34
        public 0x6B0D3608 m_securityLevel; // 0x38
        public object[] m_crossAppDomainArray; // 0x40
        public System.Collections.Generic.Dictionary`2<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation> typeNameCache;

        // ── Methods ──
        public void set_AssemblyFormat(){} // RVA: 0x7FFAC416A6E0
        public void set_SurrogateSelector(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC84B8170 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFAC84B8560 | overloaded x3
        public void Serialize(){} // RVA: 0x7FFAC84B85C0 | overloaded x3
        public void GetTypeInformation(){} // RVA: 0x7FFAC84B8990
        public void .cctor(){} // RVA: 0x7FFAC84B8DD0
    }

    public class BinaryMethodCall : Object
    {
        public string methodName; // 0x10
        public string typeName; // 0x18
        public object[] args; // 0x20
        public object callContext; // 0x28
        public System.Type[] argTypes; // 0x30
        public bool bArgsPrimitive; // 0x38
        public 0x6B0D49F8 messageEnum; // 0x3C

        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC84B00E0
        public void Dump(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC3C4CFE0
    }

    public class BinaryMethodReturn : Object
    {
        public object returnValue; // 0x10
        public object[] args; // 0x18
        public object callContext; // 0x20
        public System.Type[] argTypes; // 0x28
        public bool bArgsPrimitive; // 0x30
        public 0x6B0D49F8 messageEnum; // 0x34
        public System.Type returnType; // 0x38
        public object instanceOfVoid;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC84B0460
        public void .ctor(){} // RVA: 0x7FFAC4269BA0
        public void Write(){} // RVA: 0x7FFAC84B0560
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryObject : Object
    {
        public int objectId; // 0x10
        public int mapId; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC6CEC5A0
        public void Write(){} // RVA: 0x7FFAC84B0050
        public void Read(){} // RVA: 0x7FFAC84AFFE0
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryObjectString : Object
    {
        public int objectId; // 0x10
        public string value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC47EB5F0
        public void Write(){} // RVA: 0x7FFAC84B0820
        public void Read(){} // RVA: 0x7FFAC84AFF20
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryObjectWithMap : Object
    {
        public 0x6B0D3660 binaryHeaderEnum; // 0x10
        public int objectId; // 0x14
        public string name; // 0x18
        public int numMembers; // 0x20
        public string[] memberNames; // 0x28
        public int assemId; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC84B0A10
        public void Write(){} // RVA: 0x7FFAC84B0AE0
        public void Read(){} // RVA: 0x7FFAC84B0C10
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryObjectWithMapTyped : Object
    {
        public 0x6B0D3660 binaryHeaderEnum; // 0x10
        public int objectId; // 0x14
        public string name; // 0x18
        public int numMembers; // 0x20
        public string[] memberNames; // 0x28
        public 0x6B0D36B8[] binaryTypeEnumA; // 0x30
        public object[] typeInformationA; // 0x38
        public int[] memberAssemIds; // 0x40
        public int assemId; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC84B0E60
        public void Write(){} // RVA: 0x7FFAC84B1050
        public void Read(){} // RVA: 0x7FFAC84B1260
    }

    public class Converter : Object
    {
        public int primitiveTypeEnumLength;
        public System.Type[] typeA; // 0x8
        public System.Type[] arrayTypeA; // 0x10
        public string[] valueA; // 0x18
        public 0x6B0C1808[] typeCodeA; // 0x20
        public 0x6B0D39D0[] codeA; // 0x28
        public System.Type typeofISerializable; // 0x30
        public System.Type typeofString; // 0x38
        public System.Type typeofConverter; // 0x40
        public System.Type typeofBoolean; // 0x48
        public System.Type typeofByte; // 0x50
        public System.Type typeofChar; // 0x58
        public System.Type typeofDecimal; // 0x60
        public System.Type typeofDouble; // 0x68
        public System.Type typeofInt16; // 0x70
        public System.Type typeofInt32; // 0x78
        public System.Type typeofInt64; // 0x80
        public System.Type typeofSByte; // 0x88
        public System.Type typeofSingle; // 0x90
        public System.Type typeofTimeSpan; // 0x98
        public System.Type typeofDateTime; // 0xA0
        public System.Type typeofUInt16; // 0xA8
        public System.Type typeofUInt32; // 0xB0
        public System.Type typeofUInt64; // 0xB8
        public System.Type typeofObject; // 0xC0
        public System.Type typeofSystemVoid; // 0xC8
        public System.Reflection.Assembly urtAssembly; // 0xD0
        public string urtAssemblyString; // 0xD8
        public System.Type typeofTypeArray; // 0xE0
        public System.Type typeofObjectArray; // 0xE8
        public System.Type typeofStringArray; // 0xF0
        public System.Type typeofBooleanArray; // 0xF8
        public System.Type typeofByteArray; // 0x100
        public System.Type typeofCharArray; // 0x108
        public System.Type typeofDecimalArray; // 0x110
        public System.Type typeofDoubleArray; // 0x118
        public System.Type typeofInt16Array; // 0x120
        public System.Type typeofInt32Array; // 0x128
        public System.Type typeofInt64Array; // 0x130
        public System.Type typeofSByteArray; // 0x138
        public System.Type typeofSingleArray; // 0x140
        public System.Type typeofTimeSpanArray; // 0x148
        public System.Type typeofDateTimeArray; // 0x150
        public System.Type typeofUInt16Array; // 0x158
        public System.Type typeofUInt32Array; // 0x160
        public System.Type typeofUInt64Array; // 0x168
        public System.Type typeofMarshalByRefObject; // 0x170

        // ── Methods ──
        public void ToCode(){} // RVA: 0x7FFAC84B3F80
        public void IsWriteAsByteArray(){} // RVA: 0x7FFAC84B41E0
        public void TypeLength(){} // RVA: 0x7FFAC84B4250
        public void ToArrayType(){} // RVA: 0x7FFAC84B42D0
        public void InitTypeA(){} // RVA: 0x7FFAC84B43A0
        public void InitArrayTypeA(){} // RVA: 0x7FFAC84B49E0
        public void ToType(){} // RVA: 0x7FFAC84B5030
        public void CreatePrimitiveArray(){} // RVA: 0x7FFAC84B5100
        public void IsPrimitiveArray(){} // RVA: 0x7FFAC84B5330
        public void InitValueA(){} // RVA: 0x7FFAC84B5720
        public void ToComType(){} // RVA: 0x7FFAC84B5AD0
        public void InitTypeCodeA(){} // RVA: 0x7FFAC84B5BA0
        public void ToTypeCode(){} // RVA: 0x7FFAC84B5DB0
        public void InitCodeA(){} // RVA: 0x7FFAC84B5E80
        public void ToPrimitiveTypeEnum(){} // RVA: 0x7FFAC84B60A0
        public void FromString(){} // RVA: 0x7FFAC84B6170
        public void .cctor(){} // RVA: 0x7FFAC84B6300
    }

    public class IOUtil : Object
    {
        // ── Methods ──
        public void FlagTest(){} // RVA: 0x7FFAC4312F10
        public void WriteStringWithCode(){} // RVA: 0x7FFAC84AF7D0
        public void WriteWithCode(){} // RVA: 0x7FFAC84AF860
    }

    public class IntSizedArray : Object
    {
        public int[] Item; // 0x10
        public int[] negObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D2C90 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC84D2EC0
        public void get_Item(){} // RVA: 0x7FFAC84D2F20
        public void set_Item(){} // RVA: 0x7FFAC84D2F90
        public void IncreaseCapacity(){} // RVA: 0x7FFAC84D3040
    }

    public class InternalFE : Object
    {
        public 0x6B0D3558 FEtypeFormat; // 0x10
        public 0x6B0D35B0 FEassemblyFormat; // 0x14
        public 0x6B0D3608 FEsecurityLevel; // 0x18
        public 0x6B0D3768 FEserializerTypeEnum; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MemberPrimitiveTyped : Object
    {
        public 0x6B0D39D0 primitiveTypeEnum; // 0x10
        public object value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC47EB5F0
        public void Write(){} // RVA: 0x7FFAC84B08F0
        public void Read(){} // RVA: 0x7FFAC84B0970
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class MemberPrimitiveUnTyped : Object
    {
        public 0x6B0D39D0 typeInformation; // 0x10
        public object value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void Write(){} // RVA: 0x7FFAC84B25E0
        public void Read(){} // RVA: 0x7FFAC84B2610
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class MemberReference : Object
    {
        public int idRef; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC2F240C0
        public void Write(){} // RVA: 0x7FFAC84B2690
        public void Read(){} // RVA: 0x7FFAC84B08B0
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class MessageEnd : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Write(){} // RVA: 0x7FFAC84B28A0
        public void Read(){} // RVA: 0x7FFAC2F21310
        public void Dump(){} // RVA: 0x7FFAC2F21310 | overloaded x2
    }

    public class NameCache : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> ht;
        public string name; // 0x10

        // ── Methods ──
        public void GetCachedValue(){} // RVA: 0x7FFAC84D32B0
        public void SetCachedValue(){} // RVA: 0x7FFAC84D3450
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC84D34F0
    }

    public class NameInfo : Object
    {
        public string IsSealed; // 0x10
        public long NIname; // 0x18
        public long NIassemId; // 0x20
        public 0x6B0D39D0 NIprimitiveTypeEnum; // 0x28
        public System.Type NItype; // 0x30
        public bool NIisSealed; // 0x38
        public bool NIisArray; // 0x39
        public bool NIisArrayItem; // 0x3A
        public bool NItransmitTypeOnObject; // 0x3B
        public bool NItransmitTypeOnMember; // 0x3C
        public bool NIisParentTypeOnObject; // 0x3D
        public 0x6B0D38C8 NIarrayEnum; // 0x40
        public bool NIsealedStatusChecked; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFAC84D3B50
        public void get_IsSealed(){} // RVA: 0x7FFAC84D3C30
        public void get_NIname(){} // RVA: 0x7FFAC84D3C80
        public void set_NIname(){} // RVA: 0x7FFAC2F22E30
    }

    public class ObjectMap : Object
    {
        public string objectName; // 0x10
        public System.Type objectType; // 0x18
        public 0x6B0D36B8[] binaryTypeEnumA; // 0x20
        public object[] typeInformationA; // 0x28
        public System.Type[] memberTypes; // 0x30
        public string[] memberNames; // 0x38
        public System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo objectInfo; // 0x40
        public bool isInitObjectInfo; // 0x48
        public System.Runtime.Serialization.Formatters.Binary.ObjectReader objectReader; // 0x50
        public int objectId; // 0x58
        public System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo assemblyInfo; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84B2EF0 | overloaded x2
        public void CreateObjectInfo(){} // RVA: 0x7FFAC84B3720
        public void Create(){} // RVA: 0x7FFAC84B3820 | overloaded x2
    }

    public class ObjectMapInfo : Object
    {
        public int objectId; // 0x10
        public int numMembers; // 0x14
        public string[] memberNames; // 0x18
        public System.Type[] memberTypes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84BC0D0
        public void isCompatible(){} // RVA: 0x7FFAC84BC190
    }

    public class ObjectNull : Object
    {
        public int nullCount; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetNullCount(){} // RVA: 0x7FFAC2F240C0
        public void Write(){} // RVA: 0x7FFAC84B2700
        public void Read(){} // RVA: 0x7FFAC84B2800
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class ObjectProgress : Object
    {
        public int opRecordIdCount;
        public bool isInitial; // 0x10
        public int count; // 0x14
        public 0x6B0D36B8 expectedType; // 0x18
        public object expectedTypeInformation; // 0x20
        public string name; // 0x28
        public 0x6B0D3818 objectTypeEnum; // 0x30
        public 0x6B0D3920 memberTypeEnum; // 0x34
        public 0x6B0D3978 memberValueEnum; // 0x38
        public System.Type dtType; // 0x40
        public int numItems; // 0x48
        public 0x6B0D36B8 binaryTypeEnum; // 0x4C
        public object typeInformation; // 0x50
        public int nullCount; // 0x58
        public int memberLength; // 0x5C
        public 0x6B0D36B8[] binaryTypeEnumA; // 0x60
        public object[] typeInformationA; // 0x68
        public string[] memberNames; // 0x70
        public System.Type[] memberTypes; // 0x78
        public System.Runtime.Serialization.Formatters.Binary.ParseRecord pr; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84B3900
        public void Init(){} // RVA: 0x7FFAC84B39A0
        public void ArrayCountIncrement(){} // RVA: 0x7FFAC84B3C90
        public void GetNext(){} // RVA: 0x7FFAC84B3CA0
        public void .cctor(){} // RVA: 0x7FFAC84B3F40
    }

    public class ObjectReader : Object
    {
        public System.IO.Stream ValueFixupStack; // 0x10
        public System.Runtime.Serialization.ISurrogateSelector TopObject; // 0x18
        public System.Runtime.Serialization.StreamingContext m_context; // 0x20
        public System.Runtime.Serialization.ObjectManager m_objectManager; // 0x30
        public System.Runtime.Serialization.Formatters.Binary.InternalFE formatterEnums; // 0x38
        public System.Runtime.Serialization.SerializationBinder m_binder; // 0x40
        public long topId; // 0x48
        public bool bSimpleAssembly; // 0x50
        public object handlerObject; // 0x58
        public object m_topObject; // 0x60
        public System.Runtime.Remoting.Messaging.Header[] headers; // 0x68
        public System.Runtime.Remoting.Messaging.HeaderHandler handler; // 0x70
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit serObjectInfoInit; // 0x78
        public System.Runtime.Serialization.IFormatterConverter m_formatterConverter; // 0x80
        public System.Runtime.Serialization.Formatters.Binary.SerStack stack; // 0x88
        public System.Runtime.Serialization.Formatters.Binary.SerStack valueFixupStack; // 0x90
        public object[] crossAppDomainArray; // 0x98
        public bool bFullDeserialization; // 0xA0
        public bool bOldFormatDetected; // 0xA1
        public System.Runtime.Serialization.Formatters.Binary.IntSizedArray valTypeObjectIdTable; // 0xA8
        public System.Runtime.Serialization.Formatters.Binary.NameCache typeCache; // 0xB0
        public string previousAssemblyString; // 0xB8
        public string previousName; // 0xC0
        public System.Type previousType; // 0xC8

        // ── Methods ──
        public void get_ValueFixupStack(){} // RVA: 0x7FFAC84C1160
        public void get_TopObject(){} // RVA: 0x7FFAC2FBF370
        public void set_TopObject(){} // RVA: 0x7FFAC84C1230
        public void .ctor(){} // RVA: 0x7FFAC84C12F0
        public void Deserialize(){} // RVA: 0x7FFAC84C15C0
        public void HasSurrogate(){} // RVA: 0x7FFAC84C1A70
        public void CheckSerializable(){} // RVA: 0x7FFAC84C1B70
        public void InitFullDeserialization(){} // RVA: 0x7FFAC84C1CB0
        public void CrossAppDomainArray(){} // RVA: 0x7FFAC84C1ED0
        public void CreateReadObjectInfo(){} // RVA: 0x7FFAC84C1F50 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC84C2070
        public void ParseError(){} // RVA: 0x7FFAC84C22A0
        public void ParseSerializedStreamHeader(){} // RVA: 0x7FFAC84C2510
        public void ParseSerializedStreamHeaderEnd(){} // RVA: 0x7FFAC84C2540
        public void ParseObject(){} // RVA: 0x7FFAC84C2570
        public void ParseObjectEnd(){} // RVA: 0x7FFAC84C2A60
        public void ParseArray(){} // RVA: 0x7FFAC84C2E10
        public void NextRectangleMap(){} // RVA: 0x7FFAC84C39A0
        public void ParseArrayMember(){} // RVA: 0x7FFAC84C3A90
        public void ParseArrayMemberEnd(){} // RVA: 0x7FFAC84C4800
        public void ParseMember(){} // RVA: 0x7FFAC84C4830
        public void ParseMemberEnd(){} // RVA: 0x7FFAC84C51F0
        public void ParseString(){} // RVA: 0x7FFAC84C52A0
        public void RegisterObject(){} // RVA: 0x7FFAC84C53E0 | overloaded x2
        public void GetId(){} // RVA: 0x7FFAC84C5610
        public void Bind(){} // RVA: 0x7FFAC84C5940
        public void FastBindToType(){} // RVA: 0x7FFAC84C59A0
        public void ResolveSimpleAssemblyName(){} // RVA: 0x7FFAC84C5F10
        public void GetSimplyNamedTypeFromAssembly(){} // RVA: 0x7FFAC84C5FD0
        public void GetType(){} // RVA: 0x7FFAC84C62C0
        public void CheckTypeForwardedTo(){} // RVA: 0x7FFAC84C67C0
    }

    public class ObjectWriter : Object
    {
        public System.Collections.Queue ObjectManager; // 0x10
        public System.Runtime.Serialization.ObjectIDGenerator m_idGenerator; // 0x18
        public int m_currentId; // 0x20
        public System.Runtime.Serialization.ISurrogateSelector m_surrogates; // 0x28
        public System.Runtime.Serialization.StreamingContext m_context; // 0x30
        public System.Runtime.Serialization.Formatters.Binary.__BinaryWriter serWriter; // 0x40
        public System.Runtime.Serialization.SerializationObjectManager m_objectManager; // 0x48
        public long topId; // 0x50
        public string topName; // 0x58
        public System.Runtime.Remoting.Messaging.Header[] headers; // 0x60
        public System.Runtime.Serialization.Formatters.Binary.InternalFE formatterEnums; // 0x68
        public System.Runtime.Serialization.SerializationBinder m_binder; // 0x70
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit serObjectInfoInit; // 0x78
        public System.Runtime.Serialization.IFormatterConverter m_formatterConverter; // 0x80
        public object[] crossAppDomainArray; // 0x88
        public object previousObj; // 0x90
        public long previousId; // 0x98
        public System.Type previousType; // 0xA0
        public 0x6B0D39D0 previousCode; // 0xA8
        public System.Collections.Hashtable assemblyToIdTable; // 0xB0
        public System.Runtime.Serialization.Formatters.Binary.SerStack niPool; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84C6910
        public void Serialize(){} // RVA: 0x7FFAC84C6CC0
        public void get_ObjectManager(){} // RVA: 0x7FFAC2F9C730
        public void Write(){} // RVA: 0x7FFAC84C7C20 | overloaded x2
        public void WriteMemberSetup(){} // RVA: 0x7FFAC84C8010
        public void WriteMembers(){} // RVA: 0x7FFAC84C81B0
        public void WriteArray(){} // RVA: 0x7FFAC84C88B0
        public void WriteArrayMember(){} // RVA: 0x7FFAC84C9430
        public void WriteRectangle(){} // RVA: 0x7FFAC84C9900
        public void GetNext(){} // RVA: 0x7FFAC84C9B10
        public void InternalGetId(){} // RVA: 0x7FFAC84C9CD0
        public void Schedule(){} // RVA: 0x7FFAC84C9E90 | overloaded x2
        public void WriteKnownValueClass(){} // RVA: 0x7FFAC84C9F50
        public void WriteObjectRef(){} // RVA: 0x7FFAC84CA060
        public void WriteString(){} // RVA: 0x7FFAC84CA080
        public void CheckForNull(){} // RVA: 0x7FFAC84CA230
        public void WriteSerializedStreamHeader(){} // RVA: 0x7FFAC84CA400
        public void TypeToNameInfo(){} // RVA: 0x7FFAC84CA7A0 | overloaded x5
        public void MemberToNameInfo(){} // RVA: 0x7FFAC84CA850
        public void ToCode(){} // RVA: 0x7FFAC84CA8C0
        public void GetAssemblyId(){} // RVA: 0x7FFAC84CA9A0
        public void GetType(){} // RVA: 0x7FFAC31A1540
        public void GetNameInfo(){} // RVA: 0x7FFAC84CAC70
        public void CheckTypeFormat(){} // RVA: 0x7FFAC84CAD10
        public void PutNameInfo(){} // RVA: 0x7FFAC84CAD20
    }

    public class ParseRecord : Object
    {
        public int parseRecordIdCount;
        public 0x6B0D37C0 PRparseTypeEnum; // 0x10
        public 0x6B0D3818 PRobjectTypeEnum; // 0x14
        public 0x6B0D38C8 PRarrayTypeEnum; // 0x18
        public 0x6B0D3920 PRmemberTypeEnum; // 0x1C
        public 0x6B0D3978 PRmemberValueEnum; // 0x20
        public 0x6B0D3870 PRobjectPositionEnum; // 0x24
        public string PRname; // 0x28
        public string PRvalue; // 0x30
        public object PRvarValue; // 0x38
        public string PRkeyDt; // 0x40
        public System.Type PRdtType; // 0x48
        public 0x6B0D39D0 PRdtTypeCode; // 0x50
        public bool PRisEnum; // 0x54
        public long PRobjectId; // 0x58
        public long PRidRef; // 0x60
        public string PRarrayElementTypeString; // 0x68
        public System.Type PRarrayElementType; // 0x70
        public bool PRisArrayVariant; // 0x78
        public 0x6B0D39D0 PRarrayElementTypeCode; // 0x7C
        public int PRrank; // 0x80
        public int[] PRlengthA; // 0x88
        public int[] PRpositionA; // 0x90
        public int[] PRlowerBoundA; // 0x98
        public int[] PRupperBoundA; // 0xA0
        public int[] PRindexMap; // 0xA8
        public int PRmemberIndex; // 0xB0
        public int PRlinearlength; // 0xB4
        public int[] PRrectangularMap; // 0xB8
        public bool PRisLowerBound; // 0xC0
        public long PRtopId; // 0xC8
        public long PRheaderId; // 0xD0
        public System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo PRobjectInfo; // 0xD8
        public bool PRisValueTypeFixup; // 0xE0
        public object PRnewObj; // 0xE8
        public object[] PRobjectA; // 0xF0
        public System.Runtime.Serialization.Formatters.Binary.PrimitiveArray PRprimitiveArray; // 0xF8
        public bool PRisRegistered; // 0x100
        public object[] PRmemberData; // 0x108
        public System.Runtime.Serialization.SerializationInfo PRsi; // 0x110
        public int PRnullCount; // 0x118

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFAC84D1710
        public void .cctor(){} // RVA: 0x7FFAC84D1DC0
    }

    public class PrimitiveArray : Object
    {
        public 0x6B0D39D0 code; // 0x10
        public bool[] booleanA; // 0x18
        public char[] charA; // 0x20
        public double[] doubleA; // 0x28
        public short[] int16A; // 0x30
        public int[] int32A; // 0x38
        public long[] int64A; // 0x40
        public sbyte[] sbyteA; // 0x48
        public float[] singleA; // 0x50
        public ushort[] uint16A; // 0x58
        public uint[] uint32A; // 0x60
        public ulong[] uint64A; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D3D10
        public void Init(){} // RVA: 0x7FFAC84D3D20
        public void SetValue(){} // RVA: 0x7FFAC84D42F0
    }

    public class ReadObjectInfo : Object
    {
        public int objectInfoId; // 0x10
        public int readObjectInfoCounter;
        public System.Type objectType; // 0x18
        public System.Runtime.Serialization.ObjectManager objectManager; // 0x20
        public int count; // 0x28
        public bool isSi; // 0x2C
        public bool isNamed; // 0x2D
        public bool isTyped; // 0x2E
        public bool bSimpleAssembly; // 0x2F
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache cache; // 0x30
        public string[] wireMemberNames; // 0x38
        public System.Type[] wireMemberTypes; // 0x40
        public int lastPosition; // 0x48
        public System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate; // 0x50
        public System.Runtime.Serialization.StreamingContext context; // 0x58
        public System.Collections.Generic.List`1<System.Type> memberTypesList; // 0x68
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit serObjectInfoInit; // 0x70
        public System.Runtime.Serialization.IFormatterConverter formatterConverter; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ObjectEnd(){} // RVA: 0x7FFAC2F21310
        public void PrepareForReuse(){} // RVA: 0x7FFAC2FB14E0
        public void Create(){} // RVA: 0x7FFAC84BEC70 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC84BED80 | overloaded x2
        public void InitReadConstructor(){} // RVA: 0x7FFAC84BF0B0
        public void InitSiRead(){} // RVA: 0x7FFAC84BF4C0
        public void InitNoMembers(){} // RVA: 0x7FFAC84BF600
        public void InitMemberInfo(){} // RVA: 0x7FFAC84BF6C0
        public void GetMemberInfo(){} // RVA: 0x7FFAC84BFB30
        public void GetType(){} // RVA: 0x7FFAC84BFDA0
        public void AddValue(){} // RVA: 0x7FFAC84BFF60
        public void InitDataStore(){} // RVA: 0x7FFAC84C0010
        public void RecordFixup(){} // RVA: 0x7FFAC84C0160
        public void PopulateObjectMembers(){} // RVA: 0x7FFAC84C0230
        public void Position(){} // RVA: 0x7FFAC84C02C0
        public void GetMemberTypes(){} // RVA: 0x7FFAC84C04B0
        public void GetMemberType(){} // RVA: 0x7FFAC84C0BC0
        public void GetObjectInfo(){} // RVA: 0x7FFAC84C0DB0
    }

    public class SerObjectInfoCache : Object
    {
        public string fullTypeName; // 0x10
        public string assemblyString; // 0x18
        public bool hasTypeForwardedFrom; // 0x20
        public System.Reflection.MemberInfo[] memberInfos; // 0x28
        public string[] memberNames; // 0x30
        public System.Type[] memberTypes; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84C1030 | overloaded x2
    }

    public class SerObjectInfoInit : Object
    {
        public System.Collections.Hashtable seenBeforeTable; // 0x10
        public int objectInfoIdCount; // 0x18
        public System.Runtime.Serialization.Formatters.Binary.SerStack oiPool; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84C0E10
    }

    public class SerStack : Object
    {
        public object[] objects; // 0x10
        public string stackId; // 0x18
        public int top; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D1E00
        public void Push(){} // RVA: 0x7FFAC84D1F10
        public void Pop(){} // RVA: 0x7FFAC84D2070
        public void IncreaseCapacity(){} // RVA: 0x7FFAC84D20E0
        public void Peek(){} // RVA: 0x7FFAC84D21C0
        public void PeekPeek(){} // RVA: 0x7FFAC84D2200
        public void IsEmpty(){} // RVA: 0x7FFAC84D2240
    }

    public class SerializationHeaderRecord : Object
    {
        public int binaryFormatterMajorVersion; // 0x10
        public int binaryFormatterMinorVersion; // 0x14
        public 0x6B0D3660 binaryHeaderEnum; // 0x18
        public int topId; // 0x1C
        public int headerId; // 0x20
        public int majorVersion; // 0x24
        public int minorVersion; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84AFB20 | overloaded x2
        public void Write(){} // RVA: 0x7FFAC84AFB50
        public void GetInt32(){} // RVA: 0x7FFAC845D750
        public void Read(){} // RVA: 0x7FFAC84AFC30
        public void Dump(){} // RVA: 0x7FFAC2F21310
    }

    public class SizedArray : Object
    {
        public object[] Item; // 0x10
        public object[] negObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D2470 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAC84D25F0
        public void get_Item(){} // RVA: 0x7FFAC84D2790
        public void set_Item(){} // RVA: 0x7FFAC84D2800
        public void IncreaseCapacity(){} // RVA: 0x7FFAC84D2910
    }

    public class TypeInformation : Object
    {
        public string FullTypeName; // 0x10
        public string AssemblyString; // 0x18
        public bool HasTypeForwardedFrom; // 0x20

        // ── Methods ──
        public void get_FullTypeName(){} // RVA: 0x7FFAC2F3C380
        public void get_AssemblyString(){} // RVA: 0x7FFAC2F247C0
        public void get_HasTypeForwardedFrom(){} // RVA: 0x7FFAC300F9D0
        public void .ctor(){} // RVA: 0x7FFAC84C0F70
    }

    public class ValueFixup : Object
    {
        public 0x6B0D3A28 valueFixupEnum; // 0x10
        public System.Array arrayObj; // 0x18
        public int[] indexMap; // 0x20
        public object header; // 0x28
        public object memberObject; // 0x30
        public System.Reflection.MemberInfo valueInfo;
        public System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo objectInfo; // 0x38
        public string memberName; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D3690 | overloaded x2
        public void Fixup(){} // RVA: 0x7FFAC84D37A0
    }

    public class WriteObjectInfo : Object
    {
        public int objectInfoId; // 0x10
        public object obj; // 0x18
        public System.Type objectType; // 0x20
        public bool isSi; // 0x28
        public bool isNamed; // 0x29
        public bool isTyped; // 0x2A
        public bool isArray; // 0x2B
        public System.Runtime.Serialization.SerializationInfo si; // 0x30
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache cache; // 0x38
        public object[] memberData; // 0x40
        public System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate; // 0x48
        public System.Runtime.Serialization.StreamingContext context; // 0x50
        public System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit serObjectInfoInit; // 0x60
        public long objectId; // 0x68
        public long assemId; // 0x70
        public string binderTypeName; // 0x78
        public string binderAssemblyString; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ObjectEnd(){} // RVA: 0x7FFAC84BC2F0
        public void InternalInit(){} // RVA: 0x7FFAC84BC320
        public void Serialize(){} // RVA: 0x7FFAC84BCD80 | overloaded x2
        public void InitSerialize(){} // RVA: 0x7FFAC84BCE20 | overloaded x2
        public void InitSiWrite(){} // RVA: 0x7FFAC84BD480
        public void CheckTypeForwardedFrom(){} // RVA: 0x7FFAC84BDB60
        public void InitNoMembers(){} // RVA: 0x7FFAC84BDC30
        public void InitMemberInfo(){} // RVA: 0x7FFAC84BDE10
        public void GetTypeFullName(){} // RVA: 0x7FFAC84BE410
        public void GetAssemblyString(){} // RVA: 0x7FFAC84BE440
        public void InvokeSerializationBinder(){} // RVA: 0x7FFAC84BE470
        public void GetMemberType(){} // RVA: 0x7FFAC84BE4B0
        public void GetMemberInfo(){} // RVA: 0x7FFAC84BE6A0
        public void GetObjectInfo(){} // RVA: 0x7FFAC84BE840
        public void PutObjectInfo(){} // RVA: 0x7FFAC84BE910
    }

    public class __BinaryParser : Object
    {
        public System.Runtime.Serialization.Formatters.Binary.ObjectReader SystemAssemblyInfo; // 0x10
        public System.IO.Stream ObjectMapIdTable; // 0x18
        public long AssemIdToAssemblyTable; // 0x20
        public long prs; // 0x28
        public System.Runtime.Serialization.Formatters.Binary.SizedArray objectMapIdTable; // 0x30
        public System.Runtime.Serialization.Formatters.Binary.SizedArray assemIdToAssemblyTable; // 0x38
        public System.Runtime.Serialization.Formatters.Binary.SerStack stack; // 0x40
        public 0x6B0D36B8 expectedType; // 0x48
        public object expectedTypeInformation; // 0x50
        public System.Runtime.Serialization.Formatters.Binary.ParseRecord PRS; // 0x58
        public System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo systemAssemblyInfo; // 0x60
        public System.IO.BinaryReader dataReader; // 0x68
        public System.Text.Encoding encoding;
        public System.Runtime.Serialization.Formatters.Binary.SerStack opPool; // 0x70
        public System.Runtime.Serialization.Formatters.Binary.BinaryObject binaryObject; // 0x78
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMap bowm; // 0x80
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMapTyped bowmt; // 0x88
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectString objectString; // 0x90
        public System.Runtime.Serialization.Formatters.Binary.BinaryCrossAppDomainString crossAppDomainString; // 0x98
        public System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
        public byte[] byteBuffer; // 0xA8
        public System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
        public System.Runtime.Serialization.Formatters.Binary.MemberReference memberReference; // 0xB8
        public System.Runtime.Serialization.Formatters.Binary.ObjectNull objectNull; // 0xC0
        public System.Runtime.Serialization.Formatters.Binary.MessageEnd messageEnd; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84CAD50
        public void get_SystemAssemblyInfo(){} // RVA: 0x7FFAC84CAFA0
        public void get_ObjectMapIdTable(){} // RVA: 0x7FFAC84CB140
        public void get_AssemIdToAssemblyTable(){} // RVA: 0x7FFAC84CB2F0
        public void get_prs(){} // RVA: 0x7FFAC84CB4A0
        public void Run(){} // RVA: 0x7FFAC84CB540
        public void ReadBegin(){} // RVA: 0x7FFAC2F21310
        public void ReadEnd(){} // RVA: 0x7FFAC2F21310
        public void ReadBoolean(){} // RVA: 0x7FFAC84CBB40
        public void ReadByte(){} // RVA: 0x7FFAC84CBB70
        public void ReadBytes(){} // RVA: 0x7FFAC84CBBD0 | overloaded x2
        public void ReadChar(){} // RVA: 0x7FFAC84CBC50
        public void ReadChars(){} // RVA: 0x7FFAC84CBC80
        public void ReadDecimal(){} // RVA: 0x7FFAC84CBCB0
        public void ReadSingle(){} // RVA: 0x7FFAC84CBE70
        public void ReadDouble(){} // RVA: 0x7FFAC84CBEA0
        public void ReadInt16(){} // RVA: 0x7FFAC84CBED0
        public void ReadInt32(){} // RVA: 0x7FFAC84CBF00
        public void ReadInt64(){} // RVA: 0x7FFAC84CBF30
        public void ReadSByte(){} // RVA: 0x7FFAC84CBB70
        public void ReadString(){} // RVA: 0x7FFAC84CBF60
        public void ReadTimeSpan(){} // RVA: 0x7FFAC84CBF30
        public void ReadDateTime(){} // RVA: 0x7FFAC84CBF90
        public void ReadUInt16(){} // RVA: 0x7FFAC84CC010
        public void ReadUInt32(){} // RVA: 0x7FFAC84CC040
        public void ReadUInt64(){} // RVA: 0x7FFAC84CC070
        public void ReadSerializationHeaderRecord(){} // RVA: 0x7FFAC84CC0A0
        public void ReadAssembly(){} // RVA: 0x7FFAC84CC150
        public void ReadObject(){} // RVA: 0x7FFAC84CC550
        public void ReadCrossAppDomainMap(){} // RVA: 0x7FFAC84CCD00
        public void ReadObjectWithMap(){} // RVA: 0x7FFAC84CCFE0 | overloaded x2
        public void ReadObjectWithMapTyped(){} // RVA: 0x7FFAC84CD970 | overloaded x2
        public void ReadObjectString(){} // RVA: 0x7FFAC84CE250
        public void ReadMemberPrimitiveTyped(){} // RVA: 0x7FFAC84CECA0
        public void ReadArray(){} // RVA: 0x7FFAC84CF2F0
        public void ReadArrayAsBytes(){} // RVA: 0x7FFAC84CFB20
        public void ReadMemberPrimitiveUnTyped(){} // RVA: 0x7FFAC84CFF90
        public void ReadMemberReference(){} // RVA: 0x7FFAC84D0440
        public void ReadObjectNull(){} // RVA: 0x7FFAC84D0790
        public void ReadMessageEnd(){} // RVA: 0x7FFAC84D0B30
        public void ReadValue(){} // RVA: 0x7FFAC84D0D10
        public void GetOp(){} // RVA: 0x7FFAC84D1400
        public void PutOp(){} // RVA: 0x7FFAC84D1530
        public void .cctor(){} // RVA: 0x7FFAC84D1620
    }

    public class __BinaryWriter : Object
    {
        public System.IO.Stream sout; // 0x10
        public 0x6B0D3558 formatterTypeStyle; // 0x18
        public System.Collections.Hashtable objectMapTable; // 0x20
        public System.Runtime.Serialization.Formatters.Binary.ObjectWriter objectWriter; // 0x28
        public System.IO.BinaryWriter dataWriter; // 0x30
        public int m_nestedObjectCount; // 0x38
        public int nullCount; // 0x3C
        public System.Runtime.Serialization.Formatters.Binary.BinaryMethodCall binaryMethodCall; // 0x40
        public System.Runtime.Serialization.Formatters.Binary.BinaryMethodReturn binaryMethodReturn; // 0x48
        public System.Runtime.Serialization.Formatters.Binary.BinaryObject binaryObject; // 0x50
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMap binaryObjectWithMap; // 0x58
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
        public System.Runtime.Serialization.Formatters.Binary.BinaryObjectString binaryObjectString; // 0x68
        public System.Runtime.Serialization.Formatters.Binary.BinaryArray binaryArray; // 0x70
        public byte[] byteBuffer; // 0x78
        public int chunkSize; // 0x80
        public System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
        public System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
        public System.Runtime.Serialization.Formatters.Binary.ObjectNull objectNull; // 0x98
        public System.Runtime.Serialization.Formatters.Binary.MemberReference memberReference; // 0xA0
        public System.Runtime.Serialization.Formatters.Binary.BinaryAssembly binaryAssembly; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84B8EB0
        public void WriteBegin(){} // RVA: 0x7FFAC2F21310
        public void WriteEnd(){} // RVA: 0x7FFAC84B9050
        public void WriteBoolean(){} // RVA: 0x7FFAC84B9080
        public void WriteByte(){} // RVA: 0x7FFAC84B90B0
        public void WriteBytes(){} // RVA: 0x7FFAC84B9110 | overloaded x2
        public void WriteChar(){} // RVA: 0x7FFAC84B9140
        public void WriteChars(){} // RVA: 0x7FFAC84B9170
        public void WriteDecimal(){} // RVA: 0x7FFAC84B91A0
        public void WriteSingle(){} // RVA: 0x7FFAC843EE30
        public void WriteDouble(){} // RVA: 0x7FFAC84B92A0
        public void WriteInt16(){} // RVA: 0x7FFAC84B92D0
        public void WriteInt32(){} // RVA: 0x7FFAC84B9300
        public void WriteInt64(){} // RVA: 0x7FFAC84B9330
        public void WriteSByte(){} // RVA: 0x7FFAC84B90B0
        public void WriteString(){} // RVA: 0x7FFAC84B9360
        public void WriteTimeSpan(){} // RVA: 0x7FFAC84B9390
        public void WriteDateTime(){} // RVA: 0x7FFAC84B9410
        public void WriteUInt16(){} // RVA: 0x7FFAC84B9490
        public void WriteUInt32(){} // RVA: 0x7FFAC84B94C0
        public void WriteUInt64(){} // RVA: 0x7FFAC84B94F0
        public void WriteObjectEnd(){} // RVA: 0x7FFAC2F21310
        public void WriteSerializationHeaderEnd(){} // RVA: 0x7FFAC84B9520
        public void WriteSerializationHeader(){} // RVA: 0x7FFAC84B9590
        public void WriteMethodCall(){} // RVA: 0x7FFAC84B96D0
        public void WriteMethodReturn(){} // RVA: 0x7FFAC84B9790
        public void WriteObject(){} // RVA: 0x7FFAC84B9850
        public void WriteObjectString(){} // RVA: 0x7FFAC84BA2F0
        public void WriteSingleArray(){} // RVA: 0x7FFAC84BA4A0
        public void WriteArrayAsBytes(){} // RVA: 0x7FFAC84BA850
        public void WriteJaggedArray(){} // RVA: 0x7FFAC84BAA20
        public void WriteRectangleArray(){} // RVA: 0x7FFAC84BAC60
        public void WriteObjectByteArray(){} // RVA: 0x7FFAC84BAE40
        public void WriteMember(){} // RVA: 0x7FFAC84BAEA0
        public void WriteNullMember(){} // RVA: 0x7FFAC84BB150
        public void WriteMemberObjectRef(){} // RVA: 0x7FFAC84BB250
        public void WriteMemberNested(){} // RVA: 0x7FFAC84BB380
        public void WriteMemberString(){} // RVA: 0x7FFAC84BB3B0
        public void WriteItem(){} // RVA: 0x7FFAC84BB410
        public void WriteNullItem(){} // RVA: 0x7FFAC84BB470
        public void WriteDelayedNullItem(){} // RVA: 0x7FFAC84BB480
        public void WriteItemEnd(){} // RVA: 0x7FFAC84BB490
        public void InternalWriteItemNull(){} // RVA: 0x7FFAC84BB4A0
        public void WriteItemObjectRef(){} // RVA: 0x7FFAC84BB590
        public void WriteAssembly(){} // RVA: 0x7FFAC84BB5D0
        public void WriteValue(){} // RVA: 0x7FFAC84BB7D0
    }

}