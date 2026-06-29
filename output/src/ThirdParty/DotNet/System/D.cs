// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 23
// Methods: 537

namespace ThirdParty.DotNet.System
{
    public class DBNull : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC5C830
        public void GetObjectData(){} // RVA: 0x7ADC5C880
        public void ToString(){} // RVA: 0x7ADC5C8D0
        public void GetTypeCode(){} // RVA: 0x7A81DDCC0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7ADC5C910
        public void System.IConvertible.ToChar(){} // RVA: 0x7ADC5C960
        public void System.IConvertible.ToSByte(){} // RVA: 0x7ADC5C9B0
        public void System.IConvertible.ToByte(){} // RVA: 0x7ADC5CA00
        public void System.IConvertible.ToInt16(){} // RVA: 0x7ADC5CA50
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7ADC5CAA0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7ADC5CAF0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7ADC5CB40
        public void System.IConvertible.ToInt64(){} // RVA: 0x7ADC5CB90
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7ADC5CBE0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7ADC5CC30
        public void System.IConvertible.ToDouble(){} // RVA: 0x7ADC5CC80
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7ADC5CCD0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7ADC5CD20
        public void System.IConvertible.ToType(){} // RVA: 0x7ADC5CD70
        public void .cctor(){} // RVA: 0x7ADC5CDE0
    }

    public class DTSubString : ValueType
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ADC812B0
    }

    public class DateTime : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E38FF0
        public void get_InternalTicks(){} // RVA: 0x7A7E39010
        public void get_InternalKind(){} // RVA: 0x7A7E39030
        public void Add(){} // RVA: 0x7A7E39060
        public void AddDays(){} // RVA: 0x7A7E39070
        public void AddHours(){} // RVA: 0x7A7E39080
        public void AddMilliseconds(){} // RVA: 0x7A7E39090
        public void AddMinutes(){} // RVA: 0x7A7E390A0
        public void AddMonths(){} // RVA: 0x7A7E390B0
        public void AddSeconds(){} // RVA: 0x7A7E390C0
        public void AddTicks(){} // RVA: 0x7A7E390D0
        public void AddYears(){} // RVA: 0x7A7E390E0
        public void Compare(){} // RVA: 0x7ADC5EB00
        public void CompareTo(){} // RVA: 0x7A7E39100
        public void DateToTicks(){} // RVA: 0x7ADC5ECE0
        public void TimeToTicks(){} // RVA: 0x7ADC5EEB0
        public void DaysInMonth(){} // RVA: 0x7ADC5EF80
        public void DoubleDateToTicks(){} // RVA: 0x7ADC5F0C0
        public void Equals(){} // RVA: 0x7ADC5F320
        public void FromBinary(){} // RVA: 0x7ADC5F390
        public void FromBinaryRaw(){} // RVA: 0x7ADC5F600
        public void FromFileTime(){} // RVA: 0x7ADC5F6A0
        public void FromFileTimeUtc(){} // RVA: 0x7ADC5F740
        public void FromOADate(){} // RVA: 0x7ADC5F800
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7A7E39130
        public void IsDaylightSavingTime(){} // RVA: 0x7A7E39230
        public void SpecifyKind(){} // RVA: 0x7ADC5FBC0
        public void ToBinary(){} // RVA: 0x7A7E39240
        public void get_Date(){} // RVA: 0x7A7E39250
        public void GetDatePart(){} // RVA: 0x7A7E39270
        public void get_Day(){} // RVA: 0x7A7E39280
        public void get_DayOfWeek(){} // RVA: 0x7A7E392E0
        public void get_DayOfYear(){} // RVA: 0x7A7E392F0
        public void GetHashCode(){} // RVA: 0x7A7E39350
        public void get_Hour(){} // RVA: 0x7A7E39360
        public void IsAmbiguousDaylightSavingTime(){} // RVA: 0x7A7E39370
        public void get_Kind(){} // RVA: 0x7A7E393D0
        public void get_Millisecond(){} // RVA: 0x7A7E393E0
        public void get_Minute(){} // RVA: 0x7A7E393F0
        public void get_Month(){} // RVA: 0x7A7E39400
        public void get_Now(){} // RVA: 0x7ADC606B0
        public void get_Second(){} // RVA: 0x7A7E39460
        public void get_Ticks(){} // RVA: 0x7A7E39470
        public void get_TimeOfDay(){} // RVA: 0x7A7E394D0
        public void get_Today(){} // RVA: 0x7ADC60970
        public void get_Year(){} // RVA: 0x7A7E394E0
        public void IsLeapYear(){} // RVA: 0x7ADC60A90
        public void Parse(){} // RVA: 0x7ADC60D60
        public void ParseExact(){} // RVA: 0x7ADC611C0
        public void Subtract(){} // RVA: 0x7A7E39550
        public void TicksToOADate(){} // RVA: 0x7ADC61590
        public void ToOADate(){} // RVA: 0x7A7E39560
        public void ToFileTime(){} // RVA: 0x7A7E39570
        public void ToFileTimeUtc(){} // RVA: 0x7A7E39580
        public void ToLocalTime(){} // RVA: 0x7A7E395F0
        public void ToLongDateString(){} // RVA: 0x7A7E39600
        public void ToLongTimeString(){} // RVA: 0x7A7E39610
        public void ToShortDateString(){} // RVA: 0x7A7E39620
        public void ToShortTimeString(){} // RVA: 0x7A7E39630
        public void ToString(){} // RVA: 0x7A7E396C0
        public void TryFormat(){} // RVA: 0x7A7E396D0
        public void ToUniversalTime(){} // RVA: 0x7A7E39720
        public void TryParse(){} // RVA: 0x7ADC62330
        public void TryParseExact(){} // RVA: 0x7ADC627A0
        public void op_Addition(){} // RVA: 0x7ADC62A00
        public void op_Subtraction(){} // RVA: 0x7ADC62C20
        public void op_Equality(){} // RVA: 0x7ADC62C90
        public void op_Inequality(){} // RVA: 0x7ADC62D00
        public void op_LessThan(){} // RVA: 0x7ADC62D70
        public void op_LessThanOrEqual(){} // RVA: 0x7ADC62DE0
        public void op_GreaterThan(){} // RVA: 0x7ADC62E50
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ADC62EC0
        public void GetDateTimeFormats(){} // RVA: 0x7A7E39760
        public void GetTypeCode(){} // RVA: 0x7A772F0D0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7A7E39770
        public void System.IConvertible.ToChar(){} // RVA: 0x7A7E39780
        public void System.IConvertible.ToSByte(){} // RVA: 0x7A7E39790
        public void System.IConvertible.ToByte(){} // RVA: 0x7A7E397A0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7A7E397B0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7A7E397C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7A7E397D0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7A7E397E0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7A7E397F0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7A7E39800
        public void System.IConvertible.ToSingle(){} // RVA: 0x7A7E39810
        public void System.IConvertible.ToDouble(){} // RVA: 0x7A7E39820
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7A7E39830
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7A765F710
        public void System.IConvertible.ToType(){} // RVA: 0x7A7E39850
        public void TryCreate(){} // RVA: 0x7ADC63A20
        public void get_UtcNow(){} // RVA: 0x7ADC63C30
        public void GetSystemTimeAsFileTime(){} // RVA: 0x7ADC63CA0
        public void ToBinaryRaw(){} // RVA: 0x7A765F710
        public void .cctor(){} // RVA: 0x7ADC63CC0
    }

    public class DateTimeFormat : Object
    {
        // ── Methods ──
        public void FormatDigits(){} // RVA: 0x7ADC6C350
        public void HebrewFormatDigits(){} // RVA: 0x7ADC6C450
        public void ParseRepeatPattern(){} // RVA: 0x7ADC6C4D0
        public void FormatDayOfWeek(){} // RVA: 0x7ADC6C560
        public void FormatMonth(){} // RVA: 0x7ADC6C5A0
        public void FormatHebrewMonthName(){} // RVA: 0x7ADC6C5E0
        public void ParseQuoteString(){} // RVA: 0x7ADC6C6B0
        public void ParseNextChar(){} // RVA: 0x7ADC6C8A0
        public void IsUseGenitiveForm(){} // RVA: 0x7ADC6C910
        public void FormatCustomized(){} // RVA: 0x7ADC6CA50
        public void FormatCustomizedTimeZone(){} // RVA: 0x7ADC6DF90
        public void FormatCustomizedRoundripTimeZone(){} // RVA: 0x7ADC6E4A0
        public void Append2DigitNumber(){} // RVA: 0x7ADC6E7D0
        public void GetRealFormat(){} // RVA: 0x7ADC6E8E0
        public void ExpandPredefinedFormat(){} // RVA: 0x7ADC6EDD0
        public void Format(){} // RVA: 0x7ADC6F2C0
        public void TryFormat(){} // RVA: 0x7ADC6F6E0
        public void FormatStringBuilder(){} // RVA: 0x7ADC6F900
        public void TryFormatO(){} // RVA: 0x7ADC6FCA0
        public void TryFormatR(){} // RVA: 0x7ADC704B0
        public void WriteTwoDecimalDigits(){} // RVA: 0x7ADC709B0
        public void WriteFourDecimalDigits(){} // RVA: 0x7ADC70A10
        public void WriteDigits(){} // RVA: 0x7ADC70AE0
        public void GetAllDateTimes(){} // RVA: 0x7ADC71080
        public void InvalidFormatForLocal(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADC712F0
    }

    public class DateTimeOffset : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E3A040
        public void get_Now(){} // RVA: 0x7ADC646B0
        public void get_UtcNow(){} // RVA: 0x7ADC64720
        public void get_DateTime(){} // RVA: 0x7A7E39950
        public void get_UtcDateTime(){} // RVA: 0x7A7E399A0
        public void get_LocalDateTime(){} // RVA: 0x7A7E39A00
        public void ToOffset(){} // RVA: 0x7A7E39A10
        public void get_ClockDateTime(){} // RVA: 0x7A7E39A40
        public void get_Date(){} // RVA: 0x7A7E39A50
        public void get_Day(){} // RVA: 0x7A7E39A60
        public void get_DayOfWeek(){} // RVA: 0x7A7E39A70
        public void get_DayOfYear(){} // RVA: 0x7A7E39A80
        public void get_Hour(){} // RVA: 0x7A7E39A90
        public void get_Millisecond(){} // RVA: 0x7A7E39AA0
        public void get_Minute(){} // RVA: 0x7A7E39AB0
        public void get_Month(){} // RVA: 0x7A7E39AC0
        public void get_Offset(){} // RVA: 0x7A7E39AD0
        public void get_Second(){} // RVA: 0x7A7E39B30
        public void get_Ticks(){} // RVA: 0x7A7E39B40
        public void get_UtcTicks(){} // RVA: 0x7A7E39B50
        public void get_TimeOfDay(){} // RVA: 0x7A7E39B60
        public void get_Year(){} // RVA: 0x7A7E39B70
        public void Add(){} // RVA: 0x7A7E39B80
        public void AddDays(){} // RVA: 0x7A7E39BB0
        public void AddHours(){} // RVA: 0x7A7E39BE0
        public void AddMilliseconds(){} // RVA: 0x7A7E39C10
        public void AddMinutes(){} // RVA: 0x7A7E39C40
        public void AddMonths(){} // RVA: 0x7A7E39C70
        public void AddSeconds(){} // RVA: 0x7A7E39CA0
        public void AddTicks(){} // RVA: 0x7A7E39CD0
        public void AddYears(){} // RVA: 0x7A7E39D00
        public void Compare(){} // RVA: 0x7ADC66260
        public void System.IComparable.CompareTo(){} // RVA: 0x7A7E39D30
        public void CompareTo(){} // RVA: 0x7A7E39EF0
        public void Equals(){} // RVA: 0x7ADC66C90
        public void EqualsExact(){} // RVA: 0x7A7E39F40
        public void FromFileTime(){} // RVA: 0x7ADC66DF0
        public void FromUnixTimeSeconds(){} // RVA: 0x7ADC66E70
        public void FromUnixTimeMilliseconds(){} // RVA: 0x7ADC66FE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7A7E39F60
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7A7E39F70
        public void GetHashCode(){} // RVA: 0x7A7E3A210
        public void Parse(){} // RVA: 0x7ADC678A0
        public void ParseExact(){} // RVA: 0x7ADC67F40
        public void Subtract(){} // RVA: 0x7A7E3A240
        public void ToFileTime(){} // RVA: 0x7A7E3A270
        public void ToUnixTimeSeconds(){} // RVA: 0x7A7E3A280
        public void ToUnixTimeMilliseconds(){} // RVA: 0x7A7E3A290
        public void ToLocalTime(){} // RVA: 0x7A7E3A310
        public void ToString(){} // RVA: 0x7A7E3A370
        public void TryFormat(){} // RVA: 0x7A7E3A380
        public void ToUniversalTime(){} // RVA: 0x7A7E3A3D0
        public void TryParse(){} // RVA: 0x7ADC69110
        public void TryParseExact(){} // RVA: 0x7ADC69580
        public void ValidateOffset(){} // RVA: 0x7ADC698B0
        public void ValidateDate(){} // RVA: 0x7ADC69A30
        public void ValidateStyles(){} // RVA: 0x7ADC69B80
        public void op_Implicit(){} // RVA: 0x7ADC69CA0
        public void op_Addition(){} // RVA: 0x7ADC69CC0
        public void op_Subtraction(){} // RVA: 0x7ADC69EE0
        public void op_Equality(){} // RVA: 0x7ADC6A000
        public void op_Inequality(){} // RVA: 0x7ADC6A160
        public void op_LessThan(){} // RVA: 0x7ADC6A2C0
        public void op_LessThanOrEqual(){} // RVA: 0x7ADC6A3E0
        public void op_GreaterThan(){} // RVA: 0x7ADC6A500
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ADC6A620
        public void .cctor(){} // RVA: 0x7ADC6A740
    }

    public class DateTimeParse : Object
    {
        // ── Methods ──
        public void ParseExact(){} // RVA: 0x7ADC719F0
        public void TryParseExact(){} // RVA: 0x7ADC720E0
        public void ParseExactMultiple(){} // RVA: 0x7ADC72350
        public void TryParseExactMultiple(){} // RVA: 0x7ADC72860
        public void MatchWord(){} // RVA: 0x7ADC72BA0
        public void GetTimeZoneName(){} // RVA: 0x7ADC72DA0
        public void IsDigit(){} // RVA: 0x7ADC72E50
        public void ParseFraction(){} // RVA: 0x7ADC72E60
        public void ParseTimeZone(){} // RVA: 0x7ADC72F60
        public void HandleTimeZone(){} // RVA: 0x7ADC73320
        public void Lex(){} // RVA: 0x7ADC73520
        public void GetJapaneseCalendarDefaultInstance(){} // RVA: 0x7ADC746B0
        public void GetTaiwanCalendarDefaultInstance(){} // RVA: 0x7ADC747B0
        public void VerifyValidPunctuation(){} // RVA: 0x7ADC748B0
        public void GetYearMonthDayOrder(){} // RVA: 0x7ADC74B10
        public void GetYearMonthOrder(){} // RVA: 0x7ADC74D50
        public void GetMonthDayOrder(){} // RVA: 0x7ADC74EF0
        public void TryAdjustYear(){} // RVA: 0x7ADC750B0
        public void SetDateYMD(){} // RVA: 0x7ADC75110
        public void SetDateMDY(){} // RVA: 0x7ADC75190
        public void SetDateDMY(){} // RVA: 0x7ADC75220
        public void SetDateYDM(){} // RVA: 0x7ADC752B0
        public void GetDefaultYear(){} // RVA: 0x7ADC75340
        public void GetDayOfNN(){} // RVA: 0x7ADC753E0
        public void GetDayOfNNN(){} // RVA: 0x7ADC755A0
        public void GetDayOfMN(){} // RVA: 0x7ADC759F0
        public void GetHebrewDayOfNM(){} // RVA: 0x7ADC75C30
        public void GetDayOfNM(){} // RVA: 0x7ADC75DC0
        public void GetDayOfMNN(){} // RVA: 0x7ADC76000
        public void GetDayOfYNN(){} // RVA: 0x7ADC763B0
        public void GetDayOfNNY(){} // RVA: 0x7ADC76510
        public void GetDayOfYMN(){} // RVA: 0x7ADC766C0
        public void GetDayOfYN(){} // RVA: 0x7ADC767B0
        public void GetDayOfYM(){} // RVA: 0x7ADC76890
        public void AdjustTimeMark(){} // RVA: 0x7ADC76970
        public void AdjustHour(){} // RVA: 0x7ADC76A30
        public void GetTimeOfN(){} // RVA: 0x7ADC76A70
        public void GetTimeOfNN(){} // RVA: 0x7ADC76AE0
        public void GetTimeOfNNN(){} // RVA: 0x7ADC76B60
        public void GetDateOfDSN(){} // RVA: 0x7ADC76BE0
        public void GetDateOfNDS(){} // RVA: 0x7ADC76C50
        public void GetDateOfNNDS(){} // RVA: 0x7ADC76D30
        public void ProcessDateTimeSuffix(){} // RVA: 0x7ADC76F80
        public void ProcessHebrewTerminalState(){} // RVA: 0x7ADC77040
        public void ProcessTerminalState(){} // RVA: 0x7ADC775C0
        public void Parse(){} // RVA: 0x7ADC77CA0
        public void TryParse(){} // RVA: 0x7ADC78140
        public void DetermineTimeZoneAdjustments(){} // RVA: 0x7ADC78B90
        public void DateTimeOffsetTimeZonePostProcessing(){} // RVA: 0x7ADC78E10
        public void AdjustTimeZoneToUniversal(){} // RVA: 0x7ADC790D0
        public void AdjustTimeZoneToLocal(){} // RVA: 0x7ADC79210
        public void ParseISO8601(){} // RVA: 0x7ADC79520
        public void MatchHebrewDigits(){} // RVA: 0x7ADC79BF0
        public void ParseDigits(){} // RVA: 0x7ADC79DA0
        public void ParseFractionExact(){} // RVA: 0x7ADC79EA0
        public void ParseSign(){} // RVA: 0x7ADC7A030
        public void ParseTimeZoneOffset(){} // RVA: 0x7ADC7A0F0
        public void MatchAbbreviatedMonthName(){} // RVA: 0x7ADC7A3F0
        public void MatchMonthName(){} // RVA: 0x7ADC7A6B0
        public void MatchAbbreviatedDayName(){} // RVA: 0x7ADC7AAD0
        public void MatchDayName(){} // RVA: 0x7ADC7AC40
        public void MatchEraName(){} // RVA: 0x7ADC7ADB0
        public void MatchTimeMark(){} // RVA: 0x7ADC7AF40
        public void MatchAbbreviatedTimeMark(){} // RVA: 0x7ADC7B0C0
        public void CheckNewValue(){} // RVA: 0x7ADC7B220
        public void GetDateTimeNow(){} // RVA: 0x7ADC7B2D0
        public void CheckDefaultDateTime(){} // RVA: 0x7ADC7B430
        public void ExpandPredefinedFormat(){} // RVA: 0x7ADC7B670
        public void ParseJapaneseEraStart(){} // RVA: 0x7ADC7BB20
        public void ParseByFormat(){} // RVA: 0x7ADC7BC20
        public void TryParseQuoteString(){} // RVA: 0x7ADC7D6B0
        public void DoStrictParse(){} // RVA: 0x7ADC7D7D0
        public void GetDateTimeParseException(){} // RVA: 0x7ADC7E310
        public void .cctor(){} // RVA: 0x7ADC7E4D0
    }

    public class DateTimeRawInfo : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E3AF40
        public void AddNumber(){} // RVA: 0x7A7E3AF70
        public void GetNumber(){} // RVA: 0x7A79C7270
    }

    public class DateTimeResult : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7ADC81330
        public void SetDate(){} // RVA: 0x7AC7C3C40
        public void SetBadFormatSpecifierFailure(){} // RVA: 0x7ADC813D0
        public void SetBadDateTimeFailure(){} // RVA: 0x7ADC81430
        public void SetFailure(){} // RVA: 0x7ADC814A0
    }

    public class DateTime[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2CFE40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27EEA0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Decimal : ValueType
    {
        // ── Methods ──
        public void get_High(){} // RVA: 0x7A765F0A0
        public void get_Low(){} // RVA: 0x7A75FEFA0
        public void get_Mid(){} // RVA: 0x7A767FBD0
        public void get_IsNegative(){} // RVA: 0x7A7E3B470
        public void get_Scale(){} // RVA: 0x7A767CB00
        public void get_Low64(){} // RVA: 0x7A7E42260
        public void AsMutable(){} // RVA: 0x7A97F8BA0
        public void DecDivMod1E9(){} // RVA: 0x7ADD08110
        public void .ctor(){} // RVA: 0x7A7E42430
        public void FromOACurrency(){} // RVA: 0x7ADD083A0
        public void ToOACurrency(){} // RVA: 0x7ADD084A0
        public void IsValid(){} // RVA: 0x7ADD08520
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7A7E42380
        public void Abs(){} // RVA: 0x7ADD087F0
        public void Add(){} // RVA: 0x7ADD08810
        public void Ceiling(){} // RVA: 0x7ADD088B0
        public void Compare(){} // RVA: 0x7ADD08960
        public void CompareTo(){} // RVA: 0x7A7E42450
        public void Divide(){} // RVA: 0x7ADD08B30
        public void Equals(){} // RVA: 0x7ADD08E90
        public void GetHashCode(){} // RVA: 0x7A7E42530
        public void Floor(){} // RVA: 0x7ADD08F00
        public void ToString(){} // RVA: 0x7A7E42570
        public void TryFormat(){} // RVA: 0x7A7E42580
        public void Parse(){} // RVA: 0x7ADD096B0
        public void TryParse(){} // RVA: 0x7ADD098A0
        public void GetBits(){} // RVA: 0x7ADD099A0
        public void Max(){} // RVA: 0x7ADD09A30
        public void Min(){} // RVA: 0x7ADD09AA0
        public void Remainder(){} // RVA: 0x7ADD09B10
        public void Multiply(){} // RVA: 0x7ADD09BB0
        public void Negate(){} // RVA: 0x7ADD09C50
        public void Round(){} // RVA: 0x7ADD09F10
        public void Sign(){} // RVA: 0x7ADD0A0E0
        public void Subtract(){} // RVA: 0x7ADD0A100
        public void ToByte(){} // RVA: 0x7ADD0A1A0
        public void ToSByte(){} // RVA: 0x7ADD0A2C0
        public void ToInt16(){} // RVA: 0x7ADD0A3E0
        public void ToDouble(){} // RVA: 0x7ADD0A500
        public void ToInt32(){} // RVA: 0x7ADD0A550
        public void ToInt64(){} // RVA: 0x7ADD0A620
        public void ToUInt16(){} // RVA: 0x7ADD0A710
        public void ToUInt32(){} // RVA: 0x7ADD0A830
        public void ToUInt64(){} // RVA: 0x7ADD0A8F0
        public void ToSingle(){} // RVA: 0x7ADD0A9D0
        public void Truncate(){} // RVA: 0x7ADD0AAD0
        public void op_Implicit(){} // RVA: 0x7ADD0AC90
        public void op_Explicit(){} // RVA: 0x7ADD0B190
        public void op_UnaryNegation(){} // RVA: 0x7ADD09C50
        public void op_Increment(){} // RVA: 0x7ADD0B220
        public void op_Decrement(){} // RVA: 0x7ADD0B310
        public void op_Addition(){} // RVA: 0x7ADD0B400
        public void op_Subtraction(){} // RVA: 0x7ADD0B4A0
        public void op_Multiply(){} // RVA: 0x7ADD0B540
        public void op_Division(){} // RVA: 0x7ADD0B5E0
        public void op_Modulus(){} // RVA: 0x7ADD0B680
        public void op_Equality(){} // RVA: 0x7ADD0B720
        public void op_Inequality(){} // RVA: 0x7ADD0B790
        public void op_LessThan(){} // RVA: 0x7ADD0B800
        public void op_LessThanOrEqual(){} // RVA: 0x7ADD0B870
        public void op_GreaterThan(){} // RVA: 0x7ADD0B8E0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ADD0B950
        public void GetTypeCode(){} // RVA: 0x7A7E42650
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7A7E42660
        public void System.IConvertible.ToChar(){} // RVA: 0x7A7E426D0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7A7E426E0
        public void System.IConvertible.ToByte(){} // RVA: 0x7A7E42750
        public void System.IConvertible.ToInt16(){} // RVA: 0x7A7E427C0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7A7E42830
        public void System.IConvertible.ToInt32(){} // RVA: 0x7A7E428A0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7A7E42910
        public void System.IConvertible.ToInt64(){} // RVA: 0x7A7E42980
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7A7E429F0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7A7E42A60
        public void System.IConvertible.ToDouble(){} // RVA: 0x7A7E42B00
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7A7662BE0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7A7E42B70
        public void System.IConvertible.ToType(){} // RVA: 0x7A7E42B80
        public void .cctor(){} // RVA: 0x7ADD0C080
    }

    public class DecimalDecCalc : Object
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x7ADCB49B0
        public void DecDivMod1E9(){} // RVA: 0x7ADCB4A10
        public void DecAddInt32(){} // RVA: 0x7ADCB4AF0
        public void D32AddCarry(){} // RVA: 0x7ADCB4B20
        public void DecMul10(){} // RVA: 0x7ADCB4B40
        public void DecShiftLeft(){} // RVA: 0x7ADCB4C20
        public void DecAdd(){} // RVA: 0x7ADCB4C50
    }

    public class DecimalDecCalc : Object
    {
        // ── Methods ──
        public void D32DivMod1E9(){} // RVA: 0x7ADCB49B0
        public void DecDivMod1E9(){} // RVA: 0x7ADCB4A10
        public void DecAddInt32(){} // RVA: 0x7ADCB4AF0
        public void D32AddCarry(){} // RVA: 0x7ADCB4B20
        public void DecMul10(){} // RVA: 0x7ADCB4B40
        public void DecShiftLeft(){} // RVA: 0x7ADCB4C20
        public void DecAdd(){} // RVA: 0x7ADCB4C50
    }

    public class Decimal[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D01B0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27F130
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class DefaultBinder : Binder
    {
        // ── Methods ──
        public void BindToMethod(){} // RVA: 0x7ADCC5A60
        public void BindToField(){} // RVA: 0x7ADCC80C0
        public void SelectProperty(){} // RVA: 0x7ADCC87C0
        public void ChangeType(){} // RVA: 0x7ADCC9640
        public void ReorderArgumentArray(){} // RVA: 0x7ADCC96A0
        public void ExactBinding(){} // RVA: 0x7ADCC9B10
        public void ExactPropertyBinding(){} // RVA: 0x7ADCC9DD0
        public void FindMostSpecific(){} // RVA: 0x7ADCCA0D0
        public void FindMostSpecificType(){} // RVA: 0x7ADCCA4D0
        public void FindMostSpecificMethod(){} // RVA: 0x7ADCCA910
        public void FindMostSpecificField(){} // RVA: 0x7ADCCAF40
        public void FindMostSpecificProperty(){} // RVA: 0x7ADCCB090
        public void CompareMethodSigAndName(){} // RVA: 0x7ADCCB1E0
        public void GetHierarchyDepth(){} // RVA: 0x7ADCCB370
        public void FindMostDerivedNewSlotMeth(){} // RVA: 0x7ADCCB3F0
        public void ReorderParams(){} // RVA: 0x7ADCCB550
        public void CreateParamOrder(){} // RVA: 0x7ADCCB7C0
        public void CanConvertPrimitive(){} // RVA: 0x7ADCCBA20
        public void CanConvertPrimitiveObjectToType(){} // RVA: 0x7ADCCBD20
        public void CompareMethodSig(){} // RVA: 0x7ADCCBE40
        public void SelectMethod(){} // RVA: 0x7ADCCBFD0
        public void CanChangePrimitive(){} // RVA: 0x7ADCCC8A0
        public void CanPrimitiveWiden(){} // RVA: 0x7ADCCCA60
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADCCCBE0
    }

    public class Delegate : Object
    {
        // ── Methods ──
        public void get_Method(){} // RVA: 0x7A874BF50
        public void GetVirtualMethod_internal(){} // RVA: 0x7ADCF0CA0
        public void get_Target(){} // RVA: 0x7A81052C0
        public void CreateDelegate_internal(){} // RVA: 0x7ADCF0CD0
        public void arg_type_match(){} // RVA: 0x7ADCF0D90
        public void arg_type_match_this(){} // RVA: 0x7ADCF0FB0
        public void return_type_match(){} // RVA: 0x7ADCF1120
        public void CreateDelegate(){} // RVA: 0x7ADCF29F0
        public void GetCandidateMethod(){} // RVA: 0x7ADCF2170
        public void DynamicInvoke(){} // RVA: 0x7ABE04E20
        public void InitializeDelegateData(){} // RVA: 0x7ADCF2B20
        public void DynamicInvokeImpl(){} // RVA: 0x7ADCF2D10
        public void Clone(){} // RVA: 0x7ADB694F0
        public void Equals(){} // RVA: 0x7ADCF31C0
        public void GetHashCode(){} // RVA: 0x7ADCF3410
        public void GetMethodImpl(){} // RVA: 0x7ADCF3480
        public void GetObjectData(){} // RVA: 0x7ADCF35A0
        public void GetInvocationList(){} // RVA: 0x7ADCF35C0
        public void Combine(){} // RVA: 0x7ADCF37E0
        public void CombineImpl(){} // RVA: 0x7ADCF39C0
        public void Remove(){} // RVA: 0x7ADCF3A20
        public void RemoveImpl(){} // RVA: 0x7ADCF3BA0
        public void op_Equality(){} // RVA: 0x7ADCF3BD0
        public void op_Inequality(){} // RVA: 0x7ADCF3C00
        public void AllocDelegateLike_internal(){} // RVA: 0x7ADCF3C50
    }

    public class DelegateData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DelegateSerializationHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADCF3CD0
        public void GetDelegateData(){} // RVA: 0x7ADCF4070
        public void GetObjectData(){} // RVA: 0x7ADCF4330
        public void GetRealObject(){} // RVA: 0x7A80F2570
    }

    public class Delegate[] : Array
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

    public class DivideByZeroException : ArithmeticException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class DllNotFoundException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC6A940
    }

    public class DomainNameHelper : Object
    {
        // ── Methods ──
        public void ParseCanonicalName(){} // RVA: 0x7AE9E7FE0
        public void IsValid(){} // RVA: 0x7AE9E8240
        public void IsValidByIri(){} // RVA: 0x7AE9E83B0
        public void IdnEquivalent(){} // RVA: 0x7AE9E8900
        public void IsIdnAce(){} // RVA: 0x7AE9E8B20
        public void UnicodeEquivalent(){} // RVA: 0x7AE9E8CB0
        public void IsASCIILetterOrDigit(){} // RVA: 0x7AE9E9340
        public void IsValidDomainLabelCharacter(){} // RVA: 0x7AE9E9370
    }

    public class Double : ValueType
    {
        // ── Methods ──
        public void IsFinite(){} // RVA: 0x7ADC6A960
        public void IsInfinity(){} // RVA: 0x7ADC6A990
        public void IsNaN(){} // RVA: 0x7ADC6A9C0
        public void IsNegative(){} // RVA: 0x7ADC6A9F0
        public void IsNegativeInfinity(){} // RVA: 0x7ADC6AA00
        public void IsPositiveInfinity(){} // RVA: 0x7ADC6AA20
        public void CompareTo(){} // RVA: 0x7A7E3A410
        public void Equals(){} // RVA: 0x7A7E3A480
        public void GetHashCode(){} // RVA: 0x7A7E3A4C0
        public void ToString(){} // RVA: 0x7A7E3A530
        public void TryFormat(){} // RVA: 0x7A7E3A540
        public void Parse(){} // RVA: 0x7ADC6B200
        public void TryParse(){} // RVA: 0x7ADC6B440
        public void GetTypeCode(){} // RVA: 0x7A7E3A610
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7A7E3A620
        public void System.IConvertible.ToChar(){} // RVA: 0x7A7E3A690
        public void System.IConvertible.ToSByte(){} // RVA: 0x7A7E3A6A0
        public void System.IConvertible.ToByte(){} // RVA: 0x7A7E3A700
        public void System.IConvertible.ToInt16(){} // RVA: 0x7A7E3A760
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7A7E3A7C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7A7E3A820
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7A7E3A880
        public void System.IConvertible.ToInt64(){} // RVA: 0x7A7E3A8E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7A7E3A940
        public void System.IConvertible.ToSingle(){} // RVA: 0x7A7E3A9A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7A766FF50
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7A7E3AA00
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7A7E3AA80
        public void System.IConvertible.ToType(){} // RVA: 0x7A7E3AA90
    }

    public class Double[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D0A40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29FAC0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E65C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27F740
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29FAC0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}