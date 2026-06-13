// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 12
// Methods: 101

namespace ThirdParty.Unity.UnityEngine
{
    public class Joint
    {
        public object swingAxis;
        public object twistLimitSpring;
        public object swingLimitSpring;
        public object lowTwistLimit;
        public object highTwistLimit;
        public object swing1Limit;
        public object swing2Limit;
        public object enableProjection;
        public object projectionDistance;
        public object projectionAngle;

        // ── Methods ──
        public void get_connectedBody(){} // RVA: 0x7203540
        public void set_connectedBody(){} // RVA: 0x7203590
        public void get_connectedArticulationBody(){} // RVA: 0x72035F0
        public void set_connectedArticulationBody(){} // RVA: 0x7203640
        public void get_axis(){} // RVA: 0x72036A0
        public void set_axis(){} // RVA: 0x7203710
        public void get_anchor(){} // RVA: 0x7203770
        public void set_anchor(){} // RVA: 0x72037E0
        public void get_connectedAnchor(){} // RVA: 0x7203840
        public void set_connectedAnchor(){} // RVA: 0x72038B0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7203910
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7203960
        public void get_breakForce(){} // RVA: 0x72039C0
        public void set_breakForce(){} // RVA: 0x7203A10
        public void get_breakTorque(){} // RVA: 0x7203A70
        public void set_breakTorque(){} // RVA: 0x7203AC0
        public void get_enableCollision(){} // RVA: 0x7203B20
        public void set_enableCollision(){} // RVA: 0x7203B70
        public void get_enablePreprocessing(){} // RVA: 0x7203BD0
        public void set_enablePreprocessing(){} // RVA: 0x7203C20
        public void get_massScale(){} // RVA: 0x7203C80
        public void set_massScale(){} // RVA: 0x7203CD0
        public void get_connectedMassScale(){} // RVA: 0x7203D30
        public void set_connectedMassScale(){} // RVA: 0x7203D80
        public void GetCurrentForces(){} // RVA: 0x7203DE0
        public void get_currentForce(){} // RVA: 0x7203E50
        public void get_currentTorque(){} // RVA: 0x7203F60
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_axis_Injected(){} // RVA: 0x7204070
        public void set_axis_Injected(){} // RVA: 0x72040D0
        public void get_anchor_Injected(){} // RVA: 0x7204130
        public void set_anchor_Injected(){} // RVA: 0x7204190
        public void get_connectedAnchor_Injected(){} // RVA: 0x72041F0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7204250
    }

    public class Joint2D
    {
        public object anchor;
        public object connectedAnchor;
        public object autoConfigureConnectedAnchor;

        // ── Methods ──
        public void get_attachedRigidbody(){} // RVA: 0x71EB3F0
        public void get_connectedBody(){} // RVA: 0x71EB440
        public void set_connectedBody(){} // RVA: 0x71EB490
        public void get_enableCollision(){} // RVA: 0x71EB4F0
        public void set_enableCollision(){} // RVA: 0x71EB540
        public void get_breakForce(){} // RVA: 0x71EB5A0
        public void set_breakForce(){} // RVA: 0x71EB5F0
        public void get_breakTorque(){} // RVA: 0x71EB650
        public void set_breakTorque(){} // RVA: 0x71EB6A0
        public void get_breakAction(){} // RVA: 0x71EB700
        public void set_breakAction(){} // RVA: 0x71EB750
        public void get_reactionForce(){} // RVA: 0x71EB7B0
        public void get_reactionTorque(){} // RVA: 0x71EB810
        public void GetReactionForce(){} // RVA: 0x71EB860
        public void GetReactionTorque(){} // RVA: 0x71EB8D0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_reactionForce_Injected(){} // RVA: 0x71EB930
        public void GetReactionForce_Injected(){} // RVA: 0x71EB990
    }

    public class JointAngleLimits2D
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x300D20
        public void set_min(){} // RVA: 0x1F78330
        public void get_max(){} // RVA: 0x300D30
        public void set_max(){} // RVA: 0x1F78350
    }

    public class JointDrive
    {
        public float m_PositionSpring; // 0x10
        public float m_PositionDamper; // 0x14
        public float m_MaximumForce; // 0x18
        public int m_UseAcceleration; // 0x1C

        // ── Methods ──
        public void get_positionSpring(){} // RVA: 0x300D20
        public void set_positionSpring(){} // RVA: 0x1F78330
        public void get_positionDamper(){} // RVA: 0x300D30
        public void set_positionDamper(){} // RVA: 0x1F78350
        public void get_maximumForce(){} // RVA: 0x300CF0
        public void set_maximumForce(){} // RVA: 0x1F78340
        public void get_useAcceleration(){} // RVA: 0x71EFBA0
        public void set_useAcceleration(){} // RVA: 0x707C370
    }

    public class JointLimits
    {
        public float m_Min; // 0x10
        public float m_Max; // 0x14
        public float m_Bounciness; // 0x18
        public float m_BounceMinVelocity; // 0x1C
        public float m_ContactDistance; // 0x20

        // ── Methods ──
        public void get_min(){} // RVA: 0x300D20
        public void set_min(){} // RVA: 0x1F78330
        public void get_max(){} // RVA: 0x300D30
        public void set_max(){} // RVA: 0x1F78350
        public void get_bounciness(){} // RVA: 0x300CF0
        public void set_bounciness(){} // RVA: 0x1F78340
        public void get_bounceMinVelocity(){} // RVA: 0x300D00
        public void set_bounceMinVelocity(){} // RVA: 0x1F78380
        public void get_contactDistance(){} // RVA: 0x707C4A0
        public void set_contactDistance(){} // RVA: 0x407330
    }

    public class JointMotor
    {
        public float m_TargetVelocity; // 0x10
        public float m_Force; // 0x14
        public int m_FreeSpin; // 0x18

        // ── Methods ──
        public void get_targetVelocity(){} // RVA: 0x300D20
        public void set_targetVelocity(){} // RVA: 0x1F78330
        public void get_force(){} // RVA: 0x300D30
        public void set_force(){} // RVA: 0x1F78350
        public void get_freeSpin(){} // RVA: 0x71EFBB0
        public void set_freeSpin(){} // RVA: 0x5EAD230
    }

    public class JointMotor2D
    {
        public float dampingRatio; // 0x10
        public float frequency; // 0x14

        // ── Methods ──
        public void get_motorSpeed(){} // RVA: 0x300D20
        public void set_motorSpeed(){} // RVA: 0x1F78330
        public void get_maxMotorTorque(){} // RVA: 0x300D30
        public void set_maxMotorTorque(){} // RVA: 0x1F78350
    }

    public class JointSpring
    {
    }

    public class JointSuspension2D
    {
        public float m_DampingRatio; // 0x10
        public float m_Frequency; // 0x14
        public float m_Angle; // 0x18

        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x300D20
        public void set_dampingRatio(){} // RVA: 0x1F78330
        public void get_frequency(){} // RVA: 0x300D30
        public void set_frequency(){} // RVA: 0x1F78350
        public void get_angle(){} // RVA: 0x300CF0
        public void set_angle(){} // RVA: 0x1F78340
    }

    public class JointTranslationLimits2D
    {
        public float motorSpeed; // 0x10
        public float maxMotorTorque; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x300D20
        public void set_min(){} // RVA: 0x1F78330
        public void get_max(){} // RVA: 0x300D30
        public void set_max(){} // RVA: 0x1F78350
    }

    public class JsonUtility
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x71ABA20
        public void FromJsonInternal(){} // RVA: 0x71ABA80
        public void ToJson(){} // RVA: 0x71ABAF0 | overloaded x2
        public void FromJson(){} // RVA: 0x71ABCA0 | overloaded x2
        public void FromJsonOverwrite(){} // RVA: 0x71ABE80
    }

    public class jvalue
    {
    }

}