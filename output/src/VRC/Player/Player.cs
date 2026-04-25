// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Player
// Classes: 53
// Methods: 1644

namespace VRC.Player
{
    /// <summary>Originally: ÍÍÍÎÏÍÍÏÍÍÎÍÌÎÏÏÎÍÎÎÌÌÏ</summary>
    public class PlayerBackgroundNameIsVRCPlus_AA53
    {
        public object _backgroundName;
        public object _preview;
        public object _isVRCPlus;

        // ── Methods ──
        public void get_BackgroundName(){} // RVA: 0x7FFAC2C588A0
        public void get_Preview(){} // RVA: 0x7FFAC2C58E90
        public void get_IsVRCPlus(){} // RVA: 0x7FFAC2C59D00
        public void set_IsVRCPlus(){} // RVA: 0x7FFAC2C58E90
        public void set_Preview(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÏÍÎÌÌÌÎÍÏÎÍÏÍÍÌÎÏÏÏÏÎÎÌ</summary>
    public class PlayerCalculateLayoutInputHorizCalculateLayout_5653_5653 : LayoutGroup
    {
        public float _padding; // 0x60
        public float _childAlignment; // 0x64
        public float _rectTransform; // 0x68
        public float _rectChildren; // 0x6C
        public bool _minWidth; // 0x70
        public bool ÌÍÎÌÎÌÏÍÏÌÌÎÏÏÎÍÎÎÌÍÍÎÌ; // 0x71
        public bool ÌÍÏÍÌÏÍÎÏÎÍÌÎÌÌÎÏÍÏÍÏÎÏ; // 0x72
        public bool ÍÍÎÌÍÏÎÍÎÏÌÏÌÌÎÍÏÌÌÎÌÏÌ; // 0x73
        public 0x6B00DB30 m_StartAxis; // 0x74
        public System.Collections.Generic.IList`1<UnityEngine.RectTransform> ÏÍÌÎÎÎÏÎÍÌÏÌÎÏÌÎÎÏÍÌÌÌÏ; // 0x78

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFAC43D8210
        public void SetLayoutVertical(){} // RVA: 0x7FFAC43D82E0
        public void get_childAlignment(){} // RVA: 0x7FFAC43D82F0
        public void set_childAlignment(){} // RVA: 0x7FFAC43D83B0
        public void get_rectTransform(){} // RVA: 0x7FFAC43D8410
        public void .ctor(){} // RVA: 0x7FFAC43D8430
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC43D8500
        public void SetLayoutHorizontal(){} // RVA: 0x7FFAC43D86E0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC43D86F0
        public void get_preferredWidth(){} // RVA: 0x7FFAC43D88C0
        public void get_flexibleWidth(){} // RVA: 0x7FFAC43D8910
        public void get_minHeight(){} // RVA: 0x7FFAC43D92D0
        public void get_preferredHeight(){} // RVA: 0x7FFAC43D9720
        public void get_flexibleHeight(){} // RVA: 0x7FFAC43D97F0
        public void OnDisable(){} // RVA: 0x7FFAC43D9850
        public void SetLayoutHorizontal_E6AE6256811D(){} // RVA: 0x7FFAC43D98B0
        public void SetLayoutVertical_06148619B63F(){} // RVA: 0x7FFAC43D9980
        public void UpdatePadding(){} // RVA: 0x7FFAC43D99A0
        public void OnEnable(){} // RVA: 0x7FFAC43D9DE0
        public void ReadComponentState(){} // RVA: 0x7FFAC43D9E00
        public void get_DefaultBufferSize(){} // RVA: 0x7FFAC43D9E20
        public void GetTotalMinSize(){} // RVA: 0x7FFAC43D9E30
        public void GetTotalPreferredSize(){} // RVA: 0x7FFAC43DA990
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFAC43DA9E0
        public void GetStartOffset(){} // RVA: 0x7FFAC43DAAB0
    }

    /// <summary>Originally: ÌÎÍÏÍÌÏÌÏÍÌÎÎÌÎÌÎÌÌÍÍÎÌ</summary>
    public class PlayerCalculateLayoutInputHorizCalculateLayout_9DC6_9DC6 : GridLayoutGroup
    {
        public float ÍÌÏÍÍÏÎÏÍÌÏÌÌÎÎÌÏÌÍÎÍÌÌ;
        public float _flexibleWidth; // 0x80
        public float _flexibleHeight; // 0x84

        // ── Methods ──
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC36F3C20
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC36F3F20
        public void .ctor(){} // RVA: 0x7FFAC36F4140
    }

    /// <summary>Originally: ÌÏÏÍÏÌÏÍÌÍÌÍÍÍÏÌÏÏÎÎÌÌÏ</summary>
    public class PlayerControllerColliderHitHandler_0C8C_0C8C : MonoBehaviour
    {
        public ÌÎÌÍÎÌÌÍÏÏÍÍÍÎÍÌÍÎÎÎÍÏÎ ÎÌÏÎÌÎÎÌÎÎÍÎÎÌÎÎÌÌÍÏÍÍÎ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4214CD0
        public void RaiseCancellation(){} // RVA: 0x7FFAC4214F60
        public void IsInvoking(){} // RVA: 0x7FFAC42151F0
        public void CancelInvoke(){} // RVA: 0x7FFAC4215480
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC4215710
        public void SetCancellationCallback(){} // RVA: 0x7FFAC42159A0
        public void OnControllerColliderHit(){} // RVA: 0x7FFAC4215C30
    }

    /// <summary>Originally: ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ</summary>
    public class PlayerControllerColliderHitHandler_1F75_1F75 : MonoBehaviour
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
        public 0x6B0203D8 ÏÎÏÏÎÎÎÎÎÎÌÍÍÎÎÏÎÌÎÎÍÏÍ; // 0xD4
        public float ÎÌÎÏÌÏÏÌÌÎÏÏÎÏÌÏÍÌÌÏÏÍÏ; // 0xD8
        public bool ÌÏÍÌÏÎÏÍÎÎÎÎÎÏÌÏÌÌÍÍÎÍÌ; // 0xDC

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4737390
        public void RaiseCancellation(){} // RVA: 0x7FFAC4738030
        public void get_swapBumpers(){} // RVA: 0x7FFAC4738160
        public void CancelInvoke(){} // RVA: 0x7FFAC4738170
        public void OnDestroy(){} // RVA: 0x7FFAC4738E10
        public void OnControllerColliderHit_BEDB0985F036(){} // RVA: 0x7FFAC4738E60
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7FFAC4738E80
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFAC4738E90
        public void StartCoroutine(){} // RVA: 0x7FFAC4738EA0
        public void Reset(){} // RVA: 0x7FFAC4738EB0
        public void OnCollisionStay(){} // RVA: 0x7FFAC4739090
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC47390F0
        public void SetProgress(){} // RVA: 0x7FFAC3717190
        public void StopCoroutine(){} // RVA: 0x7FFAC4739150
        public void OnTriggerExit(){} // RVA: 0x7FFAC47392F0
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFAC47394B0
        public void get_useGUILayout(){} // RVA: 0x7FFAC47394C0
        public void set_useGUILayout(){} // RVA: 0x7FFAC47394D0
        public void set_meanLine(){} // RVA: 0x7FFAC47394E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC47394F0
        public void Awake(){} // RVA: 0x7FFAC473A8C0
        public void InvokeDelayed(){} // RVA: 0x7FFAC473A900
        public void set_swapBumpers(){} // RVA: 0x7FFAC473AAC0
        public void get_cageUpdateEveryFrame(){} // RVA: 0x7FFAC3332010
        public void set_invertStickY(){} // RVA: 0x7FFAC473AAD0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC473AAE0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC473AFA0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC473A8C0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC4738160
        public void GetScriptClassName(){} // RVA: 0x7FFAC473AFC0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC473AFD0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC473B070
        public void OnCollisionEnter(){} // RVA: 0x7FFAC473B390
        public void OnCollisionExit(){} // RVA: 0x7FFAC473B540
        public void OnControllerColliderHit_BED45B471A23(){} // RVA: 0x7FFAC473B550
        public void .ctor(){} // RVA: 0x7FFAC473B590
        public void Initialize(){} // RVA: 0x7FFAC473B7E0
        public void set_swapSticks(){} // RVA: 0x7FFAC473BA00
        public void HandleColliderHit(){} // RVA: 0x7FFAC473BA10
        public void set_inContact(){} // RVA: 0x7FFAC2F5BAC0
        public void ProcessColliderHit(){} // RVA: 0x7FFAC473BBB0
        public void get_AlignmentAxis(){} // RVA: 0x7FFAC473BBC0
        public void Start(){} // RVA: 0x7FFAC473BBE0
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFAC392CE00
        public void Update(){} // RVA: 0x7FFAC473C0C0
        public void get_Progress(){} // RVA: 0x7FFAC3716E90
        public void OnControllerColliderHit(){} // RVA: 0x7FFAC473C0D0
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFAC3C40670
        public void get_swapSticks(){} // RVA: 0x7FFAC473C630
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFAC3000230
        public void OnBecameVisible(){} // RVA: 0x7FFAC473C630
        public void OnDestroy_E5EE5FD706E0(){} // RVA: 0x7FFAC4738E10
        public void UpdateColliderState(){} // RVA: 0x7FFAC473C640
        public void set_swapBumpers_3B8C8230B1B9(){} // RVA: 0x7FFAC473AAC0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFAC3816470
        public void OnTriggerEnter(){} // RVA: 0x7FFAC47394B0
    }

    /// <summary>Originally: ÍÎÏÏÎÍÎÎÎÏÌÎÎÍÌÍÏÍÍÍÎÌÏ</summary>
    public class PlayerCustomInputTextEdited_1259_1259 : ComplexComponentImpl_A727_A727
    {
        public TMPro.TMP_InputField customInputText; // 0x1F0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _customInputPlaceholderText; // 0x1F8
        public UnityEngine.UI.Button _editTextButton; // 0x200
        public string ÎÌÏÍÏÌÎÍÎÎÎÏÍÏÏÎÌÎÌÎÏÏÎ; // 0x208
        public ÌÍÎÍÏÏÎÌÌÏÏÏÏÏÎÏÍÌÎÍÎÎÍ ÏÌÌÌÏÏÏÏÎÏÏÌÌÌÍÎÌÏÎÏÎÌÎ; // 0x210

        // ── Methods ──
        public void OnCustomInputTextEdited(){} // RVA: 0x7FFACB4B0E10
        public void .ctor(){} // RVA: 0x7FFACB30A050
        public void Initialize(){} // RVA: 0x7FFACB4B10C0
        public void OnApplicationPause(){} // RVA: 0x7FFACB4B10E0
        public void OnApplicationQuit(){} // RVA: 0x7FFACB4B13C0
        public void Awake(){} // RVA: 0x7FFACB4B1680
        public void OnDestroy(){} // RVA: 0x7FFACB4B1740
        public void HandlePlayerInputTextObject(){} // RVA: 0x7FFACB4B1790
        public void Initialize_39E38C3C02D0(){} // RVA: 0x7FFACB4B10C0
        public void OnCollisionEnter(){} // RVA: 0x7FFACB4B1A70
        public void Awake_5A1BCB77FFEF(){} // RVA: 0x7FFACB4B1D50
        public void Start(){} // RVA: 0x7FFACB4B2030
        public void OnTriggerExit(){} // RVA: 0x7FFACB4B2090
        public void Initialize_918FBB1E988D(){} // RVA: 0x7FFACB4B10C0
        public void Initialize_DA765644722F(){} // RVA: 0x7FFACB4B10C0
    }

    /// <summary>Originally: ÌÌÎÌÏÌÎÌÏÍÌÏÏÏÌÍÌÎÌÎÍÏÍ</summary>
    public class PlayerIsInteractivePickupUseDown_C325_C325 : VRCInteractable
    {
        public System.Action`2<0x6B029F90,bool> _isInteractive;
        public System.Action`1<0x6B029F90> ÌÍÌÍÎÏÎÍÍÌÍÍÌÌÍÎÏÌÎÍÍÏÌ; // 0x8
        public 0x6B029F90 InteractableType; // 0x40
        public ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ ÎÍÌÎÍÎÍÎÌÌÍÎÏÏÌÎÍÎÍÌÌÌÏ; // 0x48

        // ── Methods ──
        public void OnPickupUseDown(){} // RVA: 0x7FFAC3368150
        public void OnPickup(){} // RVA: 0x7FFAC3368170
        public void get_IsInteractive_19C42D36BABD(){} // RVA: 0x7FFAC33681D0
        public void Interact_69B77CDCC803(){} // RVA: 0x7FFAC3368300
        public void Awake(){} // RVA: 0x7FFAC3368430
        public void .ctor(){} // RVA: 0x7FFAC3368510
        public void Initialize(){} // RVA: 0x7FFAC3368520
        public void OnDrop_BAA2F1537118(){} // RVA: 0x7FFAC3368650
        public void OnDrop(){} // RVA: 0x7FFAC3368780
        public void set_IsInteractive(){} // RVA: 0x7FFAC33687E0
        public void CheckPlayerInteractivePickupState(){} // RVA: 0x7FFAC3368910
        public void Interact(){} // RVA: 0x7FFAC3368A40
        public void get_IsInteractive(){} // RVA: 0x7FFAC3006850
        public void EvaluatePlayerInteractivePickupUseDown(){} // RVA: 0x7FFAC3368AA0
    }

    /// <summary>Originally: ÎÌÍÍÏÌÌÍÏÎÏÎÌÏÎÎÌÌÎÏÌÏÌ</summary>
    public class PlayerJoinedPlayerLeftHandler_8B85_8B85 : MonoBehaviour
    {
        public System.DateTime ÌÌÎÍÌÍÎÏÎÏÍÌÎÌÌÏÌÎÎÎÍÏÎ; // 0x20
        public bool ÏÍÍÎÏÎÍÏÏÎÎÏÏÍÏÎÏÎÎÎÎÎÌ; // 0x28
        public System.Action`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÌÎÏÏÌÏÍÌÌÍÏÎÌÍÍÌÌÌÌÌÍÌÌ;
        public ÎÌÍÍÏÌÌÍÏÎÏÎÌÏÎÎÌÌÎÏÌÏÌ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ; // 0x8
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.HashSet`1<int>> ÎÎÏÏÍÍÏÏÎÌÏÍÌÌÌÎÎÌÌÌÍÏÌ; // 0x10
        public System.Collections.Generic.List`1<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ> ÏÏÎÏÏÎÌÎÏÏÎÌÍÏÏÍÍÌÎÎÍÏÍ; // 0x18

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC3A971E0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3A97390
        public void IsInvoking(){} // RVA: 0x7FFAC3A97450
        public void CancelInvoke(){} // RVA: 0x7FFAC3A97840
        public void Invoke(){} // RVA: 0x7FFAC3A97A00
        public void InvokeRepeating(){} // RVA: 0x7FFAC3A97B60
        public void OnDisable(){} // RVA: 0x7FFAC3A982E0
        public void IsInvoking_275FA00D084F(){} // RVA: 0x7FFAC3A98500
        public void StartCoroutine(){} // RVA: 0x7FFAC3A98650
        public void OnPlayerJoined(){} // RVA: 0x7FFAC3A98710
        public void .ctor(){} // RVA: 0x7FFAC3A98800
        public void Initialize(){} // RVA: 0x7FFAC3A988A0
        public void StopCoroutine(){} // RVA: 0x7FFAC3A98A80
        public void Start(){} // RVA: 0x7FFAC3A98C20
        public void Update(){} // RVA: 0x7FFAC3A98F50
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3A990B0
        public void .cctor(){} // RVA: 0x7FFAC3A99490
        public void set_useGUILayout(){} // RVA: 0x7FFAC3A99630
        public void print(){} // RVA: 0x7FFAC3A997B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3A998E0
        public void OnPlayerLeft(){} // RVA: 0x7FFAC3A999D0
        public void InvokeDelayed(){} // RVA: 0x7FFAC3A99A90
        public void OnDestroy(){} // RVA: 0x7FFAC3A9A450
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3A9A6B0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3A9A8D0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3A9AC90
    }

    /// <summary>Originally: ÏÍÍÌÏÍÎÍÍÏÏÍÍÎÏÍÎÍÎÎÏÏÍ</summary>
    public class PlayerJoinedPlayerLeft_F5C6_F5C6 : Object
    {
        public System.Collections.Generic.HashSet`1<int> _f5C6; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT ÏÌÎÏÍÍÍÌÎÍÌÎÏÍÍÏÌÏÌÌÏÌÎ; // 0x18
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ ÌÏÍÎÏÍÌÎÏÌÎÌÌÏÌÍÍÏÏÌÍÌÎ; // 0x20
        public VRC.Core.Networking.Codec.StateManagement.PersistenceObjectStateManager ÍÎÏÏÍÍÎÏÏÏÎÏÏÍÌÏÏÏÍÏÎÎÍ; // 0x28
        public System.Collections.Generic.Dictionary`2<string,byte[]> ÏÎÎÏÌÌÏÌÍÎÎÎÌÏÎÏÎÎÍÌÏÍÎ;
        public System.Collections.Generic.Dictionary`2<string,byte[]> ÎÌÌÎÏÎÎÏÍÍÎÌÎÌÍÌÏÌÎÌÍÍÏ; // 0x8

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3DD7710
        public void Equals(){} // RVA: 0x7FFAC3DD7A80
        public void GetHashCode(){} // RVA: 0x7FFAC3DD7DC0
        public void op_Implicit(){} // RVA: 0x7FFAC3DD8080
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3DD80C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3DD8120
        public void GetCachedPtr(){} // RVA: 0x7FFAC3DD85E0
        public void get_name(){} // RVA: 0x7FFAC3DD86F0
        public void set_name(){} // RVA: 0x7FFAC3DD8A30
        public void .cctor(){} // RVA: 0x7FFAC3DD8AD0
        public void Instantiate(){} // RVA: 0x7FFAC3DD8C50
        public void ToString(){} // RVA: 0x7FFAC3DD90E0
        public void OnPlayerLeft(){} // RVA: 0x7FFAC3DD9110
        public void .ctor_B1516F861635(){} // RVA: 0x7FFAC3DD93F0
        public void OnPlayerJoined(){} // RVA: 0x7FFAC3DD9880
        public void .ctor(){} // RVA: 0x7FFAC3DD9DD0
        public void Initialize(){} // RVA: 0x7FFAC3DDB640
        public void ProcessPlayerSystemMessage(){} // RVA: 0x7FFAC3DDB920
        public void Destroy(){} // RVA: 0x7FFAC3DDB980
        public void PlayerJoinedPlayerLeft(){} // RVA: 0x7FFAC3DDBA00
        public void GetNodeSetData(){} // RVA: 0x7FFAC3DDBA80
        public void DestroyImmediate(){} // RVA: 0x7FFAC3DDBAA0
        public void PlayerJoinedPlayerLeft_1CC394797991(){} // RVA: 0x7FFAC3DDBB10
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3DDBE90
        public void PlayerJoinedPlayerLeft_E5D369FA006B(){} // RVA: 0x7FFAC3DDBEA0
        public void FindObjectsByType(){} // RVA: 0x7FFAC3DDBF10
        public void PlayerJoinedPlayerLeft_1175A20CFE91(){} // RVA: 0x7FFAC3DDC270
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3DDC370
        public void get_hideFlags(){} // RVA: 0x7FFAC3DD80C0
        public void set_hideFlags(){} // RVA: 0x7FFAC3DDC690
    }

    /// <summary>Originally: ÏÍÍÎÎÏÎÌÎÌÌÍÏÎÎÏÏÍÏÌÏÍÌ</summary>
    public class PlayerLeftHandlerImpl_4B35_4B35 : PlayerLeftHandler_7766_7766
    {
        public ÏÌÍÎÏÍÌÌÎÏÍÎÍÍÌÎÌÍÎÌÏÌÎ f_B66; // 0xC0
        public UnityEngine.LayerMask f_31F; // 0xC8
        public 0x6B000668 ÌÌÌÌÌÏÎÌÏÎÌÎÏÌÏÌÌÎÏÏÏÏÏ; // 0xCC
        public 0x6B000668 ÌÎÌÎÍÎÏÍÏÎÍÎÍÌÏÎÏÍÍÎÍÏÍ; // 0xD0
        public 0x6B00A380 pointerUsage; // 0xD4

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4304EF0
        public void CheckModuleActivationCondition(){} // RVA: 0x7FFAC4304F60
        public void setReadOnly(){} // RVA: 0x7FFAC4305250
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAC3696B20
        public void OnEnable(){} // RVA: 0x7FFAC4305910
        public void InvokeRepeating(){} // RVA: 0x7FFAC4305A00
        public void UpdateLifecycleState(){} // RVA: 0x7FFAC4304EF0
        public void OnAttachedToHand(){} // RVA: 0x7FFAC4305BC0
        public void OnDisable(){} // RVA: 0x7FFAC4305CF0
        public void FixedUpdate(){} // RVA: 0x7FFAC4305E20
        public void get_AudioCaptureSource_F7399BABC1E6(){} // RVA: 0x7FFAC3696B20
        public void Awake(){} // RVA: 0x7FFAC3798890
        public void OnDestroy(){} // RVA: 0x7FFAC43060D0
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFAC4306300
        public void .ctor(){} // RVA: 0x7FFAC4306540
        public void LateUpdate(){} // RVA: 0x7FFAC4306560
        public void get_pointerBehavior(){} // RVA: 0x7FFAC43065A0
        public void get_AudioCaptureSource_9562312159C7(){} // RVA: 0x7FFAC3696B20
    }

    /// <summary>Originally: ÌÏÏÍÏÎÏÎÍÎÎÍÎÎÏÏÌÍÎÌÏÌÎ</summary>
    public class PlayerLeftHandlerImpl_5F7E_5F7E : PlayerLeftHandler_7766_7766
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
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC4302AA0
        public void Awake_482C69232443(){} // RVA: 0x7FFAC3798890
        public void Awake(){} // RVA: 0x7FFAC3798890
        public void OnDestroy(){} // RVA: 0x7FFAC3798890
        public void Awake_A4FBD8E7D79E(){} // RVA: 0x7FFAC3798890
        public void Initialize(){} // RVA: 0x7FFAC4303350
        public void .ctor(){} // RVA: 0x7FFAC4303730
        public void Awake_704C45022A97(){} // RVA: 0x7FFAC3798890
        public void LateUpdate(){} // RVA: 0x7FFAC43037C0
        public void FixedUpdate(){} // RVA: 0x7FFAC4303D50
        public void Save(){} // RVA: 0x7FFAC43040B0
        public void HasPointerInputActivity(){} // RVA: 0x7FFAC4304630
        public void Awake_1AFBA5BAE83F(){} // RVA: 0x7FFAC3798890
    }

    /// <summary>Originally: ÏÎÍÍÎÏÏÍÍÏÌÍÍÏÌÏÎÌÎÎÏÍÍ</summary>
    public class PlayerLeftHandlerImpl_734E_734E : PlayerLeftHandler_7766_7766
    {
        public float ÍÏÎÏÌÌÏÎÌÎÎÎÍÏÎÎÍÎÎÏÌÏÌ;
        public float ÏÎÏÌÏÎÌÏÎÌÏÌÌÍÌÎÏÎÌÍÍÌÎ;
        public UnityEngine.UI.Image ÍÍÏÎÎÎÌÍÎÌÍÌÎÏÎÏÍÍÌÎÏÍÏ; // 0xC0
        public ÏÎÍÌÌÍÍÌÎÌÏÍÎÏÌÏÏÌÌÎÌÏÍ ÎÏÎÍÏÎÏÌÌÌÏÌÎÏÍÌÌÏÏÍÌÏÌ; // 0xC8
        public float ÏÏÏÌÍÏÍÎÌÏÌÎÏÎÍÏÌÎÍÌÎÏÌ;
        public UnityEngine.Vector3 ÍÌÏÍÎÌÍÍÌÏÍÎÍÎÏÏÎÍÍÎÎÌÏ; // 0xD0

        // ── Methods ──
        public void GetTransformLossyScale(){} // RVA: 0x7FFAC42FD680
        public void .ctor(){} // RVA: 0x7FFAC42FD810
        public void Initialize(){} // RVA: 0x7FFAC42FD8F0
        public void UpdateJobData(){} // RVA: 0x7FFAC42FDDB0
        public void Awake_72DBB3B19E43(){} // RVA: 0x7FFAC3798890
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFAC42FEAF0
        public void OnDestroy(){} // RVA: 0x7FFAC42FEBB0
        public void ReadColliderState(){} // RVA: 0x7FFAC42FEC80
        public void Awake(){} // RVA: 0x7FFAC3798890
        public void FixedUpdate(){} // RVA: 0x7FFAC42FED60
        public void ReadColliderState_6136DEC30AB8(){} // RVA: 0x7FFAC42FEC80
        public void set_bodyPositionInternal(){} // RVA: 0x7FFAC42FEE50
        public void StopCoroutine(){} // RVA: 0x7FFAC42FED60
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFAC42FF180
        public void OnDisable(){} // RVA: 0x7FFAC42FF4B0
    }

    /// <summary>Originally: ÎÏÏÍÎÏÍÍÎÏÏÍÍÏÎÎÌÎÎÍÏÎÏ</summary>
    public class PlayerLeftHandlerImpl_B1FA_B1FA : PlayerLeftHandler_7766_7766
    {
        public UnityEngine.LineRenderer ÍÌÍÌÍÍÎÏÍÍÎÍÎÏÍÌÌÍÎÏÌÍÎ; // 0xC0
        public ÏÎÍÌÌÍÍÌÎÌÏÍÎÏÌÏÏÌÌÎÌÏÍ ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0xC8
        public UnityEngine.Color ÍÎÌÍÎÍÏÌÍÍÎÍÍÍÌÌÎÌÌÏÍÍÍ; // 0xD0
        public UnityEngine.Color ÍÌÎÎÍÏÌÍÏÍÎÎÎÌÎÏÏÍÎÍÌÎÎ; // 0xE0
        public 0x6B000668 ÌÌÌÌÌÏÎÌÏÎÌÎÏÌÏÌÌÎÏÏÏÏÏ; // 0xF0
        public 0x6B000668 ÌÎÌÎÍÎÏÍÏÎÍÎÍÌÏÎÏÍÍÎÍÏÍ; // 0xF4
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
        public void Equals(){} // RVA: 0x7FFAC3798260
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC3798340
        public void .ctor(){} // RVA: 0x7FFAC3798440
        public void Initialize(){} // RVA: 0x7FFAC3798660
        public void .cctor(){} // RVA: 0x7FFAC3798770
        public void InvokeRepeating(){} // RVA: 0x7FFAC37987B0
        public void Awake_1AFBA5BAE83F(){} // RVA: 0x7FFAC3798890
        public void OnEnable_A8F6820E4A0E(){} // RVA: 0x7FFAC37988B0
        public void Awake_A4FBD8E7D79E(){} // RVA: 0x7FFAC3798890
        public void FindRelativeTransformWithPath(){} // RVA: 0x7FFAC3798930
        public void OnEnable(){} // RVA: 0x7FFAC3799B20
        public void OnDisable(){} // RVA: 0x7FFAC3799B30
        public void Awake(){} // RVA: 0x7FFAC3798890
    }

    /// <summary>Originally: ÏÍÎÎÎÏÍÍÌÌÌÏÏÌÏÏÌÏÌÎÍÎÍ</summary>
    public class PlayerLeftHandler_4F25_4F25 : MonoBehaviour
    {
        public ÏÍÎÎÎÏÍÍÌÌÌÏÏÌÏÏÌÏÌÎÍÎÍ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ;
        public ÏÏÌÎÌÍÍÏÌÌÎÎÎÌÏÏÎÏÏÏÏÎÎ ÌÎÎÏÏÌÏÎÏÌÍÏÌÏÍÍÏÎÏÍÎÌÎ; // 0x20
        public int ÌÎÎÏÍÏÎÎÌÏÍÎÍÏÌÏÎÍÍÌÍÎÌ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC35F83A0
        public void RaiseCancellation(){} // RVA: 0x7FFAC35F83B0
        public void LogError(){} // RVA: 0x7FFAC3141EE0
        public void CancelInvoke(){} // RVA: 0x7FFAC35F8780
        public void Invoke(){} // RVA: 0x7FFAC35F8A10
        public void InvokeRepeating(){} // RVA: 0x7FFAC3141EE0
        public void CancelInvoke_3373EFA354FB(){} // RVA: 0x7FFAC35F8F80
        public void OnPlayerLeft(){} // RVA: 0x7FFAC35F9310
        public void StartCoroutine(){} // RVA: 0x7FFAC35F9400
        public void .ctor(){} // RVA: 0x7FFAC35F9650
        public void Initialize(){} // RVA: 0x7FFAC35F9730
        public void Awake(){} // RVA: 0x7FFAC35F9970
        public void OnDestroy(){} // RVA: 0x7FFAC35FA420
        public void StopCoroutine(){} // RVA: 0x7FFAC35FA690
        public void FixedUpdate(){} // RVA: 0x7FFAC35FA750
        public void StopAllCoroutines(){} // RVA: 0x7FFAC35F83A0
        public void get_useGUILayout(){} // RVA: 0x7FFAC35FA780
        public void set_useGUILayout(){} // RVA: 0x7FFAC35FA860
        public void print(){} // RVA: 0x7FFAC35FAA50
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC35FAF00
        public void Internal_IsInvokingAll_B10F87D2FC38_B10F87D2FC38(){} // RVA: 0x7FFAC35FFC20 | overloaded x2
        public void InvokeDelayed(){} // RVA: 0x7FFAC3141EE0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC35FB730
        public void IsInvoking_5EC4A9FB421A_5EC4A9FB421A(){} // RVA: 0x7FFAC35FDC60 | overloaded x2
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC35FB880
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC35FBF30
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC35FC150
        public void Start(){} // RVA: 0x7FFAC35FCA20
        public void GetScriptClassName_36AB6805E085_36AB6805E085(){} // RVA: 0x7FFAC35FD4C0 | overloaded x2
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC35FDA40
        public void HandlePointerHover(){} // RVA: 0x7FFAC35FDC80
        public void OnApplicationPause(){} // RVA: 0x7FFAC35FDE50
        public void OnApplicationQuit(){} // RVA: 0x7FFAC35FDEB0
        public void OnBecameVisible(){} // RVA: 0x7FFAC35FE280
        public void DoRender_CFD(){} // RVA: 0x7FFAC35FEB50
        public void OnEnable(){} // RVA: 0x7FFAC35FEC00
        public void OnCollisionStay(){} // RVA: 0x7FFAC35FEC60
        public void OnCollisionExit(){} // RVA: 0x7FFAC35FEE80
        public void OnTriggerEnter(){} // RVA: 0x7FFAC35FF080
        public void OnTriggerStay(){} // RVA: 0x7FFAC35FF270
        public void OnTriggerExit(){} // RVA: 0x7FFAC35FF4B0
        public void HandlePointerHoverUseGUILayout(){} // RVA: 0x7FFAC35FF530
        public void HandlePointerDrag(){} // RVA: 0x7FFAC35FF8E0
        public void Update(){} // RVA: 0x7FFAC35FFD80
        public void LateUpdate(){} // RVA: 0x7FFAC35FFF60
        public void OnDisable(){} // RVA: 0x7FFAC3600410
    }

    /// <summary>Originally: ÍÎÌÍÏÏÌÍÍÍÍÍÍÏÏÎÏÎÌÏÍÎÎ</summary>
    public class PlayerLeftHandler_7766_7766 : MonoBehaviour
    {
        public bool _destroyCancellationToken; // 0x20
        public bool _useGUILayout; // 0x21
        public 0x6B00A8A8 f_1F1; // 0x24
        public UnityEngine.Vector3 f_F0C; // 0x28
        public ÏÎÏÎÍÎÍÎÎÎÍÌÌÌÌÏÌÏÍÎÌÎÏ f_E50; // 0x38
        public ÎÏÌÎÏÍÏÍÌÍÍÎÌÌÍÌÏÌÍÏÌÍÌ f_367; // 0x40
        public ÎÏÌÎÏÍÏÍÌÍÍÎÌÌÍÌÏÌÍÏÌÍÌ f_D2A; // 0x48
        public 0x6B169B98 ÍÎÏÍÎÍÌÏÎÎÏÍÍÏÍÏÎÌÍÍÍÌÎ; // 0x50
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC2C70980
        public void get_EyeFollowingBlendshapesValid(){} // RVA: 0x7FFAC322AD20
        public void setReadOnly(){} // RVA: 0x7FFAC376A610
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void InitPayloadEncryption(){} // RVA: 0x7FFAC34D4AA0
        public void InvokeRepeating(){} // RVA: 0x7FFAC4312F20
        public void UpdateLifecycleState(){} // RVA: 0x7FFAC4312F60
        public void OnEnable(){} // RVA: 0x7FFAC4312FA0
        public void StartCoroutine(){} // RVA: 0x7FFAC4312FC0
        public void FixedUpdate(){} // RVA: 0x7FFAC43130C0
        public void Start(){} // RVA: 0x7FFAC43131C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC43132C0
        public void StopCoroutine(){} // RVA: 0x7FFAC43133C0
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFAC3F45170
        public void OnDisable(){} // RVA: 0x7FFAC3F455C0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3F3B4F0
        public void Return(){} // RVA: 0x7FFAC2C76500
        public void set_useGUILayout(){} // RVA: 0x7FFAC43133D0
        public void print(){} // RVA: 0x7FFAC4314770
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC4315FE0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC4316310
        public void InvokeDelayed(){} // RVA: 0x7FFAC43165F0
        public void get_ExecutingTaskCollection_0ED30A51855C(){} // RVA: 0x7FFAC4317DA0
        public void OnPlayerLeft(){} // RVA: 0x7FFAC4317EC0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC4317F40
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC4317F50
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC4318070
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC43180A0
        public void Initialize(){} // RVA: 0x7FFAC43184E0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC4318760
    }

    /// <summary>Originally: ÏÎÎÏÎÌÏÎÎÏÎÏÏÌÌÍÍÎÎÍÍÎÌ</summary>
    public class PlayerLeft_342ASibling_064C
    {
        // ── Unresolved (hash) ──
        public void m_7EF(){}
        public void m_3CC(){}
        public void m_E36(){} // RVA: 0x7FFAC2C70A40
        public void m_C1B(){}
    }

    /// <summary>Originally: ÏÍÌÍÌÍÌÌÏÏÏÌÎÌÍÏÍÏÏÎÏÍÎ</summary>
    public class PlayerLeft_342A_342A : Object
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
        public void GetInstanceID(){} // RVA: 0x7FFAC322C870
        public void .ctor(){} // RVA: 0x7FFAC32BC4B0
        public void Initialize(){} // RVA: 0x7FFAC32BC9C0
        public void op_Implicit(){} // RVA: 0x7FFAC32BCC70
        public void CompareBaseObjects(){} // RVA: 0x7FFAC32BCFE0
        public void ReadByte(){} // RVA: 0x7FFAC32BD0E0
        public void GetCachedPtr(){} // RVA: 0x7FFAC32BD0F0
        public void get_name(){} // RVA: 0x7FFAC32BD9A0
        public void set_name(){} // RVA: 0x7FFAC32BDC50
        public void Instantiate(){} // RVA: 0x7FFAC32BDDC0
        public void GetHashCode_3CC01A28EBC0_3CC01A28EBC0(){} // RVA: 0x7FFAC32BE560 | overloaded x2
        public void OnPlayerLeft(){} // RVA: 0x7FFAC32BE8D0
        public void ToString(){} // RVA: 0x7FFAC32BE960
        public void Equals(){} // RVA: 0x7FFAC322C870
        public void ReadByte_4684E94449A7(){} // RVA: 0x7FFAC32BD0E0
        public void .cctor(){} // RVA: 0x7FFAC32BEA70
        public void GetInstanceID_E3680B2F7442(){} // RVA: 0x7FFAC32BEB70
    }

    /// <summary>Originally: ÎÎÌÍÏÌÍÎÍÎÍÍÌÌÎÍÏÎÍÎÎÎÍ</summary>
    public class PlayerLeft_6AD7_6AD7 : Object
    {
        public string ÍÏÏÌÌÌÌÌÌÌÌÌÌÍÎÌÌÌÎÍÌÎÍ;
        public ÌÍÍÍÌÎÎÎÍÌÎÍÍÍÌÎÌÏÏÍÎÍÍ ÎÎÏÌÎÌÎÌÌÌÌÍÌÌÎÌÌÌÌÍÎÌÎ;

        // ── Methods ──
        public void OnPlayerLeft(){} // RVA: 0x7FFAC3167190
        public void Equals(){} // RVA: 0x7FFAC31674F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC31680A0 | overloaded x4
        public void get_name_7DAAC6C7D31D_7DAAC6C7D31D(){} // RVA: 0x7FFAC3168300 | overloaded x2
        public void set_name(){} // RVA: 0x7FFAC31686B0
        public void Instantiate(){} // RVA: 0x7FFAC3169AB0
        public void ToString(){} // RVA: 0x7FFAC3169F90
        public void GetHashCode_D55DB89F72AE(){} // RVA: 0x7FFAC316A7F0
        public void GetInternalHashCode(){} // RVA: 0x7FFAC316ACA0
        public void ResolveConstantValue(){} // RVA: 0x7FFAC316B310
        public void op_Implicit(){} // RVA: 0x7FFAC316B6F0
        public void ResolveConstantValue_829B1CEF78AB(){} // RVA: 0x7FFAC316BE70
        public void ResolveConstantValue_10B992422EF7(){} // RVA: 0x7FFAC316BFF0
        public void .cctor(){} // RVA: 0x7FFAC316C170
    }

    /// <summary>Originally: ÌÎÏÍÎÎÌÎÏÍÏÎÍÎÍÌÌÌÌÎÎÍÏ</summary>
    public class PlayerManuallyRecordInteractionGetIsPlayingCon_5B6A_5B6A : VRCPropApi
    {
        public ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ ÍÌÏÎÌÎÎÏÍÎÌÌÌÌÍÍÎÌÎÏÏÎÌ; // 0x10
        public UnityEngine.GameObject ÍÌÎÏÏÍÍÏÎÏÏÏÎÏÍÏÏÏÎÌÍÏÌ; // 0x18
        public UnityEngine.Transform ÎÍÌÍÎÍÍÍÍÌÌÏÎÍÎÏÎÎÍÏÍÎÌ; // 0x20
        public System.Collections.Generic.List`1<VRC.SDKBase.VRCPlayerApi> ÍÏÏÎÍÎÍÍÌÎÌÏÏÎÌÌÏÏÌÎÌÎÌ;
        public int ÏÎÌÏÏÎÎÏÌÏÏÍÏÎÌÍÌÌÌÎÎÎÏ;
        public int ÏÏÏÌÌÌÌÏÏÌÍÍÏÏÎÍÍÏÏÌÌÎÍ;
        public System.Lazy`1<string> ÌÎÌÎÍÌÏÌÌÌÎÎÍÌÎÎÏÌÌÏÌÍÌ; // 0x8

        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7FFAC334F990
        public void GetPropId(){} // RVA: 0x7FFAC334FD60
        public void GetRotation(){} // RVA: 0x7FFAC334FDC0
        public void RequestDespawn(){} // RVA: 0x7FFAC334FE40
        public void GetSpawner_7168835B028E(){} // RVA: 0x7FFAC3350030
        public void GetUserAttributes(){} // RVA: 0x7FFAC33503D0
        public void .cctor(){} // RVA: 0x7FFAC3350530
        public void ReadComponentState(){} // RVA: 0x7FFAC3350770
        public void GetSpawner(){} // RVA: 0x7FFAC3350B10
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7FFAC3350C10
        public void GetItemId(){} // RVA: 0x7FFAC3350CB0
        public void GetScale(){} // RVA: 0x7FFAC3350D10
        public void GetQuantity(){} // RVA: 0x7FFAC3350DA0
        public void GetQuantity_5C4567B1F66E(){} // RVA: 0x7FFAC3350E30
        public void RequestConsume(){} // RVA: 0x7FFAC33511D0
        public void GetPlayersInRange(){} // RVA: 0x7FFAC33522B0 | overloaded x2
        public void StartPlayingConsumableEffect_BC7EF74D4DE1(){} // RVA: 0x7FFAC3351550
        public void StopPlayingConsumableEffect(){} // RVA: 0x7FFAC3351910
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7FFAC3351A90
        public void GetIsConsumable(){} // RVA: 0x7FFAC3351AB0
        public void SetUserAttributes_1CED01B56B9D(){} // RVA: 0x7FFAC3351B40
        public void CheckInteractionState(){} // RVA: 0x7FFAC3351EE0
        public void GetPosition(){} // RVA: 0x7FFAC3352320
        public void StartPlayingConsumableEffect(){} // RVA: 0x7FFAC33523B0
        public void SetGameObjectActive(){} // RVA: 0x7FFAC3352530
        public void GetNearestPlayerInRange(){} // RVA: 0x7FFAC3352900
        public void .ctor(){} // RVA: 0x7FFAC33529B0
        public void SetUserAttributes(){} // RVA: 0x7FFAC3352B60
    }

    /// <summary>Originally: ÍÏÌÎÌÎÏÎÍÏÌÎÍÏÌÏÎÎÍÍÌÏÍ</summary>
    public class PlayerModComponentHealthRelated_F88E
    {
        public object _f88E;

        // ── Methods ──
        public void InvokeDelegate(){} // RVA: 0x7FFAC2C59D00
        public void BeginInvoke(){}
    }

    /// <summary>Originally: ÍÍÏÍÏÍÌÏÌÌÎÎÍÌÎÎÏÍÌÍÌÎÌ</summary>
    public class PlayerModComponentHealthSiblinSibling_504A
    {
        public object f_FEF;
        public object f_E56;
        public object f_9B5;
        public object f_527;

        // ── Methods ──
        public void Deconstruct(){} // RVA: 0x7FFAC2C7AF60
        public void DebugReturn(){} // RVA: 0x7FFAC2C71580
        // ── Unresolved (hash) ──
        public void m_747(){} // RVA: 0x7FFAC2C59D00
        public void m_66D(){} // RVA: 0x7FFAC2C70A40
        public void m_47B(){} // RVA: 0x7FFAC2C70A40
        public void m_1A0(){} // RVA: 0x7FFAC2C58E90
        public void m_6EA(){} // RVA: 0x7FFAC2C70980
        public void m_77F(){} // RVA: 0x7FFAC2C79B30
        public void m_A4A(){} // RVA: 0x7FFAC2C58E90
        public void m_A03(){} // RVA: 0x7FFAC2C58E90
        public void m_A56(){} // RVA: 0x7FFAC2C58E90
    }

    /// <summary>Originally: ÍÏÎÎÌÎÍÌÏÌÌÍÍÏÌÏÍÍÎÏÎÎÌ</summary>
    public class PlayerModComponentHealthSibling_B72C_B72C : Object
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
        public void GetInstanceID(){} // RVA: 0x7FFAC3C46840
        public void Equals(){} // RVA: 0x7FFAC2F4F0C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F4F0C0
        public void op_Implicit(){} // RVA: 0x7FFAC3C46BA0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3C46EF0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3C47200
        public void Finalize(){} // RVA: 0x7FFAC3C47430
        public void get_name(){} // RVA: 0x7FFAC2F21320
        public void set_name(){} // RVA: 0x7FFAC3C47580
        public void Instantiate(){} // RVA: 0x7FFAC3C477B0
        public void ToString(){} // RVA: 0x7FFAC3C478B0
        public void set_TypeId(){} // RVA: 0x7FFAC3C47970
        public void GetMaxHealth(){} // RVA: 0x7FFAC3C47A70
        public void OnCollisionStay(){} // RVA: 0x7FFAC3C47CA0
        public void .ctor(){} // RVA: 0x7FFAC3C47DC0
        public void Initialize(){} // RVA: 0x7FFAC3C48090
        public void OnTriggerStay(){} // RVA: 0x7FFAC3C48140
        public void SetXMotion(){} // RVA: 0x7FFAC3C481D0
        public void ReadTransformState(){} // RVA: 0x7FFAC2F247C0
        public void Destroy(){} // RVA: 0x7FFAC3C48380
        public void SetupVisualDamage(){} // RVA: 0x7FFAC3C483D0
        public void DestroyImmediate(){} // RVA: 0x7FFAC3C484C0
        public void Pop(){} // RVA: 0x7FFAC3C486F0
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3C499A0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void FindObjectsByType(){} // RVA: 0x7FFAC3C49A00
        public void LateUpdate(){} // RVA: 0x7FFAC3C49F00
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3C4A490
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
    }

    /// <summary>Originally: ÌÏÎÎÍÏÌÌÎÍÏÍÏÌÍÌÏÏÎÎÍÍÏ</summary>
    public class PlayerModComponentHealth_BF44 : NetworkReadyHandler_68D0_68D0
    {
        public VRCSDK2.VRC_CombatSystem _typeId; // 0x58
        public float f_8D0; // 0x60
        public float ÎÍÌÎÎÍÍÎÌÏÏÎÏÎÎÌÌÏÌÍÏÎÏ; // 0x64
        public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÎÏÌÎÌÌÍÌÌÌÌÏÍÍÌÏÍÍÎÌÌÌÏ; // 0x68
        public UnityEngine.Coroutine ÎÎÍÍÍÏÏÎÏÌÏÏÌÍÌÍÎÌÌÌÏÍÏ; // 0x70
        public UnityEngine.Transform ÌÎÏÎÏÌÍÏÍÏÌÍÎÏÌÏÎÌÌÎÌÌÏ; // 0x78
        public UnityEngine.Transform ÌÍÏÌÏÎÌÎÎÎÍÌÏÏÍÏÎÌÍÏÍÎÌ; // 0x80
        public VRC_VisualDamage ÌÍÌÍÌÏÎÌÎÌÍÎÏÏÍÎÏÏÎÎÌÏÎ; // 0x88
        public UnityEngine.GameObject ÎÍÏÍÏÍÍÎÍÍÏÏÏÌÌÌÌÏÏÌÏÍÏ; // 0x90
        public bool ÏÍÍÏÎÌÏÌÍÌÌÍÍÍÏÍÎÌÎÌÌÎÌ; // 0x98
        public float ÍÏÏÌÎÎÎÌÏÍÌÌÏÍÏÏÍÎÎÌÍÎÏ; // 0x9C
        public UnityEngine.Transform ÌÍÏÎÍÌÎÏÌÌÎÏÍÍÌÏÍÌÍÍÏÌÌ; // 0xA0
        public bool ÍÍÍÏÌÏÌÎÍÏÌÎÏÎÏÏÏÏÌÌÌÏÏ; // 0xA8
        public ÎÌÎÌÏÎÏÍÎÏÌÍÏÏÌÏÌÌÎÎÌÏÍ ÍÎÍÎÏÍÎÌÍÏÎÍÍÏÎÍÎÏÍÎÌÍÌ; // 0xB0
        public UnityEngine.GameObject ÍÌÎÏÍÌÏÌÌÌÎÍÌÏÏÍÍÌÏÌÎÎÏ; // 0xB8

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC3ED7710
        public void Respawn(){} // RVA: 0x7FFAC3ED7A90
        public void Decode(){} // RVA: 0x7FFAC3ED84E0 | overloaded x2
        public void SerializedName(){} // RVA: 0x7FFAC3ED8170
        public void Update(){} // RVA: 0x7FFAC3ED82E0
        public void GetTypeCode(){} // RVA: 0x7FFAC36AE2C0
        public void OnDisable(){} // RVA: 0x7FFAC3ED8490
        public void OnApplicationPause(){} // RVA: 0x7FFAC3ED8520
        public void GetState(){} // RVA: 0x7FFAC3ED85C0
        public void ResetHealthRPC(){} // RVA: 0x7FFAC3ED8690
        public void set_TypeId(){} // RVA: 0x7FFAC2F21320
        public void GetMaxHealth(){} // RVA: 0x7FFAC3031E10
        public void OnCollisionStay(){} // RVA: 0x7FFAC3ED8A80
        public void GetCurrentHealth(){} // RVA: 0x7FFAC2F4A040
        public void get_TypeId(){} // RVA: 0x7FFAC3ED8E80
        public void OnTriggerStay(){} // RVA: 0x7FFAC313BE20
        public void SetXMotion(){} // RVA: 0x7FFAC3ED8E90
        public void print(){} // RVA: 0x7FFAC3ED8F60
        public void GetCurrentHealth_913666F390F4(){} // RVA: 0x7FFAC2F4A040
        public void SetupVisualDamage(){} // RVA: 0x7FFAC3ED9000
        public void InvokeDelayed(){} // RVA: 0x7FFAC3ED9690
        public void SetState(){} // RVA: 0x7FFAC3ED98D0
        public void Start(){} // RVA: 0x7FFAC3ED9950
        public void ShowDeath(){} // RVA: 0x7FFAC3ED99F0
        public void ApplyHealing(){} // RVA: 0x7FFAC3ED9DF0
        public void LateUpdate(){} // RVA: 0x7FFAC3006850
        public void Encode(){} // RVA: 0x7FFAC3EDAC10 | overloaded x2
        public void CanSerialize32Bit(){} // RVA: 0x7FFAC2F21320
        public void ComputeHealthHash(){} // RVA: 0x7FFAC3EDA070
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3EDA310
        public void OnBecameVisible(){} // RVA: 0x7FFAC3EDA3B0
        public void EndDeath(){} // RVA: 0x7FFAC3EDA420
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3EDA820
        public void NeedsSync(){} // RVA: 0x7FFAC3006850
        public void ApplyDamage(){} // RVA: 0x7FFAC3EDAC30
        public void ComputeHealthHash_DC0A5EE4AC1F(){} // RVA: 0x7FFAC3EDAFD0
        public void OnDestroy(){} // RVA: 0x7FFAC3EDB100
        public void ApplyHealthUpdate(){} // RVA: 0x7FFAC3EDB240
        public void .ctor(){} // RVA: 0x7FFAC3EDB280
        public void Initialize(){} // RVA: 0x7FFAC3EDB330
        public void NeedsImportant(){} // RVA: 0x7FFAC2F21320
        public void set_iconImageUrl(){} // RVA: 0x7FFAC354E360
        public void CanSerialize8Bit(){} // RVA: 0x7FFAC3006850
    }

    /// <summary>Originally: ÏÎÍÌÍÎÌÌÎÎÍÌÎÍÏÎÍÌÏÌÍÎÏ</summary>
    public class PlayerNetSibling_733B_733B : Object
    {
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A430> _name; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A430> _hideFlags; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A488> f_2CD; // 0x20
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> f_8F8; // 0x28
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<float> f_C98; // 0x30
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A4E0> f_172; // 0x38
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A4E0> f_E80; // 0x40
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
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void Equals(){} // RVA: 0x7FFAC3644CA0
        public void GetHashCode(){} // RVA: 0x7FFAC3644CD0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3644CF0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void GetCachedPtr(){} // RVA: 0x7FFAC3644D10
        public void get_name(){} // RVA: 0x7FFAC3644D30
        public void set_name(){} // RVA: 0x7FFAC2F247C0
        public void Instantiate(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC3644D50
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3644D80
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void StopCoroutine(){} // RVA: 0x7FFAC3644DB0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3644DE0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3644E00
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F4F0C0
        public void SetOverlay(){} // RVA: 0x7FFAC3644E30
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void Destroy(){} // RVA: 0x7FFAC3644E70
        public void UpdateGeometry(){} // RVA: 0x7FFAC3644EB0
        public void DestroyImmediate(){} // RVA: 0x7FFAC3644EE0
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3644F00
        public void FindObjectsByType(){} // RVA: 0x7FFAC3644F30
        public void Updatevelocity_Inj(){} // RVA: 0x7FFAC3644F50
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC36452A0
        public void get_hideFlags(){} // RVA: 0x7FFAC36452C0
        public void set_hideFlags(){} // RVA: 0x7FFAC36453C0
        public void Equals_A39209201B01(){} // RVA: 0x7FFAC36453F0
        public void FindObjectOfType(){} // RVA: 0x7FFAC3645420
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC3645440
        public void GetAnimationClipLength(){} // RVA: 0x7FFAC3645DB0
        public void CheckNullArgument(){} // RVA: 0x7FFAC3645DD0
        public void SetClampedNetworkedFloat392(){} // RVA: 0x7FFAC3645E00
        public void SyncPlayerNetwork(){} // RVA: 0x7FFAC3645E30
        public void HandlePlayerDisconnect(){} // RVA: 0x7FFAC3645F30
        public void .ctor(){} // RVA: 0x7FFAC3645F50
        public void Initialize(){} // RVA: 0x7FFAC3647120
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void op_Inequality(){} // RVA: 0x7FFAC3647150
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC2F9E740
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC2F9C730
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC3647180
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAC36471A0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAC36471C0
        public void SetStateMachine(){} // RVA: 0x7FFAC36471E0
        public void InitializePlayerNet(){} // RVA: 0x7FFAC3647B50
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC3647B80
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void MatchesCachedString(){} // RVA: 0x7FFAC3647BB0
        public void RefreshOverlayState(){} // RVA: 0x7FFAC3647BE0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAC3648150
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFAC36471A0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void GetNetworkProperty296(){} // RVA: 0x7FFAC3648170
        public void DoRandomRangeInt_A2E(){} // RVA: 0x7FFAC36481A0
    }

    /// <summary>Originally: ÌÍÎÎÎÏÏÏÏÌÎÌÌÎÌÏÏÏÎÌÎÎÎ</summary>
    public class PlayerNetSibling_DAA5_DAA5 : Object
    {
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> _name; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> _hideFlags; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<0x6B16A3D8> f_2EC; // 0x20
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
        public 0x6B16A3D8 f_557; // 0xC0
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÌÌÎÎÌÌÏÏÌÍÌÌÌÏÏÏÍÏÌÎÍÍÍ; // 0xC8
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÏÌÎÌÍÌÍÍÍÍÌÍÎÏÎÎÏÎÎÌÌÌÏ; // 0xD0
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÍÌÍÎÎÏÎÍÎÏÍÌÌÎÏÏÏÎÏÎÍÌÏ; // 0xD8
        public ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ ÍÌÍÏÍÌÌÏÎÍÏÏÏÏÎÍÎÎÍÍÌÎÍ; // 0xE0
        public System.Collections.Generic.Dictionary`2<int,ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ> ÍÍÍÎÏÍÌÎÎÎÎÏÏÍÎÌÎÏÏÍÌÌÌ; // 0xE8

        // ── Methods ──
        public void get_taglineText(){} // RVA: 0x7FFAC354B1A0
        public void Equals(){} // RVA: 0x7FFAC365B890
        public void GetHashCode(){} // RVA: 0x7FFAC365B920
        public void op_Implicit(){} // RVA: 0x7FFAC365B960
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC365BB20
        public void GetCachedPtr(){} // RVA: 0x7FFAC365BBB0
        public void get_name(){} // RVA: 0x7FFAC365BD70
        public void set_name(){} // RVA: 0x7FFAC365BE00
        public void Instantiate(){} // RVA: 0x7FFAC365BE90
        public void ToString(){} // RVA: 0x7FFAC365C050
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC365C0E0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void StopCoroutine(){} // RVA: 0x7FFAC365C2A0
        public void GetIKSolver_ADDE6B72844A(){} // RVA: 0x7FFAC2F9C730
        public void StopAllCoroutines(){} // RVA: 0x7FFAC365C330
        public void .ctor(){} // RVA: 0x7FFAC365C3C0
        public void Initialize(){} // RVA: 0x7FFAC365DF00
        public void print(){} // RVA: 0x7FFAC365DF90
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void Destroy(){} // RVA: 0x7FFAC365E020
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void FindObjectsByType(){} // RVA: 0x7FFAC365E0B0
        public void Updatevelocity_Inj(){} // RVA: 0x7FFAC365E4B0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC365E660
        public void get_hideFlags(){} // RVA: 0x7FFAC365E820
        public void set_hideFlags(){} // RVA: 0x7FFAC365E9E0
        public void IsNetworkPropertyFlagSetR(){} // RVA: 0x7FFAC365EA70
        public void GetAudioTracks(){} // RVA: 0x7FFAC32EF640
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void DoInternal_FromEu(){} // RVA: 0x7FFAC365EC30
        public void FindObjectOfType(){} // RVA: 0x7FFAC2F4F0C0
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC365F760
        public void DoLookRotation_In(){} // RVA: 0x7FFAC365F7F0
        public void GetPlayerNetworkFloat400(){} // RVA: 0x7FFAC365F9B0
        public void GetRect(){} // RVA: 0x7FFAC365FB70
        public void op_Equality(){} // RVA: 0x7FFAC365FC00
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC365FDC0
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC365FE50
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC2F247C0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAC2F3C380
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAC365FEE0
        public void get_selectHandler(){} // RVA: 0x7FFAC365FF70
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void get_cageDownsample(){} // RVA: 0x7FFAC313B720
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC3660000
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFAC31D95E0
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAC36601C0
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void DoInternal_FromEu_C761435AD75E(){} // RVA: 0x7FFAC3660380
        public void GetNetworkProperty296(){} // RVA: 0x7FFAC3660410
        public void ReportGeneralErrors(){} // RVA: 0x7FFAC3660670
        public void GetNetworkProperty296_B040FA321306(){} // RVA: 0x7FFAC3660700
        public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
        public void Instantiate_917EF0D3DB34(){} // RVA: 0x7FFAC36608C0
        public void get_verticalScrollbar(){} // RVA: 0x7FFAC3660950
        public void GetNetworkProperty408(){} // RVA: 0x7FFAC3660B10
        public void GetTextTracks_BFB661E3642E(){} // RVA: 0x7FFAC354DFB0
        public void Decode(){} // RVA: 0x7FFAC3660CD0
        public void ComputeisDone(){} // RVA: 0x7FFAC3660E90
        public void DoDestroy(){} // RVA: 0x7FFAC3661050
        public void Encode(){} // RVA: 0x7FFAC3661210
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void GetObjectComponentValueConditional(){} // RVA: 0x7FFAC36613D0
        public void IsInvoking(){} // RVA: 0x7FFAC3661590
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFAC3661750
    }

    /// <summary>Originally: ÍÏÍÏÌÍÎÏÏÌÌÏÎÌÌÍÏÎÌÎÍÎÎ</summary>
    public class PlayerNetSibling_FDD3
    {
        public object f_C13;
        public object f_673;
        public object f_C0D;
        public object f_DD3;

        // ── Methods ──
        public void OnTriggerExit(){} // RVA: 0x7FFAC2C588A0
        public void Encode(){} // RVA: 0x7FFAC2C58E90
        public void SetPlayerNetworkState(){} // RVA: 0x7FFAC2C58E90
        public void AddSubtraction(){} // RVA: 0x7FFAC2C58E90
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÌÍÌÌÍÌÍÍÍÍÌÍÏÌÏÎÌÎÍÎÎÌÌ</summary>
    public class PlayerNet_7F0A : NetworkReadyHandler_68D0_68D0
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
        public 0x6B16A488 f_C98; // 0x160
        public float f_E80; // 0x164
        public float f_CC2; // 0x168
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> f_96B; // 0x170

        // ── Methods ──
        public void OnTriggerExit(){} // RVA: 0x7FFAC363CF50
        public void Encode(){} // RVA: 0x7FFAC3640510 | overloaded x2
        public void SetPlayerNetworkState(){} // RVA: 0x7FFAC363D040
        public void AddSubtraction(){} // RVA: 0x7FFAC363D060
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFAC2F8C600
        public void InvokeRepeating(){} // RVA: 0x7FFAC363D0A0
        public void OnEnable(){} // RVA: 0x7FFAC363D0C0
        public void ProcessNetworkData(){} // RVA: 0x7FFAC363D100
        public void ExecuteNetworkHandlerMethod(){} // RVA: 0x7FFAC363D170
        public void GetNetworkStatusZero(){} // RVA: 0x7FFAC363D1A0
        public void LateUpdate(){} // RVA: 0x7FFAC363D1F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC363D220
        public void OnNetworkReady(){} // RVA: 0x7FFAC363D260
        public void StopCoroutine(){} // RVA: 0x7FFAC363D280
        public void OnApplicationQuit(){} // RVA: 0x7FFAC363D2A0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC363D2F0
        public void GetBufferedTimes(){} // RVA: 0x7FFAC363D350
        public void SetOverlay(){} // RVA: 0x7FFAC363D370
        public void print(){} // RVA: 0x7FFAC363D3B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC363D3E0
        public void SetNetworkPlayerReference(){} // RVA: 0x7FFAC363D400
        public void DoCopyTexture_Region_957(){} // RVA: 0x7FFAC363D440
        public void get_MotionBlurCameras(){} // RVA: 0x7FFAC354DFA0
        public void __set_hasTranslationDoF__SystemBoolean__SystemVoid(){} // RVA: 0x7FFAC363D700
        public void get_alreadySelecting(){} // RVA: 0x7FFAC363D720
        public void ConfigureisTrigger(){} // RVA: 0x7FFAC363D730
        public void Updatevelocity_Inj(){} // RVA: 0x7FFAC363DA60
        public void SetNetworkPropertyIntO(){} // RVA: 0x7FFAC363DAA0
        public void SetNetworkPropertyIntY(){} // RVA: 0x7FFAC363DAE0
        public void Start_541DC43F0D78(){} // RVA: 0x7FFAC363DB00
        public void IsNetworkPropertyFlagSetR(){} // RVA: 0x7FFAC363DB50
        public void ProcessNetworkSynchronizationParameter(){} // RVA: 0x7FFAC363DB70
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFAC363DBF0
        public void SetXMotion(){} // RVA: 0x7FFAC2F21320
        public void get_rootIMGUIContainer_B04BDEA92682(){} // RVA: 0x7FFAC363DD20
        public void SetClampedNetworkedFloat392(){} // RVA: 0x7FFAC363DD30
        public void SetNetworkPropertyIntY_3430C11FB386(){} // RVA: 0x7FFAC363DD80
        public void SetClampedNetworkedFloat392_4C66004C2F08(){} // RVA: 0x7FFAC363DE20
        public void GetPlayerNetworkFloat400(){} // RVA: 0x7FFAC363DE60
        public void SetPlayerNetworkFloatNormalized(){} // RVA: 0x7FFAC363DE80
        public void DecodeNetworkState(){} // RVA: 0x7FFAC363DEA0
        public void Equals(){} // RVA: 0x7FFAC363DEE0
        public void Decode(){} // RVA: 0x7FFAC3640470 | overloaded x2
        public void OnDestroy(){} // RVA: 0x7FFAC363E060
        public void SetNetworkPropertyIntY_36F7AC284AC5(){} // RVA: 0x7FFAC363DAE0
        public void SetNetworkPropertyIntY_AC49F61ECE8E(){} // RVA: 0x7FFAC363E580
        public void set_onValueChanged(){} // RVA: 0x7FFAC363EB60
        public void get_selectHandler(){} // RVA: 0x7FFAC363EBA0
        public void set_enabled(){} // RVA: 0x7FFAC363F920
        public void SetEnabled(){} // RVA: 0x7FFAC363F960
        public void Awake(){} // RVA: 0x7FFAC363F9B0
        public void InitializeNetworkRuntime(){} // RVA: 0x7FFAC3640060
        public void UpdateNetworkMaterial(){} // RVA: 0x7FFAC3640080
        public void RefreshOverlayState(){} // RVA: 0x7FFAC36400B0
        public void Updatemass(){} // RVA: 0x7FFAC36400D0
        public void CanSerialize8Bit(){} // RVA: 0x7FFAC3006850
        public void DoInternal_FromEu(){} // RVA: 0x7FFAC36400F0
        public void GetNetworkProperty296(){} // RVA: 0x7FFAC3640100
        public void DoRandomRangeInt_A2E(){} // RVA: 0x7FFAC3640120
        public void GetNetworkProperty296_91A6D99B1D21(){} // RVA: 0x7FFAC36401B0
        public void GetPlayerNetworkFloat360(){} // RVA: 0x7FFAC3640240
        public void PropertyToID(){} // RVA: 0x7FFAC3640290
        public void get_verticalScrollbar(){} // RVA: 0x7FFAC36403C0
        public void GetNetworkProperty408(){} // RVA: 0x7FFAC3640410
        public void Computeenabled(){} // RVA: 0x7FFAC3640430
        public void ComputeisDone(){} // RVA: 0x7FFAC36404B0
        public void DoDestroy(){} // RVA: 0x7FFAC36404F0
        public void Update(){} // RVA: 0x7FFAC3640540
        public void GetGameObject(){} // RVA: 0x7FFAC3640EE0
        public void GetPackedVectorComponent(){} // RVA: 0x7FFAC3640F20
        public void YGNodeStyleSetPositionType(){} // RVA: 0x7FFAC3640F40
        public void ProxyNetworkFunctionCall(){} // RVA: 0x7FFAC3640FA0
        public void SetClampedNetworkedFloat296(){} // RVA: 0x7FFAC3640FC0
        public void SetClampedNetworkedFloat296_17AC35A2B23C(){} // RVA: 0x7FFAC36413C0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3641410
        public void GetVideoHeight(){} // RVA: 0x7FFAC3641480
        public void Computemass(){} // RVA: 0x7FFAC3641490
        public void DoCreateInternalActionMapForSingletonAction(){} // RVA: 0x7FFAC36414D0
        public void SerializedName(){} // RVA: 0x7FFAC36414F0
        public void SetGlobalFloat(){} // RVA: 0x7FFAC3641530
        public void GetSystem(){} // RVA: 0x7FFAC3641550
        public void SetGlobalFloat_5519DB5EA3CF(){} // RVA: 0x7FFAC3641570
        public void ApplyNetworkPacketData(){} // RVA: 0x7FFAC3641590
        public void ApplyGlobalShaderParameters(){} // RVA: 0x7FFAC36415E0
        public void Start(){} // RVA: 0x7FFAC36416C0
        public void SetPrimaryShaderNetworkFloat(){} // RVA: 0x7FFAC3641760
        public void SetPrimaryGlobalShaderFloat(){} // RVA: 0x7FFAC36417B0
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void GetNetworkProperty372(){} // RVA: 0x7FFAC36417D0
        public void SetSecondaryGlobalShaderFloat(){} // RVA: 0x7FFAC36417F0
        public void GetVideoHeight_7A8CA4A0E177(){} // RVA: 0x7FFAC3641820
        public void OnEnable_38F7D5376544(){} // RVA: 0x7FFAC3641850
        public void OnDisable(){} // RVA: 0x7FFAC3641870
        public void CallNetworkInternalFunctionBAC0(){} // RVA: 0x7FFAC36419F0
        public void GetNetworkProperty288(){} // RVA: 0x7FFAC3641A10
        public void GetNetworkProperty288_8E32E7E16467(){} // RVA: 0x7FFAC3641A30
        public void OnDisable_C71B19A11DC7(){} // RVA: 0x7FFAC3641A70
        public void GetNetworkProperty396(){} // RVA: 0x7FFAC3641A90
        public void GetNetworkProperty384(){} // RVA: 0x7FFAC3641B20
        public void ComputegameObject(){} // RVA: 0x7FFAC3641B40
        public void Initialize(){} // RVA: 0x7FFAC3641B80
        public void CalculateInterpolation(){} // RVA: 0x7FFAC3641BA0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3641BE0
        public void ComputegameObject_2B95CB32D066(){} // RVA: 0x7FFAC3641CA0
        public void Initialize_4204C19DC87E(){} // RVA: 0x7FFAC3641CE0
        public void set_TypeId(){} // RVA: 0x7FFAC3641D20
        public void Start_DA72FF1B51BC(){} // RVA: 0x7FFAC3641D60
        public void IsNetworkReady(){} // RVA: 0x7FFAC3641D80
        public void GetNetworkSynchronizationEnabled(){} // RVA: 0x7FFAC3641DA0
        public void get_TypeId(){} // RVA: 0x7FFAC3641DE0
        public void get_CustomBones(){} // RVA: 0x7FFAC3641DF0
        public void Update_540CB71AC481(){} // RVA: 0x7FFAC313BE20
        public void OnValidate(){} // RVA: 0x7FFAC3641E20
        public void GetNetworkProperty368(){} // RVA: 0x7FFAC3642230
        public void NeedsImportant(){} // RVA: 0x7FFAC2F21320
        public void StopCoroutine_CD63C7FB91AB(){} // RVA: 0x7FFAC3642270
        public void GetNetworkProperty368_ADBFE85B19A9(){} // RVA: 0x7FFAC3642370
        public void set_popularity(){} // RVA: 0x7FFAC3642540
        public void CanSerialize32Bit(){} // RVA: 0x7FFAC2F21320
        public void ProcessPlayerNetworkData(){} // RVA: 0x7FFAC3642550
        public void CallNetworkInternalFunctionA50(){} // RVA: 0x7FFAC3642590
        public void ProcessNetworkSynchronizationParameter_F244784C1078(){} // RVA: 0x7FFAC363DB70
        public void GetConstantValue1000(){} // RVA: 0x7FFAC363D040
        public void GetPlayerNetworkFloat356(){} // RVA: 0x7FFAC36425E0
        public void SetNetworkSynchronizationEnabled(){} // RVA: 0x7FFAC3642620
        public void NeedsSync(){} // RVA: 0x7FFAC3006850
        public void GetNetworkProperty304(){} // RVA: 0x7FFAC3642640
        public void SetNetworkSynchronizationEnabled_639BEBBAFF79(){} // RVA: 0x7FFAC3642660
        public void SetNetworkSynchronizationEnabled_A2646E8CF0FF(){} // RVA: 0x7FFAC3642680
        public void SetNetworkSynchronizationEnabled_6D4310D1E11F(){} // RVA: 0x7FFAC36426A0
        public void ComputegameObject_13220067BB8A(){} // RVA: 0x7FFAC3642710
        public void SetNetworkSynchronizationEnabled_61A7912C1F54(){} // RVA: 0x7FFAC3642730
        public void .ctor(){} // RVA: 0x7FFAC36427A0
        public void ProcessNetworkMessages(){} // RVA: 0x7FFAC36428C0
        public void get_UploadLength(){} // RVA: 0x7FFAC2F8C5F0
        public void .cctor(){} // RVA: 0x7FFAC3642970
        public void get_popularity(){} // RVA: 0x7FFAC3642A70
        public void GetPlayerNetworkFloat400_378366EB1406(){} // RVA: 0x7FFAC3642A70
        public void GetPlayerNetworkFloat400_296FC4EEAE2A(){} // RVA: 0x7FFAC3642A80
        public void SetPlayerNetworkFloatNormalized_C35C45D009FA(){} // RVA: 0x7FFAC3642AA0
        public void UpdateActive(){} // RVA: 0x7FFAC3642AE0
        public void SetPlayerNetworkByte428(){} // RVA: 0x7FFAC3642B20
        public void get_onPressed(){} // RVA: 0x7FFAC2F8C120
        public void InitializeDefaults(){} // RVA: 0x7FFAC3642B40
    }

    /// <summary>Originally: ÎÎÎÍÎÏÍÌÌÏÍÍÏÎÎÎÍÎÏÏÎÏÏ</summary>
    public class PlayerOwnerCanUseAnimatedEmojiSibling_019F : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public System.ArraySegment`1<byte> f_653; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC45BB120
        public void InternalEquals(){} // RVA: 0x7FFAC4A927E0
        public void DefaultEquals(){} // RVA: 0x7FFAC4A927E0
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC4A927D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_AEB(){} // RVA: 0x7FFAC45BB120
        public void m_9F5(){} // RVA: 0x7FFAC45BB120
        public void m_644(){} // RVA: 0x7FFAC3AD9F60
        public void m_9A6(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÎÍÏÍÌÎÌÍÍÌÍÌÎÍÎÍÌÌÏÎÍÏÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmojiSibling_4BE6 : ValueType
    {
        public UIntPtr f_058; // 0x10
        public System.ArraySegment`1<byte> f_653; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4A927D0
        public void InternalEquals(){} // RVA: 0x7FFAC4A927E0
        public void DefaultEquals(){} // RVA: 0x7FFAC4A927D0
        public void GetHashCode(){} // RVA: 0x7FFAC45BB120
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4A927E0
        public void ToString(){} // RVA: 0x7FFAC4A927D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_788(){} // RVA: 0x7FFAC4A927E0
        public void m_BFF(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÏÍÎÍÍÏÎÌÎÍÍÏÏÍÍÌÎÍÏÍÍÎÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmojiSibling_81C2 : ValueType
    {
        public UIntPtr _81C2; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC45BB120
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC45BB120
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_184(){} // RVA: 0x7FFAC3AD9F60
        public void m_581(){} // RVA: 0x7FFAC3AD9F60
        public void m_D9A(){} // RVA: 0x7FFAC45BB120
    }

    /// <summary>Originally: ÎÎÌÎÌÎÍÌÎÍÎÍÍÎÏÍÎÏÎÌÏÌÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmojiSibling_CA80 : ValueType
    {
        public System.Nullable`1<ÌÌÎÏÍÌÌÌÌÌÌÏÌÍÍÎÎÌÎÏÌÏÌ> f_653; // 0x10
        public 0x6B0FC170 f_0B1; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2FC20C0
        public void InternalEquals(){} // RVA: 0x7FFAC4AD7000
        public void DefaultEquals(){} // RVA: 0x7FFAC4AD7000
        public void GetHashCode(){} // RVA: 0x7FFAC2FC20D0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4AD6F80
        public void ToString(){} // RVA: 0x7FFAC2FC20D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4AD7000
        // ── Unresolved (hash) ──
        public void m_848(){} // RVA: 0x7FFAC4AD7000
        public void m_2CD(){} // RVA: 0x7FFAC2FC20C0
        public void m_1B6(){} // RVA: 0x7FFAC2FC20C0
        public void m_DC1(){} // RVA: 0x7FFAC4AD7000
        public void m_F67(){} // RVA: 0x7FFAC4AD6F80
    }

    /// <summary>Originally: ÏÎÏÍÎÍÌÍÎÏÏÌÏÍÏÍÌÍÍÍÎÍÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmojiSibling_DC33 : ValueType
    {
        public System.ArraySegment`1<byte> f_653; // 0x10
        public uint f_02C; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4AA1C40
        public void InternalEquals(){} // RVA: 0x7FFAC2F6E5C0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F240C0
        public void GetHashCode(){} // RVA: 0x7FFAC4AA1C40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4AA1C40
        public void ToString(){} // RVA: 0x7FFAC32C0590
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F240C0
        // ── Unresolved (hash) ──
        public void m_11A(){} // RVA: 0x7FFAC2F6E5C0
        public void m_7ED(){} // RVA: 0x7FFAC4AA1C40
        public void m_CF7(){} // RVA: 0x7FFAC4AA1C40
        public void m_8C2(){} // RVA: 0x7FFAC32C0590
        public void m_805(){} // RVA: 0x7FFAC2F6E5C0
    }

    /// <summary>Originally: ÍÍÍÏÏÏÏÎÏÍÎÌÏÎÎÍÎÏÍÌÏÎÎ</summary>
    public class PlayerOwnerCanUseAnimatedEmoji_1804_1804
    {
        public string _isAnimated;
        public string _isPremium;

        // ── Methods ──
        public void get_IsAnimated(){} // RVA: 0x7FFAC2C59D00
        public void get_IsPremium(){} // RVA: 0x7FFAC2C59D00
        public void get_LoadFrom(){} // RVA: 0x7FFAC2C59960
        public void get_Frames(){} // RVA: 0x7FFAC2C59960
        public void get_FPS(){} // RVA: 0x7FFAC2C59960
        public void get_LoopStyle(){} // RVA: 0x7FFAC2C58E90
        public void set_LoopStyle(){} // RVA: 0x7FFAC2C70A40
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFAC2C58E90
        public void get_DisplayTexture(){} // RVA: 0x7FFAC2C58E90
        public void get_FullResolutionTexture(){} // RVA: 0x7FFAC2C58E90
        public void get_Sprite(){} // RVA: 0x7FFAC2C58E90
        public void get_MaskTag(){} // RVA: 0x7FFAC2C58E90
        public void get_AnimationStyle(){} // RVA: 0x7FFAC2C58E90
        public void set_AnimationStyle(){} // RVA: 0x7FFAC2C70A40
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC2C59D00
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC2C71060
        public void get_FileId(){} // RVA: 0x7FFAC2C58E90
        public void get_IsBuiltIn(){} // RVA: 0x7FFAC2C59D00
    }

    /// <summary>Originally: ÍÏÎÏÎÌÎÏÎÎÍÏÎÍÎÏÏÏÍÍÎÎÍ</summary>
    public class PlayerOwnerCanUseAnimatedEmoji_8041_8041 : AnimatedTextureBase_F53F_F53F
    {
        public bool _ownerCanUseAnimatedEmoji; // 0x20
        public string _isSpecialFX; // 0x28
        public UnityEngine.Material _loopStyle; // 0x30
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ _fPS; // 0x38
        public string _frames;
        public VRC.Profiling.ProfilerMarker _effectBundleID; // 0x40
        public VRC.Profiling.ProfilerMarker _spawnablePrefabName; // 0x50
        public ÌÏÌÏÏÌÌÍÎÍÍÎÌÎÎÎÌÌÌÏÍÏÍ _animationStyle; // 0x60
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> _fullResolutionTexture; // 0x68
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> _loadFrom; // 0x70
        public int _fileId;

        // ── Methods ──
        public void get_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC300F9D0
        public void set_body(){} // RVA: 0x7FFAC2FE95A0
        public void set_ValidExpressions(){} // RVA: 0x7FFAC300F9E0
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void get_IsSpecialFX(){} // RVA: 0x7FFAC350BEA0
        public void set_LoopStyle(){} // RVA: 0x7FFAC46B47E0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void get_FPS(){} // RVA: 0x7FFAC3572BD0
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void set_EffectBundleID(){} // RVA: 0x7FFAC46B4850
        public void set_Frames(){} // RVA: 0x7FFAC2FE95A0
        public void get_Frames(){} // RVA: 0x7FFAC46B48A0
        public void get_EffectBundleID(){} // RVA: 0x7FFAC34AEA10
        public void set_SpawnablePrefabName(){} // RVA: 0x7FFAC300F9E0
        public void set_FullResolutionTexture(){} // RVA: 0x7FFAC31D95E0
        public void get_SpawnablePrefabName(){} // RVA: 0x7FFAC2F4F130
        public void set_AnimationStyle(){} // RVA: 0x7FFAC34BE690
        public void set_trackerAnchor(){} // RVA: 0x7FFAC2FBF380
        public void get_FullResolutionTexture(){} // RVA: 0x7FFAC2FE9590
        public void get_LoadFrom(){} // RVA: 0x7FFAC46B48C0
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC46B48F0
        public void get_LoopStyle(){} // RVA: 0x7FFAC46B4A80
        public void set_DisplayTexture(){} // RVA: 0x7FFAC46B4AE0
        public void set_FileId(){} // RVA: 0x7FFAC46B4BA0
        public void get_FileId(){} // RVA: 0x7FFAC34AE880
        public void get_DisplayTexture(){} // RVA: 0x7FFAC2F9CD50
        public void set_Sprite(){} // RVA: 0x7FFAC2FBF380
        public void get_AnimationStyle(){} // RVA: 0x7FFAC34AEA50
        public void get_IsBuiltIn(){} // RVA: 0x7FFAC2F21320
        public void get_IsPremium(){} // RVA: 0x7FFAC46B5300
        public void get_Sprite(){} // RVA: 0x7FFAC34F9180
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void get_IsAnimated(){} // RVA: 0x7FFAC46B5320
        public void get_MaskTag(){} // RVA: 0x7FFAC34AE8C0
        public void set_MaskTag(){} // RVA: 0x7FFAC46B5340
        public void set_OwnerCanUseAnimatedEmoji(){} // RVA: 0x7FFAC300F9E0
        public void set_IsAnimated(){} // RVA: 0x7FFAC46B5370
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
    }

    /// <summary>Originally: ÌÌÌÎÍÍÌÏÌÎÎÏÎÌÎÎÏÏÏÏÎÏÏ</summary>
    public class PlayerRectTransformDimensRelated_0ACA : Object
    {
        public UnityEngine.Vector2 _0ACA; // 0x10
        public UnityEngine.Vector2 ÍÎÍÏÌÍÎÌÍÏÏÏÎÎÎÏÎÌÎÏÌÏÎ; // 0x18
        public VRC.UI.Voyager.Controls.LayoutPadding ÌÍÎÍÌÍÍÍÌÌÏÌÌÌÎÍÌÎÍÎÏÏÏ; // 0x20
        public float ÏÌÏÍÎÎÏÍÎÍÎÍÍÍÌÏÎÏÎÏÍÏÎ; // 0x30
        public float ÎÎÎÌÍÏÍÏÌÌÏÌÎÏÏÎÎÍÍÏÌÏÌ; // 0x34
        public float ÏÍÏÍÏÎÌÏÌÌÎÎÍÌÏÏÌÍÎÏÍÍÏ; // 0x38
        public int ÏÌÍÎÏÍÎÎÌÎÏÎÍÏÏÌÏÏÎÎÍÍÎ; // 0x3C
        public System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Vector2,float,VRC.UI.Voyager.Controls.LayoutPadding>> ÏÍÍÎÌÍÏÌÌÍÏÍÏÌÏÌÎÏÏÏÏÏÍ; // 0x40
        public System.Collections.Generic.List`1<System.ValueTuple`4<int,int,float,float>> ÏÍÌÌÌÎÎÍÏÏÏÎÍÎÎÌÎÌÏÏÌÍÍ; // 0x48

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC58743D0
        public void Equals(){} // RVA: 0x7FFACBA00130
        public void GetHashCode(){} // RVA: 0x7FFAC441EFB0
        public void op_Implicit(){} // RVA: 0x7FFAC58743D0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC441EFB0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC58743D0
        public void .ctor(){} // RVA: 0x7FFACBA001F0
        public void Initialize(){} // RVA: 0x7FFAC58743D0
        public void set_name(){} // RVA: 0x7FFACBA00350
        public void Instantiate(){} // RVA: 0x7FFAC441EFB0
        public void ToString(){} // RVA: 0x7FFACBA00420
    }

    /// <summary>Originally: ÎÌÎÏÏÍÌÍÎÌÏÍÌÍÍÍÎÌÏÌÌÎÎ</summary>
    public class PlayerRectTransformDimensRelated_1332 : Object
    {
        public UnityEngine.Vector2 _1332; // 0x10
        public UnityEngine.Vector2 ÍÎÍÏÌÍÎÌÍÏÏÏÎÎÎÏÎÌÎÏÌÏÎ; // 0x18
        public VRC.UI.Voyager.Controls.LayoutPadding ÌÍÎÍÌÍÍÍÌÌÏÌÌÌÎÍÌÎÍÎÏÏÏ; // 0x20
        public float ÌÍÌÎÍÍÎÏÍÏÌÍÏÍÌÏÎÎÎÍÎÏÍ; // 0x30
        public float ÏÌÌÏÎÎÎÍÎÏÍÏÎÏÌÏÍÌÏÍÏÎÌ; // 0x34
        public float ÎÎÎÌÍÏÍÏÌÌÏÌÎÏÏÎÎÍÍÏÌÏÌ; // 0x38
        public int ÏÌÍÎÏÍÎÎÌÎÏÎÍÏÏÌÏÏÎÎÍÍÎ; // 0x3C
        public System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Vector2,float,VRC.UI.Voyager.Controls.LayoutPadding>> ÏÍÍÎÌÍÏÌÌÍÏÍÏÌÏÌÎÏÏÏÏÏÍ; // 0x40
        public System.Collections.Generic.List`1<System.ValueTuple`4<int,int,float,float>> ÏÌÏÎÌÍÌÍÍÎÌÎÎÏÎÏÍÏÎÏÍÏÍ; // 0x48

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFACBA011E0
        public void Equals(){} // RVA: 0x7FFAC58743D0
        public void GetHashCode(){} // RVA: 0x7FFAC441EFB0
        public void op_Implicit(){} // RVA: 0x7FFACBA012B0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC58743D0
        public void .ctor(){} // RVA: 0x7FFACBA01370
        public void Initialize(){} // RVA: 0x7FFACBA014D0
        public void get_name(){} // RVA: 0x7FFAC441EFB0
        public void set_name(){} // RVA: 0x7FFACBA02100
        public void Instantiate(){} // RVA: 0x7FFACBA021D0
        public void ToString(){} // RVA: 0x7FFACBA02DC0
        // ── Unresolved (hash) ──
        public void m_88E(){} // RVA: 0x7FFAC441EFB0
    }

    /// <summary>Originally: ÌÌÏÎÎÍÍÍÏÎÌÏÍÍÍÍÎÍÌÌÏÏÏ</summary>
    public class PlayerRectTransformDimensRelated_E91B : Object
    {
        public 0x6B279B78 _name; // 0x10
        public UnityEngine.Vector2 _hideFlags; // 0x14
        public 0x6B279BD0 f_177; // 0x1C
        public int f_7AB; // 0x20
        public bool f_82D; // 0x24
        public UnityEngine.Vector2 f_A8C; // 0x28
        public VRC.UI.Voyager.Controls.LayoutPadding ÌÍÎÍÌÍÍÍÌÌÏÌÌÌÎÍÌÎÍÎÏÏÏ; // 0x30
        public UnityEngine.Vector2 ÏÏÌÏÏÍÏÏÏÏÌÎÏÎÍÎÎÏÌÏÍÍÎ; // 0x40
        public int ÏÌÍÎÏÍÎÎÌÎÏÎÍÏÏÌÏÏÎÎÍÍÎ; // 0x48
        public int ÍÌÍÌÎÎÌÌÎÏÏÎÏÌÏÍÍÌÌÎÏÏÏ; // 0x4C
        public float ÍÍÌÎÏÍÌÌÌÎÎÎÌÌÎÌÏÏÌÏÏÍÌ; // 0x50
        public float ÌÎÌÌÎÍÎÍÍÏÌÌÏÍÍÍÍÎÎÍÌÏÎ; // 0x54
        public float ÎÏÎÍÌÏÏÌÍÌÌÍÎÍÍÏÍÌÎÍÎÏÍ; // 0x58
        public float ÎÏÍÎÍÎÍÏÍÍÏÍÏÎÌÏÏÌÌÍÏÏÎ; // 0x5C
        public float ÎÌÍÏÌÎÏÏÍÌÌÏÌÎÍÏÎÏÍÌÍÌÍ; // 0x60
        public float ÌÏÍÎÍÏÏÏÍÎÎÏÏÍÏÎÍÌÏÏÎÍÍ; // 0x64
        public int ÍÌÍÍÏÎÌÏÍÍÏÍÎÍÏÍÎÎÏÎÏÍÏ; // 0x68
        public int ÌÌÏÏÎÏÏÌÍÍÍÏÌÎÍÍÌÏÌÏÍÎÌ; // 0x6C
        public int ÍÎÍÏÌÎÌÎÎÌÎÏÍÏÍÌÍÏÏÍÏÍÏ; // 0x70

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC43A2620
        public void Equals(){} // RVA: 0x7FFAC2F6E5C0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB7A0
        public void op_Implicit(){} // RVA: 0x7FFAC44474D0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC43A2620
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4422FB0
        public void GetCachedPtr(){} // RVA: 0x7FFAC2F240C0
        public void get_name(){} // RVA: 0x7FFAC30DBBE0
        public void set_name(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFACB9FF780
        public void Initialize(){} // RVA: 0x7FFACB9FF7E0
        public void Instantiate(){} // RVA: 0x7FFAC58A1B70
        public void ToString(){} // RVA: 0x7FFACB9FFA00
        public void Destroy(){} // RVA: 0x7FFAC44357F0
        // ── Unresolved (hash) ──
        public void m_C81(){} // RVA: 0x7FFAC2F3C7C0
        public void m_114(){} // RVA: 0x7FFAC4774720
        public void m_33C(){} // RVA: 0x7FFAC58A1B70
        public void m_D5A(){} // RVA: 0x7FFAC43A2620
        public void m_F9C(){} // RVA: 0x7FFAC4422FB0
        public void m_88E(){} // RVA: 0x7FFAC33D3BF0
    }

    /// <summary>Originally: ÎÎÎÌÎÌÍÎÍÏÌÍÌÌÍÍÌÎÏÎÏÏÌ</summary>
    public class PlayerRectTransformDimensRelated_F803 : ValueType
    {
        public int f_A8C; // 0x10
        public object f_F57; // 0x18
        public System.Nullable`1<bool> f_25A; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420210
        public void InternalEquals(){} // RVA: 0x7FFAC469AEC0
        public void DefaultEquals(){} // RVA: 0x7FFAC4420240
        public void GetHashCode(){} // RVA: 0x7FFAC469BCA0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC336D8B0
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC49D8DE0
        public void Initialize(){} // RVA: 0x7FFAC469AEC0
        // ── Unresolved (hash) ──
        public void m_1BB(){} // RVA: 0x7FFAC336D8B0
        public void m_88E(){} // RVA: 0x7FFAC336D8B0
        public void m_8A5(){} // RVA: 0x7FFAC4420240
        public void m_E65(){} // RVA: 0x7FFAC4420220
        public void m_7AA(){} // RVA: 0x7FFAC4420220
    }

    /// <summary>Originally: ÎÍÌÏÌÎÏÎÎÍÎÏÏÏÎÎÎÍÎÎÏÎÎ</summary>
    public class PlayerRectTransformDimensionsCSibling_A401
    {
        public object f_30C;
        public object f_E95;
        public object f_78C;

        // ── Methods ──
        public void ContainsChild(){} // RVA: 0x7FFAC2C70A40
        public void ContainsChild_52D3FA58E3AC(){} // RVA: 0x7FFAC2C70A40
        public void GetRange_43306D7A9C3D(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void UpdatePlayerRectLayout(){} // RVA: 0x7FFAC2C58E90
        public void ValidatePlayerRectLayout(){} // RVA: 0x7FFAC2C58E90
        public void RefreshPlayerRectLayout(){} // RVA: 0x7FFAC2C58E90
        public void MeasurePlayerRectLayout(){} // RVA: 0x7FFAC2C58E90
    }

    /// <summary>Originally: ÌÏÌÏÌÍÎÌÎÎÎÌÍÏÎÍÏÎÌÏÍÌÌ</summary>
    public class PlayerRectTransformDimensionsChCalculateLayout_4181_4181 : PointerEnterPointerExit_D99E_D99E
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
        public ÎÏÏÎÌÍÌÎÍÏÍÎÌÌÌÏÍÏÎÏÌÎÏ f_4A4; // 0x110
        public System.Collections.Generic.List`1<UnityEngine.Rect> f_E5D; // 0x118
        public System.Collections.Generic.List`1<object> f_996; // 0x120
        public System.Collections.Generic.List`1<ÌÏÍÎÌÎÌÎÏÌÏÎÏÎÌÎÍÎÏÎÌÏÌ> f_195; // 0x128
        public ÌÏÏÎÍÍÏÏÌÎÎÍÏÌÏÎÌÏÌÎÌÏÎ f_E80; // 0x130
        public int f_17C;
        public DG.Tweening.Tweener f_56D; // 0x138
        public UnityEngine.Vector2 f_BFF; // 0x140
        public 0x6B279910 f_367; // 0x148
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
        public 0x6B279B20 _xAlign; // 0x1AC
        public 0x6B279B20 _yAlign; // 0x1B0
        public 0x6B279C28 _fillX; // 0x1B4
        public 0x6B279C28 _fillY; // 0x1B8
        public UnityEngine.Vector2 _gridCellSize; // 0x1BC
        public 0x6B279B78 _gridStartAxis; // 0x1C4
        public 0x6B279BD0 _gridConstraint; // 0x1C8
        public int _gridConstraintCount; // 0x1CC
        public bool _gridAlignAlignLastRowOrCol; // 0x1D0
        public System.Collections.Generic.List`1<ÍÍÌÍÎÍÎÎÏÎÏÎÌÌÏÎÍÌÍÍÏÍÎ> ÏÌÏÍÍÌÎÌÏÎÏÍÎÏÎÌÌÎÎÍÏÍÏ; // 0x1D8

        // ── Methods ──
        public void Awake_8424C29D0677(){} // RVA: 0x7FFACBA0B390
        public void get_gameObject(){} // RVA: 0x7FFACBA0B410
        public void InitializeRectTransformDefaults(){} // RVA: 0x7FFACBA0B430
        public void .ctor(){} // RVA: 0x7FFACBA0B4B0
        public void get_tilt(){} // RVA: 0x7FFAC9C7AAD0
        public void SetLineWidth(){} // RVA: 0x7FFACBA0BA40
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFACBA0DC00
        public void FixedUpdate(){} // RVA: 0x7FFACBA0DC90
        public void GetLanguage(){} // RVA: 0x7FFACBA0DCA0
        public void NeedsSync(){} // RVA: 0x7FFACBA0DCB0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA0DCC0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFACBA0DCD0
        public void get_childScaleHeight(){} // RVA: 0x7FFACBA0DD00
        public void OnBecameInvisible(){} // RVA: 0x7FFACBA0DD10
        public void SetOverlay(){} // RVA: 0x7FFACBA0DDF0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC2F21310
        public void OnCollisionExit(){} // RVA: 0x7FFACBA0DE40
        public void SetLayoutHorizontal(){} // RVA: 0x7FFACBA0DEC0
        public void Initialize(){} // RVA: 0x7FFACBA0DF50
        public void get_SubmitButtonText(){} // RVA: 0x7FFACBA0E410
        public void GetDataCount(){} // RVA: 0x7FFACBA0E540
        public void OnPointerEnter(){} // RVA: 0x7FFACBA0E560
        public void Awake(){} // RVA: 0x7FFACBA0E570
        public void OnDestroy(){} // RVA: 0x7FFACBA0E8E0
        public void FindServiceEntry(){} // RVA: 0x7FFACBA0E980
        public void CopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void FindObjectsOfType(){} // RVA: 0x7FFACBA0EB60
        public void CalculateLayoutInputHorizontal_F36096ED6158(){} // RVA: 0x7FFACBA0ED20
        public void SetLayoutVertical(){} // RVA: 0x7FFACBA0ED40
        public void CalculateLayoutInputVertical_8C534F3906BA(){} // RVA: 0x7FFACBA0EDD0
        public void SetLayoutHorizontal_BE12F5AA1BA8(){} // RVA: 0x7FFACBA0EDF0
        public void SetCurrentLayoutGroup(){} // RVA: 0x7FFACBA0EEA0
        public void SetLayoutVertical_0E3841A86732(){} // RVA: 0x7FFACBA0EEF0
        public void EnsureLayoutStatics(){} // RVA: 0x7FFACBA0EF40
        public void Update_824906DA6492(){} // RVA: 0x7FFACBA0EF50
        public void FoldMaskRowsIntoBuckets(){} // RVA: 0x7FFACBA0F050
        public void Update(){} // RVA: 0x7FFACBA0F0F0
        public void get_StackTiliaFee(){} // RVA: 0x7FFACBA0F460
        public void get_button(){} // RVA: 0x7FFAC4090620
        public void get_StackTiliaFee_4DC0908E165A(){} // RVA: 0x7FFACBA0F470
        public void get_StackTiliaFee_0E42D4B2EA1A(){} // RVA: 0x7FFACBA0F490
        public void Awake_3A91C5CE4359(){} // RVA: 0x7FFACBA0F4A0
        public void ContainsTrackedLayout(){} // RVA: 0x7FFACBA0DCB0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.UI.ILayoutElement.get_minHeight(){} // RVA: 0x7FFAC37432E0
        public void set_ConnectTimeout(){} // RVA: 0x7FFACB9790D0
        public void GetLayoutFlag392(){} // RVA: 0x7FFAC8C48980
        public void FindFirstObjectByType(){} // RVA: 0x7FFACBA0F540
        public void LateUpdate(){} // RVA: 0x7FFACBA0F690
        public void LateUpdate_B3BB2C7CF0C4(){} // RVA: 0x7FFACBA0F7C0
        public void get_VoidedByAdmin(){} // RVA: 0x7FFACB3A45C0
        public void Awake_B54CF9D6994E(){} // RVA: 0x7FFACBA0F7E0
        public void Start(){} // RVA: 0x7FFACBA0FA70
        public void AccumulateBucketWindow(){} // RVA: 0x7FFACBA0FB10
        public void IncrementOverflowBucket(){} // RVA: 0x7FFACBA0FB30
        public void CopyTo_43306D_43306D7A9C3D(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetLayoutFlag394(){} // RVA: 0x7FFAC8C48A00
        public void IndexOfBucketValue(){} // RVA: 0x7FFACBA0FBD0
        public void UnityEngine.UI.ILayoutElement.get_preferredWidth(){} // RVA: 0x7FFACBA0FC70
        public void UpdateActive(){} // RVA: 0x7FFACBA0FCA0
        public void ComputeLayoutHash(){} // RVA: 0x7FFACBA0FCB0
        public void ProcessLayoutElements(){} // RVA: 0x7FFACBA0FDE0
        public void PropagateCarryIntoBuckets(){} // RVA: 0x7FFACBA0FE30
        public void AccumulateHashTriple(){} // RVA: 0x7FFACBA0FED0
        public void PropagateOverflowBuckets(){} // RVA: 0x7FFACBA0FF30
        public void GetHashCode(){} // RVA: 0x7FFACBA10030
        public void CreateUpdatedActiveLayout(){} // RVA: 0x7FFACBA10080
        public void OnRectTransformDimensionsChange_3FCA5780B89F(){} // RVA: 0x7FFACBA10120
        public void ValidatePlayerRectLayout(){} // RVA: 0x7FFACBA10130
        public void UnityEngine.UI.ILayoutElement.get_flexibleWidth(){} // RVA: 0x7FFAC37432E0
        public void OnEnable(){} // RVA: 0x7FFACBA10220
        public void DecrementTrailingBuckets(){} // RVA: 0x7FFACBA10230
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFACBA10120
        public void UpdatePointerExitState(){} // RVA: 0x7FFACBA10250
        public void SetupScrollbarThumb(){} // RVA: 0x7FFACBA102B0
        public void SetupScrollbarThumb_65A6CA553D3A(){} // RVA: 0x7FFACBA10310
        public void get_enableVertexGradient(){} // RVA: 0x7FFAC400F720
        public void SetupScrollbarThumb_F767AD0F8442(){} // RVA: 0x7FFACBA10330
        public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
        public void UnityEngine.UI.ILayoutElement.get_preferredHeight(){} // RVA: 0x7FFACBA10360
        public void SetupScrollbarThumb_40A20D68E8A7(){} // RVA: 0x7FFACBA10390
        public void IsBucketVectorAtLeastReference(){} // RVA: 0x7FFACBA10CD0
        public void IsAtLeastCurrentBucketBaseline(){} // RVA: 0x7FFACBA10CF0
        public void CompareBucketsDescending(){} // RVA: 0x7FFACBA10D10
        public void get_characterLimit(){} // RVA: 0x7FFAC9755950
        public void UnityEngine.UI.ILayoutElement.get_flexibleHeight(){} // RVA: 0x7FFAC37432E0
        public void ApplyDisplayConfiguration(){} // RVA: 0x7FFACBA11120
        public void OnDisable(){} // RVA: 0x7FFACBA11360
        public void UpdatePlayerRectLayout(){} // RVA: 0x7FFACBA11560
        public void TrySetMarkBit(){} // RVA: 0x7FFACBA11760
        public void OnTriggerStay(){} // RVA: 0x7FFACB3A45C0
        public void RefreshPlayerRectLayout(){} // RVA: 0x7FFAC2C58E90
        public void MeasurePlayerRectLayout(){} // RVA: 0x7FFACBA11810
        public void OnRectTransformDimensionsChange_1C21E1462E03(){} // RVA: 0x7FFACBA11A10
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFACBA11AB0
        public void IsDestroyed(){} // RVA: 0x7FFACBA10220
        public void CalculatePlayerRectLayout(){} // RVA: 0x7FFACBA11B30
        public void UnityEngine.UI.ILayoutElement.get_minWidth(){} // RVA: 0x7FFAC37432E0
        public void GetLayoutPreferredWidth(){} // RVA: 0x7FFACBA11BA0
        public void GetLayoutPreferredHeight(){} // RVA: 0x7FFACBA11BD0
        public void GetLayoutFlexibleWidth(){} // RVA: 0x7FFACBA11BF0
        public void GetLayoutFlexibleHeight(){} // RVA: 0x7FFACBA11C70
        public void GetLayoutMinWidth(){} // RVA: 0x7FFACBA11E70
        public void UnityEngine.UI.ILayoutElement.get_layoutPriority(){} // RVA: 0x7FFAC34F9180
        public void SecureStringToBSTR(){} // RVA: 0x7FFACBA11FD0
        public void SecureStringToBSTR_60893B6C6EA6(){} // RVA: 0x7FFACBA11FF0
        public void SecureStringToBSTR_EED716EF6157(){} // RVA: 0x7FFACBA12010
        public void GetLayoutMinHeight(){} // RVA: 0x7FFACBA0F7C0
        public void SecureStringToBSTR_D5A6022CE91C(){} // RVA: 0x7FFACBA12060
        public void SecureStringToBSTR_1738B1458D11(){} // RVA: 0x7FFACBA12080
        public void SecureStringToBSTR_709F1B600691(){} // RVA: 0x7FFACBA120A0
    }

    /// <summary>Originally: ÏÎÎÌÎÏÏÌÎÌÎÎÌÎÌÍÍÍÌÎÌÎÌ</summary>
    public class PlayerReleaseHandle_25C7_25C7 : SafeHandleZeroOrMinusOneIsInvalid
    {
        public float ÌÍÌÌÎÎÍÍÌÍÎÍÍÏÌÍÏÍÍÌÌÌÏ;
        public float ÏÍÍÌÌÍÌÍÏÍÏÍÎÎÍÎÌÍÎÌÏÏÌ;
        public string ÎÏÎÏÎÏÌÍÏÍÍÍÎÌÌÎÎÌÌÍÍÍÍ;
        public int ÌÌÏÌÌÎÍÍÍÍÎÌÎÌÌÌÎÌÌÌÍÏÏ;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC45BB130
        public void get_IsInvalid(){} // RVA: 0x7FFAC45BB1D0
        public void .ctor(){} // RVA: 0x7FFAC45BB240
        public void Initialize(){} // RVA: 0x7FFAC45BB390
        public void ResetHandleState(){} // RVA: 0x7FFAC45BB570
        public void DoLookRotation_Injected_D62(){} // RVA: 0x7FFAC45BB5F0
        public void ComputeRoot(){} // RVA: 0x7FFAC45BB670
        public void ProcessHandleRelease(){} // RVA: 0x7FFAC45BB850
        public void EnsureReleaseHandleStatics(){} // RVA: 0x7FFAC45BBA30
        public void ReleaseHandle(){} // RVA: 0x7FFAC45BBC10
        public void DoRecentering(){} // RVA: 0x7FFAC45BBCF0
        public void ClearHandleState(){} // RVA: 0x7FFAC45BBEE0
        public void Equals(){} // RVA: 0x7FFAC45BBF80
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC45BC140
    }

    /// <summary>Originally: ÎÏÏÌÍÎÍÎÏÎÎÌÏÏÍÍÎÎÎÏÍÍÏ</summary>
    public class PlayerShouldActivateModuleIsModuleSupported_4623_4623 : PointerInputModule
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
        public void GetPointerData(){} // RVA: 0x7FFAC43065B0
        public void RemovePointerData(){} // RVA: 0x7FFAC4306780
        public void set_body(){} // RVA: 0x7FFAC2FE95A0
        public void CopyFromTo(){} // RVA: 0x7FFAC43067F0
        public void StateForMouseButton(){} // RVA: 0x7FFAC4306AD0
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void GetLastPointerEventData(){} // RVA: 0x7FFAC4306C70
        public void set_IsConfigured(){} // RVA: 0x7FFAC313D3B0
        public void ProcessDrag(){} // RVA: 0x7FFAC4306E20
        public void ProcessDrag_589AC804266A(){} // RVA: 0x7FFAC43074C0
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void ClearSelection(){} // RVA: 0x7FFAC4307820
        public void ApplyTransform(){} // RVA: 0x7FFAC4307A60
        public void get_clipLength(){} // RVA: 0x7FFAC2F4A0E0
        public void set_clipLength(){} // RVA: 0x7FFAC2F4A0F0
        public void AlignPlayerModuleRotation(){} // RVA: 0x7FFAC4307AF0
        public void get_disablePoster(){} // RVA: 0x7FFAC313E620
        public void RemovePointerData_75DA504C2C5C(){} // RVA: 0x7FFAC4306780
        public void UpdateModule(){} // RVA: 0x7FFAC4308130
        public void set_YawInput(){} // RVA: 0x7FFAC2F4A110
        public void UpdatePlayerModuleRotation(){} // RVA: 0x7FFAC4308180
        public void IsModuleSupported(){} // RVA: 0x7FFAC3006850
        public void CompositionMethod(){} // RVA: 0x7FFAC3013AF0
        public void Awake(){} // RVA: 0x7FFAC4308320
        public void get_counterRotationStrength(){} // RVA: 0x7FFAC2F4A100
        public void ProcessMove(){} // RVA: 0x7FFAC43083B0
        public void DeactivateModule(){} // RVA: 0x7FFAC43083D0
        public void Process(){} // RVA: 0x7FFAC43083E0
        public void .ctor(){} // RVA: 0x7FFAC4308830
        public void Initialize(){} // RVA: 0x7FFAC34F9180
        public void SetPlayerModuleActive(){} // RVA: 0x7FFAC4308CC0
        public void SetPlayerModuleEnabled(){} // RVA: 0x7FFAC43099E0
        public void CompositionMethod_CE8928BFB7C1(){} // RVA: 0x7FFAC3013AF0
        public void ProcessRenderingCommandBuffer(){} // RVA: 0x7FFAC430A640
        public void SetGlobalTextureImpl(){} // RVA: 0x7FFAC430A7D0
        public void set_IsConfigured_36B0AF17D03C(){} // RVA: 0x7FFAC313D3B0
        public void StartPlayerModuleOpenVr(){} // RVA: 0x7FFAC430A9B0
        public void ActivateModule(){} // RVA: 0x7FFAC430AAE0
        public void CopyTexture(){} // RVA: 0x7FFAC430AC40
        public void Update(){} // RVA: 0x7FFAC430ACF0
        public void Start(){} // RVA: 0x7FFAC430AF70
        public void get_localScale(){} // RVA: 0x7FFAC430B1A0
        public void ShouldActivateModule(){} // RVA: 0x7FFAC430B2C0
        public void ProcessTransform(){} // RVA: 0x7FFAC430B4D0
        public void StopPlayerModuleOpenVr(){} // RVA: 0x7FFAC430B7E0
        public void .cctor(){} // RVA: 0x7FFAC430B8B0
        public void get_disablePoster_683615F899B5(){} // RVA: 0x7FFAC313E620
    }

    /// <summary>Originally: ÌÍÍÌÌÍÎÎÏÏÎÍÎÏÏÌÌÌÏÍÌÌÍ</summary>
    public class PlayerUseLowLatencyVideoHeight_EC39_EC39 : Object
    {
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer _loop; // 0x10
        public RenderHeads.Media.AVProVideo.MediaPlayer _videoHeight; // 0x18
        public int _videoWidth; // 0x20
        public bool _useLowLatency; // 0x24
        public bool _isPlaying; // 0x25
        public bool _isReady; // 0x26

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC470BEA0
        public void LoadURL(){} // RVA: 0x7FFAC470BFA0
        public void get_Loop(){} // RVA: 0x7FFAC2F3C7C0
        public void op_Implicit(){} // RVA: 0x7FFAC470C0D0
        public void SetTime(){} // RVA: 0x7FFAC470C110
        public void get_VideoHeight(){} // RVA: 0x7FFAC470C1F0
        public void get_VideoWidth(){} // RVA: 0x7FFAC470C260
        public void PlayURL(){} // RVA: 0x7FFAC470C2D0
        public void set_name(){} // RVA: 0x7FFAC470C400
        public void set_Loop(){} // RVA: 0x7FFAC4422FB0
        public void GetTime(){} // RVA: 0x7FFAC470C450
        public void Instantiate(){} // RVA: 0x7FFAC470C4C0
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC3FA0EC0
        public void set_UseLowLatency(){} // RVA: 0x7FFAC470C5F0
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC3FA0EB0
        public void get_UseLowLatency(){} // RVA: 0x7FFAC470C620
        public void Play(){} // RVA: 0x7FFAC470C650
        public void GetDuration(){} // RVA: 0x7FFAC470C680
        public void get_IsPlaying(){} // RVA: 0x7FFAC470C6F0
        public void set_IsPlaying(){} // RVA: 0x7FFAC470C820
        public void Destroy(){} // RVA: 0x7FFAC470CA10
        public void Stop(){} // RVA: 0x7FFAC470CC30
        public void set_IgnoreSerializableInterface(){} // RVA: 0x7FFAC470CC50
        public void set_IsReady(){} // RVA: 0x7FFAC2F3C7C0
        public void get_IsReady(){} // RVA: 0x7FFAC3FA0EA0
        public void FindObjectsByType(){} // RVA: 0x7FFAC470C400
        public void Equals(){} // RVA: 0x7FFAC470C400
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC470CC60
        public void get_hideFlags(){} // RVA: 0x7FFAC470CCD0
        public void set_hideFlags(){} // RVA: 0x7FFAC470CD10
        public void Pause(){} // RVA: 0x7FFAC470C5F0
        public void FindObjectOfType(){} // RVA: 0x7FFAC3FA0EB0
        public void .ctor(){} // RVA: 0x7FFAC470CD80
    }

    /// <summary>Originally: ÏÎÎÍÎÏÍÏÍÌÏÍÎÌÌÏÏÎÍÏÍÌÍ</summary>
    public class PlayercontrolPathInternal_23AE_23AE : OnScreenControl
    {
        public bool _controlPathInternal; // 0x38
        public System.Action _control; // 0x40
        public bool ÏÏÎÎÍÍÎÎÍÏÎÌÏÎÎÏÏÎÎÌÎÍÌ; // 0x48
        public string m_ControlPath; // 0x50

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7FFAC4298FF0
        public void set_controlPath(){} // RVA: 0x7FFAC4299220
        public void get_control(){} // RVA: 0x7FFAC42992C0
        public void IsResource(){} // RVA: 0x7FFAC31D95D0
        public void .ctor(){} // RVA: 0x7FFAC42940A0
        public void Initialize(){} // RVA: 0x7FFAC31D95D0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC31D95C0
        public void OnPointerDown(){} // RVA: 0x7FFAC42994F0
        public void get_HasAnyActive(){} // RVA: 0x7FFAC31D95C0
        public void OnPointerEnter(){} // RVA: 0x7FFAC4299560
        public void OnDisable(){} // RVA: 0x7FFAC393D910
        public void set_controlPathInternal(){} // RVA: 0x7FFAC30794D0
        public void Initialize_F095EFEF8EB6(){} // RVA: 0x7FFAC393D910
        public void ConfigureTransformLocalScale(){} // RVA: 0x7FFAC4299570
        public void get_controlPathInternal(){} // RVA: 0x7FFAC2FC20E0
        public void OnPointerExit(){} // RVA: 0x7FFAC4299610
        public void set_name(){} // RVA: 0x7FFAC42996B0
        public void set_name_5D04F092B7F5(){} // RVA: 0x7FFAC4299720
        public void OnPointerUp(){} // RVA: 0x7FFAC4299850
    }

    /// <summary>Originally: ÎÏÏÌÏÌÎÌÍÏÎÍÌÏÏÍÍÏÎÍÏÍÎ</summary>
    public class PlayercontrolPathInternal_241A_241A : OnScreenControl
    {
        public string _controlPathInternal; // 0x38

        // ── Methods ──
        public void set_controlPathInternal(){} // RVA: 0x7FFAC31D0C20
        public void set_controlPath(){} // RVA: 0x7FFAC36F6570
        public void get_control(){} // RVA: 0x7FFAC36F65C0
        public void OnPointerDown(){} // RVA: 0x7FFAC36F6610
        public void set_controlPathInternal_44621B9A3400(){} // RVA: 0x7FFAC36F6660
        public void SetupInputControl(){} // RVA: 0x7FFAC36F66B0
        public void get_controlPathInternal(){} // RVA: 0x7FFAC31D0140
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC36F6700
        public void OnPointerUp(){} // RVA: 0x7FFAC36F6750
        public void OnDisable(){} // RVA: 0x7FFAC36F67A0
        public void GetWarningMessage(){} // RVA: 0x7FFAC36F67F0
    }

    /// <summary>Originally: ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ</summary>
    public class PlayercontrolSchemesbindingMask_17CC_17CC : Object
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
        public void GetInstanceID(){} // RVA: 0x7FFAC38D6BA0
        public void get_devices(){} // RVA: 0x7FFAC38D6D20
        public void set_devices(){} // RVA: 0x7FFAC38D6D70
        public void op_Implicit(){} // RVA: 0x7FFAC2F3C380
        public void set_controlSchemes(){} // RVA: 0x7FFAC38D6DF0
        public void get_controlSchemes(){} // RVA: 0x7FFAC38D6F70
        public void WaitUntilCanceled(){} // RVA: 0x7FFAC38D6FB0
        public void get_name(){} // RVA: 0x7FFAC38D6FB0
        public void Disable(){} // RVA: 0x7FFAC38D7010
        public void .ctor(){} // RVA: 0x7FFAC38D7030
        public void Initialize(){} // RVA: 0x7FFAC38D9060
        public void Instantiate(){} // RVA: 0x7FFAC38D9080
        public void Enable(){} // RVA: 0x7FFAC38D9200
        public void Dispose(){} // RVA: 0x7FFAC38D9220
        public void Cleanup(){} // RVA: 0x7FFAC38D9280
        public void FindBinding(){} // RVA: 0x7FFAC38D9400
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC38D9060
        public void set_bindings(){} // RVA: 0x7FFAC38D9460
        public void get_bindings(){} // RVA: 0x7FFAC38D95E0
        public void get_bindingMask(){} // RVA: 0x7FFAC38D9600
        public void Destroy(){} // RVA: 0x7FFAC38D6FB0
        public void FindAction(){} // RVA: 0x7FFAC38D9650
        public void DestroyImmediate(){} // RVA: 0x7FFAC38D6FB0
        public void FindObjectsOfType(){} // RVA: 0x7FFAC38D6D70
        public void GetEnumerator(){} // RVA: 0x7FFAC38D9060
        public void FindObjectsByType(){} // RVA: 0x7FFAC38D9670
        public void Equals(){} // RVA: 0x7FFAC38D6FB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC38D6FB0
        public void Contains(){} // RVA: 0x7FFAC38D97F0
        public void set_bindingMask(){} // RVA: 0x7FFAC38D9810
        public void GetHashCode(){} // RVA: 0x7FFAC38D9600
        public void Finalize(){} // RVA: 0x7FFAC38D9870
    }

    /// <summary>Originally: ÍÌÏÏÌÌÎÌÏÍÏÍÍÌÎÎÍÏÌÏÏÏÎ</summary>
    public class RemovePlayerModsAddPlayerModsComponent_1D88_1D88 : MonoBehaviour
    {
        public bool ÏÎÍÎÍÌÎÍÌÍÍÍÍÎÏÏÌÌÌÌÎÍÎ; // 0x20
        public System.Collections.Generic.List`1<VRCSDK2.VRCPlayerMod> ÎÎÍÍÌÍÎÎÌÏÎÍÍÎÏÍÍÏÎÎÎÎÍ; // 0x28
        public System.Collections.Generic.HashSet`1<ÍÌÏÏÌÌÎÌÏÍÏÍÍÌÎÎÍÏÌÏÏÏÎ> ÏÌÍÎÏÎÎÍÎÌÏÍÎÎÌÎÌÌÍÏÍÌÍ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3ED6620
        public void AddPlayerMods(){} // RVA: 0x7FFAC3ED66B0
        public void IsInvoking(){} // RVA: 0x7FFAC3ED67D0
        public void Start(){} // RVA: 0x7FFAC3ED6A00
        public void .cctor(){} // RVA: 0x7FFAC3ED6C30
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC3ED6D10
        public void OnDisable(){} // RVA: 0x7FFAC3ED6E30
        public void RemovePlayerMods(){} // RVA: 0x7FFAC3ED6F50
        public void StartCoroutine(){} // RVA: 0x7FFAC3ED7070
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3ED72A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3ED7330
        public void OnDestroy(){} // RVA: 0x7FFAC3ED7450
        public void StopCoroutine(){} // RVA: 0x7FFAC3ED74E0
    }

    /// <summary>Originally: ÎÎÎÏÍÎÌÍÎÌÏÏÏÏÍÎÎÌÎÏÏÎÌ</summary>
    public class VRCPlayerSiblingSibling_6C8D_6C8D : Object
    {
        public System.Action _name; // 0x10
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> _hideFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34F9850
        public void Initialize(){} // RVA: 0x7FFAC34F9A60
        public void Equals(){} // RVA: 0x7FFAC34F9AD0
        public void op_Implicit(){} // RVA: 0x7FFAC34F9C50
        public void CompareBaseObjects(){} // RVA: 0x7FFAC34F9E80
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC34F9FF0
        public void GetCachedPtr(){} // RVA: 0x7FFAC34FA3A0
        public void get_name(){} // RVA: 0x7FFAC34FA410
        public void set_name(){} // RVA: 0x7FFAC34FA550
        public void Instantiate(){} // RVA: 0x7FFAC34FA8C0
        public void GetHashCode(){} // RVA: 0x7FFAC34FAA30
        public void ToString(){} // RVA: 0x7FFAC34FAC10
        public void ResolvePlayerAvatarFromNetworkState(){} // RVA: 0x7FFAC34FAE90
        public void ComputegameObject(){} // RVA: 0x7FFAC34FB070
        public void ReadTransformState(){} // RVA: 0x7FFAC2F247C0
        public void get_PlayerApiReference(){} // RVA: 0x7FFAC34FB160
        public void .ctor_6E68D1F3AB6F(){} // RVA: 0x7FFAC34FB290
        public void Initialize_5F16F856C3F7(){} // RVA: 0x7FFAC34FB400
        public void get_IsInvisible(){} // RVA: 0x7FFAC34FB530
        public void Destroy(){} // RVA: 0x7FFAC34FB6E0
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x7FFAC34FB7F0
        public void DestroyImmediate(){} // RVA: 0x7FFAC34FB920
        public void DestroyImmediate_0F751E223BC7(){} // RVA: 0x7FFAC34FB990
        public void FindObjectsOfType(){} // RVA: 0x7FFAC34FBB00
        public void set_statusDescription(){} // RVA: 0x7FFAC34FBC40
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void .cctor(){} // RVA: 0x7FFAC34FBD30
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC2F247C0
    }

    /// <summary>Originally: ÌÌÍÎÍÍÍÍÎÌÎÎÌÍÌÏÍÌÏÎÏÎÌ</summary>
    public class VRCPlayerSibling_3D33_3D33 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3DC2970
        public void RaiseCancellation(){} // RVA: 0x7FFAC3DC2CC0
        public void GetMaterial(){} // RVA: 0x7FFAC3DC3120
        public void CancelInvoke(){} // RVA: 0x7FFAC3DC32A0
        public void Invoke(){} // RVA: 0x7FFAC3DC32F0
        public void InvokeRepeating(){} // RVA: 0x7FFAC3DC3360
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFAC3DC33C0
        public void set_name(){} // RVA: 0x7FFAC3DC37F0
        public void StartCoroutine(){} // RVA: 0x7FFAC3DC3840
        public void GetBufferAsTypeSafe(){} // RVA: 0x7FFAC3DC3A10
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFAC3DC3AC0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3DC3CE0
        public void StopCoroutine(){} // RVA: 0x7FFAC3DC3DF0
        public void ToScale(){} // RVA: 0x7FFAC3DC3F40
        public void Awake(){} // RVA: 0x7FFAC3DC40B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC3DC4410
        public void set_useGUILayout(){} // RVA: 0x7FFAC3DC4790
        public void print(){} // RVA: 0x7FFAC3DC4A50
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3DC4AA0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3DC4B10
        public void InvokeDelayed(){} // RVA: 0x7FFAC3DC4F70
        public void CancelInvoke_A60ADDEE5BA9(){} // RVA: 0x7FFAC3DC4FC0
        public void GetGameObject_8A4(){} // RVA: 0x7FFAC3DC5040
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3DC55A0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3DC5630
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3DC5680
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3DC5A00
        public void GetScriptClassName(){} // RVA: 0x7FFAC3DC5A60
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC3DC5BB0
        public void ApplyPlayerVoiceVolume(){} // RVA: 0x7FFAC3DC5CC0
        public void SetNetworkSerializerFieldNull(){} // RVA: 0x7FFAC3DC5D10
        public void get_IsSpeaking(){} // RVA: 0x7FFAC3DC5D90
        public void SetNetworkPropertyFromHashtable(){} // RVA: 0x7FFAC3DC5E10
        public void GetMaterial_51B941EAA786(){} // RVA: 0x7FFAC3DC5FC0
        public void DoIsValueConsideredPressed(){} // RVA: 0x7FFAC3DC60A0
        public void GetGameObject_587(){} // RVA: 0x7FFAC3DC60F0
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFAC3DC6160
        public void SetMonitoredReferenceWithExceptionHandling(){} // RVA: 0x7FFAC3DC6270
        public void GetGameObject_C61(){} // RVA: 0x7FFAC3DC62D0
        public void GetGameObject_011(){} // RVA: 0x7FFAC3DC6730
        public void InvokeRoomPropertyAction(){} // RVA: 0x7FFAC3DC6770
        public void SetPosition(){} // RVA: 0x7FFAC3DC69E0
        public void Start(){} // RVA: 0x7FFAC3DC6A40
        public void GetGameObject_3C1(){} // RVA: 0x7FFAC3DC6CF0
        public void GetGameObject_B72(){} // RVA: 0x7FFAC3DC6D40
        public void HasPlayerTagOfType(){} // RVA: 0x7FFAC3DC6DC0
        public void AttachNetworkComponentToPlayer(){} // RVA: 0x7FFAC3DC6F80
        public void SetMonitoredReferenceWithExceptionHandling_68EAC6E12ABF(){} // RVA: 0x7FFAC3DC6F90
        public void ComputehasVeryNegativeTrustLevel(){} // RVA: 0x7FFAC3DC7090
        public void ResetNetworkWriteBuffer(){} // RVA: 0x7FFAC3DC7220
        public void GetPhotonRoomPropertyValue(){} // RVA: 0x7FFAC3DC7670
        public void HasPlayerTagByComponent(){} // RVA: 0x7FFAC3DC76E0
        public void OnEnable(){} // RVA: 0x7FFAC3DC7740
        public void get_AvatarScaleParameter(){} // RVA: 0x7FFAC3DC7840
        public void InvokeStaticVoidMethod(){} // RVA: 0x7FFAC3DC78B0
        public void UpdateActive(){} // RVA: 0x7FFAC3DC7900
        public void InitializeNetworkSyncContainer(){} // RVA: 0x7FFAC3DC7A10
        public void AssignPhotonRoomInstance(){} // RVA: 0x7FFAC3DC7BA0
        public void Computeenabled(){} // RVA: 0x7FFAC3DC7EF0
        public void ComputeisActiveAndE(){} // RVA: 0x7FFAC3DC8000
        public void Start_4D849DD8E6B5(){} // RVA: 0x7FFAC3DC8050
        public void set_UploadProgressChanged(){} // RVA: 0x7FFAC3DC80C0
        public void get_caretBlinkRate(){} // RVA: 0x7FFAC3DC8130
        public void GetActiveInHierarchy_0C3(){} // RVA: 0x7FFAC3DC8230
        public void SyncMuteStateFromNetwork(){} // RVA: 0x7FFAC3DC8300
        public void set_VoiceGain(){} // RVA: 0x7FFAC3DC8860
        public void GetGameObject(){} // RVA: 0x7FFAC3DC8BB0
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFAC3DC8C00
        public void IsLocalPlayerOrNoNetworkRef(){} // RVA: 0x7FFAC3DC8CD0
        public void SetPlayerVoiceGainClamped(){} // RVA: 0x7FFAC3DC8D90
        public void GetTransform_FD1(){} // RVA: 0x7FFAC3DC8DE0
        public void Start_8865CA760C61(){} // RVA: 0x7FFAC3DC8E60
        public void GetTransform(){} // RVA: 0x7FFAC3DC8FC0
        public void SetActive(){} // RVA: 0x7FFAC3DC9020
        public void IsPlayerAvatarPoseValid(){} // RVA: 0x7FFAC3DC91F0
        public void TeleportToWithoutForce(){} // RVA: 0x7FFAC3DC9240
        public void set_size_Injected(){} // RVA: 0x7FFAC3DC92C0
        public void ConfigureAssetPreloader(){} // RVA: 0x7FFAC3DC93E0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFAC3DC9730
        public void get_activeInHierarchy(){} // RVA: 0x7FFAC3DC98B0
        public void SetPlayerTagWithoutNotify(){} // RVA: 0x7FFAC3DC99C0
        public void IsLocalPlayerOrInTrustGroup(){} // RVA: 0x7FFAC3DC9B10
        public void CloneSingle(){} // RVA: 0x7FFAC3DC8BB0
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7FFAC3DC9C20
        public void UpdatePlayerVoiceAndAvatar(){} // RVA: 0x7FFAC3DC9C80
        public void GetPlayerAvatarIdFromNetworkOwner(){} // RVA: 0x7FFAC3DC9DE0
        public void get_RoundTripVariance(){} // RVA: 0x7FFAC3DC9EA0
        public void get_destroyCancellationToken_D41FDC064A32(){} // RVA: 0x7FFAC3DCA540
    }

    /// <summary>Originally: ÌÏÏÏÎÌÎÍÌÍÏÍÍÏÎÏÎÎÍÏÎÌÌ</summary>
    public class VRCPlayerSibling_A428
    {
        public object f_673;
        public object f_45B;
        public object f_3E6;
        public object f_D2A;
        public object f_3C3;
        public object f_367;

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFAC2C58E90
        public void Computetransform(){} // RVA: 0x7FFAC2C58E90
        public void get_enableAutoSizing(){} // RVA: 0x7FFAC2C58E90
        public void set_NetworkSerializerReference(){} // RVA: 0x7FFAC2C588A0
        public void get_disclaimerText(){} // RVA: 0x7FFAC2C588A0
        public void get_IsStaticInstanceFlagSet(){} // RVA: 0x7FFAC2C588A0
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFAC2C588A0
        public void IsLocalPlayerMaster(){} // RVA: 0x7FFAC2C59D00
        public void Enable(){} // RVA: 0x7FFAC2C71060
    }

    /// <summary>Originally: ÏÍÌÌÍÎÍÌÏÎÌÎÎÎÌÎÌÌÎÍÏÏÎ</summary>
    public class VRCPlayerSibling_AFD7Sibling_0E3E
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
        public void Deconstruct(){} // RVA: 0x7FFAC2C7AF60
        public void Enable(){} // RVA: 0x7FFAC2C71060
        // ── 16 unresolved (hash) ──
        public void m_42A(){} // RVA: 0x7FFAC2C70980
        public void m_6E6(){} // RVA: 0x7FFAC2C59D00
        public void m_240(){} // RVA: 0x7FFAC2C58E90
        public void m_25F(){} // RVA: 0x7FFAC2C7AF60
        public void m_113(){} // RVA: 0x7FFAC2C70A40
        // ... 11 more unresolved methods
    }

    /// <summary>Originally: ÌÍÎÍÍÎÌÌÌÍÍÏÏÌÎÍÎÍÎÎÎÎÎ</summary>
    public class VRCPlayerSibling_AFD7_AFD7 : Object
    {
        public System.Action _name; // 0x10
        public VRC.Core.APIUser _hideFlags; // 0x18
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> f_489; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3771530
        public void Equals(){} // RVA: 0x7FFAC3771570
        public void GetHashCode(){} // RVA: 0x7FFAC2F21320
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void CompareBaseObjects(){} // RVA: 0x7FFAC37715B0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC3771640
        public void Initialize(){} // RVA: 0x7FFAC2F247C0
        public void set_name(){} // RVA: 0x7FFAC3771740
        public void Instantiate(){} // RVA: 0x7FFAC3771830
        public void ToString(){} // RVA: 0x7FFAC3006850
        public void ToString_11376EAB1E90(){} // RVA: 0x7FFAC3771870
        public void PerformCriticalCleanup(){} // RVA: 0x7FFAC37719F0
        public void ComputegameObject(){} // RVA: 0x7FFAC2F45210
        public void Awake(){} // RVA: 0x7FFAC3006850
        public void get_PlayerApiReference(){} // RVA: 0x7FFAC2F21320
        public void .ctor_D0A8475FC849(){} // RVA: 0x7FFAC3771A30
        public void Initialize_7DFC0741BE80(){} // RVA: 0x7FFAC3771A70
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x7FFAC3771B60
        public void Destroy(){} // RVA: 0x7FFAC3771BA0
        public void InitializePlayerNetworkSerialization(){} // RVA: 0x7FFAC3771C90
        public void DestroyImmediate(){} // RVA: 0x7FFAC2F21320
        public void Init_1FC32922BB8C(){} // RVA: 0x7FFAC2F87E80
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3771CD0
        public void set_statusDescription(){} // RVA: 0x7FFAC3771D10
        public void FindObjectsByType(){} // RVA: 0x7FFAC2F21320
        public void .cctor(){} // RVA: 0x7FFAC2F44D80
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3771D50
    }

    /// <summary>Originally: ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ</summary>
    public class VRCPlayer_3561 : NetworkReadyHandler_68D0_68D0
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
        public System.Collections.Generic.HashSet`1<0x6B170050> ÌÍÏÍÏÎÌÏÏÎÌÎÍÍÍÎÍÍÌÏÏÏÌ; // 0x2B0
        public System.Collections.Generic.List`1<ÌÍÌÏÌÏÌÍÍÌÎÍÎÎÎÍÏÍÌÌÍÏÍ> ÌÌÎÌÎÌÍÏÎÎÍÏÏÎÎÌÎÌÍÏÎÍÍ; // 0x2B8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> <ÌÍÏÍÎÍÌÌÌÎÏÍÎÏÍÏÌÍÏÌÎÏÏ>k__BackingField; // 0x2C0
        public System.Collections.Generic.Queue`1<int> ÏÌÏÌÎÏÏÌÎÏÎÏÌÍÏÏÌÏÏÍÎÏÌ; // 0x2C8
        public int ÌÌÏÌÌÍÎÍÍÍÌÌÌÎÏÎÎÍÍÎÌÌÌ; // 0x2D0

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFAC41274B0
        public void Computetransform_F8806A6B5CFD_F8806A6B5CFD(){} // RVA: 0x7FFAC413E6C0 | overloaded x2
        public void get_enableAutoSizing(){} // RVA: 0x7FFAC41276F0
        public void set_NetworkSerializerReference(){} // RVA: 0x7FFAC4127700
        public void get_disclaimerText(){} // RVA: 0x7FFAC3079460
        public void get_IsStaticInstanceFlagSet(){} // RVA: 0x7FFAC41277B0
        public void IsPlayerAvatarAndNetworkReady(){} // RVA: 0x7FFAC41277D0
        public void IsLocalPlayerMaster(){} // RVA: 0x7FFAC4127930
        public void SetEnabled_281(){} // RVA: 0x7FFAC4127AF0
        public void GetBufferAsTypeSafe(){} // RVA: 0x7FFAC35466F0
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFAC4127B00
        public void DoGetMaterial_A46(){} // RVA: 0x7FFAC4127B20
        public void ResolvePlayerAvatarFromNetworkState(){} // RVA: 0x7FFAC4127C80
        public void SetPlayerAnimatorFromNetworkObject(){} // RVA: 0x7FFAC4127CE0
        public void Awake(){} // RVA: 0x7FFAC4127E30
        public void get_PlayerApiReference_D651603365EF_D651603365EF(){} // RVA: 0x7FFAC413B900 | overloaded x2
        public void DoOpenURL_7CE(){} // RVA: 0x7FFAC4128E00
        public void get_IsLocalPlayerDefault(){} // RVA: 0x7FFAC4128FB0
        public void get_IsInvisible(){} // RVA: 0x7FFAC4129100
        public void DoOpenURL_EA4(){} // RVA: 0x7FFAC4129440
        public void InitializePlayerNetworkSerialization(){} // RVA: 0x7FFAC4129820
        public void GetGameObject_786(){} // RVA: 0x7FFAC4129830
        public void Dispose(){} // RVA: 0x7FFAC4129900
        public void GetGameObject_8A4(){} // RVA: 0x7FFAC412A720
        public void set_statusDescription(){} // RVA: 0x7FFAC412A730
        public void get_onEndTextSelection(){} // RVA: 0x7FFAC39C0A30
        public void GetGameObject_EF0(){} // RVA: 0x7FFAC412AB40
        public void GetIKSolver(){} // RVA: 0x7FFAC412AB90
        public void get_IsLocalPlayerFallback(){} // RVA: 0x7FFAC412ACD0
        public void OnPlayerDisconnectCleanup(){} // RVA: 0x7FFAC412ACE0
        public void GetGameObject_8A4_FA4BCC271619(){} // RVA: 0x7FFAC412ADD0
        public void ApplyPlayerVoiceVolume(){} // RVA: 0x7FFAC412AF30
        public void SetNetworkSerializerFieldNull(){} // RVA: 0x7FFAC412AF40
        public void get_IsSpeaking(){} // RVA: 0x7FFAC412B0E0
        public void SetNetworkPropertyFromHashtable(){} // RVA: 0x7FFAC412B140
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void DoIsValueConsideredPressed(){} // RVA: 0x7FFAC412B4E0
        public void GetGameObject_587(){} // RVA: 0x7FFAC34F9180
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFAC3544790
        public void GetGameObject_DA1(){} // RVA: 0x7FFAC412B640
        public void GetGameObject_C61(){} // RVA: 0x7FFAC412B740
        public void GetGameObject_011(){} // RVA: 0x7FFAC412B890
        public void get_rootIMGUIContainer(){} // RVA: 0x7FFAC412B8E0
        public void SetPosition(){} // RVA: 0x7FFAC412BA10
        public void Start(){} // RVA: 0x7FFAC412BC60
        public void GetGameObject_3C1(){} // RVA: 0x7FFAC412BD00
        public void GetGameObject_B72(){} // RVA: 0x7FFAC412BD50
        public void HasPlayerTagOfType(){} // RVA: 0x7FFAC412BF60
        public void AttachNetworkComponentToPlayer(){} // RVA: 0x7FFAC412C520
        public void InitializeNetworkSyncContainer_6D613B0497BA_6D613B0497BA(){} // RVA: 0x7FFAC412D5E0 | overloaded x2
        public void ComputehasVeryNegativeTrustLevel(){} // RVA: 0x7FFAC412D050
        public void ResetNetworkWriteBuffer(){} // RVA: 0x7FFAC412D140
        public void DoGetFileApiURL(){} // RVA: 0x7FFAC412D150
        public void HasPlayerTagByComponent(){} // RVA: 0x7FFAC412D210
        public void ClearVoiceAndNotifyVisibility(){} // RVA: 0x7FFAC412D2F0
        public void get_AvatarScaleParameter(){} // RVA: 0x7FFAC412D4D0
        public void DecryptPlayerEncryptionKey(){} // RVA: 0x7FFAC412D5A0
        public void GetTransform_0E5(){} // RVA: 0x7FFAC313BE20
        public void get_VoiceDistanceFar(){} // RVA: 0x7FFAC412D9B0
        public void ComputeIsSelf(){} // RVA: 0x7FFAC412DCF0
        public void ComputeisActiveAndE(){} // RVA: 0x7FFAC412DDE0
        public void GetOrCreatePlayerAnimationController(){} // RVA: 0x7FFAC412E340
        public void set_UploadProgressChanged(){} // RVA: 0x7FFAC412E500
        public void get_caretBlinkRate(){} // RVA: 0x7FFAC412E510
        public void GetActiveInHierarchy_0C3(){} // RVA: 0x7FFAC412E520
        public void SyncMuteStateFromNetwork(){} // RVA: 0x7FFAC412E600
        public void set_VoiceGain(){} // RVA: 0x7FFAC412E780
        public void GetGameObject(){} // RVA: 0x7FFAC412E850
        public void GetOrCreateCachedNetworkView(){} // RVA: 0x7FFAC412E980
        public void IsLocalPlayerOrNoNetworkRef(){} // RVA: 0x7FFAC412E990
        public void SetPlayerVoiceGainClamped(){} // RVA: 0x7FFAC412EAB0
        public void GetTransform_FD1(){} // RVA: 0x7FFAC412EB60
        public void SetPosition_461DC02BEB13(){} // RVA: 0x7FFAC412F020
        public void GetTransform(){} // RVA: 0x7FFAC412F1A0
        public void SetActive(){} // RVA: 0x7FFAC412F220
        public void IsPlayerAvatarPoseValid(){} // RVA: 0x7FFAC412F2F0
        public void TeleportToWithoutForce(){} // RVA: 0x7FFAC412F360
        public void DoIsFriendsWith(){} // RVA: 0x7FFAC412F530
        public void BuildPlayerNetworkDataSnapshot(){} // RVA: 0x7FFAC412F5B0
        public void HideAndDeactivateObject(){} // RVA: 0x7FFAC412F7C0
        public void SetPlayerTagWithoutNotify(){} // RVA: 0x7FFAC412F9F0
        public void SetPlayerTagWithoutNotify_FC1B86B92401(){} // RVA: 0x7FFAC412FA00
        public void IsLocalPlayerOrInTrustGroup(){} // RVA: 0x7FFAC412FCE0
        public void CloneSingle(){} // RVA: 0x7FFAC412FEE0
        public void SelectAll(){} // RVA: 0x7FFAC412FEF0
        public void UpdatePlayerVoiceAndAvatar(){} // RVA: 0x7FFAC4130AC0
        public void GetPlayerAvatarIdFromNetworkOwner(){} // RVA: 0x7FFAC412ACD0
        public void SetAvatarObjectActiveFromLookup(){} // RVA: 0x7FFAC4130DB0
        public void GetAvatarObjectFromLookup(){} // RVA: 0x7FFAC4131010
        public void get_AssemblyReader(){} // RVA: 0x7FFAC39C5D60
        public void get_ComponentIntValueAt192(){} // RVA: 0x7FFAC41310F0
        public void DoLocalizeVariant(){} // RVA: 0x7FFAC4131240
        public void OnPlayerDisconnectCleanup_4389E9592372(){} // RVA: 0x7FFAC41312F0
        public void ComputehasTrustedTrustLevel(){} // RVA: 0x7FFAC4131300
        public void get_TimelineController(){} // RVA: 0x7FFAC354E2F0
        public void GetReplyMessage(){} // RVA: 0x7FFAC41313F0
        public void __set_effectDistance__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFAC4131600
        public void get_VoiceVolumetricRadius(){} // RVA: 0x7FFAC4131680
        public void SetCallbackIfStringMatches(){} // RVA: 0x7FFAC4131A10
        public void set_membersOnly(){} // RVA: 0x7FFAC3D20B50
        public void set_NetworkIDCollection(){} // RVA: 0x7FFAC4131BB0
        public void set_NetworkIDCollection_3FFCF9C3FE03(){} // RVA: 0x7FFAC4131C80
        public void set_StaticFloatProperty(){} // RVA: 0x7FFAC4131CE0
        public void SetFloatAndInvokeDelegate(){} // RVA: 0x7FFAC4131D40
        public void Invoke(){} // RVA: 0x7FFAC4131DC0
        public void AllocateNetworkEventWithThreeArgs(){} // RVA: 0x7FFAC4132060
        public void get_VoiceDistanceNear(){} // RVA: 0x7FFAC4132110
        public void set_ValidExpressions(){} // RVA: 0x7FFAC300F9E0
        public void IsReadyAndNetworkActive(){} // RVA: 0x7FFAC4132190
        public void IsReadyAndNetworkActive_DFA5D4C1065F(){} // RVA: 0x7FFAC41322C0
        public void TruncateStringToMaxLength(){} // RVA: 0x7FFAC4132470
        public void get_RootTaskCollection(){} // RVA: 0x7FFAC4132480
        public void set_dpad(){} // RVA: 0x7FFAC41326A0
        public void OnDestroy_impl(){} // RVA: 0x7FFAC4132700
        public void set_IsSpeaking(){} // RVA: 0x7FFAC4132880
        public void SetNetworkComponentFromJoinData(){} // RVA: 0x7FFAC4132B70
        public void GetPosition(){} // RVA: 0x7FFAC4132CB0
        public void ToString(){} // RVA: 0x7FFAC4132D90
        public void get_onValidateInput(){} // RVA: 0x7FFAC4132FB0
        public void TryFlushPendingVisibilityChange(){} // RVA: 0x7FFAC4133630
        public void DoReset(){} // RVA: 0x7FFAC2F9CD50
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4133750
        public void ComputerealtimeSinceStar(){} // RVA: 0x7FFAC4133910
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void get_onValueChanged(){} // RVA: 0x7FFAC4133AD0
        public void get_Playlist(){} // RVA: 0x7FFAC33F8150
        public void CheckIsDone_1D0(){} // RVA: 0x7FFAC4133D70
        public void DoPlayHelper_6BE(){} // RVA: 0x7FFAC39AF520
        public void ComputeTransformFromBufferPosition(){} // RVA: 0x7FFAC4133F90
        public void UpdateBipedIK(){} // RVA: 0x7FFAC2FD5BE0
        public void CreateAndRegisterNetworkCallback(){} // RVA: 0x7FFAC41340C0
        public void SendBooleanNetworkEvent(){} // RVA: 0x7FFAC4134110
        public void CheckIsDone_E12(){} // RVA: 0x7FFAC4134160
        public void CheckIsDone_D9D(){} // RVA: 0x7FFAC4134250
        public void CompareExchangePlayerFieldAtOffset336(){} // RVA: 0x7FFAC4134260
        public void set_recentering(){} // RVA: 0x7FFAC39A8050
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void ConfiguretriggerPressed(){} // RVA: 0x7FFAC4134460
        public void set_StaticFloatProperty_67276FA25C4D(){} // RVA: 0x7FFAC4134540
        public void IsPlayerNotBlockedByActorId(){} // RVA: 0x7FFAC41345D0
        public void get_UploadLength(){} // RVA: 0x7FFAC2F8C5F0
        public void get_ActiveBlend(){} // RVA: 0x7FFAC3544EF0
        public void IsPlayerBlockedOrMuted(){} // RVA: 0x7FFAC4135370
        public void SetPlayerNetworkTimestampAtomic(){} // RVA: 0x7FFAC412B890
        public void GetLocalOrRemotePlayerIdentity(){} // RVA: 0x7FFAC2FE9500
        public void ApplyAmountFromDoubledOrCopied(){} // RVA: 0x7FFAC4135420
        public void SetMuteIfNotLocal(){} // RVA: 0x7FFAC41354D0
        public void IsPlayerNetworkSynced(){} // RVA: 0x7FFAC2F21320
        public void IsPlayerPresentInWorldByNetworkId(){} // RVA: 0x7FFAC41357F0
        public void ResolveNetworkPlayerReference(){} // RVA: 0x7FFAC4135890
        public void SerializePlayerPositionWithTimestamp(){} // RVA: 0x7FFAC4135940
        public void SetActive_366(){} // RVA: 0x7FFAC4135950
        public void ComputeisPlaying(){} // RVA: 0x7FFAC4135A80
        public void IsPlayerInCurrentWorldInstanceAlt(){} // RVA: 0x7FFAC4135B90
        public void GetTargets_4DDC1A1739B7(){} // RVA: 0x7FFAC2FBF370
        public void ForwardSerializerCall(){} // RVA: 0x7FFAC2F21320
        public void SetForm(){} // RVA: 0x7FFAC39A80B0
        public void ApplyAnimationStateToPlayer(){} // RVA: 0x7FFAC4135D80
        public void ForwardInputFlagToSerializer(){} // RVA: 0x7FFAC4135D90
        public void SetForm_F1BC0801CE48(){} // RVA: 0x7FFAC4136040
        public void PlayEmoteRPC(){} // RVA: 0x7FFAC4136170
        public void GetTypedComponentFromBuffer(){} // RVA: 0x7FFAC4136350
        public void GetPlayerSteamIdFromSingleton(){} // RVA: 0x7FFAC41363B0
        public void GetTypedComponentFromBuffer_874C64E5619C(){} // RVA: 0x7FFAC41363F0
        public void GetGameObject_4B6(){} // RVA: 0x7FFAC4136670
        public void SetVisibilityDirtyFlags(){} // RVA: 0x7FFAC4136800
        public void GetGameObject_CB0(){} // RVA: 0x7FFAC41369A0
        public void SetEnabled_D26(){} // RVA: 0x7FFAC4136A20
        public void SetEnabled_95E(){} // RVA: 0x7FFAC4136B50
        public void SetEnabled_DE4(){} // RVA: 0x7FFAC4136B60
        public void SetEnabled_3F4(){} // RVA: 0x7FFAC4136C30
        public void SetEnabled_205(){} // RVA: 0x7FFAC4136DE0
        public void set_SerializedDataField(){} // RVA: 0x7FFAC4136E50
        public void InitializePlayerNetworkComponents(){} // RVA: 0x7FFAC4136EB0
        public void Getposition(){} // RVA: 0x7FFAC4136F00
        public void GetGameObject_187(){} // RVA: 0x7FFAC4137110
        public void GetGameObject_638(){} // RVA: 0x7FFAC4137460
        public void GetGameObject_197(){} // RVA: 0x7FFAC4137490
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void SetNetworkPropertyFlag(){} // RVA: 0x7FFAC41375C0
        public void OnDestroy(){} // RVA: 0x7FFAC4137630
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFAC4137FB0
        public void get_statusDescription(){} // RVA: 0x7FFAC41385D0
        public void get_membersOnly(){} // RVA: 0x7FFAC33CE5C0
        public void get_onTextSelection(){} // RVA: 0x7FFAC39C1920
        public void get_UploadProgressChanged(){} // RVA: 0x7FFAC4138670
        public void ShouldSyncPlayerDataThisFrame(){} // RVA: 0x7FFAC4138680
        public void GetPlayerAvatarDisplayName(){} // RVA: 0x7FFAC4138870
        public void CompareExchangePlayerFieldAtOffset336_AA84DA02697C(){} // RVA: 0x7FFAC4138A20
        public void set_NetworkIDLookup(){} // RVA: 0x7FFAC4138A90
        public void GetGameObject_017(){} // RVA: 0x7FFAC4138BD0
        public void GetGameObject_8BA(){} // RVA: 0x7FFAC412D210
        public void GetDeltaTime_C44(){} // RVA: 0x7FFAC3D60520
        public void ReplaceAndNormalizeComponentEntry(){} // RVA: 0x7FFAC4138C60
        public void .ctor(){} // RVA: 0x7FFAC4138D80
        public void Initialize(){} // RVA: 0x7FFAC4139520
        public void get_IsAlwaysTrue(){} // RVA: 0x7FFAC4139B30
        public void IsPlayerBlockedOrRestricted(){} // RVA: 0x7FFAC3006850
        public void get_Enabled(){} // RVA: 0x7FFAC4139B80
        public void set_app(){} // RVA: 0x7FFAC39CF5C0
        public void SetNetworkSyncTarget(){} // RVA: 0x7FFAC4139B90
        public void InitializePlayerSyncTarget(){} // RVA: 0x7FFAC4139C50
        public void Doop_Subtraction_243C0AA61A44_243C0AA61A44(){} // RVA: 0x7FFAC413CEB0 | overloaded x2
        public void set_listingIds(){} // RVA: 0x7FFAC39C51C0
        public void set_home(){} // RVA: 0x7FFAC39B1270
        public void ApplyTrustLevelToNameplate(){} // RVA: 0x7FFAC413B690
        public void DoFindRelativeTransformWithPath_65D(){} // RVA: 0x7FFAC413B8A0
        public void get_contentList(){} // RVA: 0x7FFAC3540F70
        public void Decode(){} // RVA: 0x7FFAC413B940
        public void SerializeNetworkSyncFields(){} // RVA: 0x7FFAC413BB00
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFAC39CCB10
        public void GetSyncedParametersDefault(){} // RVA: 0x7FFAC413BBF0
        public void GetActiveAvatarDescriptorComponent(){} // RVA: 0x7FFAC413BC60
        public void get_gameObject(){} // RVA: 0x7FFAC413C020
        public void IsActiveOrPendingDeactivation(){} // RVA: 0x7FFAC413C030
        public void InvokeVirtualPropertyGetter(){} // RVA: 0x7FFAC413C070
        public void hash(){} // RVA: 0x7FFAC413C4D0
        public void SetPlayerAvatarNameplateText(){} // RVA: 0x7FFAC413C6C0
        public void AllocateBooleanEventData(){} // RVA: 0x7FFAC413C880
        public void hash_E5D10119E3F2(){} // RVA: 0x7FFAC413CA90
        public void EnsureDictionaryAtOffset368(){} // RVA: 0x7FFAC413CBA0
        public void InitializeAvatarStatePlayer_A11E14A59D94(){} // RVA: 0x7FFAC413DD00 | overloaded x2
        public void TryGetDictionaryValueByKey(){} // RVA: 0x7FFAC413CC10
        public void get_StaticFloatProperty(){} // RVA: 0x7FFAC413CC90
        public void OnEnable(){} // RVA: 0x7FFAC413CDB0
        public void OnDisable(){} // RVA: 0x7FFAC3F455C0
        public void HasStoredDataAndNotStaticFlag(){} // RVA: 0x7FFAC413CFA0
        public void .cctor(){} // RVA: 0x7FFAC413D030
        public void DoInverse_Injecte(){} // RVA: 0x7FFAC413D350
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFAC3F45170
        public void ResetEnumeratorAndFlag(){} // RVA: 0x7FFAC2F21320
        public void IsPlayerActiveInHierarchy(){} // RVA: 0x7FFAC413D4F0
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFAC35410C0
        public void ComputehasKnownTrustLevel(){} // RVA: 0x7FFAC413DA00
        public void TryApplyPlayerPickupInteraction(){} // RVA: 0x7FFAC413DBC0
        public void IsLocalPlayerOrStaticFlagSet(){} // RVA: 0x7FFAC413DEC0
        public void IsPlayerObjectSynchronized(){} // RVA: 0x7FFAC413E1D0
        public void get_RootTaskCollection_DEFDFB8C697F(){} // RVA: 0x7FFAC413E320
        public void set_position(){} // RVA: 0x7FFAC3503010
        public void get_RootTaskCollection_7F832DCA152C(){} // RVA: 0x7FFAC413E450
        public void GetTypeCode(){} // RVA: 0x7FFAC413E570
        public void ReloadAvatarNetworkedRPC(){} // RVA: 0x7FFAC413E580
        public void get_fontAsset(){} // RVA: 0x7FFAC39AC670
        public void DoLocalizeVariant_8D64940B0397(){} // RVA: 0x7FFAC4131240
        public void get_AssemblyReader_73F0BA222A26(){} // RVA: 0x7FFAC413E6B0
        public void get_NetworkStatusListener(){} // RVA: 0x7FFAC39A6830
    }

}