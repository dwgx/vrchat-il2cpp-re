// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 83
// Methods: 429

public class RBTreeEnumerator : ValueType
{
    public object _index; // 0x312D3DD0
    public object _tree; // 0x85B480C0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void get_Current(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaa8660cc0
}

public class Range : ValueType
{
    public object Allocator; // 0x34E6BAB0
    public object Handle; // 0x1700000A

    // ── Original Methods ──
    public void Dispose(){} // RVA: 0x7ffaaef31330
}

public class RawData : Object
{
    public object Data; // 0x30327C00
}

public class ReadAllAsyncEnumerable : Object
{
    public object parent; // 0x312E9460
    public object cancellationTokenRegistration1; // 0x312E9460
    public object cacheValue; // 0x312E9460

    // ── Original Methods ──
    public void .ctor(){}
    public void get_Current(){} // RVA: 0x7ffaa887e5c0
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7ffaa8648be0
    public void CancellationCallback1(){} // RVA: 0x7ffaa8660d50
    public void CancellationCallback2(){} // RVA: 0x7ffaa8660d50
    // ── Binary Analysis Named ──
    public void GetAsyncEnumerator(){}
}

public class ReadAllAsyncEnumerable : Object
{
    public object parent; // 0x39EF1FC8
    public object cancellationTokenRegistration1; // 0x39EF1FC8
    public object cacheValue; // 0x39EF1FC8
}

public class ReadAllAsyncEnumerable : Object
{
    public object parent; // 0x39EF71B8
    public object cancellationTokenRegistration1; // 0x39EF71B8
    public object cacheValue; // 0x39EF71B8
}

public class ReadBoneJob : ValueType
{
    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaac830dd0
}

public class ReadDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae017bd0
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaa9e48d90
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaae017cb0
}

public class ReadFileJson : ValueType
{
    public object controlSchemes; // 0x33B3F1B0
    public object ToAsset; // 0xB3F6FFF0

    // ── Original Methods ──
    public void ToAsset(){} // RVA: 0x7ffaaef43120
}

public class ReadOnly : ValueType
{
    public object m_Buffer; // 0x32E9CCC8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void get_Length(){} // RVA: 0x7ffaa8649ca0
    public void get_Item(){} // RVA: 0x7ffaa887e5c0
    public void get_IsCreated(){} // RVA: 0x7ffaa864a040
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa1f3540
    public void get_Length(){} // RVA: 0x7ffaabf4ae50
    public void get_Item(){} // RVA: 0x7ffaabf4d1f0
    public void get_IsCreated(){} // RVA: 0x7ffaab7cf5a0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaac169120
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaac169120
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaabf4d510
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnly : ValueType
{
}

public class ReadOnlyArrayList : ArrayList
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadfc0570
    public void get_Count(){} // RVA: 0x7ffaadfc05e0
    public void get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
    public void get_IsFixedSize(){} // RVA: 0x7ffaa8a17850
    public void get_IsSynchronized(){} // RVA: 0x7ffaadfc0610
    public void get_Item(){} // RVA: 0x7ffaadfc0640
    public void set_Item(){} // RVA: 0x7ffaadfc0670
    public void get_SyncRoot(){} // RVA: 0x7ffaadfc06c0
    public void Add(){} // RVA: 0x7ffaadfc06f0
    public void AddRange(){} // RVA: 0x7ffaadfc0740
    public void set_Capacity(){} // RVA: 0x7ffaadfc0790
    public void Clear(){} // RVA: 0x7ffaadfc07e0
    public void Clone(){} // RVA: 0x7ffaadfc0830
    public void Contains(){} // RVA: 0x7ffaadfc09a0
    public void CopyTo(){} // RVA: 0x7ffaadfc0a00
    public void CopyTo(){} // RVA: 0x7ffaadfc0a00
    public void IndexOf(){} // RVA: 0x7ffaadfc0a60
    public void Insert(){} // RVA: 0x7ffaadfc0a90
    public void InsertRange(){} // RVA: 0x7ffaadfc0ae0
    public void Remove(){} // RVA: 0x7ffaadfc0b30
    public void RemoveAt(){} // RVA: 0x7ffaadfc0b80
    public void RemoveRange(){} // RVA: 0x7ffaadfc0bd0
    public void Reverse(){} // RVA: 0x7ffaadfc0c20
    public void Sort(){} // RVA: 0x7ffaadfc0c70
    public void ToArray(){} // RVA: 0x7ffaadfc0cf0
    public void ToArray(){} // RVA: 0x7ffaadfc0cf0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaadfc0a30
}

public class ReadOnlyKeyCollection : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab182ced0
    public void get_Count(){} // RVA: 0x7ffab182cf90
    public void get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
    public void get_SyncRoot(){} // RVA: 0x7ffab182cfe0
    public void get_IsSynchronized(){} // RVA: 0x7ffaa8932320
    public void Add(){} // RVA: 0x7ffab182d040
    public void Clear(){} // RVA: 0x7ffab182d080
    public void Contains(){} // RVA: 0x7ffab182d0c0
    public void CopyTo(){} // RVA: 0x7ffab182d2f0
    public void CopyTo(){} // RVA: 0x7ffab182d2f0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffab182d4d0
    public void Remove(){} // RVA: 0x7ffab182d520
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffab182d4d0
}

public class ReadTransformJob : ValueType
{
    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaac830dd0
}

public class ReadWriteParameters : ValueType
{
    public object Count; // 0x344B4DC0
}

public class ReadWriteTask : Task`1
{
    public object _stream; // 0x344B4F40
    public object _count; // 0x344B4F40
    public object s_invokeAsyncCallback; // 0x344B4F40
    public object System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode; // 0x17000961
    public object .;

    // ── Original Methods ──
    public void ClearBeginState(){} // RVA: 0x7ffaae00aba0
    public void .ctor(){} // RVA: 0x7ffaae00ac50
    public void InvokeAsyncCallback(){} // RVA: 0x7ffaae00afd0
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x7ffaae00b0a0
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0x7ffaa8a17850
}

public class Reader : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void DangerousGetRawExecutionContext(){} // RVA: 0x7ffaa950bda0
    public void get_IsNull(){} // RVA: 0x7ffaaa254200
    public void IsDefaultFTContext(){} // RVA: 0x7ffaae0ea630
    public void get_IsFlowSuppressed(){} // RVA: 0x7ffaae0ea650
    public void get_SynchronizationContext(){} // RVA: 0x7ffaae0ea670
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x7ffaae0ea690
    public void get_LogicalCallContext(){} // RVA: 0x7ffaae0ea6b0
    public void HasSameLocalValues(){} // RVA: 0x7ffaae0ea7a0
    // ── Binary Analysis Named ──
    public void GetLocalValue(){} // RVA: 0x7ffaae0ea720
}

public class Reader : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_IsNull(){} // RVA: 0x7ffaaa254200
    public void get_HasInfo(){} // RVA: 0x7ffaadeacad0
    public void Clone(){} // RVA: 0x7ffaadeacaf0
    // ── Binary Analysis Named ──
    public void GetData(){} // RVA: 0x7ffaadeacb60
}

public class ReaderCache : Object
{
    // ── Original Methods ──
    public void TryReadTo(){} // RVA: 0x7ffab1b0d650
    public void TryReadTo(){} // RVA: 0x7ffab1b0d650
    public void ReadBoxed(){} // RVA: 0x7ffaa86583d0
    public void Register(){} // RVA: 0x7ffaa8660cf0
    public void ReadBoxed(){} // RVA: 0x7ffaa86583d0
    public void EnumJsonWrite(){} // RVA: 0x7ffaa887e5c0
    public void EnumStringWrite(){} // RVA: 0x7ffaa864bfa0
    public void EnumUtf8Write(){} // RVA: 0x7ffaa864bfa0
    public void GuidJsonWrite(){} // RVA: 0x7ffab1b0d9a0
    public void DateTimeOffsetJsonWrite(){} // RVA: 0x7ffab1b0da60
    public void JsonSerialize(){} // RVA: 0x7ffaa887e5c0
    public void StringAppendFormatted(){} // RVA: 0x7ffaa864bfa0
    public void Utf8AppendFormatted(){} // RVA: 0x7ffaa864bfa0
    public void .cctor(){} // RVA: 0x7ffab1b0db20
}

public class ReapplyDrivenProperties : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa898db80
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class RebindingOperation : Object
{
    public object m_BindingMask; // 0x31A64030
    public object m_IncludePathCount; // 0x31A64030
    public object m_ExcludePaths; // 0x31A64030
    public object m_CancelBinding; // 0x31A64030
    public object m_Magnitudes; // 0x31A64030
    public object m_Timeout; // 0x31A64030
    public object m_OnComplete; // 0x31A64030
    public object m_OnGeneratePath; // 0x31A64030
    public object m_OnEventDelegate; // 0x31A64030
    public object m_PathBuilder; // 0x31A64030

    // ── Original Methods ──
    public void get_action(){} // RVA: 0x7ffaa894d380
    public void get_bindingMask(){} // RVA: 0x7ffaac75ad00
    public void get_candidates(){} // RVA: 0x7ffaaef55c20
    public void get_scores(){} // RVA: 0x7ffaaef55c40
    public void get_magnitudes(){} // RVA: 0x7ffaaef55d00
    public void get_selectedControl(){} // RVA: 0x7ffaaef55dc0
    public void get_started(){} // RVA: 0x7ffaaef55e30
    public void get_completed(){} // RVA: 0x7ffaaef55e40
    public void get_canceled(){} // RVA: 0x7ffaaef55e50
    public void get_startTime(){} // RVA: 0x7ffaaef55e60
    public void get_timeout(){} // RVA: 0x7ffaac1206c0
    public void get_expectedControlType(){} // RVA: 0x7ffaaef55e70
    public void WithAction(){} // RVA: 0x7ffaaef55ed0
    public void WithMatchingEventsBeingSuppressed(){} // RVA: 0x7ffaaef560e0
    public void WithCancelingThrough(){} // RVA: 0x7ffaaef56230
    public void WithCancelingThrough(){} // RVA: 0x7ffaaef56230
    public void WithExpectedControlType(){} // RVA: 0x7ffaa86491d0
    public void WithExpectedControlType(){} // RVA: 0x7ffaa86491d0
    public void WithExpectedControlType(){} // RVA: 0x7ffaa86491d0
    public void WithTargetBinding(){} // RVA: 0x7ffaaef565e0
    public void WithBindingMask(){} // RVA: 0x7ffaaef57180
    public void WithBindingGroup(){} // RVA: 0x7ffaaef57210
    public void WithoutGeneralizingPathOfSelectedControl(){} // RVA: 0x7ffaaef573f0
    public void WithRebindAddingNewBinding(){} // RVA: 0x7ffaaef57400
    public void WithMagnitudeHavingToBeGreaterThan(){} // RVA: 0x7ffaaef57470
    public void WithoutIgnoringNoisyControls(){} // RVA: 0x7ffaaef57580
    public void WithControlsHavingToMatchPath(){} // RVA: 0x7ffaaef575f0
    public void WithControlsExcluding(){} // RVA: 0x7ffaaef57800
    public void WithTimeout(){} // RVA: 0x7ffaaef57a10
    public void OnComplete(){} // RVA: 0x7ffaaef597d0
    public void OnCancel(){} // RVA: 0x7ffaaef59c00
    public void OnPotentialMatch(){} // RVA: 0x7ffaaef57ae0
    public void OnGeneratePath(){} // RVA: 0x7ffaaef57b40
    public void OnComputeScore(){} // RVA: 0x7ffaaef57ba0
    public void OnApplyBinding(){} // RVA: 0x7ffaaef57c00
    public void OnMatchWaitForAnother(){} // RVA: 0x7ffaaef57c60
    public void Start(){} // RVA: 0x7ffaaef57c70
    public void Cancel(){} // RVA: 0x7ffaaef58030
    public void Complete(){} // RVA: 0x7ffaaef58080
    public void AddCandidate(){} // RVA: 0x7ffaaef580a0
    public void RemoveCandidate(){} // RVA: 0x7ffaaef58220
    public void Dispose(){} // RVA: 0x7ffaaef58370
    public void Finalize(){} // RVA: 0x7ffaaef58460
    public void Reset(){} // RVA: 0x7ffaaef58570
    public void HookOnEvent(){} // RVA: 0x7ffaaef587c0
    public void UnhookOnEvent(){} // RVA: 0x7ffaaef588e0
    public void OnEvent(){} // RVA: 0x7ffaaef58950
    public void SortCandidatesByScore(){} // RVA: 0x7ffaaef592d0
    public void HavePathMatch(){} // RVA: 0x7ffaaef59480
    public void HookOnAfterUpdate(){} // RVA: 0x7ffaaef59500
    public void UnhookOnAfterUpdate(){} // RVA: 0x7ffaaef59620
    public void OnAfterUpdate(){} // RVA: 0x7ffaaef59690
    public void OnComplete(){} // RVA: 0x7ffaaef597d0
    public void OnCancel(){} // RVA: 0x7ffaaef59c00
    public void ResetAfterMatchCompleted(){} // RVA: 0x7ffaaef59c40
    public void ThrowIfRebindInProgress(){} // RVA: 0x7ffaaef59d40
    public void GeneratePathForControl(){} // RVA: 0x7ffaaef59db0
    public void .ctor(){} // RVA: 0x7ffaaef59f60
}

public class ReceiveTrackingValues : Object
{
    public object reliableSequencedNumbersCompletelyReceived; // 0x35FB3AC0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae3c3830
}

public class ReceiverData : ValueType
{
    public object receiverType; // 0x350E58A0

    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaf848010
    public void Dispose(){} // RVA: 0x7ffaaf848160
}

public class Recentering : ValueType
{
    public object m_RecenteringTime; // 0x34B449C0
    public object mRecenteringVelocity; // 0x34B449C0
    public object m_Definition; // 0x34B3F490

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa23f350
    public void Validate(){} // RVA: 0x7ffaaa23f370
    public void CopyStateFrom(){} // RVA: 0x7ffaaa23f390
    public void CancelRecentering(){} // RVA: 0x7ffaaa23f3b0
    public void RecenterNow(){} // RVA: 0x7ffaaa23f410
    public void LegacyUpgrade(){} // RVA: 0x7ffaaa23f6f0
    // ── Binary Analysis Named ──
    public void DoRecentering(){} // RVA: 0x7ffaaa23f420
}

public class Record : ValueType
{
    public object m_Version; // 0x30F3FA40

    // ── Original Methods ──
    public void get_header(){} // RVA: 0x7ffaa887e5c0
    public void get_recordIndex(){} // RVA: 0x7ffaa8649ca0
    public void get_valid(){} // RVA: 0x7ffaa864a040
    public void get_owner(){} // RVA: 0x7ffaa86491d0
    public void get_index(){} // RVA: 0x7ffaa8649ca0
    public void get_time(){} // RVA: 0x7ffaa864eea0
    public void get_control(){} // RVA: 0x7ffaa86491d0
    public void get_next(){} // RVA: 0x7ffaa887e5c0
    public void get_previous(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void .ctor(){} // RVA: 0x7ffaa8667cb0
    public void ReadValue(){} // RVA: 0x7ffaa887e5c0
    public void CopyFrom(){} // RVA: 0x7ffaa887e5c0
    public void Equals(){} // RVA: 0x7ffaa864a2a0
    public void Equals(){} // RVA: 0x7ffaa864a2a0
    public void ToString(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetUnsafeMemoryPtr(){} // RVA: 0x7ffaa887e5c0
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x7ffaa887e5c0
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x7ffaa887e5c0
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x7ffaa887e5c0
    public void CheckValid(){} // RVA: 0x7ffaa8660cc0
    public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
}

public class Record : ValueType
{
    public object m_Version; // 0x31A64DF0
    public object header; // 0x17000522

    // ── Original Methods ──
    public void get_header(){} // RVA: 0x7ffaaf0a7f40
    public void get_recordIndex(){} // RVA: 0x7ffaac265fe0
    public void get_version(){} // RVA: 0x7ffaaa3cefa0
    public void get_valid(){} // RVA: 0x7ffaaf0a7f70
    public void get_owner(){} // RVA: 0x7ffaa950bda0
    public void get_index(){} // RVA: 0x7ffaaf0a7fc0
    public void get_time(){} // RVA: 0x7ffaaf0a8000
    public void get_control(){} // RVA: 0x7ffaaf0a8040
    public void get_next(){} // RVA: 0x7ffaaf0a81c0
    public void get_previous(){} // RVA: 0x7ffaaf0a82e0
    public void .ctor(){} // RVA: 0x7ffaac266790
    public void ReadValue(){} // RVA: 0x7ffaa887e5c0
    public void ReadValueAsObject(){} // RVA: 0x7ffaaf0a8400
    public void CopyFrom(){} // RVA: 0x7ffaaf0a8610
    public void Equals(){} // RVA: 0x7ffaaf0a8bb0
    public void Equals(){} // RVA: 0x7ffaaf0a8bb0
    public void ToString(){} // RVA: 0x7ffaaf0a8c50
    // ── Binary Analysis Named ──
    public void GetUnsafeMemoryPtr(){} // RVA: 0x7ffaaf0a8450
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x7ffaaf0a8470
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x7ffaaf0a8510
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x7ffaaf0a8530
    public void CheckValid(){} // RVA: 0x7ffaaf0a8ae0
    public void GetHashCode(){} // RVA: 0x7ffaac2671e0
}

public class RecordingItem : ValueType
{
    public object Item; // 0x34B4DB70
}

public class RefCounted : Object
{
    public object m_Id; // 0x312EB980
    public object m_RefCount; // 0x35BD0560

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa8649ca0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Acquire(){} // RVA: 0x7ffaa8660cc0
    public void Release(){} // RVA: 0x7ffaa8660cc0
    public void Copy(){} // RVA: 0x7ffaa86491d0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BD0560

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac268fd0
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BD3270

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac269160
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BED0D0

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac2692f0
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BEEAD0

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac2693d0
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BF2000

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac269480
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class RefCounted : Object
{
    public object m_Id; // 0x35BF3290

    // ── Original Methods ──
    public void get_refCount(){} // RVA: 0x7ffaa897f5c0
    public void .ctor(){} // RVA: 0x7ffaac268ef0
    public void Acquire(){} // RVA: 0x7ffaac268fb0
    public void Release(){} // RVA: 0x7ffaac268fc0
    public void Copy(){} // RVA: 0x7ffaac269570
    public void .cctor(){} // RVA: 0x7ffaac269100
}

public class ReflectionHelper`2 : Object
{
    // ── Original Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7ffaa8649280
    public void CreateActionIMessage(){} // RVA: 0x7ffaa8649280
    public void CreateFuncIMessageObject(){} // RVA: 0x7ffaa8649280
    public void CreateActionIMessageObject(){} // RVA: 0x7ffaa8649280
    public void CreateFuncIMessageBool(){} // RVA: 0x7ffaa8649280
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class Reflector : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetDerivedTypeSet(){} // RVA: 0x7ffaa8648dd0
}

public class RegionDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa89b2190
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}

public class RelationshipHandle : ValueType
{
    // ── Original Methods ──
    public void Drop(){} // RVA: 0x7ffaaa37e070
    public void DiscordRelationshipType(){} // RVA: 0x7ffaaa37e0f0
    public void User(){} // RVA: 0x7ffaaa37e170
}

public class RemoveAcesCallback`1 : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class RenderRequest : ValueType
{
    public object m_OutputSpace; // 0x32FB2E00
    public object `Ǐf; // 0x671BC9FD
}

public class RendererNotifyInvisible : ValueType
{
}

public class RentArray`1 : ValueType
{
    public object pool; // 0x300D0A70

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac2d8160
    public void Dispose(){} // RVA: 0x7ffaac2d8380
    public void DisposeManually(){} // RVA: 0x7ffaac2d8400
}

public class RentArray`1 : ValueType
{
    public object pool; // 0x312EBE30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8668a10
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void DisposeManually(){} // RVA: 0x7ffaa86613a0
}

public class RentArray`1 : ValueType
{
    public object pool; // 0x37BE7248

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac2d8160
    public void Dispose(){} // RVA: 0x7ffaac2d8380
    public void DisposeManually(){} // RVA: 0x7ffaac2d8400
}

public class Replica : Object
{
    public object _remainingConcurrency; // 0x31361850
    public object _state; // 0x313616B0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae0fd310
    public void Start(){} // RVA: 0x7ffaae0fd600
    public void Wait(){} // RVA: 0x7ffaae0fd690
    public void Execute(){} // RVA: 0x7ffaae0fd6e0
    public void CreateNewReplica(){} // RVA: 0x7ffaa8660cc0
    public void ExecuteAction(){} // RVA: 0x7ffaa8660d80
}

public class Replica`1 : Replica
{
    public object _action; // 0x366F3CA8

    // ── Original Methods ──
    public void .ctor(){}
    public void CreateNewReplica(){} // RVA: 0x7ffaa8660cc0
    public void ExecuteAction(){} // RVA: 0x7ffaa8660d80
}

public class Replica`1 : Replica
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac2e6090
    public void CreateNewReplica(){} // RVA: 0x7ffaac2e6100
    public void ExecuteAction(){} // RVA: 0x7ffaac2e6240
}

public class ReplicatableUserAction`1 : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa8668a10
}

public class ReplicatableUserAction`1 : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac2e6530
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
}

public class RequestCallback : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void HandleMessage(){} // RVA: 0x7ffaae23c370
}

public class RequestCallback`1 : RequestCallback
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void HandleMessage(){} // RVA: 0x7ffaa8660d80
}

public class RequestLightsDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac322620
    public void Invoke(){} // RVA: 0x7ffaab656810
}

public class ResetFrameStatsAfterPresent : ValueType
{
}

public class ResetInputAxis : ValueType
{
}

public class ResolutionStruct : ValueType
{
    public object frameRate; // 0x33F6E890

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9e49e40
    public void Initialize(){} // RVA: 0x7ffaa9e49e10
    public void DefaultEquals(){} // RVA: 0x7ffaa9e49e10
    public void Equals(){} // RVA: 0x7ffaa9e49e10
    public void InternalGetHashCode(){} // RVA: 0x7ffaa9e49e10
    public void .ctor(){} // RVA: 0x7ffaa9e49e40
    public void ToString(){} // RVA: 0x7ffaa9e49e50
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa9e49e10
    public void SetResolutionData(){} // RVA: 0x7ffaa9e49e10
    // ── Obfuscated Methods ──
    public void m_BE9(){} // RVA: 0x7ffaa9e49e10
}

public class ResolveEventHolder : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class ResourceRequestAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa95e1380
    public void get_IsCompleted(){} // RVA: 0x7ffaaeef0cd0
    public void OnCompleted(){} // RVA: 0x7ffaaeef42a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaaeef42b0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeef4110
}

public class Result : Object
{
    public object _argument; // 0x31362550, was: <Argument>k__BackingField
    public object Status; // 0x17000557

    // ── Original Methods ──
    public void get_Status(){} // RVA: 0x7ffaa887e5c0
    public void get_Success(){} // RVA: 0x7ffaa864a040
    public void get_Error(){} // RVA: 0x7ffaa86491d0
    public void get_Argument(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
}

public class ResultCallback : ValueType
{
}

public class ReturnObservable`1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void Subscribe(){} // RVA: 0x7ffaa8649280
}

public class ReverseComparer : ValueType
{
    // ── Original Methods ──
    public void Compare(){} // RVA: 0x7ffaa887e5c0
}

public class ReverseComparer : ValueType
{
    // ── Original Methods ──
    public void Compare(){} // RVA: 0x7ffaac2e79f0
}

public class ReverseComparer : ValueType
{
    // ── Original Methods ──
    public void Compare(){} // RVA: 0x7ffaac2e7d20
}

public class RotationBySpeedModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf379b20
    public void set_enabled(){} // RVA: 0x7ffaaf379b70
    public void get_x(){} // RVA: 0x7ffaaf379bd0
    public void set_x(){} // RVA: 0x7ffaaf379c40
    public void get_xMultiplier(){} // RVA: 0x7ffaaf379ca0
    public void set_xMultiplier(){} // RVA: 0x7ffaaf379cf0
    public void get_y(){} // RVA: 0x7ffaaf379d50
    public void set_y(){} // RVA: 0x7ffaaf379dc0
    public void get_yMultiplier(){} // RVA: 0x7ffaaf379e20
    public void set_yMultiplier(){} // RVA: 0x7ffaaf379e70
    public void get_z(){} // RVA: 0x7ffaaf379ed0
    public void set_z(){} // RVA: 0x7ffaaf379f40
    public void get_zMultiplier(){} // RVA: 0x7ffaaf379fa0
    public void set_zMultiplier(){} // RVA: 0x7ffaaf379ff0
    public void get_separateAxes(){} // RVA: 0x7ffaaf37a050
    public void set_separateAxes(){} // RVA: 0x7ffaaf37a0a0
    public void get_range(){} // RVA: 0x7ffaaf37a100
    public void set_range(){} // RVA: 0x7ffaaf37a160
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf379b20
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf379b70
    public void get_x_Injected(){} // RVA: 0x7ffaaf37a1c0
    public void set_x_Injected(){} // RVA: 0x7ffaaf37a220
    public void get_xMultiplier_Injected(){} // RVA: 0x7ffaaf379ca0
    public void set_xMultiplier_Injected(){} // RVA: 0x7ffaaf379cf0
    public void get_y_Injected(){} // RVA: 0x7ffaaf37a280
    public void set_y_Injected(){} // RVA: 0x7ffaaf37a2e0
    public void get_yMultiplier_Injected(){} // RVA: 0x7ffaaf379e20
    public void set_yMultiplier_Injected(){} // RVA: 0x7ffaaf379e70
    public void get_z_Injected(){} // RVA: 0x7ffaaf37a340
    public void set_z_Injected(){} // RVA: 0x7ffaaf37a3a0
    public void get_zMultiplier_Injected(){} // RVA: 0x7ffaaf379fa0
    public void set_zMultiplier_Injected(){} // RVA: 0x7ffaaf379ff0
    public void get_separateAxes_Injected(){} // RVA: 0x7ffaaf37a050
    public void set_separateAxes_Injected(){} // RVA: 0x7ffaaf37a0a0
    public void get_range_Injected(){} // RVA: 0x7ffaaf37a400
    public void set_range_Injected(){} // RVA: 0x7ffaaf37a460
}

public class RotationOverLifetimeModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf379300
    public void set_enabled(){} // RVA: 0x7ffaaf379350
    public void get_x(){} // RVA: 0x7ffaaf3793b0
    public void set_x(){} // RVA: 0x7ffaaf379420
    public void get_xMultiplier(){} // RVA: 0x7ffaaf379480
    public void set_xMultiplier(){} // RVA: 0x7ffaaf3794d0
    public void get_y(){} // RVA: 0x7ffaaf379530
    public void set_y(){} // RVA: 0x7ffaaf3795a0
    public void get_yMultiplier(){} // RVA: 0x7ffaaf379600
    public void set_yMultiplier(){} // RVA: 0x7ffaaf379650
    public void get_z(){} // RVA: 0x7ffaaf3796b0
    public void set_z(){} // RVA: 0x7ffaaf379720
    public void get_zMultiplier(){} // RVA: 0x7ffaaf379780
    public void set_zMultiplier(){} // RVA: 0x7ffaaf3797d0
    public void get_separateAxes(){} // RVA: 0x7ffaaf379830
    public void set_separateAxes(){} // RVA: 0x7ffaaf379880
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf379300
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf379350
    public void get_x_Injected(){} // RVA: 0x7ffaaf3798e0
    public void set_x_Injected(){} // RVA: 0x7ffaaf379940
    public void get_xMultiplier_Injected(){} // RVA: 0x7ffaaf379480
    public void set_xMultiplier_Injected(){} // RVA: 0x7ffaaf3794d0
    public void get_y_Injected(){} // RVA: 0x7ffaaf3799a0
    public void set_y_Injected(){} // RVA: 0x7ffaaf379a00
    public void get_yMultiplier_Injected(){} // RVA: 0x7ffaaf379600
    public void set_yMultiplier_Injected(){} // RVA: 0x7ffaaf379650
    public void get_z_Injected(){} // RVA: 0x7ffaaf379a60
    public void set_z_Injected(){} // RVA: 0x7ffaaf379ac0
    public void get_zMultiplier_Injected(){} // RVA: 0x7ffaaf379780
    public void set_zMultiplier_Injected(){} // RVA: 0x7ffaaf3797d0
    public void get_separateAxes_Injected(){} // RVA: 0x7ffaaf379830
    public void set_separateAxes_Injected(){} // RVA: 0x7ffaaf379880
}

public class Rotor : ValueType
{
    public object rollModifier; // 0x340D7770
    public object _rotor; // 0x33549690, was: ÍÏÏÎÎÌÌÌÏÌÎÎÍÍÎÍÏÏÌÍÎÎÌ

    // ── Original Methods ──
    public void ComputeeulerAngles(){} // RVA: 0x7ffaa9066b40
    public void DefaultEquals(){} // RVA: 0x7ffaa9066f80
    public void Equals(){} // RVA: 0x7ffaa90673c0
    public void InternalGetHashCode(){} // RVA: 0x7ffaa9067800
    // ── Binary Analysis Named ──
    public void DoInternal_FromEu(){} // RVA: 0x7ffaa9066700
    public void GetHashCode(){} // RVA: 0x7ffaa9067c30
}

public class RuntimePanelAccess : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void get_isInitialized(){} // RVA: 0x7ffaaa268a50
    public void get_panel(){} // RVA: 0x7ffaaf5bb530
    public void DisposePanel(){} // RVA: 0x7ffaaf5bb9f0
    public void CreateRelatedRuntimePanel(){} // RVA: 0x7ffaaf5bbba0
    public void DisposeRelatedPanel(){} // RVA: 0x7ffaaf5bbca0
    public void MarkPotentiallyEmpty(){} // RVA: 0x7ffaaf5bbd00
    // ── Binary Analysis Named ──
    public void SetTargetTexture(){} // RVA: 0x7ffaaf5bbab0
    public void SetSortingPriority(){} // RVA: 0x7ffaaf5bbb30
    public void SetTargetDisplay(){} // RVA: 0x7ffaaf5bbb70
}
