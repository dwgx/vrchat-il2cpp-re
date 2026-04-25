// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel
// Classes: 9
// Methods: 125

namespace VRC.DataModel
{
    public class CalendarSearchFilters : Object
    {
        public System.Collections.Generic.List`1<string> Categories; // 0x10
        public System.Collections.Generic.List`1<string> Platforms; // 0x18
        public System.Collections.Generic.List`1<string> Languages; // 0x20
        public int WeekDay; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC48AAA00
        public void Equals(){} // RVA: 0x7FFAC48AAA80
        public void GetHashCode(){} // RVA: 0x7FFAC48AAC30
        public void op_Implicit(){} // RVA: 0x7FFAC48AAC80
        public void CompareBaseObjects(){} // RVA: 0x7FFAC48AACD0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC48AAD50
        public void GetCachedPtr(){} // RVA: 0x7FFAC48AAF00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC48AAC30
    }

    public class EmojiMask : Object
    {
        public string Tag; // 0x10
        public UnityEngine.Texture2D Mask; // 0x18
        public UnityEngine.Sprite Overlay; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class KeyboardData : Object
    {
        public VRC.Localization.LocalizableString ActiveRequest; // 0x10
        public VRC.Localization.LocalizableString Title; // 0x38
        public 0x6B16C2C8 PlaceholderText; // 0x60
        public 0x6B16C320 InputType; // 0x64
        public int ContentType; // 0x68
        public 0x6B21A488 CharacterLimit; // 0x6C
        public 0x6B21A430 KeyboardType; // 0x70
        public int KeyboardRadioButtonGroup; // 0x74
        public bool DefaultRadioButtonGroupValue; // 0x78
        public bool Multiline; // 0x79
        public VRC.Localization.LocalizableString ReadOnly; // 0x80
        public VRC.Localization.LocalizableString PreviousInput; // 0xA8
        public bool OnInputChanged; // 0xD0
        public ÎÌÍÏÏÏÌÍÌÌÍÎÍÍÏÍÌÎÍÏÌÏÎ OnInputSubmitted; // 0xD8
        public string OnInputCanceled; // 0xE0
        public System.Action`1<string> OnRadioOptionSet; // 0xE8
        public System.Action`1<string> IsWorldKeyboard; // 0xF0
        public System.Action StayOpenAfterSubmit; // 0xF8
        public System.Action`1<int> SubmitButtonText; // 0x100
        public bool CancelButtonText; // 0x108

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48B49F0
        public void Initialize(){} // RVA: 0x7FFAC48B4C60
        public void get_PlaceholderText(){} // RVA: 0x7FFAC35DB780
        public void set_SocketFlags(){} // RVA: 0x7FFAC48B4C80
        public void get_Title(){} // RVA: 0x7FFAC3813C20
        public void get_CharacterLimit(){} // RVA: 0x7FFAC43D9E20
        public void set_OnInputCanceled(){} // RVA: 0x7FFAC34A4860
        public void set_CharacterLimit(){} // RVA: 0x7FFAC48B4C80
        public void set_name(){} // RVA: 0x7FFAC48B4C90
        public void set_OnRadioOptionSet(){} // RVA: 0x7FFAC34F6750
        public void get_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFAC47BAB50
        public void get_OnInputCanceled(){} // RVA: 0x7FFAC3331F50
        public void set_KeyboardRadioButtonGroup(){} // RVA: 0x7FFAC48B4C90
        public void get_KeyboardRadioButtonGroup(){} // RVA: 0x7FFAC3138CA0
        public void get_StayOpenAfterSubmit(){} // RVA: 0x7FFAC4196030
        public void Instantiate(){} // RVA: 0x7FFAC48B4DC0
        public void get_OnRadioOptionSet(){} // RVA: 0x7FFAC34F6C80
        public void get_OnInputSubmitted(){} // RVA: 0x7FFAC2F8C2A0
        public void get_OnInputChanged(){} // RVA: 0x7FFAC2FA2970
        public void Destroy(){} // RVA: 0x7FFAC48B50C0
        public void set_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFAC47BAB60
        public void get_ContentType(){} // RVA: 0x7FFAC3B99E80
        public void get_ScreenshotCompression(){} // RVA: 0x7FFAC3138C20
        public void FindObjectsOfType(){} // RVA: 0x7FFAC48B50C0
        public void set_ActiveRequest(){} // RVA: 0x7FFAC2FA28A0
        public void get_CancelButtonText(){} // RVA: 0x7FFAC48B50D0
        public void get_KeyboardType(){} // RVA: 0x7FFAC3138C20
        public void set_OnInputChanged(){} // RVA: 0x7FFAC2FA2980
        public void get_IsWorldKeyboard(){} // RVA: 0x7FFAC33CFDE0
        public void get_PreviousInput(){} // RVA: 0x7FFAC2FA2900
        public void get_ReadOnly(){} // RVA: 0x7FFAC33CC650
        public void set_ReadOnly(){} // RVA: 0x7FFAC48B5100
        public void set_PreviousInput(){} // RVA: 0x7FFAC2FA2910
        public void get_ActiveRequest(){} // RVA: 0x7FFAC3540F70
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFAC47BAB70
        public void get_SubmitButtonText(){} // RVA: 0x7FFAC35C9610
        public void get_Multiline(){} // RVA: 0x7FFAC33CE5C0
        public void get_InputType(){} // RVA: 0x7FFAC47BAB70
        public void set_ipsQuery(){} // RVA: 0x7FFAC2F8C2B0
        public void set_OnInputSubmitted(){} // RVA: 0x7FFAC2F8C2B0
        public void set_StayOpenAfterSubmit(){} // RVA: 0x7FFAC4196040
        public void op_Inequality(){} // RVA: 0x7FFAC48B54A0
    }

    public class QuitHandler : Object
    {
        public VRC.DataModel.QuitHandler ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ;
        public System.Collections.Generic.List`1<ÎÎÌÏÎÍÏÌÎÍÍÏÌÏÎÌÏÏÏÌÎÏÌ> ÍÌÍÏÏÌÍÍÎÍÎÏÌÎÏÍÏÍÍÏÍÏÍ; // 0x10
        public 0x6B030FA0 ÌÎÏÎÍÎÏÍÍÏÌÍÌÏÎÏÍÌÍÌÌÎÏ; // 0x18
        public float ÍÍÌÌÏÌÎÏÏÏÏÍÎÌÍÍÌÏÎÌÏÍÍ;
        public float ÍÌÍÎÎÎÍÏÌÎÌÏÏÎÏÌÎÎÎÏÏÌÍ; // 0x1C

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3525DA0
        public void .ctor(){} // RVA: 0x7FFAC3525F20
        public void Equals(){} // RVA: 0x7FFAC3525FE0
        public void op_Implicit(){} // RVA: 0x7FFAC3526040
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3526170
        public void Initialize(){} // RVA: 0x7FFAC35261D0
        public void GetCachedPtr(){} // RVA: 0x7FFAC3526350
        public void get_name(){} // RVA: 0x7FFAC35263B0
        public void set_name(){} // RVA: 0x7FFAC3526540
        public void Instantiate(){} // RVA: 0x7FFAC35266C0
        public void GetHashCode(){} // RVA: 0x7FFAC3526890
        public void .cctor(){} // RVA: 0x7FFAC35269C0
        public void ToString(){} // RVA: 0x7FFAC3526B20
    }

    public class SearchInFieldsUser : Object
    {
        public bool FieldDescriptions; // 0x10
        public bool Bio; // 0x11
        public bool DefaultName;
        public bool DefaultBio;
        public 0x6B16ED10 SearchContentType; // 0x14

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC48A9F20
        public void .ctor(){} // RVA: 0x7FFAC37C9DD0 | overloaded x2
        public void set_name(){} // RVA: 0x7FFAC37C9DD0 | overloaded x2
        public void set_FieldDescriptions(){} // RVA: 0x7FFAC48AA0B0
        public void get_FieldDescriptions(){} // RVA: 0x7FFAC48AA0D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC48AA180
        public void GetCachedPtr(){} // RVA: 0x7FFAC48AA1A0
        public void Instantiate(){} // RVA: 0x7FFAC48AA0B0
        public void Equals(){} // RVA: 0x7FFAC48A9F20
        public void ToString(){} // RVA: 0x7FFAC48AA220
        public void GetHashCode(){} // RVA: 0x7FFAC48AA270
        // ── Unresolved (hash) ──
        public void m_F71(){} // RVA: 0x7FFAC48AA3C0
    }

    public class SearchInFieldsWorld : Object
    {
        public bool FieldDescriptions; // 0x10
        public bool Tags; // 0x11
        public bool Description; // 0x12
        public bool Author; // 0x13
        public bool DefaultTitle;
        public bool DefaultTags;
        public bool DefaultDescription;
        public bool DefaultAuthor;
        public 0x6B16ED10 SearchContentType; // 0x14

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC48A91B0
        public void set_FieldDescriptions(){} // RVA: 0x7FFAC48A9230
        public void Equals(){} // RVA: 0x7FFAC48A92D0
        public void get_FieldDescriptions(){} // RVA: 0x7FFAC48A9350
        public void CompareBaseObjects(){} // RVA: 0x7FFAC48A9400
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4881760
        public void GetCachedPtr(){} // RVA: 0x7FFAC4881780
        public void ToString(){} // RVA: 0x7FFAC48A95A0
        public void set_name(){} // RVA: 0x7FFAC48A95F0
        public void Instantiate(){} // RVA: 0x7FFAC48A9670
        public void GetHashCode(){} // RVA: 0x7FFAC48A9740 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC48A96B0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC48A98F0
        // ── Unresolved (hash) ──
        public void m_C8D(){} // RVA: 0x7FFAC48A96C0
        public void m_7DD(){} // RVA: 0x7FFAC4881780
        public void m_624(){} // RVA: 0x7FFAC48A9970
    }

    public class SearchParameters : Object
    {
        public string IsWorldsSearch;
        public 0x6B16ED10 SearchTypeDescription; // 0x10
        public 0x6B16EE70 DefaultIncludeCommunityLabs; // 0x14
        public string SearchQuery; // 0x18
        public VRC.Localization.LocalizableString SearchTitle; // 0x20
        public string SearchQueryInitial; // 0x48
        public float SearchQuerySimilarity; // 0x50
        public int SearchCount; // 0x54
        public 0x6B16ED68 WorldSort; // 0x58
        public 0x6B16EDC0 UserSort; // 0x5C
        public 0x6B16EE18 GroupSort; // 0x60
        public VRC.DataModel.SearchInFieldsWorld WorldSearchInFields; // 0x68
        public VRC.DataModel.SearchInFieldsUser UserSearchInFields; // 0x70
        public VRC.DataModel.CalendarSearchFilters CalendarSearchFilters; // 0x78
        public bool IncludeCommunityLabs; // 0x80
        public bool IsRefined; // 0x81
        public 0x6B16EDC0 DefaultUserSort;
        public 0x6B16ED68 DefaultWorldSort;
        public 0x6B16EE18 DefaultGroupSort;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC48AB0B0
        public void set_SearchTypeDescription(){} // RVA: 0x7FFAC48AB160
        public void Equals(){} // RVA: 0x7FFAC48AB220
        public void op_Implicit(){} // RVA: 0x7FFAC48AB5B0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC48AB940
        public void get_SearchTypeDescription(){} // RVA: 0x7FFAC48ABCD0
        public void set_IsWorldsSearch(){} // RVA: 0x7FFAC48ABD60
        public void get_IsWorldsSearch(){} // RVA: 0x7FFAC48ABE10
        public void set_name(){} // RVA: 0x7FFAC48ABE30
        public void .ctor(){} // RVA: 0x7FFAC48AC070
        public void get_DefaultIncludeCommunityLabs(){} // RVA: 0x7FFAC48AC2E0
        public void set_DefaultIncludeCommunityLabs(){} // RVA: 0x7FFAC48AC370
        public void Instantiate(){} // RVA: 0x7FFAC48AC620
        public void GetHashCode(){} // RVA: 0x7FFAC48AC850
        public void ToString(){} // RVA: 0x7FFAC48AC860
        public void Destroy(){} // RVA: 0x7FFAC48ACDB0
        // ── Unresolved (hash) ──
        public void m_C8D(){} // RVA: 0x7FFAC48ACA50
        public void m_CF2(){} // RVA: 0x7FFAC48ACC20
        public void m_1F4(){} // RVA: 0x7FFAC48ACCB0
        public void m_239(){} // RVA: 0x7FFAC48ACD40
    }

    public class SupportedPlatformData : Object
    {
        public 0x6B169720 Platform; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VRCData : Object
    {
        public ÎÎÎÎÍÍÌÏÍÎÍÏÏÍÍÎÌÌÌÎÍÌÎ _vRCData;
        public ÌÏÎÎÍÌÍÍÏÌÍÎÍÌÌÏÏÏÎÎÎÎÌ ÍÌÏÎÏÎÏÏÌÌÍÌÌÌÎÌÌÏÌÍÏÎÎ; // 0x8
        public ÎÏÌÌÎÏÎÍÍÏÎÌÏÎÍÌÎÌÌÎÎÏÌ ÎÏÎÎÍÎÌÍÍÎÍÌÏÎÌÏÎÎÌÎÍÍÌ; // 0x10
        public ÏÏÌÍÎÌÍÌÎÏÎÏÎÏÌÌÍÎÏÏÌÌÎ ÎÌÏÏÍÎÌÎÌÎÎÏÎÌÍÍÍÌÏÌÌÌÌ; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<ÎÌÏÏÍÎÏÍÎÎÏÌÎÌÌÌÎÍÍÍÏÍÌ> <ÍÌÍÎÏÎÏÎÎÎÍÎÌÎÏÍÌÍÍÎÌÌÎ>k__BackingField; // 0x20
        public ÎÎÌÎÏÎÍÌÍÏÌÎÏÍÌÏÌÌÎÏÏÌÏ ÌÍÏÌÏÌÍÌÌÍÌÌÌÎÏÍÎÌÍÌÏÎÎ; // 0x28
        public ÎÎÌÍÌÍÎÏÏÍÌÍÏÎÎÍÎÏÎÏÎÏÍ ÎÏÍÎÏÍÌÏÌÏÍÍÎÌÏÌÎÏÌÌÍÏÎ; // 0x30
        public ÏÍÌÌÍÎÍÌÏÎÌÎÎÎÌÎÌÌÎÍÏÏÎ ÏÌÏÎÎÎÍÌÏÏÍÎÎÎÌÎÎÏÍÍÏÌÎ; // 0x38
        public ÏÏÍÌÎÍÍÎÎÌÍÌÎÎÌÍÌÍÎÍÌÌÌ ÏÌÍÎÌÏÎÏÍÏÍÌÌÌÎÏÏÎÍÎÍÌÎ; // 0x40
        public ÎÍÌÎÏÏÍÍÌÍÏÏÌÏÎÎÎÏÏÎÏÎÎ ÌÏÎÌÎÏÎÎÎÏÏÍÎÎÏÍÎÌÍÏÍÎÌ; // 0x48
        public ÌÏÎÏÏÏÎÎÏÌÎÌÌÍÏÎÌÏÍÎÍÎÍ ÌÌÍÌÌÍÏÏÌÎÏÌÍÌÎÏÏÏÏÏÏÎÏ; // 0x50
        public ÌÌÍÎÍÌÌÌÌÍÍÍÏÎÎÍÎÏÎÍÍÏÎ ÏÏÍÏÏÌÌÍÏÍÌÍÏÍÎÏÎÏÍÌÏÏÏ; // 0x58
        public ÏÎÌÎÍÌÍÏÏÍÏÎÎÎÎÎÏÌÏÎÌÏÏ ÍÌÍÍÌÎÏÌÌÏÍÌÎÌÏÎÏÏÍÍÌÎÎ; // 0x60
        public ÍÌÍÍÏÎÍÍÎÎÍÏÎÍÎÎÍÏÌÍÍÏÌ ÎÍÏÏÎÎÍÏÌÍÍÎÏÌÏÏÌÌÍÍÌÏÌ; // 0x68
        public ÎÏÏÌÏÏÍÎÏÍÍÍÌÏÌÌÍÎÍÏÌÏÌ ÏÍÎÎÎÌÍÌÍÏÍÎÍÍÏÎÏÎÎÍÎÍÎ; // 0x70
        public ÌÌÌÎÍÏÌÎÍÎÍÍÏÍÍÌÌÍÏÏÌÏÍ ÎÏÎÏÍÍÏÎÎÌÏÌÍÍÎÎÏÎÎÍÌÍÏ; // 0x78
        public ÌÍÌÎÍÍÎÏÌÎÍÎÌÍÎÌÏÌÏÍÌÏÏ ÌÏÎÎÍÏÏÌÍÏÍÌÍÍÎÏÍÍÌÍÏÍÌ; // 0x80
        public ÌÏÍÍÏÌÏÏÏÎÏÌÌÍÏÏÎÏÎÍÌÏÏ ÎÍÏÏÏÎÌÎÎÎÌÏÌÏÍÍÍÏÏÍÍÌÎ; // 0x88
        public ÎÏÌÏÌÍÌÎÌÍÍÌÎÌÏÍÎÎÌÌÏÎÎ ÌÏÎÍÏÌÍÌÌÎÌÍÌÎÍÍÎÌÌÌÏÎÌ; // 0x90
        public ÎÌÏÏÌÍÍÏÏÍÏÌÍÍÏÎÌÌÌÎÌÎÍ ÍÌÏÏÏÌÎÏÍÏÎÎÌÌÍÌÎÎÌÏÍÏÍ; // 0x98
        public ÏÏÍÏÌÎÌÌÎÏÍÌÎÏÏÏÏÍÌÌÏÎÌ ÍÏÍÏÎÎÎÎÌÍÍÏÌÎÍÍÎÌÍÏÏÍÎ; // 0xA0
        public ÌÎÍÏÏÎÌÍÎÍÍÏÌÏÎÎÏÍÎÏÎÍÎ ÏÎÏÌÍÏÍÌÌÌÌÌÌÌÍÏÍÌÌÌÍÌÌ; // 0xA8
        public ÎÌÍÌÏÌÌÍÎÏÏÏÌÎÌÌÌÏÍÏÏÍÏ ÍÍÎÍÎÍÍÍÎÏÍÎÎÍÎÎÍÏÍÌÌÌÍ; // 0xB0
        public ÍÏÏÌÌÏÍÎÌÎÍÍÏÍÌÎÎÎÌÌÌÍÍ ÎÏÎÏÌÌÏÌÌÏÎÎÍÏÎÌÎÍÎÎÎÌÎ; // 0xB8
        public ÎÏÍÏÏÎÌÍÎÌÎÍÏÍÏÎÌÏÎÌÍÏÎ ÌÏÏÍÍÏÏÌÎÌÎÏÏÌÍÍÍÌÎÏÏÍÍ; // 0xC0
        public ÍÍÏÏÍÎÎÌÎÌÌÍÌÍÏÌÎÍÎÎÌÎÎ ÍÌÍÏÏÎÎÏÌÏÏÏÏÍÍÎÏÍÍÏÌÌÎ; // 0xC8
        public ÏÌÎÌÏÎÌÎÎÏÌÍÎÎÍÍÌÏÍÌÍÎÍ ÏÎÏÎÍÍÌÍÎÍÎÏÍÌÍÏÏÌÍÎÌÏÌ; // 0xD0
        public ÎÍÏÌÌÌÏÎÍÌÍÍÍÎÌÌÏÍÎÍÎÏÏ ÍÏÌÎÏÏÎÍÎÏÍÍÎÏÏÏÏÌÏÍÎÌÏ; // 0xD8
        public ÌÍÌÏÎÍÎÎÎÏÎÌÍÏÍÎÌÌÎÍÍÎÏ ÌÎÍÍÌÎÍÏÎÍÍÍÏÌÏÏÌÎÌÎÌÍÏ; // 0xE0
        public ÏÌÍÍÍÏÏÏÌÌÌÍÏÎÎÌÍÍÎÌÏÌÎ ÌÌÏÏÏÏÍÏÌÏÍÎÍÍÍÍÌÌÍÌÍÌÌ; // 0xE8
        public ÍÌÌÎÏÍÍÍÌÏÎÎÏÌÏÏÏÎÌÍÎÍÍ ÍÏÏÌÏÏÌÏÌÏÍÏÌÎÍÍÍÏÏÍÏÌÌ; // 0xF0
        public VRC.Core.Services.IAvatarsService ÌÏÍÍÏÌÍÏÎÍÍÍÎÎÍÌÎÍÎÌÍÏÎ; // 0xF8
        public ÍÍÎÌÍÏÍÎÌÍÌÎÌÍÍÌÎÏÌÏÍÏÍ ÌÏÍÏÏÎÏÌÌÍÍÌÎÍÏÍÏÍÎÏÌÌÍ; // 0x100
        public ÏÍÏÌÌÏÎÎÎÌÌÍÍÏÎÍÏÏÌÍÍÎÍ ÌÎÍÏÏÏÍÍÍÌÍÍÌÍÌÌÎÎÌÎÏÎÍ; // 0x108
        public ÏÎÍÎÌÍÏÎÍÍÌÌÌÌÌÏÎÏÎÎÍÍÏ ÌÎÏÏÌÌÌÎÍÍÎÏÌÍÍÍÏÌÌÌÏÍÌ; // 0x110
        public ÏÌÌÍÍÍÏÌÏÎÌÎÏÎÏÎÌÎÏÎÎÎÍ ÌÌÍÎÍÍÎÎÏÏÏÍÍÏÎÍÏÎÎÎÏÎÌ; // 0x118
        public ÌÌÏÍÏÍÎÍÎÏÌÎÎÍÍÍÌÎÍÎÍÎÎ ÏÏÏÍÍÍÎÏÎÌÏÎÌÏÌÏÏÏÍÏÍÏÎ; // 0x120
        public ÏÍÎÏÎÏÍÎÍÍÏÎÌÌÍÌÏÎÎÎÌÍÎ ÍÏÎÎÍÌÏÌÎÍÍÎÏÏÎÎÏÎÎÍÌÍÍ; // 0x128
        public ÍÏÎÎÏÏÍÌÌÌÍÌÌÎÎÌÌÌÎÌÎÌÌ ÏÏÍÍÎÎÍÍÌÌÏÏÍÎÎÍÍÏÏÏÍÏÍ; // 0x130
        public ÍÍÍÎÍÍÍÎÍÍÏÎÍÏÍÏÏÏÎÍÏÍÍ ÏÎÍÎÍÏÏÏÌÏÍÎÍÌÍÏÍÍÎÎÎÏÌ; // 0x138
        public ÏÏÏÍÌÌÏÏÎÌÏÎÍÏÍÌÏÍÍÌÌÌÌ ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎÌÎÎ; // 0x140
        public ÍÏÍÌÏÍÏÍÌÍÍÌÏÏÎÍÎÎÎÎÎÏÏ ÌÏÍÏÍÍÍÏÏÏÌÌÏÌÌÎÎÌÍÍÎÍÌ; // 0x148
        public ÏÌÎÎÏÌÌÎÏÌÏÏÍÍÍÏÍÌÌÏÏÌÏ ÍÍÎÌÏÍÌÌÍÍÏÎÏÏÏÎÎÏÎÍÌÍÎ; // 0x150
        public ÍÏÏÍÏÌÍÌÍÌÍÎÍÍÎÌÌÏÌÌÎÏÍ ÎÍÏÍÌÍÍÌÌÍÏÍÎÍÏÎÏÏÌÍÎÌÌ; // 0x158
        public VRC.Core.Services.IGroupsService ÍÍÏÌÌÏÎÌÌÎÏÌÌÏÍÌÏÍÏÍÏÌÏ; // 0x160
        public ÎÌÌÍÏÍÏÏÎÌÌÍÏÏÎÌÎÌÌÌÍÎÌ ÍÌÍÏÎÍÌÍÏÏÍÌÍÍÌÎÏÎÏÌÌÏÏ; // 0x168
        public ÍÏÏÍÎÏÎÎÎÎÌÏÍÎÌÌÌÍÎÏÌÌÌ ÍÎÍÏÌÏÍÎÏÍÍÌÏÍÎÎÌÌÎÎÏÏÎ; // 0x170
        public ÌÎÍÌÎÍÏÎÍÌÌÍÏÌÌÎÏÏÎÎÎÍÏ ÌÏÏÎÌÍÌÎÌÎÎÎÌÎÌÎÍÍÍÏÎÎÏ; // 0x178
        public ÎÎÎÌÎÏÎÎÌÌÎÍÍÏÎÎÎÎÎÌÌÏÌ ÌÌÌÏÌÌÎÏÌÍÌÎÌÍÌÌÍÍÏÏÎÏÍ; // 0x180
        public ÍÍÍÌÌÍÏÍÎÏÎÍÌÎÍÍÏÏÍÍÍÏÍ ÍÍÍÌÌÌÍÍÌÏÍÍÍÌÌÌÏÌÎÌÌÏÌ; // 0x188
        public ÏÌÍÎÍÎÌÎÌÏÍÏÍÌÌÌÌÌÏÌÌÏÌ ÏÎÎÏÍÎÎÎÌÌÍÌÌÎÌÏÍÌÍÏÍÎÌ; // 0x190
        public ÎÎÌÍÌÎÏÎÎÏÏÌÌÎÎÏÌÎÎÏÏÏÍ ÏÎÍÏÏÍÎÎÏÎÏÏÏÎÌÍÍÍÎÍÍÌÏ; // 0x198
        public ÏÍÌÏÎÏÌÌÎÏÌÎÌÏÌÎÌÌÌÎÌÏÍ ÌÏÏÍÌÍÍÏÌÎÍÍÍÎÎÎÌÎÌÍÍÍÏ; // 0x1A0
        public ÏÎÏÌÎÏÏÎÍÎÎÏÏÏÌÍÏÌÏÎÎÌÎ ÍÌÌÏÍÌÏÌÎÍÍÏÏÍÎÍÌÎÌÎÍÎÎ; // 0x1A8
        public ÏÏÎÍÌÍÌÌÍÏÌÏÍÎÌÍÌÌÌÌÌÎÎ ÌÍÍÍÌÏÏÏÏÍÎÏÍÌÎÍÎÌÏÏÎÌÍ; // 0x1B0
        public ÌÎÎÏÎÍÍÎÌÌÎÍÎÍÎÍÌÏÍÌÍÌÌ ÏÍÍÌÎÍÎÎÏÎÌÎÍÍÏÏÎÌÏÎÏÌÍ; // 0x1B8
        public ÍÏÌÌÏÌÌÌÌÌÌÎÏÌÌÌÎÌÎÎÍÎÌ ÍÎÎÏÏÎÎÌÍÌÌÌÏÌÎÍÌÎÏÍÍÎÌ; // 0x1C0
        public ÍÎÎÏÌÎÏÌÎÍÎÍÏÎÌÌÍÍÏÍÎÎÌ ÍÎÏÎÌÌÏÍÎÌÏÏÏÎÏÍÌÏÌÌÍÍÎ; // 0x1C8
        public ÍÎÌÏÏÍÎÌÏÌÌÌÏÎÌÌÌÍÏÎÌÍÏ ÌÍÎÏÎÏÍÍÌÏÍÎÎÍÌÎÏÏÏÍÌÏÏ; // 0x1D0
        public ÏÍÏÎÌÍÏÌÎÏÌÏÌÌÎÎÏÍÍÍÎÎÌ ÌÍÍÎÎÌÍÌÌÌÌÍÌÏÏÏÏÌÏÏÎÍÎ; // 0x1D8
        public ÏÌÌÎÍÎÎÏÌÌÎÎÎÏÏÎÍÎÌÍÌÏÎ ÌÏÍÌÎÍÍÎÎÏÌÍÎÏÏÌÍÍÏÍÍÎÏ; // 0x1E0
        public VRC.Core.Services.IEventsService ÏÍÍÏÎÍÏÎÏÎÌÎÍÌÎÏÌÎÎÏÏÏÎ; // 0x1E8
        public ÏÏÏÌÍÍÌÌÎÎÌÎÍÍÎÎÎÎÌÏÌÏÍ ÍÌÌÏÌÎÌÎÎÍÏÏÌÍÏÌÏÎÏÍÏÌÎ; // 0x1F0
        public ÍÌÌÏÍÏÌÎÎÌÏÎÏÏÌÌÌÌÍÌÎÌÍ ÏÏÎÏÏÌÌÌÎÌÌÎÍÎÏÍÍÍÎÏÍÍÏ; // 0x1F8
        public ÎÏÎÎÌÎÌÎÍÌÌÎÍÍÌÍÍÎÎÌÌÌÎ ÍÏÍÍÏÍÍÎÍÍÌÍÏÍÏÏÍÌÍÌÍÎÌ; // 0x200
        public ÍÍÍÌÏÍÎÎÎÍÏÎÍÌÏÎÍÎÍÍÍÍÍ ÍÌÍÏÌÎÍÎÎÎÏÏÌÍÎÏÏÌÍÏÌÏÌ; // 0x208
        public ÍÎÎÏÎÏÏÎÍÍÎÌÏÌÎÍÎÏÍÏÍÏÌ ÍÎÎÌÍÌÏÍÌÏÌÌÍÍÌÌÍÎÎÍÍÏÎ; // 0x210
        public ÎÌÌÌÎÌÏÌÎÍÍÏÍÎÍÌÏÌÏÌÌÍÎ ÎÎÏÍÍÎÍÌÏÎÏÏÍÎÌÏÏÌÏÏÌÏÎ; // 0x218
        public ÌÍÍÌÏÌÏÍÍÎÏÍÏÎÎÏÏÍÌÌÍÌÍ ÏÎÌÌÏÏÏÍÌÏÏÏÏÏÍÍÏÍÏÍÍÌÏ; // 0x220
        public ÏÎÎÏÎÌÏÎÎÏÎÏÏÌÌÍÍÎÎÍÍÎÌ ÏÍÍÎÌÍÍÎÍÎÎÎÌÎÌÎÏÍÍÎÏÎÌ; // 0x228
        public ÍÎÌÌÏÎÍÌÎÌÍÏÍÍÎÍÍÏÌÎÏÌÎ ÎÏÌÌÏÍÏÎÍÍÎÍÍÎÍÍÏÏÌÌÏÏÌ; // 0x230
        public ÎÌÍÌÍÌÎÌÏÌÎÎÌÌÎÎÍÌÎÍÎÎÏ ÍÍÍÏÍÎÌÏÍÌÍÌÍÏÏÍÍÎÌÎÌÍÌ; // 0x238
        public ÎÌÎÍÍÎÌÍÍÎÏÌÏÏÏÌÌÍÏÌÌÏÎ ÌÍÎÎÏÌÎÍÍÏÌÎÍÍÎÍÍÍÍÍÎÏÎ; // 0x240
        public ÏÏÌÍÌÌÏÍÌÎÌÎÎÎÏÏÎÏÎÍÏÌÌ ÍÏÌÏÎÎÎÏÍÏÎÏÌÏÎÎÍÍÍÏÌÍÏ; // 0x248
        public ÏÏÏÎÌÍÌÍÏÏÌÌÍÏÍÎÎÍÏÌÎÍÍ ÌÏÎÏÏÏÌÏÍÌÍÏÍÏÌÍÎÎÌÍÌÎÎ; // 0x250
        public ÍÍÏÎÎÎÍÏÌÏÎÍÍÍÎÍÎÏÏÌÏÏÎ ÌÎÍÌÌÏÏÏÎÌÎÍÌÎÌÍÎÍÎÍÌÎÏ; // 0x258
        public ÏÌÏÎÍÍÎÎÎÌÎÎÍÍÎÍÏÎÌÌÌÍÏ ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ; // 0x260
        public ÌÌÏÎÌÌÌÎÌÌÏÌÍÍÎÏÌÏÍÌÍÍÍ ÎÎÎÌÎÌÌÏÏÎÌÏÍÍÏÌÎÍÍÎÎÎÌ; // 0x268
        public ÌÎÏÏÏÏÌÍÏÎÍÍÏÎÌÌÍÌÎÌÌÍÏ ÏÏÎÏÏÌÍÏÍÏÌÏÎÏÏÌÏÍÎÎÎÎÌ; // 0x270
        public ÎÌÏÍÌÎÌÎÎÎÌÍÌÏÎÏÌÍÍÌÌÍÍ ÍÎÎÎÌÎÏÌÏÏÌÎÌÏÌÎÎÌÌÍÌÍÌ; // 0x278
        public ÍÍÍÍÌÌÍÍÏÎÌÍÎÌÎÏÎÍÌÌÎÏÍ ÍÎÍÎÌÍÍÌÍÍÏÌÏÏÎÎÎÌÎÏÏÏÍ; // 0x280
        public VRC.Core.Services.IStoresService ÎÏÏÎÍÎÎÍÍÌÎÏÌÌÎÍÏÏÎÎÌÎÎ; // 0x288
        public VRC.Core.Services.IEconomyService ÏÍÏÏÍÌÍÍÎÍÎÏÎÌÎÌÍÍÌÏÏÎÏ; // 0x290
        public VRC.Core.Services.IInventoryService ÌÍÏÌÎÍÎÎÍÎÌÍÌÍÌÎÌÌÎÍÌÎÎ; // 0x298
        public ÍÌÍÏÎÌÍÎÎÎÏÎÏÏÎÍÎÎÌÏÏÌÎ ÌÏÏÏÎÏÏÍÍÎÎÍÌÌÍÎÍÌÏÌÌÍÎ; // 0x2A0
        public ÏÎÎÌÌÍÏÌÍÌÍÎÏÌÏÍÌÎÏÎÏÏÏ ÏÍÎÏÍÏÌÌÎÏÎÏÌÏÏÌÍÍÏÌÏÏÎ; // 0x2A8
        public ÏÌÌÍÏÏÍÍÏÏÏÌÏÍÎÎÎÌÎÏÎÏÌ ÏÏÌÏÌÎÏÏÏÌÌÌÎÌÍÏÎÍÏÎÌÏÏ; // 0x2B0
        public ÎÍÍÍÎÍÌÌÌÍÍÍÏÌÍÎÎÌÌÌÍÍÎ ÎÍÎÍÏÏÏÍÎÍÎÎÏÏÎÏÌÏÎÎÍÌÌ; // 0x2B8
        public ÍÏÌÍÌÍÎÏÍÍÌÏÍÌÍÎÍÌÌÎÏÎÌ ÌÌÍÌÎÌÎÎÍÌÍÍÎÎÍÎÌÎÍÍÎÏÍ; // 0x2C0
        public ÌÍÏÍÍÎÎÍÏÍÌÌÌÍÏÍÌÌÌÏÌÍÏ ÏÌÎÌÍÌÌÍÏÏÌÍÏÌÎÌÏÍÌÏÌÎÎ; // 0x2C8
        public ÍÍÏÍÏÍÌÏÌÌÎÎÍÌÎÎÏÍÌÍÌÎÌ ÍÏÎÎÌÎÍÌÏÌÌÍÍÏÌÏÍÍÎÏÎÎÌ; // 0x2D0
        public ÎÍÎÍÏÏÌÎÍÏÌÌÏÌÌÍÎÌÍÌÎÍÌ ÍÏÎÌÍÎÍÏÏÌÌÌÌÎÍÍÍÍÍÎÏÏÎ; // 0x2D8
        public ÍÌÎÌÎÌÌÍÏÏÏÎÌÏÌÌÍÍÌÏÍÏÎ ÌÍÎÎÏÌÎÏÍÎÎÍÎÏÌÏÌÌÏÎÌÌÏ; // 0x2E0
        public ÌÏÏÎÌÎÎÎÌÌÎÍÏÍÏÎÎÎÎÏÌÍÌ ÎÎÌÌÎÎÌÌÎÎÏÌÍÎÏÍÎÎÎÎÏÍÎ; // 0x2E8
        public ÌÌÎÌÎÍÎÌÎÎÍÍÍÍÎÍÎÌÎÏÏÏÎ ÎÌÍÌÌÎÍÎÎÎÎÎÌÍÏÌÌÍÏÍÎÎÍ; // 0x2F0
        public ÌÏÍÌÍÏÍÍÌÏÎÏÎÍÌÍÎÍÏÎÌÏÎ ÏÌÌÌÏÌÍÎÌÏÌÌÏÌÎÌÍÌÍÍÎÏÏ; // 0x2F8
        public ÏÎÌÌÍÏÍÎÏÌÌÍÎÏÍÍÌÏÌÌÎÍÏ ÏÌÎÏÏÎÍÍÍÍÎÎÌÍÎÎÎÌÎÎÍÌÍ; // 0x300
        public VRC.Core.Services.IInstancesService ÎÏÍÌÍÌÎÍÏÏÌÏÌÌÎÌÍÏÌÍÌÎÎ; // 0x308
        public ÍÌÌÏÍÍÎÏÏÎÏÌÏÌÌÍÍÎÎÌÌÍÏ ÎÏÍÏÎÌÎÎÍÏÍÍÏÌÍÍÌÏÍÍÎÍÌ; // 0x310
        public 0x6B169720 ÎÎÎÍÌÏÎÎÏÎÎÏÌÍÏÌÎÎÏÍÏÌÍ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC48B5500
        public void Initialize(){} // RVA: 0x7FFAC48B5560
        public void Equals(){} // RVA: 0x7FFAC48B55F0
        public void op_Implicit(){} // RVA: 0x7FFAC48B5720
        public void CompareBaseObjects(){} // RVA: 0x7FFAC48B5870
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC48B59C0
        public void .cctor(){} // RVA: 0x7FFAC48B5A30
    }

}