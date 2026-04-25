// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Player
// Classes: 42
// Methods: 1478

namespace VRC.Player
{
    /// <summary>Originally: ÍÍÍÎÏÍÍÏÍÍÎÍÌÎÏÏÎÍÎÎÌÌÏ</summary>
    public class PlayerBackgroundNameIsVRCPlus_AA53
    {
        public int _backgroundName;
        public System.Collections.Generic.KeyValuePair`2<string,object> _preview;
        public LogValues`3<U,V,T> _isVRCPlus;

        // ── Methods ──
        public void get_BackgroundName(){} // RVA: 0x7FFD4E0788A0
        public void get_Preview(){} // RVA: 0x7FFD4E078E90
        public void get_IsVRCPlus(){} // RVA: 0x7FFD4E079D00
        public void set_IsVRCPlus(){} // RVA: 0x7FFD4E078E90
        public void set_Preview(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÏÍÎÌÌÌÎÍÏÎÍÏÍÍÌÎÏÏÏÏÎÎÌ</summary>
    public class PlayerCalculateLayoutInputHorizCalculateLayout_5653 : LayoutGroup
    {
        public float _padding; // 0x60
        public float _childAlignment; // 0x64
        public float _rectTransform; // 0x68
        public float _rectChildren; // 0x6C
        public bool _minWidth; // 0x70
        public bool ÌÍÎÌÎÌÏÍÏÌÌÎÏÏÎÍÎÎÌÍÍÎÌ; // 0x71
        public bool ÌÍÏÍÌÏÍÎÏÎÍÌÎÌÌÎÏÍÏÍÏÎÏ; // 0x72
        public bool ÍÍÎÌÍÏÎÍÎÏÌÏÌÌÎÍÏÌÌÎÌÏÌ; // 0x73
        public R m_StartAxis; // 0x74
        public System.Collections.Generic.IList`1<UnityEngine.RectTransform> ÏÍÌÎÎÎÏÎÍÌÏÌÎÏÌÎÎÏÍÌÌÌÏ; // 0x78

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFD4F7F8210
        public void SetLayoutVertical(){} // RVA: 0x7FFD4F7F82E0
        public void get_childAlignment(){} // RVA: 0x7FFD4F7F82F0
        public void set_childAlignment(){} // RVA: 0x7FFD4F7F83B0
        public void get_rectTransform(){} // RVA: 0x7FFD4F7F8410
        public void .ctor(){} // RVA: 0x7FFD4F7F8430
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4F7F8500
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD4F7F86E0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4F7F86F0
        public void get_preferredWidth(){} // RVA: 0x7FFD4F7F88C0
        public void get_flexibleWidth(){} // RVA: 0x7FFD4F7F8910
        public void get_minHeight(){} // RVA: 0x7FFD4F7F92D0
        public void get_preferredHeight(){} // RVA: 0x7FFD4F7F9720
        public void get_flexibleHeight(){} // RVA: 0x7FFD4F7F97F0
        public void OnDisable(){} // RVA: 0x7FFD4F7F9850
        public void SetLayoutHorizontal_E6AE6256811D(){} // RVA: 0x7FFD4F7F98B0
        public void SetLayoutVertical_06148619B63F(){} // RVA: 0x7FFD4F7F9980
        public void UpdatePadding(){} // RVA: 0x7FFD4F7F99A0
        public void OnEnable(){} // RVA: 0x7FFD4F7F9DE0
        public void ReadComponentState(){} // RVA: 0x7FFD4F7F9E00
        public void get_DefaultBufferSize(){} // RVA: 0x7FFD4F7F9E20
        public void GetTotalMinSize(){} // RVA: 0x7FFD4F7F9E30
        public void GetTotalPreferredSize(){} // RVA: 0x7FFD4F7FA990
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFD4F7FA9E0
        public void GetStartOffset(){} // RVA: 0x7FFD4F7FAAB0
    }

    /// <summary>Originally: ÌÎÍÏÍÌÏÌÏÍÌÎÎÌÎÌÎÌÌÍÍÎÌ</summary>
    public class PlayerCalculateLayoutInputHorizCalculateLayout_9DC6 : GridLayoutGroup
    {
        public float ÍÌÏÍÍÏÎÏÍÌÏÌÌÎÎÌÏÌÍÎÍÌÌ;
        public float _flexibleWidth; // 0x80
        public float _flexibleHeight; // 0x84

        // ── Methods ──
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4EB13C20
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4EB13F20
        public void .ctor(){} // RVA: 0x7FFD4EB14140
    }

    /// <summary>Originally: ÌÏÏÍÏÌÏÍÌÍÌÍÍÍÏÌÏÏÎÎÌÌÏ</summary>
    public class PlayerControllerColliderHitHandler_0C8C : MonoBehaviour
    {
        public ÌÎÌÍÎÌÌÍÏÏÍÍÍÎÍÌÍÎÎÎÍÏÎ ÎÌÏÎÌÎÎÌÎÎÍÎÎÌÎÎÌÌÍÏÍÍÎ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F634CD0
        public void RaiseCancellation(){} // RVA: 0x7FFD4F634F60
        public void IsInvoking(){} // RVA: 0x7FFD4F6351F0
        public void CancelInvoke(){} // RVA: 0x7FFD4F635480
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F635710
        public void SetCancellationCallback(){} // RVA: 0x7FFD4F6359A0
        public void OnControllerColliderHit(){} // RVA: 0x7FFD4F635C30
    }

    /// <summary>Originally: ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ</summary>
    public class PlayerControllerColliderHitHandler_1F75 : MonoBehaviour
    {
        public UnityEngine.LayerMask _destroyCancellationToken; // 0x20
        public float _useGUILayout; // 0x24
        public float f_941; // 0x28
        public bool f_001; // 0x2C
        public bool f_0AB; // 0x2D
        public bool f_BB9; // 0x2E
        public bool f_F91; // 0x2F
        public float f_728; // 0x30
        public bool f_A22; // 0x34
        public bool f_397; // 0x35
        public bool f_FBF; // 0x36
        public bool f_776; // 0x37
        public float f_758; // 0x38
        public UnityEngine.CharacterController f_5B6; // 0x40
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ f_472; // 0x48
        public UnityEngine.Vector3 f_8D0; // 0x50
        public UnityEngine.Vector3 ÌÎÍÌÎÎÌÌÌÌÍÌÌÎÏÍÎÏÍÎÌÎÌ; // 0x5C
        public UnityEngine.Quaternion ÌÎÏÎÌÎÏÏÏÎÏÎÏÏÌÎÏÎÏÍÎÍÍ; // 0x68
        public UnityEngine.Quaternion ÏÌÎÌÎÏÎÏÍÎÌÎÎÎÎÏÌÏÌÏÌÏÍ; // 0x78
        public float ÌÎÌÏÍÏÌÎÎÍÎÏÏÍÏÌÏÎÌÎÌÌÌ; // 0x88
        public bool ÏÎÌÌÌÏÌÌÎÎÎÍÍÏÌÏÎÍÌÏÍÎÍ; // 0x8C
        public UnityEngine.Collider ÏÌÌÏÍÏÏÍÎÍÎÍÌÏÏÍÎÍÍÌÎÏÏ; // 0x90
        public UnityEngine.Vector3 ÎÌÎÌÏÌÌÎÎÏÎÍÍÏÏÌÏÏÌÌÎÎÎ; // 0x98
        public UnityEngine.Vector3 ÍÍÏÏÌÍÌÏÎÌÏÏÏÍÎÍÌÌÍÎÌÏÏ; // 0xA4
        public UnityEngine.Vector3 ÌÎÌÏÍÍÌÏÍÎÍÌÏÏÎÎÌÎÏÌÍÌÏ; // 0xB0
        public float ÍÍÌÏÌÎÎÍÌÎÏÍÍÏÏÎÎÎÏÏÎÎÏ; // 0xBC
        public float ÎÏÌÎÏÎÎÏÍÌÎÏÏÌÌÍÍÍÎÎÏÌÍ; // 0xC0
        public bool ÏÍÍÏÎÏÏÎÏÍÏÏÏÎÌÏÏÎÏÍÌÍÎ; // 0xC4
        public float ÎÍÍÏÎÌÍÍÍÏÎÎÎÍÌÌÌÏÏÍÌÎÎ; // 0xC8
        public bool ÏÍÎÎÏÎÏÎÎÌÌÎÏÌÎÏÏÍÎÏÎÏÌ; // 0xCC
        public bool ÌÍÌÎÌÏÏÌÍÏÌÌÎÌÏÏÎÌÏÍÍÌÏ; // 0xCD
        public bool ÍÏÏÎÎÍÍÍÎÍÍÍÍÌÏÍÏÏÎÍÍÎÌ; // 0xCE
        public bool ÎÌÏÏÍÍÌÍÍÏÏÍÎÌÌÏÌÎÌÎÏÏÌ; // 0xCF
        public float ÍÌÌÏÏÌÏÌÎÍÍÍÏÍÏÏÎÏÍÎÌÏÌ; // 0xD0
        public 0x663803D8 ÏÎÏÏÎÎÎÎÎÎÌÍÍÎÎÏÎÌÎÎÍÏÍ; // 0xD4
        public float ÎÌÎÏÌÏÏÌÌÎÏÏÎÏÌÏÍÌÌÏÏÍÏ; // 0xD8
        public bool ÌÏÍÌÏÎÏÍÎÎÎÎÎÏÌÏÌÌÍÍÎÍÌ; // 0xDC

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4FB57390
        public void RaiseCancellation(){} // RVA: 0x7FFD4FB58030
        public void get_swapBumpers(){} // RVA: 0x7FFD4FB58160
        public void CancelInvoke(){} // RVA: 0x7FFD4FB58170
        public void OnDestroy(){} // RVA: 0x7FFD4FB58E10
        public void OnControllerColliderHit_BEDB0985F036(){} // RVA: 0x7FFD4FB58E60
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7FFD4FB58E80
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFD4FB58E90
        public void StartCoroutine(){} // RVA: 0x7FFD4FB58EA0
        public void Reset(){} // RVA: 0x7FFD4FB58EB0
        public void OnCollisionStay(){} // RVA: 0x7FFD4FB59090
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4FB590F0
        public void SetProgress(){} // RVA: 0x7FFD4EB37190
        public void StopCoroutine(){} // RVA: 0x7FFD4FB59150
        public void OnTriggerExit(){} // RVA: 0x7FFD4FB592F0
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFD4FB594B0
        public void get_useGUILayout(){} // RVA: 0x7FFD4FB594C0
        public void set_useGUILayout(){} // RVA: 0x7FFD4FB594D0
        public void set_meanLine(){} // RVA: 0x7FFD4FB594E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4FB594F0
        public void Awake(){} // RVA: 0x7FFD4FB5A8C0
        public void InvokeDelayed(){} // RVA: 0x7FFD4FB5A900
        public void set_swapBumpers(){} // RVA: 0x7FFD4FB5AAC0
        public void get_cageUpdateEveryFrame(){} // RVA: 0x7FFD4E752010
        public void set_invertStickY(){} // RVA: 0x7FFD4FB5AAD0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4FB5AAE0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4FB5AFA0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4FB5A8C0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4FB58160
        public void GetScriptClassName(){} // RVA: 0x7FFD4FB5AFC0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4FB5AFD0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4FB5B070
        public void OnCollisionEnter(){} // RVA: 0x7FFD4FB5B390
        public void OnCollisionExit(){} // RVA: 0x7FFD4FB5B540
        public void OnControllerColliderHit_BED45B471A23(){} // RVA: 0x7FFD4FB5B550
        public void .ctor(){} // RVA: 0x7FFD4FB5B590
        public void Initialize(){} // RVA: 0x7FFD4FB5B7E0
        public void set_swapSticks(){} // RVA: 0x7FFD4FB5BA00
        public void HandleColliderHit(){} // RVA: 0x7FFD4FB5BA10
        public void set_inContact(){} // RVA: 0x7FFD4E37BAC0
        public void ProcessColliderHit(){} // RVA: 0x7FFD4FB5BBB0
        public void get_AlignmentAxis(){} // RVA: 0x7FFD4FB5BBC0
        public void Start(){} // RVA: 0x7FFD4FB5BBE0
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFD4ED4CE00
        public void Update(){} // RVA: 0x7FFD4FB5C0C0
        public void get_Progress(){} // RVA: 0x7FFD4EB36E90
        public void OnControllerColliderHit(){} // RVA: 0x7FFD4FB5C0D0
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4F060670
        public void get_swapSticks(){} // RVA: 0x7FFD4FB5C630
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFD4E420230
        public void OnBecameVisible(){} // RVA: 0x7FFD4FB5C630
        public void OnDestroy_E5EE5FD706E0(){} // RVA: 0x7FFD4FB58E10
        public void UpdateColliderState(){} // RVA: 0x7FFD4FB5C640
        public void set_swapBumpers_3B8C8230B1B9(){} // RVA: 0x7FFD4FB5AAC0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFD4EC36470
        public void OnTriggerEnter(){} // RVA: 0x7FFD4FB594B0
    }

    /// <summary>Originally: ÍÎÏÏÎÍÎÎÎÏÌÎÎÍÌÍÏÍÍÍÎÌÏ</summary>
    public class PlayerCustomInputTextEdited_1259 : ComplexComponentImpl_A727
    {
        public TMPro.TMP_InputField customInputText; // 0x1F0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _customInputPlaceholderText; // 0x1F8
        public UnityEngine.UI.Button _editTextButton; // 0x200
        public string ÎÌÏÍÏÌÎÍÎÎÎÏÍÏÏÎÌÎÌÎÏÏÎ; // 0x208
        public ÌÍÎÍÏÏÎÌÌÏÏÏÏÏÎÏÍÌÎÍÎÎÍ ÏÌÌÌÏÏÏÏÎÏÏÌÌÌÍÎÌÏÎÏÎÌÎ; // 0x210

        // ── Methods ──
        public void OnCustomInputTextEdited(){} // RVA: 0x7FFD568D0E10
        public void .ctor(){} // RVA: 0x7FFD5672A050
        public void Initialize(){} // RVA: 0x7FFD568D10C0
        public void OnApplicationPause(){} // RVA: 0x7FFD568D10E0
        public void OnApplicationQuit(){} // RVA: 0x7FFD568D13C0
        public void Awake(){} // RVA: 0x7FFD568D1680
        public void OnDestroy(){} // RVA: 0x7FFD568D1740
        public void HandlePlayerInputTextObject(){} // RVA: 0x7FFD568D1790
        public void Initialize_39E38C3C02D0(){} // RVA: 0x7FFD568D10C0
        public void OnCollisionEnter(){} // RVA: 0x7FFD568D1A70
        public void Awake_5A1BCB77FFEF(){} // RVA: 0x7FFD568D1D50
        public void Start(){} // RVA: 0x7FFD568D2030
        public void OnTriggerExit(){} // RVA: 0x7FFD568D2090
        public void Initialize_918FBB1E988D(){} // RVA: 0x7FFD568D10C0
        public void Initialize_DA765644722F(){} // RVA: 0x7FFD568D10C0
    }

    /// <summary>Originally: ÌÌÎÌÏÌÎÌÏÍÌÏÏÏÌÍÌÎÌÎÍÏÍ</summary>
    public class PlayerIsInteractivePickupUseDown_C325 : VRCInteractable
    {
        public System.Action`2<0x66389F90,bool> _isInteractive;
        public System.Action`1<0x66389F90> ÌÍÌÍÎÏÎÍÍÌÍÍÌÌÍÎÏÌÎÍÍÏÌ; // 0x8
        public 0x66389F90 InteractableType; // 0x40
        public ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ ÎÍÌÎÍÎÍÎÌÌÍÎÏÏÌÎÍÎÍÌÌÌÏ; // 0x48

        // ── Methods ──
        public void OnPickupUseDown(){} // RVA: 0x7FFD4E788150
        public void OnPickup(){} // RVA: 0x7FFD4E788170
        public void get_IsInteractive_19C42D36BABD(){} // RVA: 0x7FFD4E7881D0
        public void Interact_69B77CDCC803(){} // RVA: 0x7FFD4E788300
        public void Awake(){} // RVA: 0x7FFD4E788430
        public void .ctor(){} // RVA: 0x7FFD4E788510
        public void Initialize(){} // RVA: 0x7FFD4E788520
        public void OnDrop_BAA2F1537118(){} // RVA: 0x7FFD4E788650
        public void OnDrop(){} // RVA: 0x7FFD4E788780
        public void set_IsInteractive(){} // RVA: 0x7FFD4E7887E0
        public void CheckPlayerInteractivePickupState(){} // RVA: 0x7FFD4E788910
        public void Interact(){} // RVA: 0x7FFD4E788A40
        public void get_IsInteractive(){} // RVA: 0x7FFD4E426850
        public void EvaluatePlayerInteractivePickupUseDown(){} // RVA: 0x7FFD4E788AA0
    }

    /// <summary>Originally: ÎÌÍÍÏÌÌÍÏÎÏÎÌÏÎÎÌÌÎÏÌÏÌ</summary>
    public class PlayerJoinedPlayerLeftHandler_8B85 : MonoBehaviour
    {
        public System.DateTime ÌÌÎÍÌÍÎÏÎÏÍÌÎÌÌÏÌÎÎÎÍÏÎ; // 0x20
        public bool ÏÍÍÎÏÎÍÏÏÎÎÏÏÍÏÎÏÎÎÎÎÎÌ; // 0x28
        public System.Action`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÌÎÏÏÌÏÍÌÌÍÏÎÌÍÍÌÌÌÌÌÍÌÌ;
        public ÎÌÍÍÏÌÌÍÏÎÏÎÌÏÎÎÌÌÎÏÌÏÌ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ; // 0x8
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.HashSet`1<int>> ÎÎÏÏÍÍÏÏÎÌÏÍÌÌÌÎÎÌÌÌÍÏÌ; // 0x10
        public System.Collections.Generic.List`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÏÏÎÏÏÎÌÎÏÏÎÌÍÏÏÍÍÌÎÎÍÏÍ; // 0x18

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4EEB71E0
        public void RaiseCancellation(){} // RVA: 0x7FFD4EEB7390
        public void IsInvoking(){} // RVA: 0x7FFD4EEB7450
        public void CancelInvoke(){} // RVA: 0x7FFD4EEB7840
        public void Invoke(){} // RVA: 0x7FFD4EEB7A00
        public void InvokeRepeating(){} // RVA: 0x7FFD4EEB7B60
        public void OnDisable(){} // RVA: 0x7FFD4EEB82E0
        public void IsInvoking_275FA00D084F(){} // RVA: 0x7FFD4EEB8500
        public void StartCoroutine(){} // RVA: 0x7FFD4EEB8650
        public void OnPlayerJoined(){} // RVA: 0x7FFD4EEB8710
        public void .ctor(){} // RVA: 0x7FFD4EEB8800
        public void Initialize(){} // RVA: 0x7FFD4EEB88A0
        public void StopCoroutine(){} // RVA: 0x7FFD4EEB8A80
        public void Start(){} // RVA: 0x7FFD4EEB8C20
        public void Update(){} // RVA: 0x7FFD4EEB8F50
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EEB90B0
        public void .cctor(){} // RVA: 0x7FFD4EEB9490
        public void set_useGUILayout(){} // RVA: 0x7FFD4EEB9630
        public void print(){} // RVA: 0x7FFD4EEB97B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EEB98E0
        public void OnPlayerLeft(){} // RVA: 0x7FFD4EEB99D0
        public void InvokeDelayed(){} // RVA: 0x7FFD4EEB9A90
        public void OnDestroy(){} // RVA: 0x7FFD4EEBA450
        public void OnCollisionEnter(){} // RVA: 0x7FFD4EEBA6B0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EEBA8D0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EEBAC90
    }

    /// <summary>Originally: ÏÍÍÌÏÍÎÍÍÏÏÍÍÎÏÍÎÍÎÎÏÏÍ</summary>
    public class PlayerJoinedPlayerLeft_F5C6 : Object
    {
        public System.Collections.Generic.HashSet`1<int> _f5C6; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT ÏÌÎÏÍÍÍÌÎÍÌÎÏÍÍÏÌÏÌÌÏÌÎ; // 0x18
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ ÌÏÍÎÏÍÌÎÏÌÎÌÌÏÌÍÍÏÏÌÍÌÎ; // 0x20
        public VRC.Core.Networking.Codec.StateManagement.PersistenceObjectStateManager ÍÎÏÏÍÍÎÏÏÏÎÏÏÍÌÏÏÏÍÏÎÎÍ; // 0x28
        public System.Collections.Generic.Dictionary`2<string,byte[]> ÏÎÎÏÌÌÏÌÍÎÎÎÌÏÎÏÎÎÍÌÏÍÎ;
        public System.Collections.Generic.Dictionary`2<string,byte[]> ÎÌÌÎÏÎÎÏÍÍÎÌÎÌÍÌÏÌÎÌÍÍÏ; // 0x8

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F1F7710
        public void Equals(){} // RVA: 0x7FFD4F1F7A80
        public void GetHashCode(){} // RVA: 0x7FFD4F1F7DC0
        public void op_Implicit(){} // RVA: 0x7FFD4F1F8080
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F1F80C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F1F8120
        public void GetCachedPtr(){} // RVA: 0x7FFD4F1F85E0
        public void get_name(){} // RVA: 0x7FFD4F1F86F0
        public void set_name(){} // RVA: 0x7FFD4F1F8A30
        public void .cctor(){} // RVA: 0x7FFD4F1F8AD0
        public void Instantiate(){} // RVA: 0x7FFD4F1F8C50
        public void ToString(){} // RVA: 0x7FFD4F1F90E0
        public void OnPlayerLeft(){} // RVA: 0x7FFD4F1F9110
        public void .ctor_B1516F861635(){} // RVA: 0x7FFD4F1F93F0
        public void OnPlayerJoined(){} // RVA: 0x7FFD4F1F9880
        public void .ctor(){} // RVA: 0x7FFD4F1F9DD0
        public void Initialize(){} // RVA: 0x7FFD4F1FB640
        public void ProcessPlayerSystemMessage(){} // RVA: 0x7FFD4F1FB920
        public void Destroy(){} // RVA: 0x7FFD4F1FB980
        public void PlayerJoinedPlayerLeft(){} // RVA: 0x7FFD4F1FBA00
        public void GetNodeSetData(){} // RVA: 0x7FFD4F1FBA80
        public void DestroyImmediate(){} // RVA: 0x7FFD4F1FBAA0
        public void PlayerJoinedPlayerLeft_1CC394797991(){} // RVA: 0x7FFD4F1FBB10
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F1FBE90
        public void PlayerJoinedPlayerLeft_E5D369FA006B(){} // RVA: 0x7FFD4F1FBEA0
        public void FindObjectsByType(){} // RVA: 0x7FFD4F1FBF10
        public void PlayerJoinedPlayerLeft_1175A20CFE91(){} // RVA: 0x7FFD4F1FC270
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F1FC370
        public void get_hideFlags(){} // RVA: 0x7FFD4F1F80C0
        public void set_hideFlags(){} // RVA: 0x7FFD4F1FC690
    }

    /// <summary>Originally: ÏÍÍÎÎÏÎÌÎÌÌÍÏÎÎÏÏÍÏÌÏÍÌ</summary>
    public class PlayerLeftHandlerImpl_4B35 : PlayerLeftHandler_7766
    {
        public ÏÌÍÎÏÍÌÌÎÏÍÎÍÍÌÎÌÍÎÌÏÌÎ f_B66; // 0xC0
        public UnityEngine.LayerMask f_31F; // 0xC8
        public 0x66360668 ÌÌÌÌÌÏÎÌÏÎÌÎÏÌÏÌÌÎÏÏÏÏÏ; // 0xCC
        public 0x66360668 ÌÎÌÎÍÎÏÍÏÎÍÎÍÌÏÎÏÍÍÎÍÏÍ; // 0xD0
        public 0x6636A380 pointerUsage; // 0xD4

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F724EF0
        public void CheckModuleActivationCondition(){} // RVA: 0x7FFD4F724F60
        public void setReadOnly(){} // RVA: 0x7FFD4F725250
        public void get_AudioCaptureSource(){} // RVA: 0x7FFD4EAB6B20
        public void OnEnable(){} // RVA: 0x7FFD4F725910
        public void InvokeRepeating(){} // RVA: 0x7FFD4F725A00
        public void UpdateLifecycleState(){} // RVA: 0x7FFD4F724EF0
        public void OnAttachedToHand(){} // RVA: 0x7FFD4F725BC0
        public void OnDisable(){} // RVA: 0x7FFD4F725CF0
        public void FixedUpdate(){} // RVA: 0x7FFD4F725E20
        public void get_AudioCaptureSource_F7399BABC1E6(){} // RVA: 0x7FFD4EAB6B20
        public void Awake(){} // RVA: 0x7FFD4EBB8890
        public void OnDestroy(){} // RVA: 0x7FFD4F7260D0
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFD4F726300
        public void .ctor(){} // RVA: 0x7FFD4F726540
        public void LateUpdate(){} // RVA: 0x7FFD4F726560
        public void get_pointerBehavior(){} // RVA: 0x7FFD4F7265A0
        public void get_AudioCaptureSource_9562312159C7(){} // RVA: 0x7FFD4EAB6B20
    }

    /// <summary>Originally: ÌÏÏÍÏÎÏÎÍÎÎÍÎÎÏÏÌÍÎÌÏÌÎ</summary>
    public class PlayerLeftHandlerImpl_5F7E : PlayerLeftHandler_7766
    {
        public UnityEngine.Color ÏÎÍÍÍÏÌÎÏÍÎÌÌÍÌÏÌÌÍÎÍÌÎ; // 0xC0
        public UnityEngine.Color ÏÍÌÌÎÌÍÎÍÏÎÎÏÏÌÎÏÏÌÎÌÏÌ; // 0xD0
        public UnityEngine.UI.Image ÍÍÏÎÎÎÌÍÎÌÍÌÎÏÎÏÍÍÌÎÏÍÏ; // 0xE0
        public UnityEngine.Renderer[] ÏÎÏÎÏÏÏÏÍÍÍÍÌÌÏÎÍÍÏÌÎÎÌ; // 0xE8
        public UnityEngine.Material[] ÎÎÍÌÏÌÎÍÌÌÌÏÌÍÎÍÌÍÎÏÌÌÌ; // 0xF0
        public UnityEngine.Color[] ÍÌÎÎÌÌÌÍÎÍÎÏÏÌÏÎÏÍÍÏÌÎÌ; // 0xF8
        public UnityEngine.Color[] ÎÎÎÎÎÏÎÍÍÌÌÏÌÍÌÌÏÍÌÎÍÍÌ; // 0x100
        public float[] ÍÏÎÌÍÌÌÌÏÌÌÍÎÎÎÌÍÎÍÌÎÏÌ; // 0x108
        public UnityEngine.Vector2 ÎÎÏÌÏÎÎÎÎÌÍÍÎÍÌÌÍÏÎÌÍÏÎ; // 0x110
        public float ÍÍÌÍÍÏÏÍÍÎÎÍÍÏÍÏÍÎÍÍÌÎÍ;
        public bool ÌÌÏÏÍÌÏÍÌÌÏÌÎÍÎÏÏÎÏÎÍÎÏ; // 0x118
        public float ÏÏÎÏÏÍÌÏÎÏÏÍÎÌÌÌÏÎÍÍÏÏÌ; // 0x11C
        public ÏÎÍÌÌÍÍÌÎÌÏÍÎÏÌÏÏÌÌÎÌÏÍ ÎÏÎÍÏÎÏÌÌÌÏÌÎÏÍÌÌÏÏÍÌÏÌ; // 0x120

        // ── Methods ──
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F722AA0
        public void Awake_482C69232443(){} // RVA: 0x7FFD4EBB8890
        public void Awake(){} // RVA: 0x7FFD4EBB8890
        public void OnDestroy(){} // RVA: 0x7FFD4EBB8890
        public void Awake_A4FBD8E7D79E(){} // RVA: 0x7FFD4EBB8890
        public void Initialize(){} // RVA: 0x7FFD4F723350
        public void .ctor(){} // RVA: 0x7FFD4F723730
        public void Awake_704C45022A97(){} // RVA: 0x7FFD4EBB8890
        public void LateUpdate(){} // RVA: 0x7FFD4F7237C0
        public void FixedUpdate(){} // RVA: 0x7FFD4F723D50
        public void Save(){} // RVA: 0x7FFD4F7240B0
        public void HasPointerInputActivity(){} // RVA: 0x7FFD4F724630
        public void Awake_1AFBA5BAE83F(){} // RVA: 0x7FFD4EBB8890
    }

    /// <summary>Originally: ÏÎÍÍÎÏÏÍÍÏÌÍÍÏÌÏÎÌÎÎÏÍÍ</summary>
    public class PlayerLeftHandlerImpl_734E : PlayerLeftHandler_7766
    {
        public float ÍÏÎÏÌÌÏÎÌÎÎÎÍÏÎÎÍÎÎÏÌÏÌ;
        public float ÏÎÏÌÏÎÌÏÎÌÏÌÌÍÌÎÏÎÌÍÍÌÎ;
        public UnityEngine.UI.Image ÍÍÏÎÎÎÌÍÎÌÍÌÎÏÎÏÍÍÌÎÏÍÏ; // 0xC0
        public ÏÎÍÌÌÍÍÌÎÌÏÍÎÏÌÏÏÌÌÎÌÏÍ ÎÏÎÍÏÎÏÌÌÌÏÌÎÏÍÌÌÏÏÍÌÏÌ; // 0xC8
        public float ÏÏÏÌÍÏÍÎÌÏÌÎÏÎÍÏÌÎÍÌÎÏÌ;
        public UnityEngine.Vector3 ÍÌÏÍÎÌÍÍÌÏÍÎÍÎÏÏÎÍÍÎÎÌÏ; // 0xD0

        // ── Methods ──
        public void GetTransformLossyScale(){} // RVA: 0x7FFD4F71D680
        public void .ctor(){} // RVA: 0x7FFD4F71D810
        public void Initialize(){} // RVA: 0x7FFD4F71D8F0
        public void UpdateJobData(){} // RVA: 0x7FFD4F71DDB0
        public void Awake_72DBB3B19E43(){} // RVA: 0x7FFD4EBB8890
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFD4F71EAF0
        public void OnDestroy(){} // RVA: 0x7FFD4F71EBB0
        public void ReadColliderState(){} // RVA: 0x7FFD4F71EC80
        public void Awake(){} // RVA: 0x7FFD4EBB8890
        public void FixedUpdate(){} // RVA: 0x7FFD4F71ED60
        public void ReadColliderState_6136DEC30AB8(){} // RVA: 0x7FFD4F71EC80
        public void set_bodyPositionInternal(){} // RVA: 0x7FFD4F71EE50
        public void StopCoroutine(){} // RVA: 0x7FFD4F71ED60
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFD4F71F180
        public void OnDisable(){} // RVA: 0x7FFD4F71F4B0
    }

    /// <summary>Originally: ÎÏÏÍÎÏÍÍÎÏÏÍÍÏÎÎÌÎÎÍÏÎÏ</summary>
    public class PlayerLeftHandlerImpl_B1FA : PlayerLeftHandler_7766
    {
        public UnityEngine.LineRenderer ÍÌÍÌÍÍÎÏÍÍÎÍÎÏÍÌÌÍÎÏÌÍÎ; // 0xC0
        public ÏÎÍÌÌÍÍÌÎÌÏÍÎÏÌÏÏÌÌÎÌÏÍ ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0xC8
        public UnityEngine.Color ÍÎÌÍÎÍÏÌÍÍÎÍÍÍÌÌÎÌÌÏÍÍÍ; // 0xD0
        public UnityEngine.Color ÍÌÎÎÍÏÌÍÏÍÎÎÎÌÎÏÏÍÎÍÌÎÎ; // 0xE0
        public 0x66360668 ÌÌÌÌÌÏÎÌÏÎÌÎÏÌÏÌÌÎÏÏÏÏÏ; // 0xF0
        public 0x66360668 ÌÎÌÎÍÎÏÍÏÎÍÎÍÌÏÎÏÍÍÎÍÏÍ; // 0xF4
        public float ÍÎÏÎÎÍÍÌÏÌÍÌÎÎÌÏÏÎÌÍÏÍÌ; // 0xF8
        public float ÌÍÏÏÎÌÏÎÎÌÍÏÎÍÏÌÏÍÍÌÍÏÌ; // 0xFC
        public float ÏÍÍÏÍÏÍÌÏÍÌÌÌÏÏÍÎÏÎÍÌÎÍ;
        public float ÌÍÏÍÍÎÍÍÏÌÌÌÌÌÍÎÌÌÎÎÏÎÍ;
        public float ÎÌÎÎÍÍÎÍÌÏÌÎÎÏÍÍÍÏÎÏÌÌÍ; // 0x100
        public float ÌÎÍÌÏÎÌÌÏÍÏÍÌÎÎÎÏÎÎÎÌÎÏ; // 0x104
        public float ÏÎÌÏÌÍÌÍÌÏÎÌÎÌÍÏÍÏÎÎÎÎÏ; // 0x108
        public float ÎÌÌÍÎÏÍÏÏÏÎÏÌÌÎÏÏÏÎÍÌÏÎ;
        public UnityEngine.Gradient ÏÏÎÌÌÎÏÌÍÌÎÌÏÏÌÍÏÍÌÏÍÏÏ; // 0x110
        public UnityEngine.GradientAlphaKey[] ÏÎÍÎÌÏÏÏÌÎÌÎÏÏÍÎÎÎÏÎÍÍÌ; // 0x118
        public UnityEngine.GradientColorKey[] ÌÌÎÌÏÌÌÎÎÎÏÍÏÎÍÎÎÌÍÍÎÌÍ; // 0x120

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EBB8260
        public void OnAudioFilterRead(){} // RVA: 0x7FFD4EBB8340
        public void .ctor(){} // RVA: 0x7FFD4EBB8440
        public void Initialize(){} // RVA: 0x7FFD4EBB8660
        public void .cctor(){} // RVA: 0x7FFD4EBB8770
        public void InvokeRepeating(){} // RVA: 0x7FFD4EBB87B0
        public void Awake_1AFBA5BAE83F(){} // RVA: 0x7FFD4EBB8890
        public void OnEnable_A8F6820E4A0E(){} // RVA: 0x7FFD4EBB88B0
        public void Awake_A4FBD8E7D79E(){} // RVA: 0x7FFD4EBB8890
        public void FindRelativeTransformWithPath(){} // RVA: 0x7FFD4EBB8930
        public void OnEnable(){} // RVA: 0x7FFD4EBB9B20
        public void OnDisable(){} // RVA: 0x7FFD4EBB9B30
        public void Awake(){} // RVA: 0x7FFD4EBB8890
    }

    /// <summary>Originally: ÏÍÎÎÎÏÍÍÌÌÌÏÏÌÏÏÌÏÌÎÍÎÍ</summary>
    public class PlayerLeftHandler_4F25 : MonoBehaviour
    {
        public ÏÍÎÎÎÏÍÍÌÌÌÏÏÌÏÏÌÏÌÎÍÎÍ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ;
        public ÏÏÌÎÌÍÍÏÌÌÎÎÎÌÏÏÎÏÏÏÏÎÎ ÌÎÎÏÏÌÏÎÏÌÍÏÌÏÍÍÏÎÏÍÎÌÎ; // 0x20
        public int ÌÎÎÏÍÏÎÎÌÏÍÎÍÏÌÏÎÍÍÌÍÎÌ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EA183A0
        public void RaiseCancellation(){} // RVA: 0x7FFD4EA183B0
        public void LogError(){} // RVA: 0x7FFD4E561EE0
        public void CancelInvoke(){} // RVA: 0x7FFD4EA18780
        public void Invoke(){} // RVA: 0x7FFD4EA18A10
        public void InvokeRepeating(){} // RVA: 0x7FFD4E561EE0
        public void CancelInvoke_3373EFA354FB(){} // RVA: 0x7FFD4EA18F80
        public void OnPlayerLeft(){} // RVA: 0x7FFD4EA19310
        public void StartCoroutine(){} // RVA: 0x7FFD4EA19400
        public void .ctor(){} // RVA: 0x7FFD4EA19650
        public void Initialize(){} // RVA: 0x7FFD4EA19730
        public void Awake(){} // RVA: 0x7FFD4EA19970
        public void OnDestroy(){} // RVA: 0x7FFD4EA1A420
        public void StopCoroutine(){} // RVA: 0x7FFD4EA1A690
        public void FixedUpdate(){} // RVA: 0x7FFD4EA1A750
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EA183A0
        public void get_useGUILayout(){} // RVA: 0x7FFD4EA1A780
        public void set_useGUILayout(){} // RVA: 0x7FFD4EA1A860
        public void print(){} // RVA: 0x7FFD4EA1AA50
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EA1AF00
        public void Internal_IsInvokingAll_B10F87D2FC38(){} // RVA: 0x7FFD4EA1FC20 | overloaded x2
        public void InvokeDelayed(){} // RVA: 0x7FFD4E561EE0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EA1B730
        public void IsInvoking_5EC4A9FB421A(){} // RVA: 0x7FFD4EA1DC60 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EA1B880
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EA1BF30
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4EA1C150
        public void Start(){} // RVA: 0x7FFD4EA1CA20
        public void GetScriptClassName_36AB6805E085(){} // RVA: 0x7FFD4EA1D4C0 | overloaded x2
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4EA1DA40
        public void HandlePointerHover(){} // RVA: 0x7FFD4EA1DC80
        public void OnApplicationPause(){} // RVA: 0x7FFD4EA1DE50
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EA1DEB0
        public void OnBecameVisible(){} // RVA: 0x7FFD4EA1E280
        public void DoRender_CFD(){} // RVA: 0x7FFD4EA1EB50
        public void OnEnable(){} // RVA: 0x7FFD4EA1EC00
        public void OnCollisionStay(){} // RVA: 0x7FFD4EA1EC60
        public void OnCollisionExit(){} // RVA: 0x7FFD4EA1EE80
        public void OnTriggerEnter(){} // RVA: 0x7FFD4EA1F080
        public void OnTriggerStay(){} // RVA: 0x7FFD4EA1F270
        public void OnTriggerExit(){} // RVA: 0x7FFD4EA1F4B0
        public void HandlePointerHoverUseGUILayout(){} // RVA: 0x7FFD4EA1F530
        public void HandlePointerDrag(){} // RVA: 0x7FFD4EA1F8E0
        public void Update(){} // RVA: 0x7FFD4EA1FD80
        public void LateUpdate(){} // RVA: 0x7FFD4EA1FF60
        public void OnDisable(){} // RVA: 0x7FFD4EA20410
    }

    /// <summary>Originally: ÍÎÌÍÏÏÌÍÍÍÍÍÍÏÏÎÏÎÌÏÍÎÎ</summary>
    public class PlayerLeftHandler_7766 : MonoBehaviour
    {
        public bool _destroyCancellationToken; // 0x20
        public bool _useGUILayout; // 0x21
        public 0x6636A8A8 f_1F1; // 0x24
        public UnityEngine.Vector3 f_F0C; // 0x28
        public ÏÎÏÎÍÎÍÎÎÎÍÌÌÌÌÏÌÏÍÎÌÎÏ f_E50; // 0x38
        public ÎÏÌÎÏÍÏÍÌÍÍÎÌÌÍÌÏÌÍÏÌÍÌ f_367; // 0x40
        public ÎÏÌÎÏÍÏÍÌÍÍÎÌÌÍÌÏÌÍÏÌÍÌ f_D2A; // 0x48
        public 0x664C9B98 ÍÎÏÍÎÍÌÏÎÎÏÍÍÏÍÏÎÌÍÍÍÌÎ; // 0x50
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÍÏÍÌÌÎÎÌÏÏÎÏÍÌÎÌÍÌÌÏÎÌ; // 0x58
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÎÎÍÌÌÍÎÌÍÎÌÌÌÎÌÎÍÎÌÌÎÍÎ; // 0x60
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÏÎÎÏÏÎÌÌÎÎÌÏÌÍÏÎÎÎÌÏÌÌ; // 0x68
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÎÎÍÍÎÌÌÏÎÏÏÎÎÎÎÏÎÎÏÏÌÌ; // 0x70
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÍÌÌÌÍÌÌÍÎÍÌÍÍÌÏÎÌÌÌÏÍÍ; // 0x78
        public float ÏÌÌÎÌÏÍÍÏÏÌÎÎÏÎÍÏÎÌÌÎÍÍ;
        public System.Action <ÌÏÏÌÍÎÌÏÌÍÎÏÌÌÎÏÌÌÏÌÎÍÎ>k__BackingField; // 0x80
        public System.Action`1<ÌÌÍÌÏÍÏÌÌÎÏÍÌÏÎÏÍÎÌÍÌÍÏ> ÌÌÎÎÏÏÍÍÏÌÏÌÎÏÍÌÏÎÌÌÌÏÍ; // 0x88
        public System.Action`1<ÌÌÍÌÏÍÏÌÌÎÏÍÌÏÎÏÍÎÌÍÌÍÏ> ÏÏÏÎÏÌÎÌÌÎÌÌÍÏÌÍÍÏÍÎÍÏÍ; // 0x90
        public int ÏÏÎÎÎÎÍÎÌÍÏÎÏÍÌÎÍÍÌÍÍÌÍ;
        public int ÌÌÏÍÍÌÎÌÏÎÍÎÎÌÍÎÏÌÏÍÌÌÎ;
        public UnityEngine.Collider[] ÌÌÍÎÎÏÌÌÎÎÍÍÌÌÏÍÍÎÌÏÎÏÍ; // 0x98
        public System.Collections.Generic.List`1<VRC.SDKBase.VRC_Interactable> ÎÍÎÌÏÎÍÌÍÎÍÌÎÌÍÏÎÎÍÏÌÏÍ; // 0xA0
        public System.Collections.Generic.List`1<VRC.SDKBase.VRC_Interactable> ÏÎÌÎÌÏÎÍÍÍÏÌÏÎÍÎÏÌÏÍÌÎÍ; // 0xA8
        public System.Collections.Generic.List`1<VRC.SDKBase.VRC_Interactable> ÏÏÎÌÌÌÏÎÌÎÎÌÏÎÌÎÍÏÏÎÍÏÍ; // 0xB0
        public UnityEngine.Vector3[] ÎÌÍÎÏÎÏÌÍÏÌÌÎÍÏÏÌÏÌÎÎÌÎ; // 0xB8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E090980
        public void get_EyeFollowingBlendshapesValid(){} // RVA: 0x7FFD4E64AD20
        public void setReadOnly(){} // RVA: 0x7FFD4EB8A610
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F732F20
        public void UpdateLifecycleState(){} // RVA: 0x7FFD4F732F60
        public void OnEnable(){} // RVA: 0x7FFD4F732FA0
        public void StartCoroutine(){} // RVA: 0x7FFD4F732FC0
        public void FixedUpdate(){} // RVA: 0x7FFD4F7330C0
        public void Start(){} // RVA: 0x7FFD4F7331C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F7332C0
        public void StopCoroutine(){} // RVA: 0x7FFD4F7333C0
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFD4F365170
        public void OnDisable(){} // RVA: 0x7FFD4F3655C0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F35B4F0
        public void Return(){} // RVA: 0x7FFD4E096500
        public void set_useGUILayout(){} // RVA: 0x7FFD4F7333D0
        public void print(){} // RVA: 0x7FFD4F734770
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F735FE0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F736310
        public void InvokeDelayed(){} // RVA: 0x7FFD4F7365F0
        public void get_ExecutingTaskCollection_0ED30A51855C(){} // RVA: 0x7FFD4F737DA0
        public void OnPlayerLeft(){} // RVA: 0x7FFD4F737EC0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F737F40
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F737F50
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F738070
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4F7380A0
        public void Initialize(){} // RVA: 0x7FFD4F7384E0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F738760
    }

    /// <summary>Originally: ÏÎÎÏÎÌÏÎÎÏÎÏÏÌÌÍÍÎÎÍÍÎÌ</summary>
    public class PlayerLeftSibling_064C
    {
        // ── Methods ──
        public void InitializePlayerLeft(){}
        public void UpdatePlayerLeft_3CC01A28EBC0(){} // overloaded x2
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void InitializeNetworkState(){}
    }

    /// <summary>Originally: ÏÍÌÍÌÍÌÌÏÏÏÌÎÌÍÏÍÏÏÎÏÍÎ</summary>
    public class PlayerLeft_342A : Object
    {
        public string _name;
        public string _hideFlags;
        public string ÍÏÏÍÍÏÍÎÏÏÍÎÎÍÎÎÏÏÍÌÍÎÎ;
        public string ÌÌÏÎÎÎÌÍÎÏÍÌÍÍÏÌÏÏÎÏÎÎÍ;
        public string ÍÌÎÌÏÌÏÎÏÍÏÌÌÎÍÎÍÎÏÏÎÎÏ;
        public bool ÎÏÏÍÍÏÏÎÌÍÎÍÍÌÍÌÏÏÎÎÌÎÌ; // 0x10
        public System.Collections.Generic.List`1<string> ÌÌÏÏÌÍÎÎÌÎÎÎÍÌÌÌÏÏÎÏÍÏÌ; // 0x18
        public int ÍÍÎÏÌÎÍÎÍÍÎÏÍÍÍÏÏÏÌÌÍÎÎ; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E64C870
        public void .ctor(){} // RVA: 0x7FFD4E6DC4B0
        public void Initialize(){} // RVA: 0x7FFD4E6DC9C0
        public void op_Implicit(){} // RVA: 0x7FFD4E6DCC70
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E6DCFE0
        public void ReadByte(){} // RVA: 0x7FFD4E6DD0E0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E6DD0F0
        public void get_name(){} // RVA: 0x7FFD4E6DD9A0
        public void set_name(){} // RVA: 0x7FFD4E6DDC50
        public void Instantiate(){} // RVA: 0x7FFD4E6DDDC0
        public void GetHashCode_3CC01A28EBC0(){} // RVA: 0x7FFD4E6DE560 | overloaded x2
        public void OnPlayerLeft(){} // RVA: 0x7FFD4E6DE8D0
        public void ToString(){} // RVA: 0x7FFD4E6DE960
        public void Equals(){} // RVA: 0x7FFD4E64C870
        public void ReadByte_4684E94449A7(){} // RVA: 0x7FFD4E6DD0E0
        public void .cctor(){} // RVA: 0x7FFD4E6DEA70
        public void GetInstanceID_E3680B2F7442(){} // RVA: 0x7FFD4E6DEB70
    }

    /// <summary>Originally: ÎÎÌÍÏÌÍÎÍÎÍÍÌÌÎÍÏÎÍÎÎÎÍ</summary>
    public class PlayerLeft_6AD7 : Object
    {
        public string ÍÏÏÌÌÌÌÌÌÌÌÌÌÍÎÌÌÌÎÍÌÎÍ;
        public ÌÍÍÍÌÎÎÎÍÌÎÍÍÍÌÎÌÏÏÍÎÍÍ ÎÎÏÌÎÌÎÌÌÌÌÍÌÌÎÌÌÌÌÍÎÌÎ;

        // ── Methods ──
        public void OnPlayerLeft(){} // RVA: 0x7FFD4E587190
        public void Equals(){} // RVA: 0x7FFD4E5874F0
        public void GetHashCode(){} // RVA: 0x7FFD4E5880A0 | overloaded x4
        public void get_name_7DAAC6C7D31D(){} // RVA: 0x7FFD4E588300 | overloaded x2
        public void set_name(){} // RVA: 0x7FFD4E5886B0
        public void Instantiate(){} // RVA: 0x7FFD4E589AB0
        public void ToString(){} // RVA: 0x7FFD4E589F90
        public void GetHashCode_D55DB89F72AE(){} // RVA: 0x7FFD4E58A7F0
        public void GetInternalHashCode(){} // RVA: 0x7FFD4E58ACA0
        public void ResolveConstantValue(){} // RVA: 0x7FFD4E58B310
        public void op_Implicit(){} // RVA: 0x7FFD4E58B6F0
        public void ResolveConstantValue_829B1CEF78AB(){} // RVA: 0x7FFD4E58BE70
        public void ResolveConstantValue_10B992422EF7(){} // RVA: 0x7FFD4E58BFF0
        public void .cctor(){} // RVA: 0x7FFD4E58C170
    }

    /// <summary>Originally: ÌÎÏÍÎÎÌÎÏÍÏÎÍÎÍÌÌÌÌÎÎÍÏ</summary>
    public class PlayerManuallyRecordInteractionGetIsPlayingCon_5B6A : VRCPropApi
    {
        public ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ ÍÌÏÎÌÎÎÏÍÎÌÌÌÌÍÍÎÌÎÏÏÎÌ; // 0x10
        public UnityEngine.GameObject ÍÌÎÏÏÍÍÏÎÏÏÏÎÏÍÏÏÏÎÌÍÏÌ; // 0x18
        public UnityEngine.Transform ÎÍÌÍÎÍÍÍÍÌÌÏÎÍÎÏÎÎÍÏÍÎÌ; // 0x20
        public System.Collections.Generic.List`1<VRC.SDKBase.VRCPlayerApi> ÍÏÏÎÍÎÍÍÌÎÌÏÏÎÌÌÏÏÌÎÌÎÌ;
        public int ÏÎÌÏÏÎÎÏÌÏÏÍÏÎÌÍÌÌÌÎÎÎÏ;
        public int ÏÏÏÌÌÌÌÏÏÌÍÍÏÏÎÍÍÏÏÌÌÎÍ;
        public System.Lazy`1<string> ÌÎÌÎÍÌÏÌÌÌÎÎÍÌÎÎÏÌÌÏÌÍÌ; // 0x8

        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7FFD4E76F990
        public void GetPropId(){} // RVA: 0x7FFD4E76FD60
        public void GetRotation(){} // RVA: 0x7FFD4E76FDC0
        public void RequestDespawn(){} // RVA: 0x7FFD4E76FE40
        public void GetSpawner_7168835B028E(){} // RVA: 0x7FFD4E770030
        public void GetUserAttributes(){} // RVA: 0x7FFD4E7703D0
        public void .cctor(){} // RVA: 0x7FFD4E770530
        public void ReadComponentState(){} // RVA: 0x7FFD4E770770
        public void GetSpawner(){} // RVA: 0x7FFD4E770B10
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7FFD4E770C10
        public void GetItemId(){} // RVA: 0x7FFD4E770CB0
        public void GetScale(){} // RVA: 0x7FFD4E770D10
        public void GetQuantity(){} // RVA: 0x7FFD4E770DA0
        public void GetQuantity_5C4567B1F66E(){} // RVA: 0x7FFD4E770E30
        public void RequestConsume(){} // RVA: 0x7FFD4E7711D0
        public void GetPlayersInRange(){} // RVA: 0x7FFD4E7722B0 | overloaded x2
        public void StartPlayingConsumableEffect_BC7EF74D4DE1(){} // RVA: 0x7FFD4E771550
        public void StopPlayingConsumableEffect(){} // RVA: 0x7FFD4E771910
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7FFD4E771A90
        public void GetIsConsumable(){} // RVA: 0x7FFD4E771AB0
        public void SetUserAttributes_1CED01B56B9D(){} // RVA: 0x7FFD4E771B40
        public void CheckInteractionState(){} // RVA: 0x7FFD4E771EE0
        public void GetPosition(){} // RVA: 0x7FFD4E772320
        public void StartPlayingConsumableEffect(){} // RVA: 0x7FFD4E7723B0
        public void SetGameObjectActive(){} // RVA: 0x7FFD4E772530
        public void GetNearestPlayerInRange(){} // RVA: 0x7FFD4E772900
        public void .ctor(){} // RVA: 0x7FFD4E7729B0
        public void SetUserAttributes(){} // RVA: 0x7FFD4E772B60
    }

    /// <summary>Originally: ÍÏÌÎÌÎÏÎÍÏÌÎÍÏÌÏÎÎÍÍÌÏÍ</summary>
    public class PlayerModComponentHealthRelated_F88E
    {
        public object _f88E;

        // ── Methods ──
        public void InvokeDelegate(){} // RVA: 0x7FFD4E079D00
        public void BeginInvoke(){}
    }

    /// <summary>Originally: ÍÏÎÎÌÎÍÌÏÌÌÍÍÏÌÏÍÍÎÏÎÎÌ</summary>
    public class PlayerModComponentHealthSibling_B72C : Object
    {
        public string _name;
        public System.Action _hideFlags; // 0x10
        public ÍÍÍÏÍÏÎÍÌÏÍÌÏÏÎÎÍÏÌÌÌÏÌ f_527; // 0x18
        public ÍÍÌÌÌÌÏÍÏÍÍÏÏÍÏÎÏÏÎÍÎÌÍ f_E56; // 0x20
        public System.Collections.Generic.List`1<ÏÎÏÏÏÏÏÍÌÎÏÍÎÏÏÏÌÌÎÍÍÌÎ> f_9B5; // 0x28
        public System.Collections.Generic.List`1<ÏÎÏÏÏÏÏÍÌÎÏÍÎÏÏÏÌÌÎÍÍÌÎ> ÌÌÍÌÏÍÎÌÎÎÍÏÏÎÏÏÏÏÌÍÌÎÎ; // 0x30
        public float ÌÍÎÎÏÏÎÎÌÌÎÌÌÌÍÏÏÍÏÌÎÍÎ; // 0x38
        public float ÌÏÎÌÍÍÏÏÍÏÌÎÌÌÏÍÎÎÍÍÍÍÏ; // 0x3C
        public bool ÎÏÌÏÌÍÌÏÎÌÍÎÌÌÏÎÍÏÏÏÎÌÏ; // 0x40
        public string ÏÏÌÎÏÎÍÍÌÏÎÏÍÌÏÍÎÍÍÍÏÏÎ; // 0x48

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F066840
        public void Equals(){} // RVA: 0x7FFD4E36F0C0
        public void GetHashCode(){} // RVA: 0x7FFD4E36F0C0
        public void op_Implicit(){} // RVA: 0x7FFD4F066BA0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F066EF0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F067200
        public void Finalize(){} // RVA: 0x7FFD4F067430
        public void get_name(){} // RVA: 0x7FFD4E341320
        public void set_name(){} // RVA: 0x7FFD4F067580
        public void Instantiate(){} // RVA: 0x7FFD4F0677B0
        public void ToString(){} // RVA: 0x7FFD4F0678B0
        public void set_TypeId(){} // RVA: 0x7FFD4F067970
        public void GetMaxHealth(){} // RVA: 0x7FFD4F067A70
        public void OnCollisionStay(){} // RVA: 0x7FFD4F067CA0
        public void .ctor(){} // RVA: 0x7FFD4F067DC0
        public void Initialize(){} // RVA: 0x7FFD4F068090
        public void OnTriggerStay(){} // RVA: 0x7FFD4F068140
        public void SetXMotion(){} // RVA: 0x7FFD4F0681D0
        public void ReadTransformState(){} // RVA: 0x7FFD4E3447C0
        public void Destroy(){} // RVA: 0x7FFD4F068380
        public void SetupVisualDamage(){} // RVA: 0x7FFD4F0683D0
        public void DestroyImmediate(){} // RVA: 0x7FFD4F0684C0
        public void Pop(){} // RVA: 0x7FFD4F0686F0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F0699A0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void FindObjectsByType(){} // RVA: 0x7FFD4F069A00
        public void LateUpdate(){} // RVA: 0x7FFD4F069F00
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F06A490
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
    }

    /// <summary>Originally: ÌÍÌÌÍÌÍÍÍÍÌÍÏÌÏÎÌÎÍÎÎÌÌ</summary>
    public class PlayerNet : NetworkReadyHandler_68D0
    {
        public int _typeId;
        public int f_E94; // 0x4
        public ÍÏÏÏÎÍÌÍÍÍÏÏÍÏÎÎÍÌÏÍÌÏÎ f_DEA; // 0x58
        public ÎÏÌÏÍÌÎÌÏÌÎÍÍÏÏÍÍÌÌÌÌÏÌ f_BC1; // 0x60
        public ÎÏÌÏÌÍÎÍÏÍÏÏÎÏÌÍÏÎÏÎÍÍÍ f_DA7; // 0x68
        public ÏÍÏÌÌÍÍÏÌÍÎÌÎÍÍÌÍÍÍÏÏÍÏ f_45B; // 0x70
        public VRC.SDK3.Components.VRCPickup f_673; // 0x78
        public UnityEngine.TrailRenderer f_DD3; // 0x80
        public UnityEngine.GameObject f_C13; // 0x88
        public UnityEngine.Transform f_C0D; // 0x90
        public ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌÍÌÏ f_C75; // 0x98
        public UnityEngine.Collider f_5E4; // 0xA0
        public UnityEngine.Collider f_B9E; // 0xA8
        public UnityEngine.Collider[] f_427; // 0xB0
        public ÍÏÏÌÌÍÌÏÍÍÏÌÏÌÌÌÌÎÎÌÍÎÍ f_8C5; // 0xB8
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ f_665; // 0xC0
        public int f_4B7; // 0xC8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_A6A; // 0xD0
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_F8E; // 0xD8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_9DD; // 0xE0
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_14B; // 0xE8
        public UnityEngine.InputSystem.InputAction f_BE5; // 0xF0
        public UnityEngine.InputSystem.InputAction f_AC1; // 0xF8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_C9D; // 0x100
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_5EF; // 0x108
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_128; // 0x110
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_110; // 0x118
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_774; // 0x120
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ f_1A6; // 0x128
        public ÍÍÎÍÎÎÍÌÏÏÌÏÍÍÎÏÏÏÌÍÎÌÏ f_7C9; // 0x130
        public bool f_4BE; // 0x138
        public string f_7E0; // 0x140
        public bool f_F61; // 0x148
        public ÎÍÏÍÌÏÍÏÍÎÎÍÍÎÏÌÌÎÍÏÎÎÏ f_2CD; // 0x150
        public UnityEngine.GameObject f_8F8; // 0x158
        public 0x664CA488 f_C98; // 0x160
        public float f_E80; // 0x164
        public float f_CC2; // 0x168
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> f_96B; // 0x170

        // ── Methods ──
        public void OnTriggerExit(){} // RVA: 0x7FFD4EA5CF50
        public void Encode(){} // RVA: 0x7FFD4EA60510 | overloaded x2
        public void SetPlayerNetworkState(){} // RVA: 0x7FFD4EA5D040
        public void AddSubtraction(){} // RVA: 0x7FFD4EA5D060
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFD4E3AC600
        public void InvokeRepeating(){} // RVA: 0x7FFD4EA5D0A0
        public void OnEnable(){} // RVA: 0x7FFD4EA5D0C0
        public void ProcessNetworkData(){} // RVA: 0x7FFD4EA5D100
        public void ExecuteNetworkHandlerMethod(){} // RVA: 0x7FFD4EA5D170
        public void GetNetworkStatusZero(){} // RVA: 0x7FFD4EA5D1A0
        public void LateUpdate(){} // RVA: 0x7FFD4EA5D1F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EA5D220
        public void OnNetworkReady(){} // RVA: 0x7FFD4EA5D260
        public void StopCoroutine(){} // RVA: 0x7FFD4EA5D280
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EA5D2A0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EA5D2F0
        public void GetBufferedTimes(){} // RVA: 0x7FFD4EA5D350
        public void SetOverlay(){} // RVA: 0x7FFD4EA5D370
        public void print(){} // RVA: 0x7FFD4EA5D3B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EA5D3E0
        public void SetNetworkPlayerReference(){} // RVA: 0x7FFD4EA5D400
        public void DoCopyTexture_Region_957(){} // RVA: 0x7FFD4EA5D440
        public void get_MotionBlurCameras(){} // RVA: 0x7FFD4E96DFA0
        public void __set_hasTranslationDoF__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD4EA5D700
        public void get_alreadySelecting(){} // RVA: 0x7FFD4EA5D720
        public void ConfigureisTrigger(){} // RVA: 0x7FFD4EA5D730
        public void Updatevelocity_Inj(){} // RVA: 0x7FFD4EA5DA60
        public void SetNetworkPropertyIntO(){} // RVA: 0x7FFD4EA5DAA0
        public void SetNetworkPropertyIntY(){} // RVA: 0x7FFD4EA5DAE0
        public void Start_541DC43F0D78(){} // RVA: 0x7FFD4EA5DB00
        public void IsNetworkPropertyFlagSetR(){} // RVA: 0x7FFD4EA5DB50
        public void ProcessNetworkSynchronizationParameter(){} // RVA: 0x7FFD4EA5DB70
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFD4EA5DBF0
        public void SetXMotion(){} // RVA: 0x7FFD4E341320
        public void get_rootIMGUIContainer_B04BDEA92682(){} // RVA: 0x7FFD4EA5DD20
        public void SetClampedNetworkedFloat392(){} // RVA: 0x7FFD4EA5DD30
        public void SetNetworkPropertyIntY_3430C11FB386(){} // RVA: 0x7FFD4EA5DD80
        public void SetClampedNetworkedFloat392_4C66004C2F08(){} // RVA: 0x7FFD4EA5DE20
        public void GetPlayerNetworkFloat400(){} // RVA: 0x7FFD4EA5DE60
        public void SetPlayerNetworkFloatNormalized(){} // RVA: 0x7FFD4EA5DE80
        public void DecodeNetworkState(){} // RVA: 0x7FFD4EA5DEA0
        public void Equals(){} // RVA: 0x7FFD4EA5DEE0
        public void Decode(){} // RVA: 0x7FFD4EA60470 | overloaded x2
        public void OnDestroy(){} // RVA: 0x7FFD4EA5E060
        public void SetNetworkPropertyIntY_36F7AC284AC5(){} // RVA: 0x7FFD4EA5DAE0
        public void SetNetworkPropertyIntY_AC49F61ECE8E(){} // RVA: 0x7FFD4EA5E580
        public void set_onValueChanged(){} // RVA: 0x7FFD4EA5EB60
        public void get_selectHandler(){} // RVA: 0x7FFD4EA5EBA0
        public void set_enabled(){} // RVA: 0x7FFD4EA5F920
        public void SetEnabled(){} // RVA: 0x7FFD4EA5F960
        public void Awake(){} // RVA: 0x7FFD4EA5F9B0
        public void InitializeNetworkRuntime(){} // RVA: 0x7FFD4EA60060
        public void UpdateNetworkMaterial(){} // RVA: 0x7FFD4EA60080
        public void RefreshOverlayState(){} // RVA: 0x7FFD4EA600B0
        public void Updatemass(){} // RVA: 0x7FFD4EA600D0
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E426850
        public void DoInternal_FromEu(){} // RVA: 0x7FFD4EA600F0
        public void GetNetworkProperty296(){} // RVA: 0x7FFD4EA60100
        public void DoRandomRangeInt_A2E(){} // RVA: 0x7FFD4EA60120
        public void GetNetworkProperty296_91A6D99B1D21(){} // RVA: 0x7FFD4EA601B0
        public void GetPlayerNetworkFloat360(){} // RVA: 0x7FFD4EA60240
        public void PropertyToID(){} // RVA: 0x7FFD4EA60290
        public void get_verticalScrollbar(){} // RVA: 0x7FFD4EA603C0
        public void GetNetworkProperty408(){} // RVA: 0x7FFD4EA60410
        public void Computeenabled(){} // RVA: 0x7FFD4EA60430
        public void ComputeisDone(){} // RVA: 0x7FFD4EA604B0
        public void DoDestroy(){} // RVA: 0x7FFD4EA604F0
        public void Update(){} // RVA: 0x7FFD4EA60540
        public void GetGameObject(){} // RVA: 0x7FFD4EA60EE0
        public void GetPackedVectorComponent(){} // RVA: 0x7FFD4EA60F20
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFD4EA60F40
        public void ProxyNetworkFunctionCall(){} // RVA: 0x7FFD4EA60FA0
        public void SetClampedNetworkedFloat296(){} // RVA: 0x7FFD4EA60FC0
        public void SetClampedNetworkedFloat296_17AC35A2B23C(){} // RVA: 0x7FFD4EA613C0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA61410
        public void GetVideoHeight(){} // RVA: 0x7FFD4EA61480
        public void Computemass(){} // RVA: 0x7FFD4EA61490
        public void DoCreateInternalActionMapForSingletonAction(){} // RVA: 0x7FFD4EA614D0
        public void SerializedName(){} // RVA: 0x7FFD4EA614F0
        public void SetGlobalFloat(){} // RVA: 0x7FFD4EA61530
        public void GetSystem(){} // RVA: 0x7FFD4EA61550
        public void SetGlobalFloat_5519DB5EA3CF(){} // RVA: 0x7FFD4EA61570
        public void ApplyNetworkPacketData(){} // RVA: 0x7FFD4EA61590
        public void ApplyGlobalShaderParameters(){} // RVA: 0x7FFD4EA615E0
        public void Start(){} // RVA: 0x7FFD4EA616C0
        public void SetPrimaryShaderNetworkFloat(){} // RVA: 0x7FFD4EA61760
        public void SetPrimaryGlobalShaderFloat(){} // RVA: 0x7FFD4EA617B0
        public void get_gameObject(){} // RVA: 0x7FFD4E7DD180
        public void GetNetworkProperty372(){} // RVA: 0x7FFD4EA617D0
        public void SetSecondaryGlobalShaderFloat(){} // RVA: 0x7FFD4EA617F0
        public void GetVideoHeight_7A8CA4A0E177(){} // RVA: 0x7FFD4EA61820
        public void OnEnable_38F7D5376544(){} // RVA: 0x7FFD4EA61850
        public void OnDisable(){} // RVA: 0x7FFD4EA61870
        public void CallNetworkInternalFunctionBAC0(){} // RVA: 0x7FFD4EA619F0
        public void GetNetworkProperty288(){} // RVA: 0x7FFD4EA61A10
        public void GetNetworkProperty288_8E32E7E16467(){} // RVA: 0x7FFD4EA61A30
        public void OnDisable_C71B19A11DC7(){} // RVA: 0x7FFD4EA61A70
        public void GetNetworkProperty396(){} // RVA: 0x7FFD4EA61A90
        public void GetNetworkProperty384(){} // RVA: 0x7FFD4EA61B20
        public void ComputegameObject(){} // RVA: 0x7FFD4EA61B40
        public void Initialize(){} // RVA: 0x7FFD4EA61B80
        public void CalculateInterpolation(){} // RVA: 0x7FFD4EA61BA0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4EA61BE0
        public void ComputegameObject_2B95CB32D066(){} // RVA: 0x7FFD4EA61CA0
        public void Initialize_4204C19DC87E(){} // RVA: 0x7FFD4EA61CE0
        public void set_TypeId(){} // RVA: 0x7FFD4EA61D20
        public void Start_DA72FF1B51BC(){} // RVA: 0x7FFD4EA61D60
        public void IsNetworkReady(){} // RVA: 0x7FFD4EA61D80
        public void GetNetworkSynchronizationEnabled(){} // RVA: 0x7FFD4EA61DA0
        public void get_TypeId(){} // RVA: 0x7FFD4EA61DE0
        public void get_CustomBones(){} // RVA: 0x7FFD4EA61DF0
        public void Update_540CB71AC481(){} // RVA: 0x7FFD4E55BE20
        public void OnValidate(){} // RVA: 0x7FFD4EA61E20
        public void GetNetworkProperty368(){} // RVA: 0x7FFD4EA62230
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void StopCoroutine_CD63C7FB91AB(){} // RVA: 0x7FFD4EA62270
        public void GetNetworkProperty368_ADBFE85B19A9(){} // RVA: 0x7FFD4EA62370
        public void set_popularity(){} // RVA: 0x7FFD4EA62540
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E341320
        public void ProcessPlayerNetworkData(){} // RVA: 0x7FFD4EA62550
        public void CallNetworkInternalFunctionA50(){} // RVA: 0x7FFD4EA62590
        public void ProcessNetworkSynchronizationParameter_F244784C1078(){} // RVA: 0x7FFD4EA5DB70
        public void GetConstantValue1000(){} // RVA: 0x7FFD4EA5D040
        public void GetPlayerNetworkFloat356(){} // RVA: 0x7FFD4EA625E0
        public void SetNetworkSynchronizationEnabled(){} // RVA: 0x7FFD4EA62620
        public void NeedsSync(){} // RVA: 0x7FFD4E426850
        public void GetNetworkProperty304(){} // RVA: 0x7FFD4EA62640
        public void SetNetworkSynchronizationEnabled_639BEBBAFF79(){} // RVA: 0x7FFD4EA62660
        public void SetNetworkSynchronizationEnabled_A2646E8CF0FF(){} // RVA: 0x7FFD4EA62680
        public void SetNetworkSynchronizationEnabled_6D4310D1E11F(){} // RVA: 0x7FFD4EA626A0
        public void ComputegameObject_13220067BB8A(){} // RVA: 0x7FFD4EA62710
        public void SetNetworkSynchronizationEnabled_61A7912C1F54(){} // RVA: 0x7FFD4EA62730
        public void .ctor(){} // RVA: 0x7FFD4EA627A0
        public void ProcessNetworkMessages(){} // RVA: 0x7FFD4EA628C0
        public void get_UploadLength(){} // RVA: 0x7FFD4E3AC5F0
        public void .cctor(){} // RVA: 0x7FFD4EA62970
        public void get_popularity(){} // RVA: 0x7FFD4EA62A70
        public void GetPlayerNetworkFloat400_378366EB1406(){} // RVA: 0x7FFD4EA62A70
        public void GetPlayerNetworkFloat400_296FC4EEAE2A(){} // RVA: 0x7FFD4EA62A80
        public void SetPlayerNetworkFloatNormalized_C35C45D009FA(){} // RVA: 0x7FFD4EA62AA0
        public void UpdateActive(){} // RVA: 0x7FFD4EA62AE0
        public void SetPlayerNetworkByte428(){} // RVA: 0x7FFD4EA62B20
        public void get_onPressed(){} // RVA: 0x7FFD4E3AC120
        public void InitializeDefaults(){} // RVA: 0x7FFD4EA62B40
    }

    /// <summary>Originally: ÏÎÍÌÍÎÌÌÎÎÍÌÎÍÏÎÍÌÏÌÍÎÏ</summary>
    public class PlayerNetSibling_733B : Object
    {
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA430> _name; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA430> _hideFlags; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA488> f_2CD; // 0x20
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_8F8; // 0x28
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_C98; // 0x30
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA4E0> f_172; // 0x38
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA4E0> f_E80; // 0x40
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_0C0; // 0x48
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_96B; // 0x50
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_929; // 0x58
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_09B; // 0x60
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_DEE; // 0x68
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_BBA; // 0x70
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_F8C; // 0x78
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_A27; // 0x80
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_8B0; // 0x88
        public ÎÍÎÏÍÍÌÍÍÍÎÍÏÌÌÏÌÎÎÏÍÍÏ f_557; // 0x90
        public ÎÍÎÏÍÍÌÍÍÍÎÍÏÌÌÏÌÎÎÏÍÍÏ ÍÏÏÏÎÌÏÎÎÎÌÎÍÏÌÎÎÌÏÎÏÌÌ; // 0x98

        // ── Methods ──
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void Equals(){} // RVA: 0x7FFD4EA64CA0
        public void GetHashCode(){} // RVA: 0x7FFD4EA64CD0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EA64CF0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void GetCachedPtr(){} // RVA: 0x7FFD4EA64D10
        public void get_name(){} // RVA: 0x7FFD4EA64D30
        public void set_name(){} // RVA: 0x7FFD4E3447C0
        public void Instantiate(){} // RVA: 0x7FFD4E35C380
        public void ToString(){} // RVA: 0x7FFD4EA64D50
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EA64D80
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void StopCoroutine(){} // RVA: 0x7FFD4EA64DB0
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EA64DE0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EA64E00
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E36F0C0
        public void SetOverlay(){} // RVA: 0x7FFD4EA64E30
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void Destroy(){} // RVA: 0x7FFD4EA64E70
        public void UpdateGeometry(){} // RVA: 0x7FFD4EA64EB0
        public void DestroyImmediate(){} // RVA: 0x7FFD4EA64EE0
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void FindObjectsOfType(){} // RVA: 0x7FFD4EA64F00
        public void FindObjectsByType(){} // RVA: 0x7FFD4EA64F30
        public void Updatevelocity_Inj(){} // RVA: 0x7FFD4EA64F50
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EA652A0
        public void get_hideFlags(){} // RVA: 0x7FFD4EA652C0
        public void set_hideFlags(){} // RVA: 0x7FFD4EA653C0
        public void Equals_A39209201B01(){} // RVA: 0x7FFD4EA653F0
        public void FindObjectOfType(){} // RVA: 0x7FFD4EA65420
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4EA65440
        public void GetAnimationClipLength(){} // RVA: 0x7FFD4EA65DB0
        public void CheckNullArgument(){} // RVA: 0x7FFD4EA65DD0
        public void SetClampedNetworkedFloat392(){} // RVA: 0x7FFD4EA65E00
        public void SyncPlayerNetwork(){} // RVA: 0x7FFD4EA65E30
        public void HandlePlayerDisconnect(){} // RVA: 0x7FFD4EA65F30
        public void .ctor(){} // RVA: 0x7FFD4EA65F50
        public void Initialize(){} // RVA: 0x7FFD4EA67120
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void op_Inequality(){} // RVA: 0x7FFD4EA67150
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4E3BE740
        public void Internal_CloneSingle(){} // RVA: 0x7FFD4E3BC730
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4EA67180
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFD4EA671A0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFD4EA671C0
        public void SetStateMachine(){} // RVA: 0x7FFD4EA671E0
        public void InitializePlayerNet(){} // RVA: 0x7FFD4EA67B50
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD4EA67B80
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void MatchesCachedString(){} // RVA: 0x7FFD4EA67BB0
        public void RefreshOverlayState(){} // RVA: 0x7FFD4EA67BE0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFD4EA68150
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFD4EA671A0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void GetNetworkProperty296(){} // RVA: 0x7FFD4EA68170
        public void DoRandomRangeInt_A2E(){} // RVA: 0x7FFD4EA681A0
    }

    /// <summary>Originally: ÌÍÎÎÎÏÏÏÏÌÎÌÌÎÌÏÏÏÎÌÎÎÎ</summary>
    public class PlayerNetSibling_DAA5 : Object
    {
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> _name; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> _hideFlags; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x664CA3D8> f_2EC; // 0x20
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_427; // 0x28
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_8C5; // 0x30
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_665; // 0x38
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_4B7; // 0x40
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_A6A; // 0x48
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_F8E; // 0x50
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_9DD; // 0x58
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_14B; // 0x60
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_BE5; // 0x68
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_AC1; // 0x70
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_C9D; // 0x78
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_5EF; // 0x80
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_128; // 0x88
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_110; // 0x90
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_774; // 0x98
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_F4E; // 0xA0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_3AA; // 0xA8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_78D; // 0xB0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_FD9; // 0xB8
        public 0x664CA3D8 f_557; // 0xC0
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÌÌÎÎÌÌÏÏÌÍÌÌÌÏÏÏÍÏÌÎÍÍÍ; // 0xC8
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÏÌÎÌÍÌÍÍÍÍÌÍÎÏÎÎÏÎÎÌÌÌÏ; // 0xD0
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÍÌÍÎÎÏÎÍÎÏÍÌÌÎÏÏÏÎÏÎÍÌÏ; // 0xD8
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÍÌÍÏÍÌÌÏÎÍÏÏÏÏÎÍÎÎÍÍÌÎÍ; // 0xE0
        public System.Collections.Generic.Dictionary`2<int,ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ> ÍÍÍÎÏÍÌÎÎÎÎÏÏÍÎÌÎÏÏÍÌÌÌ; // 0xE8

        // ── Methods ──
        public void get_taglineText(){} // RVA: 0x7FFD4E96B1A0
        public void Equals(){} // RVA: 0x7FFD4EA7B890
        public void GetHashCode(){} // RVA: 0x7FFD4EA7B920
        public void op_Implicit(){} // RVA: 0x7FFD4EA7B960
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EA7BB20
        public void GetCachedPtr(){} // RVA: 0x7FFD4EA7BBB0
        public void get_name(){} // RVA: 0x7FFD4EA7BD70
        public void set_name(){} // RVA: 0x7FFD4EA7BE00
        public void Instantiate(){} // RVA: 0x7FFD4EA7BE90
        public void ToString(){} // RVA: 0x7FFD4EA7C050
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EA7C0E0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void StopCoroutine(){} // RVA: 0x7FFD4EA7C2A0
        public void GetIKSolver_ADDE6B72844A(){} // RVA: 0x7FFD4E3BC730
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EA7C330
        public void .ctor(){} // RVA: 0x7FFD4EA7C3C0
        public void Initialize(){} // RVA: 0x7FFD4EA7DF00
        public void print(){} // RVA: 0x7FFD4EA7DF90
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void Destroy(){} // RVA: 0x7FFD4EA7E020
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void FindObjectsByType(){} // RVA: 0x7FFD4EA7E0B0
        public void Updatevelocity_Inj(){} // RVA: 0x7FFD4EA7E4B0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EA7E660
        public void get_hideFlags(){} // RVA: 0x7FFD4EA7E820
        public void set_hideFlags(){} // RVA: 0x7FFD4EA7E9E0
        public void IsNetworkPropertyFlagSetR(){} // RVA: 0x7FFD4EA7EA70
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void DoInternal_FromEu(){} // RVA: 0x7FFD4EA7EC30
        public void FindObjectOfType(){} // RVA: 0x7FFD4E36F0C0
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4EA7F760
        public void DoLookRotation_In(){} // RVA: 0x7FFD4EA7F7F0
        public void GetPlayerNetworkFloat400(){} // RVA: 0x7FFD4EA7F9B0
        public void GetRect(){} // RVA: 0x7FFD4EA7FB70
        public void op_Equality(){} // RVA: 0x7FFD4EA7FC00
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4EA7FDC0
        public void Internal_CloneSingle(){} // RVA: 0x7FFD4EA7FE50
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4E3447C0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFD4E35C380
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFD4EA7FEE0
        public void get_selectHandler(){} // RVA: 0x7FFD4EA7FF70
        public void get_version(){} // RVA: 0x7FFD4E3AC040
        public void get_cageDownsample(){} // RVA: 0x7FFD4E55B720
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD4EA80000
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFD4E5F95E0
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFD4EA801C0
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void DoInternal_FromEu_C761435AD75E(){} // RVA: 0x7FFD4EA80380
        public void GetNetworkProperty296(){} // RVA: 0x7FFD4EA80410
        public void ReportGeneralErrors(){} // RVA: 0x7FFD4EA80670
        public void GetNetworkProperty296_B040FA321306(){} // RVA: 0x7FFD4EA80700
        public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
        public void Instantiate_917EF0D3DB34(){} // RVA: 0x7FFD4EA808C0
        public void get_verticalScrollbar(){} // RVA: 0x7FFD4EA80950
        public void GetNetworkProperty408(){} // RVA: 0x7FFD4EA80B10
        public void GetTextTracks_BFB661E3642E(){} // RVA: 0x7FFD4E96DFB0
        public void Decode(){} // RVA: 0x7FFD4EA80CD0
        public void ComputeisDone(){} // RVA: 0x7FFD4EA80E90
        public void DoDestroy(){} // RVA: 0x7FFD4EA81050
        public void Encode(){} // RVA: 0x7FFD4EA81210
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void GetObjectComponentValueConditional(){} // RVA: 0x7FFD4EA813D0
        public void IsInvoking(){} // RVA: 0x7FFD4EA81590
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFD4EA81750
    }

    /// <summary>Originally: ÍÏÍÏÌÍÎÏÏÌÌÏÎÌÌÍÏÎÌÎÍÎÎ</summary>
    public class PlayerNetSibling_FDD3
    {
        public int f_C13;
        public System.Collections.Generic.KeyValuePair`2<string,object> f_673;
        public LogValues`3<U,V,T> f_C0D;
        public int f_DD3;

        // ── Methods ──
        public void OnTriggerExit(){} // RVA: 0x7FFD4E0788A0
        public void Encode(){} // RVA: 0x7FFD4E078E90
        public void SetPlayerNetworkState(){} // RVA: 0x7FFD4E078E90
        public void AddSubtraction(){} // RVA: 0x7FFD4E078E90
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÍÍÏÏÏÏÎÏÍÎÌÏÎÎÍÎÏÍÌÏÎÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmoji_1804
    {
        public string _isAnimated;
        public string _isPremium;

        // ── Methods ──
        public void get_IsAnimated(){} // RVA: 0x7FFD4E079D00
        public void get_IsPremium(){} // RVA: 0x7FFD4E079D00
        public void get_LoadFrom(){} // RVA: 0x7FFD4E079960
        public void get_Frames(){} // RVA: 0x7FFD4E079960
        public void get_FPS(){} // RVA: 0x7FFD4E079960
        public void get_LoopStyle(){} // RVA: 0x7FFD4E078E90
        public void set_LoopStyle(){} // RVA: 0x7FFD4E090A40
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFD4E078E90
        public void get_DisplayTexture(){} // RVA: 0x7FFD4E078E90
        public void get_FullResolutionTexture(){} // RVA: 0x7FFD4E078E90
        public void get_Sprite(){} // RVA: 0x7FFD4E078E90
        public void get_MaskTag(){} // RVA: 0x7FFD4E078E90
        public void get_AnimationStyle(){} // RVA: 0x7FFD4E078E90
        public void set_AnimationStyle(){} // RVA: 0x7FFD4E090A40
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFD4E079D00
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFD4E091060
        public void get_FileId(){} // RVA: 0x7FFD4E078E90
        public void get_IsBuiltIn(){} // RVA: 0x7FFD4E079D00
    }

    /// <summary>Originally: ÍÏÎÏÎÌÎÏÎÎÍÏÎÍÎÏÏÏÍÍÎÎÍ</summary>
    public class PlayerOwnerCanUseAnimatedEmoji_8041 : AnimatedTextureBase_F53F
    {
        public bool _ownerCanUseAnimatedEmoji; // 0x20
        public string _isSpecialFX; // 0x28
        public UnityEngine.Material _loopStyle; // 0x30
        public 0x664D6400 _fPS; // 0x38
        public string _frames;
        public VRC.Profiling.ProfilerMarker _effectBundleID; // 0x40
        public VRC.Profiling.ProfilerMarker _spawnablePrefabName; // 0x50
        public ÌÏÌÏÏÌÌÍÎÍÍÎÌÎÎÎÌÌÌÏÍÏÍ _animationStyle; // 0x60
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> _fullResolutionTexture; // 0x68
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> _loadFrom; // 0x70
        public int _fileId;

        // ── Methods ──
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFD4E42F9D0
        public void set_body(){} // RVA: 0x7FFD4E4095A0
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E42F9E0
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void get_IsSpecialFX(){} // RVA: 0x7FFD4E92BEA0
        public void set_LoopStyle(){} // RVA: 0x7FFD4FAD47E0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void get_FPS(){} // RVA: 0x7FFD4E992BD0
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void set_EffectBundleID(){} // RVA: 0x7FFD4FAD4850
        public void set_Frames(){} // RVA: 0x7FFD4E4095A0
        public void get_Frames(){} // RVA: 0x7FFD4FAD48A0
        public void get_EffectBundleID(){} // RVA: 0x7FFD4E8CEA10
        public void set_SpawnablePrefabName(){} // RVA: 0x7FFD4E42F9E0
        public void set_FullResolutionTexture(){} // RVA: 0x7FFD4E5F95E0
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFD4E36F130
        public void set_AnimationStyle(){} // RVA: 0x7FFD4E8DE690
        public void set_trackerAnchor(){} // RVA: 0x7FFD4E3DF380
        public void get_FullResolutionTexture(){} // RVA: 0x7FFD4E409590
        public void get_LoadFrom(){} // RVA: 0x7FFD4FAD48C0
        public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
        public void .ctor(){} // RVA: 0x7FFD4FAD48F0
        public void get_LoopStyle(){} // RVA: 0x7FFD4FAD4A80
        public void set_DisplayTexture(){} // RVA: 0x7FFD4FAD4AE0
        public void set_FileId(){} // RVA: 0x7FFD4FAD4BA0
        public void get_FileId(){} // RVA: 0x7FFD4E8CE880
        public void get_DisplayTexture(){} // RVA: 0x7FFD4E3BCD50
        public void set_Sprite(){} // RVA: 0x7FFD4E3DF380
        public void get_AnimationStyle(){} // RVA: 0x7FFD4E8CEA50
        public void get_IsBuiltIn(){} // RVA: 0x7FFD4E341320
        public void get_IsPremium(){} // RVA: 0x7FFD4FAD5300
        public void get_Sprite(){} // RVA: 0x7FFD4E919180
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void get_IsAnimated(){} // RVA: 0x7FFD4FAD5320
        public void get_MaskTag(){} // RVA: 0x7FFD4E8CE8C0
        public void set_MaskTag(){} // RVA: 0x7FFD4FAD5340
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFD4E42F9E0
        public void set_IsAnimated(){} // RVA: 0x7FFD4FAD5370
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
    }

    /// <summary>Originally: ÎÍÌÏÌÎÏÎÎÍÎÏÏÏÎÎÎÍÎÎÏÎÎ</summary>
    public class PlayerRectTransformDimensionsCSibling_A401
    {
        public U f_30C;
        public T f_E95;
        public object f_78C;

        // ── Methods ──
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_52D3FA58E3AC(){} // RVA: 0x7FFD4E090A40
        public void GetRange_43306D7A9C3D(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void UpdatePlayerRectLayout(){} // RVA: 0x7FFD4E078E90
        public void ValidatePlayerRectLayout(){} // RVA: 0x7FFD4E078E90
        public void RefreshPlayerRectLayout(){} // RVA: 0x7FFD4E078E90
        public void MeasurePlayerRectLayout(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÌÏÌÏÌÍÎÌÎÎÎÌÍÏÎÍÏÎÌÏÍÌÌ</summary>
    public class PlayerRectTransformDimensionsChCalculateLayout_4181 : PointerEnterPointerExit_D99E
    {
        public System.Action`1<UnityEngine.Vector2> f_A8C; // 0xB0
        public UnityEngine.RectTransform f_E95; // 0xB8
        public UnityEngine.GameObject f_35B; // 0xC0
        public UnityEngine.Vector2 f_E5E; // 0xC8
        public bool f_2DC; // 0xD0
        public bool f_6E4; // 0xD1
        public VRC.UI.Core.Styles.StyleEngine f_F8B; // 0xD8
        public UnityEngine.Vector2 f_93D; // 0xE0
        public ÏÎÎÏÌÏÏÏÍÎÏÌÍÎÎÍÏÎÎÏÍÏÍ f_FB2; // 0xE8
        public System.Collections.Generic.List`1<System.ValueTuple`2<object,int>> f_648; // 0xF0
        public System.Collections.Generic.List`1<System.ValueTuple`5<int,ÌÏÍÎÌÎÌÎÏÌÏÎÏÎÌÎÍÎÏÎÌÏÌ,int,UnityEngine.Rect,bool>> f_703; // 0xF8
        public System.Collections.Generic.List`1<System.ValueTuple`2<object,int>> f_950; // 0x100
        public System.Collections.Generic.List`1<System.ValueTuple`5<int,ÌÏÍÎÌÎÌÎÏÌÏÎÏÎÌÎÍÎÏÎÌÏÌ,int,UnityEngine.Rect,bool>> f_0CF; // 0x108
        public 0x665D8FC8 f_4A4; // 0x110
        public System.Collections.Generic.List`1<UnityEngine.Rect> f_E5D; // 0x118
        public System.Collections.Generic.List`1<object> f_996; // 0x120
        public System.Collections.Generic.List`1<ÌÏÍÎÌÎÌÎÏÌÏÎÏÎÌÎÍÎÏÎÌÏÌ> f_195; // 0x128
        public 0x665D97B0 f_E80; // 0x130
        public int f_17C;
        public DG.Tweening.Tweener f_56D; // 0x138
        public UnityEngine.Vector2 f_BFF; // 0x140
        public 0x665D9910 f_367; // 0x148
        public UnityEngine.Vector2 f_D1E; // 0x14C
        public UnityEngine.Vector2 f_B43; // 0x154
        public bool f_DCC; // 0x15C
        public UnityEngine.Vector2 f_E1F; // 0x160
        public bool f_D70; // 0x168
        public UnityEngine.UI.ScrollRect f_E05; // 0x170
        public UnityEngine.UI.Scrollbar ÎÌÌÏÌÎÎÏÌÌÌÌÎÏÎÌÍÌÎÏÍÍÎ; // 0x178
        public UnityEngine.UI.Scrollbar ÍÌÎÏÍÎÏÎÌÏÏÎÎÌÏÏÍÎÏÏÌÌÏ; // 0x180
        public bool _showScrollbars; // 0x188
        public bool ÎÎÏÌÎÌÌÍÌÎÏÌÌÌÏÎÍÌÍÌÏÍÌ; // 0x189
        public bool _cullingEnabled; // 0x18A
        public UnityEngine.Vector2 _additionalCullingRange; // 0x18C
        public UnityEngine.Vector2 _spacing; // 0x194
        public VRC.UI.Voyager.Controls.LayoutPadding _padding; // 0x19C
        public 0x665D9B20 _xAlign; // 0x1AC
        public 0x665D9B20 _yAlign; // 0x1B0
        public 0x665D9C28 _fillX; // 0x1B4
        public 0x665D9C28 _fillY; // 0x1B8
        public UnityEngine.Vector2 _gridCellSize; // 0x1BC
        public 0x665D9B78 _gridStartAxis; // 0x1C4
        public 0x665D9BD0 _gridConstraint; // 0x1C8
        public int _gridConstraintCount; // 0x1CC
        public bool _gridAlignAlignLastRowOrCol; // 0x1D0
        public System.Collections.Generic.List`1<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ> ÏÌÏÍÍÌÎÌÏÎÏÍÎÏÎÌÌÎÎÍÏÍÏ; // 0x1D8

        // ── Methods ──
        public void Awake_8424C29D0677(){} // RVA: 0x7FFD56E2B390
        public void get_gameObject(){} // RVA: 0x7FFD56E2B410
        public void InitializeRectTransformDefaults(){} // RVA: 0x7FFD56E2B430
        public void .ctor(){} // RVA: 0x7FFD56E2B4B0
        public void get_tilt(){} // RVA: 0x7FFD5509AAD0
        public void SetLineWidth(){} // RVA: 0x7FFD56E2BA40
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD56E2DC00
        public void FixedUpdate(){} // RVA: 0x7FFD56E2DC90
        public void GetLanguage(){} // RVA: 0x7FFD56E2DCA0
        public void NeedsSync(){} // RVA: 0x7FFD56E2DCB0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFD56E2DCC0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD56E2DCD0
        public void get_childScaleHeight(){} // RVA: 0x7FFD56E2DD00
        public void OnBecameInvisible(){} // RVA: 0x7FFD56E2DD10
        public void SetOverlay(){} // RVA: 0x7FFD56E2DDF0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void OnCollisionExit(){} // RVA: 0x7FFD56E2DE40
        public void SetLayoutHorizontal(){} // RVA: 0x7FFD56E2DEC0
        public void Initialize(){} // RVA: 0x7FFD56E2DF50
        public void get_SubmitButtonText(){} // RVA: 0x7FFD56E2E410
        public void GetDataCount(){} // RVA: 0x7FFD56E2E540
        public void OnPointerEnter(){} // RVA: 0x7FFD56E2E560
        public void Awake(){} // RVA: 0x7FFD56E2E570
        public void OnDestroy(){} // RVA: 0x7FFD56E2E8E0
        public void FindServiceEntry(){} // RVA: 0x7FFD56E2E980
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void FindObjectsOfType(){} // RVA: 0x7FFD56E2EB60
        public void CalculateLayoutInputHorizontal_F36096ED6158(){} // RVA: 0x7FFD56E2ED20
        public void SetLayoutVertical(){} // RVA: 0x7FFD56E2ED40
        public void CalculateLayoutInputVertical_8C534F3906BA(){} // RVA: 0x7FFD56E2EDD0
        public void SetLayoutHorizontal_BE12F5AA1BA8(){} // RVA: 0x7FFD56E2EDF0
        public void SetCurrentLayoutGroup(){} // RVA: 0x7FFD56E2EEA0
        public void SetLayoutVertical_0E3841A86732(){} // RVA: 0x7FFD56E2EEF0
        public void EnsureLayoutStatics(){} // RVA: 0x7FFD56E2EF40
        public void Update_824906DA6492(){} // RVA: 0x7FFD56E2EF50
        public void FoldMaskRowsIntoBuckets(){} // RVA: 0x7FFD56E2F050
        public void Update(){} // RVA: 0x7FFD56E2F0F0
        public void get_StackTiliaFee(){} // RVA: 0x7FFD56E2F460
        public void get_button(){} // RVA: 0x7FFD4F4B0620
        public void get_StackTiliaFee_4DC0908E165A(){} // RVA: 0x7FFD56E2F470
        public void get_StackTiliaFee_0E42D4B2EA1A(){} // RVA: 0x7FFD56E2F490
        public void Awake_3A91C5CE4359(){} // RVA: 0x7FFD56E2F4A0
        public void ContainsTrackedLayout(){} // RVA: 0x7FFD56E2DCB0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.UI.ILayoutElement.get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void set_ConnectTimeout(){} // RVA: 0x7FFD56D990D0
        public void GetLayoutFlag392(){} // RVA: 0x7FFD54068980
        public void FindFirstObjectByType(){} // RVA: 0x7FFD56E2F540
        public void LateUpdate(){} // RVA: 0x7FFD56E2F690
        public void LateUpdate_B3BB2C7CF0C4(){} // RVA: 0x7FFD56E2F7C0
        public void get_VoidedByAdmin(){} // RVA: 0x7FFD567C45C0
        public void Awake_B54CF9D6994E(){} // RVA: 0x7FFD56E2F7E0
        public void Start(){} // RVA: 0x7FFD56E2FA70
        public void AccumulateBucketWindow(){} // RVA: 0x7FFD56E2FB10
        public void IncrementOverflowBucket(){} // RVA: 0x7FFD56E2FB30
        public void CopyTo_43306D(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetLayoutFlag394(){} // RVA: 0x7FFD54068A00
        public void IndexOfBucketValue(){} // RVA: 0x7FFD56E2FBD0
        public void UnityEngine.UI.ILayoutElement.get_preferredWidth(){} // RVA: 0x7FFD56E2FC70
        public void UpdateActive(){} // RVA: 0x7FFD56E2FCA0
        public void ComputeLayoutHash(){} // RVA: 0x7FFD56E2FCB0
        public void ProcessLayoutElements(){} // RVA: 0x7FFD56E2FDE0
        public void PropagateCarryIntoBuckets(){} // RVA: 0x7FFD56E2FE30
        public void AccumulateHashTriple(){} // RVA: 0x7FFD56E2FED0
        public void PropagateOverflowBuckets(){} // RVA: 0x7FFD56E2FF30
        public void GetHashCode(){} // RVA: 0x7FFD56E30030
        public void CreateUpdatedActiveLayout(){} // RVA: 0x7FFD56E30080
        public void OnRectTransformDimensionsChange_3FCA5780B89F(){} // RVA: 0x7FFD56E30120
        public void ValidatePlayerRectLayout(){} // RVA: 0x7FFD56E30130
        public void UnityEngine.UI.ILayoutElement.get_flexibleWidth(){} // RVA: 0x7FFD4EB632E0
        public void OnEnable(){} // RVA: 0x7FFD56E30220
        public void DecrementTrailingBuckets(){} // RVA: 0x7FFD56E30230
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD56E30120
        public void UpdatePointerExitState(){} // RVA: 0x7FFD56E30250
        public void SetupScrollbarThumb(){} // RVA: 0x7FFD56E302B0
        public void SetupScrollbarThumb_65A6CA553D3A(){} // RVA: 0x7FFD56E30310
        public void get_enableVertexGradient(){} // RVA: 0x7FFD4F42F720
        public void SetupScrollbarThumb_F767AD0F8442(){} // RVA: 0x7FFD56E30330
        public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
        public void UnityEngine.UI.ILayoutElement.get_preferredHeight(){} // RVA: 0x7FFD56E30360
        public void SetupScrollbarThumb_40A20D68E8A7(){} // RVA: 0x7FFD56E30390
        public void IsBucketVectorAtLeastReference(){} // RVA: 0x7FFD56E30CD0
        public void IsAtLeastCurrentBucketBaseline(){} // RVA: 0x7FFD56E30CF0
        public void CompareBucketsDescending(){} // RVA: 0x7FFD56E30D10
        public void get_characterLimit(){} // RVA: 0x7FFD54B75950
        public void UnityEngine.UI.ILayoutElement.get_flexibleHeight(){} // RVA: 0x7FFD4EB632E0
        public void ApplyDisplayConfiguration(){} // RVA: 0x7FFD56E31120
        public void OnDisable(){} // RVA: 0x7FFD56E31360
        public void UpdatePlayerRectLayout(){} // RVA: 0x7FFD56E31560
        public void TrySetMarkBit(){} // RVA: 0x7FFD56E31760
        public void OnTriggerStay(){} // RVA: 0x7FFD567C45C0
        public void RefreshPlayerRectLayout(){} // RVA: 0x7FFD4E078E90
        public void MeasurePlayerRectLayout(){} // RVA: 0x7FFD56E31810
        public void OnRectTransformDimensionsChange_1C21E1462E03(){} // RVA: 0x7FFD56E31A10
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD56E31AB0
        public void IsDestroyed(){} // RVA: 0x7FFD56E30220
        public void CalculatePlayerRectLayout(){} // RVA: 0x7FFD56E31B30
        public void UnityEngine.UI.ILayoutElement.get_minWidth(){} // RVA: 0x7FFD4EB632E0
        public void GetLayoutPreferredWidth(){} // RVA: 0x7FFD56E31BA0
        public void GetLayoutPreferredHeight(){} // RVA: 0x7FFD56E31BD0
        public void GetLayoutFlexibleWidth(){} // RVA: 0x7FFD56E31BF0
        public void GetLayoutFlexibleHeight(){} // RVA: 0x7FFD56E31C70
        public void GetLayoutMinWidth(){} // RVA: 0x7FFD56E31E70
        public void UnityEngine.UI.ILayoutElement.get_layoutPriority(){} // RVA: 0x7FFD4E919180
        public void SecureStringToBSTR(){} // RVA: 0x7FFD56E31FD0
        public void SecureStringToBSTR_60893B6C6EA6(){} // RVA: 0x7FFD56E31FF0
        public void SecureStringToBSTR_EED716EF6157(){} // RVA: 0x7FFD56E32010
        public void GetLayoutMinHeight(){} // RVA: 0x7FFD56E2F7C0
        public void SecureStringToBSTR_D5A6022CE91C(){} // RVA: 0x7FFD56E32060
        public void SecureStringToBSTR_1738B1458D11(){} // RVA: 0x7FFD56E32080
        public void SecureStringToBSTR_709F1B600691(){} // RVA: 0x7FFD56E320A0
    }

    /// <summary>Originally: ÏÎÎÌÎÏÏÌÎÌÎÎÌÎÌÍÍÍÌÎÌÎÌ</summary>
    public class PlayerReleaseHandle_25C7 : SafeHandleZeroOrMinusOneIsInvalid
    {
        public float ÌÍÌÌÎÎÍÍÌÍÎÍÍÏÌÍÏÍÍÌÌÌÏ;
        public float ÏÍÍÌÌÍÌÍÏÍÏÍÎÎÍÎÌÍÎÌÏÏÌ;
        public string ÎÏÎÏÎÏÌÍÏÍÍÍÎÌÌÎÎÌÌÍÍÍÍ;
        public int ÌÌÏÌÌÎÍÍÍÍÎÌÎÌÌÌÎÌÌÌÍÏÏ;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4F9DB130
        public void get_IsInvalid(){} // RVA: 0x7FFD4F9DB1D0
        public void .ctor(){} // RVA: 0x7FFD4F9DB240
        public void Initialize(){} // RVA: 0x7FFD4F9DB390
        public void ResetHandleState(){} // RVA: 0x7FFD4F9DB570
        public void DoLookRotation_Injected_D62(){} // RVA: 0x7FFD4F9DB5F0
        public void ComputeRoot(){} // RVA: 0x7FFD4F9DB670
        public void ProcessHandleRelease(){} // RVA: 0x7FFD4F9DB850
        public void EnsureReleaseHandleStatics(){} // RVA: 0x7FFD4F9DBA30
        public void ReleaseHandle(){} // RVA: 0x7FFD4F9DBC10
        public void DoRecentering(){} // RVA: 0x7FFD4F9DBCF0
        public void ClearHandleState(){} // RVA: 0x7FFD4F9DBEE0
        public void Equals(){} // RVA: 0x7FFD4F9DBF80
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F9DC140
    }

    /// <summary>Originally: ÎÏÏÌÍÎÍÎÏÎÎÌÏÏÍÍÎÎÎÏÍÍÏ</summary>
    public class PlayerShouldActivateModuleIsModuleSupported_4623 : PointerInputModule
    {
        public float f_B24;
        public float f_338;
        public float f_053;
        public float f_66F; // 0x4
        public string f_BFA; // 0x68
        public string f_B31; // 0x70
        public float f_230; // 0x78
        public float m_RepeatDelay; // 0x7C
        public bool m_ForceModuleActive; // 0x80
        public UnityEngine.UI.Selectable ÏÏÏÏÌÏÏÌÎÍÌÎÏÎÍÍÌÍÌÏÏÌÎ; // 0x88
        public UnityEngine.Vector2 ÌÌÌÏÏÍÌÍÎÏÏÏÍÌÎÌÏÌÏÏÍÌÌ; // 0x90
        public UnityEngine.Vector3 ÎÎÍÍÏÏÍÍÎÍÎÌÏÌÎÌÎÍÏÌÍÏÍ; // 0x98
        public UnityEngine.Vector2 ÎÏÌÌÌÌÌÍÎÌÍÎÌÏÎÍÌÏÎÌÌÎÏ; // 0xA4
        public bool[] ÎÍÏÎÎÎÌÌÍÏÌÌÌÏÏÍÌÌÍÏÌÏÍ; // 0xB0
        public bool[] ÌÏÍÍÌÍÌÍÍÍÍÏÏÍÎÏÌÏÎÏÍÎÍ; // 0xB8
        public System.Collections.Generic.Dictionary`2<UnityEngine.EventSystems.PointerEventData,UnityEngine.Vector3> ÎÌÎÎÍÍÎÎÏÌÎÎÍÌÏÍÎÎÍÍÏÏÌ; // 0xC0
        public System.Collections.Generic.Dictionary`2<UnityEngine.EventSystems.PointerEventData,UnityEngine.Vector3> ÎÌÎÎÏÌÎÌÍÌÌÎÎÌÍÌÏÏÍÎÍÌÌ; // 0xC8
        public System.Collections.Generic.Dictionary`2<UnityEngine.EventSystems.PointerEventData,UnityEngine.Vector2> ÌÎÎÎÌÍÏÎÍÏÎÌÎÎÎÍÌÎÍÎÍÌÎ; // 0xD0
        public MouseState ÌÌÍÌÎÎÍÎÍÏÏÎÏÌÏÏÏÍÏÏÎÌÌ; // 0xD8
        public int ÏÍÏÎÏÌÎÏÍÌÌÎÏÏÍÎÎÍÎÎÏÏÍ; // 0xE0
        public UnityEngine.Vector2 ÏÌÍÍÏÏÏÌÎÍÏÎÌÏÍÍÏÎÏÎÍÏÎ; // 0xE4
        public UnityEngine.Vector2 ÏÍÌÎÏÎÍÌÍÏÍÍÎÍÍÏÎÏÏÏÌÌÎ; // 0xEC
        public UnityEngine.Vector2 ÏÍÏÌÍÍÌÌÏÏÎÍÍÏÍÍÍÌÎÌÍÏÍ; // 0xF4
        public float ÏÏÎÏÎÏÏÎÌÍÎÎÏÌÏÏÏÏÎÎÎÌÎ; // 0xFC
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÎÌÏÏÍÌÎÏÎÏÍÍÎÍÍÍÌÌÏÌÏÏ; // 0x100
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÍÎÌÌÍÏÏÏÏÎÏÍÎÏÍÏÍÎÎÍÏ; // 0x108
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÎÏÍÎÍÍÎÍÍÏÍÌÏÍÌÎÍÍÍÏÍÍ; // 0x110
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÍÌÎÍÍÎÌÏÌÍÏÌÎÌÍÍÎÌÌÌÍÏ; // 0x118
        public UnityEngine.GameObject ÌÍÏÍÏÍÎÌÌÎÌÎÌÏÎÍÍÌÍÎÌÏÍ; // 0x120
        public UnityEngine.GameObject ÏÎÍÍÌÍÌÍÌÎÏÏÌÍÏÏÍÍÍÎÍÏÏ; // 0x128

        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFD4F7265B0
        public void RemovePointerData(){} // RVA: 0x7FFD4F726780
        public void set_body(){} // RVA: 0x7FFD4E4095A0
        public void CopyFromTo(){} // RVA: 0x7FFD4F7267F0
        public void StateForMouseButton(){} // RVA: 0x7FFD4F726AD0
        public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void GetLastPointerEventData(){} // RVA: 0x7FFD4F726C70
        public void set_IsConfigured(){} // RVA: 0x7FFD4E55D3B0
        public void ProcessDrag(){} // RVA: 0x7FFD4F726E20
        public void ProcessDrag_589AC804266A(){} // RVA: 0x7FFD4F7274C0
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void ClearSelection(){} // RVA: 0x7FFD4F727820
        public void ApplyTransform(){} // RVA: 0x7FFD4F727A60
        public void get_clipLength(){} // RVA: 0x7FFD4E36A0E0
        public void set_clipLength(){} // RVA: 0x7FFD4E36A0F0
        public void AlignPlayerModuleRotation(){} // RVA: 0x7FFD4F727AF0
        public void get_disablePoster(){} // RVA: 0x7FFD4E55E620
        public void RemovePointerData_75DA504C2C5C(){} // RVA: 0x7FFD4F726780
        public void UpdateModule(){} // RVA: 0x7FFD4F728130
        public void set_YawInput(){} // RVA: 0x7FFD4E36A110
        public void UpdatePlayerModuleRotation(){} // RVA: 0x7FFD4F728180
        public void IsModuleSupported(){} // RVA: 0x7FFD4E426850
        public void CompositionMethod(){} // RVA: 0x7FFD4E433AF0
        public void Awake(){} // RVA: 0x7FFD4F728320
        public void get_counterRotationStrength(){} // RVA: 0x7FFD4E36A100
        public void ProcessMove(){} // RVA: 0x7FFD4F7283B0
        public void DeactivateModule(){} // RVA: 0x7FFD4F7283D0
        public void Process(){} // RVA: 0x7FFD4F7283E0
        public void .ctor(){} // RVA: 0x7FFD4F728830
        public void Initialize(){} // RVA: 0x7FFD4E919180
        public void SetPlayerModuleActive(){} // RVA: 0x7FFD4F728CC0
        public void SetPlayerModuleEnabled(){} // RVA: 0x7FFD4F7299E0
        public void CompositionMethod_CE8928BFB7C1(){} // RVA: 0x7FFD4E433AF0
        public void ProcessRenderingCommandBuffer(){} // RVA: 0x7FFD4F72A640
        public void SetGlobalTextureImpl(){} // RVA: 0x7FFD4F72A7D0
        public void set_IsConfigured_36B0AF17D03C(){} // RVA: 0x7FFD4E55D3B0
        public void StartPlayerModuleOpenVr(){} // RVA: 0x7FFD4F72A9B0
        public void ActivateModule(){} // RVA: 0x7FFD4F72AAE0
        public void CopyTexture(){} // RVA: 0x7FFD4F72AC40
        public void Update(){} // RVA: 0x7FFD4F72ACF0
        public void Start(){} // RVA: 0x7FFD4F72AF70
        public void get_localScale(){} // RVA: 0x7FFD4F72B1A0
        public void ShouldActivateModule(){} // RVA: 0x7FFD4F72B2C0
        public void ProcessTransform(){} // RVA: 0x7FFD4F72B4D0
        public void StopPlayerModuleOpenVr(){} // RVA: 0x7FFD4F72B7E0
        public void .cctor(){} // RVA: 0x7FFD4F72B8B0
        public void get_disablePoster_683615F899B5(){} // RVA: 0x7FFD4E55E620
    }

    /// <summary>Originally: ÌÍÍÌÌÍÎÎÏÏÎÍÎÏÏÌÌÌÏÍÌÌÍ</summary>
    public class PlayerUseLowLatencyVideoHeight_EC39 : Object
    {
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer _loop; // 0x10
        public RenderHeads.Media.AVProVideo.MediaPlayer _videoHeight; // 0x18
        public int _videoWidth; // 0x20
        public bool _useLowLatency; // 0x24
        public bool _isPlaying; // 0x25
        public bool _isReady; // 0x26

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FB2BEA0
        public void LoadURL(){} // RVA: 0x7FFD4FB2BFA0
        public void get_Loop(){} // RVA: 0x7FFD4E35C7C0
        public void op_Implicit(){} // RVA: 0x7FFD4FB2C0D0
        public void SetTime(){} // RVA: 0x7FFD4FB2C110
        public void get_VideoHeight(){} // RVA: 0x7FFD4FB2C1F0
        public void get_VideoWidth(){} // RVA: 0x7FFD4FB2C260
        public void PlayURL(){} // RVA: 0x7FFD4FB2C2D0
        public void set_name(){} // RVA: 0x7FFD4FB2C400
        public void set_Loop(){} // RVA: 0x7FFD4F842FB0
        public void GetTime(){} // RVA: 0x7FFD4FB2C450
        public void Instantiate(){} // RVA: 0x7FFD4FB2C4C0
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFD4F3C0EC0
        public void set_UseLowLatency(){} // RVA: 0x7FFD4FB2C5F0
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFD4F3C0EB0
        public void get_UseLowLatency(){} // RVA: 0x7FFD4FB2C620
        public void Play(){} // RVA: 0x7FFD4FB2C650
        public void GetDuration(){} // RVA: 0x7FFD4FB2C680
        public void get_IsPlaying(){} // RVA: 0x7FFD4FB2C6F0
        public void set_IsPlaying(){} // RVA: 0x7FFD4FB2C820
        public void Destroy(){} // RVA: 0x7FFD4FB2CA10
        public void Stop(){} // RVA: 0x7FFD4FB2CC30
        public void set_IgnoreSerializableInterface(){} // RVA: 0x7FFD4FB2CC50
        public void set_IsReady(){} // RVA: 0x7FFD4E35C7C0
        public void get_IsReady(){} // RVA: 0x7FFD4F3C0EA0
        public void FindObjectsByType(){} // RVA: 0x7FFD4FB2C400
        public void Equals(){} // RVA: 0x7FFD4FB2C400
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4FB2CC60
        public void get_hideFlags(){} // RVA: 0x7FFD4FB2CCD0
        public void set_hideFlags(){} // RVA: 0x7FFD4FB2CD10
        public void Pause(){} // RVA: 0x7FFD4FB2C5F0
        public void FindObjectOfType(){} // RVA: 0x7FFD4F3C0EB0
        public void .ctor(){} // RVA: 0x7FFD4FB2CD80
    }

    /// <summary>Originally: ÏÎÎÍÎÏÍÏÍÌÏÍÎÌÌÏÏÎÍÏÍÌÍ</summary>
    public class PlayercontrolPathInternal_23AE : OnScreenControl
    {
        public bool _controlPathInternal; // 0x38
        public System.Action _control; // 0x40
        public bool ÏÏÎÎÍÍÎÎÍÏÎÌÏÎÎÏÏÎÎÌÎÍÌ; // 0x48
        public string m_ControlPath; // 0x50

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7FFD4F6B8FF0
        public void set_controlPath(){} // RVA: 0x7FFD4F6B9220
        public void get_control(){} // RVA: 0x7FFD4F6B92C0
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void .ctor(){} // RVA: 0x7FFD4F6B40A0
        public void Initialize(){} // RVA: 0x7FFD4E5F95D0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFD4E5F95C0
        public void OnPointerDown(){} // RVA: 0x7FFD4F6B94F0
        public void get_HasAnyActive(){} // RVA: 0x7FFD4E5F95C0
        public void OnPointerEnter(){} // RVA: 0x7FFD4F6B9560
        public void OnDisable(){} // RVA: 0x7FFD4ED5D910
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E4994D0
        public void Initialize_F095EFEF8EB6(){} // RVA: 0x7FFD4ED5D910
        public void ConfigureTransformLocalScale(){} // RVA: 0x7FFD4F6B9570
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E3E20E0
        public void OnPointerExit(){} // RVA: 0x7FFD4F6B9610
        public void set_name(){} // RVA: 0x7FFD4F6B96B0
        public void set_name_5D04F092B7F5(){} // RVA: 0x7FFD4F6B9720
        public void OnPointerUp(){} // RVA: 0x7FFD4F6B9850
    }

    /// <summary>Originally: ÎÏÏÌÏÌÎÌÍÏÎÍÌÏÏÍÍÏÎÍÏÍÎ</summary>
    public class PlayercontrolPathInternal_241A : OnScreenControl
    {
        public string _controlPathInternal; // 0x38

        // ── Methods ──
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E5F0C20
        public void set_controlPath(){} // RVA: 0x7FFD4EB16570
        public void get_control(){} // RVA: 0x7FFD4EB165C0
        public void OnPointerDown(){} // RVA: 0x7FFD4EB16610
        public void set_controlPathInternal_44621B9A3400(){} // RVA: 0x7FFD4EB16660
        public void SetupInputControl(){} // RVA: 0x7FFD4EB166B0
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E5F0140
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4EB16700
        public void OnPointerUp(){} // RVA: 0x7FFD4EB16750
        public void OnDisable(){} // RVA: 0x7FFD4EB167A0
        public void GetWarningMessage(){} // RVA: 0x7FFD4EB167F0
    }

    /// <summary>Originally: ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ</summary>
    public class PlayercontrolSchemesbindingMask_17CC : Object
    {
        public UnityEngine.InputSystem.InputActionAsset _devices; // 0x10
        public UnityEngine.InputSystem.InputActionMap _controlSchemes; // 0x18
        public System.Collections.Generic.List`1<ÌÏÌÏÍÍÍÌÎÍÍÌÎÎÏÎÍÎÏÍÏÌÌ> _bindings; // 0x20
        public UnityEngine.InputSystem.InputAction _bindingMask; // 0x28
        public UnityEngine.InputSystem.InputAction f_3A9; // 0x30
        public UnityEngine.InputSystem.InputAction f_B28; // 0x38
        public UnityEngine.InputSystem.InputAction f_D67; // 0x40
        public UnityEngine.InputSystem.InputAction f_EBA; // 0x48
        public UnityEngine.InputSystem.InputAction f_1B3; // 0x50
        public UnityEngine.InputSystem.InputAction f_680; // 0x58
        public UnityEngine.InputSystem.InputAction f_C41; // 0x60
        public UnityEngine.InputSystem.InputAction f_2F5; // 0x68
        public UnityEngine.InputSystem.InputAction ÍÍÏÍÎÎÌÎÎÌÌÏÎÍÏÏÍÌÍÏÌÌÌ; // 0x70
        public UnityEngine.InputSystem.InputAction ÏÌÎÌÎÏÏÍÍÍÎÏÍÏÍÏÏÎÍÍÍÏÍ; // 0x78
        public UnityEngine.InputSystem.InputAction ÌÍÎÎÌÏÍÎÎÍÌÏÍÍÏÎÌÌÏÎÌÎÌ; // 0x80
        public UnityEngine.InputSystem.InputAction ÏÏÏÍÌÏÎÍÌÏÌÏÌÌÏÏÍÎÌÏÏÍÍ; // 0x88
        public UnityEngine.InputSystem.InputAction ÌÌÍÏÌÏÏÏÎÌÏÎÌÌÎÍÍÍÌÏÌÎÏ; // 0x90
        public UnityEngine.InputSystem.InputAction ÍÏÏÎÍÏÌÍÍÍÎÏÎÌÌÍÌÏÏÎÍÏÍ; // 0x98
        public UnityEngine.InputSystem.InputAction ÍÏÍÎÏÏÍÏÏÍÌÌÍÏÏÌÍÌÍÌÌÎÎ; // 0xA0
        public UnityEngine.InputSystem.InputAction ÍÎÍÌÎÏÏÌÌÎÎÍÏÌÌÏÏÏÌÎÏÌÏ; // 0xA8
        public UnityEngine.InputSystem.InputAction ÏÍÍÏÍÎÍÎÍÍÏÏÌÏÌÎÎÍÏÎÌÎÏ; // 0xB0
        public UnityEngine.InputSystem.InputAction ÎÎÏÎÏÏÏÏÎÏÎÎÌÍÏÏÏÏÎÏÌÏÌ; // 0xB8
        public UnityEngine.InputSystem.InputAction ÌÍÏÌÍÎÎÎÌÏÌÍÎÍÍÏÌÎÎÏÍÎÏ; // 0xC0
        public UnityEngine.InputSystem.InputAction ÎÍÌÏÎÏÎÌÍÌÌÎÍÌÌÌÏÍÍÏÏÎÏ; // 0xC8
        public UnityEngine.InputSystem.InputAction ÌÍÍÍÍÌÍÍÏÌÍÏÍÎÏÎÌÌÎÍÌÍÌ; // 0xD0
        public UnityEngine.InputSystem.InputActionMap ÎÌÌÍÏÏÌÎÍÍÎÍÏÎÎÎÎÎÎÍÎÏÎ; // 0xD8
        public System.Collections.Generic.List`1<ÍÏÏÏÍÌÍÍÏÎÌÍÌÏÌÍÏÍÏÍÍÌÍ> ÎÍÌÌÍÎÏÎÎÎÏÏÌÍÌÏÍÏÎÏÏÍÏ; // 0xE0
        public UnityEngine.InputSystem.InputAction ÎÌÏÏÎÍÌÏÍÏÎÎÌÍÌÎÏÎÍÎÎÍÎ; // 0xE8
        public UnityEngine.InputSystem.InputAction ÌÎÏÍÌÏÏÌÏÏÎÎÏÌÍÎÍÌÍÎÌÏÏ; // 0xF0
        public UnityEngine.InputSystem.InputAction ÎÏÎÌÏÎÎÍÏÏÎÍÍÍÏÏÏÏÏÌÍÎÍ; // 0xF8
        public UnityEngine.InputSystem.InputAction ÎÍÎÌÏÎÎÏÍÌÎÎÎÌÎÎÎÍÍÎÎÎÏ; // 0x100
        public UnityEngine.InputSystem.InputAction ÌÏÌÍÎÌÏÏÌÎÎÍÌÌÏÌÍÎÍÍÌÌÎ; // 0x108
        public UnityEngine.InputSystem.InputAction ÏÏÏÏÍÌÌÌÌÍÍÏÏÌÌÌÌÍÍÎÌÎÏ; // 0x110
        public UnityEngine.InputSystem.InputAction ÍÏÏÎÌÎÌÌÌÍÎÎÏÏÏÍÌÌÍÍÌÍÌ; // 0x118
        public UnityEngine.InputSystem.InputAction ÎÏÌÎÌÏÏÎÌÍÌÍÏÏÎÎÍÍÏÏÎÏÌ; // 0x120
        public UnityEngine.InputSystem.InputAction ÍÎÎÏÏÍÍÎÏÏÎÏÎÎÏÌÍÌÎÍÎÎÎ; // 0x128
        public UnityEngine.InputSystem.InputActionMap ÍÎÌÌÌÍÍÍÎÍÍÎÎÍÍÎÎÎÍÎÍÎÎ; // 0x130
        public System.Collections.Generic.List`1<ÏÎÌÍÏÍÎÎÌÍÏÌÎÍÏÏÎÎÎÏÌÎÌ> ÎÏÍÎÌÍÎÍÍÍÍÏÏÍÎÌÎÍÏÌÌÎÎ; // 0x138
        public UnityEngine.InputSystem.InputAction ÎÏÎÌÌÍÏÎÌÎÏÌÏÏÏÍÎÏÏÍÎÍÏ; // 0x140
        public UnityEngine.InputSystem.InputAction ÏÌÎÌÏÎÏÏÌÍÌÌÏÍÍÎÎÍÎÌÌÌÌ; // 0x148
        public UnityEngine.InputSystem.InputAction ÌÏÍÌÌÍÏÍÎÌÎÍÍÎÍÌÍÎÌÏÎÍÏ; // 0x150
        public UnityEngine.InputSystem.InputAction ÌÌÏÏÍÎÏÎÍÍÎÎÍÏÏÎÎÌÎÏÍÎÎ; // 0x158
        public UnityEngine.InputSystem.InputAction ÏÌÍÎÍÍÌÌÍÌÎÎÍÌÍÎÏÏÍÏÏÌÌ; // 0x160
        public UnityEngine.InputSystem.InputAction ÎÌÌÎÌÎÌÎÌÏÏÏÎÏÍÌÍÍÌÏÎÌÎ; // 0x168
        public UnityEngine.InputSystem.InputAction ÍÌÌÍÍÍÏÏÍÌÍÎÏÎÎÏÍÍÏÏÍÍÏ; // 0x170
        public UnityEngine.InputSystem.InputAction ÏÍÍÏÍÍÍÏÎÏÎÍÌÌÎÍÏÌÏÎÏÌÍ; // 0x178
        public UnityEngine.InputSystem.InputAction ÍÍÌÌÏÎÎÌÏÍÍÎÌÍÌÎÎÏÎÎÍÏÏ; // 0x180
        public UnityEngine.InputSystem.InputAction ÏÎÍÎÍÎÎÎÌÍÏÎÍÍÎÍÎÏÎÌÍÏÍ; // 0x188
        public UnityEngine.InputSystem.InputAction ÎÍÍÌÎÍÎÏÌÎÏÏÍÏÍÎÎÏÌÏÎÍÍ; // 0x190
        public UnityEngine.InputSystem.InputAction ÍÍÏÌÎÏÎÌÍÍÍÌÌÌÌÏÏÏÌÍÌÏÌ; // 0x198
        public UnityEngine.InputSystem.InputAction ÌÎÍÏÍÍÍÍÍÏÏÌÍÌÌÍÍÎÏÍÎÌÏ; // 0x1A0
        public UnityEngine.InputSystem.InputAction ÏÍÌÍÍÎÏÌÏÏÏÍÍÏÎÍÏÍÎÍÏÌÏ; // 0x1A8
        public UnityEngine.InputSystem.InputAction ÌÌÎÎÎÏÏÍÌÍÏÌÍÌÍÌÍÍÏÏÍÎÍ; // 0x1B0
        public UnityEngine.InputSystem.InputAction ÌÏÍÏÍÌÎÎÎÌÍÏÎÏÎÌÏÍÎÎÏÍÍ; // 0x1B8
        public UnityEngine.InputSystem.InputActionMap ÏÏÍÏÏÎÎÍÌÎÏÎÌÏÌÌÏÍÎÎÎÏÏ; // 0x1C0
        public System.Collections.Generic.List`1<ÏÎÌÎÌÍÌÎÍÏÌÌÎÎÏÎÏÍÎÎÎÏÎ> ÏÍÍÍÍÌÎÌÏÌÏÏÌÏÍÏÌÏÍÌÎÎÎ; // 0x1C8
        public UnityEngine.InputSystem.InputAction ÌÎÎÏÏÍÍÌÎÍÌÌÏÎÌÍÌÍÍÍÏÏÎ; // 0x1D0
        public UnityEngine.InputSystem.InputAction ÍÍÎÌÏÍÏÏÍÏÍÌÌÍÏÎÎÌÌÎÌÍÍ; // 0x1D8
        public UnityEngine.InputSystem.InputAction ÎÏÎÏÏÌÍÍÏÏÎÏÎÍÌÌÎÏÎÎÏÎÌ; // 0x1E0
        public UnityEngine.InputSystem.InputAction ÍÌÌÍÏÍÌÎÍÎÏÍÏÏÍÎÏÍÍÎÏÌÏ; // 0x1E8
        public UnityEngine.InputSystem.InputAction ÌÏÎÎÌÌÏÏÍÌÎÏÌÏÏÍÍÎÏÌÍÍÏ; // 0x1F0
        public UnityEngine.InputSystem.InputAction ÏÍÍÏÍÎÎÍÌÎÍÏÏÎÌÍÏÌÍÏÌÍÏ; // 0x1F8
        public UnityEngine.InputSystem.InputAction ÌÌÏÎÏÎÎÎÍÌÏÏÎÎÎÍÌÌÍÏÎÍÏ; // 0x200
        public UnityEngine.InputSystem.InputAction ÌÍÎÏÌÎÍÏÌÌÌÍÏÏÌÍÍÏÌÎÏÎÏ; // 0x208
        public UnityEngine.InputSystem.InputAction ÎÏÌÍÎÏÍÍÌÍÏÏÍÍÎÎÎÏÎÏÎÎÏ; // 0x210
        public UnityEngine.InputSystem.InputAction ÎÍÍÍÍÏÎÌÍÏÍÌÍÏÍÏÌÏÎÌÌÎÏ; // 0x218
        public UnityEngine.InputSystem.InputAction ÏÎÍÎÍÍÎÏÏÏÎÎÍÍÎÌÏÍÎÏÎÌÍ; // 0x220
        public UnityEngine.InputSystem.InputAction ÏÍÍÍÍÌÏÎÏÌÍÏÍÏÍÌÍÍÌÍÏÍÌ; // 0x228
        public UnityEngine.InputSystem.InputAction ÎÍÎÍÌÌÎÎÏÌÏÌÏÍÏÍÎÍÍÍÏÌÏ; // 0x230
        public UnityEngine.InputSystem.InputAction ÎÍÍÍÎÍÎÌÏÎÍÏÏÏÏÍÏÌÍÌÏÍÎ; // 0x238
        public int ÌÎÌÍÏÏÏÏÏÍÌÌÌÍÎÍÎÌÎÏÌÎÌ; // 0x240
        public int ÏÎÏÎÍÎÌÍÏÏÎÍÎÌÏÎÌÍÍÌÏÍÌ; // 0x244
        public int ÏÌÎÍÌÍÍÍÌÎÏÎÍÏÏÌÏÌÍÌÍÍÎ; // 0x248

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4ECF6BA0
        public void get_devices(){} // RVA: 0x7FFD4ECF6D20
        public void set_devices(){} // RVA: 0x7FFD4ECF6D70
        public void op_Implicit(){} // RVA: 0x7FFD4E35C380
        public void set_controlSchemes(){} // RVA: 0x7FFD4ECF6DF0
        public void get_controlSchemes(){} // RVA: 0x7FFD4ECF6F70
        public void WaitUntilCanceled(){} // RVA: 0x7FFD4ECF6FB0
        public void get_name(){} // RVA: 0x7FFD4ECF6FB0
        public void Disable(){} // RVA: 0x7FFD4ECF7010
        public void .ctor(){} // RVA: 0x7FFD4ECF7030
        public void Initialize(){} // RVA: 0x7FFD4ECF9060
        public void Instantiate(){} // RVA: 0x7FFD4ECF9080
        public void Enable(){} // RVA: 0x7FFD4ECF9200
        public void Dispose(){} // RVA: 0x7FFD4ECF9220
        public void Cleanup(){} // RVA: 0x7FFD4ECF9280
        public void FindBinding(){} // RVA: 0x7FFD4ECF9400
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4ECF9060
        public void set_bindings(){} // RVA: 0x7FFD4ECF9460
        public void get_bindings(){} // RVA: 0x7FFD4ECF95E0
        public void get_bindingMask(){} // RVA: 0x7FFD4ECF9600
        public void Destroy(){} // RVA: 0x7FFD4ECF6FB0
        public void FindAction(){} // RVA: 0x7FFD4ECF9650
        public void DestroyImmediate(){} // RVA: 0x7FFD4ECF6FB0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4ECF6D70
        public void GetEnumerator(){} // RVA: 0x7FFD4ECF9060
        public void FindObjectsByType(){} // RVA: 0x7FFD4ECF9670
        public void Equals(){} // RVA: 0x7FFD4ECF6FB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4ECF6FB0
        public void Contains(){} // RVA: 0x7FFD4ECF97F0
        public void set_bindingMask(){} // RVA: 0x7FFD4ECF9810
        public void GetHashCode(){} // RVA: 0x7FFD4ECF9600
        public void Finalize(){} // RVA: 0x7FFD4ECF9870
    }

    /// <summary>Originally: ÍÌÏÏÌÌÎÌÏÍÏÍÍÌÎÎÍÏÌÏÏÏÎ</summary>
    public class RemovePlayerModsAddPlayerModsComponent_1D88 : MonoBehaviour
    {
        public bool ÏÎÍÎÍÌÎÍÌÍÍÍÍÎÏÏÌÌÌÌÎÍÎ; // 0x20
        public System.Collections.Generic.List`1<ÎÌÏÎÌÌÍÍÍÎÍÌÍÍÌÏÍÏÎÌÌ> ÎÎÍÍÌÍÎÎÌÏÎÍÍÎÏÍÍÏÎÎÎÎÍ; // 0x28
        public System.Collections.Generic.HashSet`1<ÍÌÏÏÌÌÎÌÏÍÏÍÍÌÎÎÍÏÌÏÏÏÎ> ÏÌÍÎÏÎÎÍÎÌÏÍÎÎÌÎÌÌÍÏÍÌÍ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F2F6620
        public void AddPlayerMods(){} // RVA: 0x7FFD4F2F66B0
        public void IsInvoking(){} // RVA: 0x7FFD4F2F67D0
        public void Start(){} // RVA: 0x7FFD4F2F6A00
        public void .cctor(){} // RVA: 0x7FFD4F2F6C30
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F2F6D10
        public void OnDisable(){} // RVA: 0x7FFD4F2F6E30
        public void RemovePlayerMods(){} // RVA: 0x7FFD4F2F6F50
        public void StartCoroutine(){} // RVA: 0x7FFD4F2F7070
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F2F72A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F2F7330
        public void OnDestroy(){} // RVA: 0x7FFD4F2F7450
        public void StopCoroutine(){} // RVA: 0x7FFD4F2F74E0
    }

    /// <summary>Originally: ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ</summary>
    public class VRCPlayer : NetworkReadyHandler_68D0
    {
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ f_3DB;
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ f_3E3; // 0x58
        public ÎÍÏÎÎÌÏÏÎÏÍÌÌÍÎÌÍÍÍÎÌÎÌ f_5FF; // 0x60
        public ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ f_535; // 0x68
        public ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌÍÌÏ f_9FE; // 0x70
        public bool f_F88; // 0x78
        public ÏÏÍÏÎÌÍÏÌÏÍÏÎÌÎÍÎÍÍÏÎÏÍ f_1F9; // 0x80
        public UnityEngine.GameObject f_E87; // 0x88
        public ÏÏÏÌÌÌÎÍÎÍÍÌÍÏÌÍÏÌÍÌÌÌÌ f_B11; // 0x90
        public ÏÌÏÎÍÎÎÎÍÏÎÌÎÍÎÎÎÍÍÎÍÌÍ f_1F5; // 0x98
        public string f_647; // 0xA0
        public UnityEngine.Texture2D f_99C; // 0xA8
        public bool f_0ED; // 0xB0
        public float f_F0A; // 0xB4
        public float f_A6E; // 0xB8
        public System.Collections.Generic.HashSet`1<string> f_15D; // 0xC0
        public ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ f_A59; // 0xC8
        public ÍÏÍÏÏÎÏÌÎÏÌÌÌÍÌÌÎÍÏÍÎÎÌ f_7ED; // 0xD0
        public ÌÌÏÏÍÏÏÍÎÍÌÎÎÏÏÎÌÍÎÎÎÎÏ f_694; // 0xD8
        public UnityEngine.GameObject[] f_7FD; // 0xE0
        public UnityEngine.GameObject[] f_708; // 0xE8
        public ÎÎÏÌÍÏÍÌÏÎÍÏÎÍÌÎÌÍÏÏÏÍÌ f_06A; // 0xF0
        public ÎÎÏÌÍÏÍÌÏÎÍÏÎÍÌÎÌÍÏÏÏÍÌ f_F47; // 0xF8
        public bool f_018; // 0x100
        public float f_C92; // 0x8
        public UnityEngine.Vector3 f_DA7; // 0x104
        public float f_EBD; // 0x110
        public float f_6E1;
        public string f_EB0; // 0x118
        public string f_744; // 0x120
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ f_EA2; // 0x128
        public bool f_E1E; // 0x130
        public bool f_5B2; // 0x131
        public ÌÏÍÎÎÎÏÍÌÍÌÍÏÏÌÌÎÍÌÎÌÎÏ f_ADA; // 0x138
        public UnityEngine.Transform f_C09; // 0x140
        public bool f_35C; // 0x148
        public ÏÍÎÏÏÌÌÍÌÍÍÌÎÌÏÏÌÍÍÌÏÎÎ f_4FE; // 0x150
        public UnityEngine.GameObject f_800; // 0x158
        public UnityEngine.Animator f_972; // 0x160
        public ÌÌÎÎÍÎÏÎÏÎÎÎÌÏÎÏÌÌÌÎÏÍÍ f_6FE; // 0x168
        public System.Collections.Generic.Dictionary`2<string,string> f_5D7; // 0x170
        public System.Collections.Generic.HashSet`1<int> f_127; // 0x178
        public System.Collections.Generic.Dictionary`2<int,int> f_9BB; // 0x180
        public ÍÍÌÌÎÍÏÏÍÎÎÌÏÎÏÍÏÏÌÍÎÌÏ f_0B8; // 0x188
        public bool f_B3B; // 0x190
        public System.Nullable`1<int> f_AAB; // 0x194
        public VRC.SDKBase.VRCPlayerApi f_65C; // 0x1A0
        public System.Collections.Generic.List`1<ÌÍÌÏÍÌÏÍÎÌÏÏÎÏÌÎÍÏÌÌÌÌÌ> f_865; // 0x1A8
        public ÌÍÌÏÍÌÏÍÎÌÏÏÎÏÌÎÍÏÌÌÌÌÌ f_DEE; // 0x1B0
        public ÌÍÌÏÍÌÏÍÎÌÏÏÎÏÌÎÍÏÌÌÌÌÌ f_44C; // 0x1B8
        public bool f_E70; // 0x1C0
        public bool f_2BE; // 0x1C1
        public bool f_992; // 0x1C2
        public bool f_93F; // 0x1C3
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> f_9B5; // 0x1C8
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ f_D2A; // 0x1D0
        public VRC.Core.ApiAvatar f_3C3; // 0x1D8
        public VRC.Core.ApiAvatar f_367; // 0x1E0
        public bool f_473; // 0x1E8
        public bool f_8D0; // 0x1E9
        public string f_ABC; // 0x1F0
        public bool f_56D; // 0x1F8
        public ulong f_9F3; // 0x200
        public bool f_673; // 0x208
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_3E6; // 0x210
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_30B; // 0x218
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÌÍÌÏÌÏÎÎÌÍÎÌÌÎÏÏÍÍÏÏÏÍ; // 0x220
        public float <ÏÍÍÌÎÎÍÍÌÎÎÌÍÏÏÌÎÎÍÏÏÌÌ>k__BackingField; // 0x228
        public float ÍÎÏÌÎÎÏÍÎÌÎÎÎÏÍÌÎÏÎÌÏÎÏ; // 0x22C
        public float ÌÍÌÏÎÎÏÍÌÍÎÍÍÎÎÎÏÏÏÏÏÌÍ; // 0x230
        public float ÏÏÍÎÌÍÎÎÎÌÏÍÏÏÌÎÎÍÌÌÌÎÎ; // 0x234
        public float ÎÎÏÌÌÏÎÏÍÍÏÎÏÎÏÏÎÎÎÎÏÏÏ; // 0x238
        public float ÍÏÎÌÎÏÏÏÎÏÌÍÍÌÏÎÏÌÏÏÍÏÏ;
        public bool ÏÍÍÏÌÎÌÏÌÏÌÍÌÎÏÎÎÎÎÌÎÏÌ; // 0x23C
        public bool ÍÎÌÏÏÍÏÎÌÍÏÏÎÏÌÍÍÏÌÌÍÎÎ; // 0x23D
        public bool ÌÌÏÌÏÌÌÏÍÍÍÌÌÏÌÏÌÍÏÍÎÏÍ; // 0x23E
        public bool ÍÌÍÏÍÌÏÎÏÎÏÏÎÏÏÌÏÏÎÎÏÎÏ; // 0x23F
        public bool ÍÌÍÌÌÌÎÎÏÌÏÌÎÌÌÎÎÎÌÏÎÏÏ; // 0x240
        public string ÏÎÍÍÌÍÍÍÎÍÏÎÍÏÏÎÏÍÌÌÎÌÏ; // 0x248
        public int ÌÌÍÍÌÌÌÍÎÎÏÌÌÎÍÎÌÎÏÍÌÍÏ; // 0xC
        public string ÌÎÌÍÌÌÎÎÌÌÌÏÍÍÏÏÍÏÍÌÌÌÏ;
        public string ÎÌÎÏÎÎÎÍÌÍÌÎÌÎÏÍÏÌÌÏÏÌÌ;
        public string ÎÏÍÍÏÌÎÌÎÎÍÌÎÏÌÏÌÍÏÌÍÏÍ; // 0x250
        public System.Action ÍÌÌÌÍÎÎÌÌÌÏÎÏÌÍÏÍÎÌÏÍÏÎ; // 0x258
        public System.Nullable`1<bool> ÏÏÎÌÌÏÏÎÌÎÎÍÎÌÍÏÍÏÏÎÌÌÌ; // 0x260
        public float ÌÍÎÍÎÌÏÎÍÏÍÍÌÍÍÎÍÌÎÎÏÏÏ; // 0x10
        public float ÍÍÏÍÍÍÎÍÏÍÌÏÍÎÍÍÎÍÌÌÎÍÍ; // 0x14
        public float ÌÌÎÍÏÏÍÌÏÌÌÍÎÍÌÍÌÍÍÍÍÌÏ; // 0x18
        public float ÎÏÏÎÍÎÎÎÏÌÏÌÎÏÌÍÎÍÏÌÍÌÏ; // 0x1C
        public bool ÏÏÌÏÏÌÎÏÏÎÎÎÏÏÍÍÎÌÏÎÍÌÍ; // 0x20
        public float ÎÌÎÎÍÏÎÎÍÌÌÎÌÌÍÍÍÍÍÏÌÌÍ; // 0x264
        public float ÌÎÍÎÎÌÏÍÌÌÌÎÌÎÌÎÏÎÌÎÍÍÏ; // 0x268
        public bool ÍÎÏÎÍÏÏÏÎÎÌÏÏÌÎÌÍÌÍÌÎÌÌ; // 0x26C
        public float ÌÏÎÍÏÍÏÌÍÌÌÍÌÏÍÍÎÏÌÍÏÎÎ; // 0x270
        public float ÌÏÎÌÍÎÍÎÏÌÌÏÏÎÍÏÎÌÏÌÎÍÍ; // 0x274
        public System.Action ÌÍÎÏÎÎÏÏÏÍÏÎÎÎÏÎÌÏÏÎÌÍÏ; // 0x278
        public float ÍÏÎÏÍÌÌÎÍÌÎÍÏÍÍÌÌÏÍÎÏÏÎ;
        public bool ÏÌÍÏÎÎÍÏÌÌÏÏÎÍÌÍÎÌÌÎÍÍÎ; // 0x280
        public float ÎÌÎÏÏÍÏÌÏÏÍÏÎÏÌÎÌÍÌÏÍÍÍ; // 0x284
        public int ÌÍÌÏÌÌÏÍÎÏÍÎÍÎÍÏÌÍÎÍÍÌÍ; // 0x24
        public float ÍÌÍÍÎÏÏÏÌÏÏÍÎÎÍÍÌÍÍÎÎÏÎ; // 0x28
        public UnityEngine.Color ÏÎÎÍÎÎÍÎÎÎÍÍÌÎÏÍÌÏÍÍÍÌÏ; // 0x2C
        public UnityEngine.Color ÍÎÎÎÏÌÍÌÌÌÎÏÏÎÍÎÏÎÍÎÌÍÍ; // 0x3C
        public UnityEngine.Color ÍÍÍÌÍÍÍÍÍÏÌÏÎÏÌÌÌÎÍÌÎÍÏ; // 0x4C
        public UnityEngine.Color ÏÎÌÏÏÎÏÍÏÏÍÍÍÎÌÎÍÏÌÍÎÎÍ; // 0x5C
        public UnityEngine.Color ÏÎÍÏÍÎÍÌÌÏÍÎÌÏÎÌÏÌÌÍÏÍÍ; // 0x6C
        public UnityEngine.Color ÍÌÎÌÎÎÍÌÍÎÍÌÌÏÏÌÏÎÏÌÍÍÌ; // 0x7C
        public UnityEngine.Color ÏÌÏÍÍÌÌÎÎÌÏÏÏÌÏÍÏÏÎÍÎÍÌ; // 0x8C
        public UnityEngine.Color ÍÎÍÎÏÌÏÍÌÎÎÌÍÏÏÏÎÏÍÏÍÍÎ; // 0x9C
        public UnityEngine.Color ÍÍÏÏÎÎÌÌÍÏÎÎÎÎÏÏÏÎÍÍÏÎÍ; // 0xAC
        public UnityEngine.Color ÍÏÎÍÏÍÍÌÌÎÎÍÎÏÏÍÍÍÏÍÍÏÌ; // 0xBC
        public bool ÌÌÏÌÍÌÏÎÍÏÏÏÍÏÍÌÏÏÎÏÌÍÍ; // 0x288
        public string ÌÏÏÌÌÎÏÍÌÌÎÌÍÏÏÌÍÏÏÏÎÏÍ; // 0x290
        public System.Action ÌÏÌÎÏÍÏÎÌÎÍÏÍÌÎÏÌÎÌÏÏÎÍ; // 0x298
        public float ÌÌÌÏÌÏÍÍÌÎÌÏÌÏÎÌÎÎÏÍÍÎÏ; // 0xCC
        public bool ÏÎÌÏÎÎÎÎÎÌÏÏÌÍÌÌÎÏÏÍÍÏÎ; // 0xD0
        public string ÏÏÏÏÍÏÎÎÎÏÎÌÏÍÌÍÏÍÎÌÎÎÎ; // 0xD8
        public float ÍÍÎÎÏÎÍÎÎÍÎÍÌÎÍÌÍÏÏÏÎÎÍ;
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> ÏÌÍÏÏÌÏÎÎÏÍÎÍÏÌÎÍÍÌÌÏÎÌ; // 0x2A0
        public bool ÌÎÌÍÏÎÌÎÏÏÍÏÏÏÏÌÏÌÎÏÍÌÏ; // 0xE0
        public string ÌÍÏÌÎÍÍÏÍÏÍÍÎÌÎÏÏÌÏÌÎÍÍ; // 0xE8
        public float ÌÌÍÍÎÎÍÎÍÎÌÏÍÎÎÌÍÍÎÌÌÎÏ;
        public ÏÎÍÏÏÏÏÍÍÍÏÍÎÍÏÎÌÌÍÎÏÌÏ ÏÍÌÍÍÏÎÌÌÎÍÏÍÎÏÍÏÌÏÎÌÏÎ; // 0x2A8
        public System.Collections.Generic.HashSet`1<0x664D0050> ÌÍÏÍÏÎÌÏÏÎÌÎÍÍÍÎÍÍÌÏÏÏÌ; // 0x2B0
        public System.Collections.Generic.List`1<ÌÍÌÏÌÏÌÍÍÌÎÍÎÎÎÍÏÍÌÌÍÏÍ> ÌÌÎÌÎÌÍÏÎÎÍÏÏÎÎÌÎÌÍÏÎÍÍ; // 0x2B8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> <ÌÍÏÍÎÍÌÌÌÎÏÍÎÏÍÏÌÍÏÌÎÏÏ>k__BackingField; // 0x2C0
        public System.Collections.Generic.Queue`1<int> ÏÌÏÌÎÏÏÌÎÏÎÏÌÍÏÏÌÏÏÍÎÏÌ; // 0x2C8
        public int ÌÌÏÌÌÍÎÍÍÍÌÌÌÎÏÎÎÍÍÎÌÌÌ; // 0x2D0

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4F5474B0
        public void Computetransform_F8806A6B5CFD(){} // RVA: 0x7FFD4F55E6C0 | overloaded x2
        public void get_enableAutoSizing(){} // RVA: 0x7FFD4F5476F0
        public void set_NetworkSerializerReference(){} // RVA: 0x7FFD4F547700
        public void get_disclaimerText(){} // RVA: 0x7FFD4E499460
        public void get_IsStaticInstanceFlagSet(){} // RVA: 0x7FFD4F5477B0
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFD4F5477D0
        public void IsLocalPlayerMaster(){} // RVA: 0x7FFD4F547930
        public void SetEnabled_281(){} // RVA: 0x7FFD4F547AF0
        public void GetBufferAsTypeSafe(){} // RVA: 0x7FFD4E9666F0
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFD4F547B00
        public void DoGetMaterial_A46(){} // RVA: 0x7FFD4F547B20
        public void ResolvePlayerAvatarFromNetworkState(){} // RVA: 0x7FFD4F547C80
        public void SetPlayerAnimatorFromNetworkObject(){} // RVA: 0x7FFD4F547CE0
        public void Awake(){} // RVA: 0x7FFD4F547E30
        public void get_PlayerApiReference_D651603365EF(){} // RVA: 0x7FFD4F55B900 | overloaded x2
        public void DoOpenURL_7CE(){} // RVA: 0x7FFD4F548E00
        public void get_IsLocalPlayerDefault(){} // RVA: 0x7FFD4F548FB0
        public void get_IsInvisible(){} // RVA: 0x7FFD4F549100
        public void DoOpenURL_EA4(){} // RVA: 0x7FFD4F549440
        public void InitializePlayerNetworkSerialization(){} // RVA: 0x7FFD4F549820
        public void GetGameObject_786(){} // RVA: 0x7FFD4F549830
        public void Dispose(){} // RVA: 0x7FFD4F549900
        public void GetGameObject_8A4(){} // RVA: 0x7FFD4F54A720
        public void set_statusDescription(){} // RVA: 0x7FFD4F54A730
        public void get_onEndTextSelection(){} // RVA: 0x7FFD4EDE0A30
        public void GetGameObject_EF0(){} // RVA: 0x7FFD4F54AB40
        public void GetIKSolver(){} // RVA: 0x7FFD4F54AB90
        public void get_IsLocalPlayerFallback(){} // RVA: 0x7FFD4F54ACD0
        public void OnPlayerDisconnectCleanup(){} // RVA: 0x7FFD4F54ACE0
        public void GetGameObject_8A4_FA4BCC271619(){} // RVA: 0x7FFD4F54ADD0
        public void ApplyPlayerVoiceVolume(){} // RVA: 0x7FFD4F54AF30
        public void SetNetworkSerializerFieldNull(){} // RVA: 0x7FFD4F54AF40
        public void get_IsSpeaking(){} // RVA: 0x7FFD4F54B0E0
        public void SetNetworkPropertyFromHashtable(){} // RVA: 0x7FFD4F54B140
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void DoIsValueConsideredPressed(){} // RVA: 0x7FFD4F54B4E0
        public void GetGameObject_587(){} // RVA: 0x7FFD4E919180
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFD4E964790
        public void GetGameObject_DA1(){} // RVA: 0x7FFD4F54B640
        public void GetGameObject_C61(){} // RVA: 0x7FFD4F54B740
        public void GetGameObject_011(){} // RVA: 0x7FFD4F54B890
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFD4F54B8E0
        public void SetPosition(){} // RVA: 0x7FFD4F54BA10
        public void Start(){} // RVA: 0x7FFD4F54BC60
        public void GetGameObject_3C1(){} // RVA: 0x7FFD4F54BD00
        public void GetGameObject_B72(){} // RVA: 0x7FFD4F54BD50
        public void HasPlayerTagOfType(){} // RVA: 0x7FFD4F54BF60
        public void AttachNetworkComponentToPlayer(){} // RVA: 0x7FFD4F54C520
        public void InitializeNetworkSyncContainer_6D613B0497BA(){} // RVA: 0x7FFD4F54D5E0 | overloaded x2
        public void ComputehasVeryNegativeTrustLevel(){} // RVA: 0x7FFD4F54D050
        public void ResetNetworkWriteBuffer(){} // RVA: 0x7FFD4F54D140
        public void DoGetFileApiURL(){} // RVA: 0x7FFD4F54D150
        public void HasPlayerTagByComponent(){} // RVA: 0x7FFD4F54D210
        public void ClearVoiceAndNotifyVisibility(){} // RVA: 0x7FFD4F54D2F0
        public void get_AvatarScaleParameter(){} // RVA: 0x7FFD4F54D4D0
        public void DecryptPlayerEncryptionKey(){} // RVA: 0x7FFD4F54D5A0
        public void GetTransform_0E5(){} // RVA: 0x7FFD4E55BE20
        public void get_VoiceDistanceFar(){} // RVA: 0x7FFD4F54D9B0
        public void ComputeIsSelf(){} // RVA: 0x7FFD4F54DCF0
        public void ComputeisActiveAndE(){} // RVA: 0x7FFD4F54DDE0
        public void GetOrCreatePlayerAnimationController(){} // RVA: 0x7FFD4F54E340
        public void set_UploadProgressChanged(){} // RVA: 0x7FFD4F54E500
        public void get_caretBlinkRate(){} // RVA: 0x7FFD4F54E510
        public void GetActiveInHierarchy_0C3(){} // RVA: 0x7FFD4F54E520
        public void SyncMuteStateFromNetwork(){} // RVA: 0x7FFD4F54E600
        public void set_VoiceGain(){} // RVA: 0x7FFD4F54E780
        public void GetGameObject(){} // RVA: 0x7FFD4F54E850
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFD4F54E980
        public void IsLocalPlayerOrNoNetworkRef(){} // RVA: 0x7FFD4F54E990
        public void SetPlayerVoiceGainClamped(){} // RVA: 0x7FFD4F54EAB0
        public void GetTransform_FD1(){} // RVA: 0x7FFD4F54EB60
        public void SetPosition_461DC02BEB13(){} // RVA: 0x7FFD4F54F020
        public void GetTransform(){} // RVA: 0x7FFD4F54F1A0
        public void SetActive(){} // RVA: 0x7FFD4F54F220
        public void IsPlayerAvatarPoseValid(){} // RVA: 0x7FFD4F54F2F0
        public void TeleportToWithoutForce(){} // RVA: 0x7FFD4F54F360
        public void DoIsFriendsWith(){} // RVA: 0x7FFD4F54F530
        public void BuildPlayerNetworkDataSnapshot(){} // RVA: 0x7FFD4F54F5B0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFD4F54F7C0
        public void SetPlayerTagWithoutNotify(){} // RVA: 0x7FFD4F54F9F0
        public void SetPlayerTagWithoutNotify_FC1B86B92401(){} // RVA: 0x7FFD4F54FA00
        public void IsLocalPlayerOrInTrustGroup(){} // RVA: 0x7FFD4F54FCE0
        public void CloneSingle(){} // RVA: 0x7FFD4F54FEE0
        public void SelectAll(){} // RVA: 0x7FFD4F54FEF0
        public void UpdatePlayerVoiceAndAvatar(){} // RVA: 0x7FFD4F550AC0
        public void GetPlayerAvatarIdFromNetworkOwner(){} // RVA: 0x7FFD4F54ACD0
        public void SetAvatarObjectActiveFromLookup(){} // RVA: 0x7FFD4F550DB0
        public void GetAvatarObjectFromLookup(){} // RVA: 0x7FFD4F551010
        public void get_AssemblyReader(){} // RVA: 0x7FFD4EDE5D60
        public void get_ComponentIntValueAt192(){} // RVA: 0x7FFD4F5510F0
        public void DoLocalizeVariant(){} // RVA: 0x7FFD4F551240
        public void OnPlayerDisconnectCleanup_4389E9592372(){} // RVA: 0x7FFD4F5512F0
        public void ComputehasTrustedTrustLevel(){} // RVA: 0x7FFD4F551300
        public void get_TimelineController(){} // RVA: 0x7FFD4E96E2F0
        public void GetReplyMessage(){} // RVA: 0x7FFD4F5513F0
        public void __set_effectDistance__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFD4F551600
        public void get_VoiceVolumetricRadius(){} // RVA: 0x7FFD4F551680
        public void SetCallbackIfStringMatches(){} // RVA: 0x7FFD4F551A10
        public void set_membersOnly(){} // RVA: 0x7FFD4F140B50
        public void set_NetworkIDCollection(){} // RVA: 0x7FFD4F551BB0
        public void set_NetworkIDCollection_3FFCF9C3FE03(){} // RVA: 0x7FFD4F551C80
        public void set_StaticFloatProperty(){} // RVA: 0x7FFD4F551CE0
        public void SetFloatAndInvokeDelegate(){} // RVA: 0x7FFD4F551D40
        public void Invoke(){} // RVA: 0x7FFD4F551DC0
        public void AllocateNetworkEventWithThreeArgs(){} // RVA: 0x7FFD4F552060
        public void get_VoiceDistanceNear(){} // RVA: 0x7FFD4F552110
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E42F9E0
        public void IsReadyAndNetworkActive(){} // RVA: 0x7FFD4F552190
        public void IsReadyAndNetworkActive_DFA5D4C1065F(){} // RVA: 0x7FFD4F5522C0
        public void TruncateStringToMaxLength(){} // RVA: 0x7FFD4F552470
        public void get_RootTaskCollection(){} // RVA: 0x7FFD4F552480
        public void set_dpad(){} // RVA: 0x7FFD4F5526A0
        public void OnDestroy_impl(){} // RVA: 0x7FFD4F552700
        public void set_IsSpeaking(){} // RVA: 0x7FFD4F552880
        public void SetNetworkComponentFromJoinData(){} // RVA: 0x7FFD4F552B70
        public void GetPosition(){} // RVA: 0x7FFD4F552CB0
        public void ToString(){} // RVA: 0x7FFD4F552D90
        public void get_onValidateInput(){} // RVA: 0x7FFD4F552FB0
        public void TryFlushPendingVisibilityChange(){} // RVA: 0x7FFD4F553630
        public void DoReset(){} // RVA: 0x7FFD4E3BCD50
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F553750
        public void ComputerealtimeSinceStar(){} // RVA: 0x7FFD4F553910
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void get_onValueChanged(){} // RVA: 0x7FFD4F553AD0
        public void get_Playlist(){} // RVA: 0x7FFD4E818150
        public void CheckIsDone_1D0(){} // RVA: 0x7FFD4F553D70
        public void DoPlayHelper_6BE(){} // RVA: 0x7FFD4EDCF520
        public void ComputeTransformFromBufferPosition(){} // RVA: 0x7FFD4F553F90
        public void UpdateBipedIK(){} // RVA: 0x7FFD4E3F5BE0
        public void CreateAndRegisterNetworkCallback(){} // RVA: 0x7FFD4F5540C0
        public void SendBooleanNetworkEvent(){} // RVA: 0x7FFD4F554110
        public void CheckIsDone_E12(){} // RVA: 0x7FFD4F554160
        public void CheckIsDone_D9D(){} // RVA: 0x7FFD4F554250
        public void CompareExchangePlayerFieldAtOffset336(){} // RVA: 0x7FFD4F554260
        public void set_recentering(){} // RVA: 0x7FFD4EDC8050
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void ConfiguretriggerPressed(){} // RVA: 0x7FFD4F554460
        public void set_StaticFloatProperty_67276FA25C4D(){} // RVA: 0x7FFD4F554540
        public void IsPlayerNotBlockedByActorId(){} // RVA: 0x7FFD4F5545D0
        public void get_UploadLength(){} // RVA: 0x7FFD4E3AC5F0
        public void get_ActiveBlend(){} // RVA: 0x7FFD4E964EF0
        public void IsPlayerBlockedOrMuted(){} // RVA: 0x7FFD4F555370
        public void SetPlayerNetworkTimestampAtomic(){} // RVA: 0x7FFD4F54B890
        public void GetLocalOrRemotePlayerIdentity(){} // RVA: 0x7FFD4E409500
        public void ApplyAmountFromDoubledOrCopied(){} // RVA: 0x7FFD4F555420
        public void SetMuteIfNotLocal(){} // RVA: 0x7FFD4F5554D0
        public void IsPlayerNetworkSynced(){} // RVA: 0x7FFD4E341320
        public void IsPlayerPresentInWorldByNetworkId(){} // RVA: 0x7FFD4F5557F0
        public void ResolveNetworkPlayerReference(){} // RVA: 0x7FFD4F555890
        public void SerializePlayerPositionWithTimestamp(){} // RVA: 0x7FFD4F555940
        public void SetActive_366(){} // RVA: 0x7FFD4F555950
        public void ComputeisPlaying(){} // RVA: 0x7FFD4F555A80
        public void IsPlayerInCurrentWorldInstanceAlt(){} // RVA: 0x7FFD4F555B90
        public void GetTargets_4DDC1A1739B7(){} // RVA: 0x7FFD4E3DF370
        public void ForwardSerializerCall(){} // RVA: 0x7FFD4E341320
        public void SetForm(){} // RVA: 0x7FFD4EDC80B0
        public void ApplyAnimationStateToPlayer(){} // RVA: 0x7FFD4F555D80
        public void ForwardInputFlagToSerializer(){} // RVA: 0x7FFD4F555D90
        public void SetForm_F1BC0801CE48(){} // RVA: 0x7FFD4F556040
        public void PlayEmoteRPC(){} // RVA: 0x7FFD4F556170
        public void GetTypedComponentFromBuffer(){} // RVA: 0x7FFD4F556350
        public void GetPlayerSteamIdFromSingleton(){} // RVA: 0x7FFD4F5563B0
        public void GetTypedComponentFromBuffer_874C64E5619C(){} // RVA: 0x7FFD4F5563F0
        public void GetGameObject_4B6(){} // RVA: 0x7FFD4F556670
        public void SetVisibilityDirtyFlags(){} // RVA: 0x7FFD4F556800
        public void GetGameObject_CB0(){} // RVA: 0x7FFD4F5569A0
        public void SetEnabled_D26(){} // RVA: 0x7FFD4F556A20
        public void SetEnabled_95E(){} // RVA: 0x7FFD4F556B50
        public void SetEnabled_DE4(){} // RVA: 0x7FFD4F556B60
        public void SetEnabled_3F4(){} // RVA: 0x7FFD4F556C30
        public void SetEnabled_205(){} // RVA: 0x7FFD4F556DE0
        public void set_SerializedDataField(){} // RVA: 0x7FFD4F556E50
        public void InitializePlayerNetworkComponents(){} // RVA: 0x7FFD4F556EB0
        public void Getposition(){} // RVA: 0x7FFD4F556F00
        public void GetGameObject_187(){} // RVA: 0x7FFD4F557110
        public void GetGameObject_638(){} // RVA: 0x7FFD4F557460
        public void GetGameObject_197(){} // RVA: 0x7FFD4F557490
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void SetNetworkPropertyFlag(){} // RVA: 0x7FFD4F5575C0
        public void OnDestroy(){} // RVA: 0x7FFD4F557630
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFD4F557FB0
        public void get_statusDescription(){} // RVA: 0x7FFD4F5585D0
        public void get_membersOnly(){} // RVA: 0x7FFD4E7EE5C0
        public void get_onTextSelection(){} // RVA: 0x7FFD4EDE1920
        public void get_UploadProgressChanged(){} // RVA: 0x7FFD4F558670
        public void ShouldSyncPlayerDataThisFrame(){} // RVA: 0x7FFD4F558680
        public void GetPlayerAvatarDisplayName(){} // RVA: 0x7FFD4F558870
        public void CompareExchangePlayerFieldAtOffset336_AA84DA02697C(){} // RVA: 0x7FFD4F558A20
        public void set_NetworkIDLookup(){} // RVA: 0x7FFD4F558A90
        public void GetGameObject_017(){} // RVA: 0x7FFD4F558BD0
        public void GetGameObject_8BA(){} // RVA: 0x7FFD4F54D210
        public void GetDeltaTime_C44(){} // RVA: 0x7FFD4F180520
        public void ReplaceAndNormalizeComponentEntry(){} // RVA: 0x7FFD4F558C60
        public void .ctor(){} // RVA: 0x7FFD4F558D80
        public void Initialize(){} // RVA: 0x7FFD4F559520
        public void get_IsAlwaysTrue(){} // RVA: 0x7FFD4F559B30
        public void IsPlayerBlockedOrRestricted(){} // RVA: 0x7FFD4E426850
        public void get_Enabled(){} // RVA: 0x7FFD4F559B80
        public void set_app(){} // RVA: 0x7FFD4EDEF5C0
        public void SetNetworkSyncTarget(){} // RVA: 0x7FFD4F559B90
        public void InitializePlayerSyncTarget(){} // RVA: 0x7FFD4F559C50
        public void Doop_Subtraction_243C0AA61A44(){} // RVA: 0x7FFD4F55CEB0 | overloaded x2
        public void set_listingIds(){} // RVA: 0x7FFD4EDE51C0
        public void set_home(){} // RVA: 0x7FFD4EDD1270
        public void ApplyTrustLevelToNameplate(){} // RVA: 0x7FFD4F55B690
        public void DoFindRelativeTransformWithPath_65D(){} // RVA: 0x7FFD4F55B8A0
        public void get_contentList(){} // RVA: 0x7FFD4E960F70
        public void Decode(){} // RVA: 0x7FFD4F55B940
        public void SerializeNetworkSyncFields(){} // RVA: 0x7FFD4F55BB00
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFD4EDECB10
        public void GetSyncedParametersDefault(){} // RVA: 0x7FFD4F55BBF0
        public void GetActiveAvatarDescriptorComponent(){} // RVA: 0x7FFD4F55BC60
        public void get_gameObject(){} // RVA: 0x7FFD4F55C020
        public void IsActiveOrPendingDeactivation(){} // RVA: 0x7FFD4F55C030
        public void InvokeVirtualPropertyGetter(){} // RVA: 0x7FFD4F55C070
        public void hash(){} // RVA: 0x7FFD4F55C4D0
        public void SetPlayerAvatarNameplateText(){} // RVA: 0x7FFD4F55C6C0
        public void AllocateBooleanEventData(){} // RVA: 0x7FFD4F55C880
        public void hash_E5D10119E3F2(){} // RVA: 0x7FFD4F55CA90
        public void EnsureDictionaryAtOffset368(){} // RVA: 0x7FFD4F55CBA0
        public void InitializeAvatarStatePlayer(){} // RVA: 0x7FFD4F55DD00 | overloaded x2
        public void TryGetDictionaryValueByKey(){} // RVA: 0x7FFD4F55CC10
        public void get_StaticFloatProperty(){} // RVA: 0x7FFD4F55CC90
        public void OnEnable(){} // RVA: 0x7FFD4F55CDB0
        public void OnDisable(){} // RVA: 0x7FFD4F3655C0
        public void HasStoredDataAndNotStaticFlag(){} // RVA: 0x7FFD4F55CFA0
        public void .cctor(){} // RVA: 0x7FFD4F55D030
        public void DoInverse_Injecte(){} // RVA: 0x7FFD4F55D350
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFD4F365170
        public void ResetEnumeratorAndFlag(){} // RVA: 0x7FFD4E341320
        public void IsPlayerActiveInHierarchy(){} // RVA: 0x7FFD4F55D4F0
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFD4E9610C0
        public void ComputehasKnownTrustLevel(){} // RVA: 0x7FFD4F55DA00
        public void TryApplyPlayerPickupInteraction(){} // RVA: 0x7FFD4F55DBC0
        public void IsLocalPlayerOrStaticFlagSet(){} // RVA: 0x7FFD4F55DEC0
        public void IsPlayerObjectSynchronized(){} // RVA: 0x7FFD4F55E1D0
        public void get_RootTaskCollection_DEFDFB8C697F(){} // RVA: 0x7FFD4F55E320
        public void set_position(){} // RVA: 0x7FFD4E923010
        public void get_RootTaskCollection_7F832DCA152C(){} // RVA: 0x7FFD4F55E450
        public void GetTypeCode(){} // RVA: 0x7FFD4F55E570
        public void ReloadAvatarNetworkedRPC(){} // RVA: 0x7FFD4F55E580
        public void get_fontAsset(){} // RVA: 0x7FFD4EDCC670
        public void DoLocalizeVariant_8D64940B0397(){} // RVA: 0x7FFD4F551240
        public void get_AssemblyReader_73F0BA222A26(){} // RVA: 0x7FFD4F55E6B0
        public void get_NetworkStatusListener(){} // RVA: 0x7FFD4EDC6830
    }

    /// <summary>Originally: ÏÍÌÌÍÎÍÌÏÎÌÎÎÎÌÎÌÌÎÍÏÏÎ</summary>
    public class VRCPlayerSiblingSibling_0E3E
    {
        public object f_EBD;
        public object f_1E1;
        public object f_C30;
        public object f_489;
        public object f_387;
        public object f_C2F;
        public object f_D2A;
        public object f_216;
        public object f_5B2;

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E090980
        public void Computetransform(){} // RVA: 0x7FFD4E079D00
        public void get_enableAutoSizing(){} // RVA: 0x7FFD4E078E90
        public void Deconstruct(){} // RVA: 0x7FFD4E09AF60
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFD4E079D00
        public void IsLocalPlayerMaster(){} // RVA: 0x7FFD4E079D00
        public void SetEnabled_281(){} // RVA: 0x7FFD4E079D00
        public void GetBufferAsTypeSafe(){} // RVA: 0x7FFD4E079D00
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFD4E079D00
        public void ContainsChild_53E8CE579062(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_DB1CB10B8D12(){} // RVA: 0x7FFD4E090A40
        public void SetPlayerAnimatorFromNetworkObject(){} // RVA: 0x7FFD4E0788A0
        public void Awake(){} // RVA: 0x7FFD4E0788A0
        public void get_PlayerApiReference(){} // RVA: 0x7FFD4E078E90
        public void DoOpenURL_7CE(){} // RVA: 0x7FFD4E079F60
        public void Enable(){} // RVA: 0x7FFD4E091060
    }

    /// <summary>Originally: ÎÎÎÏÍÎÌÍÎÌÏÏÏÏÍÎÎÌÎÏÏÎÌ</summary>
    public class VRCPlayerSiblingSibling_6C8D : Object
    {
        public System.Action _name; // 0x10
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> _hideFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E919850
        public void Initialize(){} // RVA: 0x7FFD4E919A60
        public void Equals(){} // RVA: 0x7FFD4E919AD0
        public void op_Implicit(){} // RVA: 0x7FFD4E919C50
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E919E80
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E919FF0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E91A3A0
        public void get_name(){} // RVA: 0x7FFD4E91A410
        public void set_name(){} // RVA: 0x7FFD4E91A550
        public void Instantiate(){} // RVA: 0x7FFD4E91A8C0
        public void GetHashCode(){} // RVA: 0x7FFD4E91AA30
        public void ToString(){} // RVA: 0x7FFD4E91AC10
        public void ResolvePlayerAvatarFromNetworkState(){} // RVA: 0x7FFD4E91AE90
        public void ComputegameObject(){} // RVA: 0x7FFD4E91B070
        public void ReadTransformState(){} // RVA: 0x7FFD4E3447C0
        public void get_PlayerApiReference(){} // RVA: 0x7FFD4E91B160
        public void .ctor_6E68D1F3AB6F(){} // RVA: 0x7FFD4E91B290
        public void Initialize_5F16F856C3F7(){} // RVA: 0x7FFD4E91B400
        public void get_IsInvisible(){} // RVA: 0x7FFD4E91B530
        public void Destroy(){} // RVA: 0x7FFD4E91B6E0
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x7FFD4E91B7F0
        public void DestroyImmediate(){} // RVA: 0x7FFD4E91B920
        public void DestroyImmediate_0F751E223BC7(){} // RVA: 0x7FFD4E91B990
        public void FindObjectsOfType(){} // RVA: 0x7FFD4E91BB00
        public void set_statusDescription(){} // RVA: 0x7FFD4E91BC40
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void .cctor(){} // RVA: 0x7FFD4E91BD30
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4E3447C0
    }

    /// <summary>Originally: ÌÌÍÎÍÍÍÍÎÌÎÎÌÍÌÏÍÌÏÎÏÎÌ</summary>
    public class VRCPlayerSibling_3D33 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F1E2970
        public void RaiseCancellation(){} // RVA: 0x7FFD4F1E2CC0
        public void GetMaterial(){} // RVA: 0x7FFD4F1E3120
        public void CancelInvoke(){} // RVA: 0x7FFD4F1E32A0
        public void Invoke(){} // RVA: 0x7FFD4F1E32F0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F1E3360
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFD4F1E33C0
        public void set_name(){} // RVA: 0x7FFD4F1E37F0
        public void StartCoroutine(){} // RVA: 0x7FFD4F1E3840
        public void GetBufferAsTypeSafe(){} // RVA: 0x7FFD4F1E3A10
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFD4F1E3AC0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F1E3CE0
        public void StopCoroutine(){} // RVA: 0x7FFD4F1E3DF0
        public void ToScale(){} // RVA: 0x7FFD4F1E3F40
        public void Awake(){} // RVA: 0x7FFD4F1E40B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F1E4410
        public void set_useGUILayout(){} // RVA: 0x7FFD4F1E4790
        public void print(){} // RVA: 0x7FFD4F1E4A50
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F1E4AA0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F1E4B10
        public void InvokeDelayed(){} // RVA: 0x7FFD4F1E4F70
        public void CancelInvoke_A60ADDEE5BA9(){} // RVA: 0x7FFD4F1E4FC0
        public void GetGameObject_8A4(){} // RVA: 0x7FFD4F1E5040
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F1E55A0
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F1E5630
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F1E5680
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E341310
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4F1E5A00
        public void GetScriptClassName(){} // RVA: 0x7FFD4F1E5A60
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F1E5BB0
        public void ApplyPlayerVoiceVolume(){} // RVA: 0x7FFD4F1E5CC0
        public void SetNetworkSerializerFieldNull(){} // RVA: 0x7FFD4F1E5D10
        public void get_IsSpeaking(){} // RVA: 0x7FFD4F1E5D90
        public void SetNetworkPropertyFromHashtable(){} // RVA: 0x7FFD4F1E5E10
        public void GetMaterial_51B941EAA786(){} // RVA: 0x7FFD4F1E5FC0
        public void DoIsValueConsideredPressed(){} // RVA: 0x7FFD4F1E60A0
        public void GetGameObject_587(){} // RVA: 0x7FFD4F1E60F0
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFD4F1E6160
        public void SetMonitoredReferenceWithExceptionHandling(){} // RVA: 0x7FFD4F1E6270
        public void GetGameObject_C61(){} // RVA: 0x7FFD4F1E62D0
        public void GetGameObject_011(){} // RVA: 0x7FFD4F1E6730
        public void InvokeRoomPropertyAction(){} // RVA: 0x7FFD4F1E6770
        public void SetPosition(){} // RVA: 0x7FFD4F1E69E0
        public void Start(){} // RVA: 0x7FFD4F1E6A40
        public void GetGameObject_3C1(){} // RVA: 0x7FFD4F1E6CF0
        public void GetGameObject_B72(){} // RVA: 0x7FFD4F1E6D40
        public void HasPlayerTagOfType(){} // RVA: 0x7FFD4F1E6DC0
        public void AttachNetworkComponentToPlayer(){} // RVA: 0x7FFD4F1E6F80
        public void SetMonitoredReferenceWithExceptionHandling_68EAC6E12ABF(){} // RVA: 0x7FFD4F1E6F90
        public void ComputehasVeryNegativeTrustLevel(){} // RVA: 0x7FFD4F1E7090
        public void ResetNetworkWriteBuffer(){} // RVA: 0x7FFD4F1E7220
        public void GetPhotonRoomPropertyValue(){} // RVA: 0x7FFD4F1E7670
        public void HasPlayerTagByComponent(){} // RVA: 0x7FFD4F1E76E0
        public void OnEnable(){} // RVA: 0x7FFD4F1E7740
        public void get_AvatarScaleParameter(){} // RVA: 0x7FFD4F1E7840
        public void InvokeStaticVoidMethod(){} // RVA: 0x7FFD4F1E78B0
        public void UpdateActive(){} // RVA: 0x7FFD4F1E7900
        public void InitializeNetworkSyncContainer(){} // RVA: 0x7FFD4F1E7A10
        public void AssignPhotonRoomInstance(){} // RVA: 0x7FFD4F1E7BA0
        public void Computeenabled(){} // RVA: 0x7FFD4F1E7EF0
        public void ComputeisActiveAndE(){} // RVA: 0x7FFD4F1E8000
        public void Start_4D849DD8E6B5(){} // RVA: 0x7FFD4F1E8050
        public void set_UploadProgressChanged(){} // RVA: 0x7FFD4F1E80C0
        public void get_caretBlinkRate(){} // RVA: 0x7FFD4F1E8130
        public void GetActiveInHierarchy_0C3(){} // RVA: 0x7FFD4F1E8230
        public void SyncMuteStateFromNetwork(){} // RVA: 0x7FFD4F1E8300
        public void set_VoiceGain(){} // RVA: 0x7FFD4F1E8860
        public void GetGameObject(){} // RVA: 0x7FFD4F1E8BB0
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFD4F1E8C00
        public void IsLocalPlayerOrNoNetworkRef(){} // RVA: 0x7FFD4F1E8CD0
        public void SetPlayerVoiceGainClamped(){} // RVA: 0x7FFD4F1E8D90
        public void GetTransform_FD1(){} // RVA: 0x7FFD4F1E8DE0
        public void Start_8865CA760C61(){} // RVA: 0x7FFD4F1E8E60
        public void GetTransform(){} // RVA: 0x7FFD4F1E8FC0
        public void SetActive(){} // RVA: 0x7FFD4F1E9020
        public void IsPlayerAvatarPoseValid(){} // RVA: 0x7FFD4F1E91F0
        public void TeleportToWithoutForce(){} // RVA: 0x7FFD4F1E9240
        public void set_size_Injected(){} // RVA: 0x7FFD4F1E92C0
        public void ConfigureAssetPreloader(){} // RVA: 0x7FFD4F1E93E0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFD4F1E9730
        public void get_activeInHierarchy(){} // RVA: 0x7FFD4F1E98B0
        public void SetPlayerTagWithoutNotify(){} // RVA: 0x7FFD4F1E99C0
        public void IsLocalPlayerOrInTrustGroup(){} // RVA: 0x7FFD4F1E9B10
        public void CloneSingle(){} // RVA: 0x7FFD4F1E8BB0
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7FFD4F1E9C20
        public void UpdatePlayerVoiceAndAvatar(){} // RVA: 0x7FFD4F1E9C80
        public void GetPlayerAvatarIdFromNetworkOwner(){} // RVA: 0x7FFD4F1E9DE0
        public void get_RoundTripVariance(){} // RVA: 0x7FFD4F1E9EA0
        public void get_destroyCancellationToken_D41FDC064A32(){} // RVA: 0x7FFD4F1EA540
    }

    /// <summary>Originally: ÌÏÏÏÎÌÎÍÌÍÏÍÍÏÎÏÎÎÍÏÎÌÌ</summary>
    public class VRCPlayerSibling_A428
    {
        public int f_673;
        public System.Collections.Generic.KeyValuePair`2<string,object> f_45B;
        public LogValues`3<U,V,T> f_3E6;
        public int f_D2A;
        public object f_3C3;
        public object f_367;

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E078E90
        public void Computetransform(){} // RVA: 0x7FFD4E078E90
        public void get_enableAutoSizing(){} // RVA: 0x7FFD4E078E90
        public void set_NetworkSerializerReference(){} // RVA: 0x7FFD4E0788A0
        public void get_disclaimerText(){} // RVA: 0x7FFD4E0788A0
        public void get_IsStaticInstanceFlagSet(){} // RVA: 0x7FFD4E0788A0
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFD4E0788A0
        public void IsLocalPlayerMaster(){} // RVA: 0x7FFD4E079D00
        public void Enable(){} // RVA: 0x7FFD4E091060
    }

    /// <summary>Originally: ÌÍÎÍÍÎÌÌÌÍÍÏÏÌÎÍÎÍÎÎÎÎÎ</summary>
    public class VRCPlayerSibling_AFD7 : Object
    {
        public System.Action _name; // 0x10
        public VRC.Core.APIUser _hideFlags; // 0x18
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> f_489; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EB91530
        public void Equals(){} // RVA: 0x7FFD4EB91570
        public void GetHashCode(){} // RVA: 0x7FFD4E341320
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EB915B0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD4EB91640
        public void Initialize(){} // RVA: 0x7FFD4E3447C0
        public void set_name(){} // RVA: 0x7FFD4EB91740
        public void Instantiate(){} // RVA: 0x7FFD4EB91830
        public void ToString(){} // RVA: 0x7FFD4E426850
        public void ToString_11376EAB1E90(){} // RVA: 0x7FFD4EB91870
        public void PerformCriticalCleanup(){} // RVA: 0x7FFD4EB919F0
        public void ComputegameObject(){} // RVA: 0x7FFD4E365210
        public void Awake(){} // RVA: 0x7FFD4E426850
        public void get_PlayerApiReference(){} // RVA: 0x7FFD4E341320
        public void .ctor_D0A8475FC849(){} // RVA: 0x7FFD4EB91A30
        public void Initialize_7DFC0741BE80(){} // RVA: 0x7FFD4EB91A70
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x7FFD4EB91B60
        public void Destroy(){} // RVA: 0x7FFD4EB91BA0
        public void InitializePlayerNetworkSerialization(){} // RVA: 0x7FFD4EB91C90
        public void DestroyImmediate(){} // RVA: 0x7FFD4E341320
        public void Init_1FC32922BB8C(){} // RVA: 0x7FFD4E3A7E80
        public void FindObjectsOfType(){} // RVA: 0x7FFD4EB91CD0
        public void set_statusDescription(){} // RVA: 0x7FFD4EB91D10
        public void FindObjectsByType(){} // RVA: 0x7FFD4E341320
        public void .cctor(){} // RVA: 0x7FFD4E364D80
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EB91D50
    }

}