// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 137

namespace ThirdParty.Unity.UnityEngine
{
    public class WWWForm : Object
    {
        public byte[] dDash;

        // ── Methods ──
        public void get_DefaultEncoding(){} // RVA: 0x7FFE88039BB0
        public void .cctor(){} // RVA: 0x7FFE88039BC0
    }

    public class WWWTranscoder : Object
    {
        // ── Methods ──
        public void Hex2Byte(){} // RVA: 0x7FFE8803A190
        public void Byte2Hex(){} // RVA: 0x7FFE8803A220
        public void URLEncode(){} // RVA: 0x7FFE8803A260
        public void Encode(){} // RVA: 0x7FFE8803A2E0
        public void ByteArrayContains(){} // RVA: 0x7FFE8803A720
        public void URLDecode(){} // RVA: 0x7FFE8803A770
        public void ByteSubArrayEquals(){} // RVA: 0x7FFE8803A7E0
        public void Decode(){} // RVA: 0x7FFE8803A870
        public void .cctor(){} // RVA: 0x7FFE8803ABC0
    }

    public class WaitForEndOfFrame : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class WaitForFixedUpdate : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class WaitForSeconds : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81225330
    }

    public class WaitForSecondsRealtime : CustomYieldInstruction
    {
        public float _waitTime; // 0x10
        public float m_WaitUntilTime; // 0x14

        // ── Methods ──
        public void get_waitTime(){} // RVA: 0x7FFE81225320
        public void set_waitTime(){} // RVA: 0x7FFE81225330
        public void get_keepWaiting(){} // RVA: 0x7FFE87C71730
        public void .ctor(){} // RVA: 0x7FFE87C71810
        public void Reset(){} // RVA: 0x7FFE87C71820
    }

    public class WaitUntil : CustomYieldInstruction
    {
        public System.Func`1<bool> m_Predicate; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFE87C71830
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class WaitWhile : CustomYieldInstruction
    {
        public System.Func`1<bool> m_Predicate; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFE82001D60
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class WebCamDevice : ValueType
    {
        public string m_Name; // 0x10
        public string m_DepthCameraName; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8348B260
        public void get_isFrontFacing(){} // RVA: 0x7FFE87BF2B30
    }

    public class WebCamTexture : Texture
    {
        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFE87BF2B40
        public void .ctor(){} // RVA: 0x7FFE87BF2B90
        public void Play(){} // RVA: 0x7FFE87BF2C80
        public void Pause(){} // RVA: 0x7FFE87BF2CD0
        public void Stop(){} // RVA: 0x7FFE87BF2D20
        public void get_isPlaying(){} // RVA: 0x7FFE87BF2D70
        public void get_videoRotationAngle(){} // RVA: 0x7FFE87BF2DC0
        public void get_videoVerticallyMirrored(){} // RVA: 0x7FFE87BF2E10
        public void get_didUpdateThisFrame(){} // RVA: 0x7FFE87BF2E60
        public void GetPixels32(){} // RVA: 0x7FFE87BF2EB0
        public void Internal_CreateWebCamTexture(){} // RVA: 0x7FFE87BF2F10
    }

    public class WheelCollider : Collider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFE8803F750
        public void set_center(){} // RVA: 0x7FFE8803F7C0
        public void get_radius(){} // RVA: 0x7FFE8803F820
        public void set_radius(){} // RVA: 0x7FFE8803F870
        public void get_suspensionDistance(){} // RVA: 0x7FFE8803F8D0
        public void set_suspensionDistance(){} // RVA: 0x7FFE8803F920
        public void get_suspensionSpring(){} // RVA: 0x7FFE8803F980
        public void set_suspensionSpring(){} // RVA: 0x7FFE8803F9F0
        public void get_suspensionExpansionLimited(){} // RVA: 0x7FFE8803FA50
        public void set_suspensionExpansionLimited(){} // RVA: 0x7FFE8803FAA0
        public void get_forceAppPointDistance(){} // RVA: 0x7FFE8803FB00
        public void set_forceAppPointDistance(){} // RVA: 0x7FFE8803FB50
        public void get_mass(){} // RVA: 0x7FFE8803FBB0
        public void set_mass(){} // RVA: 0x7FFE8803FC00
        public void get_wheelDampingRate(){} // RVA: 0x7FFE8803FC60
        public void set_wheelDampingRate(){} // RVA: 0x7FFE8803FCB0
        public void get_forwardFriction(){} // RVA: 0x7FFE8803FD10
        public void set_forwardFriction(){} // RVA: 0x7FFE8803FD80
        public void get_sidewaysFriction(){} // RVA: 0x7FFE8803FDE0
        public void set_sidewaysFriction(){} // RVA: 0x7FFE8803FE50
        public void get_motorTorque(){} // RVA: 0x7FFE8803FEB0
        public void set_motorTorque(){} // RVA: 0x7FFE8803FF00
        public void get_brakeTorque(){} // RVA: 0x7FFE8803FF60
        public void set_brakeTorque(){} // RVA: 0x7FFE8803FFB0
        public void get_steerAngle(){} // RVA: 0x7FFE88040010
        public void set_steerAngle(){} // RVA: 0x7FFE88040060
        public void get_isGrounded(){} // RVA: 0x7FFE880400C0
        public void get_rpm(){} // RVA: 0x7FFE88040110
        public void get_sprungMass(){} // RVA: 0x7FFE88040160
        public void set_sprungMass(){} // RVA: 0x7FFE880401B0
        public void get_rotationSpeed(){} // RVA: 0x7FFE88040210
        public void set_rotationSpeed(){} // RVA: 0x7FFE88040260
        public void ResetSprungMasses(){} // RVA: 0x7FFE880402C0
        public void ConfigureVehicleSubsteps(){} // RVA: 0x7FFE88040310
        public void GetWorldPose(){} // RVA: 0x7FFE88040390
        public void GetGroundHit(){} // RVA: 0x7FFE88040400
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_center_Injected(){} // RVA: 0x7FFE88040460
        public void set_center_Injected(){} // RVA: 0x7FFE880404C0
        public void get_suspensionSpring_Injected(){} // RVA: 0x7FFE88040520
        public void set_suspensionSpring_Injected(){} // RVA: 0x7FFE88040580
        public void get_forwardFriction_Injected(){} // RVA: 0x7FFE880405E0
        public void set_forwardFriction_Injected(){} // RVA: 0x7FFE88040640
        public void get_sidewaysFriction_Injected(){} // RVA: 0x7FFE880406A0
        public void set_sidewaysFriction_Injected(){} // RVA: 0x7FFE88040700
    }

    public class WheelFrictionCurve : ValueType
    {
        public float m_ExtremumSlip; // 0x10
        public float m_ExtremumValue; // 0x14
        public float m_AsymptoteSlip; // 0x18
        public float m_AsymptoteValue; // 0x1C
        public float m_Stiffness; // 0x20

        // ── Methods ──
        public void get_extremumSlip(){} // RVA: 0x7FFE8111ED20
        public void set_extremumSlip(){} // RVA: 0x7FFE82D03BB0
        public void get_extremumValue(){} // RVA: 0x7FFE8111ED30
        public void set_extremumValue(){} // RVA: 0x7FFE82D03BD0
        public void get_asymptoteSlip(){} // RVA: 0x7FFE8111ECF0
        public void set_asymptoteSlip(){} // RVA: 0x7FFE82D03BC0
        public void get_asymptoteValue(){} // RVA: 0x7FFE8111ED00
        public void set_asymptoteValue(){} // RVA: 0x7FFE82D03B80
        public void get_stiffness(){} // RVA: 0x7FFE87BBD360
        public void set_stiffness(){} // RVA: 0x7FFE81225330
    }

    public class WheelHit : ValueType
    {
        public UnityEngine.Vector3 m_Point; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C
        public UnityEngine.Vector3 m_ForwardDir; // 0x28
        public UnityEngine.Vector3 m_SidewaysDir; // 0x34
        public float m_Force; // 0x40
        public float m_ForwardSlip; // 0x44
        public float m_SidewaysSlip; // 0x48
        public UnityEngine.Collider m_Collider; // 0x50

        // ── Methods ──
        public void get_collider(){} // RVA: 0x7FFE87CC7FD0
        public void set_collider(){} // RVA: 0x7FFE81123200
        public void get_point(){} // RVA: 0x7FFE87BBA310
        public void set_point(){} // RVA: 0x7FFE835C1F00
        public void get_normal(){} // RVA: 0x7FFE87BBA330
        public void set_normal(){} // RVA: 0x7FFE87BBA350
        public void get_forwardDir(){} // RVA: 0x7FFE87BD9260
        public void set_forwardDir(){} // RVA: 0x7FFE850BAE20
        public void get_sidewaysDir(){} // RVA: 0x7FFE8803F730
        public void set_sidewaysDir(){} // RVA: 0x7FFE81156CC0
        public void get_force(){} // RVA: 0x7FFE87CE83C0
        public void set_force(){} // RVA: 0x7FFE81308960
        public void get_forwardSlip(){} // RVA: 0x7FFE87CE83E0
        public void set_forwardSlip(){} // RVA: 0x7FFE811C5640
        public void get_sidewaysSlip(){} // RVA: 0x7FFE87AC4C50
        public void set_sidewaysSlip(){} // RVA: 0x7FFE8130A000
    }

    public class WheelJoint2D : AnchoredJoint2D
    {
        // ── Methods ──
        public void get_suspension(){} // RVA: 0x7FFE87D2DD40
        public void set_suspension(){} // RVA: 0x7FFE87D2DDB0
        public void get_useMotor(){} // RVA: 0x7FFE87D2DE10
        public void set_useMotor(){} // RVA: 0x7FFE87D2DE60
        public void get_motor(){} // RVA: 0x7FFE87D2DEC0
        public void set_motor(){} // RVA: 0x7FFE87D2DF20
        public void get_jointTranslation(){} // RVA: 0x7FFE87D2DF80
        public void get_jointLinearSpeed(){} // RVA: 0x7FFE87D2DFD0
        public void get_jointSpeed(){} // RVA: 0x7FFE87D2E020
        public void get_jointAngle(){} // RVA: 0x7FFE87D2E070
        public void GetMotorTorque(){} // RVA: 0x7FFE87D2E0C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_suspension_Injected(){} // RVA: 0x7FFE87D2E120
        public void set_suspension_Injected(){} // RVA: 0x7FFE87D2E180
        public void get_motor_Injected(){} // RVA: 0x7FFE87D2E1E0
        public void set_motor_Injected(){} // RVA: 0x7FFE87D2E240
    }

    public class WindZone : Component
    {
        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFE88045380
        public void set_mode(){} // RVA: 0x7FFE880453D0
        public void get_radius(){} // RVA: 0x7FFE88045430
        public void set_radius(){} // RVA: 0x7FFE88045480
        public void get_windMain(){} // RVA: 0x7FFE880454E0
        public void set_windMain(){} // RVA: 0x7FFE88045530
        public void get_windTurbulence(){} // RVA: 0x7FFE88045590
        public void set_windTurbulence(){} // RVA: 0x7FFE880455E0
        public void get_windPulseMagnitude(){} // RVA: 0x7FFE88045640
        public void set_windPulseMagnitude(){} // RVA: 0x7FFE88045690
        public void get_windPulseFrequency(){} // RVA: 0x7FFE880456F0
        public void set_windPulseFrequency(){} // RVA: 0x7FFE88045740
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class WritableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}