// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 75
// Methods: 667

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AfterTimer_Component
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF900DA30
        public void Wait(){} // RVA: 0x7FFAF900DAB0
        public void OnDestroy(){} // RVA: 0x7FFAF900DB50
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class AllowTeleportWhileAttachedToHand
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FAF8C0
    }

    public class ArcheryTarget
    {
        // ── Methods ──
        public void ApplyDamage(){} // RVA: 0x7FFAF9017180
        public void FireExposure(){} // RVA: 0x7FFAF9017180
        public void OnDamageTaken(){} // RVA: 0x7FFAF9017190
        public void FallDown(){} // RVA: 0x7FFAF9017270
        public void .ctor(){} // RVA: 0x7FFAF9017310
    }

    public class Arrow
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9017740
        public void Start(){} // RVA: 0x7FFAF90179D0
        public void FixedUpdate(){} // RVA: 0x7FFAF9017A70
        public void StartRelease(){} // RVA: 0x7FFAF9017D50
        public void ArrowReleased(){} // RVA: 0x7FFAF90181E0
        public void SetCollisionMode(){} // RVA: 0x7FFAF9018D30
        public void OnCollisionEnter(){} // RVA: 0x7FFAF9018E70
        public void StickInTarget(){} // RVA: 0x7FFAF9019DD0
        public void OnDestroy(){} // RVA: 0x7FFAF901B000
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ArrowHand
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF901B2B0
        public void OnAttachedToHand(){} // RVA: 0x7FFAF901B410
        public void InstantiateArrow(){} // RVA: 0x7FFAF901B470
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF901B850
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF901C900
        public void FireArrow(){} // RVA: 0x7FFAF901C9A0
        public void EnableArrowSpawn(){} // RVA: 0x7FFAF2F40010
        public void ArrowReleaseHaptics(){} // RVA: 0x7FFAF901D400
        public void OnHandFocusLost(){} // RVA: 0x7FFAF2F6EC00
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAF2F6F550
        public void FindBow(){} // RVA: 0x7FFAF901D4A0
        public void .ctor(){} // RVA: 0x7FFAF901D540
    }

    public class ArrowheadRotation
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF901D7F0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Balloon
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF901D8E0
        public void Update(){} // RVA: 0x7FFAF901DAA0
        public void SpawnParticles(){} // RVA: 0x7FFAF901DBB0
        public void FixedUpdate(){} // RVA: 0x7FFAF901E060
        public void ApplyDamage(){} // RVA: 0x7FFAF901E1F0
        public void OnCollisionEnter(){} // RVA: 0x7FFAF901E2A0
        public void SetColor(){} // RVA: 0x7FFAF901E8F0
        public void BalloonColorToRGB(){} // RVA: 0x7FFAF901E9D0
        public void .ctor(){} // RVA: 0x7FFAF901EBE0
    }

    public class BalloonColliders
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF901EC40
        public void OnEnable(){} // RVA: 0x7FFAF901F1F0
        public void OnDisable(){} // RVA: 0x7FFAF901F840
        public void OnDestroy(){} // RVA: 0x7FFAF901FA00
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class BalloonHapticBump
    {
        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFAF901FB30
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class BalloonSpawner
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF901FD70
        public void Update(){} // RVA: 0x7FFAF901FE90
        public void SpawnBalloon(){} // RVA: 0x7FFAF901FFF0
        public void SpawnBalloonFromEvent(){} // RVA: 0x7FFAF9020950
        public void .ctor(){} // RVA: 0x7FFAF9020960
    }

    public class BodyCollider
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FD4500
        public void FixedUpdate(){} // RVA: 0x7FFAF8FD4590
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ChaperoneInfo
    {
        // ── Methods ──
        public void get_initialized(){} // RVA: 0x7FFAF2E7B9D0
        public void set_initialized(){} // RVA: 0x7FFAF2E7B9E0
        public void get_playAreaSizeX(){} // RVA: 0x7FFAF2EFAF50
        public void set_playAreaSizeX(){} // RVA: 0x7FFAF2EFAF60
        public void get_playAreaSizeZ(){} // RVA: 0x7FFAF2E6C210
        public void set_playAreaSizeZ(){} // RVA: 0x7FFAF2E6C220
        public void get_roomscale(){} // RVA: 0x7FFAF2E6C230
        public void set_roomscale(){} // RVA: 0x7FFAF2E6C240
        public void InitializedAction(){} // RVA: 0x7FFAF9025950
        public void get_instance(){} // RVA: 0x7FFAF90259F0
        public void Start(){} // RVA: 0x7FFAF9025D40
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void .cctor(){} // RVA: 0x7FFAF9025DE0
    }

    public class CircularDrive
    {
        // ── Methods ──
        public void Freeze(){} // RVA: 0x7FFAF8FD48C0
        public void UnFreeze(){} // RVA: 0x7FFAF8FD4990
        public void Awake(){} // RVA: 0x7FFAF8FD49B0
        public void Start(){} // RVA: 0x7FFAF8FD4A50
        public void OnDisable(){} // RVA: 0x7FFAF8FD5670
        public void HapticPulses(){} // RVA: 0x7FFAF8FD57E0
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF8FD58A0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF8FD58C0
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FD5A40
        public void ComputeToTransformProjected(){} // RVA: 0x7FFAF8FD5D10
        public void DrawDebugPath(){} // RVA: 0x7FFAF8FD6180
        public void UpdateLinearMapping(){} // RVA: 0x7FFAF8FD70C0
        public void UpdateGameObject(){} // RVA: 0x7FFAF8FD7150
        public void UpdateDebugText(){} // RVA: 0x7FFAF8FD7410
        public void UpdateAll(){} // RVA: 0x7FFAF8FD7610
        public void ComputeAngle(){} // RVA: 0x7FFAF8FD76B0
        public void .ctor(){} // RVA: 0x7FFAF8FD7BA0
    }

    public class ComplexThrowable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FD7F40
        public void Update(){} // RVA: 0x7FFAF8FD7FC0
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF8FD8100
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF8FD81E0
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FD82C0
        public void PhysicsAttach(){} // RVA: 0x7FFAF8FD8310
        public void PhysicsDetach(){} // RVA: 0x7FFAF8FD8DF0
        public void FixedUpdate(){} // RVA: 0x7FFAF8FD9100
        public void .ctor(){} // RVA: 0x7FFAF8FD9680
    }

    public class ControllerButtonHints
    {
        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0x7FFAF2DBB0C0
        public void get_initialized(){} // RVA: 0x7FFAF8DDC3D0
        public void set_initialized(){} // RVA: 0x7FFAF8DDC3E0
        public void Awake(){} // RVA: 0x7FFAF900EE60
        public void Start(){} // RVA: 0x7FFAF900EFB0
        public void HintDebugLog(){} // RVA: 0x7FFAF900F020
        public void OnEnable(){} // RVA: 0x7FFAF900F0B0
        public void OnDisable(){} // RVA: 0x7FFAF900F0E0
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFAF900F120
        public void SetInputSource(){} // RVA: 0x7FFAF900F140
        public void OnHandInitialized(){} // RVA: 0x7FFAF900F230
        public void OnRenderModelLoaded(){} // RVA: 0x7FFAF900F770
        public void DoInitialize(){} // RVA: 0x7FFAF900FA90
        public void CreateAndAddButtonInfo(){} // RVA: 0x7FFAF900FB90
        public void ComputeTextEndTransforms(){} // RVA: 0x7FFAF9011D30
        public void ShowButtonHint(){} // RVA: 0x7FFAF9015170 | overloaded x2
        public void HideAllButtonHints(){} // RVA: 0x7FFAF9015350 | overloaded x2
        public void HideButtonHint(){} // RVA: 0x7FFAF9015260 | overloaded x2
        public void IsButtonHintActive(){} // RVA: 0x7FFAF9015430 | overloaded x2
        public void TestButtonHints(){} // RVA: 0x7FFAF90137F0
        public void TestTextHints(){} // RVA: 0x7FFAF9013890
        public void Update(){} // RVA: 0x7FFAF9013930
        public void UpdateTextHint(){} // RVA: 0x7FFAF9013FE0
        public void Clear(){} // RVA: 0x7FFAF90146D0
        public void ShowText(){} // RVA: 0x7FFAF9014760
        public void HideText(){} // RVA: 0x7FFAF9014B20
        public void HideAllText(){} // RVA: 0x7FFAF9014CB0
        public void GetActiveHintText(){} // RVA: 0x7FFAF9015AE0 | overloaded x2
        public void GetControllerButtonHints(){} // RVA: 0x7FFAF9014FE0
        public void ShowTextHint(){} // RVA: 0x7FFAF9015520
        public void HideTextHint(){} // RVA: 0x7FFAF90156F0
        public void HideAllTextHints(){} // RVA: 0x7FFAF9015A00
        public void .ctor(){} // RVA: 0x7FFAF9015CD0
    }

    public class ControllerHoverHighlight
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FD9930
        public void OnHandInitialized(){} // RVA: 0x7FFAF8FD99C0
        public void RenderModel_onControllerLoaded(){} // RVA: 0x7FFAF8FDA130
        public void OnParentHandHoverBegin(){} // RVA: 0x7FFAF8FDA170
        public void OnParentHandHoverEnd(){} // RVA: 0x7FFAF8FDA420
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x7FFAF8FDA430
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFAF8FDA420
        public void ShowHighlight(){} // RVA: 0x7FFAF8FDA7A0
        public void HideHighlight(){} // RVA: 0x7FFAF8FDA910
        public void .ctor(){} // RVA: 0x7FFAF2DC4BB0
    }

    public class CustomEvents
    {
    }

    public class DebugUI
    {
        public object responseCode;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF8FDAB30
        public void Start(){} // RVA: 0x7FFAF8FDACC0
        public void OnGUI(){} // RVA: 0x7FFAF8FDAD30
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DestroyOnDetachedFromHand
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF8FDADE0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DestroyOnParticleSystemDeath
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FDAE80
        public void CheckParticleSystem(){} // RVA: 0x7FFAF8FDAF40
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DestroyOnTriggerEnter
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FDB040
        public void OnTriggerEnter(){} // RVA: 0x7FFAF8FDB060
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DistanceHaptics
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FDB300
        public void .ctor(){} // RVA: 0x7FFAF8FDB3A0
    }

    public class DontDestroyOnLoad
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FDB8D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class EnumFlags
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Equippable
    {
        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x7FFAF8FDB960
        public void Start(){} // RVA: 0x7FFAF8FDBA70
        public void Update(){} // RVA: 0x7FFAF8FDBBC0
        public void .ctor(){} // RVA: 0x7FFAF8FDBF80
    }

    public class ExplosionWobble
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x7FFAF90209D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class FallbackCameraController
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF8FDBFD0
        public void Update(){} // RVA: 0x7FFAF8FDC030
        public void OnGUI(){} // RVA: 0x7FFAF8FDCA00
        public void .ctor(){} // RVA: 0x7FFAF8FDCA80
    }

    public class FireSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF9020B40
        public void Update(){} // RVA: 0x7FFAF9020B50
        public void OnTriggerEnter(){} // RVA: 0x7FFAF9020CE0
        public void FireExposure(){} // RVA: 0x7FFAF9020D90
        public void StartBurning(){} // RVA: 0x7FFAF9020FE0
        public void .ctor(){} // RVA: 0x7FFAF3FA24E0
    }

    public class Hand
    {
        // ── Methods ──
        public void get_AttachedObjects(){} // RVA: 0x7FFAF8FDCAE0
        public void get_hoverLocked(){} // RVA: 0x7FFAF2EB8F80
        public void set_hoverLocked(){} // RVA: 0x7FFAF2EB8F90
        public void get_isActive(){} // RVA: 0x7FFAF8FDCBB0
        public void get_isPoseValid(){} // RVA: 0x7FFAF8FDCD70
        public void get_hoveringInteractable(){} // RVA: 0x7FFAF2E0E970
        public void set_hoveringInteractable(){} // RVA: 0x7FFAF8FDCDC0
        public void get_currentAttachedObject(){} // RVA: 0x7FFAF8FDD360
        public void get_currentAttachedObjectInfo(){} // RVA: 0x7FFAF8FDD410
        public void get_currentAttachedTeleportManager(){} // RVA: 0x7FFAF8FDD660
        public void get_skeleton(){} // RVA: 0x7FFAF8FDD700
        public void ShowController(){} // RVA: 0x7FFAF8FDD7F0
        public void HideController(){} // RVA: 0x7FFAF8FDD9A0
        public void ShowSkeleton(){} // RVA: 0x7FFAF8FDDB50
        public void HideSkeleton(){} // RVA: 0x7FFAF8FDDD00
        public void HasSkeleton(){} // RVA: 0x7FFAF8FDDEB0
        public void Show(){} // RVA: 0x7FFAF8FDE040
        public void Hide(){} // RVA: 0x7FFAF8FDE050
        public void SetVisibility(){} // RVA: 0x7FFAF8FDE060
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFAF8FDE160
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAF8FDE240
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAF8FDE470
        public void SetAnimationState(){} // RVA: 0x7FFAF8FDE630
        public void StopAnimation(){} // RVA: 0x7FFAF8FDE830
        public void AttachObject(){} // RVA: 0x7FFAF8FDEA30
        public void ObjectIsAttached(){} // RVA: 0x7FFAF8FE1C20
        public void ForceHoverUnlock(){} // RVA: 0x7FFAF331A5B0
        public void DetachObject(){} // RVA: 0x7FFAF8FE1E10
        public void GetTrackedObjectVelocity(){} // RVA: 0x7FFAF8FE3570
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x7FFAF8FE39B0
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFAF8FE3DF0
        public void CleanUpAttachedObjectStack(){} // RVA: 0x7FFAF8FE3F60
        public void Awake(){} // RVA: 0x7FFAF8FE40E0
        public void OnDestroy(){} // RVA: 0x7FFAF8FE4960
        public void OnTransformUpdated(){} // RVA: 0x7FFAF4304D10
        public void Start(){} // RVA: 0x7FFAF8FE4B40
        public void UpdateHovering(){} // RVA: 0x7FFAF8FE4BE0
        public void CheckHoveringForTransform(){} // RVA: 0x7FFAF8FE51A0
        public void UpdateNoSteamVRFallback(){} // RVA: 0x7FFAF8FE5E00
        public void UpdateDebugText(){} // RVA: 0x7FFAF8FE6590
        public void OnEnable(){} // RVA: 0x7FFAF8FE7190
        public void OnDisable(){} // RVA: 0x7FFAF8FE7320
        public void Update(){} // RVA: 0x7FFAF8FE73A0
        public void IsStillHovering(){} // RVA: 0x7FFAF8FE7590
        public void HandFollowUpdate(){} // RVA: 0x7FFAF8FE76D0
        public void FixedUpdate(){} // RVA: 0x7FFAF8FE8DE0
        public void UpdateAttachedVelocity(){} // RVA: 0x7FFAF8FE9730
        public void ResetAttachedTransform(){} // RVA: 0x7FFAF8FE9AF0
        public void TargetItemPosition(){} // RVA: 0x7FFAF8FE9D60
        public void TargetItemRotation(){} // RVA: 0x7FFAF8FEA200
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x7FFAF8FEAAB0
        public void OnInputFocus(){} // RVA: 0x7FFAF8FEB280
        public void OnDrawGizmos(){} // RVA: 0x7FFAF8FEB420
        public void HandDebugLog(){} // RVA: 0x7FFAF8FEBB00
        public void HoverLock(){} // RVA: 0x7FFAF8FEBBC0
        public void HoverUnlock(){} // RVA: 0x7FFAF8FEBC70
        public void TriggerHapticPulse(){} // RVA: 0x7FFAF8FEBE60 | overloaded x2
        public void ShowGrabHint(){} // RVA: 0x7FFAF8FEBFB0 | overloaded x2
        public void HideGrabHint(){} // RVA: 0x7FFAF8FEBFA0
        public void GetGrabStarting(){} // RVA: 0x7FFAF8FEBFE0
        public void GetGrabEnding(){} // RVA: 0x7FFAF8FEC3E0
        public void IsGrabEnding(){} // RVA: 0x7FFAF8FEC6B0
        public void IsGrabbingWithType(){} // RVA: 0x7FFAF8FEC930
        public void IsGrabbingWithOppositeType(){} // RVA: 0x7FFAF8FECAC0
        public void GetBestGrabbingType(){} // RVA: 0x7FFAF8FECC60 | overloaded x2
        public void InitController(){} // RVA: 0x7FFAF8FECE30
        public void SetRenderModel(){} // RVA: 0x7FFAF8FEDB10
        public void SetHoverRenderModel(){} // RVA: 0x7FFAF8FEDC80
        public void GetDeviceIndex(){} // RVA: 0x7FFAF8FEDD30
        public void .ctor(){} // RVA: 0x7FFAF8FEDD80
    }

    public class HandCollider
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FEEA50
        public void Start(){} // RVA: 0x7FFAF8FEEB30
        public void SetPhysicMaterial(){} // RVA: 0x7FFAF8FEF360
        public void SetCollisionDetectionEnabled(){} // RVA: 0x7FFAF8FEF4C0
        public void MoveTo(){} // RVA: 0x7FFAF8FEF530
        public void TeleportTo(){} // RVA: 0x7FFAF8FEF550
        public void Reset(){} // RVA: 0x7FFAF8FEF800
        public void SetCenterPoint(){} // RVA: 0x7FFAF8FEF840
        public void ExecuteFixedUpdate(){} // RVA: 0x7FFAF8FEF850
        public void GetTargetVelocities(){} // RVA: 0x7FFAF8FEFD60
        public void OnCollisionEnter(){} // RVA: 0x7FFAF8FF0290
        public void .ctor(){} // RVA: 0x7FFAF8FF05C0
    }

    public class HandEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FEEA10
    }

    public class HandPhysics
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FF0950
        public void FixedUpdate(){} // RVA: 0x7FFAF8FF1020
        public void UpdateCenterPoint(){} // RVA: 0x7FFAF8FF12A0
        public void UpdatePositions(){} // RVA: 0x7FFAF8FF1560
        public void UpdateFingertips(){} // RVA: 0x7FFAF8FF2690
        public void UpdateHand(){} // RVA: 0x7FFAF8FF2B60
        public void ProcessPos(){} // RVA: 0x7FFAF8FF3170
        public void ProcessRot(){} // RVA: 0x7FFAF8FF32F0
        public void .ctor(){} // RVA: 0x7FFAF8FF33B0
    }

    public class HapticRack
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FF3510
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF2DB5200
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF850F950
        public void Update(){} // RVA: 0x7FFAF8FF3650
        public void Pulse(){} // RVA: 0x7FFAF8FF37D0
        public void .ctor(){} // RVA: 0x7FFAF8FF3910
    }

    public class HideOnHandFocusLost
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0x7FFAF2F6EC00
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class HoverButton
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FF3970
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FF3C40
        public void LateUpdate(){} // RVA: 0x7FFAF8FF4340
        public void InvokeEvents(){} // RVA: 0x7FFAF8FF4470
        public void .ctor(){} // RVA: 0x7FFAF8FF4550
    }

    public class IgnoreHovering
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class IgnoreTeleportTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class InputModule
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF8FF45C0
        public void ShouldActivateModule(){} // RVA: 0x7FFAF8FF4750
        public void HoverBegin(){} // RVA: 0x7FFAF8FF4830
        public void HoverEnd(){} // RVA: 0x7FFAF8FF4930
        public void Submit(){} // RVA: 0x7FFAF2E55510
        public void Process(){} // RVA: 0x7FFAF8FF4A50
        public void .ctor(){} // RVA: 0x7FFAF8FF4C20
    }

    public class Interactable
    {
        // ── Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x7FFAF8FF4C30
        public void remove_onAttachedToHand(){} // RVA: 0x7FFAF8FF4D20
        public void add_onDetachedFromHand(){} // RVA: 0x7FFAF8FF4E10
        public void remove_onDetachedFromHand(){} // RVA: 0x7FFAF8FF4F00
        public void get_hoveringHand(){} // RVA: 0x7FFAF8FF4FF0
        public void get_isDestroying(){} // RVA: 0x7FFAF41EF990
        public void set_isDestroying(){} // RVA: 0x7FFAF41EEC00
        public void get_isHovering(){} // RVA: 0x7FFAF639ED40
        public void set_isHovering(){} // RVA: 0x7FFAF639ED50
        public void get_wasHovering(){} // RVA: 0x7FFAF8FF5080
        public void set_wasHovering(){} // RVA: 0x7FFAF8FF5090
        public void Awake(){} // RVA: 0x7FFAF8FF50A0
        public void Start(){} // RVA: 0x7FFAF8FF5130
        public void ShouldIgnoreHighlight(){} // RVA: 0x7FFAF8FF5510
        public void ShouldIgnore(){} // RVA: 0x7FFAF8FF5590
        public void CreateHighlightRenderers(){} // RVA: 0x7FFAF8FF5720
        public void UpdateHighlightRenderers(){} // RVA: 0x7FFAF8FF6070
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF8FF6D20
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF8FF6DD0
        public void Update(){} // RVA: 0x7FFAF8FF6F50
        public void OnAttachedToHand(){} // RVA: 0x7FFAF8FF7080
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF8FF7440
        public void OnDestroy(){} // RVA: 0x7FFAF8FF7960
        public void OnDisable(){} // RVA: 0x7FFAF8FF7BA0
        public void .ctor(){} // RVA: 0x7FFAF8FF7D50
    }

    public class InteractableDebug
    {
        // ── Methods ──
        public void get_isThrowable(){} // RVA: 0x7FFAF8FF7F70
        public void Awake(){} // RVA: 0x7FFAF8FF8040
        public void OnAttachedToHand(){} // RVA: 0x7FFAF8FF8270
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF8FF82F0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF8FF8450
        public void GetColliders(){} // RVA: 0x7FFAF2E0A740
        public void IgnoreObject(){} // RVA: 0x7FFAF8FF8A20
        public void SetIsSimulation(){} // RVA: 0x7FFAF79AF5C0
        public void CreateSimulation(){} // RVA: 0x7FFAF8FF8B30
        public void CreateMarker(){} // RVA: 0x7FFAF8FF8F20 | overloaded x2
        public void ColorSelf(){} // RVA: 0x7FFAF8FF96D0
        public void ColorThing(){} // RVA: 0x7FFAF8FF97A0
        public void .ctor(){} // RVA: 0x7FFAF8FF9870
    }

    public class InteractableHoverEvents
    {
        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF8FF98C0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF8FF98E0
        public void OnAttachedToHand(){} // RVA: 0x7FFAF8FF9900
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF8FF9920
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ItemPackage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ItemPackageReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ItemPackageSpawner
    {
        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0x7FFAF2DBB0C0
        public void set_itemPackage(){} // RVA: 0x7FFAF8FF9940
        public void CreatePreviewObject(){} // RVA: 0x7FFAF8FF9950
        public void Start(){} // RVA: 0x7FFAF8FF9F60
        public void VerifyItemPackage(){} // RVA: 0x7FFAF8FF9F60
        public void ItemPackageNotValid(){} // RVA: 0x7FFAF8FFA0F0
        public void ClearPreview(){} // RVA: 0x7FFAF8FFA260
        public void Update(){} // RVA: 0x7FFAF8FFA5B0
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF8FFA6B0
        public void TakeBackItem(){} // RVA: 0x7FFAF8FFA890
        public void GetAttachedItemPackage(){} // RVA: 0x7FFAF8FFA8F0
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FFAAB0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF8FFACB0
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x7FFAF8FFAD00
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x7FFAF8FFB130
        public void SpawnAndAttachObject(){} // RVA: 0x7FFAF8FFB3A0
        public void .ctor(){} // RVA: 0x7FFAF8FFB9D0
    }

    public class LinearAnimation
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FFBA20
        public void Update(){} // RVA: 0x7FFAF8FFBED0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class LinearAnimator
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FFBF30
        public void Update(){} // RVA: 0x7FFAF8FFC1E0
        public void .ctor(){} // RVA: 0x7FFAF8FFC2C0
    }

    public class LinearAudioPitch
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FFC310
        public void Update(){} // RVA: 0x7FFAF8FFC560
        public void Apply(){} // RVA: 0x7FFAF8FFC680
        public void .ctor(){} // RVA: 0x7FFAF42965B0
    }

    public class LinearBlendshape
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FFC790
        public void Update(){} // RVA: 0x7FFAF8FFC9E0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class LinearDisplacement
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FFCAC0
        public void Update(){} // RVA: 0x7FFAF8FFCCB0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class LinearDrive
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FFCE90
        public void Start(){} // RVA: 0x7FFAF8FFCFB0
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FFD2C0
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF8FFD4C0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF8FFD5F0
        public void CalculateMappingChangeRate(){} // RVA: 0x7FFAF8FFD5F0
        public void UpdateLinearMapping(){} // RVA: 0x7FFAF8FFD670
        public void CalculateLinearMapping(){} // RVA: 0x7FFAF8FFD980
        public void Update(){} // RVA: 0x7FFAF8FFDC80
        public void .ctor(){} // RVA: 0x7FFAF8FFDFA0
    }

    public class LinearMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Longbow
    {
        // ── Methods ──
        public void OnAttachedToHand(){} // RVA: 0x7FFAF2DB5200
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF9021580
        public void ArrowReleased(){} // RVA: 0x7FFAF9022650
        public void ResetDrawAnim(){} // RVA: 0x7FFAF90227D0
        public void GetArrowVelocity(){} // RVA: 0x7FFAF304D580
        public void StartRotationLerp(){} // RVA: 0x7FFAF9022870
        public void StartNock(){} // RVA: 0x7FFAF9022950
        public void EvaluateHandedness(){} // RVA: 0x7FFAF9022AD0
        public void DoHandednessCheck(){} // RVA: 0x7FFAF9022C20
        public void ArrowInPosition(){} // RVA: 0x7FFAF9022D00
        public void ReleaseNock(){} // RVA: 0x7FFAF9022DF0
        public void ShutDown(){} // RVA: 0x7FFAF9022E70
        public void OnHandFocusLost(){} // RVA: 0x7FFAF2F6EC00
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAF9023240
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF9023360
        public void OnDestroy(){} // RVA: 0x7FFAF9023400
        public void .ctor(){} // RVA: 0x7FFAF9023410
    }

    public class ModalThrowable
    {
        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x7FFAF8FFE000
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF8FFE0F0
        public void .ctor(){} // RVA: 0x7FFAF8FFE390
    }

    public class PlaySound
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9001160
        public void Play(){} // RVA: 0x7FFAF9001440
        public void PlayWithDelay(){} // RVA: 0x7FFAF90015F0
        public void PlayOneShotSound(){} // RVA: 0x7FFAF9001670
        public void PlayLooping(){} // RVA: 0x7FFAF9001810
        public void Disable(){} // RVA: 0x7FFAF2F6EC00
        public void Stop(){} // RVA: 0x7FFAF9001A20
        public void SetAudioSource(){} // RVA: 0x7FFAF9001A80
        public void .ctor(){} // RVA: 0x7FFAF9001D00
    }

    public class Player
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF8FFE480
        public void get_handCount(){} // RVA: 0x7FFAF8FFE610
        public void GetHand(){} // RVA: 0x7FFAF8FFE750
        public void get_leftHand(){} // RVA: 0x7FFAF8FFE8A0
        public void get_rightHand(){} // RVA: 0x7FFAF8FFEA10
        public void get_scale(){} // RVA: 0x7FFAF8FFEB80
        public void get_hmdTransform(){} // RVA: 0x7FFAF8FFEC40
        public void get_eyeHeight(){} // RVA: 0x7FFAF8FFED80
        public void get_feetPositionGuess(){} // RVA: 0x7FFAF8FFF030
        public void get_bodyDirectionGuess(){} // RVA: 0x7FFAF8FFF390
        public void Awake(){} // RVA: 0x7FFAF8FFF5D0
        public void Start(){} // RVA: 0x7FFAF8FFF870
        public void Update(){} // RVA: 0x7FFAF8FFF910
        public void OnDrawGizmos(){} // RVA: 0x7FFAF8FFFAE0
        public void Draw2DDebug(){} // RVA: 0x7FFAF90006A0
        public void ActivateRig(){} // RVA: 0x7FFAF90008E0
        public void PlayerShotSelf(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF9000E30
    }

    public class RenderModel
    {
        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x7FFAF9001D70
        public void remove_onControllerLoaded(){} // RVA: 0x7FFAF9001E60
        public void Awake(){} // RVA: 0x7FFAF9001F50
        public void InitializeHand(){} // RVA: 0x7FFAF9002050
        public void InitializeController(){} // RVA: 0x7FFAF9002A40
        public void DestroyHand(){} // RVA: 0x7FFAF9003040
        public void OnSkeletonActiveChange(){} // RVA: 0x7FFAF90033D0
        public void OnEnable(){} // RVA: 0x7FFAF90033F0
        public void OnDisable(){} // RVA: 0x7FFAF9003420
        public void OnDestroy(){} // RVA: 0x7FFAF2E41BC0
        public void GetSkeleton(){} // RVA: 0x7FFAF2E0A740
        public void SetInputSource(){} // RVA: 0x7FFAF9003450
        public void OnHandInitialized(){} // RVA: 0x7FFAF9003540
        public void MatchHandToTransform(){} // RVA: 0x7FFAF9003580
        public void SetHandPosition(){} // RVA: 0x7FFAF9003940
        public void SetHandRotation(){} // RVA: 0x7FFAF9003AD0
        public void GetHandPosition(){} // RVA: 0x7FFAF9003C50
        public void GetHandRotation(){} // RVA: 0x7FFAF9003E40
        public void OnRenderModelLoaded(){} // RVA: 0x7FFAF9004010
        public void SetVisibility(){} // RVA: 0x7FFAF90042B0
        public void Show(){} // RVA: 0x7FFAF9004330
        public void Hide(){} // RVA: 0x7FFAF9004380
        public void SetMaterial(){} // RVA: 0x7FFAF90043B0
        public void SetControllerMaterial(){} // RVA: 0x7FFAF9004480
        public void SetHandMaterial(){} // RVA: 0x7FFAF90045C0
        public void SetControllerVisibility(){} // RVA: 0x7FFAF9004680
        public void SetHandVisibility(){} // RVA: 0x7FFAF9004750
        public void IsHandVisibile(){} // RVA: 0x7FFAF9004820
        public void IsControllerVisibile(){} // RVA: 0x7FFAF90048F0
        public void GetBone(){} // RVA: 0x7FFAF90049C0
        public void GetBonePosition(){} // RVA: 0x7FFAF9004AD0
        public void GetControllerPosition(){} // RVA: 0x7FFAF9004C30
        public void GetBoneRotation(){} // RVA: 0x7FFAF9004EB0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFAF9005100
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x7FFAF9005350
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAF9005440
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAF90055A0
        public void SetAnimationState(){} // RVA: 0x7FFAF90056A0
        public void StopAnimation(){} // RVA: 0x7FFAF90057D0
        public void CheckAnimatorInit(){} // RVA: 0x7FFAF90058F0
        public void .ctor(){} // RVA: 0x7FFAF9005CE0
    }

    public class SeeThru
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9005DB0
        public void OnEnable(){} // RVA: 0x7FFAF9006FB0
        public void OnDisable(){} // RVA: 0x7FFAF9007240
        public void AttachedToHand(){} // RVA: 0x7FFAF90074D0
        public void DetachedFromHand(){} // RVA: 0x7FFAF3568C30
        public void Update(){} // RVA: 0x7FFAF9007530
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SleepOnAwake
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF90079A0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SnapTurn
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF90238B0
        public void AllOff(){} // RVA: 0x7FFAF90238C0
        public void Update(){} // RVA: 0x7FFAF9023AC0
        public void RotatePlayer(){} // RVA: 0x7FFAF9024260
        public void DoRotatePlayer(){} // RVA: 0x7FFAF90243B0
        public void ShowRotateFX(){} // RVA: 0x7FFAF9024470
        public void UpdateOrientation(){} // RVA: 0x7FFAF90245E0
        public void .ctor(){} // RVA: 0x7FFAF9024D50
    }

    public class SoundBowClick
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9023720
        public void PlayBowTensionClicks(){} // RVA: 0x7FFAF90237B0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SoundDeparent
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9007AD0
        public void Start(){} // RVA: 0x7FFAF9007B60
        public void .ctor(){} // RVA: 0x7FFAF2DE7060
    }

    public class SoundPlayOneshot
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9007D70
        public void Play(){} // RVA: 0x7FFAF9007E10
        public void Pause(){} // RVA: 0x7FFAF9008010
        public void UnPause(){} // RVA: 0x7FFAF9008130
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SpawnAndAttachAfterControllerIsTracking
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF9008250
        public void Update(){} // RVA: 0x7FFAF90082E0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SpawnAndAttachToHand
    {
        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x7FFAF90085C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Teleport
    {
        // ── Methods ──
        public void ChangeSceneAction(){} // RVA: 0x7FFAF9026350
        public void PlayerAction(){} // RVA: 0x7FFAF9026400
        public void PlayerPreAction(){} // RVA: 0x7FFAF90264C0
        public void get_instance(){} // RVA: 0x7FFAF9026580
        public void Awake(){} // RVA: 0x7FFAF9026750
        public void Start(){} // RVA: 0x7FFAF9026D70
        public void OnEnable(){} // RVA: 0x7FFAF9027190
        public void OnDisable(){} // RVA: 0x7FFAF90271D0
        public void CheckForSpawnPoint(){} // RVA: 0x7FFAF9027210
        public void HideTeleportPointer(){} // RVA: 0x7FFAF90273B0
        public void Update(){} // RVA: 0x7FFAF9027490
        public void UpdatePointer(){} // RVA: 0x7FFAF9027EA0
        public void FixedUpdate(){} // RVA: 0x7FFAF9029B00
        public void OnChaperoneInfoInitialized(){} // RVA: 0x7FFAF902A410
        public void HidePointer(){} // RVA: 0x7FFAF902BBD0
        public void ShowPointer(){} // RVA: 0x7FFAF902C570
        public void UpdateTeleportColors(){} // RVA: 0x7FFAF902D720
        public void PlayAudioClip(){} // RVA: 0x7FFAF902D840
        public void PlayPointerHaptic(){} // RVA: 0x7FFAF902D8F0
        public void TryTeleportPlayer(){} // RVA: 0x7FFAF902DAB0
        public void InitiateTeleportFade(){} // RVA: 0x7FFAF902DBE0
        public void TeleportPlayer(){} // RVA: 0x7FFAF902E030
        public void HighlightSelected(){} // RVA: 0x7FFAF902EDD0
        public void ShowTeleportHint(){} // RVA: 0x7FFAF902F380
        public void CancelTeleportHint(){} // RVA: 0x7FFAF902F4A0
        public void TeleportHintCoroutine(){} // RVA: 0x7FFAF902F600
        public void IsEligibleForTeleport(){} // RVA: 0x7FFAF902F6A0
        public void ShouldOverrideHoverLock(){} // RVA: 0x7FFAF902FAD0
        public void WasTeleportButtonReleased(){} // RVA: 0x7FFAF902FBD0
        public void IsTeleportButtonDown(){} // RVA: 0x7FFAF902FD40
        public void WasTeleportButtonPressed(){} // RVA: 0x7FFAF902FEB0
        public void GetPointerStartTransform(){} // RVA: 0x7FFAF9030020
        public void .ctor(){} // RVA: 0x7FFAF9030180
        public void .cctor(){} // RVA: 0x7FFAF90303C0
    }

    public class TeleportArc
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF9030970
        public void Update(){} // RVA: 0x7FFAF90309D0
        public void CreateLineRendererObjects(){} // RVA: 0x7FFAF9030AE0
        public void SetArcData(){} // RVA: 0x7FFAF90313E0
        public void Show(){} // RVA: 0x7FFAF9031480
        public void Hide(){} // RVA: 0x7FFAF90314A0
        public void DrawArc(){} // RVA: 0x7FFAF90314E0
        public void DrawArcSegment(){} // RVA: 0x7FFAF90318C0
        public void SetColor(){} // RVA: 0x7FFAF9031AB0
        public void FindProjectileCollision(){} // RVA: 0x7FFAF9031C00
        public void GetArcPositionAtTime(){} // RVA: 0x7FFAF9031F50
        public void HideLineSegments(){} // RVA: 0x7FFAF9032120
        public void .ctor(){} // RVA: 0x7FFAF90321E0
    }

    public class TeleportArea
    {
        // ── Methods ──
        public void get_meshBounds(){} // RVA: 0x7FFAF4AFE840
        public void set_meshBounds(){} // RVA: 0x7FFAF4AFE820
        public void Awake(){} // RVA: 0x7FFAF9032260
        public void Start(){} // RVA: 0x7FFAF9032360
        public void ShouldActivate(){} // RVA: 0x7FFAF2E72850
        public void ShouldMovePlayer(){} // RVA: 0x7FFAF2E72850
        public void Highlight(){} // RVA: 0x7FFAF9032530
        public void SetAlpha(){} // RVA: 0x7FFAF9032600
        public void UpdateVisuals(){} // RVA: 0x7FFAF9032730
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFAF9032850
        public void CalculateBounds(){} // RVA: 0x7FFAF9032A40
        public void GetTintColor(){} // RVA: 0x7FFAF9032C80
        public void .ctor(){} // RVA: 0x7FFAF9032CB0
    }

    public class TeleportMarkerBase
    {
        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFAF2E72850
        public void SetLocked(){} // RVA: 0x7FFAF9032D10
        public void TeleportPlayer(){} // RVA: 0x7FFAF2D8D310
        public void UpdateVisuals(){} // RVA: 0x7FFAF2AD4A50
        public void Highlight(){} // RVA: 0x7FFAF2AD5130
        public void SetAlpha(){}
        public void ShouldActivate(){} // RVA: 0x7FFAF2ABDE40
        public void ShouldMovePlayer(){} // RVA: 0x7FFAF2ABDBE0
        public void .ctor(){} // RVA: 0x7FFAF9032D30
    }

    public class TeleportPoint
    {
        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFAF2D8D320
        public void Awake(){} // RVA: 0x7FFAF9032D80
        public void Start(){} // RVA: 0x7FFAF90330A0
        public void Update(){} // RVA: 0x7FFAF9033110
        public void ShouldActivate(){} // RVA: 0x7FFAF9033360
        public void ShouldMovePlayer(){} // RVA: 0x7FFAF2E72850
        public void Highlight(){} // RVA: 0x7FFAF90334F0
        public void UpdateVisuals(){} // RVA: 0x7FFAF90337D0
        public void SetAlpha(){} // RVA: 0x7FFAF9033A10
        public void SetMeshMaterials(){} // RVA: 0x7FFAF9033E50
        public void TeleportToScene(){} // RVA: 0x7FFAF9034020
        public void GetRelevantComponents(){} // RVA: 0x7FFAF9034110
        public void ReleaseRelevantComponents(){} // RVA: 0x7FFAF9034A50
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFAF9034C60
        public void .ctor(){} // RVA: 0x7FFAF9035130
    }

    public class TeleportURPHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Throwable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF9008780
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF9008A10
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF9008BE0
        public void HandHoverUpdate(){} // RVA: 0x7FFAF9008C10
        public void OnAttachedToHand(){} // RVA: 0x7FFAF9008CD0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAF90090A0
        public void GetReleaseVelocities(){} // RVA: 0x7FFAF9009280
        public void HandAttachedUpdate(){} // RVA: 0x7FFAF9009A90
        public void LateDetach(){} // RVA: 0x7FFAF9009BA0
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAF9009CA0
        public void OnHandFocusLost(){} // RVA: 0x7FFAF9009E20
        public void .ctor(){} // RVA: 0x7FFAF8FFE390
    }

    public class UIElement
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF900A110
        public void OnHandHoverBegin(){} // RVA: 0x7FFAF900A260
        public void OnHandHoverEnd(){} // RVA: 0x7FFAF900A500
        public void HandHoverUpdate(){} // RVA: 0x7FFAF900A7C0
        public void OnButtonClick(){} // RVA: 0x7FFAF900A9E0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Unparent
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF900AA30
        public void Update(){} // RVA: 0x7FFAF900ACE0
        public void GetOldParent(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Util
    {
        // ── Methods ──
        public void RemapNumber(){} // RVA: 0x7FFAF900AE10
        public void RemapNumberClamped(){} // RVA: 0x7FFAF900AE30
        public void Approach(){} // RVA: 0x7FFAF900AEA0
        public void BezierInterpolate3(){} // RVA: 0x7FFAF900AED0
        public void BezierInterpolate4(){} // RVA: 0x7FFAF900B060
        public void Vector3FromString(){} // RVA: 0x7FFAF900B310
        public void Vector2FromString(){} // RVA: 0x7FFAF900B430
        public void Normalize(){} // RVA: 0x7FFAF900B520
        public void Vector2AsVector3(){} // RVA: 0x7FFAF2DF53F0
        public void Vector3AsVector2(){} // RVA: 0x7FFAF2DF53D0
        public void AngleOf(){} // RVA: 0x7FFAF900B530
        public void YawOf(){} // RVA: 0x7FFAF900B590
        public void Swap(){} // RVA: 0x7FFAF2AD4D50
        public void Shuffle(){} // RVA: 0x7FFAF2AD4AE0 | overloaded x2
        public void RandomWithLookback(){} // RVA: 0x7FFAF900B5E0
        public void FindChild(){} // RVA: 0x7FFAF900B7C0
        public void IsNullOrEmpty(){} // RVA: 0x7FFAF2ABDCC0
        public void IsValidIndex(){} // RVA: 0x7FFAF2ABFCD0 | overloaded x2
        public void FindOrAdd(){} // RVA: 0x7FFAF2D33FA0
        public void FindAndRemove(){} // RVA: 0x7FFAF2ABCEC0
        public void FindOrAddComponent(){} // RVA: 0x7FFAF2D33FA0
        public void FastRemove(){} // RVA: 0x7FFAF2ADA490
        public void ReplaceGameObject(){} // RVA: 0x7FFAF2D33FA0
        public void SwitchLayerRecursively(){} // RVA: 0x7FFAF900BA70
        public void DrawCross(){} // RVA: 0x7FFAF900BCA0
        public void ResetTransform(){} // RVA: 0x7FFAF900C2F0
        public void ClosestPointOnLine(){} // RVA: 0x7FFAF900C490
        public void AfterTimer(){} // RVA: 0x7FFAF900C750
        public void SendPhysicsMessage(){} // RVA: 0x7FFAF900CB20 | overloaded x2
        public void IgnoreCollisions(){} // RVA: 0x7FFAF900CE10
        public void WrapCoroutine(){} // RVA: 0x7FFAF900CFB0
        public void ColorWithAlpha(){} // RVA: 0x7FFAF34E8E70
        public void Quit(){} // RVA: 0x7FFAF900D0B0
        public void FloatToDecimal(){} // RVA: 0x7FFAF900D0E0
        public void Median(){} // RVA: 0x7FFAF2D33FA0
        public void ForEach(){} // RVA: 0x7FFAF2AD4D50
        public void FixupNewlines(){} // RVA: 0x7FFAF900D200
        public void PathLength(){} // RVA: 0x7FFAF900D2C0
        public void HasCommandLineArgument(){} // RVA: 0x7FFAF900D4A0
        public void GetCommandLineArgValue(){} // RVA: 0x7FFAF900D620 | overloaded x2
        public void SetActive(){} // RVA: 0x7FFAF900D700
        public void CombinePaths(){} // RVA: 0x7FFAF900D810
    }

    public class VelocityEstimator
    {
        // ── Methods ──
        public void BeginEstimatingVelocity(){} // RVA: 0x7FFAF900DD30
        public void FinishEstimatingVelocity(){} // RVA: 0x7FFAF900DE50
        public void GetVelocityEstimate(){} // RVA: 0x7FFAF900DED0
        public void GetAngularVelocityEstimate(){} // RVA: 0x7FFAF900E000
        public void GetAccelerationEstimate(){} // RVA: 0x7FFAF900E130
        public void Awake(){} // RVA: 0x7FFAF900E310
        public void EstimateVelocityCoroutine(){} // RVA: 0x7FFAF900E430
        public void .ctor(){} // RVA: 0x7FFAF900E4D0
    }

}