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
        public void get_connectedBody(){} // RVA: 0x7FFAF9CB3540
        public void set_connectedBody(){} // RVA: 0x7FFAF9CB3590
        public void get_connectedArticulationBody(){} // RVA: 0x7FFAF9CB35F0
        public void set_connectedArticulationBody(){} // RVA: 0x7FFAF9CB3640
        public void get_axis(){} // RVA: 0x7FFAF9CB36A0
        public void set_axis(){} // RVA: 0x7FFAF9CB3710
        public void get_anchor(){} // RVA: 0x7FFAF9CB3770
        public void set_anchor(){} // RVA: 0x7FFAF9CB37E0
        public void get_connectedAnchor(){} // RVA: 0x7FFAF9CB3840
        public void set_connectedAnchor(){} // RVA: 0x7FFAF9CB38B0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAF9CB3910
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAF9CB3960
        public void get_breakForce(){} // RVA: 0x7FFAF9CB39C0
        public void set_breakForce(){} // RVA: 0x7FFAF9CB3A10
        public void get_breakTorque(){} // RVA: 0x7FFAF9CB3A70
        public void set_breakTorque(){} // RVA: 0x7FFAF9CB3AC0
        public void get_enableCollision(){} // RVA: 0x7FFAF9CB3B20
        public void set_enableCollision(){} // RVA: 0x7FFAF9CB3B70
        public void get_enablePreprocessing(){} // RVA: 0x7FFAF9CB3BD0
        public void set_enablePreprocessing(){} // RVA: 0x7FFAF9CB3C20
        public void get_massScale(){} // RVA: 0x7FFAF9CB3C80
        public void set_massScale(){} // RVA: 0x7FFAF9CB3CD0
        public void get_connectedMassScale(){} // RVA: 0x7FFAF9CB3D30
        public void set_connectedMassScale(){} // RVA: 0x7FFAF9CB3D80
        public void GetCurrentForces(){} // RVA: 0x7FFAF9CB3DE0
        public void get_currentForce(){} // RVA: 0x7FFAF9CB3E50
        public void get_currentTorque(){} // RVA: 0x7FFAF9CB3F60
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_axis_Injected(){} // RVA: 0x7FFAF9CB4070
        public void set_axis_Injected(){} // RVA: 0x7FFAF9CB40D0
        public void get_anchor_Injected(){} // RVA: 0x7FFAF9CB4130
        public void set_anchor_Injected(){} // RVA: 0x7FFAF9CB4190
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFAF9CB41F0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFAF9CB4250
    }

    public class Joint2D
    {
        public object anchor;
        public object connectedAnchor;
        public object autoConfigureConnectedAnchor;

        // ── Methods ──
        public void get_attachedRigidbody(){} // RVA: 0x7FFAF9C9B3F0
        public void get_connectedBody(){} // RVA: 0x7FFAF9C9B440
        public void set_connectedBody(){} // RVA: 0x7FFAF9C9B490
        public void get_enableCollision(){} // RVA: 0x7FFAF9C9B4F0
        public void set_enableCollision(){} // RVA: 0x7FFAF9C9B540
        public void get_breakForce(){} // RVA: 0x7FFAF9C9B5A0
        public void set_breakForce(){} // RVA: 0x7FFAF9C9B5F0
        public void get_breakTorque(){} // RVA: 0x7FFAF9C9B650
        public void set_breakTorque(){} // RVA: 0x7FFAF9C9B6A0
        public void get_breakAction(){} // RVA: 0x7FFAF9C9B700
        public void set_breakAction(){} // RVA: 0x7FFAF9C9B750
        public void get_reactionForce(){} // RVA: 0x7FFAF9C9B7B0
        public void get_reactionTorque(){} // RVA: 0x7FFAF9C9B810
        public void GetReactionForce(){} // RVA: 0x7FFAF9C9B860
        public void GetReactionTorque(){} // RVA: 0x7FFAF9C9B8D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_reactionForce_Injected(){} // RVA: 0x7FFAF9C9B930
        public void GetReactionForce_Injected(){} // RVA: 0x7FFAF9C9B990
    }

    public class JointAngleLimits2D
    {
        public object min;
        public object max;

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAF2DB0D20
        public void set_min(){} // RVA: 0x7FFAF4A28330
        public void get_max(){} // RVA: 0x7FFAF2DB0D30
        public void set_max(){} // RVA: 0x7FFAF4A28350
    }

    public class JointDrive
    {
        // ── Methods ──
        public void get_positionSpring(){} // RVA: 0x7FFAF2DB0D20
        public void set_positionSpring(){} // RVA: 0x7FFAF4A28330
        public void get_positionDamper(){} // RVA: 0x7FFAF2DB0D30
        public void set_positionDamper(){} // RVA: 0x7FFAF4A28350
        public void get_maximumForce(){} // RVA: 0x7FFAF2DB0CF0
        public void set_maximumForce(){} // RVA: 0x7FFAF4A28340
        public void get_useAcceleration(){} // RVA: 0x7FFAF9C9FBA0
        public void set_useAcceleration(){} // RVA: 0x7FFAF9B2C370
    }

    public class JointLimits
    {
        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAF2DB0D20
        public void set_min(){} // RVA: 0x7FFAF4A28330
        public void get_max(){} // RVA: 0x7FFAF2DB0D30
        public void set_max(){} // RVA: 0x7FFAF4A28350
        public void get_bounciness(){} // RVA: 0x7FFAF2DB0CF0
        public void set_bounciness(){} // RVA: 0x7FFAF4A28340
        public void get_bounceMinVelocity(){} // RVA: 0x7FFAF2DB0D00
        public void set_bounceMinVelocity(){} // RVA: 0x7FFAF4A28380
        public void get_contactDistance(){} // RVA: 0x7FFAF9B2C4A0
        public void set_contactDistance(){} // RVA: 0x7FFAF2EB7330
    }

    public class JointMotor
    {
        // ── Methods ──
        public void get_targetVelocity(){} // RVA: 0x7FFAF2DB0D20
        public void set_targetVelocity(){} // RVA: 0x7FFAF4A28330
        public void get_force(){} // RVA: 0x7FFAF2DB0D30
        public void set_force(){} // RVA: 0x7FFAF4A28350
        public void get_freeSpin(){} // RVA: 0x7FFAF9C9FBB0
        public void set_freeSpin(){} // RVA: 0x7FFAF895D230
    }

    public class JointMotor2D
    {
        public object dampingRatio;
        public object frequency;

        // ── Methods ──
        public void get_motorSpeed(){} // RVA: 0x7FFAF2DB0D20
        public void set_motorSpeed(){} // RVA: 0x7FFAF4A28330
        public void get_maxMotorTorque(){} // RVA: 0x7FFAF2DB0D30
        public void set_maxMotorTorque(){} // RVA: 0x7FFAF4A28350
    }

    public class JointSpring
    {
    }

    public class JointSuspension2D
    {
        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x7FFAF2DB0D20
        public void set_dampingRatio(){} // RVA: 0x7FFAF4A28330
        public void get_frequency(){} // RVA: 0x7FFAF2DB0D30
        public void set_frequency(){} // RVA: 0x7FFAF4A28350
        public void get_angle(){} // RVA: 0x7FFAF2DB0CF0
        public void set_angle(){} // RVA: 0x7FFAF4A28340
    }

    public class JointTranslationLimits2D
    {
        public object motorSpeed;
        public object maxMotorTorque;

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAF2DB0D20
        public void set_min(){} // RVA: 0x7FFAF4A28330
        public void get_max(){} // RVA: 0x7FFAF2DB0D30
        public void set_max(){} // RVA: 0x7FFAF4A28350
    }

    public class JsonUtility
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x7FFAF9C5BA20
        public void FromJsonInternal(){} // RVA: 0x7FFAF9C5BA80
        public void ToJson(){} // RVA: 0x7FFAF9C5BAF0 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFAF9C5BCA0 | overloaded x2
        public void FromJsonOverwrite(){} // RVA: 0x7FFAF9C5BE80
    }

    public class jvalue
    {
    }

}