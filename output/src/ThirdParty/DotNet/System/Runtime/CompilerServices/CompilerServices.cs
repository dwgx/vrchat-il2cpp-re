// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 92
// Methods: 321

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class AsyncIteratorMethodBuilder : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder _methodBuilder; // 0x10
        public object _id; // 0x28

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC8A53350
        public void MoveNext(){} // RVA: 0x7FFAC2C70A40
        public void Complete(){} // RVA: 0x7FFAC8A53400
    }

    public class AsyncIteratorStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AsyncMethodBuilderAttribute : Attribute
    {
        public System.Type BuilderType; // 0x10

        // ── Methods ──
        public void get_BuilderType(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AsyncMethodBuilderCore : ValueType
    {
        public System.Runtime.CompilerServices.IAsyncStateMachine m_stateMachine; // 0x10
        public System.Action m_defaultContextAction; // 0x18

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2C70A10
        public void SetStateMachine(){} // RVA: 0x7FFAC84DE530
        public void GetCompletionAction(){} // RVA: 0x7FFAC84DE640
        public void OutputAsyncCausalityEvents(){} // RVA: 0x7FFAC84DE860
        public void PostBoxInitialization(){} // RVA: 0x7FFAC84DE9D0
        public void ThrowAsync(){} // RVA: 0x7FFAC84DEB60
        public void CreateContinuationWrapper(){} // RVA: 0x7FFAC84DF020
        public void TryGetContinuationTask(){} // RVA: 0x7FFAC84DF240
    }

    public class AsyncStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AsyncTaskCache : Object
    {
        public System.Threading.Tasks.Task`1<bool> TrueTask;
        public System.Threading.Tasks.Task`1<bool> FalseTask; // 0x8
        public System.Threading.Tasks.Task`1<int>[] Int32Tasks; // 0x10

        // ── Methods ──
        public void CreateInt32Tasks(){} // RVA: 0x7FFAC84DE1A0
        public void CreateCacheableTask(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC84DE380
    }

    public class AsyncTaskMethodBuilder : ValueType
    {
        public System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> Task;
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult> m_builder; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC684A7D0
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC84DDEC0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void get_Task(){} // RVA: 0x7FFAC84DDF30
        public void SetResult(){} // RVA: 0x7FFAC84DDFA0
        public void SetException(){} // RVA: 0x7FFAC84DE050
        public void .cctor(){} // RVA: 0x7FFAC84DE0D0
    }

    public class AsyncTaskMethodBuilder`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<T> Task;
        public System.Runtime.CompilerServices.AsyncMethodBuilderCore m_coreState;
        public System.Threading.Tasks.Task`1<T> m_task;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void get_Task(){} // RVA: 0x7FFAC2C58E90
        public void SetResult(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void SetException(){} // RVA: 0x7FFAC2C70A40
        public void GetTaskForResult(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AsyncValueTaskMethodBuilder : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder Task; // 0x10
        public bool _haveResult; // 0x28
        public bool _useBuilder; // 0x29

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC7A33140
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC8B01570
        public void SetResult(){} // RVA: 0x7FFAC8B015D0
        public void SetException(){} // RVA: 0x7FFAC8B01630
        public void get_Task(){} // RVA: 0x7FFAC8B01690
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
    }

    public class AsyncValueTaskMethodBuilder`1 : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> Task;
        public T _result;
        public bool _haveResult;
        public bool _useBuilder;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void SetResult(){} // RVA: 0x7FFAC2E8DC40
        public void SetException(){} // RVA: 0x7FFAC2C70A40
        public void get_Task(){} // RVA: 0x7FFAC2E8DC40
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
    }

    public class AsyncVoidMethodBuilder : ValueType
    {
        public System.Threading.SynchronizationContext Task; // 0x10
        public System.Runtime.CompilerServices.AsyncMethodBuilderCore m_coreState; // 0x18
        public System.Threading.Tasks.Task m_task; // 0x28

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC84DDC40
        public void Start(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC84DDCE0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC2C79B30
        public void SetResult(){} // RVA: 0x7FFAC84DDCF0
        public void SetException(){} // RVA: 0x7FFAC84DDD00
        public void NotifySynchronizationContextOfCompletion(){} // RVA: 0x7FFAC84DDDD0
        public void get_Task(){} // RVA: 0x7FFAC84DDE20
    }

    public class CallSite : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`2<System.Runtime.CompilerServices.CallSiteBinder,System.Runtime.CompilerServices.CallSite>> Binder;
        public System.Runtime.CompilerServices.CallSiteBinder _binder; // 0x10
        public bool _match; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Binder(){} // RVA: 0x7FFAC2F3C380
        public void Create(){} // RVA: 0x7FFAC8DF5170
    }

    public class CallSiteBinder : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,object> UpdateLabel; // 0x10
        public System.Linq.Expressions.LabelTarget <UpdateLabel>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_UpdateLabel(){} // RVA: 0x7FFAC8DF5830
        public void Bind(){} // RVA: 0x7FFAC2C6AE80
        public void BindDelegate(){} // RVA: 0x7FFAC2E8DC40
        public void BindCore(){} // RVA: 0x7FFAC2E8DC40
        public void CacheTarget(){} // RVA: 0x7FFAC2E8DC40
        public void Stitch(){} // RVA: 0x7FFAC2C58FF0
        public void GetRuleCache(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC8DF5890
    }

    public class CallSiteOps : Object
    {
        // ── Methods ──
        public void CreateMatchmaker(){} // RVA: 0x7FFAC2C58F80
        public void SetNotMatched(){} // RVA: 0x7FFAC8DF5A40
        public void GetMatch(){} // RVA: 0x7FFAC66EBEA0
        public void ClearMatch(){} // RVA: 0x7FFAC8DF5A60
        public void AddRule(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateRules(){} // RVA: 0x7FFAC2C76370
        public void GetRules(){} // RVA: 0x7FFAC2C58F80
        public void GetRuleCache(){} // RVA: 0x7FFAC2C58F80
        public void MoveRule(){} // RVA: 0x7FFAC2E8DC40
        public void GetCachedRules(){} // RVA: 0x7FFAC2C58F80
        public void Bind(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CallSite`1 : CallSite
    {
        public T Update;
        public T[] Rules;
        public T s_cachedUpdate;
        public T s_cachedNoMatch;

        // ── Methods ──
        public void get_Update(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void CreateMatchMaker(){} // RVA: 0x7FFAC2C58E90
        public void Create(){} // RVA: 0x7FFAC2C58F80
        public void GetUpdateDelegate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AddRule(){} // RVA: 0x7FFAC2E8DC40
        public void MoveRule(){} // RVA: 0x7FFAC2C70ED0
        public void MakeUpdateDelegate(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCustomUpdateDelegate(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCustomNoMatchDelegate(){} // RVA: 0x7FFAC2E8DC40
        public void Convert(){} // RVA: 0x7FFAC2C58FF0
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public string ParameterName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ParameterName(){} // RVA: 0x7FFAC2F3C380
    }

    public class CallerFilePathAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CallerLineNumberAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CallerMemberNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CompilationRelaxationsAttribute : Attribute
    {
        public int CompilationRelaxations; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void get_CompilationRelaxations(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public string FeatureName; // 0x10
        public bool IsOptional; // 0x18
        public string RefStructs;
        public string RequiredMembers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_FeatureName(){} // RVA: 0x7FFAC2F3C380
        public void get_IsOptional(){} // RVA: 0x7FFAC2F3C4E0
        public void set_IsOptional(){} // RVA: 0x7FFAC2F3C4F0
    }

    public class CompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ConditionalWeakTable`2 : Object
    {
        public int INITIAL_SIZE;
        public float LOAD_FACTOR;
        public float COMPACT_FACTOR;
        public float EXPAND_FACTOR;
        public System.Runtime.CompilerServices.Ephemeron[] data;
        public object _lock;
        public int size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Finalize(){} // RVA: 0x7FFAC2C70980
        public void RehashWithoutResize(){} // RVA: 0x7FFAC2C70980
        public void RecomputeSize(){} // RVA: 0x7FFAC2C70980
        public void Rehash(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void GetOrCreateValue(){} // RVA: 0x7FFAC2E8DC40
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class ConfiguredAsyncDisposable : ValueType
    {
        public System.IAsyncDisposable _source; // 0x10
        public bool _continueOnCapturedContext; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC37E8550
        public void DisposeAsync(){} // RVA: 0x7FFAC8A53450
    }

    public class ConfiguredTaskAwaitable : ValueType
    {
        public ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DDB80
        public void GetAwaiter(){} // RVA: 0x7FFAC32C0590
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public ConfiguredTaskAwaiter<T> m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C76500
        public void GetAwaiter(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ConfiguredValueTaskAwaitable : ValueType
    {
        public System.Threading.Tasks.ValueTask _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4AA1C40
        public void GetAwaiter(){} // RVA: 0x7FFAC84DBB90
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public System.Threading.Tasks.ValueTask`1<T> _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAwaiter(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CustomConstantAttribute : Attribute
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DateTimeConstantAttribute : CustomConstantAttribute
    {
        public System.DateTime Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC84DC1D0
    }

    public class DebugInfoGenerator : Object
    {
    }

    public class DecimalConstantAttribute : Attribute
    {
        public System.Decimal Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DC220
        public void get_Value(){} // RVA: 0x7FFAC4422E80
    }

    public class DefaultDependencyAttribute : Attribute
    {
        public 0x6B0D73E8 loadHint; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class DefaultInterpolatedStringHandler : ValueType
    {
        public System.IFormatProvider Text; // 0x10
        public char[] _arrayToReturnToPool; // 0x18
        public System.Span`1<char> _chars; // 0x20
        public int _pos; // 0x30
        public bool _hasCustomFormatter; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E30F0
        public void GetDefaultLength(){} // RVA: 0x7FFACC0E3250
        public void ToString(){} // RVA: 0x7FFACC0E32B0
        public void ToStringAndClear(){} // RVA: 0x7FFACC0E3310
        public void Clear(){} // RVA: 0x7FFACC0E3410
        public void get_Text(){} // RVA: 0x7FFACC0E34C0
        public void AppendLiteral(){} // RVA: 0x7FFACC0E3580
        public void AppendFormatted(){} // RVA: 0x7FFACC0E37A0 | overloaded x5
        public void AppendCustomFormatter(){} // RVA: 0x7FFAC2E8DC40
        public void AppendOrInsertAlignmentIfNeeded(){} // RVA: 0x7FFACC0E3820
        public void EnsureCapacityForAdditionalChars(){} // RVA: 0x7FFACC0E3AA0
        public void GrowThenCopyString(){} // RVA: 0x7FFACC0E3B00
        public void Grow(){} // RVA: 0x7FFACC0E3C80
        public void GrowCore(){} // RVA: 0x7FFACC0E3C90
    }

    public class DependencyAttribute : Attribute
    {
        public string dependentAssembly; // 0x10
        public 0x6B0D73E8 loadHint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

    public class DisableRuntimeMarshallingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DynamicAttribute : Attribute
    {
    }

    public class EnumeratorCancellationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Ephemeron : ValueType
    {
        public object key; // 0x10
        public object value; // 0x18
    }

    public class ExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FixedBufferAttribute : Attribute
    {
        public System.Type ElementType; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_ElementType(){} // RVA: 0x7FFAC2F3C380
        public void get_Length(){} // RVA: 0x7FFAC3157800
    }

    public class FormattableStringFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC84DC2E0
    }

    public class FriendAccessAllowedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IAsyncStateMachine
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
    }

    public class ICriticalNotifyCompletion
    {
        // ── Methods ──
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
    }

    public class INotifyCompletion
    {
        // ── Methods ──
        public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
    }

    public class IRuntimeVariables
    {
        public object Count;
        public object Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void set_Item(){} // RVA: 0x7FFAC2C72BC0
    }

    public class IStrongBox
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void set_Value(){} // RVA: 0x7FFAC2C70A40
    }

    public class ITuple
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2C59960
    }

    public class InternalsVisibleToAttribute : Attribute
    {
        public string AllInternalsVisible; // 0x10
        public bool _allInternalsVisible; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DFEC0
        public void set_AllInternalsVisible(){} // RVA: 0x7FFAC2F3C4F0
    }

    public class InterpolatedStringHandlerArgumentAttribute : Attribute
    {
        public string[] <Arguments>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E600E0
    }

    public class InterpolatedStringHandlerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IntrinsicAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IsByRefLikeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IsExternalInit : Object
    {
    }

    public class IsReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IsUnmanagedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IsVolatile : Object
    {
    }

    public class IteratorStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class JitHelpers : Object
    {
        // ── Methods ──
        public void UnsafeCast(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeEnumCast(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeEnumCastLong(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ModuleInitializerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeIntegerAttribute : Attribute
    {
        public bool[] TransformFlags; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class NullableAttribute : Attribute
    {
        public byte[] NullableFlags; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class NullableContextAttribute : Attribute
    {
        public byte Flag; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class NullablePublicOnlyAttribute : Attribute
    {
        public bool IncludesInternals; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class ReadOnlyCollectionBuilder`1 : Object
    {
        public T[] Capacity;
        public int Count;
        public int Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFAC2C70ED0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void ToReadOnlyCollection(){} // RVA: 0x7FFAC2C58E90
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void IsCompatibleObject(){} // RVA: 0x7FFAC2C59DE0
        public void ValidateNullValue(){} // RVA: 0x7FFAC2C70C80
    }

    public class RefSafetyRulesAttribute : Attribute
    {
        public int Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class ReflectionBlockedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RequiredMemberAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuleCache`1 : Object
    {
        public T[] _rules;
        public object _cacheLock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetRules(){} // RVA: 0x7FFAC2C58E90
        public void MoveRule(){} // RVA: 0x7FFAC2E8DC40
        public void AddRule(){} // RVA: 0x7FFAC2E8DC40
        public void AddOrInsert(){} // RVA: 0x7FFAC2E8DC40
    }

    public class RuntimeCompatibilityAttribute : Attribute
    {
        public bool WrapNonExceptionThrows; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void set_WrapNonExceptionThrows(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class RuntimeFeature : Object
    {
        public object IsDynamicCodeSupported;
        public object IsDynamicCodeCompiled;

        // ── Methods ──
        public void get_IsDynamicCodeSupported(){} // RVA: 0x7FFAC2F21320
        public void get_IsDynamicCodeCompiled(){} // RVA: 0x7FFAC2F21320
    }

    public class RuntimeHelpers : Object
    {
        public object OffsetToStringData;

        // ── Methods ──
        public void InitializeArray(){} // RVA: 0x7FFAC84E0110 | overloaded x2
        public void get_OffsetToStringData(){} // RVA: 0x7FFAC3195EF0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void GetObjectValue(){} // RVA: 0x7FFAC84E02B0
        public void RunClassConstructor(){} // RVA: 0x7FFAC84E0320 | overloaded x2
        public void SufficientExecutionStack(){} // RVA: 0x7FFAC3006850
        public void EnsureSufficientExecutionStack(){} // RVA: 0x7FFAC2F21310
        public void TryEnsureSufficientExecutionStack(){} // RVA: 0x7FFAC3006850
        public void PrepareConstrainedRegions(){} // RVA: 0x7FFAC2F21310
        public void PrepareDelegate(){} // RVA: 0x7FFAC2F21310
        public void IsReferenceOrContainsReferences(){} // RVA: 0x7FFAC2C59D30
        public void GetUninitializedObject(){} // RVA: 0x7FFAC8339860
    }

    public class RuntimeOps : Object
    {
        // ── Methods ──
        public void ExpandoTryGetValue(){} // RVA: 0x7FFAC8DF4DC0
        public void ExpandoTrySetValue(){} // RVA: 0x7FFAC8DF4DF0
        public void ExpandoTryDeleteValue(){} // RVA: 0x7FFAC8DF4E40
        public void ExpandoCheckVersion(){} // RVA: 0x7FFAC8DF4F00
        public void ExpandoPromoteClass(){} // RVA: 0x7FFAC8DF4F30
    }

    public class RuntimeWrappedException : Exception
    {
        public object WrappedException; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DC960 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFAC84DC7A0
        public void get_WrappedException(){} // RVA: 0x7FFAC32EF640
    }

    public class ScopedRefAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SkipLocalsInitAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StateMachineAttribute : Attribute
    {
        public System.Type StateMachineType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_StateMachineType(){} // RVA: 0x7FFAC2F3C380
    }

    public class StringFreezingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StrongBox`1 : Object
    {
        public T System.Runtime.CompilerServices.IStrongBox.Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void System.Runtime.CompilerServices.IStrongBox.get_Value(){} // RVA: 0x7FFAC2C58E90
        public void System.Runtime.CompilerServices.IStrongBox.set_Value(){} // RVA: 0x7FFAC2C70A40
    }

    public class SuppressIldasmAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TaskAwaiter : ValueType
    {
        public System.Threading.Tasks.Task IsCompleted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void get_IsCompleted(){} // RVA: 0x7FFAC5490100
        public void OnCompleted(){} // RVA: 0x7FFAC69DEB80
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC69DEC30
        public void GetResult(){} // RVA: 0x7FFAC84DD2F0
        public void ValidateEnd(){} // RVA: 0x7FFAC84DD330
        public void HandleNonSuccessAndDebuggerNotification(){} // RVA: 0x7FFAC84DD370
        public void ThrowForNonSuccess(){} // RVA: 0x7FFAC84DD580
        public void OnCompletedInternal(){} // RVA: 0x7FFAC84DD6E0
        public void OutputWaitEtwEvents(){} // RVA: 0x7FFAC84DD7B0
    }

    public class TaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<T> IsCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TrueReadOnlyCollection`1 : ReadOnlyCollection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
    }

    public class TupleElementNamesAttribute : Attribute
    {
        public string[] TransformNames; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DC990
        public void get_TransformNames(){} // RVA: 0x7FFAC2F3C380
    }

    public class TypeDependencyAttribute : Attribute
    {
        public string typeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DFF20
    }

    public class TypeForwardedFromAttribute : Attribute
    {
        public string AssemblyFullName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DCA40
        public void get_AssemblyFullName(){} // RVA: 0x7FFAC2F3C380
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void ReadUnaligned(){} // RVA: 0x7FFAC2E8DC40
        public void WriteUnaligned(){} // RVA: 0x7FFAC2E8DC40
        public void AsPointer(){} // RVA: 0x7FFAC2E8DC40
        public void SizeOf(){} // RVA: 0x7FFAC2C59990
        public void CopyBlock(){} // RVA: 0x7FFAC8462EF0
        public void InitBlockUnaligned(){} // RVA: 0x7FFAC84E03B0 | overloaded x2
        public void As(){} // RVA: 0x7FFAC2C58F80 | overloaded x2
        public void AsRef(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2C5EA50 | overloaded x2
        public void AddByteOffset(){} // RVA: 0x7FFAC2C5EA50
        public void ByteOffset(){} // RVA: 0x7FFAC2E8DC40
        public void AreSame(){} // RVA: 0x7FFAC2C5A350
    }

    public class UnsafeValueTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ValueTaskAwaiter : ValueType
    {
        public System.Action`1<object> IsCompleted;
        public System.Threading.Tasks.ValueTask _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4AA1C40
        public void get_IsCompleted(){} // RVA: 0x7FFAC84DCB00
        public void GetResult(){} // RVA: 0x7FFAC84DCB50
        public void OnCompleted(){} // RVA: 0x7FFAC84DCBA0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC84DCE30
        public void .cctor(){} // RVA: 0x7FFAC84DD0C0
    }

    public class ValueTaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.ValueTask`1<T> IsCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void GetResult(){} // RVA: 0x7FFAC2E8DC40
        public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
        public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
    }

    public class YieldAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFAC2F21320
    }

}