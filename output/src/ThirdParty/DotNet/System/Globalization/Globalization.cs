// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Globalization
// Classes: 42
// Methods: 836

namespace ThirdParty.DotNet.System.Globalization
{
    public class Bootstring : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x686E190
        public void Encode(){} // RVA: 0x686E1C0
        public void EncodeDigit(){} // RVA: 0x686E680
        public void DecodeDigit(){} // RVA: 0x686E6A0
        public void Adapt(){} // RVA: 0x686E6D0
        public void Decode(){} // RVA: 0x686E750
    }

    public class Calendar : Object
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x6841D70
        public void get_MaxSupportedDateTime(){} // RVA: 0x6841DD0
        public void .ctor(){} // RVA: 0x6841E30
        public void get_ID(){} // RVA: 0xFE6B70
        public void get_BaseCalendarID(){} // RVA: 0x254FA90
        public void get_AlgorithmType(){} // RVA: 0xDAC980
        public void get_IsReadOnly(){} // RVA: 0xC9C250
        public void Clone(){} // RVA: 0x6841E40
        public void ReadOnly(){} // RVA: 0x6841EC0
        public void VerifyWritable(){} // RVA: 0x6841FA0
        public void SetReadOnlyState(){} // RVA: 0xC9C260
        public void get_CurrentEraValue(){} // RVA: 0x6842020
        public void CheckAddResult(){} // RVA: 0x68420B0
        public void AddMonths(){} // RVA: 0x881DE0
        public void AddYears(){} // RVA: 0x881DE0
        public void GetDayOfMonth(){} // RVA: 0x882E40
        public void GetDayOfWeek(){} // RVA: 0x882E40
        public void GetDayOfYear(){} // RVA: 0x882E40
        public void GetDaysInMonth(){} // RVA: 0x8838D0
        public void GetDaysInYear(){} // RVA: 0x8830B0
        public void GetEra(){} // RVA: 0x882E40
        public void get_Eras(){} // RVA: 0x87C0A0
        public void GetMonth(){} // RVA: 0x882E40
        public void GetMonthsInYear(){} // RVA: 0x8830B0
        public void GetFirstDayWeekOfYear(){} // RVA: 0x68422C0
        public void GetWeekOfYearFullDays(){} // RVA: 0x6842380
        public void GetWeekOfYearOfMinSupportedDateTime(){} // RVA: 0x68426F0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x6842860
        public void GetWeekOfYear(){} // RVA: 0x6842870
        public void GetYear(){} // RVA: 0x882E40
        public void IsLeapDay(){} // RVA: 0x87E4B0
        public void IsLeapMonth(){} // RVA: 0x87E450
        public void GetLeapMonth(){} // RVA: 0x6842BA0
        public void IsLeapYear(){} // RVA: 0x87D5A0
        public void ToDateTime(){} // RVA: 0x881F30
        public void TryToDateTime(){} // RVA: 0x6842CE0
        public void IsValidYear(){} // RVA: 0x6842DE0
        public void IsValidMonth(){} // RVA: 0x6842E70
        public void IsValidDay(){} // RVA: 0x6842EF0
        public void get_TwoDigitYearMax(){} // RVA: 0xE62D00
        public void set_TwoDigitYearMax(){} // RVA: 0x6842F80
        public void ToFourDigitYear(){} // RVA: 0x6842FB0
        public void TimeToTicks(){} // RVA: 0x68430C0
        public void GetSystemTwoDigitYearSetting(){} // RVA: 0x6843290
    }

    public class CalendarData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6844620
        public void .cctor(){} // RVA: 0x68432F0
        public void InitializeEraNames(){} // RVA: 0x68454B0
        public void GetJapaneseEraNames(){} // RVA: 0x68459B0
        public void GetJapaneseEnglishEraNames(){} // RVA: 0x6845BE0
        public void InitializeAbbreviatedEraNames(){} // RVA: 0x6845E10
        public void GetCalendarData(){} // RVA: 0x6846260
        public void CalendarIdToCultureName(){} // RVA: 0x6846490
        public void nativeGetTwoDigitYearMax(){} // RVA: 0xFE6B70
        public void nativeGetCalendarData(){} // RVA: 0x6846660
        public void fill_calendar_data(){} // RVA: 0x6846800
    }

    public class CalendarData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CalendarId[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBD500
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7AB0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E755F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CharUnicodeInfo : Object
    {
        // ── Methods ──
        public void InternalConvertToUtf32(){} // RVA: 0x68248C0
        public void InternalGetNumericValue(){} // RVA: 0x6824970
        public void GetNumericValue(){} // RVA: 0x6824B50
        public void GetUnicodeCategory(){} // RVA: 0x6824D80
        public void InternalGetCategoryValue(){} // RVA: 0x6824F00
        public void InternalGetUnicodeCategory(){} // RVA: 0x6825130
        public void IsCombiningCategory(){} // RVA: 0x68251F0
        public void IsWhiteSpace(){} // RVA: 0x68252D0
        public void get_CategoryLevel1Index(){} // RVA: 0x68252F0
        public void get_CategoryLevel2Index(){} // RVA: 0x6825350
        public void get_CategoryLevel3Index(){} // RVA: 0x68253B0
        public void get_CategoriesValue(){} // RVA: 0x6825410
        public void get_NumericLevel1Index(){} // RVA: 0x6825470
        public void get_NumericLevel2Index(){} // RVA: 0x68254D0
        public void get_NumericLevel3Index(){} // RVA: 0x6825530
        public void get_NumericValues(){} // RVA: 0x6825590
    }

    public class CodePageDataItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6859480
        public void CreateString(){} // RVA: 0x6859540
        public void get_WebName(){} // RVA: 0x6859690
        public void get_HeaderName(){} // RVA: 0x68597B0
        public void get_BodyName(){} // RVA: 0x68598E0
        public void .cctor(){} // RVA: 0x6859A10
    }

    public class CompareInfo : Object
    {
        // ── Methods ──
        public void InvariantIndexOf(){} // RVA: 0x68255F0
        public void InvariantLastIndexOf(){} // RVA: 0x68256C0
        public void InvariantFindString(){} // RVA: 0x68257A0
        public void InvariantToUpper(){} // RVA: 0x6825B90
        public void InvariantCreateSortKey(){} // RVA: 0x6825BB0
        public void .ctor(){} // RVA: 0x682B660
        public void GetCompareInfo(){} // RVA: 0x6825F70
        public void OnDeserializing(){} // RVA: 0x627C9E0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x6826030
        public void OnDeserialized(){} // RVA: 0x6826040
        public void OnSerializing(){} // RVA: 0x6826190
        public void get_Name(){} // RVA: 0x6826230
        public void Compare(){} // RVA: 0x6826D80
        public void CompareOptionNone(){} // RVA: 0x6826AF0
        public void CompareOptionIgnoreCase(){} // RVA: 0x6826C50
        public void CompareOrdinalIgnoreCase(){} // RVA: 0x68274D0
        public void IsPrefix(){} // RVA: 0x6827B00
        public void IsSuffix(){} // RVA: 0x6827E80
        public void IndexOf(){} // RVA: 0x68288C0
        public void IndexOfOrdinal(){} // RVA: 0x6828A30
        public void LastIndexOf(){} // RVA: 0x6828C80
        public void LastIndexOfOrdinal(){} // RVA: 0x6829060
        public void GetSortKey(){} // RVA: 0x6829230
        public void Equals(){} // RVA: 0x68293B0
        public void GetHashCode(){} // RVA: 0x6829A60
        public void GetIgnoreCaseHash(){} // RVA: 0x68294E0
        public void GetHashCodeOfString(){} // RVA: 0x6829890
        public void ToString(){} // RVA: 0x6829B70
        public void get_UseManagedCollation(){} // RVA: 0x6829BD0
        public void GetCollator(){} // RVA: 0x6829D40
        public void CreateSortKeyCore(){} // RVA: 0x682A180
        public void internal_index_switch(){} // RVA: 0x682A420
        public void internal_compare_switch(){} // RVA: 0x682A6A0
        public void internal_compare_managed(){} // RVA: 0x682A8A0
        public void internal_index_managed(){} // RVA: 0x682A9A0
        public void internal_compare_icall(){} // RVA: 0x682AA50
        public void internal_compare(){} // RVA: 0x682AA60
        public void internal_index_icall(){} // RVA: 0x682AB10
        public void internal_index(){} // RVA: 0x682AC00
        public void InitSort(){} // RVA: 0x682AD40
        public void CompareStringOrdinalIgnoreCase(){} // RVA: 0x682ADB0
        public void IndexOfOrdinalCore(){} // RVA: 0x682AF60
        public void LastIndexOfOrdinalCore(){} // RVA: 0x682AFA0
        public void LastIndexOfCore(){} // RVA: 0x682AFE0
        public void IndexOfCore(){} // RVA: 0x682B020
        public void CompareString(){} // RVA: 0x682B0F0
        public void CreateSortKey(){} // RVA: 0x682B200
        public void StartsWith(){} // RVA: 0x6827B00
        public void EndsWith(){} // RVA: 0x6827E80
        public void GetHashCodeOfStringCore(){} // RVA: 0x682B500
        public void .cctor(){} // RVA: 0x682B540
    }

    public class CultureData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC0FFD0
        public void get_Invariant(){} // RVA: 0x6857170
        public void GetCultureData(){} // RVA: 0x6857920
        public void fill_culture_data(){} // RVA: 0x6857B10
        public void GetCalendar(){} // RVA: 0x6857B20
        public void get_LongTimes(){} // RVA: 0x4B432C0
        public void get_ShortTimes(){} // RVA: 0x6857CA0
        public void get_SISO639LANGNAME(){} // RVA: 0xBE58B0
        public void get_IFIRSTDAYOFWEEK(){} // RVA: 0x18A0130
        public void get_IFIRSTWEEKOFYEAR(){} // RVA: 0x114DAD0
        public void get_SAM1159(){} // RVA: 0xB5DBF0
        public void get_SPM2359(){} // RVA: 0xB465B0
        public void get_TimeSeparator(){} // RVA: 0xB700F0
        public void get_CalendarIds(){} // RVA: 0x6857CB0
        public void GetCalendarIds(){} // RVA: 0x6857F50
        public void get_IsInvariantCulture(){} // RVA: 0x6858050
        public void get_CultureName(){} // RVA: 0xC0FFC0
        public void get_SCOMPAREINFO(){} // RVA: 0x6858070
        public void get_STEXTINFO(){} // RVA: 0xC0FFC0
        public void get_IsRightToLeft(){} // RVA: 0x1163160
        public void get_SLIST(){} // RVA: 0xCD48B0
        public void get_UseUserOverride(){} // RVA: 0xB6B1A0
        public void EraNames(){} // RVA: 0x68580B0
        public void AbbrevEraNames(){} // RVA: 0x68580D0
        public void AbbreviatedEnglishEraNames(){} // RVA: 0x68580F0
        public void ShortDates(){} // RVA: 0x6858110
        public void LongDates(){} // RVA: 0x6858130
        public void YearMonths(){} // RVA: 0x6858150
        public void DayNames(){} // RVA: 0x6858170
        public void AbbreviatedDayNames(){} // RVA: 0x6858190
        public void MonthNames(){} // RVA: 0x68581B0
        public void GenitiveMonthNames(){} // RVA: 0x68581D0
        public void AbbreviatedMonthNames(){} // RVA: 0x68581F0
        public void AbbreviatedGenitiveMonthNames(){} // RVA: 0x6858210
        public void LeapYearMonthNames(){} // RVA: 0x6858240
        public void MonthDay(){} // RVA: 0x6858270
        public void DateSeparator(){} // RVA: 0x6858290
        public void GetDateSeparator(){} // RVA: 0x6858370
        public void GetSeparator(){} // RVA: 0x68583C0
        public void IndexOfTimePart(){} // RVA: 0x6858580
        public void UnescapeNlsString(){} // RVA: 0x68586A0
        public void ReescapeWin32Strings(){} // RVA: 0x2303260
        public void ReescapeWin32String(){} // RVA: 0x2303260
        public void strlen(){} // RVA: 0x6858860
        public void idx2string(){} // RVA: 0x6858880
        public void create_group_sizes_array(){} // RVA: 0x68589B0
        public void GetNFIValues(){} // RVA: 0x6858A60
        public void fill_number_data(){} // RVA: 0x6859390
    }

    public class CultureInfo : Object
    {
        // ── Methods ──
        public void get__cultureData(){} // RVA: 0xBAE420
        public void get__isInherited(){} // RVA: 0x1C11610
        public void get_InvariantCulture(){} // RVA: 0x68648F0
        public void get_CurrentCulture(){} // RVA: 0x6864950
        public void get_CurrentUICulture(){} // RVA: 0x68649A0
        public void set_CurrentUICulture(){} // RVA: 0x68649F0
        public void ConstructCurrentCulture(){} // RVA: 0x6864A20
        public void ConstructCurrentUICulture(){} // RVA: 0x6864CA0
        public void get_Territory(){} // RVA: 0xCD3320
        public void get__name(){} // RVA: 0xBBF8F0
        public void get_IetfLanguageTag(){} // RVA: 0x6864CF0
        public void get_LCID(){} // RVA: 0x116A650
        public void get_Name(){} // RVA: 0xBBF8F0
        public void get_NativeName(){} // RVA: 0x6864E30
        public void get_Calendar(){} // RVA: 0x6864EA0
        public void get_Parent(){} // RVA: 0x6864F70
        public void get_TextInfo(){} // RVA: 0x6865250
        public void get_ThreeLetterISOLanguageName(){} // RVA: 0x6865450
        public void get_TwoLetterISOLanguageName(){} // RVA: 0x68654C0
        public void Clone(){} // RVA: 0x6865530
        public void Equals(){} // RVA: 0x68657A0
        public void GetCultures(){} // RVA: 0x6865870
        public void GetTextInfoData(){} // RVA: 0x6865C50
        public void GetHashCode(){} // RVA: 0x116A650
        public void ReadOnly(){} // RVA: 0x6865C70
        public void ToString(){} // RVA: 0xBBF8F0
        public void get_CompareInfo(){} // RVA: 0x6865F00
        public void get_IsNeutralCulture(){} // RVA: 0x68661A0
        public void CheckNeutral(){} // RVA: 0xB43310
        public void get_NumberFormat(){} // RVA: 0x68661E0
        public void set_NumberFormat(){} // RVA: 0x68662D0
        public void get_DateTimeFormat(){} // RVA: 0x6866440
        public void set_DateTimeFormat(){} // RVA: 0x6866650
        public void get_DisplayName(){} // RVA: 0x68667C0
        public void get_EnglishName(){} // RVA: 0x68667E0
        public void get_InstalledUICulture(){} // RVA: 0x6866850
        public void get_IsReadOnly(){} // RVA: 0xC120A0
        public void GetFormat(){} // RVA: 0x68668A0
        public void Construct(){} // RVA: 0x68669E0
        public void construct_internal_locale_from_lcid(){} // RVA: 0x6866A40
        public void construct_internal_locale_from_name(){} // RVA: 0x6866AA0
        public void get_current_locale_name(){} // RVA: 0x6866C50
        public void internal_get_cultures(){} // RVA: 0x6866CF0
        public void ConstructInvariant(){} // RVA: 0x6866D00
        public void CreateTextInfo(){} // RVA: 0x6867270
        public void .ctor(){} // RVA: 0x1129BF0
        public void insert_into_shared_tables(){} // RVA: 0x6867A20
        public void GetCultureInfo(){} // RVA: 0x6868300
        public void CreateCulture(){} // RVA: 0x6868400
        public void CreateSpecificCulture(){} // RVA: 0x6868490
        public void ConstructLocaleFromName(){} // RVA: 0x68687B0
        public void CreateSpecificCultureFromNeutral(){} // RVA: 0x6868860
        public void get_CalendarType(){} // RVA: 0x686BAA0
        public void CreateCalendar(){} // RVA: 0x686BB40
        public void CreateNotFoundException(){} // RVA: 0x686BD50
        public void get_DefaultThreadCurrentCulture(){} // RVA: 0x686BE00
        public void set_DefaultThreadCurrentCulture(){} // RVA: 0x686BE60
        public void get_DefaultThreadCurrentUICulture(){} // RVA: 0x686BF20
        public void set_DefaultThreadCurrentUICulture(){} // RVA: 0x686BF80
        public void get_SortName(){} // RVA: 0xBBF8F0
        public void get_UserDefaultUICulture(){} // RVA: 0x686C040
        public void get_UserDefaultCulture(){} // RVA: 0x686C0C0
        public void InitializeUserPreferredCultureInfoInAppX(){} // RVA: 0x67BB940
        public void SetUserPreferredCultureInfoInAppX(){} // RVA: 0xB43310
        public void OnCultureInfoChangedInAppX(){} // RVA: 0x686C110
        public void GetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x686C2A0
        public void SetCultureInfoForUserPreferredLanguageInAppX(){} // RVA: 0x686C3A0
        public void get_HasInvariantCultureName(){} // RVA: 0x686C510
        public void VerifyCultureName(){} // RVA: 0x686C770
        public void .cctor(){} // RVA: 0x686C810
    }

    public class CultureNotFoundException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x682B700
        public void GetObjectData(){} // RVA: 0x682B9A0
        public void get_InvalidCultureId(){} // RVA: 0x106A050
        public void get_InvalidCultureName(){} // RVA: 0x106A7D0
        public void get_DefaultMessage(){} // RVA: 0x682BC80
        public void get_FormatedInvalidCultureId(){} // RVA: 0x682BCC0
        public void get_Message(){} // RVA: 0x682BE20
    }

    public class DateTimeFormatInfo : Object
    {
        // ── Methods ──
        public void get_CultureName(){} // RVA: 0x682C010
        public void get_Culture(){} // RVA: 0x682C080
        public void get_LanguageName(){} // RVA: 0x682C140
        public void internalGetAbbreviatedDayOfWeekNames(){} // RVA: 0x682C1B0
        public void internalGetAbbreviatedDayOfWeekNamesCore(){} // RVA: 0x682C1D0
        public void internalGetDayOfWeekNames(){} // RVA: 0x682C290
        public void internalGetDayOfWeekNamesCore(){} // RVA: 0x682C2B0
        public void internalGetAbbreviatedMonthNames(){} // RVA: 0x682C370
        public void internalGetAbbreviatedMonthNamesCore(){} // RVA: 0x682C390
        public void internalGetMonthNames(){} // RVA: 0x682C450
        public void internalGetMonthNamesCore(){} // RVA: 0x682C470
        public void .ctor(){} // RVA: 0x682C700
        public void InitializeOverridableProperties(){} // RVA: 0x682C770
        public void get_InvariantInfo(){} // RVA: 0x682CBF0
        public void get_CurrentInfo(){} // RVA: 0x682CD40
        public void GetInstance(){} // RVA: 0x682CEB0
        public void GetFormat(){} // RVA: 0x682D050
        public void Clone(){} // RVA: 0x682D100
        public void get_AMDesignator(){} // RVA: 0x682D280
        public void get_Calendar(){} // RVA: 0xCD3320
        public void set_Calendar(){} // RVA: 0x682D2F0
        public void get_OptionalCalendars(){} // RVA: 0x682D7A0
        public void get_EraNames(){} // RVA: 0x682D930
        public void GetEraName(){} // RVA: 0x682DA00
        public void get_AbbreviatedEraNames(){} // RVA: 0x682DBA0
        public void GetAbbreviatedEraName(){} // RVA: 0x682DC70
        public void get_AbbreviatedEnglishEraNames(){} // RVA: 0x682DE30
        public void get_DateSeparator(){} // RVA: 0x682DF00
        public void get_FullDateTimePattern(){} // RVA: 0x682DFB0
        public void get_LongDatePattern(){} // RVA: 0x682E080
        public void get_LongTimePattern(){} // RVA: 0x682E120
        public void get_MonthDayPattern(){} // RVA: 0x682E1C0
        public void get_PMDesignator(){} // RVA: 0x682E280
        public void get_RFC1123Pattern(){} // RVA: 0x682E2F0
        public void get_ShortDatePattern(){} // RVA: 0x682E330
        public void get_ShortTimePattern(){} // RVA: 0x682E3D0
        public void get_SortableDateTimePattern(){} // RVA: 0x682E470
        public void get_GeneralShortTimePattern(){} // RVA: 0x682E4B0
        public void get_GeneralLongTimePattern(){} // RVA: 0x682E570
        public void get_DateTimeOffsetPattern(){} // RVA: 0x682E630
        public void get_TimeSeparator(){} // RVA: 0x682E850
        public void get_UniversalSortableDateTimePattern(){} // RVA: 0x682E8C0
        public void get_YearMonthPattern(){} // RVA: 0x682E900
        public void get_AbbreviatedDayNames(){} // RVA: 0x682E9A0
        public void get_DayNames(){} // RVA: 0x682EA30
        public void get_AbbreviatedMonthNames(){} // RVA: 0x682EAC0
        public void get_MonthNames(){} // RVA: 0x682EB50
        public void get_HasSpacesInMonthNames(){} // RVA: 0x682EBE0
        public void get_HasSpacesInDayNames(){} // RVA: 0x682EC10
        public void internalGetMonthName(){} // RVA: 0x682EC40
        public void internalGetGenitiveMonthNames(){} // RVA: 0x682ED90
        public void internalGetLeapYearMonthNames(){} // RVA: 0x682EF40
        public void GetAbbreviatedDayName(){} // RVA: 0x682F010
        public void GetCombinedPatterns(){} // RVA: 0x682F120
        public void GetAllDateTimePatterns(){} // RVA: 0x682F250
        public void GetDayName(){} // RVA: 0x682F700
        public void GetAbbreviatedMonthName(){} // RVA: 0x682F810
        public void GetMonthName(){} // RVA: 0x682F920
        public void GetMergedPatterns(){} // RVA: 0x682FA30
        public void get_AllYearMonthPatterns(){} // RVA: 0x682FC30
        public void get_AllShortDatePatterns(){} // RVA: 0x682FCB0
        public void get_AllShortTimePatterns(){} // RVA: 0x682FD30
        public void get_AllLongDatePatterns(){} // RVA: 0x682FDB0
        public void get_AllLongTimePatterns(){} // RVA: 0x682FE30
        public void get_UnclonedYearMonthPatterns(){} // RVA: 0x682FEB0
        public void get_UnclonedShortDatePatterns(){} // RVA: 0x682FF80
        public void get_UnclonedLongDatePatterns(){} // RVA: 0x6830050
        public void get_UnclonedShortTimePatterns(){} // RVA: 0x6830120
        public void get_UnclonedLongTimePatterns(){} // RVA: 0x68301B0
        public void ReadOnly(){} // RVA: 0x6830240
        public void get_IsReadOnly(){} // RVA: 0x6830470
        public void get_MonthGenitiveNames(){} // RVA: 0x6830510
        public void get_FullTimeSpanPositivePattern(){} // RVA: 0x68305A0
        public void get_FullTimeSpanNegativePattern(){} // RVA: 0x68306E0
        public void get_CompareInfo(){} // RVA: 0x6830790
        public void ValidateStyles(){} // RVA: 0x6830920
        public void get_FormatFlags(){} // RVA: 0x6830A50
        public void InitializeFormatFlags(){} // RVA: 0x6830A70
        public void get_HasForceTwoDigitYears(){} // RVA: 0x6830CC0
        public void get_HasYearMonthAdjustment(){} // RVA: 0x6830D00
        public void YearMonthAdjustment(){} // RVA: 0x6830D30
        public void GetJapaneseCalendarDTFI(){} // RVA: 0x6830E70
        public void GetTaiwanCalendarDTFI(){} // RVA: 0x6831050
        public void ClearTokenHashTable(){} // RVA: 0x6831230
        public void CreateTokenHashTable(){} // RVA: 0x68312B0
        public void PopulateSpecialTokenHashTable(){} // RVA: 0x6831FD0
        public void IsJapaneseCalendar(){} // RVA: 0x6832DB0
        public void AddMonthNames(){} // RVA: 0x6832F20
        public void TryParseHebrewNumber(){} // RVA: 0x6832FF0
        public void IsHebrewChar(){} // RVA: 0x68331F0
        public void IsAllowedJapaneseTokenFollowedByNonSpaceLetter(){} // RVA: 0x6833210
        public void Tokenize(){} // RVA: 0x6833360
        public void InsertAtCurrentHashNode(){} // RVA: 0x6833A90
        public void InsertHash(){} // RVA: 0x6833D00
        public void CompareStringIgnoreCaseOptimized(){} // RVA: 0x6834120
        public void .cctor(){} // RVA: 0x6834250
    }

    public class DateTimeFormatInfoScanner : Object
    {
        // ── Methods ──
        public void get_KnownWords(){} // RVA: 0x6834340
        public void SkipWhiteSpacesAndNonLetter(){} // RVA: 0x68349A0
        public void AddDateWordOrPostfix(){} // RVA: 0x6834A70
        public void AddDateWords(){} // RVA: 0x6834D00
        public void ScanRepeatChar(){} // RVA: 0x6834F60
        public void AddIgnorableSymbols(){} // RVA: 0x6834FC0
        public void ScanDateWord(){} // RVA: 0x6835150
        public void GetDateWordsOfDTFI(){} // RVA: 0x6835400
        public void GetFormatFlagGenitiveMonth(){} // RVA: 0x6835730
        public void GetFormatFlagUseSpaceInMonthNames(){} // RVA: 0x6835780
        public void GetFormatFlagUseSpaceInDayNames(){} // RVA: 0x6835840
        public void GetFormatFlagUseHebrewCalendar(){} // RVA: 0x6835880
        public void EqualStringArrays(){} // RVA: 0x6835890
        public void ArrayElementsHaveSpace(){} // RVA: 0x6835960
        public void ArrayElementsBeginWithDigit(){} // RVA: 0x6835A40
        public void .ctor(){} // RVA: 0x6835C60
    }

    public class DaylightTime : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6835D20
        public void get_Start(){} // RVA: 0xB5DBF0
        public void get_End(){} // RVA: 0xB465B0
        public void get_Delta(){} // RVA: 0xB700F0
    }

    public class DaylightTimeStruct : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8B35F0
    }

    public class EncodingTable : Object
    {
        // ── Methods ──
        public void GetNumEncodingItems(){} // RVA: 0x6859AF0
        public void ENC(){} // RVA: 0x6859B60
        public void MapCodePageDataItem(){} // RVA: 0x6859BD0
        public void .cctor(){} // RVA: 0x6859C40
        public void internalGetCodePageFromName(){} // RVA: 0x6863310
        public void GetCodePageFromName(){} // RVA: 0x68636C0
        public void GetCodePageDataItem(){} // RVA: 0x6863A00
    }

    public class EraInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6849180
    }

    public class FormatProvider : Object
    {
        // ── Methods ──
        public void FormatBigInteger(){} // RVA: 0x72953C0
        public void TryStringToBigInteger(){} // RVA: 0x7295540
    }

    public class GlobalizationMode : Object
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x6841CD0
        public void GetGlobalizationInvariantMode(){} // RVA: 0xB43320
        public void .cctor(){} // RVA: 0x6841D30
    }

    public class GregorianCalendar : Calendar
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x6846810
        public void get_MinSupportedDateTime(){} // RVA: 0x6846900
        public void get_MaxSupportedDateTime(){} // RVA: 0x6846960
        public void get_AlgorithmType(){} // RVA: 0xC3CCE0
        public void GetDefaultInstance(){} // RVA: 0x68469C0
        public void .ctor(){} // RVA: 0x6846B10
        public void get_ID(){} // RVA: 0xFEAE90
        public void GetDatePart(){} // RVA: 0x6846C60
        public void GetAbsoluteDate(){} // RVA: 0x6846E30
        public void DateToTicks(){} // RVA: 0x6847030
        public void AddMonths(){} // RVA: 0x68470B0
        public void AddYears(){} // RVA: 0x68475B0
        public void GetDayOfMonth(){} // RVA: 0x68475D0
        public void GetDayOfWeek(){} // RVA: 0x6847680
        public void GetDayOfYear(){} // RVA: 0x6847740
        public void GetDaysInMonth(){} // RVA: 0x68477F0
        public void GetDaysInYear(){} // RVA: 0x6847B00
        public void GetEra(){} // RVA: 0xC3CCE0
        public void get_Eras(){} // RVA: 0x6847CD0
        public void GetMonth(){} // RVA: 0x6847D30
        public void GetMonthsInYear(){} // RVA: 0x6847DE0
        public void GetYear(){} // RVA: 0x6847F60
        public void IsLeapDay(){} // RVA: 0x6848010
        public void GetLeapMonth(){} // RVA: 0x6848430
        public void IsLeapMonth(){} // RVA: 0x68485A0
        public void IsLeapYear(){} // RVA: 0x6848820
        public void ToDateTime(){} // RVA: 0x68489E0
        public void TryToDateTime(){} // RVA: 0x6848AC0
        public void get_TwoDigitYearMax(){} // RVA: 0x6848BC0
        public void set_TwoDigitYearMax(){} // RVA: 0x6848C40
        public void ToFourDigitYear(){} // RVA: 0x6848D50
        public void .cctor(){} // RVA: 0x6848EC0
    }

    public class GregorianCalendarHelper : Object
    {
        // ── Methods ──
        public void get_MaxYear(){} // RVA: 0xB8F8F0
        public void .ctor(){} // RVA: 0x6849390
        public void GetYearOffset(){} // RVA: 0x68494C0
        public void GetGregorianYear(){} // RVA: 0x6849840
        public void IsValidYear(){} // RVA: 0x6849870
        public void GetDatePart(){} // RVA: 0x6849890
        public void GetAbsoluteDate(){} // RVA: 0x6849A90
        public void DateToTicks(){} // RVA: 0x6849C90
        public void TimeToTicks(){} // RVA: 0x6849D10
        public void CheckTicksRange(){} // RVA: 0x6849EE0
        public void AddMonths(){} // RVA: 0x684A150
        public void AddYears(){} // RVA: 0x684A6B0
        public void GetDayOfMonth(){} // RVA: 0x684A6C0
        public void GetDayOfWeek(){} // RVA: 0x684A770
        public void GetDayOfYear(){} // RVA: 0x684A890
        public void GetDaysInMonth(){} // RVA: 0x684A940
        public void GetDaysInYear(){} // RVA: 0x684AAF0
        public void GetEra(){} // RVA: 0x684AB80
        public void get_Eras(){} // RVA: 0x684ACD0
        public void GetMonth(){} // RVA: 0x684AE50
        public void GetMonthsInYear(){} // RVA: 0x684AF00
        public void GetYear(){} // RVA: 0x684AF20
        public void IsLeapDay(){} // RVA: 0x684B090
        public void GetLeapMonth(){} // RVA: 0x684B210
        public void IsLeapMonth(){} // RVA: 0x684B230
        public void IsLeapYear(){} // RVA: 0x684B350
        public void ToDateTime(){} // RVA: 0x684B3D0
        public void GetWeekOfYear(){} // RVA: 0x684B6C0
        public void ToFourDigitYear(){} // RVA: 0x684B7E0
        public void .cctor(){} // RVA: 0x684B9D0
    }

    public class HebrewNumber : Object
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x6835D50
        public void ParseByChar(){} // RVA: 0x6836170
        public void IsDigit(){} // RVA: 0x6836330
        public void .cctor(){} // RVA: 0x6836400
    }

    public class HebrewNumberParsingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8B3600
    }

    public class HijriCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x684BB70
        public void get_MaxSupportedDateTime(){} // RVA: 0x684BBD0
        public void get_AlgorithmType(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x684BC30
        public void get_ID(){} // RVA: 0x13510C0
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x684BC50
        public void GetAbsoluteDateHijri(){} // RVA: 0x684BC60
        public void DaysUpToHijriYear(){} // RVA: 0x684BD80
        public void get_HijriAdjustment(){} // RVA: 0x684BE40
        public void GetAdvanceHijriDate(){} // RVA: 0xDAC980
        public void CheckTicksRange(){} // RVA: 0x684BEA0
        public void CheckEraRange(){} // RVA: 0x684C120
        public void CheckYearRange(){} // RVA: 0x684C1F0
        public void CheckYearMonthRange(){} // RVA: 0x684C3E0
        public void GetDatePart(){} // RVA: 0x684C5A0
        public void AddMonths(){} // RVA: 0x684C850
        public void AddYears(){} // RVA: 0x68475B0
        public void GetDayOfMonth(){} // RVA: 0x684CC90
        public void GetDayOfWeek(){} // RVA: 0x684CD40
        public void GetDayOfYear(){} // RVA: 0x684CE00
        public void GetDaysInMonth(){} // RVA: 0x684CEB0
        public void GetDaysInYear(){} // RVA: 0x684CF80
        public void GetEra(){} // RVA: 0x684D020
        public void get_Eras(){} // RVA: 0x684D0F0
        public void GetMonth(){} // RVA: 0x684D190
        public void GetMonthsInYear(){} // RVA: 0x684D240
        public void GetYear(){} // RVA: 0x684D2B0
        public void IsLeapDay(){} // RVA: 0x684D360
        public void GetLeapMonth(){} // RVA: 0x684D4D0
        public void IsLeapMonth(){} // RVA: 0x684D530
        public void IsLeapYear(){} // RVA: 0x684D5A0
        public void ToDateTime(){} // RVA: 0x684D620
        public void get_TwoDigitYearMax(){} // RVA: 0x684D830
        public void set_TwoDigitYearMax(){} // RVA: 0x684D8B0
        public void ToFourDigitYear(){} // RVA: 0x684D9C0
        public void .cctor(){} // RVA: 0x684DB50
    }

    public class ISimpleCollator
    {
        // ── Methods ──
        public void GetSortKey(){} // RVA: 0x88B6A0
        public void Compare(){} // RVA: 0x885C70
        public void IsPrefix(){} // RVA: 0x87E060
        public void IsSuffix(){} // RVA: 0x87E060
        public void IndexOf(){} // RVA: 0x887030
        public void LastIndexOf(){} // RVA: 0x887030
    }

    public class IdnMapping : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x686C9E0
        public void Equals(){} // RVA: 0x686CAB0
        public void GetHashCode(){} // RVA: 0x686CB30
        public void GetAscii(){} // RVA: 0x686CC20
        public void Convert(){} // RVA: 0x686CD40
        public void ToAscii(){} // RVA: 0x686D0A0
        public void VerifyLength(){} // RVA: 0x686D500
        public void NamePrep(){} // RVA: 0x686D630
        public void VerifyProhibitedCharacters(){} // RVA: 0x686D750
        public void VerifyStd3AsciiRules(){} // RVA: 0x686D990
        public void GetUnicode(){} // RVA: 0x686DCB0
        public void ToUnicode(){} // RVA: 0x686DDD0
    }

    public class InternalCodePageDataItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InternalEncodingDataItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class JapaneseCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x684DD00
        public void get_MaxSupportedDateTime(){} // RVA: 0x684DD60
        public void get_AlgorithmType(){} // RVA: 0xC3CCE0
        public void GetEraInfo(){} // RVA: 0x684DDC0
        public void GetErasFromRegistry(){} // RVA: 0xDAC980
        public void GetDefaultInstance(){} // RVA: 0x684E460
        public void .ctor(){} // RVA: 0x684E5A0
        public void get_ID(){} // RVA: 0x12FC4A0
        public void AddMonths(){} // RVA: 0x684E760
        public void AddYears(){} // RVA: 0x684E780
        public void GetDaysInMonth(){} // RVA: 0x684E7B0
        public void GetDaysInYear(){} // RVA: 0x684E7E0
        public void GetDayOfMonth(){} // RVA: 0x684E800
        public void GetDayOfWeek(){} // RVA: 0x684E820
        public void GetDayOfYear(){} // RVA: 0x684E840
        public void GetMonthsInYear(){} // RVA: 0x684E860
        public void GetWeekOfYear(){} // RVA: 0x684E890
        public void GetEra(){} // RVA: 0x684E8C0
        public void GetMonth(){} // RVA: 0x684E8E0
        public void GetYear(){} // RVA: 0x684E900
        public void IsLeapDay(){} // RVA: 0x684E920
        public void IsLeapYear(){} // RVA: 0x684E950
        public void GetLeapMonth(){} // RVA: 0x684E970
        public void IsLeapMonth(){} // RVA: 0x684E9A0
        public void ToDateTime(){} // RVA: 0x684E9D0
        public void ToFourDigitYear(){} // RVA: 0x684EA00
        public void get_Eras(){} // RVA: 0x684EBA0
        public void EraNames(){} // RVA: 0x684EBC0
        public void EnglishEraNames(){} // RVA: 0x684ED00
        public void IsValidYear(){} // RVA: 0x684EE40
        public void get_TwoDigitYearMax(){} // RVA: 0x684EE70
        public void set_TwoDigitYearMax(){} // RVA: 0x684EEF0
        public void .cctor(){} // RVA: 0x684F030
    }

    public class NumberFormatInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x684F240
        public void OnSerializing(){} // RVA: 0x684F0D0
        public void OnDeserializing(){} // RVA: 0xB43310
        public void OnDeserialized(){} // RVA: 0xB43310
        public void VerifyWritable(){} // RVA: 0x684FCE0
        public void get_InvariantInfo(){} // RVA: 0x684FD60
        public void GetInstance(){} // RVA: 0x684FED0
        public void Clone(){} // RVA: 0x6850070
        public void get_CurrencyDecimalDigits(){} // RVA: 0x295D4E0
        public void get_CurrencyDecimalSeparator(){} // RVA: 0xBE58B0
        public void get_IsReadOnly(){} // RVA: 0x1A6FCB0
        public void get_CurrencyGroupSizes(){} // RVA: 0x68500E0
        public void get_NumberGroupSizes(){} // RVA: 0x6850160
        public void get_PercentGroupSizes(){} // RVA: 0x68501E0
        public void get_CurrencyGroupSeparator(){} // RVA: 0xBBF8F0
        public void get_CurrencySymbol(){} // RVA: 0xC0FFC0
        public void get_CurrentInfo(){} // RVA: 0x6850260
        public void get_NaNSymbol(){} // RVA: 0xBBFF90
        public void set_NaNSymbol(){} // RVA: 0x68503B0
        public void get_CurrencyNegativePattern(){} // RVA: 0x215C150
        public void get_NumberNegativePattern(){} // RVA: 0x14354E0
        public void get_PercentPositivePattern(){} // RVA: 0xE35F30
        public void get_PercentNegativePattern(){} // RVA: 0x485F8A0
        public void get_NegativeInfinitySymbol(){} // RVA: 0xCD3320
        public void get_NegativeSign(){} // RVA: 0xD33E60
        public void get_NumberDecimalDigits(){} // RVA: 0x68504E0
        public void get_NumberDecimalSeparator(){} // RVA: 0xD05CA0
        public void get_NumberGroupSeparator(){} // RVA: 0xBC1B30
        public void get_CurrencyPositivePattern(){} // RVA: 0x68504F0
        public void get_PositiveInfinitySymbol(){} // RVA: 0xC10050
        public void get_PositiveSign(){} // RVA: 0xB70160
        public void get_PercentDecimalDigits(){} // RVA: 0x12CE7D0
        public void get_PercentDecimalSeparator(){} // RVA: 0xCD48B0
        public void get_PercentGroupSeparator(){} // RVA: 0xB813B0
        public void get_PercentSymbol(){} // RVA: 0x1069350
        public void get_PerMilleSymbol(){} // RVA: 0x106A7D0
        public void GetFormat(){} // RVA: 0x6850500
        public void ReadOnly(){} // RVA: 0x68505B0
        public void ValidateParseStyleInteger(){} // RVA: 0x6850680
        public void ValidateParseStyleFloatingPoint(){} // RVA: 0x6850770
    }

    public class Punycode : Bootstring
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x686EA00
    }

    public class RegionInfo : Object
    {
        // ── Methods ──
        public void get_CurrentRegion(){} // RVA: 0x686EA40
        public void .ctor(){} // RVA: 0x686EEE0
        public void GetByTerritory(){} // RVA: 0x686F370
        public void construct_internal_region_from_name(){} // RVA: 0x686F420
        public void get_CurrencyEnglishName(){} // RVA: 0xBE58B0
        public void get_CurrencySymbol(){} // RVA: 0xBC1B30
        public void get_DisplayName(){} // RVA: 0xD33E60
        public void get_EnglishName(){} // RVA: 0xD33E60
        public void get_GeoId(){} // RVA: 0xB8F8F0
        public void get_IsMetric(){} // RVA: 0x686F5D0
        public void get_ISOCurrencySymbol(){} // RVA: 0xBBF8F0
        public void get_NativeName(){} // RVA: 0xD05CA0
        public void get_CurrencyNativeName(){} // RVA: 0xC0FFC0
        public void get_Name(){} // RVA: 0xB465B0
        public void get_ThreeLetterISORegionName(){} // RVA: 0xB700F0
        public void get_ThreeLetterWindowsRegionName(){} // RVA: 0xB70160
        public void get_TwoLetterISORegionName(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x686F6A0
        public void GetHashCode(){} // RVA: 0x686F790
        public void ToString(){} // RVA: 0x686F7D0
        public void ClearCachedData(){} // RVA: 0x686F7F0
    }

    public class SortKey : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6856A40
        public void .ctor(){} // RVA: 0x6857140
        public void get_OriginalString(){} // RVA: 0xB5DBF0
        public void get_KeyData(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6856EF0
        public void GetHashCode(){} // RVA: 0x6856F90
        public void ToString(){} // RVA: 0x6857000
    }

    public class StringInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68508A0
        public void OnDeserializing(){} // RVA: 0x1417AC0
        public void OnDeserialized(){} // RVA: 0x68509E0
        public void Equals(){} // RVA: 0x6850A50
        public void GetHashCode(){} // RVA: 0x1269730
        public void get_Indexes(){} // RVA: 0x6850B20
        public void get_String(){} // RVA: 0xB5DBF0
        public void set_String(){} // RVA: 0x68508A0
        public void get_LengthInTextElements(){} // RVA: 0x6850BB0
        public void GetCurrentTextElementLen(){} // RVA: 0x6850BF0
        public void ParseCombiningCharacters(){} // RVA: 0x6850E20
    }

    public class TaiwanCalendar : Calendar
    {
        // ── Methods ──
        public void GetDefaultInstance(){} // RVA: 0x68510E0
        public void get_MinSupportedDateTime(){} // RVA: 0x6851220
        public void get_MaxSupportedDateTime(){} // RVA: 0x6851280
        public void get_AlgorithmType(){} // RVA: 0xC3CCE0
        public void .ctor(){} // RVA: 0x68512E0
        public void get_ID(){} // RVA: 0x1347420
        public void AddMonths(){} // RVA: 0x684E760
        public void AddYears(){} // RVA: 0x684E780
        public void GetDaysInMonth(){} // RVA: 0x684E7B0
        public void GetDaysInYear(){} // RVA: 0x684E7E0
        public void GetDayOfMonth(){} // RVA: 0x684E800
        public void GetDayOfWeek(){} // RVA: 0x684E820
        public void GetDayOfYear(){} // RVA: 0x684E840
        public void GetMonthsInYear(){} // RVA: 0x684E860
        public void GetWeekOfYear(){} // RVA: 0x684E890
        public void GetEra(){} // RVA: 0x684E8C0
        public void GetMonth(){} // RVA: 0x684E8E0
        public void GetYear(){} // RVA: 0x684E900
        public void IsLeapDay(){} // RVA: 0x684E920
        public void IsLeapYear(){} // RVA: 0x684E950
        public void GetLeapMonth(){} // RVA: 0x684E970
        public void IsLeapMonth(){} // RVA: 0x684E9A0
        public void ToDateTime(){} // RVA: 0x684E9D0
        public void get_Eras(){} // RVA: 0x684EBA0
        public void get_TwoDigitYearMax(){} // RVA: 0x684EE70
        public void set_TwoDigitYearMax(){} // RVA: 0x68514B0
        public void ToFourDigitYear(){} // RVA: 0x68515F0
        public void .cctor(){} // RVA: 0x6851790
    }

    public class TextInfo : Object
    {
        // ── Methods ──
        public void get_Invariant(){} // RVA: 0x6851950
        public void .ctor(){} // RVA: 0x6853D60
        public void OnDeserializing(){} // RVA: 0x6851B80
        public void OnDeserialized(){} // RVA: 0x6851DF0
        public void OnSerializing(){} // RVA: 0x6851E00
        public void get_CultureName(){} // RVA: 0xD33E60
        public void get_IsReadOnly(){} // RVA: 0xB5DD50
        public void Clone(){} // RVA: 0x6851EE0
        public void ReadOnly(){} // RVA: 0x6851F60
        public void SetReadOnlyState(){} // RVA: 0xB5DD60
        public void get_ListSeparator(){} // RVA: 0x6852040
        public void ToLower(){} // RVA: 0x6852120
        public void ToLowerAsciiInvariant(){} // RVA: 0x6852230
        public void ToUpper(){} // RVA: 0x68522B0
        public void ToUpperAsciiInvariant(){} // RVA: 0x6853B70
        public void IsAscii(){} // RVA: 0x68523E0
        public void get_IsAsciiCasingSameAsInvariant(){} // RVA: 0x68523F0
        public void Equals(){} // RVA: 0x6852540
        public void GetHashCode(){} // RVA: 0x6852610
        public void ToString(){} // RVA: 0x6852640
        public void ToTitleCase(){} // RVA: 0x68526A0
        public void AddNonLetter(){} // RVA: 0x6852B60
        public void AddTitlecaseLetter(){} // RVA: 0x6852C20
        public void IsWordSeparator(){} // RVA: 0x6852E40
        public void IsLetterCategory(){} // RVA: 0x6852E50
        public void get_IsRightToLeft(){} // RVA: 0x6852E60
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x6851DF0
        public void ToUpperInternal(){} // RVA: 0x6853000
        public void ToLowerInternal(){} // RVA: 0x6853630
        public void ChangeCase(){} // RVA: 0x6853C30
    }

    public class TextInfoToLowerData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x68642F0
    }

    public class TextInfoToUpperData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6863D90
    }

    public class ThaiBuddhistCalendar : Calendar
    {
        // ── Methods ──
        public void get_MinSupportedDateTime(){} // RVA: 0x6853D90
        public void get_MaxSupportedDateTime(){} // RVA: 0x6853DF0
        public void get_AlgorithmType(){} // RVA: 0xC3CCE0
        public void .ctor(){} // RVA: 0x6853E50
        public void get_ID(){} // RVA: 0x132D270
        public void AddMonths(){} // RVA: 0x684E760
        public void AddYears(){} // RVA: 0x684E780
        public void GetDaysInMonth(){} // RVA: 0x684E7B0
        public void GetDaysInYear(){} // RVA: 0x684E7E0
        public void GetDayOfMonth(){} // RVA: 0x684E800
        public void GetDayOfWeek(){} // RVA: 0x684E820
        public void GetDayOfYear(){} // RVA: 0x684E840
        public void GetMonthsInYear(){} // RVA: 0x684E860
        public void GetWeekOfYear(){} // RVA: 0x684E890
        public void GetEra(){} // RVA: 0x684E8C0
        public void GetMonth(){} // RVA: 0x684E8E0
        public void GetYear(){} // RVA: 0x684E900
        public void IsLeapDay(){} // RVA: 0x684E920
        public void IsLeapYear(){} // RVA: 0x684E950
        public void GetLeapMonth(){} // RVA: 0x684E970
        public void IsLeapMonth(){} // RVA: 0x684E9A0
        public void ToDateTime(){} // RVA: 0x684E9D0
        public void get_Eras(){} // RVA: 0x684EBA0
        public void get_TwoDigitYearMax(){} // RVA: 0x6853F50
        public void set_TwoDigitYearMax(){} // RVA: 0x6853FD0
        public void ToFourDigitYear(){} // RVA: 0x6854110
        public void .cctor(){} // RVA: 0x68541D0
    }

    public class TimeSpanFormat : Object
    {
        // ── Methods ──
        public void AppendNonNegativeInt32(){} // RVA: 0x6836870
        public void Format(){} // RVA: 0x68369F0
        public void TryFormat(){} // RVA: 0x6836AF0
        public void FormatToBuilder(){} // RVA: 0x6836BF0
        public void FormatStandard(){} // RVA: 0x6836F10
        public void FormatCustomized(){} // RVA: 0x6837510
        public void .cctor(){} // RVA: 0x6837D60
    }

    public class TimeSpanParse : Object
    {
        // ── Methods ──
        public void Pow10(){} // RVA: 0x68387B0
        public void TryTimeToTicks(){} // RVA: 0x68388B0
        public void Parse(){} // RVA: 0x6838A70
        public void TryParse(){} // RVA: 0x6838AB0
        public void ParseExact(){} // RVA: 0x6838B10
        public void TryParseExact(){} // RVA: 0x6838B60
        public void ParseExactMultiple(){} // RVA: 0x6838BD0
        public void TryParseExactMultiple(){} // RVA: 0x6838C10
        public void TryParseTimeSpan(){} // RVA: 0x6838C70
        public void ProcessTerminalState(){} // RVA: 0x6839E20
        public void ProcessTerminal_DHMSF(){} // RVA: 0x6839F90
        public void ProcessTerminal_HMS_F_D(){} // RVA: 0x683A3E0
        public void ProcessTerminal_HM_S_D(){} // RVA: 0x683BE90
        public void ProcessTerminal_HM(){} // RVA: 0x683D4F0
        public void ProcessTerminal_D(){} // RVA: 0x683D830
        public void TryParseExactTimeSpan(){} // RVA: 0x683DB40
        public void TryParseByFormat(){} // RVA: 0x683DCE0
        public void ParseExactDigits(){} // RVA: 0x683E8D0
        public void ParseExactLiteral(){} // RVA: 0x683E9B0
        public void TryParseTimeSpanConstant(){} // RVA: 0x683EA70
        public void TryParseExactMultipleTimeSpan(){} // RVA: 0x683EAB0
    }

    public class UmAlQuraCalendar : Calendar
    {
        // ── Methods ──
        public void InitDateMapping(){} // RVA: 0x6854340
        public void get_MinSupportedDateTime(){} // RVA: 0x6854520
        public void get_MaxSupportedDateTime(){} // RVA: 0x6854580
        public void get_AlgorithmType(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x6841E30
        public void get_BaseCalendarID(){} // RVA: 0x13510C0
        public void get_ID(){} // RVA: 0x10AC210
        public void get_DaysInYearBeforeMinSupportedYear(){} // RVA: 0x68545E0
        public void ConvertHijriToGregorian(){} // RVA: 0x68545F0
        public void GetAbsoluteDateUmAlQura(){} // RVA: 0x6854860
        public void CheckTicksRange(){} // RVA: 0x6854930
        public void CheckEraRange(){} // RVA: 0x6854BB0
        public void CheckYearRange(){} // RVA: 0x6854C40
        public void CheckYearMonthRange(){} // RVA: 0x6854DF0
        public void ConvertGregorianToHijri(){} // RVA: 0x6854ED0
        public void GetDatePart(){} // RVA: 0x68552F0
        public void AddMonths(){} // RVA: 0x68554D0
        public void AddYears(){} // RVA: 0x68475B0
        public void GetDayOfMonth(){} // RVA: 0x68558B0
        public void GetDayOfWeek(){} // RVA: 0x68558D0
        public void GetDayOfYear(){} // RVA: 0x6855990
        public void GetDaysInMonth(){} // RVA: 0x68559B0
        public void RealGetDaysInYear(){} // RVA: 0x6855A70
        public void GetDaysInYear(){} // RVA: 0x6855B20
        public void GetEra(){} // RVA: 0x6855B90
        public void get_Eras(){} // RVA: 0x6855C50
        public void GetMonth(){} // RVA: 0x6855CB0
        public void GetMonthsInYear(){} // RVA: 0x6855CD0
        public void GetYear(){} // RVA: 0x6855D40
        public void IsLeapDay(){} // RVA: 0x6855D60
        public void GetLeapMonth(){} // RVA: 0x6855EF0
        public void IsLeapMonth(){} // RVA: 0x6855F50
        public void IsLeapYear(){} // RVA: 0x6855FC0
        public void ToDateTime(){} // RVA: 0x6856030
        public void get_TwoDigitYearMax(){} // RVA: 0x684D830
        public void set_TwoDigitYearMax(){} // RVA: 0x68562F0
        public void ToFourDigitYear(){} // RVA: 0x6856410
        public void .cctor(){} // RVA: 0x68565A0
    }

}