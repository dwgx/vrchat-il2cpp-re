// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 65
// Methods: 586

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper
    {
        // ── Methods ──
        public void Ensure(){} // RVA: 0x7FFAF8A6B7A0
        public void EnsureType(){} // RVA: 0x7FFAF2AD4A80
        public void EnsureList(){} // RVA: 0x7FFAF2AD4A80
        public void EnsureDictionary(){} // RVA: 0x7FFAF2AD4A80
        public void IsFalse(){} // RVA: 0x7FFAF8A6B8C0
        public void .cctor(){} // RVA: 0x7FFAF8A6B920
    }

    public class AsyncUtils
    {
        // ── Methods ──
        public void ToAsync(){} // RVA: 0x7FFAF8A6B9E0
        public void CancelIfRequestedAsync(){} // RVA: 0x7FFAF2ACBDB0 | overloaded x2
        public void FromCanceled(){} // RVA: 0x7FFAF2ACBDB0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF8A6BEB0 | overloaded x3
        public void ReadAsync(){} // RVA: 0x7FFAF8A6BFA0
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFAF8A6C0B0
        public void .cctor(){} // RVA: 0x7FFAF8A6C160
    }

    public class Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A6C490
        public void ValidateEncode(){} // RVA: 0x7FFAF8A6C5F0
        public void Encode(){} // RVA: 0x7FFAF8A6C750
        public void StoreLeftOverBytes(){} // RVA: 0x7FFAF8A6C950
        public void FulfillFromLeftover(){} // RVA: 0x7FFAF8A6CA80
        public void Flush(){} // RVA: 0x7FFAF8A6CB30
        public void WriteChars(){} // RVA: 0x7FFAF8A6CC10
        public void EncodeAsync(){} // RVA: 0x7FFAF8A6CC40
        public void WriteCharsAsync(){} // RVA: 0x7FFAF8A6CEE0
        public void FlushAsync(){} // RVA: 0x7FFAF8A6CF70
    }

    public class BidirectionalDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADF9F0 | overloaded x3
        public void Set(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetByFirst(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetBySecond(){} // RVA: 0x7FFAF2D33FA0
    }

    public class BoxedPrimitives
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAF8A6DCE0 | overloaded x5
        public void .cctor(){} // RVA: 0x7FFAF8A6DE60
    }

    public class BufferUtils
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7FFAF8A82390
        public void ReturnBuffer(){} // RVA: 0x7FFAF8A82410
        public void EnsureBufferSize(){} // RVA: 0x7FFAF8A82470
    }

    public class CollectionUtils
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFAF2ABDCC0
        public void AddRange(){} // RVA: 0x7FFAF2AD4D50
        public void IsDictionaryType(){} // RVA: 0x7FFAF8A6EEE0
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFAF8A6F290 | overloaded x2
        public void AddDistinct(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFAF2D33FA0
        public void AddRangeDistinct(){} // RVA: 0x7FFAF2AC14C0
        public void IndexOf(){} // RVA: 0x7FFAF2AC2610
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void IndexOfReference(){} // RVA: 0x7FFAF2D33FA0
        public void FastReverse(){} // RVA: 0x7FFAF2AD4AE0
        public void GetDimensions(){} // RVA: 0x7FFAF8A6F570
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFAF8A6F930
        public void JaggedArrayGetValue(){} // RVA: 0x7FFAF8A6FBD0
        public void ToMultidimensionalArray(){} // RVA: 0x7FFAF8A6FCD0
        public void ArrayEmpty(){} // RVA: 0x7FFAF2ABC960
    }

    public class CollectionWrapper`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void Remove(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAF2AC2590
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAF2AC2590
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAF2AD4FA0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAF2AD6C40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAF2AD4B10
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAF2ACBCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAF2AD6C40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void VerifyValueType(){} // RVA: 0x7FFAF2AD4AE0
        public void IsCompatibleObject(){} // RVA: 0x7FFAF2ABDCC0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAF2ABCD60
    }

    public class CollectionWrapper`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8226AF0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF8226BD0
        public void Clear(){} // RVA: 0x7FFAF8226D50
        public void Contains(){} // RVA: 0x7FFAF8226E00
        public void CopyTo(){} // RVA: 0x7FFAF8226F80
        public void get_Count(){} // RVA: 0x7FFAF8227040
        public void get_IsReadOnly(){} // RVA: 0x7FFAF82270F0
        public void Remove(){} // RVA: 0x7FFAF82271A0
        public void GetEnumerator(){} // RVA: 0x7FFAF8227390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8227420
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAF8227480
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAF8227670
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAF8227870
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAF8227AC0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAF8227B70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAF8227DB0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAF8227E60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAF8228040
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAF82280F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF8228330
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF82283D0
        public void VerifyValueType(){} // RVA: 0x7FFAF8228480
        public void IsCompatibleObject(){} // RVA: 0x7FFAF82285D0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAF8228760
    }

    public class CollectionWrapper`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8226AF0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF8226BD0
        public void Clear(){} // RVA: 0x7FFAF8226D50
        public void Contains(){} // RVA: 0x7FFAF8226E00
        public void CopyTo(){} // RVA: 0x7FFAF8226F80
        public void get_Count(){} // RVA: 0x7FFAF8227040
        public void get_IsReadOnly(){} // RVA: 0x7FFAF82270F0
        public void Remove(){} // RVA: 0x7FFAF82271A0
        public void GetEnumerator(){} // RVA: 0x7FFAF8227390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8227420
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAF8227480
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAF8227670
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAF8227870
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAF8227AC0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAF8227B70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAF8227DB0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAF8227E60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAF8228040
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAF82280F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF8228330
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF82283D0
        public void VerifyValueType(){} // RVA: 0x7FFAF8228480
        public void IsCompatibleObject(){} // RVA: 0x7FFAF82285D0
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAF8228760
    }

    public class ConvertUtils
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFAF8A6FF70 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x7FFAF8A702F0
        public void IsConvertible(){} // RVA: 0x7FFAF8A703A0
        public void ParseTimeSpan(){} // RVA: 0x7FFAF8A70480
        public void CreateCastConverter(){} // RVA: 0x7FFAF8A705C0
        public void ToBigInteger(){} // RVA: 0x7FFAF8A70890
        public void FromBigInteger(){} // RVA: 0x7FFAF8A70E10
        public void Convert(){} // RVA: 0x7FFAF8A713E0
        public void TryConvert(){} // RVA: 0x7FFAF8A71690
        public void TryConvertInternal(){} // RVA: 0x7FFAF8A71780
        public void ConvertOrCast(){} // RVA: 0x7FFAF8A72320
        public void EnsureTypeAssignable(){} // RVA: 0x7FFAF8A724E0
        public void VersionTryParse(){} // RVA: 0x7FFAF8A72750
        public void IsInteger(){} // RVA: 0x7FFAF8A72760
        public void Int32TryParse(){} // RVA: 0x7FFAF8A72880
        public void Int64TryParse(){} // RVA: 0x7FFAF8A729E0
        public void DecimalTryParse(){} // RVA: 0x7FFAF8A72B30
        public void TryConvertGuid(){} // RVA: 0x7FFAF8A73870
        public void TryHexTextToInt(){} // RVA: 0x7FFAF8A738C0
        public void .cctor(){} // RVA: 0x7FFAF8A73960
    }

    public class Creator`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAF2D33FA0
        public void BeginInvoke(){} // RVA: 0x7FFAF2ACE6A0
        public void EndInvoke(){} // RVA: 0x7FFAF2D33FA0
    }

    public class DateTimeParser
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8A75CF0
        public void Parse(){} // RVA: 0x7FFAF8A76080
        public void ParseDate(){} // RVA: 0x7FFAF8A761E0
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7FFAF8A764A0
        public void ParseTime(){} // RVA: 0x7FFAF8A76530
        public void ParseZone(){} // RVA: 0x7FFAF8A768F0
        public void Parse4Digit(){} // RVA: 0x7FFAF8A76B20
        public void Parse2Digit(){} // RVA: 0x7FFAF8A76C00
        public void ParseChar(){} // RVA: 0x7FFAF8A76C70
    }

    public class DateTimeUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8A76CB0
        public void GetUtcOffset(){} // RVA: 0x7FFAF8A76E70
        public void ToSerializationMode(){} // RVA: 0x7FFAF8A76EE0
        public void EnsureDateTime(){} // RVA: 0x7FFAF8A76F90
        public void SwitchToLocalTime(){} // RVA: 0x7FFAF8A77390
        public void SwitchToUtcTime(){} // RVA: 0x7FFAF8A77520
        public void ToUniversalTicks(){} // RVA: 0x7FFAF8A777B0 | overloaded x2
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7FFAF8A77AA0 | overloaded x3
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x7FFAF8A77C60
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7FFAF8A77CE0
        public void TryParseDateTimeIso(){} // RVA: 0x7FFAF8A77D70
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7FFAF8A78460
        public void CreateDateTime(){} // RVA: 0x7FFAF8A787E0
        public void TryParseDateTime(){} // RVA: 0x7FFAF8A78CF0 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFAF8A794C0 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7FFAF8A799C0
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7FFAF8A79BE0
        public void TryParseDateTimeExact(){} // RVA: 0x7FFAF8A79DC0
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7FFAF8A79EB0
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7FFAF8A7A090
        public void TryReadOffset(){} // RVA: 0x7FFAF8A7A140
        public void WriteDateTimeString(){} // RVA: 0x7FFAF8A7A640 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7FFAF8A7A9C0
        public void CopyIntToCharArray(){} // RVA: 0x7FFAF8A7AF20
        public void WriteDateTimeOffset(){} // RVA: 0x7FFAF8A7AFB0
        public void WriteDateTimeOffsetString(){} // RVA: 0x7FFAF8A7B270
        public void GetDateValues(){} // RVA: 0x7FFAF8A7B4E0
    }

    public class DictionaryWrapper`2 : System.Collections.Generic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x3
        public void get_GenericDictionary(){} // RVA: 0x7FFAF2ABCD60
        public void Add(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFAF2D33FA0
        public void get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void Remove(){} // RVA: 0x7FFAF2AD4B10 | overloaded x3
        public void TryGetValue(){} // RVA: 0x7FFAF2D33FA0
        public void get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF2ADDC60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF2ABCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF2ADDC60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFAF2ABCD60
    }

    public class DynamicProxyMetaObject`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void IsOverridden(){} // RVA: 0x7FFAF2ABDE40
        public void BindGetMember(){} // RVA: 0x7FFAF2ABCE10
        public void BindSetMember(){} // RVA: 0x7FFAF2ACE6A0
        public void BindDeleteMember(){} // RVA: 0x7FFAF2ABCE10
        public void BindConvert(){} // RVA: 0x7FFAF2ABCE10
        public void BindInvokeMember(){} // RVA: 0x7FFAF2ACE6A0
        public void BindCreateInstance(){} // RVA: 0x7FFAF2ACE6A0
        public void BindInvoke(){} // RVA: 0x7FFAF2ACE6A0
        public void BindBinaryOperation(){} // RVA: 0x7FFAF2ACE6A0
        public void BindUnaryOperation(){} // RVA: 0x7FFAF2ABCE10
        public void BindGetIndex(){} // RVA: 0x7FFAF2ACE6A0
        public void BindSetIndex(){} // RVA: 0x7FFAF2ACEE30
        public void BindDeleteIndex(){} // RVA: 0x7FFAF2ACE6A0
        public void get_NoArgs(){} // RVA: 0x7FFAF2ABC960
        public void GetArgs(){} // RVA: 0x7FFAF2ABCE50
        public void GetArgArray(){} // RVA: 0x7FFAF2ABCEC0 | overloaded x2
        public void Constant(){} // RVA: 0x7FFAF2ABCE50
        public void CallMethodWithResult(){} // RVA: 0x7FFAF2ACF260
        public void BuildCallMethodWithResult(){} // RVA: 0x7FFAF2ACF260
        public void CallMethodReturnLast(){} // RVA: 0x7FFAF2ACF0F0
        public void CallMethodNoResult(){} // RVA: 0x7FFAF2ACF0F0
        public void GetRestrictions(){} // RVA: 0x7FFAF2ABCD60
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF2ABCD60
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF2D33FA0
        public void TryBinaryOperation(){} // RVA: 0x7FFAF2D33FA0
        public void TryConvert(){} // RVA: 0x7FFAF2D33FA0
        public void TryCreateInstance(){} // RVA: 0x7FFAF2D33FA0
        public void TryDeleteIndex(){} // RVA: 0x7FFAF2D33FA0
        public void TryDeleteMember(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetIndex(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetMember(){} // RVA: 0x7FFAF2D33FA0
        public void TryInvoke(){} // RVA: 0x7FFAF2D33FA0
        public void TryInvokeMember(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetIndex(){} // RVA: 0x7FFAF2D33FA0
        public void TrySetMember(){} // RVA: 0x7FFAF2D33FA0
        public void TryUnaryOperation(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF5924C70
        public void TryBinaryOperation(){} // RVA: 0x7FFAF5924CB0
        public void TryConvert(){} // RVA: 0x7FFAF5924D10
        public void TryCreateInstance(){} // RVA: 0x7FFAF5924CB0
        public void TryDeleteIndex(){} // RVA: 0x7FFAF2D8D320
        public void TryDeleteMember(){} // RVA: 0x7FFAF2D8D320
        public void TryGetIndex(){} // RVA: 0x7FFAF5924CB0
        public void TryGetMember(){} // RVA: 0x7FFAF5924D10
        public void TryInvoke(){} // RVA: 0x7FFAF5924CB0
        public void TryInvokeMember(){} // RVA: 0x7FFAF5924CB0
        public void TrySetIndex(){} // RVA: 0x7FFAF2D8D320
        public void TrySetMember(){} // RVA: 0x7FFAF2D8D320
        public void TryUnaryOperation(){} // RVA: 0x7FFAF5924D10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DynamicProxy`1
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF5924C70
        public void TryBinaryOperation(){} // RVA: 0x7FFAF5924CB0
        public void TryConvert(){} // RVA: 0x7FFAF5924D10
        public void TryCreateInstance(){} // RVA: 0x7FFAF5924CB0
        public void TryDeleteIndex(){} // RVA: 0x7FFAF2D8D320
        public void TryDeleteMember(){} // RVA: 0x7FFAF2D8D320
        public void TryGetIndex(){} // RVA: 0x7FFAF5924CB0
        public void TryGetMember(){} // RVA: 0x7FFAF5924D10
        public void TryInvoke(){} // RVA: 0x7FFAF5924CB0
        public void TryInvokeMember(){} // RVA: 0x7FFAF5924CB0
        public void TrySetIndex(){} // RVA: 0x7FFAF2D8D320
        public void TrySetMember(){} // RVA: 0x7FFAF2D8D320
        public void TryUnaryOperation(){} // RVA: 0x7FFAF5924D10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DynamicUtils
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF8A7B700
    }

    public class EnumInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A7D4D0
    }

    public class EnumUtils
    {
        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x7FFAF8A7D5D0
        public void GetFlagsValues(){} // RVA: 0x7FFAF2D33FA0
        public void TryToString(){} // RVA: 0x7FFAF8A7DD70 | overloaded x2
        public void InternalFlagsFormat(){} // RVA: 0x7FFAF8A7E080
        public void GetEnumValuesAndNames(){} // RVA: 0x7FFAF8A7E230
        public void ToUInt64(){} // RVA: 0x7FFAF8A7E3B0
        public void ParseEnum(){} // RVA: 0x7FFAF8A7E760
        public void MatchName(){} // RVA: 0x7FFAF8A7F060
        public void FindIndexByName(){} // RVA: 0x7FFAF8A7F150
        public void .cctor(){} // RVA: 0x7FFAF8A7F240
    }

    public class FSharpFunction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Invoke(){} // RVA: 0x7FFAF8A7F4B0
    }

    public class FSharpUtils
    {
        public object Item1;
        public object Item2;
        public object System.Runtime.CompilerServices.ITuple.Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A7F4E0
        public void get_Instance(){} // RVA: 0x7FFAF8A800B0
        public void get_FSharpCoreAssembly(){} // RVA: 0x7FFAF2DBB0C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsUnion(){} // RVA: 0x7FFAF2DBB130
        public void set_IsUnion(){} // RVA: 0x7FFAF2D8EE90
        public void get_GetUnionCases(){} // RVA: 0x7FFAF30E74D0
        public void set_GetUnionCases(){} // RVA: 0x7FFAF2DBB890
        public void get_PreComputeUnionTagReader(){} // RVA: 0x7FFAF2F476A0
        public void set_PreComputeUnionTagReader(){} // RVA: 0x7FFAF2F4B830
        public void get_PreComputeUnionReader(){} // RVA: 0x7FFAF2E0A740
        public void set_PreComputeUnionReader(){} // RVA: 0x7FFAF2DB5200
        public void get_PreComputeUnionConstructor(){} // RVA: 0x7FFAF2E08730
        public void set_PreComputeUnionConstructor(){} // RVA: 0x7FFAF2E08740
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFAF2E2E0E0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFAF2EE54D0
        public void get_GetUnionCaseInfoName(){} // RVA: 0x7FFAF2E55500
        public void set_GetUnionCaseInfoName(){} // RVA: 0x7FFAF2E55510
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x7FFAF2E2B370
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x7FFAF2E2B380
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x7FFAF2E08D50
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x7FFAF2E08D60
        public void EnsureInitialized(){} // RVA: 0x7FFAF8A80110
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x7FFAF8A80380
        public void CreateFSharpFuncCall(){} // RVA: 0x7FFAF8A80490
        public void CreateSeq(){} // RVA: 0x7FFAF8A80830
        public void CreateMap(){} // RVA: 0x7FFAF8A80940
        public void BuildMapCreator(){} // RVA: 0x7FFAF2ABCD60
        public void .cctor(){} // RVA: 0x7FFAF8A80C10
    }

    public class IWrappedCollection
    {
        // ── Methods ──
        public void get_UnderlyingCollection(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IWrappedDictionary
    {
        // ── Methods ──
        public void get_UnderlyingDictionary(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ImmutableCollectionsUtils
    {
        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x7FFAF8A80E00
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x7FFAF8A813F0
        public void .cctor(){} // RVA: 0x7FFAF8A81A50
    }

    public class JavaScriptUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8A82520
        public void GetCharEscapeFlags(){} // RVA: 0x7FFAF8A830E0
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7FFAF8A831B0
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7FFAF8A83230
        public void ToEscapedJavaScriptString(){} // RVA: 0x7FFAF8A83B70
        public void FirstCharToEscape(){} // RVA: 0x7FFAF8A83D20
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x7FFAF8A83DE0
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x7FFAF8A84350 | overloaded x2
        public void WriteCharAsync(){} // RVA: 0x7FFAF8A84730
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFAF8A849C0
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFAF8A84B80
        public void TryGetDateFromConstructorJson(){} // RVA: 0x7FFAF8A84F00
        public void TryGetDateConstructorValue(){} // RVA: 0x7FFAF8A853E0
    }

    public class JsonTokenUtils
    {
        // ── Methods ──
        public void IsEndToken(){} // RVA: 0x7FFAF8A86EB0
        public void IsStartToken(){} // RVA: 0x7FFAF8A86EC0
        public void IsPrimitiveToken(){} // RVA: 0x7FFAF8A86ED0
    }

    public class LateBoundReflectionDelegateFactory
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8A86EF0
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFAF8A86F50
        public void CreateMethodCall(){} // RVA: 0x7FFAF2ABCE10
        public void CreateDefaultConstructor(){} // RVA: 0x7FFAF2ABCE10
        public void CreateGet(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8A87180
    }

    public class MathUtils
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7FFAF8A872C0
        public void IntToHex(){} // RVA: 0x7FFAF8A87420
        public void Min(){} // RVA: 0x7FFAF8A87430
        public void Max(){} // RVA: 0x7FFAF8A875F0 | overloaded x2
        public void ApproxEquals(){} // RVA: 0x7FFAF8A87710
    }

    public class MethodCall`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAF2D33FA0
        public void BeginInvoke(){} // RVA: 0x7FFAF2D33FA0
        public void EndInvoke(){} // RVA: 0x7FFAF2D33FA0
    }

    public class MiscellaneousUtils
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFAF2D8D310
        public void ValueEquals(){} // RVA: 0x7FFAF8A877E0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAF8A87B30
        public void ToString(){} // RVA: 0x7FFAF8A87C60
        public void ByteArrayCompare(){} // RVA: 0x7FFAF8A87D10
        public void GetPrefix(){} // RVA: 0x7FFAF8A87DB0
        public void GetLocalName(){} // RVA: 0x7FFAF8A87DE0
        public void GetQualifiedNameParts(){} // RVA: 0x7FFAF8A87E10
        public void GetRegexOptions(){} // RVA: 0x7FFAF8A87F70
    }

    public class NoThrowExpressionVisitor
    {
        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x7FFAF8A7D1C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8A7D420
    }

    public class NoThrowGetBinderMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A7CD20
        public void FallbackGetMember(){} // RVA: 0x7FFAF8A7CDB0
    }

    public class NoThrowSetBinderMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A7CEC0
        public void FallbackSetMember(){} // RVA: 0x7FFAF8A7D060
    }

    public class ReflectionDelegateFactory
    {
        // ── Methods ──
        public void CreateGet(){} // RVA: 0x7FFAF2ABCE10 | overloaded x3
        public void CreateSet(){} // RVA: 0x7FFAF2ABCE10 | overloaded x3
        public void CreateMethodCall(){} // RVA: 0x7FFAF2ABCE10
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFAF2ABCE10
        public void CreateDefaultConstructor(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ReflectionMember
    {
        // ── Methods ──
        public void get_MemberType(){} // RVA: 0x7FFAF2DA8380
        public void set_MemberType(){} // RVA: 0x7FFAF2D8EE30
        public void get_Getter(){} // RVA: 0x7FFAF2D907C0
        public void set_Getter(){} // RVA: 0x7FFAF2DF3E80
        public void get_Setter(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Setter(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ReflectionObject
    {
        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFAF2DA8380
        public void get_Members(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF8A88020
        public void GetValue(){} // RVA: 0x7FFAF8A88140
        public void SetValue(){} // RVA: 0x7FFAF8A881C0
        public void GetType(){} // RVA: 0x7FFAF8A88250
        public void Create(){} // RVA: 0x7FFAF8A882C0 | overloaded x2
    }

    public class ReflectionUtils
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8A88D70
        public void IsVirtual(){} // RVA: 0x7FFAF8A88E40
        public void GetBaseDefinition(){} // RVA: 0x7FFAF8A88F50
        public void IsPublic(){} // RVA: 0x7FFAF8A89060
        public void GetObjectType(){} // RVA: 0x7FFAF8A89100
        public void GetTypeName(){} // RVA: 0x7FFAF8A89120
        public void GetFullyQualifiedTypeName(){} // RVA: 0x7FFAF8A891F0
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFAF8A894E0
        public void HasDefaultConstructor(){} // RVA: 0x7FFAF8A89650
        public void GetDefaultConstructor(){} // RVA: 0x7FFAF8A89810 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFAF8A899B0
        public void IsNullableType(){} // RVA: 0x7FFAF8A89A90
        public void EnsureNotNullableType(){} // RVA: 0x7FFAF8A89BA0
        public void EnsureNotByRefType(){} // RVA: 0x7FFAF8A89C10
        public void IsGenericDefinition(){} // RVA: 0x7FFAF8A89C80
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFAF8A89DA0 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFAF8A8A120 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFAF8A8A470
        public void GetCollectionItemType(){} // RVA: 0x7FFAF8A8A600
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFAF8A8A940
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFAF8A8ADD0
        public void IsByRefLikeType(){} // RVA: 0x7FFAF8A8B090
        public void IsIndexedProperty(){} // RVA: 0x7FFAF8A8B230
        public void GetMemberValue(){} // RVA: 0x7FFAF8A8B2E0
        public void SetMemberValue(){} // RVA: 0x7FFAF8A8B630
        public void CanReadMemberValue(){} // RVA: 0x7FFAF8A8B8C0
        public void CanSetMemberValue(){} // RVA: 0x7FFAF8A8BA30
        public void GetFieldsAndProperties(){} // RVA: 0x7FFAF8A8BBF0
        public void IsOverridenGenericMember(){} // RVA: 0x7FFAF8A8C460
        public void GetAttribute(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFAF8A8C680 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFAF8A8CB00
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFAF8A8CCB0
        public void GetMemberInfoFromType(){} // RVA: 0x7FFAF8A8CD70
        public void GetFields(){} // RVA: 0x7FFAF8A8D1A0
        public void GetChildPrivateFields(){} // RVA: 0x7FFAF8A8D2F0
        public void GetProperties(){} // RVA: 0x7FFAF8A8D500
        public void RemoveFlag(){} // RVA: 0x7FFAF8A8D880
        public void GetChildPrivateProperties(){} // RVA: 0x7FFAF8A8D8A0
        public void IsMethodOverridden(){} // RVA: 0x7FFAF8A8DCC0
        public void GetDefaultValue(){} // RVA: 0x7FFAF8A8DE70
    }

    public class StringBuffer
    {
        public object Item;
        public object Chars;
        public object StartIndex;

        // ── Methods ──
        public void get_Position(){} // RVA: 0x7FFAF4959890
        public void set_Position(){} // RVA: 0x7FFAF49598A0
        public void get_IsEmpty(){} // RVA: 0x7FFAF47D6810
        public void .ctor(){} // RVA: 0x7FFAF476DE20 | overloaded x2
        public void Append(){} // RVA: 0x7FFAF8A8EAD0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8A8EB50
        public void EnsureSize(){} // RVA: 0x7FFAF8A8EC20
        public void ToString(){} // RVA: 0x7FFAF8A8EE30 | overloaded x2
        public void get_InternalBuffer(){} // RVA: 0x7FFAF4584690
    }

    public class StringReference
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAF8A8EE40
        public void get_Chars(){} // RVA: 0x7FFAF4584690
        public void get_StartIndex(){} // RVA: 0x7FFAF4959890
        public void get_Length(){} // RVA: 0x7FFAF49598B0
        public void .ctor(){} // RVA: 0x7FFAF66D14B0
        public void ToString(){} // RVA: 0x7FFAF8A8EE70
    }

    public class StringReferenceExtensions
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAF8A8EE90
        public void StartsWith(){} // RVA: 0x7FFAF8A8EF20
        public void EndsWith(){} // RVA: 0x7FFAF8A8EFB0
    }

    public class StringUtils
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFAF8A8F040
        public void FormatWith(){} // RVA: 0x7FFAF8A8F7C0 | overloaded x5
        public void IsWhiteSpace(){} // RVA: 0x7FFAF8A8F900
        public void CreateStringWriter(){} // RVA: 0x7FFAF8A8FA00
        public void ToCharAsUnicode(){} // RVA: 0x7FFAF8A8FB10
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFAF2D33FA0
        public void ToCamelCase(){} // RVA: 0x7FFAF8A8FBF0
        public void ToLower(){} // RVA: 0x7FFAF8A8FDE0
        public void ToSnakeCase(){} // RVA: 0x7FFAF8A8FF30
        public void ToKebabCase(){} // RVA: 0x7FFAF8A8FF40
        public void ToSeparatedCase(){} // RVA: 0x7FFAF8A8FF50
        public void IsHighSurrogate(){} // RVA: 0x7FFAF8A902D0
        public void IsLowSurrogate(){} // RVA: 0x7FFAF8A90340
        public void IndexOf(){} // RVA: 0x7FFAF8A903B0
        public void Replace(){} // RVA: 0x7FFAF8A903E0
        public void StartsWith(){} // RVA: 0x7FFAF8A90400
        public void EndsWith(){} // RVA: 0x7FFAF8A90430
        public void Trim(){} // RVA: 0x7FFAF8A90480
    }

    public class StructMultiKey`2
    {
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void GetHashCode(){} // RVA: 0x7FFAF6B5D780
        public void Equals(){} // RVA: 0x7FFAF6B5D960 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void Equals(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void GetHashCode(){} // RVA: 0x7FFAF6B5D780
        public void Equals(){} // RVA: 0x7FFAF6B5D960 | overloaded x2
    }

    public class StructMultiKey`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void GetHashCode(){} // RVA: 0x7FFAF6B5D780
        public void Equals(){} // RVA: 0x7FFAF6B5D960 | overloaded x2
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E9FF20
        public void Get(){} // RVA: 0x7FFAF6EA0150
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void Get(){} // RVA: 0x7FFAF2D33FA0
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E9FF20
        public void Get(){} // RVA: 0x7FFAF6EA0150
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EA0190
        public void Get(){} // RVA: 0x7FFAF6EA0320
    }

    public class ThreadSafeStore`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6E9FF20
        public void Get(){} // RVA: 0x7FFAF6EA0150
    }

    public class TypeExtensions
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x7FFAF8A906F0
        public void MemberType(){} // RVA: 0x7FFAF8A90720
        public void ContainsGenericParameters(){} // RVA: 0x7FFAF8A90750
        public void IsInterface(){} // RVA: 0x7FFAF8A90780
        public void IsGenericType(){} // RVA: 0x7FFAF8A907A0
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFAF8A907D0
        public void BaseType(){} // RVA: 0x7FFAF8A90800
        public void Assembly(){} // RVA: 0x7FFAF8A90830
        public void IsEnum(){} // RVA: 0x7FFAF8A90860
        public void IsClass(){} // RVA: 0x7FFAF8A90890
        public void IsSealed(){} // RVA: 0x7FFAF8A908F0
        public void IsAbstract(){} // RVA: 0x7FFAF8A90920
        public void IsVisible(){} // RVA: 0x7FFAF8A90950
        public void IsValueType(){} // RVA: 0x7FFAF8A90970
        public void IsPrimitive(){} // RVA: 0x7FFAF8A909A0
        public void AssignableToTypeName(){} // RVA: 0x7FFAF8A90C50 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7FFAF8A90C70
    }

    public class TypeInformation
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void get_TypeCode(){} // RVA: 0x7FFAF306ED50
        public void .ctor(){} // RVA: 0x7FFAF4816A50
    }

    public class ValidationUtils
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7FFAF8A90EC0
    }

}