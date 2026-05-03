// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 40
// Methods: 822

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86935560
        public void Encode(){} // RVA: 0x7FFE86935590
        public void EncodeDigit(){} // RVA: 0x7FFE86935A50
        public void DecodeDigit(){} // RVA: 0x7FFE86935A70
        public void Adapt(){} // RVA: 0x7FFE86935AA0
        public void Decode(){} // RVA: 0x7FFE86935B20
    }

    public class Calendar : Object
    {
        public long TicksPerMillisecond;
        public long TicksPerSecond;
        public long TicksPerMinute;
        public long TicksPerHour;
        public long TicksPerDay;
        public int MillisPerSecond;
        public int MillisPerMinute;
        public int MillisPerHour;
        public int MillisPerDay;
        public int DaysPerYear;

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE86909710
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE86909770
        public void .ctor(){} // RVA: 0x7FFE869097D0
        public void get_ID(){} // RVA: 0x7FFE81517DA0
        public void get_BaseCalendarID(){} // RVA: 0x7FFE82A336A0
        public void get_AlgorithmType(){} // RVA: 0x7FFE813240E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE8124ABD0
        public void Clone(){} // RVA: 0x7FFE869097E0
        public void ReadOnly(){} // RVA: 0x7FFE86909860
        public void VerifyWritable(){} // RVA: 0x7FFE86909950
        public void SetReadOnlyState(){} // RVA: 0x7FFE8124ABE0
        public void get_CurrentEraValue(){} // RVA: 0x7FFE869099D0
        public void CheckAddResult(){} // RVA: 0x7FFE86909A60
        public void AddMonths(){}
        public void AddYears(){}
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x7FFE86909C40 | overloaded x2
        public void GetDaysInYear(){} // RVA: 0x7FFE80E356E0
        public void GetEra(){}
        public void get_Eras(){} // RVA: 0x7FFE80E2E2E0
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x7FFE80E356E0
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7FFE86909C70
        public void GetWeekOfYearFullDays(){} // RVA: 0x7FFE86909D30
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7FFE86909F70
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFE8690A0E0
        public void GetWeekOfYear(){} // RVA: 0x7FFE8690A0F0
        public void GetYear(){}
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void GetLeapMonth(){} // RVA: 0x7FFE8690A420
        public void IsLeapYear(){} // RVA: 0x7FFE8690A4E0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFE8690A500 | overloaded x2
        public void TryToDateTime(){} // RVA: 0x7FFE8690A560
        public void IsValidYear(){} // RVA: 0x7FFE8690A660
        public void IsValidMonth(){} // RVA: 0x7FFE8690A6F0
        public void IsValidDay(){} // RVA: 0x7FFE8690A770
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE813DB630
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE8690A800
        public void ToFourDigitYear(){} // RVA: 0x7FFE8690A830
        public void TimeToTicks(){} // RVA: 0x7FFE8690A940
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7FFE8690AB20
    }

    public class CalendarData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8690BEC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8690AB80
        public void InitializeEraNames(){} // RVA: 0x7FFE8690CD60
        public void GetJapaneseEraNames(){} // RVA: 0x7FFE8690D270
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7FFE8690D490
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7FFE8690D6B0
        public void GetCalendarData(){} // RVA: 0x7FFE8690DAF0
        public void CalendarIdToCultureName(){} // RVA: 0x7FFE8690DD20
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7FFE81517DA0
        public void nativeGetCalendarData(){} // RVA: 0x7FFE8690DEF0
        public void fill_calendar_data(){} // RVA: 0x7FFE8690E090
    }

    public class CharUnicodeInfo : Object
    {
        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x7FFE868EC3C0 | overloaded x2
        public void InternalGetNumericValue(){} // RVA: 0x7FFE868EC470
        public void GetNumericValue(){} // RVA: 0x7FFE868EC650 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFE868EC880 | overloaded x3
        public void InternalGetCategoryValue(){} // RVA: 0x7FFE868ECA00
        public void InternalGetUnicodeCategory(){} // RVA: 0x7FFE868ECC30 | overloaded x2
        public void IsWhiteSpace(){} // RVA: 0x7FFE868ECDB0 | overloaded x2
        public void get_CategoryLevel1Index(){} // RVA: 0x7FFE868ECDD0
        public void get_CategoryLevel2Index(){} // RVA: 0x7FFE868ECE30
        public void get_CategoryLevel3Index(){} // RVA: 0x7FFE868ECE90
        public void get_CategoriesValue(){} // RVA: 0x7FFE868ECEF0
        public void get_NumericLevel1Index(){} // RVA: 0x7FFE868ECF50
        public void get_NumericLevel2Index(){} // RVA: 0x7FFE868ECFB0
        public void get_NumericLevel3Index(){} // RVA: 0x7FFE868ED010
        public void get_NumericValues(){} // RVA: 0x7FFE868ED070
    }

    public class CodePageDataItem : Object
    {
        public int m_dataIndex; // 0x10
        public int m_uiFamilyCodePage; // 0x14
        public string m_webName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86920220
        public void CreateString(){} // RVA: 0x7FFE869202E0
        public void get_WebName(){} // RVA: 0x7FFE86920430
        public void get_HeaderName(){} // RVA: 0x7FFE86920550
        public void get_BodyName(){} // RVA: 0x7FFE86920680
        public void .cctor(){} // RVA: 0x7FFE869207B0
    }

    public class CompareInfo : Object
    {
        public 0x664D3F34 ValidIndexMaskOffFlags;
        public 0x664D3F34 ValidCompareMaskOffFlags;

        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7FFE868ED0D0
        public void InvariantLastIndexOf(){} // RVA: 0x7FFE868ED1A0
        public void InvariantFindString(){} // RVA: 0x7FFE868ED280
        public void InvariantToUpper(){} // RVA: 0x7FFE868ED680
        public void InvariantCreateSortKey(){} // RVA: 0x7FFE868ED6A0
        public void .ctor(){} // RVA: 0x7FFE868F3030 | overloaded x2
        public void GetCompareInfo(){} // RVA: 0x7FFE868EDA60
        public void OnDeserializing(){} // RVA: 0x7FFE86200400
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE868EDB20
        public void OnDeserialized(){} // RVA: 0x7FFE868EDB30 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFE868EDC80
        public void get_Name(){} // RVA: 0x7FFE868EDD20
        public void Compare(){} // RVA: 0x7FFE868EE870 | overloaded x4
        public void CompareOptionNone(){} // RVA: 0x7FFE868EE5E0
        public void CompareOptionIgnoreCase(){} // RVA: 0x7FFE868EE740
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7FFE868EEFB0 | overloaded x2
        public void IsPrefix(){} // RVA: 0x7FFE868EF470 | overloaded x2
        public void IsSuffix(){} // RVA: 0x7FFE868EF7F0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE868F0200 | overloaded x5
        public void IndexOfOrdinal(){} // RVA: 0x7FFE868F0360
        public void LastIndexOf(){} // RVA: 0x7FFE868F05B0 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFE868F0990
        public void GetSortKey(){} // RVA: 0x7FFE868F0B60
        public void Equals(){} // RVA: 0x7FFE868F0CE0
        public void GetHashCode(){} // RVA: 0x7FFE868F13B0 | overloaded x2
        public void GetIgnoreCaseHash(){} // RVA: 0x7FFE868F0E30
        public void GetHashCodeOfString(){} // RVA: 0x7FFE868F11E0
        public void ToString(){} // RVA: 0x7FFE868F14C0
        public void get_UseManagedCollation(){} // RVA: 0x7FFE868F1520
        public void GetCollator(){} // RVA: 0x7FFE868F1690
        public void CreateSortKeyCore(){} // RVA: 0x7FFE868F1B10
        public void internal_index_switch(){} // RVA: 0x7FFE868F1DB0
        public void internal_compare_switch(){} // RVA: 0x7FFE868F2030
        public void internal_compare_managed(){} // RVA: 0x7FFE868F2230
        public void internal_index_managed(){} // RVA: 0x7FFE868F2330
        public void internal_compare_icall(){} // RVA: 0x7FFE868F23E0
        public void internal_compare(){} // RVA: 0x7FFE868F23F0
        public void internal_index_icall(){} // RVA: 0x7FFE868F24A0
        public void internal_index(){} // RVA: 0x7FFE868F2590
        public void InitSort(){} // RVA: 0x7FFE868F26D0
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7FFE868F2740
        public void IndexOfOrdinalCore(){} // RVA: 0x7FFE868F2900
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7FFE868F2940
        public void LastIndexOfCore(){} // RVA: 0x7FFE868F2980
        public void IndexOfCore(){} // RVA: 0x7FFE868F29C0
        public void CompareString(){} // RVA: 0x7FFE868F2AC0 | overloaded x2
        public void CreateSortKey(){} // RVA: 0x7FFE868F2BD0
        public void StartsWith(){} // RVA: 0x7FFE868EF470 | overloaded x2
        public void EndsWith(){} // RVA: 0x7FFE868EF7F0 | overloaded x2
        public void GetHashCodeOfStringCore(){} // RVA: 0x7FFE868F2ED0
        public void .cctor(){} // RVA: 0x7FFE868F2F10
    }

    public class CultureData : Object
    {
        public string sAM1159; // 0x10
        public string sPM2359; // 0x18
        public string sTimeSeparator; // 0x20
        public string[] saLongTimes; // 0x28
        public string[] saShortTimes; // 0x30
        public int iFirstDayOfWeek; // 0x38
        public int iFirstWeekOfYear; // 0x3C
        public int[] waCalendars; // 0x40
        public System.Globalization.CalendarData[] calendars; // 0x48
        public string sISO639Language; // 0x50
        public string sRealName; // 0x58
        public bool bUseOverrides; // 0x60
        public int calendarId; // 0x64
        public int numberIndex; // 0x68
        public int iDefaultAnsiCodePage; // 0x6C
        public int iDefaultOemCodePage; // 0x70
        public int iDefaultMacCodePage; // 0x74

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C3510
        public void get_Invariant(){} // RVA: 0x7FFE8691DF70
        public void GetCultureData(){} // RVA: 0x7FFE8691E720 | overloaded x2
        public void fill_culture_data(){} // RVA: 0x7FFE8691E910
        public void GetCalendar(){} // RVA: 0x7FFE8691E920
        public void get_LongTimes(){} // RVA: 0x7FFE84CF6780
        public void get_ShortTimes(){} // RVA: 0x7FFE8691EA90
        public void get_SISO639LANGNAME(){} // RVA: 0x7FFE8119C0E0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7FFE81D46090
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7FFE816311C0
        public void get_SAM1159(){} // RVA: 0x7FFE81116380
        public void get_SPM2359(){} // RVA: 0x7FFE810FE7C0
        public void get_TimeSeparator(){} // RVA: 0x7FFE811290C0
        public void get_CalendarIds(){} // RVA: 0x7FFE8691EAA0
        public void GetCalendarIds(){} // RVA: 0x7FFE8691ED40
        public void get_IsInvariantCulture(){} // RVA: 0x7FFE8691EE20
        public void get_CultureName(){} // RVA: 0x7FFE811C3500
        public void get_SCOMPAREINFO(){} // RVA: 0x7FFE8691EE40
        public void get_STEXTINFO(){} // RVA: 0x7FFE811C3500
        public void get_IsRightToLeft(){} // RVA: 0x7FFE816402F0
        public void get_SLIST(){} // RVA: 0x7FFE81280C30
        public void get_UseUserOverride(){} // RVA: 0x7FFE81124020
        public void EraNames(){} // RVA: 0x7FFE8691EE80
        public void AbbrevEraNames(){} // RVA: 0x7FFE8691EEA0
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7FFE8691EEC0
        public void ShortDates(){} // RVA: 0x7FFE8691EEE0
        public void LongDates(){} // RVA: 0x7FFE8691EF00
        public void YearMonths(){} // RVA: 0x7FFE8691EF20
        public void DayNames(){} // RVA: 0x7FFE8691EF40
        public void AbbreviatedDayNames(){} // RVA: 0x7FFE8691EF60
        public void MonthNames(){} // RVA: 0x7FFE8691EF80
        public void GenitiveMonthNames(){} // RVA: 0x7FFE8691EFA0
        public void AbbreviatedMonthNames(){} // RVA: 0x7FFE8691EFC0
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7FFE8691EFE0
        public void LeapYearMonthNames(){} // RVA: 0x7FFE8691F010
        public void MonthDay(){} // RVA: 0x7FFE8691F040
        public void DateSeparator(){} // RVA: 0x7FFE8691F060
        public void GetDateSeparator(){} // RVA: 0x7FFE8691F140
        public void GetSeparator(){} // RVA: 0x7FFE8691F190
        public void IndexOfTimePart(){} // RVA: 0x7FFE8691F370
        public void UnescapeNlsString(){} // RVA: 0x7FFE8691F490
        public void ReescapeWin32Strings(){} // RVA: 0x7FFE827C4A80
        public void ReescapeWin32String(){} // RVA: 0x7FFE827C4A80
        public void strlen(){} // RVA: 0x7FFE8691F650
        public void idx2string(){} // RVA: 0x7FFE8691F670
        public void create_group_sizes_array(){} // RVA: 0x7FFE8691F7A0
        public void GetNFIValues(){} // RVA: 0x7FFE8691F850
        public void fill_number_data(){} // RVA: 0x7FFE86920160
    }

    public class CultureInfo : Object
    {
        public System.Globalization.CultureInfo invariant_culture_info;
        public object shared_table_lock; // 0x8
        public System.Globalization.CultureInfo default_current_culture; // 0x10
        public bool m_isReadOnly; // 0x10
        public int cultureID; // 0x14
        public int parent_lcid; // 0x18
        public int datetime_index; // 0x1C
        public int number_index; // 0x20
        public int default_calendar_type; // 0x24
        public bool m_useUserOverride; // 0x28
        public System.Globalization.NumberFormatInfo numInfo; // 0x30
        public System.Globalization.DateTimeFormatInfo dateTimeInfo; // 0x38
        public System.Globalization.TextInfo textInfo; // 0x40
        public string m_name; // 0x48
        public string englishname; // 0x50
        public string nativename; // 0x58
        public string iso3lang; // 0x60
        public string iso2lang; // 0x68
        public string win3lang; // 0x70
        public string territory; // 0x78
        public string[] native_calendar_names; // 0x80
        public System.Globalization.CompareInfo compareInfo; // 0x88
        public void* textinfo_data; // 0x90
        public int m_dataItem; // 0x98
        public System.Globalization.Calendar calendar; // 0xA0
        public System.Globalization.CultureInfo parent_culture; // 0xA8
        public bool constructed; // 0xB0
        public byte[] cached_serialized_form; // 0xB8
        public System.Globalization.CultureData m_cultureData; // 0xC0
        public bool m_isInherited; // 0xC8
        public int InvariantCultureId;

        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x7FFE81166120
        public void get__isInherited(){} // RVA: 0x7FFE81FF3AD0
        public void get_InvariantCulture(){} // RVA: 0x7FFE8692B710
        public void get_CurrentCulture(){} // RVA: 0x7FFE8692B770
        public void get_CurrentUICulture(){} // RVA: 0x7FFE8692B7C0
        public void set_CurrentUICulture(){} // RVA: 0x7FFE8692B810
        public void ConstructCurrentCulture(){} // RVA: 0x7FFE8692B840
        public void ConstructCurrentUICulture(){} // RVA: 0x7FFE8692BAA0
        public void get_Territory(){} // RVA: 0x7FFE81463AE0
        public void get__name(){} // RVA: 0x7FFE81176730
        public void get_IetfLanguageTag(){} // RVA: 0x7FFE8692BAF0
        public void get_LCID(){} // RVA: 0x7FFE8164B230
        public void get_Name(){} // RVA: 0x7FFE81176730
        public void get_NativeName(){} // RVA: 0x7FFE8692BC30
        public void get_Calendar(){} // RVA: 0x7FFE8692BCA0
        public void get_Parent(){} // RVA: 0x7FFE8692BD70
        public void get_TextInfo(){} // RVA: 0x7FFE8692C050
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7FFE8692C2A0
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7FFE8692C310
        public void Clone(){} // RVA: 0x7FFE8692C380
        public void Equals(){} // RVA: 0x7FFE8692C5E0
        public void GetCultures(){} // RVA: 0x7FFE8692C6C0
        public void GetTextInfoData(){} // RVA: 0x7FFE8692CAC0
        public void GetHashCode(){} // RVA: 0x7FFE8164B230
        public void ReadOnly(){} // RVA: 0x7FFE8692CAE0
        public void ToString(){} // RVA: 0x7FFE81176730
        public void get_CompareInfo(){} // RVA: 0x7FFE8692CD70
        public void get_IsNeutralCulture(){} // RVA: 0x7FFE8692D030
        public void CheckNeutral(){} // RVA: 0x7FFE810FB310
        public void get_NumberFormat(){} // RVA: 0x7FFE8692D070
        public void set_NumberFormat(){} // RVA: 0x7FFE8692D160
        public void get_DateTimeFormat(){} // RVA: 0x7FFE8692D2D0
        public void set_DateTimeFormat(){} // RVA: 0x7FFE8692D4E0
        public void get_DisplayName(){} // RVA: 0x7FFE81866490
        public void get_EnglishName(){} // RVA: 0x7FFE8692D650
        public void get_InstalledUICulture(){} // RVA: 0x7FFE8692D6C0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811C55E0
        public void GetFormat(){} // RVA: 0x7FFE8692D710
        public void Construct(){} // RVA: 0x7FFE8692D860
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7FFE8692D8C0
        public void construct_internal_locale_from_name(){} // RVA: 0x7FFE8692D920
        public void get_current_locale_name(){} // RVA: 0x7FFE8692DAB0
        public void internal_get_cultures(){} // RVA: 0x7FFE8692DB30
        public void ConstructInvariant(){} // RVA: 0x7FFE8692DB40
        public void CreateTextInfo(){} // RVA: 0x7FFE8692E0C0
        public void .ctor(){} // RVA: 0x7FFE8160B370 | overloaded x7
        public void insert_into_shared_tables(){} // RVA: 0x7FFE8692E900
        public void GetCultureInfo(){} // RVA: 0x7FFE8692F220 | overloaded x3
        public void CreateCulture(){} // RVA: 0x7FFE8692F320
        public void CreateSpecificCulture(){} // RVA: 0x7FFE8692F3B0
        public void ConstructLocaleFromName(){} // RVA: 0x7FFE8692F710
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7FFE8692F7C0
        public void get_CalendarType(){} // RVA: 0x7FFE86932A00
        public void CreateCalendar(){} // RVA: 0x7FFE86932AA0
        public void CreateNotFoundException(){} // RVA: 0x7FFE86932CC0
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7FFE86932D70
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7FFE86932DD0
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFE86932E90
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFE86932EF0
        public void get_SortName(){} // RVA: 0x7FFE81176730
        public void get_UserDefaultUICulture(){} // RVA: 0x7FFE86932FB0
        public void get_UserDefaultCulture(){} // RVA: 0x7FFE86933030
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFE86883DB0
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFE810FB310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7FFE86933080
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFE86933210
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFE86933310
        public void get_HasInvariantCultureName(){} // RVA: 0x7FFE86933480
        public void VerifyCultureName(){} // RVA: 0x7FFE86933700 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE869337A0
    }

    public class CultureNotFoundException : ArgumentException
    {
        public string _invalidCultureName; // 0x98
        public System.Nullable`1<int> _invalidCultureId; // 0xA0
        public object field_2; // 0x6B5
        public object field_3; // 0x6B6
        public object field_4; // 0x6B7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868F30D0 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFE868F33E0
        public void get_InvalidCultureId(){} // RVA: 0x7FFE8179C860
        public void get_InvalidCultureName(){} // RVA: 0x7FFE817AE360
        public void get_DefaultMessage(){} // RVA: 0x7FFE868F3720
        public void get_FormatedInvalidCultureId(){} // RVA: 0x7FFE868F3760
        public void get_Message(){} // RVA: 0x7FFE868F38D0
    }

    public class DateTimeFormatInfo : Object
    {
        public System.Globalization.DateTimeFormatInfo s_invariantInfo;
        public System.Globalization.CultureData _cultureData; // 0x10
        public string _name; // 0x18
        public string _langName; // 0x20
        public System.Globalization.CompareInfo _compareInfo; // 0x28
        public System.Globalization.CultureInfo _cultureInfo; // 0x30
        public string amDesignator; // 0x38
        public string pmDesignator; // 0x40
        public string dateSeparator; // 0x48
        public string generalShortTimePattern; // 0x50
        public string generalLongTimePattern; // 0x58
        public string timeSeparator; // 0x60
        public string monthDayPattern; // 0x68
        public string dateTimeOffsetPattern; // 0x70
        public string rfc1123Pattern;
        public string sortableDateTimePattern;
        public string universalSortableDateTimePattern;
        public System.Globalization.Calendar calendar; // 0x78
        public int firstDayOfWeek; // 0x80
        public int calendarWeekRule; // 0x84
        public string fullDateTimePattern; // 0x88
        public string[] abbreviatedDayNames; // 0x90
        public string[] m_superShortDayNames; // 0x98
        public string[] dayNames; // 0xA0
        public string[] abbreviatedMonthNames; // 0xA8
        public string[] monthNames; // 0xB0
        public string[] genitiveMonthNames; // 0xB8
        public string[] m_genitiveAbbreviatedMonthNames; // 0xC0
        public string[] leapYearMonthNames; // 0xC8
        public string longDatePattern; // 0xD0
        public string shortDatePattern; // 0xD8
        public string yearMonthPattern; // 0xE0
        public string longTimePattern; // 0xE8
        public string shortTimePattern; // 0xF0
        public string[] allYearMonthPatterns; // 0xF8
        public string[] allShortDatePatterns; // 0x100
        public string[] allLongDatePatterns; // 0x108
        public string[] allShortTimePatterns; // 0x110
        public string[] allLongTimePatterns; // 0x118
        public string[] m_eraNames; // 0x120
        public string[] m_abbrevEraNames; // 0x128
        public string[] m_abbrevEnglishEraNames; // 0x130
        public 0x664D41F4[] optionalCalendars; // 0x138
        public int DEFAULT_ALL_DATETIMES_SIZE;
        public bool _isReadOnly; // 0x140
        public 0x664D4094 formatFlags; // 0x144
        public char[] s_monthSpaces; // 0x8
        public string RoundtripFormat;
        public string RoundtripDateTimeUnfixed;
        public string _fullTimeSpanPositivePattern; // 0x148
        public string _fullTimeSpanNegativePattern; // 0x150

        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x7FFE868F3AD0
        public void get_Culture(){} // RVA: 0x7FFE868F3B40
        public void get_LanguageName(){} // RVA: 0x7FFE868F3C00
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7FFE868F3C70
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7FFE868F3C90
        public void internalGetDayOfWeekNames(){} // RVA: 0x7FFE868F3D50
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7FFE868F3D70
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7FFE868F3E30
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7FFE868F3E50
        public void internalGetMonthNames(){} // RVA: 0x7FFE868F3F10
        public void internalGetMonthNamesCore(){} // RVA: 0x7FFE868F3F30
        public void .ctor(){} // RVA: 0x7FFE868F41C0 | overloaded x2
        public void InitializeOverridableProperties(){} // RVA: 0x7FFE868F4230
        public void get_InvariantInfo(){} // RVA: 0x7FFE868F46B0
        public void get_CurrentInfo(){} // RVA: 0x7FFE868F4800
        public void GetInstance(){} // RVA: 0x7FFE868F4950
        public void GetFormat(){} // RVA: 0x7FFE868F4AE0
        public void Clone(){} // RVA: 0x7FFE868F4BC0
        public void get_AMDesignator(){} // RVA: 0x7FFE868F4D40
        public void get_Calendar(){} // RVA: 0x7FFE81463AE0
        public void set_Calendar(){} // RVA: 0x7FFE868F4DB0
        public void get_OptionalCalendars(){} // RVA: 0x7FFE868F5250
        public void get_EraNames(){} // RVA: 0x7FFE868F53C0
        public void GetEraName(){} // RVA: 0x7FFE868F5490
        public void get_AbbreviatedEraNames(){} // RVA: 0x7FFE868F5630
        public void GetAbbreviatedEraName(){} // RVA: 0x7FFE868F5700
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7FFE868F58C0
        public void get_DateSeparator(){} // RVA: 0x7FFE868F5990
        public void get_FullDateTimePattern(){} // RVA: 0x7FFE868F5A40
        public void get_LongDatePattern(){} // RVA: 0x7FFE868F5B10
        public void get_LongTimePattern(){} // RVA: 0x7FFE868F5BB0
        public void get_MonthDayPattern(){} // RVA: 0x7FFE868F5C50
        public void get_PMDesignator(){} // RVA: 0x7FFE868F5D10
        public void get_RFC1123Pattern(){} // RVA: 0x7FFE868F5D80
        public void get_ShortDatePattern(){} // RVA: 0x7FFE868F5DC0
        public void get_ShortTimePattern(){} // RVA: 0x7FFE868F5E60
        public void get_SortableDateTimePattern(){} // RVA: 0x7FFE868F5F00
        public void get_GeneralShortTimePattern(){} // RVA: 0x7FFE868F5F40
        public void get_GeneralLongTimePattern(){} // RVA: 0x7FFE868F6000
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7FFE868F60C0
        public void get_TimeSeparator(){} // RVA: 0x7FFE868F62E0
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7FFE868F6350
        public void get_YearMonthPattern(){} // RVA: 0x7FFE868F6390
        public void get_AbbreviatedDayNames(){} // RVA: 0x7FFE868F6430
        public void get_DayNames(){} // RVA: 0x7FFE868F64C0
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7FFE868F6550
        public void get_MonthNames(){} // RVA: 0x7FFE868F65E0
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7FFE868F6670
        public void get_HasSpacesInDayNames(){} // RVA: 0x7FFE868F66A0
        public void internalGetMonthName(){} // RVA: 0x7FFE868F66D0
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7FFE868F6830
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7FFE868F69E0
        public void GetAbbreviatedDayName(){} // RVA: 0x7FFE868F6AB0
        public void GetCombinedPatterns(){} // RVA: 0x7FFE868F6BC0
        public void GetAllDateTimePatterns(){} // RVA: 0x7FFE868F6CD0
        public void GetDayName(){} // RVA: 0x7FFE868F7180
        public void GetAbbreviatedMonthName(){} // RVA: 0x7FFE868F7290
        public void GetMonthName(){} // RVA: 0x7FFE868F73A0
        public void GetMergedPatterns(){} // RVA: 0x7FFE868F74B0
        public void get_AllYearMonthPatterns(){} // RVA: 0x7FFE868F76B0
        public void get_AllShortDatePatterns(){} // RVA: 0x7FFE868F7730
        public void get_AllShortTimePatterns(){} // RVA: 0x7FFE868F77B0
        public void get_AllLongDatePatterns(){} // RVA: 0x7FFE868F7830
        public void get_AllLongTimePatterns(){} // RVA: 0x7FFE868F78B0
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7FFE868F7930
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7FFE868F7A00
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7FFE868F7AD0
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7FFE868F7BA0
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7FFE868F7C30
        public void ReadOnly(){} // RVA: 0x7FFE868F7CC0
        public void get_IsReadOnly(){} // RVA: 0x7FFE868F7EE0
        public void get_MonthGenitiveNames(){} // RVA: 0x7FFE868F7F80
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7FFE868F8010
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7FFE868F8150
        public void get_CompareInfo(){} // RVA: 0x7FFE868F8200
        public void ValidateStyles(){} // RVA: 0x7FFE868F8390
        public void get_FormatFlags(){} // RVA: 0x7FFE868F84C0
        public void InitializeFormatFlags(){} // RVA: 0x7FFE868F84E0
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7FFE868F8730
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7FFE868F8770
        public void YearMonthAdjustment(){} // RVA: 0x7FFE868F87A0
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7FFE868F88E0
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7FFE868F8AC0
        public void ClearTokenHashTable(){} // RVA: 0x7FFE868F8CA0
        public void CreateTokenHashTable(){} // RVA: 0x7FFE868F8D20
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7FFE868F9950
        public void IsJapaneseCalendar(){} // RVA: 0x7FFE868FA730
        public void AddMonthNames(){} // RVA: 0x7FFE868FA870
        public void TryParseHebrewNumber(){} // RVA: 0x7FFE868FA940
        public void IsHebrewChar(){} // RVA: 0x7FFE868FAB40
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7FFE868FAB60
        public void Tokenize(){} // RVA: 0x7FFE868FACB0
        public void InsertAtCurrentHashNode(){} // RVA: 0x7FFE868FB3D0
        public void InsertHash(){} // RVA: 0x7FFE868FB610
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7FFE868FBA10
        public void .cctor(){} // RVA: 0x7FFE868FBB40
    }

    public class DateTimeFormatInfoScanner : Object
    {
        public System.Collections.Generic.List`1<string> m_dateWords; // 0x10

        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x7FFE868FBC30
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x7FFE868FC2A0
        public void AddDateWordOrPostfix(){} // RVA: 0x7FFE868FC390
        public void AddDateWords(){} // RVA: 0x7FFE868FC620
        public void ScanRepeatChar(){} // RVA: 0x7FFE868FC8B0
        public void AddIgnorableSymbols(){} // RVA: 0x7FFE868FC910
        public void ScanDateWord(){} // RVA: 0x7FFE868FCAA0
        public void GetDateWordsOfDTFI(){} // RVA: 0x7FFE868FCD60
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x7FFE868FD080
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x7FFE868FD0D0
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x7FFE868FD190
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x7FFE868FD1D0
        public void EqualStringArrays(){} // RVA: 0x7FFE868FD1E0
        public void ArrayElementsHaveSpace(){} // RVA: 0x7FFE868FD2C0
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x7FFE868FD3C0
        public void .ctor(){} // RVA: 0x7FFE868FD5E0
    }

    public class DaylightTime : Object
    {
        public System.DateTime _start; // 0x10
        public System.DateTime _end; // 0x18
        public System.TimeSpan _delta; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868FD6A0
        public void get_Start(){} // RVA: 0x7FFE81116380
        public void get_End(){} // RVA: 0x7FFE810FE7C0
        public void get_Delta(){} // RVA: 0x7FFE811290C0
    }

    public class DaylightTimeStruct : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868FD6B0
    }

    public class EncodingTable : Object
    {
        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x7FFE86920890
        public void ENC(){} // RVA: 0x7FFE86920900
        public void MapCodePageDataItem(){} // RVA: 0x7FFE86920970
        public void .cctor(){} // RVA: 0x7FFE869209E0
        public void internalGetCodePageFromName(){} // RVA: 0x7FFE8692A0B0
        public void GetCodePageFromName(){} // RVA: 0x7FFE8692A450
        public void GetCodePageDataItem(){} // RVA: 0x7FFE8692A7E0
    }

    public class EraInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86910AF0 | overloaded x2
    }

    public class FormatProvider : Object
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x7FFE8736EB40
        public void TryStringToBigInteger(){} // RVA: 0x7FFE8736ECC0
    }

    public class GlobalizationMode : Object
    {
        public bool _invariant;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFE86909670
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7FFE810FB320
        public void .cctor(){} // RVA: 0x7FFE869096D0
    }

    public class GregorianCalendar : Calendar
    {
        public 0x664D4DA4 m_type; // 0x20
        public int[] DaysToMonth365;
        public int[] DaysToMonth366; // 0x8
        public System.Globalization.Calendar s_defaultInstance; // 0x10
        public object field_4; // 0x708
        public object field_5; // 0x709

        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFE8690E0A0
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE8690E190
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE8690E1F0
        public void get_AlgorithmType(){} // RVA: 0x7FFE811EDAF0
        public void GetDefaultInstance(){} // RVA: 0x7FFE8690E250
        public void .ctor(){} // RVA: 0x7FFE8690E3A0 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFE8151D690
        public void GetDatePart(){} // RVA: 0x7FFE8690E4F0
        public void GetAbsoluteDate(){} // RVA: 0x7FFE8690E6C0
        public void DateToTicks(){} // RVA: 0x7FFE8690E8C0
        public void AddMonths(){} // RVA: 0x7FFE8690E940
        public void AddYears(){} // RVA: 0x7FFE8690EE60
        public void GetDayOfMonth(){} // RVA: 0x7FFE8690EE80
        public void GetDayOfWeek(){} // RVA: 0x7FFE8690EF30
        public void GetDayOfYear(){} // RVA: 0x7FFE8690EFF0
        public void GetDaysInMonth(){} // RVA: 0x7FFE8690F0A0
        public void GetDaysInYear(){} // RVA: 0x7FFE8690F3C0
        public void GetEra(){} // RVA: 0x7FFE811EDAF0
        public void get_Eras(){} // RVA: 0x7FFE8690F5A0
        public void GetMonth(){} // RVA: 0x7FFE8690F600
        public void GetMonthsInYear(){} // RVA: 0x7FFE8690F6B0
        public void GetYear(){} // RVA: 0x7FFE8690F840
        public void IsLeapDay(){} // RVA: 0x7FFE8690F8F0
        public void GetLeapMonth(){} // RVA: 0x7FFE8690FD40
        public void IsLeapMonth(){} // RVA: 0x7FFE8690FEC0
        public void IsLeapYear(){} // RVA: 0x7FFE86910160
        public void ToDateTime(){} // RVA: 0x7FFE86910330
        public void TryToDateTime(){} // RVA: 0x7FFE86910410
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE86910510
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE86910590
        public void ToFourDigitYear(){} // RVA: 0x7FFE869106B0
        public void .cctor(){} // RVA: 0x7FFE86910830
    }

    public class GregorianCalendarHelper : Object
    {
        public int[] DaysToMonth365;
        public int[] DaysToMonth366; // 0x8

        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE86910D00
        public void GetYearOffset(){} // RVA: 0x7FFE86910E30
        public void GetGregorianYear(){} // RVA: 0x7FFE869111C0
        public void IsValidYear(){} // RVA: 0x7FFE869111F0
        public void GetDatePart(){} // RVA: 0x7FFE86911210
        public void GetAbsoluteDate(){} // RVA: 0x7FFE86911400
        public void DateToTicks(){} // RVA: 0x7FFE86911600
        public void TimeToTicks(){} // RVA: 0x7FFE86911680
        public void CheckTicksRange(){} // RVA: 0x7FFE86911860
        public void AddMonths(){} // RVA: 0x7FFE86911AD0
        public void AddYears(){} // RVA: 0x7FFE86912050
        public void GetDayOfMonth(){} // RVA: 0x7FFE86912060
        public void GetDayOfWeek(){} // RVA: 0x7FFE86912110
        public void GetDayOfYear(){} // RVA: 0x7FFE86912230
        public void GetDaysInMonth(){} // RVA: 0x7FFE869122E0
        public void GetDaysInYear(){} // RVA: 0x7FFE86912490
        public void GetEra(){} // RVA: 0x7FFE86912520
        public void get_Eras(){} // RVA: 0x7FFE86912660
        public void GetMonth(){} // RVA: 0x7FFE869127D0
        public void GetMonthsInYear(){} // RVA: 0x7FFE86912880
        public void GetYear(){} // RVA: 0x7FFE869128A0
        public void IsLeapDay(){} // RVA: 0x7FFE86912A00
        public void GetLeapMonth(){} // RVA: 0x7FFE86912B90
        public void IsLeapMonth(){} // RVA: 0x7FFE86912BB0
        public void IsLeapYear(){} // RVA: 0x7FFE86912CE0
        public void ToDateTime(){} // RVA: 0x7FFE86912D60
        public void GetWeekOfYear(){} // RVA: 0x7FFE86912EB0
        public void ToFourDigitYear(){} // RVA: 0x7FFE86912FD0
        public void .cctor(){} // RVA: 0x7FFE869131D0
    }

    public class HebrewNumber : Object
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE868FD6D0
        public void ParseByChar(){} // RVA: 0x7FFE868FDAF0
        public void IsDigit(){} // RVA: 0x7FFE868FDCB0
        public void .cctor(){} // RVA: 0x7FFE868FDD90
    }

    public class HebrewNumberParsingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868FD6C0
    }

    public class HijriCalendar : Calendar
    {
        public int HijriEra;
        public int[] HijriMonthDays; // 0x8
        public int m_HijriAdvance; // 0x20
        public System.DateTime calendarMinValue; // 0x10
        public System.DateTime calendarMaxValue; // 0x18
        public object field_5; // 0x710
        public object field_6; // 0x711
        public object field_7; // 0x712

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE86913370
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE869133D0
        public void get_AlgorithmType(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE86913430
        public void get_ID(){} // RVA: 0x7FFE81815210
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFE86913450
        public void GetAbsoluteDateHijri(){} // RVA: 0x7FFE86913460
        public void DaysUpToHijriYear(){} // RVA: 0x7FFE86913580
        public void get_HijriAdjustment(){} // RVA: 0x7FFE86913640
        public void GetAdvanceHijriDate(){} // RVA: 0x7FFE813240E0
        public void CheckTicksRange(){} // RVA: 0x7FFE869136A0
        public void CheckEraRange(){} // RVA: 0x7FFE86913920
        public void CheckYearRange(){} // RVA: 0x7FFE869139F0
        public void CheckYearMonthRange(){} // RVA: 0x7FFE86913BF0
        public void GetDatePart(){} // RVA: 0x7FFE86913DC0
        public void AddMonths(){} // RVA: 0x7FFE86914060
        public void AddYears(){} // RVA: 0x7FFE8690EE60
        public void GetDayOfMonth(){} // RVA: 0x7FFE869144B0
        public void GetDayOfWeek(){} // RVA: 0x7FFE86914560
        public void GetDayOfYear(){} // RVA: 0x7FFE86914620
        public void GetDaysInMonth(){} // RVA: 0x7FFE869146D0
        public void GetDaysInYear(){} // RVA: 0x7FFE869147A0
        public void GetEra(){} // RVA: 0x7FFE86914840
        public void get_Eras(){} // RVA: 0x7FFE86914910
        public void GetMonth(){} // RVA: 0x7FFE869149B0
        public void GetMonthsInYear(){} // RVA: 0x7FFE86914A60
        public void GetYear(){} // RVA: 0x7FFE86914AD0
        public void IsLeapDay(){} // RVA: 0x7FFE86914B80
        public void GetLeapMonth(){} // RVA: 0x7FFE86914D00
        public void IsLeapMonth(){} // RVA: 0x7FFE86914D60
        public void IsLeapYear(){} // RVA: 0x7FFE86914DD0
        public void ToDateTime(){} // RVA: 0x7FFE86914E50
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE86915070
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE869150F0
        public void ToFourDigitYear(){} // RVA: 0x7FFE86915210
        public void .cctor(){} // RVA: 0x7FFE869153B0
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x7FFE80E3F2F0
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x7FFE80E32820
        public void IsSuffix(){} // RVA: 0x7FFE80E32820
        public void IndexOf(){}
        public void LastIndexOf(){}
    }

    public class IdnMapping : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86933CD0
        public void Equals(){} // RVA: 0x7FFE86933DA0
        public void GetHashCode(){} // RVA: 0x7FFE86933E20
        public void GetAscii(){} // RVA: 0x7FFE86933F10 | overloaded x2
        public void Convert(){} // RVA: 0x7FFE86934030
        public void ToAscii(){} // RVA: 0x7FFE869343C0
        public void VerifyLength(){} // RVA: 0x7FFE86934840
        public void NamePrep(){} // RVA: 0x7FFE86934980
        public void VerifyProhibitedCharacters(){} // RVA: 0x7FFE86934AD0
        public void VerifyStd3AsciiRules(){} // RVA: 0x7FFE86934D30
        public void GetUnicode(){} // RVA: 0x7FFE86935070 | overloaded x2
        public void ToUnicode(){} // RVA: 0x7FFE86935190
    }

    public class InternalCodePageDataItem : ValueType
    {
    }

    public class InternalEncodingDataItem : ValueType
    {
    }

    public class JapaneseCalendar : Calendar
    {
        public System.DateTime calendarMinValue;
        public System.Globalization.EraInfo[] japaneseEraInfo; // 0x8
        public System.Globalization.Calendar s_defaultInstance; // 0x10
        public System.Globalization.GregorianCalendarHelper helper; // 0x20
        public object field_4; // 0x718
        public object field_5; // 0x719

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE86915560
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE869155C0
        public void get_AlgorithmType(){} // RVA: 0x7FFE811EDAF0
        public void GetEraInfo(){} // RVA: 0x7FFE86915620
        public void GetErasFromRegistry(){} // RVA: 0x7FFE813240E0
        public void GetDefaultInstance(){} // RVA: 0x7FFE86915CD0
        public void .ctor(){} // RVA: 0x7FFE86915E10
        public void get_ID(){} // RVA: 0x7FFE817BF630
        public void AddMonths(){} // RVA: 0x7FFE86915FD0
        public void AddYears(){} // RVA: 0x7FFE86915FF0
        public void GetDaysInMonth(){} // RVA: 0x7FFE86916020
        public void GetDaysInYear(){} // RVA: 0x7FFE86916050
        public void GetDayOfMonth(){} // RVA: 0x7FFE86916070
        public void GetDayOfWeek(){} // RVA: 0x7FFE86916090
        public void GetDayOfYear(){} // RVA: 0x7FFE869160B0
        public void GetMonthsInYear(){} // RVA: 0x7FFE869160D0
        public void GetWeekOfYear(){} // RVA: 0x7FFE86916100
        public void GetEra(){} // RVA: 0x7FFE86916130
        public void GetMonth(){} // RVA: 0x7FFE86916150
        public void GetYear(){} // RVA: 0x7FFE86916170
        public void IsLeapDay(){} // RVA: 0x7FFE86916190
        public void IsLeapYear(){} // RVA: 0x7FFE869161C0
        public void GetLeapMonth(){} // RVA: 0x7FFE869161E0
        public void IsLeapMonth(){} // RVA: 0x7FFE86916210
        public void ToDateTime(){} // RVA: 0x7FFE86916240
        public void ToFourDigitYear(){} // RVA: 0x7FFE86916270
        public void get_Eras(){} // RVA: 0x7FFE86916420
        public void EraNames(){} // RVA: 0x7FFE86916440
        public void EnglishEraNames(){} // RVA: 0x7FFE86916550
        public void IsValidYear(){} // RVA: 0x7FFE86916660
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE86916690
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE86916710
        public void .cctor(){} // RVA: 0x7FFE86916860
    }

    public class NumberFormatInfo : Object
    {
        public System.Globalization.NumberFormatInfo invariantInfo;
        public int[] numberGroupSizes; // 0x10
        public int[] currencyGroupSizes; // 0x18
        public int[] percentGroupSizes; // 0x20
        public string positiveSign; // 0x28
        public string negativeSign; // 0x30
        public string numberDecimalSeparator; // 0x38
        public string numberGroupSeparator; // 0x40
        public string currencyGroupSeparator; // 0x48
        public string currencyDecimalSeparator; // 0x50
        public string currencySymbol; // 0x58
        public string ansiCurrencySymbol; // 0x60
        public string nanSymbol; // 0x68
        public string positiveInfinitySymbol; // 0x70
        public string negativeInfinitySymbol; // 0x78
        public string percentDecimalSeparator; // 0x80
        public string percentGroupSeparator; // 0x88
        public string percentSymbol; // 0x90
        public string perMilleSymbol; // 0x98
        public string[] nativeDigits; // 0xA0
        public int m_dataItem; // 0xA8
        public int numberDecimalDigits; // 0xAC
        public int currencyDecimalDigits; // 0xB0
        public int currencyPositivePattern; // 0xB4
        public int currencyNegativePattern; // 0xB8
        public int numberNegativePattern; // 0xBC
        public int percentPositivePattern; // 0xC0
        public int percentNegativePattern; // 0xC4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86916A70 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFE86916900
        public void OnDeserializing(){} // RVA: 0x7FFE810FB310
        public void OnDeserialized(){} // RVA: 0x7FFE810FB310
        public void VerifyWritable(){} // RVA: 0x7FFE86917510
        public void get_InvariantInfo(){} // RVA: 0x7FFE86917590
        public void GetInstance(){} // RVA: 0x7FFE86917700
        public void Clone(){} // RVA: 0x7FFE86917890
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7FFE82E64BF0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7FFE8119C0E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE81644E40
        public void get_CurrencyGroupSizes(){} // RVA: 0x7FFE86917900
        public void get_NumberGroupSizes(){} // RVA: 0x7FFE86917980
        public void get_PercentGroupSizes(){} // RVA: 0x7FFE86917A00
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7FFE81176730
        public void get_CurrencySymbol(){} // RVA: 0x7FFE811C3500
        public void get_CurrentInfo(){} // RVA: 0x7FFE86917A80
        public void get_NaNSymbol(){} // RVA: 0x7FFE81176D50
        public void set_NaNSymbol(){} // RVA: 0x7FFE86917BB0
        public void get_CurrencyNegativePattern(){} // RVA: 0x7FFE8260FFA0
        public void get_NumberNegativePattern(){} // RVA: 0x7FFE818D2E10
        public void get_PercentPositivePattern(){} // RVA: 0x7FFE813AB640
        public void get_PercentNegativePattern(){} // RVA: 0x7FFE82A3B5F0
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7FFE81463AE0
        public void get_NegativeSign(){} // RVA: 0x7FFE8144E200
        public void get_NumberDecimalDigits(){} // RVA: 0x7FFE848BEEF0
        public void get_NumberDecimalSeparator(){} // RVA: 0x7FFE8143BA80
        public void get_NumberGroupSeparator(){} // RVA: 0x7FFE81178740
        public void get_CurrencyPositivePattern(){} // RVA: 0x7FFE84A61A20
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7FFE811C3590
        public void get_PositiveSign(){} // RVA: 0x7FFE81129130
        public void get_PercentDecimalDigits(){} // RVA: 0x7FFE81790750
        public void get_PercentDecimalSeparator(){} // RVA: 0x7FFE81280C30
        public void get_PercentGroupSeparator(){} // RVA: 0x7FFE8113A010
        public void get_PercentSymbol(){} // RVA: 0x7FFE8154EB60
        public void get_PerMilleSymbol(){} // RVA: 0x7FFE817AE360
        public void GetFormat(){} // RVA: 0x7FFE86917CE0
        public void ReadOnly(){} // RVA: 0x7FFE86917DC0
        public void ValidateParseStyleInteger(){} // RVA: 0x7FFE86917E90
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7FFE86917F80
    }

    public class Punycode : Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86935DE0
    }

    public class RegionInfo : Object
    {
        public System.Globalization.RegionInfo currentRegion;
        public int regionId; // 0x10
        public string iso2Name; // 0x18
        public string iso3Name; // 0x20
        public string win3Name; // 0x28
        public string englishName; // 0x30
        public string nativeName; // 0x38
        public string currencySymbol; // 0x40
        public string isoCurrencySymbol; // 0x48
        public string currencyEnglishName; // 0x50
        public string currencyNativeName; // 0x58
        public object field_11; // 0x789
        public object field_12; // 0x78A
        public object field_13; // 0x78B

        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x7FFE86935E20
        public void .ctor(){} // RVA: 0x7FFE869362C0 | overloaded x3
        public void GetByTerritory(){} // RVA: 0x7FFE86936750
        public void construct_internal_region_from_name(){} // RVA: 0x7FFE86936800
        public void get_CurrencyEnglishName(){} // RVA: 0x7FFE8119C0E0
        public void get_CurrencySymbol(){} // RVA: 0x7FFE81178740
        public void get_DisplayName(){} // RVA: 0x7FFE8144E200
        public void get_EnglishName(){} // RVA: 0x7FFE8144E200
        public void get_GeoId(){} // RVA: 0x7FFE811485C0
        public void get_IsMetric(){} // RVA: 0x7FFE86936990
        public void get_ISOCurrencySymbol(){} // RVA: 0x7FFE81176730
        public void get_NativeName(){} // RVA: 0x7FFE8143BA80
        public void get_CurrencyNativeName(){} // RVA: 0x7FFE811C3500
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_ThreeLetterISORegionName(){} // RVA: 0x7FFE811290C0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0x7FFE81129130
        public void get_TwoLetterISORegionName(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86936A60
        public void GetHashCode(){} // RVA: 0x7FFE86936B70
        public void ToString(){} // RVA: 0x7FFE825CB0A0
        public void ClearCachedData(){} // RVA: 0x7FFE86936BB0
    }

    public class SortKey : Object
    {
        public string source; // 0x10
        public byte[] key; // 0x18

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8691D850
        public void .ctor(){} // RVA: 0x7FFE8691DF40 | overloaded x4
        public void get_OriginalString(){} // RVA: 0x7FFE81116380
        public void get_KeyData(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8691DCE0
        public void GetHashCode(){} // RVA: 0x7FFE8691DD90
        public void ToString(){} // RVA: 0x7FFE8691DE00
    }

    public class SortVersion : Object
    {
    }

    public class TaiwanCalendar : Calendar
    {
        public System.Globalization.EraInfo[] taiwanEraInfo;
        public System.Globalization.Calendar s_defaultInstance; // 0x8
        public System.Globalization.GregorianCalendarHelper helper; // 0x20
        public System.DateTime calendarMinValue; // 0x10
        public object field_4; // 0x73A
        public object field_5; // 0x73B

        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x7FFE86918060
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE869181A0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE86918200
        public void get_AlgorithmType(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE86918260
        public void get_ID(){} // RVA: 0x7FFE8180E590
        public void AddMonths(){} // RVA: 0x7FFE86915FD0
        public void AddYears(){} // RVA: 0x7FFE86915FF0
        public void GetDaysInMonth(){} // RVA: 0x7FFE86916020
        public void GetDaysInYear(){} // RVA: 0x7FFE86916050
        public void GetDayOfMonth(){} // RVA: 0x7FFE86916070
        public void GetDayOfWeek(){} // RVA: 0x7FFE86916090
        public void GetDayOfYear(){} // RVA: 0x7FFE869160B0
        public void GetMonthsInYear(){} // RVA: 0x7FFE869160D0
        public void GetWeekOfYear(){} // RVA: 0x7FFE86916100
        public void GetEra(){} // RVA: 0x7FFE86916130
        public void GetMonth(){} // RVA: 0x7FFE86916150
        public void GetYear(){} // RVA: 0x7FFE86916170
        public void IsLeapDay(){} // RVA: 0x7FFE86916190
        public void IsLeapYear(){} // RVA: 0x7FFE869161C0
        public void GetLeapMonth(){} // RVA: 0x7FFE869161E0
        public void IsLeapMonth(){} // RVA: 0x7FFE86916210
        public void ToDateTime(){} // RVA: 0x7FFE86916240
        public void get_Eras(){} // RVA: 0x7FFE86916420
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE86916690
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE86918430
        public void ToFourDigitYear(){} // RVA: 0x7FFE86918580
        public void .cctor(){} // RVA: 0x7FFE86918730
    }

    public class TextInfo : Object
    {
        public string m_listSeparator; // 0x10
        public bool m_isReadOnly; // 0x18
        public string m_cultureName; // 0x20
        public System.Globalization.CultureData m_cultureData; // 0x28
        public string m_textInfoName; // 0x30
        public System.Nullable`1<bool> m_IsAsciiCasingSameAsInvariant; // 0x38

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFE869188F0
        public void .ctor(){} // RVA: 0x7FFE8691ACE0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFE86918B20
        public void OnDeserialized(){} // RVA: 0x7FFE86918D90 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFE86918DA0
        public void get_CultureName(){} // RVA: 0x7FFE8144E200
        public void get_IsReadOnly(){} // RVA: 0x7FFE811164E0
        public void Clone(){} // RVA: 0x7FFE86918E80
        public void ReadOnly(){} // RVA: 0x7FFE86918F00
        public void SetReadOnlyState(){} // RVA: 0x7FFE811164F0
        public void get_ListSeparator(){} // RVA: 0x7FFE86918FF0
        public void ToLower(){} // RVA: 0x7FFE869190D0 | overloaded x2
        public void ToLowerAsciiInvariant(){} // RVA: 0x7FFE86919200
        public void ToUpper(){} // RVA: 0x7FFE86919280 | overloaded x2
        public void ToUpperAsciiInvariant(){} // RVA: 0x7FFE8691AB00 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFE869193D0
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7FFE869193E0
        public void Equals(){} // RVA: 0x7FFE86919530
        public void GetHashCode(){} // RVA: 0x7FFE86919610
        public void ToString(){} // RVA: 0x7FFE86919640
        public void ToTitleCase(){} // RVA: 0x7FFE869196A0
        public void AddNonLetter(){} // RVA: 0x7FFE86919B70
        public void AddTitlecaseLetter(){} // RVA: 0x7FFE86919C30
        public void IsWordSeparator(){} // RVA: 0x7FFE86919E50
        public void IsLetterCategory(){} // RVA: 0x7FFE86919E60
        public void get_IsRightToLeft(){} // RVA: 0x7FFE86919E70
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE86918D90
        public void ToUpperInternal(){} // RVA: 0x7FFE8691A050 | overloaded x2
        public void ToLowerInternal(){} // RVA: 0x7FFE8691A620 | overloaded x2
        public void ChangeCase(){} // RVA: 0x7FFE8691ABB0
    }

    public class TextInfoToLowerData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8692B110
    }

    public class TextInfoToUpperData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8692ABB0
    }

    public class ThaiBuddhistCalendar : Calendar
    {
        public System.Globalization.EraInfo[] thaiBuddhistEraInfo;
        public int ThaiBuddhistEra;
        public System.Globalization.GregorianCalendarHelper helper; // 0x20
        public int DEFAULT_TWO_DIGIT_YEAR_MAX;
        public object field_4; // 0x746
        public object field_5; // 0x747

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE8691AD10
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE8691AD70
        public void get_AlgorithmType(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE8691ADD0
        public void get_ID(){} // RVA: 0x7FFE817F39D0
        public void AddMonths(){} // RVA: 0x7FFE86915FD0
        public void AddYears(){} // RVA: 0x7FFE86915FF0
        public void GetDaysInMonth(){} // RVA: 0x7FFE86916020
        public void GetDaysInYear(){} // RVA: 0x7FFE86916050
        public void GetDayOfMonth(){} // RVA: 0x7FFE86916070
        public void GetDayOfWeek(){} // RVA: 0x7FFE86916090
        public void GetDayOfYear(){} // RVA: 0x7FFE869160B0
        public void GetMonthsInYear(){} // RVA: 0x7FFE869160D0
        public void GetWeekOfYear(){} // RVA: 0x7FFE86916100
        public void GetEra(){} // RVA: 0x7FFE86916130
        public void GetMonth(){} // RVA: 0x7FFE86916150
        public void GetYear(){} // RVA: 0x7FFE86916170
        public void IsLeapDay(){} // RVA: 0x7FFE86916190
        public void IsLeapYear(){} // RVA: 0x7FFE869161C0
        public void GetLeapMonth(){} // RVA: 0x7FFE869161E0
        public void IsLeapMonth(){} // RVA: 0x7FFE86916210
        public void ToDateTime(){} // RVA: 0x7FFE86916240
        public void get_Eras(){} // RVA: 0x7FFE86916420
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE8691AED0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE8691AF50
        public void ToFourDigitYear(){} // RVA: 0x7FFE8691B0A0
        public void .cctor(){} // RVA: 0x7FFE8691B160
    }

    public class TimeSpanFormat : Object
    {
        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x7FFE868FE200
        public void Format(){} // RVA: 0x7FFE868FE380
        public void TryFormat(){} // RVA: 0x7FFE868FE480
        public void FormatToBuilder(){} // RVA: 0x7FFE868FE580
        public void FormatStandard(){} // RVA: 0x7FFE868FE8A0
        public void FormatCustomized(){} // RVA: 0x7FFE868FEE90
        public void .cctor(){} // RVA: 0x7FFE868FF6D0
    }

    public class TimeSpanParse : Object
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x7FFE86900140
        public void TryTimeToTicks(){} // RVA: 0x7FFE86900240
        public void Parse(){} // RVA: 0x7FFE869003F0
        public void TryParse(){} // RVA: 0x7FFE86900430
        public void ParseExact(){} // RVA: 0x7FFE86900490
        public void TryParseExact(){} // RVA: 0x7FFE869004E0
        public void ParseExactMultiple(){} // RVA: 0x7FFE86900550
        public void TryParseExactMultiple(){} // RVA: 0x7FFE86900590
        public void TryParseTimeSpan(){} // RVA: 0x7FFE869005F0
        public void ProcessTerminalState(){} // RVA: 0x7FFE86901790
        public void ProcessTerminal_DHMSF(){} // RVA: 0x7FFE86901900
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x7FFE86901D50
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x7FFE86903840
        public void ProcessTerminal_HM(){} // RVA: 0x7FFE86904E60
        public void ProcessTerminal_D(){} // RVA: 0x7FFE86905190
        public void TryParseExactTimeSpan(){} // RVA: 0x7FFE869054A0
        public void TryParseByFormat(){} // RVA: 0x7FFE86905640
        public void ParseExactDigits(){} // RVA: 0x7FFE86906270 | overloaded x2
        public void ParseExactLiteral(){} // RVA: 0x7FFE86906350
        public void TryParseTimeSpanConstant(){} // RVA: 0x7FFE86906410
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x7FFE86906450
    }

    public class UmAlQuraCalendar : Calendar
    {
        public DateMapping[] HijriYearInfo;
        public System.DateTime minDate; // 0x8
        public System.DateTime maxDate; // 0x10
        public object field_3; // 0x74C
        public object field_4; // 0x74D
        public object field_5; // 0x74E
        public object field_6; // 0x74F
        public object field_7; // 0x750

        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x7FFE8691B2D0
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFE8691B4B0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFE8691B510
        public void get_AlgorithmType(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE869097D0
        public void get_BaseCalendarID(){} // RVA: 0x7FFE81815210
        public void get_ID(){} // RVA: 0x7FFE8178CF30
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFE8691B570
        public void ConvertHijriToGregorian(){} // RVA: 0x7FFE8691B580
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x7FFE8691B7F0
        public void CheckTicksRange(){} // RVA: 0x7FFE8691B8C0
        public void CheckEraRange(){} // RVA: 0x7FFE8691BB40
        public void CheckYearRange(){} // RVA: 0x7FFE8691BBD0
        public void CheckYearMonthRange(){} // RVA: 0x7FFE8691BD90
        public void ConvertGregorianToHijri(){} // RVA: 0x7FFE8691BE70
        public void GetDatePart(){} // RVA: 0x7FFE8691C290
        public void AddMonths(){} // RVA: 0x7FFE8691C470
        public void AddYears(){} // RVA: 0x7FFE8690EE60
        public void GetDayOfMonth(){} // RVA: 0x7FFE8691C860
        public void GetDayOfWeek(){} // RVA: 0x7FFE8691C880
        public void GetDayOfYear(){} // RVA: 0x7FFE8691C940
        public void GetDaysInMonth(){} // RVA: 0x7FFE8691C960
        public void RealGetDaysInYear(){} // RVA: 0x7FFE8691CA20
        public void GetDaysInYear(){} // RVA: 0x7FFE8691CAD0
        public void GetEra(){} // RVA: 0x7FFE8691CB40
        public void get_Eras(){} // RVA: 0x7FFE8691CC00
        public void GetMonth(){} // RVA: 0x7FFE8691CC60
        public void GetMonthsInYear(){} // RVA: 0x7FFE8691CC80
        public void GetYear(){} // RVA: 0x7FFE8691CCF0
        public void IsLeapDay(){} // RVA: 0x7FFE8691CD10
        public void GetLeapMonth(){} // RVA: 0x7FFE8691CEB0
        public void IsLeapMonth(){} // RVA: 0x7FFE8691CF10
        public void IsLeapYear(){} // RVA: 0x7FFE8691CF80
        public void ToDateTime(){} // RVA: 0x7FFE8691CFF0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFE86915070
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFE8691D2C0
        public void ToFourDigitYear(){} // RVA: 0x7FFE8691D3F0
        public void .cctor(){} // RVA: 0x7FFE8691D590
    }

}