// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 24
// Methods: 285

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class LabelInfo : Object
    {
        public System.Linq.Expressions.LabelTarget HasDefinitions; // 0x10
        public System.Linq.Expressions.Interpreter.BranchLabel HasMultipleDefinitions; // 0x18
        public object _definitions; // 0x20
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.LabelScopeInfo> _references; // 0x28
        public bool _acrossBlockJump; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DBD140
        public void GetLabel(){} // RVA: 0x7FFAC8DBD260
        public void Reference(){} // RVA: 0x7FFAC8DBD2F0
        public void Define(){} // RVA: 0x7FFAC8DBD3A0
        public void ValidateJump(){} // RVA: 0x7FFAC8DBD740
        public void ValidateFinish(){} // RVA: 0x7FFAC8DBDB20
        public void EnsureLabel(){} // RVA: 0x7FFAC8DBDBB0
        public void DefinedIn(){} // RVA: 0x7FFAC8DBDC30
        public void get_HasDefinitions(){} // RVA: 0x7FFAC495C6A0
        public void FirstDefinition(){} // RVA: 0x7FFAC8DBDD00
        public void AddDefinition(){} // RVA: 0x7FFAC8DBDF30
        public void get_HasMultipleDefinitions(){} // RVA: 0x7FFAC8DBE150
        public void CommonNode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class LabelScopeInfo : Object
    {
        public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo> CanJumpInto; // 0x10
        public 0x6B1F1660 Kind; // 0x18
        public System.Linq.Expressions.Interpreter.LabelScopeInfo Parent; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DBE280
        public void get_CanJumpInto(){} // RVA: 0x7FFAC8DBE2E0
        public void ContainsTarget(){} // RVA: 0x7FFAC8DBE2F0
        public void TryGetLabelInfo(){} // RVA: 0x7FFAC8DBE3E0
        public void AddLabelInfo(){} // RVA: 0x7FFAC8DBE4B0
    }

    public class LeaveExceptionFilterInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA95B0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void Run(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC8DA95F0
    }

    public class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[] InstructionName;
        public bool ConsumedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DA80E0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA9800
        public void get_ConsumedStack(){} // RVA: 0x7FFAC8DA7AC0
        public void get_ProducedStack(){} // RVA: 0x7FFAC8DA7AC0
        public void Create(){} // RVA: 0x7FFAC8DA9840
        public void Run(){} // RVA: 0x7FFAC8DA99A0
        public void .cctor(){} // RVA: 0x7FFAC8DA99F0
    }

    public class LeaveFaultInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA93C0
        public void Run(){} // RVA: 0x7FFAC8DA9400
        public void .cctor(){} // RVA: 0x7FFAC8DA9430
    }

    public class LeaveFinallyInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA8FF0
        public void Run(){} // RVA: 0x7FFAC8DA9030
        public void .cctor(){} // RVA: 0x7FFAC8DA9070
    }

    public class LeftShiftInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x38

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DBE5B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DBE5F0
    }

    public class LessThanInstruction : Instruction
    {
        public object ConsumedStack; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack;
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble; // 0xA8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DBF570
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Create(){} // RVA: 0x7FFAC8DBF5B0
    }

    public class LessThanOrEqualInstruction : Instruction
    {
        public object ConsumedStack; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack;
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble; // 0xA8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DC12B0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Create(){} // RVA: 0x7FFAC8DC12F0
    }

    public class LightCompiler : Object
    {
        public System.Linq.Expressions.Interpreter.InstructionList Instructions; // 0x10
        public System.Linq.Expressions.Interpreter.LocalVariables _locals; // 0x18
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.DebugInfo> _debugInfos; // 0x20
        public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo> _treeLabels; // 0x28
        public System.Linq.Expressions.Interpreter.LabelScopeInfo _labelBlock; // 0x30
        public System.Collections.Generic.Stack`1<System.Linq.Expressions.ParameterExpression> _exceptionForRethrowStack; // 0x38
        public System.Linq.Expressions.Interpreter.LightCompiler _parent; // 0x40
        public System.Linq.Expressions.StackGuard _guard; // 0x48
        public System.Linq.Expressions.Interpreter.LocalDefinition[] s_emptyLocals;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DC43D0 | overloaded x2
        public void get_Instructions(){} // RVA: 0x7FFAC2F3C380
        public void CompileTop(){} // RVA: 0x7FFAC8DC4440
        public void MakeInterpreter(){} // RVA: 0x7FFAC8DC4950
        public void CompileConstantExpression(){} // RVA: 0x7FFAC8DC4ED0
        public void CompileDefaultExpression(){} // RVA: 0x7FFAC8DC4FD0 | overloaded x2
        public void EnsureAvailableForClosure(){} // RVA: 0x7FFAC8DC5190
        public void ResolveLocal(){} // RVA: 0x7FFAC8DC5550
        public void CompileGetVariable(){} // RVA: 0x7FFAC8DC55C0
        public void EmitCopyValueType(){} // RVA: 0x7FFAC8DC56C0
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7FFAC8DC57A0
        public void MaybeMutableValueType(){} // RVA: 0x7FFAC8DC58C0
        public void CompileGetBoxedVariable(){} // RVA: 0x7FFAC8DC5940
        public void CompileSetVariable(){} // RVA: 0x7FFAC8DC59E0
        public void CompileParameterExpression(){} // RVA: 0x7FFAC8DC5C00
        public void CompileBlockExpression(){} // RVA: 0x7FFAC8DC5C90
        public void CompileBlockStart(){} // RVA: 0x7FFAC8DC5F10
        public void CompileBlockEnd(){} // RVA: 0x7FFAC8DC64D0
        public void CompileIndexExpression(){} // RVA: 0x7FFAC8DC65B0
        public void EmitIndexGet(){} // RVA: 0x7FFAC8DC6700
        public void CompileIndexAssignment(){} // RVA: 0x7FFAC8DC68B0
        public void CompileMemberAssignment(){} // RVA: 0x7FFAC8DC6EE0 | overloaded x2
        public void CompileVariableAssignment(){} // RVA: 0x7FFAC8DC74C0
        public void CompileAssignBinaryExpression(){} // RVA: 0x7FFAC8DC7580
        public void CompileBinaryExpression(){} // RVA: 0x7FFAC8DC7810
        public void CompileEqual(){} // RVA: 0x7FFAC8DC89E0
        public void CompileNotEqual(){} // RVA: 0x7FFAC8DC8A80
        public void CompileComparison(){} // RVA: 0x7FFAC8DC8B20
        public void CompileArithmetic(){} // RVA: 0x7FFAC8DC8D20
        public void CompileConvertUnaryExpression(){} // RVA: 0x7FFAC8DC8FB0
        public void CompileConvertToType(){} // RVA: 0x7FFAC8DC9850
        public void CompileNotExpression(){} // RVA: 0x7FFAC8DCA030
        public void CompileUnaryExpression(){} // RVA: 0x7FFAC8DCA0A0
        public void EmitUnaryMethodCall(){} // RVA: 0x7FFAC8DCA5D0
        public void EmitUnaryBoolCheck(){} // RVA: 0x7FFAC8DCA6E0
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7FFAC8DCA910
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7FFAC8DCA9A0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7FFAC8DCAA30
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7FFAC8DCAC80
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7FFAC8DCAEC0
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7FFAC8DCBD40
        public void CompileConditionalExpression(){} // RVA: 0x7FFAC8DCBE80
        public void CompileLoopExpression(){} // RVA: 0x7FFAC8DCC150
        public void CompileSwitchExpression(){} // RVA: 0x7FFAC8DCC5E0
        public void CompileIntSwitchExpression(){} // RVA: 0x7FFAC2C70A40
        public void CompileStringSwitchExpression(){} // RVA: 0x7FFAC8DCCFC0
        public void CompileLabelExpression(){} // RVA: 0x7FFAC8DCD890
        public void CompileGotoExpression(){} // RVA: 0x7FFAC8DCDB20
        public void PushLabelBlock(){} // RVA: 0x7FFAC8DCDEA0
        public void PopLabelBlock(){} // RVA: 0x7FFAC8DCDFA0
        public void EnsureLabel(){} // RVA: 0x7FFAC8DCE010
        public void ReferenceLabel(){} // RVA: 0x7FFAC8DCE170
        public void DefineLabel(){} // RVA: 0x7FFAC8DCE230
        public void TryPushLabelBlock(){} // RVA: 0x7FFAC8DCE2D0
        public void DefineBlockLabels(){} // RVA: 0x7FFAC8DCE6B0
        public void CheckRethrow(){} // RVA: 0x7FFAC8DCE8A0
        public void CompileThrowUnaryExpression(){} // RVA: 0x7FFAC8DCE900
        public void CompileTryExpression(){} // RVA: 0x7FFAC8DCEC10
        public void CompileTryFaultExpression(){} // RVA: 0x7FFAC8DCFA70
        public void CompileMethodCallExpression(){} // RVA: 0x7FFAC8DD0010 | overloaded x2
        public void CompileArrayIndexAddress(){} // RVA: 0x7FFAC8DD0550
        public void EmitThisForMethodCall(){} // RVA: 0x7FFAC8DD08F0
        public void ShouldWritebackNode(){} // RVA: 0x7FFAC8DD0900
        public void CompileAddress(){} // RVA: 0x7FFAC8DD0B20
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7FFAC8DD1A60
        public void CompileNewExpression(){} // RVA: 0x7FFAC8DD2240
        public void CompileMemberExpression(){} // RVA: 0x7FFAC8DD27A0
        public void CompileMember(){} // RVA: 0x7FFAC8DD2860
        public void CompileNewArrayExpression(){} // RVA: 0x7FFAC8DD2BE0
        public void CompileDebugInfoExpression(){} // RVA: 0x7FFAC8DD30F0
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7FFAC8DD3300
        public void CompileLambdaExpression(){} // RVA: 0x7FFAC8DD3620
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7FFAC8DD3A20
        public void CompileInvocationExpression(){} // RVA: 0x7FFAC8DD4280
        public void CompileListInitExpression(){} // RVA: 0x7FFAC8DD45A0
        public void CompileListInit(){} // RVA: 0x7FFAC8DD4640
        public void CompileMemberInitExpression(){} // RVA: 0x7FFAC8DD49F0
        public void CompileMemberInit(){} // RVA: 0x7FFAC8DD4A90
        public void GetMemberType(){} // RVA: 0x7FFAC8DD4F40
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7FFAC8DD5080
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7FFAC8DD5600
        public void CompileTypeEqualExpression(){} // RVA: 0x7FFAC8DD5760
        public void CompileTypeAsExpression(){} // RVA: 0x7FFAC8DD59B0
        public void CompileTypeIsExpression(){} // RVA: 0x7FFAC8DD5A90
        public void Compile(){} // RVA: 0x7FFAC8DD6980 | overloaded x2
        public void CompileAsVoid(){} // RVA: 0x7FFAC8DD5DC0
        public void CompileNoLabelPush(){} // RVA: 0x7FFAC8DD5F50
        public void .cctor(){} // RVA: 0x7FFAC8DD69E0
    }

    public class LightDelegateCreator : Object
    {
        public System.Linq.Expressions.LambdaExpression Interpreter; // 0x10
        public System.Linq.Expressions.Interpreter.Interpreter <Interpreter>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
        public void get_Interpreter(){} // RVA: 0x7FFAC2F247C0
        public void CreateDelegate(){} // RVA: 0x7FFAC8DD8600 | overloaded x2
    }

    public class LightLambda : Object
    {
        public int DebugView;
        public System.Runtime.CompilerServices.IStrongBox[] _closure; // 0x10
        public System.Linq.Expressions.Interpreter.Interpreter _interpreter; // 0x18
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`2<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate>> _runCache;
        public System.Linq.Expressions.Interpreter.LightDelegateCreator _delegateCreator; // 0x20

        // ── Methods ──
        public void Run0(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid0(){} // RVA: 0x7FFAC8DD8800
        public void MakeRun0(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid0(){} // RVA: 0x7FFAC8DD88C0
        public void Run1(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid1(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun1(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid1(){} // RVA: 0x7FFAC2C58F80
        public void Run2(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid2(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun2(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid2(){} // RVA: 0x7FFAC2C58F80
        public void Run3(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid3(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun3(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid3(){} // RVA: 0x7FFAC2C58F80
        public void Run4(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid4(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun4(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid4(){} // RVA: 0x7FFAC2C58F80
        public void Run5(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid5(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun5(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid5(){} // RVA: 0x7FFAC2C58F80
        public void Run6(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid6(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun6(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid6(){} // RVA: 0x7FFAC2C58F80
        public void Run7(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid7(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun7(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid7(){} // RVA: 0x7FFAC2C58F80
        public void Run8(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid8(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun8(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid8(){} // RVA: 0x7FFAC2C58F80
        public void Run9(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid9(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun9(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid9(){} // RVA: 0x7FFAC2C58F80
        public void Run10(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid10(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun10(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid10(){} // RVA: 0x7FFAC2C58F80
        public void Run11(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid11(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun11(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid11(){} // RVA: 0x7FFAC2C58F80
        public void Run12(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid12(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun12(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid12(){} // RVA: 0x7FFAC2C58F80
        public void Run13(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid13(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun13(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid13(){} // RVA: 0x7FFAC2C58F80
        public void Run14(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid14(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun14(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid14(){} // RVA: 0x7FFAC2C58F80
        public void Run15(){} // RVA: 0x7FFAC2E8DC40
        public void RunVoid15(){} // RVA: 0x7FFAC2E8DC40
        public void MakeRun15(){} // RVA: 0x7FFAC2C58F80
        public void MakeRunVoid15(){} // RVA: 0x7FFAC2C58F80
        public void .ctor(){} // RVA: 0x7FFAC8DD8940
        public void get_DebugView(){} // RVA: 0x7FFAC8DD8A70
        public void GetRunDelegateCtor(){} // RVA: 0x7FFAC8DD8AF0
        public void MakeRunDelegateCtor(){} // RVA: 0x7FFAC8DD8DF0
        public void CreateCustomDelegate(){} // RVA: 0x7FFAC8DD99E0
        public void MakeDelegate(){} // RVA: 0x7FFAC8DDA1D0
        public void MakeFrame(){} // RVA: 0x7FFAC8DDA260
        public void RunVoidRef2(){} // RVA: 0x7FFAC2C79B30
        public void Run(){} // RVA: 0x7FFAC8DDA2D0
        public void RunVoid(){} // RVA: 0x7FFAC8DDA670
        public void .cctor(){} // RVA: 0x7FFAC8DDA870
    }

    public class LoadCachedObjectInstruction : Instruction
    {
        public uint ProducedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEB0D0
        public void Run(){} // RVA: 0x7FFAC8DEB110
        public void ToDebugString(){} // RVA: 0x7FFAC8DEB1B0
        public void ToString(){} // RVA: 0x7FFAC8DEB320
    }

    public class LoadFieldInstruction : FieldInstruction
    {
        public object InstructionName;
        public object ConsumedStack;
        public object ProducedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAF740
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DAF780
    }

    public class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC0F0
        public void Run(){} // RVA: 0x7FFAC8DDC130
    }

    public class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC360
        public void Run(){} // RVA: 0x7FFAC8DDC3A0
    }

    public class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC240
        public void Run(){} // RVA: 0x7FFAC8DDC280
    }

    public class LoadLocalInstruction : LocalAccessInstruction
    {
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDBFA0
        public void Run(){} // RVA: 0x7FFAC8DDBFE0
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAC8DDC080
    }

    public class LoadObjectInstruction : Instruction
    {
        public object ProducedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEAF70
        public void Run(){} // RVA: 0x7FFAC8DEAFB0
        public void ToString(){} // RVA: 0x7FFAC8DEB030
    }

    public class LoadStaticFieldInstruction : FieldInstruction
    {
        public object InstructionName;
        public object ProducedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAF650
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DAF690
    }

    public class LocalAccessInstruction : Instruction
    {
        public int _index; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void ToDebugString(){} // RVA: 0x7FFAC8DDBE00
    }

    public class LocalDefinition : ValueType
    {
        public int Index; // 0x10
        public System.Linq.Expressions.ParameterExpression Parameter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F24C0
        public void get_Index(){} // RVA: 0x7FFAC4420210
        public void get_Parameter(){} // RVA: 0x7FFAC4420220
        public void Equals(){} // RVA: 0x7FFAC8DDDAD0
        public void GetHashCode(){} // RVA: 0x7FFAC8DDDB70
    }

    public class LocalVariable : Object
    {
        public int IsBoxed;
        public int InClosure;
        public int Index; // 0x10
        public int _flags; // 0x14

        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x7FFAC8DDD940
        public void set_IsBoxed(){} // RVA: 0x7FFAC8DDD950
        public void get_InClosure(){} // RVA: 0x7FFAC8DDD970
        public void .ctor(){} // RVA: 0x7FFAC8DDD980
        public void ToString(){} // RVA: 0x7FFAC8DDD990
    }

    public class LocalVariables : Object
    {
        public System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2<System.Linq.Expressions.ParameterExpression,VariableScope> LocalCount; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> ClosureVariables; // 0x18
        public int _localCount; // 0x20
        public int _maxLocalCount; // 0x24

        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x7FFAC8DDDBB0
        public void UndefineLocal(){} // RVA: 0x7FFAC8DDDF70
        public void Box(){} // RVA: 0x7FFAC8DDE0F0
        public void get_LocalCount(){} // RVA: 0x7FFAC3921980
        public void TryGetLocalOrClosure(){} // RVA: 0x7FFAC8DDE270
        public void get_ClosureVariables(){} // RVA: 0x7FFAC2F247C0
        public void AddClosureVariable(){} // RVA: 0x7FFAC8DDE480
        public void .ctor(){} // RVA: 0x7FFAC8DDE600
    }

}