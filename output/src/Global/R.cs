// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 478

public class RBTreeEnumerator : ValueType
{
    public System.Data.RBTree`1<T> _tree;
    public int _version;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
}

public class REG_TZI_FORMAT : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86733A50
}

public class RaiseDataUsage : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RaiseMessageToAll : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RaiseMessageToPlayer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE812572A0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881907B0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Range : ValueType
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE878B7AA0
}

public class RangeIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878A5BF0
    public void GetHashCode(){} // RVA: 0x7FFE878A5C10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RawData : Object
{
}

public class RawTexture : ValueType
{
    // ── Methods ──
    public void WriteRawInt2Packed(){} // RVA: 0x7FFE87E84390
    public void WriteRawFloat4Packed(){} // RVA: 0x7FFE87E84430
}

public class RayHitComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE811369F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Raycast2DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A8B0
    public void Invoke(){} // RVA: 0x7FFE8801A980
    public void BeginInvoke(){} // RVA: 0x7FFE8801A9E0
    public void EndInvoke(){} // RVA: 0x7FFE8801AAD0
}

public class Raycast3DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A310
    public void Invoke(){} // RVA: 0x7FFE8801A3E0
    public void BeginInvoke(){} // RVA: 0x7FFE8801A420
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
}

public class RaycastAllCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A520
    public void Invoke(){} // RVA: 0x7FFE8801A5F0
    public void BeginInvoke(){} // RVA: 0x7FFE8801A630
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RaycastHit : ValueType
{
}

public class RaycastHitComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE86D397C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE88035EB0
}

public class RaycastHitData : ValueType
{
    public UnityEngine.UI.Graphic _graphic; // 0x10
    public UnityEngine.Vector3 _worldHitPosition; // 0x18
    public UnityEngine.Vector2 _screenPosition; // 0x24
    public float _distance; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE879FCC70
    public void get_graphic(){} // RVA: 0x7FFE8284EF60
    public void get_worldHitPosition(){} // RVA: 0x7FFE8445AD40
    public void get_screenPosition(){} // RVA: 0x7FFE83BBD0C0
    public void get_distance(){} // RVA: 0x7FFE811C8570
}

public class ReachCone : Object
{
    public UnityEngine.Vector3[] tetrahedron; // 0x10
    public float volume; // 0x18
    public UnityEngine.Vector3 S; // 0x1C
    public UnityEngine.Vector3 B; // 0x28
    public object field_4; // 0x130

    // ── Methods ──
    public void get_o(){} // RVA: 0x7FFE812647C0
    public void get_a(){} // RVA: 0x7FFE81264800
    public void get_b(){} // RVA: 0x7FFE81264840
    public void get_c(){} // RVA: 0x7FFE81264880
    public void .ctor(){} // RVA: 0x7FFE812648C0
    public void get_isValid(){} // RVA: 0x7FFE81264AA0
    public void Calculate(){} // RVA: 0x7FFE81264AB0
}

public class ReadActionJson : ValueType
{
    // ── Methods ──
    public void ToAction(){} // RVA: 0x7FFE878D0660
}

public class ReadAllAsyncEnumerable : Object
{
    public System.Action`1<object> CancellationCallback1Delegate;

    // ── Methods ──
    public void .ctor(){}
    public void GetAsyncEnumerator(){}
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
    public void CancellationCallback1(){} // RVA: 0x7FFE80E46070
    public void CancellationCallback2(){} // RVA: 0x7FFE80E46070
}

public class ReadBoneJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE851A9D20
}

public class ReadBufferState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87687260
}

public class ReadDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869A0180
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE869A0260
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class ReadFileJson : ValueType
{
    // ── Methods ──
    public void ToAsset(){} // RVA: 0x7FFE878C9890
}

public class ReadInstanceDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ReadMapJson : ValueType
{
}

public class ReadMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869A0180
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE87808D80
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class ReadOnly : ValueType
{
    public void* m_Buffer;
    public int m_Length;
    public void* m_Buffer; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void get_Length(){} // RVA: 0x7FFE80E2EDB0
    public void get_Item(){} // RVA: 0x7FFE810A1420
    public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class ReadOnlyArrayList : ArrayList
{
    public System.Collections.ArrayList _list; // 0x28
    public object field_1; // 0x818
    public object field_2; // 0x819
    public object field_3; // 0x81A
    public object field_4; // 0x81B
    public object field_5; // 0x81C
    public object field_6; // 0x81D

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86948B30
    public void get_Count(){} // RVA: 0x7FFE86948BA0
    public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
    public void get_IsSynchronized(){} // RVA: 0x7FFE86948BD0
    public void get_Item(){} // RVA: 0x7FFE86948C00
    public void set_Item(){} // RVA: 0x7FFE86948C30
    public void get_SyncRoot(){} // RVA: 0x7FFE86948C80
    public void Add(){} // RVA: 0x7FFE86948CB0
    public void AddRange(){} // RVA: 0x7FFE86948D00
    public void set_Capacity(){} // RVA: 0x7FFE86948D50
    public void Clear(){} // RVA: 0x7FFE86948DA0
    public void Clone(){} // RVA: 0x7FFE86948DF0
    public void Contains(){} // RVA: 0x7FFE86948F60
    public void CopyTo(){} // RVA: 0x7FFE86948FC0 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFE86948FF0
    public void IndexOf(){} // RVA: 0x7FFE86949020
    public void Insert(){} // RVA: 0x7FFE86949050
    public void InsertRange(){} // RVA: 0x7FFE869490A0
    public void Remove(){} // RVA: 0x7FFE869490F0
    public void RemoveAt(){} // RVA: 0x7FFE86949140
    public void RemoveRange(){} // RVA: 0x7FFE86949190
    public void Reverse(){} // RVA: 0x7FFE869491E0
    public void Sort(){} // RVA: 0x7FFE86949230
    public void ToArray(){} // RVA: 0x7FFE869492B0 | overloaded x2
}

public class ReadOnlyIPAddress : IPAddress
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8780FD90
}

public class ReadOnlyKeyCollection : Object
{
    public System.Collections.Generic.IReadOnlyCollection`1<string> m_Keys; // 0x10
    public object field_1; // 0x987
    public object field_2; // 0x988
    public object field_3; // 0x989

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A26A810
    public void get_Count(){} // RVA: 0x7FFE8A26A8D0
    public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
    public void get_SyncRoot(){} // RVA: 0x7FFE8A26A920
    public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void Add(){} // RVA: 0x7FFE8A26A980
    public void Clear(){} // RVA: 0x7FFE8A26A9C0
    public void Contains(){} // RVA: 0x7FFE8A26AA00
    public void CopyTo(){} // RVA: 0x7FFE8A26AC30 | overloaded x2
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A26AE10
    public void GetEnumerator(){} // RVA: 0x7FFE8A26AE10
    public void Remove(){} // RVA: 0x7FFE8A26AE60
}

public class ReadPlayerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84423E50
    public void Invoke(){} // RVA: 0x7FFE81998A70
    public void BeginInvoke(){} // RVA: 0x7FFE88190710
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ReadTransformJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE851A9D20
}

public class ReadWriteParameters : ValueType
{
}

public class ReadWriteTask : Task`1
{
    public bool _isRead; // 0x58

    // ── Methods ──
    public void ClearBeginState(){} // RVA: 0x7FFE86993150
    public void .ctor(){} // RVA: 0x7FFE86993200
    public void InvokeAsyncCallback(){} // RVA: 0x7FFE86993580
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x7FFE86993650
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFE811E0850
}

public class Reader : ValueType
{
    public System.Threading.ExecutionContext m_ec; // 0x10
    public object field_1; // 0xDAF8
    public object field_2; // 0xDCB0
    public object field_3; // 0x9B40
    public object field_4; // 0x150B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void DangerousGetRawExecutionContext(){} // RVA: 0x7FFE8284EF60
    public void get_IsNull(){} // RVA: 0x7FFE82AB4690
    public void IsDefaultFTContext(){} // RVA: 0x7FFE86A72BD0
    public void get_IsFlowSuppressed(){} // RVA: 0x7FFE86A72BF0
    public void get_SynchronizationContext(){} // RVA: 0x7FFE86A72C10
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFE86A72C30
    public void get_LogicalCallContext(){} // RVA: 0x7FFE86A72C50
    public void GetLocalValue(){} // RVA: 0x7FFE86A72CC0
    public void HasSameLocalValues(){} // RVA: 0x7FFE86A72D40
}

public class ReaderCache : Object
{
    // ── Methods ──
    public void TryReadTo(){} // RVA: 0x7FFE8A557710 | overloaded x2
    public void ReadBoxed(){} // RVA: 0x7FFE80E3D4E0 | overloaded x2
    public void Register(){} // RVA: 0x7FFE80E46010
    public void EnumJsonWrite(){} // RVA: 0x7FFE810A1420
    public void EnumStringWrite(){} // RVA: 0x7FFE80E310B0
    public void EnumUtf8Write(){} // RVA: 0x7FFE80E310B0
    public void GuidJsonWrite(){} // RVA: 0x7FFE8A557A60
    public void DateTimeOffsetJsonWrite(){} // RVA: 0x7FFE8A557B20
    public void JsonSerialize(){} // RVA: 0x7FFE810A1420
    public void StringAppendFormatted(){} // RVA: 0x7FFE80E310B0
    public void Utf8AppendFormatted(){} // RVA: 0x7FFE80E310B0
    public void .cctor(){} // RVA: 0x7FFE8A557BE0
}

public class ReaderCallbackInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void ReadObject(){} // RVA: 0x7FFE875FAD20
}

public class ReapplyDrivenProperties : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class RebindingOperation : Object
{
    public float kDefaultMagnitudeThreshold;
    public UnityEngine.InputSystem.InputAction m_ActionToRebind; // 0x10
    public System.Nullable`1<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x18
    public System.Type m_ControlType; // 0x78
    public UnityEngine.InputSystem.Utilities.InternedString m_ExpectedLayout; // 0x80
    public int m_IncludePathCount; // 0x90
    public string[] m_IncludePaths; // 0x98
    public int m_ExcludePathCount; // 0xA0
    public string[] m_ExcludePaths; // 0xA8
    public int m_TargetBindingIndex; // 0xB0
    public string m_BindingGroupForNewBinding; // 0xB8
    public string m_CancelBinding; // 0xC0

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFE81116380
    public void get_bindingMask(){} // RVA: 0x7FFE850D02B0
    public void get_candidates(){} // RVA: 0x7FFE878DC390
    public void get_scores(){} // RVA: 0x7FFE878DC3B0
    public void get_magnitudes(){} // RVA: 0x7FFE878DC470
    public void get_selectedControl(){} // RVA: 0x7FFE878DC530
    public void get_started(){} // RVA: 0x7FFE878DC5A0
    public void get_completed(){} // RVA: 0x7FFE878DC5B0
    public void get_canceled(){} // RVA: 0x7FFE878DC5C0
    public void get_startTime(){} // RVA: 0x7FFE878DC5D0
    public void get_timeout(){} // RVA: 0x7FFE84A61CD0
    public void get_expectedControlType(){} // RVA: 0x7FFE878DC5E0
    public void WithAction(){} // RVA: 0x7FFE878DC640
    public void WithMatchingEventsBeingSuppressed(){} // RVA: 0x7FFE878DC850
    public void WithCancelingThrough(){} // RVA: 0x7FFE878DC9A0 | overloaded x2
    public void WithExpectedControlType(){} // RVA: 0x7FFE80E2E2E0 | overloaded x3
    public void WithTargetBinding(){} // RVA: 0x7FFE878DCD50
    public void WithBindingMask(){} // RVA: 0x7FFE878DD8F0
    public void WithBindingGroup(){} // RVA: 0x7FFE878DD980
    public void WithoutGeneralizingPathOfSelectedControl(){} // RVA: 0x7FFE878DDB60
    public void WithRebindAddingNewBinding(){} // RVA: 0x7FFE878DDB70
    public void WithMagnitudeHavingToBeGreaterThan(){} // RVA: 0x7FFE878DDBE0
    public void WithoutIgnoringNoisyControls(){} // RVA: 0x7FFE878DDCF0
    public void WithControlsHavingToMatchPath(){} // RVA: 0x7FFE878DDD60
    public void WithControlsExcluding(){} // RVA: 0x7FFE878DDF70
    public void WithTimeout(){} // RVA: 0x7FFE878DE180
    public void OnComplete(){} // RVA: 0x7FFE878DFF40 | overloaded x2
    public void OnCancel(){} // RVA: 0x7FFE878E0370 | overloaded x2
    public void OnPotentialMatch(){} // RVA: 0x7FFE878DE250
    public void OnGeneratePath(){} // RVA: 0x7FFE878DE2B0
    public void OnComputeScore(){} // RVA: 0x7FFE878DE310
    public void OnApplyBinding(){} // RVA: 0x7FFE878DE370
    public void OnMatchWaitForAnother(){} // RVA: 0x7FFE878DE3D0
    public void Start(){} // RVA: 0x7FFE878DE3E0
    public void Cancel(){} // RVA: 0x7FFE878DE7A0
    public void Complete(){} // RVA: 0x7FFE878DE7F0
    public void AddCandidate(){} // RVA: 0x7FFE878DE810
    public void RemoveCandidate(){} // RVA: 0x7FFE878DE990
    public void Dispose(){} // RVA: 0x7FFE878DEAE0
    public void Finalize(){} // RVA: 0x7FFE878DEBD0
    public void Reset(){} // RVA: 0x7FFE878DECE0
    public void HookOnEvent(){} // RVA: 0x7FFE878DEF30
    public void UnhookOnEvent(){} // RVA: 0x7FFE878DF050
    public void OnEvent(){} // RVA: 0x7FFE878DF0C0
    public void SortCandidatesByScore(){} // RVA: 0x7FFE878DFA40
    public void HavePathMatch(){} // RVA: 0x7FFE878DFBF0
    public void HookOnAfterUpdate(){} // RVA: 0x7FFE878DFC70
    public void UnhookOnAfterUpdate(){} // RVA: 0x7FFE878DFD90
    public void OnAfterUpdate(){} // RVA: 0x7FFE878DFE00
    public void ResetAfterMatchCompleted(){} // RVA: 0x7FFE878E03B0
    public void ThrowIfRebindInProgress(){} // RVA: 0x7FFE878E04B0
    public void GeneratePathForControl(){} // RVA: 0x7FFE878E0520
    public void .ctor(){} // RVA: 0x7FFE878E06D0
}

public class ReceiveContext : Object
{
    public System.Net.Sockets.Socket workSocket; // 0x10
    public int ReceivedHeaderBytes; // 0x18
    public byte[] HeaderBuffer; // 0x20
    public int ExpectedMessageBytes; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D808F0
    public void get_ReadingHeader(){} // RVA: 0x7FFE81F50940
    public void get_CurrentBuffer(){} // RVA: 0x7FFE86D80A00
    public void get_CurrentOffset(){} // RVA: 0x7FFE86D80A10
    public void get_CurrentExpected(){} // RVA: 0x7FFE86D80A20
    public void Reset(){} // RVA: 0x7FFE86D80A30
}

public class ReceiveTrackingValues : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D4BCB0
}

public class ReceiverData : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE881D2B10
    public void Dispose(){} // RVA: 0x7FFE881D2C60
}

public class Recentering : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A9F7E0
    public void Validate(){} // RVA: 0x7FFE82A9F800
    public void CopyStateFrom(){} // RVA: 0x7FFE82A9F820
    public void CancelRecentering(){} // RVA: 0x7FFE82A9F840
    public void RecenterNow(){} // RVA: 0x7FFE82A9F8A0
    public void DoRecentering(){} // RVA: 0x7FFE82A9F8B0
    public void LegacyUpgrade(){} // RVA: 0x7FFE82A9FB80
}

public class RecognizedAttribute : ValueType
{
    public string m_name; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE815AE520
    public void get_Token(){} // RVA: 0x7FFE82C33000
    public void IsEqualTo(){} // RVA: 0x7FFE87675290
}

public class RecoilOffset : Object
{
    // ── Methods ──
    public void Start(){} // RVA: 0x7FFE81272F00
    public void Apply(){} // RVA: 0x7FFE81272F80
    public void .ctor(){} // RVA: 0x7FFE81273480
}

public class Record : ValueType
{
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<T> m_Owner;
    public int m_IndexPlusOne;
    public uint m_Version;
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_Owner; // 0x10
    public int m_IndexPlusOne; // 0x18
    public uint m_Version; // 0x1C
    public System.Action`1<UnityEngine.InputSystem.EnhancedTouch.Finger> field_6; // 0x6AF8
    public object field_7;
    public object field_8; // 0x2BE

    // ── Methods ──
    public void get_header(){} // RVA: 0x7FFE810A1420
    public void get_recordIndex(){} // RVA: 0x7FFE80E2EDB0
    public void get_valid(){} // RVA: 0x7FFE80E2F150
    public void get_owner(){} // RVA: 0x7FFE80E2E2E0
    public void get_index(){} // RVA: 0x7FFE80E2EDB0
    public void get_time(){} // RVA: 0x7FFE80E33FB0
    public void get_control(){} // RVA: 0x7FFE80E2E2E0
    public void get_next(){} // RVA: 0x7FFE810A1420
    public void get_previous(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x2
    public void ReadValue(){} // RVA: 0x7FFE810A1420
    public void GetUnsafeMemoryPtr(){} // RVA: 0x7FFE810A1420
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x7FFE810A1420
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x7FFE810A1420
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x7FFE810A1420
    public void CopyFrom(){} // RVA: 0x7FFE810A1420
    public void CheckValid(){} // RVA: 0x7FFE80E45FE0
    public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    public void ToString(){} // RVA: 0x7FFE80E2E2E0
}

public class RecordHeader : ValueType
{
    public double time; // 0x10
    public uint version; // 0x18

    // ── Methods ──
    public void get_statePtrWithControlIndex(){} // RVA: 0x7FFE84A67100
    public void get_statePtrWithoutControlIndex(){} // RVA: 0x7FFE869EE080
}

public class RecordLayerBuffer : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89F8CE80
    public void SendToRecordLayer(){} // RVA: 0x7FFE89F8CE90
}

public class RecordSerializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE8810AD80
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RecordingItem : ValueType
{
}

public class RectEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878A57C0
    public void GetHashCode(){} // RVA: 0x7FFE878A5890
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RectIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878A5C20
    public void GetHashCode(){} // RVA: 0x7FFE878A5C50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RectangleParams : ValueType
{
    // ── Methods ──
    public void AdjustUVsForScaleMode(){} // RVA: 0x7FFE87F73820
    public void AdjustSpriteUVsForScaleMode(){} // RVA: 0x7FFE87F73A30
    public void RectIntersection(){} // RVA: 0x7FFE87F74070
    public void ComputeGeomRect(){} // RVA: 0x7FFE87F74150
    public void ComputeUVRect(){} // RVA: 0x7FFE87F742A0
    public void ApplyPackingRotation(){} // RVA: 0x7FFE87F743F0
    public void MakeTextured(){} // RVA: 0x7FFE87F744E0
    public void MakeSprite(){} // RVA: 0x7FFE87F747C0
    public void MakeVectorTextured(){} // RVA: 0x7FFE87F75B10
    public void HasRadius(){} // RVA: 0x7FFE87F75D50
    public void HasSlices(){} // RVA: 0x7FFE87F75DD0
    public void ToNativeParams(){} // RVA: 0x7FFE87F75E20
}

public class Rectf : ValueType
{
}

public class Recti : ValueType
{
}

public class Ref : CastInstructionNoT
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void ConvertNull(){} // RVA: 0x7FFE87197BD0
}

public class RefCounted : Object
{
    public uint m_NextId;

    // ── Methods ──
    public void get_refCount(){} // RVA: 0x7FFE80E2EDB0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Acquire(){} // RVA: 0x7FFE80E45FE0
    public void Release(){} // RVA: 0x7FFE80E45FE0
    public void Copy(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class RefInstance : ValueType
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE878FEFF0
}

public class Reference : ValueType
{
}

public class ReferenceComparer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Compare(){} // RVA: 0x7FFE877B9B90
}

public class ReferenceEqualsEqualityComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IEqualityComparer<System.Object>.Equals(){} // RVA: 0x7FFE84108BE0
    public void System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(){} // RVA: 0x7FFE86B38630
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class References : Object
{
    public UnityEngine.Transform root; // 0x10
    public UnityEngine.Transform pelvis; // 0x18

    // ── Methods ──
    public void GetTransforms(){} // RVA: 0x7FFE811CB4A0
    public void get_isFilled(){} // RVA: 0x7FFE811CBB00
    public void get_isEmpty(){} // RVA: 0x7FFE811CC4C0
    public void AutoDetectReferences(){} // RVA: 0x7FFE811CCE80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ReflectedTypeData : Object
{
    public System.Type _type; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_IsPopulated(){} // RVA: 0x7FFE877D94C0
    public void GetAttributes(){} // RVA: 0x7FFE877D94F0
    public void GetClassName(){} // RVA: 0x7FFE86853FA0
    public void GetComponentName(){} // RVA: 0x7FFE877D9B80
    public void GetConverter(){} // RVA: 0x7FFE877D9C50
    public void GetDefaultEvent(){} // RVA: 0x7FFE877DA240
    public void GetDefaultProperty(){} // RVA: 0x7FFE877DA4C0
    public void GetEditor(){} // RVA: 0x7FFE877DA700
    public void GetEditorAttribute(){} // RVA: 0x7FFE877DAE80
    public void GetEvents(){} // RVA: 0x7FFE877DB120
    public void GetProperties(){} // RVA: 0x7FFE877DB570
    public void GetTypeFromName(){} // RVA: 0x7FFE877DB9C0
    public void Refresh(){} // RVA: 0x7FFE877DBB60
}

public class ReflectionData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4CA2A0
}

public class ReflectionHelper`2 : Object
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFE80E2E390
    public void CreateActionIMessage(){} // RVA: 0x7FFE80E2E390
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFE80E2E390
    public void CreateActionIMessageObject(){} // RVA: 0x7FFE80E2E390
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFE80E2E390
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class Reflector : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE810FB310
    public void GetDerivedTypeSet(){} // RVA: 0x7FFE80E2DEE0
}

public class Reg16 : ValueType
{
}

public class Reg32 : ValueType
{
}

public class Reg64 : ValueType
{
}

public class RegionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RelationshipHandle : ValueType
{
    // ── Methods ──
    public void Drop(){} // RVA: 0x7FFE82BE20F0
    public void DiscordRelationshipType(){} // RVA: 0x7FFE82BE2170
    public void User(){} // RVA: 0x7FFE82BE21F0
}

public class RelativeBoundingBox : Object
{
    public Google.Protobuf.MessageParser`1<RelativeBoundingBox> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int XminFieldNumber;
    public float XminDefaultValue; // 0x8
    public float xmin_; // 0x1C
    public int YminFieldNumber;
    public float YminDefaultValue; // 0xC
    public float ymin_; // 0x20
    public int WidthFieldNumber;
    public float WidthDefaultValue; // 0x10

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8665A920
    public void get_Descriptor(){} // RVA: 0x7FFE8665A980
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8665AA00
    public void .ctor(){} // RVA: 0x7FFE8665AAB0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8665ABB0
    public void get_Xmin(){} // RVA: 0x7FFE8665ACE0
    public void set_Xmin(){} // RVA: 0x7FFE866515A0
    public void get_HasXmin(){} // RVA: 0x7FFE8659D0B0
    public void ClearXmin(){} // RVA: 0x7FFE8659D0C0
    public void get_Ymin(){} // RVA: 0x7FFE8665AD50
    public void set_Ymin(){} // RVA: 0x7FFE866479A0
    public void get_HasYmin(){} // RVA: 0x7FFE8659D150
    public void ClearYmin(){} // RVA: 0x7FFE8659D160
    public void get_Width(){} // RVA: 0x7FFE8665ADC0
    public void set_Width(){} // RVA: 0x7FFE86651690
    public void get_HasWidth(){} // RVA: 0x7FFE865A0350
    public void ClearWidth(){} // RVA: 0x7FFE865A0360
    public void get_Height(){} // RVA: 0x7FFE8665AE30
    public void set_Height(){} // RVA: 0x7FFE86651710
    public void get_HasHeight(){} // RVA: 0x7FFE865A0910
    public void ClearHeight(){} // RVA: 0x7FFE865A0920
    public void Equals(){} // RVA: 0x7FFE8665AF00 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8665B120
    public void ToString(){} // RVA: 0x7FFE8665B2E0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8665B330
    public void CalculateSize(){} // RVA: 0x7FFE8665B410
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8665B5B0
    public void .cctor(){} // RVA: 0x7FFE8665B6B0
}

public class RelativeKeypoint : Object
{
    public Google.Protobuf.MessageParser`1<RelativeKeypoint> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int XFieldNumber;
    public float XDefaultValue; // 0x8
    public float x_; // 0x1C
    public int YFieldNumber;
    public float YDefaultValue; // 0xC
    public float y_; // 0x20
    public int KeypointLabelFieldNumber;
    public string KeypointLabelDefaultValue; // 0x10

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8665CA50
    public void get_Descriptor(){} // RVA: 0x7FFE8665CAB0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8665CB30
    public void .ctor(){} // RVA: 0x7FFE8665CBE0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8665CD40
    public void get_X(){} // RVA: 0x7FFE8665CED0
    public void set_X(){} // RVA: 0x7FFE866515A0
    public void get_HasX(){} // RVA: 0x7FFE8659D0B0
    public void ClearX(){} // RVA: 0x7FFE8659D0C0
    public void get_Y(){} // RVA: 0x7FFE8665CF40
    public void set_Y(){} // RVA: 0x7FFE866479A0
    public void get_HasY(){} // RVA: 0x7FFE8659D150
    public void ClearY(){} // RVA: 0x7FFE8659D160
    public void get_KeypointLabel(){} // RVA: 0x7FFE8665CFB0
    public void set_KeypointLabel(){} // RVA: 0x7FFE8665D020
    public void get_HasKeypointLabel(){} // RVA: 0x7FFE865A8CD0
    public void ClearKeypointLabel(){} // RVA: 0x7FFE836E7F30
    public void get_Score(){} // RVA: 0x7FFE8665D120
    public void set_Score(){} // RVA: 0x7FFE8665D190
    public void get_HasScore(){} // RVA: 0x7FFE865A0350
    public void ClearScore(){} // RVA: 0x7FFE865A0360
    public void Equals(){} // RVA: 0x7FFE8665D200 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8665D410
    public void ToString(){} // RVA: 0x7FFE8665D5B0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8665D600
    public void CalculateSize(){} // RVA: 0x7FFE8665D6E0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8665D900
    public void .cctor(){} // RVA: 0x7FFE8665DA10
}

public class ReleaseEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866957A0
}

public class RemoteClass : ValueType
{
}

public class RemoteInputDevice : ValueType
{
}

public class RemoteSender : ValueType
{
}

public class RemoveAcesCallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class RemoveDeviceMsg : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE879ACFD0
    public void Process(){} // RVA: 0x7FFE879AD0A0
}

public class RenderChainStaticIndexAllocator : ValueType
{
    // ── Methods ──
    public void AllocateIndex(){} // RVA: 0x7FFE87E8EA40
    public void FreeIndex(){} // RVA: 0x7FFE87E8EC40
    public void AccessIndex(){} // RVA: 0x7FFE87E8ECF0
    public void .cctor(){} // RVA: 0x7FFE87E8ED90
}

public class RenderMirrorEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class RenderModel : Object
{
    public UnityEngine.Mesh _mesh; // 0x10
    public UnityEngine.Material _material; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void get_mesh(){} // RVA: 0x7FFE81116380
    public void set_mesh(){} // RVA: 0x7FFE810FCE30
    public void get_material(){} // RVA: 0x7FFE810FE7C0
    public void set_material(){} // RVA: 0x7FFE81161E80
}

public class RenderModelInterfaceHolder : Object
{
    public bool needsShutdown; // 0x10

    // ── Methods ──
    public void get_instance(){} // RVA: 0x7FFE8705DFB0
    public void Dispose(){} // RVA: 0x7FFE8705E0E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RenderModelProperties : ValueType
{
}

public class RenderModelPropertiesInternal : ValueType
{
}

public class RenderNodeData : ValueType
{
}

public class RenderRequest : ValueType
{
}

public class RendererMaterialSlot : ValueType
{
}

public class RendererNotifyInvisible : ValueType
{
}

public class RenewalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3580
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE82DC25A0
}

public class RentArray`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4DDD0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void DisposeManually(){} // RVA: 0x7FFE80E466C0
}

public class RepeatRectUV : ValueType
{
}

public class ReplacementDefinition : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ReplacementList : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCCE0
}

public class ReplayController : Object
{
    public bool _finished; // 0x10
    public bool _paused; // 0x11
    public int _position; // 0x14
    public UnityEngine.InputSystem.LowLevel.InputEventTrace m_EventTrace; // 0x18
    public Enumerator m_Enumerator; // 0x20

    // ── Methods ──
    public void get_trace(){} // RVA: 0x7FFE810FE7C0
    public void get_finished(){} // RVA: 0x7FFE811C55E0
    public void set_finished(){} // RVA: 0x7FFE811C55F0
    public void get_paused(){} // RVA: 0x7FFE81346E30
    public void set_paused(){} // RVA: 0x7FFE813471A0
    public void get_position(){} // RVA: 0x7FFE8164B230
    public void set_position(){} // RVA: 0x7FFE8164E0F0
    public void get_createdDevices(){} // RVA: 0x7FFE87A237D0
    public void .ctor(){} // RVA: 0x7FFE87A23830
    public void Dispose(){} // RVA: 0x7FFE87A238E0
    public void WithDeviceMappedFromTo(){} // RVA: 0x7FFE87A23C70 | overloaded x2
    public void WithAllDevicesMappedToNewInstances(){} // RVA: 0x7FFE87A23DB0
    public void OnFinished(){} // RVA: 0x7FFE82C06DE0
    public void OnEvent(){} // RVA: 0x7FFE87A23DC0
    public void PlayOneEvent(){} // RVA: 0x7FFE87A23E20
    public void Rewind(){} // RVA: 0x7FFE87A23EB0
    public void PlayAllFramesOneByOne(){} // RVA: 0x7FFE87A23F70
    public void PlayAllEvents(){} // RVA: 0x7FFE87A24020
    public void PlayAllEventsAccordingToTimestamps(){} // RVA: 0x7FFE87A240C0
    public void OnBeginFrame(){} // RVA: 0x7FFE87A24570
    public void Finished(){} // RVA: 0x7FFE87A247A0
    public void QueueEvent(){} // RVA: 0x7FFE87A24860
    public void MoveNext(){} // RVA: 0x7FFE87A24BC0
    public void ApplyDeviceMapping(){} // RVA: 0x7FFE87A25030
}

public class Replica : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A858B0
    public void Start(){} // RVA: 0x7FFE86A85BA0
    public void Wait(){} // RVA: 0x7FFE86A85C30
    public void Execute(){} // RVA: 0x7FFE86A85C80
    public void CreateNewReplica(){} // RVA: 0x7FFE80E45FE0
    public void ExecuteAction(){} // RVA: 0x7FFE80E460A0
}

public class Replica`1 : Replica
{
    // ── Methods ──
    public void .ctor(){}
    public void CreateNewReplica(){} // RVA: 0x7FFE80E45FE0
    public void ExecuteAction(){} // RVA: 0x7FFE80E460A0
}

public class ReplicatableUserAction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE80E4DDD0
}

public class RequestCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    public void HandleMessage(){} // RVA: 0x7FFE86BC4850
}

public class RequestCallback`1 : RequestCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void HandleMessage(){} // RVA: 0x7FFE80E460A0
}
