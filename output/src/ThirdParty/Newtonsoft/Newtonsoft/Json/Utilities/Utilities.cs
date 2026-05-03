// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 45
// Methods: 470

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper : Object
    {
        // ── Methods ──
        public void Ensure(){} // RVA: 0x7FFE86AFC590
        public void EnsureType(){} // RVA: 0x7FFE80E46010
        public void EnsureList(){} // RVA: 0x7FFE80E46010
        public void EnsureDictionary(){} // RVA: 0x7FFE80E46010
        public void IsFalse(){} // RVA: 0x7FFE86AFC6B0
        public void .cctor(){} // RVA: 0x7FFE86AFC710
    }

    public class AsyncUtils : Object
    {
        // ── Methods ──
        public void ToAsync(){} // RVA: 0x7FFE86AFC7D0
        public void CancelIfRequestedAsync(){} // RVA: 0x7FFE80E3D320 | overloaded x2
        public void FromCanceled(){} // RVA: 0x7FFE80E3D320 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE86AFCCA0 | overloaded x3
        public void ReadAsync(){} // RVA: 0x7FFE86AFCD90
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFE86AFCEA0
        public void .cctor(){} // RVA: 0x7FFE86AFCF50
    }

    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86AFD280
        public void ValidateEncode(){} // RVA: 0x7FFE86AFD3E0
        public void Encode(){} // RVA: 0x7FFE86AFD540
        public void StoreLeftOverBytes(){} // RVA: 0x7FFE86AFD740
        public void FulfillFromLeftover(){} // RVA: 0x7FFE86AFD870
        public void Flush(){} // RVA: 0x7FFE86AFD920
        public void WriteChars(){} // RVA: 0x7FFE86AFDA00
        public void EncodeAsync(){} // RVA: 0x7FFE86AFDA30
        public void WriteCharsAsync(){} // RVA: 0x7FFE86AFDCD0
        public void FlushAsync(){} // RVA: 0x7FFE86AFDD60
    }

    public class BidirectionalDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50FC0 | overloaded x3
        public void Set(){} // RVA: 0x7FFE810A1420
        public void TryGetByFirst(){} // RVA: 0x7FFE810A1420
        public void TryGetBySecond(){} // RVA: 0x7FFE810A1420
    }

    public class BoxedPrimitives : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE86AFEAD0 | overloaded x5
        public void .cctor(){} // RVA: 0x7FFE86AFEC50
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7FFE86B13180
        public void ReturnBuffer(){} // RVA: 0x7FFE86B13200
        public void EnsureBufferSize(){} // RVA: 0x7FFE86B13260
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFE80E2F230
        public void AddRange(){} // RVA: 0x7FFE80E462E0
        public void IsDictionaryType(){} // RVA: 0x7FFE86AFFCD0
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFE86B00080 | overloaded x2
        public void AddDistinct(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void AddRangeDistinct(){} // RVA: 0x7FFE80E329F0
        public void IndexOf(){} // RVA: 0x7FFE80E33B80
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void IndexOfReference(){} // RVA: 0x7FFE810A1420
        public void FastReverse(){} // RVA: 0x7FFE80E46070
        public void GetDimensions(){} // RVA: 0x7FFE86B00360
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFE86B00720
        public void JaggedArrayGetValue(){} // RVA: 0x7FFE86B009C0
        public void ToMultidimensionalArray(){} // RVA: 0x7FFE86B00AC0
        public void ArrayEmpty(){} // RVA: 0x7FFE80E2DEE0
    }

    public class CollectionWrapper`1 : Object
    {
        public System.Collections.IList _list;
        public System.Collections.Generic.ICollection`1<T> _genericCollection;
        public object _syncRoot;
        public object field_3; // 0xAD
        public object field_4; // 0xAE
        public object field_5; // 0xAF
        public object field_6; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
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
        public void GetTypeCode(){} // RVA: 0x7FFE86B00D60 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x7FFE86B010E0
        public void IsConvertible(){} // RVA: 0x7FFE86B01190
        public void ParseTimeSpan(){} // RVA: 0x7FFE86B01270
        public void CreateCastConverter(){} // RVA: 0x7FFE86B013B0
        public void ToBigInteger(){} // RVA: 0x7FFE86B01680
        public void FromBigInteger(){} // RVA: 0x7FFE86B01C00
        public void Convert(){} // RVA: 0x7FFE86B021D0
        public void TryConvert(){} // RVA: 0x7FFE86B02480
        public void TryConvertInternal(){} // RVA: 0x7FFE86B02570
        public void ConvertOrCast(){} // RVA: 0x7FFE86B03110
        public void EnsureTypeAssignable(){} // RVA: 0x7FFE86B032D0
        public void VersionTryParse(){} // RVA: 0x7FFE86B03540
        public void IsInteger(){} // RVA: 0x7FFE86B03550
        public void Int32TryParse(){} // RVA: 0x7FFE86B03670
        public void Int64TryParse(){} // RVA: 0x7FFE86B037D0
        public void DecimalTryParse(){} // RVA: 0x7FFE86B03920
        public void TryConvertGuid(){} // RVA: 0x7FFE86B04660
        public void TryHexTextToInt(){} // RVA: 0x7FFE86B046B0
        public void .cctor(){} // RVA: 0x7FFE86B04750
    }

    public class Creator`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE80E3FC10
        public void EndInvoke(){} // RVA: 0x7FFE810A1420
    }

    public class DateTimeParser : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86B06AE0
        public void Parse(){} // RVA: 0x7FFE86B06E70
        public void ParseDate(){} // RVA: 0x7FFE86B06FD0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7FFE86B07290
        public void ParseTime(){} // RVA: 0x7FFE86B07320
        public void ParseZone(){} // RVA: 0x7FFE86B076E0
        public void Parse4Digit(){} // RVA: 0x7FFE86B07910
        public void Parse2Digit(){} // RVA: 0x7FFE86B079F0
        public void ParseChar(){} // RVA: 0x7FFE86B07A60
    }

    public class DateTimeUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86B07AA0
        public void GetUtcOffset(){} // RVA: 0x7FFE86B07C60
        public void ToSerializationMode(){} // RVA: 0x7FFE86B07CD0
        public void EnsureDateTime(){} // RVA: 0x7FFE86B07D80
        public void SwitchToLocalTime(){} // RVA: 0x7FFE86B08180
        public void SwitchToUtcTime(){} // RVA: 0x7FFE86B08310
        public void ToUniversalTicks(){} // RVA: 0x7FFE86B085A0 | overloaded x2
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7FFE86B08890 | overloaded x3
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x7FFE86B08A50
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7FFE86B08AD0
        public void TryParseDateTimeIso(){} // RVA: 0x7FFE86B08B60
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7FFE86B09250
        public void CreateDateTime(){} // RVA: 0x7FFE86B095D0
        public void TryParseDateTime(){} // RVA: 0x7FFE86B09AE0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFE86B0A2B0 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7FFE86B0A7B0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7FFE86B0A9D0
        public void TryParseDateTimeExact(){} // RVA: 0x7FFE86B0ABB0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7FFE86B0ACA0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7FFE86B0AE80
        public void TryReadOffset(){} // RVA: 0x7FFE86B0AF30
        public void WriteDateTimeString(){} // RVA: 0x7FFE86B0B430 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7FFE86B0B7B0
        public void CopyIntToCharArray(){} // RVA: 0x7FFE86B0BD10
        public void WriteDateTimeOffset(){} // RVA: 0x7FFE86B0BDA0
        public void WriteDateTimeOffsetString(){} // RVA: 0x7FFE86B0C060
        public void GetDateValues(){} // RVA: 0x7FFE86B0C2D0
    }

    public class DictionaryWrapper`2 : Object
    {
        public System.Collections.IDictionary _dictionary;
        public System.Collections.Generic.IDictionary`2<U,T> _genericDictionary;
        public System.Collections.Generic.IReadOnlyDictionary`2<U,T> _readOnlyDictionary;
        public object _syncRoot;
        public object field_4; // 0xB7
        public object field_5; // 0xB8
        public object field_6; // 0xB9
        public object field_7; // 0xBA
        public object field_8; // 0xBB
        public object field_9; // 0xBC
        public object field_10; // 0xBD
        public object field_11; // 0xBE
        public object field_12; // 0xBF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void get_GenericDictionary(){} // RVA: 0x7FFE80E2E2E0
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

    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        public Newtonsoft.Json.Utilities.DynamicProxy`1<T> _proxy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void IsOverridden(){} // RVA: 0x7FFE80E2F3B0
        public void BindGetMember(){} // RVA: 0x7FFE80E2E390
        public void BindSetMember(){} // RVA: 0x7FFE80E3FC10
        public void BindDeleteMember(){} // RVA: 0x7FFE80E2E390
        public void BindConvert(){} // RVA: 0x7FFE80E2E390
        public void BindInvokeMember(){} // RVA: 0x7FFE80E3FC10
        public void BindCreateInstance(){} // RVA: 0x7FFE80E3FC10
        public void BindInvoke(){} // RVA: 0x7FFE80E3FC10
        public void BindBinaryOperation(){} // RVA: 0x7FFE80E3FC10
        public void BindUnaryOperation(){} // RVA: 0x7FFE80E2E390
        public void BindGetIndex(){} // RVA: 0x7FFE80E3FC10
        public void BindSetIndex(){} // RVA: 0x7FFE80E403A0
        public void BindDeleteIndex(){} // RVA: 0x7FFE80E3FC10
        public void get_NoArgs(){} // RVA: 0x7FFE80E2DEE0
        public void GetArgs(){} // RVA: 0x7FFE80E2E3D0
        public void GetArgArray(){} // RVA: 0x7FFE80E2E440 | overloaded x2
        public void Constant(){} // RVA: 0x7FFE80E2E3D0
        public void CallMethodWithResult(){} // RVA: 0x7FFE80E407D0
        public void BuildCallMethodWithResult(){} // RVA: 0x7FFE80E407D0
        public void CallMethodReturnLast(){} // RVA: 0x7FFE80E40660
        public void CallMethodNoResult(){} // RVA: 0x7FFE80E40660
        public void GetRestrictions(){} // RVA: 0x7FFE80E2E2E0
        public void GetDynamicMemberNames(){} // RVA: 0x7FFE80E2E2E0
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFE810A1420
        public void TryBinaryOperation(){} // RVA: 0x7FFE810A1420
        public void TryConvert(){} // RVA: 0x7FFE810A1420
        public void TryCreateInstance(){} // RVA: 0x7FFE810A1420
        public void TryDeleteIndex(){} // RVA: 0x7FFE810A1420
        public void TryDeleteMember(){} // RVA: 0x7FFE810A1420
        public void TryGetIndex(){} // RVA: 0x7FFE810A1420
        public void TryGetMember(){} // RVA: 0x7FFE810A1420
        public void TryInvoke(){} // RVA: 0x7FFE810A1420
        public void TryInvokeMember(){} // RVA: 0x7FFE810A1420
        public void TrySetIndex(){} // RVA: 0x7FFE810A1420
        public void TrySetMember(){} // RVA: 0x7FFE810A1420
        public void TryUnaryOperation(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class DynamicUtils : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFE86B0C4F0
    }

    public class EnumInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B0E2C0
    }

    public class EnumUtils : Object
    {
        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x7FFE86B0E3C0
        public void GetFlagsValues(){} // RVA: 0x7FFE810A1420
        public void TryToString(){} // RVA: 0x7FFE86B0EB60 | overloaded x2
        public void InternalFlagsFormat(){} // RVA: 0x7FFE86B0EE70
        public void GetEnumValuesAndNames(){} // RVA: 0x7FFE86B0F020
        public void ToUInt64(){} // RVA: 0x7FFE86B0F1A0
        public void ParseEnum(){} // RVA: 0x7FFE86B0F550
        public void MatchName(){} // RVA: 0x7FFE86B0FE50
        public void FindIndexByName(){} // RVA: 0x7FFE86B0FF40
        public void .cctor(){} // RVA: 0x7FFE86B10030
    }

    public class FSharpFunction : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void Invoke(){} // RVA: 0x7FFE86B102A0
    }

    public class FSharpUtils : Object
    {
        public object Lock;
        public Newtonsoft.Json.Utilities.FSharpUtils _instance; // 0x8
        public System.Reflection.MethodInfo _ofSeq; // 0x10
        public System.Type _mapType; // 0x18
        public System.Reflection.Assembly _fSharpCoreAssembly; // 0x20
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _isUnion; // 0x28
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _getUnionCases; // 0x30
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _preComputeUnionTagReader; // 0x38
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _preComputeUnionReader; // 0x40
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _preComputeUnionConstructor; // 0x48
        public System.Func`2<object,object> _getUnionCaseInfoDeclaringType; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B102D0
        public void get_Instance(){} // RVA: 0x7FFE86B10EA0
        public void get_FSharpCoreAssembly(){} // RVA: 0x7FFE811290C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x7FFE811290D0
        public void get_IsUnion(){} // RVA: 0x7FFE81129130
        public void set_IsUnion(){} // RVA: 0x7FFE810FCE90
        public void get_GetUnionCases(){} // RVA: 0x7FFE8144E200
        public void set_GetUnionCases(){} // RVA: 0x7FFE81129890
        public void get_PreComputeUnionTagReader(){} // RVA: 0x7FFE8143BA80
        public void set_PreComputeUnionTagReader(){} // RVA: 0x7FFE81437330
        public void get_PreComputeUnionReader(){} // RVA: 0x7FFE81178740
        public void set_PreComputeUnionReader(){} // RVA: 0x7FFE81123200
        public void get_PreComputeUnionConstructor(){} // RVA: 0x7FFE81176730
        public void set_PreComputeUnionConstructor(){} // RVA: 0x7FFE81176740
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFE8119C0E0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFE812534D0
        public void get_GetUnionCaseInfoName(){} // RVA: 0x7FFE811C3500
        public void set_GetUnionCaseInfoName(){} // RVA: 0x7FFE811C3510
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x7FFE81199370
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x7FFE81199380
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x7FFE81176D50
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x7FFE81176D60
        public void EnsureInitialized(){} // RVA: 0x7FFE86B10F00
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x7FFE86B11170
        public void CreateFSharpFuncCall(){} // RVA: 0x7FFE86B11280
        public void CreateSeq(){} // RVA: 0x7FFE86B11620
        public void CreateMap(){} // RVA: 0x7FFE86B11730
        public void BuildMapCreator(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE86B11A00
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

    public class ImmutableCollectionsUtils : Object
    {
        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x7FFE86B11BF0
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x7FFE86B121E0
        public void .cctor(){} // RVA: 0x7FFE86B12840
    }

    public class JavaScriptUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86B13310
        public void GetCharEscapeFlags(){} // RVA: 0x7FFE86B13ED0
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7FFE86B13FA0
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7FFE86B14020
        public void ToEscapedJavaScriptString(){} // RVA: 0x7FFE86B14960
        public void FirstCharToEscape(){} // RVA: 0x7FFE86B14B10
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x7FFE86B14BD0
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x7FFE86B15140 | overloaded x2
        public void WriteCharAsync(){} // RVA: 0x7FFE86B15520
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFE86B157B0
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFE86B15970
        public void TryGetDateFromConstructorJson(){} // RVA: 0x7FFE86B15CF0
        public void TryGetDateConstructorValue(){} // RVA: 0x7FFE86B161D0
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
        public Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86B17CE0
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFE86B17D40
        public void CreateMethodCall(){} // RVA: 0x7FFE80E2E390
        public void CreateDefaultConstructor(){} // RVA: 0x7FFE80E2E390
        public void CreateGet(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86B17F70
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7FFE86B180B0
        public void IntToHex(){} // RVA: 0x7FFE86B18210
        public void Min(){} // RVA: 0x7FFE86B18220
        public void Max(){} // RVA: 0x7FFE86B183E0 | overloaded x2
        public void ApproxEquals(){} // RVA: 0x7FFE86B18500
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE810A1420
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFE810FB310
        public void ValueEquals(){} // RVA: 0x7FFE86B185D0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFE86B18920
        public void ToString(){} // RVA: 0x7FFE86B18A50
        public void ByteArrayCompare(){} // RVA: 0x7FFE86B18B00
        public void GetPrefix(){} // RVA: 0x7FFE86B18BA0
        public void GetLocalName(){} // RVA: 0x7FFE86B18BD0
        public void GetQualifiedNameParts(){} // RVA: 0x7FFE86B18C00
        public void GetRegexOptions(){} // RVA: 0x7FFE86B18D60
    }

    public class NoThrowExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x7FFE86B0DFB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86B0E210
    }

    public class NoThrowGetBinderMember : GetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B0DB10
        public void FallbackGetMember(){} // RVA: 0x7FFE86B0DBA0
    }

    public class NoThrowSetBinderMember : SetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B0DCB0
        public void FallbackSetMember(){} // RVA: 0x7FFE86B0DE50
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
        public void get_Setter(){} // RVA: 0x7FFE811290C0
        public void set_Setter(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReflectionObject : Object
    {
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _creator; // 0x10
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Utilities.ReflectionMember> _members; // 0x18

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFE81116380
        public void get_Members(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86B18E10
        public void GetValue(){} // RVA: 0x7FFE86B18F30
        public void SetValue(){} // RVA: 0x7FFE86B18FB0
        public void GetType(){} // RVA: 0x7FFE86B19040
        public void Create(){} // RVA: 0x7FFE86B190B0 | overloaded x2
    }

    public class ReflectionUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86B19B60
        public void IsVirtual(){} // RVA: 0x7FFE86B19C30
        public void GetBaseDefinition(){} // RVA: 0x7FFE86B19D40
        public void IsPublic(){} // RVA: 0x7FFE86B19E50
        public void GetObjectType(){} // RVA: 0x7FFE86B19EF0
        public void GetTypeName(){} // RVA: 0x7FFE86B19F10
        public void GetFullyQualifiedTypeName(){} // RVA: 0x7FFE86B19FE0
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFE86B1A2D0
        public void HasDefaultConstructor(){} // RVA: 0x7FFE86B1A440
        public void GetDefaultConstructor(){} // RVA: 0x7FFE86B1A600 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFE86B1A7A0
        public void IsNullableType(){} // RVA: 0x7FFE86B1A880
        public void EnsureNotNullableType(){} // RVA: 0x7FFE86B1A990
        public void EnsureNotByRefType(){} // RVA: 0x7FFE86B1AA00
        public void IsGenericDefinition(){} // RVA: 0x7FFE86B1AA70
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFE86B1AB90 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFE86B1AF10 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFE86B1B260
        public void GetCollectionItemType(){} // RVA: 0x7FFE86B1B3F0
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFE86B1B730
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFE86B1BBC0
        public void IsByRefLikeType(){} // RVA: 0x7FFE86B1BE80
        public void IsIndexedProperty(){} // RVA: 0x7FFE86B1C020
        public void GetMemberValue(){} // RVA: 0x7FFE86B1C0D0
        public void SetMemberValue(){} // RVA: 0x7FFE86B1C420
        public void CanReadMemberValue(){} // RVA: 0x7FFE86B1C6B0
        public void CanSetMemberValue(){} // RVA: 0x7FFE86B1C820
        public void GetFieldsAndProperties(){} // RVA: 0x7FFE86B1C9E0
        public void IsOverridenGenericMember(){} // RVA: 0x7FFE86B1D250
        public void GetAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFE86B1D470 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFE86B1D8F0
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFE86B1DAA0
        public void GetMemberInfoFromType(){} // RVA: 0x7FFE86B1DB60
        public void GetFields(){} // RVA: 0x7FFE86B1DF90
        public void GetChildPrivateFields(){} // RVA: 0x7FFE86B1E0E0
        public void GetProperties(){} // RVA: 0x7FFE86B1E2F0
        public void RemoveFlag(){} // RVA: 0x7FFE86B1E670
        public void GetChildPrivateProperties(){} // RVA: 0x7FFE86B1E690
        public void IsMethodOverridden(){} // RVA: 0x7FFE86B1EAB0
        public void GetDefaultValue(){} // RVA: 0x7FFE86B1EC60
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
        public void Append(){} // RVA: 0x7FFE86B1F8C0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE86B1F940
        public void EnsureSize(){} // RVA: 0x7FFE86B1FA10
        public void ToString(){} // RVA: 0x7FFE86B1FC20 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x7FFE8284EF60
    }

    public class StringReference : ValueType
    {
        public char[] _chars; // 0x10
        public int _startIndex; // 0x18
        public int _length; // 0x1C
        public object field_3; // 0x80

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
        public void IndexOf(){} // RVA: 0x7FFE86B1FC80
        public void StartsWith(){} // RVA: 0x7FFE86B1FD10
        public void EndsWith(){} // RVA: 0x7FFE86B1FDA0
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFE86B1FE30
        public void FormatWith(){} // RVA: 0x7FFE86B205B0 | overloaded x5
        public void IsWhiteSpace(){} // RVA: 0x7FFE86B206F0
        public void CreateStringWriter(){} // RVA: 0x7FFE86B207F0
        public void ToCharAsUnicode(){} // RVA: 0x7FFE86B20900
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFE810A1420
        public void ToCamelCase(){} // RVA: 0x7FFE86B209E0
        public void ToLower(){} // RVA: 0x7FFE86B20BD0
        public void ToSnakeCase(){} // RVA: 0x7FFE86B20D20
        public void ToKebabCase(){} // RVA: 0x7FFE86B20D30
        public void ToSeparatedCase(){} // RVA: 0x7FFE86B20D40
        public void IsHighSurrogate(){} // RVA: 0x7FFE86B210C0
        public void IsLowSurrogate(){} // RVA: 0x7FFE86B21130
        public void IndexOf(){} // RVA: 0x7FFE86B211A0
        public void Replace(){} // RVA: 0x7FFE86B211D0
        public void StartsWith(){} // RVA: 0x7FFE86B211F0
        public void EndsWith(){} // RVA: 0x7FFE86B21220
        public void Trim(){} // RVA: 0x7FFE86B21270
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Get(){} // RVA: 0x7FFE810A1420
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x7FFE86B214E0
        public void MemberType(){} // RVA: 0x7FFE86B21510
        public void ContainsGenericParameters(){} // RVA: 0x7FFE86B21540
        public void IsInterface(){} // RVA: 0x7FFE86B21570
        public void IsGenericType(){} // RVA: 0x7FFE86B21590
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFE86B215C0
        public void BaseType(){} // RVA: 0x7FFE86B215F0
        public void Assembly(){} // RVA: 0x7FFE86B21620
        public void IsEnum(){} // RVA: 0x7FFE86B21650
        public void IsClass(){} // RVA: 0x7FFE86B21680
        public void IsSealed(){} // RVA: 0x7FFE86B216E0
        public void IsAbstract(){} // RVA: 0x7FFE86B21710
        public void IsVisible(){} // RVA: 0x7FFE86B21740
        public void IsValueType(){} // RVA: 0x7FFE86B21760
        public void IsPrimitive(){} // RVA: 0x7FFE86B21790
        public void AssignableToTypeName(){} // RVA: 0x7FFE86B21A40 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7FFE86B21A60
    }

    public class TypeInformation : Object
    {
        public System.Type _type; // 0x10
        public 0x665BFA7C _typeCode; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_TypeCode(){} // RVA: 0x7FFE813DB630
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7FFE86B21CB0
    }

}