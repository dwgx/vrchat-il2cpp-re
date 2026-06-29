// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 10
// Methods: 99

namespace ThirdParty.Unity.UnityEngine
{
    public class Joint : Component
    {
        // ── Methods ──
        public void get_connectedBody(){} // RVA: 0x7AEFE2A60
        public void set_connectedBody(){} // RVA: 0x7AEFE2AB0
        public void get_connectedArticulationBody(){} // RVA: 0x7AEFE2B10
        public void set_connectedArticulationBody(){} // RVA: 0x7AEFE2B60
        public void get_axis(){} // RVA: 0x7AEFE2BC0
        public void set_axis(){} // RVA: 0x7AEFE2C30
        public void get_anchor(){} // RVA: 0x7AEFE2C90
        public void set_anchor(){} // RVA: 0x7AEFE2D00
        public void get_connectedAnchor(){} // RVA: 0x7AEFE2D60
        public void set_connectedAnchor(){} // RVA: 0x7AEFE2DD0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7AEFE2E30
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7AEFE2E80
        public void get_breakForce(){} // RVA: 0x7AEFE2EE0
        public void set_breakForce(){} // RVA: 0x7AEFE2F30
        public void get_breakTorque(){} // RVA: 0x7AEFE2F90
        public void set_breakTorque(){} // RVA: 0x7AEFE2FE0
        public void get_enableCollision(){} // RVA: 0x7AEFE3040
        public void set_enableCollision(){} // RVA: 0x7AEFE3090
        public void get_enablePreprocessing(){} // RVA: 0x7AEFE30F0
        public void set_enablePreprocessing(){} // RVA: 0x7AEFE3140
        public void get_massScale(){} // RVA: 0x7AEFE31A0
        public void set_massScale(){} // RVA: 0x7AEFE31F0
        public void get_connectedMassScale(){} // RVA: 0x7AEFE3250
        public void set_connectedMassScale(){} // RVA: 0x7AEFE32A0
        public void GetCurrentForces(){} // RVA: 0x7AEFE3300
        public void get_currentForce(){} // RVA: 0x7AEFE3370
        public void get_currentTorque(){} // RVA: 0x7AEFE3490
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_axis_Injected(){} // RVA: 0x7AEFE35B0
        public void set_axis_Injected(){} // RVA: 0x7AEFE3610
        public void get_anchor_Injected(){} // RVA: 0x7AEFE3670
        public void set_anchor_Injected(){} // RVA: 0x7AEFE36D0
        public void get_connectedAnchor_Injected(){} // RVA: 0x7AEFE3730
        public void set_connectedAnchor_Injected(){} // RVA: 0x7AEFE3790
    }

    public class Joint2D : Behaviour
    {
        // ── Methods ──
        public void get_attachedRigidbody(){} // RVA: 0x7AEFCA980
        public void get_connectedBody(){} // RVA: 0x7AEFCA9D0
        public void set_connectedBody(){} // RVA: 0x7AEFCAA20
        public void get_enableCollision(){} // RVA: 0x7AEFCAA80
        public void set_enableCollision(){} // RVA: 0x7AEFCAAD0
        public void get_breakForce(){} // RVA: 0x7AEFCAB30
        public void set_breakForce(){} // RVA: 0x7AEFCAB80
        public void get_breakTorque(){} // RVA: 0x7AEFCABE0
        public void set_breakTorque(){} // RVA: 0x7AEFCAC30
        public void get_breakAction(){} // RVA: 0x7AEFCAC90
        public void set_breakAction(){} // RVA: 0x7AEFCACE0
        public void get_reactionForce(){} // RVA: 0x7AEFCAD40
        public void get_reactionTorque(){} // RVA: 0x7AEFCADA0
        public void GetReactionForce(){} // RVA: 0x7AEFCADF0
        public void GetReactionTorque(){} // RVA: 0x7AEFCAE60
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_reactionForce_Injected(){} // RVA: 0x7AEFCAEC0
        public void GetReactionForce_Injected(){} // RVA: 0x7AEFCAF20
    }

    public class JointAngleLimits2D : ValueType
    {
        // ── Methods ──
        public void get_min(){} // RVA: 0x7A79EF510
        public void set_min(){} // RVA: 0x7A76B8920
        public void get_max(){} // RVA: 0x7A7ED4380
        public void set_max(){} // RVA: 0x7A76B8940
    }

    public class JointDrive : ValueType
    {
        // ── Methods ──
        public void get_positionSpring(){} // RVA: 0x7A79EF510
        public void set_positionSpring(){} // RVA: 0x7A76B8920
        public void get_positionDamper(){} // RVA: 0x7A7ED4380
        public void set_positionDamper(){} // RVA: 0x7A76B8940
        public void get_maximumForce(){} // RVA: 0x7A7ED4390
        public void set_maximumForce(){} // RVA: 0x7A76B8930
        public void get_useAcceleration(){} // RVA: 0x7A7EF4FE0
        public void set_useAcceleration(){} // RVA: 0x7A7ED4330
    }

    public class JointLimits : ValueType
    {
        // ── Methods ──
        public void get_min(){} // RVA: 0x7A79EF510
        public void set_min(){} // RVA: 0x7A76B8920
        public void get_max(){} // RVA: 0x7A7ED4380
        public void set_max(){} // RVA: 0x7A76B8940
        public void get_bounciness(){} // RVA: 0x7A7ED4390
        public void set_bounciness(){} // RVA: 0x7A76B8930
        public void get_bounceMinVelocity(){} // RVA: 0x7A7ED43A0
        public void set_bounceMinVelocity(){} // RVA: 0x7A76B8970
        public void get_contactDistance(){} // RVA: 0x7A7ED43B0
        public void set_contactDistance(){} // RVA: 0x7A76E1BA0
    }

    public class JointMotor : ValueType
    {
        // ── Methods ──
        public void get_targetVelocity(){} // RVA: 0x7A79EF510
        public void set_targetVelocity(){} // RVA: 0x7A76B8920
        public void get_force(){} // RVA: 0x7A7ED4380
        public void set_force(){} // RVA: 0x7A76B8940
        public void get_freeSpin(){} // RVA: 0x7A7EF4FF0
        public void set_freeSpin(){} // RVA: 0x7A7EF5000
    }

    public class JointMotor2D : ValueType
    {
        // ── Methods ──
        public void get_motorSpeed(){} // RVA: 0x7A79EF510
        public void set_motorSpeed(){} // RVA: 0x7A76B8920
        public void get_maxMotorTorque(){} // RVA: 0x7A7ED4380
        public void set_maxMotorTorque(){} // RVA: 0x7A76B8940
    }

    public class JointSuspension2D : ValueType
    {
        // ── Methods ──
        public void get_dampingRatio(){} // RVA: 0x7A79EF510
        public void set_dampingRatio(){} // RVA: 0x7A76B8920
        public void get_frequency(){} // RVA: 0x7A7ED4380
        public void set_frequency(){} // RVA: 0x7A76B8940
        public void get_angle(){} // RVA: 0x7A7ED4390
        public void set_angle(){} // RVA: 0x7A76B8930
    }

    public class JointTranslationLimits2D : ValueType
    {
        // ── Methods ──
        public void get_min(){} // RVA: 0x7A79EF510
        public void set_min(){} // RVA: 0x7A76B8920
        public void get_max(){} // RVA: 0x7A7ED4380
        public void set_max(){} // RVA: 0x7A76B8940
    }

    public class JsonUtility : Object
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x7AEF8AE00
        public void FromJsonInternal(){} // RVA: 0x7AEF8AE60
        public void ToJson(){} // RVA: 0x7AEF8AED0
        public void FromJson(){} // RVA: 0x7AA5093C0
        public void FromJsonOverwrite(){} // RVA: 0x7AEF8B260
    }

}