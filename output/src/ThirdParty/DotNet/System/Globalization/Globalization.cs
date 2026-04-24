// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 14
// Methods: 483

namespace ThirdParty.DotNet.System.Globalization
{
    public class Calendar : Object
    {
        public object MinSupportedDateTime;
        public object MaxSupportedDateTime;
        public object ID;
        public object BaseCalendarID;
        public object AlgorithmType;
        public object IsReadOnly;
        public object CurrentEraValue;
        public object Eras;
        public object DaysInYearBeforeMinSupportedYear;
        public object TwoDigitYearMax;

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFD5397FEE0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFD5397FF40
        public void .ctor(){} // RVA: 0x7FFD5397FFA0
        public void get_ID(){} // RVA: 0x7FFD4E6DD0E0
        public void get_BaseCalendarID(){} // RVA: 0x7FFD4FBEB300
        public void get_AlgorithmType(){} // RVA: 0x7FFD4E919180
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E490BD0
        public void Clone(){} // RVA: 0x7FFD5397FFB0
        public void ReadOnly(){} // RVA: 0x7FFD53980030
        public void VerifyWritable(){} // RVA: 0x7FFD53980120
        public void SetReadOnlyState(){} // RVA: 0x7FFD4E490BE0
        public void get_CurrentEraValue(){} // RVA: 0x7FFD539801A0
        public void CheckAddResult(){} // RVA: 0x7FFD53980230
        public void AddMonths(){}
        public void AddYears(){}
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x7FFD53980410 | overloaded x2
        public void GetDaysInYear(){} // RVA: 0x7FFD4E080290
        public void GetEra(){}
        public void get_Eras(){} // RVA: 0x7FFD4E078E90
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x7FFD4E080290
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7FFD53980440
        public void GetWeekOfYearFullDays(){} // RVA: 0x7FFD53980500
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7FFD53980740
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFD539808B0
        public void GetWeekOfYear(){} // RVA: 0x7FFD539808C0
        public void GetYear(){}
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void GetLeapMonth(){} // RVA: 0x7FFD53980BF0
        public void IsLeapYear(){} // RVA: 0x7FFD53980CB0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFD53980CD0 | overloaded x2
        public void TryToDateTime(){} // RVA: 0x7FFD53980D30
        public void IsValidYear(){} // RVA: 0x7FFD53980E30
        public void IsValidMonth(){} // RVA: 0x7FFD53980EC0
        public void IsValidDay(){} // RVA: 0x7FFD53980F40
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFD4E577800
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFD53980FD0
        public void ToFourDigitYear(){} // RVA: 0x7FFD53981000
        public void TimeToTicks(){} // RVA: 0x7FFD53981110
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7FFD539812F0
    }

    public class CalendarData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53982690 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53981350
        public void InitializeEraNames(){} // RVA: 0x7FFD53983530
        public void GetJapaneseEraNames(){} // RVA: 0x7FFD53983A40
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7FFD53983C60
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7FFD53983E80
        public void GetCalendarData(){} // RVA: 0x7FFD539842C0
        public void CalendarIdToCultureName(){} // RVA: 0x7FFD539844F0
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7FFD4E6DD0E0
        public void nativeGetCalendarData(){} // RVA: 0x7FFD539846C0
        public void fill_calendar_data(){} // RVA: 0x7FFD53984860
    }

    public class CompareInfo : Object
    {
        public object Name;
        public object UseManagedCollation;

        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7FFD539638A0
        public void InvariantLastIndexOf(){} // RVA: 0x7FFD53963970
        public void InvariantFindString(){} // RVA: 0x7FFD53963A50
        public void InvariantToUpper(){} // RVA: 0x7FFD53963E50
        public void InvariantCreateSortKey(){} // RVA: 0x7FFD53963E70
        public void .ctor(){} // RVA: 0x7FFD53969800 | overloaded x2
        public void GetCompareInfo(){} // RVA: 0x7FFD53964230
        public void OnDeserializing(){} // RVA: 0x7FFD531FDC00
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD539642F0
        public void OnDeserialized(){} // RVA: 0x7FFD53964300 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFD53964450
        public void get_Name(){} // RVA: 0x7FFD539644F0
        public void Compare(){} // RVA: 0x7FFD53965040 | overloaded x4
        public void CompareOptionNone(){} // RVA: 0x7FFD53964DB0
        public void CompareOptionIgnoreCase(){} // RVA: 0x7FFD53964F10
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7FFD53965780 | overloaded x2
        public void IsPrefix(){} // RVA: 0x7FFD53965C40 | overloaded x2
        public void IsSuffix(){} // RVA: 0x7FFD53965FC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD539669D0 | overloaded x5
        public void IndexOfOrdinal(){} // RVA: 0x7FFD53966B30
        public void LastIndexOf(){} // RVA: 0x7FFD53966D80 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFD53967160
        public void GetSortKey(){} // RVA: 0x7FFD53967330
        public void Equals(){} // RVA: 0x7FFD539674B0
        public void GetHashCode(){} // RVA: 0x7FFD53967B80 | overloaded x2
        public void GetIgnoreCaseHash(){} // RVA: 0x7FFD53967600
        public void GetHashCodeOfString(){} // RVA: 0x7FFD539679B0
        public void ToString(){} // RVA: 0x7FFD53967C90
        public void get_UseManagedCollation(){} // RVA: 0x7FFD53967CF0
        public void GetCollator(){} // RVA: 0x7FFD53967E60
        public void CreateSortKeyCore(){} // RVA: 0x7FFD539682E0
        public void internal_index_switch(){} // RVA: 0x7FFD53968580
        public void internal_compare_switch(){} // RVA: 0x7FFD53968800
        public void internal_compare_managed(){} // RVA: 0x7FFD53968A00
        public void internal_index_managed(){} // RVA: 0x7FFD53968B00
        public void internal_compare_icall(){} // RVA: 0x7FFD53968BB0
        public void internal_compare(){} // RVA: 0x7FFD53968BC0
        public void internal_index_icall(){} // RVA: 0x7FFD53968C70
        public void internal_index(){} // RVA: 0x7FFD53968D60
        public void InitSort(){} // RVA: 0x7FFD53968EA0
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7FFD53968F10
        public void IndexOfOrdinalCore(){} // RVA: 0x7FFD539690D0
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7FFD53969110
        public void LastIndexOfCore(){} // RVA: 0x7FFD53969150
        public void IndexOfCore(){} // RVA: 0x7FFD53969190
        public void CompareString(){} // RVA: 0x7FFD53969290 | overloaded x2
        public void CreateSortKey(){} // RVA: 0x7FFD539693A0
        public void StartsWith(){} // RVA: 0x7FFD53965C40 | overloaded x2
        public void EndsWith(){} // RVA: 0x7FFD53965FC0 | overloaded x2
        public void GetHashCodeOfStringCore(){} // RVA: 0x7FFD539696A0
        public void .cctor(){} // RVA: 0x7FFD539696E0
    }

    public class CultureData : Object
    {
        public object Invariant;
        public object LongTimes;
        public object ShortTimes;
        public object SISO639LANGNAME;
        public object IFIRSTDAYOFWEEK;
        public object IFIRSTWEEKOFYEAR;
        public object SAM1159;
        public object SPM2359;
        public object TimeSeparator;
        public object CalendarIds;
        public object IsInvariantCulture;
        public object CultureName;
        public object SCOMPAREINFO;
        public object STEXTINFO;
        public object IsRightToLeft;
        public object SLIST;
        public object UseUserOverride;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E409510
        public void get_Invariant(){} // RVA: 0x7FFD53994740
        public void GetCultureData(){} // RVA: 0x7FFD53994EF0 | overloaded x2
        public void fill_culture_data(){} // RVA: 0x7FFD539950E0
        public void GetCalendar(){} // RVA: 0x7FFD539950F0
        public void get_LongTimes(){} // RVA: 0x7FFD51DB5200
        public void get_ShortTimes(){} // RVA: 0x7FFD53995260
        public void get_SISO639LANGNAME(){} // RVA: 0x7FFD4E3E20E0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7FFD4E9AA870
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7FFD4E7DD4A0
        public void get_SAM1159(){} // RVA: 0x7FFD4E35C380
        public void get_SPM2359(){} // RVA: 0x7FFD4E3447C0
        public void get_TimeSeparator(){} // RVA: 0x7FFD4E36F0C0
        public void get_CalendarIds(){} // RVA: 0x7FFD53995270
        public void GetCalendarIds(){} // RVA: 0x7FFD53995510
        public void get_IsInvariantCulture(){} // RVA: 0x7FFD539955F0
        public void get_CultureName(){} // RVA: 0x7FFD4E409500
        public void get_SCOMPAREINFO(){} // RVA: 0x7FFD53995610
        public void get_STEXTINFO(){} // RVA: 0x7FFD4E409500
        public void get_IsRightToLeft(){} // RVA: 0x7FFD4E7EFDF0
        public void get_SLIST(){} // RVA: 0x7FFD4E70F410
        public void get_UseUserOverride(){} // RVA: 0x7FFD4E36A020
        public void EraNames(){} // RVA: 0x7FFD53995650
        public void AbbrevEraNames(){} // RVA: 0x7FFD53995670
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7FFD53995690
        public void ShortDates(){} // RVA: 0x7FFD539956B0
        public void LongDates(){} // RVA: 0x7FFD539956D0
        public void YearMonths(){} // RVA: 0x7FFD539956F0
        public void DayNames(){} // RVA: 0x7FFD53995710
        public void AbbreviatedDayNames(){} // RVA: 0x7FFD53995730
        public void MonthNames(){} // RVA: 0x7FFD53995750
        public void GenitiveMonthNames(){} // RVA: 0x7FFD53995770
        public void AbbreviatedMonthNames(){} // RVA: 0x7FFD53995790
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7FFD539957B0
        public void LeapYearMonthNames(){} // RVA: 0x7FFD539957E0
        public void MonthDay(){} // RVA: 0x7FFD53995810
        public void DateSeparator(){} // RVA: 0x7FFD53995830
        public void GetDateSeparator(){} // RVA: 0x7FFD53995910
        public void GetSeparator(){} // RVA: 0x7FFD53995960
        public void IndexOfTimePart(){} // RVA: 0x7FFD53995B40
        public void UnescapeNlsString(){} // RVA: 0x7FFD53995C60
        public void ReescapeWin32Strings(){} // RVA: 0x7FFD4F9181E0
        public void ReescapeWin32String(){} // RVA: 0x7FFD4F9181E0
        public void strlen(){} // RVA: 0x7FFD53995E20
        public void idx2string(){} // RVA: 0x7FFD53995E40
        public void create_group_sizes_array(){} // RVA: 0x7FFD53995F70
        public void GetNFIValues(){} // RVA: 0x7FFD53996020
        public void fill_number_data(){} // RVA: 0x7FFD53996930
    }

    public class CultureInfo : Object
    {
        public 0.T_I8 _cultureData;
        public object _isInherited; // 0x8
        public 0.T_I8 InvariantCulture; // 0x10
        public bool CurrentCulture; // 0x10
        public int CurrentUICulture; // 0x14
        public int Territory; // 0x18
        public int _name; // 0x1C
        public int IetfLanguageTag; // 0x20
        public int LCID; // 0x24
        public bool Name; // 0x28
        public 0.d NativeName; // 0x30
        public 0.tOfUserTypes Calendar; // 0x38
        public 0.GetDeclaringTypeInternal Parent; // 0x40
        public string TextInfo; // 0x48
        public string ThreeLetterISOLanguageName; // 0x50
        public string TwoLetterISOLanguageName; // 0x58
        public string CompareInfo; // 0x60
        public string IsNeutralCulture; // 0x68
        public string NumberFormat; // 0x70
        public string DateTimeFormat; // 0x78
        public string[] DisplayName; // 0x80
        public 0.AManaged EnglishName; // 0x88
        public IntPtr InstalledUICulture; // 0x90
        public int IsReadOnly; // 0x98
        public 0.ÏÏÌÏÎÌÍÌÎÍÎÍÏÌÌÏÌÎÌÎÌ CalendarType; // 0xA0
        public 0.T_I8 DefaultThreadCurrentCulture; // 0xA8
        public bool DefaultThreadCurrentUICulture; // 0xB0
        public byte[] SortName; // 0xB8
        public 0.s UserDefaultUICulture; // 0xC0
        public bool UserDefaultCulture; // 0xC8
        public int HasInvariantCultureName;
        public int CalendarTypeBits;
        public int LOCALE_INVARIANT;
        public string MSG_READONLY;
        public 0.T_I8 s_DefaultThreadCurrentUICulture; // 0x18
        public 0.T_I8 s_DefaultThreadCurrentCulture; // 0x20
        public URA.DateTime<int,0.T_I8> shared_by_number; // 0x28
        public URA.DateTime<string,0.T_I8> shared_by_name; // 0x30
        public 0.T_I8 s_UserPreferredCultureInfoInAppX; // 0x38
        public bool IsTaiwanSku; // 0x40

        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x7FFD4E3AC120
        public void get__isInherited(){} // RVA: 0x7FFD4F14B010
        public void get_InvariantCulture(){} // RVA: 0x7FFD539A1EE0
        public void get_CurrentCulture(){} // RVA: 0x7FFD539A1F40
        public void get_CurrentUICulture(){} // RVA: 0x7FFD539A1F90
        public void set_CurrentUICulture(){} // RVA: 0x7FFD539A1FE0
        public void ConstructCurrentCulture(){} // RVA: 0x7FFD539A2010
        public void ConstructCurrentUICulture(){} // RVA: 0x7FFD539A2270
        public void get_Territory(){} // RVA: 0x7FFD4E505600
        public void get__name(){} // RVA: 0x7FFD4E3BC730
        public void get_IetfLanguageTag(){} // RVA: 0x7FFD539A22C0
        public void get_LCID(){} // RVA: 0x7FFD4E7F5A20
        public void get_Name(){} // RVA: 0x7FFD4E3BC730
        public void get_NativeName(){} // RVA: 0x7FFD539A2400
        public void get_Calendar(){} // RVA: 0x7FFD539A2470
        public void get_Parent(){} // RVA: 0x7FFD539A2540
        public void get_TextInfo(){} // RVA: 0x7FFD539A2820
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7FFD539A2A70
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7FFD539A2AE0
        public void Clone(){} // RVA: 0x7FFD539A2B50
        public void Equals(){} // RVA: 0x7FFD539A2DB0
        public void GetCultures(){} // RVA: 0x7FFD539A2E90
        public void GetTextInfoData(){} // RVA: 0x7FFD539A3290
        public void GetHashCode(){} // RVA: 0x7FFD4E7F5A20
        public void ReadOnly(){} // RVA: 0x7FFD539A32B0
        public void ToString(){} // RVA: 0x7FFD4E3BC730
        public void get_CompareInfo(){} // RVA: 0x7FFD539A3540
        public void get_IsNeutralCulture(){} // RVA: 0x7FFD539A3800
        public void CheckNeutral(){} // RVA: 0x7FFD4E341310
        public void get_NumberFormat(){} // RVA: 0x7FFD539A3840
        public void set_NumberFormat(){} // RVA: 0x7FFD539A3930
        public void get_DateTimeFormat(){} // RVA: 0x7FFD539A3AA0
        public void set_DateTimeFormat(){} // RVA: 0x7FFD539A3CB0
        public void get_DisplayName(){} // RVA: 0x7FFD539A3E20
        public void get_EnglishName(){} // RVA: 0x7FFD539A3E40
        public void get_InstalledUICulture(){} // RVA: 0x7FFD539A3EB0
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E40B5E0
        public void GetFormat(){} // RVA: 0x7FFD539A3F00
        public void Construct(){} // RVA: 0x7FFD539A4050
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7FFD539A40B0
        public void construct_internal_locale_from_name(){} // RVA: 0x7FFD539A4110
        public void get_current_locale_name(){} // RVA: 0x7FFD539A42A0
        public void internal_get_cultures(){} // RVA: 0x7FFD539A4320
        public void ConstructInvariant(){} // RVA: 0x7FFD539A4330
        public void CreateTextInfo(){} // RVA: 0x7FFD539A48B0
        public void .ctor(){} // RVA: 0x7FFD4E7B81D0 | overloaded x7
        public void insert_into_shared_tables(){} // RVA: 0x7FFD539A50F0
        public void GetCultureInfo(){} // RVA: 0x7FFD539A5A10 | overloaded x3
        public void CreateCulture(){} // RVA: 0x7FFD539A5B10
        public void CreateSpecificCulture(){} // RVA: 0x7FFD539A5BA0
        public void ConstructLocaleFromName(){} // RVA: 0x7FFD539A5F00
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7FFD539A5FB0
        public void get_CalendarType(){} // RVA: 0x7FFD539A91F0
        public void CreateCalendar(){} // RVA: 0x7FFD539A9290
        public void CreateNotFoundException(){} // RVA: 0x7FFD539A94B0
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7FFD539A9560
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7FFD539A95C0
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFD539A9680
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFD539A96E0
        public void get_SortName(){} // RVA: 0x7FFD4E3BC730
        public void get_UserDefaultUICulture(){} // RVA: 0x7FFD539A97A0
        public void get_UserDefaultCulture(){} // RVA: 0x7FFD539A9820
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFD538FA580
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFD4E341310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7FFD539A9870
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFD539A9A00
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFD539A9B00
        public void get_HasInvariantCultureName(){} // RVA: 0x7FFD539A9C70
        public void VerifyCultureName(){} // RVA: 0x7FFD539A9EF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD539A9F90
    }

    public class DateTimeFormatInfo : Object
    {
        public object CultureName;
        public object Culture;
        public object LanguageName;
        public object InvariantInfo;
        public object CurrentInfo;
        public object AMDesignator;
        public object Calendar;
        public object OptionalCalendars;
        public object EraNames;
        public object AbbreviatedEraNames;
        public object AbbreviatedEnglishEraNames;
        public object DateSeparator;
        public object FullDateTimePattern;
        public object LongDatePattern;
        public object LongTimePattern;
        public object MonthDayPattern;
        public object PMDesignator;
        public object RFC1123Pattern;
        public object ShortDatePattern;
        public object ShortTimePattern;
        public object SortableDateTimePattern;
        public object GeneralShortTimePattern;
        public object GeneralLongTimePattern;
        public object DateTimeOffsetPattern;
        public object TimeSeparator;
        public object UniversalSortableDateTimePattern;
        public object YearMonthPattern;
        public object AbbreviatedDayNames;
        public object DayNames;
        public object AbbreviatedMonthNames;
        public object MonthNames;
        public object HasSpacesInMonthNames;
        public object HasSpacesInDayNames;
        public object AllYearMonthPatterns;
        public object AllShortDatePatterns;
        public object AllShortTimePatterns;
        public object AllLongDatePatterns;
        public object AllLongTimePatterns;
        public object UnclonedYearMonthPatterns;
        public object UnclonedShortDatePatterns;
        public object UnclonedLongDatePatterns;
        public object UnclonedShortTimePatterns;
        public object UnclonedLongTimePatterns;
        public object IsReadOnly;
        public object MonthGenitiveNames;
        public object FullTimeSpanPositivePattern;
        public object FullTimeSpanNegativePattern;
        public object CompareInfo;
        public object FormatFlags;
        public object HasForceTwoDigitYears;
        public object HasYearMonthAdjustment;

        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x7FFD5396A2A0
        public void get_Culture(){} // RVA: 0x7FFD5396A310
        public void get_LanguageName(){} // RVA: 0x7FFD5396A3D0
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7FFD5396A440
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7FFD5396A460
        public void internalGetDayOfWeekNames(){} // RVA: 0x7FFD5396A520
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7FFD5396A540
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7FFD5396A600
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7FFD5396A620
        public void internalGetMonthNames(){} // RVA: 0x7FFD5396A6E0
        public void internalGetMonthNamesCore(){} // RVA: 0x7FFD5396A700
        public void .ctor(){} // RVA: 0x7FFD5396A990 | overloaded x2
        public void InitializeOverridableProperties(){} // RVA: 0x7FFD5396AA00
        public void get_InvariantInfo(){} // RVA: 0x7FFD5396AE80
        public void get_CurrentInfo(){} // RVA: 0x7FFD5396AFD0
        public void GetInstance(){} // RVA: 0x7FFD5396B120
        public void GetFormat(){} // RVA: 0x7FFD5396B2B0
        public void Clone(){} // RVA: 0x7FFD5396B390
        public void get_AMDesignator(){} // RVA: 0x7FFD5396B510
        public void get_Calendar(){} // RVA: 0x7FFD4E505600
        public void set_Calendar(){} // RVA: 0x7FFD5396B580
        public void get_OptionalCalendars(){} // RVA: 0x7FFD5396BA20
        public void get_EraNames(){} // RVA: 0x7FFD5396BB90
        public void GetEraName(){} // RVA: 0x7FFD5396BC60
        public void get_AbbreviatedEraNames(){} // RVA: 0x7FFD5396BE00
        public void GetAbbreviatedEraName(){} // RVA: 0x7FFD5396BED0
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7FFD5396C090
        public void get_DateSeparator(){} // RVA: 0x7FFD5396C160
        public void get_FullDateTimePattern(){} // RVA: 0x7FFD5396C210
        public void get_LongDatePattern(){} // RVA: 0x7FFD5396C2E0
        public void get_LongTimePattern(){} // RVA: 0x7FFD5396C380
        public void get_MonthDayPattern(){} // RVA: 0x7FFD5396C420
        public void get_PMDesignator(){} // RVA: 0x7FFD5396C4E0
        public void get_RFC1123Pattern(){} // RVA: 0x7FFD5396C550
        public void get_ShortDatePattern(){} // RVA: 0x7FFD5396C590
        public void get_ShortTimePattern(){} // RVA: 0x7FFD5396C630
        public void get_SortableDateTimePattern(){} // RVA: 0x7FFD5396C6D0
        public void get_GeneralShortTimePattern(){} // RVA: 0x7FFD5396C710
        public void get_GeneralLongTimePattern(){} // RVA: 0x7FFD5396C7D0
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7FFD5396C890
        public void get_TimeSeparator(){} // RVA: 0x7FFD5396CAB0
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7FFD5396CB20
        public void get_YearMonthPattern(){} // RVA: 0x7FFD5396CB60
        public void get_AbbreviatedDayNames(){} // RVA: 0x7FFD5396CC00
        public void get_DayNames(){} // RVA: 0x7FFD5396CC90
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7FFD5396CD20
        public void get_MonthNames(){} // RVA: 0x7FFD5396CDB0
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7FFD5396CE40
        public void get_HasSpacesInDayNames(){} // RVA: 0x7FFD5396CE70
        public void internalGetMonthName(){} // RVA: 0x7FFD5396CEA0
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7FFD5396D000
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7FFD5396D1B0
        public void GetAbbreviatedDayName(){} // RVA: 0x7FFD5396D280
        public void GetCombinedPatterns(){} // RVA: 0x7FFD5396D390
        public void GetAllDateTimePatterns(){} // RVA: 0x7FFD5396D4A0
        public void GetDayName(){} // RVA: 0x7FFD5396D950
        public void GetAbbreviatedMonthName(){} // RVA: 0x7FFD5396DA60
        public void GetMonthName(){} // RVA: 0x7FFD5396DB70
        public void GetMergedPatterns(){} // RVA: 0x7FFD5396DC80
        public void get_AllYearMonthPatterns(){} // RVA: 0x7FFD5396DE80
        public void get_AllShortDatePatterns(){} // RVA: 0x7FFD5396DF00
        public void get_AllShortTimePatterns(){} // RVA: 0x7FFD5396DF80
        public void get_AllLongDatePatterns(){} // RVA: 0x7FFD5396E000
        public void get_AllLongTimePatterns(){} // RVA: 0x7FFD5396E080
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7FFD5396E100
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7FFD5396E1D0
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7FFD5396E2A0
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7FFD5396E370
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7FFD5396E400
        public void ReadOnly(){} // RVA: 0x7FFD5396E490
        public void get_IsReadOnly(){} // RVA: 0x7FFD5396E6B0
        public void get_MonthGenitiveNames(){} // RVA: 0x7FFD5396E750
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7FFD5396E7E0
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7FFD5396E920
        public void get_CompareInfo(){} // RVA: 0x7FFD5396E9D0
        public void ValidateStyles(){} // RVA: 0x7FFD5396EB60
        public void get_FormatFlags(){} // RVA: 0x7FFD5396EC90
        public void InitializeFormatFlags(){} // RVA: 0x7FFD5396ECB0
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7FFD5396EF00
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7FFD5396EF40
        public void YearMonthAdjustment(){} // RVA: 0x7FFD5396EF70
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7FFD5396F0B0
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7FFD5396F290
        public void ClearTokenHashTable(){} // RVA: 0x7FFD5396F470
        public void CreateTokenHashTable(){} // RVA: 0x7FFD5396F4F0
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7FFD53970120
        public void IsJapaneseCalendar(){} // RVA: 0x7FFD53970F00
        public void AddMonthNames(){} // RVA: 0x7FFD53971040
        public void TryParseHebrewNumber(){} // RVA: 0x7FFD53971110
        public void IsHebrewChar(){} // RVA: 0x7FFD53971310
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7FFD53971330
        public void Tokenize(){} // RVA: 0x7FFD53971480
        public void InsertAtCurrentHashNode(){} // RVA: 0x7FFD53971BA0
        public void InsertHash(){} // RVA: 0x7FFD53971DE0
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7FFD539721E0
        public void .cctor(){} // RVA: 0x7FFD53972310
    }

    public class GlobalizationMode : Object
    {
        public object Invariant;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFD5397FE40
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7FFD4E341320
        public void .cctor(){} // RVA: 0x7FFD5397FEA0
    }

    public class GregorianCalendar : Calendar
    {
        public object MinSupportedDateTime;
        public object MaxSupportedDateTime;
        public object AlgorithmType;
        public object ID;
        public object Eras;
        public object TwoDigitYearMax;

        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFD53984870
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFD53984960
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFD539849C0
        public void get_AlgorithmType(){} // RVA: 0x7FFD4E433AF0
        public void GetDefaultInstance(){} // RVA: 0x7FFD53984A20
        public void .ctor(){} // RVA: 0x7FFD53984B70 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFD4E4FBBE0
        public void GetDatePart(){} // RVA: 0x7FFD53984CC0
        public void GetAbsoluteDate(){} // RVA: 0x7FFD53984E90
        public void DateToTicks(){} // RVA: 0x7FFD53985090
        public void AddMonths(){} // RVA: 0x7FFD53985110
        public void AddYears(){} // RVA: 0x7FFD53985630
        public void GetDayOfMonth(){} // RVA: 0x7FFD53985650
        public void GetDayOfWeek(){} // RVA: 0x7FFD53985700
        public void GetDayOfYear(){} // RVA: 0x7FFD539857C0
        public void GetDaysInMonth(){} // RVA: 0x7FFD53985870
        public void GetDaysInYear(){} // RVA: 0x7FFD53985B90
        public void GetEra(){} // RVA: 0x7FFD4E433AF0
        public void get_Eras(){} // RVA: 0x7FFD53985D70
        public void GetMonth(){} // RVA: 0x7FFD53985DD0
        public void GetMonthsInYear(){} // RVA: 0x7FFD53985E80
        public void GetYear(){} // RVA: 0x7FFD53986010
        public void IsLeapDay(){} // RVA: 0x7FFD539860C0
        public void GetLeapMonth(){} // RVA: 0x7FFD53986510
        public void IsLeapMonth(){} // RVA: 0x7FFD53986690
        public void IsLeapYear(){} // RVA: 0x7FFD53986930
        public void ToDateTime(){} // RVA: 0x7FFD53986B00
        public void TryToDateTime(){} // RVA: 0x7FFD53986BE0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFD53986CE0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFD53986D60
        public void ToFourDigitYear(){} // RVA: 0x7FFD53986E80
        public void .cctor(){} // RVA: 0x7FFD53987000
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x7FFD4E089DD0
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x7FFD4E07D3D0
        public void IsSuffix(){} // RVA: 0x7FFD4E07D3D0
        public void IndexOf(){}
        public void LastIndexOf(){}
    }

    public class NumberFormatInfo : Object
    {
        public object InvariantInfo;
        public object CurrencyDecimalDigits;
        public object CurrencyDecimalSeparator;
        public object IsReadOnly;
        public object CurrencyGroupSizes;
        public object NumberGroupSizes;
        public object PercentGroupSizes;
        public object CurrencyGroupSeparator;
        public object CurrencySymbol;
        public object CurrentInfo;
        public object NaNSymbol;
        public object CurrencyNegativePattern;
        public object NumberNegativePattern;
        public object PercentPositivePattern;
        public object PercentNegativePattern;
        public object NegativeInfinitySymbol;
        public object NegativeSign;
        public object NumberDecimalDigits;
        public object NumberDecimalSeparator;
        public object NumberGroupSeparator;
        public object CurrencyPositivePattern;
        public object PositiveInfinitySymbol;
        public object PositiveSign;
        public object PercentDecimalDigits;
        public object PercentDecimalSeparator;
        public object PercentGroupSeparator;
        public object PercentSymbol;
        public object PerMilleSymbol;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5398D240 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFD5398D0D0
        public void OnDeserializing(){} // RVA: 0x7FFD4E341310
        public void OnDeserialized(){} // RVA: 0x7FFD4E341310
        public void VerifyWritable(){} // RVA: 0x7FFD5398DCE0
        public void get_InvariantInfo(){} // RVA: 0x7FFD5398DD60
        public void GetInstance(){} // RVA: 0x7FFD5398DED0
        public void Clone(){} // RVA: 0x7FFD5398E060
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7FFD500181F0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7FFD4E3E20E0
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E7EFDE0
        public void get_CurrencyGroupSizes(){} // RVA: 0x7FFD5398E0D0
        public void get_NumberGroupSizes(){} // RVA: 0x7FFD5398E150
        public void get_PercentGroupSizes(){} // RVA: 0x7FFD5398E1D0
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7FFD4E3BC730
        public void get_CurrencySymbol(){} // RVA: 0x7FFD4E409500
        public void get_CurrentInfo(){} // RVA: 0x7FFD5398E250
        public void get_NaNSymbol(){} // RVA: 0x7FFD4E3BCD50
        public void set_NaNSymbol(){} // RVA: 0x7FFD5398E380
        public void get_CurrencyNegativePattern(){} // RVA: 0x7FFD4F73B350
        public void get_NumberNegativePattern(){} // RVA: 0x7FFD4EBCB780
        public void get_PercentPositivePattern(){} // RVA: 0x7FFD4E55B720
        public void get_PercentNegativePattern(){} // RVA: 0x7FFD4FBF3250
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7FFD4E505600
        public void get_NegativeSign(){} // RVA: 0x7FFD4E5F95E0
        public void get_NumberDecimalDigits(){} // RVA: 0x7FFD51959490
        public void get_NumberDecimalSeparator(){} // RVA: 0x7FFD4E5F0140
        public void get_NumberGroupSeparator(){} // RVA: 0x7FFD4E3BE740
        public void get_CurrencyPositivePattern(){} // RVA: 0x7FFD51B35300
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7FFD4E409590
        public void get_PositiveSign(){} // RVA: 0x7FFD4E36F130
        public void get_PercentDecimalDigits(){} // RVA: 0x7FFD4EA61480
        public void get_PercentDecimalSeparator(){} // RVA: 0x7FFD4E70F410
        public void get_PercentGroupSeparator(){} // RVA: 0x7FFD4E380010
        public void get_PercentSymbol(){} // RVA: 0x7FFD4E70F640
        public void get_PerMilleSymbol(){} // RVA: 0x7FFD4E96DFB0
        public void GetFormat(){} // RVA: 0x7FFD5398E4B0
        public void ReadOnly(){} // RVA: 0x7FFD5398E590
        public void ValidateParseStyleInteger(){} // RVA: 0x7FFD5398E660
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7FFD5398E750
    }

    public class SortKey : Object
    {
        public string OriginalString; // 0x10
        public byte[] KeyData; // 0x18
        public 0.gManifestResourceException options; // 0x20
        public int lcid; // 0x24

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD53994020
        public void .ctor(){} // RVA: 0x7FFD53994710 | overloaded x4
        public void get_OriginalString(){} // RVA: 0x7FFD4E35C380
        public void get_KeyData(){} // RVA: 0x7FFD4E3447C0
        public void Equals(){} // RVA: 0x7FFD539944B0
        public void GetHashCode(){} // RVA: 0x7FFD53994560
        public void ToString(){} // RVA: 0x7FFD539945D0
    }

    public class SortVersion : Object
    {
    }

    public class TextInfo : Object
    {
        public object Invariant;
        public object CultureName;
        public object IsReadOnly;
        public object ListSeparator;
        public object IsAsciiCasingSameAsInvariant;
        public object IsRightToLeft;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFD5398F0C0
        public void .ctor(){} // RVA: 0x7FFD539914B0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFD5398F2F0
        public void OnDeserialized(){} // RVA: 0x7FFD5398F560 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFD5398F570
        public void get_CultureName(){} // RVA: 0x7FFD4E5F95E0
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E35C4E0
        public void Clone(){} // RVA: 0x7FFD5398F650
        public void ReadOnly(){} // RVA: 0x7FFD5398F6D0
        public void SetReadOnlyState(){} // RVA: 0x7FFD4E35C4F0
        public void get_ListSeparator(){} // RVA: 0x7FFD5398F7C0
        public void ToLower(){} // RVA: 0x7FFD5398F8A0 | overloaded x2
        public void ToLowerAsciiInvariant(){} // RVA: 0x7FFD5398F9D0
        public void ToUpper(){} // RVA: 0x7FFD5398FA50 | overloaded x2
        public void ToUpperAsciiInvariant(){} // RVA: 0x7FFD539912D0 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFD5398FBA0
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7FFD5398FBB0
        public void Equals(){} // RVA: 0x7FFD5398FD00
        public void GetHashCode(){} // RVA: 0x7FFD5398FDE0
        public void ToString(){} // RVA: 0x7FFD5398FE10
        public void ToTitleCase(){} // RVA: 0x7FFD5398FE70
        public void AddNonLetter(){} // RVA: 0x7FFD53990340
        public void AddTitlecaseLetter(){} // RVA: 0x7FFD53990400
        public void IsWordSeparator(){} // RVA: 0x7FFD53990620
        public void IsLetterCategory(){} // RVA: 0x7FFD53990630
        public void get_IsRightToLeft(){} // RVA: 0x7FFD53990640
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD5398F560
        public void ToUpperInternal(){} // RVA: 0x7FFD53990820 | overloaded x2
        public void ToLowerInternal(){} // RVA: 0x7FFD53990DF0 | overloaded x2
        public void ChangeCase(){} // RVA: 0x7FFD53991380
    }

    public class TextInfoToUpperData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD539A1380
    }

}