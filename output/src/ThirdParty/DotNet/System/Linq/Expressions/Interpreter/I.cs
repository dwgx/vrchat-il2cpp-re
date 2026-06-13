// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 187

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x1BCC0
    }

    public class IncrementInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x661C9A0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x661C9E0
    }

    public class IndexMethodByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6641600
        public void Update(){} // RVA: 0x6641720
        public void UndefineTemps(){} // RVA: 0x66419A0
    }

    public class IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void GetLabel(){} // RVA: 0x6611030
        public void ToDebugString(){} // RVA: 0x6611090
        public void ToString(){} // RVA: 0x66111E0
    }

    public class InitializeLocalInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class Instruction
    {
        public int UnknownInstrIndex;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x519240
        public void get_ProducedStack(){} // RVA: 0x519240
        public void get_ConsumedContinuations(){} // RVA: 0x519240
        public void get_ProducedContinuations(){} // RVA: 0x519240
        public void get_StackBalance(){} // RVA: 0x661D7A0
        public void get_ContinuationsBalance(){} // RVA: 0x661D7F0
        public void Run(){} // RVA: 0x12590
        public void get_InstructionName(){} // RVA: 0xCD60
        public void ToString(){} // RVA: 0x661D840
        public void ToDebugString(){} // RVA: 0x5DF8220
        public void GetDebugCookie(){} // RVA: 0x519240
        public void NullCheck(){} // RVA: 0x4F446F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class InstructionArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x661D8A0
    }

    public class InstructionList
    {
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.Instruction> _instructions; // 0x10
        public System.Collections.Generic.List`1<object> _objects; // 0x18
        public int _currentStackDepth; // 0x20
        public int _maxStackDepth; // 0x24

        // ── Methods ──
        public void Emit(){} // RVA: 0x661DC40
        public void UpdateStackDepth(){} // RVA: 0x661DD70
        public void UnEmit(){} // RVA: 0x661DE30
        public void SetDebugCookie(){} // RVA: 0x2DD310
        public void get_Count(){} // RVA: 0x661DF90
        public void get_CurrentStackDepth(){} // RVA: 0x760030
        public void get_CurrentContinuationsDepth(){} // RVA: 0x791DC0
        public void get_MaxStackDepth(){} // RVA: 0xCEF5B0
        public void GetInstruction(){} // RVA: 0x661DFE0
        public void ToArray(){} // RVA: 0x661E060
        public void EmitLoad(){} // RVA: 0x661E410 | overloaded x3
        public void EmitDup(){} // RVA: 0x661EA50
        public void EmitPop(){} // RVA: 0x661EAC0
        public void SwitchToBoxed(){} // RVA: 0x661EB30
        public void EmitLoadLocal(){} // RVA: 0x661EC20
        public void EmitLoadLocalBoxed(){} // RVA: 0x661EE60
        public void LoadLocalBoxed(){} // RVA: 0x661EED0
        public void EmitLoadLocalFromClosure(){} // RVA: 0x661F100
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x661F340
        public void EmitAssignLocal(){} // RVA: 0x661F580
        public void EmitStoreLocal(){} // RVA: 0x661F7C0
        public void EmitAssignLocalBoxed(){} // RVA: 0x661FA00
        public void AssignLocalBoxed(){} // RVA: 0x661FA70
        public void EmitStoreLocalBoxed(){} // RVA: 0x661FCA0
        public void StoreLocalBoxed(){} // RVA: 0x661FD10
        public void EmitAssignLocalToClosure(){} // RVA: 0x661FF40
        public void EmitStoreLocalToClosure(){} // RVA: 0x6620180
        public void EmitInitializeLocal(){} // RVA: 0x66201F0
        public void EmitInitializeParameter(){} // RVA: 0x66203F0
        public void Parameter(){} // RVA: 0x6620480
        public void ParameterBox(){} // RVA: 0x66204C0
        public void InitReference(){} // RVA: 0x6620500
        public void InitImmutableRefBox(){} // RVA: 0x6620540
        public void EmitNewRuntimeVariables(){} // RVA: 0x6620580
        public void EmitGetArrayItem(){} // RVA: 0x66205E0
        public void EmitSetArrayItem(){} // RVA: 0x6620650
        public void EmitNewArray(){} // RVA: 0x66206C0
        public void EmitNewArrayBounds(){} // RVA: 0x6620770
        public void EmitNewArrayInit(){} // RVA: 0x6620830
        public void EmitAdd(){} // RVA: 0x66208F0
        public void EmitSub(){} // RVA: 0x6620930
        public void EmitMul(){} // RVA: 0x6620970
        public void EmitDiv(){} // RVA: 0x66209B0
        public void EmitModulo(){} // RVA: 0x66209E0
        public void EmitExclusiveOr(){} // RVA: 0x6620A10
        public void EmitAnd(){} // RVA: 0x6620A40
        public void EmitOr(){} // RVA: 0x6620A70
        public void EmitLeftShift(){} // RVA: 0x6620AA0
        public void EmitRightShift(){} // RVA: 0x6620AD0
        public void EmitEqual(){} // RVA: 0x6620B00
        public void EmitNotEqual(){} // RVA: 0x6620B40
        public void EmitLessThan(){} // RVA: 0x6620B80
        public void EmitLessThanOrEqual(){} // RVA: 0x6620BC0
        public void EmitGreaterThan(){} // RVA: 0x6620C00
        public void EmitGreaterThanOrEqual(){} // RVA: 0x6620C40
        public void EmitNumericConvertChecked(){} // RVA: 0x6620C80
        public void EmitNumericConvertUnchecked(){} // RVA: 0x6620D00
        public void EmitConvertToUnderlying(){} // RVA: 0x6620D80
        public void EmitCast(){} // RVA: 0x6620DF0
        public void EmitCastToEnum(){} // RVA: 0x6620E20
        public void EmitCastReferenceToEnum(){} // RVA: 0x6620ED0
        public void EmitNot(){} // RVA: 0x6620F80
        public void EmitDefaultValue(){} // RVA: 0x6620FB0
        public void EmitNew(){} // RVA: 0x6621060
        public void EmitByRefNew(){} // RVA: 0x6621130
        public void EmitCreateDelegate(){} // RVA: 0x6621270
        public void EmitTypeEquals(){} // RVA: 0x6621320
        public void EmitArrayLength(){} // RVA: 0x6621390
        public void EmitNegate(){} // RVA: 0x6621400
        public void EmitNegateChecked(){} // RVA: 0x6621430
        public void EmitIncrement(){} // RVA: 0x6621460
        public void EmitDecrement(){} // RVA: 0x6621490
        public void EmitTypeIs(){} // RVA: 0x66214C0
        public void EmitTypeAs(){} // RVA: 0x6621570
        public void EmitLoadField(){} // RVA: 0x6621620
        public void GetLoadField(){} // RVA: 0x6621650
        public void EmitStoreField(){} // RVA: 0x6621A10
        public void EmitCall(){} // RVA: 0x6621BF0 | overloaded x2
        public void EmitByRefCall(){} // RVA: 0x6621C20
        public void EmitNullableCall(){} // RVA: 0x6621D80
        public void BuildRuntimeLabels(){} // RVA: 0x6621DF0
        public void MakeLabel(){} // RVA: 0x6622070
        public void FixupBranch(){} // RVA: 0x66221E0
        public void EnsureLabelIndex(){} // RVA: 0x6622380
        public void MarkRuntimeLabel(){} // RVA: 0x66223B0
        public void MarkLabel(){} // RVA: 0x6622400
        public void EmitGoto(){} // RVA: 0x6622430
        public void EmitBranch(){} // RVA: 0x6622870 | overloaded x3
        public void EmitCoalescingBranch(){} // RVA: 0x6622900
        public void EmitBranchTrue(){} // RVA: 0x6622960
        public void EmitBranchFalse(){} // RVA: 0x66229C0
        public void EmitThrow(){} // RVA: 0x6622A20
        public void EmitThrowVoid(){} // RVA: 0x6622A90
        public void EmitRethrow(){} // RVA: 0x6622B00
        public void EmitRethrowVoid(){} // RVA: 0x6622B70
        public void EmitEnterTryFinally(){} // RVA: 0x6622BE0
        public void EmitEnterTryCatch(){} // RVA: 0x6622C60
        public void EmitEnterTryFault(){} // RVA: 0x6622CC0
        public void EmitEnterFinally(){} // RVA: 0x6622D50
        public void EmitLeaveFinally(){} // RVA: 0x6622EF0
        public void EmitEnterFault(){} // RVA: 0x6622F60
        public void EmitLeaveFault(){} // RVA: 0x6623100
        public void EmitEnterExceptionFilter(){} // RVA: 0x6623170
        public void EmitLeaveExceptionFilter(){} // RVA: 0x66231E0
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x6623250
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x66232C0
        public void EmitLeaveExceptionHandler(){} // RVA: 0x6623330
        public void EmitIntSwitch(){} // RVA: 0x24B10
        public void EmitStringSwitch(){} // RVA: 0x66234F0
        public void .ctor(){} // RVA: 0x6623600
        public void .cctor(){} // RVA: 0x66236C0
    }

    public class IntSwitchInstruction`1
    {
        public System.Collections.Generic.Dictionary`2<T,int> _cases;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_InstructionName(){} // RVA: 0xCD60
        public void get_ConsumedStack(){} // RVA: 0xD840
        public void Run(){} // RVA: 0x12590
    }

    public class InterpretedFrame
    {
        public System.Linq.Expressions.Interpreter.InterpretedFrame Name; // 0xFFFFFFFF
        public System.Linq.Expressions.Interpreter.Interpreter LocalCount; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6624360
        public void GetDebugInfo(){} // RVA: 0x6624600
        public void get_Name(){} // RVA: 0xF3ED00
        public void Push(){} // RVA: 0x6624BD0 | overloaded x7
        public void Pop(){} // RVA: 0x6624C90
        public void SetStackDepth(){} // RVA: 0x6624CD0
        public void Peek(){} // RVA: 0x6624CF0
        public void Dup(){} // RVA: 0x6624D20
        public void get_Parent(){} // RVA: 0x2E07C0
        public void IsInterpretedFrame(){} // RVA: 0x6624DC0
        public void GetStackTraceDebugInfo(){} // RVA: 0x6624F20
        public void SaveTraceToException(){} // RVA: 0x6624FD0
        public void GetExceptionStackTrace(){} // RVA: 0x6625310
        public void Enter(){} // RVA: 0x6625440
        public void Leave(){} // RVA: 0x66255E0
        public void IsJumpHappened(){} // RVA: 0x66256F0
        public void RemoveContinuation(){} // RVA: 0x44210A0
        public void PushContinuation(){} // RVA: 0x6625700
        public void YieldToCurrentContinuation(){} // RVA: 0x6625740
        public void YieldToPendingContinuation(){} // RVA: 0x66257C0
        public void PushPendingContinuation(){} // RVA: 0x66259F0
        public void PopPendingContinuation(){} // RVA: 0x6625B20
        public void Goto(){} // RVA: 0x6625C20
    }

    public class InterpretedFrameInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void ToString(){} // RVA: 0x662D310
    }

    public class Interpreter
    {
        public object NoValue;
        public int RethrowOnReturn;
        public System.Linq.Expressions.Interpreter.InstructionArray _instructions; // 0x10
        public object[] _objects; // 0x38
        public System.Linq.Expressions.Interpreter.RuntimeLabel[] _labels; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66262D0
        public void get_Name(){} // RVA: 0x37E0E0
        public void get_LocalCount(){} // RVA: 0x9EAB90
        public void get_ClosureSize(){} // RVA: 0x6626510
        public void get_Instructions(){} // RVA: 0xBDB960
        public void get_ClosureVariables(){} // RVA: 0x37B370
        public void Run(){} // RVA: 0x6626560
        public void .cctor(){} // RVA: 0x66265D0
    }

}