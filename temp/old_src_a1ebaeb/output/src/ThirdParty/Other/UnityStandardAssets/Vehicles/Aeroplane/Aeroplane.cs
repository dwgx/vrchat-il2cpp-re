// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl : MonoBehaviour
    {
        public object m_LateralWanderDistance; // 0x3381D650
        public object m_MaxRollAngle; // 0x3381D650
        public object m_Target; // 0x3381D650
        public object m_TakenOff; // 0x3381D650
        public object m_ZeroLiftSpeed; // 0x335001B0
        public object m_YawEffect; // 0x335001B0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8959c50
        public void Reset(){} // RVA: 0x7ffaa8959d30
        public void FixedUpdate(){} // RVA: 0x7ffaa8959d40
        public void .ctor(){} // RVA: 0x7ffaa895a260
        // ── Binary Analysis Named ──
        public void SetTarget(){} // RVA: 0x7ffaa895a200
    }

    public class AeroplaneAudio : MonoBehaviour
    {
        public object m_EngineMaxThrottlePitch; // 0x3379F9D0
        public object m_WindBasePitch; // 0x3379F9D0
        public object m_AdvancedSetttings; // 0x3379F9D0
        public object m_Plane; // 0x3379F9D0
        public object `Ǐf; // 0x66DE1A7C

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa895a2e0
        public void Update(){} // RVA: 0x7ffaa895aa80
        public void .ctor(){} // RVA: 0x7ffaa895ae70
    }

    public class AeroplaneControlSurfaceAnimator : MonoBehaviour
    {
        public object m_Plane; // 0x334C76F0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa895d4f0
        public void Update(){} // RVA: 0x7ffaa895d650
        public void RotateSurface(){} // RVA: 0x7ffaa895d7d0
        public void .ctor(){} // RVA: 0x7ffaa895dac0
    }

    public class AeroplaneController : MonoBehaviour
    {
        public object m_ZeroLiftSpeed; // 0x335001B0
        public object m_YawEffect; // 0x335001B0
        public object m_AutoTurnPitch; // 0x335001B0
        public object m_AirBrakesEffect; // 0x335001B0
        public object _altitude; // 0x335001B0, was: <Altitude>k__BackingField
        public object _forwardSpeed; // 0x335001B0, was: <ForwardSpeed>k__BackingField
        public object _pitchAngle; // 0x335001B0, was: <PitchAngle>k__BackingField
        public object _yawInput; // 0x335001B0, was: <YawInput>k__BackingField
        public object m_OriginalAngularDrag; // 0x335001B0
        public object m_BankedTurnAmount; // 0x335001B0

        // ── Original Methods ──
        public void get_Altitude(){} // RVA: 0x7ffaa895afe0
        public void set_Altitude(){} // RVA: 0x7ffaa895aff0
        public void get_Throttle(){} // RVA: 0x7ffaa895b000
        public void set_Throttle(){} // RVA: 0x7ffaa895b010
        public void get_AirBrakes(){} // RVA: 0x7ffaa895b020
        public void set_AirBrakes(){} // RVA: 0x7ffaa895b030
        public void get_ForwardSpeed(){} // RVA: 0x7ffaa895b040
        public void set_ForwardSpeed(){} // RVA: 0x7ffaa895b050
        public void get_EnginePower(){} // RVA: 0x7ffaa895b060
        public void set_EnginePower(){} // RVA: 0x7ffaa895b070
        public void get_MaxEnginePower(){} // RVA: 0x7ffaa895b080
        public void get_RollAngle(){} // RVA: 0x7ffaa8953680
        public void set_RollAngle(){} // RVA: 0x7ffaa895b090
        public void get_PitchAngle(){} // RVA: 0x7ffaa895b0a0
        public void set_PitchAngle(){} // RVA: 0x7ffaa895b0b0
        public void get_RollInput(){} // RVA: 0x7ffaa895b0c0
        public void set_RollInput(){} // RVA: 0x7ffaa895b0d0
        public void get_PitchInput(){} // RVA: 0x7ffaa895b0e0
        public void set_PitchInput(){} // RVA: 0x7ffaa895b0f0
        public void get_YawInput(){} // RVA: 0x7ffaa895b100
        public void set_YawInput(){} // RVA: 0x7ffaa895b110
        public void get_ThrottleInput(){} // RVA: 0x7ffaa895b120
        public void set_ThrottleInput(){} // RVA: 0x7ffaa895b130
        public void Start(){} // RVA: 0x7ffaa895b140
        public void Move(){} // RVA: 0x7ffaa895b4a0
        public void ClampInputs(){} // RVA: 0x7ffaa895b930
        public void CalculateRollAndPitchAngles(){} // RVA: 0x7ffaa895b9d0
        public void AutoLevel(){} // RVA: 0x7ffaa895bd90
        public void CalculateForwardSpeed(){} // RVA: 0x7ffaa895be10
        public void ControlThrottle(){} // RVA: 0x7ffaa895bf60
        public void CalculateDrag(){} // RVA: 0x7ffaa895c020
        public void CaluclateAerodynamicEffect(){} // RVA: 0x7ffaa895c1a0
        public void CalculateLinearForces(){} // RVA: 0x7ffaa895c820
        public void CalculateTorque(){} // RVA: 0x7ffaa895cbf0
        public void CalculateAltitude(){} // RVA: 0x7ffaa895cfc0
        public void Immobilize(){} // RVA: 0x7ffaa895d420
        public void Reset(){} // RVA: 0x7ffaa895d430
        public void .ctor(){} // RVA: 0x7ffaa895d440
    }

    public class AeroplanePropellerAnimator : MonoBehaviour
    {
        public object m_PropellorBlurTextures; // 0x33CED030
        public object m_MaxRpm; // 0x33CED030
        public object k_RpmToDps; // 0x33CED030
        public object maxRollAngle; // 0x33A4F180
        public object maxRollAngle; // 0x33A6EE50

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa895db10
        public void Update(){} // RVA: 0x7ffaa895dcb0
        public void .ctor(){} // RVA: 0x7ffaa895def0
    }

    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        public object m_Aeroplane; // 0x33A4F180

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa895df50
        public void FixedUpdate(){} // RVA: 0x7ffaa895dfe0
        public void AdjustInputForMobileControls(){} // RVA: 0x7ffaa895e170
        public void .ctor(){} // RVA: 0x7ffaa895e250
    }

    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        public object m_Aeroplane; // 0x33A6EE50
        public object m_Yaw; // 0x33A6EE50
        public object m_System; // 0x334A5CE0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa895e2b0
        public void FixedUpdate(){} // RVA: 0x7ffaa895e340
        public void AdjustInputForMobileControls(){} // RVA: 0x7ffaa895e580
        public void .ctor(){} // RVA: 0x7ffaa895e250
    }

    public class JetParticleEffect : MonoBehaviour
    {
        public object m_System; // 0x334A5CE0
        public object m_OriginalStartColor; // 0x334A5CE0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa895e620
        public void Update(){} // RVA: 0x7ffaa895e990
        public void FindAeroplaneParent(){} // RVA: 0x7ffaa895ece0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LandingGear : MonoBehaviour
    {
        public object m_State; // 0x33AA5EA0
        public object m_Plane; // 0x33AA5EA0
        public object 8؏f; // 0x67396FC9

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa895ef10
        public void Update(){} // RVA: 0x7ffaa895f0a0
        public void .ctor(){} // RVA: 0x7ffaa895f1b0
    }

}