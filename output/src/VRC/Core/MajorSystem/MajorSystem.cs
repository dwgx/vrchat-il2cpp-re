// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.MajorSystem
// Classes: 14
// Methods: 1953

namespace VRC.Core.MajorSystem
{
    /// <summary>Originally: ÏÏÏÌÌÍÎÌÍÏÏÎÎÍÌÌÍÏÎÌÌÍÍ</summary>
    public class ComplexComponent_0B13 : MonoBehaviour
    {
        public float _destroyCancellationToken;
        public float _useGUILayout;
        public float f_807;
        public float f_B0B;
        public float f_049;
        public float f_F61;
        public float f_524;
        public float ÍÎÏÎÌÏÎÍÎÍÏÍÏÏÌÎÌÎÏÌÎÍÌ;
        public float ÎÏÎÏÍÎÌÎÌÎÌÌÏÌÎÏÌÍÎÍÏÎÍ;
        public int ÍÍÏÌÏÌÏÎÏÌÍÍÍÌÎÍÍÌÎÎÏÍÍ;
        public int ÍÏÌÍÎÍÌÏÍÍÌÎÎÍÏÌÎÎÍÍÎÎÌ;
        public bool ÌÏÏÏÍÍÍÎÍÎÌÏÍÌÏÏÍÌÏÏÎÎÌ; // 0x20
        public float <ÏÌÎÏÏÍÏÍÎÏÏÏÌÌÎÍÎÌÏÌÍÌÍ>k__BackingField; // 0x24
        public float <ÏÌÏÎÏÎÍÎÌÎÎÍÍÏÍÏÌÎÏÏÌÍÌ>k__BackingField; // 0x28
        public float <ÎÏÌÍÎÏÎÍÏÌÎÎÏÍÎÎÌÍÎÎÌÌÏ>k__BackingField; // 0x2C
        public UnityEngine.GameObject controlPointPrefab; // 0x30
        public UnityEngine.GameObject curvePointPrefab; // 0x38
        public UnityEngine.GameObject pathSegmentPrefab; // 0x40
        public UnityEngine.GameObject streamCamPrefab; // 0x48
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ playPathButton; // 0x50
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ stopPathButton; // 0x58
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ clearLastButton; // 0x60
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ clearAllButton; // 0x68
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ clearAllConfirmButton; // 0x70
        public ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ addPointButton; // 0x78
        public ÌÎÏÌÌÌÏÏÏÏÎÎÌÎÏÏÌÍÍÍÎÌÏ pathsStayVisibleToggle; // 0x80
        public UnityEngine.GameObject importModal; // 0x88
        public UnityEngine.UI.Button importPaste; // 0x90
        public UnityEngine.UI.Button importSubmit; // 0x98
        public UnityEngine.UI.Button importClose; // 0xA0
        public UnityEngine.GameObject exportModal; // 0xA8
        public UnityEngine.UI.Button exportSubmit; // 0xB0
        public UnityEngine.UI.Button exportClose; // 0xB8
        public X ÏÍÌÍÌÌÎÎÍÎÏÎÍÍÌÎÍÌÎÍÍÌÍ; // 0xC0
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ MotionTooltip; // 0xC8
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ EasingTooltip; // 0xD0
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ InterpolationTooltip; // 0xD8
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ LoopingTooltip; // 0xE0
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ CaptureTooltip; // 0xE8
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ AudioSourceTooltip; // 0xF0
        public ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ StreamingTooltip; // 0xF8
        public UnityEngine.GameObject cineCameraModel; // 0x100
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ PointCountText; // 0x108
        public bool ÌÌÍÏÎÌÏÌÍÌÌÏÌÏÎÌÍÍÎÏÍÎÏ; // 0x110
        public bool ÎÎÏÌÌÎÏÌÌÏÎÏÏÌÌÍÌÌÎÌÏÎÏ; // 0x111
        public bool <ÏÏÍÏÎÎÎÎÍÏÍÏÌÌÎÏÌÏÍÍÌÍÍ>k__BackingField; // 0x112
        public bool ÎÎÍÎÌÌÏÍÎÍÍÍÌÌÎÌÌÌÍÌÏÎÎ; // 0x113
        public bool ÌÎÏÎÎÌÏÌÏÎÎÌÍÎÎÍÍÏÌÌÏÍÌ; // 0x114
        public bool ÏÎÎÌÎÍÍÍÏÍÏÏÎÍÍÌÍÎÎÌÍÌÍ; // 0x115
        public bool ÌÍÏÎÎÎÏÍÌÌÎÍÍÍÏÏÏÌÍÏÍÏÍ; // 0x116
        public bool ÌÏÎÍÌÏÌÏÏÌÏÎÌÌÎÍÌÍÏÌÌÏÍ; // 0x117
        public bool ÌÎÎÍÎÌÍÍÏÎÏÏÌÎÎÏÎÎÍÏÍÍÏ; // 0x118
        public bool ÍÌÏÌÍÎÍÎÍÎÎÌÏÏÎÌÎÍÏÍÌÎÏ; // 0x119
        public bool ÏÍÍÌÏÌÌÍÏÎÎÎÏÌÎÏÎÏÎÎÎÌÍ; // 0x11A
        public ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ ÎÌÎÎÍÏÎÏÎÌÍÏÍÌÎÏÍÏÌÎÌÎÎ; // 0x120
        public ÏÎÎÌÎÍÍÌÍÌÏÎÍÍÍÏÎÎÏÌÎÍÎ ÌÎÍÌÏÏÌÍÏÏÎÍÍÎÎÌÍÍÎÍÌÌÎ; // 0x128
        public UnityEngine.Transform ÎÏÎÎÍÍÎÏÎÏÎÌÏÎÎÌÎÍÍÏÌÏÌ; // 0x130
        public UnityEngine.Coroutine ÌÍÍÍÎÎÏÌÍÎÏÌÌÏÏÌÌÍÌÍÏÌÏ; // 0x138
        public UnityEngine.Coroutine ÍÎÏÌÎÌÌÌÏÍÌÌÎÏÏÌÏÌÌÏÎÌÎ; // 0x140
        public UnityEngine.Coroutine ÍÏÎÎÍÍÍÌÌÏÎÍÌÌÎÍÍÍÌÍÌÏÍ; // 0x148
        public ÍÎÌÌÍÎÎÏÎÍÌÏÌÍÍÎÎÍÎÌÌÏÍ ÍÌÍÏÏÍÍÍÎÌÎÏÎÍÍÌÌÎÏÍÍÎÎ; // 0x150
        public ÎÏÎÏÌÌÍÎÍÍÎÍÍÌÍÍÍÌÌÍÏÍÌ ÍÌÍÌÍÎÏÍÍÌÏÌÏÎÌÏÏÌÎÌÎÍÏ; // 0x158
        public System.Collections.Generic.List`1<ÍÎÌÌÍÎÎÏÎÍÌÏÌÍÍÎÎÍÎÌÌÏÍ> ÎÎÍÍÎÏÌÍÌÌÎÎÏÍÌÍÏÍÏÎÌÏÍ; // 0x160
        public int ÌÍÎÌÌÎÏÌÌÎÍÌÌÏÏÍÎÍÌÌÍÍÍ; // 0x168
        public 0x6638B958 ÌÌÏÎÎÍÎÎÎÎÌÎÍÌÏÎÍÏÎÎÍÌÏ; // 0x16C
        public 0x6638B9B0 ÌÍÌÏÌÌÌÌÌÏÏÏÍÎÏÎÍÎÎÎÌÌÍ; // 0x170
        public 0x6638BA60 ÌÌÌÌÎÏÍÎÍÎÏÏÍÍÏÌÌÌÎÌÌÍÏ; // 0x174
        public 0x6638BA08 ÎÏÏÎÎÌÍÍÏÌÏÏÎÏÏÌÎÏÏÍÍÏÏ; // 0x178
        public X ÍÌÎÏÎÏÌÎÍÎÎÎÏÌÎÎÍÌÌÏÌÍÏ; // 0x17C
        public 0x6638BAB8 ÍÍÍÍÏÍÌÎÎÌÏÌÍÌÍÎÍÍÍÌÍÍÏ; // 0x180
        public 0x6638BB68 ÍÌÏÎÌÎÍÏÍÎÏÏÎÏÏÏÏÌÏÌÌÏÌ; // 0x184
        public !P ÎÌÌÏÌÏÌÍÌÏÏÌÏÎÏÎÌÍÌÍÎÌÌ; // 0x188
        public 0x6638B748 ÏÏÎÍÎÍÎÍÌÍÏÌÍÍÏÌÌÌÍÏÌÍÌ; // 0x18C
        public 0x6638B7A0 ÎÏÌÍÍÏÏÌÎÍÍÍÎÌÎÏÎÌÏÎÏÏÎ; // 0x190
        public UnityEngine.Vector3 ÍÍÎÌÍÌÍÌÌÌÏÎÍÌÌÎÏÌÏÏÌÏÌ; // 0x194
        public UnityEngine.Quaternion ÌÎÍÎÎÏÏÌÏÌÎÌÌÌÏÍÍÎÍÌÍÌÎ; // 0x1A0
        public float ÎÎÎÌÏÌÎÌÌÌÌÍÌÏÍÏÏÌÌÌÏÏÎ; // 0x1B0
        public float ÏÌÍÌÌÎÏÍÎÏÌÏÏÏÎÏÎÏÏÍÌÌÌ; // 0x1B4
        public float ÏÏÏÎÍÏÌÎÏÏÌÍÏÏÌÏÍÍÍÎÍÍÎ; // 0x1B8
        public float ÎÏÌÎÍÎÏÎÎÏÌÏÎÏÌÏÍÍÎÍÌÎÌ; // 0x1BC
        public float ÌÏÌÎÌÏÎÎÍÏÏÎÏÌÍÎÏÏÎÌÎÏÎ; // 0x1C0
        public float ÍÏÎÌÎÍÎÍÍÏÏÌÎÎÌÌÌÏÏÍÏÍÌ; // 0x1C4
        public float ÍÍÏÌÌÍÏÏÌÌÏÎÍÌÍÏÌÎÍÏÍÍÏ; // 0x1C8
        public float ÌÎÏÌÌÏÏÏÌÏÌÎÎÏÎÎÌÏÌÏÌÍÍ; // 0x1CC
        public float ÏÍÍÏÏÌÏÎÍÌÍÍÌÍÏÌÍÍÌÏÌÌÍ; // 0x1D0
        public float ÍÍÌÍÏÏÎÎÌÌÎÎÎÌÍÎÌÎÎÌÏÍÍ; // 0x1D4
        public bool ÏÏÏÏÌÎÌÌÏÍÎÌÎÏÌÏÌÌÍÌÏÍÎ; // 0x1D8
        public int ÌÌÎÍÌÎÏÌÏÍÎÏÌÍÏÏÌÎÍÌÎÍÏ;
        public System.Collections.Generic.List`1<UnityEngine.Camera> ÎÌÎÍÎÍÌÏÌÌÏÏÎÍÌÌÍÏÌÎÍÎÏ; // 0x1E0
        public System.Collections.Generic.List`1<UnityEngine.RenderTexture> ÎÍÌÏÏÏÏÎÌÎÍÍÍÏÌÌÌÎÏÌÌÎÌ; // 0x1E8
        public System.Collections.Generic.List`1<UnityEngine.Coroutine> ÏÎÏÎÎÎÎÎÌÎÌÌÍÎÍÌÌÏÎÏÏÏÎ; // 0x1F0
        public 0x6638BCC8 ÍÍÌÎÌÏÌÏÎÌÎÍÎÌÎÏÎÎÎÏÏÏÏ; // 0x1F8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E808FA0
        public void RaiseCancellation(){} // RVA: 0x7FFD4E80A5A0
        public void set_scale(){} // RVA: 0x7FFD4E80A9D0
        public void CancelInvoke(){} // RVA: 0x7FFD4E80A9E0
        public void set_Confidence(){} // RVA: 0x7FFD4E4AEF60
        public void get_scale(){} // RVA: 0x7FFD4E80AB80
        public void CancelInvoke_EA5781C9E843(){} // RVA: 0x7FFD4E80AB90
        public void IsInvoking(){} // RVA: 0x7FFD4E80AEB0
        public void set_globalDollarsGoal(){} // RVA: 0x7FFD4E5634F0
        public void StartCoroutine(){} // RVA: 0x7FFD4E80B2B0
        public void StartCoroutine_665B69C6EC5E(){} // RVA: 0x7FFD4E80B2F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E80B3F0
        public void StopCoroutine(){} // RVA: 0x7FFD4E80B400
        public void get_CanBeNull_89F3C5EEBE94(){} // RVA: 0x7FFD4E8149E0 | overloaded x2
        public void GetInstanceID(){} // RVA: 0x7FFD4E80B5C0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4E80B670
        public void get_useGUILayout(){} // RVA: 0x7FFD4E80BEA0
        public void set_useGUILayout_24F2581CC257(){} // RVA: 0x7FFD4E81A060 | overloaded x2
        public void print(){} // RVA: 0x7FFD4E80C0F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E80C410
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E80C460
        public void FixedUpdate_213C297E3E3A(){} // RVA: 0x7FFD4E80F7D0 | overloaded x2
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFD4E607D90
        public void OnTriggerExit(){} // RVA: 0x7FFD4E80C6E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4E80CA60
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4E80CE30
        public void GetCurrentHealth(){} // RVA: 0x7FFD4E4AEF50
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E80CEF0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4E80D2F0
        public void GetScriptClassName(){} // RVA: 0x7FFD4E80D5D0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4E80D720
        public void DoThrowArgumentNullException(){} // RVA: 0x7FFD4E80D740
        public void GetGameObject_99B(){} // RVA: 0x7FFD4E80D7A0
        public void OnTriggerExit_18C87653E139(){} // RVA: 0x7FFD4E80D960
        public void ToChar(){} // RVA: 0x7FFD4E80DAB0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFD4E80DD30
        public void get_Created(){} // RVA: 0x7FFD4E80DDF0
        public void OnEnable(){} // RVA: 0x7FFD4E80E1D0
        public void Updaterotation_Inj(){} // RVA: 0x7FFD4E80E520
        public void Update(){} // RVA: 0x7FFD4E80F910
        public void InvokeInterfaceMethod(){} // RVA: 0x7FFD4E80FF00
        public void OnDisable(){} // RVA: 0x7FFD4E810000
        public void ResetDestroyCancellationToken(){} // RVA: 0x7FFD4E816280 | overloaded x2
        public void OnApplicationPause(){} // RVA: 0x7FFD4E8102D0
        public void OnApplicationQuit(){} // RVA: 0x7FFD4E810310
        public void OnBecameVisible(){} // RVA: 0x7FFD4E810370
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E811A50
        public void .ctor(){} // RVA: 0x7FFD4E811BC0
        public void Initialize(){} // RVA: 0x7FFD4E811EA0
        public void OnCollisionExit(){} // RVA: 0x7FFD4E812440
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E812740
        public void OnTriggerStay(){} // RVA: 0x7FFD4E8127B0
        public void OnTriggerExit_B18956EB675B(){} // RVA: 0x7FFD4E8127C0
        public void UpdateHealth(){} // RVA: 0x7FFD4E8128D0
        public void TakeDamage(){} // RVA: 0x7FFD4E812900
        public void InvokeInterfaceMethod_A07AB15C36C4(){} // RVA: 0x7FFD4E812E60
        public void LateUpdate(){} // RVA: 0x7FFD4E8130A0
        public void DoStop(){} // RVA: 0x7FFD4E8143C0
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E420210
        public void set_scale_FF0739DBFA70(){} // RVA: 0x7FFD4E80A9D0
        public void AddDollars(){} // RVA: 0x7FFD4E814A40
        public void SetReversedPlaybackFlag(){} // RVA: 0x7FFD4E814C80
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E814D20
        public void OnCollisionStay(){} // RVA: 0x7FFD4E814EE0
        public void Awake(){} // RVA: 0x7FFD4E814F00
        public void InterpolateQuaternionComponents(){} // RVA: 0x7FFD4E814FA0
        public void SetStateAndRefresh(){} // RVA: 0x7FFD4E8157C0
        public void Start(){} // RVA: 0x7FFD4E815890
        public void SpendDollars(){} // RVA: 0x7FFD4E815DD0
        public void OnDestroy_8353473A53FD(){} // RVA: 0x7FFD4E815F00
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFD4E8161E0
        public void ResetConfidence_4DA120D06F9F(){} // RVA: 0x7FFD4E817060 | overloaded x2
        public void ProcessComponentFieldAndCheck(){} // RVA: 0x7FFD4E8162F0
        public void HandlePointerDragScale(){} // RVA: 0x7FFD4E816500
        public void HandleRectTransform(){} // RVA: 0x7FFD4E816600
        public void HandleRectTransformScale(){} // RVA: 0x7FFD4E8167C0
        public void HandleLayoutState(){} // RVA: 0x7FFD4E8169E0
        public void ToDegrees(){} // RVA: 0x7FFD4E816AA0
        public void HandleLayoutStateScale(){} // RVA: 0x7FFD4E817280
        public void UpdatePositionAndRo(){} // RVA: 0x7FFD4E817B90
        public void HandleTabContent(){} // RVA: 0x7FFD4E817C30
        public void HandleTabContentScale(){} // RVA: 0x7FFD4E817CD0
        public void HandleObservableList(){} // RVA: 0x7FFD4E817CF0
        public void HandleObservableListScale(){} // RVA: 0x7FFD4E817D00
        public void InvokeInterfaceMethod_D01990B96BD3(){} // RVA: 0x7FFD4E817E30
        public void HandleScrollStateScale(){} // RVA: 0x7FFD4E817E70
        public void set_Depth(){} // RVA: 0x7FFD4E420220
        public void set_Depth_B9992F60571F(){} // RVA: 0x7FFD4E420220
        public void get_Playlist(){} // RVA: 0x7FFD4E818150
        public void GetGameObjectReference(){} // RVA: 0x7FFD4E818160
        public void SetAudioVolume2(){} // RVA: 0x7FFD4E8183A0
        public void UpdateActive(){} // RVA: 0x7FFD4E8185C0
        public void HandlePreCullStateScale(){} // RVA: 0x7FFD4E8161E0
        public void PreparePurchaseDisplayData(){} // RVA: 0x7FFD4E818740
        public void GetTime_618(){} // RVA: 0x7FFD4E818A20
        public void OnTriggerEnter_44BB8B0A0B9A(){} // RVA: 0x7FFD4E812740
        public void OnDestroy(){} // RVA: 0x7FFD4E818C10
        public void UpdatePointerHover(){} // RVA: 0x7FFD4E818CB0
        public void GetUnityEngine(){} // RVA: 0x7FFD4E818EB0
        public void StartCoroutine_Auto_1E029CD76E52(){} // RVA: 0x7FFD4E818F80
        public void set_ambientLight(){} // RVA: 0x7FFD4E819130
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD4E819290
        public void ConfigureintVal(){} // RVA: 0x7FFD4E819C00
        public void SetGameObjectActive(){} // RVA: 0x7FFD4E819D80
        public void UpdatePointerDrag(){} // RVA: 0x7FFD4E81A230
        public void SetAudioVolume(){} // RVA: 0x7FFD4E81A310
        public void UpdatePointerDragScale(){} // RVA: 0x7FFD4E81A420
        public void UpdateRectTransform(){} // RVA: 0x7FFD4E81A520
        public void UpdateRectTransformScale(){} // RVA: 0x7FFD4E81B0C0
        public void OnTriggerExit_504EF4DAA1B8(){} // RVA: 0x7FFD4E2ADC40
        public void InvokeInterfaceMethod_F2890B6B854B(){} // RVA: 0x7FFD4E81B0E0
    }

    /// <summary>Originally: ÎÏÏÎÍÏÍÎÌÌÎÎÏÍÏÏÏÎÍÏÍÏÍ</summary>
    public class ComplexComponent_0BF8 : MonoBehaviour
    {
        public ÎÏÏÎÍÏÍÎÌÌÎÎÏÍÏÏÏÎÍÏÍÏÍ _destroyCancellationToken;
        public ÎÎÏÏÌÍÏÍÏÌÍÏÎÌÍÏÌÍÎÍÍÍÏ<System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ>> _useGUILayout; // 0x20
        public System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ> f_81F; // 0x28
        public ÎÎÏÏÌÍÏÍÏÌÍÏÎÌÍÏÌÍÎÍÍÍÏ<System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ>> f_306; // 0x30
        public System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ> f_F3B; // 0x38
        public float f_4EB; // 0x40
        public string f_911; // 0x48
        public string f_AE5; // 0x50
        public System.Collections.Generic.List`1<string> f_350; // 0x58
        public ÍÏÌÌÏÍÎÌÍÌÍÌÎÎÌÍÏÏÍÍÎÏÌ f_BBF; // 0x60
        public bool f_412; // 0x68
        public System.IO.DirectoryInfo ÌÏÎÌÏÎÏÌÍÎÌÏÍÏÏÌÏÎÎÌÏÎÌ; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiInfoPushSystem> ÎÎÏÏÎÎÏÍÎÎÏÏÏÌÍÏÎÏÏÏÎÎÌ; // 0x78
        public string ÌÎÏÍÍÍÌÎÎÍÏÌÏÎÏÏÌÍÌÎÍÎÏ;
        public string ÏÌÏÏÎÍÍÌÍÍÏÏÎÍÌÌÏÍÌÌÌÎÌ;
        public System.Collections.Generic.Dictionary`2<string,System.Func`1<string>> ÌÏÏÌÌÍÌÎÍÍÎÏÍÎÏÎÍÌÎÌÌÍÌ; // 0x8
        public string[] ÍÍÍÍÌÌÌÎÎÎÍÏÍÍÎÏÌÌÌÍÎÎÌ; // 0x10
        public string[] ÏÌÏÏÌÍÌÏÎÏÎÍÏÎÍÎÍÏÌÍÌÍÎ; // 0x18
        public string[] ÌÍÎÍÌÎÏÍÌÏÍÏÍÌÏÎÌÍÌÏÍÌÍ; // 0x20
        public string[] ÏÍÎÏÏÏÌÎÏÌÏÍÏÌÌÌÎÍÍÌÏÏÍ; // 0x28
        public string[] ÏÍÏÏÌÎÍÏÍÌÌÍÏÌÏÌÌÍÏÏÎÌÌ; // 0x30
        public string[] ÎÌÍÍÍÌÌÎÏÎÏÏÎÍÎÌÍÍÎÏÍÎÌ; // 0x38
        public string[] ÎÏÌÌÎÎÌÏÍÎÎÌÍÏÍÏÍÍÍÌÎÏÍ; // 0x40
        public string[] ÏÎÌÏÎÎÍÍÏÌÌÍÍÌÍÍÌÍÏÏÌÌÏ; // 0x48
        public string[] ÎÏÌÍÎÍÍÍÍÍÌÍÌÌÍÎÍÌÍÏÎÎÍ; // 0x50
        public string[] ÎÎÎÎÏÏÍÏÏÏÍÏÎÌÍÍÍÍÏÌÏÌÍ; // 0x58
        public string[] ÏÌÌÍÏÍÍÌÌÎÏÍÍÍÍÎÏÍÍÍÍÌÏ; // 0x60
        public string[] ÏÎÍÍÏÎÍÌÍÎÌÍÏÍÏÏÍÌÍÍÍÌÌ; // 0x68
        public string[] ÎÍÎÌÌÎÌÌÌÍÍÎÌÏÏÍÏÎÏÎÍÎÍ; // 0x70
        public ÍÌÍÏÍÍÍÏÍÌÎÏÍÌÎÎÌÌÍÌÏÌÎ <ÏÏÎÌÏÏÍÍÎÏÌÎÍÍÍÌÍÎÎÌÏÌÌ>k__BackingField; // 0x80
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<System.Collections.Generic.List`1<ÌÌÏÌÏÏÍÏÍÌÎÎÌÌÏÌÌÍÍÌÍÏÌ>> <ÎÏÍÌÎÍÎÏÎÎÌÌÏÌÍÌÎÎÎÌÍÍÏ>k__BackingField; // 0x88
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<System.Collections.Generic.List`1<ÌÏÌÏÏÏÏÍÍÏÏÍÎÍÎÍÎÎÏÎÌÌÍ>> <ÌÏÎÌÍÏÍÎÏÏÌÎÌÌÌÎÌÍÏÍÍÏÌ>k__BackingField; // 0x90
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<System.Collections.Generic.List`1<ÎÎÌÏÎÍÏÍÎÌÍÎÏÌÍÎÎÏÌÏÏÏÍ>> <ÍÏÎÌÎÌÍÎÍÎÌÍÌÏÏÌÌÎÎÏÌÏÍ>k__BackingField; // 0x98
        public System.Collections.Generic.List`1<ÎÎÌÏÎÍÏÍÎÌÍÎÏÌÍÎÎÏÌÏÏÏÍ> ÏÌÏÏÏÎÌÎÎÏÏÌÍÍÌÎÎÎÎÎÌÏÍ; // 0xA0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> <ÏÎÏÎÏÎÏÏÌÌÌÍÍÏÍÏÍÏÍÎÎÌÏ>k__BackingField; // 0xA8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> <ÌÌÌÏÌÎÍÎÍÌÍÍÎÎÌÎÌÏÏÏÏÏÌ>k__BackingField; // 0xB0
        public ÍÌÍÏÍÍÍÏÍÌÎÏÍÌÎÎÌÌÍÌÏÌÎ <ÎÍÌÍÍÏÏÎÌÎÎÏÎÎÌÍÍÍÌÌÎÎÌ>k__BackingField; // 0xB8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EBD6DD0
        public void OnDestroy(){} // RVA: 0x7FFD4EBD6F70
        public void IsInvoking(){} // RVA: 0x7FFD4EBD7080
        public void CancelInvoke(){} // RVA: 0x7FFD4EBE3F80 | overloaded x6
        public void Invoke(){} // RVA: 0x7FFD4EBD72F0
        public void InvokeRepeating(){} // RVA: 0x7FFD4EBD7370
        public void OnCollisionStay(){} // RVA: 0x7FFD4EBD7720
        public void Start(){} // RVA: 0x7FFD4EBD7760
        public void OnTriggerStay(){} // RVA: 0x7FFD4EBD8030
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EBD8360
        public void StopCoroutine(){} // RVA: 0x7FFD4EBD85C0
        public void get_CanBeNull(){} // RVA: 0x7FFD4EBD8670
        public void OnApplicationPause(){} // RVA: 0x7FFD4EBD8890
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EBD8E60
        public void get_useGUILayout(){} // RVA: 0x7FFD4EBD8EE0
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EBD9080
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4EBD9260
        public void InvokeDelayed(){} // RVA: 0x7FFD4EBD93A0
        public void CancelInvoke_CE58187DE689(){} // RVA: 0x7FFD4EBD9A50
        public void OnTriggerExit(){} // RVA: 0x7FFD4EBD9BF0
        public void get_version(){} // RVA: 0x7FFD4E3AC040
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EBD9DB0
        public void set_description(){} // RVA: 0x7FFD4E96E3C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4EBDA210
        public void StopCoroutineFromEnumeratorManaged_03AB7C3DD9D1(){} // RVA: 0x7FFD4EBE2E90 | overloaded x2
        public void GetScriptClassName(){} // RVA: 0x7FFD4EBDA3F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4EBDAD00
        public void CanReadEmbeddedValue(){} // RVA: 0x7FFD4EBDAE00
        public void ForceMeshUpdate(){} // RVA: 0x7FFD4EBDAE80
        public void OnTriggerExit_31EA1B98DCC7(){} // RVA: 0x7FFD4EBDB160
        public void BuildIndexedEntry(){} // RVA: 0x7FFD4EBDB230
        public void get_Created(){} // RVA: 0x7FFD4EBDB570
        public void InitializeAndCreate0BF8Object(){} // RVA: 0x7FFD4EBDB800
        public void ToByte(){} // RVA: 0x7FFD4EBDB990
        public void set_iconImageUrl(){} // RVA: 0x7FFD4E96E360
        public void Awake(){} // RVA: 0x7FFD4EBDBC50
        public void OnEnable(){} // RVA: 0x7FFD4EBDBF10
        public void CreateConfiguredInstance(){} // RVA: 0x7FFD4EBDBFE0
        public void get_taglineText(){} // RVA: 0x7FFD4E96B1A0
        public void AssignCreatedHandle(){} // RVA: 0x7FFD4EBDC090
        public void LateUpdate(){} // RVA: 0x7FFD4EBDC440
        public void OnDisable(){} // RVA: 0x7FFD4EBDCF10
        public void Initialize0BF8Resources(){} // RVA: 0x7FFD4EBDD380
        public void GetAudioTracks_5DF912479AFB(){} // RVA: 0x7FFD4E70F640
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EBDF2C0
        public void OnBecameVisible(){} // RVA: 0x7FFD4EBDF840
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EBDFA10
        public void set_PointerPose(){} // RVA: 0x7FFD4E3AC0C0
        public void .cctor(){} // RVA: 0x7FFD4EBDFC40
        public void OnCollisionExit(){} // RVA: 0x7FFD4EBE07D0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4EBE0A30
        public void BuildBoundsFromSource(){} // RVA: 0x7FFD4EBE0EA0
        public void InitializeComplexComponent(){} // RVA: 0x7FFD4EBE1060
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void InvokeMatchedReceiver(){} // RVA: 0x7FFD4EBE1200
        public void TryInvokeMatchedReceiver(){} // RVA: 0x7FFD4EBE15F0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x7FFD4EBE16A0
        public void DeserializeIndexedPayload(){} // RVA: 0x7FFD4EBE18D0
        public void UpdateComplexComponent(){} // RVA: 0x7FFD4EBDB800
        public void Initialize(){} // RVA: 0x7FFD4EBE1A70
        public void ApplyLinkedContext(){} // RVA: 0x7FFD4EBE1C20
        public void ProcessComplexComponent(){} // RVA: 0x7FFD4EBE1F00
        public void Initialize_D4D08C33616E(){} // RVA: 0x7FFD4EBE21A0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EBE2410
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void ApplyLinkedContextAlt(){} // RVA: 0x7FFD4EBE24E0
        public void CreateAndDisableCurrentTarget(){} // RVA: 0x7FFD4EBE26B0
        public void DisableCurrentTarget(){} // RVA: 0x7FFD4EBE26E0
        public void StartComplexComponent(){} // RVA: 0x7FFD4EBE2910
        public void op_Implicit(){} // RVA: 0x7FFD4EBE3070
        public void AllocateStateSlot(){} // RVA: 0x7FFD4E36F0C0
        public void Initialize0BF8Statics(){} // RVA: 0x7FFD4EBE3120
        public void StopComplexComponent(){} // RVA: 0x7FFD4EBE3150
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void .ctor(){} // RVA: 0x7FFD4EBE3160
        public void PauseComplexComponent(){} // RVA: 0x7FFD4EBE38A0
        public void get_name(){} // RVA: 0x7FFD4EBE3A40
        public void get_name_4A8C383E103B(){} // RVA: 0x7FFD4EBE3B30
        public void ResumeComplexComponent(){} // RVA: 0x7FFD4EBE3CD0
        public void DestroyComplexComponent(){} // RVA: 0x7FFD4EBE3ED0
        public void GetCurrentTextCue_62ACEDD4AE62(){} // RVA: 0x7FFD4E3AC0B0
        public void set_imageUrl(){} // RVA: 0x7FFD4E96E300
        public void EnableComplexComponent(){} // RVA: 0x7FFD4EBE4080
        public void DisableComplexComponent(){} // RVA: 0x7FFD4EBE4130
        public void InvokeStoredCallback(){} // RVA: 0x7FFD4EBE4510
        public void ResetComplexComponent(){} // RVA: 0x7FFD4EBE46B0
        public void FixedUpdate(){} // RVA: 0x7FFD4EBE4930
        public void Update(){} // RVA: 0x7FFD4EBE4990
        public void AwakeComplexComponent(){} // RVA: 0x7FFD4EBE4BD0
        public void ResolvePrimaryContainer(){} // RVA: 0x7FFD4EBE4DD0
        public void OnEnableComplexComponent(){} // RVA: 0x7FFD4EBE4EE0
        public void OnDisableComplexComponent(){} // RVA: 0x7FFD4EBE51B0
        public void Ensure0BF8TypeInfo(){} // RVA: 0x7FFD4EBE5260
        public void Initialize0BF8TypeInfo(){} // RVA: 0x7FFD4EBE5270
        public void ResolveOrAssignReference(){} // RVA: 0x7FFD4EBE5320
        public void OnCollisionEnter(){} // RVA: 0x7FFD4EBE5590
        public void CreateAndFinalizeHandle(){} // RVA: 0x7FFD4EBE58C0
        public void CreateDefaultContext(){} // RVA: 0x7FFD4EBE5B40
    }

    /// <summary>Originally: ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ</summary>
    public class ComplexComponent_12D5 : MonoBehaviour
    {
        public ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ _destroyCancellationToken;
        public ÎÌÏÏÍÌÎÌÍÎÌÏÍÏÎÎÏÏÏÍÌÍÏ _useGUILayout; // 0x20
        public ÏÌÎÏÎÌÍÍÌÌÍÍÏÏÍÏÎÎÌÌÍÏÎ f_396; // 0x28
        public ÌÎÏÎÍÌÌÏÏÌÍÍÎÏÏÎÍÏÎÎÌÏÎ f_13E; // 0x30
        public ÎÌÎÎÏÏÏÍÎÏÍÎÎÌÍÍÌÍÌÍÎÌÍ f_6FA; // 0x38
        public ÌÍÎÎÏÎÌÌÌÎÍÏÏÏÌÌÏÌÏÍÏÌÌ f_46C; // 0x40
        public ÏÏÏÌÌÍÎÌÍÏÏÎÎÍÌÌÍÏÎÌÌÍÍ f_61E; // 0x48
        public ÌÏÎÍÌÌÍÎÌÍÍÏÏÎÌÍÎÏÍÌÍÎÎ f_97A; // 0x50
        public ÏÏÏÎÎÍÎÎÏÌÍÌÌÏÍÌÏÍÎÌÏÏÌ f_E15; // 0x58
        public UnityEngine.Transform f_E90; // 0x60
        public VRC.SDKBase.VRC_Pickup f_020; // 0x68
        public VRC.SDKBase.VRC_Pickup f_085; // 0x70
        public UnityEngine.GameObject f_893; // 0x78
        public float f_9B8; // 0x80
        public UnityEngine.Material f_073; // 0x88
        public UnityEngine.Material f_F98; // 0x90
        public UnityEngine.Transform f_36A; // 0x98
        public UnityEngine.MeshRenderer f_208; // 0xA0
        public UnityEngine.MeshRenderer f_554; // 0xA8
        public UnityEngine.Material[] f_5CE; // 0xB0
        public UnityEngine.Material[] f_602; // 0xB8
        public UnityEngine.GameObject f_AA9; // 0xC0
        public UnityEngine.Material f_829; // 0xC8
        public UnityEngine.AudioSource f_B76; // 0xD0
        public UnityEngine.AudioSource f_739; // 0xD8
        public UnityEngine.AudioClip f_686; // 0xE0
        public UnityEngine.AudioClip ÌÍÎÎÎÌÍÎÏÎÌÎÍÌÏÎÎÌÎÎÏÌÏ; // 0xE8
        public UnityEngine.AudioClip ÏÏÍÎÎÎÌÌÌÏÏÍÎÌÍÍÌÌÌÏÏÌÌ; // 0xF0
        public ÌÌÏÏÌÍÎÏÏÌÌÏÍÍÌÏÏÏÎÎÎÏÎ TimerButton; // 0xF8
        public VRC.UserCamera.CameraPreset ÍÏÍÎÍÎÎÌÌÏÎÌÏÎÌÍÌÌÏÏÏÍÏ; // 0x100
        public VRC.UserCamera.CameraPin[] ÍÌÍÏÎÏÏÍÎÎÌÍÌÏÏÏÌÏÍÍÌÌÍ; // 0x108
        public float ÎÌÏÌÍÌÏÏÎÏÎÎÎÏÎÏÏÏÎÍÏÎÏ; // 0x110
        public float ÌÍÌÏÏÌÌÌÎÎÏÎÍÌÍÏÏÍÌÌÎÍÍ; // 0x114
        public float ÍÍÍÎÌÍÌÍÌÎÏÏÌÍÌÏÎÎÎÍÏÌÌ; // 0x118
        public bool ÌÌÌÏÍÌÍÌÎÌÏÍÌÏÍÌÎÎÏÌÌÌÌ; // 0x11C
        public bool ÏÏÌÍÌÌÍÎÌÍÌÎÍÍÎÌÏÎÌÏÎÏÍ; // 0x11D
        public bool ÎÏÌÍÎÏÌÏÎÍÏÍÌÎÍÌÎÎÏÏÏÌÍ; // 0x11E
        public ÏÌÎÍÍÌÍÏÌÎÏÏÌÌÌÍÏÌÎÏÏÎÌ ÎÎÏÎÎÏÎÎÌÌÏÌÌÎÎÌÎÍÍÌÏÍÌ; // 0x120
        public UnityEngine.Material ÌÏÏÎÎÌÎÍÎÍÌÎÌÎÎÌÌÌÏÌÎÌÏ; // 0x128
        public UnityEngine.Material ÏÍÎÎÍÌÎÎÎÎÏÎÎÌÏÌÎÍÌÏÌÍÎ; // 0x130
        public UnityEngine.RectTransform ÍÍÎÎÌÌÎÍÌÎÏÌÎÌÏÏÏÌÎÏÎÍÏ; // 0x138
        public UnityEngine.GameObject ÌÏÏÎÎÎÎÎÎÌÏÎÍÎÏÍÏÎÌÍÌÍÏ; // 0x140
        public UnityEngine.Material[] ÎÎÍÌÎÏÌÎÍÎÎÍÌÎÏÎÎÍÎÍÍÍÍ; // 0x148
        public VRC.Localization.LocalizableString[] ÍÌÌÌÌÍÎÌÏÍÎÎÏÎÌÏÍÌÎÏÌÎÍ; // 0x150
        public VRC.UserCamera.CameraPreset[] ÍÍÍÎÏÍÌÎÎÎÎÏÏÍÎÌÎÏÏÍÌÌÌ; // 0x158
        public UnityEngine.Camera <ÍÍÎÌÏÌÏÎÎÏÍÎÎÎÎÏÌÌÍÌÍÎÍ>k__BackingField; // 0x160
        public !P ÌÍÌÍÎÏÎÌÍÏÌÌÎÍÏÍÏÎÎÍÍÏÎ; // 0x168
        public bool ÎÍÏÍÍÌÍÎÍÌÏÌÏÍÌÍÎÎÏÎÍÎÎ; // 0x16C
        public bool <ÌÌÌÌÍÍÎÎÍÏÌÍÌÎÏÏÏÍÎÏÌÎÏ>k__BackingField; // 0x16D
        public 0x6638B748 ÌÏÍÌÌÎÎÏÍÌÍÌÏÏÌÏÌÎÎÌÏÎÏ; // 0x170
        public bool ÎÏÍÍÏÎÌÍÍÍÏÍÌÍÏÌÌÎÎÎÍÍÏ; // 0x174
        public 0x6638B7A0 ÌÍÍÌÍÍÏÏÏÏÏÍÎÎÏÍÏÍÌÏÏÏÌ; // 0x178
        public int ÎÏÌÌÏÏÎÏÌÌÌÍÍÌÍÎÎÌÏÍÏÌÎ; // 0x17C
        public int ÎÏÎÌÎÍÌÎÍÏÌÎÌÌÌÏÏÍÌÏÏÍÌ; // 0x180
        public int ÏÍÌÏÌÏÍÍÍÍÍÌÌÌÌÌÏÍÏÎÎÍÌ; // 0x184
        public 0x6638B850 ÎÎÎÍÌÌÏÏÎÏÎÎÎÍÎÍÏÌÎÍÌÎÎ; // 0x188
        public System.Nullable`1<0x664C9358> ÏÏÌÏÌÎÍÏÎÌÎÍÌÎÌÏÌÏÍÏÌÎÏ; // 0x18C
        public System.Nullable`1<0x664C9358> ÏÌÏÌÍÎÍÍÎÍÎÎÍÏÌÏÎÌÌÌÌÏÏ; // 0x194
        public 0x6638B900 <ÏÏÍÎÍÎÍÏÏÍÎÍÍÎÏÎÍÍÌÌÌÌÎ>k__BackingField; // 0x19C
        public float <ÏÏÌÎÌÍÌÌÌÍÎÏÍÍÏÌÏÏÎÎÌÌÎ>k__BackingField; // 0x1A0
        public UnityEngine.Transform ÌÏÍÎÍÏÎÎÍÌÌÎÎÏÏÍÍÌÎÎÍÏÌ; // 0x1A8
        public bool ÌÎÎÏÎÎÏÌÍÎÍÎÌÎÌÎÏÎÍÏÎÍÌ; // 0x1B0
        public int ÏÌÌÏÎÏÍÎÎÌÌÍÌÎÌÍÌÌÏÌÌÌÍ; // 0x1B4
        public bool ÍÏÏÍÏÏÌÌÌÍÎÍÎÎÍÍÎÎÌÎÌÍÏ; // 0x1B8
        public UnityEngine.Coroutine ÏÏÎÎÍÍÌÎÎÏÍÍÏÍÏÎÍÍÌÎÎÍÌ; // 0x1C0
        public UnityEngine.Vector2Int ÍÏÏÍÌÌÎÌÌÎÎÎÏÎÌÍÎÌÌÍÍÌÍ; // 0x8
        public UnityEngine.Vector2Int ÎÏÌÍÏÎÌÏÎÍÍÌÏÍÏÍÍÎÍÌÏÍÎ; // 0x10
        public bool <ÎÎÌÌÌÍÍÏÏÍÌÍÍÎÍÎÏÍÏÎÏÌÎ>k__BackingField; // 0x1C8
        public bool <ÎÏÌÌÎÏÏÍÏÍÍÍÍÍÍÎÏÏÎÍÎÎÏ>k__BackingField; // 0x1C9

        // ── Methods ──
        public void get_HttpProxy(){} // RVA: 0x7FFD4E7C98A0
        public void RaiseCancellation(){} // RVA: 0x7FFD4E7C98B0
        public void IsInvoking(){} // RVA: 0x7FFD4E7C9910
        public void CancelInvoke(){} // RVA: 0x7FFD4E7C9960
        public void Invoke(){} // RVA: 0x7FFD4E7CA7C0
        public void InvokeRepeating(){} // RVA: 0x7FFD4E7CA7E0
        public void CancelInvoke_F906DC58075E(){} // RVA: 0x7FFD4E7CAEE0
        public void IsInvoking_E51C33B0702A(){} // RVA: 0x7FFD4E7CAF90
        public void StartCoroutine(){} // RVA: 0x7FFD4E7CB3F0
        public void StartCoroutine_0BF9228D3731(){} // RVA: 0x7FFD4E7CB400
        public void OnDisable(){} // RVA: 0x7FFD4E7CB4A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E7CB510
        public void StopCoroutine(){} // RVA: 0x7FFD4E7CB560
        public void .ctor(){} // RVA: 0x7FFD4E7CB7B0
        public void Initialize(){} // RVA: 0x7FFD4E36F0C0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4E7CB820
        public void get_useGUILayout(){} // RVA: 0x7FFD4E7CBAD0
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E7CBB80
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E7CBBA0
        public void InvokeDelayed(){} // RVA: 0x7FFD4E7CBBC0
        public void CancelInvoke_44EB9D083CB1(){} // RVA: 0x7FFD4E7CBBD0
        public void .cctor(){} // RVA: 0x7FFD4E7CBD80
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4E7CBE70
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4E7CBF80
        public void Start(){} // RVA: 0x7FFD4E7CC1A0
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void GetScriptClassName(){} // RVA: 0x7FFD4E7CC240
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4E7CC250
        public void DispatchQueuedOperation(){} // RVA: 0x7FFD4E7CC2B0
        public void CalculateMeasurementValue(){} // RVA: 0x7FFD4E7CC360
        public void OnApplicationPause(){} // RVA: 0x7FFD4E7CC370
        public void OnApplicationQuit(){} // RVA: 0x7FFD4E7CC860
        public void OnBecameVisible(){} // RVA: 0x7FFD4E7CCBC0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E7CCD40
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E7CCE50
        public void OnCollisionStay(){} // RVA: 0x7FFD4E7CCE60
        public void OnCollisionExit(){} // RVA: 0x7FFD4E7CD120
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E7CD190
        public void OnTriggerStay(){} // RVA: 0x7FFD4E7CDE00
        public void OnTriggerExit(){} // RVA: 0x7FFD4E7CDE10
        public void ValidateAndReadMode(){} // RVA: 0x7FFD4E7CDE20
        public void BroadcastNetworkUpdate(){} // RVA: 0x7FFD4E7CDF30
        public void ConfigureHttpProxy(){} // RVA: 0x7FFD4E7CE0D0
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFD4E7CE0E0
        public void GetGameObject_D00(){} // RVA: 0x7FFD4E7CE140
        public void Pause(){} // RVA: 0x7FFD4E7CE7A0
        public void ProxyNetworkFunctionCall(){} // RVA: 0x7FFD4E7CEF60
        public void GetCachedPtr(){} // RVA: 0x7FFD4E7CF0C0
        public void GetCachedPtr_56350A8B9BAA(){} // RVA: 0x7FFD4E7CF0D0
        public void GetCachedPtr_9BF19B8CECEB(){} // RVA: 0x7FFD4E7CF170
        public void ProcessSocketMeasurement(){} // RVA: 0x7FFD4E7CF320
        public void OnEnable(){} // RVA: 0x7FFD4E7CF450
        public void OnEnable_AB9AE64E6DAF(){} // RVA: 0x7FFD4E7CF490
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void set_name(){} // RVA: 0x7FFD4E7CF4A0
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void Update(){} // RVA: 0x7FFD4E3BC730
        public void set_HttpProxy(){} // RVA: 0x7FFD4E7CFA60
        public void Initialize12D5Resources(){} // RVA: 0x7FFD4E7CFAC0
        public void OnDestroy(){} // RVA: 0x7FFD4E7D0030
        public void CreateFloatNode(){} // RVA: 0x7FFD4E7D00D0
        public void CreateFloatNodeAlt(){} // RVA: 0x7FFD4E7D0100
        public void InvokeManagedCallback(){} // RVA: 0x7FFD4E7D02E0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void IsTransformInternalFlagTrue(){} // RVA: 0x7FFD4E7D0360
        public void GetUnityEngine(){} // RVA: 0x7FFD4E7D0560
        public void GetUnityEngine_E25AB6497F19(){} // RVA: 0x7FFD4E7D07A0
        public void get_inputType(){} // RVA: 0x7FFD4E7D07B0
        public void GetCachedPtr_C6D801505517(){} // RVA: 0x7FFD4E7CF0D0
        public void GetUnityEngine_1DA37F7CDF94(){} // RVA: 0x7FFD4E7D07C0
        public void Awake(){} // RVA: 0x7FFD4E7D07D0
        public void QueueNetworkOperation(){} // RVA: 0x7FFD4E7D0F60
        public void UpdateToggleStateConditional(){} // RVA: 0x7FFD4E7D1070
        public void FixedUpdate(){} // RVA: 0x7FFD4E7D1180
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void DispatchEventToListener(){} // RVA: 0x7FFD4E7D1420
        public void UpdateIKSolver(){} // RVA: 0x7FFD4E7D1450
        public void MarshalToManaged(){} // RVA: 0x7FFD4E7D1460
        public void ResolveStateHandler(){} // RVA: 0x7FFD4E7D1590
        public void AdvanceTweenState(){} // RVA: 0x7FFD4E7D1830
        public void AttachCreatedNode(){} // RVA: 0x7FFD4E7D18C0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void set_DurationType(){} // RVA: 0x7FFD4E7D1990
        public void RaiseCancellation_9CA672F33F2D(){} // RVA: 0x7FFD4E7D19A0
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void SetModelShader(){} // RVA: 0x7FFD4E3BC740
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFD4E7D2390
        public void get_ReportAssembliesMode_1FEFD3C132A9(){} // RVA: 0x7FFD4E7D23A0
        public void QueueNetworkOperation_614BEDEFFFD5(){} // RVA: 0x7FFD4E7D23B0
        public void get_ReportAssembliesMode_8A65A8BA39E4(){} // RVA: 0x7FFD4E7D23C0
        public void get_ReportAssembliesMode_BC09D1506450(){} // RVA: 0x7FFD4E7D2470
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void InvokeWithTransformPayload(){} // RVA: 0x7FFD4E7D2620
        public void LateUpdate(){} // RVA: 0x7FFD4E7D2A70
        public void Internal_CancelInvokeAll_ABD88BF1FBDC(){} // RVA: 0x7FFD4E7CBB80
        public void SetSyncedBoolFieldAt1088(){} // RVA: 0x7FFD4E7D2B10
        public void OnApplicationQuit_02C2B02D1056(){} // RVA: 0x7FFD4E7D30C0
        public void get_DurationType(){} // RVA: 0x7FFD4E50F4E0
        public void SetGameObjectActive(){} // RVA: 0x7FFD4E7D3110
        public void OnEnable_4F97420F410E(){} // RVA: 0x7FFD4E7CF490
        public void ApplyLocalPosition(){} // RVA: 0x7FFD4E7D3B00
        public void GetBufferedTimes_8B36A1744DC0(){} // RVA: 0x7FFD4E3BE740
    }

    /// <summary>Originally: ÌÏÎÏÌÌÎÌÏÎÍÍÏÌÏÍÍÏÍÏÏÍÌ</summary>
    public class ComplexComponent_29A6 : MonoBehaviour
    {
        public UnityEngine.GameObject _destroyCancellationToken; // 0x20
        public UnityEngine.UI.Button _useGUILayout; // 0x28
        public UnityEngine.GameObject f_06F; // 0x30
        public UnityEngine.GameObject f_889; // 0x38
        public UnityEngine.GameObject ÍÏÏÎÌÎÎÏÎÌÏÎÍÎÏÌÎÏÏÌÏÎÌ; // 0x40
        public UnityEngine.GameObject ÏÏÎÎÎÌÏÍÎÎÏÎÏÎÏÏÌÏÌÌÌÏÌ; // 0x48
        public UnityEngine.GameObject ÌÏÌÍÏÍÌÌÍÍÏÎÍÌÎÌÌÍÍÌÎÍÍ; // 0x50
        public UnityEngine.GameObject ÌÌÍÍÍÏÍÎÏÌÏÏÎÍÏÌÍÏÌÎÎÌÌ; // 0x58
        public UnityEngine.GameObject ÎÌÌÍÎÎÌÌÍÎÍÎÌÏÏÎÌÌÌÍÍÎÏ; // 0x60
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÏÍÏÍÎÏÌÏÍÏÏÏÍÏÎÎÌÍÏÍÎÏÍ; // 0x68
        public UnityEngine.CanvasGroup ÍÎÌÎÎÏÍÌÎÌÎÍÏÎÍÏÍÏÌÏÌÎÎ; // 0x70
        public UnityEngine.CanvasGroup ÍÏÎÏÌÎÎÍÎÏÌÍÍÌÍÌÏÎÏÌÌÍÎ; // 0x78
        public ÎÌÌÏÍÍÏÏÏÌÍÏÎÎÏÏÌÌÍÎÏÏÎ ÎÎÍÍÌÌÎÏÎÏÍÎÌÏÌÏÍÏÎÎÍÍÏ; // 0x80
        public ÎÍÏÏÎÌÏÎÌÌÎÎÏÍÍÎÍÍÏÌÎÏÍ ÌÎÎÎÏÎÏÏÍÌÌÎÌÎÍÍÎÏÎÏÎÌÎ; // 0x88
        public System.Collections.Generic.List`1<ÏÍÏÏÎÌÏÏÍÌÍÌÌÎÏÌÍÎÌÌÍÍÍ> ÎÏÍÌÎÌÎÌÎÏÍÌÏÍÏÍÌÍÌÏÍÎÏ; // 0x90
        public bool ÌÏÌÍÌÏÎÏÌÍÏÌÌÏÌÏÎÎÎÏÍÌÌ; // 0x98
        public bool ÍÏÍÍÏÎÍÏÏÍÌÏÌÏÎÌÍÍÌÏÍÏÏ; // 0x99
        public bool ÏÎÍÌÍÌÍÏÎÎÌÌÍÌÎÌÍÌÏÎÍÌÏ; // 0x9A
        public ÎÌÍÍÎÎÎÍÌÌÍÌÍÌÎÏÏÍÍÍÍÌÌ ÎÍÏÏÏÏÏÏÏÌÏÎÍÏÌÍÌÎÌÍÌÍÍ; // 0xA0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÏÍÎÍÎÌÍÍÍÎÍÌÎÎÌÌÌÌÌÍÏÏÌ; // 0xA8
        public System.Action`2<Control,bool> ÍÌÏÌÌÎÎÍÍÌÏÎÍÌÌÍÌÌÌÎÍÍÍ; // 0xB0
        public System.Action ÍÌÌÌÎÌÏÏÎÏÍÏÏÏÏÏÎÍÎÌÏÎÌ; // 0xB8
        public System.Action ÌÎÎÍÎÏÍÏÍÌÏÎÏÎÍÌÎÌÌÌÌÍÌ; // 0xC0
        public VRC.Localization.LocalizableString ÍÏÏÏÍÌÏÎÍÌÌÌÏÏÌÏÎÍÎÌÎÌÏ;
        public ÎÌÍÎÎÌÌÌÎÌÌÏÍÌÎÍÍÎÍÏÎÎÏ ÏÌÎÌÍÌÍÌÏÏÍÍÏÍÍÍÎÌÎÌÏÏÌ; // 0xC8
        public VRC.Localization.LocalizableString[] ÌÏÎÌÎÌÏÍÍÍÌÌÏÍÎÌÌÎÏÍÌÎÌ; // 0xD0
        public VRC.Localization.LocalizableString[] ÍÌÏÎÌÌÌÏÌÌÏÌÎÎÌÌÎÏÏÎÌÌÌ; // 0xD8
        public ÎÎÌÍÎÏÌÍÎÎÏÎÎÌÌÌÌÍÎÍÎÏÍ ÎÎÎÎÏÍÌÎÎÍÌÏÌÌÏÎÍÌÍÏÍÍÎ; // 0xE0
        public System.Action ÌÏÏÎÏÏÎÌÍÍÍÌÏÍÎÎÎÍÏÍÎÍÌ; // 0xE8
        public VRC.SDK3.Components.VRCUiShape _uiShape; // 0xF0
        public UnityEngine.BoxCollider _raycastCollider; // 0xF8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÍÏÏÌÏÌÍÏÏÌÍÌÎÎÏÎÏÌÌÏÎÍ; // 0x100
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÎÌÌÏÎÍÍÎÏÏÏÍÌÍÍÏÏÌÌÍÏÏ; // 0x108
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÎÏÎÌÏÏÏÌÌÍÏÏÎÍÍÌÌÍÌÏÌÌ; // 0x110
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÌÏÎÌÎÌÍÎÍÎÎÎÌÍÍÏÌÎÎÌÎÌ; // 0x118
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÌÌÏÎÍÎÏÌÏÌÎÌÍÌÌÌÍÎÎÌÏ; // 0x120
        public float ÎÌÏÌÎÌÎÏÌÏÎÏÎÌÍÌÍÌÌÌÌÌÎ;
        public float ÎÏÏÏÌÎÎÌÌÎÍÍÌÎÍÏÍÏÍÏÌÏÏ;
        public float ÌÎÎÎÏÏÌÏÏÍÍÍÍÍÏÎÏÎÎÎÎÎÏ;
        public ÏÍÏÏÎÌÏÏÍÌÍÌÌÎÏÌÍÎÌÌÍÍÍ ÎÌÌÏÏÎÍÌÍÏÌÏÍÌÍÎÌÎÌÍÏÎÌ; // 0x128
        public ÏÍÏÏÎÌÏÏÍÌÍÌÌÎÏÌÍÎÌÌÍÍÍ ÏÍÎÍÌÏÎÏÍÍÍÌÌÌÌÌÏÍÍÍÏÎÍ; // 0x130
        public 0x66349278 ÎÌÍÎÍÎÌÍÏÎÎÎÍÎÍÏÍÌÍÌÏÌÎ; // 0x138
        public bool ÏÌÌÌÎÎÍÌÏÌÌÏÍÍÎÏÍÌÌÏÍÍÍ; // 0x13C
        public bool ÌÌÎÎÎÍÏÎÍÍÌÎÍÎÏÌÏÏÍÏÎÌÍ; // 0x13D
        public bool ÎÌÍÍÎÏÍÎÌÍÍÏÏÍÏÍÏÍÏÎÏÌÍ; // 0x13E
        public UnityEngine.Vector2 ÌÏÏÏÍÍÌÍÎÌÌÌÎÎÎÌÏÎÎÏÍÏÏ; // 0x140
        public UnityEngine.Vector3 ÏÏÍÎÌÎÏÍÌÏÎÏÍÍÏÌÌÏÏÏÏÍÏ; // 0x148
        public float ÏÍÍÍÎÎÌÍÌÎÌÍÎÌÌÏÌÏÌÏÎÌÌ;
        public float ÎÎÌÍÌÌÏÌÌÍÌÌÎÍÌÌÏÏÎÍÎÎÎ;
        public float ÍÌÌÎÍÍÎÎÎÎÏÌÌÍÏÏÌÎÌÌÍÍÏ;
        public float ÍÏÍÏÍÏÍÍÎÏÍÍÏÏÏÏÍÏÎÍÌÏÏ;
        public ÍÎÌÍÏÏÌÍÍÍÍÍÍÏÏÎÏÎÌÏÍÎÎ ÎÌÌÌÌÎÎÏÏÍÍÍÌÏÌÌÏÌÎÌÏÎÏ; // 0x158
        public ÏÎÍÍÍÏÎÏÍÌÌÍÌÏÎÏÎÎÏÌÌÌÎ ÍÎÌÎÌÌÎÌÏÎÌÌÍÎÍÎÏÎÍÍÎÏÌ; // 0x160
        public UnityEngine.GameObject ÏÌÎÏÎÌÎÎÌÌÍÏÌÎÌÎÎÏÍÎÌÍÌ; // 0x168
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÎÌÌÍÎÎÍÎÍÏÌÎÎÍÍÎÎÏÎÍÏÌÌ; // 0x170
        public System.Collections.Generic.List`1<ÌÏÍÏÍÏÎÌÌÎÌÌÌÎÍÌÏÌÎÎÌÎÎ> ÎÍÍÍÍÌÍÌÎÌÍÏÍÍÍÏÎÏÎÎÍÏÎ; // 0x178
        public VRC.Localization.LocalizableString ÌÌÍÏÍÎÎÌÌÎÎÍÌÍÎÏÌÎÍÌÌÌÏ; // 0x180
        public VRC.Localization.LocalizableString ÏÏÎÌÏÏÍÌÎÏÏÍÏÍÎÍÌÎÍÏÏÏÎ; // 0x1A8
        public VRC.Localization.LocalizableString ÎÏÍÏÏÏÏÏÍÏÎÌÎÍÌÎÎÌÎÌÍÍÎ; // 0x1D0
        public ÏÎÌÍÏÎÎÎÍÏÏÌÌÎÌÎÎÌÍÎÍÌÎ ÍÏÏÎÌÏÏÌÌÏÏÏÌÍÍÏÏÎÎÏÍÍÍ; // 0x1F8
        public ÍÏÍÍÌÍÏÌÏÏÍÍÌÎÏÏÍÌÏÎÎÏÍ ÌÏÍÎÌÍÍÎÍÏÏÍÏÍÍÌÏÏÏÌÍÌÍ; // 0x200
        public ÏÍÍÍÍÏÏÏÍÍÌÍÎÌÎÌÌÎÏÌÏÌÎ ÎÏÌÎÌÎÎÎÎÏÌÍÎÎÏÏÍÏÎÍÍÏÌ; // 0x208
        public string ÎÍÏÍÍÌÌÌÍÏÎÏÍÏÏÌÍÍÎÏÌÌÍ;
        public string ÏÏÎÍÌÎÌÎÌÍÍÌÌÎÌÎÌÍÏÏÏÏÌ;
        public string ÏÍÌÎÌÍÍÍÍÏÏÏÌÎÍÍÍÍÏÌÎÌÍ;
        public bool ÌÏÎÏÌÍÏÏÌÌÎÏÌÌÏÍÏÍÎÍÍÍÏ; // 0x210
        public UnityEngine.Vector2 ÏÍÏÎÎÍÍÌÍÎÌÏÏÎÏÌÏÎÍÎÍÌÍ; // 0x214
        public System.Action ÎÏÏÎÏÏÎÍÏÍÎÍÏÌÎÎÎÏÌÌÏÍÍ; // 0x220
        public float ÎÏÍÍÎÎÍÍÌÌÌÍÏÏÌÎÏÏÍÎÌÍÌ;
        public string ÎÍÎÎÎÍÏÌÍÏÍÏÏÌÌÎÎÎÏÏÍÌÌ;
        public ÏÎÍÍÍÏÎÏÍÌÌÍÌÏÎÏÎÎÏÌÌÌÎ ÍÍÍÍÎÍÎÍÍÍÎÎÍÍÍÏÎÌÎÎÍÏÌ; // 0x228
        public ÏÎÍÍÍÏÎÏÍÌÌÍÌÏÎÏÎÎÏÌÌÌÎ ÌÎÌÎÎÏÎÌÏÎÎÎÎÏÎÎÎÎÍÍÍÏÏ; // 0x230
        public string ÏÏÏÍÎÎÌÍÏÏÎÌÍÍÌÏÏÌÎÏÏÌÏ;
        public VRC.Localization.LocalizableString ÏÎÌÍÎÏÏÌÍÎÎÍÎÎÍÌÌÍÏÌÍÌÎ; // 0x28
        public VRC.Localization.LocalizableString ÍÌÎÍÎÍÏÌÏÎÍÍÎÏÎÌÌÏÏÌÍÏÌ; // 0x50
        public VRC.Localization.LocalizableString ÏÎÌÍÍÌÏÌÍÎÌÏÏÌÏÏÍÎÌÌÏÌÎ; // 0x78
        public VRC.Localization.LocalizableString ÎÎÍÍÍÍÌÎÏÌÏÍÎÍÍÌÎÎÍÌÌÏÎ; // 0xA0
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ ÏÏÎÎÎÍÎÌÏÏÌÎÏÌÍÏÎÏÎÎÍÏÍ; // 0x238

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F110B10
        public void RaiseCancellation(){} // RVA: 0x7FFD4F110E00
        public void IsInvoking(){} // RVA: 0x7FFD4F110F00
        public void CancelInvoke(){} // RVA: 0x7FFD4F110FF0
        public void Invoke(){} // RVA: 0x7FFD4F1110F0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F111100
        public void StepBackwardAndProcessLastEntry(){} // RVA: 0x7FFD4F111230
        public void OnEnable(){} // RVA: 0x7FFD4F111380
        public void StartCoroutine(){} // RVA: 0x7FFD4F1114F0
        public void FixedUpdate(){} // RVA: 0x7FFD4F111550
        public void StartCoroutine_3E1CD6ABB840(){} // RVA: 0x7FFD4F111590
        public void StartCoroutine_Auto_BC3CC4811100(){} // RVA: 0x7FFD4F11E0C0 | overloaded x2
        public void StopCoroutine(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD4F1117C0
        public void OnApplicationPause(){} // RVA: 0x7FFD4F112200
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F1122F0
        public void get_useGUILayout(){} // RVA: 0x7FFD4F112310
        public void set_useGUILayout(){} // RVA: 0x7FFD4F122910 | overloaded x3
        public void print(){} // RVA: 0x7FFD4F112470
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F112570
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F1128B0
        public void InvokeDelayed(){} // RVA: 0x7FFD4F112F50
        public void OnTriggerStay(){} // RVA: 0x7FFD4F113010
        public void OnTriggerExit(){} // RVA: 0x7FFD4F113AE0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F114080
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F114220
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F114A80
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F114B20
        public void get_radius(){} // RVA: 0x7FFD4F114C00
        public void GetScriptClassName(){} // RVA: 0x7FFD4F114C20
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F1150D0
        public void SetBlendState(){} // RVA: 0x7FFD4F115170
        public void Awake_E5A1AB56A3C2(){} // RVA: 0x7FFD4F115200
        public void Start(){} // RVA: 0x7FFD4F115210
        public void Update_E1FD5434E94E(){} // RVA: 0x7FFD4F115220
        public void .cctor(){} // RVA: 0x7FFD4F115260
        public void UpdateComponent(){} // RVA: 0x7FFD4F1156B0
        public void ApplyResolvedPropertyValue(){} // RVA: 0x7FFD4F1157E0
        public void Accesswidth(){} // RVA: 0x7FFD4F115870
        public void GetActiveInHierarchy(){} // RVA: 0x7FFD4F115960
        public void ComputeHashCode(){} // RVA: 0x7FFD4F116600
        public void BuildComponentFromBufferAndApply(){} // RVA: 0x7FFD4F116900
        public void ContainsChild(){} // RVA: 0x7FFD4F116990
        public void CheckLifecycleAvailability(){} // RVA: 0x7FFD4F116F40
        public void AreStringsEqual(){} // RVA: 0x7FFD4F117010
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F117040
        public void SetInputSource(){} // RVA: 0x7FFD4F117160
        public void DeserializeStatePayload(){} // RVA: 0x7FFD4F117220
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F117530
        public void GetContactReceiverList(){} // RVA: 0x7FFD4F117580
        public void Updateenabled(){} // RVA: 0x7FFD4F117920
        public void set_enabled(){} // RVA: 0x7FFD4F117970
        public void TryFormatStateMessage_64AD76CF5DCA(){} // RVA: 0x7FFD4F11EE80 | overloaded x2
        public void InvokeMaterialScaleChanged(){} // RVA: 0x7FFD4F1187D0
        public void StepBackwardComplexComponent(){} // RVA: 0x7FFD4F118870
        public void SetUseGUILayout(){} // RVA: 0x7FFD4F118AB0
        public void ResetTrackedHandle(){} // RVA: 0x7FFD4F118BF0
        public void get_atlasPadding(){} // RVA: 0x7FFD4F119000
        public void InvokeRepeating_7250E780112D(){} // RVA: 0x7FFD4F119250
        public void GetUseGUILayout(){} // RVA: 0x7FFD4F11A1D0
        public void Ensure29A6TypeInfo(){} // RVA: 0x7FFD4F11A290
        public void BuildCompletedState(){} // RVA: 0x7FFD4F11A530
        public void BuildAsyncResultState(){} // RVA: 0x7FFD4F11A5C0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F11A950
        public void InitializeStopCoroutineStatics(){} // RVA: 0x7FFD4F11B2B0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F11B3A0
        public void ProcessComplexLastEntry(){} // RVA: 0x7FFD4F11B9C0
        public void BuildVectorPayload(){} // RVA: 0x7FFD4F11BA50
        public void ResolveSceneBinding(){} // RVA: 0x7FFD4F11BAB0
        public void GetComplexRadius(){} // RVA: 0x7FFD4F11BF50
        public void SetComplexBlendState(){} // RVA: 0x7FFD4F11C390
        public void IsNativeObjectAlive_9D11C327178C(){} // RVA: 0x7FFD4F11C470
        public void GetPhotonServerSettings(){} // RVA: 0x7FFD4F11D300
        public void DispatchLifecycleTransitionAlt(){} // RVA: 0x7FFD4F11D550
        public void GetInstance(){} // RVA: 0x7FFD4F11D800
        public void InitializeComplexComponentState(){} // RVA: 0x7FFD4F11D810
        public void CreateCollection(){} // RVA: 0x7FFD4F11D900
        public void DispatchLifecycleTransition(){} // RVA: 0x7FFD4F11D9F0
        public void DispatchLifecycleTransitionAuto(){} // RVA: 0x7FFD4F11DA10
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFD4E3A7DE0
        public void Initialize(){} // RVA: 0x7FFD4F11DAA0
        public void HandleComplexTriggerStay(){} // RVA: 0x7FFD4F11DB40
        public void HandleComplexTriggerExit(){} // RVA: 0x7FFD4F11DD70
        public void ParseStandardFormat(){} // RVA: 0x7FFD4F11DE10
        public void StartCoroutine_Auto_46D0C22D2566(){} // RVA: 0x7FFD4F11E150
        public void CommitSecondaryEntry(){} // RVA: 0x7FFD4F11E1E0
        public void GetRadius(){} // RVA: 0x7FFD4F11E250
        public void ConfigureminValue(){} // RVA: 0x7FFD4F11E460
        public void UpdateRealtimeTimestamp(){} // RVA: 0x7FFD4F11F130
        public void FindSelectableOnRight(){} // RVA: 0x7FFD4F11F220
        public void Awake_85B583812A88(){} // RVA: 0x7FFD4F11F650
        public void GetLastServiceDescriptor(){} // RVA: 0x7FFD4F11F830
        public void SetStateMachine(){} // RVA: 0x7FFD4F11F930
        public void LateUpdate(){} // RVA: 0x7FFD4F11F940
        public void OnDisable(){} // RVA: 0x7FFD4F11FA20
        public void get_realtimeSinceStartup(){} // RVA: 0x7FFD4F11FAD0
        public void get_realtimeSinceStartup_F4599549DBEB(){} // RVA: 0x7FFD4F11FE20
        public void UpdateTextureObjectProperties(){} // RVA: 0x7FFD4F11FE30
        public void OnBecameVisible(){} // RVA: 0x7FFD4F11FF20
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F120210
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E341310
        public void OnCollisionStay(){} // RVA: 0x7FFD4F120480
        public void OnCollisionExit(){} // RVA: 0x7FFD4F1204F0
        public void Reset(){} // RVA: 0x7FFD4F1206B0
        public void get_realtimeSinceStartup_97363D4A8AF7(){} // RVA: 0x7FFD4F1206C0
        public void UpdateRealtimeTimestamp2(){} // RVA: 0x7FFD4F120750
        public void GetLayoutFlag392(){} // RVA: 0x7FFD4F120830
        public void Start_AAAB3FFB059C(){} // RVA: 0x7FFD4F120860
        public void DoGetGraphicsFormat_F24(){} // RVA: 0x7FFD4F1208F0
        public void GetSessionId(){} // RVA: 0x7FFD4F120980
        public void GetPosition(){} // RVA: 0x7FFD4F120A10
        public void ParseStandardFormat_51E9D9C61B26(){} // RVA: 0x7FFD4F120CF0
        public void GetStatus(){} // RVA: 0x7FFD4F120DE0
        public void InitializeInvokeRepeatingStatics(){} // RVA: 0x7FFD4F120EB0
        public void GetSelectedDataPointer(){} // RVA: 0x7FFD4F120F20
        public void ConvertDateTimeToSingle(){} // RVA: 0x7FFD4F121060
        public void Update_C36BCB8A7928(){} // RVA: 0x7FFD4F121180
        public void DoHorizontalToVertica(){} // RVA: 0x7FFD4F121270
        public void ConvertDateTimeToSingle_2D3BA4B63E03(){} // RVA: 0x7FFD4F121360
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7FFD4F121470
        public void CaptureVectorSnapshot(){} // RVA: 0x7FFD4F121B90
        public void GetUnityEngine_46F06DCFA301(){} // RVA: 0x7FFD4F121CB0
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void Awake(){} // RVA: 0x7FFD4F1225C0
        public void ReadCachedStatusCode(){} // RVA: 0x7FFD4F1229E0
        public void Initialize29A6Statics(){} // RVA: 0x7FFD4F122AA0
        public void StartCoroutine_3E13206F7687(){} // RVA: 0x7FFD4F122ED0
        public void InvokeDelayed_48F38611D3D1(){} // RVA: 0x7FFD4F117970
        public void set_selectionColor(){} // RVA: 0x7FFD4F1234B0
        public void LateUpdate_97B2617E6FF3(){} // RVA: 0x7FFD4F1234C0
        public void OnApplicationQuit_E0D62724BCF2(){} // RVA: 0x7FFD4F1239F0
        public void OnEnable_B6733F959940(){} // RVA: 0x7FFD4F123A80
        public void OnApplicationQuit_40B2DC4F02B5(){} // RVA: 0x7FFD4F123B60
        public void OnDisable_EFD8E1443000(){} // RVA: 0x7FFD4F123BF0
        public void GetIsCompleted(){} // RVA: 0x7FFD4F123EA0
        public void ToString(){} // RVA: 0x7FFD4F123F30
        public void .ctor(){} // RVA: 0x7FFD4F1242C0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F125390
        public void GetAnimationStyle(){} // RVA: 0x7FFD4F128470 | overloaded x2
        public void CancelInvoke_213988DCEC48(){} // RVA: 0x7FFD4F126220
        public void CancelInvoke_5EB89A12854C(){} // RVA: 0x7FFD4F1263C0
        public void SerializeNetworkObjectWithFlags(){} // RVA: 0x7FFD4F1269C0
        public void SetActive(){} // RVA: 0x7FFD4F126BE0
        public void UpdateTextureObjectProperties_E4B4CC03DAAE(){} // RVA: 0x7FFD4F127820
        public void OnCollisionEnter_F9AA8C1194CB(){} // RVA: 0x7FFD4F127980
        public void GetMainCamera(){} // RVA: 0x7FFD4F127A00
        public void SetOperationCanceled(){} // RVA: 0x7FFD4F127C50
        public void ReleaseTrackedHandle(){} // RVA: 0x7FFD4F127CE0
        public void ComputeHashCode_68DFDE9E6FAE(){} // RVA: 0x7FFD4F127DD0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFD4F128590
        public void UpdateCoroutineState(){} // RVA: 0x7FFD4F128C10
        public void GetInvocationList(){} // RVA: 0x7FFD4F128CB0
        public void GetLastServiceDescriptor_06382DD45D91(){} // RVA: 0x7FFD4F128DB0
        public void StopAllCoroutines_4DADFAB10360(){} // RVA: 0x7FFD4F128E40
        public void StopCoroutineByHandle(){} // RVA: 0x7FFD4F128F60
        public void CopyVectorPayload(){} // RVA: 0x7FFD4F128FF0
        public void Update(){} // RVA: 0x7FFD4F129010
        public void InvokeTimedCallback(){} // RVA: 0x7FFD4F129110
        public void OnCollisionExit_E7CB480B2B18(){} // RVA: 0x7FFD4F129790
        public void GetDisclaimerText(){} // RVA: 0x7FFD4F1297C0
        public void OnCollisionStay_448A45362AEB(){} // RVA: 0x7FFD4F129850
        public void GetBackingFieldFromProperty(){} // RVA: 0x7FFD4F129A30
        public void CancelPendingServiceInvocation(){} // RVA: 0x7FFD4F129D20
        public void CancelPendingServiceInvocation_FB8FA5352AC8(){} // RVA: 0x7FFD4F129D30
        public void PackInvocationParameters(){} // RVA: 0x7FFD4F12A3D0
        public void OpImplicit(){} // RVA: 0x7FFD4F12A670
        public void SetProcessorParameter(){} // RVA: 0x7FFD4F12A800
        public void OnBecameVisible_FFE9DD82FFBE(){} // RVA: 0x7FFD4F12A990
        public void CancelPendingServiceInvocation_B028AA344C29(){} // RVA: 0x7FFD4F12AA80
        public void SetComponentFlags(){} // RVA: 0x7FFD4F12B140
        public void CancelPendingServiceInvocation_EA692BE0768D(){} // RVA: 0x7FFD4F12B1A0
        public void Ensure29A6ThreadContext(){} // RVA: 0x7FFD4F12B980
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD4F12BA90
        public void GetPhysBoneMaxStretchValue(){} // RVA: 0x7FFD4F12BC20
        public void get_currentHandTrackingFeatureEnabled(){} // RVA: 0x7FFD4F0AEC30
        public void SetComponentActiveState(){} // RVA: 0x7FFD4F12C510
        public void OnBecameInvisible_EA151454E329(){} // RVA: 0x7FFD4F12C5A0
    }

    /// <summary>Originally: ÌÏÎÍÌÍÌÌÎÍÎÍÏÎÌÎÌÏÍÌÏÏÍ</summary>
    public class ComplexComponent_49D1 : MonoBehaviour
    {
        public int _destroyCancellationToken;
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _useGUILayout; // 0x20
        public UnityEngine.UI.LayoutElement _usernameLayoutElement; // 0x28
        public int ÌÏÍÌÍÎÎÍÏÌÍÏÎÎÌÎÏÎÏÍÏÎÍ;
        public int ÍÌÍÏÏÌÌÌÏÌÌÎÌÍÍÌÏÍÏÌÏÌÎ;
        public ÍÏÌÎÌÍÎÍÎÎÍÌÏÌÌÌÏÍÍÍÍÌÍ _scrollRect; // 0x30
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _status; // 0x38
        public ÎÌÏÎÌÌÏÍÍÍÏÍÏÌÏÍÏÍÏÏÏÏÎ _statusIcon; // 0x40
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _statusTooltip; // 0x48
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _pronouns; // 0x50
        public UnityEngine.UI.Button _pronounsButton; // 0x58
        public UnityEngine.GameObject _pronounsHeaderGameObject; // 0x60
        public UnityEngine.GameObject _walletContentsButton; // 0x68
        public ÌÍÌÌÎÌÍÌÎÍÎÍÍÏÍÏÍÏÍÏÌÎÏ _profileAvatarImage; // 0x70
        public UnityEngine.GameObject _streamerModeUserImage; // 0x78
        public ÌÏÎÎÎÍÌÌÏÌÌÏÍÏÏÎÌÌÏÎÎÏÌ _profileIconImage; // 0x80
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _defaultUserIconText; // 0x88
        public ÍÏÍÏÍÏÌÍÍÍÏÏÍÏÌÎÎÎÍÌÎÏÍ _editProfileImageButton; // 0x90
        public ÍÏÍÏÍÏÌÍÍÍÏÏÍÏÌÎÎÎÍÌÎÏÍ _editProfileIconButton; // 0x98
        public UnityEngine.GameObject _editIconModalPrefab; // 0xA0
        public UnityEngine.GameObject _editPictureModalPrefab; // 0xA8
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _editPictureTooltip; // 0xB0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _worldName; // 0xB8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _worldInstance; // 0xC0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _playerCount; // 0xC8
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ _worldInstanceThumbnailImage; // 0xD0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _socialRank; // 0xD8
        public ÍÍÎÍÌÌÍÍÏÏÌÎÌÌÎÍÏÌÏÏÏÏÍ _editStatusButton; // 0xE0
        public UnityEngine.RectTransform _socialRankLayoutContainer; // 0xE8
        public UnityEngine.UI.Toggle _toggleDisplaySocialRank; // 0xF0
        public ÍÎÎÍÍÍÏÏÍÌÏÎÎÏÍÌÌÍÎÌÏÌÏ _socialRankIcon; // 0xF8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _socialRankDisplayedText; // 0x100
        public ÎÌÏÎÍÎÏÌÍÌÍÌÎÌÎÎÍÌÏÎÏÏÏ _socialRankToggleTooltip; // 0x108
        public ÎÌÌÏÎÎÌÏÌÍÍÏÎÍÎÍÍÎÌÍÍÌÌ _editAgeVerificationStatusButton; // 0x110
        public UnityEngine.GameObject _locationContainer; // 0x118
        public UnityEngine.GameObject _publicLocation; // 0x120
        public UnityEngine.GameObject _privateLocation; // 0x128
        public UnityEngine.GameObject _unavailableLocation; // 0x130
        public UnityEngine.GameObject _offlineLocation; // 0x138
        public UnityEngine.GameObject _streamerModeLocation; // 0x140
        public ÎÌÎÍÍÏÏÌÍÍÍÏÍÏÏÏÎÏÏÏÍÎÌ _regionIcon; // 0x148
        public ÏÏÌÎÏÏÌÏÌÌÏÏÍÏÍÎÍÌÌÎÍÌÍ _ageGateIcon; // 0x150
        public UnityEngine.GameObject _unknownRegionIcon; // 0x158
        public UnityEngine.UI.Image _privateLocationImage; // 0x160
        public UnityEngine.UI.Image _offlineLocationImage; // 0x168
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _privateLocationText; // 0x170
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _offlineLocationText; // 0x178
        public UnityEngine.UI.Button _backButton; // 0x180
        public UnityEngine.UI.Button _joinButton; // 0x188
        public UnityEngine.UI.Button _inviteButton; // 0x190
        public UnityEngine.UI.Button _requestInviteButton; // 0x198
        public UnityEngine.UI.Button _favoriteButton; // 0x1A0
        public UnityEngine.UI.Button _unfavoriteButton; // 0x1A8
        public ÏÍÏÍÎÌÌÏÏÍÍÍÏÌÍÍÎÍÏÍÌÍÍ _friendButton; // 0x1B0
        public UnityEngine.UI.Button _unfriendButton; // 0x1B8
        public UnityEngine.UI.Button _unblockButton; // 0x1C0
        public UnityEngine.UI.Button _boopButton; // 0x1C8
        public UnityEngine.UI.Button _modButton; // 0x1D0
        public UnityEngine.UI.Button _reportButton; // 0x1D8
        public UnityEngine.UI.Button _viewWorldDetails; // 0x1E0
        public UnityEngine.UI.Button _giftVRChatPlus; // 0x1E8
        public UnityEngine.UI.Button _viewOnWebsite; // 0x1F0
        public UnityEngine.UI.Button _addNoteButton; // 0x1F8
        public UnityEngine.UI.Button _inviteToGroupButton; // 0x200
        public UnityEngine.UI.Button _viewAvatarDetails; // 0x208
        public UnityEngine.UI.Button _editProfileButton; // 0x210
        public ÎÍÏÎÎÍÎÌÌÏÏÍÌÎÌÎÍÎÍÎÏÎÏ _viewSharedConnectionsButton; // 0x218
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _viewSharedConnectionsText; // 0x220
        public ÍÍÏÏÏÌÎÎÌÌÍÌÎÍÍÌÎÍÏÍÎÌÌ _bioField; // 0x228
        public UnityEngine.UI.Button _bioFieldButton; // 0x230
        public UnityEngine.GameObject _addABioPanel; // 0x238
        public UnityEngine.UI.ScrollRect _bioScrollView; // 0x240
        public ÍÍÏÏÏÌÎÎÌÌÍÌÎÍÍÌÎÍÏÍÎÌÌ _notes; // 0x248
        public UnityEngine.UI.Button _notesButton; // 0x250
        public UnityEngine.GameObject _noteTextGameObject; // 0x258
        public UnityEngine.GameObject _noteHeaderGameObject; // 0x260
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ _badgesListBinding; // 0x268
        public UnityEngine.GameObject _viewAllBadgesButton; // 0x270
        public ÎÎÏÏÌÎÎÏÍÌÍÏÎÏÏÏÍÎÌÍÌÍÍ _groupProfileButton; // 0x278
        public UnityEngine.GameObject _groupsPanel; // 0x280
        public UnityEngine.GameObject _emptyGroupsPanel; // 0x288
        public UnityEngine.GameObject _showAllGroupsButton; // 0x290
        public UnityEngine.GameObject _GroupsPrefab; // 0x298
        public ÎÍÎÎÎÌÏÎÍÏÌÍÎÎÍÌÏÎÎÏÌÍÍ[] _languages; // 0x2A0
        public UnityEngine.GameObject _emptyLanguagesPanel; // 0x2A8
        public ÍÎÏÏÌÏÌÎÏÏÍÌÍÌÌÍÎÍÍÏÏÌÍ[] _links; // 0x2B0
        public UnityEngine.GameObject _emptyLinksPanel; // 0x2B8
        public UnityEngine.GameObject _friendRequestPanel; // 0x2C0
        public UnityEngine.UI.Button _acceptFriendRequestButton; // 0x2C8
        public UnityEngine.UI.Button _declineFriendRequestButton; // 0x2D0
        public UnityEngine.Texture _kickIcon; // 0x2D8
        public UnityEngine.Texture _muteIcon; // 0x2E0
        public UnityEngine.Texture _muteChatboxIcon; // 0x2E8
        public UnityEngine.Texture _blockIcon; // 0x2F0
        public UnityEngine.Texture _reportIcon; // 0x2F8
        public UnityEngine.Texture _warnIcon; // 0x300
        public UnityEngine.Texture _groupIcon; // 0x308
        public UnityEngine.Sprite _offlineIcon; // 0x310
        public UnityEngine.Sprite _activeOnWebIcon; // 0x318
        public UnityEngine.Sprite _mobileIcon; // 0x320
        public UnityEngine.GameObject _actionsContainer; // 0x328
        public ÌÌÎÍÍÌÌÍÏÍÍÍÏÌÍÍÎÍÍÎÌÌÎ ÏÏÎÏÎÎÏÌÌÎÏÍÌÏÌÌÍÎÏÍÏÎÎ; // 0x330
        public ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ ÎÎÏÏÍÌÌÌÍÍÏÌÎÌÏÏÏÎÍÌÌÏÌ; // 0x338
        public ÍÍÎÍÍÍÍÎÏÎÏÏÏÍÎÍÏÌÎÍÌÍÍ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x340
        public UnityEngine.GameObject _avatarsRow; // 0x348
        public UnityEngine.GameObject _worldsRow; // 0x350
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _worldLabel; // 0x358
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _avatarLabel; // 0x360
        public ÏÏÎÎÍÎÎÌÏÍÏÍÍÎÎÍÍÍÎÌÍÍÍ _avatarsListBinding; // 0x368
        public ÏÏÎÎÍÎÎÌÏÍÏÍÍÎÎÍÍÍÎÌÍÍÍ _worldsListBinding; // 0x370
        public ÏÌÏÍÎÌÍÌÏÌÌÍÏÎÌÍÍÎÎÎÎÌÌ _playlistsListBinding; // 0x378
        public ÌÎÍÌÏÏÌÍÌÌÍÏÎÏÎÏÍÏÏÍÍÏÌ _avatarsSortByDropdown; // 0x380
        public ÌÎÍÌÏÏÌÍÌÌÍÏÎÏÎÏÍÏÏÍÍÏÌ _worldsSortByDropdown; // 0x388
        public UnityEngine.GameObject _avatarPrefab; // 0x390
        public UnityEngine.GameObject _worldPrefab; // 0x398
        public UnityEngine.GameObject _viewMorePrefab; // 0x3A0
        public UnityEngine.GameObject _playlistPrefab; // 0x3A8
        public UnityEngine.CanvasGroup ÌÌÎÎÏÍÌÍÏÏÍÎÌÎÌÍÌÎÏÎÎÍÎ; // 0x3B0
        public UnityEngine.CanvasGroup ÏÏÏÏÏÌÌÍÍÏÌÌÏÎÍÌÌÍÎÏÎÍÏ; // 0x3B8
        public UnityEngine.UI.LayoutElement ÍÏÏÌÎÍÌÎÎÏÍÍÎÌÌÏÍÏÏÏÌÏÍ; // 0x3C0
        public UnityEngine.UI.LayoutElement ÎÎÌÍÍÌÏÏÍÍÌÏÍÌÌÍÏÌÌÏÏÌÍ; // 0x3C8
        public VRC.UI.Core.Styles.StyleElement ÌÎÎÍÍÍÌÌÎÏÎÎÏÏÏÍÌÍÎÏÎÌÍ; // 0x3D0
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ ÌÌÏÌÌÌÎÏÎÌÍÎÏÌÌÏÏÌÎÍÎÌÏ; // 0x3D8
        public VRC.UI.Core.Styles.StyleElement ÏÎÌÎÏÍÏÎÍÎÎÎÏÏÍÏÍÏÍÍÌÎÎ; // 0x3E0
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ ÏÌÌÌÌÏÏÌÍÌÏÏÍÌÎÌÌÌÍÏÌÏÌ; // 0x3E8
        public ÎÍÌÏÍÎÍÏÌÌÎÏÌÏÌÏÎÏÌÎÍÏÎ<0x664C8908> ÌÎÎÎÍÍÍÏÏÍÎÌÎÎÍÌÏÎÍÏÎÌÎ; // 0x3F0
        public ÎÍÌÏÍÎÍÏÌÌÎÏÌÏÌÏÎÏÌÎÍÏÎ<0x664D2258> ÎÏÎÎÎÎÏÎÏÏÏÏÏÍÎÎÎÏÌÏÏÌÌ; // 0x3F8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÍÌÌÏÍÏÏÎÌÎÌÏÎÌÏÍÍÎÏÏÍÍÍ; // 0x400
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÌÏÏÍÌÍÎÌÍÍÌÍÏÍÍÏÎÏÏÏÌÏÎ; // 0x408
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<VRC.Localization.LocalizableString> ÎÏÎÌÍÍÍÍÏÍÌÍÌÏÌÏÍÏÌÍÏÎÎ; // 0x410
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<VRC.Localization.LocalizableString> ÏÌÌÌÎÏÍÌÍÍÍÎÏÎÍÏÏÍÍÏÌÏÌ; // 0x418
        public ÎÏÎÏÎÍÍÌÌÏÏÍÎÌÍÎÍÏÌÎÌÎÍ ÎÏÏÍÏÎÍÏÏÎÎÏÏÎÌÎÍÏÌÍÍÌÍ; // 0x420
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÍÎÏÍÎÍÌÎÎÌÍÏÍÎÏÏÍÏÏÌÎÍÍ>> ÍÌÎÌÏÎÏÍÏÌÏÍÎÏÎÍÎÌÍÍÍÌÍ; // 0x478
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÌÏÌÍÍÎÌÏÍÏÏÌÌÍÏÌÍÍÍÎÌÍÏ; // 0x480
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÍÌÏÏÌÏÍÌÏÏÎÌÎÎÌÎÎÏÏÎÍÌ>> ÏÏÎÎÌÏÏÎÌÏÏÎÍÌÏÏÌÍÎÎÍÎÌ; // 0x488
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ ÏÏÌÍÌÏÏÌÎÏÎÎÌÌÍÎÍÌÏÎÌÍÍ; // 0x490
        public VRC.UI.Core.Styles.StyleElement[] ÎÌÌÏÌÌÌÏÏÍÌÎÍÍÎÎÏÌÍÌÏÌÏ; // 0x498
        public string ÏÏÏÏÎÌÍÏÍÏÏÌÌÎÍÌÎÍÏÍÌÎÌ;
        public ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ ÎÎÌÌÍÌÎÏÏÏÏÎÍÌÎÌÎÌÌÍÌÏÎ; // 0x4A0
        public int _maxCells; // 0x4A8
        public UnityEngine.GameObject _loadingOverlay; // 0x4B0
        public UnityEngine.GameObject _userDetailsContainer; // 0x4B8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<VRC.Localization.LocalizableString> ÌÌÍÍÏÍÌÏÎÍÏÎÌÎÏÎÍÏÍÏÏÍÍ; // 0x4C0
        public UnityEngine.GameObject _selectableBadgePrefab; // 0x4C8
        public bool <ÌÏÌÏÌÏÎÌÏÍÍÌÎÏÍÎÌÍÏÏÎÎÌ>k__BackingField; // 0x4D0
        public ÎÎÏÏÌÍÏÍÏÌÍÏÎÌÍÏÌÍÎÍÍÍÏ<ÎÏÌÎÍÏÌÏÎÏÌÍÏÌÍÌÏÌÍÌÏÏÏ> ÍÌÏÌÍÎÎÌÌÏÏÍÏÍÏÍÏÌÌÍÎÌÌ; // 0x4D8
        public ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ ÏÎÍÎÌÏÌÎÍÌÍÍÏÎÏÎÌÍÌÎÌÎÎ; // 0x4E0
        public ÍÍÌÍÏÎÍÍÎÌÏÌÌÏÎÍÏÍÏÌÍÍÌ ÎÌÏÏÌÍÍÌÏÏÍÏÌÏÌÍÎÎÎÏÏÏÍ; // 0x4E8
        public ÎÎÏÏÌÍÏÍÏÌÍÏÎÌÍÏÌÍÎÍÍÍÏ<ÍÌÌÏÎÍÏÍÏÍÎÎÎÌÏÍÍÌÎÌÏÍÌ> ÌÏÎÌÍÍÍÎÏÏÎÎÍÌÎÏÍÏÎÎÏÎÎ; // 0x4F0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÍÏÍÏÍÍÌÌÏÌÎÏÍÏÍÌÌÍÎÎÏÏÌ; // 0x4F8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÏÌÎÎÎÍÎÍÏÎÌÏÍÏÍÌÌÏÎÍÎÌÍ; // 0x500
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> ÌÎÌÎÌÌÌÍÏÌÎÏÌÌÌÍÍÎÌÎÍÏÍ; // 0x508
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<VRC.Localization.LocalizableString> ÎÏÍÌÌÎÌÍÍÍÎÌÏÍÌÌÍÌÎÌÌÎÌ; // 0x510
        public ÎÏÎÏÎÍÍÌÌÏÏÍÎÌÍÎÍÏÌÎÌÎÍ ÌÍÌÌÎÏÎÏÌÎÎÏÏÏÏÎÏÍÌÏÍÍÎ; // 0x518
        public bool ÎÍÍÍÍÌÎÏÏÎÎÏÍÎÍÏÌÏÏÌÍÏÏ; // 0x570
        public string ÍÍÌÍÏÌÏÏÌÏÍÎÏÍÎÍÏÎÌÌÎÏÎ; // 0x578
        public System.Threading.CancellationTokenSource ÏÏÏÍÌÍÍÏÍÍÍÌÎÍÎÍÎÎÌÍÌÌÏ; // 0x580
        public System.Collections.Generic.HashSet`1<ÎÍÍÌÏÍÏÏÎÍÍÎÎÏÏÍÌÏÍÎÎÌÏ> ÍÍÏÍÌÏÍÎÏÏÍÍÏÎÏÏÍÏÎÌÌÍÌ; // 0x588

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD569FE1A0
        public void OnEnable(){} // RVA: 0x7FFD569FE1D0
        public void OnDisable(){} // RVA: 0x7FFD569FE200
        public void CancelInvoke(){} // RVA: 0x7FFD569FE5F0
        public void Invoke(){} // RVA: 0x7FFD569FE850
        public void InvokeRepeating(){} // RVA: 0x7FFD569FEC10
        public void CancelInvoke_AF3F77A04EC1(){} // RVA: 0x7FFD569FED30
        public void IsInvoking(){} // RVA: 0x7FFD569FF150
        public void StartCoroutine(){} // RVA: 0x7FFD569FF610
        public void OnApplicationQuit(){} // RVA: 0x7FFD569FF8B0
        public void OnBecameVisible(){} // RVA: 0x7FFD569FFAC0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD569FFFE0
        public void StopCoroutine(){} // RVA: 0x7FFD569FFFF0
        public void OnCollisionStay(){} // RVA: 0x7FFD56A00360
        public void Start(){} // RVA: 0x7FFD56A00730
        public void StopAllCoroutines(){} // RVA: 0x7FFD56A009E0
        public void get_useGUILayout(){} // RVA: 0x7FFD56A00B50
        public void set_useGUILayout(){} // RVA: 0x7FFD56A00BC0
        public void print(){} // RVA: 0x7FFD56A01310
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD56A01690
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD56A01700
        public void InvokeDelayed(){} // RVA: 0x7FFD56A01A00
        public void Awake(){} // RVA: 0x7FFD56A01E60
        public void OnDestroy(){} // RVA: 0x7FFD56A03940
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD56A04330
        public void StartCoroutineManaged(){} // RVA: 0x7FFD56A060A0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD56A06260
        public void StopCoroutineManaged(){} // RVA: 0x7FFD56A06540
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD56A06670
        public void GetScriptClassName(){} // RVA: 0x7FFD56A069F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD56A06A10
        public void GetGameObjectReference3(){} // RVA: 0x7FFD56A07360
        public void Awake_03737D8618A4(){} // RVA: 0x7FFD56A07910
        public void OnBecameInvisible(){} // RVA: 0x7FFD56A07970
        public void OnCollisionEnter(){} // RVA: 0x7FFD56A07A00
        public void Start_58381140145A(){} // RVA: 0x7FFD56A08740
        public void OnCollisionExit(){} // RVA: 0x7FFD56A08950
        public void OnTriggerEnter(){} // RVA: 0x7FFD56A08A70
        public void OnTriggerStay(){} // RVA: 0x7FFD56A08B60
        public void OnTriggerExit(){} // RVA: 0x7FFD56A08B80
        public void OnEnable_9A36DE44090E(){} // RVA: 0x7FFD56A08C40
        public void Update(){} // RVA: 0x7FFD56A08F10
        public void UpdateblocksRayc(){} // RVA: 0x7FFD56A09030
        public void SetGameObjectActive(){} // RVA: 0x7FFD56A09390
        public void OnApplicationPause(){} // RVA: 0x7FFD56A097C0
        public void OnApplicationQuit_641B25F57260(){} // RVA: 0x7FFD56A09940
        public void OnBecameVisible_CA117C93F5C5(){} // RVA: 0x7FFD56A09A90
        public void OnBecameInvisible_B76B3FEE442E(){} // RVA: 0x7FFD56A09F30
        public void .ctor(){} // RVA: 0x7FFD56A0A070
        public void Initialize(){} // RVA: 0x7FFD56A0AB80
        public void OnCollisionExit_76439B0C403C(){} // RVA: 0x7FFD56A0ADD0
        public void OnTriggerEnter_0F16F3FAC572(){} // RVA: 0x7FFD56A0AF50
        public void OnTriggerStay_9F3992F41E3A(){} // RVA: 0x7FFD56A0B310
        public void OnTriggerExit_4C00E2878340(){} // RVA: 0x7FFD56A0B3C0
        public void FixedUpdate(){} // RVA: 0x7FFD56A0B450
        public void get_mesh(){} // RVA: 0x7FFD4EDCD480
        public void LateUpdate(){} // RVA: 0x7FFD56A0B6D0
        public void LateUpdate_97BCE6E9AB22(){} // RVA: 0x7FFD56A0B820
        public void DoStop(){} // RVA: 0x7FFD56A0B8D0
        public void SetGameObjectActive5(){} // RVA: 0x7FFD56A0BA30
        public void GetMaxDampTime(){} // RVA: 0x7FFD56A0BB40
        public void CheckIsDone_D2B(){} // RVA: 0x7FFD56A0BBE0
        public void get_gameObject(){} // RVA: 0x7FFD56A0C220
        public void get_gameObject_ABBBFDC50386(){} // RVA: 0x7FFD56A0C610
        public void GetGameObjectReference(){} // RVA: 0x7FFD56A0C640
        public void get_mesh_CE83D6256815(){} // RVA: 0x7FFD4EDCD480
        public void get_gameObject_92B59FD1CC79(){} // RVA: 0x7FFD56A0C720
        public void GetGameObjectReference5(){} // RVA: 0x7FFD56A0C730
        public void SetGameObjectActive4(){} // RVA: 0x7FFD56A0CD50
        public void Start_7438D29FF63F(){} // RVA: 0x7FFD56A0CFD0
        public void OnEnable_0C36E17BF6D1(){} // RVA: 0x7FFD56A0D320
        public void OnGUI(){} // RVA: 0x7FFD56A0D520
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFD56A0D680
        public void OnValidate(){} // RVA: 0x7FFD56A0D7E0
        public void get_gameObject_A43966040E3C(){} // RVA: 0x7FFD56A0DA10
        public void GetRange(){} // RVA: 0x7FFD56A0DD80
        public void DestroyImmediate(){} // RVA: 0x7FFD56A0DFC0
        public void Equals(){} // RVA: 0x7FFD56A0E0E0
        public void ContainsChild(){} // RVA: 0x7FFD56A0E380
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD56A0E5E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD56A0E940
        public void StartComplexRoutine(){} // RVA: 0x7FFD56A0F070
        public void GetPlatform(){} // RVA: 0x7FFD56A0F190
        public void GetDisclaimerText(){} // RVA: 0x7FFD56A0F250
        public void GetCachedPtr(){} // RVA: 0x7FFD56A0F300
        public void InitializeStartStopDestroy(){} // RVA: 0x7FFD56A0F520
        public void GetInstanceID(){} // RVA: 0x7FFD56A0F6E0
        public void StopComplexRoutine(){} // RVA: 0x7FFD56A0FA60
        public void GetMaskTransform(){} // RVA: 0x7FFD56A0FB80
        public void UpdateStartStopDestroy(){} // RVA: 0x7FFD56A102E0
        public void GetComplexScriptClass(){} // RVA: 0x7FFD56A10480
        public void HandleComplexVisibility(){} // RVA: 0x7FFD56A10570
        public void SetDestroyCancellationToken(){} // RVA: 0x7FFD56A10660
        public void DoInverseTransform(){} // RVA: 0x7FFD56A10790
        public void StartCoroutine_Auto_621564668ABB(){} // RVA: 0x7FFD56A108B0
        public void GetSelectedDataPointer(){} // RVA: 0x7FFD56A109C0
        public void GetHashCode(){} // RVA: 0x7FFD56A10AC0
        public void CalculateInitialOffset(){} // RVA: 0x7FFD56A10BD0
        public void Awake_FF3ED4332166(){} // RVA: 0x7FFD56A10BE0
        public void CancelInvoke_9D4AB095CD36(){} // RVA: 0x7FFD56A10BF0
        public void GetUseGUILayout(){} // RVA: 0x7FFD56A10C50
        public void UpdateGameObjectActiveStates(){} // RVA: 0x7FFD56A10E70
        public void UpdateActive(){} // RVA: 0x7FFD56A115C0
        public void GetLast(){} // RVA: 0x7FFD56A11750
        public void ComputeactiveSelf(){} // RVA: 0x7FFD56A11860
        public void Start_56BB5D0DEDA7(){} // RVA: 0x7FFD56A11970
        public void DoEncodeToPN(){} // RVA: 0x7FFD56A11AE0
        public void ProcessStartStopDestroy(){} // RVA: 0x7FFD56A11C90
        public void __get_Multiline__SystemTextRegularExpressionsRegexOptions(){} // RVA: 0x7FFD56A12350
    }

    /// <summary>Originally: ÌÌÎÍÍÌÌÍÏÍÍÍÏÌÍÍÎÍÍÎÌÌÎ</summary>
    public class ComplexComponent_5D5C : MonoBehaviour
    {
        public string _destroyCancellationToken; // 0x20
        public bool _useGUILayout; // 0x28
        public bool f_639; // 0x29
        public bool f_0C3; // 0x2A
        public bool f_B19; // 0x2B
        public ÍÎÎÌÎÌÌÍÎÌÍÏÏÌÏÎÎÎÍÏÍÎÎ f_ABE; // 0x30
        public bool f_6A9; // 0x38
        public ÏÏÏÏÌÍÏÌÎÎÏÏÏÌÌÍÏÌÍÌÌÍÍ f_A19; // 0x40
        public bool f_067; // 0x48
        public ÎÎÍÍÏÏÎÌÏÏÍÌÍÌÎÌÏÎÎÌÏÎÎ f_5EA; // 0x50
        public UnityEngine.RectTransform f_A6B; // 0x58
        public UnityEngine.CanvasGroup f_208; // 0x60
        public float f_C30;
        public System.Action`1<VRC.Localization.LocalizableString> f_6B8; // 0x68
        public System.Action`2<bool,0x66594E18> f_80C; // 0x70
        public System.Action`1<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> f_748; // 0x78
        public System.Action f_A09; // 0x80
        public System.Action f_637; // 0x88
        public System.Action`1<bool> f_94A; // 0x90
        public System.Action f_840; // 0x98
        public ÍÌÏÎÍÏÍÍÎÌÎÏÏÏÎÎÏÏÏÌÌ f_3AD; // 0xA0
        public System.Collections.Generic.Dictionary`2<UnityEngine.Behaviour,bool> f_26A; // 0xA8
        public System.Collections.Generic.List`1<ÎÌÌÎÎÌÍÏÎÌÍÍÏÎÎÎÏÌÍÌÏÍÏ> f_D94; // 0xB0
        public System.Collections.Generic.List`1<ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ> f_E06; // 0xB8
        public bool f_0A0; // 0xC0
        public System.Collections.Generic.List`1<ÌÏÍÌÎÏÌÍÏÍÎÌÎÎÌÏÍÎÌÌÏÍÍ> f_7CA; // 0xC8
        public System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D> f_201; // 0xD0
        public System.Collections.Generic.List`1<ÍÏÌÎÌÍÎÍÎÎÍÌÏÌÌÌÏÍÍÍÍÌÍ> f_B13; // 0xD8
        public System.Collections.Generic.List`1<UnityEngine.Canvas> f_5C4; // 0xE0
        public System.Collections.Generic.List`1<UnityEngine.UI.GraphicRaycaster> ÌÌÎÎÎÏÎÎÏÍÎÌÍÍÍÏÌÏÌÍÍÍÏ; // 0xE8
        public System.Collections.Generic.List`1<UnityEngine.Behaviour> ÍÎÌÎÌÍÏÏÏÎÎÌÎÌÍÎÌÍÍÎÍÌÎ; // 0xF0
        public ÍÌÎÍÏÎÎÌÌÎÎÌÏÏÎÏÌÍÌÌÍÏÎ ÎÎÏÎÎÏÏÌÎÍÌÏÏÎÌÎÏÏÏÏÍÍÎ; // 0xF8
        public int <TransitionSortOrder>k__BackingField; // 0x100
        public ÍÌÌÍÎÏÍÏÏÏÏÏÌÎÍÏÍÎÏÏÌÏÍ ÍÍÎÎÌÏÎÌÎÏÎÍÎÎÌÎÎÎÏÎÍÏÍ; // 0x108
        public bool <ÌÍÍÎÎÍÏÎÍÏÌÏÍÎÍÎÎÌÌÎÌÏÌ>k__BackingField; // 0x110
        public ÏÌÎÍÏÎÍÎÏÏÍÌÎÌÏÍÏÍÍÍÍÎÌ ÌÏÌÎÏÎÌÏÎÌÏÌÍÏÏÍÏÌÏÌÎÏÎ; // 0x118
        public 0x665953F0 ÍÍÏÍÌÌÏÏÎÏÌÌÏÍÌÍÍÍÏÎÎÌÎ; // 0x120
        public System.Threading.CancellationTokenSource ÎÎÌÏÎÏÌÍÍÏÎÌÌÏÍÌÍÌÎÏÏÌÍ; // 0x128
        public System.Collections.Generic.List`1<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ> ÏÌÏÍÍÌÎÌÏÎÏÍÎÏÎÌÌÎÎÍÏÍÏ; // 0x130

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD5678D010
        public void RaiseCancellation(){} // RVA: 0x7FFD5678D0E0
        public void IsInvoking(){} // RVA: 0x7FFD5678D1D0
        public void set_featuredAvatarCategoryId(){} // RVA: 0x7FFD4E563400
        public void Invoke(){} // RVA: 0x7FFD5678D2A0
        public void InvokeRepeating(){} // RVA: 0x7FFD5678D3A0
        public void CancelInvoke(){} // RVA: 0x7FFD5678D570
        public void GetTypeCode(){} // RVA: 0x7FFD5678D590
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void StartCoroutine(){} // RVA: 0x7FFD5678D5B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD5678D610
        public void StopCoroutine(){} // RVA: 0x7FFD5678D8A0
        public void get_CanBeNull(){} // RVA: 0x7FFD4FFA2F20
        public void ToBoolean(){} // RVA: 0x7FFD5678D940
        public void StopAllCoroutines(){} // RVA: 0x7FFD5678DAC0
        public void Awake(){} // RVA: 0x7FFD5678DBC0
        public void set_useGUILayout(){} // RVA: 0x7FFD5678DBD0
        public void print(){} // RVA: 0x7FFD5678DC90
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD5678DFB0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E341310
        public void InvokeDelayed(){} // RVA: 0x7FFD5678E020
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void OnTriggerExit_47EB68DD7E57(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD5678E1A0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD5678E290
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD5678E480
        public void StopCoroutineManaged(){} // RVA: 0x7FFD5678E560
        public void GetMainCamera(){} // RVA: 0x7FFD4EAF1F40
        public void get_gameObject(){} // RVA: 0x7FFD4E7DD180
        public void get_featuredAvatarCategoryId(){} // RVA: 0x7FFD4E55CBB0
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void OnTriggerStay(){} // RVA: 0x7FFD5678E590
        public void ToChar(){} // RVA: 0x7FFD4E341310
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFD4EC8C550
        public void get_Created(){} // RVA: 0x7FFD52C3E0A0
        public void ToSByte(){} // RVA: 0x7FFD5678E5B0
        public void ToByte(){} // RVA: 0x7FFD5678E6B0
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void ToInt16(){} // RVA: 0x7FFD5678E8C0
        public void Start(){} // RVA: 0x7FFD5678EA40
        public void FixedUpdate(){} // RVA: 0x7FFD5678EB50
        public void Update(){} // RVA: 0x7FFD5678EBF0
        public void LateUpdate(){} // RVA: 0x7FFD5678FB60
        public void ToUInt16(){} // RVA: 0x7FFD5678D590
        public void OnDestroy(){} // RVA: 0x7FFD4E341310
        public void OnApplicationPause(){} // RVA: 0x7FFD5678FBB0
        public void ToBoolean_3268EEDB4637(){} // RVA: 0x7FFD4E3624C0
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void OnBecameInvisible(){} // RVA: 0x7FFD5678FD20
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E963900
        public void get_blurPasses(){} // RVA: 0x7FFD540268C0
        public void OnCollisionExit(){} // RVA: 0x7FFD4E078E90
        public void OnTriggerEnter(){} // RVA: 0x7FFD5678FE20
        public void ToInt32(){} // RVA: 0x7FFD5678FE40
        public void ToUInt32(){} // RVA: 0x7FFD4E341310
        public void ToInt64(){} // RVA: 0x7FFD4E341310
        public void ToDateTime(){} // RVA: 0x7FFD4E409500
        public void ResolveComponentProperty(){} // RVA: 0x7FFD5678FF00
        public void ToUInt64(){} // RVA: 0x7FFD5678FFF0
        public void ToSingle(){} // RVA: 0x7FFD567900E0
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFD4E607D90
        public void ToDouble(){} // RVA: 0x7FFD567901D0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD56790380
        public void ToDecimal(){} // RVA: 0x7FFD567903E0
        public void ToString(){} // RVA: 0x7FFD567909D0
        public void UpdateActive(){} // RVA: 0x7FFD56790A10
        public void op_Implicit(){} // RVA: 0x7FFD4F9181E0
        public void ToType(){} // RVA: 0x7FFD56790C00
        public void Awake_0EACF06453AE(){} // RVA: 0x7FFD56790DA0
        public void set_pointerId(){} // RVA: 0x7FFD5509A8E0
        public void Start_6861B69187EE(){} // RVA: 0x7FFD56790DF0
        public void get_disclaimerText(){} // RVA: 0x7FFD4E499460
        public void SetConnectedBody4(){} // RVA: 0x7FFD4E341310
        public void set_name(){} // RVA: 0x7FFD4F9181E0
        public void Initialize_2E8FD6547269(){} // RVA: 0x7FFD56791CB0 | overloaded x2
        public void OnDisable(){} // RVA: 0x7FFD56790E20
        public void BuildPoseArguments(){} // RVA: 0x7FFD56790E70
        public void Update_84A206AF7E24(){} // RVA: 0x7FFD56790EC0
        public void OnApplicationQuit(){} // RVA: 0x7FFD540268C0
        public void OnBecameVisible(){} // RVA: 0x7FFD56790FB0
        public void OnSerializing(){} // RVA: 0x7FFD4E409500
        public void SetResources_1FF4DC82BF07(){} // RVA: 0x7FFD4E605C40
        public void OnCollisionStay(){} // RVA: 0x7FFD56791230
        public void get_IgnoreDefaultValuesOnWrite(){} // RVA: 0x7FFD4FFA2F30
        public void InitializeGameObjectGetter(){} // RVA: 0x7FFD56791250
        public void ValidateBounds_43306D7A9C3D(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void OnDestroy_6C31885CF8AC(){} // RVA: 0x7FFD56791350
        public void Internal_CancelInvokeAll_4412BCBE55CA(){} // RVA: 0x7FFD56791370
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void ResolveComponentProperty_B308415BFDB8(){} // RVA: 0x7FFD567914C0
        public void set_trackerAnchor(){} // RVA: 0x7FFD4E3DF380
        public void OnEnable_F9557EA8BA59(){} // RVA: 0x7FFD56791510
        public void .ctor(){} // RVA: 0x7FFD56791600
        public void .cctor(){} // RVA: 0x7FFD56791DC0
        public void IsSetup(){} // RVA: 0x7FFD4E516BA0
        public void GetUnityEngine(){} // RVA: 0x7FFD56791E00
        public void OnEnable(){} // RVA: 0x7FFD56791F00
        public void SetConnectedBody2(){} // RVA: 0x7FFD4E341310
        public void set_Color(){} // RVA: 0x7FFD4F044F40
        public void SetGameObjectActive2(){} // RVA: 0x7FFD56791F50
        public void SetGameObjectActive3(){} // RVA: 0x7FFD56792050
        public void SetGameObjectActive(){} // RVA: 0x7FFD56792400
        public void OnDisable_52D3FA58E3AC(){} // RVA: 0x7FFD56792680
        public void SetGameObjectActive6(){} // RVA: 0x7FFD56792880
        public void SetConnectedBody3(){} // RVA: 0x7FFD4E341310
        public void SetGameObjectActive_509B47EE515C(){} // RVA: 0x7FFD56792970
        public void SetGameObjectActive5(){} // RVA: 0x7FFD56792990
        public void SetGameObjectActive4(){} // RVA: 0x7FFD56792A90
        public void ToDateTime_C9F53CC79683(){} // RVA: 0x7FFD567909D0
        public void OnDestroy_92B59FD1CC79(){} // RVA: 0x7FFD56792B50
        public void InitializeOwnedSlot(){} // RVA: 0x7FFD4E36F0C0
    }

    /// <summary>Originally: ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍÍÏÎ</summary>
    public class ComplexComponent_6FD4 : MonoBehaviour
    {
        public ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍÍÏÎ _destroyCancellationToken;
        public System.Collections.Generic.Dictionary`2<0x6635C2B0,System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>>> _useGUILayout; // 0x20
        public float f_440;
        public float f_F2E; // 0x28
        public int f_374;
        public int f_E42;
        public int f_30D;
        public string f_C7D;
        public float f_2B0; // 0x2C
        public float f_E02; // 0x30
        public bool f_C56; // 0x34
        public bool f_F5A; // 0x35
        public bool f_E72; // 0x36
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_2BC; // 0x38
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_C95; // 0x40
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_149; // 0x48
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_52B; // 0x50
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_8F6; // 0x58
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_908; // 0x60
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_FE1; // 0x68
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_B26; // 0x70
        public System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> f_00A; // 0x78
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_75C; // 0x80
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_A10; // 0x88
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_6BD; // 0x90
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_49B; // 0x98
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_A82; // 0xA0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_DFC; // 0xA8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_E10; // 0xB0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_426; // 0xB8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_9DD; // 0xC0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_B00; // 0xC8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_A84; // 0xD0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_BCE; // 0xD8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_67A; // 0xE0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_A7F; // 0xE8
        public bool f_39D; // 0xF0
        public bool f_D1E; // 0xF1
        public bool f_561; // 0xF2
        public bool <ÏÎÌÌÍÌÍÍÎÏÏÏÍÌÍÏÏÏÎÎÌÏÎ>k__BackingField; // 0xF3
        public bool <ÎÍÌÎÎÍÏÍÏÍÎÎÍÌÏÏÍÎÍÎÏÌÍ>k__BackingField; // 0xF4
        public bool <ÏÌÌÍÍÎÎÍÎÌÏÍÍÏÌÎÎÏÏÌÍÎÏ>k__BackingField; // 0xF5
        public bool <ÏÍÌÎÌÎÏÎÍÏÎÍÍÏÍÌÏÏÍÎÍÌÍ>k__BackingField; // 0xF6
        public 0x664CD2F0 ÌÏÏÏÍÍÍÏÍÎÌÍÏÌÎÎÌÎÎÎÏÍÍ; // 0xF8
        public string ÌÏÎÎÎÎÌÎÏÍÎÌÌÌÏÎÌÌÍÍÏÎÏ;
        public string ÌÌÌÌÎÎÌÎÎÌÎÌÍÎÍÍÍÌÏÏÏÏÏ;
        public string ÌÏÍÌÍÌÏÌÍÏÎÏÌÍÏÏÌÏÏÏÎÍÍ;
        public string ÍÎÏÍÍÎÍÏÌÏÍÍÍÎÏÍÏÍÍÌÍÎÌ;
        public string ÌÌÌÍÎÏÍÏÍÏÍÎÌÍÏÏÍÌÏÌÎÎÌ;
        public string ÏÍÍÍÎÌÎÍÌÌÎÍÍÍÏÏÌÎÌÍÏÍÎ;
        public string ÍÌÍÌÎÌÎÍÎÏÍÎÍÌÎÌÌÎÌÏÍÍÎ;
        public string ÎÏÍÎÍÍÌÎÎÏÌÏÎÍÎÏÏÌÌÍÏÏÎ;
        public string ÍÎÍÎÍÏÏÎÏÌÍÍÌÎÍÎÏÏÎÍÍÌÏ;
        public string ÍÏÏÎÏÎÌÍÍÏÍÌÎÌÎÏÍÌÏÎÏÌÍ;
        public string ÌÌÏÏÍÌÍÎÌÌÌÎÌÏÍÍÏÌÌÍÌÏÍ;
        public System.Action`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ> <ÍÍÌÍÌÎÏÌÎÏÍÍÍÏÌÏÍÏÏÏÏÎÍ>k__BackingField; // 0x100
        public System.Collections.Generic.List`1<string> ÏÎÏÍÌÏÎÍÎÌÌÍÎÍÎÍÎÍÏÏÏÌÍ; // 0x108
        public System.Collections.Generic.Dictionary`2<string,float> ÏÎÌÎÏÎÏÌÏÍÎÏÏÍÎÌÎÏÏÌÎÌÍ; // 0x110
        public float ÍÍÏÎÏÏÌÎÎÍÎÌÎÎÏÍÎÎÍÌÍÌÌ;
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÌÍÌÎÎÌÌÌÌÌÏÏÍÍÌÏÎÎÎÎÏÎÌ>k__BackingField; // 0x118
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÏÏÌÍÎÎÍÍÍÏÍÍÏÎÌÌÏÌÏÏÎÌÍ>k__BackingField; // 0x120
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÎÎÏÌÎÍÎÎÍÏÌÌÍÏÌÌÍÍÌÎÍÍÎ>k__BackingField; // 0x128
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÍÍÍÍÏÍÏÌÎÏÏÎÏÏÎÎÎÏÌÌÎÏÍ>k__BackingField; // 0x130
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÌÍÍÏÎÎÌÎÎÏÍÌÌÍÌÍÍÌÎÎÎÌÎ>k__BackingField; // 0x138
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> <ÍÎÏÌÏÏÎÍÏÌÏÌÌÍÍÌÎÏÍÎÍÏÎ>k__BackingField; // 0x140
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÏÌÍÏÌÏÎÌÌÌÎÎÏÌÌÏÏÎÏÍÎÍÎ>k__BackingField; // 0x148
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÌÏÏÍÍÍÌÏÎÎÏÌÌÍÌÍÌÎÌÏÎÎÎ>k__BackingField; // 0x150
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÎÏÍÍÏÍÏÏÌÏÍÏÎÏÌÌÏÏÎÌÍÎÌ>k__BackingField; // 0x158
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÎÎÎÏÏÌÎÎÎÎÏÎÏÍÎÎÎÎÍÎÏÌÏ>> <ÍÍÌÌÏÎÌÌÍÎÎÏÌÍÍÌÎÎÎÍÏÌÎ>k__BackingField; // 0x160

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F279140
        public void RaiseCancellation(){} // RVA: 0x7FFD4F2798B0
        public void IsInvoking(){} // RVA: 0x7FFD4F279C10
        public void Update(){} // RVA: 0x7FFD4F279C20
        public void Invoke(){} // RVA: 0x7FFD4F27A050
        public void InvokeRepeating(){} // RVA: 0x7FFD4F27A0D0
        public void UpdateComplexComponentState(){} // RVA: 0x7FFD4F27A480
        public void OnApplicationPause(){} // RVA: 0x7FFD4F27A490
        public void StartCoroutine(){} // RVA: 0x7FFD4F27A4A0
        public void OnBecameVisible(){} // RVA: 0x7FFD4F27A5D0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F27B050
        public void get_preserveAspect(){} // RVA: 0x7FFD4F27B1F0
        public void StopCoroutine(){} // RVA: 0x7FFD4F27B200
        public void OnCollisionExit(){} // RVA: 0x7FFD4F27B3D0
        public void get_version(){} // RVA: 0x7FFD4E3AC040
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F27B5E0
        public void get_useGUILayout(){} // RVA: 0x7FFD4F27B670
        public void set_useGUILayout(){} // RVA: 0x7FFD4F27B680
        public void print(){} // RVA: 0x7FFD4F27B910
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F27B990
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F27BD60
        public void InvokeDelayed(){} // RVA: 0x7FFD4F27BFE0
        public void SetActionBinding_sub(){} // RVA: 0x7FFD4F27C150
        public void DoFindRelativeTransformWithPath_B1A(){} // RVA: 0x7FFD4F27C730
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F27CDB0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F27CF00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F27D0A0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F27D3A0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4F27D810
        public void GetScriptClassName(){} // RVA: 0x7FFD4F27D950
        public void get_contentList(){} // RVA: 0x7FFD4E960F70
        public void ReadCameraState(){} // RVA: 0x7FFD4F27D980
        public void get_HttpProxy(){} // RVA: 0x7FFD4E7C98A0
        public void ReadCameraState_C060DB1D8E52(){} // RVA: 0x7FFD4F27D990
        public void LateUpdate(){} // RVA: 0x7FFD4F27DC90
        public void get_fillCenter(){} // RVA: 0x7FFD4F27DCB0
        public void OnDestroy(){} // RVA: 0x7FFD4F27DCC0
        public void LateUpdate_E02F6BBD4B0C(){} // RVA: 0x7FFD4F27DD80
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F27E140
        public void OnApplicationQuit_E91B15EA4181(){} // RVA: 0x7FFD4F27E2E0
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E3AC040
        public void OnCollisionStay(){} // RVA: 0x7FFD4F27EB50
        public void ConvertDateTimeToSingle(){} // RVA: 0x7FFD4F27EC90
        public void SetGameObjectActive3(){} // RVA: 0x7FFD4F27EDA0
        public void get_featuredAvatarCategoryId(){} // RVA: 0x7FFD4E55CBB0
        public void OnTriggerExit(){} // RVA: 0x7FFD4F27EDB0
        public void HasVideo(){} // RVA: 0x7FFD4F27EE50
        public void ResetDestroyCancellationToken(){} // RVA: 0x7FFD4F27FF10
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void AppendCore(){} // RVA: 0x7FFD4F280210
        public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
        public void GetUseGUILayout(){} // RVA: 0x7FFD4F282820
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFD4E3AC600
        public void set_hasSelection(){} // RVA: 0x7FFD4F282830
        public void get_name(){} // RVA: 0x7FFD4F282840
        public void CancelInvoke(){} // RVA: 0x7FFD4F282980
        public void get_onPressed(){} // RVA: 0x7FFD4E3AC120
        public void GetInstanceID(){} // RVA: 0x7FFD4F282B60
        public void GetTexture(){} // RVA: 0x7FFD4E45E100
        public void set_isPointerDown(){} // RVA: 0x7FFD4F282B70
        public void DoFindRelativeTransformWithPath_B1A_B607C9594FCD(){} // RVA: 0x7FFD4F282B80
        public void get_categories(){} // RVA: 0x7FFD4E916C80
        public void set_categories(){} // RVA: 0x7FFD4E916750
        public void get_disclaimerText(){} // RVA: 0x7FFD4E499460
        public void ResetUseGUILayout(){} // RVA: 0x7FFD4F282D90
        public void HandleUseGUILayout(){} // RVA: 0x7FFD4F282FE0
        public void get_MotionBlurCameras(){} // RVA: 0x7FFD4E96DFA0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4F2834D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F2834E0
        public void HandleUseGUILayoutDestroyCancellationToken(){} // RVA: 0x7FFD4F283680
        public void .ctor(){} // RVA: 0x7FFD4F283990
        public void Initialize(){} // RVA: 0x7FFD4F285120
        public void HandlePointerHover(){} // RVA: 0x7FFD4F2852C0
        public void get_destroyCancellationToken_BCBB1141DB1A(){} // RVA: 0x7FFD4F2855A0
        public void HandlePointerDrag(){} // RVA: 0x7FFD4F285630
        public void HandlePointerDragDestroyCancellationToken(){} // RVA: 0x7FFD4F285640
        public void HandleRectTransform(){} // RVA: 0x7FFD4F285780
        public void HandleRectTransformDestroyCancellationToken(){} // RVA: 0x7FFD4F2857F0
        public void HasAudio(){} // RVA: 0x7FFD4E3C2AD0
        public void ovr_FreeMessage(){} // RVA: 0x7FFD4F285FD0
        public void HandleLayoutState(){} // RVA: 0x7FFD4F286120
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFD4F286180
        public void Awake_66DAF597F4F3(){} // RVA: 0x7FFD4F2862C0
        public void HandleTabContent(){} // RVA: 0x7FFD4F286480
        public void HasVideo_DAEE8E6FB8DC(){} // RVA: 0x7FFD4F286730
        public void HasVideo_5E919D5007E2(){} // RVA: 0x7FFD4F286780
        public void HandleObservableListDestroyCancellationToken(){} // RVA: 0x7FFD4F286790
        public void HasVideo_141B5DDEB2E1(){} // RVA: 0x7FFD4F2867A0
        public void get_promotion(){} // RVA: 0x7FFD4E7DC6D0
        public void get_Uploaded(){} // RVA: 0x7FFD4E9622C0
        public void HandleScrollStateDestroyCancellationToken(){} // RVA: 0x7FFD4F286880
        public void Awake(){} // RVA: 0x7FFD4F286A70
        public void OnEnable(){} // RVA: 0x7FFD4F2872D0
        public void UpdateRealtimeTimestamp(){} // RVA: 0x7FFD4F2872E0
        public void HasVideo_8CEFDF695D83(){} // RVA: 0x7FFD4F2875E0
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void ResetVisibilityState(){} // RVA: 0x7FFD4F287E70
        public void OnDisable(){} // RVA: 0x7FFD4F287F50
        public void HandlePreCullState(){} // RVA: 0x7FFD4F2880E0
        public void ComputeHashCode(){} // RVA: 0x7FFD4F2884C0
        public void HandlePreCullStateDestroyCancellationToken(){} // RVA: 0x7FFD4F288600
        public void UpdateComplexComponentState_0D1BAA95D5F6(){} // RVA: 0x7FFD4F288850
        public void ComputeHashCode_A3F6AE95C128(){} // RVA: 0x7FFD4F288950
        public void GetColliderComponents_E8F29942BC02(){} // RVA: 0x7FFD4E963900
        public void UpdatePointerDrag(){} // RVA: 0x7FFD4F288DE0
        public void get_UploadLength(){} // RVA: 0x7FFD4E3AC5F0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F288E00
        public void OnTriggerStay(){} // RVA: 0x7FFD4F289570
        public void set_ProtocolHandler(){} // RVA: 0x7FFD4F289950
        public void UpdatePointerDragDestroyCancellationToken(){} // RVA: 0x7FFD4F289960
        public void get_useGUILayout_08C1C769F4D7(){} // RVA: 0x7FFD4F27B670
        public void get_ProtocolHandler(){} // RVA: 0x7FFD4F289A60
        public void UpdateRectTransformDestroyCancellationToken(){} // RVA: 0x7FFD4F289BA0
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void get_ProtocolHandler_133FA53CB330(){} // RVA: 0x7FFD4F289BB0
        public void ComputeHashCode_45AF8AE344FC(){} // RVA: 0x7FFD4F289CA0
        public void UpdateTabContent(){} // RVA: 0x7FFD4F28A060
        public void get_Headers(){} // RVA: 0x7FFD4E962410
        public void GetSource(){} // RVA: 0x7FFD4E964340
        public void UpdateTabContentDestroyCancellationToken(){} // RVA: 0x7FFD4F28A070
        public void UpdateObservableList(){} // RVA: 0x7FFD4F28A0A0
        public void Sequence(){} // RVA: 0x7FFD4E426850
        public void InvokePrimaryAndSecondaryCallbacks(){} // RVA: 0x7FFD4F28A990
        public void get_search(){} // RVA: 0x7FFD4E3C2970
        public void get_listingIds(){} // RVA: 0x7FFD4E9666F0
        public void UpdateObservableListDestroyCancellationToken(){} // RVA: 0x7FFD4F28AE40
        public void UpdateScrollState(){} // RVA: 0x7FFD4F28AF80
        public void SetGameObjectActive3_BD2B28AF46F7(){} // RVA: 0x7FFD4F28D270
        public void get_domainList(){} // RVA: 0x7FFD4E3C2900
        public void SetGameObjectActive(){} // RVA: 0x7FFD4F28D6F0
        public void SetGameObjectActive_93D0DDA1F28C(){} // RVA: 0x7FFD4F28D8D0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F28DA20
        public void get_taglineText(){} // RVA: 0x7FFD4E96B1A0
        public void GetUnityEngine_D5D657A4FC21(){} // RVA: 0x7FFD4F28DA60
        public void RefreshUseGUILayout(){} // RVA: 0x7FFD4F28DAF0
        public void SetGameObjectActive_058F735D89DA(){} // RVA: 0x7FFD4F28DC30
        public void set_vectorImage(){} // RVA: 0x7FFD4F28E1D0
        public void RefreshPointerHover(){} // RVA: 0x7FFD4E341320
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void GetUnityEngine_6DDDDE54C7AA(){} // RVA: 0x7FFD4F28E1E0
        public void GetUnityEngine_81BE4A0A14E7(){} // RVA: 0x7FFD4F28E2D0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F28E330
        public void Start(){} // RVA: 0x7FFD4F28E850
        public void GetTransformReference(){} // RVA: 0x7FFD4F28E870
        public void get_rebuildTargetParent(){} // RVA: 0x7FFD4E3AC660
        public void SetGameObjectActive4(){} // RVA: 0x7FFD4F28EB60
        public void RefreshPointerDragDestroyCancellationToken(){} // RVA: 0x7FFD4F28ECA0
    }

    /// <summary>Originally: ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ</summary>
    public class ComplexComponent_7316 : MonoBehaviour
    {
        public bool _destroyCancellationToken;
        public bool _useGUILayout; // 0x1
        public float f_514; // 0x4
        public float f_F4C; // 0x8
        public float f_292; // 0xC
        public bool f_53E; // 0x10
        public System.Collections.Generic.List`1<ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ> f_320; // 0x18
        public int f_87C; // 0x20
        public string f_C34; // 0x28
        public System.Action f_643; // 0x30
        public float f_32E;
        public System.Collections.Generic.List`1<System.ValueTuple`2<float,0x663484B8>> f_6F0; // 0x38
        public 0x66348568 f_2C6; // 0x20
        public 0x66348460 f_6AF; // 0x24
        public 0x663484B8 f_CC8; // 0x28
        public 0 ÎÍÌÌÍÌÌÍÎÍÌÌÍÍÌÌÎÌÎÌÌÏÌ; // 0x2C
        public float ÏÍÎÎÍÍÏÍÍÍÏÌÍÌÎÍÌÍÍÎÍÎÎ;
        public 0x663485C0 ÎÍÏÏÎÌÏÎÎÏÍÏÌÎÌÍÎÍÌÏÌÍÏ; // 0x30
        public bool ÎÎÎÎÎÌÏÎÌÌÌÏÍÎÍÎÏÍÌÏÏÌÎ; // 0x34
        public 0x66348618 ÍÎÎÍÏÏÏÍÌÌÍÌÍÍÍÍÏÏÍÌÌÌÍ; // 0x38
        public bool ÎÌÏÏÍÎÌÎÏÎÌÌÌÌÏÍÎÏÏÍÎÏÎ; // 0x3C
        public bool ÍÏÍÌÏÍÌÌÎÏÎÍÌÌÎÍÏÍÏÍÎÍÎ; // 0x3D
        public float <ÌÌÌÏÎÍÏÍÌÏÏÏÏÌÏÍÌÌÎÎÍÏÌ>k__BackingField; // 0x40
        public ÎÍÌÎÏÌÍÍÎÎÌÏÎÍÏÎÌÏÍÎÎÏÎ <ÎÏÌÏÍÌÏÏÎÏÏÍÏÎÌÎÏÎÍÌÎÎÎ>k__BackingField; // 0x48
        public long ÎÍÌÍÌÍÏÍÎÎÍÍÍÍÍÍÏÌÌÍÎÌÍ; // 0x50
        public float ÍÍÌÏÎÌÌÎÍÎÍÎÌÌÎÌÌÍÌÎÍÎÌ; // 0x58
        public int ÍÎÏÍÌÎÍÍÌÏÌÍÍÍÏÌÌÍÏÎÎÎÏ;
        public int ÎÌÍÎÏÎÏÌÌÌÌÍÎÍÍÌÎÍÌÎÎÏÌ;
        public System.Action ÎÌÏÍÍÎÏÎÎÏÌÌÎÍÏÎÏÎÍÎÍÏÌ; // 0x60
        public System.Action ÎÎÍÎÌÍÎÏÏÏÎÌÎÏÏÎÌÏÍÌÍÍÍ; // 0x68
        public System.Action ÍÏÍÌÌÌÏÌÍÎÎÏÏÌÏÎÍÎÎÎÎÌÍ; // 0x70
        public 0x664CCF28 <ÌÎÎÍÎÌÌÍÏÏÎÏÏÌÏÌÌÎÌÍÎÍÌ>k__BackingField; // 0x78
        public bool ÏÏÏÏÍÌÌÎÍÎÏÎÍÎÎÌÍÍÌÍÏÏÌ; // 0x80
        public string[] ÏÏÎÌÎÎÍÏÍÏÌÌÎÌÏÌÌÌÎÏÏÏÎ; // 0x40
        public string ÌÏÌÍÏÍÎÌÎÎÎÌÍÍÍÎÏÍÏÌÍÍÏ;
        public string ÍÏÎÌÍÌÍÏÏÍÍÏÎÌÏÌÎÏÌÍÍÍÌ;
        public int ÎÎÌÏÍÎÎÎÎÌÏÍÎÍÍÌÎÏÎÎÌÏÌ;
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ ÎÎÏÍÍÎÎÏÌÎÍÌÎÎÎÌÍÏÏÎÌÌÎ; // 0x88
        public UnityEngine.AudioSource ÏÌÎÌÎÌÌÎÌÌÎÏÎÍÍÌÍÌÎÏÌÎÏ; // 0x90
        public ONSPAudioSource ÏÌÌÏÏÌÌÏÌÌÍÏÌÏÍÌÎÍÍÏÍÌÏ; // 0x98
        public OVRLipSyncContext ÍÍÎÏÎÌÍÌÌÏÍÍÌÍÌÌÍÎÎÎÏÏÎ; // 0xA0
        public OVRLipSyncContextMorphTarget ÌÍÏÎÌÍÍÏÍÎÌÍÍÎÏÍÎÌÌÏÎÏÏ; // 0xA8
        public ÏÌÏÎÏÏÎÍÎÏÏÎÏÍÍÍÍÍÍÍÌÏÏ ÏÏÎÎÌÎÍÏÎÎÎÏÍÍÍÏÎÎÏÏÌÏÌ; // 0xB0
        public ÌÌÍÎÍÏÏÌÎÏÍÏÌÏÏÏÏÌÎÌÍÍÌ ÍÎÍÍÍÌÌÎÎÎÏÍÍÎÌÏÍÎÌÏÌÎÍ; // 0xB8
        public UnityEngine.AudioClip ÏÎÏÏÍÍÎÏÌÍÌÎÌÏÌÎÌÏÏÌÍÎÍ; // 0xC0
        public ÎÏÎÏÏÏÍÏÏÍÍÌÏÍÏÌÌÍÍÎÍÌÍ ÍÏÏÌÌÏÍÍÏÍÎÌÏÍÏÏÍÌÌÏÎÍÍ; // 0xC8
        public int ÎÌÏÌÌÏÏÎÌÌÎÏÌÌÍÍÎÌÎÎÏÍÏ; // 0xD0
        public bool ÏÎÌÌÌÏÎÍÌÌÎÌÍÏÍÎÍÍÍÌÌÌÌ; // 0xD4
        public ÏÎÎÌÎÏÏÌÎÌÎÎÌÎÌÍÍÍÌÎÌÎÌ ÌÎÏÎÍÏÌÎÌÌÍÏÌÏÌÌÏÌÎÏÎÍÏ; // 0xD8
        public int ÍÍÍÌÌÍÎÍÍÌÌÎÏÏÎÎÌÏÏÎÍÍÏ; // 0xE0
        public int ÍÏÌÏÌÎÍÏÍÎÏÍÌÍÍÏÌÏÍÎÎÍÌ; // 0xE4
        public float ÎÍÍÎÏÌÍÌÏÍÏÍÏÌÌÍÍÏÍÌÌÏÌ; // 0xE8
        public float ÏÍÍÏÌÎÍÍÌÏÌÏÌÌÍÌÍÍÌÎÍÍÏ; // 0xEC
        public System.Collections.Generic.List`1<ÏÏÍÎÌÍÍÎÏÏÏÎÏÎÍÌÌÍÌÍÍÏÏ> ÎÏÎÍÏÎÌÏÍÌÏÍÏÌÏÏÎÍÌÎÎÍÎ; // 0xF0
        public System.Collections.Generic.List`1<ÏÏÍÎÌÍÍÎÏÏÏÎÏÎÍÌÌÍÌÍÍÏÏ> ÎÌÏÌÌÏÌÍÍÌÍÏÍÌÏÏÍÏÏÏÎÏÍ; // 0xF8
        public byte[] ÍÍÏÎÎÎÍÎÌÏÌÏÏÎÏÍÍÍÏÏÍÍÏ; // 0x100
        public int ÍÍÎÏÎÍÍÍÎÏÌÎÏÎÎÏÏÎÍÍÌÎÎ; // 0x108
        public ÎÍÍÏÌÍÎÎÏÎÌÎÍÍÏÏÌÍÏÎÎÌÍ ÍÌÏÍÌÎÏÏÌÏÌÏÍÍÏÏÍÏÏÏÎÎÎ; // 0x110
        public string ÎÍÎÏÌÏÎÎÌÍÌÌÍÎÌÎÍÎÎÍÎÎÍ; // 0x118
        public float ÍÍÎÎÏÌÌÎÍÌÍÎÏÏÌÍÍÍÍÏÍÍÎ; // 0x120
        public float ÍÏÌÍÌÌÍÌÏÎÎÌÏÏÏÎÌÎÏÌÌÍÍ; // 0x124
        public float ÌÌÎÌÍÎÌÌÎÎÌÍÎÎÎÌÏÎÌÍÌÎÎ; // 0x128
        public ÎÌÏÌÍÍÏÎÍÌÎÌÍÌÍÌÎÍÍÏÎÍÍ ÍÏÏÌÌÏÎÍÌÎÌÍÎÏÏÏÌÏÏÎÍÌÏ; // 0x130
        public ÎÌÏÌÍÍÏÎÍÌÎÌÍÌÍÌÎÍÍÏÎÍÍ ÍÌÌÍÎÍÏÌÏÎÏÌÍÏÍÏÍÌÌÍÏÎÌ; // 0x138
        public int ÍÏÍÌÎÍÌÌÎÌÌÌÌÍÌÏÎÍÌÎÎÏÌ; // 0x140
        public int ÌÎÎÎÍÍÍÍÌÏÌÏÍÌÏÎÌÍÎÌÍÌÎ; // 0x144
        public int ÎÌÎÌÎÌÏÌÏÍÌÎÌÌÏÍÌÏÎÍÍÌÍ; // 0x148
        public int ÌÏÏÌÍÏÏÌÏÎÏÏÎÌÎÏÎÌÏÏÏÏÎ; // 0x14C
        public bool ÍÏÌÎÍÌÌÎÎÏÏÏÏÏÏÎÏÏÏÌÎÏÏ; // 0x150
        public int ÌÎÏÍÌÏÌÍÌÍÏÍÌÎÍÏÍÎÎÍÏÎÍ; // 0x154
        public int ÏÌÎÍÌÏÎÌÌÎÏÏÎÍÌÏÎÏÏÏÌÍÏ; // 0x158
        public 0x66348460 ÎÏÍÌÎÌÍÏÍÎÏÎÍÍÍÌÏÏÎÎÎÌÎ; // 0x15C
        public 0x663484B8 ÍÌÏÎÍÎÍÍÌÍÏÍÏÎÌÏÎÎÏÍÏÍÍ; // 0x160
        public 0x66348618 ÎÍÌÍÎÌÌÎÎÏÌÏÍÎÍÎÏÌÎÏÏÌÏ; // 0x164
        public int ÎÍÍÏÎÎÎÎÍÎÎÌÎÎÍÎÏÍÎÎÏÎÎ; // 0x168
        public float ÎÏÌÏÎÎÍÍÎÏÍÌÌÏÍÍÌÍÌÍÏÍÌ; // 0x16C
        public uint ÌÎÏÎÌÌÏÏÎÌÏÏÍÍÌÌÏÎÍÎÎÌÏ; // 0x170
        public float ÍÏÌÍÏÍÎÏÍÍÍÍÌÌÏÌÏÏÌÌÎÍÎ; // 0x174
        public uint ÌÎÍÏÎÍÍÎÍÎÏÏÍÎÎÌÍÏÍÌÏÏÌ; // 0x178
        public float ÎÎÎÍÏÍÍÎÍÎÎÎÍÍÏÌÏÏÌÎÍÏÌ;
        public float ÌÌÌÍÎÍÏÏÏÎÌÎÌÍÎÍÍÏÌÌÏÎÍ; // 0x48
        public int ÍÌÏÌÏÍÍÎÌÎÌÌÌÎÏÏÌÍÌÍÏÏÏ;
        public long ÎÍÌÌÎÌÏÏÌÍÌÏÌÍÌÌÌÍÎÍÌÍÎ;
        public long ÌÍÎÎÎÏÎÍÏÍÍÏÌÏÍÍÍÍÏÍÍÏÍ; // 0x180
        public float[] ÏÎÏÍÏÎÏÍÌÍÎÏÍÏÍÌÎÌÍÌÌÎÍ; // 0x188
        public float ÍÏÎÍÏÌÍÌÏÎÏÍÍÎÏÌÏÌÏÏÏÌÎ; // 0x190
        public float ÌÌÍÎÍÌÌÎÎÌÏÎÍÎÎÎÍÍÎÌÎÎÏ; // 0x194
        public float ÎÎÏÏÍÌÌÎÍÌÌÎÍÍÍÌÎÍÎÌÏÏÌ; // 0x198
        public System.Nullable`1<int> ÍÎÏÌÏÌÍÍÎÎÌÌÍÎÎÍÌÍÎÎÎÎÍ; // 0x4C
        public int ÎÍÌÌÎÌÌÌÏÎÍÌÍÍÎÏÍÏÎÍÍÍÍ; // 0x19C
        public float ÍÏÏÏÏÏÍÎÌÌÍÏÎÎÌÎÏÎÎÍÍÎÏ; // 0x1A0
        public float ÎÏÏÍÌÎÏÏÎÌÏÎÍÌÏÌÏÎÌÎÏÎÍ; // 0x1A4
        public float ÏÌÍÎÌÏÍÍÍÍÎÏÌÍÌÎÍÌÍÍÌÎÎ; // 0x1A8
        public double ÍÏÏÎÏÎÍÍÍÏÎÌÏÎÏÍÍÏÌÏÎÏÌ; // 0x1B0
        public float ÏÍÏÌÏÎÏÏÍÎÌÍÌÌÏÎÏÎÎÏÍÌÍ;
        public float ÌÎÎÌÌÎÌÍÎÍÍÌÍÍÎÍÌÎÏÎÎÎÌ;
        public float ÌÌÌÌÍÍÌÎÎÏÍÌÎÍÎÌÍÌÌÍÎÌÍ; // 0x1B8
        public float ÌÏÍÌÍÎÏÏÌÌÍÎÏÌÎÍÎÎÌÍÍÏÌ; // 0x1BC
        public float ÏÍÎÏÏÌÎÍÏÎÎÏÍÎÏÌÎÍÎÎÌÌÏ; // 0x1C0
        public 0x66348670 ÌÏÏÌÏÌÎÌÎÌÍÏÍÌÎÍÌÌÌÍÎÍÏ; // 0x1C4
        public int ÌÌÎÍÏÍÎÎÏÎÌÍÍÏÎÎÎÍÎÎÌÍÎ; // 0x1C8
        public ÎÎÌÏÏÏÎÌÏÌÌÏÍÍÏÌÌÍÏÎÍÏÍ ÎÏÌÍÍÎÍÍÎÌÌÌÌÎÎÎÎÍÎÎÌÍÌ; // 0x1D0
        public float ÍÎÎÎÌÌÎÍÌÍÎÍÍÎÎÌÌÎÌÌÍÏÎ; // 0x1D8
        public int ÍÏÏÏÌÎÍÏÌÎÍÏÌÎÍÎÍÏÍÎÍÎÌ; // 0x1DC
        public Photon.Client.SendOptions ÌÏÏÏÎÏÏÎÏÎÎÌÎÎÍÍÍÍÌÎÏÎÍ; // 0x54
        public int ÌÏÎÎÍÏÌÏÌÏÏÏÍÌÌÎÏÎÎÍÍÎÏ;
        public ÎÎÏÏÍÏÌÍÍÎÎÍÌÍÌÏÎÍÏÏÏÎÌ[] ÏÎÌÏÌÌÎÎÎÎÏÎÏÎÏÍÌÍÍÏÎÎÍ; // 0x1E0
        public int ÏÏÎÍÌÎÌÌÌÍÏÎÏÏÏÍÎÌÏÏÌÏÎ; // 0x1E8
        public int ÌÌÍÍÏÍÌÌÌÎÏÏÍÌÏÎÍÏÌÎÍÍÍ;
        public VRC.Profiling.ProfilerMarker ÎÎÌÎÌÏÌÌÌÎÍÎÍÍÏÍÍÎÌÌÌÌÏ; // 0x60
        public VRC.Profiling.ProfilerMarker ÍÍÎÏÏÍÏÎÍÌÎÎÌÏÎÍÏÏÌÌÎÎÏ; // 0x70
        public VRC.Profiling.ProfilerMarker ÏÎÏÍÎÎÍÎÍÎÏÏÌÎÎÏÎÍÏÍÌÌÍ; // 0x80
        public VRC.Profiling.ProfilerMarker ÎÍÌÏÌÍÌÌÎÌÏÎÍÌÍÎÏÎÍÍÌÏÏ; // 0x90
        public VRC.Profiling.ProfilerMarker ÍÏÏÎÍÌÎÏÎÎÏÎÌÎÌÍÌÏÎÌÏÍÎ; // 0xA0
        public VRC.Profiling.ProfilerMarker ÎÎÏÎÎÏÏÎÎÍÍÏÍÍÏÏÌÏÌÏÏÏÌ; // 0xB0
        public int ÎÎÏÍÎÎÍÌÎÌÍÌÏÎÌÌÍÌÏÌÎÍÎ; // 0x1EC
        public int ÎÍÍÏÎÎÌÌÌÎÎÌÌÏÏÌÍÎÍÌÏÏÌ; // 0x1F0
        public VRC.Profiling.ProfilerMarker ÌÏÌÍÍÌÏÏÍÎÎÌÎÏÍÏÍÏÍÌÎÍÌ; // 0xC0
        public VRC.Profiling.ProfilerMarker ÌÍÏÌÌÍÏÎÎÍÌÏÏÏÌÎÎÎÏÌÏÍÍ; // 0xD0
        public VRC.Profiling.ProfilerMarker ÌÍÌÎÌÎÍÏÌÌÏÏÎÍÍÍÌÌÍÍÌÏÎ; // 0xE0
        public VRC.Profiling.ProfilerMarker ÎÌÏÌÎÍÎÌÎÎÎÌÌÎÌÎÏÎÍÏÌÏÌ; // 0xF0
        public VRC.Profiling.ProfilerMarker ÎÌÌÎÎÌÎÎÍÏÎÍÍÎÏÌÌÌÌÏÌÏÍ; // 0x100
        public VRC.Profiling.ProfilerMarker ÍÍÎÍÌÎÍÍÌÎÎÍÎÌÏÌÎÌÏÌÎÏÍ; // 0x110
        public VRC.Profiling.ProfilerMarker ÏÌÌÌÏÍÏÍÏÎÏÍÏÌÍÌÎÎÏÌÍÎÎ; // 0x120
        public VRC.Profiling.ProfilerMarker ÌÌÎÌÎÍÍÍÌÏÎÌÌÎÌÍÍÌÍÌÍÌÌ; // 0x130
        public VRC.Profiling.ProfilerMarker ÏÎÌÍÍÎÎÎÎÍÎÎÍÌÌÍÍÎÏÌÌÍÌ; // 0x140
        public VRC.Profiling.ProfilerMarker ÎÎÍÌÍÌÏÏÎÍÌÏÏÎÎÌÌÌÎÎÎÎÏ; // 0x150
        public VRC.Profiling.ProfilerMarker ÍÌÍÏÌÌÎÏÍÎÎÎÎÎÍÍÎÎÌÍÏÏÍ; // 0x160
        public VRC.Profiling.ProfilerMarker ÌÏÎÎÏÌÍÏÍÌÍÎÌÎÌÎÏÏÏÎÏÌÌ; // 0x170
        public VRC.Profiling.ProfilerMarker ÍÎÎÍÌÌÎÎÍÎÌÍÏÎÏÎÍÌÎÏÍÌÏ; // 0x180
        public VRC.Profiling.ProfilerMarker ÎÍÌÍÏÎÍÎÎÏÍÍÏÌÌÎÎÍÏÍÌÎÍ; // 0x190
        public System.Nullable`1<float> ÏÎÍÎÎÍÎÌÍÌÏÌÍÍÏÎÌÌÌÌÏÍÌ; // 0x1F4
        public float ÍÎÏÌÌÎÍÌÎÌÎÎÌÏÍÍÏÏÍÎÏÌÎ;
        public float ÌÌÏÍÌÍÏÍÏÏÍÌÎÎÎÌÍÍÏÌÏÌÍ; // 0x1FC
        public int ÌÌÍÎÌÌÏÌÍÏÏÌÏÎÌÏÎÍÏÌÎÍÍ; // 0x200
        public int ÌÏÏÍÍÌÍÌÌÎÎÍÎÌÎÌÎÍÎÍÎÏÏ; // 0x204
        public int ÍÏÏÏÍÏÍÍÎÎÏÎÌÍÍÌÏÎÏÌÌÌÎ; // 0x208
        public int ÍÍÌÌÍÎÍÏÏÌÌÍÎÎÍÎÏÏÎÌÎÎÌ; // 0x20C
        public int ÎÌÍÌÏÌÌÍÏÌÏÎÎÍÍÏÎÌÌÏÌÏÌ; // 0x210
        public bool ÎÎÌÍÍÎÌÍÌÏÍÎÍÍÌÍÏÎÏÌÍÌÎ; // 0x1A0
        public float ÍÎÎÎÌÏÎÏÌÌÍÏÏÌÍÏÏÌÏÍÏÎÌ;
        public float ÌÌÎÍÎÏÌÌÍÌÎÎÌÍÍÎÌÏÏÌÍÌÎ; // 0x214
        public float ÍÌÏÏÎÎÍÍÎÏÏÏÌÏÍÎÎÎÍÌÎÌÎ; // 0x218
        public VRC.Profiling.ProfilerMarker ÍÏÍÍÏÍÏÌÍÏÌÎÌÌÏÎÎÍÎÌÍÍÌ; // 0x1A8
        public VRC.Profiling.ProfilerMarker ÌÎÍÏÍÎÎÍÍÍÏÏÎÎÎÏÏÎÌÍÏÍÏ; // 0x1B8
        public bool ÎÎÎÎÎÏÍÍÎÎÎÍÏÍÏÏÌÎÏÍÎÍÎ; // 0x1C8
        public System.Threading.CancellationTokenSource ÏÏÍÍÍÌÏÍÌÌÏÌÍÌÏÏÌÌÏÍÏÌÌ; // 0x220
        public Unity.Profiling.ProfilerMarker ÎÍÏÌÏÌÏÏÏÏÎÌÎÏÏÏÎÎÌÌÍÎÎ; // 0x228
        public Cysharp.Threading.Tasks.Channel`1<float[]> ÏÍÍÎÌÍÏÌÍÏÍÌÌÎÍÎÍÌÎÌÏÏÌ; // 0x230
        public Cysharp.Threading.Tasks.Channel`1<ÏÎÎÏÏÎÍÏÌÎÎÎÍÍÎÏÌÍÌÏÎÏÍ> ÏÎÎÎÌÎÌÏÌÎÎÏÏÍÌÍÌÍÍÎÏÍÎ; // 0x238
        public Cysharp.Threading.Tasks.Channel`1<ÏÎÎÏÏÎÍÏÌÎÎÎÍÍÎÏÌÍÌÏÎÏÍ> ÎÎÎÌÍÍÌÏÏÎÏÌÍÍÍÎÌÍÎÎÍÏÌ; // 0x240
        public Unity.Profiling.ProfilerMarker ÌÏÍÎÎÏÌÍÎÎÏÎÎÍÌÌÏÌÎÌÎÌÎ; // 0x248
        public Unity.Profiling.ProfilerMarker ÎÏÌÌÏÎÌÍÍÍÎÌÌÌÎÌÌÎÌÏÏÏÏ; // 0x250
        public Unity.Profiling.ProfilerMarker ÌÌÎÎÏÌÍÏÌÌÌÍÍÌÌÍÏÌÌÎÎÎÍ; // 0x258
        public Cysharp.Threading.Tasks.Channel`1<ÍÌÍÌÏÍÍÏÏÌÍÏÎÏÎÏÌÎÌÏÌÌÌ> ÏÎÎÌÎÍÌÍÏÍÌÏÏÏÌÎÎÍÎÌÏÏÏ; // 0x260
        public Cysharp.Threading.Tasks.Channel`1<ÍÌÍÌÏÍÍÏÏÌÍÏÎÏÎÏÌÎÌÏÌÌÌ> ÍÍÏÎÎÌÍÏÍÌÍÌÎÍÏÌÍÎÌÏÍÌÎ; // 0x268
        public Unity.Profiling.ProfilerMarker ÍÎÎÍÌÎÏÍÌÎÍÌÌÏÌÎÍÎÎÍÎÎÍ; // 0x270
        public Unity.Profiling.ProfilerMarker ÏÌÏÍÍÎÍÎÍÎÎÍÎÍÍÍÍÏÍÍÏÌÌ; // 0x278

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E4FD010
        public void RaiseCancellation(){} // RVA: 0x7FFD4E4FD1E0
        public void LateUpdate(){} // RVA: 0x7FFD4E4FD490
        public void CancelInvoke(){} // RVA: 0x7FFD4E4FD4C0
        public void Invoke(){} // RVA: 0x7FFD4E4FD7A0
        public void InvokeRepeating(){} // RVA: 0x7FFD4E4FDB30
        public void OnApplicationQuit(){} // RVA: 0x7FFD4E4FDC80
        public void IsInvoking(){} // RVA: 0x7FFD4E4FDEB0
        public void StartCoroutine(){} // RVA: 0x7FFD4E4FE060
        public void OnDestroy(){} // RVA: 0x7FFD4E4FE150
        public void OnCollisionStay(){} // RVA: 0x7FFD4E4FE9C0
        public void SetModelShader(){} // RVA: 0x7FFD4E3BC740
        public void StopCoroutine(){} // RVA: 0x7FFD4E4FEF80
        public void OnTriggerStay(){} // RVA: 0x7FFD4E4FF040
        public void OnTriggerExit(){} // RVA: 0x7FFD4E4FF630
        public void StopAllCoroutines(){} // RVA: 0x7FFD4E4FF6A0
        public void get_useGUILayout(){} // RVA: 0x7FFD4E4FF7D0
        public void set_useGUILayout(){} // RVA: 0x7FFD4E4FF8E0
        public void print(){} // RVA: 0x7FFD4E4FF8F0
        public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E500750
        public void InvokeDelayed(){} // RVA: 0x7FFD4E5009D0
        public void set_contentList(){} // RVA: 0x7FFD4E500A40
        public void IsInvoking_FE04B31E30C4(){} // RVA: 0x7FFD4E500B40
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4E500C30
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4E500DF0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4E500F50
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E5010A0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4E501110
        public void GetScriptClassName(){} // RVA: 0x7FFD4E5012D0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4E501720
        public void GetGameObject_02C(){} // RVA: 0x7FFD4E5017A0
        public void GetTextTracks(){} // RVA: 0x7FFD4E5019B0
        public void WriteVector3(){} // RVA: 0x7FFD4E502590
        public void GetGameObject_02C_F76404898C54(){} // RVA: 0x7FFD4E502990
        public void set_worldTag(){} // RVA: 0x7FFD4E502C60
        public void LoadImageUrl(){} // RVA: 0x7FFD4E502D10
        public void .ctor(){} // RVA: 0x7FFD4E502F00
        public void Initialize(){} // RVA: 0x7FFD4E5035D0
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void GetBytePair(){} // RVA: 0x7FFD4E503630
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E503640
        public void GetVideoTracks(){} // RVA: 0x7FFD4E503810
        public void GetVideoTracks_6B3F74EE3F4A(){} // RVA: 0x7FFD4E503980
        public void ResetPendingState(){} // RVA: 0x7FFD4E504C80
        public void GetUInt16Value(){} // RVA: 0x7FFD4E504CD0
        public void CreateRangeValue(){} // RVA: 0x7FFD4E505390
        public void Callback(){} // RVA: 0x7FFD4E5054B0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void Computealpha(){} // RVA: 0x7FFD4E505610
        public void CheckGameObjectActive(){} // RVA: 0x7FFD4E5057B0
        public void GetGameObject_106(){} // RVA: 0x7FFD4E5058F0
        public void StringToHash(){} // RVA: 0x7FFD4E505A50
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFD4E505AB0
        public void set_MaterialForRenderingInternal(){} // RVA: 0x7FFD4E505B20
        public void ApplyRigidbodyVelocity(){} // RVA: 0x7FFD4E505FD0
        public void OnEnable(){} // RVA: 0x7FFD4E506030
        public void Start(){} // RVA: 0x7FFD4E506090
        public void FixedUpdate(){} // RVA: 0x7FFD4E506130
        public void set_iconImageUrl(){} // RVA: 0x7FFD4E506190
        public void UpdateTextTracks(){} // RVA: 0x7FFD4E5061A0
        public void OnDisable(){} // RVA: 0x7FFD4E5061F0
        public void GetHashCode(){} // RVA: 0x7FFD4E506AB0
        public void OnApplicationPause(){} // RVA: 0x7FFD4E506E80
        public void RefreshContentList(){} // RVA: 0x7FFD4E506F40
        public void OnBecameVisible(){} // RVA: 0x7FFD4E507030
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E507040
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E5073A0
        public void SetByteValue(){} // RVA: 0x7FFD4E5074A0
        public void OnCollisionExit(){} // RVA: 0x7FFD4E507660
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E507910
        public void OnTriggerEnter_9B86FA487188(){} // RVA: 0x7FFD4E507990
        public void GetInstanceID(){} // RVA: 0x7FFD4E507BA0
        public void ApplyModelShader(){} // RVA: 0x7FFD4E507F50
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4E5080B0
        public void EndsWithCultureHelper(){} // RVA: 0x7FFD4E5080C0
        public void HandleTriggerStay(){} // RVA: 0x7FFD4E5083E0
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7FFD4E5084D0
        public void VerifyMutable(){} // RVA: 0x7FFD4E5086F0
        public void VerifyMutable_B5FC92693373(){} // RVA: 0x7FFD4E508830
        public void CopyBufferedValue(){} // RVA: 0x7FFD4E508930
        public void OnBecameVisible_66BF254947EB(){} // RVA: 0x7FFD4E507030
        public void InitializeMedia(){} // RVA: 0x7FFD4E508A20
        public void FetchContent(){} // RVA: 0x7FFD4E508BE0
        public void Update(){} // RVA: 0x7FFD4E509050
        public void SetVectorValue(){} // RVA: 0x7FFD4E509330
        public void op_Implicit(){} // RVA: 0x7FFD4E5097D0
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void StartCoroutine_99F1F6A73BD6(){} // RVA: 0x7FFD4E5099D0
        public void set_preferredWidth(){} // RVA: 0x7FFD4E509A30
        public void ProcessTracks(){} // RVA: 0x7FFD4E509E00
        public void Awake(){} // RVA: 0x7FFD4E50A080
        public void VerifyMutable_B5F62FD88E08(){} // RVA: 0x7FFD4E50A950
        public void SetReferencedObject(){} // RVA: 0x7FFD4E50AB10
        public void DoTransformDirecti(){} // RVA: 0x7FFD4E50AD00
        public void Initialize_2C1CEFAA639D(){} // RVA: 0x7FFD4E50AD60
        public void UpdateUIState(){} // RVA: 0x7FFD4E50AD70
        public void get_copyMaterial(){} // RVA: 0x7FFD4E50B2F0
        public void EnsureType5Wrapper(){} // RVA: 0x7FFD4E50B750
        public void AttachChildNode(){} // RVA: 0x7FFD4E50B840
        public void set_name(){} // RVA: 0x7FFD4E50B8A0
        public void .cctor(){} // RVA: 0x7FFD4E50BDF0
        public void SetupShader(){} // RVA: 0x7FFD4E50D4B0
        public void SetInt32Value(){} // RVA: 0x7FFD4E50D5A0
        public void CacheImageUrl(){} // RVA: 0x7FFD4E50D600
        public void GetGameObject_C8F(){} // RVA: 0x7FFD4E50D860
        public void StartCoroutine_BF30F23CE1D7(){} // RVA: 0x7FFD4E50D9C0
        public void CreateType4ENode(){} // RVA: 0x7FFD4E50DAD0
        public void CreateChildNode(){} // RVA: 0x7FFD4E50DF80
        public void ValidateStateAndCall(){} // RVA: 0x7FFD4E50E8B0
        public void RenderContent(){} // RVA: 0x7FFD4E50E930
        public void set_Method(){} // RVA: 0x7FFD4E50E990
        public void ClearTextTracks(){} // RVA: 0x7FFD4E50EE50
        public void UpdateColorImpl_Inje(){} // RVA: 0x7FFD4E50EF40
        public void get_DurationType(){} // RVA: 0x7FFD4E50F4E0
        public void TryGetInt32Value(){} // RVA: 0x7FFD4E50F4F0
        public void DoTransformDirecti_930F8F3EE47F(){} // RVA: 0x7FFD4E50F640
        public void StopCoroutine_40A5A9520ED3(){} // RVA: 0x7FFD4E50F6E0
        public void ConfiguresortingOrder(){} // RVA: 0x7FFD4E50F740
        public void CreateType90Node(){} // RVA: 0x7FFD4E50F8D0
        public void UpdateColorImpl_Inje_95B4E65902C4(){} // RVA: 0x7FFD4E50FD80
        public void StopMediaPlayback(){} // RVA: 0x7FFD4E50FD90
        public void UpdateState(){} // RVA: 0x7FFD4E50FE50
        public void PlayMedia(){} // RVA: 0x7FFD4E5100D0
        public void PauseMedia(){} // RVA: 0x7FFD4E5100F0
        public void get_BindingFlags(){} // RVA: 0x7FFD4E5108A0
        public void GetDeltaTime_79A(){} // RVA: 0x7FFD4E510C10
        public void ValidateContent(){} // RVA: 0x7FFD4E510C80
    }

    /// <summary>Originally: ÍÎÍÌÏÏÌÌÌÍÌÍÏÎÍÌÎÍÍÌÍÌÎ</summary>
    public class ComplexComponent_7679 : MonoBehaviour
    {
        public ÍÎÍÌÏÏÌÌÌÍÌÍÏÎÍÌÎÍÍÌÍÌÎ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ;
        public bool ÏÏÏÌÍÍÌÏÍÍÍÌÏÍÏÎÎÏÎÏÎÎÏ; // 0x8
        public System.Collections.Generic.Queue`1<ÍÏÏÎÍÍÏÌÎÍÏÌÏÎÎÎÎÍÌÌÎÍÌ> ÎÍÌÌÍÏÏÎÎÎÏÏÏÍÍÍÍÌÌÎÌÍÌ; // 0x20
        public System.Collections.Generic.Queue`1<ÍÏÏÎÍÍÏÌÎÍÏÌÏÎÎÎÎÍÌÌÎÍÌ> ÌÍÍÌÎÍÏÌÎÍÍÍÏÏÏÏÎÌÌÏÏÍÎ; // 0x28
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÌÏÏÎÏÏÌÎÍÍÌÍÌÎÎÍÎÌÍÏÍ; // 0x10
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÌÍÏÌÌÏÏÌÍÏÍÎÎÎÏÎÏÏÏÏÎÌ; // 0x18
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÍÎÌÍÌÏÍÏÍÌÌÏÍÎÏÍÌÌÎÏÍÍ; // 0x20
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÍÏÌÌÏÏÌÌÍÌÍÏÌÌÏÌÏÍÌÏÌÍ; // 0x28
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÎÎÍÌÎÏÌÏÏÎÎÎÏÍÍÏÍÎÌÌÎÌÎ; // 0x30
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÎÏÏÌÏÎÎÍÎÍÌÍÏÎÎÍÌÍÏÍÏÏÏ; // 0x38
        public System.Collections.Generic.Dictionary`2<string,object> ÏÌÎÏÍÍÍÌÎÍÌÎÏÍÍÏÌÏÌÌÏÌÎ; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4F638FA0
        public void RaiseCancellation(){} // RVA: 0x7FFD4F63D800
        public void IsInvoking(){} // RVA: 0x7FFD4F63DAF0
        public void CancelInvoke(){} // RVA: 0x7FFD4F63DC00
        public void Invoke(){} // RVA: 0x7FFD4F63DD50
        public void InvokeRepeating(){} // RVA: 0x7FFD4F63DE10
        public void OnDisable(){} // RVA: 0x7FFD4F63DFF0
        public void IsInvoking_6D0F179363BA(){} // RVA: 0x7FFD4F63E9B0
        public void StartCoroutine(){} // RVA: 0x7FFD4F63EAA0
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F63EB00
        public void OnBecameVisible(){} // RVA: 0x7FFD4F63ED10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F63F070
        public void StopCoroutine(){} // RVA: 0x7FFD4F63F0C0
        public void OnCollisionStay(){} // RVA: 0x7FFD4F63F190
        public void GetGameObjectReference3(){} // RVA: 0x7FFD4F63F5F0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F63F870
        public void get_useGUILayout(){} // RVA: 0x7FFD4F63F920
        public void set_useGUILayout(){} // RVA: 0x7FFD4F63FAA0
        public void print(){} // RVA: 0x7FFD4F6403F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F640480
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F6406B0
        public void InvokeDelayed(){} // RVA: 0x7FFD4F640780
        public void GetComponentTransform(){} // RVA: 0x7FFD4F640AD0
        public void GetComponentTransform_178FB10C4E8A(){} // RVA: 0x7FFD4F640B60
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F640CE0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F640E00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F640F10
        public void Update(){} // RVA: 0x7FFD4F641060
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4F641070
        public void GetScriptClassName(){} // RVA: 0x7FFD4F6410E0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F641310
        public void OnApplicationPause(){} // RVA: 0x7FFD4F6413B0
        public void SetGameObjectActive4(){} // RVA: 0x7FFD4F641B70
        public void OnTriggerExit(){} // RVA: 0x7FFD4F641C50
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F641D70
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F641EB0
        public void ValidateGameObjectComponents(){} // RVA: 0x7FFD4F641F80
        public void OnCollisionExit(){} // RVA: 0x7FFD4F642150
        public void Start(){} // RVA: 0x7FFD4F642450
        public void OnTriggerStay(){} // RVA: 0x7FFD4F642810
        public void GetUnityEngine(){} // RVA: 0x7FFD4F642920
        public void LateUpdate(){} // RVA: 0x7FFD4F642AE0
        public void SetGameObjectActive(){} // RVA: 0x7FFD4F642D40
        public void OnTriggerStay_E37D71D9E03D(){} // RVA: 0x7FFD4F643020
        public void OnTriggerExit_57BA265D72B9(){} // RVA: 0x7FFD4F643070
        public void OnApplicationQuit_8ECA04774C99(){} // RVA: 0x7FFD4F6433C0
        public void OnBecameVisible_4830D6DD2BA0(){} // RVA: 0x7FFD4F6436C0
        public void OnBecameInvisible_4BEDA6651412(){} // RVA: 0x7FFD4F646CD0
        public void ExecuteCoroutine(){} // RVA: 0x7FFD4F646DE0
        public void Initialize(){} // RVA: 0x7FFD4F646E70
        public void OnCollisionExit_B3C4F058F9D6(){} // RVA: 0x7FFD4F647060
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E341310
        public void OnTriggerStay_D87309BF7556(){} // RVA: 0x7FFD4F6470E0
        public void OnTriggerExit_FC87FD55BFDE(){} // RVA: 0x7FFD4F647260
        public void CancelCoroutine(){} // RVA: 0x7FFD4F6473F0
        public void ManageCoroutines(){} // RVA: 0x7FFD4F647440
        public void SetGameObjectActive_EF27A2829688(){} // RVA: 0x7FFD4F647530
        public void LateUpdate_2CFF667DA0DD(){} // RVA: 0x7FFD4F6475C0
        public void DoStop(){} // RVA: 0x7FFD4F647640
        public void ComputeisActiveAndE(){} // RVA: 0x7FFD4F647730
        public void GetMaxDampTime(){} // RVA: 0x7FFD4F647830
        public void EnsureSecondaryController(){} // RVA: 0x7FFD4F647930
        public void SetActiveState(){} // RVA: 0x7FFD4F647A30
        public void SetReversedPlaybackFlag(){} // RVA: 0x7FFD4F647B00
        public void get_callbacksOnDisable(){} // RVA: 0x7FFD4F647C10
        public void OnEnable(){} // RVA: 0x7FFD4F647E00
        public void FixedUpdate(){} // RVA: 0x7FFD4F648010
        public void CaptureTransformState(){} // RVA: 0x7FFD4F648020
        public void SetStateAndRefresh(){} // RVA: 0x7FFD4F6481D0
        public void GetTransformData(){} // RVA: 0x7FFD4F648310
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F648390
        public void OnDestroy(){} // RVA: 0x7FFD4F648630
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFD4F6486E0
        public void ProcessUiVisibilityLogic_FBAF1D611544(){} // RVA: 0x7FFD4F648750
        public void ProcessUiVisibilityLogic_F0FBBAC8F783(){} // RVA: 0x7FFD4F648860
        public void ProcessComponentFieldAndCheck(){} // RVA: 0x7FFD4F6488F0
        public void .ctor(){} // RVA: 0x7FFD4F648990
        public void GetGameObjectReference(){} // RVA: 0x7FFD4F648B90
        public void CompareUnityObjects(){} // RVA: 0x7FFD4F648D40
        public void GetGameObjectReference2(){} // RVA: 0x7FFD4F649440
        public void SetGameObjectActive_A903651662B8(){} // RVA: 0x7FFD4F6494D0
        public void SetReferenceObject(){} // RVA: 0x7FFD4F649560
        public void SetTargetEnabled(){} // RVA: 0x7FFD4F649ED0
        public void EnsureControllerInstance(){} // RVA: 0x7FFD4F649FE0
        public void OnBecameInvisible_0838F1452353(){} // RVA: 0x7FFD4F64A170
        public void GetGameObjectReference3_2688FDB7DA62(){} // RVA: 0x7FFD4F64A520
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F64A7B0
        public void SetGameObjectActive2(){} // RVA: 0x7FFD4F64A890
        public void ComputeunscaledDeltaTime(){} // RVA: 0x7FFD4F64A9A0
        public void SetGameObjectActive3(){} // RVA: 0x7FFD4F64AE80
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void SetGameObjectActive_E327BCD82A68(){} // RVA: 0x7FFD4F64AF20
        public void TryToString(){} // RVA: 0x7FFD4F64B100
        public void ApplyAnimatedProperties(){} // RVA: 0x7FFD4F64B9F0
        public void StartMultipartUpload(){} // RVA: 0x7FFD4F64BB90
        public void Initialize_07883ADE0702(){} // RVA: 0x7FFD4F64BC20
        public void InvokeNextFrame(){} // RVA: 0x7FFD4F64BCF0
        public void GetGameObjectReference4(){} // RVA: 0x7FFD4F64C710
        public void ApplyAnimatedPropertiesDisabled(){} // RVA: 0x7FFD4F64CB00
        public void GetCachedPtr(){} // RVA: 0x7FFD4F64CC00
        public void SetConnectedBody2(){} // RVA: 0x7FFD4E341310
        public void ApplyAnimatedProperties_0CBBEC32BC4C(){} // RVA: 0x7FFD4F64CCD0
        public void SetGameObjectActive2_893275FF43AB(){} // RVA: 0x7FFD4F64CE70
        public void CompareUnityObjects_9082B84643F9(){} // RVA: 0x7FFD4F64D1D0
        public void RaiseCancellation_C94541B812E8(){} // RVA: 0x7FFD4F64D700
        public void InitializeFromTemplate(){} // RVA: 0x7FFD4F64D8F0
        public void SetGameObjectActive6(){} // RVA: 0x7FFD4F64D9F0
        public void CreateAndAttachHelper(){} // RVA: 0x7FFD4F64DAA0
        public void IsInvokingDelayed(){} // RVA: 0x7FFD4F64DD00
        public void GetGameObjectReference5(){} // RVA: 0x7FFD4F64DE40
        public void SetGameObjectActive4_63A116023F77(){} // RVA: 0x7FFD4F64DEC0
        public void ValidateBounds(){} // RVA: 0x7FFD4F64DFF0
        public void CancelInvokeDelayed(){} // RVA: 0x7FFD4F64E080
        public void Updateenabled(){} // RVA: 0x7FFD4F64E110
        public void Initialize_790475645265(){} // RVA: 0x7FFD4F6523E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F652550
        public void ApplyAnimatedProperties_EFCE4E741BDF(){} // RVA: 0x7FFD4F652920
        public void ProcessAsynchronousBehavior(){} // RVA: 0x7FFD4F652AC0
        public void GetBehaviourName(){} // RVA: 0x7FFD4F652DD0
        public void StartCoroutineDelayed(){} // RVA: 0x7FFD4F652ED0
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetGameObjectActive2_A84FE06414C0(){} // RVA: 0x7FFD4F652FE0
    }

    /// <summary>Originally: ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ</summary>
    public class ComplexComponent_8C61 : MonoBehaviour
    {
        public string _destroyCancellationToken;
        public ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ _useGUILayout;
        public ÎÏÏÌÎÏÎÏÍÌÏÍÏÏÌÎÍÍÌÍÍÏÌ f_88A; // 0x20
        public ÌÎÌÎÎÏÍÌÌÍÎÎÎÎÏÍÌÏÎÍÌÏÍ f_D1D; // 0x28
        public bool f_388; // 0x30
        public VRC.Localization.LocalizableString f_CCA; // 0x38
        public VRC.Localization.LocalizableString f_350; // 0x60
        public int f_396; // 0x88
        public System.Action f_ECE; // 0x90
        public System.Action f_72F; // 0x98
        public System.Action f_FD3; // 0xA0
        public System.Action f_C43; // 0x8
        public ÎÏÎÏÏÏÌÎÏÌÌÏÍÏÌÏÌÌÌÌÍÌÍ f_147; // 0x10
        public UnityEngine.GameObject f_518; // 0xA8
        public float f_F8E; // 0xB0
        public UnityEngine.GameObject f_8AF; // 0xB8
        public 0x66357978 f_564; // 0xC0
        public bool f_BD9; // 0xC4
        public bool f_292; // 0xC5
        public float ÎÎÌÎÍÍÏÍÌÎÎÌÌÏÍÌÏÌÍÏÏÍÍ;
        public bool ÏÏÌÏÍÎÌÎÌÌÏÏÌÌÌÎÌÎÏÌÍÏÎ; // 0xC6
        public bool ÍÎÍÍÍÍÌÌÌÌÌÍÌÌÌÍÎÏÌÏÏÍÍ; // 0xC7
        public bool <ÍÏÌÎÏÎÌÎÎÏÍÎÎÏÎÎÍÏÎÍÎÏÏ>k__BackingField; // 0xC8
        public bool <ÏÎÌÌÌÍÎÎÌÎÌÌÏÍÎÍÏÏÏÏÍÍÏ>k__BackingField; // 0xC9
        public System.Collections.Generic.Dictionary`2<string,System.Action> ÍÍÎÍÎÌÌÍÏÌÎÍÍÍÌÏÏÏÌÍÌÍÍ; // 0xD0
        public System.Collections.Generic.Dictionary`2<string,object> ÍÌÍÍÍÍÏÎÏÎÌÏÏÎÍÏÍÏÎÏÏÏÍ; // 0xD8
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> ÎÎÌÍÏÏÎÏÏÏÎÎÌÍÌÏÏÎÍÌÏÌÌ; // 0xE0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> <ÎÍÎÎÍÏÏÏÎÎÏÍÏÌÏÏÍÎÌÌÌÏÌ>k__BackingField; // 0xE8
        public System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTask> <ÏÎÍÌÏÏÏÎÎÍÍÎÌÍÌÎÍÍÍÌÍÎÎ>k__BackingField; // 0xF0
        public bool ÍÏÍÎÌÎÍÎÎÌÏÏÌÎÎÎÎÌÌÎÌÎÏ; // 0xF8
        public bool ÍÍÍÍÎÏÏÎÏÍÎÍÌÏÍÍÎÏÌÍÏÍÎ; // 0xF9
        public bool ÏÎÎÌÏÎÌÎÏÎÏÏÏÍÍÏÌÌÎÎÏÏÍ; // 0xFA
        public VRC.Profiling.ProfilerMarker ÎÏÌÍÏÌÎÏÌÌÎÏÍÏÏÏÏÏÎÍÎÎÌ; // 0x100
        public VRC.Profiling.ProfilerMarker ÏÏÏÍÍÎÍÌÎÏÌÎÎÍÏÍÎÌÌÌÎÌÍ; // 0x110
        public System.Threading.CancellationTokenSource ÎÎÎÍÎÌÏÎÌÍÎÍÌÌÍÌÍÏÍÍÎÏÎ; // 0x120
        public float[] ÌÏÌÌÍÎÏÏÎÏÍÎÌÍÏÌÏÌÏÏÎÌÏ; // 0x18
        public System.Collections.Generic.Dictionary`2<string,VRC.Localization.LocalizableString> ÍÌÍÏÎÍÎÌÎÌÏÌÌÏÌÌÍÌÏÏÏÌÏ; // 0x128
        public VRC.Core.ApiWorldInstance <ÎÌÌÌÌÏÏÍÌÍÍÌÎÌÏÏÌÍÏÌÍÎÎ>k__BackingField; // 0x130
        public string <ÌÍÎÍÍÍÏÏÎÏÏÎÎÍÏÎÍÎÏÌÏÌÏ>k__BackingField; // 0x138
        public string ÍÎÌÍÏÏÏÏÏÌÎÎÏÏÎÌÍÏÌÌÏÍÌ; // 0x140
        public int ÎÌÍÍÎÍÏÌÍÍÍÍÏÌÏÏÏÎÎÍÏÎÍ;
        public int ÏÏÌÏÌÌÎÏÌÌÍÏÎÌÎÏÌÍÌÌÌÏÏ; // 0x148
        public bool ÌÌÍÎÍÍÌÏÏÌÎÍÏÌÎÎÌÏÎÍÍÎÏ; // 0x14C
        public 0x664C7938 ÎÍÍÏÍÌÎÎÏÍÎÎÌÏÍÌÎÌÎÎÎÍÏ; // 0x150
        public bool ÍÎÌÌÎÏÎÍÎÏÌÌÎÎÌÌÏÌÌÎÎÏÎ; // 0x158
        public bool <ÎÍÍÎÌÌÍÏÍÎÏÎÍÍÏÏÌÎÎÍÍÏÍ>k__BackingField; // 0x159
        public string ÍÏÏÍÏÏÌÌÏÌÏÍÌÎÌÏÏÏÍÍÍÍÏ; // 0x160
        public bool ÎÎÎÏÎÏÌÍÌÎÏÌÏÍÌÍÍÏÎÎÏÍÍ; // 0x168
        public System.Action`1<VRC.Core.ApiWorldInstance> ÍÍÌÏÎÏÍÌÍÍÏÏÎÍÎÏÌÍÏÌÏÏÍ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F1431F0
        public void RaiseCancellation(){} // RVA: 0x7FFD4F143260
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFD4F1433D0
        public void Awake(){} // RVA: 0x7FFD4F1433E0
        public void Invoke(){} // RVA: 0x7FFD4F143AC0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F143B60
        public void CancelInvoke(){} // RVA: 0x7FFD4F143C00
        public void IsInvoking(){} // RVA: 0x7FFD4F143C20
        public void StartCoroutine(){} // RVA: 0x7FFD4F143C40
        public void LateUpdate(){} // RVA: 0x7FFD4F143D60
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4F143D90
        public void OnDestroy(){} // RVA: 0x7FFD4F143DE0
        public void get_SendClientReports(){} // RVA: 0x7FFD4F143ED0
        public void ApplyTransformRotation(){} // RVA: 0x7FFD4F143EE0
        public void StopCoroutine(){} // RVA: 0x7FFD4F143EF0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F143FE0
        public void get_ipsQuery(){} // RVA: 0x7FFD4E3AC2A0
        public void .cctor(){} // RVA: 0x7FFD4F144130
        public void print(){} // RVA: 0x7FFD4F1441F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F144490
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F144510
        public void InvokeDelayed(){} // RVA: 0x7FFD4F1445B0
        public void OnEnable(){} // RVA: 0x7FFD4F144820
        public void IsInvoking_FDA4AC6BF45E(){} // RVA: 0x7FFD4F144940
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F1449F0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F144B50
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F144C00
        public void OnDisable(){} // RVA: 0x7FFD4F144C60
        public void StopCoroutineFromEnumeratorManaged_AD830D9D55D8(){} // RVA: 0x7FFD4F144CB0
        public void SetHaltUpdateMovement(){} // RVA: 0x7FFD4F144CD0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F144CE0
        public void OnBecameVisible(){} // RVA: 0x7FFD4E426850
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F144DD0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F144E80
        public void set_search(){} // RVA: 0x7FFD4E3C2980
        public void OnCollisionExit(){} // RVA: 0x7FFD4F144F90
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F145180
        public void OnTriggerStay(){} // RVA: 0x7FFD4F145230
        public void OnTriggerExit(){} // RVA: 0x7FFD4F145280
        public void get_Uploaded(){} // RVA: 0x7FFD4E9622C0
        public void UpdateIK(){} // RVA: 0x7FFD4F145360
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4F1454D0
        public void GetVideoTracks(){} // RVA: 0x7FFD4F145510
        public void get_isRightToLeftText(){} // RVA: 0x7FFD4F0AE090
        public void ResetPendingState(){} // RVA: 0x7FFD4F145660
        public void Awake_F6B6764675D3(){} // RVA: 0x7FFD4F145710
        public void set_SendClientReports(){} // RVA: 0x7FFD4F1458D0
        public void SyncTransformPosition3(){} // RVA: 0x7FFD4F1458E0
        public void CreateHelperObject(){} // RVA: 0x7FFD4E36F0C0
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void CheckGameObjectActive(){} // RVA: 0x7FFD4F145B20
        public void FixedUpdate(){} // RVA: 0x7FFD4F145B50
        public void Update(){} // RVA: 0x7FFD4F145BF0
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFD4F145D50
        public void IsNodeActive(){} // RVA: 0x7FFD4F145E40
        public void ValidateNodes(){} // RVA: 0x7FFD4F145F60
        public void OnApplicationPause(){} // RVA: 0x7FFD4F146040
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F146190
        public void UpdateStateFromConfig(){} // RVA: 0x7FFD4F1461E0
        public void ApplyTransformRotation_69A0BC102494(){} // RVA: 0x7FFD4F146300
        public void Start_D2C2961F0296(){} // RVA: 0x7FFD4F146310
        public void OnCollisionStay(){} // RVA: 0x7FFD4F146AF0
        public void SyncPhysicsTransforms(){} // RVA: 0x7FFD4F146C00
        public void GetLanguage(){} // RVA: 0x7FFD4F146FC0
        public void Update_6ADA48C15521(){} // RVA: 0x7FFD4F147120
        public void SetConnectedBody2(){} // RVA: 0x7FFD4F147380
        public void OnDisable_85D99044F45E(){} // RVA: 0x7FFD4F1474E0
        public void CreateSecondaryResources(){} // RVA: 0x7FFD4F147520
        public void get_Drone(){} // RVA: 0x7FFD4F144C60
        public void CreatePrimaryResource(){} // RVA: 0x7FFD4F1475C0
        public void StoreVector2(){} // RVA: 0x7FFD4F147660
        public void ResetDefaultSettings(){} // RVA: 0x7FFD4F1477F0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F147AE0
        public void ResolveAndSwapBestMatchingEntry(){} // RVA: 0x7FFD4F147AF0
        public void set_Item(){} // RVA: 0x7FFD4F147BE0
        public void InitializeScaleTween(){} // RVA: 0x7FFD4F147D30
        public void InitializeScaleTween_C441847B12D1(){} // RVA: 0x7FFD4F147E80
        public void ApplyEulerRotation(){} // RVA: 0x7FFD4F148490
        public void DefaultEquals(){} // RVA: 0x7FFD4F1485A0
        public void CaptureVectorState(){} // RVA: 0x7FFD4F148640
        public void GetUnityEngine_BCFCD7F0C04C(){} // RVA: 0x7FFD4F1486A0
        public void OnDestroy_52700D8F3E69(){} // RVA: 0x7FFD4E36F130
        public void FixedUpdate_058B50F1E0FF(){} // RVA: 0x7FFD4F148740
        public void ApplyTransformPose(){} // RVA: 0x7FFD4F148760
        public void HandleMovement(){} // RVA: 0x7FFD4F148840
        public void CalculateFootPlacement(){} // RVA: 0x7FFD4F148930
        public void UpdateCull(){} // RVA: 0x7FFD4E3AC2A0
        public void get_search(){} // RVA: 0x7FFD4E3C2970
        public void CreateInstance(){} // RVA: 0x7FFD4F148A30
        public void CreateInstance_0EC301562FFF(){} // RVA: 0x7FFD4F148AD0
        public void GetUnityEngine_BCFD162BE252(){} // RVA: 0x7FFD4F149030
        public void GetUnityEngine_277FFA682F11(){} // RVA: 0x7FFD4F149070
        public void UpdateTransform(){} // RVA: 0x7FFD4F1491E0
        public void SyncTransformPosition2(){} // RVA: 0x7FFD4F149450
        public void TestProjectionOverlap(){} // RVA: 0x7FFD4F1495A0
        public void get_Drone_67A82472E7A4(){} // RVA: 0x7FFD4F144C60
        public void Start(){} // RVA: 0x7FFD4F1495C0
        public void GetTransformReference2(){} // RVA: 0x7FFD4F149660
        public void GetEffector(){} // RVA: 0x7FFD4F1497D0
        public void ProcessAnimation(){} // RVA: 0x7FFD4F149880
        public void NormalizeStep(){} // RVA: 0x7FFD4F149980
        public void Check(){} // RVA: 0x7FFD4F1499D0
        public void InitializeState(){} // RVA: 0x7FFD4F149B30
        public void SyncTransformRotation2(){} // RVA: 0x7FFD4F149C10
        public void SyncTransformRotation5(){} // RVA: 0x7FFD4F149DE0
        public void CheckParentConstraintActive2(){} // RVA: 0x7FFD4F14A080
        public void SyncTransformRotation6(){} // RVA: 0x7FFD4F14A2B0
        public void ProcessRotation(){} // RVA: 0x7FFD4F14A560
        public void InitializeIK(){} // RVA: 0x7FFD4F14A960
        public void ApplyMovement(){} // RVA: 0x7FFD4F14AD50
        public void SyncTransformRotation4(){} // RVA: 0x7FFD4F14AEB0
        public void GetTransformReference(){} // RVA: 0x7FFD4F14AFB0
        public void get_IsDominantHand(){} // RVA: 0x7FFD4F14B010
        public void GetUnityEngine_27AF01A35077(){} // RVA: 0x7FFD4F14B020
        public void ResetIK(){} // RVA: 0x7FFD4F14B140
        public void SyncTransformRotation3(){} // RVA: 0x7FFD4F14B1F0
        public void UpdateSearch(){} // RVA: 0x7FFD4F14B500
        public void ReportClientState(){} // RVA: 0x7FFD4F14B510
        public void UpdateLookRotation(){} // RVA: 0x7FFD4F14B610
        public void set_payload(){} // RVA: 0x7FFD4EDC79B0
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD4F14B800
        public void Initialize(){} // RVA: 0x7FFD4F14BDC0
        public void HandleCollision(){} // RVA: 0x7FFD4F14BF50
        public void EvaluateIK(){} // RVA: 0x7FFD4F14C7B0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFD4EAF84B0
        public void GetSource(){} // RVA: 0x7FFD4E964340
        public void ApplyTransformRotation2(){} // RVA: 0x7FFD4F14C850
        public void SyncTransformPosition(){} // RVA: 0x7FFD4F14C9C0
        public void SynchronizeState(){} // RVA: 0x7FFD4F14CC80
        public void SetDestroyCancellationToken(){} // RVA: 0x7FFD4F14CF70
        public void SetHaltUpdateMovement_A5FB15E912D4(){} // RVA: 0x7FFD4F144CD0
        public void SetUpdateMode(){} // RVA: 0x7FFD4F14D0B0
        public void GetTransformReference3(){} // RVA: 0x7FFD4F14D2C0
        public void SyncTransformRotation7(){} // RVA: 0x7FFD4F14D330
        public void ContainsChild(){} // RVA: 0x7FFD4F14D390
        public void InitializeComplexComponent(){} // RVA: 0x7FFD4F14D480
        public void SolveConstraint(){} // RVA: 0x7FFD4F14D4B0
        public void NormalizeAndClamp(){} // RVA: 0x7FFD4F14D4E0
        public void CheckParentConstraintActive(){} // RVA: 0x7FFD4F14D580
        public void UpdateComplexComponent(){} // RVA: 0x7FFD4F14D480
        public void CancelComplexInvocation(){} // RVA: 0x7FFD4F14D670
    }

    /// <summary>Originally: ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎÏÎÏ</summary>
    public class ComplexComponent_AFA2 : MonoBehaviour
    {
        public ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎÏÎÏ _destroyCancellationToken;
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ _useGUILayout; // 0x20
        public ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍÏÌÎ f_09C; // 0x28
        public ÍÏÌÏÎÎÏÍÎÌÌÍÍÌÏÎÏÍÎÍÍÍÌ f_8FB; // 0x30
        public ÎÌÎÏÍÍÌÎÍÎÍÏÏÌÌÏÎÌÎÌÌÍÏ f_96C; // 0x38
        public ÏÍÌÍÌÍÌÌÏÏÏÌÎÌÍÏÍÏÏÎÏÍÎ f_B04; // 0x40
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ f_981; // 0x48
        public ÍÍÌÌÎÏÏÌÏÏÎÌÏÍÎÏÎÌÍÍÍÍÌ f_5DE; // 0x50
        public N|K.x f_EC2; // 0x58
        public ÌÎÎÌÏÍÍÎÎÍÏÌÍÍÌÎÎÎÏÍÌÏÌ f_A60; // 0x60
        public ÍÌÏÏÌÏÏÍÌÎÏÎÏÍÏÍÎÏÌÌÎÎÌ f_AF8; // 0x68
        public ÌÏÍÌÏÏÎÏÏÌÎÎÎÍÍÍÎÏÏÍÎÏÌ f_5D5; // 0x70
        public ÎÎÏÎÌÍÍÏÍÏÍÍÏÍÎÏÏÌÎÌÌÎÎ f_AF1; // 0x78
        public ÌÏÍÎÌÎÏÍÍÏÍÍÌÍÌÍÏÌÌÎÎÏÏ f_2F2; // 0x80
        public ÎÎÎÏÍÍÌÎÍÍÎÍÎÎÌÍÎÍÎÏÍÎÏ f_2D4; // 0x88
        public ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ f_8EA; // 0x90
        public ÍÏÎÎÌÎÍÌÏÌÌÍÍÏÌÏÍÍÎÏÎÎÌ f_B72; // 0x98
        public ÌÏÎÎÌÌÌÏÍÍÌÍÎÍÎÏÎÎÎÎÌÌÏ f_D51; // 0xA0
        public ÌÍÏÏÌÏÎÏÎÍÌÏÍÌÏÌÌÎÏÌÎÏÍ f_AAB; // 0xA8
        public ÌÍÎÎÎÏÌÏÌÎÌÍÏÍÌÎÍÏÌÎÏÏÏ f_50F; // 0xB0
        public ÏÍÎÍÍÎÎÏÎÏÎÎÎÌÍÎÎÍÍÎÍÍÍ f_545; // 0xB8
        public ÎÏÌÎÍÎÍÍÏÍÏÌÏÍÌÏÎÏÎÍÌÏÍ f_509; // 0xC0
        public ÎÍÍÍÏÎÏÍÍÏÎÏÌÏÍÎÎÎÏÌÍÏÍ f_38F; // 0xC8
        public ÌÌÍÌÌÎÍÎÏÌÏÎÎÍÎÏÎÎÌÏÌÌÎ f_5AA; // 0xD0
        public ÍÎÍÌÎÌÍÎÎÍÌÎÍÍÎÎÌÏÍÌÏÏÌ f_F06; // 0xD8
        public ÏÎÏÎÏÏÏÍÌÎÎÏÍÏÌÎÏÎÌÍÌÎÎ f_A1B; // 0xE0
        public string f_A5E; // 0x8
        public string f_A0E; // 0x10
        public float f_456; // 0x18
        public string f_2B1;
        public string ÏÌÏÌÍÎÏÎÏÍÏÍÍÏÌÌÌÏÏÌÎÎÍ;
        public string ÎÎÍÎÍÏÍÍÍÎÎÍÏÍÏÎÎÎÌÏÏÍÎ;
        public string ÌÎÌÏÌÏÏÎÎÎÍÎÎÏÍÍÌÎÌÎÎÏÍ;
        public System.Action ÏÏÏÍÍÎÍÍÎÏÏÍÍÍÎÍÏÌÎÏÎÌÎ; // 0x20
        public System.Action ÌÏÏÍÏÏÎÌÎÌÌÌÍÌÎÍÏÏÏÎÍÌÏ; // 0x28
        public System.Action ÍÎÏÎÍÏÌÎÌÌÏÎÍÎÌÌÎÌÏÏÍÎÎ; // 0x30
        public System.Action ÌÍÏÎÍÌÏÍÎÎÏÍÎÎÌÍÏÏÏÍÏÌÎ; // 0x38
        public System.Action`1<float> ÍÍÍÌÍÏÏÎÌÎÎÏÏÌÏÎÏÏÌÍÎÏÍ; // 0x40
        public System.Action ÌÍÍÍÏÌÎÏÎÏÎÌÌÏÏÏÎÌÌÍÏÌÎ; // 0x48
        public System.Action ÎÌÎÏÎÏÎÍÎÏÏÎÎÏÌÏÎÍÌÍÍÏÏ; // 0x50
        public System.Action ÍÌÏÏÌÌÍÌÏÍÏÏÌÏÍÎÍÍÎÎÎÎÍ; // 0x58
        public System.Action ÍÏÌÎÍÍÍÎÎÏÍÏÌÏÎÍÍÏÎÌÎÌÍ; // 0x60
        public System.Action ÍÍÍÍÎÎÍÌÏÏÍÍÎÏÍÏÌÎÏÌÏÍÎ; // 0x68
        public System.Action ÎÌÍÍÎÏÌÍÏÎÎÏÎÎÌÌÌÏÍÌÏÏÍ; // 0x70
        public System.Action ÌÏÎÌÎÏÎÏÌÏÎÍÌÎÌÍÌÍÍÎÌÌÎ; // 0x78
        public System.Action ÎÎÍÍÌÌÏÏÍÍÏÍÌÌÎÌÏÌÏÌÍÎÎ; // 0x80
        public bool ÎÍÎÎÌÍÏÌÎÌÎÌÎÍÎÎÎÏÍÏÌÎÌ; // 0xE8
        public bool ÌÎÍÏÍÍÌÎÍÌÍÍÌÌÍÏÌÌÌÎÌÏÏ; // 0xE9
        public bool ÌÏÌÏÎÍÍÎÌÏÌÍÍÏÎÏÏÌÎÏÍÏÌ; // 0xEA
        public bool ÏÌÌÏÍÎÏÌÍÏÌÌÎÍÌÌÏÌÍÌÎÌÌ; // 0xEB
        public bool ÍÎÏÏÍÏÏÏÍÍÌÏÎÏÎÎÏÌÎÏÍÍÍ; // 0xEC
        public bool ÏÌÍÏÍÏÏÍÍÍÍÏÍÎÍÍÏÏÍÌÌÌÍ; // 0xED
        public bool ÎÍÌÍÍÎÏÏÎÎÏÎÎÌÍÎÎÌÌÏÍÍÎ; // 0xEE
        public bool ÍÍÎÏÏÌÌÎÏÏÌÌÎÎÍÌÌÏÍÎÍÎÎ; // 0xEF
        public bool ÏÏÌÎÍÏÌÏÌÎÏÍÌÏÌÌÏÌÏÍÍÎÍ; // 0xF0
        public bool ÏÎÍÌÎÌÎÏÎÍÌÍÎÌÏÎÍÏÌÌÏÏÎ; // 0xF1
        public bool ÎÌÌÏÎÌÍÏÍÎÎÌÌÏÏÏÌÎÌÎÎÎÏ; // 0xF2
        public System.ValueTuple`2<bool,System.DateTime> ÌÍÎÍÏÏÎÏÌÏÎÍÏÍÎÎÍÎÏÎÏÌÎ; // 0xF8
        public System.Threading.CancellationTokenSource ÍÏÏÏÍÌÎÎÌÌÎÍÍÎÎÎÌÏÏÎÎÎÌ; // 0x108
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÌÎÏÎÍÎÌÎÎÌÎÏÌÌÌÏÍÏÏÏÏÏ; // 0x110
        public System.ValueTuple`2<bool,System.DateTime> <ÎÍÍÍÌÏÎÏÎÌÏÎÍÏÌÍÌÍÌÍÍÏÏ>k__BackingField; // 0x88
        public int ÌÎÎÌÏÌÍÎÎÌÍÏÌÏÍÍÎÌÌÌÏÌÎ;
        public long ÍÍÏÌÌÏÏÏÏÏÏÏÍÎÌÍÏÌÌÏÎÎÍ;
        public int ÏÎÌÎÌÍÎÍÍÏÏÍÌÏÍÍÏÏÍÍÎÌÏ; // 0x118
        public int ÌÎÌÏÏÍÌÏÍÎÌÌÎÎÌÎÌÌÌÏÌÏÌ;
        public ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ ÍÌÏÌÌÍÌÍÏÍÏÍÎÍÌÍÎÎÏÌÏÏÎ; // 0x120
        public float ÏÌÌÍÏÎÍÍÏÎÏÎÌÌÎÏÍÎÌÌÌÏÍ; // 0x128
        public float ÎÎÎÌÏÏÏÎÍÎÏÌÎÌÏÏÎÍÎÏÍÏÍ; // 0x12C
        public System.Action ÌÎÌÏÍÍÌÏÌÎÏÍÎÌÍÏÍÎÎÎÌÏÏ; // 0x130
        public float ÎÎÎÌÌÍÎÌÍÏÏÌÍÍÌÍÎÍÌÎÎÎÏ;
        public float ÍÏÎÏÎÏÍÍÏÏÍÌÍÎÏÌÎÍÍÏÍÎÏ;
        public float ÍÏÍÏÌÍÎÌÎÎÎÎÍÍÏÌÌÎÏÌÌÌÌ; // 0x138
        public float ÎÎÌÏÍÎÍÌÎÍÏÏÎÎÌÏÏÎÏÎÌÏÌ; // 0x98
        public float ÏÌÏÌÏÍÏÌÎÌÏÎÍÏÍÍÍÍÌÌÎÍÎ;

        // ── Methods ──
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void RaiseCancellation(){} // RVA: 0x7FFD4F4970B0
        public void get_contentList(){} // RVA: 0x7FFD4E960F70
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void InvokeRepeating(){} // RVA: 0x7FFD4F497210
        public void GetTexture(){} // RVA: 0x7FFD4E45E100
        public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
        public void StartCoroutine(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD4F497360
        public void StartCoroutine_DFACAE305CA3(){} // RVA: 0x7FFD4F4973E0
        public void get_taglineText(){} // RVA: 0x7FFD4E96B1A0
        public void StopCoroutine(){} // RVA: 0x7FFD4F497990
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F497A80
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F497B30
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F497BB0
        public void .cctor(){} // RVA: 0x7FFD4F497D00
        public void set_useGUILayout(){} // RVA: 0x7FFD4E341310
        public void print(){} // RVA: 0x7FFD4F497E40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F497F00
        public void set_onPressed(){} // RVA: 0x7FFD4E3AC130
        public void InvokeDelayed(){} // RVA: 0x7FFD4F498050
        public void set_contentList(){} // RVA: 0x7FFD4E3C28A0
        public void IsInvoking(){} // RVA: 0x7FFD4F4981A0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F498220
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F498290
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F4982A0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F4983F0
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void GetScriptClassName(){} // RVA: 0x7FFD4F498540
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F498560
        public void StartCoroutineManaged_9A4B20E5AC59(){} // RVA: 0x7FFD4E3E20E0
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void InitializeTransientBuffer(){} // RVA: 0x7FFD4F4985C0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F498C70
        public void set_worldTag(){} // RVA: 0x7FFD4E45E110
        public void .ctor(){} // RVA: 0x7FFD4F498DC0
        public void Initialize(){} // RVA: 0x7FFD4F498F60
        public void get_version(){} // RVA: 0x7FFD4E3AC040
        public void LateUpdate(){} // RVA: 0x7FFD4F4990B0
        public void UpdateSpine(){} // RVA: 0x7FFD4F4990C0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void FormatTransientLabel(){} // RVA: 0x7FFD4F4993D0
        public void ResetPendingState(){} // RVA: 0x7FFD4F499420
        public void CalculateAlpha(){} // RVA: 0x7FFD4F499430
        public void AssignUdonEmitter(){} // RVA: 0x7FFD4E76B370
        public void BlendTextures(){} // RVA: 0x7FFD4F499E70
        public void DecodeNetworkFloat(){} // RVA: 0x7FFD4F499E80
        public void ResetMapping(){} // RVA: 0x7FFD4F49A010
        public void CheckGameObjectActive(){} // RVA: 0x7FFD4F49A020
        public void set_version(){} // RVA: 0x7FFD4E3AC050
        public void StringToHash(){} // RVA: 0x7FFD4F49A570
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFD4F49A5A0
        public void set_PointerPose(){} // RVA: 0x7FFD4E3AC0C0
        public void ApplyRigidbodyVelocity(){} // RVA: 0x7FFD4F49A690
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void UpdateTracks(){} // RVA: 0x7FFD4F49A7E0
        public void UpdateStateFromConfig(){} // RVA: 0x7FFD4F49A930
        public void set_iconImageUrl(){} // RVA: 0x7FFD4E96E360
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void HandleCollision(){} // RVA: 0x7FFD4F49AA80
        public void SetConnectedBody2(){} // RVA: 0x7FFD4E341310
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void ProcessInput(){} // RVA: 0x7FFD4F49AAE0
        public void EnsurePhysicsAccessors(){} // RVA: 0x7FFD4F49AC30
        public void RefreshVisuals(){} // RVA: 0x7FFD4F49AD80
        public void UpdateTagline(){} // RVA: 0x7FFD4F49AED0
        public void SetTexture(){} // RVA: 0x7FFD4F49B020
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void Start(){} // RVA: 0x7FFD4F49B180
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void get_onPressed(){} // RVA: 0x7FFD4E3AC120
        public void set_domainList(){} // RVA: 0x7FFD4E3C2910
        public void OnDisable(){} // RVA: 0x7FFD4F49B190
        public void ReadTransformBounds(){} // RVA: 0x7FFD4F49B480
        public void ClearContent(){} // RVA: 0x7FFD4F49B6F0
        public void Awake(){} // RVA: 0x7FFD4F49B840
        public void OnBecameVisible(){} // RVA: 0x7FFD4F49C4E0
        public void set_tooltipDescription(){} // RVA: 0x7FFD4E96E420
        public void FixedUpdate(){} // RVA: 0x7FFD4F49C970
        public void OnApplicationFocus(){} // RVA: 0x7FFD4F49CA90
        public void OnCollisionExit(){} // RVA: 0x7FFD4E3AC0C0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F49CAA0
        public void OnTriggerStay(){} // RVA: 0x7FFD4F49CBF0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void set_imageUrl(){} // RVA: 0x7FFD4E96E300
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F49D220
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void OnApplicationPause(){} // RVA: 0x7FFD4F49D280
        public void UpdateLayout(){} // RVA: 0x7FFD4F49D380
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFD4E5006F0
        public void set_disclaimerText(){} // RVA: 0x7FFD4E499470
        public void OnCollisionStay(){} // RVA: 0x7FFD4E36F0C0
        public void Save(){} // RVA: 0x7FFD4F49D430
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void OnDisable_F3E3E0F0F590(){} // RVA: 0x7FFD4F49DBF0
        public void OnTriggerExit(){} // RVA: 0x7FFD4E505600
        public void InvokeIndexedCallback(){} // RVA: 0x7FFD4F49DD40
        public void InitComponent(){} // RVA: 0x7FFD4F49DE90
        public void GetGameObject_E61(){} // RVA: 0x7FFD4F49DFE0
        public void InvokeStateDelegate(){} // RVA: 0x7FFD4F49E3D0
        public void set_body(){} // RVA: 0x7FFD4E4095A0
        public void UpdatelocalScale_I(){} // RVA: 0x7FFD4F49E3E0
        public void set_description(){} // RVA: 0x7FFD4E96E3C0
        public void Update(){} // RVA: 0x7FFD4F49E4D0
        public void ProcessContent(){} // RVA: 0x7FFD4F49E950
        public void LateUpdate_783A5220A4A7(){} // RVA: 0x7FFD4F49E9C0
        public void ApplyRigidbodyVelocity_154A2E33B375(){} // RVA: 0x7FFD4F49F660
        public void IsSupportedMotionMode(){} // RVA: 0x7FFD4F4A0150
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void ComputeHashCode(){} // RVA: 0x7FFD4F4A02A0
        public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
        public void DoInverseTransform(){} // RVA: 0x7FFD4F4A13F0
        public void get_domainList(){} // RVA: 0x7FFD4E3C2900
        public void SetActive_A34(){} // RVA: 0x7FFD4F4A1A20
        public void set_worldTag_4CA937E2908C(){} // RVA: 0x7FFD4E499460
        public void SyncTransformRotation(){} // RVA: 0x7FFD4F4A1B70
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void SetModelShader(){} // RVA: 0x7FFD4E3BC740
        public void ComputeRotationDelta(){} // RVA: 0x7FFD4F4A1CC0
        public void SyncTransformPosition(){} // RVA: 0x7FFD4F4A1D10
        public void GetColliderComponents_011267DE0EA2(){} // RVA: 0x7FFD4E963900
    }

    /// <summary>Originally: ÌÏÍÍÎÎÏÍÎÌÏÍÍÎÌÎÏÏÏÎÍÏÍ</summary>
    public class ComplexComponent_E737 : MonoBehaviour
    {
        public ÌÏÍÍÎÎÏÍÎÌÏÍÍÎÌÎÏÏÏÎÍÏÍ _destroyCancellationToken;
        public UnityEngine.LayerMask _useGUILayout; // 0x20
        public UnityEngine.LayerMask f_D9E; // 0x24
        public UnityEngine.GameObject f_768; // 0x28
        public VRC.StickerCollectionPrefab f_2BC; // 0x30
        public ÎÎÏÏÌÍÏÍÏÌÍÏÎÌÍÏÌÍÎÍÍÍÏ<System.Collections.Generic.List`1<ÌÌÍÎÏÌÍÌÍÏÏÎÏÏÎÌÏÏÍÍÏÍÌ>> f_FC3; // 0x38
        public string f_004; // 0x8
        public int f_473; // 0x40
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_BCF; // 0x48
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_185; // 0x50
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÌÍÎÏÌÍÌÍÏÏÎÏÏÎÌÏÏÍÍÏÍÌ>> f_4E6; // 0x58
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÌÍÎÏÌÍÌÍÏÏÎÏÏÎÌÏÏÍÍÏÍÌ>> f_D41; // 0x60
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÌÍÎÏÌÍÌÍÏÏÎÏÏÎÌÏÏÍÍÏÍÌ>> f_8F6; // 0x68
        public System.Collections.Generic.List`1<ÎÎÍÌÌÎÌÍÏÎÍÏÎÌÏÎÍÍÍÎÌÌÌ> f_BD1; // 0x70
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_C7C; // 0x78
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_53A; // 0x80
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<int> f_D2B; // 0x88
        public System.Collections.Generic.HashSet`1<ÎÏÌÏÏÎÍÏÍÌÏÏÍÌÏÌÍÎÍÌÌÏÌ> f_F92; // 0x90
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ>> f_D03; // 0x98
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_1AA; // 0xA0
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_576; // 0xA8
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_550; // 0xB0
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_60D; // 0xB8
        public ÌÏÌÍÏÍÍÎÍÎÎÏÌÎÍÏÍÍÍÎÌÎÌ f_D8C; // 0xC0
        public ÏÌÍÌÏÎÏÌÏÎÍÎÌÌÌÎÌÌÍÍÌÏÌ f_653; // 0xC8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<ÌÌÎÎÏÏÍÌÌÏÏÌÌÎÌÏÏÏÎÍÏÍÎ> <ÌÌÏÏÏÍÌÌÏÏÍÍÌÏÏÎÍÏÍÍÌÍÌ>k__BackingField; // 0xD0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<ÌÌÎÎÏÏÍÌÌÏÏÌÌÎÌÏÏÏÎÍÏÍÎ> <ÎÎÏÍÍÎÌÌÎÏÌÍÏÎÎÎÏÍÏÎÍÍÌ>k__BackingField; // 0xD8
        public bool ÍÌÏÌÎÍÎÍÏÎÌÍÏÍÎÌÍÏÎÍÌÌÌ; // 0xE0
        public System.Collections.Generic.List`1<ÏÏÌÍÍÌÍÍÍÏÎÍÍÎÎÌÎÎÍÌÌÌÎ> ÍÍÎÏÍÏÍÍÎÎÎÏÏÏÌÌÍÏÎÍÎÏÌ; // 0xE8
        public System.Collections.Generic.List`1<ÏÏÌÍÍÌÍÍÍÏÎÍÍÎÎÌÎÎÍÌÌÌÎ> ÌÌÏÏÏÌÏÏÎÍÏÍÍÍÎÍÍÍÏÎÏÏÍ; // 0xF0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÌÌÍÎÏÌÍÌÍÏÏÎÏÏÎÌÏÏÍÍÏÍÌ>> ÌÌÌÎÍÌÏÍÏÍÌÎÎÌÎÎÍÍÍÍÎÍÍ; // 0xF8
        public float ÌÌÏÏÎÏÏÌÏÍÎÌÍÎÎÎÎÌÎÏÏÍÏ;
        public float ÍÍÌÌÌÌÎÍÎÏÎÏÏÏÌÎÍÎÏÍÌÏÍ; // 0x10
        public System.Collections.Generic.List`1<ÍÍÍÏÎÍÌÎÏÌÌÏÍÎÍÏÍÌÏÌÌÎÍ> ÍÌÎÏÎÏÏÍÎÍÎÌÌÏÏÌÍÌÌÌÏÍÎ; // 0x100
        public UnityEngine.Coroutine ÎÎÎÌÏÎÎÌÌÌÏÎÌÏÎÌÌÎÏÏÎÍÎ; // 0x108
        public UnityEngine.Coroutine ÎÍÎÌÎÌÏÍÌÏÌÌÍÌÍÎÍÏÎÌÎÍÏ; // 0x110
        public UnityEngine.Camera ÌÌÏÍÌÏÌÎÌÌÎÏÏÎÎÏÎÌÍÎÌÏÎ; // 0x118
        public ÏÌÎÎÍÎÌÍÍÌÍÌÏÏÌÏÌÎÌÍÎÎÏ ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0x120
        public System.Collections.Generic.Dictionary`2<0x6634F940,byte[]> ÎÌÏÏÍÍÌÌÏÌÌÎÍÌÏÌÌÏÏÎÏÍÎ; // 0x18
        public System.Collections.Generic.Dictionary`2<byte,System.Type> ÌÎÏÍÏÏÍÎÎÍÏÍÏÎÎÏÏÌÍÍÏÍÌ; // 0x20
        public int ÌÍÌÏÍÌÎÏÎÎÏÍÏÏÍÏÍÏÌÌÏÌÍ;
        public int ÍÌÏÌÍÎÎÏÏÌÍÏÎÎÏÏÎÎÌÍÌÍÏ;
        public int ÌÍÎÍÍÌÏÌÏÍÏÎÎÌÎÎÍÌÎÏÍÌÍ;
        public bool <ÏÌÎÍÍÍÌÎÍÌÌÏÍÌÏÍÏÎÎÍÌÍÏ>k__BackingField; // 0x128

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E9C5F60
        public void RaiseCancellation(){} // RVA: 0x7FFD4E9C6140
        public void IsInvoking(){} // RVA: 0x7FFD4E9C62E0
        public void CancelInvoke(){} // RVA: 0x7FFD4E9C6610
        public void Invoke(){} // RVA: 0x7FFD4E9C6670
        public void InvokeRepeating(){} // RVA: 0x7FFD4E9C6DD0
        public void CancelInvoke_E9790DDC4DC6(){} // RVA: 0x7FFD4E9C6E70
        public void Computenames(){} // RVA: 0x7FFD4E9C6ED0
        public void StartCoroutine(){} // RVA: 0x7FFD4E9C71D0
        public void StartCoroutine_6A551142D887(){} // RVA: 0x7FFD4E9C7240
        public void StartCoroutine_AB3BB7EA21D3(){} // RVA: 0x7FFD4E9C7270
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E9C75A0
        public void StopCoroutine(){} // RVA: 0x7FFD4E9C75D0
        public void Awake(){} // RVA: 0x7FFD4E9C7B40
        public void Start(){} // RVA: 0x7FFD4E9C7C40
        public void get_version(){} // RVA: 0x7FFD4E3AC040
        public void .ctor(){} // RVA: 0x7FFD4E9C96F0
        public void Initialize(){} // RVA: 0x7FFD4E9CA130
        public void print(){} // RVA: 0x7FFD4E9CA1D0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E9CA7F0
        public void OnDestroy(){} // RVA: 0x7FFD4E9CA910
        public void InvokeDelayed(){} // RVA: 0x7FFD4E9CAB10
        public void OnBecameVisible(){} // RVA: 0x7FFD4E9CAC80
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E9CAE80
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4E9CAED0
        public void set_PointerPose(){} // RVA: 0x7FFD4E3AC0C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E9CB160
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4E9CB210
        public void GetScriptClassName_1C60BD7E6B6B(){} // RVA: 0x7FFD4E9D0430 | overloaded x2
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4E9CB830
        public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
        public void SyncLocalRotation(){} // RVA: 0x7FFD4E9CBA50
        public void ApplyEulerRotation2(){} // RVA: 0x7FFD4E9CBBC0
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void PickUp(){} // RVA: 0x7FFD4E9CBCB0
        public void set_description(){} // RVA: 0x7FFD4E96E3C0
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void ApplyLocalRotation(){} // RVA: 0x7FFD4E9CBD60
        public void IsInvoking_0B505AC60201(){} // RVA: 0x7FFD4E9CBE00
        public void CancelInvoke_69C27AF5AF0A(){} // RVA: 0x7FFD4E9CBE60
        public void GetSpineMapping_0FC52C63620A(){} // RVA: 0x7FFD4E409590
        public void OnTriggerExit(){} // RVA: 0x7FFD4E9CBE70
        public void SyncLocalRotation3(){} // RVA: 0x7FFD4E9CBF50
        public void Update(){} // RVA: 0x7FFD4E9CC130
        public void ApplyLocalRotation2(){} // RVA: 0x7FFD4E9CC180
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E9CC230
        public void GetPhysicsShapeImpl(){} // RVA: 0x7FFD4E9CC280
        public void Awake_7480E08F6AD3(){} // RVA: 0x7FFD4E9CCC80
        public void get_mass(){} // RVA: 0x7FFD4E9CD140
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFD4E3E2090
        public void IsInvoking_DBBB7178EB5F(){} // RVA: 0x7FFD4E9CD780
        public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
        public void set_IsCustomized(){} // RVA: 0x7FFD4E74DA60
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD4E9CD9E0
        public void .cctor(){} // RVA: 0x7FFD4E9CDC10
        public void GetTexture(){} // RVA: 0x7FFD4E45E100
        public void FixedUpdate(){} // RVA: 0x7FFD4E9CE520
        public void Start_BA8513AC35E7(){} // RVA: 0x7FFD4E9CE880
        public void CompareState(){} // RVA: 0x7FFD4E9CE9B0
        public void get_onPressed(){} // RVA: 0x7FFD4E3AC120
        public void SetColorImplParticleMainModule(){} // RVA: 0x7FFD4E9CEDF0
        public void OnEnable(){} // RVA: 0x7FFD4E9CF010
        public void ReadRigidbodyState(){} // RVA: 0x7FFD4E9CF3C0
        public void RaiseCancellation_DB2D5B9FE00C(){} // RVA: 0x7FFD4E9CF770
        public void OnDisable(){} // RVA: 0x7FFD4E9CFA60
        public void StartCoroutine_Auto_5CBAA4C8F77F(){} // RVA: 0x7FFD4E9C75A0
        public void OnDestroy_E009047AABDC(){} // RVA: 0x7FFD4E9CFB10
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E9CFBC0
        public void OnCollisionStay(){} // RVA: 0x7FFD4E9CFE90
        public void OnCollisionExit(){} // RVA: 0x7FFD4E9CFF40
        public void DispatchLifecycleUpdate(){} // RVA: 0x7FFD4E9D0150
        public void GetStatus(){} // RVA: 0x7FFD4E3E2080
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void GetIKSolver_31DAEF251751(){} // RVA: 0x7FFD4E3E20E0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E9D01B0
        public void OnTriggerStay(){} // RVA: 0x7FFD4E9D0400
        public void get_article(){} // RVA: 0x7FFD4E751F50
        public void OnTriggerExit_868524F2A1AB(){} // RVA: 0x7FFD4E9D0440
        public void set_enabled(){} // RVA: 0x7FFD4E9D05B0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void set_onPressed(){} // RVA: 0x7FFD4E3AC130
        public void set_version(){} // RVA: 0x7FFD4E3AC050
        public void set_enabled_A944DA083396(){} // RVA: 0x7FFD4E9D0600
        public void set_enabled_45FB74094747(){} // RVA: 0x7FFD4E9D0670
        public void get_IsCustomized(){} // RVA: 0x7FFD4E751A00
        public void set_enabled_6386172D5DD6(){} // RVA: 0x7FFD4E9D0690
        public void get_contentList(){} // RVA: 0x7FFD4E960F70
        public void SetRendererEnabled(){} // RVA: 0x7FFD4E9D0BF0
        public void GetUnityEngine(){} // RVA: 0x7FFD4E9D0FD0
        public void GetTransformReference(){} // RVA: 0x7FFD4E9D10C0
        public void get_gameObject(){} // RVA: 0x7FFD4E9D1200
        public void get_transform(){} // RVA: 0x7FFD4E9D1330
        public void ComputeName(){} // RVA: 0x7FFD4E9D13E0
        public void get_onPressed_922CB9E10C71(){} // RVA: 0x7FFD4E3BCD50
        public void GetComponent(){} // RVA: 0x7FFD4E9D16C0
        public void Initialize_614792764F6A(){} // RVA: 0x7FFD4E3AC0B0
        public void GetComponents(){} // RVA: 0x7FFD4E9D1730
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void LateUpdate(){} // RVA: 0x7FFD4E9D1AF0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void Reset(){} // RVA: 0x7FFD4E9D1B40
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
    }

    /// <summary>Originally: ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍÏÌÎ</summary>
    public class Major148m_82E5 : Object
    {
        public string _name;
        public string _hideFlags;
        public string f_B80;
        public string f_721;
        public string f_A40;
        public bool f_AA8; // 0x10
        public bool f_5F6;
        public bool f_291; // 0x1
        public bool f_294; // 0x2
        public bool f_5B4; // 0x3
        public bool f_162; // 0x4
        public System.DateTime f_F9C; // 0x8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_252; // 0x10
        public bool f_F1A; // 0x18
        public string f_4D8; // 0x20
        public string f_91A; // 0x28
        public string f_148; // 0x30
        public string f_386; // 0x38
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_FFD; // 0x40
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_24F; // 0x48
        public string f_A3D; // 0x50
        public System.Collections.Generic.List`1<0x66413C60> f_C26; // 0x58
        public bool f_268; // 0x60
        public bool f_0F1; // 0x61
        public string f_253; // 0x68
        public bool f_F3A; // 0x70
        public System.DateTime f_A07; // 0x78
        public string f_B94; // 0x80
        public string f_E06; // 0x88
        public string f_7E3; // 0x90
        public string f_0CC; // 0x98
        public string f_0AB; // 0xA0
        public string f_99A; // 0xA8
        public string f_3DD; // 0xB0
        public bool f_1BC; // 0xB8
        public bool f_377; // 0xB9
        public bool f_80D; // 0xBA
        public 0x664D6400 f_E49; // 0xC0
        public 0x664D6400 f_DD4; // 0xC8
        public 0x664D6400 f_EC5; // 0xD0
        public 0x664D6400 f_90A; // 0xD8
        public string f_9F0;
        public string f_735;
        public string f_B3E;
        public string f_B4C;
        public string f_554;
        public string f_BB2;
        public string f_742;
        public string f_5C1;
        public string f_ED5;
        public string f_8B7;
        public float f_40C;
        public float f_DFA; // 0xE0
        public string f_FB6;
        public string f_A5B;
        public string f_AAD;
        public string ÌÎÏÍÏÎÎÏÍÏÏÎÏÎÍÏÎÎÏÎÍÍÌ;
        public string ÎÎÌÎÌÌÎÌÍÍÌÏÏÎÏÏÌÍÍÍÌÍÏ;
        public float ÍÎÍÎÏÌÌÍÍÏÏÎÎÎÍÍÎÎÏÍÍÍÏ;
        public float ÏÍÎÌÏÏÏÎÌÌÏÎÌÎÎÏÍÌÍÍÍÎÏ;
        public float ÏÍÎÏÏÎÎÏÎÎÌÎÎÌÎÌÎÎÏÎÌÏÌ; // 0xE4
        public float ÌÌÏÌÍÍÎÍÌÎÏÌÎÎÍÌÍÎÌÌÌÌÍ; // 0xE8
        public bool ÌÏÎÌÎÎÏÏÌÏÏÏÍÍÏÌÌÏÏÏÎÌÏ; // 0xEC
        public bool ÎÎÏÌÏÏÌÏÏÍÌÌÌÍÎÎÌÍÎÍÌÏÍ; // 0xED
        public bool ÍÍÌÏÏÏÍÌÍÍÌÍÎÏÌÏÍÎÎÏÌÍÍ; // 0xEE
        public ulong ÏÏÏÌÎÏÍÏÌÌÏÏÏÌÏÏÏÎÏÎÍÎÌ; // 0xF0
        public bool ÏÎÎÏÌÌÍÏÏÍÍÏÌÎÌÎÏÍÏÌÎÎÏ; // 0x11
        public bool ÎÏÎÎÏÍÎÌÍÍÏÍÏÌÏÎÎÌÍÌÍÌÍ; // 0x12
        public System.Action ÏÌÌÏÎÌÏÏÌÌÍÍÌÍÌÏÏÏÍÌÏÌÏ; // 0xF8
        public bool ÏÏÌÏÌÌÏÎÎÎÍÏÍÎÌÍÌÏÌÏÎÌÏ; // 0x100
        public bool ÎÌÏÎÌÌÍÌÏÏÍÎÌÎÍÎÎÎÏÎÏÏÏ; // 0x101
        public System.Action`1<bool> ÎÌÌÎÍÏÌÏÌÎÏÌÍÌÎÍÏÌÌÏÎÏÍ; // 0x108
        public VRC.Localization.LocalizableString <ÌÍÍÎÌÏÎÍÌÏÍÍÍÎÍÍÍÏÎÌÌÏÍ>k__BackingField; // 0x110
        public VRC.Localization.LocalizableString <ÌÍÍÌÏÏÌÌÏÎÍÍÍÍÌÍÏÌÌÏÏÏÌ>k__BackingField; // 0x138
        public VRC.Localization.LocalizableString <ÌÍÎÍÎÌÍÍÎÎÌÏÏÌÍÎÏÏÏÎÌÏÏ>k__BackingField; // 0x160
        public VRC.Localization.LocalizableString <ÎÏÍÌÌÍÎÎÍÎÍÌÏÍÏÌÍÏÍÎÍÍÍ>k__BackingField; // 0x188
        public VRC.Localization.LocalizableString <ÌÍÌÌÍÍÌÏÌÍÌÌÎÌÎÏÌÎÌÍÌÌÌ>k__BackingField; // 0x1B0
        public VRC.Localization.LocalizableString <ÎÎÎÎÍÏÍÏÍÍÌÍÎÎÏÏÍÌÌÌÌÌÍ>k__BackingField; // 0x1D8
        public string ÎÏÎÏÌÌÍÎÏÎÏÍÎÍÌÌÎÏÏÎÎÎÏ; // 0x200
        public string ÍÌÍÍÍÍÌÌÍÍÍÌÎÏÌÌÏÏÌÍÍÍÏ; // 0x208
        public System.Action ÍÎÌÎÍÌÍÍÏÌÎÍÌÌÎÎÏÌÌÌÌÍÎ; // 0x210
        public VRC.Core.ApiUserPermissions ÌÍÏÌÎÍÎÌÌÏÌÎÎÏÍÌÌÌÏÍÍÌÏ; // 0x218
        public System.Action ÏÍÍÎÎÎÍÎÎÍÌÌÎÏÍÎÌÍÌÌÎÏÎ; // 0x18
        public 0x664D07E0 <ÌÌÏÏÌÌÎÏÎÍÏÌÎÏÍÏÌÏÎÏÎÏÌ>k__BackingField; // 0x20
        public 0x664D0838 <ÎÎÍÎÎÌÏÍÎÍÌÌÍÌÎÍÏÏÏÌÏÏÏ>k__BackingField; // 0x28
        public System.Action`1<0x664D0890> ÍÍÎÌÏÌÍÌÎÍÎÎÎÍÏÏÎÎÍÎÍÌÍ; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EE3D120
        public void Equals(){} // RVA: 0x7FFD4EE3D440
        public void GetHashCode(){} // RVA: 0x7FFD4E36F0C0
        public void op_Implicit(){} // RVA: 0x7FFD4EE3D4F0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EE3D650
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EE3D710
        public void GetCachedPtr(){} // RVA: 0x7FFD4EE3D7F0
        public void get_name(){} // RVA: 0x7FFD4EE3D8B0
        public void set_name(){} // RVA: 0x7FFD4EE3D910
        public void Instantiate(){} // RVA: 0x7FFD4EE3D9A0
        public void ToString(){} // RVA: 0x7FFD4EE3DD10
        public void EnqueueMatchmaking(){} // RVA: 0x7FFD4EE3E2A0
        public void CleanupLookupTable(){} // RVA: 0x7FFD4EE3E2F0
        public void GetPPLayer(){} // RVA: 0x7FFD4EE3E6B0
        public void CleanupLookupTable_703BE601D5A7(){} // RVA: 0x7FFD4EE3E760
        public void CleanupLookupTable_FD4F96F4D506(){} // RVA: 0x7FFD4EE3E7B0
        public void GetInnerStruct(){} // RVA: 0x7FFD4EE3E830
        public void SetCurrentSocket(){} // RVA: 0x7FFD4EE3E890
        public void CloneSingle(){} // RVA: 0x7FFD4EE3E910
        public void Destroy(){} // RVA: 0x7FFD4EE3EC30
        public void GetInnerStructA(){} // RVA: 0x7FFD4E426850
        public void DestroyImmediate(){} // RVA: 0x7FFD4EE3F070
        public void DestroyImmediate_0A4AACBCA6E3(){} // RVA: 0x7FFD4EE3F1F0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4EE3F290
        public void ovr_Matchmaking_Enqueue2_Native(){} // RVA: 0x7FFD4EE3F2E0
        public void FindObjectsByType(){} // RVA: 0x7FFD4EE3F340
        public void GetItemByIndex(){} // RVA: 0x7FFD4EE3F550
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EE3F600
        public void get_hideFlags(){} // RVA: 0x7FFD4EE3F660
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void GetPPLayer_C752425E6A58(){} // RVA: 0x7FFD4EE3F6B0
        public void FindObjectOfType(){} // RVA: 0x7FFD4EE3F990
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4EE3FA80
        public void GetItemByIndex_D8955063B4E8(){} // RVA: 0x7FFD4EE3FB20
        public void CheckNullArgument(){} // RVA: 0x7FFD4EE3FCB0
        public void CheckNullArgument_4C3667424D03(){} // RVA: 0x7FFD4EE3FD10
        public void AddSubtraction_F5B20CE87DD4(){} // RVA: 0x7FFD4EE3FDC0
        public void ValidateInnerStruct(){} // RVA: 0x7FFD4EE3FE60
        public void CloneObject(){} // RVA: 0x7FFD4EE3FF00
        public void IsSocketConnected(){} // RVA: 0x7FFD4EE3FF70
        public void op_Equality(){} // RVA: 0x7FFD4E36F0D0
        public void op_Inequality(){} // RVA: 0x7FFD4EE40050
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4EE40300
        public void Internal_CloneSingle(){} // RVA: 0x7FFD4EE40350
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4EE404B0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFD4EE40510
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFD4EE40600
        public void GetInnerStructB(){} // RVA: 0x7FFD4E426850
        public void GetName(){} // RVA: 0x7FFD4EE406A0
        public void SetName(){} // RVA: 0x7FFD4EE40740
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD4EE407C0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFD4EE40820
        public void SetName_B5873D639C9C(){} // RVA: 0x7FFD4EE408D0
        public void DoSetPositionAndRotation_Injected_06E(){} // RVA: 0x7FFD4EE40C80
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFD4EE40CE0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFD4EE40D60
        public void SerializeEventFields(){} // RVA: 0x7FFD4EE40DC0
        public void GetCachedPtr_49E8872C2EE8(){} // RVA: 0x7FFD4EE40EC0
        public void GetMatchID(){} // RVA: 0x7FFD4EE40F20
        public void SyncTransform(){} // RVA: 0x7FFD4EE412D0
        public void SyncPosition(){} // RVA: 0x7FFD4EE41330
        public void SyncTransform_2A48EB1CA4F0(){} // RVA: 0x7FFD4EE414F0
        public void UpdatePosition(){} // RVA: 0x7FFD4EE41550
        public void AddMatchModifier(){} // RVA: 0x7FFD4EE419C0
        public void CompareBaseObjects_D783F1E5501E(){} // RVA: 0x7FFD4EE41C30
        public void DoSetPositionAndRotation_Injected_662(){} // RVA: 0x7FFD4EE41D10
        public void DoSetPositionAndRotation_Injected_662_4D1AA11B23A1(){} // RVA: 0x7FFD4EE41E00
        public void DoSendGetRequest(){} // RVA: 0x7FFD4EE41EE0
        public void SubtractMatchModifier(){} // RVA: 0x7FFD4EE41F60
        public void ConnectToSocket(){} // RVA: 0x7FFD4EE41FC0
        public void DisconnectSocket(){} // RVA: 0x7FFD4EE42080
        public void ResetLookupTable(){} // RVA: 0x7FFD4E341320
        public void FetchMatchmakingData(){} // RVA: 0x7FFD4EE420D0
        public void ParseInnerStructA(){} // RVA: 0x7FFD4EE421D0
        public void ProcessLookupTableEntry(){} // RVA: 0x7FFD4EE42250
        public void OnPreRender(){} // RVA: 0x7FFD4EE42600
        public void CompareBaseObjects_C4D611948AE8(){} // RVA: 0x7FFD4EE426C0
        public void UnPack(){} // RVA: 0x7FFD4EE42760
        public void HasChanged_F418B4F6B8A3(){} // RVA: 0x7FFD4EE43F40 | overloaded x2
        public void GetTransformHash(){} // RVA: 0x7FFD4EE428D0
        public void .cctor(){} // RVA: 0x7FFD4EE429B0
        public void PrepareConcurrentSystemUpdate(){} // RVA: 0x7FFD4EE43040
        public void PerformConcurrentSystemUpdate(){} // RVA: 0x7FFD4EE430E0
        public void UpdateGameObjectProperties(){} // RVA: 0x7FFD4EE43180
        public void IsNativeObjectAlive_9B0B58BF08BF(){} // RVA: 0x7FFD4EE432F0
        public void InitializeStateComponent(){} // RVA: 0x7FFD4EE43390
        public void .ctor(){} // RVA: 0x7FFD4EE43400
        public void Initialize(){} // RVA: 0x7FFD4EE434C0
        public void RetrieveTransformSystemStatus(){} // RVA: 0x7FFD4EE43560
        public void RetrieveTransformSystemStatus_9955C0E0D0EC(){} // RVA: 0x7FFD4EE435C0
        public void RetrieveTransformSystemStatus_754E53E1A9F7(){} // RVA: 0x7FFD4EE43620
        public void UpdateTransformState(){} // RVA: 0x7FFD4EE436A0
        public void InitializeTransformState(){} // RVA: 0x7FFD4EE43750
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD4EE438D0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_20E6C4A520E1(){} // RVA: 0x7FFD4EE43980
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_87AC3BDD4F0A(){} // RVA: 0x7FFD4EE439D0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_95FE6D8AFD96(){} // RVA: 0x7FFD4EE43A70
        public void GetTransformStateStatus(){} // RVA: 0x7FFD4EE43D70
        public void UpdateModifiedState(){} // RVA: 0x7FFD4EE43E70
        public void IsModified(){} // RVA: 0x7FFD4EE43EC0
        public void RefreshChangeState(){} // RVA: 0x7FFD4EE44730
        public void UpdateSystemState(){} // RVA: 0x7FFD4EE44790
        public void PrepareAtomicGameObjectReference(){} // RVA: 0x7FFD4EE45460
        public void UpdateAtomicGameObjectReference(){} // RVA: 0x7FFD4EE45530
        public void ReadTransformRelatedData(){} // RVA: 0x7FFD4EE45650
        public void SetTransformRelatedPointerAndFlag(){} // RVA: 0x7FFD4EE45A40
        public void InitializeLocalTransform(){} // RVA: 0x7FFD4EE45AC0
        public void ProcessSystemRelatedData(){} // RVA: 0x7FFD4EE45B80
        public void ApplyLocalTransform(){} // RVA: 0x7FFD4EE45C30
        public void AttachTransformAndSetLocalPose(){} // RVA: 0x7FFD4EE45CB0
        public void GetUnityEngine(){} // RVA: 0x7FFD4EE45D10
        public void UpdateDetailsPanelState(){} // RVA: 0x7FFD4EE462B0
        public void RefreshDetailsPanel(){} // RVA: 0x7FFD4EE46310
        public void GetDetailsPanelState(){} // RVA: 0x7FFD4EE46370
        public void get_name_F23B61291488(){} // RVA: 0x7FFD4EE463F0
        public void InitializeMatchmaking(){} // RVA: 0x7FFD4E341320
        public void get_deltaTime(){} // RVA: 0x7FFD4EE46CB0
        public void ComputeNow(){} // RVA: 0x7FFD4EE46E60
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void GetSystemInitializationFlag(){} // RVA: 0x7FFD4EE47720
        public void GetUnityEngine_800D12(){} // RVA: 0x7FFD4EE47AD0 | overloaded x2
        public void GetUnityEngine_B8A25CD10968(){} // RVA: 0x7FFD4EE47900
        public void GetGameObjectTransform(){} // RVA: 0x7FFD4EE47950
        public void PrepareUIElementComparison(){} // RVA: 0x7FFD4EE479D0
        public void PerformUIElementComparison(){} // RVA: 0x7FFD4EE47D80
        public void SetLocalPosition(){} // RVA: 0x7FFD4EE47E50
        public void GetLocalRotation(){} // RVA: 0x7FFD4EE47F00
        public void ReadTransformState(){} // RVA: 0x7FFD4EE47FF0
        public void print(){} // RVA: 0x7FFD4EE48080
        public void GetMaterialRenderer(){} // RVA: 0x7FFD4EE482D0
        public void ClampRotationBlend(){} // RVA: 0x7FFD4EE49070
        public void PrepareSetParent(){} // RVA: 0x7FFD4EE49120
        public void SetParent(){} // RVA: 0x7FFD4EE491A0
        public void ResolveParentTransform(){} // RVA: 0x7FFD4EE49540
        public void ResolveTransformParent(){} // RVA: 0x7FFD4EE49590
        public void DoFetchUser(){} // RVA: 0x7FFD4EE49610
        public void SetTransformParent(){} // RVA: 0x7FFD4EE496D0
        public void SetParent_6CE3C066ED5F(){} // RVA: 0x7FFD4EE497B0
        public void UpdateMaterialFloat(){} // RVA: 0x7FFD4EE49810
        public void UpdateMaterialFloatCurrent(){} // RVA: 0x7FFD4EE498B0
        public void SetLocalPositionAnimated(){} // RVA: 0x7FFD4EE49AC0
        public void SetLocalPositionCurrent(){} // RVA: 0x7FFD4EE49B10
        public void SetActive_F2D(){} // RVA: 0x7FFD4EE4A0B0
        public void SerializeNetworkObjectWithFlags(){} // RVA: 0x7FFD4EE4A100
        public void LateUpdate(){} // RVA: 0x7FFD4EE4A150
        public void RefreshState(){} // RVA: 0x7FFD4EE4A700
    }

    /// <summary>Originally: ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎÌÎÎ</summary>
    public class MajorSystem_13C5 : MonoBehaviour
    {
        public string _destroyCancellationToken;
        public string _useGUILayout;
        public string f_66C;
        public string f_A68;
        public string f_61C;
        public string f_630;
        public string f_AD1;
        public string f_798;
        public string f_4BC;
        public string f_E72;
        public string f_122;
        public string ÏÍÍÎÌÎÍÏÍÍÍÌÎÏÌÎÎÏÎÏÍÍÍ;
        public string ÎÏÌÏÌÎÎÍÌÍÏÎÎÏÍÏÌÍÎÌÎÍÌ;
        public float ÏÍÏÌÌÎÎÏÏÎÏÎÎÌÌÏÏÎÍÎÎÍÎ;
        public bool ÍÌÏÍÌÎÍÎÎÏÏÏÎÎÎÍÏÌÎÍÌÍÌ;
        public bool ÌÏÌÏÎÎÌÍÏÍÏÌÎÎÎÍÌÎÍÏÎÌÎ;
        public System.Action ÍÏÏÍÏÎÎÍÎÏÌÍÎÍÌÏÌÌÌÎÏÌÌ;
        public ÍÍÎÌÏÎÎÌÍÎÏÏÎÏÏÎÍÎÎÌÌÏÎ ÏÌÎÌÍÍÏÍÍÏÏÍÌÏÏÍÍÏÌÎÎÍÍ; // 0x20
        public bool ÍÎÎÍÌÍÏÎÌÍÍÌÎÎÎÍÌÌÍÌÍÍÏ; // 0x28
        public string ÍÎÍÍÏÎÎÎÏÎÎÎÌÌÍÌÌÌÎÍÏÌÌ; // 0x8
        public int ÏÍÎÎÌÌÏÎÏÍÎÏÌÏÌÏÎÌÌÎÌÍÎ; // 0x2C
        public int ÏÌÌÍÍÍÏÍÌÏÍÌÏÍÏÍÏÌÏÎÍÍÎ; // 0x30
        public int ÏÎÌÍÌÎÎÍÎÌÏÎÏÏÏÌÌÎÍÏÎÏÌ; // 0x34
        public int ÎÌÌÍÌÏÎÌÍÍÏÌÎÍÎÏÎÌÍÏÏÏÏ; // 0x38
        public int ÌÌÍÏÌÌÌÍÍÎÌÏÎÏÏÏÍÍÌÏÍÏÎ; // 0x3C
        public int ÎÎÎÌÎÍÏÎÎÏÍÎÏÏÍÍÌÍÏÍÎÍÍ; // 0x40
        public System.Collections.Generic.HashSet`1<string> ÏÍÌÍÏÍÍÏÌÌÏÍÏÏÏÎÌÏÍÌÏÌÌ; // 0x10
        public System.Collections.Generic.Dictionary`2<9,string> ÏÍÏÍÌÎÎÏÍÌÏÏÎÌÎÍÌÍÏÌÌÌÍ; // 0x18
        public ulong ÎÎÏÏÌÎÏÌÎÍÏÍÏÏÎÎÍÌÎÍÎÎÌ; // 0x48
        public float ÍÏÌÍÎÎÎÎÍÍÍÏÍÎÏÍÎÍÌÎÏÍÌ; // 0x50
        public float ÌÌÎÍÏÎÏÎÌÏÏÎÌÎÌÍÍÌÏÎÏÎÍ;
        public int ÎÎÏÍÏÎÌÏÎÎÌÎÍÏÌÎÌÏÌÌÎÌÏ; // 0x54
        public string ÏÏÎÌÎÏÍÏÍÎÍÎÌÍÎÎÍÏÍÏÎÏÍ; // 0x20
        public string ÎÎÍÏÏÎÎÍÎÍÏÌÎÍÏÏÏÌÎÍÍÍÌ; // 0x28
        public VRC.Core.ApiWorld ÏÍÍÎÏÌÍÍÍÌÌÍÌÏÍÍÎÌÌÍÌÌÌ; // 0x30
        public VRC.Core.ApiWorldInstance ÌÏÌÏÍÍÏÍÏÏÏÏÌÌÎÌÎÎÎÎÏÎÎ; // 0x38
        public System.Collections.Generic.Dictionary`2<string,object> ÏÎÏÏÍÌÌÎÎÍÎÍÏÌÌÏÏÍÎÎÎÎÌ; // 0x40
        public System.Collections.Generic.Dictionary`2<string,object> ÌÏÌÎÌÏÌÍÍÍÎÏÏÌÎÌÏÏÌÌÏÌÌ; // 0x48
        public System.Collections.Generic.HashSet`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÏÏÏÏÎÌÌÌÌÍÎÏÍÏÌÌÏÎÍÍÌÎÍ; // 0x50
        public System.Collections.Generic.HashSet`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÌÌÌÍÌÍÏÎÍÏÎÎÎÍÌÍÌÍÏÌÏÏÏ; // 0x58
        public System.Collections.Generic.HashSet`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÌÎÍÏÍÍÍÏÏÌÌÎÍÏÍÏÎÍÏÎÍÍÏ; // 0x60
        public System.Collections.Generic.HashSet`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÌÎÌÌÏÏÎÎÌÌÎÏÎÎÎÏÌÍÌÎÎÌÏ; // 0x68
        public System.Collections.Generic.List`1<string> ÎÍÌÏÌÌÎÍÏÌÎÏÏÎÎÏÎÏÎÎÎÌÏ; // 0x58
        public VRC.Core.ApiWorld ÏÏÎÏÏÎÎÏÍÎÏÎÏÎÌÏÍÎÎÎÏÎÏ; // 0x70
        public VRC.Core.ApiWorldInstance ÌÎÌÎÏÎÌÌÏÏÎÎÌÏÎÎÎÍÏÏÏÎÍ; // 0x78
        public bool ÏÍÌÎÎÎÌÍÌÍÍÏÏÍÍÌÌÏÏÏÌÎÎ; // 0x80
        public int ÎÌÏÎÏÍÌÌÌÍÏÌÌÌÌÎÎÍÏÎÍÍÎ; // 0x84
        public int ÍÍÍÎÏÍÌÌÏÎÏÍÍÎÍÍÍÌÏÍÎÎÌ; // 0x88
        public int ÍÎÏÏÍÎÌÏÏÎÌÌÏÍÏÎÍÍÌÏÍÎÏ; // 0x8C
        public int ÌÏÌÌÌÌÌÌÌÎÎÍÏÍÎÍÍÎÍÏÌÌÎ; // 0x90
        public int ÎÍÌÎÎÍÎÎÍÎÏÍÍÍÏÏÏÏÍÏÎÏÎ; // 0x94
        public int ÍÌÏÏÌÍÎÎÏÏÍÎÌÎÌÍÎÏÎÍÍÏÌ; // 0x98
        public int ÎÍÎÌÎÍÍÏÏÎÎÍÏÌÍÍÏÎÍÎÍÎÍ; // 0x9C
        public int ÌÌÎÌÌÌÎÌÍÌÌÍÍÌÎÌÎÏÍÎÏÍÏ; // 0xA0
        public int ÍÍÏÎÍÎÏÏÌÌÎÏÎÌÎÍÏÏÌÎÎÏÏ; // 0xA4
        public int ÍÎÎÌÌÍÍÌÏÍÍÌÍÍÎÍÏÏÌÏÏÌÏ; // 0xA8
        public int ÏÍÎÎÏÎÌÎÍÌÌÍÍÌÍÎÎÎÎÍÎÎÍ; // 0xAC
        public int ÌÌÍÍÏÍÏÎÎÍÏÌÎÎÎÍÍÍÎÍÌÌÎ; // 0xB0
        public int ÎÌÌÌÏÌÌÍÍÏÍÏÍÎÏÌÏÍÍÏÌÍÎ; // 0xB4
        public int ÎÏÎÏÏÎÍÌÌÌÎÍÍÎÎÎÍÌÍÏÏÏÎ; // 0xB8
        public int ÏÎÎÏÌÌÍÌÍÌÌÍÌÎÍÏÍÏÍÌÌÎÎ; // 0xBC
        public int ÍÌÎÌÎÎÌÌÎÏÎÌÍÏÌÏÏÎÌÍÍÏÎ; // 0xC0
        public int ÎÍÏÎÏÏÌÍÏÏÎÌÍÏÏÌÍÍÌÌÌÌÍ; // 0xC4
        public int ÏÏÎÏÏÌÍÌÌÏÌÏÍÍÍÍÍÏÏÌÏÍÎ; // 0xC8
        public int ÎÏÏÌÍÏÎÍÍÏÏÌÌÎÌÌÌÌÎÌÏÍÌ; // 0xCC
        public int ÎÎÎÎÌÌÍÏÎÌÍÎÌÏÍÌÎÏÎÍÍÌÌ; // 0xD0
        public int ÌÎÍÍÌÍÏÍÌÎÌÌÎÏÍÏÏÌÎÎÏÍÌ; // 0xD4
        public int ÌÏÏÏÏÎÎÍÎÎÌÏÌÍÌÍÎÏÎÍÏÌÏ; // 0xD8
        public System.Collections.Generic.List`1<string> ÌÍÎÌÌÍÏÏÍÌÏÍÍÍÍÍÏÍÏÍÏÌÎ; // 0xE0
        public int ÏÍÏÎÎÍÍÍÌÍÌÏÎÌÍÎÎÏÍÎÍÎÏ; // 0xE8
        public int ÎÏÏÍÌÏÎÏÌÏÏÌÌÎÎÏÍÌÌÎÎÎÎ; // 0xEC
        public int ÌÏÍÌÌÍÍÏÌÍÎÏÍÌÏÍÏÎÍÎÏÍÏ; // 0xF0
        public int ÍÌÍÌÎÎÎÎÍÎÎÏÍÏÎÏÎÌÎÌÏÎÏ; // 0xF4
        public int ÏÌÎÌÌÏÎÏÌÌÍÎÏÍÎÎÍÎÎÍÌÎÎ; // 0xF8
        public int ÏÏÎÎÍÏÌÌÎÌÌÏÏÌÍÌÌÍÏÏÍÎÎ; // 0xFC
        public bool ÍÎÏÏÏÏÌÌÎÍÎÌÎÏÏÌÎÏÎÌÍÎÌ; // 0x100
        public bool ÌÏÎÎÍÏÎÏÏÍÍÍÎÍÌÏÏÎÍÌÏÍÍ; // 0x101
        public System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<string,object>> ÏÌÎÏÏÍÎÍÌÍÍÍÍÏÌÏÎÎÎÌÎÎÌ; // 0x108
        public System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<string,object>> ÍÎÎÍÏÍÌÎÌÏÏÏÏÌÎÍÎÌÍÍÍÍÌ; // 0x110
        public System.Collections.Generic.List`1<string> ÌÍÌÎÌÍÍÍÎÍÏÍÍÌÎÎÎÎÏÍÏÌÍ; // 0x118
        public System.Collections.Generic.List`1<string> ÏÎÏÌÌÌÍÌÏÌÏÌÏÌÍÍÎÎÍÏÎÏÎ; // 0x120
        public System.Collections.Generic.Dictionary`2<string,0x665B2DA0> ÎÍÎÏÎÎÌÏÍÍÍÍÎÍÍÌÏÌÍÏÌÎÎ; // 0x128
        public float ÍÏÏÏÎÌÌÎÌÏÎÏÏÍÌÍÎÌÎÎÍÍÍ; // 0x130
        public int ÍÎÏÍÍÌÏÎÍÌÌÍÎÏÏÌÌÎÏÏÏÌÏ; // 0x134
        public int ÌÍÍÎÎÎÎÌÌÎÎÌÎÎÍÏÏÌÏÌÍÏÎ; // 0x138
        public int ÌÍÏÎÌÌÍÎÎÌÏÎÎÌÌÍÏÏÎÏÍÎÍ; // 0x13C
        public int ÍÍÍÌÌÏÏÍÎÌÎÎÏÌÍÌÍÌÍÏÏÌÍ; // 0x140
        public int ÏÍÎÎÏÏÎÍÍÏÌÎÏÍÍÏÎÍÍÍÌÍÌ; // 0x144
        public int ÎÎÍÍÏÍÌÍÍÎÏÌÍÌÎÍÎÍÎÏÍÎÍ; // 0x148
        public int ÏÌÍÎÎÎÏÌÎÏÍÎÏÍÎÍÏÏÎÏÏÎÌ; // 0x14C
        public int ÏÎÌÌÏÎÌÌÍÌÎÏÌÌÍÎÎÍÎÎÍÎÏ; // 0x150
        public int ÏÍÍÌÌÏÍÍÌÏÍÏÏÌÍÏÏÏÎÌÍÌÍ; // 0x154
        public int ÎÎÍÏÎÌÏÌÌÎÎÏÏÌÌÎÌÌÍÏÎÌÌ; // 0x158
        public int ÎÍÎÌÏÏÍÌÎÍÎÏÍÍÍÏÍÍÏÏÎÏÎ; // 0x15C
        public int ÍÎÎÎÌÏÌÏÎÏÎÎÍÍÏÍÎÌÏÍÎÍÎ; // 0x160
        public int ÎÍÌÏÍÍÍÌÌÌÎÏÏÍÌÎÌÎÎÏÏÍÍ; // 0x164
        public int ÌÏÌÎÎÌÍÍÎÌÎÏÍÎÌÏÍÎÍÍÌÍÍ; // 0x168
        public int ÍÍÎÌÎÏÍÍÏÌÌÌÌÎÏÎÎÍÍÏÍÌÎ; // 0x16C
        public int ÌÌÍÏÍÏÌÎÏÎÌÎÎÍÏÌÌÌÌÍÌÎÍ; // 0x170
        public System.Collections.Generic.HashSet`1<string> ÏÎÍÎÏÍÍÍÎÎÌÍÌÎÏÍÍÎÍÎÌÏÍ; // 0x178
        public System.Collections.Generic.HashSet`1<string> ÏÍÎÌÌÏÌÌÍÏÎÌÍÌÏÌÌÌÌÌÌÏÌ; // 0x180
        public int ÌÍÎÏÏÌÌÏÎÎÏÌÍÏÍÏÍÏÌÏÏÏÏ; // 0x188
        public int ÌÍÎÎÏÎÌÍÏÏÏÎÏÎÌÌÏÏÍÎÏÎÏ; // 0x18C
        public System.Collections.Generic.HashSet`1<string> ÍÏÍÎÎÍÌÌÎÍÏÏÏÍÎÏÎÌÎÎÍÍÌ; // 0x190
        public System.Collections.Generic.HashSet`1<string> ÎÏÎÌÏÍÍÎÌÎÎÏÏÎÎÌÌÏÍÎÎÍÏ; // 0x198
        public System.Collections.Generic.HashSet`1<string> ÎÍÌÎÎÍÎÎÍÎÌÌÎÌÌÍÍÌÌÎÍÎÎ; // 0x1A0
        public System.Collections.Generic.Dictionary`2<string,ÌÌÌÏÎÍÌÌÎÏÍÍÎÎÎÏÏÍÎÌÌÎÌ> ÍÍÍÌÏÏÏÎÏÍÎÍÍÏÎÍÎÎÍÏÌÎÍ; // 0x1A8
        public int ÎÌÍÌÌÎÌÍÍÎÍÌÏÌÌÍÌÌÌÏÏÍÌ; // 0x1B0
        public System.Collections.Generic.Dictionary`2<string,int> ÍÌÌÍÍÏÎÌÏÎÎÎÍÎÌÎÌÍÌÎÎÎÎ; // 0x1B8
        public bool ÌÌÍÍÏÏÌÎÌÍÏÏÏÏÎÌÎÍÌÌÍÌÌ; // 0x60
        public ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎÌÎÎ <ÌÍÍÌÌÍÏÏÍÌÎÌÌÍÏÏÌÌÎÍÌÌÏ>k__BackingField; // 0x1C0
        public string ÍÍÏÍÌÌÌÍÌÎÎÎÍÎÎÏÍÎÎÏÏÍÏ; // 0x1C8
        public string ÏÎÌÌÎÌÌÌÍÏÌÍÍÍÌÍÍÎÏÏÏÍÏ; // 0x1D0
        public bool ÍÏÌÏÎÏÌÏÌÎÏÎÏÌÌÏÏÏÎÏÎÏÏ; // 0x1D8
        public bool ÍÌÎÏÎÌÌÌÌÎÌÎÎÏÎÍÎÌÍÍÍÏÏ; // 0x1D9
        public System.Collections.Generic.Dictionary`2<string,int> ÏÏÎÎÎÌÏÍÍÎÎÌÍÎÌÏÏÏÍÌÌÏÎ; // 0x68
        public int ÌÍÍÍÌÍÌÏÏÍÎÍÍÍÏÌÎÍÍÌÍÍÏ; // 0x70
        public int ÌÍÏÏÍÍÍÎÎÍÏÍÎÎÏÌÏÎÌÌÌÌÏ; // 0x74
        public int ÌÏÍÍÎÏÌÏÍÍÍÏÍÏÌÌÏÌÏÌÍÏÎ; // 0x78
        public int ÎÏÎÍÏÎÍÎÍÏÎÌÍÌÎÏÍÌÌÍÏÌÍ; // 0x7C
        public string ÏÍÏÎÌÍÎÏÌÎÌÎÏÌÎÎÏÏÌÍÌÌÍ;
        public float ÍÏÍÏÌÏÎÎÎÏÎÎÌÌÎÎÌÏÌÌÌÏÌ; // 0x1DC
        public float ÌÍÍÍÎÍÌÌÌÎÍÍÍÏÎÌÌÍÎÍÎÎÍ; // 0x1E0
        public float ÏÏÏÌÎÏÌÎÏÏÍÍÍÌÎÌÍÌÌÎÎÍÏ; // 0x1E4
        public int ÏÏÍÌÎÏÌÌÍÍÍÏÍÏÎÍÏÎÍÌÍÍÌ; // 0x1E8
        public int ÎÏÌÏÌÌÌÍÎÌÎÌÌÌÏÎÎÏÍÍÍÌÏ; // 0x1EC
        public int ÍÏÌÌÏÏÎÎÍÌÏÏÎÍÌÏÏÏÌÏÏÍÌ; // 0x1F0
        public int ÎÎÎÏÎÎÍÏÎÌÎÏÍÍÌÍÍÎÏÏÎÍÍ; // 0x1F4
        public string ÌÌÏÌÎÍÍÎÌÎÏÌÎÍÍÌÌÍÍÍÍÌÍ; // 0x1F8
        public string ÏÎÍÌÍÌÌÌÍÍÎÍÏÎÌÍÍÏÏÌÌÎÎ; // 0x200
        public string ÏÏÍÍÏÏÍÏÎÎÌÍÏÍÍÎÌÍÏÎÏÍÍ; // 0x208
        public string ÍÏÎÌÎÌÏÎÍÌÍÍÌÌÌÏÏÏÎÍÏÏÏ;
        public string ÏÍÎÍÏÏÍÍÌÌÎÎÎÍÍÎÎÍÍÎÍÌÌ;
        public string ÎÍÎÎÏÍÍÏÏÎÏÍÏÌÍÎÍÍÏÍÌÍÏ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EF03FD0
        public void RaiseCancellation(){} // RVA: 0x7FFD4EF042E0
        public void IsInvoking(){} // RVA: 0x7FFD4EF04350
        public void CancelInvoke(){} // RVA: 0x7FFD4EF044A0
        public void Invoke(){} // RVA: 0x7FFD4EF04570
        public void InvokeRepeating(){} // RVA: 0x7FFD4EF04600
        public void CancelInvoke_5EA3A7BB1869(){} // RVA: 0x7FFD4EF046B0
        public void IsInvoking_D259F43C9F9E(){} // RVA: 0x7FFD4EF047B0
        public void StartCoroutine(){} // RVA: 0x7FFD4EF04960
        public void StartCoroutine_0D9AC8F33130(){} // RVA: 0x7FFD4EF04A60
        public void StartCoroutine_A319F0ED388B(){} // RVA: 0x7FFD4EF04BA0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EF054B0
        public void StopCoroutine(){} // RVA: 0x7FFD4EF05560
        public void StopCoroutine_1810C56B1D2B(){} // RVA: 0x7FFD4EF05630
        public void StopCoroutine_30D31850AE56(){} // RVA: 0x7FFD4EF057C0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EF05B70
        public void get_useGUILayout_7885EC916CC2(){} // RVA: 0x7FFD4EF0A030 | overloaded x2
        public void set_useGUILayout(){} // RVA: 0x7FFD4EF05DD0
        public void print(){} // RVA: 0x7FFD4EF05E30
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EF06220
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4EF06280
        public void .cctor(){} // RVA: 0x7FFD4EF06380
        public void CancelInvoke_D85AA0D3BE00(){} // RVA: 0x7FFD4EF09350
        public void GetSyncState(){} // RVA: 0x7FFD4EF0C450 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EF09550
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EF09560
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4EF095C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4EF09660
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4EF09890
        public void GetScriptClassName(){} // RVA: 0x7FFD4EF09DA0
        public void Awake_6C6520E2AAD4(){} // RVA: 0x7FFD4EF09EA0
        public void SyncPosition(){} // RVA: 0x7FFD4EF0A290
        public void InvertRotationTarget_EAC320DE2127(){} // RVA: 0x7FFD4EF0A470 | overloaded x2
        public void SyncTransform(){} // RVA: 0x7FFD4EF0A410
        public void Start_A9380F11B761(){} // RVA: 0x7FFD4EF0A530
        public void SyncTransform_028D2D418B23(){} // RVA: 0x7FFD4EF0AB50
        public void SyncAnimatorGoalRotation_3A87FD2D23D2(){} // RVA: 0x7FFD4EF35A50 | overloaded x2
        public void SyncScale(){} // RVA: 0x7FFD4EF0ADF0
        public void ReadTransformPosition(){} // RVA: 0x7FFD4EF0AE50
        public void CopyRotation(){} // RVA: 0x7FFD4EF0B0E0
        public void ReadTransformScale(){} // RVA: 0x7FFD4EF0B8F0
        public void ReadTransformRotation(){} // RVA: 0x7FFD4EF0B990
        public void MultiplyQuaternionVector(){} // RVA: 0x7FFD4EF0BAE0
        public void SetRotation(){} // RVA: 0x7FFD4EF0BC00
        public void FixedUpdate(){} // RVA: 0x7FFD4EF0BE00
        public void SetRotationCurrent(){} // RVA: 0x7FFD4EF0BF40
        public void GetUnityEngine(){} // RVA: 0x7FFD4EF0C600
        public void OnDestroy(){} // RVA: 0x7FFD4EF0C660
        public void OnApplicationPause(){} // RVA: 0x7FFD4EF0CD70
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EF0D0A0
        public void OnBecameVisible(){} // RVA: 0x7FFD4EF0D410
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EF0D4D0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4EF0D750
        public void OnCollisionStay(){} // RVA: 0x7FFD4EF0DB50
        public void OnCollisionExit(){} // RVA: 0x7FFD4EF1AA50 | overloaded x5
        public void OnTriggerEnter(){} // RVA: 0x7FFD4EF0DC70
        public void OnTriggerStay(){} // RVA: 0x7FFD4EF0E200
        public void OnTriggerExit(){} // RVA: 0x7FFD4EF0E2C0
        public void StartCoroutine_Auto_E54C0D05B25A(){} // RVA: 0x7FFD4EF0E360
        public void DoGetIntegerString_7BC(){} // RVA: 0x7FFD4EF0E590
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7FFD4EF0E8B0
        public void UpdateUiComponentState(){} // RVA: 0x7FFD4EF0E9F0
        public void CopyPosition(){} // RVA: 0x7FFD4EF0EAF0
        public void EnsureInitialized(){} // RVA: 0x7FFD4EF0EEC0
        public void Awake(){} // RVA: 0x7FFD4EF0EF40
        public void ResetOffsets(){} // RVA: 0x7FFD4EF0F660
        public void CopyScale(){} // RVA: 0x7FFD4EF101E0
        public void UpdateSync(){} // RVA: 0x7FFD4EF104E0
        public void RefreshState(){} // RVA: 0x7FFD4EF10790
        public void InitializeSync(){} // RVA: 0x7FFD4EF10A80
        public void ResetSync(){} // RVA: 0x7FFD4EF2C4D0 | overloaded x2
        public void ClearSync(){} // RVA: 0x7FFD4EF10B60
        public void ClearConstraintReferences(){} // RVA: 0x7FFD4EF11500
        public void ApplyAnimatedProperties(){} // RVA: 0x7FFD4EF11560
        public void OnDisable_FDDA990B161C(){} // RVA: 0x7FFD4EF11BD0
        public void CopyAsyncState(){} // RVA: 0x7FFD4EF12190
        public void ApplySync(){} // RVA: 0x7FFD4EF12670
        public void Update_93B00B0D2914(){} // RVA: 0x7FFD4EF126E0
        public void FindObjectsByType(){} // RVA: 0x7FFD4EF127C0
        public void InitializeTransformStatics(){} // RVA: 0x7FFD4EF12C10
        public void SetComponentFlags(){} // RVA: 0x7FFD4EF12D90
        public void SetSyncFlags(){} // RVA: 0x7FFD4EF12E90
        public void SyncTransform_913FFF9B2796(){} // RVA: 0x7FFD4EF12F30
        public void SetEnabled_CB1(){} // RVA: 0x7FFD4EF302E0 | overloaded x3
        public void get_gameObject(){} // RVA: 0x7FFD4EF130F0
        public void ComputeParent(){} // RVA: 0x7FFD4EF13160
        public void ResolveGameObject(){} // RVA: 0x7FFD4EF134B0
        public void .ctor(){} // RVA: 0x7FFD4EF13A20
        public void Initialize(){} // RVA: 0x7FFD4EF13BB0
        public void Update_F3D3FAFD7C92(){} // RVA: 0x7FFD4EF13C80
        public void ValidateInputs(){} // RVA: 0x7FFD4EF13F30
        public void SetSyncState(){} // RVA: 0x7FFD4EF13FD0
        public void SyncAnimatorGoalPosition(){} // RVA: 0x7FFD4EF13FF0
        public void SyncAnimatorGoalScale(){} // RVA: 0x7FFD4EF142B0
        public void get_enabled(){} // RVA: 0x7FFD4EF14FA0
        public void UpdatePlayerStatusDisplay(){} // RVA: 0x7FFD4EF15060
        public void get_simulationMode(){} // RVA: 0x7FFD4EF15270
        public void ComputegameObject(){} // RVA: 0x7FFD4E922FD0
        public void get_simulationMode_2E9E81CC8AF4(){} // RVA: 0x7FFD4EF153B0
        public void get_simulationMode_F8B2CB9C342B(){} // RVA: 0x7FFD4EF15450
        public void AssignManagedReference(){} // RVA: 0x7FFD4EF154E0
        public void get_simulationMode_763D8B148E2F(){} // RVA: 0x7FFD4EF157D0
        public void InvertPositionTarget(){} // RVA: 0x7FFD4EF15C10
        public void SetFlagsFromBytes(){} // RVA: 0x7FFD4EF15D50
        public void StartCoroutine_Auto_0C41598B8113(){} // RVA: 0x7FFD4EF15E90
        public void UpdateUiComponentState_B8714A4E151F(){} // RVA: 0x7FFD4EF15F30
        public void get_simulationMode_31A80B05BE90(){} // RVA: 0x7FFD4EF16600
        public void SetBehaviourEnabled(){} // RVA: 0x7FFD4EF16880
        public void InvertScaleTarget(){} // RVA: 0x7FFD4EF16900
        public void InvertRotationCurrent(){} // RVA: 0x7FFD4EF171B0
        public void GetParentTransform(){} // RVA: 0x7FFD4EF17340
        public void SyncPoseFromRotationCurrent_8E52080BBB67(){} // RVA: 0x7FFD4EF22A20 | overloaded x2
        public void SetFirstBlendWeight(){} // RVA: 0x7FFD4EF17C30
        public void SetSecondBlendWeight(){} // RVA: 0x7FFD4EF17E20
        public void StopCoroutine_8F191FDB76BF(){} // RVA: 0x7FFD4EF17F40
        public void ResetMaterialProperty(){} // RVA: 0x7FFD4EF180D0
        public void GetTransform_EC5(){} // RVA: 0x7FFD4EF18450
        public void InvertRotation(){} // RVA: 0x7FFD4EF189A0
        public void GetUnityEngine_F4C08534B484(){} // RVA: 0x7FFD4EF18A00
        public void CreateInverseEulerRotation(){} // RVA: 0x7FFD4EF18B40
        public void CachePropertyIDs(){} // RVA: 0x7FFD4EF18C80
        public void SyncTransformRotation(){} // RVA: 0x7FFD4EF18D40
        public void SyncTransformPosition(){} // RVA: 0x7FFD4EF18DA0
        public void GetComponentTransform(){} // RVA: 0x7FFD4EF18F90
        public void OnTriggerExit_06B8CEA73CF4(){} // RVA: 0x7FFD4EF19030
        public void GetTransformPosition(){} // RVA: 0x7FFD4EF191C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EF1A580
        public void SyncTransformScale(){} // RVA: 0x7FFD4EF1A5E0
        public void ComputeRotationAverage(){} // RVA: 0x7FFD4EF1A760
        public void UpdateTransformPose(){} // RVA: 0x7FFD4EF34B60 | overloaded x3
        public void Update(){} // RVA: 0x7FFD4EF1AAC0
        public void iplHRTFCreate_6ABB41DEFCCE(){} // RVA: 0x7FFD4EF33470 | overloaded x2
        public void EvaluateRotationDelta(){} // RVA: 0x7FFD4EF1AE20
        public void TransformDirection(){} // RVA: 0x7FFD4EF1AE30
        public void TransformPointToCurrentPose(){} // RVA: 0x7FFD4EF1AF50
        public void UpdateTransformPose_9250B3AB81D2(){} // RVA: 0x7FFD4EF1B000
        public void UpdatePoseFromRotationDelta(){} // RVA: 0x7FFD4EF1B1B0
        public void InvertRotation_4B9E4A0D8C37(){} // RVA: 0x7FFD4EF1B690
        public void ComputeAngularVelocity(){} // RVA: 0x7FFD4EF1B970
        public void SetAngularVelocity(){} // RVA: 0x7FFD4EF1BB70
        public void SetAngularVelocityCurrent(){} // RVA: 0x7FFD4EF1C290
        public void ApplyAngularVelocityCurrent(){} // RVA: 0x7FFD4EF1C3A0
        public void GetComponentTransform_4FF90CE419A4(){} // RVA: 0x7FFD4EF1C400
        public void InvertRotation_6F0C1B2BB41F(){} // RVA: 0x7FFD4EF1CB80
        public void ExtractAxisAngle(){} // RVA: 0x7FFD4EF1CFB0
        public void ApplyQuaternionToVector(){} // RVA: 0x7FFD4EF1D0E0
        public void SetAngularVelocityTarget(){} // RVA: 0x7FFD4EF1D140
        public void ApplyAngularVelocityTarget(){} // RVA: 0x7FFD4EF1D3C0
        public void ApplyTransform(){} // RVA: 0x7FFD4EF1D6F0
        public void SyncTransformPoint(){} // RVA: 0x7FFD4EF1D790
        public void ResetBlendState(){} // RVA: 0x7FFD4EF1ED80
        public void UpdateNormalizedProgress(){} // RVA: 0x7FFD4EF1EE30
        public void ClampRotationBlend(){} // RVA: 0x7FFD4EF1F0A0
        public void CopyRotationState(){} // RVA: 0x7FFD4EF1F210
        public void OnEnable_4663AB782EF5(){} // RVA: 0x7FFD4EF1F360
        public void set_enabled(){} // RVA: 0x7FFD4EF1FAA0
        public void set_enabled_2034991DADD2(){} // RVA: 0x7FFD4EF1FB10
        public void __GetType__SystemType(){} // RVA: 0x7FFD4EF1FBE0
        public void OnBecameInvisible_49C2B262C8D9(){} // RVA: 0x7FFD4EF20330
        public void HasHumanAnimatorController(){} // RVA: 0x7FFD4EF20470
        public void SetSharedTextMaterial(){} // RVA: 0x7FFD4EF205F0
        public void WriteBarrierAssignNull(){} // RVA: 0x7FFD4EF20690
        public void SetBehaviourEnabled_1343FDA8B01A(){} // RVA: 0x7FFD4EF20D00
        public void PrepareInverseTransformPoint(){} // RVA: 0x7FFD4EF20EB0
        public void InverseTransformPoint(){} // RVA: 0x7FFD4EF20FB0
        public void TransformPointCurrent(){} // RVA: 0x7FFD4EF22020
        public void HookIntoActionChange(){} // RVA: 0x7FFD4EF22190
        public void TransformPoint(){} // RVA: 0x7FFD4EF221A0
        public void SyncPoseFromRotation(){} // RVA: 0x7FFD4EF22200
        public void Initialize_3D55D53C2458(){} // RVA: 0x7FFD4EF22710
        public void BlendToPoser(){} // RVA: 0x7FFD4EF22C80
        public void BlendToPoser_5AD1C145008D(){} // RVA: 0x7FFD4EF22C90
        public void get_transform(){} // RVA: 0x7FFD4EF22D70
        public void InverseTransformPointCurrent(){} // RVA: 0x7FFD4EF22E10
        public void TransformPointFromCurrent(){} // RVA: 0x7FFD4EF22F60
        public void MultiplyQuaternionComponents(){} // RVA: 0x7FFD4EF23050
        public void ApplyLocalTransform(){} // RVA: 0x7FFD4EF232B0
        public void GetUnityEngine_B1754E4FE30C(){} // RVA: 0x7FFD4EF23310
        public void RemoveParentConstraintSourceCurrent(){} // RVA: 0x7FFD4EF23450
        public void ValidateComponentReferences(){} // RVA: 0x7FFD4EF23510
        public void TryGetValue(){} // RVA: 0x7FFD4EF238D0
        public void PrepareLocalPose(){} // RVA: 0x7FFD4EF23940
        public void ApplyLocalPose(){} // RVA: 0x7FFD4EF239A0
        public void SyncLocalPosition(){} // RVA: 0x7FFD4EF23C90
        public void OnDisable(){} // RVA: 0x7FFD4EF24130
        public void get_transform_476244712A3B(){} // RVA: 0x7FFD4EF242C0
        public void FindRelativeTransform(){} // RVA: 0x7FFD4EF24320
        public void RotateVector(){} // RVA: 0x7FFD4EF24910
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7FFD4EF24B70
        public void GetGameObjectTransform(){} // RVA: 0x7FFD4EF24E80
        public void CreateAngleAxisRotation(){} // RVA: 0x7FFD4EF24F60
        public void SetRotation_297C1EF1EFB6(){} // RVA: 0x7FFD4EF24F80
        public void PrepareSyncPosition(){} // RVA: 0x7FFD4EF27440
        public void SyncPosition_BFD49602D06E(){} // RVA: 0x7FFD4EF274D0
        public void CreateManagedObject(){} // RVA: 0x7FFD4EF2A720
        public void InitializeTransformPose(){} // RVA: 0x7FFD4EF2A840
        public void UpdateTransformPoseState(){} // RVA: 0x7FFD4EF2AF80
        public void ApplyTransformPose(){} // RVA: 0x7FFD4EF2B040
        public void Updateenabled(){} // RVA: 0x7FFD4EF2B520
        public void RefreshEnabledState(){} // RVA: 0x7FFD4EF2B8A0
        public void DoIsDevApi(){} // RVA: 0x7FFD4EF2BB50
        public void RefreshPlayerStatusDisplay(){} // RVA: 0x7FFD4EF2BD10
        public void UpdatePlayerStatusDisplay_1468B8CEFE44(){} // RVA: 0x7FFD4EF2C000
        public void UpdateComponentFlagsAndReferences(){} // RVA: 0x7FFD4EF2C3E0
        public void ClearSyncState(){} // RVA: 0x7FFD4EF2C550
        public void DoIsDevApi_3ACFB13FB8D7(){} // RVA: 0x7FFD4EF2C850
        public void SyncRotationCurrent(){} // RVA: 0x7FFD4EF2C8A0
        public void ToString(){} // RVA: 0x7FFD4EF2C940
        public void ProcessMultiStateFlagPartial(){} // RVA: 0x7FFD4EF2CB70
        public void SyncRotation(){} // RVA: 0x7FFD4EF2CE90
        public void SetFlagAndCallFunction(){} // RVA: 0x7FFD4EF2D190
        public void ApplyLocalTransform_3964A43AA662(){} // RVA: 0x7FFD4EF2D1C0
        public void ApplyHumanBoneLocalPose(){} // RVA: 0x7FFD4EF2D220
        public void DoHasAnyPendingTasks(){} // RVA: 0x7FFD4EF2D790
        public void GetTransform_EC5_93CEAFF87970(){} // RVA: 0x7FFD4EF2D830
        public void ProcessSystemComponentData(){} // RVA: 0x7FFD4EF2DAF0
        public void IncrementCounterAndProcess(){} // RVA: 0x7FFD4EF2DB40
        public void ResetSystemDataBlock(){} // RVA: 0x7FFD4EF2DCC0
        public void InitializeSystemDataBlock(){} // RVA: 0x7FFD4EF2DD20
        public void ProcessSystemDataBlock(){} // RVA: 0x7FFD4EF2DD80
        public void SyncTransform_5DFF8D8F10E0(){} // RVA: 0x7FFD4EF2DE10
        public void ResolveInputSource(){} // RVA: 0x7FFD4EF2E000
        public void GetInputSourceHandle(){} // RVA: 0x7FFD4EF2E060
        public void CopyPoseState(){} // RVA: 0x7FFD4EF2E510
        public void CopyPoseStateCurrent(){} // RVA: 0x7FFD4EF2E6A0
        public void StopCoroutine_8F178AA30895(){} // RVA: 0x7FFD4EF2E700
        public void ResolveRelativeRotationCurrent(){} // RVA: 0x7FFD4EF2E760
        public void NormalizeQuaternionBlend(){} // RVA: 0x7FFD4EF2E8A0
        public void RotateVector_07C18381C4B4(){} // RVA: 0x7FFD4EF2E900
        public void GetTransformRotation(){} // RVA: 0x7FFD4EF2E910
        public void ResolveLocalRotation(){}
        public void SyncLocalRotation(){} // RVA: 0x7FFD4EF2EB70
        public void ApplyLocalRotation(){} // RVA: 0x7FFD4EF2ECC0
        public void IsInvoking_59070821FBF6(){} // RVA: 0x7FFD4EF2EE00
        public void OnEnable(){} // RVA: 0x7FFD4EF2F0E0
        public void get_Internal(){} // RVA: 0x7FFD4EF2F270
        public void GetInputSourceHandleCurrent(){} // RVA: 0x7FFD4EF2F4A0
        public void ResolveTransformMapping(){} // RVA: 0x7FFD4EF2F650
        public void UpdateTransformMapping(){} // RVA: 0x7FFD4EF30260
        public void OnEnable_FF8EEB6282DE(){} // RVA: 0x7FFD4EF303D0
        public void InitializeComponentFlag(){} // RVA: 0x7FFD4EF30470
        public void PrepareRelativeRotation(){} // RVA: 0x7FFD4EF304D0
        public void ResolveRelativeRotation(){} // RVA: 0x7FFD4EF30950
        public void AssignHumanoidReferences(){} // RVA: 0x7FFD4EF30AD0
        public void DoInverseTransformPoint_Injected_3E5(){} // RVA: 0x7FFD4EF30B30
        public void SetRotationCurrent_4B6D05862416(){} // RVA: 0x7FFD4EF30D30
        public void SetLocalRotation(){} // RVA: 0x7FFD4EF30EB0
        public void ApplyLocalRotationCurrent(){} // RVA: 0x7FFD4EF30FE0
        public void get_Start_Move(){} // RVA: 0x7FFD4EF31450
        public void SyncTransform_5E919D5007E2(){} // RVA: 0x7FFD4EF316A0
        public void ApplySharedTextMaterial(){} // RVA: 0x7FFD4EF319A0
        public void ApplyRotation(){} // RVA: 0x7FFD4EF31F10
        public void SetLocalRotation_D97E430E25E7(){} // RVA: 0x7FFD4EF325B0
        public void ApplyTransform_77F427D0E26E(){} // RVA: 0x7FFD4EF32C20
        public void Start(){} // RVA: 0x7FFD4EF32D10
        public void Update_BE0CAA09FBAC(){} // RVA: 0x7FFD4EF32DB0
        public void InitializeAvatarGoalPose(){} // RVA: 0x7FFD4EF330D0
        public void InitializeAnimatorGoalPose(){} // RVA: 0x7FFD4EF330E0
        public void InitializeTextMaterial(){} // RVA: 0x7FFD4EF33340
        public void ApplyAvatarGoalPose(){} // RVA: 0x7FFD4EF335E0
        public void ApplyAnimatorGoalPose(){} // RVA: 0x7FFD4EF33A00
        public void UpdateAnimatorGoalPose(){} // RVA: 0x7FFD4EF33F90
        public void ApplyTextMaterial(){} // RVA: 0x7FFD4EF34080
        public void GetTransformData(){} // RVA: 0x7FFD4EF340E0
        public void ProcessTransformData(){} // RVA: 0x7FFD4EF34140
        public void SyncTransformPose(){} // RVA: 0x7FFD4EF341A0
        public void SyncPoseFromRotationTarget(){} // RVA: 0x7FFD4EF34CD0
        public void HasValidData(){} // RVA: 0x7FFD4EF354F0
        public void ValidateTransformData(){} // RVA: 0x7FFD4EF35630
        public void MoveNext(){} // RVA: 0x7FFD4EF359C0
        public void SyncAnimatorGoalPose(){} // RVA: 0x7FFD4EF35BF0
        public void UpdateTextMaterial(){} // RVA: 0x7FFD4EF35CF0
        public void SetTextMaterial(){} // RVA: 0x7FFD4EF361D0
        public void UpdatelocalScale_I(){} // RVA: 0x7FFD4EF363A0
        public void GetUnityEngine_1CFDDA334B8D(){} // RVA: 0x7FFD4EF36590
        public void GetActiveSelf_CE6(){} // RVA: 0x7FFD4EF365F0
        public void RefreshTextMaterial(){} // RVA: 0x7FFD4EF368A0
        public void SetAvatarGoalPose(){} // RVA: 0x7FFD4EF36930
    }

}