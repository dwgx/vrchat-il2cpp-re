// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 24
// Methods: 279

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class LabelInfo : Object
    {
        public object _node;
        public object _label;
        public object _definitions;
        public object _references;
        public object _acrossBlockJump;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7093430
        public void GetLabel(){} // RVA: 0x7093550
        public void Reference(){} // RVA: 0x70935E0
        public void Define(){} // RVA: 0x7093690
        public void ValidateJump(){} // RVA: 0x7093A30
        public void ValidateFinish(){} // RVA: 0x7093E10
        public void EnsureLabel(){} // RVA: 0x7093EA0
        public void DefinedIn(){} // RVA: 0x7093F20
        public void get_HasDefinitions(){} // RVA: 0x26C1120
        public void FirstDefinition(){} // RVA: 0x7093FD0
        public void AddDefinition(){} // RVA: 0x7094210
        public void get_HasMultipleDefinitions(){} // RVA: 0x7094430
        public void CommonNode(){} // RVA: 0xA94080
    }

    public class LabelScopeInfo : Object
    {
        public object _labels;
        public object Kind;
        public object Parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7094550
        public void get_CanJumpInto(){} // RVA: 0x70945B0
        public void ContainsTarget(){} // RVA: 0x70945C0
        public void TryGetLabelInfo(){} // RVA: 0x70946B0
        public void AddLabelInfo(){} // RVA: 0x7094780
    }

    public class LeaveExceptionFilterInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_InstructionName(){} // RVA: 0x7080390
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void Run(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x70803D0
    }

    public class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        public object s_cache;
        public object _hasValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x707EF70
        public void get_InstructionName(){} // RVA: 0x70805E0
        public void get_ConsumedStack(){} // RVA: 0x707E950
        public void get_ProducedStack(){} // RVA: 0x707E950
        public void Create(){} // RVA: 0x7080620
        public void Run(){} // RVA: 0x7080780
        public void .cctor(){} // RVA: 0x70807D0
    }

    public class LeaveFaultInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ConsumedContinuations(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70801A0
        public void Run(){} // RVA: 0x70801E0
        public void .cctor(){} // RVA: 0x7080210
    }

    public class LeaveFinallyInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_InstructionName(){} // RVA: 0x707FDD0
        public void Run(){} // RVA: 0x707FE10
        public void .cctor(){} // RVA: 0x707FE50
    }

    public class LeftShiftInstruction : Instruction
    {
        public object s_SByte;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7094880
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70948C0
    }

    public class LessThanInstruction : Instruction
    {
        public object _nullValue;
        public object s_SByte;
        public object s_Int16;
        public object s_Char;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;
        public object s_liftedToNullSByte;
        public object s_liftedToNullInt16;
        public object s_liftedToNullChar;
        public object s_liftedToNullInt32;
        public object s_liftedToNullInt64;
        public object s_liftedToNullByte;
        public object s_liftedToNullUInt16;
        public object s_liftedToNullUInt32;
        public object s_liftedToNullUInt64;
        public object s_liftedToNullSingle;
        public object s_liftedToNullDouble;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7095710
        public void .ctor(){} // RVA: 0xB44D60
        public void Create(){} // RVA: 0x7095750
    }

    public class LessThanOrEqualInstruction : Instruction
    {
        public object _nullValue;
        public object s_SByte;
        public object s_Int16;
        public object s_Char;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;
        public object s_liftedToNullSByte;
        public object s_liftedToNullInt16;
        public object s_liftedToNullChar;
        public object s_liftedToNullInt32;
        public object s_liftedToNullInt64;
        public object s_liftedToNullByte;
        public object s_liftedToNullUInt16;
        public object s_liftedToNullUInt32;
        public object s_liftedToNullUInt64;
        public object s_liftedToNullSingle;
        public object s_liftedToNullDouble;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7097310
        public void .ctor(){} // RVA: 0xB44D60
        public void Create(){} // RVA: 0x7097350
    }

    public class LightCompiler : Object
    {
        public object _instructions;
        public object _locals;
        public object _debugInfos;
        public object _treeLabels;
        public object _labelBlock;
        public object _exceptionForRethrowStack;
        public object _parent;
        public object _guard;
        public object s_emptyLocals;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x709A2B0
        public void get_Instructions(){} // RVA: 0xB5DBF0
        public void CompileTop(){} // RVA: 0x709A320
        public void MakeInterpreter(){} // RVA: 0x709A7E0
        public void CompileConstantExpression(){} // RVA: 0x709AD70
        public void CompileDefaultExpression(){} // RVA: 0x709AE70
        public void EnsureAvailableForClosure(){} // RVA: 0x709AFF0
        public void ResolveLocal(){} // RVA: 0x709B3A0
        public void CompileGetVariable(){} // RVA: 0x709B410
        public void EmitCopyValueType(){} // RVA: 0x709B510
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x709B5F0
        public void MaybeMutableValueType(){} // RVA: 0x709B710
        public void CompileGetBoxedVariable(){} // RVA: 0x709B790
        public void CompileSetVariable(){} // RVA: 0x709B830
        public void CompileParameterExpression(){} // RVA: 0x709BA50
        public void CompileBlockExpression(){} // RVA: 0x709BAE0
        public void CompileBlockStart(){} // RVA: 0x709BD60
        public void CompileBlockEnd(){} // RVA: 0x709C310
        public void CompileIndexExpression(){} // RVA: 0x709C3E0
        public void EmitIndexGet(){} // RVA: 0x709C530
        public void CompileIndexAssignment(){} // RVA: 0x709C6E0
        public void CompileMemberAssignment(){} // RVA: 0x709CD10
        public void CompileVariableAssignment(){} // RVA: 0x709D2E0
        public void CompileAssignBinaryExpression(){} // RVA: 0x709D3A0
        public void CompileBinaryExpression(){} // RVA: 0x709D630
        public void CompileEqual(){} // RVA: 0x709E7F0
        public void CompileNotEqual(){} // RVA: 0x709E890
        public void CompileComparison(){} // RVA: 0x709E930
        public void CompileArithmetic(){} // RVA: 0x709EB30
        public void CompileConvertUnaryExpression(){} // RVA: 0x709EDC0
        public void CompileConvertToType(){} // RVA: 0x709F650
        public void CompileNotExpression(){} // RVA: 0x709FE30
        public void CompileUnaryExpression(){} // RVA: 0x709FEA0
        public void EmitUnaryMethodCall(){} // RVA: 0x70A03D0
        public void EmitUnaryBoolCheck(){} // RVA: 0x70A04E0
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x70A0730
        public void CompileOrElseBinaryExpression(){} // RVA: 0x70A07C0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x70A0850
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x70A0AA0
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x70A0CE0
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x70A1A00
        public void CompileConditionalExpression(){} // RVA: 0x70A1B30
        public void CompileLoopExpression(){} // RVA: 0x70A1DF0
        public void CompileSwitchExpression(){} // RVA: 0x70A2240
        public void CompileIntSwitchExpression(){} // RVA: 0x894320
        public void CompileStringSwitchExpression(){} // RVA: 0x70A2C10
        public void CompileLabelExpression(){} // RVA: 0x70A3490
        public void CompileGotoExpression(){} // RVA: 0x70A3730
        public void PushLabelBlock(){} // RVA: 0x70A3A70
        public void PopLabelBlock(){} // RVA: 0x70A3B70
        public void EnsureLabel(){} // RVA: 0x70A3BE0
        public void ReferenceLabel(){} // RVA: 0x70A3D40
        public void DefineLabel(){} // RVA: 0x70A3E00
        public void TryPushLabelBlock(){} // RVA: 0x70A3EA0
        public void DefineBlockLabels(){} // RVA: 0x70A4260
        public void CheckRethrow(){} // RVA: 0x70A4450
        public void CompileThrowUnaryExpression(){} // RVA: 0x70A44B0
        public void CompileTryExpression(){} // RVA: 0x70A47C0
        public void CompileTryFaultExpression(){} // RVA: 0x70A5650
        public void CompileMethodCallExpression(){} // RVA: 0x70A5BB0
        public void CompileArrayIndexAddress(){} // RVA: 0x70A6110
        public void EmitThisForMethodCall(){} // RVA: 0x70A64C0
        public void ShouldWritebackNode(){} // RVA: 0x70A64D0
        public void CompileAddress(){} // RVA: 0x70A66D0
        public void CompileMultiDimArrayAccess(){} // RVA: 0x70A7670
        public void CompileNewExpression(){} // RVA: 0x70A7E70
        public void CompileMemberExpression(){} // RVA: 0x70A83D0
        public void CompileMember(){} // RVA: 0x70A8490
        public void CompileNewArrayExpression(){} // RVA: 0x70A8810
        public void CompileDebugInfoExpression(){} // RVA: 0x70A8D40
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x70A8F50
        public void CompileLambdaExpression(){} // RVA: 0x70A9260
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x70A9670
        public void CompileInvocationExpression(){} // RVA: 0x70A9E90
        public void CompileListInitExpression(){} // RVA: 0x70AA170
        public void CompileListInit(){} // RVA: 0x70AA210
        public void CompileMemberInitExpression(){} // RVA: 0x70AA590
        public void CompileMemberInit(){} // RVA: 0x70AA630
        public void GetMemberType(){} // RVA: 0x70AAAE0
        public void CompileQuoteUnaryExpression(){} // RVA: 0x70AAC00
        public void CompileUnboxUnaryExpression(){} // RVA: 0x70AB190
        public void CompileTypeEqualExpression(){} // RVA: 0x70AB2F0
        public void CompileTypeAsExpression(){} // RVA: 0x70AB530
        public void CompileTypeIsExpression(){} // RVA: 0x70AB610
        public void Compile(){} // RVA: 0x70AC4C0
        public void CompileAsVoid(){} // RVA: 0x70AB950
        public void CompileNoLabelPush(){} // RVA: 0x70ABAB0
        public void .cctor(){} // RVA: 0x70AC520
    }

    public class LightDelegateCreator : Object
    {
        public object _lambda;
        public object _interpreter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
        public void get_Interpreter(){} // RVA: 0xB465B0
        public void CreateDelegate(){} // RVA: 0x70AE0E0
    }

    public class LightLambda : Object
    {
        public object MaxParameters;
        public object _closure;
        public object _interpreter;
        public object _runCache;
        public object _delegateCreator;

        // ── Methods ──
        public void Run0(){} // RVA: 0xA94080
        public void RunVoid0(){} // RVA: 0x70AE2E0
        public void MakeRun0(){} // RVA: 0x87C5C0
        public void MakeRunVoid0(){} // RVA: 0x70AE3B0
        public void Run1(){} // RVA: 0xA94080
        public void RunVoid1(){} // RVA: 0xA94080
        public void MakeRun1(){} // RVA: 0x87C5C0
        public void MakeRunVoid1(){} // RVA: 0x87C5C0
        public void Run2(){} // RVA: 0xA94080
        public void RunVoid2(){} // RVA: 0xA94080
        public void MakeRun2(){} // RVA: 0x87C5C0
        public void MakeRunVoid2(){} // RVA: 0x87C5C0
        public void Run3(){} // RVA: 0xA94080
        public void RunVoid3(){} // RVA: 0xA94080
        public void MakeRun3(){} // RVA: 0x87C5C0
        public void MakeRunVoid3(){} // RVA: 0x87C5C0
        public void Run4(){} // RVA: 0xA94080
        public void RunVoid4(){} // RVA: 0xA94080
        public void MakeRun4(){} // RVA: 0x87C5C0
        public void MakeRunVoid4(){} // RVA: 0x87C5C0
        public void Run5(){} // RVA: 0xA94080
        public void RunVoid5(){} // RVA: 0xA94080
        public void MakeRun5(){} // RVA: 0x87C5C0
        public void MakeRunVoid5(){} // RVA: 0x87C5C0
        public void Run6(){} // RVA: 0xA94080
        public void RunVoid6(){} // RVA: 0xA94080
        public void MakeRun6(){} // RVA: 0x87C5C0
        public void MakeRunVoid6(){} // RVA: 0x87C5C0
        public void Run7(){} // RVA: 0xA94080
        public void RunVoid7(){} // RVA: 0xA94080
        public void MakeRun7(){} // RVA: 0x87C5C0
        public void MakeRunVoid7(){} // RVA: 0x87C5C0
        public void Run8(){} // RVA: 0xA94080
        public void RunVoid8(){} // RVA: 0xA94080
        public void MakeRun8(){} // RVA: 0x87C5C0
        public void MakeRunVoid8(){} // RVA: 0x87C5C0
        public void Run9(){} // RVA: 0xA94080
        public void RunVoid9(){} // RVA: 0xA94080
        public void MakeRun9(){} // RVA: 0x87C5C0
        public void MakeRunVoid9(){} // RVA: 0x87C5C0
        public void Run10(){} // RVA: 0xA94080
        public void RunVoid10(){} // RVA: 0xA94080
        public void MakeRun10(){} // RVA: 0x87C5C0
        public void MakeRunVoid10(){} // RVA: 0x87C5C0
        public void Run11(){} // RVA: 0xA94080
        public void RunVoid11(){} // RVA: 0xA94080
        public void MakeRun11(){} // RVA: 0x87C5C0
        public void MakeRunVoid11(){} // RVA: 0x87C5C0
        public void Run12(){} // RVA: 0xA94080
        public void RunVoid12(){} // RVA: 0xA94080
        public void MakeRun12(){} // RVA: 0x87C5C0
        public void MakeRunVoid12(){} // RVA: 0x87C5C0
        public void Run13(){} // RVA: 0xA94080
        public void RunVoid13(){} // RVA: 0xA94080
        public void MakeRun13(){} // RVA: 0x87C5C0
        public void MakeRunVoid13(){} // RVA: 0x87C5C0
        public void Run14(){} // RVA: 0xA94080
        public void RunVoid14(){} // RVA: 0xA94080
        public void MakeRun14(){} // RVA: 0x87C5C0
        public void MakeRunVoid14(){} // RVA: 0x87C5C0
        public void Run15(){} // RVA: 0xA94080
        public void RunVoid15(){} // RVA: 0xA94080
        public void MakeRun15(){} // RVA: 0x87C5C0
        public void MakeRunVoid15(){} // RVA: 0x87C5C0
        public void .ctor(){} // RVA: 0x70AE430
        public void get_DebugView(){} // RVA: 0x70AE560
        public void GetRunDelegateCtor(){} // RVA: 0x70AE5E0
        public void MakeRunDelegateCtor(){} // RVA: 0x70AE8A0
        public void CreateCustomDelegate(){} // RVA: 0x70AF510
        public void MakeDelegate(){} // RVA: 0x70AFCE0
        public void MakeFrame(){} // RVA: 0x70AFD70
        public void RunVoidRef2(){} // RVA: 0x8943B0
        public void Run(){} // RVA: 0x70AFDE0
        public void RunVoid(){} // RVA: 0x70B0180
        public void .cctor(){} // RVA: 0x70B0370
    }

    public class LoadCachedObjectInstruction : Instruction
    {
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BFB50
        public void Run(){} // RVA: 0x70BFB90
        public void ToDebugString(){} // RVA: 0x70BFC30
        public void ToString(){} // RVA: 0x70BFD90
    }

    public class LoadFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InstructionName(){} // RVA: 0x7085F90
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x7085FD0
    }

    public class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B1C20
        public void Run(){} // RVA: 0x70B1C60
    }

    public class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B1E90
        public void Run(){} // RVA: 0x70B1ED0
    }

    public class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B1D70
        public void Run(){} // RVA: 0x70B1DB0
    }

    public class LoadLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B1AD0
        public void Run(){} // RVA: 0x70B1B10
        public void BoxIfIndexMatches(){} // RVA: 0x70B1BB0
    }

    public class LoadObjectInstruction : Instruction
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BF9F0
        public void Run(){} // RVA: 0x70BFA30
        public void ToString(){} // RVA: 0x70BFAB0
    }

    public class LoadStaticFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InstructionName(){} // RVA: 0x7085EA0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x7085EE0
    }

    public class LocalAccessInstruction : Instruction
    {
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void ToDebugString(){} // RVA: 0x70B1930
    }

    public class LocalDefinition : ValueType
    {
        public object _index;
        public object _parameter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3616C0
        public void get_Index(){} // RVA: 0x77E60
        public void get_Parameter(){} // RVA: 0x77ED0
        public void Equals(){} // RVA: 0x8FECA0
        public void GetHashCode(){} // RVA: 0x8FECB0
    }

    public class LocalVariable : Object
    {
        public object IsBoxedFlag;
        public object InClosureFlag;
        public object Index;
        public object _flags;

        // ── Methods ──
        public void get_IsBoxed(){} // RVA: 0x70B3470
        public void set_IsBoxed(){} // RVA: 0x70B3480
        public void get_InClosure(){} // RVA: 0x70B34A0
        public void .ctor(){} // RVA: 0x70B34B0
        public void ToString(){} // RVA: 0x70B34C0
    }

    public class LocalVariables : Object
    {
        public object _variables;
        public object _closureVariables;
        public object _localCount;
        public object _maxLocalCount;

        // ── Methods ──
        public void DefineLocal(){} // RVA: 0x70B36D0
        public void UndefineLocal(){} // RVA: 0x70B3AA0
        public void Box(){} // RVA: 0x70B3C20
        public void get_LocalCount(){} // RVA: 0x15AF000
        public void TryGetLocalOrClosure(){} // RVA: 0x70B3DA0
        public void get_ClosureVariables(){} // RVA: 0xB465B0
        public void AddClosureVariable(){} // RVA: 0x70B3FA0
        public void .ctor(){} // RVA: 0x70B4120
    }

}