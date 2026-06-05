// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 187

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class IncrementInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_ProducedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void get_InstructionName(){} // RVA: 0x7FFAF90CC9A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF90CC9E0
    }

    public class IndexMethodByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90F1600
        public void Update(){} // RVA: 0x7FFAF90F1720
        public void UndefineTemps(){} // RVA: 0x7FFAF90F19A0
    }

    public class IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void GetLabel(){} // RVA: 0x7FFAF90C1030
        public void ToDebugString(){} // RVA: 0x7FFAF90C1090
        public void ToString(){} // RVA: 0x7FFAF90C11E0
    }

    public class InitializeLocalInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2FC9240
        public void get_ProducedStack(){} // RVA: 0x7FFAF2FC9240
        public void get_ConsumedContinuations(){} // RVA: 0x7FFAF2FC9240
        public void get_ProducedContinuations(){} // RVA: 0x7FFAF2FC9240
        public void get_StackBalance(){} // RVA: 0x7FFAF90CD7A0
        public void get_ContinuationsBalance(){} // RVA: 0x7FFAF90CD7F0
        public void Run(){} // RVA: 0x7FFAF2AC2590
        public void get_InstructionName(){} // RVA: 0x7FFAF2ABCD60
        public void ToString(){} // RVA: 0x7FFAF90CD840
        public void ToDebugString(){} // RVA: 0x7FFAF88A8220
        public void GetDebugCookie(){} // RVA: 0x7FFAF2FC9240
        public void NullCheck(){} // RVA: 0x7FFAF79F46F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class InstructionArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90CD8A0
    }

    public class InstructionList
    {
        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFAF90CDC40
        public void UpdateStackDepth(){} // RVA: 0x7FFAF90CDD70
        public void UnEmit(){} // RVA: 0x7FFAF90CDE30
        public void SetDebugCookie(){} // RVA: 0x7FFAF2D8D310
        public void get_Count(){} // RVA: 0x7FFAF90CDF90
        public void get_CurrentStackDepth(){} // RVA: 0x7FFAF3210030
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7FFAF3241DC0
        public void get_MaxStackDepth(){} // RVA: 0x7FFAF379F5B0
        public void GetInstruction(){} // RVA: 0x7FFAF90CDFE0
        public void ToArray(){} // RVA: 0x7FFAF90CE060
        public void EmitLoad(){} // RVA: 0x7FFAF90CE410 | overloaded x3
        public void EmitDup(){} // RVA: 0x7FFAF90CEA50
        public void EmitPop(){} // RVA: 0x7FFAF90CEAC0
        public void SwitchToBoxed(){} // RVA: 0x7FFAF90CEB30
        public void EmitLoadLocal(){} // RVA: 0x7FFAF90CEC20
        public void EmitLoadLocalBoxed(){} // RVA: 0x7FFAF90CEE60
        public void LoadLocalBoxed(){} // RVA: 0x7FFAF90CEED0
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7FFAF90CF100
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7FFAF90CF340
        public void EmitAssignLocal(){} // RVA: 0x7FFAF90CF580
        public void EmitStoreLocal(){} // RVA: 0x7FFAF90CF7C0
        public void EmitAssignLocalBoxed(){} // RVA: 0x7FFAF90CFA00
        public void AssignLocalBoxed(){} // RVA: 0x7FFAF90CFA70
        public void EmitStoreLocalBoxed(){} // RVA: 0x7FFAF90CFCA0
        public void StoreLocalBoxed(){} // RVA: 0x7FFAF90CFD10
        public void EmitAssignLocalToClosure(){} // RVA: 0x7FFAF90CFF40
        public void EmitStoreLocalToClosure(){} // RVA: 0x7FFAF90D0180
        public void EmitInitializeLocal(){} // RVA: 0x7FFAF90D01F0
        public void EmitInitializeParameter(){} // RVA: 0x7FFAF90D03F0
        public void Parameter(){} // RVA: 0x7FFAF90D0480
        public void ParameterBox(){} // RVA: 0x7FFAF90D04C0
        public void InitReference(){} // RVA: 0x7FFAF90D0500
        public void InitImmutableRefBox(){} // RVA: 0x7FFAF90D0540
        public void EmitNewRuntimeVariables(){} // RVA: 0x7FFAF90D0580
        public void EmitGetArrayItem(){} // RVA: 0x7FFAF90D05E0
        public void EmitSetArrayItem(){} // RVA: 0x7FFAF90D0650
        public void EmitNewArray(){} // RVA: 0x7FFAF90D06C0
        public void EmitNewArrayBounds(){} // RVA: 0x7FFAF90D0770
        public void EmitNewArrayInit(){} // RVA: 0x7FFAF90D0830
        public void EmitAdd(){} // RVA: 0x7FFAF90D08F0
        public void EmitSub(){} // RVA: 0x7FFAF90D0930
        public void EmitMul(){} // RVA: 0x7FFAF90D0970
        public void EmitDiv(){} // RVA: 0x7FFAF90D09B0
        public void EmitModulo(){} // RVA: 0x7FFAF90D09E0
        public void EmitExclusiveOr(){} // RVA: 0x7FFAF90D0A10
        public void EmitAnd(){} // RVA: 0x7FFAF90D0A40
        public void EmitOr(){} // RVA: 0x7FFAF90D0A70
        public void EmitLeftShift(){} // RVA: 0x7FFAF90D0AA0
        public void EmitRightShift(){} // RVA: 0x7FFAF90D0AD0
        public void EmitEqual(){} // RVA: 0x7FFAF90D0B00
        public void EmitNotEqual(){} // RVA: 0x7FFAF90D0B40
        public void EmitLessThan(){} // RVA: 0x7FFAF90D0B80
        public void EmitLessThanOrEqual(){} // RVA: 0x7FFAF90D0BC0
        public void EmitGreaterThan(){} // RVA: 0x7FFAF90D0C00
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7FFAF90D0C40
        public void EmitNumericConvertChecked(){} // RVA: 0x7FFAF90D0C80
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7FFAF90D0D00
        public void EmitConvertToUnderlying(){} // RVA: 0x7FFAF90D0D80
        public void EmitCast(){} // RVA: 0x7FFAF90D0DF0
        public void EmitCastToEnum(){} // RVA: 0x7FFAF90D0E20
        public void EmitCastReferenceToEnum(){} // RVA: 0x7FFAF90D0ED0
        public void EmitNot(){} // RVA: 0x7FFAF90D0F80
        public void EmitDefaultValue(){} // RVA: 0x7FFAF90D0FB0
        public void EmitNew(){} // RVA: 0x7FFAF90D1060
        public void EmitByRefNew(){} // RVA: 0x7FFAF90D1130
        public void EmitCreateDelegate(){} // RVA: 0x7FFAF90D1270
        public void EmitTypeEquals(){} // RVA: 0x7FFAF90D1320
        public void EmitArrayLength(){} // RVA: 0x7FFAF90D1390
        public void EmitNegate(){} // RVA: 0x7FFAF90D1400
        public void EmitNegateChecked(){} // RVA: 0x7FFAF90D1430
        public void EmitIncrement(){} // RVA: 0x7FFAF90D1460
        public void EmitDecrement(){} // RVA: 0x7FFAF90D1490
        public void EmitTypeIs(){} // RVA: 0x7FFAF90D14C0
        public void EmitTypeAs(){} // RVA: 0x7FFAF90D1570
        public void EmitLoadField(){} // RVA: 0x7FFAF90D1620
        public void GetLoadField(){} // RVA: 0x7FFAF90D1650
        public void EmitStoreField(){} // RVA: 0x7FFAF90D1A10
        public void EmitCall(){} // RVA: 0x7FFAF90D1BF0 | overloaded x2
        public void EmitByRefCall(){} // RVA: 0x7FFAF90D1C20
        public void EmitNullableCall(){} // RVA: 0x7FFAF90D1D80
        public void BuildRuntimeLabels(){} // RVA: 0x7FFAF90D1DF0
        public void MakeLabel(){} // RVA: 0x7FFAF90D2070
        public void FixupBranch(){} // RVA: 0x7FFAF90D21E0
        public void EnsureLabelIndex(){} // RVA: 0x7FFAF90D2380
        public void MarkRuntimeLabel(){} // RVA: 0x7FFAF90D23B0
        public void MarkLabel(){} // RVA: 0x7FFAF90D2400
        public void EmitGoto(){} // RVA: 0x7FFAF90D2430
        public void EmitBranch(){} // RVA: 0x7FFAF90D2870 | overloaded x3
        public void EmitCoalescingBranch(){} // RVA: 0x7FFAF90D2900
        public void EmitBranchTrue(){} // RVA: 0x7FFAF90D2960
        public void EmitBranchFalse(){} // RVA: 0x7FFAF90D29C0
        public void EmitThrow(){} // RVA: 0x7FFAF90D2A20
        public void EmitThrowVoid(){} // RVA: 0x7FFAF90D2A90
        public void EmitRethrow(){} // RVA: 0x7FFAF90D2B00
        public void EmitRethrowVoid(){} // RVA: 0x7FFAF90D2B70
        public void EmitEnterTryFinally(){} // RVA: 0x7FFAF90D2BE0
        public void EmitEnterTryCatch(){} // RVA: 0x7FFAF90D2C60
        public void EmitEnterTryFault(){} // RVA: 0x7FFAF90D2CC0
        public void EmitEnterFinally(){} // RVA: 0x7FFAF90D2D50
        public void EmitLeaveFinally(){} // RVA: 0x7FFAF90D2EF0
        public void EmitEnterFault(){} // RVA: 0x7FFAF90D2F60
        public void EmitLeaveFault(){} // RVA: 0x7FFAF90D3100
        public void EmitEnterExceptionFilter(){} // RVA: 0x7FFAF90D3170
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7FFAF90D31E0
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7FFAF90D3250
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7FFAF90D32C0
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7FFAF90D3330
        public void EmitIntSwitch(){} // RVA: 0x7FFAF2AD4B10
        public void EmitStringSwitch(){} // RVA: 0x7FFAF90D34F0
        public void .ctor(){} // RVA: 0x7FFAF90D3600
        public void .cctor(){} // RVA: 0x7FFAF90D36C0
    }

    public class IntSwitchInstruction`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void get_InstructionName(){} // RVA: 0x7FFAF2ABCD60
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2ABD840
        public void Run(){} // RVA: 0x7FFAF2AC2590
    }

    public class InterpretedFrame
    {
        public object Name;
        public object LocalCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90D4360
        public void GetDebugInfo(){} // RVA: 0x7FFAF90D4600
        public void get_Name(){} // RVA: 0x7FFAF39EED00
        public void Push(){} // RVA: 0x7FFAF90D4BD0 | overloaded x7
        public void Pop(){} // RVA: 0x7FFAF90D4C90
        public void SetStackDepth(){} // RVA: 0x7FFAF90D4CD0
        public void Peek(){} // RVA: 0x7FFAF90D4CF0
        public void Dup(){} // RVA: 0x7FFAF90D4D20
        public void get_Parent(){} // RVA: 0x7FFAF2D907C0
        public void IsInterpretedFrame(){} // RVA: 0x7FFAF90D4DC0
        public void GetStackTraceDebugInfo(){} // RVA: 0x7FFAF90D4F20
        public void SaveTraceToException(){} // RVA: 0x7FFAF90D4FD0
        public void GetExceptionStackTrace(){} // RVA: 0x7FFAF90D5310
        public void Enter(){} // RVA: 0x7FFAF90D5440
        public void Leave(){} // RVA: 0x7FFAF90D55E0
        public void IsJumpHappened(){} // RVA: 0x7FFAF90D56F0
        public void RemoveContinuation(){} // RVA: 0x7FFAF6ED10A0
        public void PushContinuation(){} // RVA: 0x7FFAF90D5700
        public void YieldToCurrentContinuation(){} // RVA: 0x7FFAF90D5740
        public void YieldToPendingContinuation(){} // RVA: 0x7FFAF90D57C0
        public void PushPendingContinuation(){} // RVA: 0x7FFAF90D59F0
        public void PopPendingContinuation(){} // RVA: 0x7FFAF90D5B20
        public void Goto(){} // RVA: 0x7FFAF90D5C20
    }

    public class InterpretedFrameInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void ToString(){} // RVA: 0x7FFAF90DD310
    }

    public class Interpreter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90D62D0
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void get_LocalCount(){} // RVA: 0x7FFAF349AB90
        public void get_ClosureSize(){} // RVA: 0x7FFAF90D6510
        public void get_Instructions(){} // RVA: 0x7FFAF368B960
        public void get_ClosureVariables(){} // RVA: 0x7FFAF2E2B370
        public void Run(){} // RVA: 0x7FFAF90D6560
        public void .cctor(){} // RVA: 0x7FFAF90D65D0
    }

}