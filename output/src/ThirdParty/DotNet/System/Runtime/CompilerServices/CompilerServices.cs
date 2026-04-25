// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 49
// Methods: 261

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class AsyncIteratorMethodBuilder : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder _methodBuilder; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD53E73350
        public void MoveNext(){} // RVA: 0x7FFD4E090A40
        public void Complete(){} // RVA: 0x7FFD53E73400
    }

    public class AsyncMethodBuilderAttribute : Attribute
    {
        public System.Type BuilderType; // 0x10

        // ── Methods ──
        public void get_BuilderType(){} // RVA: 0x7FFD4E35C380
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AsyncMethodBuilderCore : ValueType
    {
        public System.Runtime.CompilerServices.IAsyncStateMachine m_stateMachine; // 0x10
        public System.Action m_defaultContextAction; // 0x18

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E090A10
        public void SetStateMachine(){} // RVA: 0x7FFD538FE530
        public void GetCompletionAction(){} // RVA: 0x7FFD538FE640
        public void OutputAsyncCausalityEvents(){} // RVA: 0x7FFD538FE860
        public void PostBoxInitialization(){} // RVA: 0x7FFD538FE9D0
        public void ThrowAsync(){} // RVA: 0x7FFD538FEB60
        public void CreateContinuationWrapper(){} // RVA: 0x7FFD538FF020
        public void TryGetContinuationTask(){} // RVA: 0x7FFD538FF240
    }

    public class AsyncTaskCache : Object
    {
        public System.Threading.Tasks.Task`1<bool> TrueTask;
        public System.Threading.Tasks.Task`1<bool> FalseTask; // 0x8
        public System.Threading.Tasks.Task`1<int>[] Int32Tasks; // 0x10

        // ── Methods ──
        public void CreateInt32Tasks(){} // RVA: 0x7FFD538FE1A0
        public void CreateCacheableTask(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD538FE380
    }

    public class AsyncTaskMethodBuilder : ValueType
    {
        public System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> Task;
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult> m_builder; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD51C6A7D0
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD538FDEC0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void get_Task(){} // RVA: 0x7FFD538FDF30
        public void SetResult(){} // RVA: 0x7FFD538FDFA0
        public void SetException(){} // RVA: 0x7FFD538FE050
        public void .cctor(){} // RVA: 0x7FFD538FE0D0
    }

    public class AsyncTaskMethodBuilder`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> Task;
        public System.Runtime.CompilerServices.AsyncMethodBuilderCore m_coreState; // 0x10
        public System.Threading.Tasks.Task`1<System.ValueTuple`2<VRC.Core.ApiWorld,VRC.Core.ApiContainer>> m_task; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void get_Task(){} // RVA: 0x7FFD4E078E90
        public void SetResult(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void SetException(){} // RVA: 0x7FFD4E090A40
        public void GetTaskForResult(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AsyncValueTaskMethodBuilder : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder Task; // 0x10
        public bool _haveResult; // 0x28
        public bool _useBuilder; // 0x29

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD52E53140
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD53F21570
        public void SetResult(){} // RVA: 0x7FFD53F215D0
        public void SetException(){} // RVA: 0x7FFD53F21630
        public void get_Task(){} // RVA: 0x7FFD53F21690
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
    }

    public class AsyncValueTaskMethodBuilder`1 : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> Task;
        public T _result;
        public bool _haveResult;
        public bool _useBuilder;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void SetResult(){} // RVA: 0x7FFD4E2ADC40
        public void SetException(){} // RVA: 0x7FFD4E090A40
        public void get_Task(){} // RVA: 0x7FFD4E2ADC40
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
    }

    public class AsyncVoidMethodBuilder : ValueType
    {
        public System.Threading.SynchronizationContext Task; // 0x10
        public System.Runtime.CompilerServices.AsyncMethodBuilderCore m_coreState; // 0x18
        public System.Threading.Tasks.Task m_task; // 0x28

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD538FDC40
        public void Start(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD538FDCE0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4E099B30
        public void SetResult(){} // RVA: 0x7FFD538FDCF0
        public void SetException(){} // RVA: 0x7FFD538FDD00
        public void NotifySynchronizationContextOfCompletion(){} // RVA: 0x7FFD538FDDD0
        public void get_Task(){} // RVA: 0x7FFD538FDE20
    }

    public class CallSite : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`2<System.Runtime.CompilerServices.CallSiteBinder,System.Runtime.CompilerServices.CallSite>> Binder;
        public System.Runtime.CompilerServices.CallSiteBinder _binder; // 0x10
        public bool _match; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_Binder(){} // RVA: 0x7FFD4E35C380
        public void Create(){} // RVA: 0x7FFD54215170
    }

    public class CallSiteBinder : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,object> UpdateLabel; // 0x10
        public 0x6654CA68 <UpdateLabel>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_UpdateLabel(){} // RVA: 0x7FFD54215830
        public void Bind(){} // RVA: 0x7FFD4E08AE80
        public void BindDelegate(){} // RVA: 0x7FFD4E2ADC40
        public void BindCore(){} // RVA: 0x7FFD4E2ADC40
        public void CacheTarget(){} // RVA: 0x7FFD4E2ADC40
        public void Stitch(){} // RVA: 0x7FFD4E078FF0
        public void GetRuleCache(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD54215890
    }

    public class CallSiteOps : Object
    {
        // ── Methods ──
        public void CreateMatchmaker(){} // RVA: 0x7FFD4E078F80
        public void SetNotMatched(){} // RVA: 0x7FFD54215A40
        public void GetMatch(){} // RVA: 0x7FFD51B0BEA0
        public void ClearMatch(){} // RVA: 0x7FFD54215A60
        public void AddRule(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateRules(){} // RVA: 0x7FFD4E096370
        public void GetRules(){} // RVA: 0x7FFD4E078F80
        public void GetRuleCache(){} // RVA: 0x7FFD4E078F80
        public void MoveRule(){} // RVA: 0x7FFD4E2ADC40
        public void GetCachedRules(){} // RVA: 0x7FFD4E078F80
        public void Bind(){} // RVA: 0x7FFD4E2ADC40
    }

    public class CallSite`1 : CallSite
    {
        public T Update;
        public T[] Rules;
        public T s_cachedUpdate;
        public T s_cachedNoMatch;

        // ── Methods ──
        public void get_Update(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void CreateMatchMaker(){} // RVA: 0x7FFD4E078E90
        public void Create(){} // RVA: 0x7FFD4E078F80
        public void GetUpdateDelegate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AddRule(){} // RVA: 0x7FFD4E2ADC40
        public void MoveRule(){} // RVA: 0x7FFD4E090ED0
        public void MakeUpdateDelegate(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCustomUpdateDelegate(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCustomNoMatchDelegate(){} // RVA: 0x7FFD4E2ADC40
        public void Convert(){} // RVA: 0x7FFD4E078FF0
    }

    public class CompilationRelaxationsAttribute : Attribute
    {
        public int CompilationRelaxations; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0 | overloaded x2
        public void get_CompilationRelaxations(){} // RVA: 0x7FFD4E38E5C0
    }

    public class CompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ConditionalWeakTable`2 : Object
    {
        public int INITIAL_SIZE;
        public float LOAD_FACTOR;
        public float COMPACT_FACTOR;
        public float EXPAND_FACTOR;
        public 0x66437700[] data; // 0x10
        public object _lock; // 0x18
        public int size; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Finalize(){} // RVA: 0x7FFD4E090980
        public void RehashWithoutResize(){} // RVA: 0x7FFD4E090980
        public void RecomputeSize(){} // RVA: 0x7FFD4E090980
        public void Rehash(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetOrCreateValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public ConfiguredTaskAwaiter<VRC.Core.ApiInventoryItem> m_configuredTaskAwaiter; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E096500
        public void GetAwaiter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public System.Threading.Tasks.ValueTask`1<bool> _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAwaiter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class CustomConstantAttribute : Attribute
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DateTimeConstantAttribute : CustomConstantAttribute
    {
        public System.DateTime Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD538FC1D0
    }

    public class DecimalConstantAttribute : Attribute
    {
        public System.Decimal Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538FC220
        public void get_Value(){} // RVA: 0x7FFD4F842E80
    }

    public class DefaultDependencyAttribute : Attribute
    {
        public 0x664373E8 loadHint; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class DefaultInterpolatedStringHandler : ValueType
    {
        public System.IFormatProvider Text; // 0x10
        public char[] _arrayToReturnToPool; // 0x18
        public System.Span`1<char> _chars; // 0x20
        public int _pos; // 0x30
        public bool _hasCustomFormatter; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD575030F0
        public void GetDefaultLength(){} // RVA: 0x7FFD57503250
        public void ToString(){} // RVA: 0x7FFD575032B0
        public void ToStringAndClear(){} // RVA: 0x7FFD57503310
        public void Clear(){} // RVA: 0x7FFD57503410
        public void get_Text(){} // RVA: 0x7FFD575034C0
        public void AppendLiteral(){} // RVA: 0x7FFD57503580
        public void AppendFormatted(){} // RVA: 0x7FFD575037A0 | overloaded x5
        public void AppendCustomFormatter(){} // RVA: 0x7FFD4E2ADC40
        public void AppendOrInsertAlignmentIfNeeded(){} // RVA: 0x7FFD57503820
        public void EnsureCapacityForAdditionalChars(){} // RVA: 0x7FFD57503AA0
        public void GrowThenCopyString(){} // RVA: 0x7FFD57503B00
        public void Grow(){} // RVA: 0x7FFD57503C80
        public void GrowCore(){} // RVA: 0x7FFD57503C90
    }

    public class DependencyAttribute : Attribute
    {
        public string dependentAssembly; // 0x10
        public 0x664373E8 loadHint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCAC310
    }

    public class ExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class FixedBufferAttribute : Attribute
    {
        public System.Type ElementType; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCAC310
        public void get_ElementType(){} // RVA: 0x7FFD4E35C380
        public void get_Length(){} // RVA: 0x7FFD4E577800
    }

    public class IAsyncStateMachine
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
    }

    public class ICriticalNotifyCompletion
    {
        // ── Methods ──
        public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
    }

    public class INotifyCompletion
    {
        // ── Methods ──
        public void OnCompleted(){} // RVA: 0x7FFD4E090A40
    }

    public class IStrongBox
    {
        public <>c<T> Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E078E90
        public void set_Value(){} // RVA: 0x7FFD4E090A40
    }

    public class ITuple
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class InternalsVisibleToAttribute : Attribute
    {
        public string AllInternalsVisible; // 0x10
        public bool _allInternalsVisible; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538FFEC0
        public void set_AllInternalsVisible(){} // RVA: 0x7FFD4E35C4F0
    }

    public class InterpolatedStringHandlerArgumentAttribute : Attribute
    {
        public string[] <Arguments>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552800E0
    }

    public class JitHelpers : Object
    {
        // ── Methods ──
        public void UnsafeCast(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeEnumCast(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeEnumCastLong(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NullableAttribute : Attribute
    {
        public byte[] NullableFlags; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class NullableContextAttribute : Attribute
    {
        public byte Flag; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E40B5F0
    }

    public class ReadOnlyCollectionBuilder`1 : Object
    {
        public T[] Capacity;
        public int Count;
        public int Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void ToReadOnlyCollection(){} // RVA: 0x7FFD4E078E90
        public void EnsureCapacity(){} // RVA: 0x7FFD4E090ED0
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
        public void ValidateNullValue(){} // RVA: 0x7FFD4E090C80
    }

    public class RuleCache`1 : Object
    {
        public T[] _rules;
        public T _cacheLock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetRules(){} // RVA: 0x7FFD4E078E90
        public void MoveRule(){} // RVA: 0x7FFD4E2ADC40
        public void AddRule(){} // RVA: 0x7FFD4E2ADC40
        public void AddOrInsert(){} // RVA: 0x7FFD4E2ADC40
    }

    public class RuntimeCompatibilityAttribute : Attribute
    {
        public bool WrapNonExceptionThrows; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void set_WrapNonExceptionThrows(){} // RVA: 0x7FFD4E40B5F0
    }

    public class RuntimeHelpers : Object
    {
        public object OffsetToStringData;

        // ── Methods ──
        public void InitializeArray(){} // RVA: 0x7FFD53900110 | overloaded x2
        public void get_OffsetToStringData(){} // RVA: 0x7FFD4E5B5EF0
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void GetObjectValue(){} // RVA: 0x7FFD539002B0
        public void RunClassConstructor(){} // RVA: 0x7FFD53900320 | overloaded x2
        public void SufficientExecutionStack(){} // RVA: 0x7FFD4E426850
        public void EnsureSufficientExecutionStack(){} // RVA: 0x7FFD4E341310
        public void TryEnsureSufficientExecutionStack(){} // RVA: 0x7FFD4E426850
        public void PrepareConstrainedRegions(){} // RVA: 0x7FFD4E341310
        public void PrepareDelegate(){} // RVA: 0x7FFD4E341310
        public void IsReferenceOrContainsReferences(){} // RVA: 0x7FFD4E079D30
        public void GetUninitializedObject(){} // RVA: 0x7FFD53759860
    }

    public class StringFreezingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class StrongBox`1 : Object
    {
        public System.DateTime System.Runtime.CompilerServices.IStrongBox.Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void System.Runtime.CompilerServices.IStrongBox.get_Value(){} // RVA: 0x7FFD4E078E90
        public void System.Runtime.CompilerServices.IStrongBox.set_Value(){} // RVA: 0x7FFD4E090A40
    }

    public class SuppressIldasmAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TaskAwaiter : ValueType
    {
        public System.Threading.Tasks.Task IsCompleted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void get_IsCompleted(){} // RVA: 0x7FFD508B0100
        public void OnCompleted(){} // RVA: 0x7FFD51DFEB80
        public void UnsafeOnCompleted(){} // RVA: 0x7FFD51DFEC30
        public void GetResult(){} // RVA: 0x7FFD538FD2F0
        public void ValidateEnd(){} // RVA: 0x7FFD538FD330
        public void HandleNonSuccessAndDebuggerNotification(){} // RVA: 0x7FFD538FD370
        public void ThrowForNonSuccess(){} // RVA: 0x7FFD538FD580
        public void OnCompletedInternal(){} // RVA: 0x7FFD538FD6E0
        public void OutputWaitEtwEvents(){} // RVA: 0x7FFD538FD7B0
    }

    public class TaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<0x66499EC0[]> IsCompleted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void OnCompleted(){} // RVA: 0x7FFD4E090A40
        public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TrueReadOnlyCollection`1 : ReadOnlyCollection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void ReadUnaligned(){} // RVA: 0x7FFD4E2ADC40
        public void WriteUnaligned(){} // RVA: 0x7FFD4E2ADC40
        public void AsPointer(){} // RVA: 0x7FFD4E2ADC40
        public void SizeOf(){} // RVA: 0x7FFD4E079990
        public void CopyBlock(){} // RVA: 0x7FFD53882EF0
        public void InitBlockUnaligned(){} // RVA: 0x7FFD539003B0 | overloaded x2
        public void As(){} // RVA: 0x7FFD4E078F80 | overloaded x2
        public void AsRef(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E07EA50 | overloaded x2
        public void AddByteOffset(){} // RVA: 0x7FFD4E07EA50
        public void ByteOffset(){} // RVA: 0x7FFD4E2ADC40
        public void AreSame(){} // RVA: 0x7FFD4E07A350
    }

    public class ValueTaskAwaiter : ValueType
    {
        public System.Action`1<object> IsCompleted;
        public System.Threading.Tasks.ValueTask _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FEC1C40
        public void get_IsCompleted(){} // RVA: 0x7FFD538FCB00
        public void GetResult(){} // RVA: 0x7FFD538FCB50
        public void OnCompleted(){} // RVA: 0x7FFD538FCBA0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFD538FCE30
        public void .cctor(){} // RVA: 0x7FFD538FD0C0
    }

    public class ValueTaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.ValueTask`1<bool> IsCompleted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void OnCompleted(){} // RVA: 0x7FFD4E090A40
        public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
    }

}