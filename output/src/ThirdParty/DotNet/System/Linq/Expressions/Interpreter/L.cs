// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 24
// Methods: 285

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class LabelInfo : Object
    {
        public System.Linq.Expressions.LabelTarget _node; // 0x10
        public System.Linq.Expressions.Interpreter.BranchLabel _label; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87165570
        public void GetLabel(){} // RVA: 0x7FFE87165690
        public void Reference(){} // RVA: 0x7FFE87165720
        public void Define(){} // RVA: 0x7FFE871657D0
        public void ValidateJump(){} // RVA: 0x7FFE87165B70
        public void ValidateFinish(){} // RVA: 0x7FFE87165F50
        public void EnsureLabel(){} // RVA: 0x7FFE87165FE0
        public void DefinedIn(){} // RVA: 0x7FFE87166060
        public void get_HasDefinitions(){} // RVA: 0x7FFE82BC81D0
        public void FirstDefinition(){} // RVA: 0x7FFE87166130
        public void AddDefinition(){} // RVA: 0x7FFE87166360
        public void get_HasMultipleDefinitions(){} // RVA: 0x7FFE87166580
        public void CommonNode(){} // RVA: 0x7FFE810A1420
    }

    public class LabelScopeInfo : Object
    {
        public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo> _labels; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871666B0
        public void get_CanJumpInto(){} // RVA: 0x7FFE87166710
        public void ContainsTarget(){} // RVA: 0x7FFE87166720
        public void TryGetLabelInfo(){} // RVA: 0x7FFE87166810
        public void AddLabelInfo(){} // RVA: 0x7FFE871668E0
    }

    public class LeaveExceptionFilterInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction Instance;
        public object field_1; // 0x2B7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_InstructionName(){} // RVA: 0x7FFE871519E0
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void Run(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE87151A20
    }

    public class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[] s_cache;
        public bool _hasValue; // 0x18
        public object field_2; // 0x2BC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87150510
        public void get_InstructionName(){} // RVA: 0x7FFE87151C30
        public void get_ConsumedStack(){} // RVA: 0x7FFE8714FEF0
        public void get_ProducedStack(){} // RVA: 0x7FFE8714FEF0
        public void Create(){} // RVA: 0x7FFE87151C70
        public void Run(){} // RVA: 0x7FFE87151DD0
        public void .cctor(){} // RVA: 0x7FFE87151E20
    }

    public class LeaveFaultInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction Instance;
        public object field_1; // 0x2B2
        public object field_2; // 0x2B3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871517F0
        public void Run(){} // RVA: 0x7FFE87151830
        public void .cctor(){} // RVA: 0x7FFE87151860
    }

    public class LeaveFinallyInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction Instance;
        public object field_1; // 0x2AE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_InstructionName(){} // RVA: 0x7FFE87151420
        public void Run(){} // RVA: 0x7FFE87151460
        public void .cctor(){} // RVA: 0x7FFE871514A0
    }

    public class LeftShiftInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871669E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87166A20
    }

    public class LessThanInstruction : Instruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871679A0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Create(){} // RVA: 0x7FFE871679E0
    }

    public class LessThanOrEqualInstruction : Instruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871696E0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Create(){} // RVA: 0x7FFE87169720
    }

    public class LightCompiler : Object
    {
        public System.Linq.Expressions.Interpreter.InstructionList _instructions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8716C800 | overloaded x2
        public void get_Instructions(){} // RVA: 0x7FFE81116380
        public void CompileTop(){} // RVA: 0x7FFE8716C870
        public void MakeInterpreter(){} // RVA: 0x7FFE8716CD80
        public void CompileConstantExpression(){} // RVA: 0x7FFE8716D300
        public void CompileDefaultExpression(){} // RVA: 0x7FFE8716D400 | overloaded x2
        public void EnsureAvailableForClosure(){} // RVA: 0x7FFE8716D5C0
        public void ResolveLocal(){} // RVA: 0x7FFE8716D980
        public void CompileGetVariable(){} // RVA: 0x7FFE8716D9F0
        public void EmitCopyValueType(){} // RVA: 0x7FFE8716DAF0
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7FFE8716DBD0
        public void MaybeMutableValueType(){} // RVA: 0x7FFE8716DCF0
        public void CompileGetBoxedVariable(){} // RVA: 0x7FFE8716DD70
        public void CompileSetVariable(){} // RVA: 0x7FFE8716DE10
        public void CompileParameterExpression(){} // RVA: 0x7FFE8716E030
        public void CompileBlockExpression(){} // RVA: 0x7FFE8716E0C0
        public void CompileBlockStart(){} // RVA: 0x7FFE8716E340
        public void CompileBlockEnd(){} // RVA: 0x7FFE8716E900
        public void CompileIndexExpression(){} // RVA: 0x7FFE8716E9E0
        public void EmitIndexGet(){} // RVA: 0x7FFE8716EB30
        public void CompileIndexAssignment(){} // RVA: 0x7FFE8716ECE0
        public void CompileMemberAssignment(){} // RVA: 0x7FFE8716F310 | overloaded x2
        public void CompileVariableAssignment(){} // RVA: 0x7FFE8716F8F0
        public void CompileAssignBinaryExpression(){} // RVA: 0x7FFE8716F9B0
        public void CompileBinaryExpression(){} // RVA: 0x7FFE8716FC40
        public void CompileEqual(){} // RVA: 0x7FFE87170E10
        public void CompileNotEqual(){} // RVA: 0x7FFE87170EB0
        public void CompileComparison(){} // RVA: 0x7FFE87170F50
        public void CompileArithmetic(){} // RVA: 0x7FFE87171150
        public void CompileConvertUnaryExpression(){} // RVA: 0x7FFE871713E0
        public void CompileConvertToType(){} // RVA: 0x7FFE87171C80
        public void CompileNotExpression(){} // RVA: 0x7FFE87172460
        public void CompileUnaryExpression(){} // RVA: 0x7FFE871724D0
        public void EmitUnaryMethodCall(){} // RVA: 0x7FFE87172A00
        public void EmitUnaryBoolCheck(){} // RVA: 0x7FFE87172B10
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7FFE87172D40
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7FFE87172DD0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7FFE87172E60
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7FFE871730B0
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7FFE871732F0
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7FFE87174170
        public void CompileConditionalExpression(){} // RVA: 0x7FFE871742B0
        public void CompileLoopExpression(){} // RVA: 0x7FFE87174580
        public void CompileSwitchExpression(){} // RVA: 0x7FFE87174A10
        public void CompileIntSwitchExpression(){} // RVA: 0x7FFE80E460A0
        public void CompileStringSwitchExpression(){} // RVA: 0x7FFE871753F0
        public void CompileLabelExpression(){} // RVA: 0x7FFE87175CC0
        public void CompileGotoExpression(){} // RVA: 0x7FFE87175F50
        public void PushLabelBlock(){} // RVA: 0x7FFE871762D0
        public void PopLabelBlock(){} // RVA: 0x7FFE871763D0
        public void EnsureLabel(){} // RVA: 0x7FFE87176440
        public void ReferenceLabel(){} // RVA: 0x7FFE871765A0
        public void DefineLabel(){} // RVA: 0x7FFE87176660
        public void TryPushLabelBlock(){} // RVA: 0x7FFE87176700
        public void DefineBlockLabels(){} // RVA: 0x7FFE87176AE0
        public void CheckRethrow(){} // RVA: 0x7FFE87176CD0
        public void CompileThrowUnaryExpression(){} // RVA: 0x7FFE87176D30
        public void CompileTryExpression(){} // RVA: 0x7FFE87177040
        public void CompileTryFaultExpression(){} // RVA: 0x7FFE87177EA0
        public void CompileMethodCallExpression(){} // RVA: 0x7FFE87178440 | overloaded x2
        public void CompileArrayIndexAddress(){} // RVA: 0x7FFE87178980
        public void EmitThisForMethodCall(){} // RVA: 0x7FFE87178D20
        public void ShouldWritebackNode(){} // RVA: 0x7FFE87178D30
        public void CompileAddress(){} // RVA: 0x7FFE87178F50
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7FFE87179E90
        public void CompileNewExpression(){} // RVA: 0x7FFE8717A670
        public void CompileMemberExpression(){} // RVA: 0x7FFE8717ABD0
        public void CompileMember(){} // RVA: 0x7FFE8717AC90
        public void CompileNewArrayExpression(){} // RVA: 0x7FFE8717B010
        public void CompileDebugInfoExpression(){} // RVA: 0x7FFE8717B520
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7FFE8717B730
        public void CompileLambdaExpression(){} // RVA: 0x7FFE8717BA50
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7FFE8717BE50
        public void CompileInvocationExpression(){} // RVA: 0x7FFE8717C6B0
        public void CompileListInitExpression(){} // RVA: 0x7FFE8717C9D0
        public void CompileListInit(){} // RVA: 0x7FFE8717CA70
        public void CompileMemberInitExpression(){} // RVA: 0x7FFE8717CE20
        public void CompileMemberInit(){} // RVA: 0x7FFE8717CEC0
        public void GetMemberType(){} // RVA: 0x7FFE8717D370
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7FFE8717D4B0
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7FFE8717DA30
        public void CompileTypeEqualExpression(){} // RVA: 0x7FFE8717DB90
        public void CompileTypeAsExpression(){} // RVA: 0x7FFE8717DDE0
        public void CompileTypeIsExpression(){} // RVA: 0x7FFE8717DEC0
        public void Compile(){} // RVA: 0x7FFE8717EDB0 | overloaded x2
        public void CompileAsVoid(){} // RVA: 0x7FFE8717E1F0
        public void CompileNoLabelPush(){} // RVA: 0x7FFE8717E380
        public void .cctor(){} // RVA: 0x7FFE8717EE10
    }

    public class LightDelegateCreator : Object
    {
        public System.Linq.Expressions.LambdaExpression _lambda; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
        public void get_Interpreter(){} // RVA: 0x7FFE810FE7C0
        public void CreateDelegate(){} // RVA: 0x7FFE87180A30 | overloaded x2
    }

    public class LightLambda : Object
    {
        public int MaxParameters;

        // ── Methods ──
        public void Run0(){} // RVA: 0x7FFE810A1420
        public void RunVoid0(){} // RVA: 0x7FFE87180C30
        public void MakeRun0(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid0(){} // RVA: 0x7FFE87180CF0
        public void Run1(){} // RVA: 0x7FFE810A1420
        public void RunVoid1(){} // RVA: 0x7FFE810A1420
        public void MakeRun1(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid1(){} // RVA: 0x7FFE80E2E3D0
        public void Run2(){} // RVA: 0x7FFE810A1420
        public void RunVoid2(){} // RVA: 0x7FFE810A1420
        public void MakeRun2(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid2(){} // RVA: 0x7FFE80E2E3D0
        public void Run3(){} // RVA: 0x7FFE810A1420
        public void RunVoid3(){} // RVA: 0x7FFE810A1420
        public void MakeRun3(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid3(){} // RVA: 0x7FFE80E2E3D0
        public void Run4(){} // RVA: 0x7FFE810A1420
        public void RunVoid4(){} // RVA: 0x7FFE810A1420
        public void MakeRun4(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid4(){} // RVA: 0x7FFE80E2E3D0
        public void Run5(){} // RVA: 0x7FFE810A1420
        public void RunVoid5(){} // RVA: 0x7FFE810A1420
        public void MakeRun5(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid5(){} // RVA: 0x7FFE80E2E3D0
        public void Run6(){} // RVA: 0x7FFE810A1420
        public void RunVoid6(){} // RVA: 0x7FFE810A1420
        public void MakeRun6(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid6(){} // RVA: 0x7FFE80E2E3D0
        public void Run7(){} // RVA: 0x7FFE810A1420
        public void RunVoid7(){} // RVA: 0x7FFE810A1420
        public void MakeRun7(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid7(){} // RVA: 0x7FFE80E2E3D0
        public void Run8(){} // RVA: 0x7FFE810A1420
        public void RunVoid8(){} // RVA: 0x7FFE810A1420
        public void MakeRun8(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid8(){} // RVA: 0x7FFE80E2E3D0
        public void Run9(){} // RVA: 0x7FFE810A1420
        public void RunVoid9(){} // RVA: 0x7FFE810A1420
        public void MakeRun9(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid9(){} // RVA: 0x7FFE80E2E3D0
        public void Run10(){} // RVA: 0x7FFE810A1420
        public void RunVoid10(){} // RVA: 0x7FFE810A1420
        public void MakeRun10(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid10(){} // RVA: 0x7FFE80E2E3D0
        public void Run11(){} // RVA: 0x7FFE810A1420
        public void RunVoid11(){} // RVA: 0x7FFE810A1420
        public void MakeRun11(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid11(){} // RVA: 0x7FFE80E2E3D0
        public void Run12(){} // RVA: 0x7FFE810A1420
        public void RunVoid12(){} // RVA: 0x7FFE810A1420
        public void MakeRun12(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid12(){} // RVA: 0x7FFE80E2E3D0
        public void Run13(){} // RVA: 0x7FFE810A1420
        public void RunVoid13(){} // RVA: 0x7FFE810A1420
        public void MakeRun13(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid13(){} // RVA: 0x7FFE80E2E3D0
        public void Run14(){} // RVA: 0x7FFE810A1420
        public void RunVoid14(){} // RVA: 0x7FFE810A1420
        public void MakeRun14(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid14(){} // RVA: 0x7FFE80E2E3D0
        public void Run15(){} // RVA: 0x7FFE810A1420
        public void RunVoid15(){} // RVA: 0x7FFE810A1420
        public void MakeRun15(){} // RVA: 0x7FFE80E2E3D0
        public void MakeRunVoid15(){} // RVA: 0x7FFE80E2E3D0
        public void .ctor(){} // RVA: 0x7FFE87180D70
        public void get_DebugView(){} // RVA: 0x7FFE87180EA0
        public void GetRunDelegateCtor(){} // RVA: 0x7FFE87180F20
        public void MakeRunDelegateCtor(){} // RVA: 0x7FFE87181220
        public void CreateCustomDelegate(){} // RVA: 0x7FFE87181E10
        public void MakeDelegate(){} // RVA: 0x7FFE87182600
        public void MakeFrame(){} // RVA: 0x7FFE87182690
        public void RunVoidRef2(){} // RVA: 0x7FFE80E4F230
        public void Run(){} // RVA: 0x7FFE87182700
        public void RunVoid(){} // RVA: 0x7FFE87182AA0
        public void .cctor(){} // RVA: 0x7FFE87182CA0
    }

    public class LoadCachedObjectInstruction : Instruction
    {
        public uint _index; // 0x10
        public object field_1; // 0x363

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87193500
        public void Run(){} // RVA: 0x7FFE87193540
        public void ToDebugString(){} // RVA: 0x7FFE871935E0
        public void ToString(){} // RVA: 0x7FFE87193750
    }

    public class LoadFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_InstructionName(){} // RVA: 0x7FFE87157B70
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE87157BB0
    }

    public class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184520
        public void Run(){} // RVA: 0x7FFE87184560
    }

    public class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184790
        public void Run(){} // RVA: 0x7FFE871847D0
    }

    public class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184670
        public void Run(){} // RVA: 0x7FFE871846B0
    }

    public class LoadLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871843D0
        public void Run(){} // RVA: 0x7FFE87184410
        public void BoxIfIndexMatches(){} // RVA: 0x7FFE871844B0
    }

    public class LoadObjectInstruction : Instruction
    {
        public object _value; // 0x10
        public object field_1; // 0x361

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871933A0
        public void Run(){} // RVA: 0x7FFE871933E0
        public void ToString(){} // RVA: 0x7FFE87193460
    }

    public class LoadStaticFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_InstructionName(){} // RVA: 0x7FFE87157A80
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE87157AC0
    }

    public class LocalAccessInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void ToDebugString(){} // RVA: 0x7FFE87184230
    }

    public class LocalDefinition : ValueType
    {
        public int _index; // 0x10
        public System.Linq.Expressions.ParameterExpression _parameter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844576B0
        public void get_Index(){} // RVA: 0x7FFE826F4220
        public void get_Parameter(){} // RVA: 0x7FFE826F4210
        public void Equals(){} // RVA: 0x7FFE87185F00
        public void GetHashCode(){} // RVA: 0x7FFE87185FA0
    }

    public class LocalVariable : Object
    {
        public int IsBoxedFlag;
        public int InClosureFlag;

        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x7FFE87185D70
        public void set_IsBoxed(){} // RVA: 0x7FFE87185D80
        public void get_InClosure(){} // RVA: 0x7FFE87185DA0
        public void .ctor(){} // RVA: 0x7FFE87185DB0
        public void ToString(){} // RVA: 0x7FFE87185DC0
    }

    public class LocalVariables : Object
    {
        public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.ParameterExpression,VariableScope> _variables; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> _closureVariables; // 0x18

        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x7FFE87185FE0
        public void UndefineLocal(){} // RVA: 0x7FFE871863A0
        public void Box(){} // RVA: 0x7FFE87186520
        public void get_LocalCount(){} // RVA: 0x7FFE81A56130
        public void TryGetLocalOrClosure(){} // RVA: 0x7FFE871866A0
        public void get_ClosureVariables(){} // RVA: 0x7FFE810FE7C0
        public void AddClosureVariable(){} // RVA: 0x7FFE871868B0
        public void .ctor(){} // RVA: 0x7FFE87186A30
    }

}