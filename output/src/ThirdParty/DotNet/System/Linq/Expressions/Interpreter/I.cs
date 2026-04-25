// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 187

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAC2C67DE0
    }

    public class IncrementInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x38

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DB3440
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DB3480
    }

    public class IndexMethodByRefUpdater : ByRefUpdater
    {
        public System.Reflection.MethodInfo _indexer; // 0x18
        public System.Nullable`1<System.Linq.Expressions.Interpreter.LocalDefinition> _obj; // 0x20
        public System.Linq.Expressions.Interpreter.LocalDefinition[] _args; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DD80C0
        public void Update(){} // RVA: 0x7FFAC8DD81E0
        public void UndefineTemps(){} // RVA: 0x7FFAC8DD8460
    }

    public class IndexedBranchInstruction : Instruction
    {
        public int CacheSize;
        public int _labelIndex; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void GetLabel(){} // RVA: 0x7FFAC8DA7AD0
        public void ToDebugString(){} // RVA: 0x7FFAC8DA7B30
        public void ToString(){} // RVA: 0x7FFAC8DA7C80
    }

    public class InitializeLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class Instruction : Object
    {
        public int ConsumedStack;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC34F9180
        public void get_ProducedStack(){} // RVA: 0x7FFAC34F9180
        public void get_ConsumedContinuations(){} // RVA: 0x7FFAC34F9180
        public void get_ProducedContinuations(){} // RVA: 0x7FFAC34F9180
        public void get_StackBalance(){} // RVA: 0x7FFAC8DB4240
        public void get_ContinuationsBalance(){} // RVA: 0x7FFAC8DB4290
        public void Run(){} // RVA: 0x7FFAC2C5E6B0
        public void get_InstructionName(){} // RVA: 0x7FFAC2C58E90
        public void ToString(){} // RVA: 0x7FFAC8DB42E0
        public void ToDebugString(){} // RVA: 0x7FFAC858F850
        public void GetDebugCookie(){} // RVA: 0x7FFAC34F9180
        public void NullCheck(){} // RVA: 0x7FFAC77DF370
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InstructionArray : ValueType
    {
        public int MaxStackDepth; // 0x10
        public int MaxContinuationDepth; // 0x14
        public System.Linq.Expressions.Interpreter.Instruction[] Instructions; // 0x18
        public object[] Objects; // 0x20
        public System.Linq.Expressions.Interpreter.RuntimeLabel[] Labels; // 0x28
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<int,object>> DebugCookies; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DB4340
    }

    public class InstructionList : Object
    {
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.Instruction> Count; // 0x10
        public System.Collections.Generic.List`1<object> CurrentStackDepth; // 0x18
        public int CurrentContinuationsDepth; // 0x20
        public int MaxStackDepth; // 0x24
        public int _currentContinuationsDepth; // 0x28
        public int _maxContinuationDepth; // 0x2C
        public int _runtimeLabelCount; // 0x30
        public System.Collections.Generic.List`1<System.Linq.Expressions.Interpreter.BranchLabel> _labels; // 0x38
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<int,object>> _debugCookies; // 0x40
        public int PushIntMinCachedValue;
        public int PushIntMaxCachedValue;
        public int CachedObjectCount;
        public System.Linq.Expressions.Interpreter.Instruction s_null;
        public System.Linq.Expressions.Interpreter.Instruction s_true; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_false; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction[] s_Ints; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction[] s_loadObjectCached; // 0x20
        public int LocalInstrCacheSize;
        public System.Linq.Expressions.Interpreter.Instruction[] s_loadLocal; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalBoxed; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalFromClosure; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalFromClosureBoxed; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction[] s_assignLocal; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction[] s_storeLocal; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction[] s_assignLocalBoxed; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction[] s_storeLocalBoxed; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction[] s_assignLocalToClosure; // 0x68
        public System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,System.Linq.Expressions.Interpreter.Instruction> s_loadFields; // 0x70
        public System.Linq.Expressions.Interpreter.RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFAC8DB46E0
        public void UpdateStackDepth(){} // RVA: 0x7FFAC8DB4810
        public void UnEmit(){} // RVA: 0x7FFAC8DB48D0
        public void SetDebugCookie(){} // RVA: 0x7FFAC2F21310
        public void get_Count(){} // RVA: 0x7FFAC8DB4A30
        public void get_CurrentStackDepth(){} // RVA: 0x7FFAC30DBBE0
        public void get_CurrentContinuationsDepth(){} // RVA: 0x7FFAC32EC4C0
        public void get_MaxStackDepth(){} // RVA: 0x7FFAC3921980
        public void GetInstruction(){} // RVA: 0x7FFAC8DB4A80
        public void ToArray(){} // RVA: 0x7FFAC8DB4B00
        public void EmitLoad(){} // RVA: 0x7FFAC8DB4EB0 | overloaded x3
        public void EmitDup(){} // RVA: 0x7FFAC8DB54F0
        public void EmitPop(){} // RVA: 0x7FFAC8DB5560
        public void SwitchToBoxed(){} // RVA: 0x7FFAC8DB55D0
        public void EmitLoadLocal(){} // RVA: 0x7FFAC8DB56C0
        public void EmitLoadLocalBoxed(){} // RVA: 0x7FFAC8DB5900
        public void LoadLocalBoxed(){} // RVA: 0x7FFAC8DB5970
        public void EmitLoadLocalFromClosure(){} // RVA: 0x7FFAC8DB5BA0
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x7FFAC8DB5DE0
        public void EmitAssignLocal(){} // RVA: 0x7FFAC8DB6020
        public void EmitStoreLocal(){} // RVA: 0x7FFAC8DB6260
        public void EmitAssignLocalBoxed(){} // RVA: 0x7FFAC8DB64A0
        public void AssignLocalBoxed(){} // RVA: 0x7FFAC8DB6510
        public void EmitStoreLocalBoxed(){} // RVA: 0x7FFAC8DB6740
        public void StoreLocalBoxed(){} // RVA: 0x7FFAC8DB67B0
        public void EmitAssignLocalToClosure(){} // RVA: 0x7FFAC8DB69E0
        public void EmitStoreLocalToClosure(){} // RVA: 0x7FFAC8DB6C20
        public void EmitInitializeLocal(){} // RVA: 0x7FFAC8DB6C90
        public void EmitInitializeParameter(){} // RVA: 0x7FFAC8DB6E90
        public void Parameter(){} // RVA: 0x7FFAC8DB6F20
        public void ParameterBox(){} // RVA: 0x7FFAC8DB6F60
        public void InitReference(){} // RVA: 0x7FFAC8DB6FA0
        public void InitImmutableRefBox(){} // RVA: 0x7FFAC8DB6FE0
        public void EmitNewRuntimeVariables(){} // RVA: 0x7FFAC8DB7020
        public void EmitGetArrayItem(){} // RVA: 0x7FFAC8DB7080
        public void EmitSetArrayItem(){} // RVA: 0x7FFAC8DB70F0
        public void EmitNewArray(){} // RVA: 0x7FFAC8DB7160
        public void EmitNewArrayBounds(){} // RVA: 0x7FFAC8DB7210
        public void EmitNewArrayInit(){} // RVA: 0x7FFAC8DB72D0
        public void EmitAdd(){} // RVA: 0x7FFAC8DB7390
        public void EmitSub(){} // RVA: 0x7FFAC8DB73D0
        public void EmitMul(){} // RVA: 0x7FFAC8DB7410
        public void EmitDiv(){} // RVA: 0x7FFAC8DB7450
        public void EmitModulo(){} // RVA: 0x7FFAC8DB7480
        public void EmitExclusiveOr(){} // RVA: 0x7FFAC8DB74B0
        public void EmitAnd(){} // RVA: 0x7FFAC8DB74E0
        public void EmitOr(){} // RVA: 0x7FFAC8DB7510
        public void EmitLeftShift(){} // RVA: 0x7FFAC8DB7540
        public void EmitRightShift(){} // RVA: 0x7FFAC8DB7570
        public void EmitEqual(){} // RVA: 0x7FFAC8DB75A0
        public void EmitNotEqual(){} // RVA: 0x7FFAC8DB75E0
        public void EmitLessThan(){} // RVA: 0x7FFAC8DB7620
        public void EmitLessThanOrEqual(){} // RVA: 0x7FFAC8DB7660
        public void EmitGreaterThan(){} // RVA: 0x7FFAC8DB76A0
        public void EmitGreaterThanOrEqual(){} // RVA: 0x7FFAC8DB76E0
        public void EmitNumericConvertChecked(){} // RVA: 0x7FFAC8DB7720
        public void EmitNumericConvertUnchecked(){} // RVA: 0x7FFAC8DB77A0
        public void EmitConvertToUnderlying(){} // RVA: 0x7FFAC8DB7820
        public void EmitCast(){} // RVA: 0x7FFAC8DB7890
        public void EmitCastToEnum(){} // RVA: 0x7FFAC8DB78C0
        public void EmitCastReferenceToEnum(){} // RVA: 0x7FFAC8DB7970
        public void EmitNot(){} // RVA: 0x7FFAC8DB7A20
        public void EmitDefaultValue(){} // RVA: 0x7FFAC8DB7A50
        public void EmitNew(){} // RVA: 0x7FFAC8DB7B00
        public void EmitByRefNew(){} // RVA: 0x7FFAC8DB7BD0
        public void EmitCreateDelegate(){} // RVA: 0x7FFAC8DB7D10
        public void EmitTypeEquals(){} // RVA: 0x7FFAC8DB7DC0
        public void EmitArrayLength(){} // RVA: 0x7FFAC8DB7E30
        public void EmitNegate(){} // RVA: 0x7FFAC8DB7EA0
        public void EmitNegateChecked(){} // RVA: 0x7FFAC8DB7ED0
        public void EmitIncrement(){} // RVA: 0x7FFAC8DB7F00
        public void EmitDecrement(){} // RVA: 0x7FFAC8DB7F30
        public void EmitTypeIs(){} // RVA: 0x7FFAC8DB7F60
        public void EmitTypeAs(){} // RVA: 0x7FFAC8DB8010
        public void EmitLoadField(){} // RVA: 0x7FFAC8DB80C0
        public void GetLoadField(){} // RVA: 0x7FFAC8DB80F0
        public void EmitStoreField(){} // RVA: 0x7FFAC8DB84B0
        public void EmitCall(){} // RVA: 0x7FFAC8DB8690 | overloaded x2
        public void EmitByRefCall(){} // RVA: 0x7FFAC8DB86C0
        public void EmitNullableCall(){} // RVA: 0x7FFAC8DB8820
        public void BuildRuntimeLabels(){} // RVA: 0x7FFAC8DB8890
        public void MakeLabel(){} // RVA: 0x7FFAC8DB8B10
        public void FixupBranch(){} // RVA: 0x7FFAC8DB8C80
        public void EnsureLabelIndex(){} // RVA: 0x7FFAC8DB8E20
        public void MarkRuntimeLabel(){} // RVA: 0x7FFAC8DB8E50
        public void MarkLabel(){} // RVA: 0x7FFAC8DB8EA0
        public void EmitGoto(){} // RVA: 0x7FFAC8DB8ED0
        public void EmitBranch(){} // RVA: 0x7FFAC8DB9310 | overloaded x3
        public void EmitCoalescingBranch(){} // RVA: 0x7FFAC8DB93A0
        public void EmitBranchTrue(){} // RVA: 0x7FFAC8DB9400
        public void EmitBranchFalse(){} // RVA: 0x7FFAC8DB9460
        public void EmitThrow(){} // RVA: 0x7FFAC8DB94C0
        public void EmitThrowVoid(){} // RVA: 0x7FFAC8DB9530
        public void EmitRethrow(){} // RVA: 0x7FFAC8DB95A0
        public void EmitRethrowVoid(){} // RVA: 0x7FFAC8DB9610
        public void EmitEnterTryFinally(){} // RVA: 0x7FFAC8DB9680
        public void EmitEnterTryCatch(){} // RVA: 0x7FFAC8DB9700
        public void EmitEnterTryFault(){} // RVA: 0x7FFAC8DB9760
        public void EmitEnterFinally(){} // RVA: 0x7FFAC8DB97F0
        public void EmitLeaveFinally(){} // RVA: 0x7FFAC8DB9990
        public void EmitEnterFault(){} // RVA: 0x7FFAC8DB9A00
        public void EmitLeaveFault(){} // RVA: 0x7FFAC8DB9BA0
        public void EmitEnterExceptionFilter(){} // RVA: 0x7FFAC8DB9C10
        public void EmitLeaveExceptionFilter(){} // RVA: 0x7FFAC8DB9C80
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7FFAC8DB9CF0
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7FFAC8DB9D60
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7FFAC8DB9DD0
        public void EmitIntSwitch(){} // RVA: 0x7FFAC2C70A40
        public void EmitStringSwitch(){} // RVA: 0x7FFAC8DB9F90
        public void .ctor(){} // RVA: 0x7FFAC8DBA0A0
        public void .cctor(){} // RVA: 0x7FFAC8DBA160
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        public System.Collections.Generic.Dictionary`2<T,int> InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_InstructionName(){} // RVA: 0x7FFAC2C58E90
        public void get_ConsumedStack(){} // RVA: 0x7FFAC2C59960
        public void Run(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class InterpretedFrame : Object
    {
        public System.Linq.Expressions.Interpreter.InterpretedFrame Name; // 0xFFFF
        public System.Linq.Expressions.Interpreter.Interpreter Parent; // 0x10
        public System.Linq.Expressions.Interpreter.InterpretedFrame _parent; // 0x18
        public int[] _continuations; // 0x20
        public int _continuationIndex; // 0x28
        public int _pendingContinuation; // 0x2C
        public object _pendingValue; // 0x30
        public object[] Data; // 0x38
        public System.Runtime.CompilerServices.IStrongBox[] Closure; // 0x40
        public int StackIndex; // 0x48
        public int InstructionIndex; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DBAE00
        public void GetDebugInfo(){} // RVA: 0x7FFAC8DBB0A0
        public void get_Name(){} // RVA: 0x7FFAC8DBB230
        public void Push(){} // RVA: 0x7FFAC8DBB690 | overloaded x7
        public void Pop(){} // RVA: 0x7FFAC8DBB750
        public void SetStackDepth(){} // RVA: 0x7FFAC8DBB790
        public void Peek(){} // RVA: 0x7FFAC8DBB7B0
        public void Dup(){} // RVA: 0x7FFAC8DBB7E0
        public void get_Parent(){} // RVA: 0x7FFAC2F247C0
        public void IsInterpretedFrame(){} // RVA: 0x7FFAC8DBB880
        public void GetStackTraceDebugInfo(){} // RVA: 0x7FFAC8DBB9E0
        public void SaveTraceToException(){} // RVA: 0x7FFAC8DBBA90
        public void GetExceptionStackTrace(){} // RVA: 0x7FFAC8DBBDD0
        public void Enter(){} // RVA: 0x7FFAC8DBBF00
        public void Leave(){} // RVA: 0x7FFAC8DBC0A0
        public void IsJumpHappened(){} // RVA: 0x7FFAC8DBC1B0
        public void RemoveContinuation(){} // RVA: 0x7FFAC6CD5640
        public void PushContinuation(){} // RVA: 0x7FFAC8DBC1C0
        public void YieldToCurrentContinuation(){} // RVA: 0x7FFAC8DBC200
        public void YieldToPendingContinuation(){} // RVA: 0x7FFAC8DBC280
        public void PushPendingContinuation(){} // RVA: 0x7FFAC8DBC4B0
        public void PopPendingContinuation(){} // RVA: 0x7FFAC8DBC5E0
        public void Goto(){} // RVA: 0x7FFAC8DBC6E0
    }

    public class InterpretedFrameInfo : ValueType
    {
        public string _methodName; // 0x10
        public System.Linq.Expressions.Interpreter.DebugInfo _debugInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void ToString(){} // RVA: 0x7FFAC8DC3DD0
    }

    public class Interpreter : Object
    {
        public object Name;
        public int LocalCount;
        public System.Linq.Expressions.Interpreter.InstructionArray ClosureSize; // 0x10
        public object[] Instructions; // 0x38
        public System.Linq.Expressions.Interpreter.RuntimeLabel[] ClosureVariables; // 0x40
        public System.Linq.Expressions.Interpreter.DebugInfo[] _debugInfos; // 0x48
        public string <Name>k__BackingField; // 0x50
        public int <LocalCount>k__BackingField; // 0x58
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> <ClosureVariables>k__BackingField; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DBCD90
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void get_LocalCount(){} // RVA: 0x7FFAC362EA40
        public void get_ClosureSize(){} // RVA: 0x7FFAC8DBCFD0
        public void get_Instructions(){} // RVA: 0x7FFAC3813C20
        public void get_ClosureVariables(){} // RVA: 0x7FFAC2FBF370
        public void Run(){} // RVA: 0x7FFAC8DBD020
        public void .cctor(){} // RVA: 0x7FFAC8DBD090
    }

}