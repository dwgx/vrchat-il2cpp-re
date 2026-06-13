// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 46
// Methods: 756

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver
    {
        public int* native_terminal_size;
        public int terminal_size; // 0x8
        public string[] locations; // 0x10

        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x5F0CC00
        public void SearchTerminfo(){} // RVA: 0x5F0CEB0
        public void WriteConsole(){} // RVA: 0x5F0D060
        public void .ctor(){} // RVA: 0x5F0D090
        public void get_Initialized(){} // RVA: 0x1B6CD50
        public void Init(){} // RVA: 0x5F0D910
        public void IncrementX(){} // RVA: 0x5F0E590
        public void WriteSpecialKey(){} // RVA: 0x5F0E820 | overloaded x2
        public void IsSpecialKey(){} // RVA: 0x5F0E990 | overloaded x2
        public void GetCursorPosition(){} // RVA: 0x5F0E9E0
        public void CheckWindowDimensions(){} // RVA: 0x5F0EA80
        public void get_WindowHeight(){} // RVA: 0x5F0EBE0
        public void get_WindowWidth(){} // RVA: 0x5F0EC10
        public void AddToBuffer(){} // RVA: 0x5F0EC40
        public void AdjustBuffer(){} // RVA: 0x5F0EDF0
        public void CreateKeyInfoFromInt(){} // RVA: 0x5F0EE10
        public void GetKeyFromBuffer(){} // RVA: 0x5F0EF50
        public void ReadKeyInternal(){} // RVA: 0x5F0F2D0
        public void InputPending(){} // RVA: 0x5F0F480
        public void QueueEcho(){} // RVA: 0x5F0F4C0
        public void Echo(){} // RVA: 0x5F0F600
        public void EchoFlush(){} // RVA: 0x5F0F7D0
        public void Read(){} // RVA: 0x5F0F820
        public void ReadKey(){} // RVA: 0x5F0FBF0
        public void ReadLine(){} // RVA: 0x5F0FCB0
        public void ReadToEnd(){} // RVA: 0x5F0FCC0
        public void ReadUntilConditionInternal(){} // RVA: 0x5F0FCD0
        public void SetCursorPosition(){} // RVA: 0x5F10000
        public void CreateKeyMap(){} // RVA: 0x5F10390
        public void InitKeys(){} // RVA: 0x5F11F00
        public void AddStringMapping(){} // RVA: 0x5F12200
        public void .cctor(){} // RVA: 0x5F12250
    }

    public class TermInfoReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F147B0 | overloaded x2
        public void DetermineVersion(){} // RVA: 0x5F14890
        public void ReadHeader(){} // RVA: 0x5F14950
        public void ReadNames(){} // RVA: 0x5F14BD0
        public void Get(){} // RVA: 0x5F14D40 | overloaded x2
        public void GetStringBytes(){} // RVA: 0x5F15130 | overloaded x2
        public void GetInt16(){} // RVA: 0x5F15040
        public void GetString(){} // RVA: 0x5F150A0
    }

    public class ThreadStaticAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x62BDAB0
        public void CreateArgumentNullException(){} // RVA: 0x62BDAE0
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x62BDBA0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x62BDBD0
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x62BDC50
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x62BDC80
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x62BDD70
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x62BDDA0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x62BDE80
        public void CreateIndexOutOfRangeException(){} // RVA: 0x62BDEB0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x62BDFE0 | overloaded x2
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x62BE010 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x62BE0D0
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x62BE100
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x62BE230
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x62BE260
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x62BE310
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x62BE340
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x62BE420
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x62BE450
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x62BE4F0
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x62BE520
        public void TryFormatThrowFormatException(){} // RVA: 0x62BE5B0
        public void TryParseThrowFormatException(){} // RVA: 0xE230
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x62BE5D0
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x62BE600
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x5EC6300
        public void CreateArgumentNullException(){} // RVA: 0x5EC6330
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x5EC63F0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x5EC6420
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x5EC64A0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x5EC64D0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x5EC6540
        public void CreateIndexOutOfRangeException(){} // RVA: 0x5EC6570
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x5EC6FF0 | overloaded x3
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x5EC66D0 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x5EC6790
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x5EC67C0
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x5EC6890
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x5EC68C0
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x5EC6950
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x5EC6980
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x5EC69F0
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x5EC6A20
        public void ThrowArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x5EC6AC0
        public void CreateArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x5EC6AF0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x5EC6B90
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x5EC6BC0
        public void ThrowNotSupportedException(){} // RVA: 0x5EC71A0 | overloaded x2
        public void CreateThrowNotSupportedException(){} // RVA: 0x5EC6C60
        public void TryFormatThrowFormatException(){} // RVA: 0x5EC6CE0
        public void TryParseThrowFormatException(){} // RVA: 0xE230
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x5EC6D00
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x5EC6D30
        public void ThrowWrongKeyTypeArgumentException(){} // RVA: 0x5EC6D50
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x5EC6E30
        public void ThrowArgumentException(){} // RVA: 0x5EC6F70 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x5EC70E0
        public void ThrowSerializationException(){} // RVA: 0x5EC7140
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x5EC7200
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x5EC7250
        public void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted(){} // RVA: 0x5EC72A0
        public void ThrowInvalidOperationException_InvalidOperation_EnumEnded(){} // RVA: 0x5EC72F0
        public void ThrowInvalidOperationException_InvalidOperation_NoValue(){} // RVA: 0x5EC7340
        public void GetArgumentOutOfRangeException(){} // RVA: 0x5EC7DD0 | overloaded x2
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x5EC7410
        public void ThrowIndexArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x5EC7450
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x5EC7490
        public void GetAddingDuplicateWithKeyArgumentException(){} // RVA: 0x5EC74E0
        public void ThrowAddingDuplicateWithKeyArgumentException(){} // RVA: 0x5EC7570
        public void GetKeyNotFoundException(){} // RVA: 0x5EC75A0
        public void ThrowKeyNotFoundException(){} // RVA: 0x5EC7620
        public void ThrowInvalidTypeWithPointersNotSupported(){} // RVA: 0x5EC7630
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x5EC76A0
        public void GetInvalidOperationException(){} // RVA: 0x5EC76E0
        public void ThrowArraySegmentCtorValidationFailedExceptions(){} // RVA: 0x5EC7740
        public void GetArraySegmentCtorValidationFailedException(){} // RVA: 0x5EC7770
        public void GetArgumentException(){} // RVA: 0x5EC78F0
        public void GetArgumentNullException(){} // RVA: 0x5EC7990
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x2A490
        public void GetArgumentName(){} // RVA: 0x5EC7A30
        public void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index(){} // RVA: 0x5EC7E90
        public void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count(){} // RVA: 0x5EC7ED0
        public void GetResourceName(){} // RVA: 0x5EC7F10
        public void ThrowValueArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x5EC8590
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x5BA3E70
        public void Throw(){} // RVA: 0x5BA3E90
        public void IfNullOrWhitespace(){} // RVA: 0x5BA3EE0
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x5BAE550
        public void Throw(){} // RVA: 0x5BAE570
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x5BB5BD0
        public void Throw(){} // RVA: 0x5BB5BF0
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x5B88D20
        public void Throw(){} // RVA: 0x5B88D40
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x6369160
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x6369190
        public void GetArgumentNullException(){} // RVA: 0x63691C0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x6369260
        public void GetArgumentName(){} // RVA: 0x6369300
    }

    public class TimeProvider
    {
        public System.TimeProvider <System>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void GetUtcNow(){} // RVA: 0x5B88930
        public void get_LocalTimeZone(){} // RVA: 0x5B889E0
        public void .cctor(){} // RVA: 0x5B88A30
    }

    public class TimeSpan
    {
        public long TicksPerMillisecond;
        public double MillisecondsPerTick;
        public long TicksPerSecond;
        public double SecondsPerTick;
        public long TicksPerMinute;
        public double MinutesPerTick;
        public long TicksPerHour;
        public double HoursPerTick;
        public long TicksPerDay;
        public double DaysPerTick;
        public int MillisPerSecond;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EB77D0 | overloaded x4
        public void get_Ticks(){} // RVA: 0x1AD4690
        public void get_Days(){} // RVA: 0x5EB7890
        public void get_Hours(){} // RVA: 0x5EB78B0
        public void get_Milliseconds(){} // RVA: 0x5EB78F0
        public void get_Minutes(){} // RVA: 0x5EB7940
        public void get_Seconds(){} // RVA: 0x5EB7990
        public void get_TotalDays(){} // RVA: 0x5EB79E0
        public void get_TotalHours(){} // RVA: 0x5EB7A00
        public void get_TotalMilliseconds(){} // RVA: 0x5EB7A20
        public void get_TotalMinutes(){} // RVA: 0x5EB7A50
        public void get_TotalSeconds(){} // RVA: 0x5EB7A70
        public void Add(){} // RVA: 0x5EB7A90
        public void Compare(){} // RVA: 0x5EB7B10
        public void CompareTo(){} // RVA: 0x5EB7C10 | overloaded x2
        public void FromDays(){} // RVA: 0x5EB7C30
        public void Duration(){} // RVA: 0x5EB7C90
        public void Equals(){} // RVA: 0x2878D00 | overloaded x3
        public void GetHashCode(){} // RVA: 0x5E9A080
        public void FromHours(){} // RVA: 0x5EB7DE0
        public void Interval(){} // RVA: 0x5EB7E40
        public void FromMilliseconds(){} // RVA: 0x5EB7F50
        public void FromMinutes(){} // RVA: 0x5EB7FB0
        public void Negate(){} // RVA: 0x5EB8010
        public void FromSeconds(){} // RVA: 0x5EB80C0
        public void Subtract(){} // RVA: 0x5EB8120
        public void FromTicks(){} // RVA: 0x1A3F520
        public void TimeToTicks(){} // RVA: 0x5EB81A0
        public void ValidateStyles(){} // RVA: 0x5EB8240
        public void Parse(){} // RVA: 0x5EB8340 | overloaded x2
        public void ParseExact(){} // RVA: 0x5EB8790 | overloaded x4
        public void TryParse(){} // RVA: 0x5EB89C0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x5EB8E60 | overloaded x4
        public void ToString(){} // RVA: 0x5EB90B0 | overloaded x3
        public void TryFormat(){} // RVA: 0x5EB9130
        public void op_UnaryNegation(){} // RVA: 0x5EB9270
        public void op_Subtraction(){} // RVA: 0x5EB9320
        public void op_UnaryPlus(){} // RVA: 0x1A3F520
        public void op_Addition(){} // RVA: 0x5EB93E0
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void op_LessThan(){} // RVA: 0x5EB94B0
        public void op_LessThanOrEqual(){} // RVA: 0x5EB94C0
        public void op_GreaterThan(){} // RVA: 0x5EB94D0
        public void op_GreaterThanOrEqual(){} // RVA: 0x5EB94E0
        public void .cctor(){} // RVA: 0x5EB94F0
    }

    public class TimeZone
    {
        public System.TimeZone currentTimeZone;
        public object s_InternalSyncObject; // 0x8

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x5EB9570
        public void .ctor(){} // RVA: 0x2DD310
        public void get_CurrentTimeZone(){} // RVA: 0x5EB9640
        public void GetUtcOffset(){}
        public void GetDaylightChanges(){} // RVA: 0x1BCC0
        public void CalculateUtcOffset(){} // RVA: 0x5EB9970
    }

    public class TimeZoneInfo
    {
        public string TimeZonesRegistryHive;
        public string DisplayValue;
        public string DaylightValue;
        public string StandardValue;
        public string MuiDisplayValue;
        public string MuiDaylightValue;
        public string MuiStandardValue;
        public string TimeZoneInfoValue;
        public string FirstEntryValue;

        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x5D5A010
        public void PopulateAllSystemTimeZones(){} // RVA: 0x5D5A0B0
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x5D5A140
        public void .ctor(){} // RVA: 0x5D6B400 | overloaded x4
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x5D5A8E0
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x5D5EC70 | overloaded x2
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x5D5AD40
        public void GetLocalTimeZone(){} // RVA: 0x5D5AF10
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x5D5B290
        public void FindSystemTimeZoneById(){} // RVA: 0x5D5B3C0
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x5D5B8C0
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x5D5F2A0 | overloaded x2
        public void TryCreateAdjustmentRules(){} // RVA: 0x5D5BD00
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x5D5C950
        public void TryCompareStandardDate(){} // RVA: 0x5D5CA80
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x5D5CB00
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x5D5D0C0
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x5D5D440
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x5D5D840
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x5D6A420 | overloaded x2
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x5D5E000
        public void get_HaveRegistry(){} // RVA: 0x5D5E540
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x5D5E5C0
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x5D5E760
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x5D5E8F0
        public void GetTimeZoneInformationForYear(){} // RVA: 0x5D5EAB0
        public void TryCreateTimeZone(){} // RVA: 0x5D60140
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x5D60BC0
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x5D60F30
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x5D61190
        public void get_Id(){} // RVA: 0x2F8380
        public void get_DisplayName(){} // RVA: 0x5D619A0
        public void get_StandardName(){} // RVA: 0x5D619F0
        public void get_DaylightName(){} // RVA: 0x5D61A40
        public void get_BaseUtcOffset(){} // RVA: 0x6374D0
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x4A6500
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x5D61EC0 | overloaded x2
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x5D62390
        public void GetPreviousAdjustmentRule(){} // RVA: 0x5D62410
        public void GetUtcOffset(){} // RVA: 0x5D6ADD0 | overloaded x6
        public void GetLocalUtcOffset(){} // RVA: 0x5D62650
        public void IsAmbiguousTime(){} // RVA: 0x5D62B50 | overloaded x3
        public void IsDaylightSavingTime(){} // RVA: 0x5D630A0 | overloaded x4
        public void IsInvalidTime(){} // RVA: 0x5D63380
        public void ClearCachedData(){} // RVA: 0x5D63630
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x5D63800 | overloaded x3
        public void ConvertTime(){} // RVA: 0x5D64220 | overloaded x5
        public void ConvertTimeFromUtc(){} // RVA: 0x5D64850
        public void ConvertTimeToUtc(){} // RVA: 0x5D64B70 | overloaded x3
        public void Equals(){} // RVA: 0x5D64CF0 | overloaded x2
        public void FromSerializedString(){} // RVA: 0x5D64D50
        public void GetHashCode(){} // RVA: 0x5D64E30
        public void GetSystemTimeZones(){} // RVA: 0x5D64EE0
        public void HasSameRules(){} // RVA: 0x5D65410
        public void get_Local(){} // RVA: 0x5D65700
        public void ToSerializedString(){} // RVA: 0x5D65780
        public void ToString(){} // RVA: 0x5D619A0
        public void get_Utc(){} // RVA: 0x5D65790
        public void CreateCustomTimeZone(){} // RVA: 0x5D65B90 | overloaded x3
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5D65CC0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5D65E80
        public void GetAdjustmentRuleForTime(){} // RVA: 0x5D666B0 | overloaded x2
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x5D66930
        public void ConvertToUtc(){} // RVA: 0x5D66B80
        public void ConvertFromUtc(){} // RVA: 0x5D66BA0
        public void ConvertToFromUtc(){} // RVA: 0x5D66BC0
        public void ConvertUtcToTimeZone(){} // RVA: 0x5D66E80
        public void GetDaylightTime(){} // RVA: 0x5D67270
        public void GetIsDaylightSavings(){} // RVA: 0x5D673E0
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x5D679E0
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x5D67AC0
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x5D67B50
        public void CheckIsDst(){} // RVA: 0x5D68640
        public void GetIsAmbiguousTime(){} // RVA: 0x5D68970
        public void GetIsInvalidTime(){} // RVA: 0x5D68D30
        public void GetUtcOffsetFromUtc(){} // RVA: 0x5D69470 | overloaded x3
        public void TransitionTimeToDateTime(){} // RVA: 0x5D697E0
        public void TryGetTimeZone(){} // RVA: 0x5D6A120
        public void ValidateTimeZoneInfo(){} // RVA: 0x5D6A8F0
        public void UtcOffsetOutOfRange(){} // RVA: 0x5D6ACF0
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x5D6AEB0
        public void .cctor(){} // RVA: 0x5D6AFD0
    }

    public class TimeZoneNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EB9D90 | overloaded x4
    }

    public class TimeoutException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class Tuple
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0 | overloaded x3
        public void CombineHashCodes(){} // RVA: 0x5EB9E90 | overloaded x3
    }

    public class Tuple`2
    {
        public U m_Item1;
        public T m_Item2;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x283FA0
        public void get_Item2(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x11120
        public void System.IComparable.CompareTo(){} // RVA: 0x12590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x17680
        public void GetHashCode(){} // RVA: 0xD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x12590
        public void ToString(){} // RVA: 0xCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0xCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xD840
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.InventoryEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.TextureEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public VRC.DataModel.Challenges.ChallengeEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.EconomyEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.UpdateEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.ContentEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.QueueEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public Transmtn.InstanceEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2
    {
        public object m_Item1; // 0x10
        public Transmtn.GroupEvent m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2
    {
        public System.Threading.Tasks.UnwrapPromise`1<System.Threading.Tasks.VoidTaskResult> m_Item1; // 0x10
        public System.Threading.Tasks.Task m_Item2; // 0x18
    }

    public class Tuple`2
    {
        public System.Threading.Tasks.UnwrapPromise`1<ÌÎÌÌÏÍÎÎÌÎÌÏÏÍÏÍÏÎÎÎÎÎÎ> m_Item1; // 0x10
        public System.Threading.Tasks.Task m_Item2; // 0x18
    }

    public class Tuple`2 : 
    {
        public object m_Item1; // 0x10
        public T m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0xCD60
        public void get_Item2(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x288F850
        public void Equals(){} // RVA: 0x4439E80
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439F00
        public void System.IComparable.CompareTo(){} // RVA: 0x443A200
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x443A280
        public void GetHashCode(){} // RVA: 0x443A610
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x443A680
        public void ToString(){} // RVA: 0x443A840
        public void System.ITupleInternal.ToString(){} // RVA: 0x443A910
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2 : 
    {
        public string m_Item1; // 0x10
        public System.Type m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2
    {
        public string m_Item1; // 0x10
        public object m_Item2; // 0x18

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x2F8380
        public void get_Item2(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x4439810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4439890
        public void System.IComparable.CompareTo(){} // RVA: 0x4439990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4439A10
        public void GetHashCode(){} // RVA: 0x4439B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4439C00
        public void ToString(){} // RVA: 0x4439C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x4439D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`2
    {
        public System.Guid m_Item1; // 0x10
        public string m_Item2; // 0x20

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x196ABE0
        public void get_Item2(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x4437830
        public void Equals(){} // RVA: 0x4437890
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4437910
        public void System.IComparable.CompareTo(){} // RVA: 0x4437A60
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4437AE0
        public void GetHashCode(){} // RVA: 0x4437CC0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4437D30
        public void ToString(){} // RVA: 0x4437DE0
        public void System.ITupleInternal.ToString(){} // RVA: 0x4437EB0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x3E2CB0
    }

    public class Tuple`3
    {
        public U m_Item1;
        public V m_Item2;
        public T m_Item3;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x283FA0
        public void get_Item2(){} // RVA: 0x283FA0
        public void get_Item3(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x11120
        public void System.IComparable.CompareTo(){} // RVA: 0x12590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x17680
        public void GetHashCode(){} // RVA: 0xD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x12590
        public void ToString(){} // RVA: 0xCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0xCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xD840
    }

    public class Tuple`4
    {
        public U m_Item1;
        public V m_Item2;
        public W m_Item3;
        public T m_Item4;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x283FA0
        public void get_Item2(){} // RVA: 0x283FA0
        public void get_Item3(){} // RVA: 0x283FA0
        public void get_Item4(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x11120
        public void System.IComparable.CompareTo(){} // RVA: 0x12590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x17680
        public void GetHashCode(){} // RVA: 0xD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x12590
        public void ToString(){} // RVA: 0xCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0xCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xD840
    }

    public class Type
    {
        public System.Reflection.Binder s_defaultBinder;
        public char Delimiter; // 0x8
        public System.Type[] EmptyTypes; // 0x10
        public object Missing; // 0x18
        public System.Reflection.MemberFilter FilterAttribute; // 0x20
        public System.Reflection.MemberFilter FilterName; // 0x28
        public System.Reflection.MemberFilter FilterNameIgnoreCase; // 0x30
        public 0x657F3700 DefaultLookup;
        public System.RuntimeTypeHandle _impl; // 0x10
        public string DefaultTypeNameWhenMissingMetadata;

        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x5EB9EB0
        public void GetEnumName(){} // RVA: 0x5EBA4F0
        public void GetEnumNames(){} // RVA: 0x5EBA8E0
        public void GetEnumRawConstantValues(){} // RVA: 0x5EBA990
        public void GetEnumData(){} // RVA: 0x5EBA9C0
        public void BinarySearch(){} // RVA: 0x5EBAE70
        public void IsIntegerType(){} // RVA: 0x5EBB030
        public void get_IsSerializable(){} // RVA: 0x5EBB340
        public void get_ContainsGenericParameters(){} // RVA: 0x5EBB540
        public void GetRootElementType(){} // RVA: 0x5EBB6A0
        public void get_IsVisible(){} // RVA: 0x5EBB700
        public void IsSubclassOf(){} // RVA: 0x5EBB900
        public void IsAssignableFrom(){} // RVA: 0x5EBB9C0
        public void ImplementInterface(){} // RVA: 0x5EBBBA0
        public void FilterAttributeImpl(){} // RVA: 0x5EBBD00
        public void FilterNameImpl(){} // RVA: 0x5EBC090
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x5EBC340
        public void .ctor(){} // RVA: 0x2DD310
        public void get_MemberType(){} // RVA: 0x210E300
        public void GetType(){} // RVA: 0x5EBF0D0 | overloaded x5
        public void get_Namespace(){} // RVA: 0xCD60
        public void get_AssemblyQualifiedName(){} // RVA: 0xCD60
        public void get_FullName(){} // RVA: 0xCD60
        public void get_Assembly(){} // RVA: 0xCD60
        public void get_Module(){} // RVA: 0xCD60
        public void get_IsNested(){} // RVA: 0x5EBC750
        public void get_DeclaringType(){} // RVA: 0x519240
        public void get_DeclaringMethod(){} // RVA: 0x519240
        public void get_ReflectedType(){} // RVA: 0x519240
        public void get_UnderlyingSystemType(){} // RVA: 0xCD60
        public void get_IsArray(){} // RVA: 0x5EBC7C0
        public void IsArrayImpl(){} // RVA: 0xDBE0
        public void get_IsByRef(){} // RVA: 0x5EBC7E0
        public void IsByRefImpl(){} // RVA: 0xDBE0
        public void get_IsPointer(){} // RVA: 0x5EBC800
        public void IsPointerImpl(){} // RVA: 0xDBE0
        public void get_IsConstructedGenericType(){} // RVA: 0x5EBC820
        public void get_IsGenericParameter(){} // RVA: 0x2DD320
        public void get_IsGenericMethodParameter(){} // RVA: 0x5EBC850
        public void get_IsGenericType(){} // RVA: 0x2DD320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x2DD320
        public void get_IsSZArray(){} // RVA: 0x5EBC8D0
        public void get_IsVariableBoundArray(){} // RVA: 0x5EBC900
        public void get_HasElementType(){} // RVA: 0x5EBC950
        public void HasElementTypeImpl(){} // RVA: 0xDBE0
        public void GetElementType(){} // RVA: 0xCD60
        public void GetArrayRank(){} // RVA: 0x5EBC970
        public void GetGenericTypeDefinition(){} // RVA: 0x5EBC9C0
        public void get_GenericTypeArguments(){} // RVA: 0x5EBCA10
        public void GetGenericArguments(){} // RVA: 0x5EBCAA0
        public void get_GenericParameterPosition(){} // RVA: 0x5EBCAF0
        public void get_GenericParameterAttributes(){} // RVA: 0x5EBCB40
        public void GetGenericParameterConstraints(){} // RVA: 0x5EBCB80
        public void get_Attributes(){} // RVA: 0x5EBCC20
        public void GetAttributeFlagsImpl(){} // RVA: 0xD840
        public void get_IsAbstract(){} // RVA: 0x5EBCC40
        public void get_IsImport(){} // RVA: 0x5EBCC70
        public void get_IsSealed(){} // RVA: 0x5EBCCA0
        public void get_IsSpecialName(){} // RVA: 0x5EBCCD0
        public void get_IsClass(){} // RVA: 0x5EBCD00
        public void get_IsNestedAssembly(){} // RVA: 0x5EBCD50
        public void get_IsNestedFamANDAssem(){} // RVA: 0x5EBCD80
        public void get_IsNestedFamily(){} // RVA: 0x5EBCDB0
        public void get_IsNestedFamORAssem(){} // RVA: 0x5EBCDE0
        public void get_IsNestedPrivate(){} // RVA: 0x5EBCE10
        public void get_IsNestedPublic(){} // RVA: 0x5EBCE40
        public void get_IsNotPublic(){} // RVA: 0x5EBCE70
        public void get_IsPublic(){} // RVA: 0x5EBCEA0
        public void get_IsAutoLayout(){} // RVA: 0x5EBCED0
        public void get_IsExplicitLayout(){} // RVA: 0x5EBCF00
        public void get_IsLayoutSequential(){} // RVA: 0x5EBCF30
        public void get_IsAnsiClass(){} // RVA: 0x5EBCF60
        public void get_IsAutoClass(){} // RVA: 0x5EBCF90
        public void get_IsUnicodeClass(){} // RVA: 0x5EBCFC0
        public void get_IsCOMObject(){} // RVA: 0x5EBCFF0
        public void IsCOMObjectImpl(){} // RVA: 0xDBE0
        public void get_IsContextful(){} // RVA: 0x5EBD010
        public void IsContextfulImpl(){} // RVA: 0x5EBD030
        public void get_IsCollectible(){} // RVA: 0x3C2850
        public void get_IsEnum(){} // RVA: 0x5EBD110
        public void get_IsMarshalByRef(){} // RVA: 0x5EBD1F0
        public void IsMarshalByRefImpl(){} // RVA: 0x5EBD210
        public void get_IsPrimitive(){} // RVA: 0x5EBD2F0
        public void IsPrimitiveImpl(){} // RVA: 0xDBE0
        public void get_IsValueType(){} // RVA: 0x5EBD310
        public void IsValueTypeImpl(){} // RVA: 0x5EBD330
        public void get_IsSignatureType(){} // RVA: 0x2DD320
        public void get_IsSecurityCritical(){} // RVA: 0x5EBD410
        public void get_IsSecuritySafeCritical(){} // RVA: 0x5EBD440
        public void get_IsSecurityTransparent(){} // RVA: 0x5EBD470
        public void GetConstructor(){} // RVA: 0x5EBD500 | overloaded x3
        public void GetConstructorImpl(){}
        public void GetConstructors(){} // RVA: 0x1BCC0 | overloaded x2
        public void GetEvent(){} // RVA: 0x1DD80 | overloaded x2
        public void GetEvents(){} // RVA: 0x1BCC0
        public void GetField(){} // RVA: 0x1DD80 | overloaded x2
        public void GetFields(){} // RVA: 0x1BCC0 | overloaded x2
        public void GetMember(){} // RVA: 0x5EBD750 | overloaded x3
        public void GetMembers(){} // RVA: 0x1BCC0
        public void GetMethod(){} // RVA: 0x5EBD980 | overloaded x6
        public void GetMethodImpl(){}
        public void GetMethods(){} // RVA: 0x1BCC0 | overloaded x2
        public void GetNestedType(){} // RVA: 0x1DD80 | overloaded x2
        public void GetProperty(){} // RVA: 0x5EBDFD0 | overloaded x6
        public void GetPropertyImpl(){}
        public void GetProperties(){} // RVA: 0x1BCC0 | overloaded x2
        public void get_TypeHandle(){} // RVA: 0x5EBE0E0
        public void GetTypeHandle(){} // RVA: 0x5EBE120
        public void GetTypeArray(){} // RVA: 0x5EBE1B0
        public void GetTypeCode(){} // RVA: 0x5EBE330
        public void GetTypeCodeImpl(){} // RVA: 0x5EBE3A0
        public void get_GUID(){} // RVA: 0xC770
        public void get_BaseType(){} // RVA: 0xCD60
        public void InvokeMember(){}
        public void GetInterface(){} // RVA: 0x1D640
        public void GetInterfaces(){} // RVA: 0xCD60
        public void IsInstanceOfType(){} // RVA: 0x5EBE4F0
        public void IsEquivalentTo(){} // RVA: 0x5EBE540
        public void GetEnumUnderlyingType(){} // RVA: 0x5EBE5A0
        public void GetEnumValues(){} // RVA: 0x5EBE6F0
        public void MakeArrayType(){} // RVA: 0x5EBE7E0 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x5EBE820
        public void MakeGenericType(){} // RVA: 0x5EBE860
        public void MakePointerType(){} // RVA: 0x5EBE8B0
        public void MakeGenericSignatureType(){} // RVA: 0x5EBE8F0
        public void ToString(){} // RVA: 0x5EBE960
        public void Equals(){} // RVA: 0x5EBEAC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5EBEA60
        public void get_DefaultBinder(){} // RVA: 0x5EBEB60
        public void GetTypeFromHandle(){} // RVA: 0x5EBEC90
        public void internal_from_handle(){} // RVA: 0x5EBED00
        public void get_IsSzArray(){} // RVA: 0x2DD320
        public void FormatTypeName(){} // RVA: 0x5EBED40 | overloaded x2
        public void get_IsInterface(){} // RVA: 0x5EBED80
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x5EB94A0
        public void get_FullNameOrDefault(){} // RVA: 0x5EBF210
        public void IsRuntimeImplemented(){} // RVA: 0x5EBF2A0
        public void InternalGetNameIfAvailable(){} // RVA: 0x950560
        public void get_InternalNameIfAvailable(){} // RVA: 0x5EBF340
        public void get_NameOrDefault(){} // RVA: 0x5EBF370
        public void .cctor(){} // RVA: 0x5EBF3E0
    }

    public class TypeAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E7BF40 | overloaded x2
    }

    public class TypeIdentifier
    {
        // ── Methods ──
        public void get_InternalName(){} // RVA: 0xCD60
    }

    public class TypeIdentifiers
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x5F15480
    }

    public class TypeInitializationException
    {
        public string _typeName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EBF910 | overloaded x4
        public void GetObjectData(){} // RVA: 0x5EBFA20
        public void get_TypeName(){} // RVA: 0x5EBFC20
    }

    public class TypeLoadException
    {
        public string ClassName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EF90D0 | overloaded x5
        public void get_Message(){} // RVA: 0x5EF8AD0
        public void SetMessageField(){} // RVA: 0x5EF8AF0
        public void GetObjectData(){} // RVA: 0x5EF9360
    }

    public class TypeName
    {
        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0xCD60
    }

    public class TypeNameParser
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x5F00080
    }

    public class TypeNames
    {
    }

    public class TypeSpec
    {
        public System.TypeIdentifier name; // 0x10
        public string assembly_name; // 0x18

        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x51555E0
        public void GetDisplayFullName(){} // RVA: 0x5F15B40
        public void GetModifierString(){} // RVA: 0x5F16110
        public void get_DisplayFullName(){} // RVA: 0x5F16390
        public void Parse(){} // RVA: 0x5F174D0 | overloaded x2
        public void UnescapeInternalName(){} // RVA: 0x5F16500
        public void Resolve(){} // RVA: 0x5F16600
        public void AddName(){} // RVA: 0x5F17060
        public void AddModifier(){} // RVA: 0x5F17230
        public void SkipSpace(){} // RVA: 0x5F17370
        public void BoundCheck(){} // RVA: 0x5F17430
        public void ParsedTypeIdentifier(){} // RVA: 0x5F174C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TypedReference
    {
        public System.RuntimeTypeHandle type; // 0x10

        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x5EF81F0
        public void InternalMakeTypedReference(){} // RVA: 0x5EF8830
        public void GetHashCode(){} // RVA: 0x5EF8900
        public void Equals(){} // RVA: 0x5EF8990
        public void get_IsNull(){} // RVA: 0x5EF89F0
        public void SetTypedReference(){} // RVA: 0x5EF8A10
    }

}