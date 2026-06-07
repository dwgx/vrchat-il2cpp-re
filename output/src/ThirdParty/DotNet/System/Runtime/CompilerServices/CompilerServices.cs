// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 92
// Methods: 321

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class AsyncIteratorMethodBuilder
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x62BBFB0
        public void MoveNext(){} // RVA: 0x24B10
        public void Complete(){} // RVA: 0x62BC060
    }

    public class AsyncIteratorStateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class AsyncMethodBuilderAttribute
    {
        // ── Methods ──
        public void get_BuilderType(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class AsyncMethodBuilderCore
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x24AE0
        public void SetStateMachine(){} // RVA: 0x5D46E60
        public void GetCompletionAction(){} // RVA: 0x5D46F70
        public void OutputAsyncCausalityEvents(){} // RVA: 0x5D47190
        public void PostBoxInitialization(){} // RVA: 0x5D47300
        public void ThrowAsync(){} // RVA: 0x5D47490
        public void CreateContinuationWrapper(){} // RVA: 0x5D47950
        public void TryGetContinuationTask(){} // RVA: 0x5D47B70
    }

    public class AsyncStateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class AsyncTaskCache
    {
        // ── Methods ──
        public void CreateInt32Tasks(){} // RVA: 0x5D46AD0
        public void CreateCacheableTask(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x5D46CB0
    }

    public class AsyncTaskMethodBuilder
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x3F3ED10
        public void Start(){} // RVA: 0x24B10
        public void SetStateMachine(){} // RVA: 0x5D467F0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x2DC60
        public void get_Task(){} // RVA: 0x5D46860
        public void SetResult(){} // RVA: 0x5D468D0
        public void SetException(){} // RVA: 0x5D46980
        public void .cctor(){} // RVA: 0x5D46A00
    }

    public class AsyncTaskMethodBuilder`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0
        public void Start(){} // RVA: 0x24B10
        public void SetStateMachine(){} // RVA: 0x24B10
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x2DC60
        public void get_Task(){} // RVA: 0xCD60
        public void SetResult(){} // RVA: 0x24B10 | overloaded x2
        public void SetException(){} // RVA: 0x24B10
        public void GetTaskForResult(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class AsyncValueTaskMethodBuilder
    {
        public object Task;

        // ── Methods ──
        public void Create(){} // RVA: 0x4F85940
        public void Start(){} // RVA: 0x24B10
        public void SetStateMachine(){} // RVA: 0x636A1B0
        public void SetResult(){} // RVA: 0x636A210
        public void SetException(){} // RVA: 0x636A270
        public void get_Task(){} // RVA: 0x636A2D0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x2DC60
    }

    public class AsyncValueTaskMethodBuilder`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0
        public void Start(){} // RVA: 0x24B10
        public void SetStateMachine(){} // RVA: 0x24B10
        public void SetResult(){} // RVA: 0x283FA0
        public void SetException(){} // RVA: 0x24B10
        public void get_Task(){} // RVA: 0x283FA0
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x2DC60
    }

    public class AsyncVoidMethodBuilder
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x5D46570
        public void Start(){} // RVA: 0x24B10
        public void SetStateMachine(){} // RVA: 0x5D46610
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x2DC60
        public void SetResult(){} // RVA: 0x5D46620
        public void SetException(){} // RVA: 0x5D46630
        public void NotifySynchronizationContextOfCompletion(){} // RVA: 0x5D46700
        public void get_Task(){} // RVA: 0x5D46750
    }

    public class CallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Binder(){} // RVA: 0x2F8380
        public void Create(){} // RVA: 0x665E6B0
    }

    public class CallSiteBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_UpdateLabel(){} // RVA: 0x665ED70
        public void Bind(){} // RVA: 0x1EE30
        public void BindDelegate(){} // RVA: 0x283FA0
        public void BindCore(){} // RVA: 0x283FA0
        public void CacheTarget(){} // RVA: 0x283FA0
        public void Stitch(){} // RVA: 0xCEC0
        public void GetRuleCache(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x665EDD0
    }

    public class CallSiteOps
    {
        // ── Methods ──
        public void CreateMatchmaker(){} // RVA: 0xCE50
        public void SetNotMatched(){} // RVA: 0x665EF80
        public void GetMatch(){} // RVA: 0x3DE0510
        public void ClearMatch(){} // RVA: 0x665EFA0
        public void AddRule(){} // RVA: 0x283FA0
        public void UpdateRules(){} // RVA: 0x2A490
        public void GetRules(){} // RVA: 0xCE50
        public void GetRuleCache(){} // RVA: 0xCE50
        public void MoveRule(){} // RVA: 0x283FA0
        public void GetCachedRules(){} // RVA: 0xCE50
        public void Bind(){} // RVA: 0x283FA0
    }

    public class CallSite`1
    {
        public object Binder;

        // ── Methods ──
        public void get_Update(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void CreateMatchMaker(){} // RVA: 0xCD60
        public void Create(){} // RVA: 0xCE50
        public void GetUpdateDelegate(){} // RVA: 0x283FA0 | overloaded x2
        public void AddRule(){} // RVA: 0x283FA0
        public void MoveRule(){} // RVA: 0x24FA0
        public void MakeUpdateDelegate(){} // RVA: 0x283FA0
        public void CreateCustomUpdateDelegate(){} // RVA: 0x283FA0
        public void CreateCustomNoMatchDelegate(){} // RVA: 0x283FA0
        public void Convert(){} // RVA: 0xCEC0
    }

    public class CallerArgumentExpressionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ParameterName(){} // RVA: 0x2F8380
    }

    public class CallerFilePathAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CallerLineNumberAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CallerMemberNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CompilationRelaxationsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0 | overloaded x2
        public void get_CompilationRelaxations(){} // RVA: 0x32A5C0
    }

    public class CompilerFeatureRequiredAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_FeatureName(){} // RVA: 0x2F8380
        public void get_IsOptional(){} // RVA: 0x2F84E0
        public void set_IsOptional(){} // RVA: 0x2F84F0
    }

    public class CompilerGeneratedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ConditionalWeakTable`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Finalize(){} // RVA: 0x24A50
        public void RehashWithoutResize(){} // RVA: 0x24A50
        public void RecomputeSize(){} // RVA: 0x24A50
        public void Rehash(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void GetOrCreateValue(){} // RVA: 0x283FA0
        public void GetValue(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class ConfiguredAsyncDisposable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA8650
        public void DisposeAsync(){} // RVA: 0x62BC0B0
    }

    public class ConfiguredTaskAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D464B0
        public void GetAwaiter(){} // RVA: 0x75E7E0
    }

    public class ConfiguredTaskAwaitable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A620
        public void GetAwaiter(){} // RVA: 0x283FA0
    }

    public class ConfiguredValueTaskAwaitable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1F7E940
        public void GetAwaiter(){} // RVA: 0x5D444C0
    }

    public class ConfiguredValueTaskAwaitable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void GetAwaiter(){} // RVA: 0x283FA0
    }

    public class CustomConstantAttribute
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DateTimeConstantAttribute
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x5D44B00
    }

    public class DebugInfoGenerator
    {
    }

    public class DecimalConstantAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D44B50
        public void get_Value(){} // RVA: 0x196ABE0
    }

    public class DefaultDependencyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class DefaultInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B09850
        public void GetDefaultLength(){} // RVA: 0x9B099B0
        public void ToString(){} // RVA: 0x9B09A10
        public void ToStringAndClear(){} // RVA: 0x9B09A70
        public void Clear(){} // RVA: 0x9B09B70
        public void get_Text(){} // RVA: 0x9B09C20
        public void AppendLiteral(){} // RVA: 0x9B09CE0
        public void AppendFormatted(){} // RVA: 0x9B09F00 | overloaded x5
        public void AppendCustomFormatter(){} // RVA: 0x283FA0
        public void AppendOrInsertAlignmentIfNeeded(){} // RVA: 0x9B09F80
        public void EnsureCapacityForAdditionalChars(){} // RVA: 0x9B0A200
        public void GrowThenCopyString(){} // RVA: 0x9B0A260
        public void Grow(){} // RVA: 0x9B0A3E0
        public void GrowCore(){} // RVA: 0x9B0A3F0
    }

    public class DependencyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
    }

    public class DisableRuntimeMarshallingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DynamicAttribute
    {
    }

    public class EnumeratorCancellationAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Ephemeron
    {
    }

    public class ExtensionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FixedBufferAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_ElementType(){} // RVA: 0x2F8380
        public void get_Length(){} // RVA: 0x5BED50
    }

    public class FormattableStringFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x5D44C10
    }

    public class FriendAccessAllowedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IAsyncStateMachine
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x24A50
        public void SetStateMachine(){} // RVA: 0x24B10
    }

    public class ICriticalNotifyCompletion
    {
        // ── Methods ──
        public void UnsafeOnCompleted(){} // RVA: 0x24B10
    }

    public class INotifyCompletion
    {
        // ── Methods ──
        public void OnCompleted(){} // RVA: 0x24B10
    }

    public class IRuntimeVariables
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x1BCC0
        public void set_Item(){} // RVA: 0x26C40
    }

    public class IStrongBox
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xCD60
        public void set_Value(){} // RVA: 0x24B10
    }

    public class ITuple
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0xD840
    }

    public class InternalsVisibleToAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D487F0
        public void set_AllInternalsVisible(){} // RVA: 0x2F84F0
    }

    public class InterpolatedStringHandlerArgumentAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D5930
    }

    public class InterpolatedStringHandlerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntrinsicAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IsByRefLikeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IsExternalInit
    {
    }

    public class IsReadOnlyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IsUnmanagedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IsVolatile
    {
    }

    public class IteratorStateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class JitHelpers
    {
        // ── Methods ──
        public void UnsafeCast(){} // RVA: 0x283FA0
        public void UnsafeEnumCast(){} // RVA: 0x283FA0
        public void UnsafeEnumCastLong(){} // RVA: 0x283FA0
    }

    public class ModuleInitializerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeIntegerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class NullableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class NullableContextAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
    }

    public class NullablePublicOnlyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
    }

    public class ReadOnlyCollectionBuilder`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Count(){} // RVA: 0xD840
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void Remove(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void ToArray(){} // RVA: 0xCD60
        public void ToReadOnlyCollection(){} // RVA: 0xCD60
        public void EnsureCapacity(){} // RVA: 0x24FA0
        public void IsCompatibleObject(){} // RVA: 0xDCC0
        public void ValidateNullValue(){} // RVA: 0x24D50
    }

    public class RefSafetyRulesAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class ReflectionBlockedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RequiredMemberAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RuleCache`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void GetRules(){} // RVA: 0xCD60
        public void MoveRule(){} // RVA: 0x283FA0
        public void AddRule(){} // RVA: 0x283FA0
        public void AddOrInsert(){} // RVA: 0x283FA0
    }

    public class RuntimeCompatibilityAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void set_WrapNonExceptionThrows(){} // RVA: 0x3A75F0
    }

    public class RuntimeFeature
    {
        public object WrappedException;

        // ── Methods ──
        public void get_IsDynamicCodeSupported(){} // RVA: 0x2DD320
        public void get_IsDynamicCodeCompiled(){} // RVA: 0x2DD320
    }

    public class RuntimeHelpers
    {
        // ── Methods ──
        public void InitializeArray(){} // RVA: 0x5D48A40 | overloaded x2
        public void get_OffsetToStringData(){} // RVA: 0x5FAB20
        public void GetHashCode(){} // RVA: 0x5C63910
        public void GetObjectValue(){} // RVA: 0x5D48BE0
        public void RunClassConstructor(){} // RVA: 0x5D48C50 | overloaded x2
        public void SufficientExecutionStack(){} // RVA: 0x3C2850
        public void EnsureSufficientExecutionStack(){} // RVA: 0x2DD310
        public void TryEnsureSufficientExecutionStack(){} // RVA: 0x3C2850
        public void PrepareConstrainedRegions(){} // RVA: 0x2DD310
        public void PrepareDelegate(){} // RVA: 0x2DD310
        public void IsReferenceOrContainsReferences(){} // RVA: 0xDC10
        public void GetUninitializedObject(){} // RVA: 0x5BA2310
    }

    public class RuntimeOps
    {
        // ── Methods ──
        public void ExpandoTryGetValue(){} // RVA: 0x665E300
        public void ExpandoTrySetValue(){} // RVA: 0x665E330
        public void ExpandoTryDeleteValue(){} // RVA: 0x665E380
        public void ExpandoCheckVersion(){} // RVA: 0x665E440
        public void ExpandoPromoteClass(){} // RVA: 0x665E470
    }

    public class RuntimeWrappedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D45290 | overloaded x3
        public void GetObjectData(){} // RVA: 0x5D450D0
        public void get_WrappedException(){} // RVA: 0x796DE0
    }

    public class ScopedRefAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SkipLocalsInitAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StateMachineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_StateMachineType(){} // RVA: 0x2F8380
    }

    public class StringFreezingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StrongBox`1 : System.Runtime.CompilerServices.IStrongBox.Value
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void System.Runtime.CompilerServices.IStrongBox.get_Value(){} // RVA: 0xCD60
        public void System.Runtime.CompilerServices.IStrongBox.set_Value(){} // RVA: 0x24B10
    }

    public class SuppressIldasmAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TaskAwaiter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void get_IsCompleted(){} // RVA: 0x2AC5C60
        public void OnCompleted(){} // RVA: 0x40D5BA0
        public void UnsafeOnCompleted(){} // RVA: 0x40D5C50
        public void GetResult(){} // RVA: 0x5D45C20
        public void ValidateEnd(){} // RVA: 0x5D45C60
        public void HandleNonSuccessAndDebuggerNotification(){} // RVA: 0x5D45CA0
        public void ThrowForNonSuccess(){} // RVA: 0x5D45EB0
        public void OnCompletedInternal(){} // RVA: 0x5D46010
        public void OutputWaitEtwEvents(){} // RVA: 0x5D460E0
    }

    public class TaskAwaiter`1 : IsCompleted
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_IsCompleted(){} // RVA: 0xDBE0
        public void OnCompleted(){} // RVA: 0x24B10
        public void UnsafeOnCompleted(){} // RVA: 0x24B10
        public void GetResult(){} // RVA: 0x283FA0
    }

    public class TrueReadOnlyCollection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
    }

    public class TupleElementNamesAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D452C0
        public void get_TransformNames(){} // RVA: 0x2F8380
    }

    public class TypeDependencyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D48850
    }

    public class TypeForwardedFromAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D45370
        public void get_AssemblyFullName(){} // RVA: 0x2F8380
    }

    public class Unsafe
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x283FA0
        public void ReadUnaligned(){} // RVA: 0x283FA0
        public void WriteUnaligned(){} // RVA: 0x283FA0
        public void AsPointer(){} // RVA: 0x283FA0
        public void SizeOf(){} // RVA: 0xD870
        public void CopyBlock(){} // RVA: 0x5CCB900
        public void InitBlockUnaligned(){} // RVA: 0x5D48CE0 | overloaded x2
        public void As(){} // RVA: 0xCE50 | overloaded x2
        public void AsRef(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x12930 | overloaded x2
        public void AddByteOffset(){} // RVA: 0x12930
        public void ByteOffset(){} // RVA: 0x283FA0
        public void AreSame(){} // RVA: 0xE230
    }

    public class UnsafeValueTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ValueTaskAwaiter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1F7E940
        public void get_IsCompleted(){} // RVA: 0x5D45430
        public void GetResult(){} // RVA: 0x5D45480
        public void OnCompleted(){} // RVA: 0x5D454D0
        public void UnsafeOnCompleted(){} // RVA: 0x5D45760
        public void .cctor(){} // RVA: 0x5D459F0
    }

    public class ValueTaskAwaiter`1 : IsCompleted
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_IsCompleted(){} // RVA: 0xDBE0
        public void GetResult(){} // RVA: 0x283FA0
        public void OnCompleted(){} // RVA: 0x24B10
        public void UnsafeOnCompleted(){} // RVA: 0x24B10
    }

    public class YieldAwaitable
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x2DD320
    }

}