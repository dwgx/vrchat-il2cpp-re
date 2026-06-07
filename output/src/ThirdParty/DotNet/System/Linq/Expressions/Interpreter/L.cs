// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 24
// Methods: 285

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class LabelInfo
    {
        public object padding;
        public object childAlignment;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6626680
        public void GetLabel(){} // RVA: 0x66267A0
        public void Reference(){} // RVA: 0x6626830
        public void Define(){} // RVA: 0x66268E0
        public void ValidateJump(){} // RVA: 0x6626C80
        public void ValidateFinish(){} // RVA: 0x6627060
        public void EnsureLabel(){} // RVA: 0x66270F0
        public void DefinedIn(){} // RVA: 0x6627170
        public void get_HasDefinitions(){} // RVA: 0x1E3EC10
        public void FirstDefinition(){} // RVA: 0x6627240
        public void AddDefinition(){} // RVA: 0x6627470
        public void get_HasMultipleDefinitions(){} // RVA: 0x6627690
        public void CommonNode(){} // RVA: 0x283FA0
    }

    public class LabelScopeInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66277C0
        public void get_CanJumpInto(){} // RVA: 0x6627820
        public void ContainsTarget(){} // RVA: 0x6627830
        public void TryGetLabelInfo(){} // RVA: 0x6627920
        public void AddLabelInfo(){} // RVA: 0x66279F0
    }

    public class LeaveExceptionFilterInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_InstructionName(){} // RVA: 0x6612B10
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void Run(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x6612B50
    }

    public class LeaveExceptionHandlerInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6611640
        public void get_InstructionName(){} // RVA: 0x6612D60
        public void get_ConsumedStack(){} // RVA: 0x6611020
        public void get_ProducedStack(){} // RVA: 0x6611020
        public void Create(){} // RVA: 0x6612DA0
        public void Run(){} // RVA: 0x6612F00
        public void .cctor(){} // RVA: 0x6612F50
    }

    public class LeaveFaultInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ConsumedContinuations(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6612920
        public void Run(){} // RVA: 0x6612960
        public void .cctor(){} // RVA: 0x6612990
    }

    public class LeaveFinallyInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_InstructionName(){} // RVA: 0x6612550
        public void Run(){} // RVA: 0x6612590
        public void .cctor(){} // RVA: 0x66125D0
    }

    public class LeftShiftInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6627AF0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6627B30
    }

    public class LessThanInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6628AB0
        public void .ctor(){} // RVA: 0x2DEE30
        public void Create(){} // RVA: 0x6628AF0
    }

    public class LessThanOrEqualInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x662A7F0
        public void .ctor(){} // RVA: 0x2DEE30
        public void Create(){} // RVA: 0x662A830
    }

    public class LightCompiler
    {
        public object DebugView;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662D910 | overloaded x2
        public void get_Instructions(){} // RVA: 0x2F8380
        public void CompileTop(){} // RVA: 0x662D980
        public void MakeInterpreter(){} // RVA: 0x662DE90
        public void CompileConstantExpression(){} // RVA: 0x662E410
        public void CompileDefaultExpression(){} // RVA: 0x662E510 | overloaded x2
        public void EnsureAvailableForClosure(){} // RVA: 0x662E6D0
        public void ResolveLocal(){} // RVA: 0x662EA90
        public void CompileGetVariable(){} // RVA: 0x662EB00
        public void EmitCopyValueType(){} // RVA: 0x662EC00
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x662ECE0
        public void MaybeMutableValueType(){} // RVA: 0x662EE00
        public void CompileGetBoxedVariable(){} // RVA: 0x662EE80
        public void CompileSetVariable(){} // RVA: 0x662EF20
        public void CompileParameterExpression(){} // RVA: 0x662F140
        public void CompileBlockExpression(){} // RVA: 0x662F1D0
        public void CompileBlockStart(){} // RVA: 0x662F450
        public void CompileBlockEnd(){} // RVA: 0x662FA10
        public void CompileIndexExpression(){} // RVA: 0x662FAF0
        public void EmitIndexGet(){} // RVA: 0x662FC40
        public void CompileIndexAssignment(){} // RVA: 0x662FDF0
        public void CompileMemberAssignment(){} // RVA: 0x6630420 | overloaded x2
        public void CompileVariableAssignment(){} // RVA: 0x6630A00
        public void CompileAssignBinaryExpression(){} // RVA: 0x6630AC0
        public void CompileBinaryExpression(){} // RVA: 0x6630D50
        public void CompileEqual(){} // RVA: 0x6631F20
        public void CompileNotEqual(){} // RVA: 0x6631FC0
        public void CompileComparison(){} // RVA: 0x6632060
        public void CompileArithmetic(){} // RVA: 0x6632260
        public void CompileConvertUnaryExpression(){} // RVA: 0x66324F0
        public void CompileConvertToType(){} // RVA: 0x6632D90
        public void CompileNotExpression(){} // RVA: 0x6633570
        public void CompileUnaryExpression(){} // RVA: 0x66335E0
        public void EmitUnaryMethodCall(){} // RVA: 0x6633B10
        public void EmitUnaryBoolCheck(){} // RVA: 0x6633C20
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x6633E50
        public void CompileOrElseBinaryExpression(){} // RVA: 0x6633EE0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x6633F70
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x66341C0
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x6634400
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x6635280
        public void CompileConditionalExpression(){} // RVA: 0x66353C0
        public void CompileLoopExpression(){} // RVA: 0x6635690
        public void CompileSwitchExpression(){} // RVA: 0x6635B20
        public void CompileIntSwitchExpression(){} // RVA: 0x24B10
        public void CompileStringSwitchExpression(){} // RVA: 0x6636500
        public void CompileLabelExpression(){} // RVA: 0x6636DD0
        public void CompileGotoExpression(){} // RVA: 0x6637060
        public void PushLabelBlock(){} // RVA: 0x66373E0
        public void PopLabelBlock(){} // RVA: 0x66374E0
        public void EnsureLabel(){} // RVA: 0x6637550
        public void ReferenceLabel(){} // RVA: 0x66376B0
        public void DefineLabel(){} // RVA: 0x6637770
        public void TryPushLabelBlock(){} // RVA: 0x6637810
        public void DefineBlockLabels(){} // RVA: 0x6637BF0
        public void CheckRethrow(){} // RVA: 0x6637DE0
        public void CompileThrowUnaryExpression(){} // RVA: 0x6637E40
        public void CompileTryExpression(){} // RVA: 0x6638150
        public void CompileTryFaultExpression(){} // RVA: 0x6638FB0
        public void CompileMethodCallExpression(){} // RVA: 0x6639550 | overloaded x2
        public void CompileArrayIndexAddress(){} // RVA: 0x6639A90
        public void EmitThisForMethodCall(){} // RVA: 0x6639E30
        public void ShouldWritebackNode(){} // RVA: 0x6639E40
        public void CompileAddress(){} // RVA: 0x663A060
        public void CompileMultiDimArrayAccess(){} // RVA: 0x663AFA0
        public void CompileNewExpression(){} // RVA: 0x663B780
        public void CompileMemberExpression(){} // RVA: 0x663BCE0
        public void CompileMember(){} // RVA: 0x663BDA0
        public void CompileNewArrayExpression(){} // RVA: 0x663C120
        public void CompileDebugInfoExpression(){} // RVA: 0x663C630
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x663C840
        public void CompileLambdaExpression(){} // RVA: 0x663CB60
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x663CF60
        public void CompileInvocationExpression(){} // RVA: 0x663D7C0
        public void CompileListInitExpression(){} // RVA: 0x663DAE0
        public void CompileListInit(){} // RVA: 0x663DB80
        public void CompileMemberInitExpression(){} // RVA: 0x663DF30
        public void CompileMemberInit(){} // RVA: 0x663DFD0
        public void GetMemberType(){} // RVA: 0x663E480
        public void CompileQuoteUnaryExpression(){} // RVA: 0x663E5C0
        public void CompileUnboxUnaryExpression(){} // RVA: 0x663EB40
        public void CompileTypeEqualExpression(){} // RVA: 0x663ECA0
        public void CompileTypeAsExpression(){} // RVA: 0x663EEF0
        public void CompileTypeIsExpression(){} // RVA: 0x663EFD0
        public void Compile(){} // RVA: 0x663FEC0 | overloaded x2
        public void CompileAsVoid(){} // RVA: 0x663F300
        public void CompileNoLabelPush(){} // RVA: 0x663F490
        public void .cctor(){} // RVA: 0x663FF20
    }

    public class LightDelegateCreator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
        public void get_Interpreter(){} // RVA: 0x2E07C0
        public void CreateDelegate(){} // RVA: 0x6641B40 | overloaded x2
    }

    public class LightLambda
    {
        // ── Methods ──
        public void Run0(){} // RVA: 0x283FA0
        public void RunVoid0(){} // RVA: 0x6641D40
        public void MakeRun0(){} // RVA: 0xCE50
        public void MakeRunVoid0(){} // RVA: 0x6641E00
        public void Run1(){} // RVA: 0x283FA0
        public void RunVoid1(){} // RVA: 0x283FA0
        public void MakeRun1(){} // RVA: 0xCE50
        public void MakeRunVoid1(){} // RVA: 0xCE50
        public void Run2(){} // RVA: 0x283FA0
        public void RunVoid2(){} // RVA: 0x283FA0
        public void MakeRun2(){} // RVA: 0xCE50
        public void MakeRunVoid2(){} // RVA: 0xCE50
        public void Run3(){} // RVA: 0x283FA0
        public void RunVoid3(){} // RVA: 0x283FA0
        public void MakeRun3(){} // RVA: 0xCE50
        public void MakeRunVoid3(){} // RVA: 0xCE50
        public void Run4(){} // RVA: 0x283FA0
        public void RunVoid4(){} // RVA: 0x283FA0
        public void MakeRun4(){} // RVA: 0xCE50
        public void MakeRunVoid4(){} // RVA: 0xCE50
        public void Run5(){} // RVA: 0x283FA0
        public void RunVoid5(){} // RVA: 0x283FA0
        public void MakeRun5(){} // RVA: 0xCE50
        public void MakeRunVoid5(){} // RVA: 0xCE50
        public void Run6(){} // RVA: 0x283FA0
        public void RunVoid6(){} // RVA: 0x283FA0
        public void MakeRun6(){} // RVA: 0xCE50
        public void MakeRunVoid6(){} // RVA: 0xCE50
        public void Run7(){} // RVA: 0x283FA0
        public void RunVoid7(){} // RVA: 0x283FA0
        public void MakeRun7(){} // RVA: 0xCE50
        public void MakeRunVoid7(){} // RVA: 0xCE50
        public void Run8(){} // RVA: 0x283FA0
        public void RunVoid8(){} // RVA: 0x283FA0
        public void MakeRun8(){} // RVA: 0xCE50
        public void MakeRunVoid8(){} // RVA: 0xCE50
        public void Run9(){} // RVA: 0x283FA0
        public void RunVoid9(){} // RVA: 0x283FA0
        public void MakeRun9(){} // RVA: 0xCE50
        public void MakeRunVoid9(){} // RVA: 0xCE50
        public void Run10(){} // RVA: 0x283FA0
        public void RunVoid10(){} // RVA: 0x283FA0
        public void MakeRun10(){} // RVA: 0xCE50
        public void MakeRunVoid10(){} // RVA: 0xCE50
        public void Run11(){} // RVA: 0x283FA0
        public void RunVoid11(){} // RVA: 0x283FA0
        public void MakeRun11(){} // RVA: 0xCE50
        public void MakeRunVoid11(){} // RVA: 0xCE50
        public void Run12(){} // RVA: 0x283FA0
        public void RunVoid12(){} // RVA: 0x283FA0
        public void MakeRun12(){} // RVA: 0xCE50
        public void MakeRunVoid12(){} // RVA: 0xCE50
        public void Run13(){} // RVA: 0x283FA0
        public void RunVoid13(){} // RVA: 0x283FA0
        public void MakeRun13(){} // RVA: 0xCE50
        public void MakeRunVoid13(){} // RVA: 0xCE50
        public void Run14(){} // RVA: 0x283FA0
        public void RunVoid14(){} // RVA: 0x283FA0
        public void MakeRun14(){} // RVA: 0xCE50
        public void MakeRunVoid14(){} // RVA: 0xCE50
        public void Run15(){} // RVA: 0x283FA0
        public void RunVoid15(){} // RVA: 0x283FA0
        public void MakeRun15(){} // RVA: 0xCE50
        public void MakeRunVoid15(){} // RVA: 0xCE50
        public void .ctor(){} // RVA: 0x6641E80
        public void get_DebugView(){} // RVA: 0x6641FB0
        public void GetRunDelegateCtor(){} // RVA: 0x6642030
        public void MakeRunDelegateCtor(){} // RVA: 0x6642330
        public void CreateCustomDelegate(){} // RVA: 0x6642F20
        public void MakeDelegate(){} // RVA: 0x6643710
        public void MakeFrame(){} // RVA: 0x66437A0
        public void RunVoidRef2(){} // RVA: 0x2DC60
        public void Run(){} // RVA: 0x6643810
        public void RunVoid(){} // RVA: 0x6643BB0
        public void .cctor(){} // RVA: 0x6643DB0
    }

    public class LoadCachedObjectInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6654610
        public void Run(){} // RVA: 0x6654650
        public void ToDebugString(){} // RVA: 0x66546F0
        public void ToString(){} // RVA: 0x6654860
    }

    public class LoadFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_InstructionName(){} // RVA: 0x6618CA0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6618CE0
    }

    public class LoadLocalBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645630
        public void Run(){} // RVA: 0x6645670
    }

    public class LoadLocalFromClosureBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x66458A0
        public void Run(){} // RVA: 0x66458E0
    }

    public class LoadLocalFromClosureInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645780
        public void Run(){} // RVA: 0x66457C0
    }

    public class LoadLocalInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x66454E0
        public void Run(){} // RVA: 0x6645520
        public void BoxIfIndexMatches(){} // RVA: 0x66455C0
    }

    public class LoadObjectInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x66544B0
        public void Run(){} // RVA: 0x66544F0
        public void ToString(){} // RVA: 0x6654570
    }

    public class LoadStaticFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_InstructionName(){} // RVA: 0x6618BB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6618BF0
    }

    public class LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void ToDebugString(){} // RVA: 0x6645340
    }

    public class LocalDefinition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C6C70
        public void get_Index(){} // RVA: 0x19689B0
        public void get_Parameter(){} // RVA: 0x19689C0
        public void Equals(){} // RVA: 0x6647010
        public void GetHashCode(){} // RVA: 0x66470B0
    }

    public class LocalVariable
    {
        public object Index;
        public object Parameter;

        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x6646E80
        public void set_IsBoxed(){} // RVA: 0x6646E90
        public void get_InClosure(){} // RVA: 0x6646EB0
        public void .ctor(){} // RVA: 0x6646EC0
        public void ToString(){} // RVA: 0x6646ED0
    }

    public class LocalVariables
    {
        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x66470F0
        public void UndefineLocal(){} // RVA: 0x66474B0
        public void Box(){} // RVA: 0x6647630
        public void get_LocalCount(){} // RVA: 0xCEF5B0
        public void TryGetLocalOrClosure(){} // RVA: 0x66477B0
        public void get_ClosureVariables(){} // RVA: 0x2E07C0
        public void AddClosureVariable(){} // RVA: 0x66479C0
        public void .ctor(){} // RVA: 0x6647B40
    }

}