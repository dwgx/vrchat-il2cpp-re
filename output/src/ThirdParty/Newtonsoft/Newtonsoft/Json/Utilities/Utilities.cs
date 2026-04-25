// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
// Classes: 45
// Methods: 466

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Utilities
{
    public class AotHelper : Object
    {
        public bool s_alwaysFalse;

        // ── Methods ──
        public void Ensure(){} // RVA: 0x7FFAC8752E20
        public void EnsureType(){} // RVA: 0x7FFAC2C709B0
        public void EnsureList(){} // RVA: 0x7FFAC2C709B0
        public void EnsureDictionary(){} // RVA: 0x7FFAC2C709B0
        public void IsFalse(){} // RVA: 0x7FFAC8752F40
        public void .cctor(){} // RVA: 0x7FFAC8752FA0
    }

    public class AsyncUtils : Object
    {
        public System.Threading.Tasks.Task`1<bool> False;
        public System.Threading.Tasks.Task`1<bool> True; // 0x8
        public System.Threading.Tasks.Task CompletedTask; // 0x10

        // ── Methods ──
        public void ToAsync(){} // RVA: 0x7FFAC8753060
        public void CancelIfRequestedAsync(){} // RVA: 0x7FFAC2C67ED0 | overloaded x2
        public void FromCanceled(){} // RVA: 0x7FFAC2C67ED0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC8753530 | overloaded x3
        public void ReadAsync(){} // RVA: 0x7FFAC8753620
        public void IsCompletedSuccessfully(){} // RVA: 0x7FFAC8753730
        public void .cctor(){} // RVA: 0x7FFAC87537E0
    }

    public class Base64Encoder : Object
    {
        public int Base64LineSize;
        public int LineSizeInBytes;
        public char[] _charsLine; // 0x10
        public System.IO.TextWriter _writer; // 0x18
        public byte[] _leftOverBytes; // 0x20
        public int _leftOverBytesCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8753B10
        public void ValidateEncode(){} // RVA: 0x7FFAC8753C70
        public void Encode(){} // RVA: 0x7FFAC8753DD0
        public void StoreLeftOverBytes(){} // RVA: 0x7FFAC8753FD0
        public void FulfillFromLeftover(){} // RVA: 0x7FFAC8754100
        public void Flush(){} // RVA: 0x7FFAC87541B0
        public void WriteChars(){} // RVA: 0x7FFAC8754290
        public void EncodeAsync(){} // RVA: 0x7FFAC87542C0
        public void WriteCharsAsync(){} // RVA: 0x7FFAC8754560
        public void FlushAsync(){} // RVA: 0x7FFAC87545F0
    }

    public class BidirectionalDictionary`2 : Object
    {
        public System.Collections.Generic.IDictionary`2<U,T> _firstToSecond;
        public System.Collections.Generic.IDictionary`2<T,U> _secondToFirst;
        public string _duplicateFirstErrorMessage;
        public string _duplicateSecondErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0 | overloaded x3
        public void Set(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetByFirst(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetBySecond(){} // RVA: 0x7FFAC2E8DC40
    }

    public class BoxedPrimitives : Object
    {
        public object BooleanTrue;
        public object BooleanFalse; // 0x8
        public object Int32_M1; // 0x10
        public object Int32_0; // 0x18
        public object Int32_1; // 0x20
        public object Int32_2; // 0x28
        public object Int32_3; // 0x30
        public object Int32_4; // 0x38
        public object Int32_5; // 0x40
        public object Int32_6; // 0x48
        public object Int32_7; // 0x50
        public object Int32_8; // 0x58
        public object Int64_M1; // 0x60
        public object Int64_0; // 0x68
        public object Int64_1; // 0x70
        public object Int64_2; // 0x78
        public object Int64_3; // 0x80
        public object Int64_4; // 0x88
        public object Int64_5; // 0x90
        public object Int64_6; // 0x98
        public object Int64_7; // 0xA0
        public object Int64_8; // 0xA8
        public object DecimalZero; // 0xB0
        public object DoubleNaN; // 0xB8
        public object DoublePositiveInfinity; // 0xC0
        public object DoubleNegativeInfinity; // 0xC8
        public object DoubleZero; // 0xD0

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC8755360 | overloaded x5
        public void .cctor(){} // RVA: 0x7FFAC87554E0
    }

    public class BufferUtils : Object
    {
        // ── Methods ──
        public void RentBuffer(){} // RVA: 0x7FFAC8769A10
        public void ReturnBuffer(){} // RVA: 0x7FFAC8769A90
        public void EnsureBufferSize(){} // RVA: 0x7FFAC8769AF0
    }

    public class CollectionUtils : Object
    {
        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFAC2C59DE0
        public void AddRange(){} // RVA: 0x7FFAC2C70C80
        public void IsDictionaryType(){} // RVA: 0x7FFAC8756560
        public void ResolveEnumerableCollectionConstructor(){} // RVA: 0x7FFAC8756910 | overloaded x2
        public void AddDistinct(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFAC2E8DC40
        public void AddRangeDistinct(){} // RVA: 0x7FFAC2C5D5A0
        public void IndexOf(){} // RVA: 0x7FFAC2C5E730
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOfReference(){} // RVA: 0x7FFAC2E8DC40
        public void FastReverse(){} // RVA: 0x7FFAC2C70A10
        public void GetDimensions(){} // RVA: 0x7FFAC8756BF0
        public void CopyFromJaggedToMultidimensionalArray(){} // RVA: 0x7FFAC8756FB0
        public void JaggedArrayGetValue(){} // RVA: 0x7FFAC8757250
        public void ToMultidimensionalArray(){} // RVA: 0x7FFAC8757350
        public void ArrayEmpty(){} // RVA: 0x7FFAC2C58A90
    }

    public class CollectionWrapper`1 : Object
    {
        public System.Collections.IList Count;
        public System.Collections.Generic.ICollection`1<T> IsReadOnly;
        public object System.Collections.IList.IsFixedSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
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
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B1C61B8> TypeCodeMap;
        public Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes; // 0x8
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>,System.Func`2<object,object>> CastConverters; // 0x10

        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFAC87575F0 | overloaded x2
        public void GetTypeInformation(){} // RVA: 0x7FFAC8757970
        public void IsConvertible(){} // RVA: 0x7FFAC8757A20
        public void ParseTimeSpan(){} // RVA: 0x7FFAC8757B00
        public void CreateCastConverter(){} // RVA: 0x7FFAC8757C40
        public void ToBigInteger(){} // RVA: 0x7FFAC8757F10
        public void FromBigInteger(){} // RVA: 0x7FFAC8758490
        public void Convert(){} // RVA: 0x7FFAC8758A60
        public void TryConvert(){} // RVA: 0x7FFAC8758D10
        public void TryConvertInternal(){} // RVA: 0x7FFAC8758E00
        public void ConvertOrCast(){} // RVA: 0x7FFAC87599A0
        public void EnsureTypeAssignable(){} // RVA: 0x7FFAC8759B60
        public void VersionTryParse(){} // RVA: 0x7FFAC8759DD0
        public void IsInteger(){} // RVA: 0x7FFAC8759DE0
        public void Int32TryParse(){} // RVA: 0x7FFAC8759F00
        public void Int64TryParse(){} // RVA: 0x7FFAC875A060
        public void DecimalTryParse(){} // RVA: 0x7FFAC875A1B0
        public void TryConvertGuid(){} // RVA: 0x7FFAC875AEF0
        public void TryHexTextToInt(){} // RVA: 0x7FFAC875AF40
        public void .cctor(){} // RVA: 0x7FFAC875AFE0
    }

    public class Creator`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2C6A6F0
        public void EndInvoke(){} // RVA: 0x7FFAC2E8DC40
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
        public 0x6B1C63C8 Zone; // 0x34
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
        public short MaxFractionDigits;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC875D370
        public void Parse(){} // RVA: 0x7FFAC875D700
        public void ParseDate(){} // RVA: 0x7FFAC875D860
        public void ParseTimeAndZoneAndWhitespace(){} // RVA: 0x7FFAC875DB20
        public void ParseTime(){} // RVA: 0x7FFAC875DBB0
        public void ParseZone(){} // RVA: 0x7FFAC875DF70
        public void Parse4Digit(){} // RVA: 0x7FFAC875E1A0
        public void Parse2Digit(){} // RVA: 0x7FFAC875E280
        public void ParseChar(){} // RVA: 0x7FFAC875E2F0
    }

    public class DateTimeUtils : Object
    {
        public long InitialJavaScriptDateTicks;
        public string IsoDateFormat;
        public int DaysPer100Years;
        public int DaysPer400Years;
        public int DaysPer4Years;
        public int DaysPerYear;
        public long TicksPerDay;
        public int[] DaysToMonth365; // 0x8
        public int[] DaysToMonth366; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC875E330
        public void GetUtcOffset(){} // RVA: 0x7FFAC875E4F0
        public void ToSerializationMode(){} // RVA: 0x7FFAC875E560
        public void EnsureDateTime(){} // RVA: 0x7FFAC875E610
        public void SwitchToLocalTime(){} // RVA: 0x7FFAC875EA10
        public void SwitchToUtcTime(){} // RVA: 0x7FFAC875EBA0
        public void ToUniversalTicks(){} // RVA: 0x7FFAC875EE30 | overloaded x2
        public void ConvertDateTimeToJavaScriptTicks(){} // RVA: 0x7FFAC875F120 | overloaded x3
        public void UniversalTicksToJavaScriptTicks(){} // RVA: 0x7FFAC875F2E0
        public void ConvertJavaScriptTicksToDateTime(){} // RVA: 0x7FFAC875F360
        public void TryParseDateTimeIso(){} // RVA: 0x7FFAC875F3F0
        public void TryParseDateTimeOffsetIso(){} // RVA: 0x7FFAC875FAE0
        public void CreateDateTime(){} // RVA: 0x7FFAC875FE60
        public void TryParseDateTime(){} // RVA: 0x7FFAC8760370 | overloaded x2
        public void TryParseDateTimeOffset(){} // RVA: 0x7FFAC8760B40 | overloaded x2
        public void TryParseMicrosoftDate(){} // RVA: 0x7FFAC8761040
        public void TryParseDateTimeMicrosoft(){} // RVA: 0x7FFAC8761260
        public void TryParseDateTimeExact(){} // RVA: 0x7FFAC8761440
        public void TryParseDateTimeOffsetMicrosoft(){} // RVA: 0x7FFAC8761530
        public void TryParseDateTimeOffsetExact(){} // RVA: 0x7FFAC8761710
        public void TryReadOffset(){} // RVA: 0x7FFAC87617C0
        public void WriteDateTimeString(){} // RVA: 0x7FFAC8761CC0 | overloaded x2
        public void WriteDefaultIsoDate(){} // RVA: 0x7FFAC8762040
        public void CopyIntToCharArray(){} // RVA: 0x7FFAC87625A0
        public void WriteDateTimeOffset(){} // RVA: 0x7FFAC8762630
        public void WriteDateTimeOffsetString(){} // RVA: 0x7FFAC87628F0
        public void GetDateValues(){} // RVA: 0x7FFAC8762B60
    }

    public class DictionaryWrapper`2 : Object
    {
        public System.Collections.IDictionary GenericDictionary;
        public System.Collections.Generic.IDictionary`2<U,T> Keys;
        public System.Collections.Generic.IReadOnlyDictionary`2<U,T> Values;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void get_GenericDictionary(){} // RVA: 0x7FFAC2C58E90
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

    public class DynamicProxyMetaObject`1 : DynamicMetaObject
    {
        public Newtonsoft.Json.Utilities.DynamicProxy`1<T> NoArgs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void IsOverridden(){} // RVA: 0x7FFAC2C59F60
        public void BindGetMember(){} // RVA: 0x7FFAC2C58F40
        public void BindSetMember(){} // RVA: 0x7FFAC2C6A6F0
        public void BindDeleteMember(){} // RVA: 0x7FFAC2C58F40
        public void BindConvert(){} // RVA: 0x7FFAC2C58F40
        public void BindInvokeMember(){} // RVA: 0x7FFAC2C6A6F0
        public void BindCreateInstance(){} // RVA: 0x7FFAC2C6A6F0
        public void BindInvoke(){} // RVA: 0x7FFAC2C6A6F0
        public void BindBinaryOperation(){} // RVA: 0x7FFAC2C6A6F0
        public void BindUnaryOperation(){} // RVA: 0x7FFAC2C58F40
        public void BindGetIndex(){} // RVA: 0x7FFAC2C6A6F0
        public void BindSetIndex(){} // RVA: 0x7FFAC2C6AE80
        public void BindDeleteIndex(){} // RVA: 0x7FFAC2C6A6F0
        public void get_NoArgs(){} // RVA: 0x7FFAC2C58A90
        public void GetArgs(){} // RVA: 0x7FFAC2C58F80
        public void GetArgArray(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void Constant(){} // RVA: 0x7FFAC2C58F80
        public void CallMethodWithResult(){} // RVA: 0x7FFAC2C6B2B0
        public void BuildCallMethodWithResult(){} // RVA: 0x7FFAC2C6B2B0
        public void CallMethodReturnLast(){} // RVA: 0x7FFAC2C6B140
        public void CallMethodNoResult(){} // RVA: 0x7FFAC2C6B140
        public void GetRestrictions(){} // RVA: 0x7FFAC2C58E90
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAC2C58E90
    }

    public class DynamicProxy`1 : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAC2E8DC40
        public void TryBinaryOperation(){} // RVA: 0x7FFAC2E8DC40
        public void TryConvert(){} // RVA: 0x7FFAC2E8DC40
        public void TryCreateInstance(){} // RVA: 0x7FFAC2E8DC40
        public void TryDeleteIndex(){} // RVA: 0x7FFAC2E8DC40
        public void TryDeleteMember(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetIndex(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetMember(){} // RVA: 0x7FFAC2E8DC40
        public void TryInvoke(){} // RVA: 0x7FFAC2E8DC40
        public void TryInvokeMember(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetIndex(){} // RVA: 0x7FFAC2E8DC40
        public void TrySetMember(){} // RVA: 0x7FFAC2E8DC40
        public void TryUnaryOperation(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DynamicUtils : Object
    {
        // ── Methods ──
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAC8762D80
    }

    public class EnumInfo : Object
    {
        public bool IsFlags; // 0x10
        public ulong[] Values; // 0x18
        public string[] Names; // 0x20
        public string[] ResolvedNames; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8764B50
    }

    public class EnumUtils : Object
    {
        public char EnumSeparatorChar;
        public string EnumSeparatorString;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum;
        public Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

        // ── Methods ──
        public void InitializeValuesAndNames(){} // RVA: 0x7FFAC8764C50
        public void GetFlagsValues(){} // RVA: 0x7FFAC2E8DC40
        public void TryToString(){} // RVA: 0x7FFAC87653F0 | overloaded x2
        public void InternalFlagsFormat(){} // RVA: 0x7FFAC8765700
        public void GetEnumValuesAndNames(){} // RVA: 0x7FFAC87658B0
        public void ToUInt64(){} // RVA: 0x7FFAC8765A30
        public void ParseEnum(){} // RVA: 0x7FFAC8765DE0
        public void MatchName(){} // RVA: 0x7FFAC87666E0
        public void FindIndexByName(){} // RVA: 0x7FFAC87667D0
        public void .cctor(){} // RVA: 0x7FFAC87668C0
    }

    public class FSharpFunction : Object
    {
        public object _instance; // 0x10
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _invoker; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void Invoke(){} // RVA: 0x7FFAC8766B30
    }

    public class FSharpUtils : Object
    {
        public object Instance;
        public Newtonsoft.Json.Utilities.FSharpUtils FSharpCoreAssembly; // 0x8
        public System.Reflection.MethodInfo IsUnion; // 0x10
        public System.Type GetUnionCases; // 0x18
        public System.Reflection.Assembly PreComputeUnionTagReader; // 0x20
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> PreComputeUnionReader; // 0x28
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> PreComputeUnionConstructor; // 0x30
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> GetUnionCaseInfoDeclaringType; // 0x38
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> GetUnionCaseInfoName; // 0x40
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> GetUnionCaseInfoTag; // 0x48
        public System.Func`2<object,object> GetUnionCaseInfoFields; // 0x50
        public System.Func`2<object,object> <GetUnionCaseInfoName>k__BackingField; // 0x58
        public System.Func`2<object,object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
        public Newtonsoft.Json.Utilities.MethodCall`2<object,object> <GetUnionCaseInfoFields>k__BackingField; // 0x68
        public string FSharpSetTypeName;
        public string FSharpListTypeName;
        public string FSharpMapTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8766B60
        public void get_Instance(){} // RVA: 0x7FFAC8767730
        public void get_FSharpCoreAssembly(){} // RVA: 0x7FFAC2F4F0C0
        public void set_FSharpCoreAssembly(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsUnion(){} // RVA: 0x7FFAC2F4F130
        public void set_IsUnion(){} // RVA: 0x7FFAC2F22E90
        public void get_GetUnionCases(){} // RVA: 0x7FFAC31D95E0
        public void set_GetUnionCases(){} // RVA: 0x7FFAC2F4F890
        public void get_PreComputeUnionTagReader(){} // RVA: 0x7FFAC31D0140
        public void set_PreComputeUnionTagReader(){} // RVA: 0x7FFAC31D0C20
        public void get_PreComputeUnionReader(){} // RVA: 0x7FFAC2F9E740
        public void set_PreComputeUnionReader(){} // RVA: 0x7FFAC2F49200
        public void get_PreComputeUnionConstructor(){} // RVA: 0x7FFAC2F9C730
        public void set_PreComputeUnionConstructor(){} // RVA: 0x7FFAC2F9C740
        public void get_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFAC2FC20E0
        public void set_GetUnionCaseInfoDeclaringType(){} // RVA: 0x7FFAC30794D0
        public void get_GetUnionCaseInfoName(){} // RVA: 0x7FFAC2FE9500
        public void set_GetUnionCaseInfoName(){} // RVA: 0x7FFAC2FE9510
        public void get_GetUnionCaseInfoTag(){} // RVA: 0x7FFAC2FBF370
        public void set_GetUnionCaseInfoTag(){} // RVA: 0x7FFAC2FBF380
        public void get_GetUnionCaseInfoFields(){} // RVA: 0x7FFAC2F9CD50
        public void set_GetUnionCaseInfoFields(){} // RVA: 0x7FFAC2F9CD60
        public void EnsureInitialized(){} // RVA: 0x7FFAC8767790
        public void GetMethodWithNonPublicFallback(){} // RVA: 0x7FFAC8767A00
        public void CreateFSharpFuncCall(){} // RVA: 0x7FFAC8767B10
        public void CreateSeq(){} // RVA: 0x7FFAC8767EB0
        public void CreateMap(){} // RVA: 0x7FFAC8767FC0
        public void BuildMapCreator(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC8768290
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

    public class ImmutableCollectionsUtils : Object
    {
        public string ImmutableListGenericInterfaceTypeName;
        public string ImmutableQueueGenericInterfaceTypeName;
        public string ImmutableStackGenericInterfaceTypeName;
        public string ImmutableSetGenericInterfaceTypeName;
        public string ImmutableArrayTypeName;
        public string ImmutableArrayGenericTypeName;
        public string ImmutableListTypeName;
        public string ImmutableListGenericTypeName;
        public string ImmutableQueueTypeName;
        public string ImmutableQueueGenericTypeName;
        public string ImmutableStackTypeName;
        public string ImmutableStackGenericTypeName;
        public string ImmutableSortedSetTypeName;
        public string ImmutableSortedSetGenericTypeName;
        public string ImmutableHashSetTypeName;
        public string ImmutableHashSetGenericTypeName;
        public System.Collections.Generic.IList`1<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;
        public string ImmutableDictionaryGenericInterfaceTypeName;
        public string ImmutableDictionaryTypeName;
        public string ImmutableDictionaryGenericTypeName;
        public string ImmutableSortedDictionaryTypeName;
        public string ImmutableSortedDictionaryGenericTypeName;
        public System.Collections.Generic.IList`1<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

        // ── Methods ──
        public void TryBuildImmutableForArrayContract(){} // RVA: 0x7FFAC8768480
        public void TryBuildImmutableForDictionaryContract(){} // RVA: 0x7FFAC8768A70
        public void .cctor(){} // RVA: 0x7FFAC87690D0
    }

    public class JavaScriptUtils : Object
    {
        public bool[] SingleQuoteCharEscapeFlags;
        public bool[] DoubleQuoteCharEscapeFlags; // 0x8
        public bool[] HtmlCharEscapeFlags; // 0x10
        public int UnicodeTextLength;
        public string EscapedUnicodeText;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8769BA0
        public void GetCharEscapeFlags(){} // RVA: 0x7FFAC876A760
        public void ShouldEscapeJavaScriptString(){} // RVA: 0x7FFAC876A830
        public void WriteEscapedJavaScriptString(){} // RVA: 0x7FFAC876A8B0
        public void ToEscapedJavaScriptString(){} // RVA: 0x7FFAC876B1F0
        public void FirstCharToEscape(){} // RVA: 0x7FFAC876B3A0
        public void WriteEscapedJavaScriptStringAsync(){} // RVA: 0x7FFAC876B460
        public void WriteEscapedJavaScriptStringWithDelimitersAsync(){} // RVA: 0x7FFAC876B9D0 | overloaded x2
        public void WriteCharAsync(){} // RVA: 0x7FFAC876BDB0
        public void WriteEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFAC876C040
        public void WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(){} // RVA: 0x7FFAC876C200
        public void TryGetDateFromConstructorJson(){} // RVA: 0x7FFAC876C580
        public void TryGetDateConstructorValue(){} // RVA: 0x7FFAC876CA60
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
        public Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC876E570
        public void CreateParameterizedConstructor(){} // RVA: 0x7FFAC876E5D0
        public void CreateMethodCall(){} // RVA: 0x7FFAC2C58F40
        public void CreateDefaultConstructor(){} // RVA: 0x7FFAC2C58F40
        public void CreateGet(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void CreateSet(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC876E800
    }

    public class MathUtils : Object
    {
        // ── Methods ──
        public void IntLength(){} // RVA: 0x7FFAC876E940
        public void IntToHex(){} // RVA: 0x7FFAC876EAA0
        public void Min(){} // RVA: 0x7FFAC876EAB0
        public void Max(){} // RVA: 0x7FFAC876EC70 | overloaded x2
        public void ApproxEquals(){} // RVA: 0x7FFAC876ED90
    }

    public class MethodCall`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
        public void EndInvoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class MiscellaneousUtils : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFAC2F21310
        public void ValueEquals(){} // RVA: 0x7FFAC876EE60
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAC876F1B0
        public void ToString(){} // RVA: 0x7FFAC876F2E0
        public void ByteArrayCompare(){} // RVA: 0x7FFAC876F390
        public void GetPrefix(){} // RVA: 0x7FFAC876F430
        public void GetLocalName(){} // RVA: 0x7FFAC876F460
        public void GetQualifiedNameParts(){} // RVA: 0x7FFAC876F490
        public void GetRegexOptions(){} // RVA: 0x7FFAC876F5F0
    }

    public class NoThrowExpressionVisitor : ExpressionVisitor
    {
        public object ErrorResult;

        // ── Methods ──
        public void VisitConditional(){} // RVA: 0x7FFAC8764840
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8764AA0
    }

    public class NoThrowGetBinderMember : GetMemberBinder
    {
        public System.Dynamic.GetMemberBinder _innerBinder; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87643A0
        public void FallbackGetMember(){} // RVA: 0x7FFAC8764430
    }

    public class NoThrowSetBinderMember : SetMemberBinder
    {
        public System.Dynamic.SetMemberBinder _innerBinder; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8764540
        public void FallbackSetMember(){} // RVA: 0x7FFAC87646E0
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
        public void get_Setter(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Setter(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectionObject : Object
    {
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> Creator; // 0x10
        public System.Collections.Generic.IDictionary`2<string,Newtonsoft.Json.Utilities.ReflectionMember> Members; // 0x18

        // ── Methods ──
        public void get_Creator(){} // RVA: 0x7FFAC2F3C380
        public void get_Members(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC876F6A0
        public void GetValue(){} // RVA: 0x7FFAC876F7C0
        public void SetValue(){} // RVA: 0x7FFAC876F840
        public void GetType(){} // RVA: 0x7FFAC876F8D0
        public void Create(){} // RVA: 0x7FFAC876F940 | overloaded x2
    }

    public class ReflectionUtils : Object
    {
        public System.Type[] EmptyTypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC87703F0
        public void IsVirtual(){} // RVA: 0x7FFAC87704C0
        public void GetBaseDefinition(){} // RVA: 0x7FFAC87705D0
        public void IsPublic(){} // RVA: 0x7FFAC87706E0
        public void GetObjectType(){} // RVA: 0x7FFAC8770780
        public void GetTypeName(){} // RVA: 0x7FFAC87707A0
        public void GetFullyQualifiedTypeName(){} // RVA: 0x7FFAC8770870
        public void RemoveAssemblyDetails(){} // RVA: 0x7FFAC8770B60
        public void HasDefaultConstructor(){} // RVA: 0x7FFAC8770CD0
        public void GetDefaultConstructor(){} // RVA: 0x7FFAC8770E90 | overloaded x2
        public void IsNullable(){} // RVA: 0x7FFAC8771030
        public void IsNullableType(){} // RVA: 0x7FFAC8771110
        public void EnsureNotNullableType(){} // RVA: 0x7FFAC8771220
        public void EnsureNotByRefType(){} // RVA: 0x7FFAC8771290
        public void IsGenericDefinition(){} // RVA: 0x7FFAC8771300
        public void ImplementsGenericDefinition(){} // RVA: 0x7FFAC8771420 | overloaded x2
        public void InheritsGenericDefinition(){} // RVA: 0x7FFAC87717A0 | overloaded x2
        public void InheritsGenericDefinitionInternal(){} // RVA: 0x7FFAC8771AF0
        public void GetCollectionItemType(){} // RVA: 0x7FFAC8771C80
        public void GetDictionaryKeyValueTypes(){} // RVA: 0x7FFAC8771FC0
        public void GetMemberUnderlyingType(){} // RVA: 0x7FFAC8772450
        public void IsByRefLikeType(){} // RVA: 0x7FFAC8772710
        public void IsIndexedProperty(){} // RVA: 0x7FFAC87728B0
        public void GetMemberValue(){} // RVA: 0x7FFAC8772960
        public void SetMemberValue(){} // RVA: 0x7FFAC8772CB0
        public void CanReadMemberValue(){} // RVA: 0x7FFAC8772F40
        public void CanSetMemberValue(){} // RVA: 0x7FFAC87730B0
        public void GetFieldsAndProperties(){} // RVA: 0x7FFAC8773270
        public void IsOverridenGenericMember(){} // RVA: 0x7FFAC8773AE0
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFAC8773D00 | overloaded x2
        public void SplitFullyQualifiedTypeName(){} // RVA: 0x7FFAC8774180
        public void GetAssemblyDelimiterIndex(){} // RVA: 0x7FFAC8774330
        public void GetMemberInfoFromType(){} // RVA: 0x7FFAC87743F0
        public void GetFields(){} // RVA: 0x7FFAC8774820
        public void GetChildPrivateFields(){} // RVA: 0x7FFAC8774970
        public void GetProperties(){} // RVA: 0x7FFAC8774B80
        public void RemoveFlag(){} // RVA: 0x7FFAC8774F00
        public void GetChildPrivateProperties(){} // RVA: 0x7FFAC8774F20
        public void IsMethodOverridden(){} // RVA: 0x7FFAC8775340
        public void GetDefaultValue(){} // RVA: 0x7FFAC87754F0
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
        public void Append(){} // RVA: 0x7FFAC8776150 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC87761D0
        public void EnsureSize(){} // RVA: 0x7FFAC87762A0
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
        public void IndexOf(){} // RVA: 0x7FFAC8776510
        public void StartsWith(){} // RVA: 0x7FFAC87765A0
        public void EndsWith(){} // RVA: 0x7FFAC8776630
    }

    public class StringUtils : Object
    {
        public string CarriageReturnLineFeed;
        public string Empty;
        public char CarriageReturn;
        public char LineFeed;
        public char Tab;

        // ── Methods ──
        public void IsNullOrEmpty(){} // RVA: 0x7FFAC87766C0
        public void FormatWith(){} // RVA: 0x7FFAC8776E40 | overloaded x5
        public void IsWhiteSpace(){} // RVA: 0x7FFAC8776F80
        public void CreateStringWriter(){} // RVA: 0x7FFAC8777080
        public void ToCharAsUnicode(){} // RVA: 0x7FFAC8777190
        public void ForgivingCaseSensitiveFind(){} // RVA: 0x7FFAC2E8DC40
        public void ToCamelCase(){} // RVA: 0x7FFAC8777270
        public void ToLower(){} // RVA: 0x7FFAC8777460
        public void ToSnakeCase(){} // RVA: 0x7FFAC87775B0
        public void ToKebabCase(){} // RVA: 0x7FFAC87775C0
        public void ToSeparatedCase(){} // RVA: 0x7FFAC87775D0
        public void IsHighSurrogate(){} // RVA: 0x7FFAC8777950
        public void IsLowSurrogate(){} // RVA: 0x7FFAC87779C0
        public void IndexOf(){} // RVA: 0x7FFAC8777A30
        public void Replace(){} // RVA: 0x7FFAC8777A60
        public void StartsWith(){} // RVA: 0x7FFAC8777A80
        public void EndsWith(){} // RVA: 0x7FFAC8777AB0
        public void Trim(){} // RVA: 0x7FFAC8777B00
    }

    public class StructMultiKey`2 : ValueType
    {
        public System.Type Value1; // 0x10
        public Newtonsoft.Json.Serialization.NamingStrategy Value2; // 0x18
    }

    public class ThreadSafeStore`2 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> _concurrentStore; // 0x10
        public System.Func`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> _creator; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CA44C0
        public void Get(){} // RVA: 0x7FFAC6CA46F0
    }

    public class TypeExtensions : Object
    {
        // ── Methods ──
        public void Method(){} // RVA: 0x7FFAC8777D70
        public void MemberType(){} // RVA: 0x7FFAC8777DA0
        public void ContainsGenericParameters(){} // RVA: 0x7FFAC8777DD0
        public void IsInterface(){} // RVA: 0x7FFAC8777E00
        public void IsGenericType(){} // RVA: 0x7FFAC8777E20
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFAC8777E50
        public void BaseType(){} // RVA: 0x7FFAC8777E80
        public void Assembly(){} // RVA: 0x7FFAC8777EB0
        public void IsEnum(){} // RVA: 0x7FFAC8777EE0
        public void IsClass(){} // RVA: 0x7FFAC8777F10
        public void IsSealed(){} // RVA: 0x7FFAC8777F70
        public void IsAbstract(){} // RVA: 0x7FFAC8777FA0
        public void IsVisible(){} // RVA: 0x7FFAC8777FD0
        public void IsValueType(){} // RVA: 0x7FFAC8777FF0
        public void IsPrimitive(){} // RVA: 0x7FFAC8778020
        public void AssignableToTypeName(){} // RVA: 0x7FFAC87782D0 | overloaded x2
        public void ImplementInterface(){} // RVA: 0x7FFAC87782F0
    }

    public class TypeInformation : Object
    {
        public System.Type Type; // 0x10
        public 0x6B1C61B8 TypeCode; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeCode(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

    public class ValidationUtils : Object
    {
        // ── Methods ──
        public void ArgumentNotNull(){} // RVA: 0x7FFAC8778540
    }

}