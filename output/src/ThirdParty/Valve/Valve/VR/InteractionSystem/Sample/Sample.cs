// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
// Classes: 25
// Methods: 109

namespace ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
{
    public class AmbientSound : MonoBehaviour
    {
        public object s;
        public object fadeintime;
        public object t;
        public object fadeblack;
        public object vol;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF2A80
        public void Update(){} // RVA: 0x6FF2D90
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BuggyBuddy : MonoBehaviour
    {
        public object turret;
        public object turretRot;
        public object maxAngle;
        public object maxTurnTorque;
        public object maxTorque;
        public object brakeTorque;
        public object wheelRenders;
        public object criticalSpeed;
        public object stepsBelow;
        public object stepsAbove;
        public object m_Wheels;
        public object au_motor;
        public object mvol;
        public object au_skid;
        public object svol;
        public object skidsample;
        public object skidSpeed;
        public object localGravity;
        public object body;
        public object rapidfireTime;
        public object shootTimer;
        public object steer;
        public object throttle;
        public object handBrake;
        public object controllerReference;
        public object speed;
        public object centerOfMass;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF2E40
        public void Update(){} // RVA: 0x6FF3240
        public void FixedUpdate(){} // RVA: 0x6FF3E50
        public void FindAngle(){} // RVA: 0x6FF3F20
        public void .ctor(){} // RVA: 0x6FF4110
    }

    public class BuggyController : MonoBehaviour
    {
        public object modelJoystick;
        public object joystickRot;
        public object modelTrigger;
        public object triggerRot;
        public object buggy;
        public object buttonBrake;
        public object buttonReset;
        public object ui_Canvas;
        public object ui_rpm;
        public object ui_speed;
        public object ui_steer;
        public object ui_steerangle;
        public object ui_fillAngles;
        public object resetToPoint;
        public object actionSteering;
        public object actionThrottle;
        public object actionBrake;
        public object actionReset;
        public object usteer;
        public object interactable;
        public object trigSRot;
        public object joySRot;
        public object resettingRoutine;
        public object initialScale;
        public object buzztimer;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF4190
        public void Update(){} // RVA: 0x6FF4560
        public void DoReset(){} // RVA: 0x6FF5100
        public void DoBuzz(){} // RVA: 0x6FF51A0
        public void .ctor(){} // RVA: 0x6FF5240
    }

    public class ButtonEffect : MonoBehaviour
    {
        // ── Methods ──
        public void OnButtonDown(){} // RVA: 0x6FFC5F0
        public void OnButtonUp(){} // RVA: 0x6FFC670
        public void ColorSelf(){} // RVA: 0x6FFC6A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ButtonExample : MonoBehaviour
    {
        public object hoverButton;
        public object prefab;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FFC810
        public void OnButtonDown(){} // RVA: 0x6FFC8D0
        public void DoPlant(){} // RVA: 0x6FFC980
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ControllerHintsExample : MonoBehaviour
    {
        public object buttonHintCoroutine;
        public object textHintCoroutine;

        // ── Methods ──
        public void ShowButtonHints(){} // RVA: 0x6FFD610
        public void ShowTextHints(){} // RVA: 0x6FFD740
        public void DisableHints(){} // RVA: 0x6FFD870
        public void TestButtonHints(){} // RVA: 0x6FFD9C0
        public void TestTextHints(){} // RVA: 0x6FFDA60
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CustomSkeletonHelper : MonoBehaviour
    {
        public object wrist;
        public object fingers;
        public object thumbs;

        // ── Methods ──
        public void Update(){} // RVA: 0x6FFE380
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class FloppyHand : MonoBehaviour
    {
        public object fingerFlexAngle;
        public object squeezyAction;
        public object inputSource;
        public object fingers;
        public object constforce;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FFEFF0
        public void Update(){} // RVA: 0x6FFF140
        public void .ctor(){} // RVA: 0x6FFF4D0
    }

    public class FlowerPlanted : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7000F20
        public void Plant(){} // RVA: 0x7000F20
        public void DoPlant(){} // RVA: 0x7000FD0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Grenade : MonoBehaviour
    {
        public object explodePartPrefab;
        public object explodeCount;
        public object minMagnitudeToExplode;
        public object interactable;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF8600
        public void OnCollisionEnter(){} // RVA: 0x6FF8690
        public void .ctor(){} // RVA: 0x6FF8F20
    }

    public class InteractableExample : MonoBehaviour
    {
        public object generalText;
        public object hoveringText;
        public object oldPosition;
        public object oldRotation;
        public object attachTime;
        public object attachmentFlags;
        public object interactable;
        public object lastHovering;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7001E10
        public void OnHandHoverBegin(){} // RVA: 0x7002000
        public void OnHandHoverEnd(){} // RVA: 0x7002080
        public void HandHoverUpdate(){} // RVA: 0x70020D0
        public void OnAttachedToHand(){} // RVA: 0x7002530
        public void OnDetachedFromHand(){} // RVA: 0x7002640
        public void HandAttachedUpdate(){} // RVA: 0x7002700
        public void Update(){} // RVA: 0x7002830
        public void OnHandFocusAcquired(){} // RVA: 0xB43310
        public void OnHandFocusLost(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x7002930
    }

    public class JoeJeff : MonoBehaviour
    {
        public object animationSpeed;
        public object jumpVelocity;
        public object m_MovingTurnSpeed;
        public object m_StationaryTurnSpeed;
        public object airControl;
        public object frictionTime;
        public object footHeight;
        public object footRadius;
        public object footHit;
        public object isGrounded;
        public object turnAmount;
        public object forwardAmount;
        public object groundedTime;
        public object animator;
        public object input;
        public object held;
        public object rigidbody;
        public object interactable;
        public object fire;
        public object jumpTimer;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF8F80
        public void Update(){} // RVA: 0x6FF9130
        public void FixRotation(){} // RVA: 0x6FF92E0
        public void OnAnimatorMove(){} // RVA: 0x6FF95F0
        public void Move(){} // RVA: 0x6FF9B40
        public void UpdateAnimator(){} // RVA: 0x6FF9DF0
        public void ApplyExtraTurnRotation(){} // RVA: 0x6FFA130
        public void CheckGrounded(){} // RVA: 0x6FFA250
        public void FixedUpdate(){} // RVA: 0x6FFA6E0
        public void HandleGroundedMovement(){} // RVA: 0x6FFAA90
        public void Jump(){} // RVA: 0x6FFAAB0
        public void .ctor(){} // RVA: 0x6FFAE00
    }

    public class JoeJeffController : MonoBehaviour
    {
        public object Joystick;
        public object joyMove;
        public object moveAction;
        public object jumpAction;
        public object character;
        public object jumpHighlight;
        public object movement;
        public object jump;
        public object glow;
        public object hand;
        public object interactable;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FFAE70
        public void Update(){} // RVA: 0x6FFAF00
        public void .ctor(){} // RVA: 0x6FFB610
    }

    public class JoeJeffGestures : MonoBehaviour
    {
        public object openFingerAmount;
        public object closedFingerAmount;
        public object closedThumbAmount;
        public object joeJeff;
        public object lastPeaceSignState;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FFB7E0
        public void Update(){} // RVA: 0x6FFB870
        public void PeaceSignRecognized(){} // RVA: 0x6FFBDF0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LockToPoint : MonoBehaviour
    {
        public object snapTo;
        public object body;
        public object snapTime;
        public object dropTimer;
        public object interactable;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF61E0
        public void FixedUpdate(){} // RVA: 0x6FF6300
        public void .ctor(){} // RVA: 0x6FF7050
    }

    public class Planting : MonoBehaviour
    {
        public object plantAction;
        public object hand;
        public object prefabToPlant;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7002980
        public void OnDisable(){} // RVA: 0x7002C40
        public void OnPlantActionChange(){} // RVA: 0x7002DD0
        public void Plant(){} // RVA: 0x7002E80
        public void DoPlant(){} // RVA: 0x7002F30
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ProceduralHats : MonoBehaviour
    {
        public object hats;
        public object hatSwitchTime;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FFBE30
        public void OnEnable(){} // RVA: 0x6FFBE40
        public void HatSwitcher(){} // RVA: 0x6FFBEF0
        public void ChooseHat(){} // RVA: 0x6FFBF90
        public void SwitchToHat(){} // RVA: 0x6FFC010
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class RenderModelChangerUI : UIElement
    {
        public object leftPrefab;
        public object rightPrefab;
        public object ui;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7003DA0
        public void OnButtonClick(){} // RVA: 0x7003F80
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SkeletonUIOptions : MonoBehaviour
    {
        // ── Methods ──
        public void AnimateHandWithController(){} // RVA: 0x7004220
        public void AnimateHandWithoutController(){} // RVA: 0x70043A0
        public void ShowController(){} // RVA: 0x7004520
        public void SetRenderModel(){} // RVA: 0x7004680
        public void HideController(){} // RVA: 0x7004810
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SquishyToy : MonoBehaviour
    {
        public object interactable;
        public object renderer;
        public object affectMaterial;
        public object gripSqueeze;
        public object pinchSqueeze;
        public object rigidbody;

        // ── Methods ──
        public void Start(){} // RVA: 0x7005CC0
        public void Update(){} // RVA: 0x7006010
        public void .ctor(){} // RVA: 0x7006560
    }

    public class TargetHitEffect : MonoBehaviour
    {
        public object targetCollider;
        public object spawnObjectOnCollision;
        public object colorSpawnedObject;
        public object destroyOnTargetCollision;

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7004970
        public void .ctor(){} // RVA: 0x7005390
    }

    public class TargetMeasurement : MonoBehaviour
    {
        public object visualWrapper;
        public object measurementTape;
        public object endPoint;
        public object measurementTextM;
        public object measurementTextFT;
        public object maxDistanceToDraw;
        public object drawTape;
        public object lastDistance;

        // ── Methods ──
        public void Update(){} // RVA: 0x70053E0
        public void .ctor(){} // RVA: 0x7005C70
    }

    public class WheelDust : MonoBehaviour
    {
        public object col;
        public object p;
        public object EmissionMul;
        public object velocityMul;
        public object maxEmission;
        public object minSlip;
        public object amt;
        public object slip;
        public object emitTimer;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FF7BF0
        public void Update(){} // RVA: 0x6FF7D30
        public void emitter(){} // RVA: 0x6FF8030
        public void DoEmit(){} // RVA: 0x6FF80D0
        public void .ctor(){} // RVA: 0x6FF8450
    }

    public class trackCam : MonoBehaviour
    {
        public object speed;
        public object negative;

        // ── Methods ──
        public void Update(){} // RVA: 0x6FF70A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class trackObj : MonoBehaviour
    {
        public object target;
        public object speed;
        public object negative;

        // ── Methods ──
        public void Update(){} // RVA: 0x6FF7650
        public void .ctor(){} // RVA: 0xB43D60
    }

}