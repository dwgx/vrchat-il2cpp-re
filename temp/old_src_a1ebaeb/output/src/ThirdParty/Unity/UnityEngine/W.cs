// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 90

namespace ThirdParty.Unity.UnityEngine
{
    public class WaitForEndOfFrame : YieldInstruction
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class WaitForFixedUpdate : YieldInstruction
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class WaitForSeconds : YieldInstruction
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a5c330
    }

    public class WebCamDevice : ValueType
    {
        public object m_Flags; // 0x32E29DD0

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaaabdb990
        public void get_isFrontFacing(){} // RVA: 0x7ffaaf26c4f0
    }

    public class WebCamTexture : Texture
    {
        // ── Original Methods ──
        public void get_devices(){} // RVA: 0x7ffaaf26c500
        public void .ctor(){} // RVA: 0x7ffaaf26c550
        public void Play(){} // RVA: 0x7ffaaf26c640
        public void Pause(){} // RVA: 0x7ffaaf26c690
        public void Stop(){} // RVA: 0x7ffaaf26c6e0
        public void get_isPlaying(){} // RVA: 0x7ffaaf26c730
        public void get_videoRotationAngle(){} // RVA: 0x7ffaaf26c780
        public void get_videoVerticallyMirrored(){} // RVA: 0x7ffaaf26c7d0
        public void get_didUpdateThisFrame(){} // RVA: 0x7ffaaf26c820
        public void Internal_CreateWebCamTexture(){} // RVA: 0x7ffaaf26c8d0
        // ── Binary Analysis Named ──
        public void GetPixels32(){} // RVA: 0x7ffaaf26c870
    }

    public class WheelCollider : Collider
    {
        // ── Original Methods ──
        public void get_center(){} // RVA: 0x7ffaaf6b8e70
        public void set_center(){} // RVA: 0x7ffaaf6b8ee0
        public void get_radius(){} // RVA: 0x7ffaaf6b8f40
        public void set_radius(){} // RVA: 0x7ffaaf6b8f90
        public void get_suspensionDistance(){} // RVA: 0x7ffaaf6b8ff0
        public void set_suspensionDistance(){} // RVA: 0x7ffaaf6b9040
        public void get_suspensionSpring(){} // RVA: 0x7ffaaf6b90a0
        public void set_suspensionSpring(){} // RVA: 0x7ffaaf6b9110
        public void get_suspensionExpansionLimited(){} // RVA: 0x7ffaaf6b9170
        public void set_suspensionExpansionLimited(){} // RVA: 0x7ffaaf6b91c0
        public void get_forceAppPointDistance(){} // RVA: 0x7ffaaf6b9220
        public void set_forceAppPointDistance(){} // RVA: 0x7ffaaf6b9270
        public void get_mass(){} // RVA: 0x7ffaaf6b92d0
        public void set_mass(){} // RVA: 0x7ffaaf6b9320
        public void get_wheelDampingRate(){} // RVA: 0x7ffaaf6b9380
        public void set_wheelDampingRate(){} // RVA: 0x7ffaaf6b93d0
        public void get_forwardFriction(){} // RVA: 0x7ffaaf6b9430
        public void set_forwardFriction(){} // RVA: 0x7ffaaf6b94a0
        public void get_sidewaysFriction(){} // RVA: 0x7ffaaf6b9500
        public void set_sidewaysFriction(){} // RVA: 0x7ffaaf6b9570
        public void get_motorTorque(){} // RVA: 0x7ffaaf6b95d0
        public void set_motorTorque(){} // RVA: 0x7ffaaf6b9620
        public void get_brakeTorque(){} // RVA: 0x7ffaaf6b9680
        public void set_brakeTorque(){} // RVA: 0x7ffaaf6b96d0
        public void get_steerAngle(){} // RVA: 0x7ffaaf6b9730
        public void set_steerAngle(){} // RVA: 0x7ffaaf6b9780
        public void get_isGrounded(){} // RVA: 0x7ffaaf6b97e0
        public void get_rpm(){} // RVA: 0x7ffaaf6b9830
        public void get_sprungMass(){} // RVA: 0x7ffaaf6b9880
        public void set_sprungMass(){} // RVA: 0x7ffaaf6b98d0
        public void get_rotationSpeed(){} // RVA: 0x7ffaaf6b9930
        public void set_rotationSpeed(){} // RVA: 0x7ffaaf6b9980
        public void ResetSprungMasses(){} // RVA: 0x7ffaaf6b99e0
        public void ConfigureVehicleSubsteps(){} // RVA: 0x7ffaaf6b9a30
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_center_Injected(){} // RVA: 0x7ffaaf6b9b80
        public void set_center_Injected(){} // RVA: 0x7ffaaf6b9be0
        public void get_suspensionSpring_Injected(){} // RVA: 0x7ffaaf6b9c40
        public void set_suspensionSpring_Injected(){} // RVA: 0x7ffaaf6b9ca0
        public void get_forwardFriction_Injected(){} // RVA: 0x7ffaaf6b9d00
        public void set_forwardFriction_Injected(){} // RVA: 0x7ffaaf6b9d60
        public void get_sidewaysFriction_Injected(){} // RVA: 0x7ffaaf6b9dc0
        public void set_sidewaysFriction_Injected(){} // RVA: 0x7ffaaf6b9e20
        // ── Binary Analysis Named ──
        public void GetWorldPose(){} // RVA: 0x7ffaaf6b9ab0
        public void GetGroundHit(){} // RVA: 0x7ffaaf6b9b20
    }

    public class WheelJoint2D : AnchoredJoint2D
    {
        // ── Original Methods ──
        public void get_suspension(){} // RVA: 0x7ffaaf3a7400
        public void set_suspension(){} // RVA: 0x7ffaaf3a7470
        public void get_useMotor(){} // RVA: 0x7ffaaf3a74d0
        public void set_useMotor(){} // RVA: 0x7ffaaf3a7520
        public void get_motor(){} // RVA: 0x7ffaaf3a7580
        public void set_motor(){} // RVA: 0x7ffaaf3a75e0
        public void get_jointTranslation(){} // RVA: 0x7ffaaf3a7640
        public void get_jointLinearSpeed(){} // RVA: 0x7ffaaf3a7690
        public void get_jointSpeed(){} // RVA: 0x7ffaaf3a76e0
        public void get_jointAngle(){} // RVA: 0x7ffaaf3a7730
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_suspension_Injected(){} // RVA: 0x7ffaaf3a77e0
        public void set_suspension_Injected(){} // RVA: 0x7ffaaf3a7840
        public void get_motor_Injected(){} // RVA: 0x7ffaaf3a78a0
        public void set_motor_Injected(){} // RVA: 0x7ffaaf3a7900
        // ── Binary Analysis Named ──
        public void GetMotorTorque(){} // RVA: 0x7ffaaf3a7780
    }

    public class WindZone : Component
    {
        // ── Original Methods ──
        public void get_mode(){} // RVA: 0x7ffaaf6beaa0
        public void set_mode(){} // RVA: 0x7ffaaf6beaf0
        public void get_radius(){} // RVA: 0x7ffaaf6beb50
        public void set_radius(){} // RVA: 0x7ffaaf6beba0
        public void get_windMain(){} // RVA: 0x7ffaaf6bec00
        public void set_windMain(){} // RVA: 0x7ffaaf6bec50
        public void get_windTurbulence(){} // RVA: 0x7ffaaf6becb0
        public void set_windTurbulence(){} // RVA: 0x7ffaaf6bed00
        public void get_windPulseMagnitude(){} // RVA: 0x7ffaaf6bed60
        public void set_windPulseMagnitude(){} // RVA: 0x7ffaaf6bedb0
        public void get_windPulseFrequency(){} // RVA: 0x7ffaaf6bee10
        public void set_windPulseFrequency(){} // RVA: 0x7ffaaf6bee60
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}