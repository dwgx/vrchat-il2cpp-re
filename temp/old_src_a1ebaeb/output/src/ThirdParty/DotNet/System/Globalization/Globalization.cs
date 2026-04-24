// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 14
// Methods: 483

namespace ThirdParty.DotNet.System.Globalization
{
    public class Calendar : Object
    {
        public object TicksPerMinute; // 0x34FCAC20
        public object MillisPerSecond; // 0x34FCAC20
        public object MillisPerDay; // 0x34FCAC20
        public object DaysPer100Years; // 0x34FCAC20
        public object MaxMillis; // 0x34FCAC20
        public object CAL_JAPAN; // 0x34FCAC20
        public object CAL_HIJRI; // 0x34FCAC20
        public object CAL_GREGORIAN_ME_FRENCH; // 0x34FCAC20
        public object CAL_GREGORIAN_XLIT_FRENCH; // 0x34FCAC20
        public object CAL_CHINESELUNISOLAR; // 0x34FCAC20
        public object CAL_LUNAR_ETO_KOR; // 0x34FCAC20
        public object CAL_TAIWANLUNISOLAR; // 0x34FCAC20
        public object m_currentEraValue; // 0x34FCAC20
        public object twoDigitYearMax; // 0x34FCAC20
        public object MinSupportedDateTime; // 0x170006FE
        public object MaxSupportedDateTime; // 0x170006FF
        public object ID; // 0x17000700
        public object BaseCalendarID; // 0x17000701
        public object AlgorithmType; // 0x17000702
        public object IsReadOnly; // 0x17000703
        public object CurrentEraValue; // 0x17000704
        public object Eras; // 0x17000705
        public object DaysInYearBeforeMinSupportedYear; // 0x17000706
        public object TwoDigitYearMax; // 0x17000707

        // ── Original Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7ffaadf81120
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ffaadf81180
        public void .ctor(){} // RVA: 0x7ffaadf811e0
        public void get_ID(){} // RVA: 0x7ffaa8ce12f0
        public void get_BaseCalendarID(){} // RVA: 0x7ffaaa1d31f0
        public void get_AlgorithmType(){} // RVA: 0x7ffaa8f22da0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8a81bd0
        public void Clone(){} // RVA: 0x7ffaadf811f0
        public void ReadOnly(){} // RVA: 0x7ffaadf81270
        public void VerifyWritable(){} // RVA: 0x7ffaadf81360
        public void get_CurrentEraValue(){} // RVA: 0x7ffaadf813e0
        public void AddMonths(){}
        public void AddYears(){}
        public void get_Eras(){} // RVA: 0x7ffaa86491d0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7ffaadf81af0
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void IsLeapYear(){} // RVA: 0x7ffaadf81ef0
        public void IsLeapYear(){} // RVA: 0x7ffaadf81ef0
        public void ToDateTime(){} // RVA: 0x7ffaadf81f10
        public void ToDateTime(){} // RVA: 0x7ffaadf81f10
        public void TryToDateTime(){} // RVA: 0x7ffaadf81f70
        public void IsValidYear(){} // RVA: 0x7ffaadf82070
        public void IsValidMonth(){} // RVA: 0x7ffaadf82100
        public void IsValidDay(){} // RVA: 0x7ffaadf82180
        public void get_TwoDigitYearMax(){} // RVA: 0x7ffaa8b945a0
        public void set_TwoDigitYearMax(){} // RVA: 0x7ffaadf82210
        public void ToFourDigitYear(){} // RVA: 0x7ffaadf82240
        public void TimeToTicks(){} // RVA: 0x7ffaadf82350
        // ── Binary Analysis Named ──
        public void SetReadOnlyState(){} // RVA: 0x7ffaa8a81be0
        public void CheckAddResult(){} // RVA: 0x7ffaadf81470
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x7ffaadf81650
        public void GetDaysInMonth(){} // RVA: 0x7ffaadf81650
        public void GetDaysInYear(){} // RVA: 0x7ffaa86505d0
        public void GetEra(){}
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x7ffaa86505d0
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7ffaadf81680
        public void GetWeekOfYearFullDays(){} // RVA: 0x7ffaadf81740
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7ffaadf81980
        public void GetWeekOfYear(){} // RVA: 0x7ffaadf81b00
        public void GetYear(){}
        public void GetLeapMonth(){} // RVA: 0x7ffaadf81e30
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7ffaadf82530
    }

    public class CalendarData : Object
    {
        public object saShortDates; // 0x33BBD2E0
        public object sMonthDay; // 0x33BBD2E0
        public object saAbbrevEnglishEraNames; // 0x33BBD2E0
        public object saSuperShortDayNames; // 0x33BBD2E0
        public object saMonthGenitiveNames; // 0x33BBD2E0
        public object iTwoDigitYearMax; // 0x33BBD2E0
        public object Invariant; // 0x33BBD2E0
        public object .cctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadf838d0
        public void .cctor(){} // RVA: 0x7ffaadf82590
        public void .ctor(){} // RVA: 0x7ffaadf838d0
        public void InitializeEraNames(){} // RVA: 0x7ffaadf84770
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7ffaadf850c0
        public void CalendarIdToCultureName(){} // RVA: 0x7ffaadf85730
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7ffaa8ce12f0
        public void nativeGetCalendarData(){} // RVA: 0x7ffaadf85900
        public void fill_calendar_data(){} // RVA: 0x7ffaadf85aa0
        // ── Binary Analysis Named ──
        public void GetJapaneseEraNames(){} // RVA: 0x7ffaadf84c80
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7ffaadf84ea0
        public void GetCalendarData(){} // RVA: 0x7ffaadf85500
    }

    public class CompareInfo : Object
    {
        public object ValidHashCodeOfStringMaskOffFlags; // 0x34DEABC0
        public object m_name; // 0x34DEABC0
        public object culture; // 0x34DEABC0
        public object managedCollation; // 0x34DEABC0

        // ── Original Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7ffaadf64ae0
        public void InvariantLastIndexOf(){} // RVA: 0x7ffaadf64bb0
        public void InvariantFindString(){} // RVA: 0x7ffaadf64c90
        public void InvariantToUpper(){} // RVA: 0x7ffaadf65090
        public void InvariantCreateSortKey(){} // RVA: 0x7ffaadf650b0
        public void .ctor(){} // RVA: 0x7ffaadf6aa40
        public void OnDeserializing(){} // RVA: 0x7ffaad812560
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ffaadf65530
        public void OnDeserialized(){} // RVA: 0x7ffaadf65540
        public void OnDeserialized(){} // RVA: 0x7ffaadf65540
        public void OnSerializing(){} // RVA: 0x7ffaadf65690
        public void get_Name(){} // RVA: 0x7ffaadf65730
        public void Compare(){} // RVA: 0x7ffaadf66280
        public void Compare(){} // RVA: 0x7ffaadf66280
        public void Compare(){} // RVA: 0x7ffaadf66280
        public void CompareOptionNone(){} // RVA: 0x7ffaadf65ff0
        public void CompareOptionIgnoreCase(){} // RVA: 0x7ffaadf66150
        public void Compare(){} // RVA: 0x7ffaadf66280
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7ffaadf669c0
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7ffaadf669c0
        public void IsPrefix(){} // RVA: 0x7ffaadf66e80
        public void IsPrefix(){} // RVA: 0x7ffaadf66e80
        public void IsSuffix(){} // RVA: 0x7ffaadf67200
        public void IsSuffix(){} // RVA: 0x7ffaadf67200
        public void IndexOf(){} // RVA: 0x7ffaadf67c10
        public void IndexOf(){} // RVA: 0x7ffaadf67c10
        public void IndexOf(){} // RVA: 0x7ffaadf67c10
        public void IndexOf(){} // RVA: 0x7ffaadf67c10
        public void IndexOf(){} // RVA: 0x7ffaadf67c10
        public void IndexOfOrdinal(){} // RVA: 0x7ffaadf67d70
        public void LastIndexOf(){} // RVA: 0x7ffaadf67fc0
        public void LastIndexOf(){} // RVA: 0x7ffaadf67fc0
        public void LastIndexOfOrdinal(){} // RVA: 0x7ffaadf683a0
        public void Equals(){} // RVA: 0x7ffaadf686f0
        public void ToString(){} // RVA: 0x7ffaadf68ed0
        public void get_UseManagedCollation(){} // RVA: 0x7ffaadf68f30
        public void CreateSortKeyCore(){} // RVA: 0x7ffaadf69520
        public void internal_index_switch(){} // RVA: 0x7ffaadf697c0
        public void internal_compare_switch(){} // RVA: 0x7ffaadf69a40
        public void internal_compare_managed(){} // RVA: 0x7ffaadf69c40
        public void internal_index_managed(){} // RVA: 0x7ffaadf69d40
        public void internal_compare_icall(){} // RVA: 0x7ffaadf69df0
        public void internal_compare(){} // RVA: 0x7ffaadf69e00
        public void internal_index_icall(){} // RVA: 0x7ffaadf69eb0
        public void internal_index(){} // RVA: 0x7ffaadf69fa0
        public void InitSort(){} // RVA: 0x7ffaadf6a0e0
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7ffaadf6a150
        public void IndexOfOrdinalCore(){} // RVA: 0x7ffaadf6a310
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7ffaadf6a350
        public void LastIndexOfCore(){} // RVA: 0x7ffaadf6a390
        public void IndexOfCore(){} // RVA: 0x7ffaadf6a3d0
        public void CompareString(){} // RVA: 0x7ffaadf6a4d0
        public void CompareString(){} // RVA: 0x7ffaadf6a4d0
        public void CreateSortKey(){} // RVA: 0x7ffaadf6a5e0
        public void StartsWith(){} // RVA: 0x7ffaadf66e80
        public void StartsWith(){} // RVA: 0x7ffaadf66e80
        public void EndsWith(){} // RVA: 0x7ffaadf67200
        public void EndsWith(){} // RVA: 0x7ffaadf67200
        public void .cctor(){} // RVA: 0x7ffaadf6a920
        public void .ctor(){} // RVA: 0x7ffaadf6aa40
        // ── Binary Analysis Named ──
        public void GetCompareInfo(){} // RVA: 0x7ffaadf65470
        public void GetSortKey(){} // RVA: 0x7ffaadf68570
        public void GetHashCode(){} // RVA: 0x7ffaadf68dc0
        public void GetIgnoreCaseHash(){} // RVA: 0x7ffaadf68840
        public void GetHashCodeOfString(){} // RVA: 0x7ffaadf68bf0
        public void GetHashCode(){} // RVA: 0x7ffaadf68dc0
        public void GetCollator(){} // RVA: 0x7ffaadf690a0
        public void GetHashCodeOfStringCore(){} // RVA: 0x7ffaadf6a8e0
    }

    public class CultureData : Object
    {
        public object sTimeSeparator; // 0x33BBD460
        public object iFirstDayOfWeek; // 0x33BBD460
        public object calendars; // 0x33BBD460
        public object bUseOverrides; // 0x33BBD460
        public object iDefaultAnsiCodePage; // 0x33BBD460
        public object iDefaultEbcdicCodePage; // 0x33BBD460
        public object s_Invariant; // 0x33BBD460
        public object Invariant; // 0x17000756
        public object LongTimes; // 0x17000757
        public object ShortTimes; // 0x17000758
        public object SISO639LANGNAME; // 0x17000759
        public object IFIRSTDAYOFWEEK; // 0x1700075A
        public object IFIRSTWEEKOFYEAR; // 0x1700075B
        public object SAM1159; // 0x1700075C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89fa510
        public void get_Invariant(){} // RVA: 0x7ffaadf95980
        public void fill_culture_data(){} // RVA: 0x7ffaadf96320
        public void get_LongTimes(){} // RVA: 0x7ffaac3a5460
        public void get_ShortTimes(){} // RVA: 0x7ffaadf964a0
        public void get_SISO639LANGNAME(){} // RVA: 0x7ffaa89d30e0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7ffaa8fb82b0
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7ffaa8de7460
        public void get_SAM1159(){} // RVA: 0x7ffaa894d380
        public void get_SPM2359(){} // RVA: 0x7ffaa89357c0
        public void get_TimeSeparator(){} // RVA: 0x7ffaa89600c0
        public void get_CalendarIds(){} // RVA: 0x7ffaadf964b0
        public void get_IsInvariantCulture(){} // RVA: 0x7ffaadf96830
        public void get_CultureName(){} // RVA: 0x7ffaa89fa500
        public void get_SCOMPAREINFO(){} // RVA: 0x7ffaadf96850
        public void get_STEXTINFO(){} // RVA: 0x7ffaa89fa500
        public void get_IsRightToLeft(){} // RVA: 0x7ffaa8dfe510
        public void get_SLIST(){} // RVA: 0x7ffaa8d1a3b0
        public void get_UseUserOverride(){} // RVA: 0x7ffaa895b020
        public void EraNames(){} // RVA: 0x7ffaadf96890
        public void AbbrevEraNames(){} // RVA: 0x7ffaadf968b0
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7ffaadf968d0
        public void ShortDates(){} // RVA: 0x7ffaadf968f0
        public void LongDates(){} // RVA: 0x7ffaadf96910
        public void YearMonths(){} // RVA: 0x7ffaadf96930
        public void DayNames(){} // RVA: 0x7ffaadf96950
        public void AbbreviatedDayNames(){} // RVA: 0x7ffaadf96970
        public void MonthNames(){} // RVA: 0x7ffaadf96990
        public void GenitiveMonthNames(){} // RVA: 0x7ffaadf969b0
        public void AbbreviatedMonthNames(){} // RVA: 0x7ffaadf969d0
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7ffaadf969f0
        public void LeapYearMonthNames(){} // RVA: 0x7ffaadf96a20
        public void MonthDay(){} // RVA: 0x7ffaadf96a50
        public void DateSeparator(){} // RVA: 0x7ffaadf96a70
        public void IndexOfTimePart(){} // RVA: 0x7ffaadf96d80
        public void UnescapeNlsString(){} // RVA: 0x7ffaadf96ea0
        public void ReescapeWin32Strings(){} // RVA: 0x7ffaa9f19100
        public void ReescapeWin32String(){} // RVA: 0x7ffaa9f19100
        public void strlen(){} // RVA: 0x7ffaadf97060
        public void idx2string(){} // RVA: 0x7ffaadf97080
        public void create_group_sizes_array(){} // RVA: 0x7ffaadf971b0
        public void fill_number_data(){} // RVA: 0x7ffaadf97b70
        // ── Binary Analysis Named ──
        public void GetCultureData(){} // RVA: 0x7ffaadf96130
        public void GetCultureData(){} // RVA: 0x7ffaadf96130
        public void GetCalendar(){} // RVA: 0x7ffaadf96330
        public void GetCalendarIds(){} // RVA: 0x7ffaadf96750
        public void GetDateSeparator(){} // RVA: 0x7ffaadf96b50
        public void GetSeparator(){} // RVA: 0x7ffaadf96ba0
        public void GetNFIValues(){} // RVA: 0x7ffaadf97260
    }

    public class CultureInfo : Object
    {
        public object default_current_culture; // 0x3031C880
        public object parent_lcid; // 0x3031C880
        public object default_calendar_type; // 0x3031C880
        public object dateTimeInfo; // 0x3031C880
        public object englishname; // 0x3031C880
        public object iso2lang; // 0x3031C880
        public object native_calendar_names; // 0x3031C880
        public object m_dataItem; // 0x3031C880
        public object constructed; // 0x3031C880
        public object m_isInherited; // 0x3031C880
        public object LOCALE_INVARIANT; // 0x3031C880
        public object s_DefaultThreadCurrentCulture; // 0x3031C880
        public object s_UserPreferredCultureInfoInAppX; // 0x3031C880

        // ── Original Methods ──
        public void get__cultureData(){} // RVA: 0x7ffaa899d120
        public void get__isInherited(){} // RVA: 0x7ffaa9757e70
        public void get_InvariantCulture(){} // RVA: 0x7ffaadfa3120
        public void get_CurrentCulture(){} // RVA: 0x7ffaadfa3180
        public void get_CurrentUICulture(){} // RVA: 0x7ffaadfa31d0
        public void set_CurrentUICulture(){} // RVA: 0x7ffaadfa3220
        public void ConstructCurrentCulture(){} // RVA: 0x7ffaadfa3250
        public void ConstructCurrentUICulture(){} // RVA: 0x7ffaadfa34b0
        public void get_Territory(){} // RVA: 0x7ffaa8af68f0
        public void get__name(){} // RVA: 0x7ffaa89ad730
        public void get_IetfLanguageTag(){} // RVA: 0x7ffaadfa3500
        public void get_LCID(){} // RVA: 0x7ffaa8e046c0
        public void get_Name(){} // RVA: 0x7ffaa89ad730
        public void get_NativeName(){} // RVA: 0x7ffaadfa3640
        public void get_Calendar(){} // RVA: 0x7ffaadfa36b0
        public void get_Parent(){} // RVA: 0x7ffaadfa3780
        public void get_TextInfo(){} // RVA: 0x7ffaadfa3a60
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7ffaadfa3cb0
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7ffaadfa3d20
        public void Clone(){} // RVA: 0x7ffaadfa3d90
        public void Equals(){} // RVA: 0x7ffaadfa3ff0
        public void ReadOnly(){} // RVA: 0x7ffaadfa44f0
        public void ToString(){} // RVA: 0x7ffaa89ad730
        public void get_CompareInfo(){} // RVA: 0x7ffaadfa4780
        public void get_IsNeutralCulture(){} // RVA: 0x7ffaadfa4a40
        public void get_NumberFormat(){} // RVA: 0x7ffaadfa4a80
        public void set_NumberFormat(){} // RVA: 0x7ffaadfa4b70
        public void get_DateTimeFormat(){} // RVA: 0x7ffaadfa4ce0
        public void set_DateTimeFormat(){} // RVA: 0x7ffaadfa4ef0
        public void get_DisplayName(){} // RVA: 0x7ffaadfa5060
        public void get_EnglishName(){} // RVA: 0x7ffaadfa5080
        public void get_InstalledUICulture(){} // RVA: 0x7ffaadfa50f0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa89fc5e0
        public void Construct(){} // RVA: 0x7ffaadfa5290
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7ffaadfa52f0
        public void construct_internal_locale_from_name(){} // RVA: 0x7ffaadfa5350
        public void get_current_locale_name(){} // RVA: 0x7ffaadfa54e0
        public void internal_get_cultures(){} // RVA: 0x7ffaadfa5560
        public void ConstructInvariant(){} // RVA: 0x7ffaadfa5570
        public void CreateTextInfo(){} // RVA: 0x7ffaadfa5af0
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void .ctor(){} // RVA: 0x7ffaadfa6330
        public void insert_into_shared_tables(){} // RVA: 0x7ffaadfa6340
        public void CreateCulture(){} // RVA: 0x7ffaadfa6d60
        public void CreateSpecificCulture(){} // RVA: 0x7ffaadfa6df0
        public void ConstructLocaleFromName(){} // RVA: 0x7ffaadfa7150
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7ffaadfa7200
        public void get_CalendarType(){} // RVA: 0x7ffaadfaa440
        public void CreateCalendar(){} // RVA: 0x7ffaadfaa4e0
        public void CreateNotFoundException(){} // RVA: 0x7ffaadfaa700
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7ffaadfaa7b0
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7ffaadfaa810
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7ffaadfaa8d0
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7ffaadfaa930
        public void get_SortName(){} // RVA: 0x7ffaa89ad730
        public void get_UserDefaultUICulture(){} // RVA: 0x7ffaadfaa9f0
        public void get_UserDefaultCulture(){} // RVA: 0x7ffaadfaaa70
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7ffaadefb7e0
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7ffaadfaaac0
        public void get_HasInvariantCultureName(){} // RVA: 0x7ffaadfaaec0
        public void VerifyCultureName(){} // RVA: 0x7ffaadfab140
        public void VerifyCultureName(){} // RVA: 0x7ffaadfab140
        public void .cctor(){} // RVA: 0x7ffaadfab1e0
        // ── Binary Analysis Named ──
        public void GetCultures(){} // RVA: 0x7ffaadfa40d0
        public void GetTextInfoData(){} // RVA: 0x7ffaadfa44d0
        public void GetHashCode(){} // RVA: 0x7ffaa8e046c0
        public void CheckNeutral(){} // RVA: 0x7ffaa8932310
        public void GetFormat(){} // RVA: 0x7ffaadfa5140
        public void GetCultureInfo(){} // RVA: 0x7ffaadfa6c60
        public void GetCultureInfo(){} // RVA: 0x7ffaadfa6c60
        public void GetCultureInfo(){} // RVA: 0x7ffaadfa6c60
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7ffaa8932310
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7ffaadfaac50
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7ffaadfaad50
    }

    public class DateTimeFormatInfo : Object
    {
        public object _name; // 0x34FCA650
        public object _cultureInfo; // 0x34FCA650
        public object dateSeparator; // 0x34FCA650
        public object timeSeparator; // 0x34FCA650
        public object rfc1123Pattern; // 0x34FCA650
        public object calendar; // 0x34FCA650
        public object fullDateTimePattern; // 0x34FCA650
        public object dayNames; // 0x34FCA650
        public object genitiveMonthNames; // 0x34FCA650
        public object longDatePattern; // 0x34FCA650
        public object longTimePattern; // 0x34FCA650
        public object allShortDatePatterns; // 0x34FCA650
        public object allLongTimePatterns; // 0x34FCA650
        public object m_abbrevEnglishEraNames; // 0x34FCA650
        public object _isReadOnly; // 0x34FCA650
        public object RoundtripFormat; // 0x34FCA650
        public object _fullTimeSpanNegativePattern; // 0x34FCA650
        public object TOKEN_HASH_SIZE; // 0x34FCA650
        public object invariantDateSeparator; // 0x34FCA650
        public object IgnorableComma; // 0x34FCA650
        public object CJKDaySuff; // 0x34FCA650
        public object KoreanDaySuff; // 0x34FCA650
        public object KoreanSecondSuff; // 0x34FCA650
        public object CJKMinuteSuff; // 0x34FCA650
        public object LocalTimeMark; // 0x34FCA650
        public object KoreanLangName; // 0x34FCA650
        public object s_jajpDTFI; // 0x34FCA650

        // ── Original Methods ──
        public void get_CultureName(){} // RVA: 0x7ffaadf6b4e0
        public void get_Culture(){} // RVA: 0x7ffaadf6b550
        public void get_LanguageName(){} // RVA: 0x7ffaadf6b610
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7ffaadf6b680
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7ffaadf6b6a0
        public void internalGetDayOfWeekNames(){} // RVA: 0x7ffaadf6b760
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7ffaadf6b780
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7ffaadf6b840
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7ffaadf6b860
        public void internalGetMonthNames(){} // RVA: 0x7ffaadf6b920
        public void internalGetMonthNamesCore(){} // RVA: 0x7ffaadf6b940
        public void .ctor(){} // RVA: 0x7ffaadf6bbd0
        public void .ctor(){} // RVA: 0x7ffaadf6bbd0
        public void InitializeOverridableProperties(){} // RVA: 0x7ffaadf6bc40
        public void get_InvariantInfo(){} // RVA: 0x7ffaadf6c0c0
        public void get_CurrentInfo(){} // RVA: 0x7ffaadf6c210
        public void Clone(){} // RVA: 0x7ffaadf6c5d0
        public void get_AMDesignator(){} // RVA: 0x7ffaadf6c750
        public void get_Calendar(){} // RVA: 0x7ffaa8af68f0
        public void set_Calendar(){} // RVA: 0x7ffaadf6c7c0
        public void get_OptionalCalendars(){} // RVA: 0x7ffaadf6cc60
        public void get_EraNames(){} // RVA: 0x7ffaadf6cdd0
        public void get_AbbreviatedEraNames(){} // RVA: 0x7ffaadf6d040
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7ffaadf6d2d0
        public void get_DateSeparator(){} // RVA: 0x7ffaadf6d3a0
        public void get_FullDateTimePattern(){} // RVA: 0x7ffaadf6d450
        public void get_LongDatePattern(){} // RVA: 0x7ffaadf6d520
        public void get_LongTimePattern(){} // RVA: 0x7ffaadf6d5c0
        public void get_MonthDayPattern(){} // RVA: 0x7ffaadf6d660
        public void get_PMDesignator(){} // RVA: 0x7ffaadf6d720
        public void get_RFC1123Pattern(){} // RVA: 0x7ffaadf6d790
        public void get_ShortDatePattern(){} // RVA: 0x7ffaadf6d7d0
        public void get_ShortTimePattern(){} // RVA: 0x7ffaadf6d870
        public void get_SortableDateTimePattern(){} // RVA: 0x7ffaadf6d910
        public void get_GeneralShortTimePattern(){} // RVA: 0x7ffaadf6d950
        public void get_GeneralLongTimePattern(){} // RVA: 0x7ffaadf6da10
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7ffaadf6dad0
        public void get_TimeSeparator(){} // RVA: 0x7ffaadf6dcf0
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7ffaadf6dd60
        public void get_YearMonthPattern(){} // RVA: 0x7ffaadf6dda0
        public void get_AbbreviatedDayNames(){} // RVA: 0x7ffaadf6de40
        public void get_DayNames(){} // RVA: 0x7ffaadf6ded0
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7ffaadf6df60
        public void get_MonthNames(){} // RVA: 0x7ffaadf6dff0
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7ffaadf6e080
        public void get_HasSpacesInDayNames(){} // RVA: 0x7ffaadf6e0b0
        public void internalGetMonthName(){} // RVA: 0x7ffaadf6e0e0
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7ffaadf6e240
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7ffaadf6e3f0
        public void get_AllYearMonthPatterns(){} // RVA: 0x7ffaadf6f0c0
        public void get_AllShortDatePatterns(){} // RVA: 0x7ffaadf6f140
        public void get_AllShortTimePatterns(){} // RVA: 0x7ffaadf6f1c0
        public void get_AllLongDatePatterns(){} // RVA: 0x7ffaadf6f240
        public void get_AllLongTimePatterns(){} // RVA: 0x7ffaadf6f2c0
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7ffaadf6f340
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7ffaadf6f410
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7ffaadf6f4e0
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7ffaadf6f5b0
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7ffaadf6f640
        public void ReadOnly(){} // RVA: 0x7ffaadf6f6d0
        public void get_IsReadOnly(){} // RVA: 0x7ffaadf6f8f0
        public void get_MonthGenitiveNames(){} // RVA: 0x7ffaadf6f990
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7ffaadf6fa20
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7ffaadf6fb60
        public void get_CompareInfo(){} // RVA: 0x7ffaadf6fc10
        public void ValidateStyles(){} // RVA: 0x7ffaadf6fda0
        public void get_FormatFlags(){} // RVA: 0x7ffaadf6fed0
        public void InitializeFormatFlags(){} // RVA: 0x7ffaadf6fef0
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7ffaadf70140
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7ffaadf70180
        public void YearMonthAdjustment(){} // RVA: 0x7ffaadf701b0
        public void ClearTokenHashTable(){} // RVA: 0x7ffaadf706b0
        public void CreateTokenHashTable(){} // RVA: 0x7ffaadf70730
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7ffaadf71360
        public void IsJapaneseCalendar(){} // RVA: 0x7ffaadf72140
        public void AddMonthNames(){} // RVA: 0x7ffaadf72280
        public void TryParseHebrewNumber(){} // RVA: 0x7ffaadf72350
        public void IsHebrewChar(){} // RVA: 0x7ffaadf72550
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7ffaadf72570
        public void Tokenize(){} // RVA: 0x7ffaadf726c0
        public void InsertAtCurrentHashNode(){} // RVA: 0x7ffaadf72de0
        public void InsertHash(){} // RVA: 0x7ffaadf73020
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7ffaadf73420
        public void .cctor(){} // RVA: 0x7ffaadf73550
        // ── Binary Analysis Named ──
        public void GetInstance(){} // RVA: 0x7ffaadf6c360
        public void GetFormat(){} // RVA: 0x7ffaadf6c4f0
        public void GetEraName(){} // RVA: 0x7ffaadf6cea0
        public void GetAbbreviatedEraName(){} // RVA: 0x7ffaadf6d110
        public void GetAbbreviatedDayName(){} // RVA: 0x7ffaadf6e4c0
        public void GetCombinedPatterns(){} // RVA: 0x7ffaadf6e5d0
        public void GetAllDateTimePatterns(){} // RVA: 0x7ffaadf6e6e0
        public void GetDayName(){} // RVA: 0x7ffaadf6eb90
        public void GetAbbreviatedMonthName(){} // RVA: 0x7ffaadf6eca0
        public void GetMonthName(){} // RVA: 0x7ffaadf6edb0
        public void GetMergedPatterns(){} // RVA: 0x7ffaadf6eec0
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7ffaadf702f0
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7ffaadf704d0
    }

    public class GlobalizationMode : Object
    {
        // ── Original Methods ──
        public void get_Invariant(){} // RVA: 0x7ffaadf81080
        public void .cctor(){} // RVA: 0x7ffaadf810e0
        // ── Binary Analysis Named ──
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7ffaa8932320
    }

    public class GregorianCalendar : Calendar
    {
        public object DaysToMonth366; // 0x34FCAFF0

        // ── Original Methods ──
        public void OnDeserialized(){} // RVA: 0x7ffaadf85ab0
        public void get_MinSupportedDateTime(){} // RVA: 0x7ffaadf85ba0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7ffaadf85c00
        public void get_AlgorithmType(){} // RVA: 0x7ffaa8a24af0
        public void .ctor(){} // RVA: 0x7ffaadf85db0
        public void .ctor(){} // RVA: 0x7ffaadf85db0
        public void get_ID(){} // RVA: 0x7ffaa8aeced0
        public void DateToTicks(){} // RVA: 0x7ffaadf862d0
        public void AddMonths(){} // RVA: 0x7ffaadf86350
        public void AddYears(){} // RVA: 0x7ffaadf86870
        public void get_Eras(){} // RVA: 0x7ffaadf86fb0
        public void IsLeapDay(){} // RVA: 0x7ffaadf87300
        public void IsLeapMonth(){} // RVA: 0x7ffaadf878d0
        public void IsLeapYear(){} // RVA: 0x7ffaadf87b70
        public void ToDateTime(){} // RVA: 0x7ffaadf87d40
        public void TryToDateTime(){} // RVA: 0x7ffaadf87e20
        public void get_TwoDigitYearMax(){} // RVA: 0x7ffaadf87f20
        public void set_TwoDigitYearMax(){} // RVA: 0x7ffaadf87fa0
        public void ToFourDigitYear(){} // RVA: 0x7ffaadf880c0
        public void .cctor(){} // RVA: 0x7ffaadf88240
        // ── Binary Analysis Named ──
        public void GetDefaultInstance(){} // RVA: 0x7ffaadf85c60
        public void GetDatePart(){} // RVA: 0x7ffaadf85f00
        public void GetAbsoluteDate(){} // RVA: 0x7ffaadf860d0
        public void GetDayOfMonth(){} // RVA: 0x7ffaadf86890
        public void GetDayOfWeek(){} // RVA: 0x7ffaadf86940
        public void GetDayOfYear(){} // RVA: 0x7ffaadf86a00
        public void GetDaysInMonth(){} // RVA: 0x7ffaadf86ab0
        public void GetDaysInYear(){} // RVA: 0x7ffaadf86dd0
        public void GetEra(){} // RVA: 0x7ffaa8a24af0
        public void GetMonth(){} // RVA: 0x7ffaadf87010
        public void GetMonthsInYear(){} // RVA: 0x7ffaadf870c0
        public void GetYear(){} // RVA: 0x7ffaadf87250
        public void GetLeapMonth(){} // RVA: 0x7ffaadf87750
    }

    public class ISimpleCollator
    {
        // ── Original Methods ──
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x7ffaa864d710
        public void IsSuffix(){} // RVA: 0x7ffaa864d710
        public void IndexOf(){}
        public void LastIndexOf(){}
        // ── Binary Analysis Named ──
        public void GetSortKey(){} // RVA: 0x7ffaa865a110
    }

    public class NumberFormatInfo : Object
    {
        public object currencyGroupSizes; // 0x33BBD760
        public object negativeSign; // 0x33BBD760
        public object currencyGroupSeparator; // 0x33BBD760
        public object ansiCurrencySymbol; // 0x33BBD760
        public object negativeInfinitySymbol; // 0x33BBD760
        public object percentSymbol; // 0x33BBD760
        public object m_dataItem; // 0x33BBD760
        public object currencyPositivePattern; // 0x33BBD760
        public object percentPositivePattern; // 0x33BBD760
        public object digitSubstitution; // 0x33BBD760
        public object m_isInvariant; // 0x33BBD760
        public object InvalidNumberStyles; // 0x33BBD760
        public object InvariantInfo; // 0x1700071E
        public object CurrencyDecimalDigits; // 0x1700071F
        public object CurrencyDecimalSeparator; // 0x17000720
        public object IsReadOnly; // 0x17000721
        public object CurrencyGroupSizes; // 0x17000722
        public object NumberGroupSizes; // 0x17000723
        public object PercentGroupSizes; // 0x17000724
        public object CurrencyGroupSeparator; // 0x17000725
        public object CurrencySymbol; // 0x17000726
        public object CurrentInfo; // 0x17000727
        public object NaNSymbol; // 0x17000728
        public object CurrencyNegativePattern; // 0x17000729

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadf8e480
        public void OnSerializing(){} // RVA: 0x7ffaadf8e310
        public void OnDeserializing(){} // RVA: 0x7ffaa8932310
        public void OnDeserialized(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaadf8e480
        public void VerifyWritable(){} // RVA: 0x7ffaadf8ef20
        public void get_InvariantInfo(){} // RVA: 0x7ffaadf8efa0
        public void Clone(){} // RVA: 0x7ffaadf8f2a0
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7ffaaa5f96a0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7ffaa89d30e0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8dfbd60
        public void get_CurrencyGroupSizes(){} // RVA: 0x7ffaadf8f310
        public void get_NumberGroupSizes(){} // RVA: 0x7ffaadf8f390
        public void get_PercentGroupSizes(){} // RVA: 0x7ffaadf8f410
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7ffaa89ad730
        public void get_CurrencySymbol(){} // RVA: 0x7ffaa89fa500
        public void get_CurrentInfo(){} // RVA: 0x7ffaadf8f490
        public void get_NaNSymbol(){} // RVA: 0x7ffaa89add50
        public void set_NaNSymbol(){} // RVA: 0x7ffaadf8f5c0
        public void get_CurrencyNegativePattern(){} // RVA: 0x7ffaa9d66e50
        public void get_NumberNegativePattern(){} // RVA: 0x7ffaa91d1f30
        public void get_PercentPositivePattern(){} // RVA: 0x7ffaa8b6fed0
        public void get_PercentNegativePattern(){} // RVA: 0x7ffaaa1db140
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7ffaa8af68f0
        public void get_NegativeSign(){} // RVA: 0x7ffaa8bfcc80
        public void get_NumberDecimalDigits(){} // RVA: 0x7ffaabf46940
        public void get_NumberDecimalSeparator(){} // RVA: 0x7ffaa8bf45b0
        public void get_NumberGroupSeparator(){} // RVA: 0x7ffaa89af740
        public void get_CurrencyPositivePattern(){} // RVA: 0x7ffaac120410
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7ffaa89fa590
        public void get_PositiveSign(){} // RVA: 0x7ffaa8960130
        public void get_PercentDecimalDigits(){} // RVA: 0x7ffaa906c660
        public void get_PercentDecimalSeparator(){} // RVA: 0x7ffaa8d1a3b0
        public void get_PercentGroupSeparator(){} // RVA: 0x7ffaa8971010
        public void get_PercentSymbol(){} // RVA: 0x7ffaa8d1b980
        public void get_PerMilleSymbol(){} // RVA: 0x7ffaa8f75d20
        public void ReadOnly(){} // RVA: 0x7ffaadf8f7d0
        public void ValidateParseStyleInteger(){} // RVA: 0x7ffaadf8f8a0
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7ffaadf8f990
        // ── Binary Analysis Named ──
        public void GetInstance(){} // RVA: 0x7ffaadf8f110
        public void GetFormat(){} // RVA: 0x7ffaadf8f6f0
    }

    public class SortKey : Object
    {
        public object options; // 0x3031E850

        // ── Original Methods ──
        public void Compare(){} // RVA: 0x7ffaadf95260
        public void .ctor(){} // RVA: 0x7ffaadf95950
        public void .ctor(){} // RVA: 0x7ffaadf95950
        public void .ctor(){} // RVA: 0x7ffaadf95950
        public void get_OriginalString(){} // RVA: 0x7ffaa894d380
        public void get_KeyData(){} // RVA: 0x7ffaa89357c0
        public void Equals(){} // RVA: 0x7ffaadf956f0
        public void ToString(){} // RVA: 0x7ffaadf95810
        public void .ctor(){} // RVA: 0x7ffaadf95950
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadf957a0
    }

    public class SortVersion : Object
    {
    }

    public class TextInfo : Object
    {
        public object m_cultureName; // 0x33BBDA80
        public object m_IsAsciiCasingSameAsInvariant; // 0x33BBDA80
        public object m_nDataItem; // 0x33BBDA80
        public object wordSeparatorMask; // 0x33BBDA80

        // ── Original Methods ──
        public void get_Invariant(){} // RVA: 0x7ffaadf90300
        public void .ctor(){} // RVA: 0x7ffaadf926f0
        public void OnDeserializing(){} // RVA: 0x7ffaadf90530
        public void OnDeserialized(){} // RVA: 0x7ffaadf907a0
        public void OnDeserialized(){} // RVA: 0x7ffaadf907a0
        public void OnSerializing(){} // RVA: 0x7ffaadf907b0
        public void get_CultureName(){} // RVA: 0x7ffaa8bfcc80
        public void get_IsReadOnly(){} // RVA: 0x7ffaa894d4e0
        public void Clone(){} // RVA: 0x7ffaadf90890
        public void ReadOnly(){} // RVA: 0x7ffaadf90910
        public void get_ListSeparator(){} // RVA: 0x7ffaadf90a00
        public void ToLower(){} // RVA: 0x7ffaadf90ae0
        public void ToLower(){} // RVA: 0x7ffaadf90ae0
        public void ToLowerAsciiInvariant(){} // RVA: 0x7ffaadf90c10
        public void ToUpper(){} // RVA: 0x7ffaadf90c90
        public void ToUpper(){} // RVA: 0x7ffaadf90c90
        public void ToUpperAsciiInvariant(){} // RVA: 0x7ffaadf92510
        public void IsAscii(){} // RVA: 0x7ffaadf90de0
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7ffaadf90df0
        public void Equals(){} // RVA: 0x7ffaadf90f40
        public void ToString(){} // RVA: 0x7ffaadf91050
        public void ToTitleCase(){} // RVA: 0x7ffaadf910b0
        public void AddNonLetter(){} // RVA: 0x7ffaadf91580
        public void AddTitlecaseLetter(){} // RVA: 0x7ffaadf91640
        public void IsWordSeparator(){} // RVA: 0x7ffaadf91860
        public void IsLetterCategory(){} // RVA: 0x7ffaadf91870
        public void get_IsRightToLeft(){} // RVA: 0x7ffaadf91880
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ffaadf907a0
        public void ToUpperInternal(){} // RVA: 0x7ffaadf91a60
        public void ToLowerInternal(){} // RVA: 0x7ffaadf92030
        public void ToUpperInternal(){} // RVA: 0x7ffaadf91a60
        public void ToLowerInternal(){} // RVA: 0x7ffaadf92030
        public void ToUpperAsciiInvariant(){} // RVA: 0x7ffaadf92510
        public void ChangeCase(){} // RVA: 0x7ffaadf925c0
        public void .ctor(){} // RVA: 0x7ffaadf926f0
        // ── Binary Analysis Named ──
        public void SetReadOnlyState(){} // RVA: 0x7ffaa894d4f0
        public void GetHashCode(){} // RVA: 0x7ffaadf91020
    }

    public class TextInfoToUpperData : Object
    {
        public object range_2170_2184; // 0x354EAB10
        public object range_2d00_2d25; // 0x354EAB10

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaadfa25c0
    }

}