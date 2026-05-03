// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 187

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x7FFE80E3D230
    }

    public class IncrementInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8715B870
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8715B8B0
    }

    public class IndexMethodByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871804F0
        public void Update(){} // RVA: 0x7FFE87180610
        public void UndefineTemps(){} // RVA: 0x7FFE87180890
    }

    public class IndexedBranchInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void GetLabel(){} // RVA: 0x7FFE8714FF00
        public void ToDebugString(){} // RVA: 0x7FFE8714FF60
        public void ToString(){} // RVA: 0x7FFE871500B0
    }

    public class InitializeLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class Instruction : Object
    {
        public int UnknownInstrIndex;
        public object field_1; // 0x2E6
        public object field_2; // 0x2E7
        public object field_3; // 0x2E8
        public object field_4; // 0x2E9
        public object field_5; // 0x2EA
        public object field_6; // 0x2EB

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE813240E0
        public void get_ProducedStack(){} // RVA: 0x7FFE813240E0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFE813240E0
        public void get_ProducedContinuations(){} // RVA: 0x7FFE813240E0
        public void get_StackBalance(){} // RVA: 0x7FFE8715C670
        public void get_ContinuationsBalance(){} // RVA: 0x7FFE8715C6C0
        public void Run(){} // RVA: 0x7FFE80E33B00
        public void get_InstructionName(){} // RVA: 0x7FFE80E2E2E0
        public void ToString(){} // RVA: 0x7FFE8715C710
        public void ToDebugString(){} // RVA: 0x7FFE86939060
        public void GetDebugCookie(){} // RVA: 0x7FFE813240E0
        public void NullCheck(){} // RVA: 0x7FFE85B765D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InstructionArray : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8715C770
    }

    public class InstructionList : Object
    {
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.Instruction> _instructions; // 0x10
        public System.Collections.Generic.List`1<object> _objects; // 0x18
        public int _currentStackDepth; // 0x20
        public int _maxStackDepth; // 0x24

        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFE8715CB10
        public void UpdateStackDepth(){} // RVA: 0x7FFE8715CC40
        public void UnEmit(){} // RVA: 0x7FFE8715CD00
        public void SetDebugCookie(){} // RVA: 0x7FFE810FB310
        public void get_Count(){} // RVA: 0x7FFE8715CE60
        public void get_CurrentStackDepth(){} // RVA: 0x7FFE8151D690
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7FFE81549710
        public void get_MaxStackDepth(){} // RVA: 0x7FFE81A56130
        public void GetInstruction(){} // RVA: 0x7FFE8715CEB0
        public void ToArray(){} // RVA: 0x7FFE8715CF30
        public void EmitLoad(){} // RVA: 0x7FFE8715D2E0 | overloaded x3
        public void EmitDup(){} // RVA: 0x7FFE8715D920
        public void EmitPop(){} // RVA: 0x7FFE8715D990
        public void SwitchToBoxed(){} // RVA: 0x7FFE8715DA00
        public void EmitLoadLocal(){} // RVA: 0x7FFE8715DAF0
        public void EmitLoadLocalBoxed(){} // RVA: 0x7FFE8715DD30
        public void LoadLocalBoxed(){} // RVA: 0x7FFE8715DDA0
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7FFE8715DFD0
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7FFE8715E210
        public void EmitAssignLocal(){} // RVA: 0x7FFE8715E450
        public void EmitStoreLocal(){} // RVA: 0x7FFE8715E690
        public void EmitAssignLocalBoxed(){} // RVA: 0x7FFE8715E8D0
        public void AssignLocalBoxed(){} // RVA: 0x7FFE8715E940
        public void EmitStoreLocalBoxed(){} // RVA: 0x7FFE8715EB70
        public void StoreLocalBoxed(){} // RVA: 0x7FFE8715EBE0
        public void EmitAssignLocalToClosure(){} // RVA: 0x7FFE8715EE10
        public void EmitStoreLocalToClosure(){} // RVA: 0x7FFE8715F050
        public void EmitInitializeLocal(){} // RVA: 0x7FFE8715F0C0
        public void EmitInitializeParameter(){} // RVA: 0x7FFE8715F2C0
        public void Parameter(){} // RVA: 0x7FFE8715F350
        public void ParameterBox(){} // RVA: 0x7FFE8715F390
        public void InitReference(){} // RVA: 0x7FFE8715F3D0
        public void InitImmutableRefBox(){} // RVA: 0x7FFE8715F410
        public void EmitNewRuntimeVariables(){} // RVA: 0x7FFE8715F450
        public void EmitGetArrayItem(){} // RVA: 0x7FFE8715F4B0
        public void EmitSetArrayItem(){} // RVA: 0x7FFE8715F520
        public void EmitNewArray(){} // RVA: 0x7FFE8715F590
        public void EmitNewArrayBounds(){} // RVA: 0x7FFE8715F640
        public void EmitNewArrayInit(){} // RVA: 0x7FFE8715F700
        public void EmitAdd(){} // RVA: 0x7FFE8715F7C0
        public void EmitSub(){} // RVA: 0x7FFE8715F800
        public void EmitMul(){} // RVA: 0x7FFE8715F840
        public void EmitDiv(){} // RVA: 0x7FFE8715F880
        public void EmitModulo(){} // RVA: 0x7FFE8715F8B0
        public void EmitExclusiveOr(){} // RVA: 0x7FFE8715F8E0
        public void EmitAnd(){} // RVA: 0x7FFE8715F910
        public void EmitOr(){} // RVA: 0x7FFE8715F940
        public void EmitLeftShift(){} // RVA: 0x7FFE8715F970
        public void EmitRightShift(){} // RVA: 0x7FFE8715F9A0
        public void EmitEqual(){} // RVA: 0x7FFE8715F9D0
        public void EmitNotEqual(){} // RVA: 0x7FFE8715FA10
        public void EmitLessThan(){} // RVA: 0x7FFE8715FA50
        public void EmitLessThanOrEqual(){} // RVA: 0x7FFE8715FA90
        public void EmitGreaterThan(){} // RVA: 0x7FFE8715FAD0
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7FFE8715FB10
        public void EmitNumericConvertChecked(){} // RVA: 0x7FFE8715FB50
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7FFE8715FBD0
        public void EmitConvertToUnderlying(){} // RVA: 0x7FFE8715FC50
        public void EmitCast(){} // RVA: 0x7FFE8715FCC0
        public void EmitCastToEnum(){} // RVA: 0x7FFE8715FCF0
        public void EmitCastReferenceToEnum(){} // RVA: 0x7FFE8715FDA0
        public void EmitNot(){} // RVA: 0x7FFE8715FE50
        public void EmitDefaultValue(){} // RVA: 0x7FFE8715FE80
        public void EmitNew(){} // RVA: 0x7FFE8715FF30
        public void EmitByRefNew(){} // RVA: 0x7FFE87160000
        public void EmitCreateDelegate(){} // RVA: 0x7FFE87160140
        public void EmitTypeEquals(){} // RVA: 0x7FFE871601F0
        public void EmitArrayLength(){} // RVA: 0x7FFE87160260
        public void EmitNegate(){} // RVA: 0x7FFE871602D0
        public void EmitNegateChecked(){} // RVA: 0x7FFE87160300
        public void EmitIncrement(){} // RVA: 0x7FFE87160330
        public void EmitDecrement(){} // RVA: 0x7FFE87160360
        public void EmitTypeIs(){} // RVA: 0x7FFE87160390
        public void EmitTypeAs(){} // RVA: 0x7FFE87160440
        public void EmitLoadField(){} // RVA: 0x7FFE871604F0
        public void GetLoadField(){} // RVA: 0x7FFE87160520
        public void EmitStoreField(){} // RVA: 0x7FFE871608E0
        public void EmitCall(){} // RVA: 0x7FFE87160AC0 | overloaded x2
        public void EmitByRefCall(){} // RVA: 0x7FFE87160AF0
        public void EmitNullableCall(){} // RVA: 0x7FFE87160C50
        public void BuildRuntimeLabels(){} // RVA: 0x7FFE87160CC0
        public void MakeLabel(){} // RVA: 0x7FFE87160F40
        public void FixupBranch(){} // RVA: 0x7FFE871610B0
        public void EnsureLabelIndex(){} // RVA: 0x7FFE87161250
        public void MarkRuntimeLabel(){} // RVA: 0x7FFE87161280
        public void MarkLabel(){} // RVA: 0x7FFE871612D0
        public void EmitGoto(){} // RVA: 0x7FFE87161300
        public void EmitBranch(){} // RVA: 0x7FFE87161740 | overloaded x3
        public void EmitCoalescingBranch(){} // RVA: 0x7FFE871617D0
        public void EmitBranchTrue(){} // RVA: 0x7FFE87161830
        public void EmitBranchFalse(){} // RVA: 0x7FFE87161890
        public void EmitThrow(){} // RVA: 0x7FFE871618F0
        public void EmitThrowVoid(){} // RVA: 0x7FFE87161960
        public void EmitRethrow(){} // RVA: 0x7FFE871619D0
        public void EmitRethrowVoid(){} // RVA: 0x7FFE87161A40
        public void EmitEnterTryFinally(){} // RVA: 0x7FFE87161AB0
        public void EmitEnterTryCatch(){} // RVA: 0x7FFE87161B30
        public void EmitEnterTryFault(){} // RVA: 0x7FFE87161B90
        public void EmitEnterFinally(){} // RVA: 0x7FFE87161C20
        public void EmitLeaveFinally(){} // RVA: 0x7FFE87161DC0
        public void EmitEnterFault(){} // RVA: 0x7FFE87161E30
        public void EmitLeaveFault(){} // RVA: 0x7FFE87161FD0
        public void EmitEnterExceptionFilter(){} // RVA: 0x7FFE87162040
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7FFE871620B0
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7FFE87162120
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7FFE87162190
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7FFE87162200
        public void EmitIntSwitch(){} // RVA: 0x7FFE80E460A0
        public void EmitStringSwitch(){} // RVA: 0x7FFE871623C0
        public void .ctor(){} // RVA: 0x7FFE871624D0
        public void .cctor(){} // RVA: 0x7FFE87162590
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        public System.Collections.Generic.Dictionary`2<T,int> _cases;
        public object field_1; // 0x2C2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_InstructionName(){} // RVA: 0x7FFE80E2E2E0
        public void get_ConsumedStack(){} // RVA: 0x7FFE80E2EDB0
        public void Run(){} // RVA: 0x7FFE80E33B00
    }

    public class InterpretedFrame : Object
    {
        public System.Linq.Expressions.Interpreter.InterpretedFrame s_currentFrame; // 0xFFFF
        public System.Linq.Expressions.Interpreter.Interpreter Interpreter; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87163230
        public void GetDebugInfo(){} // RVA: 0x7FFE871634D0
        public void get_Name(){} // RVA: 0x7FFE87163660
        public void Push(){} // RVA: 0x7FFE87163AC0 | overloaded x7
        public void Pop(){} // RVA: 0x7FFE87163B80
        public void SetStackDepth(){} // RVA: 0x7FFE87163BC0
        public void Peek(){} // RVA: 0x7FFE87163BE0
        public void Dup(){} // RVA: 0x7FFE87163C10
        public void get_Parent(){} // RVA: 0x7FFE810FE7C0
        public void IsInterpretedFrame(){} // RVA: 0x7FFE87163CB0
        public void GetStackTraceDebugInfo(){} // RVA: 0x7FFE87163E10
        public void SaveTraceToException(){} // RVA: 0x7FFE87163EC0
        public void GetExceptionStackTrace(){} // RVA: 0x7FFE87164200
        public void Enter(){} // RVA: 0x7FFE87164330
        public void Leave(){} // RVA: 0x7FFE871644D0
        public void IsJumpHappened(){} // RVA: 0x7FFE871645E0
        public void RemoveContinuation(){} // RVA: 0x7FFE8505BB40
        public void PushContinuation(){} // RVA: 0x7FFE871645F0
        public void YieldToCurrentContinuation(){} // RVA: 0x7FFE87164630
        public void YieldToPendingContinuation(){} // RVA: 0x7FFE871646B0
        public void PushPendingContinuation(){} // RVA: 0x7FFE871648E0
        public void PopPendingContinuation(){} // RVA: 0x7FFE87164A10
        public void Goto(){} // RVA: 0x7FFE87164B10
    }

    public class InterpretedFrameInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void ToString(){} // RVA: 0x7FFE8716C200
    }

    public class Interpreter : Object
    {
        public object NoValue;
        public int RethrowOnReturn;
        public System.Linq.Expressions.Interpreter.InstructionArray _instructions; // 0x10
        public object[] _objects; // 0x38
        public System.Linq.Expressions.Interpreter.RuntimeLabel[] _labels; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871651C0
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void get_LocalCount(){} // RVA: 0x7FFE8175AC90
        public void get_ClosureSize(){} // RVA: 0x7FFE87165400
        public void get_Instructions(){} // RVA: 0x7FFE8196FB10
        public void get_ClosureVariables(){} // RVA: 0x7FFE81199370
        public void Run(){} // RVA: 0x7FFE87165450
        public void .cctor(){} // RVA: 0x7FFE871654C0
    }

}