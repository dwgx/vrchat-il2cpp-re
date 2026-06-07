// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 40
// Methods: 822

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF4700
        public void Encode(){} // RVA: 0x5DF4730
        public void EncodeDigit(){} // RVA: 0x5DF4BF0
        public void DecodeDigit(){} // RVA: 0x5DF4C10
        public void Adapt(){} // RVA: 0x5DF4C40
        public void Decode(){} // RVA: 0x5DF4CC0
    }

    public class Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x5DC8880
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DC88E0
        public void .ctor(){} // RVA: 0x5DC8940
        public void get_ID(){} // RVA: 0x75BB20
        public void get_BaseCalendarID(){} // RVA: 0x1CA1C00
        public void get_AlgorithmType(){} // RVA: 0x519240
        public void get_IsReadOnly(){} // RVA: 0x42CBD0
        public void Clone(){} // RVA: 0x5DC8950
        public void ReadOnly(){} // RVA: 0x5DC89D0
        public void VerifyWritable(){} // RVA: 0x5DC8AC0
        public void SetReadOnlyState(){} // RVA: 0x42CBE0
        public void get_CurrentEraValue(){} // RVA: 0x5DC8B40
        public void CheckAddResult(){} // RVA: 0x5DC8BD0
        public void AddMonths(){}
        public void AddYears(){}
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x5DC8DB0 | overloaded x2
        public void GetDaysInYear(){} // RVA: 0x14170
        public void GetEra(){}
        public void get_Eras(){} // RVA: 0xCD60
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x14170
        public void GetFirstDayWeekOfYear(){} // RVA: 0x5DC8DE0
        public void GetWeekOfYearFullDays(){} // RVA: 0x5DC8EA0
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x5DC90E0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x5DC9250
        public void GetWeekOfYear(){} // RVA: 0x5DC9260
        public void GetYear(){}
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void GetLeapMonth(){} // RVA: 0x5DC9590
        public void IsLeapYear(){} // RVA: 0x5DC9650 | overloaded x2
        public void ToDateTime(){} // RVA: 0x5DC9670 | overloaded x2
        public void TryToDateTime(){} // RVA: 0x5DC96D0
        public void IsValidYear(){} // RVA: 0x5DC97D0
        public void IsValidMonth(){} // RVA: 0x5DC9860
        public void IsValidDay(){} // RVA: 0x5DC98E0
        public void get_TwoDigitYearMax(){} // RVA: 0x5BED50
        public void set_TwoDigitYearMax(){} // RVA: 0x5DC9970
        public void ToFourDigitYear(){} // RVA: 0x5DC99A0
        public void TimeToTicks(){} // RVA: 0x5DC9AB0
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x5DC9C90
    }

    public class CalendarData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DCB030 | overloaded x2
        public void .cctor(){} // RVA: 0x5DC9CF0
        public void InitializeEraNames(){} // RVA: 0x5DCBED0
        public void GetJapaneseEraNames(){} // RVA: 0x5DCC3E0
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x5DCC600
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x5DCC820
        public void GetCalendarData(){} // RVA: 0x5DCCC60
        public void CalendarIdToCultureName(){} // RVA: 0x5DCCE90
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x75BB20
        public void nativeGetCalendarData(){} // RVA: 0x5DCD060
        public void fill_calendar_data(){} // RVA: 0x5DCD200
    }

    public class CharUnicodeInfo
    {
        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x5DAB530 | overloaded x2
        public void InternalGetNumericValue(){} // RVA: 0x5DAB5E0
        public void GetNumericValue(){} // RVA: 0x5DAB7C0 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x5DAB9F0 | overloaded x3
        public void InternalGetCategoryValue(){} // RVA: 0x5DABB70
        public void InternalGetUnicodeCategory(){} // RVA: 0x5DABDA0 | overloaded x2
        public void IsWhiteSpace(){} // RVA: 0x5DABF20 | overloaded x2
        public void get_CategoryLevel1Index(){} // RVA: 0x5DABF40
        public void get_CategoryLevel2Index(){} // RVA: 0x5DABFA0
        public void get_CategoryLevel3Index(){} // RVA: 0x5DAC000
        public void get_CategoriesValue(){} // RVA: 0x5DAC060
        public void get_NumericLevel1Index(){} // RVA: 0x5DAC0C0
        public void get_NumericLevel2Index(){} // RVA: 0x5DAC120
        public void get_NumericLevel3Index(){} // RVA: 0x5DAC180
        public void get_NumericValues(){} // RVA: 0x5DAC1E0
    }

    public class CodePageDataItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DDF390
        public void CreateString(){} // RVA: 0x5DDF450
        public void get_WebName(){} // RVA: 0x5DDF5A0
        public void get_HeaderName(){} // RVA: 0x5DDF6C0
        public void get_BodyName(){} // RVA: 0x5DDF7F0
        public void .cctor(){} // RVA: 0x5DDF920
    }

    public class CompareInfo
    {
        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x5DAC240
        public void InvariantLastIndexOf(){} // RVA: 0x5DAC310
        public void InvariantFindString(){} // RVA: 0x5DAC3F0
        public void InvariantToUpper(){} // RVA: 0x5DAC7F0
        public void InvariantCreateSortKey(){} // RVA: 0x5DAC810
        public void .ctor(){} // RVA: 0x5DB21A0 | overloaded x2
        public void GetCompareInfo(){} // RVA: 0x5DACBD0
        public void OnDeserializing(){} // RVA: 0x574FB20
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5DACC90
        public void OnDeserialized(){} // RVA: 0x5DACCA0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x5DACDF0
        public void get_Name(){} // RVA: 0x5DACE90
        public void Compare(){} // RVA: 0x5DAD9E0 | overloaded x4
        public void CompareOptionNone(){} // RVA: 0x5DAD750
        public void CompareOptionIgnoreCase(){} // RVA: 0x5DAD8B0
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x5DAE120 | overloaded x2
        public void IsPrefix(){} // RVA: 0x5DAE5E0 | overloaded x2
        public void IsSuffix(){} // RVA: 0x5DAE960 | overloaded x2
        public void IndexOf(){} // RVA: 0x5DAF370 | overloaded x5
        public void IndexOfOrdinal(){} // RVA: 0x5DAF4D0
        public void LastIndexOf(){} // RVA: 0x5DAF720 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x5DAFB00
        public void GetSortKey(){} // RVA: 0x5DAFCD0
        public void Equals(){} // RVA: 0x5DAFE50
        public void GetHashCode(){} // RVA: 0x5DB0520 | overloaded x2
        public void GetIgnoreCaseHash(){} // RVA: 0x5DAFFA0
        public void GetHashCodeOfString(){} // RVA: 0x5DB0350
        public void ToString(){} // RVA: 0x5DB0630
        public void get_UseManagedCollation(){} // RVA: 0x5DB0690
        public void GetCollator(){} // RVA: 0x5DB0800
        public void CreateSortKeyCore(){} // RVA: 0x5DB0C80
        public void internal_index_switch(){} // RVA: 0x5DB0F20
        public void internal_compare_switch(){} // RVA: 0x5DB11A0
        public void internal_compare_managed(){} // RVA: 0x5DB13A0
        public void internal_index_managed(){} // RVA: 0x5DB14A0
        public void internal_compare_icall(){} // RVA: 0x5DB1550
        public void internal_compare(){} // RVA: 0x5DB1560
        public void internal_index_icall(){} // RVA: 0x5DB1610
        public void internal_index(){} // RVA: 0x5DB1700
        public void InitSort(){} // RVA: 0x5DB1840
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x5DB18B0
        public void IndexOfOrdinalCore(){} // RVA: 0x5DB1A70
        public void LastIndexOfOrdinalCore(){} // RVA: 0x5DB1AB0
        public void LastIndexOfCore(){} // RVA: 0x5DB1AF0
        public void IndexOfCore(){} // RVA: 0x5DB1B30
        public void CompareString(){} // RVA: 0x5DB1C30 | overloaded x2
        public void CreateSortKey(){} // RVA: 0x5DB1D40
        public void StartsWith(){} // RVA: 0x5DAE5E0 | overloaded x2
        public void EndsWith(){} // RVA: 0x5DAE960 | overloaded x2
        public void GetHashCodeOfStringCore(){} // RVA: 0x5DB2040
        public void .cctor(){} // RVA: 0x5DB2080
    }

    public class CultureData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A5510
        public void get_Invariant(){} // RVA: 0x5DDD0E0
        public void GetCultureData(){} // RVA: 0x5DDD890 | overloaded x2
        public void fill_culture_data(){} // RVA: 0x5DDDA80
        public void GetCalendar(){} // RVA: 0x5DDDA90
        public void get_LongTimes(){} // RVA: 0x407FEB0
        public void get_ShortTimes(){} // RVA: 0x5DDDC00
        public void get_SISO639LANGNAME(){} // RVA: 0x37E0E0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0xFDC9F0
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x891AF0
        public void get_SAM1159(){} // RVA: 0x2F8380
        public void get_SPM2359(){} // RVA: 0x2E07C0
        public void get_TimeSeparator(){} // RVA: 0x30B0C0
        public void get_CalendarIds(){} // RVA: 0x5DDDC10
        public void GetCalendarIds(){} // RVA: 0x5DDDEB0
        public void get_IsInvariantCulture(){} // RVA: 0x5DDDF90
        public void get_CultureName(){} // RVA: 0x3A5500
        public void get_SCOMPAREINFO(){} // RVA: 0x5DDDFB0
        public void get_STEXTINFO(){} // RVA: 0x3A5500
        public void get_IsRightToLeft(){} // RVA: 0x8A89C0
        public void get_SLIST(){} // RVA: 0x462D00
        public void get_UseUserOverride(){} // RVA: 0x306020
        public void EraNames(){} // RVA: 0x5DDDFF0
        public void AbbrevEraNames(){} // RVA: 0x5DDE010
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x5DDE030
        public void ShortDates(){} // RVA: 0x5DDE050
        public void LongDates(){} // RVA: 0x5DDE070
        public void YearMonths(){} // RVA: 0x5DDE090
        public void DayNames(){} // RVA: 0x5DDE0B0
        public void AbbreviatedDayNames(){} // RVA: 0x5DDE0D0
        public void MonthNames(){} // RVA: 0x5DDE0F0
        public void GenitiveMonthNames(){} // RVA: 0x5DDE110
        public void AbbreviatedMonthNames(){} // RVA: 0x5DDE130
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x5DDE150
        public void LeapYearMonthNames(){} // RVA: 0x5DDE180
        public void MonthDay(){} // RVA: 0x5DDE1B0
        public void DateSeparator(){} // RVA: 0x5DDE1D0
        public void GetDateSeparator(){} // RVA: 0x5DDE2B0
        public void GetSeparator(){} // RVA: 0x5DDE300
        public void IndexOfTimePart(){} // RVA: 0x5DDE4E0
        public void UnescapeNlsString(){} // RVA: 0x5DDE600
        public void ReescapeWin32Strings(){} // RVA: 0x1A3F520
        public void ReescapeWin32String(){} // RVA: 0x1A3F520
        public void strlen(){} // RVA: 0x5DDE7C0
        public void idx2string(){} // RVA: 0x5DDE7E0
        public void create_group_sizes_array(){} // RVA: 0x5DDE910
        public void GetNFIValues(){} // RVA: 0x5DDE9C0
        public void fill_number_data(){} // RVA: 0x5DDF2D0
    }

    public class CultureInfo
    {
        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x348120
        public void get__isInherited(){} // RVA: 0x126AF80
        public void get_InvariantCulture(){} // RVA: 0x5DEA880
        public void get_CurrentCulture(){} // RVA: 0x5DEA8E0
        public void get_CurrentUICulture(){} // RVA: 0x5DEA930
        public void set_CurrentUICulture(){} // RVA: 0x5DEA980
        public void ConstructCurrentCulture(){} // RVA: 0x5DEA9B0
        public void ConstructCurrentUICulture(){} // RVA: 0x5DEAC10
        public void get_Territory(){} // RVA: 0x4C7C50
        public void get__name(){} // RVA: 0x358730
        public void get_IetfLanguageTag(){} // RVA: 0x5DEAC60
        public void get_LCID(){} // RVA: 0x8ABED0
        public void get_Name(){} // RVA: 0x358730
        public void get_NativeName(){} // RVA: 0x5DEADA0
        public void get_Calendar(){} // RVA: 0x5DEAE10
        public void get_Parent(){} // RVA: 0x5DEAEE0
        public void get_TextInfo(){} // RVA: 0x5DEB1C0
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x5DEB410
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x5DEB480
        public void Clone(){} // RVA: 0x5DEB4F0
        public void Equals(){} // RVA: 0x5DEB750
        public void GetCultures(){} // RVA: 0x5DEB830
        public void GetTextInfoData(){} // RVA: 0x5DEBC30
        public void GetHashCode(){} // RVA: 0x8ABED0
        public void ReadOnly(){} // RVA: 0x5DEBC50
        public void ToString(){} // RVA: 0x358730
        public void get_CompareInfo(){} // RVA: 0x5DEBEE0
        public void get_IsNeutralCulture(){} // RVA: 0x5DEC1A0
        public void CheckNeutral(){} // RVA: 0x2DD310
        public void get_NumberFormat(){} // RVA: 0x5DEC1E0
        public void set_NumberFormat(){} // RVA: 0x5DEC2D0
        public void get_DateTimeFormat(){} // RVA: 0x5DEC440
        public void set_DateTimeFormat(){} // RVA: 0x5DEC650
        public void get_DisplayName(){} // RVA: 0x5DEC7C0
        public void get_EnglishName(){} // RVA: 0x5DEC7E0
        public void get_InstalledUICulture(){} // RVA: 0x5DEC850
        public void get_IsReadOnly(){} // RVA: 0x3A75E0
        public void GetFormat(){} // RVA: 0x5DEC8A0
        public void Construct(){} // RVA: 0x5DEC9F0
        public void construct_internal_locale_from_lcid(){} // RVA: 0x5DECA50
        public void construct_internal_locale_from_name(){} // RVA: 0x5DECAB0
        public void get_current_locale_name(){} // RVA: 0x5DECC40
        public void internal_get_cultures(){} // RVA: 0x5DECCC0
        public void ConstructInvariant(){} // RVA: 0x5DECCD0
        public void CreateTextInfo(){} // RVA: 0x5DED250
        public void .ctor(){} // RVA: 0x5DEDA90 | overloaded x7
        public void insert_into_shared_tables(){} // RVA: 0x5DEDAA0
        public void GetCultureInfo(){} // RVA: 0x5DEE3C0 | overloaded x3
        public void CreateCulture(){} // RVA: 0x5DEE4C0
        public void CreateSpecificCulture(){} // RVA: 0x5DEE550
        public void ConstructLocaleFromName(){} // RVA: 0x5DEE8B0
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x5DEE960
        public void get_CalendarType(){} // RVA: 0x5DF1BA0
        public void CreateCalendar(){} // RVA: 0x5DF1C40
        public void CreateNotFoundException(){} // RVA: 0x5DF1E60
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x5DF1F10
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x5DF1F70
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x5DF2030
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x5DF2090
        public void get_SortName(){} // RVA: 0x358730
        public void get_UserDefaultUICulture(){} // RVA: 0x5DF2150
        public void get_UserDefaultCulture(){} // RVA: 0x5DF21D0
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x5D42EB0
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x2DD310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x5DF2220
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x5DF23B0
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x5DF24B0
        public void get_HasInvariantCultureName(){} // RVA: 0x5DF2620
        public void VerifyCultureName(){} // RVA: 0x5DF28A0 | overloaded x2
        public void .cctor(){} // RVA: 0x5DF2940
    }

    public class CultureNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DB2240 | overloaded x3
        public void GetObjectData(){} // RVA: 0x5DB2550
        public void get_InvalidCultureId(){} // RVA: 0xA085E0
        public void get_InvalidCultureName(){} // RVA: 0xA1C8C0
        public void get_DefaultMessage(){} // RVA: 0x5DB2890
        public void get_FormatedInvalidCultureId(){} // RVA: 0x5DB28D0
        public void get_Message(){} // RVA: 0x5DB2A40
    }

    public class DateTimeFormatInfo
    {
        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x5DB2C40
        public void get_Culture(){} // RVA: 0x5DB2CB0
        public void get_LanguageName(){} // RVA: 0x5DB2D70
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x5DB2DE0
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x5DB2E00
        public void internalGetDayOfWeekNames(){} // RVA: 0x5DB2EC0
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x5DB2EE0
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x5DB2FA0
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x5DB2FC0
        public void internalGetMonthNames(){} // RVA: 0x5DB3080
        public void internalGetMonthNamesCore(){} // RVA: 0x5DB30A0
        public void .ctor(){} // RVA: 0x5DB3330 | overloaded x2
        public void InitializeOverridableProperties(){} // RVA: 0x5DB33A0
        public void get_InvariantInfo(){} // RVA: 0x5DB3820
        public void get_CurrentInfo(){} // RVA: 0x5DB3970
        public void GetInstance(){} // RVA: 0x5DB3AC0
        public void GetFormat(){} // RVA: 0x5DB3C50
        public void Clone(){} // RVA: 0x5DB3D30
        public void get_AMDesignator(){} // RVA: 0x5DB3EB0
        public void get_Calendar(){} // RVA: 0x4C7C50
        public void set_Calendar(){} // RVA: 0x5DB3F20
        public void get_OptionalCalendars(){} // RVA: 0x5DB43C0
        public void get_EraNames(){} // RVA: 0x5DB4530
        public void GetEraName(){} // RVA: 0x5DB4600
        public void get_AbbreviatedEraNames(){} // RVA: 0x5DB47A0
        public void GetAbbreviatedEraName(){} // RVA: 0x5DB4870
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x5DB4A30
        public void get_DateSeparator(){} // RVA: 0x5DB4B00
        public void get_FullDateTimePattern(){} // RVA: 0x5DB4BB0
        public void get_LongDatePattern(){} // RVA: 0x5DB4C80
        public void get_LongTimePattern(){} // RVA: 0x5DB4D20
        public void get_MonthDayPattern(){} // RVA: 0x5DB4DC0
        public void get_PMDesignator(){} // RVA: 0x5DB4E80
        public void get_RFC1123Pattern(){} // RVA: 0x5DB4EF0
        public void get_ShortDatePattern(){} // RVA: 0x5DB4F30
        public void get_ShortTimePattern(){} // RVA: 0x5DB4FD0
        public void get_SortableDateTimePattern(){} // RVA: 0x5DB5070
        public void get_GeneralShortTimePattern(){} // RVA: 0x5DB50B0
        public void get_GeneralLongTimePattern(){} // RVA: 0x5DB5170
        public void get_DateTimeOffsetPattern(){} // RVA: 0x5DB5230
        public void get_TimeSeparator(){} // RVA: 0x5DB5450
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x5DB54C0
        public void get_YearMonthPattern(){} // RVA: 0x5DB5500
        public void get_AbbreviatedDayNames(){} // RVA: 0x5DB55A0
        public void get_DayNames(){} // RVA: 0x5DB5630
        public void get_AbbreviatedMonthNames(){} // RVA: 0x5DB56C0
        public void get_MonthNames(){} // RVA: 0x5DB5750
        public void get_HasSpacesInMonthNames(){} // RVA: 0x5DB57E0
        public void get_HasSpacesInDayNames(){} // RVA: 0x5DB5810
        public void internalGetMonthName(){} // RVA: 0x5DB5840
        public void internalGetGenitiveMonthNames(){} // RVA: 0x5DB59A0
        public void internalGetLeapYearMonthNames(){} // RVA: 0x5DB5B50
        public void GetAbbreviatedDayName(){} // RVA: 0x5DB5C20
        public void GetCombinedPatterns(){} // RVA: 0x5DB5D30
        public void GetAllDateTimePatterns(){} // RVA: 0x5DB5E40
        public void GetDayName(){} // RVA: 0x5DB62F0
        public void GetAbbreviatedMonthName(){} // RVA: 0x5DB6400
        public void GetMonthName(){} // RVA: 0x5DB6510
        public void GetMergedPatterns(){} // RVA: 0x5DB6620
        public void get_AllYearMonthPatterns(){} // RVA: 0x5DB6820
        public void get_AllShortDatePatterns(){} // RVA: 0x5DB68A0
        public void get_AllShortTimePatterns(){} // RVA: 0x5DB6920
        public void get_AllLongDatePatterns(){} // RVA: 0x5DB69A0
        public void get_AllLongTimePatterns(){} // RVA: 0x5DB6A20
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x5DB6AA0
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x5DB6B70
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x5DB6C40
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x5DB6D10
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x5DB6DA0
        public void ReadOnly(){} // RVA: 0x5DB6E30
        public void get_IsReadOnly(){} // RVA: 0x5DB7050
        public void get_MonthGenitiveNames(){} // RVA: 0x5DB70F0
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x5DB7180
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x5DB72C0
        public void get_CompareInfo(){} // RVA: 0x5DB7370
        public void ValidateStyles(){} // RVA: 0x5DB7500
        public void get_FormatFlags(){} // RVA: 0x5DB7630
        public void InitializeFormatFlags(){} // RVA: 0x5DB7650
        public void get_HasForceTwoDigitYears(){} // RVA: 0x5DB78A0
        public void get_HasYearMonthAdjustment(){} // RVA: 0x5DB78E0
        public void YearMonthAdjustment(){} // RVA: 0x5DB7910
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x5DB7A50
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x5DB7C30
        public void ClearTokenHashTable(){} // RVA: 0x5DB7E10
        public void CreateTokenHashTable(){} // RVA: 0x5DB7E90
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x5DB8AC0
        public void IsJapaneseCalendar(){} // RVA: 0x5DB98A0
        public void AddMonthNames(){} // RVA: 0x5DB99E0
        public void TryParseHebrewNumber(){} // RVA: 0x5DB9AB0
        public void IsHebrewChar(){} // RVA: 0x5DB9CB0
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x5DB9CD0
        public void Tokenize(){} // RVA: 0x5DB9E20
        public void InsertAtCurrentHashNode(){} // RVA: 0x5DBA540
        public void InsertHash(){} // RVA: 0x5DBA780
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x5DBAB80
        public void .cctor(){} // RVA: 0x5DBACB0
    }

    public class DateTimeFormatInfoScanner
    {
        public object Start;

        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x5DBADA0
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x5DBB410
        public void AddDateWordOrPostfix(){} // RVA: 0x5DBB500
        public void AddDateWords(){} // RVA: 0x5DBB790
        public void ScanRepeatChar(){} // RVA: 0x5DBBA20
        public void AddIgnorableSymbols(){} // RVA: 0x5DBBA80
        public void ScanDateWord(){} // RVA: 0x5DBBC10
        public void GetDateWordsOfDTFI(){} // RVA: 0x5DBBED0
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x5DBC1F0
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x5DBC240
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x5DBC300
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x5DBC340
        public void EqualStringArrays(){} // RVA: 0x5DBC350
        public void ArrayElementsHaveSpace(){} // RVA: 0x5DBC430
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x5DBC530
        public void .ctor(){} // RVA: 0x5DBC750
    }

    public class DaylightTime
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DBC810
        public void get_Start(){} // RVA: 0x2F8380
        public void get_End(){} // RVA: 0x2E07C0
        public void get_Delta(){} // RVA: 0x30B0C0
    }

    public class DaylightTimeStruct
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DBC820
    }

    public class EncodingTable
    {
        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x5DDFA00
        public void ENC(){} // RVA: 0x5DDFA70
        public void MapCodePageDataItem(){} // RVA: 0x5DDFAE0
        public void .cctor(){} // RVA: 0x5DDFB50
        public void internalGetCodePageFromName(){} // RVA: 0x5DE9220
        public void GetCodePageFromName(){} // RVA: 0x5DE95C0
        public void GetCodePageDataItem(){} // RVA: 0x5DE9950
    }

    public class EraInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DCFC60 | overloaded x2
    }

    public class FormatProvider
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x682F860
        public void TryStringToBigInteger(){} // RVA: 0x682F9E0
    }

    public class GlobalizationMode
    {
        public object Invariant;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x5DC87E0
        public void GetGlobalizationInvariantMode(){} // RVA: 0x2DD320
        public void .cctor(){} // RVA: 0x5DC8840
    }

    public class GregorianCalendar
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x5DCD210
        public void get_MinSupportedDateTime(){} // RVA: 0x5DCD300
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DCD360
        public void get_AlgorithmType(){} // RVA: 0x3CFAF0
        public void GetDefaultInstance(){} // RVA: 0x5DCD3C0
        public void .ctor(){} // RVA: 0x5DCD510 | overloaded x2
        public void get_ID(){} // RVA: 0x760030
        public void GetDatePart(){} // RVA: 0x5DCD660
        public void GetAbsoluteDate(){} // RVA: 0x5DCD830
        public void DateToTicks(){} // RVA: 0x5DCDA30
        public void AddMonths(){} // RVA: 0x5DCDAB0
        public void AddYears(){} // RVA: 0x5DCDFD0
        public void GetDayOfMonth(){} // RVA: 0x5DCDFF0
        public void GetDayOfWeek(){} // RVA: 0x5DCE0A0
        public void GetDayOfYear(){} // RVA: 0x5DCE160
        public void GetDaysInMonth(){} // RVA: 0x5DCE210
        public void GetDaysInYear(){} // RVA: 0x5DCE530
        public void GetEra(){} // RVA: 0x3CFAF0
        public void get_Eras(){} // RVA: 0x5DCE710
        public void GetMonth(){} // RVA: 0x5DCE770
        public void GetMonthsInYear(){} // RVA: 0x5DCE820
        public void GetYear(){} // RVA: 0x5DCE9B0
        public void IsLeapDay(){} // RVA: 0x5DCEA60
        public void GetLeapMonth(){} // RVA: 0x5DCEEB0
        public void IsLeapMonth(){} // RVA: 0x5DCF030
        public void IsLeapYear(){} // RVA: 0x5DCF2D0
        public void ToDateTime(){} // RVA: 0x5DCF4A0
        public void TryToDateTime(){} // RVA: 0x5DCF580
        public void get_TwoDigitYearMax(){} // RVA: 0x5DCF680
        public void set_TwoDigitYearMax(){} // RVA: 0x5DCF700
        public void ToFourDigitYear(){} // RVA: 0x5DCF820
        public void .cctor(){} // RVA: 0x5DCF9A0
    }

    public class GregorianCalendarHelper
    {
        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x5DCFE70
        public void GetYearOffset(){} // RVA: 0x5DCFFA0
        public void GetGregorianYear(){} // RVA: 0x5DD0330
        public void IsValidYear(){} // RVA: 0x5DD0360
        public void GetDatePart(){} // RVA: 0x5DD0380
        public void GetAbsoluteDate(){} // RVA: 0x5DD0570
        public void DateToTicks(){} // RVA: 0x5DD0770
        public void TimeToTicks(){} // RVA: 0x5DD07F0
        public void CheckTicksRange(){} // RVA: 0x5DD09D0
        public void AddMonths(){} // RVA: 0x5DD0C40
        public void AddYears(){} // RVA: 0x5DD11C0
        public void GetDayOfMonth(){} // RVA: 0x5DD11D0
        public void GetDayOfWeek(){} // RVA: 0x5DD1280
        public void GetDayOfYear(){} // RVA: 0x5DD13A0
        public void GetDaysInMonth(){} // RVA: 0x5DD1450
        public void GetDaysInYear(){} // RVA: 0x5DD1600
        public void GetEra(){} // RVA: 0x5DD1690
        public void get_Eras(){} // RVA: 0x5DD17D0
        public void GetMonth(){} // RVA: 0x5DD1940
        public void GetMonthsInYear(){} // RVA: 0x5DD19F0
        public void GetYear(){} // RVA: 0x5DD1A10
        public void IsLeapDay(){} // RVA: 0x5DD1B70
        public void GetLeapMonth(){} // RVA: 0x5DD1D00
        public void IsLeapMonth(){} // RVA: 0x5DD1D20
        public void IsLeapYear(){} // RVA: 0x5DD1E50
        public void ToDateTime(){} // RVA: 0x5DD1ED0
        public void GetWeekOfYear(){} // RVA: 0x5DD2020
        public void ToFourDigitYear(){} // RVA: 0x5DD2140
        public void .cctor(){} // RVA: 0x5DD2340
    }

    public class HebrewNumber
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x5DBC840
        public void ParseByChar(){} // RVA: 0x5DBCC60
        public void IsDigit(){} // RVA: 0x5DBCE20
        public void .cctor(){} // RVA: 0x5DBCF00
    }

    public class HebrewNumberParsingContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DBC830
    }

    public class HijriCalendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x5DD24E0
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DD2540
        public void get_AlgorithmType(){} // RVA: 0x3E2CB0
        public void .ctor(){} // RVA: 0x5DD25A0
        public void get_ID(){} // RVA: 0xA850E0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x5DD25C0
        public void GetAbsoluteDateHijri(){} // RVA: 0x5DD25D0
        public void DaysUpToHijriYear(){} // RVA: 0x5DD26F0
        public void get_HijriAdjustment(){} // RVA: 0x5DD27B0
        public void GetAdvanceHijriDate(){} // RVA: 0x519240
        public void CheckTicksRange(){} // RVA: 0x5DD2810
        public void CheckEraRange(){} // RVA: 0x5DD2A90
        public void CheckYearRange(){} // RVA: 0x5DD2B60
        public void CheckYearMonthRange(){} // RVA: 0x5DD2D60
        public void GetDatePart(){} // RVA: 0x5DD2F30
        public void AddMonths(){} // RVA: 0x5DD31D0
        public void AddYears(){} // RVA: 0x5DCDFD0
        public void GetDayOfMonth(){} // RVA: 0x5DD3620
        public void GetDayOfWeek(){} // RVA: 0x5DD36D0
        public void GetDayOfYear(){} // RVA: 0x5DD3790
        public void GetDaysInMonth(){} // RVA: 0x5DD3840
        public void GetDaysInYear(){} // RVA: 0x5DD3910
        public void GetEra(){} // RVA: 0x5DD39B0
        public void get_Eras(){} // RVA: 0x5DD3A80
        public void GetMonth(){} // RVA: 0x5DD3B20
        public void GetMonthsInYear(){} // RVA: 0x5DD3BD0
        public void GetYear(){} // RVA: 0x5DD3C40
        public void IsLeapDay(){} // RVA: 0x5DD3CF0
        public void GetLeapMonth(){} // RVA: 0x5DD3E70
        public void IsLeapMonth(){} // RVA: 0x5DD3ED0
        public void IsLeapYear(){} // RVA: 0x5DD3F40
        public void ToDateTime(){} // RVA: 0x5DD3FC0
        public void get_TwoDigitYearMax(){} // RVA: 0x5DD41E0
        public void set_TwoDigitYearMax(){} // RVA: 0x5DD4260
        public void ToFourDigitYear(){} // RVA: 0x5DD4380
        public void .cctor(){} // RVA: 0x5DD4520
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x1DD80
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x112F0
        public void IsSuffix(){} // RVA: 0x112F0
        public void IndexOf(){}
        public void LastIndexOf(){}
    }

    public class IdnMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF2E70
        public void Equals(){} // RVA: 0x5DF2F40
        public void GetHashCode(){} // RVA: 0x5DF2FC0
        public void GetAscii(){} // RVA: 0x5DF30B0 | overloaded x2
        public void Convert(){} // RVA: 0x5DF31D0
        public void ToAscii(){} // RVA: 0x5DF3560
        public void VerifyLength(){} // RVA: 0x5DF39E0
        public void NamePrep(){} // RVA: 0x5DF3B20
        public void VerifyProhibitedCharacters(){} // RVA: 0x5DF3C70
        public void VerifyStd3AsciiRules(){} // RVA: 0x5DF3ED0
        public void GetUnicode(){} // RVA: 0x5DF4210 | overloaded x2
        public void ToUnicode(){} // RVA: 0x5DF4330
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
        public void get_MinSupportedDateTime(){} // RVA: 0x5DD46D0
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DD4730
        public void get_AlgorithmType(){} // RVA: 0x3CFAF0
        public void GetEraInfo(){} // RVA: 0x5DD4790
        public void GetErasFromRegistry(){} // RVA: 0x519240
        public void GetDefaultInstance(){} // RVA: 0x5DD4E40
        public void .ctor(){} // RVA: 0x5DD4F80
        public void get_ID(){} // RVA: 0xA308B0
        public void AddMonths(){} // RVA: 0x5DD5140
        public void AddYears(){} // RVA: 0x5DD5160
        public void GetDaysInMonth(){} // RVA: 0x5DD5190
        public void GetDaysInYear(){} // RVA: 0x5DD51C0
        public void GetDayOfMonth(){} // RVA: 0x5DD51E0
        public void GetDayOfWeek(){} // RVA: 0x5DD5200
        public void GetDayOfYear(){} // RVA: 0x5DD5220
        public void GetMonthsInYear(){} // RVA: 0x5DD5240
        public void GetWeekOfYear(){} // RVA: 0x5DD5270
        public void GetEra(){} // RVA: 0x5DD52A0
        public void GetMonth(){} // RVA: 0x5DD52C0
        public void GetYear(){} // RVA: 0x5DD52E0
        public void IsLeapDay(){} // RVA: 0x5DD5300
        public void IsLeapYear(){} // RVA: 0x5DD5330
        public void GetLeapMonth(){} // RVA: 0x5DD5350
        public void IsLeapMonth(){} // RVA: 0x5DD5380
        public void ToDateTime(){} // RVA: 0x5DD53B0
        public void ToFourDigitYear(){} // RVA: 0x5DD53E0
        public void get_Eras(){} // RVA: 0x5DD5590
        public void EraNames(){} // RVA: 0x5DD55B0
        public void EnglishEraNames(){} // RVA: 0x5DD56C0
        public void IsValidYear(){} // RVA: 0x5DD57D0
        public void get_TwoDigitYearMax(){} // RVA: 0x5DD5800
        public void set_TwoDigitYearMax(){} // RVA: 0x5DD5880
        public void .cctor(){} // RVA: 0x5DD59D0
    }

    public class NumberFormatInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DD5BE0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x5DD5A70
        public void OnDeserializing(){} // RVA: 0x2DD310
        public void OnDeserialized(){} // RVA: 0x2DD310
        public void VerifyWritable(){} // RVA: 0x5DD6680
        public void get_InvariantInfo(){} // RVA: 0x5DD6700
        public void GetInstance(){} // RVA: 0x5DD6870
        public void Clone(){} // RVA: 0x5DD6A00
        public void get_CurrencyDecimalDigits(){} // RVA: 0x20D67F0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x37E0E0
        public void get_IsReadOnly(){} // RVA: 0x8A9980
        public void get_CurrencyGroupSizes(){} // RVA: 0x5DD6A70
        public void get_NumberGroupSizes(){} // RVA: 0x5DD6AF0
        public void get_PercentGroupSizes(){} // RVA: 0x5DD6B70
        public void get_CurrencyGroupSeparator(){} // RVA: 0x358730
        public void get_CurrencySymbol(){} // RVA: 0x3A5500
        public void get_CurrentInfo(){} // RVA: 0x5DD6BF0
        public void get_NaNSymbol(){} // RVA: 0x358D50
        public void set_NaNSymbol(){} // RVA: 0x5DD6D20
        public void get_CurrencyNegativePattern(){} // RVA: 0x1896340
        public void get_NumberNegativePattern(){} // RVA: 0xB68000
        public void get_PercentPositivePattern(){} // RVA: 0x59E510
        public void get_PercentNegativePattern(){} // RVA: 0x1CA9B60
        public void get_NegativeInfinitySymbol(){} // RVA: 0x4C7C50
        public void get_NegativeSign(){} // RVA: 0x6374D0
        public void get_NumberDecimalDigits(){} // RVA: 0x3C49C20
        public void get_NumberDecimalSeparator(){} // RVA: 0x4976A0
        public void get_NumberGroupSeparator(){} // RVA: 0x35A740
        public void get_CurrencyPositivePattern(){} // RVA: 0x3DF1350
        public void get_PositiveInfinitySymbol(){} // RVA: 0x3A5590
        public void get_PositiveSign(){} // RVA: 0x30B130
        public void get_PercentDecimalDigits(){} // RVA: 0xA002A0
        public void get_PercentDecimalSeparator(){} // RVA: 0x462D00
        public void get_PercentGroupSeparator(){} // RVA: 0x31C010
        public void get_PercentSymbol(){} // RVA: 0x796DE0
        public void get_PerMilleSymbol(){} // RVA: 0xA1C8C0
        public void GetFormat(){} // RVA: 0x5DD6E50
        public void ReadOnly(){} // RVA: 0x5DD6F30
        public void ValidateParseStyleInteger(){} // RVA: 0x5DD7000
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x5DD70F0
    }

    public class Punycode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF4F80
    }

    public class RegionInfo
    {
        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x5DF4FC0
        public void .ctor(){} // RVA: 0x5DF5460 | overloaded x3
        public void GetByTerritory(){} // RVA: 0x5DF58F0
        public void construct_internal_region_from_name(){} // RVA: 0x5DF59A0
        public void get_CurrencyEnglishName(){} // RVA: 0x37E0E0
        public void get_CurrencySymbol(){} // RVA: 0x35A740
        public void get_DisplayName(){} // RVA: 0x6374D0
        public void get_EnglishName(){} // RVA: 0x6374D0
        public void get_GeoId(){} // RVA: 0x32A5C0
        public void get_IsMetric(){} // RVA: 0x5DF5B30
        public void get_ISOCurrencySymbol(){} // RVA: 0x358730
        public void get_NativeName(){} // RVA: 0x4976A0
        public void get_CurrencyNativeName(){} // RVA: 0x3A5500
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_ThreeLetterISORegionName(){} // RVA: 0x30B0C0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0x30B130
        public void get_TwoLetterISORegionName(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5DF5C00
        public void GetHashCode(){} // RVA: 0x5DF5D10
        public void ToString(){} // RVA: 0x5DF5D50
        public void ClearCachedData(){} // RVA: 0x5DF5D70
    }

    public class SortKey
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x5DDC9C0
        public void .ctor(){} // RVA: 0x5DDD0B0 | overloaded x4
        public void get_OriginalString(){} // RVA: 0x2F8380
        public void get_KeyData(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5DDCE50
        public void GetHashCode(){} // RVA: 0x5DDCF00
        public void ToString(){} // RVA: 0x5DDCF70
    }

    public class SortVersion
    {
    }

    public class TaiwanCalendar
    {
        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x5DD71D0
        public void get_MinSupportedDateTime(){} // RVA: 0x5DD7310
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DD7370
        public void get_AlgorithmType(){} // RVA: 0x3CFAF0
        public void .ctor(){} // RVA: 0x5DD73D0
        public void get_ID(){} // RVA: 0xA7E130
        public void AddMonths(){} // RVA: 0x5DD5140
        public void AddYears(){} // RVA: 0x5DD5160
        public void GetDaysInMonth(){} // RVA: 0x5DD5190
        public void GetDaysInYear(){} // RVA: 0x5DD51C0
        public void GetDayOfMonth(){} // RVA: 0x5DD51E0
        public void GetDayOfWeek(){} // RVA: 0x5DD5200
        public void GetDayOfYear(){} // RVA: 0x5DD5220
        public void GetMonthsInYear(){} // RVA: 0x5DD5240
        public void GetWeekOfYear(){} // RVA: 0x5DD5270
        public void GetEra(){} // RVA: 0x5DD52A0
        public void GetMonth(){} // RVA: 0x5DD52C0
        public void GetYear(){} // RVA: 0x5DD52E0
        public void IsLeapDay(){} // RVA: 0x5DD5300
        public void IsLeapYear(){} // RVA: 0x5DD5330
        public void GetLeapMonth(){} // RVA: 0x5DD5350
        public void IsLeapMonth(){} // RVA: 0x5DD5380
        public void ToDateTime(){} // RVA: 0x5DD53B0
        public void get_Eras(){} // RVA: 0x5DD5590
        public void get_TwoDigitYearMax(){} // RVA: 0x5DD5800
        public void set_TwoDigitYearMax(){} // RVA: 0x5DD75A0
        public void ToFourDigitYear(){} // RVA: 0x5DD76F0
        public void .cctor(){} // RVA: 0x5DD78A0
    }

    public class TextInfo
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x5DD7A60
        public void .ctor(){} // RVA: 0x5DD9E50 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x5DD7C90
        public void OnDeserialized(){} // RVA: 0x5DD7F00 | overloaded x2
        public void OnSerializing(){} // RVA: 0x5DD7F10
        public void get_CultureName(){} // RVA: 0x6374D0
        public void get_IsReadOnly(){} // RVA: 0x2F84E0
        public void Clone(){} // RVA: 0x5DD7FF0
        public void ReadOnly(){} // RVA: 0x5DD8070
        public void SetReadOnlyState(){} // RVA: 0x2F84F0
        public void get_ListSeparator(){} // RVA: 0x5DD8160
        public void ToLower(){} // RVA: 0x5DD8240 | overloaded x2
        public void ToLowerAsciiInvariant(){} // RVA: 0x5DD8370
        public void ToUpper(){} // RVA: 0x5DD83F0 | overloaded x2
        public void ToUpperAsciiInvariant(){} // RVA: 0x5DD9C70 | overloaded x2
        public void IsAscii(){} // RVA: 0x5DD8540
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x5DD8550
        public void Equals(){} // RVA: 0x5DD86A0
        public void GetHashCode(){} // RVA: 0x5DD8780
        public void ToString(){} // RVA: 0x5DD87B0
        public void ToTitleCase(){} // RVA: 0x5DD8810
        public void AddNonLetter(){} // RVA: 0x5DD8CE0
        public void AddTitlecaseLetter(){} // RVA: 0x5DD8DA0
        public void IsWordSeparator(){} // RVA: 0x5DD8FC0
        public void IsLetterCategory(){} // RVA: 0x5DD8FD0
        public void get_IsRightToLeft(){} // RVA: 0x5DD8FE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5DD7F00
        public void ToUpperInternal(){} // RVA: 0x5DD91C0 | overloaded x2
        public void ToLowerInternal(){} // RVA: 0x5DD9790 | overloaded x2
        public void ChangeCase(){} // RVA: 0x5DD9D20
    }

    public class TextInfoToLowerData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5DEA280
    }

    public class TextInfoToUpperData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5DE9D20
    }

    public class ThaiBuddhistCalendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x5DD9E80
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DD9EE0
        public void get_AlgorithmType(){} // RVA: 0x3CFAF0
        public void .ctor(){} // RVA: 0x5DD9F40
        public void get_ID(){} // RVA: 0xA67BB0
        public void AddMonths(){} // RVA: 0x5DD5140
        public void AddYears(){} // RVA: 0x5DD5160
        public void GetDaysInMonth(){} // RVA: 0x5DD5190
        public void GetDaysInYear(){} // RVA: 0x5DD51C0
        public void GetDayOfMonth(){} // RVA: 0x5DD51E0
        public void GetDayOfWeek(){} // RVA: 0x5DD5200
        public void GetDayOfYear(){} // RVA: 0x5DD5220
        public void GetMonthsInYear(){} // RVA: 0x5DD5240
        public void GetWeekOfYear(){} // RVA: 0x5DD5270
        public void GetEra(){} // RVA: 0x5DD52A0
        public void GetMonth(){} // RVA: 0x5DD52C0
        public void GetYear(){} // RVA: 0x5DD52E0
        public void IsLeapDay(){} // RVA: 0x5DD5300
        public void IsLeapYear(){} // RVA: 0x5DD5330
        public void GetLeapMonth(){} // RVA: 0x5DD5350
        public void IsLeapMonth(){} // RVA: 0x5DD5380
        public void ToDateTime(){} // RVA: 0x5DD53B0
        public void get_Eras(){} // RVA: 0x5DD5590
        public void get_TwoDigitYearMax(){} // RVA: 0x5DDA040
        public void set_TwoDigitYearMax(){} // RVA: 0x5DDA0C0
        public void ToFourDigitYear(){} // RVA: 0x5DDA210
        public void .cctor(){} // RVA: 0x5DDA2D0
    }

    public class TimeSpanFormat
    {
        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x5DBD370
        public void Format(){} // RVA: 0x5DBD4F0
        public void TryFormat(){} // RVA: 0x5DBD5F0
        public void FormatToBuilder(){} // RVA: 0x5DBD6F0
        public void FormatStandard(){} // RVA: 0x5DBDA10
        public void FormatCustomized(){} // RVA: 0x5DBE000
        public void .cctor(){} // RVA: 0x5DBE840
    }

    public class TimeSpanParse
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x5DBF2B0
        public void TryTimeToTicks(){} // RVA: 0x5DBF3B0
        public void Parse(){} // RVA: 0x5DBF560
        public void TryParse(){} // RVA: 0x5DBF5A0
        public void ParseExact(){} // RVA: 0x5DBF600
        public void TryParseExact(){} // RVA: 0x5DBF650
        public void ParseExactMultiple(){} // RVA: 0x5DBF6C0
        public void TryParseExactMultiple(){} // RVA: 0x5DBF700
        public void TryParseTimeSpan(){} // RVA: 0x5DBF760
        public void ProcessTerminalState(){} // RVA: 0x5DC0900
        public void ProcessTerminal_DHMSF(){} // RVA: 0x5DC0A70
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x5DC0EC0
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x5DC29B0
        public void ProcessTerminal_HM(){} // RVA: 0x5DC3FD0
        public void ProcessTerminal_D(){} // RVA: 0x5DC4300
        public void TryParseExactTimeSpan(){} // RVA: 0x5DC4610
        public void TryParseByFormat(){} // RVA: 0x5DC47B0
        public void ParseExactDigits(){} // RVA: 0x5DC53E0 | overloaded x2
        public void ParseExactLiteral(){} // RVA: 0x5DC54C0
        public void TryParseTimeSpanConstant(){} // RVA: 0x5DC5580
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x5DC55C0
    }

    public class UmAlQuraCalendar
    {
        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x5DDA440
        public void get_MinSupportedDateTime(){} // RVA: 0x5DDA620
        public void get_MaxSupportedDateTime(){} // RVA: 0x5DDA680
        public void get_AlgorithmType(){} // RVA: 0x3E2CB0
        public void .ctor(){} // RVA: 0x5DC8940
        public void get_BaseCalendarID(){} // RVA: 0xA850E0
        public void get_ID(){} // RVA: 0x9FD990
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x5DDA6E0
        public void ConvertHijriToGregorian(){} // RVA: 0x5DDA6F0
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x5DDA960
        public void CheckTicksRange(){} // RVA: 0x5DDAA30
        public void CheckEraRange(){} // RVA: 0x5DDACB0
        public void CheckYearRange(){} // RVA: 0x5DDAD40
        public void CheckYearMonthRange(){} // RVA: 0x5DDAF00
        public void ConvertGregorianToHijri(){} // RVA: 0x5DDAFE0
        public void GetDatePart(){} // RVA: 0x5DDB400
        public void AddMonths(){} // RVA: 0x5DDB5E0
        public void AddYears(){} // RVA: 0x5DCDFD0
        public void GetDayOfMonth(){} // RVA: 0x5DDB9D0
        public void GetDayOfWeek(){} // RVA: 0x5DDB9F0
        public void GetDayOfYear(){} // RVA: 0x5DDBAB0
        public void GetDaysInMonth(){} // RVA: 0x5DDBAD0
        public void RealGetDaysInYear(){} // RVA: 0x5DDBB90
        public void GetDaysInYear(){} // RVA: 0x5DDBC40
        public void GetEra(){} // RVA: 0x5DDBCB0
        public void get_Eras(){} // RVA: 0x5DDBD70
        public void GetMonth(){} // RVA: 0x5DDBDD0
        public void GetMonthsInYear(){} // RVA: 0x5DDBDF0
        public void GetYear(){} // RVA: 0x5DDBE60
        public void IsLeapDay(){} // RVA: 0x5DDBE80
        public void GetLeapMonth(){} // RVA: 0x5DDC020
        public void IsLeapMonth(){} // RVA: 0x5DDC080
        public void IsLeapYear(){} // RVA: 0x5DDC0F0
        public void ToDateTime(){} // RVA: 0x5DDC160
        public void get_TwoDigitYearMax(){} // RVA: 0x5DD41E0
        public void set_TwoDigitYearMax(){} // RVA: 0x5DDC430
        public void ToFourDigitYear(){} // RVA: 0x5DDC560
        public void .cctor(){} // RVA: 0x5DDC700
    }

}