// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 65
// Methods: 546

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper : Object
    {
        // ── Methods ──
        public void Ensure(){} // RVA: 0x7ADDA7D80
        public void EnsureType(){} // RVA: 0x7A7E187D0
        public void EnsureList(){} // RVA: 0x7A7E187D0
        public void EnsureDictionary(){} // RVA: 0x7A7E187D0
        public void IsFalse(){} // RVA: 0x7ADDA7EA0
        public void .cctor(){} // RVA: 0x7ADDA7F00
    }

    public class AsyncUtils : Object
    {
        // ── Methods ──
        public void ToAsync(){} // RVA: 0x7ADDA7FC0
        public void CancelIfRequestedAsync(){} // RVA: 0x7A7E0FB00
        public void FromCanceled(){} // RVA: 0x7A7E0FB00
        public void WriteAsync(){} // RVA: 0x7ADDA8490
        public void ReadAsync(){} // RVA: 0x7ADDA8580
        public void IsCompletedSuccessfully(){} // RVA: 0x7ADDA8690
        public void .cctor(){} // RVA: 0x7ADDA8740
    }

    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADDA8A70
        public void ValidateEncode(){} // RVA: 0x7ADDA8BD0
        public void Encode(){} // RVA: 0x7ADDA8D30
        public void StoreLeftOverBytes(){} // RVA: 0x7ADDA8F50
        public void FulfillFromLeftover(){} // RVA: 0x7ADDA90A0
        public void Flush(){} // RVA: 0x7ADDA9160
        public void WriteChars(){} // RVA: 0x7ADDA9240
        public void EncodeAsync(){} // RVA: 0x7ADDA9270
        public void WriteCharsAsync(){} // RVA: 0x7ADDA9510
        public void FlushAsync(){} // RVA: 0x7ADDA95A0
    }

    public class BidirectionalDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DB70
        public void Set(){} // RVA: 0x7A8051B10
        public void TryGetByFirst(){} // RVA: 0x7A8051B10
        public void TryGetBySecond(){} // RVA: 0x7A8051B10
    }

    public class BoxedPrimitives : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7ADDAA340
        public void .cctor(){} // RVA: 0x7ADDAA4C0
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7ADDBEBC0
        public void ReturnBuffer(){} // RVA: 0x7ADDBEC40
        public void EnsureBufferSize(){} // RVA: 0x7ADDBECA0
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7AA40DEC0
        public void AddRange(){} // RVA: 0x7AA40C0C0
        public void IsDictionaryType(){} // RVA: 0x7ADDAB540
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7ADDAB8F0
        public void AddDistinct(){} // RVA: 0x7A8051B10
        public void ContainsValue(){} // RVA: 0x7A8051B10
        public void AddRangeDistinct(){} // RVA: 0x7A7E05210
        public void IndexOf(){} // RVA: 0x7AA40D880
        public void Contains(){} // RVA: 0x7AA40CC30
        public void IndexOfReference(){} // RVA: 0x7A8051B10
        public void FastReverse(){} // RVA: 0x7A7E18830
        public void GetDimensions(){} // RVA: 0x7ADDABBD0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7ADDABF90
        public void JaggedArrayGetValue(){} // RVA: 0x7ADDAC240
        public void ToMultidimensionalArray(){} // RVA: 0x7ADDAC340
        public void ArrayEmpty(){} // RVA: 0x7A814DAD0
    }

    public class CollectionWrapper`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
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

    public class CollectionWrapper`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD545AD0
        public void Add(){} // RVA: 0x7AD545BB0
        public void Clear(){} // RVA: 0x7AD545D20
        public void Contains(){} // RVA: 0x7AD545DD0
        public void CopyTo(){} // RVA: 0x7AD545F40
        public void get_Count(){} // RVA: 0x7AD546000
        public void get_IsReadOnly(){} // RVA: 0x7AD5460B0
        public void Remove(){} // RVA: 0x7AD546160
        public void GetEnumerator(){} // RVA: 0x7AD546350
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD5463D0
        public void System.Collections.IList.Add(){} // RVA: 0x7AD546430
        public void System.Collections.IList.Contains(){} // RVA: 0x7AD546620
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7AD546810
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7AD546A50
        public void System.Collections.IList.Insert(){} // RVA: 0x7AD546B00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7AD546D40
        public void System.Collections.IList.Remove(){} // RVA: 0x7AD546DF0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AD546FC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AD547070
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AD5472B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AD547350
        public void VerifyValueType(){} // RVA: 0x7AD547400
        public void IsCompatibleObject(){} // RVA: 0x7AD547550
        public void get_UnderlyingCollection(){} // RVA: 0x7AD5476E0
    }

    public class CollectionWrapper`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD545AD0
        public void Add(){} // RVA: 0x7AD545BB0
        public void Clear(){} // RVA: 0x7AD545D20
        public void Contains(){} // RVA: 0x7AD545DD0
        public void CopyTo(){} // RVA: 0x7AD545F40
        public void get_Count(){} // RVA: 0x7AD546000
        public void get_IsReadOnly(){} // RVA: 0x7AD5460B0
        public void Remove(){} // RVA: 0x7AD546160
        public void GetEnumerator(){} // RVA: 0x7AD546350
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD5463D0
        public void System.Collections.IList.Add(){} // RVA: 0x7AD546430
        public void System.Collections.IList.Contains(){} // RVA: 0x7AD546620
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7AD546810
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7AD546A50
        public void System.Collections.IList.Insert(){} // RVA: 0x7AD546B00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7AD546D40
        public void System.Collections.IList.Remove(){} // RVA: 0x7AD546DF0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AD546FC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AD547070
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AD5472B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AD547350
        public void VerifyValueType(){} // RVA: 0x7AD547400
        public void IsCompatibleObject(){} // RVA: 0x7AD547550
        public void get_UnderlyingCollection(){} // RVA: 0x7AD5476E0
    }

    public class ConvertUtils : Object
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7ADDAC5E0
        public void GetTypeInformation(){} // RVA: 0x7ADDAC960
        public void IsConvertible(){} // RVA: 0x7ADDACA10
        public void ParseTimeSpan(){} // RVA: 0x7ADDACAF0
        public void CreateCastConverter(){} // RVA: 0x7ADDACC30
        public void ToBigInteger(){} // RVA: 0x7ADDACF00
        public void FromBigInteger(){} // RVA: 0x7ADDAD480
        public void Convert(){} // RVA: 0x7ADDADA50
        public void TryConvert(){} // RVA: 0x7ADDADD00
        public void TryConvertInternal(){} // RVA: 0x7ADDADDF0
        public void ConvertOrCast(){} // RVA: 0x7ADDAE990
        public void EnsureTypeAssignable(){} // RVA: 0x7ADDAEB50
        public void VersionTryParse(){} // RVA: 0x7ADDAEDC0
        public void IsInteger(){} // RVA: 0x7ADDAEDD0
        public void Int32TryParse(){} // RVA: 0x7ADDAEEF0
        public void Int64TryParse(){} // RVA: 0x7ADDAF090
        public void DecimalTryParse(){} // RVA: 0x7ADDAF220
        public void TryConvertGuid(){} // RVA: 0x7ADDAFF90
        public void TryHexTextToInt(){} // RVA: 0x7ADDAFFE0
        public void .cctor(){} // RVA: 0x7ADDB0090
    }

    public class Creator`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
        public void BeginInvoke(){} // RVA: 0x7A7E00BD0
        public void EndInvoke(){} // RVA: 0x7A8051B10
    }

    public class DateTimeParser : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADDB2420
        public void Parse(){} // RVA: 0x7A7E47480
        public void ParseDate(){} // RVA: 0x7A7E47490
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7A7E474A0
        public void ParseTime(){} // RVA: 0x7A7E474B0
        public void ParseZone(){} // RVA: 0x7A7E474C0
        public void Parse4Digit(){} // RVA: 0x7A7E474D0
        public void Parse2Digit(){} // RVA: 0x7A7E474E0
        public void ParseChar(){} // RVA: 0x7A7E474F0
    }

    public class DateTimeUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADDB3430
        public void GetUtcOffset(){} // RVA: 0x7ADDB35F0
        public void ToSerializationMode(){} // RVA: 0x7ADDB3660
        public void EnsureDateTime(){} // RVA: 0x7ADDB3710
        public void SwitchToLocalTime(){} // RVA: 0x7ADDB3B10
        public void SwitchToUtcTime(){} // RVA: 0x7ADDB3CA0
        public void ToUniversalTicks(){} // RVA: 0x7ADDB3F30
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7ADDB4220
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x7ADDB43E0
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7ADDB4460
        public void TryParseDateTimeIso(){} // RVA: 0x7ADDB44F0
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7ADDB4BE0
        public void CreateDateTime(){} // RVA: 0x7ADDB4F60
        public void TryParseDateTime(){} // RVA: 0x7ADDB5480
        public void TryParseDateTimeOffset(){} // RVA: 0x7ADDB5C60
        public void TryParseMicrosoftDate(){} // RVA: 0x7ADDB6160
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7ADDB6390
        public void TryParseDateTimeExact(){} // RVA: 0x7ADDB6570
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7ADDB6660
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7ADDB6840
        public void TryReadOffset(){} // RVA: 0x7ADDB68F0
        public void WriteDateTimeString(){} // RVA: 0x7ADDB6DA0
        public void WriteDefaultIsoDate(){} // RVA: 0x7ADDB7120
        public void CopyIntToCharArray(){} // RVA: 0x7ADDB76C0
        public void WriteDateTimeOffset(){} // RVA: 0x7ADDB7770
        public void WriteDateTimeOffsetString(){} // RVA: 0x7ADDB7A60
        public void GetDateValues(){} // RVA: 0x7ADDB7CD0
    }

    public class DictionaryWrapper`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_GenericDictionary(){} // RVA: 0x7A7E00680
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

    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void IsOverridden(){} // RVA: 0x7A7E019D0
        public void BindGetMember(){} // RVA: 0x7A7E00B20
        public void BindSetMember(){} // RVA: 0x7A7E00BD0
        public void BindDeleteMember(){} // RVA: 0x7A7E00B20
        public void BindConvert(){} // RVA: 0x7A7E00B20
        public void BindInvokeMember(){} // RVA: 0x7A7E00BD0
        public void BindCreateInstance(){} // RVA: 0x7A7E00BD0
        public void BindInvoke(){} // RVA: 0x7A7E00BD0
        public void BindBinaryOperation(){} // RVA: 0x7A7E00BD0
        public void BindUnaryOperation(){} // RVA: 0x7A7E00B20
        public void BindGetIndex(){} // RVA: 0x7A7E00BD0
        public void BindSetIndex(){} // RVA: 0x7A7E06710
        public void BindDeleteIndex(){} // RVA: 0x7A7E00BD0
        public void get_NoArgs(){} // RVA: 0x7A7E006B0
        public void GetArgs(){} // RVA: 0x7A7E00BA0
        public void GetArgArray(){} // RVA: 0x7A7E00C10
        public void Constant(){} // RVA: 0x7A7E00BA0
        public void CallMethodWithResult(){} // RVA: 0x7A7E12F50
        public void BuildCallMethodWithResult(){} // RVA: 0x7A7E12F50
        public void CallMethodReturnLast(){} // RVA: 0x7A7E12DE0
        public void CallMethodNoResult(){} // RVA: 0x7A7E12DE0
        public void GetRestrictions(){} // RVA: 0x7A7E00680
        public void GetDynamicMemberNames(){} // RVA: 0x7A7E00680
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7A8051B10
        public void TryBinaryOperation(){} // RVA: 0x7A8051B10
        public void TryConvert(){} // RVA: 0x7A8051B10
        public void TryCreateInstance(){} // RVA: 0x7A8051B10
        public void TryDeleteIndex(){} // RVA: 0x7A8051B10
        public void TryDeleteMember(){} // RVA: 0x7A8051B10
        public void TryGetIndex(){} // RVA: 0x7A8051B10
        public void TryGetMember(){} // RVA: 0x7A8051B10
        public void TryInvoke(){} // RVA: 0x7A8051B10
        public void TryInvokeMember(){} // RVA: 0x7A8051B10
        public void TrySetIndex(){} // RVA: 0x7A8051B10
        public void TrySetMember(){} // RVA: 0x7A8051B10
        public void TryUnaryOperation(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7AAC6C6D0
        public void TryBinaryOperation(){} // RVA: 0x7AAC6C710
        public void TryConvert(){} // RVA: 0x7AAC6C770
        public void TryCreateInstance(){} // RVA: 0x7AAC6C710
        public void TryDeleteIndex(){} // RVA: 0x7A80D7320
        public void TryDeleteMember(){} // RVA: 0x7A80D7320
        public void TryGetIndex(){} // RVA: 0x7AAC6C710
        public void TryGetMember(){} // RVA: 0x7AAC6C770
        public void TryInvoke(){} // RVA: 0x7AAC6C710
        public void TryInvokeMember(){} // RVA: 0x7AAC6C710
        public void TrySetIndex(){} // RVA: 0x7A80D7320
        public void TrySetMember(){} // RVA: 0x7A80D7320
        public void TryUnaryOperation(){} // RVA: 0x7AAC6C770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7AAC6C6D0
        public void TryBinaryOperation(){} // RVA: 0x7AAC6C710
        public void TryConvert(){} // RVA: 0x7AAC6C770
        public void TryCreateInstance(){} // RVA: 0x7AAC6C710
        public void TryDeleteIndex(){} // RVA: 0x7A80D7320
        public void TryDeleteMember(){} // RVA: 0x7A80D7320
        public void TryGetIndex(){} // RVA: 0x7AAC6C710
        public void TryGetMember(){} // RVA: 0x7AAC6C770
        public void TryInvoke(){} // RVA: 0x7AAC6C710
        public void TryInvokeMember(){} // RVA: 0x7AAC6C710
        public void TrySetIndex(){} // RVA: 0x7A80D7320
        public void TrySetMember(){} // RVA: 0x7A80D7320
        public void TryUnaryOperation(){} // RVA: 0x7AAC6C770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DynamicUtils : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7ADDB7F00
    }

    public class EnumInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADDB9CD0
    }

    public class EnumUtils : Object
    {
        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x7ADDB9DD0
        public void GetFlagsValues(){} // RVA: 0x7A8051B10
        public void TryToString(){} // RVA: 0x7ADDBA590
        public void InternalFlagsFormat(){} // RVA: 0x7ADDBA8C0
        public void GetEnumValuesAndNames(){} // RVA: 0x7ADDBAA70
        public void ToUInt64(){} // RVA: 0x7ADDBABF0
        public void ParseEnum(){} // RVA: 0x7ADDBAFA0
        public void MatchName(){} // RVA: 0x7ADDBB8A0
        public void FindIndexByName(){} // RVA: 0x7ADDBB990
        public void .cctor(){} // RVA: 0x7ADDBBA90
    }

    public class FSharpFunction : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Invoke(){} // RVA: 0x7ADDBBD00
    }

    public class FSharpUtils : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADDBBD30
        public void get_Instance(){} // RVA: 0x7ADDBC900
        public void get_FSharpCoreAssembly(){} // RVA: 0x7A81052C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x7A81052D0
        public void get_IsUnion(){} // RVA: 0x7A8105330
        public void set_IsUnion(){} // RVA: 0x7A80D8E80
        public void get_GetUnionCases(){} // RVA: 0x7A83F69F0
        public void set_GetUnionCases(){} // RVA: 0x7A8105A90
        public void get_PreComputeUnionTagReader(){} // RVA: 0x7A8292C30
        public void set_PreComputeUnionTagReader(){} // RVA: 0x7A8296DE0
        public void get_PreComputeUnionReader(){} // RVA: 0x7A8154D80
        public void set_PreComputeUnionReader(){} // RVA: 0x7A80FF440
        public void get_PreComputeUnionConstructor(){} // RVA: 0x7A8152D80
        public void set_PreComputeUnionConstructor(){} // RVA: 0x7A8152D90
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7A8178B90
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7A8230620
        public void get_GetUnionCaseInfoName(){} // RVA: 0x7A81A0050
        public void set_GetUnionCaseInfoName(){} // RVA: 0x7A81A0060
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x7A8175DF0
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x7A8175E00
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x7A8153390
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x7A81533A0
        public void EnsureInitialized(){} // RVA: 0x7ADDBC960
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x7ADDBCBA0
        public void CreateFSharpFuncCall(){} // RVA: 0x7ADDBCCB0
        public void CreateSeq(){} // RVA: 0x7ADDBD060
        public void CreateMap(){} // RVA: 0x7ADDBD170
        public void BuildMapCreator(){} // RVA: 0x7A7E00680
        public void .cctor(){} // RVA: 0x7ADDBD440
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

    public class ImmutableCollectionsUtils : Object
    {
        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x7ADDBD630
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x7ADDBDC20
        public void .cctor(){} // RVA: 0x7ADDBE280
    }

    public class JavaScriptUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADDBED50
        public void GetCharEscapeFlags(){} // RVA: 0x7ADDBF930
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7ADDBFA00
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7ADDBFA80
        public void ToEscapedJavaScriptString(){} // RVA: 0x7ADDC03D0
        public void FirstCharToEscape(){} // RVA: 0x7ADDC0590
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x7ADDC0650
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x7ADDC0BC0
        public void WriteCharAsync(){} // RVA: 0x7ADDC0FB0
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7ADDC1240
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7ADDC1400
        public void TryGetDateFromConstructorJson(){} // RVA: 0x7ADDC1790
        public void TryGetDateConstructorValue(){} // RVA: 0x7ADDC1C70
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
        public void get_Instance(){} // RVA: 0x7ADDC3790
        public void CreateParameterizedConstructor(){} // RVA: 0x7ADDC37F0
        public void CreateMethodCall(){} // RVA: 0x7A7E00B20
        public void CreateDefaultConstructor(){} // RVA: 0x7AA50A000
        public void CreateGet(){} // RVA: 0x7A7E00B20
        public void CreateSet(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADDC3A20
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7ADDC3B60
        public void IntToHex(){} // RVA: 0x7ADDC3CC0
        public void Min(){} // RVA: 0x7ADDC3CD0
        public void Max(){} // RVA: 0x7ADDC3E90
        public void ApproxEquals(){} // RVA: 0x7ADDC3FB0
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
        public void BeginInvoke(){} // RVA: 0x7A8051B10
        public void EndInvoke(){} // RVA: 0x7A8051B10
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7A80D7310
        public void ValueEquals(){} // RVA: 0x7ADDC4080
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7ADDC43D0
        public void ToString(){} // RVA: 0x7ADDC4500
        public void ByteArrayCompare(){} // RVA: 0x7ADDC45B0
        public void GetPrefix(){} // RVA: 0x7ADDC4650
        public void GetLocalName(){} // RVA: 0x7ADDC4680
        public void GetQualifiedNameParts(){} // RVA: 0x7ADDC46B0
        public void GetRegexOptions(){} // RVA: 0x7ADDC4810
    }

    public class NoThrowExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x7ADDB99C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADDB9C20
    }

    public class NoThrowGetBinderMember : GetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADDB9520
        public void FallbackGetMember(){} // RVA: 0x7ADDB95B0
    }

    public class NoThrowSetBinderMember : SetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADDB96C0
        public void FallbackSetMember(){} // RVA: 0x7ADDB9860
    }

    public class ReflectionDelegateFactory : Object
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7AA574050
        public void CreateSet(){} // RVA: 0x7AA574260
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
        public void get_Setter(){} // RVA: 0x7A81052C0
        public void set_Setter(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReflectionObject : Object
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7A80F2570
        public void get_Members(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7ADDC48C0
        public void GetValue(){} // RVA: 0x7ADDC49E0
        public void SetValue(){} // RVA: 0x7ADDC4A60
        public void GetType(){} // RVA: 0x7ADDC4AF0
        public void Create(){} // RVA: 0x7ADDC4B60
    }

    public class ReflectionUtils : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADDC5620
        public void IsVirtual(){} // RVA: 0x7ADDC56F0
        public void GetBaseDefinition(){} // RVA: 0x7ADDC5800
        public void IsPublic(){} // RVA: 0x7ADDC5910
        public void GetObjectType(){} // RVA: 0x7ADDC59B0
        public void GetTypeName(){} // RVA: 0x7ADDC59D0
        public void GetFullyQualifiedTypeName(){} // RVA: 0x7ADDC5AA0
        public void RemoveAssemblyDetails(){} // RVA: 0x7ADDC5D90
        public void HasDefaultConstructor(){} // RVA: 0x7ADDC5F00
        public void GetDefaultConstructor(){} // RVA: 0x7ADDC60C0
        public void IsNullable(){} // RVA: 0x7ADDC6260
        public void IsNullableType(){} // RVA: 0x7ADDC6340
        public void EnsureNotNullableType(){} // RVA: 0x7ADDC6450
        public void EnsureNotByRefType(){} // RVA: 0x7ADDC64C0
        public void IsGenericDefinition(){} // RVA: 0x7ADDC6530
        public void ImplementsGenericDefinition(){} // RVA: 0x7ADDC6650
        public void InheritsGenericDefinition(){} // RVA: 0x7ADDC69E0
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7ADDC6D30
        public void GetCollectionItemType(){} // RVA: 0x7ADDC6EC0
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7ADDC7200
        public void GetMemberUnderlyingType(){} // RVA: 0x7ADDC7690
        public void IsByRefLikeType(){} // RVA: 0x7ADDC7950
        public void IsIndexedProperty(){} // RVA: 0x7ADDC7B00
        public void GetMemberValue(){} // RVA: 0x7ADDC7BB0
        public void SetMemberValue(){} // RVA: 0x7ADDC7F00
        public void CanReadMemberValue(){} // RVA: 0x7ADDC8190
        public void CanSetMemberValue(){} // RVA: 0x7ADDC8300
        public void GetFieldsAndProperties(){} // RVA: 0x7ADDC84C0
        public void IsOverridenGenericMember(){} // RVA: 0x7ADDC8D40
        public void GetAttribute(){} // RVA: 0x7AA579EF0
        public void GetAttributes(){} // RVA: 0x7AA579F90
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7ADDC93E0
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7ADDC9590
        public void GetMemberInfoFromType(){} // RVA: 0x7ADDC9650
        public void GetFields(){} // RVA: 0x7ADDC9AA0
        public void GetChildPrivateFields(){} // RVA: 0x7ADDC9BF0
        public void GetProperties(){} // RVA: 0x7ADDC9E00
        public void RemoveFlag(){} // RVA: 0x7ADDCA180
        public void GetChildPrivateProperties(){} // RVA: 0x7ADDCA1A0
        public void IsMethodOverridden(){} // RVA: 0x7ADDCA5F0
        public void GetDefaultValue(){} // RVA: 0x7ADDCA7A0
    }

    public class StringBuffer : ValueType
    {
        // ── Methods ──
        public void get_Position(){} // RVA: 0x7A75FEFA0
        public void set_Position(){} // RVA: 0x7A767FBC0
        public void get_IsEmpty(){} // RVA: 0x7A7673DE0
        public void .ctor(){} // RVA: 0x7A7670310
        public void Append(){} // RVA: 0x7A7E47F60
        public void Clear(){} // RVA: 0x7A7E47F70
        public void EnsureSize(){} // RVA: 0x7A7E47F80
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
        public void IndexOf(){} // RVA: 0x7ADDCB7C0
        public void StartsWith(){} // RVA: 0x7ADDCB850
        public void EndsWith(){} // RVA: 0x7ADDCB8E0
    }

    public class StringUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7ADDCB9A0
        public void FormatWith(){} // RVA: 0x7ADDCC120
        public void IsWhiteSpace(){} // RVA: 0x7ADDCC260
        public void CreateStringWriter(){} // RVA: 0x7ADDCC360
        public void ToCharAsUnicode(){} // RVA: 0x7ADDCC470
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7AA5A5490
        public void ToCamelCase(){} // RVA: 0x7ADDCC540
        public void ToLower(){} // RVA: 0x7ADDCC730
        public void ToSnakeCase(){} // RVA: 0x7ADDCC880
        public void ToKebabCase(){} // RVA: 0x7ADDCC890
        public void ToSeparatedCase(){} // RVA: 0x7ADDCC8A0
        public void IsHighSurrogate(){} // RVA: 0x7ADDCCC20
        public void IsLowSurrogate(){} // RVA: 0x7ADDCCC90
        public void IndexOf(){} // RVA: 0x7ADDCCD00
        public void Replace(){} // RVA: 0x7ADDCCD30
        public void StartsWith(){} // RVA: 0x7ADDCCD50
        public void EndsWith(){} // RVA: 0x7ADDCCD80
        public void Trim(){} // RVA: 0x7ADDCCDD0
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void GetHashCode(){} // RVA: 0x7A7A390D0
        public void Equals(){} // RVA: 0x7A7A390F0
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void Equals(){} // RVA: 0x7A8051B10
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void GetHashCode(){} // RVA: 0x7A7A390D0
        public void Equals(){} // RVA: 0x7A7A390F0
    }

    public class StructMultiKey`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void GetHashCode(){} // RVA: 0x7A7A390D0
        public void Equals(){} // RVA: 0x7A7A390F0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE770
        public void Get(){} // RVA: 0x7AC1DE9A0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Get(){} // RVA: 0x7A8051B10
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE9E0
        public void Get(){} // RVA: 0x7AC1DEB70
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE9E0
        public void Get(){} // RVA: 0x7AC1DEB70
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE9E0
        public void Get(){} // RVA: 0x7AC1DEB70
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE9E0
        public void Get(){} // RVA: 0x7AC1DEB70
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE770
        public void Get(){} // RVA: 0x7AC1DE9A0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE9E0
        public void Get(){} // RVA: 0x7AC1DEB70
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AC1DEB70
        public void .ctor(){} // RVA: 0x7AC1DE9E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AC1DEB70
        public void .ctor(){} // RVA: 0x7AC1DE9E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AC1DEB70
        public void .ctor(){} // RVA: 0x7AC1DE9E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AC1DEB70
        public void .ctor(){} // RVA: 0x7AC1DE9E0
    }

    public class ThreadSafeStore`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1DE770
        public void Get(){} // RVA: 0x7AC1DE9A0
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x7ADDCD040
        public void MemberType(){} // RVA: 0x7ADDCD070
        public void ContainsGenericParameters(){} // RVA: 0x7ADDCD0A0
        public void IsInterface(){} // RVA: 0x7ADDCD0D0
        public void IsGenericType(){} // RVA: 0x7ADDCD0F0
        public void IsGenericTypeDefinition(){} // RVA: 0x7ADDCD120
        public void BaseType(){} // RVA: 0x7ADDCD150
        public void Assembly(){} // RVA: 0x7ADDCD180
        public void IsEnum(){} // RVA: 0x7ADDCD1B0
        public void IsClass(){} // RVA: 0x7ADDCD1E0
        public void IsSealed(){} // RVA: 0x7ADDCD240
        public void IsAbstract(){} // RVA: 0x7ADDCD270
        public void IsVisible(){} // RVA: 0x7ADDCD2A0
        public void IsValueType(){} // RVA: 0x7ADDCD2C0
        public void IsPrimitive(){} // RVA: 0x7ADDCD2F0
        public void AssignableToTypeName(){} // RVA: 0x7ADDCD5B0
        public void ImplementInterface(){} // RVA: 0x7ADDCD5D0
    }

    public class TypeInformation : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_TypeCode(){} // RVA: 0x7A83782A0
        public void .ctor(){} // RVA: 0x7A9B6A000
    }

    public class TypeInformation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7ADDCD850
    }

}