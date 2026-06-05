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
        public void .ctor(){} // RVA: 0x7FFAF90D6680
        public void GetLabel(){} // RVA: 0x7FFAF90D67A0
        public void Reference(){} // RVA: 0x7FFAF90D6830
        public void Define(){} // RVA: 0x7FFAF90D68E0
        public void ValidateJump(){} // RVA: 0x7FFAF90D6C80
        public void ValidateFinish(){} // RVA: 0x7FFAF90D7060
        public void EnsureLabel(){} // RVA: 0x7FFAF90D70F0
        public void DefinedIn(){} // RVA: 0x7FFAF90D7170
        public void get_HasDefinitions(){} // RVA: 0x7FFAF48EEC10
        public void FirstDefinition(){} // RVA: 0x7FFAF90D7240
        public void AddDefinition(){} // RVA: 0x7FFAF90D7470
        public void get_HasMultipleDefinitions(){} // RVA: 0x7FFAF90D7690
        public void CommonNode(){} // RVA: 0x7FFAF2D33FA0
    }

    public class LabelScopeInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90D77C0
        public void get_CanJumpInto(){} // RVA: 0x7FFAF90D7820
        public void ContainsTarget(){} // RVA: 0x7FFAF90D7830
        public void TryGetLabelInfo(){} // RVA: 0x7FFAF90D7920
        public void AddLabelInfo(){} // RVA: 0x7FFAF90D79F0
    }

    public class LeaveExceptionFilterInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_InstructionName(){} // RVA: 0x7FFAF90C2B10
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void Run(){} // RVA: 0x7FFAF2E7FAF0
        public void .cctor(){} // RVA: 0x7FFAF90C2B50
    }

    public class LeaveExceptionHandlerInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90C1640
        public void get_InstructionName(){} // RVA: 0x7FFAF90C2D60
        public void get_ConsumedStack(){} // RVA: 0x7FFAF90C1020
        public void get_ProducedStack(){} // RVA: 0x7FFAF90C1020
        public void Create(){} // RVA: 0x7FFAF90C2DA0
        public void Run(){} // RVA: 0x7FFAF90C2F00
        public void .cctor(){} // RVA: 0x7FFAF90C2F50
    }

    public class LeaveFaultInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90C2920
        public void Run(){} // RVA: 0x7FFAF90C2960
        public void .cctor(){} // RVA: 0x7FFAF90C2990
    }

    public class LeaveFinallyInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void get_InstructionName(){} // RVA: 0x7FFAF90C2550
        public void Run(){} // RVA: 0x7FFAF90C2590
        public void .cctor(){} // RVA: 0x7FFAF90C25D0
    }

    public class LeftShiftInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90D7AF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF90D7B30
    }

    public class LessThanInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90D8AB0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Create(){} // RVA: 0x7FFAF90D8AF0
    }

    public class LessThanOrEqualInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E92CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90DA7F0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Create(){} // RVA: 0x7FFAF90DA830
    }

    public class LightCompiler
    {
        public object DebugView;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90DD910 | overloaded x2
        public void get_Instructions(){} // RVA: 0x7FFAF2DA8380
        public void CompileTop(){} // RVA: 0x7FFAF90DD980
        public void MakeInterpreter(){} // RVA: 0x7FFAF90DDE90
        public void CompileConstantExpression(){} // RVA: 0x7FFAF90DE410
        public void CompileDefaultExpression(){} // RVA: 0x7FFAF90DE510 | overloaded x2
        public void EnsureAvailableForClosure(){} // RVA: 0x7FFAF90DE6D0
        public void ResolveLocal(){} // RVA: 0x7FFAF90DEA90
        public void CompileGetVariable(){} // RVA: 0x7FFAF90DEB00
        public void EmitCopyValueType(){} // RVA: 0x7FFAF90DEC00
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7FFAF90DECE0
        public void MaybeMutableValueType(){} // RVA: 0x7FFAF90DEE00
        public void CompileGetBoxedVariable(){} // RVA: 0x7FFAF90DEE80
        public void CompileSetVariable(){} // RVA: 0x7FFAF90DEF20
        public void CompileParameterExpression(){} // RVA: 0x7FFAF90DF140
        public void CompileBlockExpression(){} // RVA: 0x7FFAF90DF1D0
        public void CompileBlockStart(){} // RVA: 0x7FFAF90DF450
        public void CompileBlockEnd(){} // RVA: 0x7FFAF90DFA10
        public void CompileIndexExpression(){} // RVA: 0x7FFAF90DFAF0
        public void EmitIndexGet(){} // RVA: 0x7FFAF90DFC40
        public void CompileIndexAssignment(){} // RVA: 0x7FFAF90DFDF0
        public void CompileMemberAssignment(){} // RVA: 0x7FFAF90E0420 | overloaded x2
        public void CompileVariableAssignment(){} // RVA: 0x7FFAF90E0A00
        public void CompileAssignBinaryExpression(){} // RVA: 0x7FFAF90E0AC0
        public void CompileBinaryExpression(){} // RVA: 0x7FFAF90E0D50
        public void CompileEqual(){} // RVA: 0x7FFAF90E1F20
        public void CompileNotEqual(){} // RVA: 0x7FFAF90E1FC0
        public void CompileComparison(){} // RVA: 0x7FFAF90E2060
        public void CompileArithmetic(){} // RVA: 0x7FFAF90E2260
        public void CompileConvertUnaryExpression(){} // RVA: 0x7FFAF90E24F0
        public void CompileConvertToType(){} // RVA: 0x7FFAF90E2D90
        public void CompileNotExpression(){} // RVA: 0x7FFAF90E3570
        public void CompileUnaryExpression(){} // RVA: 0x7FFAF90E35E0
        public void EmitUnaryMethodCall(){} // RVA: 0x7FFAF90E3B10
        public void EmitUnaryBoolCheck(){} // RVA: 0x7FFAF90E3C20
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7FFAF90E3E50
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7FFAF90E3EE0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7FFAF90E3F70
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7FFAF90E41C0
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7FFAF90E4400
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7FFAF90E5280
        public void CompileConditionalExpression(){} // RVA: 0x7FFAF90E53C0
        public void CompileLoopExpression(){} // RVA: 0x7FFAF90E5690
        public void CompileSwitchExpression(){} // RVA: 0x7FFAF90E5B20
        public void CompileIntSwitchExpression(){} // RVA: 0x7FFAF2AD4B10
        public void CompileStringSwitchExpression(){} // RVA: 0x7FFAF90E6500
        public void CompileLabelExpression(){} // RVA: 0x7FFAF90E6DD0
        public void CompileGotoExpression(){} // RVA: 0x7FFAF90E7060
        public void PushLabelBlock(){} // RVA: 0x7FFAF90E73E0
        public void PopLabelBlock(){} // RVA: 0x7FFAF90E74E0
        public void EnsureLabel(){} // RVA: 0x7FFAF90E7550
        public void ReferenceLabel(){} // RVA: 0x7FFAF90E76B0
        public void DefineLabel(){} // RVA: 0x7FFAF90E7770
        public void TryPushLabelBlock(){} // RVA: 0x7FFAF90E7810
        public void DefineBlockLabels(){} // RVA: 0x7FFAF90E7BF0
        public void CheckRethrow(){} // RVA: 0x7FFAF90E7DE0
        public void CompileThrowUnaryExpression(){} // RVA: 0x7FFAF90E7E40
        public void CompileTryExpression(){} // RVA: 0x7FFAF90E8150
        public void CompileTryFaultExpression(){} // RVA: 0x7FFAF90E8FB0
        public void CompileMethodCallExpression(){} // RVA: 0x7FFAF90E9550 | overloaded x2
        public void CompileArrayIndexAddress(){} // RVA: 0x7FFAF90E9A90
        public void EmitThisForMethodCall(){} // RVA: 0x7FFAF90E9E30
        public void ShouldWritebackNode(){} // RVA: 0x7FFAF90E9E40
        public void CompileAddress(){} // RVA: 0x7FFAF90EA060
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7FFAF90EAFA0
        public void CompileNewExpression(){} // RVA: 0x7FFAF90EB780
        public void CompileMemberExpression(){} // RVA: 0x7FFAF90EBCE0
        public void CompileMember(){} // RVA: 0x7FFAF90EBDA0
        public void CompileNewArrayExpression(){} // RVA: 0x7FFAF90EC120
        public void CompileDebugInfoExpression(){} // RVA: 0x7FFAF90EC630
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7FFAF90EC840
        public void CompileLambdaExpression(){} // RVA: 0x7FFAF90ECB60
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7FFAF90ECF60
        public void CompileInvocationExpression(){} // RVA: 0x7FFAF90ED7C0
        public void CompileListInitExpression(){} // RVA: 0x7FFAF90EDAE0
        public void CompileListInit(){} // RVA: 0x7FFAF90EDB80
        public void CompileMemberInitExpression(){} // RVA: 0x7FFAF90EDF30
        public void CompileMemberInit(){} // RVA: 0x7FFAF90EDFD0
        public void GetMemberType(){} // RVA: 0x7FFAF90EE480
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7FFAF90EE5C0
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7FFAF90EEB40
        public void CompileTypeEqualExpression(){} // RVA: 0x7FFAF90EECA0
        public void CompileTypeAsExpression(){} // RVA: 0x7FFAF90EEEF0
        public void CompileTypeIsExpression(){} // RVA: 0x7FFAF90EEFD0
        public void Compile(){} // RVA: 0x7FFAF90EFEC0 | overloaded x2
        public void CompileAsVoid(){} // RVA: 0x7FFAF90EF300
        public void CompileNoLabelPush(){} // RVA: 0x7FFAF90EF490
        public void .cctor(){} // RVA: 0x7FFAF90EFF20
    }

    public class LightDelegateCreator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
        public void get_Interpreter(){} // RVA: 0x7FFAF2D907C0
        public void CreateDelegate(){} // RVA: 0x7FFAF90F1B40 | overloaded x2
    }

    public class LightLambda
    {
        // ── Methods ──
        public void Run0(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid0(){} // RVA: 0x7FFAF90F1D40
        public void MakeRun0(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid0(){} // RVA: 0x7FFAF90F1E00
        public void Run1(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid1(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun1(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid1(){} // RVA: 0x7FFAF2ABCE50
        public void Run2(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid2(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun2(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid2(){} // RVA: 0x7FFAF2ABCE50
        public void Run3(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid3(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun3(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid3(){} // RVA: 0x7FFAF2ABCE50
        public void Run4(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid4(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun4(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid4(){} // RVA: 0x7FFAF2ABCE50
        public void Run5(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid5(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun5(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid5(){} // RVA: 0x7FFAF2ABCE50
        public void Run6(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid6(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun6(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid6(){} // RVA: 0x7FFAF2ABCE50
        public void Run7(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid7(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun7(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid7(){} // RVA: 0x7FFAF2ABCE50
        public void Run8(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid8(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun8(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid8(){} // RVA: 0x7FFAF2ABCE50
        public void Run9(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid9(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun9(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid9(){} // RVA: 0x7FFAF2ABCE50
        public void Run10(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid10(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun10(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid10(){} // RVA: 0x7FFAF2ABCE50
        public void Run11(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid11(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun11(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid11(){} // RVA: 0x7FFAF2ABCE50
        public void Run12(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid12(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun12(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid12(){} // RVA: 0x7FFAF2ABCE50
        public void Run13(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid13(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun13(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid13(){} // RVA: 0x7FFAF2ABCE50
        public void Run14(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid14(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun14(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid14(){} // RVA: 0x7FFAF2ABCE50
        public void Run15(){} // RVA: 0x7FFAF2D33FA0
        public void RunVoid15(){} // RVA: 0x7FFAF2D33FA0
        public void MakeRun15(){} // RVA: 0x7FFAF2ABCE50
        public void MakeRunVoid15(){} // RVA: 0x7FFAF2ABCE50
        public void .ctor(){} // RVA: 0x7FFAF90F1E80
        public void get_DebugView(){} // RVA: 0x7FFAF90F1FB0
        public void GetRunDelegateCtor(){} // RVA: 0x7FFAF90F2030
        public void MakeRunDelegateCtor(){} // RVA: 0x7FFAF90F2330
        public void CreateCustomDelegate(){} // RVA: 0x7FFAF90F2F20
        public void MakeDelegate(){} // RVA: 0x7FFAF90F3710
        public void MakeFrame(){} // RVA: 0x7FFAF90F37A0
        public void RunVoidRef2(){} // RVA: 0x7FFAF2ADDC60
        public void Run(){} // RVA: 0x7FFAF90F3810
        public void RunVoid(){} // RVA: 0x7FFAF90F3BB0
        public void .cctor(){} // RVA: 0x7FFAF90F3DB0
    }

    public class LoadCachedObjectInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF9104610
        public void Run(){} // RVA: 0x7FFAF9104650
        public void ToDebugString(){} // RVA: 0x7FFAF91046F0
        public void ToString(){} // RVA: 0x7FFAF9104860
    }

    public class LoadFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_InstructionName(){} // RVA: 0x7FFAF90C8CA0
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void Run(){} // RVA: 0x7FFAF90C8CE0
    }

    public class LoadLocalBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90F5630
        public void Run(){} // RVA: 0x7FFAF90F5670
    }

    public class LoadLocalFromClosureBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90F58A0
        public void Run(){} // RVA: 0x7FFAF90F58E0
    }

    public class LoadLocalFromClosureInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90F5780
        public void Run(){} // RVA: 0x7FFAF90F57C0
    }

    public class LoadLocalInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90F54E0
        public void Run(){} // RVA: 0x7FFAF90F5520
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAF90F55C0
    }

    public class LoadObjectInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF91044B0
        public void Run(){} // RVA: 0x7FFAF91044F0
        public void ToString(){} // RVA: 0x7FFAF9104570
    }

    public class LoadStaticFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_InstructionName(){} // RVA: 0x7FFAF90C8BB0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void Run(){} // RVA: 0x7FFAF90C8BF0
    }

    public class LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void ToDebugString(){} // RVA: 0x7FFAF90F5340
    }

    public class LocalDefinition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6276C70
        public void get_Index(){} // RVA: 0x7FFAF44189B0
        public void get_Parameter(){} // RVA: 0x7FFAF44189C0
        public void Equals(){} // RVA: 0x7FFAF90F7010
        public void GetHashCode(){} // RVA: 0x7FFAF90F70B0
    }

    public class LocalVariable
    {
        public object Index;
        public object Parameter;

        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x7FFAF90F6E80
        public void set_IsBoxed(){} // RVA: 0x7FFAF90F6E90
        public void get_InClosure(){} // RVA: 0x7FFAF90F6EB0
        public void .ctor(){} // RVA: 0x7FFAF90F6EC0
        public void ToString(){} // RVA: 0x7FFAF90F6ED0
    }

    public class LocalVariables
    {
        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x7FFAF90F70F0
        public void UndefineLocal(){} // RVA: 0x7FFAF90F74B0
        public void Box(){} // RVA: 0x7FFAF90F7630
        public void get_LocalCount(){} // RVA: 0x7FFAF379F5B0
        public void TryGetLocalOrClosure(){} // RVA: 0x7FFAF90F77B0
        public void get_ClosureVariables(){} // RVA: 0x7FFAF2D907C0
        public void AddClosureVariable(){} // RVA: 0x7FFAF90F79C0
        public void .ctor(){} // RVA: 0x7FFAF90F7B40
    }

}