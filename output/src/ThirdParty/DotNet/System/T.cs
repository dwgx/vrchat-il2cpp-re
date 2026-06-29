// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 55
// Methods: 835

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver : Object
    {
        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x6984640
        public void SearchTerminfo(){} // RVA: 0x69849B0
        public void WriteConsole(){} // RVA: 0x6984B50
        public void .ctor(){} // RVA: 0x6984B80
        public void get_Initialized(){} // RVA: 0x2443C20
        public void Init(){} // RVA: 0x6985400
        public void IncrementX(){} // RVA: 0x6986060
        public void WriteSpecialKey(){} // RVA: 0x69862F0
        public void IsSpecialKey(){} // RVA: 0x6986460
        public void GetCursorPosition(){} // RVA: 0x69864B0
        public void CheckWindowDimensions(){} // RVA: 0x6986550
        public void get_WindowHeight(){} // RVA: 0x69866B0
        public void get_WindowWidth(){} // RVA: 0x69866E0
        public void AddToBuffer(){} // RVA: 0x6986710
        public void AdjustBuffer(){} // RVA: 0x69868D0
        public void CreateKeyInfoFromInt(){} // RVA: 0x69868F0
        public void GetKeyFromBuffer(){} // RVA: 0x6986A40
        public void ReadKeyInternal(){} // RVA: 0x6986DA0
        public void InputPending(){} // RVA: 0x6986F50
        public void QueueEcho(){} // RVA: 0x6986F90
        public void Echo(){} // RVA: 0x69870D0
        public void EchoFlush(){} // RVA: 0x69872A0
        public void Read(){} // RVA: 0x69872F0
        public void ReadKey(){} // RVA: 0x69876B0
        public void ReadLine(){} // RVA: 0x6987770
        public void ReadToEnd(){} // RVA: 0x6987780
        public void ReadUntilConditionInternal(){} // RVA: 0x6987790
        public void SetCursorPosition(){} // RVA: 0x6987AB0
        public void CreateKeyMap(){} // RVA: 0x6987E40
        public void InitKeys(){} // RVA: 0x69899B0
        public void AddStringMapping(){} // RVA: 0x6989CC0
        public void .cctor(){} // RVA: 0x6989D10
    }

    public class TermInfoReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x698C1C0
        public void DetermineVersion(){} // RVA: 0x698C2A0
        public void ReadHeader(){} // RVA: 0x698C360
        public void ReadNames(){} // RVA: 0x698C5D0
        public void Get(){} // RVA: 0x698C740
        public void GetStringBytes(){} // RVA: 0x698CB50
        public void GetInt16(){} // RVA: 0x698CA60
        public void GetString(){} // RVA: 0x698CAC0
    }

    public class ThreadStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x2A38B30
        public void ThrowArgumentNullException(){} // RVA: 0x693EB10
        public void CreateArgumentNullException(){} // RVA: 0x693EB40
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x693EC00
        public void CreateArrayTypeMismatchException(){} // RVA: 0x693EC30
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x693ECB0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x693ECE0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x693ED50
        public void CreateIndexOutOfRangeException(){} // RVA: 0x693ED80
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x693F8C0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x693EEE0
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x693EFA0
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x693EFD0
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x693F090
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x693F0C0
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x693F150
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x693F180
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x693F1F0
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x693F220
        public void ThrowArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x693F2C0
        public void CreateArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x693F2F0
        public void ThrowObjectDisposedException_ArrayMemoryPoolBuffer(){} // RVA: 0x693F390
        public void CreateObjectDisposedException_ArrayMemoryPoolBuffer(){} // RVA: 0x693F3C0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x693F460
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x693F490
        public void ThrowNotSupportedException(){} // RVA: 0x693FA70
        public void CreateThrowNotSupportedException(){} // RVA: 0x693F530
        public void TryFormatThrowFormatException(){} // RVA: 0x693F5B0
        public void TryParseThrowFormatException(){} // RVA: 0x87D880
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x693F5D0
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x693F600
        public void ThrowWrongKeyTypeArgumentException(){} // RVA: 0x693F620
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x693F700
        public void ThrowArgumentException(){} // RVA: 0x693F840
        public void ThrowInvalidOperationException(){} // RVA: 0x693F9B0
        public void ThrowSerializationException(){} // RVA: 0x693FA10
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x693FAD0
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x693FB20
        public void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted(){} // RVA: 0x693FB70
        public void ThrowInvalidOperationException_InvalidOperation_EnumEnded(){} // RVA: 0x693FBC0
        public void ThrowInvalidOperationException_InvalidOperation_NoValue(){} // RVA: 0x693FC10
        public void GetArgumentOutOfRangeException(){} // RVA: 0x6940680
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x693FCE0
        public void ThrowIndexArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x693FD20
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x693FD60
        public void GetAddingDuplicateWithKeyArgumentException(){} // RVA: 0x693FDB0
        public void ThrowAddingDuplicateWithKeyArgumentException(){} // RVA: 0x693FE40
        public void GetKeyNotFoundException(){} // RVA: 0x693FE70
        public void ThrowKeyNotFoundException(){} // RVA: 0x693FEF0
        public void ThrowInvalidTypeWithPointersNotSupported(){} // RVA: 0x693FF00
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x693FF70
        public void GetInvalidOperationException(){} // RVA: 0x693FFB0
        public void ThrowArraySegmentCtorValidationFailedExceptions(){} // RVA: 0x6940010
        public void GetArraySegmentCtorValidationFailedException(){} // RVA: 0x6940040
        public void GetArgumentException(){} // RVA: 0x69401C0
        public void GetArgumentNullException(){} // RVA: 0x6940260
        public void GetArgumentName(){} // RVA: 0x6940300
        public void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index(){} // RVA: 0x6940740
        public void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count(){} // RVA: 0x6940780
        public void GetResourceName(){} // RVA: 0x69407C0
        public void ThrowValueArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x6940E30
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x6D2ABC0
        public void CreateArgumentNullException(){} // RVA: 0x6D2ABF0
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x6D2ACB0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x6D2ACE0
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x6D2AD60
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x6D2AD90
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x6D2AE80
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x6D2AEB0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x6D2AF90
        public void CreateIndexOutOfRangeException(){} // RVA: 0x6D2AFC0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x6D2B0F0
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x6D2B120
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x6D2B1E0
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x6D2B210
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x6D2B330
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x6D2B360
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x6D2B410
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x6D2B440
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x6D2B520
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x6D2B550
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x6D2B5F0
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x6D2B620
        public void TryFormatThrowFormatException(){} // RVA: 0x6D2B6B0
        public void TryParseThrowFormatException(){} // RVA: 0x87D880
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x6D2B6D0
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x6D2B700
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x661CD70
        public void Throw(){} // RVA: 0x661CD90
        public void IfNullOrWhitespace(){} // RVA: 0x661CDE0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x66272E0
        public void Throw(){} // RVA: 0x6627300
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x662E810
        public void Throw(){} // RVA: 0x662E830
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x6602A30
        public void Throw(){} // RVA: 0x6602A50
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x6DD64E0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x6DD6510
        public void GetArgumentNullException(){} // RVA: 0x6DD6540
        public void GetArgumentOutOfRangeException(){} // RVA: 0x6DD65E0
        public void GetArgumentName(){} // RVA: 0x6DD6680
    }

    public class TimeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetUtcNow(){} // RVA: 0x6602640
        public void get_LocalTimeZone(){} // RVA: 0x66026F0
        public void .cctor(){} // RVA: 0x6602740
    }

    public class TimeSpan : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8BC240
        public void get_Ticks(){} // RVA: 0x77900
        public void get_Days(){} // RVA: 0x8BC250
        public void get_Hours(){} // RVA: 0x8BC270
        public void get_Milliseconds(){} // RVA: 0x8BC2B0
        public void get_Minutes(){} // RVA: 0x8BC300
        public void get_Seconds(){} // RVA: 0x8BC350
        public void get_TotalDays(){} // RVA: 0x8BC3A0
        public void get_TotalHours(){} // RVA: 0x8BC3C0
        public void get_TotalMilliseconds(){} // RVA: 0x8BC3E0
        public void get_TotalMinutes(){} // RVA: 0x8BC420
        public void get_TotalSeconds(){} // RVA: 0x8BC440
        public void Add(){} // RVA: 0x8BC460
        public void Compare(){} // RVA: 0x6930A70
        public void CompareTo(){} // RVA: 0x8BC480
        public void FromDays(){} // RVA: 0x6930B90
        public void Duration(){} // RVA: 0x8BC4A0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x8BA560
        public void FromHours(){} // RVA: 0x6930D40
        public void Interval(){} // RVA: 0x6930DA0
        public void FromMilliseconds(){} // RVA: 0x6930EB0
        public void FromMinutes(){} // RVA: 0x6930F10
        public void Negate(){} // RVA: 0x8BC540
        public void FromSeconds(){} // RVA: 0x6931020
        public void Subtract(){} // RVA: 0x8BC550
        public void FromTicks(){} // RVA: 0x2303260
        public void TimeToTicks(){} // RVA: 0x6931100
        public void ValidateStyles(){} // RVA: 0x69311A0
        public void Parse(){} // RVA: 0x69312A0
        public void ParseExact(){} // RVA: 0x69316F0
        public void TryParse(){} // RVA: 0x6931920
        public void TryParseExact(){} // RVA: 0x6931DC0
        public void ToString(){} // RVA: 0x8BC5D0
        public void TryFormat(){} // RVA: 0x8BC5E0
        public void op_UnaryNegation(){} // RVA: 0x69321D0
        public void op_Subtraction(){} // RVA: 0x6932280
        public void op_UnaryPlus(){} // RVA: 0x2303260
        public void op_Addition(){} // RVA: 0x6932340
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0xD12240
        public void op_LessThan(){} // RVA: 0x6932400
        public void op_LessThanOrEqual(){} // RVA: 0x6932410
        public void op_GreaterThan(){} // RVA: 0x6932420
        public void op_GreaterThanOrEqual(){} // RVA: 0x6932430
        public void .cctor(){} // RVA: 0x6932440
    }

    public class TimeSpan[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBC320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E749A0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TimeZone : Object
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x69324C0
        public void .ctor(){} // RVA: 0xB43310
        public void get_CurrentTimeZone(){} // RVA: 0x6932590
        public void GetUtcOffset(){} // RVA: 0x881D60
        public void GetDaylightChanges(){} // RVA: 0x87C160
        public void CalculateUtcOffset(){} // RVA: 0x6932890
    }

    public class TimeZoneInfo : Object
    {
        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x67D2130
        public void PopulateAllSystemTimeZones(){} // RVA: 0x67D21D0
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x67D2260
        public void .ctor(){} // RVA: 0x67E4000
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x67D2A10
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x67D6D70
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x67D2E70
        public void GetLocalTimeZone(){} // RVA: 0x67D3040
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x67D33D0
        public void FindSystemTimeZoneById(){} // RVA: 0x67D3500
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x67D39E0
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x67D73A0
        public void TryCreateAdjustmentRules(){} // RVA: 0x67D3E20
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x67D4A70
        public void TryCompareStandardDate(){} // RVA: 0x67D4BA0
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x67D4C20
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x67D51E0
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x67D5550
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x67D5950
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x67E3010
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x67D6100
        public void get_HaveRegistry(){} // RVA: 0x67D6640
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x67D66C0
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x67D6860
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x67D69F0
        public void GetTimeZoneInformationForYear(){} // RVA: 0x67D6BB0
        public void TryCreateTimeZone(){} // RVA: 0x67D8240
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x67D8CD0
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x67D9040
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x67D92A0
        public void get_Id(){} // RVA: 0xB5DBF0
        public void get_DisplayName(){} // RVA: 0x67D9AC0
        public void get_StandardName(){} // RVA: 0x67D9AE0
        public void get_DaylightName(){} // RVA: 0x67D9B00
        public void get_BaseUtcOffset(){} // RVA: 0xD33E60
        public void get_SupportsDaylightSavingTime(){} // RVA: 0xD16660
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x67D9F50
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x67DA420
        public void GetPreviousAdjustmentRule(){} // RVA: 0x67DA4A0
        public void GetUtcOffset(){} // RVA: 0x67E39D0
        public void GetLocalUtcOffset(){} // RVA: 0x67DA6F0
        public void IsAmbiguousTime(){} // RVA: 0x67DABF0
        public void IsDaylightSavingTime(){} // RVA: 0x67DB150
        public void IsInvalidTime(){} // RVA: 0x67DB430
        public void ClearCachedData(){} // RVA: 0x67DB6E0
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x67DB8B0
        public void ConvertTime(){} // RVA: 0x67DC2D0
        public void ConvertTimeFromUtc(){} // RVA: 0x67DC900
        public void ConvertTimeToUtc(){} // RVA: 0x67DCC20
        public void Equals(){} // RVA: 0x67DCDA0
        public void FromSerializedString(){} // RVA: 0x67DCE00
        public void GetHashCode(){} // RVA: 0x67DCEE0
        public void GetSystemTimeZones(){} // RVA: 0x67DCF90
        public void HasSameRules(){} // RVA: 0x67DD480
        public void get_Local(){} // RVA: 0x67DD780
        public void ToSerializedString(){} // RVA: 0x67DD800
        public void ToString(){} // RVA: 0x67D9AC0
        public void get_Utc(){} // RVA: 0x67DD810
        public void CreateCustomTimeZone(){} // RVA: 0x67DDC10
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x67DDD40
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x67DDF00
        public void GetAdjustmentRuleForTime(){} // RVA: 0x67DF290
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x67DF520
        public void ConvertToUtc(){} // RVA: 0x67DF770
        public void ConvertFromUtc(){} // RVA: 0x67DF790
        public void ConvertToFromUtc(){} // RVA: 0x67DF7B0
        public void ConvertUtcToTimeZone(){} // RVA: 0x67DFA70
        public void GetDaylightTime(){} // RVA: 0x67DFE60
        public void GetIsDaylightSavings(){} // RVA: 0x67DFFD0
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x67E05D0
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x67E06B0
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x67E0740
        public void CheckIsDst(){} // RVA: 0x67E1230
        public void GetIsAmbiguousTime(){} // RVA: 0x67E1560
        public void GetIsInvalidTime(){} // RVA: 0x67E1920
        public void GetUtcOffsetFromUtc(){} // RVA: 0x67E2060
        public void TransitionTimeToDateTime(){} // RVA: 0x67E23D0
        public void TryGetTimeZone(){} // RVA: 0x67E2D10
        public void ValidateTimeZoneInfo(){} // RVA: 0x67E34E0
        public void UtcOffsetOutOfRange(){} // RVA: 0x67E38F0
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x67E3AB0
        public void .cctor(){} // RVA: 0x67E3BD0
    }

    public class TimeZoneInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TimeZoneNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6932CB0
    }

    public class TimeoutException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class Tuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x2A3CF60
        public void CombineHashCodes(){} // RVA: 0x6932DB0
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xA94080
        public void get_Item2(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x87D3C0
        public void System.IComparable.CompareTo(){} // RVA: 0x87D050
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x881CA0
        public void GetHashCode(){} // RVA: 0x87C130
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x87D050
        public void ToString(){} // RVA: 0x87C0A0
        public void System.ITupleInternal.ToString(){} // RVA: 0x87C540
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x87C130
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x87C0A0
        public void get_Item2(){} // RVA: 0xAD0950
        public void .ctor(){} // RVA: 0x31D4160
        public void Equals(){} // RVA: 0x4F37770
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F377F0
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37AE0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37B60
        public void GetHashCode(){} // RVA: 0x4F37EE0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F37F50
        public void ToString(){} // RVA: 0x4F38100
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F381D0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xB5DBF0
        public void get_Item2(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x4F37100
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F37180
        public void System.IComparable.CompareTo(){} // RVA: 0x4F37280
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F37300
        public void GetHashCode(){} // RVA: 0x4F37480
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F374F0
        public void ToString(){} // RVA: 0x4F37580
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F37650
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F35120
        public void get_Item1(){} // RVA: 0x22343B0
        public void get_Item2(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0x4F35180
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x4F35200
        public void System.IComparable.CompareTo(){} // RVA: 0x4F35350
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x4F353D0
        public void GetHashCode(){} // RVA: 0x4F355B0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x4F35620
        public void ToString(){} // RVA: 0x4F356D0
        public void System.ITupleInternal.ToString(){} // RVA: 0x4F357A0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0xC50A80
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tuple`3 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xA94080
        public void get_Item2(){} // RVA: 0xA94080
        public void get_Item3(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x87D3C0
        public void System.IComparable.CompareTo(){} // RVA: 0x87D050
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x881CA0
        public void GetHashCode(){} // RVA: 0x87C130
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x87D050
        public void ToString(){} // RVA: 0x87C0A0
        public void System.ITupleInternal.ToString(){} // RVA: 0x87C540
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x87C130
    }

    public class Tuple`4 : Object
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0xA94080
        public void get_Item2(){} // RVA: 0xA94080
        public void get_Item3(){} // RVA: 0xA94080
        public void get_Item4(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x87D3C0
        public void System.IComparable.CompareTo(){} // RVA: 0x87D050
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x881CA0
        public void GetHashCode(){} // RVA: 0x87C130
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x87D050
        public void ToString(){} // RVA: 0x87C0A0
        public void System.ITupleInternal.ToString(){} // RVA: 0x87C540
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x87C130
    }

    public class Type : MemberInfo
    {
        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x6932DD0
        public void GetEnumName(){} // RVA: 0x6933410
        public void GetEnumNames(){} // RVA: 0x69337D0
        public void GetEnumRawConstantValues(){} // RVA: 0x6933880
        public void GetEnumData(){} // RVA: 0x69338B0
        public void BinarySearch(){} // RVA: 0x6933D90
        public void IsIntegerType(){} // RVA: 0x6933F40
        public void get_IsSerializable(){} // RVA: 0x69341D0
        public void get_ContainsGenericParameters(){} // RVA: 0x6934370
        public void GetRootElementType(){} // RVA: 0x69344E0
        public void get_IsVisible(){} // RVA: 0x6934540
        public void IsSubclassOf(){} // RVA: 0x6934710
        public void IsAssignableFrom(){} // RVA: 0x69347B0
        public void ImplementInterface(){} // RVA: 0x6934940
        public void FilterAttributeImpl(){} // RVA: 0x6934A60
        public void FilterNameImpl(){} // RVA: 0x6934DE0
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x6935070
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0x2AFBE90
        public void GetType(){} // RVA: 0x6937B40
        public void get_Namespace(){} // RVA: 0x87C0A0
        public void get_AssemblyQualifiedName(){} // RVA: 0x87C0A0
        public void get_FullName(){} // RVA: 0x87C0A0
        public void get_Assembly(){} // RVA: 0x87C0A0
        public void get_Module(){} // RVA: 0x87C0A0
        public void get_IsNested(){} // RVA: 0x6935450
        public void get_DeclaringType(){} // RVA: 0xDAC980
        public void get_DeclaringMethod(){} // RVA: 0xDAC980
        public void get_ReflectedType(){} // RVA: 0xDAC980
        public void get_UnderlyingSystemType(){} // RVA: 0x87C0A0
        public void get_IsArray(){} // RVA: 0x6935490
        public void IsArrayImpl(){} // RVA: 0x87D280
        public void get_IsByRef(){} // RVA: 0x69354B0
        public void IsByRefImpl(){} // RVA: 0x87D280
        public void get_IsPointer(){} // RVA: 0x69354D0
        public void IsPointerImpl(){} // RVA: 0x87D280
        public void get_IsConstructedGenericType(){} // RVA: 0x69354F0
        public void get_IsGenericParameter(){} // RVA: 0xB43320
        public void get_IsGenericMethodParameter(){} // RVA: 0x6935520
        public void get_IsGenericType(){} // RVA: 0xB43320
        public void get_IsGenericTypeDefinition(){} // RVA: 0xB43320
        public void get_IsSZArray(){} // RVA: 0x69355A0
        public void get_IsVariableBoundArray(){} // RVA: 0x69355D0
        public void get_HasElementType(){} // RVA: 0x6935620
        public void HasElementTypeImpl(){} // RVA: 0x87D280
        public void GetElementType(){} // RVA: 0x87C0A0
        public void GetArrayRank(){} // RVA: 0x6935640
        public void GetGenericTypeDefinition(){} // RVA: 0x6935690
        public void get_GenericTypeArguments(){} // RVA: 0x69356E0
        public void GetGenericArguments(){} // RVA: 0x6935770
        public void get_GenericParameterPosition(){} // RVA: 0x69357C0
        public void get_GenericParameterAttributes(){} // RVA: 0x6935810
        public void GetGenericParameterConstraints(){} // RVA: 0x6935850
        public void get_Attributes(){} // RVA: 0x69358F0
        public void GetAttributeFlagsImpl(){} // RVA: 0x87C130
        public void get_IsAbstract(){} // RVA: 0x6935910
        public void get_IsImport(){} // RVA: 0x6935940
        public void get_IsSealed(){} // RVA: 0x6935970
        public void get_IsSpecialName(){} // RVA: 0x69359A0
        public void get_IsClass(){} // RVA: 0x69359D0
        public void get_IsNestedAssembly(){} // RVA: 0x6935A20
        public void get_IsNestedFamANDAssem(){} // RVA: 0x6935A50
        public void get_IsNestedFamily(){} // RVA: 0x6935A80
        public void get_IsNestedFamORAssem(){} // RVA: 0x6935AB0
        public void get_IsNestedPrivate(){} // RVA: 0x6935AE0
        public void get_IsNestedPublic(){} // RVA: 0x6935B10
        public void get_IsNotPublic(){} // RVA: 0x6935B40
        public void get_IsPublic(){} // RVA: 0x6935B70
        public void get_IsAutoLayout(){} // RVA: 0x6935BA0
        public void get_IsExplicitLayout(){} // RVA: 0x6935BD0
        public void get_IsLayoutSequential(){} // RVA: 0x6935C00
        public void get_IsAnsiClass(){} // RVA: 0x6935C30
        public void get_IsAutoClass(){} // RVA: 0x6935C60
        public void get_IsUnicodeClass(){} // RVA: 0x6935C90
        public void get_IsCOMObject(){} // RVA: 0x6935CC0
        public void IsCOMObjectImpl(){} // RVA: 0x87D280
        public void get_IsContextful(){} // RVA: 0x6935CE0
        public void IsContextfulImpl(){} // RVA: 0x6935D00
        public void get_IsCollectible(){} // RVA: 0xC2E4C0
        public void get_IsEnum(){} // RVA: 0x6935DB0
        public void get_IsMarshalByRef(){} // RVA: 0x6935E40
        public void IsMarshalByRefImpl(){} // RVA: 0x6935E60
        public void get_IsPrimitive(){} // RVA: 0x6935F10
        public void IsPrimitiveImpl(){} // RVA: 0x87D280
        public void get_IsValueType(){} // RVA: 0x6935F30
        public void IsValueTypeImpl(){} // RVA: 0x6935F50
        public void get_IsSignatureType(){} // RVA: 0xB43320
        public void get_IsSecurityCritical(){} // RVA: 0x6935FE0
        public void get_IsSecuritySafeCritical(){} // RVA: 0x6936010
        public void get_IsSecurityTransparent(){} // RVA: 0x6936040
        public void GetConstructor(){} // RVA: 0x69360D0
        public void GetConstructorImpl(){} // RVA: 0x88C750
        public void GetConstructors(){} // RVA: 0x87C160
        public void GetEvent(){} // RVA: 0x88B6A0
        public void GetEvents(){} // RVA: 0x87C160
        public void GetField(){} // RVA: 0x88B6A0
        public void GetFields(){} // RVA: 0x87C160
        public void GetMember(){} // RVA: 0x6936300
        public void GetMembers(){} // RVA: 0x87C160
        public void GetMethod(){} // RVA: 0x6936530
        public void GetMethodImpl(){} // RVA: 0x88DAE0
        public void GetMethods(){} // RVA: 0x87C160
        public void GetNestedType(){} // RVA: 0x88B6A0
        public void GetProperty(){} // RVA: 0x6936B40
        public void GetPropertyImpl(){} // RVA: 0x88DCD0
        public void GetProperties(){} // RVA: 0x87C160
        public void get_TypeHandle(){} // RVA: 0x6936C50
        public void GetTypeHandle(){} // RVA: 0x6936C90
        public void GetTypeArray(){} // RVA: 0x6936D20
        public void GetTypeCode(){} // RVA: 0x6936EB0
        public void GetTypeCodeImpl(){} // RVA: 0x6936F00
        public void get_GUID(){} // RVA: 0x87BEB0
        public void get_BaseType(){} // RVA: 0x87C0A0
        public void InvokeMember(){} // RVA: 0x88DD40
        public void GetInterface(){} // RVA: 0x87D1A0
        public void GetInterfaces(){} // RVA: 0x87C0A0
        public void IsInstanceOfType(){} // RVA: 0x6937000
        public void IsEquivalentTo(){} // RVA: 0x6937050
        public void GetEnumUnderlyingType(){} // RVA: 0x6937090
        public void GetEnumValues(){} // RVA: 0x69371E0
        public void MakeArrayType(){} // RVA: 0x69372D0
        public void MakeByRefType(){} // RVA: 0x6937310
        public void MakeGenericType(){} // RVA: 0x6937350
        public void MakePointerType(){} // RVA: 0x69373A0
        public void MakeGenericSignatureType(){} // RVA: 0x69373E0
        public void ToString(){} // RVA: 0x6937450
        public void Equals(){} // RVA: 0x6937580
        public void GetHashCode(){} // RVA: 0x6937520
        public void get_DefaultBinder(){} // RVA: 0x6937600
        public void GetTypeFromHandle(){} // RVA: 0x6937720
        public void internal_from_handle(){} // RVA: 0x6937770
        public void get_IsSzArray(){} // RVA: 0xB43320
        public void FormatTypeName(){} // RVA: 0x69377B0
        public void get_IsInterface(){} // RVA: 0x69377F0
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0xD12240
        public void get_FullNameOrDefault(){} // RVA: 0x6937C80
        public void IsRuntimeImplemented(){} // RVA: 0x6937D10
        public void InternalGetNameIfAvailable(){} // RVA: 0x2538380
        public void get_InternalNameIfAvailable(){} // RVA: 0x6937DA0
        public void get_NameOrDefault(){} // RVA: 0x6937DD0
        public void .cctor(){} // RVA: 0x6937E40
    }

    public class TypeAccessException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68F5110
    }

    public class TypeIdentifier
    {
        // ── Methods ──
        public void get_InternalName(){} // RVA: 0x87C0A0
    }

    public class TypeIdentifiers : Object
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x698CEB0
    }

    public class TypeInitializationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6938360
        public void GetObjectData(){} // RVA: 0x6938470
        public void get_TypeName(){} // RVA: 0x6926BE0
    }

    public class TypeLoadException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6970DD0
        public void get_Message(){} // RVA: 0x69707D0
        public void SetMessageField(){} // RVA: 0x69707F0
        public void GetObjectData(){} // RVA: 0x6971060
    }

    public class TypeName
    {
        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0x87C0A0
    }

    public class TypeNameParser : Object
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x6977820
    }

    public class TypeSpec : Object
    {
        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x5BC22D0
        public void GetDisplayFullName(){} // RVA: 0x698D590
        public void GetModifierString(){} // RVA: 0x698DB60
        public void get_DisplayFullName(){} // RVA: 0x698DDE0
        public void Parse(){} // RVA: 0x698EF60
        public void UnescapeInternalName(){} // RVA: 0x698DF50
        public void Resolve(){} // RVA: 0x698E060
        public void AddName(){} // RVA: 0x698EA80
        public void AddModifier(){} // RVA: 0x698EC50
        public void SkipSpace(){} // RVA: 0x698ED90
        public void BoundCheck(){} // RVA: 0x698EEC0
        public void ParsedTypeIdentifier(){} // RVA: 0x698EF50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Type[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TypedReference : ValueType
    {
        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x696FF00
        public void InternalMakeTypedReference(){} // RVA: 0x6970530
        public void GetHashCode(){} // RVA: 0x6970600
        public void Equals(){} // RVA: 0x6970690
        public void get_IsNull(){} // RVA: 0x69706F0
        public void SetTypedReference(){} // RVA: 0x6970710
    }

}