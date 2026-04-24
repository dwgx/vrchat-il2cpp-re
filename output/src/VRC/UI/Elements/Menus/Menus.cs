// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Elements.Menus
// Classes: 6
// Methods: 80

namespace VRC.UI.Elements.Menus
{
    public class Binding : ValueType
    {
        public k fingerBindings; // 0x10
        public ÏÍÎÍÍÏÎÌÏÎÌÎÌÏÏÎÎÎÎÎÎÍÎ fingerBindingCell_Left; // 0x18
        public ÏÍÎÍÍÏÎÌÏÎÌÎÌÏÏÎÎÎÎÎÎÍÎ fingerBindingCell_Right; // 0x20
    }

    public class GalleryIconsView : HeaderElementContentView`1
    {
        public VRC.UI.Elements.HelperMethods.UIAlert MaxContentCount; // 0x68
        public VRC.UI.Elements.HelperMethods.UIBinaryAlert ObservableList; // 0x90
        public UnityEngine.GameObject subNowInfo; // 0xE0

        // ── Methods ──
        public void UpdateActive(){} // RVA: 0x7FFD568C1260
        public void AccessactiveSelf(){} // RVA: 0x7FFD568C1350
        public void SetObservableListActiveTrue(){} // RVA: 0x7FFD568C1480
        public void ComputeViewMetric(){} // RVA: 0x7FFD568C14A0
        public void OnEnable(){} // RVA: 0x7FFD568C14C0
        public void OnDestroy(){} // RVA: 0x7FFD568C16F0
        public void Start(){} // RVA: 0x7FFD568C17E0
        public void set_MaxContentCount(){} // RVA: 0x7FFD568C18E0
        public void GetMaxContentCount(){} // RVA: 0x7FFD568C1D00
        public void get_MaxContentCount(){} // RVA: 0x7FFD568C1D20
        public void set_ObservableList(){} // RVA: 0x7FFD568C1DA0
        public void ToggleObservableListVisibility(){} // RVA: 0x7FFD568C20D0
        public void RefreshGalleryIcons(){} // RVA: 0x7FFD568C21C0
        public void GetObservableList(){} // RVA: 0x7FFD568C21E0
        public void get_ObservableList(){} // RVA: 0x7FFD568C2200
        public void OnDisable(){} // RVA: 0x7FFD568C2280
        public void ResetGalleryState(){} // RVA: 0x7FFD568C2320
        public void SetGalleryStateActive(){} // RVA: 0x7FFD568C2410
        public void .ctor(){} // RVA: 0x7FFD568C26B0
    }

    public class GalleryPhotosView : HeaderElementContentView`1
    {
        public ÍÍÍÍÏÎÍÌÌÏÌÎÏÍÏÍÎÏÍÍÏÌÎ MaxContentCount; // 0x68
        public UnityEngine.GameObject ObservableList; // 0x70

        // ── Methods ──
        public void get_MaxContentCount(){} // RVA: 0x7FFD568C2B00
        public void set_MaxContentCount(){} // RVA: 0x7FFD568C2B80
        public void set_ObservableList(){} // RVA: 0x7FFD568C2FA0
        public void get_ObservableList(){} // RVA: 0x7FFD568C3090
        public void OnDisable(){} // RVA: 0x7FFD568C3110
        public void Start(){} // RVA: 0x7FFD568C31A0
        public void Start_96AFB855537C(){} // RVA: 0x7FFD568C3300
        public void .ctor(){} // RVA: 0x7FFD568C33F0
        public void Initialize(){} // RVA: 0x7FFD568C3460
        public void OnDestroy(){} // RVA: 0x7FFD568C3550
        public void AccessactiveSelf(){} // RVA: 0x7FFD568C3640
        public void SetupPhotoViewContent(){} // RVA: 0x7FFD568C3A60
        public void PreparePhotoViewRendering(){} // RVA: 0x7FFD568C3E80
        public void set_ObservableList_5C38AF16EC82(){} // RVA: 0x7FFD568C4180
        public void ProcessGalleryPhotoData(){} // RVA: 0x7FFD568C4270
        public void GetGameObjectReference(){} // RVA: 0x7FFD568C4590
        public void OnEnable(){} // RVA: 0x7FFD568C49B0
    }

    public class HeaderElementContentView`1 : ListContentView`1
    {
        public UnityEngine.GameObject _headerPrefab; // 0x60

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFD4E090980
        public void get_MaxContentCount(){} // RVA: 0x7FFD4E090980
        public void get_ObservableList(){} // RVA: 0x7FFD4E099B30
        public void GetTargets(){} // RVA: 0x7FFD4E078F40
        public void OnEnable(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class KeyboardInputModalComponents : Object
    {
        public UnityEngine.GameObject Keyboard; // 0x10
        public UnityEngine.UI.Button Cancel; // 0x18
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ CancelText; // 0x20
        public UnityEngine.UI.Button Submit; // 0x28
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ SubmitText; // 0x30
        public UnityEngine.UI.Button CloseButton; // 0x38
        public UnityEngine.UI.Button ClearButton; // 0x40
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ Title; // 0x48
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ Placeholder; // 0x50
        public ÏÍÍÌÏÎÏÌÌÎÏÏÍÌÍÍÌÍÎÎÏÌÎ CharactersRemaining; // 0x58
        public TMPro.TMP_InputField InputField; // 0x60
        public ÏÌÏÏÎÌÍÍÏÌÍÌÏÎÎÍÎÏÏÌÍÍÍ MaskInputToggle; // 0x68
        public ÍÎÍÌÏÍÍÌÎÍÎÏÍÏÌÎÎÌÏÏÌÍÌ MinimizedKeyboard; // 0x70
        public UnityEngine.GameObject[] ModalBackgrounds; // 0x78
        public UnityEngine.GameObject WorldBackground; // 0x80
        public ÏÌÎÍÍÌÌÏÌÍÎÌÌÏÏÏÍÍÍÏÏÌÏ[] KeyboardToggleGroups; // 0x88
        public ÍÏÎÍÍÎÎÏÎÏÌÏÏÌÎÌÍÎÏÎÌÏÎ _keyboard; // 0x90

        // ── Methods ──
        public void get_SubmitText(){} // RVA: 0x7FFD4E5F95E0
        public void get_MaskInputToggle(){} // RVA: 0x7FFD4E3BCD50
        public void get_Title(){} // RVA: 0x7FFD4E3BC730
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void get_InputField(){} // RVA: 0x7FFD4E3DF370
        public void get_Keyboard(){} // RVA: 0x7FFD568FB4B0
        public void get_KeyboardToggleGroups(){} // RVA: 0x7FFD4E380010
        public void get_ModalBackgrounds(){} // RVA: 0x7FFD4E505600
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void Instantiate(){} // RVA: 0x7FFD4E3DF370
        public void set_Placeholder(){} // RVA: 0x7FFD4E3447C0
        public void get_Placeholder(){} // RVA: 0x7FFD4E3E20E0
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void get_CancelText(){} // RVA: 0x7FFD4E36F0C0
        public void get_Submit(){} // RVA: 0x7FFD4E36F130
        public void get_ClearButton(){} // RVA: 0x7FFD4E3BE740
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void get_WorldBackground(){} // RVA: 0x7FFD4E70F410
        public void get_CharactersRemaining(){} // RVA: 0x7FFD4E409500
        public void get_CloseButton(){} // RVA: 0x7FFD4E5F0140
        public void get_Cancel(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void get_MinimizedKeyboard(){} // RVA: 0x7FFD4E409590
    }

    public class ListContentView`1 : MonoBehaviour
    {
        public UnityEngine.GameObject CountFormat; // 0x20
        public ÏÌÏÍÎÌÍÌÏÌÌÍÏÎÌÍÍÎÎÎÎÌÌ MaxContentCount; // 0x28
        public ÏÏÍÏÏÍÏÌÎÍÏÏÍÏÌÏÎÌÏÎÎÏÍ ObservableList; // 0x30
        public VRC.Localization.LocalizableString _header; // 0x38

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFD5153B210
        public void get_MaxContentCount(){} // RVA: 0x7FFD4E919180
        public void get_ObservableList(){} // RVA: 0x7FFD4E078E90
        public void Start(){} // RVA: 0x7FFD4F37BE50
        public void OnEnable(){} // RVA: 0x7FFD4E4A21C0
        public void OnDisable(){} // RVA: 0x7FFD50C79110
        public void CancelInvoke(){} // RVA: 0x7FFD5153B350
        public void IsInvoking(){} // RVA: 0x7FFD5153B550
        public void StartCoroutine(){} // RVA: 0x7FFD5153B630
        public void IndexOf(){} // RVA: 0x7FFD4E36F0C0
        public void OnApplicationQuit(){} // RVA: 0x7FFD5153B740
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}