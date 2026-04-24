// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 9
// Methods: 424

namespace ThirdParty.DotNet.System
{
    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x7FFD53E74E50
        public void CreateArgumentNullException(){} // RVA: 0x7FFD53E74E80
        public void ThrowArrayTypeMismatchException(){} // RVA: 0x7FFD53E74F40
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFD53E74F70
        public void ThrowArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFD53E74FF0
        public void CreateArgumentException_InvalidTypeWithPointersNotSupported(){} // RVA: 0x7FFD53E75020
        public void ThrowArgumentException_DestinationTooShort(){} // RVA: 0x7FFD53E75110
        public void CreateArgumentException_DestinationTooShort(){} // RVA: 0x7FFD53E75140
        public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFD53E75220
        public void CreateIndexOutOfRangeException(){} // RVA: 0x7FFD53E75250
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFD53E75380 | overloaded x2
        public void CreateArgumentOutOfRangeException(){} // RVA: 0x7FFD53E753B0 | overloaded x2
        public void ThrowArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFD53E75470
        public void CreateArgumentOutOfRangeException_PrecisionTooLarge(){} // RVA: 0x7FFD53E754A0
        public void ThrowArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFD53E755D0
        public void CreateArgumentOutOfRangeException_SymbolDoesNotFit(){} // RVA: 0x7FFD53E75600
        public void ThrowInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFD53E756B0
        public void CreateInvalidOperationException_EndPositionNotReached(){} // RVA: 0x7FFD53E756E0
        public void ThrowArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFD53E757C0
        public void CreateArgumentOutOfRangeException_PositionOutOfRange(){} // RVA: 0x7FFD53E757F0
        public void ThrowFormatException_BadFormatSpecifier(){} // RVA: 0x7FFD53E75890
        public void CreateFormatException_BadFormatSpecifier(){} // RVA: 0x7FFD53E758C0
        public void TryFormatThrowFormatException(){} // RVA: 0x7FFD53E75950
        public void TryParseThrowFormatException(){} // RVA: 0x7FFD4E07A350
        public void ThrowStartOrEndArgumentValidationException(){} // RVA: 0x7FFD53E75970
        public void CreateStartOrEndArgumentValidationException(){} // RVA: 0x7FFD53E759A0
    }

    public class TimeSpan : ValueType
    {
        public object Ticks;
        public object Days;
        public object Hours;
        public object Milliseconds;
        public object Minutes;
        public object Seconds;
        public object TotalDays;
        public object TotalHours;
        public object TotalMilliseconds;
        public object TotalMinutes;
        public object TotalSeconds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A6EE80 | overloaded x4
        public void get_Ticks(){} // RVA: 0x7FFD4EEF9F60
        public void get_Days(){} // RVA: 0x7FFD53A6EF40
        public void get_Hours(){} // RVA: 0x7FFD53A6EF60
        public void get_Milliseconds(){} // RVA: 0x7FFD53A6EFA0
        public void get_Minutes(){} // RVA: 0x7FFD53A6EFF0
        public void get_Seconds(){} // RVA: 0x7FFD53A6F040
        public void get_TotalDays(){} // RVA: 0x7FFD53A6F090
        public void get_TotalHours(){} // RVA: 0x7FFD53A6F0B0
        public void get_TotalMilliseconds(){} // RVA: 0x7FFD53A6F0D0
        public void get_TotalMinutes(){} // RVA: 0x7FFD53A6F100
        public void get_TotalSeconds(){} // RVA: 0x7FFD53A6F120
        public void Add(){} // RVA: 0x7FFD53A6F140
        public void Compare(){} // RVA: 0x7FFD53A6F1C0
        public void CompareTo(){} // RVA: 0x7FFD53A6F2C0 | overloaded x2
        public void FromDays(){} // RVA: 0x7FFD53A6F2E0
        public void Duration(){} // RVA: 0x7FFD53A6F340
        public void Equals(){} // RVA: 0x7FFD5072B460 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD53A516F0
        public void FromHours(){} // RVA: 0x7FFD53A6F490
        public void Interval(){} // RVA: 0x7FFD53A6F4F0
        public void FromMilliseconds(){} // RVA: 0x7FFD53A6F600
        public void FromMinutes(){} // RVA: 0x7FFD53A6F660
        public void Negate(){} // RVA: 0x7FFD53A6F6C0
        public void FromSeconds(){} // RVA: 0x7FFD53A6F770
        public void Subtract(){} // RVA: 0x7FFD53A6F7D0
        public void FromTicks(){} // RVA: 0x7FFD4F9181E0
        public void TimeToTicks(){} // RVA: 0x7FFD53A6F850
        public void ValidateStyles(){} // RVA: 0x7FFD53A6F8F0
        public void Parse(){} // RVA: 0x7FFD53A6F9F0 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFD53A6FE40 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFD53A70070 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFD53A70510 | overloaded x4
        public void ToString(){} // RVA: 0x7FFD53A70760 | overloaded x3
        public void TryFormat(){} // RVA: 0x7FFD53A707E0
        public void op_UnaryNegation(){} // RVA: 0x7FFD53A70920
        public void op_Subtraction(){} // RVA: 0x7FFD53A709D0
        public void op_UnaryPlus(){} // RVA: 0x7FFD4F9181E0
        public void op_Addition(){} // RVA: 0x7FFD53A70A90
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD53A70B50
        public void op_LessThan(){} // RVA: 0x7FFD53A70B60
        public void op_LessThanOrEqual(){} // RVA: 0x7FFD53A70B70
        public void op_GreaterThan(){} // RVA: 0x7FFD53A70B80
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFD53A70B90
        public void .cctor(){} // RVA: 0x7FFD53A70BA0
    }

    public class TimeZoneInfo : Object
    {
        public object HaveRegistry;
        public object Id;
        public object DisplayName;
        public object StandardName;
        public object DaylightName;
        public object BaseUtcOffset;
        public object SupportsDaylightSavingTime;
        public object Local;
        public object Utc;

        // ── Methods ──
        public void GetAdjustmentRules(){} // RVA: 0x7FFD539116A0
        public void PopulateAllSystemTimeZones(){} // RVA: 0x7FFD53911740
        public void PopulateAllSystemTimeZonesFromRegistry(){} // RVA: 0x7FFD539117D0
        public void .ctor(){} // RVA: 0x7FFD53922A90 | overloaded x4
        public void CheckDaylightSavingTimeNotSupported(){} // RVA: 0x7FFD53911F70
        public void CreateAdjustmentRuleFromTimeZoneInformation(){} // RVA: 0x7FFD53916300 | overloaded x2
        public void FindIdFromTimeZoneInformation(){} // RVA: 0x7FFD539123D0
        public void GetLocalTimeZone(){} // RVA: 0x7FFD539125A0
        public void GetLocalTimeZoneFromWin32Data(){} // RVA: 0x7FFD53912920
        public void FindSystemTimeZoneById(){} // RVA: 0x7FFD53912A50
        public void GetDateTimeNowUtcOffsetFromUtc(){} // RVA: 0x7FFD53912F50
        public void TransitionTimeFromTimeZoneInformation(){} // RVA: 0x7FFD53916930 | overloaded x2
        public void TryCreateAdjustmentRules(){} // RVA: 0x7FFD53913390
        public void TryGetTimeZoneEntryFromRegistry(){} // RVA: 0x7FFD53913FE0
        public void TryCompareStandardDate(){} // RVA: 0x7FFD53914110
        public void TryCompareTimeZoneInformationToRegistry(){} // RVA: 0x7FFD53914190
        public void TryGetLocalizedNameByMuiNativeResource(){} // RVA: 0x7FFD53914750
        public void TryGetLocalizedNameByNativeResource(){} // RVA: 0x7FFD53914AD0
        public void GetLocalizedNamesByRegistryKey(){} // RVA: 0x7FFD53914ED0
        public void TryGetTimeZoneFromLocalMachine(){} // RVA: 0x7FFD53921AB0 | overloaded x2
        public void TryGetTimeZoneFromLocalRegistry(){} // RVA: 0x7FFD53915690
        public void get_HaveRegistry(){} // RVA: 0x7FFD53915BD0
        public void EnumDynamicTimeZoneInformation(){} // RVA: 0x7FFD53915C50
        public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFD53915DF0
        public void GetDynamicTimeZoneInformationEffectiveYears(){} // RVA: 0x7FFD53915F80
        public void GetTimeZoneInformationForYear(){} // RVA: 0x7FFD53916140
        public void TryCreateTimeZone(){} // RVA: 0x7FFD539177D0
        public void GetLocalTimeZoneInfoWinRTFallback(){} // RVA: 0x7FFD53918250
        public void FindSystemTimeZoneByIdWinRTFallback(){} // RVA: 0x7FFD539185C0
        public void GetSystemTimeZonesWinRTFallback(){} // RVA: 0x7FFD53918820
        public void get_Id(){} // RVA: 0x7FFD4E35C380
        public void get_DisplayName(){} // RVA: 0x7FFD53919030
        public void get_StandardName(){} // RVA: 0x7FFD53919080
        public void get_DaylightName(){} // RVA: 0x7FFD539190D0
        public void get_BaseUtcOffset(){} // RVA: 0x7FFD4E5F95E0
        public void get_SupportsDaylightSavingTime(){} // RVA: 0x7FFD4E5F95D0
        public void GetAmbiguousTimeOffsets(){} // RVA: 0x7FFD53919550 | overloaded x2
        public void GetAdjustmentRuleForAmbiguousOffsets(){} // RVA: 0x7FFD53919A20
        public void GetPreviousAdjustmentRule(){} // RVA: 0x7FFD53919AA0
        public void GetUtcOffset(){} // RVA: 0x7FFD53922460 | overloaded x6
        public void GetLocalUtcOffset(){} // RVA: 0x7FFD53919CE0
        public void IsAmbiguousTime(){} // RVA: 0x7FFD5391A1E0 | overloaded x3
        public void IsDaylightSavingTime(){} // RVA: 0x7FFD5391A730 | overloaded x4
        public void IsInvalidTime(){} // RVA: 0x7FFD5391AA10
        public void ClearCachedData(){} // RVA: 0x7FFD5391ACC0
        public void ConvertTimeBySystemTimeZoneId(){} // RVA: 0x7FFD5391AE90 | overloaded x3
        public void ConvertTime(){} // RVA: 0x7FFD5391B8B0 | overloaded x5
        public void ConvertTimeFromUtc(){} // RVA: 0x7FFD5391BEE0
        public void ConvertTimeToUtc(){} // RVA: 0x7FFD5391C200 | overloaded x3
        public void Equals(){} // RVA: 0x7FFD5391C380 | overloaded x2
        public void FromSerializedString(){} // RVA: 0x7FFD5391C3E0
        public void GetHashCode(){} // RVA: 0x7FFD5391C4C0
        public void GetSystemTimeZones(){} // RVA: 0x7FFD5391C570
        public void HasSameRules(){} // RVA: 0x7FFD5391CAA0
        public void get_Local(){} // RVA: 0x7FFD5391CD90
        public void ToSerializedString(){} // RVA: 0x7FFD5391CE10
        public void ToString(){} // RVA: 0x7FFD53919030
        public void get_Utc(){} // RVA: 0x7FFD5391CE20
        public void CreateCustomTimeZone(){} // RVA: 0x7FFD5391D220 | overloaded x3
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD5391D350
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD5391D510
        public void GetAdjustmentRuleForTime(){} // RVA: 0x7FFD5391DD40 | overloaded x2
        public void CompareAdjustmentRuleToDateTime(){} // RVA: 0x7FFD5391DFC0
        public void ConvertToUtc(){} // RVA: 0x7FFD5391E210
        public void ConvertFromUtc(){} // RVA: 0x7FFD5391E230
        public void ConvertToFromUtc(){} // RVA: 0x7FFD5391E250
        public void ConvertUtcToTimeZone(){} // RVA: 0x7FFD5391E510
        public void GetDaylightTime(){} // RVA: 0x7FFD5391E900
        public void GetIsDaylightSavings(){} // RVA: 0x7FFD5391EA70
        public void GetDaylightSavingsStartOffsetFromUtc(){} // RVA: 0x7FFD5391F070
        public void GetDaylightSavingsEndOffsetFromUtc(){} // RVA: 0x7FFD5391F150
        public void GetIsDaylightSavingsFromUtc(){} // RVA: 0x7FFD5391F1E0
        public void CheckIsDst(){} // RVA: 0x7FFD5391FCD0
        public void GetIsAmbiguousTime(){} // RVA: 0x7FFD53920000
        public void GetIsInvalidTime(){} // RVA: 0x7FFD539203C0
        public void GetUtcOffsetFromUtc(){} // RVA: 0x7FFD53920B00 | overloaded x3
        public void TransitionTimeToDateTime(){} // RVA: 0x7FFD53920E70
        public void TryGetTimeZone(){} // RVA: 0x7FFD539217B0
        public void ValidateTimeZoneInfo(){} // RVA: 0x7FFD53921F80
        public void UtcOffsetOutOfRange(){} // RVA: 0x7FFD53922380
        public void IsValidAdjustmentRuleOffest(){} // RVA: 0x7FFD53922540
        public void .cctor(){} // RVA: 0x7FFD53922660
    }

    public class Tuple : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void CombineHashCodes(){} // RVA: 0x7FFD53A71540 | overloaded x3
    }

    public class Tuple`2 : Object
    {
        public object Item1;
        public object Item2;
        public object System.Runtime.CompilerServices.ITuple.Length;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item2(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFD4E07D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFD4E0837A0
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFD4E07E6B0
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFD4E078F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class Tuple`3 : Object
    {
        public object Item1;
        public object Item2;
        public object Item3;
        public object System.Runtime.CompilerServices.ITuple.Length;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item2(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item3(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFD4E07D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFD4E0837A0
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFD4E07E6B0
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFD4E078F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class Tuple`4 : Object
    {
        public object Item1;
        public object Item2;
        public object Item3;
        public object Item4;
        public object System.Runtime.CompilerServices.ITuple.Length;

        // ── Methods ──
        public void get_Item1(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item2(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item3(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item4(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFD4E07D200
        public void System.IComparable.CompareTo(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFD4E0837A0
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFD4E07E6B0
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void System.ITupleInternal.ToString(){} // RVA: 0x7FFD4E078F40
        public void System.Runtime.CompilerServices.ITuple.get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class Type : MemberInfo
    {
        public m.? IsSerializable;
        public char ContainsGenericParameters; // 0x8
        public ?[] IsVisible; // 0x10
        public object MemberType; // 0x18
        public m.UInt32 Namespace; // 0x20
        public m.UInt32 AssemblyQualifiedName; // 0x28
        public m.UInt32 FullName; // 0x30
        public m.unt Assembly;
        public d Module; // 0x10
        public string IsNested;

        // ── Methods ──
        public void IsEnumDefined(){} // RVA: 0x7FFD53A71560
        public void GetEnumName(){} // RVA: 0x7FFD53A71BA0
        public void GetEnumNames(){} // RVA: 0x7FFD53A71F90
        public void GetEnumRawConstantValues(){} // RVA: 0x7FFD53A72040
        public void GetEnumData(){} // RVA: 0x7FFD53A72070
        public void BinarySearch(){} // RVA: 0x7FFD53A72520
        public void IsIntegerType(){} // RVA: 0x7FFD53A726E0
        public void get_IsSerializable(){} // RVA: 0x7FFD53A729F0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFD53A72BF0
        public void GetRootElementType(){} // RVA: 0x7FFD53A72D50
        public void get_IsVisible(){} // RVA: 0x7FFD53A72DB0
        public void IsSubclassOf(){} // RVA: 0x7FFD53A72FB0
        public void IsAssignableFrom(){} // RVA: 0x7FFD53A73070
        public void ImplementInterface(){} // RVA: 0x7FFD53A73250
        public void FilterAttributeImpl(){} // RVA: 0x7FFD53A733B0
        public void FilterNameImpl(){} // RVA: 0x7FFD53A73740
        public void FilterNameIgnoreCaseImpl(){} // RVA: 0x7FFD53A739F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD5072BFF0
        public void GetType(){} // RVA: 0x7FFD53A76780 | overloaded x5
        public void get_Namespace(){} // RVA: 0x7FFD4E078E90
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFD4E078E90
        public void get_FullName(){} // RVA: 0x7FFD4E078E90
        public void get_Assembly(){} // RVA: 0x7FFD4E078E90
        public void get_Module(){} // RVA: 0x7FFD4E078E90
        public void get_IsNested(){} // RVA: 0x7FFD53A73E00
        public void get_DeclaringType(){} // RVA: 0x7FFD4E919180
        public void get_DeclaringMethod(){} // RVA: 0x7FFD4E919180
        public void get_ReflectedType(){} // RVA: 0x7FFD4E919180
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFD4E078E90
        public void get_IsArray(){} // RVA: 0x7FFD53A73E70
        public void IsArrayImpl(){} // RVA: 0x7FFD4E079D00
        public void get_IsByRef(){} // RVA: 0x7FFD53A73E90
        public void IsByRefImpl(){} // RVA: 0x7FFD4E079D00
        public void get_IsPointer(){} // RVA: 0x7FFD53A73EB0
        public void IsPointerImpl(){} // RVA: 0x7FFD4E079D00
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFD53A73ED0
        public void get_IsGenericParameter(){} // RVA: 0x7FFD4E341320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFD53A73F00
        public void get_IsGenericType(){} // RVA: 0x7FFD4E341320
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFD4E341320
        public void get_IsSZArray(){} // RVA: 0x7FFD53A73F80
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFD53A73FB0
        public void get_HasElementType(){} // RVA: 0x7FFD53A74000
        public void HasElementTypeImpl(){} // RVA: 0x7FFD4E079D00
        public void GetElementType(){} // RVA: 0x7FFD4E078E90
        public void GetArrayRank(){} // RVA: 0x7FFD53A74020
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFD53A74070
        public void get_GenericTypeArguments(){} // RVA: 0x7FFD53A740C0
        public void GetGenericArguments(){} // RVA: 0x7FFD53A74150
        public void get_GenericParameterPosition(){} // RVA: 0x7FFD53A741A0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFD53A741F0
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFD53A74230
        public void get_Attributes(){} // RVA: 0x7FFD53A742D0
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFD4E079960
        public void get_IsAbstract(){} // RVA: 0x7FFD53A742F0
        public void get_IsImport(){} // RVA: 0x7FFD53A74320
        public void get_IsSealed(){} // RVA: 0x7FFD53A74350
        public void get_IsSpecialName(){} // RVA: 0x7FFD53A74380
        public void get_IsClass(){} // RVA: 0x7FFD53A743B0
        public void get_IsNestedAssembly(){} // RVA: 0x7FFD53A74400
        public void get_IsNestedFamANDAssem(){} // RVA: 0x7FFD53A74430
        public void get_IsNestedFamily(){} // RVA: 0x7FFD53A74460
        public void get_IsNestedFamORAssem(){} // RVA: 0x7FFD53A74490
        public void get_IsNestedPrivate(){} // RVA: 0x7FFD53A744C0
        public void get_IsNestedPublic(){} // RVA: 0x7FFD53A744F0
        public void get_IsNotPublic(){} // RVA: 0x7FFD53A74520
        public void get_IsPublic(){} // RVA: 0x7FFD53A74550
        public void get_IsAutoLayout(){} // RVA: 0x7FFD53A74580
        public void get_IsExplicitLayout(){} // RVA: 0x7FFD53A745B0
        public void get_IsLayoutSequential(){} // RVA: 0x7FFD53A745E0
        public void get_IsAnsiClass(){} // RVA: 0x7FFD53A74610
        public void get_IsAutoClass(){} // RVA: 0x7FFD53A74640
        public void get_IsUnicodeClass(){} // RVA: 0x7FFD53A74670
        public void get_IsCOMObject(){} // RVA: 0x7FFD53A746A0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFD4E079D00
        public void get_IsContextful(){} // RVA: 0x7FFD53A746C0
        public void IsContextfulImpl(){} // RVA: 0x7FFD53A746E0
        public void get_IsCollectible(){} // RVA: 0x7FFD4E426850
        public void get_IsEnum(){} // RVA: 0x7FFD53A747C0
        public void get_IsMarshalByRef(){} // RVA: 0x7FFD53A748A0
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFD53A748C0
        public void get_IsPrimitive(){} // RVA: 0x7FFD53A749A0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFD4E079D00
        public void get_IsValueType(){} // RVA: 0x7FFD53A749C0
        public void IsValueTypeImpl(){} // RVA: 0x7FFD53A749E0
        public void get_IsSignatureType(){} // RVA: 0x7FFD4E341320
        public void get_IsSecurityCritical(){} // RVA: 0x7FFD53A74AC0
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFD53A74AF0
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFD53A74B20
        public void GetConstructor(){} // RVA: 0x7FFD53A74BB0 | overloaded x3
        public void GetConstructorImpl(){}
        public void GetConstructors(){} // RVA: 0x7FFD4E087DE0 | overloaded x2
        public void GetEvent(){} // RVA: 0x7FFD4E089DD0 | overloaded x2
        public void GetEvents(){} // RVA: 0x7FFD4E087DE0
        public void GetField(){} // RVA: 0x7FFD4E089DD0 | overloaded x2
        public void GetFields(){} // RVA: 0x7FFD4E087DE0 | overloaded x2
        public void GetMember(){} // RVA: 0x7FFD53A74E00 | overloaded x3
        public void GetMembers(){} // RVA: 0x7FFD4E087DE0
        public void GetMethod(){} // RVA: 0x7FFD53A75030 | overloaded x6
        public void GetMethodImpl(){}
        public void GetMethods(){} // RVA: 0x7FFD4E087DE0 | overloaded x2
        public void GetNestedType(){} // RVA: 0x7FFD4E089DD0 | overloaded x2
        public void GetProperty(){} // RVA: 0x7FFD53A75680 | overloaded x6
        public void GetPropertyImpl(){}
        public void GetProperties(){} // RVA: 0x7FFD4E087DE0 | overloaded x2
        public void get_TypeHandle(){} // RVA: 0x7FFD53A75790
        public void GetTypeHandle(){} // RVA: 0x7FFD53A757D0
        public void GetTypeArray(){} // RVA: 0x7FFD53A75860
        public void GetTypeCode(){} // RVA: 0x7FFD53A759E0
        public void GetTypeCodeImpl(){} // RVA: 0x7FFD53A75A50
        public void get_GUID(){} // RVA: 0x7FFD4E0788A0
        public void get_BaseType(){} // RVA: 0x7FFD4E078E90
        public void InvokeMember(){}
        public void GetInterface(){} // RVA: 0x7FFD4E0896F0
        public void GetInterfaces(){} // RVA: 0x7FFD4E078E90
        public void IsInstanceOfType(){} // RVA: 0x7FFD53A75BA0
        public void IsEquivalentTo(){} // RVA: 0x7FFD53A75BF0
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFD53A75C50
        public void GetEnumValues(){} // RVA: 0x7FFD53A75DA0
        public void MakeArrayType(){} // RVA: 0x7FFD53A75E90 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFD53A75ED0
        public void MakeGenericType(){} // RVA: 0x7FFD53A75F10
        public void MakePointerType(){} // RVA: 0x7FFD53A75F60
        public void MakeGenericSignatureType(){} // RVA: 0x7FFD53A75FA0
        public void ToString(){} // RVA: 0x7FFD53A76010
        public void Equals(){} // RVA: 0x7FFD53A76170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A76110
        public void get_DefaultBinder(){} // RVA: 0x7FFD53A76210
        public void GetTypeFromHandle(){} // RVA: 0x7FFD53A76340
        public void internal_from_handle(){} // RVA: 0x7FFD53A763B0
        public void get_IsSzArray(){} // RVA: 0x7FFD4E341320
        public void FormatTypeName(){} // RVA: 0x7FFD53A763F0 | overloaded x2
        public void get_IsInterface(){} // RVA: 0x7FFD53A76430
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD53A70B50
        public void get_FullNameOrDefault(){} // RVA: 0x7FFD53A768C0
        public void IsRuntimeImplemented(){} // RVA: 0x7FFD53A76950
        public void InternalGetNameIfAvailable(){} // RVA: 0x7FFD4E51EBD0
        public void get_InternalNameIfAvailable(){} // RVA: 0x7FFD53A769F0
        public void get_NameOrDefault(){} // RVA: 0x7FFD53A76A20
        public void .cctor(){} // RVA: 0x7FFD53A76A90
    }

    public class TypedReference : ValueType
    {
        public d IsNull; // 0x10
        public UIntPtr Value; // 0x18
        public UIntPtr Type; // 0x20

        // ── Methods ──
        public void MakeTypedReference(){} // RVA: 0x7FFD53AAF850
        public void InternalMakeTypedReference(){} // RVA: 0x7FFD53AAFE90
        public void GetHashCode(){} // RVA: 0x7FFD53AAFF60
        public void Equals(){} // RVA: 0x7FFD53AAFFF0
        public void get_IsNull(){} // RVA: 0x7FFD53AB0050
        public void SetTypedReference(){} // RVA: 0x7FFD53AB0070
    }

}