// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
// Classes: 31
// Methods: 299

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Utilities
{
    public class Base64Encoder : Object
    {
        public char[] _charsLine; // 0x10
        public System.IO.TextWriter _writer; // 0x18
        public byte[] _leftOverBytes; // 0x20
        public int _leftOverBytesCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CC32C0
        public void Encode(){} // RVA: 0x7FFAC9CC3420
        public void Flush(){} // RVA: 0x7FFAC9CC3850
        public void WriteChars(){} // RVA: 0x7FFAC8754290
    }

    public class BidirectionalDictionary`2 : Object
    {
        public System.Collections.Generic.IDictionary`2<U,T> _firstToSecond;
        public System.Collections.Generic.IDictionary`2<T,U> _secondToFirst;
        public string _duplicateFirstErrorMessage;
        public string _duplicateSecondErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetByFirst(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetBySecond(){} // RVA: 0x7FFAC2E8DC40
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7FFAC9CCEE30
        public void ReturnBuffer(){} // RVA: 0x7FFAC9CCEEB0
        public void EnsureBufferSize(){} // RVA: 0x7FFAC9CCEF10
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFAC2C59DE0
        public void AddRange(){} // RVA: 0x7FFAC2C70C80 | overloaded x2
        public void IsDictionaryType(){} // RVA: 0x7FFAC9CC3930
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFAC9CC3CC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC2C5E730
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
        public void GetDimensions(){} // RVA: 0x7FFAC9CC3F60
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFAC9CC4350
        public void JaggedArrayGetValue(){} // RVA: 0x7FFAC9CC45F0
        public void ToMultidimensionalArray(){} // RVA: 0x7FFAC9CC46F0
    }

    public class CollectionWrapper`1 : Object
    {
        public System.Collections.IList Count;
        public System.Collections.Generic.ICollection`1<T> IsReadOnly;
        public object System.Collections.IList.IsFixedSize;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void VerifyValueType(){} // RVA: 0x7FFAC2C70A10
        public void IsCompatibleObject(){} // RVA: 0x7FFAC2C59DE0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAC2C58E90
    }

    public class ConvertUtils : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B245720> TypeCodeMap;
        public Valve.Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes; // 0x8
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<TypeConvertKey,System.Func`2<object,object>> CastConverters; // 0x10

        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFAC9CC4990 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x7FFAC9CC4D10
        public void IsConvertible(){} // RVA: 0x7FFAC9CC4DC0
        public void ParseTimeSpan(){} // RVA: 0x7FFAC9CC4EA0
        public void CreateCastConverter(){} // RVA: 0x7FFAC9CC4F70
        public void TryConvert(){} // RVA: 0x7FFAC9CC5240
        public void TryConvertInternal(){} // RVA: 0x7FFAC9CC5330
        public void ConvertOrCast(){} // RVA: 0x7FFAC9CC5DF0
        public void EnsureTypeAssignable(){} // RVA: 0x7FFAC9CC5FB0
        public void GetConverter(){} // RVA: 0x7FFAC9CC62F0
        public void VersionTryParse(){} // RVA: 0x7FFAC9CC6380
        public void IsInteger(){} // RVA: 0x7FFAC9CC6510
        public void Int32TryParse(){} // RVA: 0x7FFAC8759F00
        public void Int64TryParse(){} // RVA: 0x7FFAC875A060
        public void TryConvertGuid(){} // RVA: 0x7FFAC9CC6630
        public void HexTextToInt(){} // RVA: 0x7FFAC9CC67B0
        public void HexCharToInt(){} // RVA: 0x7FFAC9CC6920
        public void .cctor(){} // RVA: 0x7FFAC9CC6A00
    }

    public class DateTimeParser : ValueType
    {
        public int Year; // 0x10
        public int Month; // 0x14
        public int Day; // 0x18
        public int Hour; // 0x1C
        public int Minute; // 0x20
        public int Second; // 0x24
        public int Fraction; // 0x28
        public int ZoneHour; // 0x2C
        public int ZoneMinute; // 0x30
        public 0x6B245988 Zone; // 0x34
        public char[] _text; // 0x38
        public int _end; // 0x40
        public int[] Power10;
        public int Lzyyyy; // 0x8
        public int Lzyyyy_; // 0xC
        public int Lzyyyy_MM; // 0x10
        public int Lzyyyy_MM_; // 0x14
        public int Lzyyyy_MM_dd; // 0x18
        public int Lzyyyy_MM_ddT; // 0x1C
        public int LzHH; // 0x20
        public int LzHH_; // 0x24
        public int LzHH_mm; // 0x28
        public int LzHH_mm_; // 0x2C
        public int LzHH_mm_ss; // 0x30
        public int Lz_; // 0x34
        public int Lz_zz; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9CC8D30
        public void Parse(){} // RVA: 0x7FFAC9CC90C0
        public void ParseDate(){} // RVA: 0x7FFAC9CC9220
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7FFAC9CC94E0
        public void ParseTime(){} // RVA: 0x7FFAC9CC9570
        public void ParseZone(){} // RVA: 0x7FFAC9CC9930
        public void Parse4Digit(){} // RVA: 0x7FFAC875E1A0
        public void Parse2Digit(){} // RVA: 0x7FFAC875E280
        public void ParseChar(){} // RVA: 0x7FFAC875E2F0
    }

    public class DateTimeUtils : Object
    {
        public long InitialJavaScriptDateTicks;
        public int[] DaysToMonth365; // 0x8
        public int[] DaysToMonth366; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9CC9B60
        public void GetUtcOffset(){} // RVA: 0x7FFAC9CC9D20
        public void EnsureDateTime(){} // RVA: 0x7FFAC9CC9D60
        public void SwitchToLocalTime(){} // RVA: 0x7FFAC9CCA160
        public void SwitchToUtcTime(){} // RVA: 0x7FFAC9CCA2F0
        public void ToUniversalTicks(){} // RVA: 0x7FFAC9CCA440
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7FFAC9CCA660
        public void UniversialTicksToJavaScriptTicks(){} // RVA: 0x7FFAC9CCA730
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7FFAC9CCA7B0
        public void TryParseDateTimeIso(){} // RVA: 0x7FFAC9CCA840
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7FFAC9CCAF30
        public void CreateDateTime(){} // RVA: 0x7FFAC9CCB2B0
        public void TryParseDateTime(){} // RVA: 0x7FFAC9CCB7C0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFAC9CCBF90 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7FFAC9CCC490
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7FFAC9CCC6B0
        public void TryParseDateTimeExact(){} // RVA: 0x7FFAC9CCC890
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7FFAC9CCC980
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7FFAC9CCCB60
        public void TryReadOffset(){} // RVA: 0x7FFAC9CCCC10
        public void WriteDateTimeString(){} // RVA: 0x7FFAC9CCD110 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7FFAC9CCD550
        public void CopyIntToCharArray(){} // RVA: 0x7FFAC87625A0
        public void WriteDateTimeOffset(){} // RVA: 0x7FFAC9CCDAB0
        public void WriteDateTimeOffsetString(){} // RVA: 0x7FFAC9CCDD70
        public void GetDateValues(){} // RVA: 0x7FFAC9CCDFE0
    }

    public class DictionaryWrapper`2 : Object
    {
        public System.Collections.IDictionary Keys;
        public System.Collections.Generic.IDictionary`2<U,T> Values;
        public object Item;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFAC2C58E90
    }

    public class EnumUtils : Object
    {
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Valve.Newtonsoft.Json.Utilities.BidirectionalDictionary`2<string,string>> EnumMemberNamesPerType;

        // ── Methods ──
        public void InitializeEnumType(){} // RVA: 0x7FFAC9CCE200
        public void GetValues(){} // RVA: 0x7FFAC9CCE770
        public void .cctor(){} // RVA: 0x7FFAC9CCEC30
    }

    public class IWrappedCollection
    {
        public object UnderlyingCollection;

        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAC2C58E90
    }

    public class IWrappedDictionary
    {
        public object UnderlyingDictionary;

        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFAC2C58E90
    }

    public class JavaScriptUtils : Object
    {
        public bool[] SingleQuoteCharEscapeFlags;
        public bool[] DoubleQuoteCharEscapeFlags; // 0x8
        public bool[] HtmlCharEscapeFlags; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9CCEFC0
        public void GetCharEscapeFlags(){} // RVA: 0x7FFAC9CCFB80
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7FFAC876A830
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7FFAC9CCFC50
        public void ToEscapedJavaScriptString(){} // RVA: 0x7FFAC9CD03C0
    }

    public class JsonTokenUtils : Object
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x7FFAC876E530
        public void IsStartToken(){} // RVA: 0x7FFAC876E540
        public void IsPrimitiveToken(){} // RVA: 0x7FFAC876E550
    }

    public class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
    {
        public Valve.Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC9CD0660
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFAC9CD06C0
        public void CreateMethodCall(){} // RVA: 0x7FFAC2C58F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFAC2C58F40
        public void CreateGet(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9CD08F0
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7FFAC876E940
        public void IntToHex(){} // RVA: 0x7FFAC876EAA0
        public void ApproxEquals(){} // RVA: 0x7FFAC9CD0990
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void ValueEquals(){} // RVA: 0x7FFAC9CD0A60
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAC9CD0D70
        public void ByteArrayCompare(){} // RVA: 0x7FFAC876F390
        public void FormatValueForPrint(){} // RVA: 0x7FFAC9CD0EA0
    }

    public class PropertyNameTable : Object
    {
        public int HashCodeRandomizer;
        public int _count; // 0x10
        public Entry[] _entries; // 0x18
        public int _mask; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9CD1000
        public void .ctor(){} // RVA: 0x7FFAC9CD1040
        public void Get(){} // RVA: 0x7FFAC9CD10E0
        public void Add(){} // RVA: 0x7FFAC9CD12D0
        public void AddEntry(){} // RVA: 0x7FFAC9CD14D0
        public void Grow(){} // RVA: 0x7FFAC9CD17F0
        public void TextEquals(){} // RVA: 0x7FFAC86E9EC0
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7FFAC2C58F40 | overloaded x3
        public void CreateSet(){} // RVA: 0x7FFAC2C58F40 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0x7FFAC2C58F40
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFAC2C58F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectionMember : Object
    {
        public System.Type MemberType; // 0x10
        public System.Func`2<object,object> Getter; // 0x18
        public System.Action`2<object,object> Setter; // 0x20

        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x7FFAC2F3C380
        public void set_MemberType(){} // RVA: 0x7FFAC2F22E30
        public void get_Getter(){} // RVA: 0x7FFAC2F247C0
        public void set_Getter(){} // RVA: 0x7FFAC2F87E80
        public void set_Setter(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectionObject : Object
    {
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> Creator; // 0x10
        public System.Collections.Generic.IDictionary`2<string,Valve.Newtonsoft.Json.Utilities.ReflectionMember> Members; // 0x18

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFAC2F3C380
        public void set_Creator(){} // RVA: 0x7FFAC2F22E30
        public void get_Members(){} // RVA: 0x7FFAC2F247C0
        public void set_Members(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9CD1980
        public void GetValue(){} // RVA: 0x7FFAC9CD1A40
        public void GetType(){} // RVA: 0x7FFAC9CD1AC0
        public void Create(){} // RVA: 0x7FFAC9CD1B30 | overloaded x2
    }

    public class ReflectionUtils : Object
    {
        public System.Type[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9CD2640
        public void IsVirtual(){} // RVA: 0x7FFAC9CD2710
        public void GetBaseDefinition(){} // RVA: 0x7FFAC9CD2820
        public void IsPublic(){} // RVA: 0x7FFAC9CD2900
        public void GetObjectType(){} // RVA: 0x7FFAC8770780
        public void GetTypeName(){} // RVA: 0x7FFAC9CD29E0
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFAC9CD2BD0
        public void HasDefaultConstructor(){} // RVA: 0x7FFAC9CD2D20
        public void GetDefaultConstructor(){} // RVA: 0x7FFAC9CD2E80 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFAC9CD3020
        public void IsNullableType(){} // RVA: 0x7FFAC9CD3100
        public void EnsureNotNullableType(){} // RVA: 0x7FFAC9CD3210
        public void IsGenericDefinition(){} // RVA: 0x7FFAC9CD3280
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFAC9CD3360 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFAC9CD3690 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFAC9CD38A0
        public void GetCollectionItemType(){} // RVA: 0x7FFAC9CD3A60
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFAC9CD3DA0
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFAC9CD4230
        public void IsIndexedProperty(){} // RVA: 0x7FFAC9CD4630 | overloaded x2
        public void GetMemberValue(){} // RVA: 0x7FFAC9CD46E0
        public void SetMemberValue(){} // RVA: 0x7FFAC9CD4A40
        public void CanReadMemberValue(){} // RVA: 0x7FFAC9CD4CD0
        public void CanSetMemberValue(){} // RVA: 0x7FFAC9CD4E40
        public void GetFieldsAndProperties(){} // RVA: 0x7FFAC9CD5000
        public void IsOverridenGenericMember(){} // RVA: 0x7FFAC9CD5910
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFAC9CD5B00 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFAC9CD60B0
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFAC9CD63A0
        public void GetMemberInfoFromType(){} // RVA: 0x7FFAC9CD6460
        public void GetFields(){} // RVA: 0x7FFAC9CD6890
        public void GetChildPrivateFields(){} // RVA: 0x7FFAC9CD69E0
        public void GetProperties(){} // RVA: 0x7FFAC9CD6BF0
        public void RemoveFlag(){} // RVA: 0x7FFAC8774F00
        public void GetChildPrivateProperties(){} // RVA: 0x7FFAC9CD6F40
        public void GetDefaultValue(){} // RVA: 0x7FFAC9CD7230
    }

    public class StringBuffer : ValueType
    {
        public char[] Position; // 0x10
        public int IsEmpty; // 0x18

        // ── Methods ──
        public void get_Position(){} // RVA: 0x7FFAC49C7500
        public void set_Position(){} // RVA: 0x7FFAC49C7510
        public void get_IsEmpty(){} // RVA: 0x7FFAC484C2F0
        public void .ctor(){} // RVA: 0x7FFAC47E74F0 | overloaded x2
        public void Append(){} // RVA: 0x7FFAC9CD7C50 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC9CD7CD0
        public void EnsureSize(){} // RVA: 0x7FFAC9CD7DA0
        public void ToString(){} // RVA: 0x7FFAC87764B0 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x7FFAC3AD9F60
    }

    public class StringReference : ValueType
    {
        public char[] Item; // 0x10
        public int Chars; // 0x18
        public int StartIndex; // 0x1C

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC87764C0
        public void get_Chars(){} // RVA: 0x7FFAC3AD9F60
        public void get_StartIndex(){} // RVA: 0x7FFAC49C7500
        public void get_Length(){} // RVA: 0x7FFAC49C7520
        public void .ctor(){} // RVA: 0x7FFAC6510D20
        public void ToString(){} // RVA: 0x7FFAC87764F0
    }

    public class StringReferenceExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC9CD7F90
        public void StartsWith(){} // RVA: 0x7FFAC87765A0
        public void EndsWith(){} // RVA: 0x7FFAC8776630
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void FormatWith(){} // RVA: 0x7FFAC9CD8780 | overloaded x5
        public void CreateStringWriter(){} // RVA: 0x7FFAC9CD88C0
        public void ToCharAsUnicode(){} // RVA: 0x7FFAC8777190
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFAC2E8DC40
        public void IsHighSurrogate(){} // RVA: 0x7FFAC9CD89D0
        public void IsLowSurrogate(){} // RVA: 0x7FFAC9CD8A40
        public void StartsWith(){} // RVA: 0x7FFAC8777A80
        public void EndsWith(){} // RVA: 0x7FFAC8777AB0
    }

    public class ThreadSafeStore`2 : Object
    {
        public object _lock;
        public System.Collections.Generic.Dictionary`2<U,T> _store;
        public System.Func`2<U,T> _creator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void AddValue(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void MemberType(){} // RVA: 0x7FFAC8777DA0
        public void ContainsGenericParameters(){} // RVA: 0x7FFAC8777DD0
        public void IsInterface(){} // RVA: 0x7FFAC8777E00
        public void IsGenericType(){} // RVA: 0x7FFAC8777E20
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFAC8777E50
        public void BaseType(){} // RVA: 0x7FFAC8777E80
        public void IsEnum(){} // RVA: 0x7FFAC8777EE0
        public void IsClass(){} // RVA: 0x7FFAC8777F10
        public void IsSealed(){} // RVA: 0x7FFAC8777F70
        public void IsAbstract(){} // RVA: 0x7FFAC8777FA0
        public void IsValueType(){} // RVA: 0x7FFAC8777FF0
        public void AssignableToTypeName(){} // RVA: 0x7FFAC9CD8CE0 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7FFAC9CD8D00
    }

    public class TypeInformation : Object
    {
        public System.Type Type; // 0x10
        public 0x6B245720 TypeCode; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void set_Type(){} // RVA: 0x7FFAC2F22E30
        public void get_TypeCode(){} // RVA: 0x7FFAC3157800
        public void set_TypeCode(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7FFAC9CD8EF0
    }

}