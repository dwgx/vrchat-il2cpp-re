// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI
// Classes: 100
// Methods: 1610

namespace VRC.UI
{
    /// <summary>Originally: ÎÍÏÍÍÏÎÌÎÏÌÏÍÎÌÏÌÎÏÏÏÌÍ</summary>
    public class PointerBackPressedSibling_58D9_58D9 : PointerBackPressed_5C11_5C11
    {
        public object f_A5C;
        public object f_455;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC43694B0
        public void RaiseCancellation(){} // RVA: 0x7FFAC4369570
        public void SetActive_5E8(){} // RVA: 0x7FFAC4369600
        public void EnableSecondCheckBox(){} // RVA: 0x7FFAC4369660
        public void .ctor(){} // RVA: 0x7FFAC4368D30
    }

    /// <summary>Originally: ÍÏÌÌÏÎÌÏÎÌÌÍÎÎÌÍÌÎÎÏÎÏÍ</summary>
    public class PointerBackPressed_5C11_5C11 : UpdateComponent_B6B3_B6B3
    {
        public float f_A5C;
        public float f_455;
        public float ÍÏÍÍÍÎÍÏÍÌÌÌÍÏÍÎÌÎÍÎÍÏÎ;
        public float ÌÎÌÎÌÎÏÎÍÌÏÌÎÎÏÎÌÍÌÌÍÌÌ;
        public UnityEngine.GameObject ÌÌÏÎÏÎÏÌÎÍÍÌÏÌÎÍÌÏÍÏÎÏÎ; // 0x60
        public UnityEngine.GameObject ÌÎÍÎÎÎÍÎÌÌÍÎÏÌÌÏÌÎÎÏÏÏÍ; // 0x68
        public UnityEngine.UI.Button agreeButton; // 0x70
        public bool ÌÎÏÍÎÎÎÎÎÌÏÎÍÍÏÏÏÎÎÎÏÎÍ; // 0x78
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÌÏÌÎÎÎÏÌÍÌÍÌÍÎÏÏÌÍÍÎÏÍÌ; // 0x80
        public float ÌÍÌÏÍÌÎÍÎÏÌÏÍÎÏÍÍÍÍÌÍÎÏ; // 0x88
        public ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ ÌÌÍÍÏÍÍÎÎÍÌÍÍÍÎÎÏÍÍÏÎÎÌ; // 0x90

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC2C58E90
        public void RaiseCancellation(){} // RVA: 0x7FFAC2C588A0
        public void Start(){} // RVA: 0x7FFAC43659D0
        public void OnEnable(){} // RVA: 0x7FFAC4365B30
        public void OnDisable(){} // RVA: 0x7FFAC4365CC0
        public void SetComponentUpdateStateActive2(){} // RVA: 0x7FFAC4365D20
        public void Update(){} // RVA: 0x7FFAC4365DC0
        public void OnEnable_9F874F030C1F(){} // RVA: 0x7FFAC4365E60
        public void Start_24077EE63E84(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine(){} // RVA: 0x7FFAC4366070
        public void OnApplicationPause(){} // RVA: 0x7FFAC4366170
        public void Equals(){} // RVA: 0x7FFAC3E92FB0
        public void get_Current(){} // RVA: 0x7FFAC4366600
        public void OnBecameInvisible(){} // RVA: 0x7FFAC4366C10
        public void InvokeDelegate(){} // RVA: 0x7FFAC2C70980
        public void BackPressed(){} // RVA: 0x7FFAC39B4E30
        public void .ctor(){} // RVA: 0x7FFAC4366DD0
    }

    /// <summary>Originally: ÎÏÍÎÎÌÎÍÌÏÌÌÏÏÌÎÍÎÍÍÏÍÍ</summary>
    public class PointerBeginDragEndDragHandler_3D5A : MonoBehaviour
    {
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÍÏÎÎÏÎÎÎÌÏÌÌÏÎÌÏÌÎÍÍÍÌÍ; // 0x20
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÏÍÍÍÍÌÏÏÍÏÎÍÌÌÌÍÏÏÎÏÍÍÎ; // 0x28
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÍÍÎÎÍÍÎÏÏÌÏÍÎÍÍÏÌÍÏÌÌÌÏ; // 0x30

        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFAC34D6BC0
        public void OnPointerClick(){} // RVA: 0x7FFAC37CD440
        public void IsInvoking(){} // RVA: 0x7FFAC3539CE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC37CD440
        public void OnEndDrag(){} // RVA: 0x7FFAC37CD440
        public void CancelInvoke(){} // RVA: 0x7FFAC3539CE0
        public void RegisterCancellationOrCoroutine(){} // RVA: 0x7FFAC34D6BC0
        public void OnDrag(){} // RVA: 0x7FFAC3539CE0
        public void StartCoroutine(){} // RVA: 0x7FFAC3539CE0
    }

    /// <summary>Originally: ÍÏÏÍÍÎÍÌÎÎÏÍÎÌÎÍÍÏÌÍÎÎÍ</summary>
    public class PointerBeginDragEndDragHandler_3D5A_1E5B : MonoBehaviour
    {
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÎÍÎÌÌÎÍÌÎÏÍÎÏÌÏÎÍÌÌÏÍÍÌ; // 0x20
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÍÌÌÌÎÍÎÎÌÍÏÎÌÍÍÏÏÏÌÎÏÎÏ; // 0x28
        public System.Action`1<UnityEngine.EventSystems.PointerEventData> ÎÌÎÏÌÏÎÏÎÍÍÏÏÏÌÏÎÏÌÎÍÎÏ; // 0x30

        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFAC3539CE0
        public void OnPointerUp(){} // RVA: 0x7FFAC3539CE0
        public void IsInvoking(){} // RVA: 0x7FFAC3539CE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC37CD440
        public void OnPointerDown(){} // RVA: 0x7FFAC34D6BC0
        public void CancelInvoke(){} // RVA: 0x7FFAC34D6BC0
        public void RegisterCancellationOrCoroutine(){} // RVA: 0x7FFAC37CD440
        public void OnPointerClick(){} // RVA: 0x7FFAC37CD440
    }

    /// <summary>Originally: ÍÎÍÏÏÍÌÎÌÏÎÎÎÏÌÌÍÎÌÏÏÍÎ</summary>
    public class PointerBeginDragEndDragHandler_5A3B : MonoBehaviour
    {
        public bool _5A3B; // 0x20
        public UnityEngine.UI.Slider slider; // 0x28

        // ── Methods ──
        public void set_ValidExpressions(){} // RVA: 0x7FFAC300F9E0
        public void RaiseCancellation(){} // RVA: 0x7FFACB851EB0
        public void OnBeginDrag(){} // RVA: 0x7FFACB851EB0
        public void CancelInvoke(){} // RVA: 0x7FFACB851EE0
        public void Invoke(){} // RVA: 0x7FFACB851EB0
        public void InvokeRepeating(){} // RVA: 0x7FFAC300F9E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEndDrag(){} // RVA: 0x7FFACB851EE0
        public void OnDrag(){} // RVA: 0x7FFACB851EB0
        public void StartCoroutine(){} // RVA: 0x7FFACB851EB0
        public void OnApplicationQuit(){} // RVA: 0x7FFACB851EB0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB851EB0
        public void get_ValidExpressions(){} // RVA: 0x7FFAC300F9D0
        public void .ctor_0892AEE762E3(){} // RVA: 0x7FFAC300F9E0
    }

    /// <summary>Originally: ÍÎÎÎÎÌÍÍÏÏÌÎÏÏÍÍÎÏÏÎÎÌÎ</summary>
    public class PointerBeginDrag_8F34_8F34 : PointerInitializePotentialDragBeginDrag_3B21_3B21
    {
        public UnityEngine.RectTransform _tutorialRectTransform; // 0x180

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFACB819F10
        public void get_Current(){} // RVA: 0x7FFACB81A0E0
        public void StopCoroutine(){} // RVA: 0x7FFACB81A190
        public void OnBeginDrag(){} // RVA: 0x7FFACB81A240
        public void StopCoroutine_E691EC812285(){} // RVA: 0x7FFACB81A260
        public void StopCoroutine_57709D0FCE61(){} // RVA: 0x7FFACB81A190
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACB81A430
        public void .ctor(){} // RVA: 0x7FFACB817B70
        public void Initialize(){} // RVA: 0x7FFACB81A0E0
    }

    /// <summary>Originally: ÍÏÌÍÍÍÌÏÌÎÏÌÎÍÍÌÍÍÏÏÎÎÎ</summary>
    public class PointerClickHandlerSibling_8F7Sibling_B115 : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Events.UnityAction> ÎÎÏÍÎÎÎÏÌÍÌÌÎÍÎÎÍÌÌÎÏÎÏ; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC4883820
        public void Equals(){} // RVA: 0x7FFAC4883AB0
        public void GetHashCode(){} // RVA: 0x7FFAC4883D40
        public void .ctor(){} // RVA: 0x7FFAC4883DA0
        public void Initialize(){} // RVA: 0x7FFAC4883E60
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4884090
        public void GetCachedPtr(){} // RVA: 0x7FFAC48840F0
        public void get_name(){} // RVA: 0x7FFAC4884150
        public void set_name(){} // RVA: 0x7FFAC48841A0
        public void Instantiate(){} // RVA: 0x7FFAC48841F0
        public void ToString(){} // RVA: 0x7FFAC4884420
    }

    /// <summary>Originally: ÌÎÌÎÌÎÎÍÌÌÍÎÏÏÎÏÍÍÎÏÎÍÌ</summary>
    public class PointerClickHandler_05F9_05F9 : MonoBehaviour
    {
        public System.Action ÏÍÌÍÎÏÎÎÎÏÏÏÌÌÌÎÍÌÏÌÎÍÍ; // 0x20

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFAC32032C0
        public void Process(){} // RVA: 0x7FFAC32032C0
        public void OnReceive(){} // RVA: 0x7FFAC32032C0
        public void OnEvent(){} // RVA: 0x7FFAC32032C0
        public void OnPointerClick(){} // RVA: 0x7FFAC32032C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC32032C0
    }

    /// <summary>Originally: ÎÎÏÌÎÎÍÏÎÌÍÍÌÍÌÏÎÏÍÏÏÍÎ</summary>
    public class PointerClickHandler_2BA8_2BA8 : MonoBehaviour
    {
        public TMPro.TextMeshProUGUI _2BA8; // 0x20
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ ÎÍÍÏÏÌÍÏÌÏÎÍÏÍÎÏÎÍÌÍÎÎÌ; // 0x28
        public UnityEngine.UI.VerticalLayoutGroup ÏÎÌÏÎÌÎÏÌÌÎÏÎÎÍÏÎÍÎÌÍÎÌ; // 0x30
        public RenderHeads.Media.AVProVideo.MediaPlayer ÎÍÏÌÌÏÎÍÌÍÌÍÏÎÏÌÌÌÏÏÌÏÍ; // 0x38
        public UnityEngine.GameObject videoPlayerPrefab; // 0x40
        public ÍÍÍÎÎÏÏÏÌÏÎÌÌÌÌÌÏÌÍÍÌÎÏ <ÌÏÎÏÎÏÏÏÎÌÏÍÌÏÏÏÏÌÍÏÏÏÌ>k__BackingField; // 0x48

        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void Start(){} // RVA: 0x7FFACB64E7F0
        public void IsInvoking(){} // RVA: 0x7FFACB64EA40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void InvokeRepeating(){} // RVA: 0x7FFACB64EBD0
        public void OnPointerClick(){} // RVA: 0x7FFACB64F2C0
        public void OnApplicationPause(){} // RVA: 0x7FFACB64F450
        public void StartCoroutine(){} // RVA: 0x7FFAC2F9C730
        public void OnBecameVisible(){} // RVA: 0x7FFAC2F9C740
        public void OnBecameInvisible(){} // RVA: 0x7FFACB64F5E0
    }

    /// <summary>Originally: ÍÏÌÏÏÌÌÍÎÎÎÏÌÍÏÏÍÏÌÍÌÎÏ</summary>
    public class PointerClickHandler_498A_498A : MonoBehaviour
    {
        public TMPro.TMP_InputField _inputField; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB2A57B0
        public void OnPointerClick(){} // RVA: 0x7FFACB2A58B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB2A59C0
        public void get_destroyCancellationToken_2E66351DD1FD(){} // RVA: 0x7FFACB2A5CC0
        public void InvokeRepeating(){} // RVA: 0x7FFACB2A5FC0
        public void CancelInvoke(){} // RVA: 0x7FFACB2A60D0
        public void IsInvoking(){} // RVA: 0x7FFACB2A6100
    }

    /// <summary>Originally: ÌÏÍÎÎÌÏÍÌÎÍÍÍÎÍÍÍÎÏÎÌÏÍ</summary>
    public class PointerClickHandler_83D2_83D2 : MonoBehaviour
    {
        public TMPro.TMP_InputField ÌÏÏÌÍÏÏÌÎÌÎÎÎÏÏÌÎÌÌÎÎÍÎ; // 0x20
        public UnityEngine.Sprite ÏÏÎÍÍÌÍÍÍÎÍÍÌÏÍÌÍÍÎÏÎÎÍ; // 0x28
        public UnityEngine.Sprite ÍÏÌÏÎÍÎÎÍÏÎÍÍÎÏÌÎÍÌÍÎÎÏ; // 0x30
        public UnityEngine.GameObject _hiddenPasswordDisplay; // 0x38
        public TMPro.TextMeshProUGUI _shownPasswordDisplay; // 0x40
        public UnityEngine.UI.Image ÍÌÌÌÌÏÎÍÌÌÍÌÍÏÏÌÍÏÏÏÍÎÎ; // 0x48
        public bool ÎÌÎÍÌÏÍÍÌÏÌÍÌÌÏÍÌÏÏÍÎÌÍ; // 0x50

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC42EB410
        public void OnDisable(){} // RVA: 0x7FFAC42EB610
        public void IsInvoking(){} // RVA: 0x7FFAC42EB750
        public void CancelInvoke(){} // RVA: 0x7FFAC42EB910
        public void Invoke(){} // RVA: 0x7FFAC42EBB60
        public void OnPointerClick(){} // RVA: 0x7FFAC42EBCC0
        public void OnDestroy(){} // RVA: 0x7FFAC42EBDA0
        public void OnApplicationPause(){} // RVA: 0x7FFAC42EBEE0
        public void StartCoroutine(){} // RVA: 0x7FFAC42EC130
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC42EC290
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC42EC450
        public void StopCoroutine(){} // RVA: 0x7FFAC42EC6A0
        public void OnCollisionExit(){} // RVA: 0x7FFAC42EC860
        public void OnTriggerEnter(){} // RVA: 0x7FFAC42ECAB0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC42EBCC0
    }

    /// <summary>Originally: ÎÌÎÏÏÎÎÌÍÎÌÌÏÌÎÌÎÍÌÏÎÍÏ</summary>
    public class PointerClickHandler_8880_8880 : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerClick(){} // RVA: 0x7FFACB8158C0
        public void Handle(){} // RVA: 0x7FFACB815990
        public void Process(){} // RVA: 0x7FFACB815A60
        public void OnReceive(){} // RVA: 0x7FFACB815B30
        public void OnEvent(){} // RVA: 0x7FFACB815C00
        public void CancelInvoke(){} // RVA: 0x7FFACB815CD0
    }

    /// <summary>Originally: ÍÎÍÍÌÎÏÏÌÍÏÏÏÎÍÍÍÎÍÍÏÎÌ</summary>
    public class PointerClickHandler_C334_C334 : MonoBehaviour
    {
        public System.Collections.Generic.List`1<System.Action> ÌÏÍÎÏÌÎÍÍÎÎÍÍÌÍÎÍÌÎÍÎÏÌ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB7E1870
        public void RaiseCancellation(){} // RVA: 0x7FFACB7E18D0
        public void .ctor(){} // RVA: 0x7FFACB7E1950
        public void OnPointerClick(){} // RVA: 0x7FFACB7E1A50
        public void Invoke(){} // RVA: 0x7FFACB7E1BA0
        public void InvokeRepeating(){} // RVA: 0x7FFACB7E1C00
        public void CancelInvoke(){} // RVA: 0x7FFACB7E1C80
        public void OnDestroy(){} // RVA: 0x7FFACB7E1CF0
        public void StartCoroutine(){} // RVA: 0x7FFACB7E1C80
        public void OnApplicationQuit(){} // RVA: 0x7FFACB7E1D60
        public void OnBecameVisible(){} // RVA: 0x7FFACB7E1CF0
    }

    /// <summary>Originally: ÎÌÌÎÍÎÎÍÎÍÌÍÏÏÎÌÌÍÎÏÏÏÍ</summary>
    public class PointerClickHandler_D98D_D98D : MonoBehaviour
    {
        public UnityEngine.GameObject ÌÏÍÍÌÌÎÌÎÌÏÏÎÍÍÌÌÌÏÏÏÍÎ; // 0x20
        public UnityEngine.GameObject ÎÌÎÌÌÎÍÌÏÍÌÎÏÏÏÍÎÏÎÍÏÏÏ; // 0x28
        public int ÎÎÎÍÍÏÍÌÎÍÎÏÎÏÎÍÌÏÍÏÎÌÍ; // 0x30
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÏÍÏÎÏÌÍÎÌÎÌÏÌÏÍÎÌÎÍÍÏÌÎ; // 0x38
        public VRC.UI.Core.Styles.StyleElement ÎÏÏÌÍÍÏÎÎÍÌÎÎÏÏÎÍÏÌÏÏÏÎ; // 0x40
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ ÍÌÎÎÍÏÍÌÌÏÌÏÎÏÎÍÎÍÌÍÎÎÏ; // 0x48
        public UnityEngine.UI.Button ÎÌÏÏÏÍÌÎÏÏÎÎÍÏÌÌÍÍÏÏÏÏÎ; // 0x50

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB75D470
        public void RaiseCancellation(){} // RVA: 0x7FFACB75D5E0
        public void Start(){} // RVA: 0x7FFACB75D760
        public void Awake(){} // RVA: 0x7FFACB75D7F0
        public void OnDestroy(){} // RVA: 0x7FFACB75D960
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerClick(){} // RVA: 0x7FFACB75DAD0
        public void IsInvoking(){} // RVA: 0x7FFACB75DDE0
        public void StartCoroutine(){} // RVA: 0x7FFACB75DFA0
        public void OnDisable(){} // RVA: 0x7FFACB75E110
        public void OnBecameVisible(){} // RVA: 0x7FFACB75E280
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB75E400
        public void StopCoroutine(){} // RVA: 0x7FFACB75E570
        public void OnCollisionStay(){} // RVA: 0x7FFACB75E6E0
        public void OnEnable(){} // RVA: 0x7FFACB75E9F0
    }

    /// <summary>Originally: ÍÌÍÎÌÍÍÍÌÍÎÍÌÍÍÍÏÎÌÏÌÏÍ</summary>
    public class PointerClickHandler_F5E1_F5E1 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB925A90
        public void OnPointerClick(){} // RVA: 0x7FFACB925A90
        public void IsInvoking(){} // RVA: 0x7FFACB925A90
        public void CancelInvoke(){} // RVA: 0x7FFACB925A90
        public void Invoke(){} // RVA: 0x7FFACB925A90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB925A90
        public void OnPointerClick_505524E6AF0E(){} // RVA: 0x7FFACB925A90
    }

    /// <summary>Originally: ÎÍÏÎÎÍÎÌÌÏÏÍÌÎÌÎÍÎÍÎÏÎÏ</summary>
    public class PointerClickPointerDown_DD53_DD53 : PointerClickSubmit_50A4_50A4
    {
        public VRC.Localization.LocalizableString f_5E3; // 0x158
        public UnityEngine.Events.UnityEvent f_FA0; // 0x180
        public UnityEngine.Events.UnityEvent f_BFF; // 0x188
        public UnityEngine.Events.UnityEvent f_92E; // 0x190
        public bool _softInteractable; // 0x198

        // ── Methods ──
        public void set_MotionBlurCameras(){} // RVA: 0x7FFACB85A440
        public void get_onClick(){} // RVA: 0x7FFACB85A440
        public void OnPointerUp(){} // RVA: 0x7FFACB85A4C0
        public void get_Transform(){} // RVA: 0x7FFACB85A440
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFAC35410C0
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7FFAC3540F60
        public void OnPointerClick(){} // RVA: 0x7FFACB85A510
        public void .ctor(){} // RVA: 0x7FFACB85A600
        public void Initialize(){} // RVA: 0x7FFACB85A8D0
        public void get_PlatformOptionsIOS_50C7F6C660DB(){} // RVA: 0x7FFAC35410C0
        public void OnPointerUp_258980266904(){} // RVA: 0x7FFACB85A970
        public void get_PlatformOptionsTVOS_1580F2F7C543(){} // RVA: 0x7FFAC3540F60
        public void Awake(){} // RVA: 0x7FFACB85AA10
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAC8B3EBF0
        public void OnMove(){} // RVA: 0x7FFACB85A440
        public void OnPointerDown(){} // RVA: 0x7FFACB85AAB0
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7FFAC354B1B0
        public void get_PlatformOptionsMacOSX_83172BC24A43(){} // RVA: 0x7FFAC354B1B0
    }

    /// <summary>Originally: ÍÌÎÌÌÏÎÌÌÌÍÎÎÎÏÏÍÏÌÌÌÏÎ</summary>
    public class PointerClickPointerEnterHandler_F9B1_F9B1 : MonoBehaviour
    {
        public UnityEngine.AudioClip ÏÎÎÌÌÏÌÍÍÌÌÎÎÍÎÏÏÌÎÎÏÎÏ; // 0x20
        public UnityEngine.AudioClip ÍÍÍÍÎÍÏÎÍÎÎÏÌÍÎÌÎÌÍÌÏÏÌ; // 0x28
        public UnityEngine.AudioClip ÌÏÎÍÏÌÍÍÏÍÎÎÍÎÎÍÏÎÍÌÎÏÍ; // 0x30
        public float ÏÏÎÍÏÎÎÌÏÎÌÏÏÏÌÎÌÌÎÍÏÍÎ;
        public UISoundCollection ÌÎÎÎÎÌÎÍÌÏÎÏÏÏÌÏÍÍÌÌÍÏÎ; // 0x38
        public UnityEngine.Sprite ÌÍÌÌÍÌÌÍÎÌÌÌÎÌÎÍÏÌÍÎÌÍÌ; // 0x40
        public UnityEngine.Sprite ÌÏÏÍÎÍÎÍÏÎÏÏÏÍÌÎÍÍÎÎÌÏÏ; // 0x48
        public UnityEngine.Sprite ÏÎÍÎÌÏÍÌÏÎÎÍÍÎÌÎÏÏÏÍÌÌÎ; // 0x50
        public UnityEngine.GameObject ÏÏÎÎÌÏÌÏÎÏÏÍÎÎÏÎÎÍÍÍÎÏÍ; // 0x58

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC426B8E0
        public void Start(){} // RVA: 0x7FFAC426B9A0
        public void OnEnable(){} // RVA: 0x7FFAC426BEF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerClick(){} // RVA: 0x7FFAC426C010
        public void OnPointerEnter(){} // RVA: 0x7FFAC426C160
        public void CancelInvoke(){} // RVA: 0x7FFAC426C390
        public void IsInvoking(){} // RVA: 0x7FFAC426C8E0
        public void StartCoroutine(){} // RVA: 0x7FFAC426C9A0
        public void OnBecameVisible(){} // RVA: 0x7FFAC426CBD0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC426D120
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC426D270
        public void OnPointerExit(){} // RVA: 0x7FFAC426D4A0
    }

    /// <summary>Originally: ÎÏÌÎÌÎÌÌÍÌÌÌÎÍÌÌÏÍÍÏÌÎÍ</summary>
    public class PointerClickPointerMoveHandler_4464_4464 : MonoBehaviour
    {
        public UnityEngine.GameObject _4464; // 0x20
        public UnityEngine.GameObject optionPrefab; // 0x28
        public UnityEngine.Transform dividerContainer; // 0x30
        public UnityEngine.Transform optionsContainer; // 0x38
        public ÍÎÏÍÏÍÌÏÏÍÏÍÏÍÌÏÏÌÏÎÎÎÏ mainGraphic; // 0x40
        public ÍÎÏÍÏÍÌÏÏÍÏÍÏÍÌÏÏÌÏÎÎÎÏ selectionGraphic; // 0x48
        public UnityEngine.RectTransform selectionObj; // 0x50
        public UnityEngine.CanvasGroup optionsCanvasGroup; // 0x58
        public Sounds sounds; // 0x60
        public System.Action`1<int> ÍÏÍÍÎÌÎÌÏÎÌÏÍÎÌÌÎÎÏÌÎÌÏ; // 0x80
        public System.Action`1<int> ÍÎÍÌÎÎÍÎÎÏÍÍÍÎÌÎÍÎÏÍÏÌÎ; // 0x88
        public System.Action`1<int> ÍÌÏÍÍÌÌÌÌÍÏÌÍÎÍÏÎÏÎÎÍÏÌ; // 0x90
        public ÏÏÍÌÎÌÏÍÎÏÌÏÌÌÌÍÌÌÎÎÍÏÎ ÎÎÏÏÏÍÎÌÍÎÍÍÌÍÌÎÎÏÍÌÎÏÌ; // 0x98
        public ÌÏÌÏÌÎÍÎÏÌÎÌÎÏÍÏÏÌÍÍÎÌÏ ÏÍÎÍÌÏÎÏÍÍÍÌÌÌÌÌÏÍÍÍÏÎÍ; // 0xA0
        public ÏÍÎÌÌÏÌÍÎÍÏÌÍÌÌÏÌÌÍÎÏÌÏ ÌÌÎÌÌÎÍÍÌÍÍÎÌÎÍÍÎÏÎÌÏÎÎ; // 0xA8
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÎÏÍÌÎÌÎÌÎÏÍÌÏÍÏÍÌÍÌÏÍÎÏ; // 0xB0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÏÍÎÍÎÌÍÍÍÎÍÌÎÎÌÌÌÌÌÍÏÏÌ; // 0xB8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB2BA6D0
        public void Start(){} // RVA: 0x7FFACB2BA7D0
        public void IsInvoking(){} // RVA: 0x7FFACB2BA880
        public void CancelInvoke(){} // RVA: 0x7FFACB2BA980
        public void OnBeginDrag(){} // RVA: 0x7FFACB2BAC70
        public void get_HasProxy(){} // RVA: 0x7FFACB2BACD0
        public void .ctor(){} // RVA: 0x7FFACB2BACE0
        public void Initialize(){} // RVA: 0x7FFACB2BAED0
        public void StartCoroutine(){} // RVA: 0x7FFACB2BB230
        public void OnBecameVisible(){} // RVA: 0x7FFACB2BB330
        public void get_version(){} // RVA: 0x7FFAC2F8C040
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB2BB910
        public void StopCoroutine(){} // RVA: 0x7FFACB2BBEF0
        public void OnCollisionExit(){} // RVA: 0x7FFACB2BC1E0
        public void OnPointerMove(){} // RVA: 0x7FFACB2BC560
        public void OnPointerClick(){} // RVA: 0x7FFACB2BC5B0
        public void get_useGUILayout(){} // RVA: 0x7FFACB2BC820
        public void set_useGUILayout(){} // RVA: 0x7FFACB2BC920
        public void print(){} // RVA: 0x7FFACB2BCA30
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void OnEndDrag(){} // RVA: 0x7FFACB2BCB30
        public void InvokeDelayed(){} // RVA: 0x7FFAC2F8C040
        public void CancelInvoke_FA84E443F8C1(){} // RVA: 0x7FFACB2BCB90
        public void GetGameObject_600(){} // RVA: 0x7FFACB2BCDA0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB2BCEA0
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB2BCFA0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB2BD0B0
    }

    /// <summary>Originally: ÌÌÎÌÌÌÌÏÏÏÏÍÏÎÏÍÌÌÏÎÏÏÎ</summary>
    public class PointerClickSubmitImpl_82CA_82CA : PointerClickSubmit_50A4_50A4
    {
        public ÍÍÍÍÏÎÍÌÌÏÌÎÏÍÏÍÎÏÍÍÏÌÎ f_853; // 0x158
        public string f_143; // 0x160
        public string f_11A; // 0x168
        public string f_7E4; // 0x170

        // ── Methods ──
        public void SetForm(){} // RVA: 0x7FFAC39A80B0
        public void get_VideoPlayerController(){} // RVA: 0x7FFAC336D850
        public void get_HttpProxy(){} // RVA: 0x7FFAC33A98A0
        public void get_HttpProxy_459E01EA37B2(){} // RVA: 0x7FFAC33A98A0
        public void get_TimelineController(){} // RVA: 0x7FFAC354E2F0
        public void Update(){} // RVA: 0x7FFAC354E2F0
        public void get_HttpProxy_BE3261413D28(){} // RVA: 0x7FFAC33A98A0
        public void IsInvoking(){} // RVA: 0x7FFAC336D850
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void get_DownloadProgressChanged(){} // RVA: 0x7FFACB7D03A0
        public void OnPointerUp(){} // RVA: 0x7FFACB7D03D0
        public void OnSelect(){} // RVA: 0x7FFACB7D0790
        public void Update_AA4C8EF0EF36(){} // RVA: 0x7FFAC354E2F0
        public void set_VideoPlayerController(){} // RVA: 0x7FFAC39B5DB0
        public void get_HttpProxy_AD34788AAEF0(){} // RVA: 0x7FFAC33A98A0
        public void .ctor(){} // RVA: 0x7FFAC42D9430
        public void Initialize(){} // RVA: 0x7FFAC39B5DB0
        public void Initialize_F3741274331B(){} // RVA: 0x7FFAC39B5DB0
        public void get_transform(){} // RVA: 0x7FFACB7D07D0
        public void Awake(){} // RVA: 0x7FFACB7D08B0
        public void set_HttpProxy(){} // RVA: 0x7FFAC33AFA60
    }

    /// <summary>Originally: ÌÍÍÍÍÏÌÏÍÎÎÍÍÏÍÌÍÌÌÏÍÎÎ</summary>
    public class PointerClickSubmit_2A90_2A90 : Toggle
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _group; // 0x128
        public string _isOn; // 0x130
        public bool _sendAnalytics; // 0x138
        public ÌÍÏÏÌÎÌÌÌÌÍÎÌÌÌÎÎÍÎÏÍÎÏ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x140
        public bool ÎÍÏÎÏÍÏÏÏÎÎÌÎÏÍÍÏÏÏÎÌÍÌ; // 0x148
        public ÌÏÍÌÎÏÌÍÏÍÎÌÎÎÌÏÍÎÌÌÏÍÍ ÍÏÏÍÍÎÎÌÌÍÍÎÏÎÎÎÌÏÍÏÏÌÎ; // 0x150

        // ── Methods ──
        public void set_MotionBlurCameras(){} // RVA: 0x7FFAC39B99C0
        public void set_group(){} // RVA: 0x7FFACB85E7B0
        public void OnPointerEnter(){} // RVA: 0x7FFACB85E8D0
        public void Rebuild(){} // RVA: 0x7FFACB85EB10
        public void get_Transform(){} // RVA: 0x7FFAC33BCDF0
        public void Start(){} // RVA: 0x7FFACB85EC30
        public void get_promotion(){} // RVA: 0x7FFAC33BC6D0
        public void get_isOn(){} // RVA: 0x7FFAC87898E0
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void .ctor(){} // RVA: 0x7FFACB85EDD0
        public void Initialize(){} // RVA: 0x7FFAC33BCDF0
        public void OnPointerExit(){} // RVA: 0x7FFACB85EDE0
        public void GetSource(){} // RVA: 0x7FFAC3544340
        public void SetIsOnWithoutNotify(){} // RVA: 0x7FFAC3544340
        public void Set(){} // RVA: 0x7FFACB85EF00
        public void OnSubmit(){} // RVA: 0x7FFACB85F020
        public void OnPointerDown(){} // RVA: 0x7FFAC3544340
        public void OnPointerClick(){} // RVA: 0x7FFACB85F0E0
        public void set_payload(){} // RVA: 0x7FFAC39A79B0
        public void OnPointerUp(){} // RVA: 0x7FFACB85F430
        public void set_UploadProgressChanged(){} // RVA: 0x7FFAC412E500
        public void set_isOn(){} // RVA: 0x7FFAC9C6EB10
        public void OnSelect(){} // RVA: 0x7FFAC3544340
    }

    /// <summary>Originally: ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ</summary>
    public class PointerClickSubmit_50A4_50A4 : Button
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _onClick; // 0x108
        public UnityEngine.UI.Image f_593; // 0x110
        public UnityEngine.UI.Image f_9AE; // 0x118
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _tooltip; // 0x120
        public VRC.UI.Core.Styles.StyleElement _style; // 0x128
        public bool _disabled; // 0x130
        public string _controlName; // 0x138
        public bool _sendAnalytics; // 0x140
        public ÌÍÏÏÌÎÌÌÌÌÍÎÌÌÌÎÎÍÎÏÍÎÏ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x148
        public ÌÏÍÌÎÏÌÍÏÍÎÌÎÎÌÏÍÎÌÌÏÍÍ ÍÏÏÍÍÎÎÌÌÍÍÎÏÎÎÎÌÏÍÏÏÌÎ; // 0x150

        // ── Methods ──
        public void set_MotionBlurCameras(){} // RVA: 0x7FFAC39B99C0
        public void get_onClick(){} // RVA: 0x7FFACB858F70
        public void set_onClick(){} // RVA: 0x7FFAC39B99C0
        public void get_Transform(){} // RVA: 0x7FFAC33BCDF0
        public void OnPointerEnter(){} // RVA: 0x7FFACB8591B0
        public void OnPointerClick(){} // RVA: 0x7FFACB8591D0
        public void OnFinishSubmit(){} // RVA: 0x7FFACB859500
        public void OnPointerExit(){} // RVA: 0x7FFACB8595F0
        public void OnPointerDown(){} // RVA: 0x7FFACB859670
        public void get_DownloadProgressChanged(){} // RVA: 0x7FFAC90ADDB0
        public void OnPointerUp(){} // RVA: 0x7FFAC39B99C0
        public void OnSelect(){} // RVA: 0x7FFACB859770
        public void OnDeselect(){} // RVA: 0x7FFAC90ADDB0
        public void OnCancel(){} // RVA: 0x7FFACB859840
        public void OnMove(){} // RVA: 0x7FFACB8598D0
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void .ctor(){} // RVA: 0x7FFAC42D9430
        public void Initialize(){} // RVA: 0x7FFACB859AD0
        public void get_transform(){} // RVA: 0x7FFACB859DD0
        public void Start_B46D451B2590(){} // RVA: 0x7FFACB8591B0
        public void get_DownloadProgressChanged_5919F38A4401(){} // RVA: 0x7FFACB859FF0
        public void OnSubmit(){} // RVA: 0x7FFACB85A110
        public void get_gameObject(){} // RVA: 0x7FFAC33BCDF0
        public void Start(){} // RVA: 0x7FFACB85A260
        public void OnScroll(){} // RVA: 0x7FFAC33BD180
        public void OnValueChanged(){} // RVA: 0x7FFAC36D84B0
    }

    /// <summary>Originally: ÍÎÍÍÎÌÍÏÏÌÏÌÏÎÍÎÎÎÍÌÍÍÍ</summary>
    public class PointerDeselectSubmitHandler_4E7B_4E7B : MonoBehaviour
    {
        public UnityEngine.GameObject _destroyCancellationToken;

        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7FFAC4280110
        public void RaiseCancellation(){} // RVA: 0x7FFAC42801B0
        public void IsInvoking(){} // RVA: 0x7FFAC4280210
        public void CancelInvoke(){} // RVA: 0x7FFAC42802B0
        public void Invoke(){} // RVA: 0x7FFAC4280350
        public void InvokeRepeating(){} // RVA: 0x7FFAC4280590
        public void CancelInvoke_82F5A9841A90(){} // RVA: 0x7FFAC42807D0
        public void Equals(){} // RVA: 0x7FFAC4280A10
        public void StartCoroutine(){} // RVA: 0x7FFAC4280AB0
        public void OnDeselect(){} // RVA: 0x7FFAC4280B50
        public void StartCoroutine_4363B97E5C73(){} // RVA: 0x7FFAC4280BF0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC4280C90
        public void OnSelect(){} // RVA: 0x7FFAC4280D30
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC4280DE0
        public void OnCancel(){} // RVA: 0x7FFAC4280E80
    }

    /// <summary>Originally: ÌÎÍÌÏÏÌÍÌÌÍÏÎÏÎÏÍÏÏÍÍÏÌ</summary>
    public class PointerDestroyDropdownListCreateDropdownList_DF25_DF25 : TMP_Dropdown
    {
        public string _template; // 0x180
        public VRC.UI.Core.Styles.StyleElement _captionText; // 0x188
        public string ÎÎÌÌÍÏÏÌÏÍÍÌÌÌÍÏÎÎÍÏÍÌÍ;
        public bool ÍÏÏÌÌÌÌÏÍÏÍÍÌÍÏÌÎÍÎÍÌÍÏ; // 0x190
        public bool ÏÎÎÏÎÏÎÌÎÌÏÏÎÌÌÍÏÍÌÎÌÍÍ; // 0x191
        public bool ÍÍÌÏÎÏÎÎÌÏÏÍÎÍÍÎÎÍÎÎÎÎÌ; // 0x192
        public int ÌÍÌÍÎÏÎÏÎÌÏÏÎÎÌÌÍÍÌÏÌÍÍ; // 0x194
        public System.Collections.Generic.List`1<VRC.Localization.LocalizableOptionData> ÎÎÎÌÏÍÌÌÏÍÌÌÎÌÍÌÎÍÏÏÌÌÏ; // 0x198
        public System.Action ÎÎÎÏÏÎÌÌÌÏÏÌÌÎÍÍÏÏÏÏÏÎÍ; // 0x1A0

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFACB85AAE0
        public void DestroyDropdownList(){} // RVA: 0x7FFACB85AB40
        public void OnDisable(){} // RVA: 0x7FFACB85ABF0
        public void get_LastFilePath(){} // RVA: 0x7FFAC3541C80
        public void set_touchId(){} // RVA: 0x7FFAC3503070
        public void set_captionImage(){} // RVA: 0x7FFACB85ADA0
        public void get_placeholder(){} // RVA: 0x7FFACB85ADB0
        public void OnDestroy(){} // RVA: 0x7FFACB85B000
        public void get_itemText(){} // RVA: 0x7FFACB85B1B0
        public void Awake(){} // RVA: 0x7FFACB85B380
        public void set_value(){} // RVA: 0x7FFAC973F070
        public void set_itemImage(){} // RVA: 0x7FFACB85B420
        public void OnPointerClick(){} // RVA: 0x7FFACB85B480
        public void get_Transform(){} // RVA: 0x7FFAC33BCDF0
        public void Start(){} // RVA: 0x7FFACB85B7F0
        public void set_onValueChanged(){} // RVA: 0x7FFACB85BA90
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFACB85BCE0
        public void .ctor(){} // RVA: 0x7FFACB85BD50
        public void DestroyItem(){} // RVA: 0x7FFACB85BE40
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7FFAC354B1B0
        public void CreateItem(){} // RVA: 0x7FFACB85BE50
        public void SetValue(){} // RVA: 0x7FFACB85BF80
        public void get_IsExpanded(){} // RVA: 0x7FFAC973F070
        public void IndexOf(){} // RVA: 0x7FFACB85ADA0
        public void get_component(){} // RVA: 0x7FFAC33BC1B0
        public void OnPointerEnter(){} // RVA: 0x7FFACB85BFE0
        public void OnPointerExit(){} // RVA: 0x7FFACB85C0D0
        public void CreateDropdownList(){} // RVA: 0x7FFACB85C1C0
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void AddOptions(){} // RVA: 0x7FFAC33BCDF0
        public void OnPointerDown(){} // RVA: 0x7FFACB85C280
        public void ClearOptions(){} // RVA: 0x7FFACB85C370
        public void SetupTemplate(){} // RVA: 0x7FFACB85C750
        public void GetOrAddComponent(){} // RVA: 0x7FFACB85C840
        public void OnPointerUp(){} // RVA: 0x7FFACB85C9B0
    }

    /// <summary>Originally: ÍÏÍÌÎÏÍÎÌÌÍÎÌÏÌÌÎÏÎÍÏÏÎ</summary>
    public class PointerDownBeginDragHandler_0060_0060 : MonoBehaviour
    {
        public UnityEngine.RectTransform _destroyCancellationToken; // 0x20
        public UnityEngine.GameObject _useGUILayout; // 0x28
        public UnityEngine.GameObject f_92E; // 0x30
        public 0x6B07F8B8 f_90C; // 0x38
        public float f_0F5; // 0x3C
        public UnityEngine.BoxCollider f_73C; // 0x40
        public UnityEngine.BoxCollider f_A41; // 0x48
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _avatarName; // 0x50
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _heightText; // 0x58
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _prices; // 0x60
        public UnityEngine.GameObject _priceContainer; // 0x68
        public ÏÍÍÌÏÌÏÎÎÏÎÎÎÌÎÌÍÎÎÏÍÍÌ _avatarUnavailableBanner; // 0x70
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _useButton; // 0x78
        public ÌÍÌÏÌÏÎÌÎÌÍÌÍÌÍÌÏÍÎÏÏÌÎ _previewButton; // 0x80
        public ÍÏÎÍÍÏÌÌÍÎÎÏÏÍÍÎÎÌÎÎÍÍÏ _favoriteButton; // 0x88
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _detailsButton; // 0x90
        public UnityEngine.GameObject _avatarMarketplacePanel; // 0x98
        public UnityEngine.GameObject _impostorPanel; // 0xA0
        public ÎÎÏÎÎÍÌÏÍÌÍÎÎÍÍÏÌÍÍÎÌÌÎ _accessoriesPanel; // 0xA8
        public ÎÎÎÍÍÎÍÎÎÌÎÏÍÏÍÏÏÎÎÍÌÏÍ _accessoriesStorePanel; // 0xB0
        public ÎÌÎÌÌÎÏÍÎÍÍÎÎÍÌÎÎÍÍÎÌÎÏ ÌÌÌÎÏÏÌÏÍÍÍÌÌÍÍÎÌÏÎÍÌÌÌ; // 0xB8
        public ÌÌÏÏÏÌÌÍÏÏÎÎÎÍÎÎÏÌÎÎÌÏÌ ÌÎÎÌÏÎÏÏÍÏÍÎÎÍÎÎÎÍÏÍÌÍÍ; // 0xC0
        public bool ÎÏÌÍÌÍÎÌÌÏÌÍÍÎÏÌÌÍÎÌÌÌÌ; // 0xC8
        public bool ÌÎÏÌÎÎÍÌÏÍÍÎÌÌÌÍÏÏÌÌÏÌÍ; // 0xC9
        public UnityEngine.GameObject ÎÌÏÌÏÏÏÏÏÎÎÎÎÎÌÎÏÍÏÍÏÌÎ; // 0xD0
        public UnityEngine.Transform ÏÌÌÏÏÍÍÌÍÍÏÌÏÏÍÌÍÎÏÌÌÏÎ; // 0xD8
        public bool ÏÍÍÌÎÌÎÏÌÏÌÌÏÎÏÍÍÍÎÎÍÎÎ; // 0xE0
        public string ÏÍÏÏÍÏÏÌÍÍÌÌÏÎÍÎÎÏÏÌÌÏÌ; // 0xE8
        public float ÏÎÎÎÍÌÏÎÌÏÍÍÎÎÎÍÏÏÎÏÍÌÏ; // 0xF0
        public bool ÍÌÎÍÏÌÎÍÍÏÎÍÌÍÎÍÏÏÍÍÌÎÎ; // 0xF4
        public bool ÌÎÎÎÍÎÍÏÌÏÌÌÍÏÍÏÎÏÏÏÏÌÎ; // 0xF5
        public float ÍÌÏÎÌÎÍÏÏÍÍÌÎÌÌÏÍÌÌÎÏÌÏ; // 0xF8
        public bool ÍÌÍÎÏÌÍÌÌÍÎÎÎÎÏÌÎÏÏÎÍÍÏ; // 0xFC
        public float targetTorque; // 0x100
        public float maxTorque; // 0x104
        public float torqueMultiplier_VR; // 0x108
        public float torqueMultiplier_Desktop; // 0x10C
        public float damping; // 0x110
        public float acceleration; // 0x114
        public ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ ÏÎÍÍÌÌÎÍÌÌÍÎÎÎÏÎÍÌÌÌÍÎÌ; // 0x118
        public bool <ÍÏÍÎÏÏÌÍÌÎÏÍÌÌÎÍÌÏÌÎÍÎÏ>k__BackingField; // 0x120
        public bool ÎÍÏÏÎÍÍÍÏÍÍÎÏÍÌÍÌÌÍÏÌÌÌ; // 0x121
        public System.Action`2<UnityEngine.GameObject,bool> ÏÌÌÎÏÍÌÎÏÍÍÏÍÍÎÎÏÌÍÎÏÏÌ; // 0x128
        public System.Action`1<ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ> ÏÏÌÎÏÌÍÎÏÏÍÍÏÌÎÌÎÍÍÎÍÍÍ; // 0x130
        public ÌÌÎÍÍÌÌÍÏÍÍÍÏÌÍÍÎÍÍÎÌÌÎ ÏÏÎÏÎÎÏÌÌÎÏÍÌÏÌÌÍÎÏÍÏÎÎ; // 0x138
        public bool ÏÍÍÎÎÌÏÌÏÏÍÎÎÍÍÏÍÏÏÍÍÌÎ; // 0x140
        public bool ÎÎÏÎÎÎÏÎÌÎÏÍÎÏÎÏÌÏÏÎÍÎÎ; // 0x141

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB81C540
        public void RaiseCancellation(){} // RVA: 0x7FFACB81C570
        public void Awake(){} // RVA: 0x7FFACB81C5A0
        public void CancelInvoke(){} // RVA: 0x7FFACB81CD00
        public void Invoke(){} // RVA: 0x7FFACB81CE90
        public void InvokeRepeating(){} // RVA: 0x7FFACB81CEF0
        public void CancelInvoke_825C2CEE77F2(){} // RVA: 0x7FFACB81D3F0
        public void IsInvoking(){} // RVA: 0x7FFACB81D560
        public void StartCoroutine(){} // RVA: 0x7FFACB81D5C0
        public void StartCoroutine_9BBEECA243D2(){} // RVA: 0x7FFACB81D5D0
        public void OnApplicationPause(){} // RVA: 0x7FFACB81D630
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB81DC50
        public void StopCoroutine(){} // RVA: 0x7FFACB81DD20
        public void get_destroyCancellationToken_900A089165F4(){} // RVA: 0x7FFACB81E4E0
        public void OnCollisionEnter(){} // RVA: 0x7FFACB81E5D0
        public void StopAllCoroutines(){} // RVA: 0x7FFACB81E8A0
        public void get_useGUILayout(){} // RVA: 0x7FFACB81E920
        public void set_useGUILayout(){} // RVA: 0x7FFACB81EA00
        public void print(){} // RVA: 0x7FFACB81EBD0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB81EC00
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFACB81F160
        public void InvokeDelayed(){} // RVA: 0x7FFACB81F9C0
        public void get_isOn(){} // RVA: 0x7FFAC87898E0
        public void OnDrag(){} // RVA: 0x7FFACB81FAC0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB81FB20
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB81FE60
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB81FE70
        public void StopCoroutineManaged(){} // RVA: 0x7FFACB81FEF0
        public void OnEndDrag(){} // RVA: 0x7FFACB820000
        public void GetScriptClassName(){} // RVA: 0x7FFACB820040
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFACB8201E0
        public void SetDragPayload(){} // RVA: 0x7FFACB8205D0
        public void .ctor(){} // RVA: 0x7FFACB820790
        public void Initialize(){} // RVA: 0x7FFACB820820
        public void ResolveDragHandler(){} // RVA: 0x7FFACB8208F0
        public void Start(){} // RVA: 0x7FFACB820980
        public void OnBeginDrag(){} // RVA: 0x7FFACB81D5C0
        public void ResolvePointerPressTarget(){} // RVA: 0x7FFACB820A80
        public void ResolveDragHandler_B449D8A1CED4(){} // RVA: 0x7FFACB820B40
        public void ResolveDragTarget(){} // RVA: 0x7FFACB820B50
        public void OnDestroy(){} // RVA: 0x7FFACB820DB0
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7FFACB8211B0
        public void OnApplicationQuit(){} // RVA: 0x7FFACB8211C0
        public void OnBecameVisible(){} // RVA: 0x7FFACB821410
        public void Update(){} // RVA: 0x7FFACB821470
        public void GetGameObject_ED2(){} // RVA: 0x7FFACB8214C0
        public void OnPointerDown(){} // RVA: 0x7FFACB821620
        public void OnCollisionExit(){} // RVA: 0x7FFACB821660
        public void OnTriggerEnter(){} // RVA: 0x7FFACB8216F0
        public void OnTriggerStay(){} // RVA: 0x7FFACB8217F0
        public void OnEnable(){} // RVA: 0x7FFACB821830
        public void OnDisable(){} // RVA: 0x7FFACB821AD0
        public void OnPointerUp(){} // RVA: 0x7FFACB821E00
        public void OnCollisionStay(){} // RVA: 0x7FFACB821E40
        public void OnDestroy_impl(){} // RVA: 0x7FFACB821E50
        public void SetInternalFlag(){} // RVA: 0x7FFAC87898F0
        public void MoveNext(){} // RVA: 0x7FFACB821FD0
        public void OnTriggerExit(){} // RVA: 0x7FFACB8223C0
        public void FixedUpdate(){} // RVA: 0x7FFACB822450
        public void GetPrimaryDragCandidate(){} // RVA: 0x7FFACB8225B0
        public void LateUpdate(){} // RVA: 0x7FFACB8227D0
        public void StartPointerDragProfiler(){} // RVA: 0x7FFACB822940
        public void get_promotion(){} // RVA: 0x7FFAC33BC6D0
        public void StartPointerDragProfiler_45751F28AADA(){} // RVA: 0x7FFACB822AF0
        public void Update_E0A5261399F3(){} // RVA: 0x7FFACB821470
    }

    /// <summary>Originally: ÌÎÎÍÍÌÎÍÌÌÌÌÍÏÌÌÌÍÎÏÍÎÎ</summary>
    public class PointerDownHandler_1C87_1C87 : MonoBehaviour
    {
        public UnityEngine.UI.Toggle[] _toggles; // 0x20
        public UnityEngine.UI.Selectable ÍÍÌÎÎÎÌÌÌÏÍÍÌÍÌÎÌÍÎÎÏÏÏ; // 0x28
        public bool ÎÌÎÌÎÍÏÍÎÍÎÏÍÌÏÌÌÎÏÌÍÎÏ; // 0x30

        // ── Methods ──
        public void ColorRed(){} // RVA: 0x7FFAC4269BA0
        public void RaiseCancellation(){} // RVA: 0x7FFACB35CAE0
        public void Awake(){} // RVA: 0x7FFACB35CB70
        public void OnDestroy(){} // RVA: 0x7FFACB35CC00
        public void OnPointerDown(){} // RVA: 0x7FFACB35CC80
        public void InvokeRepeating(){} // RVA: 0x7FFACB35CC80
        public void CancelInvoke(){} // RVA: 0x7FFACB35CC80
        public void IsInvoking(){} // RVA: 0x7FFACB35CC90
        public void StartCoroutine(){} // RVA: 0x7FFAC4269BA0
        public void OnApplicationPause(){} // RVA: 0x7FFAC4269BB0
        public void StartCoroutine_ACC61E44F513(){} // RVA: 0x7FFACB35CD20
        public void ColorBlack(){} // RVA: 0x7FFAC4269BB0
        public void .ctor(){} // RVA: 0x7FFAC2FD5710
    }

    /// <summary>Originally: ÌÍÌÌÍÏÌÎÎÌÏÏÍÍÍÌÎÏÍÍÎÌÎ</summary>
    public class PointerDownHandler_663C_663C : MonoBehaviour
    {
        public string _controlName; // 0x20

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFACB9447C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Start(){} // RVA: 0x7FFACB944870
        public void Handle(){} // RVA: 0x7FFACB944AC0
        public void Process(){} // RVA: 0x7FFACB944D10
        public void OnReceive(){} // RVA: 0x7FFACB944DC0
        public void OnEvent(){} // RVA: 0x7FFACB945010
        public void IsInvoking(){} // RVA: 0x7FFACB9450C0
    }

    /// <summary>Originally: ÍÏÏÏÌÏÍÎÍÍÏÌÌÍÌÌÌÏÎÍÏÍÎ</summary>
    public class PointerDownHandler_8BA9_8BA9 : MonoBehaviour
    {
        public 0x6B02A460 buttonType; // 0x20
        public UnityEngine.UI.Button button; // 0x28
        public UnityEngine.UI.Image image; // 0x30
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ text; // 0x38
        public UnityEngine.Color ÍÎÌÍÎÍÏÌÍÍÎÍÍÍÌÌÎÌÌÏÍÍÍ; // 0x40
        public UnityEngine.Color ÌÏÎÍÌÌÎÍÏÎÏÍÌÏÎÍÍÌÎÌÏÌÎ; // 0x50
        public UnityEngine.Color ÏÎÎÌÍÏÍÌÍÎÌÌÎÍÍÍÌÌÍÌÌÍÎ; // 0x60
        public DG.Tweening.Tween ÎÌÌÎÍÏÍÍÎÌÌÍÍÍÌÎÏÌÎÌÏÍÌ; // 0x70
        public System.Action ÎÌÎÍÌÍÎÏÎÎÏÍÍÎÍÎÏÍÌÏÍÌÍ;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC33735D0
        public void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(){} // RVA: 0x7FFAC3373680
        public void IsInvoking(){} // RVA: 0x7FFAC33736B0
        public void CancelInvoke(){} // RVA: 0x7FFAC33736F0
        public void Invoke(){} // RVA: 0x7FFAC33739F0
        public void InvokeRepeating(){} // RVA: 0x7FFAC3373A90
        public void OnApplicationPause(){} // RVA: 0x7FFAC3373B40
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3373C50
        public void StartCoroutine(){} // RVA: 0x7FFAC3373CB0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3374250
        public void OnCollisionEnter(){} // RVA: 0x7FFAC33742B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC33745B0
        public void StopCoroutine(){} // RVA: 0x7FFAC33746C0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC33746F0
        public void OnTriggerStay(){} // RVA: 0x7FFAC33747A0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3374820
        public void .ctor(){} // RVA: 0x7FFAC3374880
        public void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(){} // RVA: 0x7FFAC33748F0
        public void print(){} // RVA: 0x7FFAC3374920
        public void OnDisable(){} // RVA: 0x7FFAC3374CB0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3374D50
        public void OnEnable(){} // RVA: 0x7FFAC3374E60
        public void OnPointerDown(){} // RVA: 0x7FFAC3374FF0
    }

    /// <summary>Originally: ÍÌÎÍÎÍÎÎÌÎÌÎÌÍÎÏÎÌÏÏÌÎÎ</summary>
    public class PointerDownHandler_8C9D_8C9D : MonoBehaviour
    {
        public UnityEngine.GameObject _newStatusDot; // 0x20
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _newInventoryItemsCountText; // 0x28
        public string _controlName; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB945170
        public void Start(){} // RVA: 0x7FFACB9456E0
        public void IsInvoking(){} // RVA: 0x7FFACB945C20
        public void OnPointerDown(){} // RVA: 0x7FFACB945CD0
        public void Invoke(){} // RVA: 0x7FFACB945D80
        public void InvokeRepeating(){} // RVA: 0x7FFACB946220
        public void CancelInvoke(){} // RVA: 0x7FFACB9466C0
        public void OnApplicationPause(){} // RVA: 0x7FFACB946770
        public void StartCoroutine(){} // RVA: 0x7FFACB946C10
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB9470B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB947550
    }

    /// <summary>Originally: ÍÌÏÍÏÍÌÍÍÎÎÍÎÍÌÍÌÏÎÍÏÍÏ</summary>
    public class PointerDownHandler_BB39_BB39 : MonoBehaviour
    {
        public UnityEngine.GameObject ÎÌÏÍÎÎÎÍÌÍÍÌÌÍÍÌÍÌÍÍÌÏÍ; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC36F6840
        public void OnPointerDown(){} // RVA: 0x7FFAC36F6840
        public void CancelInvoke(){} // RVA: 0x7FFAC36F6840
        public void Invoke(){} // RVA: 0x7FFAC36F6840
        public void InvokeRepeating(){} // RVA: 0x7FFAC36F6840
        public void Gettransform(){} // RVA: 0x7FFAC36F6840
        public void IsInvoking(){} // RVA: 0x7FFAC36F6840
    }

    /// <summary>Originally: ÌÎÍÍÍÎÎÎÌÌÏÎÏÎÏÏÎÏÍÎÍÏÏ</summary>
    public class PointerDownPointerExitHandler_269B_269B : MonoBehaviour
    {
        public ÏÏÎÏÎÎÍÍÍÏÏÎÎÎÍÏÏÍÎÌÍÍÏ ÎÌÎÏÌÏÏÌÌÎÎÏÎÌÎÏÌÌÏÌÎÎÎ; // 0x20
        public 0x6B00A010 ÌÌÍÍÏÏÍÌÎÎÍÍÍÍÌÌÍÍÍÍÍÎÍ; // 0x28
        public bool ÏÏÎÍÌÌÌÌÏÍÎÍÏÍÌÎÎÍÍÍÏÏÌ; // 0x2C

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFAC2F26B70
        public void OnPointerDown(){} // RVA: 0x7FFAC2F26B70
        public void Process(){} // RVA: 0x7FFAC42FC830
        public void Update(){} // RVA: 0x7FFAC42FC840
        public void OnPointerUp(){} // RVA: 0x7FFAC42FC830
        public void OnReceive(){} // RVA: 0x7FFAC42FCA00
        public void OnEvent(){} // RVA: 0x7FFAC2F26B70
        public void OnPointerExit(){} // RVA: 0x7FFAC42FCA70
        public void StartCoroutine(){} // RVA: 0x7FFAC2F26B70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÍÌÏÎÎÏÌÌÍÎÎÍÌÎÌÌÎÏÎÍÍÏÌ</summary>
    public class PointerDownPointerUpHandler_3722_3722 : MonoBehaviour
    {
        public UnityEngine.UI.RawImage _destroyCancellationToken; // 0x20
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _useGUILayout; // 0x28
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÍÍÍÏÏÎÎÎÌÏÌÏÍÍÎÍÏÎÌÏÏÎ; // 0x30
        public UnityEngine.GameObject ÏÎÏÎÏÍÍÌÎÎÏÎÌÌÏÎÎÌÏÌÍÎÏ; // 0x38
        public UnityEngine.UI.RawImage ÏÍÌÏÏÍÏÏÌÍÍÎÌÍÏÍÎÍÍÎÏÍÌ; // 0x40
        public System.Func`1<bool> <ÏÌÎÏÌÎÎÍÏÌÎÎÎÍÍÍÌÎÍÏÌÏÌ>k__BackingField; // 0x48
        public bool <ÎÌÎÎÍÏÍÎÍÍÏÎÏÎÏÌÏÎÏÏÌÎÌ>k__BackingField; // 0x50

        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void OnPointerUp(){} // RVA: 0x7FFAC30D5EF0
        public void IsInvoking(){} // RVA: 0x7FFAC43AA570
        public void CancelInvoke(){} // RVA: 0x7FFAC43AA700
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FDB8F0
        public void Awake(){} // RVA: 0x7FFAC43AAA30
        public void OnEnable(){} // RVA: 0x7FFAC43AABC0
        public void Start(){} // RVA: 0x7FFAC43AAD80
        public void StartCoroutine(){} // RVA: 0x7FFAC43AAE40
        public void Update(){} // RVA: 0x7FFAC2FDB8F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC363CEE0
        public void OnPointerDown(){} // RVA: 0x7FFAC43AAEB0
        public void StopCoroutine(){} // RVA: 0x7FFAC43AAEC0
        public void OnApplicationPause(){} // RVA: 0x7FFAC2F21310
        public void StopAllCoroutines(){} // RVA: 0x7FFAC43AB1F0
        public void StartWithHighestBandwidth(){} // RVA: 0x7FFAC2FDB8E0
        public void set_useGUILayout(){} // RVA: 0x7FFAC43AB4D0
        public void print(){} // RVA: 0x7FFAC2F21310
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC2FDB8F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void OnTriggerStay(){} // RVA: 0x7FFAC2F21310
        public void OnTriggerExit(){} // RVA: 0x7FFAC43AB7B0
    }

    /// <summary>Originally: ÎÎÏÌÍÏÎÏÎÎÏÌÌÌÌÏÍÍÏÍÍÌÏ</summary>
    public class PointerDownPointerUpHandler_382C_382C : MonoBehaviour
    {
        public UnityEngine.Transform ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0x20
        public UnityEngine.Vector2 ÏÎÏÎÍÏÌÌÎÎÎÏÎÏÍÌÍÏÏÌÍÍÎ; // 0x28
        public float ÍÎÎÎÏÌÎÌÏÏÌÍÏÎÌÌÌÎÌÍÎÏÍ;
        public float ÍÌÏÏÌÏÎÏÍÏÎÎÍÌÏÌÎÌÍÏÎÏÌ;
        public bool ÏÏÌÎÏÍÏÎÎÍÎÌÏÎÌÍÏÎÎÏÍÌÍ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC43A25E0
        public void get_SensorSize(){} // RVA: 0x7FFAC43A2620
        public void ColorBlack(){} // RVA: 0x7FFAC4269BB0
        public void CancelInvoke(){} // RVA: 0x7FFAC43A2640
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC43A27B0
        public void CancelInvoke_F3D3A61A6893(){} // RVA: 0x7FFAC43A27F0
        public void OnDrag(){} // RVA: 0x7FFAC43A27B0
        public void OnPointerUp(){} // RVA: 0x7FFAC4269BB0
        public void StartCoroutine(){} // RVA: 0x7FFAC43A2920
        public void FindSelectableOnUp(){} // RVA: 0x7FFAC43A2A50
        public void IsValid(){} // RVA: 0x7FFAC2F47450
        public void OnPointerDown(){} // RVA: 0x7FFAC43A2B80
        public void StopCoroutine(){} // RVA: 0x7FFAC4269BB0
        public void get_SensorSize_C384F9DB58C6(){} // RVA: 0x7FFAC43A2620
    }

    /// <summary>Originally: ÍÌÏÍÍÌÍÍÌÌÏÌÏÎÍÎÏÏÎÌÎÌÎ</summary>
    public class PointerDownPointerUpHandler_EC3C_EC3C : MonoBehaviour
    {
        public System.Action`1<UnityEngine.Vector2> _eC3C; // 0x20
        public System.Action`1<UnityEngine.Vector2> ÏÍÍÌÎÎÏÌÍÎÍÎÎÌÏÎÍÏÌÍÏÏÎ; // 0x28
        public System.Action`1<UnityEngine.Vector2> ÌÎÍÍÎÎÍÌÌÎÌÏÎÌÌÏÏÌÍÍÌÌÍ; // 0x30
        public System.Action`1<UnityEngine.Vector2> ÎÌÎÎÎÎÍÏÍÏÍÏÎÎÍÎÌÏÎÍÎÍÍ; // 0x38
        public System.Action`1<UnityEngine.Vector2> ÍÏÍÏÍÏÌÌÍÍÌÌÌÍÌÎÎÌÏÎÏÍÍ; // 0x40
        public bool ÌÌÌÍÍÌÏÍÍÎÍÎÎÌÏÏÏÌÍÌÏÎÌ; // 0x48
        public ÌÌÍÌÏÍÏÌÌÎÏÍÌÏÎÏÍÎÌÍÌÍÏ ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0x50
        public int ÍÎÏÎÎÌÏÎÍÍÍÎÎÎÌÎÌÎÌÏÌÍÍ;
        public UnityEngine.Vector2 ÍÌÎÍÍÌÍÏÌÎÏÍÌÌÏÏÎÌÍÍÌÎÏ; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB9B12E0
        public void IsInvoking(){} // RVA: 0x7FFACB9B13E0
        public void CancelInvoke(){} // RVA: 0x7FFACB9B15E0
        public void Invoke(){} // RVA: 0x7FFACB9B16E0
        public void InvokeRepeating(){} // RVA: 0x7FFAC30FEBD0
        public void CancelInvoke_CFF96F3E372F(){} // RVA: 0x7FFACB9B17E0
        public void OnPointerDown(){} // RVA: 0x7FFACB9B18E0
        public void StartCoroutine(){} // RVA: 0x7FFACB9B1950
        public void Awake(){} // RVA: 0x7FFACB9B1A50
        public void OnEnable(){} // RVA: 0x7FFACB9B1BD0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB9B2050
        public void StopCoroutine(){} // RVA: 0x7FFACB9B24D0
        public void OnGUI(){} // RVA: 0x7FFACB9B25D0
        public void LateUpdate(){} // RVA: 0x7FFACB9B26D0
        public void OnDisable(){} // RVA: 0x7FFAC30FEBD0
        public void get_useGUILayout(){} // RVA: 0x7FFACB9B27D0
        public void set_useGUILayout(){} // RVA: 0x7FFACB9B29D0
        public void print(){} // RVA: 0x7FFACB9B2AD0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB9B2BD0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFACB9B2CD0
        public void OnPointerUp(){} // RVA: 0x7FFACB9B2DD0
        public void OnCollisionStay(){} // RVA: 0x7FFACB9B2E40
        public void Start(){} // RVA: 0x7FFACB9B2F40
        public void Update(){} // RVA: 0x7FFACB9B3040
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB9B3140
        public void get_hidden(){} // RVA: 0x7FFAC2FD8D30
        public void OnBeginDrag(){} // RVA: 0x7FFACB9B3240
    }

    /// <summary>Originally: ÍÍÎÍÌÍÍÌÍÏÏÎÎÌÏÎÌÌÌÌÌÌÏ</summary>
    public class PointerDragHandler_3936_3936 : MonoBehaviour
    {
        public ÍÌÏÍÍÌÍÍÌÌÏÌÏÎÍÎÏÏÎÌÎÌÎ dragHandler; // 0x20
        public UnityEngine.Vector2 ÌÍÌÍÎÏÏÌÎÌÏÍÏÎÍÏÎÏÏÌÌÌÎ; // 0x28
        public ÎÎÏÍÌÏÌÌÍÌÏÎÎÍÍÍÏÏÌÌÍÏÌ ÌÎÎÌÏÍÏÎÍÌÎÏÌÎÍÌÍÍÎÎÏÌÎ; // 0x30

        // ── Methods ──
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void RaiseCancellation(){} // RVA: 0x7FFAC2F4F890
        public void IsInvoking(){} // RVA: 0x7FFACB94D770
        public void Start(){} // RVA: 0x7FFACB94D840
        public void OnDrag(){} // RVA: 0x7FFACB94D920
        public void InvokeRepeating(){} // RVA: 0x7FFAC2F4F890
        public void CancelInvoke(){} // RVA: 0x7FFACB94DA20
        public void OnDisable(){} // RVA: 0x7FFACB94DAF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB94DBF0
    }

    /// <summary>Originally: ÎÍÍÌÍÏÏÌÍÏÌÌÌÏÎÎÍÌÌÌÏÏÎ</summary>
    public class PointerEnterComponent_039B_039B : MonoBehaviour
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _nameField; // 0x20
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ _thumbnail; // 0x28
        public UnityEngine.Texture2D _noThumbnailTexture; // 0x30
        public UnityEngine.Material _defaultMaterial; // 0x38
        public UnityEngine.Material _grayScaleMaterial; // 0x40
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _button; // 0x48
        public UnityEngine.GameObject _selected; // 0x50
        public UnityEngine.GameObject _playing; // 0x58
        public ÏÎÌÌÌÍÎÌÌÎÏÏÌÍÎÎÌÏÌÎÎÌÏ _platformIconContext; // 0x60
        public UnityEngine.GameObject _contentWarningBanner; // 0x68
        public UnityEngine.GameObject _vrcPlusExclusiveBadge; // 0x70
        public UnityEngine.GameObject _vrcPlusExclusiveLockedIcon; // 0x78
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ ÍÌÎÎÍÏÍÌÌÏÌÏÎÏÎÍÎÍÌÍÎÎÏ; // 0x80
        public VRC.UI.Core.Styles.StyleElement ÎÏÏÌÍÍÏÎÎÍÌÎÎÏÏÎÍÏÌÏÏÏÎ; // 0x88
        public ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ ÍÌÌÎÎÏÌÏÎÎÏÌÌÌÏÍÌÍÏÌÌÎÎ; // 0x90
        public bool ÎÍÍÎÌÌÍÌÍÎÏÍÌÌÍÌÏÍÏÌÌÏÏ; // 0x98
        public bool ÌÏÌÎÍÍÏÍÎÎÌÌÏÎÎÌÍÍÏÏÎÏÌ; // 0x99
        public System.Threading.SemaphoreSlim ÏÎÏÌÏÏÌÏÌÏÎÎÌÌÍÍÌÏÎÌÏÎÌ; // 0xA0

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB892E30
        public void RaiseCancellation(){} // RVA: 0x7FFACB892F00
        public void IsInvoking(){} // RVA: 0x7FFACB893510
        public void CancelInvoke(){} // RVA: 0x7FFACB893520
        public void Invoke(){} // RVA: 0x7FFACB8936B0
        public void OnDestroy(){} // RVA: 0x7FFACB893890
        public void OnApplicationPause(){} // RVA: 0x7FFACB893A20
        public void Start(){} // RVA: 0x7FFACB893B60
        public void StartCoroutine(){} // RVA: 0x7FFACB893E20
        public void OnBecameInvisible(){} // RVA: 0x7FFACB8940E0
        public void .ctor(){} // RVA: 0x7FFACB894280
        public void Initialize(){} // RVA: 0x7FFACB894370
        public void StopCoroutine(){} // RVA: 0x7FFACB894590
        public void OnTriggerEnter(){} // RVA: 0x7FFACB894720
        public void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(){} // RVA: 0x7FFACB8947F0
        public void OnDisable(){} // RVA: 0x7FFACB894910
        public void OnEnable(){} // RVA: 0x7FFACB894BD0
        public void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(){} // RVA: 0x7FFACB894DB0
        public void print(){} // RVA: 0x7FFACB894F50
        public void Awake(){} // RVA: 0x7FFACB894FC0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFACB8950E0
        public void InvokeDelayed(){} // RVA: 0x7FFACB895300
        public void OnTriggerExit(){} // RVA: 0x7FFACB895350
        public void OnCollisionExit(){} // RVA: 0x7FFACB8954F0
    }

    /// <summary>Originally: ÏÌÌÍÎÏÎÍÌÏÍÌÍÏÎÎÎÎÍÌÎÏÎ</summary>
    public class PointerEnterPointerDownHandler_1558_1558 : MonoBehaviour
    {
        public bool ÍÏÌÎÏÌÌÏÍÎÏÎÏÌÏÍÌÌÌÌÍÍÍ;
        public bool ÏÌÎÌÌÏÎÍÍÌÍÍÍÎÌÏÍÎÎÌÍÎÌ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB9194F0
        public void OnPointerUp(){} // RVA: 0x7FFACB919530
        public void OnPointerEnter(){} // RVA: 0x7FFACB919570
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB9195D0
        public void InvokeRepeating(){} // RVA: 0x7FFACB919670
        public void CancelInvoke(){} // RVA: 0x7FFACB9196B0
        public void IsInvoking(){} // RVA: 0x7FFACB919750
        public void StartCoroutine(){} // RVA: 0x7FFACB9197B0
        public void OnPointerDown_7275143A221A(){} // RVA: 0x7FFACB9197F0
        public void OnPointerDown(){} // RVA: 0x7FFACB919850
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB919890
        public void StopCoroutine(){} // RVA: 0x7FFACB9199F0
    }

    /// <summary>Originally: ÏÌÍÍÏÍÌÏÏÌÍÎÍÎÍÍÍÎÌÌÎÌÏ</summary>
    public class PointerEnterPointerDown_7D8E_7D8E : Button
    {
        public ÍÍÏÏÍÎÍÎÌÍÎÍÌÍÌÏÌÎÍÎÌÎÌ ÎÍÎÌÌÎÍÌÎÏÍÎÏÌÏÎÍÌÌÏÍÍÌ; // 0x108
        public ÍÍÏÏÍÎÍÎÌÍÎÍÌÍÌÏÌÎÍÎÌÎÌ ÍÌÌÌÎÍÎÎÌÍÏÎÌÍÍÏÏÏÌÎÏÎÏ; // 0x110
        public ÍÍÏÏÍÎÍÎÌÍÎÍÌÍÌÏÌÎÍÎÌÎÌ ÌÏÍÎÍÍÍÎÍÏÌÍÎÏÏÏÍÌÍÎÎÏÏ; // 0x118
        public ÍÍÏÏÍÎÍÎÌÍÎÍÌÍÌÏÌÎÍÎÌÎÌ ÍÌÍÍÏÏÌÍÏÎÎÎÏÏÏÌÏÌÌÌÎÌÏ; // 0x120

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F8280
        public void OnPointerDown(){} // RVA: 0x7FFAC44F84A0
        public void OnPointerExit(){} // RVA: 0x7FFAC44F8510
        public void OnPointerUp(){} // RVA: 0x7FFAC44F8580
        public void OnPointerEnter(){} // RVA: 0x7FFAC44F8600
    }

    /// <summary>Originally: ÎÎÍÌÏÍÌÏÏÏÌÌÏÎÎÌÌÎÎÌÌÍÍ</summary>
    public class PointerEnterPointerEImpl_AA84_AA84 : PointerEnterPointerExitHandlerImpl_C021_C021
    {
        public 0x6B169300 saveLocation; // 0x60
        public 0x6B1692A8 cameraMode; // 0x64

        // ── Methods ──
        public void UpdateGameObjectStatistics(){} // RVA: 0x7FFAC33A06B0
        public void GetHashCode(){} // RVA: 0x7FFAC33A07D0
        public void OnRenderImage(){} // RVA: 0x7FFAC33A08F0
        public void IsInvoking(){} // RVA: 0x7FFAC33A0A90
        public void UpdatePointerEnterFlags(){} // RVA: 0x7FFAC33A0C30
        public void Initialize(){} // RVA: 0x7FFAC33A0DB0
        public void OnPointerExit(){} // RVA: 0x7FFAC33A0EC0
        public void Start_D1491CF267ED(){} // RVA: 0x7FFAC33A0FE0
        public void Start(){} // RVA: 0x7FFAC33A1100
        public void Invoke(){} // RVA: 0x7FFAC33A12A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void AdvanceStateAndBuildData(){} // RVA: 0x7FFAC33A13B0
        public void Awake(){} // RVA: 0x7FFAC33A1410
    }

    /// <summary>Originally: ÍÎÏÏÏÏÎÏÎÌÌÌÍÏÍÎÌÏÏÌÎÌÍ</summary>
    public class PointerEnterPointerEImpl_ED9D_ED9D : PointerEnterPointerExitImplImpl_A9A2_A9A2
    {
        public UnityEngine.UI.Image _eD9D; // 0x118
        public bool ÍÏÍÏÎÎÍÌÏÏÎÍÍÌÍÏÎÌÏÍÏÎÏ; // 0x120

        // ── Methods ──
        public void get_isOn(){} // RVA: 0x7FFAC87898E0
        public void .ctor(){} // RVA: 0x7FFACBA1B200
        public void Initialize(){} // RVA: 0x7FFACBA1B2D0
        public void MoveNext(){} // RVA: 0x7FFACBA1B450
        public void Instantiate(){} // RVA: 0x7FFACBA1B5D0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACBA1B750
        public void get_isOn_674E4271D67A(){} // RVA: 0x7FFAC87898E0
        public void ApplyDisplayConfiguration(){} // RVA: 0x7FFACBA1B8D0
        public void Initialize_B585AD0ADBEE(){} // RVA: 0x7FFACBA1BA50
        public void NeedsSync(){} // RVA: 0x7FFACBA1BBD0
    }

    /// <summary>Originally: ÍÌÌÏÌÎÍÏÍÎÎÏÏÏÎÎÌÎÎÏÏÏÏ</summary>
    public class PointerEnterPointerExitHandlerImpl_0309_0309 : PointerEnterPointerExitHandler_CF12_CF12
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFACB925A00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÎÌÌÌÏÌÌÌÍÍÎÎÏÎÎÏÏÍÏÎÍÎÏ</summary>
    public class PointerEnterPointerExitHandlerImpl_3128_3128 : PointerEnterPointerExitHandler_AE24_AE24
    {
        public 0x6B02A358 ÌÌÍÎÌÌÏÍÍÍÏÎÎÎÌÍÏÌÏÏÍÍÌ; // 0x48
        public UnityEngine.GameObject ÏÏÌÏÏÎÍÍÌÌÎÎÌÎÌÎÌÎÎÎÏÍÍ; // 0x50
        public UnityEngine.CanvasGroup ÍÍÎÎÏÍÍÌÌÍÎÍÎÌÏÎÎÎÍÍÍÏÎ; // 0x58
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÏÌÍÎÌÎÌÍÌÏÎÌÎÍÏÌÏÎÌÏÏÏÏ; // 0x60
        public UnityEngine.UI.Image ÍÎÎÍÎÍÌÍÌÏÏÏÎÌÎÏÌÎÍÍÌÏÏ; // 0x68
        public UnityEngine.UI.Image ÍÎÎÍÎÎÍÍÎÍÌÎÍÎÏÍÎÏÎÍÍÎÎ; // 0x70
        public UnityEngine.UI.Image ÏÍÎÍÌÏÎÏÍÍÍÌÌÌÌÌÏÍÍÍÏÎÍ; // 0x78
        public UnityEngine.UI.Image ÌÏÎÎÏÎÌÏÏÏÍÌÌÎÍÎÎÎÎÌÍÏÏ; // 0x80
        public UnityEngine.RectTransform ÍÌÍÏÏÍÎÏÌÌÌÏÍÍÎÏÎÍÏÍÍÏÎ; // 0x88
        public UnityEngine.RectTransform ÏÍÎÏÍÍÎÏÎÍÎÌÏÌÌÍÏÏÌÏÎÎÏ; // 0x90
        public UnityEngine.RectTransform ÌÌÍÏÎÎÍÍÍÎÏÏÌÍÌÎÏÎÎÎÌÎÎ; // 0x98
        public UnityEngine.UI.RawImage ÍÏÎÍÎÏÌÍÌÎÏÍÍÎÌÍÍÎÏÏÌÌÌ; // 0xA0
        public UnityEngine.Sprite ÏÎÍÍÏÏÎÎÎÌÌÎÎÎÍÎÎÏÏÏÌÍÌ; // 0xA8
        public VRC.Localization.LocalizableString ÍÍÌÌÍÌÍÍÏÌÏÏÎÏÏÏÏÏÎÏÌÎÍ; // 0xB0
        public UnityEngine.UI.Button ÏÏÌÎÌÍÌÏÍÏÍÍÍÌÌÏÏÍÎÎÌÍÎ; // 0xD8
        public float ÌÏÎÌÌÎÌÌÍÍÍÌÏÍÌÍÍÏÍÏÎÎÎ; // 0xE0
        public int ÌÎÌÍÍÏÌÎÍÎÎÌÌÌÎÏÎÏÎÍÎÏÍ; // 0xE4
        public bool ÎÍÎÌÎÌÍÏÍÎÌÌÌÏÏÎÎÎÌÍÎÌÏ; // 0xE8
        public bool ÏÌÌÌÎÎÏÍÏÌÏÏÌÌÍÏÌÍÏÍÎÏÏ; // 0xE9
        public bool ÎÍÏÌÏÍÍÏÏÌÎÌÌÍÌÎÏÌÏÍÎÎÌ; // 0xEA
        public System.Action ÏÌÌÌÍÌÌÌÎÍÏÍÌÎÍÌÎÎÍÌÍÍÎ; // 0xF0
        public bool ÌÍÍÌÏÏÏÌÌÌÏÍÎÎÍÏÎÎÏÎÌÎÌ; // 0xF8
        public System.Collections.Generic.List`1<UnityEngine.CanvasGroup> ÌÎÎÏÌÎÌÌÎÌÎÌÏÎÌÍÏÏÍÎÌÌÎ; // 0x100
        public System.Collections.Generic.Dictionary`2<string,object> ÌÏÌÍÎÏÎÌÍÎÍÎÏÎÎÌÌÏÍÏÍÎÍ; // 0x108
        public System.Action`1<bool> ÎÏÎÏÍÏÏÌÎÌÏÏÍÍÏÏÏÎÌÏÌÎÍ; // 0x110

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC336EDD0
        public void RaiseCancellation(){} // RVA: 0x7FFAC336F040
        public void InitializePurchaseDescription(){} // RVA: 0x7FFAC336F280
        public void Start(){} // RVA: 0x7FFAC3370680
        public void .ctor(){} // RVA: 0x7FFAC3370B10
        public void Initialize(){} // RVA: 0x7FFAC3370CC0
        public void OnPointerExit(){} // RVA: 0x7FFAC3370CE0
        public void Start_2F7D868A3BB7(){} // RVA: 0x7FFAC3372130
        public void op_Implicit(){} // RVA: 0x7FFAC3372230
        public void DoGetSceneByName_Injected_69D(){} // RVA: 0x7FFAC3372470
        public void DoGetIsLoadedInternal_3EF(){} // RVA: 0x7FFAC3372860
        public void CreateCachedFormatter(){} // RVA: 0x7FFAC3372AD0
        public void EnsureCachedField48(){} // RVA: 0x7FFAC3372BD0
        public void EnsureCachedField48_54BEEA46D288(){} // RVA: 0x7FFAC3372BD0
        public void EnsureCachedField48_37AF47587A40(){} // RVA: 0x7FFAC3372BD0
    }

    /// <summary>Originally: ÍÌÍÌÌÏÏÎÏÌÎÏÍÎÏÍÍÏÍÍÎÍÏ</summary>
    public class PointerEnterPointerExitHandlerImpl_5684_5684 : PointerEnterPointerExitHandler_CF12_CF12
    {
        public 0x6B16ED10 _contentType; // 0x28
        public bool _useLastSearchContentType; // 0x2C
        public ÌÎÏÌÍÌÏÎÏÎÏÎÎÍÌÎÏÎÍÏÍÎÍ ÎÏÏÏÌÎÎÍÏÌÎÎÎÌÎÏÍÍÎÎÍÌÎ; // 0x30

        // ── Methods ──
        public void DoGetInt_676(){} // RVA: 0x7FFACB409390
        public void Awake(){} // RVA: 0x7FFACB409420
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB4094B0
        public void OnPointerEnter(){} // RVA: 0x7FFACB409540
        public void DispatchPointerEvent(){} // RVA: 0x7FFACB409790
        public void OnPointerExit(){} // RVA: 0x7FFACB409820
        public void CreateChildHandler(){} // RVA: 0x7FFACB4098B0
    }

    /// <summary>Originally: ÌÎÏÌÌÌÏÏÏÏÎÎÌÎÏÏÌÍÍÍÎÌÏ</summary>
    public class PointerEnterPointerExitHandlerImpl_5DE3_5DE3 : PointerEnterPointerExitHandler_AE24_AE24
    {
        public UnityEngine.UI.Toggle _5DE3; // 0x48
        public UnityEngine.UI.Image SwitchSprite; // 0x50
        public UnityEngine.UI.Image SwitchBackground; // 0x58
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ StateText; // 0x60
        public UnityEngine.RectTransform Switch; // 0x68
        public UnityEngine.RectTransform SwitchOffTarget; // 0x70
        public UnityEngine.RectTransform SwitchOnTarget; // 0x78
        public UnityEngine.GameObject disabled; // 0x80
        public 0x6B02A720 ÎÌÏÍÎÌÍÎÏÏÏÍÌÎÎÏÎÌÌÏÌÌÏ; // 0x88
        public 0x6B26C448 EaseMode; // 0x8C
        public float TimeToAnimate; // 0x90
        public VRC.Localization.LocalizableString _textContent; // 0x98
        public UnityEngine.Color OnColor; // 0xC0
        public UnityEngine.Color OffColor; // 0xD0
        public UnityEngine.Sprite OnSprite; // 0xE0
        public UnityEngine.Sprite OffSprite; // 0xE8
        public bool ÎÍÎÌÎÌÍÏÍÎÌÌÌÏÏÎÎÎÌÍÎÌÏ; // 0xF0
        public bool ÏÌÌÌÎÎÏÍÏÌÏÏÌÌÍÏÌÍÏÍÎÏÏ; // 0xF1
        public bool ÎÍÏÌÏÍÍÏÏÌÎÌÌÍÌÎÏÌÏÍÎÎÌ; // 0xF2
        public System.Collections.Generic.Dictionary`2<string,object> ÌÏÌÍÎÏÎÌÍÎÍÎÏÎÎÌÌÏÍÏÍÎÍ; // 0xF8

        // ── Methods ──
        public void UpdateActive(){} // RVA: 0x7FFAC337A630
        public void GetInstanceID(){} // RVA: 0x7FFAC337A6C0
        public void Start(){} // RVA: 0x7FFAC337A750
        public void InternalGetHashCode(){} // RVA: 0x7FFAC337A9C0
        public void .ctor(){} // RVA: 0x7FFAC337AD70
        public void Initialize(){} // RVA: 0x7FFAC337AE70
        public void UpdateActive_1EB65A01927C(){} // RVA: 0x7FFAC337AF00
        public void Start_AD3CA0A2BB45(){} // RVA: 0x7FFAC337B010
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC337B280
        public void GetInstanceID_BFDA4FDF422A(){} // RVA: 0x7FFAC337A6C0
        public void SetComponentIntegerProperty(){} // RVA: 0x7FFAC337B510
        public void UpdateActive_77F623463D26(){} // RVA: 0x7FFAC337A630
        public void GetTileDataNoRef(){} // RVA: 0x7FFAC337B620
        public void GetTileDataNoRef_99F9E38A7DC6(){} // RVA: 0x7FFAC337B6C0
        public void UpdateActive_1EB3A37EC458(){} // RVA: 0x7FFAC337A630
        public void UpdateActive_E496D7D9FF62(){} // RVA: 0x7FFAC337A630
    }

    /// <summary>Originally: ÍÌÍÏÎÏÌÌÏÎÏÎÍÌÏÌÌÎÎÍÍÏÎ</summary>
    public class PointerEnterPointerExitHandlerImpl_5DF9_5DF9 : PointerEnterPointerExitHandler_AE24_AE24
    {
        public 0x6B02A510 ÎÌÏÍÎÌÍÎÏÏÏÍÌÎÎÏÎÌÌÏÌÌÏ; // 0x48
        public ÌÏÌÌÌÎÍÍÍÍÏÏÌÍÏÍÌÏÌÎÍÎÌ ÏÎÏÌÏÏÍÎÍÍÎÍÏÌÏÍÌÍÌÌÌÍÌ; // 0x50
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÏÏÏÎÍÏÍÏÌÌÌÌÏÌÌÏÏÌÌÍÌÍ; // 0x58
        public VRC.Localization.LocalizableString ÌÍÍÍÎÏÏÎÍÍÏÎÏÏÌÏÍÏÍÏÎÌÏ; // 0x60
        public UnityEngine.UI.Image ÎÎÌÍÌÌÏÎÍÌÌÎÎÎÏÏÏÌÎÏÌÏÍ; // 0x88
        public int ÍÎÌÍÎÍÌÎÎÌÏÌÌÍÍÌÎÍÏÍÍÏÍ; // 0x90
        public UnityEngine.UI.Button ÌÌÌÌÍÍÌÎÍÍÍÏÏÏÌÌÌÍÏÏÏÌÌ; // 0x98

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3375020
        public void RaiseCancellation(){} // RVA: 0x7FFAC3375230
        public void AccessblocksRaycasts(){} // RVA: 0x7FFAC33752D0
        public void IsInvoking(){} // RVA: 0x7FFAC33754E0
        public void OnPointerExit(){} // RVA: 0x7FFAC3375580
        public void Initialize(){} // RVA: 0x7FFAC3375790
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Start(){} // RVA: 0x7FFAC33759A0
        public void Instantiate(){} // RVA: 0x7FFAC3375BB0
        public void Update(){} // RVA: 0x7FFAC3375DC0
    }

    /// <summary>Originally: ÌÌÏÏÌÍÎÏÏÌÌÏÍÍÌÏÏÏÎÎÎÏÎ</summary>
    public class PointerEnterPointerExitHandlerImpl_8BC4_8BC4 : PointerEnterPointerExitHandler_AE24_AE24
    {
        public UnityEngine.Sprite iconTakePhoto; // 0x48
        public UnityEngine.Sprite iconStopPhoto; // 0x50
        public UnityEngine.UI.Button button; // 0x58
        public UnityEngine.UI.Image icon; // 0x60
        public UnityEngine.UI.Image disabled; // 0x68
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ label; // 0x70
        public bool ÍÌÏÍÍÎÏÎÍÍÎÎÎÎÎÏÍÎÍÍÏÏÎ; // 0x78

        // ── Methods ──
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC44BA100
        public void RaiseCancellation(){} // RVA: 0x7FFAC44BA110
        public void OnEnable(){} // RVA: 0x7FFAC44BA1B0
        public void DontDestroyOnLoad_908F481DEF74(){} // RVA: 0x7FFAC44BA100
        public void IsInvoking(){} // RVA: 0x7FFAC44BA1B0
        public void Initialize(){} // RVA: 0x7FFAC44BA1C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Start(){} // RVA: 0x7FFAC44BA1D0
        public void StartCoroutine(){} // RVA: 0x7FFAC44BA1C0
        public void OnDisable(){} // RVA: 0x7FFAC44BA100
        public void IsInvoking_7E13A5FBB795(){} // RVA: 0x7FFAC44BA260
        public void ContainsChild(){} // RVA: 0x7FFAC44BA2F0
        public void DoToCoroutine(){} // RVA: 0x7FFAC44BA3C0
        public void HandlePointerEvent(){} // RVA: 0x7FFAC44BA1C0
        public void TryGetNext(){} // RVA: 0x7FFAC44BA4E0
    }

    /// <summary>Originally: ÌÏÏÎÎÍÎÌÏÌÌÍÍÏÎÍÎÏÏÎÌÎÍ</summary>
    public class PointerEnterPointerExitHandlerImpl_9F1F_9F1F : PointerEnterPointerExitHandler_CF12_CF12
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Handle(){} // RVA: 0x7FFACB91AF50
    }

    /// <summary>Originally: ÎÏÍÍÍÏÎÍÏÎÍÍÌÍÌÌÏÍÎÏÌÎÏ</summary>
    public class PointerEnterPointerExitHandlerImpl_C021_C021 : PointerEnterPointerExitHandler_AE24_AE24
    {
        public System.Action`1<ÎÏÍÍÍÏÎÍÏÎÍÍÌÍÌÌÏÍÎÏÌÎÏ> _c021; // 0x48
        public UnityEngine.GameObject selectedIndicator; // 0x50
        public UnityEngine.UI.Button ÎÏÍÎÏÍÎÏÎÏÏÍÍÏÏÍÎÎÎÍÏÌÌ; // 0x58

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3398C00
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void IsInvoking(){} // RVA: 0x7FFAC3398C00
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFAC3398C10
        public void FormatEventCode(){} // RVA: 0x7FFAC3398CB0
        public void Initialize(){} // RVA: 0x7FFAC3398CE0
        public void OnPointerExit(){} // RVA: 0x7FFAC3398CB0
        public void Start(){} // RVA: 0x7FFAC3398CB0
        public void StartCoroutine(){} // RVA: 0x7FFAC3398D40
        public void GetIKSolver_D2B8C47C540B(){} // RVA: 0x7FFAC2F9C730
        public void SetModelShader(){} // RVA: 0x7FFAC2F9C740
        public void AdvanceStateAndBuildData(){} // RVA: 0x7FFAC3398E40
        public void Awake(){} // RVA: 0x7FFAC3398EA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÍÎÎÎÌÌÌÎÍÍÌÎÎÌÌÍÌÏÏÍÎÍÌ</summary>
    public class PointerEnterPointerExitHandlerImpl_C564_C564 : PointerEnterPointerExitHandler_CF12_CF12
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Handle(){} // RVA: 0x7FFACB920010
    }

    /// <summary>Originally: ÎÍÌÌÍÌÍÌÏÎÍÍÏÏÍÏÍÎÏÏÎÎÎ</summary>
    public class PointerEnterPointerExitHandlerImpl_C99A_C99A : PointerEnterPointerExitHandler_CF12_CF12
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Handle(){} // RVA: 0x7FFACB9200B0
    }

    /// <summary>Originally: ÎÍÎÏÌÌÏÍÎÏÌÏÍÍÍÌÏÎÏÏÎÌÍ</summary>
    public class PointerEnterPointerExitHandlerImpl_DCCC_DCCC : PointerEnterPointerExitHandler_CF12_CF12
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Handle(){} // RVA: 0x7FFACB926280
    }

    /// <summary>Originally: ÍÏÌÎÎÏÌÎÌÍÏÍÎÎÌÎÏÎÌÎÍÎÌ</summary>
    public class PointerEnterPointerExitHandlerSibling_B560_B560 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB34FD10
        public void RaiseCancellation(){} // RVA: 0x7FFACB34FDB0
        public void IsInvoking(){} // RVA: 0x7FFACB34FE50
        public void CancelInvoke(){} // RVA: 0x7FFACB34FEF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB34FF90
        public void SetCancellationCallback(){} // RVA: 0x7FFACB350030
        public void IsInvoking_F4CE4F1E89DB(){} // RVA: 0x7FFACB3500D0
    }

    /// <summary>Originally: ÏÌÍÏÎÍÌÎÍÎÌÏÏÎÍÏÍÏÍÌÎÏÏ</summary>
    public class PointerEnterPointerExitHandler_0237_0237 : MonoBehaviour
    {
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ ÎÏÎÏÏÌÍÎÎÌÍÌÍÌÍÏÍÌÏÎÎÏÏ; // 0x20
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ ÏÌÌÍÍÌÌÌÍÎÍÍÎÎÌÏÍÎÏÌÎÌÍ; // 0x28
        public ÍÎÍÍÌÎÏÏÌÍÏÏÏÎÍÍÍÎÍÍÏÎÌ ÌÌÏÍÌÎÍÍÌÎÍÍÎÏÎÎÎÏÌÏÏÍÍ; // 0x30
        public ÍÎÍÍÌÎÏÏÌÍÏÏÏÎÍÍÍÎÍÍÏÎÌ ÌÍÌÌÍÍÌÍÌÍÍÎÌÏÍÍÏÎÎÏÍÎÏ; // 0x38
        public bool _sendImageChangeEvents; // 0x40
        public System.Action ÍÍÍÏÍÌÌÌÍÍÎÎÎÌÍÌÎÍÏÍÎÍÏ; // 0x48
        public float ÍÎÏÎÎÍÎÎÎÍÍÏÌÌÍÎÎÎÌÍÍÌÎ;
        public float ÌÏÍÍÎÎÎÏÏÍÌÌÌÍÌÌÎÎÏÍÍÎÌ;
        public float ÏÍÏÍÌÏÎÌÌÏÌÌÌÏÏÏÎÌÌÏÏÌÍ; // 0x50
        public int ÍÏÍÌÌÍÌÍÍÏÌÌÌÎÎÏÌÎÌÎÏÏÌ; // 0x54
        public UnityEngine.GameObject ÍÏÎÍÌÎÍÌÍÏÎÍÍÏÍÍÍÎÏÏÏÌÎ; // 0x58
        public float ÎÎÎÏÏÏÏÎÌÍÎÌÌÏÏÌÏÌÍÌÍÏÌ; // 0x60
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ>> ÌÎÌÏÏÍÍÍÏÍÌÍÍÎÍÏÎÌÍÎÎÍÌ; // 0x68
        public bool ÏÎÍÍÍÏÎÍÏÏÍÎÎÍÍÌÎÎÍÍÎÍÏ; // 0x70
        public bool ÎÏÌÏÍÎÏÏÌÌÌÎÏÍÍÏÌÎÍÏÌÌÍ; // 0x71
        public bool ÎÎÌÍÌÍÍÎÎÎÍÌÎÏÎÌÏÎÍÏÌÍÍ; // 0x72
        public System.Collections.Generic.HashSet`1<ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ> ÏÏÏÍÌÍÏÍÌÌÏÌÎÎÍÌÏÏÌÌÎÍÏ; // 0x78

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB7B5280
        public void RaiseCancellation(){} // RVA: 0x7FFACB7B5300
        public void OnDisable(){} // RVA: 0x7FFACB7B5450
        public void set_enabled(){} // RVA: 0x7FFAC3CF7970
        public void Invoke(){} // RVA: 0x7FFACB7B5460
        public void InvokeRepeating(){} // RVA: 0x7FFACB7B58A0
        public void .ctor(){} // RVA: 0x7FFACB7B5980
        public void Initialize(){} // RVA: 0x7FFACB7B59D0
        public void Update(){} // RVA: 0x7FFACB7B6150
        public void StartCoroutine(){} // RVA: 0x7FFACB7B6250
        public void OnCollisionExit(){} // RVA: 0x7FFACB7B6350
        public void OnEnable(){} // RVA: 0x7FFACB7B63D0
        public void StopCoroutine(){} // RVA: 0x7FFACB7B65D0
        public void OnTriggerExit(){} // RVA: 0x7FFAC3CF7970
        public void OnBecameVisible(){} // RVA: 0x7FFACB7B5450
        public void OnPointerExit(){} // RVA: 0x7FFACB7B6B90
        public void OnPointerEnter(){} // RVA: 0x7FFACB7B6E40
        public void set_useGUILayout(){} // RVA: 0x7FFACB7B7080
        public void print(){} // RVA: 0x7FFACB7B72C0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB7B7350
        public void Start(){} // RVA: 0x7FFACB7B73D0
        public void InvokeDelayed(){} // RVA: 0x7FFACB7B7960
    }

    /// <summary>Originally: ÌÏÍÏÎÎÌÎÏÍÏÌÏÎÍÎÍÍÏÏÎÏÌ</summary>
    public class PointerEnterPointerExitHandler_0AA7_0AA7 : MonoBehaviour
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _nameText; // 0x20
        public UnityEngine.UI.Image _thumbnail; // 0x28
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _button; // 0x30
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _tooltip; // 0x38
        public ÎÌÌÎÏÍÎÎÏÌÍÍÌÏÏÎÎÎÎÍÍÌÍ _selectionBinding; // 0x40
        public UnityEngine.CanvasGroup _vrcPlusIcon; // 0x48
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _vrcPlusButton; // 0x50
        public ÍÍÍÎÏÍÍÏÍÍÎÍÌÎÏÏÎÍÎÎÌÌÏ ÌÌÎÍÏÌÏÏÍÌÍÏÌÌÎÍÌÌÌÌÍÌÎ; // 0x58
        public string ÌÍÍÌÌÏÌÎÍÌÎÏÎÎÏÌÍÌÌÏÎÌÍ; // 0x60
        public ÌÍÏÏÌÎÌÌÌÌÍÎÌÌÌÎÎÍÎÏÍÎÏ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x68

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB72E490
        public void RaiseCancellation(){} // RVA: 0x7FFACB72E520
        public void IsInvoking(){} // RVA: 0x7FFACB72E630
        public void CancelInvoke(){} // RVA: 0x7FFACB72E6C0
        public void Invoke(){} // RVA: 0x7FFACB72E750
        public void InvokeRepeating(){} // RVA: 0x7FFACB72E860
        public void OnPointerExit(){} // RVA: 0x7FFACB72ECE0
        public void Awake_4EC08B91102F(){} // RVA: 0x7FFACB72ED70
        public void StartCoroutine(){} // RVA: 0x7FFACB72EE10
        public void OnEnable(){} // RVA: 0x7FFACB72F290
        public void Awake(){} // RVA: 0x7FFACB72FA70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerEnter(){} // RVA: 0x7FFACB72FB80
        public void StopCoroutine(){} // RVA: 0x7FFACB72FC20
    }

    /// <summary>Originally: ÍÏÍÏÍÏÌÍÍÍÏÏÍÏÌÎÎÎÍÌÎÏÍ</summary>
    public class PointerEnterPointerExitHandler_20E8_20E8 : MonoBehaviour
    {
        public UnityEngine.UI.Button _20E8; // 0x20
        public UnityEngine.GameObject _editIndicator; // 0x28
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _toolTip; // 0x30
        public VRC.UI.Core.Styles.StyleElement _style; // 0x38
        public bool ÍÎÎÎÌÍÌÎÌÏÌÍÏÎÎÍÎÌÏÍÍÎÍ; // 0x40

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC2F4F0C0
        public void RaiseCancellation(){} // RVA: 0x7FFACB919D70
        public void OnPointerExit(){} // RVA: 0x7FFACB919E90
        public void CancelInvoke(){} // RVA: 0x7FFACB919FB0
        public void Invoke(){} // RVA: 0x7FFACB91A0D0
        public void InvokeRepeating(){} // RVA: 0x7FFACB91A430
        public void OnPointerEnter(){} // RVA: 0x7FFACB91A7B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB91A8A0
        public void StartCoroutine(){} // RVA: 0x7FFACB91A990
        public void Awake(){} // RVA: 0x7FFACB91AD10
        public void OnEnable(){} // RVA: 0x7FFACB91AE30
    }

    /// <summary>Originally: ÎÎÏÏÎÏÎÍÌÍÌÌÎÎÎÎÎÍÍÍÏÎÍ</summary>
    public class PointerEnterPointerExitHandler_274A_274A : MonoBehaviour
    {
        public ÏÍÍÏÎÏÏÎÍÍÌÍÍÍÎÌÌÎÌÏÎÏÎ ÍÍÌÍÌÏÎÌÎÏÎÍÌÏÎÍÏÌÎÎÏÌÎ; // 0x20
        public UnityEngine.GameObject ÍÍÎÌÎÌÌÍÏÍÏÍÌÍÍÎÍÎÍÍÌÌÍ; // 0x28

        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFACB89B260
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB89B290
        public void CancelInvoke(){} // RVA: 0x7FFACB89B2C0
        public void Invoke(){} // RVA: 0x7FFACB89B290
        public void OnPointerExit(){} // RVA: 0x7FFACB89B290
        public void Invoke_C7241CDCCFD3(){} // RVA: 0x7FFACB89B290
        public void IsInvoking(){} // RVA: 0x7FFACB89B290
        public void StartCoroutine(){} // RVA: 0x7FFACB89B2F0
    }

    /// <summary>Originally: ÍÌÍÎÍÏÏÍÌÎÌÎÎÌÌÌÍÌÍÏÎÌÎ</summary>
    public class PointerEnterPointerExitHandler_7555_7555 : MonoBehaviour
    {
        public UnityEngine.GameObject ÍÎÎÏÍÎÍÎÍÎÏÏÌÌÎÌÎÌÏÎÌÍÏ; // 0x20

        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7FFAC374F800
        public void RaiseCancellation(){} // RVA: 0x7FFAC374F810
        public void IsInvoking(){} // RVA: 0x7FFAC374F940
        public void CancelInvoke(){} // RVA: 0x7FFAC374FA60
        public void Start(){} // RVA: 0x7FFAC374FA70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerEnter(){} // RVA: 0x7FFAC374FA60
        public void LateUpdate(){} // RVA: 0x7FFAC374FB90
        public void StartCoroutine(){} // RVA: 0x7FFAC374FCB0
        public void OnDestroy(){} // RVA: 0x7FFAC374FDE0
        public void OnApplicationPause(){} // RVA: 0x7FFAC374FA60
    }

    /// <summary>Originally: ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ</summary>
    public class PointerEnterPointerExitHandler_9C10_9C10 : MonoBehaviour
    {
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<VRC.Localization.LocalizableString> _destroyCancellationToken;
        public VRC.Localization.LocalizableString _useGUILayout; // 0x20
        public VRC.Localization.LocalizableString f_5F8; // 0x48
        public bool f_1E7; // 0x70
        public bool ÎÏÎÏÎÌÌÏÏÏÍÏÎÎÌÎÏÍÏÏÎÌÎ; // 0x71

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB9A2ED0
        public void RaiseCancellation(){} // RVA: 0x7FFAC34EA280
        public void IsInvoking(){} // RVA: 0x7FFAC34E9F20
        public void CancelInvoke(){} // RVA: 0x7FFACB9A2FA0
        public void OnDisable(){} // RVA: 0x7FFACB9A2FA0
        public void OnPointerEnter(){} // RVA: 0x7FFACB9A2FB0
        public void OnApplicationPause(){} // RVA: 0x7FFACB9A2FC0
        public void get_source(){} // RVA: 0x7FFAC34EA3D0
        public void StartCoroutine(){} // RVA: 0x7FFACB9A2FA0
        public void OnBecameInvisible(){} // RVA: 0x7FFACB9A2FB0
        public void OnCollisionEnter(){} // RVA: 0x7FFACB9A2700
        public void OnPointerExit(){} // RVA: 0x7FFACB9A2FA0
        public void StopCoroutine(){} // RVA: 0x7FFACB9A2FD0
        public void OnTriggerEnter(){} // RVA: 0x7FFACB9A2FB0
        public void OnTriggerStay(){} // RVA: 0x7FFACB9A2700
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_destination(){} // RVA: 0x7FFAC34EA260
        public void .cctor(){} // RVA: 0x7FFACB9A3080
        public void print(){} // RVA: 0x7FFACB9A3180
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB9A2FB0
    }

    /// <summary>Originally: ÌÎÍÏÏÏÎÌÎÍÏÍÏÌÎÎÏÏÎÍÌÍÏ</summary>
    public class PointerEnterPointerExitHandler_AE24_AE24 : MonoBehaviour
    {
        public VRC.Localization.LocalizableString ÏÏÏÌÍÍÏÏÍÌÍÏÌÌÍÌÌÎÍÌÍÌÎ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3372EB0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3372F60
        public void IsInvoking(){} // RVA: 0x7FFAC3373080
        public void OnPointerEnter(){} // RVA: 0x7FFAC3373130
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC3373250
        public void OnPointerExit(){} // RVA: 0x7FFAC3373300
        public void Start(){} // RVA: 0x7FFAC33733C0
        public void StartCoroutine(){} // RVA: 0x7FFAC3373470
        public void Update(){} // RVA: 0x7FFAC3373520
    }

    /// <summary>Originally: ÍÍÍÎÎÎÌÌÌÏÍÏÌÌÎÍÍÏÍÏÍÏÏ</summary>
    public class PointerEnterPointerExitHandler_BAD3_BAD3 : MonoBehaviour
    {
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ ÎÏÎÏÏÌÍÎÎÌÍÌÍÌÍÏÍÌÏÎÎÏÏ; // 0x20
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ ÏÌÌÍÍÌÌÌÍÎÍÍÎÎÌÏÍÎÏÌÎÌÍ; // 0x28
        public ÍÎÍÍÌÎÏÏÌÍÏÏÏÎÍÍÍÎÍÍÏÎÌ ÌÌÏÍÌÎÍÍÌÎÍÍÎÏÎÎÎÏÌÏÏÍÍ; // 0x30
        public ÍÎÍÍÌÎÏÏÌÍÏÏÏÎÍÍÍÎÍÍÏÎÌ ÌÍÌÌÍÍÌÍÌÍÍÎÌÏÍÍÏÎÎÏÍÎÏ; // 0x38
        public bool _sendImageChangeEvents; // 0x40
        public UnityEngine.RectTransform ÌÍÌÏÏÏÏÎÏÌÌÍÌÍÎÏÌÍÌÌÍÍÎ; // 0x48
        public float ÏÎÌÏÍÍÌÏÎÌÎÌÍÍÏÏÍÍÎÌÎÎÎ; // 0x50
        public float ÏÌÍÌÏÏÍÌÎÏÎÌÌÌÏÏÏÍÎÍÏÍÍ; // 0x54
        public float ÎÍÌÎÌÌÎÌÌÎÎÍÍÍÏÍÌÌÏÌÏÎÍ; // 0x58
        public float ÎÏÍÌÎÍÍÍÎÏÏÏÌÏÎÌÏÌÌÏÌÏÍ; // 0x5C
        public float ÎÎÏÌÎÎÎÏÏÍÏÍÏÎÍÌÎÌÍÍÍÌÏ; // 0x60
        public float ÏÏÍÏÎÌÎÌÌÏÎÌÏÌÎÌÌÌÍÌÌÏÎ; // 0x64
        public System.Action ÍÍÍÏÍÌÌÌÍÍÎÎÎÌÍÌÎÍÏÍÎÍÏ; // 0x68
        public float ÍÎÏÎÎÍÎÎÎÍÍÏÌÌÍÎÎÎÌÍÍÌÎ;
        public float ÌÏÍÍÎÎÎÏÏÍÌÌÌÍÌÌÎÎÏÍÍÎÌ;
        public float ÏÍÏÍÌÏÎÌÌÏÌÌÌÏÏÏÎÌÌÏÏÌÍ; // 0x70
        public int ÍÏÍÌÌÍÌÍÍÏÌÌÌÎÎÏÌÎÌÎÏÏÌ; // 0x74
        public int ÏÏÎÎÌÏÌÎÎÌÍÏÌÌÎÍÎÍÌÏÏÏÌ; // 0x78
        public UnityEngine.GameObject ÍÏÎÍÌÎÍÌÍÏÎÍÍÏÍÍÍÎÏÏÏÌÎ; // 0x80
        public float ÎÎÎÏÏÏÏÎÌÍÎÌÌÏÏÌÏÌÍÌÍÏÌ; // 0x88
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<System.Collections.Generic.List`1<ÏÎÍÎÍÌÎÎÏÏÍÏÌÌÎÏÎÌÌÏÌÍÌ>> ÌÎÌÏÏÍÍÍÏÍÌÍÍÎÍÏÎÌÍÎÎÍÌ; // 0x90
        public bool ÏÎÍÍÍÏÎÍÏÏÍÎÎÍÍÌÎÎÍÍÎÍÏ; // 0x98
        public bool ÎÏÌÏÍÎÏÏÌÌÌÎÏÍÍÏÌÎÍÏÌÌÍ; // 0x99
        public bool ÎÎÌÍÌÍÍÎÎÎÍÌÎÏÎÌÏÎÍÏÌÍÍ; // 0x9A
        public System.Collections.Generic.HashSet`1<ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ> ÏÏÏÍÌÍÏÍÌÌÏÌÎÎÍÌÏÏÌÌÎÍÏ; // 0xA0
        public UnityEngine.Vector2 ÎÏÏÎÌÏÎÌÏÍÌÌÌÏÍÎÍÎÍÍÎÍÍ; // 0xA8
        public System.Collections.Generic.List`1<ÏÌÏÍÍÎÌÏÍÎÏÌÏÎÍÌÍÍÎÌÎÌÎ> ÎÎÏÏÏÏÌÌÏÏÌÎÏÏÏÌÏÎÍÎÍÎÌ; // 0xB0

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB7B8020
        public void Start(){} // RVA: 0x7FFACB7B87B0
        public void set_enabled(){} // RVA: 0x7FFAC3CF7970
        public void OnPointerExit(){} // RVA: 0x7FFACB7B8F10
        public void OnDisable(){} // RVA: 0x7FFACB7B91C0
        public void InvokeRepeating(){} // RVA: 0x7FFACB7B91D0
        public void CancelInvoke(){} // RVA: 0x7FFACB7B9700
        public void IsInvoking(){} // RVA: 0x7FFACB7B9E50
        public void StartCoroutine(){} // RVA: 0x7FFAC3CF7970
        public void OnBecameVisible(){} // RVA: 0x7FFACB7B9F00
        public void OnBecameInvisible(){} // RVA: 0x7FFACB7BA630
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB7BAB60
        public void StopCoroutine(){} // RVA: 0x7FFACB7BAC40
        public void OnCollisionExit(){} // RVA: 0x7FFACB7BACF0
        public void Update(){} // RVA: 0x7FFACB7BAE60
        public void .ctor(){} // RVA: 0x7FFACB7BB520
        public void Initialize(){} // RVA: 0x7FFACB7BB640
        public void OnEnable(){} // RVA: 0x7FFACB7BBE50
        public void print(){} // RVA: 0x7FFACB7BC060
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB7BC4A0
        public void OnPointerEnter(){} // RVA: 0x7FFACB7BC520
        public void InvokeDelayed(){} // RVA: 0x7FFAC3CF7970
    }

    /// <summary>Originally: ÍÎÏÏÌÏÌÎÏÏÍÌÍÌÌÍÎÍÍÏÏÌÍ</summary>
    public class PointerEnterPointerExitHandler_BDDC_BDDC : MonoBehaviour
    {
        public UnityEngine.UI.Button ÎÌÏÏÏÍÌÎÏÏÎÎÍÏÌÌÍÍÏÏÏÏÎ; // 0x20
        public string ÏÏÍÏÍÌÌÌÏÌÏÌÎÍÍÍÏÌÍÎÎÌÍ; // 0x28
        public int ÌÏÍÎÏÌÎÌÏÎÌÎÎÌÍÍÍÍÎÍÎÍÎ; // 0x30
        public bool ÌÏÎÎÌÍÍÌÎÎÏÎÍÎÏÎÏÏÎÌÍÎÍ; // 0x34
        public LinkImage[] _linkImages; // 0x38
        public UnityEngine.UI.RawImage _image; // 0x40
        public UnityEngine.Texture _genericTexture; // 0x48
        public UnityEngine.Texture _addLinkTexture; // 0x50
        public UnityEngine.GameObject _hoverTrashCan; // 0x58
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _label; // 0x60
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _tooltip; // 0x68
        public ÍÍÏÏÏÌÎÎÌÌÍÌÎÍÍÌÎÍÏÍÎÌÌ ÎÌÏÍÌÏÏÏÏÌÎÎÌÏÎÌÌÎÌÍÏÌÏ; // 0x70

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFACB657940
        public void OnDisable(){} // RVA: 0x7FFACB707A00
        public void OnPointerEnter(){} // RVA: 0x7FFACB707B70
        public void CancelInvoke(){} // RVA: 0x7FFACB707BB0
        public void Invoke(){} // RVA: 0x7FFACB707DA0
        public void Awake(){} // RVA: 0x7FFACB707F90
        public void OnDestroy(){} // RVA: 0x7FFACB708110
        public void IsInvoking(){} // RVA: 0x7FFACB708180
        public void StartCoroutine(){} // RVA: 0x7FFACB7082F0
        public void OnBecameVisible(){} // RVA: 0x7FFACB708610
        public void OnBecameInvisible(){} // RVA: 0x7FFACB7086B0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB708750
        public void StopCoroutine(){} // RVA: 0x7FFACB657420
        public void OnCollisionExit(){} // RVA: 0x7FFACB708A70
        public void OnTriggerEnter(){} // RVA: 0x7FFACB708CD0
        public void OnPointerExit(){} // RVA: 0x7FFACB709340
        public void get_useGUILayout(){} // RVA: 0x7FFACB7093C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB709470
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB709640
    }

    /// <summary>Originally: ÎÏÏÌÎÌÎÌÌÌÏÎÏÌÍÏÏÍÌÌÍÍÏ</summary>
    public class PointerEnterPointerExitHandler_C66E_C66E : MonoBehaviour
    {
        public UnityEngine.UI.ScrollRect _c66E; // 0x20
        public UnityEngine.UI.Button _featuredButton; // 0x28
        public ÍÎÏÌÏÏÌÏÍÌÌÌÏÏÎÏÏÏÎÎÏÎÎ _featuredRadioButtonSelector; // 0x30
        public ÎÎÍÍÌÎÍÏÌÌÏÌÏÎÍÎÏÌÏÍÏÎÌ _radioButtonSelectorGroup; // 0x38
        public float _shelfScrollOffset; // 0x40
        public UnityEngine.UI.Button _expandToggleButton; // 0x48
        public ÎÍÎÌÌÎÎÍÏÎÍÌÎÍÍÏÎÏÍÍÍÍÏ ÎÍÍÍÎÏÎÍÎÌÏÎÎÌÍÏÌÍÎÎÌÍÏ; // 0x50
        public System.Collections.Generic.List`1<ÎÌÏÌÎÏÎÍÎÎÏÌÎÏÎÍÏÍÏÌÎÎÏ> ÏÏÌÌÌÍÍÎÎÏÍÏÌÍÌÏÎÌÌÍÏÌÍ; // 0x58
        public bool ÌÌÍÌÌÎÍÏÎÏÍÌÏÌÌÍÏÍÎÎÏÏÏ; // 0x60
        public string ÎÌÎÎÌÎÏÎÍÌÎÍÏÌÌÌÌÎÍÍÍÏÍ; // 0x68
        public bool ÏÍÏÏÎÌÏÎÏÎÏÎÍÍÏÌÏÎÍÎÎÎÏ; // 0x70
        public int <ÏÎÎÌÌÎÍÍÌÏÍÏÌÍÎÎÌÍÏÎÏÎÌ>k__BackingField; // 0x74

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB635B00
        public void OnPointerEnter(){} // RVA: 0x7FFACB635B40
        public void IsInvoking(){} // RVA: 0x7FFACB635B70
        public void CancelInvoke(){} // RVA: 0x7FFACB635BA0
        public void get_DefaultBufferSize(){} // RVA: 0x7FFAC43D9E20
        public void OnEnable(){} // RVA: 0x7FFACB636050
        public void Awake(){} // RVA: 0x7FFACB636070
        public void Start(){} // RVA: 0x7FFAC76E7960
        public void StartCoroutine(){} // RVA: 0x7FFACB6363E0
        public void LateUpdate(){} // RVA: 0x7FFACB636630
        public void OnDisable(){} // RVA: 0x7FFAC43D9E20
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB636650
        public void StopCoroutine(){} // RVA: 0x7FFACB636050
        public void OnApplicationQuit(){} // RVA: 0x7FFACB636630
        public void OnDestroy(){} // RVA: 0x7FFACB637060
        public void set_SocketFlags(){} // RVA: 0x7FFAC48B4C80
        public void OnPointerExit(){} // RVA: 0x7FFACB637140
        public void set_useGUILayout(){} // RVA: 0x7FFACB637170
        public void .ctor(){} // RVA: 0x7FFACB637210
        public void Initialize(){} // RVA: 0x7FFACB637310
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC43D9E20
        public void InvokeDelayed(){} // RVA: 0x7FFACB637320
        public void OnTriggerStay(){} // RVA: 0x7FFACB637320
        public void OnTriggerExit(){} // RVA: 0x7FFACB637330
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB637310
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB635B00
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB6376A0
        public void StopCoroutineManaged(){} // RVA: 0x7FFACB637AD0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFACB637CF0
        public void GetScriptClassName(){} // RVA: 0x7FFACB637F10
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFACB638060
    }

    /// <summary>Originally: ÍÍÍÍÏÌÌÍÌÍÌÎÏÍÍÍÎÍÎÍÌÏÏ</summary>
    public class PointerEnterPointerExitHandler_CF12_CF12 : MonoBehaviour
    {
        public float ÍÏÍÏÎÍÎÍÏÎÍÎÌÌÏÌÌÎÍÏÏÍÍ;
        public float ÎÎÏÌÌÏÏÏÎÏÌÌÎÎÏÏÏÏÍÍÌÏÏ; // 0x20
        public bool ÌÏÌÌÏÎÍÏÎÍÌÍÎÏÍÍÎÍÍÌÏÎÏ; // 0x24
        public bool ÏÏÎÎÍÍÎÎÍÏÎÌÏÎÎÏÏÎÎÌÎÍÌ; // 0x25

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFAC2C70980
        public void OnPointerUp(){} // RVA: 0x7FFACB754A90
        public void OnPointerEnter(){} // RVA: 0x7FFACB754BD0
        public void OnPointerExit(){} // RVA: 0x7FFACB754BE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÎÍÎÎÎÌÏÎÍÏÌÍÎÎÍÌÏÎÎÏÌÍÍ</summary>
    public class PointerEnterPointerExitHandler_D2BF_D2BF : MonoBehaviour
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _d2BF; // 0x20
        public UnityEngine.UI.Button _button; // 0x28
        public UnityEngine.GameObject _editIndicator; // 0x30
        public UnityEngine.GameObject _hoverTrashCan; // 0x38
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _tooltip; // 0x40
        public VRC.UI.Core.Styles.StyleElement _styleElement; // 0x48
        public ÌÍÍÎÌÎÏÎÏÌÏÌÍÏÏÏÏÍÍÎÌÍÎ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x50
        public string ÍÍÍÍÍÌÌÏÎÏÍÎÌÎÌÎÍÌÎÏÍÍÏ; // 0x58
        public bool ÍÎÎÎÌÍÌÎÌÏÌÍÏÎÎÍÎÌÏÍÍÎÍ; // 0x60
        public string ÎÌÏÎÏÍÌÏÌÍÏÏÌÏÏÏÎÏÍÌÍÏÍ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB91B020
        public void RaiseCancellation(){} // RVA: 0x7FFACB91BB40
        public void OnPointerExit(){} // RVA: 0x7FFACB91C300
        public void CancelInvoke(){} // RVA: 0x7FFACB91C3F0
        public void Invoke(){} // RVA: 0x7FFACB91C440
        public void InvokeRepeating(){} // RVA: 0x7FFACB91C550
        public void .ctor_16457FDE7DDB(){} // RVA: 0x7FFACB91C9A0
        public void OnPointerEnter(){} // RVA: 0x7FFACB91C9C0
        public void StartCoroutine(){} // RVA: 0x7FFACB91CA60
        public void InitializeVRSDKDependencies(){} // RVA: 0x7FFACB91CC30
        public void Awake(){} // RVA: 0x7FFACB91CD50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB91C9A0
        public void StopCoroutine(){} // RVA: 0x7FFACB91CE60
        public void Update(){} // RVA: 0x7FFACB91D970
        public void StopAllCoroutines(){} // RVA: 0x7FFACB91DA90
        public void get_useGUILayout(){} // RVA: 0x7FFACB91DBA0
        public void set_useGUILayout(){} // RVA: 0x7FFACB91DCB0
        public void print(){} // RVA: 0x7FFACB91DDD0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFACB91DEE0
        public void OnEnable(){} // RVA: 0x7FFACB91E000
    }

    /// <summary>Originally: ÌÎÌÏÏÏÌÏÏÎÎÏÍÍÌÎÎÍÌÏÍÎÍ</summary>
    public class PointerEnterPointerExitHandler_E321_E321 : MonoBehaviour
    {
        public UnityEngine.UI.Image playImage; // 0x20
        public UnityEngine.UI.Button playPauseButton; // 0x28
        public RenderHeads.Media.AVProVideo.MediaPlayer target; // 0x30
        public ÍÎÌÍÍÌÌÍÍÌÍÎÍÍÍÍÍÍÎÎÌÏÌ timeSlider; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB7C92A0
        public void RaiseCancellation(){} // RVA: 0x7FFACB7C94F0
        public void IsInvoking(){} // RVA: 0x7FFACB7C9740
        public void CancelInvoke(){} // RVA: 0x7FFACB7C9910
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB7C9A30
        public void Awake(){} // RVA: 0x7FFACB7C9B40
        public void Start(){} // RVA: 0x7FFACB7C9C60
        public void StartCoroutine(){} // RVA: 0x7FFACB7C9D80
        public void Update(){} // RVA: 0x7FFACB7C9EB0
        public void LateUpdate(){} // RVA: 0x7FFACB7C9FE0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB7CA060
        public void OnPointerExit(){} // RVA: 0x7FFACB7CA270
        public void StopCoroutine(){} // RVA: 0x7FFACB7C9FE0
        public void OnPointerEnter(){} // RVA: 0x7FFACB7CA440
    }

    /// <summary>Originally: ÌÍÌÍÎÌÎÍÏÌÎÍÌÌÍÌÌÍÎÎÎÏÏ</summary>
    public class PointerEnterPointerExitHandler_E95D_E95D : MonoBehaviour
    {
        public UnityEngine.UI.Text ÍÎÌÏÏÎÎÌÎÎÏÌÏÍÌÎÏÎÌÎÎÎÌ; // 0x20
        public UnityEngine.UI.Text ÍÏÏÌÌÌÏÎÌÍÎÏÍÌÏÍÏÏÌÌÎÏÌ; // 0x28
        public string ÎÍÍÎÎÍÎÎÍÌÎÏÌÌÎÏÍÏÎÏÏÎÍ; // 0x30
        public string ÍÌÍÌÌÏÌÎÏÏÏÎÏÎÌÏÎÏÌÏÍÎÎ; // 0x38
        public bool ÎÍÏÌÏÎÎÎÎÎÌÍÏÌÌÌÌÌÌÍÎÌÌ; // 0x40
        public bool ÎÏÎÎÏÎÏÏÌÍÎÌÍÎÎÏÌÌÍÍÏÎÎ; // 0x41

        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFAC42F48A0
        public void RaiseCancellation(){} // RVA: 0x7FFAC42F48D0
        public void IsInvoking(){} // RVA: 0x7FFAC42F48F0
        public void CancelInvoke(){} // RVA: 0x7FFAC42F4910
        public void Invoke(){} // RVA: 0x7FFAC42F48A0
        public void InvokeRepeating(){} // RVA: 0x7FFAC42F4B50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEnable(){} // RVA: 0x7FFAC42F4DE0
        public void OnDisable(){} // RVA: 0x7FFAC42F5020
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAC31D8A10
        public void OnPointerExit(){} // RVA: 0x7FFAC42F48F0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC42F5040
        public void StopCoroutine(){} // RVA: 0x7FFAC42F52E0
        public void OnDestroy(){} // RVA: 0x7FFAC31D8A10
    }

    /// <summary>Originally: ÍÎÍÏÌÎÎÏÌÍÎÌÌÍÎÌÌÏÌÏÎÍÌ</summary>
    public class PointerEnterPointerExitHandler_F0EF_F0EF : MonoBehaviour
    {
        public UnityEngine.GameObject[] ÌÏÌÎÏÍÌÍÏÏÏÌÎÎÎÎÏÍÎÌÍÌÏ; // 0x20
        public bool ÍÎÌÌÏÌÏÎÍÎÌÍÎÏÏÎÎÎÎÌÏÎÌ; // 0x28
        public VRC.UI.Core.Styles.StyleElement ÎÏÏÌÍÍÏÎÎÍÌÎÎÏÏÎÍÏÌÏÏÏÎ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB74F4D0
        public void RaiseCancellation(){} // RVA: 0x7FFACB74F5F0
        public void Start(){} // RVA: 0x7FFACB74F600
        public void OnPointerEnter(){} // RVA: 0x7FFACB74F6E0
        public void Invoke(){} // RVA: 0x7FFACB74F5F0
        public void OnEnable(){} // RVA: 0x7FFACB74F6F0
        public void OnDisable(){} // RVA: 0x7FFACB74F830
        public void IsInvoking(){} // RVA: 0x7FFACB74F9A0
        public void StartCoroutine(){} // RVA: 0x7FFACB74FAD0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB74F6E0
        public void OnPointerExit(){} // RVA: 0x7FFACB74F5F0
        public void StopCoroutine(){} // RVA: 0x7FFACB74FBF0
    }

    /// <summary>Originally: ÎÍÍÍÎÏÌÌÌÎÏÌÍÎÍÌÏÍÎÍÏÍÍ</summary>
    public class PointerEnterPointerExitHandler_F24B_F24B : MonoBehaviour
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ labelText; // 0x20
        public UnityEngine.UI.Slider slider; // 0x28
        public ÎÏÍÎÎÌÎÍÌÏÌÌÏÏÌÎÍÎÍÍÏÍÍ sliderDrag; // 0x30
        public ÍÏÏÍÍÎÍÌÎÎÏÍÎÌÎÍÍÏÌÍÎÎÍ sliderPointer; // 0x38
        public ÎÏÏÏÎÎÏÌÏÌÍÌÏÌÎÎÏÏÎÏÎÏÍ ÌÌÏÏÌÌÍÌÎÏÍÏÎÍÍÏÍÍÎÏÏÌÎ; // 0x40
        public float ÎÏÏÎÏÎÎÍÎÌÏÏÌÏÎÍÎÍÌÍÏÎÍ; // 0x48
        public bool ÌÌÌÍÍÌÏÍÍÎÍÎÎÌÏÏÏÌÍÌÏÎÌ; // 0x4C
        public bool ÍÏÍÎÌÏÏÏÎÌÌÌÎÎÌÍÎÏÍÍÏÍÍ; // 0x4D

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC30CD160
        public void RaiseCancellation(){} // RVA: 0x7FFACB8B0210
        public void IsInvoking(){} // RVA: 0x7FFACB8B0480
        public void get_useGUILayout_FC0798F86913_FC0798F86913(){} // RVA: 0x7FFACB8B1080 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Awake(){} // RVA: 0x7FFACB8B07B0
        public void OnDestroy(){} // RVA: 0x7FFACB8B0CB0
        public void Start(){} // RVA: 0x7FFACB8B0CE0
        public void StartCoroutine(){} // RVA: 0x7FFACB8B0CB0
        public void Update(){} // RVA: 0x7FFACB8B0D80
        public void OnPointerEnter(){} // RVA: 0x7FFACB8B0DB0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB8B0DE0
        public void StopCoroutine(){} // RVA: 0x7FFACB8B0E80
        public void OnApplicationPause(){} // RVA: 0x7FFACB8B0F10
        public void OnPointerExit(){} // RVA: 0x7FFACB8B0FB0
        public void StopAllCoroutines(){} // RVA: 0x7FFACB8B0FE0
    }

    /// <summary>Originally: ÎÌÍÏÎÌÎÍÌÍÏÌÌÍÌÏÌÏÏÎÍÏÌ</summary>
    public class PointerEnterPointerExitHandler_F4A8_F4A8 : MonoBehaviour
    {
        public UnityEngine.UI.Button ÍÍÎÏÎÌÎÌÍÌÎÍÍÌÏÍÎÎÏÎÏÌÍ; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.GameObject> ÍÍÍÎÏÏÏÏÌÎÏÍÏÌÍÌÌÏÌÍÌÏÎ; // 0x28
        public ÌÌÍÎÎÌÏÏÏÌÍÍÍÎÏÌÎÍÎÍÏÎÏ ÌÌÏÏÏÌÍÌÌÍÌÎÍÍÎÌÍÌÎÌÏÎÎ; // 0x30
        public bool ÏÌÍÎÍÎÌÍÍÌÍÎÍÏÍÌÏÍÍÎÍÏÌ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB92FFF0
        public void OnDisable(){} // RVA: 0x7FFAC2F2F7C0
        public void .ctor(){} // RVA: 0x7FFACB930000
        public void Initialize(){} // RVA: 0x7FFACB930100
        public void OnPointerEnter(){} // RVA: 0x7FFACB930440
        public void InvokeRepeating(){} // RVA: 0x7FFAC3C4CFE0
        public void CancelInvoke(){} // RVA: 0x7FFACB930440
        public void OnEnable(){} // RVA: 0x7FFACB930450
        public void Awake(){} // RVA: 0x7FFACB930460
        public void OnDestroy(){} // RVA: 0x7FFACB9304F0
        public void StartCoroutine(){} // RVA: 0x7FFACB92FFF0
        public void OnPointerExit(){} // RVA: 0x7FFACB930500
        public void StopCoroutine(){} // RVA: 0x7FFACB930510
        public void LateUpdate(){} // RVA: 0x7FFACB930440
    }

    /// <summary>Originally: ÍÏÎÍÏÌÎÎÏÏÏÎÏÍÍÏÌÏÏÏÍÍÏ</summary>
    public class PointerEnterPointerExitImplImpl_1F12_1F12 : PointerEnterPointerExitImpl_EFE0_EFE0
    {
        public TMPro.TextMeshProUGUI f_8B9; // 0xC0
        public ÌÎÏÍÏÏÌÏÎÍÎÌÏÍÌÎÎÌÌÌÍÌÎ f_245; // 0xC8
        public bool ÌÍÌÍÍÌÎÍÍÍÎÍÌÎÌÍÏÌÌÌÍÌÎ; // 0xD0
        public long ÎÏÌÎÏÏÎÎÏÍÎÌÍÌÌÎÏÌÌÏÌÌÌ; // 0xD8

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFACB9D2320
        public void get_contentList(){} // RVA: 0x7FFAC3540F70
        public void Add(){} // RVA: 0x7FFAC3540F70
        public void Remove(){} // RVA: 0x7FFACB9D23D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFACB9D23E0
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFACB9D2490
        public void Awake_7D1B89A75BE8(){} // RVA: 0x7FFACB9D24A0
        public void ContainsKey(){} // RVA: 0x7FFAC3540F70
        public void get_SendDefaultPii(){} // RVA: 0x7FFAC33CFDE0
        public void get_SendDefaultPii_847EC8E19ED0(){} // RVA: 0x7FFAC33CFDE0
        public void TryGetValue(){} // RVA: 0x7FFACB9D23D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Awake(){} // RVA: 0x7FFACB9D2550
        public void OnDestroy(){} // RVA: 0x7FFACB9D2610
    }

    /// <summary>Originally: ÎÍÌÍÎÏÎÍÌÌÍÌÍÍÎÏÍÍÎÏÎÌÍ</summary>
    public class PointerEnterPointerExitImplImpl_A3CD_A3CD : PointerEnterPointerExitImpl_EFE0_EFE0
    {
        public System.Action`1<bool> f_A78; // 0xC0
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<bool> f_5E7; // 0xC8
        public bool ÏÎÎÎÌÍÌÍÎÏÍÏÎÍÏÏÏÍÎÏÍÍÌ; // 0xD0

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFACBA20820
        public void Updateenabled(){} // RVA: 0x7FFACBA20920
        public void Initialize(){} // RVA: 0x7FFACBA20980
        public void get_disclaimerText(){} // RVA: 0x7FFAC3079460
        public void SetRoundedRectIntParameter(){} // RVA: 0x7FFACBA20A80
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Awake_BD39FAD50DF0(){} // RVA: 0x7FFACBA20AA0
        public void OnDestroy(){} // RVA: 0x7FFACBA20A80
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3079460
        public void StartCoroutine_Auto_0D5CD0D7CBF5(){} // RVA: 0x7FFAC3079460
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA20C50
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFACBA20D50
        public void ProcessAsObject(){} // RVA: 0x7FFACBA20FB0
        public void get_UploadStreamLength(){} // RVA: 0x7FFACBA21210
    }

    /// <summary>Originally: ÎÎÍÌÏÏÎÏÎÌÏÌÏÍÏÏÎÏÏÍÍÍÍ</summary>
    public class PointerEnterPointerExitImplImpl_A9A2_A9A2 : PointerEnterPointerExitImpl_EFE0_EFE0
    {
        public TMPro.TextMeshProUGUI f_8D3; // 0xC0
        public VRC.UI.ImageEx f_7F6; // 0xC8
        public ÌÎÌÌÏÎÏÎÎÏÌÌÎÌÍÌÍÍÍÍÌÍÍ f_F6B; // 0xD0
        public VRC.Localization.LocalizableString f_9F2; // 0xD8
        public UnityEngine.Sprite f_FCF; // 0x100
        public ÍÎÎÏÍÎÍÌÍÎÏÏÍÏÌÏÍÌÌÏÏÍÎ f_2BE; // 0x108
        public ÌÎÏÍÏÏÌÏÎÍÎÌÏÍÌÎÎÌÌÌÍÌÎ f_A55; // 0x110

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFACBA1D9D0
        public void Update(){} // RVA: 0x7FFACBA1D9F0
        public void Initialize_D179815280CD(){} // RVA: 0x7FFACBA1DC20
        public void set_element(){} // RVA: 0x7FFACBA1DC50
        public void SetRoundedRectIntParameter(){} // RVA: 0x7FFACBA1DC80
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFACBA1DCF0
        public void Awake_89457825A395(){} // RVA: 0x7FFACBA1DDF0
        public void OnDestroy(){} // RVA: 0x7FFACBA1DE80
        public void SplitCsvLine(){} // RVA: 0x7FFACBA1DF80
        public void NeedsSync(){} // RVA: 0x7FFACBA1DFA0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA1DFF0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFACBA1E070
        public void ProcessAsObject(){} // RVA: 0x7FFACBA1E0D0
        public void get_UploadStreamLength(){} // RVA: 0x7FFACBA1E0D0
        public void .ctor(){} // RVA: 0x7FFACBA1B200
        public void DoGetPreferredWidth(){} // RVA: 0x7FFACBA1D9D0
        public void BoxValue(){} // RVA: 0x7FFACBA1E140
        public void DoFiles(){} // RVA: 0x7FFACBA1E1A0
        public void DoFiles_AF9A715A1DE0(){} // RVA: 0x7FFACBA1E200
        public void DoFiles_A31DE03CDDD0(){} // RVA: 0x7FFACBA1E230
        public void DoFiles_56356C4A7D5E(){} // RVA: 0x7FFACBA1E2D0
        public void GetFlagAtOffset456(){} // RVA: 0x7FFACBA1E460
        public void OnPointerEnter(){} // RVA: 0x7FFACBA1E560
        public void Internal_Create(){} // RVA: 0x7FFACBA1E5C0
        public void Internal_Create_4B02AA0CB1ED(){} // RVA: 0x7FFACBA1E5F0
        public void FindServiceEntry(){} // RVA: 0x7FFACBA1E6F0
        public void FindServiceEntry_4000E7A4B369(){} // RVA: 0x7FFACBA1E710
        public void Initialize_D4FD9C79C5BD(){} // RVA: 0x7FFACBA1D9D0
        public void OnPointerExit(){} // RVA: 0x7FFACBA1E810
        public void set_DownloadLength(){} // RVA: 0x7FFACBA1E830
        public void set_DownloadLength_9BD631A46DB7(){} // RVA: 0x7FFACBA1E890
        public void InvokeTargetHandler_D65C52C982D6_D65C52C982D6(){} // RVA: 0x7FFACBA1E9C0 | overloaded x2
        public void TryInvokeSlotHandler(){} // RVA: 0x7FFACBA1E9F0
        public void OnPointerClick(){} // RVA: 0x7FFACBA1EB00
        public void GetRoundedRectBorderColor(){} // RVA: 0x7FFACBA1EC10
        public void GetRoundedRectBorderColor_FAFA5D6417F8(){} // RVA: 0x7FFACBA1EC30
        public void Awake(){} // RVA: 0x7FFACBA1EC50
        public void OnPointerDown(){} // RVA: 0x7FFACBA1EE80
        public void OnPointerUp(){} // RVA: 0x7FFACBA1EF80
        public void UpdatePointer(){} // RVA: 0x7FFACBA1EFA0
        public void ProcessPointer(){} // RVA: 0x7FFACBA1F010
        public void GetOrCreateCachedObject(){} // RVA: 0x7FFACBA1F040
        public void SumTopEightValues(){} // RVA: 0x7FFACBA1F1E0
        public void ClearPointer(){} // RVA: 0x7FFACBA1F2B0
    }

    /// <summary>Originally: ÌÏÍÍÌÍÏÌÎÌÏÍÏÏÎÎÍÎÍÏÏÎÏ</summary>
    public class PointerEnterPointerExitImplSibling_04B3_04B3 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFACBA09020
        public void Equals(){} // RVA: 0x7FFACBA09330
        public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void CompareBaseObjects(){} // RVA: 0x7FFAC2E8DC40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2E8DC40
        public void GetCachedPtr(){} // RVA: 0x7FFAC2E8DC40
        public void get_name(){} // RVA: 0x7FFAC2E8DC40
        public void set_name(){} // RVA: 0x7FFAC2E8DC40
        public void ToString_717A0F30DA38_717A0F30DA38(){} // RVA: 0x7FFACBA09390 | overloaded x2
        public void Instantiate(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_66ED46EBBCEA(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_C2740B4D38F5(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_04E7A0CEBDA2(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_34437F159DD8(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_D65C52C982D6(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_93DA317EE2D6(){} // RVA: 0x7FFAC2E8DC40
        public void Destroy(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_20D6EEE4A079(){} // RVA: 0x7FFAC2E8DC40
        public void DestroyImmediate(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_28020EE7E412(){} // RVA: 0x7FFAC2E8DC40
        public void FindObjectsOfType(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo_9F234EDAA53B(){} // RVA: 0x7FFAC2E8DC40
    }

    /// <summary>Originally: ÌÍÍÎÍÌÌÎÏÌÍÍÌÌÍÍÎÎÎÌÎÌÌ</summary>
    public class PointerEnterPointerExitImplSibling_86FA_86FA : LifecycleComponent_C626_C626
    {
        public UnityEngine.UI.Image _radioButtonImage; // 0x88

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFACB7828B0
        public void Initialize_21DA3B7AEB3B(){} // RVA: 0x7FFACB7828B0
        public void Initialize_310C56BBE03B(){} // RVA: 0x7FFACB7828B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void SetObservableList(){} // RVA: 0x7FFACB7828B0
        public void Initialize_27BE28DCDE25(){} // RVA: 0x7FFACB7828B0
        public void Initialize_D65C52C982D6(){} // RVA: 0x7FFACB7828B0
    }

    /// <summary>Originally: ÍÌÍÎÏÎÏÍÏÍÌÎÌÌÏÎÏÌÍÏÌÌÏ</summary>
    public class PointerEnterPointerExitImpl_244B_244B : PointerEnterPointerExit_D99E_D99E
    {
        public System.Action`1<UnityEngine.Sprite> f_9CE; // 0xB0
        public VRC.UI.ImageEx f_32D; // 0xB8
        public ÍÎÎÏÍÎÍÌÍÎÏÏÍÏÌÏÍÌÌÏÏÍÎ f_A51; // 0xC0
        public UnityEngine.Color f_F97; // 0xC8
        public bool ÌÌÌÏÌÏÏÏÌÍÎÏÌÎÎÏÏÎÎÌÌÎÍ; // 0xD8
        public UnityEngine.Color ÍÌÌÏÍÎÏÏÏÍÎÏÌÏÎÎÍÌÏÍÌÏÍ; // 0xDC
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<UnityEngine.Color32> ÌÏÍÎÎÍÍÍÌÎÍÎÏÍÍÏÎÏÏÍÍÏÌ; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA0A0D0
        public void Initialize(){} // RVA: 0x7FFACBA0A1B0
        public void SetFlagByteAtOffset392(){} // RVA: 0x7FFACBA0A2B0
        public void PreparePointerInteraction(){} // RVA: 0x7FFACBA0A470
        public void get_EnableTimoutForStreaming(){} // RVA: 0x7FFAC3DBD9E0
        public void ComputeverticalNormalizedPosition(){} // RVA: 0x7FFACBA0A4A0
        public void InitializeLayoutContext(){} // RVA: 0x7FFACBA0A5A0
        public void FixedUpdate(){} // RVA: 0x7FFACBA0A6A0
        public void GetLanguage(){} // RVA: 0x7FFACBA0A710
        public void NeedsSync(){} // RVA: 0x7FFACBA0A960
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA0AA60
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFACBA0AA80
        public void OnDestroy(){} // RVA: 0x7FFACBA0B260 | overloaded x5
        public void OnBecameInvisible(){} // RVA: 0x7FFACBA0ABC0
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFACBA0ABD0
        public void OnDrag(){} // RVA: 0x7FFACBA0ACD0
        public void OnCollisionExit(){} // RVA: 0x7FFACBA0ABC0
        public void Initialize_5FB2E4F4F619(){} // RVA: 0x7FFACBA0AD60
        public void get_SubmitButtonText(){} // RVA: 0x7FFACBA0AD90
        public void get_lastBoneRotations(){} // RVA: 0x7FFACBA0ADC0
        public void OnPointerEnter(){} // RVA: 0x7FFACBA0AE00
        public void Awake(){} // RVA: 0x7FFACBA0AE30
        public void NormalizePriority(){} // RVA: 0x7FFACBA0B110
        public void get_gameObject(){} // RVA: 0x7FFACBA0B250
        public void OnPointerExit(){} // RVA: 0x7FFACBA0B250
    }

    /// <summary>Originally: ÍÎÎÏÍÎÍÌÍÎÏÏÍÏÌÏÍÌÌÏÏÍÎ</summary>
    public class PointerEnterPointerExitImpl_24Sibling_8B9E : Object
    {
        public System.Action`1<UnityEngine.Sprite> _name; // 0x10
        public VRC.UI.ImageEx _hideFlags; // 0x18
        public VRC.UI.Core.Styles.StyleElement ÍÌÏÍÎÏÌÏÎÏÍÍÎÌÎÌÌÎÍÎÌÏÍ; // 0x20
        public UnityEngine.Sprite ÎÍÍÍÏÏÎÎÌÍÏÎÌÎÌÌÎÍÎÏÍÌÍ; // 0x28
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> ÏÌÌÎÌÎÎÌÍÍÎÎÍÎÎÍÎÎÍÏÌÏÏ; // 0x30
        public string ÎÎÏÏÌÏÍÎÍÎÍÏÎÌÎÎÏÏÌÎÎÍÌ; // 0x38
        public UnityEngine.Sprite ÌÌÌÎÎÌÍÏÌÏÏÎÏÌÎÌÍÌÍÏÌÎÏ; // 0x40
        public UnityEngine.Sprite ÏÌÎÍÏÍÍÎÍÍÏÎÍÍÎÍÏÌÌÎÍÌÍ; // 0x48
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<UnityEngine.Texture2D> ÎÌÌÎÏÌÍÌÏÎÍÏÌÍÏÏÍÌÎÎÌÍÍ; // 0x50
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<UnityEngine.Sprite> ÎÎÏÍÍÍÏÌÎÎÍÎÏÍÏÍÏÌÏÌÏÎÌ; // 0x58

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFACBA05BE0
        public void Equals(){} // RVA: 0x7FFACBA05BF0
        public void GetHashCode(){} // RVA: 0x7FFACBA05D80
        public void op_Implicit(){} // RVA: 0x7FFACBA06120
        public void CompareBaseObjects(){} // RVA: 0x7FFACBA070B0 | overloaded x4
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2F9E740
        public void get_name(){} // RVA: 0x7FFACBA06560
        public void set_name(){} // RVA: 0x7FFACBA065C0
        public void Instantiate(){} // RVA: 0x7FFACBA066D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFACBA06A50
        public void ToString(){} // RVA: 0x7FFACBA06BC0
        public void Destroy(){} // RVA: 0x7FFACBA05BE0
        public void DestroyImmediate(){} // RVA: 0x7FFACBA07A10
        public void FindObjectsOfType(){} // RVA: 0x7FFACBA07CA0
        public void FindObjectsByType(){} // RVA: 0x7FFACBA07FD0
        // ── Unresolved (hash) ──
        public void m_374(){} // RVA: 0x7FFACBA06F60
        public void m_59F(){} // RVA: 0x7FFACBA06F70
        public void m_402(){} // RVA: 0x7FFACBA07430
        public void m_3C7(){} // RVA: 0x7FFACBA076F0
        public void m_063(){} // RVA: 0x7FFACBA07700
        public void m_563(){} // RVA: 0x7FFACBA07B10
        public void m_FAF(){} // RVA: 0x7FFAC2F9E740
        public void m_157(){} // RVA: 0x7FFACBA080D0
    }

    /// <summary>Originally: ÍÍÍÍÍÎÌÍÍÌÌÏÎÎÍÎÌÏÎÎÎÎÎ</summary>
    public class PointerEnterPointerExitImpl_AF7A_AF7A : PointerEnterPointerExit_D99E_D99E
    {
        public ÌÎÏÍÏÏÌÏÎÍÎÌÏÍÌÎÎÌÌÌÍÌÎ f_623; // 0xB0
        public VRC.Localization.LocalizableString f_6F4; // 0xB8
        public UnityEngine.Color f_3D7; // 0xE0
        public float f_F4F; // 0xF0
        public 0x6B279650 f_B84; // 0xF4
        public 0x6B2796A8 f_C95; // 0xF8
        public 0x6B27A0F8 _designClass; // 0xFC
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<VRC.Localization.LocalizableString> ÎÎÎÍÍÎÍÎÏÌÌÍÍÌÏÎÌÌÍÌÍÌÍ; // 0x100

        // ── Methods ──
        public void AccumulateIndexSeven_5715D383DCA8_5715D383DCA8(){} // RVA: 0x7FFACBA1FC10 | overloaded x2
        public void get_gameObject(){} // RVA: 0x7FFACBA1F560
        public void GetBufferedTimes(){} // RVA: 0x7FFACBA1F5D0
        public void ProcessPointerEventWithPurchaseStateCheck(){} // RVA: 0x7FFACBA1F630
        public void GetSessionId(){} // RVA: 0x7FFACBA1F700
        public void ComputeverticalNormalizedPosition(){} // RVA: 0x7FFACBA1F720
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACBA1F830
        public void GetLanguage(){} // RVA: 0x7FFACBA1F890
        public void NeedsSync(){} // RVA: 0x7FFACBA1F960
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA1FA30
        public void get_displayIndex(){} // RVA: 0x7FFAC3C8BB20
        public void ClampMagnitude(){} // RVA: 0x7FFACBA1FAC0
        public void OnBecameInvisible(){} // RVA: 0x7FFACBA1FB30
        public void SetOverlay(){} // RVA: 0x7FFACBA1FB90
        public void get_displayIndex_EFF2CEAA153C(){} // RVA: 0x7FFAC3C8BB20
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFACBA1FCB0
        public void Initialize_0B8F13E7CCD3(){} // RVA: 0x7FFACBA1FD10
        public void get_SubmitButtonText(){} // RVA: 0x7FFACBA1FF80
        public void GetDataCount(){} // RVA: 0x7FFACBA20090
        public void OnPointerEnter(){} // RVA: 0x7FFACBA200F0
        public void Awake(){} // RVA: 0x7FFACBA20160
        public void OnDestroy(){} // RVA: 0x7FFACBA204E0
        public void Update(){} // RVA: 0x7FFACBA204F0
        public void SecureStringToBSTR(){} // RVA: 0x7FFACBA20550
        public void get_gameObject_14A877124FCB(){} // RVA: 0x7FFACBA205B0
        public void OnDestroy_00C8F7ED7085(){} // RVA: 0x7FFACBA206E0
        public void BuildException(){} // RVA: 0x7FFACBA20740
        public void GetCachedType(){} // RVA: 0x7FFACBA207C0
    }

    /// <summary>Originally: ÎÏÎÎÍÏÏÏÍÌÏÍÍÎÍÌÌÍÎÏÏÌÎ</summary>
    public class PointerEnterPointerExitImpl_EA8F_EA8F : PointerEnterPointerExit_D99E_D99E
    {
        public UnityEngine.UI.Toggle _eA8F; // 0xB0

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFACB9D2680
        public void Awake(){} // RVA: 0x7FFACB9D26B0
        public void GetBufferedTimes(){} // RVA: 0x7FFACB9D2680
        public void OnDestroy_6874A31E053E(){} // RVA: 0x7FFACB9D2680
        public void OnDestroy_AC05B169B2C8(){} // RVA: 0x7FFACB9D2680
        public void OnDestroy_C23D2522824A(){} // RVA: 0x7FFACB9D2680
        public void OnDestroy_D941405088B1(){} // RVA: 0x7FFACB9D2680
        public void FixedUpdate(){} // RVA: 0x7FFACB9D2750
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACB9D2780
        public void NeedsSync(){} // RVA: 0x7FFACB9D2750
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÎÎÏÏÏÌÌÎÍÍÌÎÎÌÍÏÌÌÏÌÎÌÏ</summary>
    public class PointerEnterPointerExitImpl_EFE0_EFE0 : PointerEnterPointerExit_D99E_D99E
    {
        public System.Action ÍÍÌÏÌÌÎÎÎÍÎÍÏÎÌÎÌÌÏÎÌÎÍ; // 0xB0
        public UnityEngine.UI.Button ÎÌÏÏÏÍÌÎÏÏÎÎÍÏÌÌÍÍÏÏÏÏÎ; // 0xB8

        // ── Methods ──
        public void Awake_9B89F468F7D2(){} // RVA: 0x7FFACBA095E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACBA09600
        public void set_element(){} // RVA: 0x7FFACBA096F0
        public void SetRoundedRectIntParameter(){} // RVA: 0x7FFACBA09710
        public void remove_CustomCertificationValidator(){} // RVA: 0x7FFACBA09800
        public void Awake(){} // RVA: 0x7FFACBA098F0
        public void OnDestroy(){} // RVA: 0x7FFACBA09A10
        public void SplitCsvLine(){} // RVA: 0x7FFACBA09B00
        public void NeedsSync(){} // RVA: 0x7FFACBA096F0
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFACBA09B90
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFACBA09C80
        public void ProcessAsObject(){} // RVA: 0x7FFACBA09CE0
        public void get_UploadStreamLength(){} // RVA: 0x7FFACBA09DC0
        public void SetOverlay(){} // RVA: 0x7FFACBA09ED0
        public void DoGetPreferredWidth(){} // RVA: 0x7FFACBA09FC0
    }

    /// <summary>Originally: ÌÏÍÎÍÌÍÏÍÏÌÎÏÍÎÌÏÏÍÏÌÍÌ</summary>
    public class PointerEnterPointerExit_1983_1983 : UIRectTransformDimensionsChBeforeTransform_C3EE
    {
        public UnityEngine.Events.UnityAction ÌÍÎÍÌÏÎÎÍÍÍÎÍÎÌÌÏÌÍÏÏÍÌ; // 0xD0
        public UnityEngine.Events.UnityAction ÏÎÎÌÌÍÏÌÎÍÍÌÏÍÎÎÏÍÎÌÌÎÏ; // 0xD8
        public UnityEngine.Events.UnityAction ÌÏÌÍÎÏÏÏÌÌÍÎÍÌÏÏÎÎÎÏÌÌÍ; // 0xE0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _worldName; // 0xE8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _userCount; // 0xF0
        public UnityEngine.GameObject _iconFriendCount; // 0xF8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ _friendCount; // 0x100
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ _thumbnailImage; // 0x108
        public UnityEngine.GameObject _contentWarningBanner; // 0x110
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _toolTip; // 0x118
        public UnityEngine.GameObject _attributeIconFavorite; // 0x120
        public UnityEngine.GameObject _attributeIconCommunityLabs; // 0x128
        public UnityEngine.UI.Button _worldButton; // 0x130
        public UnityEngine.RectTransform _preloadProgressBarContainer; // 0x138
        public ÎÏÎÍÍÌÏÏÌÌÌÏÎÏÍÌÏÌÏÏÎÏÌ _preloadProgressBar; // 0x140
        public UnityEngine.GameObject _hoverContainer; // 0x148
        public UnityEngine.UI.Button _joinButton; // 0x150
        public UnityEngine.UI.Button _favoriteButton; // 0x158
        public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ _favoriteButtonToolTip; // 0x160
        public UnityEngine.GameObject _favoriteIcon; // 0x168
        public UnityEngine.GameObject _unfavoriteIcon; // 0x170

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFACB9E1560
        public void AttachRectTransformDimensionsBody(){} // RVA: 0x7FFACB9E16D0
        public void OnPointerExit(){} // RVA: 0x7FFACB9E17F0
        public void AddLinkInternal(){} // RVA: 0x7FFACB9E1890
        public void AddLinkInternal_Injected(){} // RVA: 0x7FFACB9E18B0
        public void AddLinkInternal_49F7AF316E91(){} // RVA: 0x7FFACB9E18D0
        public void AddLinkInternal_8C453F11D501(){} // RVA: 0x7FFACB9E1890
        public void get_Current(){} // RVA: 0x7FFACB9E19C0
        public void OnPointerEnter(){} // RVA: 0x7FFACB9E1AB0
        public void Dispose(){} // RVA: 0x7FFACB9E1B50
        public void OnPointerEnter_4A712748B652(){} // RVA: 0x7FFACB9E1C40
        public void Initialize(){} // RVA: 0x7FFACB9E0C90
        public void Initialize_7C64FC6D86A2(){} // RVA: 0x7FFACB9E0C90
        public void OnPointerExit_C138DED3C615(){} // RVA: 0x7FFACB9E1EA0
        public void Update(){} // RVA: 0x7FFACB9E1F90
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACB9E2080
        public void Start(){} // RVA: 0x7FFACB9E2200
        public void Serialize(){} // RVA: 0x7FFACB9E22F0
        public void Awake(){} // RVA: 0x7FFACB9E2320
        public void HandlePointerHover(){} // RVA: 0x7FFACB9E2580
        public void .ctor(){} // RVA: 0x7FFACB9E2670
        public void OnDestroy(){} // RVA: 0x7FFACB9E26B0
        public void MultiplyAssign(){} // RVA: 0x7FFACB9E2830
    }

    /// <summary>Originally: ÍÍÍÍÎÎÍÌÍÎÍÍÍÍÍÎÌÏÎÍÏÍÍ</summary>
    public class PointerEnterPointerExit_947C_947C : BaseClass20ImplImpl_FC62_FC62
    {
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ nameDisplay; // 0x38
        public UnityEngine.UI.Image highlightDisplay; // 0x40
        public UnityEngine.UI.Image iconDisplay; // 0x48
        public UnityEngine.UI.Image buttonsDisplay; // 0x50
        public UnityEngine.UI.Image backgroundDisplay; // 0x58
        public UnityEngine.UI.Image textDisplay; // 0x60
        public UnityEngine.UI.Image subtextDisplay; // 0x68
        public ÎÌÌÎÏÍÎÎÏÌÍÍÌÏÏÎÎÎÎÍÍÌÍ selectionBinding; // 0x70
        public ÏÍÎÌÌÏÎÍÎÏÎÌÏÍÏÌÎÌÌÏÍÎÎ hoverTarget; // 0x78
        public ÍÎÍÌÍÏÏÍÌÎÍÎÌÏÌÏÏÍÎÎÌÎÌ shareButton; // 0x80

        // ── Methods ──
        public void GetFaceInfo_Internal(){} // RVA: 0x7FFACB2B14A0
        public void CreatePointerMenuItem(){} // RVA: 0x7FFACB2B1540
        public void OnPointerEnter_2D090B080C92(){} // RVA: 0x7FFACB2B17E0
        public void SetGameObjectActive(){} // RVA: 0x7FFACB2B1D00
        public void OnPointerExit_F9728E574BF9(){} // RVA: 0x7FFACB2B1DA0
        public void Export(){} // RVA: 0x7FFACB2B1E40
        public void UpdatePointerState(){} // RVA: 0x7FFACB2B1EE0
        public void GetPointerHoverAlpha(){} // RVA: 0x7FFACB2B1F80
        public void UpdateCanProcess(){} // RVA: 0x7FFACB2B2020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACB2B21F0
        public void set_enabled(){} // RVA: 0x7FFACB2B2440
        public void GetUnityEngine(){} // RVA: 0x7FFACB2B24E0
        public void UpdatePointerHoverAlpha(){} // RVA: 0x7FFACB2B2580
        public void SetPointerHoverEnabled(){} // RVA: 0x7FFACB2B2620
        public void MoveNext(){} // RVA: 0x7FFACB2B2970
        public void SetPointerMenuActive(){} // RVA: 0x7FFACB2B2A10
        public void InitializePointerHover(){} // RVA: 0x7FFACB2B2AE0
        public void FadeInPointerHover(){} // RVA: 0x7FFACB2B2B80
        public void OnPointerExit(){} // RVA: 0x7FFACB2B2C20
        public void .ctor(){} // RVA: 0x7FFACB2B2CB0
        public void Initialize(){} // RVA: 0x7FFACB2B2D20
        public void OnPointerEnter(){} // RVA: 0x7FFACB2B2DC0
        public void FadePointerHoverCanvas(){} // RVA: 0x7FFACB2B2E60
    }

    /// <summary>Originally: ÌÎÍÎÏÎÏÏÏÍÍÎÏÏÍÎÌÍÎÎÎÎÎ</summary>
    public class PointerEnterUpdateMessageHandler_A154_A154 : MonoBehaviour
    {
        public UnityEngine.UI.Toggle ÏÍÍÍÏÍÎÌÎÍÎÍÎÍÌÏÍÌÌÍÎÎÌ; // 0x20
        public UnityEngine.UI.Button ÎÌÍÎÍÏÌÍÌÌÍÍÎÍÍÏÌÍÏÎÏÏÌ; // 0x28
        public bool ÍÏÏÍÍÎÎÏÌÍÌÏÏÌÏÍÏÌÌÌÎÏÍ; // 0x30
        public UnityEngine.GameObject ÏÍÌÌÌÍÌÍÏÎÌÏÍÌÎÌÌÏÌÎÍÏÎ; // 0x38
        public ÍÍÏÏÏÌÎÎÌÌÍÌÎÍÍÌÎÍÏÍÎÌÌ _inputField; // 0x40
        public UnityEngine.UI.Button ÎÌÏÏÏÍÌÎÏÏÎÎÍÏÌÌÍÍÏÏÏÏÎ; // 0x48
        public ÎÍÍÌÌÌÌÍÏÍÏÎÌÏÌÎÎÌÍÍÍÍÍ ÏÎÏÎÏÌÍÏÏÏÎÍÏÍÎÎÌÍÌÌÌÏÍ; // 0x50
        public ÏÌÍÌÍÍÍÌÌÎÍÍÏÏÍÌÌÏÏÌÍÍÎ ÏÏÎÍÏÌÍÍÏÏÌÍÍÍÌÎÎÎÌÌÍÌÌ; // 0x58
        public int ÏÎÏÍÏÎÍÍÏÎÏÍÎÏÎÍÏÏÎÎÏÏÏ; // 0x60
        public bool ÏÌÍÎÍÎÌÍÍÌÍÎÍÏÍÌÏÍÍÎÍÏÌ; // 0x64

        // ── Methods ──
        public void UpdateMessage(){} // RVA: 0x7FFACB884660
        public void RaiseCancellation(){} // RVA: 0x7FFACB8847A0
        public void IsInvoking(){} // RVA: 0x7FFACB884800
        public void CancelInvoke(){} // RVA: 0x7FFACB884BE0
        public void Invoke(){} // RVA: 0x7FFACB884F90
        public void Start(){} // RVA: 0x7FFACB885100
        public void OnEnable(){} // RVA: 0x7FFACB885110
        public void Update(){} // RVA: 0x7FFACB885280
        public void OnDisable(){} // RVA: 0x7FFACB885480
        public void StartCoroutine(){} // RVA: 0x7FFACB8847A0
        public void OnDestroy(){} // RVA: 0x7FFACB885100
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB885530
        public void StopCoroutine(){} // RVA: 0x7FFACB885810
        public void OnPointerEnter(){} // RVA: 0x7FFACB8858A0
        public void OnBecameInvisible(){} // RVA: 0x7FFACB8858B0
        public void StopAllCoroutines(){} // RVA: 0x7FFACB8859D0
        public void get_useGUILayout(){} // RVA: 0x7FFACB885BF0
        public void set_useGUILayout(){} // RVA: 0x7FFACB885D20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnPointerExit(){} // RVA: 0x7FFACB886040
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFACB886050
        public void Awake(){} // RVA: 0x7FFACB886220
        public void OnTriggerExit(){} // RVA: 0x7FFACB8864C0
        public void OnPointerExit_7275143A221A(){} // RVA: 0x7FFACB886040
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFACB886760
        public void StartCoroutineManaged(){} // RVA: 0x7FFACB886910
        public void StartCoroutineManaged2(){} // RVA: 0x7FFACB886CC0
        public void StopCoroutineManaged(){} // RVA: 0x7FFACB886E50
    }

    /// <summary>Originally: ÍÌÎÌÏÍÌÎÍÏÏÌÍÎÌÏÌÍÍÌÌÏÏ</summary>
    public class PointerExitPointerDown_E559_E559 : PlayercontrolPathInternal_23AE_23AE
    {
        public int ÌÎÎÌÌÎÏÍÎÌÏÏÏÍÍÎÍÌÌÍÌÌÌ;
        public System.Threading.CancellationTokenSource ÏÏÍÍÍÌÏÍÌÌÏÌÍÌÏÏÌÌÏÍÏÌÌ; // 0x58
        public bool ÎÌÍÍÏÎÏÏÎÏÎÎÍÍÎÏÌÎÏÍÎÍÏ; // 0x60
        public System.Action ÏÍÎÌÏÌÎÌÏÍÌÎÍÌÎÏÍÏÌÌÍÎÌ; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC42940A0
        public void Initialize(){} // RVA: 0x7FFAC42940F0
        public void OnPointerExit(){} // RVA: 0x7FFAC42942A0
        public void IsResource(){} // RVA: 0x7FFAC4294310
        public void OnDestroy_EEF0D1314C9C(){} // RVA: 0x7FFAC42944C0
        public void OnDestroy(){} // RVA: 0x7FFAC42944C0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC42944E0
        public void OnPointerDown(){} // RVA: 0x7FFAC4294690
        public void OnDestroy_7B7E6EFB5EC0(){} // RVA: 0x7FFAC42944C0
        public void Equals(){} // RVA: 0x7FFAC4294790
        public void OnDisable(){} // RVA: 0x7FFAC4294940
        public void OnPointerUp(){} // RVA: 0x7FFAC4294AF0
        public void OnDestroy_5C38AF16EC82(){} // RVA: 0x7FFAC42944C0
    }

    /// <summary>Originally: ÎÎÌÎÎÌÏÎÍÎÏÌÏÌÏÏÎÌÌÎÏÏÏ</summary>
    public class PointerInitializePotentialDragBeginDragHandler_F0B5_F0B5 : MonoBehaviour
    {
        public UnityEngine.RectTransform ÏÍÏÌÏÏÎÎÍÎÎÌÌÎÌÌÌÏÌÎÏÌÏ; // 0x20
        public UnityEngine.RectTransform ÎÏÏÏÎÍÏÌÏÏÏÏÎÎÍÎÌÌÌÏÏÍÎ; // 0x28
        public UnityEngine.RectTransform ÎÌÍÍÌÍÎÍÎÌÏÏÍÌÍÍÍÎÍÏÎÌÎ; // 0x30
        public UnityEngine.RectTransform ÎÏÍÍÎÍÎÎÍÌÌÌÏÏÎÍÏÌÏÍÎÏÌ; // 0x38
        public UnityEngine.GameObject ÌÌÎÎÍÏÏÌÌÌÎÌÎÎÌÏÌÌÎÍÏÏÌ; // 0x40
        public UnityEngine.GameObject ÏÌÍÍÌÌÏÎÏÌÍÌÍÍÎÌÏÍÍÍÍÌÍ; // 0x48
        public UnityEngine.GameObject ÍÏÍÎÌÏÎÌÌÌÏÍÍÍÌÎÎÍÍÎÌÌÏ; // 0x50
        public UnityEngine.GameObject ÏÎÍÍÎÏÍÌÎÏÍÍÌÍÎÍÍÍÍÏÍÏÍ; // 0x58
        public UnityEngine.UI.RawImage ÍÎÏÍÏÍÎÏÎÌÏÎÌÏÍÏÎÌÎÍÎÍÍ; // 0x60
        public UnityEngine.Material ÍÏÏÎÏÍÏÏÎÍÍÏÎÍÏÏÍÍÎÏÍÎÌ; // 0x68
        public UnityEngine.UI.Slider ÍÍÍÌÍÎÎÏÎÏÍÎÎÌÏÌÍÌÌÌÍÎÏ; // 0x70
        public UnityEngine.UI.Button ÏÌÌÏÏÏÍÏÏÏÌÏÎÎÎÎÏÍÎÍÏÎÌ; // 0x78
        public UnityEngine.Vector2 ÎÌÌÌÎÌÎÎÍÎÌÏÍÎÍÏÎÏÎÎÎÍÎ; // 0x80
        public bool ÌÍÍÍÏÍÎÏÍÌÌÎÎÎÏÎÍÍÌÏÏÏÎ; // 0x88
        public UnityEngine.Rect ÎÍÌÌÎÏÏÎÍÏÌÍÎÎÌÎÎÍÌÎÎÎÏ; // 0x8C

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC373FDB0
        public void RaiseCancellation(){} // RVA: 0x7FFAC373FDB0
        public void IsInvoking(){} // RVA: 0x7FFAC373FDB0
        public void Start(){} // RVA: 0x7FFAC373FDC0
        public void Invoke(){} // RVA: 0x7FFAC373FEE0
        public void InvokeRepeating(){} // RVA: 0x7FFAC373FF00
        public void CancelInvoke(){} // RVA: 0x7FFAC3740750
        public void OnDrag(){} // RVA: 0x7FFAC3740CB0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC371D9D0
        public void StartCoroutine(){} // RVA: 0x7FFAC3740EE0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3740FB0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEndDrag(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutine(){} // RVA: 0x7FFAC3741110
        public void OnBeginDrag(){} // RVA: 0x7FFAC3741910
        public void get_useGUILayout(){} // RVA: 0x7FFAC3741B40
        public void set_useGUILayout(){} // RVA: 0x7FFAC3741B50
        public void print(){} // RVA: 0x7FFAC3741D80
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC37421B0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC37421D0
        public void InvokeDelayed(){} // RVA: 0x7FFAC3742370
        public void get_useGUILayout_0A73A7041177(){} // RVA: 0x7FFAC3741B40
    }

    /// <summary>Originally: ÍÍÏÎÌÌÏÌÌÍÍÍÍÎÌÍÏÏÎÎÏÎÍ</summary>
    public class PointerInitializePotentialDragBeginDragHandler_F5D8 : MonoBehaviour
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void CancelInvoke(){} // RVA: 0x7FFAC2F21310
        public void Invoke(){} // RVA: 0x7FFAC2F21310
        public void InvokeRepeating(){} // RVA: 0x7FFAC2F21310
        public void CancelInvoke_F9D607C5F1B8(){} // RVA: 0x7FFAC2F21310
        public void IsInvoking(){} // RVA: 0x7FFAC2F21310
        public void OnDrag(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine(){} // RVA: 0x7FFAC2F21310
        public void OnBeginDrag(){} // RVA: 0x7FFAC2F21310
        public void OnEndDrag(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÏÌÎÌÍÎÍÎÎÍÌÏÌÌÌÏÍÍÍÍÌÍ</summary>
    public class PointerInitializePotentialDragBeginDrag_3B21_3B21 : ScrollRect
    {
        public float _content;
        public string _horizontal; // 0x130
        public bool ÎÌÍÍÏÍÌÏÌÏÎÍÎÎÍÎÍÌÍÏÎÏÎ; // 0x138
        public float minimumSpeed; // 0x13C
        public bool _allowPropagationToParent; // 0x140
        public uint _framesDelayForSet; // 0x144
        public bool _autoClampScroll; // 0x148
        public bool ÎÌÎÏÍÌÍÎÏÌÌÍÌÏÌÍÎÌÏÍÍÎÌ; // 0x149
        public bool ÌÎÌÍÍÍÍÏÏÍÏÍÎÏÏÏÎÌÎÍÍÌÎ; // 0x14A
        public bool ÎÏÌÌÍÍÌÏÎÌÌÏÏÌÏÌÌÏÎÏÎÍÍ; // 0x14B
        public bool ÍÎÌÎÎÎÌÌÎÍÎÌÏÍÌÌÎÏÎÍÍÍÎ; // 0x14C
        public UnityEngine.CanvasGroup ÎÏÍÌÏÍÌÍÌÍÌÍÏÌÍÎÍÌÌÍÌÍÍ; // 0x150
        public DG.Tweening.Tween ÏÎÏÏÎÎÎÎÏÎÍÎÏÌÎÌÎÎÏÌÎÍÎ; // 0x158
        public System.Collections.Generic.Dictionary`2<object,float> ÍÍÏÎÌÌÏÍÍÎÍÏÏÌÎÌÏÍÎÌÎÍÎ; // 0x160
        public object ÌÍÍÍÏÌÌÌÍÌÍÌÍÍÏÎÌÍÍÎÎÍÌ; // 0x168
        public System.Threading.CancellationTokenSource ÏÏÍÍÍÌÏÍÌÌÏÌÍÌÏÏÌÌÏÍÏÌÌ; // 0x170
        public 0x6B24ACB8 ÎÍÌÎÏÎÌÎÎÏÍÏÍÌÏÌÍÏÏÎÏÍÏ; // 0x178
        public float ÌÍÏÏÌÎÏÍÎÍÌÌÏÏÍÌÎÌÏÌÎÎÏ;
        public float ÌÌÌÍÏÌÏÏÎÏÌÏÎÎÍÍÌÏÍÍÍÏÌ;
        public float ÌÍÎÌÍÍÌÏÏÌÎÍÍÌÎÌÎÍÎÌÍÌÌ; // 0x17C

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void LateUpdate(){} // RVA: 0x7FFACB816370
        public void OnBeginDrag(){} // RVA: 0x7FFACB816560
        public void set_horizontal(){} // RVA: 0x7FFACB816740
        public void SetForm(){} // RVA: 0x7FFAC39A80B0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFACB8167D0
        public void get_movementType(){} // RVA: 0x7FFACB8169E0
        public void set_movementType(){} // RVA: 0x7FFACB816B70
        public void get_elasticity(){} // RVA: 0x7FFACB816C20
        public void set_elasticity(){} // RVA: 0x7FFAC39A80B0
        public void OnScroll(){} // RVA: 0x7FFACB816CD0
        public void set_inertia(){} // RVA: 0x7FFACB816F90
        public void GetSource(){} // RVA: 0x7FFAC3544340
        public void set_decelerationRate(){} // RVA: 0x7FFACB817240
        public void get_scrollSensitivity(){} // RVA: 0x7FFACB8173D0
        public void set_scrollSensitivity(){} // RVA: 0x7FFACB817460
        public void get_normalizedPosition(){} // RVA: 0x7FFAC9C60A40
        public void get_Transform(){} // RVA: 0x7FFAC33BCDF0
        public void Start(){} // RVA: 0x7FFACB817470
        public void set_horizontalScrollbar(){} // RVA: 0x7FFACB817860
        public void get_verticalScrollbar(){} // RVA: 0x7FFACB8178C0
        public void set_verticalScrollbar(){} // RVA: 0x7FFACB817460
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x7FFAC33BCDF0
        public void OnDrag(){} // RVA: 0x7FFACB8178D0
        public void SetVerticalNormalizedPosition(){} // RVA: 0x7FFAC9C60D30
        public void .ctor(){} // RVA: 0x7FFACB817B70
        public void Initialize(){} // RVA: 0x7FFAC33BCDF0
        public void OnEndDrag(){} // RVA: 0x7FFACB817C60
        public void get_verticalScrollbarSpacing(){} // RVA: 0x7FFACB817E10
        public void set_verticalScrollbarSpacing(){} // RVA: 0x7FFACB817F40
        public void set_normalizedPosition(){} // RVA: 0x7FFAC9C60A80
        public void set_onValueChanged(){} // RVA: 0x7FFAC9C60D30
        public void get_viewRect(){} // RVA: 0x7FFACB818070
        public void get_velocity(){} // RVA: 0x7FFAC33BD180
        public void set_velocity(){} // RVA: 0x7FFACB818130
    }

    /// <summary>Originally: ÏÌÍÏÍÎÌÍÌÌÎÏÎÎÍÌÏÌÏÍÌÎÍ</summary>
    public class PointerInitializePotentialDragBeginDrag_5680_5680 : ScrollRect
    {
        public float minimumSpeed; // 0x130
        public bool _allowPropagationToParent; // 0x134
        public bool ÎÌÎÏÍÌÍÎÏÌÌÍÌÏÌÍÎÌÏÍÍÎÌ; // 0x135
        public bool ÌÎÌÍÍÍÍÏÏÍÏÍÎÏÏÏÎÌÎÍÍÌÎ; // 0x136
        public bool ÎÏÌÌÍÍÌÏÎÌÌÏÏÌÏÌÌÏÎÏÎÍÍ; // 0x137

        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFACBA12150
        public void OnEndDrag(){} // RVA: 0x7FFACBA122F0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFACBA124A0
        public void .ctor(){} // RVA: 0x7FFACBA126B0
        public void OnBeginDrag(){} // RVA: 0x7FFACBA126D0
        public void Start(){} // RVA: 0x7FFACBA12980
        public void LateUpdate(){} // RVA: 0x7FFACBA12B90
    }

    /// <summary>Originally: ÏÌÌÍÌÏÌÎÍÏÎÌÎÌÌÌÏÎÏÎÌÍÌ</summary>
    public class PointerInitializePotentialDragBeginDrag_ED1A_ED1A : ScrollRect
    {
        public bool ÏÌÎÌÌÍÍÌÎÎÎÌÎÏÏÏÍÎÎÍÏÏÌ; // 0x130
        public float minimumSpeed; // 0x134

        // ── Methods ──
        public void get_content(){} // RVA: 0x7FFAC2C70A40
        public void OnScroll(){} // RVA: 0x7FFAC42C87C0
        public void OnEndDrag(){} // RVA: 0x7FFAC42C89F0
        public void OnDrag(){} // RVA: 0x7FFAC42C8B40
        public void LateUpdate(){} // RVA: 0x7FFAC42C8C90
        public void OnBeginDrag(){} // RVA: 0x7FFAC42C8CF0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC42C8F00
        public void .ctor(){} // RVA: 0x7FFAC42C9080
    }

    /// <summary>Originally: ÍÍÍÍÏÍÌÌÏÍÌÌÏÏÌÍÎÍÏÌÎÍÌ</summary>
    public class PointerInitializePotentialDragnormalizedValue_75CF_75CF
    {
        public object _value;
        public object _normalizedValue;
        public object f_FBA;

        // ── Methods ──
        public void Select(){} // RVA: 0x7FFAC2C70980
        public void get_value(){} // RVA: 0x7FFAC2C6D880
        public void set_value(){} // RVA: 0x7FFAC2C7E480
        public void get_normalizedValue(){} // RVA: 0x7FFAC2C6D880
        public void set_normalizedValue(){} // RVA: 0x7FFAC2C7E480
        public void OnDrag(){} // RVA: 0x7FFAC2C70A40
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC2C70A40
        public void GetLast(){} // RVA: 0x7FFAC2C58E90
    }

    /// <summary>Originally: ÎÏÍÎÌÌÎÏÍÎÌÌÏÌÎÌÏÏÎÏÏÏÏ</summary>
    public class PointerPreCullHandlerImpl_1756_1756 : PointerPreCullHandler_2B6A_2B6A
    {
        public UnityEngine.Transform _1756; // 0x48
        public UnityEngine.Transform ÏÍÏÌÎÎÎÏÌÌÏÌÎÌÏÌÌÏÍÍÍÏÏ; // 0x50
        public UnityEngine.Vector3 ÌÏÍÎÏÎÍÏÍÌÏÌÎÍÎÌÌÌÏÎÍÏÏ; // 0x58
        public bool ÍÌÎÎÌÎÎÌÎÍÎÎÎÏÏÍÍÏÏÎÌÎÏ; // 0x64

        // ── Methods ──
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3F44E90
        public void Start(){} // RVA: 0x7FFAC3F44F10
        public void Create(){} // RVA: 0x7FFAC3F44FD0
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFAC3F45170
        public void SetCullingParameters(){} // RVA: 0x7FFAC3F45240
        public void InvokeRepeating(){} // RVA: 0x7FFAC3F45400
        public void OnDisable(){} // RVA: 0x7FFAC3F455C0
        public void SetSyncedFloatFieldAt120(){} // RVA: 0x7FFAC3F45690
        public void SetCullingVectorParameters(){} // RVA: 0x7FFAC3F457F0
        public void GetIndexedUINumericValue(){} // RVA: 0x7FFAC3F45B80
        public void StartCoroutine(){} // RVA: 0x7FFAC3F45D10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutine(){} // RVA: 0x7FFAC3F45ED0
        public void get_UseResampler(){} // RVA: 0x7FFAC3F45FE0
        public void .ctor(){} // RVA: 0x7FFAC3F3B7A0
        public void Initialize(){} // RVA: 0x7FFAC3F45FF0
        public void OnDestroy(){} // RVA: 0x7FFAC3F462F0
        public void set_useGUILayout(){} // RVA: 0x7FFAC3F464B0
        public void print(){} // RVA: 0x7FFAC3F46670
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3F46920
    }

    /// <summary>Originally: ÌÎÌÌÏÎÎÌÏÌÏÎÏÏÍÍÍÏÏÎÌÎÏ</summary>
    public class PointerPreCullHandlerImpl_2960_2960 : PointerPreCullHandler_2B6A_2B6A
    {
        public UnityEngine.GameObject ÍÌÌÍÍÎÍÍÏÏÍÍÍÍÏÍÎÎÏÌÌÎÌ; // 0x48
        public UnityEngine.GameObject ÍÍÏÏÏÏÍÏÌÎÍÍÎÏÎÌÌÏÎÌÌÍÌ; // 0x50
        public UnityEngine.GameObject ÍÍÌÏÎÎÏÍÍÍÎÌÏÏÏÎÌÎÌÍÎÍÌ; // 0x58
        public UnityEngine.Transform ÏÍÏÎÌÍÏÎÍÏÏÌÏÏÎÌÏÎÌÍÎÏÎ; // 0x60
        public UnityEngine.Vector3 ÌÏÍÎÏÎÍÏÍÌÏÌÎÍÎÌÌÌÏÎÍÏÏ; // 0x68
        public UnityEngine.Transform ÍÌÏÏÎÍÏÍÎÎÎÌÏÏÏÌÌÍÏÏÏÎÍ; // 0x78
        public bool ÎÍÍÍÎÌÏÍÌÌÎÍÍÎÍÎÌÏÎÌÏÍÏ; // 0x80
        public bool ÍÏÏÌÏÏÏÌÌÏÍÍÎÍÌÏÏÍÏÏÎÍÍ; // 0x81
        public bool ÍÌÍÏÎÏÏÌÍÎÌÌÍÎÍÍÎÏÎÌÌÎÏ; // 0x82
        public bool ÍÌÏÏÎÌÏÍÌÎÎÏÌÍÍÌÏÎÌÌÍÎÍ; // 0x83
        public UnityEngine.Coroutine ÍÍÍÌÎÌÎÏÏÎÎÍÏÌÍÍÍÏÎÎÌÍÏ; // 0x88
        public float ÎÍÍÍÎÎÍÎÌÍÍÌÏÍÍÏÍÍÎÏÍÌÎ;

        // ── Methods ──
        public void get_WriteIndented(){} // RVA: 0x7FFAC3BDEE90
        public void .ctor(){} // RVA: 0x7FFAC3F415F0
        public void Initialize(){} // RVA: 0x7FFAC3F3BC50
        public void CancelInvoke(){} // RVA: 0x7FFAC3F41600
        public void OnDestroy_5C38AF16EC82(){} // RVA: 0x7FFAC3F3C660
        public void InvokeRepeating(){} // RVA: 0x7FFAC3F418A0
        public void AddUnitNode(){} // RVA: 0x7FFAC3F41BF0
        public void Flush(){} // RVA: 0x7FFAC3F41CD0
        public void DoDeleteAll_78C(){} // RVA: 0x7FFAC3F41DA0
        public void Update(){} // RVA: 0x7FFAC3F3BC50
        public void StartCoroutine(){} // RVA: 0x7FFAC3F42100
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3F42450
        public void StopCoroutine(){} // RVA: 0x7FFAC3F42520
        public void StopCoroutine_1738B1458D11(){} // RVA: 0x7FFAC3F42970
        public void StopCoroutine_C53A1A3948D6(){} // RVA: 0x7FFAC3F42B30
        public void Awake_C6B8EF1EFA27(){} // RVA: 0x7FFAC3F430E0
        public void Start(){} // RVA: 0x7FFAC3F43100
        public void set_useGUILayout(){} // RVA: 0x7FFAC3F43440
        public void print(){} // RVA: 0x7FFAC3F43590
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3F43720
        public void OnDestroy(){} // RVA: 0x7FFAC3F3C660
        public void Initialize_ctrlKeyboardnumpadMinus(){} // RVA: 0x7FFAC3F437A0
        public void Initialize_9B76A1BC9E3E(){} // RVA: 0x7FFAC3F43AC0
        public void OnApplicationPause(){} // RVA: 0x7FFAC3F43F60
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3F440C0
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3F44250
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3F44380
        public void set_name(){} // RVA: 0x7FFAC3F44640
        public void Awake(){} // RVA: 0x7FFAC3F44710
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
    }

    /// <summary>Originally: ÍÏÌÎÏÎÍÌÎÎÏÎÏÎÍÌÎÌÎÍÌÎÍ</summary>
    public class PointerPreCullHandlerImpl_2A78_2A78 : PointerPreCullHandler_2B6A_2B6A
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFAC3F3B4F0
        public void Process(){} // RVA: 0x7FFAC3F3B6D0
        public void .ctor(){} // RVA: 0x7FFAC3F3B7A0
        public void OnReceive(){} // RVA: 0x7FFAC3F3B7B0
        public void OnEvent(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÏÍÎÍÎÎÍÍÌÌÍÍÎÍÎÎÍÌÎÏÏ</summary>
    public class PointerPreCullHandlerImpl_5F49_5F49 : PointerPreCullHandler_2B6A_2B6A
    {
        public UnityEngine.Transform ÍÌÏÏÎÍÏÍÎÎÎÌÏÏÏÌÌÍÏÏÏÎÍ; // 0x48
        public UnityEngine.Transform ÎÌÍÎÍÏÍÍÍÏÌÎÎÍÏÎÎÌÍÎÎÍÎ; // 0x50
        public UnityEngine.Transform ÍÍÎÌÌÍÎÍÏÌÍÎÌÍÎÏÎÏÎÎÎÌÎ; // 0x58
        public UnityEngine.Camera ÎÌÌÍÏÍÍÍÏÍÌÍÎÌÌÍÎÍÎÎÌÏÍ; // 0x60
        public UnityEngine.Camera[] ÌÎÎÌÏÏÎÎÌÏÏÎÍÌÎÍÏÍÎÎÎÌÍ; // 0x68
        public ÎÌÏÍÎÎÏÌÍÏÍÏÍÍÎÏÍÌÍÏÎÎÏ ÌÌÌÌÍÏÍÎÏÏÍÎÌÏÌÏÏÎÌÏÎÍÏ; // 0x70
        public UnityEngine.Vector3 ÌÏÍÎÏÎÍÏÍÌÏÌÎÍÎÌÌÌÏÎÍÏÏ; // 0x78
        public bool ÎÍÍÍÎÌÏÍÌÌÎÍÍÎÍÎÌÏÎÌÏÍÏ; // 0x84
        public bool ÍÏÏÌÏÏÏÌÌÏÍÍÎÍÌÏÏÍÏÏÎÍÍ; // 0x85
        public bool ÍÌÍÏÎÏÏÌÍÎÌÌÍÎÍÍÎÏÎÌÌÎÏ; // 0x86
        public bool ÍÌÏÏÎÌÏÍÌÎÎÏÌÍÍÌÏÎÌÌÍÎÍ; // 0x87
        public UnityEngine.Coroutine ÍÍÍÌÎÌÎÏÏÎÎÍÏÌÍÍÍÏÎÎÌÍÏ; // 0x88
        public float ÎÍÍÍÎÎÍÎÌÍÍÌÏÍÍÏÍÍÎÏÍÌÎ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3F3B880
        public void RaiseCancellation(){} // RVA: 0x7FFAC3F3BA90
        public void Update(){} // RVA: 0x7FFAC3F3BC50
        public void CancelInvoke(){} // RVA: 0x7FFAC3F3BC60
        public void SyncPointerPreCullPose(){} // RVA: 0x7FFAC3F3BF00
        public void InvokeRepeating(){} // RVA: 0x7FFAC3F3C2B0
        public void AddUnitNode(){} // RVA: 0x7FFAC3F3C380
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine(){} // RVA: 0x7FFAC3F3C510
        public void StartCoroutine_C65193B9BF2C(){} // RVA: 0x7FFAC3006850
        public void StartCoroutine_7C452970B4ED(){} // RVA: 0x7FFAC3F3C5E0
        public void OnDestroy(){} // RVA: 0x7FFAC3F3C660
        public void OnDestroy_453B173AFAC6(){} // RVA: 0x7FFAC3F3C660
        public void OnDestroy_800C8BC57F46(){} // RVA: 0x7FFAC3F3C660
        public void StopCoroutine(){} // RVA: 0x7FFAC3F3C670
        public void Awake_D6474D9893E2(){} // RVA: 0x7FFAC3F3C6F0
        public void Computerotation_Inj(){} // RVA: 0x7FFAC3F3C780
        public void get_EnableOfflineCaching(){} // RVA: 0x7FFAC3F3C7F0
        public void print(){} // RVA: 0x7FFAC3F3C800
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3F3C820
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3F3CC00
        public void Initialize(){} // RVA: 0x7FFAC3F3CDC0
        public void .ctor(){} // RVA: 0x7FFAC3F3B7A0
        public void OnApplicationPause(){} // RVA: 0x7FFAC3F3CE70
        public void Start(){} // RVA: 0x7FFAC3F3CF60
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3F3D120
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3F3D2E0
        public void SyncPointerPreCullPose_E1789FE9A2AA(){} // RVA: 0x7FFAC2F9C730
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3F3D420
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC3F3D7C0
        public void Awake(){} // RVA: 0x7FFAC3F3D910
        public void IsInvoking(){} // RVA: 0x7FFAC3F38200
        public void HandlePreCull(){} // RVA: 0x7FFAC3F3DE50
    }

    /// <summary>Originally: ÎÏÎÎÌÏÍÌÍÎÏÍÏÏÍÎÍÏÎÏÍÏÏ</summary>
    public class PointerPreCullHandler_3FF4_3FF4 : MonoBehaviour
    {
        public UnityEngine.Light[] ÎÏÌÏÌÏÌÎÏÌÌÍÏÍÏÌÌÌÍÎÌÍÏ; // 0x20

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFAC42D8BD0
        public void Process(){} // RVA: 0x7FFAC42D8CF0
        public void OnReceive(){} // RVA: 0x7FFAC42D8E10
        public void OnPreCull(){} // RVA: 0x7FFAC42D8F30
        public void OnPostRender(){} // RVA: 0x7FFAC42D9050
        public void OnEvent(){} // RVA: 0x7FFAC42D9170
        public void CancelInvoke(){} // RVA: 0x7FFAC42D9290
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÍÏÎÌÏÍÏÍÌÍÏÌÌÌÎÍÌÍÎÏÏÍÎ</summary>
    public class PointerPreCullHandler_9E84_9E84 : MonoBehaviour
    {
        public VRC.IMDraw ÍÏÍÍÍÎÎÍÎÌÎÎÍÎÎÍÍÍÌÏÌÌÍ; // 0x20
        public UnityEngine.Camera ÎÎÎÎÎÏÎÏÌÍÌÎÎÏÎÎÎÏÎÌÏÎÍ; // 0x28
        public UnityEngine.Rendering.CommandBuffer ÎÎÎÏÌÌÌÍÌÎÌÌÍÏÎÍÏÌÍÌÌÎÍ; // 0x30
        public 0x6B186788 ÏÎÎÏÌÍÍÏÏÍÏÎÎÌÏÍÎÏÍÍÏÍÎ; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB906970
        public void IsInvoking(){} // RVA: 0x7FFACB906A50
        public void CancelInvoke(){} // RVA: 0x7FFACB906CE0
        public void Invoke(){} // RVA: 0x7FFACB906EC0
        public void InvokeRepeating(){} // RVA: 0x7FFACB9070A0
        public void Update(){} // RVA: 0x7FFACB907180
        public void LateUpdate(){} // RVA: 0x7FFACB907360
        public void OnPreCull(){} // RVA: 0x7FFACB9075F0
        public void OnDestroy(){} // RVA: 0x7FFACB9076D0
        public void StartCoroutine(){} // RVA: 0x7FFACB9076E0
    }

    /// <summary>Originally: ÎÍÎÍÏÎÎÌÎÏÎÌÎÌÌÎÌÎÍÌÍÍÌ</summary>
    public class PointerPreCullHandler_D1BF_D1BF : MonoBehaviour
    {
        public float referenceFOV; // 0x20
        public float currentLODBias; // 0x24
        public bool enableCompensation; // 0x28
        public UnityEngine.Camera ÎÎÎÎÎÏÎÏÌÍÌÎÎÏÎÎÎÏÎÌÏÎÍ; // 0x30
        public float ÌÍÌÌÍÌÌÎÎÏÌÍÌÍÎÌÌÍÎÏÍÍÏ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3EDE270
        public void RaiseCancellation(){} // RVA: 0x7FFAC3EDE3D0
        public void .ctor(){} // RVA: 0x7FFAC3EDE430
        public void Initialize(){} // RVA: 0x7FFAC3EDE3D0
        public void OnPreCull(){} // RVA: 0x7FFAC3EDE490
        public void Start(){} // RVA: 0x7FFAC3EDE5F0
        public void CancelInvoke(){} // RVA: 0x7FFAC3EDE3D0
        public void IsInvoking(){} // RVA: 0x7FFAC3EDE680
        public void OnPostRender(){} // RVA: 0x7FFAC3EDE3D0
        public void StartCoroutine(){} // RVA: 0x7FFAC3EDE710
        public void OnDestroy(){} // RVA: 0x7FFAC3EDE870
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3EDE900
    }

    /// <summary>Originally: ÌÍÎÎÍÎÍÏÏÍÏÍÏÌÌÎÍÎÌÌÎÍÌ</summary>
    public class PointerPreCullHandler_FC27_FC27 : MonoBehaviour
    {
        public bool ÎÎÍÌÌÍÌÌÍÎÏÍÏÎÍÎÌÌÏÏÎÍÌ; // 0x20
        public UnityEngine.Camera ÎÎÎÎÎÏÎÏÌÍÌÎÎÏÎÎÎÏÎÌÏÎÍ; // 0x28
        public Valve.VR.CVRSystem ÎÏÏÎÎÌÌÏÏÏÏÌÍÏÏÌÍÌÌÌÌÍÌ; // 0x30
        public UnityEngine.Matrix4x4 ÏÎÌÎÍÍÎÌÎÍÏÏÍÏÎÌÌÎÏÌÎÌÍ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3EEBDA0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3EEC230
        public void IsInvoking(){} // RVA: 0x7FFAC3EEC770
        public void CancelInvoke(){} // RVA: 0x7FFAC3EEC8A0
        public void OnDisable(){} // RVA: 0x7FFAC3EECD30
        public void InvokeRepeating(){} // RVA: 0x7FFAC3EECDB0
        public void OnApplicationPause(){} // RVA: 0x7FFAC3EED240
        public void OnApplicationQuit(){} // RVA: 0x7FFAC3EED370
        public void OnEnable(){} // RVA: 0x7FFAC3EED3F0
        public void OnPreCull(){} // RVA: 0x7FFAC3EED830
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÌÌÏÏÎÍÎÍÌÎÌÌÎÌÍÍÌÍÌÍÍÍÌ</summary>
    public class PointerPressKeyComponent_534D_534D : MonoBehaviour
    {
        public ÏÏÍÌÍÌÌÎÎÌÌÍÍÏÎÏÌÍÎÎÏÌÏ ÌÏÌÏÍÎÌÍÏÎÌÏÎÎÍÏÎÌÎÏÍÏÏ; // 0x20
        public 0x6B019DC0 ÌÌÍÎÌÌÏÍÍÍÏÎÎÎÌÍÏÌÏÏÍÍÌ; // 0x28
        public 0x6B17D1A8 ÎÍÏÎÎÌÌÍÏÌÏÌÏÎÍÎÍÍÏÌÍÍÌ; // 0x2C
        public string ÌÎÏÍÍÍÎÎÍÎÎÌÍÎÏÍÏÍÍÎÏÍÍ; // 0x30
        public string ÏÌÎÍÌÍÍÎÌÏÌÌÎÏÍÌÎÎÌÏÍÏÌ; // 0x38
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÏÏÎÍÍÎÌÏÍÏÍÎÎÌÎÏÌÎÌÏÌÎ; // 0x40
        public float ÍÏÏÎÌÍÎÍÌÏÌÏÍÌÌÌÏÏÏÌÎÌÎ;
        public float ÎÏÏÍÌÍÌÏÍÏÍÎÍÏÍÌÍÍÏÍÎÎÎ;
        public float ÌÌÍÌÌÎÌÎÌÎÎÎÍÎÎÌÌÍÌÎÏÎÎ; // 0x48
        public float ÏÎÌÌÏÏÌÏÎÍÍÏÎÍÍÌÌÌÎÏÎÌÍ; // 0x4C

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC45BA6C0
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void IsInvoking(){} // RVA: 0x7FFAC2F21310
        public void CancelInvoke(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC45BA7A0
        public void PressKey(){} // RVA: 0x7FFAC45BA910
        public void OnDestroy(){} // RVA: 0x7FFAC45BABD0
        public void OnApplicationPause(){} // RVA: 0x7FFAC45BACB0
        public void StartCoroutine(){} // RVA: 0x7FFAC2F21310
        public void OnBecameVisible(){} // RVA: 0x7FFAC45BAD50
        public void OnBecameInvisible(){} // RVA: 0x7FFAC45BADF0
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC45BAEE0
        public void Initialize(){} // RVA: 0x7FFAC45BB030
    }

    /// <summary>Originally: ÏÌÍÏÍÏÌÎÍÌÎÏÍÍÎÏÍÏÍÏÏÎÍ</summary>
    public class PointerReleaseBonesComponent_14B5_14B5 : MonoBehaviour
    {
        public UnityEngine.GameObject _destroyCancellationToken; // 0x20
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender _useGUILayout; // 0x28
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÎÍÍÎÌÍÎÍÍÌÍÏÌÍÍÏÏÌÌÏÎÌÍ; // 0x30
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÌÏÏÎÎÌÎÎÏÎÏÌÍÌÌÌÍÎÍÍÎÌÎ; // 0x38
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÎÌÌÌÌÍÏÍÍÎÎÍÍÍÎÏÌÌÍÏÎÎÌ; // 0x40
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÏÌÌÌÍÏÌÍÎÌÏÍÍÍÏÏÎÎÎÏÏÏÏ; // 0x48
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÏÏÏÏÍÎÌÏÌÍÎÎÎÍÌÏÎÌÏÎÏÍÎ; // 0x50
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÏÎÌÎÎÎÏÌÎÎÏÎÏÎÍÌÎÌÌÌÎÍÌ; // 0x58
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÌÍÍÏÍÎÏÍÎÏÏÏÏÌÌÎÏÌÏÍÌÏÌ; // 0x60
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÌÌÏÏÌÍÍÎÏÏÏÌÏÌÍÏÌÏÎÍÎÎÍ; // 0x68
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÌÍÍÏÎÏÏÍÍÌÌÌÌÍÏÏÍÍÏÍÎÎÍ; // 0x70
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÍÌÏÌÌÌÏÍÌÌÏÎÌÏÎÌÍÍÏÌÎÌÏ; // 0x78
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÏÏÍÏÏÏÏÍÏÍÎÎÌÎÏÎÌÌÌÏÍÎÍ; // 0x80
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÏÎÌÏÎÏÌÌÎÎÌÏÌÍÎÏÌÏÍÌÎÏÏ; // 0x88
        public VRC.SDK3.Dynamics.Contact.Components.VRCContactSender ÍÌÌÎÏÎÏÌÏÍÎÎÌÌÎÍÍÌÌÎÍÍÌ; // 0x90
        public ÎÌÎÍÍÍÏÎÌÏÏÍÏÏÌÌÎÎÎÏÍÏÏ ÍÎÍÍÎÌÏÏÏÏÏÏÎÌÎÏÏÎÏÏÎÎÌ; // 0x98
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ ÎÌÍÌÌÎÎÏÎÍÎÍÎÍÏÎÍÌÏÌÌÍÏ; // 0xA0
        public int ÌÍÍÎÎÏÎÍÌÍÏÎÌÎÌÍÏÍÎÌÏÍÎ; // 0xA8
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÌÌÌÍÎÏÎÌÌÎÎÌÍÍÌÏÎÍÏÍÏ; // 0xB0
        public ÌÏÍÎÎÎÏÍÌÍÌÍÏÏÌÌÎÍÌÎÌÎÏ ÏÌÎÍÏÏÎÏÍÎÌÍÌÌÌÏÎÏÌÌÌÎÏ; // 0xB8
        public ÌÏÍÌÏÎÎÏÍÍÏÏÌÎÎÍÌÍÌÌÍÎÌ ÏÌÎÌÌÎÏÌÏÏÏÎÌÌÏÍÍÎÏÍÌÌÍ; // 0xC0
        public UnityEngine.GameObject ÍÏÍÍÎÌÏÏÌÌÏÎÎÌÍÎÏÏÎÍÌÎÍ; // 0xC8
        public UnityEngine.Animator ÏÎÎÎÏÌÍÌÎÎÌÎÌÌÎÌÏÏÏÌÍÏÌ; // 0xD0
        public VRC.SDK3.Avatars.Components.VRCAvatarDescriptor ÍÏÏÏÏÍÍÏÏÌÎÎÍÌÏÍÌÌÌÍÍÎÏ; // 0xD8
        public UnityEngine.Vector3 ÍÌÎÍÌÌÍÌÎÎÏÌÌÏÎÌÌÌÏÌÌÎÌ; // 0xE0
        public float ÏÎÍÎÌÎÎÏÏÍÌÏÏÌÎÍÍÌÌÎÏÏÏ; // 0xEC
        public VRC.Dynamics.PhysBoneRootDefinition ÏÏÌÎÌÍÍÏÍÏÏÌÌÏÎÍÌÏÌÎÍÎÎ; // 0xF0
        public bool ÍÎÏÏÎÌÍÏÏÎÎÎÏÌÎÍÌÏÎÍÌÍÏ; // 0xF8
        public System.Collections.Generic.List`1<DynamicBoneCollider> ÏÏÏÏÌÎÍÍÍÍÌÌÎÎÍÍÍÌÏÏÏÏÌ;
        public System.Collections.Generic.List`1<DynamicBone> ÏÌÎÏÎÎÏÏÏÌÏÍÎÏÎÍÎÎÏÌÌÍÌ; // 0x8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4036060
        public void RaiseCancellation(){} // RVA: 0x7FFAC40361C0
        public void IsInvoking(){} // RVA: 0x7FFAC40363F0
        public void CancelInvoke(){} // RVA: 0x7FFAC4036620
        public void OnDestroy(){} // RVA: 0x7FFAC4036760
        public void InvokeRepeating(){} // RVA: 0x7FFAC4036770
        public void .cctor(){} // RVA: 0x7FFAC4036B00
        public void OnBecameVisible(){} // RVA: 0x7FFAC4036CA0
        public void StartCoroutine(){} // RVA: 0x7FFAC40376C0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC4037A20
        public void Awake(){} // RVA: 0x7FFAC4037AC0
        public void Start(){} // RVA: 0x7FFAC4037AE0
        public void StopCoroutine(){} // RVA: 0x7FFAC40383B0
        public void OnTriggerStay(){} // RVA: 0x7FFAC4038E40
        public void ReleaseBones(){} // RVA: 0x7FFAC4038E70
        public void StopAllCoroutines(){} // RVA: 0x7FFAC40393C0
        public void get_useGUILayout(){} // RVA: 0x7FFAC4039E50
        public void set_useGUILayout(){} // RVA: 0x7FFAC403A110
        public void print(){} // RVA: 0x7FFAC403A9E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC403ACD0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC403AF90
        public void InvokeDelayed(){} // RVA: 0x7FFAC403B250
        public void OnCollisionStay(){} // RVA: 0x7FFAC403BB20
        public void OnCollisionExit(){} // RVA: 0x7FFAC403BDB0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC403D1F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC403D210
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC403DD70
    }

    /// <summary>Originally: ÌÎÏÏÏÌÌÌÏÎÎÎÍÍÎÏÌÌÌÍÎÍÌ</summary>
    public class PointerSecondaryButtonPressQuickPressHandler_BEBA_BEBA : MonoBehaviour
    {
        public string ÍÌÍÎÎÎÏÏÌÎÏÌÍÍÌÌÌÎÏÎÏÏÍ; // 0x20
        public UnityEngine.UI.Text ÎÌÍÏÏÌÎÍÎÏÎÏÎÏÌÍÍÍÌÌÏÏÏ; // 0x28
        public UnityEngine.UI.RawImage ÏÎÍÎÌÏÍÌÏÎÎÍÍÎÌÎÏÏÏÍÌÌÎ; // 0x30
        public UnityEngine.UI.Image ÌÍÏÍÍÏÌÎÌÎÌÏÎÌÌÏÏÎÍÎÏÎÏ; // 0x38
        public UnityEngine.Texture ÍÏÍÎÎÍÍÍÌÎÍÌÍÍÏÏÏÍÎÎÍÏÍ; // 0x40
        public string ÏÎÍÎÏÎÍÍÌÌÌÌÎÍÍÏÍÎÏÌÏÌÏ; // 0x48
        public ÍÎÎÍÏÌÎÍÏÍÏÌÏÎÍÌÏÎÏÌÏÍÎ ÍÌÏÎÍÍÌÏÌÏÎÎÌÏÎÌÎÍÍÍÍÏÏ; // 0x50
        public ÌÏÏÌÌÎÌÌÌÏÌÌÌÏÍÏÌÌÎÎÎÏÍ ÎÍÌÌÎÏÎÍÏÏÌÎÌÍÌÍÌÎÏÎÍÌÍ; // 0x58
        public UnityEngine.GameObject ÎÏÌÎÌÌÍÍÎÎÏÍÎÍÎÍÍÎÎÍÏÌÎ; // 0x60
        public bool ÏÍÌÌÍÏÌÍÌÎÍÎÏÎÌÌÍÌÌÎÏÍÌ; // 0x68
        public bool ÍÍÌÎÏÏÎÌÌÌÍÎÏÌÌÍÏÎÏÏÍÏÌ; // 0x69
        public ÍÌÎÌÍÏÍÏÌÌÌÏÍÌÏÎÎÏÍÎÏÌÍ ÏÌÏÍÏÌÍÌÎÏÏÌÌÎÍÌÏÍÌÍÎÎÍ; // 0x70
        public UnityEngine.GameObject[] ÌÎÌÍÏÏÌÍÎÏÌÎÍÌÏÍÌÎÏÎÎÍÌ; // 0x78
        public UnityEngine.GameObject ÍÎÍÏÎÎÍÌÏÏÎÍÏÍÍÎÎÏÏÏÏÍÏ; // 0x80
        public UnityEngine.Texture ÎÍÏÏÏÎÌÌÎÏÌÏÍÍÍÎÍÍÎÎÏÎÌ; // 0x88
        public System.Action ÌÎÍÍÎÏÍÌÍÎÍÌÌÌÌÌÎÍÏÎÌÏÌ; // 0x90
        public System.Action ÎÏÏÎÍÌÍÏÍÍÌÍÏÌÏÌÏÎÏÌÏÎÏ; // 0x98
        public System.Action ÌÎÍÌÏÍÌÏÏÏÍÏÎÍÌÎÌÏÍÍÎÎÏ; // 0xA0
        public UnityEngine.Vector3 ÌÍÏÌÍÌÌÎÍÌÎÌÏÏÏÌÏÌÎÌÌÎÍ; // 0xA8
        public bool ÌÏÎÍÏÎÍÏÌÎÍÍÍÌÏÏÌÌÎÌÏÏÌ; // 0xB4
        public bool ÏÍÏÎÍÎÏÎÍÍÍÏÏÎÍÎÌÎÎÏÌÌÎ; // 0xB5
        public UnityEngine.Color ÌÎÍÎÌÍÏÌÎÎÍÏÎÌÏÎÎÏÎÎÌÍÎ; // 0xB8
        public UnityEngine.AnimationCurve ÎÍÏÎÌÌÌÌÌÎÌÏÎÍÌÍÎÏÎÌÎÎÍ; // 0xC8
        public int ÌÏÍÍÏÌÏÎÎÍÏÎÎÎÍÎÌÍÍÏÎÎÍ;

        // ── Methods ──
        public void QuickPress(){} // RVA: 0x7FFAC43102B0
        public void RaiseCancellation(){} // RVA: 0x7FFAC43102D0
        public void Press(){} // RVA: 0x7FFAC4310410
        public void CancelInvoke(){} // RVA: 0x7FFAC4310430
        public void Invoke(){} // RVA: 0x7FFAC4310720
        public void InvokeRepeating(){} // RVA: 0x7FFAC4310740
        public void SecondaryButtonPress(){} // RVA: 0x7FFAC4310890
        public void IsInvoking(){} // RVA: 0x7FFAC43108B0
        public void StartCoroutine(){} // RVA: 0x7FFAC4310410
        public void OnPointerEnter(){} // RVA: 0x7FFAC43109F0
        public void OnPointerExit(){} // RVA: 0x7FFAC4310A10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC4310D00
        public void StopCoroutine(){} // RVA: 0x7FFAC4310DE0
        public void OnPointerDown(){} // RVA: 0x7FFAC4310F90
        public void OnPointerUp(){} // RVA: 0x7FFAC4311210
        public void StopAllCoroutines(){} // RVA: 0x7FFAC4311770
        public void get_useGUILayout(){} // RVA: 0x7FFAC4311850
        public void set_useGUILayout(){} // RVA: 0x7FFAC43118A0
        public void Awake(){} // RVA: 0x7FFAC4311C20
        public void OnDestroy(){} // RVA: 0x7FFAC4311C30
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC4311C80
        public void .ctor(){} // RVA: 0x7FFAC4312280
        public void Initialize(){} // RVA: 0x7FFAC4310890
        public void OnSelect(){} // RVA: 0x7FFAC43122E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC43124E0
    }

    /// <summary>Originally: ÌÏÍÏÌÏÌÌÏÌÎÌÍÎÌÍÍÍÏÎÍÌÎ</summary>
    public class PointerSubmitAuthenticationCodeIOpenTwoFactorAu_6951_6951 : UpdateComponent_B6B3_B6B3
    {
        public ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ ÌÌÍÍÏÍÍÎÎÍÌÍÍÍÎÎÏÍÍÏÎÎÌ; // 0x60
        public UiInputField ÌÌÍÍÍÏÌÌÍÎÏÏÍÏÌÌÏÏÌÍÌÍÏ; // 0x68
        public UiInputField ÎÏÌÎÏÏÌÍÌÏÏÏÎÍÏÎÎÌÍÌÍÍÌ; // 0x70
        public UiInputField ÏÏÏÎÎÍÌÎÎÏÌÏÏÍÏÎÎÌÌÌÍÌÍ; // 0x78
        public UnityEngine.UI.Button ÌÏÍÏÏÎÍÌÏÌÎÎÎÏÍÎÌÍÏÌÏÎÌ; // 0x80
        public UnityEngine.UI.Button ÏÍÌÏÍÌÏÏÌÎÏÎÏÎÎÎÎÎÌÍÍÏÍ; // 0x88
        public UnityEngine.GameObject ÏÌÏÎÎÍÏÌÍÎÏÌÎÏÌÍÏÌÍÏÏÏÌ; // 0x90
        public string ÏÌÎÎÏÏÌÎÌÏÎÎÌÍÍÎÎÎÎÎÎÎÏ; // 0x98
        public string ÎÎÍÍÌÍÎÏÌÍÏÎÏÎÌÌÌÎÎÎÍÌÎ;
        public string ÌÌÌÍÏÍÎÌÏÌÎÌÍÌÌÍÏÎÌÌÌÍÍ;
        public string ÍÌÍÎÌÏÏÏÎÏÏÏÎÍÎÏÎÏÍÌÍÎÏ;
        public string ÏÏÏÏÏÎÍÎÌÍÍÌÏÎÎÌÏÌÍÌÏÎÌ;
        public string ÏÎÍÏÍÎÍÎÌÌÍÏÍÏÌÌÎÌÏÏÏÍÍ;
        public string ÎÏÍÏÍÍÎÏÍÍÏÎÏÎÌÌÏÎÌÍÏÏÍ;
        public string ÎÍÎÎÍÍÎÎÌÌÎÎÍÏÌÎÍÌÏÎÍÍÏ;
        public System.Action ÏÎÌÎÏÌÌÎÍÏÌÌÏÏÎÌÎÏÎÎÍÌÏ;
        public System.Action ÍÌÌÌÍÍÍÎÎÌÌÎÎÍÏÍÌÌÌÍÌÎÌ; // 0x8
        public string ÌÍÌÎÏÎÏÍÏÏÎÎÏÌÎÎÏÌÏÌÌÎÍ; // 0x10
        public string ÏÏÎÏÌÏÍÎÍÏÏÎÌÏÎÏÎÏÎÍÍÌÍ; // 0x18
        public bool ÏÏÍÎÌÏÍÍÌÏÌÌÌÎÎÍÌÏÏÎÏÍÎ; // 0xA0
        public bool ÏÌÎÎÎÌÏÏÎÌÎÏÌÏÎÎÌÍÍÎÏÏÍ; // 0xA1
        public UiInputField ÌÎÌÎÎÎÎÌÍÍÍÏÌÍÌÍÍÍÌÍÌÌÍ; // 0xA8
        public UiInputField ÏÎÏÎÎÍÍÍÍÌÎÍÏÍÏÌÍÏÌÍÏÍÍ; // 0xB0
        public UiInputField ÌÌÍÏÌÎÌÏÏÍÌÎÍÎÎÌÏÌÎÍÎÌÏ; // 0xB8
        public UiInputField ÏÏÌÏÍÌÍÍÎÍÍÏÌÌÏÌÍÎÌÏÌÍÌ; // 0xC0
        public UiInputField ÎÏÎÌÏÏÎÎÍÌÏÎÎÌÍÏÌÎÍÌÎÎÏ; // 0xC8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC435C060
        public void Initialize(){} // RVA: 0x7FFAC435C120
        public void Start(){} // RVA: 0x7FFAC435C2A0
        public void BackPressed(){} // RVA: 0x7FFAC435CA00
        public void AuthenticateWithPico(){} // RVA: 0x7FFAC2F21310
        public void InitializeBackPressed(){} // RVA: 0x7FFAC435CB30
        public void AuthenticateWithSteam(){} // RVA: 0x7FFAC435CC60
        public void OnEnable_9A2778F77B9A(){} // RVA: 0x7FFAC2F21310
        public void AccountLoginPressed(){} // RVA: 0x7FFAC435CD20
        public void OnDestroy(){} // RVA: 0x7FFAC435D1D0
        public void Start_98CE27042B0B(){} // RVA: 0x7FFAC435D480
        public void OnSubmitAuthenticationCodeIsRecovery(){} // RVA: 0x7FFAC435D590
        public void UpdateActive(){} // RVA: 0x7FFAC435DAE0
        public void ShowAppropriateLoginPromptScreen(){} // RVA: 0x7FFAC435DC10
        public void AuthenticateWithViveport(){} // RVA: 0x7FFAC2F21310
        public void CanNotSubmitAuthenticationCode(){} // RVA: 0x7FFAC435DC30
        public void AuthenticateWithOculus(){} // RVA: 0x7FFAC2F21310
        public void DeactivateContinueAction(){} // RVA: 0x7FFAC435DC70
        public void GetOneHandGestureTriggerAxis(){} // RVA: 0x7FFAC435DC90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize_FF69E7A41895(){} // RVA: 0x7FFAC435DCF0
        public void EnsureInitialized(){} // RVA: 0x7FFAC435DE00
        public void UpdateConfigurationObject(){} // RVA: 0x7FFAC435DF80
        public void OpenTwoFactorAuthenticationHelpURL(){} // RVA: 0x7FFAC435E110
        public void OnEnable(){} // RVA: 0x7FFAC435E1B0
        public void OnDisable(){} // RVA: 0x7FFAC435E370
        public void AccountCreatePressed(){} // RVA: 0x7FFAC435E480
        public void CreateAuthenticationRequest(){} // RVA: 0x7FFAC435ED90
        public void Update(){} // RVA: 0x7FFAC435EE80
    }

}