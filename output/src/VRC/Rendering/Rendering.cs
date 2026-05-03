// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Rendering
// Classes: 37
// Methods: 909

namespace VRC.Rendering
{
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

    /// <summary>Originally: ÌÍÍÎÍÍÏÏÏÎÎÏÍÎÌÎÎÍÍÌÍÌÌ</summary>
    public class EffectmaterialForRenderingGetMaterial_3AA3 : UIlocalizableStringcopyPrefHeightTo_84F2
    {
        public ÎÎÌÎÍÏÌÎÏÏÍÎÌÌÎÏÎÏÏÌÎÏÎ _materialForRendering; // 0x7E8

        // ── Methods ──
        public void set_materialForRendering(){} // RVA: 0x7FFE81769D70
        public void get_materialForRendering(){} // RVA: 0x7FFE8176A920
        public void .ctor(){} // RVA: 0x7FFE8176AD40
        public void Initialize(){} // RVA: 0x7FFE8176AD90
        public void Rebuild(){} // RVA: 0x7FFE8176AF40
        public void GetMaterial(){} // RVA: 0x7FFE8176B260
        // ── Unresolved (hash) ──
        public void m_526(){} // RVA: 0x7FFE81769F70
        public void m_9B7(){} // RVA: 0x7FFE8176A360
        public void m_C29(){} // RVA: 0x7FFE8176A540
        public void m_C75(){} // RVA: 0x7FFE8176A940
        public void m_D84(){} // RVA: 0x7FFE8176B0B0
        public void m_48B(){} // RVA: 0x7FFE8176B3F0
        public void m_535(){} // RVA: 0x7FFE8176B7F0
    }

    /// <summary>Originally: ÎÎÌÍÏÏÏÎÍÍÏÍÌÎÏÎÌÌÎÍÍÏÎ</summary>
    public class MobileOpaqueShaderComponent_581C : MonoBehaviour
    {
        public UnityEngine.Shader MobileOpaqueShader; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81464570
        public void RaiseCancellation(){} // RVA: 0x7FFE8243D340
        public void IsInvoking(){} // RVA: 0x7FFE81464570
        public void OnApplicationQuit(){} // RVA: 0x7FFE8243F2F0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE8243E090
        public void .cctor(){} // RVA: 0x7FFE8243E540
        public void OnEnable(){} // RVA: 0x7FFE8243E640
        public void Start(){} // RVA: 0x7FFE8243E6F0
        public void StartCoroutine(){} // RVA: 0x7FFE8243E7A0
        public void Update(){} // RVA: 0x7FFE8243EB00
        public void LateUpdate(){} // RVA: 0x7FFE8243ED00
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8243F1B0
        public void OnDestroy(){} // RVA: 0x7FFE8243F2E0
        public void StopCoroutine(){} // RVA: 0x7FFE811C3500
        public void StopAllCoroutines(){} // RVA: 0x7FFE8243F650
        public void get_useGUILayout(){} // RVA: 0x7FFE8243F2E0
        public void set_useGUILayout(){} // RVA: 0x7FFE81199370
        public void print(){} // RVA: 0x7FFE8243F790
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE8243F900
        public void .ctor(){} // RVA: 0x7FFE8243FA40
        public void Initialize(){} // RVA: 0x7FFE8243F2E0
        public void OnTriggerExit(){} // RVA: 0x7FFE8243FA90
    }

    /// <summary>Originally: ÌÏÌÏÎÌÌÎÍÏÌÎÎÎÏÍÎÍÍÌÎÏÍ</summary>
    public class PopulateMesh_8CDE : Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFE8185A8D0
        public void OnPopulateMesh(){} // RVA: 0x7FFE8185A920
        public void .ctor(){} // RVA: 0x7FFE8185AB80
        public void Initialize(){} // RVA: 0x7FFE8185AC40
        public void get_vectorImage(){} // RVA: 0x7FFE8185B130
        public void set_vectorImage(){} // RVA: 0x7FFE8185B600
        public void get_sourceRect(){} // RVA: 0x7FFE8185BAD0
        public void get_uv(){} // RVA: 0x7FFE8185BB20
        public void set_uv(){} // RVA: 0x7FFE8185C010
        public void get_scaleMode(){} // RVA: 0x7FFE8185C4E0
        public void get_tintColor(){} // RVA: 0x7FFE81842480
        // ── Unresolved (hash) ──
        public void m_EEA(){} // RVA: 0x7FFE8185C530
    }

    /// <summary>Originally: ÏÎÍÌÎÎÍÎÍÏÏÏÍÎÏÌÏÍÌÌÍÌÍ</summary>
    public class PopulateMesh_AA4E : Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFE818437F0
        public void set_image(){} // RVA: 0x7FFE81843A50
        public void get_sprite(){} // RVA: 0x7FFE81843DC0
        public void set_sprite(){} // RVA: 0x7FFE81843EB0
        public void get_vectorImage(){} // RVA: 0x7FFE818441F0
        public void set_vectorImage(){} // RVA: 0x7FFE818442E0
        public void get_sourceRect(){} // RVA: 0x7FFE818443D0
        public void get_uv(){} // RVA: 0x7FFE81844560
        public void OnPopulateMesh(){} // RVA: 0x7FFE81844650
        public void .cctor(){} // RVA: 0x7FFE818452A0
        public void .ctor(){} // RVA: 0x7FFE818453E0
    }

    /// <summary>Originally: ÍÎÏÎÎÏÏÍÍÎÌÌÎÌÏÎÌÌÏÎÎÎÌ</summary>
    public class PopulateMesh_B039 : Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFE81857350
        public void set_image(){} // RVA: 0x7FFE81857440
        public void get_sprite(){} // RVA: 0x7FFE81857530
        public void set_sprite(){} // RVA: 0x7FFE81857B20
        public void get_vectorImage(){} // RVA: 0x7FFE81857C10
        public void OnPopulateMesh(){} // RVA: 0x7FFE81858200
        public void get_sourceRect(){} // RVA: 0x7FFE81858D00
        public void get_uv(){} // RVA: 0x7FFE81858DF0
        public void set_uv(){} // RVA: 0x7FFE818593E0
        public void get_scaleMode(){} // RVA: 0x7FFE81843DC0
        public void get_tintColor(){} // RVA: 0x7FFE818599D0
        public void .ctor(){} // RVA: 0x7FFE81859AC0
    }

    /// <summary>Originally: ÍÍÎÌÎÌÎÌÌÍÌÍÏÍÌÏÌÎÎÍÎÎÌ</summary>
    public class PopulateMesh_C826 : MaskableGraphic
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE81841A70
        public void OnDisable(){} // RVA: 0x7FFE81842480
        public void get_maskable(){} // RVA: 0x7FFE818424C0
        public void set_maskable(){} // RVA: 0x7FFE81842510
        public void .cctor(){} // RVA: 0x7FFE81842560
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE818427E0
        public void OnPopulateMesh(){} // RVA: 0x7FFE81842830
        public void .ctor(){} // RVA: 0x7FFE81842B30
        public void Initialize(){} // RVA: 0x7FFE81842B50
        public void SetClipRect(){} // RVA: 0x7FFE81842BA0
        public void SetClipSoftness(){} // RVA: 0x7FFE81842BF0
        public void OnCollisionEnter(){} // RVA: 0x7FFE81842C40
        public void OnCollisionStay(){} // RVA: 0x7FFE81842C90
    }

    /// <summary>Originally: ÏÍÌÎÎÏÏÌÍÍÎÍÍÍÎÎÎÏÌÎÎÌÍ</summary>
    public class PopulateMesh_ECC0 : MaskableGraphic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815E8F20
        public void OnPopulateMesh(){} // RVA: 0x7FFE815E8F30
        public void get_maskable(){} // RVA: 0x7FFE815E90B0
        public void set_maskable(){} // RVA: 0x7FFE815E94B0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFE815E98B0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE815E9CB0
        public void GetModifiedMaterial(){} // RVA: 0x7FFE815EA0B0
        public void Cull(){} // RVA: 0x7FFE815EA4B0
        public void UpdateCull(){} // RVA: 0x7FFE815EA8B0
        public void SetClipRect(){} // RVA: 0x7FFE815EACB0
        public void SetClipSoftness(){} // RVA: 0x7FFE815EB0B0
    }

    /// <summary>Originally: ÍÎÍÌÏÎÏÎÍÍÌÍÎÎÏÍÍÍÎÌÌÎÍ</summary>
    public class SetMaterialDirtySetVerticesDirty_866B : Text
    {
        // ── Methods ──
        public void get_cachedTextGenerator(){} // RVA: 0x7FFE81D90A10
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x7FFE81D90C30
        public void get_mainTexture(){} // RVA: 0x7FFE81D90E50
        public void OnPopulateMesh(){} // RVA: 0x7FFE81D91070
        public void SetMaterialDirty(){} // RVA: 0x7FFE81D91120
        public void SetVerticesDirty(){} // RVA: 0x7FFE81D911C0
        public void SetLayoutDirty(){} // RVA: 0x7FFE81D91260
        public void set_text(){} // RVA: 0x7FFE81D91310
        public void .ctor(){} // RVA: 0x7FFE81D91530
        public void Initialize(){} // RVA: 0x7FFE81D91770
        // ── Unresolved (hash) ──
        public void m_74F(){} // RVA: 0x7FFE81D907F0
    }

    /// <summary>Originally: ÍÎÌÌÌÍÌÍÏÏÎÎÌÌÍÍÎÎÌÏÎÌÏ</summary>
    public class TransformCameraBaseIImpl_0D75 : TransformCameraBaseImpl_DF8F
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE82321640
        public void OnDestroy(){} // RVA: 0x7FFE82321660
        public void .ctor(){} // RVA: 0x7FFE82321A80
        public void Initialize(){} // RVA: 0x7FFE82321C40
        // ── Unresolved (hash) ──
        public void m_3E2(){} // RVA: 0x7FFE82321870
        public void m_58E(){} // RVA: 0x7FFE82321E50
        public void m_9CF(){} // RVA: 0x7FFE82322060
        public void m_A4F(){} // RVA: 0x7FFE82322270
        public void m_EAD(){} // RVA: 0x7FFE82322480
        public void m_EF6(){} // RVA: 0x7FFE82322690
        public void m_A94(){} // RVA: 0x7FFE823228A0
    }

    /// <summary>Originally: ÎÏÎÍÍÎÌÍÏÏÌÏÌÎÌÍÍÌÎÍÌÎÏ</summary>
    public class TransformCameraBaseImpl_308A : TransformCameraBase_D269
    {
        public UnityEngine.Transform _308A; // 0x38

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFE822F3D50
        public void .cctor(){} // RVA: 0x7FFE822F8400
        public void Start(){} // RVA: 0x7FFE822F95E0
        public void OnDestroy(){} // RVA: 0x7FFE822F96A0
        public void .ctor(){} // RVA: 0x7FFE822FBDA0
        public void Initialize(){} // RVA: 0x7FFE822FBF90
        // ── 53 unresolved (hash) ──
        public void m_BF8(){} // RVA: 0x7FFE822F2360
        public void m_BD9(){} // RVA: 0x7FFE822F3D40
        public void m_197(){} // RVA: 0x7FFE822F4500
        public void m_77E(){} // RVA: 0x7FFE822F4D80
        public void m_EEC(){} // RVA: 0x7FFE822F5220
        // ... 48 more unresolved methods
    }

    /// <summary>Originally: ÏÍÎÎÏÏÍÎÎÎÍÌÌÍÌÍÎÌÌÌÍÏÎ</summary>
    public class TransformCameraBaseImpl_408B : TransformCameraBase_D269
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE822D32D0
        // ── Unresolved (hash) ──
        public void m_C13(){} // RVA: 0x7FFE822D3260
        public void m_D39(){} // RVA: 0x7FFE817F4630
    }

    /// <summary>Originally: ÍÍÎÌÏÎÎÏÍÎÌÏÎÍÍÌÍÎÏÏÎÏÏ</summary>
    public class TransformCameraBaseImpl_6237 : TransformCameraBase_D269
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82323C90
        // ── Unresolved (hash) ──
        public void m_D39(){} // RVA: 0x7FFE82323B10
        public void m_C13(){} // RVA: 0x7FFE82323C10
    }

    /// <summary>Originally: ÍÎÏÌÏÎÏÍÌÍÏÌÌÌÍÍÏÍÎÌÏÍÍ</summary>
    public class TransformCameraBaseImpl_84DF : TransformCameraBase_D269
    {
        public string f_955; // 0x38
        public UnityEngine.GameObject f_92D; // 0x40
        public UnityEngine.Transform f_365; // 0x48
        public UnityEngine.Transform f_748; // 0x50
        public UnityEngine.Transform f_257; // 0x58
        public UnityEngine.Transform f_B9E; // 0x60

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE822E55E0
        public void Initialize(){} // RVA: 0x7FFE822E5EE0
        public void Update(){} // RVA: 0x7FFE822E7DD0
        public void OnDestroy(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE822EC360
        // ── 70 unresolved (hash) ──
        public void m_EF8(){} // RVA: 0x7FFE822E3450
        public void m_1BA(){} // RVA: 0x7FFE811E0850
        public void m_2A1(){} // RVA: 0x7FFE822E5010
        public void m_095(){} // RVA: 0x7FFE810FB320
        public void m_6C3(){} // RVA: 0x7FFE810FB310
        // ... 65 more unresolved methods
    }

    /// <summary>Originally: ÌÏÏÎÌÍÌÏÍÌÍÏÍÎÎÍÏÏÎÌÌÏÎ</summary>
    public class TransformCameraBaseImpl_9DCD : TransformCameraBase_D269
    {
        public UnityEngine.Transform _9DCD; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE822D3320
        public void Initialize(){} // RVA: 0x7FFE822D33E0
        public void FixedUpdate(){} // RVA: 0x7FFE822D3470
        // ── Unresolved (hash) ──
        public void m_D39(){} // RVA: 0x7FFE810FB320
        public void m_AE9(){} // RVA: 0x7FFE822D3470
        public void m_656(){} // RVA: 0x7FFE822D3480
        public void m_16A(){} // RVA: 0x7FFE822D3F20
        public void m_414(){} // RVA: 0x7FFE822D49C0
        public void m_5BC(){} // RVA: 0x7FFE822D49D0
        public void m_134(){} // RVA: 0x7FFE822D49C0
        public void m_B09(){} // RVA: 0x7FFE822D49E0
        public void m_1BA(){} // RVA: 0x7FFE811E0850
    }

    /// <summary>Originally: ÍÎÎÏÍÌÎÌÍÎÏÏÌÌÎÎÌÌÌÎÍÏÌ</summary>
    public class TransformCameraBaseImpl_A48A : TransformCameraBase_D269
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82332190
    }

    /// <summary>Originally: ÎÍÎÌÌÎÎÌÌÏÎÎÎÍÎÍÎÌÎÍÍÏÎ</summary>
    public class TransformCameraBaseImpl_DF8F : TransformCameraBase_D269
    {
        public UnityEngine.Transform f_CAF; // 0x38
        public UnityEngine.Transform f_2F0; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82328F90
        public void .cctor(){} // RVA: 0x7FFE82329110
        public void Start(){} // RVA: 0x7FFE823293C0
        public void Awake(){} // RVA: 0x7FFE8232A5C0
        public void Update(){} // RVA: 0x7FFE8232B2C0
        public void OnDestroy(){} // RVA: 0x7FFE8232B600
        public void LateUpdate(){} // RVA: 0x7FFE8232BF80
        // ── 40 unresolved (hash) ──
        public void m_EC6(){} // RVA: 0x7FFE822EAEA0
        public void m_A2C(){} // RVA: 0x7FFE822EB490
        public void m_B5C(){} // RVA: 0x7FFE82323CE0
        public void m_5F6(){} // RVA: 0x7FFE82323D20
        public void m_153(){} // RVA: 0x7FFE82323FB0
        // ... 35 more unresolved methods
    }

    /// <summary>Originally: ÏÏÌÌÎÏÏÎÎÎÌÌÎÍÏÌÌÏÍÏÎÌÍ</summary>
    public class TransformCameraBaseImpl_ED4E : TransformCameraBase_D269
    {
        public ÍÌÍÎÌÎÍÏÏÌÍÎÍÎÍÎÎÍÍÌÌÎÍ f_938; // 0x38
        public UnityEngine.Transform f_B9E; // 0x40
        public UnityEngine.Transform f_956; // 0x48
        public UnityEngine.Transform f_13C; // 0x50
        public UnityEngine.Transform f_AAC; // 0x58
        public UnityEngine.Transform f_E2A; // 0x60
        public UnityEngine.Transform f_F4F; // 0x68
        public UnityEngine.Transform f_885; // 0x70
        public UnityEngine.Transform f_81F; // 0x78

        // ── Methods ──
        public void OnDrawGizmos(){} // RVA: 0x7FFE82302690
        public void OnDisable(){} // RVA: 0x7FFE82303170
        public void Update(){} // RVA: 0x7FFE82303530
        public void OnEnable(){} // RVA: 0x7FFE8230DA70
        public void .ctor(){} // RVA: 0x7FFE82310B40
        public void Initialize(){} // RVA: 0x7FFE82311600
        public void .cctor(){} // RVA: 0x7FFE82315C80
        public void Awake(){} // RVA: 0x7FFE8231A030
        public void OnDestroy(){} // RVA: 0x7FFE8231CE80
        public void LateUpdate(){} // RVA: 0x7FFE8231DD80
        public void Start(){} // RVA: 0x7FFE8231FD60
        // ── 90 unresolved (hash) ──
        public void m_36A(){} // RVA: 0x7FFE823013A0
        public void m_A2C(){} // RVA: 0x7FFE822EB490
        public void m_B43(){} // RVA: 0x7FFE823020B0
        public void m_410(){} // RVA: 0x7FFE823022B0
        public void m_5E9(){} // RVA: 0x7FFE82302C50
        // ... 85 more unresolved methods
    }

    /// <summary>Originally: ÌÌÌÌÏÎÎÏÌÌÎÏÌÏÏÏÍÏÎÎÍÍÌ</summary>
    public class TransformCameraBase_D269 : MonoBehaviour
    {
        public string _m_CancellationTokenSource;
        public VRCHandData f_DDA;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE822CCAD0
        public void RaiseCancellation(){} // RVA: 0x7FFE813240E0
        public void IsInvoking(){} // RVA: 0x7FFE810FB310
        public void CancelInvoke(){} // RVA: 0x7FFE822CCB30
        public void Invoke(){} // RVA: 0x7FFE810FB310
        public void InvokeRepeating(){} // RVA: 0x7FFE810FB310
        public void GetCameraPosition(){} // RVA: 0x7FFE8111ED80
        public void SetCameraPosition(){} // RVA: 0x7FFE810FB310
        public void StartCoroutine(){} // RVA: 0x7FFE822CCB40
        public void GetCameraRotation(){} // RVA: 0x7FFE813240E0
        public void SetCameraRotation(){} // RVA: 0x7FFE811E0850
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE810FB310
        public void StopCoroutine(){} // RVA: 0x7FFE810FB320
        public void GetCameraTransform(){} // RVA: 0x7FFE810FB320
        public void SetCameraTransform(){} // RVA: 0x7FFE813240E0
        public void StopAllCoroutines(){} // RVA: 0x7FFE810FB320
        public void get_useGUILayout(){} // RVA: 0x7FFE810FB310
        public void set_useGUILayout(){} // RVA: 0x7FFE810FB310
        public void print(){} // RVA: 0x7FFE822CCBC0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE810FB310
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE822CCC20
        public void InvokeDelayed(){} // RVA: 0x7FFE813240E0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE822CCD20 | overloaded x2
        public void ResetCameraTransform(){} // RVA: 0x7FFE813240E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE822CCD10
        public void StartCoroutineManaged(){} // RVA: 0x7FFE813240E0
        public void StopCoroutineManaged(){} // RVA: 0x7FFE813240E0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE822CD270
        public void GetScriptClassName(){} // RVA: 0x7FFE810FB310
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE813240E0
        public void ApplyCameraOffset(){} // RVA: 0x7FFE810FB320
        public void FollowTarget(){} // RVA: 0x7FFE810FB320
        public void LookAtTarget(){} // RVA: 0x7FFE810FB320
        public void SmoothMoveCamera(){} // RVA: 0x7FFE810FB310
        public void GetCameraForward(){} // RVA: 0x7FFE822CD360
        public void .ctor(){} // RVA: 0x7FFE822CD370
        public void Initialize(){} // RVA: 0x7FFE810FB320
        public void .cctor(){} // RVA: 0x7FFE822CD960
        // ── 36 unresolved (hash) ──
        public void m_BD9(){} // RVA: 0x7FFE810FB310
        public void m_D9D(){} // RVA: 0x7FFE813240E0
        public void m_1AE(){} // RVA: 0x7FFE810FB310
        public void m_AFB(){} // RVA: 0x7FFE810FB320
        public void m_CBA(){} // RVA: 0x7FFE810FB320
        // ... 31 more unresolved methods
    }

    /// <summary>Originally: ÍÌÌÎÏÏÏÏÎÍÎÌÌÎÏÏÎÎÍÏÎÍÎ</summary>
    public class WorldMainSceneCameraComponentSSibling_9F0E
    {
        // ── Unresolved (hash) ──
        public void m_A73(){} // RVA: 0x7FFE80E2E2E0
        public void m_D80(){} // RVA: 0x7FFE80E460A0
        public void m_F32(){} // RVA: 0x7FFE80E3D230
    }

    /// <summary>Originally: ÌÏÎÍÎÍÏÏÌÌÏÎÎÌÌÍÍÏÏÏÎÌÏ</summary>
    public class WorldMainSceneCameraComponentSibling_90BB : Object
    {
        public UnityEngine.Camera _90BB; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8251EA90
        public void GetHashCode(){} // RVA: 0x7FFE8251EBF0
        public void op_Implicit(){} // RVA: 0x7FFE8251EC30
        public void CompareBaseObjects(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void get_name(){} // RVA: 0x7FFE810FE7C0
        public void set_name(){} // RVA: 0x7FFE8251EBF0
        public void Instantiate(){} // RVA: 0x7FFE8251EC30
    }

    /// <summary>Originally: ÎÌÎÏÎÍÌÏÍÏÌÏÌÏÏÍÍÌÍÏÌÌÏ</summary>
    public class WorldMainSceneCameraComponent_CBF1 : MonoBehaviour
    {
        public ÎÌÎÏÎÍÌÏÍÏÌÏÌÏÏÍÍÌÍÏÌÌÏ _cBF1;
        public UnityEngine.Camera MainSceneCamera; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE880E5840
        public void Awake(){} // RVA: 0x7FFE880E5F00
        public void IsInvoking(){} // RVA: 0x7FFE8143BA80
        public void CancelInvoke(){} // RVA: 0x7FFE880E6050
        public void Invoke(){} // RVA: 0x7FFE880E6200
        public void InvokeRepeating(){} // RVA: 0x7FFE880E64E0
        public void .ctor(){} // RVA: 0x7FFE880E66A0
        public void Initialize(){} // RVA: 0x7FFE880E6790
        public void StartCoroutine(){} // RVA: 0x7FFE81463B00
        public void OnApplicationPause(){} // RVA: 0x7FFE880E6A40
        public void OnApplicationQuit(){} // RVA: 0x7FFE880E7100
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE880E7290
        public void StopCoroutine(){} // RVA: 0x7FFE880E7760
        public void OnDestroy(){} // RVA: 0x7FFE880E7810
        public void OnCollisionStay(){} // RVA: 0x7FFE880E7AC0
        public void StopAllCoroutines(){} // RVA: 0x7FFE880E7D20
        public void get_useGUILayout(){} // RVA: 0x7FFE81437330
        public void set_useGUILayout(){} // RVA: 0x7FFE880E8000
        public void print(){} // RVA: 0x7FFE8139DAD0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE8143BA80
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE880E86C0
        public void InvokeDelayed(){} // RVA: 0x7FFE880E8D80
        public void Start(){} // RVA: 0x7FFE880E9030
    }

    /// <summary>Originally: ÌÍÏÍÌÌÍÍÌÍÎÍÏÎÎÌÎÏÍÍÍÎÎ</summary>
    public class mainTexturePopulateMeshSibling_C712 : MonoBehaviour
    {
        public UnityEngine.UI.RawImage _screen; // 0x20
        public ÏÎÏÍÎÎÏÍÍÌÏÌÎÎÍÎÎÎÌÍÌÎÍ _c712; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE827036A0
        public void RaiseCancellation(){} // RVA: 0x7FFE82703700
        public void IsInvoking(){} // RVA: 0x7FFE82703720
        public void CancelInvoke(){} // RVA: 0x7FFE827037C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE82703960
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFE827039A0
        public void StartCoroutine(){} // RVA: 0x7FFE82703700
        public void Construct(){} // RVA: 0x7FFE82703720
        public void Initialize_8D960542F3CB(){} // RVA: 0x7FFE827039C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE82703A50
        public void StopCoroutine(){} // RVA: 0x7FFE82703C30
        public void .ctor_56FC631895E1(){} // RVA: 0x7FFE82703C70
        public void StopAllCoroutines(){} // RVA: 0x7FFE82703720
        public void get_useGUILayout(){} // RVA: 0x7FFE82703E40
        // ── Unresolved (hash) ──
        public void m_E18(){} // RVA: 0x7FFE827039A0
        public void m_C5E(){} // RVA: 0x7FFE82703CB0
    }

    /// <summary>Originally: ÎÎÎÌÍÎÍÍÌÍÌÎÏÍÍÍÌÏÏÎÏÌÌ</summary>
    public class mainTexturePopulateMesh_02E6 : MaskableGraphic
    {
        public UnityEngine.Sprite _sprite; // 0xE0
        public 0x663E29DC _mainTexture; // 0xE8
        public bool ShaderFeatureStripes; // 0xEC

        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x7FFE815EB4B0
        public void set_onCullStateChanged(){} // RVA: 0x7FFE815EB660
        public void get_maskable(){} // RVA: 0x7FFE8117C900
        public void .ctor(){} // RVA: 0x7FFE815EB6B0
        public void Initialize(){} // RVA: 0x7FFE815EB6D0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE815EBF50
        public void OnPopulateMesh(){} // RVA: 0x7FFE815EBFC0
        public void Cull(){} // RVA: 0x7FFE815ECD10
        public void UpdateCull(){} // RVA: 0x7FFE8117C900
        public void SetClipRect(){} // RVA: 0x7FFE815ECD60
        public void set_mainTexture(){} // RVA: 0x7FFE8117C900
        public void get_mainTexture(){} // RVA: 0x7FFE815ECF10
        public void OnDisable(){} // RVA: 0x7FFE815ED080
        public void OnTransformParentChanged(){} // RVA: 0x7FFE815ED8E0
    }

    /// <summary>Originally: ÌÍÍÎÌÌÏÍÎÎÎÍÎÍÎÍÌÍÌÎÍÌÍ</summary>
    public class mainTexturePopulateMesh_CDB8 : MaskableGraphic
    {
        public UnityEngine.Sprite _mainTexture; // 0xE0

        // ── Methods ──
        public void get_mainTexture(){} // RVA: 0x7FFE899602E0
        public void set_mainTexture(){} // RVA: 0x7FFE89960450
        public void get_maskable(){} // RVA: 0x7FFE89960450
        public void set_maskable(){} // RVA: 0x7FFE89960450
        public void get_isMaskingGraphic(){} // RVA: 0x7FFE89960450
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE89960450
        public void GetModifiedMaterial(){} // RVA: 0x7FFE89960450
        public void OnPopulateMesh(){} // RVA: 0x7FFE89960530
        public void UpdateCull(){} // RVA: 0x7FFE89960450
        public void .ctor(){} // RVA: 0x7FFE815E8F20
        public void Initialize(){} // RVA: 0x7FFE89960450
        public void OnEnable(){} // RVA: 0x7FFE89960450
    }

    /// <summary>Originally: ÏÏÎÍÍÏÍÍÌÏÍÌÏÎÏÍÍÌÍÌÌÏÍ</summary>
    public class mainTexturePopulateMesh_E4B1 : MaskableGraphic
    {
        public float _mainTexture; // 0xE0
        public float _m_MaskMaterial; // 0xE4

        // ── Methods ──
        public void set_mainTexture(){} // RVA: 0x7FFE89DC7FD0
        public void get_mainTexture(){} // RVA: 0x7FFE811662A0
        public void .ctor(){} // RVA: 0x7FFE89DC8180
        public void Initialize(){} // RVA: 0x7FFE89DC81A0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFE89DC8350
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE811662A0
        public void OnPopulateMesh(){} // RVA: 0x7FFE89DC8500
        public void Cull(){} // RVA: 0x7FFE811662A0
        public void UpdateCull(){} // RVA: 0x7FFE811662A0
        public void SetClipRect(){} // RVA: 0x7FFE89DC8DE0
    }

}