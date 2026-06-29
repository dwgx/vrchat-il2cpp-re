// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 12
// Methods: 176

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class IBoxableInstruction
    {
        // ── Methods ──
        public void BoxIfIndexMatches(){} // RVA: 0x87C160
    }

    public class IncrementInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7089A10
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7089A50
    }

    public class IndexMethodByRefUpdater : ByRefUpdater
    {
        public object _indexer;
        public object _obj;
        public object _args;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70ADB90
        public void Update(){} // RVA: 0x70ADCB0
        public void UndefineTemps(){} // RVA: 0x70ADF40
    }

    public class IndexedBranchInstruction : Instruction
    {
        public object CacheSize;
        public object _labelIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void GetLabel(){} // RVA: 0x707E960
        public void ToDebugString(){} // RVA: 0x707E9C0
        public void ToString(){} // RVA: 0x707EB10
    }

    public class InitializeLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class Instruction : Object
    {
        public object UnknownInstrIndex;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xDAC980
        public void get_ProducedStack(){} // RVA: 0xDAC980
        public void get_ConsumedContinuations(){} // RVA: 0xDAC980
        public void get_ProducedContinuations(){} // RVA: 0xDAC980
        public void get_StackBalance(){} // RVA: 0x708A7F0
        public void get_ContinuationsBalance(){} // RVA: 0x708A840
        public void Run(){} // RVA: 0x87D050
        public void get_InstructionName(){} // RVA: 0x87C0A0
        public void ToString(){} // RVA: 0x708A890
        public void ToDebugString(){} // RVA: 0x6871D20
        public void GetDebugCookie(){} // RVA: 0xDAC980
        public void NullCheck(){} // RVA: 0x5A94920
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InstructionArray : ValueType
    {
        public object MaxStackDepth;
        public object MaxContinuationDepth;
        public object Instructions;
        public object Objects;
        public object Labels;
        public object DebugCookies;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8FE470
    }

    public class InstructionList : Object
    {
        public object _instructions;
        public object _objects;
        public object _currentStackDepth;
        public object _maxStackDepth;
        public object _currentContinuationsDepth;
        public object _maxContinuationDepth;
        public object _runtimeLabelCount;
        public object _labels;
        public object _debugCookies;
        public object PushIntMinCachedValue;
        public object PushIntMaxCachedValue;
        public object CachedObjectCount;
        public object s_null;
        public object s_true;
        public object s_false;
        public object s_Ints;
        public object s_loadObjectCached;
        public object LocalInstrCacheSize;
        public object s_loadLocal;
        public object s_loadLocalBoxed;
        public object s_loadLocalFromClosure;
        public object s_loadLocalFromClosureBoxed;
        public object s_assignLocal;
        public object s_storeLocal;
        public object s_assignLocalBoxed;
        public object s_storeLocalBoxed;
        public object s_assignLocalToClosure;
        public object s_loadFields;
        public object s_emptyRuntimeLabels;

        // ── Methods ──
        public void Emit(){} // RVA: 0x708AC90
        public void UpdateStackDepth(){} // RVA: 0x708ADD0
        public void UnEmit(){} // RVA: 0x708AE90
        public void SetDebugCookie(){} // RVA: 0xB43310
        public void get_Count(){} // RVA: 0x708AFF0
        public void get_CurrentStackDepth(){} // RVA: 0xFEAE90
        public void get_CurrentContinuationsDepth(){} // RVA: 0x1065D50
        public void get_MaxStackDepth(){} // RVA: 0x15AF000
        public void GetInstruction(){} // RVA: 0x708B040
        public void ToArray(){} // RVA: 0x708B0C0
        public void EmitLoad(){} // RVA: 0x708B470
        public void EmitDup(){} // RVA: 0x708BA90
        public void EmitPop(){} // RVA: 0x708BB00
        public void SwitchToBoxed(){} // RVA: 0x708BB70
        public void EmitLoadLocal(){} // RVA: 0x708BC60
        public void EmitLoadLocalBoxed(){} // RVA: 0x708BEA0
        public void LoadLocalBoxed(){} // RVA: 0x708BF10
        public void EmitLoadLocalFromClosure(){} // RVA: 0x708C140
        public void EmitLoadLocalFromClosureBoxed(){} // RVA: 0x708C380
        public void EmitAssignLocal(){} // RVA: 0x708C5C0
        public void EmitStoreLocal(){} // RVA: 0x708C800
        public void EmitAssignLocalBoxed(){} // RVA: 0x708CA40
        public void AssignLocalBoxed(){} // RVA: 0x708CAB0
        public void EmitStoreLocalBoxed(){} // RVA: 0x708CCE0
        public void StoreLocalBoxed(){} // RVA: 0x708CD50
        public void EmitAssignLocalToClosure(){} // RVA: 0x708CF80
        public void EmitStoreLocalToClosure(){} // RVA: 0x708D1C0
        public void EmitInitializeLocal(){} // RVA: 0x708D230
        public void EmitInitializeParameter(){} // RVA: 0x708D430
        public void Parameter(){} // RVA: 0x708D4C0
        public void ParameterBox(){} // RVA: 0x708D500
        public void InitReference(){} // RVA: 0x708D540
        public void InitImmutableRefBox(){} // RVA: 0x708D580
        public void EmitNewRuntimeVariables(){} // RVA: 0x708D5C0
        public void EmitGetArrayItem(){} // RVA: 0x708D620
        public void EmitSetArrayItem(){} // RVA: 0x708D690
        public void EmitNewArray(){} // RVA: 0x708D700
        public void EmitNewArrayBounds(){} // RVA: 0x708D7B0
        public void EmitNewArrayInit(){} // RVA: 0x708D870
        public void EmitAdd(){} // RVA: 0x708D930
        public void EmitSub(){} // RVA: 0x708D970
        public void EmitMul(){} // RVA: 0x708D9B0
        public void EmitDiv(){} // RVA: 0x708D9F0
        public void EmitModulo(){} // RVA: 0x708DA20
        public void EmitExclusiveOr(){} // RVA: 0x708DA50
        public void EmitAnd(){} // RVA: 0x708DA80
        public void EmitOr(){} // RVA: 0x708DAB0
        public void EmitLeftShift(){} // RVA: 0x708DAE0
        public void EmitRightShift(){} // RVA: 0x708DB10
        public void EmitEqual(){} // RVA: 0x708DB40
        public void EmitNotEqual(){} // RVA: 0x708DB80
        public void EmitLessThan(){} // RVA: 0x708DBC0
        public void EmitLessThanOrEqual(){} // RVA: 0x708DC00
        public void EmitGreaterThan(){} // RVA: 0x708DC40
        public void EmitGreaterThanOrEqual(){} // RVA: 0x708DC80
        public void EmitNumericConvertChecked(){} // RVA: 0x708DCC0
        public void EmitNumericConvertUnchecked(){} // RVA: 0x708DD40
        public void EmitConvertToUnderlying(){} // RVA: 0x708DDC0
        public void EmitCast(){} // RVA: 0x708DE30
        public void EmitCastToEnum(){} // RVA: 0x708DE60
        public void EmitCastReferenceToEnum(){} // RVA: 0x708DF10
        public void EmitNot(){} // RVA: 0x708DFC0
        public void EmitDefaultValue(){} // RVA: 0x708DFF0
        public void EmitNew(){} // RVA: 0x708E0A0
        public void EmitByRefNew(){} // RVA: 0x708E170
        public void EmitCreateDelegate(){} // RVA: 0x708E2B0
        public void EmitTypeEquals(){} // RVA: 0x708E360
        public void EmitArrayLength(){} // RVA: 0x708E3D0
        public void EmitNegate(){} // RVA: 0x708E440
        public void EmitNegateChecked(){} // RVA: 0x708E470
        public void EmitIncrement(){} // RVA: 0x708E4A0
        public void EmitDecrement(){} // RVA: 0x708E4D0
        public void EmitTypeIs(){} // RVA: 0x708E500
        public void EmitTypeAs(){} // RVA: 0x708E5B0
        public void EmitLoadField(){} // RVA: 0x708E660
        public void GetLoadField(){} // RVA: 0x708E690
        public void EmitStoreField(){} // RVA: 0x708EA20
        public void EmitCall(){} // RVA: 0x708EC00
        public void EmitByRefCall(){} // RVA: 0x708EC30
        public void EmitNullableCall(){} // RVA: 0x708ED90
        public void BuildRuntimeLabels(){} // RVA: 0x708EE00
        public void MakeLabel(){} // RVA: 0x708F090
        public void FixupBranch(){} // RVA: 0x708F200
        public void EnsureLabelIndex(){} // RVA: 0x708F3A0
        public void MarkRuntimeLabel(){} // RVA: 0x708F3D0
        public void MarkLabel(){} // RVA: 0x708F420
        public void EmitGoto(){} // RVA: 0x708F450
        public void EmitBranch(){} // RVA: 0x708F740
        public void EmitCoalescingBranch(){} // RVA: 0x708F7D0
        public void EmitBranchTrue(){} // RVA: 0x708F830
        public void EmitBranchFalse(){} // RVA: 0x708F890
        public void EmitThrow(){} // RVA: 0x708F8F0
        public void EmitThrowVoid(){} // RVA: 0x708F960
        public void EmitRethrow(){} // RVA: 0x708F9D0
        public void EmitRethrowVoid(){} // RVA: 0x708FA40
        public void EmitEnterTryFinally(){} // RVA: 0x708FAB0
        public void EmitEnterTryCatch(){} // RVA: 0x708FB30
        public void EmitEnterTryFault(){} // RVA: 0x708FB90
        public void EmitEnterFinally(){} // RVA: 0x708FC20
        public void EmitLeaveFinally(){} // RVA: 0x708FDC0
        public void EmitEnterFault(){} // RVA: 0x708FE30
        public void EmitLeaveFault(){} // RVA: 0x708FFD0
        public void EmitEnterExceptionFilter(){} // RVA: 0x7090040
        public void EmitLeaveExceptionFilter(){} // RVA: 0x70900B0
        public void EmitEnterExceptionHandlerNonVoid(){} // RVA: 0x7090120
        public void EmitEnterExceptionHandlerVoid(){} // RVA: 0x7090190
        public void EmitLeaveExceptionHandler(){} // RVA: 0x7090200
        public void EmitIntSwitch(){} // RVA: 0x894320
        public void EmitStringSwitch(){} // RVA: 0x70903E0
        public void .ctor(){} // RVA: 0x70904F0
        public void .cctor(){} // RVA: 0x70905B0
    }

    public class IntSwitchInstruction`1 : Instruction
    {
        public object _cases;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_InstructionName(){} // RVA: 0x87C0A0
        public void get_ConsumedStack(){} // RVA: 0x87C130
        public void Run(){} // RVA: 0x87D050
    }

    public class InterpretedFrame : Object
    {
        public object s_currentFrame;
        public object Interpreter;
        public object _parent;
        public object _continuations;
        public object _continuationIndex;
        public object _pendingContinuation;
        public object _pendingValue;
        public object Data;
        public object Closure;
        public object StackIndex;
        public object InstructionIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7091250
        public void GetDebugInfo(){} // RVA: 0x70914F0
        public void get_Name(){} // RVA: 0x17F09D0
        public void Push(){} // RVA: 0x7091A30
        public void Pop(){} // RVA: 0x7091AC0
        public void SetStackDepth(){} // RVA: 0x7091B00
        public void Peek(){} // RVA: 0x7091B20
        public void Dup(){} // RVA: 0x7091B50
        public void get_Parent(){} // RVA: 0xB465B0
        public void IsInterpretedFrame(){} // RVA: 0x7091BF0
        public void GetStackTraceDebugInfo(){} // RVA: 0x7091D20
        public void SaveTraceToException(){} // RVA: 0x7091DD0
        public void GetExceptionStackTrace(){} // RVA: 0x7092100
        public void Enter(){} // RVA: 0x7092200
        public void Leave(){} // RVA: 0x70923C0
        public void IsJumpHappened(){} // RVA: 0x70924D0
        public void RemoveContinuation(){} // RVA: 0x4F237E0
        public void PushContinuation(){} // RVA: 0x70924E0
        public void YieldToCurrentContinuation(){} // RVA: 0x7092520
        public void YieldToPendingContinuation(){} // RVA: 0x70925A0
        public void PushPendingContinuation(){} // RVA: 0x70927D0
        public void PopPendingContinuation(){} // RVA: 0x7092900
        public void Goto(){} // RVA: 0x70929E0
    }

    public class InterpretedFrameInfo : ValueType
    {
        public object _methodName;
        public object _debugInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void ToString(){} // RVA: 0x8FE870
    }

    public class Interpreter : Object
    {
        public object NoValue;
        public object RethrowOnReturn;
        public object _instructions;
        public object _objects;
        public object _labels;
        public object _debugInfos;
        public object _name;
        public object _localCount;
        public object _closureVariables;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7093080
        public void get_Name(){} // RVA: 0xBE58B0
        public void get_LocalCount(){} // RVA: 0x12BB630
        public void get_ClosureSize(){} // RVA: 0x70932C0
        public void get_Instructions(){} // RVA: 0x11E18A0
        public void get_ClosureVariables(){} // RVA: 0xBE2C60
        public void Run(){} // RVA: 0x7093310
        public void .cctor(){} // RVA: 0x7093380
    }

}