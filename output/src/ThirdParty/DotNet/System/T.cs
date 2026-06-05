// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 46
// Methods: 756

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver
    {
        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x7FFAF89BCC00
        public void SearchTerminfo(){} // RVA: 0x7FFAF89BCEB0
        public void WriteConsole(){} // RVA: 0x7FFAF89BD060
        public void .ctor(){} // RVA: 0x7FFAF89BD090
        public void get_Initialized(){} // RVA: 0x7FFAF461CD50
        public void Init(){} // RVA: 0x7FFAF89BD910
        public void IncrementX(){} // RVA: 0x7FFAF89BE590
        public void WriteSpecialKey(){} // RVA: 0x7FFAF89BE820 | overloaded x2
        public void IsSpecialKey(){} // RVA: 0x7FFAF89BE990 | overloaded x2
        public void GetCursorPosition(){} // RVA: 0x7FFAF89BE9E0
        public void CheckWindowDimensions(){} // RVA: 0x7FFAF89BEA80
        public void get_WindowHeight(){} // RVA: 0x7FFAF89BEBE0
        public void get_WindowWidth(){} // RVA: 0x7FFAF89BEC10
        public void AddToBuffer(){} // RVA: 0x7FFAF89BEC40
        public void AdjustBuffer(){} // RVA: 0x7FFAF89BEDF0
        public void CreateKeyInfoFromInt(){} // RVA: 0x7FFAF89BEE10
        public void GetKeyFromBuffer(){} // RVA: 0x7FFAF89BEF50
        public void ReadKeyInternal(){} // RVA: 0x7FFAF89BF2D0
        public void InputPending(){} // RVA: 0x7FFAF89BF480
        public void QueueEcho(){} // RVA: 0x7FFAF89BF4C0
        public void Echo(){} // RVA: 0x7FFAF89BF600
        public void EchoFlush(){} // RVA: 0x7FFAF89BF7D0
        public void Read(){} // RVA: 0x7FFAF89BF820
        public void ReadKey(){} // RVA: 0x7FFAF89BFBF0
        public void ReadLine(){} // RVA: 0x7FFAF89BFCB0
        public void ReadToEnd(){} // RVA: 0x7FFAF89BFCC0
        public void ReadUntilConditionInternal(){} // RVA: 0x7FFAF89BFCD0
        public void SetCursorPosition(){} // RVA: 0x7FFAF89C0000
        public void CreateKeyMap(){} // RVA: 0x7FFAF89C0390
        public void InitKeys(){} // RVA: 0x7FFAF89C1F00
        public void AddStringMapping(){} // RVA: 0x7FFAF89C2200
        public void .cctor(){} // RVA: 0x7FFAF89C2250
    }

    public class TermInfoReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89C47B0 | overloaded x2
        public void DetermineVersion(){} // RVA: 0x7FFAF89C4890
        public void ReadHeader(){} // RVA: 0x7FFAF89C4950
        public void ReadNames(){} // RVA: 0x7FFAF89C4BD0
        public void Get(){} // RVA: 0x7FFAF89C4D40 | overloaded x2
        public void GetStringBytes(){} // RVA: 0x7FFAF89C5130 | overloaded x2
        public void GetInt16(){} // RVA: 0x7FFAF89C5040
        public void GetString(){} // RVA: 0x7FFAF89C50A0
    }

    public class ThreadStaticAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAF8D6DAB0
        public void CreateArgumentNullException(){} // RVA: 0x7FFAF8D6DAE0
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7FFAF8D6DBA0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFAF8D6DBD0
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFAF8D6DC50
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFAF8D6DC80
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7FFAF8D6DD70
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7FFAF8D6DDA0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFAF8D6DE80
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7FFAF8D6DEB0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAF8D6DFE0 | overloaded x2
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAF8D6E010 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAF8D6E0D0
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAF8D6E100
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAF8D6E230
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAF8D6E260
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAF8D6E310
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAF8D6E340
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAF8D6E420
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAF8D6E450
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAF8D6E4F0
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAF8D6E520
        public void TryFormatThrowFormatException(){} // RVA: 0x7FFAF8D6E5B0
        public void TryParseThrowFormatException(){} // RVA: 0x7FFAF2ABE230
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7FFAF8D6E5D0
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7FFAF8D6E600
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAF8976300
        public void CreateArgumentNullException(){} // RVA: 0x7FFAF8976330
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7FFAF89763F0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFAF8976420
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7FFAF89764A0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7FFAF89764D0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFAF8976540
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7FFAF8976570
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAF8976FF0 | overloaded x3
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAF89766D0 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAF8976790
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAF89767C0
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAF8976890
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAF89768C0
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAF8976950
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAF8976980
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAF89769F0
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAF8976A20
        public void ThrowArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x7FFAF8976AC0
        public void CreateArgumentOutOfRangeException_OffsetOutOfRange(){} // RVA: 0x7FFAF8976AF0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAF8976B90
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAF8976BC0
        public void ThrowNotSupportedException(){} // RVA: 0x7FFAF89771A0 | overloaded x2
        public void CreateThrowNotSupportedException(){} // RVA: 0x7FFAF8976C60
        public void TryFormatThrowFormatException(){} // RVA: 0x7FFAF8976CE0
        public void TryParseThrowFormatException(){} // RVA: 0x7FFAF2ABE230
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7FFAF8976D00
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7FFAF8976D30
        public void ThrowWrongKeyTypeArgumentException(){} // RVA: 0x7FFAF8976D50
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x7FFAF8976E30
        public void ThrowArgumentException(){} // RVA: 0x7FFAF8976F70 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFAF89770E0
        public void ThrowSerializationException(){} // RVA: 0x7FFAF8977140
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x7FFAF8977200
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x7FFAF8977250
        public void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted(){} // RVA: 0x7FFAF89772A0
        public void ThrowInvalidOperationException_InvalidOperation_EnumEnded(){} // RVA: 0x7FFAF89772F0
        public void ThrowInvalidOperationException_InvalidOperation_NoValue(){} // RVA: 0x7FFAF8977340
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFAF8977DD0 | overloaded x2
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFAF8977410
        public void ThrowIndexArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x7FFAF8977450
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x7FFAF8977490
        public void GetAddingDuplicateWithKeyArgumentException(){} // RVA: 0x7FFAF89774E0
        public void ThrowAddingDuplicateWithKeyArgumentException(){} // RVA: 0x7FFAF8977570
        public void GetKeyNotFoundException(){} // RVA: 0x7FFAF89775A0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF8977620
        public void ThrowInvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFAF8977630
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x7FFAF89776A0
        public void GetInvalidOperationException(){} // RVA: 0x7FFAF89776E0
        public void ThrowArraySegmentCtorValidationFailedExceptions(){} // RVA: 0x7FFAF8977740
        public void GetArraySegmentCtorValidationFailedException(){} // RVA: 0x7FFAF8977770
        public void GetArgumentException(){} // RVA: 0x7FFAF89778F0
        public void GetArgumentNullException(){} // RVA: 0x7FFAF8977990
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x7FFAF2ADA490
        public void GetArgumentName(){} // RVA: 0x7FFAF8977A30
        public void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index(){} // RVA: 0x7FFAF8977E90
        public void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count(){} // RVA: 0x7FFAF8977ED0
        public void GetResourceName(){} // RVA: 0x7FFAF8977F10
        public void ThrowValueArgumentOutOfRange_NeedNonNegNumException(){} // RVA: 0x7FFAF8978590
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7FFAF8653E70
        public void Throw(){} // RVA: 0x7FFAF8653E90
        public void IfNullOrWhitespace(){} // RVA: 0x7FFAF8653EE0
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7FFAF865E550
        public void Throw(){} // RVA: 0x7FFAF865E570
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7FFAF8665BD0
        public void Throw(){} // RVA: 0x7FFAF8665BF0
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x7FFAF8638D20
        public void Throw(){} // RVA: 0x7FFAF8638D40
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAF8E19160
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAF8E19190
        public void GetArgumentNullException(){} // RVA: 0x7FFAF8E191C0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFAF8E19260
        public void GetArgumentName(){} // RVA: 0x7FFAF8E19300
    }

    public class TimeProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void GetUtcNow(){} // RVA: 0x7FFAF8638930
        public void get_LocalTimeZone(){} // RVA: 0x7FFAF86389E0
        public void .cctor(){} // RVA: 0x7FFAF8638A30
    }

    public class TimeSpan
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89677D0 | overloaded x4
        public void get_Ticks(){} // RVA: 0x7FFAF4584690
        public void get_Days(){} // RVA: 0x7FFAF8967890
        public void get_Hours(){} // RVA: 0x7FFAF89678B0
        public void get_Milliseconds(){} // RVA: 0x7FFAF89678F0
        public void get_Minutes(){} // RVA: 0x7FFAF8967940
        public void get_Seconds(){} // RVA: 0x7FFAF8967990
        public void get_TotalDays(){} // RVA: 0x7FFAF89679E0
        public void get_TotalHours(){} // RVA: 0x7FFAF8967A00
        public void get_TotalMilliseconds(){} // RVA: 0x7FFAF8967A20
        public void get_TotalMinutes(){} // RVA: 0x7FFAF8967A50
        public void get_TotalSeconds(){} // RVA: 0x7FFAF8967A70
        public void Add(){} // RVA: 0x7FFAF8967A90
        public void Compare(){} // RVA: 0x7FFAF8967B10
        public void CompareTo(){} // RVA: 0x7FFAF8967C10 | overloaded x2
        public void FromDays(){} // RVA: 0x7FFAF8967C30
        public void Duration(){} // RVA: 0x7FFAF8967C90
        public void Equals(){} // RVA: 0x7FFAF5328D00 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAF894A080
        public void FromHours(){} // RVA: 0x7FFAF8967DE0
        public void Interval(){} // RVA: 0x7FFAF8967E40
        public void FromMilliseconds(){} // RVA: 0x7FFAF8967F50
        public void FromMinutes(){} // RVA: 0x7FFAF8967FB0
        public void Negate(){} // RVA: 0x7FFAF8968010
        public void FromSeconds(){} // RVA: 0x7FFAF89680C0
        public void Subtract(){} // RVA: 0x7FFAF8968120
        public void FromTicks(){} // RVA: 0x7FFAF44EF520
        public void TimeToTicks(){} // RVA: 0x7FFAF89681A0
        public void ValidateStyles(){} // RVA: 0x7FFAF8968240
        public void Parse(){} // RVA: 0x7FFAF8968340 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFAF8968790 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFAF89689C0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAF8968E60 | overloaded x4
        public void ToString(){} // RVA: 0x7FFAF89690B0 | overloaded x3
        public void TryFormat(){} // RVA: 0x7FFAF8969130
        public void op_UnaryNegation(){} // RVA: 0x7FFAF8969270
        public void op_Subtraction(){} // RVA: 0x7FFAF8969320
        public void op_UnaryPlus(){} // RVA: 0x7FFAF44EF520
        public void op_Addition(){} // RVA: 0x7FFAF89693E0
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF89694A0
        public void op_LessThan(){} // RVA: 0x7FFAF89694B0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAF89694C0
        public void op_GreaterThan(){} // RVA: 0x7FFAF89694D0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAF89694E0
        public void .cctor(){} // RVA: 0x7FFAF89694F0
    }

    public class TimeZone
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF8969570
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_CurrentTimeZone(){} // RVA: 0x7FFAF8969640
        public void GetUtcOffset(){}
        public void GetDaylightChanges(){} // RVA: 0x7FFAF2ACBCC0
        public void CalculateUtcOffset(){} // RVA: 0x7FFAF8969970
    }

    public class TimeZoneInfo
    {
        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x7FFAF880A010
        public void PopulateAllSystemTimeZones(){} // RVA: 0x7FFAF880A0B0
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x7FFAF880A140
        public void .ctor(){} // RVA: 0x7FFAF881B400 | overloaded x4
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x7FFAF880A8E0
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x7FFAF880EC70 | overloaded x2
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x7FFAF880AD40
        public void GetLocalTimeZone(){} // RVA: 0x7FFAF880AF10
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x7FFAF880B290
        public void FindSystemTimeZoneById(){} // RVA: 0x7FFAF880B3C0
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x7FFAF880B8C0
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x7FFAF880F2A0 | overloaded x2
        public void TryCreateAdjustmentRules(){} // RVA: 0x7FFAF880BD00
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x7FFAF880C950
        public void TryCompareStandardDate(){} // RVA: 0x7FFAF880CA80
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x7FFAF880CB00
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x7FFAF880D0C0
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x7FFAF880D440
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x7FFAF880D840
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x7FFAF881A420 | overloaded x2
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x7FFAF880E000
        public void get_HaveRegistry(){} // RVA: 0x7FFAF880E540
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x7FFAF880E5C0
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFAF880E760
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x7FFAF880E8F0
        public void GetTimeZoneInformationForYear(){} // RVA: 0x7FFAF880EAB0
        public void TryCreateTimeZone(){} // RVA: 0x7FFAF8810140
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x7FFAF8810BC0
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x7FFAF8810F30
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x7FFAF8811190
        public void get_Id(){} // RVA: 0x7FFAF2DA8380
        public void get_DisplayName(){} // RVA: 0x7FFAF88119A0
        public void get_StandardName(){} // RVA: 0x7FFAF88119F0
        public void get_DaylightName(){} // RVA: 0x7FFAF8811A40
        public void get_BaseUtcOffset(){} // RVA: 0x7FFAF30E74D0
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x7FFAF2F56500
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x7FFAF8811EC0 | overloaded x2
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x7FFAF8812390
        public void GetPreviousAdjustmentRule(){} // RVA: 0x7FFAF8812410
        public void GetUtcOffset(){} // RVA: 0x7FFAF881ADD0 | overloaded x6
        public void GetLocalUtcOffset(){} // RVA: 0x7FFAF8812650
        public void IsAmbiguousTime(){} // RVA: 0x7FFAF8812B50 | overloaded x3
        public void IsDaylightSavingTime(){} // RVA: 0x7FFAF88130A0 | overloaded x4
        public void IsInvalidTime(){} // RVA: 0x7FFAF8813380
        public void ClearCachedData(){} // RVA: 0x7FFAF8813630
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x7FFAF8813800 | overloaded x3
        public void ConvertTime(){} // RVA: 0x7FFAF8814220 | overloaded x5
        public void ConvertTimeFromUtc(){} // RVA: 0x7FFAF8814850
        public void ConvertTimeToUtc(){} // RVA: 0x7FFAF8814B70 | overloaded x3
        public void Equals(){} // RVA: 0x7FFAF8814CF0 | overloaded x2
        public void FromSerializedString(){} // RVA: 0x7FFAF8814D50
        public void GetHashCode(){} // RVA: 0x7FFAF8814E30
        public void GetSystemTimeZones(){} // RVA: 0x7FFAF8814EE0
        public void HasSameRules(){} // RVA: 0x7FFAF8815410
        public void get_Local(){} // RVA: 0x7FFAF8815700
        public void ToSerializedString(){} // RVA: 0x7FFAF8815780
        public void ToString(){} // RVA: 0x7FFAF88119A0
        public void get_Utc(){} // RVA: 0x7FFAF8815790
        public void CreateCustomTimeZone(){} // RVA: 0x7FFAF8815B90 | overloaded x3
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF8815CC0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF8815E80
        public void GetAdjustmentRuleForTime(){} // RVA: 0x7FFAF88166B0 | overloaded x2
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x7FFAF8816930
        public void ConvertToUtc(){} // RVA: 0x7FFAF8816B80
        public void ConvertFromUtc(){} // RVA: 0x7FFAF8816BA0
        public void ConvertToFromUtc(){} // RVA: 0x7FFAF8816BC0
        public void ConvertUtcToTimeZone(){} // RVA: 0x7FFAF8816E80
        public void GetDaylightTime(){} // RVA: 0x7FFAF8817270
        public void GetIsDaylightSavings(){} // RVA: 0x7FFAF88173E0
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x7FFAF88179E0
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x7FFAF8817AC0
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x7FFAF8817B50
        public void CheckIsDst(){} // RVA: 0x7FFAF8818640
        public void GetIsAmbiguousTime(){} // RVA: 0x7FFAF8818970
        public void GetIsInvalidTime(){} // RVA: 0x7FFAF8818D30
        public void GetUtcOffsetFromUtc(){} // RVA: 0x7FFAF8819470 | overloaded x3
        public void TransitionTimeToDateTime(){} // RVA: 0x7FFAF88197E0
        public void TryGetTimeZone(){} // RVA: 0x7FFAF881A120
        public void ValidateTimeZoneInfo(){} // RVA: 0x7FFAF881A8F0
        public void UtcOffsetOutOfRange(){} // RVA: 0x7FFAF881ACF0
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x7FFAF881AEB0
        public void .cctor(){} // RVA: 0x7FFAF881AFD0
    }

    public class TimeZoneNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8969D90 | overloaded x4
    }

    public class TimeoutException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class Tuple
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void CombineHashCodes(){} // RVA: 0x7FFAF8969E90 | overloaded x3
    }

    public class Tuple`2
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item2(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF2AC1120
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF2AC2590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF2AC7680
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF2AC2590
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF2ABCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2ABD840
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2
    {
    }

    public class Tuple`2
    {
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2ABCD60
        public void get_Item2(){} // RVA: 0x7FFAF2D13BC0
        public void .ctor(){} // RVA: 0x7FFAF533F850
        public void Equals(){} // RVA: 0x7FFAF6EE9E80
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9F00
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EEA200
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EEA280
        public void GetHashCode(){} // RVA: 0x7FFAF6EEA610
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EEA680
        public void ToString(){} // RVA: 0x7FFAF6EEA840
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EEA910
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2 : 
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2DA8380
        public void get_Item2(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Equals(){} // RVA: 0x7FFAF6EE9810
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE9890
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE9990
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE9A10
        public void GetHashCode(){} // RVA: 0x7FFAF6EE9B90
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE9C00
        public void ToString(){} // RVA: 0x7FFAF6EE9C90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE9D60
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`2
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF441ABE0
        public void get_Item2(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF6EE7830
        public void Equals(){} // RVA: 0x7FFAF6EE7890
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF6EE7910
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF6EE7A60
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF6EE7AE0
        public void GetHashCode(){} // RVA: 0x7FFAF6EE7CC0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF6EE7D30
        public void ToString(){} // RVA: 0x7FFAF6EE7DE0
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF6EE7EB0
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2E92CB0
    }

    public class Tuple`3
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item2(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item3(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF2AC1120
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF2AC2590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF2AC7680
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF2AC2590
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF2ABCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2ABD840
    }

    public class Tuple`4
    {
        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item2(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item3(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item4(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAF2AC1120
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAF2AC2590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAF2AC7680
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAF2AC2590
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAF2ABCE10
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAF2ABD840
    }

    public class Type
    {
        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x7FFAF8969EB0
        public void GetEnumName(){} // RVA: 0x7FFAF896A4F0
        public void GetEnumNames(){} // RVA: 0x7FFAF896A8E0
        public void GetEnumRawConstantValues(){} // RVA: 0x7FFAF896A990
        public void GetEnumData(){} // RVA: 0x7FFAF896A9C0
        public void BinarySearch(){} // RVA: 0x7FFAF896AE70
        public void IsIntegerType(){} // RVA: 0x7FFAF896B030
        public void get_IsSerializable(){} // RVA: 0x7FFAF896B340
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAF896B540
        public void GetRootElementType(){} // RVA: 0x7FFAF896B6A0
        public void get_IsVisible(){} // RVA: 0x7FFAF896B700
        public void IsSubclassOf(){} // RVA: 0x7FFAF896B900
        public void IsAssignableFrom(){} // RVA: 0x7FFAF896B9C0
        public void ImplementInterface(){} // RVA: 0x7FFAF896BBA0
        public void FilterAttributeImpl(){} // RVA: 0x7FFAF896BD00
        public void FilterNameImpl(){} // RVA: 0x7FFAF896C090
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x7FFAF896C340
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_MemberType(){} // RVA: 0x7FFAF4BBE300
        public void GetType(){} // RVA: 0x7FFAF896F0D0 | overloaded x5
        public void get_Namespace(){} // RVA: 0x7FFAF2ABCD60
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAF2ABCD60
        public void get_FullName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Assembly(){} // RVA: 0x7FFAF2ABCD60
        public void get_Module(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsNested(){} // RVA: 0x7FFAF896C750
        public void get_DeclaringType(){} // RVA: 0x7FFAF2FC9240
        public void get_DeclaringMethod(){} // RVA: 0x7FFAF2FC9240
        public void get_ReflectedType(){} // RVA: 0x7FFAF2FC9240
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsArray(){} // RVA: 0x7FFAF896C7C0
        public void IsArrayImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsByRef(){} // RVA: 0x7FFAF896C7E0
        public void IsByRefImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsPointer(){} // RVA: 0x7FFAF896C800
        public void IsPointerImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAF896C820
        public void get_IsGenericParameter(){} // RVA: 0x7FFAF2D8D320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAF896C850
        public void get_IsGenericType(){} // RVA: 0x7FFAF2D8D320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAF2D8D320
        public void get_IsSZArray(){} // RVA: 0x7FFAF896C8D0
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAF896C900
        public void get_HasElementType(){} // RVA: 0x7FFAF896C950
        public void HasElementTypeImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void GetElementType(){} // RVA: 0x7FFAF2ABCD60
        public void GetArrayRank(){} // RVA: 0x7FFAF896C970
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAF896C9C0
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAF896CA10
        public void GetGenericArguments(){} // RVA: 0x7FFAF896CAA0
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAF896CAF0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFAF896CB40
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFAF896CB80
        public void get_Attributes(){} // RVA: 0x7FFAF896CC20
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAF2ABD840
        public void get_IsAbstract(){} // RVA: 0x7FFAF896CC40
        public void get_IsImport(){} // RVA: 0x7FFAF896CC70
        public void get_IsSealed(){} // RVA: 0x7FFAF896CCA0
        public void get_IsSpecialName(){} // RVA: 0x7FFAF896CCD0
        public void get_IsClass(){} // RVA: 0x7FFAF896CD00
        public void get_IsNestedAssembly(){} // RVA: 0x7FFAF896CD50
        public void get_IsNestedFamANDAssem(){} // RVA: 0x7FFAF896CD80
        public void get_IsNestedFamily(){} // RVA: 0x7FFAF896CDB0
        public void get_IsNestedFamORAssem(){} // RVA: 0x7FFAF896CDE0
        public void get_IsNestedPrivate(){} // RVA: 0x7FFAF896CE10
        public void get_IsNestedPublic(){} // RVA: 0x7FFAF896CE40
        public void get_IsNotPublic(){} // RVA: 0x7FFAF896CE70
        public void get_IsPublic(){} // RVA: 0x7FFAF896CEA0
        public void get_IsAutoLayout(){} // RVA: 0x7FFAF896CED0
        public void get_IsExplicitLayout(){} // RVA: 0x7FFAF896CF00
        public void get_IsLayoutSequential(){} // RVA: 0x7FFAF896CF30
        public void get_IsAnsiClass(){} // RVA: 0x7FFAF896CF60
        public void get_IsAutoClass(){} // RVA: 0x7FFAF896CF90
        public void get_IsUnicodeClass(){} // RVA: 0x7FFAF896CFC0
        public void get_IsCOMObject(){} // RVA: 0x7FFAF896CFF0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsContextful(){} // RVA: 0x7FFAF896D010
        public void IsContextfulImpl(){} // RVA: 0x7FFAF896D030
        public void get_IsCollectible(){} // RVA: 0x7FFAF2E72850
        public void get_IsEnum(){} // RVA: 0x7FFAF896D110
        public void get_IsMarshalByRef(){} // RVA: 0x7FFAF896D1F0
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFAF896D210
        public void get_IsPrimitive(){} // RVA: 0x7FFAF896D2F0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsValueType(){} // RVA: 0x7FFAF896D310
        public void IsValueTypeImpl(){} // RVA: 0x7FFAF896D330
        public void get_IsSignatureType(){} // RVA: 0x7FFAF2D8D320
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAF896D410
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFAF896D440
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFAF896D470
        public void GetConstructor(){} // RVA: 0x7FFAF896D500 | overloaded x3
        public void GetConstructorImpl(){}
        public void GetConstructors(){} // RVA: 0x7FFAF2ACBCC0 | overloaded x2
        public void GetEvent(){} // RVA: 0x7FFAF2ACDD80 | overloaded x2
        public void GetEvents(){} // RVA: 0x7FFAF2ACBCC0
        public void GetField(){} // RVA: 0x7FFAF2ACDD80 | overloaded x2
        public void GetFields(){} // RVA: 0x7FFAF2ACBCC0 | overloaded x2
        public void GetMember(){} // RVA: 0x7FFAF896D750 | overloaded x3
        public void GetMembers(){} // RVA: 0x7FFAF2ACBCC0
        public void GetMethod(){} // RVA: 0x7FFAF896D980 | overloaded x6
        public void GetMethodImpl(){}
        public void GetMethods(){} // RVA: 0x7FFAF2ACBCC0 | overloaded x2
        public void GetNestedType(){} // RVA: 0x7FFAF2ACDD80 | overloaded x2
        public void GetProperty(){} // RVA: 0x7FFAF896DFD0 | overloaded x6
        public void GetPropertyImpl(){}
        public void GetProperties(){} // RVA: 0x7FFAF2ACBCC0 | overloaded x2
        public void get_TypeHandle(){} // RVA: 0x7FFAF896E0E0
        public void GetTypeHandle(){} // RVA: 0x7FFAF896E120
        public void GetTypeArray(){} // RVA: 0x7FFAF896E1B0
        public void GetTypeCode(){} // RVA: 0x7FFAF896E330
        public void GetTypeCodeImpl(){} // RVA: 0x7FFAF896E3A0
        public void get_GUID(){} // RVA: 0x7FFAF2ABC770
        public void get_BaseType(){} // RVA: 0x7FFAF2ABCD60
        public void InvokeMember(){}
        public void GetInterface(){} // RVA: 0x7FFAF2ACD640
        public void GetInterfaces(){} // RVA: 0x7FFAF2ABCD60
        public void IsInstanceOfType(){} // RVA: 0x7FFAF896E4F0
        public void IsEquivalentTo(){} // RVA: 0x7FFAF896E540
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFAF896E5A0
        public void GetEnumValues(){} // RVA: 0x7FFAF896E6F0
        public void MakeArrayType(){} // RVA: 0x7FFAF896E7E0 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFAF896E820
        public void MakeGenericType(){} // RVA: 0x7FFAF896E860
        public void MakePointerType(){} // RVA: 0x7FFAF896E8B0
        public void MakeGenericSignatureType(){} // RVA: 0x7FFAF896E8F0
        public void ToString(){} // RVA: 0x7FFAF896E960
        public void Equals(){} // RVA: 0x7FFAF896EAC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF896EA60
        public void get_DefaultBinder(){} // RVA: 0x7FFAF896EB60
        public void GetTypeFromHandle(){} // RVA: 0x7FFAF896EC90
        public void internal_from_handle(){} // RVA: 0x7FFAF896ED00
        public void get_IsSzArray(){} // RVA: 0x7FFAF2D8D320
        public void FormatTypeName(){} // RVA: 0x7FFAF896ED40 | overloaded x2
        public void get_IsInterface(){} // RVA: 0x7FFAF896ED80
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF89694A0
        public void get_FullNameOrDefault(){} // RVA: 0x7FFAF896F210
        public void IsRuntimeImplemented(){} // RVA: 0x7FFAF896F2A0
        public void InternalGetNameIfAvailable(){} // RVA: 0x7FFAF3400560
        public void get_InternalNameIfAvailable(){} // RVA: 0x7FFAF896F340
        public void get_NameOrDefault(){} // RVA: 0x7FFAF896F370
        public void .cctor(){} // RVA: 0x7FFAF896F3E0
    }

    public class TypeAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF892BF40 | overloaded x2
    }

    public class TypeIdentifier
    {
        // ── Methods ──
        public void get_InternalName(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TypeIdentifiers
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x7FFAF89C5480
    }

    public class TypeInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF896F910 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAF896FA20
        public void get_TypeName(){} // RVA: 0x7FFAF896FC20
    }

    public class TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89A90D0 | overloaded x5
        public void get_Message(){} // RVA: 0x7FFAF89A8AD0
        public void SetMessageField(){} // RVA: 0x7FFAF89A8AF0
        public void GetObjectData(){} // RVA: 0x7FFAF89A9360
    }

    public class TypeName
    {
        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0x7FFAF2ABCD60
    }

    public class TypeNameParser
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFAF89B0080
    }

    public class TypeNames
    {
    }

    public class TypeSpec
    {
        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x7FFAF7C055E0
        public void GetDisplayFullName(){} // RVA: 0x7FFAF89C5B40
        public void GetModifierString(){} // RVA: 0x7FFAF89C6110
        public void get_DisplayFullName(){} // RVA: 0x7FFAF89C6390
        public void Parse(){} // RVA: 0x7FFAF89C74D0 | overloaded x2
        public void UnescapeInternalName(){} // RVA: 0x7FFAF89C6500
        public void Resolve(){} // RVA: 0x7FFAF89C6600
        public void AddName(){} // RVA: 0x7FFAF89C7060
        public void AddModifier(){} // RVA: 0x7FFAF89C7230
        public void SkipSpace(){} // RVA: 0x7FFAF89C7370
        public void BoundCheck(){} // RVA: 0x7FFAF89C7430
        public void ParsedTypeIdentifier(){} // RVA: 0x7FFAF89C74C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TypedReference
    {
        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x7FFAF89A81F0
        public void InternalMakeTypedReference(){} // RVA: 0x7FFAF89A8830
        public void GetHashCode(){} // RVA: 0x7FFAF89A8900
        public void Equals(){} // RVA: 0x7FFAF89A8990
        public void get_IsNull(){} // RVA: 0x7FFAF89A89F0
        public void SetTypedReference(){} // RVA: 0x7FFAF89A8A10
    }

}