// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 75
// Methods: 667

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AfterTimer_Component
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x655DA30
        public void Wait(){} // RVA: 0x655DAB0
        public void OnDestroy(){} // RVA: 0x655DB50
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class AllowTeleportWhileAttachedToHand
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64FF8C0
    }

    public class ArcheryTarget
    {
        // ── Methods ──
        public void ApplyDamage(){} // RVA: 0x6567180
        public void FireExposure(){} // RVA: 0x6567180
        public void OnDamageTaken(){} // RVA: 0x6567190
        public void FallDown(){} // RVA: 0x6567270
        public void .ctor(){} // RVA: 0x6567310
    }

    public class Arrow
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6567740
        public void Start(){} // RVA: 0x65679D0
        public void FixedUpdate(){} // RVA: 0x6567A70
        public void StartRelease(){} // RVA: 0x6567D50
        public void ArrowReleased(){} // RVA: 0x65681E0
        public void SetCollisionMode(){} // RVA: 0x6568D30
        public void OnCollisionEnter(){} // RVA: 0x6568E70
        public void StickInTarget(){} // RVA: 0x6569DD0
        public void OnDestroy(){} // RVA: 0x656B000
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ArrowHand
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x656B2B0
        public void OnAttachedToHand(){} // RVA: 0x656B410
        public void InstantiateArrow(){} // RVA: 0x656B470
        public void HandAttachedUpdate(){} // RVA: 0x656B850
        public void OnDetachedFromHand(){} // RVA: 0x656C900
        public void FireArrow(){} // RVA: 0x656C9A0
        public void EnableArrowSpawn(){} // RVA: 0x490010
        public void ArrowReleaseHaptics(){} // RVA: 0x656D400
        public void OnHandFocusLost(){} // RVA: 0x4BEC00
        public void OnHandFocusAcquired(){} // RVA: 0x4BF550
        public void FindBow(){} // RVA: 0x656D4A0
        public void .ctor(){} // RVA: 0x656D540
    }

    public class ArrowheadRotation
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x656D7F0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Balloon
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x656D8E0
        public void Update(){} // RVA: 0x656DAA0
        public void SpawnParticles(){} // RVA: 0x656DBB0
        public void FixedUpdate(){} // RVA: 0x656E060
        public void ApplyDamage(){} // RVA: 0x656E1F0
        public void OnCollisionEnter(){} // RVA: 0x656E2A0
        public void SetColor(){} // RVA: 0x656E8F0
        public void BalloonColorToRGB(){} // RVA: 0x656E9D0
        public void .ctor(){} // RVA: 0x656EBE0
    }

    public class BalloonColliders
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x656EC40
        public void OnEnable(){} // RVA: 0x656F1F0
        public void OnDisable(){} // RVA: 0x656F840
        public void OnDestroy(){} // RVA: 0x656FA00
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BalloonHapticBump
    {
        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x656FB30
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BalloonSpawner
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x656FD70
        public void Update(){} // RVA: 0x656FE90
        public void SpawnBalloon(){} // RVA: 0x656FFF0
        public void SpawnBalloonFromEvent(){} // RVA: 0x6570950
        public void .ctor(){} // RVA: 0x6570960
    }

    public class BodyCollider
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6524500
        public void FixedUpdate(){} // RVA: 0x6524590
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ChaperoneInfo
    {
        // ── Methods ──
        public void get_initialized(){} // RVA: 0x3CB9D0
        public void set_initialized(){} // RVA: 0x3CB9E0
        public void get_playAreaSizeX(){} // RVA: 0x44AF50
        public void set_playAreaSizeX(){} // RVA: 0x44AF60
        public void get_playAreaSizeZ(){} // RVA: 0x3BC210
        public void set_playAreaSizeZ(){} // RVA: 0x3BC220
        public void get_roomscale(){} // RVA: 0x3BC230
        public void set_roomscale(){} // RVA: 0x3BC240
        public void InitializedAction(){} // RVA: 0x6575950
        public void get_instance(){} // RVA: 0x65759F0
        public void Start(){} // RVA: 0x6575D40
        public void .ctor(){} // RVA: 0x2DDD50
        public void .cctor(){} // RVA: 0x6575DE0
    }

    public class CircularDrive
    {
        // ── Methods ──
        public void Freeze(){} // RVA: 0x65248C0
        public void UnFreeze(){} // RVA: 0x6524990
        public void Awake(){} // RVA: 0x65249B0
        public void Start(){} // RVA: 0x6524A50
        public void OnDisable(){} // RVA: 0x6525670
        public void HapticPulses(){} // RVA: 0x65257E0
        public void OnHandHoverBegin(){} // RVA: 0x65258A0
        public void OnHandHoverEnd(){} // RVA: 0x65258C0
        public void HandHoverUpdate(){} // RVA: 0x6525A40
        public void ComputeToTransformProjected(){} // RVA: 0x6525D10
        public void DrawDebugPath(){} // RVA: 0x6526180
        public void UpdateLinearMapping(){} // RVA: 0x65270C0
        public void UpdateGameObject(){} // RVA: 0x6527150
        public void UpdateDebugText(){} // RVA: 0x6527410
        public void UpdateAll(){} // RVA: 0x6527610
        public void ComputeAngle(){} // RVA: 0x65276B0
        public void .ctor(){} // RVA: 0x6527BA0
    }

    public class ComplexThrowable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6527F40
        public void Update(){} // RVA: 0x6527FC0
        public void OnHandHoverBegin(){} // RVA: 0x6528100
        public void OnHandHoverEnd(){} // RVA: 0x65281E0
        public void HandHoverUpdate(){} // RVA: 0x65282C0
        public void PhysicsAttach(){} // RVA: 0x6528310
        public void PhysicsDetach(){} // RVA: 0x6528DF0
        public void FixedUpdate(){} // RVA: 0x6529100
        public void .ctor(){} // RVA: 0x6529680
    }

    public class ControllerButtonHints
    {
        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0x30B0C0
        public void get_initialized(){} // RVA: 0x632C3D0
        public void set_initialized(){} // RVA: 0x632C3E0
        public void Awake(){} // RVA: 0x655EE60
        public void Start(){} // RVA: 0x655EFB0
        public void HintDebugLog(){} // RVA: 0x655F020
        public void OnEnable(){} // RVA: 0x655F0B0
        public void OnDisable(){} // RVA: 0x655F0E0
        public void OnParentHandInputFocusLost(){} // RVA: 0x655F120
        public void SetInputSource(){} // RVA: 0x655F140
        public void OnHandInitialized(){} // RVA: 0x655F230
        public void OnRenderModelLoaded(){} // RVA: 0x655F770
        public void DoInitialize(){} // RVA: 0x655FA90
        public void CreateAndAddButtonInfo(){} // RVA: 0x655FB90
        public void ComputeTextEndTransforms(){} // RVA: 0x6561D30
        public void ShowButtonHint(){} // RVA: 0x6565170 | overloaded x2
        public void HideAllButtonHints(){} // RVA: 0x6565350 | overloaded x2
        public void HideButtonHint(){} // RVA: 0x6565260 | overloaded x2
        public void IsButtonHintActive(){} // RVA: 0x6565430 | overloaded x2
        public void TestButtonHints(){} // RVA: 0x65637F0
        public void TestTextHints(){} // RVA: 0x6563890
        public void Update(){} // RVA: 0x6563930
        public void UpdateTextHint(){} // RVA: 0x6563FE0
        public void Clear(){} // RVA: 0x65646D0
        public void ShowText(){} // RVA: 0x6564760
        public void HideText(){} // RVA: 0x6564B20
        public void HideAllText(){} // RVA: 0x6564CB0
        public void GetActiveHintText(){} // RVA: 0x6565AE0 | overloaded x2
        public void GetControllerButtonHints(){} // RVA: 0x6564FE0
        public void ShowTextHint(){} // RVA: 0x6565520
        public void HideTextHint(){} // RVA: 0x65656F0
        public void HideAllTextHints(){} // RVA: 0x6565A00
        public void .ctor(){} // RVA: 0x6565CD0
    }

    public class ControllerHoverHighlight
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6529930
        public void OnHandInitialized(){} // RVA: 0x65299C0
        public void RenderModel_onControllerLoaded(){} // RVA: 0x652A130
        public void OnParentHandHoverBegin(){} // RVA: 0x652A170
        public void OnParentHandHoverEnd(){} // RVA: 0x652A420
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x652A430
        public void OnParentHandInputFocusLost(){} // RVA: 0x652A420
        public void ShowHighlight(){} // RVA: 0x652A7A0
        public void HideHighlight(){} // RVA: 0x652A910
        public void .ctor(){} // RVA: 0x314BB0
    }

    public class CustomEvents
    {
    }

    public class DebugUI
    {
        public object responseCode;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x652AB30
        public void Start(){} // RVA: 0x652ACC0
        public void OnGUI(){} // RVA: 0x652AD30
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DestroyOnDetachedFromHand
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x652ADE0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DestroyOnParticleSystemDeath
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x652AE80
        public void CheckParticleSystem(){} // RVA: 0x652AF40
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DestroyOnTriggerEnter
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x652B040
        public void OnTriggerEnter(){} // RVA: 0x652B060
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DistanceHaptics
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x652B300
        public void .ctor(){} // RVA: 0x652B3A0
    }

    public class DontDestroyOnLoad
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x652B8D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class EnumFlags
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Equippable
    {
        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x652B960
        public void Start(){} // RVA: 0x652BA70
        public void Update(){} // RVA: 0x652BBC0
        public void .ctor(){} // RVA: 0x652BF80
    }

    public class ExplosionWobble
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x65709D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class FallbackCameraController
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x652BFD0
        public void Update(){} // RVA: 0x652C030
        public void OnGUI(){} // RVA: 0x652CA00
        public void .ctor(){} // RVA: 0x652CA80
    }

    public class FireSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6570B40
        public void Update(){} // RVA: 0x6570B50
        public void OnTriggerEnter(){} // RVA: 0x6570CE0
        public void FireExposure(){} // RVA: 0x6570D90
        public void StartBurning(){} // RVA: 0x6570FE0
        public void .ctor(){} // RVA: 0x14F24E0
    }

    public class Hand
    {
        // ── Methods ──
        public void get_AttachedObjects(){} // RVA: 0x652CAE0
        public void get_hoverLocked(){} // RVA: 0x408F80
        public void set_hoverLocked(){} // RVA: 0x408F90
        public void get_isActive(){} // RVA: 0x652CBB0
        public void get_isPoseValid(){} // RVA: 0x652CD70
        public void get_hoveringInteractable(){} // RVA: 0x35E970
        public void set_hoveringInteractable(){} // RVA: 0x652CDC0
        public void get_currentAttachedObject(){} // RVA: 0x652D360
        public void get_currentAttachedObjectInfo(){} // RVA: 0x652D410
        public void get_currentAttachedTeleportManager(){} // RVA: 0x652D660
        public void get_skeleton(){} // RVA: 0x652D700
        public void ShowController(){} // RVA: 0x652D7F0
        public void HideController(){} // RVA: 0x652D9A0
        public void ShowSkeleton(){} // RVA: 0x652DB50
        public void HideSkeleton(){} // RVA: 0x652DD00
        public void HasSkeleton(){} // RVA: 0x652DEB0
        public void Show(){} // RVA: 0x652E040
        public void Hide(){} // RVA: 0x652E050
        public void SetVisibility(){} // RVA: 0x652E060
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x652E160
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x652E240
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x652E470
        public void SetAnimationState(){} // RVA: 0x652E630
        public void StopAnimation(){} // RVA: 0x652E830
        public void AttachObject(){} // RVA: 0x652EA30
        public void ObjectIsAttached(){} // RVA: 0x6531C20
        public void ForceHoverUnlock(){} // RVA: 0x86A5B0
        public void DetachObject(){} // RVA: 0x6531E10
        public void GetTrackedObjectVelocity(){} // RVA: 0x6533570
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x65339B0
        public void GetEstimatedPeakVelocities(){} // RVA: 0x6533DF0
        public void CleanUpAttachedObjectStack(){} // RVA: 0x6533F60
        public void Awake(){} // RVA: 0x65340E0
        public void OnDestroy(){} // RVA: 0x6534960
        public void OnTransformUpdated(){} // RVA: 0x1854D10
        public void Start(){} // RVA: 0x6534B40
        public void UpdateHovering(){} // RVA: 0x6534BE0
        public void CheckHoveringForTransform(){} // RVA: 0x65351A0
        public void UpdateNoSteamVRFallback(){} // RVA: 0x6535E00
        public void UpdateDebugText(){} // RVA: 0x6536590
        public void OnEnable(){} // RVA: 0x6537190
        public void OnDisable(){} // RVA: 0x6537320
        public void Update(){} // RVA: 0x65373A0
        public void IsStillHovering(){} // RVA: 0x6537590
        public void HandFollowUpdate(){} // RVA: 0x65376D0
        public void FixedUpdate(){} // RVA: 0x6538DE0
        public void UpdateAttachedVelocity(){} // RVA: 0x6539730
        public void ResetAttachedTransform(){} // RVA: 0x6539AF0
        public void TargetItemPosition(){} // RVA: 0x6539D60
        public void TargetItemRotation(){} // RVA: 0x653A200
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x653AAB0
        public void OnInputFocus(){} // RVA: 0x653B280
        public void OnDrawGizmos(){} // RVA: 0x653B420
        public void HandDebugLog(){} // RVA: 0x653BB00
        public void HoverLock(){} // RVA: 0x653BBC0
        public void HoverUnlock(){} // RVA: 0x653BC70
        public void TriggerHapticPulse(){} // RVA: 0x653BE60 | overloaded x2
        public void ShowGrabHint(){} // RVA: 0x653BFB0 | overloaded x2
        public void HideGrabHint(){} // RVA: 0x653BFA0
        public void GetGrabStarting(){} // RVA: 0x653BFE0
        public void GetGrabEnding(){} // RVA: 0x653C3E0
        public void IsGrabEnding(){} // RVA: 0x653C6B0
        public void IsGrabbingWithType(){} // RVA: 0x653C930
        public void IsGrabbingWithOppositeType(){} // RVA: 0x653CAC0
        public void GetBestGrabbingType(){} // RVA: 0x653CC60 | overloaded x2
        public void InitController(){} // RVA: 0x653CE30
        public void SetRenderModel(){} // RVA: 0x653DB10
        public void SetHoverRenderModel(){} // RVA: 0x653DC80
        public void GetDeviceIndex(){} // RVA: 0x653DD30
        public void .ctor(){} // RVA: 0x653DD80
    }

    public class HandCollider
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x653EA50
        public void Start(){} // RVA: 0x653EB30
        public void SetPhysicMaterial(){} // RVA: 0x653F360
        public void SetCollisionDetectionEnabled(){} // RVA: 0x653F4C0
        public void MoveTo(){} // RVA: 0x653F530
        public void TeleportTo(){} // RVA: 0x653F550
        public void Reset(){} // RVA: 0x653F800
        public void SetCenterPoint(){} // RVA: 0x653F840
        public void ExecuteFixedUpdate(){} // RVA: 0x653F850
        public void GetTargetVelocities(){} // RVA: 0x653FD60
        public void OnCollisionEnter(){} // RVA: 0x6540290
        public void .ctor(){} // RVA: 0x65405C0
    }

    public class HandEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x653EA10
    }

    public class HandPhysics
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6540950
        public void FixedUpdate(){} // RVA: 0x6541020
        public void UpdateCenterPoint(){} // RVA: 0x65412A0
        public void UpdatePositions(){} // RVA: 0x6541560
        public void UpdateFingertips(){} // RVA: 0x6542690
        public void UpdateHand(){} // RVA: 0x6542B60
        public void ProcessPos(){} // RVA: 0x6543170
        public void ProcessRot(){} // RVA: 0x65432F0
        public void .ctor(){} // RVA: 0x65433B0
    }

    public class HapticRack
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6543510
        public void OnHandHoverBegin(){} // RVA: 0x305200
        public void OnHandHoverEnd(){} // RVA: 0x5A5F950
        public void Update(){} // RVA: 0x6543650
        public void Pulse(){} // RVA: 0x65437D0
        public void .ctor(){} // RVA: 0x6543910
    }

    public class HideOnHandFocusLost
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0x4BEC00
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class HoverButton
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6543970
        public void HandHoverUpdate(){} // RVA: 0x6543C40
        public void LateUpdate(){} // RVA: 0x6544340
        public void InvokeEvents(){} // RVA: 0x6544470
        public void .ctor(){} // RVA: 0x6544550
    }

    public class IgnoreHovering
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class IgnoreTeleportTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class InputModule
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x65445C0
        public void ShouldActivateModule(){} // RVA: 0x6544750
        public void HoverBegin(){} // RVA: 0x6544830
        public void HoverEnd(){} // RVA: 0x6544930
        public void Submit(){} // RVA: 0x3A5510
        public void Process(){} // RVA: 0x6544A50
        public void .ctor(){} // RVA: 0x6544C20
    }

    public class Interactable
    {
        // ── Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x6544C30
        public void remove_onAttachedToHand(){} // RVA: 0x6544D20
        public void add_onDetachedFromHand(){} // RVA: 0x6544E10
        public void remove_onDetachedFromHand(){} // RVA: 0x6544F00
        public void get_hoveringHand(){} // RVA: 0x6544FF0
        public void get_isDestroying(){} // RVA: 0x173F990
        public void set_isDestroying(){} // RVA: 0x173EC00
        public void get_isHovering(){} // RVA: 0x38EED40
        public void set_isHovering(){} // RVA: 0x38EED50
        public void get_wasHovering(){} // RVA: 0x6545080
        public void set_wasHovering(){} // RVA: 0x6545090
        public void Awake(){} // RVA: 0x65450A0
        public void Start(){} // RVA: 0x6545130
        public void ShouldIgnoreHighlight(){} // RVA: 0x6545510
        public void ShouldIgnore(){} // RVA: 0x6545590
        public void CreateHighlightRenderers(){} // RVA: 0x6545720
        public void UpdateHighlightRenderers(){} // RVA: 0x6546070
        public void OnHandHoverBegin(){} // RVA: 0x6546D20
        public void OnHandHoverEnd(){} // RVA: 0x6546DD0
        public void Update(){} // RVA: 0x6546F50
        public void OnAttachedToHand(){} // RVA: 0x6547080
        public void OnDetachedFromHand(){} // RVA: 0x6547440
        public void OnDestroy(){} // RVA: 0x6547960
        public void OnDisable(){} // RVA: 0x6547BA0
        public void .ctor(){} // RVA: 0x6547D50
    }

    public class InteractableDebug
    {
        // ── Methods ──
        public void get_isThrowable(){} // RVA: 0x6547F70
        public void Awake(){} // RVA: 0x6548040
        public void OnAttachedToHand(){} // RVA: 0x6548270
        public void HandAttachedUpdate(){} // RVA: 0x65482F0
        public void OnDetachedFromHand(){} // RVA: 0x6548450
        public void GetColliders(){} // RVA: 0x35A740
        public void IgnoreObject(){} // RVA: 0x6548A20
        public void SetIsSimulation(){} // RVA: 0x4EFF5C0
        public void CreateSimulation(){} // RVA: 0x6548B30
        public void CreateMarker(){} // RVA: 0x6548F20 | overloaded x2
        public void ColorSelf(){} // RVA: 0x65496D0
        public void ColorThing(){} // RVA: 0x65497A0
        public void .ctor(){} // RVA: 0x6549870
    }

    public class InteractableHoverEvents
    {
        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x65498C0
        public void OnHandHoverEnd(){} // RVA: 0x65498E0
        public void OnAttachedToHand(){} // RVA: 0x6549900
        public void OnDetachedFromHand(){} // RVA: 0x6549920
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ItemPackage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ItemPackageReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ItemPackageSpawner
    {
        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0x30B0C0
        public void set_itemPackage(){} // RVA: 0x6549940
        public void CreatePreviewObject(){} // RVA: 0x6549950
        public void Start(){} // RVA: 0x6549F60
        public void VerifyItemPackage(){} // RVA: 0x6549F60
        public void ItemPackageNotValid(){} // RVA: 0x654A0F0
        public void ClearPreview(){} // RVA: 0x654A260
        public void Update(){} // RVA: 0x654A5B0
        public void OnHandHoverBegin(){} // RVA: 0x654A6B0
        public void TakeBackItem(){} // RVA: 0x654A890
        public void GetAttachedItemPackage(){} // RVA: 0x654A8F0
        public void HandHoverUpdate(){} // RVA: 0x654AAB0
        public void OnHandHoverEnd(){} // RVA: 0x654ACB0
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x654AD00
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x654B130
        public void SpawnAndAttachObject(){} // RVA: 0x654B3A0
        public void .ctor(){} // RVA: 0x654B9D0
    }

    public class LinearAnimation
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x654BA20
        public void Update(){} // RVA: 0x654BED0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class LinearAnimator
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x654BF30
        public void Update(){} // RVA: 0x654C1E0
        public void .ctor(){} // RVA: 0x654C2C0
    }

    public class LinearAudioPitch
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x654C310
        public void Update(){} // RVA: 0x654C560
        public void Apply(){} // RVA: 0x654C680
        public void .ctor(){} // RVA: 0x17E65B0
    }

    public class LinearBlendshape
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x654C790
        public void Update(){} // RVA: 0x654C9E0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class LinearDisplacement
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x654CAC0
        public void Update(){} // RVA: 0x654CCB0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class LinearDrive
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x654CE90
        public void Start(){} // RVA: 0x654CFB0
        public void HandHoverUpdate(){} // RVA: 0x654D2C0
        public void HandAttachedUpdate(){} // RVA: 0x654D4C0
        public void OnDetachedFromHand(){} // RVA: 0x654D5F0
        public void CalculateMappingChangeRate(){} // RVA: 0x654D5F0
        public void UpdateLinearMapping(){} // RVA: 0x654D670
        public void CalculateLinearMapping(){} // RVA: 0x654D980
        public void Update(){} // RVA: 0x654DC80
        public void .ctor(){} // RVA: 0x654DFA0
    }

    public class LinearMapping
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Longbow
    {
        // ── Methods ──
        public void OnAttachedToHand(){} // RVA: 0x305200
        public void HandAttachedUpdate(){} // RVA: 0x6571580
        public void ArrowReleased(){} // RVA: 0x6572650
        public void ResetDrawAnim(){} // RVA: 0x65727D0
        public void GetArrowVelocity(){} // RVA: 0x59D580
        public void StartRotationLerp(){} // RVA: 0x6572870
        public void StartNock(){} // RVA: 0x6572950
        public void EvaluateHandedness(){} // RVA: 0x6572AD0
        public void DoHandednessCheck(){} // RVA: 0x6572C20
        public void ArrowInPosition(){} // RVA: 0x6572D00
        public void ReleaseNock(){} // RVA: 0x6572DF0
        public void ShutDown(){} // RVA: 0x6572E70
        public void OnHandFocusLost(){} // RVA: 0x4BEC00
        public void OnHandFocusAcquired(){} // RVA: 0x6573240
        public void OnDetachedFromHand(){} // RVA: 0x6573360
        public void OnDestroy(){} // RVA: 0x6573400
        public void .ctor(){} // RVA: 0x6573410
    }

    public class ModalThrowable
    {
        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x654E000
        public void HandAttachedUpdate(){} // RVA: 0x654E0F0
        public void .ctor(){} // RVA: 0x654E390
    }

    public class PlaySound
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6551160
        public void Play(){} // RVA: 0x6551440
        public void PlayWithDelay(){} // RVA: 0x65515F0
        public void PlayOneShotSound(){} // RVA: 0x6551670
        public void PlayLooping(){} // RVA: 0x6551810
        public void Disable(){} // RVA: 0x4BEC00
        public void Stop(){} // RVA: 0x6551A20
        public void SetAudioSource(){} // RVA: 0x6551A80
        public void .ctor(){} // RVA: 0x6551D00
    }

    public class Player
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x654E480
        public void get_handCount(){} // RVA: 0x654E610
        public void GetHand(){} // RVA: 0x654E750
        public void get_leftHand(){} // RVA: 0x654E8A0
        public void get_rightHand(){} // RVA: 0x654EA10
        public void get_scale(){} // RVA: 0x654EB80
        public void get_hmdTransform(){} // RVA: 0x654EC40
        public void get_eyeHeight(){} // RVA: 0x654ED80
        public void get_feetPositionGuess(){} // RVA: 0x654F030
        public void get_bodyDirectionGuess(){} // RVA: 0x654F390
        public void Awake(){} // RVA: 0x654F5D0
        public void Start(){} // RVA: 0x654F870
        public void Update(){} // RVA: 0x654F910
        public void OnDrawGizmos(){} // RVA: 0x654FAE0
        public void Draw2DDebug(){} // RVA: 0x65506A0
        public void ActivateRig(){} // RVA: 0x65508E0
        public void PlayerShotSelf(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6550E30
    }

    public class RenderModel
    {
        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x6551D70
        public void remove_onControllerLoaded(){} // RVA: 0x6551E60
        public void Awake(){} // RVA: 0x6551F50
        public void InitializeHand(){} // RVA: 0x6552050
        public void InitializeController(){} // RVA: 0x6552A40
        public void DestroyHand(){} // RVA: 0x6553040
        public void OnSkeletonActiveChange(){} // RVA: 0x65533D0
        public void OnEnable(){} // RVA: 0x65533F0
        public void OnDisable(){} // RVA: 0x6553420
        public void OnDestroy(){} // RVA: 0x391BC0
        public void GetSkeleton(){} // RVA: 0x35A740
        public void SetInputSource(){} // RVA: 0x6553450
        public void OnHandInitialized(){} // RVA: 0x6553540
        public void MatchHandToTransform(){} // RVA: 0x6553580
        public void SetHandPosition(){} // RVA: 0x6553940
        public void SetHandRotation(){} // RVA: 0x6553AD0
        public void GetHandPosition(){} // RVA: 0x6553C50
        public void GetHandRotation(){} // RVA: 0x6553E40
        public void OnRenderModelLoaded(){} // RVA: 0x6554010
        public void SetVisibility(){} // RVA: 0x65542B0
        public void Show(){} // RVA: 0x6554330
        public void Hide(){} // RVA: 0x6554380
        public void SetMaterial(){} // RVA: 0x65543B0
        public void SetControllerMaterial(){} // RVA: 0x6554480
        public void SetHandMaterial(){} // RVA: 0x65545C0
        public void SetControllerVisibility(){} // RVA: 0x6554680
        public void SetHandVisibility(){} // RVA: 0x6554750
        public void IsHandVisibile(){} // RVA: 0x6554820
        public void IsControllerVisibile(){} // RVA: 0x65548F0
        public void GetBone(){} // RVA: 0x65549C0
        public void GetBonePosition(){} // RVA: 0x6554AD0
        public void GetControllerPosition(){} // RVA: 0x6554C30
        public void GetBoneRotation(){} // RVA: 0x6554EB0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x6555100
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x6555350
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x6555440
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x65555A0
        public void SetAnimationState(){} // RVA: 0x65556A0
        public void StopAnimation(){} // RVA: 0x65557D0
        public void CheckAnimatorInit(){} // RVA: 0x65558F0
        public void .ctor(){} // RVA: 0x6555CE0
    }

    public class SeeThru
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6555DB0
        public void OnEnable(){} // RVA: 0x6556FB0
        public void OnDisable(){} // RVA: 0x6557240
        public void AttachedToHand(){} // RVA: 0x65574D0
        public void DetachedFromHand(){} // RVA: 0xAB8C30
        public void Update(){} // RVA: 0x6557530
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SleepOnAwake
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x65579A0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SnapTurn
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x65738B0
        public void AllOff(){} // RVA: 0x65738C0
        public void Update(){} // RVA: 0x6573AC0
        public void RotatePlayer(){} // RVA: 0x6574260
        public void DoRotatePlayer(){} // RVA: 0x65743B0
        public void ShowRotateFX(){} // RVA: 0x6574470
        public void UpdateOrientation(){} // RVA: 0x65745E0
        public void .ctor(){} // RVA: 0x6574D50
    }

    public class SoundBowClick
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6573720
        public void PlayBowTensionClicks(){} // RVA: 0x65737B0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SoundDeparent
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6557AD0
        public void Start(){} // RVA: 0x6557B60
        public void .ctor(){} // RVA: 0x337060
    }

    public class SoundPlayOneshot
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6557D70
        public void Play(){} // RVA: 0x6557E10
        public void Pause(){} // RVA: 0x6558010
        public void UnPause(){} // RVA: 0x6558130
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SpawnAndAttachAfterControllerIsTracking
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6558250
        public void Update(){} // RVA: 0x65582E0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SpawnAndAttachToHand
    {
        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x65585C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Teleport
    {
        // ── Methods ──
        public void ChangeSceneAction(){} // RVA: 0x6576350
        public void PlayerAction(){} // RVA: 0x6576400
        public void PlayerPreAction(){} // RVA: 0x65764C0
        public void get_instance(){} // RVA: 0x6576580
        public void Awake(){} // RVA: 0x6576750
        public void Start(){} // RVA: 0x6576D70
        public void OnEnable(){} // RVA: 0x6577190
        public void OnDisable(){} // RVA: 0x65771D0
        public void CheckForSpawnPoint(){} // RVA: 0x6577210
        public void HideTeleportPointer(){} // RVA: 0x65773B0
        public void Update(){} // RVA: 0x6577490
        public void UpdatePointer(){} // RVA: 0x6577EA0
        public void FixedUpdate(){} // RVA: 0x6579B00
        public void OnChaperoneInfoInitialized(){} // RVA: 0x657A410
        public void HidePointer(){} // RVA: 0x657BBD0
        public void ShowPointer(){} // RVA: 0x657C570
        public void UpdateTeleportColors(){} // RVA: 0x657D720
        public void PlayAudioClip(){} // RVA: 0x657D840
        public void PlayPointerHaptic(){} // RVA: 0x657D8F0
        public void TryTeleportPlayer(){} // RVA: 0x657DAB0
        public void InitiateTeleportFade(){} // RVA: 0x657DBE0
        public void TeleportPlayer(){} // RVA: 0x657E030
        public void HighlightSelected(){} // RVA: 0x657EDD0
        public void ShowTeleportHint(){} // RVA: 0x657F380
        public void CancelTeleportHint(){} // RVA: 0x657F4A0
        public void TeleportHintCoroutine(){} // RVA: 0x657F600
        public void IsEligibleForTeleport(){} // RVA: 0x657F6A0
        public void ShouldOverrideHoverLock(){} // RVA: 0x657FAD0
        public void WasTeleportButtonReleased(){} // RVA: 0x657FBD0
        public void IsTeleportButtonDown(){} // RVA: 0x657FD40
        public void WasTeleportButtonPressed(){} // RVA: 0x657FEB0
        public void GetPointerStartTransform(){} // RVA: 0x6580020
        public void .ctor(){} // RVA: 0x6580180
        public void .cctor(){} // RVA: 0x65803C0
    }

    public class TeleportArc
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6580970
        public void Update(){} // RVA: 0x65809D0
        public void CreateLineRendererObjects(){} // RVA: 0x6580AE0
        public void SetArcData(){} // RVA: 0x65813E0
        public void Show(){} // RVA: 0x6581480
        public void Hide(){} // RVA: 0x65814A0
        public void DrawArc(){} // RVA: 0x65814E0
        public void DrawArcSegment(){} // RVA: 0x65818C0
        public void SetColor(){} // RVA: 0x6581AB0
        public void FindProjectileCollision(){} // RVA: 0x6581C00
        public void GetArcPositionAtTime(){} // RVA: 0x6581F50
        public void HideLineSegments(){} // RVA: 0x6582120
        public void .ctor(){} // RVA: 0x65821E0
    }

    public class TeleportArea
    {
        // ── Methods ──
        public void get_meshBounds(){} // RVA: 0x204E840
        public void set_meshBounds(){} // RVA: 0x204E820
        public void Awake(){} // RVA: 0x6582260
        public void Start(){} // RVA: 0x6582360
        public void ShouldActivate(){} // RVA: 0x3C2850
        public void ShouldMovePlayer(){} // RVA: 0x3C2850
        public void Highlight(){} // RVA: 0x6582530
        public void SetAlpha(){} // RVA: 0x6582600
        public void UpdateVisuals(){} // RVA: 0x6582730
        public void UpdateVisualsInEditor(){} // RVA: 0x6582850
        public void CalculateBounds(){} // RVA: 0x6582A40
        public void GetTintColor(){} // RVA: 0x6582C80
        public void .ctor(){} // RVA: 0x6582CB0
    }

    public class TeleportMarkerBase
    {
        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x3C2850
        public void SetLocked(){} // RVA: 0x6582D10
        public void TeleportPlayer(){} // RVA: 0x2DD310
        public void UpdateVisuals(){} // RVA: 0x24A50
        public void Highlight(){} // RVA: 0x25130
        public void SetAlpha(){}
        public void ShouldActivate(){} // RVA: 0xDE40
        public void ShouldMovePlayer(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x6582D30
    }

    public class TeleportPoint
    {
        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x2DD320
        public void Awake(){} // RVA: 0x6582D80
        public void Start(){} // RVA: 0x65830A0
        public void Update(){} // RVA: 0x6583110
        public void ShouldActivate(){} // RVA: 0x6583360
        public void ShouldMovePlayer(){} // RVA: 0x3C2850
        public void Highlight(){} // RVA: 0x65834F0
        public void UpdateVisuals(){} // RVA: 0x65837D0
        public void SetAlpha(){} // RVA: 0x6583A10
        public void SetMeshMaterials(){} // RVA: 0x6583E50
        public void TeleportToScene(){} // RVA: 0x6584020
        public void GetRelevantComponents(){} // RVA: 0x6584110
        public void ReleaseRelevantComponents(){} // RVA: 0x6584A50
        public void UpdateVisualsInEditor(){} // RVA: 0x6584C60
        public void .ctor(){} // RVA: 0x6585130
    }

    public class TeleportURPHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Throwable
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6558780
        public void OnHandHoverBegin(){} // RVA: 0x6558A10
        public void OnHandHoverEnd(){} // RVA: 0x6558BE0
        public void HandHoverUpdate(){} // RVA: 0x6558C10
        public void OnAttachedToHand(){} // RVA: 0x6558CD0
        public void OnDetachedFromHand(){} // RVA: 0x65590A0
        public void GetReleaseVelocities(){} // RVA: 0x6559280
        public void HandAttachedUpdate(){} // RVA: 0x6559A90
        public void LateDetach(){} // RVA: 0x6559BA0
        public void OnHandFocusAcquired(){} // RVA: 0x6559CA0
        public void OnHandFocusLost(){} // RVA: 0x6559E20
        public void .ctor(){} // RVA: 0x654E390
    }

    public class UIElement
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x655A110
        public void OnHandHoverBegin(){} // RVA: 0x655A260
        public void OnHandHoverEnd(){} // RVA: 0x655A500
        public void HandHoverUpdate(){} // RVA: 0x655A7C0
        public void OnButtonClick(){} // RVA: 0x655A9E0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Unparent
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x655AA30
        public void Update(){} // RVA: 0x655ACE0
        public void GetOldParent(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Util
    {
        // ── Methods ──
        public void RemapNumber(){} // RVA: 0x655AE10
        public void RemapNumberClamped(){} // RVA: 0x655AE30
        public void Approach(){} // RVA: 0x655AEA0
        public void BezierInterpolate3(){} // RVA: 0x655AED0
        public void BezierInterpolate4(){} // RVA: 0x655B060
        public void Vector3FromString(){} // RVA: 0x655B310
        public void Vector2FromString(){} // RVA: 0x655B430
        public void Normalize(){} // RVA: 0x655B520
        public void Vector2AsVector3(){} // RVA: 0x3453F0
        public void Vector3AsVector2(){} // RVA: 0x3453D0
        public void AngleOf(){} // RVA: 0x655B530
        public void YawOf(){} // RVA: 0x655B590
        public void Swap(){} // RVA: 0x24D50
        public void Shuffle(){} // RVA: 0x24AE0 | overloaded x2
        public void RandomWithLookback(){} // RVA: 0x655B5E0
        public void FindChild(){} // RVA: 0x655B7C0
        public void IsNullOrEmpty(){} // RVA: 0xDCC0
        public void IsValidIndex(){} // RVA: 0xFCD0 | overloaded x2
        public void FindOrAdd(){} // RVA: 0x283FA0
        public void FindAndRemove(){} // RVA: 0xCEC0
        public void FindOrAddComponent(){} // RVA: 0x283FA0
        public void FastRemove(){} // RVA: 0x2A490
        public void ReplaceGameObject(){} // RVA: 0x283FA0
        public void SwitchLayerRecursively(){} // RVA: 0x655BA70
        public void DrawCross(){} // RVA: 0x655BCA0
        public void ResetTransform(){} // RVA: 0x655C2F0
        public void ClosestPointOnLine(){} // RVA: 0x655C490
        public void AfterTimer(){} // RVA: 0x655C750
        public void SendPhysicsMessage(){} // RVA: 0x655CB20 | overloaded x2
        public void IgnoreCollisions(){} // RVA: 0x655CE10
        public void WrapCoroutine(){} // RVA: 0x655CFB0
        public void ColorWithAlpha(){} // RVA: 0xA38E70
        public void Quit(){} // RVA: 0x655D0B0
        public void FloatToDecimal(){} // RVA: 0x655D0E0
        public void Median(){} // RVA: 0x283FA0
        public void ForEach(){} // RVA: 0x24D50
        public void FixupNewlines(){} // RVA: 0x655D200
        public void PathLength(){} // RVA: 0x655D2C0
        public void HasCommandLineArgument(){} // RVA: 0x655D4A0
        public void GetCommandLineArgValue(){} // RVA: 0x655D620 | overloaded x2
        public void SetActive(){} // RVA: 0x655D700
        public void CombinePaths(){} // RVA: 0x655D810
    }

    public class VelocityEstimator
    {
        // ── Methods ──
        public void BeginEstimatingVelocity(){} // RVA: 0x655DD30
        public void FinishEstimatingVelocity(){} // RVA: 0x655DE50
        public void GetVelocityEstimate(){} // RVA: 0x655DED0
        public void GetAngularVelocityEstimate(){} // RVA: 0x655E000
        public void GetAccelerationEstimate(){} // RVA: 0x655E130
        public void Awake(){} // RVA: 0x655E310
        public void EstimateVelocityCoroutine(){} // RVA: 0x655E430
        public void .ctor(){} // RVA: 0x655E4D0
    }

}