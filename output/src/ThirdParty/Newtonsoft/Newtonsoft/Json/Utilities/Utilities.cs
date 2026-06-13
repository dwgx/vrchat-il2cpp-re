// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 65
// Methods: 586

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper
    {
        // ── Methods ──
        public void Ensure(){} // RVA: 0x5FBB7A0
        public void EnsureType(){} // RVA: 0x24A80
        public void EnsureList(){} // RVA: 0x24A80
        public void EnsureDictionary(){} // RVA: 0x24A80
        public void IsFalse(){} // RVA: 0x5FBB8C0
        public void .cctor(){} // RVA: 0x5FBB920
    }

    public class AsyncUtils
    {
        // ── Methods ──
        public void ToAsync(){} // RVA: 0x5FBB9E0
        public void CancelIfRequestedAsync(){} // RVA: 0x1BDB0 | overloaded x2
        public void FromCanceled(){} // RVA: 0x1BDB0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x5FBBEB0 | overloaded x3
        public void ReadAsync(){} // RVA: 0x5FBBFA0
        public void IsCompletedSuccessfully(){} // RVA: 0x5FBC0B0
        public void .cctor(){} // RVA: 0x5FBC160
    }

    public class Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5FBC490
        public void ValidateEncode(){} // RVA: 0x5FBC5F0
        public void Encode(){} // RVA: 0x5FBC750
        public void StoreLeftOverBytes(){} // RVA: 0x5FBC950
        public void FulfillFromLeftover(){} // RVA: 0x5FBCA80
        public void Flush(){} // RVA: 0x5FBCB30
        public void WriteChars(){} // RVA: 0x5FBCC10
        public void EncodeAsync(){} // RVA: 0x5FBCC40
        public void WriteCharsAsync(){} // RVA: 0x5FBCEE0
        public void FlushAsync(){} // RVA: 0x5FBCF70
    }

    public class BidirectionalDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F9F0 | overloaded x3
        public void Set(){} // RVA: 0x283FA0
        public void TryGetByFirst(){} // RVA: 0x283FA0
        public void TryGetBySecond(){} // RVA: 0x283FA0
    }

    public class BoxedPrimitives
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x5FBDCE0 | overloaded x5
        public void .cctor(){} // RVA: 0x5FBDE60
    }

    public class BufferUtils
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x5FD2390
        public void ReturnBuffer(){} // RVA: 0x5FD2410
        public void EnsureBufferSize(){} // RVA: 0x5FD2470
    }

    public class CollectionUtils
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0xDCC0
        public void AddRange(){} // RVA: 0x24D50
        public void IsDictionaryType(){} // RVA: 0x5FBEEE0
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x5FBF290 | overloaded x2
        public void AddDistinct(){} // RVA: 0x283FA0 | overloaded x2
        public void ContainsValue(){} // RVA: 0x283FA0
        public void AddRangeDistinct(){} // RVA: 0x114C0
        public void IndexOf(){} // RVA: 0x12610
        public void Contains(){} // RVA: 0x283FA0
        public void IndexOfReference(){} // RVA: 0x283FA0
        public void FastReverse(){} // RVA: 0x24AE0
        public void GetDimensions(){} // RVA: 0x5FBF570
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x5FBF930
        public void JaggedArrayGetValue(){} // RVA: 0x5FBFBD0
        public void ToMultidimensionalArray(){} // RVA: 0x5FBFCD0
        public void ArrayEmpty(){} // RVA: 0xC960
    }

    public class CollectionWrapper`1
    {
        public System.Collections.IList _list;
        public System.Collections.Generic.ICollection`1<T> _genericCollection;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
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

    public class CollectionWrapper`1
    {
        public System.Collections.IList _list; // 0x10
        public System.Collections.Generic.ICollection`1<ÏÍÎÏÌÎÎÌÏÏÎÌÎÍÍÌÍÍÍÏÌÌÍ> _genericCollection; // 0x18
        public object _syncRoot; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5776AF0 | overloaded x2
        public void Add(){} // RVA: 0x5776BD0
        public void Clear(){} // RVA: 0x5776D50
        public void Contains(){} // RVA: 0x5776E00
        public void CopyTo(){} // RVA: 0x5776F80
        public void get_Count(){} // RVA: 0x5777040
        public void get_IsReadOnly(){} // RVA: 0x57770F0
        public void Remove(){} // RVA: 0x57771A0
        public void GetEnumerator(){} // RVA: 0x5777390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5777420
        public void System.Collections.IList.Add(){} // RVA: 0x5777480
        public void System.Collections.IList.Contains(){} // RVA: 0x5777670
        public void System.Collections.IList.IndexOf(){} // RVA: 0x5777870
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x5777AC0
        public void System.Collections.IList.Insert(){} // RVA: 0x5777B70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x5777DB0
        public void System.Collections.IList.Remove(){} // RVA: 0x5777E60
        public void System.Collections.IList.get_Item(){} // RVA: 0x5778040
        public void System.Collections.IList.set_Item(){} // RVA: 0x57780F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5778330
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x57783D0
        public void VerifyValueType(){} // RVA: 0x5778480
        public void IsCompatibleObject(){} // RVA: 0x57785D0
        public void get_UnderlyingCollection(){} // RVA: 0x5778760
    }

    public class CollectionWrapper`1
    {
        public System.Collections.IList _list; // 0x10
        public System.Collections.Generic.ICollection`1<string> _genericCollection; // 0x18
        public object _syncRoot; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5776AF0 | overloaded x2
        public void Add(){} // RVA: 0x5776BD0
        public void Clear(){} // RVA: 0x5776D50
        public void Contains(){} // RVA: 0x5776E00
        public void CopyTo(){} // RVA: 0x5776F80
        public void get_Count(){} // RVA: 0x5777040
        public void get_IsReadOnly(){} // RVA: 0x57770F0
        public void Remove(){} // RVA: 0x57771A0
        public void GetEnumerator(){} // RVA: 0x5777390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5777420
        public void System.Collections.IList.Add(){} // RVA: 0x5777480
        public void System.Collections.IList.Contains(){} // RVA: 0x5777670
        public void System.Collections.IList.IndexOf(){} // RVA: 0x5777870
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x5777AC0
        public void System.Collections.IList.Insert(){} // RVA: 0x5777B70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x5777DB0
        public void System.Collections.IList.Remove(){} // RVA: 0x5777E60
        public void System.Collections.IList.get_Item(){} // RVA: 0x5778040
        public void System.Collections.IList.set_Item(){} // RVA: 0x57780F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5778330
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x57783D0
        public void VerifyValueType(){} // RVA: 0x5778480
        public void IsCompatibleObject(){} // RVA: 0x57785D0
        public void get_UnderlyingCollection(){} // RVA: 0x5778760
    }

    public class ConvertUtils
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x5FBFF70 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x5FC02F0
        public void IsConvertible(){} // RVA: 0x5FC03A0
        public void ParseTimeSpan(){} // RVA: 0x5FC0480
        public void CreateCastConverter(){} // RVA: 0x5FC05C0
        public void ToBigInteger(){} // RVA: 0x5FC0890
        public void FromBigInteger(){} // RVA: 0x5FC0E10
        public void Convert(){} // RVA: 0x5FC13E0
        public void TryConvert(){} // RVA: 0x5FC1690
        public void TryConvertInternal(){} // RVA: 0x5FC1780
        public void ConvertOrCast(){} // RVA: 0x5FC2320
        public void EnsureTypeAssignable(){} // RVA: 0x5FC24E0
        public void VersionTryParse(){} // RVA: 0x5FC2750
        public void IsInteger(){} // RVA: 0x5FC2760
        public void Int32TryParse(){} // RVA: 0x5FC2880
        public void Int64TryParse(){} // RVA: 0x5FC29E0
        public void DecimalTryParse(){} // RVA: 0x5FC2B30
        public void TryConvertGuid(){} // RVA: 0x5FC3870
        public void TryHexTextToInt(){} // RVA: 0x5FC38C0
        public void .cctor(){} // RVA: 0x5FC3960
    }

    public class Creator`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
        public void BeginInvoke(){} // RVA: 0x1E6A0
        public void EndInvoke(){} // RVA: 0x283FA0
    }

    public class DateTimeParser
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5FC5CF0
        public void Parse(){} // RVA: 0x5FC6080
        public void ParseDate(){} // RVA: 0x5FC61E0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x5FC64A0
        public void ParseTime(){} // RVA: 0x5FC6530
        public void ParseZone(){} // RVA: 0x5FC68F0
        public void Parse4Digit(){} // RVA: 0x5FC6B20
        public void Parse2Digit(){} // RVA: 0x5FC6C00
        public void ParseChar(){} // RVA: 0x5FC6C70
    }

    public class DateTimeUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5FC6CB0
        public void GetUtcOffset(){} // RVA: 0x5FC6E70
        public void ToSerializationMode(){} // RVA: 0x5FC6EE0
        public void EnsureDateTime(){} // RVA: 0x5FC6F90
        public void SwitchToLocalTime(){} // RVA: 0x5FC7390
        public void SwitchToUtcTime(){} // RVA: 0x5FC7520
        public void ToUniversalTicks(){} // RVA: 0x5FC77B0 | overloaded x2
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x5FC7AA0 | overloaded x3
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x5FC7C60
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x5FC7CE0
        public void TryParseDateTimeIso(){} // RVA: 0x5FC7D70
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x5FC8460
        public void CreateDateTime(){} // RVA: 0x5FC87E0
        public void TryParseDateTime(){} // RVA: 0x5FC8CF0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x5FC94C0 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x5FC99C0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x5FC9BE0
        public void TryParseDateTimeExact(){} // RVA: 0x5FC9DC0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x5FC9EB0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x5FCA090
        public void TryReadOffset(){} // RVA: 0x5FCA140
        public void WriteDateTimeString(){} // RVA: 0x5FCA640 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x5FCA9C0
        public void CopyIntToCharArray(){} // RVA: 0x5FCAF20
        public void WriteDateTimeOffset(){} // RVA: 0x5FCAFB0
        public void WriteDateTimeOffsetString(){} // RVA: 0x5FCB270
        public void GetDateValues(){} // RVA: 0x5FCB4E0
    }

    public class DictionaryWrapper`2 : System.Collections.Generic
    {
        public System.Collections.IDictionary _dictionary;
        public System.Collections.Generic.IDictionary`2<U,T> _genericDictionary;
        public System.Collections.Generic.IReadOnlyDictionary`2<U,T> _readOnlyDictionary;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void get_GenericDictionary(){} // RVA: 0xCD60
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

    public class DynamicProxyMetaObject`1
    {
        public Newtonsoft.Json.Utilities.DynamicProxy`1<T> _proxy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void IsOverridden(){} // RVA: 0xDE40
        public void BindGetMember(){} // RVA: 0xCE10
        public void BindSetMember(){} // RVA: 0x1E6A0
        public void BindDeleteMember(){} // RVA: 0xCE10
        public void BindConvert(){} // RVA: 0xCE10
        public void BindInvokeMember(){} // RVA: 0x1E6A0
        public void BindCreateInstance(){} // RVA: 0x1E6A0
        public void BindInvoke(){} // RVA: 0x1E6A0
        public void BindBinaryOperation(){} // RVA: 0x1E6A0
        public void BindUnaryOperation(){} // RVA: 0xCE10
        public void BindGetIndex(){} // RVA: 0x1E6A0
        public void BindSetIndex(){} // RVA: 0x1EE30
        public void BindDeleteIndex(){} // RVA: 0x1E6A0
        public void get_NoArgs(){} // RVA: 0xC960
        public void GetArgs(){} // RVA: 0xCE50
        public void GetArgArray(){} // RVA: 0xCEC0 | overloaded x2
        public void Constant(){} // RVA: 0xCE50
        public void CallMethodWithResult(){} // RVA: 0x1F260
        public void BuildCallMethodWithResult(){} // RVA: 0x1F260
        public void CallMethodReturnLast(){} // RVA: 0x1F0F0
        public void CallMethodNoResult(){} // RVA: 0x1F0F0
        public void GetRestrictions(){} // RVA: 0xCD60
        public void GetDynamicMemberNames(){} // RVA: 0xCD60
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x283FA0
        public void TryBinaryOperation(){} // RVA: 0x283FA0
        public void TryConvert(){} // RVA: 0x283FA0
        public void TryCreateInstance(){} // RVA: 0x283FA0
        public void TryDeleteIndex(){} // RVA: 0x283FA0
        public void TryDeleteMember(){} // RVA: 0x283FA0
        public void TryGetIndex(){} // RVA: 0x283FA0
        public void TryGetMember(){} // RVA: 0x283FA0
        public void TryInvoke(){} // RVA: 0x283FA0
        public void TryInvokeMember(){} // RVA: 0x283FA0
        public void TrySetIndex(){} // RVA: 0x283FA0
        public void TrySetMember(){} // RVA: 0x283FA0
        public void TryUnaryOperation(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x2E74C70
        public void TryBinaryOperation(){} // RVA: 0x2E74CB0
        public void TryConvert(){} // RVA: 0x2E74D10
        public void TryCreateInstance(){} // RVA: 0x2E74CB0
        public void TryDeleteIndex(){} // RVA: 0x2DD320
        public void TryDeleteMember(){} // RVA: 0x2DD320
        public void TryGetIndex(){} // RVA: 0x2E74CB0
        public void TryGetMember(){} // RVA: 0x2E74D10
        public void TryInvoke(){} // RVA: 0x2E74CB0
        public void TryInvokeMember(){} // RVA: 0x2E74CB0
        public void TrySetIndex(){} // RVA: 0x2DD320
        public void TrySetMember(){} // RVA: 0x2DD320
        public void TryUnaryOperation(){} // RVA: 0x2E74D10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x2E74C70
        public void TryBinaryOperation(){} // RVA: 0x2E74CB0
        public void TryConvert(){} // RVA: 0x2E74D10
        public void TryCreateInstance(){} // RVA: 0x2E74CB0
        public void TryDeleteIndex(){} // RVA: 0x2DD320
        public void TryDeleteMember(){} // RVA: 0x2DD320
        public void TryGetIndex(){} // RVA: 0x2E74CB0
        public void TryGetMember(){} // RVA: 0x2E74D10
        public void TryInvoke(){} // RVA: 0x2E74CB0
        public void TryInvokeMember(){} // RVA: 0x2E74CB0
        public void TrySetIndex(){} // RVA: 0x2DD320
        public void TrySetMember(){} // RVA: 0x2DD320
        public void TryUnaryOperation(){} // RVA: 0x2E74D10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DynamicUtils
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x5FCB700
    }

    public class EnumInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5FCD4D0
    }

    public class EnumUtils
    {
        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x5FCD5D0
        public void GetFlagsValues(){} // RVA: 0x283FA0
        public void TryToString(){} // RVA: 0x5FCDD70 | overloaded x2
        public void InternalFlagsFormat(){} // RVA: 0x5FCE080
        public void GetEnumValuesAndNames(){} // RVA: 0x5FCE230
        public void ToUInt64(){} // RVA: 0x5FCE3B0
        public void ParseEnum(){} // RVA: 0x5FCE760
        public void MatchName(){} // RVA: 0x5FCF060
        public void FindIndexByName(){} // RVA: 0x5FCF150
        public void .cctor(){} // RVA: 0x5FCF240
    }

    public class FSharpFunction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void Invoke(){} // RVA: 0x5FCF4B0
    }

    public class FSharpUtils
    {
        public object Item1;
        public Newtonsoft.Json.Utilities.FSharpUtils Item2; // 0x8
        public System.Reflection.MethodInfo System.Runtime.CompilerServices.ITuple.Length; // 0x10
        public System.Type _mapType; // 0x18
        public System.Reflection.Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <IsUnion>k__BackingField; // 0x28
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <GetUnionCases>k__BackingField; // 0x30
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <PreComputeUnionTagReader>k__BackingField; // 0x38
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <PreComputeUnionReader>k__BackingField; // 0x40
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <PreComputeUnionConstructor>k__BackingField; // 0x48
        public System.Func`2<object,object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5FCF4E0
        public void get_Instance(){} // RVA: 0x5FD00B0
        public void get_FSharpCoreAssembly(){} // RVA: 0x30B0C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x30B0D0
        public void get_IsUnion(){} // RVA: 0x30B130
        public void set_IsUnion(){} // RVA: 0x2DEE90
        public void get_GetUnionCases(){} // RVA: 0x6374D0
        public void set_GetUnionCases(){} // RVA: 0x30B890
        public void get_PreComputeUnionTagReader(){} // RVA: 0x4976A0
        public void set_PreComputeUnionTagReader(){} // RVA: 0x49B830
        public void get_PreComputeUnionReader(){} // RVA: 0x35A740
        public void set_PreComputeUnionReader(){} // RVA: 0x305200
        public void get_PreComputeUnionConstructor(){} // RVA: 0x358730
        public void set_PreComputeUnionConstructor(){} // RVA: 0x358740
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x37E0E0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x4354D0
        public void get_GetUnionCaseInfoName(){} // RVA: 0x3A5500
        public void set_GetUnionCaseInfoName(){} // RVA: 0x3A5510
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x37B370
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x37B380
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x358D50
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x358D60
        public void EnsureInitialized(){} // RVA: 0x5FD0110
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x5FD0380
        public void CreateFSharpFuncCall(){} // RVA: 0x5FD0490
        public void CreateSeq(){} // RVA: 0x5FD0830
        public void CreateMap(){} // RVA: 0x5FD0940
        public void BuildMapCreator(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x5FD0C10
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

    public class ImmutableCollectionsUtils
    {
        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x5FD0E00
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x5FD13F0
        public void .cctor(){} // RVA: 0x5FD1A50
    }

    public class JavaScriptUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5FD2520
        public void GetCharEscapeFlags(){} // RVA: 0x5FD30E0
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x5FD31B0
        public void WriteEscapedJavaScriptString(){} // RVA: 0x5FD3230
        public void ToEscapedJavaScriptString(){} // RVA: 0x5FD3B70
        public void FirstCharToEscape(){} // RVA: 0x5FD3D20
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x5FD3DE0
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x5FD4350 | overloaded x2
        public void WriteCharAsync(){} // RVA: 0x5FD4730
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x5FD49C0
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x5FD4B80
        public void TryGetDateFromConstructorJson(){} // RVA: 0x5FD4F00
        public void TryGetDateConstructorValue(){} // RVA: 0x5FD53E0
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
        public Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5FD6EF0
        public void CreateParameterizedConstructor(){} // RVA: 0x5FD6F50
        public void CreateMethodCall(){} // RVA: 0xCE10
        public void CreateDefaultConstructor(){} // RVA: 0xCE10
        public void CreateGet(){} // RVA: 0xCE10 | overloaded x2
        public void CreateSet(){} // RVA: 0xCE10 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5FD7180
    }

    public class MathUtils
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x5FD72C0
        public void IntToHex(){} // RVA: 0x5FD7420
        public void Min(){} // RVA: 0x5FD7430
        public void Max(){} // RVA: 0x5FD75F0 | overloaded x2
        public void ApproxEquals(){} // RVA: 0x5FD7710
    }

    public class MethodCall`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
        public void BeginInvoke(){} // RVA: 0x283FA0
        public void EndInvoke(){} // RVA: 0x283FA0
    }

    public class MiscellaneousUtils
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x2DD310
        public void ValueEquals(){} // RVA: 0x5FD77E0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x5FD7B30
        public void ToString(){} // RVA: 0x5FD7C60
        public void ByteArrayCompare(){} // RVA: 0x5FD7D10
        public void GetPrefix(){} // RVA: 0x5FD7DB0
        public void GetLocalName(){} // RVA: 0x5FD7DE0
        public void GetQualifiedNameParts(){} // RVA: 0x5FD7E10
        public void GetRegexOptions(){} // RVA: 0x5FD7F70
    }

    public class NoThrowExpressionVisitor
    {
        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x5FCD1C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5FCD420
    }

    public class NoThrowGetBinderMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5FCCD20
        public void FallbackGetMember(){} // RVA: 0x5FCCDB0
    }

    public class NoThrowSetBinderMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5FCCEC0
        public void FallbackSetMember(){} // RVA: 0x5FCD060
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
        public System.Type <MemberType>k__BackingField; // 0x10
        public System.Func`2<object,object> <Getter>k__BackingField; // 0x18
        public System.Action`2<object,object> <Setter>k__BackingField; // 0x20

        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x2F8380
        public void set_MemberType(){} // RVA: 0x2DEE30
        public void get_Getter(){} // RVA: 0x2E07C0
        public void set_Getter(){} // RVA: 0x343E80
        public void get_Setter(){} // RVA: 0x30B0C0
        public void set_Setter(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReflectionObject
    {
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> <Creator>k__BackingField; // 0x10
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x2F8380
        public void get_Members(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x5FD8020
        public void GetValue(){} // RVA: 0x5FD8140
        public void SetValue(){} // RVA: 0x5FD81C0
        public void GetType(){} // RVA: 0x5FD8250
        public void Create(){} // RVA: 0x5FD82C0 | overloaded x2
    }

    public class ReflectionUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5FD8D70
        public void IsVirtual(){} // RVA: 0x5FD8E40
        public void GetBaseDefinition(){} // RVA: 0x5FD8F50
        public void IsPublic(){} // RVA: 0x5FD9060
        public void GetObjectType(){} // RVA: 0x5FD9100
        public void GetTypeName(){} // RVA: 0x5FD9120
        public void GetFullyQualifiedTypeName(){} // RVA: 0x5FD91F0
        public void RemoveAssemblyDetails(){} // RVA: 0x5FD94E0
        public void HasDefaultConstructor(){} // RVA: 0x5FD9650
        public void GetDefaultConstructor(){} // RVA: 0x5FD9810 | overloaded x2
        public void IsNullable(){} // RVA: 0x5FD99B0
        public void IsNullableType(){} // RVA: 0x5FD9A90
        public void EnsureNotNullableType(){} // RVA: 0x5FD9BA0
        public void EnsureNotByRefType(){} // RVA: 0x5FD9C10
        public void IsGenericDefinition(){} // RVA: 0x5FD9C80
        public void ImplementsGenericDefinition(){} // RVA: 0x5FD9DA0 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x5FDA120 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x5FDA470
        public void GetCollectionItemType(){} // RVA: 0x5FDA600
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x5FDA940
        public void GetMemberUnderlyingType(){} // RVA: 0x5FDADD0
        public void IsByRefLikeType(){} // RVA: 0x5FDB090
        public void IsIndexedProperty(){} // RVA: 0x5FDB230
        public void GetMemberValue(){} // RVA: 0x5FDB2E0
        public void SetMemberValue(){} // RVA: 0x5FDB630
        public void CanReadMemberValue(){} // RVA: 0x5FDB8C0
        public void CanSetMemberValue(){} // RVA: 0x5FDBA30
        public void GetFieldsAndProperties(){} // RVA: 0x5FDBBF0
        public void IsOverridenGenericMember(){} // RVA: 0x5FDC460
        public void GetAttribute(){} // RVA: 0x283FA0 | overloaded x2
        public void GetAttributes(){} // RVA: 0x5FDC680 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x5FDCB00
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x5FDCCB0
        public void GetMemberInfoFromType(){} // RVA: 0x5FDCD70
        public void GetFields(){} // RVA: 0x5FDD1A0
        public void GetChildPrivateFields(){} // RVA: 0x5FDD2F0
        public void GetProperties(){} // RVA: 0x5FDD500
        public void RemoveFlag(){} // RVA: 0x5FDD880
        public void GetChildPrivateProperties(){} // RVA: 0x5FDD8A0
        public void IsMethodOverridden(){} // RVA: 0x5FDDCC0
        public void GetDefaultValue(){} // RVA: 0x5FDDE70
    }

    public class StringBuffer
    {
        public char[] Item; // 0x10
        public int Chars; // 0x18

        // ── Methods ──
        public void get_Position(){} // RVA: 0x1EA9890
        public void set_Position(){} // RVA: 0x1EA98A0
        public void get_IsEmpty(){} // RVA: 0x1D26810
        public void .ctor(){} // RVA: 0x1CBDE20 | overloaded x2
        public void Append(){} // RVA: 0x5FDEAD0 | overloaded x2
        public void Clear(){} // RVA: 0x5FDEB50
        public void EnsureSize(){} // RVA: 0x5FDEC20
        public void ToString(){} // RVA: 0x5FDEE30 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x1AD4690
    }

    public class StringReference
    {
        public char[] _chars; // 0x10
        public int _startIndex; // 0x18
        public int _length; // 0x1C

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
        public void IndexOf(){} // RVA: 0x5FDEE90
        public void StartsWith(){} // RVA: 0x5FDEF20
        public void EndsWith(){} // RVA: 0x5FDEFB0
    }

    public class StringUtils
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x5FDF040
        public void FormatWith(){} // RVA: 0x5FDF7C0 | overloaded x5
        public void IsWhiteSpace(){} // RVA: 0x5FDF900
        public void CreateStringWriter(){} // RVA: 0x5FDFA00
        public void ToCharAsUnicode(){} // RVA: 0x5FDFB10
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x283FA0
        public void ToCamelCase(){} // RVA: 0x5FDFBF0
        public void ToLower(){} // RVA: 0x5FDFDE0
        public void ToSnakeCase(){} // RVA: 0x5FDFF30
        public void ToKebabCase(){} // RVA: 0x5FDFF40
        public void ToSeparatedCase(){} // RVA: 0x5FDFF50
        public void IsHighSurrogate(){} // RVA: 0x5FE02D0
        public void IsLowSurrogate(){} // RVA: 0x5FE0340
        public void IndexOf(){} // RVA: 0x5FE03B0
        public void Replace(){} // RVA: 0x5FE03E0
        public void StartsWith(){} // RVA: 0x5FE0400
        public void EndsWith(){} // RVA: 0x5FE0430
        public void Trim(){} // RVA: 0x5FE0480
    }

    public class StructMultiKey`2
    {
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void GetHashCode(){} // RVA: 0x40AD780
        public void Equals(){} // RVA: 0x40AD960 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void GetHashCode(){} // RVA: 0x40AD780
        public void Equals(){} // RVA: 0x40AD960 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void GetHashCode(){} // RVA: 0x40AD780
        public void Equals(){} // RVA: 0x40AD960 | overloaded x2
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43EFF20
        public void Get(){} // RVA: 0x43F0150
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Get(){} // RVA: 0x283FA0
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43EFF20
        public void Get(){} // RVA: 0x43F0150
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43F0190
        public void Get(){} // RVA: 0x43F0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x43EFF20
        public void Get(){} // RVA: 0x43F0150
    }

    public class TypeExtensions
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x5FE06F0
        public void MemberType(){} // RVA: 0x5FE0720
        public void ContainsGenericParameters(){} // RVA: 0x5FE0750
        public void IsInterface(){} // RVA: 0x5FE0780
        public void IsGenericType(){} // RVA: 0x5FE07A0
        public void IsGenericTypeDefinition(){} // RVA: 0x5FE07D0
        public void BaseType(){} // RVA: 0x5FE0800
        public void Assembly(){} // RVA: 0x5FE0830
        public void IsEnum(){} // RVA: 0x5FE0860
        public void IsClass(){} // RVA: 0x5FE0890
        public void IsSealed(){} // RVA: 0x5FE08F0
        public void IsAbstract(){} // RVA: 0x5FE0920
        public void IsVisible(){} // RVA: 0x5FE0950
        public void IsValueType(){} // RVA: 0x5FE0970
        public void IsPrimitive(){} // RVA: 0x5FE09A0
        public void AssignableToTypeName(){} // RVA: 0x5FE0C50 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x5FE0C70
    }

    public class TypeInformation
    {
        public System.Type <Type>k__BackingField; // 0x10
        public 0x658E2370 <TypeCode>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x2F8380
        public void get_TypeCode(){} // RVA: 0x5BED50
        public void .ctor(){} // RVA: 0x1D66A50
    }

    public class ValidationUtils
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x5FE0EC0
    }

}