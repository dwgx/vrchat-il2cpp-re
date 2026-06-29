// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 41
// Methods: 824

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE30F0
        public void Encode(){} // RVA: 0x7ADBE3120
        public void EncodeDigit(){} // RVA: 0x7ADBE35E0
        public void DecodeDigit(){} // RVA: 0x7ADBE3600
        public void Adapt(){} // RVA: 0x7ADBE3630
        public void Decode(){} // RVA: 0x7ADBE36B0
    }

    public class Calendar : Object
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBB6EB0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBB6F10
        public void .ctor(){} // RVA: 0x7ADBB6F70
        public void get_ID(){} // RVA: 0x7A85193D0
        public void get_BaseCalendarID(){} // RVA: 0x7A9AA40B0
        public void get_AlgorithmType(){} // RVA: 0x7A82D1450
        public void get_IsReadOnly(){} // RVA: 0x7A8227C00
        public void Clone(){} // RVA: 0x7ADBB6F80
        public void ReadOnly(){} // RVA: 0x7ADBB7000
        public void VerifyWritable(){} // RVA: 0x7ADBB70E0
        public void SetReadOnlyState(){} // RVA: 0x7A8227C10
        public void get_CurrentEraValue(){} // RVA: 0x7ADBB7160
        public void CheckAddResult(){} // RVA: 0x7ADBB71F0
        public void AddMonths(){} // RVA: 0x7A7E06460
        public void AddYears(){} // RVA: 0x7A7E06460
        public void GetDayOfMonth(){} // RVA: 0x7A7E07480
        public void GetDayOfWeek(){} // RVA: 0x7A7E07480
        public void GetDayOfYear(){} // RVA: 0x7A7E07480
        public void GetDaysInMonth(){} // RVA: 0x7A7E07F10
        public void GetDaysInYear(){} // RVA: 0x7A7E076F0
        public void GetEra(){} // RVA: 0x7A7E07480
        public void get_Eras(){} // RVA: 0x7A7E00680
        public void GetMonth(){} // RVA: 0x7A7E07480
        public void GetMonthsInYear(){} // RVA: 0x7A7E076F0
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7ADBB7400
        public void GetWeekOfYearFullDays(){} // RVA: 0x7ADBB74C0
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7ADBB7830
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7ADBB79A0
        public void GetWeekOfYear(){} // RVA: 0x7ADBB79B0
        public void GetYear(){} // RVA: 0x7A7E07480
        public void IsLeapDay(){} // RVA: 0x7A7E02B30
        public void IsLeapMonth(){} // RVA: 0x7A7E02AD0
        public void GetLeapMonth(){} // RVA: 0x7ADBB7CE0
        public void IsLeapYear(){} // RVA: 0x7A7E01C20
        public void ToDateTime(){} // RVA: 0x7A7E065B0
        public void TryToDateTime(){} // RVA: 0x7ADBB7E20
        public void IsValidYear(){} // RVA: 0x7ADBB7F20
        public void IsValidMonth(){} // RVA: 0x7ADBB7FB0
        public void IsValidDay(){} // RVA: 0x7ADBB8030
        public void get_TwoDigitYearMax(){} // RVA: 0x7A83782A0
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBB80C0
        public void ToFourDigitYear(){} // RVA: 0x7ADBB80F0
        public void TimeToTicks(){} // RVA: 0x7ADBB8200
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7ADBB83E0
    }

    public class CalendarData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBB9780
        public void .cctor(){} // RVA: 0x7ADBB8440
        public void InitializeEraNames(){} // RVA: 0x7ADBBA620
        public void GetJapaneseEraNames(){} // RVA: 0x7ADBBAB30
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7ADBBAD60
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7ADBBAF90
        public void GetCalendarData(){} // RVA: 0x7ADBBB3E0
        public void CalendarIdToCultureName(){} // RVA: 0x7ADBBB610
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7A85193D0
        public void nativeGetCalendarData(){} // RVA: 0x7ADBBB7E0
        public void fill_calendar_data(){} // RVA: 0x7ADBBB980
    }

    public class CalendarData[] : Array
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

    public class CalendarId[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DC5C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EB50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6000
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA299010
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EB50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CharUnicodeInfo : Object
    {
        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x7ADB99830
        public void InternalGetNumericValue(){} // RVA: 0x7ADB998E0
        public void GetNumericValue(){} // RVA: 0x7ADB99AC0
        public void GetUnicodeCategory(){} // RVA: 0x7ADB99CF0
        public void InternalGetCategoryValue(){} // RVA: 0x7ADB99E70
        public void InternalGetUnicodeCategory(){} // RVA: 0x7ADB9A0A0
        public void IsWhiteSpace(){} // RVA: 0x7ADB9A220
        public void get_CategoryLevel1Index(){} // RVA: 0x7ADB9A240
        public void get_CategoryLevel2Index(){} // RVA: 0x7ADB9A2A0
        public void get_CategoryLevel3Index(){} // RVA: 0x7ADB9A300
        public void get_CategoriesValue(){} // RVA: 0x7ADB9A360
        public void get_NumericLevel1Index(){} // RVA: 0x7ADB9A3C0
        public void get_NumericLevel2Index(){} // RVA: 0x7ADB9A420
        public void get_NumericLevel3Index(){} // RVA: 0x7ADB9A480
        public void get_NumericValues(){} // RVA: 0x7ADB9A4E0
    }

    public class CodePageDataItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBCDEA0
        public void CreateString(){} // RVA: 0x7ADBCDF60
        public void get_WebName(){} // RVA: 0x7ADBCE0B0
        public void get_HeaderName(){} // RVA: 0x7ADBCE1D0
        public void get_BodyName(){} // RVA: 0x7ADBCE300
        public void .cctor(){} // RVA: 0x7ADBCE430
    }

    public class CompareInfo : Object
    {
        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7ADB9A540
        public void InvariantLastIndexOf(){} // RVA: 0x7ADB9A610
        public void InvariantFindString(){} // RVA: 0x7ADB9A6F0
        public void InvariantToUpper(){} // RVA: 0x7ADB9AAE0
        public void InvariantCreateSortKey(){} // RVA: 0x7ADB9AB00
        public void .ctor(){} // RVA: 0x7ADBA0670
        public void GetCompareInfo(){} // RVA: 0x7ADB9AEC0
        public void OnDeserializing(){} // RVA: 0x7AD51EC30
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ADB9AF80
        public void OnDeserialized(){} // RVA: 0x7ADB9AF90
        public void OnSerializing(){} // RVA: 0x7ADB9B0E0
        public void get_Name(){} // RVA: 0x7ADB9B180
        public void Compare(){} // RVA: 0x7ADB9BCD0
        public void CompareOptionNone(){} // RVA: 0x7ADB9BA40
        public void CompareOptionIgnoreCase(){} // RVA: 0x7ADB9BBA0
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7ADB9C420
        public void IsPrefix(){} // RVA: 0x7ADB9CA50
        public void IsSuffix(){} // RVA: 0x7ADB9CDD0
        public void IndexOf(){} // RVA: 0x7ADB9D8B0
        public void IndexOfOrdinal(){} // RVA: 0x7ADB9DA10
        public void LastIndexOf(){} // RVA: 0x7ADB9DC60
        public void LastIndexOfOrdinal(){} // RVA: 0x7ADB9E040
        public void GetSortKey(){} // RVA: 0x7ADB9E210
        public void Equals(){} // RVA: 0x7ADB9E390
        public void GetHashCode(){} // RVA: 0x7ADB9EA40
        public void GetIgnoreCaseHash(){} // RVA: 0x7ADB9E4C0
        public void GetHashCodeOfString(){} // RVA: 0x7ADB9E870
        public void ToString(){} // RVA: 0x7ADB9EB50
        public void get_UseManagedCollation(){} // RVA: 0x7ADB9EBB0
        public void GetCollator(){} // RVA: 0x7ADB9ED20
        public void CreateSortKeyCore(){} // RVA: 0x7ADB9F160
        public void internal_index_switch(){} // RVA: 0x7ADB9F400
        public void internal_compare_switch(){} // RVA: 0x7ADB9F680
        public void internal_compare_managed(){} // RVA: 0x7ADB9F880
        public void internal_index_managed(){} // RVA: 0x7ADB9F980
        public void internal_compare_icall(){} // RVA: 0x7ADB9FA30
        public void internal_compare(){} // RVA: 0x7ADB9FA40
        public void internal_index_icall(){} // RVA: 0x7ADB9FAF0
        public void internal_index(){} // RVA: 0x7ADB9FBE0
        public void InitSort(){} // RVA: 0x7ADB9FD20
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7ADB9FD90
        public void IndexOfOrdinalCore(){} // RVA: 0x7ADB9FF40
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7ADB9FF80
        public void LastIndexOfCore(){} // RVA: 0x7ADB9FFC0
        public void IndexOfCore(){} // RVA: 0x7ADBA0000
        public void CompareString(){} // RVA: 0x7ADBA0100
        public void CreateSortKey(){} // RVA: 0x7ADBA0210
        public void StartsWith(){} // RVA: 0x7ADB9CA50
        public void EndsWith(){} // RVA: 0x7ADB9CDD0
        public void GetHashCodeOfStringCore(){} // RVA: 0x7ADBA0510
        public void .cctor(){} // RVA: 0x7ADBA0550
    }

    public class CultureData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A0060
        public void get_Invariant(){} // RVA: 0x7ADBCBB70
        public void GetCultureData(){} // RVA: 0x7ADBCC320
        public void fill_culture_data(){} // RVA: 0x7ADBCC510
        public void GetCalendar(){} // RVA: 0x7ADBCC520
        public void get_LongTimes(){} // RVA: 0x7ABE750D0
        public void get_ShortTimes(){} // RVA: 0x7ADBCC6A0
        public void get_SISO639LANGNAME(){} // RVA: 0x7A8178B90
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7A8D863F0
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7A864E8D0
        public void get_SAM1159(){} // RVA: 0x7A80F2570
        public void get_SPM2359(){} // RVA: 0x7A80DA7B0
        public void get_TimeSeparator(){} // RVA: 0x7A81052C0
        public void get_CalendarIds(){} // RVA: 0x7ADBCC6B0
        public void GetCalendarIds(){} // RVA: 0x7ADBCC950
        public void get_IsInvariantCulture(){} // RVA: 0x7ADBCCA50
        public void get_CultureName(){} // RVA: 0x7A81A0050
        public void get_SCOMPAREINFO(){} // RVA: 0x7ADBCCA70
        public void get_STEXTINFO(){} // RVA: 0x7A81A0050
        public void get_IsRightToLeft(){} // RVA: 0x7A86655E0
        public void get_SLIST(){} // RVA: 0x7A825E100
        public void get_UseUserOverride(){} // RVA: 0x7A8100260
        public void EraNames(){} // RVA: 0x7ADBCCAB0
        public void AbbrevEraNames(){} // RVA: 0x7ADBCCAD0
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7ADBCCAF0
        public void ShortDates(){} // RVA: 0x7ADBCCB10
        public void LongDates(){} // RVA: 0x7ADBCCB30
        public void YearMonths(){} // RVA: 0x7ADBCCB50
        public void DayNames(){} // RVA: 0x7ADBCCB70
        public void AbbreviatedDayNames(){} // RVA: 0x7ADBCCB90
        public void MonthNames(){} // RVA: 0x7ADBCCBB0
        public void GenitiveMonthNames(){} // RVA: 0x7ADBCCBD0
        public void AbbreviatedMonthNames(){} // RVA: 0x7ADBCCBF0
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7ADBCCC10
        public void LeapYearMonthNames(){} // RVA: 0x7ADBCCC40
        public void MonthDay(){} // RVA: 0x7ADBCCC70
        public void DateSeparator(){} // RVA: 0x7ADBCCC90
        public void GetDateSeparator(){} // RVA: 0x7ADBCCD70
        public void GetSeparator(){} // RVA: 0x7ADBCCDC0
        public void IndexOfTimePart(){} // RVA: 0x7ADBCCFA0
        public void UnescapeNlsString(){} // RVA: 0x7ADBCD0C0
        public void ReescapeWin32Strings(){} // RVA: 0x7A97F8BA0
        public void ReescapeWin32String(){} // RVA: 0x7A97F8BA0
        public void strlen(){} // RVA: 0x7ADBCD280
        public void idx2string(){} // RVA: 0x7ADBCD2A0
        public void create_group_sizes_array(){} // RVA: 0x7ADBCD3D0
        public void GetNFIValues(){} // RVA: 0x7ADBCD480
        public void fill_number_data(){} // RVA: 0x7ADBCDDB0
    }

    public class CultureInfo : Object
    {
        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x7A81426F0
        public void get__isInherited(){} // RVA: 0x7A9021760
        public void get_InvariantCulture(){} // RVA: 0x7ADBD9310
        public void get_CurrentCulture(){} // RVA: 0x7ADBD9370
        public void get_CurrentUICulture(){} // RVA: 0x7ADBD93C0
        public void set_CurrentUICulture(){} // RVA: 0x7ADBD9410
        public void ConstructCurrentCulture(){} // RVA: 0x7ADBD9440
        public void ConstructCurrentUICulture(){} // RVA: 0x7ADBD96C0
        public void get_Territory(){} // RVA: 0x7A82C2060
        public void get__name(){} // RVA: 0x7A8152D80
        public void get_IetfLanguageTag(){} // RVA: 0x7ADBD9710
        public void get_LCID(){} // RVA: 0x7A8668BC0
        public void get_Name(){} // RVA: 0x7A8152D80
        public void get_NativeName(){} // RVA: 0x7ADBD9850
        public void get_Calendar(){} // RVA: 0x7ADBD98C0
        public void get_Parent(){} // RVA: 0x7ADBD9990
        public void get_TextInfo(){} // RVA: 0x7ADBD9C70
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7ADBD9E70
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7ADBD9EE0
        public void Clone(){} // RVA: 0x7ADBD9F50
        public void Equals(){} // RVA: 0x7ADBDA1C0
        public void GetCultures(){} // RVA: 0x7ADBDA290
        public void GetTextInfoData(){} // RVA: 0x7ADBDA6A0
        public void GetHashCode(){} // RVA: 0x7A8668BC0
        public void ReadOnly(){} // RVA: 0x7ADBDA6C0
        public void ToString(){} // RVA: 0x7A8152D80
        public void get_CompareInfo(){} // RVA: 0x7ADBDA950
        public void get_IsNeutralCulture(){} // RVA: 0x7ADBDABF0
        public void CheckNeutral(){} // RVA: 0x7A80D7310
        public void get_NumberFormat(){} // RVA: 0x7ADBDAC30
        public void set_NumberFormat(){} // RVA: 0x7ADBDAD20
        public void get_DateTimeFormat(){} // RVA: 0x7ADBDAE90
        public void set_DateTimeFormat(){} // RVA: 0x7ADBDB0A0
        public void get_DisplayName(){} // RVA: 0x7ADBDB210
        public void get_EnglishName(){} // RVA: 0x7ADBDB230
        public void get_InstalledUICulture(){} // RVA: 0x7ADBDB2A0
        public void get_IsReadOnly(){} // RVA: 0x7A81A2200
        public void GetFormat(){} // RVA: 0x7ADBDB2F0
        public void Construct(){} // RVA: 0x7ADBDB440
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7ADBDB4A0
        public void construct_internal_locale_from_name(){} // RVA: 0x7ADBDB500
        public void get_current_locale_name(){} // RVA: 0x7ADBDB6B0
        public void internal_get_cultures(){} // RVA: 0x7ADBDB750
        public void ConstructInvariant(){} // RVA: 0x7ADBDB760
        public void CreateTextInfo(){} // RVA: 0x7ADBDBCE0
        public void .ctor(){} // RVA: 0x7ADBDC4F0
        public void insert_into_shared_tables(){} // RVA: 0x7ADBDC500
        public void GetCultureInfo(){} // RVA: 0x7ADBDCDE0
        public void CreateCulture(){} // RVA: 0x7ADBDCEE0
        public void CreateSpecificCulture(){} // RVA: 0x7ADBDCF70
        public void ConstructLocaleFromName(){} // RVA: 0x7ADBDD2D0
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7ADBDD380
        public void get_CalendarType(){} // RVA: 0x7ADBE05C0
        public void CreateCalendar(){} // RVA: 0x7ADBE0660
        public void CreateNotFoundException(){} // RVA: 0x7ADBE0880
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7ADBE0930
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7ADBE0990
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7ADBE0A50
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7ADBE0AB0
        public void get_SortName(){} // RVA: 0x7A8152D80
        public void get_UserDefaultUICulture(){} // RVA: 0x7ADBE0B70
        public void get_UserDefaultCulture(){} // RVA: 0x7ADBE0BF0
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7ADB311A0
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7A80D7310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7ADBE0C40
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7ADBE0DD0
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7ADBE0ED0
        public void get_HasInvariantCultureName(){} // RVA: 0x7ADBE1040
        public void VerifyCultureName(){} // RVA: 0x7ADBE12C0
        public void .cctor(){} // RVA: 0x7ADBE1360
    }

    public class CultureNotFoundException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBA0710
        public void GetObjectData(){} // RVA: 0x7ADBA0A20
        public void get_InvalidCultureId(){} // RVA: 0x7A87C5850
        public void get_InvalidCultureName(){} // RVA: 0x7A87D9C10
        public void get_DefaultMessage(){} // RVA: 0x7ADBA0D60
        public void get_FormatedInvalidCultureId(){} // RVA: 0x7ADBA0DA0
        public void get_Message(){} // RVA: 0x7ADBA0F10
    }

    public class DateTimeFormatInfo : Object
    {
        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x7ADBA1110
        public void get_Culture(){} // RVA: 0x7ADBA1180
        public void get_LanguageName(){} // RVA: 0x7ADBA1240
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7ADBA12B0
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7ADBA12D0
        public void internalGetDayOfWeekNames(){} // RVA: 0x7ADBA1390
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7ADBA13B0
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7ADBA1470
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7ADBA1490
        public void internalGetMonthNames(){} // RVA: 0x7ADBA1550
        public void internalGetMonthNamesCore(){} // RVA: 0x7ADBA1570
        public void .ctor(){} // RVA: 0x7ADBA1800
        public void InitializeOverridableProperties(){} // RVA: 0x7ADBA1870
        public void get_InvariantInfo(){} // RVA: 0x7ADBA1CF0
        public void get_CurrentInfo(){} // RVA: 0x7ADBA1E40
        public void GetInstance(){} // RVA: 0x7ADBA1F90
        public void GetFormat(){} // RVA: 0x7ADBA2120
        public void Clone(){} // RVA: 0x7ADBA2200
        public void get_AMDesignator(){} // RVA: 0x7ADBA2380
        public void get_Calendar(){} // RVA: 0x7A82C2060
        public void set_Calendar(){} // RVA: 0x7ADBA23F0
        public void get_OptionalCalendars(){} // RVA: 0x7ADBA28A0
        public void get_EraNames(){} // RVA: 0x7ADBA2A30
        public void GetEraName(){} // RVA: 0x7ADBA2B00
        public void get_AbbreviatedEraNames(){} // RVA: 0x7ADBA2CA0
        public void GetAbbreviatedEraName(){} // RVA: 0x7ADBA2D70
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7ADBA2F30
        public void get_DateSeparator(){} // RVA: 0x7ADBA3000
        public void get_FullDateTimePattern(){} // RVA: 0x7ADBA30B0
        public void get_LongDatePattern(){} // RVA: 0x7ADBA3180
        public void get_LongTimePattern(){} // RVA: 0x7ADBA3220
        public void get_MonthDayPattern(){} // RVA: 0x7ADBA32C0
        public void get_PMDesignator(){} // RVA: 0x7ADBA3380
        public void get_RFC1123Pattern(){} // RVA: 0x7ADBA33F0
        public void get_ShortDatePattern(){} // RVA: 0x7ADBA3430
        public void get_ShortTimePattern(){} // RVA: 0x7ADBA34D0
        public void get_SortableDateTimePattern(){} // RVA: 0x7ADBA3570
        public void get_GeneralShortTimePattern(){} // RVA: 0x7ADBA35B0
        public void get_GeneralLongTimePattern(){} // RVA: 0x7ADBA3670
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7ADBA3730
        public void get_TimeSeparator(){} // RVA: 0x7ADBA3950
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7ADBA39C0
        public void get_YearMonthPattern(){} // RVA: 0x7ADBA3A00
        public void get_AbbreviatedDayNames(){} // RVA: 0x7ADBA3AA0
        public void get_DayNames(){} // RVA: 0x7ADBA3B30
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7ADBA3BC0
        public void get_MonthNames(){} // RVA: 0x7ADBA3C50
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7ADBA3CE0
        public void get_HasSpacesInDayNames(){} // RVA: 0x7ADBA3D10
        public void internalGetMonthName(){} // RVA: 0x7ADBA3D40
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7ADBA3EA0
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7ADBA4050
        public void GetAbbreviatedDayName(){} // RVA: 0x7ADBA4120
        public void GetCombinedPatterns(){} // RVA: 0x7ADBA4230
        public void GetAllDateTimePatterns(){} // RVA: 0x7ADBA4360
        public void GetDayName(){} // RVA: 0x7ADBA4820
        public void GetAbbreviatedMonthName(){} // RVA: 0x7ADBA4930
        public void GetMonthName(){} // RVA: 0x7ADBA4A50
        public void GetMergedPatterns(){} // RVA: 0x7ADBA4B70
        public void get_AllYearMonthPatterns(){} // RVA: 0x7ADBA4D70
        public void get_AllShortDatePatterns(){} // RVA: 0x7ADBA4DF0
        public void get_AllShortTimePatterns(){} // RVA: 0x7ADBA4E70
        public void get_AllLongDatePatterns(){} // RVA: 0x7ADBA4EF0
        public void get_AllLongTimePatterns(){} // RVA: 0x7ADBA4F70
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7ADBA4FF0
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7ADBA50C0
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7ADBA5190
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7ADBA5260
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7ADBA52F0
        public void ReadOnly(){} // RVA: 0x7ADBA5380
        public void get_IsReadOnly(){} // RVA: 0x7ADBA55B0
        public void get_MonthGenitiveNames(){} // RVA: 0x7ADBA5650
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7ADBA56E0
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7ADBA5820
        public void get_CompareInfo(){} // RVA: 0x7ADBA58D0
        public void ValidateStyles(){} // RVA: 0x7ADBA5A60
        public void get_FormatFlags(){} // RVA: 0x7ADBA5B90
        public void InitializeFormatFlags(){} // RVA: 0x7ADBA5BB0
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7ADBA5E00
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7ADBA5E40
        public void YearMonthAdjustment(){} // RVA: 0x7ADBA5E70
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7ADBA5FB0
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7ADBA6190
        public void ClearTokenHashTable(){} // RVA: 0x7ADBA6370
        public void CreateTokenHashTable(){} // RVA: 0x7ADBA63F0
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7ADBA7050
        public void IsJapaneseCalendar(){} // RVA: 0x7ADBA7E10
        public void AddMonthNames(){} // RVA: 0x7ADBA7F50
        public void TryParseHebrewNumber(){} // RVA: 0x7ADBA8020
        public void IsHebrewChar(){} // RVA: 0x7ADBA8220
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7ADBA8240
        public void Tokenize(){} // RVA: 0x7ADBA8390
        public void InsertAtCurrentHashNode(){} // RVA: 0x7ADBA8AD0
        public void InsertHash(){} // RVA: 0x7ADBA8D40
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7ADBA9170
        public void .cctor(){} // RVA: 0x7ADBA92A0
    }

    public class DateTimeFormatInfoScanner : Object
    {
        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x7ADBA9390
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x7ADBA9A00
        public void AddDateWordOrPostfix(){} // RVA: 0x7ADBA9AF0
        public void AddDateWords(){} // RVA: 0x7ADBA9D80
        public void ScanRepeatChar(){} // RVA: 0x7ADBAA010
        public void AddIgnorableSymbols(){} // RVA: 0x7ADBAA070
        public void ScanDateWord(){} // RVA: 0x7ADBAA200
        public void GetDateWordsOfDTFI(){} // RVA: 0x7ADBAA4C0
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x7ADBAA7F0
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x7ADBAA840
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x7ADBAA900
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x7ADBAA940
        public void EqualStringArrays(){} // RVA: 0x7ADBAA950
        public void ArrayElementsHaveSpace(){} // RVA: 0x7ADBAAA20
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x7ADBAAB20
        public void .ctor(){} // RVA: 0x7ADBAAD40
    }

    public class DaylightTime : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBAAE00
        public void get_Start(){} // RVA: 0x7A80F2570
        public void get_End(){} // RVA: 0x7A80DA7B0
        public void get_Delta(){} // RVA: 0x7A81052C0
    }

    public class DaylightTimeStruct : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E35C30
    }

    public class EncodingTable : Object
    {
        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x7ADBCE510
        public void ENC(){} // RVA: 0x7ADBCE580
        public void MapCodePageDataItem(){} // RVA: 0x7ADBCE5F0
        public void .cctor(){} // RVA: 0x7ADBCE660
        public void internalGetCodePageFromName(){} // RVA: 0x7ADBD7D30
        public void GetCodePageFromName(){} // RVA: 0x7ADBD80E0
        public void GetCodePageDataItem(){} // RVA: 0x7ADBD8420
    }

    public class EraInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBBE3D0
    }

    public class FormatProvider : Object
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x7AE61E5C0
        public void TryStringToBigInteger(){} // RVA: 0x7AE61E740
    }

    public class GlobalizationMode : Object
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7ADBB6E10
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7A80D7320
        public void .cctor(){} // RVA: 0x7ADBB6E70
    }

    public class GregorianCalendar : Calendar
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7ADBBB990
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBBBA80
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBBBAE0
        public void get_AlgorithmType(){} // RVA: 0x7A81CA9D0
        public void GetDefaultInstance(){} // RVA: 0x7ADBBBB40
        public void .ctor(){} // RVA: 0x7ADBBBC90
        public void get_ID(){} // RVA: 0x7A851DB90
        public void GetDatePart(){} // RVA: 0x7ADBBBDE0
        public void GetAbsoluteDate(){} // RVA: 0x7ADBBBFB0
        public void DateToTicks(){} // RVA: 0x7ADBBC1B0
        public void AddMonths(){} // RVA: 0x7ADBBC230
        public void AddYears(){} // RVA: 0x7ADBBC740
        public void GetDayOfMonth(){} // RVA: 0x7ADBBC760
        public void GetDayOfWeek(){} // RVA: 0x7ADBBC810
        public void GetDayOfYear(){} // RVA: 0x7ADBBC8D0
        public void GetDaysInMonth(){} // RVA: 0x7ADBBC980
        public void GetDaysInYear(){} // RVA: 0x7ADBBCCA0
        public void GetEra(){} // RVA: 0x7A81CA9D0
        public void get_Eras(){} // RVA: 0x7ADBBCE80
        public void GetMonth(){} // RVA: 0x7ADBBCEE0
        public void GetMonthsInYear(){} // RVA: 0x7ADBBCF90
        public void GetYear(){} // RVA: 0x7ADBBD120
        public void IsLeapDay(){} // RVA: 0x7ADBBD1D0
        public void GetLeapMonth(){} // RVA: 0x7ADBBD620
        public void IsLeapMonth(){} // RVA: 0x7ADBBD7A0
        public void IsLeapYear(){} // RVA: 0x7ADBBDA40
        public void ToDateTime(){} // RVA: 0x7ADBBDC10
        public void TryToDateTime(){} // RVA: 0x7ADBBDCF0
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBBDDF0
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBBDE70
        public void ToFourDigitYear(){} // RVA: 0x7ADBBDF90
        public void .cctor(){} // RVA: 0x7ADBBE110
    }

    public class GregorianCalendarHelper : Object
    {
        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0x7A8124910
        public void .ctor(){} // RVA: 0x7ADBBE5E0
        public void GetYearOffset(){} // RVA: 0x7ADBBE710
        public void GetGregorianYear(){} // RVA: 0x7ADBBEAA0
        public void IsValidYear(){} // RVA: 0x7ADBBEAD0
        public void GetDatePart(){} // RVA: 0x7ADBBEAF0
        public void GetAbsoluteDate(){} // RVA: 0x7ADBBECF0
        public void DateToTicks(){} // RVA: 0x7ADBBEEF0
        public void TimeToTicks(){} // RVA: 0x7ADBBEF70
        public void CheckTicksRange(){} // RVA: 0x7ADBBF150
        public void AddMonths(){} // RVA: 0x7ADBBF3C0
        public void AddYears(){} // RVA: 0x7ADBBF930
        public void GetDayOfMonth(){} // RVA: 0x7ADBBF940
        public void GetDayOfWeek(){} // RVA: 0x7ADBBF9F0
        public void GetDayOfYear(){} // RVA: 0x7ADBBFB10
        public void GetDaysInMonth(){} // RVA: 0x7ADBBFBC0
        public void GetDaysInYear(){} // RVA: 0x7ADBBFD70
        public void GetEra(){} // RVA: 0x7ADBBFE00
        public void get_Eras(){} // RVA: 0x7ADBBFF50
        public void GetMonth(){} // RVA: 0x7ADBC00D0
        public void GetMonthsInYear(){} // RVA: 0x7ADBC0180
        public void GetYear(){} // RVA: 0x7ADBC01A0
        public void IsLeapDay(){} // RVA: 0x7ADBC0310
        public void GetLeapMonth(){} // RVA: 0x7ADBC04A0
        public void IsLeapMonth(){} // RVA: 0x7ADBC04C0
        public void IsLeapYear(){} // RVA: 0x7ADBC05F0
        public void ToDateTime(){} // RVA: 0x7ADBC0670
        public void GetWeekOfYear(){} // RVA: 0x7ADBC07C0
        public void ToFourDigitYear(){} // RVA: 0x7ADBC08E0
        public void .cctor(){} // RVA: 0x7ADBC0AE0
    }

    public class HebrewNumber : Object
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7ADBAAE30
        public void ParseByChar(){} // RVA: 0x7ADBAB250
        public void IsDigit(){} // RVA: 0x7ADBAB410
        public void .cctor(){} // RVA: 0x7ADBAB4E0
    }

    public class HebrewNumberParsingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E35C40
    }

    public class HijriCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBC0C80
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBC0CE0
        public void get_AlgorithmType(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7ADBC0D40
        public void get_ID(){} // RVA: 0x7A8842E60
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7ADBC0D60
        public void GetAbsoluteDateHijri(){} // RVA: 0x7ADBC0D70
        public void DaysUpToHijriYear(){} // RVA: 0x7ADBC0E90
        public void get_HijriAdjustment(){} // RVA: 0x7ADBC0F50
        public void GetAdvanceHijriDate(){} // RVA: 0x7A82D1450
        public void CheckTicksRange(){} // RVA: 0x7ADBC0FB0
        public void CheckEraRange(){} // RVA: 0x7ADBC1230
        public void CheckYearRange(){} // RVA: 0x7ADBC1300
        public void CheckYearMonthRange(){} // RVA: 0x7ADBC1500
        public void GetDatePart(){} // RVA: 0x7ADBC16D0
        public void AddMonths(){} // RVA: 0x7ADBC1980
        public void AddYears(){} // RVA: 0x7ADBBC740
        public void GetDayOfMonth(){} // RVA: 0x7ADBC1DD0
        public void GetDayOfWeek(){} // RVA: 0x7ADBC1E80
        public void GetDayOfYear(){} // RVA: 0x7ADBC1F40
        public void GetDaysInMonth(){} // RVA: 0x7ADBC1FF0
        public void GetDaysInYear(){} // RVA: 0x7ADBC20C0
        public void GetEra(){} // RVA: 0x7ADBC2160
        public void get_Eras(){} // RVA: 0x7ADBC2230
        public void GetMonth(){} // RVA: 0x7ADBC22D0
        public void GetMonthsInYear(){} // RVA: 0x7ADBC2380
        public void GetYear(){} // RVA: 0x7ADBC23F0
        public void IsLeapDay(){} // RVA: 0x7ADBC24A0
        public void GetLeapMonth(){} // RVA: 0x7ADBC2620
        public void IsLeapMonth(){} // RVA: 0x7ADBC2680
        public void IsLeapYear(){} // RVA: 0x7ADBC26F0
        public void ToDateTime(){} // RVA: 0x7ADBC2770
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBC2990
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBC2A10
        public void ToFourDigitYear(){} // RVA: 0x7ADBC2B30
        public void .cctor(){} // RVA: 0x7ADBC2CD0
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x7A7E0FC80
        public void Compare(){} // RVA: 0x7A7E0A2B0
        public void IsPrefix(){} // RVA: 0x7A7E02720
        public void IsSuffix(){} // RVA: 0x7A7E02720
        public void IndexOf(){} // RVA: 0x7A7E0B620
        public void LastIndexOf(){} // RVA: 0x7A7E0B620
    }

    public class IdnMapping : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE1870
        public void Equals(){} // RVA: 0x7ADBE1940
        public void GetHashCode(){} // RVA: 0x7ADBE19C0
        public void GetAscii(){} // RVA: 0x7ADBE1AB0
        public void Convert(){} // RVA: 0x7ADBE1BD0
        public void ToAscii(){} // RVA: 0x7ADBE1F50
        public void VerifyLength(){} // RVA: 0x7ADBE23D0
        public void NamePrep(){} // RVA: 0x7ADBE2510
        public void VerifyProhibitedCharacters(){} // RVA: 0x7ADBE2660
        public void VerifyStd3AsciiRules(){} // RVA: 0x7ADBE28C0
        public void GetUnicode(){} // RVA: 0x7ADBE2C00
        public void ToUnicode(){} // RVA: 0x7ADBE2D20
    }

    public class InternalCodePageDataItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InternalEncodingDataItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class JapaneseCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBC2E80
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBC2EE0
        public void get_AlgorithmType(){} // RVA: 0x7A81CA9D0
        public void GetEraInfo(){} // RVA: 0x7ADBC2F40
        public void GetErasFromRegistry(){} // RVA: 0x7A82D1450
        public void GetDefaultInstance(){} // RVA: 0x7ADBC35E0
        public void .ctor(){} // RVA: 0x7ADBC3720
        public void get_ID(){} // RVA: 0x7A87EE0F0
        public void AddMonths(){} // RVA: 0x7ADBC38E0
        public void AddYears(){} // RVA: 0x7ADBC3900
        public void GetDaysInMonth(){} // RVA: 0x7ADBC3930
        public void GetDaysInYear(){} // RVA: 0x7ADBC3960
        public void GetDayOfMonth(){} // RVA: 0x7ADBC3980
        public void GetDayOfWeek(){} // RVA: 0x7ADBC39A0
        public void GetDayOfYear(){} // RVA: 0x7ADBC39C0
        public void GetMonthsInYear(){} // RVA: 0x7ADBC39E0
        public void GetWeekOfYear(){} // RVA: 0x7ADBC3A10
        public void GetEra(){} // RVA: 0x7ADBC3A40
        public void GetMonth(){} // RVA: 0x7ADBC3A60
        public void GetYear(){} // RVA: 0x7ADBC3A80
        public void IsLeapDay(){} // RVA: 0x7ADBC3AA0
        public void IsLeapYear(){} // RVA: 0x7ADBC3AD0
        public void GetLeapMonth(){} // RVA: 0x7ADBC3AF0
        public void IsLeapMonth(){} // RVA: 0x7ADBC3B20
        public void ToDateTime(){} // RVA: 0x7ADBC3B50
        public void ToFourDigitYear(){} // RVA: 0x7ADBC3B80
        public void get_Eras(){} // RVA: 0x7ADBC3D30
        public void EraNames(){} // RVA: 0x7ADBC3D50
        public void EnglishEraNames(){} // RVA: 0x7ADBC3E90
        public void IsValidYear(){} // RVA: 0x7ADBC3FD0
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBC4000
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBC4080
        public void .cctor(){} // RVA: 0x7ADBC41D0
    }

    public class NumberFormatInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBC43E0
        public void OnSerializing(){} // RVA: 0x7ADBC4270
        public void OnDeserializing(){} // RVA: 0x7A80D7310
        public void OnDeserialized(){} // RVA: 0x7A80D7310
        public void VerifyWritable(){} // RVA: 0x7ADBC4E80
        public void get_InvariantInfo(){} // RVA: 0x7ADBC4F00
        public void GetInstance(){} // RVA: 0x7ADBC5070
        public void Clone(){} // RVA: 0x7ADBC51F0
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7A9EEB080
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7A8178B90
        public void get_IsReadOnly(){} // RVA: 0x7A86665A0
        public void get_CurrencyGroupSizes(){} // RVA: 0x7ADBC5260
        public void get_NumberGroupSizes(){} // RVA: 0x7ADBC52E0
        public void get_PercentGroupSizes(){} // RVA: 0x7ADBC5360
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7A8152D80
        public void get_CurrencySymbol(){} // RVA: 0x7A81A0050
        public void get_CurrentInfo(){} // RVA: 0x7ADBC53E0
        public void get_NaNSymbol(){} // RVA: 0x7A8153390
        public void set_NaNSymbol(){} // RVA: 0x7ADBC5510
        public void get_CurrencyNegativePattern(){} // RVA: 0x7A9651770
        public void get_NumberNegativePattern(){} // RVA: 0x7A892D750
        public void get_PercentPositivePattern(){} // RVA: 0x7A8357940
        public void get_PercentNegativePattern(){} // RVA: 0x7A9AAC1B0
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7A82C2060
        public void get_NegativeSign(){} // RVA: 0x7A83F69F0
        public void get_NumberDecimalDigits(){} // RVA: 0x7ABA39100
        public void get_NumberDecimalSeparator(){} // RVA: 0x7A8292C30
        public void get_NumberGroupSeparator(){} // RVA: 0x7A8154D80
        public void get_CurrencyPositivePattern(){} // RVA: 0x7ABBEC920
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7A81A00E0
        public void get_PositiveSign(){} // RVA: 0x7A8105330
        public void get_PercentDecimalDigits(){} // RVA: 0x7A87BD4F0
        public void get_PercentDecimalSeparator(){} // RVA: 0x7A825E100
        public void get_PercentGroupSeparator(){} // RVA: 0x7A81163D0
        public void get_PercentSymbol(){} // RVA: 0x7A8555100
        public void get_PerMilleSymbol(){} // RVA: 0x7A87D9C10
        public void GetFormat(){} // RVA: 0x7ADBC5640
        public void ReadOnly(){} // RVA: 0x7ADBC5720
        public void ValidateParseStyleInteger(){} // RVA: 0x7ADBC57F0
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7ADBC58E0
    }

    public class Punycode : Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE3970
    }

    public class RegionInfo : Object
    {
        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x7ADBE39B0
        public void .ctor(){} // RVA: 0x7ADBE3E50
        public void GetByTerritory(){} // RVA: 0x7ADBE42E0
        public void construct_internal_region_from_name(){} // RVA: 0x7ADBE4390
        public void get_CurrencyEnglishName(){} // RVA: 0x7A8178B90
        public void get_CurrencySymbol(){} // RVA: 0x7A8154D80
        public void get_DisplayName(){} // RVA: 0x7A83F69F0
        public void get_EnglishName(){} // RVA: 0x7A83F69F0
        public void get_GeoId(){} // RVA: 0x7A8124910
        public void get_IsMetric(){} // RVA: 0x7ADBE4540
        public void get_ISOCurrencySymbol(){} // RVA: 0x7A8152D80
        public void get_NativeName(){} // RVA: 0x7A8292C30
        public void get_CurrencyNativeName(){} // RVA: 0x7A81A0050
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_ThreeLetterISORegionName(){} // RVA: 0x7A81052C0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0x7A8105330
        public void get_TwoLetterISORegionName(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7ADBE4610
        public void GetHashCode(){} // RVA: 0x7ADBE4700
        public void ToString(){} // RVA: 0x7ADBE4740
        public void ClearCachedData(){} // RVA: 0x7ADBE4760
    }

    public class SortKey : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7ADBCB440
        public void .ctor(){} // RVA: 0x7ADBCBB40
        public void get_OriginalString(){} // RVA: 0x7A80F2570
        public void get_KeyData(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7ADBCB8F0
        public void GetHashCode(){} // RVA: 0x7ADBCB990
        public void ToString(){} // RVA: 0x7ADBCBA00
    }

    public class TaiwanCalendar : Calendar
    {
        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x7ADBC59C0
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBC5B00
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBC5B60
        public void get_AlgorithmType(){} // RVA: 0x7A81CA9D0
        public void .ctor(){} // RVA: 0x7ADBC5BC0
        public void get_ID(){} // RVA: 0x7A883BE70
        public void AddMonths(){} // RVA: 0x7ADBC38E0
        public void AddYears(){} // RVA: 0x7ADBC3900
        public void GetDaysInMonth(){} // RVA: 0x7ADBC3930
        public void GetDaysInYear(){} // RVA: 0x7ADBC3960
        public void GetDayOfMonth(){} // RVA: 0x7ADBC3980
        public void GetDayOfWeek(){} // RVA: 0x7ADBC39A0
        public void GetDayOfYear(){} // RVA: 0x7ADBC39C0
        public void GetMonthsInYear(){} // RVA: 0x7ADBC39E0
        public void GetWeekOfYear(){} // RVA: 0x7ADBC3A10
        public void GetEra(){} // RVA: 0x7ADBC3A40
        public void GetMonth(){} // RVA: 0x7ADBC3A60
        public void GetYear(){} // RVA: 0x7ADBC3A80
        public void IsLeapDay(){} // RVA: 0x7ADBC3AA0
        public void IsLeapYear(){} // RVA: 0x7ADBC3AD0
        public void GetLeapMonth(){} // RVA: 0x7ADBC3AF0
        public void IsLeapMonth(){} // RVA: 0x7ADBC3B20
        public void ToDateTime(){} // RVA: 0x7ADBC3B50
        public void get_Eras(){} // RVA: 0x7ADBC3D30
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBC4000
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBC5D90
        public void ToFourDigitYear(){} // RVA: 0x7ADBC5EE0
        public void .cctor(){} // RVA: 0x7ADBC6090
    }

    public class TextInfo : Object
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7ADBC6250
        public void .ctor(){} // RVA: 0x7ADBC86F0
        public void OnDeserializing(){} // RVA: 0x7ADBC6480
        public void OnDeserialized(){} // RVA: 0x7ADBC66F0
        public void OnSerializing(){} // RVA: 0x7ADBC6700
        public void get_CultureName(){} // RVA: 0x7A83F69F0
        public void get_IsReadOnly(){} // RVA: 0x7A80F26D0
        public void Clone(){} // RVA: 0x7ADBC67E0
        public void ReadOnly(){} // RVA: 0x7ADBC6860
        public void SetReadOnlyState(){} // RVA: 0x7A80F26E0
        public void get_ListSeparator(){} // RVA: 0x7ADBC6940
        public void ToLower(){} // RVA: 0x7ADBC6A20
        public void ToLowerAsciiInvariant(){} // RVA: 0x7ADBC6B50
        public void ToUpper(){} // RVA: 0x7ADBC6BD0
        public void ToUpperAsciiInvariant(){} // RVA: 0x7ADBC8500
        public void IsAscii(){} // RVA: 0x7ADBC6D20
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7ADBC6D30
        public void Equals(){} // RVA: 0x7ADBC6E80
        public void GetHashCode(){} // RVA: 0x7ADBC6F50
        public void ToString(){} // RVA: 0x7ADBC6F80
        public void ToTitleCase(){} // RVA: 0x7ADBC6FE0
        public void AddNonLetter(){} // RVA: 0x7ADBC74B0
        public void AddTitlecaseLetter(){} // RVA: 0x7ADBC7570
        public void IsWordSeparator(){} // RVA: 0x7ADBC7790
        public void IsLetterCategory(){} // RVA: 0x7ADBC77A0
        public void get_IsRightToLeft(){} // RVA: 0x7ADBC77B0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ADBC66F0
        public void ToUpperInternal(){} // RVA: 0x7ADBC7990
        public void ToLowerInternal(){} // RVA: 0x7ADBC7FC0
        public void ChangeCase(){} // RVA: 0x7ADBC85C0
    }

    public class TextInfoToLowerData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADBD8D10
    }

    public class TextInfoToUpperData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADBD87B0
    }

    public class ThaiBuddhistCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBC8720
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBC8780
        public void get_AlgorithmType(){} // RVA: 0x7A81CA9D0
        public void .ctor(){} // RVA: 0x7ADBC87E0
        public void get_ID(){} // RVA: 0x7A88258F0
        public void AddMonths(){} // RVA: 0x7ADBC38E0
        public void AddYears(){} // RVA: 0x7ADBC3900
        public void GetDaysInMonth(){} // RVA: 0x7ADBC3930
        public void GetDaysInYear(){} // RVA: 0x7ADBC3960
        public void GetDayOfMonth(){} // RVA: 0x7ADBC3980
        public void GetDayOfWeek(){} // RVA: 0x7ADBC39A0
        public void GetDayOfYear(){} // RVA: 0x7ADBC39C0
        public void GetMonthsInYear(){} // RVA: 0x7ADBC39E0
        public void GetWeekOfYear(){} // RVA: 0x7ADBC3A10
        public void GetEra(){} // RVA: 0x7ADBC3A40
        public void GetMonth(){} // RVA: 0x7ADBC3A60
        public void GetYear(){} // RVA: 0x7ADBC3A80
        public void IsLeapDay(){} // RVA: 0x7ADBC3AA0
        public void IsLeapYear(){} // RVA: 0x7ADBC3AD0
        public void GetLeapMonth(){} // RVA: 0x7ADBC3AF0
        public void IsLeapMonth(){} // RVA: 0x7ADBC3B20
        public void ToDateTime(){} // RVA: 0x7ADBC3B50
        public void get_Eras(){} // RVA: 0x7ADBC3D30
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBC88E0
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBC8960
        public void ToFourDigitYear(){} // RVA: 0x7ADBC8AB0
        public void .cctor(){} // RVA: 0x7ADBC8B70
    }

    public class TimeSpanFormat : Object
    {
        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x7ADBAB950
        public void Format(){} // RVA: 0x7ADBABAD0
        public void TryFormat(){} // RVA: 0x7ADBABBD0
        public void FormatToBuilder(){} // RVA: 0x7ADBABCD0
        public void FormatStandard(){} // RVA: 0x7ADBABFF0
        public void FormatCustomized(){} // RVA: 0x7ADBAC5F0
        public void .cctor(){} // RVA: 0x7ADBACE40
    }

    public class TimeSpanParse : Object
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x7ADBAD8B0
        public void TryTimeToTicks(){} // RVA: 0x7ADBAD9B0
        public void Parse(){} // RVA: 0x7ADBADB70
        public void TryParse(){} // RVA: 0x7ADBADBB0
        public void ParseExact(){} // RVA: 0x7ADBADC10
        public void TryParseExact(){} // RVA: 0x7ADBADC60
        public void ParseExactMultiple(){} // RVA: 0x7ADBADCD0
        public void TryParseExactMultiple(){} // RVA: 0x7ADBADD10
        public void TryParseTimeSpan(){} // RVA: 0x7ADBADD70
        public void ProcessTerminalState(){} // RVA: 0x7ADBAEF20
        public void ProcessTerminal_DHMSF(){} // RVA: 0x7ADBAF090
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x7ADBAF4E0
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x7ADBB0F90
        public void ProcessTerminal_HM(){} // RVA: 0x7ADBB25F0
        public void ProcessTerminal_D(){} // RVA: 0x7ADBB2930
        public void TryParseExactTimeSpan(){} // RVA: 0x7ADBB2C40
        public void TryParseByFormat(){} // RVA: 0x7ADBB2DE0
        public void ParseExactDigits(){} // RVA: 0x7ADBB3A10
        public void ParseExactLiteral(){} // RVA: 0x7ADBB3AF0
        public void TryParseTimeSpanConstant(){} // RVA: 0x7ADBB3BB0
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x7ADBB3BF0
    }

    public class UmAlQuraCalendar : Calendar
    {
        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x7ADBC8CE0
        public void get_MinSupportedDateTime(){} // RVA: 0x7ADBC8EC0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ADBC8F20
        public void get_AlgorithmType(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7ADBB6F70
        public void get_BaseCalendarID(){} // RVA: 0x7A8842E60
        public void get_ID(){} // RVA: 0x7A87BABE0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7ADBC8F80
        public void ConvertHijriToGregorian(){} // RVA: 0x7ADBC8F90
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x7ADBC9200
        public void CheckTicksRange(){} // RVA: 0x7ADBC92D0
        public void CheckEraRange(){} // RVA: 0x7ADBC9550
        public void CheckYearRange(){} // RVA: 0x7ADBC95E0
        public void CheckYearMonthRange(){} // RVA: 0x7ADBC97A0
        public void ConvertGregorianToHijri(){} // RVA: 0x7ADBC9880
        public void GetDatePart(){} // RVA: 0x7ADBC9CA0
        public void AddMonths(){} // RVA: 0x7ADBC9E80
        public void AddYears(){} // RVA: 0x7ADBBC740
        public void GetDayOfMonth(){} // RVA: 0x7ADBCA270
        public void GetDayOfWeek(){} // RVA: 0x7ADBCA290
        public void GetDayOfYear(){} // RVA: 0x7ADBCA350
        public void GetDaysInMonth(){} // RVA: 0x7ADBCA370
        public void RealGetDaysInYear(){} // RVA: 0x7ADBCA430
        public void GetDaysInYear(){} // RVA: 0x7ADBCA4E0
        public void GetEra(){} // RVA: 0x7ADBCA550
        public void get_Eras(){} // RVA: 0x7ADBCA610
        public void GetMonth(){} // RVA: 0x7ADBCA670
        public void GetMonthsInYear(){} // RVA: 0x7ADBCA690
        public void GetYear(){} // RVA: 0x7ADBCA700
        public void IsLeapDay(){} // RVA: 0x7ADBCA720
        public void GetLeapMonth(){} // RVA: 0x7ADBCA8C0
        public void IsLeapMonth(){} // RVA: 0x7ADBCA920
        public void IsLeapYear(){} // RVA: 0x7ADBCA990
        public void ToDateTime(){} // RVA: 0x7ADBCAA00
        public void get_TwoDigitYearMax(){} // RVA: 0x7ADBC2990
        public void set_TwoDigitYearMax(){} // RVA: 0x7ADBCACD0
        public void ToFourDigitYear(){} // RVA: 0x7ADBCAE00
        public void .cctor(){} // RVA: 0x7ADBCAFA0
    }

}