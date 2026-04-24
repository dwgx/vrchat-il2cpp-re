// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 8
// Methods: 487

namespace ThirdParty.DotNet.System
{
    public class DBNull : Object
    {
        public NativeIoCompletionCallback Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A25460 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFD53A254B0
        public void ToString(){} // RVA: 0x7FFD53A25500 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFD4E446CB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A25540
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A25590
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A255E0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A25630
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A25680
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A256D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A25720
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A25770
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A257C0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A25810
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A25860
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A258B0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A25900
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A25950
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A259A0
        public void .cctor(){} // RVA: 0x7FFD53A25A10
    }

    public class DateTime : ValueType
    {
        public object InternalTicks;
        public object InternalKind;
        public object Date;
        public object Day;
        public object DayOfWeek;
        public object DayOfYear;
        public object Hour;
        public object Kind;
        public object Millisecond;
        public object Minute;
        public object Month;
        public object Now;
        public object Second;
        public object Ticks;
        public object TimeOfDay;
        public object Today;
        public object Year;
        public object UtcNow;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A26AB0 | overloaded x14
        public void get_InternalTicks(){} // RVA: 0x7FFD53A26F10
        public void get_InternalKind(){} // RVA: 0x7FFD53A26F30
        public void Add(){} // RVA: 0x7FFD53A26FB0 | overloaded x2
        public void AddDays(){} // RVA: 0x7FFD53A270D0
        public void AddHours(){} // RVA: 0x7FFD53A27140
        public void AddMilliseconds(){} // RVA: 0x7FFD53A271B0
        public void AddMinutes(){} // RVA: 0x7FFD53A27220
        public void AddMonths(){} // RVA: 0x7FFD53A27290
        public void AddSeconds(){} // RVA: 0x7FFD53A274E0
        public void AddTicks(){} // RVA: 0x7FFD53A27550
        public void AddYears(){} // RVA: 0x7FFD53A27660
        public void Compare(){} // RVA: 0x7FFD53A27730
        public void CompareTo(){} // RVA: 0x7FFD53A278A0 | overloaded x2
        public void DateToTicks(){} // RVA: 0x7FFD53A27910
        public void TimeToTicks(){} // RVA: 0x7FFD53A27AF0
        public void DaysInMonth(){} // RVA: 0x7FFD53A27BC0
        public void DoubleDateToTicks(){} // RVA: 0x7FFD53A27D10
        public void Equals(){} // RVA: 0x7FFD53A27F70 | overloaded x3
        public void FromBinary(){} // RVA: 0x7FFD53A27FE0
        public void FromBinaryRaw(){} // RVA: 0x7FFD53A28250
        public void FromFileTime(){} // RVA: 0x7FFD53A282F0
        public void FromFileTimeUtc(){} // RVA: 0x7FFD53A28390
        public void FromOADate(){} // RVA: 0x7FFD53A28450
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53A28600
        public void IsDaylightSavingTime(){} // RVA: 0x7FFD53A28700
        public void SpecifyKind(){} // RVA: 0x7FFD53A28810
        public void ToBinary(){} // RVA: 0x7FFD53A28890
        public void get_Date(){} // RVA: 0x7FFD53A289E0
        public void GetDatePart(){} // RVA: 0x7FFD53A28C50 | overloaded x2
        public void get_Day(){} // RVA: 0x7FFD53A28E30
        public void get_DayOfWeek(){} // RVA: 0x7FFD53A28E90
        public void get_DayOfYear(){} // RVA: 0x7FFD53A28F20
        public void GetHashCode(){} // RVA: 0x7FFD53A28F80
        public void get_Hour(){} // RVA: 0x7FFD53A28FE0
        public void IsAmbiguousDaylightSavingTime(){} // RVA: 0x7FFD53A29070
        public void get_Kind(){} // RVA: 0x7FFD53A290D0
        public void get_Millisecond(){} // RVA: 0x7FFD53A29150
        public void get_Minute(){} // RVA: 0x7FFD53A291F0
        public void get_Month(){} // RVA: 0x7FFD53A29290
        public void get_Now(){} // RVA: 0x7FFD53A292F0
        public void get_Second(){} // RVA: 0x7FFD53A294B0
        public void get_Ticks(){} // RVA: 0x7FFD53A29550
        public void get_TimeOfDay(){} // RVA: 0x7FFD53A295B0
        public void get_Today(){} // RVA: 0x7FFD53A29620
        public void get_Year(){} // RVA: 0x7FFD53A296E0
        public void IsLeapYear(){} // RVA: 0x7FFD53A29740
        public void Parse(){} // RVA: 0x7FFD53A29A10 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFD53A29E70 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFD53A2A130 | overloaded x2
        public void TicksToOADate(){} // RVA: 0x7FFD53A2A240
        public void ToOADate(){} // RVA: 0x7FFD53A2A360
        public void ToFileTime(){} // RVA: 0x7FFD53A2A4C0
        public void ToFileTimeUtc(){} // RVA: 0x7FFD53A2A520
        public void ToLocalTime(){} // RVA: 0x7FFD53A2A670 | overloaded x2
        public void ToLongDateString(){} // RVA: 0x7FFD53A2A8F0
        public void ToLongTimeString(){} // RVA: 0x7FFD53A2A960
        public void ToShortDateString(){} // RVA: 0x7FFD53A2A9D0
        public void ToShortTimeString(){} // RVA: 0x7FFD53A2AA40
        public void ToString(){} // RVA: 0x7FFD53A2ABF0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A2AC70
        public void ToUniversalTime(){} // RVA: 0x7FFD53A2AD70
        public void TryParse(){} // RVA: 0x7FFD53A2AFE0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFD53A2B430 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD53A2B690
        public void op_Subtraction(){} // RVA: 0x7FFD53A2B8B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD53A2B920
        public void op_Inequality(){} // RVA: 0x7FFD53A2B990
        public void op_LessThan(){} // RVA: 0x7FFD53A2BA00
        public void op_LessThanOrEqual(){} // RVA: 0x7FFD53A2BA70
        public void op_GreaterThan(){} // RVA: 0x7FFD53A2BAE0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFD53A2BB50
        public void GetDateTimeFormats(){} // RVA: 0x7FFD53A2BE10 | overloaded x4
        public void GetTypeCode(){} // RVA: 0x7FFD5072B540
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A2BEC0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A2BF50
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A2BFE0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A2C070
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A2C100
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A2C190
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A2C220
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A2C2B0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A2C340
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A2C3D0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A2C460
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A2C4F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A2C580
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD4EEF9F60
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A2C610
        public void TryCreate(){} // RVA: 0x7FFD53A2C6B0
        public void get_UtcNow(){} // RVA: 0x7FFD53A2C8C0
        public void GetSystemTimeAsFileTime(){} // RVA: 0x7FFD53A2C930
        public void ToBinaryRaw(){} // RVA: 0x7FFD4EEF9F60
        public void .cctor(){} // RVA: 0x7FFD53A2C950
    }

    public class DateTimeFormat : Object
    {
        // ── Methods ──
        public void FormatDigits(){} // RVA: 0x7FFD53A34FC0 | overloaded x2
        public void HebrewFormatDigits(){} // RVA: 0x7FFD53A350C0
        public void ParseRepeatPattern(){} // RVA: 0x7FFD53A35140
        public void FormatDayOfWeek(){} // RVA: 0x7FFD53A351C0
        public void FormatMonth(){} // RVA: 0x7FFD53A35200
        public void FormatHebrewMonthName(){} // RVA: 0x7FFD53A35240
        public void ParseQuoteString(){} // RVA: 0x7FFD53A35310
        public void ParseNextChar(){} // RVA: 0x7FFD53A35500
        public void IsUseGenitiveForm(){} // RVA: 0x7FFD53A35570
        public void FormatCustomized(){} // RVA: 0x7FFD53A356B0
        public void FormatCustomizedTimeZone(){} // RVA: 0x7FFD53A36B80
        public void FormatCustomizedRoundripTimeZone(){} // RVA: 0x7FFD53A37090
        public void Append2DigitNumber(){} // RVA: 0x7FFD53A373C0
        public void GetRealFormat(){} // RVA: 0x7FFD53A374D0
        public void ExpandPredefinedFormat(){} // RVA: 0x7FFD53A379C0
        public void Format(){} // RVA: 0x7FFD53A37EB0 | overloaded x2
        public void TryFormat(){} // RVA: 0x7FFD53A38280 | overloaded x2
        public void FormatStringBuilder(){} // RVA: 0x7FFD53A384C0
        public void TryFormatO(){} // RVA: 0x7FFD53A38850
        public void TryFormatR(){} // RVA: 0x7FFD53A39070
        public void WriteTwoDecimalDigits(){} // RVA: 0x7FFD53A39570
        public void WriteFourDecimalDigits(){} // RVA: 0x7FFD53A395D0
        public void WriteDigits(){} // RVA: 0x7FFD53A396A0
        public void GetAllDateTimes(){} // RVA: 0x7FFD53A39BE0 | overloaded x2
        public void InvalidFormatForLocal(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53A39E30
    }

    public class DateTimeOffset : ValueType
    {
        public object Now;
        public object UtcNow;
        public object DateTime;
        public object UtcDateTime;
        public object LocalDateTime;
        public object ClockDateTime;
        public object Date;
        public object Day;
        public object DayOfWeek;
        public object DayOfYear;
        public object Hour;
        public object Millisecond;
        public object Minute;
        public object Month;
        public object Offset;
        public object Second;
        public object Ticks;
        public object UtcTicks;
        public object TimeOfDay;
        public object Year;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A30020 | overloaded x7
        public void get_Now(){} // RVA: 0x7FFD53A2D340
        public void get_UtcNow(){} // RVA: 0x7FFD53A2D3B0
        public void get_DateTime(){} // RVA: 0x7FFD53A2D420
        public void get_UtcDateTime(){} // RVA: 0x7FFD53A2D470
        public void get_LocalDateTime(){} // RVA: 0x7FFD53A2D4D0
        public void ToOffset(){} // RVA: 0x7FFD53A2D5D0
        public void get_ClockDateTime(){} // RVA: 0x7FFD53A2D6A0
        public void get_Date(){} // RVA: 0x7FFD53A2D7E0
        public void get_Day(){} // RVA: 0x7FFD53A2D8D0
        public void get_DayOfWeek(){} // RVA: 0x7FFD53A2D9A0
        public void get_DayOfYear(){} // RVA: 0x7FFD53A2DAA0
        public void get_Hour(){} // RVA: 0x7FFD53A2DB70
        public void get_Millisecond(){} // RVA: 0x7FFD53A2DC70
        public void get_Minute(){} // RVA: 0x7FFD53A2DD70
        public void get_Month(){} // RVA: 0x7FFD53A2DE70
        public void get_Offset(){} // RVA: 0x7FFD53A2DF40
        public void get_Second(){} // RVA: 0x7FFD53A2DFA0
        public void get_Ticks(){} // RVA: 0x7FFD53A2E0A0
        public void get_UtcTicks(){} // RVA: 0x7FFD53A2E160
        public void get_TimeOfDay(){} // RVA: 0x7FFD53A2E260
        public void get_Year(){} // RVA: 0x7FFD53A2E330
        public void Add(){} // RVA: 0x7FFD53A2E3F0
        public void AddDays(){} // RVA: 0x7FFD53A2E530
        public void AddHours(){} // RVA: 0x7FFD53A2E680
        public void AddMilliseconds(){} // RVA: 0x7FFD53A2E7D0
        public void AddMinutes(){} // RVA: 0x7FFD53A2E920
        public void AddMonths(){} // RVA: 0x7FFD53A2EA70
        public void AddSeconds(){} // RVA: 0x7FFD53A2EB80
        public void AddTicks(){} // RVA: 0x7FFD53A2ECD0
        public void AddYears(){} // RVA: 0x7FFD53A2EDE0
        public void Compare(){} // RVA: 0x7FFD53A2EEF0
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFD53A2F010
        public void CompareTo(){} // RVA: 0x7FFD53A2F1C0
        public void Equals(){} // RVA: 0x7FFD53A2F920 | overloaded x3
        public void EqualsExact(){} // RVA: 0x7FFD53A2F650
        public void FromFileTime(){} // RVA: 0x7FFD53A2FA80
        public void FromUnixTimeSeconds(){} // RVA: 0x7FFD53A2FB00
        public void FromUnixTimeMilliseconds(){} // RVA: 0x7FFD53A2FC70
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD53A2FDE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53A2FF50
        public void GetHashCode(){} // RVA: 0x7FFD53A301F0
        public void Parse(){} // RVA: 0x7FFD53A30530 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFD53A30A40 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFD53A30EA0 | overloaded x2
        public void ToFileTime(){} // RVA: 0x7FFD53A30FB0
        public void ToUnixTimeSeconds(){} // RVA: 0x7FFD53A310C0
        public void ToUnixTimeMilliseconds(){} // RVA: 0x7FFD53A311E0
        public void ToLocalTime(){} // RVA: 0x7FFD53A31370 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53A31760 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A31870
        public void ToUniversalTime(){} // RVA: 0x7FFD53A319B0
        public void TryParse(){} // RVA: 0x7FFD53A31C10 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFD53A32200 | overloaded x2
        public void ValidateOffset(){} // RVA: 0x7FFD53A32520
        public void ValidateDate(){} // RVA: 0x7FFD53A326A0
        public void ValidateStyles(){} // RVA: 0x7FFD53A327F0
        public void op_Implicit(){} // RVA: 0x7FFD53A32910
        public void op_Addition(){} // RVA: 0x7FFD53A32930
        public void op_Subtraction(){} // RVA: 0x7FFD53A32B50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD53A32C70
        public void op_Inequality(){} // RVA: 0x7FFD53A32DD0
        public void op_LessThan(){} // RVA: 0x7FFD53A32F30
        public void op_LessThanOrEqual(){} // RVA: 0x7FFD53A33050
        public void op_GreaterThan(){} // RVA: 0x7FFD53A33170
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFD53A33290
        public void .cctor(){} // RVA: 0x7FFD53A333B0
    }

    public class Decimal : ValueType
    {
        public object High;
        public object Low;
        public object Mid;
        public object IsNegative;
        public object Scale;
        public object Low64;

        // ── Methods ──
        public void get_High(){} // RVA: 0x7FFD4F8402A0
        public void get_Low(){} // RVA: 0x7FFD4FDE7500
        public void get_Mid(){} // RVA: 0x7FFD4FDE7520
        public void get_IsNegative(){} // RVA: 0x7FFD53A4EBA0
        public void get_Scale(){} // RVA: 0x7FFD4FD7DE20
        public void get_Low64(){} // RVA: 0x7FFD53AD0AF0
        public void AsMutable(){} // RVA: 0x7FFD4F9181E0
        public void DecDivMod1E9(){} // RVA: 0x7FFD53AD0B30
        public void .ctor(){} // RVA: 0x7FFD53AD11F0 | overloaded x9
        public void FromOACurrency(){} // RVA: 0x7FFD53AD0DB0
        public void ToOACurrency(){} // RVA: 0x7FFD53AD0EB0
        public void IsValid(){} // RVA: 0x7FFD53AD0F30
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD53AD1140
        public void Abs(){} // RVA: 0x7FFD53AD1200
        public void Add(){} // RVA: 0x7FFD53AD1220
        public void Ceiling(){} // RVA: 0x7FFD53AD12C0
        public void Compare(){} // RVA: 0x7FFD53AD1370
        public void CompareTo(){} // RVA: 0x7FFD53AD14E0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFD53AD1540
        public void Equals(){} // RVA: 0x7FFD53AD18A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD53AD1710
        public void Floor(){} // RVA: 0x7FFD53AD1910
        public void ToString(){} // RVA: 0x7FFD53AD1C30 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53AD1D20
        public void Parse(){} // RVA: 0x7FFD53AD20C0 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFD53AD22B0 | overloaded x2
        public void GetBits(){} // RVA: 0x7FFD53AD23B0
        public void Max(){} // RVA: 0x7FFD53AD2440
        public void Min(){} // RVA: 0x7FFD53AD24B0
        public void Remainder(){} // RVA: 0x7FFD53AD2520
        public void Multiply(){} // RVA: 0x7FFD53AD25C0
        public void Negate(){} // RVA: 0x7FFD53AD2660
        public void Round(){} // RVA: 0x7FFD53AD2920 | overloaded x5
        public void Sign(){} // RVA: 0x7FFD53AD2AF0
        public void Subtract(){} // RVA: 0x7FFD53AD2B10
        public void ToByte(){} // RVA: 0x7FFD53AD2BB0
        public void ToSByte(){} // RVA: 0x7FFD53AD2CD0
        public void ToInt16(){} // RVA: 0x7FFD53AD2DF0
        public void ToDouble(){} // RVA: 0x7FFD53AD2F10
        public void ToInt32(){} // RVA: 0x7FFD53AD2F60
        public void ToInt64(){} // RVA: 0x7FFD53AD3030
        public void ToUInt16(){} // RVA: 0x7FFD53AD3120
        public void ToUInt32(){} // RVA: 0x7FFD53AD3240
        public void ToUInt64(){} // RVA: 0x7FFD53AD3300
        public void ToSingle(){} // RVA: 0x7FFD53AD33E0
        public void Truncate(){} // RVA: 0x7FFD53AD34E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD53AD36A0 | overloaded x9
        public void op_Explicit(){} // RVA: 0x7FFD53AD3BA0 | overloaded x13
        public void op_UnaryNegation(){} // RVA: 0x7FFD53AD2660
        public void op_Increment(){} // RVA: 0x7FFD53AD3C30
        public void op_Decrement(){} // RVA: 0x7FFD53AD3D20
        public void op_Addition(){} // RVA: 0x7FFD53AD3E10
        public void op_Subtraction(){} // RVA: 0x7FFD53AD3EB0
        public void op_Multiply(){} // RVA: 0x7FFD53AD3F50
        public void op_Division(){} // RVA: 0x7FFD53AD3FF0
        public void op_Modulus(){} // RVA: 0x7FFD53AD4090
        public void op_Equality(){} // RVA: 0x7FFD53AD4130
        public void op_Inequality(){} // RVA: 0x7FFD53AD41A0
        public void op_LessThan(){} // RVA: 0x7FFD53AD4210
        public void op_LessThanOrEqual(){} // RVA: 0x7FFD53AD4280
        public void op_GreaterThan(){} // RVA: 0x7FFD53AD42F0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFD53AD4360
        public void GetTypeCode(){} // RVA: 0x7FFD4F2654F0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53AD43D0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53AD4440
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53AD44D0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53AD4540
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53AD45B0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53AD4620
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53AD4690
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53AD4700
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53AD4770
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53AD47E0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53AD4850
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53AD48F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD4E6E0590
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53AD4960
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53AD49F0
        public void .cctor(){} // RVA: 0x7FFD53AD4A90
    }

    public class DefaultBinder : Binder
    {
        // ── Methods ──
        public void BindToMethod(){} // RVA: 0x7FFD53A8E6E0
        public void BindToField(){} // RVA: 0x7FFD53A90CB0
        public void SelectProperty(){} // RVA: 0x7FFD53A913A0
        public void ChangeType(){} // RVA: 0x7FFD53A92180
        public void ReorderArgumentArray(){} // RVA: 0x7FFD53A921E0
        public void ExactBinding(){} // RVA: 0x7FFD53A92650
        public void ExactPropertyBinding(){} // RVA: 0x7FFD53A928C0
        public void FindMostSpecific(){} // RVA: 0x7FFD53A92B90
        public void FindMostSpecificType(){} // RVA: 0x7FFD53A92F60
        public void FindMostSpecificMethod(){} // RVA: 0x7FFD53A933A0
        public void FindMostSpecificField(){} // RVA: 0x7FFD53A93990
        public void FindMostSpecificProperty(){} // RVA: 0x7FFD53A93AE0
        public void CompareMethodSigAndName(){} // RVA: 0x7FFD53A93C30
        public void GetHierarchyDepth(){} // RVA: 0x7FFD53A93D90
        public void FindMostDerivedNewSlotMeth(){} // RVA: 0x7FFD53A93E10
        public void ReorderParams(){} // RVA: 0x7FFD53A93F60
        public void CreateParamOrder(){} // RVA: 0x7FFD53A94190
        public void CanConvertPrimitive(){} // RVA: 0x7FFD53A943B0
        public void CanConvertPrimitiveObjectToType(){} // RVA: 0x7FFD53A946A0
        public void CompareMethodSig(){} // RVA: 0x7FFD53A947C0
        public void SelectMethod(){} // RVA: 0x7FFD53A94920
        public void CanChangePrimitive(){} // RVA: 0x7FFD53A95130
        public void CanPrimitiveWiden(){} // RVA: 0x7FFD53A952F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53A95470
    }

    public class Delegate : Object
    {
        public UIntPtr Method; // 0x10
        public UIntPtr Target; // 0x18
        public object m_target; // 0x20
        public UIntPtr method; // 0x28
        public UIntPtr delegate_trampoline; // 0x30
        public UIntPtr extra_arg; // 0x38
        public UIntPtr method_code; // 0x40
        public UIntPtr interp_method; // 0x48
        public UIntPtr interp_invoke_impl; // 0x50
        public m.jectMapInfo method_info; // 0x58
        public m.jectMapInfo original_method_info; // 0x60
        public mespace data; // 0x68
        public bool method_is_virtual; // 0x70

        // ── Methods ──
        public void get_Method(){} // RVA: 0x7FFD4E51EBD0
        public void GetVirtualMethod_internal(){} // RVA: 0x7FFD53AB9790
        public void get_Target(){} // RVA: 0x7FFD4E36F0C0
        public void CreateDelegate_internal(){} // RVA: 0x7FFD53AB97C0
        public void arg_type_match(){} // RVA: 0x7FFD53AB9880
        public void arg_type_match_this(){} // RVA: 0x7FFD53AB9AA0
        public void return_type_match(){} // RVA: 0x7FFD53AB9C10
        public void CreateDelegate(){} // RVA: 0x7FFD53ABB480 | overloaded x10
        public void GetCandidateMethod(){} // RVA: 0x7FFD53ABAC40
        public void DynamicInvoke(){} // RVA: 0x7FFD51D36740
        public void InitializeDelegateData(){} // RVA: 0x7FFD53ABB5B0
        public void DynamicInvokeImpl(){} // RVA: 0x7FFD53ABB7A0
        public void Clone(){} // RVA: 0x7FFD53932B10
        public void Equals(){} // RVA: 0x7FFD53ABBC40
        public void GetHashCode(){} // RVA: 0x7FFD53ABBE70
        public void GetMethodImpl(){} // RVA: 0x7FFD53ABBEE0
        public void GetObjectData(){} // RVA: 0x7FFD53ABC000
        public void GetInvocationList(){} // RVA: 0x7FFD53ABC020
        public void Combine(){} // RVA: 0x7FFD53ABC240 | overloaded x2
        public void CombineImpl(){} // RVA: 0x7FFD53ABC410
        public void Remove(){} // RVA: 0x7FFD53ABC470
        public void RemoveImpl(){} // RVA: 0x7FFD53ABC5F0
        public void op_Equality(){} // RVA: 0x7FFD53ABC620
        public void op_Inequality(){} // RVA: 0x7FFD53ABC650
        public void AllocDelegateLike_internal(){} // RVA: 0x7FFD53ABC6A0
    }

    public class Double : ValueType
    {
        public double m_value; // 0x10
        public double MinValue;
        public double MaxValue;
        public double Epsilon;
        public double NegativeInfinity;
        public double PositiveInfinity;
        public double NaN;
        public double NegativeZero;

        // ── Methods ──
        public void IsFinite(){} // RVA: 0x7FFD53A335D0
        public void IsInfinity(){} // RVA: 0x7FFD53A33600
        public void IsNaN(){} // RVA: 0x7FFD53A33630
        public void IsNegative(){} // RVA: 0x7FFD53A33660
        public void IsNegativeInfinity(){} // RVA: 0x7FFD53A33670
        public void IsPositiveInfinity(){} // RVA: 0x7FFD53A33690
        public void CompareTo(){} // RVA: 0x7FFD53A337E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD53A33900 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD511C2860
        public void ToString(){} // RVA: 0x7FFD53A33AB0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A33B40
        public void Parse(){} // RVA: 0x7FFD53A33E70 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFD53A340B0 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFD4F626550
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A343A0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A34410
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A344A0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A34500
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A34560
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A345C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A34620
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A34680
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A346E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A34740
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A347A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD4FBF1AC0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A34800
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A34880
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A34910
    }

}