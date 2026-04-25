// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 121

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
        public void Reset(){} // RVA: 0x7FFAC9980D20
        public void get_edgeRadius(){} // RVA: 0x7FFAC9980D70
        public void set_edgeRadius(){} // RVA: 0x7FFAC9980DC0
        public void get_edgeCount(){} // RVA: 0x7FFAC9980E20
        public void get_pointCount(){} // RVA: 0x7FFAC9980E70
        public void get_points(){} // RVA: 0x7FFAC9980EC0
        public void set_points(){} // RVA: 0x7FFAC9980F10
        public void GetPoints(){} // RVA: 0x7FFAC9980F70
        public void SetPoints(){} // RVA: 0x7FFAC9980FD0
        public void get_useAdjacentStartPoint(){} // RVA: 0x7FFAC9981030
        public void set_useAdjacentStartPoint(){} // RVA: 0x7FFAC9981080
        public void get_useAdjacentEndPoint(){} // RVA: 0x7FFAC99810E0
        public void set_useAdjacentEndPoint(){} // RVA: 0x7FFAC9981130
        public void get_adjacentStartPoint(){} // RVA: 0x7FFAC9981190
        public void set_adjacentStartPoint(){} // RVA: 0x7FFAC99811F0
        public void get_adjacentEndPoint(){} // RVA: 0x7FFAC9981250
        public void set_adjacentEndPoint(){} // RVA: 0x7FFAC99812B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_adjacentStartPoint_Injected(){} // RVA: 0x7FFAC9981310
        public void set_adjacentStartPoint_Injected(){} // RVA: 0x7FFAC9981370
        public void get_adjacentEndPoint_Injected(){} // RVA: 0x7FFAC99813D0
        public void set_adjacentEndPoint_Injected(){} // RVA: 0x7FFAC9981430
    }

    public class Effector2D : Behaviour
    {
        public object useColliderMask;
        public object colliderMask;

        // ── Methods ──
        public void get_useColliderMask(){} // RVA: 0x7FFAC9985A00
        public void set_useColliderMask(){} // RVA: 0x7FFAC9985A50
        public void get_colliderMask(){} // RVA: 0x7FFAC9985AB0
        public void set_colliderMask(){} // RVA: 0x7FFAC9985B00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class EnumData : ValueType
    {
        public System.Enum[] values; // 0x10
        public int[] flagValues; // 0x18
        public string[] displayNames; // 0x20
        public string[] names; // 0x28
        public string[] tooltip; // 0x30
        public bool flags; // 0x38
        public System.Type underlyingType; // 0x40
        public bool unsigned; // 0x48
        public bool serializable; // 0x49
    }

    public class EnumDataUtility : Object
    {
        public System.Collections.Generic.Dictionary`2<System.ValueTuple`2<0x6B17ECD0,System.Type>,UnityEngine.EnumData> s_EnumData;

        // ── Methods ──
        public void GetCachedEnumData(){} // RVA: 0x7FFAC98BCCD0
        public void HandleInspectorOrderAttribute(){} // RVA: 0x7FFAC98BE8E0
        public void CheckObsoleteAddition(){} // RVA: 0x7FFAC98BF380
        public void EnumTooltipFromEnumField(){} // RVA: 0x7FFAC98BF500
        public void EnumNameFromEnumField(){} // RVA: 0x7FFAC98BF690
        public void .cctor(){} // RVA: 0x7FFAC98BFA70
        public void <EnumNameFromEnumField>g__NicifyName|8_0(){} // RVA: 0x7FFAC98BFBD0
    }

    public class Event : Object
    {
        public UIntPtr rawType; // 0x10
        public UnityEngine.Event mousePosition;
        public UnityEngine.Event delta; // 0x8

        // ── Methods ──
        public void get_rawType(){} // RVA: 0x7FFAC9905250
        public void get_mousePosition(){} // RVA: 0x7FFAC99052A0
        public void set_mousePosition(){} // RVA: 0x7FFAC9905300
        public void get_delta(){} // RVA: 0x7FFAC9905360
        public void set_delta(){} // RVA: 0x7FFAC99053C0
        public void get_pointerType(){} // RVA: 0x7FFAC9905420
        public void get_button(){} // RVA: 0x7FFAC9905470
        public void get_modifiers(){} // RVA: 0x7FFAC99054C0
        public void set_modifiers(){} // RVA: 0x7FFAC9905510
        public void get_pressure(){} // RVA: 0x7FFAC9905570
        public void get_twist(){} // RVA: 0x7FFAC99055C0
        public void get_tilt(){} // RVA: 0x7FFAC9905610
        public void get_penStatus(){} // RVA: 0x7FFAC9905670
        public void get_clickCount(){} // RVA: 0x7FFAC99056C0
        public void get_character(){} // RVA: 0x7FFAC9905710
        public void set_character(){} // RVA: 0x7FFAC9905760
        public void get_keyCode(){} // RVA: 0x7FFAC99057C0
        public void set_keyCode(){} // RVA: 0x7FFAC9905810
        public void get_displayIndex(){} // RVA: 0x7FFAC9905870
        public void set_displayIndex(){} // RVA: 0x7FFAC99058C0
        public void get_type(){} // RVA: 0x7FFAC9905920
        public void set_type(){} // RVA: 0x7FFAC9905970
        public void get_commandName(){} // RVA: 0x7FFAC99059D0
        public void set_commandName(){} // RVA: 0x7FFAC9905A20
        public void Internal_Use(){} // RVA: 0x7FFAC9905A80
        public void Internal_Create(){} // RVA: 0x7FFAC9905AD0
        public void Internal_Destroy(){} // RVA: 0x7FFAC9905B20
        public void GetTypeForControl(){} // RVA: 0x7FFAC9905B70
        public void CopyFromPtr(){} // RVA: 0x7FFAC9905BD0
        public void PopEvent(){} // RVA: 0x7FFAC9905C30
        public void Internal_SetNativeEvent(){} // RVA: 0x7FFAC9905C80
        public void Internal_MakeMasterEventCurrent(){} // RVA: 0x7FFAC9905CD0
        public void GetDoubleClickTime(){} // RVA: 0x7FFAC9905F20
        public void .ctor(){} // RVA: 0x7FFAC9905FD0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC9906030
        public void CopyFrom(){} // RVA: 0x7FFAC99060D0
        public void get_shift(){} // RVA: 0x7FFAC9906150
        public void get_control(){} // RVA: 0x7FFAC99061B0
        public void get_alt(){} // RVA: 0x7FFAC9906210
        public void get_command(){} // RVA: 0x7FFAC9906270
        public void get_current(){} // RVA: 0x7FFAC99062D0
        public void set_current(){} // RVA: 0x7FFAC9906310
        public void get_isKey(){} // RVA: 0x7FFAC9906420
        public void get_isMouse(){} // RVA: 0x7FFAC9906490
        public void get_isDirectManipulationDevice(){} // RVA: 0x7FFAC9906510
        public void KeyboardEvent(){} // RVA: 0x7FFAC99065C0
        public void GetHashCode(){} // RVA: 0x7FFAC9908080
        public void Equals(){} // RVA: 0x7FFAC9908190
        public void ToString(){} // RVA: 0x7FFAC9908350
        public void Use(){} // RVA: 0x7FFAC9908C50
        public void get_mousePosition_Injected(){} // RVA: 0x7FFAC9908E90
        public void set_mousePosition_Injected(){} // RVA: 0x7FFAC9908EF0
        public void get_delta_Injected(){} // RVA: 0x7FFAC9908F50
        public void set_delta_Injected(){} // RVA: 0x7FFAC9908FB0
        public void get_tilt_Injected(){} // RVA: 0x7FFAC9909010
    }

    public class EventInterests : ValueType
    {
        public bool wantsMouseMove; // 0x10
        public bool wantsMouseEnterLeaveWindow; // 0x11
        public bool wantsLessLayoutEvents; // 0x12

        // ── Methods ──
        public void get_wantsMouseMove(){} // RVA: 0x7FFAC495DDF0
        public void set_wantsMouseMove(){} // RVA: 0x7FFAC495DE00
        public void get_wantsMouseEnterLeaveWindow(){} // RVA: 0x7FFAC495DE10
        public void set_wantsMouseEnterLeaveWindow(){} // RVA: 0x7FFAC3B9B9B0
        public void get_wantsLessLayoutEvents(){} // RVA: 0x7FFAC495DE20
        public void WantsEvent(){} // RVA: 0x7FFAC9909070
        public void WantsLayoutPass(){} // RVA: 0x7FFAC9909090
    }

    public class ExcludeFromObjectFactoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExcludeFromPresetAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExecuteAlways : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExecuteInEditMode : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ExitGUIException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99287B0 | overloaded x2
    }

    public class ExposedReference`1 : ValueType
    {
        public UnityEngine.PropertyName exposedName;
        public UnityEngine.Object defaultValue;

        // ── Methods ──
        public void Resolve(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ExpressionEvaluator : Object
    {
        public PcgRandom s_Random;
        public System.Collections.Generic.Dictionary`2<string,Operator> s_Operators; // 0x10

        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFAC2C5D5A0
        public void EvaluateTokens(){} // RVA: 0x7FFAC2E8DC40
        public void EvaluateDouble(){} // RVA: 0x7FFAC9861750
        public void InfixToRPN(){} // RVA: 0x7FFAC9861CC0
        public void NeedToPop(){} // RVA: 0x7FFAC98622D0
        public void ExpressionToTokens(){} // RVA: 0x7FFAC98623D0
        public void IsCommand(){} // RVA: 0x7FFAC9862900
        public void IsVariable(){} // RVA: 0x7FFAC9862980
        public void IsDelayedFunction(){} // RVA: 0x7FFAC98629D0
        public void IsOperator(){} // RVA: 0x7FFAC9862A40
        public void TokenToOperator(){} // RVA: 0x7FFAC9862AE0
        public void PreFormatExpression(){} // RVA: 0x7FFAC9862B90
        public void FixUnaryOperators(){} // RVA: 0x7FFAC9862DF0
        public void EvaluateOp(){} // RVA: 0x7FFAC9862FF0
        public void TryParse(){} // RVA: 0x7FFAC2C5A350
        public void .cctor(){} // RVA: 0x7FFAC9863390
    }

    public class ExtensionOfNativeClassAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}