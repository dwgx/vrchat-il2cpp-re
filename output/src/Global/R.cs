// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 49
// Methods: 347

public class RBTreeEnumerator : ValueType
{
    public object Current;
    public object System.Collections.IEnumerator.Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
}

public class Range : ValueType
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFD5492F360
}

public class RawData : Object
{
    public UIntPtr Bounds; // 0x10
    public UIntPtr Count; // 0x18
    public byte Data; // 0x20
}

public class ReadAllAsyncEnumerable : Object
{
    public object Current;

    // ── Methods ──
    public void .ctor(){}
    public void GetAsyncEnumerator(){}
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void CancellationCallback1(){} // RVA: 0x7FFD4E090A10
    public void CancellationCallback2(){} // RVA: 0x7FFD4E090A10
}

public class ReadBoneJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD5223DF70
}

public class ReadDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A169B0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD53A16A90
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class ReadFileJson : ValueType
{
    // ── Methods ──
    public void ToAsset(){} // RVA: 0x7FFD54941150
}

public class ReadOnly : ValueType
{
    public object Length;
    public object Item;
    public object IsCreated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Length(){} // RVA: 0x7FFD4E079960
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class ReadOnlyArrayList : ArrayList
{
    public object Count;
    public object IsReadOnly;
    public object IsFixedSize;
    public object IsSynchronized;
    public object Item;
    public object SyncRoot;
    public object Capacity;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539BF350
    public void get_Count(){} // RVA: 0x7FFD539BF3C0
    public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
    public void get_IsFixedSize(){} // RVA: 0x7FFD4E426850
    public void get_IsSynchronized(){} // RVA: 0x7FFD539BF3F0
    public void get_Item(){} // RVA: 0x7FFD539BF420
    public void set_Item(){} // RVA: 0x7FFD539BF450
    public void get_SyncRoot(){} // RVA: 0x7FFD539BF4A0
    public void Add(){} // RVA: 0x7FFD539BF4D0
    public void AddRange(){} // RVA: 0x7FFD539BF520
    public void set_Capacity(){} // RVA: 0x7FFD539BF570
    public void Clear(){} // RVA: 0x7FFD539BF5C0
    public void Clone(){} // RVA: 0x7FFD539BF610
    public void Contains(){} // RVA: 0x7FFD539BF780
    public void CopyTo(){} // RVA: 0x7FFD539BF7E0 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFD539BF810
    public void IndexOf(){} // RVA: 0x7FFD539BF840
    public void Insert(){} // RVA: 0x7FFD539BF870
    public void InsertRange(){} // RVA: 0x7FFD539BF8C0
    public void Remove(){} // RVA: 0x7FFD539BF910
    public void RemoveAt(){} // RVA: 0x7FFD539BF960
    public void RemoveRange(){} // RVA: 0x7FFD539BF9B0
    public void Reverse(){} // RVA: 0x7FFD539BFA00
    public void Sort(){} // RVA: 0x7FFD539BFA50
    public void ToArray(){} // RVA: 0x7FFD539BFAD0 | overloaded x2
}

public class ReadOnlyKeyCollection : Object
{
    public object Count;
    public object IsReadOnly;
    public object SyncRoot;
    public object IsSynchronized;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD572311F0
    public void get_Count(){} // RVA: 0x7FFD572312B0
    public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
    public void get_SyncRoot(){} // RVA: 0x7FFD57231300
    public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
    public void Add(){} // RVA: 0x7FFD57231360
    public void Clear(){} // RVA: 0x7FFD572313A0
    public void Contains(){} // RVA: 0x7FFD572313E0
    public void CopyTo(){} // RVA: 0x7FFD57231610 | overloaded x2
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD572317F0
    public void GetEnumerator(){} // RVA: 0x7FFD572317F0
    public void Remove(){} // RVA: 0x7FFD57231840
}

public class ReadTransformJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD5223DF70
}

public class ReadWriteParameters : ValueType
{
}

public class ReadWriteTask : Task`1
{
    public object System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode;

    // ── Methods ──
    public void ClearBeginState(){} // RVA: 0x7FFD53A09980
    public void .ctor(){} // RVA: 0x7FFD53A09A30
    public void InvokeAsyncCallback(){} // RVA: 0x7FFD53A09DB0
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x7FFD53A09E80
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFD4E426850
}

public class Reader : ValueType
{
    public object IsNull;
    public object IsFlowSuppressed;
    public object SynchronizationContext;
    public object SynchronizationContextNoFlow;
    public object LogicalCallContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void DangerousGetRawExecutionContext(){} // RVA: 0x7FFD4EEF9F60
    public void get_IsNull(){} // RVA: 0x7FFD4FC6C2F0
    public void IsDefaultFTContext(){} // RVA: 0x7FFD53AE9420
    public void get_IsFlowSuppressed(){} // RVA: 0x7FFD53AE9440
    public void get_SynchronizationContext(){} // RVA: 0x7FFD53AE9460
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFD53AE9480
    public void get_LogicalCallContext(){} // RVA: 0x7FFD53AE94A0
    public void GetLocalValue(){} // RVA: 0x7FFD53AE9510
    public void HasSameLocalValues(){} // RVA: 0x7FFD53AE9590
}

public class ReaderCache : Object
{
    // ── Methods ──
    public void TryReadTo(){} // RVA: 0x7FFD57511740 | overloaded x2
    public void ReadBoxed(){} // RVA: 0x7FFD4E088090 | overloaded x2
    public void Register(){} // RVA: 0x7FFD4E0909B0
    public void EnumJsonWrite(){} // RVA: 0x7FFD4E2ADC40
    public void EnumStringWrite(){} // RVA: 0x7FFD4E07BC60
    public void EnumUtf8Write(){} // RVA: 0x7FFD4E07BC60
    public void GuidJsonWrite(){} // RVA: 0x7FFD57511A90
    public void DateTimeOffsetJsonWrite(){} // RVA: 0x7FFD57511B50
    public void JsonSerialize(){} // RVA: 0x7FFD4E2ADC40
    public void StringAppendFormatted(){} // RVA: 0x7FFD4E07BC60
    public void Utf8AppendFormatted(){} // RVA: 0x7FFD4E07BC60
    public void .cctor(){} // RVA: 0x7FFD57511C10
}

public class ReapplyDrivenProperties : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class RebindingOperation : Object
{
    public object action;
    public object bindingMask;
    public object candidates;
    public object scores;
    public object magnitudes;
    public object selectedControl;
    public object started;
    public object completed;
    public object canceled;
    public object startTime;
    public object timeout;
    public object expectedControlType;

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFD4E35C380
    public void get_bindingMask(){} // RVA: 0x7FFD52169D60
    public void get_candidates(){} // RVA: 0x7FFD54953C50
    public void get_scores(){} // RVA: 0x7FFD54953C70
    public void get_magnitudes(){} // RVA: 0x7FFD54953D30
    public void get_selectedControl(){} // RVA: 0x7FFD54953DF0
    public void get_started(){} // RVA: 0x7FFD54953E60
    public void get_completed(){} // RVA: 0x7FFD54953E70
    public void get_canceled(){} // RVA: 0x7FFD54953E80
    public void get_startTime(){} // RVA: 0x7FFD54953E90
    public void get_timeout(){} // RVA: 0x7FFD51B355B0
    public void get_expectedControlType(){} // RVA: 0x7FFD54953EA0
    public void WithAction(){} // RVA: 0x7FFD54953F00
    public void WithMatchingEventsBeingSuppressed(){} // RVA: 0x7FFD54954110
    public void WithCancelingThrough(){} // RVA: 0x7FFD54954260 | overloaded x2
    public void WithExpectedControlType(){} // RVA: 0x7FFD4E078E90 | overloaded x3
    public void WithTargetBinding(){} // RVA: 0x7FFD54954610
    public void WithBindingMask(){} // RVA: 0x7FFD549551B0
    public void WithBindingGroup(){} // RVA: 0x7FFD54955240
    public void WithoutGeneralizingPathOfSelectedControl(){} // RVA: 0x7FFD54955420
    public void WithRebindAddingNewBinding(){} // RVA: 0x7FFD54955430
    public void WithMagnitudeHavingToBeGreaterThan(){} // RVA: 0x7FFD549554A0
    public void WithoutIgnoringNoisyControls(){} // RVA: 0x7FFD549555B0
    public void WithControlsHavingToMatchPath(){} // RVA: 0x7FFD54955620
    public void WithControlsExcluding(){} // RVA: 0x7FFD54955830
    public void WithTimeout(){} // RVA: 0x7FFD54955A40
    public void OnComplete(){} // RVA: 0x7FFD54957800 | overloaded x2
    public void OnCancel(){} // RVA: 0x7FFD54957C30 | overloaded x2
    public void OnPotentialMatch(){} // RVA: 0x7FFD54955B10
    public void OnGeneratePath(){} // RVA: 0x7FFD54955B70
    public void OnComputeScore(){} // RVA: 0x7FFD54955BD0
    public void OnApplyBinding(){} // RVA: 0x7FFD54955C30
    public void OnMatchWaitForAnother(){} // RVA: 0x7FFD54955C90
    public void Start(){} // RVA: 0x7FFD54955CA0
    public void Cancel(){} // RVA: 0x7FFD54956060
    public void Complete(){} // RVA: 0x7FFD549560B0
    public void AddCandidate(){} // RVA: 0x7FFD549560D0
    public void RemoveCandidate(){} // RVA: 0x7FFD54956250
    public void Dispose(){} // RVA: 0x7FFD549563A0
    public void Finalize(){} // RVA: 0x7FFD54956490
    public void Reset(){} // RVA: 0x7FFD549565A0
    public void HookOnEvent(){} // RVA: 0x7FFD549567F0
    public void UnhookOnEvent(){} // RVA: 0x7FFD54956910
    public void OnEvent(){} // RVA: 0x7FFD54956980
    public void SortCandidatesByScore(){} // RVA: 0x7FFD54957300
    public void HavePathMatch(){} // RVA: 0x7FFD549574B0
    public void HookOnAfterUpdate(){} // RVA: 0x7FFD54957530
    public void UnhookOnAfterUpdate(){} // RVA: 0x7FFD54957650
    public void OnAfterUpdate(){} // RVA: 0x7FFD549576C0
    public void ResetAfterMatchCompleted(){} // RVA: 0x7FFD54957C70
    public void ThrowIfRebindInProgress(){} // RVA: 0x7FFD54957D70
    public void GeneratePathForControl(){} // RVA: 0x7FFD54957DE0
    public void .ctor(){} // RVA: 0x7FFD54957F90
}

public class ReceiveTrackingValues : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53DC2620
}

public class Recentering : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC57440
    public void Validate(){} // RVA: 0x7FFD4FC57460
    public void CopyStateFrom(){} // RVA: 0x7FFD4FC57480
    public void CancelRecentering(){} // RVA: 0x7FFD4FC574A0
    public void RecenterNow(){} // RVA: 0x7FFD4FC57500
    public void DoRecentering(){} // RVA: 0x7FFD4FC57510
    public void LegacyUpgrade(){} // RVA: 0x7FFD4FC577E0
}

public class Record : ValueType
{
    public object header;
    public object recordIndex;
    public object valid;
    public object owner;
    public object index;
    public object time;
    public object control;
    public object next;
    public object previous;

    // ── Methods ──
    public void get_header(){} // RVA: 0x7FFD4E2ADC40
    public void get_recordIndex(){} // RVA: 0x7FFD4E079960
    public void get_valid(){} // RVA: 0x7FFD4E079D00
    public void get_owner(){} // RVA: 0x7FFD4E078E90
    public void get_index(){} // RVA: 0x7FFD4E079960
    public void get_time(){} // RVA: 0x7FFD4E07EB60
    public void get_control(){} // RVA: 0x7FFD4E078E90
    public void get_next(){} // RVA: 0x7FFD4E2ADC40
    public void get_previous(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x2
    public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
    public void GetUnsafeMemoryPtr(){} // RVA: 0x7FFD4E2ADC40
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x7FFD4E2ADC40
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x7FFD4E2ADC40
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x7FFD4E2ADC40
    public void CopyFrom(){} // RVA: 0x7FFD4E2ADC40
    public void CheckValid(){} // RVA: 0x7FFD4E090980
    public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFD4E079960
    public void ToString(){} // RVA: 0x7FFD4E078E90
}

public class RecordingItem : ValueType
{
}

public class RefCounted : Object
{
    public object refCount;

    // ── Methods ──
    public void get_refCount(){} // RVA: 0x7FFD4E079960
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Acquire(){} // RVA: 0x7FFD4E090980
    public void Release(){} // RVA: 0x7FFD4E090980
    public void Copy(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ReflectionHelper`2 : Object
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFD4E078F40
    public void CreateActionIMessage(){} // RVA: 0x7FFD4E078F40
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFD4E078F40
    public void CreateActionIMessageObject(){} // RVA: 0x7FFD4E078F40
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFD4E078F40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class Reflector : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E341310
    public void GetDerivedTypeSet(){} // RVA: 0x7FFD4E078A90
}

public class RegionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class RemoveAcesCallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class RenderRequest : ValueType
{
}

public class RendererNotifyInvisible : ValueType
{
}

public class RentArray`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51CE66B0
    public void Dispose(){} // RVA: 0x7FFD51CE68D0
    public void DisposeManually(){} // RVA: 0x7FFD51CE6950
}

public class Replica : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53AFC100
    public void Start(){} // RVA: 0x7FFD53AFC3F0
    public void Wait(){} // RVA: 0x7FFD53AFC480
    public void Execute(){} // RVA: 0x7FFD53AFC4D0
    public void CreateNewReplica(){} // RVA: 0x7FFD4E090980
    public void ExecuteAction(){} // RVA: 0x7FFD4E090A40
}

public class Replica`1 : Replica
{
    // ── Methods ──
    public void .ctor(){}
    public void CreateNewReplica(){} // RVA: 0x7FFD4E090980
    public void ExecuteAction(){} // RVA: 0x7FFD4E090A40
}

public class ReplicatableUserAction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E0986D0
}

public class RequestCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    public void HandleMessage(){} // RVA: 0x7FFD53C3B160
}

public class RequestCallback`1 : RequestCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void HandleMessage(){} // RVA: 0x7FFD4E090A40
}

public class RequestLightsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51D30B70
    public void Invoke(){} // RVA: 0x7FFD5106DBE0
}

public class ReservedName : ApiModel
{
    public object displayName;
    public object expires;

    // ── Methods ──
    public void get_displayName(){} // RVA: 0x7FFD4E3BCD50
    public void set_displayName(){} // RVA: 0x7FFD4E3BCD60
    public void get_expires(){} // RVA: 0x7FFD4E409590
    public void set_expires(){} // RVA: 0x7FFD4FE4BA60
    public void .ctor(){} // RVA: 0x7FFD57284C90
}

public class ResetFrameStatsAfterPresent : ValueType
{
}

public class ResetInputAxis : ValueType
{
}

public class ResolutionStruct : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F8431A0 | overloaded x2
    public void Initialize(){} // RVA: 0x7FFD4F843170
    public void DefaultEquals(){} // RVA: 0x7FFD4F843170
    public void Equals(){} // RVA: 0x7FFD4F843170
    public void InternalGetHashCode(){} // RVA: 0x7FFD4F843170
    public void GetHashCode(){} // RVA: 0x7FFD4F843170
    public void ToString(){} // RVA: 0x7FFD4F8431B0
    public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4F843170
    public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4F843170
    public void .ctor_2391253A6788(){} // RVA: 0x7FFD4F843170
    public void Equals_3903EA6EFB3E(){} // RVA: 0x7FFD4F843170
}

public class ResolveEventHolder : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ResourceRequestAwaiter : ValueType
{
    public object IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F2140
    public void OnCompleted(){} // RVA: 0x7FFD548F22D0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F22E0
}

public class Result : Object
{
    public object Status;
    public object Success;
    public object Error;
    public object Argument;

    // ── Methods ──
    public void get_Status(){} // RVA: 0x7FFD4E2ADC40
    public void get_Success(){} // RVA: 0x7FFD4E079D00
    public void get_Error(){} // RVA: 0x7FFD4E078E90
    public void get_Argument(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
}

public class ResultCallback : ValueType
{
}

public class ReturnObservable`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void Subscribe(){} // RVA: 0x7FFD4E078F40
}

public class ReverseComparer : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD4E2ADC40
}

public class RotationBySpeedModule : ValueType
{
    public object enabled;
    public object x;
    public object xMultiplier;
    public object y;
    public object yMultiplier;
    public object z;
    public object zMultiplier;
    public object separateAxes;
    public object range;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D77BC0
    public void set_enabled(){} // RVA: 0x7FFD54D77C10
    public void get_x(){} // RVA: 0x7FFD54D77C70
    public void set_x(){} // RVA: 0x7FFD54D77CE0
    public void get_xMultiplier(){} // RVA: 0x7FFD54D77D40
    public void set_xMultiplier(){} // RVA: 0x7FFD54D77D90
    public void get_y(){} // RVA: 0x7FFD54D77DF0
    public void set_y(){} // RVA: 0x7FFD54D77E60
    public void get_yMultiplier(){} // RVA: 0x7FFD54D77EC0
    public void set_yMultiplier(){} // RVA: 0x7FFD54D77F10
    public void get_z(){} // RVA: 0x7FFD54D77F70
    public void set_z(){} // RVA: 0x7FFD54D77FE0
    public void get_zMultiplier(){} // RVA: 0x7FFD54D78040
    public void set_zMultiplier(){} // RVA: 0x7FFD54D78090
    public void get_separateAxes(){} // RVA: 0x7FFD54D780F0
    public void set_separateAxes(){} // RVA: 0x7FFD54D78140
    public void get_range(){} // RVA: 0x7FFD54D781A0
    public void set_range(){} // RVA: 0x7FFD54D78200
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D77BC0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D77C10
    public void get_x_Injected(){} // RVA: 0x7FFD54D78260
    public void set_x_Injected(){} // RVA: 0x7FFD54D782C0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFD54D77D40
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFD54D77D90
    public void get_y_Injected(){} // RVA: 0x7FFD54D78320
    public void set_y_Injected(){} // RVA: 0x7FFD54D78380
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFD54D77EC0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFD54D77F10
    public void get_z_Injected(){} // RVA: 0x7FFD54D783E0
    public void set_z_Injected(){} // RVA: 0x7FFD54D78440
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFD54D78040
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFD54D78090
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D780F0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D78140
    public void get_range_Injected(){} // RVA: 0x7FFD54D784A0
    public void set_range_Injected(){} // RVA: 0x7FFD54D78500
}

public class RotationOverLifetimeModule : ValueType
{
    public object enabled;
    public object x;
    public object xMultiplier;
    public object y;
    public object yMultiplier;
    public object z;
    public object zMultiplier;
    public object separateAxes;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D773A0
    public void set_enabled(){} // RVA: 0x7FFD54D773F0
    public void get_x(){} // RVA: 0x7FFD54D77450
    public void set_x(){} // RVA: 0x7FFD54D774C0
    public void get_xMultiplier(){} // RVA: 0x7FFD54D77520
    public void set_xMultiplier(){} // RVA: 0x7FFD54D77570
    public void get_y(){} // RVA: 0x7FFD54D775D0
    public void set_y(){} // RVA: 0x7FFD54D77640
    public void get_yMultiplier(){} // RVA: 0x7FFD54D776A0
    public void set_yMultiplier(){} // RVA: 0x7FFD54D776F0
    public void get_z(){} // RVA: 0x7FFD54D77750
    public void set_z(){} // RVA: 0x7FFD54D777C0
    public void get_zMultiplier(){} // RVA: 0x7FFD54D77820
    public void set_zMultiplier(){} // RVA: 0x7FFD54D77870
    public void get_separateAxes(){} // RVA: 0x7FFD54D778D0
    public void set_separateAxes(){} // RVA: 0x7FFD54D77920
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D773A0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D773F0
    public void get_x_Injected(){} // RVA: 0x7FFD54D77980
    public void set_x_Injected(){} // RVA: 0x7FFD54D779E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFD54D77520
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFD54D77570
    public void get_y_Injected(){} // RVA: 0x7FFD54D77A40
    public void set_y_Injected(){} // RVA: 0x7FFD54D77AA0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFD54D776A0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFD54D776F0
    public void get_z_Injected(){} // RVA: 0x7FFD54D77B00
    public void set_z_Injected(){} // RVA: 0x7FFD54D77B60
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFD54D77820
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFD54D77870
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D778D0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D77920
}

public class Rotor : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFD4EA5AD50
    public void InternalEquals(){} // RVA: 0x7FFD4EA5B180
    public void DefaultEquals(){} // RVA: 0x7FFD4EA5B5C0
    public void GetHashCode(){} // RVA: 0x7FFD4EA5BA00
    public void InternalGetHashCode(){} // RVA: 0x7FFD4EA5BE40
    public void ToString(){} // RVA: 0x7FFD4EA5C280
}

public class RuntimePanelAccess : Object
{
    public object isInitialized;
    public object panel;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void get_isInitialized(){} // RVA: 0x7FFD4FC80B40
    public void get_panel(){} // RVA: 0x7FFD54FB95C0
    public void DisposePanel(){} // RVA: 0x7FFD54FB9A80
    public void SetTargetTexture(){} // RVA: 0x7FFD54FB9B40
    public void SetSortingPriority(){} // RVA: 0x7FFD54FB9BC0
    public void SetTargetDisplay(){} // RVA: 0x7FFD54FB9C00
    public void CreateRelatedRuntimePanel(){} // RVA: 0x7FFD54FB9C30
    public void DisposeRelatedPanel(){} // RVA: 0x7FFD54FB9D30
    public void MarkPotentiallyEmpty(){} // RVA: 0x7FFD54FB9D90
}
