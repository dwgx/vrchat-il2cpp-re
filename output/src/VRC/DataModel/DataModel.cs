// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel
// Classes: 12
// Methods: 167

namespace VRC.DataModel
{
    public class CalendarSearchFilters : Object
    {
        public object Categories;
        public object Platforms;
        public object Languages;
        public object WeekDay;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x26394F0
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x26396A0
        public void op_Implicit(){} // RVA: 0x2639720
        public void CompareBaseObjects(){} // RVA: 0x2639770
        public void IsNativeObjectAlive(){} // RVA: 0x26397F0
        public void GetCachedPtr(){} // RVA: 0x2639870
        public void get_name(){} // RVA: 0x2639A20
        public void set_name(){} // RVA: 0x2639BD0
    }

    public class EmojiMask : Object
    {
        public object Tag;
        public object Mask;
        public object Overlay;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EmojiMask[] : Array
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

    public class KeyboardData : Object
    {
        public object _title;
        public object _placeholderText;
        public object _keyboardType;
        public object _keyboardRadioButtonGroup;
        public object _defaultRadioButtonGroupValue;
        public object _inputType;
        public object _contentType;
        public object _characterLimit;
        public object _multiline;
        public object _readOnly;
        public object _submitLabel;
        public object _cancelLabel;
        public object _isWorldKeyboard;
        public object f_9D9;
        public object f_E6A;
        public object f_C87;
        public object f_CF2;
        public object f_325;
        public object f_D3E;
        public object _stayOpenAfterSubmit;

        // ── Methods ──
        public void get_Title(){} // RVA: 0x11E18A0
        public void get_OnRadioOptionSet(){} // RVA: 0x10B4170
        public void get_PreviousInput(){} // RVA: 0xBC5B30
        public void get_OnInputChanged(){} // RVA: 0xBC5BA0
        public void set_DefaultRadioButtonGroupValue(){} // RVA: 0x25406E0
        public void .ctor(){} // RVA: 0x2642F40
        public void get_ActiveRequest(){} // RVA: 0x135D730
        public void set_PreviousInput(){} // RVA: 0xBC5B40
        public void set_OnInputCanceled(){} // RVA: 0xEC0BB0
        public void Instantiate(){} // RVA: 0x26431B0
        public void set_OnRadioOptionSet(){} // RVA: 0x15B42C0
        public void set_CharacterLimit(){} // RVA: 0x26432E0
        public void FindObjectsOfType(){} // RVA: 0x26431B0
        public void set_OnInputSubmitted(){} // RVA: 0xBAE5B0
        public void DontDestroyOnLoad(){} // RVA: 0x26432F0
        public void get_hideFlags(){} // RVA: 0x135D730
        public void set_hideFlags(){} // RVA: 0x2643310
        public void set_StayOpenAfterSubmit(){} // RVA: 0x1FDB9D0
        public void set_OnInputChanged(){} // RVA: 0xBC5BB0
        public void set_Multiline(){} // RVA: 0x21EA4F0
        public void get_Multiline(){} // RVA: 0x1165710
        public void get_OnInputCanceled(){} // RVA: 0x135A7B0
        public void op_Inequality(){} // RVA: 0x2643370
        public void set_ReadOnly(){} // RVA: 0x135A7B0
        public void get_ReadOnly(){} // RVA: 0x1165720
        public void get_DefaultRadioButtonGroupValue(){} // RVA: 0x2536460
        public void get_ContentType(){} // RVA: 0x19C6270
        public void set_ContentType(){} // RVA: 0x2643670
        public void get_CharacterLimit(){} // RVA: 0x21EA4F0
        public void get_StayOpenAfterSubmit(){} // RVA: 0x1FDB9C0
        public void get_KeyboardRadioButtonGroup(){} // RVA: 0xD34720
        public void get_SubmitButtonText(){} // RVA: 0xEA0050
        public void set_SubmitButtonText(){} // RVA: 0x2643680
        public void set_IsWorldKeyboard(){} // RVA: 0xBAE5B0
        public void get_IsWorldKeyboard(){} // RVA: 0x1A6FCB0
        public void get_InputType(){} // RVA: 0x25406F0
        public void set_ActiveRequest(){} // RVA: 0xBC5AD0
        public void get_KeyboardType(){} // RVA: 0xD347A0
        public void get_OnInputSubmitted(){} // RVA: 0xBAE5A0
        public void get_PlaceholderText(){} // RVA: 0x1269840
        public void get_CancelButtonText(){} // RVA: 0xEA0850
    }

    public class QuitHandler : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1808650
        public void Equals(){} // RVA: 0x18086B0
        public void .cctor(){} // RVA: 0x18087E0
        public void op_Implicit(){} // RVA: 0x1808940
        public void CompareBaseObjects(){} // RVA: 0x18089C0
        public void IsNativeObjectAlive(){} // RVA: 0x1808EF0
        public void GetCachedPtr(){} // RVA: 0x1808F50
        public void Initialize(){} // RVA: 0x1809080
        public void set_name(){} // RVA: 0x1809200
        public void .ctor(){} // RVA: 0x1809380
        public void Destroy(){} // RVA: 0x1809440
        public void DestroyImmediate(){} // RVA: 0x18094C0
        public void FindObjectsOfType(){} // RVA: 0x18094D0
        public void FindObjectsByType(){} // RVA: 0x1809600
    }

    public class SearchInFieldsUser : Object
    {
        public object Name;
        public object Bio;
        public object DefaultName;
        public object DefaultBio;
        public object SearchContentType;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x26388D0
        public void Equals(){} // RVA: 0x2638900
        public void GetHashCode(){} // RVA: 0x2638C50
        public void .ctor(){} // RVA: 0x2638B90
        public void Initialize(){} // RVA: 0x2638A60
        public void IsNativeObjectAlive(){} // RVA: 0x2638AE0
        public void GetCachedPtr(){} // RVA: 0x2638BA0
        public void set_FieldDescriptions(){} // RVA: 0x2638DA0
        public void get_FieldDescriptions(){} // RVA: 0x2638DC0
        public void Instantiate(){} // RVA: 0x2638E70
        public void Destroy(){} // RVA: 0x2638DA0
        public void ToString(){} // RVA: 0x2638EF0
    }

    public class SearchInFieldsWorld : Object
    {
        public object Title;
        public object Tags;
        public object Description;
        public object Author;
        public object DefaultTitle;
        public object DefaultTags;
        public object DefaultDescription;
        public object DefaultAuthor;
        public object SearchContentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2638210
        public void Initialize(){} // RVA: 0x2637B40
        public void Equals(){} // RVA: 0x2637CD0
        public void op_Implicit(){} // RVA: 0x2637D10
        public void CompareBaseObjects(){} // RVA: 0x2637EB0
        public void IsNativeObjectAlive(){} // RVA: 0x2637B30
        public void GetCachedPtr(){} // RVA: 0x26380E0
        public void get_name(){} // RVA: 0x2638160
        public void set_name(){} // RVA: 0x2638220
        public void set_FieldDescriptions(){} // RVA: 0x260A2D0
        public void get_FieldDescriptions(){} // RVA: 0x26382C0
        public void ToString(){} // RVA: 0x2638370
        public void FindObjectsOfType(){} // RVA: 0x26383C0
        public void FindObjectsByType(){} // RVA: 0x26383E0
        public void DontDestroyOnLoad(){} // RVA: 0x2637CD0
    }

    public class SearchParameters : Object
    {
        public object SEARCH_TITLE_OVERFLOW_SUFFIX;
        public object SearchContentType;
        public object SearchInvokedFrom;
        public object SearchQuery;
        public object SearchTitle;
        public object SearchQueryInitial;
        public object SearchQuerySimilarity;
        public object SearchCount;
        public object WorldSort;
        public object UserSort;
        public object GroupSort;
        public object WorldSearchInFields;
        public object UserSearchInFields;
        public object CalendarSearchFilters;
        public object IncludeCommunityLabs;
        public object IsRefined;
        public object DefaultUserSort;
        public object DefaultWorldSort;
        public object DefaultGroupSort;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2639C20
        public void set_IsWorldsSearch(){} // RVA: 0x2639C30
        public void Equals(){} // RVA: 0x2639E20
        public void op_Implicit(){} // RVA: 0x263A070
        public void CompareBaseObjects(){} // RVA: 0x263A320
        public void get_IsWorldsSearch(){} // RVA: 0x263A390
        public void set_DefaultIncludeCommunityLabs(){} // RVA: 0x263A3B0
        public void get_DefaultIncludeCommunityLabs(){} // RVA: 0x263A460
        public void set_name(){} // RVA: 0x263A4F0
        public void Instantiate(){} // RVA: 0x263A870
        public void Destroy(){} // RVA: 0x263A900
        public void .ctor(){} // RVA: 0x263A9B0
        public void Initialize(){} // RVA: 0x263AC20
        public void get_SearchTypeDescription(){} // RVA: 0x263ACD0
        public void set_SearchTypeDescription(){} // RVA: 0x263ADF0
        public void get_hideFlags(){} // RVA: 0x263AFC0
        public void set_hideFlags(){} // RVA: 0x263B070
        public void FindObjectOfType(){} // RVA: 0x263B100
        public void FindFirstObjectByType(){} // RVA: 0x263B110
        public void CheckNullArgument(){} // RVA: 0x263B120
        public void GetHashCode(){} // RVA: 0x263B260
    }

    public class SearchParameters[] : Array
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

    public class SupportedPlatformData : Object
    {
        public object Platform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SupportedPlatformData[] : Array
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

    public class VRCData : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_0BE;
        public object f_EAA;
        public object f_BA8;
        public object f_A98;
        public object f_15B;
        public object f_44E;
        public object f_F66;
        public object f_D5C;
        public object f_6FC;
        public object f_E2A;
        public object f_A5A;
        public object f_4D4;
        public object f_14F;
        public object f_6F7;
        public object f_356;
        public object f_0E8;
        public object f_A69;
        public object f_C50;
        public object f_CC1;
        public object f_CA9;
        public object f_5B7;
        public object f_371;
        public object f_4A4;
        public object f_274;
        public object f_8A2;
        public object f_9E6;
        public object f_17C;
        public object f_AD9;
        public object f_447;
        public object f_ECA;
        public object f_714;
        public object f_2BB;
        public object f_35A;
        public object f_07A;
        public object f_E17;
        public object f_463;
        public object f_E34;
        public object f_0B1;
        public object f_73C;
        public object f_907;
        public object f_CAF;
        public object f_7BE;
        public object f_E16;
        public object f_CCF;
        public object f_635;
        public object f_684;
        public object f_2AE;
        public object f_A93;
        public object f_CE5;
        public object f_D40;
        public object f_197;
        public object f_4C7;
        public object f_D13;
        public object f_AB4;
        public object f_679;
        public object f_7DC;
        public object f_E8B;
        public object f_81E;
        public object f_AC2;
        public object f_B31;
        public object f_9BC;
        public object f_C01;
        public object f_2CB;
        public object f_F2B;
        public object f_879;
        public object f_021;
        public object f_095;
        public object f_1DC;
        public object f_6F1;
        public object f_1B0;
        public object f_48B;
        public object f_D2B;
        public object f_00A;
        public object f_9CC;
        public object f_D55;
        public object f_98A;
        public object f_ACB;
        public object f_8A1;
        public object f_E16;
        public object f_B7A;
        public object f_718;
        public object f_73C;
        public object f_0F2;
        public object f_37A;
        public object f_AE8;
        public object f_F21;
        public object f_94F;
        public object f_8E2;
        public object f_B0E;
        public object f_CE8;
        public object f_3EC;
        public object f_B99;
        public object f_545;
        public object f_938;
        public object f_459;
        public object f_8B6;
        public object f_521;
        public object f_CBD;
        public object f_D0A;
        public object f_BE7;
        public object f_6C1;
        public object f_9DC;
        public object f_0F7;
        public object f_E2A;
        public object f_86D;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2646FA0
        public void Equals(){} // RVA: 0x2647000
        public void Initialize(){} // RVA: 0x26471A0
        public void op_Implicit(){} // RVA: 0x2647230
        public void CompareBaseObjects(){} // RVA: 0x2647360
        public void IsNativeObjectAlive(){} // RVA: 0x26474B0
        public void GetCachedPtr(){} // RVA: 0x2647600
        public void .cctor(){} // RVA: 0x2647670
    }

}