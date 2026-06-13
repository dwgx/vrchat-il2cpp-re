// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 20
// Methods: 620

namespace ThirdParty.DotNet.System
{
    public class DBNull
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E6DDF0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x5E6DE40
        public void ToString(){} // RVA: 0x5E6DE90 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x3E2CB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x5E6DED0
        public void System.IConvertible.ToChar(){} // RVA: 0x5E6DF20
        public void System.IConvertible.ToSByte(){} // RVA: 0x5E6DF70
        public void System.IConvertible.ToByte(){} // RVA: 0x5E6DFC0
        public void System.IConvertible.ToInt16(){} // RVA: 0x5E6E010
        public void System.IConvertible.ToUInt16(){} // RVA: 0x5E6E060
        public void System.IConvertible.ToInt32(){} // RVA: 0x5E6E0B0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x5E6E100
        public void System.IConvertible.ToInt64(){} // RVA: 0x5E6E150
        public void System.IConvertible.ToUInt64(){} // RVA: 0x5E6E1A0
        public void System.IConvertible.ToSingle(){} // RVA: 0x5E6E1F0
        public void System.IConvertible.ToDouble(){} // RVA: 0x5E6E240
        public void System.IConvertible.ToDecimal(){} // RVA: 0x5E6E290
        public void System.IConvertible.ToDateTime(){} // RVA: 0x5E6E2E0
        public void System.IConvertible.ToType(){} // RVA: 0x5E6E330
        public void .cctor(){} // RVA: 0x5E6E3A0
    }

    public class DTSubString
    {
        public System.ReadOnlySpan`1<char> s; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x5E92750
    }

    public class DateTime : System
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
        public void .ctor(){} // RVA: 0x5E6F440 | overloaded x14
        public void get_InternalTicks(){} // RVA: 0x5E6F8A0
        public void get_InternalKind(){} // RVA: 0x5E6F8C0
        public void Add(){} // RVA: 0x5E6F940 | overloaded x2
        public void AddDays(){} // RVA: 0x5E6FA60
        public void AddHours(){} // RVA: 0x5E6FAD0
        public void AddMilliseconds(){} // RVA: 0x5E6FB40
        public void AddMinutes(){} // RVA: 0x5E6FBB0
        public void AddMonths(){} // RVA: 0x5E6FC20
        public void AddSeconds(){} // RVA: 0x5E6FE70
        public void AddTicks(){} // RVA: 0x5E6FEE0
        public void AddYears(){} // RVA: 0x5E6FFF0
        public void Compare(){} // RVA: 0x5E700C0
        public void CompareTo(){} // RVA: 0x5E70230 | overloaded x2
        public void DateToTicks(){} // RVA: 0x5E702A0
        public void TimeToTicks(){} // RVA: 0x5E70480
        public void DaysInMonth(){} // RVA: 0x5E70550
        public void DoubleDateToTicks(){} // RVA: 0x5E706A0
        public void Equals(){} // RVA: 0x5E70900 | overloaded x3
        public void FromBinary(){} // RVA: 0x5E70970
        public void FromBinaryRaw(){} // RVA: 0x5E70BE0
        public void FromFileTime(){} // RVA: 0x5E70C80
        public void FromFileTimeUtc(){} // RVA: 0x5E70D20
        public void FromOADate(){} // RVA: 0x5E70DE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5E70F90
        public void IsDaylightSavingTime(){} // RVA: 0x5E71090
        public void SpecifyKind(){} // RVA: 0x5E711A0
        public void ToBinary(){} // RVA: 0x5E71220
        public void get_Date(){} // RVA: 0x5E71370
        public void GetDatePart(){} // RVA: 0x5E715E0 | overloaded x2
        public void get_Day(){} // RVA: 0x5E717C0
        public void get_DayOfWeek(){} // RVA: 0x5E71820
        public void get_DayOfYear(){} // RVA: 0x5E718B0
        public void GetHashCode(){} // RVA: 0x5E71910
        public void get_Hour(){} // RVA: 0x5E71970
        public void IsAmbiguousDaylightSavingTime(){} // RVA: 0x5E71A00
        public void get_Kind(){} // RVA: 0x5E71A60
        public void get_Millisecond(){} // RVA: 0x5E71AE0
        public void get_Minute(){} // RVA: 0x5E71B80
        public void get_Month(){} // RVA: 0x5E71C20
        public void get_Now(){} // RVA: 0x5E71C80
        public void get_Second(){} // RVA: 0x5E71E40
        public void get_Ticks(){} // RVA: 0x5E71EE0
        public void get_TimeOfDay(){} // RVA: 0x5E71F40
        public void get_Today(){} // RVA: 0x5E71FB0
        public void get_Year(){} // RVA: 0x5E72070
        public void IsLeapYear(){} // RVA: 0x5E720D0
        public void Parse(){} // RVA: 0x5E723A0 | overloaded x3
        public void ParseExact(){} // RVA: 0x5E72800 | overloaded x3
        public void Subtract(){} // RVA: 0x5E72AC0 | overloaded x2
        public void TicksToOADate(){} // RVA: 0x5E72BD0
        public void ToOADate(){} // RVA: 0x5E72CF0
        public void ToFileTime(){} // RVA: 0x5E72E50
        public void ToFileTimeUtc(){} // RVA: 0x5E72EB0
        public void ToLocalTime(){} // RVA: 0x5E73000 | overloaded x2
        public void ToLongDateString(){} // RVA: 0x5E73280
        public void ToLongTimeString(){} // RVA: 0x5E732F0
        public void ToShortDateString(){} // RVA: 0x5E73360
        public void ToShortTimeString(){} // RVA: 0x5E733D0
        public void ToString(){} // RVA: 0x5E73580 | overloaded x4
        public void TryFormat(){} // RVA: 0x5E73600
        public void ToUniversalTime(){} // RVA: 0x5E73700
        public void TryParse(){} // RVA: 0x5E73970 | overloaded x2
        public void TryParseExact(){} // RVA: 0x5E73DC0 | overloaded x2
        public void op_Addition(){} // RVA: 0x5E74020
        public void op_Subtraction(){} // RVA: 0x5E74240 | overloaded x2
        public void op_Equality(){} // RVA: 0x5E742B0
        public void op_Inequality(){} // RVA: 0x5E74320
        public void op_LessThan(){} // RVA: 0x5E74390
        public void op_LessThanOrEqual(){} // RVA: 0x5E74400
        public void op_GreaterThan(){} // RVA: 0x5E74470
        public void op_GreaterThanOrEqual(){} // RVA: 0x5E744E0
        public void GetDateTimeFormats(){} // RVA: 0x5E747A0 | overloaded x4
        public void GetTypeCode(){} // RVA: 0x210E2B0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x5E74850
        public void System.IConvertible.ToChar(){} // RVA: 0x5E748E0
        public void System.IConvertible.ToSByte(){} // RVA: 0x5E74970
        public void System.IConvertible.ToByte(){} // RVA: 0x5E74A00
        public void System.IConvertible.ToInt16(){} // RVA: 0x5E74A90
        public void System.IConvertible.ToUInt16(){} // RVA: 0x5E74B20
        public void System.IConvertible.ToInt32(){} // RVA: 0x5E74BB0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x5E74C40
        public void System.IConvertible.ToInt64(){} // RVA: 0x5E74CD0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x5E74D60
        public void System.IConvertible.ToSingle(){} // RVA: 0x5E74DF0
        public void System.IConvertible.ToDouble(){} // RVA: 0x5E74E80
        public void System.IConvertible.ToDecimal(){} // RVA: 0x5E74F10
        public void System.IConvertible.ToDateTime(){} // RVA: 0x1AD4690
        public void System.IConvertible.ToType(){} // RVA: 0x5E74FA0
        public void TryCreate(){} // RVA: 0x5E75040
        public void get_UtcNow(){} // RVA: 0x5E75250
        public void GetSystemTimeAsFileTime(){} // RVA: 0x5E752C0
        public void ToBinaryRaw(){} // RVA: 0x1AD4690
        public void .cctor(){} // RVA: 0x5E752E0
    }

    public class DateTimeFormat
    {
        // ── Methods ──
        public void FormatDigits(){} // RVA: 0x5E7D950 | overloaded x2
        public void HebrewFormatDigits(){} // RVA: 0x5E7DA50
        public void ParseRepeatPattern(){} // RVA: 0x5E7DAD0
        public void FormatDayOfWeek(){} // RVA: 0x5E7DB50
        public void FormatMonth(){} // RVA: 0x5E7DB90
        public void FormatHebrewMonthName(){} // RVA: 0x5E7DBD0
        public void ParseQuoteString(){} // RVA: 0x5E7DCA0
        public void ParseNextChar(){} // RVA: 0x5E7DE90
        public void IsUseGenitiveForm(){} // RVA: 0x5E7DF00
        public void FormatCustomized(){} // RVA: 0x5E7E040
        public void FormatCustomizedTimeZone(){} // RVA: 0x5E7F510
        public void FormatCustomizedRoundripTimeZone(){} // RVA: 0x5E7FA20
        public void Append2DigitNumber(){} // RVA: 0x5E7FD50
        public void GetRealFormat(){} // RVA: 0x5E7FE60
        public void ExpandPredefinedFormat(){} // RVA: 0x5E80350
        public void Format(){} // RVA: 0x5E80840 | overloaded x2
        public void TryFormat(){} // RVA: 0x5E80C10 | overloaded x2
        public void FormatStringBuilder(){} // RVA: 0x5E80E50
        public void TryFormatO(){} // RVA: 0x5E811E0
        public void TryFormatR(){} // RVA: 0x5E81A00
        public void WriteTwoDecimalDigits(){} // RVA: 0x5E81F00
        public void WriteFourDecimalDigits(){} // RVA: 0x5E81F60
        public void WriteDigits(){} // RVA: 0x5E82030
        public void GetAllDateTimes(){} // RVA: 0x5E82570 | overloaded x2
        public void InvalidFormatForLocal(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5E827C0
    }

    public class DateTimeOffset : System
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

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E789B0 | overloaded x7
        public void get_Now(){} // RVA: 0x5E75CD0
        public void get_UtcNow(){} // RVA: 0x5E75D40
        public void get_DateTime(){} // RVA: 0x5E75DB0
        public void get_UtcDateTime(){} // RVA: 0x5E75E00
        public void get_LocalDateTime(){} // RVA: 0x5E75E60
        public void ToOffset(){} // RVA: 0x5E75F60
        public void get_ClockDateTime(){} // RVA: 0x5E76030
        public void get_Date(){} // RVA: 0x5E76170
        public void get_Day(){} // RVA: 0x5E76260
        public void get_DayOfWeek(){} // RVA: 0x5E76330
        public void get_DayOfYear(){} // RVA: 0x5E76430
        public void get_Hour(){} // RVA: 0x5E76500
        public void get_Millisecond(){} // RVA: 0x5E76600
        public void get_Minute(){} // RVA: 0x5E76700
        public void get_Month(){} // RVA: 0x5E76800
        public void get_Offset(){} // RVA: 0x5E768D0
        public void get_Second(){} // RVA: 0x5E76930
        public void get_Ticks(){} // RVA: 0x5E76A30
        public void get_UtcTicks(){} // RVA: 0x5E76AF0
        public void get_TimeOfDay(){} // RVA: 0x5E76BF0
        public void get_Year(){} // RVA: 0x5E76CC0
        public void Add(){} // RVA: 0x5E76D80
        public void AddDays(){} // RVA: 0x5E76EC0
        public void AddHours(){} // RVA: 0x5E77010
        public void AddMilliseconds(){} // RVA: 0x5E77160
        public void AddMinutes(){} // RVA: 0x5E772B0
        public void AddMonths(){} // RVA: 0x5E77400
        public void AddSeconds(){} // RVA: 0x5E77510
        public void AddTicks(){} // RVA: 0x5E77660
        public void AddYears(){} // RVA: 0x5E77770
        public void Compare(){} // RVA: 0x5E77880
        public void System.IComparable.CompareTo(){} // RVA: 0x5E779A0
        public void CompareTo(){} // RVA: 0x5E77B50
        public void Equals(){} // RVA: 0x5E782B0 | overloaded x3
        public void EqualsExact(){} // RVA: 0x5E77FE0
        public void FromFileTime(){} // RVA: 0x5E78410
        public void FromUnixTimeSeconds(){} // RVA: 0x5E78490
        public void FromUnixTimeMilliseconds(){} // RVA: 0x5E78600
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5E78770
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5E788E0
        public void GetHashCode(){} // RVA: 0x5E78B80
        public void Parse(){} // RVA: 0x5E78EC0 | overloaded x3
        public void ParseExact(){} // RVA: 0x5E793D0 | overloaded x3
        public void Subtract(){} // RVA: 0x5E79830 | overloaded x2
        public void ToFileTime(){} // RVA: 0x5E79940
        public void ToUnixTimeSeconds(){} // RVA: 0x5E79A50
        public void ToUnixTimeMilliseconds(){} // RVA: 0x5E79B70
        public void ToLocalTime(){} // RVA: 0x5E79D00 | overloaded x2
        public void ToString(){} // RVA: 0x5E7A0F0 | overloaded x4
        public void TryFormat(){} // RVA: 0x5E7A200
        public void ToUniversalTime(){} // RVA: 0x5E7A340
        public void TryParse(){} // RVA: 0x5E7A5A0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x5E7AB90 | overloaded x2
        public void ValidateOffset(){} // RVA: 0x5E7AEB0
        public void ValidateDate(){} // RVA: 0x5E7B030
        public void ValidateStyles(){} // RVA: 0x5E7B180
        public void op_Implicit(){} // RVA: 0x5E7B2A0
        public void op_Addition(){} // RVA: 0x5E7B2C0
        public void op_Subtraction(){} // RVA: 0x5E7B4E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x5E7B600
        public void op_Inequality(){} // RVA: 0x5E7B760
        public void op_LessThan(){} // RVA: 0x5E7B8C0
        public void op_LessThanOrEqual(){} // RVA: 0x5E7B9E0
        public void op_GreaterThan(){} // RVA: 0x5E7BB00
        public void op_GreaterThanOrEqual(){} // RVA: 0x5E7BC20
        public void .cctor(){} // RVA: 0x5E7BD40
    }

    public class DateTimeParse
    {
        // ── Methods ──
        public void ParseExact(){} // RVA: 0x5E82EC0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x5E83580 | overloaded x3
        public void ParseExactMultiple(){} // RVA: 0x5E837F0 | overloaded x2
        public void TryParseExactMultiple(){} // RVA: 0x5E83D00 | overloaded x3
        public void MatchWord(){} // RVA: 0x5E84030
        public void GetTimeZoneName(){} // RVA: 0x5E84230
        public void IsDigit(){} // RVA: 0x5E842E0
        public void ParseFraction(){} // RVA: 0x5E842F0
        public void ParseTimeZone(){} // RVA: 0x5E843F0
        public void HandleTimeZone(){} // RVA: 0x5E847B0
        public void Lex(){} // RVA: 0x5E849B0
        public void GetJapaneseCalendarDefaultInstance(){} // RVA: 0x5E85B90
        public void GetTaiwanCalendarDefaultInstance(){} // RVA: 0x5E85C90
        public void VerifyValidPunctuation(){} // RVA: 0x5E85D90
        public void GetYearMonthDayOrder(){} // RVA: 0x5E85FF0
        public void GetYearMonthOrder(){} // RVA: 0x5E86210
        public void GetMonthDayOrder(){} // RVA: 0x5E863B0
        public void TryAdjustYear(){} // RVA: 0x5E86570
        public void SetDateYMD(){} // RVA: 0x5E865D0
        public void SetDateMDY(){} // RVA: 0x5E86650
        public void SetDateDMY(){} // RVA: 0x5E866E0
        public void SetDateYDM(){} // RVA: 0x5E86770
        public void GetDefaultYear(){} // RVA: 0x5E86800
        public void GetDayOfNN(){} // RVA: 0x5E868A0
        public void GetDayOfNNN(){} // RVA: 0x5E86A60
        public void GetDayOfMN(){} // RVA: 0x5E86EB0
        public void GetHebrewDayOfNM(){} // RVA: 0x5E870F0
        public void GetDayOfNM(){} // RVA: 0x5E87280
        public void GetDayOfMNN(){} // RVA: 0x5E874C0
        public void GetDayOfYNN(){} // RVA: 0x5E87870
        public void GetDayOfNNY(){} // RVA: 0x5E879D0
        public void GetDayOfYMN(){} // RVA: 0x5E87B80
        public void GetDayOfYN(){} // RVA: 0x5E87C70
        public void GetDayOfYM(){} // RVA: 0x5E87D50
        public void AdjustTimeMark(){} // RVA: 0x5E87E30
        public void AdjustHour(){} // RVA: 0x5E87EF0
        public void GetTimeOfN(){} // RVA: 0x5E87F30
        public void GetTimeOfNN(){} // RVA: 0x5E87FA0
        public void GetTimeOfNNN(){} // RVA: 0x5E88020
        public void GetDateOfDSN(){} // RVA: 0x5E880A0
        public void GetDateOfNDS(){} // RVA: 0x5E88110
        public void GetDateOfNNDS(){} // RVA: 0x5E881F0
        public void ProcessDateTimeSuffix(){} // RVA: 0x5E88440
        public void ProcessHebrewTerminalState(){} // RVA: 0x5E88500
        public void ProcessTerminalState(){} // RVA: 0x5E88A80
        public void Parse(){} // RVA: 0x5E89160 | overloaded x2
        public void TryParse(){} // RVA: 0x5E895F0 | overloaded x3
        public void DetermineTimeZoneAdjustments(){} // RVA: 0x5E8A060
        public void DateTimeOffsetTimeZonePostProcessing(){} // RVA: 0x5E8A2E0
        public void AdjustTimeZoneToUniversal(){} // RVA: 0x5E8A5A0
        public void AdjustTimeZoneToLocal(){} // RVA: 0x5E8A6E0
        public void ParseISO8601(){} // RVA: 0x5E8A9E0
        public void MatchHebrewDigits(){} // RVA: 0x5E8B0D0
        public void ParseDigits(){} // RVA: 0x5E8B280 | overloaded x2
        public void ParseFractionExact(){} // RVA: 0x5E8B380
        public void ParseSign(){} // RVA: 0x5E8B510
        public void ParseTimeZoneOffset(){} // RVA: 0x5E8B5D0
        public void MatchAbbreviatedMonthName(){} // RVA: 0x5E8B8D0
        public void MatchMonthName(){} // RVA: 0x5E8BB80
        public void MatchAbbreviatedDayName(){} // RVA: 0x5E8BFA0
        public void MatchDayName(){} // RVA: 0x5E8C110
        public void MatchEraName(){} // RVA: 0x5E8C280
        public void MatchTimeMark(){} // RVA: 0x5E8C400
        public void MatchAbbreviatedTimeMark(){} // RVA: 0x5E8C580
        public void CheckNewValue(){} // RVA: 0x5E8C6E0
        public void GetDateTimeNow(){} // RVA: 0x5E8C790
        public void CheckDefaultDateTime(){} // RVA: 0x5E8C8F0
        public void ExpandPredefinedFormat(){} // RVA: 0x5E8CB30
        public void ParseJapaneseEraStart(){} // RVA: 0x5E8CFE0
        public void ParseByFormat(){} // RVA: 0x5E8D0E0
        public void TryParseQuoteString(){} // RVA: 0x5E8EB70
        public void DoStrictParse(){} // RVA: 0x5E8EC90
        public void GetDateTimeParseException(){} // RVA: 0x5E8F7D0
        public void .cctor(){} // RVA: 0x5E8F990
    }

    public class DateTimeRawInfo
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x5E92780
        public void AddNumber(){} // RVA: 0x5E927B0
        public void GetNumber(){} // RVA: 0x45AB3A0
    }

    public class DateTimeResult
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x5E927D0
        public void SetDate(){} // RVA: 0x49D93F0
        public void SetBadFormatSpecifierFailure(){} // RVA: 0x5E92870 | overloaded x2
        public void SetBadDateTimeFailure(){} // RVA: 0x5E928D0
        public void SetFailure(){} // RVA: 0x5E92940 | overloaded x3
    }

    public class DateTimeToken
    {
    }

    public class Decimal : System
    {
        public int SignMask;
        public int ScaleMask;
        public int ScaleShift;
        public System.Decimal Zero;
        public System.Decimal One; // 0x10
        public System.Decimal MinusOne; // 0x20

        // ── Methods ──
        public void get_High(){} // RVA: 0x19689E0
        public void get_Low(){} // RVA: 0x1EA9890
        public void get_Mid(){} // RVA: 0x1EA98B0
        public void get_IsNegative(){} // RVA: 0x5E97530
        public void get_Scale(){} // RVA: 0x1E40390
        public void get_Low64(){} // RVA: 0x5F19480
        public void AsMutable(){} // RVA: 0x1A3F520
        public void DecDivMod1E9(){} // RVA: 0x5F194C0
        public void .ctor(){} // RVA: 0x5F19B80 | overloaded x9
        public void FromOACurrency(){} // RVA: 0x5F19740
        public void ToOACurrency(){} // RVA: 0x5F19840
        public void IsValid(){} // RVA: 0x5F198C0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5F19AD0
        public void Abs(){} // RVA: 0x5F19B90
        public void Add(){} // RVA: 0x5F19BB0
        public void Ceiling(){} // RVA: 0x5F19C50
        public void Compare(){} // RVA: 0x5F19D00
        public void CompareTo(){} // RVA: 0x5F19E70 | overloaded x2
        public void Divide(){} // RVA: 0x5F19ED0
        public void Equals(){} // RVA: 0x5F1A230 | overloaded x3
        public void GetHashCode(){} // RVA: 0x5F1A0A0
        public void Floor(){} // RVA: 0x5F1A2A0
        public void ToString(){} // RVA: 0x5F1A5C0 | overloaded x4
        public void TryFormat(){} // RVA: 0x5F1A6B0
        public void Parse(){} // RVA: 0x5F1AA50 | overloaded x4
        public void TryParse(){} // RVA: 0x5F1AC40 | overloaded x2
        public void GetBits(){} // RVA: 0x5F1AD40
        public void Max(){} // RVA: 0x5F1ADD0
        public void Min(){} // RVA: 0x5F1AE40
        public void Remainder(){} // RVA: 0x5F1AEB0
        public void Multiply(){} // RVA: 0x5F1AF50
        public void Negate(){} // RVA: 0x5F1AFF0
        public void Round(){} // RVA: 0x5F1B2B0 | overloaded x5
        public void Sign(){} // RVA: 0x5F1B480
        public void Subtract(){} // RVA: 0x5F1B4A0
        public void ToByte(){} // RVA: 0x5F1B540
        public void ToSByte(){} // RVA: 0x5F1B660
        public void ToInt16(){} // RVA: 0x5F1B780
        public void ToDouble(){} // RVA: 0x5F1B8A0
        public void ToInt32(){} // RVA: 0x5F1B8F0
        public void ToInt64(){} // RVA: 0x5F1B9C0
        public void ToUInt16(){} // RVA: 0x5F1BAB0
        public void ToUInt32(){} // RVA: 0x5F1BBD0
        public void ToUInt64(){} // RVA: 0x5F1BC90
        public void ToSingle(){} // RVA: 0x5F1BD70
        public void Truncate(){} // RVA: 0x5F1BE70 | overloaded x2
        public void op_Implicit(){} // RVA: 0x5F1C030 | overloaded x9
        public void op_Explicit(){} // RVA: 0x5F1C530 | overloaded x13
        public void op_UnaryNegation(){} // RVA: 0x5F1AFF0
        public void op_Increment(){} // RVA: 0x5F1C5C0
        public void op_Decrement(){} // RVA: 0x5F1C6B0
        public void op_Addition(){} // RVA: 0x5F1C7A0
        public void op_Subtraction(){} // RVA: 0x5F1C840
        public void op_Multiply(){} // RVA: 0x5F1C8E0
        public void op_Division(){} // RVA: 0x5F1C980
        public void op_Modulus(){} // RVA: 0x5F1CA20
        public void op_Equality(){} // RVA: 0x5F1CAC0
        public void op_Inequality(){} // RVA: 0x5F1CB30
        public void op_LessThan(){} // RVA: 0x5F1CBA0
        public void op_LessThanOrEqual(){} // RVA: 0x5F1CC10
        public void op_GreaterThan(){} // RVA: 0x5F1CC80
        public void op_GreaterThanOrEqual(){} // RVA: 0x5F1CCF0
        public void GetTypeCode(){} // RVA: 0x13ADE30
        public void System.IConvertible.ToBoolean(){} // RVA: 0x5F1CD60
        public void System.IConvertible.ToChar(){} // RVA: 0x5F1CDD0
        public void System.IConvertible.ToSByte(){} // RVA: 0x5F1CE60
        public void System.IConvertible.ToByte(){} // RVA: 0x5F1CED0
        public void System.IConvertible.ToInt16(){} // RVA: 0x5F1CF40
        public void System.IConvertible.ToUInt16(){} // RVA: 0x5F1CFB0
        public void System.IConvertible.ToInt32(){} // RVA: 0x5F1D020
        public void System.IConvertible.ToUInt32(){} // RVA: 0x5F1D090
        public void System.IConvertible.ToInt64(){} // RVA: 0x5F1D100
        public void System.IConvertible.ToUInt64(){} // RVA: 0x5F1D170
        public void System.IConvertible.ToSingle(){} // RVA: 0x5F1D1E0
        public void System.IConvertible.ToDouble(){} // RVA: 0x5F1D280
        public void System.IConvertible.ToDecimal(){} // RVA: 0x75E7E0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x5F1D2F0
        public void System.IConvertible.ToType(){} // RVA: 0x5F1D380
        public void .cctor(){} // RVA: 0x5F1D420
    }

    public class DecimalDecCalc
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x5EC5E60
        public void DecDivMod1E9(){} // RVA: 0x5EC5EC0
        public void DecAddInt32(){} // RVA: 0x5EC5FA0
        public void D32AddCarry(){} // RVA: 0x5EC5FD0
        public void DecMul10(){} // RVA: 0x5EC5FF0
        public void DecShiftLeft(){} // RVA: 0x5EC60E0
        public void DecAdd(){} // RVA: 0x5EC6110
    }

    public class DecimalDecCalc
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x5EC5E60
        public void DecDivMod1E9(){} // RVA: 0x5EC5EC0
        public void DecAddInt32(){} // RVA: 0x5EC5FA0
        public void D32AddCarry(){} // RVA: 0x5EC5FD0
        public void DecMul10(){} // RVA: 0x5EC5FF0
        public void DecShiftLeft(){} // RVA: 0x5EC60E0
        public void DecAdd(){} // RVA: 0x5EC6110
    }

    public class DefaultBinder
    {
        // ── Methods ──
        public void BindToMethod(){} // RVA: 0x5ED7030
        public void BindToField(){} // RVA: 0x5ED9600
        public void SelectProperty(){} // RVA: 0x5ED9CF0
        public void ChangeType(){} // RVA: 0x5EDAAD0
        public void ReorderArgumentArray(){} // RVA: 0x5EDAB30
        public void ExactBinding(){} // RVA: 0x5EDAFA0
        public void ExactPropertyBinding(){} // RVA: 0x5EDB210
        public void FindMostSpecific(){} // RVA: 0x5EDB4E0
        public void FindMostSpecificType(){} // RVA: 0x5EDB8B0
        public void FindMostSpecificMethod(){} // RVA: 0x5EDBCF0
        public void FindMostSpecificField(){} // RVA: 0x5EDC2E0
        public void FindMostSpecificProperty(){} // RVA: 0x5EDC430
        public void CompareMethodSigAndName(){} // RVA: 0x5EDC580
        public void GetHierarchyDepth(){} // RVA: 0x5EDC6E0
        public void FindMostDerivedNewSlotMeth(){} // RVA: 0x5EDC760
        public void ReorderParams(){} // RVA: 0x5EDC8B0
        public void CreateParamOrder(){} // RVA: 0x5EDCAE0
        public void CanConvertPrimitive(){} // RVA: 0x5EDCD00
        public void CanConvertPrimitiveObjectToType(){} // RVA: 0x5EDCFF0
        public void CompareMethodSig(){} // RVA: 0x5EDD110
        public void SelectMethod(){} // RVA: 0x5EDD270
        public void CanChangePrimitive(){} // RVA: 0x5EDDA80
        public void CanPrimitiveWiden(){} // RVA: 0x5EDDC40
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5EDDDC0
    }

    public class Delegate
    {
        public UIntPtr method_ptr; // 0x10
        public UIntPtr invoke_impl; // 0x18

        // ── Methods ──
        public void get_Method(){} // RVA: 0x950560
        public void GetVirtualMethod_internal(){} // RVA: 0x5F02130
        public void get_Target(){} // RVA: 0x30B0C0
        public void CreateDelegate_internal(){} // RVA: 0x5F02160
        public void arg_type_match(){} // RVA: 0x5F02220
        public void arg_type_match_this(){} // RVA: 0x5F02440
        public void return_type_match(){} // RVA: 0x5F025B0
        public void CreateDelegate(){} // RVA: 0x5F03E20 | overloaded x10
        public void GetCandidateMethod(){} // RVA: 0x5F035E0
        public void DynamicInvoke(){} // RVA: 0x400EA10
        public void InitializeDelegateData(){} // RVA: 0x5F03F50
        public void DynamicInvokeImpl(){} // RVA: 0x5F04140
        public void Clone(){} // RVA: 0x5D7B480
        public void Equals(){} // RVA: 0x5F045E0
        public void GetHashCode(){} // RVA: 0x5F04810
        public void GetMethodImpl(){} // RVA: 0x5F04880
        public void GetObjectData(){} // RVA: 0x5F049A0
        public void GetInvocationList(){} // RVA: 0x5F049C0
        public void Combine(){} // RVA: 0x5F04BE0 | overloaded x2
        public void CombineImpl(){} // RVA: 0x5F04DB0
        public void Remove(){} // RVA: 0x5F04E10
        public void RemoveImpl(){} // RVA: 0x5F04F90
        public void op_Equality(){} // RVA: 0x5F04FC0
        public void op_Inequality(){} // RVA: 0x5F04FF0
        public void AllocDelegateLike_internal(){} // RVA: 0x5F05040
    }

    public class DelegateData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DelegateSerializationHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F050C0
        public void GetDelegateData(){} // RVA: 0x5F05440
        public void GetObjectData(){} // RVA: 0x5F05700
        public void GetRealObject(){} // RVA: 0x2F8380
    }

    public class DivideByZeroException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class DllNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E7BF40 | overloaded x3
    }

    public class DomainNameHelper
    {
        // ── Methods ──
        public void ParseCanonicalName(){} // RVA: 0x6BF8F20
        public void IsValid(){} // RVA: 0x6BF91A0
        public void IsValidByIri(){} // RVA: 0x6BF9320
        public void IdnEquivalent(){} // RVA: 0x6BF9890 | overloaded x3
        public void IsIdnAce(){} // RVA: 0x6BF9AB0 | overloaded x2
        public void UnicodeEquivalent(){} // RVA: 0x6BF9C40 | overloaded x2
        public void IsASCIILetterOrDigit(){} // RVA: 0x6BFA2D0
        public void IsValidDomainLabelCharacter(){} // RVA: 0x6BFA300
    }

    public class Double
    {
        // ── Methods ──
        public void IsFinite(){} // RVA: 0x5E7BF60
        public void IsInfinity(){} // RVA: 0x5E7BF90
        public void IsNaN(){} // RVA: 0x5E7BFC0
        public void IsNegative(){} // RVA: 0x5E7BFF0
        public void IsNegativeInfinity(){} // RVA: 0x5E7C000
        public void IsPositiveInfinity(){} // RVA: 0x5E7C020
        public void CompareTo(){} // RVA: 0x5E7C170 | overloaded x2
        public void Equals(){} // RVA: 0x5E7C290 | overloaded x2
        public void GetHashCode(){} // RVA: 0x34778E0
        public void ToString(){} // RVA: 0x5E7C440 | overloaded x4
        public void TryFormat(){} // RVA: 0x5E7C4D0
        public void Parse(){} // RVA: 0x5E7C800 | overloaded x4
        public void TryParse(){} // RVA: 0x5E7CA40 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x174E930
        public void System.IConvertible.ToBoolean(){} // RVA: 0x5E7CD30
        public void System.IConvertible.ToChar(){} // RVA: 0x5E7CDA0
        public void System.IConvertible.ToSByte(){} // RVA: 0x5E7CE30
        public void System.IConvertible.ToByte(){} // RVA: 0x5E7CE90
        public void System.IConvertible.ToInt16(){} // RVA: 0x5E7CEF0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x5E7CF50
        public void System.IConvertible.ToInt32(){} // RVA: 0x5E7CFB0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x5E7D010
        public void System.IConvertible.ToInt64(){} // RVA: 0x5E7D070
        public void System.IConvertible.ToUInt64(){} // RVA: 0x5E7D0D0
        public void System.IConvertible.ToSingle(){} // RVA: 0x5E7D130
        public void System.IConvertible.ToDouble(){} // RVA: 0x1CA83C0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x5E7D190
        public void System.IConvertible.ToDateTime(){} // RVA: 0x5E7D210
        public void System.IConvertible.ToType(){} // RVA: 0x5E7D2A0
    }

}