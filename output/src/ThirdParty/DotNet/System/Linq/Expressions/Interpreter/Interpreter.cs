// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 331

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CastInstruction : Instruction
    {
        public rmat_String_ObjectArray.ceMethodCallExpressionN ConsumedStack;
        public rmat_String_ObjectArray.ceMethodCallExpressionN ProducedStack; // 0x8
        public rmat_String_ObjectArray.ceMethodCallExpressionN InstructionName; // 0x10
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_DateTime; // 0x18
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Decimal; // 0x20
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Double; // 0x28
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Int16; // 0x30
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Int32; // 0x38
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Int64; // 0x40
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_SByte; // 0x48
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_Single; // 0x50
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_String; // 0x58
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_UInt16; // 0x60
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_UInt32; // 0x68
        public rmat_String_ObjectArray.ceMethodCallExpressionN s_UInt64; // 0x70

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFD4E433AF0
        public void get_ProducedStack(){} // RVA: 0x7FFD4E433AF0
        public void get_InstructionName(){} // RVA: 0x7FFD5420E9F0
        public void Create(){} // RVA: 0x7FFD5420EA30
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class HybridReferenceDictionary`2 : Object
    {
        public URA.mes<T1717688080,T1717688096>[] Item;
        public URA.DateTime<T1717688080,T1717688096> _dict;
        public int ArraySize;

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumeratorWorker(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Instruction : Object
    {
        public int ConsumedStack;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFD4E919180
        public void get_ProducedStack(){} // RVA: 0x7FFD4E919180
        public void get_ConsumedContinuations(){} // RVA: 0x7FFD4E919180
        public void get_ProducedContinuations(){} // RVA: 0x7FFD4E919180
        public void get_StackBalance(){} // RVA: 0x7FFD541D4240
        public void get_ContinuationsBalance(){} // RVA: 0x7FFD541D4290
        public void Run(){} // RVA: 0x7FFD4E07E6B0
        public void get_InstructionName(){} // RVA: 0x7FFD4E078E90
        public void ToString(){} // RVA: 0x7FFD541D42E0
        public void ToDebugString(){} // RVA: 0x7FFD539AF850
        public void GetDebugCookie(){} // RVA: 0x7FFD4E919180
        public void NullCheck(){} // RVA: 0x7FFD52BFF370
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InstructionList : Object
    {
        public URA.woDigitYearMax<rmat_String_ObjectArray.ryQuote> Count; // 0x10
        public URA.woDigitYearMax<object> CurrentStackDepth; // 0x18
        public int CurrentContinuationsDepth; // 0x20
        public int MaxStackDepth; // 0x24
        public int _currentContinuationsDepth; // 0x28
        public int _maxContinuationDepth; // 0x2C
        public int _runtimeLabelCount; // 0x30
        public URA.woDigitYearMax<rmat_String_ObjectArray.ecimal_Ctor_Int32_Int32_Int32_Bool_Byte> _labels; // 0x38
        public URA.woDigitYearMax<URA.mes<int,object>> _debugCookies; // 0x40
        public int PushIntMinCachedValue;
        public int PushIntMaxCachedValue;
        public int CachedObjectCount;
        public rmat_String_ObjectArray.ryQuote s_null;
        public rmat_String_ObjectArray.ryQuote s_true; // 0x8
        public rmat_String_ObjectArray.ryQuote s_false; // 0x10
        public rmat_String_ObjectArray.ryQuote[] s_Ints; // 0x18
        public rmat_String_ObjectArray.ryQuote[] s_loadObjectCached; // 0x20
        public int LocalInstrCacheSize;
        public rmat_String_ObjectArray.ryQuote[] s_loadLocal; // 0x28
        public rmat_String_ObjectArray.ryQuote[] s_loadLocalBoxed; // 0x30
        public rmat_String_ObjectArray.ryQuote[] s_loadLocalFromClosure; // 0x38
        public rmat_String_ObjectArray.ryQuote[] s_loadLocalFromClosureBoxed; // 0x40
        public rmat_String_ObjectArray.ryQuote[] s_assignLocal; // 0x48
        public rmat_String_ObjectArray.ryQuote[] s_storeLocal; // 0x50
        public rmat_String_ObjectArray.ryQuote[] s_assignLocalBoxed; // 0x58
        public rmat_String_ObjectArray.ryQuote[] s_storeLocalBoxed; // 0x60
        public rmat_String_ObjectArray.ryQuote[] s_assignLocalToClosure; // 0x68
        public URA.DateTime<m.WmiGuidObject,rmat_String_ObjectArray.ryQuote> s_loadFields; // 0x70
        public rmat_String_ObjectArray.tor_Int32[] s_emptyRuntimeLabels; // 0x78

        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFD541D46E0
        public void UpdateStackDepth(){} // RVA: 0x7FFD541D4810
        public void UnEmit(){} // RVA: 0x7FFD541D48D0
        public void SetDebugCookie(){} // RVA: 0x7FFD4E341310
        public void get_Count(){} // RVA: 0x7FFD541D4A30
        public void get_CurrentStackDepth(){} // RVA: 0x7FFD4E4FBBE0
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7FFD4E70C4C0
        public void get_MaxStackDepth(){} // RVA: 0x7FFD4ED41980
        public void GetInstruction(){} // RVA: 0x7FFD541D4A80
        public void ToArray(){} // RVA: 0x7FFD541D4B00
        public void EmitLoad(){} // RVA: 0x7FFD541D4EB0 | overloaded x3
        public void EmitDup(){} // RVA: 0x7FFD541D54F0
        public void EmitPop(){} // RVA: 0x7FFD541D5560
        public void SwitchToBoxed(){} // RVA: 0x7FFD541D55D0
        public void EmitLoadLocal(){} // RVA: 0x7FFD541D56C0
        public void EmitLoadLocalBoxed(){} // RVA: 0x7FFD541D5900
        public void LoadLocalBoxed(){} // RVA: 0x7FFD541D5970
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7FFD541D5BA0
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7FFD541D5DE0
        public void EmitAssignLocal(){} // RVA: 0x7FFD541D6020
        public void EmitStoreLocal(){} // RVA: 0x7FFD541D6260
        public void EmitAssignLocalBoxed(){} // RVA: 0x7FFD541D64A0
        public void AssignLocalBoxed(){} // RVA: 0x7FFD541D6510
        public void EmitStoreLocalBoxed(){} // RVA: 0x7FFD541D6740
        public void StoreLocalBoxed(){} // RVA: 0x7FFD541D67B0
        public void EmitAssignLocalToClosure(){} // RVA: 0x7FFD541D69E0
        public void EmitStoreLocalToClosure(){} // RVA: 0x7FFD541D6C20
        public void EmitInitializeLocal(){} // RVA: 0x7FFD541D6C90
        public void EmitInitializeParameter(){} // RVA: 0x7FFD541D6E90
        public void Parameter(){} // RVA: 0x7FFD541D6F20
        public void ParameterBox(){} // RVA: 0x7FFD541D6F60
        public void InitReference(){} // RVA: 0x7FFD541D6FA0
        public void InitImmutableRefBox(){} // RVA: 0x7FFD541D6FE0
        public void EmitNewRuntimeVariables(){} // RVA: 0x7FFD541D7020
        public void EmitGetArrayItem(){} // RVA: 0x7FFD541D7080
        public void EmitSetArrayItem(){} // RVA: 0x7FFD541D70F0
        public void EmitNewArray(){} // RVA: 0x7FFD541D7160
        public void EmitNewArrayBounds(){} // RVA: 0x7FFD541D7210
        public void EmitNewArrayInit(){} // RVA: 0x7FFD541D72D0
        public void EmitAdd(){} // RVA: 0x7FFD541D7390
        public void EmitSub(){} // RVA: 0x7FFD541D73D0
        public void EmitMul(){} // RVA: 0x7FFD541D7410
        public void EmitDiv(){} // RVA: 0x7FFD541D7450
        public void EmitModulo(){} // RVA: 0x7FFD541D7480
        public void EmitExclusiveOr(){} // RVA: 0x7FFD541D74B0
        public void EmitAnd(){} // RVA: 0x7FFD541D74E0
        public void EmitOr(){} // RVA: 0x7FFD541D7510
        public void EmitLeftShift(){} // RVA: 0x7FFD541D7540
        public void EmitRightShift(){} // RVA: 0x7FFD541D7570
        public void EmitEqual(){} // RVA: 0x7FFD541D75A0
        public void EmitNotEqual(){} // RVA: 0x7FFD541D75E0
        public void EmitLessThan(){} // RVA: 0x7FFD541D7620
        public void EmitLessThanOrEqual(){} // RVA: 0x7FFD541D7660
        public void EmitGreaterThan(){} // RVA: 0x7FFD541D76A0
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7FFD541D76E0
        public void EmitNumericConvertChecked(){} // RVA: 0x7FFD541D7720
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7FFD541D77A0
        public void EmitConvertToUnderlying(){} // RVA: 0x7FFD541D7820
        public void EmitCast(){} // RVA: 0x7FFD541D7890
        public void EmitCastToEnum(){} // RVA: 0x7FFD541D78C0
        public void EmitCastReferenceToEnum(){} // RVA: 0x7FFD541D7970
        public void EmitNot(){} // RVA: 0x7FFD541D7A20
        public void EmitDefaultValue(){} // RVA: 0x7FFD541D7A50
        public void EmitNew(){} // RVA: 0x7FFD541D7B00
        public void EmitByRefNew(){} // RVA: 0x7FFD541D7BD0
        public void EmitCreateDelegate(){} // RVA: 0x7FFD541D7D10
        public void EmitTypeEquals(){} // RVA: 0x7FFD541D7DC0
        public void EmitArrayLength(){} // RVA: 0x7FFD541D7E30
        public void EmitNegate(){} // RVA: 0x7FFD541D7EA0
        public void EmitNegateChecked(){} // RVA: 0x7FFD541D7ED0
        public void EmitIncrement(){} // RVA: 0x7FFD541D7F00
        public void EmitDecrement(){} // RVA: 0x7FFD541D7F30
        public void EmitTypeIs(){} // RVA: 0x7FFD541D7F60
        public void EmitTypeAs(){} // RVA: 0x7FFD541D8010
        public void EmitLoadField(){} // RVA: 0x7FFD541D80C0
        public void GetLoadField(){} // RVA: 0x7FFD541D80F0
        public void EmitStoreField(){} // RVA: 0x7FFD541D84B0
        public void EmitCall(){} // RVA: 0x7FFD541D8690 | overloaded x2
        public void EmitByRefCall(){} // RVA: 0x7FFD541D86C0
        public void EmitNullableCall(){} // RVA: 0x7FFD541D8820
        public void BuildRuntimeLabels(){} // RVA: 0x7FFD541D8890
        public void MakeLabel(){} // RVA: 0x7FFD541D8B10
        public void FixupBranch(){} // RVA: 0x7FFD541D8C80
        public void EnsureLabelIndex(){} // RVA: 0x7FFD541D8E20
        public void MarkRuntimeLabel(){} // RVA: 0x7FFD541D8E50
        public void MarkLabel(){} // RVA: 0x7FFD541D8EA0
        public void EmitGoto(){} // RVA: 0x7FFD541D8ED0
        public void EmitBranch(){} // RVA: 0x7FFD541D9310 | overloaded x3
        public void EmitCoalescingBranch(){} // RVA: 0x7FFD541D93A0
        public void EmitBranchTrue(){} // RVA: 0x7FFD541D9400
        public void EmitBranchFalse(){} // RVA: 0x7FFD541D9460
        public void EmitThrow(){} // RVA: 0x7FFD541D94C0
        public void EmitThrowVoid(){} // RVA: 0x7FFD541D9530
        public void EmitRethrow(){} // RVA: 0x7FFD541D95A0
        public void EmitRethrowVoid(){} // RVA: 0x7FFD541D9610
        public void EmitEnterTryFinally(){} // RVA: 0x7FFD541D9680
        public void EmitEnterTryCatch(){} // RVA: 0x7FFD541D9700
        public void EmitEnterTryFault(){} // RVA: 0x7FFD541D9760
        public void EmitEnterFinally(){} // RVA: 0x7FFD541D97F0
        public void EmitLeaveFinally(){} // RVA: 0x7FFD541D9990
        public void EmitEnterFault(){} // RVA: 0x7FFD541D9A00
        public void EmitLeaveFault(){} // RVA: 0x7FFD541D9BA0
        public void EmitEnterExceptionFilter(){} // RVA: 0x7FFD541D9C10
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7FFD541D9C80
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7FFD541D9CF0
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7FFD541D9D60
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7FFD541D9DD0
        public void EmitIntSwitch(){} // RVA: 0x7FFD4E090A40
        public void EmitStringSwitch(){} // RVA: 0x7FFD541D9F90
        public void .ctor(){} // RVA: 0x7FFD541DA0A0
        public void .cctor(){} // RVA: 0x7FFD541DA160
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        public URA.DateTime<T1717679712,int> InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_InstructionName(){} // RVA: 0x7FFD4E078E90
        public void get_ConsumedStack(){} // RVA: 0x7FFD4E079960
        public void Run(){} // RVA: 0x7FFD4E07E6B0
    }

    public class LabelInfo : Object
    {
        public iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.ator<TResult>.Current HasDefinitions; // 0x10
        public rmat_String_ObjectArray.ecimal_Ctor_Int32_Int32_Int32_Bool_Byte HasMultipleDefinitions; // 0x18
        public object _definitions; // 0x20
        public URA.woDigitYearMax<rmat_String_ObjectArray.>b__60_0> _references; // 0x28
        public bool _acrossBlockJump; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD541DD140
        public void GetLabel(){} // RVA: 0x7FFD541DD260
        public void Reference(){} // RVA: 0x7FFD541DD2F0
        public void Define(){} // RVA: 0x7FFD541DD3A0
        public void ValidateJump(){} // RVA: 0x7FFD541DD740
        public void ValidateFinish(){} // RVA: 0x7FFD541DDB20
        public void EnsureLabel(){} // RVA: 0x7FFD541DDBB0
        public void DefinedIn(){} // RVA: 0x7FFD541DDC30
        public void get_HasDefinitions(){} // RVA: 0x7FFD4FD7C6A0
        public void FirstDefinition(){} // RVA: 0x7FFD541DDD00
        public void AddDefinition(){} // RVA: 0x7FFD541DDF30
        public void get_HasMultipleDefinitions(){} // RVA: 0x7FFD541DE150
        public void CommonNode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class LightCompiler : Object
    {
        public rmat_String_ObjectArray.? Instructions; // 0x10
        public rmat_String_ObjectArray.? _locals; // 0x18
        public URA.woDigitYearMax<rmat_String_ObjectArray.ncCollisionExitTrigger> _debugInfos; // 0x20
        public rmat_String_ObjectArray.Expression<iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.ator<TResult>.Current,rmat_String_ObjectArray.to> _treeLabels; // 0x28
        public rmat_String_ObjectArray.>b__60_0 _labelBlock; // 0x30
        public URA.leEastFrench<iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.eneric.IEnumerator<TElement>.Current> _exceptionForRethrowStack; // 0x38
        public rmat_String_ObjectArray.ompatible _parent; // 0x40
        public iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.ocessor _guard; // 0x48
        public rmat_String_ObjectArray.ConstructorRequired[] s_emptyLocals;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD541E43D0 | overloaded x2
        public void get_Instructions(){} // RVA: 0x7FFD4E35C380
        public void CompileTop(){} // RVA: 0x7FFD541E4440
        public void MakeInterpreter(){} // RVA: 0x7FFD541E4950
        public void CompileConstantExpression(){} // RVA: 0x7FFD541E4ED0
        public void CompileDefaultExpression(){} // RVA: 0x7FFD541E4FD0 | overloaded x2
        public void EnsureAvailableForClosure(){} // RVA: 0x7FFD541E5190
        public void ResolveLocal(){} // RVA: 0x7FFD541E5550
        public void CompileGetVariable(){} // RVA: 0x7FFD541E55C0
        public void EmitCopyValueType(){} // RVA: 0x7FFD541E56C0
        public void LoadLocalNoValueTypeCopy(){} // RVA: 0x7FFD541E57A0
        public void MaybeMutableValueType(){} // RVA: 0x7FFD541E58C0
        public void CompileGetBoxedVariable(){} // RVA: 0x7FFD541E5940
        public void CompileSetVariable(){} // RVA: 0x7FFD541E59E0
        public void CompileParameterExpression(){} // RVA: 0x7FFD541E5C00
        public void CompileBlockExpression(){} // RVA: 0x7FFD541E5C90
        public void CompileBlockStart(){} // RVA: 0x7FFD541E5F10
        public void CompileBlockEnd(){} // RVA: 0x7FFD541E64D0
        public void CompileIndexExpression(){} // RVA: 0x7FFD541E65B0
        public void EmitIndexGet(){} // RVA: 0x7FFD541E6700
        public void CompileIndexAssignment(){} // RVA: 0x7FFD541E68B0
        public void CompileMemberAssignment(){} // RVA: 0x7FFD541E6EE0 | overloaded x2
        public void CompileVariableAssignment(){} // RVA: 0x7FFD541E74C0
        public void CompileAssignBinaryExpression(){} // RVA: 0x7FFD541E7580
        public void CompileBinaryExpression(){} // RVA: 0x7FFD541E7810
        public void CompileEqual(){} // RVA: 0x7FFD541E89E0
        public void CompileNotEqual(){} // RVA: 0x7FFD541E8A80
        public void CompileComparison(){} // RVA: 0x7FFD541E8B20
        public void CompileArithmetic(){} // RVA: 0x7FFD541E8D20
        public void CompileConvertUnaryExpression(){} // RVA: 0x7FFD541E8FB0
        public void CompileConvertToType(){} // RVA: 0x7FFD541E9850
        public void CompileNotExpression(){} // RVA: 0x7FFD541EA030
        public void CompileUnaryExpression(){} // RVA: 0x7FFD541EA0A0
        public void EmitUnaryMethodCall(){} // RVA: 0x7FFD541EA5D0
        public void EmitUnaryBoolCheck(){} // RVA: 0x7FFD541EA6E0
        public void CompileAndAlsoBinaryExpression(){} // RVA: 0x7FFD541EA910
        public void CompileOrElseBinaryExpression(){} // RVA: 0x7FFD541EA9A0
        public void CompileLogicalBinaryExpression(){} // RVA: 0x7FFD541EAA30
        public void CompileMethodLogicalBinaryExpression(){} // RVA: 0x7FFD541EAC80
        public void CompileLiftedLogicalBinaryExpression(){} // RVA: 0x7FFD541EAEC0
        public void CompileUnliftedLogicalBinaryExpression(){} // RVA: 0x7FFD541EBD40
        public void CompileConditionalExpression(){} // RVA: 0x7FFD541EBE80
        public void CompileLoopExpression(){} // RVA: 0x7FFD541EC150
        public void CompileSwitchExpression(){} // RVA: 0x7FFD541EC5E0
        public void CompileIntSwitchExpression(){} // RVA: 0x7FFD4E090A40
        public void CompileStringSwitchExpression(){} // RVA: 0x7FFD541ECFC0
        public void CompileLabelExpression(){} // RVA: 0x7FFD541ED890
        public void CompileGotoExpression(){} // RVA: 0x7FFD541EDB20
        public void PushLabelBlock(){} // RVA: 0x7FFD541EDEA0
        public void PopLabelBlock(){} // RVA: 0x7FFD541EDFA0
        public void EnsureLabel(){} // RVA: 0x7FFD541EE010
        public void ReferenceLabel(){} // RVA: 0x7FFD541EE170
        public void DefineLabel(){} // RVA: 0x7FFD541EE230
        public void TryPushLabelBlock(){} // RVA: 0x7FFD541EE2D0
        public void DefineBlockLabels(){} // RVA: 0x7FFD541EE6B0
        public void CheckRethrow(){} // RVA: 0x7FFD541EE8A0
        public void CompileThrowUnaryExpression(){} // RVA: 0x7FFD541EE900
        public void CompileTryExpression(){} // RVA: 0x7FFD541EEC10
        public void CompileTryFaultExpression(){} // RVA: 0x7FFD541EFA70
        public void CompileMethodCallExpression(){} // RVA: 0x7FFD541F0010 | overloaded x2
        public void CompileArrayIndexAddress(){} // RVA: 0x7FFD541F0550
        public void EmitThisForMethodCall(){} // RVA: 0x7FFD541F08F0
        public void ShouldWritebackNode(){} // RVA: 0x7FFD541F0900
        public void CompileAddress(){} // RVA: 0x7FFD541F0B20
        public void CompileMultiDimArrayAccess(){} // RVA: 0x7FFD541F1A60
        public void CompileNewExpression(){} // RVA: 0x7FFD541F2240
        public void CompileMemberExpression(){} // RVA: 0x7FFD541F27A0
        public void CompileMember(){} // RVA: 0x7FFD541F2860
        public void CompileNewArrayExpression(){} // RVA: 0x7FFD541F2BE0
        public void CompileDebugInfoExpression(){} // RVA: 0x7FFD541F30F0
        public void CompileRuntimeVariablesExpression(){} // RVA: 0x7FFD541F3300
        public void CompileLambdaExpression(){} // RVA: 0x7FFD541F3620
        public void CompileCoalesceBinaryExpression(){} // RVA: 0x7FFD541F3A20
        public void CompileInvocationExpression(){} // RVA: 0x7FFD541F4280
        public void CompileListInitExpression(){} // RVA: 0x7FFD541F45A0
        public void CompileListInit(){} // RVA: 0x7FFD541F4640
        public void CompileMemberInitExpression(){} // RVA: 0x7FFD541F49F0
        public void CompileMemberInit(){} // RVA: 0x7FFD541F4A90
        public void GetMemberType(){} // RVA: 0x7FFD541F4F40
        public void CompileQuoteUnaryExpression(){} // RVA: 0x7FFD541F5080
        public void CompileUnboxUnaryExpression(){} // RVA: 0x7FFD541F5600
        public void CompileTypeEqualExpression(){} // RVA: 0x7FFD541F5760
        public void CompileTypeAsExpression(){} // RVA: 0x7FFD541F59B0
        public void CompileTypeIsExpression(){} // RVA: 0x7FFD541F5A90
        public void Compile(){} // RVA: 0x7FFD541F6980 | overloaded x2
        public void CompileAsVoid(){} // RVA: 0x7FFD541F5DC0
        public void CompileNoLabelPush(){} // RVA: 0x7FFD541F5F50
        public void .cctor(){} // RVA: 0x7FFD541F69E0
    }

    public class LightLambda : Object
    {
        public int DebugView;
        public ArgCount.meticTypes[] _closure; // 0x10
        public rmat_String_ObjectArray.ngField _interpreter; // 0x18
        public instructions.untimeLabel<?,n<rmat_String_ObjectArray.otHaveAccessor,formation>> _runCache;
        public rmat_String_ObjectArray.Accessor _delegateCreator; // 0x20

        // ── Methods ──
        public void Run0(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid0(){} // RVA: 0x7FFD541F8800
        public void MakeRun0(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid0(){} // RVA: 0x7FFD541F88C0
        public void Run1(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid1(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun1(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid1(){} // RVA: 0x7FFD4E078F80
        public void Run2(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid2(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun2(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid2(){} // RVA: 0x7FFD4E078F80
        public void Run3(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid3(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun3(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid3(){} // RVA: 0x7FFD4E078F80
        public void Run4(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid4(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun4(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid4(){} // RVA: 0x7FFD4E078F80
        public void Run5(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid5(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun5(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid5(){} // RVA: 0x7FFD4E078F80
        public void Run6(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid6(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun6(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid6(){} // RVA: 0x7FFD4E078F80
        public void Run7(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid7(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun7(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid7(){} // RVA: 0x7FFD4E078F80
        public void Run8(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid8(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun8(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid8(){} // RVA: 0x7FFD4E078F80
        public void Run9(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid9(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun9(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid9(){} // RVA: 0x7FFD4E078F80
        public void Run10(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid10(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun10(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid10(){} // RVA: 0x7FFD4E078F80
        public void Run11(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid11(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun11(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid11(){} // RVA: 0x7FFD4E078F80
        public void Run12(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid12(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun12(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid12(){} // RVA: 0x7FFD4E078F80
        public void Run13(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid13(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun13(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid13(){} // RVA: 0x7FFD4E078F80
        public void Run14(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid14(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun14(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid14(){} // RVA: 0x7FFD4E078F80
        public void Run15(){} // RVA: 0x7FFD4E2ADC40
        public void RunVoid15(){} // RVA: 0x7FFD4E2ADC40
        public void MakeRun15(){} // RVA: 0x7FFD4E078F80
        public void MakeRunVoid15(){} // RVA: 0x7FFD4E078F80
        public void .ctor(){} // RVA: 0x7FFD541F8940
        public void get_DebugView(){} // RVA: 0x7FFD541F8A70
        public void GetRunDelegateCtor(){} // RVA: 0x7FFD541F8AF0
        public void MakeRunDelegateCtor(){} // RVA: 0x7FFD541F8DF0
        public void CreateCustomDelegate(){} // RVA: 0x7FFD541F99E0
        public void MakeDelegate(){} // RVA: 0x7FFD541FA1D0
        public void MakeFrame(){} // RVA: 0x7FFD541FA260
        public void RunVoidRef2(){} // RVA: 0x7FFD4E099B30
        public void Run(){} // RVA: 0x7FFD541FA2D0
        public void RunVoid(){} // RVA: 0x7FFD541FA670
        public void .cctor(){} // RVA: 0x7FFD541FA870
    }

    public class QuoteInstruction : Instruction
    {
        public iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.Update ProducedStack; // 0x10
        public URA.DateTime<iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.eneric.IEnumerator<TElement>.Current,rmat_String_ObjectArray.er> InstructionName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void get_ProducedStack(){} // RVA: 0x7FFD4E433AF0
        public void get_InstructionName(){} // RVA: 0x7FFD5420FF30
        public void Run(){} // RVA: 0x7FFD5420FF70
    }

}