// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
// Classes: 25
// Methods: 109

namespace ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
{
    public class AmbientSound : MonoBehaviour
    {
        public t s; // 0x20
        public float fadeintime; // 0x28
        public float t; // 0x2C
        public bool fadeblack; // 0x30
        public float vol; // 0x34

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5413BD80
        public void Update(){} // RVA: 0x7FFD5413C090
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BuggyBuddy : MonoBehaviour
    {
        public object turret; // 0x20
        public float turretRot; // 0x28
        public float maxAngle; // 0x2C
        public float maxTurnTorque; // 0x30
        public float maxTorque; // 0x34
        public float brakeTorque; // 0x38
        public BuffersImpl[] wheelRenders; // 0x40
        public float criticalSpeed; // 0x48
        public int stepsBelow; // 0x4C
        public int stepsAbove; // 0x50
        public cessorType[] m_Wheels; // 0x58
        public t au_motor; // 0x60
        public float mvol; // 0x68
        public t au_skid; // 0x70
        public float svol; // 0x78
        public rted.? skidsample; // 0x80
        public float skidSpeed; // 0x88
        public amut localGravity; // 0x8C
        public Touched body; // 0x98
        public float rapidfireTime; // 0xA0
        public float shootTimer; // 0xA4
        public tionX steer; // 0xA8
        public float throttle; // 0xB0
        public float handBrake; // 0xB4
        public object controllerReference; // 0xB8
        public float speed; // 0xC0
        public object centerOfMass; // 0xC8

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5413C140
        public void Update(){} // RVA: 0x7FFD5413C4F0
        public void FixedUpdate(){} // RVA: 0x7FFD5413D140
        public void FindAngle(){} // RVA: 0x7FFD5413D1D0
        public void .ctor(){} // RVA: 0x7FFD5413D3A0
    }

    public class BuggyController : MonoBehaviour
    {
        public object modelJoystick; // 0x20
        public float joystickRot; // 0x28
        public object modelTrigger; // 0x30
        public float triggerRot; // 0x38
        public rted.ameId buggy; // 0x40
        public object buttonBrake; // 0x48
        public object buttonReset; // 0x50
        public pad ui_Canvas; // 0x58
        public ePathName117.ÎÌÍÍÎÏÌ ui_rpm; // 0x60
        public ePathName117.ÎÌÍÍÎÏÌ ui_speed; // 0x68
        public 16 ui_steer; // 0x70
        public float ui_steerangle; // 0x78
        public tionX ui_fillAngles; // 0x7C
        public object resetToPoint; // 0x88
        public tartWrappedLong actionSteering; // 0x90
        public rify actionThrottle; // 0x98
        public or actionBrake; // 0xA0
        public or actionReset; // 0xA8
        public float usteer; // 0xB0
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0xB8
        public R_12x12 trigSRot; // 0xC0
        public R_12x12 joySRot; // 0xD0
        public ts resettingRoutine; // 0xE0
        public amut initialScale; // 0xE8
        public float buzztimer; // 0xF4

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5413D420
        public void Update(){} // RVA: 0x7FFD5413D7B0
        public void DoReset(){} // RVA: 0x7FFD5413E310
        public void DoBuzz(){} // RVA: 0x7FFD5413E3B0
        public void .ctor(){} // RVA: 0x7FFD5413E450
    }

    public class ButtonEffect : MonoBehaviour
    {
        // ── Methods ──
        public void OnButtonDown(){} // RVA: 0x7FFD54145490
        public void OnButtonUp(){} // RVA: 0x7FFD54145510
        public void ColorSelf(){} // RVA: 0x7FFD54145540
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ButtonExample : MonoBehaviour
    {
        public Source_Map.thumbDistal hoverButton; // 0x20
        public BuffersImpl prefab; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54145660
        public void OnButtonDown(){} // RVA: 0x7FFD54145720
        public void DoPlant(){} // RVA: 0x7FFD541457D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ControllerHintsExample : MonoBehaviour
    {
        public ts buttonHintCoroutine; // 0x20
        public ts textHintCoroutine; // 0x28

        // ── Methods ──
        public void ShowButtonHints(){} // RVA: 0x7FFD541464B0
        public void ShowTextHints(){} // RVA: 0x7FFD541465E0
        public void DisableHints(){} // RVA: 0x7FFD54146710
        public void TestButtonHints(){} // RVA: 0x7FFD54146850
        public void TestTextHints(){} // RVA: 0x7FFD541468F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CustomSkeletonHelper : MonoBehaviour
    {
        public hMap wrist; // 0x20
        public ÍÏÏÎÎÍÎÌÎÏÍÎÌÏ[] fingers; // 0x28
        public ÎÎÌÎÌ[] thumbs; // 0x30

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD54147210
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FloppyHand : MonoBehaviour
    {
        public float fingerFlexAngle; // 0x20
        public rify squeezyAction; // 0x28
        public 2EA1BA7A405A72DE inputSource; // 0x30
        public ÍÏÏÎÎÍÎÌÎÏÍÎÌÏ[] fingers; // 0x38
        public amut constforce; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54147A70
        public void Update(){} // RVA: 0x7FFD54147BD0
        public void .ctor(){} // RVA: 0x7FFD54147F10
    }

    public class FlowerPlanted : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD541499A0
        public void Plant(){} // RVA: 0x7FFD541499A0
        public void DoPlant(){} // RVA: 0x7FFD54149A50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Grenade : MonoBehaviour
    {
        public BuffersImpl explodePartPrefab; // 0x20
        public int explodeCount; // 0x28
        public float minMagnitudeToExplode; // 0x2C
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD541416B0
        public void OnCollisionEnter(){} // RVA: 0x7FFD54141740
        public void .ctor(){} // RVA: 0x7FFD54141E20
    }

    public class InteractableExample : MonoBehaviour
    {
        public ED54E9924CA80D32FD85A52A959E03 generalText; // 0x20
        public ED54E9924CA80D32FD85A52A959E03 hoveringText; // 0x28
        public amut oldPosition; // 0x30
        public R_12x12 oldRotation; // 0x3C
        public float attachTime; // 0x4C
        public x attachmentFlags; // 0x50
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0x58
        public bool lastHovering; // 0x60

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5414A900
        public void OnHandHoverBegin(){} // RVA: 0x7FFD5414ABB0
        public void OnHandHoverEnd(){} // RVA: 0x7FFD5414AC70
        public void HandHoverUpdate(){} // RVA: 0x7FFD5414AD10
        public void OnAttachedToHand(){} // RVA: 0x7FFD5414B220
        public void OnDetachedFromHand(){} // RVA: 0x7FFD5414B360
        public void HandAttachedUpdate(){} // RVA: 0x7FFD5414B450
        public void Update(){} // RVA: 0x7FFD5414B5D0
        public void OnHandFocusAcquired(){} // RVA: 0x7FFD4E341310
        public void OnHandFocusLost(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD5414B720
    }

    public class JoeJeff : MonoBehaviour
    {
        public float animationSpeed; // 0x20
        public float jumpVelocity; // 0x24
        public float m_MovingTurnSpeed; // 0x28
        public float m_StationaryTurnSpeed; // 0x2C
        public float airControl; // 0x30
        public float frictionTime; // 0x34
        public float footHeight; // 0x38
        public float footRadius; // 0x3C
        public ColorScaleAndOffset footHit; // 0x40
        public bool isGrounded; // 0x6C
        public float turnAmount; // 0x70
        public float forwardAmount; // 0x74
        public float groundedTime; // 0x78
        public stfix animator; // 0x80
        public amut input; // 0x88
        public bool held; // 0x94
        public Touched rigidbody; // 0x98
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0xA0
        public Source_Map.e fire; // 0xA8
        public float jumpTimer; // 0xB0

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54141E80
        public void Update(){} // RVA: 0x7FFD54142070
        public void FixRotation(){} // RVA: 0x7FFD54142240
        public void OnAnimatorMove(){} // RVA: 0x7FFD541425D0
        public void Move(){} // RVA: 0x7FFD54142A60
        public void UpdateAnimator(){} // RVA: 0x7FFD54142D20
        public void ApplyExtraTurnRotation(){} // RVA: 0x7FFD54143070
        public void CheckGrounded(){} // RVA: 0x7FFD541431B0
        public void FixedUpdate(){} // RVA: 0x7FFD54143640
        public void HandleGroundedMovement(){} // RVA: 0x7FFD54143930
        public void Jump(){} // RVA: 0x7FFD54143950
        public void .ctor(){} // RVA: 0x7FFD54143C00
    }

    public class JoeJeffController : MonoBehaviour
    {
        public object Joystick; // 0x20
        public float joyMove; // 0x28
        public tartWrappedLong moveAction; // 0x30
        public or jumpAction; // 0x38
        public rted.eLinearMapping character; // 0x40
        public rical jumpHighlight; // 0x48
        public amut movement; // 0x50
        public bool jump; // 0x5C
        public float glow; // 0x60
        public 2EA1BA7A405A72DE hand; // 0x64
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54143C70
        public void Update(){} // RVA: 0x7FFD54143D00
        public void .ctor(){} // RVA: 0x7FFD541444B0
    }

    public class JoeJeffGestures : MonoBehaviour
    {
        public float openFingerAmount;
        public float closedFingerAmount;
        public float closedThumbAmount;
        public rted.eLinearMapping joeJeff; // 0x20
        public bool lastPeaceSignState; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54144680
        public void Update(){} // RVA: 0x7FFD54144710
        public void PeaceSignRecognized(){} // RVA: 0x7FFD54144CC0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LockToPoint : MonoBehaviour
    {
        public object snapTo; // 0x20
        public Touched body; // 0x28
        public float snapTime; // 0x30
        public float dropTimer; // 0x34
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5413F3E0
        public void FixedUpdate(){} // RVA: 0x7FFD5413F500
        public void .ctor(){} // RVA: 0x7FFD54140170
    }

    public class Planting : MonoBehaviour
    {
        public or plantAction; // 0x20
        public Source_Map.ÌÎ hand; // 0x28
        public BuffersImpl prefabToPlant; // 0x30

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD5414B770
        public void OnDisable(){} // RVA: 0x7FFD5414BA30
        public void OnPlantActionChange(){} // RVA: 0x7FFD5414BBC0
        public void Plant(){} // RVA: 0x7FFD5414BC70
        public void DoPlant(){} // RVA: 0x7FFD5414BD20
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ProceduralHats : MonoBehaviour
    {
        public BuffersImpl[] hats; // 0x20
        public float hatSwitchTime; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54144D00
        public void OnEnable(){} // RVA: 0x7FFD54144D10
        public void HatSwitcher(){} // RVA: 0x7FFD54144DC0
        public void ChooseHat(){} // RVA: 0x7FFD54144E60
        public void SwitchToHat(){} // RVA: 0x7FFD54144EE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class RenderModelChangerUI : UIElement
    {
        public BuffersImpl leftPrefab; // 0x30
        public BuffersImpl rightPrefab; // 0x38
        public rted.? ui; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5414CBC0
        public void OnButtonClick(){} // RVA: 0x7FFD5414CDA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SkeletonUIOptions : MonoBehaviour
    {
        // ── Methods ──
        public void AnimateHandWithController(){} // RVA: 0x7FFD5414D020
        public void AnimateHandWithoutController(){} // RVA: 0x7FFD5414D190
        public void ShowController(){} // RVA: 0x7FFD5414D300
        public void SetRenderModel(){} // RVA: 0x7FFD5414D450
        public void HideController(){} // RVA: 0x7FFD5414D5E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SquishyToy : MonoBehaviour
    {
        public Source_Map.ÍÎÍÎÍÎÎÏÎÌÏÍ interactable; // 0x20
        public ure renderer; // 0x28
        public bool affectMaterial; // 0x30
        public rify gripSqueeze; // 0x38
        public rify pinchSqueeze; // 0x40
        public Touched rigidbody; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5414E9E0
        public void Update(){} // RVA: 0x7FFD5414ED30
        public void .ctor(){} // RVA: 0x7FFD5414F360
    }

    public class TargetHitEffect : MonoBehaviour
    {
        public riteCharacterUnicode targetCollider; // 0x20
        public BuffersImpl spawnObjectOnCollision; // 0x28
        public bool colorSpawnedObject; // 0x30
        public bool destroyOnTargetCollision; // 0x31

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFD5414D730
        public void .ctor(){} // RVA: 0x7FFD5414E100
    }

    public class TargetMeasurement : MonoBehaviour
    {
        public BuffersImpl visualWrapper; // 0x20
        public object measurementTape; // 0x28
        public object endPoint; // 0x30
        public ePathName117.? measurementTextM; // 0x38
        public ePathName117.? measurementTextFT; // 0x40
        public float maxDistanceToDraw; // 0x48
        public bool drawTape; // 0x4C
        public float lastDistance; // 0x50

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD5414E150
        public void .ctor(){} // RVA: 0x7FFD5414E990
    }

    public class WheelDust : MonoBehaviour
    {
        public cessorType col; // 0x20
        public InDuration p; // 0x28
        public float EmissionMul; // 0x30
        public float velocityMul; // 0x34
        public float maxEmission; // 0x38
        public float minSlip; // 0x3C
        public float amt; // 0x40
        public amut slip; // 0x44
        public float emitTimer; // 0x50

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54140D20
        public void Update(){} // RVA: 0x7FFD54140E60
        public void emitter(){} // RVA: 0x7FFD541410E0
        public void DoEmit(){} // RVA: 0x7FFD54141180
        public void .ctor(){} // RVA: 0x7FFD54141500
    }

    public class trackCam : MonoBehaviour
    {
        public float speed; // 0x20
        public bool negative; // 0x24

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD541401C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class trackObj : MonoBehaviour
    {
        public object target; // 0x20
        public float speed; // 0x28
        public bool negative; // 0x2C

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD541407D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}