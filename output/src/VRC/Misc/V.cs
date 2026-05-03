// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 65
// Methods: 3488

namespace VRC.Misc
{
    /// <summary>Originally: ÎÏÎÏÎÏÎÍÍÌÌÍÏÌÍÏÍÌÎÏÍÍÍ</summary>
    public class VRActiveActionSet_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8215DD20
        public void Equals(){} // RVA: 0x7FFE8215DDD0
        public void GetHashCode(){} // RVA: 0x7FFE8215DE80
        public void op_Implicit(){} // RVA: 0x7FFE8215DF30
        public void CompareBaseObjects(){} // RVA: 0x7FFE8215DFE0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8215E090
        public void GetCachedPtr(){} // RVA: 0x7FFE8215E140
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8215E1F0
        public void Instantiate(){} // RVA: 0x7FFE8215E2A0
    }

    /// <summary>Originally: ÏÍÎÎÏÍÌÌÌÏÏÍÌÌÍÌÍÏÎÌÎÌÍ</summary>
    public class VRCCustomActionDerived_388D : VRCCustomAction
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE826A1190
        public void .ctor(){} // RVA: 0x7FFE826A13D0
        public void Initialize(){} // RVA: 0x7FFE826A1510
        // ── Unresolved (hash) ──
        public void m_6D5(){} // RVA: 0x7FFE826A12B0
        public void m_7DC(){} // RVA: 0x7FFE826A1630
        public void m_780(){} // RVA: 0x7FFE826A1750
        public void m_E7A(){} // RVA: 0x7FFE826A1870
        public void m_C59(){} // RVA: 0x7FFE826A1990
    }

    /// <summary>Originally: ÍÎÏÏÍÌÎÏÏÏÍÌÍÎÌÏÌÏÍÌÌÎÏ</summary>
    public class VRCUiManager : UIManager
    {
        public bool f_F5E; // 0x20
        public ÍÎÍÍÍÍÎÍÏÌÎÌÍÏÍÏÍÏÌÌÎÎÏ f_606; // 0x28
        public System.Action f_F07; // 0x30
        public System.Action f_136; // 0x38
        public System.Action f_B5B; // 0x40
        public System.Action f_21F; // 0x48
        public System.Action`1<bool> f_31D; // 0x50
        public System.Action f_FF4;
        public System.Action f_3FB; // 0x8
        public System.Action`1<bool> f_C07; // 0x10
        public System.Action`1<bool> f_458; // 0x18
        public UnityEngine.GameObject f_8BE; // 0x58
        public UnityEngine.GameObject f_52E; // 0x60
        public UnityEngine.GameObject f_803; // 0x68
        public UnityEngine.GameObject f_3D3; // 0x70
        public UserController f_3AA; // 0x78
        public System.Collections.Generic.HashSet`1<ÏÌÎÍÍÎÍÍÎÏÏÍÏÌÏÎÏÍÍÍÎÎÍ> f_F78; // 0x80
        public 0x6656BD2C f_294; // 0x88
        public bool f_65D; // 0x8C
        public UnityEngine.Transform f_6DA; // 0x90
        public UnityEngine.Transform f_ED6; // 0x98
        public VRC.UI.Core.Styles.StyleEngine f_9D6; // 0xA0
        public ÎÎÌÎÎÏÏÎÎÍÏÏÏÍÎÍÏÍÎÍÌÏÌ f_E22; // 0xA8
        public UnityEngine.GameObject f_E30; // 0xB0

        // ── Methods ──
        public void ShowUIScreen(){} // RVA: 0x7FFE81944180
        public void HideUIScreen_9FE04B0F38A1(){} // RVA: 0x7FFE81946840 | overloaded x2
        public void PushUIPage(){} // RVA: 0x7FFE81944410
        public void PopUIPage(){} // RVA: 0x7FFE81944520
        public void OpenMenuByName(){} // RVA: 0x7FFE81944590
        public void CloseAllMenus(){} // RVA: 0x7FFE81944680
        public void RefreshUIState_1A943EBE1500(){} // RVA: 0x7FFE819455C0 | overloaded x2
        public void SetUIScreenActive(){} // RVA: 0x7FFE819447E0
        public void GetCurrentScreen_521BFD84A47A(){} // RVA: 0x7FFE8194B080 | overloaded x2
        public void DispatchUIEvent(){} // RVA: 0x7FFE811E99D0
        public void RegisterUIScreen(){} // RVA: 0x7FFE81944B90
        public void OnEnable(){} // RVA: 0x7FFE81944C00
        public void UnregisterUIScreen(){} // RVA: 0x7FFE81944C60
        public void ShowQuickMenu(){} // RVA: 0x7FFE81944D50
        public void HideQuickMenu(){} // RVA: 0x7FFE81944D60
        public void OnDisable(){} // RVA: 0x7FFE81944EA0
        public void ToggleMainMenu(){} // RVA: 0x7FFE81944EC0
        public void OnUIInteractionEnd(){} // RVA: 0x7FFE81944F00
        public void GetUIScreenByName(){} // RVA: 0x7FFE819450D0
        public void ShowConfirmDialog(){} // RVA: 0x7FFE819451A0
        public void ShowAlertDialog(){} // RVA: 0x7FFE819452E0
        public void CloseAllDialogs(){} // RVA: 0x7FFE81945350
        public void InitializeAndDispatchUIMessage(){} // RVA: 0x7FFE81945C00
        public void Start(){} // RVA: 0x7FFE81945C70
        public void ProcessUIScreenState(){} // RVA: 0x7FFE81317920
        public void CheckUIElementVisibilityCondition(){} // RVA: 0x7FFE8194C420
        public void ConfigureUIElementInteraction(){} // RVA: 0x7FFE8194C9B0
        public void ProcessActiveUIComponent2(){} // RVA: 0x7FFE8194CD30
        public void GetActiveUIManagerComponent(){} // RVA: 0x7FFE8194D250
        public void PushUIPage_CA8662DD63E8(){} // RVA: 0x7FFE8194DB20
        public void SelectUIManagerProperty(){} // RVA: 0x7FFE8194E540
        public void OnDestroy(){} // RVA: 0x7FFE8194F690
        public void .ctor(){} // RVA: 0x7FFE81950550
        public void Initialize(){} // RVA: 0x7FFE81950650
        public void GetDefaultUIState(){} // RVA: 0x7FFE81950AE0
        public void SetUIA2Value(){} // RVA: 0x7FFE81951CC0
        public void CheckUIElementInitializationState(){} // RVA: 0x7FFE81952A80
        public void CloseAllMenus_BEB05B51D63F(){} // RVA: 0x7FFE819532F0
        public void .cctor(){} // RVA: 0x7FFE81954C60
        public void Awake(){} // RVA: 0x7FFE81955820
        public void CanUIManagerPerformAction(){} // RVA: 0x7FFE819572D0
        public void Update(){} // RVA: 0x7FFE81952920
        // ── 209 unresolved (hash) ──
        public void m_5D4(){} // RVA: 0x7FFE819453C0
        public void m_ED6(){} // RVA: 0x7FFE81945670
        public void m_E84(){} // RVA: 0x7FFE81945760
        public void m_674(){} // RVA: 0x7FFE81945820
        public void m_922(){} // RVA: 0x7FFE819459D0
        // ... 204 more unresolved methods
    }

    /// <summary>Originally: ÏÎÏÍÏÎÍÍÏÏÏÌÏÏÍÎÎÌÌÍÌÌÌ</summary>
    public class VRCUiManagerSiblingSiblingSibling_6B3E : Object
    {
        public UnityEngine.GameObject _m_CachedPtr; // 0x10
        public ÌÎÌÍÎÎÎÍÍÎÏÏÎÏÎÎÍÍÌÏÍÌÏ _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public dFixup.2 f_5F4; // 0x20
        public string f_23E; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE811C3570
        public void Equals(){} // RVA: 0x7FFE810FCE90
        public void GetHashCode(){} // RVA: 0x7FFE8188C4D0
        public void op_Implicit(){} // RVA: 0x7FFE8188C760
        public void CompareBaseObjects(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE8188C8B0
        public void Initialize(){} // RVA: 0x7FFE8188CA00
        public void get_name(){} // RVA: 0x7FFE8188CAA0
        public void set_name(){} // RVA: 0x7FFE8188CD30
        public void Instantiate(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode_A030700E550C(){} // RVA: 0x7FFE8188D1C0
        public void ToString_7DC923B5D028(){} // RVA: 0x7FFE8188D3C0
        public void DoSetValue(){} // RVA: 0x7FFE81129130
        public void ApplyEventFilter(){} // RVA: 0x7FFE8188D460
        public void GetSkeletonType(){} // RVA: 0x7FFE81116380
        public void NeedsSync(){} // RVA: 0x7FFE8188D610
        public void ProcessEventFilter(){} // RVA: 0x7FFE8188D640
        public void InitializeEventFilterState(){} // RVA: 0x7FFE8188D830
        public void Destroy(){} // RVA: 0x7FFE8151D690
        public void ApplyEventFilteringLogic(){} // RVA: 0x7FFE8188D610
        public void DestroyImmediate(){} // RVA: 0x7FFE8188EBD0
        public void GetSkeletonInfo(){} // RVA: 0x7FFE8188EDD0
        public void FindObjectsOfType(){} // RVA: 0x7FFE810FB310
        public void SyncValue(){} // RVA: 0x7FFE8188EF60
    }

    /// <summary>Originally: ÍÌÏÍÌÌÏÎÏÌÎÌÎÎÌÌÌÌÌÍÏÏÍ</summary>
    public class VRCUiManagerSiblingSibling_A576
    {
        // ── 156 unresolved (hash) ──
        public void m_0A9(){}
        public void m_508(){}
        public void m_528(){}
        public void m_B73(){}
        public void m_8A7(){} // RVA: 0x7FFE80E2F150
        // ... 151 more unresolved methods
    }

    /// <summary>Originally: ÎÍÏÍÎÎÎÎÏÏÎÍÎÌÌÌÎÏÍÍÎÌÍ</summary>
    public class VRCUiManagerSiblingSibling_AD07
    {
        // ── Unresolved (hash) ──
        public void m_FDC(){} // RVA: 0x7FFE80E2E2E0
        public void m_4B8(){} // RVA: 0x7FFE80E2EDB0
        public void m_523(){} // RVA: 0x7FFE80E2E2E0
        public void m_4D9(){} // RVA: 0x7FFE80E460A0
        public void m_3BE(){} // RVA: 0x7FFE80E2E2E0
        public void m_A03(){} // RVA: 0x7FFE80E49570
        public void m_663(){} // RVA: 0x7FFE80E45FE0
        public void m_07E(){} // RVA: 0x7FFE80E45FE0
        public void m_697(){} // RVA: 0x7FFE80E460A0
    }

    /// <summary>Originally: ÌÍÏÍÍÎÎÎÎÍÏÌÏÍÎÎÌÍÏÏÏÏÏ</summary>
    public class VRCUiManagerSibling_A133 : Object
    {
        public System.Action f_F07; // 0x10
        public System.Action _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public System.Action f_B5B; // 0x20
        public System.Action f_21F; // 0x28
        public System.Action`1<bool> f_31D; // 0x30
        public string f_2A7; // 0x38
        public ÎÍÏÍÎÎÎÎÏÏÎÍÎÌÌÌÎÏÍÍÎÌÍ f_E37; // 0x40
        public UnityEngine.Canvas f_978; // 0x48
        public UnityEngine.GameObject f_B91; // 0x50
        public ÍÌÏÍÌÌÏÎÏÌÎÌÎÎÌÌÌÌÌÍÏÏÍ f_554; // 0x58
        public ÏÌÍÍÎÍÌÌÎÎÍÌÌÏÏÏÎÎÏÌÎÍÌ f_C68; // 0x60
        public ÏÏÏÏÏÎÍÌÍÎÌÌÎÌÍÌÍÍÎÎÏÍÏ f_16A; // 0x68
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<UnityEngine.Material> f_75F; // 0x70
        public System.Collections.Generic.ISet`1<UnityEngine.Material> f_D32; // 0x78
        public bool f_5E8; // 0x80
        public object f_F07; // 0xB3
        public System.Action ÍÌÌÍÏÌÌÍÎÌÍÎÏÏÌÎÍÏÌÍÌÌÎ; // 0x7BF0
        public object field_17;
        public object field_18; // 0x281
        public object field_19; // 0x6520
        public object field_20; // 0x82C0
        public object field_21; // 0x5C50

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FB320
        public void Equals(){} // RVA: 0x7FFE818A3E10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE818A0430
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE818A1A40 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFE818A0550
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE810FB320
        public void GetCachedPtr(){} // RVA: 0x7FFE818A05A0
        public void get_name(){} // RVA: 0x7FFE818A05F0
        public void set_name(){} // RVA: 0x7FFE818A0650
        public void Instantiate(){} // RVA: 0x7FFE818A0690
        public void ToString(){} // RVA: 0x7FFE818A06F0
        public void Destroy(){} // RVA: 0x7FFE818A0AD0
        public void DestroyImmediate(){} // RVA: 0x7FFE818A3B60 | overloaded x2
        public void FindObjectsOfType(){} // RVA: 0x7FFE818A0CB0
        public void FindObjectsByType(){} // RVA: 0x7FFE818A0EB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE818A0FD0
        public void get_hideFlags(){} // RVA: 0x7FFE818A1030
        public void set_hideFlags(){} // RVA: 0x7FFE818A1080
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE818A2470 | overloaded x2
        public void FindObjectOfType(){} // RVA: 0x7FFE818A12A0
        public void FindFirstObjectByType(){} // RVA: 0x7FFE818A14D0
        public void CheckNullArgument(){} // RVA: 0x7FFE818A1630
        public void op_Equality(){} // RVA: 0x7FFE810FB320
        public void op_Inequality(){} // RVA: 0x7FFE818A38C0 | overloaded x2
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE818A19E0
        public void Internal_CloneSingle(){} // RVA: 0x7FFE81464570
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE818A1B00
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE818A1B50
        public void GetName(){} // RVA: 0x7FFE818A1E00
        public void SetName(){} // RVA: 0x7FFE818A1E50
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE818A2020
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE818A20A0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE818A2410
        public void .ctor(){} // RVA: 0x7FFE818A5A90
        public void Initialize(){} // RVA: 0x7FFE818A5C90
        // ── 144 unresolved (hash) ──
        public void m_E2B(){} // RVA: 0x7FFE811C3590
        public void m_9C1(){} // RVA: 0x7FFE818A07B0
        public void m_02D(){} // RVA: 0x7FFE818A0810
        public void m_4E8(){} // RVA: 0x7FFE818A0860
        public void m_3BE(){} // RVA: 0x7FFE818A0980
        // ... 139 more unresolved methods
    }

    /// <summary>Originally: ÎÍÌÍÌÌÌÌÏÍÍÏÍÎÎÍÌÏÌÏÎÌÍ</summary>
    public class VRC_Interactable : VRC_Interactable
    {
        public ÏÏÍÎÏÌÌÌÌÌÌÌÎÎÍÏÏÎÏÌÌÎÏ cardRenderer; // 0x40

        // ── Methods ──
        public void GetGameObject_6CA(){} // RVA: 0x7FFE82795BD0
        public void GetGameObject_4E4(){} // RVA: 0x7FFE82795C00
        public void OnDestroy_82D152EB85B8(){} // RVA: 0x7FFE82795F80
        public void Update_F8F93D51858D(){} // RVA: 0x7FFE82796150
        public void set_IsInteractive(){} // RVA: 0x7FFE82797F90 | overloaded x7
        public void Getclip(){} // RVA: 0x7FFE827970E0
        public void Getclip_4345D85DEEB3(){} // RVA: 0x7FFE82795BD0
        public void get_IsInteractive(){} // RVA: 0x7FFE811E0850
        public void Getclip_6D40FBB5552E(){} // RVA: 0x7FFE82797160
        public void .ctor(){} // RVA: 0x7FFE815BA3A0
        public void Initialize(){} // RVA: 0x7FFE827977B0
        public void Start(){} // RVA: 0x7FFE82797A80
        public void Update(){} // RVA: 0x7FFE82795F80
        public void set_IsInteractive_B3559D001FFB(){} // RVA: 0x7FFE82797BF0
        public void Getclip_44F45EB375EC(){} // RVA: 0x7FFE82797C20
        public void GetTransform(){} // RVA: 0x7FFE82797BF0
        public void ProcessInteractableState(){} // RVA: 0x7FFE82797DA0
        public void OnDestroy(){} // RVA: 0x7FFE82798150
        public void Interact(){} // RVA: 0x7FFE827982D0
    }

    /// <summary>Originally: ÏÍÎÏÍÎÌÌÍÍÏÌÎÏÌÎÌÌÏÍÎÏÌ</summary>
    public class VRC_InteractableSibling_0286 : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE89AAF900
        public void IsInvoking(){} // RVA: 0x7FFE89AAFB90 | overloaded x2
        public void CancelInvoke(){} // RVA: 0x7FFE89AAFB90
        public void Invoke(){} // RVA: 0x7FFE89AAFB90
        public void InvokeRepeating(){} // RVA: 0x7FFE89AAFD90
        // ── Unresolved (hash) ──
        public void m_0C3(){} // RVA: 0x7FFE89AAFB90
    }

    /// <summary>Originally: ÏÌÏÏÌÍÏÎÌÍÌÎÎÏÌÎÍÍÍÎÎÍÎ</summary>
    public class VRC_InteractableSibling_365D : Object
    {
        public string _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public string f_4B3; // 0x20
        public 0x66569864 f_654; // 0x28
        public 0x66566F24 f_186; // 0x29
        public int f_11E; // 0x2C
        public System.Collections.Generic.List`1<string> f_C1B; // 0x30
        public VRC.Core.ApiInventoryJweToken f_76B; // 0x38
        public object f_C54; // 0x40

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE82B1A600 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFE811290D0
        public void op_Implicit(){} // RVA: 0x7FFE810FE7C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81123200
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE815F1380
        public void GetCachedPtr(){} // RVA: 0x7FFE81161E80
        public void get_name(){} // RVA: 0x7FFE8143BA80
        public void set_name(){} // RVA: 0x7FFE81178740
        public void Instantiate(){} // RVA: 0x7FFE8143BA80
        public void Equals(){} // RVA: 0x7FFE81C15740
        public void GetHashCode(){} // RVA: 0x7FFE811290C0
        public void ToString(){} // RVA: 0x7FFE819C2EA0
        public void ComputegameObject(){} // RVA: 0x7FFE8143BA80
        public void ReadTransformState(){} // RVA: 0x7FFE82B1A380
        public void get_PlayerApiReference(){} // RVA: 0x7FFE810FE7C0
        public void get_IsInvisible(){} // RVA: 0x7FFE82883A50
        public void Destroy(){} // RVA: 0x7FFE8268C820
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x7FFE81116380
        public void DestroyImmediate(){} // RVA: 0x7FFE815F1380
        public void FindObjectsOfType(){} // RVA: 0x7FFE82883A50
        public void FindObjectsByType(){} // RVA: 0x7FFE8143BA80
        public void .cctor(){} // RVA: 0x7FFE810FCE30
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE81F84A50
        // ── Unresolved (hash) ──
        public void m_163(){} // RVA: 0x7FFE8144E200
        public void m_A86(){} // RVA: 0x7FFE8268C820
    }

    /// <summary>Originally: ÎÏÌÏÎÌÌÎÌÎÌÏÎÏÎÍÌÍÎÎÎÌÎ</summary>
    public class VRC_InteractableSibling_4098 : VRC_InteractableSibling_7FBD
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE82603EB0
    }

    /// <summary>Originally: ÌÍÏÌÏÏÌÌÏÏÏÏÌÍÎÌÏÌÎÍÌÏÌ</summary>
    public class VRC_InteractableSibling_7428 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8264CF20
        public void RaiseCancellation(){} // RVA: 0x7FFE8264D090
        public void IsInvoking(){} // RVA: 0x7FFE8264D1F0
        public void CancelInvoke(){} // RVA: 0x7FFE8264D350
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE8264D4B0
        public void SetCancellationCallback(){} // RVA: 0x7FFE8264D610
        // ── Unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFE8264D780
    }

    /// <summary>Originally: ÎÌÍÎÍÎÍÍÍÏÏÎÎÍÎÍÍÌÍÌÍÍÌ</summary>
    public class VRC_InteractableSibling_7FBD : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE825D2AA0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    /// <summary>Originally: ÎÏÌÎÎÎÍÏÎÌÌÌÍÎÌÍÎÌÏÏÌÌÌ</summary>
    public class VRC_InteractableSibling_8E6D
    {
        // ── Unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFE80E460A0
    }

    /// <summary>Originally: ÍÌÌÌÍÌÌÌÏÏÎÎÏÌÌÍÍÍÎÎÏÎÏ</summary>
    public class VRC_InteractableSibling_96C2 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8997C510
        public void RaiseCancellation(){} // RVA: 0x7FFE8997C5E0
        public void IsInvoking(){} // RVA: 0x7FFE8997C760
        public void StartCoroutine(){} // RVA: 0x7FFE8997CD20 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE8997C900
        public void InvokeRepeating(){} // RVA: 0x7FFE8997CA40
        public void CancelInvoke(){} // RVA: 0x7FFE8997CB10
        public void Awake(){} // RVA: 0x7FFE8997C760
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE8997CC50
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8997CDB0
        public void StopCoroutine(){} // RVA: 0x7FFE8997CE40
        // ── Unresolved (hash) ──
        public void m_A1F(){} // RVA: 0x7FFE8997C760
    }

    /// <summary>Originally: ÏÍÍÎÍÍÏÎÎÌÍÌÏÍÍÎÎÎÌÌÌÎÏ</summary>
    public class VRC_InteractableSibling_A120 : animationPlayerComponent_D041
    {
        public ÏÏÎÍÍÏÍÍÌÏÍÌÏÎÏÍÍÌÍÌÌÏÍ _a120; // 0x80

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFE820E94D0
        public void .ctor(){} // RVA: 0x7FFE820E9BC0
        public void Initialize(){} // RVA: 0x7FFE818DBD80
        // ── 15 unresolved (hash) ──
        public void m_081(){} // RVA: 0x7FFE820E8D50
        public void m_2AC(){} // RVA: 0x7FFE820E8EA0
        public void m_D96(){} // RVA: 0x7FFE820E8F10
        public void m_244(){} // RVA: 0x7FFE820E9360
        public void m_AC1(){} // RVA: 0x7FFE820E9370
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÎÍÍÏÌÏÌÍÏÌÎÍÏÌÌÏÎÏÏÍÌÏÎ</summary>
    public class VRC_InteractableSibling_E08C : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE89BC8030
        public void Equals(){} // RVA: 0x7FFE89BC8060
        public void GetHashCode(){} // RVA: 0x7FFE89BC8190
        public void op_Implicit(){} // RVA: 0x7FFE89BC85B0
        public void CompareBaseObjects(){} // RVA: 0x7FFE89BC8630
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE89BC8790
        public void GetCachedPtr(){} // RVA: 0x7FFE89BC8A90
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Initialize(){} // RVA: 0x7FFE89BC8AC0
        public void Instantiate(){} // RVA: 0x7FFE89BC8BD0
        public void ToString(){} // RVA: 0x7FFE89BC8FF0
        public void .ctor_D938B00D69E6(){} // RVA: 0x7FFE89BC9020
        public void Initialize_D0AD42216488(){} // RVA: 0x7FFE89BC8A90
        public void ToString_8D07C6A5CD7F(){} // RVA: 0x7FFE89BC9320
        public void GetLongFromDelegate(){} // RVA: 0x7FFE89BC94B0
        public void GetBooleanFromDelegate(){} // RVA: 0x7FFE89BC8FF0
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFE89BC9820
        // ── Unresolved (hash) ──
        public void m_017(){} // RVA: 0x7FFE89BC93A0
    }

    /// <summary>Originally: ÌÍÎÍÍÎÏÌÎÎÎÏÍÌÌÎÏÎÌÌÏÍÌ</summary>
    public class VRC_InteractableSibling_E9BF : MonoBehaviour
    {
        public float buttonSpacing; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE827AB620
        public void RaiseCancellation(){} // RVA: 0x7FFE827AB8B0
        public void IsInvoking(){} // RVA: 0x7FFE827ABCD0
        public void CancelInvoke(){} // RVA: 0x7FFE827ABF10
        public void Invoke(){} // RVA: 0x7FFE81124030
        public void InvokeRepeating(){} // RVA: 0x7FFE81124030
        public void Start(){} // RVA: 0x7FFE81124020
        public void IsInvoking_1E86269C5B94(){} // RVA: 0x7FFE827AC050
        public void StartCoroutine(){} // RVA: 0x7FFE827AC280
        public void .ctor_F89A74045FF5(){} // RVA: 0x7FFE827AC3A0
        public void Initialize(){} // RVA: 0x7FFE827AC610
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE827AC850
        public void StopCoroutine(){} // RVA: 0x7FFE827ACC50
        public void .ctor(){} // RVA: 0x7FFE827ACEE0
        // ── Unresolved (hash) ──
        public void m_3DA(){} // RVA: 0x7FFE827ACF30
    }

    /// <summary>Originally: ÏÏÏÌÌÌÎÎÍÏÌÎÏÍÌÍÌÏÏÍÌÍÍ</summary>
    public class VRC_InteractableSibling_F29F
    {
        // ── Unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFE80E460A0
    }

    /// <summary>Originally: ÌÏÍÌÌÎÌÌÏÍÏÏÌÍÏÌÌÍÏÎÌÍÏ</summary>
    public class VRC_InteractableSibling_F97C : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8997C760
        public void RaiseCancellation(){} // RVA: 0x7FFE89A97170
        public void IsInvoking(){} // RVA: 0x7FFE89A97230
        public void CancelInvoke(){} // RVA: 0x7FFE89A972F0
        public void Invoke(){} // RVA: 0x7FFE89A97380
        public void InvokeRepeating(){} // RVA: 0x7FFE8997C760
        public void StartCoroutine(){} // RVA: 0x7FFE89A97760
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        // ── Unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFE89A979D0
        public void m_6A4(){} // RVA: 0x7FFE89A976A0
        public void m_A5C(){} // RVA: 0x7FFE89A978A0
    }

    /// <summary>Originally: ÍÍÍÎÎÍÍÎÌÎÏÌÎÌÍÎÌÍÍÌÍÌÍ</summary>
    public class VRC_InteractableSibling_FBCD
    {
        // ── Unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFE810A1420
    }

    /// <summary>Originally: ÎÌÍÌÌÍÎÎÎÎÏÍÎÏÌÍÏÍÏÌÎÍÌ</summary>
    public class VRC_Main : MonoBehaviour
    {
        public ÎÌÍÌÌÍÎÎÎÎÏÍÎÏÌÍÏÍÏÌÎÍÌ _m_CancellationTokenSource;
        public ÎÎÏÏÍÏÎÏÌÏÏÏÌÎÎÎÏÏÌÌÎÍÏ f_CF8; // 0x20
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_B91; // 0x28
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_462; // 0x30
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_7D7; // 0x38
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_543; // 0x40
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_9C9; // 0x48
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_1C7; // 0x50
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_400; // 0x58
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568B54> f_728; // 0x60
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568C04> f_355; // 0x68
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568BAC> f_4B3; // 0x70
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_4FA; // 0x78
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3C1; // 0x80
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_414; // 0x88
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3D5; // 0x90
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3E3; // 0x98
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_753; // 0xA0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E22; // 0xA8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_451; // 0xB0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C15; // 0xB8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_9FA; // 0xC0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_136; // 0xC8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_D05; // 0xD0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F31; // 0xD8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_086; // 0xE0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F62; // 0xE8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_EAE; // 0xF0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_FBA; // 0xF8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_243; // 0x100
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_058; // 0x108
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_D55; // 0x110
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_690; // 0x118
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656949C> f_3B4; // 0x120
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_CF1; // 0x128
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<string> f_CF2; // 0x130
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_94E; // 0x138
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<System.Collections.Generic.List`1<ÏÌÎÏÍÎÍÌÌÎÍÏÍÎÎÍÎÎÏÌÎÍÍ>> f_E3F; // 0x140
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<string> f_36F; // 0x148
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_634; // 0x150
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_BDA; // 0x158
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568E14> f_B54; // 0x160
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C36; // 0x168
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568E6C> f_0CF; // 0x170
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_5C0; // 0x178
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_78C; // 0x180
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_340; // 0x188
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_8F8; // 0x190
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C25; // 0x198
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_941; // 0x1A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_A40; // 0x1A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E6C; // 0x1B0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_40B; // 0x1B8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3FE; // 0x1C0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_9F2; // 0x1C8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E83; // 0x1D0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_686; // 0x1D8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_984; // 0x1E0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_158; // 0x1E8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568AFC> f_C05; // 0x1F0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656B5F4> f_45D; // 0x1F8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656B6FC> f_735; // 0x200
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_CA9; // 0x208
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_8C6; // 0x210
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568F74> f_A44; // 0x218
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F21; // 0x220
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568F74> f_324; // 0x228
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656928C> f_C6D; // 0x230
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_885; // 0x238
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568F74> f_AC1; // 0x240
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C77; // 0x248
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_83C; // 0x250
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_56A; // 0x258
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_B35; // 0x260
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_6A8; // 0x268
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_120; // 0x270
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_947; // 0x278
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665691DC> f_8DC; // 0x280
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_F12; // 0x288
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_917; // 0x290
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_733; // 0x298
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_5B7; // 0x2A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_1D2; // 0x2A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_CDE; // 0x2B0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_06B; // 0x2B8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6664C5B4> f_DCE; // 0x2C0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_41E; // 0x2C8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_74A; // 0x2D0
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<VRC.Localization.LocalizableString> f_E9E; // 0x2D8
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<VRC.Localization.LocalizableString> f_6FB; // 0x2E0
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<VRC.Localization.LocalizableString> f_B33; // 0x2E8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_58B; // 0x2F0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<VRC.Localization.LocalizableString> f_A13; // 0x2F8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3A7; // 0x300
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_EB9; // 0x308
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E26; // 0x310
        public string[] f_321; // 0x318
        public int f_C59; // 0x320
        public int f_BF5; // 0x324
        public int f_C99; // 0x328
        public bool f_3B9; // 0x32C
        public bool f_06D; // 0x32D
        public bool f_D16; // 0x32E
        public bool f_051; // 0x32F
        public bool f_6C8; // 0x330
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_D8A; // 0x338
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665695A4> f_179; // 0x340
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_4FD; // 0x348
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_5D5; // 0x350
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_BBF; // 0x358
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_0F3; // 0x360
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F7F; // 0x368
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_23B; // 0x370
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_EFE; // 0x378
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_218; // 0x380
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66649BC4> f_AB8; // 0x388
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<string> f_75F; // 0x390
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E6D; // 0x398
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<dFixup.X> f_C22; // 0x3A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_833; // 0x3A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C31; // 0x3B0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568D0C> f_319; // 0x3B8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_BD3; // 0x3C0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F53; // 0x3C8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665690D4> f_A04; // 0x3D0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_BCB; // 0x3D8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_62C; // 0x3E0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568D64> f_F8B; // 0x3E8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568DBC> f_9DF; // 0x3F0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_AC0; // 0x3F8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x666CD904> f_1AD; // 0x400
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_A5B; // 0x408
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_CF3; // 0x410
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_44A; // 0x418
        public ÎÌÍÎÌÍÍÍÎÏÌÎÌÍÎÏÌÌÎÎÎÌÏ<float> f_D16; // 0x420
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568EC4> f_3E1; // 0x428
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_02E; // 0x430
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_CDD; // 0x438
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656912C> f_1C4; // 0x440
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_10D; // 0x448
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_220; // 0x450
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_667; // 0x458
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_74B; // 0x460
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66562A64> f_7D5; // 0x468
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66562A64> f_C9B; // 0x470
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_23F; // 0x478
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_B13; // 0x480
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568A4C> f_41E; // 0x488
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568AA4> f_251; // 0x490
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_6C6; // 0x498
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E03; // 0x4A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_3E2; // 0x4A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66569184> f_74F; // 0x4B0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_DA3; // 0x4B8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_9D4; // 0x4C0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_D2E; // 0x4C8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_BD7; // 0x4D0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_5C7; // 0x4D8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_612; // 0x4E0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_E4D; // 0x4E8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_DF7; // 0x4F0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568F1C> f_F76; // 0x4F8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66568CB4> f_C78; // 0x500
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_277; // 0x508
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_481; // 0x510
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_48E; // 0x518
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_68E; // 0x520
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_01C; // 0x528
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_846; // 0x530
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_148; // 0x538
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_B70; // 0x540
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_0BF; // 0x548
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_D73; // 0x550
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_10F; // 0x558
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F88; // 0x560
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66569234> f_8C0; // 0x568
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_942; // 0x570
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_1D8; // 0x578
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_144; // 0x580
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_0B5; // 0x588
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_2AE; // 0x590
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_54A; // 0x598
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_7C1; // 0x5A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_F3F; // 0x5A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665692E4> f_D35; // 0x5B0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3F7; // 0x5B8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_77B; // 0x5C0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_595; // 0x5C8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_C99; // 0x5D0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_735; // 0x5D8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656933C> f_2EB; // 0x5E0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<ÍÍÎÍÍÎÌÎÍÍÍÌÌÎÎÌÎÌÍÏÏÍÎ> f_CF5; // 0x5E8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66569394> f_2EC; // 0x5F0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665693EC> f_EED; // 0x5F8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66569444> f_022; // 0x600
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_239; // 0x608
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_EED; // 0x610
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_651; // 0x618
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x665694F4> f_36E; // 0x620
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656954C> f_292; // 0x628
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_DC7; // 0x630
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_6B6; // 0x638
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_197; // 0x640
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<int> f_5F2; // 0x648
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x66569024> f_450; // 0x650
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<0x6656907C> f_F93; // 0x658
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_6A9; // 0x660
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C0F; // 0x668
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_7A2; // 0x670
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3FC; // 0x678
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_3E3; // 0x680
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_C25; // 0x688
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_5FB; // 0x690
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_43D; // 0x698
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_49B; // 0x6A0
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_111; // 0x6A8
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> f_3DE; // 0x6B0
        public bool f_ECE; // 0x6B8
        public ÍÍÎÍÍÎÌÎÍÍÍÌÌÎÎÌÎÌÍÏÏÍÎ f_9D5; // 0x6C0
        public string f_BB1; // 0x6C8
        public VRC.Localization.LocalizableString f_B7B; // 0x6D0
        public ÎÌÌÌÎÏÌÍÎÌÌÎÏÌÍÎÌÏÎÍÏÍÏ f_CE6; // 0x6F8
        public 0x66568AFC f_737; // 0x700
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ f_B2D; // 0x708
        public bool f_532; // 0x710
        public string f_13D;
        public float f_68B;
        public string f_434;
        public string f_3EC;
        public string f_869;
        public string f_960;
        public float f_AE2;
        public float f_186;
        public System.Lazy`1<string> f_B17; // 0x8
        public System.Collections.Generic.Dictionary`2<string,ÌÎÎÎÍÏÌÎÍÌÏÍÏÍÌÎÍÌÎÍÎÌÎ> f_4DF; // 0x718
        public System.Collections.Generic.List`1<string> f_835; // 0x720
        public VRC.Localization.LocalizableString f_783; // 0x728
        public System.Collections.Generic.List`1<UnityEngine.Resolution> f_A91; // 0x750
        public bool f_933; // 0x758
        public bool f_155; // 0x759
        public 0x66568D64 f_E6C; // 0x75C
        public ÍÎÌÎÍÌÏÏÏÎÎÍÎÏÍÏÍÍÍÏÏÌÌ f_F0A; // 0x760
        public bool f_189; // 0x768
        public string f_F42;
        public object field_244; // 0x11AE
        public object field_245; // 0x11AF
        public object field_246; // 0x11B0
        public object field_247; // 0x11B1
        public object field_248; // 0x11B2
        public object field_249; // 0x11B3
        public object field_250; // 0x11B4
        public object field_251; // 0x11B5
        public object field_252; // 0x11B6

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81B07B40
        public void RaiseCancellation(){} // RVA: 0x7FFE81B07B60
        public void IsInvoking(){} // RVA: 0x7FFE81B07BC0
        public void CancelInvoke(){} // RVA: 0x7FFE81B07E00
        public void Invoke(){} // RVA: 0x7FFE81B07E10
        public void InvokeRepeating(){} // RVA: 0x7FFE81B07F60
        public void InitializeMainState(){} // RVA: 0x7FFE81B08120
        public void UpdateMainLoop(){} // RVA: 0x7FFE81B082E0
        public void StartCoroutine(){} // RVA: 0x7FFE81B08340
        public void ShutdownMain(){} // RVA: 0x7FFE81B083A0
        public void GetMainInstance(){} // RVA: 0x7FFE81B083B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE81B08400
        public void StopCoroutine(){} // RVA: 0x7FFE81B08540
        public void OnApplicationQuit(){} // RVA: 0x7FFE81B085E0
        public void LoadWorldData(){} // RVA: 0x7FFE81B08640
        public void StopAllCoroutines(){} // RVA: 0x7FFE81B16570 | overloaded x2
        public void get_useGUILayout(){} // RVA: 0x7FFE81823850
        public void set_useGUILayout(){} // RVA: 0x7FFE81B08D20
        public void InitializeMainGuardedState(){} // RVA: 0x7FFE81B08D80
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE811661F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE81B08D90
        public void AwaitDisposeAsync(){} // RVA: 0x7FFE81B08DF0
        public void RegisterMainCallback(){} // RVA: 0x7FFE81B08EB0
        public void UnregisterMainCallback(){} // RVA: 0x7FFE81B08F10
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE81B08F20
        public void StartCoroutineManaged(){} // RVA: 0x7FFE81B08F80
        public void InvokeRepeating_978227(){} // RVA: 0x7FFE81B08F90
        public void StopCoroutineManaged(){} // RVA: 0x7FFE81B08FF0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE81B09AD0
        public void GetScriptClassName(){} // RVA: 0x7FFE81B09AE0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE81B09B00
        public void ProcessMainTick(){} // RVA: 0x7FFE81129890
        public void RefreshWorldState(){} // RVA: 0x7FFE81B09B10
        public void OnWorldLoaded(){} // RVA: 0x7FFE81B09B30
        public void OnWorldUnloaded(){} // RVA: 0x7FFE81B09B90
        public void HandleSceneTransition(){} // RVA: 0x7FFE811665F0
        public void InvokeCallback(){} // RVA: 0x7FFE81B0A3A0
        public void Start_AF260C(){} // RVA: 0x7FFE8181E3D0
        public void AwaitDisposeAsync_E2BBE2(){} // RVA: 0x7FFE81B0BC70
        public void set_UpdateScrollOffset(){} // RVA: 0x7FFE81B0DB50
        public void GetGameObject_D96(){} // RVA: 0x7FFE81B0DED0
        public void DoInternal_FromEulerRad_Injected_61E(){} // RVA: 0x7FFE81B0E1B0
        public void InvokeCallback_4704B8(){} // RVA: 0x7FFE81B0E910
        public void SetWorldTag(){} // RVA: 0x7FFE81B0F150
        public void set_touchpadClicked(){} // RVA: 0x7FFE81178740
        public void CancelInvoke_06FC00(){} // RVA: 0x7FFE81B0FEF0
        public void ProbeBucketedCacheEntry(){} // RVA: 0x7FFE8117C8A0
        public void get_editingEnded(){} // RVA: 0x7FFE81B0FFC0
        public void InitializeStateC(){} // RVA: 0x7FFE81B10430
        public void IsCompatibleObject(){} // RVA: 0x7FFE81B10700
        public void LookupMainEntry(){} // RVA: 0x7FFE81B13B90
        public void GetParent_69F(){} // RVA: 0x7FFE81B14100
        public void set_LineRendererRefs(){} // RVA: 0x7FFE81B14260
        public void get_labelElement(){} // RVA: 0x7FFE81B14D50
        public void get_SdkIntegrationNames(){} // RVA: 0x7FFE81B158B0
        public void Start_AF260F(){} // RVA: 0x7FFE81B175C0
        public void Awake(){} // RVA: 0x7FFE81B17A90
        public void OnEnable(){} // RVA: 0x7FFE81B1FD20
        public void FixedUpdate(){} // RVA: 0x7FFE81B1FFE0
        public void LateUpdate(){} // RVA: 0x7FFE8154EB60
        public void OnDisable(){} // RVA: 0x7FFE81B20230
        public void OnApplicationPause(){} // RVA: 0x7FFE81B206F0
        public void OnBecameVisible(){} // RVA: 0x7FFE81B208C0
        public void OnBecameInvisible(){} // RVA: 0x7FFE81B20920
        public void OnCollisionEnter(){} // RVA: 0x7FFE81B20980
        public void OnCollisionStay(){} // RVA: 0x7FFE81B20990
        public void OnCollisionExit(){} // RVA: 0x7FFE811662A0
        public void OnTriggerEnter(){} // RVA: 0x7FFE81B20B30
        public void OnTriggerStay(){} // RVA: 0x7FFE81B20B40
        public void OnTriggerExit(){} // RVA: 0x7FFE81B20B50
        public void get_useGUILayout_68AEE5(){} // RVA: 0x7FFE81B21E30
        public void ReadTransformPosition(){} // RVA: 0x7FFE81B229A0
        public void Update(){} // RVA: 0x7FFE81B22B80
        public void SetLiveChild(){} // RVA: 0x7FFE81B230D0
        public void GetMainInstance_7EE3EB9DBACB(){} // RVA: 0x7FFE81B23920
        public void Initialize(){} // RVA: 0x7FFE81B24210
        public void ComputeactiveSelf(){} // RVA: 0x7FFE81166120
        public void AwaitDisposeAsync_0A052C(){} // RVA: 0x7FFE81B25250
        public void StopAllCoroutines_E73971(){} // RVA: 0x7FFE81B25990
        public void InitializeState(){} // RVA: 0x7FFE81825EC0
        public void .ctor(){} // RVA: 0x7FFE81B270B0
        public void StartCoroutine_91C9B2(){} // RVA: 0x7FFE81B275B0
        public void ProcessNetworkStatus(){} // RVA: 0x7FFE81B288D0
        public void StopAllCoroutines_E73AC0(){} // RVA: 0x7FFE81B28D30
        public void DoInternal_FromEulerRad_Injected_61E_C824A1(){} // RVA: 0x7FFE81B290E0
        public void OnApplicationQuit_CC19519B0A51(){} // RVA: 0x7FFE81B29EF0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE81B2B930
        public void GetRealtime_3B1(){} // RVA: 0x7FFE810FB310
        public void InitializeState_08B453(){} // RVA: 0x7FFE81B2D0E0
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFE81B2D160
        public void get_PhysBoneMaxStretchValue(){} // RVA: 0x7FFE817AB5E0
        public void ProcessEventD(){} // RVA: 0x7FFE81B2DA80
        public void UnregisterMainCallback_9382E38D6D0C(){} // RVA: 0x7FFE81B2E600
        public void GetInstanceID(){} // RVA: 0x7FFE81253460
        public void SetBehaviourEnabled(){} // RVA: 0x7FFE81B31930
        public void op_Implicit(){} // RVA: 0x7FFE81B31B60
        public void get_viewController(){} // RVA: 0x7FFE81318010
        public void LateUpdate_575465(){} // RVA: 0x7FFE81B32330
        public void CheckAsyncGPUReadbackSupport(){} // RVA: 0x7FFE81B32D40
        public void ConvertSliceAndInvokeReceiver(){} // RVA: 0x7FFE81B33040
        public void set_touchpadClicked_6A26A6(){} // RVA: 0x7FFE81B330B0
        public void .cctor(){} // RVA: 0x7FFE81B330D0
        public void GetParent_69F_0E7F92(){} // RVA: 0x7FFE81B33290
        public void ProcessEventE(){} // RVA: 0x7FFE81B337C0
        public void Start(){} // RVA: 0x7FFE81B348A0
        public void AwaitDisposeAsync_E00F50(){} // RVA: 0x7FFE81B34C00
        public void GetAlternateNetworkTargetOrFallback(){} // RVA: 0x7FFE81B364B0
        public void ProbeBucketedCacheEntry_E12B68(){} // RVA: 0x7FFE81B368B0
        public void OnDestroy(){} // RVA: 0x7FFE81B36F70
        public void GetRealtime_3B1_642660(){} // RVA: 0x7FFE81B37570
        public void GetConditionalPropertyAtOffset1096(){} // RVA: 0x7FFE81B38060
        public void set_buttonEast(){} // RVA: 0x7FFE81B38350
        public void GetIKSolver(){} // RVA: 0x7FFE81B39DB0
        // ── 781 unresolved (hash) ──
        public void m_5E8(){} // RVA: 0x7FFE81B09BD0
        public void m_79A(){} // RVA: 0x7FFE81176730
        public void m_8D8(){} // RVA: 0x7FFE81B09BE0
        public void m_9CB(){} // RVA: 0x7FFE81B09C20
        public void m_36D(){} // RVA: 0x7FFE81B21A20
        // ... 776 more unresolved methods
    }

    /// <summary>Originally: ÎÍÍÍÍÌÎÎÏÏÏÏÏÏÎÏÎÍÏÌÌÎÍ</summary>
    public class VRC_MainSiblingSibling_A4C5
    {
        // ── Unresolved (hash) ──
        public void m_701(){} // RVA: 0x7FFE80E2E2E0
        public void m_F61(){} // RVA: 0x7FFE80E2F150
        public void m_ACB(){} // RVA: 0x7FFE80E4BC00
        public void m_4C1(){} // RVA: 0x7FFE80E31D70
        public void m_157(){} // RVA: 0x7FFE80E4F230
    }

    /// <summary>Originally: ÎÎÌÏÎÏÍÏÏÏÎÌÍÎÏÎÌÌÍÎÍÏÎ</summary>
    public class VRC_MainSibling_0DE2 : Object
    {
        public int _m_CachedPtr;
        public int _offsetOfInstanceIDInCPlusPlusObject;
        public int f_5B6;
        public int f_1A3;
        public int f_885;
        public string f_30A;
        public System.Nullable`1<bool> f_749;
        public bool f_708; // 0x10
        public int f_84F; // 0x14

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81E29080
        public void set_name(){} // RVA: 0x7FFE81E29960 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE81E29310
        public void op_Implicit(){} // RVA: 0x7FFE81E29320
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FB320
        public void Dispose(){} // RVA: 0x7FFE81E29360
        public void Cleanup(){} // RVA: 0x7FFE81E29480
        public void get_name(){} // RVA: 0x7FFE81E296C0
        public void Instantiate(){} // RVA: 0x7FFE81E29BB0
        public void .ctor(){} // RVA: 0x7FFE81E29C90
        public void Initialize(){} // RVA: 0x7FFE810FB320
        public void ToString(){} // RVA: 0x7FFE81E2AF20
        public void Equals(){} // RVA: 0x7FFE8164B230
        public void GetNativeOffset(){} // RVA: 0x7FFE81E2B040
        public void TryGetNext(){} // RVA: 0x7FFE81E29310
        public void GetPropertyValueAtOffset1504(){} // RVA: 0x7FFE813DB630
        public void GetNextItem(){} // RVA: 0x7FFE81E2B120
        public void FindObjectsOfType(){} // RVA: 0x7FFE811C55F0
        public void Destroy(){} // RVA: 0x7FFE81E2B1D0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE81E2B3D0
        public void DestroyImmediate(){} // RVA: 0x7FFE81E2B3E0
        public void DestroyImmediate_A07026CAC5FE(){} // RVA: 0x7FFE81E2B510
        public void DestroyImmediate_20627D42CA40(){} // RVA: 0x7FFE8164E0F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE8144DF00
        public void FindObjectsByType(){} // RVA: 0x7FFE81E2B550
        public void GetPropertyValue(){} // RVA: 0x7FFE811C55E0
    }

    /// <summary>Originally: ÏÎÎÌÏÍÏÌÍÌÍÍÍÍÌÎÌÍÌÏÍÎÌ</summary>
    public class VRC_MainSibling_34A3 : Object
    {
        public string _m_CachedPtr;
        public int _offsetOfInstanceIDInCPlusPlusObject;
        public int f_F6F;
        public long f_F31;
        public long f_8F7;
        public int f_2DF;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8293BB30
        public void Equals(){} // RVA: 0x7FFE8293BB80
        public void GetHashCode(){} // RVA: 0x7FFE82944A90 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFE81463AE0
        public void CompareBaseObjects(){} // RVA: 0x7FFE8293BD50
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8293C100
        public void GetCachedPtr(){} // RVA: 0x7FFE8293C130
        public void get_name(){} // RVA: 0x7FFE8293C1F0
        public void set_name(){} // RVA: 0x7FFE8293C560
        public void Instantiate(){} // RVA: 0x7FFE8293CC90
        public void .ctor(){} // RVA: 0x7FFE8293CFE0
        public void Initialize(){} // RVA: 0x7FFE8293D7A0
        public void ToString(){} // RVA: 0x7FFE8293DB30
        public void GetVideoTracks(){} // RVA: 0x7FFE8293DC40
        public void get_PointerPose(){} // RVA: 0x7FFE8293E360
        public void IsInvoking(){} // RVA: 0x7FFE8293EC30
        public void op_Implicit_D010221CAFD3(){} // RVA: 0x7FFE8293EE20
        public void set_useGUILayout(){} // RVA: 0x7FFE8293F060
        public void print(){} // RVA: 0x7FFE8293F130
        public void Destroy(){} // RVA: 0x7FFE8293BB30
        public void GetName(){} // RVA: 0x7FFE82942320 | overloaded x4
        public void DestroyImmediate(){} // RVA: 0x7FFE81282380
        public void FindObjectsOfType(){} // RVA: 0x7FFE8293F890
        public void FindObjectsByType(){} // RVA: 0x7FFE8293FA60
        public void GetMediaTrack(){} // RVA: 0x7FFE8293FEE0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE82940100
        public void .ctor_591DF5C02B1F(){} // RVA: 0x7FFE82940440
        public void FindObjectOfType(){} // RVA: 0x7FFE829405C0
        public void FindFirstObjectByType(){} // RVA: 0x7FFE82940840
        public void Update(){} // RVA: 0x7FFE829408E0
        public void CheckNullArgument(){} // RVA: 0x7FFE82942250 | overloaded x2
        public void FindObjectOfType_078CFB7CA95C(){} // RVA: 0x7FFE82940AF0
        public void DoublePropertyCountClamped(){} // RVA: 0x7FFE8293C100
        public void RegisterPointerOverlay(){} // RVA: 0x7FFE82940BC0
        public void InitializeMediaTracks(){} // RVA: 0x7FFE82940F50
        public void set_name_6C0243933F8F(){} // RVA: 0x7FFE82941060
        public void op_Equality(){} // RVA: 0x7FFE82941140
        public void op_Inequality(){} // RVA: 0x7FFE82941540
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE82941A30
        public void Internal_CloneSingle(){} // RVA: 0x7FFE82941AC0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE82941F50
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE811C3590
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE8179C860
        public void SetName(){} // RVA: 0x7FFE82942630
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE829426F0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE82942730
        public void CheckClothEnabled(){} // RVA: 0x7FFE82942AA0
        public void set_name_866B34219CD7(){} // RVA: 0x7FFE82943180
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE829431E0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE82943390
        public void SyncConstraintTranslationOffsets(){} // RVA: 0x7FFE81280C30
        public void UpdatePointerPose(){} // RVA: 0x7FFE829435F0
        public void SetOverlay(){} // RVA: 0x7FFE829438D0
        public void ResolveMediaLookup(){} // RVA: 0x7FFE829439C0
        public void op_Implicit_900516DDCA6C(){} // RVA: 0x7FFE829439F0
        public void ResetAndRebuildComponentState(){} // RVA: 0x7FFE82943B20
        public void ResolveInstanceFromId(){} // RVA: 0x7FFE82943B50
        public void op_Implicit_65EF6E099D85(){} // RVA: 0x7FFE82943C10
        public void GetDeltaTime_06E(){} // RVA: 0x7FFE829442D0
        public void SetSyncedFloatFieldAt592(){} // RVA: 0x7FFE82944460
        public void ApplyConstraintTranslation(){} // RVA: 0x7FFE82944920
        public void DoSetPositionAndRotation_Injected_1F8(){} // RVA: 0x7FFE82944C70
        public void BuildLongFormattedMessage(){} // RVA: 0x7FFE82944D40
    }

    /// <summary>Originally: ÎÍÌÍÍÍÎÎÎÌÍÌÌÎÍÌÎÌÎÎÎÏÎ</summary>
    public class VRC_MainSibling_4E6F : Object
    {
        public System.Lazy`1<string> _m_CachedPtr;
        public ÎÍÌÍÍÍÎÎÎÌÍÌÌÎÍÌÎÌÎÎÎÏÎ _offsetOfInstanceIDInCPlusPlusObject; // 0x8
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<VRC.Core.ApiModeration>> f_8B0; // 0x10
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<VRC.Core.ApiPlayerModeration>> f_3BA; // 0x18
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>> f_5DE; // 0x20
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>> f_DE9; // 0x28
        public float f_97D;
        public System.TimeSpan f_4CC; // 0x30
        public bool f_6B8; // 0x38
        public float f_CCF; // 0x3C
        public System.DateTime f_1B7; // 0x40

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81477EE0
        public void Equals(){} // RVA: 0x7FFE81477FD0
        public void GetHashCode(){} // RVA: 0x7FFE81478020
        public void op_Implicit(){} // RVA: 0x7FFE814781B0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81478260
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE814782C0
        public void GetCachedPtr(){} // RVA: 0x7FFE81478320
        public void get_name(){} // RVA: 0x7FFE814783A0
        public void set_name(){} // RVA: 0x7FFE81478530
        public void Instantiate(){} // RVA: 0x7FFE81478870
        public void ToString(){} // RVA: 0x7FFE81478AC0
        public void .ctor(){} // RVA: 0x7FFE81479430
        public void Initialize(){} // RVA: 0x7FFE8147A760
        public void Destroy(){} // RVA: 0x7FFE8148C840 | overloaded x2
        public void DestroyImmediate(){} // RVA: 0x7FFE8147B3A0
        public void FindObjectsOfType(){} // RVA: 0x7FFE8147BB20
        public void FindObjectsByType(){} // RVA: 0x7FFE8147BDB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE8147C0D0
        public void get_hideFlags(){} // RVA: 0x7FFE8147C4B0
        public void set_hideFlags(){} // RVA: 0x7FFE81166040
        public void FindObjectOfType(){} // RVA: 0x7FFE8147CA70
        public void FindFirstObjectByType(){} // RVA: 0x7FFE8147CC80
        public void Finalize(){} // RVA: 0x7FFE8147D1E0
        public void CheckNullArgument(){} // RVA: 0x7FFE8147D750
        public void op_Equality(){} // RVA: 0x7FFE8147DD80
        public void op_Inequality(){} // RVA: 0x7FFE8147DE00
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE8147E220
        public void Internal_CloneSingle(){} // RVA: 0x7FFE8147EEB0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE8147F0C0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE8147F4E0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE8147F580
        public void GetName(){} // RVA: 0x7FFE8147FD20
        public void SetName(){} // RVA: 0x7FFE8147FEF0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE814800F0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE81480310
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE81480960
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE81480A60
        public void .cctor(){} // RVA: 0x7FFE814880C0
        // ── 98 unresolved (hash) ──
        public void m_8F6(){} // RVA: 0x7FFE81478B10
        public void m_052(){} // RVA: 0x7FFE81478CD0
        public void m_BF0(){} // RVA: 0x7FFE81479220
        public void m_7BF(){} // RVA: 0x7FFE8147A810
        public void m_6AC(){} // RVA: 0x7FFE8147A9C0
        // ... 93 more unresolved methods
    }

    /// <summary>Originally: ÎÎÏÏÍÏÎÏÌÏÏÏÌÎÎÎÏÏÌÌÎÍÏ</summary>
    public class VRC_MainSibling_8CBB : Object
    {
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> _m_CachedPtr; // 0x10
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<string> _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_165; // 0x20
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x665695A4> f_179; // 0x28
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C07; // 0x30
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_5E0; // 0x38
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C4A; // 0x40
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CF3; // 0x48
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_ABD; // 0x50
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_74D; // 0x58
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_161; // 0x60
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_833; // 0x68
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C31; // 0x70
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<string> f_7DD; // 0x78
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_90E; // 0x80
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_E6D; // 0x88
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_CF3; // 0x90
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_44A; // 0x98
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_D16; // 0xA0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568EC4> f_3E1; // 0xA8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_02E; // 0xB0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_CDD; // 0xB8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656912C> f_950; // 0xC0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_10D; // 0xC8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_220; // 0xD0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_667; // 0xD8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_74B; // 0xE0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<string> f_7D5; // 0xE8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66562A64> f_C9B; // 0xF0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_23F; // 0xF8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_B13; // 0x100
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C82; // 0x108
        public ÏÌÎÌÎÌÏÎÎÍÏÌÏÌÎÍÍÌÏÌÍÌÎ<string> f_330; // 0x110
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<string> f_36F; // 0x118
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568C04> f_601; // 0x120
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568BAC> f_4B3; // 0x128
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_4FA; // 0x130
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3C1; // 0x138
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568B54> f_FAE; // 0x140
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C15; // 0x148
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_B9C; // 0x150
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_422; // 0x158
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_D05; // 0x160
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_136; // 0x168
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<dFixup.rals> f_94E; // 0x170
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_F6A; // 0x178
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_A40; // 0x180
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_35A; // 0x188
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_34D; // 0x190
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_56A; // 0x198
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_800; // 0x1A0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_70D; // 0x1A8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3FE; // 0x1B0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_0C7; // 0x1B8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_B08; // 0x1C0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_89C; // 0x1C8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66649BC4> f_AB8; // 0x1D0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_681; // 0x1D8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CA9; // 0x1E0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_8C6; // 0x1E8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568F74> f_A44; // 0x1F0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_F21; // 0x1F8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568F74> f_324; // 0x200
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_885; // 0x208
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568F74> f_AC1; // 0x210
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656928C> f_C6D; // 0x218
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C77; // 0x220
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_F31; // 0x228
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_086; // 0x230
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_E98; // 0x238
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_EAE; // 0x240
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_FBA; // 0x248
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_243; // 0x250
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_058; // 0x258
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_ECB; // 0x260
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_E45; // 0x268
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656949C> f_1AA; // 0x270
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CF1; // 0x278
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_23B; // 0x280
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_218; // 0x288
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CF0; // 0x290
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_B35; // 0x298
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_5C7; // 0x2A0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568CB4> f_C78; // 0x2A8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656BEE4> f_D21; // 0x2B0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_DC2; // 0x2B8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6664C5B4> f_B5B; // 0x2C0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_277; // 0x2C8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_481; // 0x2D0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_48E; // 0x2D8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_68E; // 0x2E0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_01C; // 0x2E8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_8A3; // 0x2F0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> f_524; // 0x2F8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> f_825; // 0x300
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_613; // 0x308
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_062; // 0x310
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_277; // 0x318
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_291; // 0x320
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3BB; // 0x328
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_6A8; // 0x330
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_120; // 0x338
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_947; // 0x340
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x665691DC> f_4B9; // 0x348
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_F12; // 0x350
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_917; // 0x358
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_733; // 0x360
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_1D2; // 0x368
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_5B7; // 0x370
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x664AE12C> f_056; // 0x378
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568A4C> f_F71; // 0x380
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_2CA; // 0x388
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_ADC; // 0x390
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568AA4> f_251; // 0x398
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66569184> f_74F; // 0x3A0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_3E2; // 0x3A8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656B5F4> f_0D9; // 0x3B0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656B6FC> f_961; // 0x3B8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66569024> f_EB3; // 0x3C0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656907C> f_08C; // 0x3C8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_6A9; // 0x3D0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_C0F; // 0x3D8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_7A2; // 0x3E0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3FC; // 0x3E8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3E3; // 0x3F0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_4B1; // 0x3F8
        public ÏÌÎÌÎÌÏÎÎÍÏÌÏÌÎÍÍÌÏÌÍÌÎ<bool> f_4E6; // 0x400
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_43D; // 0x408
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_72E; // 0x410
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_13B; // 0x418
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_3DE; // 0x420
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_B91; // 0x428
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_462; // 0x430
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_7D7; // 0x438
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_555; // 0x440
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_F60; // 0x448
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<float> f_1C7; // 0x450
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_414; // 0x458
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3D5; // 0x460
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3E3; // 0x468
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_165; // 0x470
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_19D; // 0x478
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_451; // 0x480
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> f_E66; // 0x488
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> f_32D; // 0x490
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_AC0; // 0x498
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CD1; // 0x4A0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_97E; // 0x4A8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x666CD904> f_1AD; // 0x4B0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_A5B; // 0x4B8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<string> f_80E; // 0x4C0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3A7; // 0x4C8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<int> f_DC7; // 0x4D0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66569654> f_A2A; // 0x4D8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<ÎÌÍÏÍÍÌÏÎÎÍÌÏÎÏÌÍÏÌÎÏÌÍ> f_488; // 0x4E0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x665695FC> f_A63; // 0x4E8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_CDE; // 0x4F0
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_FE7; // 0x4F8
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_2FE; // 0x500
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_9A8; // 0x508
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568E14> f_713; // 0x510
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_3F8; // 0x518
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66568E6C> f_8F8; // 0x520
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_B43; // 0x528
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_2D1; // 0x530
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_BF2; // 0x538
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_4EF; // 0x540
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_A41; // 0x548
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_541; // 0x550
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x665690D4> f_5CC; // 0x558
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_D8C; // 0x560
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_238; // 0x568
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<bool> f_4E4; // 0x570
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x6656933C> f_2EB; // 0x578
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66569394> f_2EC; // 0x580
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x665693EC> f_EED; // 0x588
        public ÏÌÍÍÏÏÎÍÏÍÎÏÌÍÍÎÎÍÎÌÌÌÌ<0x66569444> f_EDA; // 0x590
        public float f_B04;
        public float f_1BB;
        public float f_D7B;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81B32390
        public void Equals(){} // RVA: 0x7FFE81B2FCE0
        public void GetHashCode(){} // RVA: 0x7FFE81B23520
        public void op_Implicit(){} // RVA: 0x7FFE81B13290
        public void CompareBaseObjects(){} // RVA: 0x7FFE81B26F00
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81253460
        public void GetCachedPtr(){} // RVA: 0x7FFE81B0E510
        public void get_name(){} // RVA: 0x7FFE81B10190
        public void set_name(){} // RVA: 0x7FFE8154EB60
        public void Instantiate(){} // RVA: 0x7FFE8119C0E0
        public void ToString(){} // RVA: 0x7FFE811661F0
        public void Destroy(){} // RVA: 0x7FFE81B30F60
        public void DestroyImmediate(){} // RVA: 0x7FFE81B09AD0
        public void FindObjectsOfType(){} // RVA: 0x7FFE81B2E4C0
        public void FindObjectsByType(){} // RVA: 0x7FFE81318010
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE815BB6A0
        public void get_hideFlags(){} // RVA: 0x7FFE81B281A0
        public void set_hideFlags(){} // RVA: 0x7FFE81B15410
        public void FindObjectOfType(){} // RVA: 0x7FFE811C3500
        public void FindFirstObjectByType(){} // RVA: 0x7FFE81B33CE0
        public void CheckNullArgument(){} // RVA: 0x7FFE81176D50
        public void op_Equality(){} // RVA: 0x7FFE810FCE30
        public void op_Inequality(){} // RVA: 0x7FFE81B146A0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE81B14A90
        public void Internal_CloneSingle(){} // RVA: 0x7FFE81B0DE50
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE810FE7C0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE81B32320
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE81B66890
        public void GetName(){} // RVA: 0x7FFE81B13B90
        public void SetName(){} // RVA: 0x7FFE81B164E0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE81B0AAA0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE81166660
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE81B2D840
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE81B12420
        public void .ctor(){} // RVA: 0x7FFE81B668C0
        public void Initialize(){} // RVA: 0x7FFE81B13BA0
        // ── 158 unresolved (hash) ──
        public void m_FF1(){} // RVA: 0x7FFE8181EA60
        public void m_292(){} // RVA: 0x7FFE81B08F10
        public void m_6A4(){} // RVA: 0x7FFE81B36F60
        public void m_BE8(){} // RVA: 0x7FFE81B373C0
        public void m_3B3(){} // RVA: 0x7FFE81B0BC70
        // ... 153 more unresolved methods
    }

    /// <summary>Originally: ÎÏÌÌÌÌÏÏÏÏÌÎÌÍÍÎÍÏÏÏÍÍÎ</summary>
    public class VRC_MainSibling_F4F7
    {
        // ── 344 unresolved (hash) ──
        public void m_848(){} // RVA: 0x7FFE80E2E2E0
        public void m_C19(){} // RVA: 0x7FFE80E2E2E0
        public void m_5A9(){} // RVA: 0x7FFE80E2E2E0
        public void m_8BF(){} // RVA: 0x7FFE80E2E2E0
        public void m_79A(){} // RVA: 0x7FFE80E2E2E0
        // ... 339 more unresolved methods
    }

    /// <summary>Originally: ÎÌÎÍÎÎÏÌÏÏÏÍÏÍÍÏÍÎÏÍÌÌÏ</summary>
    public class VRC_Secondary : MonoBehaviour
    {
        public ÎÌÎÍÎÎÏÌÏÏÏÍÏÍÍÏÍÎÏÍÌÌÏ _m_CancellationTokenSource;
        public System.Action f_6F4; // 0x8
        public System.Action`1<float> f_E21; // 0x10
        public string f_4AF;
        public bool f_294; // 0x20
        public UnityEngine.Transform f_FE8; // 0x28
        public ÎÏÏÏÎÍÎÌÍÏÏÍÏÍÎÌÏÌÎÏÍÎÎ f_B15; // 0x30
        public ÎÎÎÏÏÏÍÌÍÍÎÏÎÍÌÎÍÏÎÍÏÎÎ f_1ED; // 0x38
        public ÎÎÌÎÌÏÏÌÌÍÍÏÎÌÌÎÌÌÌÌÌÏÏ f_AD3; // 0x40
        public ÌÎÎÍÌÎÏÍÏÎÍÏÎÎÍÌÏÍÎÍÌÎÌ f_287; // 0x48
        public bool f_705; // 0x50
        public UnityEngine.Sprite f_2D1; // 0x58
        public string f_944; // 0x60
        public string f_C0A; // 0x68
        public string f_D67; // 0x70
        public string f_314; // 0x78
        public string f_F58; // 0x80
        public string f_DF3; // 0x88
        public string f_CD8; // 0x90
        public string f_2F1; // 0x98
        public string f_B7E; // 0xA0
        public string f_81C; // 0xA8
        public string f_C3B; // 0xB0
        public string f_A47;
        public string f_F1B;
        public ÏÎÏÌÍÏÎÍÏÍÌÌÌÍÌÏÎÎÍÌÏÎÌ f_BC2; // 0xB8
        public ÍÏÎÏÍÍÌÌÍÏÏÌÏÌÎÌÌÌÍÎÎÌÏ _bodyEstimation; // 0xC0
        public UnityEngine.GameObject f_6C6; // 0xC8
        public UnityEngine.GameObject f_406; // 0xD0
        public UnityEngine.GameObject f_362; // 0xD8
        public UnityEngine.Transform _inverseScaleRoot; // 0xE0
        public VRC.IMDraw f_12C; // 0x18
        public ÎÎÎÍÏÍÌÍÏÍÌÍÍÍÎÏÍÏÏÏÌÏÌ f_305; // 0x20
        public ÎÎÎÍÏÍÌÍÏÍÌÍÍÍÎÏÍÏÏÏÌÏÌ f_ACF; // 0x28
        public ÎÎÎÍÏÍÌÍÏÍÌÍÍÍÎÏÍÏÏÏÌÏÌ f_C36; // 0x30
        public System.Collections.Generic.Dictionary`2<string,ÎÎÎÍÏÍÌÍÏÍÌÍÍÍÎÏÍÏÏÏÌÏÌ> f_C35; // 0x38
        public UnityEngine.Transform f_81A; // 0x40
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_625; // 0x48
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_D18; // 0x50
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_63C; // 0x58
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_D4F; // 0x60
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_E6F; // 0x68
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_094; // 0x70
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_3E6; // 0x78
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ f_69C; // 0x80
        public System.Collections.Generic.List`1<string> f_2CD; // 0x88
        public float[] f_E43; // 0x90
        public ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ[] f_035; // 0x98
        public bool[] f_016; // 0xA0
        public bool f_4C1; // 0xA8
        public bool f_5FB; // 0xA9
        public bool f_0C9; // 0xAA
        public bool f_FE3; // 0xAB
        public bool f_68A; // 0xAC
        public bool f_9C3; // 0xE8
        public bool f_0A3; // 0xE9
        public System.Collections.Generic.List`1<ÌÌÌÌÏÎÎÏÌÌÎÏÌÏÏÏÍÏÎÎÍÍÌ> f_16D; // 0xF0
        public System.Collections.Generic.Dictionary`2<dFixup.ionSource,ÏÏÌÌÍÍÍÌÍÌÌÏÏÍÌÎÏÌÏÍÍÍÎ> f_AD1; // 0xB0
        public float f_10A; // 0xB8
        public float f_D02; // 0xBC
        public float f_FE2; // 0xC0
        public float f_718; // 0xC4
        public UnityEngine.Vector3 f_0B9; // 0xC8
        public UnityEngine.Vector3 f_9F4; // 0xD4
        public UnityEngine.Vector3 f_046; // 0xE0
        public bool f_A69; // 0xEC
        public int f_4C3; // 0xF0
        public float f_3A0;
        public float f_22A;
        public float f_59D;
        public float f_043;
        public float f_C32;
        public float f_1F9;
        public float f_D99;
        public float f_33E;
        public float f_1E0;
        public float f_3E9;
        public float f_723;
        public float f_199;
        public string f_EC3;
        public bool f_877; // 0xF8
        public bool f_C6A; // 0xF9
        public bool f_410; // 0xFA
        public UnityEngine.Vector3 f_B8D; // 0xFC
        public UnityEngine.Quaternion f_A5D; // 0x108
        public float f_559; // 0x118
        public UnityEngine.Vector3 f_AED; // 0x11C
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_BAC; // 0x128
        public ÏÏÎÏÎÌÍÏÎÌÏÎÎÍÎÎÌÏÍÎÎÎÌ f_CDB; // 0x130
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ f_837; // 0x138
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ f_30C; // 0x140
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ f_4BB; // 0x148
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ f_E6E; // 0x150
        public bool f_13A; // 0x158
        public bool f_0A1; // 0x159
        public dFixup.ionSource f_97F; // 0x15C
        public dFixup.ionSource f_E02; // 0x160
        public dFixup.ionSource f_836; // 0x164
        public dFixup.ionSource f_2A2; // 0x168
        public UnityEngine.Vector3 f_EAC; // 0x16C
        public UnityEngine.Quaternion f_9F8; // 0x178
        public float f_4B8; // 0x188
        public float f_699; // 0x18C
        public float f_ECD; // 0x190
        public float f_A64;
        public float f_9BD;
        public bool f_986; // 0x194
        public float f_298;
        public float f_4D6;
        public string f_C03;
        public string f_9BD;
        public string f_1BA;
        public int f_993; // 0x198
        public string f_491;
        public string f_47C;
        public string f_2FF;
        public string f_CD6;
        public string f_67C;
        public string f_236;
        public string f_19E;
        public string f_488;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8227AF40
        public void RaiseCancellation(){} // RVA: 0x7FFE8227B050
        public void IsInvoking(){} // RVA: 0x7FFE8227B2D0
        public void CancelInvoke(){} // RVA: 0x7FFE8227B480
        public void Invoke(){} // RVA: 0x7FFE8227B860
        public void InvokeRepeating(){} // RVA: 0x7FFE8227BA00
        public void StartCoroutine(){} // RVA: 0x7FFE8227BBB0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8227C3E0
        public void StopCoroutine(){} // RVA: 0x7FFE8227C870
        public void StopAllCoroutines(){} // RVA: 0x7FFE81B310E0
        public void get_useGUILayout(){} // RVA: 0x7FFE8227C9D0
        public void set_useGUILayout(){} // RVA: 0x7FFE8227CAA0
        public void print(){} // RVA: 0x7FFE8227CE40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE81B2CB80
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE8227CEA0
        public void InvokeDelayed(){} // RVA: 0x7FFE8227CF00
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE8227D100
        public void StartCoroutineManaged(){} // RVA: 0x7FFE8227D160
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE8227D540
        public void SetSyncedBoolFieldAt704(){} // RVA: 0x7FFE8227D5A0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE815ADA20
        public void GetScriptClassName(){} // RVA: 0x7FFE8227D700
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE8227DDC0
        public void GetUnscaledDeltaTime(){} // RVA: 0x7FFE8227E660
        public void SetSyncedFloatFieldAt120(){} // RVA: 0x7FFE8227F190
        public void set_OwnerGameObjectRef(){} // RVA: 0x7FFE81B26FF0
        public void set_PhysBoneGrabRange(){} // RVA: 0x7FFE8227FA90
        public void set_ScaleConstraintRefs(){} // RVA: 0x7FFE81B208C0
        public void GetBackingFieldFromProperty_592(){} // RVA: 0x7FFE82280C00
        public void OnEnable(){} // RVA: 0x7FFE82281F20
        public void FixedUpdate(){} // RVA: 0x7FFE81B2E600
        public void LateUpdate(){} // RVA: 0x7FFE82282820
        public void OnDisable(){} // RVA: 0x7FFE82283E40
        public void OnApplicationPause(){} // RVA: 0x7FFE82284920
        public void OnApplicationQuit(){} // RVA: 0x7FFE82284990
        public void OnBecameVisible(){} // RVA: 0x7FFE82284B40
        public void OnBecameInvisible(){} // RVA: 0x7FFE82284BA0
        public void OnCollisionEnter(){} // RVA: 0x7FFE82284CE0
        public void set_OwnerGameObjectRef_06E033(){} // RVA: 0x7FFE81B0DEC0
        public void OnCollisionExit(){} // RVA: 0x7FFE82284D50
        public void OnTriggerEnter(){} // RVA: 0x7FFE82284E70
        public void OnTriggerStay(){} // RVA: 0x7FFE82284ED0
        public void OnTriggerExit(){} // RVA: 0x7FFE82284F70
        public void GetUnityEngine(){} // RVA: 0x7FFE822881B0
        public void GetParameterValueBySlotType(){} // RVA: 0x7FFE82288FB0
        public void GetConditionalPropertyAtOffset1112(){} // RVA: 0x7FFE82289B20
        public void SetLocalPosition(){} // RVA: 0x7FFE8228BE30
        public void Update(){} // RVA: 0x7FFE8228FB00
        public void OnCollisionStay(){} // RVA: 0x7FFE82290240
        public void set_RotationConstraintSourceWeights(){} // RVA: 0x7FFE82290690
        public void OnDestroy(){} // RVA: 0x7FFE82290A30
        public void GetUnityEngine_17CAF5(){} // RVA: 0x7FFE822926E0
        public void set_DynamicBoneStiffness(){} // RVA: 0x7FFE82292D80
        public void get_ColliderTransformArray(){} // RVA: 0x7FFE82293120
        public void Awake(){} // RVA: 0x7FFE822939A0
        public void LookRotation(){} // RVA: 0x7FFE822944A0
        public void .cctor(){} // RVA: 0x7FFE82294B00
        public void Start(){} // RVA: 0x7FFE82297110
        public void IsLocalPlayerInstanceOwner(){} // RVA: 0x7FFE8229A0A0
        public void SyncAllDirtyProperties(){} // RVA: 0x7FFE81B0B080
        public void set_PhysBoneImmobileWorldRef(){} // RVA: 0x7FFE822A16D0
        public void SyncAllDirtyProperties_055511(){} // RVA: 0x7FFE822A1E80
        public void SetSyncedBoolFieldAt400(){} // RVA: 0x7FFE810A1420
        public void GetRawPointerFieldAtOffset_240(){} // RVA: 0x7FFE822A3EB0
        public void ResetAndRebuildComponentState(){} // RVA: 0x7FFE822A4760
        public void SetSyncedBoolFieldAt1160(){} // RVA: 0x7FFE822A5450
        public void GetUnityEngine_60DE08(){} // RVA: 0x7FFE822A5750
        public void DoOpenURL(){} // RVA: 0x7FFE822A59F0
        public void GetCurrentPlatformModeIndex(){} // RVA: 0x7FFE81B0F100
        public void GetBackingFieldFromProperty_1080(){} // RVA: 0x7FFE81B31110
        public void .ctor(){} // RVA: 0x7FFE822AAF40
        public void Initialize(){} // RVA: 0x7FFE81B2FC70
        public void set_LineRendererRefs(){} // RVA: 0x7FFE822AF1B0
        public void SetIntPropertyWithRangeFilter(){} // RVA: 0x7FFE822B2240
        // ── 399 unresolved (hash) ──
        public void m_174(){} // RVA: 0x7FFE822A70C0
        public void m_937(){} // RVA: 0x7FFE817EFE00
        public void m_5EF(){} // RVA: 0x7FFE8228B470
        public void m_655(){} // RVA: 0x7FFE8227C030
        public void m_428(){} // RVA: 0x7FFE8227C8D0
        // ... 394 more unresolved methods
    }

    /// <summary>Originally: ÏÌÏÏÌÏÍÏÍÌÏÎÍÏÎÍÍÎÎÏÏÏÎ</summary>
    public class VRC_SecondarySiblingSibling_5BC3 : Object
    {
        public UnityEngine.Camera _5BC3; // 0x10
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<float> _5BC32; // 0x18
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> _5BC33; // 0x20
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> _5BC34; // 0x28
        public object field_4; // 0xF82
        public object field_5; // 0xF83
        public object field_6; // 0xF84
        public object field_7; // 0xF85
        public object field_8; // 0xF86
        public object field_9; // 0xF87
        public object field_10; // 0xF88
        public object field_11; // 0xF89
        public object field_12; // 0xF8A
        public object field_13; // 0xF8B
        public object field_14; // 0xF8C
        public object field_15; // 0xF8D
        public object field_16; // 0xF8E
        public object field_17; // 0xF8F
        public object field_18; // 0xF90
        public object field_19; // 0xF91
        public object field_20; // 0xF92
        public object field_21; // 0xF93
        public object field_22; // 0xF94
        public object field_23; // 0xF95
        public object field_24; // 0xF96
        public object field_25; // 0xF97
        public object field_26; // 0xF98
        public object field_27; // 0xF99
        public object field_28; // 0xF9A
        public object field_29; // 0xF9B
        public object field_30; // 0xF9C
        public object field_31; // 0xF9D
        public object field_32; // 0xF9E
        public object field_33; // 0xF9F
        public object field_34; // 0xFA0
        public object field_35; // 0xFA1
        public object field_36; // 0xFA2
        public object field_37; // 0xFA3
        public object field_38; // 0xFA4
        public object field_39; // 0xFA5
        public object field_40; // 0xFA6
        public object field_41; // 0xFA7
        public object field_42; // 0xFA8
        public object field_43; // 0xFA9
        public object field_44; // 0xFAA
        public object field_45; // 0xFAB
        public object field_46; // 0xFAC
        public object field_47; // 0xFAD
        public object field_48; // 0xFAE
        public object field_49; // 0xFAF
        public object field_50; // 0xFB0
        public object field_51; // 0xFB1
        public object field_52; // 0xFB2
        public object field_53; // 0xFB3
        public object field_54; // 0xFB4
        public object field_55; // 0xFB5

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8189D940
        public void Equals(){} // RVA: 0x7FFE8189D9A0
        public void GetHashCode(){} // RVA: 0x7FFE8189DB40
        public void op_Implicit(){} // RVA: 0x7FFE8189DBA0
        public void CompareBaseObjects(){} // RVA: 0x7FFE8189DC10
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE811290D0
        public void GetCachedPtr(){} // RVA: 0x7FFE8189DC70
        public void get_name(){} // RVA: 0x7FFE8189DCD0
        public void set_name(){} // RVA: 0x7FFE811E0850
        public void Instantiate(){} // RVA: 0x7FFE8189DD10
        public void ToString(){} // RVA: 0x7FFE8189DD50
        public void Destroy(){} // RVA: 0x7FFE8189E010
        public void .ctor(){} // RVA: 0x7FFE8189E090
        public void Initialize(){} // RVA: 0x7FFE8189E2C0
        public void FindObjectsOfType(){} // RVA: 0x7FFE8189E320
        public void FindObjectsByType(){} // RVA: 0x7FFE8189E3C0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE811290C0
        public void get_hideFlags(){} // RVA: 0x7FFE8189E480
        public void set_hideFlags(){} // RVA: 0x7FFE8189E4C0
        public void FindObjectOfType(){} // RVA: 0x7FFE8189E520
        public void FindFirstObjectByType(){} // RVA: 0x7FFE8189E580
        public void CheckNullArgument(){} // RVA: 0x7FFE8189E620
        public void op_Equality(){} // RVA: 0x7FFE8189E7A0
        public void op_Inequality(){} // RVA: 0x7FFE8189E800
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE8189E860
        public void Internal_CloneSingle(){} // RVA: 0x7FFE8189E8C0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE8189E900
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE8189E960
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE8189E9C0
        public void GetName(){} // RVA: 0x7FFE8189EA80
        public void SetName(){} // RVA: 0x7FFE8189EAE0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE8189EB40
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE8189EBA0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE8189ECC0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE8189D9A0
        // ── 58 unresolved (hash) ──
        public void m_3C8(){} // RVA: 0x7FFE8189DDB0
        public void m_09E(){} // RVA: 0x7FFE8189DDF0
        public void m_F92(){} // RVA: 0x7FFE8189DE50
        public void m_658(){} // RVA: 0x7FFE8186F320
        public void m_C60(){} // RVA: 0x7FFE8189DE90
        // ... 53 more unresolved methods
    }

    /// <summary>Originally: ÌÎÏÎÍÌÎÏÏÏÌÏÏÍÏÌÏÏÌÎÌÏÎ</summary>
    public class VRC_SecondarySibling_B38C
    {
        // ── Unresolved (hash) ──
        public void m_EC2(){} // RVA: 0x7FFE80E2E2E0
        public void m_E23(){} // RVA: 0x7FFE80E2E2E0
        public void m_D47(){} // RVA: 0x7FFE80E460A0
        public void m_9D7(){} // RVA: 0x7FFE80E460A0
    }

    /// <summary>Originally: ÌÎÎÏÌÎÍÍÍÍÏÎÎÏÌÏÎÏÎÌÍÎÍ</summary>
    public class VRC_SecondarySibling_FC53
    {
        // ── 83 unresolved (hash) ──
        public void m_B64(){} // RVA: 0x7FFE80E2F150
        public void m_185(){} // RVA: 0x7FFE80E2E2E0
        public void m_C60(){} // RVA: 0x7FFE80E2DCF0
        public void m_538(){} // RVA: 0x7FFE80E2E2E0
        public void m_A47(){} // RVA: 0x7FFE80E4F230
        // ... 78 more unresolved methods
    }

    /// <summary>Originally: ÎÍÌÎÌÌÌÎÏÍÍÌÍÎÏÌÎÌÏÏÎÍÍ</summary>
    public class VRC_UiShapeDerived_DC9A : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE825E4980
        public void Initialize(){} // RVA: 0x7FFE825E49F0
        public void Start(){} // RVA: 0x7FFE825E4A20
        // ── Unresolved (hash) ──
        public void m_FA0(){} // RVA: 0x7FFE825E4A80
        public void m_539(){} // RVA: 0x7FFE825E51E0
        public void m_30A(){} // RVA: 0x7FFE825E49F0
        public void m_964(){} // RVA: 0x7FFE825E5240
        public void m_317(){} // RVA: 0x7FFE825E49F0
        public void m_236(){} // RVA: 0x7FFE825E49F0
        public void m_664(){} // RVA: 0x7FFE825E5A60
        public void m_5A5(){} // RVA: 0x7FFE825E5AC0
    }

    /// <summary>Originally: ÌÍÎÎÎÍÌÏÌÎÏÏÏÌÏÌÏÍÌÌÎÌÌ</summary>
    public class VRControllerAxis_t : ValueType
    {
    }

    /// <summary>Originally: ÌÌÌÌÏÌÏÏÍÍÎÎÍÍÍÎÌÌÎÍÍÏÎ</summary>
    public class VRControllerState_t_Packed : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82125BB0
        public void Equals(){} // RVA: 0x7FFE82125BB0
        public void GetHashCode(){} // RVA: 0x7FFE82125BE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82125BB0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82125BB0
        public void GetCachedPtr(){} // RVA: 0x7FFE82125BB0
        public void get_name(){} // RVA: 0x7FFE82125D30
        public void set_name(){} // RVA: 0x7FFE82125BB0
        public void Instantiate(){} // RVA: 0x7FFE82125BB0
        public void ToString(){} // RVA: 0x7FFE82125BB0
        // ── Unresolved (hash) ──
        public void m_974(){} // RVA: 0x7FFE82125BB0
        public void m_8B2(){} // RVA: 0x7FFE82125BB0
    }

    /// <summary>Originally: ÌÎÍÎÏÎÍÌÎÏÍÍÏÍÎÏÌÏÌÍÌÏÌ</summary>
    public class VREvent_ApplicationLaunch_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE820F8510
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE820F89F0
        public void op_Implicit(){} // RVA: 0x7FFE820F8ED0
        public void CompareBaseObjects(){} // RVA: 0x7FFE820F93B0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE820F9890
        public void GetCachedPtr(){} // RVA: 0x7FFE820F9D70
        public void get_name(){} // RVA: 0x7FFE820FA250
        public void set_name(){} // RVA: 0x7FFE820FA730
        public void Instantiate(){} // RVA: 0x7FFE820FAC00
    }

    /// <summary>Originally: ÎÌÎÏÎÏÏÎÍÍÍÍÎÏÎÌÏÏÍÍÏÏÌ</summary>
    public class VREvent_DualAnalog_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82100400
        public void Equals(){} // RVA: 0x7FFE82100530
        public void GetHashCode(){} // RVA: 0x7FFE82100660
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82100790
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE821008C0
        public void GetCachedPtr(){} // RVA: 0x7FFE821009F0
        public void get_name(){} // RVA: 0x7FFE82100B20
        public void set_name(){} // RVA: 0x7FFE82100C50
    }

    /// <summary>Originally: ÍÌÌÎÏÍÍÎÍÎÍÏÍÍÍÍÍÏÌÍÌÍÎ</summary>
    public class VREvent_EditingCameraSurface_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE899B4B00
        public void Equals(){} // RVA: 0x7FFE899B4D10
        public void GetHashCode(){} // RVA: 0x7FFE899B4F20
        public void op_Implicit(){} // RVA: 0x7FFE899B5130
        public void CompareBaseObjects(){} // RVA: 0x7FFE899B5340
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE899B5550
        public void GetCachedPtr(){} // RVA: 0x7FFE899B5760
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÍÍÌÍÏÌÍÍÌÍÌÌÎÏÌÌÌÌÏÍÌÏÎ</summary>
    public class VREvent_HapticVibration_t : ValueType
    {
    }

    /// <summary>Originally: ÌÍÏÌÎÏÎÍÍÌÏÏÏÌÏÏÍÎÌÌÌÎÏ</summary>
    public class VREvent_InputActionManifestLoad_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82104910
        public void Equals(){} // RVA: 0x7FFE82104F10
        public void GetHashCode(){} // RVA: 0x7FFE82105520
        public void op_Implicit(){} // RVA: 0x7FFE82105B40
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82106150
        public void GetCachedPtr(){} // RVA: 0x7FFE82106760
        public void get_name(){} // RVA: 0x7FFE82106D60
        public void set_name(){} // RVA: 0x7FFE82107370
    }

    /// <summary>Originally: ÎÍÎÍÏÏÏÍÏÏÌÎÍÌÏÎÌÌÍÎÏÏÏ</summary>
    public class VREvent_InputBindingLoad_t : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82101CB0
        public void Equals(){} // RVA: 0x7FFE821021A0
        public void op_Implicit(){} // RVA: 0x7FFE82102680
        public void CompareBaseObjects(){} // RVA: 0x7FFE82102B70
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82103060
        public void GetCachedPtr(){} // RVA: 0x7FFE82103550
        public void get_name(){} // RVA: 0x7FFE82103A40
        public void set_name(){} // RVA: 0x7FFE82103F30
        public void Instantiate(){} // RVA: 0x7FFE82104420
    }

    /// <summary>Originally: ÌÏÎÏÏÏÎÏÍÎÎÍÍÏÌÍÎÌÎÎÏÎÎ</summary>
    public class VREvent_MessageOverlay_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE820FC100
        public void Equals(){} // RVA: 0x7FFE820FC5F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE820FCAE0
        public void CompareBaseObjects(){} // RVA: 0x7FFE820FCFD0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE820FD4C0
        public void GetCachedPtr(){} // RVA: 0x7FFE820FD9B0
        public void get_name(){} // RVA: 0x7FFE820FDEA0
        public void set_name(){} // RVA: 0x7FFE820FE390
    }

    /// <summary>Originally: ÍÍÌÏÍÎÏÍÍÏÍÎÏÍÎÌÍÍÌÏÎÏÌ</summary>
    public class VREvent_Mouse_t : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DD4520
        public void InternalEquals(){} // RVA: 0x7FFE82DD4580
        public void Dispose(){} // RVA: 0x7FFE82DD46D0
        public void Cleanup(){} // RVA: 0x7FFE82DD4730
        public void InternalGetHashCode(){} // RVA: 0x7FFE82DD4880
        public void GetHashCode(){} // RVA: 0x7FFE82DD49D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DD4B20
        public void ToString(){} // RVA: 0x7FFE82DD4B80
    }

    /// <summary>Originally: ÏÍÎÍÌÏÌÌÍÌÍÍÎÍÏÎÏÏÎÏÍÍÍ</summary>
    public class VREvent_PerformanceTest_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE820F5160
        public void Equals(){} // RVA: 0x7FFE820F5290
        public void GetHashCode(){} // RVA: 0x7FFE820F53C0
        public void op_Implicit(){} // RVA: 0x7FFE820F54F0
        public void CompareBaseObjects(){} // RVA: 0x7FFE820F5620
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE820F5750
        public void GetCachedPtr(){} // RVA: 0x7FFE820F5880
        public void get_name(){} // RVA: 0x7FFE820F59B0
        public void set_name(){} // RVA: 0x7FFE820F5AE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÎÏÎÏÏÏÎÎÎÍÍÍÍÌÎÏÍÎÎÎÏÏ</summary>
    public class VREvent_Property_t : ValueType
    {
    }

    /// <summary>Originally: ÍÏÍÌÌÌÍÎÍÍÏÍÌÏÍÏÍÏÎÌÌÎÍ</summary>
    public class VREvent_ScreenshotProgress_t : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE820F7F90
        public void Equals(){} // RVA: 0x7FFE820F8040
        public void op_Implicit(){} // RVA: 0x7FFE820F80F0
        public void CompareBaseObjects(){} // RVA: 0x7FFE820F81A0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE820F8250
        public void GetCachedPtr(){} // RVA: 0x7FFE820F8300
        public void get_name(){} // RVA: 0x7FFE820F83B0
        public void set_name(){} // RVA: 0x7FFE820F8460
    }

    /// <summary>Originally: ÎÎÎÌÏÌÎÏÎÏÎÌÏÌÎÌÎÎÌÍÎÎÌ</summary>
    public class VREvent_Screenshot_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE820F6960
        public void Equals(){} // RVA: 0x7FFE820F6AF0
        public void GetHashCode(){} // RVA: 0x7FFE820F6E20
        public void op_Implicit(){} // RVA: 0x7FFE820F7150
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE820F7480
        public void GetCachedPtr(){} // RVA: 0x7FFE820F77B0
        public void get_name(){} // RVA: 0x7FFE820F7940
        public void set_name(){} // RVA: 0x7FFE820F7AD0
        public void Instantiate(){} // RVA: 0x7FFE820F7C60
    }

    /// <summary>Originally: ÍÌÏÌÍÌÎÏÏÎÎÏÏÎÏÏÏÎÌÏÌÌÏ</summary>
    public class VREvent_SpatialAnchor_t : ValueType
    {
    }

    /// <summary>Originally: ÍÏÎÍÏÎÏÌÏÍÎÍÎÍÏÌÍÍÌÌÏÏÍ</summary>
    public class VREvent_Status_t : ValueType
    {
    }

    /// <summary>Originally: ÎÏÎÎÏÏÎÍÍÌÏÍÏÎÏÌÌÍÏÍÏÌÌ</summary>
    public class VREvent_TouchPadMove_t
    {
        // ── Unresolved (hash) ──
        public void m_6D7(){} // RVA: 0x7FFE80E2E2E0
        public void m_A51(){} // RVA: 0x7FFE80E2DCF0
    }

    /// <summary>Originally: ÌÍÏÎÎÎÎÎÏÌÌÏÏÎÏÏÍÍÍÏÏÎÍ</summary>
    public class VREvent_WebConsole_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE821017B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82101850
        public void op_Implicit(){} // RVA: 0x7FFE821018F0
        public void CompareBaseObjects(){} // RVA: 0x7FFE82101990
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82101A30
        public void GetCachedPtr(){} // RVA: 0x7FFE82101AD0
        public void get_name(){} // RVA: 0x7FFE82101B70
        public void set_name(){} // RVA: 0x7FFE82101C10
    }

    /// <summary>Originally: ÌÍÌÍÎÎÎÏÏÏÎÌÎÏÏÌÎÏÏÎÍÎÌ</summary>
    public class VREvent_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82109810
        public void Equals(){} // RVA: 0x7FFE82109B90
        public void GetHashCode(){} // RVA: 0x7FFE82109F10
        public void op_Implicit(){} // RVA: 0x7FFE8210A290
        public void CompareBaseObjects(){} // RVA: 0x7FFE8210A610
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8210A990
        public void GetCachedPtr(){} // RVA: 0x7FFE8210AD10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8210B090
        public void Instantiate(){} // RVA: 0x7FFE8210B410
    }

    /// <summary>Originally: ÌÍÏÌÌÌÌÏÍÎÍÏÌÏÌÎÏÏÎÌÌÎÍ</summary>
    public class VREvent_t_Packed : ValueType
    {
    }

    /// <summary>Originally: ÌÎÍÍÍÏÏÍÎÌÍÎÍÌÍÏÎÍÍÌÏÎÏ</summary>
    public class VRMessageOverlayResponse : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DC9B20
        public void InternalEquals(){} // RVA: 0x7FFE82DC9BE0
        public void Dispose(){} // RVA: 0x7FFE82DC9CA0
        public void Cleanup(){} // RVA: 0x7FFE82DC9CF0
        public void InternalGetHashCode(){} // RVA: 0x7FFE82DC9DB0
        public void GetHashCode(){} // RVA: 0x7FFE82DC9E00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DC9E50
    }

    /// <summary>Originally: ÍÍÌÏÍÏÍÎÌÌÎÍÌÍÏÎÍÎÍÎÏÎÌ</summary>
    public class VROverlayFlags : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_8E4; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ResetStructFields(){} // RVA: 0x7FFE81D7E9E0
        public void SetupUIManagerModule(){} // RVA: 0x7FFE8284EF60
        // ── Unresolved (hash) ──
        public void m_1D2(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÌÏÌÌÏÎÌÎÍÎÍÎÍÍÌÏÌÍÍÍÎÍÌ</summary>
    public class VROverlayIntersectionMaskPrimitive_t : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DDB060
        public void InternalEquals(){} // RVA: 0x7FFE82DDB0B0
        public void DefaultEquals(){} // RVA: 0x7FFE82DDB170
        public void GetHashCode(){} // RVA: 0x7FFE82DDB230
        public void InternalGetHashCode(){} // RVA: 0x7FFE82DDB280
        public void ToString(){} // RVA: 0x7FFE82DDB2D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DDB390
        public void Dispose(){} // RVA: 0x7FFE82DDB4A0
        // ── Unresolved (hash) ──
        public void m_FB5(){} // RVA: 0x7FFE82DDB450
    }

    /// <summary>Originally: ÌÎÎÎÎÌÌÏÌÎÌÍÎÏÌÎÏÏÎÌÌÌÎ</summary>
    public class VROverlayIntersectionParams_t : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DD94C0
        public void InternalEquals(){} // RVA: 0x7FFE82DD9580
        public void DefaultEquals(){} // RVA: 0x7FFE82DD96F0
        public void GetHashCode(){} // RVA: 0x7FFE82DD97B0
        public void InternalGetHashCode(){} // RVA: 0x7FFE82DD9990
        public void Dispose(){} // RVA: 0x7FFE82DD9B70
        public void Cleanup(){} // RVA: 0x7FFE82DD9C30
        public void ToString(){} // RVA: 0x7FFE82DD9E10
    }

    /// <summary>Originally: ÎÏÎÏÏÍÏÏÎÎÎÍÎÏÍÏÏÎÏÎÌÎÎ</summary>
    public class Vector2Int : Object
    {
        public ÎÎÎÏÌÏÏÏÍÍÌÏÎÏÌÎÌÍÌÌÍÎÌ _eC4B;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82D39EF0
        public void Equals(){} // RVA: 0x7FFE82D3A0C0
    }

    /// <summary>Originally: ÏÎÏÏÍÌÏÌÌÍÍÎÌÌÏÏÌÎÍÏÍÎÎ</summary>
    public class Vector3
    {
    }

    /// <summary>Originally: ÍÌÍÍÏÎÌÍÏÎÍÌÏÏÍÌÏÏÏÌÍÎÏ</summary>
    public class Vector3Int : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÍÎÏÍÍÎÎÌÏÎÍÍÎÏÏÍÏÎÍÏÍÌÏ</summary>
    public class Vector4 : ValueType
    {
        public ÍÎÏÍÍÎÎÌÏÎÍÍÎÏÏÍÏÎÍÏÍÌÏ _99BE;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82B08D20
        public void InternalEquals(){} // RVA: 0x7FFE82B08DD0
        public void DefaultEquals(){} // RVA: 0x7FFE82B08E80
        public void GetHashCode(){} // RVA: 0x7FFE82B08F30
        public void InternalGetHashCode(){} // RVA: 0x7FFE82B08FE0
        public void ToString(){} // RVA: 0x7FFE82B09090
        public void .cctor(){} // RVA: 0x7FFE82B09140
        public void .ctor(){} // RVA: 0x7FFE8111ED70
        public void Initialize(){} // RVA: 0x7FFE82B091E0
        // ── Unresolved (hash) ──
        public void m_07E(){} // RVA: 0x7FFE82B09290
    }

    /// <summary>Originally: ÍÌÌÏÏÍÎÎÎÌÏÍÌÌÏÌÌÏÍÍÍÎÏ</summary>
    public class VertexAttribute : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81F48800
        public void Equals(){} // RVA: 0x7FFE81F48800
        public void GetHashCode(){} // RVA: 0x7FFE81F48800
        public void op_Implicit(){} // RVA: 0x7FFE81F48800
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81F48800
        public void GetCachedPtr(){} // RVA: 0x7FFE81F48800
        public void get_name(){} // RVA: 0x7FFE81F48800
        public void set_name(){} // RVA: 0x7FFE81F48800
    }

    /// <summary>Originally: ÌÌÎÍÌÏÎÎÎÏÌÏÏÏÎÏÏÎÍÏÏÍÌ</summary>
    public class VertexAttributeFormat : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81F487D0
        public void Equals(){} // RVA: 0x7FFE81F487D0
        public void GetHashCode(){} // RVA: 0x7FFE81F487D0
        public void op_Implicit(){} // RVA: 0x7FFE81F487D0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81F487D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81F487D0
        public void get_name(){} // RVA: 0x7FFE81F487D0
    }

    /// <summary>Originally: ÍÎÌÌÍÎÌÏÌÎÎÎÏÌÏÍÍÍÏÎÎÍÏ</summary>
    public class value_18ED
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFE80E45FE0
        public void get_value(){} // RVA: 0x7FFE80E2EDB0
        public void set_value(){} // RVA: 0x7FFE80E46530
    }

    /// <summary>Originally: ÏÍÎÏÌÎÍÌÍÍÍÍÎÏÍÌÍÍÏÎÏÎÏ</summary>
    public class visualizerComponent_3E06 : MonoBehaviour
    {
        public UnityEngine.GameObject _visualizer; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE89D28970
        public void OnEnable(){} // RVA: 0x7FFE89D28C80
        public void IsInvoking(){} // RVA: 0x7FFE81437330
        public void CancelInvoke(){} // RVA: 0x7FFE81437330
        public void Invoke(){} // RVA: 0x7FFE89D28D90
        public void InvokeRepeating(){} // RVA: 0x7FFE89D28E20
        public void Start(){} // RVA: 0x7FFE8143BA80
        public void OnDestroy(){} // RVA: 0x7FFE8143BA80
        public void .ctor(){} // RVA: 0x7FFE89D28F40
        public void Initialize(){} // RVA: 0x7FFE89D29060
        public void OnDisable(){} // RVA: 0x7FFE89D29070
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE89D29190
        public void StopCoroutine(){} // RVA: 0x7FFE8143BA80
        public void OnCollisionStay(){} // RVA: 0x7FFE89D29490
        public void OnCollisionExit(){} // RVA: 0x7FFE89D29530
    }

}