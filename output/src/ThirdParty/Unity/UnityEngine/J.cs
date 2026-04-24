// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 3
// Methods: 59

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
        public void get_connectedBody(){} // RVA: 0x7FFD54DBAE40
        public void set_connectedBody(){} // RVA: 0x7FFD54DBAE90
        public void get_connectedArticulationBody(){} // RVA: 0x7FFD54DBAEF0
        public void set_connectedArticulationBody(){} // RVA: 0x7FFD54DBAF40
        public void get_axis(){} // RVA: 0x7FFD54DBAFA0
        public void set_axis(){} // RVA: 0x7FFD54DBB010
        public void get_anchor(){} // RVA: 0x7FFD54DBB070
        public void set_anchor(){} // RVA: 0x7FFD54DBB0E0
        public void get_connectedAnchor(){} // RVA: 0x7FFD54DBB140
        public void set_connectedAnchor(){} // RVA: 0x7FFD54DBB1B0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFD54DBB210
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFD54DBB260
        public void get_breakForce(){} // RVA: 0x7FFD54DBB2C0
        public void set_breakForce(){} // RVA: 0x7FFD54DBB310
        public void get_breakTorque(){} // RVA: 0x7FFD54DBB370
        public void set_breakTorque(){} // RVA: 0x7FFD54DBB3C0
        public void get_enableCollision(){} // RVA: 0x7FFD54DBB420
        public void set_enableCollision(){} // RVA: 0x7FFD54DBB470
        public void get_enablePreprocessing(){} // RVA: 0x7FFD54DBB4D0
        public void set_enablePreprocessing(){} // RVA: 0x7FFD54DBB520
        public void get_massScale(){} // RVA: 0x7FFD54DBB580
        public void set_massScale(){} // RVA: 0x7FFD54DBB5D0
        public void get_connectedMassScale(){} // RVA: 0x7FFD54DBB630
        public void set_connectedMassScale(){} // RVA: 0x7FFD54DBB680
        public void GetCurrentForces(){} // RVA: 0x7FFD54DBB6E0
        public void get_currentForce(){} // RVA: 0x7FFD54DBB750
        public void get_currentTorque(){} // RVA: 0x7FFD54DBB860
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_axis_Injected(){} // RVA: 0x7FFD54DBB970
        public void set_axis_Injected(){} // RVA: 0x7FFD54DBB9D0
        public void get_anchor_Injected(){} // RVA: 0x7FFD54DBBA30
        public void set_anchor_Injected(){} // RVA: 0x7FFD54DBBA90
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFD54DBBAF0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFD54DBBB50
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
        public void get_attachedRigidbody(){} // RVA: 0x7FFD54DA2CF0
        public void get_connectedBody(){} // RVA: 0x7FFD54DA2D40
        public void set_connectedBody(){} // RVA: 0x7FFD54DA2D90
        public void get_enableCollision(){} // RVA: 0x7FFD54DA2DF0
        public void set_enableCollision(){} // RVA: 0x7FFD54DA2E40
        public void get_breakForce(){} // RVA: 0x7FFD54DA2EA0
        public void set_breakForce(){} // RVA: 0x7FFD54DA2EF0
        public void get_breakTorque(){} // RVA: 0x7FFD54DA2F50
        public void set_breakTorque(){} // RVA: 0x7FFD54DA2FA0
        public void get_breakAction(){} // RVA: 0x7FFD54DA3000
        public void set_breakAction(){} // RVA: 0x7FFD54DA3050
        public void get_reactionForce(){} // RVA: 0x7FFD54DA30B0
        public void get_reactionTorque(){} // RVA: 0x7FFD54DA3110
        public void GetReactionForce(){} // RVA: 0x7FFD54DA3160
        public void GetReactionTorque(){} // RVA: 0x7FFD54DA31D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_reactionForce_Injected(){} // RVA: 0x7FFD54DA3230
        public void GetReactionForce_Injected(){} // RVA: 0x7FFD54DA3290
    }

    public class JsonUtility : Object
    {
        // ── Methods ──
        public void ToJsonInternal(){} // RVA: 0x7FFD54D63320
        public void FromJsonInternal(){} // RVA: 0x7FFD54D63380
        public void ToJson(){} // RVA: 0x7FFD54D633F0 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFD54D635A0 | overloaded x2
        public void FromJsonOverwrite(){} // RVA: 0x7FFD54D63780
    }

}