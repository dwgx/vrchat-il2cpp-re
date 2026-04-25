// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 25
// Methods: 521

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver : Object
    {
        public int* Initialized;
        public int WindowHeight; // 0x8
        public string[] WindowWidth; // 0x10
        public System.TermInfoReader reader; // 0x10
        public int cursorLeft; // 0x18
        public int cursorTop; // 0x1C
        public string title; // 0x20
        public string titleFormat; // 0x28
        public bool cursorVisible; // 0x30
        public string csrVisible; // 0x38
        public string csrInvisible; // 0x40
        public string clear; // 0x48
        public string bell; // 0x50
        public string term; // 0x58
        public System.IO.StreamReader stdin; // 0x60
        public System.IO.CStreamWriter stdout; // 0x68
        public int windowWidth; // 0x70
        public int windowHeight; // 0x74
        public int bufferHeight; // 0x78
        public int bufferWidth; // 0x7C
        public char[] buffer; // 0x80
        public int readpos; // 0x88
        public int writepos; // 0x8C
        public string keypadXmit; // 0x90
        public string keypadLocal; // 0x98
        public bool inited; // 0xA0
        public object initLock; // 0xA8
        public bool initKeys; // 0xB0
        public string origPair; // 0xB8
        public string origColors; // 0xC0
        public string cursorAddress; // 0xC8
        public 0x6B0C20F8 fgcolor; // 0xD0
        public string setfgcolor; // 0xD8
        public string setbgcolor; // 0xE0
        public int maxColors; // 0xE8
        public bool noGetPosition; // 0xEC
        public System.Collections.Hashtable keymap; // 0xF0
        public System.ByteMatcher rootmap; // 0xF8
        public int rl_startx; // 0x100
        public int rl_starty; // 0x104
        public byte[] control_characters; // 0x108
        public int[] _consoleColorToAnsiCode; // 0x18
        public char[] echobuf; // 0x110
        public int echon; // 0x118

        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x7FFAC86A4270
        public void SearchTerminfo(){} // RVA: 0x7FFAC86A4520
        public void WriteConsole(){} // RVA: 0x7FFAC86A46D0
        public void .ctor(){} // RVA: 0x7FFAC86A4700
        public void get_Initialized(){} // RVA: 0x7FFAC45C9D50
        public void Init(){} // RVA: 0x7FFAC86A4F80
        public void IncrementX(){} // RVA: 0x7FFAC86A5C00
        public void WriteSpecialKey(){} // RVA: 0x7FFAC86A5E90 | overloaded x2
        public void IsSpecialKey(){} // RVA: 0x7FFAC86A6000 | overloaded x2
        public void GetCursorPosition(){} // RVA: 0x7FFAC86A6050
        public void CheckWindowDimensions(){} // RVA: 0x7FFAC86A60F0
        public void get_WindowHeight(){} // RVA: 0x7FFAC86A6250
        public void get_WindowWidth(){} // RVA: 0x7FFAC86A6280
        public void AddToBuffer(){} // RVA: 0x7FFAC86A62B0
        public void AdjustBuffer(){} // RVA: 0x7FFAC86A6460
        public void CreateKeyInfoFromInt(){} // RVA: 0x7FFAC86A6480
        public void GetKeyFromBuffer(){} // RVA: 0x7FFAC86A65C0
        public void ReadKeyInternal(){} // RVA: 0x7FFAC86A6940
        public void InputPending(){} // RVA: 0x7FFAC86A6AF0
        public void QueueEcho(){} // RVA: 0x7FFAC86A6B30
        public void Echo(){} // RVA: 0x7FFAC86A6C70
        public void EchoFlush(){} // RVA: 0x7FFAC86A6E40
        public void Read(){} // RVA: 0x7FFAC86A6E90
        public void ReadKey(){} // RVA: 0x7FFAC86A7260
        public void ReadLine(){} // RVA: 0x7FFAC86A7320
        public void ReadToEnd(){} // RVA: 0x7FFAC86A7330
        public void ReadUntilConditionInternal(){} // RVA: 0x7FFAC86A7340
        public void SetCursorPosition(){} // RVA: 0x7FFAC86A7670
        public void CreateKeyMap(){} // RVA: 0x7FFAC86A7A00
        public void InitKeys(){} // RVA: 0x7FFAC86A9570
        public void AddStringMapping(){} // RVA: 0x7FFAC86A9870
        public void .cctor(){} // RVA: 0x7FFAC86A98C0
    }

    public class TermInfoReader : Object
    {
        public int boolSize; // 0x10
        public int numSize; // 0x14
        public int strOffsets; // 0x18
        public byte[] buffer; // 0x20
        public int booleansOffset; // 0x28
        public int intOffset; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86ABE20 | overloaded x2
        public void DetermineVersion(){} // RVA: 0x7FFAC86ABF00
        public void ReadHeader(){} // RVA: 0x7FFAC86ABFC0
        public void ReadNames(){} // RVA: 0x7FFAC86AC240
        public void Get(){} // RVA: 0x7FFAC86AC3B0 | overloaded x2
        public void GetStringBytes(){} // RVA: 0x7FFAC86AC7A0 | overloaded x2
        public void GetInt16(){} // RVA: 0x7FFAC86AC6B0
        public void GetString(){} // RVA: 0x7FFAC86AC710
    }

    public class ThreadStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAC8A54E50
        public void CreateArgumentNullException(){} // RVA: 0x7FFAC8A54E80
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7FFAC8A54F40
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFAC8A54F70
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFAC8A54FF0
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFAC8A55020
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7FFAC8A55110
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7FFAC8A55140
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFAC8A55220
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7FFAC8A55250
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAC8A55380 | overloaded x2
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFAC8A553B0 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAC8A55470
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFAC8A554A0
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAC8A555D0
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFAC8A55600
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAC8A556B0
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFAC8A556E0
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAC8A557C0
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFAC8A557F0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAC8A55890
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7FFAC8A558C0
        public void TryFormatThrowFormatException(){} // RVA: 0x7FFAC8A55950
        public void TryParseThrowFormatException(){} // RVA: 0x7FFAC2C5A350
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7FFAC8A55970
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7FFAC8A559A0
    }

    public class TimeProvider : Object
    {
        public System.TimeProvider LocalTimeZone;
        public long s_minDateTicks; // 0x8
        public long s_maxDateTicks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetUtcNow(){} // RVA: 0x7FFAC831FE60
        public void get_LocalTimeZone(){} // RVA: 0x7FFAC831FF10
        public void .cctor(){} // RVA: 0x7FFAC831FF60
    }

    public class TimeSpan : ValueType
    {
        public long Ticks;
        public double Days;
        public long Hours;
        public double Milliseconds;
        public long Minutes;
        public double Seconds;
        public long TotalDays;
        public double TotalHours;
        public long TotalMilliseconds;
        public double TotalMinutes;
        public int TotalSeconds;
        public int MillisPerMinute;
        public int MillisPerHour;
        public int MillisPerDay;
        public long MaxSeconds;
        public long MinSeconds;
        public long MaxMilliSeconds;
        public long MinMilliSeconds;
        public long TicksPerTenthSecond;
        public System.TimeSpan Zero;
        public System.TimeSpan MaxValue; // 0x8
        public System.TimeSpan MinValue; // 0x10
        public long _ticks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC864EE80 | overloaded x4
        public void get_Ticks(){} // RVA: 0x7FFAC3AD9F60
        public void get_Days(){} // RVA: 0x7FFAC864EF40
        public void get_Hours(){} // RVA: 0x7FFAC864EF60
        public void get_Milliseconds(){} // RVA: 0x7FFAC864EFA0
        public void get_Minutes(){} // RVA: 0x7FFAC864EFF0
        public void get_Seconds(){} // RVA: 0x7FFAC864F040
        public void get_TotalDays(){} // RVA: 0x7FFAC864F090
        public void get_TotalHours(){} // RVA: 0x7FFAC864F0B0
        public void get_TotalMilliseconds(){} // RVA: 0x7FFAC864F0D0
        public void get_TotalMinutes(){} // RVA: 0x7FFAC864F100
        public void get_TotalSeconds(){} // RVA: 0x7FFAC864F120
        public void Add(){} // RVA: 0x7FFAC864F140
        public void Compare(){} // RVA: 0x7FFAC864F1C0
        public void CompareTo(){} // RVA: 0x7FFAC864F2C0 | overloaded x2
        public void FromDays(){} // RVA: 0x7FFAC864F2E0
        public void Duration(){} // RVA: 0x7FFAC864F340
        public void Equals(){} // RVA: 0x7FFAC530B460 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC86316F0
        public void FromHours(){} // RVA: 0x7FFAC864F490
        public void Interval(){} // RVA: 0x7FFAC864F4F0
        public void FromMilliseconds(){} // RVA: 0x7FFAC864F600
        public void FromMinutes(){} // RVA: 0x7FFAC864F660
        public void Negate(){} // RVA: 0x7FFAC864F6C0
        public void FromSeconds(){} // RVA: 0x7FFAC864F770
        public void Subtract(){} // RVA: 0x7FFAC864F7D0
        public void FromTicks(){} // RVA: 0x7FFAC44F81E0
        public void TimeToTicks(){} // RVA: 0x7FFAC864F850
        public void ValidateStyles(){} // RVA: 0x7FFAC864F8F0
        public void Parse(){} // RVA: 0x7FFAC864F9F0 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFAC864FE40 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFAC8650070 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAC8650510 | overloaded x4
        public void ToString(){} // RVA: 0x7FFAC8650760 | overloaded x3
        public void TryFormat(){} // RVA: 0x7FFAC86507E0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC8650920
        public void op_Subtraction(){} // RVA: 0x7FFAC86509D0
        public void op_UnaryPlus(){} // RVA: 0x7FFAC44F81E0
        public void op_Addition(){} // RVA: 0x7FFAC8650A90
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void op_LessThan(){} // RVA: 0x7FFAC8650B60
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC8650B70
        public void op_GreaterThan(){} // RVA: 0x7FFAC8650B80
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC8650B90
        public void .cctor(){} // RVA: 0x7FFAC8650BA0
    }

    public class TimeZone : Object
    {
        public System.TimeZone InternalSyncObject;
        public object CurrentTimeZone; // 0x8

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC8650C20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_CurrentTimeZone(){} // RVA: 0x7FFAC8650CF0
        public void GetUtcOffset(){}
        public void GetDaylightChanges(){} // RVA: 0x7FFAC2C67DE0
        public void CalculateUtcOffset(){} // RVA: 0x7FFAC8651020
    }

    public class TimeZoneInfo : Object
    {
        public string HaveRegistry;
        public string Id;
        public string DisplayName;
        public string StandardName;
        public string DaylightName;
        public string BaseUtcOffset;
        public string SupportsDaylightSavingTime;
        public string Local;
        public string Utc;
        public string LastEntryValue;
        public int MaxKeyLength;
        public System.Lazy`1<bool> lazyHaveRegistry;
        public uint TIME_ZONE_ID_INVALID;
        public uint ERROR_NO_MORE_ITEMS;
        public string _id; // 0x10
        public string _displayName; // 0x18
        public string _standardDisplayName; // 0x20
        public string _daylightDisplayName; // 0x28
        public System.TimeSpan _baseUtcOffset; // 0x30
        public bool _supportsDaylightSavingTime; // 0x38
        public AdjustmentRule[] _adjustmentRules; // 0x40
        public string UtcId;
        public string LocalId;
        public System.TimeZoneInfo s_utcTimeZone; // 0x8
        public CachedData s_cachedData; // 0x10
        public System.DateTime s_maxDateOnly; // 0x18
        public System.DateTime s_minDateOnly; // 0x20
        public System.TimeSpan MaxOffset; // 0x28
        public System.TimeSpan MinOffset; // 0x30

        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x7FFAC84F16A0
        public void PopulateAllSystemTimeZones(){} // RVA: 0x7FFAC84F1740
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x7FFAC84F17D0
        public void .ctor(){} // RVA: 0x7FFAC8502A90 | overloaded x4
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x7FFAC84F1F70
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x7FFAC84F6300 | overloaded x2
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x7FFAC84F23D0
        public void GetLocalTimeZone(){} // RVA: 0x7FFAC84F25A0
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x7FFAC84F2920
        public void FindSystemTimeZoneById(){} // RVA: 0x7FFAC84F2A50
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x7FFAC84F2F50
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x7FFAC84F6930 | overloaded x2
        public void TryCreateAdjustmentRules(){} // RVA: 0x7FFAC84F3390
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x7FFAC84F3FE0
        public void TryCompareStandardDate(){} // RVA: 0x7FFAC84F4110
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x7FFAC84F4190
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x7FFAC84F4750
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x7FFAC84F4AD0
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x7FFAC84F4ED0
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x7FFAC8501AB0 | overloaded x2
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x7FFAC84F5690
        public void get_HaveRegistry(){} // RVA: 0x7FFAC84F5BD0
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x7FFAC84F5C50
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFAC84F5DF0
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x7FFAC84F5F80
        public void GetTimeZoneInformationForYear(){} // RVA: 0x7FFAC84F6140
        public void TryCreateTimeZone(){} // RVA: 0x7FFAC84F77D0
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x7FFAC84F8250
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x7FFAC84F85C0
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x7FFAC84F8820
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void get_DisplayName(){} // RVA: 0x7FFAC84F9030
        public void get_StandardName(){} // RVA: 0x7FFAC84F9080
        public void get_DaylightName(){} // RVA: 0x7FFAC84F90D0
        public void get_BaseUtcOffset(){} // RVA: 0x7FFAC31D95E0
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x7FFAC31D95D0
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x7FFAC84F9550 | overloaded x2
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x7FFAC84F9A20
        public void GetPreviousAdjustmentRule(){} // RVA: 0x7FFAC84F9AA0
        public void GetUtcOffset(){} // RVA: 0x7FFAC8502460 | overloaded x6
        public void GetLocalUtcOffset(){} // RVA: 0x7FFAC84F9CE0
        public void IsAmbiguousTime(){} // RVA: 0x7FFAC84FA1E0 | overloaded x3
        public void IsDaylightSavingTime(){} // RVA: 0x7FFAC84FA730 | overloaded x4
        public void IsInvalidTime(){} // RVA: 0x7FFAC84FAA10
        public void ClearCachedData(){} // RVA: 0x7FFAC84FACC0
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x7FFAC84FAE90 | overloaded x3
        public void ConvertTime(){} // RVA: 0x7FFAC84FB8B0 | overloaded x5
        public void ConvertTimeFromUtc(){} // RVA: 0x7FFAC84FBEE0
        public void ConvertTimeToUtc(){} // RVA: 0x7FFAC84FC200 | overloaded x3
        public void Equals(){} // RVA: 0x7FFAC84FC380 | overloaded x2
        public void FromSerializedString(){} // RVA: 0x7FFAC84FC3E0
        public void GetHashCode(){} // RVA: 0x7FFAC84FC4C0
        public void GetSystemTimeZones(){} // RVA: 0x7FFAC84FC570
        public void HasSameRules(){} // RVA: 0x7FFAC84FCAA0
        public void get_Local(){} // RVA: 0x7FFAC84FCD90
        public void ToSerializedString(){} // RVA: 0x7FFAC84FCE10
        public void ToString(){} // RVA: 0x7FFAC84F9030
        public void get_Utc(){} // RVA: 0x7FFAC84FCE20
        public void CreateCustomTimeZone(){} // RVA: 0x7FFAC84FD220 | overloaded x3
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC84FD350
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC84FD510
        public void GetAdjustmentRuleForTime(){} // RVA: 0x7FFAC84FDD40 | overloaded x2
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x7FFAC84FDFC0
        public void ConvertToUtc(){} // RVA: 0x7FFAC84FE210
        public void ConvertFromUtc(){} // RVA: 0x7FFAC84FE230
        public void ConvertToFromUtc(){} // RVA: 0x7FFAC84FE250
        public void ConvertUtcToTimeZone(){} // RVA: 0x7FFAC84FE510
        public void GetDaylightTime(){} // RVA: 0x7FFAC84FE900
        public void GetIsDaylightSavings(){} // RVA: 0x7FFAC84FEA70
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x7FFAC84FF070
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x7FFAC84FF150
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x7FFAC84FF1E0
        public void CheckIsDst(){} // RVA: 0x7FFAC84FFCD0
        public void GetIsAmbiguousTime(){} // RVA: 0x7FFAC8500000
        public void GetIsInvalidTime(){} // RVA: 0x7FFAC85003C0
        public void GetUtcOffsetFromUtc(){} // RVA: 0x7FFAC8500B00 | overloaded x3
        public void TransitionTimeToDateTime(){} // RVA: 0x7FFAC8500E70
        public void TryGetTimeZone(){} // RVA: 0x7FFAC85017B0
        public void ValidateTimeZoneInfo(){} // RVA: 0x7FFAC8501F80
        public void UtcOffsetOutOfRange(){} // RVA: 0x7FFAC8502380
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x7FFAC8502540
        public void .cctor(){} // RVA: 0x7FFAC8502660
    }

    public class TimeZoneNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8651440 | overloaded x4
    }

    public class TimeoutException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class Tuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void CombineHashCodes(){} // RVA: 0x7FFAC8651540 | overloaded x3
    }

    public class Tuple`2 : Object
    {
        public U Item1;
        public T Item2;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item2(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAC2C5D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAC2C637A0
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAC2C58F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAC2C59960
    }

    public class Tuple`3 : Object
    {
        public U Item1;
        public V Item2;
        public T Item3;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item2(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item3(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAC2C5D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAC2C637A0
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAC2C58F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAC2C59960
    }

    public class Tuple`4 : Object
    {
        public U Item1;
        public V Item2;
        public W Item3;
        public T Item4;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item2(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item3(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item4(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAC2C5D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAC2C637A0
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFAC2C58F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFAC2C59960
    }

    public class Type : MemberInfo
    {
        public System.Reflection.Binder IsSerializable;
        public char ContainsGenericParameters; // 0x8
        public System.Type[] IsVisible; // 0x10
        public object MemberType; // 0x18
        public System.Reflection.MemberFilter Namespace; // 0x20
        public System.Reflection.MemberFilter AssemblyQualifiedName; // 0x28
        public System.Reflection.MemberFilter FullName; // 0x30
        public 0x6B0D8780 Assembly;
        public System.RuntimeTypeHandle Module; // 0x10
        public string IsNested;

        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x7FFAC8651560
        public void GetEnumName(){} // RVA: 0x7FFAC8651BA0
        public void GetEnumNames(){} // RVA: 0x7FFAC8651F90
        public void GetEnumRawConstantValues(){} // RVA: 0x7FFAC8652040
        public void GetEnumData(){} // RVA: 0x7FFAC8652070
        public void BinarySearch(){} // RVA: 0x7FFAC8652520
        public void IsIntegerType(){} // RVA: 0x7FFAC86526E0
        public void get_IsSerializable(){} // RVA: 0x7FFAC86529F0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC8652BF0
        public void GetRootElementType(){} // RVA: 0x7FFAC8652D50
        public void get_IsVisible(){} // RVA: 0x7FFAC8652DB0
        public void IsSubclassOf(){} // RVA: 0x7FFAC8652FB0
        public void IsAssignableFrom(){} // RVA: 0x7FFAC8653070
        public void ImplementInterface(){} // RVA: 0x7FFAC8653250
        public void FilterAttributeImpl(){} // RVA: 0x7FFAC86533B0
        public void FilterNameImpl(){} // RVA: 0x7FFAC8653740
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x7FFAC86539F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC530BFF0
        public void GetType(){} // RVA: 0x7FFAC8656780 | overloaded x5
        public void get_Namespace(){} // RVA: 0x7FFAC2C58E90
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC2C58E90
        public void get_FullName(){} // RVA: 0x7FFAC2C58E90
        public void get_Assembly(){} // RVA: 0x7FFAC2C58E90
        public void get_Module(){} // RVA: 0x7FFAC2C58E90
        public void get_IsNested(){} // RVA: 0x7FFAC8653E00
        public void get_DeclaringType(){} // RVA: 0x7FFAC34F9180
        public void get_DeclaringMethod(){} // RVA: 0x7FFAC34F9180
        public void get_ReflectedType(){} // RVA: 0x7FFAC34F9180
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsArray(){} // RVA: 0x7FFAC8653E70
        public void IsArrayImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsByRef(){} // RVA: 0x7FFAC8653E90
        public void IsByRefImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsPointer(){} // RVA: 0x7FFAC8653EB0
        public void IsPointerImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC8653ED0
        public void get_IsGenericParameter(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAC8653F00
        public void get_IsGenericType(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAC2F21320
        public void get_IsSZArray(){} // RVA: 0x7FFAC8653F80
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC8653FB0
        public void get_HasElementType(){} // RVA: 0x7FFAC8654000
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC2C59D00
        public void GetElementType(){} // RVA: 0x7FFAC2C58E90
        public void GetArrayRank(){} // RVA: 0x7FFAC8654020
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC8654070
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAC86540C0
        public void GetGenericArguments(){} // RVA: 0x7FFAC8654150
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAC86541A0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFAC86541F0
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFAC8654230
        public void get_Attributes(){} // RVA: 0x7FFAC86542D0
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC2C59960
        public void get_IsAbstract(){} // RVA: 0x7FFAC86542F0
        public void get_IsImport(){} // RVA: 0x7FFAC8654320
        public void get_IsSealed(){} // RVA: 0x7FFAC8654350
        public void get_IsSpecialName(){} // RVA: 0x7FFAC8654380
        public void get_IsClass(){} // RVA: 0x7FFAC86543B0
        public void get_IsNestedAssembly(){} // RVA: 0x7FFAC8654400
        public void get_IsNestedFamANDAssem(){} // RVA: 0x7FFAC8654430
        public void get_IsNestedFamily(){} // RVA: 0x7FFAC8654460
        public void get_IsNestedFamORAssem(){} // RVA: 0x7FFAC8654490
        public void get_IsNestedPrivate(){} // RVA: 0x7FFAC86544C0
        public void get_IsNestedPublic(){} // RVA: 0x7FFAC86544F0
        public void get_IsNotPublic(){} // RVA: 0x7FFAC8654520
        public void get_IsPublic(){} // RVA: 0x7FFAC8654550
        public void get_IsAutoLayout(){} // RVA: 0x7FFAC8654580
        public void get_IsExplicitLayout(){} // RVA: 0x7FFAC86545B0
        public void get_IsLayoutSequential(){} // RVA: 0x7FFAC86545E0
        public void get_IsAnsiClass(){} // RVA: 0x7FFAC8654610
        public void get_IsAutoClass(){} // RVA: 0x7FFAC8654640
        public void get_IsUnicodeClass(){} // RVA: 0x7FFAC8654670
        public void get_IsCOMObject(){} // RVA: 0x7FFAC86546A0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsContextful(){} // RVA: 0x7FFAC86546C0
        public void IsContextfulImpl(){} // RVA: 0x7FFAC86546E0
        public void get_IsCollectible(){} // RVA: 0x7FFAC3006850
        public void get_IsEnum(){} // RVA: 0x7FFAC86547C0
        public void get_IsMarshalByRef(){} // RVA: 0x7FFAC86548A0
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFAC86548C0
        public void get_IsPrimitive(){} // RVA: 0x7FFAC86549A0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsValueType(){} // RVA: 0x7FFAC86549C0
        public void IsValueTypeImpl(){} // RVA: 0x7FFAC86549E0
        public void get_IsSignatureType(){} // RVA: 0x7FFAC2F21320
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAC8654AC0
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFAC8654AF0
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFAC8654B20
        public void GetConstructor(){} // RVA: 0x7FFAC8654BB0 | overloaded x3
        public void GetConstructorImpl(){}
        public void GetConstructors(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void GetEvent(){} // RVA: 0x7FFAC2C69DD0 | overloaded x2
        public void GetEvents(){} // RVA: 0x7FFAC2C67DE0
        public void GetField(){} // RVA: 0x7FFAC2C69DD0 | overloaded x2
        public void GetFields(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void GetMember(){} // RVA: 0x7FFAC8654E00 | overloaded x3
        public void GetMembers(){} // RVA: 0x7FFAC2C67DE0
        public void GetMethod(){} // RVA: 0x7FFAC8655030 | overloaded x6
        public void GetMethodImpl(){}
        public void GetMethods(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void GetNestedType(){} // RVA: 0x7FFAC2C69DD0 | overloaded x2
        public void GetProperty(){} // RVA: 0x7FFAC8655680 | overloaded x6
        public void GetPropertyImpl(){}
        public void GetProperties(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void get_TypeHandle(){} // RVA: 0x7FFAC8655790
        public void GetTypeHandle(){} // RVA: 0x7FFAC86557D0
        public void GetTypeArray(){} // RVA: 0x7FFAC8655860
        public void GetTypeCode(){} // RVA: 0x7FFAC86559E0
        public void GetTypeCodeImpl(){} // RVA: 0x7FFAC8655A50
        public void get_GUID(){} // RVA: 0x7FFAC2C588A0
        public void get_BaseType(){} // RVA: 0x7FFAC2C58E90
        public void InvokeMember(){}
        public void GetInterface(){} // RVA: 0x7FFAC2C696F0
        public void GetInterfaces(){} // RVA: 0x7FFAC2C58E90
        public void IsInstanceOfType(){} // RVA: 0x7FFAC8655BA0
        public void IsEquivalentTo(){} // RVA: 0x7FFAC8655BF0
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFAC8655C50
        public void GetEnumValues(){} // RVA: 0x7FFAC8655DA0
        public void MakeArrayType(){} // RVA: 0x7FFAC8655E90 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFAC8655ED0
        public void MakeGenericType(){} // RVA: 0x7FFAC8655F10
        public void MakePointerType(){} // RVA: 0x7FFAC8655F60
        public void MakeGenericSignatureType(){} // RVA: 0x7FFAC8655FA0
        public void ToString(){} // RVA: 0x7FFAC8656010
        public void Equals(){} // RVA: 0x7FFAC8656170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8656110
        public void get_DefaultBinder(){} // RVA: 0x7FFAC8656210
        public void GetTypeFromHandle(){} // RVA: 0x7FFAC8656340
        public void internal_from_handle(){} // RVA: 0x7FFAC86563B0
        public void get_IsSzArray(){} // RVA: 0x7FFAC2F21320
        public void FormatTypeName(){} // RVA: 0x7FFAC86563F0 | overloaded x2
        public void get_IsInterface(){} // RVA: 0x7FFAC8656430
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void get_FullNameOrDefault(){} // RVA: 0x7FFAC86568C0
        public void IsRuntimeImplemented(){} // RVA: 0x7FFAC8656950
        public void InternalGetNameIfAvailable(){} // RVA: 0x7FFAC30FEBD0
        public void get_InternalNameIfAvailable(){} // RVA: 0x7FFAC86569F0
        public void get_NameOrDefault(){} // RVA: 0x7FFAC8656A20
        public void .cctor(){} // RVA: 0x7FFAC8656A90
    }

    public class TypeAccessException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86135B0 | overloaded x2
    }

    public class TypeIdentifier
    {
        public object InternalName;

        // ── Methods ──
        public void get_InternalName(){} // RVA: 0x7FFAC2C58E90
    }

    public class TypeIdentifiers : Object
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x7FFAC86ACAF0
    }

    public class TypeInitializationException : SystemException
    {
        public string TypeName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8656FC0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAC86570D0
        public void get_TypeName(){} // RVA: 0x7FFAC86572D0
    }

    public class TypeLoadException : SystemException
    {
        public string Message; // 0x90
        public string AssemblyName; // 0x98
        public string MessageArg; // 0xA0
        public int ResourceId; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8690730 | overloaded x5
        public void get_Message(){} // RVA: 0x7FFAC8690130
        public void SetMessageField(){} // RVA: 0x7FFAC8690150
        public void GetObjectData(){} // RVA: 0x7FFAC86909C0
    }

    public class TypeName
    {
        public object DisplayName;

        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0x7FFAC2C58E90
    }

    public class TypeNameParser : Object
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFAC86976E0
    }

    public class TypeNames : Object
    {
    }

    public class TypeSpec : Object
    {
        public System.TypeIdentifier HasModifiers; // 0x10
        public string DisplayFullName; // 0x18
        public System.Collections.Generic.List`1<System.TypeIdentifier> nested; // 0x20
        public System.Collections.Generic.List`1<System.TypeSpec> generic_params; // 0x28
        public System.Collections.Generic.List`1<System.ModifierSpec> modifier_spec; // 0x30
        public bool is_byref; // 0x38
        public string display_fullname; // 0x40

        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x7FFAC781E0A0
        public void GetDisplayFullName(){} // RVA: 0x7FFAC86AD1B0
        public void GetModifierString(){} // RVA: 0x7FFAC86AD780
        public void get_DisplayFullName(){} // RVA: 0x7FFAC86ADA00
        public void Parse(){} // RVA: 0x7FFAC86AEB40 | overloaded x2
        public void UnescapeInternalName(){} // RVA: 0x7FFAC86ADB70
        public void Resolve(){} // RVA: 0x7FFAC86ADC70
        public void AddName(){} // RVA: 0x7FFAC86AE6D0
        public void AddModifier(){} // RVA: 0x7FFAC86AE8A0
        public void SkipSpace(){} // RVA: 0x7FFAC86AE9E0
        public void BoundCheck(){} // RVA: 0x7FFAC86AEAA0
        public void ParsedTypeIdentifier(){} // RVA: 0x7FFAC86AEB30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TypedReference : ValueType
    {
        public System.RuntimeTypeHandle IsNull; // 0x10
        public UIntPtr Value; // 0x18
        public UIntPtr Type; // 0x20

        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x7FFAC868F850
        public void InternalMakeTypedReference(){} // RVA: 0x7FFAC868FE90
        public void GetHashCode(){} // RVA: 0x7FFAC868FF60
        public void Equals(){} // RVA: 0x7FFAC868FFF0
        public void get_IsNull(){} // RVA: 0x7FFAC8690050
        public void SetTypedReference(){} // RVA: 0x7FFAC8690070
    }

}