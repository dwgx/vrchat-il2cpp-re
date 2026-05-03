// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel
// Classes: 9
// Methods: 129

namespace VRC.DataModel
{
    public class CalendarSearchFilters : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82B15680
        public void Equals(){} // RVA: 0x7FFE82B15830
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82B159E0
        public void CompareBaseObjects(){} // RVA: 0x7FFE82B15B90
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82B15D40
        public void GetCachedPtr(){} // RVA: 0x7FFE82B15EF0
        public void get_name(){} // RVA: 0x7FFE82B15F70
        public void set_name(){} // RVA: 0x7FFE82B15FF0
        public void Instantiate(){} // RVA: 0x7FFE82B161A0
        public void GetHashCode(){} // RVA: 0x7FFE82B161F0
        public void ToString(){} // RVA: 0x7FFE82B16270
    }

    public class EmojiMask : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class KeyboardData : Object
    {
        public VRC.Localization.LocalizableString _title; // 0x10
        public VRC.Localization.LocalizableString _placeholderText; // 0x38
        public 0x665659D4 _keyboardType; // 0x60
        public 0x66565A2C _keyboardRadioButtonGroup; // 0x64
        public int _defaultRadioButtonGroupValue; // 0x68
        public 0x66613D4C _inputType; // 0x6C
        public 0x66613CF4 _contentType; // 0x70
        public int _characterLimit; // 0x74
        public bool _multiline; // 0x78
        public bool _readOnly; // 0x79
        public VRC.Localization.LocalizableString _submitLabel; // 0x80
        public VRC.Localization.LocalizableString _cancelLabel; // 0xA8
        public bool _isWorldKeyboard; // 0xD0
        public ÎÎÎÏÌÌÌÍÌÍÎÏÏÏÍÍÌÍÌÍÌÌÌ f_BA0; // 0xD8
        public string f_80D; // 0xE0
        public System.Action`1<string> f_ABB; // 0xE8
        public System.Action`1<string> f_E18; // 0xF0
        public System.Action f_B6E; // 0xF8
        public System.Action`1<int> f_A6F; // 0x100
        public bool _stayOpenAfterSubmit; // 0x108

        // ── Methods ──
        public void set_OnInputChanged(){} // RVA: 0x7FFE8117C980
        public void get_CancelButtonText(){} // RVA: 0x7FFE82B1F550
        public void get_Multiline(){} // RVA: 0x7FFE816400C0
        public void set_Multiline(){} // RVA: 0x7FFE82B1F580
        public void get_OnInputSubmitted(){} // RVA: 0x7FFE811662A0
        public void set_KeyboardType(){} // RVA: 0x7FFE82B1F590
        public void get_KeyboardType(){} // RVA: 0x7FFE8139EA30
        public void get_OnInputChanged(){} // RVA: 0x7FFE8117C970
        public void get_ContentType(){} // RVA: 0x7FFE81E60180
        public void set_OnInputCanceled(){} // RVA: 0x7FFE81B0E4B0
        public void get_OnInputCanceled(){} // RVA: 0x7FFE8158D5D0
        public void get_IsWorldKeyboard(){} // RVA: 0x7FFE81644E40
        public void get_PreviousInput(){} // RVA: 0x7FFE8117C900
        public void get_InputType(){} // RVA: 0x7FFE82A22F10
        public void set_InputType(){} // RVA: 0x7FFE82B1F890
        public void set_CharacterLimit(){} // RVA: 0x7FFE82B1F9C0
        public void get_OnRadioOptionSet(){} // RVA: 0x7FFE81828B50
        public void get_KeyboardRadioButtonGroup(){} // RVA: 0x7FFE8139DA60
        public void get_ReadOnly(){} // RVA: 0x7FFE81647650
        public void .ctor(){} // RVA: 0x7FFE82B1F9D0
        public void get_StayOpenAfterSubmit(){} // RVA: 0x7FFE82472660
        public void set_PreviousInput(){} // RVA: 0x7FFE8117C910
        public void set_OnInputSubmitted(){} // RVA: 0x7FFE811662B0
        public void FindObjectsOfType(){} // RVA: 0x7FFE82B1FC40
        public void get_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFE82A22EF0
        public void FindObjectsByType(){} // RVA: 0x7FFE82B1FCA0
        public void set_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFE82A22F00
        public void set_Title(){} // RVA: 0x7FFE82B1FCC0
        public void get_Title(){} // RVA: 0x7FFE8196FB10
        public void set_hideFlags(){} // RVA: 0x7FFE81B0E4B0
        public void set_PlaceholderText(){} // RVA: 0x7FFE81B0E4B0
        public void set_SubmitButtonText(){} // RVA: 0x7FFE81644E40
        public void get_SubmitButtonText(){} // RVA: 0x7FFE816F93D0
        public void get_PlaceholderText(){} // RVA: 0x7FFE8170B650
        public void set_OnRadioOptionSet(){} // RVA: 0x7FFE81A58AB0
        public void set_StayOpenAfterSubmit(){} // RVA: 0x7FFE82472670
        public void set_ActiveRequest(){} // RVA: 0x7FFE8117C8A0
        public void FindObjectOfType(){} // RVA: 0x7FFE82B20060
        public void FindFirstObjectByType(){} // RVA: 0x7FFE82A22F10
        public void get_ActiveRequest(){} // RVA: 0x7FFE8181EA80
        public void get_CharacterLimit(){} // RVA: 0x7FFE826A9B90
    }

    public class QuitHandler : Object
    {
        public VRC.DataModel.QuitHandler _quitHandler;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81CE0560
        public void Equals(){} // RVA: 0x7FFE81CE0690
        public void GetHashCode(){} // RVA: 0x7FFE81CE0830
        public void op_Implicit(){} // RVA: 0x7FFE81CE0840
        public void CompareBaseObjects(){} // RVA: 0x7FFE81CE08E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81CE0830
        public void .cctor(){} // RVA: 0x7FFE81CE0A80
        public void Initialize(){} // RVA: 0x7FFE81CE0BE0
        public void .ctor(){} // RVA: 0x7FFE81CE0D60
        public void Instantiate(){} // RVA: 0x7FFE81CE0E20
        public void ToString(){} // RVA: 0x7FFE81CE1330
        public void DoJoinCore(){} // RVA: 0x7FFE81CE19E0
        public void .ctor_CD98E6FE12FE(){} // RVA: 0x7FFE81CE1B10
        public void .cctor_5A2E2B42711E(){} // RVA: 0x7FFE81CE1C90
        // ── Unresolved (hash) ──
        public void m_9AF(){} // RVA: 0x7FFE81CE1860
        public void m_0B4(){} // RVA: 0x7FFE81CE1E10
    }

    public class SearchInFieldsUser : Object
    {
        public bool Name; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82B14B50
        public void Equals(){} // RVA: 0x7FFE82B14BA0
        public void .ctor(){} // RVA: 0x7FFE82B151E0 | overloaded x2
        public void set_name(){} // RVA: 0x7FFE82B14DE0 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFE82B14BC0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82B14BC0
        public void GetCachedPtr(){} // RVA: 0x7FFE82B14BE0
        public void get_name(){} // RVA: 0x7FFE82B14D30
        public void Instantiate(){} // RVA: 0x7FFE82B14F30
        public void set_FieldDescriptions(){} // RVA: 0x7FFE82B15080
        public void GetHashCode(){} // RVA: 0x7FFE82B14BC0
        public void get_FieldDescriptions(){} // RVA: 0x7FFE82B150B0
        public void Initialize_CFEEE01AE438(){} // RVA: 0x7FFE82B15160
        public void Initialize(){} // RVA: 0x7FFE82B151F0
    }

    public class SearchInFieldsWorld : Object
    {
        public bool Title; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B14460 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE82B14010
        public void Equals(){} // RVA: 0x7FFE82AE9CB0
        public void set_FieldDescriptions(){} // RVA: 0x7FFE82B14180 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFE82B14010
        public void ToString(){} // RVA: 0x7FFE82B14050
        public void GetCachedPtr(){} // RVA: 0x7FFE82B140A0
        public void get_name(){} // RVA: 0x7FFE82B14140
        public void get_FieldDescriptions(){} // RVA: 0x7FFE82B14320
        public void Instantiate(){} // RVA: 0x7FFE82B143D0
        public void GetHashCode(){} // RVA: 0x7FFE82B14140
        public void .ctor_2A52D16D4B81(){} // RVA: 0x7FFE82B14450
        public void get_anisoLevel(){} // RVA: 0x7FFE82B14470
        public void ApplyAnisoLevel(){} // RVA: 0x7FFE82B14610
    }

    public class SearchParameters : Object
    {
        public string SEARCH_TITLE_OVERFLOW_SUFFIX;
        public 0x66568524 SearchContentType; // 0x10
        public 0x66568684 SearchInvokedFrom; // 0x14

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82B162F0
        public void set_SearchTypeDescription(){} // RVA: 0x7FFE82B16380
        public void get_SearchTypeDescription(){} // RVA: 0x7FFE82B16390
        public void set_IsWorldsSearch(){} // RVA: 0x7FFE82B16420
        public void get_IsWorldsSearch(){} // RVA: 0x7FFE82B164D0
        public void get_DefaultIncludeCommunityLabs(){} // RVA: 0x7FFE82B164F0
        public void set_DefaultIncludeCommunityLabs(){} // RVA: 0x7FFE82B16580
        public void get_name(){} // RVA: 0x7FFE82B167B0
        public void set_name(){} // RVA: 0x7FFE82B169A0
        public void Instantiate(){} // RVA: 0x7FFE82B16BD0
        public void Equals(){} // RVA: 0x7FFE82B16F60
        public void GetHashCode(){} // RVA: 0x7FFE82B17130
        public void ToString(){} // RVA: 0x7FFE82B171E0
        public void .ctor(){} // RVA: 0x7FFE82B172A0
        public void Initialize(){} // RVA: 0x7FFE82B17510
        public void set_SearchTerm(){} // RVA: 0x7FFE82B17530
        public void set_IncludeAvatars(){} // RVA: 0x7FFE82B175E0
        public void set_SortOrder(){} // RVA: 0x7FFE82B17670
        public void set_PageSize(){} // RVA: 0x7FFE82B176E0
    }

    public class SupportedPlatformData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VRCData : Object
    {
        public ÍÌÏÍÌÌÏÎÏÌÎÌÎÎÌÌÌÌÌÍÏÏÍ _vRCData;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82B20400
        public void Initialize(){} // RVA: 0x7FFE82B20460
        public void Equals(){} // RVA: 0x7FFE82B204F0
        public void op_Implicit(){} // RVA: 0x7FFE82B20620
        public void CompareBaseObjects(){} // RVA: 0x7FFE82B20770
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82B208C0
        public void .cctor(){} // RVA: 0x7FFE82B20930
    }

}