// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 31
// Methods: 299

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x752B940
        public void Encode(){} // RVA: 0x752BAA0
        public void Flush(){} // RVA: 0x752BED0
        public void WriteChars(){} // RVA: 0x5FBCC10
    }

    public class BidirectionalDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F9F0 | overloaded x2
        public void Set(){} // RVA: 0x283FA0
        public void TryGetByFirst(){} // RVA: 0x283FA0
        public void TryGetBySecond(){} // RVA: 0x283FA0
    }

    public class BufferUtils
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x75374B0
        public void ReturnBuffer(){} // RVA: 0x7537530
        public void EnsureBufferSize(){} // RVA: 0x7537590
    }

    public class CollectionUtils
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0xDCC0
        public void AddRange(){} // RVA: 0x24D50 | overloaded x2
        public void IsDictionaryType(){} // RVA: 0x752BFB0
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x752C340 | overloaded x2
        public void IndexOf(){} // RVA: 0x12610
        public void Contains(){} // RVA: 0x283FA0
        public void IndexOfReference(){} // RVA: 0x283FA0
        public void GetDimensions(){} // RVA: 0x752C5E0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x752C9D0
        public void JaggedArrayGetValue(){} // RVA: 0x752CC70
        public void ToMultidimensionalArray(){} // RVA: 0x752CD70
    }

    public class CollectionWrapper`1
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Remove(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void VerifyValueType(){} // RVA: 0x24AE0
        public void IsCompatibleObject(){} // RVA: 0xDCC0
        public void get_UnderlyingCollection(){} // RVA: 0xCD60
    }

    public class ConvertUtils
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x752D010 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x752D390
        public void IsConvertible(){} // RVA: 0x752D440
        public void ParseTimeSpan(){} // RVA: 0x752D520
        public void CreateCastConverter(){} // RVA: 0x752D5F0
        public void TryConvert(){} // RVA: 0x752D8C0
        public void TryConvertInternal(){} // RVA: 0x752D9B0
        public void ConvertOrCast(){} // RVA: 0x752E470
        public void EnsureTypeAssignable(){} // RVA: 0x752E630
        public void GetConverter(){} // RVA: 0x752E970
        public void VersionTryParse(){} // RVA: 0x752EA00
        public void IsInteger(){} // RVA: 0x752EB90
        public void Int32TryParse(){} // RVA: 0x5FC2880
        public void Int64TryParse(){} // RVA: 0x5FC29E0
        public void TryConvertGuid(){} // RVA: 0x752ECB0
        public void HexTextToInt(){} // RVA: 0x752EE30
        public void HexCharToInt(){} // RVA: 0x752EFA0
        public void .cctor(){} // RVA: 0x752F080
    }

    public class DateTimeParser
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x75313B0
        public void Parse(){} // RVA: 0x7531740
        public void ParseDate(){} // RVA: 0x75318A0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7531B60
        public void ParseTime(){} // RVA: 0x7531BF0
        public void ParseZone(){} // RVA: 0x7531FB0
        public void Parse4Digit(){} // RVA: 0x5FC6B20
        public void Parse2Digit(){} // RVA: 0x5FC6C00
        public void ParseChar(){} // RVA: 0x5FC6C70
    }

    public class DateTimeUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x75321E0
        public void GetUtcOffset(){} // RVA: 0x75323A0
        public void EnsureDateTime(){} // RVA: 0x75323E0
        public void SwitchToLocalTime(){} // RVA: 0x75327E0
        public void SwitchToUtcTime(){} // RVA: 0x7532970
        public void ToUniversalTicks(){} // RVA: 0x7532AC0
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7532CE0
        public void UniversialTicksToJavaScriptTicks(){} // RVA: 0x7532DB0
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7532E30
        public void TryParseDateTimeIso(){} // RVA: 0x7532EC0
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x75335B0
        public void CreateDateTime(){} // RVA: 0x7533930
        public void TryParseDateTime(){} // RVA: 0x7533E40 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7534610 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7534B10
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7534D30
        public void TryParseDateTimeExact(){} // RVA: 0x7534F10
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7535000
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x75351E0
        public void TryReadOffset(){} // RVA: 0x7535290
        public void WriteDateTimeString(){} // RVA: 0x7535790 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7535BD0
        public void CopyIntToCharArray(){} // RVA: 0x5FCAF20
        public void WriteDateTimeOffset(){} // RVA: 0x7536130
        public void WriteDateTimeOffsetString(){} // RVA: 0x75363F0
        public void GetDateValues(){} // RVA: 0x7536660
    }

    public class DictionaryWrapper`2 : System.Collections.Generic
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x283FA0 | overloaded x2
        public void ContainsKey(){} // RVA: 0x283FA0
        public void get_Keys(){} // RVA: 0xCD60
        public void Remove(){} // RVA: 0x24B10 | overloaded x3
        public void TryGetValue(){} // RVA: 0x283FA0
        public void get_Values(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void get_UnderlyingDictionary(){} // RVA: 0xCD60
    }

    public class EnumUtils
    {
        // ── Methods ──
        public void InitializeEnumType(){} // RVA: 0x7536880
        public void GetValues(){} // RVA: 0x7536DF0
        public void .cctor(){} // RVA: 0x75372B0
    }

    public class IWrappedCollection
    {
        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0xCD60
    }

    public class IWrappedDictionary
    {
        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0xCD60
    }

    public class JavaScriptUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7537640
        public void GetCharEscapeFlags(){} // RVA: 0x7538200
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x5FD31B0
        public void WriteEscapedJavaScriptString(){} // RVA: 0x75382D0
        public void ToEscapedJavaScriptString(){} // RVA: 0x7538A40
    }

    public class JsonTokenUtils
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x5FD6EB0
        public void IsStartToken(){} // RVA: 0x5FD6EC0
        public void IsPrimitiveToken(){} // RVA: 0x5FD6ED0
    }

    public class LateBoundReflectionDelegateFactory
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7538CE0
        public void CreateParameterizedConstructor(){} // RVA: 0x7538D40
        public void CreateMethodCall(){} // RVA: 0xCE10
        public void CreateDefaultConstructor(){} // RVA: 0xCE10
        public void CreateGet(){} // RVA: 0xCE10 | overloaded x2
        public void CreateSet(){} // RVA: 0xCE10 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x7538F70
    }

    public class MathUtils
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x5FD72C0
        public void IntToHex(){} // RVA: 0x5FD7420
        public void ApproxEquals(){} // RVA: 0x7539010
    }

    public class MethodCall`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class MiscellaneousUtils
    {
        // ── Methods ──
        public void ValueEquals(){} // RVA: 0x75390E0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x75393F0
        public void ByteArrayCompare(){} // RVA: 0x5FD7D10
        public void FormatValueForPrint(){} // RVA: 0x7539520
    }

    public class PropertyNameTable
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7539680
        public void .ctor(){} // RVA: 0x75396C0
        public void Get(){} // RVA: 0x7539760
        public void Add(){} // RVA: 0x7539950
        public void AddEntry(){} // RVA: 0x7539B50
        public void Grow(){} // RVA: 0x7539E70
        public void TextEquals(){} // RVA: 0x5F52850
    }

    public class ReflectionDelegateFactory
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0xCE10 | overloaded x3
        public void CreateSet(){} // RVA: 0xCE10 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0xCE10
        public void CreateParameterizedConstructor(){} // RVA: 0xCE10
        public void CreateDefaultConstructor(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReflectionMember
    {
        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x2F8380
        public void set_MemberType(){} // RVA: 0x2DEE30
        public void get_Getter(){} // RVA: 0x2E07C0
        public void set_Getter(){} // RVA: 0x343E80
        public void set_Setter(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReflectionObject
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x2F8380
        public void set_Creator(){} // RVA: 0x2DEE30
        public void get_Members(){} // RVA: 0x2E07C0
        public void set_Members(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x753A000
        public void GetValue(){} // RVA: 0x753A0C0
        public void GetType(){} // RVA: 0x753A140
        public void Create(){} // RVA: 0x753A1B0 | overloaded x2
    }

    public class ReflectionUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x753ACC0
        public void IsVirtual(){} // RVA: 0x753AD90
        public void GetBaseDefinition(){} // RVA: 0x753AEA0
        public void IsPublic(){} // RVA: 0x753AF80
        public void GetObjectType(){} // RVA: 0x5FD9100
        public void GetTypeName(){} // RVA: 0x753B060
        public void RemoveAssemblyDetails(){} // RVA: 0x753B250
        public void HasDefaultConstructor(){} // RVA: 0x753B3A0
        public void GetDefaultConstructor(){} // RVA: 0x753B500 | overloaded x2
        public void IsNullable(){} // RVA: 0x753B6A0
        public void IsNullableType(){} // RVA: 0x753B780
        public void EnsureNotNullableType(){} // RVA: 0x753B890
        public void IsGenericDefinition(){} // RVA: 0x753B900
        public void ImplementsGenericDefinition(){} // RVA: 0x753B9E0 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x753BD10 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x753BF20
        public void GetCollectionItemType(){} // RVA: 0x753C0E0
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x753C420
        public void GetMemberUnderlyingType(){} // RVA: 0x753C8B0
        public void IsIndexedProperty(){} // RVA: 0x753CCB0 | overloaded x2
        public void GetMemberValue(){} // RVA: 0x753CD60
        public void SetMemberValue(){} // RVA: 0x753D0C0
        public void CanReadMemberValue(){} // RVA: 0x753D350
        public void CanSetMemberValue(){} // RVA: 0x753D4C0
        public void GetFieldsAndProperties(){} // RVA: 0x753D680
        public void IsOverridenGenericMember(){} // RVA: 0x753DF90
        public void GetAttribute(){} // RVA: 0x283FA0 | overloaded x2
        public void GetAttributes(){} // RVA: 0x753E180 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x753E730
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x753EA20
        public void GetMemberInfoFromType(){} // RVA: 0x753EAE0
        public void GetFields(){} // RVA: 0x753EF10
        public void GetChildPrivateFields(){} // RVA: 0x753F060
        public void GetProperties(){} // RVA: 0x753F270
        public void RemoveFlag(){} // RVA: 0x5FDD880
        public void GetChildPrivateProperties(){} // RVA: 0x753F5C0
        public void GetDefaultValue(){} // RVA: 0x753F8B0
    }

    public class StringBuffer
    {
        public object Item;
        public object Chars;
        public object StartIndex;

        // ── Methods ──
        public void get_Position(){} // RVA: 0x1EA9890
        public void set_Position(){} // RVA: 0x1EA98A0
        public void get_IsEmpty(){} // RVA: 0x1D26810
        public void .ctor(){} // RVA: 0x1CBDE20 | overloaded x2
        public void Append(){} // RVA: 0x75402D0 | overloaded x2
        public void Clear(){} // RVA: 0x7540350
        public void EnsureSize(){} // RVA: 0x7540420
        public void ToString(){} // RVA: 0x5FDEE30 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x1AD4690
    }

    public class StringReference
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x5FDEE40
        public void get_Chars(){} // RVA: 0x1AD4690
        public void get_StartIndex(){} // RVA: 0x1EA9890
        public void get_Length(){} // RVA: 0x1EA98B0
        public void .ctor(){} // RVA: 0x3C214B0
        public void ToString(){} // RVA: 0x5FDEE70
    }

    public class StringReferenceExtensions
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7540610
        public void StartsWith(){} // RVA: 0x5FDEF20
        public void EndsWith(){} // RVA: 0x5FDEFB0
    }

    public class StringUtils
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x7540E00 | overloaded x5
        public void CreateStringWriter(){} // RVA: 0x7540F40
        public void ToCharAsUnicode(){} // RVA: 0x5FDFB10
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x283FA0
        public void IsHighSurrogate(){} // RVA: 0x7541050
        public void IsLowSurrogate(){} // RVA: 0x75410C0
        public void StartsWith(){} // RVA: 0x5FE0400
        public void EndsWith(){} // RVA: 0x5FE0430
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Get(){} // RVA: 0x283FA0
        public void AddValue(){} // RVA: 0x283FA0
    }

    public class TypeExtensions
    {
        // ── Methods ──
        public void MemberType(){} // RVA: 0x5FE0720
        public void ContainsGenericParameters(){} // RVA: 0x5FE0750
        public void IsInterface(){} // RVA: 0x5FE0780
        public void IsGenericType(){} // RVA: 0x5FE07A0
        public void IsGenericTypeDefinition(){} // RVA: 0x5FE07D0
        public void BaseType(){} // RVA: 0x5FE0800
        public void IsEnum(){} // RVA: 0x5FE0860
        public void IsClass(){} // RVA: 0x5FE0890
        public void IsSealed(){} // RVA: 0x5FE08F0
        public void IsAbstract(){} // RVA: 0x5FE0920
        public void IsValueType(){} // RVA: 0x5FE0970
        public void AssignableToTypeName(){} // RVA: 0x7541360 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7541380
    }

    public class TypeInformation
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x2F8380
        public void set_Type(){} // RVA: 0x2DEE30
        public void get_TypeCode(){} // RVA: 0x5BED50
        public void set_TypeCode(){} // RVA: 0x6374E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ValidationUtils
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7541570
    }

}