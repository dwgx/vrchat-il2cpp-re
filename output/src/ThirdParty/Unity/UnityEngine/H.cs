// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 15
// Methods: 129

namespace ThirdParty.Unity.UnityEngine
{
    public class HDROutputSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5D070
        public void .cctor(){} // RVA: 0x70D97A0
    }

    public class Halo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Hash128
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D36F20
        public void CompareTo(){} // RVA: 0x710ECD0 | overloaded x2
        public void ToString(){} // RVA: 0x710EAD0
        public void Parse(){} // RVA: 0x710EB30
        public void Hash128ToStringImpl(){} // RVA: 0x710EBA0
        public void Equals(){} // RVA: 0x710EC80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x710ECB0
        public void op_Equality(){} // RVA: 0x710EDB0
        public void op_LessThan(){} // RVA: 0x710EDD0
        public void op_GreaterThan(){} // RVA: 0x710EDF0
        public void Parse_Injected(){} // RVA: 0x710EE40
        public void Hash128ToStringImpl_Injected(){} // RVA: 0x710EEA0
    }

    public class HeaderAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class HelpURLAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7122660
    }

    public class HideInCallstackAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HideInInspector
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HingeJoint
    {
        public object spring;
        public object damper;
        public object minDistance;
        public object maxDistance;
        public object tolerance;

        // ── Methods ──
        public void get_motor(){} // RVA: 0x72042B0
        public void set_motor(){} // RVA: 0x7204320
        public void get_limits(){} // RVA: 0x7204380
        public void set_limits(){} // RVA: 0x72043F0
        public void get_spring(){} // RVA: 0x7204450
        public void set_spring(){} // RVA: 0x72044C0
        public void get_useMotor(){} // RVA: 0x7204520
        public void set_useMotor(){} // RVA: 0x7204570
        public void get_useLimits(){} // RVA: 0x72045D0
        public void set_useLimits(){} // RVA: 0x7204620
        public void get_extendedLimits(){} // RVA: 0x7204680
        public void set_extendedLimits(){} // RVA: 0x72046D0
        public void get_useSpring(){} // RVA: 0x7204730
        public void set_useSpring(){} // RVA: 0x7204780
        public void get_velocity(){} // RVA: 0x72047E0
        public void get_angle(){} // RVA: 0x7204830
        public void get_useAcceleration(){} // RVA: 0x7204880
        public void set_useAcceleration(){} // RVA: 0x72048D0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_motor_Injected(){} // RVA: 0x7204930
        public void set_motor_Injected(){} // RVA: 0x7204990
        public void get_limits_Injected(){} // RVA: 0x72049F0
        public void set_limits_Injected(){} // RVA: 0x7204A50
        public void get_spring_Injected(){} // RVA: 0x7204AB0
        public void set_spring_Injected(){} // RVA: 0x7204B10
    }

    public class HingeJoint2D
    {
        public object autoConfigureAngle;
        public object angle;
        public object useMotor;
        public object useLimits;
        public object motor;
        public object limits;
        public object limitState;
        public object referenceAngle;

        // ── Methods ──
        public void get_useMotor(){} // RVA: 0x71EC120
        public void set_useMotor(){} // RVA: 0x71EC170
        public void get_useLimits(){} // RVA: 0x71EC1D0
        public void set_useLimits(){} // RVA: 0x71EC220
        public void get_motor(){} // RVA: 0x71EC280
        public void set_motor(){} // RVA: 0x71EC2E0
        public void get_limits(){} // RVA: 0x71EC340
        public void set_limits(){} // RVA: 0x71EC3A0
        public void get_limitState(){} // RVA: 0x71EC400
        public void get_referenceAngle(){} // RVA: 0x71EC450
        public void get_jointAngle(){} // RVA: 0x71EC4A0
        public void get_jointSpeed(){} // RVA: 0x71EC4F0
        public void GetMotorTorque(){} // RVA: 0x71EC540
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_motor_Injected(){} // RVA: 0x71EC5A0
        public void set_motor_Injected(){} // RVA: 0x71EC600
        public void get_limits_Injected(){} // RVA: 0x71EC660
        public void set_limits_Injected(){} // RVA: 0x71EC6C0
    }

    public class HumanBone
    {
        public string m_BoneName; // 0x10
        public string m_HumanName; // 0x18

        // ── Methods ──
        public void get_boneName(){} // RVA: 0x2738C50
        public void set_boneName(){} // RVA: 0x100A2F0
        public void get_humanName(){} // RVA: 0x5F1D510
        public void set_humanName(){} // RVA: 0x1968950
    }

    public class HumanDescription
    {
        public UnityEngine.HumanBone[] human; // 0x10
        public UnityEngine.SkeletonBone[] skeleton; // 0x18
        public float m_ArmTwist; // 0x20
        public float m_ForeArmTwist; // 0x24
        public float m_UpperLegTwist; // 0x28
        public float m_LegTwist; // 0x2C
        public float m_ArmStretch; // 0x30
        public float m_LegStretch; // 0x34

        // ── Methods ──
        public void get_upperArmTwist(){} // RVA: 0x707C4A0
        public void set_upperArmTwist(){} // RVA: 0x407330
        public void get_lowerArmTwist(){} // RVA: 0x2EECAB0
        public void set_lowerArmTwist(){} // RVA: 0x407350
        public void get_upperLegTwist(){} // RVA: 0x70794A0
        public void set_upperLegTwist(){} // RVA: 0x2F84D0
        public void get_lowerLegTwist(){} // RVA: 0x707C4B0
        public void set_lowerLegTwist(){} // RVA: 0x3AA580
        public void get_armStretch(){} // RVA: 0x7079CF0
        public void set_armStretch(){} // RVA: 0xFEC7A0
        public void get_legStretch(){} // RVA: 0x707C4C0
        public void set_legStretch(){} // RVA: 0x44AF60
        public void get_feetSpacing(){} // RVA: 0x70983C0
        public void set_feetSpacing(){} // RVA: 0x3BC220
        public void get_hasTranslationDoF(){} // RVA: 0x70983D0
        public void set_hasTranslationDoF(){} // RVA: 0x4A78C0
    }

    public class HumanLimit
    {
        public UnityEngine.Vector3 m_Min; // 0x10
        public UnityEngine.Vector3 m_Max; // 0x1C
        public UnityEngine.Vector3 m_Center; // 0x28
        public float m_AxisLength; // 0x34
        public int m_UseDefaultValues; // 0x38

        // ── Methods ──
        public void get_useDefaultValues(){} // RVA: 0x707C4D0
        public void set_useDefaultValues(){} // RVA: 0x707C4E0
        public void get_min(){} // RVA: 0x7079450
        public void set_min(){} // RVA: 0x210E450
        public void get_max(){} // RVA: 0x7079470
        public void set_max(){} // RVA: 0x7079490
        public void get_center(){} // RVA: 0x70983A0
        public void set_center(){} // RVA: 0x447FFC0
        public void get_axisLength(){} // RVA: 0x707C4C0
        public void set_axisLength(){} // RVA: 0x44AF60
    }

    public class HumanPose
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7098D30
    }

    public class HumanPoseHandler
    {
        // ── Methods ──
        public void Internal_CreateFromRoot(){} // RVA: 0x7098EF0
        public void Internal_CreateFromJointPaths(){} // RVA: 0x7098F50
        public void Internal_Destroy(){} // RVA: 0x7098FB0
        public void GetHumanPose(){} // RVA: 0x70998C0 | overloaded x2
        public void SetHumanPose(){} // RVA: 0x70999A0 | overloaded x2
        public void GetInternalHumanPose(){} // RVA: 0x7099A80 | overloaded x2
        public void SetInternalHumanPose(){} // RVA: 0x7099B60 | overloaded x2
        public void Dispose(){} // RVA: 0x7099200
        public void .ctor(){} // RVA: 0x7099600 | overloaded x2
    }

    public class HumanTrait
    {
        // ── Methods ──
        public void get_MuscleCount(){} // RVA: 0x7099C40
        public void GetBoneIndexFromMono(){} // RVA: 0x7099C90
        public void GetBoneIndexToMono(){} // RVA: 0x7099CE0
        public void get_MuscleName(){} // RVA: 0x7099D30
        public void get_BoneCount(){} // RVA: 0x7099D80
        public void get_BoneName(){} // RVA: 0x7099DD0
        public void MuscleFromBone(){} // RVA: 0x7099E20
        public void Internal_MuscleFromBone(){} // RVA: 0x7099EC0
        public void BoneFromMuscle(){} // RVA: 0x7099F20
        public void Internal_BoneFromMuscle(){} // RVA: 0x7099FB0
        public void RequiredBone(){} // RVA: 0x709A000
        public void Internal_RequiredBone(){} // RVA: 0x709A090
        public void get_RequiredBoneCount(){} // RVA: 0x709A0E0
        public void GetMuscleDefaultMin(){} // RVA: 0x709A130
        public void GetMuscleDefaultMax(){} // RVA: 0x709A180
        public void GetBoneDefaultHierarchyMass(){} // RVA: 0x709A1D0
        public void GetParentBone(){} // RVA: 0x709A260
        public void Internal_GetBoneHierarchyMass(){} // RVA: 0x709A340
        public void Internal_GetParent(){} // RVA: 0x709A390
        public void .ctor(){} // RVA: 0x2DD310
    }

}