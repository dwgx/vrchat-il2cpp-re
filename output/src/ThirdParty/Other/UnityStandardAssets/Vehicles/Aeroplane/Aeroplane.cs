// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81122C50
        public void Reset(){} // RVA: 0x7FFE81122D30
        public void FixedUpdate(){} // RVA: 0x7FFE81122D40
        public void SetTarget(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE81123260
    }

    public class AeroplaneAudio : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE811232E0
        public void Update(){} // RVA: 0x7FFE81123A80
        public void .ctor(){} // RVA: 0x7FFE81123E70
    }

    public class AeroplaneControlSurfaceAnimator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE811264F0
        public void Update(){} // RVA: 0x7FFE81126650
        public void RotateSurface(){} // RVA: 0x7FFE811267D0
        public void .ctor(){} // RVA: 0x7FFE81126AC0
    }

    public class AeroplaneController : MonoBehaviour
    {
        public float m_MaxEnginePower; // 0x20
        public float m_Lift; // 0x24
        public float m_ZeroLiftSpeed; // 0x28
        public float m_RollEffect; // 0x2C
        public float m_PitchEffect; // 0x30
        public float m_YawEffect; // 0x34
        public float m_BankedTurnEffect; // 0x38
        public float m_AerodynamicEffect; // 0x3C
        public float m_AutoTurnPitch; // 0x40
        public float m_AutoRollLevel; // 0x44
        public float m_AutoPitchLevel; // 0x48
        public float m_AirBrakesEffect; // 0x4C

        // ── Methods ──
        public void get_Altitude(){} // RVA: 0x7FFE81123FE0
        public void set_Altitude(){} // RVA: 0x7FFE81123FF0
        public void get_Throttle(){} // RVA: 0x7FFE81124000
        public void set_Throttle(){} // RVA: 0x7FFE81124010
        public void get_AirBrakes(){} // RVA: 0x7FFE81124020
        public void set_AirBrakes(){} // RVA: 0x7FFE81124030
        public void get_ForwardSpeed(){} // RVA: 0x7FFE81124040
        public void set_ForwardSpeed(){} // RVA: 0x7FFE81124050
        public void get_EnginePower(){} // RVA: 0x7FFE81124060
        public void set_EnginePower(){} // RVA: 0x7FFE81124070
        public void get_MaxEnginePower(){} // RVA: 0x7FFE81124080
        public void get_RollAngle(){} // RVA: 0x7FFE8111C680
        public void set_RollAngle(){} // RVA: 0x7FFE81124090
        public void get_PitchAngle(){} // RVA: 0x7FFE811240A0
        public void set_PitchAngle(){} // RVA: 0x7FFE811240B0
        public void get_RollInput(){} // RVA: 0x7FFE811240C0
        public void set_RollInput(){} // RVA: 0x7FFE811240D0
        public void get_PitchInput(){} // RVA: 0x7FFE811240E0
        public void set_PitchInput(){} // RVA: 0x7FFE811240F0
        public void get_YawInput(){} // RVA: 0x7FFE81124100
        public void set_YawInput(){} // RVA: 0x7FFE81124110
        public void get_ThrottleInput(){} // RVA: 0x7FFE81124120
        public void set_ThrottleInput(){} // RVA: 0x7FFE81124130
        public void Start(){} // RVA: 0x7FFE81124140
        public void Move(){} // RVA: 0x7FFE811244A0
        public void ClampInputs(){} // RVA: 0x7FFE81124930
        public void CalculateRollAndPitchAngles(){} // RVA: 0x7FFE811249D0
        public void AutoLevel(){} // RVA: 0x7FFE81124D90
        public void CalculateForwardSpeed(){} // RVA: 0x7FFE81124E10
        public void ControlThrottle(){} // RVA: 0x7FFE81124F60
        public void CalculateDrag(){} // RVA: 0x7FFE81125020
        public void CaluclateAerodynamicEffect(){} // RVA: 0x7FFE811251A0
        public void CalculateLinearForces(){} // RVA: 0x7FFE81125820
        public void CalculateTorque(){} // RVA: 0x7FFE81125BF0
        public void CalculateAltitude(){} // RVA: 0x7FFE81125FC0
        public void Immobilize(){} // RVA: 0x7FFE81126420
        public void Reset(){} // RVA: 0x7FFE81126430
        public void .ctor(){} // RVA: 0x7FFE81126440
    }

    public class AeroplanePropellerAnimator : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81126B10
        public void Update(){} // RVA: 0x7FFE81126CB0
        public void .ctor(){} // RVA: 0x7FFE81126EF0
    }

    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81126F50
        public void FixedUpdate(){} // RVA: 0x7FFE81126FE0
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFE81127170
        public void .ctor(){} // RVA: 0x7FFE81127250
    }

    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE811272B0
        public void FixedUpdate(){} // RVA: 0x7FFE81127340
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFE81127580
        public void .ctor(){} // RVA: 0x7FFE81127250
    }

    public class JetParticleEffect : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81127620
        public void Update(){} // RVA: 0x7FFE81127990
        public void FindAeroplaneParent(){} // RVA: 0x7FFE81127CE0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LandingGear : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81127F10
        public void Update(){} // RVA: 0x7FFE811280A0
        public void .ctor(){} // RVA: 0x7FFE811281B0
    }

}