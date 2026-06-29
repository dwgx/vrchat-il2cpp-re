// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 176

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x7A7E00740
    }

    public class IncrementInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE40B4B0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE40B4F0
    }

    public class IndexMethodByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE42FF80
        public void Update(){} // RVA: 0x7AE4300A0
        public void UndefineTemps(){} // RVA: 0x7AE430330
    }

    public class IndexedBranchInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void GetLabel(){} // RVA: 0x7AE3FFAF0
        public void ToDebugString(){} // RVA: 0x7AE3FFB50
        public void ToString(){} // RVA: 0x7AE3FFCA0
    }

    public class InitializeLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class Instruction : Object
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A82D1450
        public void get_ProducedStack(){} // RVA: 0x7A82D1450
        public void get_ConsumedContinuations(){} // RVA: 0x7A82D1450
        public void get_ProducedContinuations(){} // RVA: 0x7A82D1450
        public void get_StackBalance(){} // RVA: 0x7AE40C2B0
        public void get_ContinuationsBalance(){} // RVA: 0x7AE40C300
        public void Run(){} // RVA: 0x7A7E01630
        public void get_InstructionName(){} // RVA: 0x7A7E00680
        public void ToString(){} // RVA: 0x7AE40C350
        public void ToDebugString(){} // RVA: 0x7ADBE6D30
        public void GetDebugCookie(){} // RVA: 0x7A82D1450
        public void NullCheck(){} // RVA: 0x7ACE3DE00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InstructionArray : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E7F0E0
    }

    public class InstructionList : Object
    {
        // ── Methods ──
        public void Emit(){} // RVA: 0x7AE40C750
        public void UpdateStackDepth(){} // RVA: 0x7AE40C890
        public void UnEmit(){} // RVA: 0x7AE40C950
        public void SetDebugCookie(){} // RVA: 0x7A80D7310
        public void get_Count(){} // RVA: 0x7AE40CAB0
        public void get_CurrentStackDepth(){} // RVA: 0x7A851DB90
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7A854FDE0
        public void get_MaxStackDepth(){} // RVA: 0x7A8AB15F0
        public void GetInstruction(){} // RVA: 0x7AE40CB00
        public void ToArray(){} // RVA: 0x7AE40CB80
        public void EmitLoad(){} // RVA: 0x7AE40CF30
        public void EmitDup(){} // RVA: 0x7AE40D590
        public void EmitPop(){} // RVA: 0x7AE40D600
        public void SwitchToBoxed(){} // RVA: 0x7AE40D670
        public void EmitLoadLocal(){} // RVA: 0x7AE40D760
        public void EmitLoadLocalBoxed(){} // RVA: 0x7AE40D9A0
        public void LoadLocalBoxed(){} // RVA: 0x7AE40DA10
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7AE40DC40
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7AE40DE80
        public void EmitAssignLocal(){} // RVA: 0x7AE40E0C0
        public void EmitStoreLocal(){} // RVA: 0x7AE40E300
        public void EmitAssignLocalBoxed(){} // RVA: 0x7AE40E540
        public void AssignLocalBoxed(){} // RVA: 0x7AE40E5B0
        public void EmitStoreLocalBoxed(){} // RVA: 0x7AE40E7E0
        public void StoreLocalBoxed(){} // RVA: 0x7AE40E850
        public void EmitAssignLocalToClosure(){} // RVA: 0x7AE40EA80
        public void EmitStoreLocalToClosure(){} // RVA: 0x7AE40ECC0
        public void EmitInitializeLocal(){} // RVA: 0x7AE40ED30
        public void EmitInitializeParameter(){} // RVA: 0x7AE40EF30
        public void Parameter(){} // RVA: 0x7AE40EFC0
        public void ParameterBox(){} // RVA: 0x7AE40F000
        public void InitReference(){} // RVA: 0x7AE40F040
        public void InitImmutableRefBox(){} // RVA: 0x7AE40F080
        public void EmitNewRuntimeVariables(){} // RVA: 0x7AE40F0C0
        public void EmitGetArrayItem(){} // RVA: 0x7AE40F120
        public void EmitSetArrayItem(){} // RVA: 0x7AE40F190
        public void EmitNewArray(){} // RVA: 0x7AE40F200
        public void EmitNewArrayBounds(){} // RVA: 0x7AE40F2B0
        public void EmitNewArrayInit(){} // RVA: 0x7AE40F370
        public void EmitAdd(){} // RVA: 0x7AE40F430
        public void EmitSub(){} // RVA: 0x7AE40F470
        public void EmitMul(){} // RVA: 0x7AE40F4B0
        public void EmitDiv(){} // RVA: 0x7AE40F4F0
        public void EmitModulo(){} // RVA: 0x7AE40F520
        public void EmitExclusiveOr(){} // RVA: 0x7AE40F550
        public void EmitAnd(){} // RVA: 0x7AE40F580
        public void EmitOr(){} // RVA: 0x7AE40F5B0
        public void EmitLeftShift(){} // RVA: 0x7AE40F5E0
        public void EmitRightShift(){} // RVA: 0x7AE40F610
        public void EmitEqual(){} // RVA: 0x7AE40F640
        public void EmitNotEqual(){} // RVA: 0x7AE40F680
        public void EmitLessThan(){} // RVA: 0x7AE40F6C0
        public void EmitLessThanOrEqual(){} // RVA: 0x7AE40F700
        public void EmitGreaterThan(){} // RVA: 0x7AE40F740
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7AE40F780
        public void EmitNumericConvertChecked(){} // RVA: 0x7AE40F7C0
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7AE40F840
        public void EmitConvertToUnderlying(){} // RVA: 0x7AE40F8C0
        public void EmitCast(){} // RVA: 0x7AE40F930
        public void EmitCastToEnum(){} // RVA: 0x7AE40F960
        public void EmitCastReferenceToEnum(){} // RVA: 0x7AE40FA10
        public void EmitNot(){} // RVA: 0x7AE40FAC0
        public void EmitDefaultValue(){} // RVA: 0x7AE40FAF0
        public void EmitNew(){} // RVA: 0x7AE40FBA0
        public void EmitByRefNew(){} // RVA: 0x7AE40FC70
        public void EmitCreateDelegate(){} // RVA: 0x7AE40FDB0
        public void EmitTypeEquals(){} // RVA: 0x7AE40FE60
        public void EmitArrayLength(){} // RVA: 0x7AE40FED0
        public void EmitNegate(){} // RVA: 0x7AE40FF40
        public void EmitNegateChecked(){} // RVA: 0x7AE40FF70
        public void EmitIncrement(){} // RVA: 0x7AE40FFA0
        public void EmitDecrement(){} // RVA: 0x7AE40FFD0
        public void EmitTypeIs(){} // RVA: 0x7AE410000
        public void EmitTypeAs(){} // RVA: 0x7AE4100B0
        public void EmitLoadField(){} // RVA: 0x7AE410160
        public void GetLoadField(){} // RVA: 0x7AE410190
        public void EmitStoreField(){} // RVA: 0x7AE410520
        public void EmitCall(){} // RVA: 0x7AE410700
        public void EmitByRefCall(){} // RVA: 0x7AE410730
        public void EmitNullableCall(){} // RVA: 0x7AE410890
        public void BuildRuntimeLabels(){} // RVA: 0x7AE410900
        public void MakeLabel(){} // RVA: 0x7AE410B90
        public void FixupBranch(){} // RVA: 0x7AE410D00
        public void EnsureLabelIndex(){} // RVA: 0x7AE410EA0
        public void MarkRuntimeLabel(){} // RVA: 0x7AE410ED0
        public void MarkLabel(){} // RVA: 0x7AE410F20
        public void EmitGoto(){} // RVA: 0x7AE410F50
        public void EmitBranch(){} // RVA: 0x7AE411240
        public void EmitCoalescingBranch(){} // RVA: 0x7AE4112D0
        public void EmitBranchTrue(){} // RVA: 0x7AE411330
        public void EmitBranchFalse(){} // RVA: 0x7AE411390
        public void EmitThrow(){} // RVA: 0x7AE4113F0
        public void EmitThrowVoid(){} // RVA: 0x7AE411460
        public void EmitRethrow(){} // RVA: 0x7AE4114D0
        public void EmitRethrowVoid(){} // RVA: 0x7AE411540
        public void EmitEnterTryFinally(){} // RVA: 0x7AE4115B0
        public void EmitEnterTryCatch(){} // RVA: 0x7AE411630
        public void EmitEnterTryFault(){} // RVA: 0x7AE411690
        public void EmitEnterFinally(){} // RVA: 0x7AE411720
        public void EmitLeaveFinally(){} // RVA: 0x7AE4118C0
        public void EmitEnterFault(){} // RVA: 0x7AE411930
        public void EmitLeaveFault(){} // RVA: 0x7AE411AD0
        public void EmitEnterExceptionFilter(){} // RVA: 0x7AE411B40
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7AE411BB0
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7AE411C20
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7AE411C90
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7AE411D00
        public void EmitIntSwitch(){} // RVA: 0x7A7E18800
        public void EmitStringSwitch(){} // RVA: 0x7AE411EE0
        public void .ctor(){} // RVA: 0x7AE411FF0
        public void .cctor(){} // RVA: 0x7AE4120B0
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_InstructionName(){} // RVA: 0x7A7E00680
        public void get_ConsumedStack(){} // RVA: 0x7A7E00710
        public void Run(){} // RVA: 0x7A7E01630
    }

    public class InterpretedFrame : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE412D50
        public void GetDebugInfo(){} // RVA: 0x7AE412FF0
        public void get_Name(){} // RVA: 0x7A8D094E0
        public void Push(){} // RVA: 0x7AE4135C0
        public void Pop(){} // RVA: 0x7AE413680
        public void SetStackDepth(){} // RVA: 0x7AE4136C0
        public void Peek(){} // RVA: 0x7AE4136E0
        public void Dup(){} // RVA: 0x7AE413710
        public void get_Parent(){} // RVA: 0x7A80DA7B0
        public void IsInterpretedFrame(){} // RVA: 0x7AE4137B0
        public void GetStackTraceDebugInfo(){} // RVA: 0x7AE413910
        public void SaveTraceToException(){} // RVA: 0x7AE4139C0
        public void GetExceptionStackTrace(){} // RVA: 0x7AE413D00
        public void Enter(){} // RVA: 0x7AE413E30
        public void Leave(){} // RVA: 0x7AE413FF0
        public void IsJumpHappened(){} // RVA: 0x7AE414100
        public void RemoveContinuation(){} // RVA: 0x7AC20FD50
        public void PushContinuation(){} // RVA: 0x7AE414110
        public void YieldToCurrentContinuation(){} // RVA: 0x7AE414150
        public void YieldToPendingContinuation(){} // RVA: 0x7AE4141D0
        public void PushPendingContinuation(){} // RVA: 0x7AE414400
        public void PopPendingContinuation(){} // RVA: 0x7AE414530
        public void Goto(){} // RVA: 0x7AE414630
    }

    public class InterpretedFrameInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void ToString(){} // RVA: 0x7A7E7F3A0
    }

    public class Interpreter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE414CD0
        public void get_Name(){} // RVA: 0x7A8178B90
        public void get_LocalCount(){} // RVA: 0x7A87A7DA0
        public void get_ClosureSize(){} // RVA: 0x7AE414F10
        public void get_Instructions(){} // RVA: 0x7A89A1E30
        public void get_ClosureVariables(){} // RVA: 0x7A8175DF0
        public void Run(){} // RVA: 0x7AE414F60
        public void .cctor(){} // RVA: 0x7AE414FD0
    }

}