// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Audio
// Classes: 4
// Methods: 67

namespace VRC.Audio
{
    /// <summary>Originally: ÏÌÏÌÎÍÏÏÍÏÍÎÍÌÏÌÍÏÎÌÍÌÍ</summary>
    public class AudioFilterReadHandler_9BBB : MonoBehaviour
    {
        public int _destroyCancellationToken; // 0x20
        public bool _useGUILayout; // 0x24
        public UnityEngine.AudioSource ÍÏÎÏÍÍÏÎÍÍÎÎÎÏÌÏÌÌÏÎÍÌÏ; // 0x28
        public ONSPAudioSource ÎÎÌÎÏÍÏÎÏÎÌÎÏÌÌÌÍÎÎÎÌÏÌ; // 0x30
        public bool ÏÎÌÍÌÌÌÎÏÌÎÎÏÌÎÌÍÏÌÌÍÍÌ; // 0x38
        public ÏÍÎÏÎÌÏÎÎÏÍÏÏÎÏÏÎÎÍÏÌÎÎ ÍÏÎÎÏÎÌÎÎÏÍÎÍÌÎÍÏÍÍÌÍÍÌ; // 0x40
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ <ÌÎÌÏÍÌÏÎÏÎÏÍÏÍÎÌÌÎÌÌÎÎÍ>k__BackingField; // 0x80
        public ÍÍÌÌÎÍÏÏÍÎÎÌÏÎÏÍÏÏÌÍÎÌÏ <ÎÎÍÏÎÌÎÏÍÍÎÏÎÌÎÌÏÍÍÌÍÍÏ>k__BackingField; // 0x88

        // ── Methods ──
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void RaiseCancellation(){} // RVA: 0x7FFD4F05EA10
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void Invoke(){} // RVA: 0x7FFD4F05EF30
        public void Update(){} // RVA: 0x7FFD4F05F350
        public void Start(){} // RVA: 0x7FFD4E380010
        public void OnEnable(){} // RVA: 0x7FFD4F05F4F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F05F720
        public void StartCoroutine(){} // RVA: 0x7FFD4F05F900
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E8F4AA0
        public void StopCoroutine(){} // RVA: 0x7FFD4F05FD80
        public void set_imageUrl(){} // RVA: 0x7FFD4E96E300
        public void LateUpdate(){} // RVA: 0x7FFD4F060200
        public void Awake(){} // RVA: 0x7FFD4F060230
        public void OnDestroy(){} // RVA: 0x7FFD4E380010
        public void set_useGUILayout(){} // RVA: 0x7FFD4E70F410
        public void print(){} // RVA: 0x7FFD4F060200
        public void OnAudioFilterRead(){} // RVA: 0x7FFD4F060350
    }

    /// <summary>Originally: ÍÍÎÍÎÏÍÌÏÎÏÌÎÏÍÏÏÎÌÍÏÍÍ</summary>
    public class AudioGetDeviceNamesOpenDevice_173D : Object
    {
        public ÏÎÍÌÍÏÏÏÎÎÍÍÏÎÌÏÌÌÎÍÌÌÌ _name; // 0x10
        public byte[] ÍÌÏÍÍÎÌÌÏÍÏÏÎÎÍÍÌÌÌÌÏÍÌ; // 0x18
        public ÌÌÍÌÍÍÏÌÎÎÍÍÏÍÏÌÏÌÍÍÏÎÍ ÌÍÏÏÌÌÍÌÌÍÎÍÎÍÍÎÎÎÌÎÍÍÌ; // 0x20
        public 0x665B3E78 ÍÌÎÌÏÍÌÌÎÌÌÏÌÏÎÎÌÌÏÏÏÏÌ; // 0x50
        public 0x665B3E20 ÏÎÌÌÍÍÎÍÎÌÎÎÍÍÌÎÍÎÎÌÍÌÍ; // 0x58

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E5529D0
        public void Equals(){} // RVA: 0x7FFD4E5529E0
        public void GetHashCode(){} // RVA: 0x7FFD4E552AD0
        public void remove_OnMidiVoiceMessage(){} // RVA: 0x7FFD4E552BC0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E552CB0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4E553070
        public void get_Name(){} // RVA: 0x7FFD4E5529D0
        public void set_Name(){} // RVA: 0x7FFD4E553660
        public void Close(){} // RVA: 0x7FFD4E553750
        public void Instantiate(){} // RVA: 0x7FFD4E5537E0
        public void ToString(){} // RVA: 0x7FFD4E553920
        public void OpenDevice_3CEB32E8A587(){} // RVA: 0x7FFD4E553A60
        public void GetDeviceNames(){} // RVA: 0x7FFD4E553B50
        public void OpenDevice(){} // RVA: 0x7FFD4E553EB0
        public void Update(){} // RVA: 0x7FFD4E554500
        public void add_OnMidiVoiceMessage(){} // RVA: 0x7FFD4E5545F0
    }

    /// <summary>Originally: ÍÌÏÎÎÍÏÍÎÎÎÎÍÏÍÌÏÎÌÏÎÎÏ</summary>
    public class AudioPerformClipping_2B7E : RectMask2D
    {
        public System.Action _2B7E;
        public bool ÌÏÍÌÍÎÏÌÎÌÏÎÍÏÌÎÎÍÏÎÎÌÍ; // 0x90
        public Cysharp.Threading.Tasks.UniTask ÍÏÏÏÍÍÎÍÏÌÍÎÌÍÏÌÏÍÎÏÌÏÍ; // 0x98
        public bool _clippingEnabled; // 0xA8

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFD56C16E50
        public void OnDestroy(){} // RVA: 0x7FFD56C16F60
        public void PerformClipping(){} // RVA: 0x7FFD56C173E0
        public void set_softness(){} // RVA: 0x7FFD56C17410
        public void get_Canvas(){} // RVA: 0x7FFD56C17550
        public void get_canvasRect(){} // RVA: 0x7FFD56C176B0
        public void get_rectTransform(){} // RVA: 0x7FFD56C177C0
        public void AudioClippingController(){} // RVA: 0x7FFD56C178D0
        public void IsPlaying(){} // RVA: 0x7FFD4E561F10
        public void OnDisable(){} // RVA: 0x7FFD56C17930
        public void OnEnable(){} // RVA: 0x7FFD56C17A90
        public void IsRaycastLocationValid(){} // RVA: 0x7FFD56C17B20
        public void get_rootCanvasRect(){} // RVA: 0x7FFD56C17C30
        public void PerformClipping_C49EC6384F31(){} // RVA: 0x7FFD56C17D70
        public void .ctor(){} // RVA: 0x7FFD56C17ED0
        public void Initialize(){} // RVA: 0x7FFD4E561F10
        public void RemoveClippable(){} // RVA: 0x7FFD56C17F90
        public void Start(){} // RVA: 0x7FFD56C180A0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD56C184D0
    }

    /// <summary>Originally: ÌÏÏÍÎÏÍÍÎÎÍÌÌÍÏÎÏÎÎÎÌÌÍ</summary>
    public class AudioSelectPreviousMicSelectNextMic_DB18 : MonoBehaviour
    {
        public UnityEngine.UI.Button ÍÍÌÍÎÌÎÎÍÌÌÎÍÏÎÌÌÎÎÏÌÍÏ; // 0x20
        public UnityEngine.UI.Button ÏÏÏÌÎÍÌÏÎÌÌÍÎÍÍÌÏÍÎÎÌÍÍ; // 0x28
        public UnityEngine.UI.Text ÏÎÌÏÌÌÎÍÍÏÌÏÏÎÏÎÌÏÍÍÏÍÌ; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E341310
        public void RaiseCancellation(){} // RVA: 0x7FFD4E341310
        public void SelectNextMic(){} // RVA: 0x7FFD4E341310
        public void CancelInvoke(){} // RVA: 0x7FFD4E341310
        public void Invoke(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void IsInvoking(){} // RVA: 0x7FFD4E341310
        public void StartCoroutine(){} // RVA: 0x7FFD4E341310
        public void .ctor_AC1101A74B4C(){} // RVA: 0x7FFD4E341310
        public void SelectPreviousMic(){} // RVA: 0x7FFD4E341310
    }

}