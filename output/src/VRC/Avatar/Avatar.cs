// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Avatar
// Classes: 6
// Methods: 145

namespace VRC.Avatar
{
    /// <summary>Originally: ÏÏÌÌÌÎÏÏÌÍÎÏÎÎÎÎÏÏÎÏÏÏÌ</summary>
    public class AvatarItem_66A2_66A2
    {
        public object _item;

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void LogFormat(){} // RVA: 0x7FFAC2C73960
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void set_Item(){} // RVA: 0x7FFAC2C72BC0
    }

    /// <summary>Originally: ÏÎÎÍÏÍÎÍÍÏÌÍÎÏÍÌÎÏÎÍÍÎÏ</summary>
    public class AvatarParameterEnumerator_27C5_27C5 : Object
    {
        public int System.Collections.Generic.IEnumerator<VRC.Playables.AvatarParameter>.Current; // 0x10
        public ÏÎÏÌÌÌÏÍÍÌÍÎÍÌÏÍÎÏÌÍÎÎÍ System.Collections.IEnumerator.Current; // 0x18
        public int ÌÍÎÎÎÏÍÌÍÌÏÎÌÎÌÍÌÍÍÏÌÌÌ; // 0x20
        public ÌÎÌÌÍÌÏÏÍÎÏÏÏÍÌÌÎÎÍÌÏÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Enumerator<int,ÏÎÏÌÌÌÏÍÍÌÍÎÍÌÏÍÎÏÌÍÎÎÍ> ÍÍÎÏÎÍÍÌÌÍÍÌÍÎÎÍÌÎÌÏÎÌÏ; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC327C1D0
        public void GetEnumerator(){} // RVA: 0x7FFAC327C210
        public void get_Current(){} // RVA: 0x7FFAC327C2D0
        public void op_Implicit(){} // RVA: 0x7FFAC2F247C0
        public void MoveNext(){} // RVA: 0x7FFAC327C3A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void GetCachedPtr(){} // RVA: 0x7FFAC327C6A0
        public void get_name(){} // RVA: 0x7FFAC327C6F0
        public void .ctor(){} // RVA: 0x7FFAC327C740
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC327C760
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC327C7A0
        public void System.Collections.Generic.IEnumerator<VRC.Playables.AvatarParameter>.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC327C820
        public void System.Collections.Generic.IEnumerable<VRC.Playables.AvatarParameter>.GetEnumerator(){} // RVA: 0x7FFAC327C820
    }

    /// <summary>Originally: ÎÏÎÏÌÌÍÎÍÍÎÍÍÌÍÍÍÌÌÍÏÍÌ</summary>
    public class AvatarPickupUseDownPickup_640A_640A : VRC_Interactable
    {
        public float f_A35;
        public bool Index; // 0x40
        public int PathIndex; // 0x44
        public int FocalDistance; // 0x48
        public float Aperture; // 0x4C
        public float Hue; // 0x50
        public float Saturation; // 0x54
        public float Lightness; // 0x58
        public float LookAtMeXOffset; // 0x5C
        public float LookAtMeYOffset; // 0x60
        public float Zoom; // 0x64
        public float Exposure; // 0x68
        public float Speed; // 0x6C
        public float Duration; // 0x70
        public float Position; // 0x74
        public ÎÍÏÏÏÏÌÌÏÏÍÏÎÏÏÌÏÏÏÎÍÏÏ Rotation; // 0x78
        public UnityEngine.Transform f_523; // 0x80
        public UnityEngine.Transform f_D7B; // 0x88
        public UnityEngine.Transform ÎÌÍÎÌÍÎÏÌÏÍÏÌÎÏÌÌÏÎÏÍÍÍ; // 0x90
        public UnityEngine.Transform ÍÏÍÏÎÌÏÎÍÏÏÍÏÎÍÌÏÎÏÏÍÏÍ; // 0x98
        public System.Collections.Generic.List`1<UnityEngine.Vector3> ÎÏÌÎÏÌÍÍÏÏÏÌÎÌÎÍÌÎÏÏÏÍÍ; // 0xA0
        public UnityEngine.UI.Slider SpeedSlider; // 0xA8
        public UnityEngine.UI.Slider DurationSlider; // 0xB0
        public UnityEngine.UI.Slider ZoomSlider; // 0xB8
        public UnityEngine.UI.Slider ExposureSlider; // 0xC0
        public UnityEngine.UI.Slider FocalDistanceSlider; // 0xC8
        public UnityEngine.UI.Slider ApertureSlider; // 0xD0
        public UnityEngine.UI.Slider LookAtMeXOffsetSlider; // 0xD8
        public UnityEngine.UI.Slider LookAtMeYOffsetSlider; // 0xE0
        public UnityEngine.UI.Slider HueSlider; // 0xE8
        public UnityEngine.UI.Slider LightnessSlider; // 0xF0
        public UnityEngine.UI.Slider SaturationSlider; // 0xF8
        public UnityEngine.UI.Button MotionFoldout; // 0x100
        public UnityEngine.UI.Button FocusFoldout; // 0x108
        public UnityEngine.UI.Button LookAtMeFoldout; // 0x110
        public UnityEngine.UI.Button GreenscreenFoldout; // 0x118
        public UnityEngine.GameObject[] SliderContent; // 0x120
        public UnityEngine.GameObject[] SliderFoldoutArrows; // 0x128
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ DofSliderContentTitle; // 0x130
        public UnityEngine.RectTransform DofSliderContentRect; // 0x138
        public UnityEngine.RectTransform ZoomSliderParentRect; // 0x140
        public UnityEngine.GameObject FocalDistanceSliderParent; // 0x148
        public UnityEngine.GameObject ApertureSliderParent; // 0x150
        public UnityEngine.UI.Button DeleteButton; // 0x158
        public UnityEngine.UI.Button CopyToCameraButton; // 0x160
        public UnityEngine.UI.Button NextPositionButton; // 0x168
        public UnityEngine.UI.Button PreviousPositionButton; // 0x170
        public UnityEngine.UI.Button NextSegmentButton; // 0x178
        public UnityEngine.UI.Button PreviousSegmentButton; // 0x180
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ IndexUIPathIndex; // 0x188
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ IndexUIPointIndex; // 0x190
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ UITitle; // 0x198
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ PositionIndexText; // 0x1A0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ SegmentIndexText; // 0x1A8
        public VRC.SDKBase.VRC_Pickup ÍÎÌÎÎÏÎÏÎÎÎÏÎÍÍÏÏÏÌÏÌÏÎ; // 0x1B0
        public ÌÎÎÌÌÏÌÎÌÏÍÏÏÏÎÍÌÎÌÎÌÌÏ ÌÍÏÌÍÍÍÍÎÏÍÌÌÌÎÍÍÏÍÏÍÎÎ; // 0x1B8
        public UnityEngine.Rigidbody ÏÏÎÍÏÏÌÍÎÌÌÌÎÏÍÎÎÍÌÌÏÎÎ; // 0x1C0
        public UnityEngine.Transform ÎÌÏÏÍÌÌÍÌÍÏÏÌÍÌÏÍÏÍÎÎÍÎ; // 0x1C8
        public UnityEngine.Transform ÏÍÏÍÌÏÌÏÏÌÎÌÍÌÎÍÏÌÍÎÎÏÏ; // 0x1D0
        public UnityEngine.Vector3 ÏÍÍÌÍÌÎÏÎÏÌÏÌÏÍÍÍÏÌÍÌÍÏ; // 0x1D8
        public UnityEngine.Vector3 ÎÏÏÍÍÍÏÍÏÍÏÏÌÏÏÍÌÌÍÌÍÍÎ; // 0x1E4
        public UnityEngine.Vector3 ÌÌÎÌÏÏÎÍÏÎÌÌÎÏÏÎÏÏÌÌÍÎÌ; // 0x1F0
        public UnityEngine.Quaternion ÌÌÌÏÏÏÍÏÍÎÎÌÏÎÌÎÍÎÏÌÌÍÌ; // 0x1FC
        public 0x6B02B7A0 ÎÍÏÎÌÌÌÏÎÎÏÎÏÎÎÎÍÌÌÎÍÌÏ; // 0x20C
        public UnityEngine.Vector3 ÌÌÏÍÌÌÌÌÎÌÏÏÏÍÌÏÍÌÍÎÍÍÌ; // 0x210
        public UnityEngine.Quaternion ÌÎÌÎÏÍÌÏÍÏÏÎÏÎÍÍÌÌÌÎÌÏÍ; // 0x21C
        public bool ÌÏÎÌÎÎÍÏÏÎÎÏÏÏÎÏÌÏÌÍÎÌÌ; // 0x22C
        public float ÏÏÌÎÍÎÎÌÍÎÍÏÍÍÌÌÎÎÍÏÎÏÏ; // 0x230
        public int ÍÎÎÎÌÍÎÍÎÏÏÌÍÏÏÏÌÎÍÍÍÎÏ; // 0x234

        // ── Methods ──
        public void set_captureMethod(){} // RVA: 0x7FFAC2FC20B0
        public void OnPickup(){} // RVA: 0x7FFAC37335B0
        public void GetCaptureMethod(){} // RVA: 0x7FFAC3733AC0
        public void set_lifetime(){} // RVA: 0x7FFAC2F4A090
        public void Update(){} // RVA: 0x7FFAC3733B10
        public void SetVolume(){} // RVA: 0x7FFAC3734120
        public void set_IsInteractive(){} // RVA: 0x7FFAC3734580
        public void set_startLifetime(){} // RVA: 0x7FFAC2F4A0B0
        public void get_rawName(){} // RVA: 0x7FFAC3734590
        public void Getclip(){} // RVA: 0x7FFAC37345D0
        public void set_IsInteractive_9FD0773B2F0B(){} // RVA: 0x7FFAC3734610
        public void GetMaxHealth(){} // RVA: 0x7FFAC3031E10
        public void set_IsInteractive_B7DA07A82BE8(){} // RVA: 0x7FFAC3734610
        public void get_RollInput(){} // RVA: 0x7FFAC2F4A0C0
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void set_AreaWidth(){} // RVA: 0x7FFAC2F89470
        public void Interact(){} // RVA: 0x7FFAC2F21310
        public void set_RollInput(){} // RVA: 0x7FFAC2F4A0D0
        public void set_IsInteractive_CDD170F45B29(){} // RVA: 0x7FFAC3734620
        public void get_DisableInteractive(){} // RVA: 0x7FFAC2FDCC00
        public void ProcessInteractableState(){} // RVA: 0x7FFAC3734660
        public void GetVideoDisplayRate(){} // RVA: 0x7FFAC2F89460
        public void ProcessPickupState(){} // RVA: 0x7FFAC37346A0
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7FFAC2F4A000
        public void Initialize(){} // RVA: 0x7FFAC37346B0
        public void set_LostPackagesOut(){} // RVA: 0x7FFAC2FC20D0
        public void set_bakingProgress(){} // RVA: 0x7FFAC2F4A050
        public void set_EnginePower(){} // RVA: 0x7FFAC2F4A070
        public void GetLifetime(){} // RVA: 0x7FFAC37346F0
        public void CalculateInitialOffset(){} // RVA: 0x7FFAC3734C50
        public void CalculateInitialOffset_71FE6C1BD82C(){} // RVA: 0x7FFAC3734D70
        public void set_minRegionArea(){} // RVA: 0x7FFAC2F4A010
        public void OnPickupUseDown(){} // RVA: 0x7FFAC3734DA0
        public void .ctor(){} // RVA: 0x7FFAC3734F60
        public void GetVolume(){} // RVA: 0x7FFAC3735030
        public void BeginProfiler(){} // RVA: 0x7FFAC3735070
        public void set_AreaHeight(){} // RVA: 0x7FFAC33914E0
        public void BeginProfiler_A19(){} // RVA: 0x7FFAC3735080
        public void GetIsInteractive(){} // RVA: 0x7FFAC37350C0
        public void Equals(){} // RVA: 0x7FFAC2F89470
        public void GetCurrentHealth(){} // RVA: 0x7FFAC2F4A040
        public void SetClip(){} // RVA: 0x7FFAC3735100
        public void ComputeIsPressed(){} // RVA: 0x7FFAC3735200
        public void get_voxelSize(){} // RVA: 0x7FFAC2F49FE0
        public void ComputeisPressed(){} // RVA: 0x7FFAC3735240
        public void get_RollAngle(){} // RVA: 0x7FFAC2F42680
        public void get_currentScale(){} // RVA: 0x7FFAC3735280
        public void SetMaxHealth(){} // RVA: 0x7FFAC3735290
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void SetRollInput(){} // RVA: 0x7FFAC37352A0
        public void OnDrop(){} // RVA: 0x7FFAC37352E0
        public void ProcessInteractableState_39894AF72A62(){} // RVA: 0x7FFAC37354D0
        public void set_lifetime_D3E0BB3F651E(){} // RVA: 0x7FFAC2F4A090
        public void GetStatus(){} // RVA: 0x7FFAC2FC20C0
        public void get_EnginePower(){} // RVA: 0x7FFAC2F4A060
        public void CalculateInitialOffset_85EA86E9217B(){} // RVA: 0x7FFAC3735280
        public void get_PitchAngle(){} // RVA: 0x7FFAC2F4A0A0
        public void set_voxelSize(){} // RVA: 0x7FFAC2F49FF0
        public void CalculateInitialOffset_1CB920289DDB(){} // RVA: 0x7FFAC3735280
        public void SetVideoTracks(){} // RVA: 0x7FFAC3735510
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFAC3735550
        public void GetAreaWidth(){} // RVA: 0x7FFAC3735560
        public void GetMaxDampTime(){} // RVA: 0x7FFAC3391600
        public void GetMaxDampTime_28D5D024E65B(){} // RVA: 0x7FFAC3391600
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FDCC10
        public void GetAreaHeight(){} // RVA: 0x7FFAC37355B0
        public void OnDrop_DB0F6629ED71(){} // RVA: 0x7FFAC3735870
        public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC2FC20A0
        public void Start_72D62AB58A35(){} // RVA: 0x7FFAC3736BC0
        public void Start(){} // RVA: 0x7FFAC3736C00
    }

    /// <summary>Originally: ÍÌÍÌÏÏÌÍÏÎÌÌÏÎÎÍÌÏÌÍÍÍÍ</summary>
    public class AvatarProxySettingsSibling_5019
    {
        public object f_1C1;
        public object f_75E;
        public object f_B9B;
        public object f_42C;
        public object f_FD0;
        public object f_AB0;
        public object f_C00;
        public object f_31B;
        public object f_975;
        public object f_13E;
        public object f_954;
        public object f_56A;

        // ── Methods ──
        public void GetPlaybackRate(){} // RVA: 0x7FFAC2C6D880
        public void GetPlaybackRate_F3A682EE7AE3(){} // RVA: 0x7FFAC2C6D880
        public void GetPlaybackRate_CF0A6CCFD915(){} // RVA: 0x7FFAC2C6D880
        public void GetPlaybackRate_BF4ED7AFA196(){} // RVA: 0x7FFAC2C6D880
        public void GetPlaybackRate_4FF8B3877C53(){} // RVA: 0x7FFAC2C6D880
        public void GetPlaybackRate_83A8879362E8(){} // RVA: 0x7FFAC2C59960
        public void GetPlaybackRate_5512DFE6C3DB(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate_276C43898A8F(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate_6DEAD580C86C(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate_B90055E71E70(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate_05F4875EACB8(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate_6D0A619113F7(){} // RVA: 0x7FFAC2C58E90
    }

    /// <summary>Originally: ÍÎÌÌÏÎÎÌÎÏÌÏÏÎÍÍÏÏÌÎÎÍÏ</summary>
    public class LoadAvatarComponent_D33F_D33F : MonoBehaviour
    {
        public bool ÍÎÏÎÎÌÍÏÎÍÎÏÏÎÌÌÎÍÎÍÌÌÍ;
        public UnityEngine.UI.Image ÏÏÎÍÌÍÍÍÏÎÌÌÍÎÍÏÌÌÎÍÏÎÏ; // 0x20
        public UnityEngine.UI.Image ÎÍÎÌÍÎÌÌÎÏÍÍÍÎÍÍÎÎÌÏÌÏÎ; // 0x28
        public UnityEngine.UI.Image ÏÍÍÎÏÎÎÌÌÍÍÌÍÌÎÍÏÏÌÌÏÌÎ; // 0x30
        public UnityEngine.Color ÏÍÎÌÌÌÌÎÍÌÎÍÎÍÎÏÎÎÍÏÏÍÍ; // 0x38
        public UnityEngine.Color ÏÎÎÍÎÎÍÎÎÎÍÍÌÎÏÍÌÏÍÍÍÌÏ; // 0x48
        public UnityEngine.Color ÍÏÎÍÏÍÍÌÌÎÎÍÎÏÏÍÍÍÏÍÍÏÌ; // 0x58
        public UnityEngine.Sprite ÎÎÌÍÍÏÍÍÌÏÎÏÌÏÎÎÍÍÎÎÏÎÏ; // 0x68
        public UnityEngine.Sprite ÏÌÏÍÌÍÏÌÍÍÌÌÍÎÌÌÏÌÏÎÎÌÎ; // 0x70
        public UnityEngine.UI.Image ÍÍÎÏÏÎÌÌÍÍÏÍÍÏÍÎÎÍÍÎÌÍÍ; // 0x78
        public UnityEngine.UI.Image ÏÏÌÏÌÍÏÏÌÌÎÌÎÌÎÎÍÍÌÌÎÌÌ; // 0x80
        public UnityEngine.UI.Image ÌÌÌÏÎÏÍÍÎÍÌÍÍÏÌÍÏÍÎÏÎÎÍ; // 0x88
        public UnityEngine.UI.Image ÍÎÍÌÍÏÎÌÎÏÎÍÍÎÍÎÎÍÌÏÍÌÌ; // 0x90
        public UnityEngine.UI.Image ÍÏÏÍÌÌÌÎÎÍÌÎÌÍÌÌÌÍÎÍÏÏÎ; // 0x98
        public UnityEngine.UI.Image ÍÌÎÌÏÏÌÏÏÏÍÏÏÌÎÏÎÏÎÏÎÍÍ; // 0xA0
        public UnityEngine.UI.Image ÏÌÍÏÏÎÍÎÍÍÎÍÌÍÍÍÎÏÍÍÎÎÍ; // 0xA8
        public UnityEngine.UI.Text ÌÎÍÌÏÍÍÍÌÎÎÎÌÍÏÌÎÍÎÎÎÌÏ; // 0xB0
        public UnityEngine.UI.Text ÎÌÌÍÎÎÎÎÌÎÎÏÌÌÏÌÏÌÍÍÏÌÍ; // 0xB8
        public UnityEngine.UI.Text ÌÎÍÎÏÏÎÍÎÏÎÏÏÏÌÌÏÌÎÌÎÍÍ; // 0xC0
        public UnityEngine.Color ÌÌÌÍÌÏÏÏÍÎÎÎÌÍÍÎÏÌÍÌÍÎÏ; // 0xC8
        public bool ÏÏÏÍÌÍÌÍÏÍÎÎÎÍÎÏÎÎÎÎÌÌÎ; // 0xD8
        public UnityEngine.Transform ÍÌÌÌÎÌÏÍÎÏÌÌÏÏÍÍÌÍÎÌÍÌÎ; // 0xE0
        public VRC.Core.ApiAvatar ÏÏÍÏÏÍÏÎÏÎÌÎÍÌÍÏÌÌÏÌÎÍÍ; // 0xE8
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÍÌÌÏÎÌÏÏÎÏÎÎÌÏÎÎÍÎÏÌÌÎÎ; // 0xF0
        public UnityEngine.Animator ÌÏÌÍÏÏÏÍÎÍÍÌÎÏÎÏÏÏÍÏÎÍÎ; // 0xF8
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ ÍÎÏÏÏÍÏÎÎÍÍÍÎÏÏÎÌÎÌÏÏÍÎ; // 0x100
        public ÌÏÍÎÎÎÏÍÌÍÌÍÏÏÌÌÎÍÌÎÌÎÏ ÏÌÎÍÏÏÎÏÍÎÌÍÌÌÌÏÎÏÌÌÌÎÏ; // 0x108
        public ÏÍÍÏÌÍÍÏÏÍÍÌÍÎÎÎÌÏÎÎÎÍÏ ÌÏÎÏÌÍÌÏÍÏÍÎÎÌÎÍÌÍÏÌÎÎÏ; // 0x110
        public ÍÏÍÏÏÎÏÌÎÏÌÌÌÍÌÌÎÍÏÍÎÎÌ ÏÏÏÍÍÌÏÌÏÏÍÏÎÏÍÎÍÍÎÏÎÏÎ; // 0x118
        public UnityEngine.AudioSource ÌÎÏÍÎÏÌÌÎÏÍÎÌÌÎÎÎÍÌÏÎÍÌ; // 0x120
        public OVRLipSyncContext ÍÌÌÎÌÎÌÎÏÌÍÎÎÌÌÍÏÏÌÏÍÏÎ; // 0x128
        public bool ÎÎÎÌÍÏÎÎÍÏÏÏÏÍÎÎÌÏÌÏÌÍÌ; // 0x130
        public bool ÌÍÍÎÌÎÍÍÍÌÍÌÌÍÎÏÎÌÎÌÌÏÏ; // 0x131
        public bool ÌÎÏÍÍÍÎÌÏÌÍÌÏÍÌÍÌÏÍÏÏÍÍ; // 0x132
        public int ÎÌÍÍÎÍÎÏÎÎÍÌÍÌÍÎÍÌÏÍÍÌÎ; // 0x134
        public int ÏÏÌÎÌÍÍÎÎÎÌÏÏÎÍÍÏÎÏÌÏÌÏ; // 0x138
        public bool ÍÌÏÏÌÌÎÍÎÍÌÎÍÌÍÏÌÎÏÏÌÏÎ; // 0x13C
        public int ÍÌÌÏÍÌÏÌÍÌÏÌÎÎÌÍÌÌÍÏÏÌÍ; // 0x140
        public string ÏÍÍÌÌÍÌÌÍÌÍÎÌÍÏÎÌÍÍÍÎÏÏ; // 0x148
        public string ÎÎÏÏÌÎÏÎÌÌÌÍÏÎÍÏÍÌÌÍÏÍÎ; // 0x150
        public UnityEngine.Vector3 ÍÌÌÏÎÏÎÏÏÍÌÏÏÎÍÎÏÌÎÎÎÍÎ; // 0x158
        public float ÎÌÍÍÌÏÎÎÍÍÍÍÎÌÏÎÏÏÏÌÍÌÏ; // 0x164
        public float[] ÍÏÎÍÏÎÏÌÎÌÏÍÍÌÏÍÍÏÎÎÌÏÎ; // 0x168

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC423D540
        public void RaiseCancellation(){} // RVA: 0x7FFAC2F21310
        public void IsInvoking(){} // RVA: 0x7FFAC423DD50
        public void CancelInvoke(){} // RVA: 0x7FFAC423E000
        public void Update(){} // RVA: 0x7FFAC423E4A0
        public void Awake(){} // RVA: 0x7FFAC423F930
        public void OnDestroy(){} // RVA: 0x7FFAC423FEF0
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void StartCoroutine(){} // RVA: 0x7FFAC42402C0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC4240350
        public void OnBecameVisible(){} // RVA: 0x7FFAC4240450
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC2F21310
        public void StopCoroutine(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC42404C0
        public void Initialize(){} // RVA: 0x7FFAC4240630
        public void StopAllCoroutines(){} // RVA: 0x7FFAC2F21310
        public void get_useGUILayout(){} // RVA: 0x7FFAC4240720
        public void set_useGUILayout(){} // RVA: 0x7FFAC4240BC0
        public void print(){} // RVA: 0x7FFAC4240BD0
        public void LoadAvatar(){} // RVA: 0x7FFAC4240C90
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC4241060
        public void InvokeDelayed(){} // RVA: 0x7FFAC4241150
        public void OnTriggerExit(){} // RVA: 0x7FFAC4240450
        public void .cctor(){} // RVA: 0x7FFAC42413E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC4241420
    }

    /// <summary>Originally: ÎÎÍÌÏÏÏÌÏÏÎÎÎÍÏÍÏÏÎÍÏÌÌ</summary>
    public class RefreshAvatarComponent_6DA1_6DA1 : MonoBehaviour
    {
        public int ÏÌÏÏÏÎÎÏÏÎÏÍÍÎÏÍÌÌÎÌÎÍÌ;
        public UnityEngine.GameObject ÌÎÎÌÏÌÏÎÌÏÌÏÍÏÏÎÏÎÍÌÏÍÌ; // 0x20
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ ÍÏÏÌÍÏÏÎÎÏÎÌÎÌÏÏÏÎÏÌÍÌÎ; // 0x28
        public UnityEngine.GameObject ÌÍÎÍÏÍÍÏÎÎÎÌÎÎÌÍÌÏÍÍÎÏÌ; // 0x30
        public UnityEngine.UI.Button ÏÌÍÌÌÎÍÍÏÍÎÏÎÎÏÎÏÌÌÎÏÍÏ; // 0x38
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÏÏÍÎÏÎÎÍÍÎÎÎÌÌÌÍÌÎÏÌÏÍÍ; // 0x40
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÎÎÏÌÏÏÏÌÌÌÏÌÎÎÎÏÏÌÌÎÍÎ; // 0x48
        public UnityEngine.GameObject ÎÎÍÍÍÏÎÍÏÌÌÏÏÍÎÌÌÌÍÌÌÎÍ; // 0x50
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ ÏÏÌÎÌÎÍÏÎÎÌÏÍÎÎÏÌÏÏÏÎÏÌ; // 0x58
        public UnityEngine.UI.Button ÏÎÎÎÌÍÏÏÏÌÏÎÍÌÌÎÍÏÍÍÌÏÎ; // 0x60
        public UnityEngine.GameObject ÏÌÍÏÏÌÏÎÎÏÍÎÍÏÌÎÍÍÌÌÏÎÌ; // 0x68
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ ÏÏÍÌÌÏÎÌÏÌÏÎÌÎÏÏÏÏÎÎÎÍÏ; // 0x70
        public UnityEngine.UI.Button ÍÍÍÍÎÎÏÏÍÎÍÌÎÍÏÍÎÏÎÌÎÌÎ; // 0x78
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÎÏÏÎÏÍÏÌÌÍÌÎÍÍÎÎÌÌÎÍÏÌÏ; // 0x80
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÎÌÍÎÌÎÍÎÎÍÎÏÏÍÍÌÏÍÎÎÏÏÍ; // 0x88
        public UnityEngine.UI.Button ÌÎÍÏÎÍÎÏÌÍÏÎÍÍÍÏÍÎÎÍÏÌÏ; // 0x90
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÏÍÏÍÎÍÏÏÌÍÎÏÍÎÌÎÏÍÍÌÍÎ; // 0x98
        public ÎÌÏÎÌÌÏÍÍÍÏÍÏÌÏÍÏÍÏÏÏÏÎ ÏÌÌÌÌÎÏÌÌÎÎÎÍÏÍÏÎÌÏÎÌÌÏ; // 0xA0
        public UnityEngine.UI.Button ÌÍÎÏÎÏÌÎÌÌÏÍÎÎÍÌÌÍÍÌÏÌÎ; // 0xA8
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÌÏÏÎÌÏÍÎÎÌÏÍÏÏÏÌÎÍÏÍÌÍ; // 0xB0
        public UnityEngine.UI.Button ÏÌÎÍÌÏÏÌÌÎÎÍÌÌÌÎÏÏÌÍÎÌÍ; // 0xB8
        public UnityEngine.GameObject ÌÌÌÏÎÎÎÌÎÍÏÍÎÍÎÌÎÎÌÎÍÏÌ; // 0xC0
        public UnityEngine.UI.Toggle ÎÌÌÎÎÍÏÏÌÌÏÌÏÏÌÏÏÌÎÎÎÎÍ; // 0xC8
        public ÍÎÎÍÍÍÏÏÍÌÏÎÎÏÍÌÌÍÎÌÏÌÏ ÍÎÌÎÎÍÎÌÏÎÍÎÍÎÌÍÏÏÏÌÍÎÌ; // 0xD0
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÍÎÌÍÌÌÍÍÌÌÎÏÎÍÏÍÏÏÏÏÎÏÍ; // 0xD8
        public ÎÌÏÎÍÎÏÌÍÌÍÌÎÌÎÎÍÌÏÎÏÏÏ ÎÎÏÍÏÍÍÌÏÌÎÎÍÎÌÎÌÍÏÍÌÌÍ; // 0xE0
        public ÌÌÍÍÏÌÏÏÏÌÏÍÍÏÎÌÌÌÎÍÎÏÏ _badgesListBinding; // 0xE8
        public ÌÍÍÍÎÌÍÍÎÎÍÏÎÌÌÏÎÏÎÎÌÌÏ ÍÍÎÍÌÏÏÍÎÎÍÏÎÌÍÏÍÌÏÏÌÎÏ; // 0xF0
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.List`1<ÍÎÏÍÎÍÌÎÎÌÍÏÍÎÏÏÍÏÏÌÎÍÍ>> ÍÌÎÌÏÎÏÍÏÌÏÍÎÏÎÍÎÌÍÍÍÌÍ; // 0xF8

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB37D880
        public void RaiseCancellation(){} // RVA: 0x7FFACB37DCA0
        public void IsInvoking(){} // RVA: 0x7FFACB37DDD0
        public void CancelInvoke(){} // RVA: 0x7FFACB37DE70
        public void OnEnable(){} // RVA: 0x7FFACB37DF10
        public void InvokeRepeating(){} // RVA: 0x7FFACB37E730
        public void FixedUpdate(){} // RVA: 0x7FFACB37E880
        public void OnDisable(){} // RVA: 0x7FFACB37EFF0
        public void StartCoroutine(){} // RVA: 0x7FFACB37F3F0
        public void OnApplicationPause(){} // RVA: 0x7FFACB37F520
        public void OnDestroy(){} // RVA: 0x7FFACB37FBF0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB37FD40
        public void Start(){} // RVA: 0x7FFACB380410
        public void RefreshAvatar(){} // RVA: 0x7FFACB380A10
        public void StopCoroutine(){} // RVA: 0x7FFACB380CF0
        public void .ctor(){} // RVA: 0x7FFACB381510
        public void Initialize(){} // RVA: 0x7FFACB3816F0
        public void set_useGUILayout(){} // RVA: 0x7FFACB381E60
        public void print(){} // RVA: 0x7FFACB382010
    }

}