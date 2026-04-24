// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 331

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CastInstruction : Instruction
    {
        public object s_Char; // 0x30DEDEE0
        public object s_Double; // 0x30DEDEE0
        public object s_Int64; // 0x30DEDEE0
        public object s_String; // 0x30DEDEE0
        public object s_UInt64; // 0x30DEDEE0
        public object ConsumedStack; // 0x17000380
        public object ProducedStack; // 0x17000381
        public object InstructionName; // 0x17000382
        public object  ; // 0x30DEDCE0

        // ── Original Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7ffaa8a24af0
        public void get_ProducedStack(){} // RVA: 0x7ffaa8a24af0
        public void get_InstructionName(){} // RVA: 0x7ffaae810970
        public void Create(){} // RVA: 0x7ffaae8109b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class HybridReferenceDictionary`2 : Object
    {
        public object ArraySize; // 0x30C7A680
        public object Item; // 0x17000385

        // ── Original Methods ──
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void ContainsKey(){} // RVA: 0x7ffaa887e5c0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void GetEnumeratorWorker(){} // RVA: 0x7ffaa86491d0
    }

    public class Instruction : Object
    {
        // ── Original Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7ffaa8f22da0
        public void get_ProducedStack(){} // RVA: 0x7ffaa8f22da0
        public void get_ConsumedContinuations(){} // RVA: 0x7ffaa8f22da0
        public void get_ProducedContinuations(){} // RVA: 0x7ffaa8f22da0
        public void get_StackBalance(){} // RVA: 0x7ffaae7d61c0
        public void get_ContinuationsBalance(){} // RVA: 0x7ffaae7d6210
        public void Run(){} // RVA: 0x7ffaa864e9f0
        public void get_InstructionName(){} // RVA: 0x7ffaa86491d0
        public void ToString(){} // RVA: 0x7ffaae7d6260
        public void ToDebugString(){} // RVA: 0x7ffaadfb0aa0
        public void NullCheck(){} // RVA: 0x7ffaad1a3ff0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDebugCookie(){} // RVA: 0x7ffaa8f22da0
    }

    public class InstructionList : Object
    {
        public object _currentStackDepth; // 0x317E0900
        public object _maxContinuationDepth; // 0x317E0900
        public object _debugCookies; // 0x317E0900
        public object CachedObjectCount; // 0x317E0900
        public object s_false; // 0x317E0900
        public object LocalInstrCacheSize; // 0x317E0900
        public object s_loadLocalFromClosure; // 0x317E0900
        public object s_storeLocal; // 0x317E0900
        public object s_assignLocalToClosure; // 0x317E0900

        // ── Original Methods ──
        public void Emit(){} // RVA: 0x7ffaae7d6660
        public void UpdateStackDepth(){} // RVA: 0x7ffaae7d6790
        public void UnEmit(){} // RVA: 0x7ffaae7d6850
        public void get_Count(){} // RVA: 0x7ffaae7d69b0
        public void get_CurrentStackDepth(){} // RVA: 0x7ffaa8aeced0
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7ffaa8d14570
        public void get_MaxStackDepth(){} // RVA: 0x7ffaa9349010
        public void ToArray(){} // RVA: 0x7ffaae7d6a80
        public void EmitLoad(){} // RVA: 0x7ffaae7d6e30
        public void EmitLoad(){} // RVA: 0x7ffaae7d6e30
        public void EmitLoad(){} // RVA: 0x7ffaae7d6e30
        public void EmitDup(){} // RVA: 0x7ffaae7d7470
        public void EmitPop(){} // RVA: 0x7ffaae7d74e0
        public void SwitchToBoxed(){} // RVA: 0x7ffaae7d7550
        public void EmitLoadLocal(){} // RVA: 0x7ffaae7d7640
        public void EmitLoadLocalBoxed(){} // RVA: 0x7ffaae7d7880
        public void LoadLocalBoxed(){} // RVA: 0x7ffaae7d78f0
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7ffaae7d7b20
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7ffaae7d7d60
        public void EmitAssignLocal(){} // RVA: 0x7ffaae7d7fa0
        public void EmitStoreLocal(){} // RVA: 0x7ffaae7d81e0
        public void EmitAssignLocalBoxed(){} // RVA: 0x7ffaae7d8420
        public void AssignLocalBoxed(){} // RVA: 0x7ffaae7d8490
        public void EmitStoreLocalBoxed(){} // RVA: 0x7ffaae7d86c0
        public void StoreLocalBoxed(){} // RVA: 0x7ffaae7d8730
        public void EmitAssignLocalToClosure(){} // RVA: 0x7ffaae7d8960
        public void EmitStoreLocalToClosure(){} // RVA: 0x7ffaae7d8ba0
        public void EmitInitializeLocal(){} // RVA: 0x7ffaae7d8c10
        public void EmitInitializeParameter(){} // RVA: 0x7ffaae7d8e10
        public void Parameter(){} // RVA: 0x7ffaae7d8ea0
        public void ParameterBox(){} // RVA: 0x7ffaae7d8ee0
        public void InitReference(){} // RVA: 0x7ffaae7d8f20
        public void InitImmutableRefBox(){} // RVA: 0x7ffaae7d8f60
        public void EmitNewRuntimeVariables(){} // RVA: 0x7ffaae7d8fa0
        public void EmitGetArrayItem(){} // RVA: 0x7ffaae7d9000
        public void EmitSetArrayItem(){} // RVA: 0x7ffaae7d9070
        public void EmitNewArray(){} // RVA: 0x7ffaae7d90e0
        public void EmitNewArrayBounds(){} // RVA: 0x7ffaae7d9190
        public void EmitNewArrayInit(){} // RVA: 0x7ffaae7d9250
        public void EmitAdd(){} // RVA: 0x7ffaae7d9310
        public void EmitSub(){} // RVA: 0x7ffaae7d9350
        public void EmitMul(){} // RVA: 0x7ffaae7d9390
        public void EmitDiv(){} // RVA: 0x7ffaae7d93d0
        public void EmitModulo(){} // RVA: 0x7ffaae7d9400
        public void EmitExclusiveOr(){} // RVA: 0x7ffaae7d9430
        public void EmitAnd(){} // RVA: 0x7ffaae7d9460
        public void EmitOr(){} // RVA: 0x7ffaae7d9490
        public void EmitLeftShift(){} // RVA: 0x7ffaae7d94c0
        public void EmitRightShift(){} // RVA: 0x7ffaae7d94f0
        public void EmitEqual(){} // RVA: 0x7ffaae7d9520
        public void EmitNotEqual(){} // RVA: 0x7ffaae7d9560
        public void EmitLessThan(){} // RVA: 0x7ffaae7d95a0
        public void EmitLessThanOrEqual(){} // RVA: 0x7ffaae7d95e0
        public void EmitGreaterThan(){} // RVA: 0x7ffaae7d9620
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7ffaae7d9660
        public void EmitNumericConvertChecked(){} // RVA: 0x7ffaae7d96a0
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7ffaae7d9720
        public void EmitConvertToUnderlying(){} // RVA: 0x7ffaae7d97a0
        public void EmitCast(){} // RVA: 0x7ffaae7d9810
        public void EmitCastToEnum(){} // RVA: 0x7ffaae7d9840
        public void EmitCastReferenceToEnum(){} // RVA: 0x7ffaae7d98f0
        public void EmitNot(){} // RVA: 0x7ffaae7d99a0
        public void EmitDefaultValue(){} // RVA: 0x7ffaae7d99d0
        public void EmitNew(){} // RVA: 0x7ffaae7d9a80
        public void EmitByRefNew(){} // RVA: 0x7ffaae7d9b50
        public void EmitCreateDelegate(){} // RVA: 0x7ffaae7d9c90
        public void EmitTypeEquals(){} // RVA: 0x7ffaae7d9d40
        public void EmitArrayLength(){} // RVA: 0x7ffaae7d9db0
        public void EmitNegate(){} // RVA: 0x7ffaae7d9e20
        public void EmitNegateChecked(){} // RVA: 0x7ffaae7d9e50
        public void EmitIncrement(){} // RVA: 0x7ffaae7d9e80
        public void EmitDecrement(){} // RVA: 0x7ffaae7d9eb0
        public void EmitTypeIs(){} // RVA: 0x7ffaae7d9ee0
        public void EmitTypeAs(){} // RVA: 0x7ffaae7d9f90
        public void EmitLoadField(){} // RVA: 0x7ffaae7da040
        public void EmitStoreField(){} // RVA: 0x7ffaae7da430
        public void EmitCall(){} // RVA: 0x7ffaae7da610
        public void EmitCall(){} // RVA: 0x7ffaae7da610
        public void EmitByRefCall(){} // RVA: 0x7ffaae7da640
        public void EmitNullableCall(){} // RVA: 0x7ffaae7da7a0
        public void BuildRuntimeLabels(){} // RVA: 0x7ffaae7da810
        public void MakeLabel(){} // RVA: 0x7ffaae7daa90
        public void FixupBranch(){} // RVA: 0x7ffaae7dac00
        public void EnsureLabelIndex(){} // RVA: 0x7ffaae7dada0
        public void MarkRuntimeLabel(){} // RVA: 0x7ffaae7dadd0
        public void MarkLabel(){} // RVA: 0x7ffaae7dae20
        public void EmitGoto(){} // RVA: 0x7ffaae7dae50
        public void EmitBranch(){} // RVA: 0x7ffaae7db290
        public void EmitBranch(){} // RVA: 0x7ffaae7db290
        public void EmitBranch(){} // RVA: 0x7ffaae7db290
        public void EmitCoalescingBranch(){} // RVA: 0x7ffaae7db320
        public void EmitBranchTrue(){} // RVA: 0x7ffaae7db380
        public void EmitBranchFalse(){} // RVA: 0x7ffaae7db3e0
        public void EmitThrow(){} // RVA: 0x7ffaae7db440
        public void EmitThrowVoid(){} // RVA: 0x7ffaae7db4b0
        public void EmitRethrow(){} // RVA: 0x7ffaae7db520
        public void EmitRethrowVoid(){} // RVA: 0x7ffaae7db590
        public void EmitEnterTryFinally(){} // RVA: 0x7ffaae7db600
        public void EmitEnterTryCatch(){} // RVA: 0x7ffaae7db680
        public void EmitEnterTryFault(){} // RVA: 0x7ffaae7db6e0
        public void EmitEnterFinally(){} // RVA: 0x7ffaae7db770
        public void EmitLeaveFinally(){} // RVA: 0x7ffaae7db910
        public void EmitEnterFault(){} // RVA: 0x7ffaae7db980
        public void EmitLeaveFault(){} // RVA: 0x7ffaae7dbb20
        public void EmitEnterExceptionFilter(){} // RVA: 0x7ffaae7dbb90
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7ffaae7dbc00
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7ffaae7dbc70
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7ffaae7dbce0
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7ffaae7dbd50
        public void EmitIntSwitch(){} // RVA: 0x7ffaa8660d80
        public void EmitStringSwitch(){} // RVA: 0x7ffaae7dbf10
        public void .ctor(){} // RVA: 0x7ffaae7dc020
        public void .cctor(){} // RVA: 0x7ffaae7dc0e0
        // ── Binary Analysis Named ──
        public void SetDebugCookie(){} // RVA: 0x7ffaa8932310
        public void GetInstruction(){} // RVA: 0x7ffaae7d6a00
        public void GetLoadField(){} // RVA: 0x7ffaae7da070
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_InstructionName(){} // RVA: 0x7ffaa86491d0
        public void get_ConsumedStack(){} // RVA: 0x7ffaa8649ca0
        public void Run(){} // RVA: 0x7ffaa864e9f0
    }

    public class LabelInfo : Object
    {
        public object _definitions; // 0x31809820

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7df0c0
        public void Reference(){} // RVA: 0x7ffaae7df270
        public void Define(){} // RVA: 0x7ffaae7df320
        public void ValidateJump(){} // RVA: 0x7ffaae7df6c0
        public void ValidateFinish(){} // RVA: 0x7ffaae7dfaa0
        public void EnsureLabel(){} // RVA: 0x7ffaae7dfb30
        public void DefinedIn(){} // RVA: 0x7ffaae7dfbb0
        public void get_HasDefinitions(){} // RVA: 0x7ffaaa364120
        public void FirstDefinition(){} // RVA: 0x7ffaae7dfc80
        public void AddDefinition(){} // RVA: 0x7ffaae7dfeb0
        public void get_HasMultipleDefinitions(){} // RVA: 0x7ffaae7e00d0
        public void CommonNode(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetLabel(){} // RVA: 0x7ffaae7df1e0
    }

    public class LightCompiler : Object
    {
        public object _debugInfos; // 0x31809EE0
        public object _exceptionForRethrowStack; // 0x31809EE0
        public object s_emptyLocals; // 0x31809EE0
        public object Instructions; // 0x1700030B
        public object  ; // 0x85DE8350

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae7e6350
        public void .ctor(){} // RVA: 0x7ffaae7e6350
        public void get_Instructions(){} // RVA: 0x7ffaa894d380
        public void CompileTop(){} // RVA: 0x7ffaae7e63c0
        public void MakeInterpreter(){} // RVA: 0x7ffaae7e68d0
        public void CompileConstantExpression(){} // RVA: 0x7ffaae7e6e50
        public void CompileDefaultExpression(){} // RVA: 0x7ffaae7e6f50
        public void CompileDefaultExpression(){} // RVA: 0x7ffaae7e6f50
        public void EnsureAvailableForClosure(){} // RVA: 0x7ffaae7e7110
        public void ResolveLocal(){} // RVA: 0x7ffaae7e74d0
        public void CompileGetVariable(){} // RVA: 0x7ffaae7e7540
        public void EmitCopyValueType(){} // RVA: 0x7ffaae7e7640
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7ffaae7e7720
        public void MaybeMutableValueType(){} // RVA: 0x7ffaae7e7840
        public void CompileGetBoxedVariable(){} // RVA: 0x7ffaae7e78c0
        public void CompileSetVariable(){} // RVA: 0x7ffaae7e7960
        public void CompileParameterExpression(){} // RVA: 0x7ffaae7e7b80
        public void CompileBlockExpression(){} // RVA: 0x7ffaae7e7c10
        public void CompileBlockStart(){} // RVA: 0x7ffaae7e7e90
        public void CompileBlockEnd(){} // RVA: 0x7ffaae7e8450
        public void CompileIndexExpression(){} // RVA: 0x7ffaae7e8530
        public void EmitIndexGet(){} // RVA: 0x7ffaae7e8680
        public void CompileIndexAssignment(){} // RVA: 0x7ffaae7e8830
        public void CompileMemberAssignment(){} // RVA: 0x7ffaae7e8e60
        public void CompileMemberAssignment(){} // RVA: 0x7ffaae7e8e60
        public void CompileVariableAssignment(){} // RVA: 0x7ffaae7e9440
        public void CompileAssignBinaryExpression(){} // RVA: 0x7ffaae7e9500
        public void CompileBinaryExpression(){} // RVA: 0x7ffaae7e9790
        public void CompileEqual(){} // RVA: 0x7ffaae7ea960
        public void CompileNotEqual(){} // RVA: 0x7ffaae7eaa00
        public void CompileComparison(){} // RVA: 0x7ffaae7eaaa0
        public void CompileArithmetic(){} // RVA: 0x7ffaae7eaca0
        public void CompileConvertUnaryExpression(){} // RVA: 0x7ffaae7eaf30
        public void CompileConvertToType(){} // RVA: 0x7ffaae7eb7d0
        public void CompileNotExpression(){} // RVA: 0x7ffaae7ebfb0
        public void CompileUnaryExpression(){} // RVA: 0x7ffaae7ec020
        public void EmitUnaryMethodCall(){} // RVA: 0x7ffaae7ec550
        public void EmitUnaryBoolCheck(){} // RVA: 0x7ffaae7ec660
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7ffaae7ec890
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7ffaae7ec920
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7ffaae7ec9b0
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7ffaae7ecc00
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7ffaae7ece40
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7ffaae7edcc0
        public void CompileConditionalExpression(){} // RVA: 0x7ffaae7ede00
        public void CompileLoopExpression(){} // RVA: 0x7ffaae7ee0d0
        public void CompileSwitchExpression(){} // RVA: 0x7ffaae7ee560
        public void CompileIntSwitchExpression(){} // RVA: 0x7ffaa8660d80
        public void CompileStringSwitchExpression(){} // RVA: 0x7ffaae7eef40
        public void CompileLabelExpression(){} // RVA: 0x7ffaae7ef810
        public void CompileGotoExpression(){} // RVA: 0x7ffaae7efaa0
        public void PushLabelBlock(){} // RVA: 0x7ffaae7efe20
        public void PopLabelBlock(){} // RVA: 0x7ffaae7eff20
        public void EnsureLabel(){} // RVA: 0x7ffaae7eff90
        public void ReferenceLabel(){} // RVA: 0x7ffaae7f00f0
        public void DefineLabel(){} // RVA: 0x7ffaae7f01b0
        public void TryPushLabelBlock(){} // RVA: 0x7ffaae7f0250
        public void DefineBlockLabels(){} // RVA: 0x7ffaae7f0630
        public void CompileThrowUnaryExpression(){} // RVA: 0x7ffaae7f0880
        public void CompileTryExpression(){} // RVA: 0x7ffaae7f0b90
        public void CompileTryFaultExpression(){} // RVA: 0x7ffaae7f19f0
        public void CompileMethodCallExpression(){} // RVA: 0x7ffaae7f1f90
        public void CompileMethodCallExpression(){} // RVA: 0x7ffaae7f1f90
        public void CompileArrayIndexAddress(){} // RVA: 0x7ffaae7f24d0
        public void EmitThisForMethodCall(){} // RVA: 0x7ffaae7f2870
        public void ShouldWritebackNode(){} // RVA: 0x7ffaae7f2880
        public void CompileAddress(){} // RVA: 0x7ffaae7f2aa0
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7ffaae7f39e0
        public void CompileNewExpression(){} // RVA: 0x7ffaae7f41c0
        public void CompileMemberExpression(){} // RVA: 0x7ffaae7f4720
        public void CompileMember(){} // RVA: 0x7ffaae7f47e0
        public void CompileNewArrayExpression(){} // RVA: 0x7ffaae7f4b60
        public void CompileDebugInfoExpression(){} // RVA: 0x7ffaae7f5070
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7ffaae7f5280
        public void CompileLambdaExpression(){} // RVA: 0x7ffaae7f55a0
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7ffaae7f59a0
        public void CompileInvocationExpression(){} // RVA: 0x7ffaae7f6200
        public void CompileListInitExpression(){} // RVA: 0x7ffaae7f6520
        public void CompileListInit(){} // RVA: 0x7ffaae7f65c0
        public void CompileMemberInitExpression(){} // RVA: 0x7ffaae7f6970
        public void CompileMemberInit(){} // RVA: 0x7ffaae7f6a10
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7ffaae7f7000
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7ffaae7f7580
        public void CompileTypeEqualExpression(){} // RVA: 0x7ffaae7f76e0
        public void CompileTypeAsExpression(){} // RVA: 0x7ffaae7f7930
        public void CompileTypeIsExpression(){} // RVA: 0x7ffaae7f7a10
        public void Compile(){} // RVA: 0x7ffaae7f8900
        public void CompileAsVoid(){} // RVA: 0x7ffaae7f7d40
        public void CompileNoLabelPush(){} // RVA: 0x7ffaae7f7ed0
        public void Compile(){} // RVA: 0x7ffaae7f8900
        public void .cctor(){} // RVA: 0x7ffaae7f8960
        // ── Binary Analysis Named ──
        public void CheckRethrow(){} // RVA: 0x7ffaae7f0820
        public void GetMemberType(){} // RVA: 0x7ffaae7f6ec0
    }

    public class LightLambda : Object
    {
        public object _interpreter; // 0x3180A060

        // ── Original Methods ──
        public void Run0(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid0(){} // RVA: 0x7ffaae7fa780
        public void MakeRun0(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid0(){} // RVA: 0x7ffaae7fa840
        public void Run1(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid1(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun1(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid1(){} // RVA: 0x7ffaa86492c0
        public void Run2(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid2(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun2(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid2(){} // RVA: 0x7ffaa86492c0
        public void Run3(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid3(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun3(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid3(){} // RVA: 0x7ffaa86492c0
        public void Run4(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid4(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun4(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid4(){} // RVA: 0x7ffaa86492c0
        public void Run5(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid5(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun5(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid5(){} // RVA: 0x7ffaa86492c0
        public void Run6(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid6(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun6(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid6(){} // RVA: 0x7ffaa86492c0
        public void Run7(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid7(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun7(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid7(){} // RVA: 0x7ffaa86492c0
        public void Run8(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid8(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun8(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid8(){} // RVA: 0x7ffaa86492c0
        public void Run9(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid9(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun9(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid9(){} // RVA: 0x7ffaa86492c0
        public void Run10(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid10(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun10(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid10(){} // RVA: 0x7ffaa86492c0
        public void Run11(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid11(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun11(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid11(){} // RVA: 0x7ffaa86492c0
        public void Run12(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid12(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun12(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid12(){} // RVA: 0x7ffaa86492c0
        public void Run13(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid13(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun13(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid13(){} // RVA: 0x7ffaa86492c0
        public void Run14(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid14(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun14(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid14(){} // RVA: 0x7ffaa86492c0
        public void Run15(){} // RVA: 0x7ffaa887e5c0
        public void RunVoid15(){} // RVA: 0x7ffaa887e5c0
        public void MakeRun15(){} // RVA: 0x7ffaa86492c0
        public void MakeRunVoid15(){} // RVA: 0x7ffaa86492c0
        public void .ctor(){} // RVA: 0x7ffaae7fa8c0
        public void get_DebugView(){} // RVA: 0x7ffaae7fa9f0
        public void MakeRunDelegateCtor(){} // RVA: 0x7ffaae7fad70
        public void CreateCustomDelegate(){} // RVA: 0x7ffaae7fb960
        public void MakeDelegate(){} // RVA: 0x7ffaae7fc150
        public void MakeFrame(){} // RVA: 0x7ffaae7fc1e0
        public void RunVoidRef2(){} // RVA: 0x7ffaa8669e70
        public void Run(){} // RVA: 0x7ffaae7fc250
        public void RunVoid(){} // RVA: 0x7ffaae7fc5f0
        public void .cctor(){} // RVA: 0x7ffaae7fc7f0
        // ── Binary Analysis Named ──
        public void GetRunDelegateCtor(){} // RVA: 0x7ffaae7faa70
    }

    public class QuoteInstruction : Instruction
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void get_ProducedStack(){} // RVA: 0x7ffaa8a24af0
        public void get_InstructionName(){} // RVA: 0x7ffaae811eb0
        public void Run(){} // RVA: 0x7ffaae811ef0
    }

}