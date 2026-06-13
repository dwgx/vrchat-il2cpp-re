// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Transform
// Classes: 2
// Methods: 521

namespace VRC.Core.Transform
{
    /// <summary>Originally: ÍÏÎÏÍÌÏÍÏÌÎÌÍÍÍÍÍÍÌÍÌÍÏ</summary>
    public class IMDrawTransformGizmoController
    {
        public ÍÏÎÏÍÌÏÍÏÌÎÌÍÍÍÍÍÍÌÍÌÍÏ ÌÎÏÎÏÏÎÎÏÍÍÎÍÍÌÍÍÏÏÍÍÎÌ;
        public System.Action ÎÌÎÎÏÌÏÏÌÍÍÌÏÎÍÍÌÌÍÌÌÎÎ; // 0x8
        public System.Action`1<float> ÎÌÍÏÎÎÍÎÌÏÌÎÍÏÍÏÏÏÎÍÍÌÎ; // 0x10
        public string ÎÏÎÎÍÍÎÌÏÍÍÍÍÎÌÏÏÍÏÏÌÍÌ;
        public bool ÏÎÌÍÎÎÌÏÎÏÌÏÎÎÍÌÏÌÏÌÍÎÌ; // 0x20
        public UnityEngine.Transform ÌÏÌÎÍÌÎÌÏÎÌÏÌÏÍÎÎÌÍÍÍÍÍ; // 0x28
        public ÏÎÍÏÏÍÏÏÍÏÎÌÏÌÏÎÍÎÎÌÍÌÏ ÎÍÍÍÍÏÌÏÏÎÍÍÏÏÌÍÍÏÌÎÍÌÌ; // 0x30
        public ÏÏÎÍÍÏÍÌÌÏÌÍÎÌÌÍÏÏÏÎÍÎÏ ÍÍÌÏÌÌÍÏÌÌÌÌÎÌÍÎÎÍÏÏÌÏÎ; // 0x38
        public ÌÎÌÍÎÎÎÍÍÏÏÎÏÍÏÏÌÍÏÍÏÎÌ ÎÏÏÎÏÍÌÍÌÌÏÍÍÏÍÎÏÎÌÎÍÏÎ; // 0x40
        public ÌÏÍÏÌÏÏÍÎÎÌÏÎÏÎÏÌÌÏÏÎÏÏ ÎÍÏÎÌÌÍÍÏÎÍÏÎÍÌÏÎÏÍÏÎÍÏ; // 0x48
        public bool ÎÎÍÏÍÏÌÏÌÏÍÌÎÏÌÎÏÍÏÏÍÎÌ; // 0x50
        public UnityEngine.Sprite ÌÍÍÏÌÍÏÌÌÎÍÎÏÎÍÏÌÍÎÎÎÎÎ; // 0x58
        public string ÎÍÏÏÎÌÌÎÍÏÍÍÌÏÏÎÍÌÍÎÍÏÍ; // 0x60
        public string ÌÏÌÏÎÌÌÍÎÏÏÌÌÍÍÏÏÏÏÍÍÌÏ; // 0x68
        public string ÎÏÎÌÏÍÎÎÌÏÌÎÎÍÍÎÏÎÍÏÏÍÌ; // 0x70
        public string ÌÌÌÍÌÌÎÏÎÍÍÏÏÏÏÎÌÎÏÏÍÎÏ; // 0x78
        public string ÌÏÌÏÏÎÌÍÏÎÎÍÍÎÏÌÎÎÍÏÏÌÏ; // 0x80
        public string ÌÎÌÌÍÌÌÎÎÍÎÍÍÎÏÍÌÍÎÏÍÏÍ; // 0x88
        public string ÎÌÍÌÍÎÎÌÌÎÎÍÏÍÍÌÏÎÌÌÏÌÏ; // 0x90
        public string ÌÍÎÏÏÍÍÌÎÎÎÎÎÎÏÌÍÏÏÌÏÍÎ; // 0x98
        public string ÌÎÌÏÍÌÌÎÎÏÍÌÌÎÌÎÌÌÌÎÎÎÏ; // 0xA0
        public string ÎÎÏÎÎÎÍÌÌÎÌÍÍÏÍÌÏÏÍÎÌÏÏ; // 0xA8
        public string ÏÌÌÍÌÌÍÎÎÌÍÍÎÏÎÎÏÎÎÍÍÎÌ; // 0xB0
        public string ÌÏÎÌÌÍÌÌÍÌÍÏÌÌÍÏÍÎÎÍÍÌÎ;
        public string ÍÍÎÏÎÍÌÎÎÍÍÏÌÏÍÍÎÎÍÏÍÎÍ;
        public ÎÌÍÎÌÌÌÎÎÏÍÌÏÍÍÍÎÍÏÎÎÎÎ ÏÎÍÍÎÍÎÎÌÎÌÏÍÏÎÏÏÎÌÍÎÏÍ; // 0xB8
        public ÏÏÍÍÌÌÍÌÏÍÍÎÍÎÏÏÏÌÏÎÌÌÌ _bodyEstimation; // 0xC0
        public UnityEngine.GameObject ÏÎÏÌÎÏÎÍÌÏÏÏÎÎÍÎÌÌÏÎÏÍÏ; // 0xC8
        public UnityEngine.GameObject ÎÍÏÌÎÍÍÏÎÌÍÎÎÍÍÏÍÌÏÍÎÎÌ; // 0xD0
        public UnityEngine.GameObject ÎÏÍÍÍÌÍÍÎÎÌÍÌÌÍÌÏÍÏÎÍÍÍ; // 0xD8
        public UnityEngine.Transform _inverseScaleRoot; // 0xE0
        public VRC.IMDraw ÌÏÌÌÍÎÍÎÍÍÎÍÎÎÎÎÏÌÍÏÎÎÌ; // 0x18
        public ÌÍÏÌÏÏÍÌÍÍÍÌÌÎÎÌÍÍÏÏÏÌÌ ÎÎÌÎÌÌÌÍÌÎÌÌÌÎÎÏÌÏÎÏÎÍÎ; // 0x20
        public ÌÍÏÌÏÏÍÌÍÍÍÌÌÎÎÌÍÍÏÏÏÌÌ ÍÎÏÎÌÍÎÎÏÍÍÌÎÍÎÎÏÏÏÍÍÌÏ; // 0x28
        public ÌÍÏÌÏÏÍÌÍÍÍÌÌÎÎÌÍÍÏÏÏÌÌ ÎÏÎÍÏÎÍÏÌÏÍÍÌÎÍÌÎÌÍÌÌÎÏ; // 0x30
        public System.Collections.Generic.Dictionary`2<string,ÌÍÏÌÏÏÍÌÍÍÍÌÌÎÎÌÍÍÏÏÏÌÌ> ÎÍÎÏÎÏÎÌÌÎÎÌÌÍÎÍÏÍÏÌÌÏÍ; // 0x38
        public UnityEngine.Transform ÌÌÌÏÍÍÍÍÎÏÏÌÍÏÎÏÍÌÎÎÏÎÍ; // 0x40
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÍÎÌÌÍÏÌÍÏÍÌÍÏÍÎÏÏÌÎÍÍÍÌ; // 0x48
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÏÎÏÎÍÏÎÍÌÍÌÎÌÏÎÍÍÍÌÏÏÌÍ; // 0x50
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÍÎÏÎÎÎÍÎÎÎÏÏÌÌÍÏÏÍÏÍÌÌÎ; // 0x58
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÌÎÌÏÎÏÌÌÍÍÏÍÍÏÍÏÏÏÎÍÏÏÌ; // 0x60
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÏÍÍÏÍÎÍÏÏÏÏÌÍÏÌÏÍÌÎÎÍÍÏ; // 0x68
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÏÌÌÌÍÍÎÍÏÍÌÎÌÍÍÌÍÎÌÏÏÏÍ; // 0x70
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÏÌÌÍÌÏÌÏÎÌÌÎÎÍÎÍÍÌÌÎÏÍÍ; // 0x78
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ ÍÍÎÏÏÌÍÎÏÎÏÌÏÏÌÌÍÌÌÍÌÍÏ; // 0x80
        public System.Collections.Generic.List`1<string> ÍÏÏÎÌÌÎÎÍÍÌÍÍÎÍÎÍÌÏÎÏÏÍ; // 0x88
        public float[] ÍÎÏÌÎÎÍÏÍÎÏÎÍÍÎÎÏÍÏÎÏÎÏ; // 0x90
        public ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ[] ÍÎÍÌÌÍÎÌÌÌÎÌÌÏÎÌÌÎÌÎÍÌÎ; // 0x98
        public bool[] ÍÍÎÏÎÏÍÏÍÍÏÍÌÎÌÎÌÏÌÍÎÏÏ; // 0xA0
        public bool ÏÎÍÍÌÌÎÌÏÌÏÌÏÍÏÎÌÎÍÎÎÍÌ; // 0xA8
        public bool ÎÌÎÍÎÏÌÎÎÎÌÍÍÎÍÍÌÌÌÎÍÍÏ; // 0xA9
        public bool ÏÍÎÎÍÌÎÌÎÌÎÍÍÌÎÏÏÌÌÏÍÍÍ; // 0xAA
        public bool ÌÎÌÏÍÎÌÍÌÏÍÌÍÎÏÌÍÎÍÍÎÍÌ; // 0xAB
        public bool ÎÏÌÏÏÌÌÌÎÏÎÍÏÎÍÏÍÍÎÏÏÌÌ; // 0xAC
        public bool ÌÎÌÍÌÏÌÎÌÍÍÎÍÏÌÍÌÏÎÍÏÎÌ; // 0xE8
        public bool ÎÏÏÍÏÎÏÌÍÌÍÌÏÌÌÎÎÏÎÏÌÌÌ; // 0xE9
        public System.Collections.Generic.List`1<ÍÎÌÌÎÌÎÍÎÏÎÏÌÏÌÏÍÌÎÍÎÌÌ> ÎÎÏÏÍÍÍÎÏÎÌÏÌÎÌÎÎÌÍÎÎÍÎ; // 0xF0
        public System.Collections.Generic.Dictionary`2<0x65714FD0,ÏÎÌÌÍÍÏÌÏÎÌÏÍÍÌÍÌÎÏÏÌÏÌ> ÎÍÎÎÎÌÏÎÍÌÎÎÌÎÍÍÍÏÎÏÍÎÎ; // 0xB0
        public float <ÎÍÏÌÎÌÏÎÎÌÏÎÌÌÏÏÌÌÌÎÎÎÏ>k__BackingField; // 0xB8
        public float <ÌÏÌÍÌÍÍÎÎÍÌÏÏÌÍÎÏÍÎÏÎÏÏ>k__BackingField; // 0xBC
        public float ÌÌÏÌÏÏÌÎÎÏÎÏÎÌÌÍÎÌÍÌÌÌÎ; // 0xC0
        public float ÏÌÌÍÎÎÍÍÏÌÍÏÌÏÍÏÌÍÍÎÍÏÍ; // 0xC4
        public UnityEngine.Vector3 ÎÎÏÌÌÏÏÎÌÎÏÌÎÍÏÎÎÍÍÎÌÍÎ; // 0xC8
        public UnityEngine.Vector3 ÍÌÏÏÎÌÎÏÍÏÍÌÎÌÌÍÎÌÏÎÍÌÍ; // 0xD4
        public UnityEngine.Vector3 ÍÏÎÍÎÍÎÌÎÌÏÌÎÏÎÍÎÎÏÍÍÌÍ; // 0xE0
        public bool ÌÍÎÍÍÏÎÍÏÌÍÎÎÍÍÍÍÏÍÏÍÍÌ; // 0xEC
        public int ÍÌÌÍÍÏÌÍÏÎÍÌÏÌÍÍÎÏÏÎÏÎÎ; // 0xF0
        public float ÌÏÌÎÌÌÏÌÎÍÏÍÍÎÌÍÌÍÍÍÎÌÏ;
        public float ÎÎÏÍÍÎÏÍÏÌÏÌÍÌÍÎÍÍÍÎÎÎÏ;
        public float ÎÍÌÏÎÎÌÏÎÎÍÎÌÏÌÏÏÌÌÍÌÏÍ;
        public float ÏÍÌÏÎÌÍÎÎÍÎÌÍÌÍÍÎÏÏÍÌÎÎ;
        public float ÏÏÏÏÎÏÎÏÌÍÌÏÎÎÌÏÍÍÌÌÌÎÍ;
        public float ÍÎÍÌÎÎÌÌÌÍÏÎÍÍÌÍÏÏÏÍÌÏÍ;
        public float ÍÎÎÍÌÎÍÏÏÌÏÎÌÏÎÌÎÍÍÌÌÎÍ;
        public float ÎÌÍÏÎÏÏÍÌÍÎÌÏÎÏÏÌÎÏÎÎÏÌ;
        public float ÏÎÎÏÍÎÎÏÎÍÎÎÏÎÎÍÌÍÍÎÌÌÍ;
        public float ÌÎÎÎÍÏÌÌÎÍÍÏÏÏÏÍÍÍÌÏÎÍÏ;
        public float ÎÌÏÎÎÌÏÍÍÎÌÎÎÍÍÎÍÎÍÌÍÏÍ;
        public float ÍÍÎÏÎÎÌÍÍÍÎÌÎÎÍÌÏÍÍÎÌÌÍ;
        public string ÍÌÌÍÌÍÍÏÎÏÍÍÍÎÏÍÎÌÎÌÏÎÏ;
        public bool ÌÎÍÍÌÎÎÎÍÍÏÍÍÌÌÎÌÌÌÍÏÍÌ; // 0xF8
        public bool ÌÌÏÍÏÍÏÍÏÍÌÌÍÏÍÍÏÌÌÌÏÏÍ; // 0xF9
        public bool ÎÍÍÌÏÏÌÌÍÏÏÏÍÌÌÏÌÌÍÍÌÏÌ; // 0xFA
        public UnityEngine.Vector3 ÌÏÍÎÏÎÍÎÌÎÎÌÍÎÌÏÍÌÏÍÌÎÌ; // 0xFC
        public UnityEngine.Quaternion ÎÌÏÍÎÍÎÍÍÍÍÍÏÎÏÎÎÏÌÌÎÏÎ; // 0x108
        public float ÍÌÍÍÎÌÍÌÏÎÌÏÍÎÌÍÍÍÏÍÏÍÎ; // 0x118
        public UnityEngine.Vector3 ÍÍÏÌÍÍÍÎÌÎÎÌÏÎÍÌÏÏÌÍÏÎÎ; // 0x11C
        public ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<bool> ÏÌÌÏÍÌÍÏÎÎÏÎÌÍÌÍÍÏÎÍÏÌÌ; // 0x128
        public ÌÏÍÎÎÎÍÍÎÌÏÍÍÏÌÌÎÎÏÌÌÏÍ ÍÎÏÎÎÏÏÍÌÍÍÌÎÎÌÏÌÏÏÎÏÌÌ; // 0x130
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ ÏÍÍÏÍÎÌÌÎÏÎÌÌÍÍÎÎÍÏÎÌÎÍ; // 0x138
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ ÌÏÏÍÎÌÌÌÏÏÏÌÌÏÍÏÏÎÎÏÏÍÎ; // 0x140
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ ÍÏÌÏÎÌÍÍÌÌÌÏÎÌÍÏÍÎÏÏÌÏÍ; // 0x148
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ ÎÌÏÎÌÌÎÏÌÎÌÎÍÎÏÍÌÎÎÍÌÏÍ; // 0x150
        public bool ÌÌÏÏÌÌÏÎÍÌÎÍÎÎÌÍÏÌÏÍÌÎÌ; // 0x158
        public bool ÎÏÏÎÌÏÍÌÍÏÍÏÎÏÌÎÎÏÌÎÏÏÏ; // 0x159
        public 0x65714FD0 ÏÌÎÏÌÎÎÎÎÍÌÍÌÍÍÏÏÎÌÎÌÏÎ; // 0x15C
        public 0x65714FD0 ÏÎÌÎÍÏÍÌÏÏÏÏÍÏÍÌÍÍÍÎÏÍÎ; // 0x160
        public 0x65714FD0 ÌÍÍÏÍÍÌÏÏÏÏÍÌÌÎÏÎÌÎÌÌÏÏ; // 0x164
        public 0x65714FD0 ÌÌÏÏÌÌÍÍÌÍÏÏÍÍÍÍÎÍÌÌÏÌÍ; // 0x168
        public UnityEngine.Vector3 ÍÌÏÏÌÏÎÍÏÏÌÏÏÎÍÎÌÌÌÍÎÏÍ; // 0x16C
        public UnityEngine.Quaternion ÏÏÍÏÌÍÎÌÎÍÎÎÏÌÎÌÏÏÎÎÍÏÏ; // 0x178
        public float ÎÏÏÌÍÎÍÏÎÌÏÏÌÌÏÏÎÎÎÏÏÍÍ; // 0x188
        public float ÏÌÎÍÍÏÏÍÎÎÏÎÏÌÎÎÍÏÏÎÍÎÌ; // 0x18C
        public float ÌÍÌÎÏÌÎÎÍÍÌÎÏÏÎÍÏÌÏÍÎÍÏ; // 0x190
        public float ÎÍÎÏÌÍÏÍÍÎÏÍÎÌÎÌÎÍÍÍÍÏÌ;
        public float ÏÌÍÎÍÎÏÏÏÎÍÌÏÌÏÏÏÎÏÎÎÎÌ;
        public bool ÍÍÎÍÍÎÍÎÍÌÍÎÏÌÍÏÎÏÍÍÏÎÏ; // 0x194
        public float ÌÌÎÌÎÏÎÌÏÎÎÏÌÏÏÎÏÌÎÏÍÎÎ;
        public float ÎÍÎÎÍÍÏÏÍÎÌÏÍÌÎÎÌÏÎÌÌÎÌ;
        public string ÌÍÍÌÎÏÏÍÏÌÎÎÎÎÏÍÍÏÍÏÏÏÏ;
        public string ÌÌÌÏÍÌÎÏÍÌÌÎÏÌÌÍÍÌÍÌÎÎÌ;
        public string ÌÌÎÍÏÎÌÌÌÍÌÍÎÌÏÌÎÎÎÍÌÏÍ;
        public int ÏÍÍÌÎÎÎÌÎÏÎÌÍÍÍÌÎÌÏÎÏÍÍ; // 0x198
        public string ÏÎÎÌÏÏÍÎÏÏÎÎÏÎÍÏÎÌÎÌÏÌÌ;
        public string ÍÌÏÏÌÌÍÌÍÌÎÎÏÌÌÏÏÌÏÎÏÎÏ;
        public string ÏÏÌÏÏÎÍÏÏÍÏÌÎÎÏÌÎÏÍÌÌÎÌ;
        public string ÌÍÎÏÌÎÍÌÎÌÏÎÎÎÌÏÎÎÍÌÏÏÍ;
        public string ÏÎÏÌÌÎÏÌÏÌÍÍÏÌÎÌÌÌÎÌÌÎÍ;
        public string ÏÎÏÏÍÍÌÎÎÌÍÏÎÎÎÏÏÎÌÌÍÎÎ;
        public string ÏÏÏÏÎÍÏÎÌÏÏÎÏÌÍÌÏÍÏÌÌÍÍ;
        public string ÏÍÎÍÍÏÌÍÎÌÌÏÏÎÏÏÎÏÍÌÎÏÏ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x152A100
        public void RaiseCancellation(){} // RVA: 0xD91360
        public void get_DebounceTimeError(){} // RVA: 0x152A2B0
        public void CancelInvoke(){} // RVA: 0x2DD310
        public void Invoke(){} // RVA: 0x152A6F0
        public void InvokeRepeating(){} // RVA: 0xA94F10
        public void ProcessNetworkDisposal(){} // RVA: 0x152A990
        public void IsInvoking(){} // RVA: 0x152AEA0
        public void StartCoroutine(){} // RVA: 0x152AFB0
        public void DrawGizmoLine_677E3DFAA4B1(){} // RVA: 0x154B690 | overloaded x2
        public void GetUnityEngine(){} // RVA: 0x152B3F0
        public void set_PhysBoneChainList(){} // RVA: 0x152B6C0
        public void StopCoroutine(){} // RVA: 0x152B720
        public void UpdateDualBooleanText(){} // RVA: 0xD88A80
        public void StopAllCoroutines(){} // RVA: 0x152BB20
        public void set_yogaNode(){} // RVA: 0xD94B90
        public void set_useGUILayout(){} // RVA: 0x152BB80
        public void print(){} // RVA: 0x152BBE0
        public void GetParameterValueBySlotType(){} // RVA: 0x152BFC0
        public void SetSyncedIntFieldAt928(){} // RVA: 0x152C330
        public void InvokeDelayed(){} // RVA: 0x152C5F0
        public void get_Stats(){} // RVA: 0x152C650
        public void DoGetBlendShapeName(){} // RVA: 0x152CC40
        public void Awake_8738EF06222C(){} // RVA: 0x152D120
        public void StartCoroutineManaged(){} // RVA: 0x152D180
        public void StartCoroutineManaged2(){} // RVA: 0x152D1E0
        public void StopCoroutineManaged(){} // RVA: 0x152D4C0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x152DB80
        public void GetScriptClassName(){} // RVA: 0x152DBD0
        public void OnCancellationTokenCreated(){} // RVA: 0x152DBF0
        public void GetPosition(){} // RVA: 0x152DCE0
        public void Update(){} // RVA: 0x152DE00
        public void GetNetworkPlayerReference(){} // RVA: 0x152DFB0
        public void DoOpenURL(){} // RVA: 0x152E150
        public void OnBecameInvisible(){} // RVA: 0xD90650
        public void get_onEndTextSelection(){} // RVA: 0x152E160
        public void OnCollisionStay(){} // RVA: 0x152E4C0
        public void StartCoroutine_21F91E392682(){} // RVA: 0xD9F490
        public void OnTriggerEnter(){} // RVA: 0xD85A20
        public void OnTriggerStay(){} // RVA: 0x152E560
        public void OnTriggerExit(){} // RVA: 0x152E610
        public void SetRotation(){} // RVA: 0x152E7C0
        public void GetRotation(){} // RVA: 0x152EE00
        public void IsTypeExcludedFromValidation(){} // RVA: 0xD8AAB0
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x152EF50
        public void UpdateVRCSecondary(){} // RVA: 0xD8A490
        public void SyncFixedDeltaTimeToTimeScale(){} // RVA: 0x152F180
        public void OnEnable(){} // RVA: 0x152F420
        public void IsPhysBoneStateComplete(){} // RVA: 0x152F8B0
        public void FixedUpdate(){} // RVA: 0x152F910
        public void SetIsWeb(){} // RVA: 0x152FD90
        public void GetMemoryUsageMegabytes(){} // RVA: 0x152FEE0
        public void OnDisable(){} // RVA: 0x152FF40
        public void OnDestroy_6B4EF51EAB48(){} // RVA: 0x152FFA0
        public void SetFixedDeltaTime(){} // RVA: 0x1530000
        public void OnApplicationQuit(){} // RVA: 0x1530080
        public void GetBackingFieldFromProperty_272(){} // RVA: 0x1530110
        public void get_PhysBonePullStrength(){} // RVA: 0x1530160
        public void OnCollisionEnter(){} // RVA: 0x15301C0
        public void set_PhysBoneMaxStretch(){} // RVA: 0xD85210
        public void SetConnectedBody(){} // RVA: 0x1530790
        public void IsComponentActiveAtOffset280(){} // RVA: 0x15307E0
        public void get_PhysBoneGravityDirection(){} // RVA: 0x1530840
        public void ApplyLocalRotationAndScale(){} // RVA: 0x15308A0
        public void set_leftEyeAngularAcceleration(){} // RVA: 0xD88BD0
        public void set_CameraSelector(){} // RVA: 0xD870C0
        public void GetVRCSecondary(){} // RVA: 0x1530900
        public void DispatchCachedPayload(){} // RVA: 0xD90BA0
        public void SetLocalPosition(){} // RVA: 0xA57F60
        public void GetPropertyValueAtOffset520(){} // RVA: 0xDA0BC0
        public void ProcessNetworkData(){} // RVA: 0x1530F10
        public void ApplyLocalPosition(){} // RVA: 0x1530F60
        public void SetLocalRotation(){} // RVA: 0x15310C0
        public void get_PlatformOptionsWebGL(){} // RVA: 0xD86540
        public void OnGUI(){} // RVA: 0x1531270
        public void TransformPoint(){} // RVA: 0x15312C0
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x1531590
        public void GetPosition_4AFD2D08F8B0(){} // RVA: 0x15315F0
        public void TransformPointFromLocal(){} // RVA: 0x15317E0
        public void SetSyncedBoolFieldAt976(){} // RVA: 0x1531990
        public void get_PhysBoneRadiusCurve(){} // RVA: 0x1531CB0
        public void HasMediaPlayerKeyRegistered(){} // RVA: 0xD90650
        public void set_CrashedLastRun(){} // RVA: 0x1531D10
        public void GetMainCamera(){} // RVA: 0x1531D80
        public void GetDeltaTime(){} // RVA: 0x1531DE0
        public void GetMemoryUsageMegabytes_D5460BBCB93F(){} // RVA: 0xD9D6A0
        public void set_PhysBoneGrabIntensity(){} // RVA: 0x1531F90
        public void GetPlayerCountDisplayValue(){} // RVA: 0x1532010
        public void TransformPointWithRotation(){} // RVA: 0x15320C0
        public void get_MouseCursor(){} // RVA: 0x15323B0
        public void get_last_platform(){} // RVA: 0x1532560
        public void ProcessVRCSecondary(){} // RVA: 0x1532630
        public void get_PhysBoneGravityPower(){} // RVA: 0x1532F20
        public void get_PostInitCallbacks(){} // RVA: 0x2DD320
        public void set_leftTriggerButton(){} // RVA: 0x1532FF0
        public void NotifyWorkItemProgressNative(){} // RVA: 0x15331A0
        public void get_onTextSelection(){} // RVA: 0x1533200
        public void ApplyLocalTransform(){} // RVA: 0x1533260
        public void CopyWorldTransform(){} // RVA: 0x1533580
        public void DoInverseTransformPoint_Injected_582(){} // RVA: 0x1533590
        public void GetDeltaTime_2E5(){} // RVA: 0x15336D0
        public void GetDeltaTime_06E(){} // RVA: 0x1533870
        public void SetSyncedFloatFieldAt592(){} // RVA: 0xD915D0
        public void GetBackingFieldFromProperty_832(){} // RVA: 0x1533A10
        public void ResetAndRebuildComponentState(){} // RVA: 0xD90760
        public void Initialize(){} // RVA: 0x1534120
        public void get_SynchronizingObject(){} // RVA: 0x15342F0
        public void ProcessNetworkDisposal_5B7304DD072F(){} // RVA: 0x1534380
        public void FindObjectsByMultipleCriteria(){} // RVA: 0x1534450
        public void get_Transform(){} // RVA: 0x15344B0
        public void LateUpdate(){} // RVA: 0x1534510
        public void TransitionToStateWithError(){} // RVA: 0x1535B30
        public void InverseTransformPoint(){} // RVA: 0x15364E0
        public void GetTexture(){} // RVA: 0x1536530
        public void get_statusDescription(){} // RVA: 0x1536590
        public void set_recentering(){} // RVA: 0x15365E0
        public void SetSyncedBoolFieldAt704(){} // RVA: 0x1536650
        public void PacketGetSize(){} // RVA: 0x15366B0
        public void GetSource(){} // RVA: 0x1536710
        public void GetParent_4F7(){} // RVA: 0x1536890
        public void SampleUnscaledDeltaTime(){} // RVA: 0xD95E20
        public void CreateFilteredInstanceFromType(){} // RVA: 0x15369F0
        public void HandleVRCSecondary(){} // RVA: 0x1536A50
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x1536B90
        public void DoInverseTransformPoint_Injected_BA6(){} // RVA: 0x1536BF0
        public void SetSocialStatus(){} // RVA: 0x1537080
        public void get_ExperimentalMetrics(){} // RVA: 0xD94490
        public void DoFindRelativeTransformWithPath_9C3(){} // RVA: 0xD94B20
        public void get_ContactReceiverList(){} // RVA: 0x15373E0
        public void get_DebounceTimeWarning(){} // RVA: 0xD9BA80
        public void set_PhysBoneColliderList(){} // RVA: 0x1537440
        public void ThrowMissingMethodException(){} // RVA: 0x15374A0
        public void set_PostInitCallbacks(){} // RVA: 0x1537840
        public void EnablePhysBoneWithCollision(){} // RVA: 0xD89FC0
        public void UpdatelodBia(){} // RVA: 0xDB44F0
        public void SlerpTowardsRotation(){} // RVA: 0x1537A50
        public void GetBackingFieldFromProperty_1048(){} // RVA: 0x3480B0
        public void set_LiveChild(){} // RVA: 0x1537F10
        public void GetEnabled(){} // RVA: 0x15380F0
        public void GetLocalToWorldMatrix(){} // RVA: 0x1538150
        public void .cctor_0A6409316A6B(){} // RVA: 0x15381D0
        public void set_home(){} // RVA: 0x1538220
        public void QuaternionFromEuler(){} // RVA: 0x15382D0
        public void ComputeactiveSelf(){} // RVA: 0x15385D0
        public void GetTransform_349(){} // RVA: 0x1538820
        public void GetTransform_C7C(){} // RVA: 0x15389C0
        public void get_PhysBoneRadiusCurve_EADAD9E77A8F(){} // RVA: 0x1538A20
        public void get_DebounceTimeLog(){} // RVA: 0x2DD310
        public void CreateTransformData(){} // RVA: 0x1538AC0
        public void set_leftTrigger(){} // RVA: 0x1538E90
        public void CreateParentRelativeTransformData(){} // RVA: 0x1538F40
        public void CreateTransformState(){} // RVA: 0x1538FA0
        public void get_AcceptCharacter(){} // RVA: 0x1539000
        public void GetStats(){} // RVA: 0x1539060
        public void GetTransform(){} // RVA: 0xD9A440
        public void set_status(){} // RVA: 0x1539130
        public void get_Playlist(){} // RVA: 0x1539860
        public void SlerpRotation(){} // RVA: 0x15398C0
        public void get_hierarchy(){} // RVA: 0x1539AF0
        public void DoSave(){} // RVA: 0x1539B50
        public void ClearTrackedReferenceAndLog(){} // RVA: 0xD94B80
        public void SetColor(){} // RVA: 0x1539CA0
        public void get_AssemblyReader(){} // RVA: 0x153A330
        public void set_TracesSampler(){} // RVA: 0xDA70C0
        public void OrthoOffsetToScreenBounds(){} // RVA: 0xD9AA90
        public void DrawGizmos(){} // RVA: 0x153A840
        public void get_PhysBoneStretchMotion(){} // RVA: 0x153AD40
        public void GetPropertyValueAtOffset1240(){} // RVA: 0x153B000
        public void Awake(){} // RVA: 0x153B060
        public void SetSyncedFloatFieldAt1024(){} // RVA: 0x153B4F0
        public void SetBoolPropertyWithBroadcast624(){} // RVA: 0x153B550
        public void get_RotationConstraintRefs(){} // RVA: 0x153B5B0
        public void SetTrackedReferenceAndRefreshState(){} // RVA: 0x153BBF0
        public void DoInternal_FromEulerRad_Injected_173(){} // RVA: 0x153BC50
        public void Internal_IsInvokingAll(){} // RVA: 0x153C020
        public void SetHeadLookEnabled(){} // RVA: 0x153C300
        public void IsDesktopReticleEnabled(){} // RVA: 0xD97D00
        public void UpdateLocalPointCache(){} // RVA: 0x153C350
        public void get_FailedRequestStatusCodes(){} // RVA: 0xD83050
        public void get_leftEyeAngularAcceleration(){} // RVA: 0x153C3A0
        public void set_PhysBoneGrabIntensity_C364CA1335C9(){} // RVA: 0x1530F10
        public void GetStore(){} // RVA: 0x153C400
        public void ReadRelativeLocalPose(){} // RVA: 0x153CA40
        public void SwitchActiveInputMethod(){} // RVA: 0x153CD30
        public void GetPropertyValueAtOffset1088(){} // RVA: 0x153CD70
        public void Initialize_344A43F1B600(){} // RVA: 0x153D3A0
        public void Encode(){} // RVA: 0x153D400
        public void GetBackingFieldFromProperty_1016(){} // RVA: 0x153D920
        public void get_listingIds(){} // RVA: 0x153DA80
        public void SetBoolPropertyWithBroadcast464(){} // RVA: 0x153DB30
        public void set_domainList(){} // RVA: 0x153DEB0
        public void OnProductsRetrieved(){} // RVA: 0x153DF20
        public void set_NativeSupportCloseCallback(){} // RVA: 0x153DFD0
        public void get_yogaNode(){} // RVA: 0xD90E40
        public void GetGameObject_9D7(){} // RVA: 0x153E110
        public void InvalidatePathCache(){} // RVA: 0xDB4D60
        public void SetGlobalBooleanProperty(){} // RVA: 0x153E170
        public void SetBoolPropertyWithNotify152(){} // RVA: 0x153E1D0
        public void GetBackingFieldFromProperty_832_30B73C7ED2CC(){} // RVA: 0x153E380
        public void GetLocalRotation(){} // RVA: 0x153E530
        public void set_Follow(){} // RVA: 0x153E6A0
        public void DoInverseTransformPoint_Injected_B37(){} // RVA: 0x153F550
        public void DoOpenURL_D95B2301F86B(){} // RVA: 0x153F620
        public void DoInverseTransformPoint_Injected_7DC(){} // RVA: 0x153F680
        public void DoInverseTransformPoint_Injected_02F(){} // RVA: 0x153F6E0
        public void DoInverseTransformPoint_Injected(){} // RVA: 0x153F980
        public void get_PhysBoneImmobileWorldMode(){} // RVA: 0x153FB30
        public void DoInverseTransformPoint_Injected_805(){} // RVA: 0x153FB90
        public void LookRotation(){} // RVA: 0x153FBD0
        public void CalculateLookRotation(){} // RVA: 0x153FCD0
        public void DoSetHumanPose_56B(){} // RVA: 0x153FF80
        public void CalculateTargetLookRotation(){} // RVA: 0x1540220
        public void SetCamera(){} // RVA: 0xD859B0
        public void CalculateTargetLookRotation_468FB8477F24(){} // RVA: 0x15403D0
        public void set_SettingLocator(){} // RVA: 0x1540420
        public void SetIsWeb_505516390092(){} // RVA: 0x15406C0
        public void get_SettingLocator(){} // RVA: 0x1540790
        public void SetGlobalBooleanProperty_A81915C754B1(){} // RVA: 0x15407F0
        public void GetHumanoidMuscleCount(){} // RVA: 0x1540900
        public void get_onValidateInput(){} // RVA: 0xD9FF90
        public void GetColliderComponents(){} // RVA: 0x1540960
        public void SetSyncedFloatFieldAt1024_C10415646266(){} // RVA: 0x1540C40
        public void SetSyncedBoolFieldAt400(){} // RVA: 0x1540C90
        public void get_TracePropagationTargets(){} // RVA: 0xD9A380
        public void set_PhysBoneGrabSnap(){} // RVA: 0x891B00
        public void set_TrailRendererArray(){} // RVA: 0xD94790
        public void GetDeltaTime_054(){} // RVA: 0x8CBA20
        public void SetSyncedBoolWithToggleNotify(){} // RVA: 0x1540CF0
        public void SetSyncedFloatFieldAt120(){} // RVA: 0x1540D50
        public void GetCurrentPlatformModeIndex(){} // RVA: 0xD96B10
        public void DoInternal_CreateFromRoot_E18(){} // RVA: 0x1540EF0
        public void OnDestroy(){} // RVA: 0x1540F50
        public void set_FileSystem(){} // RVA: 0x15410E0
        public void GetTargets(){} // RVA: 0x15414A0
        public void GetArticle(){} // RVA: 0x1541500
        public void get_article(){} // RVA: 0x1541570
        public void TransformPointByRotation(){} // RVA: 0x1541820
        public void ProcessMatrix4X4(){} // RVA: 0x1541880
        public void TransformPointWithCurrentRotation(){} // RVA: 0x1541940
        public void TransformPointWithCurrentRotation_1B93051B2066(){} // RVA: 0x15419A0
        public void GetTextTracks(){} // RVA: 0xDA2700
        public void TransformPointFromTransform(){} // RVA: 0x1541A00
        public void RotateVectorByTransform(){} // RVA: 0x1541A50
        public void SetFixedDeltaTime_F86E113C7C60(){} // RVA: 0x1541DA0
        public void ApplyTransformAndLocalPose(){} // RVA: 0x1542030
        public void ApplyTransformAndLocalPose_A7EE97B0D223(){} // RVA: 0x1542090
        public void FindRelativeChildTransform(){} // RVA: 0x1542280
        public void FindRelativeChildTransform_86A9EB832965(){} // RVA: 0xD9F060
        public void ReadTransformPosition(){} // RVA: 0x1542820
        public void set_deviceVelocity(){} // RVA: 0x1542990
        public void DoFindRelativeTransformWithPath_7C0(){} // RVA: 0x1542A80
        public void ReadTransformPosition_668104F2D182(){} // RVA: 0x1542D50
        public void GetPickupHapticsSetting(){} // RVA: 0x1543100
        public void UpdateClosestPositionCandidate(){} // RVA: 0xDA5040
        public void DoInternal_Create_AB3(){} // RVA: 0xD94E00
        public void set_rawValue(){} // RVA: 0x1543110
        public void ReadIndexedTransformPosition(){} // RVA: 0x15434E0
        public void set_app(){} // RVA: 0x1543670
        public void set_NetworkStatusListener(){} // RVA: 0x283FA0
        public void EvaluateClosestPosition(){} // RVA: 0x1543720
        public void SetForm(){} // RVA: 0x1543AC0
        public void DefaultEquals(){} // RVA: 0x1543B10
        public void RetrieveLockContext(){} // RVA: 0x1543B70
        public void SetSecondaryComponentActiveAndNotify(){} // RVA: 0x1543CF0
        public void ProcessMatrix4X4_5C9244860BB2(){} // RVA: 0x1543F90
        public void TRS(){} // RVA: 0x1544300
        public void DrawRotationGizmo(){} // RVA: 0xD89570
        public void GetActiveInHierarchy(){} // RVA: 0xD93180
        public void DestroyObject(){} // RVA: 0x1544360
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x15443C0
        public void get_hideFlags(){} // RVA: 0x1544420
        public void GetUnityEngine_DE0DECD22F89(){} // RVA: 0x1544550
        public void set_PhysBoneColliderList_7AC8E0C1D340(){} // RVA: 0x15445B0
        public void SetLocalScale(){} // RVA: 0x1544660
        public void ApplyLocalPositionState(){} // RVA: 0x15446C0
        public void ApplyInstantiatedLocalTransform(){} // RVA: 0x1544820
        public void ApplyLocalRotationAndScale_3FF5A54ABEE4(){} // RVA: 0x1544880
        public void get_PhysicsBoneTransforms(){} // RVA: 0x1544D60
        public void get_NetworkStatusListener(){} // RVA: 0x1544DB0
        public void get_PointerPose(){} // RVA: 0xDB4D00
        public void AddTransformLink(){} // RVA: 0x1545290
        public void get_CompletedFileWritingAction(){} // RVA: 0x1545310
        public void InvokeStaticDelegateWithFlag(){} // RVA: 0x1545370
        public void ReadParticleMainModuleState(){} // RVA: 0x1545520
        public void DestroySafeArrays(){} // RVA: 0x1545910
        public void SetFloatPropertyAndNotifyChanged(){} // RVA: 0x1545E80
        public void ReadAvatarState(){} // RVA: 0x1547210
        public void set_BoneRootTransform(){} // RVA: 0x1547330
        public void set_domainList_00A6C056D2F2(){} // RVA: 0x15488E0
        public void DoEvaluate_Injected_F7E(){} // RVA: 0xD8E4E0
        public void GetFloatPropertyAtOffset1208(){} // RVA: 0x1548AE0
        public void get_DynamicBoneStiffness(){} // RVA: 0xD8D540
        public void GetBackingFieldFromProperty_592(){} // RVA: 0x152E150
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x1548B40
        public void SetIntPropertyWithRangeFilter(){} // RVA: 0x1548BF0
        public void GetGameObject(){} // RVA: 0x1548C50
        public void StopCoroutineManaged_27D32FEE54B3(){} // RVA: 0x1548D60
        public void SetBoolPropertyWithBroadcast280(){} // RVA: 0x1548E80
        public void set_SpringBoneColliders(){} // RVA: 0x1548ED0
        public void SetSyncedBoolFieldAt1160(){} // RVA: 0xDA64E0
        public void get_LiveChild(){} // RVA: 0x1548F30
        public void ResolveTransformReference(){} // RVA: 0x1548F90
        public void get_onPressed(){} // RVA: 0x15490F0
        public void GetParameterValueBySlotType_F4ACF2C6693B(){} // RVA: 0x1549140
        public void ForwardToSingletonWithForceFlag_EFD75B7659B8(){} // RVA: 0x1560980 | overloaded x2
        public void SetTargetFrameRate(){} // RVA: 0x15496D0
        public void print_27CB216B9DDB(){} // RVA: 0x1549790
        public void get_transform(){} // RVA: 0x15497F0
        public void ProcessMaterial(){} // RVA: 0x15498B0
        public void EvaluateClosestPosition_47A69B74ACEB(){} // RVA: 0x1549A80
        public void get_ContactReceiverList_11183F7520F4(){} // RVA: 0x1549AE0
        public void set_AvatarSkinnedMeshRenderer(){} // RVA: 0xD973A0
        public void TransformPointWithCurrentRotationAlt(){} // RVA: 0x1549B50
        public void get_centerEyeAngularVelocity(){} // RVA: 0x1549C60
        public void SetSyncedFloatWithDirtyFlag(){} // RVA: 0x1549FE0
        public void Updateenabled(){} // RVA: 0x2DD320
        public void get_CurrentScope(){} // RVA: 0x154A110
        public void StartSecondary(){} // RVA: 0x154A210
        public void GetPoints(){} // RVA: 0x154A3C0
        public void GetPreviewTexture(){} // RVA: 0xD9F7C0
        public void IsLocalPlayerMaster(){} // RVA: 0x154A420
        public void GetCurrentPlatformModeIndex_384CDD4B8ED8(){} // RVA: 0x154ABE0
        public void get_hasRootCurves(){} // RVA: 0x154AC40
        public void GetTransform_D92(){} // RVA: 0x154AE80
        public void GetUnscaledDeltaTime(){} // RVA: 0x891B00
        public void IsPropertyMatchingCondition(){} // RVA: 0x154B100
        public void GetTransform_E1A(){} // RVA: 0x154B2A0
        public void GetNetworkTimeInstance(){} // RVA: 0x154B300
        public void ComputeLocalPointFromPosition(){} // RVA: 0x154B410
        public void CreateSpecificCulture(){} // RVA: 0x154B470
        public void set_FailedRequestStatusCodes(){} // RVA: 0x154B4E0
        public void GetPhysicsConfigValue(){} // RVA: 0x154B720
        public void get_AimConstraintArray(){} // RVA: 0xD89900
        public void ConfigureRenderer(){} // RVA: 0x154BAC0
        public void DoInverseTransformPoint_Injected_1CA(){} // RVA: 0x154BB20
        public void set_touchpadClicked(){} // RVA: 0x154BC70
        public void SetMediaBufferSizeMs(){} // RVA: 0x154BE40
        public void ApplyMediaTransitionMode(){} // RVA: 0x154BEA0
        public void GetCurrentTimestampValue(){} // RVA: 0x154C6E0
        public void GetPropertyValueAtOffset480(){} // RVA: 0x154C860
        public void get_pathCount(){} // RVA: 0x154CA10
        public void set_PositionConstraintRefs(){} // RVA: 0x154CC80
        public void ApplyMediaTransitionMode_ABE6A0452E04(){} // RVA: 0x154CCE0
        public void set_rightTriggerButton(){} // RVA: 0x154D040
        public void UpdateNetworkState(){} // RVA: 0x154D220
        public void get_unscaledTime(){} // RVA: 0x154D280
        public void GetUnscaledTime(){} // RVA: 0x154D2E0
        public void GetCompletedFileWritingAction(){} // RVA: 0x154DDE0
        public void GetConditionalPropertyAtOffset1112(){} // RVA: 0x154DE40
        public void get_BackingFieldValue(){} // RVA: 0x154DEA0
        public void GetBackingFieldFromProperty_1056(){} // RVA: 0xD82BE0
        public void get_dragger(){} // RVA: 0x154E680
        public void DoEvaluate_Injected_F7E_9B7FA3F16761(){} // RVA: 0x154E830
        public void get_ColliderComponentArray(){} // RVA: 0x154E890
        public void MarkSecondaryDirty(){} // RVA: 0x154EA40
        public void GetPropertyValueAtOffset1288(){} // RVA: 0x154EAA0
        public void GetFallbackPropertyValue(){} // RVA: 0x154EB10
        public void GetDynamicBoneColliderComponent(){} // RVA: 0x154EB60
        public void get_ParticleSystemRefs(){} // RVA: 0xD9E220
        public void SetSyncedIntWithEventDispatch(){} // RVA: 0x154ED10
        public void GetTransform_F71(){} // RVA: 0x154EDC0
        public void GetTransform_8B839138AF26(){} // RVA: 0x154EE20
        public void set_rightTriggerButton_21A5A6B202C9(){} // RVA: 0x154EE90
        public void IsHuman(){} // RVA: 0x154F280
        public void IsFocused(){} // RVA: 0x154F2E0
        public void DoInverseTransformPoint_Injected_02F_1A7298FF2685(){} // RVA: 0x154F690
        public void LateUpdateSecondary(){} // RVA: 0x154F700
        public void ResolveGameObject(){} // RVA: 0xD9AC30
        public void SetSyncedBoolFieldAt1088(){} // RVA: 0x154F750
        public void GetTime(){} // RVA: 0x154F7A0
        public void UpdateDeltaTimer(){} // RVA: 0x1550140
        public void GetBackingFieldFromProperty_504(){} // RVA: 0x15501A0
        public void GetTransform_972(){} // RVA: 0x15501E0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x1550380
        public void SetSyncedIntFieldAt600(){} // RVA: 0x15503E0
        public void get_AnrTimeout(){} // RVA: 0x1550530
        public void Update_1BFC44AE7E71(){} // RVA: 0xD8AD50
        public void get_AnimatorComponentRef(){} // RVA: 0xDA8080
        public void set_AimConstraintRefs(){} // RVA: 0x1550590
        public void UpdateTransformPositionsFromQuaternions(){} // RVA: 0x1550E50
        public void GetTransformReference(){} // RVA: 0x1551150
        public void DoInverseTransformPoint_Injected_7DC_8EC88C675F5C(){} // RVA: 0x1551450
        public void OnBecameVisible(){} // RVA: 0x7F86C0
        public void IsApplicationPlaying(){} // RVA: 0x1551590
        public void DoInternal_FromEulerRad_Injected_61E(){} // RVA: 0x15515F0
        public void GetBackingFieldFromProperty_248(){} // RVA: 0x15517B0
        public void SetBoolPropertyWithNotify608(){} // RVA: 0x15519C0
        public void InvokeSingletonTransformDelegate(){} // RVA: 0x1551E10
        public void SetSyncedBoolAndRebuildLayout(){} // RVA: 0x1551F20
        public void DontDestroyGameObject(){} // RVA: 0x15521C0
        public void get_onTouchScreenKeyboardStatusChanged(){} // RVA: 0x1552230
        public void set_TrailRendererArray_6AB8A48F29C4(){} // RVA: 0x15523D0
        public void Start_4D3681584F0D(){} // RVA: 0x15524C0
        public void InitializeWindowsApiPointers(){} // RVA: 0x1552890
        public void ComputeLocalPointFromPosition_4169E5A5B32F(){} // RVA: 0xDA62D0
        public void StoreInverseTransformedPoint(){} // RVA: 0x15528F0
        public void Inverse(){} // RVA: 0x1552940
        public void get_fontAsset(){} // RVA: 0x1552C10
        public void SetBackgroundLoadingPriority(){} // RVA: 0x1552CB0
        public void AddLink(){} // RVA: 0x1552D10
        public void DoInternal_Create_61F(){} // RVA: 0x1552D70
        public void LookRotation_81C1D5C1AF2E(){} // RVA: 0xDB3D70
        public void GetParent_140(){} // RVA: 0x1552DD0
        public void SetupNetworkManager(){} // RVA: 0xD94430
        public void SetLocalScale_5D84AE12390C(){} // RVA: 0x1552E20
        public void set_home_BC7BAD0E0EE3(){} // RVA: 0x1552ED0
        public void ApplyInstantiatedLocalTransform_5CB5A24A278E(){} // RVA: 0x1553240
        public void AddLink_9DC3BC33AE30(){} // RVA: 0x15532A0
        public void GetParent_35E(){} // RVA: 0xD8BD90
        public void IsMediaFlipHorizontalEnabled(){} // RVA: 0x1553300
        public void DestroySafeArrays_EE9F799E8789(){} // RVA: 0x1553420
        public void IsPhysBoneStateComplete_C43AEB2F56B9(){} // RVA: 0x1553A90
        public void GetBackingFieldFromProperty_640(){} // RVA: 0xDA0DF0
        public void ReadAvatarState_6E1B997D7845(){} // RVA: 0x1553AF0
        public void set_PhysBoneMaxStretch_ECFB509052E9(){} // RVA: 0x348120
        public void GetBackingFieldFromProperty_592_86BE83C33F0E(){} // RVA: 0x1553B90
        public void SetIntPropertyWithRangeFilter_9D6130EE8410(){} // RVA: 0x1553BF0
        public void StopCoroutine_B47B52B376C9(){} // RVA: 0x1554280
        public void get_dragger_C15F975ABEAD(){} // RVA: 0x1554520
        public void DoInitializeArray(){} // RVA: 0x1554590
        public void get_NativeContextWriter(){} // RVA: 0x1554730
        public void set_PhysBoneGrabCallback(){} // RVA: 0x15547B0
        public void set_RotationConstraintRefs(){} // RVA: 0x1554970
        public void SetTargetFrameRate_0997586FFAAB(){} // RVA: 0x15549D0
        public void ProcessMaterial_387027BA8BF4(){} // RVA: 0x1554C50
        public void get_PhysBoneStretchConfig(){} // RVA: 0x1554CA0
        public void OrthoOffsetToScreenBounds_6B9D0B89E757(){} // RVA: 0x15551D0
        public void OnCancellationTokenCreated_6E2D59925E96(){} // RVA: 0x1498020
        public void DoInverseTransformPoint_Injected_EE4(){} // RVA: 0x15551E0
        public void GetPickupHapticsSetting_30370A48C36F(){} // RVA: 0x1555520
        public void ResolveGameObject_0DFBA86CE66D(){} // RVA: 0x15562A0
        public void ConvertToSingle(){} // RVA: 0x1556570
        public void GetCurrentResolution(){} // RVA: 0xD83C70
        public void get_TransactionProfilerFactory(){} // RVA: 0xDB2150
        public void set_rightEyeAngularVelocity(){} // RVA: 0x15565D0
        public void EvaluateClosestPosition_258CBA114622(){} // RVA: 0xD90B00
        public void TransformPointWithCurrentRotation_1B9913D2367A(){} // RVA: 0x1556870
        public void SetSyncedFloatWithDirtyFlag_592C7E779374(){} // RVA: 0x1556A10
        public void get_PositionConstraintArray(){} // RVA: 0x3C2850
        public void Start(){} // RVA: 0x1556A70
        public void ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(){} // RVA: 0xD92860
        public void Ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(){} // RVA: 0x1559450
        public void SetSyncedBoolFieldAt1088_55B8C3EA1FD4(){} // RVA: 0x15594B0
        public void SampleUnscaledDeltaTime_8E5605A203F2(){} // RVA: 0xD87940
        public void set_promotion(){} // RVA: 0xD9E9A0
        public void SetXMotion(){} // RVA: 0x1559690
        public void ovr_CloudStorageMetadataArray_GetNextUrl(){} // RVA: 0xD9C4E0
        public void set_DynamicBoneColliders(){} // RVA: 0x15596F0
        public void SetSyncedIntFieldAt600_48565FEC9037(){} // RVA: 0x1559750
        public void GetCompletedFileWritingAction_0239B6367409(){} // RVA: 0x15597B0
        public void InitializeWindowsApiPointers_48A32D30736A(){} // RVA: 0x1559960
        public void get_PhysicsConfigValue(){} // RVA: 0x15599C0
        public void StoreInverseTransformedPoint_2271083454F1(){} // RVA: 0x1559A20
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
        public void get_CompletedFileWritingAction_E050159FFFE5(){} // RVA: 0x1559A80
        public void get_ActiveBlend(){} // RVA: 0x1559AE0
        public void InverseTransformPoint_06CE69DC0529(){} // RVA: 0x1559D60
        public void AddLink_D90CF7F9FAEF(){} // RVA: 0x1559E90
        public void IsInstanceOfType(){} // RVA: 0x1559F30
        public void SetupNetworkManager_667325AB509E(){} // RVA: 0x1559F80
        public void ComputeLocalPointFromPosition_416C8E8F8E82(){} // RVA: 0x155A420
        public void get_contentList(){} // RVA: 0xD889C0
        public void get_name(){} // RVA: 0xD971B0
        public void GetFallbackPropertyValue_3A4E8D90DEF6(){} // RVA: 0x155A480
        public void SetSyncedIntWithEventDispatch_5A2A71331C68(){} // RVA: 0x155AB70
        public void IsFocused_A358A8B87098(){} // RVA: 0x155ABD0
        public void get_AimConstraintArray_386CAD562728(){} // RVA: 0x155AC40
        public void SetLocalScaleFromState(){} // RVA: 0x155ACA0
        public void LateUpdate_5A06AE3593A7(){} // RVA: 0x155AD00
        public void set_volumeDown(){} // RVA: 0x155AD60
        public void GetPropertyValueAtOffset360(){} // RVA: 0x155B090
        public void get_leftTriggerButton(){} // RVA: 0x155B3C0
        public void GetPropertyValueAtOffset528(){} // RVA: 0x155B470
        public void GetTime_0C14EA995195(){} // RVA: 0x155B4E0
        public void .ctor(){} // RVA: 0x155B540
        public void GetNestedItemAtIndex(){} // RVA: 0xDB5A60
        public void GetCachedPtr(){} // RVA: 0x155F7B0
        public void GetUnscaledDeltaTime_01DDA087A48A(){} // RVA: 0x155F810
        public void UpdateDeltaTimer_CDDDB022E2CC(){} // RVA: 0x155FCC0
        public void set_CacheWritingBehavior(){} // RVA: 0x155FD10
        public void set_CompletedFileWritingAction(){} // RVA: 0xDA3FD0
        public void UpdateTransformPositionsFromQuaternions_F096FBDC9754(){} // RVA: 0x155FD90
        public void IsMediaFlipHorizontalEnabled_519B904C6D62(){} // RVA: 0x155FDA0
        public void get_SelectedAudioInputDevice(){} // RVA: 0x155FE00
        public void IsApplicationPlaying_EE5125F32EC1(){} // RVA: 0x15601E0
        public void DontDestroyGameObject_2323106D5EC6(){} // RVA: 0x1560240
        public void ReadAvatarStateSnapshot(){} // RVA: 0x15602F0
        public void get_CameraSelector(){} // RVA: 0x283FA0
        public void GetName(){} // RVA: 0xD9ABC0
        public void GetPickupHapticsSetting_1E32B8CBB545(){} // RVA: 0x1560350
        public void SetBackgroundLoadingPriority_F3B1245335F7(){} // RVA: 0x1560360
        public void DoInverseTransformPoint_Injected_C02(){} // RVA: 0x1560790
        public void GetHumanoidMuscleCount_207A9D6DB1C7(){} // RVA: 0x1560800
        public void .cctor(){} // RVA: 0x1560C80
        public void ApplyPhysicsBoneStretchLimit(){} // RVA: 0x15627D0
        public void InitializeSecondaryStatics(){} // RVA: 0x1562860
        // ── Unresolved (hash) ──
        public void m_E81(){} // RVA: 0x152B870
    }

    /// <summary>Originally: ÍÍÍÍÌÏÎÎÎÍÍÎÍÎÌÏÌÏÌÏÎÏÏ</summary>
    public class InvisibleDrawGizmosComponent_8D81
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x982D90
        public void Update(){} // RVA: 0x983AA0
        public void LateUpdate(){} // RVA: 0x9847A0
        public void OnDisable(){} // RVA: 0x9848C0
        public void OnDestroy(){} // RVA: 0x985CC0
        public void OnApplicationPause(){} // RVA: 0x985D20
        public void Start(){} // RVA: 0x986200
        public void OnBecameVisible(){} // RVA: 0x987340
        public void .ctor(){} // RVA: 0x9875C0
        public void Initialize(){} // RVA: 0x987740
        public void OnCollisionStay(){} // RVA: 0x9877A0
        public void Awake(){} // RVA: 0x987880
        public void OnTriggerEnter(){} // RVA: 0x987B00
        public void OnTriggerStay(){} // RVA: 0x987F80
        public void OnTriggerExit(){} // RVA: 0x988B20
        public void OnBecameInvisible(){} // RVA: 0x988E20
        public void OnCollisionEnter(){} // RVA: 0x989BA0
        public void ComputeDrawGizmosHash(){} // RVA: 0x989C70
        public void OnDrawGizmos(){} // RVA: 0x989E90
        public void OnApplicationQuit(){} // RVA: 0x98A350
        public void OnApplicationQuit_70BC530773F0(){} // RVA: 0x98A350
        // ── Unresolved (hash) ──
        public void m_1C9(){} // RVA: 0x98A270
    }

}