// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E368C50
        public void Reset(){} // RVA: 0x7FFD4E368D30
        public void FixedUpdate(){} // RVA: 0x7FFD4E368D40
        public void SetTarget(){} // RVA: 0x7FFD4E369200
        public void .ctor(){} // RVA: 0x7FFD4E369260
    }

    public class AeroplaneAudio : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E3692E0
        public void Update(){} // RVA: 0x7FFD4E369A80
        public void .ctor(){} // RVA: 0x7FFD4E369E70
    }

    public class AeroplaneControlSurfaceAnimator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E36C4F0
        public void Update(){} // RVA: 0x7FFD4E36C650
        public void RotateSurface(){} // RVA: 0x7FFD4E36C7D0
        public void .ctor(){} // RVA: 0x7FFD4E36CAC0
    }

    public class AeroplaneController : MonoBehaviour
    {
        public object Altitude;
        public object Throttle;
        public object AirBrakes;
        public object ForwardSpeed;
        public object EnginePower;
        public object MaxEnginePower;
        public object RollAngle;
        public object PitchAngle;
        public object RollInput;
        public object PitchInput;
        public object YawInput;
        public object ThrottleInput;

        // ── Methods ──
        public void get_Altitude(){} // RVA: 0x7FFD4E369FE0
        public void set_Altitude(){} // RVA: 0x7FFD4E369FF0
        public void get_Throttle(){} // RVA: 0x7FFD4E36A000
        public void set_Throttle(){} // RVA: 0x7FFD4E36A010
        public void get_AirBrakes(){} // RVA: 0x7FFD4E36A020
        public void set_AirBrakes(){} // RVA: 0x7FFD4E36A030
        public void get_ForwardSpeed(){} // RVA: 0x7FFD4E36A040
        public void set_ForwardSpeed(){} // RVA: 0x7FFD4E36A050
        public void get_EnginePower(){} // RVA: 0x7FFD4E36A060
        public void set_EnginePower(){} // RVA: 0x7FFD4E36A070
        public void get_MaxEnginePower(){} // RVA: 0x7FFD4E36A080
        public void get_RollAngle(){} // RVA: 0x7FFD4E362680
        public void set_RollAngle(){} // RVA: 0x7FFD4E36A090
        public void get_PitchAngle(){} // RVA: 0x7FFD4E36A0A0
        public void set_PitchAngle(){} // RVA: 0x7FFD4E36A0B0
        public void get_RollInput(){} // RVA: 0x7FFD4E36A0C0
        public void set_RollInput(){} // RVA: 0x7FFD4E36A0D0
        public void get_PitchInput(){} // RVA: 0x7FFD4E36A0E0
        public void set_PitchInput(){} // RVA: 0x7FFD4E36A0F0
        public void get_YawInput(){} // RVA: 0x7FFD4E36A100
        public void set_YawInput(){} // RVA: 0x7FFD4E36A110
        public void get_ThrottleInput(){} // RVA: 0x7FFD4E36A120
        public void set_ThrottleInput(){} // RVA: 0x7FFD4E36A130
        public void Start(){} // RVA: 0x7FFD4E36A140
        public void Move(){} // RVA: 0x7FFD4E36A4A0
        public void ClampInputs(){} // RVA: 0x7FFD4E36A930
        public void CalculateRollAndPitchAngles(){} // RVA: 0x7FFD4E36A9D0
        public void AutoLevel(){} // RVA: 0x7FFD4E36AD90
        public void CalculateForwardSpeed(){} // RVA: 0x7FFD4E36AE10
        public void ControlThrottle(){} // RVA: 0x7FFD4E36AF60
        public void CalculateDrag(){} // RVA: 0x7FFD4E36B020
        public void CaluclateAerodynamicEffect(){} // RVA: 0x7FFD4E36B1A0
        public void CalculateLinearForces(){} // RVA: 0x7FFD4E36B820
        public void CalculateTorque(){} // RVA: 0x7FFD4E36BBF0
        public void CalculateAltitude(){} // RVA: 0x7FFD4E36BFC0
        public void Immobilize(){} // RVA: 0x7FFD4E36C420
        public void Reset(){} // RVA: 0x7FFD4E36C430
        public void .ctor(){} // RVA: 0x7FFD4E36C440
    }

    public class AeroplanePropellerAnimator : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E36CB10
        public void Update(){} // RVA: 0x7FFD4E36CCB0
        public void .ctor(){} // RVA: 0x7FFD4E36CEF0
    }

    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E36CF50
        public void FixedUpdate(){} // RVA: 0x7FFD4E36CFE0
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFD4E36D170
        public void .ctor(){} // RVA: 0x7FFD4E36D250
    }

    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E36D2B0
        public void FixedUpdate(){} // RVA: 0x7FFD4E36D340
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFD4E36D580
        public void .ctor(){} // RVA: 0x7FFD4E36D250
    }

    public class JetParticleEffect : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E36D620
        public void Update(){} // RVA: 0x7FFD4E36D990
        public void FindAeroplaneParent(){} // RVA: 0x7FFD4E36DCE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LandingGear : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E36DF10
        public void Update(){} // RVA: 0x7FFD4E36E0A0
        public void .ctor(){} // RVA: 0x7FFD4E36E1B0
    }

}