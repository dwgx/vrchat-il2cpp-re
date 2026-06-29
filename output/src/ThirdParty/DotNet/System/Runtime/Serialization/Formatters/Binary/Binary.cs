// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
// Classes: 44
// Methods: 354

namespace ThirdParty.DotNet.System.Runtime.Serialization.Formatters.Binary
{
    public class BinaryArray : Object
    {
        public object objectId;
        public object rank;
        public object lengthA;
        public object lowerBoundA;
        public object binaryTypeEnum;
        public object typeInformation;
        public object assemId;
        public object binaryHeaderEnum;
        public object binaryArrayTypeEnum;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x25671C0
        public void Set(){} // RVA: 0x6792C80
        public void Write(){} // RVA: 0x6792E00
        public void Read(){} // RVA: 0x6793180
    }

    public class BinaryAssembly : Object
    {
        public object assemId;
        public object assemblyString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0x2574280
        public void Write(){} // RVA: 0x6791390
        public void Read(){} // RVA: 0x6791420
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryAssemblyInfo : Object
    {
        public object assemblyString;
        public object assembly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetAssembly(){} // RVA: 0x6790EC0
    }

    public class BinaryConverter : Object
    {
        // ── Methods ──
        public void GetBinaryTypeInfo(){} // RVA: 0x678FC60
        public void GetParserBinaryTypeInfo(){} // RVA: 0x6790040
        public void WriteTypeInfo(){} // RVA: 0x6790340
        public void ReadTypeInfo(){} // RVA: 0x67905C0
        public void TypeFromInfo(){} // RVA: 0x67907E0
    }

    public class BinaryCrossAppDomainAssembly : Object
    {
        public object assemId;
        public object assemblyIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0x67914E0
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryCrossAppDomainMap : Object
    {
        public object crossAppDomainArrayIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0x6791D50
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryCrossAppDomainString : Object
    {
        public object objectId;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0x67914E0
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryFormatter : Object
    {
        public object m_surrogates;
        public object m_context;
        public object m_binder;
        public object m_typeFormat;
        public object m_assemblyFormat;
        public object m_securityLevel;
        public object m_crossAppDomainArray;
        public object typeNameCache;

        // ── Methods ──
        public void set_AssemblyFormat(){} // RVA: 0xEA1260
        public void set_SurrogateSelector(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x6799460
        public void Deserialize(){} // RVA: 0x6799850
        public void Serialize(){} // RVA: 0x67998B0
        public void GetTypeInformation(){} // RVA: 0x6799C80
        public void .cctor(){} // RVA: 0x679A0A0
    }

    public class BinaryMethodCall : Object
    {
        public object methodName;
        public object typeName;
        public object args;
        public object callContext;
        public object argTypes;
        public object bArgsPrimitive;
        public object messageEnum;

        // ── Methods ──
        public void Write(){} // RVA: 0x67915E0
        public void Dump(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x1A9DEA0
    }

    public class BinaryMethodReturn : Object
    {
        public object returnValue;
        public object args;
        public object callContext;
        public object argTypes;
        public object bArgsPrimitive;
        public object messageEnum;
        public object returnType;
        public object instanceOfVoid;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6791930
        public void .ctor(){} // RVA: 0x21B8CE0
        public void Write(){} // RVA: 0x6791A30
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryObject : Object
    {
        public object objectId;
        public object mapId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0x4F358F0
        public void Write(){} // RVA: 0x6791550
        public void Read(){} // RVA: 0x67914E0
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryObjectString : Object
    {
        public object objectId;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0x2574280
        public void Write(){} // RVA: 0x6791CC0
        public void Read(){} // RVA: 0x6791420
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryObjectWithMap : Object
    {
        public object binaryHeaderEnum;
        public object objectId;
        public object name;
        public object numMembers;
        public object memberNames;
        public object assemId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void Set(){} // RVA: 0x6791EB0
        public void Write(){} // RVA: 0x6791FA0
        public void Read(){} // RVA: 0x67920E0
        public void Dump(){} // RVA: 0xB43310
    }

    public class BinaryObjectWithMapTyped : Object
    {
        public object binaryHeaderEnum;
        public object objectId;
        public object name;
        public object numMembers;
        public object memberNames;
        public object binaryTypeEnumA;
        public object typeInformationA;
        public object memberAssemIds;
        public object assemId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void Set(){} // RVA: 0x6792350
        public void Write(){} // RVA: 0x6792540
        public void Read(){} // RVA: 0x6792760
    }

    public class BinaryTypeEnum[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Converter : Object
    {
        public object primitiveTypeEnumLength;
        public object typeA;
        public object arrayTypeA;
        public object valueA;
        public object typeCodeA;
        public object codeA;
        public object typeofISerializable;
        public object typeofString;
        public object typeofConverter;
        public object typeofBoolean;
        public object typeofByte;
        public object typeofChar;
        public object typeofDecimal;
        public object typeofDouble;
        public object typeofInt16;
        public object typeofInt32;
        public object typeofInt64;
        public object typeofSByte;
        public object typeofSingle;
        public object typeofTimeSpan;
        public object typeofDateTime;
        public object typeofUInt16;
        public object typeofUInt32;
        public object typeofUInt64;
        public object typeofObject;
        public object typeofSystemVoid;
        public object urtAssembly;
        public object urtAssemblyString;
        public object typeofTypeArray;
        public object typeofObjectArray;
        public object typeofStringArray;
        public object typeofBooleanArray;
        public object typeofByteArray;
        public object typeofCharArray;
        public object typeofDecimalArray;
        public object typeofDoubleArray;
        public object typeofInt16Array;
        public object typeofInt32Array;
        public object typeofInt64Array;
        public object typeofSByteArray;
        public object typeofSingleArray;
        public object typeofTimeSpanArray;
        public object typeofDateTimeArray;
        public object typeofUInt16Array;
        public object typeofUInt32Array;
        public object typeofUInt64Array;
        public object typeofMarshalByRefObject;

        // ── Methods ──
        public void ToCode(){} // RVA: 0x6795490
        public void IsWriteAsByteArray(){} // RVA: 0x67956C0
        public void TypeLength(){} // RVA: 0x6795730
        public void ToArrayType(){} // RVA: 0x67957C0
        public void InitTypeA(){} // RVA: 0x6795890
        public void InitArrayTypeA(){} // RVA: 0x6795ED0
        public void ToType(){} // RVA: 0x6796520
        public void CreatePrimitiveArray(){} // RVA: 0x67965F0
        public void IsPrimitiveArray(){} // RVA: 0x6796820
        public void InitValueA(){} // RVA: 0x6796C10
        public void ToComType(){} // RVA: 0x6796FC0
        public void InitTypeCodeA(){} // RVA: 0x6797090
        public void ToTypeCode(){} // RVA: 0x67972A0
        public void InitCodeA(){} // RVA: 0x6797370
        public void ToPrimitiveTypeEnum(){} // RVA: 0x6797590
        public void FromString(){} // RVA: 0x6797660
        public void .cctor(){} // RVA: 0x67977F0
    }

    public class IOUtil : Object
    {
        // ── Methods ──
        public void FlagTest(){} // RVA: 0x2154E40
        public void WriteStringWithCode(){} // RVA: 0x6790CE0
        public void WriteWithCode(){} // RVA: 0x6790D70
    }

    public class IntSizedArray : Object
    {
        public object objects;
        public object negObjects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B40A0
        public void Clone(){} // RVA: 0x67B42D0
        public void get_Item(){} // RVA: 0x67B4330
        public void set_Item(){} // RVA: 0x67B43A0
        public void IncreaseCapacity(){} // RVA: 0x67B4450
    }

    public class InternalFE : Object
    {
        public object FEtypeFormat;
        public object FEassemblyFormat;
        public object FEsecurityLevel;
        public object FEserializerTypeEnum;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MemberPrimitiveTyped : Object
    {
        public object primitiveTypeEnum;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0x2574280
        public void Write(){} // RVA: 0x6791D90
        public void Read(){} // RVA: 0x6791E10
        public void Dump(){} // RVA: 0xB43310
    }

    public class MemberPrimitiveUnTyped : Object
    {
        public object typeInformation;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0xB460A0
        public void Write(){} // RVA: 0x6793B10
        public void Read(){} // RVA: 0x6793B40
        public void Dump(){} // RVA: 0xB43310
    }

    public class MemberReference : Object
    {
        public object idRef;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0xB460A0
        public void Write(){} // RVA: 0x6793BC0
        public void Read(){} // RVA: 0x6791D50
        public void Dump(){} // RVA: 0xB43310
    }

    public class MessageEnd : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Write(){} // RVA: 0x6793DD0
        public void Read(){} // RVA: 0xB43310
        public void Dump(){} // RVA: 0xB43310
    }

    public class NameCache : Object
    {
        public object ht;
        public object name;

        // ── Methods ──
        public void GetCachedValue(){} // RVA: 0x67B46C0
        public void SetCachedValue(){} // RVA: 0x67B4860
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x67B4900
    }

    public class NameInfo : Object
    {
        public object NIFullName;
        public object NIobjectId;
        public object NIassemId;
        public object NIprimitiveTypeEnum;
        public object NItype;
        public object NIisSealed;
        public object NIisArray;
        public object NIisArrayItem;
        public object NItransmitTypeOnObject;
        public object NItransmitTypeOnMember;
        public object NIisParentTypeOnObject;
        public object NIarrayEnum;
        public object NIsealedStatusChecked;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0x67B4F60
        public void get_IsSealed(){} // RVA: 0x67B5040
        public void get_NIname(){} // RVA: 0x67B5090
        public void set_NIname(){} // RVA: 0xB44D60
    }

    public class ObjectMap : Object
    {
        public object objectName;
        public object objectType;
        public object binaryTypeEnumA;
        public object typeInformationA;
        public object memberTypes;
        public object memberNames;
        public object objectInfo;
        public object isInitObjectInfo;
        public object objectReader;
        public object objectId;
        public object assemblyInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67943F0
        public void CreateObjectInfo(){} // RVA: 0x6794C30
        public void Create(){} // RVA: 0x6794D30
    }

    public class ObjectMapInfo : Object
    {
        public object objectId;
        public object numMembers;
        public object memberNames;
        public object memberTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x679D3F0
        public void isCompatible(){} // RVA: 0x679D4B0
    }

    public class ObjectNull : Object
    {
        public object nullCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void SetNullCount(){} // RVA: 0xB460A0
        public void Write(){} // RVA: 0x6793C30
        public void Read(){} // RVA: 0x6793D30
        public void Dump(){} // RVA: 0xB43310
    }

    public class ObjectProgress : Object
    {
        public object opRecordIdCount;
        public object isInitial;
        public object count;
        public object expectedType;
        public object expectedTypeInformation;
        public object name;
        public object objectTypeEnum;
        public object memberTypeEnum;
        public object memberValueEnum;
        public object dtType;
        public object numItems;
        public object binaryTypeEnum;
        public object typeInformation;
        public object nullCount;
        public object memberLength;
        public object binaryTypeEnumA;
        public object typeInformationA;
        public object memberNames;
        public object memberTypes;
        public object pr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6794E10
        public void Init(){} // RVA: 0x6794EB0
        public void ArrayCountIncrement(){} // RVA: 0x67951A0
        public void GetNext(){} // RVA: 0x67951B0
        public void .cctor(){} // RVA: 0x6795450
    }

    public class ObjectReader : Object
    {
        public object m_stream;
        public object m_surrogates;
        public object m_context;
        public object m_objectManager;
        public object formatterEnums;
        public object m_binder;
        public object topId;
        public object bSimpleAssembly;
        public object handlerObject;
        public object m_topObject;
        public object headers;
        public object handler;
        public object serObjectInfoInit;
        public object m_formatterConverter;
        public object stack;
        public object valueFixupStack;
        public object crossAppDomainArray;
        public object bFullDeserialization;
        public object bOldFormatDetected;
        public object valTypeObjectIdTable;
        public object typeCache;
        public object previousAssemblyString;
        public object previousName;
        public object previousType;

        // ── Methods ──
        public void get_ValueFixupStack(){} // RVA: 0x67A26F0
        public void get_TopObject(){} // RVA: 0xBE2C60
        public void set_TopObject(){} // RVA: 0x67A27C0
        public void .ctor(){} // RVA: 0x67A2880
        public void Deserialize(){} // RVA: 0x67A2B50
        public void HasSurrogate(){} // RVA: 0x67A3000
        public void CheckSerializable(){} // RVA: 0x67A3100
        public void InitFullDeserialization(){} // RVA: 0x67A3240
        public void CrossAppDomainArray(){} // RVA: 0x67A3460
        public void CreateReadObjectInfo(){} // RVA: 0x67A34E0
        public void Parse(){} // RVA: 0x67A3600
        public void ParseError(){} // RVA: 0x67A3840
        public void ParseSerializedStreamHeader(){} // RVA: 0x67A3AB0
        public void ParseSerializedStreamHeaderEnd(){} // RVA: 0x67A3AE0
        public void ParseObject(){} // RVA: 0x67A3B10
        public void ParseObjectEnd(){} // RVA: 0x67A4000
        public void ParseArray(){} // RVA: 0x67A43B0
        public void NextRectangleMap(){} // RVA: 0x67A4F30
        public void ParseArrayMember(){} // RVA: 0x67A5030
        public void ParseArrayMemberEnd(){} // RVA: 0x67A5D80
        public void ParseMember(){} // RVA: 0x67A5DB0
        public void ParseMemberEnd(){} // RVA: 0x67A6700
        public void ParseString(){} // RVA: 0x67A67C0
        public void RegisterObject(){} // RVA: 0x67A68E0
        public void GetId(){} // RVA: 0x67A6AD0
        public void Bind(){} // RVA: 0x67A6E00
        public void FastBindToType(){} // RVA: 0x67A6E60
        public void ResolveSimpleAssemblyName(){} // RVA: 0x67A73D0
        public void GetSimplyNamedTypeFromAssembly(){} // RVA: 0x67A7490
        public void GetType(){} // RVA: 0x67A7760
        public void CheckTypeForwardedTo(){} // RVA: 0x67A7C50
    }

    public class ObjectWriter : Object
    {
        public object m_objectQueue;
        public object m_idGenerator;
        public object m_currentId;
        public object m_surrogates;
        public object m_context;
        public object serWriter;
        public object m_objectManager;
        public object topId;
        public object topName;
        public object headers;
        public object formatterEnums;
        public object m_binder;
        public object serObjectInfoInit;
        public object m_formatterConverter;
        public object crossAppDomainArray;
        public object previousObj;
        public object previousId;
        public object previousType;
        public object previousCode;
        public object assemblyToIdTable;
        public object niPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67A7DA0
        public void Serialize(){} // RVA: 0x67A8150
        public void get_ObjectManager(){} // RVA: 0xBBF8F0
        public void Write(){} // RVA: 0x67A90F0
        public void WriteMemberSetup(){} // RVA: 0x67A9550
        public void WriteMembers(){} // RVA: 0x67A96F0
        public void WriteArray(){} // RVA: 0x67A9E00
        public void WriteArrayMember(){} // RVA: 0x67AAA20
        public void WriteRectangle(){} // RVA: 0x67AADC0
        public void GetNext(){} // RVA: 0x67AB020
        public void InternalGetId(){} // RVA: 0x67AB1E0
        public void Schedule(){} // RVA: 0x67AB3A0
        public void WriteKnownValueClass(){} // RVA: 0x67AB460
        public void WriteObjectRef(){} // RVA: 0x67AB570
        public void WriteString(){} // RVA: 0x67AB590
        public void CheckForNull(){} // RVA: 0x67AB720
        public void WriteSerializedStreamHeader(){} // RVA: 0x67AB8F0
        public void TypeToNameInfo(){} // RVA: 0x67ABC90
        public void MemberToNameInfo(){} // RVA: 0x67ABD40
        public void ToCode(){} // RVA: 0x67ABDB0
        public void GetAssemblyId(){} // RVA: 0x67ABE90
        public void GetType(){} // RVA: 0xE8FF70
        public void GetNameInfo(){} // RVA: 0x67AC160
        public void CheckTypeFormat(){} // RVA: 0x67AC200
        public void PutNameInfo(){} // RVA: 0x67AC210
    }

    public class ParseRecord : Object
    {
        public object parseRecordIdCount;
        public object PRparseTypeEnum;
        public object PRobjectTypeEnum;
        public object PRarrayTypeEnum;
        public object PRmemberTypeEnum;
        public object PRmemberValueEnum;
        public object PRobjectPositionEnum;
        public object PRname;
        public object PRvalue;
        public object PRvarValue;
        public object PRkeyDt;
        public object PRdtType;
        public object PRdtTypeCode;
        public object PRisEnum;
        public object PRobjectId;
        public object PRidRef;
        public object PRarrayElementTypeString;
        public object PRarrayElementType;
        public object PRisArrayVariant;
        public object PRarrayElementTypeCode;
        public object PRrank;
        public object PRlengthA;
        public object PRpositionA;
        public object PRlowerBoundA;
        public object PRupperBoundA;
        public object PRindexMap;
        public object PRmemberIndex;
        public object PRlinearlength;
        public object PRrectangularMap;
        public object PRisLowerBound;
        public object PRtopId;
        public object PRheaderId;
        public object PRobjectInfo;
        public object PRisValueTypeFixup;
        public object PRnewObj;
        public object PRobjectA;
        public object PRprimitiveArray;
        public object PRisRegistered;
        public object PRmemberData;
        public object PRsi;
        public object PRnullCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0x67B2B20
        public void .cctor(){} // RVA: 0x67B31D0
    }

    public class PrimitiveArray : Object
    {
        public object code;
        public object booleanA;
        public object charA;
        public object doubleA;
        public object int16A;
        public object int32A;
        public object int64A;
        public object sbyteA;
        public object singleA;
        public object uint16A;
        public object uint32A;
        public object uint64A;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B5120
        public void Init(){} // RVA: 0x67B5130
        public void SetValue(){} // RVA: 0x67B5710
    }

    public class ReadObjectInfo : Object
    {
        public object objectInfoId;
        public object readObjectInfoCounter;
        public object objectType;
        public object objectManager;
        public object count;
        public object isSi;
        public object isNamed;
        public object isTyped;
        public object bSimpleAssembly;
        public object cache;
        public object wireMemberNames;
        public object wireMemberTypes;
        public object lastPosition;
        public object serializationSurrogate;
        public object context;
        public object memberTypesList;
        public object serObjectInfoInit;
        public object formatterConverter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ObjectEnd(){} // RVA: 0xB43310
        public void PrepareForReuse(){} // RVA: 0xBD4A20
        public void Create(){} // RVA: 0x679FFE0
        public void Init(){} // RVA: 0x67A00F0
        public void InitReadConstructor(){} // RVA: 0x67A0420
        public void InitSiRead(){} // RVA: 0x67A0840
        public void InitNoMembers(){} // RVA: 0x67A0980
        public void InitMemberInfo(){} // RVA: 0x67A0A40
        public void GetMemberInfo(){} // RVA: 0x67A0EB0
        public void GetType(){} // RVA: 0x67A1120
        public void AddValue(){} // RVA: 0x67A12E0
        public void InitDataStore(){} // RVA: 0x67A1550
        public void RecordFixup(){} // RVA: 0x67A16A0
        public void PopulateObjectMembers(){} // RVA: 0x67A1770
        public void Position(){} // RVA: 0x67A1800
        public void GetMemberTypes(){} // RVA: 0x67A1A40
        public void GetMemberType(){} // RVA: 0x67A2140
        public void GetObjectInfo(){} // RVA: 0x67A2330
    }

    public class SerObjectInfoCache : Object
    {
        public object fullTypeName;
        public object assemblyString;
        public object hasTypeForwardedFrom;
        public object memberInfos;
        public object memberNames;
        public object memberTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67A25C0
    }

    public class SerObjectInfoInit : Object
    {
        public object seenBeforeTable;
        public object objectInfoIdCount;
        public object oiPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67A23A0
    }

    public class SerStack : Object
    {
        public object objects;
        public object stackId;
        public object top;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B3210
        public void Push(){} // RVA: 0x67B3320
        public void Pop(){} // RVA: 0x67B3480
        public void IncreaseCapacity(){} // RVA: 0x67B34F0
        public void Peek(){} // RVA: 0x67B35D0
        public void PeekPeek(){} // RVA: 0x67B3610
        public void IsEmpty(){} // RVA: 0x67B3650
    }

    public class SerializationHeaderRecord : Object
    {
        public object binaryFormatterMajorVersion;
        public object binaryFormatterMinorVersion;
        public object binaryHeaderEnum;
        public object topId;
        public object headerId;
        public object majorVersion;
        public object minorVersion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6791020
        public void Write(){} // RVA: 0x6791050
        public void GetInt32(){} // RVA: 0x673F770
        public void Read(){} // RVA: 0x6791130
        public void Dump(){} // RVA: 0xB43310
    }

    public class SizedArray : Object
    {
        public object objects;
        public object negObjects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B3880
        public void Clone(){} // RVA: 0x67B3A00
        public void get_Item(){} // RVA: 0x67B3BA0
        public void set_Item(){} // RVA: 0x67B3C10
        public void IncreaseCapacity(){} // RVA: 0x67B3D20
    }

    public class TypeInformation : Object
    {
        public object fullTypeName;
        public object assemblyString;
        public object hasTypeForwardedFrom;

        // ── Methods ──
        public void get_FullTypeName(){} // RVA: 0xB5DBF0
        public void get_AssemblyString(){} // RVA: 0xB465B0
        public void get_HasTypeForwardedFrom(){} // RVA: 0xC38360
        public void .ctor(){} // RVA: 0x67A2500
    }

    public class ValueFixup : Object
    {
        public object valueFixupEnum;
        public object arrayObj;
        public object indexMap;
        public object header;
        public object memberObject;
        public object valueInfo;
        public object objectInfo;
        public object memberName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B4AA0
        public void Fixup(){} // RVA: 0x67B4BB0
    }

    public class WriteObjectInfo : Object
    {
        public object objectInfoId;
        public object obj;
        public object objectType;
        public object isSi;
        public object isNamed;
        public object isTyped;
        public object isArray;
        public object si;
        public object cache;
        public object memberData;
        public object serializationSurrogate;
        public object context;
        public object serObjectInfoInit;
        public object objectId;
        public object assemId;
        public object binderTypeName;
        public object binderAssemblyString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ObjectEnd(){} // RVA: 0x679D600
        public void InternalInit(){} // RVA: 0x679D630
        public void Serialize(){} // RVA: 0x679E080
        public void InitSerialize(){} // RVA: 0x679E120
        public void InitSiWrite(){} // RVA: 0x679E790
        public void CheckTypeForwardedFrom(){} // RVA: 0x679EE70
        public void InitNoMembers(){} // RVA: 0x679EF40
        public void InitMemberInfo(){} // RVA: 0x679F120
        public void GetTypeFullName(){} // RVA: 0x679F780
        public void GetAssemblyString(){} // RVA: 0x679F7B0
        public void InvokeSerializationBinder(){} // RVA: 0x679F7E0
        public void GetMemberType(){} // RVA: 0x679F820
        public void GetMemberInfo(){} // RVA: 0x679FA10
        public void GetObjectInfo(){} // RVA: 0x679FBB0
        public void PutObjectInfo(){} // RVA: 0x679FC80
    }

    public class __BinaryParser : Object
    {
        public object objectReader;
        public object input;
        public object topId;
        public object headerId;
        public object objectMapIdTable;
        public object assemIdToAssemblyTable;
        public object stack;
        public object expectedType;
        public object expectedTypeInformation;
        public object PRS;
        public object systemAssemblyInfo;
        public object dataReader;
        public object encoding;
        public object opPool;
        public object binaryObject;
        public object bowm;
        public object bowmt;
        public object objectString;
        public object crossAppDomainString;
        public object memberPrimitiveTyped;
        public object byteBuffer;
        public object memberPrimitiveUnTyped;
        public object memberReference;
        public object objectNull;
        public object messageEnd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67AC240
        public void get_SystemAssemblyInfo(){} // RVA: 0x67AC4A0
        public void get_ObjectMapIdTable(){} // RVA: 0x67AC640
        public void get_AssemIdToAssemblyTable(){} // RVA: 0x67AC7F0
        public void get_prs(){} // RVA: 0x67AC9A0
        public void Run(){} // RVA: 0x67ACA40
        public void ReadBegin(){} // RVA: 0xB43310
        public void ReadEnd(){} // RVA: 0xB43310
        public void ReadBoolean(){} // RVA: 0x67AD020
        public void ReadByte(){} // RVA: 0x67AD050
        public void ReadBytes(){} // RVA: 0x67AD0B0
        public void ReadChar(){} // RVA: 0x67AD130
        public void ReadChars(){} // RVA: 0x67AD160
        public void ReadDecimal(){} // RVA: 0x67AD190
        public void ReadSingle(){} // RVA: 0x67AD350
        public void ReadDouble(){} // RVA: 0x67AD380
        public void ReadInt16(){} // RVA: 0x67AD3B0
        public void ReadInt32(){} // RVA: 0x67AD3E0
        public void ReadInt64(){} // RVA: 0x67AD410
        public void ReadSByte(){} // RVA: 0x67AD050
        public void ReadString(){} // RVA: 0x67AD440
        public void ReadTimeSpan(){} // RVA: 0x67AD410
        public void ReadDateTime(){} // RVA: 0x67AD470
        public void ReadUInt16(){} // RVA: 0x67AD4F0
        public void ReadUInt32(){} // RVA: 0x67AD520
        public void ReadUInt64(){} // RVA: 0x67AD550
        public void ReadSerializationHeaderRecord(){} // RVA: 0x67AD580
        public void ReadAssembly(){} // RVA: 0x67AD630
        public void ReadObject(){} // RVA: 0x67ADA30
        public void ReadCrossAppDomainMap(){} // RVA: 0x67AE1D0
        public void ReadObjectWithMap(){} // RVA: 0x67AE4B0
        public void ReadObjectWithMapTyped(){} // RVA: 0x67AEE40
        public void ReadObjectString(){} // RVA: 0x67AF720
        public void ReadMemberPrimitiveTyped(){} // RVA: 0x67B0170
        public void ReadArray(){} // RVA: 0x67B07C0
        public void ReadArrayAsBytes(){} // RVA: 0x67B1000
        public void ReadMemberPrimitiveUnTyped(){} // RVA: 0x67B1460
        public void ReadMemberReference(){} // RVA: 0x67B1910
        public void ReadObjectNull(){} // RVA: 0x67B1C60
        public void ReadMessageEnd(){} // RVA: 0x67B2000
        public void ReadValue(){} // RVA: 0x67B21E0
        public void GetOp(){} // RVA: 0x67B2800
        public void PutOp(){} // RVA: 0x67B2930
        public void .cctor(){} // RVA: 0x67B2A20
    }

    public class __BinaryWriter : Object
    {
        public object sout;
        public object formatterTypeStyle;
        public object objectMapTable;
        public object objectWriter;
        public object dataWriter;
        public object m_nestedObjectCount;
        public object nullCount;
        public object binaryMethodCall;
        public object binaryMethodReturn;
        public object binaryObject;
        public object binaryObjectWithMap;
        public object binaryObjectWithMapTyped;
        public object binaryObjectString;
        public object binaryArray;
        public object byteBuffer;
        public object chunkSize;
        public object memberPrimitiveUnTyped;
        public object memberPrimitiveTyped;
        public object objectNull;
        public object memberReference;
        public object binaryAssembly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x679A180
        public void WriteBegin(){} // RVA: 0xB43310
        public void WriteEnd(){} // RVA: 0x679A330
        public void WriteBoolean(){} // RVA: 0x679A360
        public void WriteByte(){} // RVA: 0x679A390
        public void WriteBytes(){} // RVA: 0x679A3F0
        public void WriteChar(){} // RVA: 0x679A420
        public void WriteChars(){} // RVA: 0x679A450
        public void WriteDecimal(){} // RVA: 0x679A480
        public void WriteSingle(){} // RVA: 0x67204C0
        public void WriteDouble(){} // RVA: 0x679A580
        public void WriteInt16(){} // RVA: 0x679A5B0
        public void WriteInt32(){} // RVA: 0x679A5E0
        public void WriteInt64(){} // RVA: 0x679A610
        public void WriteSByte(){} // RVA: 0x679A390
        public void WriteString(){} // RVA: 0x679A640
        public void WriteTimeSpan(){} // RVA: 0x679A670
        public void WriteDateTime(){} // RVA: 0x679A6F0
        public void WriteUInt16(){} // RVA: 0x679A770
        public void WriteUInt32(){} // RVA: 0x679A7A0
        public void WriteUInt64(){} // RVA: 0x679A7D0
        public void WriteObjectEnd(){} // RVA: 0xB43310
        public void WriteSerializationHeaderEnd(){} // RVA: 0x679A800
        public void WriteSerializationHeader(){} // RVA: 0x679A870
        public void WriteMethodCall(){} // RVA: 0x679A9B0
        public void WriteMethodReturn(){} // RVA: 0x679AA70
        public void WriteObject(){} // RVA: 0x679AB30
        public void WriteObjectString(){} // RVA: 0x679B620
        public void WriteSingleArray(){} // RVA: 0x679B7D0
        public void WriteArrayAsBytes(){} // RVA: 0x679BB70
        public void WriteJaggedArray(){} // RVA: 0x679BD40
        public void WriteRectangleArray(){} // RVA: 0x679BF70
        public void WriteObjectByteArray(){} // RVA: 0x679C160
        public void WriteMember(){} // RVA: 0x679C1C0
        public void WriteNullMember(){} // RVA: 0x679C470
        public void WriteMemberObjectRef(){} // RVA: 0x679C570
        public void WriteMemberNested(){} // RVA: 0x679C6A0
        public void WriteMemberString(){} // RVA: 0x679C6D0
        public void WriteItem(){} // RVA: 0x679C730
        public void WriteNullItem(){} // RVA: 0x679C790
        public void WriteDelayedNullItem(){} // RVA: 0x679C7A0
        public void WriteItemEnd(){} // RVA: 0x679C7B0
        public void InternalWriteItemNull(){} // RVA: 0x679C7C0
        public void WriteItemObjectRef(){} // RVA: 0x679C8B0
        public void WriteAssembly(){} // RVA: 0x679C8F0
        public void WriteValue(){} // RVA: 0x679CAE0
    }

}