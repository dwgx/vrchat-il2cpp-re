// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 19
// Methods: 613

namespace ThirdParty.DotNet.System
{
    public class DBNull : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869AEC30 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE869AEC80
        public void ToString(){} // RVA: 0x7FFE869AECD0 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFE81200CB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869AED10
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869AED60
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869AEDB0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869AEE00
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE869AEE50
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869AEEA0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE869AEEF0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869AEF40
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE869AEF90
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869AEFE0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869AF030
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE869AF080
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869AF0D0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE869AF120
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869AF170
        public void .cctor(){} // RVA: 0x7FFE869AF1E0
    }

    public class DTSubString : ValueType
    {
        public System.ReadOnlySpan`1<char> s; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE869D3590
    }

    public class DateTime : ValueType
    {
        public long TicksPerMillisecond;
        public long TicksPerSecond;
        public long TicksPerMinute;
        public long TicksPerHour;
        public long TicksPerDay;
        public int MillisPerSecond;
        public int MillisPerMinute;
        public int MillisPerHour;
        public int MillisPerDay;
        public int DaysPerYear;
        public int DaysPer4Years;
        public int DaysPer100Years;
        public int DaysPer400Years;
        public int DaysTo1601;
        public int DaysTo1899;
        public int DaysTo1970;
        public int DaysTo10000;
        public long MinTicks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869B0280 | overloaded x14
        public void get_InternalTicks(){} // RVA: 0x7FFE869B06E0
        public void get_InternalKind(){} // RVA: 0x7FFE869B0700
        public void Add(){} // RVA: 0x7FFE869B0780 | overloaded x2
        public void AddDays(){} // RVA: 0x7FFE869B08A0
        public void AddHours(){} // RVA: 0x7FFE869B0910
        public void AddMilliseconds(){} // RVA: 0x7FFE869B0980
        public void AddMinutes(){} // RVA: 0x7FFE869B09F0
        public void AddMonths(){} // RVA: 0x7FFE869B0A60
        public void AddSeconds(){} // RVA: 0x7FFE869B0CB0
        public void AddTicks(){} // RVA: 0x7FFE869B0D20
        public void AddYears(){} // RVA: 0x7FFE869B0E30
        public void Compare(){} // RVA: 0x7FFE869B0F00
        public void CompareTo(){} // RVA: 0x7FFE869B1070 | overloaded x2
        public void DateToTicks(){} // RVA: 0x7FFE869B10E0
        public void TimeToTicks(){} // RVA: 0x7FFE869B12C0
        public void DaysInMonth(){} // RVA: 0x7FFE869B1390
        public void DoubleDateToTicks(){} // RVA: 0x7FFE869B14E0
        public void Equals(){} // RVA: 0x7FFE869B1740 | overloaded x3
        public void FromBinary(){} // RVA: 0x7FFE869B17B0
        public void FromBinaryRaw(){} // RVA: 0x7FFE869B1A20
        public void FromFileTime(){} // RVA: 0x7FFE869B1AC0
        public void FromFileTimeUtc(){} // RVA: 0x7FFE869B1B60
        public void FromOADate(){} // RVA: 0x7FFE869B1C20
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE869B1DD0
        public void IsDaylightSavingTime(){} // RVA: 0x7FFE869B1ED0
        public void SpecifyKind(){} // RVA: 0x7FFE869B1FE0
        public void ToBinary(){} // RVA: 0x7FFE869B2060
        public void get_Date(){} // RVA: 0x7FFE869B21B0
        public void GetDatePart(){} // RVA: 0x7FFE869B2420 | overloaded x2
        public void get_Day(){} // RVA: 0x7FFE869B2600
        public void get_DayOfWeek(){} // RVA: 0x7FFE869B2660
        public void get_DayOfYear(){} // RVA: 0x7FFE869B26F0
        public void GetHashCode(){} // RVA: 0x7FFE869B2750
        public void get_Hour(){} // RVA: 0x7FFE869B27B0
        public void IsAmbiguousDaylightSavingTime(){} // RVA: 0x7FFE869B2840
        public void get_Kind(){} // RVA: 0x7FFE869B28A0
        public void get_Millisecond(){} // RVA: 0x7FFE869B2920
        public void get_Minute(){} // RVA: 0x7FFE869B29C0
        public void get_Month(){} // RVA: 0x7FFE869B2A60
        public void get_Now(){} // RVA: 0x7FFE869B2AC0
        public void get_Second(){} // RVA: 0x7FFE869B2C80
        public void get_Ticks(){} // RVA: 0x7FFE869B2D20
        public void get_TimeOfDay(){} // RVA: 0x7FFE869B2D80
        public void get_Today(){} // RVA: 0x7FFE869B2DF0
        public void get_Year(){} // RVA: 0x7FFE869B2EB0
        public void IsLeapYear(){} // RVA: 0x7FFE869B2F10
        public void Parse(){} // RVA: 0x7FFE869B31E0 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFE869B3640 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFE869B3900 | overloaded x2
        public void TicksToOADate(){} // RVA: 0x7FFE869B3A10
        public void ToOADate(){} // RVA: 0x7FFE869B3B30
        public void ToFileTime(){} // RVA: 0x7FFE869B3C90
        public void ToFileTimeUtc(){} // RVA: 0x7FFE869B3CF0
        public void ToLocalTime(){} // RVA: 0x7FFE869B3E40 | overloaded x2
        public void ToLongDateString(){} // RVA: 0x7FFE869B40C0
        public void ToLongTimeString(){} // RVA: 0x7FFE869B4130
        public void ToShortDateString(){} // RVA: 0x7FFE869B41A0
        public void ToShortTimeString(){} // RVA: 0x7FFE869B4210
        public void ToString(){} // RVA: 0x7FFE869B43C0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869B4440
        public void ToUniversalTime(){} // RVA: 0x7FFE869B4540
        public void TryParse(){} // RVA: 0x7FFE869B47B0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFE869B4C00 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFE869B4E60
        public void op_Subtraction(){} // RVA: 0x7FFE869B5080 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE869B50F0
        public void op_Inequality(){} // RVA: 0x7FFE869B5160
        public void op_LessThan(){} // RVA: 0x7FFE869B51D0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE869B5240
        public void op_GreaterThan(){} // RVA: 0x7FFE869B52B0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE869B5320
        public void GetDateTimeFormats(){} // RVA: 0x7FFE869B55E0 | overloaded x4
        public void GetTypeCode(){} // RVA: 0x7FFE835C1D80
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869B5690
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869B5720
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869B57B0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869B5840
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE869B58D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869B5960
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE869B59F0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869B5A80
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE869B5B10
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869B5BA0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869B5C30
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE869B5CC0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869B5D50
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE8284EF60
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869B5DE0
        public void TryCreate(){} // RVA: 0x7FFE869B5E80
        public void get_UtcNow(){} // RVA: 0x7FFE869B6090
        public void GetSystemTimeAsFileTime(){} // RVA: 0x7FFE869B6100
        public void ToBinaryRaw(){} // RVA: 0x7FFE8284EF60
        public void .cctor(){} // RVA: 0x7FFE869B6120
    }

    public class DateTimeFormat : Object
    {
        // ── Methods ──
        public void FormatDigits(){} // RVA: 0x7FFE869BE790 | overloaded x2
        public void HebrewFormatDigits(){} // RVA: 0x7FFE869BE890
        public void ParseRepeatPattern(){} // RVA: 0x7FFE869BE910
        public void FormatDayOfWeek(){} // RVA: 0x7FFE869BE990
        public void FormatMonth(){} // RVA: 0x7FFE869BE9D0
        public void FormatHebrewMonthName(){} // RVA: 0x7FFE869BEA10
        public void ParseQuoteString(){} // RVA: 0x7FFE869BEAE0
        public void ParseNextChar(){} // RVA: 0x7FFE869BECD0
        public void IsUseGenitiveForm(){} // RVA: 0x7FFE869BED40
        public void FormatCustomized(){} // RVA: 0x7FFE869BEE80
        public void FormatCustomizedTimeZone(){} // RVA: 0x7FFE869C0350
        public void FormatCustomizedRoundripTimeZone(){} // RVA: 0x7FFE869C0860
        public void Append2DigitNumber(){} // RVA: 0x7FFE869C0B90
        public void GetRealFormat(){} // RVA: 0x7FFE869C0CA0
        public void ExpandPredefinedFormat(){} // RVA: 0x7FFE869C1190
        public void Format(){} // RVA: 0x7FFE869C1680 | overloaded x2
        public void TryFormat(){} // RVA: 0x7FFE869C1A50 | overloaded x2
        public void FormatStringBuilder(){} // RVA: 0x7FFE869C1C90
        public void TryFormatO(){} // RVA: 0x7FFE869C2020
        public void TryFormatR(){} // RVA: 0x7FFE869C2840
        public void WriteTwoDecimalDigits(){} // RVA: 0x7FFE869C2D40
        public void WriteFourDecimalDigits(){} // RVA: 0x7FFE869C2DA0
        public void WriteDigits(){} // RVA: 0x7FFE869C2E70
        public void GetAllDateTimes(){} // RVA: 0x7FFE869C33B0 | overloaded x2
        public void InvalidFormatForLocal(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE869C3600
    }

    public class DateTimeOffset : ValueType
    {
        public long MaxOffset;
        public long MinOffset;
        public long UnixEpochSeconds;
        public long UnixEpochMilliseconds;
        public long UnixMinSeconds;
        public long UnixMaxSeconds;
        public System.DateTimeOffset MinValue;
        public System.DateTimeOffset MaxValue; // 0x10
        public System.DateTimeOffset UnixEpoch; // 0x20
        public System.DateTime _dateTime; // 0x10
        public short _offsetMinutes; // 0x18
        public object System; // 0x5A90
        public object field_12;
        public object System;
        public object field_14; // 0x2D0
        public object field_15;
        public object field_16;
        public object field_17;
        public object field_18;
        public object field_19;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869B97F0 | overloaded x7
        public void get_Now(){} // RVA: 0x7FFE869B6B10
        public void get_UtcNow(){} // RVA: 0x7FFE869B6B80
        public void get_DateTime(){} // RVA: 0x7FFE869B6BF0
        public void get_UtcDateTime(){} // RVA: 0x7FFE869B6C40
        public void get_LocalDateTime(){} // RVA: 0x7FFE869B6CA0
        public void ToOffset(){} // RVA: 0x7FFE869B6DA0
        public void get_ClockDateTime(){} // RVA: 0x7FFE869B6E70
        public void get_Date(){} // RVA: 0x7FFE869B6FB0
        public void get_Day(){} // RVA: 0x7FFE869B70A0
        public void get_DayOfWeek(){} // RVA: 0x7FFE869B7170
        public void get_DayOfYear(){} // RVA: 0x7FFE869B7270
        public void get_Hour(){} // RVA: 0x7FFE869B7340
        public void get_Millisecond(){} // RVA: 0x7FFE869B7440
        public void get_Minute(){} // RVA: 0x7FFE869B7540
        public void get_Month(){} // RVA: 0x7FFE869B7640
        public void get_Offset(){} // RVA: 0x7FFE869B7710
        public void get_Second(){} // RVA: 0x7FFE869B7770
        public void get_Ticks(){} // RVA: 0x7FFE869B7870
        public void get_UtcTicks(){} // RVA: 0x7FFE869B7930
        public void get_TimeOfDay(){} // RVA: 0x7FFE869B7A30
        public void get_Year(){} // RVA: 0x7FFE869B7B00
        public void Add(){} // RVA: 0x7FFE869B7BC0
        public void AddDays(){} // RVA: 0x7FFE869B7D00
        public void AddHours(){} // RVA: 0x7FFE869B7E50
        public void AddMilliseconds(){} // RVA: 0x7FFE869B7FA0
        public void AddMinutes(){} // RVA: 0x7FFE869B80F0
        public void AddMonths(){} // RVA: 0x7FFE869B8240
        public void AddSeconds(){} // RVA: 0x7FFE869B8350
        public void AddTicks(){} // RVA: 0x7FFE869B84A0
        public void AddYears(){} // RVA: 0x7FFE869B85B0
        public void Compare(){} // RVA: 0x7FFE869B86C0
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE869B87E0
        public void CompareTo(){} // RVA: 0x7FFE869B8990
        public void Equals(){} // RVA: 0x7FFE869B90F0 | overloaded x3
        public void EqualsExact(){} // RVA: 0x7FFE869B8E20
        public void FromFileTime(){} // RVA: 0x7FFE869B9250
        public void FromUnixTimeSeconds(){} // RVA: 0x7FFE869B92D0
        public void FromUnixTimeMilliseconds(){} // RVA: 0x7FFE869B9440
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE869B95B0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE869B9720
        public void GetHashCode(){} // RVA: 0x7FFE869B99C0
        public void Parse(){} // RVA: 0x7FFE869B9D00 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFE869BA210 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFE869BA670 | overloaded x2
        public void ToFileTime(){} // RVA: 0x7FFE869BA780
        public void ToUnixTimeSeconds(){} // RVA: 0x7FFE869BA890
        public void ToUnixTimeMilliseconds(){} // RVA: 0x7FFE869BA9B0
        public void ToLocalTime(){} // RVA: 0x7FFE869BAB40 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE869BAF30 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869BB040
        public void ToUniversalTime(){} // RVA: 0x7FFE869BB180
        public void TryParse(){} // RVA: 0x7FFE869BB3E0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFE869BB9D0 | overloaded x2
        public void ValidateOffset(){} // RVA: 0x7FFE869BBCF0
        public void ValidateDate(){} // RVA: 0x7FFE869BBE70
        public void ValidateStyles(){} // RVA: 0x7FFE869BBFC0
        public void op_Implicit(){} // RVA: 0x7FFE869BC0E0
        public void op_Addition(){} // RVA: 0x7FFE869BC100
        public void op_Subtraction(){} // RVA: 0x7FFE869BC320 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE869BC440
        public void op_Inequality(){} // RVA: 0x7FFE869BC5A0
        public void op_LessThan(){} // RVA: 0x7FFE869BC700
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE869BC820
        public void op_GreaterThan(){} // RVA: 0x7FFE869BC940
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE869BCA60
        public void .cctor(){} // RVA: 0x7FFE869BCB80
    }

    public class DateTimeParse : Object
    {
        // ── Methods ──
        public void ParseExact(){} // RVA: 0x7FFE869C3D00 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFE869C43C0 | overloaded x3
        public void ParseExactMultiple(){} // RVA: 0x7FFE869C4630 | overloaded x2
        public void TryParseExactMultiple(){} // RVA: 0x7FFE869C4B40 | overloaded x3
        public void MatchWord(){} // RVA: 0x7FFE869C4E70
        public void GetTimeZoneName(){} // RVA: 0x7FFE869C5070
        public void IsDigit(){} // RVA: 0x7FFE869C5120
        public void ParseFraction(){} // RVA: 0x7FFE869C5130
        public void ParseTimeZone(){} // RVA: 0x7FFE869C5230
        public void HandleTimeZone(){} // RVA: 0x7FFE869C55F0
        public void Lex(){} // RVA: 0x7FFE869C57F0
        public void GetJapaneseCalendarDefaultInstance(){} // RVA: 0x7FFE869C69D0
        public void GetTaiwanCalendarDefaultInstance(){} // RVA: 0x7FFE869C6AD0
        public void VerifyValidPunctuation(){} // RVA: 0x7FFE869C6BD0
        public void GetYearMonthDayOrder(){} // RVA: 0x7FFE869C6E30
        public void GetYearMonthOrder(){} // RVA: 0x7FFE869C7050
        public void GetMonthDayOrder(){} // RVA: 0x7FFE869C71F0
        public void TryAdjustYear(){} // RVA: 0x7FFE869C73B0
        public void SetDateYMD(){} // RVA: 0x7FFE869C7410
        public void SetDateMDY(){} // RVA: 0x7FFE869C7490
        public void SetDateDMY(){} // RVA: 0x7FFE869C7520
        public void SetDateYDM(){} // RVA: 0x7FFE869C75B0
        public void GetDefaultYear(){} // RVA: 0x7FFE869C7640
        public void GetDayOfNN(){} // RVA: 0x7FFE869C76E0
        public void GetDayOfNNN(){} // RVA: 0x7FFE869C78A0
        public void GetDayOfMN(){} // RVA: 0x7FFE869C7CF0
        public void GetHebrewDayOfNM(){} // RVA: 0x7FFE869C7F30
        public void GetDayOfNM(){} // RVA: 0x7FFE869C80C0
        public void GetDayOfMNN(){} // RVA: 0x7FFE869C8300
        public void GetDayOfYNN(){} // RVA: 0x7FFE869C86B0
        public void GetDayOfNNY(){} // RVA: 0x7FFE869C8810
        public void GetDayOfYMN(){} // RVA: 0x7FFE869C89C0
        public void GetDayOfYN(){} // RVA: 0x7FFE869C8AB0
        public void GetDayOfYM(){} // RVA: 0x7FFE869C8B90
        public void AdjustTimeMark(){} // RVA: 0x7FFE869C8C70
        public void AdjustHour(){} // RVA: 0x7FFE869C8D30
        public void GetTimeOfN(){} // RVA: 0x7FFE869C8D70
        public void GetTimeOfNN(){} // RVA: 0x7FFE869C8DE0
        public void GetTimeOfNNN(){} // RVA: 0x7FFE869C8E60
        public void GetDateOfDSN(){} // RVA: 0x7FFE869C8EE0
        public void GetDateOfNDS(){} // RVA: 0x7FFE869C8F50
        public void GetDateOfNNDS(){} // RVA: 0x7FFE869C9030
        public void ProcessDateTimeSuffix(){} // RVA: 0x7FFE869C9280
        public void ProcessHebrewTerminalState(){} // RVA: 0x7FFE869C9340
        public void ProcessTerminalState(){} // RVA: 0x7FFE869C98C0
        public void Parse(){} // RVA: 0x7FFE869C9FA0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFE869CA430 | overloaded x3
        public void DetermineTimeZoneAdjustments(){} // RVA: 0x7FFE869CAEA0
        public void DateTimeOffsetTimeZonePostProcessing(){} // RVA: 0x7FFE869CB120
        public void AdjustTimeZoneToUniversal(){} // RVA: 0x7FFE869CB3E0
        public void AdjustTimeZoneToLocal(){} // RVA: 0x7FFE869CB520
        public void ParseISO8601(){} // RVA: 0x7FFE869CB820
        public void MatchHebrewDigits(){} // RVA: 0x7FFE869CBF10
        public void ParseDigits(){} // RVA: 0x7FFE869CC0C0 | overloaded x2
        public void ParseFractionExact(){} // RVA: 0x7FFE869CC1C0
        public void ParseSign(){} // RVA: 0x7FFE869CC350
        public void ParseTimeZoneOffset(){} // RVA: 0x7FFE869CC410
        public void MatchAbbreviatedMonthName(){} // RVA: 0x7FFE869CC710
        public void MatchMonthName(){} // RVA: 0x7FFE869CC9C0
        public void MatchAbbreviatedDayName(){} // RVA: 0x7FFE869CCDE0
        public void MatchDayName(){} // RVA: 0x7FFE869CCF50
        public void MatchEraName(){} // RVA: 0x7FFE869CD0C0
        public void MatchTimeMark(){} // RVA: 0x7FFE869CD240
        public void MatchAbbreviatedTimeMark(){} // RVA: 0x7FFE869CD3C0
        public void CheckNewValue(){} // RVA: 0x7FFE869CD520
        public void GetDateTimeNow(){} // RVA: 0x7FFE869CD5D0
        public void CheckDefaultDateTime(){} // RVA: 0x7FFE869CD730
        public void ExpandPredefinedFormat(){} // RVA: 0x7FFE869CD970
        public void ParseJapaneseEraStart(){} // RVA: 0x7FFE869CDE20
        public void ParseByFormat(){} // RVA: 0x7FFE869CDF20
        public void TryParseQuoteString(){} // RVA: 0x7FFE869CF9B0
        public void DoStrictParse(){} // RVA: 0x7FFE869CFAD0
        public void GetDateTimeParseException(){} // RVA: 0x7FFE869D0610
        public void .cctor(){} // RVA: 0x7FFE869D07D0
    }

    public class DateTimeRawInfo : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE869D35C0
        public void AddNumber(){} // RVA: 0x7FFE869D35F0
        public void GetNumber(){} // RVA: 0x7FFE851A9560
    }

    public class DateTimeResult : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE869D3610
        public void SetDate(){} // RVA: 0x7FFE855D5D40
        public void SetBadFormatSpecifierFailure(){} // RVA: 0x7FFE869D36B0 | overloaded x2
        public void SetBadDateTimeFailure(){} // RVA: 0x7FFE869D3710
        public void SetFailure(){} // RVA: 0x7FFE869D3780 | overloaded x3
    }

    public class DateTimeToken : ValueType
    {
    }

    public class Decimal : ValueType
    {
        public int SignMask;
        public int ScaleMask;
        public int ScaleShift;
        public System.Decimal Zero;
        public System.Decimal One; // 0x10
        public System.Decimal MinusOne; // 0x20

        // ── Methods ──
        public void get_High(){} // RVA: 0x7FFE826F42A0
        public void get_Low(){} // RVA: 0x7FFE82C33000
        public void get_Mid(){} // RVA: 0x7FFE82C33020
        public void get_IsNegative(){} // RVA: 0x7FFE869D8370
        public void get_Scale(){} // RVA: 0x7FFE82BC9950
        public void get_Low64(){} // RVA: 0x7FFE86A5A2A0
        public void AsMutable(){} // RVA: 0x7FFE827C4A80
        public void DecDivMod1E9(){} // RVA: 0x7FFE86A5A2E0
        public void .ctor(){} // RVA: 0x7FFE86A5A9A0 | overloaded x9
        public void FromOACurrency(){} // RVA: 0x7FFE86A5A560
        public void ToOACurrency(){} // RVA: 0x7FFE86A5A660
        public void IsValid(){} // RVA: 0x7FFE86A5A6E0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE86A5A8F0
        public void Abs(){} // RVA: 0x7FFE86A5A9B0
        public void Add(){} // RVA: 0x7FFE86A5A9D0
        public void Ceiling(){} // RVA: 0x7FFE86A5AA70
        public void Compare(){} // RVA: 0x7FFE86A5AB20
        public void CompareTo(){} // RVA: 0x7FFE86A5AC90 | overloaded x2
        public void Divide(){} // RVA: 0x7FFE86A5ACF0
        public void Equals(){} // RVA: 0x7FFE86A5B050 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE86A5AEC0
        public void Floor(){} // RVA: 0x7FFE86A5B0C0
        public void ToString(){} // RVA: 0x7FFE86A5B3E0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE86A5B4D0
        public void Parse(){} // RVA: 0x7FFE86A5B870 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFE86A5BA60 | overloaded x2
        public void GetBits(){} // RVA: 0x7FFE86A5BB60
        public void Max(){} // RVA: 0x7FFE86A5BBF0
        public void Min(){} // RVA: 0x7FFE86A5BC60
        public void Remainder(){} // RVA: 0x7FFE86A5BCD0
        public void Multiply(){} // RVA: 0x7FFE86A5BD70
        public void Negate(){} // RVA: 0x7FFE86A5BE10
        public void Round(){} // RVA: 0x7FFE86A5C0D0 | overloaded x5
        public void Sign(){} // RVA: 0x7FFE86A5C2A0
        public void Subtract(){} // RVA: 0x7FFE86A5C2C0
        public void ToByte(){} // RVA: 0x7FFE86A5C360
        public void ToSByte(){} // RVA: 0x7FFE86A5C480
        public void ToInt16(){} // RVA: 0x7FFE86A5C5A0
        public void ToDouble(){} // RVA: 0x7FFE86A5C6C0
        public void ToInt32(){} // RVA: 0x7FFE86A5C710
        public void ToInt64(){} // RVA: 0x7FFE86A5C7E0
        public void ToUInt16(){} // RVA: 0x7FFE86A5C8D0
        public void ToUInt32(){} // RVA: 0x7FFE86A5C9F0
        public void ToUInt64(){} // RVA: 0x7FFE86A5CAB0
        public void ToSingle(){} // RVA: 0x7FFE86A5CB90
        public void Truncate(){} // RVA: 0x7FFE86A5CC90 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE86A5CE50 | overloaded x9
        public void op_Explicit(){} // RVA: 0x7FFE86A5D350 | overloaded x13
        public void op_UnaryNegation(){} // RVA: 0x7FFE86A5BE10
        public void op_Increment(){} // RVA: 0x7FFE86A5D3E0
        public void op_Decrement(){} // RVA: 0x7FFE86A5D4D0
        public void op_Addition(){} // RVA: 0x7FFE86A5D5C0
        public void op_Subtraction(){} // RVA: 0x7FFE86A5D660
        public void op_Multiply(){} // RVA: 0x7FFE86A5D700
        public void op_Division(){} // RVA: 0x7FFE86A5D7A0
        public void op_Modulus(){} // RVA: 0x7FFE86A5D840
        public void op_Equality(){} // RVA: 0x7FFE86A5D8E0
        public void op_Inequality(){} // RVA: 0x7FFE86A5D950
        public void op_LessThan(){} // RVA: 0x7FFE86A5D9C0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE86A5DA30
        public void op_GreaterThan(){} // RVA: 0x7FFE86A5DAA0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE86A5DB10
        public void GetTypeCode(){} // RVA: 0x7FFE82127E50
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE86A5DB80
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE86A5DBF0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE86A5DC80
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE86A5DCF0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE86A5DD60
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE86A5DDD0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE86A5DE40
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE86A5DEB0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE86A5DF20
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE86A5DF90
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE86A5E000
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE86A5E0A0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE8151C410
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE86A5E110
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE86A5E1A0
        public void .cctor(){} // RVA: 0x7FFE86A5E240
    }

    public class DecimalDecCalc : Object
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x7FFE86A06D00
        public void DecDivMod1E9(){} // RVA: 0x7FFE86A06D60
        public void DecAddInt32(){} // RVA: 0x7FFE86A06E40
        public void D32AddCarry(){} // RVA: 0x7FFE86A06E70
        public void DecMul10(){} // RVA: 0x7FFE86A06E90
        public void DecShiftLeft(){} // RVA: 0x7FFE86A06F80
        public void DecAdd(){} // RVA: 0x7FFE86A06FB0
    }

    public class DefaultBinder : Binder
    {
        // ── Methods ──
        public void BindToMethod(){} // RVA: 0x7FFE86A17ED0
        public void BindToField(){} // RVA: 0x7FFE86A1A4A0
        public void SelectProperty(){} // RVA: 0x7FFE86A1AB90
        public void ChangeType(){} // RVA: 0x7FFE86A1B970
        public void ReorderArgumentArray(){} // RVA: 0x7FFE86A1B9D0
        public void ExactBinding(){} // RVA: 0x7FFE86A1BE40
        public void ExactPropertyBinding(){} // RVA: 0x7FFE86A1C0B0
        public void FindMostSpecific(){} // RVA: 0x7FFE86A1C380
        public void FindMostSpecificType(){} // RVA: 0x7FFE86A1C750
        public void FindMostSpecificMethod(){} // RVA: 0x7FFE86A1CB90
        public void FindMostSpecificField(){} // RVA: 0x7FFE86A1D180
        public void FindMostSpecificProperty(){} // RVA: 0x7FFE86A1D2D0
        public void CompareMethodSigAndName(){} // RVA: 0x7FFE86A1D420
        public void GetHierarchyDepth(){} // RVA: 0x7FFE86A1D580
        public void FindMostDerivedNewSlotMeth(){} // RVA: 0x7FFE86A1D600
        public void ReorderParams(){} // RVA: 0x7FFE86A1D750
        public void CreateParamOrder(){} // RVA: 0x7FFE86A1D980
        public void CanConvertPrimitive(){} // RVA: 0x7FFE86A1DBA0
        public void CanConvertPrimitiveObjectToType(){} // RVA: 0x7FFE86A1DE90
        public void CompareMethodSig(){} // RVA: 0x7FFE86A1DFB0
        public void SelectMethod(){} // RVA: 0x7FFE86A1E110
        public void CanChangePrimitive(){} // RVA: 0x7FFE86A1E920
        public void CanPrimitiveWiden(){} // RVA: 0x7FFE86A1EAE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86A1EC60
    }

    public class Delegate : Object
    {
        public UIntPtr method_ptr; // 0x10
        public UIntPtr invoke_impl; // 0x18

        // ── Methods ──
        public void get_Method(){} // RVA: 0x7FFE81768340
        public void GetVirtualMethod_internal(){} // RVA: 0x7FFE86A42F70
        public void get_Target(){} // RVA: 0x7FFE811290C0
        public void CreateDelegate_internal(){} // RVA: 0x7FFE86A42FA0
        public void arg_type_match(){} // RVA: 0x7FFE86A43060
        public void arg_type_match_this(){} // RVA: 0x7FFE86A43280
        public void return_type_match(){} // RVA: 0x7FFE86A433F0
        public void CreateDelegate(){} // RVA: 0x7FFE86A44C60 | overloaded x10
        public void GetCandidateMethod(){} // RVA: 0x7FFE86A44420
        public void DynamicInvoke(){} // RVA: 0x7FFE84C79010
        public void InitializeDelegateData(){} // RVA: 0x7FFE86A44D90
        public void DynamicInvokeImpl(){} // RVA: 0x7FFE86A44F80
        public void Clone(){} // RVA: 0x7FFE868BC310
        public void Equals(){} // RVA: 0x7FFE86A45420
        public void GetHashCode(){} // RVA: 0x7FFE86A45650
        public void GetMethodImpl(){} // RVA: 0x7FFE86A456C0
        public void GetObjectData(){} // RVA: 0x7FFE86A457E0
        public void GetInvocationList(){} // RVA: 0x7FFE86A45800
        public void Combine(){} // RVA: 0x7FFE86A45A20 | overloaded x2
        public void CombineImpl(){} // RVA: 0x7FFE86A45BF0
        public void Remove(){} // RVA: 0x7FFE86A45C50
        public void RemoveImpl(){} // RVA: 0x7FFE86A45DD0
        public void op_Equality(){} // RVA: 0x7FFE86A45E00
        public void op_Inequality(){} // RVA: 0x7FFE86A45E30
        public void AllocDelegateLike_internal(){} // RVA: 0x7FFE86A45E80
    }

    public class DelegateData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DelegateSerializationHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A45F00
        public void GetDelegateData(){} // RVA: 0x7FFE86A46280
        public void GetObjectData(){} // RVA: 0x7FFE86A46540
        public void GetRealObject(){} // RVA: 0x7FFE81116380
    }

    public class DivideByZeroException : ArithmeticException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class DllNotFoundException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869BCD80 | overloaded x3
    }

    public class DomainNameHelper : Object
    {
        // ── Methods ──
        public void ParseCanonicalName(){} // RVA: 0x7FFE87739DD0
        public void IsValid(){} // RVA: 0x7FFE8773A050
        public void IsValidByIri(){} // RVA: 0x7FFE8773A1D0
        public void IdnEquivalent(){} // RVA: 0x7FFE8773A740 | overloaded x3
        public void IsIdnAce(){} // RVA: 0x7FFE8773A960 | overloaded x2
        public void UnicodeEquivalent(){} // RVA: 0x7FFE8773AAF0 | overloaded x2
        public void IsASCIILetterOrDigit(){} // RVA: 0x7FFE8773B180
        public void IsValidDomainLabelCharacter(){} // RVA: 0x7FFE8773B1B0
    }

    public class Double : ValueType
    {
        // ── Methods ──
        public void IsFinite(){} // RVA: 0x7FFE869BCDA0
        public void IsInfinity(){} // RVA: 0x7FFE869BCDD0
        public void IsNaN(){} // RVA: 0x7FFE869BCE00
        public void IsNegative(){} // RVA: 0x7FFE869BCE30
        public void IsNegativeInfinity(){} // RVA: 0x7FFE869BCE40
        public void IsPositiveInfinity(){} // RVA: 0x7FFE869BCE60
        public void CompareTo(){} // RVA: 0x7FFE869BCFB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE869BD0D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE84109F50
        public void ToString(){} // RVA: 0x7FFE869BD280 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869BD310
        public void Parse(){} // RVA: 0x7FFE869BD640 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFE869BD880 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFE824BF490
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869BDB70
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869BDBE0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869BDC70
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869BDCD0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE869BDD30
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869BDD90
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE869BDDF0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869BDE50
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE869BDEB0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869BDF10
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869BDF70
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE82A39E60
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869BDFD0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE869BE050
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869BE0E0
    }

}