// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 31
// Methods: 268

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class Base64Encoder : Object
    {
        public object _charsLine;
        public object _writer;
        public object _leftOverBytes;
        public object _leftOverBytesCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81635A0
        public void Encode(){} // RVA: 0x8163700
        public void Flush(){} // RVA: 0x8163B50
        public void WriteChars(){} // RVA: 0x6A31660
    }

    public class BidirectionalDictionary`2 : Object
    {
        public object _firstToSecond;
        public object _secondToFirst;
        public object _duplicateFirstErrorMessage;
        public object _duplicateSecondErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899870
        public void Set(){} // RVA: 0xA94080
        public void TryGetByFirst(){} // RVA: 0xA94080
        public void TryGetBySecond(){} // RVA: 0xA94080
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x816EDA0
        public void ReturnBuffer(){} // RVA: 0x816EE20
        public void EnsureBufferSize(){} // RVA: 0x816EE80
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x87D390
        public void AddRange(){} // RVA: 0x8945C0
        public void IsDictionaryType(){} // RVA: 0x8163C30
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x8163F80
        public void IndexOf(){} // RVA: 0x881CE0
        public void Contains(){} // RVA: 0xA94080
        public void IndexOfReference(){} // RVA: 0xA94080
        public void GetDimensions(){} // RVA: 0x81641F0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x81645E0
        public void JaggedArrayGetValue(){} // RVA: 0x8164890
        public void ToMultidimensionalArray(){} // RVA: 0x8164990
    }

    public class CollectionWrapper`1 : Object
    {
        public object _list;
        public object _genericCollection;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Remove(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IList.Add(){} // RVA: 0x87D050
        public void System.Collections.IList.Contains(){} // RVA: 0x87D350
        public void System.Collections.IList.IndexOf(){} // RVA: 0x87D050
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x8944F0
        public void System.Collections.IList.Insert(){} // RVA: 0x895750
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.IList.Remove(){} // RVA: 0x894320
        public void System.Collections.IList.get_Item(){} // RVA: 0x87C160
        public void System.Collections.IList.set_Item(){} // RVA: 0x895750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void VerifyValueType(){} // RVA: 0x894350
        public void IsCompatibleObject(){} // RVA: 0x87D390
        public void get_UnderlyingCollection(){} // RVA: 0x87C0A0
    }

    public class ConvertUtils : Object
    {
        public object TypeCodeMap;
        public object PrimitiveTypeCodes;
        public object CastConverters;

        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x8164C30
        public void GetTypeInformation(){} // RVA: 0x8164F40
        public void IsConvertible(){} // RVA: 0x8164FF0
        public void ParseTimeSpan(){} // RVA: 0x81650A0
        public void CreateCastConverter(){} // RVA: 0x8165170
        public void TryConvert(){} // RVA: 0x8165450
        public void TryConvertInternal(){} // RVA: 0x8165550
        public void ConvertOrCast(){} // RVA: 0x81660B0
        public void EnsureTypeAssignable(){} // RVA: 0x8166230
        public void GetConverter(){} // RVA: 0x8166570
        public void VersionTryParse(){} // RVA: 0x8166600
        public void IsInteger(){} // RVA: 0x8166790
        public void Int32TryParse(){} // RVA: 0x6A37130
        public void Int64TryParse(){} // RVA: 0x6A372D0
        public void TryConvertGuid(){} // RVA: 0x81668B0
        public void HexTextToInt(){} // RVA: 0x8166A30
        public void HexCharToInt(){} // RVA: 0x8166BC0
        public void .cctor(){} // RVA: 0x8166C90
    }

    public class DateTimeParser : ValueType
    {
        public object Year;
        public object Month;
        public object Day;
        public object Hour;
        public object Minute;
        public object Second;
        public object Fraction;
        public object ZoneHour;
        public object ZoneMinute;
        public object Zone;
        public object _text;
        public object _end;
        public object Power10;
        public object Lzyyyy;
        public object Lzyyyy_;
        public object Lzyyyy_MM;
        public object Lzyyyy_MM_;
        public object Lzyyyy_MM_dd;
        public object Lzyyyy_MM_ddT;
        public object LzHH;
        public object LzHH_;
        public object LzHH_mm;
        public object LzHH_mm_;
        public object LzHH_mm_ss;
        public object Lz_;
        public object Lz_zz;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8168C60
        public void Parse(){} // RVA: 0x9B16D0
        public void ParseDate(){} // RVA: 0x9B16E0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x9B16F0
        public void ParseTime(){} // RVA: 0x9B1700
        public void ParseZone(){} // RVA: 0x9B1710
        public void Parse4Digit(){} // RVA: 0x8C5A90
        public void Parse2Digit(){} // RVA: 0x8C5AA0
        public void ParseChar(){} // RVA: 0x8C5AB0
    }

    public class DateTimeUtils : Object
    {
        public object InitialJavaScriptDateTicks;
        public object DaysToMonth365;
        public object DaysToMonth366;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8169AE0
        public void GetUtcOffset(){} // RVA: 0x8169CA0
        public void EnsureDateTime(){} // RVA: 0x8169CE0
        public void SwitchToLocalTime(){} // RVA: 0x816A0E0
        public void SwitchToUtcTime(){} // RVA: 0x816A270
        public void ToUniversalTicks(){} // RVA: 0x816A3C0
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x816A5E0
        public void UniversialTicksToJavaScriptTicks(){} // RVA: 0x816A6B0
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x816A730
        public void TryParseDateTimeIso(){} // RVA: 0x816A7C0
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x816AEB0
        public void CreateDateTime(){} // RVA: 0x816B230
        public void TryParseDateTime(){} // RVA: 0x816B740
        public void TryParseDateTimeOffset(){} // RVA: 0x816BF00
        public void TryParseMicrosoftDate(){} // RVA: 0x816C3F0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x816C620
        public void TryParseDateTimeExact(){} // RVA: 0x816C800
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x816C8F0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x816CAD0
        public void TryReadOffset(){} // RVA: 0x816CB80
        public void WriteDateTimeString(){} // RVA: 0x816D030
        public void WriteDefaultIsoDate(){} // RVA: 0x816D470
        public void CopyIntToCharArray(){} // RVA: 0x6A3F510
        public void WriteDateTimeOffset(){} // RVA: 0x816DA10
        public void WriteDateTimeOffsetString(){} // RVA: 0x816DD00
        public void GetDateValues(){} // RVA: 0x816DF70
    }

    public class DictionaryWrapper`2 : Object
    {
        public object _dictionary;
        public object _genericDictionary;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0xA94080
        public void ContainsKey(){} // RVA: 0xA94080
        public void get_Keys(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0x894320
        public void TryGetValue(){} // RVA: 0xA94080
        public void get_Values(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x8943B0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x87C540
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x8943B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x87D350
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_UnderlyingDictionary(){} // RVA: 0x87C0A0
    }

    public class EnumUtils : Object
    {
        public object EnumMemberNamesPerType;

        // ── Methods ──
        public void InitializeEnumType(){} // RVA: 0x816E1A0
        public void GetValues(){} // RVA: 0x816E6F0
        public void .cctor(){} // RVA: 0x816EBA0
    }

    public class IWrappedCollection
    {
        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0x87C0A0
    }

    public class IWrappedDictionary
    {
        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0x87C0A0
    }

    public class JavaScriptUtils : Object
    {
        public object SingleQuoteCharEscapeFlags;
        public object DoubleQuoteCharEscapeFlags;
        public object HtmlCharEscapeFlags;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x816EF30
        public void GetCharEscapeFlags(){} // RVA: 0x816FB10
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x6A47560
        public void WriteEscapedJavaScriptString(){} // RVA: 0x816FBE0
        public void ToEscapedJavaScriptString(){} // RVA: 0x8170340
    }

    public class JsonTokenUtils : Object
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x6A4B2A0
        public void IsStartToken(){} // RVA: 0x6A4B2B0
        public void IsPrimitiveToken(){} // RVA: 0x6A4B2C0
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x81705E0
        public void CreateParameterizedConstructor(){} // RVA: 0x8170640
        public void CreateMethodCall(){} // RVA: 0x87C540
        public void CreateDefaultConstructor(){} // RVA: 0x87C540
        public void CreateGet(){} // RVA: 0x87C540
        public void CreateSet(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x8170870
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x6A4B6B0
        public void IntToHex(){} // RVA: 0x6A4B810
        public void ApproxEquals(){} // RVA: 0x8170910
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void ValueEquals(){} // RVA: 0x81709E0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x8170CD0
        public void ByteArrayCompare(){} // RVA: 0x6A4C0B0
        public void FormatValueForPrint(){} // RVA: 0x8170E00
    }

    public class PropertyNameTable : Object
    {
        public object HashCodeRandomizer;
        public object _count;
        public object _entries;
        public object _mask;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8170F30
        public void .ctor(){} // RVA: 0x8170F70
        public void Get(){} // RVA: 0x8171010
        public void Add(){} // RVA: 0x8171210
        public void AddEntry(){} // RVA: 0x8171400
        public void Grow(){} // RVA: 0x8171720
        public void TextEquals(){} // RVA: 0x69C9DF0
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x87C540
        public void CreateSet(){} // RVA: 0x87C540
        public void CreateMethodCall(){} // RVA: 0x87C540
        public void CreateParameterizedConstructor(){} // RVA: 0x87C540
        public void CreateDefaultConstructor(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectionMember : Object
    {
        public object _memberType;
        public object _getter;
        public object _setter;

        // ── Methods ──
        public void get_MemberType(){} // RVA: 0xB5DBF0
        public void set_MemberType(){} // RVA: 0xB44D60
        public void get_Getter(){} // RVA: 0xB465B0
        public void set_Getter(){} // RVA: 0xBA9BA0
        public void set_Setter(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectionObject : Object
    {
        public object _creator;
        public object _members;

        // ── Methods ──
        public void get_Creator(){} // RVA: 0xB5DBF0
        public void set_Creator(){} // RVA: 0xB44D60
        public void get_Members(){} // RVA: 0xB465B0
        public void set_Members(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x81718C0
        public void GetValue(){} // RVA: 0x8171980
        public void GetType(){} // RVA: 0x8171A00
        public void Create(){} // RVA: 0x8171A70
    }

    public class ReflectionUtils : Object
    {
        public object EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8172580
        public void IsVirtual(){} // RVA: 0x8172640
        public void GetBaseDefinition(){} // RVA: 0x8172750
        public void IsPublic(){} // RVA: 0x8172830
        public void GetObjectType(){} // RVA: 0x6A4D470
        public void GetTypeName(){} // RVA: 0x8172910
        public void RemoveAssemblyDetails(){} // RVA: 0x8172B00
        public void HasDefaultConstructor(){} // RVA: 0x8172C50
        public void GetDefaultConstructor(){} // RVA: 0x8172DB0
        public void IsNullable(){} // RVA: 0x8172F50
        public void IsNullableType(){} // RVA: 0x8173030
        public void EnsureNotNullableType(){} // RVA: 0x8173170
        public void IsGenericDefinition(){} // RVA: 0x81731E0
        public void ImplementsGenericDefinition(){} // RVA: 0x81732C0
        public void InheritsGenericDefinition(){} // RVA: 0x8173600
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x8173810
        public void GetCollectionItemType(){} // RVA: 0x81739D0
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x8173D40
        public void GetMemberUnderlyingType(){} // RVA: 0x81741C0
        public void IsIndexedProperty(){} // RVA: 0x81745C0
        public void GetMemberValue(){} // RVA: 0x8174670
        public void SetMemberValue(){} // RVA: 0x81749D0
        public void CanReadMemberValue(){} // RVA: 0x8174C60
        public void CanSetMemberValue(){} // RVA: 0x8174DD0
        public void GetFieldsAndProperties(){} // RVA: 0x8174F90
        public void IsOverridenGenericMember(){} // RVA: 0x81758B0
        public void GetAttribute(){} // RVA: 0xA94080
        public void GetAttributes(){} // RVA: 0x8175AA0
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x8176040
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x8176330
        public void GetMemberInfoFromType(){} // RVA: 0x81763F0
        public void GetFields(){} // RVA: 0x8176840
        public void GetChildPrivateFields(){} // RVA: 0x8176990
        public void GetProperties(){} // RVA: 0x8176BA0
        public void RemoveFlag(){} // RVA: 0x6A51B90
        public void GetChildPrivateProperties(){} // RVA: 0x8176EF0
        public void GetDefaultValue(){} // RVA: 0x8177200
    }

    public class StringBuffer : ValueType
    {
        public object _buffer;
        public object _position;

        // ── Methods ──
        public void get_Position(){} // RVA: 0x14790
        public void set_Position(){} // RVA: 0x92DD0
        public void get_IsEmpty(){} // RVA: 0x88E70
        public void .ctor(){} // RVA: 0x853B0
        public void Append(){} // RVA: 0x9B18A0
        public void Clear(){} // RVA: 0x9B18B0
        public void EnsureSize(){} // RVA: 0x9B18C0
        public void ToString(){} // RVA: 0x8C6570
        public void get_InternalBuffer(){} // RVA: 0x77900
    }

    public class StringReference : ValueType
    {
        public object _chars;
        public object _startIndex;
        public object _length;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x8C6720
        public void get_Chars(){} // RVA: 0x77900
        public void get_StartIndex(){} // RVA: 0x14790
        public void get_Length(){} // RVA: 0x92DE0
        public void .ctor(){} // RVA: 0x426050
        public void ToString(){} // RVA: 0x8C6750
    }

    public class StringReferenceExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x8177F10
        public void StartsWith(){} // RVA: 0x6A53190
        public void EndsWith(){} // RVA: 0x6A53220
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x8178700
        public void CreateStringWriter(){} // RVA: 0x8178840
        public void ToCharAsUnicode(){} // RVA: 0x6A53D90
        public void ForgivingCaseSensitiveFind(){} // RVA: 0xA94080
        public void IsHighSurrogate(){} // RVA: 0x6A54500
        public void IsLowSurrogate(){} // RVA: 0x6A54550
        public void StartsWith(){} // RVA: 0x6A545F0
        public void EndsWith(){} // RVA: 0x6A54620
    }

    public class ThreadSafeStore`2 : Object
    {
        public object _lock;
        public object _store;
        public object _creator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Get(){} // RVA: 0xA94080
        public void AddValue(){} // RVA: 0xA94080
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void MemberType(){} // RVA: 0x6A548F0
        public void ContainsGenericParameters(){} // RVA: 0x6A54920
        public void IsInterface(){} // RVA: 0x6A54950
        public void IsGenericType(){} // RVA: 0x6A54970
        public void IsGenericTypeDefinition(){} // RVA: 0x6A549A0
        public void BaseType(){} // RVA: 0x6A549D0
        public void IsEnum(){} // RVA: 0x6A54A30
        public void IsClass(){} // RVA: 0x6A54A60
        public void IsSealed(){} // RVA: 0x6A54AC0
        public void IsAbstract(){} // RVA: 0x6A54AF0
        public void IsValueType(){} // RVA: 0x6A54B40
        public void AssignableToTypeName(){} // RVA: 0x8178B90
        public void ImplementInterface(){} // RVA: 0x8178BB0
    }

    public class TypeInformation : Object
    {
        public object _type;
        public object _typeCode;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB5DBF0
        public void set_Type(){} // RVA: 0xB44D60
        public void get_TypeCode(){} // RVA: 0xE62D00
        public void set_TypeCode(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x8178DB0
    }

}