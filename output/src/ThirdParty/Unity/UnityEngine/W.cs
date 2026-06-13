// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 137

namespace ThirdParty.Unity.UnityEngine
{
    public class WWWForm
    {
        public byte[] dDash;

        // ── Methods ──
        public void get_DefaultEncoding(){} // RVA: 0x74F99E0
        public void .cctor(){} // RVA: 0x74F99F0
    }

    public class WWWTranscoder
    {
        // ── Methods ──
        public void Hex2Byte(){} // RVA: 0x74F9FC0
        public void Byte2Hex(){} // RVA: 0x74FA050
        public void URLEncode(){} // RVA: 0x74FA090
        public void Encode(){} // RVA: 0x74FA110
        public void ByteArrayContains(){} // RVA: 0x74FA550
        public void URLDecode(){} // RVA: 0x74FA5A0
        public void ByteSubArrayEquals(){} // RVA: 0x74FA610
        public void Decode(){} // RVA: 0x74FA6A0
        public void .cctor(){} // RVA: 0x74FA9F0
    }

    public class WaitForEndOfFrame
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class WaitForFixedUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class WaitForSeconds
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class WaitForSecondsRealtime
    {
        public float <waitTime>k__BackingField; // 0x10
        public float m_WaitUntilTime; // 0x14

        // ── Methods ──
        public void get_waitTime(){} // RVA: 0x407320
        public void set_waitTime(){} // RVA: 0x407330
        public void get_keepWaiting(){} // RVA: 0x7130A70
        public void .ctor(){} // RVA: 0x7130B50
        public void Reset(){} // RVA: 0x7130B60
    }

    public class WaitUntil
    {
        public System.Func`1<bool> m_Predicate; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7130B70
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class WaitWhile
    {
        public System.Func`1<bool> m_Predicate; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x1281E30
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class WebCamDevice
    {
        public string m_Name; // 0x10
        public string m_DepthCameraName; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x2738C50
        public void get_isFrontFacing(){} // RVA: 0x70B1B50
    }

    public class WebCamTexture
    {
        // ── Methods ──
        public void get_devices(){} // RVA: 0x70B1B60
        public void .ctor(){} // RVA: 0x70B1BB0
        public void Play(){} // RVA: 0x70B1CA0
        public void Pause(){} // RVA: 0x70B1CF0
        public void Stop(){} // RVA: 0x70B1D40
        public void get_isPlaying(){} // RVA: 0x70B1D90
        public void get_videoRotationAngle(){} // RVA: 0x70B1DE0
        public void get_videoVerticallyMirrored(){} // RVA: 0x70B1E30
        public void get_didUpdateThisFrame(){} // RVA: 0x70B1E80
        public void GetPixels32(){} // RVA: 0x70B1ED0
        public void Internal_CreateWebCamTexture(){} // RVA: 0x70B1F30
    }

    public class WheelCollider
    {
        public object connectedBody;
        public object connectedArticulationBody;
        public object axis;
        public object anchor;
        public object connectedAnchor;
        public object autoConfigureConnectedAnchor;
        public object breakForce;
        public object breakTorque;
        public object enableCollision;
        public object enablePreprocessing;
        public object massScale;
        public object connectedMassScale;
        public object currentForce;
        public object currentTorque;

        // ── Methods ──
        public void get_center(){} // RVA: 0x74FF580
        public void set_center(){} // RVA: 0x74FF5F0
        public void get_radius(){} // RVA: 0x74FF650
        public void set_radius(){} // RVA: 0x74FF6A0
        public void get_suspensionDistance(){} // RVA: 0x74FF700
        public void set_suspensionDistance(){} // RVA: 0x74FF750
        public void get_suspensionSpring(){} // RVA: 0x74FF7B0
        public void set_suspensionSpring(){} // RVA: 0x74FF820
        public void get_suspensionExpansionLimited(){} // RVA: 0x74FF880
        public void set_suspensionExpansionLimited(){} // RVA: 0x74FF8D0
        public void get_forceAppPointDistance(){} // RVA: 0x74FF930
        public void set_forceAppPointDistance(){} // RVA: 0x74FF980
        public void get_mass(){} // RVA: 0x74FF9E0
        public void set_mass(){} // RVA: 0x74FFA30
        public void get_wheelDampingRate(){} // RVA: 0x74FFA90
        public void set_wheelDampingRate(){} // RVA: 0x74FFAE0
        public void get_forwardFriction(){} // RVA: 0x74FFB40
        public void set_forwardFriction(){} // RVA: 0x74FFBB0
        public void get_sidewaysFriction(){} // RVA: 0x74FFC10
        public void set_sidewaysFriction(){} // RVA: 0x74FFC80
        public void get_motorTorque(){} // RVA: 0x74FFCE0
        public void set_motorTorque(){} // RVA: 0x74FFD30
        public void get_brakeTorque(){} // RVA: 0x74FFD90
        public void set_brakeTorque(){} // RVA: 0x74FFDE0
        public void get_steerAngle(){} // RVA: 0x74FFE40
        public void set_steerAngle(){} // RVA: 0x74FFE90
        public void get_isGrounded(){} // RVA: 0x74FFEF0
        public void get_rpm(){} // RVA: 0x74FFF40
        public void get_sprungMass(){} // RVA: 0x74FFF90
        public void set_sprungMass(){} // RVA: 0x74FFFE0
        public void get_rotationSpeed(){} // RVA: 0x7500040
        public void set_rotationSpeed(){} // RVA: 0x7500090
        public void ResetSprungMasses(){} // RVA: 0x75000F0
        public void ConfigureVehicleSubsteps(){} // RVA: 0x7500140
        public void GetWorldPose(){} // RVA: 0x75001C0
        public void GetGroundHit(){} // RVA: 0x7500230
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_center_Injected(){} // RVA: 0x7500290
        public void set_center_Injected(){} // RVA: 0x75002F0
        public void get_suspensionSpring_Injected(){} // RVA: 0x7500350
        public void set_suspensionSpring_Injected(){} // RVA: 0x75003B0
        public void get_forwardFriction_Injected(){} // RVA: 0x7500410
        public void set_forwardFriction_Injected(){} // RVA: 0x7500470
        public void get_sidewaysFriction_Injected(){} // RVA: 0x75004D0
        public void set_sidewaysFriction_Injected(){} // RVA: 0x7500530
    }

    public class WheelFrictionCurve
    {
        public float limit; // 0x10
        public float bounciness; // 0x14
        public float contactDistance; // 0x18
        public float get_spring; // 0x1C
        public float m_Stiffness; // 0x20

        // ── Methods ──
        public void get_extremumSlip(){} // RVA: 0x300D20
        public void set_extremumSlip(){} // RVA: 0x1F78330
        public void get_extremumValue(){} // RVA: 0x300D30
        public void set_extremumValue(){} // RVA: 0x1F78350
        public void get_asymptoteSlip(){} // RVA: 0x300CF0
        public void set_asymptoteSlip(){} // RVA: 0x1F78340
        public void get_asymptoteValue(){} // RVA: 0x300D00
        public void set_asymptoteValue(){} // RVA: 0x1F78380
        public void get_stiffness(){} // RVA: 0x707C4A0
        public void set_stiffness(){} // RVA: 0x407330
    }

    public class WheelHit
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
        public void get_collider(){} // RVA: 0x7187E30
        public void set_collider(){} // RVA: 0x305200
        public void get_point(){} // RVA: 0x7079450
        public void set_point(){} // RVA: 0x210E450
        public void get_normal(){} // RVA: 0x7079470
        public void set_normal(){} // RVA: 0x7079490
        public void get_forwardDir(){} // RVA: 0x70983A0
        public void set_forwardDir(){} // RVA: 0x447FFC0
        public void get_sidewaysDir(){} // RVA: 0x74FF560
        public void set_sidewaysDir(){} // RVA: 0x338CC0
        public void get_force(){} // RVA: 0x71A8220
        public void set_force(){} // RVA: 0x4FDE90
        public void get_forwardSlip(){} // RVA: 0x71A8240
        public void set_forwardSlip(){} // RVA: 0x3A7640
        public void get_sidewaysSlip(){} // RVA: 0x6F83DB0
        public void set_sidewaysSlip(){} // RVA: 0x4FB970
    }

    public class WheelJoint2D
    {
        public object maxForce;
        public object maxTorque;
        public object correctionScale;
        public object autoConfigureOffset;
        public object linearOffset;
        public object angularOffset;
        public object target;

        // ── Methods ──
        public void get_suspension(){} // RVA: 0x71EDBA0
        public void set_suspension(){} // RVA: 0x71EDC10
        public void get_useMotor(){} // RVA: 0x71EDC70
        public void set_useMotor(){} // RVA: 0x71EDCC0
        public void get_motor(){} // RVA: 0x71EDD20
        public void set_motor(){} // RVA: 0x71EDD80
        public void get_jointTranslation(){} // RVA: 0x71EDDE0
        public void get_jointLinearSpeed(){} // RVA: 0x71EDE30
        public void get_jointSpeed(){} // RVA: 0x71EDE80
        public void get_jointAngle(){} // RVA: 0x71EDED0
        public void GetMotorTorque(){} // RVA: 0x71EDF20
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_suspension_Injected(){} // RVA: 0x71EDF80
        public void set_suspension_Injected(){} // RVA: 0x71EDFE0
        public void get_motor_Injected(){} // RVA: 0x71EE040
        public void set_motor_Injected(){} // RVA: 0x71EE0A0
    }

    public class WindZone
    {
        public object hasPopInstruction;
        public object materialCount;
        public object popMaterialCount;
        public object absoluteDepth;
        public object hasMoved;
        public object cullTransparentMesh;

        // ── Methods ──
        public void get_mode(){} // RVA: 0x75051B0
        public void set_mode(){} // RVA: 0x7505200
        public void get_radius(){} // RVA: 0x7505260
        public void set_radius(){} // RVA: 0x75052B0
        public void get_windMain(){} // RVA: 0x7505310
        public void set_windMain(){} // RVA: 0x7505360
        public void get_windTurbulence(){} // RVA: 0x75053C0
        public void set_windTurbulence(){} // RVA: 0x7505410
        public void get_windPulseMagnitude(){} // RVA: 0x7505470
        public void set_windPulseMagnitude(){} // RVA: 0x75054C0
        public void get_windPulseFrequency(){} // RVA: 0x7505520
        public void set_windPulseFrequency(){} // RVA: 0x7505570
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class WritableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}