// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 73
// Methods: 662

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AllowTeleportWhileAttachedToHand : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae6b83b0
    }

    public class ArcheryTarget : MonoBehaviour
    {
        public object targetCenter; // 0x33C9E6A0
        public object fallTime; // 0x33C9E6A0
        public object Pέf; // 0x673FC744

        // ── Original Methods ──
        public void ApplyDamage(){} // RVA: 0x7ffaae71fc80
        public void FireExposure(){} // RVA: 0x7ffaae71fc80
        public void OnDamageTaken(){} // RVA: 0x7ffaae71fc90
        public void FallDown(){} // RVA: 0x7ffaae71fd70
        public void .ctor(){} // RVA: 0x7ffaae71fe10
    }

    public class Arrow : MonoBehaviour
    {
        public object shaftRB; // 0x337DCFF0
        public object prevRotation; // 0x337DCFF0
        public object fireReleaseSound; // 0x337DCFF0
        public object hitGroundSound; // 0x337DCFF0
        public object hasSpreadFire; // 0x337DCFF0
        public object initialMass; // 0x337DCFF0
        public object initialInterpolation; // 0x337DCFF0
        public object q5;

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae720240
        public void Start(){} // RVA: 0x7ffaae7204d0
        public void FixedUpdate(){} // RVA: 0x7ffaae720570
        public void StartRelease(){} // RVA: 0x7ffaae720850
        public void ArrowReleased(){} // RVA: 0x7ffaae720ce0
        public void OnCollisionEnter(){} // RVA: 0x7ffaae721970
        public void StickInTarget(){} // RVA: 0x7ffaae7228d0
        public void OnDestroy(){} // RVA: 0x7ffaae723b00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetCollisionMode(){} // RVA: 0x7ffaae721830
    }

    public class ArrowHand : MonoBehaviour
    {
        public object currentArrow; // 0x337E5600
        public object nockDistance; // 0x337E5600
        public object positionLerpThreshold; // 0x337E5600
        public object nockedWithType; // 0x337E5600
        public object arrowSpawnSound; // 0x337E5600
        public object arrowList; // 0x337E5600
        public object 8؏f; // 0x673FCE4C
        public object ћf; // 0x673FCE8D
        public object ћf; // 0x673FCEA7

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae723db0
        public void OnAttachedToHand(){} // RVA: 0x7ffaae723f10
        public void InstantiateArrow(){} // RVA: 0x7ffaae723f70
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae724350
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae725400
        public void FireArrow(){} // RVA: 0x7ffaae7254a0
        public void EnableArrowSpawn(){} // RVA: 0x7ffaa8ae41c0
        public void ArrowReleaseHaptics(){} // RVA: 0x7ffaae725f00
        public void OnHandFocusLost(){} // RVA: 0x7ffaa90c0dd0
        public void OnHandFocusAcquired(){} // RVA: 0x7ffaa9572620
        public void FindBow(){} // RVA: 0x7ffaae725fa0
        public void .ctor(){} // RVA: 0x7ffaae726040
    }

    public class ArrowheadRotation : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae7262f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Balloon : MonoBehaviour
    {
        public object maxVelocity; // 0x33666920
        public object lifetimeEndParticlePrefab; // 0x33666920
        public object releaseTime; // 0x33666920
        public object soundDelay; // 0x33666920
        public object s_flLastDeathSound; // 0x33666920
        public object 8؏f; // 0x673FCBF4

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae7263e0
        public void Update(){} // RVA: 0x7ffaae7265a0
        public void SpawnParticles(){} // RVA: 0x7ffaae7266b0
        public void FixedUpdate(){} // RVA: 0x7ffaae726b60
        public void ApplyDamage(){} // RVA: 0x7ffaae726cf0
        public void OnCollisionEnter(){} // RVA: 0x7ffaae726da0
        public void BalloonColorToRGB(){} // RVA: 0x7ffaae7274d0
        public void .ctor(){} // RVA: 0x7ffaae7276e0
        // ── Binary Analysis Named ──
        public void SetColor(){} // RVA: 0x7ffaae7273f0
    }

    public class BalloonColliders : MonoBehaviour
    {
        public object colliderLocalRotations; // 0x33588820
        public object minSpawnTime; // 0x33B04790

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae727740
        public void OnEnable(){} // RVA: 0x7ffaae727cf0
        public void OnDisable(){} // RVA: 0x7ffaae728340
        public void OnDestroy(){} // RVA: 0x7ffaae728500
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class BalloonHapticBump : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7ffaae728630
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class BalloonSpawner : MonoBehaviour
    {
        public object nextSpawnTime; // 0x33B04790
        public object spawnAtStartup; // 0x33B04790
        public object stretchSound; // 0x33B04790
        public object spawnDirectionTransform; // 0x33B04790
        public object color; // 0x33B04790
        public object fireObject; // 0x33CD0F70
        public object burnTime; // 0x33CD0F70

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae728870
        public void Update(){} // RVA: 0x7ffaae728990
        public void SpawnBalloon(){} // RVA: 0x7ffaae728af0
        public void SpawnBalloonFromEvent(){} // RVA: 0x7ffaae729450
        public void .ctor(){} // RVA: 0x7ffaae729460
    }

    public class BodyCollider : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6dcff0
        public void FixedUpdate(){} // RVA: 0x7ffaae6dd080
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ChaperoneInfo : MonoBehaviour
    {
        public object _playAreaSizeZ; // 0x33C646B0, was: <playAreaSizeZ>k__BackingField
        public object _instance; // 0x33C646B0
        public object initialized; // 0x1700022C
        public object playAreaSizeX; // 0x1700022D

        // ── Original Methods ──
        public void get_initialized(){} // RVA: 0x7ffaa8a209d0
        public void set_initialized(){} // RVA: 0x7ffaa8a209e0
        public void get_playAreaSizeX(){} // RVA: 0x7ffaa8a9ff50
        public void set_playAreaSizeX(){} // RVA: 0x7ffaa8a9ff60
        public void get_playAreaSizeZ(){} // RVA: 0x7ffaa8a11210
        public void set_playAreaSizeZ(){} // RVA: 0x7ffaa8a11220
        public void get_roomscale(){} // RVA: 0x7ffaa8a11230
        public void set_roomscale(){} // RVA: 0x7ffaa8a11240
        public void InitializedAction(){} // RVA: 0x7ffaae72e450
        public void get_instance(){} // RVA: 0x7ffaae72e4f0
        public void Start(){} // RVA: 0x7ffaae72e840
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaae72e8e0
    }

    public class CircularDrive : MonoBehaviour
    {
        public object linearMapping; // 0x334D07D0
        public object frozenDistanceMinMaxThreshold; // 0x334D07D0
        public object freezeOnMin; // 0x334D07D0
        public object freezeOnMax; // 0x334D07D0
        public object startAngle; // 0x334D07D0
        public object dbgPathLimit; // 0x334D07D0
        public object start; // 0x334D07D0
        public object lastHandProjected; // 0x334D07D0
        public object dbgHandObjects; // 0x334D07D0
        public object dbgObjectCount; // 0x334D07D0
        public object minMaxAngularThreshold; // 0x334D07D0
        public object frozenHandWorldPos; // 0x334D07D0
        public object interactable; // 0x334D07D0
        public object get_text; // 0xB41F4950

        // ── Original Methods ──
        public void Freeze(){} // RVA: 0x7ffaae6dd3b0
        public void UnFreeze(){} // RVA: 0x7ffaae6dd480
        public void Awake(){} // RVA: 0x7ffaae6dd4a0
        public void Start(){} // RVA: 0x7ffaae6dd540
        public void OnDisable(){} // RVA: 0x7ffaae6de160
        public void HapticPulses(){} // RVA: 0x7ffaae6de2d0
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae6de390
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae6de3b0
        public void HandHoverUpdate(){} // RVA: 0x7ffaae6de530
        public void ComputeToTransformProjected(){} // RVA: 0x7ffaae6de800
        public void DrawDebugPath(){} // RVA: 0x7ffaae6dec70
        public void UpdateLinearMapping(){} // RVA: 0x7ffaae6dfbb0
        public void UpdateGameObject(){} // RVA: 0x7ffaae6dfc40
        public void UpdateDebugText(){} // RVA: 0x7ffaae6dff00
        public void UpdateAll(){} // RVA: 0x7ffaae6e0100
        public void ComputeAngle(){} // RVA: 0x7ffaae6e01a0
        public void .ctor(){} // RVA: 0x7ffaae6e0690
    }

    public class ComplexThrowable : MonoBehaviour
    {
        public object attachMode; // 0x33A1F220
        public object holdingBodies; // 0x33A1F220

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6e0a30
        public void Update(){} // RVA: 0x7ffaae6e0ab0
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae6e0bf0
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae6e0cd0
        public void HandHoverUpdate(){} // RVA: 0x7ffaae6e0db0
        public void PhysicsAttach(){} // RVA: 0x7ffaae6e0e00
        public void PhysicsDetach(){} // RVA: 0x7ffaae6e18e0
        public void FixedUpdate(){} // RVA: 0x7ffaae6e1bf0
        public void .ctor(){} // RVA: 0x7ffaae6e2170
    }

    public class ControllerButtonHints : MonoBehaviour
    {
        public object flashColor; // 0x33C4D9A0
        public object autoSetWithControllerRangeOfMotion; // 0x33C4D9A0
        public object player; // 0x33C4D9A0
        public object startTime; // 0x33C4D9A0
        public object textHintParent; // 0x33C4D9A0
        public object centerPosition; // 0x33C4D9A0
        public object componentTransformMap; // 0x33C4D9A0
        public object usingMaterial; // 0x1700021C
        public object initialized; // 0x1700021D
        public object Dictionary`2; // 0xB412DB90

        // ── Original Methods ──
        public void get_usingMaterial(){} // RVA: 0x7ffaa89600c0
        public void get_initialized(){} // RVA: 0x7ffaae4e4990
        public void set_initialized(){} // RVA: 0x7ffaae4e49a0
        public void Awake(){} // RVA: 0x7ffaae717960
        public void Start(){} // RVA: 0x7ffaae717ab0
        public void HintDebugLog(){} // RVA: 0x7ffaae717b20
        public void OnEnable(){} // RVA: 0x7ffaae717bb0
        public void OnDisable(){} // RVA: 0x7ffaae717be0
        public void OnParentHandInputFocusLost(){} // RVA: 0x7ffaae717c20
        public void OnHandInitialized(){} // RVA: 0x7ffaae717d30
        public void OnRenderModelLoaded(){} // RVA: 0x7ffaae718270
        public void CreateAndAddButtonInfo(){} // RVA: 0x7ffaae718690
        public void ComputeTextEndTransforms(){} // RVA: 0x7ffaae71a830
        public void ShowButtonHint(){} // RVA: 0x7ffaae71dc70
        public void HideAllButtonHints(){} // RVA: 0x7ffaae71de50
        public void HideButtonHint(){} // RVA: 0x7ffaae71dd60
        public void IsButtonHintActive(){} // RVA: 0x7ffaae71df30
        public void TestButtonHints(){} // RVA: 0x7ffaae71c2f0
        public void TestTextHints(){} // RVA: 0x7ffaae71c390
        public void Update(){} // RVA: 0x7ffaae71c430
        public void UpdateTextHint(){} // RVA: 0x7ffaae71cae0
        public void Clear(){} // RVA: 0x7ffaae71d1d0
        public void ShowText(){} // RVA: 0x7ffaae71d260
        public void HideText(){} // RVA: 0x7ffaae71d620
        public void HideAllText(){} // RVA: 0x7ffaae71d7b0
        public void ShowButtonHint(){} // RVA: 0x7ffaae71dc70
        public void HideButtonHint(){} // RVA: 0x7ffaae71dd60
        public void HideAllButtonHints(){} // RVA: 0x7ffaae71de50
        public void IsButtonHintActive(){} // RVA: 0x7ffaae71df30
        public void ShowTextHint(){} // RVA: 0x7ffaae71e020
        public void HideTextHint(){} // RVA: 0x7ffaae71e1f0
        public void HideAllTextHints(){} // RVA: 0x7ffaae71e500
        public void .ctor(){} // RVA: 0x7ffaae71e7d0
        // ── Binary Analysis Named ──
        public void SetInputSource(){} // RVA: 0x7ffaae717c40
        public void DoInitialize(){} // RVA: 0x7ffaae718590
        public void GetActiveHintText(){} // RVA: 0x7ffaae71e5e0
        public void GetControllerButtonHints(){} // RVA: 0x7ffaae71dae0
        public void GetActiveHintText(){} // RVA: 0x7ffaae71e5e0
    }

    public class ControllerHoverHighlight : MonoBehaviour
    {
        public object hand; // 0x33915490
        public object `;

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6e2420
        public void OnHandInitialized(){} // RVA: 0x7ffaae6e24b0
        public void RenderModel_onControllerLoaded(){} // RVA: 0x7ffaae6e2c20
        public void OnParentHandHoverBegin(){} // RVA: 0x7ffaae6e2c60
        public void OnParentHandHoverEnd(){} // RVA: 0x7ffaae6e2f10
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x7ffaae6e2f20
        public void OnParentHandInputFocusLost(){} // RVA: 0x7ffaae6e2f10
        public void ShowHighlight(){} // RVA: 0x7ffaae6e3290
        public void HideHighlight(){} // RVA: 0x7ffaae6e3400
        public void .ctor(){} // RVA: 0x7ffaa8969bb0
    }

    public class CustomEvents : Object
    {
    }

    public class DebugUI : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae6e3620
        public void Start(){} // RVA: 0x7ffaae6e37b0
        public void OnGUI(){} // RVA: 0x7ffaae6e3820
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DestroyOnDetachedFromHand : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae6e38d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DestroyOnParticleSystemDeath : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6e3970
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void CheckParticleSystem(){} // RVA: 0x7ffaae6e3a30
    }

    public class DestroyOnTriggerEnter : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6e3b30
        public void OnTriggerEnter(){} // RVA: 0x7ffaae6e3b50
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DistanceHaptics : MonoBehaviour
    {
        public object distanceIntensityCurve; // 0x3379F370

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6e3df0
        public void .ctor(){} // RVA: 0x7ffaae6e3e90
    }

    public class DontDestroyOnLoad : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6e43c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class EnumFlags : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Equippable : MonoBehaviour
    {
        public object initialScale; // 0x33C66D60

        // ── Original Methods ──
        public void get_attachedHandType(){} // RVA: 0x7ffaae6e4450
        public void Start(){} // RVA: 0x7ffaae6e4560
        public void Update(){} // RVA: 0x7ffaae6e46b0
        public void .ctor(){} // RVA: 0x7ffaae6e4a70
    }

    public class ExplosionWobble : MonoBehaviour
    {
        // ── Original Methods ──
        public void ExplosionEvent(){} // RVA: 0x7ffaae7294d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class FallbackCameraController : MonoBehaviour
    {
        public object showInstructions; // 0x33756250
        public object realTime; // 0x33756250
        public object .;

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae6e4ac0
        public void Update(){} // RVA: 0x7ffaae6e4b20
        public void OnGUI(){} // RVA: 0x7ffaae6e54f0
        public void .ctor(){} // RVA: 0x7ffaae6e5570
    }

    public class FireSource : MonoBehaviour
    {
        public object fireObject; // 0x33CD0F70
        public object burnTime; // 0x33CD0F70
        public object hand; // 0x33CD0F70

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae729640
        public void Update(){} // RVA: 0x7ffaae729650
        public void OnTriggerEnter(){} // RVA: 0x7ffaae7297e0
        public void FireExposure(){} // RVA: 0x7ffaae729890
        public void StartBurning(){} // RVA: 0x7ffaae729ae0
        public void .ctor(){} // RVA: 0x7ffaa9a2f560
    }

    public class Hand : MonoBehaviour
    {
        public object handType; // 0x33539690
        public object grabGripAction; // 0x33539690
        public object useHoverSphere; // 0x33539690
        public object hoverLayerMask; // 0x33539690
        public object controllerHoverComponent; // 0x33539690
        public object fingerJointHover; // 0x33539690
        public object noSteamVRFallbackCamera; // 0x33539690
        public object noSteamVRFallbackInteractorDistance; // 0x33539690
        public object mainRenderModel; // 0x33539690
        public object spewDebugText; // 0x33539690
        public object _hoverLocked; // 0x33539690, was: <hoverLocked>k__BackingField
        public object prevOverlappingColliders; // 0x33539690
        public object playerInstance; // 0x33539690
        public object MaxVelocityChange; // 0x33539690
        public object MaxAngularVelocityChange; // 0x33539690
        public object AttachedObjects; // 0x170001F5
        public object hoverLocked; // 0x170001F6
        public object isActive; // 0x170001F7
        public object isPoseValid; // 0x170001F8
        public object hoveringInteractable; // 0x170001F9
        public object currentAttachedObject; // 0x170001FA
        public object currentAttachedObjectInfo; // 0x170001FB
        public object currentAttachedTeleportManager; // 0x170001FC
        public object skeleton; // 0x170001FD

        // ── Original Methods ──
        public void get_AttachedObjects(){} // RVA: 0x7ffaae6e55d0
        public void get_hoverLocked(){} // RVA: 0x7ffaa8a5df80
        public void set_hoverLocked(){} // RVA: 0x7ffaa8a5df90
        public void get_isActive(){} // RVA: 0x7ffaae6e56a0
        public void get_isPoseValid(){} // RVA: 0x7ffaae6e5860
        public void get_hoveringInteractable(){} // RVA: 0x7ffaa89b3970
        public void set_hoveringInteractable(){} // RVA: 0x7ffaae6e58b0
        public void get_currentAttachedObject(){} // RVA: 0x7ffaae6e5e50
        public void get_currentAttachedObjectInfo(){} // RVA: 0x7ffaae6e5f00
        public void get_currentAttachedTeleportManager(){} // RVA: 0x7ffaae6e6150
        public void get_skeleton(){} // RVA: 0x7ffaae6e61f0
        public void ShowController(){} // RVA: 0x7ffaae6e62e0
        public void HideController(){} // RVA: 0x7ffaae6e6490
        public void ShowSkeleton(){} // RVA: 0x7ffaae6e6640
        public void HideSkeleton(){} // RVA: 0x7ffaae6e67f0
        public void HasSkeleton(){} // RVA: 0x7ffaae6e69a0
        public void Show(){} // RVA: 0x7ffaae6e6b30
        public void Hide(){} // RVA: 0x7ffaae6e6b40
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7ffaae6e6f60
        public void StopAnimation(){} // RVA: 0x7ffaae6e7320
        public void AttachObject(){} // RVA: 0x7ffaae6e7520
        public void ObjectIsAttached(){} // RVA: 0x7ffaae6ea710
        public void ForceHoverUnlock(){} // RVA: 0x7ffaa8dc5ac0
        public void DetachObject(){} // RVA: 0x7ffaae6ea900
        public void CleanUpAttachedObjectStack(){} // RVA: 0x7ffaae6eca50
        public void Awake(){} // RVA: 0x7ffaae6ecbd0
        public void OnDestroy(){} // RVA: 0x7ffaae6ed450
        public void OnTransformUpdated(){} // RVA: 0x7ffaa9cf9d80
        public void Start(){} // RVA: 0x7ffaae6ed630
        public void UpdateHovering(){} // RVA: 0x7ffaae6ed6d0
        public void UpdateNoSteamVRFallback(){} // RVA: 0x7ffaae6ee8f0
        public void UpdateDebugText(){} // RVA: 0x7ffaae6ef080
        public void OnEnable(){} // RVA: 0x7ffaae6efc80
        public void OnDisable(){} // RVA: 0x7ffaae6efe10
        public void Update(){} // RVA: 0x7ffaae6efe90
        public void IsStillHovering(){} // RVA: 0x7ffaae6f0080
        public void HandFollowUpdate(){} // RVA: 0x7ffaae6f01c0
        public void FixedUpdate(){} // RVA: 0x7ffaae6f18d0
        public void UpdateAttachedVelocity(){} // RVA: 0x7ffaae6f2220
        public void ResetAttachedTransform(){} // RVA: 0x7ffaae6f25e0
        public void TargetItemPosition(){} // RVA: 0x7ffaae6f2850
        public void TargetItemRotation(){} // RVA: 0x7ffaae6f2cf0
        public void OnInputFocus(){} // RVA: 0x7ffaae6f3d70
        public void OnDrawGizmos(){} // RVA: 0x7ffaae6f3f10
        public void HandDebugLog(){} // RVA: 0x7ffaae6f45f0
        public void HoverLock(){} // RVA: 0x7ffaae6f46b0
        public void HoverUnlock(){} // RVA: 0x7ffaae6f4760
        public void TriggerHapticPulse(){} // RVA: 0x7ffaae6f4950
        public void TriggerHapticPulse(){} // RVA: 0x7ffaae6f4950
        public void ShowGrabHint(){} // RVA: 0x7ffaae6f4aa0
        public void HideGrabHint(){} // RVA: 0x7ffaae6f4a90
        public void ShowGrabHint(){} // RVA: 0x7ffaae6f4aa0
        public void IsGrabEnding(){} // RVA: 0x7ffaae6f51a0
        public void IsGrabbingWithType(){} // RVA: 0x7ffaae6f5420
        public void IsGrabbingWithOppositeType(){} // RVA: 0x7ffaae6f55b0
        public void InitController(){} // RVA: 0x7ffaae6f5920
        public void .ctor(){} // RVA: 0x7ffaae6f6870
        // ── Binary Analysis Named ──
        public void SetVisibility(){} // RVA: 0x7ffaae6e6b50
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7ffaae6e6c50
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7ffaae6e6d30
        public void SetAnimationState(){} // RVA: 0x7ffaae6e7120
        public void GetTrackedObjectVelocity(){} // RVA: 0x7ffaae6ec060
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x7ffaae6ec4a0
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7ffaae6ec8e0
        public void CheckHoveringForTransform(){} // RVA: 0x7ffaae6edc90
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x7ffaae6f35a0
        public void GetGrabStarting(){} // RVA: 0x7ffaae6f4ad0
        public void GetGrabEnding(){} // RVA: 0x7ffaae6f4ed0
        public void GetBestGrabbingType(){} // RVA: 0x7ffaae6f5750
        public void GetBestGrabbingType(){} // RVA: 0x7ffaae6f5750
        public void SetRenderModel(){} // RVA: 0x7ffaae6f6600
        public void SetHoverRenderModel(){} // RVA: 0x7ffaae6f6770
        public void GetDeviceIndex(){} // RVA: 0x7ffaae6f6820
    }

    public class HandCollider : MonoBehaviour
    {
        public object collisionMask; // 0x33522890
        public object physicMaterial_lowfriction; // 0x33522890
        public object center; // 0x33522890
        public object MaxVelocityChange; // 0x33522890
        public object MaxAngularVelocityChange; // 0x33522890
        public object maxCollisionEnergy; // 0x33522890

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6f7540
        public void Start(){} // RVA: 0x7ffaae6f7620
        public void MoveTo(){} // RVA: 0x7ffaae6f8020
        public void TeleportTo(){} // RVA: 0x7ffaae6f8040
        public void Reset(){} // RVA: 0x7ffaae6f82f0
        public void ExecuteFixedUpdate(){} // RVA: 0x7ffaae6f8340
        public void OnCollisionEnter(){} // RVA: 0x7ffaae6f8d80
        public void .ctor(){} // RVA: 0x7ffaae6f90b0
        // ── Binary Analysis Named ──
        public void SetPhysicMaterial(){} // RVA: 0x7ffaae6f7e50
        public void SetCollisionDetectionEnabled(){} // RVA: 0x7ffaae6f7fb0
        public void SetCenterPoint(){} // RVA: 0x7ffaae6f8330
        public void GetTargetVelocities(){} // RVA: 0x7ffaae6f8850
    }

    public class HandPhysics : MonoBehaviour
    {
        public object clearanceCheckMask; // 0x334C57C0
        public object collisionReenableClearanceRadius; // 0x334C57C0
        public object wristToRoot; // 0x334C57C0
        public object targetPosition; // 0x334C57C0
        public object rootBone; // 0x334C57C0
        public object thumbBone; // 0x334C57C0
        public object ringBone; // 0x334C57C0
        public object teethCount; // 0x338B5420
        public object onPulse; // 0x338B5420
        public object movingPart; // 0x33549010
        public object disengageAtPercent; // 0x33549010

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6f9440
        public void FixedUpdate(){} // RVA: 0x7ffaae6f9b10
        public void UpdateCenterPoint(){} // RVA: 0x7ffaae6f9d90
        public void UpdatePositions(){} // RVA: 0x7ffaae6fa050
        public void UpdateFingertips(){} // RVA: 0x7ffaae6fb180
        public void UpdateHand(){} // RVA: 0x7ffaae6fb650
        public void ProcessPos(){} // RVA: 0x7ffaae6fbc60
        public void ProcessRot(){} // RVA: 0x7ffaae6fbde0
        public void .ctor(){} // RVA: 0x7ffaae6fbea0
    }

    public class HapticRack : MonoBehaviour
    {
        public object minimumPulseDuration; // 0x338B5420
        public object hand; // 0x338B5420
        public object localMoveDistance; // 0x33549010

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6fc000
        public void OnHandHoverBegin(){} // RVA: 0x7ffaa895a200
        public void OnHandHoverEnd(){} // RVA: 0x7ffaadc17ec0
        public void Update(){} // RVA: 0x7ffaae6fc140
        public void Pulse(){} // RVA: 0x7ffaae6fc2c0
        public void .ctor(){} // RVA: 0x7ffaae6fc400
    }

    public class HideOnHandFocusLost : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnHandFocusLost(){} // RVA: 0x7ffaa90c0dd0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class HoverButton : MonoBehaviour
    {
        public object engageAtPercent; // 0x33549010
        public object onButtonUp; // 0x33549010
        public object buttonDown; // 0x33549010
        public object endPosition; // 0x33549010
        public object lastHoveredHand; // 0x33549010
        public object _instance; // 0x33AECD70
        public object instance; // 0x17000201
        public object simulateReleasesEveryXSeconds; // 0x338741B0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6fc460
        public void HandHoverUpdate(){} // RVA: 0x7ffaae6fc730
        public void LateUpdate(){} // RVA: 0x7ffaae6fce30
        public void InvokeEvents(){} // RVA: 0x7ffaae6fcf60
        public void .ctor(){} // RVA: 0x7ffaae6fd040
    }

    public class IgnoreHovering : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class IgnoreTeleportTrace : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class InputModule : BaseInputModule
    {
        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae6fd0b0
        public void ShouldActivateModule(){} // RVA: 0x7ffaae6fd240
        public void HoverBegin(){} // RVA: 0x7ffaae6fd320
        public void HoverEnd(){} // RVA: 0x7ffaae6fd420
        public void Submit(){} // RVA: 0x7ffaa89fa510
        public void Process(){} // RVA: 0x7ffaae6fd540
        public void .ctor(){} // RVA: 0x7ffaae6fd710
    }

    public class Interactable : MonoBehaviour
    {
        public object hideSkeletonOnAttach; // 0x33A74FA0
        public object setRangeOfMotionOnPickup; // 0x33A74FA0
        public object useHandObjectAttachmentPoint; // 0x33A74FA0
        public object snapAttachEaseInTime; // 0x33A74FA0
        public object handFollowTransform; // 0x33A74FA0
        public object existingRenderers; // 0x33A74FA0
        public object existingSkinnedRenderers; // 0x33A74FA0
        public object hoverPriority; // 0x33A74FA0
        public object _isDestroying; // 0x33A74FA0, was: <isDestroying>k__BackingField
        public object blendToPoseTime; // 0x33A74FA0
        public object onDetachedFromHand; // 0x33A78E30
        public object hoveringHand; // 0x17000202
        public object isDestroying; // 0x17000203
        public object isHovering; // 0x17000204
        public object wasHovering; // 0x17000205

        // ── Original Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x7ffaae6fd720
        public void remove_onAttachedToHand(){} // RVA: 0x7ffaae6fd810
        public void add_onDetachedFromHand(){} // RVA: 0x7ffaae6fd900
        public void remove_onDetachedFromHand(){} // RVA: 0x7ffaae6fd9f0
        public void get_hoveringHand(){} // RVA: 0x7ffaae6fdae0
        public void get_isDestroying(){} // RVA: 0x7ffaa9c12640
        public void set_isDestroying(){} // RVA: 0x7ffaa9c14170
        public void get_isHovering(){} // RVA: 0x7ffaabc50470
        public void set_isHovering(){} // RVA: 0x7ffaabc50480
        public void get_wasHovering(){} // RVA: 0x7ffaae6fdb70
        public void set_wasHovering(){} // RVA: 0x7ffaae6fdb80
        public void Awake(){} // RVA: 0x7ffaae6fdb90
        public void Start(){} // RVA: 0x7ffaae6fdc20
        public void ShouldIgnoreHighlight(){} // RVA: 0x7ffaae6fe000
        public void ShouldIgnore(){} // RVA: 0x7ffaae6fe080
        public void CreateHighlightRenderers(){} // RVA: 0x7ffaae6fe210
        public void UpdateHighlightRenderers(){} // RVA: 0x7ffaae6feb60
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae6ff810
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae6ff8c0
        public void Update(){} // RVA: 0x7ffaae6ffa40
        public void OnAttachedToHand(){} // RVA: 0x7ffaae6ffb70
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae6fff30
        public void OnDestroy(){} // RVA: 0x7ffaae700450
        public void OnDisable(){} // RVA: 0x7ffaae700690
        public void .ctor(){} // RVA: 0x7ffaae700840
    }

    public class InteractableDebug : MonoBehaviour
    {
        public object simulateReleasesEveryXSeconds; // 0x338741B0
        public object colliders; // 0x338741B0
        public object onlyColorOnChange; // 0x338741B0
        public object attachmentFlags; // 0x337E69D0
        public object releaseVelocityStyle; // 0x337E69D0

        // ── Original Methods ──
        public void get_isThrowable(){} // RVA: 0x7ffaae700a60
        public void Awake(){} // RVA: 0x7ffaae700b30
        public void OnAttachedToHand(){} // RVA: 0x7ffaae700d60
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae700de0
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae700f40
        public void IgnoreObject(){} // RVA: 0x7ffaae701510
        public void CreateSimulation(){} // RVA: 0x7ffaae701630
        public void CreateMarker(){} // RVA: 0x7ffaae701a20
        public void CreateMarker(){} // RVA: 0x7ffaae701a20
        public void ColorSelf(){} // RVA: 0x7ffaae7021d0
        public void ColorThing(){} // RVA: 0x7ffaae7022a0
        public void .ctor(){} // RVA: 0x7ffaae702370
        // ── Binary Analysis Named ──
        public void GetColliders(){} // RVA: 0x7ffaa89af740
        public void SetIsSimulation(){} // RVA: 0x7ffaae701620
    }

    public class InteractableHoverEvents : MonoBehaviour
    {
        public object onAttachedToHand; // 0x33AB7510

        // ── Original Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae7023c0
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae7023e0
        public void OnAttachedToHand(){} // RVA: 0x7ffaae702400
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae702420
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ItemPackage : MonoBehaviour
    {
        public object itemPrefab; // 0x33AED060
        public object fadedPreviewPrefab; // 0x33AED060

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ItemPackageReference : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ItemPackageSpawner : MonoBehaviour
    {
        public object useFadedPreview; // 0x3366E6E0
        public object requireReleaseActionToReturn; // 0x3366E6E0
        public object takeBackItem; // 0x3366E6E0
        public object itemIsSpawned; // 0x3366E6E0
        public object justPickedUpItem; // 0x3366E6E0
        public object itemPackage; // 0x17000207
        public object animState; // 0x336A63A0
        public object linearMapping; // 0x33784780

        // ── Original Methods ──
        public void get_itemPackage(){} // RVA: 0x7ffaa89600c0
        public void set_itemPackage(){} // RVA: 0x7ffaae702440
        public void CreatePreviewObject(){} // RVA: 0x7ffaae702450
        public void Start(){} // RVA: 0x7ffaae702a60
        public void VerifyItemPackage(){} // RVA: 0x7ffaae702a60
        public void ItemPackageNotValid(){} // RVA: 0x7ffaae702bf0
        public void ClearPreview(){} // RVA: 0x7ffaae702d60
        public void Update(){} // RVA: 0x7ffaae7030b0
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae7031b0
        public void TakeBackItem(){} // RVA: 0x7ffaae703390
        public void HandHoverUpdate(){} // RVA: 0x7ffaae7035b0
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae7037b0
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x7ffaae703800
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x7ffaae703c30
        public void SpawnAndAttachObject(){} // RVA: 0x7ffaae703ea0
        public void .ctor(){} // RVA: 0x7ffaae7044d0
        // ── Binary Analysis Named ──
        public void GetAttachedItemPackage(){} // RVA: 0x7ffaae7033f0
    }

    public class LinearAnimation : MonoBehaviour
    {
        public object animState; // 0x336A63A0
        public object linearMapping; // 0x33784780

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae704520
        public void Update(){} // RVA: 0x7ffaae7049d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LinearAnimator : MonoBehaviour
    {
        public object currentLinearMapping; // 0x33784780
        public object pitchCurve; // 0x33A777B0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae704a30
        public void Update(){} // RVA: 0x7ffaae704ce0
        public void .ctor(){} // RVA: 0x7ffaae704dc0
    }

    public class LinearAudioPitch : MonoBehaviour
    {
        public object minPitch; // 0x33A777B0
        public object audioSource; // 0x33A777B0
        public object lastValue; // 0x337357D0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae704e10
        public void Update(){} // RVA: 0x7ffaae705060
        public void Apply(){} // RVA: 0x7ffaae705180
        public void .ctor(){} // RVA: 0x7ffaa9cb58b0
    }

    public class LinearBlendshape : MonoBehaviour
    {
        public object lastValue; // 0x337357D0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae705290
        public void Update(){} // RVA: 0x7ffaae7054e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LinearDisplacement : MonoBehaviour
    {
        public object initialPosition; // 0x3343D390

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae7055c0
        public void Update(){} // RVA: 0x7ffaae7057b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LinearDrive : MonoBehaviour
    {
        public object linearMapping; // 0x339152B0
        public object momemtumDampenRate; // 0x339152B0
        public object numMappingChangeSamples; // 0x339152B0
        public object mappingChangeRate; // 0x339152B0
        public object gripOffset; // 0x337E67A0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae705990
        public void Start(){} // RVA: 0x7ffaae705ab0
        public void HandHoverUpdate(){} // RVA: 0x7ffaae705dc0
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae705fc0
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae7060f0
        public void CalculateMappingChangeRate(){} // RVA: 0x7ffaae7060f0
        public void UpdateLinearMapping(){} // RVA: 0x7ffaae706170
        public void CalculateLinearMapping(){} // RVA: 0x7ffaae706480
        public void Update(){} // RVA: 0x7ffaae706780
        public void .ctor(){} // RVA: 0x7ffaae706aa0
    }

    public class LinearMapping : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Longbow : MonoBehaviour
    {
        public object timeBeforeConfirmingHandSwitch; // 0x3357FBC0
        public object handleTransform; // 0x3357FBC0
        public object nockTransform; // 0x3357FBC0
        public object arrowHandItemPackage; // 0x3357FBC0
        public object pulled; // 0x3357FBC0
        public object nockDistanceTravelled; // 0x3357FBC0
        public object bowPullPulseStrengthLow; // 0x3357FBC0
        public object arrowMinVelocity; // 0x3357FBC0
        public object minStrainTickTime; // 0x3357FBC0
        public object lerpBackToZeroRotation; // 0x3357FBC0
        public object lerpStartRotation; // 0x3357FBC0
        public object drawOffset; // 0x3357FBC0
        public object lateUpdateRot; // 0x3357FBC0
        public object arrowSlideSound; // 0x3357FBC0
        public object newPosesAppliedAction; // 0x3357FBC0
        public object Right; // 0x847C4680
        public object minPitch; // 0x33BE4710
        public object teleportAllowed; // 0x33A74340
        public object value__; // 0x847C43D0
        public object Orange; // 0x847C43D0
        public object GreenYellow; // 0x847C43D0

        // ── Original Methods ──
        public void OnAttachedToHand(){} // RVA: 0x7ffaa895a200
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae72a080
        public void ArrowReleased(){} // RVA: 0x7ffaae72b150
        public void ResetDrawAnim(){} // RVA: 0x7ffaae72b2d0
        public void StartRotationLerp(){} // RVA: 0x7ffaae72b370
        public void StartNock(){} // RVA: 0x7ffaae72b450
        public void EvaluateHandedness(){} // RVA: 0x7ffaae72b5d0
        public void ArrowInPosition(){} // RVA: 0x7ffaae72b800
        public void ReleaseNock(){} // RVA: 0x7ffaae72b8f0
        public void ShutDown(){} // RVA: 0x7ffaae72b970
        public void OnHandFocusLost(){} // RVA: 0x7ffaa90c0dd0
        public void OnHandFocusAcquired(){} // RVA: 0x7ffaae72bd40
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae72be60
        public void OnDestroy(){} // RVA: 0x7ffaae72bf00
        public void .ctor(){} // RVA: 0x7ffaae72bf10
        // ── Binary Analysis Named ──
        public void GetArrowVelocity(){} // RVA: 0x7ffaa8b6ec30
        public void DoHandednessCheck(){} // RVA: 0x7ffaae72b720
    }

    public class ModalThrowable : Throwable
    {
        // ── Original Methods ──
        public void HandHoverUpdate(){} // RVA: 0x7ffaae706b00
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae706bf0
        public void .ctor(){} // RVA: 0x7ffaae706e90
    }

    public class PlaySound : MonoBehaviour
    {
        public object disableOnEnd; // 0x3348DC70
        public object playOnAwakeWithDelay; // 0x3348DC70
        public object volMax; // 0x3348DC70
        public object pitchMax; // 0x3348DC70
        public object timeMin; // 0x3348DC70
        public object percentToNotPlay; // 0x3348DC70
        public object clip; // 0x3348DC70
        public object interactable; // 0x33896D30
        public object destroyAfterPlayOnce; // 0x33CA95B0
        public object thisAudioSource; // 0x335D8170

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae709c60
        public void Play(){} // RVA: 0x7ffaae709f40
        public void PlayWithDelay(){} // RVA: 0x7ffaae70a0f0
        public void PlayOneShotSound(){} // RVA: 0x7ffaae70a170
        public void PlayLooping(){} // RVA: 0x7ffaae70a310
        public void Disable(){} // RVA: 0x7ffaa90c0dd0
        public void Stop(){} // RVA: 0x7ffaae70a520
        public void .ctor(){} // RVA: 0x7ffaae70a800
        // ── Binary Analysis Named ──
        public void SetAudioSource(){} // RVA: 0x7ffaae70a580
    }

    public class Player : MonoBehaviour
    {
        public object hands; // 0x334D38D0
        public object rig2DFallback; // 0x334D38D0
        public object allowToggleTo2D; // 0x334D38D0

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae706f80
        public void get_handCount(){} // RVA: 0x7ffaae707110
        public void get_leftHand(){} // RVA: 0x7ffaae7073a0
        public void get_rightHand(){} // RVA: 0x7ffaae707510
        public void get_scale(){} // RVA: 0x7ffaae707680
        public void get_hmdTransform(){} // RVA: 0x7ffaae707740
        public void get_eyeHeight(){} // RVA: 0x7ffaae707880
        public void get_feetPositionGuess(){} // RVA: 0x7ffaae707b30
        public void get_bodyDirectionGuess(){} // RVA: 0x7ffaae707e90
        public void Awake(){} // RVA: 0x7ffaae7080d0
        public void Start(){} // RVA: 0x7ffaae708370
        public void Update(){} // RVA: 0x7ffaae708410
        public void OnDrawGizmos(){} // RVA: 0x7ffaae7085e0
        public void Draw2DDebug(){} // RVA: 0x7ffaae7091a0
        public void ActivateRig(){} // RVA: 0x7ffaae7093e0
        public void PlayerShotSelf(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaae709930
        // ── Binary Analysis Named ──
        public void GetHand(){} // RVA: 0x7ffaae707250
    }

    public class RenderModel : MonoBehaviour
    {
        public object handRenderers; // 0x338CF060
        public object handAnimator; // 0x338CF060
        public object controllerPrefab; // 0x338CF060
        public object controllerRenderModel; // 0x338CF060
        public object onControllerLoaded; // 0x338CF060

        // ── Original Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x7ffaae70a870
        public void remove_onControllerLoaded(){} // RVA: 0x7ffaae70a960
        public void Awake(){} // RVA: 0x7ffaae70aa50
        public void InitializeHand(){} // RVA: 0x7ffaae70ab50
        public void InitializeController(){} // RVA: 0x7ffaae70b540
        public void DestroyHand(){} // RVA: 0x7ffaae70bb40
        public void OnSkeletonActiveChange(){} // RVA: 0x7ffaae70bed0
        public void OnEnable(){} // RVA: 0x7ffaae70bef0
        public void OnDisable(){} // RVA: 0x7ffaae70bf20
        public void OnDestroy(){} // RVA: 0x7ffaa89e6bc0
        public void OnHandInitialized(){} // RVA: 0x7ffaae70c040
        public void MatchHandToTransform(){} // RVA: 0x7ffaae70c080
        public void OnRenderModelLoaded(){} // RVA: 0x7ffaae70cb10
        public void Show(){} // RVA: 0x7ffaae70ce30
        public void Hide(){} // RVA: 0x7ffaae70ce80
        public void IsHandVisibile(){} // RVA: 0x7ffaae70d320
        public void IsControllerVisibile(){} // RVA: 0x7ffaae70d3f0
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x7ffaae70de50
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7ffaae70e0a0
        public void StopAnimation(){} // RVA: 0x7ffaae70e2d0
        public void .ctor(){} // RVA: 0x7ffaae70e7e0
        // ── Binary Analysis Named ──
        public void GetSkeleton(){} // RVA: 0x7ffaa89af740
        public void SetInputSource(){} // RVA: 0x7ffaae70bf50
        public void SetHandPosition(){} // RVA: 0x7ffaae70c440
        public void SetHandRotation(){} // RVA: 0x7ffaae70c5d0
        public void GetHandPosition(){} // RVA: 0x7ffaae70c750
        public void GetHandRotation(){} // RVA: 0x7ffaae70c940
        public void SetVisibility(){} // RVA: 0x7ffaae70cdb0
        public void SetMaterial(){} // RVA: 0x7ffaae70ceb0
        public void SetControllerMaterial(){} // RVA: 0x7ffaae70cf80
        public void SetHandMaterial(){} // RVA: 0x7ffaae70d0c0
        public void SetControllerVisibility(){} // RVA: 0x7ffaae70d180
        public void SetHandVisibility(){} // RVA: 0x7ffaae70d250
        public void GetBone(){} // RVA: 0x7ffaae70d4c0
        public void GetBonePosition(){} // RVA: 0x7ffaae70d5d0
        public void GetControllerPosition(){} // RVA: 0x7ffaae70d730
        public void GetBoneRotation(){} // RVA: 0x7ffaae70d9b0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7ffaae70dc00
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7ffaae70df40
        public void SetAnimationState(){} // RVA: 0x7ffaae70e1a0
        public void CheckAnimatorInit(){} // RVA: 0x7ffaae70e3f0
    }

    public class SeeThru : MonoBehaviour
    {
        public object interactable; // 0x33896D30
        public object destroyAfterPlayOnce; // 0x33CA95B0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae70e8b0
        public void OnEnable(){} // RVA: 0x7ffaae70fab0
        public void OnDisable(){} // RVA: 0x7ffaae70fd40
        public void AttachedToHand(){} // RVA: 0x7ffaae70ffd0
        public void DetachedFromHand(){} // RVA: 0x7ffaa91233e0
        public void Update(){} // RVA: 0x7ffaae710030
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SleepOnAwake : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae7104a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SnapTurn : MonoBehaviour
    {
        public object snapTurnSource; // 0x3383E110
        public object rotateLeftFX; // 0x3383E110
        public object fadeScreen; // 0x3383E110
        public object distanceFromFace; // 0x3383E110
        public object canRotate; // 0x3383E110

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae72c3b0
        public void AllOff(){} // RVA: 0x7ffaae72c3c0
        public void Update(){} // RVA: 0x7ffaae72c5c0
        public void RotatePlayer(){} // RVA: 0x7ffaae72cd60
        public void ShowRotateFX(){} // RVA: 0x7ffaae72cf70
        public void UpdateOrientation(){} // RVA: 0x7ffaae72d0e0
        public void .ctor(){} // RVA: 0x7ffaae72d850
        // ── Binary Analysis Named ──
        public void DoRotatePlayer(){} // RVA: 0x7ffaae72ceb0
    }

    public class SoundBowClick : MonoBehaviour
    {
        public object minPitch; // 0x33BE4710
        public object teleportAllowed; // 0x33A74340

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae72c220
        public void PlayBowTensionClicks(){} // RVA: 0x7ffaae72c2b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SoundDeparent : MonoBehaviour
    {
        public object waveFiles; // 0x335D8170

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae7105d0
        public void Start(){} // RVA: 0x7ffaae710660
        public void .ctor(){} // RVA: 0x7ffaa898c060
    }

    public class SoundPlayOneshot : MonoBehaviour
    {
        public object volMin; // 0x335D8170
        public object pitchMax; // 0x335D8170
        public object itemPrefab; // 0x335A86C0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae710870
        public void Play(){} // RVA: 0x7ffaae710910
        public void Pause(){} // RVA: 0x7ffaae710b10
        public void UnPause(){} // RVA: 0x7ffaae710c30
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SpawnAndAttachAfterControllerIsTracking : MonoBehaviour
    {
        public object hand; // 0x33CA8A90

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae710d50
        public void Update(){} // RVA: 0x7ffaae710de0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SpawnAndAttachToHand : MonoBehaviour
    {
        // ── Original Methods ──
        public void SpawnAndAttach(){} // RVA: 0x7ffaae7110c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Teleport : MonoBehaviour
    {
        public object floorFixupTraceLayerMask; // 0x33C9DC90
        public object areaLockedMaterial; // 0x33C9DC90
        public object pointLockedMaterial; // 0x33C9DC90
        public object invalidReticleTransform; // 0x33C9DC90
        public object pointerValidColor; // 0x33C9DC90
        public object showPlayAreaMarker; // 0x33C9DC90
        public object arcDistance; // 0x33C9DC90
        public object activateObjectTime; // 0x33C9DC90
        public object loopingAudioSource; // 0x33C9DC90
        public object teleportSound; // 0x33C9DC90
        public object pointerStopSound; // 0x33C9DC90
        public object debugFloor; // 0x33C9DC90
        public object floorDebugSphere; // 0x33C9DC90
        public object teleportPointerObject; // 0x33C9DC90
        public object player; // 0x33C9DC90
        public object teleportMarkers; // 0x33C9DC90
        public object pointedAtPosition; // 0x33C9DC90
        public object currentFadeTime; // 0x33C9DC90
        public object pointerHideStartTime; // 0x33C9DC90
        public object invalidReticleMinScale; // 0x33C9DC90
        public object invalidReticleMaxScaleDistance; // 0x33C9DC90
        public object playAreaPreviewTransform; // 0x33C9DC90
        public object loopingAudioMaxVolume; // 0x33C9DC90
        public object originalHoveringInteractable; // 0x33C9DC90
        public object movedFeetFarEnough; // 0x33C9DC90
        public object Player; // 0x33C9DC90
        public object `Ǐf; // 0x673FDD20
        public object 8؏f; // 0x673FDD43
        public object `Ǐf; // 0x673FD64D
        public object 8؏f; // 0x673FDD75
        public object ћf; // 0x673FDDBA

        // ── Original Methods ──
        public void ChangeSceneAction(){} // RVA: 0x7ffaae72ee50
        public void PlayerAction(){} // RVA: 0x7ffaae72ef00
        public void PlayerPreAction(){} // RVA: 0x7ffaae72efc0
        public void get_instance(){} // RVA: 0x7ffaae72f080
        public void Awake(){} // RVA: 0x7ffaae72f250
        public void Start(){} // RVA: 0x7ffaae72f870
        public void OnEnable(){} // RVA: 0x7ffaae72fc90
        public void OnDisable(){} // RVA: 0x7ffaae72fcd0
        public void HideTeleportPointer(){} // RVA: 0x7ffaae72feb0
        public void Update(){} // RVA: 0x7ffaae72ff90
        public void UpdatePointer(){} // RVA: 0x7ffaae7309a0
        public void FixedUpdate(){} // RVA: 0x7ffaae732600
        public void OnChaperoneInfoInitialized(){} // RVA: 0x7ffaae732f10
        public void HidePointer(){} // RVA: 0x7ffaae7346d0
        public void ShowPointer(){} // RVA: 0x7ffaae735070
        public void UpdateTeleportColors(){} // RVA: 0x7ffaae736220
        public void PlayAudioClip(){} // RVA: 0x7ffaae736340
        public void PlayPointerHaptic(){} // RVA: 0x7ffaae7363f0
        public void TryTeleportPlayer(){} // RVA: 0x7ffaae7365b0
        public void InitiateTeleportFade(){} // RVA: 0x7ffaae7366e0
        public void TeleportPlayer(){} // RVA: 0x7ffaae736b30
        public void HighlightSelected(){} // RVA: 0x7ffaae7378d0
        public void ShowTeleportHint(){} // RVA: 0x7ffaae737e80
        public void CancelTeleportHint(){} // RVA: 0x7ffaae737fa0
        public void TeleportHintCoroutine(){} // RVA: 0x7ffaae738100
        public void IsEligibleForTeleport(){} // RVA: 0x7ffaae7381a0
        public void ShouldOverrideHoverLock(){} // RVA: 0x7ffaae7385d0
        public void WasTeleportButtonReleased(){} // RVA: 0x7ffaae7386d0
        public void IsTeleportButtonDown(){} // RVA: 0x7ffaae738840
        public void WasTeleportButtonPressed(){} // RVA: 0x7ffaae7389b0
        public void .ctor(){} // RVA: 0x7ffaae738c80
        public void .cctor(){} // RVA: 0x7ffaae738ec0
        // ── Binary Analysis Named ──
        public void CheckForSpawnPoint(){} // RVA: 0x7ffaae72fd10
        public void GetPointerStartTransform(){} // RVA: 0x7ffaae738b20
    }

    public class TeleportArc : MonoBehaviour
    {
        public object arcDuration; // 0x339BE620
        public object material; // 0x339BE620
        public object arcTimeOffset; // 0x339BE620
        public object showArc; // 0x339BE620
        public object useGravity; // 0x339BE620
        public object scale; // 0x339BE620
        public object 0d20;

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae739470
        public void Update(){} // RVA: 0x7ffaae7394d0
        public void CreateLineRendererObjects(){} // RVA: 0x7ffaae7395e0
        public void Show(){} // RVA: 0x7ffaae739f80
        public void Hide(){} // RVA: 0x7ffaae739fa0
        public void DrawArc(){} // RVA: 0x7ffaae739fe0
        public void DrawArcSegment(){} // RVA: 0x7ffaae73a3c0
        public void FindProjectileCollision(){} // RVA: 0x7ffaae73a700
        public void HideLineSegments(){} // RVA: 0x7ffaae73ac20
        public void .ctor(){} // RVA: 0x7ffaae73ace0
        // ── Binary Analysis Named ──
        public void SetArcData(){} // RVA: 0x7ffaae739ee0
        public void SetColor(){} // RVA: 0x7ffaae73a5b0
        public void GetArcPositionAtTime(){} // RVA: 0x7ffaae73aa50
    }

    public class TeleportArea : TeleportMarkerBase
    {
        public object tintColorId; // 0x338CFB20
        public object lockedTintColor; // 0x338CFB20

        // ── Original Methods ──
        public void get_meshBounds(){} // RVA: 0x7ffaaa56e760
        public void set_meshBounds(){} // RVA: 0x7ffaaa56e780
        public void Awake(){} // RVA: 0x7ffaae73ad60
        public void Start(){} // RVA: 0x7ffaae73ae60
        public void ShouldActivate(){} // RVA: 0x7ffaa8a17850
        public void ShouldMovePlayer(){} // RVA: 0x7ffaa8a17850
        public void Highlight(){} // RVA: 0x7ffaae73b030
        public void UpdateVisuals(){} // RVA: 0x7ffaae73b230
        public void UpdateVisualsInEditor(){} // RVA: 0x7ffaae73b350
        public void CalculateBounds(){} // RVA: 0x7ffaae73b540
        public void .ctor(){} // RVA: 0x7ffaae73b7b0
        // ── Binary Analysis Named ──
        public void SetAlpha(){} // RVA: 0x7ffaae73b100
        public void GetTintColor(){} // RVA: 0x7ffaae73b780
    }

    public class TeleportMarkerBase : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_showReticle(){} // RVA: 0x7ffaa8a17850
        public void TeleportPlayer(){} // RVA: 0x7ffaa8932310
        public void UpdateVisuals(){} // RVA: 0x7ffaa8660cc0
        public void Highlight(){} // RVA: 0x7ffaa86613a0
        public void ShouldActivate(){} // RVA: 0x7ffaa864a2a0
        public void ShouldMovePlayer(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaae73b830
        // ── Binary Analysis Named ──
        public void SetLocked(){} // RVA: 0x7ffaae73b810
        public void SetAlpha(){}
    }

    public class TeleportPoint : TeleportMarkerBase
    {
        public object switchToScene; // 0x33C06520
        public object titleLockedColor; // 0x33C06520
        public object markerMesh; // 0x33C06520
        public object lockedIcon; // 0x33C06520
        public object animation; // 0x33C06520
        public object lookAtPosition; // 0x33C06520
        public object titleColor; // 0x33C06520
        public object moveLocationAnimation; // 0x33C06520
        public object 8؏f; // 0x673FE154
        public object 8؏f; // 0x673FE169
        public object 8؏f; // 0x66FF93B6
        public object 8؏f; // 0x673FE1A1

        // ── Original Methods ──
        public void get_showReticle(){} // RVA: 0x7ffaa8932320
        public void Awake(){} // RVA: 0x7ffaae73b880
        public void Start(){} // RVA: 0x7ffaae73bba0
        public void Update(){} // RVA: 0x7ffaae73bc10
        public void ShouldActivate(){} // RVA: 0x7ffaae73be60
        public void ShouldMovePlayer(){} // RVA: 0x7ffaa8a17850
        public void Highlight(){} // RVA: 0x7ffaae73bff0
        public void UpdateVisuals(){} // RVA: 0x7ffaae73c2d0
        public void TeleportToScene(){} // RVA: 0x7ffaae73cb20
        public void ReleaseRelevantComponents(){} // RVA: 0x7ffaae73d550
        public void UpdateVisualsInEditor(){} // RVA: 0x7ffaae73d760
        public void .ctor(){} // RVA: 0x7ffaae73dc30
        // ── Binary Analysis Named ──
        public void SetAlpha(){} // RVA: 0x7ffaae73c510
        public void SetMeshMaterials(){} // RVA: 0x7ffaae73c950
        public void GetRelevantComponents(){} // RVA: 0x7ffaae73cc10
    }

    public class TeleportURPHelper : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Throwable : MonoBehaviour
    {
        public object catchingSpeedThreshold; // 0x337E69D0
        public object scaleReleaseVelocity; // 0x337E69D0
        public object restoreOriginalParent; // 0x337E69D0
        public object attachTime; // 0x337E69D0
        public object attachEaseInTransform; // 0x337E69D0
        public object onHeldUpdate; // 0x337E69D0
        public object interactable; // 0x337E69D0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae711280
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae711510
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae7116e0
        public void HandHoverUpdate(){} // RVA: 0x7ffaae711710
        public void OnAttachedToHand(){} // RVA: 0x7ffaae7117d0
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae711ba0
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae712590
        public void LateDetach(){} // RVA: 0x7ffaae7126a0
        public void OnHandFocusAcquired(){} // RVA: 0x7ffaae7127a0
        public void OnHandFocusLost(){} // RVA: 0x7ffaae712920
        public void .ctor(){} // RVA: 0x7ffaae706e90
        // ── Binary Analysis Named ──
        public void GetReleaseVelocities(){} // RVA: 0x7ffaae711d80
    }

    public class UIElement : MonoBehaviour
    {
        public object oldParent; // 0x33A76710

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae712c10
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae712d60
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae713000
        public void HandHoverUpdate(){} // RVA: 0x7ffaae7132c0
        public void OnButtonClick(){} // RVA: 0x7ffaae7134e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Unparent : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae713530
        public void Update(){} // RVA: 0x7ffaae7137e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetOldParent(){} // RVA: 0x7ffaa89600c0
    }

    public class Util : Object
    {
        public object InchesToMeters; // 0x30B937E0
        public object MetersToInches; // 0x30B937E0
        public object KilometersToMiles; // 0x30B937E0
        public object `;

        // ── Original Methods ──
        public void RemapNumber(){} // RVA: 0x7ffaae713910
        public void RemapNumberClamped(){} // RVA: 0x7ffaae713930
        public void Approach(){} // RVA: 0x7ffaae7139a0
        public void BezierInterpolate3(){} // RVA: 0x7ffaae7139d0
        public void BezierInterpolate4(){} // RVA: 0x7ffaae713b60
        public void Vector3FromString(){} // RVA: 0x7ffaae713e10
        public void Vector2FromString(){} // RVA: 0x7ffaae713f30
        public void Normalize(){} // RVA: 0x7ffaae714020
        public void Vector2AsVector3(){} // RVA: 0x7ffaa899a3f0
        public void Vector3AsVector2(){} // RVA: 0x7ffaa899a3d0
        public void AngleOf(){} // RVA: 0x7ffaae714030
        public void YawOf(){} // RVA: 0x7ffaae714090
        public void Swap(){} // RVA: 0x7ffaa8660fc0
        public void Shuffle(){} // RVA: 0x7ffaa8660d50
        public void Shuffle(){} // RVA: 0x7ffaa8660d50
        public void RandomWithLookback(){} // RVA: 0x7ffaae7140e0
        public void FindChild(){} // RVA: 0x7ffaae7142c0
        public void IsNullOrEmpty(){} // RVA: 0x7ffaa864a120
        public void IsValidIndex(){} // RVA: 0x7ffaa864c0f0
        public void IsValidIndex(){} // RVA: 0x7ffaa864c0f0
        public void FindOrAdd(){} // RVA: 0x7ffaa887e5c0
        public void FindAndRemove(){} // RVA: 0x7ffaa8649330
        public void FindOrAddComponent(){} // RVA: 0x7ffaa887e5c0
        public void FastRemove(){} // RVA: 0x7ffaa86666b0
        public void ReplaceGameObject(){} // RVA: 0x7ffaa887e5c0
        public void SwitchLayerRecursively(){} // RVA: 0x7ffaae714570
        public void DrawCross(){} // RVA: 0x7ffaae7147a0
        public void ResetTransform(){} // RVA: 0x7ffaae714df0
        public void ClosestPointOnLine(){} // RVA: 0x7ffaae714f90
        public void AfterTimer(){} // RVA: 0x7ffaae715250
        public void SendPhysicsMessage(){} // RVA: 0x7ffaae715620
        public void SendPhysicsMessage(){} // RVA: 0x7ffaae715620
        public void IgnoreCollisions(){} // RVA: 0x7ffaae715910
        public void WrapCoroutine(){} // RVA: 0x7ffaae715ab0
        public void ColorWithAlpha(){} // RVA: 0x7ffaa909ef50
        public void Quit(){} // RVA: 0x7ffaae715bb0
        public void FloatToDecimal(){} // RVA: 0x7ffaae715be0
        public void Median(){} // RVA: 0x7ffaa887e5c0
        public void ForEach(){} // RVA: 0x7ffaa8660fc0
        public void FixupNewlines(){} // RVA: 0x7ffaae715d00
        public void PathLength(){} // RVA: 0x7ffaae715dc0
        public void HasCommandLineArgument(){} // RVA: 0x7ffaae715fa0
        public void CombinePaths(){} // RVA: 0x7ffaae716310
        // ── Binary Analysis Named ──
        public void GetCommandLineArgValue(){} // RVA: 0x7ffaae716120
        public void GetCommandLineArgValue(){} // RVA: 0x7ffaae716120
        public void SetActive(){} // RVA: 0x7ffaae716200
    }

    public class VelocityEstimator : MonoBehaviour
    {
        public object estimateOnAwake; // 0x3385FE20
        public object velocitySamples; // 0x3385FE20

        // ── Original Methods ──
        public void FinishEstimatingVelocity(){} // RVA: 0x7ffaae716950
        public void Awake(){} // RVA: 0x7ffaae716e10
        public void EstimateVelocityCoroutine(){} // RVA: 0x7ffaae716f30
        public void .ctor(){} // RVA: 0x7ffaae716fd0
        // ── Binary Analysis Named ──
        public void BeginEstimatingVelocity(){} // RVA: 0x7ffaae716830
        public void GetVelocityEstimate(){} // RVA: 0x7ffaae7169d0
        public void GetAngularVelocityEstimate(){} // RVA: 0x7ffaae716b00
        public void GetAccelerationEstimate(){} // RVA: 0x7ffaae716c30
    }

}