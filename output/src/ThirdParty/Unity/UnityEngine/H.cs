// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 10
// Methods: 77

namespace ThirdParty.Unity.UnityEngine
{
    public class HDROutputSettings : Object
    {
        public int m_DisplayIndex; // 0x10
        public UnityEngine.HDROutputSettings[] displays;
        public UnityEngine.HDROutputSettings _mainDisplay; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EABFBB0
        public void .cctor(){} // RVA: 0x7FFD54C91DF0
    }

    public class Halo : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Hash128 : ValueType
    {
        public ulong u64_0; // 0x10
        public ulong u64_1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC7CA00
        public void CompareTo(){} // RVA: 0x7FFD54CC7090 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54CC6E90
        public void Parse(){} // RVA: 0x7FFD54CC6EF0
        public void Hash128ToStringImpl(){} // RVA: 0x7FFD54CC6F60
        public void Equals(){} // RVA: 0x7FFD54CC7040 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54CC7070
        public void op_Equality(){} // RVA: 0x7FFD54CC7170
        public void op_LessThan(){} // RVA: 0x7FFD54CC7190
        public void op_GreaterThan(){} // RVA: 0x7FFD54CC71B0
        public void Parse_Injected(){} // RVA: 0x7FFD54CC7200
        public void Hash128ToStringImpl_Injected(){} // RVA: 0x7FFD54CC7260
    }

    public class HelpURLAttribute : Attribute
    {
        public string m_Url; // 0x10
        public bool m_Dispatcher; // 0x18
        public string m_DispatchingFieldName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CDABF0
    }

    public class HideInInspector : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class HingeJoint : Joint
    {
        public object motor;
        public object limits;
        public object spring;
        public object useMotor;
        public object useLimits;
        public object extendedLimits;
        public object useSpring;
        public object velocity;
        public object angle;
        public object useAcceleration;

        // ── Methods ──
        public void get_motor(){} // RVA: 0x7FFD54DBBBB0
        public void set_motor(){} // RVA: 0x7FFD54DBBC20
        public void get_limits(){} // RVA: 0x7FFD54DBBC80
        public void set_limits(){} // RVA: 0x7FFD54DBBCF0
        public void get_spring(){} // RVA: 0x7FFD54DBBD50
        public void set_spring(){} // RVA: 0x7FFD54DBBDC0
        public void get_useMotor(){} // RVA: 0x7FFD54DBBE20
        public void set_useMotor(){} // RVA: 0x7FFD54DBBE70
        public void get_useLimits(){} // RVA: 0x7FFD54DBBED0
        public void set_useLimits(){} // RVA: 0x7FFD54DBBF20
        public void get_extendedLimits(){} // RVA: 0x7FFD54DBBF80
        public void set_extendedLimits(){} // RVA: 0x7FFD54DBBFD0
        public void get_useSpring(){} // RVA: 0x7FFD54DBC030
        public void set_useSpring(){} // RVA: 0x7FFD54DBC080
        public void get_velocity(){} // RVA: 0x7FFD54DBC0E0
        public void get_angle(){} // RVA: 0x7FFD54DBC130
        public void get_useAcceleration(){} // RVA: 0x7FFD54DBC180
        public void set_useAcceleration(){} // RVA: 0x7FFD54DBC1D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_motor_Injected(){} // RVA: 0x7FFD54DBC230
        public void set_motor_Injected(){} // RVA: 0x7FFD54DBC290
        public void get_limits_Injected(){} // RVA: 0x7FFD54DBC2F0
        public void set_limits_Injected(){} // RVA: 0x7FFD54DBC350
        public void get_spring_Injected(){} // RVA: 0x7FFD54DBC3B0
        public void set_spring_Injected(){} // RVA: 0x7FFD54DBC410
    }

    public class HingeJoint2D : AnchoredJoint2D
    {
        public object useMotor;
        public object useLimits;
        public object motor;
        public object limits;
        public object limitState;
        public object referenceAngle;
        public object jointAngle;
        public object jointSpeed;

        // ── Methods ──
        public void get_useMotor(){} // RVA: 0x7FFD54DA3A20
        public void set_useMotor(){} // RVA: 0x7FFD54DA3A70
        public void get_useLimits(){} // RVA: 0x7FFD54DA3AD0
        public void set_useLimits(){} // RVA: 0x7FFD54DA3B20
        public void get_motor(){} // RVA: 0x7FFD54DA3B80
        public void set_motor(){} // RVA: 0x7FFD54DA3BE0
        public void get_limits(){} // RVA: 0x7FFD54DA3C40
        public void set_limits(){} // RVA: 0x7FFD54DA3CA0
        public void get_limitState(){} // RVA: 0x7FFD54DA3D00
        public void get_referenceAngle(){} // RVA: 0x7FFD54DA3D50
        public void get_jointAngle(){} // RVA: 0x7FFD54DA3DA0
        public void get_jointSpeed(){} // RVA: 0x7FFD54DA3DF0
        public void GetMotorTorque(){} // RVA: 0x7FFD54DA3E40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_motor_Injected(){} // RVA: 0x7FFD54DA3EA0
        public void set_motor_Injected(){} // RVA: 0x7FFD54DA3F00
        public void get_limits_Injected(){} // RVA: 0x7FFD54DA3F60
        public void set_limits_Injected(){} // RVA: 0x7FFD54DA3FC0
    }

    public class HumanBone : ValueType
    {
        public string boneName; // 0x10
        public string humanName; // 0x18
        public UnityEngine.HumanLimit limit; // 0x20

        // ── Methods ──
        public void get_boneName(){} // RVA: 0x7FFD505F9A30
        public void set_boneName(){} // RVA: 0x7FFD4ECFFE40
        public void get_humanName(){} // RVA: 0x7FFD53AD4B80
        public void set_humanName(){} // RVA: 0x7FFD4F840240
    }

    public class HumanLimit : ValueType
    {
        public UnityEngine.Vector3 useDefaultValues; // 0x10
        public UnityEngine.Vector3 min; // 0x1C
        public UnityEngine.Vector3 max; // 0x28
        public float center; // 0x34
        public int axisLength; // 0x38

        // ── Methods ──
        public void get_useDefaultValues(){} // RVA: 0x7FFD54C34E20
        public void set_useDefaultValues(){} // RVA: 0x7FFD54C34E30
        public void get_min(){} // RVA: 0x7FFD54C31DA0
        public void set_min(){} // RVA: 0x7FFD5072B6C0
        public void get_max(){} // RVA: 0x7FFD54C31DC0
        public void set_max(){} // RVA: 0x7FFD54C31DE0
        public void get_center(){} // RVA: 0x7FFD54C50D10
        public void set_center(){} // RVA: 0x7FFD521548D0
        public void get_axisLength(){} // RVA: 0x7FFD54C34E10
        public void set_axisLength(){} // RVA: 0x7FFD4E4AEF60
    }

    public class HumanPose : ValueType
    {
        public UnityEngine.Vector3 bodyPosition; // 0x10
        public UnityEngine.Quaternion bodyRotation; // 0x1C
        public float[] muscles; // 0x30

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD54C516A0
    }

}