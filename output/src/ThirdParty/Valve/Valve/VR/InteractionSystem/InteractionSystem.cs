// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 75
// Methods: 667

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AfterTimer_Component : MonoBehaviour
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8709CAC0
        public void Wait(){} // RVA: 0x7FFE8709CB40
        public void OnDestroy(){} // RVA: 0x7FFE8709CBE0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class AllowTeleportWhileAttachedToHand : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8703E940
    }

    public class ArcheryTarget : MonoBehaviour
    {
        // ── Methods ──
        public void ApplyDamage(){} // RVA: 0x7FFE870A6210
        public void FireExposure(){} // RVA: 0x7FFE870A6210
        public void OnDamageTaken(){} // RVA: 0x7FFE870A6220
        public void FallDown(){} // RVA: 0x7FFE870A6300
        public void .ctor(){} // RVA: 0x7FFE870A63A0
    }

    public class Arrow : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870A67D0
        public void Start(){} // RVA: 0x7FFE870A6A60
        public void FixedUpdate(){} // RVA: 0x7FFE870A6B00
        public void StartRelease(){} // RVA: 0x7FFE870A6DE0
        public void ArrowReleased(){} // RVA: 0x7FFE870A7270
        public void SetCollisionMode(){} // RVA: 0x7FFE870A7DC0
        public void OnCollisionEnter(){} // RVA: 0x7FFE870A7F00
        public void StickInTarget(){} // RVA: 0x7FFE870A8E60
        public void OnDestroy(){} // RVA: 0x7FFE870AA090
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ArrowHand : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870AA340
        public void OnAttachedToHand(){} // RVA: 0x7FFE870AA4A0
        public void InstantiateArrow(){} // RVA: 0x7FFE870AA500
        public void HandAttachedUpdate(){} // RVA: 0x7FFE870AA8E0
        public void OnDetachedFromHand(){} // RVA: 0x7FFE870AB990
        public void FireArrow(){} // RVA: 0x7FFE870ABA30
        public void EnableArrowSpawn(){} // RVA: 0x7FFE812AED70
        public void ArrowReleaseHaptics(){} // RVA: 0x7FFE870AC490
        public void OnHandFocusLost(){} // RVA: 0x7FFE817E41C0
        public void OnHandFocusAcquired(){} // RVA: 0x7FFE81E2C030
        public void FindBow(){} // RVA: 0x7FFE870AC530
        public void .ctor(){} // RVA: 0x7FFE870AC5D0
    }

    public class ArrowheadRotation : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870AC880
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Balloon : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870AC970
        public void Update(){} // RVA: 0x7FFE870ACB30
        public void SpawnParticles(){} // RVA: 0x7FFE870ACC40
        public void FixedUpdate(){} // RVA: 0x7FFE870AD0F0
        public void ApplyDamage(){} // RVA: 0x7FFE870AD280
        public void OnCollisionEnter(){} // RVA: 0x7FFE870AD330
        public void SetColor(){} // RVA: 0x7FFE870AD980
        public void BalloonColorToRGB(){} // RVA: 0x7FFE870ADA60
        public void .ctor(){} // RVA: 0x7FFE870ADC70
    }

    public class BalloonColliders : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870ADCD0
        public void OnEnable(){} // RVA: 0x7FFE870AE280
        public void OnDisable(){} // RVA: 0x7FFE870AE8D0
        public void OnDestroy(){} // RVA: 0x7FFE870AEA90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BalloonHapticBump : MonoBehaviour
    {
        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFE870AEBC0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BalloonSpawner : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870AEE00
        public void Update(){} // RVA: 0x7FFE870AEF20
        public void SpawnBalloon(){} // RVA: 0x7FFE870AF080
        public void SpawnBalloonFromEvent(){} // RVA: 0x7FFE870AF9E0
        public void .ctor(){} // RVA: 0x7FFE870AF9F0
    }

    public class BodyCollider : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87063580
        public void FixedUpdate(){} // RVA: 0x7FFE87063610
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ChaperoneInfo : MonoBehaviour
    {
        public bool _initialized; // 0x20
        public float _playAreaSizeX; // 0x24
        public float _playAreaSizeZ; // 0x28
        public bool _roomscale; // 0x2C
        public Event Initialized;

        // ── Methods ──
        public void get_initialized(){} // RVA: 0x7FFE811E99D0
        public void set_initialized(){} // RVA: 0x7FFE811E99E0
        public void get_playAreaSizeX(){} // RVA: 0x7FFE81268F50
        public void set_playAreaSizeX(){} // RVA: 0x7FFE81268F60
        public void get_playAreaSizeZ(){} // RVA: 0x7FFE811DA210
        public void set_playAreaSizeZ(){} // RVA: 0x7FFE811DA220
        public void get_roomscale(){} // RVA: 0x7FFE811DA230
        public void set_roomscale(){} // RVA: 0x7FFE811DA240
        public void InitializedAction(){} // RVA: 0x7FFE870B49E0
        public void get_instance(){} // RVA: 0x7FFE870B4A80
        public void Start(){} // RVA: 0x7FFE870B4DD0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void .cctor(){} // RVA: 0x7FFE870B4E70
    }

    public class CircularDrive : MonoBehaviour
    {
        // ── Methods ──
        public void Freeze(){} // RVA: 0x7FFE87063940
        public void UnFreeze(){} // RVA: 0x7FFE87063A10
        public void Awake(){} // RVA: 0x7FFE87063A30
        public void Start(){} // RVA: 0x7FFE87063AD0
        public void OnDisable(){} // RVA: 0x7FFE870646F0
        public void HapticPulses(){} // RVA: 0x7FFE87064860
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87064920
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87064940
        public void HandHoverUpdate(){} // RVA: 0x7FFE87064AC0
        public void ComputeToTransformProjected(){} // RVA: 0x7FFE87064D90
        public void DrawDebugPath(){} // RVA: 0x7FFE87065200
        public void UpdateLinearMapping(){} // RVA: 0x7FFE87066140
        public void UpdateGameObject(){} // RVA: 0x7FFE870661D0
        public void UpdateDebugText(){} // RVA: 0x7FFE87066490
        public void UpdateAll(){} // RVA: 0x7FFE87066690
        public void ComputeAngle(){} // RVA: 0x7FFE87066730
        public void .ctor(){} // RVA: 0x7FFE87066C20
    }

    public class ComplexThrowable : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87066FC0
        public void Update(){} // RVA: 0x7FFE87067040
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87067180
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87067260
        public void HandHoverUpdate(){} // RVA: 0x7FFE87067340
        public void PhysicsAttach(){} // RVA: 0x7FFE87067390
        public void PhysicsDetach(){} // RVA: 0x7FFE87067E70
        public void FixedUpdate(){} // RVA: 0x7FFE87068180
        public void .ctor(){} // RVA: 0x7FFE87068700
    }

    public class ControllerButtonHints : MonoBehaviour
    {
        public UnityEngine.Material controllerMaterial; // 0x20
        public UnityEngine.Material urpControllerMaterial; // 0x28

        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0x7FFE811290C0
        public void get_initialized(){} // RVA: 0x7FFE86E6CDF0
        public void set_initialized(){} // RVA: 0x7FFE86E6CE00
        public void Awake(){} // RVA: 0x7FFE8709DEF0
        public void Start(){} // RVA: 0x7FFE8709E040
        public void HintDebugLog(){} // RVA: 0x7FFE8709E0B0
        public void OnEnable(){} // RVA: 0x7FFE8709E140
        public void OnDisable(){} // RVA: 0x7FFE8709E170
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFE8709E1B0
        public void SetInputSource(){} // RVA: 0x7FFE8709E1D0
        public void OnHandInitialized(){} // RVA: 0x7FFE8709E2C0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFE8709E800
        public void DoInitialize(){} // RVA: 0x7FFE8709EB20
        public void CreateAndAddButtonInfo(){} // RVA: 0x7FFE8709EC20
        public void ComputeTextEndTransforms(){} // RVA: 0x7FFE870A0DC0
        public void ShowButtonHint(){} // RVA: 0x7FFE870A4200 | overloaded x2
        public void HideAllButtonHints(){} // RVA: 0x7FFE870A43E0 | overloaded x2
        public void HideButtonHint(){} // RVA: 0x7FFE870A42F0 | overloaded x2
        public void IsButtonHintActive(){} // RVA: 0x7FFE870A44C0 | overloaded x2
        public void TestButtonHints(){} // RVA: 0x7FFE870A2880
        public void TestTextHints(){} // RVA: 0x7FFE870A2920
        public void Update(){} // RVA: 0x7FFE870A29C0
        public void UpdateTextHint(){} // RVA: 0x7FFE870A3070
        public void Clear(){} // RVA: 0x7FFE870A3760
        public void ShowText(){} // RVA: 0x7FFE870A37F0
        public void HideText(){} // RVA: 0x7FFE870A3BB0
        public void HideAllText(){} // RVA: 0x7FFE870A3D40
        public void GetActiveHintText(){} // RVA: 0x7FFE870A4B70 | overloaded x2
        public void GetControllerButtonHints(){} // RVA: 0x7FFE870A4070
        public void ShowTextHint(){} // RVA: 0x7FFE870A45B0
        public void HideTextHint(){} // RVA: 0x7FFE870A4780
        public void HideAllTextHints(){} // RVA: 0x7FFE870A4A90
        public void .ctor(){} // RVA: 0x7FFE870A4D60
    }

    public class ControllerHoverHighlight : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870689B0
        public void OnHandInitialized(){} // RVA: 0x7FFE87068A40
        public void RenderModel_onControllerLoaded(){} // RVA: 0x7FFE870691B0
        public void OnParentHandHoverBegin(){} // RVA: 0x7FFE870691F0
        public void OnParentHandHoverEnd(){} // RVA: 0x7FFE870694A0
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x7FFE870694B0
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFE870694A0
        public void ShowHighlight(){} // RVA: 0x7FFE87069820
        public void HideHighlight(){} // RVA: 0x7FFE87069990
        public void .ctor(){} // RVA: 0x7FFE81132BB0
    }

    public class CustomEvents : Object
    {
    }

    public class DebugUI : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Player player; // 0x20

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87069BB0
        public void Start(){} // RVA: 0x7FFE87069D40
        public void OnGUI(){} // RVA: 0x7FFE87069DB0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DestroyOnDetachedFromHand : MonoBehaviour
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x7FFE87069E60
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DestroyOnParticleSystemDeath : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87069F00
        public void CheckParticleSystem(){} // RVA: 0x7FFE87069FC0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DestroyOnTriggerEnter : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8706A0C0
        public void OnTriggerEnter(){} // RVA: 0x7FFE8706A0E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DistanceHaptics : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8706A380
        public void .ctor(){} // RVA: 0x7FFE8706A420
    }

    public class DontDestroyOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8706A950
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class EnumFlags : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Equippable : MonoBehaviour
    {
        public UnityEngine.Transform[] antiFlip; // 0x20

        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x7FFE8706A9E0
        public void Start(){} // RVA: 0x7FFE8706AAF0
        public void Update(){} // RVA: 0x7FFE8706AC40
        public void .ctor(){} // RVA: 0x7FFE8706B000
    }

    public class ExplosionWobble : MonoBehaviour
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x7FFE870AFA60
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class FallbackCameraController : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8706B050
        public void Update(){} // RVA: 0x7FFE8706B0B0
        public void OnGUI(){} // RVA: 0x7FFE8706BA80
        public void .ctor(){} // RVA: 0x7FFE8706BB00
    }

    public class FireSource : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870AFBD0
        public void Update(){} // RVA: 0x7FFE870AFBE0
        public void OnTriggerEnter(){} // RVA: 0x7FFE870AFD70
        public void FireExposure(){} // RVA: 0x7FFE870AFE20
        public void StartBurning(){} // RVA: 0x7FFE870B0070
        public void .ctor(){} // RVA: 0x7FFE82264070
    }

    public class Hand : MonoBehaviour
    {
        public 0x666054EC defaultAttachmentFlags;
        public Valve.VR.InteractionSystem.Hand otherHand; // 0x20
        public 0x6660354C handType; // 0x28
        public Valve.VR.SteamVR_Behaviour_Pose trackedObject; // 0x30
        public Valve.VR.SteamVR_Action_Boolean grabPinchAction; // 0x38
        public Valve.VR.SteamVR_Action_Boolean grabGripAction; // 0x40
        public Valve.VR.SteamVR_Action_Vibration hapticAction; // 0x48
        public Valve.VR.SteamVR_Action_Boolean uiInteractAction; // 0x50
        public bool useHoverSphere; // 0x58

        // ── Methods ──
        public void get_AttachedObjects(){} // RVA: 0x7FFE8706BB60
        public void get_hoverLocked(){} // RVA: 0x7FFE81226F80
        public void set_hoverLocked(){} // RVA: 0x7FFE81226F90
        public void get_isActive(){} // RVA: 0x7FFE8706BC30
        public void get_isPoseValid(){} // RVA: 0x7FFE8706BDF0
        public void get_hoveringInteractable(){} // RVA: 0x7FFE8117C970
        public void set_hoveringInteractable(){} // RVA: 0x7FFE8706BE40
        public void get_currentAttachedObject(){} // RVA: 0x7FFE8706C3E0
        public void get_currentAttachedObjectInfo(){} // RVA: 0x7FFE8706C490
        public void get_currentAttachedTeleportManager(){} // RVA: 0x7FFE8706C6E0
        public void get_skeleton(){} // RVA: 0x7FFE8706C780
        public void ShowController(){} // RVA: 0x7FFE8706C870
        public void HideController(){} // RVA: 0x7FFE8706CA20
        public void ShowSkeleton(){} // RVA: 0x7FFE8706CBD0
        public void HideSkeleton(){} // RVA: 0x7FFE8706CD80
        public void HasSkeleton(){} // RVA: 0x7FFE8706CF30
        public void Show(){} // RVA: 0x7FFE8706D0C0
        public void Hide(){} // RVA: 0x7FFE8706D0D0
        public void SetVisibility(){} // RVA: 0x7FFE8706D0E0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFE8706D1E0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFE8706D2C0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFE8706D4F0
        public void SetAnimationState(){} // RVA: 0x7FFE8706D6B0
        public void StopAnimation(){} // RVA: 0x7FFE8706D8B0
        public void AttachObject(){} // RVA: 0x7FFE8706DAB0
        public void ObjectIsAttached(){} // RVA: 0x7FFE87070CA0
        public void ForceHoverUnlock(){} // RVA: 0x7FFE8160DA40
        public void DetachObject(){} // RVA: 0x7FFE87070E90
        public void GetTrackedObjectVelocity(){} // RVA: 0x7FFE870725F0
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x7FFE87072A30
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFE87072E70
        public void CleanUpAttachedObjectStack(){} // RVA: 0x7FFE87072FE0
        public void Awake(){} // RVA: 0x7FFE87073160
        public void OnDestroy(){} // RVA: 0x7FFE870739E0
        public void OnTransformUpdated(){} // RVA: 0x7FFE82215450
        public void Start(){} // RVA: 0x7FFE87073BC0
        public void UpdateHovering(){} // RVA: 0x7FFE87073C60
        public void CheckHoveringForTransform(){} // RVA: 0x7FFE87074220
        public void UpdateNoSteamVRFallback(){} // RVA: 0x7FFE87074E80
        public void UpdateDebugText(){} // RVA: 0x7FFE87075610
        public void OnEnable(){} // RVA: 0x7FFE87076210
        public void OnDisable(){} // RVA: 0x7FFE870763A0
        public void Update(){} // RVA: 0x7FFE87076420
        public void IsStillHovering(){} // RVA: 0x7FFE87076610
        public void HandFollowUpdate(){} // RVA: 0x7FFE87076750
        public void FixedUpdate(){} // RVA: 0x7FFE87077E60
        public void UpdateAttachedVelocity(){} // RVA: 0x7FFE870787B0
        public void ResetAttachedTransform(){} // RVA: 0x7FFE87078B70
        public void TargetItemPosition(){} // RVA: 0x7FFE87078DE0
        public void TargetItemRotation(){} // RVA: 0x7FFE87079280
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x7FFE87079B30
        public void OnInputFocus(){} // RVA: 0x7FFE8707A300
        public void OnDrawGizmos(){} // RVA: 0x7FFE8707A4A0
        public void HandDebugLog(){} // RVA: 0x7FFE8707AB80
        public void HoverLock(){} // RVA: 0x7FFE8707AC40
        public void HoverUnlock(){} // RVA: 0x7FFE8707ACF0
        public void TriggerHapticPulse(){} // RVA: 0x7FFE8707AEE0 | overloaded x2
        public void ShowGrabHint(){} // RVA: 0x7FFE8707B030 | overloaded x2
        public void HideGrabHint(){} // RVA: 0x7FFE8707B020
        public void GetGrabStarting(){} // RVA: 0x7FFE8707B060
        public void GetGrabEnding(){} // RVA: 0x7FFE8707B460
        public void IsGrabEnding(){} // RVA: 0x7FFE8707B730
        public void IsGrabbingWithType(){} // RVA: 0x7FFE8707B9B0
        public void IsGrabbingWithOppositeType(){} // RVA: 0x7FFE8707BB40
        public void GetBestGrabbingType(){} // RVA: 0x7FFE8707BCE0 | overloaded x2
        public void InitController(){} // RVA: 0x7FFE8707BEB0
        public void SetRenderModel(){} // RVA: 0x7FFE8707CB90
        public void SetHoverRenderModel(){} // RVA: 0x7FFE8707CD00
        public void GetDeviceIndex(){} // RVA: 0x7FFE8707CDB0
        public void .ctor(){} // RVA: 0x7FFE8707CE00
    }

    public class HandCollider : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8707DAD0
        public void Start(){} // RVA: 0x7FFE8707DBB0
        public void SetPhysicMaterial(){} // RVA: 0x7FFE8707E3E0
        public void SetCollisionDetectionEnabled(){} // RVA: 0x7FFE8707E540
        public void MoveTo(){} // RVA: 0x7FFE8707E5B0
        public void TeleportTo(){} // RVA: 0x7FFE8707E5D0
        public void Reset(){} // RVA: 0x7FFE8707E880
        public void SetCenterPoint(){} // RVA: 0x7FFE8707E8C0
        public void ExecuteFixedUpdate(){} // RVA: 0x7FFE8707E8D0
        public void GetTargetVelocities(){} // RVA: 0x7FFE8707EDE0
        public void OnCollisionEnter(){} // RVA: 0x7FFE8707F310
        public void .ctor(){} // RVA: 0x7FFE8707F640
    }

    public class HandEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8707DA90
    }

    public class HandPhysics : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8707F9D0
        public void FixedUpdate(){} // RVA: 0x7FFE870800A0
        public void UpdateCenterPoint(){} // RVA: 0x7FFE87080320
        public void UpdatePositions(){} // RVA: 0x7FFE870805E0
        public void UpdateFingertips(){} // RVA: 0x7FFE87081710
        public void UpdateHand(){} // RVA: 0x7FFE87081BE0
        public void ProcessPos(){} // RVA: 0x7FFE870821F0
        public void ProcessRot(){} // RVA: 0x7FFE87082370
        public void .ctor(){} // RVA: 0x7FFE87082430
    }

    public class HapticRack : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87082590
        public void OnHandHoverBegin(){} // RVA: 0x7FFE81123200
        public void OnHandHoverEnd(){} // RVA: 0x7FFE865A0650
        public void Update(){} // RVA: 0x7FFE870826D0
        public void Pulse(){} // RVA: 0x7FFE87082850
        public void .ctor(){} // RVA: 0x7FFE87082990
    }

    public class HideOnHandFocusLost : MonoBehaviour
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0x7FFE817E41C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class HoverButton : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870829F0
        public void HandHoverUpdate(){} // RVA: 0x7FFE87082CC0
        public void LateUpdate(){} // RVA: 0x7FFE870833C0
        public void InvokeEvents(){} // RVA: 0x7FFE870834F0
        public void .ctor(){} // RVA: 0x7FFE870835D0
    }

    public class IgnoreHovering : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class IgnoreTeleportTrace : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class InputModule : BaseInputModule
    {
        public UnityEngine.GameObject submitObject; // 0x58

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87083640
        public void ShouldActivateModule(){} // RVA: 0x7FFE870837D0
        public void HoverBegin(){} // RVA: 0x7FFE870838B0
        public void HoverEnd(){} // RVA: 0x7FFE870839B0
        public void Submit(){} // RVA: 0x7FFE811C3510
        public void Process(){} // RVA: 0x7FFE87083AD0
        public void .ctor(){} // RVA: 0x7FFE87083CA0
    }

    public class Interactable : MonoBehaviour
    {
        public Valve.VR.SteamVR_ActionSet activateActionSetOnAttach; // 0x20
        public bool hideHandOnAttach; // 0x28
        public bool hideSkeletonOnAttach; // 0x29
        public bool hideControllerOnAttach; // 0x2A

        // ── Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x7FFE87083CB0
        public void remove_onAttachedToHand(){} // RVA: 0x7FFE87083DA0
        public void add_onDetachedFromHand(){} // RVA: 0x7FFE87083E90
        public void remove_onDetachedFromHand(){} // RVA: 0x7FFE87083F80
        public void get_hoveringHand(){} // RVA: 0x7FFE87084070
        public void get_isDestroying(){} // RVA: 0x7FFE824AEC00
        public void set_isDestroying(){} // RVA: 0x7FFE824AD2F0
        public void get_isHovering(){} // RVA: 0x7FFE8453D820
        public void set_isHovering(){} // RVA: 0x7FFE8453D830
        public void get_wasHovering(){} // RVA: 0x7FFE87084100
        public void set_wasHovering(){} // RVA: 0x7FFE87084110
        public void Awake(){} // RVA: 0x7FFE87084120
        public void Start(){} // RVA: 0x7FFE870841B0
        public void ShouldIgnoreHighlight(){} // RVA: 0x7FFE87084590
        public void ShouldIgnore(){} // RVA: 0x7FFE87084610
        public void CreateHighlightRenderers(){} // RVA: 0x7FFE870847A0
        public void UpdateHighlightRenderers(){} // RVA: 0x7FFE870850F0
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87085DA0
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87085E50
        public void Update(){} // RVA: 0x7FFE87085FD0
        public void OnAttachedToHand(){} // RVA: 0x7FFE87086100
        public void OnDetachedFromHand(){} // RVA: 0x7FFE870864C0
        public void OnDestroy(){} // RVA: 0x7FFE870869E0
        public void OnDisable(){} // RVA: 0x7FFE87086C20
        public void .ctor(){} // RVA: 0x7FFE87086DD0
    }

    public class InteractableDebug : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand attachedToHand; // 0x20

        // ── Methods ──
        public void get_isThrowable(){} // RVA: 0x7FFE87086FF0
        public void Awake(){} // RVA: 0x7FFE870870C0
        public void OnAttachedToHand(){} // RVA: 0x7FFE870872F0
        public void HandAttachedUpdate(){} // RVA: 0x7FFE87087370
        public void OnDetachedFromHand(){} // RVA: 0x7FFE870874D0
        public void GetColliders(){} // RVA: 0x7FFE81178740
        public void IgnoreObject(){} // RVA: 0x7FFE87087AA0
        public void SetIsSimulation(){} // RVA: 0x7FFE87087BB0
        public void CreateSimulation(){} // RVA: 0x7FFE87087BC0
        public void CreateMarker(){} // RVA: 0x7FFE87087FB0 | overloaded x2
        public void ColorSelf(){} // RVA: 0x7FFE87088760
        public void ColorThing(){} // RVA: 0x7FFE87088830
        public void .ctor(){} // RVA: 0x7FFE87088900
    }

    public class InteractableHoverEvents : MonoBehaviour
    {
        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87088950
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87088970
        public void OnAttachedToHand(){} // RVA: 0x7FFE87088990
        public void OnDetachedFromHand(){} // RVA: 0x7FFE870889B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ItemPackage : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ItemPackageReference : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ItemPackageSpawner : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.ItemPackage _itemPackage; // 0x20

        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0x7FFE811290C0
        public void set_itemPackage(){} // RVA: 0x7FFE870889D0
        public void CreatePreviewObject(){} // RVA: 0x7FFE870889E0
        public void Start(){} // RVA: 0x7FFE87088FF0
        public void VerifyItemPackage(){} // RVA: 0x7FFE87088FF0
        public void ItemPackageNotValid(){} // RVA: 0x7FFE87089180
        public void ClearPreview(){} // RVA: 0x7FFE870892F0
        public void Update(){} // RVA: 0x7FFE87089640
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87089740
        public void TakeBackItem(){} // RVA: 0x7FFE87089920
        public void GetAttachedItemPackage(){} // RVA: 0x7FFE87089980
        public void HandHoverUpdate(){} // RVA: 0x7FFE87089B40
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87089D40
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x7FFE87089D90
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x7FFE8708A1C0
        public void SpawnAndAttachObject(){} // RVA: 0x7FFE8708A430
        public void .ctor(){} // RVA: 0x7FFE8708AA60
    }

    public class LinearAnimation : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8708AAB0
        public void Update(){} // RVA: 0x7FFE8708AF60
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LinearAnimator : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8708AFC0
        public void Update(){} // RVA: 0x7FFE8708B270
        public void .ctor(){} // RVA: 0x7FFE8708B350
    }

    public class LinearAudioPitch : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8708B3A0
        public void Update(){} // RVA: 0x7FFE8708B5F0
        public void Apply(){} // RVA: 0x7FFE8708B710
        public void .ctor(){} // RVA: 0x7FFE82555A10
    }

    public class LinearBlendshape : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8708B820
        public void Update(){} // RVA: 0x7FFE8708BA70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LinearDisplacement : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8708BB50
        public void Update(){} // RVA: 0x7FFE8708BD40
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LinearDrive : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8708BF20
        public void Start(){} // RVA: 0x7FFE8708C040
        public void HandHoverUpdate(){} // RVA: 0x7FFE8708C350
        public void HandAttachedUpdate(){} // RVA: 0x7FFE8708C550
        public void OnDetachedFromHand(){} // RVA: 0x7FFE8708C680
        public void CalculateMappingChangeRate(){} // RVA: 0x7FFE8708C680
        public void UpdateLinearMapping(){} // RVA: 0x7FFE8708C700
        public void CalculateLinearMapping(){} // RVA: 0x7FFE8708CA10
        public void Update(){} // RVA: 0x7FFE8708CD10
        public void .ctor(){} // RVA: 0x7FFE8708D030
    }

    public class LinearMapping : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Longbow : MonoBehaviour
    {
        // ── Methods ──
        public void OnAttachedToHand(){} // RVA: 0x7FFE81123200
        public void HandAttachedUpdate(){} // RVA: 0x7FFE870B0610
        public void ArrowReleased(){} // RVA: 0x7FFE870B16E0
        public void ResetDrawAnim(){} // RVA: 0x7FFE870B1860
        public void GetArrowVelocity(){} // RVA: 0x7FFE813A18F0
        public void StartRotationLerp(){} // RVA: 0x7FFE870B1900
        public void StartNock(){} // RVA: 0x7FFE870B19E0
        public void EvaluateHandedness(){} // RVA: 0x7FFE870B1B60
        public void DoHandednessCheck(){} // RVA: 0x7FFE870B1CB0
        public void ArrowInPosition(){} // RVA: 0x7FFE870B1D90
        public void ReleaseNock(){} // RVA: 0x7FFE870B1E80
        public void ShutDown(){} // RVA: 0x7FFE870B1F00
        public void OnHandFocusLost(){} // RVA: 0x7FFE817E41C0
        public void OnHandFocusAcquired(){} // RVA: 0x7FFE870B22D0
        public void OnDetachedFromHand(){} // RVA: 0x7FFE870B23F0
        public void OnDestroy(){} // RVA: 0x7FFE870B2490
        public void .ctor(){} // RVA: 0x7FFE870B24A0
    }

    public class ModalThrowable : Throwable
    {
        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x7FFE8708D090
        public void HandAttachedUpdate(){} // RVA: 0x7FFE8708D180
        public void .ctor(){} // RVA: 0x7FFE8708D420
    }

    public class PlaySound : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870901F0
        public void Play(){} // RVA: 0x7FFE870904D0
        public void PlayWithDelay(){} // RVA: 0x7FFE87090680
        public void PlayOneShotSound(){} // RVA: 0x7FFE87090700
        public void PlayLooping(){} // RVA: 0x7FFE870908A0
        public void Disable(){} // RVA: 0x7FFE817E41C0
        public void Stop(){} // RVA: 0x7FFE87090AB0
        public void SetAudioSource(){} // RVA: 0x7FFE87090B10
        public void .ctor(){} // RVA: 0x7FFE87090D90
    }

    public class Player : MonoBehaviour
    {
        public UnityEngine.Transform trackingOriginTransform; // 0x20
        public UnityEngine.Transform[] hmdTransforms; // 0x28
        public Valve.VR.InteractionSystem.Hand[] hands; // 0x30
        public UnityEngine.Collider headCollider; // 0x38
        public UnityEngine.GameObject rigSteamVR; // 0x40
        public UnityEngine.GameObject rig2DFallback; // 0x48
        public UnityEngine.Transform audioListener; // 0x50
        public Valve.VR.SteamVR_Action_Boolean headsetOnHead; // 0x58
        public bool allowToggleTo2D; // 0x60

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE8708D510
        public void get_handCount(){} // RVA: 0x7FFE8708D6A0
        public void GetHand(){} // RVA: 0x7FFE8708D7E0
        public void get_leftHand(){} // RVA: 0x7FFE8708D930
        public void get_rightHand(){} // RVA: 0x7FFE8708DAA0
        public void get_scale(){} // RVA: 0x7FFE8708DC10
        public void get_hmdTransform(){} // RVA: 0x7FFE8708DCD0
        public void get_eyeHeight(){} // RVA: 0x7FFE8708DE10
        public void get_feetPositionGuess(){} // RVA: 0x7FFE8708E0C0
        public void get_bodyDirectionGuess(){} // RVA: 0x7FFE8708E420
        public void Awake(){} // RVA: 0x7FFE8708E660
        public void Start(){} // RVA: 0x7FFE8708E900
        public void Update(){} // RVA: 0x7FFE8708E9A0
        public void OnDrawGizmos(){} // RVA: 0x7FFE8708EB70
        public void Draw2DDebug(){} // RVA: 0x7FFE8708F730
        public void ActivateRig(){} // RVA: 0x7FFE8708F970
        public void PlayerShotSelf(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8708FEC0
    }

    public class RenderModel : MonoBehaviour
    {
        public UnityEngine.GameObject handPrefab; // 0x20

        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x7FFE87090E00
        public void remove_onControllerLoaded(){} // RVA: 0x7FFE87090EF0
        public void Awake(){} // RVA: 0x7FFE87090FE0
        public void InitializeHand(){} // RVA: 0x7FFE870910E0
        public void InitializeController(){} // RVA: 0x7FFE87091AD0
        public void DestroyHand(){} // RVA: 0x7FFE870920D0
        public void OnSkeletonActiveChange(){} // RVA: 0x7FFE87092460
        public void OnEnable(){} // RVA: 0x7FFE87092480
        public void OnDisable(){} // RVA: 0x7FFE870924B0
        public void OnDestroy(){} // RVA: 0x7FFE811AFBC0
        public void GetSkeleton(){} // RVA: 0x7FFE81178740
        public void SetInputSource(){} // RVA: 0x7FFE870924E0
        public void OnHandInitialized(){} // RVA: 0x7FFE870925D0
        public void MatchHandToTransform(){} // RVA: 0x7FFE87092610
        public void SetHandPosition(){} // RVA: 0x7FFE870929D0
        public void SetHandRotation(){} // RVA: 0x7FFE87092B60
        public void GetHandPosition(){} // RVA: 0x7FFE87092CE0
        public void GetHandRotation(){} // RVA: 0x7FFE87092ED0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFE870930A0
        public void SetVisibility(){} // RVA: 0x7FFE87093340
        public void Show(){} // RVA: 0x7FFE870933C0
        public void Hide(){} // RVA: 0x7FFE87093410
        public void SetMaterial(){} // RVA: 0x7FFE87093440
        public void SetControllerMaterial(){} // RVA: 0x7FFE87093510
        public void SetHandMaterial(){} // RVA: 0x7FFE87093650
        public void SetControllerVisibility(){} // RVA: 0x7FFE87093710
        public void SetHandVisibility(){} // RVA: 0x7FFE870937E0
        public void IsHandVisibile(){} // RVA: 0x7FFE870938B0
        public void IsControllerVisibile(){} // RVA: 0x7FFE87093980
        public void GetBone(){} // RVA: 0x7FFE87093A50
        public void GetBonePosition(){} // RVA: 0x7FFE87093B60
        public void GetControllerPosition(){} // RVA: 0x7FFE87093CC0
        public void GetBoneRotation(){} // RVA: 0x7FFE87093F40
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFE87094190
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x7FFE870943E0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFE870944D0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFE87094630
        public void SetAnimationState(){} // RVA: 0x7FFE87094730
        public void StopAnimation(){} // RVA: 0x7FFE87094860
        public void CheckAnimatorInit(){} // RVA: 0x7FFE87094980
        public void .ctor(){} // RVA: 0x7FFE87094D70
    }

    public class SeeThru : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87094E40
        public void OnEnable(){} // RVA: 0x7FFE87096040
        public void OnDisable(){} // RVA: 0x7FFE870962D0
        public void AttachedToHand(){} // RVA: 0x7FFE87096560
        public void DetachedFromHand(){} // RVA: 0x7FFE8184A200
        public void Update(){} // RVA: 0x7FFE870965C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SleepOnAwake : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87096A30
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SnapTurn : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870B2940
        public void AllOff(){} // RVA: 0x7FFE870B2950
        public void Update(){} // RVA: 0x7FFE870B2B50
        public void RotatePlayer(){} // RVA: 0x7FFE870B32F0
        public void DoRotatePlayer(){} // RVA: 0x7FFE870B3440
        public void ShowRotateFX(){} // RVA: 0x7FFE870B3500
        public void UpdateOrientation(){} // RVA: 0x7FFE870B3670
        public void .ctor(){} // RVA: 0x7FFE870B3DE0
    }

    public class SoundBowClick : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870B27B0
        public void PlayBowTensionClicks(){} // RVA: 0x7FFE870B2840
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SoundDeparent : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87096B60
        public void Start(){} // RVA: 0x7FFE87096BF0
        public void .ctor(){} // RVA: 0x7FFE81155060
    }

    public class SoundPlayOneshot : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87096E00
        public void Play(){} // RVA: 0x7FFE87096EA0
        public void Pause(){} // RVA: 0x7FFE870970A0
        public void UnPause(){} // RVA: 0x7FFE870971C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SpawnAndAttachAfterControllerIsTracking : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870972E0
        public void Update(){} // RVA: 0x7FFE87097370
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SpawnAndAttachToHand : MonoBehaviour
    {
        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x7FFE87097650
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Teleport : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Boolean teleportAction; // 0x20

        // ── Methods ──
        public void ChangeSceneAction(){} // RVA: 0x7FFE870B53E0
        public void PlayerAction(){} // RVA: 0x7FFE870B5490
        public void PlayerPreAction(){} // RVA: 0x7FFE870B5550
        public void get_instance(){} // RVA: 0x7FFE870B5610
        public void Awake(){} // RVA: 0x7FFE870B57E0
        public void Start(){} // RVA: 0x7FFE870B5E00
        public void OnEnable(){} // RVA: 0x7FFE870B6220
        public void OnDisable(){} // RVA: 0x7FFE870B6260
        public void CheckForSpawnPoint(){} // RVA: 0x7FFE870B62A0
        public void HideTeleportPointer(){} // RVA: 0x7FFE870B6440
        public void Update(){} // RVA: 0x7FFE870B6520
        public void UpdatePointer(){} // RVA: 0x7FFE870B6F30
        public void FixedUpdate(){} // RVA: 0x7FFE870B8B90
        public void OnChaperoneInfoInitialized(){} // RVA: 0x7FFE870B94A0
        public void HidePointer(){} // RVA: 0x7FFE870BAC60
        public void ShowPointer(){} // RVA: 0x7FFE870BB600
        public void UpdateTeleportColors(){} // RVA: 0x7FFE870BC7B0
        public void PlayAudioClip(){} // RVA: 0x7FFE870BC8D0
        public void PlayPointerHaptic(){} // RVA: 0x7FFE870BC980
        public void TryTeleportPlayer(){} // RVA: 0x7FFE870BCB40
        public void InitiateTeleportFade(){} // RVA: 0x7FFE870BCC70
        public void TeleportPlayer(){} // RVA: 0x7FFE870BD0C0
        public void HighlightSelected(){} // RVA: 0x7FFE870BDE60
        public void ShowTeleportHint(){} // RVA: 0x7FFE870BE410
        public void CancelTeleportHint(){} // RVA: 0x7FFE870BE530
        public void TeleportHintCoroutine(){} // RVA: 0x7FFE870BE690
        public void IsEligibleForTeleport(){} // RVA: 0x7FFE870BE730
        public void ShouldOverrideHoverLock(){} // RVA: 0x7FFE870BEB60
        public void WasTeleportButtonReleased(){} // RVA: 0x7FFE870BEC60
        public void IsTeleportButtonDown(){} // RVA: 0x7FFE870BEDD0
        public void WasTeleportButtonPressed(){} // RVA: 0x7FFE870BEF40
        public void GetPointerStartTransform(){} // RVA: 0x7FFE870BF0B0
        public void .ctor(){} // RVA: 0x7FFE870BF210
        public void .cctor(){} // RVA: 0x7FFE870BF450
    }

    public class TeleportArc : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870BFA00
        public void Update(){} // RVA: 0x7FFE870BFA60
        public void CreateLineRendererObjects(){} // RVA: 0x7FFE870BFB70
        public void SetArcData(){} // RVA: 0x7FFE870C0470
        public void Show(){} // RVA: 0x7FFE870C0510
        public void Hide(){} // RVA: 0x7FFE870C0530
        public void DrawArc(){} // RVA: 0x7FFE870C0570
        public void DrawArcSegment(){} // RVA: 0x7FFE870C0950
        public void SetColor(){} // RVA: 0x7FFE870C0B40
        public void FindProjectileCollision(){} // RVA: 0x7FFE870C0C90
        public void GetArcPositionAtTime(){} // RVA: 0x7FFE870C0FE0
        public void HideLineSegments(){} // RVA: 0x7FFE870C11B0
        public void .ctor(){} // RVA: 0x7FFE870C1270
    }

    public class TeleportArea : TeleportMarkerBase
    {
        public UnityEngine.Bounds _meshBounds; // 0x28

        // ── Methods ──
        public void get_meshBounds(){} // RVA: 0x7FFE82DDC4A0
        public void set_meshBounds(){} // RVA: 0x7FFE82DDC480
        public void Awake(){} // RVA: 0x7FFE870C12F0
        public void Start(){} // RVA: 0x7FFE870C13F0
        public void ShouldActivate(){} // RVA: 0x7FFE811E0850
        public void ShouldMovePlayer(){} // RVA: 0x7FFE811E0850
        public void Highlight(){} // RVA: 0x7FFE870C15C0
        public void SetAlpha(){} // RVA: 0x7FFE870C1690
        public void UpdateVisuals(){} // RVA: 0x7FFE870C17C0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFE870C18E0
        public void CalculateBounds(){} // RVA: 0x7FFE870C1AD0
        public void GetTintColor(){} // RVA: 0x7FFE870C1D10
        public void .ctor(){} // RVA: 0x7FFE870C1D40
    }

    public class TeleportMarkerBase : MonoBehaviour
    {
        public bool locked; // 0x20

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFE811E0850
        public void SetLocked(){} // RVA: 0x7FFE870C1DA0
        public void TeleportPlayer(){} // RVA: 0x7FFE810FB310
        public void UpdateVisuals(){} // RVA: 0x7FFE80E45FE0
        public void Highlight(){} // RVA: 0x7FFE80E466C0
        public void SetAlpha(){}
        public void ShouldActivate(){} // RVA: 0x7FFE80E2F3B0
        public void ShouldMovePlayer(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE870C1DC0
    }

    public class TeleportPoint : TeleportMarkerBase
    {
        public 0x6660732C teleportType; // 0x28

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFE810FB320
        public void Awake(){} // RVA: 0x7FFE870C1E10
        public void Start(){} // RVA: 0x7FFE870C2130
        public void Update(){} // RVA: 0x7FFE870C21A0
        public void ShouldActivate(){} // RVA: 0x7FFE870C23F0
        public void ShouldMovePlayer(){} // RVA: 0x7FFE811E0850
        public void Highlight(){} // RVA: 0x7FFE870C2580
        public void UpdateVisuals(){} // RVA: 0x7FFE870C2860
        public void SetAlpha(){} // RVA: 0x7FFE870C2AA0
        public void SetMeshMaterials(){} // RVA: 0x7FFE870C2EE0
        public void TeleportToScene(){} // RVA: 0x7FFE870C30B0
        public void GetRelevantComponents(){} // RVA: 0x7FFE870C31A0
        public void ReleaseRelevantComponents(){} // RVA: 0x7FFE870C3AE0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFE870C3CF0
        public void .ctor(){} // RVA: 0x7FFE870C41C0
    }

    public class TeleportURPHelper : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Throwable : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87097810
        public void OnHandHoverBegin(){} // RVA: 0x7FFE87097AA0
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87097C70
        public void HandHoverUpdate(){} // RVA: 0x7FFE87097CA0
        public void OnAttachedToHand(){} // RVA: 0x7FFE87097D60
        public void OnDetachedFromHand(){} // RVA: 0x7FFE87098130
        public void GetReleaseVelocities(){} // RVA: 0x7FFE87098310
        public void HandAttachedUpdate(){} // RVA: 0x7FFE87098B20
        public void LateDetach(){} // RVA: 0x7FFE87098C30
        public void OnHandFocusAcquired(){} // RVA: 0x7FFE87098D30
        public void OnHandFocusLost(){} // RVA: 0x7FFE87098EB0
        public void .ctor(){} // RVA: 0x7FFE8708D420
    }

    public class UIElement : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870991A0
        public void OnHandHoverBegin(){} // RVA: 0x7FFE870992F0
        public void OnHandHoverEnd(){} // RVA: 0x7FFE87099590
        public void HandHoverUpdate(){} // RVA: 0x7FFE87099850
        public void OnButtonClick(){} // RVA: 0x7FFE87099A70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Unparent : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE87099AC0
        public void Update(){} // RVA: 0x7FFE87099D70
        public void GetOldParent(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Util : Object
    {
        // ── Methods ──
        public void RemapNumber(){} // RVA: 0x7FFE87099EA0
        public void RemapNumberClamped(){} // RVA: 0x7FFE87099EC0
        public void Approach(){} // RVA: 0x7FFE87099F30
        public void BezierInterpolate3(){} // RVA: 0x7FFE87099F60
        public void BezierInterpolate4(){} // RVA: 0x7FFE8709A0F0
        public void Vector3FromString(){} // RVA: 0x7FFE8709A3A0
        public void Vector2FromString(){} // RVA: 0x7FFE8709A4C0
        public void Normalize(){} // RVA: 0x7FFE8709A5B0
        public void Vector2AsVector3(){} // RVA: 0x7FFE811633F0
        public void Vector3AsVector2(){} // RVA: 0x7FFE811633D0
        public void AngleOf(){} // RVA: 0x7FFE8709A5C0
        public void YawOf(){} // RVA: 0x7FFE8709A620
        public void Swap(){} // RVA: 0x7FFE80E462E0
        public void Shuffle(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void RandomWithLookback(){} // RVA: 0x7FFE8709A670
        public void FindChild(){} // RVA: 0x7FFE8709A850
        public void IsNullOrEmpty(){} // RVA: 0x7FFE80E2F230
        public void IsValidIndex(){} // RVA: 0x7FFE80E31200 | overloaded x2
        public void FindOrAdd(){} // RVA: 0x7FFE810A1420
        public void FindAndRemove(){} // RVA: 0x7FFE80E2E440
        public void FindOrAddComponent(){} // RVA: 0x7FFE810A1420
        public void FastRemove(){} // RVA: 0x7FFE80E4BA70
        public void ReplaceGameObject(){} // RVA: 0x7FFE810A1420
        public void SwitchLayerRecursively(){} // RVA: 0x7FFE8709AB00
        public void DrawCross(){} // RVA: 0x7FFE8709AD30
        public void ResetTransform(){} // RVA: 0x7FFE8709B380
        public void ClosestPointOnLine(){} // RVA: 0x7FFE8709B520
        public void AfterTimer(){} // RVA: 0x7FFE8709B7E0
        public void SendPhysicsMessage(){} // RVA: 0x7FFE8709BBB0 | overloaded x2
        public void IgnoreCollisions(){} // RVA: 0x7FFE8709BEA0
        public void WrapCoroutine(){} // RVA: 0x7FFE8709C040
        public void ColorWithAlpha(){} // RVA: 0x7FFE817C6370
        public void Quit(){} // RVA: 0x7FFE8709C140
        public void FloatToDecimal(){} // RVA: 0x7FFE8709C170
        public void Median(){} // RVA: 0x7FFE810A1420
        public void ForEach(){} // RVA: 0x7FFE80E462E0
        public void FixupNewlines(){} // RVA: 0x7FFE8709C290
        public void PathLength(){} // RVA: 0x7FFE8709C350
        public void HasCommandLineArgument(){} // RVA: 0x7FFE8709C530
        public void GetCommandLineArgValue(){} // RVA: 0x7FFE8709C6B0 | overloaded x2
        public void SetActive(){} // RVA: 0x7FFE8709C790
        public void CombinePaths(){} // RVA: 0x7FFE8709C8A0
    }

    public class VelocityEstimator : MonoBehaviour
    {
        // ── Methods ──
        public void BeginEstimatingVelocity(){} // RVA: 0x7FFE8709CDC0
        public void FinishEstimatingVelocity(){} // RVA: 0x7FFE8709CEE0
        public void GetVelocityEstimate(){} // RVA: 0x7FFE8709CF60
        public void GetAngularVelocityEstimate(){} // RVA: 0x7FFE8709D090
        public void GetAccelerationEstimate(){} // RVA: 0x7FFE8709D1C0
        public void Awake(){} // RVA: 0x7FFE8709D3A0
        public void EstimateVelocityCoroutine(){} // RVA: 0x7FFE8709D4C0
        public void .ctor(){} // RVA: 0x7FFE8709D560
    }

}