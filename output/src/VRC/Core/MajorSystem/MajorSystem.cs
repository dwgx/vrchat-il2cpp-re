// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.MajorSystem
// Classes: 14
// Methods: 1953

namespace VRC.Core.MajorSystem
{
    /// <summary>Originally: ÏÏÏÌÌÍÎÌÍÏÏÎÎÍÌÌÍÏÎÌÌÍÍ</summary>
    public class ComplexComponent_0B13_0B13 : MonoBehaviour
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
        public 0x6B02BC70 ÏÍÌÍÌÌÎÎÍÎÏÎÍÍÌÎÍÌÎÍÍÌÍ; // 0xC0
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
        public 0x6B02B958 ÌÌÏÎÎÍÎÎÎÎÌÎÍÌÏÎÍÏÎÎÍÌÏ; // 0x16C
        public 0x6B02B9B0 ÌÍÌÏÌÌÌÌÌÏÏÏÍÎÏÎÍÎÎÎÌÌÍ; // 0x170
        public 0x6B02BA60 ÌÌÌÌÎÏÍÎÍÎÏÏÍÍÏÌÌÌÎÌÌÍÏ; // 0x174
        public 0x6B02BA08 ÎÏÏÎÎÌÍÍÏÌÏÏÎÏÏÌÎÏÏÍÍÏÏ; // 0x178
        public 0x6B02ACF8 ÍÌÎÏÎÏÌÎÍÎÎÎÏÌÎÎÍÌÌÏÌÍÏ; // 0x17C
        public 0x6B02BAB8 ÍÍÍÍÏÍÌÎÎÌÏÌÍÌÍÎÍÍÍÌÍÍÏ; // 0x180
        public 0x6B02BB68 ÍÌÏÎÌÎÍÏÍÎÏÏÎÏÏÏÏÌÏÌÌÏÌ; // 0x184
        public 0x6B02B6F0 ÎÌÌÏÌÏÌÍÌÏÏÌÏÎÏÎÌÍÌÍÎÌÌ; // 0x188
        public 0x6B02B748 ÏÏÎÍÎÍÎÍÌÍÏÌÍÍÏÌÌÌÍÏÌÍÌ; // 0x18C
        public 0x6B02B7A0 ÎÏÌÍÍÏÏÌÎÍÍÍÎÌÎÏÎÌÏÎÏÏÎ; // 0x190
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
        public 0x6B02BCC8 ÍÍÌÎÌÏÌÏÎÌÎÍÎÌÎÏÎÎÎÏÏÏÏ; // 0x1F8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC33E8FA0
        public void RaiseCancellation(){} // RVA: 0x7FFAC33EA5A0
        public void set_scale(){} // RVA: 0x7FFAC33EA9D0
        public void CancelInvoke(){} // RVA: 0x7FFAC33EA9E0
        public void set_Confidence(){} // RVA: 0x7FFAC308EF60
        public void get_scale(){} // RVA: 0x7FFAC33EAB80
        public void CancelInvoke_EA5781C9E843(){} // RVA: 0x7FFAC33EAB90
        public void IsInvoking(){} // RVA: 0x7FFAC33EAEB0
        public void set_globalDollarsGoal(){} // RVA: 0x7FFAC31434F0
        public void StartCoroutine(){} // RVA: 0x7FFAC33EB2B0
        public void StartCoroutine_665B69C6EC5E(){} // RVA: 0x7FFAC33EB2F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC33EB3F0
        public void StopCoroutine(){} // RVA: 0x7FFAC33EB400
        public void get_CanBeNull_89F3C5EEBE94_89F3C5EEBE94(){} // RVA: 0x7FFAC33F49E0 | overloaded x2
        public void GetInstanceID(){} // RVA: 0x7FFAC33EB5C0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC33EB670
        public void get_useGUILayout(){} // RVA: 0x7FFAC33EBEA0
        public void set_useGUILayout_24F2581CC257_24F2581CC257(){} // RVA: 0x7FFAC33FA060 | overloaded x2
        public void print(){} // RVA: 0x7FFAC33EC0F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC33EC410
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC33EC460
        public void FixedUpdate_213C297E3E3A_213C297E3E3A(){} // RVA: 0x7FFAC33EF7D0 | overloaded x2
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFAC31E7D90
        public void OnTriggerExit(){} // RVA: 0x7FFAC33EC6E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC33ECA60
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC33ECE30
        public void GetCurrentHealth(){} // RVA: 0x7FFAC308EF50
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC33ECEF0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC33ED2F0
        public void GetScriptClassName(){} // RVA: 0x7FFAC33ED5D0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC33ED720
        public void DoThrowArgumentNullException(){} // RVA: 0x7FFAC33ED740
        public void GetGameObject_99B(){} // RVA: 0x7FFAC33ED7A0
        public void OnTriggerExit_18C87653E139(){} // RVA: 0x7FFAC33ED960
        public void ToChar(){} // RVA: 0x7FFAC33EDAB0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFAC33EDD30
        public void get_Created(){} // RVA: 0x7FFAC33EDDF0
        public void OnEnable(){} // RVA: 0x7FFAC33EE1D0
        public void Updaterotation_Inj(){} // RVA: 0x7FFAC33EE520
        public void Update(){} // RVA: 0x7FFAC33EF910
        public void InvokeInterfaceMethod(){} // RVA: 0x7FFAC33EFF00
        public void OnDisable(){} // RVA: 0x7FFAC33F0000
        public void ResetDestroyCancellationToken_DE458A3C86CD(){} // RVA: 0x7FFAC33F6280 | overloaded x2
        public void OnApplicationPause(){} // RVA: 0x7FFAC33F02D0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC33F0310
        public void OnBecameVisible(){} // RVA: 0x7FFAC33F0370
        public void OnBecameInvisible(){} // RVA: 0x7FFAC33F1A50
        public void .ctor(){} // RVA: 0x7FFAC33F1BC0
        public void Initialize(){} // RVA: 0x7FFAC33F1EA0
        public void OnCollisionExit(){} // RVA: 0x7FFAC33F2440
        public void OnTriggerEnter(){} // RVA: 0x7FFAC33F2740
        public void OnTriggerStay(){} // RVA: 0x7FFAC33F27B0
        public void OnTriggerExit_B18956EB675B(){} // RVA: 0x7FFAC33F27C0
        public void UpdateHealth(){} // RVA: 0x7FFAC33F28D0
        public void TakeDamage(){} // RVA: 0x7FFAC33F2900
        public void InvokeInterfaceMethod_A07AB15C36C4(){} // RVA: 0x7FFAC33F2E60
        public void LateUpdate(){} // RVA: 0x7FFAC33F30A0
        public void DoStop(){} // RVA: 0x7FFAC33F43C0
        public void GetMaxDampTime(){} // RVA: 0x7FFAC3000210
        public void set_scale_FF0739DBFA70(){} // RVA: 0x7FFAC33EA9D0
        public void AddDollars(){} // RVA: 0x7FFAC33F4A40
        public void SetReversedPlaybackFlag(){} // RVA: 0x7FFAC33F4C80
        public void OnCollisionEnter(){} // RVA: 0x7FFAC33F4D20
        public void OnCollisionStay(){} // RVA: 0x7FFAC33F4EE0
        public void Awake(){} // RVA: 0x7FFAC33F4F00
        public void InterpolateQuaternionComponents(){} // RVA: 0x7FFAC33F4FA0
        public void SetStateAndRefresh(){} // RVA: 0x7FFAC33F57C0
        public void Start(){} // RVA: 0x7FFAC33F5890
        public void SpendDollars(){} // RVA: 0x7FFAC33F5DD0
        public void OnDestroy_8353473A53FD(){} // RVA: 0x7FFAC33F5F00
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFAC33F61E0
        public void ResetConfidence_4DA120D06F9F_4DA120D06F9F(){} // RVA: 0x7FFAC33F7060 | overloaded x2
        public void ProcessComponentFieldAndCheck(){} // RVA: 0x7FFAC33F62F0
        public void HandlePointerDragScale(){} // RVA: 0x7FFAC33F6500
        public void HandleRectTransform(){} // RVA: 0x7FFAC33F6600
        public void HandleRectTransformScale(){} // RVA: 0x7FFAC33F67C0
        public void HandleLayoutState(){} // RVA: 0x7FFAC33F69E0
        public void ToDegrees(){} // RVA: 0x7FFAC33F6AA0
        public void HandleLayoutStateScale(){} // RVA: 0x7FFAC33F7280
        public void UpdatePositionAndRo(){} // RVA: 0x7FFAC33F7B90
        public void HandleTabContent(){} // RVA: 0x7FFAC33F7C30
        public void HandleTabContentScale(){} // RVA: 0x7FFAC33F7CD0
        public void HandleObservableList(){} // RVA: 0x7FFAC33F7CF0
        public void HandleObservableListScale(){} // RVA: 0x7FFAC33F7D00
        public void InvokeInterfaceMethod_D01990B96BD3(){} // RVA: 0x7FFAC33F7E30
        public void HandleScrollStateScale(){} // RVA: 0x7FFAC33F7E70
        public void set_Depth(){} // RVA: 0x7FFAC3000220
        public void set_Depth_B9992F60571F(){} // RVA: 0x7FFAC3000220
        public void get_Playlist(){} // RVA: 0x7FFAC33F8150
        public void GetGameObjectReference(){} // RVA: 0x7FFAC33F8160
        public void SetAudioVolume2(){} // RVA: 0x7FFAC33F83A0
        public void UpdateActive(){} // RVA: 0x7FFAC33F85C0
        public void HandlePreCullStateScale(){} // RVA: 0x7FFAC33F61E0
        public void PreparePurchaseDisplayData(){} // RVA: 0x7FFAC33F8740
        public void GetTime_618(){} // RVA: 0x7FFAC33F8A20
        public void OnTriggerEnter_44BB8B0A0B9A(){} // RVA: 0x7FFAC33F2740
        public void OnDestroy(){} // RVA: 0x7FFAC33F8C10
        public void UpdatePointerHover(){} // RVA: 0x7FFAC33F8CB0
        public void GetUnityEngine(){} // RVA: 0x7FFAC33F8EB0
        public void StartCoroutine_Auto_1E029CD76E52(){} // RVA: 0x7FFAC33F8F80
        public void set_ambientLight(){} // RVA: 0x7FFAC33F9130
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC33F9290
        public void ConfigureintVal(){} // RVA: 0x7FFAC33F9C00
        public void SetGameObjectActive(){} // RVA: 0x7FFAC33F9D80
        public void UpdatePointerDrag(){} // RVA: 0x7FFAC33FA230
        public void SetAudioVolume(){} // RVA: 0x7FFAC33FA310
        public void UpdatePointerDragScale(){} // RVA: 0x7FFAC33FA420
        public void UpdateRectTransform(){} // RVA: 0x7FFAC33FA520
        public void UpdateRectTransformScale(){} // RVA: 0x7FFAC33FB0C0
        public void OnTriggerExit_504EF4DAA1B8(){} // RVA: 0x7FFAC2E8DC40
        public void InvokeInterfaceMethod_F2890B6B854B(){} // RVA: 0x7FFAC33FB0E0
    }

    /// <summary>Originally: ÎÏÏÎÍÏÍÎÌÌÎÎÏÍÏÏÏÎÍÏÍÏÍ</summary>
    public class ComplexComponent_0BF8_0BF8 : MonoBehaviour
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC37B6DD0
        public void OnDestroy(){} // RVA: 0x7FFAC37B6F70
        public void IsInvoking(){} // RVA: 0x7FFAC37B7080
        public void CancelInvoke(){} // RVA: 0x7FFAC37C3F80 | overloaded x6
        public void Invoke(){} // RVA: 0x7FFAC37B72F0
        public void InvokeRepeating(){} // RVA: 0x7FFAC37B7370
        public void OnCollisionStay(){} // RVA: 0x7FFAC37B7720
        public void Start(){} // RVA: 0x7FFAC37B7760
        public void OnTriggerStay(){} // RVA: 0x7FFAC37B8030
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC37B8360
        public void StopCoroutine(){} // RVA: 0x7FFAC37B85C0
        public void get_CanBeNull(){} // RVA: 0x7FFAC37B8670
        public void OnApplicationPause(){} // RVA: 0x7FFAC37B8890
        public void StopAllCoroutines(){} // RVA: 0x7FFAC37B8E60
        public void get_useGUILayout(){} // RVA: 0x7FFAC37B8EE0
        public void InitPayloadEncryption(){} // RVA: 0x7FFAC34D4AA0
        public void GetAudioTracks(){} // RVA: 0x7FFAC32EF640
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC37B9080
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC37B9260
        public void InvokeDelayed(){} // RVA: 0x7FFAC37B93A0
        public void CancelInvoke_CE58187DE689(){} // RVA: 0x7FFAC37B9A50
        public void OnTriggerExit(){} // RVA: 0x7FFAC37B9BF0
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC37B9DB0
        public void set_description(){} // RVA: 0x7FFAC354E3C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC37BA210
        public void StopCoroutineFromEnumeratorManaged_03AB7C3DD9D1_03AB7C3DD9D1(){} // RVA: 0x7FFAC37C2E90 | overloaded x2
        public void GetScriptClassName(){} // RVA: 0x7FFAC37BA3F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC37BAD00
        public void CanReadEmbeddedValue(){} // RVA: 0x7FFAC37BAE00
        public void ForceMeshUpdate(){} // RVA: 0x7FFAC37BAE80
        public void OnTriggerExit_31EA1B98DCC7(){} // RVA: 0x7FFAC37BB160
        public void BuildIndexedEntry(){} // RVA: 0x7FFAC37BB230
        public void get_Created(){} // RVA: 0x7FFAC37BB570
        public void InitializeAndCreate0BF8Object(){} // RVA: 0x7FFAC37BB800
        public void ToByte(){} // RVA: 0x7FFAC37BB990
        public void set_iconImageUrl(){} // RVA: 0x7FFAC354E360
        public void Awake(){} // RVA: 0x7FFAC37BBC50
        public void OnEnable(){} // RVA: 0x7FFAC37BBF10
        public void CreateConfiguredInstance(){} // RVA: 0x7FFAC37BBFE0
        public void get_taglineText(){} // RVA: 0x7FFAC354B1A0
        public void AssignCreatedHandle(){} // RVA: 0x7FFAC37BC090
        public void LateUpdate(){} // RVA: 0x7FFAC37BC440
        public void OnDisable(){} // RVA: 0x7FFAC37BCF10
        public void Initialize0BF8Resources(){} // RVA: 0x7FFAC37BD380
        public void GetAudioTracks_5DF912479AFB(){} // RVA: 0x7FFAC32EF640
        public void OnApplicationQuit(){} // RVA: 0x7FFAC37BF2C0
        public void OnBecameVisible(){} // RVA: 0x7FFAC37BF840
        public void OnBecameInvisible(){} // RVA: 0x7FFAC37BFA10
        public void set_PointerPose(){} // RVA: 0x7FFAC2F8C0C0
        public void .cctor(){} // RVA: 0x7FFAC37BFC40
        public void OnCollisionExit(){} // RVA: 0x7FFAC37C07D0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC37C0A30
        public void BuildBoundsFromSource(){} // RVA: 0x7FFAC37C0EA0
        public void InitializeComplexComponent(){} // RVA: 0x7FFAC37C1060
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void InvokeMatchedReceiver(){} // RVA: 0x7FFAC37C1200
        public void TryInvokeMatchedReceiver(){} // RVA: 0x7FFAC37C15F0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void ThrowJsonException_MetadataReferenceObjectCannotContainOtherProperties(){} // RVA: 0x7FFAC37C16A0
        public void DeserializeIndexedPayload(){} // RVA: 0x7FFAC37C18D0
        public void UpdateComplexComponent(){} // RVA: 0x7FFAC37BB800
        public void Initialize(){} // RVA: 0x7FFAC37C1A70
        public void ApplyLinkedContext(){} // RVA: 0x7FFAC37C1C20
        public void ProcessComplexComponent(){} // RVA: 0x7FFAC37C1F00
        public void Initialize_D4D08C33616E(){} // RVA: 0x7FFAC37C21A0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC37C2410
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void ApplyLinkedContextAlt(){} // RVA: 0x7FFAC37C24E0
        public void CreateAndDisableCurrentTarget(){} // RVA: 0x7FFAC37C26B0
        public void DisableCurrentTarget(){} // RVA: 0x7FFAC37C26E0
        public void StartComplexComponent(){} // RVA: 0x7FFAC37C2910
        public void op_Implicit(){} // RVA: 0x7FFAC37C3070
        public void AllocateStateSlot(){} // RVA: 0x7FFAC2F4F0C0
        public void Initialize0BF8Statics(){} // RVA: 0x7FFAC37C3120
        public void StopComplexComponent(){} // RVA: 0x7FFAC37C3150
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void .ctor(){} // RVA: 0x7FFAC37C3160
        public void PauseComplexComponent(){} // RVA: 0x7FFAC37C38A0
        public void get_name(){} // RVA: 0x7FFAC37C3A40
        public void get_name_4A8C383E103B(){} // RVA: 0x7FFAC37C3B30
        public void ResumeComplexComponent(){} // RVA: 0x7FFAC37C3CD0
        public void DestroyComplexComponent(){} // RVA: 0x7FFAC37C3ED0
        public void GetCurrentTextCue_62ACEDD4AE62(){} // RVA: 0x7FFAC2F8C0B0
        public void set_imageUrl(){} // RVA: 0x7FFAC354E300
        public void EnableComplexComponent(){} // RVA: 0x7FFAC37C4080
        public void DisableComplexComponent(){} // RVA: 0x7FFAC37C4130
        public void InvokeStoredCallback(){} // RVA: 0x7FFAC37C4510
        public void ResetComplexComponent(){} // RVA: 0x7FFAC37C46B0
        public void FixedUpdate(){} // RVA: 0x7FFAC37C4930
        public void Update(){} // RVA: 0x7FFAC37C4990
        public void AwakeComplexComponent(){} // RVA: 0x7FFAC37C4BD0
        public void ResolvePrimaryContainer(){} // RVA: 0x7FFAC37C4DD0
        public void OnEnableComplexComponent(){} // RVA: 0x7FFAC37C4EE0
        public void OnDisableComplexComponent(){} // RVA: 0x7FFAC37C51B0
        public void Ensure0BF8TypeInfo(){} // RVA: 0x7FFAC37C5260
        public void Initialize0BF8TypeInfo(){} // RVA: 0x7FFAC37C5270
        public void ResolveOrAssignReference(){} // RVA: 0x7FFAC37C5320
        public void OnCollisionEnter(){} // RVA: 0x7FFAC37C5590
        public void CreateAndFinalizeHandle(){} // RVA: 0x7FFAC37C58C0
        public void CreateDefaultContext(){} // RVA: 0x7FFAC37C5B40
    }

    /// <summary>Originally: ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ</summary>
    public class ComplexComponent_12D5_12D5 : MonoBehaviour
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
        public 0x6B02B6F0 ÌÍÌÍÎÏÎÌÍÏÌÌÎÍÏÍÏÎÎÍÍÏÎ; // 0x168
        public bool ÎÍÏÍÍÌÍÎÍÌÏÌÏÍÌÍÎÎÏÎÍÎÎ; // 0x16C
        public bool <ÌÌÌÌÍÍÎÎÍÏÌÍÌÎÏÏÏÍÎÏÌÎÏ>k__BackingField; // 0x16D
        public 0x6B02B748 ÌÏÍÌÌÎÎÏÍÌÍÌÏÏÌÏÌÎÎÌÏÎÏ; // 0x170
        public bool ÎÏÍÍÏÎÌÍÍÍÏÍÌÍÏÌÌÎÎÎÍÍÏ; // 0x174
        public 0x6B02B7A0 ÌÍÍÌÍÍÏÏÏÏÏÍÎÎÏÍÏÍÌÏÏÏÌ; // 0x178
        public int ÎÏÌÌÏÏÎÏÌÌÌÍÍÌÍÎÎÌÏÍÏÌÎ; // 0x17C
        public int ÎÏÎÌÎÍÌÎÍÏÌÎÌÌÌÏÏÍÌÏÏÍÌ; // 0x180
        public int ÏÍÌÏÌÏÍÍÍÍÍÌÌÌÌÌÏÍÏÎÎÍÌ; // 0x184
        public 0x6B02B850 ÎÎÎÍÌÌÏÏÎÏÎÎÎÍÎÍÏÌÎÍÌÎÎ; // 0x188
        public System.Nullable`1<0x6B169358> ÏÏÌÏÌÎÍÏÎÌÎÍÌÎÌÏÌÏÍÏÌÎÏ; // 0x18C
        public System.Nullable`1<0x6B169358> ÏÌÏÌÍÎÍÍÎÍÎÎÍÏÌÏÎÌÌÌÌÏÏ; // 0x194
        public 0x6B02B900 <ÏÏÍÎÍÎÍÏÏÍÎÍÍÎÏÎÍÍÌÌÌÌÎ>k__BackingField; // 0x19C
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
        public void get_HttpProxy(){} // RVA: 0x7FFAC33A98A0
        public void RaiseCancellation(){} // RVA: 0x7FFAC33A98B0
        public void IsInvoking(){} // RVA: 0x7FFAC33A9910
        public void CancelInvoke(){} // RVA: 0x7FFAC33A9960
        public void Invoke(){} // RVA: 0x7FFAC33AA7C0
        public void InvokeRepeating(){} // RVA: 0x7FFAC33AA7E0
        public void CancelInvoke_F906DC58075E(){} // RVA: 0x7FFAC33AAEE0
        public void IsInvoking_E51C33B0702A(){} // RVA: 0x7FFAC33AAF90
        public void StartCoroutine(){} // RVA: 0x7FFAC33AB3F0
        public void StartCoroutine_0BF9228D3731(){} // RVA: 0x7FFAC33AB400
        public void OnDisable(){} // RVA: 0x7FFAC33AB4A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC33AB510
        public void StopCoroutine(){} // RVA: 0x7FFAC33AB560
        public void .ctor(){} // RVA: 0x7FFAC33AB7B0
        public void Initialize(){} // RVA: 0x7FFAC2F4F0C0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC33AB820
        public void get_useGUILayout(){} // RVA: 0x7FFAC33ABAD0
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC33ABB80
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC33ABBA0
        public void InvokeDelayed(){} // RVA: 0x7FFAC33ABBC0
        public void CancelInvoke_44EB9D083CB1(){} // RVA: 0x7FFAC33ABBD0
        public void .cctor(){} // RVA: 0x7FFAC33ABD80
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC33ABE70
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC33ABF80
        public void Start(){} // RVA: 0x7FFAC33AC1A0
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void GetScriptClassName(){} // RVA: 0x7FFAC33AC240
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC33AC250
        public void DispatchQueuedOperation(){} // RVA: 0x7FFAC33AC2B0
        public void CalculateMeasurementValue(){} // RVA: 0x7FFAC33AC360
        public void OnApplicationPause(){} // RVA: 0x7FFAC33AC370
        public void OnApplicationQuit(){} // RVA: 0x7FFAC33AC860
        public void OnBecameVisible(){} // RVA: 0x7FFAC33ACBC0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC33ACD40
        public void OnCollisionEnter(){} // RVA: 0x7FFAC33ACE50
        public void OnCollisionStay(){} // RVA: 0x7FFAC33ACE60
        public void OnCollisionExit(){} // RVA: 0x7FFAC33AD120
        public void OnTriggerEnter(){} // RVA: 0x7FFAC33AD190
        public void OnTriggerStay(){} // RVA: 0x7FFAC33ADE00
        public void OnTriggerExit(){} // RVA: 0x7FFAC33ADE10
        public void ValidateAndReadMode(){} // RVA: 0x7FFAC33ADE20
        public void BroadcastNetworkUpdate(){} // RVA: 0x7FFAC33ADF30
        public void ConfigureHttpProxy(){} // RVA: 0x7FFAC33AE0D0
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFAC33AE0E0
        public void GetGameObject_D00(){} // RVA: 0x7FFAC33AE140
        public void Pause(){} // RVA: 0x7FFAC33AE7A0
        public void ProxyNetworkFunctionCall(){} // RVA: 0x7FFAC33AEF60
        public void GetCachedPtr(){} // RVA: 0x7FFAC33AF0C0
        public void GetCachedPtr_56350A8B9BAA(){} // RVA: 0x7FFAC33AF0D0
        public void GetCachedPtr_9BF19B8CECEB(){} // RVA: 0x7FFAC33AF170
        public void ProcessSocketMeasurement(){} // RVA: 0x7FFAC33AF320
        public void OnEnable(){} // RVA: 0x7FFAC33AF450
        public void OnEnable_AB9AE64E6DAF(){} // RVA: 0x7FFAC33AF490
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void set_name(){} // RVA: 0x7FFAC33AF4A0
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void set_element(){} // RVA: 0x7FFAC31D0C20
        public void Update(){} // RVA: 0x7FFAC2F9C730
        public void set_HttpProxy(){} // RVA: 0x7FFAC33AFA60
        public void Initialize12D5Resources(){} // RVA: 0x7FFAC33AFAC0
        public void OnDestroy(){} // RVA: 0x7FFAC33B0030
        public void CreateFloatNode(){} // RVA: 0x7FFAC33B00D0
        public void CreateFloatNodeAlt(){} // RVA: 0x7FFAC33B0100
        public void InvokeManagedCallback(){} // RVA: 0x7FFAC33B02E0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFAC30794D0
        public void IsTransformInternalFlagTrue(){} // RVA: 0x7FFAC33B0360
        public void GetUnityEngine(){} // RVA: 0x7FFAC33B0560
        public void GetUnityEngine_E25AB6497F19(){} // RVA: 0x7FFAC33B07A0
        public void get_inputType(){} // RVA: 0x7FFAC33B07B0
        public void GetCachedPtr_C6D801505517(){} // RVA: 0x7FFAC33AF0D0
        public void GetUnityEngine_1DA37F7CDF94(){} // RVA: 0x7FFAC33B07C0
        public void Awake(){} // RVA: 0x7FFAC33B07D0
        public void QueueNetworkOperation(){} // RVA: 0x7FFAC33B0F60
        public void UpdateToggleStateConditional(){} // RVA: 0x7FFAC33B1070
        public void FixedUpdate(){} // RVA: 0x7FFAC33B1180
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void DispatchEventToListener(){} // RVA: 0x7FFAC33B1420
        public void UpdateIKSolver(){} // RVA: 0x7FFAC33B1450
        public void MarshalToManaged(){} // RVA: 0x7FFAC33B1460
        public void ResolveStateHandler(){} // RVA: 0x7FFAC33B1590
        public void AdvanceTweenState(){} // RVA: 0x7FFAC33B1830
        public void AttachCreatedNode(){} // RVA: 0x7FFAC33B18C0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void set_DurationType(){} // RVA: 0x7FFAC33B1990
        public void RaiseCancellation_9CA672F33F2D(){} // RVA: 0x7FFAC33B19A0
        public void SetOverlay(){} // RVA: 0x7FFAC2F49200
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAC33B2390
        public void get_ReportAssembliesMode_1FEFD3C132A9(){} // RVA: 0x7FFAC33B23A0
        public void QueueNetworkOperation_614BEDEFFFD5(){} // RVA: 0x7FFAC33B23B0
        public void get_ReportAssembliesMode_8A65A8BA39E4(){} // RVA: 0x7FFAC33B23C0
        public void get_ReportAssembliesMode_BC09D1506450(){} // RVA: 0x7FFAC33B2470
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void InvokeWithTransformPayload(){} // RVA: 0x7FFAC33B2620
        public void LateUpdate(){} // RVA: 0x7FFAC33B2A70
        public void Internal_CancelInvokeAll_ABD88BF1FBDC(){} // RVA: 0x7FFAC33ABB80
        public void SetSyncedBoolFieldAt1088(){} // RVA: 0x7FFAC33B2B10
        public void OnApplicationQuit_02C2B02D1056(){} // RVA: 0x7FFAC33B30C0
        public void get_DurationType(){} // RVA: 0x7FFAC30EF4E0
        public void SetGameObjectActive(){} // RVA: 0x7FFAC33B3110
        public void OnEnable_4F97420F410E(){} // RVA: 0x7FFAC33AF490
        public void ApplyLocalPosition(){} // RVA: 0x7FFAC33B3B00
        public void GetBufferedTimes_8B36A1744DC0(){} // RVA: 0x7FFAC2F9E740
    }

    /// <summary>Originally: ÌÏÎÏÌÌÎÌÏÎÍÍÏÌÏÍÍÏÍÏÏÍÌ</summary>
    public class ComplexComponent_29A6_29A6 : MonoBehaviour
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
        public 0x6AFE9278 ÎÌÍÎÍÎÌÍÏÎÎÎÍÎÍÏÍÌÍÌÏÌÎ; // 0x138
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3CF0B10
        public void RaiseCancellation(){} // RVA: 0x7FFAC3CF0E00
        public void IsInvoking(){} // RVA: 0x7FFAC3CF0F00
        public void CancelInvoke(){} // RVA: 0x7FFAC3CF0FF0
        public void Invoke(){} // RVA: 0x7FFAC3CF10F0
        public void InvokeRepeating(){} // RVA: 0x7FFAC3CF1100
        public void StepBackwardAndProcessLastEntry(){} // RVA: 0x7FFAC3CF1230
        public void OnEnable(){} // RVA: 0x7FFAC3CF1380
        public void StartCoroutine(){} // RVA: 0x7FFAC3CF14F0
        public void FixedUpdate(){} // RVA: 0x7FFAC3CF1550
        public void StartCoroutine_3E1CD6ABB840(){} // RVA: 0x7FFAC3CF1590
        public void StartCoroutine_Auto_BC3CC4811100_BC3CC4811100(){} // RVA: 0x7FFAC3CFE0C0 | overloaded x2
        public void StopCoroutine(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC3CF17C0
        public void OnApplicationPause(){} // RVA: 0x7FFAC3CF2200
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3CF22F0
        public void get_useGUILayout(){} // RVA: 0x7FFAC3CF2310
        public void set_useGUILayout(){} // RVA: 0x7FFAC3D02910 | overloaded x3
        public void print(){} // RVA: 0x7FFAC3CF2470
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3CF2570
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3CF28B0
        public void InvokeDelayed(){} // RVA: 0x7FFAC3CF2F50
        public void OnTriggerStay(){} // RVA: 0x7FFAC3CF3010
        public void OnTriggerExit(){} // RVA: 0x7FFAC3CF3AE0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3CF4080
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3CF4220
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3CF4A80
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC3CF4B20
        public void get_radius(){} // RVA: 0x7FFAC3CF4C00
        public void GetScriptClassName(){} // RVA: 0x7FFAC3CF4C20
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC3CF50D0
        public void SetBlendState(){} // RVA: 0x7FFAC3CF5170
        public void Awake_E5A1AB56A3C2(){} // RVA: 0x7FFAC3CF5200
        public void Start(){} // RVA: 0x7FFAC3CF5210
        public void Update_E1FD5434E94E(){} // RVA: 0x7FFAC3CF5220
        public void .cctor(){} // RVA: 0x7FFAC3CF5260
        public void UpdateComponent(){} // RVA: 0x7FFAC3CF56B0
        public void ApplyResolvedPropertyValue(){} // RVA: 0x7FFAC3CF57E0
        public void Accesswidth(){} // RVA: 0x7FFAC3CF5870
        public void GetActiveInHierarchy(){} // RVA: 0x7FFAC3CF5960
        public void ComputeHashCode(){} // RVA: 0x7FFAC3CF6600
        public void BuildComponentFromBufferAndApply(){} // RVA: 0x7FFAC3CF6900
        public void ContainsChild(){} // RVA: 0x7FFAC3CF6990
        public void CheckLifecycleAvailability(){} // RVA: 0x7FFAC3CF6F40
        public void AreStringsEqual(){} // RVA: 0x7FFAC3CF7010
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3CF7040
        public void SetInputSource(){} // RVA: 0x7FFAC3CF7160
        public void DeserializeStatePayload(){} // RVA: 0x7FFAC3CF7220
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3CF7530
        public void GetContactReceiverList(){} // RVA: 0x7FFAC3CF7580
        public void Updateenabled(){} // RVA: 0x7FFAC3CF7920
        public void set_enabled(){} // RVA: 0x7FFAC3CF7970
        public void TryFormatStateMessage_64AD76CF5DCA_64AD76CF5DCA(){} // RVA: 0x7FFAC3CFEE80 | overloaded x2
        public void InvokeMaterialScaleChanged(){} // RVA: 0x7FFAC3CF87D0
        public void StepBackwardComplexComponent(){} // RVA: 0x7FFAC3CF8870
        public void SetUseGUILayout(){} // RVA: 0x7FFAC3CF8AB0
        public void ResetTrackedHandle(){} // RVA: 0x7FFAC3CF8BF0
        public void get_atlasPadding(){} // RVA: 0x7FFAC3CF9000
        public void InvokeRepeating_7250E780112D(){} // RVA: 0x7FFAC3CF9250
        public void GetUseGUILayout(){} // RVA: 0x7FFAC3CFA1D0
        public void Ensure29A6TypeInfo(){} // RVA: 0x7FFAC3CFA290
        public void BuildCompletedState(){} // RVA: 0x7FFAC3CFA530
        public void BuildAsyncResultState(){} // RVA: 0x7FFAC3CFA5C0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3CFA950
        public void InitializeStopCoroutineStatics(){} // RVA: 0x7FFAC3CFB2B0
        public void GetUnityEngine(){} // RVA: 0x7FFAC3CFB3A0
        public void ProcessComplexLastEntry(){} // RVA: 0x7FFAC3CFB9C0
        public void BuildVectorPayload(){} // RVA: 0x7FFAC3CFBA50
        public void ResolveSceneBinding(){} // RVA: 0x7FFAC3CFBAB0
        public void GetComplexRadius(){} // RVA: 0x7FFAC3CFBF50
        public void SetComplexBlendState(){} // RVA: 0x7FFAC3CFC390
        public void IsNativeObjectAlive_9D11C327178C(){} // RVA: 0x7FFAC3CFC470
        public void GetPhotonServerSettings(){} // RVA: 0x7FFAC3CFD300
        public void DispatchLifecycleTransitionAlt(){} // RVA: 0x7FFAC3CFD550
        public void GetInstance(){} // RVA: 0x7FFAC3CFD800
        public void InitializeComplexComponentState(){} // RVA: 0x7FFAC3CFD810
        public void CreateCollection(){} // RVA: 0x7FFAC3CFD900
        public void DispatchLifecycleTransition(){} // RVA: 0x7FFAC3CFD9F0
        public void DispatchLifecycleTransitionAuto(){} // RVA: 0x7FFAC3CFDA10
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFAC2F87DE0
        public void Initialize(){} // RVA: 0x7FFAC3CFDAA0
        public void HandleComplexTriggerStay(){} // RVA: 0x7FFAC3CFDB40
        public void HandleComplexTriggerExit(){} // RVA: 0x7FFAC3CFDD70
        public void ParseStandardFormat(){} // RVA: 0x7FFAC3CFDE10
        public void StartCoroutine_Auto_46D0C22D2566(){} // RVA: 0x7FFAC3CFE150
        public void CommitSecondaryEntry(){} // RVA: 0x7FFAC3CFE1E0
        public void GetRadius(){} // RVA: 0x7FFAC3CFE250
        public void ConfigureminValue(){} // RVA: 0x7FFAC3CFE460
        public void UpdateRealtimeTimestamp(){} // RVA: 0x7FFAC3CFF130
        public void FindSelectableOnRight(){} // RVA: 0x7FFAC3CFF220
        public void Awake_85B583812A88(){} // RVA: 0x7FFAC3CFF650
        public void GetLastServiceDescriptor(){} // RVA: 0x7FFAC3CFF830
        public void SetStateMachine(){} // RVA: 0x7FFAC3CFF930
        public void LateUpdate(){} // RVA: 0x7FFAC3CFF940
        public void OnDisable(){} // RVA: 0x7FFAC3CFFA20
        public void get_realtimeSinceStartup(){} // RVA: 0x7FFAC3CFFAD0
        public void get_realtimeSinceStartup_F4599549DBEB(){} // RVA: 0x7FFAC3CFFE20
        public void UpdateTextureObjectProperties(){} // RVA: 0x7FFAC3CFFE30
        public void OnBecameVisible(){} // RVA: 0x7FFAC3CFFF20
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3D00210
        public void OnCollisionEnter(){} // RVA: 0x7FFAC2F21310
        public void OnCollisionStay(){} // RVA: 0x7FFAC3D00480
        public void OnCollisionExit(){} // RVA: 0x7FFAC3D004F0
        public void Reset(){} // RVA: 0x7FFAC3D006B0
        public void get_realtimeSinceStartup_97363D4A8AF7(){} // RVA: 0x7FFAC3D006C0
        public void UpdateRealtimeTimestamp2(){} // RVA: 0x7FFAC3D00750
        public void GetLayoutFlag392(){} // RVA: 0x7FFAC3D00830
        public void Start_AAAB3FFB059C(){} // RVA: 0x7FFAC3D00860
        public void DoGetGraphicsFormat_F24(){} // RVA: 0x7FFAC3D008F0
        public void GetSessionId(){} // RVA: 0x7FFAC3D00980
        public void GetPosition(){} // RVA: 0x7FFAC3D00A10
        public void ParseStandardFormat_51E9D9C61B26(){} // RVA: 0x7FFAC3D00CF0
        public void GetStatus(){} // RVA: 0x7FFAC3D00DE0
        public void InitializeInvokeRepeatingStatics(){} // RVA: 0x7FFAC3D00EB0
        public void GetSelectedDataPointer(){} // RVA: 0x7FFAC3D00F20
        public void ConvertDateTimeToSingle(){} // RVA: 0x7FFAC3D01060
        public void Update_C36BCB8A7928(){} // RVA: 0x7FFAC3D01180
        public void DoHorizontalToVertica(){} // RVA: 0x7FFAC3D01270
        public void ConvertDateTimeToSingle_2D3BA4B63E03(){} // RVA: 0x7FFAC3D01360
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7FFAC3D01470
        public void CaptureVectorSnapshot(){} // RVA: 0x7FFAC3D01B90
        public void GetUnityEngine_46F06DCFA301(){} // RVA: 0x7FFAC3D01CB0
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void Awake(){} // RVA: 0x7FFAC3D025C0
        public void ReadCachedStatusCode(){} // RVA: 0x7FFAC3D029E0
        public void Initialize29A6Statics(){} // RVA: 0x7FFAC3D02AA0
        public void StartCoroutine_3E13206F7687(){} // RVA: 0x7FFAC3D02ED0
        public void InvokeDelayed_48F38611D3D1(){} // RVA: 0x7FFAC3CF7970
        public void set_selectionColor(){} // RVA: 0x7FFAC3D034B0
        public void LateUpdate_97B2617E6FF3(){} // RVA: 0x7FFAC3D034C0
        public void OnApplicationQuit_E0D62724BCF2(){} // RVA: 0x7FFAC3D039F0
        public void OnEnable_B6733F959940(){} // RVA: 0x7FFAC3D03A80
        public void OnApplicationQuit_40B2DC4F02B5(){} // RVA: 0x7FFAC3D03B60
        public void OnDisable_EFD8E1443000(){} // RVA: 0x7FFAC3D03BF0
        public void GetIsCompleted(){} // RVA: 0x7FFAC3D03EA0
        public void ToString(){} // RVA: 0x7FFAC3D03F30
        public void .ctor(){} // RVA: 0x7FFAC3D042C0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3D05390
        public void GetAnimationStyle_E4EEAC72D5A8(){} // RVA: 0x7FFAC3D08470 | overloaded x2
        public void CancelInvoke_213988DCEC48(){} // RVA: 0x7FFAC3D06220
        public void CancelInvoke_5EB89A12854C(){} // RVA: 0x7FFAC3D063C0
        public void SerializeNetworkObjectWithFlags(){} // RVA: 0x7FFAC3D069C0
        public void SetActive(){} // RVA: 0x7FFAC3D06BE0
        public void UpdateTextureObjectProperties_E4B4CC03DAAE(){} // RVA: 0x7FFAC3D07820
        public void OnCollisionEnter_F9AA8C1194CB(){} // RVA: 0x7FFAC3D07980
        public void GetMainCamera(){} // RVA: 0x7FFAC3D07A00
        public void SetOperationCanceled(){} // RVA: 0x7FFAC3D07C50
        public void ReleaseTrackedHandle(){} // RVA: 0x7FFAC3D07CE0
        public void ComputeHashCode_68DFDE9E6FAE(){} // RVA: 0x7FFAC3D07DD0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFAC3D08590
        public void UpdateCoroutineState(){} // RVA: 0x7FFAC3D08C10
        public void GetInvocationList(){} // RVA: 0x7FFAC3D08CB0
        public void GetLastServiceDescriptor_06382DD45D91(){} // RVA: 0x7FFAC3D08DB0
        public void StopAllCoroutines_4DADFAB10360(){} // RVA: 0x7FFAC3D08E40
        public void StopCoroutineByHandle(){} // RVA: 0x7FFAC3D08F60
        public void CopyVectorPayload(){} // RVA: 0x7FFAC3D08FF0
        public void Update(){} // RVA: 0x7FFAC3D09010
        public void InvokeTimedCallback(){} // RVA: 0x7FFAC3D09110
        public void OnCollisionExit_E7CB480B2B18(){} // RVA: 0x7FFAC3D09790
        public void GetDisclaimerText(){} // RVA: 0x7FFAC3D097C0
        public void OnCollisionStay_448A45362AEB(){} // RVA: 0x7FFAC3D09850
        public void GetBackingFieldFromProperty(){} // RVA: 0x7FFAC3D09A30
        public void CancelPendingServiceInvocation(){} // RVA: 0x7FFAC3D09D20
        public void CancelPendingServiceInvocation_FB8FA5352AC8(){} // RVA: 0x7FFAC3D09D30
        public void PackInvocationParameters(){} // RVA: 0x7FFAC3D0A3D0
        public void OpImplicit(){} // RVA: 0x7FFAC3D0A670
        public void SetProcessorParameter(){} // RVA: 0x7FFAC3D0A800
        public void OnBecameVisible_FFE9DD82FFBE(){} // RVA: 0x7FFAC3D0A990
        public void CancelPendingServiceInvocation_B028AA344C29(){} // RVA: 0x7FFAC3D0AA80
        public void SetComponentFlags(){} // RVA: 0x7FFAC3D0B140
        public void CancelPendingServiceInvocation_EA692BE0768D(){} // RVA: 0x7FFAC3D0B1A0
        public void Ensure29A6ThreadContext(){} // RVA: 0x7FFAC3D0B980
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC3D0BA90
        public void GetPhysBoneMaxStretchValue(){} // RVA: 0x7FFAC3D0BC20
        public void get_currentHandTrackingFeatureEnabled(){} // RVA: 0x7FFAC3C8EC30
        public void SetComponentActiveState(){} // RVA: 0x7FFAC3D0C510
        public void OnBecameInvisible_EA151454E329(){} // RVA: 0x7FFAC3D0C5A0
    }

    /// <summary>Originally: ÌÏÎÍÌÍÌÌÎÍÎÍÏÎÌÎÌÏÍÌÏÏÍ</summary>
    public class ComplexComponent_49D1_49D1 : MonoBehaviour
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
        public ÎÍÌÏÍÎÍÏÌÌÎÏÌÏÌÏÎÏÌÎÍÏÎ<0x6B168908> ÌÎÎÎÍÍÍÏÏÍÎÌÎÎÍÌÏÎÍÏÎÌÎ; // 0x3F0
        public ÎÍÌÏÍÎÍÏÌÌÎÏÌÏÌÏÎÏÌÎÍÏÎ<0x6B172258> ÎÏÎÎÎÎÏÎÏÏÏÏÏÍÎÎÎÏÌÏÏÌÌ; // 0x3F8
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB5DE1A0
        public void OnEnable(){} // RVA: 0x7FFACB5DE1D0
        public void OnDisable(){} // RVA: 0x7FFACB5DE200
        public void CancelInvoke(){} // RVA: 0x7FFACB5DE5F0
        public void Invoke(){} // RVA: 0x7FFACB5DE850
        public void InvokeRepeating(){} // RVA: 0x7FFACB5DEC10
        public void CancelInvoke_AF3F77A04EC1(){} // RVA: 0x7FFACB5DED30
        public void IsInvoking(){} // RVA: 0x7FFACB5DF150
        public void StartCoroutine(){} // RVA: 0x7FFACB5DF610
        public void OnApplicationQuit(){} // RVA: 0x7FFACB5DF8B0
        public void OnBecameVisible(){} // RVA: 0x7FFACB5DFAC0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB5DFFE0
        public void StopCoroutine(){} // RVA: 0x7FFACB5DFFF0
        public void OnCollisionStay(){} // RVA: 0x7FFACB5E0360
        public void Start(){} // RVA: 0x7FFACB5E0730
        public void StopAllCoroutines(){} // RVA: 0x7FFACB5E09E0
        public void get_useGUILayout(){} // RVA: 0x7FFACB5E0B50
        public void set_useGUILayout(){} // RVA: 0x7FFACB5E0BC0
        public void print(){} // RVA: 0x7FFACB5E1310
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB5E1690
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFACB5E1700
        public void InvokeDelayed(){} // RVA: 0x7FFACB5E1A00
        public void Awake(){} // RVA: 0x7FFACB5E1E60
        public void OnDestroy(){} // RVA: 0x7FFACB5E3940
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB5E4330
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB5E60A0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB5E6260
        public void StopCoroutineManaged(){} // RVA: 0x7FFACB5E6540
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFACB5E6670
        public void GetScriptClassName(){} // RVA: 0x7FFACB5E69F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFACB5E6A10
        public void GetGameObjectReference3(){} // RVA: 0x7FFACB5E7360
        public void Awake_03737D8618A4(){} // RVA: 0x7FFACB5E7910
        public void OnBecameInvisible(){} // RVA: 0x7FFACB5E7970
        public void OnCollisionEnter(){} // RVA: 0x7FFACB5E7A00
        public void Start_58381140145A(){} // RVA: 0x7FFACB5E8740
        public void OnCollisionExit(){} // RVA: 0x7FFACB5E8950
        public void OnTriggerEnter(){} // RVA: 0x7FFACB5E8A70
        public void OnTriggerStay(){} // RVA: 0x7FFACB5E8B60
        public void OnTriggerExit(){} // RVA: 0x7FFACB5E8B80
        public void OnEnable_9A36DE44090E(){} // RVA: 0x7FFACB5E8C40
        public void Update(){} // RVA: 0x7FFACB5E8F10
        public void UpdateblocksRayc(){} // RVA: 0x7FFACB5E9030
        public void SetGameObjectActive(){} // RVA: 0x7FFACB5E9390
        public void OnApplicationPause(){} // RVA: 0x7FFACB5E97C0
        public void OnApplicationQuit_641B25F57260(){} // RVA: 0x7FFACB5E9940
        public void OnBecameVisible_CA117C93F5C5(){} // RVA: 0x7FFACB5E9A90
        public void OnBecameInvisible_B76B3FEE442E(){} // RVA: 0x7FFACB5E9F30
        public void .ctor(){} // RVA: 0x7FFACB5EA070
        public void Initialize(){} // RVA: 0x7FFACB5EAB80
        public void OnCollisionExit_76439B0C403C(){} // RVA: 0x7FFACB5EADD0
        public void OnTriggerEnter_0F16F3FAC572(){} // RVA: 0x7FFACB5EAF50
        public void OnTriggerStay_9F3992F41E3A(){} // RVA: 0x7FFACB5EB310
        public void OnTriggerExit_4C00E2878340(){} // RVA: 0x7FFACB5EB3C0
        public void FixedUpdate(){} // RVA: 0x7FFACB5EB450
        public void get_mesh(){} // RVA: 0x7FFAC39AD480
        public void LateUpdate(){} // RVA: 0x7FFACB5EB6D0
        public void LateUpdate_97BCE6E9AB22(){} // RVA: 0x7FFACB5EB820
        public void DoStop(){} // RVA: 0x7FFACB5EB8D0
        public void SetGameObjectActive5(){} // RVA: 0x7FFACB5EBA30
        public void GetMaxDampTime(){} // RVA: 0x7FFACB5EBB40
        public void CheckIsDone_D2B(){} // RVA: 0x7FFACB5EBBE0
        public void get_gameObject(){} // RVA: 0x7FFACB5EC220
        public void get_gameObject_ABBBFDC50386(){} // RVA: 0x7FFACB5EC610
        public void GetGameObjectReference(){} // RVA: 0x7FFACB5EC640
        public void get_mesh_CE83D6256815(){} // RVA: 0x7FFAC39AD480
        public void get_gameObject_92B59FD1CC79(){} // RVA: 0x7FFACB5EC720
        public void GetGameObjectReference5(){} // RVA: 0x7FFACB5EC730
        public void SetGameObjectActive4(){} // RVA: 0x7FFACB5ECD50
        public void Start_7438D29FF63F(){} // RVA: 0x7FFACB5ECFD0
        public void OnEnable_0C36E17BF6D1(){} // RVA: 0x7FFACB5ED320
        public void OnGUI(){} // RVA: 0x7FFACB5ED520
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFACB5ED680
        public void OnValidate(){} // RVA: 0x7FFACB5ED7E0
        public void get_gameObject_A43966040E3C(){} // RVA: 0x7FFACB5EDA10
        public void GetRange(){} // RVA: 0x7FFACB5EDD80
        public void DestroyImmediate(){} // RVA: 0x7FFACB5EDFC0
        public void Equals(){} // RVA: 0x7FFACB5EE0E0
        public void ContainsChild(){} // RVA: 0x7FFACB5EE380
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFACB5EE5E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACB5EE940
        public void StartComplexRoutine(){} // RVA: 0x7FFACB5EF070
        public void GetPlatform(){} // RVA: 0x7FFACB5EF190
        public void GetDisclaimerText(){} // RVA: 0x7FFACB5EF250
        public void GetCachedPtr(){} // RVA: 0x7FFACB5EF300
        public void InitializeStartStopDestroy(){} // RVA: 0x7FFACB5EF520
        public void GetInstanceID(){} // RVA: 0x7FFACB5EF6E0
        public void StopComplexRoutine(){} // RVA: 0x7FFACB5EFA60
        public void GetMaskTransform(){} // RVA: 0x7FFACB5EFB80
        public void UpdateStartStopDestroy(){} // RVA: 0x7FFACB5F02E0
        public void GetComplexScriptClass(){} // RVA: 0x7FFACB5F0480
        public void HandleComplexVisibility(){} // RVA: 0x7FFACB5F0570
        public void SetDestroyCancellationToken(){} // RVA: 0x7FFACB5F0660
        public void DoInverseTransform(){} // RVA: 0x7FFACB5F0790
        public void StartCoroutine_Auto_621564668ABB(){} // RVA: 0x7FFACB5F08B0
        public void GetSelectedDataPointer(){} // RVA: 0x7FFACB5F09C0
        public void GetHashCode(){} // RVA: 0x7FFACB5F0AC0
        public void CalculateInitialOffset(){} // RVA: 0x7FFACB5F0BD0
        public void Awake_FF3ED4332166(){} // RVA: 0x7FFACB5F0BE0
        public void CancelInvoke_9D4AB095CD36(){} // RVA: 0x7FFACB5F0BF0
        public void GetUseGUILayout(){} // RVA: 0x7FFACB5F0C50
        public void UpdateGameObjectActiveStates(){} // RVA: 0x7FFACB5F0E70
        public void UpdateActive(){} // RVA: 0x7FFACB5F15C0
        public void GetLast(){} // RVA: 0x7FFACB5F1750
        public void ComputeactiveSelf(){} // RVA: 0x7FFACB5F1860
        public void Start_56BB5D0DEDA7(){} // RVA: 0x7FFACB5F1970
        public void DoEncodeToPN(){} // RVA: 0x7FFACB5F1AE0
        public void ProcessStartStopDestroy(){} // RVA: 0x7FFACB5F1C90
        public void __get_Multiline__SystemTextRegularExpressionsRegexOptions(){} // RVA: 0x7FFACB5F2350
    }

    /// <summary>Originally: ÌÌÎÍÍÌÌÍÏÍÍÍÏÌÍÍÎÍÍÎÌÌÎ</summary>
    public class ComplexComponent_5D5C_5D5C : MonoBehaviour
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
        public System.Action`2<bool,0x6B234E18> f_80C; // 0x70
        public System.Action`1<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> f_748; // 0x78
        public System.Action f_A09; // 0x80
        public System.Action f_637; // 0x88
        public System.Action`1<bool> f_94A; // 0x90
        public System.Action f_840; // 0x98
        public ÍÏÏÍÌÏÎÏÌÏÌÍÏÏÌÏÌÎÍÏÎÎÌ f_3AD; // 0xA0
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
        public ÌÍÎÍÌÌÏÍÌÌÎÏÌÏÎÏÎÌÌÌÎÎÎ ÍÍÏÍÌÌÏÏÎÏÌÌÏÍÌÍÍÍÏÎÎÌÎ; // 0x120
        public System.Threading.CancellationTokenSource ÎÎÌÏÎÏÌÍÍÏÎÌÌÏÍÌÍÌÎÏÏÌÍ; // 0x128
        public System.Collections.Generic.List`1<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ> ÏÌÏÍÍÌÎÌÏÎÏÍÎÏÎÌÌÎÎÍÏÍÏ; // 0x130

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB36D010
        public void RaiseCancellation(){} // RVA: 0x7FFACB36D0E0
        public void IsInvoking(){} // RVA: 0x7FFACB36D1D0
        public void set_featuredAvatarCategoryId(){} // RVA: 0x7FFAC3143400
        public void Invoke(){} // RVA: 0x7FFACB36D2A0
        public void InvokeRepeating(){} // RVA: 0x7FFACB36D3A0
        public void CancelInvoke(){} // RVA: 0x7FFACB36D570
        public void GetTypeCode(){} // RVA: 0x7FFACB36D590
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void StartCoroutine(){} // RVA: 0x7FFACB36D5B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB36D610
        public void StopCoroutine(){} // RVA: 0x7FFACB36D8A0
        public void get_CanBeNull(){} // RVA: 0x7FFAC4B82F20
        public void ToBoolean(){} // RVA: 0x7FFACB36D940
        public void StopAllCoroutines(){} // RVA: 0x7FFACB36DAC0
        public void Awake(){} // RVA: 0x7FFACB36DBC0
        public void set_useGUILayout(){} // RVA: 0x7FFACB36DBD0
        public void print(){} // RVA: 0x7FFACB36DC90
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB36DFB0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC2F21310
        public void InvokeDelayed(){} // RVA: 0x7FFACB36E020
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void OnTriggerExit_47EB68DD7E57_47EB68DD7E57(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB36E1A0
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB36E290
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB36E480
        public void StopCoroutineManaged(){} // RVA: 0x7FFACB36E560
        public void GetMainCamera(){} // RVA: 0x7FFAC36D1F40
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void get_featuredAvatarCategoryId(){} // RVA: 0x7FFAC313CBB0
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void OnTriggerStay(){} // RVA: 0x7FFACB36E590
        public void ToChar(){} // RVA: 0x7FFAC2F21310
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFAC386C550
        public void get_Created(){} // RVA: 0x7FFAC781E0A0
        public void ToSByte(){} // RVA: 0x7FFACB36E5B0
        public void ToByte(){} // RVA: 0x7FFACB36E6B0
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void ToInt16(){} // RVA: 0x7FFACB36E8C0
        public void Start(){} // RVA: 0x7FFACB36EA40
        public void FixedUpdate(){} // RVA: 0x7FFACB36EB50
        public void Update(){} // RVA: 0x7FFACB36EBF0
        public void LateUpdate(){} // RVA: 0x7FFACB36FB60
        public void ToUInt16(){} // RVA: 0x7FFACB36D590
        public void OnDestroy(){} // RVA: 0x7FFAC2F21310
        public void OnApplicationPause(){} // RVA: 0x7FFACB36FBB0
        public void ToBoolean_3268EEDB4637(){} // RVA: 0x7FFAC2F424C0
        public void IsResource(){} // RVA: 0x7FFAC31D95D0
        public void OnBecameInvisible(){} // RVA: 0x7FFACB36FD20
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3543900
        public void get_blurPasses(){} // RVA: 0x7FFAC8C068C0
        public void OnCollisionExit(){} // RVA: 0x7FFAC2C58E90
        public void OnTriggerEnter(){} // RVA: 0x7FFACB36FE20
        public void ToInt32(){} // RVA: 0x7FFACB36FE40
        public void ToUInt32(){} // RVA: 0x7FFAC2F21310
        public void ToInt64(){} // RVA: 0x7FFAC2F21310
        public void ToDateTime(){} // RVA: 0x7FFAC2FE9500
        public void ResolveComponentProperty(){} // RVA: 0x7FFACB36FF00
        public void ToUInt64(){} // RVA: 0x7FFACB36FFF0
        public void ToSingle(){} // RVA: 0x7FFACB3700E0
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFAC31E7D90
        public void ToDouble(){} // RVA: 0x7FFACB3701D0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFACB370380
        public void ToDecimal(){} // RVA: 0x7FFACB3703E0
        public void ToString(){} // RVA: 0x7FFACB3709D0
        public void UpdateActive(){} // RVA: 0x7FFACB370A10
        public void op_Implicit(){} // RVA: 0x7FFAC44F81E0
        public void ToType(){} // RVA: 0x7FFACB370C00
        public void Awake_0EACF06453AE(){} // RVA: 0x7FFACB370DA0
        public void set_pointerId(){} // RVA: 0x7FFAC9C7A8E0
        public void Start_6861B69187EE(){} // RVA: 0x7FFACB370DF0
        public void get_disclaimerText(){} // RVA: 0x7FFAC3079460
        public void SetConnectedBody4(){} // RVA: 0x7FFAC2F21310
        public void set_name(){} // RVA: 0x7FFAC44F81E0
        public void Initialize_2E8FD6547269_2E8FD6547269(){} // RVA: 0x7FFACB371CB0 | overloaded x2
        public void OnDisable(){} // RVA: 0x7FFACB370E20
        public void BuildPoseArguments(){} // RVA: 0x7FFACB370E70
        public void Update_84A206AF7E24(){} // RVA: 0x7FFACB370EC0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC8C068C0
        public void OnBecameVisible(){} // RVA: 0x7FFACB370FB0
        public void OnSerializing(){} // RVA: 0x7FFAC2FE9500
        public void SetResources_1FF4DC82BF07(){} // RVA: 0x7FFAC31E5C40
        public void OnCollisionStay(){} // RVA: 0x7FFACB371230
        public void get_IgnoreDefaultValuesOnWrite(){} // RVA: 0x7FFAC4B82F30
        public void InitializeGameObjectGetter(){} // RVA: 0x7FFACB371250
        public void ValidateBounds_43306D7A9C3D_43306D7A9C3D(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void OnDestroy_6C31885CF8AC(){} // RVA: 0x7FFACB371350
        public void Internal_CancelInvokeAll_4412BCBE55CA(){} // RVA: 0x7FFACB371370
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void ResolveComponentProperty_B308415BFDB8(){} // RVA: 0x7FFACB3714C0
        public void set_trackerAnchor(){} // RVA: 0x7FFAC2FBF380
        public void OnEnable_F9557EA8BA59(){} // RVA: 0x7FFACB371510
        public void .ctor(){} // RVA: 0x7FFACB371600
        public void .cctor(){} // RVA: 0x7FFACB371DC0
        public void IsSetup(){} // RVA: 0x7FFAC30F6BA0
        public void GetUnityEngine(){} // RVA: 0x7FFACB371E00
        public void OnEnable(){} // RVA: 0x7FFACB371F00
        public void SetConnectedBody2(){} // RVA: 0x7FFAC2F21310
        public void set_Color(){} // RVA: 0x7FFAC3C24F40
        public void SetGameObjectActive2(){} // RVA: 0x7FFACB371F50
        public void SetGameObjectActive3(){} // RVA: 0x7FFACB372050
        public void SetGameObjectActive(){} // RVA: 0x7FFACB372400
        public void OnDisable_52D3FA58E3AC(){} // RVA: 0x7FFACB372680
        public void SetGameObjectActive6(){} // RVA: 0x7FFACB372880
        public void SetConnectedBody3(){} // RVA: 0x7FFAC2F21310
        public void SetGameObjectActive_509B47EE515C(){} // RVA: 0x7FFACB372970
        public void SetGameObjectActive5(){} // RVA: 0x7FFACB372990
        public void SetGameObjectActive4(){} // RVA: 0x7FFACB372A90
        public void ToDateTime_C9F53CC79683(){} // RVA: 0x7FFACB3709D0
        public void OnDestroy_92B59FD1CC79(){} // RVA: 0x7FFACB372B50
        public void InitializeOwnedSlot(){} // RVA: 0x7FFAC2F4F0C0
    }

    /// <summary>Originally: ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍÍÏÎ</summary>
    public class ComplexComponent_6FD4_6FD4 : MonoBehaviour
    {
        public ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍÍÏÎ _destroyCancellationToken;
        public System.Collections.Generic.Dictionary`2<0x6AFFC2B0,System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>>> _useGUILayout; // 0x20
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
        public 0x6B16D2F0 ÌÏÏÏÍÍÍÏÍÎÌÍÏÌÎÎÌÎÎÎÏÍÍ; // 0xF8
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3E59140
        public void RaiseCancellation(){} // RVA: 0x7FFAC3E598B0
        public void IsInvoking(){} // RVA: 0x7FFAC3E59C10
        public void Update(){} // RVA: 0x7FFAC3E59C20
        public void Invoke(){} // RVA: 0x7FFAC3E5A050
        public void InvokeRepeating(){} // RVA: 0x7FFAC3E5A0D0
        public void UpdateComplexComponentState(){} // RVA: 0x7FFAC3E5A480
        public void OnApplicationPause(){} // RVA: 0x7FFAC3E5A490
        public void StartCoroutine(){} // RVA: 0x7FFAC3E5A4A0
        public void OnBecameVisible(){} // RVA: 0x7FFAC3E5A5D0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3E5B050
        public void get_preserveAspect(){} // RVA: 0x7FFAC3E5B1F0
        public void StopCoroutine(){} // RVA: 0x7FFAC3E5B200
        public void OnCollisionExit(){} // RVA: 0x7FFAC3E5B3D0
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3E5B5E0
        public void get_useGUILayout(){} // RVA: 0x7FFAC3E5B670
        public void set_useGUILayout(){} // RVA: 0x7FFAC3E5B680
        public void print(){} // RVA: 0x7FFAC3E5B910
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3E5B990
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3E5BD60
        public void InvokeDelayed(){} // RVA: 0x7FFAC3E5BFE0
        public void SetActionBinding_sub(){} // RVA: 0x7FFAC3E5C150
        public void DoFindRelativeTransformWithPath_B1A(){} // RVA: 0x7FFAC3E5C730
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3E5CDB0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3E5CF00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3E5D0A0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC3E5D3A0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3E5D810
        public void GetScriptClassName(){} // RVA: 0x7FFAC3E5D950
        public void get_contentList(){} // RVA: 0x7FFAC3540F70
        public void ReadCameraState(){} // RVA: 0x7FFAC3E5D980
        public void get_HttpProxy(){} // RVA: 0x7FFAC33A98A0
        public void ReadCameraState_C060DB1D8E52(){} // RVA: 0x7FFAC3E5D990
        public void LateUpdate(){} // RVA: 0x7FFAC3E5DC90
        public void get_fillCenter(){} // RVA: 0x7FFAC3E5DCB0
        public void OnDestroy(){} // RVA: 0x7FFAC3E5DCC0
        public void LateUpdate_E02F6BBD4B0C(){} // RVA: 0x7FFAC3E5DD80
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3E5E140
        public void OnApplicationQuit_E91B15EA4181(){} // RVA: 0x7FFAC3E5E2E0
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC2F8C040
        public void OnCollisionStay(){} // RVA: 0x7FFAC3E5EB50
        public void ConvertDateTimeToSingle(){} // RVA: 0x7FFAC3E5EC90
        public void SetGameObjectActive3(){} // RVA: 0x7FFAC3E5EDA0
        public void get_featuredAvatarCategoryId(){} // RVA: 0x7FFAC313CBB0
        public void OnTriggerExit(){} // RVA: 0x7FFAC3E5EDB0
        public void HasVideo(){} // RVA: 0x7FFAC3E5EE50
        public void ResetDestroyCancellationToken(){} // RVA: 0x7FFAC3E5FF10
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void AppendCore(){} // RVA: 0x7FFAC3E60210
        public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
        public void GetUseGUILayout(){} // RVA: 0x7FFAC3E62820
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFAC2F8C600
        public void set_hasSelection(){} // RVA: 0x7FFAC3E62830
        public void get_name(){} // RVA: 0x7FFAC3E62840
        public void CancelInvoke(){} // RVA: 0x7FFAC3E62980
        public void get_onPressed(){} // RVA: 0x7FFAC2F8C120
        public void GetInstanceID(){} // RVA: 0x7FFAC3E62B60
        public void GetTexture(){} // RVA: 0x7FFAC303E100
        public void set_isPointerDown(){} // RVA: 0x7FFAC3E62B70
        public void DoFindRelativeTransformWithPath_B1A_B607C9594FCD(){} // RVA: 0x7FFAC3E62B80
        public void get_categories(){} // RVA: 0x7FFAC34F6C80
        public void set_categories(){} // RVA: 0x7FFAC34F6750
        public void get_disclaimerText(){} // RVA: 0x7FFAC3079460
        public void ResetUseGUILayout(){} // RVA: 0x7FFAC3E62D90
        public void HandleUseGUILayout(){} // RVA: 0x7FFAC3E62FE0
        public void get_MotionBlurCameras(){} // RVA: 0x7FFAC354DFA0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC3E634D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3E634E0
        public void HandleUseGUILayoutDestroyCancellationToken(){} // RVA: 0x7FFAC3E63680
        public void .ctor(){} // RVA: 0x7FFAC3E63990
        public void Initialize(){} // RVA: 0x7FFAC3E65120
        public void HandlePointerHover(){} // RVA: 0x7FFAC3E652C0
        public void get_destroyCancellationToken_BCBB1141DB1A(){} // RVA: 0x7FFAC3E655A0
        public void HandlePointerDrag(){} // RVA: 0x7FFAC3E65630
        public void HandlePointerDragDestroyCancellationToken(){} // RVA: 0x7FFAC3E65640
        public void HandleRectTransform(){} // RVA: 0x7FFAC3E65780
        public void HandleRectTransformDestroyCancellationToken(){} // RVA: 0x7FFAC3E657F0
        public void HasAudio(){} // RVA: 0x7FFAC2FA2AD0
        public void ovr_FreeMessage(){} // RVA: 0x7FFAC3E65FD0
        public void HandleLayoutState(){} // RVA: 0x7FFAC3E66120
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFAC3E66180
        public void Awake_66DAF597F4F3(){} // RVA: 0x7FFAC3E662C0
        public void HandleTabContent(){} // RVA: 0x7FFAC3E66480
        public void HasVideo_DAEE8E6FB8DC(){} // RVA: 0x7FFAC3E66730
        public void HasVideo_5E919D5007E2(){} // RVA: 0x7FFAC3E66780
        public void HandleObservableListDestroyCancellationToken(){} // RVA: 0x7FFAC3E66790
        public void HasVideo_141B5DDEB2E1(){} // RVA: 0x7FFAC3E667A0
        public void get_promotion(){} // RVA: 0x7FFAC33BC6D0
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void HandleScrollStateDestroyCancellationToken(){} // RVA: 0x7FFAC3E66880
        public void Awake(){} // RVA: 0x7FFAC3E66A70
        public void OnEnable(){} // RVA: 0x7FFAC3E672D0
        public void UpdateRealtimeTimestamp(){} // RVA: 0x7FFAC3E672E0
        public void HasVideo_8CEFDF695D83(){} // RVA: 0x7FFAC3E675E0
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void ResetVisibilityState(){} // RVA: 0x7FFAC3E67E70
        public void OnDisable(){} // RVA: 0x7FFAC3E67F50
        public void HandlePreCullState(){} // RVA: 0x7FFAC3E680E0
        public void ComputeHashCode(){} // RVA: 0x7FFAC3E684C0
        public void HandlePreCullStateDestroyCancellationToken(){} // RVA: 0x7FFAC3E68600
        public void UpdateComplexComponentState_0D1BAA95D5F6(){} // RVA: 0x7FFAC3E68850
        public void ComputeHashCode_A3F6AE95C128(){} // RVA: 0x7FFAC3E68950
        public void GetColliderComponents_E8F29942BC02(){} // RVA: 0x7FFAC3543900
        public void UpdatePointerDrag(){} // RVA: 0x7FFAC3E68DE0
        public void get_UploadLength(){} // RVA: 0x7FFAC2F8C5F0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3E68E00
        public void OnTriggerStay(){} // RVA: 0x7FFAC3E69570
        public void set_ProtocolHandler(){} // RVA: 0x7FFAC3E69950
        public void UpdatePointerDragDestroyCancellationToken(){} // RVA: 0x7FFAC3E69960
        public void get_useGUILayout_08C1C769F4D7(){} // RVA: 0x7FFAC3E5B670
        public void get_ProtocolHandler(){} // RVA: 0x7FFAC3E69A60
        public void UpdateRectTransformDestroyCancellationToken(){} // RVA: 0x7FFAC3E69BA0
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void get_ProtocolHandler_133FA53CB330(){} // RVA: 0x7FFAC3E69BB0
        public void ComputeHashCode_45AF8AE344FC(){} // RVA: 0x7FFAC3E69CA0
        public void UpdateTabContent(){} // RVA: 0x7FFAC3E6A060
        public void get_Headers(){} // RVA: 0x7FFAC3542410
        public void GetSource(){} // RVA: 0x7FFAC3544340
        public void UpdateTabContentDestroyCancellationToken(){} // RVA: 0x7FFAC3E6A070
        public void UpdateObservableList(){} // RVA: 0x7FFAC3E6A0A0
        public void Sequence(){} // RVA: 0x7FFAC3006850
        public void InvokePrimaryAndSecondaryCallbacks(){} // RVA: 0x7FFAC3E6A990
        public void get_search(){} // RVA: 0x7FFAC2FA2970
        public void get_listingIds(){} // RVA: 0x7FFAC35466F0
        public void UpdateObservableListDestroyCancellationToken(){} // RVA: 0x7FFAC3E6AE40
        public void UpdateScrollState(){} // RVA: 0x7FFAC3E6AF80
        public void SetGameObjectActive3_BD2B28AF46F7(){} // RVA: 0x7FFAC3E6D270
        public void get_domainList(){} // RVA: 0x7FFAC2FA2900
        public void SetGameObjectActive(){} // RVA: 0x7FFAC3E6D6F0
        public void SetGameObjectActive_93D0DDA1F28C(){} // RVA: 0x7FFAC3E6D8D0
        public void GetUnityEngine(){} // RVA: 0x7FFAC3E6DA20
        public void get_taglineText(){} // RVA: 0x7FFAC354B1A0
        public void GetUnityEngine_D5D657A4FC21(){} // RVA: 0x7FFAC3E6DA60
        public void RefreshUseGUILayout(){} // RVA: 0x7FFAC3E6DAF0
        public void SetGameObjectActive_058F735D89DA(){} // RVA: 0x7FFAC3E6DC30
        public void set_vectorImage(){} // RVA: 0x7FFAC3E6E1D0
        public void RefreshPointerHover(){} // RVA: 0x7FFAC2F21320
        public void GetAudioTracks(){} // RVA: 0x7FFAC32EF640
        public void GetUnityEngine_6DDDDE54C7AA(){} // RVA: 0x7FFAC3E6E1E0
        public void GetUnityEngine_81BE4A0A14E7(){} // RVA: 0x7FFAC3E6E2D0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3E6E330
        public void Start(){} // RVA: 0x7FFAC3E6E850
        public void GetTransformReference(){} // RVA: 0x7FFAC3E6E870
        public void get_rebuildTargetParent(){} // RVA: 0x7FFAC2F8C660
        public void SetGameObjectActive4(){} // RVA: 0x7FFAC3E6EB60
        public void RefreshPointerDragDestroyCancellationToken(){} // RVA: 0x7FFAC3E6ECA0
    }

    /// <summary>Originally: ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ</summary>
    public class ComplexComponent_7316_7316 : MonoBehaviour
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
        public System.Collections.Generic.List`1<System.ValueTuple`2<float,0x6AFE84B8>> f_6F0; // 0x38
        public 0x6AFE8568 f_2C6; // 0x20
        public 0x6AFE8460 f_6AF; // 0x24
        public 0x6AFE84B8 f_CC8; // 0x28
        public 0x6AFE8510 ÎÍÌÌÍÌÌÍÎÍÌÌÍÍÌÌÎÌÎÌÌÏÌ; // 0x2C
        public float ÏÍÎÎÍÍÏÍÍÍÏÌÍÌÎÍÌÍÍÎÍÎÎ;
        public 0x6AFE85C0 ÎÍÏÏÎÌÏÎÎÏÍÏÌÎÌÍÎÍÌÏÌÍÏ; // 0x30
        public bool ÎÎÎÎÎÌÏÎÌÌÌÏÍÎÍÎÏÍÌÏÏÌÎ; // 0x34
        public 0x6AFE8618 ÍÎÎÍÏÏÏÍÌÌÍÌÍÍÍÍÏÏÍÌÌÌÍ; // 0x38
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
        public ÌÍÌÌÌÏÌÍÏÌÎÎÏÌÏÏÍÍÍÏÏÏÎ <ÌÎÎÍÎÌÌÍÏÏÎÏÏÌÏÌÌÎÌÍÎÍÌ>k__BackingField; // 0x78
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
        public 0x6AFE8460 ÎÏÍÌÎÌÍÏÍÎÏÎÍÍÍÌÏÏÎÎÎÌÎ; // 0x15C
        public 0x6AFE84B8 ÍÌÏÎÍÎÍÍÌÍÏÍÏÎÌÏÎÎÏÍÏÍÍ; // 0x160
        public 0x6AFE8618 ÎÍÌÍÎÌÌÎÎÏÌÏÍÎÍÎÏÌÎÏÏÌÏ; // 0x164
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
        public 0x6AFE8670 ÌÏÏÌÏÌÎÌÎÌÍÏÍÌÎÍÌÌÌÍÎÍÏ; // 0x1C4
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC30DD010
        public void RaiseCancellation(){} // RVA: 0x7FFAC30DD1E0
        public void LateUpdate(){} // RVA: 0x7FFAC30DD490
        public void CancelInvoke(){} // RVA: 0x7FFAC30DD4C0
        public void Invoke(){} // RVA: 0x7FFAC30DD7A0
        public void InvokeRepeating(){} // RVA: 0x7FFAC30DDB30
        public void OnApplicationQuit(){} // RVA: 0x7FFAC30DDC80
        public void IsInvoking(){} // RVA: 0x7FFAC30DDEB0
        public void StartCoroutine(){} // RVA: 0x7FFAC30DE060
        public void OnDestroy(){} // RVA: 0x7FFAC30DE150
        public void OnCollisionStay(){} // RVA: 0x7FFAC30DE9C0
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void StopCoroutine(){} // RVA: 0x7FFAC30DEF80
        public void OnTriggerStay(){} // RVA: 0x7FFAC30DF040
        public void OnTriggerExit(){} // RVA: 0x7FFAC30DF630
        public void StopAllCoroutines(){} // RVA: 0x7FFAC30DF6A0
        public void get_useGUILayout(){} // RVA: 0x7FFAC30DF7D0
        public void set_useGUILayout(){} // RVA: 0x7FFAC30DF8E0
        public void print(){} // RVA: 0x7FFAC30DF8F0
        public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC30E0750
        public void InvokeDelayed(){} // RVA: 0x7FFAC30E09D0
        public void set_contentList(){} // RVA: 0x7FFAC30E0A40
        public void IsInvoking_FE04B31E30C4(){} // RVA: 0x7FFAC30E0B40
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC30E0C30
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC30E0DF0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC30E0F50
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC30E10A0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC30E1110
        public void GetScriptClassName(){} // RVA: 0x7FFAC30E12D0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC30E1720
        public void GetGameObject_02C(){} // RVA: 0x7FFAC30E17A0
        public void GetTextTracks(){} // RVA: 0x7FFAC30E19B0
        public void WriteVector3(){} // RVA: 0x7FFAC30E2590
        public void GetGameObject_02C_F76404898C54(){} // RVA: 0x7FFAC30E2990
        public void set_worldTag(){} // RVA: 0x7FFAC30E2C60
        public void LoadImageUrl(){} // RVA: 0x7FFAC30E2D10
        public void .ctor(){} // RVA: 0x7FFAC30E2F00
        public void Initialize(){} // RVA: 0x7FFAC30E35D0
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void GetBytePair(){} // RVA: 0x7FFAC30E3630
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC30E3640
        public void GetVideoTracks(){} // RVA: 0x7FFAC30E3810
        public void GetVideoTracks_6B3F74EE3F4A(){} // RVA: 0x7FFAC30E3980
        public void ResetPendingState(){} // RVA: 0x7FFAC30E4C80
        public void GetUInt16Value(){} // RVA: 0x7FFAC30E4CD0
        public void CreateRangeValue(){} // RVA: 0x7FFAC30E5390
        public void Callback(){} // RVA: 0x7FFAC30E54B0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void Computealpha(){} // RVA: 0x7FFAC30E5610
        public void CheckGameObjectActive(){} // RVA: 0x7FFAC30E57B0
        public void GetGameObject_106(){} // RVA: 0x7FFAC30E58F0
        public void StringToHash(){} // RVA: 0x7FFAC30E5A50
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFAC30E5AB0
        public void set_MaterialForRenderingInternal(){} // RVA: 0x7FFAC30E5B20
        public void ApplyRigidbodyVelocity(){} // RVA: 0x7FFAC30E5FD0
        public void OnEnable(){} // RVA: 0x7FFAC30E6030
        public void Start(){} // RVA: 0x7FFAC30E6090
        public void FixedUpdate(){} // RVA: 0x7FFAC30E6130
        public void set_iconImageUrl(){} // RVA: 0x7FFAC30E6190
        public void UpdateTextTracks(){} // RVA: 0x7FFAC30E61A0
        public void OnDisable(){} // RVA: 0x7FFAC30E61F0
        public void GetHashCode(){} // RVA: 0x7FFAC30E6AB0
        public void OnApplicationPause(){} // RVA: 0x7FFAC30E6E80
        public void RefreshContentList(){} // RVA: 0x7FFAC30E6F40
        public void OnBecameVisible(){} // RVA: 0x7FFAC30E7030
        public void OnBecameInvisible(){} // RVA: 0x7FFAC30E7040
        public void OnCollisionEnter(){} // RVA: 0x7FFAC30E73A0
        public void SetByteValue(){} // RVA: 0x7FFAC30E74A0
        public void OnCollisionExit(){} // RVA: 0x7FFAC30E7660
        public void OnTriggerEnter(){} // RVA: 0x7FFAC30E7910
        public void OnTriggerEnter_9B86FA487188(){} // RVA: 0x7FFAC30E7990
        public void GetInstanceID(){} // RVA: 0x7FFAC30E7BA0
        public void ApplyModelShader(){} // RVA: 0x7FFAC30E7F50
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFAC30E80B0
        public void EndsWithCultureHelper(){} // RVA: 0x7FFAC30E80C0
        public void HandleTriggerStay(){} // RVA: 0x7FFAC30E83E0
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7FFAC30E84D0
        public void VerifyMutable(){} // RVA: 0x7FFAC30E86F0
        public void VerifyMutable_B5FC92693373(){} // RVA: 0x7FFAC30E8830
        public void CopyBufferedValue(){} // RVA: 0x7FFAC30E8930
        public void OnBecameVisible_66BF254947EB(){} // RVA: 0x7FFAC30E7030
        public void InitializeMedia(){} // RVA: 0x7FFAC30E8A20
        public void FetchContent(){} // RVA: 0x7FFAC30E8BE0
        public void Update(){} // RVA: 0x7FFAC30E9050
        public void SetVectorValue(){} // RVA: 0x7FFAC30E9330
        public void op_Implicit(){} // RVA: 0x7FFAC30E97D0
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine_99F1F6A73BD6(){} // RVA: 0x7FFAC30E99D0
        public void set_preferredWidth(){} // RVA: 0x7FFAC30E9A30
        public void ProcessTracks(){} // RVA: 0x7FFAC30E9E00
        public void Awake(){} // RVA: 0x7FFAC30EA080
        public void VerifyMutable_B5F62FD88E08(){} // RVA: 0x7FFAC30EA950
        public void SetReferencedObject(){} // RVA: 0x7FFAC30EAB10
        public void DoTransformDirecti(){} // RVA: 0x7FFAC30EAD00
        public void Initialize_2C1CEFAA639D(){} // RVA: 0x7FFAC30EAD60
        public void UpdateUIState(){} // RVA: 0x7FFAC30EAD70
        public void get_copyMaterial(){} // RVA: 0x7FFAC30EB2F0
        public void EnsureType5Wrapper(){} // RVA: 0x7FFAC30EB750
        public void AttachChildNode(){} // RVA: 0x7FFAC30EB840
        public void set_name(){} // RVA: 0x7FFAC30EB8A0
        public void .cctor(){} // RVA: 0x7FFAC30EBDF0
        public void SetupShader(){} // RVA: 0x7FFAC30ED4B0
        public void SetInt32Value(){} // RVA: 0x7FFAC30ED5A0
        public void CacheImageUrl(){} // RVA: 0x7FFAC30ED600
        public void GetGameObject_C8F(){} // RVA: 0x7FFAC30ED860
        public void StartCoroutine_BF30F23CE1D7(){} // RVA: 0x7FFAC30ED9C0
        public void CreateType4ENode(){} // RVA: 0x7FFAC30EDAD0
        public void CreateChildNode(){} // RVA: 0x7FFAC30EDF80
        public void ValidateStateAndCall(){} // RVA: 0x7FFAC30EE8B0
        public void RenderContent(){} // RVA: 0x7FFAC30EE930
        public void set_Method(){} // RVA: 0x7FFAC30EE990
        public void ClearTextTracks(){} // RVA: 0x7FFAC30EEE50
        public void UpdateColorImpl_Inje(){} // RVA: 0x7FFAC30EEF40
        public void get_DurationType(){} // RVA: 0x7FFAC30EF4E0
        public void TryGetInt32Value(){} // RVA: 0x7FFAC30EF4F0
        public void DoTransformDirecti_930F8F3EE47F(){} // RVA: 0x7FFAC30EF640
        public void StopCoroutine_40A5A9520ED3(){} // RVA: 0x7FFAC30EF6E0
        public void ConfiguresortingOrder(){} // RVA: 0x7FFAC30EF740
        public void CreateType90Node(){} // RVA: 0x7FFAC30EF8D0
        public void UpdateColorImpl_Inje_95B4E65902C4(){} // RVA: 0x7FFAC30EFD80
        public void StopMediaPlayback(){} // RVA: 0x7FFAC30EFD90
        public void UpdateState(){} // RVA: 0x7FFAC30EFE50
        public void PlayMedia(){} // RVA: 0x7FFAC30F00D0
        public void PauseMedia(){} // RVA: 0x7FFAC30F00F0
        public void get_BindingFlags(){} // RVA: 0x7FFAC30F08A0
        public void GetDeltaTime_79A(){} // RVA: 0x7FFAC30F0C10
        public void ValidateContent(){} // RVA: 0x7FFAC30F0C80
    }

    /// <summary>Originally: ÍÎÍÌÏÏÌÌÌÍÌÍÏÎÍÌÎÍÍÌÍÌÎ</summary>
    public class ComplexComponent_7679_7679 : MonoBehaviour
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
        public void Awake(){} // RVA: 0x7FFAC4218FA0
        public void RaiseCancellation(){} // RVA: 0x7FFAC421D800
        public void IsInvoking(){} // RVA: 0x7FFAC421DAF0
        public void CancelInvoke(){} // RVA: 0x7FFAC421DC00
        public void Invoke(){} // RVA: 0x7FFAC421DD50
        public void InvokeRepeating(){} // RVA: 0x7FFAC421DE10
        public void OnDisable(){} // RVA: 0x7FFAC421DFF0
        public void IsInvoking_6D0F179363BA(){} // RVA: 0x7FFAC421E9B0
        public void StartCoroutine(){} // RVA: 0x7FFAC421EAA0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC421EB00
        public void OnBecameVisible(){} // RVA: 0x7FFAC421ED10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC421F070
        public void StopCoroutine(){} // RVA: 0x7FFAC421F0C0
        public void OnCollisionStay(){} // RVA: 0x7FFAC421F190
        public void GetGameObjectReference3(){} // RVA: 0x7FFAC421F5F0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC421F870
        public void get_useGUILayout(){} // RVA: 0x7FFAC421F920
        public void set_useGUILayout(){} // RVA: 0x7FFAC421FAA0
        public void print(){} // RVA: 0x7FFAC42203F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC4220480
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC42206B0
        public void InvokeDelayed(){} // RVA: 0x7FFAC4220780
        public void GetComponentTransform(){} // RVA: 0x7FFAC4220AD0
        public void GetComponentTransform_178FB10C4E8A(){} // RVA: 0x7FFAC4220B60
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC4220CE0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC4220E00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC4220F10
        public void Update(){} // RVA: 0x7FFAC4221060
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC4221070
        public void GetScriptClassName(){} // RVA: 0x7FFAC42210E0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC4221310
        public void OnApplicationPause(){} // RVA: 0x7FFAC42213B0
        public void SetGameObjectActive4(){} // RVA: 0x7FFAC4221B70
        public void OnTriggerExit(){} // RVA: 0x7FFAC4221C50
        public void OnBecameInvisible(){} // RVA: 0x7FFAC4221D70
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4221EB0
        public void ValidateGameObjectComponents(){} // RVA: 0x7FFAC4221F80
        public void OnCollisionExit(){} // RVA: 0x7FFAC4222150
        public void Start(){} // RVA: 0x7FFAC4222450
        public void OnTriggerStay(){} // RVA: 0x7FFAC4222810
        public void GetUnityEngine(){} // RVA: 0x7FFAC4222920
        public void LateUpdate(){} // RVA: 0x7FFAC4222AE0
        public void SetGameObjectActive(){} // RVA: 0x7FFAC4222D40
        public void OnTriggerStay_E37D71D9E03D(){} // RVA: 0x7FFAC4223020
        public void OnTriggerExit_57BA265D72B9(){} // RVA: 0x7FFAC4223070
        public void OnApplicationQuit_8ECA04774C99(){} // RVA: 0x7FFAC42233C0
        public void OnBecameVisible_4830D6DD2BA0(){} // RVA: 0x7FFAC42236C0
        public void OnBecameInvisible_4BEDA6651412(){} // RVA: 0x7FFAC4226CD0
        public void ExecuteCoroutine(){} // RVA: 0x7FFAC4226DE0
        public void Initialize(){} // RVA: 0x7FFAC4226E70
        public void OnCollisionExit_B3C4F058F9D6(){} // RVA: 0x7FFAC4227060
        public void OnTriggerEnter(){} // RVA: 0x7FFAC2F21310
        public void OnTriggerStay_D87309BF7556(){} // RVA: 0x7FFAC42270E0
        public void OnTriggerExit_FC87FD55BFDE(){} // RVA: 0x7FFAC4227260
        public void CancelCoroutine(){} // RVA: 0x7FFAC42273F0
        public void ManageCoroutines(){} // RVA: 0x7FFAC4227440
        public void SetGameObjectActive_EF27A2829688(){} // RVA: 0x7FFAC4227530
        public void LateUpdate_2CFF667DA0DD(){} // RVA: 0x7FFAC42275C0
        public void DoStop(){} // RVA: 0x7FFAC4227640
        public void ComputeisActiveAndE(){} // RVA: 0x7FFAC4227730
        public void GetMaxDampTime(){} // RVA: 0x7FFAC4227830
        public void EnsureSecondaryController(){} // RVA: 0x7FFAC4227930
        public void SetActiveState(){} // RVA: 0x7FFAC4227A30
        public void SetReversedPlaybackFlag(){} // RVA: 0x7FFAC4227B00
        public void get_callbacksOnDisable(){} // RVA: 0x7FFAC4227C10
        public void OnEnable(){} // RVA: 0x7FFAC4227E00
        public void FixedUpdate(){} // RVA: 0x7FFAC4228010
        public void CaptureTransformState(){} // RVA: 0x7FFAC4228020
        public void SetStateAndRefresh(){} // RVA: 0x7FFAC42281D0
        public void GetTransformData(){} // RVA: 0x7FFAC4228310
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC4228390
        public void OnDestroy(){} // RVA: 0x7FFAC4228630
        public void ProcessUiVisibilityLogic(){} // RVA: 0x7FFAC42286E0
        public void ProcessUiVisibilityLogic_FBAF1D611544(){} // RVA: 0x7FFAC4228750
        public void ProcessUiVisibilityLogic_F0FBBAC8F783(){} // RVA: 0x7FFAC4228860
        public void ProcessComponentFieldAndCheck(){} // RVA: 0x7FFAC42288F0
        public void .ctor(){} // RVA: 0x7FFAC4228990
        public void GetGameObjectReference(){} // RVA: 0x7FFAC4228B90
        public void CompareUnityObjects(){} // RVA: 0x7FFAC4228D40
        public void GetGameObjectReference2(){} // RVA: 0x7FFAC4229440
        public void SetGameObjectActive_A903651662B8(){} // RVA: 0x7FFAC42294D0
        public void SetReferenceObject(){} // RVA: 0x7FFAC4229560
        public void SetTargetEnabled(){} // RVA: 0x7FFAC4229ED0
        public void EnsureControllerInstance(){} // RVA: 0x7FFAC4229FE0
        public void OnBecameInvisible_0838F1452353(){} // RVA: 0x7FFAC422A170
        public void GetGameObjectReference3_2688FDB7DA62(){} // RVA: 0x7FFAC422A520
        public void CompareBaseObjects(){} // RVA: 0x7FFAC422A7B0
        public void SetGameObjectActive2(){} // RVA: 0x7FFAC422A890
        public void ComputeunscaledDeltaTime(){} // RVA: 0x7FFAC422A9A0
        public void SetGameObjectActive3(){} // RVA: 0x7FFAC422AE80
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void SetGameObjectActive_E327BCD82A68(){} // RVA: 0x7FFAC422AF20
        public void TryToString(){} // RVA: 0x7FFAC422B100
        public void ApplyAnimatedProperties(){} // RVA: 0x7FFAC422B9F0
        public void StartMultipartUpload(){} // RVA: 0x7FFAC422BB90
        public void Initialize_07883ADE0702(){} // RVA: 0x7FFAC422BC20
        public void InvokeNextFrame(){} // RVA: 0x7FFAC422BCF0
        public void GetGameObjectReference4(){} // RVA: 0x7FFAC422C710
        public void ApplyAnimatedPropertiesDisabled(){} // RVA: 0x7FFAC422CB00
        public void GetCachedPtr(){} // RVA: 0x7FFAC422CC00
        public void SetConnectedBody2(){} // RVA: 0x7FFAC2F21310
        public void ApplyAnimatedProperties_0CBBEC32BC4C(){} // RVA: 0x7FFAC422CCD0
        public void SetGameObjectActive2_893275FF43AB(){} // RVA: 0x7FFAC422CE70
        public void CompareUnityObjects_9082B84643F9(){} // RVA: 0x7FFAC422D1D0
        public void RaiseCancellation_C94541B812E8(){} // RVA: 0x7FFAC422D700
        public void InitializeFromTemplate(){} // RVA: 0x7FFAC422D8F0
        public void SetGameObjectActive6(){} // RVA: 0x7FFAC422D9F0
        public void CreateAndAttachHelper(){} // RVA: 0x7FFAC422DAA0
        public void IsInvokingDelayed(){} // RVA: 0x7FFAC422DD00
        public void GetGameObjectReference5(){} // RVA: 0x7FFAC422DE40
        public void SetGameObjectActive4_63A116023F77(){} // RVA: 0x7FFAC422DEC0
        public void ValidateBounds(){} // RVA: 0x7FFAC422DFF0
        public void CancelInvokeDelayed(){} // RVA: 0x7FFAC422E080
        public void Updateenabled(){} // RVA: 0x7FFAC422E110
        public void Initialize_790475645265(){} // RVA: 0x7FFAC42323E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4232550
        public void ApplyAnimatedProperties_EFCE4E741BDF(){} // RVA: 0x7FFAC4232920
        public void ProcessAsynchronousBehavior(){} // RVA: 0x7FFAC4232AC0
        public void GetBehaviourName(){} // RVA: 0x7FFAC4232DD0
        public void StartCoroutineDelayed(){} // RVA: 0x7FFAC4232ED0
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetGameObjectActive2_A84FE06414C0(){} // RVA: 0x7FFAC4232FE0
    }

    /// <summary>Originally: ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ</summary>
    public class ComplexComponent_8C61_8C61 : MonoBehaviour
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
        public 0x6AFF7978 f_564; // 0xC0
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
        public ÍÌÎÌÎÍÏÏÎÎÏÎÍÏÏÎÏÏÌÏÍÌÏ ÎÍÍÏÍÌÎÎÏÍÎÎÌÏÍÌÎÌÎÎÎÍÏ; // 0x150
        public bool ÍÎÌÌÎÏÎÍÎÏÌÌÎÎÌÌÏÌÌÎÎÏÎ; // 0x158
        public bool <ÎÍÍÎÌÌÍÏÍÎÏÎÍÍÏÏÌÎÎÍÍÏÍ>k__BackingField; // 0x159
        public string ÍÏÏÍÏÏÌÌÏÌÏÍÌÎÌÏÏÏÍÍÍÍÏ; // 0x160
        public bool ÎÎÎÏÎÏÌÍÌÎÏÌÏÍÌÍÍÏÎÎÏÍÍ; // 0x168
        public System.Action`1<VRC.Core.ApiWorldInstance> ÍÍÌÏÎÏÍÌÍÍÏÏÎÍÎÏÌÍÏÌÏÏÍ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3D231F0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3D23260
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFAC3D233D0
        public void Awake(){} // RVA: 0x7FFAC3D233E0
        public void Invoke(){} // RVA: 0x7FFAC3D23AC0
        public void InvokeRepeating(){} // RVA: 0x7FFAC3D23B60
        public void CancelInvoke(){} // RVA: 0x7FFAC3D23C00
        public void IsInvoking(){} // RVA: 0x7FFAC3D23C20
        public void StartCoroutine(){} // RVA: 0x7FFAC3D23C40
        public void LateUpdate(){} // RVA: 0x7FFAC3D23D60
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3D23D90
        public void OnDestroy(){} // RVA: 0x7FFAC3D23DE0
        public void get_SendClientReports(){} // RVA: 0x7FFAC3D23ED0
        public void ApplyTransformRotation(){} // RVA: 0x7FFAC3D23EE0
        public void StopCoroutine(){} // RVA: 0x7FFAC3D23EF0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3D23FE0
        public void get_ipsQuery(){} // RVA: 0x7FFAC2F8C2A0
        public void .cctor(){} // RVA: 0x7FFAC3D24130
        public void print(){} // RVA: 0x7FFAC3D241F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3D24490
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3D24510
        public void InvokeDelayed(){} // RVA: 0x7FFAC3D245B0
        public void OnEnable(){} // RVA: 0x7FFAC3D24820
        public void IsInvoking_FDA4AC6BF45E(){} // RVA: 0x7FFAC3D24940
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3D249F0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3D24B50
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3D24C00
        public void OnDisable(){} // RVA: 0x7FFAC3D24C60
        public void StopCoroutineFromEnumeratorManaged_AD830D9D55D8(){} // RVA: 0x7FFAC3D24CB0
        public void SetHaltUpdateMovement(){} // RVA: 0x7FFAC3D24CD0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC3D24CE0
        public void OnBecameVisible(){} // RVA: 0x7FFAC3006850
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3D24DD0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3D24E80
        public void set_search(){} // RVA: 0x7FFAC2FA2980
        public void OnCollisionExit(){} // RVA: 0x7FFAC3D24F90
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3D25180
        public void OnTriggerStay(){} // RVA: 0x7FFAC3D25230
        public void OnTriggerExit(){} // RVA: 0x7FFAC3D25280
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void UpdateIK(){} // RVA: 0x7FFAC3D25360
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC3D254D0
        public void GetVideoTracks(){} // RVA: 0x7FFAC3D25510
        public void get_isRightToLeftText(){} // RVA: 0x7FFAC3C8E090
        public void ResetPendingState(){} // RVA: 0x7FFAC3D25660
        public void Awake_F6B6764675D3(){} // RVA: 0x7FFAC3D25710
        public void set_SendClientReports(){} // RVA: 0x7FFAC3D258D0
        public void SyncTransformPosition3(){} // RVA: 0x7FFAC3D258E0
        public void CreateHelperObject(){} // RVA: 0x7FFAC2F4F0C0
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void CheckGameObjectActive(){} // RVA: 0x7FFAC3D25B20
        public void FixedUpdate(){} // RVA: 0x7FFAC3D25B50
        public void Update(){} // RVA: 0x7FFAC3D25BF0
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFAC3D25D50
        public void IsNodeActive(){} // RVA: 0x7FFAC3D25E40
        public void ValidateNodes(){} // RVA: 0x7FFAC3D25F60
        public void OnApplicationPause(){} // RVA: 0x7FFAC3D26040
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3D26190
        public void UpdateStateFromConfig(){} // RVA: 0x7FFAC3D261E0
        public void ApplyTransformRotation_69A0BC102494(){} // RVA: 0x7FFAC3D26300
        public void Start_D2C2961F0296(){} // RVA: 0x7FFAC3D26310
        public void OnCollisionStay(){} // RVA: 0x7FFAC3D26AF0
        public void SyncPhysicsTransforms(){} // RVA: 0x7FFAC3D26C00
        public void GetLanguage(){} // RVA: 0x7FFAC3D26FC0
        public void Update_6ADA48C15521(){} // RVA: 0x7FFAC3D27120
        public void SetConnectedBody2(){} // RVA: 0x7FFAC3D27380
        public void OnDisable_85D99044F45E(){} // RVA: 0x7FFAC3D274E0
        public void CreateSecondaryResources(){} // RVA: 0x7FFAC3D27520
        public void get_Drone(){} // RVA: 0x7FFAC3D24C60
        public void CreatePrimaryResource(){} // RVA: 0x7FFAC3D275C0
        public void StoreVector2(){} // RVA: 0x7FFAC3D27660
        public void ResetDefaultSettings(){} // RVA: 0x7FFAC3D277F0
        public void GetUnityEngine(){} // RVA: 0x7FFAC3D27AE0
        public void ResolveAndSwapBestMatchingEntry(){} // RVA: 0x7FFAC3D27AF0
        public void set_Item(){} // RVA: 0x7FFAC3D27BE0
        public void InitializeScaleTween(){} // RVA: 0x7FFAC3D27D30
        public void InitializeScaleTween_C441847B12D1(){} // RVA: 0x7FFAC3D27E80
        public void ApplyEulerRotation(){} // RVA: 0x7FFAC3D28490
        public void DefaultEquals(){} // RVA: 0x7FFAC3D285A0
        public void CaptureVectorState(){} // RVA: 0x7FFAC3D28640
        public void GetUnityEngine_BCFCD7F0C04C(){} // RVA: 0x7FFAC3D286A0
        public void OnDestroy_52700D8F3E69(){} // RVA: 0x7FFAC2F4F130
        public void FixedUpdate_058B50F1E0FF(){} // RVA: 0x7FFAC3D28740
        public void ApplyTransformPose(){} // RVA: 0x7FFAC3D28760
        public void HandleMovement(){} // RVA: 0x7FFAC3D28840
        public void CalculateFootPlacement(){} // RVA: 0x7FFAC3D28930
        public void UpdateCull(){} // RVA: 0x7FFAC2F8C2A0
        public void get_search(){} // RVA: 0x7FFAC2FA2970
        public void CreateInstance(){} // RVA: 0x7FFAC3D28A30
        public void CreateInstance_0EC301562FFF(){} // RVA: 0x7FFAC3D28AD0
        public void GetUnityEngine_BCFD162BE252(){} // RVA: 0x7FFAC3D29030
        public void GetUnityEngine_277FFA682F11(){} // RVA: 0x7FFAC3D29070
        public void UpdateTransform(){} // RVA: 0x7FFAC3D291E0
        public void SyncTransformPosition2(){} // RVA: 0x7FFAC3D29450
        public void TestProjectionOverlap(){} // RVA: 0x7FFAC3D295A0
        public void get_Drone_67A82472E7A4(){} // RVA: 0x7FFAC3D24C60
        public void Start(){} // RVA: 0x7FFAC3D295C0
        public void GetTransformReference2(){} // RVA: 0x7FFAC3D29660
        public void GetEffector(){} // RVA: 0x7FFAC3D297D0
        public void ProcessAnimation(){} // RVA: 0x7FFAC3D29880
        public void NormalizeStep(){} // RVA: 0x7FFAC3D29980
        public void Check(){} // RVA: 0x7FFAC3D299D0
        public void InitializeState(){} // RVA: 0x7FFAC3D29B30
        public void SyncTransformRotation2(){} // RVA: 0x7FFAC3D29C10
        public void SyncTransformRotation5(){} // RVA: 0x7FFAC3D29DE0
        public void CheckParentConstraintActive2(){} // RVA: 0x7FFAC3D2A080
        public void SyncTransformRotation6(){} // RVA: 0x7FFAC3D2A2B0
        public void ProcessRotation(){} // RVA: 0x7FFAC3D2A560
        public void InitializeIK(){} // RVA: 0x7FFAC3D2A960
        public void ApplyMovement(){} // RVA: 0x7FFAC3D2AD50
        public void SyncTransformRotation4(){} // RVA: 0x7FFAC3D2AEB0
        public void GetTransformReference(){} // RVA: 0x7FFAC3D2AFB0
        public void get_IsDominantHand(){} // RVA: 0x7FFAC3D2B010
        public void GetUnityEngine_27AF01A35077(){} // RVA: 0x7FFAC3D2B020
        public void ResetIK(){} // RVA: 0x7FFAC3D2B140
        public void SyncTransformRotation3(){} // RVA: 0x7FFAC3D2B1F0
        public void UpdateSearch(){} // RVA: 0x7FFAC3D2B500
        public void ReportClientState(){} // RVA: 0x7FFAC3D2B510
        public void UpdateLookRotation(){} // RVA: 0x7FFAC3D2B610
        public void set_payload(){} // RVA: 0x7FFAC39A79B0
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC3D2B800
        public void Initialize(){} // RVA: 0x7FFAC3D2BDC0
        public void HandleCollision(){} // RVA: 0x7FFAC3D2BF50
        public void EvaluateIK(){} // RVA: 0x7FFAC3D2C7B0
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFAC36D84B0
        public void GetSource(){} // RVA: 0x7FFAC3544340
        public void ApplyTransformRotation2(){} // RVA: 0x7FFAC3D2C850
        public void SyncTransformPosition(){} // RVA: 0x7FFAC3D2C9C0
        public void SynchronizeState(){} // RVA: 0x7FFAC3D2CC80
        public void SetDestroyCancellationToken(){} // RVA: 0x7FFAC3D2CF70
        public void SetHaltUpdateMovement_A5FB15E912D4(){} // RVA: 0x7FFAC3D24CD0
        public void SetUpdateMode(){} // RVA: 0x7FFAC3D2D0B0
        public void GetTransformReference3(){} // RVA: 0x7FFAC3D2D2C0
        public void SyncTransformRotation7(){} // RVA: 0x7FFAC3D2D330
        public void ContainsChild(){} // RVA: 0x7FFAC3D2D390
        public void InitializeComplexComponent(){} // RVA: 0x7FFAC3D2D480
        public void SolveConstraint(){} // RVA: 0x7FFAC3D2D4B0
        public void NormalizeAndClamp(){} // RVA: 0x7FFAC3D2D4E0
        public void CheckParentConstraintActive(){} // RVA: 0x7FFAC3D2D580
        public void UpdateComplexComponent(){} // RVA: 0x7FFAC3D2D480
        public void CancelComplexInvocation(){} // RVA: 0x7FFAC3D2D670
    }

    /// <summary>Originally: ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎÏÎÏ</summary>
    public class ComplexComponent_AFA2_AFA2 : MonoBehaviour
    {
        public ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎÏÎÏ _destroyCancellationToken;
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ _useGUILayout; // 0x20
        public ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍÏÌÎ f_09C; // 0x28
        public ÍÏÌÏÎÎÏÍÎÌÌÍÍÌÏÎÏÍÎÍÍÍÌ f_8FB; // 0x30
        public ÎÌÎÏÍÍÌÎÍÎÍÏÏÌÌÏÎÌÎÌÌÍÏ f_96C; // 0x38
        public ÏÍÌÍÌÍÌÌÏÏÏÌÎÌÍÏÍÏÏÎÏÍÎ f_B04; // 0x40
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ f_981; // 0x48
        public ÍÍÌÌÎÏÏÌÏÏÎÌÏÍÎÏÎÌÍÍÍÍÌ f_5DE; // 0x50
        public VRC.Core.UdonAnalytics.UdonAnalyticsCache f_EC2; // 0x58
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
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFAC30794D0
        public void RaiseCancellation(){} // RVA: 0x7FFAC40770B0
        public void get_contentList(){} // RVA: 0x7FFAC3540F70
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void set_element(){} // RVA: 0x7FFAC31D0C20
        public void InvokeRepeating(){} // RVA: 0x7FFAC4077210
        public void GetTexture(){} // RVA: 0x7FFAC303E100
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void StartCoroutine(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC4077360
        public void StartCoroutine_DFACAE305CA3(){} // RVA: 0x7FFAC40773E0
        public void get_taglineText(){} // RVA: 0x7FFAC354B1A0
        public void StopCoroutine(){} // RVA: 0x7FFAC4077990
        public void OnBecameInvisible(){} // RVA: 0x7FFAC4077A80
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4077B30
        public void StopAllCoroutines(){} // RVA: 0x7FFAC4077BB0
        public void .cctor(){} // RVA: 0x7FFAC4077D00
        public void set_useGUILayout(){} // RVA: 0x7FFAC2F21310
        public void print(){} // RVA: 0x7FFAC4077E40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC4077F00
        public void set_onPressed(){} // RVA: 0x7FFAC2F8C130
        public void InvokeDelayed(){} // RVA: 0x7FFAC4078050
        public void set_contentList(){} // RVA: 0x7FFAC2FA28A0
        public void IsInvoking(){} // RVA: 0x7FFAC40781A0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC4078220
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC4078290
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC40782A0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC40783F0
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void GetScriptClassName(){} // RVA: 0x7FFAC4078540
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC4078560
        public void StartCoroutineManaged_9A4B20E5AC59(){} // RVA: 0x7FFAC2FC20E0
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void InitializeTransientBuffer(){} // RVA: 0x7FFAC40785C0
        public void GetUnityEngine(){} // RVA: 0x7FFAC4078C70
        public void set_worldTag(){} // RVA: 0x7FFAC303E110
        public void .ctor(){} // RVA: 0x7FFAC4078DC0
        public void Initialize(){} // RVA: 0x7FFAC4078F60
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void LateUpdate(){} // RVA: 0x7FFAC40790B0
        public void UpdateSpine(){} // RVA: 0x7FFAC40790C0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void FormatTransientLabel(){} // RVA: 0x7FFAC40793D0
        public void ResetPendingState(){} // RVA: 0x7FFAC4079420
        public void CalculateAlpha(){} // RVA: 0x7FFAC4079430
        public void AssignUdonEmitter(){} // RVA: 0x7FFAC334B370
        public void BlendTextures(){} // RVA: 0x7FFAC4079E70
        public void DecodeNetworkFloat(){} // RVA: 0x7FFAC4079E80
        public void ResetMapping(){} // RVA: 0x7FFAC407A010
        public void CheckGameObjectActive(){} // RVA: 0x7FFAC407A020
        public void set_version(){} // RVA: 0x7FFAC2F8C050
        public void StringToHash(){} // RVA: 0x7FFAC407A570
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFAC407A5A0
        public void set_PointerPose(){} // RVA: 0x7FFAC2F8C0C0
        public void ApplyRigidbodyVelocity(){} // RVA: 0x7FFAC407A690
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void UpdateTracks(){} // RVA: 0x7FFAC407A7E0
        public void UpdateStateFromConfig(){} // RVA: 0x7FFAC407A930
        public void set_iconImageUrl(){} // RVA: 0x7FFAC354E360
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void HandleCollision(){} // RVA: 0x7FFAC407AA80
        public void SetConnectedBody2(){} // RVA: 0x7FFAC2F21310
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void ProcessInput(){} // RVA: 0x7FFAC407AAE0
        public void EnsurePhysicsAccessors(){} // RVA: 0x7FFAC407AC30
        public void RefreshVisuals(){} // RVA: 0x7FFAC407AD80
        public void UpdateTagline(){} // RVA: 0x7FFAC407AED0
        public void SetTexture(){} // RVA: 0x7FFAC407B020
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void Start(){} // RVA: 0x7FFAC407B180
        public void InitPayloadEncryption(){} // RVA: 0x7FFAC34D4AA0
        public void get_onPressed(){} // RVA: 0x7FFAC2F8C120
        public void set_domainList(){} // RVA: 0x7FFAC2FA2910
        public void OnDisable(){} // RVA: 0x7FFAC407B190
        public void ReadTransformBounds(){} // RVA: 0x7FFAC407B480
        public void ClearContent(){} // RVA: 0x7FFAC407B6F0
        public void Awake(){} // RVA: 0x7FFAC407B840
        public void OnBecameVisible(){} // RVA: 0x7FFAC407C4E0
        public void set_tooltipDescription(){} // RVA: 0x7FFAC354E420
        public void FixedUpdate(){} // RVA: 0x7FFAC407C970
        public void OnApplicationFocus(){} // RVA: 0x7FFAC407CA90
        public void OnCollisionExit(){} // RVA: 0x7FFAC2F8C0C0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC407CAA0
        public void OnTriggerStay(){} // RVA: 0x7FFAC407CBF0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void set_imageUrl(){} // RVA: 0x7FFAC354E300
        public void GetAudioTracks(){} // RVA: 0x7FFAC32EF640
        public void OnApplicationQuit(){} // RVA: 0x7FFAC407D220
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void OnApplicationPause(){} // RVA: 0x7FFAC407D280
        public void UpdateLayout(){} // RVA: 0x7FFAC407D380
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFAC30E06F0
        public void set_disclaimerText(){} // RVA: 0x7FFAC3079470
        public void OnCollisionStay(){} // RVA: 0x7FFAC2F4F0C0
        public void Save(){} // RVA: 0x7FFAC407D430
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void OnDisable_F3E3E0F0F590(){} // RVA: 0x7FFAC407DBF0
        public void OnTriggerExit(){} // RVA: 0x7FFAC30E5600
        public void InvokeIndexedCallback(){} // RVA: 0x7FFAC407DD40
        public void InitComponent(){} // RVA: 0x7FFAC407DE90
        public void GetGameObject_E61(){} // RVA: 0x7FFAC407DFE0
        public void InvokeStateDelegate(){} // RVA: 0x7FFAC407E3D0
        public void set_body(){} // RVA: 0x7FFAC2FE95A0
        public void UpdatelocalScale_I(){} // RVA: 0x7FFAC407E3E0
        public void set_description(){} // RVA: 0x7FFAC354E3C0
        public void Update(){} // RVA: 0x7FFAC407E4D0
        public void ProcessContent(){} // RVA: 0x7FFAC407E950
        public void LateUpdate_783A5220A4A7(){} // RVA: 0x7FFAC407E9C0
        public void ApplyRigidbodyVelocity_154A2E33B375(){} // RVA: 0x7FFAC407F660
        public void IsSupportedMotionMode(){} // RVA: 0x7FFAC4080150
        public void SetOverlay(){} // RVA: 0x7FFAC2F49200
        public void ComputeHashCode(){} // RVA: 0x7FFAC40802A0
        public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
        public void DoInverseTransform(){} // RVA: 0x7FFAC40813F0
        public void get_domainList(){} // RVA: 0x7FFAC2FA2900
        public void SetActive_A34(){} // RVA: 0x7FFAC4081A20
        public void set_worldTag_4CA937E2908C(){} // RVA: 0x7FFAC3079460
        public void SyncTransformRotation(){} // RVA: 0x7FFAC4081B70
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void ComputeRotationDelta(){} // RVA: 0x7FFAC4081CC0
        public void SyncTransformPosition(){} // RVA: 0x7FFAC4081D10
        public void GetColliderComponents_011267DE0EA2(){} // RVA: 0x7FFAC3543900
    }

    /// <summary>Originally: ÌÏÍÍÎÎÏÍÎÌÏÍÍÎÌÎÏÏÏÎÍÏÍ</summary>
    public class ComplexComponent_E737_E737 : MonoBehaviour
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
        public System.Collections.Generic.Dictionary`2<0x6AFEF940,byte[]> ÎÌÏÏÍÍÌÌÏÌÌÎÍÌÏÌÌÏÏÎÏÍÎ; // 0x18
        public System.Collections.Generic.Dictionary`2<byte,System.Type> ÌÎÏÍÏÏÍÎÎÍÏÍÏÎÎÏÏÌÍÍÏÍÌ; // 0x20
        public int ÌÍÌÏÍÌÎÏÎÎÏÍÏÏÍÏÍÏÌÌÏÌÍ;
        public int ÍÌÏÌÍÎÎÏÏÌÍÏÎÎÏÏÎÎÌÍÌÍÏ;
        public int ÌÍÎÍÍÌÏÌÏÍÏÎÎÌÎÎÍÌÎÏÍÌÍ;
        public bool <ÏÌÎÍÍÍÌÎÍÌÌÏÍÌÏÍÏÎÎÍÌÍÏ>k__BackingField; // 0x128

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC35A5F60
        public void RaiseCancellation(){} // RVA: 0x7FFAC35A6140
        public void IsInvoking(){} // RVA: 0x7FFAC35A62E0
        public void CancelInvoke(){} // RVA: 0x7FFAC35A6610
        public void Invoke(){} // RVA: 0x7FFAC35A6670
        public void InvokeRepeating(){} // RVA: 0x7FFAC35A6DD0
        public void CancelInvoke_E9790DDC4DC6(){} // RVA: 0x7FFAC35A6E70
        public void Computenames(){} // RVA: 0x7FFAC35A6ED0
        public void StartCoroutine(){} // RVA: 0x7FFAC35A71D0
        public void StartCoroutine_6A551142D887(){} // RVA: 0x7FFAC35A7240
        public void StartCoroutine_AB3BB7EA21D3(){} // RVA: 0x7FFAC35A7270
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC35A75A0
        public void StopCoroutine(){} // RVA: 0x7FFAC35A75D0
        public void Awake(){} // RVA: 0x7FFAC35A7B40
        public void Start(){} // RVA: 0x7FFAC35A7C40
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void .ctor(){} // RVA: 0x7FFAC35A96F0
        public void Initialize(){} // RVA: 0x7FFAC35AA130
        public void print(){} // RVA: 0x7FFAC35AA1D0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC35AA7F0
        public void OnDestroy(){} // RVA: 0x7FFAC35AA910
        public void InvokeDelayed(){} // RVA: 0x7FFAC35AAB10
        public void OnBecameVisible(){} // RVA: 0x7FFAC35AAC80
        public void OnBecameInvisible(){} // RVA: 0x7FFAC35AAE80
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC35AAED0
        public void set_PointerPose(){} // RVA: 0x7FFAC2F8C0C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC35AB160
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC35AB210
        public void GetScriptClassName_1C60BD7E6B6B_1C60BD7E6B6B(){} // RVA: 0x7FFAC35B0430 | overloaded x2
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC35AB830
        public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
        public void SyncLocalRotation(){} // RVA: 0x7FFAC35ABA50
        public void ApplyEulerRotation2(){} // RVA: 0x7FFAC35ABBC0
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void PickUp(){} // RVA: 0x7FFAC35ABCB0
        public void set_description(){} // RVA: 0x7FFAC354E3C0
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void ApplyLocalRotation(){} // RVA: 0x7FFAC35ABD60
        public void IsInvoking_0B505AC60201(){} // RVA: 0x7FFAC35ABE00
        public void CancelInvoke_69C27AF5AF0A(){} // RVA: 0x7FFAC35ABE60
        public void GetSpineMapping_0FC52C63620A(){} // RVA: 0x7FFAC2FE9590
        public void OnTriggerExit(){} // RVA: 0x7FFAC35ABE70
        public void SyncLocalRotation3(){} // RVA: 0x7FFAC35ABF50
        public void Update(){} // RVA: 0x7FFAC35AC130
        public void ApplyLocalRotation2(){} // RVA: 0x7FFAC35AC180
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC35AC230
        public void GetPhysicsShapeImpl(){} // RVA: 0x7FFAC35AC280
        public void Awake_7480E08F6AD3(){} // RVA: 0x7FFAC35ACC80
        public void get_mass(){} // RVA: 0x7FFAC35AD140
        public void NotifySelectedCipherSuite(){} // RVA: 0x7FFAC2FC2090
        public void IsInvoking_DBBB7178EB5F(){} // RVA: 0x7FFAC35AD780
        public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
        public void set_IsCustomized(){} // RVA: 0x7FFAC332DA60
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC35AD9E0
        public void .cctor(){} // RVA: 0x7FFAC35ADC10
        public void GetTexture(){} // RVA: 0x7FFAC303E100
        public void FixedUpdate(){} // RVA: 0x7FFAC35AE520
        public void Start_BA8513AC35E7(){} // RVA: 0x7FFAC35AE880
        public void CompareState(){} // RVA: 0x7FFAC35AE9B0
        public void get_onPressed(){} // RVA: 0x7FFAC2F8C120
        public void SetColorImplParticleMainModule(){} // RVA: 0x7FFAC35AEDF0
        public void OnEnable(){} // RVA: 0x7FFAC35AF010
        public void ReadRigidbodyState(){} // RVA: 0x7FFAC35AF3C0
        public void RaiseCancellation_DB2D5B9FE00C(){} // RVA: 0x7FFAC35AF770
        public void OnDisable(){} // RVA: 0x7FFAC35AFA60
        public void StartCoroutine_Auto_5CBAA4C8F77F(){} // RVA: 0x7FFAC35A75A0
        public void OnDestroy_E009047AABDC(){} // RVA: 0x7FFAC35AFB10
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void OnCollisionEnter(){} // RVA: 0x7FFAC35AFBC0
        public void OnCollisionStay(){} // RVA: 0x7FFAC35AFE90
        public void OnCollisionExit(){} // RVA: 0x7FFAC35AFF40
        public void DispatchLifecycleUpdate(){} // RVA: 0x7FFAC35B0150
        public void GetStatus(){} // RVA: 0x7FFAC2FC2080
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void GetIKSolver_31DAEF251751(){} // RVA: 0x7FFAC2FC20E0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC35B01B0
        public void OnTriggerStay(){} // RVA: 0x7FFAC35B0400
        public void get_article(){} // RVA: 0x7FFAC3331F50
        public void OnTriggerExit_868524F2A1AB(){} // RVA: 0x7FFAC35B0440
        public void set_enabled(){} // RVA: 0x7FFAC35B05B0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void set_onPressed(){} // RVA: 0x7FFAC2F8C130
        public void set_version(){} // RVA: 0x7FFAC2F8C050
        public void set_enabled_A944DA083396(){} // RVA: 0x7FFAC35B0600
        public void set_enabled_45FB74094747(){} // RVA: 0x7FFAC35B0670
        public void get_IsCustomized(){} // RVA: 0x7FFAC3331A00
        public void set_enabled_6386172D5DD6(){} // RVA: 0x7FFAC35B0690
        public void get_contentList(){} // RVA: 0x7FFAC3540F70
        public void SetRendererEnabled(){} // RVA: 0x7FFAC35B0BF0
        public void GetUnityEngine(){} // RVA: 0x7FFAC35B0FD0
        public void GetTransformReference(){} // RVA: 0x7FFAC35B10C0
        public void get_gameObject(){} // RVA: 0x7FFAC35B1200
        public void get_transform(){} // RVA: 0x7FFAC35B1330
        public void ComputeName(){} // RVA: 0x7FFAC35B13E0
        public void get_onPressed_922CB9E10C71(){} // RVA: 0x7FFAC2F9CD50
        public void GetComponent(){} // RVA: 0x7FFAC35B16C0
        public void Initialize_614792764F6A(){} // RVA: 0x7FFAC2F8C0B0
        public void GetComponents(){} // RVA: 0x7FFAC35B1730
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void LateUpdate(){} // RVA: 0x7FFAC35B1AF0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void Reset(){} // RVA: 0x7FFAC35B1B40
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
    }

    /// <summary>Originally: ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍÏÌÎ</summary>
    public class Major148m_82E5_82E5 : Object
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
        public System.Collections.Generic.List`1<VRC.Core.ApiVRChatSubscription> f_C26; // 0x58
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
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ f_E49; // 0xC0
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ f_DD4; // 0xC8
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ f_EC5; // 0xD0
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ f_90A; // 0xD8
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
        public ÎÎÌÌÌÌÌÎÏÏÍÎÎÍÏÍÎÎÎÏÍÏÍ <ÌÌÏÏÌÌÎÏÎÍÏÌÎÏÍÏÌÏÎÏÎÏÌ>k__BackingField; // 0x20
        public ÍÌÎÍÌÏÍÎÌÍÎÌÏÌÏÍÏÍÏÍÏÍÏ <ÎÎÍÎÎÌÏÍÎÍÌÌÍÌÎÍÏÏÏÌÏÏÏ>k__BackingField; // 0x28
        public System.Action`1<ÌÍÍÏÌÌÌÏÏÍÌÎÍÍÌÍÎÏÏÍÏÌÎ> ÍÍÎÌÏÌÍÌÎÍÎÎÎÍÏÏÎÎÍÎÍÌÍ; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3A1D120
        public void Equals(){} // RVA: 0x7FFAC3A1D440
        public void GetHashCode(){} // RVA: 0x7FFAC2F4F0C0
        public void op_Implicit(){} // RVA: 0x7FFAC3A1D4F0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3A1D650
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3A1D710
        public void GetCachedPtr(){} // RVA: 0x7FFAC3A1D7F0
        public void get_name(){} // RVA: 0x7FFAC3A1D8B0
        public void set_name(){} // RVA: 0x7FFAC3A1D910
        public void Instantiate(){} // RVA: 0x7FFAC3A1D9A0
        public void ToString(){} // RVA: 0x7FFAC3A1DD10
        public void EnqueueMatchmaking(){} // RVA: 0x7FFAC3A1E2A0
        public void CleanupLookupTable(){} // RVA: 0x7FFAC3A1E2F0
        public void GetPPLayer(){} // RVA: 0x7FFAC3A1E6B0
        public void CleanupLookupTable_703BE601D5A7(){} // RVA: 0x7FFAC3A1E760
        public void CleanupLookupTable_FD4F96F4D506(){} // RVA: 0x7FFAC3A1E7B0
        public void GetInnerStruct(){} // RVA: 0x7FFAC3A1E830
        public void SetCurrentSocket(){} // RVA: 0x7FFAC3A1E890
        public void CloneSingle(){} // RVA: 0x7FFAC3A1E910
        public void Destroy(){} // RVA: 0x7FFAC3A1EC30
        public void GetInnerStructA(){} // RVA: 0x7FFAC3006850
        public void DestroyImmediate(){} // RVA: 0x7FFAC3A1F070
        public void DestroyImmediate_0A4AACBCA6E3(){} // RVA: 0x7FFAC3A1F1F0
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3A1F290
        public void ovr_Matchmaking_Enqueue2_Native(){} // RVA: 0x7FFAC3A1F2E0
        public void FindObjectsByType(){} // RVA: 0x7FFAC3A1F340
        public void GetItemByIndex(){} // RVA: 0x7FFAC3A1F550
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3A1F600
        public void get_hideFlags(){} // RVA: 0x7FFAC3A1F660
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void GetPPLayer_C752425E6A58(){} // RVA: 0x7FFAC3A1F6B0
        public void FindObjectOfType(){} // RVA: 0x7FFAC3A1F990
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC3A1FA80
        public void GetItemByIndex_D8955063B4E8(){} // RVA: 0x7FFAC3A1FB20
        public void CheckNullArgument(){} // RVA: 0x7FFAC3A1FCB0
        public void CheckNullArgument_4C3667424D03(){} // RVA: 0x7FFAC3A1FD10
        public void AddSubtraction_F5B20CE87DD4(){} // RVA: 0x7FFAC3A1FDC0
        public void ValidateInnerStruct(){} // RVA: 0x7FFAC3A1FE60
        public void CloneObject(){} // RVA: 0x7FFAC3A1FF00
        public void IsSocketConnected(){} // RVA: 0x7FFAC3A1FF70
        public void op_Equality(){} // RVA: 0x7FFAC2F4F0D0
        public void op_Inequality(){} // RVA: 0x7FFAC3A20050
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC3A20300
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC3A20350
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC3A204B0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAC3A20510
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAC3A20600
        public void GetInnerStructB(){} // RVA: 0x7FFAC3006850
        public void GetName(){} // RVA: 0x7FFAC3A206A0
        public void SetName(){} // RVA: 0x7FFAC3A20740
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC3A207C0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFAC3A20820
        public void SetName_B5873D639C9C(){} // RVA: 0x7FFAC3A208D0
        public void DoSetPositionAndRotation_Injected_06E(){} // RVA: 0x7FFAC3A20C80
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAC3A20CE0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFAC3A20D60
        public void SerializeEventFields(){} // RVA: 0x7FFAC3A20DC0
        public void GetCachedPtr_49E8872C2EE8(){} // RVA: 0x7FFAC3A20EC0
        public void GetMatchID(){} // RVA: 0x7FFAC3A20F20
        public void SyncTransform(){} // RVA: 0x7FFAC3A212D0
        public void SyncPosition(){} // RVA: 0x7FFAC3A21330
        public void SyncTransform_2A48EB1CA4F0(){} // RVA: 0x7FFAC3A214F0
        public void UpdatePosition(){} // RVA: 0x7FFAC3A21550
        public void AddMatchModifier(){} // RVA: 0x7FFAC3A219C0
        public void CompareBaseObjects_D783F1E5501E(){} // RVA: 0x7FFAC3A21C30
        public void DoSetPositionAndRotation_Injected_662(){} // RVA: 0x7FFAC3A21D10
        public void DoSetPositionAndRotation_Injected_662_4D1AA11B23A1(){} // RVA: 0x7FFAC3A21E00
        public void DoSendGetRequest(){} // RVA: 0x7FFAC3A21EE0
        public void SubtractMatchModifier(){} // RVA: 0x7FFAC3A21F60
        public void ConnectToSocket(){} // RVA: 0x7FFAC3A21FC0
        public void DisconnectSocket(){} // RVA: 0x7FFAC3A22080
        public void ResetLookupTable(){} // RVA: 0x7FFAC2F21320
        public void FetchMatchmakingData(){} // RVA: 0x7FFAC3A220D0
        public void ParseInnerStructA(){} // RVA: 0x7FFAC3A221D0
        public void ProcessLookupTableEntry(){} // RVA: 0x7FFAC3A22250
        public void OnPreRender(){} // RVA: 0x7FFAC3A22600
        public void CompareBaseObjects_C4D611948AE8(){} // RVA: 0x7FFAC3A226C0
        public void UnPack(){} // RVA: 0x7FFAC3A22760
        public void HasChanged_F418B4F6B8A3_F418B4F6B8A3(){} // RVA: 0x7FFAC3A23F40 | overloaded x2
        public void GetTransformHash(){} // RVA: 0x7FFAC3A228D0
        public void .cctor(){} // RVA: 0x7FFAC3A229B0
        public void PrepareConcurrentSystemUpdate(){} // RVA: 0x7FFAC3A23040
        public void PerformConcurrentSystemUpdate(){} // RVA: 0x7FFAC3A230E0
        public void UpdateGameObjectProperties(){} // RVA: 0x7FFAC3A23180
        public void IsNativeObjectAlive_9B0B58BF08BF(){} // RVA: 0x7FFAC3A232F0
        public void InitializeStateComponent(){} // RVA: 0x7FFAC3A23390
        public void .ctor(){} // RVA: 0x7FFAC3A23400
        public void Initialize(){} // RVA: 0x7FFAC3A234C0
        public void RetrieveTransformSystemStatus(){} // RVA: 0x7FFAC3A23560
        public void RetrieveTransformSystemStatus_9955C0E0D0EC(){} // RVA: 0x7FFAC3A235C0
        public void RetrieveTransformSystemStatus_754E53E1A9F7(){} // RVA: 0x7FFAC3A23620
        public void UpdateTransformState(){} // RVA: 0x7FFAC3A236A0
        public void InitializeTransformState(){} // RVA: 0x7FFAC3A23750
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC3A238D0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_20E6C4A520E1(){} // RVA: 0x7FFAC3A23980
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_87AC3BDD4F0A(){} // RVA: 0x7FFAC3A239D0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right_95FE6D8AFD96(){} // RVA: 0x7FFAC3A23A70
        public void GetTransformStateStatus(){} // RVA: 0x7FFAC3A23D70
        public void UpdateModifiedState(){} // RVA: 0x7FFAC3A23E70
        public void IsModified(){} // RVA: 0x7FFAC3A23EC0
        public void RefreshChangeState(){} // RVA: 0x7FFAC3A24730
        public void UpdateSystemState(){} // RVA: 0x7FFAC3A24790
        public void PrepareAtomicGameObjectReference(){} // RVA: 0x7FFAC3A25460
        public void UpdateAtomicGameObjectReference(){} // RVA: 0x7FFAC3A25530
        public void ReadTransformRelatedData(){} // RVA: 0x7FFAC3A25650
        public void SetTransformRelatedPointerAndFlag(){} // RVA: 0x7FFAC3A25A40
        public void InitializeLocalTransform(){} // RVA: 0x7FFAC3A25AC0
        public void ProcessSystemRelatedData(){} // RVA: 0x7FFAC3A25B80
        public void ApplyLocalTransform(){} // RVA: 0x7FFAC3A25C30
        public void AttachTransformAndSetLocalPose(){} // RVA: 0x7FFAC3A25CB0
        public void GetUnityEngine(){} // RVA: 0x7FFAC3A25D10
        public void UpdateDetailsPanelState(){} // RVA: 0x7FFAC3A262B0
        public void RefreshDetailsPanel(){} // RVA: 0x7FFAC3A26310
        public void GetDetailsPanelState(){} // RVA: 0x7FFAC3A26370
        public void get_name_F23B61291488(){} // RVA: 0x7FFAC3A263F0
        public void InitializeMatchmaking(){} // RVA: 0x7FFAC2F21320
        public void get_deltaTime(){} // RVA: 0x7FFAC3A26CB0
        public void ComputeNow(){} // RVA: 0x7FFAC3A26E60
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void GetSystemInitializationFlag(){} // RVA: 0x7FFAC3A27720
        public void GetUnityEngine_800D12_800D12F30236(){} // RVA: 0x7FFAC3A27AD0 | overloaded x2
        public void GetUnityEngine_B8A25CD10968(){} // RVA: 0x7FFAC3A27900
        public void GetGameObjectTransform(){} // RVA: 0x7FFAC3A27950
        public void PrepareUIElementComparison(){} // RVA: 0x7FFAC3A279D0
        public void PerformUIElementComparison(){} // RVA: 0x7FFAC3A27D80
        public void SetLocalPosition(){} // RVA: 0x7FFAC3A27E50
        public void GetLocalRotation(){} // RVA: 0x7FFAC3A27F00
        public void ReadTransformState(){} // RVA: 0x7FFAC3A27FF0
        public void print(){} // RVA: 0x7FFAC3A28080
        public void GetMaterialRenderer(){} // RVA: 0x7FFAC3A282D0
        public void ClampRotationBlend(){} // RVA: 0x7FFAC3A29070
        public void PrepareSetParent(){} // RVA: 0x7FFAC3A29120
        public void SetParent(){} // RVA: 0x7FFAC3A291A0
        public void ResolveParentTransform(){} // RVA: 0x7FFAC3A29540
        public void ResolveTransformParent(){} // RVA: 0x7FFAC3A29590
        public void DoFetchUser(){} // RVA: 0x7FFAC3A29610
        public void SetTransformParent(){} // RVA: 0x7FFAC3A296D0
        public void SetParent_6CE3C066ED5F(){} // RVA: 0x7FFAC3A297B0
        public void UpdateMaterialFloat(){} // RVA: 0x7FFAC3A29810
        public void UpdateMaterialFloatCurrent(){} // RVA: 0x7FFAC3A298B0
        public void SetLocalPositionAnimated(){} // RVA: 0x7FFAC3A29AC0
        public void SetLocalPositionCurrent(){} // RVA: 0x7FFAC3A29B10
        public void SetActive_F2D(){} // RVA: 0x7FFAC3A2A0B0
        public void SerializeNetworkObjectWithFlags(){} // RVA: 0x7FFAC3A2A100
        public void LateUpdate(){} // RVA: 0x7FFAC3A2A150
        public void RefreshState(){} // RVA: 0x7FFAC3A2A700
    }

    /// <summary>Originally: ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎÌÎÎ</summary>
    public class MajorSystem_13C5_13C5 : MonoBehaviour
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
        public System.Collections.Generic.Dictionary`2<0x6AFF22D8,string> ÏÍÏÍÌÎÎÏÍÌÏÏÎÌÎÍÌÍÏÌÌÌÍ; // 0x18
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
        public System.Collections.Generic.Dictionary`2<string,Snapshot> ÎÍÎÏÎÎÌÏÍÍÍÍÎÍÍÌÏÌÍÏÌÎÎ; // 0x128
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3AE3FD0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3AE42E0
        public void IsInvoking(){} // RVA: 0x7FFAC3AE4350
        public void CancelInvoke(){} // RVA: 0x7FFAC3AE44A0
        public void Invoke(){} // RVA: 0x7FFAC3AE4570
        public void InvokeRepeating(){} // RVA: 0x7FFAC3AE4600
        public void CancelInvoke_5EA3A7BB1869(){} // RVA: 0x7FFAC3AE46B0
        public void IsInvoking_D259F43C9F9E(){} // RVA: 0x7FFAC3AE47B0
        public void StartCoroutine(){} // RVA: 0x7FFAC3AE4960
        public void StartCoroutine_0D9AC8F33130(){} // RVA: 0x7FFAC3AE4A60
        public void StartCoroutine_A319F0ED388B(){} // RVA: 0x7FFAC3AE4BA0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3AE54B0
        public void StopCoroutine(){} // RVA: 0x7FFAC3AE5560
        public void StopCoroutine_1810C56B1D2B(){} // RVA: 0x7FFAC3AE5630
        public void StopCoroutine_30D31850AE56(){} // RVA: 0x7FFAC3AE57C0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3AE5B70
        public void get_useGUILayout_7885EC916CC2_7885EC916CC2(){} // RVA: 0x7FFAC3AEA030 | overloaded x2
        public void set_useGUILayout(){} // RVA: 0x7FFAC3AE5DD0
        public void print(){} // RVA: 0x7FFAC3AE5E30
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3AE6220
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3AE6280
        public void .cctor(){} // RVA: 0x7FFAC3AE6380
        public void CancelInvoke_D85AA0D3BE00(){} // RVA: 0x7FFAC3AE9350
        public void GetSyncState_93BF8F1F11F3(){} // RVA: 0x7FFAC3AEC450 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3AE9550
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3AE9560
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3AE95C0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC3AE9660
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3AE9890
        public void GetScriptClassName(){} // RVA: 0x7FFAC3AE9DA0
        public void Awake_6C6520E2AAD4(){} // RVA: 0x7FFAC3AE9EA0
        public void SyncPosition(){} // RVA: 0x7FFAC3AEA290
        public void InvertRotationTarget_EAC320DE2127_EAC320DE2127(){} // RVA: 0x7FFAC3AEA470 | overloaded x2
        public void SyncTransform(){} // RVA: 0x7FFAC3AEA410
        public void Start_A9380F11B761(){} // RVA: 0x7FFAC3AEA530
        public void SyncTransform_028D2D418B23(){} // RVA: 0x7FFAC3AEAB50
        public void SyncAnimatorGoalRotation_3A87FD2D23D2_3A87FD2D23D2(){} // RVA: 0x7FFAC3B15A50 | overloaded x2
        public void SyncScale(){} // RVA: 0x7FFAC3AEADF0
        public void ReadTransformPosition(){} // RVA: 0x7FFAC3AEAE50
        public void CopyRotation(){} // RVA: 0x7FFAC3AEB0E0
        public void ReadTransformScale(){} // RVA: 0x7FFAC3AEB8F0
        public void ReadTransformRotation(){} // RVA: 0x7FFAC3AEB990
        public void MultiplyQuaternionVector(){} // RVA: 0x7FFAC3AEBAE0
        public void SetRotation(){} // RVA: 0x7FFAC3AEBC00
        public void FixedUpdate(){} // RVA: 0x7FFAC3AEBE00
        public void SetRotationCurrent(){} // RVA: 0x7FFAC3AEBF40
        public void GetUnityEngine(){} // RVA: 0x7FFAC3AEC600
        public void OnDestroy(){} // RVA: 0x7FFAC3AEC660
        public void OnApplicationPause(){} // RVA: 0x7FFAC3AECD70
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3AED0A0
        public void OnBecameVisible(){} // RVA: 0x7FFAC3AED410
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3AED4D0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3AED750
        public void OnCollisionStay(){} // RVA: 0x7FFAC3AEDB50
        public void OnCollisionExit(){} // RVA: 0x7FFAC3AFAA50 | overloaded x5
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3AEDC70
        public void OnTriggerStay(){} // RVA: 0x7FFAC3AEE200
        public void OnTriggerExit(){} // RVA: 0x7FFAC3AEE2C0
        public void StartCoroutine_Auto_E54C0D05B25A(){} // RVA: 0x7FFAC3AEE360
        public void DoGetIntegerString_7BC(){} // RVA: 0x7FFAC3AEE590
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7FFAC3AEE8B0
        public void UpdateUiComponentState(){} // RVA: 0x7FFAC3AEE9F0
        public void CopyPosition(){} // RVA: 0x7FFAC3AEEAF0
        public void EnsureInitialized(){} // RVA: 0x7FFAC3AEEEC0
        public void Awake(){} // RVA: 0x7FFAC3AEEF40
        public void ResetOffsets(){} // RVA: 0x7FFAC3AEF660
        public void CopyScale(){} // RVA: 0x7FFAC3AF01E0
        public void UpdateSync(){} // RVA: 0x7FFAC3AF04E0
        public void RefreshState(){} // RVA: 0x7FFAC3AF0790
        public void InitializeSync(){} // RVA: 0x7FFAC3AF0A80
        public void ResetSync_6C62BE38C12D(){} // RVA: 0x7FFAC3B0C4D0 | overloaded x2
        public void ClearSync(){} // RVA: 0x7FFAC3AF0B60
        public void ClearConstraintReferences(){} // RVA: 0x7FFAC3AF1500
        public void ApplyAnimatedProperties(){} // RVA: 0x7FFAC3AF1560
        public void OnDisable_FDDA990B161C(){} // RVA: 0x7FFAC3AF1BD0
        public void CopyAsyncState(){} // RVA: 0x7FFAC3AF2190
        public void ApplySync(){} // RVA: 0x7FFAC3AF2670
        public void Update_93B00B0D2914(){} // RVA: 0x7FFAC3AF26E0
        public void FindObjectsByType(){} // RVA: 0x7FFAC3AF27C0
        public void InitializeTransformStatics(){} // RVA: 0x7FFAC3AF2C10
        public void SetComponentFlags(){} // RVA: 0x7FFAC3AF2D90
        public void SetSyncFlags(){} // RVA: 0x7FFAC3AF2E90
        public void SyncTransform_913FFF9B2796(){} // RVA: 0x7FFAC3AF2F30
        public void get_gameObject(){} // RVA: 0x7FFAC3AF30F0
        public void ComputeParent(){} // RVA: 0x7FFAC3AF3160
        public void ResolveGameObject(){} // RVA: 0x7FFAC3AF34B0
        public void .ctor(){} // RVA: 0x7FFAC3AF3A20
        public void Initialize(){} // RVA: 0x7FFAC3AF3BB0
        public void Update_F3D3FAFD7C92(){} // RVA: 0x7FFAC3AF3C80
        public void ValidateInputs(){} // RVA: 0x7FFAC3AF3F30
        public void SetSyncState(){} // RVA: 0x7FFAC3AF3FD0
        public void SyncAnimatorGoalPosition(){} // RVA: 0x7FFAC3AF3FF0
        public void SyncAnimatorGoalScale(){} // RVA: 0x7FFAC3AF42B0
        public void get_enabled(){} // RVA: 0x7FFAC3AF4FA0
        public void UpdatePlayerStatusDisplay(){} // RVA: 0x7FFAC3AF5060
        public void get_simulationMode(){} // RVA: 0x7FFAC3AF5270
        public void ComputegameObject(){} // RVA: 0x7FFAC3502FD0
        public void get_simulationMode_2E9E81CC8AF4(){} // RVA: 0x7FFAC3AF53B0
        public void get_simulationMode_F8B2CB9C342B(){} // RVA: 0x7FFAC3AF5450
        public void AssignManagedReference(){} // RVA: 0x7FFAC3AF54E0
        public void get_simulationMode_763D8B148E2F(){} // RVA: 0x7FFAC3AF57D0
        public void InvertPositionTarget(){} // RVA: 0x7FFAC3AF5C10
        public void SetFlagsFromBytes(){} // RVA: 0x7FFAC3AF5D50
        public void StartCoroutine_Auto_0C41598B8113(){} // RVA: 0x7FFAC3AF5E90
        public void UpdateUiComponentState_B8714A4E151F(){} // RVA: 0x7FFAC3AF5F30
        public void get_simulationMode_31A80B05BE90(){} // RVA: 0x7FFAC3AF6600
        public void SetBehaviourEnabled(){} // RVA: 0x7FFAC3AF6880
        public void InvertScaleTarget(){} // RVA: 0x7FFAC3AF6900
        public void InvertRotationCurrent(){} // RVA: 0x7FFAC3AF71B0
        public void GetParentTransform(){} // RVA: 0x7FFAC3AF7340
        public void SyncPoseFromRotationCurrent_8E52080BBB67_8E52080BBB67(){} // RVA: 0x7FFAC3B02A20 | overloaded x2
        public void SetFirstBlendWeight(){} // RVA: 0x7FFAC3AF7C30
        public void SetSecondBlendWeight(){} // RVA: 0x7FFAC3AF7E20
        public void StopCoroutine_8F191FDB76BF(){} // RVA: 0x7FFAC3AF7F40
        public void ResetMaterialProperty(){} // RVA: 0x7FFAC3AF80D0
        public void GetTransform_EC5(){} // RVA: 0x7FFAC3AF8450
        public void InvertRotation(){} // RVA: 0x7FFAC3AF89A0
        public void GetUnityEngine_F4C08534B484(){} // RVA: 0x7FFAC3AF8A00
        public void CreateInverseEulerRotation(){} // RVA: 0x7FFAC3AF8B40
        public void CachePropertyIDs(){} // RVA: 0x7FFAC3AF8C80
        public void SyncTransformRotation(){} // RVA: 0x7FFAC3AF8D40
        public void SyncTransformPosition(){} // RVA: 0x7FFAC3AF8DA0
        public void GetComponentTransform(){} // RVA: 0x7FFAC3AF8F90
        public void OnTriggerExit_06B8CEA73CF4(){} // RVA: 0x7FFAC3AF9030
        public void GetTransformPosition(){} // RVA: 0x7FFAC3AF91C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AFA580
        public void SyncTransformScale(){} // RVA: 0x7FFAC3AFA5E0
        public void ComputeRotationAverage(){} // RVA: 0x7FFAC3AFA760
        public void Update(){} // RVA: 0x7FFAC3AFAAC0
        public void iplHRTFCreate_6ABB41DEFCCE_6ABB41DEFCCE(){} // RVA: 0x7FFAC3B13470 | overloaded x2
        public void EvaluateRotationDelta(){} // RVA: 0x7FFAC3AFAE20
        public void TransformDirection(){} // RVA: 0x7FFAC3AFAE30
        public void TransformPointToCurrentPose(){} // RVA: 0x7FFAC3AFAF50
        public void UpdateTransformPose_9250B3AB81D2(){} // RVA: 0x7FFAC3AFB000
        public void UpdatePoseFromRotationDelta(){} // RVA: 0x7FFAC3AFB1B0
        public void InvertRotation_4B9E4A0D8C37(){} // RVA: 0x7FFAC3AFB690
        public void ComputeAngularVelocity(){} // RVA: 0x7FFAC3AFB970
        public void SetAngularVelocity(){} // RVA: 0x7FFAC3AFBB70
        public void SetAngularVelocityCurrent(){} // RVA: 0x7FFAC3AFC290
        public void ApplyAngularVelocityCurrent(){} // RVA: 0x7FFAC3AFC3A0
        public void GetComponentTransform_4FF90CE419A4(){} // RVA: 0x7FFAC3AFC400
        public void InvertRotation_6F0C1B2BB41F(){} // RVA: 0x7FFAC3AFCB80
        public void ExtractAxisAngle(){} // RVA: 0x7FFAC3AFCFB0
        public void ApplyQuaternionToVector(){} // RVA: 0x7FFAC3AFD0E0
        public void SetAngularVelocityTarget(){} // RVA: 0x7FFAC3AFD140
        public void ApplyAngularVelocityTarget(){} // RVA: 0x7FFAC3AFD3C0
        public void ApplyTransform(){} // RVA: 0x7FFAC3AFD6F0
        public void SyncTransformPoint(){} // RVA: 0x7FFAC3AFD790
        public void ResetBlendState(){} // RVA: 0x7FFAC3AFED80
        public void UpdateNormalizedProgress(){} // RVA: 0x7FFAC3AFEE30
        public void ClampRotationBlend(){} // RVA: 0x7FFAC3AFF0A0
        public void CopyRotationState(){} // RVA: 0x7FFAC3AFF210
        public void OnEnable_4663AB782EF5(){} // RVA: 0x7FFAC3AFF360
        public void set_enabled(){} // RVA: 0x7FFAC3AFFAA0
        public void set_enabled_2034991DADD2(){} // RVA: 0x7FFAC3AFFB10
        public void __GetType__SystemType(){} // RVA: 0x7FFAC3AFFBE0
        public void OnBecameInvisible_49C2B262C8D9(){} // RVA: 0x7FFAC3B00330
        public void HasHumanAnimatorController(){} // RVA: 0x7FFAC3B00470
        public void SetSharedTextMaterial(){} // RVA: 0x7FFAC3B005F0
        public void WriteBarrierAssignNull(){} // RVA: 0x7FFAC3B00690
        public void SetBehaviourEnabled_1343FDA8B01A(){} // RVA: 0x7FFAC3B00D00
        public void PrepareInverseTransformPoint(){} // RVA: 0x7FFAC3B00EB0
        public void InverseTransformPoint(){} // RVA: 0x7FFAC3B00FB0
        public void TransformPointCurrent(){} // RVA: 0x7FFAC3B02020
        public void HookIntoActionChange(){} // RVA: 0x7FFAC3B02190
        public void TransformPoint(){} // RVA: 0x7FFAC3B021A0
        public void SyncPoseFromRotation(){} // RVA: 0x7FFAC3B02200
        public void Initialize_3D55D53C2458(){} // RVA: 0x7FFAC3B02710
        public void BlendToPoser(){} // RVA: 0x7FFAC3B02C80
        public void BlendToPoser_5AD1C145008D(){} // RVA: 0x7FFAC3B02C90
        public void get_transform(){} // RVA: 0x7FFAC3B02D70
        public void InverseTransformPointCurrent(){} // RVA: 0x7FFAC3B02E10
        public void TransformPointFromCurrent(){} // RVA: 0x7FFAC3B02F60
        public void MultiplyQuaternionComponents(){} // RVA: 0x7FFAC3B03050
        public void ApplyLocalTransform(){} // RVA: 0x7FFAC3B032B0
        public void GetUnityEngine_B1754E4FE30C(){} // RVA: 0x7FFAC3B03310
        public void RemoveParentConstraintSourceCurrent(){} // RVA: 0x7FFAC3B03450
        public void ValidateComponentReferences(){} // RVA: 0x7FFAC3B03510
        public void TryGetValue(){} // RVA: 0x7FFAC3B038D0
        public void PrepareLocalPose(){} // RVA: 0x7FFAC3B03940
        public void ApplyLocalPose(){} // RVA: 0x7FFAC3B039A0
        public void SyncLocalPosition(){} // RVA: 0x7FFAC3B03C90
        public void OnDisable(){} // RVA: 0x7FFAC3B04130
        public void get_transform_476244712A3B(){} // RVA: 0x7FFAC3B042C0
        public void FindRelativeTransform(){} // RVA: 0x7FFAC3B04320
        public void RotateVector(){} // RVA: 0x7FFAC3B04910
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC3B04B70
        public void GetGameObjectTransform(){} // RVA: 0x7FFAC3B04E80
        public void CreateAngleAxisRotation(){} // RVA: 0x7FFAC3B04F60
        public void SetRotation_297C1EF1EFB6(){} // RVA: 0x7FFAC3B04F80
        public void PrepareSyncPosition(){} // RVA: 0x7FFAC3B07440
        public void SyncPosition_BFD49602D06E(){} // RVA: 0x7FFAC3B074D0
        public void CreateManagedObject(){} // RVA: 0x7FFAC3B0A720
        public void InitializeTransformPose(){} // RVA: 0x7FFAC3B0A840
        public void UpdateTransformPoseState(){} // RVA: 0x7FFAC3B0AF80
        public void ApplyTransformPose(){} // RVA: 0x7FFAC3B0B040
        public void Updateenabled(){} // RVA: 0x7FFAC3B0B520
        public void RefreshEnabledState(){} // RVA: 0x7FFAC3B0B8A0
        public void DoIsDevApi(){} // RVA: 0x7FFAC3B0BB50
        public void RefreshPlayerStatusDisplay(){} // RVA: 0x7FFAC3B0BD10
        public void UpdatePlayerStatusDisplay_1468B8CEFE44(){} // RVA: 0x7FFAC3B0C000
        public void UpdateComponentFlagsAndReferences(){} // RVA: 0x7FFAC3B0C3E0
        public void ClearSyncState(){} // RVA: 0x7FFAC3B0C550
        public void DoIsDevApi_3ACFB13FB8D7(){} // RVA: 0x7FFAC3B0C850
        public void SyncRotationCurrent(){} // RVA: 0x7FFAC3B0C8A0
        public void ToString(){} // RVA: 0x7FFAC3B0C940
        public void ProcessMultiStateFlagPartial(){} // RVA: 0x7FFAC3B0CB70
        public void SyncRotation(){} // RVA: 0x7FFAC3B0CE90
        public void SetFlagAndCallFunction(){} // RVA: 0x7FFAC3B0D190
        public void ApplyLocalTransform_3964A43AA662(){} // RVA: 0x7FFAC3B0D1C0
        public void ApplyHumanBoneLocalPose(){} // RVA: 0x7FFAC3B0D220
        public void DoHasAnyPendingTasks(){} // RVA: 0x7FFAC3B0D790
        public void GetTransform_EC5_93CEAFF87970(){} // RVA: 0x7FFAC3B0D830
        public void ProcessSystemComponentData(){} // RVA: 0x7FFAC3B0DAF0
        public void IncrementCounterAndProcess(){} // RVA: 0x7FFAC3B0DB40
        public void ResetSystemDataBlock(){} // RVA: 0x7FFAC3B0DCC0
        public void InitializeSystemDataBlock(){} // RVA: 0x7FFAC3B0DD20
        public void ProcessSystemDataBlock(){} // RVA: 0x7FFAC3B0DD80
        public void SyncTransform_5DFF8D8F10E0(){} // RVA: 0x7FFAC3B0DE10
        public void ResolveInputSource(){} // RVA: 0x7FFAC3B0E000
        public void GetInputSourceHandle(){} // RVA: 0x7FFAC3B0E060
        public void CopyPoseState(){} // RVA: 0x7FFAC3B0E510
        public void CopyPoseStateCurrent(){} // RVA: 0x7FFAC3B0E6A0
        public void StopCoroutine_8F178AA30895(){} // RVA: 0x7FFAC3B0E700
        public void ResolveRelativeRotationCurrent(){} // RVA: 0x7FFAC3B0E760
        public void NormalizeQuaternionBlend(){} // RVA: 0x7FFAC3B0E8A0
        public void RotateVector_07C18381C4B4(){} // RVA: 0x7FFAC3B0E900
        public void GetTransformRotation(){} // RVA: 0x7FFAC3B0E910
        public void ResolveLocalRotation(){}
        public void SyncLocalRotation(){} // RVA: 0x7FFAC3B0EB70
        public void ApplyLocalRotation(){} // RVA: 0x7FFAC3B0ECC0
        public void IsInvoking_59070821FBF6(){} // RVA: 0x7FFAC3B0EE00
        public void OnEnable(){} // RVA: 0x7FFAC3B0F0E0
        public void get_Internal(){} // RVA: 0x7FFAC3B0F270
        public void GetInputSourceHandleCurrent(){} // RVA: 0x7FFAC3B0F4A0
        public void ResolveTransformMapping(){} // RVA: 0x7FFAC3B0F650
        public void UpdateTransformMapping(){} // RVA: 0x7FFAC3B10260
        public void OnEnable_FF8EEB6282DE(){} // RVA: 0x7FFAC3B103D0
        public void InitializeComponentFlag(){} // RVA: 0x7FFAC3B10470
        public void PrepareRelativeRotation(){} // RVA: 0x7FFAC3B104D0
        public void ResolveRelativeRotation(){} // RVA: 0x7FFAC3B10950
        public void AssignHumanoidReferences(){} // RVA: 0x7FFAC3B10AD0
        public void DoInverseTransformPoint_Injected_3E5(){} // RVA: 0x7FFAC3B10B30
        public void SetRotationCurrent_4B6D05862416(){} // RVA: 0x7FFAC3B10D30
        public void SetLocalRotation(){} // RVA: 0x7FFAC3B10EB0
        public void ApplyLocalRotationCurrent(){} // RVA: 0x7FFAC3B10FE0
        public void get_Start_Move(){} // RVA: 0x7FFAC3B11450
        public void SyncTransform_5E919D5007E2(){} // RVA: 0x7FFAC3B116A0
        public void ApplySharedTextMaterial(){} // RVA: 0x7FFAC3B119A0
        public void ApplyRotation(){} // RVA: 0x7FFAC3B11F10
        public void SetLocalRotation_D97E430E25E7(){} // RVA: 0x7FFAC3B125B0
        public void ApplyTransform_77F427D0E26E(){} // RVA: 0x7FFAC3B12C20
        public void Start(){} // RVA: 0x7FFAC3B12D10
        public void Update_BE0CAA09FBAC(){} // RVA: 0x7FFAC3B12DB0
        public void InitializeAvatarGoalPose(){} // RVA: 0x7FFAC3B130D0
        public void InitializeAnimatorGoalPose(){} // RVA: 0x7FFAC3B130E0
        public void InitializeTextMaterial(){} // RVA: 0x7FFAC3B13340
        public void ApplyAvatarGoalPose(){} // RVA: 0x7FFAC3B135E0
        public void ApplyAnimatorGoalPose(){} // RVA: 0x7FFAC3B13A00
        public void UpdateAnimatorGoalPose(){} // RVA: 0x7FFAC3B13F90
        public void ApplyTextMaterial(){} // RVA: 0x7FFAC3B14080
        public void GetTransformData(){} // RVA: 0x7FFAC3B140E0
        public void ProcessTransformData(){} // RVA: 0x7FFAC3B14140
        public void SyncTransformPose(){} // RVA: 0x7FFAC3B141A0
        public void SyncPoseFromRotationTarget(){} // RVA: 0x7FFAC3B14CD0
        public void HasValidData(){} // RVA: 0x7FFAC3B154F0
        public void ValidateTransformData(){} // RVA: 0x7FFAC3B15630
        public void MoveNext(){} // RVA: 0x7FFAC3B159C0
        public void SyncAnimatorGoalPose(){} // RVA: 0x7FFAC3B15BF0
        public void UpdateTextMaterial(){} // RVA: 0x7FFAC3B15CF0
        public void SetTextMaterial(){} // RVA: 0x7FFAC3B161D0
        public void UpdatelocalScale_I(){} // RVA: 0x7FFAC3B163A0
        public void GetUnityEngine_1CFDDA334B8D(){} // RVA: 0x7FFAC3B16590
        public void GetActiveSelf_CE6(){} // RVA: 0x7FFAC3B165F0
        public void RefreshTextMaterial(){} // RVA: 0x7FFAC3B168A0
        public void SetAvatarGoalPose(){} // RVA: 0x7FFAC3B16930
        // ── Unresolved (hash) ──
        public void m_124(){} // RVA: 0x7FFAC3B102E0
        public void m_B49(){} // RVA: 0x7FFAC3B14B60
    }

}