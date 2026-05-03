// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 12
// Methods: 101

namespace ThirdParty.Unity.UnityEngine
{
    public class Joint : Component
    {
        // ── Methods ──
        public void get_connectedBody(){} // RVA: 0x7FFE87D436E0
        public void set_connectedBody(){} // RVA: 0x7FFE87D43730
        public void get_connectedArticulationBody(){} // RVA: 0x7FFE87D43790
        public void set_connectedArticulationBody(){} // RVA: 0x7FFE87D437E0
        public void get_axis(){} // RVA: 0x7FFE87D43840
        public void set_axis(){} // RVA: 0x7FFE87D438B0
        public void get_anchor(){} // RVA: 0x7FFE87D43910
        public void set_anchor(){} // RVA: 0x7FFE87D43980
        public void get_connectedAnchor(){} // RVA: 0x7FFE87D439E0
        public void set_connectedAnchor(){} // RVA: 0x7FFE87D43A50
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFE87D43AB0
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFE87D43B00
        public void get_breakForce(){} // RVA: 0x7FFE87D43B60
        public void set_breakForce(){} // RVA: 0x7FFE87D43BB0
        public void get_breakTorque(){} // RVA: 0x7FFE87D43C10
        public void set_breakTorque(){} // RVA: 0x7FFE87D43C60
        public void get_enableCollision(){} // RVA: 0x7FFE87D43CC0
        public void set_enableCollision(){} // RVA: 0x7FFE87D43D10
        public void get_enablePreprocessing(){} // RVA: 0x7FFE87D43D70
        public void set_enablePreprocessing(){} // RVA: 0x7FFE87D43DC0
        public void get_massScale(){} // RVA: 0x7FFE87D43E20
        public void set_massScale(){} // RVA: 0x7FFE87D43E70
        public void get_connectedMassScale(){} // RVA: 0x7FFE87D43ED0
        public void set_connectedMassScale(){} // RVA: 0x7FFE87D43F20
        public void GetCurrentForces(){} // RVA: 0x7FFE87D43F80
        public void get_currentForce(){} // RVA: 0x7FFE87D43FF0
        public void get_currentTorque(){} // RVA: 0x7FFE87D44100
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_axis_Injected(){} // RVA: 0x7FFE87D44210
        public void set_axis_Injected(){} // RVA: 0x7FFE87D44270
        public void get_anchor_Injected(){} // RVA: 0x7FFE87D442D0
        public void set_anchor_Injected(){} // RVA: 0x7FFE87D44330
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFE87D44390
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFE87D443F0
    }

    public class Joint2D : Behaviour
    {
        // ── Methods ──
        public void get_attachedRigidbody(){} // RVA: 0x7FFE87D2B590
        public void get_connectedBody(){} // RVA: 0x7FFE87D2B5E0
        public void set_connectedBody(){} // RVA: 0x7FFE87D2B630
        public void get_enableCollision(){} // RVA: 0x7FFE87D2B690
        public void set_enableCollision(){} // RVA: 0x7FFE87D2B6E0
        public void get_breakForce(){} // RVA: 0x7FFE87D2B740
        public void set_breakForce(){} // RVA: 0x7FFE87D2B790
        public void get_breakTorque(){} // RVA: 0x7FFE87D2B7F0
        public void set_breakTorque(){} // RVA: 0x7FFE87D2B840
        public void get_breakAction(){} // RVA: 0x7FFE87D2B8A0
        public void set_breakAction(){} // RVA: 0x7FFE87D2B8F0
        public void get_reactionForce(){} // RVA: 0x7FFE87D2B950
        public void get_reactionTorque(){} // RVA: 0x7FFE87D2B9B0
        public void GetReactionForce(){} // RVA: 0x7FFE87D2BA00
        public void GetReactionTorque(){} // RVA: 0x7FFE87D2BA70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_reactionForce_Injected(){} // RVA: 0x7FFE87D2BAD0
        public void GetReactionForce_Injected(){} // RVA: 0x7FFE87D2BB30
    }

    public class JointAngleLimits2D : ValueType
    {
        public float m_LowerAngle; // 0x10
        public float m_UpperAngle; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFE8111ED20
        public void set_min(){} // RVA: 0x7FFE82D03BB0
        public void get_max(){} // RVA: 0x7FFE8111ED30
        public void set_max(){} // RVA: 0x7FFE82D03BD0
    }

    public class JointDrive : ValueType
    {
        public float m_PositionSpring; // 0x10
        public float m_PositionDamper; // 0x14
        public float m_MaximumForce; // 0x18
        public int m_UseAcceleration; // 0x1C

        // ── Methods ──
        public void get_positionSpring(){} // RVA: 0x7FFE8111ED20
        public void set_positionSpring(){} // RVA: 0x7FFE82D03BB0
        public void get_positionDamper(){} // RVA: 0x7FFE8111ED30
        public void set_positionDamper(){} // RVA: 0x7FFE82D03BD0
        public void get_maximumForce(){} // RVA: 0x7FFE8111ECF0
        public void set_maximumForce(){} // RVA: 0x7FFE82D03BC0
        public void get_useAcceleration(){} // RVA: 0x7FFE87D2FD40
        public void set_useAcceleration(){} // RVA: 0x7FFE87BBD230
    }

    public class JointLimits : ValueType
    {
        public float m_Min; // 0x10
        public float m_Max; // 0x14
        public float m_Bounciness; // 0x18
        public float m_BounceMinVelocity; // 0x1C
        public float m_ContactDistance; // 0x20

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFE8111ED20
        public void set_min(){} // RVA: 0x7FFE82D03BB0
        public void get_max(){} // RVA: 0x7FFE8111ED30
        public void set_max(){} // RVA: 0x7FFE82D03BD0
        public void get_bounciness(){} // RVA: 0x7FFE8111ECF0
        public void set_bounciness(){} // RVA: 0x7FFE82D03BC0
        public void get_bounceMinVelocity(){} // RVA: 0x7FFE8111ED00
        public void set_bounceMinVelocity(){} // RVA: 0x7FFE82D03B80
        public void get_contactDistance(){} // RVA: 0x7FFE87BBD360
        public void set_contactDistance(){} // RVA: 0x7FFE81225330
    }

    public class JointMotor : ValueType
    {
        public float m_TargetVelocity; // 0x10
        public float m_Force; // 0x14
        public int m_FreeSpin; // 0x18

        // ── Methods ──
        public void get_targetVelocity(){} // RVA: 0x7FFE8111ED20
        public void set_targetVelocity(){} // RVA: 0x7FFE82D03BB0
        public void get_force(){} // RVA: 0x7FFE8111ED30
        public void set_force(){} // RVA: 0x7FFE82D03BD0
        public void get_freeSpin(){} // RVA: 0x7FFE87D2FD50
        public void set_freeSpin(){} // RVA: 0x7FFE869EE070
    }

    public class JointMotor2D : ValueType
    {
        public float m_MotorSpeed; // 0x10
        public float m_MaximumMotorTorque; // 0x14

        // ── Methods ──
        public void get_motorSpeed(){} // RVA: 0x7FFE8111ED20
        public void set_motorSpeed(){} // RVA: 0x7FFE82D03BB0
        public void get_maxMotorTorque(){} // RVA: 0x7FFE8111ED30
        public void set_maxMotorTorque(){} // RVA: 0x7FFE82D03BD0
    }

    public class JointSpring : ValueType
    {
    }

    public class JointSuspension2D : ValueType
    {
        public float m_DampingRatio; // 0x10
        public float m_Frequency; // 0x14
        public float m_Angle; // 0x18

        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x7FFE8111ED20
        public void set_dampingRatio(){} // RVA: 0x7FFE82D03BB0
        public void get_frequency(){} // RVA: 0x7FFE8111ED30
        public void set_frequency(){} // RVA: 0x7FFE82D03BD0
        public void get_angle(){} // RVA: 0x7FFE8111ECF0
        public void set_angle(){} // RVA: 0x7FFE82D03BC0
    }

    public class JointTranslationLimits2D : ValueType
    {
        public float m_LowerTranslation; // 0x10
        public float m_UpperTranslation; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFE8111ED20
        public void set_min(){} // RVA: 0x7FFE82D03BB0
        public void get_max(){} // RVA: 0x7FFE8111ED30
        public void set_max(){} // RVA: 0x7FFE82D03BD0
    }

    public class JsonUtility : Object
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x7FFE87CEBBC0
        public void FromJsonInternal(){} // RVA: 0x7FFE87CEBC20
        public void ToJson(){} // RVA: 0x7FFE87CEBC90 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFE87CEBE40 | overloaded x2
        public void FromJsonOverwrite(){} // RVA: 0x7FFE87CEC020
    }

    public class jvalue : ValueType
    {
    }

}