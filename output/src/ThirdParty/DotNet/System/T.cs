// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 25
// Methods: 521

namespace ThirdParty.DotNet.System
{
    public class TermInfoDriver : Object
    {
        public int* native_terminal_size;
        public int terminal_size; // 0x8
        public string[] locations; // 0x10

        // ── Methods ──
        public void TryTermInfoDir(){} // RVA: 0x7FFE86A4DA20
        public void SearchTerminfo(){} // RVA: 0x7FFE86A4DCD0
        public void WriteConsole(){} // RVA: 0x7FFE86A4DE80
        public void .ctor(){} // RVA: 0x7FFE86A4DEB0
        public void get_Initialized(){} // RVA: 0x7FFE820E9360
        public void Init(){} // RVA: 0x7FFE86A4E730
        public void IncrementX(){} // RVA: 0x7FFE86A4F3B0
        public void WriteSpecialKey(){} // RVA: 0x7FFE86A4F640 | overloaded x2
        public void IsSpecialKey(){} // RVA: 0x7FFE86A4F7B0 | overloaded x2
        public void GetCursorPosition(){} // RVA: 0x7FFE86A4F800
        public void CheckWindowDimensions(){} // RVA: 0x7FFE86A4F8A0
        public void get_WindowHeight(){} // RVA: 0x7FFE86A4FA00
        public void get_WindowWidth(){} // RVA: 0x7FFE86A4FA30
        public void AddToBuffer(){} // RVA: 0x7FFE86A4FA60
        public void AdjustBuffer(){} // RVA: 0x7FFE86A4FC10
        public void CreateKeyInfoFromInt(){} // RVA: 0x7FFE86A4FC30
        public void GetKeyFromBuffer(){} // RVA: 0x7FFE86A4FD70
        public void ReadKeyInternal(){} // RVA: 0x7FFE86A500F0
        public void InputPending(){} // RVA: 0x7FFE86A502A0
        public void QueueEcho(){} // RVA: 0x7FFE86A502E0
        public void Echo(){} // RVA: 0x7FFE86A50420
        public void EchoFlush(){} // RVA: 0x7FFE86A505F0
        public void Read(){} // RVA: 0x7FFE86A50640
        public void ReadKey(){} // RVA: 0x7FFE86A50A10
        public void ReadLine(){} // RVA: 0x7FFE86A50AD0
        public void ReadToEnd(){} // RVA: 0x7FFE86A50AE0
        public void ReadUntilConditionInternal(){} // RVA: 0x7FFE86A50AF0
        public void SetCursorPosition(){} // RVA: 0x7FFE86A50E20
        public void CreateKeyMap(){} // RVA: 0x7FFE86A511B0
        public void InitKeys(){} // RVA: 0x7FFE86A52D20
        public void AddStringMapping(){} // RVA: 0x7FFE86A53020
        public void .cctor(){} // RVA: 0x7FFE86A53070
    }

    public class TermInfoReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A555D0 | overloaded x2
        public void DetermineVersion(){} // RVA: 0x7FFE86A556B0
        public void ReadHeader(){} // RVA: 0x7FFE86A55770
        public void ReadNames(){} // RVA: 0x7FFE86A559F0
        public void Get(){} // RVA: 0x7FFE86A55B60 | overloaded x2
        public void GetStringBytes(){} // RVA: 0x7FFE86A55F50 | overloaded x2
        public void GetInt16(){} // RVA: 0x7FFE86A55E60
        public void GetString(){} // RVA: 0x7FFE86A55EC0
    }

    public class ThreadStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFE86DFE4E0
        public void CreateArgumentNullException(){} // RVA: 0x7FFE86DFE510
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7FFE86DFE5D0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFE86DFE600
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFE86DFE680
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFE86DFE6B0
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7FFE86DFE7A0
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7FFE86DFE7D0
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFE86DFE8B0
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7FFE86DFE8E0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFE86DFEA10 | overloaded x2
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFE86DFEA40 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFE86DFEB00
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFE86DFEB30
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFE86DFEC60
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFE86DFEC90
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFE86DFED40
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFE86DFED70
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFE86DFEE50
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFE86DFEE80
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7FFE86DFEF20
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7FFE86DFEF50
        public void TryFormatThrowFormatException(){} // RVA: 0x7FFE86DFEFE0
        public void TryParseThrowFormatException(){} // RVA: 0x7FFE80E2F7A0
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7FFE86DFF000
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7FFE86DFF030
    }

    public class TimeProvider : Object
    {
        public System.TimeProvider _system;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetUtcNow(){} // RVA: 0x7FFE866C9760
        public void get_LocalTimeZone(){} // RVA: 0x7FFE866C9810
        public void .cctor(){} // RVA: 0x7FFE866C9860
    }

    public class TimeSpan : ValueType
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
        public void .ctor(){} // RVA: 0x7FFE869F8670 | overloaded x4
        public void get_Ticks(){} // RVA: 0x7FFE8284EF60
        public void get_Days(){} // RVA: 0x7FFE869F8730
        public void get_Hours(){} // RVA: 0x7FFE869F8750
        public void get_Milliseconds(){} // RVA: 0x7FFE869F8790
        public void get_Minutes(){} // RVA: 0x7FFE869F87E0
        public void get_Seconds(){} // RVA: 0x7FFE869F8830
        public void get_TotalDays(){} // RVA: 0x7FFE869F8880
        public void get_TotalHours(){} // RVA: 0x7FFE869F88A0
        public void get_TotalMilliseconds(){} // RVA: 0x7FFE869F88C0
        public void get_TotalMinutes(){} // RVA: 0x7FFE869F88F0
        public void get_TotalSeconds(){} // RVA: 0x7FFE869F8910
        public void Add(){} // RVA: 0x7FFE869F8930
        public void Compare(){} // RVA: 0x7FFE869F89B0
        public void CompareTo(){} // RVA: 0x7FFE869F8AB0 | overloaded x2
        public void FromDays(){} // RVA: 0x7FFE869F8AD0
        public void Duration(){} // RVA: 0x7FFE869F8B30
        public void Equals(){} // RVA: 0x7FFE835C1CA0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE869DAEC0
        public void FromHours(){} // RVA: 0x7FFE869F8C80
        public void Interval(){} // RVA: 0x7FFE869F8CE0
        public void FromMilliseconds(){} // RVA: 0x7FFE869F8DF0
        public void FromMinutes(){} // RVA: 0x7FFE869F8E50
        public void Negate(){} // RVA: 0x7FFE869F8EB0
        public void FromSeconds(){} // RVA: 0x7FFE869F8F60
        public void Subtract(){} // RVA: 0x7FFE869F8FC0
        public void FromTicks(){} // RVA: 0x7FFE827C4A80
        public void TimeToTicks(){} // RVA: 0x7FFE869F9040
        public void ValidateStyles(){} // RVA: 0x7FFE869F90E0
        public void Parse(){} // RVA: 0x7FFE869F91E0 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFE869F9630 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFE869F9860 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFE869F9D00 | overloaded x4
        public void ToString(){} // RVA: 0x7FFE869F9F50 | overloaded x3
        public void TryFormat(){} // RVA: 0x7FFE869F9FD0
        public void op_UnaryNegation(){} // RVA: 0x7FFE869FA110
        public void op_Subtraction(){} // RVA: 0x7FFE869FA1C0
        public void op_UnaryPlus(){} // RVA: 0x7FFE827C4A80
        public void op_Addition(){} // RVA: 0x7FFE869FA280
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void op_LessThan(){} // RVA: 0x7FFE869FA350
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE869FA360
        public void op_GreaterThan(){} // RVA: 0x7FFE869FA370
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE869FA380
        public void .cctor(){} // RVA: 0x7FFE869FA390
    }

    public class TimeZone : Object
    {
        public System.TimeZone currentTimeZone;
        public object s_InternalSyncObject; // 0x8

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFE869FA410
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_CurrentTimeZone(){} // RVA: 0x7FFE869FA4E0
        public void GetUtcOffset(){}
        public void GetDaylightChanges(){} // RVA: 0x7FFE80E3D230
        public void CalculateUtcOffset(){} // RVA: 0x7FFE869FA810
    }

    public class TimeZoneInfo : Object
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
        public void GetAdjustmentRules(){} // RVA: 0x7FFE8689AEA0
        public void PopulateAllSystemTimeZones(){} // RVA: 0x7FFE8689AF40
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x7FFE8689AFD0
        public void .ctor(){} // RVA: 0x7FFE868AC290 | overloaded x4
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x7FFE8689B770
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x7FFE8689FB00 | overloaded x2
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x7FFE8689BBD0
        public void GetLocalTimeZone(){} // RVA: 0x7FFE8689BDA0
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x7FFE8689C120
        public void FindSystemTimeZoneById(){} // RVA: 0x7FFE8689C250
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x7FFE8689C750
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x7FFE868A0130 | overloaded x2
        public void TryCreateAdjustmentRules(){} // RVA: 0x7FFE8689CB90
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x7FFE8689D7E0
        public void TryCompareStandardDate(){} // RVA: 0x7FFE8689D910
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x7FFE8689D990
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x7FFE8689DF50
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x7FFE8689E2D0
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x7FFE8689E6D0
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x7FFE868AB2B0 | overloaded x2
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x7FFE8689EE90
        public void get_HaveRegistry(){} // RVA: 0x7FFE8689F3D0
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x7FFE8689F450
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFE8689F5F0
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x7FFE8689F780
        public void GetTimeZoneInformationForYear(){} // RVA: 0x7FFE8689F940
        public void TryCreateTimeZone(){} // RVA: 0x7FFE868A0FD0
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x7FFE868A1A50
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x7FFE868A1DC0
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x7FFE868A2020
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void get_DisplayName(){} // RVA: 0x7FFE868A2830
        public void get_StandardName(){} // RVA: 0x7FFE868A2880
        public void get_DaylightName(){} // RVA: 0x7FFE868A28D0
        public void get_BaseUtcOffset(){} // RVA: 0x7FFE8144E200
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x7FFE812CF770
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x7FFE868A2D50 | overloaded x2
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x7FFE868A3220
        public void GetPreviousAdjustmentRule(){} // RVA: 0x7FFE868A32A0
        public void GetUtcOffset(){} // RVA: 0x7FFE868ABC60 | overloaded x6
        public void GetLocalUtcOffset(){} // RVA: 0x7FFE868A34E0
        public void IsAmbiguousTime(){} // RVA: 0x7FFE868A39E0 | overloaded x3
        public void IsDaylightSavingTime(){} // RVA: 0x7FFE868A3F30 | overloaded x4
        public void IsInvalidTime(){} // RVA: 0x7FFE868A4210
        public void ClearCachedData(){} // RVA: 0x7FFE868A44C0
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x7FFE868A4690 | overloaded x3
        public void ConvertTime(){} // RVA: 0x7FFE868A50B0 | overloaded x5
        public void ConvertTimeFromUtc(){} // RVA: 0x7FFE868A56E0
        public void ConvertTimeToUtc(){} // RVA: 0x7FFE868A5A00 | overloaded x3
        public void Equals(){} // RVA: 0x7FFE868A5B80 | overloaded x2
        public void FromSerializedString(){} // RVA: 0x7FFE868A5BE0
        public void GetHashCode(){} // RVA: 0x7FFE868A5CC0
        public void GetSystemTimeZones(){} // RVA: 0x7FFE868A5D70
        public void HasSameRules(){} // RVA: 0x7FFE868A62A0
        public void get_Local(){} // RVA: 0x7FFE868A6590
        public void ToSerializedString(){} // RVA: 0x7FFE868A6610
        public void ToString(){} // RVA: 0x7FFE868A2830
        public void get_Utc(){} // RVA: 0x7FFE868A6620
        public void CreateCustomTimeZone(){} // RVA: 0x7FFE868A6A20 | overloaded x3
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE868A6B50
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868A6D10
        public void GetAdjustmentRuleForTime(){} // RVA: 0x7FFE868A7540 | overloaded x2
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x7FFE868A77C0
        public void ConvertToUtc(){} // RVA: 0x7FFE868A7A10
        public void ConvertFromUtc(){} // RVA: 0x7FFE868A7A30
        public void ConvertToFromUtc(){} // RVA: 0x7FFE868A7A50
        public void ConvertUtcToTimeZone(){} // RVA: 0x7FFE868A7D10
        public void GetDaylightTime(){} // RVA: 0x7FFE868A8100
        public void GetIsDaylightSavings(){} // RVA: 0x7FFE868A8270
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x7FFE868A8870
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x7FFE868A8950
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x7FFE868A89E0
        public void CheckIsDst(){} // RVA: 0x7FFE868A94D0
        public void GetIsAmbiguousTime(){} // RVA: 0x7FFE868A9800
        public void GetIsInvalidTime(){} // RVA: 0x7FFE868A9BC0
        public void GetUtcOffsetFromUtc(){} // RVA: 0x7FFE868AA300 | overloaded x3
        public void TransitionTimeToDateTime(){} // RVA: 0x7FFE868AA670
        public void TryGetTimeZone(){} // RVA: 0x7FFE868AAFB0
        public void ValidateTimeZoneInfo(){} // RVA: 0x7FFE868AB780
        public void UtcOffsetOutOfRange(){} // RVA: 0x7FFE868ABB80
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x7FFE868ABD40
        public void .cctor(){} // RVA: 0x7FFE868ABE60
    }

    public class TimeZoneNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869FAC30 | overloaded x4
    }

    public class TimeoutException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class Tuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void CombineHashCodes(){} // RVA: 0x7FFE869FAD30 | overloaded x3
    }

    public class Tuple`2 : Object
    {
        public U m_Item1;
        public T m_Item2;
        public object m_Item1; // 0x10

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFE810A1420
        public void get_Item2(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFE80E32650
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFE80E38BF0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFE80E33B00
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFE80E2E390
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFE80E2EDB0
    }

    public class Tuple`3 : Object
    {
        public U m_Item1;
        public V m_Item2;
        public T m_Item3;
        public object field_3; // 0xD3

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFE810A1420
        public void get_Item2(){} // RVA: 0x7FFE810A1420
        public void get_Item3(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFE80E32650
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFE80E38BF0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFE80E33B00
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFE80E2E390
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFE80E2EDB0
    }

    public class Tuple`4 : Object
    {
        public U m_Item1;
        public V m_Item2;
        public W m_Item3;
        public T m_Item4;
        public object field_4; // 0xD7

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFE810A1420
        public void get_Item2(){} // RVA: 0x7FFE810A1420
        public void get_Item3(){} // RVA: 0x7FFE810A1420
        public void get_Item4(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFE80E32650
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFE80E38BF0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFE80E33B00
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFE80E2E390
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFE80E2EDB0
    }

    public class Type : MemberInfo
    {
        public System.Reflection.Binder s_defaultBinder;
        public char Delimiter; // 0x8
        public System.Type[] EmptyTypes; // 0x10
        public object Missing; // 0x18
        public System.Reflection.MemberFilter FilterAttribute; // 0x20
        public System.Reflection.MemberFilter FilterName; // 0x28
        public System.Reflection.MemberFilter FilterNameIgnoreCase; // 0x30
        public 0x664D16A4 DefaultLookup;
        public System.RuntimeTypeHandle _impl; // 0x10
        public string DefaultTypeNameWhenMissingMetadata;
        public UIntPtr value; // 0x10
        public object field_11; // 0xDC
        public object field_12; // 0xDD
        public object field_13; // 0xDE
        public object field_14; // 0xDF
        public object field_15; // 0xE0
        public object field_16; // 0xE1
        public object field_17; // 0xE2
        public object field_18; // 0xE3
        public object field_19; // 0xE4
        public object field_20; // 0xE5
        public object field_21; // 0xE6
        public object field_22; // 0xE7
        public object field_23; // 0xE8
        public object field_24; // 0xE9
        public object field_25; // 0xEA
        public object field_26; // 0xEB
        public object field_27; // 0xEC
        public object field_28; // 0xED
        public object field_29; // 0xEE
        public object field_30; // 0xEF
        public object field_31; // 0xF0
        public object field_32; // 0xF1
        public object field_33; // 0xF2
        public object field_34; // 0xF3
        public object field_35; // 0xF4
        public object field_36; // 0xF5
        public object field_37; // 0xF6
        public object field_38; // 0xF7
        public object field_39; // 0xF8
        public object field_40; // 0xF9
        public object field_41; // 0xFA
        public object field_42; // 0xFB
        public object field_43; // 0xFC
        public object field_44; // 0xFD
        public object field_45; // 0xFE
        public object field_46; // 0xFF
        public object field_47; // 0x100
        public object field_48; // 0x101
        public object field_49; // 0x102
        public object field_50; // 0x103
        public object field_51; // 0x104
        public object field_52; // 0x105
        public object field_53; // 0x106
        public object field_54; // 0x107
        public object field_55; // 0x108
        public object field_56; // 0x109
        public object field_57; // 0x10A
        public object field_58; // 0x10B
        public object field_59; // 0x10C
        public object field_60; // 0x10D
        public object field_61; // 0x10E
        public object field_62; // 0x10F
        public object field_63; // 0x110
        public object field_64; // 0x111
        public object field_65; // 0x112
        public object field_66; // 0x113
        public object field_67; // 0x114

        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x7FFE869FAD50
        public void GetEnumName(){} // RVA: 0x7FFE869FB390
        public void GetEnumNames(){} // RVA: 0x7FFE869FB780
        public void GetEnumRawConstantValues(){} // RVA: 0x7FFE869FB830
        public void GetEnumData(){} // RVA: 0x7FFE869FB860
        public void BinarySearch(){} // RVA: 0x7FFE869FBD10
        public void IsIntegerType(){} // RVA: 0x7FFE869FBED0
        public void get_IsSerializable(){} // RVA: 0x7FFE869FC1E0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE869FC3E0
        public void GetRootElementType(){} // RVA: 0x7FFE869FC540
        public void get_IsVisible(){} // RVA: 0x7FFE869FC5A0
        public void IsSubclassOf(){} // RVA: 0x7FFE869FC7A0
        public void IsAssignableFrom(){} // RVA: 0x7FFE869FC860
        public void ImplementInterface(){} // RVA: 0x7FFE869FCA40
        public void FilterAttributeImpl(){} // RVA: 0x7FFE869FCBA0
        public void FilterNameImpl(){} // RVA: 0x7FFE869FCF30
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x7FFE869FD1E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE835C28C0
        public void GetType(){} // RVA: 0x7FFE869FFF70 | overloaded x5
        public void get_Namespace(){} // RVA: 0x7FFE80E2E2E0
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFE80E2E2E0
        public void get_FullName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Assembly(){} // RVA: 0x7FFE80E2E2E0
        public void get_Module(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsNested(){} // RVA: 0x7FFE869FD5F0
        public void get_DeclaringType(){} // RVA: 0x7FFE813240E0
        public void get_DeclaringMethod(){} // RVA: 0x7FFE813240E0
        public void get_ReflectedType(){} // RVA: 0x7FFE813240E0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsArray(){} // RVA: 0x7FFE869FD660
        public void IsArrayImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsByRef(){} // RVA: 0x7FFE869FD680
        public void IsByRefImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsPointer(){} // RVA: 0x7FFE869FD6A0
        public void IsPointerImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE869FD6C0
        public void get_IsGenericParameter(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFE869FD6F0
        public void get_IsGenericType(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFE810FB320
        public void get_IsSZArray(){} // RVA: 0x7FFE869FD770
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE869FD7A0
        public void get_HasElementType(){} // RVA: 0x7FFE869FD7F0
        public void HasElementTypeImpl(){} // RVA: 0x7FFE80E2F150
        public void GetElementType(){} // RVA: 0x7FFE80E2E2E0
        public void GetArrayRank(){} // RVA: 0x7FFE869FD810
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE869FD860
        public void get_GenericTypeArguments(){} // RVA: 0x7FFE869FD8B0
        public void GetGenericArguments(){} // RVA: 0x7FFE869FD940
        public void get_GenericParameterPosition(){} // RVA: 0x7FFE869FD990
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFE869FD9E0
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFE869FDA20
        public void get_Attributes(){} // RVA: 0x7FFE869FDAC0
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsAbstract(){} // RVA: 0x7FFE869FDAE0
        public void get_IsImport(){} // RVA: 0x7FFE869FDB10
        public void get_IsSealed(){} // RVA: 0x7FFE869FDB40
        public void get_IsSpecialName(){} // RVA: 0x7FFE869FDB70
        public void get_IsClass(){} // RVA: 0x7FFE869FDBA0
        public void get_IsNestedAssembly(){} // RVA: 0x7FFE869FDBF0
        public void get_IsNestedFamANDAssem(){} // RVA: 0x7FFE869FDC20
        public void get_IsNestedFamily(){} // RVA: 0x7FFE869FDC50
        public void get_IsNestedFamORAssem(){} // RVA: 0x7FFE869FDC80
        public void get_IsNestedPrivate(){} // RVA: 0x7FFE869FDCB0
        public void get_IsNestedPublic(){} // RVA: 0x7FFE869FDCE0
        public void get_IsNotPublic(){} // RVA: 0x7FFE869FDD10
        public void get_IsPublic(){} // RVA: 0x7FFE869FDD40
        public void get_IsAutoLayout(){} // RVA: 0x7FFE869FDD70
        public void get_IsExplicitLayout(){} // RVA: 0x7FFE869FDDA0
        public void get_IsLayoutSequential(){} // RVA: 0x7FFE869FDDD0
        public void get_IsAnsiClass(){} // RVA: 0x7FFE869FDE00
        public void get_IsAutoClass(){} // RVA: 0x7FFE869FDE30
        public void get_IsUnicodeClass(){} // RVA: 0x7FFE869FDE60
        public void get_IsCOMObject(){} // RVA: 0x7FFE869FDE90
        public void IsCOMObjectImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsContextful(){} // RVA: 0x7FFE869FDEB0
        public void IsContextfulImpl(){} // RVA: 0x7FFE869FDED0
        public void get_IsCollectible(){} // RVA: 0x7FFE811E0850
        public void get_IsEnum(){} // RVA: 0x7FFE869FDFB0
        public void get_IsMarshalByRef(){} // RVA: 0x7FFE869FE090
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFE869FE0B0
        public void get_IsPrimitive(){} // RVA: 0x7FFE869FE190
        public void IsPrimitiveImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsValueType(){} // RVA: 0x7FFE869FE1B0
        public void IsValueTypeImpl(){} // RVA: 0x7FFE869FE1D0
        public void get_IsSignatureType(){} // RVA: 0x7FFE810FB320
        public void get_IsSecurityCritical(){} // RVA: 0x7FFE869FE2B0
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFE869FE2E0
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFE869FE310
        public void GetConstructor(){} // RVA: 0x7FFE869FE3A0 | overloaded x3
        public void GetConstructorImpl(){}
        public void GetConstructors(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void GetEvent(){} // RVA: 0x7FFE80E3F2F0 | overloaded x2
        public void GetEvents(){} // RVA: 0x7FFE80E3D230
        public void GetField(){} // RVA: 0x7FFE80E3F2F0 | overloaded x2
        public void GetFields(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void GetMember(){} // RVA: 0x7FFE869FE5F0 | overloaded x3
        public void GetMembers(){} // RVA: 0x7FFE80E3D230
        public void GetMethod(){} // RVA: 0x7FFE869FE820 | overloaded x6
        public void GetMethodImpl(){}
        public void GetMethods(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void GetNestedType(){} // RVA: 0x7FFE80E3F2F0 | overloaded x2
        public void GetProperty(){} // RVA: 0x7FFE869FEE70 | overloaded x6
        public void GetPropertyImpl(){}
        public void GetProperties(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void get_TypeHandle(){} // RVA: 0x7FFE869FEF80
        public void GetTypeHandle(){} // RVA: 0x7FFE869FEFC0
        public void GetTypeArray(){} // RVA: 0x7FFE869FF050
        public void GetTypeCode(){} // RVA: 0x7FFE869FF1D0
        public void GetTypeCodeImpl(){} // RVA: 0x7FFE869FF240
        public void get_GUID(){} // RVA: 0x7FFE80E2DCF0
        public void get_BaseType(){} // RVA: 0x7FFE80E2E2E0
        public void InvokeMember(){}
        public void GetInterface(){} // RVA: 0x7FFE80E3EBB0
        public void GetInterfaces(){} // RVA: 0x7FFE80E2E2E0
        public void IsInstanceOfType(){} // RVA: 0x7FFE869FF390
        public void IsEquivalentTo(){} // RVA: 0x7FFE869FF3E0
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFE869FF440
        public void GetEnumValues(){} // RVA: 0x7FFE869FF590
        public void MakeArrayType(){} // RVA: 0x7FFE869FF680 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFE869FF6C0
        public void MakeGenericType(){} // RVA: 0x7FFE869FF700
        public void MakePointerType(){} // RVA: 0x7FFE869FF750
        public void MakeGenericSignatureType(){} // RVA: 0x7FFE869FF790
        public void ToString(){} // RVA: 0x7FFE869FF800
        public void Equals(){} // RVA: 0x7FFE869FF960 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869FF900
        public void get_DefaultBinder(){} // RVA: 0x7FFE869FFA00
        public void GetTypeFromHandle(){} // RVA: 0x7FFE869FFB30
        public void internal_from_handle(){} // RVA: 0x7FFE869FFBA0
        public void get_IsSzArray(){} // RVA: 0x7FFE810FB320
        public void FormatTypeName(){} // RVA: 0x7FFE869FFBE0 | overloaded x2
        public void get_IsInterface(){} // RVA: 0x7FFE869FFC20
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void get_FullNameOrDefault(){} // RVA: 0x7FFE86A000B0
        public void IsRuntimeImplemented(){} // RVA: 0x7FFE86A00140
        public void InternalGetNameIfAvailable(){} // RVA: 0x7FFE81768340
        public void get_InternalNameIfAvailable(){} // RVA: 0x7FFE86A001E0
        public void get_NameOrDefault(){} // RVA: 0x7FFE86A00210
        public void .cctor(){} // RVA: 0x7FFE86A00280
    }

    public class TypeAccessException : TypeLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869BCD80 | overloaded x2
    }

    public class TypeIdentifier
    {
        // ── Methods ──
        public void get_InternalName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TypeIdentifiers : Object
    {
        // ── Methods ──
        public void FromDisplay(){} // RVA: 0x7FFE86A562A0
    }

    public class TypeInitializationException : SystemException
    {
        public string _typeName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A007B0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFE86A008C0
        public void get_TypeName(){} // RVA: 0x7FFE86A00AC0
    }

    public class TypeLoadException : SystemException
    {
        public string ClassName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A39F10 | overloaded x5
        public void get_Message(){} // RVA: 0x7FFE86A39910
        public void SetMessageField(){} // RVA: 0x7FFE86A39930
        public void GetObjectData(){} // RVA: 0x7FFE86A3A1A0
    }

    public class TypeName
    {
        // ── Methods ──
        public void get_DisplayName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class TypeNameParser : Object
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFE86A40EC0
    }

    public class TypeNames : Object
    {
    }

    public class TypeSpec : Object
    {
        public System.TypeIdentifier name; // 0x10
        public string assembly_name; // 0x18

        // ── Methods ──
        public void get_HasModifiers(){} // RVA: 0x7FFE85C00B10
        public void GetDisplayFullName(){} // RVA: 0x7FFE86A56960
        public void GetModifierString(){} // RVA: 0x7FFE86A56F30
        public void get_DisplayFullName(){} // RVA: 0x7FFE86A571B0
        public void Parse(){} // RVA: 0x7FFE86A582F0 | overloaded x2
        public void UnescapeInternalName(){} // RVA: 0x7FFE86A57320
        public void Resolve(){} // RVA: 0x7FFE86A57420
        public void AddName(){} // RVA: 0x7FFE86A57E80
        public void AddModifier(){} // RVA: 0x7FFE86A58050
        public void SkipSpace(){} // RVA: 0x7FFE86A58190
        public void BoundCheck(){} // RVA: 0x7FFE86A58250
        public void ParsedTypeIdentifier(){} // RVA: 0x7FFE86A582E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TypedReference : ValueType
    {
        public System.RuntimeTypeHandle type; // 0x10

        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x7FFE86A39030
        public void InternalMakeTypedReference(){} // RVA: 0x7FFE86A39670
        public void GetHashCode(){} // RVA: 0x7FFE86A39740
        public void Equals(){} // RVA: 0x7FFE86A397D0
        public void get_IsNull(){} // RVA: 0x7FFE86A39830
        public void SetTypedReference(){} // RVA: 0x7FFE86A39850
    }

}