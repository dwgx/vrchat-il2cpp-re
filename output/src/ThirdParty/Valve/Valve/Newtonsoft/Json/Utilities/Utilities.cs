// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 31
// Methods: 299

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8806BAD0
        public void Encode(){} // RVA: 0x7FFE8806BC30
        public void Flush(){} // RVA: 0x7FFE8806C060
        public void WriteChars(){} // RVA: 0x7FFE86AFDA00
    }

    public class BidirectionalDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50FC0 | overloaded x2
        public void Set(){} // RVA: 0x7FFE810A1420
        public void TryGetByFirst(){} // RVA: 0x7FFE810A1420
        public void TryGetBySecond(){} // RVA: 0x7FFE810A1420
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7FFE88077640
        public void ReturnBuffer(){} // RVA: 0x7FFE880776C0
        public void EnsureBufferSize(){} // RVA: 0x7FFE88077720
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFE80E2F230
        public void AddRange(){} // RVA: 0x7FFE80E462E0 | overloaded x2
        public void IsDictionaryType(){} // RVA: 0x7FFE8806C140
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFE8806C4D0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE80E33B80
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
        public void GetDimensions(){} // RVA: 0x7FFE8806C770
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFE8806CB60
        public void JaggedArrayGetValue(){} // RVA: 0x7FFE8806CE00
        public void ToMultidimensionalArray(){} // RVA: 0x7FFE8806CF00
    }

    public class CollectionWrapper`1 : Object
    {
        public System.Collections.IList _list;
        public System.Collections.Generic.ICollection`1<T> _genericCollection;
        public object _syncRoot;
        public object field_3; // 0x5D
        public object field_4; // 0x5E
        public object field_5; // 0x5F
        public object field_6; // 0x60

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void VerifyValueType(){} // RVA: 0x7FFE80E46070
        public void IsCompatibleObject(){} // RVA: 0x7FFE80E2F230
        public void get_UnderlyingCollection(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ConvertUtils : Object
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFE8806D1A0 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x7FFE8806D520
        public void IsConvertible(){} // RVA: 0x7FFE8806D5D0
        public void ParseTimeSpan(){} // RVA: 0x7FFE8806D6B0
        public void CreateCastConverter(){} // RVA: 0x7FFE8806D780
        public void TryConvert(){} // RVA: 0x7FFE8806DA50
        public void TryConvertInternal(){} // RVA: 0x7FFE8806DB40
        public void ConvertOrCast(){} // RVA: 0x7FFE8806E600
        public void EnsureTypeAssignable(){} // RVA: 0x7FFE8806E7C0
        public void GetConverter(){} // RVA: 0x7FFE8806EB00
        public void VersionTryParse(){} // RVA: 0x7FFE8806EB90
        public void IsInteger(){} // RVA: 0x7FFE8806ED20
        public void Int32TryParse(){} // RVA: 0x7FFE86B03670
        public void Int64TryParse(){} // RVA: 0x7FFE86B037D0
        public void TryConvertGuid(){} // RVA: 0x7FFE8806EE40
        public void HexTextToInt(){} // RVA: 0x7FFE8806EFC0
        public void HexCharToInt(){} // RVA: 0x7FFE8806F130
        public void .cctor(){} // RVA: 0x7FFE8806F210
    }

    public class DateTimeParser : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88071540
        public void Parse(){} // RVA: 0x7FFE880718D0
        public void ParseDate(){} // RVA: 0x7FFE88071A30
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7FFE88071CF0
        public void ParseTime(){} // RVA: 0x7FFE88071D80
        public void ParseZone(){} // RVA: 0x7FFE88072140
        public void Parse4Digit(){} // RVA: 0x7FFE86B07910
        public void Parse2Digit(){} // RVA: 0x7FFE86B079F0
        public void ParseChar(){} // RVA: 0x7FFE86B07A60
    }

    public class DateTimeUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88072370
        public void GetUtcOffset(){} // RVA: 0x7FFE88072530
        public void EnsureDateTime(){} // RVA: 0x7FFE88072570
        public void SwitchToLocalTime(){} // RVA: 0x7FFE88072970
        public void SwitchToUtcTime(){} // RVA: 0x7FFE88072B00
        public void ToUniversalTicks(){} // RVA: 0x7FFE88072C50
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7FFE88072E70
        public void UniversialTicksToJavaScriptTicks(){} // RVA: 0x7FFE88072F40
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7FFE88072FC0
        public void TryParseDateTimeIso(){} // RVA: 0x7FFE88073050
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7FFE88073740
        public void CreateDateTime(){} // RVA: 0x7FFE88073AC0
        public void TryParseDateTime(){} // RVA: 0x7FFE88073FD0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFE880747A0 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7FFE88074CA0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7FFE88074EC0
        public void TryParseDateTimeExact(){} // RVA: 0x7FFE880750A0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7FFE88075190
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7FFE88075370
        public void TryReadOffset(){} // RVA: 0x7FFE88075420
        public void WriteDateTimeString(){} // RVA: 0x7FFE88075920 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7FFE88075D60
        public void CopyIntToCharArray(){} // RVA: 0x7FFE86B0BD10
        public void WriteDateTimeOffset(){} // RVA: 0x7FFE880762C0
        public void WriteDateTimeOffsetString(){} // RVA: 0x7FFE88076580
        public void GetDateValues(){} // RVA: 0x7FFE880767F0
    }

    public class DictionaryWrapper`2 : Object
    {
        public System.Collections.IDictionary _dictionary;
        public System.Collections.Generic.IDictionary`2<U,T> _genericDictionary;
        public object _syncRoot;
        public object field_3; // 0x69
        public object field_4; // 0x6A
        public object field_5; // 0x6B
        public object field_6; // 0x6C
        public object field_7; // 0x6D
        public object field_8; // 0x6E
        public object field_9; // 0x6F
        public object field_10; // 0x70
        public object field_11; // 0x71

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFE80E2E2E0
    }

    public class EnumUtils : Object
    {
        // ── Methods ──
        public void InitializeEnumType(){} // RVA: 0x7FFE88076A10
        public void GetValues(){} // RVA: 0x7FFE88076F80
        public void .cctor(){} // RVA: 0x7FFE88077440
    }

    public class IWrappedCollection
    {
        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IWrappedDictionary
    {
        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFE80E2E2E0
    }

    public class JavaScriptUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE880777D0
        public void GetCharEscapeFlags(){} // RVA: 0x7FFE88078390
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7FFE86B13FA0
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7FFE88078460
        public void ToEscapedJavaScriptString(){} // RVA: 0x7FFE88078BD0
    }

    public class JsonTokenUtils : Object
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x7FFE86B17CA0
        public void IsStartToken(){} // RVA: 0x7FFE86B17CB0
        public void IsPrimitiveToken(){} // RVA: 0x7FFE86B17CC0
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        public Valve.Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE88078E70
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFE88078ED0
        public void CreateMethodCall(){} // RVA: 0x7FFE80E2E390
        public void CreateDefaultConstructor(){} // RVA: 0x7FFE80E2E390
        public void CreateGet(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE88079100
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7FFE86B180B0
        public void IntToHex(){} // RVA: 0x7FFE86B18210
        public void ApproxEquals(){} // RVA: 0x7FFE880791A0
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void ValueEquals(){} // RVA: 0x7FFE88079270
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFE88079580
        public void ByteArrayCompare(){} // RVA: 0x7FFE86B18B00
        public void FormatValueForPrint(){} // RVA: 0x7FFE880796B0
    }

    public class PropertyNameTable : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88079810
        public void .ctor(){} // RVA: 0x7FFE88079850
        public void Get(){} // RVA: 0x7FFE880798F0
        public void Add(){} // RVA: 0x7FFE88079AE0
        public void AddEntry(){} // RVA: 0x7FFE88079CE0
        public void Grow(){} // RVA: 0x7FFE8807A000
        public void TextEquals(){} // RVA: 0x7FFE86A93670
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7FFE80E2E390 | overloaded x3
        public void CreateSet(){} // RVA: 0x7FFE80E2E390 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0x7FFE80E2E390
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFE80E2E390
        public void CreateDefaultConstructor(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReflectionMember : Object
    {
        public System.Type _memberType; // 0x10
        public System.Func`2<object,object> _getter; // 0x18
        public System.Action`2<object,object> _setter; // 0x20

        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x7FFE81116380
        public void set_MemberType(){} // RVA: 0x7FFE810FCE30
        public void get_Getter(){} // RVA: 0x7FFE810FE7C0
        public void set_Getter(){} // RVA: 0x7FFE81161E80
        public void set_Setter(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReflectionObject : Object
    {
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _creator; // 0x10
        public System.Collections.Generic.IDictionary`2<string,Valve.Newtonsoft.Json.Utilities.ReflectionMember> _members; // 0x18

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFE81116380
        public void set_Creator(){} // RVA: 0x7FFE810FCE30
        public void get_Members(){} // RVA: 0x7FFE810FE7C0
        public void set_Members(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8807A190
        public void GetValue(){} // RVA: 0x7FFE8807A250
        public void GetType(){} // RVA: 0x7FFE8807A2D0
        public void Create(){} // RVA: 0x7FFE8807A340 | overloaded x2
    }

    public class ReflectionUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8807AE50
        public void IsVirtual(){} // RVA: 0x7FFE8807AF20
        public void GetBaseDefinition(){} // RVA: 0x7FFE8807B030
        public void IsPublic(){} // RVA: 0x7FFE8807B110
        public void GetObjectType(){} // RVA: 0x7FFE86B19EF0
        public void GetTypeName(){} // RVA: 0x7FFE8807B1F0
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFE8807B3E0
        public void HasDefaultConstructor(){} // RVA: 0x7FFE8807B530
        public void GetDefaultConstructor(){} // RVA: 0x7FFE8807B690 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFE8807B830
        public void IsNullableType(){} // RVA: 0x7FFE8807B910
        public void EnsureNotNullableType(){} // RVA: 0x7FFE8807BA20
        public void IsGenericDefinition(){} // RVA: 0x7FFE8807BA90
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFE8807BB70 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFE8807BEA0 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFE8807C0B0
        public void GetCollectionItemType(){} // RVA: 0x7FFE8807C270
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFE8807C5B0
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFE8807CA40
        public void IsIndexedProperty(){} // RVA: 0x7FFE8807CE40 | overloaded x2
        public void GetMemberValue(){} // RVA: 0x7FFE8807CEF0
        public void SetMemberValue(){} // RVA: 0x7FFE8807D250
        public void CanReadMemberValue(){} // RVA: 0x7FFE8807D4E0
        public void CanSetMemberValue(){} // RVA: 0x7FFE8807D650
        public void GetFieldsAndProperties(){} // RVA: 0x7FFE8807D810
        public void IsOverridenGenericMember(){} // RVA: 0x7FFE8807E120
        public void GetAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFE8807E310 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFE8807E8C0
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFE8807EBB0
        public void GetMemberInfoFromType(){} // RVA: 0x7FFE8807EC70
        public void GetFields(){} // RVA: 0x7FFE8807F0A0
        public void GetChildPrivateFields(){} // RVA: 0x7FFE8807F1F0
        public void GetProperties(){} // RVA: 0x7FFE8807F400
        public void RemoveFlag(){} // RVA: 0x7FFE86B1E670
        public void GetChildPrivateProperties(){} // RVA: 0x7FFE8807F750
        public void GetDefaultValue(){} // RVA: 0x7FFE8807FA40
    }

    public class StringBuffer : ValueType
    {
        public char[] _buffer; // 0x10
        public int _position; // 0x18
        public char[] _chars; // 0x10

        // ── Methods ──
        public void get_Position(){} // RVA: 0x7FFE82C33000
        public void set_Position(){} // RVA: 0x7FFE82C33010
        public void get_IsEmpty(){} // RVA: 0x7FFE82AB4690
        public void .ctor(){} // RVA: 0x7FFE82A4F890 | overloaded x2
        public void Append(){} // RVA: 0x7FFE88080460 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE880804E0
        public void EnsureSize(){} // RVA: 0x7FFE880805B0
        public void ToString(){} // RVA: 0x7FFE86B1FC20 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x7FFE8284EF60
    }

    public class StringReference : ValueType
    {
        public char[] _chars; // 0x10
        public int _startIndex; // 0x18
        public int _length; // 0x1C
        public object field_3; // 0x4B

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE86B1FC30
        public void get_Chars(){} // RVA: 0x7FFE8284EF60
        public void get_StartIndex(){} // RVA: 0x7FFE82C33000
        public void get_Length(){} // RVA: 0x7FFE82C33020
        public void .ctor(){} // RVA: 0x7FFE84896780
        public void ToString(){} // RVA: 0x7FFE86B1FC60
    }

    public class StringReferenceExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE880807A0
        public void StartsWith(){} // RVA: 0x7FFE86B1FD10
        public void EndsWith(){} // RVA: 0x7FFE86B1FDA0
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x7FFE88080F90 | overloaded x5
        public void CreateStringWriter(){} // RVA: 0x7FFE880810D0
        public void ToCharAsUnicode(){} // RVA: 0x7FFE86B20900
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFE810A1420
        public void IsHighSurrogate(){} // RVA: 0x7FFE880811E0
        public void IsLowSurrogate(){} // RVA: 0x7FFE88081250
        public void StartsWith(){} // RVA: 0x7FFE86B211F0
        public void EndsWith(){} // RVA: 0x7FFE86B21220
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Get(){} // RVA: 0x7FFE810A1420
        public void AddValue(){} // RVA: 0x7FFE810A1420
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void MemberType(){} // RVA: 0x7FFE86B21510
        public void ContainsGenericParameters(){} // RVA: 0x7FFE86B21540
        public void IsInterface(){} // RVA: 0x7FFE86B21570
        public void IsGenericType(){} // RVA: 0x7FFE86B21590
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFE86B215C0
        public void BaseType(){} // RVA: 0x7FFE86B215F0
        public void IsEnum(){} // RVA: 0x7FFE86B21650
        public void IsClass(){} // RVA: 0x7FFE86B21680
        public void IsSealed(){} // RVA: 0x7FFE86B216E0
        public void IsAbstract(){} // RVA: 0x7FFE86B21710
        public void IsValueType(){} // RVA: 0x7FFE86B21760
        public void AssignableToTypeName(){} // RVA: 0x7FFE880814F0 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7FFE88081510
    }

    public class TypeInformation : Object
    {
        public System.Type _type; // 0x10
        public 0x6663F0EC _typeCode; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void set_Type(){} // RVA: 0x7FFE810FCE30
        public void get_TypeCode(){} // RVA: 0x7FFE813DB630
        public void set_TypeCode(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7FFE88081700
    }

}