// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 57
// Methods: 860

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver : Object
    {
        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x7ADCFB860
        public void SearchTerminfo(){} // RVA: 0x7ADCFBB10
        public void WriteConsole(){} // RVA: 0x7ADCFBCC0
        public void .ctor(){} // RVA: 0x7ADCFBCF0
        public void get_Initialized(){} // RVA: 0x7A9905F60
        public void Init(){} // RVA: 0x7ADCFC580
        public void IncrementX(){} // RVA: 0x7ADCFD1E0
        public void WriteSpecialKey(){} // RVA: 0x7ADCFD470
        public void IsSpecialKey(){} // RVA: 0x7ADCFD5E0
        public void GetCursorPosition(){} // RVA: 0x7ADCFD630
        public void CheckWindowDimensions(){} // RVA: 0x7ADCFD6D0
        public void get_WindowHeight(){} // RVA: 0x7ADCFD830
        public void get_WindowWidth(){} // RVA: 0x7ADCFD860
        public void AddToBuffer(){} // RVA: 0x7ADCFD890
        public void AdjustBuffer(){} // RVA: 0x7ADCFDA50
        public void CreateKeyInfoFromInt(){} // RVA: 0x7ADCFDA70
        public void GetKeyFromBuffer(){} // RVA: 0x7ADCFDBC0
        public void ReadKeyInternal(){} // RVA: 0x7ADCFDF40
        public void InputPending(){} // RVA: 0x7ADCFE0F0
        public void QueueEcho(){} // RVA: 0x7ADCFE130
        public void Echo(){} // RVA: 0x7ADCFE270
        public void EchoFlush(){} // RVA: 0x7ADCFE440
        public void Read(){} // RVA: 0x7ADCFE490
        public void ReadKey(){} // RVA: 0x7ADCFE850
        public void ReadLine(){} // RVA: 0x7ADCFE910
        public void ReadToEnd(){} // RVA: 0x7ADCFE920
        public void ReadUntilConditionInternal(){} // RVA: 0x7ADCFE930
        public void SetCursorPosition(){} // RVA: 0x7ADCFEC50
        public void CreateKeyMap(){} // RVA: 0x7ADCFEFE0
        public void InitKeys(){} // RVA: 0x7ADD00B50
        public void AddStringMapping(){} // RVA: 0x7ADD00E60
        public void .cctor(){} // RVA: 0x7ADD00EB0
    }

    public class TermInfoReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD033B0
        public void DetermineVersion(){} // RVA: 0x7ADD03490
        public void ReadHeader(){} // RVA: 0x7ADD03550
        public void ReadNames(){} // RVA: 0x7ADD037D0
        public void Get(){} // RVA: 0x7ADD03940
        public void GetStringBytes(){} // RVA: 0x7ADD03D50
        public void GetInt16(){} // RVA: 0x7ADD03C60
        public void GetString(){} // RVA: 0x7ADD03CC0
    }

    public class ThreadStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x7A8DD7270
        public void ThrowArgumentNullException(){} // RVA: 0x7ADCB4E40
        public void CreateArgumentNullException(){} // RVA: 0x7ADCB4E70
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7ADCB4F30
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7ADCB4F60
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7ADCB4FE0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7ADCB5010
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7ADCB5080
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7ADCB50B0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7ADCB5B30
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7ADCB5210
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7ADCB52D0
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7ADCB5300
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7ADCB53D0
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7ADCB5400
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7ADCB5490
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7ADCB54C0
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7ADCB5530
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7ADCB5560
        public void ThrowArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x7ADCB5600
        public void CreateArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x7ADCB5630
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7ADCB56D0
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7ADCB5700
        public void ThrowNotSupportedException(){} // RVA: 0x7ADCB5CE0
        public void CreateThrowNotSupportedException(){} // RVA: 0x7ADCB57A0
        public void TryFormatThrowFormatException(){} // RVA: 0x7ADCB5820
        public void TryParseThrowFormatException(){} // RVA: 0x7A7E01F80
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7ADCB5840
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7ADCB5870
        public void ThrowWrongKeyTypeArgumentException(){} // RVA: 0x7ADCB5890
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x7ADCB5970
        public void ThrowArgumentException(){} // RVA: 0x7ADCB5AB0
        public void ThrowInvalidOperationException(){} // RVA: 0x7ADCB5C20
        public void ThrowSerializationException(){} // RVA: 0x7ADCB5C80
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x7ADCB5D40
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x7ADCB5D90
        public void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted(){} // RVA: 0x7ADCB5DE0
        public void ThrowInvalidOperationException_InvalidOperation_EnumEnded(){} // RVA: 0x7ADCB5E30
        public void ThrowInvalidOperationException_InvalidOperation_NoValue(){} // RVA: 0x7ADCB5E80
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7ADCB6910
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7ADCB5F50
        public void ThrowIndexArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x7ADCB5F90
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x7ADCB5FD0
        public void GetAddingDuplicateWithKeyArgumentException(){} // RVA: 0x7ADCB6020
        public void ThrowAddingDuplicateWithKeyArgumentException(){} // RVA: 0x7ADCB60B0
        public void GetKeyNotFoundException(){} // RVA: 0x7ADCB60E0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ADCB6160
        public void ThrowInvalidTypeWithPointersNotSupported(){} // RVA: 0x7ADCB6170
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x7ADCB61E0
        public void GetInvalidOperationException(){} // RVA: 0x7ADCB6220
        public void ThrowArraySegmentCtorValidationFailedExceptions(){} // RVA: 0x7ADCB6280
        public void GetArraySegmentCtorValidationFailedException(){} // RVA: 0x7ADCB62B0
        public void GetArgumentException(){} // RVA: 0x7ADCB6430
        public void GetArgumentNullException(){} // RVA: 0x7ADCB64D0
        public void GetArgumentName(){} // RVA: 0x7ADCB6570
        public void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index(){} // RVA: 0x7ADCB69D0
        public void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count(){} // RVA: 0x7ADCB6A10
        public void GetResourceName(){} // RVA: 0x7ADCB6A50
        public void ThrowValueArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x7ADCB70D0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7AE0A9A10
        public void CreateArgumentNullException(){} // RVA: 0x7AE0A9A40
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7AE0A9B00
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7AE0A9B30
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7AE0A9BB0
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7AE0A9BE0
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7AE0A9CD0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7AE0A9D00
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7AE0A9DE0
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7AE0A9E10
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7AE0A9F40
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7AE0A9F70
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7AE0AA030
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7AE0AA060
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7AE0AA190
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7AE0AA1C0
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7AE0AA270
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7AE0AA2A0
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7AE0AA380
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7AE0AA3B0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7AE0AA450
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7AE0AA480
        public void TryFormatThrowFormatException(){} // RVA: 0x7AE0AA510
        public void TryParseThrowFormatException(){} // RVA: 0x7A7E01F80
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7AE0AA530
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7AE0AA560
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7AD991910
        public void Throw(){} // RVA: 0x7AD991930
        public void IfNullOrWhitespace(){} // RVA: 0x7AD991980
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7AD99C230
        public void Throw(){} // RVA: 0x7AD99C250
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7AD9A3840
        public void Throw(){} // RVA: 0x7AD9A3860
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7AD976B10
        public void Throw(){} // RVA: 0x7AD976B30
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7AE155960
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7AE155990
        public void GetArgumentNullException(){} // RVA: 0x7AE1559C0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7AE155A60
        public void GetArgumentName(){} // RVA: 0x7AE155B00
    }

    public class TimeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetUtcNow(){} // RVA: 0x7AD976720
        public void get_LocalTimeZone(){} // RVA: 0x7AD9767D0
        public void .cctor(){} // RVA: 0x7AD976820
    }

    public class TimeSpan : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E3E110
        public void get_Ticks(){} // RVA: 0x7A765F710
        public void get_Days(){} // RVA: 0x7A7E3E120
        public void get_Hours(){} // RVA: 0x7A7E3E140
        public void get_Milliseconds(){} // RVA: 0x7A7E3E180
        public void get_Minutes(){} // RVA: 0x7A7E3E1D0
        public void get_Seconds(){} // RVA: 0x7A7E3E220
        public void get_TotalDays(){} // RVA: 0x7A7E3E270
        public void get_TotalHours(){} // RVA: 0x7A7E3E290
        public void get_TotalMilliseconds(){} // RVA: 0x7A7E3E2B0
        public void get_TotalMinutes(){} // RVA: 0x7A7E3E2F0
        public void get_TotalSeconds(){} // RVA: 0x7A7E3E310
        public void Add(){} // RVA: 0x7A7E3E330
        public void Compare(){} // RVA: 0x7ADCA6670
        public void CompareTo(){} // RVA: 0x7A7E3E350
        public void FromDays(){} // RVA: 0x7ADCA6790
        public void Duration(){} // RVA: 0x7A7E3E370
        public void Equals(){} // RVA: 0x7AA68A530
        public void GetHashCode(){} // RVA: 0x7A7E3C6C0
        public void FromHours(){} // RVA: 0x7ADCA6940
        public void Interval(){} // RVA: 0x7ADCA69A0
        public void FromMilliseconds(){} // RVA: 0x7ADCA6AB0
        public void FromMinutes(){} // RVA: 0x7ADCA6B10
        public void Negate(){} // RVA: 0x7A7E3E410
        public void FromSeconds(){} // RVA: 0x7ADCA6C20
        public void Subtract(){} // RVA: 0x7A7E3E420
        public void FromTicks(){} // RVA: 0x7A97F8BA0
        public void TimeToTicks(){} // RVA: 0x7ADCA6D00
        public void ValidateStyles(){} // RVA: 0x7ADCA6DA0
        public void Parse(){} // RVA: 0x7ADCA6EA0
        public void ParseExact(){} // RVA: 0x7ADCA72F0
        public void TryParse(){} // RVA: 0x7ADCA7520
        public void TryParseExact(){} // RVA: 0x7ADCA79C0
        public void ToString(){} // RVA: 0x7A7E3E4A0
        public void TryFormat(){} // RVA: 0x7A7E3E4B0
        public void op_UnaryNegation(){} // RVA: 0x7ADCA7DD0
        public void op_Subtraction(){} // RVA: 0x7ADCA7E80
        public void op_UnaryPlus(){} // RVA: 0x7A97F8BA0
        public void op_Addition(){} // RVA: 0x7ADCA7F40
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7ADCA8000
        public void op_LessThan(){} // RVA: 0x7ADCA8010
        public void op_LessThanOrEqual(){} // RVA: 0x7ADCA8020
        public void op_GreaterThan(){} // RVA: 0x7ADCA8030
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ADCA8040
        public void .cctor(){} // RVA: 0x7ADCA8050
    }

    public class TimeSpan[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DB5A0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA298510
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TimeZone : Object
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7ADCA80D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_CurrentTimeZone(){} // RVA: 0x7ADCA81A0
        public void GetUtcOffset(){} // RVA: 0x7A7E063E0
        public void GetDaylightChanges(){} // RVA: 0x7A7E00740
        public void CalculateUtcOffset(){} // RVA: 0x7ADCA84A0
    }

    public class TimeZoneInfo : Object
    {
        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x7ADB47FD0
        public void PopulateAllSystemTimeZones(){} // RVA: 0x7ADB48070
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x7ADB48100
        public void .ctor(){} // RVA: 0x7ADB59430
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x7ADB488B0
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x7ADB4CC70
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x7ADB48D10
        public void GetLocalTimeZone(){} // RVA: 0x7ADB48EE0
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x7ADB49270
        public void FindSystemTimeZoneById(){} // RVA: 0x7ADB493A0
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x7ADB49880
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x7ADB4D2A0
        public void TryCreateAdjustmentRules(){} // RVA: 0x7ADB49CC0
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x7ADB4A920
        public void TryCompareStandardDate(){} // RVA: 0x7ADB4AA50
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x7ADB4AAD0
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x7ADB4B0A0
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x7ADB4B430
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x7ADB4B840
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x7ADB58440
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x7ADB4C000
        public void get_HaveRegistry(){} // RVA: 0x7ADB4C540
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x7ADB4C5C0
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x7ADB4C760
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x7ADB4C8F0
        public void GetTimeZoneInformationForYear(){} // RVA: 0x7ADB4CAB0
        public void TryCreateTimeZone(){} // RVA: 0x7ADB4E140
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x7ADB4EBD0
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x7ADB4EF40
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x7ADB4F1A0
        public void get_Id(){} // RVA: 0x7A80F2570
        public void get_DisplayName(){} // RVA: 0x7ADB4F9C0
        public void get_StandardName(){} // RVA: 0x7ADB4FA10
        public void get_DaylightName(){} // RVA: 0x7ADB4FA60
        public void get_BaseUtcOffset(){} // RVA: 0x7A83F69F0
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x7A82A20A0
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x7ADB4FEE0
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x7ADB503B0
        public void GetPreviousAdjustmentRule(){} // RVA: 0x7ADB50430
        public void GetUtcOffset(){} // RVA: 0x7ADB58E00
        public void GetLocalUtcOffset(){} // RVA: 0x7ADB50680
        public void IsAmbiguousTime(){} // RVA: 0x7ADB50B80
        public void IsDaylightSavingTime(){} // RVA: 0x7ADB510E0
        public void IsInvalidTime(){} // RVA: 0x7ADB513C0
        public void ClearCachedData(){} // RVA: 0x7ADB51670
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x7ADB51840
        public void ConvertTime(){} // RVA: 0x7ADB52260
        public void ConvertTimeFromUtc(){} // RVA: 0x7ADB52890
        public void ConvertTimeToUtc(){} // RVA: 0x7ADB52BB0
        public void Equals(){} // RVA: 0x7ADB52D30
        public void FromSerializedString(){} // RVA: 0x7ADB52D90
        public void GetHashCode(){} // RVA: 0x7ADB52E70
        public void GetSystemTimeZones(){} // RVA: 0x7ADB52F20
        public void HasSameRules(){} // RVA: 0x7ADB53410
        public void get_Local(){} // RVA: 0x7ADB53710
        public void ToSerializedString(){} // RVA: 0x7ADB53790
        public void ToString(){} // RVA: 0x7ADB4F9C0
        public void get_Utc(){} // RVA: 0x7ADB537A0
        public void CreateCustomTimeZone(){} // RVA: 0x7ADB53BA0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ADB53CD0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADB53E90
        public void GetAdjustmentRuleForTime(){} // RVA: 0x7ADB546C0
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x7ADB54950
        public void ConvertToUtc(){} // RVA: 0x7ADB54BA0
        public void ConvertFromUtc(){} // RVA: 0x7ADB54BC0
        public void ConvertToFromUtc(){} // RVA: 0x7ADB54BE0
        public void ConvertUtcToTimeZone(){} // RVA: 0x7ADB54EA0
        public void GetDaylightTime(){} // RVA: 0x7ADB55290
        public void GetIsDaylightSavings(){} // RVA: 0x7ADB55400
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x7ADB55A00
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x7ADB55AE0
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x7ADB55B70
        public void CheckIsDst(){} // RVA: 0x7ADB56660
        public void GetIsAmbiguousTime(){} // RVA: 0x7ADB56990
        public void GetIsInvalidTime(){} // RVA: 0x7ADB56D50
        public void GetUtcOffsetFromUtc(){} // RVA: 0x7ADB57490
        public void TransitionTimeToDateTime(){} // RVA: 0x7ADB57800
        public void TryGetTimeZone(){} // RVA: 0x7ADB58140
        public void ValidateTimeZoneInfo(){} // RVA: 0x7ADB58910
        public void UtcOffsetOutOfRange(){} // RVA: 0x7ADB58D20
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x7ADB58EE0
        public void .cctor(){} // RVA: 0x7ADB59000
    }

    public class TimeZoneInfo[] : Array
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

    public class TimeZoneNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADCA88C0
    }

    public class TimeoutException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class Tuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AA60E130
        public void CombineHashCodes(){} // RVA: 0x7ADCA89C0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A8051B10
        public void get_Item2(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7A7E01A40
        public void System.IComparable.CompareTo(){} // RVA: 0x7A7E01630
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7A7E06320
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7A7E01630
        public void ToString(){} // RVA: 0x7A7E00680
        public void System.ITupleInternal.ToString(){} // RVA: 0x7A7E00B20
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A7E00710
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A7E00680
        public void get_Item2(){} // RVA: 0x7A80804D0
        public void .ctor(){} // RVA: 0x7AA69AD00
        public void Equals(){} // RVA: 0x7AC228A80
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228B00
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228DF0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228E70
        public void GetHashCode(){} // RVA: 0x7AC2291F0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC229260
        public void ToString(){} // RVA: 0x7AC229410
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC2294E0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226430
        public void get_Item1(){} // RVA: 0x7A97277F0
        public void get_Item2(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7AC226490
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC226510
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC226660
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC2266E0
        public void GetHashCode(){} // RVA: 0x7AC2268C0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC226930
        public void ToString(){} // RVA: 0x7AC2269E0
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC226AB0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A80F2570
        public void get_Item2(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AC228410
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7AC228490
        public void System.IComparable.CompareTo(){} // RVA: 0x7AC228590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7AC228610
        public void GetHashCode(){} // RVA: 0x7AC228790
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7AC228800
        public void ToString(){} // RVA: 0x7AC228890
        public void System.ITupleInternal.ToString(){} // RVA: 0x7AC228960
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A81DDCC0
    }

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`2[] : Array
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

    public class Tuple`3 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A8051B10
        public void get_Item2(){} // RVA: 0x7A8051B10
        public void get_Item3(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7A7E01A40
        public void System.IComparable.CompareTo(){} // RVA: 0x7A7E01630
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7A7E06320
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7A7E01630
        public void ToString(){} // RVA: 0x7A7E00680
        public void System.ITupleInternal.ToString(){} // RVA: 0x7A7E00B20
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A7E00710
    }

    public class Tuple`4 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7A8051B10
        public void get_Item2(){} // RVA: 0x7A8051B10
        public void get_Item3(){} // RVA: 0x7A8051B10
        public void get_Item4(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A7E019D0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7A7E01A40
        public void System.IComparable.CompareTo(){} // RVA: 0x7A7E01630
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7A7E06320
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7A7E01630
        public void ToString(){} // RVA: 0x7A7E00680
        public void System.ITupleInternal.ToString(){} // RVA: 0x7A7E00B20
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7A7E00710
    }

    public class Type : MemberInfo
    {
        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x7ADCA89E0
        public void GetEnumName(){} // RVA: 0x7ADCA9020
        public void GetEnumNames(){} // RVA: 0x7ADCA9410
        public void GetEnumRawConstantValues(){} // RVA: 0x7ADCA94C0
        public void GetEnumData(){} // RVA: 0x7ADCA94F0
        public void BinarySearch(){} // RVA: 0x7ADCA99D0
        public void IsIntegerType(){} // RVA: 0x7ADCA9B90
        public void get_IsSerializable(){} // RVA: 0x7ADCA9EA0
        public void get_ContainsGenericParameters(){} // RVA: 0x7ADCAA0A0
        public void GetRootElementType(){} // RVA: 0x7ADCAA210
        public void get_IsVisible(){} // RVA: 0x7ADCAA270
        public void IsSubclassOf(){} // RVA: 0x7ADCAA470
        public void IsAssignableFrom(){} // RVA: 0x7ADCAA530
        public void ImplementInterface(){} // RVA: 0x7ADCAA6E0
        public void FilterAttributeImpl(){} // RVA: 0x7ADCAA820
        public void FilterNameImpl(){} // RVA: 0x7ADCAABB0
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x7ADCAAE60
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_MemberType(){} // RVA: 0x7A9F22B70
        public void GetType(){} // RVA: 0x7ADCADC20
        public void get_Namespace(){} // RVA: 0x7A7E00680
        public void get_AssemblyQualifiedName(){} // RVA: 0x7A7E00680
        public void get_FullName(){} // RVA: 0x7A7E00680
        public void get_Assembly(){} // RVA: 0x7A7E00680
        public void get_Module(){} // RVA: 0x7A7E00680
        public void get_IsNested(){} // RVA: 0x7ADCAB270
        public void get_DeclaringType(){} // RVA: 0x7A82D1450
        public void get_DeclaringMethod(){} // RVA: 0x7A82D1450
        public void get_ReflectedType(){} // RVA: 0x7A82D1450
        public void get_UnderlyingSystemType(){} // RVA: 0x7A7E00680
        public void get_IsArray(){} // RVA: 0x7ADCAB2E0
        public void IsArrayImpl(){} // RVA: 0x7A7E01900
        public void get_IsByRef(){} // RVA: 0x7ADCAB300
        public void IsByRefImpl(){} // RVA: 0x7A7E01900
        public void get_IsPointer(){} // RVA: 0x7ADCAB320
        public void IsPointerImpl(){} // RVA: 0x7A7E01900
        public void get_IsConstructedGenericType(){} // RVA: 0x7ADCAB340
        public void get_IsGenericParameter(){} // RVA: 0x7A80D7320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7ADCAB370
        public void get_IsGenericType(){} // RVA: 0x7A80D7320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7A80D7320
        public void get_IsSZArray(){} // RVA: 0x7ADCAB3F0
        public void get_IsVariableBoundArray(){} // RVA: 0x7ADCAB420
        public void get_HasElementType(){} // RVA: 0x7ADCAB470
        public void HasElementTypeImpl(){} // RVA: 0x7A7E01900
        public void GetElementType(){} // RVA: 0x7A7E00680
        public void GetArrayRank(){} // RVA: 0x7ADCAB490
        public void GetGenericTypeDefinition(){} // RVA: 0x7ADCAB4E0
        public void get_GenericTypeArguments(){} // RVA: 0x7ADCAB530
        public void GetGenericArguments(){} // RVA: 0x7ADCAB5C0
        public void get_GenericParameterPosition(){} // RVA: 0x7ADCAB610
        public void get_GenericParameterAttributes(){} // RVA: 0x7ADCAB660
        public void GetGenericParameterConstraints(){} // RVA: 0x7ADCAB6A0
        public void get_Attributes(){} // RVA: 0x7ADCAB740
        public void GetAttributeFlagsImpl(){} // RVA: 0x7A7E00710
        public void get_IsAbstract(){} // RVA: 0x7ADCAB760
        public void get_IsImport(){} // RVA: 0x7ADCAB790
        public void get_IsSealed(){} // RVA: 0x7ADCAB7C0
        public void get_IsSpecialName(){} // RVA: 0x7ADCAB7F0
        public void get_IsClass(){} // RVA: 0x7ADCAB820
        public void get_IsNestedAssembly(){} // RVA: 0x7ADCAB870
        public void get_IsNestedFamANDAssem(){} // RVA: 0x7ADCAB8A0
        public void get_IsNestedFamily(){} // RVA: 0x7ADCAB8D0
        public void get_IsNestedFamORAssem(){} // RVA: 0x7ADCAB900
        public void get_IsNestedPrivate(){} // RVA: 0x7ADCAB930
        public void get_IsNestedPublic(){} // RVA: 0x7ADCAB960
        public void get_IsNotPublic(){} // RVA: 0x7ADCAB990
        public void get_IsPublic(){} // RVA: 0x7ADCAB9C0
        public void get_IsAutoLayout(){} // RVA: 0x7ADCAB9F0
        public void get_IsExplicitLayout(){} // RVA: 0x7ADCABA20
        public void get_IsLayoutSequential(){} // RVA: 0x7ADCABA50
        public void get_IsAnsiClass(){} // RVA: 0x7ADCABA80
        public void get_IsAutoClass(){} // RVA: 0x7ADCABAB0
        public void get_IsUnicodeClass(){} // RVA: 0x7ADCABAE0
        public void get_IsCOMObject(){} // RVA: 0x7ADCABB10
        public void IsCOMObjectImpl(){} // RVA: 0x7A7E01900
        public void get_IsContextful(){} // RVA: 0x7ADCABB30
        public void IsContextfulImpl(){} // RVA: 0x7ADCABB50
        public void get_IsCollectible(){} // RVA: 0x7A81BD750
        public void get_IsEnum(){} // RVA: 0x7ADCABC30
        public void get_IsMarshalByRef(){} // RVA: 0x7ADCABD10
        public void IsMarshalByRefImpl(){} // RVA: 0x7ADCABD30
        public void get_IsPrimitive(){} // RVA: 0x7ADCABE10
        public void IsPrimitiveImpl(){} // RVA: 0x7A7E01900
        public void get_IsValueType(){} // RVA: 0x7ADCABE30
        public void IsValueTypeImpl(){} // RVA: 0x7ADCABE50
        public void get_IsSignatureType(){} // RVA: 0x7A80D7320
        public void get_IsSecurityCritical(){} // RVA: 0x7ADCABF30
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7ADCABF60
        public void get_IsSecurityTransparent(){} // RVA: 0x7ADCABF90
        public void GetConstructor(){} // RVA: 0x7ADCAC020
        public void GetConstructorImpl(){} // RVA: 0x7A7E10D30
        public void GetConstructors(){} // RVA: 0x7A7E00740
        public void GetEvent(){} // RVA: 0x7A7E0FC80
        public void GetEvents(){} // RVA: 0x7A7E00740
        public void GetField(){} // RVA: 0x7A7E0FC80
        public void GetFields(){} // RVA: 0x7A7E00740
        public void GetMember(){} // RVA: 0x7ADCAC280
        public void GetMembers(){} // RVA: 0x7A7E00740
        public void GetMethod(){} // RVA: 0x7ADCAC4B0
        public void GetMethodImpl(){} // RVA: 0x7A7E12050
        public void GetMethods(){} // RVA: 0x7A7E00740
        public void GetNestedType(){} // RVA: 0x7A7E0FC80
        public void GetProperty(){} // RVA: 0x7ADCACB00
        public void GetPropertyImpl(){} // RVA: 0x7A7E12240
        public void GetProperties(){} // RVA: 0x7A7E00740
        public void get_TypeHandle(){} // RVA: 0x7ADCACC10
        public void GetTypeHandle(){} // RVA: 0x7ADCACC50
        public void GetTypeArray(){} // RVA: 0x7ADCACCE0
        public void GetTypeCode(){} // RVA: 0x7ADCACE70
        public void GetTypeCodeImpl(){} // RVA: 0x7ADCACEE0
        public void get_GUID(){} // RVA: 0x7A7E00490
        public void get_BaseType(){} // RVA: 0x7A7E00680
        public void InvokeMember(){} // RVA: 0x7A7E122B0
        public void GetInterface(){} // RVA: 0x7A7E01780
        public void GetInterfaces(){} // RVA: 0x7A7E00680
        public void IsInstanceOfType(){} // RVA: 0x7ADCAD030
        public void IsEquivalentTo(){} // RVA: 0x7ADCAD080
        public void GetEnumUnderlyingType(){} // RVA: 0x7ADCAD0E0
        public void GetEnumValues(){} // RVA: 0x7ADCAD230
        public void MakeArrayType(){} // RVA: 0x7ADCAD320
        public void MakeByRefType(){} // RVA: 0x7ADCAD360
        public void MakeGenericType(){} // RVA: 0x7ADCAD3A0
        public void MakePointerType(){} // RVA: 0x7ADCAD3F0
        public void MakeGenericSignatureType(){} // RVA: 0x7ADCAD430
        public void ToString(){} // RVA: 0x7ADCAD4A0
        public void Equals(){} // RVA: 0x7ADCAD610
        public void GetHashCode(){} // RVA: 0x7ADCAD5B0
        public void get_DefaultBinder(){} // RVA: 0x7ADCAD6B0
        public void GetTypeFromHandle(){} // RVA: 0x7ADCAD7E0
        public void internal_from_handle(){} // RVA: 0x7ADCAD850
        public void get_IsSzArray(){} // RVA: 0x7A80D7320
        public void FormatTypeName(){} // RVA: 0x7ADCAD890
        public void get_IsInterface(){} // RVA: 0x7ADCAD8D0
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7ADCA8000
        public void get_FullNameOrDefault(){} // RVA: 0x7ADCADD60
        public void IsRuntimeImplemented(){} // RVA: 0x7ADCADDF0
        public void InternalGetNameIfAvailable(){} // RVA: 0x7A874BF50
        public void get_InternalNameIfAvailable(){} // RVA: 0x7ADCADE80
        public void get_NameOrDefault(){} // RVA: 0x7ADCADEB0
        public void .cctor(){} // RVA: 0x7ADCADF20
    }

    public class TypeAccessException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC6A940
    }

    public class TypeIdentifier
    {
        // ── Methods ──
        public void get_InternalName(){} // RVA: 0x7A7E00680
    }

    public class TypeIdentifiers : Object
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x7ADD040B0
    }

    public class TypeInitializationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADCAE450
        public void GetObjectData(){} // RVA: 0x7ADCAE560
        public void get_TypeName(){} // RVA: 0x7ADCAE760
    }

    public class TypeLoadException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADCE7E90
        public void get_Message(){} // RVA: 0x7ADCE7890
        public void SetMessageField(){} // RVA: 0x7ADCE78B0
        public void GetObjectData(){} // RVA: 0x7ADCE8120
    }

    public class TypeName
    {
        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0x7A7E00680
    }

    public class TypeNameParser : Object
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x7ADCEEBB0
    }

    public class TypeSpec : Object
    {
        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x7ACDAB700
        public void GetDisplayFullName(){} // RVA: 0x7ADD04790
        public void GetModifierString(){} // RVA: 0x7ADD04D60
        public void get_DisplayFullName(){} // RVA: 0x7ADD04FE0
        public void Parse(){} // RVA: 0x7ADD06100
        public void UnescapeInternalName(){} // RVA: 0x7ADD05150
        public void Resolve(){} // RVA: 0x7ADD05260
        public void AddName(){} // RVA: 0x7ADD05C90
        public void AddModifier(){} // RVA: 0x7ADD05E60
        public void SkipSpace(){} // RVA: 0x7ADD05FA0
        public void BoundCheck(){} // RVA: 0x7ADD06060
        public void ParsedTypeIdentifier(){} // RVA: 0x7ADD060F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Type[] : Array
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

    public class TypedReference : ValueType
    {
        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x7ADCE6FC0
        public void InternalMakeTypedReference(){} // RVA: 0x7ADCE75F0
        public void GetHashCode(){} // RVA: 0x7ADCE76C0
        public void Equals(){} // RVA: 0x7ADCE7750
        public void get_IsNull(){} // RVA: 0x7ADCE77B0
        public void SetTypedReference(){} // RVA: 0x7ADCE77D0
    }

}