// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 11
// Methods: 112

namespace ThirdParty.Unity.UnityEngine
{
    public class EdgeCollider2D : Collider2D
    {
        public object edgeRadius;
        public object edgeCount;
        public object pointCount;
        public object points;
        public object useAdjacentStartPoint;
        public object useAdjacentEndPoint;
        public object adjacentStartPoint;
        public object adjacentEndPoint;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD54DA0D20
        public void get_edgeRadius(){} // RVA: 0x7FFD54DA0D70
        public void set_edgeRadius(){} // RVA: 0x7FFD54DA0DC0
        public void get_edgeCount(){} // RVA: 0x7FFD54DA0E20
        public void get_pointCount(){} // RVA: 0x7FFD54DA0E70
        public void get_points(){} // RVA: 0x7FFD54DA0EC0
        public void set_points(){} // RVA: 0x7FFD54DA0F10
        public void GetPoints(){} // RVA: 0x7FFD54DA0F70
        public void SetPoints(){} // RVA: 0x7FFD54DA0FD0
        public void get_useAdjacentStartPoint(){} // RVA: 0x7FFD54DA1030
        public void set_useAdjacentStartPoint(){} // RVA: 0x7FFD54DA1080
        public void get_useAdjacentEndPoint(){} // RVA: 0x7FFD54DA10E0
        public void set_useAdjacentEndPoint(){} // RVA: 0x7FFD54DA1130
        public void get_adjacentStartPoint(){} // RVA: 0x7FFD54DA1190
        public void set_adjacentStartPoint(){} // RVA: 0x7FFD54DA11F0
        public void get_adjacentEndPoint(){} // RVA: 0x7FFD54DA1250
        public void set_adjacentEndPoint(){} // RVA: 0x7FFD54DA12B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_adjacentStartPoint_Injected(){} // RVA: 0x7FFD54DA1310
        public void set_adjacentStartPoint_Injected(){} // RVA: 0x7FFD54DA1370
        public void get_adjacentEndPoint_Injected(){} // RVA: 0x7FFD54DA13D0
        public void set_adjacentEndPoint_Injected(){} // RVA: 0x7FFD54DA1430
    }

    public class Effector2D : Behaviour
    {
        public object useColliderMask;
        public object colliderMask;

        // ── Methods ──
        public void get_useColliderMask(){} // RVA: 0x7FFD54DA5A00
        public void set_useColliderMask(){} // RVA: 0x7FFD54DA5A50
        public void get_colliderMask(){} // RVA: 0x7FFD54DA5AB0
        public void set_colliderMask(){} // RVA: 0x7FFD54DA5B00
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Event : Object
    {
        public UIntPtr rawType; // 0x10
        public UnityEngine.Event mousePosition;
        public UnityEngine.Event delta; // 0x8

        // ── Methods ──
        public void get_rawType(){} // RVA: 0x7FFD54D25250
        public void get_mousePosition(){} // RVA: 0x7FFD54D252A0
        public void set_mousePosition(){} // RVA: 0x7FFD54D25300
        public void get_delta(){} // RVA: 0x7FFD54D25360
        public void set_delta(){} // RVA: 0x7FFD54D253C0
        public void get_pointerType(){} // RVA: 0x7FFD54D25420
        public void get_button(){} // RVA: 0x7FFD54D25470
        public void get_modifiers(){} // RVA: 0x7FFD54D254C0
        public void set_modifiers(){} // RVA: 0x7FFD54D25510
        public void get_pressure(){} // RVA: 0x7FFD54D25570
        public void get_twist(){} // RVA: 0x7FFD54D255C0
        public void get_tilt(){} // RVA: 0x7FFD54D25610
        public void get_penStatus(){} // RVA: 0x7FFD54D25670
        public void get_clickCount(){} // RVA: 0x7FFD54D256C0
        public void get_character(){} // RVA: 0x7FFD54D25710
        public void set_character(){} // RVA: 0x7FFD54D25760
        public void get_keyCode(){} // RVA: 0x7FFD54D257C0
        public void set_keyCode(){} // RVA: 0x7FFD54D25810
        public void get_displayIndex(){} // RVA: 0x7FFD54D25870
        public void set_displayIndex(){} // RVA: 0x7FFD54D258C0
        public void get_type(){} // RVA: 0x7FFD54D25920
        public void set_type(){} // RVA: 0x7FFD54D25970
        public void get_commandName(){} // RVA: 0x7FFD54D259D0
        public void set_commandName(){} // RVA: 0x7FFD54D25A20
        public void Internal_Use(){} // RVA: 0x7FFD54D25A80
        public void Internal_Create(){} // RVA: 0x7FFD54D25AD0
        public void Internal_Destroy(){} // RVA: 0x7FFD54D25B20
        public void GetTypeForControl(){} // RVA: 0x7FFD54D25B70
        public void CopyFromPtr(){} // RVA: 0x7FFD54D25BD0
        public void PopEvent(){} // RVA: 0x7FFD54D25C30
        public void Internal_SetNativeEvent(){} // RVA: 0x7FFD54D25C80
        public void Internal_MakeMasterEventCurrent(){} // RVA: 0x7FFD54D25CD0
        public void GetDoubleClickTime(){} // RVA: 0x7FFD54D25F20
        public void .ctor(){} // RVA: 0x7FFD54D25FD0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD54D26030
        public void CopyFrom(){} // RVA: 0x7FFD54D260D0
        public void get_shift(){} // RVA: 0x7FFD54D26150
        public void get_control(){} // RVA: 0x7FFD54D261B0
        public void get_alt(){} // RVA: 0x7FFD54D26210
        public void get_command(){} // RVA: 0x7FFD54D26270
        public void get_current(){} // RVA: 0x7FFD54D262D0
        public void set_current(){} // RVA: 0x7FFD54D26310
        public void get_isKey(){} // RVA: 0x7FFD54D26420
        public void get_isMouse(){} // RVA: 0x7FFD54D26490
        public void get_isDirectManipulationDevice(){} // RVA: 0x7FFD54D26510
        public void KeyboardEvent(){} // RVA: 0x7FFD54D265C0
        public void GetHashCode(){} // RVA: 0x7FFD54D28080
        public void Equals(){} // RVA: 0x7FFD54D28190
        public void ToString(){} // RVA: 0x7FFD54D28350
        public void Use(){} // RVA: 0x7FFD54D28C50
        public void get_mousePosition_Injected(){} // RVA: 0x7FFD54D28E90
        public void set_mousePosition_Injected(){} // RVA: 0x7FFD54D28EF0
        public void get_delta_Injected(){} // RVA: 0x7FFD54D28F50
        public void set_delta_Injected(){} // RVA: 0x7FFD54D28FB0
        public void get_tilt_Injected(){} // RVA: 0x7FFD54D29010
    }

    public class EventInterests : ValueType
    {
        public bool wantsMouseMove; // 0x10
        public bool wantsMouseEnterLeaveWindow; // 0x11
        public bool wantsLessLayoutEvents; // 0x12

        // ── Methods ──
        public void get_wantsMouseMove(){} // RVA: 0x7FFD4FD7DDF0
        public void set_wantsMouseMove(){} // RVA: 0x7FFD4FD7DE00
        public void get_wantsMouseEnterLeaveWindow(){} // RVA: 0x7FFD4FD7DE10
        public void set_wantsMouseEnterLeaveWindow(){} // RVA: 0x7FFD4EFBB9B0
        public void get_wantsLessLayoutEvents(){} // RVA: 0x7FFD4FD7DE20
        public void WantsEvent(){} // RVA: 0x7FFD54D29070
        public void WantsLayoutPass(){} // RVA: 0x7FFD54D29090
    }

    public class ExcludeFromObjectFactoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ExcludeFromPresetAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ExecuteAlways : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ExecuteInEditMode : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ExposedReference`1 : ValueType
    {
        public UnityEngine.PropertyName exposedName; // 0x10
        public UnityEngine.Object defaultValue; // 0x18

        // ── Methods ──
        public void Resolve(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ExpressionEvaluator : Object
    {
        public 0x664DA130 s_Random;
        public System.Collections.Generic.Dictionary`2<string,0x664DA238> s_Operators; // 0x10

        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFD4E07D5A0
        public void EvaluateTokens(){} // RVA: 0x7FFD4E2ADC40
        public void EvaluateDouble(){} // RVA: 0x7FFD54C81750
        public void InfixToRPN(){} // RVA: 0x7FFD54C81CC0
        public void NeedToPop(){} // RVA: 0x7FFD54C822D0
        public void ExpressionToTokens(){} // RVA: 0x7FFD54C823D0
        public void IsCommand(){} // RVA: 0x7FFD54C82900
        public void IsVariable(){} // RVA: 0x7FFD54C82980
        public void IsDelayedFunction(){} // RVA: 0x7FFD54C829D0
        public void IsOperator(){} // RVA: 0x7FFD54C82A40
        public void TokenToOperator(){} // RVA: 0x7FFD54C82AE0
        public void PreFormatExpression(){} // RVA: 0x7FFD54C82B90
        public void FixUnaryOperators(){} // RVA: 0x7FFD54C82DF0
        public void EvaluateOp(){} // RVA: 0x7FFD54C82FF0
        public void TryParse(){} // RVA: 0x7FFD4E07A350
        public void .cctor(){} // RVA: 0x7FFD54C83390
    }

    public class ExtensionOfNativeClassAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}