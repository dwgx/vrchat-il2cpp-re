// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 19
// Methods: 613

namespace ThirdParty.DotNet.System
{
    public class DBNull : Object
    {
        public System.DBNull Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8605460 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC86054B0
        public void ToString(){} // RVA: 0x7FFAC8605500 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFAC3026CB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC8605540
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC8605590
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC86055E0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC8605630
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC8605680
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC86056D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC8605720
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC8605770
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC86057C0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC8605810
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC8605860
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC86058B0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC8605900
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC8605950
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC86059A0
        public void .cctor(){} // RVA: 0x7FFAC8605A10
    }

    public class DTSubString : ValueType
    {
        public System.ReadOnlySpan`1<char> Item; // 0x10
        public int index; // 0x20
        public int length; // 0x24
        public 0x6B0BF290 type; // 0x28
        public int value; // 0x2C

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC8629DC0
    }

    public class DateTime : ValueType
    {
        public long InternalTicks;
        public long InternalKind;
        public long Date;
        public long Day;
        public long DayOfWeek;
        public int DayOfYear;
        public int Hour;
        public int Kind;
        public int Millisecond;
        public int Minute;
        public int Month;
        public int Now;
        public int Second;
        public int Ticks;
        public int TimeOfDay;
        public int Today;
        public int Year;
        public long UtcNow;
        public long MaxTicks;
        public long MaxMillis;
        public long UnixEpochTicks;
        public long FileTimeOffset;
        public long DoubleDateOffset;
        public long OADateMinAsTicks;
        public double OADateMinAsDouble;
        public double OADateMaxAsDouble;
        public int DatePartYear;
        public int DatePartDayOfYear;
        public int DatePartMonth;
        public int DatePartDay;
        public int[] s_daysToMonth365;
        public int[] s_daysToMonth366; // 0x8
        public System.DateTime MinValue; // 0x10
        public System.DateTime MaxValue; // 0x18
        public System.DateTime UnixEpoch; // 0x20
        public ulong TicksMask;
        public ulong FlagsMask;
        public ulong LocalMask;
        public long TicksCeiling;
        public ulong KindUnspecified;
        public ulong KindUtc;
        public ulong KindLocal;
        public ulong KindLocalAmbiguousDst;
        public int KindShift;
        public string TicksField;
        public string DateDataField;
        public ulong _dateData; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8606AB0 | overloaded x14
        public void get_InternalTicks(){} // RVA: 0x7FFAC8606F10
        public void get_InternalKind(){} // RVA: 0x7FFAC8606F30
        public void Add(){} // RVA: 0x7FFAC8606FB0 | overloaded x2
        public void AddDays(){} // RVA: 0x7FFAC86070D0
        public void AddHours(){} // RVA: 0x7FFAC8607140
        public void AddMilliseconds(){} // RVA: 0x7FFAC86071B0
        public void AddMinutes(){} // RVA: 0x7FFAC8607220
        public void AddMonths(){} // RVA: 0x7FFAC8607290
        public void AddSeconds(){} // RVA: 0x7FFAC86074E0
        public void AddTicks(){} // RVA: 0x7FFAC8607550
        public void AddYears(){} // RVA: 0x7FFAC8607660
        public void Compare(){} // RVA: 0x7FFAC8607730
        public void CompareTo(){} // RVA: 0x7FFAC86078A0 | overloaded x2
        public void DateToTicks(){} // RVA: 0x7FFAC8607910
        public void TimeToTicks(){} // RVA: 0x7FFAC8607AF0
        public void DaysInMonth(){} // RVA: 0x7FFAC8607BC0
        public void DoubleDateToTicks(){} // RVA: 0x7FFAC8607D10
        public void Equals(){} // RVA: 0x7FFAC8607F70 | overloaded x3
        public void FromBinary(){} // RVA: 0x7FFAC8607FE0
        public void FromBinaryRaw(){} // RVA: 0x7FFAC8608250
        public void FromFileTime(){} // RVA: 0x7FFAC86082F0
        public void FromFileTimeUtc(){} // RVA: 0x7FFAC8608390
        public void FromOADate(){} // RVA: 0x7FFAC8608450
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8608600
        public void IsDaylightSavingTime(){} // RVA: 0x7FFAC8608700
        public void SpecifyKind(){} // RVA: 0x7FFAC8608810
        public void ToBinary(){} // RVA: 0x7FFAC8608890
        public void get_Date(){} // RVA: 0x7FFAC86089E0
        public void GetDatePart(){} // RVA: 0x7FFAC8608C50 | overloaded x2
        public void get_Day(){} // RVA: 0x7FFAC8608E30
        public void get_DayOfWeek(){} // RVA: 0x7FFAC8608E90
        public void get_DayOfYear(){} // RVA: 0x7FFAC8608F20
        public void GetHashCode(){} // RVA: 0x7FFAC8608F80
        public void get_Hour(){} // RVA: 0x7FFAC8608FE0
        public void IsAmbiguousDaylightSavingTime(){} // RVA: 0x7FFAC8609070
        public void get_Kind(){} // RVA: 0x7FFAC86090D0
        public void get_Millisecond(){} // RVA: 0x7FFAC8609150
        public void get_Minute(){} // RVA: 0x7FFAC86091F0
        public void get_Month(){} // RVA: 0x7FFAC8609290
        public void get_Now(){} // RVA: 0x7FFAC86092F0
        public void get_Second(){} // RVA: 0x7FFAC86094B0
        public void get_Ticks(){} // RVA: 0x7FFAC8609550
        public void get_TimeOfDay(){} // RVA: 0x7FFAC86095B0
        public void get_Today(){} // RVA: 0x7FFAC8609620
        public void get_Year(){} // RVA: 0x7FFAC86096E0
        public void IsLeapYear(){} // RVA: 0x7FFAC8609740
        public void Parse(){} // RVA: 0x7FFAC8609A10 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFAC8609E70 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFAC860A130 | overloaded x2
        public void TicksToOADate(){} // RVA: 0x7FFAC860A240
        public void ToOADate(){} // RVA: 0x7FFAC860A360
        public void ToFileTime(){} // RVA: 0x7FFAC860A4C0
        public void ToFileTimeUtc(){} // RVA: 0x7FFAC860A520
        public void ToLocalTime(){} // RVA: 0x7FFAC860A670 | overloaded x2
        public void ToLongDateString(){} // RVA: 0x7FFAC860A8F0
        public void ToLongTimeString(){} // RVA: 0x7FFAC860A960
        public void ToShortDateString(){} // RVA: 0x7FFAC860A9D0
        public void ToShortTimeString(){} // RVA: 0x7FFAC860AA40
        public void ToString(){} // RVA: 0x7FFAC860ABF0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC860AC70
        public void ToUniversalTime(){} // RVA: 0x7FFAC860AD70
        public void TryParse(){} // RVA: 0x7FFAC860AFE0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAC860B430 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC860B690
        public void op_Subtraction(){} // RVA: 0x7FFAC860B8B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC860B920
        public void op_Inequality(){} // RVA: 0x7FFAC860B990
        public void op_LessThan(){} // RVA: 0x7FFAC860BA00
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC860BA70
        public void op_GreaterThan(){} // RVA: 0x7FFAC860BAE0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC860BB50
        public void GetDateTimeFormats(){} // RVA: 0x7FFAC860BE10 | overloaded x4
        public void GetTypeCode(){} // RVA: 0x7FFAC530B540
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC860BEC0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC860BF50
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC860BFE0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC860C070
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC860C100
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC860C190
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC860C220
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC860C2B0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC860C340
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC860C3D0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC860C460
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC860C4F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC860C580
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC3AD9F60
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC860C610
        public void TryCreate(){} // RVA: 0x7FFAC860C6B0
        public void get_UtcNow(){} // RVA: 0x7FFAC860C8C0
        public void GetSystemTimeAsFileTime(){} // RVA: 0x7FFAC860C930
        public void ToBinaryRaw(){} // RVA: 0x7FFAC3AD9F60
        public void .cctor(){} // RVA: 0x7FFAC860C950
    }

    public class DateTimeFormat : Object
    {
        public System.TimeSpan NullOffset;
        public char[] allStandardFormats; // 0x8
        public System.Globalization.DateTimeFormatInfo InvariantFormatInfo; // 0x10
        public string[] InvariantAbbreviatedMonthNames; // 0x18
        public string[] InvariantAbbreviatedDayNames; // 0x20
        public string[] fixedNumberFormats; // 0x28

        // ── Methods ──
        public void FormatDigits(){} // RVA: 0x7FFAC8614FC0 | overloaded x2
        public void HebrewFormatDigits(){} // RVA: 0x7FFAC86150C0
        public void ParseRepeatPattern(){} // RVA: 0x7FFAC8615140
        public void FormatDayOfWeek(){} // RVA: 0x7FFAC86151C0
        public void FormatMonth(){} // RVA: 0x7FFAC8615200
        public void FormatHebrewMonthName(){} // RVA: 0x7FFAC8615240
        public void ParseQuoteString(){} // RVA: 0x7FFAC8615310
        public void ParseNextChar(){} // RVA: 0x7FFAC8615500
        public void IsUseGenitiveForm(){} // RVA: 0x7FFAC8615570
        public void FormatCustomized(){} // RVA: 0x7FFAC86156B0
        public void FormatCustomizedTimeZone(){} // RVA: 0x7FFAC8616B80
        public void FormatCustomizedRoundripTimeZone(){} // RVA: 0x7FFAC8617090
        public void Append2DigitNumber(){} // RVA: 0x7FFAC86173C0
        public void GetRealFormat(){} // RVA: 0x7FFAC86174D0
        public void ExpandPredefinedFormat(){} // RVA: 0x7FFAC86179C0
        public void Format(){} // RVA: 0x7FFAC8617EB0 | overloaded x2
        public void TryFormat(){} // RVA: 0x7FFAC8618280 | overloaded x2
        public void FormatStringBuilder(){} // RVA: 0x7FFAC86184C0
        public void TryFormatO(){} // RVA: 0x7FFAC8618850
        public void TryFormatR(){} // RVA: 0x7FFAC8619070
        public void WriteTwoDecimalDigits(){} // RVA: 0x7FFAC8619570
        public void WriteFourDecimalDigits(){} // RVA: 0x7FFAC86195D0
        public void WriteDigits(){} // RVA: 0x7FFAC86196A0
        public void GetAllDateTimes(){} // RVA: 0x7FFAC8619BE0 | overloaded x2
        public void InvalidFormatForLocal(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8619E30
    }

    public class DateTimeOffset : ValueType
    {
        public long Now;
        public long UtcNow;
        public long DateTime;
        public long UtcDateTime;
        public long LocalDateTime;
        public long ClockDateTime;
        public System.DateTimeOffset Date;
        public System.DateTimeOffset Day; // 0x10
        public System.DateTimeOffset DayOfWeek; // 0x20
        public System.DateTime DayOfYear; // 0x10
        public short Hour; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8610020 | overloaded x7
        public void get_Now(){} // RVA: 0x7FFAC860D340
        public void get_UtcNow(){} // RVA: 0x7FFAC860D3B0
        public void get_DateTime(){} // RVA: 0x7FFAC860D420
        public void get_UtcDateTime(){} // RVA: 0x7FFAC860D470
        public void get_LocalDateTime(){} // RVA: 0x7FFAC860D4D0
        public void ToOffset(){} // RVA: 0x7FFAC860D5D0
        public void get_ClockDateTime(){} // RVA: 0x7FFAC860D6A0
        public void get_Date(){} // RVA: 0x7FFAC860D7E0
        public void get_Day(){} // RVA: 0x7FFAC860D8D0
        public void get_DayOfWeek(){} // RVA: 0x7FFAC860D9A0
        public void get_DayOfYear(){} // RVA: 0x7FFAC860DAA0
        public void get_Hour(){} // RVA: 0x7FFAC860DB70
        public void get_Millisecond(){} // RVA: 0x7FFAC860DC70
        public void get_Minute(){} // RVA: 0x7FFAC860DD70
        public void get_Month(){} // RVA: 0x7FFAC860DE70
        public void get_Offset(){} // RVA: 0x7FFAC860DF40
        public void get_Second(){} // RVA: 0x7FFAC860DFA0
        public void get_Ticks(){} // RVA: 0x7FFAC860E0A0
        public void get_UtcTicks(){} // RVA: 0x7FFAC860E160
        public void get_TimeOfDay(){} // RVA: 0x7FFAC860E260
        public void get_Year(){} // RVA: 0x7FFAC860E330
        public void Add(){} // RVA: 0x7FFAC860E3F0
        public void AddDays(){} // RVA: 0x7FFAC860E530
        public void AddHours(){} // RVA: 0x7FFAC860E680
        public void AddMilliseconds(){} // RVA: 0x7FFAC860E7D0
        public void AddMinutes(){} // RVA: 0x7FFAC860E920
        public void AddMonths(){} // RVA: 0x7FFAC860EA70
        public void AddSeconds(){} // RVA: 0x7FFAC860EB80
        public void AddTicks(){} // RVA: 0x7FFAC860ECD0
        public void AddYears(){} // RVA: 0x7FFAC860EDE0
        public void Compare(){} // RVA: 0x7FFAC860EEF0
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC860F010
        public void CompareTo(){} // RVA: 0x7FFAC860F1C0
        public void Equals(){} // RVA: 0x7FFAC860F920 | overloaded x3
        public void EqualsExact(){} // RVA: 0x7FFAC860F650
        public void FromFileTime(){} // RVA: 0x7FFAC860FA80
        public void FromUnixTimeSeconds(){} // RVA: 0x7FFAC860FB00
        public void FromUnixTimeMilliseconds(){} // RVA: 0x7FFAC860FC70
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC860FDE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC860FF50
        public void GetHashCode(){} // RVA: 0x7FFAC86101F0
        public void Parse(){} // RVA: 0x7FFAC8610530 | overloaded x3
        public void ParseExact(){} // RVA: 0x7FFAC8610A40 | overloaded x3
        public void Subtract(){} // RVA: 0x7FFAC8610EA0 | overloaded x2
        public void ToFileTime(){} // RVA: 0x7FFAC8610FB0
        public void ToUnixTimeSeconds(){} // RVA: 0x7FFAC86110C0
        public void ToUnixTimeMilliseconds(){} // RVA: 0x7FFAC86111E0
        public void ToLocalTime(){} // RVA: 0x7FFAC8611370 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8611760 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC8611870
        public void ToUniversalTime(){} // RVA: 0x7FFAC86119B0
        public void TryParse(){} // RVA: 0x7FFAC8611C10 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAC8612200 | overloaded x2
        public void ValidateOffset(){} // RVA: 0x7FFAC8612520
        public void ValidateDate(){} // RVA: 0x7FFAC86126A0
        public void ValidateStyles(){} // RVA: 0x7FFAC86127F0
        public void op_Implicit(){} // RVA: 0x7FFAC8612910
        public void op_Addition(){} // RVA: 0x7FFAC8612930
        public void op_Subtraction(){} // RVA: 0x7FFAC8612B50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8612C70
        public void op_Inequality(){} // RVA: 0x7FFAC8612DD0
        public void op_LessThan(){} // RVA: 0x7FFAC8612F30
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC8613050
        public void op_GreaterThan(){} // RVA: 0x7FFAC8613170
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC8613290
        public void .cctor(){} // RVA: 0x7FFAC86133B0
    }

    public class DateTimeParse : Object
    {
        public MatchNumberDelegate m_hebrewNumberParser;
        public 0x6B0BF130[][] dateParsingStates; // 0x8

        // ── Methods ──
        public void ParseExact(){} // RVA: 0x7FFAC861A530 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAC861ABF0 | overloaded x3
        public void ParseExactMultiple(){} // RVA: 0x7FFAC861AE60 | overloaded x2
        public void TryParseExactMultiple(){} // RVA: 0x7FFAC861B370 | overloaded x3
        public void MatchWord(){} // RVA: 0x7FFAC861B6A0
        public void GetTimeZoneName(){} // RVA: 0x7FFAC861B8A0
        public void IsDigit(){} // RVA: 0x7FFAC861B950
        public void ParseFraction(){} // RVA: 0x7FFAC861B960
        public void ParseTimeZone(){} // RVA: 0x7FFAC861BA60
        public void HandleTimeZone(){} // RVA: 0x7FFAC861BE20
        public void Lex(){} // RVA: 0x7FFAC861C020
        public void GetJapaneseCalendarDefaultInstance(){} // RVA: 0x7FFAC861D200
        public void GetTaiwanCalendarDefaultInstance(){} // RVA: 0x7FFAC861D300
        public void VerifyValidPunctuation(){} // RVA: 0x7FFAC861D400
        public void GetYearMonthDayOrder(){} // RVA: 0x7FFAC861D660
        public void GetYearMonthOrder(){} // RVA: 0x7FFAC861D880
        public void GetMonthDayOrder(){} // RVA: 0x7FFAC861DA20
        public void TryAdjustYear(){} // RVA: 0x7FFAC861DBE0
        public void SetDateYMD(){} // RVA: 0x7FFAC861DC40
        public void SetDateMDY(){} // RVA: 0x7FFAC861DCC0
        public void SetDateDMY(){} // RVA: 0x7FFAC861DD50
        public void SetDateYDM(){} // RVA: 0x7FFAC861DDE0
        public void GetDefaultYear(){} // RVA: 0x7FFAC861DE70
        public void GetDayOfNN(){} // RVA: 0x7FFAC861DF10
        public void GetDayOfNNN(){} // RVA: 0x7FFAC861E0D0
        public void GetDayOfMN(){} // RVA: 0x7FFAC861E520
        public void GetHebrewDayOfNM(){} // RVA: 0x7FFAC861E760
        public void GetDayOfNM(){} // RVA: 0x7FFAC861E8F0
        public void GetDayOfMNN(){} // RVA: 0x7FFAC861EB30
        public void GetDayOfYNN(){} // RVA: 0x7FFAC861EEE0
        public void GetDayOfNNY(){} // RVA: 0x7FFAC861F040
        public void GetDayOfYMN(){} // RVA: 0x7FFAC861F1F0
        public void GetDayOfYN(){} // RVA: 0x7FFAC861F2E0
        public void GetDayOfYM(){} // RVA: 0x7FFAC861F3C0
        public void AdjustTimeMark(){} // RVA: 0x7FFAC861F4A0
        public void AdjustHour(){} // RVA: 0x7FFAC861F560
        public void GetTimeOfN(){} // RVA: 0x7FFAC861F5A0
        public void GetTimeOfNN(){} // RVA: 0x7FFAC861F610
        public void GetTimeOfNNN(){} // RVA: 0x7FFAC861F690
        public void GetDateOfDSN(){} // RVA: 0x7FFAC861F710
        public void GetDateOfNDS(){} // RVA: 0x7FFAC861F780
        public void GetDateOfNNDS(){} // RVA: 0x7FFAC861F860
        public void ProcessDateTimeSuffix(){} // RVA: 0x7FFAC861FAB0
        public void ProcessHebrewTerminalState(){} // RVA: 0x7FFAC861FB70
        public void ProcessTerminalState(){} // RVA: 0x7FFAC86200F0
        public void Parse(){} // RVA: 0x7FFAC86207D0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAC8620C60 | overloaded x3
        public void DetermineTimeZoneAdjustments(){} // RVA: 0x7FFAC86216D0
        public void DateTimeOffsetTimeZonePostProcessing(){} // RVA: 0x7FFAC8621950
        public void AdjustTimeZoneToUniversal(){} // RVA: 0x7FFAC8621C10
        public void AdjustTimeZoneToLocal(){} // RVA: 0x7FFAC8621D50
        public void ParseISO8601(){} // RVA: 0x7FFAC8622050
        public void MatchHebrewDigits(){} // RVA: 0x7FFAC8622740
        public void ParseDigits(){} // RVA: 0x7FFAC86228F0 | overloaded x2
        public void ParseFractionExact(){} // RVA: 0x7FFAC86229F0
        public void ParseSign(){} // RVA: 0x7FFAC8622B80
        public void ParseTimeZoneOffset(){} // RVA: 0x7FFAC8622C40
        public void MatchAbbreviatedMonthName(){} // RVA: 0x7FFAC8622F40
        public void MatchMonthName(){} // RVA: 0x7FFAC86231F0
        public void MatchAbbreviatedDayName(){} // RVA: 0x7FFAC8623610
        public void MatchDayName(){} // RVA: 0x7FFAC8623780
        public void MatchEraName(){} // RVA: 0x7FFAC86238F0
        public void MatchTimeMark(){} // RVA: 0x7FFAC8623A70
        public void MatchAbbreviatedTimeMark(){} // RVA: 0x7FFAC8623BF0
        public void CheckNewValue(){} // RVA: 0x7FFAC8623D50
        public void GetDateTimeNow(){} // RVA: 0x7FFAC8623E00
        public void CheckDefaultDateTime(){} // RVA: 0x7FFAC8623F60
        public void ExpandPredefinedFormat(){} // RVA: 0x7FFAC86241A0
        public void ParseJapaneseEraStart(){} // RVA: 0x7FFAC8624650
        public void ParseByFormat(){} // RVA: 0x7FFAC8624750
        public void TryParseQuoteString(){} // RVA: 0x7FFAC86261E0
        public void DoStrictParse(){} // RVA: 0x7FFAC8626300
        public void GetDateTimeParseException(){} // RVA: 0x7FFAC8626E40
        public void .cctor(){} // RVA: 0x7FFAC8627000
    }

    public class DateTimeRawInfo : ValueType
    {
        public int* num; // 0x10
        public int numCount; // 0x18
        public int month; // 0x1C
        public int year; // 0x20
        public int dayOfWeek; // 0x24
        public int era; // 0x28
        public 0x6B0BF0D8 timeMark; // 0x2C
        public double fraction; // 0x30
        public bool hasSameDateAndTimeSeparators; // 0x38

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8629DF0
        public void AddNumber(){} // RVA: 0x7FFAC8629E20
        public void GetNumber(){} // RVA: 0x7FFAC6E1D7B0
    }

    public class DateTimeResult : ValueType
    {
        public int Year; // 0x10
        public int Month; // 0x14
        public int Day; // 0x18
        public int Hour; // 0x1C
        public int Minute; // 0x20
        public int Second; // 0x24
        public double fraction; // 0x28
        public int era; // 0x30
        public 0x6B0BF448 flags; // 0x34
        public System.TimeSpan timeZoneOffset; // 0x38
        public System.Globalization.Calendar calendar; // 0x40
        public System.DateTime parsedDate; // 0x48
        public 0x6B0BF3F0 failure; // 0x50
        public string failureMessageID; // 0x58
        public object failureMessageFormatArgument; // 0x60
        public string failureArgumentName; // 0x68
        public System.ReadOnlySpan`1<char> originalDateTimeString; // 0x70
        public System.ReadOnlySpan`1<char> failedFormatSpecifier; // 0x80

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8629E40
        public void SetDate(){} // RVA: 0x7FFAC721A020
        public void SetBadFormatSpecifierFailure(){} // RVA: 0x7FFAC8629EE0 | overloaded x2
        public void SetBadDateTimeFailure(){} // RVA: 0x7FFAC8629F40
        public void SetFailure(){} // RVA: 0x7FFAC8629FB0 | overloaded x3
    }

    public class DateTimeToken : ValueType
    {
        public 0x6B0BF080 dtt; // 0x10
        public 0x6B0BF550 suffix; // 0x14
        public int num; // 0x18
    }

    public class Decimal : ValueType
    {
        public int High;
        public int Low;
        public int Mid;
        public System.Decimal IsNegative;
        public System.Decimal Scale; // 0x10
        public System.Decimal Low64; // 0x20
        public System.Decimal MaxValue; // 0x30
        public System.Decimal MinValue; // 0x40
        public int flags; // 0x10
        public int hi; // 0x14
        public int lo; // 0x18
        public int mid; // 0x1C
        public ulong ulomidLE; // 0x18

        // ── Methods ──
        public void get_High(){} // RVA: 0x7FFAC44202A0
        public void get_Low(){} // RVA: 0x7FFAC49C7500
        public void get_Mid(){} // RVA: 0x7FFAC49C7520
        public void get_IsNegative(){} // RVA: 0x7FFAC862EBA0
        public void get_Scale(){} // RVA: 0x7FFAC495DE20
        public void get_Low64(){} // RVA: 0x7FFAC86B0AF0
        public void AsMutable(){} // RVA: 0x7FFAC44F81E0
        public void DecDivMod1E9(){} // RVA: 0x7FFAC86B0B30
        public void .ctor(){} // RVA: 0x7FFAC86B11F0 | overloaded x9
        public void FromOACurrency(){} // RVA: 0x7FFAC86B0DB0
        public void ToOACurrency(){} // RVA: 0x7FFAC86B0EB0
        public void IsValid(){} // RVA: 0x7FFAC86B0F30
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC86B1140
        public void Abs(){} // RVA: 0x7FFAC86B1200
        public void Add(){} // RVA: 0x7FFAC86B1220
        public void Ceiling(){} // RVA: 0x7FFAC86B12C0
        public void Compare(){} // RVA: 0x7FFAC86B1370
        public void CompareTo(){} // RVA: 0x7FFAC86B14E0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFAC86B1540
        public void Equals(){} // RVA: 0x7FFAC86B18A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC86B1710
        public void Floor(){} // RVA: 0x7FFAC86B1910
        public void ToString(){} // RVA: 0x7FFAC86B1C30 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC86B1D20
        public void Parse(){} // RVA: 0x7FFAC86B20C0 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFAC86B22B0 | overloaded x2
        public void GetBits(){} // RVA: 0x7FFAC86B23B0
        public void Max(){} // RVA: 0x7FFAC86B2440
        public void Min(){} // RVA: 0x7FFAC86B24B0
        public void Remainder(){} // RVA: 0x7FFAC86B2520
        public void Multiply(){} // RVA: 0x7FFAC86B25C0
        public void Negate(){} // RVA: 0x7FFAC86B2660
        public void Round(){} // RVA: 0x7FFAC86B2920 | overloaded x5
        public void Sign(){} // RVA: 0x7FFAC86B2AF0
        public void Subtract(){} // RVA: 0x7FFAC86B2B10
        public void ToByte(){} // RVA: 0x7FFAC86B2BB0
        public void ToSByte(){} // RVA: 0x7FFAC86B2CD0
        public void ToInt16(){} // RVA: 0x7FFAC86B2DF0
        public void ToDouble(){} // RVA: 0x7FFAC86B2F10
        public void ToInt32(){} // RVA: 0x7FFAC86B2F60
        public void ToInt64(){} // RVA: 0x7FFAC86B3030
        public void ToUInt16(){} // RVA: 0x7FFAC86B3120
        public void ToUInt32(){} // RVA: 0x7FFAC86B3240
        public void ToUInt64(){} // RVA: 0x7FFAC86B3300
        public void ToSingle(){} // RVA: 0x7FFAC86B33E0
        public void Truncate(){} // RVA: 0x7FFAC86B34E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC86B36A0 | overloaded x9
        public void op_Explicit(){} // RVA: 0x7FFAC86B3BA0 | overloaded x13
        public void op_UnaryNegation(){} // RVA: 0x7FFAC86B2660
        public void op_Increment(){} // RVA: 0x7FFAC86B3C30
        public void op_Decrement(){} // RVA: 0x7FFAC86B3D20
        public void op_Addition(){} // RVA: 0x7FFAC86B3E10
        public void op_Subtraction(){} // RVA: 0x7FFAC86B3EB0
        public void op_Multiply(){} // RVA: 0x7FFAC86B3F50
        public void op_Division(){} // RVA: 0x7FFAC86B3FF0
        public void op_Modulus(){} // RVA: 0x7FFAC86B4090
        public void op_Equality(){} // RVA: 0x7FFAC86B4130
        public void op_Inequality(){} // RVA: 0x7FFAC86B41A0
        public void op_LessThan(){} // RVA: 0x7FFAC86B4210
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC86B4280
        public void op_GreaterThan(){} // RVA: 0x7FFAC86B42F0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC86B4360
        public void GetTypeCode(){} // RVA: 0x7FFAC3E454F0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC86B43D0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC86B4440
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC86B44D0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC86B4540
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC86B45B0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC86B4620
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC86B4690
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC86B4700
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC86B4770
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC86B47E0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC86B4850
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC86B48F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC32C0590
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC86B4960
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC86B49F0
        public void .cctor(){} // RVA: 0x7FFAC86B4A90
    }

    public class DecimalDecCalc : Object
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x7FFAC865D510
        public void DecDivMod1E9(){} // RVA: 0x7FFAC865D570
        public void DecAddInt32(){} // RVA: 0x7FFAC865D650
        public void D32AddCarry(){} // RVA: 0x7FFAC865D680
        public void DecMul10(){} // RVA: 0x7FFAC865D6A0
        public void DecShiftLeft(){} // RVA: 0x7FFAC865D790
        public void DecAdd(){} // RVA: 0x7FFAC865D7C0
    }

    public class DefaultBinder : Binder
    {
        public 0x6B0C2E08[] _primitiveConversions;

        // ── Methods ──
        public void BindToMethod(){} // RVA: 0x7FFAC866E6E0
        public void BindToField(){} // RVA: 0x7FFAC8670CB0
        public void SelectProperty(){} // RVA: 0x7FFAC86713A0
        public void ChangeType(){} // RVA: 0x7FFAC8672180
        public void ReorderArgumentArray(){} // RVA: 0x7FFAC86721E0
        public void ExactBinding(){} // RVA: 0x7FFAC8672650
        public void ExactPropertyBinding(){} // RVA: 0x7FFAC86728C0
        public void FindMostSpecific(){} // RVA: 0x7FFAC8672B90
        public void FindMostSpecificType(){} // RVA: 0x7FFAC8672F60
        public void FindMostSpecificMethod(){} // RVA: 0x7FFAC86733A0
        public void FindMostSpecificField(){} // RVA: 0x7FFAC8673990
        public void FindMostSpecificProperty(){} // RVA: 0x7FFAC8673AE0
        public void CompareMethodSigAndName(){} // RVA: 0x7FFAC8673C30
        public void GetHierarchyDepth(){} // RVA: 0x7FFAC8673D90
        public void FindMostDerivedNewSlotMeth(){} // RVA: 0x7FFAC8673E10
        public void ReorderParams(){} // RVA: 0x7FFAC8673F60
        public void CreateParamOrder(){} // RVA: 0x7FFAC8674190
        public void CanConvertPrimitive(){} // RVA: 0x7FFAC86743B0
        public void CanConvertPrimitiveObjectToType(){} // RVA: 0x7FFAC86746A0
        public void CompareMethodSig(){} // RVA: 0x7FFAC86747C0
        public void SelectMethod(){} // RVA: 0x7FFAC8674920
        public void CanChangePrimitive(){} // RVA: 0x7FFAC8675130
        public void CanPrimitiveWiden(){} // RVA: 0x7FFAC86752F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8675470
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
        public System.Reflection.MethodInfo method_info; // 0x58
        public System.Reflection.MethodInfo original_method_info; // 0x60
        public System.DelegateData data; // 0x68
        public bool method_is_virtual; // 0x70

        // ── Methods ──
        public void get_Method(){} // RVA: 0x7FFAC30FEBD0
        public void GetVirtualMethod_internal(){} // RVA: 0x7FFAC8699790
        public void get_Target(){} // RVA: 0x7FFAC2F4F0C0
        public void CreateDelegate_internal(){} // RVA: 0x7FFAC86997C0
        public void arg_type_match(){} // RVA: 0x7FFAC8699880
        public void arg_type_match_this(){} // RVA: 0x7FFAC8699AA0
        public void return_type_match(){} // RVA: 0x7FFAC8699C10
        public void CreateDelegate(){} // RVA: 0x7FFAC869B480 | overloaded x10
        public void GetCandidateMethod(){} // RVA: 0x7FFAC869AC40
        public void DynamicInvoke(){} // RVA: 0x7FFAC6916740
        public void InitializeDelegateData(){} // RVA: 0x7FFAC869B5B0
        public void DynamicInvokeImpl(){} // RVA: 0x7FFAC869B7A0
        public void Clone(){} // RVA: 0x7FFAC8512B10
        public void Equals(){} // RVA: 0x7FFAC869BC40
        public void GetHashCode(){} // RVA: 0x7FFAC869BE70
        public void GetMethodImpl(){} // RVA: 0x7FFAC869BEE0
        public void GetObjectData(){} // RVA: 0x7FFAC869C000
        public void GetInvocationList(){} // RVA: 0x7FFAC869C020
        public void Combine(){} // RVA: 0x7FFAC869C240 | overloaded x2
        public void CombineImpl(){} // RVA: 0x7FFAC869C410
        public void Remove(){} // RVA: 0x7FFAC869C470
        public void RemoveImpl(){} // RVA: 0x7FFAC869C5F0
        public void op_Equality(){} // RVA: 0x7FFAC869C620
        public void op_Inequality(){} // RVA: 0x7FFAC869C650
        public void AllocDelegateLike_internal(){} // RVA: 0x7FFAC869C6A0
    }

    public class DelegateData : Object
    {
        public System.Type target_type; // 0x10
        public string method_name; // 0x18
        public bool curried_first_arg; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DelegateSerializationHolder : Object
    {
        public System.Delegate _delegate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC869C720
        public void GetDelegateData(){} // RVA: 0x7FFAC869CAA0
        public void GetObjectData(){} // RVA: 0x7FFAC869CD60
        public void GetRealObject(){} // RVA: 0x7FFAC2F3C380
    }

    public class DivideByZeroException : ArithmeticException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class DllNotFoundException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86135B0 | overloaded x3
    }

    public class DomainNameHelper : Object
    {
        // ── Methods ──
        public void ParseCanonicalName(){} // RVA: 0x7FFAC93916A0
        public void IsValid(){} // RVA: 0x7FFAC9391920
        public void IsValidByIri(){} // RVA: 0x7FFAC9391AA0
        public void IdnEquivalent(){} // RVA: 0x7FFAC9392010 | overloaded x3
        public void IsIdnAce(){} // RVA: 0x7FFAC9392230 | overloaded x2
        public void UnicodeEquivalent(){} // RVA: 0x7FFAC93923C0 | overloaded x2
        public void IsASCIILetterOrDigit(){} // RVA: 0x7FFAC9392A50
        public void IsValidDomainLabelCharacter(){} // RVA: 0x7FFAC9392A80
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
        public void IsFinite(){} // RVA: 0x7FFAC86135D0
        public void IsInfinity(){} // RVA: 0x7FFAC8613600
        public void IsNaN(){} // RVA: 0x7FFAC8613630
        public void IsNegative(){} // RVA: 0x7FFAC8613660
        public void IsNegativeInfinity(){} // RVA: 0x7FFAC8613670
        public void IsPositiveInfinity(){} // RVA: 0x7FFAC8613690
        public void CompareTo(){} // RVA: 0x7FFAC86137E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8613900 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC5DA2860
        public void ToString(){} // RVA: 0x7FFAC8613AB0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC8613B40
        public void Parse(){} // RVA: 0x7FFAC8613E70 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFAC86140B0 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFAC4206550
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC86143A0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC8614410
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC86144A0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC8614500
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC8614560
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC86145C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC8614620
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC8614680
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC86146E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC8614740
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC86147A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC47D1AC0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC8614800
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC8614880
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC8614910
    }

}