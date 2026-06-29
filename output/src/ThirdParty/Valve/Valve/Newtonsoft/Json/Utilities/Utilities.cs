// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 31
// Methods: 268

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF309DF0
        public void Encode(){} // RVA: 0x7AF309F50
        public void Flush(){} // RVA: 0x7AF30A3A0
        public void WriteChars(){} // RVA: 0x7ADDA9240
    }

    public class BidirectionalDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DB70
        public void Set(){} // RVA: 0x7A8051B10
        public void TryGetByFirst(){} // RVA: 0x7A8051B10
        public void TryGetBySecond(){} // RVA: 0x7A8051B10
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7AF315A80
        public void ReturnBuffer(){} // RVA: 0x7AF315B00
        public void EnsureBufferSize(){} // RVA: 0x7AF315B60
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7A7E01A10
        public void AddRange(){} // RVA: 0x7A7E18AA0
        public void IsDictionaryType(){} // RVA: 0x7AF30A480
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7AF30A810
        public void IndexOf(){} // RVA: 0x7A7E06360
        public void Contains(){} // RVA: 0x7A8051B10
        public void IndexOfReference(){} // RVA: 0x7A8051B10
        public void GetDimensions(){} // RVA: 0x7AF30AAB0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7AF30AEA0
        public void JaggedArrayGetValue(){} // RVA: 0x7AF30B150
        public void ToMultidimensionalArray(){} // RVA: 0x7AF30B250
    }

    public class CollectionWrapper`1 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void Contains(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void Remove(){} // RVA: 0x7A8051B10
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IList.Add(){} // RVA: 0x7A7E01630
        public void System.Collections.IList.Contains(){} // RVA: 0x7A7E019D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7A7E01630
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7A7E189D0
        public void System.Collections.IList.Insert(){} // RVA: 0x7A7E19BE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A7E01900
        public void System.Collections.IList.Remove(){} // RVA: 0x7A7E18800
        public void System.Collections.IList.get_Item(){} // RVA: 0x7A7E00740
        public void System.Collections.IList.set_Item(){} // RVA: 0x7A7E19BE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void VerifyValueType(){} // RVA: 0x7A7E18830
        public void IsCompatibleObject(){} // RVA: 0x7A7E01A10
        public void get_UnderlyingCollection(){} // RVA: 0x7A7E00680
    }

    public class ConvertUtils : Object
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7AF30B4F0
        public void GetTypeInformation(){} // RVA: 0x7AF30B870
        public void IsConvertible(){} // RVA: 0x7AF30B920
        public void ParseTimeSpan(){} // RVA: 0x7AF30BA00
        public void CreateCastConverter(){} // RVA: 0x7AF30BAD0
        public void TryConvert(){} // RVA: 0x7AF30BDB0
        public void TryConvertInternal(){} // RVA: 0x7AF30BEA0
        public void ConvertOrCast(){} // RVA: 0x7AF30C960
        public void EnsureTypeAssignable(){} // RVA: 0x7AF30CB20
        public void GetConverter(){} // RVA: 0x7AF30CE60
        public void VersionTryParse(){} // RVA: 0x7AF30CEF0
        public void IsInteger(){} // RVA: 0x7AF30D080
        public void Int32TryParse(){} // RVA: 0x7ADDAEEF0
        public void Int64TryParse(){} // RVA: 0x7ADDAF090
        public void TryConvertGuid(){} // RVA: 0x7AF30D1A0
        public void HexTextToInt(){} // RVA: 0x7AF30D320
        public void HexCharToInt(){} // RVA: 0x7AF30D4C0
        public void .cctor(){} // RVA: 0x7AF30D5A0
    }

    public class DateTimeParser : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF30F8D0
        public void Parse(){} // RVA: 0x7A7F0E2D0
        public void ParseDate(){} // RVA: 0x7A7F0E2E0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7A7F0E2F0
        public void ParseTime(){} // RVA: 0x7A7F0E300
        public void ParseZone(){} // RVA: 0x7A7F0E310
        public void Parse4Digit(){} // RVA: 0x7A7E474D0
        public void Parse2Digit(){} // RVA: 0x7A7E474E0
        public void ParseChar(){} // RVA: 0x7A7E474F0
    }

    public class DateTimeUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF310750
        public void GetUtcOffset(){} // RVA: 0x7AF310910
        public void EnsureDateTime(){} // RVA: 0x7AF310950
        public void SwitchToLocalTime(){} // RVA: 0x7AF310D50
        public void SwitchToUtcTime(){} // RVA: 0x7AF310EE0
        public void ToUniversalTicks(){} // RVA: 0x7AF311030
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7AF311250
        public void UniversialTicksToJavaScriptTicks(){} // RVA: 0x7AF311320
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7AF3113A0
        public void TryParseDateTimeIso(){} // RVA: 0x7AF311430
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7AF311B20
        public void CreateDateTime(){} // RVA: 0x7AF311EA0
        public void TryParseDateTime(){} // RVA: 0x7AF3123C0
        public void TryParseDateTimeOffset(){} // RVA: 0x7AF312BA0
        public void TryParseMicrosoftDate(){} // RVA: 0x7AF3130A0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7AF3132D0
        public void TryParseDateTimeExact(){} // RVA: 0x7AF3134B0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7AF3135A0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7AF313780
        public void TryReadOffset(){} // RVA: 0x7AF313830
        public void WriteDateTimeString(){} // RVA: 0x7AF313CE0
        public void WriteDefaultIsoDate(){} // RVA: 0x7AF314120
        public void CopyIntToCharArray(){} // RVA: 0x7ADDB76C0
        public void WriteDateTimeOffset(){} // RVA: 0x7AF3146C0
        public void WriteDateTimeOffsetString(){} // RVA: 0x7AF3149B0
        public void GetDateValues(){} // RVA: 0x7AF314C20
    }

    public class DictionaryWrapper`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7A8051B10
        public void ContainsKey(){} // RVA: 0x7A8051B10
        public void get_Keys(){} // RVA: 0x7A7E00680
        public void Remove(){} // RVA: 0x7A7E18800
        public void TryGetValue(){} // RVA: 0x7A8051B10
        public void get_Values(){} // RVA: 0x7A7E00680
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void Contains(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7A7E18890
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7A7E00B20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7A7E18890
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7A7E019D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A7E01900
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7A7E00680
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void get_UnderlyingDictionary(){} // RVA: 0x7A7E00680
    }

    public class EnumUtils : Object
    {
        // ── Methods ──
        public void InitializeEnumType(){} // RVA: 0x7AF314E50
        public void GetValues(){} // RVA: 0x7AF3153D0
        public void .cctor(){} // RVA: 0x7AF315880
    }

    public class IWrappedCollection
    {
        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0x7A7E00680
    }

    public class IWrappedDictionary
    {
        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0x7A7E00680
    }

    public class JavaScriptUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF315C10
        public void GetCharEscapeFlags(){} // RVA: 0x7AF3167F0
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7ADDBFA00
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7AF3168C0
        public void ToEscapedJavaScriptString(){} // RVA: 0x7AF317020
    }

    public class JsonTokenUtils : Object
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x7ADDC3750
        public void IsStartToken(){} // RVA: 0x7ADDC3760
        public void IsPrimitiveToken(){} // RVA: 0x7ADDC3770
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AF3172C0
        public void CreateParameterizedConstructor(){} // RVA: 0x7AF317320
        public void CreateMethodCall(){} // RVA: 0x7A7E00B20
        public void CreateDefaultConstructor(){} // RVA: 0x7A7E00B20
        public void CreateGet(){} // RVA: 0x7A7E00B20
        public void CreateSet(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF317550
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7ADDC3B60
        public void IntToHex(){} // RVA: 0x7ADDC3CC0
        public void ApproxEquals(){} // RVA: 0x7AF3175F0
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void ValueEquals(){} // RVA: 0x7AF3176C0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7AF3179D0
        public void ByteArrayCompare(){} // RVA: 0x7ADDC45B0
        public void FormatValueForPrint(){} // RVA: 0x7AF317B00
    }

    public class PropertyNameTable : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF317C60
        public void .ctor(){} // RVA: 0x7AF317CA0
        public void Get(){} // RVA: 0x7AF317D40
        public void Add(){} // RVA: 0x7AF317F50
        public void AddEntry(){} // RVA: 0x7AF318150
        public void Grow(){} // RVA: 0x7AF318470
        public void TextEquals(){} // RVA: 0x7ADD41050
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7A7E00B20
        public void CreateSet(){} // RVA: 0x7A7E00B20
        public void CreateMethodCall(){} // RVA: 0x7A7E00B20
        public void CreateParameterizedConstructor(){} // RVA: 0x7A7E00B20
        public void CreateDefaultConstructor(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReflectionMember : Object
    {
        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x7A80F2570
        public void set_MemberType(){} // RVA: 0x7A80D8E20
        public void get_Getter(){} // RVA: 0x7A80DA7B0
        public void set_Getter(){} // RVA: 0x7A813E420
        public void set_Setter(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReflectionObject : Object
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7A80F2570
        public void set_Creator(){} // RVA: 0x7A80D8E20
        public void get_Members(){} // RVA: 0x7A80DA7B0
        public void set_Members(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF318610
        public void GetValue(){} // RVA: 0x7AF3186D0
        public void GetType(){} // RVA: 0x7AF318750
        public void Create(){} // RVA: 0x7AF3187C0
    }

    public class ReflectionUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF3192F0
        public void IsVirtual(){} // RVA: 0x7AF3193C0
        public void GetBaseDefinition(){} // RVA: 0x7AF3194D0
        public void IsPublic(){} // RVA: 0x7AF3195B0
        public void GetObjectType(){} // RVA: 0x7ADDC59B0
        public void GetTypeName(){} // RVA: 0x7AF319690
        public void RemoveAssemblyDetails(){} // RVA: 0x7AF319880
        public void HasDefaultConstructor(){} // RVA: 0x7AF3199D0
        public void GetDefaultConstructor(){} // RVA: 0x7AF319B30
        public void IsNullable(){} // RVA: 0x7AF319CD0
        public void IsNullableType(){} // RVA: 0x7AF319DB0
        public void EnsureNotNullableType(){} // RVA: 0x7AF319EC0
        public void IsGenericDefinition(){} // RVA: 0x7AF319F30
        public void ImplementsGenericDefinition(){} // RVA: 0x7AF31A010
        public void InheritsGenericDefinition(){} // RVA: 0x7AF31A350
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7AF31A560
        public void GetCollectionItemType(){} // RVA: 0x7AF31A720
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7AF31AA60
        public void GetMemberUnderlyingType(){} // RVA: 0x7AF31AEF0
        public void IsIndexedProperty(){} // RVA: 0x7AF31B2F0
        public void GetMemberValue(){} // RVA: 0x7AF31B3A0
        public void SetMemberValue(){} // RVA: 0x7AF31B700
        public void CanReadMemberValue(){} // RVA: 0x7AF31B990
        public void CanSetMemberValue(){} // RVA: 0x7AF31BB00
        public void GetFieldsAndProperties(){} // RVA: 0x7AF31BCC0
        public void IsOverridenGenericMember(){} // RVA: 0x7AF31C5E0
        public void GetAttribute(){} // RVA: 0x7A8051B10
        public void GetAttributes(){} // RVA: 0x7AF31C7D0
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7AF31CD80
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7AF31D070
        public void GetMemberInfoFromType(){} // RVA: 0x7AF31D130
        public void GetFields(){} // RVA: 0x7AF31D580
        public void GetChildPrivateFields(){} // RVA: 0x7AF31D6D0
        public void GetProperties(){} // RVA: 0x7AF31D8E0
        public void RemoveFlag(){} // RVA: 0x7ADDCA180
        public void GetChildPrivateProperties(){} // RVA: 0x7AF31DC30
        public void GetDefaultValue(){} // RVA: 0x7AF31DF40
    }

    public class StringBuffer : ValueType
    {
        // ── Methods ──
        public void get_Position(){} // RVA: 0x7A75FEFA0
        public void set_Position(){} // RVA: 0x7A767FBC0
        public void get_IsEmpty(){} // RVA: 0x7A7673DE0
        public void .ctor(){} // RVA: 0x7A7670310
        public void Append(){} // RVA: 0x7A7F0E4A0
        public void Clear(){} // RVA: 0x7A7F0E4B0
        public void EnsureSize(){} // RVA: 0x7A7F0E4C0
        public void ToString(){} // RVA: 0x7A7E47FB0
        public void get_InternalBuffer(){} // RVA: 0x7A765F710
    }

    public class StringReference : ValueType
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7A7E48160
        public void get_Chars(){} // RVA: 0x7A765F710
        public void get_StartIndex(){} // RVA: 0x7A75FEFA0
        public void get_Length(){} // RVA: 0x7A767FBD0
        public void .ctor(){} // RVA: 0x7A79C13D0
        public void ToString(){} // RVA: 0x7A7E48190
    }

    public class StringReferenceExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7AF31ECA0
        public void StartsWith(){} // RVA: 0x7ADDCB850
        public void EndsWith(){} // RVA: 0x7ADDCB8E0
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x7AF31F490
        public void CreateStringWriter(){} // RVA: 0x7AF31F5D0
        public void ToCharAsUnicode(){} // RVA: 0x7ADDCC470
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7A8051B10
        public void IsHighSurrogate(){} // RVA: 0x7AF31F6E0
        public void IsLowSurrogate(){} // RVA: 0x7AF31F750
        public void StartsWith(){} // RVA: 0x7ADDCCD50
        public void EndsWith(){} // RVA: 0x7ADDCCD80
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Get(){} // RVA: 0x7A8051B10
        public void AddValue(){} // RVA: 0x7A8051B10
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void MemberType(){} // RVA: 0x7ADDCD070
        public void ContainsGenericParameters(){} // RVA: 0x7ADDCD0A0
        public void IsInterface(){} // RVA: 0x7ADDCD0D0
        public void IsGenericType(){} // RVA: 0x7ADDCD0F0
        public void IsGenericTypeDefinition(){} // RVA: 0x7ADDCD120
        public void BaseType(){} // RVA: 0x7ADDCD150
        public void IsEnum(){} // RVA: 0x7ADDCD1B0
        public void IsClass(){} // RVA: 0x7ADDCD1E0
        public void IsSealed(){} // RVA: 0x7ADDCD240
        public void IsAbstract(){} // RVA: 0x7ADDCD270
        public void IsValueType(){} // RVA: 0x7ADDCD2C0
        public void AssignableToTypeName(){} // RVA: 0x7AF31FA00
        public void ImplementInterface(){} // RVA: 0x7AF31FA20
    }

    public class TypeInformation : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A80F2570
        public void set_Type(){} // RVA: 0x7A80D8E20
        public void get_TypeCode(){} // RVA: 0x7A83782A0
        public void set_TypeCode(){} // RVA: 0x7A84385B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7AF31FC20
    }

}