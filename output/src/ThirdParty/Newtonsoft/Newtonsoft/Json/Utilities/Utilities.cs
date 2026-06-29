// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 63
// Methods: 496

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper : Object
    {
        // ── Methods ──
        public void Ensure(){} // RVA: 0x6A301A0
        public void EnsureType(){} // RVA: 0x8942F0
        public void EnsureList(){} // RVA: 0x8942F0
        public void EnsureDictionary(){} // RVA: 0x8942F0
        public void IsFalse(){} // RVA: 0x6A302C0
        public void .cctor(){} // RVA: 0x6A30320
    }

    public class AsyncUtils : Object
    {
        // ── Methods ──
        public void ToAsync(){} // RVA: 0x6A303E0
        public void CancelIfRequestedAsync(){} // RVA: 0x882880
        public void FromCanceled(){} // RVA: 0x882880
        public void WriteAsync(){} // RVA: 0x6A308B0
        public void ReadAsync(){} // RVA: 0x6A309A0
        public void IsCompletedSuccessfully(){} // RVA: 0x6A30AB0
        public void .cctor(){} // RVA: 0x6A30B60
    }

    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A30E90
        public void ValidateEncode(){} // RVA: 0x6A30FF0
        public void Encode(){} // RVA: 0x6A31150
        public void StoreLeftOverBytes(){} // RVA: 0x6A31370
        public void FulfillFromLeftover(){} // RVA: 0x6A314C0
        public void Flush(){} // RVA: 0x6A31580
        public void WriteChars(){} // RVA: 0x6A31660
        public void EncodeAsync(){} // RVA: 0x6A31690
        public void WriteCharsAsync(){} // RVA: 0x6A31930
        public void FlushAsync(){} // RVA: 0x6A319C0
    }

    public class BidirectionalDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899870
        public void Set(){} // RVA: 0xA94080
        public void TryGetByFirst(){} // RVA: 0xA94080
        public void TryGetBySecond(){} // RVA: 0xA94080
    }

    public class BoxedPrimitives : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x6A32740
        public void .cctor(){} // RVA: 0x6A328B0
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x6A46720
        public void ReturnBuffer(){} // RVA: 0x6A467A0
        public void EnsureBufferSize(){} // RVA: 0x6A46800
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void AddRange(){} // RVA: 0x8945C0
        public void IndexOf(){} // RVA: 0x881CE0
        public void ArrayEmpty(){} // RVA: 0x87C0D0
        public void IsNullOrEmpty(){} // RVA: 0x87D390
        public void Contains(){} // RVA: 0xA94080
        public void IsDictionaryType(){} // RVA: 0x6A338F0
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x6A33C90
        public void AddDistinct(){} // RVA: 0xA94080
        public void ContainsValue(){} // RVA: 0xA94080
        public void AddRangeDistinct(){} // RVA: 0x880B90
        public void IndexOfReference(){} // RVA: 0xA94080
        public void FastReverse(){} // RVA: 0x894350
        public void GetDimensions(){} // RVA: 0x6A33F40
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x6A34300
        public void JaggedArrayGetValue(){} // RVA: 0x6A345B0
        public void ToMultidimensionalArray(){} // RVA: 0x6A346B0
    }

    public class CollectionWrapper`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
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
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x6A34950
        public void GetTypeInformation(){} // RVA: 0x6A34C60
        public void IsConvertible(){} // RVA: 0x6A34D10
        public void ParseTimeSpan(){} // RVA: 0x6A34DC0
        public void CreateCastConverter(){} // RVA: 0x6A34F00
        public void ToBigInteger(){} // RVA: 0x6A351D0
        public void FromBigInteger(){} // RVA: 0x6A356D0
        public void Convert(){} // RVA: 0x6A35C20
        public void TryConvert(){} // RVA: 0x6A35ED0
        public void TryConvertInternal(){} // RVA: 0x6A35FD0
        public void ConvertOrCast(){} // RVA: 0x6A36C10
        public void EnsureTypeAssignable(){} // RVA: 0x6A36D90
        public void VersionTryParse(){} // RVA: 0x6A37000
        public void IsInteger(){} // RVA: 0x6A37010
        public void Int32TryParse(){} // RVA: 0x6A37130
        public void Int64TryParse(){} // RVA: 0x6A372D0
        public void DecimalTryParse(){} // RVA: 0x6A37460
        public void TryConvertGuid(){} // RVA: 0x6A381D0
        public void TryHexTextToInt(){} // RVA: 0x6A38220
        public void .cctor(){} // RVA: 0x6A382D0
    }

    public class Creator`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
        public void BeginInvoke(){} // RVA: 0x87C5F0
        public void EndInvoke(){} // RVA: 0xA94080
    }

    public class DateTimeParser : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6A3A2B0
        public void Parse(){} // RVA: 0x8C5A40
        public void ParseDate(){} // RVA: 0x8C5A50
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x8C5A60
        public void ParseTime(){} // RVA: 0x8C5A70
        public void ParseZone(){} // RVA: 0x8C5A80
        public void Parse4Digit(){} // RVA: 0x8C5A90
        public void Parse2Digit(){} // RVA: 0x8C5AA0
        public void ParseChar(){} // RVA: 0x8C5AB0
    }

    public class DateTimeUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6A3B2C0
        public void GetUtcOffset(){} // RVA: 0x6A3B480
        public void ToSerializationMode(){} // RVA: 0x6A3B4F0
        public void EnsureDateTime(){} // RVA: 0x6A3B5A0
        public void SwitchToLocalTime(){} // RVA: 0x6A3B9A0
        public void SwitchToUtcTime(){} // RVA: 0x6A3BB30
        public void ToUniversalTicks(){} // RVA: 0x6A3BDC0
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x6A3C0B0
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x6A3C270
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x6A3C2F0
        public void TryParseDateTimeIso(){} // RVA: 0x6A3C380
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x6A3CA70
        public void CreateDateTime(){} // RVA: 0x6A3CDF0
        public void TryParseDateTime(){} // RVA: 0x6A3D300
        public void TryParseDateTimeOffset(){} // RVA: 0x6A3DAC0
        public void TryParseMicrosoftDate(){} // RVA: 0x6A3DFB0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x6A3E1E0
        public void TryParseDateTimeExact(){} // RVA: 0x6A3E3C0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x6A3E4B0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x6A3E690
        public void TryReadOffset(){} // RVA: 0x6A3E740
        public void WriteDateTimeString(){} // RVA: 0x6A3EBF0
        public void WriteDefaultIsoDate(){} // RVA: 0x6A3EF70
        public void CopyIntToCharArray(){} // RVA: 0x6A3F510
        public void WriteDateTimeOffset(){} // RVA: 0x6A3F5C0
        public void WriteDateTimeOffsetString(){} // RVA: 0x6A3F8B0
        public void GetDateValues(){} // RVA: 0x6A3FB20
    }

    public class DictionaryWrapper`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_GenericDictionary(){} // RVA: 0x87C0A0
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

    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void IsOverridden(){} // RVA: 0x87D350
        public void BindGetMember(){} // RVA: 0x87C540
        public void BindSetMember(){} // RVA: 0x87C5F0
        public void BindDeleteMember(){} // RVA: 0x87C540
        public void BindConvert(){} // RVA: 0x87C540
        public void BindInvokeMember(){} // RVA: 0x87C5F0
        public void BindCreateInstance(){} // RVA: 0x87C5F0
        public void BindInvoke(){} // RVA: 0x87C5F0
        public void BindBinaryOperation(){} // RVA: 0x87C5F0
        public void BindUnaryOperation(){} // RVA: 0x87C540
        public void BindGetIndex(){} // RVA: 0x87C5F0
        public void BindSetIndex(){} // RVA: 0x882090
        public void BindDeleteIndex(){} // RVA: 0x87C5F0
        public void get_NoArgs(){} // RVA: 0x87C0D0
        public void GetArgs(){} // RVA: 0x87C5C0
        public void GetArgArray(){} // RVA: 0x87C630
        public void Constant(){} // RVA: 0x87C5C0
        public void CallMethodWithResult(){} // RVA: 0x88E980
        public void BuildCallMethodWithResult(){} // RVA: 0x88E980
        public void CallMethodReturnLast(){} // RVA: 0x88D2C0
        public void CallMethodNoResult(){} // RVA: 0x88D2C0
        public void GetRestrictions(){} // RVA: 0x87C0A0
        public void GetDynamicMemberNames(){} // RVA: 0x87C0A0
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0xA94080
        public void TryBinaryOperation(){} // RVA: 0xA94080
        public void TryConvert(){} // RVA: 0xA94080
        public void TryCreateInstance(){} // RVA: 0xA94080
        public void TryDeleteIndex(){} // RVA: 0xA94080
        public void TryDeleteMember(){} // RVA: 0xA94080
        public void TryGetIndex(){} // RVA: 0xA94080
        public void TryGetMember(){} // RVA: 0xA94080
        public void TryInvoke(){} // RVA: 0xA94080
        public void TryInvokeMember(){} // RVA: 0xA94080
        public void TrySetIndex(){} // RVA: 0xA94080
        public void TrySetMember(){} // RVA: 0xA94080
        public void TryUnaryOperation(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x3896990
        public void TryBinaryOperation(){} // RVA: 0x38969D0
        public void TryConvert(){} // RVA: 0x3896A30
        public void TryCreateInstance(){} // RVA: 0x38969D0
        public void TryDeleteIndex(){} // RVA: 0xB43320
        public void TryDeleteMember(){} // RVA: 0xB43320
        public void TryGetIndex(){} // RVA: 0x38969D0
        public void TryGetMember(){} // RVA: 0x3896A30
        public void TryInvoke(){} // RVA: 0x38969D0
        public void TryInvokeMember(){} // RVA: 0x38969D0
        public void TrySetIndex(){} // RVA: 0xB43320
        public void TrySetMember(){} // RVA: 0xB43320
        public void TryUnaryOperation(){} // RVA: 0x3896A30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x3896990
        public void TryBinaryOperation(){} // RVA: 0x38969D0
        public void TryConvert(){} // RVA: 0x3896A30
        public void TryCreateInstance(){} // RVA: 0x38969D0
        public void TryDeleteIndex(){} // RVA: 0xB43320
        public void TryDeleteMember(){} // RVA: 0xB43320
        public void TryGetIndex(){} // RVA: 0x38969D0
        public void TryGetMember(){} // RVA: 0x3896A30
        public void TryInvoke(){} // RVA: 0x38969D0
        public void TryInvokeMember(){} // RVA: 0x38969D0
        public void TrySetIndex(){} // RVA: 0xB43320
        public void TrySetMember(){} // RVA: 0xB43320
        public void TryUnaryOperation(){} // RVA: 0x3896A30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DynamicUtils : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x6A3FD50
    }

    public class EnumInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A419C0
    }

    public class EnumUtils : Object
    {
        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x6A41AC0
        public void GetFlagsValues(){} // RVA: 0xA94080
        public void TryToString(){} // RVA: 0x6A42240
        public void InternalFlagsFormat(){} // RVA: 0x6A42570
        public void GetEnumValuesAndNames(){} // RVA: 0x6A42720
        public void ToUInt64(){} // RVA: 0x6A428A0
        public void ParseEnum(){} // RVA: 0x6A42BA0
        public void MatchName(){} // RVA: 0x6A43460
        public void FindIndexByName(){} // RVA: 0x6A43550
        public void .cctor(){} // RVA: 0x6A43650
    }

    public class FSharpFunction : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void Invoke(){} // RVA: 0x6A438C0
    }

    public class FSharpUtils : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A438F0
        public void get_Instance(){} // RVA: 0x6A444C0
        public void get_FSharpCoreAssembly(){} // RVA: 0xB700F0
        public void set_FSharpCoreAssembly(){} // RVA: 0xB70100
        public void get_IsUnion(){} // RVA: 0xB70160
        public void set_IsUnion(){} // RVA: 0xB44DC0
        public void get_GetUnionCases(){} // RVA: 0xD33E60
        public void set_GetUnionCases(){} // RVA: 0xB708C0
        public void get_PreComputeUnionTagReader(){} // RVA: 0xD05CA0
        public void set_PreComputeUnionTagReader(){} // RVA: 0xD09D70
        public void get_PreComputeUnionReader(){} // RVA: 0xBC1B30
        public void set_PreComputeUnionReader(){} // RVA: 0xB6A8C0
        public void get_PreComputeUnionConstructor(){} // RVA: 0xBBF8F0
        public void set_PreComputeUnionConstructor(){} // RVA: 0xBBF900
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0xBE58B0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0xCA4DF0
        public void get_GetUnionCaseInfoName(){} // RVA: 0xC0FFC0
        public void set_GetUnionCaseInfoName(){} // RVA: 0xC0FFD0
        public void get_GetUnionCaseInfoTag(){} // RVA: 0xBE2C60
        public void set_GetUnionCaseInfoTag(){} // RVA: 0xBE2C70
        public void get_GetUnionCaseInfoFields(){} // RVA: 0xBBFF90
        public void set_GetUnionCaseInfoFields(){} // RVA: 0xBBFFA0
        public void EnsureInitialized(){} // RVA: 0x6A44520
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x6A44760
        public void CreateFSharpFuncCall(){} // RVA: 0x6A44870
        public void CreateSeq(){} // RVA: 0x6A44C20
        public void CreateMap(){} // RVA: 0x6A44D30
        public void BuildMapCreator(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x6A44FD0
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

    public class ImmutableCollectionsUtils : Object
    {
        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x6A451C0
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x6A457A0
        public void .cctor(){} // RVA: 0x6A45DF0
    }

    public class JavaScriptUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6A468B0
        public void GetCharEscapeFlags(){} // RVA: 0x6A47490
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x6A47560
        public void WriteEscapedJavaScriptString(){} // RVA: 0x6A475E0
        public void ToEscapedJavaScriptString(){} // RVA: 0x6A47F30
        public void FirstCharToEscape(){} // RVA: 0x6A480F0
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x6A481B0
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x6A48720
        public void WriteCharAsync(){} // RVA: 0x6A48B10
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x6A48DA0
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x6A48F60
        public void TryGetDateFromConstructorJson(){} // RVA: 0x6A492F0
        public void TryGetDateConstructorValue(){} // RVA: 0x6A497D0
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
        // ── Methods ──
        public void CreateDefaultConstructor(){} // RVA: 0x87C540
        public void get_Instance(){} // RVA: 0x6A4B2E0
        public void CreateParameterizedConstructor(){} // RVA: 0x6A4B340
        public void CreateMethodCall(){} // RVA: 0x87C540
        public void CreateGet(){} // RVA: 0x87C540
        public void CreateSet(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6A4B570
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x6A4B6B0
        public void IntToHex(){} // RVA: 0x6A4B810
        public void Min(){} // RVA: 0x6A4B820
        public void Max(){} // RVA: 0x6A4B9E0
        public void ApproxEquals(){} // RVA: 0x6A4BB00
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
        public void BeginInvoke(){} // RVA: 0xA94080
        public void EndInvoke(){} // RVA: 0xA94080
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0xB43310
        public void ValueEquals(){} // RVA: 0x6A4BBD0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x6A4BEE0
        public void ToString(){} // RVA: 0x6A4C010
        public void ByteArrayCompare(){} // RVA: 0x6A4C0B0
        public void GetPrefix(){} // RVA: 0x6A4C150
        public void GetLocalName(){} // RVA: 0x6A4C180
        public void GetQualifiedNameParts(){} // RVA: 0x6A4C1B0
        public void GetRegexOptions(){} // RVA: 0x6A4C310
    }

    public class NoThrowExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x6A416B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6A41910
    }

    public class NoThrowGetBinderMember : GetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A41210
        public void FallbackGetMember(){} // RVA: 0x6A412A0
    }

    public class NoThrowSetBinderMember : SetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A413B0
        public void FallbackSetMember(){} // RVA: 0x6A41550
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateDefaultConstructor(){} // RVA: 0x87C540
        public void CreateMethodCall(){} // RVA: 0x87C540
        public void CreateGet(){} // RVA: 0x87C540
        public void CreateSet(){} // RVA: 0x87C540
        public void CreateParameterizedConstructor(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectionMember : Object
    {
        // ── Methods ──
        public void get_MemberType(){} // RVA: 0xB5DBF0
        public void set_MemberType(){} // RVA: 0xB44D60
        public void get_Getter(){} // RVA: 0xB465B0
        public void set_Getter(){} // RVA: 0xBA9BA0
        public void get_Setter(){} // RVA: 0xB700F0
        public void set_Setter(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReflectionObject : Object
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0xB5DBF0
        public void get_Members(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x6A4C3C0
        public void GetValue(){} // RVA: 0x6A4C4E0
        public void SetValue(){} // RVA: 0x6A4C560
        public void GetType(){} // RVA: 0x6A4C5F0
        public void Create(){} // RVA: 0x6A4C660
    }

    public class ReflectionUtils : Object
    {
        // ── Methods ──
        public void GetAttribute(){} // RVA: 0xA94080
        public void GetAttributes(){} // RVA: 0x6A509A0
        public void .cctor(){} // RVA: 0x6A4D0F0
        public void IsVirtual(){} // RVA: 0x6A4D1B0
        public void GetBaseDefinition(){} // RVA: 0x6A4D2C0
        public void IsPublic(){} // RVA: 0x6A4D3D0
        public void GetObjectType(){} // RVA: 0x6A4D470
        public void GetTypeName(){} // RVA: 0x6A4D490
        public void GetFullyQualifiedTypeName(){} // RVA: 0x6A4D560
        public void RemoveAssemblyDetails(){} // RVA: 0x6A4D810
        public void HasDefaultConstructor(){} // RVA: 0x6A4D980
        public void GetDefaultConstructor(){} // RVA: 0x6A4DB40
        public void IsNullable(){} // RVA: 0x6A4DCE0
        public void IsNullableType(){} // RVA: 0x6A4DDC0
        public void EnsureNotNullableType(){} // RVA: 0x6A4DF00
        public void EnsureNotByRefType(){} // RVA: 0x6A4DF70
        public void IsGenericDefinition(){} // RVA: 0x6A4DFE0
        public void ImplementsGenericDefinition(){} // RVA: 0x6A4E0D0
        public void InheritsGenericDefinition(){} // RVA: 0x6A4E450
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x6A4E780
        public void GetCollectionItemType(){} // RVA: 0x6A4E8F0
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x6A4EC60
        public void GetMemberUnderlyingType(){} // RVA: 0x6A4F0E0
        public void IsByRefLikeType(){} // RVA: 0x6A4F3A0
        public void IsIndexedProperty(){} // RVA: 0x6A4F550
        public void GetMemberValue(){} // RVA: 0x6A4F600
        public void SetMemberValue(){} // RVA: 0x6A4F950
        public void CanReadMemberValue(){} // RVA: 0x6A4FBE0
        public void CanSetMemberValue(){} // RVA: 0x6A4FD50
        public void GetFieldsAndProperties(){} // RVA: 0x6A4FF10
        public void IsOverridenGenericMember(){} // RVA: 0x6A50790
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x6A50E10
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x6A50FC0
        public void GetMemberInfoFromType(){} // RVA: 0x6A51080
        public void GetFields(){} // RVA: 0x6A514D0
        public void GetChildPrivateFields(){} // RVA: 0x6A51620
        public void GetProperties(){} // RVA: 0x6A51820
        public void RemoveFlag(){} // RVA: 0x6A51B90
        public void GetChildPrivateProperties(){} // RVA: 0x6A51BB0
        public void IsMethodOverridden(){} // RVA: 0x6A51FF0
        public void GetDefaultValue(){} // RVA: 0x6A521A0
    }

    public class StringBuffer : ValueType
    {
        // ── Methods ──
        public void get_Position(){} // RVA: 0x14790
        public void set_Position(){} // RVA: 0x92DD0
        public void get_IsEmpty(){} // RVA: 0x88E70
        public void .ctor(){} // RVA: 0x853B0
        public void Append(){} // RVA: 0x8C6520
        public void Clear(){} // RVA: 0x8C6530
        public void EnsureSize(){} // RVA: 0x8C6540
        public void ToString(){} // RVA: 0x8C6570
        public void get_InternalBuffer(){} // RVA: 0x77900
    }

    public class StringReference : ValueType
    {
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
        public void IndexOf(){} // RVA: 0x6A53100
        public void StartsWith(){} // RVA: 0x6A53190
        public void EndsWith(){} // RVA: 0x6A53220
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void ForgivingCaseSensitiveFind(){} // RVA: 0xA94080
        public void IsNullOrEmpty(){} // RVA: 0x6A532E0
        public void FormatWith(){} // RVA: 0x6A53A60
        public void IsWhiteSpace(){} // RVA: 0x6A53BA0
        public void CreateStringWriter(){} // RVA: 0x6A53C80
        public void ToCharAsUnicode(){} // RVA: 0x6A53D90
        public void ToCamelCase(){} // RVA: 0x6A53E60
        public void ToLower(){} // RVA: 0x6A54030
        public void ToSnakeCase(){} // RVA: 0x6A54170
        public void ToKebabCase(){} // RVA: 0x6A54180
        public void ToSeparatedCase(){} // RVA: 0x6A54190
        public void IsHighSurrogate(){} // RVA: 0x6A54500
        public void IsLowSurrogate(){} // RVA: 0x6A54550
        public void IndexOf(){} // RVA: 0x6A545A0
        public void Replace(){} // RVA: 0x6A545D0
        public void StartsWith(){} // RVA: 0x6A545F0
        public void EndsWith(){} // RVA: 0x6A54620
        public void Trim(){} // RVA: 0x6A54670
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void Equals(){} // RVA: 0xA94080
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void GetHashCode(){} // RVA: 0x4A33C0
        public void Equals(){} // RVA: 0x4A33E0
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void GetHashCode(){} // RVA: 0x4A33C0
        public void Equals(){} // RVA: 0x4A33E0
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void GetHashCode(){} // RVA: 0x4A33C0
        public void Equals(){} // RVA: 0x4A33E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Get(){} // RVA: 0xA94080
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF0F70
        public void Get(){} // RVA: 0x4EF11A0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF11E0
        public void Get(){} // RVA: 0x4EF1370
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF11E0
        public void Get(){} // RVA: 0x4EF1370
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF11E0
        public void Get(){} // RVA: 0x4EF1370
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF11E0
        public void Get(){} // RVA: 0x4EF1370
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF0F70
        public void Get(){} // RVA: 0x4EF11A0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF11E0
        public void Get(){} // RVA: 0x4EF1370
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x4EF1370
        public void .ctor(){} // RVA: 0x4EF11E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x4EF1370
        public void .ctor(){} // RVA: 0x4EF11E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x4EF1370
        public void .ctor(){} // RVA: 0x4EF11E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x4EF1370
        public void .ctor(){} // RVA: 0x4EF11E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4EF0F70
        public void Get(){} // RVA: 0x4EF11A0
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x6A548C0
        public void MemberType(){} // RVA: 0x6A548F0
        public void ContainsGenericParameters(){} // RVA: 0x6A54920
        public void IsInterface(){} // RVA: 0x6A54950
        public void IsGenericType(){} // RVA: 0x6A54970
        public void IsGenericTypeDefinition(){} // RVA: 0x6A549A0
        public void BaseType(){} // RVA: 0x6A549D0
        public void Assembly(){} // RVA: 0x6A54A00
        public void IsEnum(){} // RVA: 0x6A54A30
        public void IsClass(){} // RVA: 0x6A54A60
        public void IsSealed(){} // RVA: 0x6A54AC0
        public void IsAbstract(){} // RVA: 0x6A54AF0
        public void IsVisible(){} // RVA: 0x6A54B20
        public void IsValueType(){} // RVA: 0x6A54B40
        public void IsPrimitive(){} // RVA: 0x6A54B70
        public void AssignableToTypeName(){} // RVA: 0x6A54E10
        public void ImplementInterface(){} // RVA: 0x6A54E30
    }

    public class TypeInformation : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_TypeCode(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class TypeInformation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x6A550A0
    }

}