// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 15
// Methods: 129

namespace ThirdParty.Unity.UnityEngine
{
    public class HDROutputSettings : Object
    {
        public int m_DisplayIndex; // 0x10
        public UnityEngine.HDROutputSettings[] displays;
        public UnityEngine.HDROutputSettings _mainDisplay; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
        public void .cctor(){} // RVA: 0x7FFAC9871DF0
    }

    public class Halo : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Hash128 : ValueType
    {
        public ulong u64_0; // 0x10
        public ulong u64_1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC485CA00
        public void CompareTo(){} // RVA: 0x7FFAC98A7090 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC98A6E90
        public void Parse(){} // RVA: 0x7FFAC98A6EF0
        public void Hash128ToStringImpl(){} // RVA: 0x7FFAC98A6F60
        public void Equals(){} // RVA: 0x7FFAC98A7040 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98A7070
        public void op_Equality(){} // RVA: 0x7FFAC98A7170
        public void op_LessThan(){} // RVA: 0x7FFAC98A7190
        public void op_GreaterThan(){} // RVA: 0x7FFAC98A71B0
        public void Parse_Injected(){} // RVA: 0x7FFAC98A7200
        public void Hash128ToStringImpl_Injected(){} // RVA: 0x7FFAC98A7260
    }

    public class HeaderAttribute : PropertyAttribute
    {
        public string header; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class HelpURLAttribute : Attribute
    {
        public string m_Url; // 0x10
        public bool m_Dispatcher; // 0x18
        public string m_DispatchingFieldName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98BABF0
    }

    public class HideInCallstackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HideInInspector : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_motor(){} // RVA: 0x7FFAC999BBB0
        public void set_motor(){} // RVA: 0x7FFAC999BC20
        public void get_limits(){} // RVA: 0x7FFAC999BC80
        public void set_limits(){} // RVA: 0x7FFAC999BCF0
        public void get_spring(){} // RVA: 0x7FFAC999BD50
        public void set_spring(){} // RVA: 0x7FFAC999BDC0
        public void get_useMotor(){} // RVA: 0x7FFAC999BE20
        public void set_useMotor(){} // RVA: 0x7FFAC999BE70
        public void get_useLimits(){} // RVA: 0x7FFAC999BED0
        public void set_useLimits(){} // RVA: 0x7FFAC999BF20
        public void get_extendedLimits(){} // RVA: 0x7FFAC999BF80
        public void set_extendedLimits(){} // RVA: 0x7FFAC999BFD0
        public void get_useSpring(){} // RVA: 0x7FFAC999C030
        public void set_useSpring(){} // RVA: 0x7FFAC999C080
        public void get_velocity(){} // RVA: 0x7FFAC999C0E0
        public void get_angle(){} // RVA: 0x7FFAC999C130
        public void get_useAcceleration(){} // RVA: 0x7FFAC999C180
        public void set_useAcceleration(){} // RVA: 0x7FFAC999C1D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_motor_Injected(){} // RVA: 0x7FFAC999C230
        public void set_motor_Injected(){} // RVA: 0x7FFAC999C290
        public void get_limits_Injected(){} // RVA: 0x7FFAC999C2F0
        public void set_limits_Injected(){} // RVA: 0x7FFAC999C350
        public void get_spring_Injected(){} // RVA: 0x7FFAC999C3B0
        public void set_spring_Injected(){} // RVA: 0x7FFAC999C410
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
        public void get_useMotor(){} // RVA: 0x7FFAC9983A20
        public void set_useMotor(){} // RVA: 0x7FFAC9983A70
        public void get_useLimits(){} // RVA: 0x7FFAC9983AD0
        public void set_useLimits(){} // RVA: 0x7FFAC9983B20
        public void get_motor(){} // RVA: 0x7FFAC9983B80
        public void set_motor(){} // RVA: 0x7FFAC9983BE0
        public void get_limits(){} // RVA: 0x7FFAC9983C40
        public void set_limits(){} // RVA: 0x7FFAC9983CA0
        public void get_limitState(){} // RVA: 0x7FFAC9983D00
        public void get_referenceAngle(){} // RVA: 0x7FFAC9983D50
        public void get_jointAngle(){} // RVA: 0x7FFAC9983DA0
        public void get_jointSpeed(){} // RVA: 0x7FFAC9983DF0
        public void GetMotorTorque(){} // RVA: 0x7FFAC9983E40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_motor_Injected(){} // RVA: 0x7FFAC9983EA0
        public void set_motor_Injected(){} // RVA: 0x7FFAC9983F00
        public void get_limits_Injected(){} // RVA: 0x7FFAC9983F60
        public void set_limits_Injected(){} // RVA: 0x7FFAC9983FC0
    }

    public class HumanBone : ValueType
    {
        public string boneName; // 0x10
        public string humanName; // 0x18
        public UnityEngine.HumanLimit limit; // 0x20

        // ── Methods ──
        public void get_boneName(){} // RVA: 0x7FFAC51D9A30
        public void set_boneName(){} // RVA: 0x7FFAC38DFE40
        public void get_humanName(){} // RVA: 0x7FFAC86B4B80
        public void set_humanName(){} // RVA: 0x7FFAC4420240
    }

    public class HumanDescription : ValueType
    {
        public UnityEngine.HumanBone[] upperArmTwist; // 0x10
        public UnityEngine.SkeletonBone[] lowerArmTwist; // 0x18
        public float upperLegTwist; // 0x20
        public float lowerLegTwist; // 0x24
        public float armStretch; // 0x28
        public float legStretch; // 0x2C
        public float feetSpacing; // 0x30
        public float hasTranslationDoF; // 0x34
        public float m_FeetSpacing; // 0x38
        public float m_GlobalScale; // 0x3C
        public string m_RootMotionBoneName; // 0x40
        public bool m_HasTranslationDoF; // 0x48
        public bool m_HasExtraRoot; // 0x49
        public bool m_SkeletonHasParents; // 0x4A

        // ── Methods ──
        public void get_upperArmTwist(){} // RVA: 0x7FFAC9814DF0
        public void set_upperArmTwist(){} // RVA: 0x7FFAC304B330
        public void get_lowerArmTwist(){} // RVA: 0x7FFAC58A0690
        public void set_lowerArmTwist(){} // RVA: 0x7FFAC304B350
        public void get_upperLegTwist(){} // RVA: 0x7FFAC9811DF0
        public void set_upperLegTwist(){} // RVA: 0x7FFAC2F3C4D0
        public void get_lowerLegTwist(){} // RVA: 0x7FFAC9814E00
        public void set_lowerLegTwist(){} // RVA: 0x7FFAC2FEE580
        public void get_armStretch(){} // RVA: 0x7FFAC9812640
        public void set_armStretch(){} // RVA: 0x7FFAC4447440
        public void get_legStretch(){} // RVA: 0x7FFAC9814E10
        public void set_legStretch(){} // RVA: 0x7FFAC308EF60
        public void get_feetSpacing(){} // RVA: 0x7FFAC9830D30
        public void set_feetSpacing(){} // RVA: 0x7FFAC3000220
        public void get_hasTranslationDoF(){} // RVA: 0x7FFAC9830D40
        public void set_hasTranslationDoF(){} // RVA: 0x7FFAC31D95C0
    }

    public class HumanLimit : ValueType
    {
        public UnityEngine.Vector3 useDefaultValues; // 0x10
        public UnityEngine.Vector3 min; // 0x1C
        public UnityEngine.Vector3 max; // 0x28
        public float center; // 0x34
        public int axisLength; // 0x38

        // ── Methods ──
        public void get_useDefaultValues(){} // RVA: 0x7FFAC9814E20
        public void set_useDefaultValues(){} // RVA: 0x7FFAC9814E30
        public void get_min(){} // RVA: 0x7FFAC9811DA0
        public void set_min(){} // RVA: 0x7FFAC530B6C0
        public void get_max(){} // RVA: 0x7FFAC9811DC0
        public void set_max(){} // RVA: 0x7FFAC9811DE0
        public void get_center(){} // RVA: 0x7FFAC9830D10
        public void set_center(){} // RVA: 0x7FFAC6D348D0
        public void get_axisLength(){} // RVA: 0x7FFAC9814E10
        public void set_axisLength(){} // RVA: 0x7FFAC308EF60
    }

    public class HumanPose : ValueType
    {
        public UnityEngine.Vector3 bodyPosition; // 0x10
        public UnityEngine.Quaternion bodyRotation; // 0x1C
        public float[] muscles; // 0x30

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC98316A0
    }

    public class HumanPoseHandler : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void Internal_CreateFromRoot(){} // RVA: 0x7FFAC9831860
        public void Internal_CreateFromJointPaths(){} // RVA: 0x7FFAC98318C0
        public void Internal_Destroy(){} // RVA: 0x7FFAC9831920
        public void GetHumanPose(){} // RVA: 0x7FFAC9832230 | overloaded x2
        public void SetHumanPose(){} // RVA: 0x7FFAC9832310 | overloaded x2
        public void GetInternalHumanPose(){} // RVA: 0x7FFAC98323F0 | overloaded x2
        public void SetInternalHumanPose(){} // RVA: 0x7FFAC98324D0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC9831B70
        public void .ctor(){} // RVA: 0x7FFAC9831F70 | overloaded x2
    }

    public class HumanTrait : Object
    {
        public object MuscleCount;
        public object MuscleName;
        public object BoneCount;
        public object BoneName;
        public object RequiredBoneCount;

        // ── Methods ──
        public void get_MuscleCount(){} // RVA: 0x7FFAC98325B0
        public void GetBoneIndexFromMono(){} // RVA: 0x7FFAC9832600
        public void GetBoneIndexToMono(){} // RVA: 0x7FFAC9832650
        public void get_MuscleName(){} // RVA: 0x7FFAC98326A0
        public void get_BoneCount(){} // RVA: 0x7FFAC98326F0
        public void get_BoneName(){} // RVA: 0x7FFAC9832740
        public void MuscleFromBone(){} // RVA: 0x7FFAC9832790
        public void Internal_MuscleFromBone(){} // RVA: 0x7FFAC9832830
        public void BoneFromMuscle(){} // RVA: 0x7FFAC9832890
        public void Internal_BoneFromMuscle(){} // RVA: 0x7FFAC9832920
        public void RequiredBone(){} // RVA: 0x7FFAC9832970
        public void Internal_RequiredBone(){} // RVA: 0x7FFAC9832A00
        public void get_RequiredBoneCount(){} // RVA: 0x7FFAC9832A50
        public void GetMuscleDefaultMin(){} // RVA: 0x7FFAC9832AA0
        public void GetMuscleDefaultMax(){} // RVA: 0x7FFAC9832AF0
        public void GetBoneDefaultHierarchyMass(){} // RVA: 0x7FFAC9832B40
        public void GetParentBone(){} // RVA: 0x7FFAC9832BD0
        public void Internal_GetBoneHierarchyMass(){} // RVA: 0x7FFAC9832CB0
        public void Internal_GetParent(){} // RVA: 0x7FFAC9832D00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}