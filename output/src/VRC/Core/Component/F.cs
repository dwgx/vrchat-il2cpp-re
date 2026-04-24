// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Component
// Classes: 6
// Methods: 107

namespace VRC.Core.Component
{
    /// <summary>Originally: ÍÌÏÍÌÏÎÍÍÍÎÏÏÍÎÏÌÌÍÌÍÏÎ</summary>
    public class FixedUpdateComponent_1F51 : MonoBehaviour
    {
        public float ÎÍÎÎÎÌÎÎÎÎÌÍÌÌÎÌÍÏÎÍÍÍÌ; // 0x20
        public float ÍÌÏÎÎÌÌÏÌÎÍÌÏÍÌÌÏÎÌÏÌÎÎ; // 0x24
        public UnityEngine.GameObject objectToEnable; // 0x28
        public ÍÏÍÎÍÌÎÏÏÌÍÌÎÍÏÏÌÎÌÌÌÎÏ ÍÍÍÌÏÏÎÏÏÍÍÎÏÍÏÍÌÌÏÎÏÎÌ; // 0x30
        public float ÏÍÌÌÎÍÍÍÎÎÏÎÍÌÍÏÎÍÏÏÌÎÍ;
        public float ÌÌÎÏÌÏÍÍÌÏÌÍÍÏÍÌÎÎÍÌÍÍÍ;
        public UnityEngine.UI.Button ÎÏÍÎÏÍÎÏÎÏÏÍÍÏÏÍÎÎÎÍÏÌÌ; // 0x38
        public bool ÏÏÎÌÏÎÍÏÎÌÎÏÎÏÍÏÍÎÏÍÏÍÏ; // 0x40
        public bool ÍÏÎÏÌÌÎÏÍÎÎÏÍÏÌÎÍÏÏÏÌÏÎ; // 0x41

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F1C6560
        public void RaiseCancellation(){} // RVA: 0x7FFD4F1C67A0
        public void OnEnable(){} // RVA: 0x7FFD4F1C6BB0
        public void OnDisable(){} // RVA: 0x7FFD4F1C6BC0
        public void Invoke(){} // RVA: 0x7FFD4F1C6BE0
        public void .ctor(){} // RVA: 0x7FFD4F1C7040
        public void Initialize(){} // RVA: 0x7FFD4F1C70A0
        public void Awake(){} // RVA: 0x7FFD4F1C70D0
        public void OnDestroy(){} // RVA: 0x7FFD4F1C7170
        public void StartCoroutine(){} // RVA: 0x7FFD4F1C70A0
        public void LateUpdate(){} // RVA: 0x7FFD4F1C75E0
        public void FixedUpdate(){} // RVA: 0x7FFD4F1C79F0
        public void Start(){} // RVA: 0x7FFD4F1C7E30
        public void StopCoroutine(){} // RVA: 0x7FFD4F1C8270
        public void OnCollisionStay(){} // RVA: 0x7FFD4F1C84A0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F1C88B0
    }

    /// <summary>Originally: ÎÏÌÏÍÌÎÌÏÌÎÍÍÏÏÍÍÌÌÌÌÏÌ</summary>
    public class FixedUpdateComponent_2A2A : MonoBehaviour
    {
        public float _destroyCancellationToken;
        public float _useGUILayout;
        public float f_BE5;
        public float f_AC1;
        public float f_B68;
        public float f_E71;
        public float f_EE1;
        public float ÏÎÏÌÎÎÌÏÏÎÌÏÌÍÎÏÍÏÌÌÎÌÎ;
        public float ÌÍÏÌÎÌÎÍÏÌÍÏÍÏÎÏÎÏÎÏÎÎÏ;
        public float ÍÎÎÌÍÎÎÎÌÌÍÌÌÌÌÌÎÏÌÌÎÏÍ;
        public float ÌÍÏÌÏÍÏÎÏÌÌÏÎÏÍÌÌÏÎÏÎÌÌ;
        public float ÎÎÍÏÏÎÎÎÎÍÌÍÎÌÎÎÌÌÎÎÎÌÌ;
        public float ÎÎÏÍÌÌÌÍÎÎÎÌÎÍÍÍÌÏÍÏÌÍÌ;
        public float ÌÏÎÏÏÍÎÌÍÏÌÍÌÎÏÎÏÍÏÏÏÍÎ;
        public float ÍÌÌÍÎÎÍÍÍÌÏÍÏÍÏÍÎÎÍÌÌÏÌ;
        public float ÎÌÍÎÍÍÍÎÏÍÏÌÎÌÎÏÏÏÍÏÎÍÎ;
        public float ÎÏÏÏÌÏÍÍÏÍÌÍÌÎÌÏÌÍÌÍÌÌÍ;
        public float ÌÎÌÎÌÌÍÌÏÌÌÎÍÍÍÍÎÍÎÌÌÌÌ;
        public float ÏÏÎÎÏÏÌÌÍÏÎÎÌÌÍÌÌÍÌÍÍÌÏ;
        public float ÏÍÍÎÎÏÎÌÏÌÏÎÌÌÍÌÍÎÎÏÍÎÌ;
        public float ÍÍÍÏÌÏÏÏÍÎÌÎÍÍÏÎÏÏÌÍÎÍÌ;
        public float ÎÌÌÍÏÌÎÍÌÎÍÌÎÌÏÌÏÍÏÌÏÏÎ;
        public float ÍÎÌÍÏÍÎÌÍÎÎÎÏÌÏÍÍÌÌÌÏÌÍ;
        public float ÎÌÌÎÏÎÎÏÎÍÎÏÏÎÏÍÎÌÎÍÏÍÎ;
        public float ÍÌÎÏÍÌÌÌÎÌÎÏÍÍÍÎÎÎÍÌÏÌÎ;
        public float ÍÍÍÎÎÌÍÏÍÎÍÍÍÍÌÏÎÏÎÌÍÎÍ;
        public float ÍÏÍÎÍÎÌÏÎÏÌÌÍÏÍÌÎÏÎÌÌÍÏ;
        public float ÌÍÏÏÎÍÍÎÍÏÌÏÎÍÍÏÍÏÏÏÌÌÌ;
        public float ÏÍÍÌÌÍÎÏÌÍÎÎÍÏÎÏÏÌÏÍÌÍÏ;
        public float ÌÎÏÌÏÎÏÍÌÎÌÍÏÎÏÍÌÏÏÎÍÌÏ;
        public float ÌÌÌÍÎÏÏÏÎÏÌÏÎÍÎÍÌÎÍÎÎÌÏ;
        public float ÌÍÌÏÍÍÍÍÏÎÍÌÍÎÍÏÏÎÏÏÏÍÎ;
        public float ÌÏÏÏÍÎÌÍÍÏÏÌÎÌÍÎÌÍÎÍÌÌÎ;
        public float ÎÏÏÌÌÍÏÌÏÌÌÏÎÍÎÎÌÎÏÏÏÌÏ;
        public float ÎÍÏÌÎÍÏÎÌÌÎÏÌÌÌÌÌÏÏÏÎÌÏ;
        public float ÌÏÍÏÏÍÍÎÏÏÌÏÍÏÎÏÌÍÍÏÍÍÏ;
        public float ÎÍÎÌÍÍÍÎÌÌÎÎÎÌÏÍÏÌÍÏÌÌÎ;
        public float ÌÎÌÌÍÏÌÏÌÎÍÍÏÏÏÎÍÎÍÍÏÎÏ;
        public float ÌÏÌÏÍÏÌÎÏÏÍÌÏÍÌÏÌÍÌÎÌÏÍ;
        public float ÍÎÏÍÎÎÍÏÏÍÏÎÌÎÏÍÍÌÍÎÏÍÌ;
        public UnityEngine.Rigidbody ÎÏÍÌÍÍÎÎÍÎÍÌÌÍÍÎÌÍÍÏÍÎÍ; // 0x20
        public UnityEngine.Transform ÎÎÎÏÏÏÎÌÍÌÎÎÍÌÎÌÎÍÏÍÎÌÍ; // 0x28
        public ÎÏÌÏÌÍÎÍÏÍÏÏÎÏÌÍÏÎÏÎÍÍÍ ÏÍÌÌÌÏÌÌÍÎÍÍÍÍÌÎÌÏÌÏÏÍÌ; // 0x30
        public VRC.PlayerDrone.PIDControllerQuaternion ÎÌÎÌÎÍÍÏÏÎÌÏÍÎÏÍÎÏÏÍÍÌÏ; // 0x38
        public VRC.PlayerDrone.PIDController ÍÍÍÏÏÌÍÌÎÌÌÏÌÎÌÍÏÍÎÎÍÌÌ; // 0x5C
        public VRC.PlayerDrone.PIDController ÌÎÍÌÎÌÎÍÍÎÏÌÏÎÎÏÎÏÏÏÌÏÎ; // 0x7C
        public VRC.PlayerDrone.PIDController ÌÍÎÌÌÏÍÌÎÌÌÏÍÏÏÌÍÌÎÎÎÎÎ; // 0x9C
        public VRC.PlayerDrone.PIDController ÍÍÏÍÏÍÌÎÌÍÍÎÏÍÌÎÏÌÍÎÏÎÎ; // 0xBC
        public VRC.PlayerDrone.PIDController ÎÌÏÎÌÍÎÌÍÏÌÍÌÏÏÌÍÏÌÏÍÏÏ; // 0xDC
        public VRC.PlayerDrone.PIDController ÍÎÍÌÎÍÎÌÏÏÏÎÏÌÌÎÍÌÍÏÍÌÏ; // 0xFC
        public float ÌÏÎÍÌÍÎÍÌÏÌÎÎÌÌÎÌÍÎÌÍÌÎ; // 0x11C
        public float ÏÍÌÍÏÏÍÎÎÍÎÎÎÏÍÎÎÍÏÌÌÎÌ; // 0x120
        public float ÍÌÌÍÎÍÏÏÍÍÎÍÎÍÏÏÍÌÍÏÎÎÌ; // 0x124
        public float ÍÎÏÌÌÏÌÍÌÎÍÌÎÎÍÏÌÍÌÎÏÌÎ; // 0x128
        public float ÍÏÌÌÍÍÎÍÍÎÌÍÌÍÎÎÍÏÏÏÌÏÎ; // 0x12C
        public float ÍÏÎÏÎÌÌÏÌÎÎÎÎÎÍÌÌÌÏÍÍÏÏ; // 0x130
        public float ÎÏÌÏÏÌÍÍÌÎÏÍÌÌÍÌÍÍÏÍÍÍÍ; // 0x134
        public float ÎÏÍÏÍÏÍÏÍÌÏÍÌÎÎÌÎÍÎÍÌÎÏ; // 0x138
        public float ÍÏÎÌÏÌÎÏÏÎÍÏÍÌÍÌÏÌÏÍÍÌÌ; // 0x13C
        public float ÌÏÏÏÌÏÏÏÎÌÎÌÏÏÎÎÏÏÏÏÎÍÍ; // 0x140
        public float ÏÍÎÎÌÎÍÏÌÍÌÌÎÏÌÎÎÌÎÏÌÎÍ; // 0x144
        public float ÏÎÏÏÎÌÏÍÍÍÍÍÏÌÍÌÍÏÏÏÌÎÍ; // 0x148
        public float ÎÍÏÌÎÍÏÌÌÎÏÌÌÎÏÌÎÎÍÍÎÌÌ; // 0x14C
        public float ÌÌÎÎÌÍÌÌÍÏÌÏÏÌÎÎÏÍÎÍÌÌÎ; // 0x150
        public float ÍÍÏÎÏÏÍÍÌÌÎÌÏÌÏÌÍÎÏÎÌÏÍ; // 0x154
        public UnityEngine.LayerMask ÌÍÎÌÎÏÍÌÌÌÏÎÍÎÏÎÏÎÏÍÏÌÎ; // 0x158
        public float ÎÏÌÎÏÏÍÎÏÏÍÌÍÏÍÏÌÏÍÎÍÍÎ; // 0x15C
        public float ÍÏÌÏÍÎÎÎÏÌÌÏÏÏÌÏÎÎÍÎÏÌÍ; // 0x160
        public float ÏÏÏÌÏÍÏÌÏÌÌÌÎÍÍÍÏÍÌÌÏÍÏ; // 0x164
        public float ÏÍÎÎÎÍÌÌÍÎÎÏÍÎÍÌÎÌÏÍÎÍÍ; // 0x168
        public float ÌÌÏÏÍÌÍÍÌÎÎÌÎÌÍÌÏÌÏÏÌÎÎ; // 0x16C
        public float ÌÍÌÏÏÌÍÌÍÍÎÌÌÍÏÍÎÏÌÎÌÎÏ; // 0x170
        public float ÏÎÎÌÏÏÎÍÎÏÎÌÌÎÏÏÏÎÌÎÌÌÍ; // 0x174
        public float ÌÎÍÎÎÎÌÏÍÎÍÌÌÏÍÏÏÌÏÎÎÍÏ; // 0x178
        public float ÍÍÌÏÏÏÎÍÌÍÍÎÎÎÌÎÌÎÌÎÌÏÌ; // 0x17C
        public float ÍÎÍÍÎÎÎÏÌÎÌÌÍÏÍÏÏÌÌÎÌÏÏ; // 0x180
        public float ÌÍÏÌÏÍÌÍÌÌÌÍÏÌÌÌÎÎÎÎÏÌÌ; // 0x184
        public float ÍÎÌÌÍÎÌÎÌÌÏÎÌÎÍÌÌÎÌÎÎÏÏ; // 0x188
        public float ÏÍÍÍÎÌÎÌÏÏÌÍÎÎÌÎÎÏÍÎÍÍÍ; // 0x18C
        public float ÏÍÎÏÌÍÎÏÍÍÎÍÏÎÌÌÌÌÌÏÍÍÍ; // 0x190
        public float ÍÎÏÌÏÌÏÏÏÌÍÍÌÏÏÍÎÍÍÏÍÍÍ; // 0x194
        public float ÍÌÎÎÎÏÍÌÏÏÏÏÌÎÎÏÌÌÌÍÏÌÌ; // 0x198
        public float ÎÍÏÍÌÏÎÏÎÎÏÏÍÌÍÎÍÏÌÌÏÏÎ; // 0x19C
        public float ÌÎÎÏÌÍÌÍÎÌÌÌÎÎÏÌÌÎÏÌÍÏÎ; // 0x1A0
        public 0x664CA430 ÎÏÌÏÍÏÏÏÏÏÍÍÎÌÏÍÌÏÎÍÌÏÎ; // 0x1A4
        public 0x664CA430 ÌÏÍÍÎÎÍÌÏÏÍÍÎÏÎÎÍÍÌÏÏÌÎ; // 0x1A8
        public bool ÍÎÌÍÏÍÏÏÏÍÌÎÎÍÌÏÍÏÏÍÏÌÎ; // 0x1AC
        public 0x664CA4E0 ÎÏÌÌÎÎÌÍÌÏÍÌÎÎÎÌÎÍÍÍÎÍÏ; // 0x1B0
        public 0x664CA4E0 ÌÏÍÌÏÍÏÌÍÍÌÎÎÎÎÌÌÌÍÌÎÌÏ; // 0x1B4
        public float ÏÎÎÌÌÏÏÌÏÎÍÎÍÍÏÍÌÏÍÌÌÍÏ; // 0x1B8
        public bool ÏÌÌÌÎÎÍÌÏÌÌÏÍÍÎÏÍÌÌÏÍÍÍ; // 0x1BC
        public bool ÍÍÏÌÍÌÏÌÌÏÍÌÌÍÏÏÌÏÎÎÌÌÌ; // 0x1BD
        public bool ÍÎÎÍÍÎÏÏÎÌÌÎÎÎÍÏÌÌÎÏÍÍÏ; // 0x1BE
        public float ÎÌÌÎÎÎÍÌÍÌÌÌÏÎÏÏÏÌÏÍÍÌÎ; // 0x1C0
        public float ÍÍÌÎÏÏÎÎÎÏÏÏÌÎÎÍÎÎÍÏÏÌÎ; // 0x1C4
        public float ÏÌÎÎÌÌÍÎÍÌÎÍÌÍÍÍÌÎÎÎÌÏÎ; // 0x1C8
        public float ÍÏÍÎÎÎÌÍÍÌÌÎÏÎÌÍÌÍÍÎÍÎÍ; // 0x1CC
        public 0x664CA380 ÏÏÍÍÏÏÏÌÍÌÏÏÍÍÎÏÏÍÍÍÌÍÌ; // 0x1D0
        public 0x664CA380 ÏÎÏÎÎÌÍÌÏÏÌÌÏÍÍÍÎÏÌÎÍÎÏ; // 0x1D4
        public UnityEngine.RaycastHit[] ÏÏÍÏÎÏÎÎÏÌÌÏÎÎÎÏÎÍÌÌÌÎÎ; // 0x1D8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÎÏÌÌÏÍÍÍÍÎÍÌÎÎÍÎÍÍÌÍÏÎ; // 0x1E0
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÍÌÏÏÏÍÍÌÏÍÌÏÌÌÏÏÏÎÏÌÍÏ; // 0x1E8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÍÎÍÏÌÏÎÌÏÎÌÎÍÎÏÎÏÏÍÍÏÌ; // 0x1F0
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÎÏÌÎÏÍÎÍÍÎÌÌÏÍÏÏÏÏÍÍÏÎ; // 0x1F8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÎÍÌÏÎÍÌÎÏÌÎÏÌÏÍÍÏÎÌÏÏÍÌ; // 0x200
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÍÏÌÏÎÍÎÌÌÏÎÍÌÌÌÍÌÍÌÍÎÍÍ; // 0x208
        public float ÍÍÌÌÎÍÍÏÍÏÏÎÏÎÎÌÍÏÌÎÍÎÍ; // 0x210
        public float <ÎÏÏÏÏÌÏÏÌÌÍÍÎÏÎÌÌÌÏÍÏÎÍ>k__BackingField; // 0x214

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EA75A30
        public void RaiseCancellation(){} // RVA: 0x7FFD4EA75A50
        public void IsInvoking(){} // RVA: 0x7FFD4EA75B90
        public void CancelInvoke(){} // RVA: 0x7FFD4EA75F00
        public void Invoke(){} // RVA: 0x7FFD4EA763B0
        public void InvokeRepeating(){} // RVA: 0x7FFD4EA768B0
        public void LateUpdate(){} // RVA: 0x7FFD4EA76920
        public void OnDisable(){} // RVA: 0x7FFD4EA769B0
        public void StartCoroutine(){} // RVA: 0x7FFD4EA76A30
        public void OnApplicationPause(){} // RVA: 0x7FFD4EA76A50
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EA76B80
        public void FixedUpdate(){} // RVA: 0x7FFD4EA77000
        public void StopCoroutine(){} // RVA: 0x7FFD4EA770C0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4EA77230
        public void OnCollisionStay(){} // RVA: 0x7FFD4EA775A0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EA77850
        public void get_useGUILayout(){} // RVA: 0x7FFD4EA77860
        public void set_useGUILayout(){} // RVA: 0x7FFD4EA77950
        public void print(){} // RVA: 0x7FFD4EA77A00
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EA77B10
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4EA77B30
        public void InvokeDelayed(){} // RVA: 0x7FFD4EA77B40
        public void .ctor(){} // RVA: 0x7FFD4EA77B50
        public void Initialize(){} // RVA: 0x7FFD4EA77D90
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EA77E20
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EA77E40
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4EA77FE0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4EA78000
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4EA78190
        public void GetScriptClassName(){} // RVA: 0x7FFD4EA78610
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4EA786C0
        public void OnEnable_79175370DBA2(){} // RVA: 0x7FFD4EA78900
        public void StartManagedCoroutine(){} // RVA: 0x7FFD4EA78A20
        public void OnEnable(){} // RVA: 0x7FFD4EA77B30
        public void Start(){} // RVA: 0x7FFD4EA78D10
        public void SetSpecialBoolPropertyTrue(){} // RVA: 0x7FFD4EA78E60
        public void Update(){} // RVA: 0x7FFD4EA78E90
        public void IsObjectMonoBehaviour_2E9B75212A2F(){} // RVA: 0x7FFD4EA77E20
        public void GetInstanceID(){} // RVA: 0x7FFD4EA78EF0
        public void OnDestroy(){} // RVA: 0x7FFD4EA794D0
        public void RaiseCancel(){} // RVA: 0x7FFD4EA79590
        public void SetSpecialProperty(){} // RVA: 0x7FFD4EA795C0
        public void OnBecameVisible(){} // RVA: 0x7FFD4EA79A80
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EA79D90
        public void StopManagedCoroutine(){} // RVA: 0x7FFD4EA7AF80
        public void Awake(){} // RVA: 0x7FFD4EA7B0D0
    }

    /// <summary>Originally: ÏÌÏÍÏÎÍÎÍÍÏÍÏÏÍÏÌÍÌÌÎÎÎ</summary>
    public class FixedUpdateComponent_462D : MonoBehaviour
    {
        public UnityEngine.Transform ÌÎÎÎÎÌÎÌÌÍÎÍÎÏÌÏÏÎÏÎÏÌÍ; // 0x20
        public UnityEngine.Rigidbody ÍÎÏÍÎÌÎÍÌÍÍÎÏÍÏÍÏÎÏÌÎÎÏ; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EFAB4B0
        public void RaiseCancellation(){} // RVA: 0x7FFD4EFAB590
        public void IsInvoking(){} // RVA: 0x7FFD4EFAB670
        public void Start(){} // RVA: 0x7FFD4EFABD50
        public void Invoke(){} // RVA: 0x7FFD4EFABE30
        public void InvokeRepeating(){} // RVA: 0x7FFD4EFAC510
        public void FixedUpdate(){} // RVA: 0x7FFD4EFACBF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    /// <summary>Originally: ÏÌÎÌÍÌÍÍÌÏÌÌÎÌÏÌÏÌÏÌÍÎÌ</summary>
    public class FixedUpdateComponent_4A37 : MonoBehaviour
    {
        public float maxStepHeight; // 0x20
        public float stepUpThreshold; // 0x24
        public float offsetDistance; // 0x28
        public float distanceFromOrigin; // 0x2C
        public UnityEngine.CharacterController ÌÏÎÍÌÏÎÌÌÏÎÏÍÌÎÌÌÏÎÌÍÌÏ; // 0x30
        public UnityEngine.LayerMask groundedLayers; // 0x38
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÏÌÌÎÏÏÍÏÎÌÏÌÏÎÍÌÎÏÎÍÍÎÏ; // 0x40
        public UnityEngine.Vector3 ÏÎÍÌÌÏÍÏÏÍÏÏÏÍÏÎÌÏÌÌÏÏÌ; // 0x48

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F571920
        public void FixedUpdate(){} // RVA: 0x7FFD4F571F50
        public void IsInvoking(){} // RVA: 0x7FFD4F572580
        public void CancelInvoke(){} // RVA: 0x7FFD4F572780
        public void .ctor(){} // RVA: 0x7FFD4F572DB0
        public void Awake(){} // RVA: 0x7FFD4F572E10
        public void OnDestroy(){} // RVA: 0x7FFD4F573010
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F573640
    }

    /// <summary>Originally: ÎÎÏÎÎÎÍÏÎÍÏÌÎÌÎÏÏÌÍÎÍÏÌ</summary>
    public class FixedUpdateComponent_8DDC : MonoBehaviour
    {
        public UnityEngine.Transform _destroyCancellationToken; // 0x20
        public ÎÎÍÎÏÏÌÏÎÎÌÍÏÌÎÎÍÌÍÌÏÌÏ _useGUILayout; // 0x28
        public ÎÏÏÎÌÏÌÎÍÎÎÌÎÏÌÏÎÏÌÏÏÌÍ ÎÌÍÎÍÎÍÌÌÏÎÎÌÎÎÍÌÍÎÏÍÎÏ; // 0x30
        public ÍÌÌÏÎÌÍÌÎÌÏÌÌÍÍÍÎÍÌÎÎÏÏ ÎÎÎÏÍÌÌÎÎÌÍÍÏÎÌÌÍÎÌÍÎÏÌ; // 0x38
        public UnityEngine.CanvasGroup ÎÏÏÏÏÏÍÌÎÌÍÌÎÍÌÎÌÎÏÍÍÍÏ; // 0x40
        public bool ÎÌÎÏÏÌÏÏÍÎÍÍÏÏÎÏÎÎÏÎÌÍÏ; // 0x48
        public UnityEngine.Animator ÏÏÎÎÍÏÌÎÌÏÏÏÌÏÎÏÍÏÏÌÎÌÏ; // 0x50
        public ÌÌÎÍ ÌÎÏÏÏÎÌÎÍÏÍÏÎÍÏÍÏÌÌÌÍÍÎ; // 0x58
        public ÌÌÎÍ ÏÏÌÎÍÎÎÌÍÏÍÍÏÎÍÌÌÍÌÌÎÏÏ; // 0x5C
        public UnityEngine.Transform ÎÏÏÎÎÌÌÎÍÍÏÎÎÌÍÎÏÏÌÏÍÏÌ; // 0x60
        public UnityEngine.Transform ÍÍÌÌÎÏÌÎÌÎÎÎÎÍÍÏÏÏÌÌÍÏÏ; // 0x68
        public UnityEngine.Transform ÎÌÍÌÏÌÌÏÏÎÏÌÍÌÎÍÏÎÏÌÎÏÏ; // 0x70
        public UnityEngine.Transform ÌÌÎÌÎÏÌÎÌÎÍÏÍÏÍÏÌÏÍÏÎÏÌ; // 0x78
        public float ÏÌÍÏÎÍÍÍÎÏÏÎÎÌÌÎÍÌÍÎÍÎÌ; // 0x80
        public float ÍÎÏÍÎÌÍÍÌÌÌÍÌÏÍÍÏÌÏÌÎÏÎ; // 0x84
        public UnityEngine.Quaternion ÎÌÏÍÏÏÌÏÌÎÍÌÍÍÏÍÌÍÎÎÍÏÍ; // 0x88
        public UnityEngine.Quaternion ÎÍÎÎÎÍÎÏÍÍÌÏÎÎÏÌÏÎÏÍÎÎÎ; // 0x98
        public UnityEngine.Vector3 offset; // 0xA8
        public bool autoSelectHand; // 0xB4
        public bool preferLeft; // 0xB5
        public bool tweenToFaceUser; // 0xB6
        public bool disableOnGrasperHeld; // 0xB7
        public bool graspDisableOppositeHand; // 0xB8
        public L ÌÎÍÌÌÌÍÎÎÌÌÏÌÎÎÎÎÎÌÌÌÎÎ; // 0xBC
        public float ÎÌÌÌÎÍÌÎÌÍÏÏÏÌÌÌÏÏÏÎÎÍÍ; // 0xC0
        public float ÍÎÌÏÎÍÎÎÎÍÏÎÎÎÎÏÏÍÏÌÏÏÌ;
        public bool ÏÌÎÌÎÎÍÍÏÍÍÎÎÎÎÎÍÏÏÏÌÍÎ; // 0xC4
        public float ÍÌÍÍÌÍÍÌÌÍÎÏÍÎÍÎÌÏÍÎÏÏÏ; // 0xC8
        public float ÎÌÌÏÎÎÌÎÌÏÌÍÍÏÍÏÌÏÌÍÎÎÍ;
        public float ÏÏÎÏÎÏÎÌÎÏÏÌÏÍÍÎÏÍÌÍÏÍÍ; // 0xCC
        public float ÎÎÍÏÍÎÏÍÏÏÌÎÌÎÌÏÎÌÎÎÍÏÌ;
        public float ÏÌÍÌÌÎÌÎÌÍÏÍÏÏÍÏÍÏÏÎÎÎÎ;
        public float ÌÎÎÌÎÎÏÌÌÌÏÍÏÎÌÎÌÎÍÏÌÏÎ;
        public float ÏÍÏÎÌÏÏÏÍÏÌÍÌÌÎÏÌÏÌÎÍÌÏ; // 0xD0
        public float ÎÏÎÏÌÍÌÎÍÍÎÏÏÎÌÌÌÍÌÏÎÏÎ; // 0xD4
        public UnityEngine.Vector3 ÌÌÍÏÏÍÌÍÌÏÍÌÌÌÎÎÎÏÌÎÌÍÎ; // 0xD8
        public float ÌÏÏÌÏÌÌÍÏÎÎÏÏÌÍÎÎÏÏÍÏÎÎ;
        public float ÍÏÎÌÌÎÏÍÎÍÎÏÍÌÎÏÏÏÎÎÍÎÍ;

        // ── Methods ──
        public void get_NumberNegativePattern(){} // RVA: 0x7FFD4EBCB780
        public void RaiseCancellation(){} // RVA: 0x7FFD4EBCB790
        public void IsInvoking(){} // RVA: 0x7FFD4EBCB960
        public void .ctor(){} // RVA: 0x7FFD4EBCBE30
        public void Initialize(){} // RVA: 0x7FFD4EBCBE90
        public void InvokeRepeating(){} // RVA: 0x7FFD4EBCBEC0
        public void CancelInvoke(){} // RVA: 0x7FFD4EBCC1E0
        public void FixedUpdate_15280F3D5635(){} // RVA: 0x7FFD4EBCC410
        public void get_AccelInput(){} // RVA: 0x7FFD4E3626B0
        public void LateUpdate(){} // RVA: 0x7FFD4EBCC7F0
        public void OnDisable(){} // RVA: 0x7FFD4EBCC870
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EBCCA20
        public void StopCoroutine(){} // RVA: 0x7FFD4EBCE300
        public void Initialize_2108254897D2(){} // RVA: 0x7FFD4EBCE640
        public void Awake(){} // RVA: 0x7FFD4EBCEC30
        public void OnDestroy(){} // RVA: 0x7FFD4EBCEF60
        public void get_useGUILayout(){} // RVA: 0x7FFD4EBCB780
        public void FixedUpdate(){} // RVA: 0x7FFD4EBCF280
        public void print(){} // RVA: 0x7FFD4EBCF800
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EBCFD50
    }

    /// <summary>Originally: ÎÍÏÏÏÏÌÌÏÏÍÏÎÏÏÌÏÏÏÎÍÏÏ</summary>
    public class FixedUpdateComponent_92B7 : MonoBehaviour
    {
        public float ÌÏÌÍÎÎÏÏÏÌÎÌÎÍÎÍÍÏÍÏÏÌÏ; // 0x20
        public UnityEngine.GameObject ÌÎÏÎÎÎÏÌÏÎÌÎÌÍÎÍÍÍÌÎÎÌÍ; // 0x28
        public UnityEngine.GameObject ÎÍÌÍÌÌÍÎÍÏÍÍÎÍÏÎÎÏÏÎÌÎÌ; // 0x30
        public bool ÌÏÏÌÍÍÎÌÍÎÎÎÌÎÏÎÍÏÍÌÌÍÍ; // 0x38
        public bool ÍÎÍÍÏÌÍÍÍÍÎÍÍÏÌÍÍÎÏÏÎÎÍ; // 0x39

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E7C7150
        public void FixedUpdate(){} // RVA: 0x7FFD4E7C7150
        public void Start(){} // RVA: 0x7FFD4E7C7490
        public void CancelInvoke(){} // RVA: 0x7FFD4E7C7600
        public void Invoke(){} // RVA: 0x7FFD4E7C7930
        public void InvokeRepeating(){} // RVA: 0x7FFD4E7C7AA0
        public void OnApplicationPause(){} // RVA: 0x7FFD4E7C7C10
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4E7C7D80
    }

}