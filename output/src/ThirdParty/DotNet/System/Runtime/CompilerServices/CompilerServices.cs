// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 92
// Methods: 317

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class AsyncIteratorMethodBuilder : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86DFC9E0
        public void MoveNext(){} // RVA: 0x7FFE80E460A0
        public void Complete(){} // RVA: 0x7FFE86DFCA90
    }

    public class AsyncIteratorStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AsyncMethodBuilderAttribute : Attribute
    {
        public System.Type _builderType; // 0x10

        // ── Methods ──
        public void get_BuilderType(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AsyncMethodBuilderCore : ValueType
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE80E46070
        public void SetStateMachine(){} // RVA: 0x7FFE86887D60
        public void GetCompletionAction(){} // RVA: 0x7FFE86887E70
        public void OutputAsyncCausalityEvents(){} // RVA: 0x7FFE86888090
        public void PostBoxInitialization(){} // RVA: 0x7FFE86888200
        public void ThrowAsync(){} // RVA: 0x7FFE86888390
        public void CreateContinuationWrapper(){} // RVA: 0x7FFE86888850
        public void TryGetContinuationTask(){} // RVA: 0x7FFE86888A70
    }

    public class AsyncStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AsyncTaskCache : Object
    {
        // ── Methods ──
        public void CreateInt32Tasks(){} // RVA: 0x7FFE868879D0
        public void CreateCacheableTask(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE86887BB0
    }

    public class AsyncTaskMethodBuilder : ValueType
    {
        public System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> s_cachedCompleted;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE84BAB710
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE868876F0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void get_Task(){} // RVA: 0x7FFE86887760
        public void SetResult(){} // RVA: 0x7FFE868877D0
        public void SetException(){} // RVA: 0x7FFE86887880
        public void .cctor(){} // RVA: 0x7FFE86887900
    }

    public class AsyncTaskMethodBuilder`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<T> s_defaultResultTask;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE80E460A0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void get_Task(){} // RVA: 0x7FFE80E2E2E0
        public void SetResult(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void SetException(){} // RVA: 0x7FFE80E460A0
        public void GetTaskForResult(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AsyncValueTaskMethodBuilder : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder _methodBuilder; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE85E18650
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE86EAABD0
        public void SetResult(){} // RVA: 0x7FFE86EAAC30
        public void SetException(){} // RVA: 0x7FFE86EAAC90
        public void get_Task(){} // RVA: 0x7FFE86EAACF0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
    }

    public class AsyncValueTaskMethodBuilder`1 : ValueType
    {
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<T> _methodBuilder;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE80E460A0
        public void SetResult(){} // RVA: 0x7FFE810A1420
        public void SetException(){} // RVA: 0x7FFE80E460A0
        public void get_Task(){} // RVA: 0x7FFE810A1420
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
    }

    public class AsyncVoidMethodBuilder : ValueType
    {
        public System.Threading.SynchronizationContext m_synchronizationContext; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86887470
        public void Start(){} // RVA: 0x7FFE80E460A0
        public void SetStateMachine(){} // RVA: 0x7FFE86887510
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFE80E4F230
        public void SetResult(){} // RVA: 0x7FFE86887520
        public void SetException(){} // RVA: 0x7FFE86887530
        public void NotifySynchronizationContextOfCompletion(){} // RVA: 0x7FFE86887600
        public void get_Task(){} // RVA: 0x7FFE86887650
    }

    public class CallSite : Object
    {
        public System.Dynamic.Utils.CacheDict`2<System.Type,System.Func`2<System.Runtime.CompilerServices.CallSiteBinder,System.Runtime.CompilerServices.CallSite>> s_siteCtors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Binder(){} // RVA: 0x7FFE81116380
        public void Create(){} // RVA: 0x7FFE8719D5A0
    }

    public class CallSiteBinder : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,object> Cache; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_UpdateLabel(){} // RVA: 0x7FFE8719DC60
        public void Bind(){} // RVA: 0x7FFE80E403A0
        public void BindDelegate(){} // RVA: 0x7FFE810A1420
        public void BindCore(){} // RVA: 0x7FFE810A1420
        public void CacheTarget(){} // RVA: 0x7FFE810A1420
        public void Stitch(){} // RVA: 0x7FFE80E2E440
        public void GetRuleCache(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE8719DCC0
    }

    public class CallSiteOps : Object
    {
        // ── Methods ──
        public void CreateMatchmaker(){} // RVA: 0x7FFE80E2E3D0
        public void SetNotMatched(){} // RVA: 0x7FFE8719DE70
        public void GetMatch(){} // RVA: 0x7FFE84A50A80
        public void ClearMatch(){} // RVA: 0x7FFE8719DE90
        public void AddRule(){} // RVA: 0x7FFE810A1420
        public void UpdateRules(){} // RVA: 0x7FFE80E4BA70
        public void GetRules(){} // RVA: 0x7FFE80E2E3D0
        public void GetRuleCache(){} // RVA: 0x7FFE80E2E3D0
        public void MoveRule(){} // RVA: 0x7FFE810A1420
        public void GetCachedRules(){} // RVA: 0x7FFE80E2E3D0
        public void Bind(){} // RVA: 0x7FFE810A1420
    }

    public class CallSite`1 : CallSite
    {
        public T Target;

        // ── Methods ──
        public void get_Update(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void CreateMatchMaker(){} // RVA: 0x7FFE80E2E2E0
        public void Create(){} // RVA: 0x7FFE80E2E3D0
        public void GetUpdateDelegate(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AddRule(){} // RVA: 0x7FFE810A1420
        public void MoveRule(){} // RVA: 0x7FFE80E46530
        public void MakeUpdateDelegate(){} // RVA: 0x7FFE810A1420
        public void CreateCustomUpdateDelegate(){} // RVA: 0x7FFE810A1420
        public void CreateCustomNoMatchDelegate(){} // RVA: 0x7FFE810A1420
        public void Convert(){} // RVA: 0x7FFE80E2E440
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class CallerFilePathAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CallerLineNumberAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CallerMemberNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CompilationRelaxationsAttribute : Attribute
    {
        public int m_relaxations; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void get_CompilationRelaxations(){} // RVA: 0x7FFE811485C0
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class CompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ConditionalWeakTable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
        public void RehashWithoutResize(){} // RVA: 0x7FFE80E45FE0
        public void RecomputeSize(){} // RVA: 0x7FFE80E45FE0
        public void Rehash(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void GetOrCreateValue(){} // RVA: 0x7FFE810A1420
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ConfiguredAsyncDisposable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE819409B0
        public void DisposeAsync(){} // RVA: 0x7FFE86DFCAE0
    }

    public class ConfiguredTaskAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868873B0
        public void GetAwaiter(){} // RVA: 0x7FFE8151C410
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4BC00
        public void GetAwaiter(){} // RVA: 0x7FFE810A1420
    }

    public class ConfiguredValueTaskAwaitable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82D0A490
        public void GetAwaiter(){} // RVA: 0x7FFE868853C0
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetAwaiter(){} // RVA: 0x7FFE810A1420
    }

    public class CustomConstantAttribute : Attribute
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DateTimeConstantAttribute : CustomConstantAttribute
    {
        public System.DateTime _date; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE86885A00
    }

    public class DebugInfoGenerator : Object
    {
    }

    public class DecimalConstantAttribute : Attribute
    {
        public System.Decimal _dec; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86885A50
        public void get_Value(){} // RVA: 0x7FFE826F6B90
    }

    public class DefaultDependencyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class DefaultInterpolatedStringHandler : ValueType
    {
        public System.IFormatProvider _provider; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5490C0
        public void GetDefaultLength(){} // RVA: 0x7FFE8A549220
        public void ToString(){} // RVA: 0x7FFE8A549280
        public void ToStringAndClear(){} // RVA: 0x7FFE8A5492E0
        public void Clear(){} // RVA: 0x7FFE8A5493E0
        public void get_Text(){} // RVA: 0x7FFE8A549490
        public void AppendLiteral(){} // RVA: 0x7FFE8A549550
        public void AppendFormatted(){} // RVA: 0x7FFE8A549770 | overloaded x5
        public void AppendCustomFormatter(){} // RVA: 0x7FFE810A1420
        public void AppendOrInsertAlignmentIfNeeded(){} // RVA: 0x7FFE8A5497F0
        public void EnsureCapacityForAdditionalChars(){} // RVA: 0x7FFE8A549A70
        public void GrowThenCopyString(){} // RVA: 0x7FFE8A549AD0
        public void Grow(){} // RVA: 0x7FFE8A549C50
        public void GrowCore(){} // RVA: 0x7FFE8A549C60
    }

    public class DependencyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

    public class DisableRuntimeMarshallingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DynamicAttribute : Attribute
    {
    }

    public class EnumeratorCancellationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Ephemeron : ValueType
    {
    }

    public class ExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FixedBufferAttribute : Attribute
    {
        public System.Type _elementType; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_ElementType(){} // RVA: 0x7FFE81116380
        public void get_Length(){} // RVA: 0x7FFE813DB630
    }

    public class FormattableStringFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86885B10
    }

    public class FriendAccessAllowedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IAsyncStateMachine
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE80E45FE0
        public void SetStateMachine(){} // RVA: 0x7FFE80E460A0
    }

    public class ICriticalNotifyCompletion
    {
        // ── Methods ──
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE80E460A0
    }

    public class INotifyCompletion
    {
        // ── Methods ──
        public void OnCompleted(){} // RVA: 0x7FFE80E460A0
    }

    public class IRuntimeVariables
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void set_Item(){} // RVA: 0x7FFE80E48220
    }

    public class IStrongBox
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void set_Value(){} // RVA: 0x7FFE80E460A0
    }

    public class ITuple
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
    }

    public class InternalsVisibleToAttribute : Attribute
    {
        public string _assemblyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868896F0
        public void set_AllInternalsVisible(){} // RVA: 0x7FFE811164F0
    }

    public class InterpolatedStringHandlerArgumentAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88212A50
    }

    public class InterpolatedStringHandlerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IntrinsicAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IsByRefLikeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IsExternalInit : Object
    {
    }

    public class IsReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IsUnmanagedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IsVolatile : Object
    {
    }

    public class IteratorStateMachineAttribute : StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class JitHelpers : Object
    {
        // ── Methods ──
        public void UnsafeCast(){} // RVA: 0x7FFE810A1420
        public void UnsafeEnumCast(){} // RVA: 0x7FFE810A1420
        public void UnsafeEnumCastLong(){} // RVA: 0x7FFE810A1420
    }

    public class ModuleInitializerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeIntegerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class NullableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class NullableContextAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class NullablePublicOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class ReadOnlyCollectionBuilder`1 : Object
    {
        public T[] _items;
        public int _size;
        public int _version;
        public object field_3; // 0x393
        public object field_4; // 0x394
        public object field_5; // 0x395
        public object field_6; // 0x396
        public object field_7; // 0x397
        public object field_8; // 0x398

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void ToReadOnlyCollection(){} // RVA: 0x7FFE80E2E2E0
        public void EnsureCapacity(){} // RVA: 0x7FFE80E46530
        public void IsCompatibleObject(){} // RVA: 0x7FFE80E2F230
        public void ValidateNullValue(){} // RVA: 0x7FFE80E462E0
    }

    public class RefSafetyRulesAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class ReflectionBlockedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RequiredMemberAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuleCache`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetRules(){} // RVA: 0x7FFE80E2E2E0
        public void MoveRule(){} // RVA: 0x7FFE810A1420
        public void AddRule(){} // RVA: 0x7FFE810A1420
        public void AddOrInsert(){} // RVA: 0x7FFE810A1420
    }

    public class RuntimeCompatibilityAttribute : Attribute
    {
        public bool _wrapNonExceptionThrows; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void set_WrapNonExceptionThrows(){} // RVA: 0x7FFE811C55F0
    }

    public class RuntimeFeature : Object
    {
        // ── Methods ──
        public void get_IsDynamicCodeSupported(){} // RVA: 0x7FFE810FB320
        public void get_IsDynamicCodeCompiled(){} // RVA: 0x7FFE810FB320
    }

    public class RuntimeHelpers : Object
    {
        // ── Methods ──
        public void InitializeArray(){} // RVA: 0x7FFE86889940 | overloaded x2
        public void get_OffsetToStringData(){} // RVA: 0x7FFE813FC490
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void GetObjectValue(){} // RVA: 0x7FFE86889AE0
        public void RunClassConstructor(){} // RVA: 0x7FFE86889B50 | overloaded x2
        public void SufficientExecutionStack(){} // RVA: 0x7FFE811E0850
        public void EnsureSufficientExecutionStack(){} // RVA: 0x7FFE810FB310
        public void TryEnsureSufficientExecutionStack(){} // RVA: 0x7FFE811E0850
        public void PrepareConstrainedRegions(){} // RVA: 0x7FFE810FB310
        public void PrepareDelegate(){} // RVA: 0x7FFE810FB310
        public void IsReferenceOrContainsReferences(){} // RVA: 0x7FFE80E2F180
        public void GetUninitializedObject(){} // RVA: 0x7FFE866E3160
    }

    public class RuntimeOps : Object
    {
        // ── Methods ──
        public void ExpandoTryGetValue(){} // RVA: 0x7FFE8719D1F0
        public void ExpandoTrySetValue(){} // RVA: 0x7FFE8719D220
        public void ExpandoTryDeleteValue(){} // RVA: 0x7FFE8719D270
        public void ExpandoCheckVersion(){} // RVA: 0x7FFE8719D330
        public void ExpandoPromoteClass(){} // RVA: 0x7FFE8719D360
    }

    public class RuntimeWrappedException : Exception
    {
        public object _wrappedException; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86886190 | overloaded x3
        public void GetObjectData(){} // RVA: 0x7FFE86885FD0
        public void get_WrappedException(){} // RVA: 0x7FFE8154EB60
    }

    public class ScopedRefAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SkipLocalsInitAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StateMachineAttribute : Attribute
    {
        public System.Type _stateMachineType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_StateMachineType(){} // RVA: 0x7FFE81116380
    }

    public class StringFreezingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StrongBox`1 : Object
    {
        public T Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void System.Runtime.CompilerServices.IStrongBox.get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void System.Runtime.CompilerServices.IStrongBox.set_Value(){} // RVA: 0x7FFE80E460A0
    }

    public class SuppressIldasmAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TaskAwaiter : ValueType
    {
        public System.Threading.Tasks.Task m_task; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void get_IsCompleted(){} // RVA: 0x7FFE83788010
        public void OnCompleted(){} // RVA: 0x7FFE84D3FDA0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE84D3FE50
        public void GetResult(){} // RVA: 0x7FFE86886B20
        public void ValidateEnd(){} // RVA: 0x7FFE86886B60
        public void HandleNonSuccessAndDebuggerNotification(){} // RVA: 0x7FFE86886BA0
        public void ThrowForNonSuccess(){} // RVA: 0x7FFE86886DB0
        public void OnCompletedInternal(){} // RVA: 0x7FFE86886F10
        public void OutputWaitEtwEvents(){} // RVA: 0x7FFE86886FE0
    }

    public class TaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.Task`1<T> m_task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void OnCompleted(){} // RVA: 0x7FFE80E460A0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE80E460A0
        public void GetResult(){} // RVA: 0x7FFE810A1420
    }

    public class TrueReadOnlyCollection`1 : ReadOnlyCollection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
    }

    public class TupleElementNamesAttribute : Attribute
    {
        public string[] _transformNames; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868861C0
        public void get_TransformNames(){} // RVA: 0x7FFE81116380
    }

    public class TypeDependencyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86889750
    }

    public class TypeForwardedFromAttribute : Attribute
    {
        public string _assemblyFullName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86886270
        public void get_AssemblyFullName(){} // RVA: 0x7FFE81116380
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE810A1420
        public void ReadUnaligned(){} // RVA: 0x7FFE810A1420
        public void WriteUnaligned(){} // RVA: 0x7FFE810A1420
        public void AsPointer(){} // RVA: 0x7FFE810A1420
        public void SizeOf(){} // RVA: 0x7FFE80E2EDE0
        public void CopyBlock(){} // RVA: 0x7FFE8680C800
        public void InitBlockUnaligned(){} // RVA: 0x7FFE86889BE0 | overloaded x2
        public void As(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
        public void AsRef(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE80E33EA0 | overloaded x2
        public void AddByteOffset(){} // RVA: 0x7FFE80E33EA0
        public void ByteOffset(){} // RVA: 0x7FFE810A1420
        public void AreSame(){} // RVA: 0x7FFE80E2F7A0
    }

    public class UnsafeValueTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ValueTaskAwaiter : ValueType
    {
        public System.Action`1<object> s_invokeActionDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82D0A490
        public void get_IsCompleted(){} // RVA: 0x7FFE86886330
        public void GetResult(){} // RVA: 0x7FFE86886380
        public void OnCompleted(){} // RVA: 0x7FFE868863D0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE86886660
        public void .cctor(){} // RVA: 0x7FFE868868F0
    }

    public class ValueTaskAwaiter`1 : ValueType
    {
        public System.Threading.Tasks.ValueTask`1<T> _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void GetResult(){} // RVA: 0x7FFE810A1420
        public void OnCompleted(){} // RVA: 0x7FFE80E460A0
        public void UnsafeOnCompleted(){} // RVA: 0x7FFE80E460A0
    }

    public class YieldAwaitable : ValueType
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7FFE810FB320
    }

}