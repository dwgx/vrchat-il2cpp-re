// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 123

namespace ThirdParty.Unity.UnityEngine
{
    public class EdgeCollider2D
    {
        public object useDelaunayMesh;
        public object autoTiling;
        public object points;
        public object pathCount;

        // ── Methods ──
        public void Reset(){} // RVA: 0x71E9420
        public void get_edgeRadius(){} // RVA: 0x71E9470
        public void set_edgeRadius(){} // RVA: 0x71E94C0
        public void get_edgeCount(){} // RVA: 0x71E9520
        public void get_pointCount(){} // RVA: 0x71E9570
        public void get_points(){} // RVA: 0x71E95C0
        public void set_points(){} // RVA: 0x71E9610
        public void GetPoints(){} // RVA: 0x71E9670
        public void SetPoints(){} // RVA: 0x71E96D0
        public void get_useAdjacentStartPoint(){} // RVA: 0x71E9730
        public void set_useAdjacentStartPoint(){} // RVA: 0x71E9780
        public void get_useAdjacentEndPoint(){} // RVA: 0x71E97E0
        public void set_useAdjacentEndPoint(){} // RVA: 0x71E9830
        public void get_adjacentStartPoint(){} // RVA: 0x71E9890
        public void set_adjacentStartPoint(){} // RVA: 0x71E98F0
        public void get_adjacentEndPoint(){} // RVA: 0x71E9950
        public void set_adjacentEndPoint(){} // RVA: 0x71E99B0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_adjacentStartPoint_Injected(){} // RVA: 0x71E9A10
        public void set_adjacentStartPoint_Injected(){} // RVA: 0x71E9A70
        public void get_adjacentEndPoint_Injected(){} // RVA: 0x71E9AD0
        public void set_adjacentEndPoint_Injected(){} // RVA: 0x71E9B30
    }

    public class Effector2D
    {
        public object forceAngle;
        public object useGlobalAngle;

        // ── Methods ──
        public void get_useColliderMask(){} // RVA: 0x71EE100
        public void set_useColliderMask(){} // RVA: 0x71EE150
        public void get_colliderMask(){} // RVA: 0x71EE1B0
        public void set_colliderMask(){} // RVA: 0x71EE200
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class EnumData
    {
    }

    public class EnumDataUtility
    {
        // ── Methods ──
        public void GetCachedEnumData(){} // RVA: 0x7124740
        public void HandleInspectorOrderAttribute(){} // RVA: 0x7126350
        public void CheckObsoleteAddition(){} // RVA: 0x7126DF0
        public void EnumTooltipFromEnumField(){} // RVA: 0x7126F70
        public void EnumNameFromEnumField(){} // RVA: 0x7127100
        public void .cctor(){} // RVA: 0x71274E0
        public void <EnumNameFromEnumField>g__NicifyName|8_0(){} // RVA: 0x7127640
    }

    public class Event
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.Event s_Current;
        public UnityEngine.Event s_MasterEvent; // 0x8

        // ── Methods ──
        public void get_rawType(){} // RVA: 0x716D950
        public void get_mousePosition(){} // RVA: 0x716D9A0
        public void set_mousePosition(){} // RVA: 0x716DA00
        public void get_delta(){} // RVA: 0x716DA60
        public void set_delta(){} // RVA: 0x716DAC0
        public void get_pointerType(){} // RVA: 0x716DB20
        public void get_button(){} // RVA: 0x716DB70
        public void get_modifiers(){} // RVA: 0x716DBC0
        public void set_modifiers(){} // RVA: 0x716DC10
        public void get_pressure(){} // RVA: 0x716DC70
        public void get_twist(){} // RVA: 0x716DCC0
        public void get_tilt(){} // RVA: 0x716DD10
        public void get_penStatus(){} // RVA: 0x716DD70
        public void get_clickCount(){} // RVA: 0x716DDC0
        public void get_character(){} // RVA: 0x716DE10
        public void set_character(){} // RVA: 0x716DE60
        public void get_keyCode(){} // RVA: 0x716DEC0
        public void set_keyCode(){} // RVA: 0x716DF10
        public void get_displayIndex(){} // RVA: 0x716DF70
        public void set_displayIndex(){} // RVA: 0x716DFC0
        public void get_type(){} // RVA: 0x716E020
        public void set_type(){} // RVA: 0x716E070
        public void get_commandName(){} // RVA: 0x716E0D0
        public void set_commandName(){} // RVA: 0x716E120
        public void Internal_Use(){} // RVA: 0x716E180
        public void Internal_Create(){} // RVA: 0x716E1D0
        public void Internal_Destroy(){} // RVA: 0x716E220
        public void GetTypeForControl(){} // RVA: 0x716E270
        public void CopyFromPtr(){} // RVA: 0x716E2D0
        public void PopEvent(){} // RVA: 0x716E330
        public void Internal_SetNativeEvent(){} // RVA: 0x716E380
        public void Internal_MakeMasterEventCurrent(){} // RVA: 0x716E3D0
        public void GetDoubleClickTime(){} // RVA: 0x716E620
        public void .ctor(){} // RVA: 0x716E6D0 | overloaded x2
        public void Finalize(){} // RVA: 0x716E730
        public void CopyFrom(){} // RVA: 0x716E7D0
        public void get_shift(){} // RVA: 0x716E850
        public void get_control(){} // RVA: 0x716E8B0
        public void get_alt(){} // RVA: 0x716E910
        public void get_command(){} // RVA: 0x716E970
        public void get_current(){} // RVA: 0x716E9D0
        public void set_current(){} // RVA: 0x716EA10
        public void get_isKey(){} // RVA: 0x716EB20
        public void get_isMouse(){} // RVA: 0x716EB90
        public void get_isDirectManipulationDevice(){} // RVA: 0x716EC10
        public void KeyboardEvent(){} // RVA: 0x716ECC0
        public void GetHashCode(){} // RVA: 0x7170780
        public void Equals(){} // RVA: 0x7170890
        public void ToString(){} // RVA: 0x7170A50
        public void Use(){} // RVA: 0x7171350
        public void get_mousePosition_Injected(){} // RVA: 0x7171590
        public void set_mousePosition_Injected(){} // RVA: 0x71715F0
        public void get_delta_Injected(){} // RVA: 0x7171650
        public void set_delta_Injected(){} // RVA: 0x71716B0
        public void get_tilt_Injected(){} // RVA: 0x7171710
    }

    public class EventInterests
    {
        public bool <wantsMouseMove>k__BackingField; // 0x10
        public bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x11
        public bool <wantsLessLayoutEvents>k__BackingField; // 0x12

        // ── Methods ──
        public void get_wantsMouseMove(){} // RVA: 0x1E40360
        public void set_wantsMouseMove(){} // RVA: 0x1E40370
        public void get_wantsMouseEnterLeaveWindow(){} // RVA: 0x1E40380
        public void set_wantsMouseEnterLeaveWindow(){} // RVA: 0x10EEB00
        public void get_wantsLessLayoutEvents(){} // RVA: 0x1E40390
        public void WantsEvent(){} // RVA: 0x7171770
        public void WantsLayoutPass(){} // RVA: 0x7171790
    }

    public class ExcludeFromObjectFactoryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ExcludeFromPresetAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ExecuteAlways
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ExecuteInEditMode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ExitGUIException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7190EB0 | overloaded x2
    }

    public class ExposedReference`1
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x283FA0
    }

    public class ExposedReference`1
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x331B280
    }

    public class ExposedReference`1
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x331B280
    }

    public class ExpressionEvaluator
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x114C0
        public void EvaluateTokens(){} // RVA: 0x283FA0
        public void EvaluateDouble(){} // RVA: 0x70C8D80
        public void InfixToRPN(){} // RVA: 0x70C92F0
        public void NeedToPop(){} // RVA: 0x70C9900
        public void ExpressionToTokens(){} // RVA: 0x70C9A00
        public void IsCommand(){} // RVA: 0x70C9F30
        public void IsVariable(){} // RVA: 0x70C9FB0
        public void IsDelayedFunction(){} // RVA: 0x70CA000
        public void IsOperator(){} // RVA: 0x70CA070
        public void TokenToOperator(){} // RVA: 0x70CA110
        public void PreFormatExpression(){} // RVA: 0x70CA1C0
        public void FixUnaryOperators(){} // RVA: 0x70CA420
        public void EvaluateOp(){} // RVA: 0x70CA620
        public void TryParse(){} // RVA: 0xE230
        public void .cctor(){} // RVA: 0x70CA9C0
    }

    public class ExtensionOfNativeClassAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}