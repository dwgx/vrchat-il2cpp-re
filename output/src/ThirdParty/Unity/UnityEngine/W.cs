// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 90

namespace ThirdParty.Unity.UnityEngine
{
    public class WaitForEndOfFrame : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class WaitForFixedUpdate : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class WaitForSeconds : YieldInstruction
    {
        public float m_Seconds; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E46B330
    }

    public class WebCamDevice : ValueType
    {
        public string name; // 0x10
        public string isFrontFacing; // 0x18
        public int m_Flags; // 0x20
        public g`2 m_Kind; // 0x24
        public ilter[] m_Resolutions; // 0x28

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD505F9A30
        public void get_isFrontFacing(){} // RVA: 0x7FFD54C6A590
    }

    public class WebCamTexture : Texture
    {
        public object devices;
        public object isPlaying;
        public object videoRotationAngle;
        public object videoVerticallyMirrored;
        public object didUpdateThisFrame;

        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFD54C6A5A0
        public void .ctor(){} // RVA: 0x7FFD54C6A5F0
        public void Play(){} // RVA: 0x7FFD54C6A6E0
        public void Pause(){} // RVA: 0x7FFD54C6A730
        public void Stop(){} // RVA: 0x7FFD54C6A780
        public void get_isPlaying(){} // RVA: 0x7FFD54C6A7D0
        public void get_videoRotationAngle(){} // RVA: 0x7FFD54C6A820
        public void get_videoVerticallyMirrored(){} // RVA: 0x7FFD54C6A870
        public void get_didUpdateThisFrame(){} // RVA: 0x7FFD54C6A8C0
        public void GetPixels32(){} // RVA: 0x7FFD54C6A910
        public void Internal_CreateWebCamTexture(){} // RVA: 0x7FFD54C6A970
    }

    public class WheelCollider : Collider
    {
        public object center;
        public object radius;
        public object suspensionDistance;
        public object suspensionSpring;
        public object suspensionExpansionLimited;
        public object forceAppPointDistance;
        public object mass;
        public object wheelDampingRate;
        public object forwardFriction;
        public object sidewaysFriction;
        public object motorTorque;
        public object brakeTorque;
        public object steerAngle;
        public object isGrounded;
        public object rpm;
        public object sprungMass;
        public object rotationSpeed;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFD550B6F00
        public void set_center(){} // RVA: 0x7FFD550B6F70
        public void get_radius(){} // RVA: 0x7FFD550B6FD0
        public void set_radius(){} // RVA: 0x7FFD550B7020
        public void get_suspensionDistance(){} // RVA: 0x7FFD550B7080
        public void set_suspensionDistance(){} // RVA: 0x7FFD550B70D0
        public void get_suspensionSpring(){} // RVA: 0x7FFD550B7130
        public void set_suspensionSpring(){} // RVA: 0x7FFD550B71A0
        public void get_suspensionExpansionLimited(){} // RVA: 0x7FFD550B7200
        public void set_suspensionExpansionLimited(){} // RVA: 0x7FFD550B7250
        public void get_forceAppPointDistance(){} // RVA: 0x7FFD550B72B0
        public void set_forceAppPointDistance(){} // RVA: 0x7FFD550B7300
        public void get_mass(){} // RVA: 0x7FFD550B7360
        public void set_mass(){} // RVA: 0x7FFD550B73B0
        public void get_wheelDampingRate(){} // RVA: 0x7FFD550B7410
        public void set_wheelDampingRate(){} // RVA: 0x7FFD550B7460
        public void get_forwardFriction(){} // RVA: 0x7FFD550B74C0
        public void set_forwardFriction(){} // RVA: 0x7FFD550B7530
        public void get_sidewaysFriction(){} // RVA: 0x7FFD550B7590
        public void set_sidewaysFriction(){} // RVA: 0x7FFD550B7600
        public void get_motorTorque(){} // RVA: 0x7FFD550B7660
        public void set_motorTorque(){} // RVA: 0x7FFD550B76B0
        public void get_brakeTorque(){} // RVA: 0x7FFD550B7710
        public void set_brakeTorque(){} // RVA: 0x7FFD550B7760
        public void get_steerAngle(){} // RVA: 0x7FFD550B77C0
        public void set_steerAngle(){} // RVA: 0x7FFD550B7810
        public void get_isGrounded(){} // RVA: 0x7FFD550B7870
        public void get_rpm(){} // RVA: 0x7FFD550B78C0
        public void get_sprungMass(){} // RVA: 0x7FFD550B7910
        public void set_sprungMass(){} // RVA: 0x7FFD550B7960
        public void get_rotationSpeed(){} // RVA: 0x7FFD550B79C0
        public void set_rotationSpeed(){} // RVA: 0x7FFD550B7A10
        public void ResetSprungMasses(){} // RVA: 0x7FFD550B7A70
        public void ConfigureVehicleSubsteps(){} // RVA: 0x7FFD550B7AC0
        public void GetWorldPose(){} // RVA: 0x7FFD550B7B40
        public void GetGroundHit(){} // RVA: 0x7FFD550B7BB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_center_Injected(){} // RVA: 0x7FFD550B7C10
        public void set_center_Injected(){} // RVA: 0x7FFD550B7C70
        public void get_suspensionSpring_Injected(){} // RVA: 0x7FFD550B7CD0
        public void set_suspensionSpring_Injected(){} // RVA: 0x7FFD550B7D30
        public void get_forwardFriction_Injected(){} // RVA: 0x7FFD550B7D90
        public void set_forwardFriction_Injected(){} // RVA: 0x7FFD550B7DF0
        public void get_sidewaysFriction_Injected(){} // RVA: 0x7FFD550B7E50
        public void set_sidewaysFriction_Injected(){} // RVA: 0x7FFD550B7EB0
    }

    public class WheelJoint2D : AnchoredJoint2D
    {
        public object suspension;
        public object useMotor;
        public object motor;
        public object jointTranslation;
        public object jointLinearSpeed;
        public object jointSpeed;
        public object jointAngle;

        // ── Methods ──
        public void get_suspension(){} // RVA: 0x7FFD54DA54A0
        public void set_suspension(){} // RVA: 0x7FFD54DA5510
        public void get_useMotor(){} // RVA: 0x7FFD54DA5570
        public void set_useMotor(){} // RVA: 0x7FFD54DA55C0
        public void get_motor(){} // RVA: 0x7FFD54DA5620
        public void set_motor(){} // RVA: 0x7FFD54DA5680
        public void get_jointTranslation(){} // RVA: 0x7FFD54DA56E0
        public void get_jointLinearSpeed(){} // RVA: 0x7FFD54DA5730
        public void get_jointSpeed(){} // RVA: 0x7FFD54DA5780
        public void get_jointAngle(){} // RVA: 0x7FFD54DA57D0
        public void GetMotorTorque(){} // RVA: 0x7FFD54DA5820
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_suspension_Injected(){} // RVA: 0x7FFD54DA5880
        public void set_suspension_Injected(){} // RVA: 0x7FFD54DA58E0
        public void get_motor_Injected(){} // RVA: 0x7FFD54DA5940
        public void set_motor_Injected(){} // RVA: 0x7FFD54DA59A0
    }

    public class WindZone : Component
    {
        public object mode;
        public object radius;
        public object windMain;
        public object windTurbulence;
        public object windPulseMagnitude;
        public object windPulseFrequency;

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFD550BCB30
        public void set_mode(){} // RVA: 0x7FFD550BCB80
        public void get_radius(){} // RVA: 0x7FFD550BCBE0
        public void set_radius(){} // RVA: 0x7FFD550BCC30
        public void get_windMain(){} // RVA: 0x7FFD550BCC90
        public void set_windMain(){} // RVA: 0x7FFD550BCCE0
        public void get_windTurbulence(){} // RVA: 0x7FFD550BCD40
        public void set_windTurbulence(){} // RVA: 0x7FFD550BCD90
        public void get_windPulseMagnitude(){} // RVA: 0x7FFD550BCDF0
        public void set_windPulseMagnitude(){} // RVA: 0x7FFD550BCE40
        public void get_windPulseFrequency(){} // RVA: 0x7FFD550BCEA0
        public void set_windPulseFrequency(){} // RVA: 0x7FFD550BCEF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}