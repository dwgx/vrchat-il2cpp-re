// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Rendering
// Classes: 23
// Methods: 385

namespace VRC.Rendering
{
    /// <summary>Originally: ÏÎÍÎÍÎÌÌÏÍÌÌÌÎÎÍÏÏÏÍÎÌÎ</summary>
    public class Camera : ValueType
    {
        public bool f_3B6; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82BC9920
        public void InternalEquals(){} // RVA: 0x7FFE82BC9930
        public void DefaultEquals(){} // RVA: 0x7FFE82BC9920
        public void GetHashCode(){} // RVA: 0x7FFE82BC9920
        public void InternalGetHashCode(){} // RVA: 0x7FFE82BC9920
        public void ToString(){} // RVA: 0x7FFE82BC9920
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82BC9930
    }

    /// <summary>Originally: ÌÎÏÏÏÌÍÌÌÍÎÍÏÎÍÎÏÎÍÍÎÍÏ</summary>
    public class CameraClearFlags : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE89D6DB20
        public void Equals(){} // RVA: 0x7FFE89D6DD00
        public void GetHashCode(){} // RVA: 0x7FFE89D6DEE0
        public void op_Implicit(){} // RVA: 0x7FFE89D6E0B0
        public void CompareBaseObjects(){} // RVA: 0x7FFE89D6E290
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE89D6E470
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÎÎÌÎÏÎÍÌÌÌÏÌÍÏÌÍÏÍÏÎÌÏÌ</summary>
    public class CameraPositionCanWrite_2060 : Stream
    {
        public ÎÎÍÎÍÏÏÎÌÎÍÍÌÎÎÏÏÏÌÍÎÌÎ _length; // 0x28
        public object field_1; // 0x81F
        public object field_2; // 0x820
        public object field_3; // 0x821
        public object field_4; // 0x822
        public object field_5; // 0x823

        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE827BED80
        public void .ctor(){} // RVA: 0x7FFE827BF230 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFE827BEE40
        public void Flush(){} // RVA: 0x7FFE827BEEE0
        public void get_Length(){} // RVA: 0x7FFE827BEF80
        public void Read(){} // RVA: 0x7FFE827BEFE0
        public void get_CanSeek(){} // RVA: 0x7FFE827BF080
        public void set_CanSeek(){} // RVA: 0x7FFE827BF0B0
        public void Dispose(){} // RVA: 0x7FFE827BF4B0
        public void get_Position(){} // RVA: 0x7FFE827BF580
        public void SetLength(){} // RVA: 0x7FFE827BF5E0
        public void CopyToAsync(){} // RVA: 0x7FFE827BF640
        public void set_CanWrite(){} // RVA: 0x7FFE827BF640
        public void BeginRead(){} // RVA: 0x7FFE827BF660
        public void get_CanWrite(){} // RVA: 0x7FFE827BF700
        public void CopyTo(){} // RVA: 0x7FFE827BF730
        public void Close(){} // RVA: 0x7FFE827BF640
        public void EndRead(){} // RVA: 0x7FFE827BF8B0
        public void Seek(){} // RVA: 0x7FFE827BF940
        public void set_CanRead(){} // RVA: 0x7FFE827BF640
        public void set_Position(){} // RVA: 0x7FFE827BF9A0
        public void get_CanRead(){} // RVA: 0x7FFE827BFA00
        public void FlushAsync(){} // RVA: 0x7FFE827BFA30
        public void EndWrite(){} // RVA: 0x7FFE827BFBB0
    }

    /// <summary>Originally: ÎÎÍÎÍÏÏÎÌÎÍÍÌÎÎÏÏÏÌÍÎÌÎ</summary>
    public class CameraPosition_D82A : Stream
    {
        public int _canSeek;
        public System.IO.Stream _length; // 0x28
        public dFixup.alIlluminationFlags _position; // 0x30
        public bool _canWrite; // 0x34
        public ÌÍÏÍÎÍÍÎÍÍÌÍÏÌÌÌÍÏÎÏÏÎÍ _canRead; // 0x38
        public ÏÏÎÏÎÍÌÎÍÎÎÍÌÎÎÍÏÏÍÎÍÌÌ f_759; // 0x40

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFE827B7E30
        public void Close(){} // RVA: 0x7FFE827B7FE0
        public void BeginRead_937B3BD09221(){} // RVA: 0x7FFE827B8070
        public void Dispose(){} // RVA: 0x7FFE827B80F0
        public void BeginWrite(){} // RVA: 0x7FFE827B8360
        public void Dispose_FEA41148FB9F(){} // RVA: 0x7FFE827B85B0
        public void Cleanup(){} // RVA: 0x7FFE827B86E0
        public void Write(){} // RVA: 0x7FFE827B8760
        public void get_ReadTimeout(){} // RVA: 0x7FFE827B88E0
        public void set_ReadTimeout(){} // RVA: 0x7FFE827B8A10
        public void BeginRead(){} // RVA: 0x7FFE827B8A60
        public void EndWrite(){} // RVA: 0x7FFE827B8D70
        public void CopyToAsync(){} // RVA: 0x7FFE827B8EA0
        public void set_CanSeek(){} // RVA: 0x7FFE827B9090
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void Flush(){} // RVA: 0x7FFE827B9200
        public void CopyTo(){} // RVA: 0x7FFE827B9210
        public void Seek(){} // RVA: 0x7FFE827B9440
        public void set_Length(){} // RVA: 0x7FFE827B94A0
        public void get_Length(){} // RVA: 0x7FFE827B9520
        public void get_Position(){} // RVA: 0x7FFE827B9580
        public void Read(){} // RVA: 0x7FFE827B95E0
        public void GetLength(){} // RVA: 0x7FFE827B9770
        public void FlushAsync(){} // RVA: 0x7FFE827B98E0
        public void set_CanWrite(){} // RVA: 0x7FFE827B9A30
        public void Initialize(){} // RVA: 0x7FFE827B9AB0
        public void SetLength(){} // RVA: 0x7FFE827B9B30
        public void set_Position(){} // RVA: 0x7FFE827B9B90
        public void get_CanWrite(){} // RVA: 0x7FFE827B9BF0
        public void ReadAsync(){} // RVA: 0x7FFE827B9C20
        public void set_CanWrite_3FE4372BEEA3(){} // RVA: 0x7FFE827B9F00
        public void BeginEndReadAsync(){} // RVA: 0x7FFE810FB320
        public void get_Position_B401484128FD(){} // RVA: 0x7FFE827B9FE0
        public void BeginWriteInternal(){} // RVA: 0x7FFE81129130
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7FFE827BA150
        public void RunReadWriteTask(){} // RVA: 0x7FFE827BA280
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFE827BA370
        public void .ctor(){} // RVA: 0x7FFE827BA920 | overloaded x2
        public void EndRead(){} // RVA: 0x7FFE827BA940
        public void get_CanRead(){} // RVA: 0x7FFE827BAAA0
    }

    /// <summary>Originally: ÏÎÎÍÍÌÍÎÎÎÌÌÌÏÍÏÏÍÍÎÍÏÍ</summary>
    public class CameraType
    {
        // ── Unresolved (hash) ──
        public void m_4D7(){} // RVA: 0x7FFE80E2E2E0
    }

    /// <summary>Originally: ÌÏÍÌÌÌÏÌÍÌÌÌÌÌÏÌÎÍÍÌÏÎÌ</summary>
    public class CameraVideoStreamFrameHeader_t : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DD8470
        public void InternalEquals(){} // RVA: 0x7FFE82DD85B0
        public void DefaultEquals(){} // RVA: 0x7FFE82DD86F0
        public void GetHashCode(){} // RVA: 0x7FFE82DD8760
        public void Dispose(){} // RVA: 0x7FFE82DD88A0
        public void Cleanup(){} // RVA: 0x7FFE82DD8910
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DD8980
    }

    /// <summary>Originally: ÍÎÎÏÌÎÍÎÏÍÎÎÍÏÏÎÏÌÍÏÏÎÌ</summary>
    public class CameracamComponent_BC6D : MonoBehaviour
    {
        public UnityEngine.Camera cam; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE815A6A00
        public void RaiseCancellation(){} // RVA: 0x7FFE815A6A20
        public void IsInvoking(){} // RVA: 0x7FFE815A6A40
        public void OnDestroy(){} // RVA: 0x7FFE815A6BF0
        public void Invoke(){} // RVA: 0x7FFE815A6D00
        public void InvokeRepeating(){} // RVA: 0x7FFE815A6EB0
        public void CancelInvoke(){} // RVA: 0x7FFE815A7060
        public void OnBecameInvisible(){} // RVA: 0x7FFE815A7210
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE815A73C0
        public void StartCoroutine(){} // RVA: 0x7FFE815A7570
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE815A7720
    }

    /// <summary>Originally: ÏÏÎÍÏÏÍÌÎÎÍÏÎÌÍÍÏÎÌÌÍÍÌ</summary>
    public class Camerak__BackingFieldComponentSibling_574D : Camerak__BackingFieldComponent_4DA6
    {
        public UnityEngine.Transform orbitParent; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81868840
        // ── Unresolved (hash) ──
        public void m_8A8(){} // RVA: 0x7FFE818685F0
        public void m_044(){} // RVA: 0x7FFE818686C0
        public void m_90C(){} // RVA: 0x7FFE81199370
    }

    /// <summary>Originally: ÏÌÍÌÎÌÏÏÎÎÏÌÏÍÌÏÌÍÌÌÎÍÍ</summary>
    public class Camerak__BackingFieldComponentSibling_93E3 : Camerak__BackingFieldComponent_4DA6
    {
        public float f_7D1;
        public float f_C91; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE818688A0
        public void Initialize(){} // RVA: 0x7FFE81868900
        public void .cctor(){} // RVA: 0x7FFE81868C90
        // ── Unresolved (hash) ──
        public void m_90C(){} // RVA: 0x7FFE81176730
        public void m_49B(){} // RVA: 0x7FFE81868CD0
        public void m_CE8(){} // RVA: 0x7FFE81868D70
    }

    /// <summary>Originally: ÎÏÏÍÌÌÌÎÍÏÍÍÍÌÏÌÎÏÎÍÏÌÍ</summary>
    public class Camerak__BackingFieldComponentSibling_C62C
    {
        // ── 13 unresolved (hash) ──
        public void m_D36(){} // RVA: 0x7FFE80E460A0
        public void m_CFB(){} // RVA: 0x7FFE80E53B80
        public void m_8A8(){} // RVA: 0x7FFE80E460A0
        public void m_382(){}
        public void m_BD2(){}
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÍÎÍÌÏÎÌÏÍÍÎÎÌÍÌÎÌÎÎÎÍÎÌ</summary>
    public class Camerak__BackingFieldComponent_4DA6 : MonoBehaviour
    {
        public UnityEngine.GameObject _m_CancellationTokenSource; // 0x20
        public UnityEngine.RenderTexture f_1FB; // 0x28
        public UnityEngine.Transform f_DEE; // 0x30
        public float f_277; // 0x38
        public UnityEngine.Camera cam; // 0x40
        public UnityEngine.Transform previewParent; // 0x48
        public UnityEngine.Vector2 f_7D9; // 0x50

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81865790
        public void RaiseCancellation(){} // RVA: 0x7FFE81865860
        public void IsInvoking(){} // RVA: 0x7FFE81865B50
        public void CancelInvoke(){} // RVA: 0x7FFE810FCE90
        public void Invoke(){} // RVA: 0x7FFE8130ACF0
        public void InvokeRepeating(){} // RVA: 0x7FFE81865BB0
        public void OnApplicationPause(){} // RVA: 0x7FFE81865DC0
        public void Awake(){} // RVA: 0x7FFE81865FD0
        public void StartCoroutine(){} // RVA: 0x7FFE811290C0
        public void Start(){} // RVA: 0x7FFE8130A000
        public void FixedUpdate(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE818661F0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void StopCoroutine(){} // RVA: 0x7FFE81866240
        public void OnDestroy(){} // RVA: 0x7FFE81866490
        public void StopAllCoroutines(){} // RVA: 0x7FFE818664B0
        public void get_useGUILayout(){} // RVA: 0x7FFE81865B50
        public void set_useGUILayout(){} // RVA: 0x7FFE81866520
        public void print(){} // RVA: 0x7FFE81866810
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE81866830
        public void Dispose(){} // RVA: 0x7FFE81866850
        public void Cleanup(){} // RVA: 0x7FFE81176730
        public void OnTriggerEnter(){} // RVA: 0x7FFE81129130
        public void OnTriggerStay(){} // RVA: 0x7FFE818668F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE81866A20
        public void StartCoroutineManaged(){} // RVA: 0x7FFE81866C70
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE81176730
        public void StopCoroutineManaged(){} // RVA: 0x7FFE81866D80
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE811290D0
        public void GetScriptClassName(){} // RVA: 0x7FFE81178740
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE8144E200
        // ── Unresolved (hash) ──
        public void m_0AF(){} // RVA: 0x7FFE81176730
    }

    /// <summary>Originally: ÏÌÏÌÌÎÏÍÌÎÌÍÌÍÍÌÎÏÏÏÏÏÌ</summary>
    public class Camerak__BackingFieldComponent_7F31 : MonoBehaviour
    {
        public ÏÌÏÌÌÎÏÍÌÎÌÍÌÍÍÌÎÏÏÏÏÏÌ _m_CancellationTokenSource;
        public ÍÏÏÎÍÍÏÍÍÍÏÌÎÏÌÍÏÎÎÏÏÎÏ f_2F2; // 0x20
        public ÍÌÏÏÍÎÌÏÏÌÌÍÎÍÏÍÌÏÏÍÏÌÎ f_BFC; // 0x28
        public ÎÏÎÌÏÏÍÌÏÎÌÍÏÎÎÍÌÌÏÍÍÏÎ f_57A; // 0x30
        public ÌÏÍÎÌÏÍÍÏÌÌÌÍÍÎÌÎÏÍÌÌÍÎ f_97D; // 0x38
        public ÎÎÏÏÍÍÌÌÍÎÏÍÏÍÌÌÎÍÍÌÍÌÍ f_DFC; // 0x40
        public ÏÎÏÏÏÎÎÌÍÎÌÍÎÍÌÏÏÍÌÌÌÌÏ f_DF5; // 0x48
        public ÌÍÍÏÎÏÌÌÌÎÌÎÏÎÍÍÏÏÌÍÎÏÍ f_1F0; // 0x50
        public ÌÍÎÎÍÎÍÍÎÍÌÎÍÏÌÎÏÌÍÍÌÎÏ f_971; // 0x58
        public UnityEngine.Transform f_BEE; // 0x60
        public VRC.SDKBase.VRC_Pickup f_008; // 0x68
        public VRC.SDKBase.VRC_Pickup f_150; // 0x70
        public UnityEngine.GameObject lensUpIndicator; // 0x78
        public float f_7D0; // 0x80
        public UnityEngine.Material f_EB0; // 0x88
        public UnityEngine.Material f_83D; // 0x90
        public UnityEngine.Transform f_6F8; // 0x98
        public UnityEngine.MeshRenderer lensRenderer; // 0xA0
        public UnityEngine.MeshRenderer printLensRenderer; // 0xA8
        public UnityEngine.Material[] f_C5B; // 0xB0
        public UnityEngine.Material[] f_BF0; // 0xB8
        public UnityEngine.GameObject lensParent; // 0xC0
        public UnityEngine.Material f_59C; // 0xC8
        public UnityEngine.AudioSource speakerOnViewfinder; // 0xD0
        public UnityEngine.AudioSource speakerOnLens; // 0xD8
        public UnityEngine.AudioClip buttonSound; // 0xE0

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8161BFB0
        public void RaiseCancellation(){} // RVA: 0x7FFE8161C050
        public void IsInvoking(){} // RVA: 0x7FFE8161C0A0
        public void CancelInvoke(){} // RVA: 0x7FFE81129890
        public void Invoke(){} // RVA: 0x7FFE8161C4A0
        public void InvokeRepeating(){} // RVA: 0x7FFE8161C650
        public void OnApplicationPause(){} // RVA: 0x7FFE8161C670
        public void OnApplicationQuit(){} // RVA: 0x7FFE8144E200
        public void StartCoroutine(){} // RVA: 0x7FFE8161C6C0
        public void OnBecameInvisible(){} // RVA: 0x7FFE8161C7F0
        public void OnCollisionEnter(){} // RVA: 0x7FFE811C3500
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8161CCE0
        public void StopCoroutine(){} // RVA: 0x7FFE8161CDF0
        public void OnTriggerEnter(){} // RVA: 0x7FFE8161CE50
        public void OnTriggerStay(){} // RVA: 0x7FFE811290C0
        public void StopAllCoroutines(){} // RVA: 0x7FFE8161D050
        public void get_useGUILayout(){} // RVA: 0x7FFE8161D750
        public void LateUpdate(){} // RVA: 0x7FFE8161DA30
        public void print(){} // RVA: 0x7FFE8161DAD0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE81129130
        public void OnDestroy(){} // RVA: 0x7FFE8161DAE0
        public void InvokeDelayed(){} // RVA: 0x7FFE8161DDC0
        public void OnBecameVisible(){} // RVA: 0x7FFE8161E080
        public void InitializeCamera(){} // RVA: 0x7FFE8161E170
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE8161E220
        public void StartCoroutineManaged(){} // RVA: 0x7FFE8161E310
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE81437330
        public void StopCoroutineManaged(){} // RVA: 0x7FFE8161E8D0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE8161E8F0
        public void GetScriptClassName(){} // RVA: 0x7FFE8161EA90
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE8161F480
        public void GetCameraTransform(){} // RVA: 0x7FFE8161FF00
        public void SetCameraEnabled(){} // RVA: 0x7FFE8161FF10
        public void GetCameraField(){} // RVA: 0x7FFE81176740
        public void SetCameraField(){} // RVA: 0x7FFE811C3510
        public void RefreshCameraView(){} // RVA: 0x7FFE81620130
        public void GetMainCamera(){} // RVA: 0x7FFE816208F0
        public void .ctor(){} // RVA: 0x7FFE81622D80
        public void Initialize(){} // RVA: 0x7FFE81622DF0
        public void .cctor(){} // RVA: 0x7FFE81625750
        public void Awake(){} // RVA: 0x7FFE81625F40
        public void OnEnable(){} // RVA: 0x7FFE816266D0
        public void FixedUpdate(){} // RVA: 0x7FFE816268F0
        // ── 63 unresolved (hash) ──
        public void m_DF7(){} // RVA: 0x7FFE81621370
        public void m_BD0(){} // RVA: 0x7FFE81622400
        public void m_7B8(){} // RVA: 0x7FFE816213B0
        public void m_EB3(){} // RVA: 0x7FFE816214C0
        public void m_B59(){} // RVA: 0x7FFE8119C0E0
        // ... 58 more unresolved methods
    }

    /// <summary>Originally: ÎÌÏÍÏÍÏÌÍÍÌÎÍÍÏÎÎÌÏÎÎÌÌ</summary>
    public class CameralineRendererinvalidCompoSibling_46F3 : CameralineRendererinvalidComponent_7355
    {
        public UnityEngine.Renderer imageRenderer; // 0xC8
        public float raycastOffset; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8153E3F0
        public void Initialize(){} // RVA: 0x7FFE8153E430
        // ── 12 unresolved (hash) ──
        public void m_7DE(){} // RVA: 0x7FFE8153CD80
        public void m_992(){} // RVA: 0x7FFE8153D020
        public void m_B4C(){} // RVA: 0x7FFE8153D880
        public void m_942(){} // RVA: 0x7FFE8153D8A0
        public void m_71F(){} // RVA: 0x7FFE8153D990
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÍÏÏÎÌÏÏÍÍÍÌÎÍÎÏÌÌÏÍÎÏÌÏ</summary>
    public class CameralineRendererinvalidComponent_7355 : MonoBehaviour
    {
        public UnityEngine.GameObject cursor; // 0x20
        public UnityEngine.GameObject arrow; // 0x28
        public UnityEngine.GameObject invalid; // 0x30
        public UnityEngine.GameObject outline; // 0x38
        public UnityEngine.LineRenderer lineRenderer; // 0x40

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81F16960
        public void RaiseCancellation(){} // RVA: 0x7FFE80E2DCF0
        public void IsInvoking(){} // RVA: 0x7FFE8186F320
        public void CancelInvoke(){} // RVA: 0x7FFE8175AC90
        public void Invoke(){} // RVA: 0x7FFE81F16A90
        public void Start(){} // RVA: 0x7FFE81F16B90
        public void FixedUpdate(){} // RVA: 0x7FFE81F16DC0
        public void StartCoroutine(){} // RVA: 0x7FFE81F17080 | overloaded x2
        public void Update(){} // RVA: 0x7FFE81F17300
        public void LateUpdate(){} // RVA: 0x7FFE81F17560
        public void StopCoroutine(){} // RVA: 0x7FFE81F17E80 | overloaded x2
        public void OnBecameVisible(){}
        public void OnBecameInvisible(){} // RVA: 0x7FFE81F18140
        public void StopAllCoroutines(){} // RVA: 0x7FFE81F18160
        public void get_useGUILayout(){} // RVA: 0x7FFE81F18170
        public void .ctor(){} // RVA: 0x7FFE81F18500
    }

    /// <summary>Originally: ÌÍÏÌÌÏÏÎÎÎÏÎÏÌÎÏÌÍÎÏÍÏÌ</summary>
    public class CameraupIndicatorMeshscreenshoSibling_4144
    {
        // ── 15 unresolved (hash) ──
        public void m_57C(){} // RVA: 0x7FFE80E2E2E0
        public void m_6B8(){} // RVA: 0x7FFE80E460A0
        public void m_A81(){} // RVA: 0x7FFE80E2E2E0
        public void m_AEB(){} // RVA: 0x7FFE80E460A0
        public void m_77A(){} // RVA: 0x7FFE80E2E2E0
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÌÎÏÏÏÎÍÌÎÎÌÌÎÍÌÍÏÍÎÍÏÌÌ</summary>
    public class CameraupIndicatorMeshscreenshotSoundComponent_32E8 : MonoBehaviour
    {
        public UnityEngine.GameObject remoteShape; // 0x20
        public UnityEngine.MeshRenderer lensMesh; // 0x28
        public UnityEngine.MeshRenderer upIndicatorMesh; // 0x30
        public UnityEngine.AudioSource Speaker; // 0x38
        public UnityEngine.AudioClip screenshotSound; // 0x40
        public UnityEngine.AudioClip timerSound; // 0x48
        public UnityEngine.LineRenderer lineRender; // 0x50
        public UnityEngine.LineRenderer lineRenderCone; // 0x58

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8162AFA0
        public void RaiseCancellation(){} // RVA: 0x7FFE8162B150
        public void IsInvoking(){} // RVA: 0x7FFE8162B8A0
        public void CancelInvoke(){} // RVA: 0x7FFE81318010
        public void OnDestroy(){} // RVA: 0x7FFE8162B950
        public void InvokeRepeating(){} // RVA: 0x7FFE811C3590
        public void OnApplicationQuit(){} // RVA: 0x7FFE8162BCF0
        public void OnBecameVisible(){} // RVA: 0x7FFE8162BD10
        public void StartCoroutine(){} // RVA: 0x7FFE8162C170
        public void OnCollisionEnter(){} // RVA: 0x7FFE8162C320
        public void OnCollisionStay(){} // RVA: 0x7FFE8162C330
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8162C790
        public void StopCoroutine(){} // RVA: 0x7FFE8162C7D0
        public void .cctor(){} // RVA: 0x7FFE8162CE10
        public void LateUpdate(){} // RVA: 0x7FFE8162CEB0
        public void StopAllCoroutines(){} // RVA: 0x7FFE8162DD50
        public void get_useGUILayout(){} // RVA: 0x7FFE813A0830
        public void Start(){} // RVA: 0x7FFE8162DE40
        public void print(){} // RVA: 0x7FFE8162E2A0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE8162E6C0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE8162E820
        public void InvokeDelayed(){} // RVA: 0x7FFE8162EC40
        public void OnCollisionExit(){} // RVA: 0x7FFE8162F2E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE811C3590
        public void .ctor(){} // RVA: 0x7FFE81630180
        public void Initialize(){} // RVA: 0x7FFE81630220
        public void StopCoroutineManaged(){} // RVA: 0x7FFE81199370
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE81317920
        public void GetScriptClassName(){} // RVA: 0x7FFE81630230
        public void OnDisable(){} // RVA: 0x7FFE816302E0
        public void OnTriggerStay(){} // RVA: 0x7FFE813A1DA0
        public void OnTriggerExit(){} // RVA: 0x7FFE81630410
        // ── Unresolved (hash) ──
        public void m_D51(){} // RVA: 0x7FFE81199370
        public void m_125(){} // RVA: 0x7FFE81630CA0
    }

    /// <summary>Originally: ÍÍÏÏÏÍÍÎÎÎÌÍÏÎÍÌÏÏÎÎÍÎÎ</summary>
    public class ComputeShader : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81C683E0
        public void Equals(){} // RVA: 0x7FFE81C68490
        public void GetHashCode(){} // RVA: 0x7FFE81C68540
        public void op_Implicit(){} // RVA: 0x7FFE81C685F0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81C686A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81C68750
        public void get_name(){} // RVA: 0x7FFE81C68800
        public void set_name(){} // RVA: 0x7FFE81C688B0
    }

    /// <summary>Originally: ÌÍÏÌÍÏÌÎÍÍÎÎÏÏÎÏÏÌÍÌÎÎÍ</summary>
    public class CoreCameraValues : Object
    {
        public ÌÎÏÌÍÎÌÍÍÎÎÍÎÏÌÍÎÍÏÍÍÏÏ _cC2B;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82DA79D0
        public void Equals(){} // RVA: 0x7FFE82DA7BA0
    }

    /// <summary>Originally: ÎÏÌÍÎÌÎÌÍÌÌÌÏÍÍÌÎÌÏÍÎÏÎ</summary>
    public class CustomRenderTexture : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8143DEA0
        public void Equals(){} // RVA: 0x7FFE8143E0A0
        public void GetHashCode(){} // RVA: 0x7FFE8143E2A0
        public void op_Implicit(){} // RVA: 0x7FFE8143E480
        public void CompareBaseObjects(){} // RVA: 0x7FFE8143E660
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8143E840
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8143EA20
    }

    /// <summary>Originally: ÌÎÍÍÍÍÎÌÏÏÎÎÎÏÌÍÎÌÏÌÎÍÎ</summary>
    public class CustomRenderTextureInitializationSource : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82C93E10
        public void InternalEquals(){} // RVA: 0x7FFE82C93F30
        public void DefaultEquals(){} // RVA: 0x7FFE82C94050
        public void Dispose(){} // RVA: 0x7FFE82C94170
        public void Cleanup(){} // RVA: 0x7FFE82C941C0
        public void GetHashCode(){} // RVA: 0x7FFE82C942E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82C94400
        public void ToString(){} // RVA: 0x7FFE82C94520
        public void ValidateStructPointers(){} // RVA: 0x7FFE82C94640
    }

    /// <summary>Originally: ÌÌÌÏÌÍÏÎÌÎÏÌÌÎÍÍÍÍÍÏÌÎÍ</summary>
    public class CustomRenderTextureManager : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82416620
        public void Equals(){} // RVA: 0x7FFE824166F0
        public void GetHashCode(){} // RVA: 0x7FFE824167C0
        public void op_Implicit(){} // RVA: 0x7FFE82416890
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82416960
        public void GetCachedPtr(){} // RVA: 0x7FFE82416A30
    }

    /// <summary>Originally: ÍÍÍÏÏÍÏÎÏÌÍÎÍÏÏÏÌÎÍÌÍÌÏ</summary>
    public class CustomRenderTextureUpdateMode
    {
    }

    /// <summary>Originally: ÍÍÍÌÌÏÎÎÎÏÏÎÏÏÏÌÎÏÌÎÏÎÌ</summary>
    public class CustomRenderTextureUpdateZone : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8143DA20
        public void Equals(){} // RVA: 0x7FFE8143DAE0
        public void GetHashCode(){} // RVA: 0x7FFE8143DBA0
        public void op_Implicit(){} // RVA: 0x7FFE8143DC60
        public void CompareBaseObjects(){} // RVA: 0x7FFE8143DD20
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8143DDE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}