// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 12
// Methods: 101

namespace ThirdParty.Unity.UnityEngine
{
    public class Joint : Component
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
        public void get_connectedBody(){} // RVA: 0x7FFAC999AE40
        public void set_connectedBody(){} // RVA: 0x7FFAC999AE90
        public void get_connectedArticulationBody(){} // RVA: 0x7FFAC999AEF0
        public void set_connectedArticulationBody(){} // RVA: 0x7FFAC999AF40
        public void get_axis(){} // RVA: 0x7FFAC999AFA0
        public void set_axis(){} // RVA: 0x7FFAC999B010
        public void get_anchor(){} // RVA: 0x7FFAC999B070
        public void set_anchor(){} // RVA: 0x7FFAC999B0E0
        public void get_connectedAnchor(){} // RVA: 0x7FFAC999B140
        public void set_connectedAnchor(){} // RVA: 0x7FFAC999B1B0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAC999B210
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAC999B260
        public void get_breakForce(){} // RVA: 0x7FFAC999B2C0
        public void set_breakForce(){} // RVA: 0x7FFAC999B310
        public void get_breakTorque(){} // RVA: 0x7FFAC999B370
        public void set_breakTorque(){} // RVA: 0x7FFAC999B3C0
        public void get_enableCollision(){} // RVA: 0x7FFAC999B420
        public void set_enableCollision(){} // RVA: 0x7FFAC999B470
        public void get_enablePreprocessing(){} // RVA: 0x7FFAC999B4D0
        public void set_enablePreprocessing(){} // RVA: 0x7FFAC999B520
        public void get_massScale(){} // RVA: 0x7FFAC999B580
        public void set_massScale(){} // RVA: 0x7FFAC999B5D0
        public void get_connectedMassScale(){} // RVA: 0x7FFAC999B630
        public void set_connectedMassScale(){} // RVA: 0x7FFAC999B680
        public void GetCurrentForces(){} // RVA: 0x7FFAC999B6E0
        public void get_currentForce(){} // RVA: 0x7FFAC999B750
        public void get_currentTorque(){} // RVA: 0x7FFAC999B860
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_axis_Injected(){} // RVA: 0x7FFAC999B970
        public void set_axis_Injected(){} // RVA: 0x7FFAC999B9D0
        public void get_anchor_Injected(){} // RVA: 0x7FFAC999BA30
        public void set_anchor_Injected(){} // RVA: 0x7FFAC999BA90
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFAC999BAF0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFAC999BB50
    }

    public class Joint2D : Behaviour
    {
        public object attachedRigidbody;
        public object connectedBody;
        public object enableCollision;
        public object breakForce;
        public object breakTorque;
        public object breakAction;
        public object reactionForce;
        public object reactionTorque;

        // ── Methods ──
        public void get_attachedRigidbody(){} // RVA: 0x7FFAC9982CF0
        public void get_connectedBody(){} // RVA: 0x7FFAC9982D40
        public void set_connectedBody(){} // RVA: 0x7FFAC9982D90
        public void get_enableCollision(){} // RVA: 0x7FFAC9982DF0
        public void set_enableCollision(){} // RVA: 0x7FFAC9982E40
        public void get_breakForce(){} // RVA: 0x7FFAC9982EA0
        public void set_breakForce(){} // RVA: 0x7FFAC9982EF0
        public void get_breakTorque(){} // RVA: 0x7FFAC9982F50
        public void set_breakTorque(){} // RVA: 0x7FFAC9982FA0
        public void get_breakAction(){} // RVA: 0x7FFAC9983000
        public void set_breakAction(){} // RVA: 0x7FFAC9983050
        public void get_reactionForce(){} // RVA: 0x7FFAC99830B0
        public void get_reactionTorque(){} // RVA: 0x7FFAC9983110
        public void GetReactionForce(){} // RVA: 0x7FFAC9983160
        public void GetReactionTorque(){} // RVA: 0x7FFAC99831D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_reactionForce_Injected(){} // RVA: 0x7FFAC9983230
        public void GetReactionForce_Injected(){} // RVA: 0x7FFAC9983290
    }

    public class JointAngleLimits2D : ValueType
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAC2F44D20
        public void set_min(){} // RVA: 0x7FFAC4A9B910
        public void get_max(){} // RVA: 0x7FFAC2F44D30
        public void set_max(){} // RVA: 0x7FFAC4A9B8F0
    }

    public class JointDrive : ValueType
    {
        public float positionSpring; // 0x10
        public float positionDamper; // 0x14
        public float maximumForce; // 0x18
        public int useAcceleration; // 0x1C

        // ── Methods ──
        public void get_positionSpring(){} // RVA: 0x7FFAC2F44D20
        public void set_positionSpring(){} // RVA: 0x7FFAC4A9B910
        public void get_positionDamper(){} // RVA: 0x7FFAC2F44D30
        public void set_positionDamper(){} // RVA: 0x7FFAC4A9B8F0
        public void get_maximumForce(){} // RVA: 0x7FFAC2F44CF0
        public void set_maximumForce(){} // RVA: 0x7FFAC4A9B920
        public void get_useAcceleration(){} // RVA: 0x7FFAC99874A0
        public void set_useAcceleration(){} // RVA: 0x7FFAC9814CC0
    }

    public class JointLimits : ValueType
    {
        public float min; // 0x10
        public float max; // 0x14
        public float bounciness; // 0x18
        public float bounceMinVelocity; // 0x1C
        public float contactDistance; // 0x20
        public float minBounce; // 0x24
        public float maxBounce; // 0x28

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAC2F44D20
        public void set_min(){} // RVA: 0x7FFAC4A9B910
        public void get_max(){} // RVA: 0x7FFAC2F44D30
        public void set_max(){} // RVA: 0x7FFAC4A9B8F0
        public void get_bounciness(){} // RVA: 0x7FFAC2F44CF0
        public void set_bounciness(){} // RVA: 0x7FFAC4A9B920
        public void get_bounceMinVelocity(){} // RVA: 0x7FFAC2F44D00
        public void set_bounceMinVelocity(){} // RVA: 0x7FFAC4A9B8C0
        public void get_contactDistance(){} // RVA: 0x7FFAC9814DF0
        public void set_contactDistance(){} // RVA: 0x7FFAC304B330
    }

    public class JointMotor : ValueType
    {
        public float targetVelocity; // 0x10
        public float force; // 0x14
        public int freeSpin; // 0x18

        // ── Methods ──
        public void get_targetVelocity(){} // RVA: 0x7FFAC2F44D20
        public void set_targetVelocity(){} // RVA: 0x7FFAC4A9B910
        public void get_force(){} // RVA: 0x7FFAC2F44D30
        public void set_force(){} // RVA: 0x7FFAC4A9B8F0
        public void get_freeSpin(){} // RVA: 0x7FFAC99874B0
        public void set_freeSpin(){} // RVA: 0x7FFAC8644880
    }

    public class JointMotor2D : ValueType
    {
        public float motorSpeed; // 0x10
        public float maxMotorTorque; // 0x14

        // ── Methods ──
        public void get_motorSpeed(){} // RVA: 0x7FFAC2F44D20
        public void set_motorSpeed(){} // RVA: 0x7FFAC4A9B910
        public void get_maxMotorTorque(){} // RVA: 0x7FFAC2F44D30
        public void set_maxMotorTorque(){} // RVA: 0x7FFAC4A9B8F0
    }

    public class JointSpring : ValueType
    {
        public float spring; // 0x10
        public float damper; // 0x14
        public float targetPosition; // 0x18
    }

    public class JointSuspension2D : ValueType
    {
        public float dampingRatio; // 0x10
        public float frequency; // 0x14
        public float angle; // 0x18

        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x7FFAC2F44D20
        public void set_dampingRatio(){} // RVA: 0x7FFAC4A9B910
        public void get_frequency(){} // RVA: 0x7FFAC2F44D30
        public void set_frequency(){} // RVA: 0x7FFAC4A9B8F0
        public void get_angle(){} // RVA: 0x7FFAC2F44CF0
        public void set_angle(){} // RVA: 0x7FFAC4A9B920
    }

    public class JointTranslationLimits2D : ValueType
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void get_min(){} // RVA: 0x7FFAC2F44D20
        public void set_min(){} // RVA: 0x7FFAC4A9B910
        public void get_max(){} // RVA: 0x7FFAC2F44D30
        public void set_max(){} // RVA: 0x7FFAC4A9B8F0
    }

    public class JsonUtility : Object
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x7FFAC9943320
        public void FromJsonInternal(){} // RVA: 0x7FFAC9943380
        public void ToJson(){} // RVA: 0x7FFAC99433F0 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFAC99435A0 | overloaded x2
        public void FromJsonOverwrite(){} // RVA: 0x7FFAC9943780
    }

    public class jvalue : ValueType
    {
        public bool z; // 0x10
        public sbyte b; // 0x10
        public char c; // 0x10
        public short s; // 0x10
        public int i; // 0x10
        public long j; // 0x10
        public float f; // 0x10
        public double d; // 0x10
        public UIntPtr l; // 0x10
    }

}