// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 40
// Methods: 822

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A4700
        public void Encode(){} // RVA: 0x7FFAF88A4730
        public void EncodeDigit(){} // RVA: 0x7FFAF88A4BF0
        public void DecodeDigit(){} // RVA: 0x7FFAF88A4C10
        public void Adapt(){} // RVA: 0x7FFAF88A4C40
        public void Decode(){} // RVA: 0x7FFAF88A4CC0
    }

    public class Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF8878880
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF88788E0
        public void .ctor(){} // RVA: 0x7FFAF8878940
        public void get_ID(){} // RVA: 0x7FFAF320BB20
        public void get_BaseCalendarID(){} // RVA: 0x7FFAF4751C00
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2FC9240
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2EDCBD0
        public void Clone(){} // RVA: 0x7FFAF8878950
        public void ReadOnly(){} // RVA: 0x7FFAF88789D0
        public void VerifyWritable(){} // RVA: 0x7FFAF8878AC0
        public void SetReadOnlyState(){} // RVA: 0x7FFAF2EDCBE0
        public void get_CurrentEraValue(){} // RVA: 0x7FFAF8878B40
        public void CheckAddResult(){} // RVA: 0x7FFAF8878BD0
        public void AddMonths(){}
        public void AddYears(){}
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8878DB0 | overloaded x2
        public void GetDaysInYear(){} // RVA: 0x7FFAF2AC4170
        public void GetEra(){}
        public void get_Eras(){} // RVA: 0x7FFAF2ABCD60
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x7FFAF2AC4170
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7FFAF8878DE0
        public void GetWeekOfYearFullDays(){} // RVA: 0x7FFAF8878EA0
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7FFAF88790E0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAF8879250
        public void GetWeekOfYear(){} // RVA: 0x7FFAF8879260
        public void GetYear(){}
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void GetLeapMonth(){} // RVA: 0x7FFAF8879590
        public void IsLeapYear(){} // RVA: 0x7FFAF8879650 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFAF8879670 | overloaded x2
        public void TryToDateTime(){} // RVA: 0x7FFAF88796D0
        public void IsValidYear(){} // RVA: 0x7FFAF88797D0
        public void IsValidMonth(){} // RVA: 0x7FFAF8879860
        public void IsValidDay(){} // RVA: 0x7FFAF88798E0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF306ED50
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF8879970
        public void ToFourDigitYear(){} // RVA: 0x7FFAF88799A0
        public void TimeToTicks(){} // RVA: 0x7FFAF8879AB0
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7FFAF8879C90
    }

    public class CalendarData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF887B030 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8879CF0
        public void InitializeEraNames(){} // RVA: 0x7FFAF887BED0
        public void GetJapaneseEraNames(){} // RVA: 0x7FFAF887C3E0
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7FFAF887C600
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7FFAF887C820
        public void GetCalendarData(){} // RVA: 0x7FFAF887CC60
        public void CalendarIdToCultureName(){} // RVA: 0x7FFAF887CE90
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7FFAF320BB20
        public void nativeGetCalendarData(){} // RVA: 0x7FFAF887D060
        public void fill_calendar_data(){} // RVA: 0x7FFAF887D200
    }

    public class CharUnicodeInfo
    {
        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x7FFAF885B530 | overloaded x2
        public void InternalGetNumericValue(){} // RVA: 0x7FFAF885B5E0
        public void GetNumericValue(){} // RVA: 0x7FFAF885B7C0 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFAF885B9F0 | overloaded x3
        public void InternalGetCategoryValue(){} // RVA: 0x7FFAF885BB70
        public void InternalGetUnicodeCategory(){} // RVA: 0x7FFAF885BDA0 | overloaded x2
        public void IsWhiteSpace(){} // RVA: 0x7FFAF885BF20 | overloaded x2
        public void get_CategoryLevel1Index(){} // RVA: 0x7FFAF885BF40
        public void get_CategoryLevel2Index(){} // RVA: 0x7FFAF885BFA0
        public void get_CategoryLevel3Index(){} // RVA: 0x7FFAF885C000
        public void get_CategoriesValue(){} // RVA: 0x7FFAF885C060
        public void get_NumericLevel1Index(){} // RVA: 0x7FFAF885C0C0
        public void get_NumericLevel2Index(){} // RVA: 0x7FFAF885C120
        public void get_NumericLevel3Index(){} // RVA: 0x7FFAF885C180
        public void get_NumericValues(){} // RVA: 0x7FFAF885C1E0
    }

    public class CodePageDataItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF888F390
        public void CreateString(){} // RVA: 0x7FFAF888F450
        public void get_WebName(){} // RVA: 0x7FFAF888F5A0
        public void get_HeaderName(){} // RVA: 0x7FFAF888F6C0
        public void get_BodyName(){} // RVA: 0x7FFAF888F7F0
        public void .cctor(){} // RVA: 0x7FFAF888F920
    }

    public class CompareInfo
    {
        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7FFAF885C240
        public void InvariantLastIndexOf(){} // RVA: 0x7FFAF885C310
        public void InvariantFindString(){} // RVA: 0x7FFAF885C3F0
        public void InvariantToUpper(){} // RVA: 0x7FFAF885C7F0
        public void InvariantCreateSortKey(){} // RVA: 0x7FFAF885C810
        public void .ctor(){} // RVA: 0x7FFAF88621A0 | overloaded x2
        public void GetCompareInfo(){} // RVA: 0x7FFAF885CBD0
        public void OnDeserializing(){} // RVA: 0x7FFAF81FFB20
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF885CC90
        public void OnDeserialized(){} // RVA: 0x7FFAF885CCA0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAF885CDF0
        public void get_Name(){} // RVA: 0x7FFAF885CE90
        public void Compare(){} // RVA: 0x7FFAF885D9E0 | overloaded x4
        public void CompareOptionNone(){} // RVA: 0x7FFAF885D750
        public void CompareOptionIgnoreCase(){} // RVA: 0x7FFAF885D8B0
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7FFAF885E120 | overloaded x2
        public void IsPrefix(){} // RVA: 0x7FFAF885E5E0 | overloaded x2
        public void IsSuffix(){} // RVA: 0x7FFAF885E960 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAF885F370 | overloaded x5
        public void IndexOfOrdinal(){} // RVA: 0x7FFAF885F4D0
        public void LastIndexOf(){} // RVA: 0x7FFAF885F720 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFAF885FB00
        public void GetSortKey(){} // RVA: 0x7FFAF885FCD0
        public void Equals(){} // RVA: 0x7FFAF885FE50
        public void GetHashCode(){} // RVA: 0x7FFAF8860520 | overloaded x2
        public void GetIgnoreCaseHash(){} // RVA: 0x7FFAF885FFA0
        public void GetHashCodeOfString(){} // RVA: 0x7FFAF8860350
        public void ToString(){} // RVA: 0x7FFAF8860630
        public void get_UseManagedCollation(){} // RVA: 0x7FFAF8860690
        public void GetCollator(){} // RVA: 0x7FFAF8860800
        public void CreateSortKeyCore(){} // RVA: 0x7FFAF8860C80
        public void internal_index_switch(){} // RVA: 0x7FFAF8860F20
        public void internal_compare_switch(){} // RVA: 0x7FFAF88611A0
        public void internal_compare_managed(){} // RVA: 0x7FFAF88613A0
        public void internal_index_managed(){} // RVA: 0x7FFAF88614A0
        public void internal_compare_icall(){} // RVA: 0x7FFAF8861550
        public void internal_compare(){} // RVA: 0x7FFAF8861560
        public void internal_index_icall(){} // RVA: 0x7FFAF8861610
        public void internal_index(){} // RVA: 0x7FFAF8861700
        public void InitSort(){} // RVA: 0x7FFAF8861840
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7FFAF88618B0
        public void IndexOfOrdinalCore(){} // RVA: 0x7FFAF8861A70
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7FFAF8861AB0
        public void LastIndexOfCore(){} // RVA: 0x7FFAF8861AF0
        public void IndexOfCore(){} // RVA: 0x7FFAF8861B30
        public void CompareString(){} // RVA: 0x7FFAF8861C30 | overloaded x2
        public void CreateSortKey(){} // RVA: 0x7FFAF8861D40
        public void StartsWith(){} // RVA: 0x7FFAF885E5E0 | overloaded x2
        public void EndsWith(){} // RVA: 0x7FFAF885E960 | overloaded x2
        public void GetHashCodeOfStringCore(){} // RVA: 0x7FFAF8862040
        public void .cctor(){} // RVA: 0x7FFAF8862080
    }

    public class CultureData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E55510
        public void get_Invariant(){} // RVA: 0x7FFAF888D0E0
        public void GetCultureData(){} // RVA: 0x7FFAF888D890 | overloaded x2
        public void fill_culture_data(){} // RVA: 0x7FFAF888DA80
        public void GetCalendar(){} // RVA: 0x7FFAF888DA90
        public void get_LongTimes(){} // RVA: 0x7FFAF6B2FEB0
        public void get_ShortTimes(){} // RVA: 0x7FFAF888DC00
        public void get_SISO639LANGNAME(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7FFAF3A8C9F0
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7FFAF3341AF0
        public void get_SAM1159(){} // RVA: 0x7FFAF2DA8380
        public void get_SPM2359(){} // RVA: 0x7FFAF2D907C0
        public void get_TimeSeparator(){} // RVA: 0x7FFAF2DBB0C0
        public void get_CalendarIds(){} // RVA: 0x7FFAF888DC10
        public void GetCalendarIds(){} // RVA: 0x7FFAF888DEB0
        public void get_IsInvariantCulture(){} // RVA: 0x7FFAF888DF90
        public void get_CultureName(){} // RVA: 0x7FFAF2E55500
        public void get_SCOMPAREINFO(){} // RVA: 0x7FFAF888DFB0
        public void get_STEXTINFO(){} // RVA: 0x7FFAF2E55500
        public void get_IsRightToLeft(){} // RVA: 0x7FFAF33589C0
        public void get_SLIST(){} // RVA: 0x7FFAF2F12D00
        public void get_UseUserOverride(){} // RVA: 0x7FFAF2DB6020
        public void EraNames(){} // RVA: 0x7FFAF888DFF0
        public void AbbrevEraNames(){} // RVA: 0x7FFAF888E010
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7FFAF888E030
        public void ShortDates(){} // RVA: 0x7FFAF888E050
        public void LongDates(){} // RVA: 0x7FFAF888E070
        public void YearMonths(){} // RVA: 0x7FFAF888E090
        public void DayNames(){} // RVA: 0x7FFAF888E0B0
        public void AbbreviatedDayNames(){} // RVA: 0x7FFAF888E0D0
        public void MonthNames(){} // RVA: 0x7FFAF888E0F0
        public void GenitiveMonthNames(){} // RVA: 0x7FFAF888E110
        public void AbbreviatedMonthNames(){} // RVA: 0x7FFAF888E130
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7FFAF888E150
        public void LeapYearMonthNames(){} // RVA: 0x7FFAF888E180
        public void MonthDay(){} // RVA: 0x7FFAF888E1B0
        public void DateSeparator(){} // RVA: 0x7FFAF888E1D0
        public void GetDateSeparator(){} // RVA: 0x7FFAF888E2B0
        public void GetSeparator(){} // RVA: 0x7FFAF888E300
        public void IndexOfTimePart(){} // RVA: 0x7FFAF888E4E0
        public void UnescapeNlsString(){} // RVA: 0x7FFAF888E600
        public void ReescapeWin32Strings(){} // RVA: 0x7FFAF44EF520
        public void ReescapeWin32String(){} // RVA: 0x7FFAF44EF520
        public void strlen(){} // RVA: 0x7FFAF888E7C0
        public void idx2string(){} // RVA: 0x7FFAF888E7E0
        public void create_group_sizes_array(){} // RVA: 0x7FFAF888E910
        public void GetNFIValues(){} // RVA: 0x7FFAF888E9C0
        public void fill_number_data(){} // RVA: 0x7FFAF888F2D0
    }

    public class CultureInfo
    {
        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x7FFAF2DF8120
        public void get__isInherited(){} // RVA: 0x7FFAF3D1AF80
        public void get_InvariantCulture(){} // RVA: 0x7FFAF889A880
        public void get_CurrentCulture(){} // RVA: 0x7FFAF889A8E0
        public void get_CurrentUICulture(){} // RVA: 0x7FFAF889A930
        public void set_CurrentUICulture(){} // RVA: 0x7FFAF889A980
        public void ConstructCurrentCulture(){} // RVA: 0x7FFAF889A9B0
        public void ConstructCurrentUICulture(){} // RVA: 0x7FFAF889AC10
        public void get_Territory(){} // RVA: 0x7FFAF2F77C50
        public void get__name(){} // RVA: 0x7FFAF2E08730
        public void get_IetfLanguageTag(){} // RVA: 0x7FFAF889AC60
        public void get_LCID(){} // RVA: 0x7FFAF335BED0
        public void get_Name(){} // RVA: 0x7FFAF2E08730
        public void get_NativeName(){} // RVA: 0x7FFAF889ADA0
        public void get_Calendar(){} // RVA: 0x7FFAF889AE10
        public void get_Parent(){} // RVA: 0x7FFAF889AEE0
        public void get_TextInfo(){} // RVA: 0x7FFAF889B1C0
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7FFAF889B410
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7FFAF889B480
        public void Clone(){} // RVA: 0x7FFAF889B4F0
        public void Equals(){} // RVA: 0x7FFAF889B750
        public void GetCultures(){} // RVA: 0x7FFAF889B830
        public void GetTextInfoData(){} // RVA: 0x7FFAF889BC30
        public void GetHashCode(){} // RVA: 0x7FFAF335BED0
        public void ReadOnly(){} // RVA: 0x7FFAF889BC50
        public void ToString(){} // RVA: 0x7FFAF2E08730
        public void get_CompareInfo(){} // RVA: 0x7FFAF889BEE0
        public void get_IsNeutralCulture(){} // RVA: 0x7FFAF889C1A0
        public void CheckNeutral(){} // RVA: 0x7FFAF2D8D310
        public void get_NumberFormat(){} // RVA: 0x7FFAF889C1E0
        public void set_NumberFormat(){} // RVA: 0x7FFAF889C2D0
        public void get_DateTimeFormat(){} // RVA: 0x7FFAF889C440
        public void set_DateTimeFormat(){} // RVA: 0x7FFAF889C650
        public void get_DisplayName(){} // RVA: 0x7FFAF889C7C0
        public void get_EnglishName(){} // RVA: 0x7FFAF889C7E0
        public void get_InstalledUICulture(){} // RVA: 0x7FFAF889C850
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2E575E0
        public void GetFormat(){} // RVA: 0x7FFAF889C8A0
        public void Construct(){} // RVA: 0x7FFAF889C9F0
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7FFAF889CA50
        public void construct_internal_locale_from_name(){} // RVA: 0x7FFAF889CAB0
        public void get_current_locale_name(){} // RVA: 0x7FFAF889CC40
        public void internal_get_cultures(){} // RVA: 0x7FFAF889CCC0
        public void ConstructInvariant(){} // RVA: 0x7FFAF889CCD0
        public void CreateTextInfo(){} // RVA: 0x7FFAF889D250
        public void .ctor(){} // RVA: 0x7FFAF889DA90 | overloaded x7
        public void insert_into_shared_tables(){} // RVA: 0x7FFAF889DAA0
        public void GetCultureInfo(){} // RVA: 0x7FFAF889E3C0 | overloaded x3
        public void CreateCulture(){} // RVA: 0x7FFAF889E4C0
        public void CreateSpecificCulture(){} // RVA: 0x7FFAF889E550
        public void ConstructLocaleFromName(){} // RVA: 0x7FFAF889E8B0
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7FFAF889E960
        public void get_CalendarType(){} // RVA: 0x7FFAF88A1BA0
        public void CreateCalendar(){} // RVA: 0x7FFAF88A1C40
        public void CreateNotFoundException(){} // RVA: 0x7FFAF88A1E60
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7FFAF88A1F10
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7FFAF88A1F70
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFAF88A2030
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFAF88A2090
        public void get_SortName(){} // RVA: 0x7FFAF2E08730
        public void get_UserDefaultUICulture(){} // RVA: 0x7FFAF88A2150
        public void get_UserDefaultCulture(){} // RVA: 0x7FFAF88A21D0
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFAF87F2EB0
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFAF2D8D310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7FFAF88A2220
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFAF88A23B0
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFAF88A24B0
        public void get_HasInvariantCultureName(){} // RVA: 0x7FFAF88A2620
        public void VerifyCultureName(){} // RVA: 0x7FFAF88A28A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF88A2940
    }

    public class CultureNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8862240 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAF8862550
        public void get_InvalidCultureId(){} // RVA: 0x7FFAF34B85E0
        public void get_InvalidCultureName(){} // RVA: 0x7FFAF34CC8C0
        public void get_DefaultMessage(){} // RVA: 0x7FFAF8862890
        public void get_FormatedInvalidCultureId(){} // RVA: 0x7FFAF88628D0
        public void get_Message(){} // RVA: 0x7FFAF8862A40
    }

    public class DateTimeFormatInfo
    {
        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x7FFAF8862C40
        public void get_Culture(){} // RVA: 0x7FFAF8862CB0
        public void get_LanguageName(){} // RVA: 0x7FFAF8862D70
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7FFAF8862DE0
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7FFAF8862E00
        public void internalGetDayOfWeekNames(){} // RVA: 0x7FFAF8862EC0
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7FFAF8862EE0
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7FFAF8862FA0
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7FFAF8862FC0
        public void internalGetMonthNames(){} // RVA: 0x7FFAF8863080
        public void internalGetMonthNamesCore(){} // RVA: 0x7FFAF88630A0
        public void .ctor(){} // RVA: 0x7FFAF8863330 | overloaded x2
        public void InitializeOverridableProperties(){} // RVA: 0x7FFAF88633A0
        public void get_InvariantInfo(){} // RVA: 0x7FFAF8863820
        public void get_CurrentInfo(){} // RVA: 0x7FFAF8863970
        public void GetInstance(){} // RVA: 0x7FFAF8863AC0
        public void GetFormat(){} // RVA: 0x7FFAF8863C50
        public void Clone(){} // RVA: 0x7FFAF8863D30
        public void get_AMDesignator(){} // RVA: 0x7FFAF8863EB0
        public void get_Calendar(){} // RVA: 0x7FFAF2F77C50
        public void set_Calendar(){} // RVA: 0x7FFAF8863F20
        public void get_OptionalCalendars(){} // RVA: 0x7FFAF88643C0
        public void get_EraNames(){} // RVA: 0x7FFAF8864530
        public void GetEraName(){} // RVA: 0x7FFAF8864600
        public void get_AbbreviatedEraNames(){} // RVA: 0x7FFAF88647A0
        public void GetAbbreviatedEraName(){} // RVA: 0x7FFAF8864870
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7FFAF8864A30
        public void get_DateSeparator(){} // RVA: 0x7FFAF8864B00
        public void get_FullDateTimePattern(){} // RVA: 0x7FFAF8864BB0
        public void get_LongDatePattern(){} // RVA: 0x7FFAF8864C80
        public void get_LongTimePattern(){} // RVA: 0x7FFAF8864D20
        public void get_MonthDayPattern(){} // RVA: 0x7FFAF8864DC0
        public void get_PMDesignator(){} // RVA: 0x7FFAF8864E80
        public void get_RFC1123Pattern(){} // RVA: 0x7FFAF8864EF0
        public void get_ShortDatePattern(){} // RVA: 0x7FFAF8864F30
        public void get_ShortTimePattern(){} // RVA: 0x7FFAF8864FD0
        public void get_SortableDateTimePattern(){} // RVA: 0x7FFAF8865070
        public void get_GeneralShortTimePattern(){} // RVA: 0x7FFAF88650B0
        public void get_GeneralLongTimePattern(){} // RVA: 0x7FFAF8865170
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7FFAF8865230
        public void get_TimeSeparator(){} // RVA: 0x7FFAF8865450
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7FFAF88654C0
        public void get_YearMonthPattern(){} // RVA: 0x7FFAF8865500
        public void get_AbbreviatedDayNames(){} // RVA: 0x7FFAF88655A0
        public void get_DayNames(){} // RVA: 0x7FFAF8865630
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7FFAF88656C0
        public void get_MonthNames(){} // RVA: 0x7FFAF8865750
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7FFAF88657E0
        public void get_HasSpacesInDayNames(){} // RVA: 0x7FFAF8865810
        public void internalGetMonthName(){} // RVA: 0x7FFAF8865840
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7FFAF88659A0
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7FFAF8865B50
        public void GetAbbreviatedDayName(){} // RVA: 0x7FFAF8865C20
        public void GetCombinedPatterns(){} // RVA: 0x7FFAF8865D30
        public void GetAllDateTimePatterns(){} // RVA: 0x7FFAF8865E40
        public void GetDayName(){} // RVA: 0x7FFAF88662F0
        public void GetAbbreviatedMonthName(){} // RVA: 0x7FFAF8866400
        public void GetMonthName(){} // RVA: 0x7FFAF8866510
        public void GetMergedPatterns(){} // RVA: 0x7FFAF8866620
        public void get_AllYearMonthPatterns(){} // RVA: 0x7FFAF8866820
        public void get_AllShortDatePatterns(){} // RVA: 0x7FFAF88668A0
        public void get_AllShortTimePatterns(){} // RVA: 0x7FFAF8866920
        public void get_AllLongDatePatterns(){} // RVA: 0x7FFAF88669A0
        public void get_AllLongTimePatterns(){} // RVA: 0x7FFAF8866A20
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7FFAF8866AA0
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7FFAF8866B70
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7FFAF8866C40
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7FFAF8866D10
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7FFAF8866DA0
        public void ReadOnly(){} // RVA: 0x7FFAF8866E30
        public void get_IsReadOnly(){} // RVA: 0x7FFAF8867050
        public void get_MonthGenitiveNames(){} // RVA: 0x7FFAF88670F0
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7FFAF8867180
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7FFAF88672C0
        public void get_CompareInfo(){} // RVA: 0x7FFAF8867370
        public void ValidateStyles(){} // RVA: 0x7FFAF8867500
        public void get_FormatFlags(){} // RVA: 0x7FFAF8867630
        public void InitializeFormatFlags(){} // RVA: 0x7FFAF8867650
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7FFAF88678A0
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7FFAF88678E0
        public void YearMonthAdjustment(){} // RVA: 0x7FFAF8867910
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7FFAF8867A50
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7FFAF8867C30
        public void ClearTokenHashTable(){} // RVA: 0x7FFAF8867E10
        public void CreateTokenHashTable(){} // RVA: 0x7FFAF8867E90
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7FFAF8868AC0
        public void IsJapaneseCalendar(){} // RVA: 0x7FFAF88698A0
        public void AddMonthNames(){} // RVA: 0x7FFAF88699E0
        public void TryParseHebrewNumber(){} // RVA: 0x7FFAF8869AB0
        public void IsHebrewChar(){} // RVA: 0x7FFAF8869CB0
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7FFAF8869CD0
        public void Tokenize(){} // RVA: 0x7FFAF8869E20
        public void InsertAtCurrentHashNode(){} // RVA: 0x7FFAF886A540
        public void InsertHash(){} // RVA: 0x7FFAF886A780
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7FFAF886AB80
        public void .cctor(){} // RVA: 0x7FFAF886ACB0
    }

    public class DateTimeFormatInfoScanner
    {
        public object Start;

        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x7FFAF886ADA0
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x7FFAF886B410
        public void AddDateWordOrPostfix(){} // RVA: 0x7FFAF886B500
        public void AddDateWords(){} // RVA: 0x7FFAF886B790
        public void ScanRepeatChar(){} // RVA: 0x7FFAF886BA20
        public void AddIgnorableSymbols(){} // RVA: 0x7FFAF886BA80
        public void ScanDateWord(){} // RVA: 0x7FFAF886BC10
        public void GetDateWordsOfDTFI(){} // RVA: 0x7FFAF886BED0
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x7FFAF886C1F0
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x7FFAF886C240
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x7FFAF886C300
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x7FFAF886C340
        public void EqualStringArrays(){} // RVA: 0x7FFAF886C350
        public void ArrayElementsHaveSpace(){} // RVA: 0x7FFAF886C430
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x7FFAF886C530
        public void .ctor(){} // RVA: 0x7FFAF886C750
    }

    public class DaylightTime
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF886C810
        public void get_Start(){} // RVA: 0x7FFAF2DA8380
        public void get_End(){} // RVA: 0x7FFAF2D907C0
        public void get_Delta(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class DaylightTimeStruct
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF886C820
    }

    public class EncodingTable
    {
        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x7FFAF888FA00
        public void ENC(){} // RVA: 0x7FFAF888FA70
        public void MapCodePageDataItem(){} // RVA: 0x7FFAF888FAE0
        public void .cctor(){} // RVA: 0x7FFAF888FB50
        public void internalGetCodePageFromName(){} // RVA: 0x7FFAF8899220
        public void GetCodePageFromName(){} // RVA: 0x7FFAF88995C0
        public void GetCodePageDataItem(){} // RVA: 0x7FFAF8899950
    }

    public class EraInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF887FC60 | overloaded x2
    }

    public class FormatProvider
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x7FFAF92DF860
        public void TryStringToBigInteger(){} // RVA: 0x7FFAF92DF9E0
    }

    public class GlobalizationMode
    {
        public object Invariant;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFAF88787E0
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7FFAF2D8D320
        public void .cctor(){} // RVA: 0x7FFAF8878840
    }

    public class GregorianCalendar
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFAF887D210
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF887D300
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF887D360
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E7FAF0
        public void GetDefaultInstance(){} // RVA: 0x7FFAF887D3C0
        public void .ctor(){} // RVA: 0x7FFAF887D510 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFAF3210030
        public void GetDatePart(){} // RVA: 0x7FFAF887D660
        public void GetAbsoluteDate(){} // RVA: 0x7FFAF887D830
        public void DateToTicks(){} // RVA: 0x7FFAF887DA30
        public void AddMonths(){} // RVA: 0x7FFAF887DAB0
        public void AddYears(){} // RVA: 0x7FFAF887DFD0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF887DFF0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF887E0A0
        public void GetDayOfYear(){} // RVA: 0x7FFAF887E160
        public void GetDaysInMonth(){} // RVA: 0x7FFAF887E210
        public void GetDaysInYear(){} // RVA: 0x7FFAF887E530
        public void GetEra(){} // RVA: 0x7FFAF2E7FAF0
        public void get_Eras(){} // RVA: 0x7FFAF887E710
        public void GetMonth(){} // RVA: 0x7FFAF887E770
        public void GetMonthsInYear(){} // RVA: 0x7FFAF887E820
        public void GetYear(){} // RVA: 0x7FFAF887E9B0
        public void IsLeapDay(){} // RVA: 0x7FFAF887EA60
        public void GetLeapMonth(){} // RVA: 0x7FFAF887EEB0
        public void IsLeapMonth(){} // RVA: 0x7FFAF887F030
        public void IsLeapYear(){} // RVA: 0x7FFAF887F2D0
        public void ToDateTime(){} // RVA: 0x7FFAF887F4A0
        public void TryToDateTime(){} // RVA: 0x7FFAF887F580
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF887F680
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF887F700
        public void ToFourDigitYear(){} // RVA: 0x7FFAF887F820
        public void .cctor(){} // RVA: 0x7FFAF887F9A0
    }

    public class GregorianCalendarHelper
    {
        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0x7FFAF2DDA5C0
        public void .ctor(){} // RVA: 0x7FFAF887FE70
        public void GetYearOffset(){} // RVA: 0x7FFAF887FFA0
        public void GetGregorianYear(){} // RVA: 0x7FFAF8880330
        public void IsValidYear(){} // RVA: 0x7FFAF8880360
        public void GetDatePart(){} // RVA: 0x7FFAF8880380
        public void GetAbsoluteDate(){} // RVA: 0x7FFAF8880570
        public void DateToTicks(){} // RVA: 0x7FFAF8880770
        public void TimeToTicks(){} // RVA: 0x7FFAF88807F0
        public void CheckTicksRange(){} // RVA: 0x7FFAF88809D0
        public void AddMonths(){} // RVA: 0x7FFAF8880C40
        public void AddYears(){} // RVA: 0x7FFAF88811C0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF88811D0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF8881280
        public void GetDayOfYear(){} // RVA: 0x7FFAF88813A0
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8881450
        public void GetDaysInYear(){} // RVA: 0x7FFAF8881600
        public void GetEra(){} // RVA: 0x7FFAF8881690
        public void get_Eras(){} // RVA: 0x7FFAF88817D0
        public void GetMonth(){} // RVA: 0x7FFAF8881940
        public void GetMonthsInYear(){} // RVA: 0x7FFAF88819F0
        public void GetYear(){} // RVA: 0x7FFAF8881A10
        public void IsLeapDay(){} // RVA: 0x7FFAF8881B70
        public void GetLeapMonth(){} // RVA: 0x7FFAF8881D00
        public void IsLeapMonth(){} // RVA: 0x7FFAF8881D20
        public void IsLeapYear(){} // RVA: 0x7FFAF8881E50
        public void ToDateTime(){} // RVA: 0x7FFAF8881ED0
        public void GetWeekOfYear(){} // RVA: 0x7FFAF8882020
        public void ToFourDigitYear(){} // RVA: 0x7FFAF8882140
        public void .cctor(){} // RVA: 0x7FFAF8882340
    }

    public class HebrewNumber
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF886C840
        public void ParseByChar(){} // RVA: 0x7FFAF886CC60
        public void IsDigit(){} // RVA: 0x7FFAF886CE20
        public void .cctor(){} // RVA: 0x7FFAF886CF00
    }

    public class HebrewNumberParsingContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF886C830
    }

    public class HijriCalendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF88824E0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF8882540
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E92CB0
        public void .ctor(){} // RVA: 0x7FFAF88825A0
        public void get_ID(){} // RVA: 0x7FFAF35350E0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAF88825C0
        public void GetAbsoluteDateHijri(){} // RVA: 0x7FFAF88825D0
        public void DaysUpToHijriYear(){} // RVA: 0x7FFAF88826F0
        public void get_HijriAdjustment(){} // RVA: 0x7FFAF88827B0
        public void GetAdvanceHijriDate(){} // RVA: 0x7FFAF2FC9240
        public void CheckTicksRange(){} // RVA: 0x7FFAF8882810
        public void CheckEraRange(){} // RVA: 0x7FFAF8882A90
        public void CheckYearRange(){} // RVA: 0x7FFAF8882B60
        public void CheckYearMonthRange(){} // RVA: 0x7FFAF8882D60
        public void GetDatePart(){} // RVA: 0x7FFAF8882F30
        public void AddMonths(){} // RVA: 0x7FFAF88831D0
        public void AddYears(){} // RVA: 0x7FFAF887DFD0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF8883620
        public void GetDayOfWeek(){} // RVA: 0x7FFAF88836D0
        public void GetDayOfYear(){} // RVA: 0x7FFAF8883790
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8883840
        public void GetDaysInYear(){} // RVA: 0x7FFAF8883910
        public void GetEra(){} // RVA: 0x7FFAF88839B0
        public void get_Eras(){} // RVA: 0x7FFAF8883A80
        public void GetMonth(){} // RVA: 0x7FFAF8883B20
        public void GetMonthsInYear(){} // RVA: 0x7FFAF8883BD0
        public void GetYear(){} // RVA: 0x7FFAF8883C40
        public void IsLeapDay(){} // RVA: 0x7FFAF8883CF0
        public void GetLeapMonth(){} // RVA: 0x7FFAF8883E70
        public void IsLeapMonth(){} // RVA: 0x7FFAF8883ED0
        public void IsLeapYear(){} // RVA: 0x7FFAF8883F40
        public void ToDateTime(){} // RVA: 0x7FFAF8883FC0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF88841E0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF8884260
        public void ToFourDigitYear(){} // RVA: 0x7FFAF8884380
        public void .cctor(){} // RVA: 0x7FFAF8884520
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x7FFAF2ACDD80
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x7FFAF2AC12F0
        public void IsSuffix(){} // RVA: 0x7FFAF2AC12F0
        public void IndexOf(){}
        public void LastIndexOf(){}
    }

    public class IdnMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A2E70
        public void Equals(){} // RVA: 0x7FFAF88A2F40
        public void GetHashCode(){} // RVA: 0x7FFAF88A2FC0
        public void GetAscii(){} // RVA: 0x7FFAF88A30B0 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAF88A31D0
        public void ToAscii(){} // RVA: 0x7FFAF88A3560
        public void VerifyLength(){} // RVA: 0x7FFAF88A39E0
        public void NamePrep(){} // RVA: 0x7FFAF88A3B20
        public void VerifyProhibitedCharacters(){} // RVA: 0x7FFAF88A3C70
        public void VerifyStd3AsciiRules(){} // RVA: 0x7FFAF88A3ED0
        public void GetUnicode(){} // RVA: 0x7FFAF88A4210 | overloaded x2
        public void ToUnicode(){} // RVA: 0x7FFAF88A4330
    }

    public class InternalCodePageDataItem
    {
    }

    public class InternalEncodingDataItem
    {
    }

    public class JapaneseCalendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF88846D0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF8884730
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E7FAF0
        public void GetEraInfo(){} // RVA: 0x7FFAF8884790
        public void GetErasFromRegistry(){} // RVA: 0x7FFAF2FC9240
        public void GetDefaultInstance(){} // RVA: 0x7FFAF8884E40
        public void .ctor(){} // RVA: 0x7FFAF8884F80
        public void get_ID(){} // RVA: 0x7FFAF34E08B0
        public void AddMonths(){} // RVA: 0x7FFAF8885140
        public void AddYears(){} // RVA: 0x7FFAF8885160
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8885190
        public void GetDaysInYear(){} // RVA: 0x7FFAF88851C0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF88851E0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF8885200
        public void GetDayOfYear(){} // RVA: 0x7FFAF8885220
        public void GetMonthsInYear(){} // RVA: 0x7FFAF8885240
        public void GetWeekOfYear(){} // RVA: 0x7FFAF8885270
        public void GetEra(){} // RVA: 0x7FFAF88852A0
        public void GetMonth(){} // RVA: 0x7FFAF88852C0
        public void GetYear(){} // RVA: 0x7FFAF88852E0
        public void IsLeapDay(){} // RVA: 0x7FFAF8885300
        public void IsLeapYear(){} // RVA: 0x7FFAF8885330
        public void GetLeapMonth(){} // RVA: 0x7FFAF8885350
        public void IsLeapMonth(){} // RVA: 0x7FFAF8885380
        public void ToDateTime(){} // RVA: 0x7FFAF88853B0
        public void ToFourDigitYear(){} // RVA: 0x7FFAF88853E0
        public void get_Eras(){} // RVA: 0x7FFAF8885590
        public void EraNames(){} // RVA: 0x7FFAF88855B0
        public void EnglishEraNames(){} // RVA: 0x7FFAF88856C0
        public void IsValidYear(){} // RVA: 0x7FFAF88857D0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF8885800
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF8885880
        public void .cctor(){} // RVA: 0x7FFAF88859D0
    }

    public class NumberFormatInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8885BE0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAF8885A70
        public void OnDeserializing(){} // RVA: 0x7FFAF2D8D310
        public void OnDeserialized(){} // RVA: 0x7FFAF2D8D310
        public void VerifyWritable(){} // RVA: 0x7FFAF8886680
        public void get_InvariantInfo(){} // RVA: 0x7FFAF8886700
        public void GetInstance(){} // RVA: 0x7FFAF8886870
        public void Clone(){} // RVA: 0x7FFAF8886A00
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7FFAF4B867F0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IsReadOnly(){} // RVA: 0x7FFAF3359980
        public void get_CurrencyGroupSizes(){} // RVA: 0x7FFAF8886A70
        public void get_NumberGroupSizes(){} // RVA: 0x7FFAF8886AF0
        public void get_PercentGroupSizes(){} // RVA: 0x7FFAF8886B70
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7FFAF2E08730
        public void get_CurrencySymbol(){} // RVA: 0x7FFAF2E55500
        public void get_CurrentInfo(){} // RVA: 0x7FFAF8886BF0
        public void get_NaNSymbol(){} // RVA: 0x7FFAF2E08D50
        public void set_NaNSymbol(){} // RVA: 0x7FFAF8886D20
        public void get_CurrencyNegativePattern(){} // RVA: 0x7FFAF4346340
        public void get_NumberNegativePattern(){} // RVA: 0x7FFAF3618000
        public void get_PercentPositivePattern(){} // RVA: 0x7FFAF304E510
        public void get_PercentNegativePattern(){} // RVA: 0x7FFAF4759B60
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7FFAF2F77C50
        public void get_NegativeSign(){} // RVA: 0x7FFAF30E74D0
        public void get_NumberDecimalDigits(){} // RVA: 0x7FFAF66F9C20
        public void get_NumberDecimalSeparator(){} // RVA: 0x7FFAF2F476A0
        public void get_NumberGroupSeparator(){} // RVA: 0x7FFAF2E0A740
        public void get_CurrencyPositivePattern(){} // RVA: 0x7FFAF68A1350
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7FFAF2E55590
        public void get_PositiveSign(){} // RVA: 0x7FFAF2DBB130
        public void get_PercentDecimalDigits(){} // RVA: 0x7FFAF34B02A0
        public void get_PercentDecimalSeparator(){} // RVA: 0x7FFAF2F12D00
        public void get_PercentGroupSeparator(){} // RVA: 0x7FFAF2DCC010
        public void get_PercentSymbol(){} // RVA: 0x7FFAF3246DE0
        public void get_PerMilleSymbol(){} // RVA: 0x7FFAF34CC8C0
        public void GetFormat(){} // RVA: 0x7FFAF8886E50
        public void ReadOnly(){} // RVA: 0x7FFAF8886F30
        public void ValidateParseStyleInteger(){} // RVA: 0x7FFAF8887000
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7FFAF88870F0
    }

    public class Punycode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A4F80
    }

    public class RegionInfo
    {
        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x7FFAF88A4FC0
        public void .ctor(){} // RVA: 0x7FFAF88A5460 | overloaded x3
        public void GetByTerritory(){} // RVA: 0x7FFAF88A58F0
        public void construct_internal_region_from_name(){} // RVA: 0x7FFAF88A59A0
        public void get_CurrencyEnglishName(){} // RVA: 0x7FFAF2E2E0E0
        public void get_CurrencySymbol(){} // RVA: 0x7FFAF2E0A740
        public void get_DisplayName(){} // RVA: 0x7FFAF30E74D0
        public void get_EnglishName(){} // RVA: 0x7FFAF30E74D0
        public void get_GeoId(){} // RVA: 0x7FFAF2DDA5C0
        public void get_IsMetric(){} // RVA: 0x7FFAF88A5B30
        public void get_ISOCurrencySymbol(){} // RVA: 0x7FFAF2E08730
        public void get_NativeName(){} // RVA: 0x7FFAF2F476A0
        public void get_CurrencyNativeName(){} // RVA: 0x7FFAF2E55500
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_ThreeLetterISORegionName(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0x7FFAF2DBB130
        public void get_TwoLetterISORegionName(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF88A5C00
        public void GetHashCode(){} // RVA: 0x7FFAF88A5D10
        public void ToString(){} // RVA: 0x7FFAF88A5D50
        public void ClearCachedData(){} // RVA: 0x7FFAF88A5D70
    }

    public class SortKey
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAF888C9C0
        public void .ctor(){} // RVA: 0x7FFAF888D0B0 | overloaded x4
        public void get_OriginalString(){} // RVA: 0x7FFAF2DA8380
        public void get_KeyData(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF888CE50
        public void GetHashCode(){} // RVA: 0x7FFAF888CF00
        public void ToString(){} // RVA: 0x7FFAF888CF70
    }

    public class SortVersion
    {
    }

    public class TaiwanCalendar
    {
        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x7FFAF88871D0
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF8887310
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF8887370
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E7FAF0
        public void .ctor(){} // RVA: 0x7FFAF88873D0
        public void get_ID(){} // RVA: 0x7FFAF352E130
        public void AddMonths(){} // RVA: 0x7FFAF8885140
        public void AddYears(){} // RVA: 0x7FFAF8885160
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8885190
        public void GetDaysInYear(){} // RVA: 0x7FFAF88851C0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF88851E0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF8885200
        public void GetDayOfYear(){} // RVA: 0x7FFAF8885220
        public void GetMonthsInYear(){} // RVA: 0x7FFAF8885240
        public void GetWeekOfYear(){} // RVA: 0x7FFAF8885270
        public void GetEra(){} // RVA: 0x7FFAF88852A0
        public void GetMonth(){} // RVA: 0x7FFAF88852C0
        public void GetYear(){} // RVA: 0x7FFAF88852E0
        public void IsLeapDay(){} // RVA: 0x7FFAF8885300
        public void IsLeapYear(){} // RVA: 0x7FFAF8885330
        public void GetLeapMonth(){} // RVA: 0x7FFAF8885350
        public void IsLeapMonth(){} // RVA: 0x7FFAF8885380
        public void ToDateTime(){} // RVA: 0x7FFAF88853B0
        public void get_Eras(){} // RVA: 0x7FFAF8885590
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF8885800
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF88875A0
        public void ToFourDigitYear(){} // RVA: 0x7FFAF88876F0
        public void .cctor(){} // RVA: 0x7FFAF88878A0
    }

    public class TextInfo
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFAF8887A60
        public void .ctor(){} // RVA: 0x7FFAF8889E50 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFAF8887C90
        public void OnDeserialized(){} // RVA: 0x7FFAF8887F00 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAF8887F10
        public void get_CultureName(){} // RVA: 0x7FFAF30E74D0
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2DA84E0
        public void Clone(){} // RVA: 0x7FFAF8887FF0
        public void ReadOnly(){} // RVA: 0x7FFAF8888070
        public void SetReadOnlyState(){} // RVA: 0x7FFAF2DA84F0
        public void get_ListSeparator(){} // RVA: 0x7FFAF8888160
        public void ToLower(){} // RVA: 0x7FFAF8888240 | overloaded x2
        public void ToLowerAsciiInvariant(){} // RVA: 0x7FFAF8888370
        public void ToUpper(){} // RVA: 0x7FFAF88883F0 | overloaded x2
        public void ToUpperAsciiInvariant(){} // RVA: 0x7FFAF8889C70 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFAF8888540
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7FFAF8888550
        public void Equals(){} // RVA: 0x7FFAF88886A0
        public void GetHashCode(){} // RVA: 0x7FFAF8888780
        public void ToString(){} // RVA: 0x7FFAF88887B0
        public void ToTitleCase(){} // RVA: 0x7FFAF8888810
        public void AddNonLetter(){} // RVA: 0x7FFAF8888CE0
        public void AddTitlecaseLetter(){} // RVA: 0x7FFAF8888DA0
        public void IsWordSeparator(){} // RVA: 0x7FFAF8888FC0
        public void IsLetterCategory(){} // RVA: 0x7FFAF8888FD0
        public void get_IsRightToLeft(){} // RVA: 0x7FFAF8888FE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF8887F00
        public void ToUpperInternal(){} // RVA: 0x7FFAF88891C0 | overloaded x2
        public void ToLowerInternal(){} // RVA: 0x7FFAF8889790 | overloaded x2
        public void ChangeCase(){} // RVA: 0x7FFAF8889D20
    }

    public class TextInfoToLowerData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF889A280
    }

    public class TextInfoToUpperData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8899D20
    }

    public class ThaiBuddhistCalendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF8889E80
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF8889EE0
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E7FAF0
        public void .ctor(){} // RVA: 0x7FFAF8889F40
        public void get_ID(){} // RVA: 0x7FFAF3517BB0
        public void AddMonths(){} // RVA: 0x7FFAF8885140
        public void AddYears(){} // RVA: 0x7FFAF8885160
        public void GetDaysInMonth(){} // RVA: 0x7FFAF8885190
        public void GetDaysInYear(){} // RVA: 0x7FFAF88851C0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF88851E0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF8885200
        public void GetDayOfYear(){} // RVA: 0x7FFAF8885220
        public void GetMonthsInYear(){} // RVA: 0x7FFAF8885240
        public void GetWeekOfYear(){} // RVA: 0x7FFAF8885270
        public void GetEra(){} // RVA: 0x7FFAF88852A0
        public void GetMonth(){} // RVA: 0x7FFAF88852C0
        public void GetYear(){} // RVA: 0x7FFAF88852E0
        public void IsLeapDay(){} // RVA: 0x7FFAF8885300
        public void IsLeapYear(){} // RVA: 0x7FFAF8885330
        public void GetLeapMonth(){} // RVA: 0x7FFAF8885350
        public void IsLeapMonth(){} // RVA: 0x7FFAF8885380
        public void ToDateTime(){} // RVA: 0x7FFAF88853B0
        public void get_Eras(){} // RVA: 0x7FFAF8885590
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF888A040
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF888A0C0
        public void ToFourDigitYear(){} // RVA: 0x7FFAF888A210
        public void .cctor(){} // RVA: 0x7FFAF888A2D0
    }

    public class TimeSpanFormat
    {
        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x7FFAF886D370
        public void Format(){} // RVA: 0x7FFAF886D4F0
        public void TryFormat(){} // RVA: 0x7FFAF886D5F0
        public void FormatToBuilder(){} // RVA: 0x7FFAF886D6F0
        public void FormatStandard(){} // RVA: 0x7FFAF886DA10
        public void FormatCustomized(){} // RVA: 0x7FFAF886E000
        public void .cctor(){} // RVA: 0x7FFAF886E840
    }

    public class TimeSpanParse
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x7FFAF886F2B0
        public void TryTimeToTicks(){} // RVA: 0x7FFAF886F3B0
        public void Parse(){} // RVA: 0x7FFAF886F560
        public void TryParse(){} // RVA: 0x7FFAF886F5A0
        public void ParseExact(){} // RVA: 0x7FFAF886F600
        public void TryParseExact(){} // RVA: 0x7FFAF886F650
        public void ParseExactMultiple(){} // RVA: 0x7FFAF886F6C0
        public void TryParseExactMultiple(){} // RVA: 0x7FFAF886F700
        public void TryParseTimeSpan(){} // RVA: 0x7FFAF886F760
        public void ProcessTerminalState(){} // RVA: 0x7FFAF8870900
        public void ProcessTerminal_DHMSF(){} // RVA: 0x7FFAF8870A70
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x7FFAF8870EC0
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x7FFAF88729B0
        public void ProcessTerminal_HM(){} // RVA: 0x7FFAF8873FD0
        public void ProcessTerminal_D(){} // RVA: 0x7FFAF8874300
        public void TryParseExactTimeSpan(){} // RVA: 0x7FFAF8874610
        public void TryParseByFormat(){} // RVA: 0x7FFAF88747B0
        public void ParseExactDigits(){} // RVA: 0x7FFAF88753E0 | overloaded x2
        public void ParseExactLiteral(){} // RVA: 0x7FFAF88754C0
        public void TryParseTimeSpanConstant(){} // RVA: 0x7FFAF8875580
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x7FFAF88755C0
    }

    public class UmAlQuraCalendar
    {
        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x7FFAF888A440
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAF888A620
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAF888A680
        public void get_AlgorithmType(){} // RVA: 0x7FFAF2E92CB0
        public void .ctor(){} // RVA: 0x7FFAF8878940
        public void get_BaseCalendarID(){} // RVA: 0x7FFAF35350E0
        public void get_ID(){} // RVA: 0x7FFAF34AD990
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAF888A6E0
        public void ConvertHijriToGregorian(){} // RVA: 0x7FFAF888A6F0
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x7FFAF888A960
        public void CheckTicksRange(){} // RVA: 0x7FFAF888AA30
        public void CheckEraRange(){} // RVA: 0x7FFAF888ACB0
        public void CheckYearRange(){} // RVA: 0x7FFAF888AD40
        public void CheckYearMonthRange(){} // RVA: 0x7FFAF888AF00
        public void ConvertGregorianToHijri(){} // RVA: 0x7FFAF888AFE0
        public void GetDatePart(){} // RVA: 0x7FFAF888B400
        public void AddMonths(){} // RVA: 0x7FFAF888B5E0
        public void AddYears(){} // RVA: 0x7FFAF887DFD0
        public void GetDayOfMonth(){} // RVA: 0x7FFAF888B9D0
        public void GetDayOfWeek(){} // RVA: 0x7FFAF888B9F0
        public void GetDayOfYear(){} // RVA: 0x7FFAF888BAB0
        public void GetDaysInMonth(){} // RVA: 0x7FFAF888BAD0
        public void RealGetDaysInYear(){} // RVA: 0x7FFAF888BB90
        public void GetDaysInYear(){} // RVA: 0x7FFAF888BC40
        public void GetEra(){} // RVA: 0x7FFAF888BCB0
        public void get_Eras(){} // RVA: 0x7FFAF888BD70
        public void GetMonth(){} // RVA: 0x7FFAF888BDD0
        public void GetMonthsInYear(){} // RVA: 0x7FFAF888BDF0
        public void GetYear(){} // RVA: 0x7FFAF888BE60
        public void IsLeapDay(){} // RVA: 0x7FFAF888BE80
        public void GetLeapMonth(){} // RVA: 0x7FFAF888C020
        public void IsLeapMonth(){} // RVA: 0x7FFAF888C080
        public void IsLeapYear(){} // RVA: 0x7FFAF888C0F0
        public void ToDateTime(){} // RVA: 0x7FFAF888C160
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAF88841E0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAF888C430
        public void ToFourDigitYear(){} // RVA: 0x7FFAF888C560
        public void .cctor(){} // RVA: 0x7FFAF888C700
    }

}