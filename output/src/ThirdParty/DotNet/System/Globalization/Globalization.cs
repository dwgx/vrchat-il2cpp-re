// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 40
// Methods: 822

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring : Object
    {
        public char delimiter; // 0x10
        public int base_num; // 0x14
        public int tmin; // 0x18
        public int tmax; // 0x1C
        public int skew; // 0x20
        public int damp; // 0x24
        public int initial_bias; // 0x28
        public int initial_n; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858BD50
        public void Encode(){} // RVA: 0x7FFAC858BD80
        public void EncodeDigit(){} // RVA: 0x7FFAC858C240
        public void DecodeDigit(){} // RVA: 0x7FFAC858C260
        public void Adapt(){} // RVA: 0x7FFAC858C290
        public void Decode(){} // RVA: 0x7FFAC858C310
    }

    public class Calendar : Object
    {
        public long MinSupportedDateTime;
        public long MaxSupportedDateTime;
        public long ID;
        public long BaseCalendarID;
        public long AlgorithmType;
        public int IsReadOnly;
        public int CurrentEraValue;
        public int Eras;
        public int DaysInYearBeforeMinSupportedYear;
        public int TwoDigitYearMax;
        public int DaysPer4Years;
        public int DaysPer100Years;
        public int DaysPer400Years;
        public int DaysTo10000;
        public long MaxMillis;
        public int CAL_GREGORIAN;
        public int CAL_GREGORIAN_US;
        public int CAL_JAPAN;
        public int CAL_TAIWAN;
        public int CAL_KOREA;
        public int CAL_HIJRI;
        public int CAL_THAI;
        public int CAL_HEBREW;
        public int CAL_GREGORIAN_ME_FRENCH;
        public int CAL_GREGORIAN_ARABIC;
        public int CAL_GREGORIAN_XLIT_ENGLISH;
        public int CAL_GREGORIAN_XLIT_FRENCH;
        public int CAL_JULIAN;
        public int CAL_JAPANESELUNISOLAR;
        public int CAL_CHINESELUNISOLAR;
        public int CAL_SAKA;
        public int CAL_LUNAR_ETO_CHN;
        public int CAL_LUNAR_ETO_KOR;
        public int CAL_LUNAR_ETO_ROKUYOU;
        public int CAL_KOREANLUNISOLAR;
        public int CAL_TAIWANLUNISOLAR;
        public int CAL_PERSIAN;
        public int CAL_UMALQURA;
        public int m_currentEraValue; // 0x10
        public bool m_isReadOnly; // 0x14
        public int CurrentEra;
        public int twoDigitYearMax; // 0x18

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC855FEE0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC855FF40
        public void .ctor(){} // RVA: 0x7FFAC855FFA0
        public void get_ID(){} // RVA: 0x7FFAC32BD0E0
        public void get_BaseCalendarID(){} // RVA: 0x7FFAC47CB300
        public void get_AlgorithmType(){} // RVA: 0x7FFAC34F9180
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3070BD0
        public void Clone(){} // RVA: 0x7FFAC855FFB0
        public void ReadOnly(){} // RVA: 0x7FFAC8560030
        public void VerifyWritable(){} // RVA: 0x7FFAC8560120
        public void SetReadOnlyState(){} // RVA: 0x7FFAC3070BE0
        public void get_CurrentEraValue(){} // RVA: 0x7FFAC85601A0
        public void CheckAddResult(){} // RVA: 0x7FFAC8560230
        public void AddMonths(){}
        public void AddYears(){}
        public void GetDayOfMonth(){}
        public void GetDayOfWeek(){}
        public void GetDayOfYear(){}
        public void GetDaysInMonth(){} // RVA: 0x7FFAC8560410 | overloaded x2
        public void GetDaysInYear(){} // RVA: 0x7FFAC2C60290
        public void GetEra(){}
        public void get_Eras(){} // RVA: 0x7FFAC2C58E90
        public void GetMonth(){}
        public void GetMonthsInYear(){} // RVA: 0x7FFAC2C60290
        public void GetFirstDayWeekOfYear(){} // RVA: 0x7FFAC8560440
        public void GetWeekOfYearFullDays(){} // RVA: 0x7FFAC8560500
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x7FFAC8560740
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAC85608B0
        public void GetWeekOfYear(){} // RVA: 0x7FFAC85608C0
        public void GetYear(){}
        public void IsLeapDay(){}
        public void IsLeapMonth(){}
        public void GetLeapMonth(){} // RVA: 0x7FFAC8560BF0
        public void IsLeapYear(){} // RVA: 0x7FFAC8560CB0 | overloaded x2
        public void ToDateTime(){} // RVA: 0x7FFAC8560CD0 | overloaded x2
        public void TryToDateTime(){} // RVA: 0x7FFAC8560D30
        public void IsValidYear(){} // RVA: 0x7FFAC8560E30
        public void IsValidMonth(){} // RVA: 0x7FFAC8560EC0
        public void IsValidDay(){} // RVA: 0x7FFAC8560F40
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC3157800
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC8560FD0
        public void ToFourDigitYear(){} // RVA: 0x7FFAC8561000
        public void TimeToTicks(){} // RVA: 0x7FFAC8561110
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x7FFAC85612F0
    }

    public class CalendarData : Object
    {
        public int MAX_CALENDARS;
        public string sNativeName; // 0x10
        public string[] saShortDates; // 0x18
        public string[] saYearMonths; // 0x20
        public string[] saLongDates; // 0x28
        public string sMonthDay; // 0x30
        public string[] saEraNames; // 0x38
        public string[] saAbbrevEraNames; // 0x40
        public string[] saAbbrevEnglishEraNames; // 0x48
        public string[] saDayNames; // 0x50
        public string[] saAbbrevDayNames; // 0x58
        public string[] saSuperShortDayNames; // 0x60
        public string[] saMonthNames; // 0x68
        public string[] saAbbrevMonthNames; // 0x70
        public string[] saMonthGenitiveNames; // 0x78
        public string[] saAbbrevMonthGenitiveNames; // 0x80
        public string[] saLeapYearMonthNames; // 0x88
        public int iTwoDigitYearMax; // 0x90
        public int iCurrentEra; // 0x94
        public bool bUseUserOverrides; // 0x98
        public System.Globalization.CalendarData Invariant;
        public string[] HEBREW_MONTH_NAMES; // 0x8
        public string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8562690 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8561350
        public void InitializeEraNames(){} // RVA: 0x7FFAC8563530
        public void GetJapaneseEraNames(){} // RVA: 0x7FFAC8563A40
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x7FFAC8563C60
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x7FFAC8563E80
        public void GetCalendarData(){} // RVA: 0x7FFAC85642C0
        public void CalendarIdToCultureName(){} // RVA: 0x7FFAC85644F0
        public void nativeGetTwoDigitYearMax(){} // RVA: 0x7FFAC32BD0E0
        public void nativeGetCalendarData(){} // RVA: 0x7FFAC85646C0
        public void fill_calendar_data(){} // RVA: 0x7FFAC8564860
    }

    public class CharUnicodeInfo : Object
    {
        public object CategoryLevel1Index;
        public object CategoryLevel2Index;
        public object CategoryLevel3Index;
        public object CategoriesValue;
        public object NumericLevel1Index;
        public object NumericLevel2Index;
        public object NumericLevel3Index;
        public object NumericValues;

        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x7FFAC8542B90 | overloaded x2
        public void InternalGetNumericValue(){} // RVA: 0x7FFAC8542C40
        public void GetNumericValue(){} // RVA: 0x7FFAC8542E20 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFAC8543050 | overloaded x3
        public void InternalGetCategoryValue(){} // RVA: 0x7FFAC85431D0
        public void InternalGetUnicodeCategory(){} // RVA: 0x7FFAC8543400 | overloaded x2
        public void IsWhiteSpace(){} // RVA: 0x7FFAC8543580 | overloaded x2
        public void get_CategoryLevel1Index(){} // RVA: 0x7FFAC85435A0
        public void get_CategoryLevel2Index(){} // RVA: 0x7FFAC8543600
        public void get_CategoryLevel3Index(){} // RVA: 0x7FFAC8543660
        public void get_CategoriesValue(){} // RVA: 0x7FFAC85436C0
        public void get_NumericLevel1Index(){} // RVA: 0x7FFAC8543720
        public void get_NumericLevel2Index(){} // RVA: 0x7FFAC8543780
        public void get_NumericLevel3Index(){} // RVA: 0x7FFAC85437E0
        public void get_NumericValues(){} // RVA: 0x7FFAC8543840
    }

    public class CodePageDataItem : Object
    {
        public int WebName; // 0x10
        public int HeaderName; // 0x14
        public string BodyName; // 0x18
        public string m_headerName; // 0x20
        public string m_bodyName; // 0x28
        public uint m_flags; // 0x30
        public char[] sep;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85769F0
        public void CreateString(){} // RVA: 0x7FFAC8576AB0
        public void get_WebName(){} // RVA: 0x7FFAC8576C00
        public void get_HeaderName(){} // RVA: 0x7FFAC8576D20
        public void get_BodyName(){} // RVA: 0x7FFAC8576E50
        public void .cctor(){} // RVA: 0x7FFAC8576F80
    }

    public class CompareInfo : Object
    {
        public 0x6B0DB010 Name;
        public 0x6B0DB010 UseManagedCollation;
        public 0x6B0DB010 ValidHashCodeOfStringMaskOffFlags;
        public 0x6B0DB010 ValidSortkeyCtorMaskOffFlags;
        public System.Globalization.CompareInfo Invariant;
        public string m_name; // 0x10
        public string _sortName; // 0x18
        public System.Globalization.SortVersion m_SortVersion; // 0x20
        public int culture; // 0x28
        public System.Globalization.ISimpleCollator collator; // 0x30
        public System.Collections.Generic.Dictionary`2<string,System.Globalization.ISimpleCollator> collators; // 0x8
        public bool managedCollation; // 0x10
        public bool managedCollationChecked; // 0x11

        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x7FFAC85438A0
        public void InvariantLastIndexOf(){} // RVA: 0x7FFAC8543970
        public void InvariantFindString(){} // RVA: 0x7FFAC8543A50
        public void InvariantToUpper(){} // RVA: 0x7FFAC8543E50
        public void InvariantCreateSortKey(){} // RVA: 0x7FFAC8543E70
        public void .ctor(){} // RVA: 0x7FFAC8549800 | overloaded x2
        public void GetCompareInfo(){} // RVA: 0x7FFAC8544230
        public void OnDeserializing(){} // RVA: 0x7FFAC7DDDC00
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC85442F0
        public void OnDeserialized(){} // RVA: 0x7FFAC8544300 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAC8544450
        public void get_Name(){} // RVA: 0x7FFAC85444F0
        public void Compare(){} // RVA: 0x7FFAC8545040 | overloaded x4
        public void CompareOptionNone(){} // RVA: 0x7FFAC8544DB0
        public void CompareOptionIgnoreCase(){} // RVA: 0x7FFAC8544F10
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x7FFAC8545780 | overloaded x2
        public void IsPrefix(){} // RVA: 0x7FFAC8545C40 | overloaded x2
        public void IsSuffix(){} // RVA: 0x7FFAC8545FC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC85469D0 | overloaded x5
        public void IndexOfOrdinal(){} // RVA: 0x7FFAC8546B30
        public void LastIndexOf(){} // RVA: 0x7FFAC8546D80 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFAC8547160
        public void GetSortKey(){} // RVA: 0x7FFAC8547330
        public void Equals(){} // RVA: 0x7FFAC85474B0
        public void GetHashCode(){} // RVA: 0x7FFAC8547B80 | overloaded x2
        public void GetIgnoreCaseHash(){} // RVA: 0x7FFAC8547600
        public void GetHashCodeOfString(){} // RVA: 0x7FFAC85479B0
        public void ToString(){} // RVA: 0x7FFAC8547C90
        public void get_UseManagedCollation(){} // RVA: 0x7FFAC8547CF0
        public void GetCollator(){} // RVA: 0x7FFAC8547E60
        public void CreateSortKeyCore(){} // RVA: 0x7FFAC85482E0
        public void internal_index_switch(){} // RVA: 0x7FFAC8548580
        public void internal_compare_switch(){} // RVA: 0x7FFAC8548800
        public void internal_compare_managed(){} // RVA: 0x7FFAC8548A00
        public void internal_index_managed(){} // RVA: 0x7FFAC8548B00
        public void internal_compare_icall(){} // RVA: 0x7FFAC8548BB0
        public void internal_compare(){} // RVA: 0x7FFAC8548BC0
        public void internal_index_icall(){} // RVA: 0x7FFAC8548C70
        public void internal_index(){} // RVA: 0x7FFAC8548D60
        public void InitSort(){} // RVA: 0x7FFAC8548EA0
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x7FFAC8548F10
        public void IndexOfOrdinalCore(){} // RVA: 0x7FFAC85490D0
        public void LastIndexOfOrdinalCore(){} // RVA: 0x7FFAC8549110
        public void LastIndexOfCore(){} // RVA: 0x7FFAC8549150
        public void IndexOfCore(){} // RVA: 0x7FFAC8549190
        public void CompareString(){} // RVA: 0x7FFAC8549290 | overloaded x2
        public void CreateSortKey(){} // RVA: 0x7FFAC85493A0
        public void StartsWith(){} // RVA: 0x7FFAC8545C40 | overloaded x2
        public void EndsWith(){} // RVA: 0x7FFAC8545FC0 | overloaded x2
        public void GetHashCodeOfStringCore(){} // RVA: 0x7FFAC85496A0
        public void .cctor(){} // RVA: 0x7FFAC85496E0
    }

    public class CultureData : Object
    {
        public string Invariant; // 0x10
        public string LongTimes; // 0x18
        public string ShortTimes; // 0x20
        public string[] SISO639LANGNAME; // 0x28
        public string[] IFIRSTDAYOFWEEK; // 0x30
        public int IFIRSTWEEKOFYEAR; // 0x38
        public int SAM1159; // 0x3C
        public int[] SPM2359; // 0x40
        public System.Globalization.CalendarData[] TimeSeparator; // 0x48
        public string CalendarIds; // 0x50
        public string IsInvariantCulture; // 0x58
        public bool CultureName; // 0x60
        public int SCOMPAREINFO; // 0x64
        public int STEXTINFO; // 0x68
        public int IsRightToLeft; // 0x6C
        public int SLIST; // 0x70
        public int UseUserOverride; // 0x74
        public int iDefaultEbcdicCodePage; // 0x78
        public bool isRightToLeft; // 0x7C
        public string sListSeparator; // 0x80
        public System.Globalization.CultureData s_Invariant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FE9510
        public void get_Invariant(){} // RVA: 0x7FFAC8574740
        public void GetCultureData(){} // RVA: 0x7FFAC8574EF0 | overloaded x2
        public void fill_culture_data(){} // RVA: 0x7FFAC85750E0
        public void GetCalendar(){} // RVA: 0x7FFAC85750F0
        public void get_LongTimes(){} // RVA: 0x7FFAC6995200
        public void get_ShortTimes(){} // RVA: 0x7FFAC8575260
        public void get_SISO639LANGNAME(){} // RVA: 0x7FFAC2FC20E0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x7FFAC358A870
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x7FFAC33BD4A0
        public void get_SAM1159(){} // RVA: 0x7FFAC2F3C380
        public void get_SPM2359(){} // RVA: 0x7FFAC2F247C0
        public void get_TimeSeparator(){} // RVA: 0x7FFAC2F4F0C0
        public void get_CalendarIds(){} // RVA: 0x7FFAC8575270
        public void GetCalendarIds(){} // RVA: 0x7FFAC8575510
        public void get_IsInvariantCulture(){} // RVA: 0x7FFAC85755F0
        public void get_CultureName(){} // RVA: 0x7FFAC2FE9500
        public void get_SCOMPAREINFO(){} // RVA: 0x7FFAC8575610
        public void get_STEXTINFO(){} // RVA: 0x7FFAC2FE9500
        public void get_IsRightToLeft(){} // RVA: 0x7FFAC33CFDF0
        public void get_SLIST(){} // RVA: 0x7FFAC32EF410
        public void get_UseUserOverride(){} // RVA: 0x7FFAC2F4A020
        public void EraNames(){} // RVA: 0x7FFAC8575650
        public void AbbrevEraNames(){} // RVA: 0x7FFAC8575670
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x7FFAC8575690
        public void ShortDates(){} // RVA: 0x7FFAC85756B0
        public void LongDates(){} // RVA: 0x7FFAC85756D0
        public void YearMonths(){} // RVA: 0x7FFAC85756F0
        public void DayNames(){} // RVA: 0x7FFAC8575710
        public void AbbreviatedDayNames(){} // RVA: 0x7FFAC8575730
        public void MonthNames(){} // RVA: 0x7FFAC8575750
        public void GenitiveMonthNames(){} // RVA: 0x7FFAC8575770
        public void AbbreviatedMonthNames(){} // RVA: 0x7FFAC8575790
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x7FFAC85757B0
        public void LeapYearMonthNames(){} // RVA: 0x7FFAC85757E0
        public void MonthDay(){} // RVA: 0x7FFAC8575810
        public void DateSeparator(){} // RVA: 0x7FFAC8575830
        public void GetDateSeparator(){} // RVA: 0x7FFAC8575910
        public void GetSeparator(){} // RVA: 0x7FFAC8575960
        public void IndexOfTimePart(){} // RVA: 0x7FFAC8575B40
        public void UnescapeNlsString(){} // RVA: 0x7FFAC8575C60
        public void ReescapeWin32Strings(){} // RVA: 0x7FFAC44F81E0
        public void ReescapeWin32String(){} // RVA: 0x7FFAC44F81E0
        public void strlen(){} // RVA: 0x7FFAC8575E20
        public void idx2string(){} // RVA: 0x7FFAC8575E40
        public void create_group_sizes_array(){} // RVA: 0x7FFAC8575F70
        public void GetNFIValues(){} // RVA: 0x7FFAC8576020
        public void fill_number_data(){} // RVA: 0x7FFAC8576930
    }

    public class CultureInfo : Object
    {
        public System.Globalization.CultureInfo _cultureData;
        public object _isInherited; // 0x8
        public System.Globalization.CultureInfo InvariantCulture; // 0x10
        public bool CurrentCulture; // 0x10
        public int CurrentUICulture; // 0x14
        public int Territory; // 0x18
        public int _name; // 0x1C
        public int IetfLanguageTag; // 0x20
        public int LCID; // 0x24
        public bool Name; // 0x28
        public System.Globalization.NumberFormatInfo NativeName; // 0x30
        public System.Globalization.DateTimeFormatInfo Calendar; // 0x38
        public System.Globalization.TextInfo Parent; // 0x40
        public string TextInfo; // 0x48
        public string ThreeLetterISOLanguageName; // 0x50
        public string TwoLetterISOLanguageName; // 0x58
        public string CompareInfo; // 0x60
        public string IsNeutralCulture; // 0x68
        public string NumberFormat; // 0x70
        public string DateTimeFormat; // 0x78
        public string[] DisplayName; // 0x80
        public System.Globalization.CompareInfo EnglishName; // 0x88
        public void* InstalledUICulture; // 0x90
        public int IsReadOnly; // 0x98
        public System.Globalization.Calendar CalendarType; // 0xA0
        public System.Globalization.CultureInfo DefaultThreadCurrentCulture; // 0xA8
        public bool DefaultThreadCurrentUICulture; // 0xB0
        public byte[] SortName; // 0xB8
        public System.Globalization.CultureData UserDefaultUICulture; // 0xC0
        public bool UserDefaultCulture; // 0xC8
        public int HasInvariantCultureName;
        public int CalendarTypeBits;
        public int LOCALE_INVARIANT;
        public string MSG_READONLY;
        public System.Globalization.CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
        public System.Globalization.CultureInfo s_DefaultThreadCurrentCulture; // 0x20
        public System.Collections.Generic.Dictionary`2<int,System.Globalization.CultureInfo> shared_by_number; // 0x28
        public System.Collections.Generic.Dictionary`2<string,System.Globalization.CultureInfo> shared_by_name; // 0x30
        public System.Globalization.CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
        public bool IsTaiwanSku; // 0x40

        // ── Methods ──
        public void get__cultureData(){} // RVA: 0x7FFAC2F8C120
        public void get__isInherited(){} // RVA: 0x7FFAC3D2B010
        public void get_InvariantCulture(){} // RVA: 0x7FFAC8581EE0
        public void get_CurrentCulture(){} // RVA: 0x7FFAC8581F40
        public void get_CurrentUICulture(){} // RVA: 0x7FFAC8581F90
        public void set_CurrentUICulture(){} // RVA: 0x7FFAC8581FE0
        public void ConstructCurrentCulture(){} // RVA: 0x7FFAC8582010
        public void ConstructCurrentUICulture(){} // RVA: 0x7FFAC8582270
        public void get_Territory(){} // RVA: 0x7FFAC30E5600
        public void get__name(){} // RVA: 0x7FFAC2F9C730
        public void get_IetfLanguageTag(){} // RVA: 0x7FFAC85822C0
        public void get_LCID(){} // RVA: 0x7FFAC33D5A20
        public void get_Name(){} // RVA: 0x7FFAC2F9C730
        public void get_NativeName(){} // RVA: 0x7FFAC8582400
        public void get_Calendar(){} // RVA: 0x7FFAC8582470
        public void get_Parent(){} // RVA: 0x7FFAC8582540
        public void get_TextInfo(){} // RVA: 0x7FFAC8582820
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x7FFAC8582A70
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x7FFAC8582AE0
        public void Clone(){} // RVA: 0x7FFAC8582B50
        public void Equals(){} // RVA: 0x7FFAC8582DB0
        public void GetCultures(){} // RVA: 0x7FFAC8582E90
        public void GetTextInfoData(){} // RVA: 0x7FFAC8583290
        public void GetHashCode(){} // RVA: 0x7FFAC33D5A20
        public void ReadOnly(){} // RVA: 0x7FFAC85832B0
        public void ToString(){} // RVA: 0x7FFAC2F9C730
        public void get_CompareInfo(){} // RVA: 0x7FFAC8583540
        public void get_IsNeutralCulture(){} // RVA: 0x7FFAC8583800
        public void CheckNeutral(){} // RVA: 0x7FFAC2F21310
        public void get_NumberFormat(){} // RVA: 0x7FFAC8583840
        public void set_NumberFormat(){} // RVA: 0x7FFAC8583930
        public void get_DateTimeFormat(){} // RVA: 0x7FFAC8583AA0
        public void set_DateTimeFormat(){} // RVA: 0x7FFAC8583CB0
        public void get_DisplayName(){} // RVA: 0x7FFAC8583E20
        public void get_EnglishName(){} // RVA: 0x7FFAC8583E40
        public void get_InstalledUICulture(){} // RVA: 0x7FFAC8583EB0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2FEB5E0
        public void GetFormat(){} // RVA: 0x7FFAC8583F00
        public void Construct(){} // RVA: 0x7FFAC8584050
        public void construct_internal_locale_from_lcid(){} // RVA: 0x7FFAC85840B0
        public void construct_internal_locale_from_name(){} // RVA: 0x7FFAC8584110
        public void get_current_locale_name(){} // RVA: 0x7FFAC85842A0
        public void internal_get_cultures(){} // RVA: 0x7FFAC8584320
        public void ConstructInvariant(){} // RVA: 0x7FFAC8584330
        public void CreateTextInfo(){} // RVA: 0x7FFAC85848B0
        public void .ctor(){} // RVA: 0x7FFAC33981D0 | overloaded x7
        public void insert_into_shared_tables(){} // RVA: 0x7FFAC85850F0
        public void GetCultureInfo(){} // RVA: 0x7FFAC8585A10 | overloaded x3
        public void CreateCulture(){} // RVA: 0x7FFAC8585B10
        public void CreateSpecificCulture(){} // RVA: 0x7FFAC8585BA0
        public void ConstructLocaleFromName(){} // RVA: 0x7FFAC8585F00
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x7FFAC8585FB0
        public void get_CalendarType(){} // RVA: 0x7FFAC85891F0
        public void CreateCalendar(){} // RVA: 0x7FFAC8589290
        public void CreateNotFoundException(){} // RVA: 0x7FFAC85894B0
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x7FFAC8589560
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x7FFAC85895C0
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFAC8589680
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x7FFAC85896E0
        public void get_SortName(){} // RVA: 0x7FFAC2F9C730
        public void get_UserDefaultUICulture(){} // RVA: 0x7FFAC85897A0
        public void get_UserDefaultCulture(){} // RVA: 0x7FFAC8589820
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFAC84DA580
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0x7FFAC2F21310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x7FFAC8589870
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFAC8589A00
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x7FFAC8589B00
        public void get_HasInvariantCultureName(){} // RVA: 0x7FFAC8589C70
        public void VerifyCultureName(){} // RVA: 0x7FFAC8589EF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8589F90
    }

    public class CultureNotFoundException : ArgumentException
    {
        public string InvalidCultureId; // 0x98
        public System.Nullable`1<int> InvalidCultureName; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85498A0 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAC8549BB0
        public void get_InvalidCultureId(){} // RVA: 0x7FFAC3543900
        public void get_InvalidCultureName(){} // RVA: 0x7FFAC354DFB0
        public void get_DefaultMessage(){} // RVA: 0x7FFAC8549EF0
        public void get_FormatedInvalidCultureId(){} // RVA: 0x7FFAC8549F30
        public void get_Message(){} // RVA: 0x7FFAC854A0A0
    }

    public class DateTimeFormatInfo : Object
    {
        public System.Globalization.DateTimeFormatInfo CultureName;
        public System.Globalization.CultureData Culture; // 0x10
        public string LanguageName; // 0x18
        public string InvariantInfo; // 0x20
        public System.Globalization.CompareInfo CurrentInfo; // 0x28
        public System.Globalization.CultureInfo AMDesignator; // 0x30
        public string Calendar; // 0x38
        public string OptionalCalendars; // 0x40
        public string EraNames; // 0x48
        public string AbbreviatedEraNames; // 0x50
        public string AbbreviatedEnglishEraNames; // 0x58
        public string DateSeparator; // 0x60
        public string FullDateTimePattern; // 0x68
        public string LongDatePattern; // 0x70
        public string LongTimePattern;
        public string MonthDayPattern;
        public string PMDesignator;
        public System.Globalization.Calendar RFC1123Pattern; // 0x78
        public int ShortDatePattern; // 0x80
        public int ShortTimePattern; // 0x84
        public string SortableDateTimePattern; // 0x88
        public string[] GeneralShortTimePattern; // 0x90
        public string[] GeneralLongTimePattern; // 0x98
        public string[] DateTimeOffsetPattern; // 0xA0
        public string[] TimeSeparator; // 0xA8
        public string[] UniversalSortableDateTimePattern; // 0xB0
        public string[] YearMonthPattern; // 0xB8
        public string[] AbbreviatedDayNames; // 0xC0
        public string[] DayNames; // 0xC8
        public string AbbreviatedMonthNames; // 0xD0
        public string MonthNames; // 0xD8
        public string HasSpacesInMonthNames; // 0xE0
        public string HasSpacesInDayNames; // 0xE8
        public string AllYearMonthPatterns; // 0xF0
        public string[] AllShortDatePatterns; // 0xF8
        public string[] AllShortTimePatterns; // 0x100
        public string[] AllLongDatePatterns; // 0x108
        public string[] AllLongTimePatterns; // 0x110
        public string[] UnclonedYearMonthPatterns; // 0x118
        public string[] UnclonedShortDatePatterns; // 0x120
        public string[] UnclonedLongDatePatterns; // 0x128
        public string[] UnclonedShortTimePatterns; // 0x130
        public 0x6B0DB2D0[] UnclonedLongTimePatterns; // 0x138
        public int IsReadOnly;
        public bool MonthGenitiveNames; // 0x140
        public 0x6B0DB170 FullTimeSpanPositivePattern; // 0x144
        public char[] FullTimeSpanNegativePattern; // 0x8
        public string CompareInfo;
        public string FormatFlags;
        public string HasForceTwoDigitYears; // 0x148
        public string HasYearMonthAdjustment; // 0x150
        public 0x6B0DB3D8 InvalidDateTimeStyles;
        public TokenHashValue[] _dtfiTokenHash; // 0x158
        public int TOKEN_HASH_SIZE;
        public int SECOND_PRIME;
        public string dateSeparatorOrTimeZoneOffset;
        public string invariantDateSeparator;
        public string invariantTimeSeparator;
        public string IgnorablePeriod;
        public string IgnorableComma;
        public string CJKYearSuff;
        public string CJKMonthSuff;
        public string CJKDaySuff;
        public string KoreanYearSuff;
        public string KoreanMonthSuff;
        public string KoreanDaySuff;
        public string KoreanHourSuff;
        public string KoreanMinuteSuff;
        public string KoreanSecondSuff;
        public string CJKHourSuff;
        public string ChineseHourSuff;
        public string CJKMinuteSuff;
        public string CJKSecondSuff;
        public string JapaneseEraStart;
        public string LocalTimeMark;
        public string GMTName;
        public string ZuluName;
        public string KoreanLangName;
        public string JapaneseLangName;
        public string EnglishLangName;
        public System.Globalization.DateTimeFormatInfo s_jajpDTFI; // 0x10
        public System.Globalization.DateTimeFormatInfo s_zhtwDTFI; // 0x18

        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x7FFAC854A2A0
        public void get_Culture(){} // RVA: 0x7FFAC854A310
        public void get_LanguageName(){} // RVA: 0x7FFAC854A3D0
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x7FFAC854A440
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x7FFAC854A460
        public void internalGetDayOfWeekNames(){} // RVA: 0x7FFAC854A520
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x7FFAC854A540
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x7FFAC854A600
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x7FFAC854A620
        public void internalGetMonthNames(){} // RVA: 0x7FFAC854A6E0
        public void internalGetMonthNamesCore(){} // RVA: 0x7FFAC854A700
        public void .ctor(){} // RVA: 0x7FFAC854A990 | overloaded x2
        public void InitializeOverridableProperties(){} // RVA: 0x7FFAC854AA00
        public void get_InvariantInfo(){} // RVA: 0x7FFAC854AE80
        public void get_CurrentInfo(){} // RVA: 0x7FFAC854AFD0
        public void GetInstance(){} // RVA: 0x7FFAC854B120
        public void GetFormat(){} // RVA: 0x7FFAC854B2B0
        public void Clone(){} // RVA: 0x7FFAC854B390
        public void get_AMDesignator(){} // RVA: 0x7FFAC854B510
        public void get_Calendar(){} // RVA: 0x7FFAC30E5600
        public void set_Calendar(){} // RVA: 0x7FFAC854B580
        public void get_OptionalCalendars(){} // RVA: 0x7FFAC854BA20
        public void get_EraNames(){} // RVA: 0x7FFAC854BB90
        public void GetEraName(){} // RVA: 0x7FFAC854BC60
        public void get_AbbreviatedEraNames(){} // RVA: 0x7FFAC854BE00
        public void GetAbbreviatedEraName(){} // RVA: 0x7FFAC854BED0
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x7FFAC854C090
        public void get_DateSeparator(){} // RVA: 0x7FFAC854C160
        public void get_FullDateTimePattern(){} // RVA: 0x7FFAC854C210
        public void get_LongDatePattern(){} // RVA: 0x7FFAC854C2E0
        public void get_LongTimePattern(){} // RVA: 0x7FFAC854C380
        public void get_MonthDayPattern(){} // RVA: 0x7FFAC854C420
        public void get_PMDesignator(){} // RVA: 0x7FFAC854C4E0
        public void get_RFC1123Pattern(){} // RVA: 0x7FFAC854C550
        public void get_ShortDatePattern(){} // RVA: 0x7FFAC854C590
        public void get_ShortTimePattern(){} // RVA: 0x7FFAC854C630
        public void get_SortableDateTimePattern(){} // RVA: 0x7FFAC854C6D0
        public void get_GeneralShortTimePattern(){} // RVA: 0x7FFAC854C710
        public void get_GeneralLongTimePattern(){} // RVA: 0x7FFAC854C7D0
        public void get_DateTimeOffsetPattern(){} // RVA: 0x7FFAC854C890
        public void get_TimeSeparator(){} // RVA: 0x7FFAC854CAB0
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x7FFAC854CB20
        public void get_YearMonthPattern(){} // RVA: 0x7FFAC854CB60
        public void get_AbbreviatedDayNames(){} // RVA: 0x7FFAC854CC00
        public void get_DayNames(){} // RVA: 0x7FFAC854CC90
        public void get_AbbreviatedMonthNames(){} // RVA: 0x7FFAC854CD20
        public void get_MonthNames(){} // RVA: 0x7FFAC854CDB0
        public void get_HasSpacesInMonthNames(){} // RVA: 0x7FFAC854CE40
        public void get_HasSpacesInDayNames(){} // RVA: 0x7FFAC854CE70
        public void internalGetMonthName(){} // RVA: 0x7FFAC854CEA0
        public void internalGetGenitiveMonthNames(){} // RVA: 0x7FFAC854D000
        public void internalGetLeapYearMonthNames(){} // RVA: 0x7FFAC854D1B0
        public void GetAbbreviatedDayName(){} // RVA: 0x7FFAC854D280
        public void GetCombinedPatterns(){} // RVA: 0x7FFAC854D390
        public void GetAllDateTimePatterns(){} // RVA: 0x7FFAC854D4A0
        public void GetDayName(){} // RVA: 0x7FFAC854D950
        public void GetAbbreviatedMonthName(){} // RVA: 0x7FFAC854DA60
        public void GetMonthName(){} // RVA: 0x7FFAC854DB70
        public void GetMergedPatterns(){} // RVA: 0x7FFAC854DC80
        public void get_AllYearMonthPatterns(){} // RVA: 0x7FFAC854DE80
        public void get_AllShortDatePatterns(){} // RVA: 0x7FFAC854DF00
        public void get_AllShortTimePatterns(){} // RVA: 0x7FFAC854DF80
        public void get_AllLongDatePatterns(){} // RVA: 0x7FFAC854E000
        public void get_AllLongTimePatterns(){} // RVA: 0x7FFAC854E080
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x7FFAC854E100
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x7FFAC854E1D0
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x7FFAC854E2A0
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x7FFAC854E370
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x7FFAC854E400
        public void ReadOnly(){} // RVA: 0x7FFAC854E490
        public void get_IsReadOnly(){} // RVA: 0x7FFAC854E6B0
        public void get_MonthGenitiveNames(){} // RVA: 0x7FFAC854E750
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x7FFAC854E7E0
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x7FFAC854E920
        public void get_CompareInfo(){} // RVA: 0x7FFAC854E9D0
        public void ValidateStyles(){} // RVA: 0x7FFAC854EB60
        public void get_FormatFlags(){} // RVA: 0x7FFAC854EC90
        public void InitializeFormatFlags(){} // RVA: 0x7FFAC854ECB0
        public void get_HasForceTwoDigitYears(){} // RVA: 0x7FFAC854EF00
        public void get_HasYearMonthAdjustment(){} // RVA: 0x7FFAC854EF40
        public void YearMonthAdjustment(){} // RVA: 0x7FFAC854EF70
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x7FFAC854F0B0
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x7FFAC854F290
        public void ClearTokenHashTable(){} // RVA: 0x7FFAC854F470
        public void CreateTokenHashTable(){} // RVA: 0x7FFAC854F4F0
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x7FFAC8550120
        public void IsJapaneseCalendar(){} // RVA: 0x7FFAC8550F00
        public void AddMonthNames(){} // RVA: 0x7FFAC8551040
        public void TryParseHebrewNumber(){} // RVA: 0x7FFAC8551110
        public void IsHebrewChar(){} // RVA: 0x7FFAC8551310
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x7FFAC8551330
        public void Tokenize(){} // RVA: 0x7FFAC8551480
        public void InsertAtCurrentHashNode(){} // RVA: 0x7FFAC8551BA0
        public void InsertHash(){} // RVA: 0x7FFAC8551DE0
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x7FFAC85521E0
        public void .cctor(){} // RVA: 0x7FFAC8552310
    }

    public class DateTimeFormatInfoScanner : Object
    {
        public System.Collections.Generic.List`1<string> KnownWords; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> s_knownWords;
        public 0x6B0DB328 _ymdFlags; // 0x18

        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x7FFAC8552400
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x7FFAC8552A70
        public void AddDateWordOrPostfix(){} // RVA: 0x7FFAC8552B60
        public void AddDateWords(){} // RVA: 0x7FFAC8552DF0
        public void ScanRepeatChar(){} // RVA: 0x7FFAC8553080
        public void AddIgnorableSymbols(){} // RVA: 0x7FFAC85530E0
        public void ScanDateWord(){} // RVA: 0x7FFAC8553270
        public void GetDateWordsOfDTFI(){} // RVA: 0x7FFAC8553530
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x7FFAC8553850
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x7FFAC85538A0
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x7FFAC8553960
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x7FFAC85539A0
        public void EqualStringArrays(){} // RVA: 0x7FFAC85539B0
        public void ArrayElementsHaveSpace(){} // RVA: 0x7FFAC8553A90
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x7FFAC8553B90
        public void .ctor(){} // RVA: 0x7FFAC8553DB0
    }

    public class DaylightTime : Object
    {
        public System.DateTime Start; // 0x10
        public System.DateTime End; // 0x18
        public System.TimeSpan Delta; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8553E70
        public void get_Start(){} // RVA: 0x7FFAC2F3C380
        public void get_End(){} // RVA: 0x7FFAC2F247C0
        public void get_Delta(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class DaylightTimeStruct : ValueType
    {
        public System.DateTime Start; // 0x10
        public System.DateTime End; // 0x18
        public System.TimeSpan Delta; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8553E80
    }

    public class EncodingTable : Object
    {
        public System.Globalization.InternalEncodingDataItem[] encodingDataPtr;
        public System.Globalization.InternalCodePageDataItem[] codePageDataPtr; // 0x8
        public int lastEncodingItem; // 0x10
        public System.Collections.Generic.Dictionary`2<string,int> hashByName; // 0x18
        public System.Collections.Generic.Dictionary`2<int,System.Globalization.CodePageDataItem> hashByCodePage; // 0x20

        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x7FFAC8577060
        public void ENC(){} // RVA: 0x7FFAC85770D0
        public void MapCodePageDataItem(){} // RVA: 0x7FFAC8577140
        public void .cctor(){} // RVA: 0x7FFAC85771B0
        public void internalGetCodePageFromName(){} // RVA: 0x7FFAC8580880
        public void GetCodePageFromName(){} // RVA: 0x7FFAC8580C20
        public void GetCodePageDataItem(){} // RVA: 0x7FFAC8580FB0
    }

    public class EraInfo : Object
    {
        public int era; // 0x10
        public long ticks; // 0x18
        public int yearOffset; // 0x20
        public int minEraYear; // 0x24
        public int maxEraYear; // 0x28
        public string eraName; // 0x30
        public string abbrevEraName; // 0x38
        public string englishEraName; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85672C0 | overloaded x2
    }

    public class FormatProvider : Object
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x7FFAC8FC6380
        public void TryStringToBigInteger(){} // RVA: 0x7FFAC8FC6500
    }

    public class GlobalizationMode : Object
    {
        public bool Invariant;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFAC855FE40
        public void GetGlobalizationInvariantMode(){} // RVA: 0x7FFAC2F21320
        public void .cctor(){} // RVA: 0x7FFAC855FEA0
    }

    public class GregorianCalendar : Calendar
    {
        public 0x6B0DBE80 MinSupportedDateTime; // 0x20
        public int[] MaxSupportedDateTime;
        public int[] AlgorithmType; // 0x8
        public System.Globalization.Calendar ID; // 0x10

        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFAC8564870
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC8564960
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC85649C0
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3013AF0
        public void GetDefaultInstance(){} // RVA: 0x7FFAC8564A20
        public void .ctor(){} // RVA: 0x7FFAC8564B70 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFAC30DBBE0
        public void GetDatePart(){} // RVA: 0x7FFAC8564CC0
        public void GetAbsoluteDate(){} // RVA: 0x7FFAC8564E90
        public void DateToTicks(){} // RVA: 0x7FFAC8565090
        public void AddMonths(){} // RVA: 0x7FFAC8565110
        public void AddYears(){} // RVA: 0x7FFAC8565630
        public void GetDayOfMonth(){} // RVA: 0x7FFAC8565650
        public void GetDayOfWeek(){} // RVA: 0x7FFAC8565700
        public void GetDayOfYear(){} // RVA: 0x7FFAC85657C0
        public void GetDaysInMonth(){} // RVA: 0x7FFAC8565870
        public void GetDaysInYear(){} // RVA: 0x7FFAC8565B90
        public void GetEra(){} // RVA: 0x7FFAC3013AF0
        public void get_Eras(){} // RVA: 0x7FFAC8565D70
        public void GetMonth(){} // RVA: 0x7FFAC8565DD0
        public void GetMonthsInYear(){} // RVA: 0x7FFAC8565E80
        public void GetYear(){} // RVA: 0x7FFAC8566010
        public void IsLeapDay(){} // RVA: 0x7FFAC85660C0
        public void GetLeapMonth(){} // RVA: 0x7FFAC8566510
        public void IsLeapMonth(){} // RVA: 0x7FFAC8566690
        public void IsLeapYear(){} // RVA: 0x7FFAC8566930
        public void ToDateTime(){} // RVA: 0x7FFAC8566B00
        public void TryToDateTime(){} // RVA: 0x7FFAC8566BE0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC8566CE0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC8566D60
        public void ToFourDigitYear(){} // RVA: 0x7FFAC8566E80
        public void .cctor(){} // RVA: 0x7FFAC8567000
    }

    public class GregorianCalendarHelper : Object
    {
        public int[] MaxYear;
        public int[] Eras; // 0x8
        public int m_maxYear; // 0x10
        public int m_minYear; // 0x14
        public System.Globalization.Calendar m_Cal; // 0x18
        public System.Globalization.EraInfo[] m_EraInfo; // 0x20
        public int[] m_eras; // 0x28
        public System.DateTime m_minDate; // 0x30

        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC85674D0
        public void GetYearOffset(){} // RVA: 0x7FFAC8567600
        public void GetGregorianYear(){} // RVA: 0x7FFAC8567990
        public void IsValidYear(){} // RVA: 0x7FFAC85679C0
        public void GetDatePart(){} // RVA: 0x7FFAC85679E0
        public void GetAbsoluteDate(){} // RVA: 0x7FFAC8567BD0
        public void DateToTicks(){} // RVA: 0x7FFAC8567DD0
        public void TimeToTicks(){} // RVA: 0x7FFAC8567E50
        public void CheckTicksRange(){} // RVA: 0x7FFAC8568030
        public void AddMonths(){} // RVA: 0x7FFAC85682A0
        public void AddYears(){} // RVA: 0x7FFAC8568820
        public void GetDayOfMonth(){} // RVA: 0x7FFAC8568830
        public void GetDayOfWeek(){} // RVA: 0x7FFAC85688E0
        public void GetDayOfYear(){} // RVA: 0x7FFAC8568A00
        public void GetDaysInMonth(){} // RVA: 0x7FFAC8568AB0
        public void GetDaysInYear(){} // RVA: 0x7FFAC8568C60
        public void GetEra(){} // RVA: 0x7FFAC8568CF0
        public void get_Eras(){} // RVA: 0x7FFAC8568E30
        public void GetMonth(){} // RVA: 0x7FFAC8568FA0
        public void GetMonthsInYear(){} // RVA: 0x7FFAC8569050
        public void GetYear(){} // RVA: 0x7FFAC8569070
        public void IsLeapDay(){} // RVA: 0x7FFAC85691D0
        public void GetLeapMonth(){} // RVA: 0x7FFAC8569360
        public void IsLeapMonth(){} // RVA: 0x7FFAC8569380
        public void IsLeapYear(){} // RVA: 0x7FFAC85694B0
        public void ToDateTime(){} // RVA: 0x7FFAC8569530
        public void GetWeekOfYear(){} // RVA: 0x7FFAC8569680
        public void ToFourDigitYear(){} // RVA: 0x7FFAC85697A0
        public void .cctor(){} // RVA: 0x7FFAC85699A0
    }

    public class HebrewNumber : Object
    {
        public HebrewValue[] s_hebrewValues;
        public char s_maxHebrewNumberCh; // 0x8
        public 0x6B0DB640[] s_numberPasingState; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC8553EA0
        public void ParseByChar(){} // RVA: 0x7FFAC85542C0
        public void IsDigit(){} // RVA: 0x7FFAC8554480
        public void .cctor(){} // RVA: 0x7FFAC8554560
    }

    public class HebrewNumberParsingContext : ValueType
    {
        public 0x6B0DB640 state; // 0x10
        public int result; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8553E90
    }

    public class HijriCalendar : Calendar
    {
        public int MinSupportedDateTime;
        public int[] MaxSupportedDateTime; // 0x8
        public int AlgorithmType; // 0x20
        public System.DateTime ID; // 0x10
        public System.DateTime DaysInYearBeforeMinSupportedYear; // 0x18

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC8569B40
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC8569BA0
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC8569C00
        public void get_ID(){} // RVA: 0x7FFAC36A9850
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAC8569C20
        public void GetAbsoluteDateHijri(){} // RVA: 0x7FFAC8569C30
        public void DaysUpToHijriYear(){} // RVA: 0x7FFAC8569D50
        public void get_HijriAdjustment(){} // RVA: 0x7FFAC8569E10
        public void GetAdvanceHijriDate(){} // RVA: 0x7FFAC34F9180
        public void CheckTicksRange(){} // RVA: 0x7FFAC8569E70
        public void CheckEraRange(){} // RVA: 0x7FFAC856A0F0
        public void CheckYearRange(){} // RVA: 0x7FFAC856A1C0
        public void CheckYearMonthRange(){} // RVA: 0x7FFAC856A3C0
        public void GetDatePart(){} // RVA: 0x7FFAC856A590
        public void AddMonths(){} // RVA: 0x7FFAC856A830
        public void AddYears(){} // RVA: 0x7FFAC8565630
        public void GetDayOfMonth(){} // RVA: 0x7FFAC856AC80
        public void GetDayOfWeek(){} // RVA: 0x7FFAC856AD30
        public void GetDayOfYear(){} // RVA: 0x7FFAC856ADF0
        public void GetDaysInMonth(){} // RVA: 0x7FFAC856AEA0
        public void GetDaysInYear(){} // RVA: 0x7FFAC856AF70
        public void GetEra(){} // RVA: 0x7FFAC856B010
        public void get_Eras(){} // RVA: 0x7FFAC856B0E0
        public void GetMonth(){} // RVA: 0x7FFAC856B180
        public void GetMonthsInYear(){} // RVA: 0x7FFAC856B230
        public void GetYear(){} // RVA: 0x7FFAC856B2A0
        public void IsLeapDay(){} // RVA: 0x7FFAC856B350
        public void GetLeapMonth(){} // RVA: 0x7FFAC856B4D0
        public void IsLeapMonth(){} // RVA: 0x7FFAC856B530
        public void IsLeapYear(){} // RVA: 0x7FFAC856B5A0
        public void ToDateTime(){} // RVA: 0x7FFAC856B620
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC856B840
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC856B8C0
        public void ToFourDigitYear(){} // RVA: 0x7FFAC856B9E0
        public void .cctor(){} // RVA: 0x7FFAC856BB80
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x7FFAC2C69DD0
        public void Compare(){}
        public void IsPrefix(){} // RVA: 0x7FFAC2C5D3D0
        public void IsSuffix(){} // RVA: 0x7FFAC2C5D3D0
        public void IndexOf(){}
        public void LastIndexOf(){}
    }

    public class IdnMapping : Object
    {
        public bool allow_unassigned; // 0x10
        public bool use_std3; // 0x11
        public System.Globalization.Punycode puny; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858A4C0
        public void Equals(){} // RVA: 0x7FFAC858A590
        public void GetHashCode(){} // RVA: 0x7FFAC858A610
        public void GetAscii(){} // RVA: 0x7FFAC858A700 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAC858A820
        public void ToAscii(){} // RVA: 0x7FFAC858ABB0
        public void VerifyLength(){} // RVA: 0x7FFAC858B030
        public void NamePrep(){} // RVA: 0x7FFAC858B170
        public void VerifyProhibitedCharacters(){} // RVA: 0x7FFAC858B2C0
        public void VerifyStd3AsciiRules(){} // RVA: 0x7FFAC858B520
        public void GetUnicode(){} // RVA: 0x7FFAC858B860 | overloaded x2
        public void ToUnicode(){} // RVA: 0x7FFAC858B980
    }

    public class InternalCodePageDataItem : ValueType
    {
        public ushort codePage; // 0x10
        public ushort uiFamilyCodePage; // 0x12
        public uint flags; // 0x14
        public string Names; // 0x18
    }

    public class InternalEncodingDataItem : ValueType
    {
        public string webName; // 0x10
        public ushort codePage; // 0x18
    }

    public class JapaneseCalendar : Calendar
    {
        public System.DateTime MinSupportedDateTime;
        public System.Globalization.EraInfo[] MaxSupportedDateTime; // 0x8
        public System.Globalization.Calendar AlgorithmType; // 0x10
        public System.Globalization.GregorianCalendarHelper ID; // 0x20

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC856BD30
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC856BD90
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3013AF0
        public void GetEraInfo(){} // RVA: 0x7FFAC856BDF0
        public void GetErasFromRegistry(){} // RVA: 0x7FFAC34F9180
        public void GetDefaultInstance(){} // RVA: 0x7FFAC856C4A0
        public void .ctor(){} // RVA: 0x7FFAC856C5E0
        public void get_ID(){} // RVA: 0x7FFAC366FE20
        public void AddMonths(){} // RVA: 0x7FFAC856C7A0
        public void AddYears(){} // RVA: 0x7FFAC856C7C0
        public void GetDaysInMonth(){} // RVA: 0x7FFAC856C7F0
        public void GetDaysInYear(){} // RVA: 0x7FFAC856C820
        public void GetDayOfMonth(){} // RVA: 0x7FFAC856C840
        public void GetDayOfWeek(){} // RVA: 0x7FFAC856C860
        public void GetDayOfYear(){} // RVA: 0x7FFAC856C880
        public void GetMonthsInYear(){} // RVA: 0x7FFAC856C8A0
        public void GetWeekOfYear(){} // RVA: 0x7FFAC856C8D0
        public void GetEra(){} // RVA: 0x7FFAC856C900
        public void GetMonth(){} // RVA: 0x7FFAC856C920
        public void GetYear(){} // RVA: 0x7FFAC856C940
        public void IsLeapDay(){} // RVA: 0x7FFAC856C960
        public void IsLeapYear(){} // RVA: 0x7FFAC856C990
        public void GetLeapMonth(){} // RVA: 0x7FFAC856C9B0
        public void IsLeapMonth(){} // RVA: 0x7FFAC856C9E0
        public void ToDateTime(){} // RVA: 0x7FFAC856CA10
        public void ToFourDigitYear(){} // RVA: 0x7FFAC856CA40
        public void get_Eras(){} // RVA: 0x7FFAC856CBF0
        public void EraNames(){} // RVA: 0x7FFAC856CC10
        public void EnglishEraNames(){} // RVA: 0x7FFAC856CD20
        public void IsValidYear(){} // RVA: 0x7FFAC856CE30
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC856CE60
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC856CEE0
        public void .cctor(){} // RVA: 0x7FFAC856D030
    }

    public class NumberFormatInfo : Object
    {
        public System.Globalization.NumberFormatInfo InvariantInfo;
        public int[] CurrencyDecimalDigits; // 0x10
        public int[] CurrencyDecimalSeparator; // 0x18
        public int[] IsReadOnly; // 0x20
        public string CurrencyGroupSizes; // 0x28
        public string NumberGroupSizes; // 0x30
        public string PercentGroupSizes; // 0x38
        public string CurrencyGroupSeparator; // 0x40
        public string CurrencySymbol; // 0x48
        public string CurrentInfo; // 0x50
        public string NaNSymbol; // 0x58
        public string CurrencyNegativePattern; // 0x60
        public string NumberNegativePattern; // 0x68
        public string PercentPositivePattern; // 0x70
        public string PercentNegativePattern; // 0x78
        public string NegativeInfinitySymbol; // 0x80
        public string NegativeSign; // 0x88
        public string NumberDecimalDigits; // 0x90
        public string NumberDecimalSeparator; // 0x98
        public string[] NumberGroupSeparator; // 0xA0
        public int CurrencyPositivePattern; // 0xA8
        public int PositiveInfinitySymbol; // 0xAC
        public int PositiveSign; // 0xB0
        public int PercentDecimalDigits; // 0xB4
        public int PercentDecimalSeparator; // 0xB8
        public int PercentGroupSeparator; // 0xBC
        public int PercentSymbol; // 0xC0
        public int PerMilleSymbol; // 0xC4
        public int percentDecimalDigits; // 0xC8
        public int digitSubstitution; // 0xCC
        public bool isReadOnly; // 0xD0
        public bool m_useUserOverride; // 0xD1
        public bool m_isInvariant; // 0xD2
        public bool validForParseAsNumber; // 0xD3
        public bool validForParseAsCurrency; // 0xD4
        public 0x6B0DB6F0 InvalidNumberStyles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC856D240 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAC856D0D0
        public void OnDeserializing(){} // RVA: 0x7FFAC2F21310
        public void OnDeserialized(){} // RVA: 0x7FFAC2F21310
        public void VerifyWritable(){} // RVA: 0x7FFAC856DCE0
        public void get_InvariantInfo(){} // RVA: 0x7FFAC856DD60
        public void GetInstance(){} // RVA: 0x7FFAC856DED0
        public void Clone(){} // RVA: 0x7FFAC856E060
        public void get_CurrencyDecimalDigits(){} // RVA: 0x7FFAC4BF81F0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC33CFDE0
        public void get_CurrencyGroupSizes(){} // RVA: 0x7FFAC856E0D0
        public void get_NumberGroupSizes(){} // RVA: 0x7FFAC856E150
        public void get_PercentGroupSizes(){} // RVA: 0x7FFAC856E1D0
        public void get_CurrencyGroupSeparator(){} // RVA: 0x7FFAC2F9C730
        public void get_CurrencySymbol(){} // RVA: 0x7FFAC2FE9500
        public void get_CurrentInfo(){} // RVA: 0x7FFAC856E250
        public void get_NaNSymbol(){} // RVA: 0x7FFAC2F9CD50
        public void set_NaNSymbol(){} // RVA: 0x7FFAC856E380
        public void get_CurrencyNegativePattern(){} // RVA: 0x7FFAC431B350
        public void get_NumberNegativePattern(){} // RVA: 0x7FFAC37AB780
        public void get_PercentPositivePattern(){} // RVA: 0x7FFAC313B720
        public void get_PercentNegativePattern(){} // RVA: 0x7FFAC47D3250
        public void get_NegativeInfinitySymbol(){} // RVA: 0x7FFAC30E5600
        public void get_NegativeSign(){} // RVA: 0x7FFAC31D95E0
        public void get_NumberDecimalDigits(){} // RVA: 0x7FFAC6539490
        public void get_NumberDecimalSeparator(){} // RVA: 0x7FFAC31D0140
        public void get_NumberGroupSeparator(){} // RVA: 0x7FFAC2F9E740
        public void get_CurrencyPositivePattern(){} // RVA: 0x7FFAC6715300
        public void get_PositiveInfinitySymbol(){} // RVA: 0x7FFAC2FE9590
        public void get_PositiveSign(){} // RVA: 0x7FFAC2F4F130
        public void get_PercentDecimalDigits(){} // RVA: 0x7FFAC3641480
        public void get_PercentDecimalSeparator(){} // RVA: 0x7FFAC32EF410
        public void get_PercentGroupSeparator(){} // RVA: 0x7FFAC2F60010
        public void get_PercentSymbol(){} // RVA: 0x7FFAC32EF640
        public void get_PerMilleSymbol(){} // RVA: 0x7FFAC354DFB0
        public void GetFormat(){} // RVA: 0x7FFAC856E4B0
        public void ReadOnly(){} // RVA: 0x7FFAC856E590
        public void ValidateParseStyleInteger(){} // RVA: 0x7FFAC856E660
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x7FFAC856E750
    }

    public class Punycode : Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858C5D0
    }

    public class RegionInfo : Object
    {
        public System.Globalization.RegionInfo CurrentRegion;
        public int CurrencyEnglishName; // 0x10
        public string CurrencySymbol; // 0x18
        public string DisplayName; // 0x20
        public string EnglishName; // 0x28
        public string GeoId; // 0x30
        public string IsMetric; // 0x38
        public string ISOCurrencySymbol; // 0x40
        public string NativeName; // 0x48
        public string CurrencyNativeName; // 0x50
        public string Name; // 0x58

        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x7FFAC858C610
        public void .ctor(){} // RVA: 0x7FFAC858CAB0 | overloaded x3
        public void GetByTerritory(){} // RVA: 0x7FFAC858CF40
        public void construct_internal_region_from_name(){} // RVA: 0x7FFAC858CFF0
        public void get_CurrencyEnglishName(){} // RVA: 0x7FFAC2FC20E0
        public void get_CurrencySymbol(){} // RVA: 0x7FFAC2F9E740
        public void get_DisplayName(){} // RVA: 0x7FFAC31D95E0
        public void get_EnglishName(){} // RVA: 0x7FFAC31D95E0
        public void get_GeoId(){} // RVA: 0x7FFAC2F6E5C0
        public void get_IsMetric(){} // RVA: 0x7FFAC858D180
        public void get_ISOCurrencySymbol(){} // RVA: 0x7FFAC2F9C730
        public void get_NativeName(){} // RVA: 0x7FFAC31D0140
        public void get_CurrencyNativeName(){} // RVA: 0x7FFAC2FE9500
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_ThreeLetterISORegionName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0x7FFAC2F4F130
        public void get_TwoLetterISORegionName(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC858D250
        public void GetHashCode(){} // RVA: 0x7FFAC858D360
        public void ToString(){} // RVA: 0x7FFAC42D3240
        public void ClearCachedData(){} // RVA: 0x7FFAC858D3A0
    }

    public class SortKey : Object
    {
        public string OriginalString; // 0x10
        public byte[] KeyData; // 0x18
        public 0x6B0DB010 options; // 0x20
        public int lcid; // 0x24

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC8574020
        public void .ctor(){} // RVA: 0x7FFAC8574710 | overloaded x4
        public void get_OriginalString(){} // RVA: 0x7FFAC2F3C380
        public void get_KeyData(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC85744B0
        public void GetHashCode(){} // RVA: 0x7FFAC8574560
        public void ToString(){} // RVA: 0x7FFAC85745D0
    }

    public class SortVersion : Object
    {
        public int m_NlsVersion; // 0x10
        public System.Guid m_SortId; // 0x14
    }

    public class TaiwanCalendar : Calendar
    {
        public System.Globalization.EraInfo[] MinSupportedDateTime;
        public System.Globalization.Calendar MaxSupportedDateTime; // 0x8
        public System.Globalization.GregorianCalendarHelper AlgorithmType; // 0x20
        public System.DateTime ID; // 0x10

        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x7FFAC856E830
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC856E970
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC856E9D0
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC856EA30
        public void get_ID(){} // RVA: 0x7FFAC36C3910
        public void AddMonths(){} // RVA: 0x7FFAC856C7A0
        public void AddYears(){} // RVA: 0x7FFAC856C7C0
        public void GetDaysInMonth(){} // RVA: 0x7FFAC856C7F0
        public void GetDaysInYear(){} // RVA: 0x7FFAC856C820
        public void GetDayOfMonth(){} // RVA: 0x7FFAC856C840
        public void GetDayOfWeek(){} // RVA: 0x7FFAC856C860
        public void GetDayOfYear(){} // RVA: 0x7FFAC856C880
        public void GetMonthsInYear(){} // RVA: 0x7FFAC856C8A0
        public void GetWeekOfYear(){} // RVA: 0x7FFAC856C8D0
        public void GetEra(){} // RVA: 0x7FFAC856C900
        public void GetMonth(){} // RVA: 0x7FFAC856C920
        public void GetYear(){} // RVA: 0x7FFAC856C940
        public void IsLeapDay(){} // RVA: 0x7FFAC856C960
        public void IsLeapYear(){} // RVA: 0x7FFAC856C990
        public void GetLeapMonth(){} // RVA: 0x7FFAC856C9B0
        public void IsLeapMonth(){} // RVA: 0x7FFAC856C9E0
        public void ToDateTime(){} // RVA: 0x7FFAC856CA10
        public void get_Eras(){} // RVA: 0x7FFAC856CBF0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC856CE60
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC856EC00
        public void ToFourDigitYear(){} // RVA: 0x7FFAC856ED50
        public void .cctor(){} // RVA: 0x7FFAC856EF00
    }

    public class TextInfo : Object
    {
        public string Invariant; // 0x10
        public bool CultureName; // 0x18
        public string IsReadOnly; // 0x20
        public System.Globalization.CultureData ListSeparator; // 0x28
        public string IsAsciiCasingSameAsInvariant; // 0x30
        public System.Nullable`1<bool> IsRightToLeft; // 0x38
        public System.Globalization.TextInfo s_Invariant;
        public string customCultureName; // 0x40
        public int m_nDataItem; // 0x48
        public bool m_useUserOverride; // 0x4C
        public int m_win32LangID; // 0x50
        public int wordSeparatorMask;

        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x7FFAC856F0C0
        public void .ctor(){} // RVA: 0x7FFAC85714B0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFAC856F2F0
        public void OnDeserialized(){} // RVA: 0x7FFAC856F560 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAC856F570
        public void get_CultureName(){} // RVA: 0x7FFAC31D95E0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F3C4E0
        public void Clone(){} // RVA: 0x7FFAC856F650
        public void ReadOnly(){} // RVA: 0x7FFAC856F6D0
        public void SetReadOnlyState(){} // RVA: 0x7FFAC2F3C4F0
        public void get_ListSeparator(){} // RVA: 0x7FFAC856F7C0
        public void ToLower(){} // RVA: 0x7FFAC856F8A0 | overloaded x2
        public void ToLowerAsciiInvariant(){} // RVA: 0x7FFAC856F9D0
        public void ToUpper(){} // RVA: 0x7FFAC856FA50 | overloaded x2
        public void ToUpperAsciiInvariant(){} // RVA: 0x7FFAC85712D0 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFAC856FBA0
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x7FFAC856FBB0
        public void Equals(){} // RVA: 0x7FFAC856FD00
        public void GetHashCode(){} // RVA: 0x7FFAC856FDE0
        public void ToString(){} // RVA: 0x7FFAC856FE10
        public void ToTitleCase(){} // RVA: 0x7FFAC856FE70
        public void AddNonLetter(){} // RVA: 0x7FFAC8570340
        public void AddTitlecaseLetter(){} // RVA: 0x7FFAC8570400
        public void IsWordSeparator(){} // RVA: 0x7FFAC8570620
        public void IsLetterCategory(){} // RVA: 0x7FFAC8570630
        public void get_IsRightToLeft(){} // RVA: 0x7FFAC8570640
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC856F560
        public void ToUpperInternal(){} // RVA: 0x7FFAC8570820 | overloaded x2
        public void ToLowerInternal(){} // RVA: 0x7FFAC8570DF0 | overloaded x2
        public void ChangeCase(){} // RVA: 0x7FFAC8571380
    }

    public class TextInfoToLowerData : Object
    {
        public char[] range_00c0_0556;
        public char[] range_10a0_10c5; // 0x8
        public char[] range_1e00_1ffc; // 0x10
        public char[] range_2160_216f; // 0x18
        public char[] range_24b6_24cf; // 0x20
        public char[] range_2c00_2c2e; // 0x28
        public char[] range_2c60_2ce2; // 0x30
        public char[] range_a640_a696; // 0x38
        public char[] range_a722_a78b; // 0x40

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC85818E0
    }

    public class TextInfoToUpperData : Object
    {
        public char[] range_00e0_0586;
        public char[] range_1e01_1ff3; // 0x8
        public char[] range_2170_2184; // 0x10
        public char[] range_24d0_24e9; // 0x18
        public char[] range_2c30_2ce3; // 0x20
        public char[] range_2d00_2d25; // 0x28
        public char[] range_a641_a697; // 0x30
        public char[] range_a723_a78c; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8581380
    }

    public class ThaiBuddhistCalendar : Calendar
    {
        public System.Globalization.EraInfo[] MinSupportedDateTime;
        public int MaxSupportedDateTime;
        public System.Globalization.GregorianCalendarHelper AlgorithmType; // 0x20
        public int ID;

        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC85714E0
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC8571540
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC85715A0
        public void get_ID(){} // RVA: 0x7FFAC36AE2C0
        public void AddMonths(){} // RVA: 0x7FFAC856C7A0
        public void AddYears(){} // RVA: 0x7FFAC856C7C0
        public void GetDaysInMonth(){} // RVA: 0x7FFAC856C7F0
        public void GetDaysInYear(){} // RVA: 0x7FFAC856C820
        public void GetDayOfMonth(){} // RVA: 0x7FFAC856C840
        public void GetDayOfWeek(){} // RVA: 0x7FFAC856C860
        public void GetDayOfYear(){} // RVA: 0x7FFAC856C880
        public void GetMonthsInYear(){} // RVA: 0x7FFAC856C8A0
        public void GetWeekOfYear(){} // RVA: 0x7FFAC856C8D0
        public void GetEra(){} // RVA: 0x7FFAC856C900
        public void GetMonth(){} // RVA: 0x7FFAC856C920
        public void GetYear(){} // RVA: 0x7FFAC856C940
        public void IsLeapDay(){} // RVA: 0x7FFAC856C960
        public void IsLeapYear(){} // RVA: 0x7FFAC856C990
        public void GetLeapMonth(){} // RVA: 0x7FFAC856C9B0
        public void IsLeapMonth(){} // RVA: 0x7FFAC856C9E0
        public void ToDateTime(){} // RVA: 0x7FFAC856CA10
        public void get_Eras(){} // RVA: 0x7FFAC856CBF0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC85716A0
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC8571720
        public void ToFourDigitYear(){} // RVA: 0x7FFAC8571870
        public void .cctor(){} // RVA: 0x7FFAC8571930
    }

    public class TimeSpanFormat : Object
    {
        public FormatLiterals PositiveInvariantFormatLiterals;
        public FormatLiterals NegativeInvariantFormatLiterals; // 0x28

        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x7FFAC85549D0
        public void Format(){} // RVA: 0x7FFAC8554B50
        public void TryFormat(){} // RVA: 0x7FFAC8554C50
        public void FormatToBuilder(){} // RVA: 0x7FFAC8554D50
        public void FormatStandard(){} // RVA: 0x7FFAC8555070
        public void FormatCustomized(){} // RVA: 0x7FFAC8555660
        public void .cctor(){} // RVA: 0x7FFAC8555EA0
    }

    public class TimeSpanParse : Object
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x7FFAC8556910
        public void TryTimeToTicks(){} // RVA: 0x7FFAC8556A10
        public void Parse(){} // RVA: 0x7FFAC8556BC0
        public void TryParse(){} // RVA: 0x7FFAC8556C00
        public void ParseExact(){} // RVA: 0x7FFAC8556C60
        public void TryParseExact(){} // RVA: 0x7FFAC8556CB0
        public void ParseExactMultiple(){} // RVA: 0x7FFAC8556D20
        public void TryParseExactMultiple(){} // RVA: 0x7FFAC8556D60
        public void TryParseTimeSpan(){} // RVA: 0x7FFAC8556DC0
        public void ProcessTerminalState(){} // RVA: 0x7FFAC8557F60
        public void ProcessTerminal_DHMSF(){} // RVA: 0x7FFAC85580D0
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x7FFAC8558520
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x7FFAC855A010
        public void ProcessTerminal_HM(){} // RVA: 0x7FFAC855B630
        public void ProcessTerminal_D(){} // RVA: 0x7FFAC855B960
        public void TryParseExactTimeSpan(){} // RVA: 0x7FFAC855BC70
        public void TryParseByFormat(){} // RVA: 0x7FFAC855BE10
        public void ParseExactDigits(){} // RVA: 0x7FFAC855CA40 | overloaded x2
        public void ParseExactLiteral(){} // RVA: 0x7FFAC855CB20
        public void TryParseTimeSpanConstant(){} // RVA: 0x7FFAC855CBE0
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x7FFAC855CC20
    }

    public class UmAlQuraCalendar : Calendar
    {
        public DateMapping[] MinSupportedDateTime;
        public System.DateTime MaxSupportedDateTime; // 0x8
        public System.DateTime AlgorithmType; // 0x10

        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x7FFAC8571AA0
        public void get_MinSupportedDateTime(){} // RVA: 0x7FFAC8571C80
        public void get_MaxSupportedDateTime(){} // RVA: 0x7FFAC8571CE0
        public void get_AlgorithmType(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC855FFA0
        public void get_BaseCalendarID(){} // RVA: 0x7FFAC36A9850
        public void get_ID(){} // RVA: 0x7FFAC3641DE0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x7FFAC8571D40
        public void ConvertHijriToGregorian(){} // RVA: 0x7FFAC8571D50
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x7FFAC8571FC0
        public void CheckTicksRange(){} // RVA: 0x7FFAC8572090
        public void CheckEraRange(){} // RVA: 0x7FFAC8572310
        public void CheckYearRange(){} // RVA: 0x7FFAC85723A0
        public void CheckYearMonthRange(){} // RVA: 0x7FFAC8572560
        public void ConvertGregorianToHijri(){} // RVA: 0x7FFAC8572640
        public void GetDatePart(){} // RVA: 0x7FFAC8572A60
        public void AddMonths(){} // RVA: 0x7FFAC8572C40
        public void AddYears(){} // RVA: 0x7FFAC8565630
        public void GetDayOfMonth(){} // RVA: 0x7FFAC8573030
        public void GetDayOfWeek(){} // RVA: 0x7FFAC8573050
        public void GetDayOfYear(){} // RVA: 0x7FFAC8573110
        public void GetDaysInMonth(){} // RVA: 0x7FFAC8573130
        public void RealGetDaysInYear(){} // RVA: 0x7FFAC85731F0
        public void GetDaysInYear(){} // RVA: 0x7FFAC85732A0
        public void GetEra(){} // RVA: 0x7FFAC8573310
        public void get_Eras(){} // RVA: 0x7FFAC85733D0
        public void GetMonth(){} // RVA: 0x7FFAC8573430
        public void GetMonthsInYear(){} // RVA: 0x7FFAC8573450
        public void GetYear(){} // RVA: 0x7FFAC85734C0
        public void IsLeapDay(){} // RVA: 0x7FFAC85734E0
        public void GetLeapMonth(){} // RVA: 0x7FFAC8573680
        public void IsLeapMonth(){} // RVA: 0x7FFAC85736E0
        public void IsLeapYear(){} // RVA: 0x7FFAC8573750
        public void ToDateTime(){} // RVA: 0x7FFAC85737C0
        public void get_TwoDigitYearMax(){} // RVA: 0x7FFAC856B840
        public void set_TwoDigitYearMax(){} // RVA: 0x7FFAC8573A90
        public void ToFourDigitYear(){} // RVA: 0x7FFAC8573BC0
        public void .cctor(){} // RVA: 0x7FFAC8573D60
    }

}