// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 24
// Methods: 279

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class LabelInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE415080
        public void GetLabel(){} // RVA: 0x7AE4151A0
        public void Reference(){} // RVA: 0x7AE415230
        public void Define(){} // RVA: 0x7AE4152E0
        public void ValidateJump(){} // RVA: 0x7AE415680
        public void ValidateFinish(){} // RVA: 0x7AE415A50
        public void EnsureLabel(){} // RVA: 0x7AE415AE0
        public void DefinedIn(){} // RVA: 0x7AE415B60
        public void get_HasDefinitions(){} // RVA: 0x7A9C435A0
        public void FirstDefinition(){} // RVA: 0x7AE415C10
        public void AddDefinition(){} // RVA: 0x7AE415E50
        public void get_HasMultipleDefinitions(){} // RVA: 0x7AE416070
        public void CommonNode(){} // RVA: 0x7A8051B10
    }

    public class LabelScopeInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE416190
        public void get_CanJumpInto(){} // RVA: 0x7AE4161F0
        public void ContainsTarget(){} // RVA: 0x7AE416200
        public void TryGetLabelInfo(){} // RVA: 0x7AE4162F0
        public void AddLabelInfo(){} // RVA: 0x7AE4163C0
    }

    public class LeaveExceptionFilterInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_InstructionName(){} // RVA: 0x7AE4015C0
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void Run(){} // RVA: 0x7A81CA9D0
        public void .cctor(){} // RVA: 0x7AE401600
    }

    public class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE400100
        public void get_InstructionName(){} // RVA: 0x7AE401810
        public void get_ConsumedStack(){} // RVA: 0x7AE3FFAE0
        public void get_ProducedStack(){} // RVA: 0x7AE3FFAE0
        public void Create(){} // RVA: 0x7AE401850
        public void Run(){} // RVA: 0x7AE4019B0
        public void .cctor(){} // RVA: 0x7AE401A00
    }

    public class LeaveFaultInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ConsumedContinuations(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4013D0
        public void Run(){} // RVA: 0x7AE401410
        public void .cctor(){} // RVA: 0x7AE401440
    }

    public class LeaveFinallyInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_InstructionName(){} // RVA: 0x7AE401000
        public void Run(){} // RVA: 0x7AE401040
        public void .cctor(){} // RVA: 0x7AE401080
    }

    public class LeftShiftInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4164C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE416500
    }

    public class LessThanInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE417480
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Create(){} // RVA: 0x7AE4174C0
    }

    public class LessThanOrEqualInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4191C0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Create(){} // RVA: 0x7AE419200
    }

    public class LightCompiler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE41C2E0
        public void get_Instructions(){} // RVA: 0x7A80F2570
        public void CompileTop(){} // RVA: 0x7AE41C350
        public void MakeInterpreter(){} // RVA: 0x7AE41C870
        public void CompileConstantExpression(){} // RVA: 0x7AE41CE00
        public void CompileDefaultExpression(){} // RVA: 0x7AE41CF00
        public void EnsureAvailableForClosure(){} // RVA: 0x7AE41D0C0
        public void ResolveLocal(){} // RVA: 0x7AE41D470
        public void CompileGetVariable(){} // RVA: 0x7AE41D4E0
        public void EmitCopyValueType(){} // RVA: 0x7AE41D5E0
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7AE41D6C0
        public void MaybeMutableValueType(){} // RVA: 0x7AE41D7E0
        public void CompileGetBoxedVariable(){} // RVA: 0x7AE41D860
        public void CompileSetVariable(){} // RVA: 0x7AE41D900
        public void CompileParameterExpression(){} // RVA: 0x7AE41DB20
        public void CompileBlockExpression(){} // RVA: 0x7AE41DBB0
        public void CompileBlockStart(){} // RVA: 0x7AE41DE30
        public void CompileBlockEnd(){} // RVA: 0x7AE41E3E0
        public void CompileIndexExpression(){} // RVA: 0x7AE41E4B0
        public void EmitIndexGet(){} // RVA: 0x7AE41E600
        public void CompileIndexAssignment(){} // RVA: 0x7AE41E7B0
        public void CompileMemberAssignment(){} // RVA: 0x7AE41EDE0
        public void CompileVariableAssignment(){} // RVA: 0x7AE41F3B0
        public void CompileAssignBinaryExpression(){} // RVA: 0x7AE41F470
        public void CompileBinaryExpression(){} // RVA: 0x7AE41F700
        public void CompileEqual(){} // RVA: 0x7AE4208D0
        public void CompileNotEqual(){} // RVA: 0x7AE420970
        public void CompileComparison(){} // RVA: 0x7AE420A10
        public void CompileArithmetic(){} // RVA: 0x7AE420C10
        public void CompileConvertUnaryExpression(){} // RVA: 0x7AE420EA0
        public void CompileConvertToType(){} // RVA: 0x7AE421740
        public void CompileNotExpression(){} // RVA: 0x7AE421F10
        public void CompileUnaryExpression(){} // RVA: 0x7AE421F80
        public void EmitUnaryMethodCall(){} // RVA: 0x7AE4224B0
        public void EmitUnaryBoolCheck(){} // RVA: 0x7AE4225C0
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7AE4227F0
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7AE422880
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7AE422910
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7AE422B50
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7AE422D90
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7AE423BE0
        public void CompileConditionalExpression(){} // RVA: 0x7AE423D10
        public void CompileLoopExpression(){} // RVA: 0x7AE423FD0
        public void CompileSwitchExpression(){} // RVA: 0x7AE424460
        public void CompileIntSwitchExpression(){} // RVA: 0x7A7E18800
        public void CompileStringSwitchExpression(){} // RVA: 0x7AE424DF0
        public void CompileLabelExpression(){} // RVA: 0x7AE4256C0
        public void CompileGotoExpression(){} // RVA: 0x7AE425950
        public void PushLabelBlock(){} // RVA: 0x7AE425CC0
        public void PopLabelBlock(){} // RVA: 0x7AE425DC0
        public void EnsureLabel(){} // RVA: 0x7AE425E30
        public void ReferenceLabel(){} // RVA: 0x7AE425F90
        public void DefineLabel(){} // RVA: 0x7AE426050
        public void TryPushLabelBlock(){} // RVA: 0x7AE4260F0
        public void DefineBlockLabels(){} // RVA: 0x7AE4264D0
        public void CheckRethrow(){} // RVA: 0x7AE4266C0
        public void CompileThrowUnaryExpression(){} // RVA: 0x7AE426720
        public void CompileTryExpression(){} // RVA: 0x7AE426A30
        public void CompileTryFaultExpression(){} // RVA: 0x7AE4278A0
        public void CompileMethodCallExpression(){} // RVA: 0x7AE427E40
        public void CompileArrayIndexAddress(){} // RVA: 0x7AE4283A0
        public void EmitThisForMethodCall(){} // RVA: 0x7AE428750
        public void ShouldWritebackNode(){} // RVA: 0x7AE428760
        public void CompileAddress(){} // RVA: 0x7AE428960
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7AE429900
        public void CompileNewExpression(){} // RVA: 0x7AE42A100
        public void CompileMemberExpression(){} // RVA: 0x7AE42A660
        public void CompileMember(){} // RVA: 0x7AE42A720
        public void CompileNewArrayExpression(){} // RVA: 0x7AE42AAA0
        public void CompileDebugInfoExpression(){} // RVA: 0x7AE42AFD0
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7AE42B1E0
        public void CompileLambdaExpression(){} // RVA: 0x7AE42B4F0
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7AE42B900
        public void CompileInvocationExpression(){} // RVA: 0x7AE42C160
        public void CompileListInitExpression(){} // RVA: 0x7AE42C480
        public void CompileListInit(){} // RVA: 0x7AE42C520
        public void CompileMemberInitExpression(){} // RVA: 0x7AE42C8D0
        public void CompileMemberInit(){} // RVA: 0x7AE42C970
        public void GetMemberType(){} // RVA: 0x7AE42CE20
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7AE42CF40
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7AE42D4D0
        public void CompileTypeEqualExpression(){} // RVA: 0x7AE42D630
        public void CompileTypeAsExpression(){} // RVA: 0x7AE42D880
        public void CompileTypeIsExpression(){} // RVA: 0x7AE42D960
        public void Compile(){} // RVA: 0x7AE42E850
        public void CompileAsVoid(){} // RVA: 0x7AE42DC90
        public void CompileNoLabelPush(){} // RVA: 0x7AE42DE20
        public void .cctor(){} // RVA: 0x7AE42E8B0
    }

    public class LightDelegateCreator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void get_Interpreter(){} // RVA: 0x7A80DA7B0
        public void CreateDelegate(){} // RVA: 0x7AE4304D0
    }

    public class LightLambda : Object
    {
        // ── Methods ──
        public void Run0(){} // RVA: 0x7A8051B10
        public void RunVoid0(){} // RVA: 0x7AE4306D0
        public void MakeRun0(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid0(){} // RVA: 0x7AE4307A0
        public void Run1(){} // RVA: 0x7A8051B10
        public void RunVoid1(){} // RVA: 0x7A8051B10
        public void MakeRun1(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid1(){} // RVA: 0x7A7E00BA0
        public void Run2(){} // RVA: 0x7A8051B10
        public void RunVoid2(){} // RVA: 0x7A8051B10
        public void MakeRun2(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid2(){} // RVA: 0x7A7E00BA0
        public void Run3(){} // RVA: 0x7A8051B10
        public void RunVoid3(){} // RVA: 0x7A8051B10
        public void MakeRun3(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid3(){} // RVA: 0x7A7E00BA0
        public void Run4(){} // RVA: 0x7A8051B10
        public void RunVoid4(){} // RVA: 0x7A8051B10
        public void MakeRun4(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid4(){} // RVA: 0x7A7E00BA0
        public void Run5(){} // RVA: 0x7A8051B10
        public void RunVoid5(){} // RVA: 0x7A8051B10
        public void MakeRun5(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid5(){} // RVA: 0x7A7E00BA0
        public void Run6(){} // RVA: 0x7A8051B10
        public void RunVoid6(){} // RVA: 0x7A8051B10
        public void MakeRun6(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid6(){} // RVA: 0x7A7E00BA0
        public void Run7(){} // RVA: 0x7A8051B10
        public void RunVoid7(){} // RVA: 0x7A8051B10
        public void MakeRun7(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid7(){} // RVA: 0x7A7E00BA0
        public void Run8(){} // RVA: 0x7A8051B10
        public void RunVoid8(){} // RVA: 0x7A8051B10
        public void MakeRun8(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid8(){} // RVA: 0x7A7E00BA0
        public void Run9(){} // RVA: 0x7A8051B10
        public void RunVoid9(){} // RVA: 0x7A8051B10
        public void MakeRun9(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid9(){} // RVA: 0x7A7E00BA0
        public void Run10(){} // RVA: 0x7A8051B10
        public void RunVoid10(){} // RVA: 0x7A8051B10
        public void MakeRun10(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid10(){} // RVA: 0x7A7E00BA0
        public void Run11(){} // RVA: 0x7A8051B10
        public void RunVoid11(){} // RVA: 0x7A8051B10
        public void MakeRun11(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid11(){} // RVA: 0x7A7E00BA0
        public void Run12(){} // RVA: 0x7A8051B10
        public void RunVoid12(){} // RVA: 0x7A8051B10
        public void MakeRun12(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid12(){} // RVA: 0x7A7E00BA0
        public void Run13(){} // RVA: 0x7A8051B10
        public void RunVoid13(){} // RVA: 0x7A8051B10
        public void MakeRun13(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid13(){} // RVA: 0x7A7E00BA0
        public void Run14(){} // RVA: 0x7A8051B10
        public void RunVoid14(){} // RVA: 0x7A8051B10
        public void MakeRun14(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid14(){} // RVA: 0x7A7E00BA0
        public void Run15(){} // RVA: 0x7A8051B10
        public void RunVoid15(){} // RVA: 0x7A8051B10
        public void MakeRun15(){} // RVA: 0x7A7E00BA0
        public void MakeRunVoid15(){} // RVA: 0x7A7E00BA0
        public void .ctor(){} // RVA: 0x7AE430820
        public void get_DebugView(){} // RVA: 0x7AE430950
        public void GetRunDelegateCtor(){} // RVA: 0x7AE4309D0
        public void MakeRunDelegateCtor(){} // RVA: 0x7AE430C90
        public void CreateCustomDelegate(){} // RVA: 0x7AE4318C0
        public void MakeDelegate(){} // RVA: 0x7AE4320B0
        public void MakeFrame(){} // RVA: 0x7AE432140
        public void RunVoidRef2(){} // RVA: 0x7A7E18890
        public void Run(){} // RVA: 0x7AE4321B0
        public void RunVoid(){} // RVA: 0x7AE432550
        public void .cctor(){} // RVA: 0x7AE432740
    }

    public class LoadCachedObjectInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE443070
        public void Run(){} // RVA: 0x7AE4430B0
        public void ToDebugString(){} // RVA: 0x7AE443150
        public void ToString(){} // RVA: 0x7AE4432C0
    }

    public class LoadFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_InstructionName(){} // RVA: 0x7AE4077B0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE4077F0
    }

    public class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE433FF0
        public void Run(){} // RVA: 0x7AE434030
    }

    public class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE434260
        public void Run(){} // RVA: 0x7AE4342A0
    }

    public class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE434140
        public void Run(){} // RVA: 0x7AE434180
    }

    public class LoadLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE433EA0
        public void Run(){} // RVA: 0x7AE433EE0
        public void BoxIfIndexMatches(){} // RVA: 0x7AE433F80
    }

    public class LoadObjectInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE442F10
        public void Run(){} // RVA: 0x7AE442F50
        public void ToString(){} // RVA: 0x7AE442FD0
    }

    public class LoadStaticFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_InstructionName(){} // RVA: 0x7AE4076C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE407700
    }

    public class LocalAccessInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void ToDebugString(){} // RVA: 0x7AE433D00
    }

    public class LocalDefinition : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A790A7A0
        public void get_Index(){} // RVA: 0x7A765F070
        public void get_Parameter(){} // RVA: 0x7A765F080
        public void Equals(){} // RVA: 0x7A7E7F730
        public void GetHashCode(){} // RVA: 0x7A7E7F740
    }

    public class LocalVariable : Object
    {
        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x7AE435840
        public void set_IsBoxed(){} // RVA: 0x7AE435850
        public void get_InClosure(){} // RVA: 0x7AE435870
        public void .ctor(){} // RVA: 0x7AE435880
        public void ToString(){} // RVA: 0x7AE435890
    }

    public class LocalVariables : Object
    {
        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x7AE435AB0
        public void UndefineLocal(){} // RVA: 0x7AE435E80
        public void Box(){} // RVA: 0x7AE436000
        public void get_LocalCount(){} // RVA: 0x7A8AB15F0
        public void TryGetLocalOrClosure(){} // RVA: 0x7AE436180
        public void get_ClosureVariables(){} // RVA: 0x7A80DA7B0
        public void AddClosureVariable(){} // RVA: 0x7AE436380
        public void .ctor(){} // RVA: 0x7AE436500
    }

}