// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 137

namespace ThirdParty.Unity.UnityEngine
{
    public class WWWForm : Object
    {
        public byte[] DefaultEncoding;
        public byte[] crlf; // 0x8
        public byte[] contentTypeHeader; // 0x10
        public byte[] dispositionHeader; // 0x18
        public byte[] endQuote; // 0x20
        public byte[] fileNameField; // 0x28
        public byte[] ampersand; // 0x30
        public byte[] equal; // 0x38

        // ── Methods ──
        public void get_DefaultEncoding(){} // RVA: 0x7FFAC9C91360
        public void .cctor(){} // RVA: 0x7FFAC9C91370
    }

    public class WWWTranscoder : Object
    {
        public byte[] ucHexChars;
        public byte[] lcHexChars; // 0x8
        public byte urlEscapeChar; // 0x10
        public byte[] urlSpace; // 0x18
        public byte[] dataSpace; // 0x20
        public byte[] urlForbidden; // 0x28
        public byte qpEscapeChar; // 0x30
        public byte[] qpSpace; // 0x38
        public byte[] qpForbidden; // 0x40

        // ── Methods ──
        public void Hex2Byte(){} // RVA: 0x7FFAC9C91940
        public void Byte2Hex(){} // RVA: 0x7FFAC9C919D0
        public void URLEncode(){} // RVA: 0x7FFAC9C91A10
        public void Encode(){} // RVA: 0x7FFAC9C91A90
        public void ByteArrayContains(){} // RVA: 0x7FFAC9C91ED0
        public void URLDecode(){} // RVA: 0x7FFAC9C91F20
        public void ByteSubArrayEquals(){} // RVA: 0x7FFAC9C91F90
        public void Decode(){} // RVA: 0x7FFAC9C92020
        public void .cctor(){} // RVA: 0x7FFAC9C92370
    }

    public class WaitForEndOfFrame : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class WaitForFixedUpdate : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class WaitForSeconds : YieldInstruction
    {
        public float m_Seconds; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC304B330
    }

    public class WaitForSecondsRealtime : CustomYieldInstruction
    {
        public float waitTime; // 0x10
        public float keepWaiting; // 0x14

        // ── Methods ──
        public void get_waitTime(){} // RVA: 0x7FFAC304B320
        public void set_waitTime(){} // RVA: 0x7FFAC304B330
        public void get_keepWaiting(){} // RVA: 0x7FFAC98C9000
        public void .ctor(){} // RVA: 0x7FFAC98C90E0
        public void Reset(){} // RVA: 0x7FFAC98C90F0
    }

    public class WaitUntil : CustomYieldInstruction
    {
        public System.Func`1<bool> keepWaiting; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAC98C9100
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class WaitWhile : CustomYieldInstruction
    {
        public System.Func`1<bool> keepWaiting; // 0x10

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAC3D3B830
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class WebCamDevice : ValueType
    {
        public string name; // 0x10
        public string isFrontFacing; // 0x18
        public int m_Flags; // 0x20
        public 0x6B2C02A0 m_Kind; // 0x24
        public UnityEngine.Resolution[] m_Resolutions; // 0x28

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC51D9A30
        public void get_isFrontFacing(){} // RVA: 0x7FFAC984A590
    }

    public class WebCamTexture : Texture
    {
        public object devices;
        public object isPlaying;
        public object videoRotationAngle;
        public object videoVerticallyMirrored;
        public object didUpdateThisFrame;

        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFAC984A5A0
        public void .ctor(){} // RVA: 0x7FFAC984A5F0
        public void Play(){} // RVA: 0x7FFAC984A6E0
        public void Pause(){} // RVA: 0x7FFAC984A730
        public void Stop(){} // RVA: 0x7FFAC984A780
        public void get_isPlaying(){} // RVA: 0x7FFAC984A7D0
        public void get_videoRotationAngle(){} // RVA: 0x7FFAC984A820
        public void get_videoVerticallyMirrored(){} // RVA: 0x7FFAC984A870
        public void get_didUpdateThisFrame(){} // RVA: 0x7FFAC984A8C0
        public void GetPixels32(){} // RVA: 0x7FFAC984A910
        public void Internal_CreateWebCamTexture(){} // RVA: 0x7FFAC984A970
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
        public void get_center(){} // RVA: 0x7FFAC9C96F00
        public void set_center(){} // RVA: 0x7FFAC9C96F70
        public void get_radius(){} // RVA: 0x7FFAC9C96FD0
        public void set_radius(){} // RVA: 0x7FFAC9C97020
        public void get_suspensionDistance(){} // RVA: 0x7FFAC9C97080
        public void set_suspensionDistance(){} // RVA: 0x7FFAC9C970D0
        public void get_suspensionSpring(){} // RVA: 0x7FFAC9C97130
        public void set_suspensionSpring(){} // RVA: 0x7FFAC9C971A0
        public void get_suspensionExpansionLimited(){} // RVA: 0x7FFAC9C97200
        public void set_suspensionExpansionLimited(){} // RVA: 0x7FFAC9C97250
        public void get_forceAppPointDistance(){} // RVA: 0x7FFAC9C972B0
        public void set_forceAppPointDistance(){} // RVA: 0x7FFAC9C97300
        public void get_mass(){} // RVA: 0x7FFAC9C97360
        public void set_mass(){} // RVA: 0x7FFAC9C973B0
        public void get_wheelDampingRate(){} // RVA: 0x7FFAC9C97410
        public void set_wheelDampingRate(){} // RVA: 0x7FFAC9C97460
        public void get_forwardFriction(){} // RVA: 0x7FFAC9C974C0
        public void set_forwardFriction(){} // RVA: 0x7FFAC9C97530
        public void get_sidewaysFriction(){} // RVA: 0x7FFAC9C97590
        public void set_sidewaysFriction(){} // RVA: 0x7FFAC9C97600
        public void get_motorTorque(){} // RVA: 0x7FFAC9C97660
        public void set_motorTorque(){} // RVA: 0x7FFAC9C976B0
        public void get_brakeTorque(){} // RVA: 0x7FFAC9C97710
        public void set_brakeTorque(){} // RVA: 0x7FFAC9C97760
        public void get_steerAngle(){} // RVA: 0x7FFAC9C977C0
        public void set_steerAngle(){} // RVA: 0x7FFAC9C97810
        public void get_isGrounded(){} // RVA: 0x7FFAC9C97870
        public void get_rpm(){} // RVA: 0x7FFAC9C978C0
        public void get_sprungMass(){} // RVA: 0x7FFAC9C97910
        public void set_sprungMass(){} // RVA: 0x7FFAC9C97960
        public void get_rotationSpeed(){} // RVA: 0x7FFAC9C979C0
        public void set_rotationSpeed(){} // RVA: 0x7FFAC9C97A10
        public void ResetSprungMasses(){} // RVA: 0x7FFAC9C97A70
        public void ConfigureVehicleSubsteps(){} // RVA: 0x7FFAC9C97AC0
        public void GetWorldPose(){} // RVA: 0x7FFAC9C97B40
        public void GetGroundHit(){} // RVA: 0x7FFAC9C97BB0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_center_Injected(){} // RVA: 0x7FFAC9C97C10
        public void set_center_Injected(){} // RVA: 0x7FFAC9C97C70
        public void get_suspensionSpring_Injected(){} // RVA: 0x7FFAC9C97CD0
        public void set_suspensionSpring_Injected(){} // RVA: 0x7FFAC9C97D30
        public void get_forwardFriction_Injected(){} // RVA: 0x7FFAC9C97D90
        public void set_forwardFriction_Injected(){} // RVA: 0x7FFAC9C97DF0
        public void get_sidewaysFriction_Injected(){} // RVA: 0x7FFAC9C97E50
        public void set_sidewaysFriction_Injected(){} // RVA: 0x7FFAC9C97EB0
    }

    public class WheelFrictionCurve : ValueType
    {
        public float extremumSlip; // 0x10
        public float extremumValue; // 0x14
        public float asymptoteSlip; // 0x18
        public float asymptoteValue; // 0x1C
        public float stiffness; // 0x20

        // ── Methods ──
        public void get_extremumSlip(){} // RVA: 0x7FFAC2F44D20
        public void set_extremumSlip(){} // RVA: 0x7FFAC4A9B910
        public void get_extremumValue(){} // RVA: 0x7FFAC2F44D30
        public void set_extremumValue(){} // RVA: 0x7FFAC4A9B8F0
        public void get_asymptoteSlip(){} // RVA: 0x7FFAC2F44CF0
        public void set_asymptoteSlip(){} // RVA: 0x7FFAC4A9B920
        public void get_asymptoteValue(){} // RVA: 0x7FFAC2F44D00
        public void set_asymptoteValue(){} // RVA: 0x7FFAC4A9B8C0
        public void get_stiffness(){} // RVA: 0x7FFAC9814DF0
        public void set_stiffness(){} // RVA: 0x7FFAC304B330
    }

    public class WheelHit : ValueType
    {
        public UnityEngine.Vector3 collider; // 0x10
        public UnityEngine.Vector3 point; // 0x1C
        public UnityEngine.Vector3 normal; // 0x28
        public UnityEngine.Vector3 forwardDir; // 0x34
        public float sidewaysDir; // 0x40
        public float force; // 0x44
        public float forwardSlip; // 0x48
        public UnityEngine.Collider sidewaysSlip; // 0x50

        // ── Methods ──
        public void get_collider(){} // RVA: 0x7FFAC991F730
        public void set_collider(){} // RVA: 0x7FFAC2F49200
        public void get_point(){} // RVA: 0x7FFAC9811DA0
        public void set_point(){} // RVA: 0x7FFAC530B6C0
        public void get_normal(){} // RVA: 0x7FFAC9811DC0
        public void set_normal(){} // RVA: 0x7FFAC9811DE0
        public void get_forwardDir(){} // RVA: 0x7FFAC9830D10
        public void set_forwardDir(){} // RVA: 0x7FFAC6D348D0
        public void get_sidewaysDir(){} // RVA: 0x7FFAC9C96EE0
        public void set_sidewaysDir(){} // RVA: 0x7FFAC2F7CCC0
        public void get_force(){} // RVA: 0x7FFAC993FB20
        public void set_force(){} // RVA: 0x7FFAC47394E0
        public void get_forwardSlip(){} // RVA: 0x7FFAC993FB40
        public void set_forwardSlip(){} // RVA: 0x7FFAC2FEB640
        public void get_sidewaysSlip(){} // RVA: 0x7FFAC971C6E0
        public void set_sidewaysSlip(){} // RVA: 0x7FFAC3717190
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
        public void get_suspension(){} // RVA: 0x7FFAC99854A0
        public void set_suspension(){} // RVA: 0x7FFAC9985510
        public void get_useMotor(){} // RVA: 0x7FFAC9985570
        public void set_useMotor(){} // RVA: 0x7FFAC99855C0
        public void get_motor(){} // RVA: 0x7FFAC9985620
        public void set_motor(){} // RVA: 0x7FFAC9985680
        public void get_jointTranslation(){} // RVA: 0x7FFAC99856E0
        public void get_jointLinearSpeed(){} // RVA: 0x7FFAC9985730
        public void get_jointSpeed(){} // RVA: 0x7FFAC9985780
        public void get_jointAngle(){} // RVA: 0x7FFAC99857D0
        public void GetMotorTorque(){} // RVA: 0x7FFAC9985820
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_suspension_Injected(){} // RVA: 0x7FFAC9985880
        public void set_suspension_Injected(){} // RVA: 0x7FFAC99858E0
        public void get_motor_Injected(){} // RVA: 0x7FFAC9985940
        public void set_motor_Injected(){} // RVA: 0x7FFAC99859A0
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
        public void get_mode(){} // RVA: 0x7FFAC9C9CB30
        public void set_mode(){} // RVA: 0x7FFAC9C9CB80
        public void get_radius(){} // RVA: 0x7FFAC9C9CBE0
        public void set_radius(){} // RVA: 0x7FFAC9C9CC30
        public void get_windMain(){} // RVA: 0x7FFAC9C9CC90
        public void set_windMain(){} // RVA: 0x7FFAC9C9CCE0
        public void get_windTurbulence(){} // RVA: 0x7FFAC9C9CD40
        public void set_windTurbulence(){} // RVA: 0x7FFAC9C9CD90
        public void get_windPulseMagnitude(){} // RVA: 0x7FFAC9C9CDF0
        public void set_windPulseMagnitude(){} // RVA: 0x7FFAC9C9CE40
        public void get_windPulseFrequency(){} // RVA: 0x7FFAC9C9CEA0
        public void set_windPulseFrequency(){} // RVA: 0x7FFAC9C9CEF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class WritableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}