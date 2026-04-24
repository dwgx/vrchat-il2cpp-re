// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
// Classes: 25
// Methods: 109

namespace ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
{
    public class AmbientSound : MonoBehaviour
    {
        public object t; // 0x33630030
        public object turret; // 0x3358BE00

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae73dce0
        public void Update(){} // RVA: 0x7ffaae73dff0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class BuggyBuddy : MonoBehaviour
    {
        public object maxAngle; // 0x3358BE00
        public object brakeTorque; // 0x3358BE00
        public object stepsBelow; // 0x3358BE00
        public object au_motor; // 0x3358BE00
        public object svol; // 0x3358BE00
        public object localGravity; // 0x3358BE00
        public object shootTimer; // 0x3358BE00
        public object handBrake; // 0x3358BE00
        public object centerOfMass; // 0x3358BE00
        public object EmissionMul; // 0x333FD860
        public object minSlip; // 0x333FD860
        public object emitTimer; // 0x333FD860

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae73e0a0
        public void Update(){} // RVA: 0x7ffaae73e450
        public void FixedUpdate(){} // RVA: 0x7ffaae73f0a0
        public void FindAngle(){} // RVA: 0x7ffaae73f130
        public void .ctor(){} // RVA: 0x7ffaae73f300
    }

    public class BuggyController : MonoBehaviour
    {
        public object modelTrigger; // 0x338CCAE0
        public object buttonBrake; // 0x338CCAE0
        public object ui_rpm; // 0x338CCAE0
        public object ui_steerangle; // 0x338CCAE0
        public object actionSteering; // 0x338CCAE0
        public object actionReset; // 0x338CCAE0
        public object trigSRot; // 0x338CCAE0
        public object initialScale; // 0x338CCAE0
        public object snapTime; // 0x3357CA50
        public object speed; // 0x339FFDA0
        public object speed; // 0x3397D7E0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae73f380
        public void Update(){} // RVA: 0x7ffaae73f710
        public void .ctor(){} // RVA: 0x7ffaae7403b0
        // ── Binary Analysis Named ──
        public void DoReset(){} // RVA: 0x7ffaae740270
        public void DoBuzz(){} // RVA: 0x7ffaae740310
    }

    public class ButtonEffect : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnButtonDown(){} // RVA: 0x7ffaae7473f0
        public void OnButtonUp(){} // RVA: 0x7ffaae747470
        public void ColorSelf(){} // RVA: 0x7ffaae7474a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ButtonExample : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae7475c0
        public void OnButtonDown(){} // RVA: 0x7ffaae747680
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void DoPlant(){} // RVA: 0x7ffaae747730
    }

    public class ControllerHintsExample : MonoBehaviour
    {
        // ── Original Methods ──
        public void ShowButtonHints(){} // RVA: 0x7ffaae748410
        public void ShowTextHints(){} // RVA: 0x7ffaae748540
        public void DisableHints(){} // RVA: 0x7ffaae748670
        public void TestButtonHints(){} // RVA: 0x7ffaae7487b0
        public void TestTextHints(){} // RVA: 0x7ffaae748850
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CustomSkeletonHelper : MonoBehaviour
    {
        public object thumbs; // 0x335381B0

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaae749170
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class FloppyHand : MonoBehaviour
    {
        public object inputSource; // 0x334570A0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae7499d0
        public void Update(){} // RVA: 0x7ffaae749b30
        public void .ctor(){} // RVA: 0x7ffaae749e70
    }

    public class FlowerPlanted : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae74b900
        public void Plant(){} // RVA: 0x7ffaae74b900
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void DoPlant(){} // RVA: 0x7ffaae74b9b0
    }

    public class Grenade : MonoBehaviour
    {
        public object minMagnitudeToExplode; // 0x33323C30
        public object jumpVelocity; // 0x33563740

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae743610
        public void OnCollisionEnter(){} // RVA: 0x7ffaae7436a0
        public void .ctor(){} // RVA: 0x7ffaae743d80
    }

    public class InteractableExample : MonoBehaviour
    {
        public object oldPosition; // 0x33914030
        public object attachmentFlags; // 0x33914030

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae74c860
        public void OnHandHoverBegin(){} // RVA: 0x7ffaae74cb10
        public void OnHandHoverEnd(){} // RVA: 0x7ffaae74cbd0
        public void HandHoverUpdate(){} // RVA: 0x7ffaae74cc70
        public void OnAttachedToHand(){} // RVA: 0x7ffaae74d180
        public void OnDetachedFromHand(){} // RVA: 0x7ffaae74d2c0
        public void HandAttachedUpdate(){} // RVA: 0x7ffaae74d3b0
        public void Update(){} // RVA: 0x7ffaae74d530
        public void OnHandFocusAcquired(){} // RVA: 0x7ffaa8932310
        public void OnHandFocusLost(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaae74d680
    }

    public class JoeJeff : MonoBehaviour
    {
        public object m_MovingTurnSpeed; // 0x33563740
        public object frictionTime; // 0x33563740
        public object footHit; // 0x33563740
        public object forwardAmount; // 0x33563740
        public object input; // 0x33563740
        public object interactable; // 0x33563740
        public object Joystick; // 0x33549510
        public object jumpAction; // 0x33549510
        public object movement; // 0x33549510
        public object hand; // 0x33549510

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae743de0
        public void Update(){} // RVA: 0x7ffaae743fd0
        public void FixRotation(){} // RVA: 0x7ffaae7441a0
        public void OnAnimatorMove(){} // RVA: 0x7ffaae744530
        public void Move(){} // RVA: 0x7ffaae7449c0
        public void UpdateAnimator(){} // RVA: 0x7ffaae744c80
        public void ApplyExtraTurnRotation(){} // RVA: 0x7ffaae744fd0
        public void FixedUpdate(){} // RVA: 0x7ffaae7455a0
        public void HandleGroundedMovement(){} // RVA: 0x7ffaae745890
        public void Jump(){} // RVA: 0x7ffaae7458b0
        public void .ctor(){} // RVA: 0x7ffaae745b60
        // ── Binary Analysis Named ──
        public void CheckGrounded(){} // RVA: 0x7ffaae745110
    }

    public class JoeJeffController : MonoBehaviour
    {
        public object moveAction; // 0x33549510
        public object jumpHighlight; // 0x33549510
        public object glow; // 0x33549510
        public object openFingerAmount; // 0x33685FC0
        public object joeJeff; // 0x33685FC0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae745bd0
        public void Update(){} // RVA: 0x7ffaae745c60
        public void .ctor(){} // RVA: 0x7ffaae746410
    }

    public class JoeJeffGestures : MonoBehaviour
    {
        public object closedThumbAmount; // 0x33685FC0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae7465e0
        public void Update(){} // RVA: 0x7ffaae746670
        public void PeaceSignRecognized(){} // RVA: 0x7ffaae746c20
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LockToPoint : MonoBehaviour
    {
        public object snapTime; // 0x3357CA50
        public object speed; // 0x339FFDA0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae741340
        public void FixedUpdate(){} // RVA: 0x7ffaae741460
        public void .ctor(){} // RVA: 0x7ffaae7420d0
    }

    public class Planting : MonoBehaviour
    {
        public object prefabToPlant; // 0x3366D810

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae74d6d0
        public void OnDisable(){} // RVA: 0x7ffaae74d990
        public void OnPlantActionChange(){} // RVA: 0x7ffaae74db20
        public void Plant(){} // RVA: 0x7ffaae74dbd0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void DoPlant(){} // RVA: 0x7ffaae74dc80
    }

    public class ProceduralHats : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae746c60
        public void OnEnable(){} // RVA: 0x7ffaae746c70
        public void HatSwitcher(){} // RVA: 0x7ffaae746d20
        public void ChooseHat(){} // RVA: 0x7ffaae746dc0
        public void SwitchToHat(){} // RVA: 0x7ffaae746e40
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class RenderModelChangerUI : UIElement
    {
        public object ui; // 0x33C84C20

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae74eb20
        public void OnButtonClick(){} // RVA: 0x7ffaae74ed00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SkeletonUIOptions : MonoBehaviour
    {
        // ── Original Methods ──
        public void AnimateHandWithController(){} // RVA: 0x7ffaae74ef80
        public void AnimateHandWithoutController(){} // RVA: 0x7ffaae74f0f0
        public void ShowController(){} // RVA: 0x7ffaae74f260
        public void HideController(){} // RVA: 0x7ffaae74f540
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetRenderModel(){} // RVA: 0x7ffaae74f3b0
    }

    public class SquishyToy : MonoBehaviour
    {
        public object affectMaterial; // 0x33C2ED80
        public object rigidbody; // 0x33C2ED80

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae750940
        public void Update(){} // RVA: 0x7ffaae750c90
        public void .ctor(){} // RVA: 0x7ffaae7512c0
    }

    public class TargetHitEffect : MonoBehaviour
    {
        public object colorSpawnedObject; // 0x33391C60
        public object measurementTape; // 0x33C65480

        // ── Original Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7ffaae74f690
        public void .ctor(){} // RVA: 0x7ffaae750060
    }

    public class TargetMeasurement : MonoBehaviour
    {
        public object endPoint; // 0x33C65480
        public object maxDistanceToDraw; // 0x33C65480
        public object interactable; // 0x33C2ED80
        public object gripSqueeze; // 0x33C2ED80

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaae7500b0
        public void .ctor(){} // RVA: 0x7ffaae7508f0
    }

    public class WheelDust : MonoBehaviour
    {
        public object EmissionMul; // 0x333FD860
        public object minSlip; // 0x333FD860
        public object emitTimer; // 0x333FD860

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae742c80
        public void Update(){} // RVA: 0x7ffaae742dc0
        public void emitter(){} // RVA: 0x7ffaae743040
        public void .ctor(){} // RVA: 0x7ffaae743460
        // ── Binary Analysis Named ──
        public void DoEmit(){} // RVA: 0x7ffaae7430e0
    }

    public class trackCam : MonoBehaviour
    {
        public object target; // 0x3397D7E0

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaae742120
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class trackObj : MonoBehaviour
    {
        public object negative; // 0x3397D7E0

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaae742730
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}