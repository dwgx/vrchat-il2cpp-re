// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Elements.Menus
// Classes: 6
// Methods: 74

namespace VRC.UI.Elements.Menus
{
    public class Binding : ValueType
    {
    }

    public class GalleryIconsView : HeaderElementContentView`1
    {
        public VRC.UI.Elements.HelperMethods.UIAlert _iconSelected; // 0x68
        public VRC.UI.Elements.HelperMethods.UIBinaryAlert _iconUpdated; // 0x90

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE89B8CC00
        public void set_MaxContentCount(){} // RVA: 0x7FFE89B8CD00
        public void OnDestroy(){} // RVA: 0x7FFE89B8D120
        public void get_ObservableList_514D95F0E5AD(){} // RVA: 0x7FFE89B8D210
        public void set_ObservableList(){} // RVA: 0x7FFE89B8D4B0
        public void Start_A0B7BC3C3813(){} // RVA: 0x7FFE89B8D4D0
        public void .ctor(){} // RVA: 0x7FFE89B8D4F0
        public void Initialize(){} // RVA: 0x7FFE89B8D560
        public void get_ObservableList(){} // RVA: 0x7FFE89B8D980
        public void OnEnable(){} // RVA: 0x7FFE89B8DA00
        public void OnDisable(){} // RVA: 0x7FFE89B8DC30
        public void RefreshIconList(){} // RVA: 0x7FFE89B8DCD0
        public void PreparePhotoViewRendering(){} // RVA: 0x7FFE89B8DE00
        public void OnIconClicked(){} // RVA: 0x7FFE89B8DEF0
        public void ProcessGalleryPhotoData(){} // RVA: 0x7FFE89B8DF10
        public void get_MaxContentCount(){} // RVA: 0x7FFE89B8DF30
        public void OnEnable_71CCEFAFAFB2(){} // RVA: 0x7FFE89B8DFB0
        public void PopulateIcons(){} // RVA: 0x7FFE89B8DFD0
    }

    public class GalleryPhotosView : HeaderElementContentView`1
    {
        public ÏÌÌÍÏÍÏÍÎÍÏÌÎÍÌÏÎÏÏÌÎÎÏ _menuStateController; // 0x68
        public UnityEngine.GameObject subNowInfo; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89B8ED70
        public void Initialize(){} // RVA: 0x7FFE89B8EDE0
        public void Start(){} // RVA: 0x7FFE89B8F100
        public void OnEnable(){} // RVA: 0x7FFE89B8F260
        public void OnDestroy(){} // RVA: 0x7FFE89B8F490
        public void get_MaxContentCount(){} // RVA: 0x7FFE89B8F580
        public void set_MaxContentCount(){} // RVA: 0x7FFE89B8F600
        public void set_ObservableList(){} // RVA: 0x7FFE89B8F6F0
        public void get_ObservableList(){} // RVA: 0x7FFE89B90020
        public void OnDisable(){} // RVA: 0x7FFE89B900A0
        // ── Unresolved (hash) ──
        public void m_D7D(){} // RVA: 0x7FFE89B8E560
        public void m_772(){} // RVA: 0x7FFE89B8E650
        public void m_CE6(){} // RVA: 0x7FFE89B8E950
        public void m_44F(){} // RVA: 0x7FFE89B8FB10
        public void m_D1B(){} // RVA: 0x7FFE89B8FC00
    }

    public class HeaderElementContentView`1 : ListContentView`1
    {
        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFE80E45FE0
        public void get_MaxContentCount(){} // RVA: 0x7FFE80E45FE0
        public void get_ObservableList(){} // RVA: 0x7FFE80E4F230
        public void Start(){} // RVA: 0x7FFE80E2E390
        public void OnEnable(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class KeyboardInputModalComponents : Object
    {
        public UnityEngine.GameObject _keyboardGameObject; // 0x10
        public UnityEngine.UI.Button _cancel; // 0x18
        public ÏÌÎÌÌÌÍÌÌÌÌÌÌÏÍÍÎÌÏÏÏÍÌ _cancelText; // 0x20
        public UnityEngine.UI.Button _submit; // 0x28
        public ÏÌÎÌÌÌÍÌÌÌÌÌÌÏÍÍÎÌÏÏÏÍÌ _submitText; // 0x30
        public UnityEngine.UI.Button _closeButton; // 0x38
        public UnityEngine.UI.Button _clearButton; // 0x40
        public ÏÌÎÌÌÌÍÌÌÌÌÌÌÏÍÍÎÌÏÏÏÍÌ _title; // 0x48
        public ÏÌÎÌÌÌÍÌÌÌÌÌÌÏÍÍÎÌÏÏÏÍÌ _placeholder; // 0x50
        public ÎÍÍÌÍÍÍÏÏÎÌÏÏÎÏÏÌÏÍÎÍÍÏ _charactersRemaining; // 0x58
        public TMPro.TMP_InputField _inputField; // 0x60
        public ÌÎÌÎÌÎÎÌÌÌÏÌÎÏÌÌÎÎÏÎÌÏÍ _maskInputToggle; // 0x68
        public ÌÏÏÎÏÎÎÏÍÌÌÎÎÎÌÌÌÍÌÎÌÍÍ _minimizedKeyboard; // 0x70
        public UnityEngine.GameObject[] _modalBackgrounds; // 0x78
        public UnityEngine.GameObject _worldKeyboardBackground; // 0x80
        public ÎÌÌÌÏÏÏÎÌÏÌÌÍÌÍÌÌÌÎÎÏÌÏ[] _keyboardToggleGroups; // 0x88

        // ── Methods ──
        public void get_WorldBackground(){} // RVA: 0x7FFE81280C30
        public void get_InputField(){} // RVA: 0x7FFE81199370
        public void get_ClearButton(){} // RVA: 0x7FFE81178740
        public void get_CloseButton(){} // RVA: 0x7FFE8143BA80
        public void get_CharactersRemaining(){} // RVA: 0x7FFE811C3500
        public void get_Submit(){} // RVA: 0x7FFE81129130
        public void get_SubmitText(){} // RVA: 0x7FFE8144E200
        public void get_ModalBackgrounds(){} // RVA: 0x7FFE81463AE0
        public void set_ModalBackgrounds(){} // RVA: 0x7FFE89BC7EB0
        public void get_CancelText(){} // RVA: 0x7FFE811290C0
        public void get_Placeholder(){} // RVA: 0x7FFE8119C0E0
        public void set_Placeholder(){} // RVA: 0x7FFE811C3500
        public void Instantiate(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81176730
        public void get_MinimizedKeyboard(){} // RVA: 0x7FFE811C3590
        public void get_Title(){} // RVA: 0x7FFE81176730
        public void get_MaskInputToggle(){} // RVA: 0x7FFE81176D50
        public void get_Cancel(){} // RVA: 0x7FFE810FE7C0
        public void get_KeyboardToggleGroups(){} // RVA: 0x7FFE8113A010
        public void set_KeyboardToggleGroups(){} // RVA: 0x7FFE811290C0
        public void get_Keyboard(){} // RVA: 0x7FFE89BC7F70
    }

    public class ListContentView`1 : MonoBehaviour
    {
        public UnityEngine.GameObject _contentPrefab;
        public ÍÎÏÌÌÏÌÏÌÏÍÏÍÎÌÍÍÎÍÏÏÎÏ _listBinding;
        public ÍÍÎÍÏÏÎÎÏÏÏÌÌÌÎÌÎÎÌÏÎÎÎ _listCountBinding;

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFE80E2E2E0
        public void get_MaxContentCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_ObservableList(){} // RVA: 0x7FFE80E2E2E0
        public void Start(){} // RVA: 0x7FFE80E45FE0
        public void OnEnable(){} // RVA: 0x7FFE80E45FE0
        public void OnDisable(){} // RVA: 0x7FFE80E45FE0
        public void CancelInvoke(){} // RVA: 0x7FFE80E45FE0
        public void IsInvoking(){} // RVA: 0x7FFE80E45FE0
        public void StartCoroutine(){} // RVA: 0x7FFE80E45FE0
        public void IndexOf(){} // RVA: 0x7FFE80E2E390
        public void OnApplicationQuit(){} // RVA: 0x7FFE80E4F230
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

}