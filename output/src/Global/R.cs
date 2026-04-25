// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 480

public class RBTreeEnumerator : ValueType
{
    public System.Data.RBTree`1<T> Current;
    public int System.Collections.IEnumerator.Current;
    public int _index;
    public int _mainTreeNodeId;
    public T _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
}

public class REG_TZI_FORMAT : ValueType
{
    public int Bias; // 0x10
    public int StandardBias; // 0x14
    public int DaylightBias; // 0x18
    public SYSTEMTIME StandardDate; // 0x1C
    public SYSTEMTIME DaylightDate; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC838A150
}

public class RaiseDataUsage : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RaiseMessageToAll : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RaiseMessageToPlayer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D2A0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEBA00
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Range : ValueType
{
    public UIntPtr Pointer; // 0x10
    public int Items; // 0x18
    public AllocatorHandle Allocator; // 0x1C

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC950F360
}

public class RangeIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD4B0
    public void GetHashCode(){} // RVA: 0x7FFAC94FD4D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RawData : Object
{
    public UIntPtr Bounds; // 0x10
    public UIntPtr Count; // 0x18
    public byte Data; // 0x20
}

public class RawTexture : ValueType
{
    public UnityEngine.Color32[] rgba; // 0x10
    public int width; // 0x18
    public int height; // 0x1C

    // ── Methods ──
    public void WriteRawInt2Packed(){} // RVA: 0x7FFAC9ADBAF0
    public void WriteRawFloat4Packed(){} // RVA: 0x7FFAC9ADBB90
}

public class RayHitComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC2F5C9F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Raycast2DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C72060
    public void Invoke(){} // RVA: 0x7FFAC9C72130
    public void BeginInvoke(){} // RVA: 0x7FFAC9C72190
    public void EndInvoke(){} // RVA: 0x7FFAC9C72280
}

public class Raycast3DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C71AC0
    public void Invoke(){} // RVA: 0x7FFAC9C71B90
    public void BeginInvoke(){} // RVA: 0x7FFAC9C71BD0
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class RaycastAllCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C71CD0
    public void Invoke(){} // RVA: 0x7FFAC9C71DA0
    public void BeginInvoke(){} // RVA: 0x7FFAC9C71DE0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RaycastHit : ValueType
{
    public UnityEngine.UI.Graphic graphic; // 0x10
    public UnityEngine.Vector3 worldPos; // 0x18
    public bool fromMouse; // 0x24
}

public class RaycastHitComparer : Object
{
    public RaycastHitComparer instance;

    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC8990130
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9C8D660
}

public class RaycastHitData : ValueType
{
    public UnityEngine.UI.Graphic graphic; // 0x10
    public UnityEngine.Vector3 worldHitPosition; // 0x18
    public UnityEngine.Vector2 screenPosition; // 0x24
    public float distance; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9654510
    public void get_graphic(){} // RVA: 0x7FFAC3AD9F60
    public void get_worldHitPosition(){} // RVA: 0x7FFAC60F5A40
    public void get_screenPosition(){} // RVA: 0x7FFAC58A1B70
    public void get_distance(){} // RVA: 0x7FFAC2FEE570
}

public class ReachCone : Object
{
    public UnityEngine.Vector3[] o; // 0x10
    public float a; // 0x18
    public UnityEngine.Vector3 b; // 0x1C
    public UnityEngine.Vector3 c; // 0x28

    // ── Methods ──
    public void get_o(){} // RVA: 0x7FFAC308A7C0
    public void get_a(){} // RVA: 0x7FFAC308A800
    public void get_b(){} // RVA: 0x7FFAC308A840
    public void get_c(){} // RVA: 0x7FFAC308A880
    public void .ctor(){} // RVA: 0x7FFAC308A8C0
    public void get_isValid(){} // RVA: 0x7FFAC308AAA0
    public void Calculate(){} // RVA: 0x7FFAC308AAB0
}

public class ReadActionJson : ValueType
{
    public string name; // 0x10
    public string type; // 0x18
    public string id; // 0x20
    public string expectedControlType; // 0x28
    public string expectedControlLayout; // 0x30
    public string processors; // 0x38
    public string interactions; // 0x40
    public bool passThrough; // 0x48
    public bool initialStateCheck; // 0x49
    public BindingJson[] bindings; // 0x50

    // ── Methods ──
    public void ToAction(){} // RVA: 0x7FFAC9527F20
}

public class ReadAllAsyncEnumerable : Object
{
    public System.Action`1<object> Current;
    public System.Action`1<object> CancellationCallback2Delegate;
    public SingleConsumerUnboundedChannelReader<T> parent;
    public System.Threading.CancellationToken cancellationToken1;
    public System.Threading.CancellationToken cancellationToken2;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration1;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration2;
    public T current;
    public bool cacheValue;
    public bool running;

    // ── Methods ──
    public void .ctor(){}
    public void GetAsyncEnumerator(){}
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void CancellationCallback1(){} // RVA: 0x7FFAC2C70A10
    public void CancellationCallback2(){} // RVA: 0x7FFAC2C70A10
}

public class ReadBoneJob : ValueType
{
    public Unity.Collections.NativeArray`1<UnityEngine.Jobs.TransformAccess> transformData; // 0x10

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC6E1DF70
}

public class ReadBufferState : Object
{
    public byte[] Buffer; // 0x10
    public int Offset; // 0x18
    public int Count; // 0x1C
    public int InitialCount; // 0x20
    public System.Net.HttpStreamAsyncResult Ares; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92DEB30
}

public class ReadDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85F69B0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC85F6A90
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class ReadFileJson : ValueType
{
    public string name; // 0x10
    public ReadMapJson[] maps; // 0x18
    public SchemeJson[] controlSchemes; // 0x20

    // ── Methods ──
    public void ToAsset(){} // RVA: 0x7FFAC9521150
}

public class ReadInstanceDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ReadMapJson : ValueType
{
    public string name; // 0x10
    public string id; // 0x18
    public ReadActionJson[] actions; // 0x20
    public BindingJson[] bindings; // 0x28
}

public class ReadMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85F69B0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC9460640
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class ReadOnly : ValueType
{
    public void* Length;
    public int Item;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Length(){} // RVA: 0x7FFAC2C59960
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class ReadOnlyArrayList : ArrayList
{
    public System.Collections.ArrayList Count; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC859F350
    public void get_Count(){} // RVA: 0x7FFAC859F3C0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
    public void get_IsFixedSize(){} // RVA: 0x7FFAC3006850
    public void get_IsSynchronized(){} // RVA: 0x7FFAC859F3F0
    public void get_Item(){} // RVA: 0x7FFAC859F420
    public void set_Item(){} // RVA: 0x7FFAC859F450
    public void get_SyncRoot(){} // RVA: 0x7FFAC859F4A0
    public void Add(){} // RVA: 0x7FFAC859F4D0
    public void AddRange(){} // RVA: 0x7FFAC859F520
    public void set_Capacity(){} // RVA: 0x7FFAC859F570
    public void Clear(){} // RVA: 0x7FFAC859F5C0
    public void Clone(){} // RVA: 0x7FFAC859F610
    public void Contains(){} // RVA: 0x7FFAC859F780
    public void CopyTo(){} // RVA: 0x7FFAC859F7E0 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFAC859F810
    public void IndexOf(){} // RVA: 0x7FFAC859F840
    public void Insert(){} // RVA: 0x7FFAC859F870
    public void InsertRange(){} // RVA: 0x7FFAC859F8C0
    public void Remove(){} // RVA: 0x7FFAC859F910
    public void RemoveAt(){} // RVA: 0x7FFAC859F960
    public void RemoveRange(){} // RVA: 0x7FFAC859F9B0
    public void Reverse(){} // RVA: 0x7FFAC859FA00
    public void Sort(){} // RVA: 0x7FFAC859FA50
    public void ToArray(){} // RVA: 0x7FFAC859FAD0 | overloaded x2
}

public class ReadOnlyIPAddress : IPAddress
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9467650
}

public class ReadOnlyKeyCollection : Object
{
    public System.Collections.Generic.IReadOnlyCollection`1<string> Count; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBE111F0
    public void get_Count(){} // RVA: 0x7FFACBE112B0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
    public void get_SyncRoot(){} // RVA: 0x7FFACBE11300
    public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void Add(){} // RVA: 0x7FFACBE11360
    public void Clear(){} // RVA: 0x7FFACBE113A0
    public void Contains(){} // RVA: 0x7FFACBE113E0
    public void CopyTo(){} // RVA: 0x7FFACBE11610 | overloaded x2
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACBE117F0
    public void GetEnumerator(){} // RVA: 0x7FFACBE117F0
    public void Remove(){} // RVA: 0x7FFACBE11840
}

public class ReadPlayerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6192A30
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEB960
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ReadTransformJob : ValueType
{
    public Unity.Collections.NativeArray`1<UnityEngine.Jobs.TransformAccess> transformData; // 0x10

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC6E1DF70
}

public class ReadWriteParameters : ValueType
{
    public byte[] Buffer; // 0x10
    public int Offset; // 0x18
    public int Count; // 0x1C
}

public class ReadWriteTask : Task`1
{
    public bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode; // 0x58
    public bool _apm; // 0x59
    public System.IO.Stream _stream; // 0x60
    public byte[] _buffer; // 0x68
    public int _offset; // 0x70
    public int _count; // 0x74
    public System.AsyncCallback _callback; // 0x78
    public System.Threading.ExecutionContext _context; // 0x80
    public System.Threading.ContextCallback s_invokeAsyncCallback;

    // ── Methods ──
    public void ClearBeginState(){} // RVA: 0x7FFAC85E9980
    public void .ctor(){} // RVA: 0x7FFAC85E9A30
    public void InvokeAsyncCallback(){} // RVA: 0x7FFAC85E9DB0
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x7FFAC85E9E80
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFAC3006850
}

public class Reader : ValueType
{
    public System.Threading.ExecutionContext IsNull; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void DangerousGetRawExecutionContext(){} // RVA: 0x7FFAC3AD9F60
    public void get_IsNull(){} // RVA: 0x7FFAC484C2F0
    public void IsDefaultFTContext(){} // RVA: 0x7FFAC86C9420
    public void get_IsFlowSuppressed(){} // RVA: 0x7FFAC86C9440
    public void get_SynchronizationContext(){} // RVA: 0x7FFAC86C9460
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x7FFAC86C9480
    public void get_LogicalCallContext(){} // RVA: 0x7FFAC86C94A0
    public void GetLocalValue(){} // RVA: 0x7FFAC86C9510
    public void HasSameLocalValues(){} // RVA: 0x7FFAC86C9590
}

public class ReaderCache : Object
{
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,Handlers> cache;

    // ── Methods ──
    public void TryReadTo(){} // RVA: 0x7FFACC0F1740 | overloaded x2
    public void ReadBoxed(){} // RVA: 0x7FFAC2C68090 | overloaded x2
    public void Register(){} // RVA: 0x7FFAC2C709B0
    public void EnumJsonWrite(){} // RVA: 0x7FFAC2E8DC40
    public void EnumStringWrite(){} // RVA: 0x7FFAC2C5BC60
    public void EnumUtf8Write(){} // RVA: 0x7FFAC2C5BC60
    public void GuidJsonWrite(){} // RVA: 0x7FFACC0F1A90
    public void DateTimeOffsetJsonWrite(){} // RVA: 0x7FFACC0F1B50
    public void JsonSerialize(){} // RVA: 0x7FFAC2E8DC40
    public void StringAppendFormatted(){} // RVA: 0x7FFAC2C5BC60
    public void Utf8AppendFormatted(){} // RVA: 0x7FFAC2C5BC60
    public void .cctor(){} // RVA: 0x7FFACC0F1C10
}

public class ReaderCallbackInfo : Object
{
    public System.Xml.Serialization.XmlSerializationReaderInterpreter _sri; // 0x10
    public System.Xml.Serialization.XmlTypeMapping _typeMap; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void ReadObject(){} // RVA: 0x7FFAC92525B0
}

public class ReapplyDrivenProperties : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class RebindingOperation : Object
{
    public float action;
    public UnityEngine.InputSystem.InputAction bindingMask; // 0x10
    public System.Nullable`1<UnityEngine.InputSystem.InputBinding> candidates; // 0x18
    public System.Type scores; // 0x78
    public UnityEngine.InputSystem.Utilities.InternedString magnitudes; // 0x80
    public int selectedControl; // 0x90
    public string[] started; // 0x98
    public int completed; // 0xA0
    public string[] canceled; // 0xA8
    public int startTime; // 0xB0
    public string timeout; // 0xB8
    public string expectedControlType; // 0xC0
    public float m_MagnitudeThreshold; // 0xC8
    public float[] m_Scores; // 0xD0
    public float[] m_Magnitudes; // 0xD8
    public double m_LastMatchTime; // 0xE0
    public double m_StartTime; // 0xE8
    public float m_Timeout; // 0xF0
    public float m_WaitSecondsAfterMatch; // 0xF4
    public UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl> m_Candidates; // 0xF8
    public System.Action`1<RebindingOperation> m_OnComplete; // 0x118
    public System.Action`1<RebindingOperation> m_OnCancel; // 0x120
    public System.Action`1<RebindingOperation> m_OnPotentialMatch; // 0x128
    public System.Func`2<UnityEngine.InputSystem.InputControl,string> m_OnGeneratePath; // 0x130
    public System.Func`3<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,float> m_OnComputeScore; // 0x138
    public System.Action`2<RebindingOperation,string> m_OnApplyBinding; // 0x140
    public System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEventDelegate; // 0x148
    public System.Action m_OnAfterUpdateDelegate; // 0x150
    public Cache m_LayoutCache; // 0x158
    public System.Text.StringBuilder m_PathBuilder; // 0x160
    public 0x6B145D88 m_Flags; // 0x168
    public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputControl,float> m_StartingActuations; // 0x170

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFAC2F3C380
    public void get_bindingMask(){} // RVA: 0x7FFAC6D49D60
    public void get_candidates(){} // RVA: 0x7FFAC9533C50
    public void get_scores(){} // RVA: 0x7FFAC9533C70
    public void get_magnitudes(){} // RVA: 0x7FFAC9533D30
    public void get_selectedControl(){} // RVA: 0x7FFAC9533DF0
    public void get_started(){} // RVA: 0x7FFAC9533E60
    public void get_completed(){} // RVA: 0x7FFAC9533E70
    public void get_canceled(){} // RVA: 0x7FFAC9533E80
    public void get_startTime(){} // RVA: 0x7FFAC9533E90
    public void get_timeout(){} // RVA: 0x7FFAC67155B0
    public void get_expectedControlType(){} // RVA: 0x7FFAC9533EA0
    public void WithAction(){} // RVA: 0x7FFAC9533F00
    public void WithMatchingEventsBeingSuppressed(){} // RVA: 0x7FFAC9534110
    public void WithCancelingThrough(){} // RVA: 0x7FFAC9534260 | overloaded x2
    public void WithExpectedControlType(){} // RVA: 0x7FFAC2C58E90 | overloaded x3
    public void WithTargetBinding(){} // RVA: 0x7FFAC9534610
    public void WithBindingMask(){} // RVA: 0x7FFAC95351B0
    public void WithBindingGroup(){} // RVA: 0x7FFAC9535240
    public void WithoutGeneralizingPathOfSelectedControl(){} // RVA: 0x7FFAC9535420
    public void WithRebindAddingNewBinding(){} // RVA: 0x7FFAC9535430
    public void WithMagnitudeHavingToBeGreaterThan(){} // RVA: 0x7FFAC95354A0
    public void WithoutIgnoringNoisyControls(){} // RVA: 0x7FFAC95355B0
    public void WithControlsHavingToMatchPath(){} // RVA: 0x7FFAC9535620
    public void WithControlsExcluding(){} // RVA: 0x7FFAC9535830
    public void WithTimeout(){} // RVA: 0x7FFAC9535A40
    public void OnComplete(){} // RVA: 0x7FFAC9537800 | overloaded x2
    public void OnCancel(){} // RVA: 0x7FFAC9537C30 | overloaded x2
    public void OnPotentialMatch(){} // RVA: 0x7FFAC9535B10
    public void OnGeneratePath(){} // RVA: 0x7FFAC9535B70
    public void OnComputeScore(){} // RVA: 0x7FFAC9535BD0
    public void OnApplyBinding(){} // RVA: 0x7FFAC9535C30
    public void OnMatchWaitForAnother(){} // RVA: 0x7FFAC9535C90
    public void Start(){} // RVA: 0x7FFAC9535CA0
    public void Cancel(){} // RVA: 0x7FFAC9536060
    public void Complete(){} // RVA: 0x7FFAC95360B0
    public void AddCandidate(){} // RVA: 0x7FFAC95360D0
    public void RemoveCandidate(){} // RVA: 0x7FFAC9536250
    public void Dispose(){} // RVA: 0x7FFAC95363A0
    public void Finalize(){} // RVA: 0x7FFAC9536490
    public void Reset(){} // RVA: 0x7FFAC95365A0
    public void HookOnEvent(){} // RVA: 0x7FFAC95367F0
    public void UnhookOnEvent(){} // RVA: 0x7FFAC9536910
    public void OnEvent(){} // RVA: 0x7FFAC9536980
    public void SortCandidatesByScore(){} // RVA: 0x7FFAC9537300
    public void HavePathMatch(){} // RVA: 0x7FFAC95374B0
    public void HookOnAfterUpdate(){} // RVA: 0x7FFAC9537530
    public void UnhookOnAfterUpdate(){} // RVA: 0x7FFAC9537650
    public void OnAfterUpdate(){} // RVA: 0x7FFAC95376C0
    public void ResetAfterMatchCompleted(){} // RVA: 0x7FFAC9537C70
    public void ThrowIfRebindInProgress(){} // RVA: 0x7FFAC9537D70
    public void GeneratePathForControl(){} // RVA: 0x7FFAC9537DE0
    public void .ctor(){} // RVA: 0x7FFAC9537F90
}

public class ReceiveContext : Object
{
    public System.Net.Sockets.Socket ReadingHeader; // 0x10
    public int CurrentBuffer; // 0x18
    public byte[] CurrentOffset; // 0x20
    public int CurrentExpected; // 0x28
    public int ReceivedMessageBytes; // 0x2C
    public byte[] MessageBuffer; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89D7270
    public void get_ReadingHeader(){} // RVA: 0x7FFAC3CE9940
    public void get_CurrentBuffer(){} // RVA: 0x7FFAC89D7380
    public void get_CurrentOffset(){} // RVA: 0x7FFAC89D7390
    public void get_CurrentExpected(){} // RVA: 0x7FFAC89D73A0
    public void Reset(){} // RVA: 0x7FFAC89D73B0
}

public class ReceiveTrackingValues : Object
{
    public bool ReceivedReliableCommandSincePreviousAck2; // 0x10
    public System.Collections.Generic.HashSet`1<int> receivedReliableSequenceNumbers; // 0x18
    public int reliableSequencedNumbersCompletelyReceived; // 0x20
    public int reliableSequencedNumbersHighestReceived; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89A2620
}

public class ReceiverData : ValueType
{
    public bool isValid; // 0x10
    public int shapeId; // 0x14
    public 0x6B25F240 receiverType; // 0x18
    public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int> collisions; // 0x20
    public float collisionValue; // 0x38

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC9E255F0
    public void Dispose(){} // RVA: 0x7FFAC9E25740
}

public class Recentering : ValueType
{
    public bool m_enabled; // 0x10
    public float m_WaitTime; // 0x14
    public float m_RecenteringTime; // 0x18
    public float m_LastUpdateTime; // 0x1C
    public float mLastAxisInputTime; // 0x20
    public float mRecenteringVelocity; // 0x24
    public int m_LegacyHeadingDefinition; // 0x28
    public int m_LegacyVelocityFilterStrength; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4837440
    public void Validate(){} // RVA: 0x7FFAC4837460
    public void CopyStateFrom(){} // RVA: 0x7FFAC4837480
    public void CancelRecentering(){} // RVA: 0x7FFAC48374A0
    public void RecenterNow(){} // RVA: 0x7FFAC4837500
    public void DoRecentering(){} // RVA: 0x7FFAC4837510
    public void LegacyUpgrade(){} // RVA: 0x7FFAC48377E0
}

public class RecognizedAttribute : ValueType
{
    public string Token; // 0x10
    public 0x6B13BE08 m_token; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC335C3C0
    public void get_Token(){} // RVA: 0x7FFAC49C7500
    public void IsEqualTo(){} // RVA: 0x7FFAC92CCB60
}

public class RecoilOffset : Object
{
    public UnityEngine.Vector3 offset; // 0x10
    public float additivity; // 0x1C
    public float maxAdditiveOffsetMag; // 0x20
    public EffectorLink[] effectorLinks; // 0x28
    public UnityEngine.Vector3 additiveOffset; // 0x30
    public UnityEngine.Vector3 lastOffset; // 0x3C

    // ── Methods ──
    public void Start(){} // RVA: 0x7FFAC3098F00
    public void Apply(){} // RVA: 0x7FFAC3098F80
    public void .ctor(){} // RVA: 0x7FFAC3099480
}

public class Record : ValueType
{
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<T> header;
    public int recordIndex;
    public uint valid;

    // ── Methods ──
    public void get_header(){} // RVA: 0x7FFAC2E8DC40
    public void get_recordIndex(){} // RVA: 0x7FFAC2C59960
    public void get_valid(){} // RVA: 0x7FFAC2C59D00
    public void get_owner(){} // RVA: 0x7FFAC2C58E90
    public void get_index(){} // RVA: 0x7FFAC2C59960
    public void get_time(){} // RVA: 0x7FFAC2C5EB60
    public void get_control(){} // RVA: 0x7FFAC2C58E90
    public void get_next(){} // RVA: 0x7FFAC2E8DC40
    public void get_previous(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x2
    public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
    public void GetUnsafeMemoryPtr(){} // RVA: 0x7FFAC2E8DC40
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x7FFAC2E8DC40
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x7FFAC2E8DC40
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x7FFAC2E8DC40
    public void CopyFrom(){} // RVA: 0x7FFAC2E8DC40
    public void CheckValid(){} // RVA: 0x7FFAC2C70980
    public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    public void ToString(){} // RVA: 0x7FFAC2C58E90
}

public class RecordHeader : ValueType
{
    public double statePtrWithControlIndex; // 0x10
    public uint statePtrWithoutControlIndex; // 0x18
    public int controlIndex; // 0x1C
    public <m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex; // 0x1C
    public <m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex; // 0x20
    public int kSizeWithControlIndex;
    public int kSizeWithoutControlIndex;

    // ── Methods ──
    public void get_statePtrWithControlIndex(){} // RVA: 0x7FFAC671A9E0
    public void get_statePtrWithoutControlIndex(){} // RVA: 0x7FFAC8644890
}

public class RecordLayerBuffer : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB33860
    public void SendToRecordLayer(){} // RVA: 0x7FFACBB33870
}

public class RecordSerializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D61230
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RecordingItem : ValueType
{
    public float Time; // 0x10
    public bool IsCut; // 0x14
    public Item Item; // 0x18
}

public class RectEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD080
    public void GetHashCode(){} // RVA: 0x7FFAC94FD150
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RectIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD4E0
    public void GetHashCode(){} // RVA: 0x7FFAC94FD510
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RectangleParams : ValueType
{
    public UnityEngine.Rect rect; // 0x10
    public UnityEngine.Rect uv; // 0x20
    public UnityEngine.Color color; // 0x30
    public UnityEngine.Rect subRect; // 0x40
    public UnityEngine.UIElements.BackgroundPosition backgroundPositionX; // 0x50
    public UnityEngine.UIElements.BackgroundPosition backgroundPositionY; // 0x5C
    public UnityEngine.UIElements.BackgroundRepeat backgroundRepeat; // 0x68
    public UnityEngine.UIElements.BackgroundSize backgroundSize; // 0x70
    public UnityEngine.Texture texture; // 0x88
    public UnityEngine.Sprite sprite; // 0x90
    public UnityEngine.UIElements.VectorImage vectorImage; // 0x98
    public UnityEngine.Material material; // 0xA0
    public 0x6B27F8A0 scaleMode; // 0xA8
    public UnityEngine.Color playmodeTintColor; // 0xAC
    public UnityEngine.Vector2 topLeftRadius; // 0xBC
    public UnityEngine.Vector2 topRightRadius; // 0xC4
    public UnityEngine.Vector2 bottomRightRadius; // 0xCC
    public UnityEngine.Vector2 bottomLeftRadius; // 0xD4
    public UnityEngine.Vector2 contentSize; // 0xDC
    public UnityEngine.Vector2 textureSize; // 0xE4
    public int leftSlice; // 0xEC
    public int topSlice; // 0xF0
    public int rightSlice; // 0xF4
    public int bottomSlice; // 0xF8
    public float sliceScale; // 0xFC
    public UnityEngine.Rect spriteGeomRect; // 0x100
    public UnityEngine.Vector4 rectInset; // 0x110
    public UnityEngine.UIElements.ColorPage colorPage; // 0x120
    public 0x6B120AD8 meshFlags; // 0x128

    // ── Methods ──
    public void AdjustUVsForScaleMode(){} // RVA: 0x7FFAC9BCAF70
    public void AdjustSpriteUVsForScaleMode(){} // RVA: 0x7FFAC9BCB180
    public void RectIntersection(){} // RVA: 0x7FFAC9BCB7C0
    public void ComputeGeomRect(){} // RVA: 0x7FFAC9BCB8A0
    public void ComputeUVRect(){} // RVA: 0x7FFAC9BCB9F0
    public void ApplyPackingRotation(){} // RVA: 0x7FFAC9BCBB40
    public void MakeTextured(){} // RVA: 0x7FFAC9BCBC30
    public void MakeSprite(){} // RVA: 0x7FFAC9BCBF10
    public void MakeVectorTextured(){} // RVA: 0x7FFAC9BCD260
    public void HasRadius(){} // RVA: 0x7FFAC9BCD4A0
    public void HasSlices(){} // RVA: 0x7FFAC9BCD520
    public void ToNativeParams(){} // RVA: 0x7FFAC9BCD570
}

public class Rectf : ValueType
{
    public Vector2f Pos; // 0x10
    public Sizef Size; // 0x18
}

public class Recti : ValueType
{
    public Vector2i Pos; // 0x10
    public Sizei Size; // 0x18
}

public class Ref : CastInstructionNoT
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void ConvertNull(){} // RVA: 0x7FFAC8DEF7A0
}

public class RefCounted : Object
{
    public uint refCount;
    public int m_RefCount;
    public uint m_Id;
    public T value;

    // ── Methods ──
    public void get_refCount(){} // RVA: 0x7FFAC2C59960
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Acquire(){} // RVA: 0x7FFAC2C70980
    public void Release(){} // RVA: 0x7FFAC2C70980
    public void Copy(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class RefInstance : ValueType
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC95568B0
}

public class Reference : ValueType
{
    public string key; // 0x10
    public UnityEngine.Object target; // 0x18
}

public class ReferenceComparer : Object
{
    public System.ComponentModel.ReferenceConverter _converter; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Compare(){} // RVA: 0x7FFAC9411460
}

public class ReferenceEqualsEqualityComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IEqualityComparer<System.Object>.Equals(){} // RVA: 0x7FFAC5DA0BF0
    public void System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(){} // RVA: 0x7FFAC878EEC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class References : Object
{
    public UnityEngine.Transform isFilled; // 0x10
    public UnityEngine.Transform isEmpty; // 0x18
    public UnityEngine.Transform spine; // 0x20
    public UnityEngine.Transform chest; // 0x28
    public UnityEngine.Transform neck; // 0x30
    public UnityEngine.Transform head; // 0x38
    public UnityEngine.Transform leftShoulder; // 0x40
    public UnityEngine.Transform leftUpperArm; // 0x48
    public UnityEngine.Transform leftForearm; // 0x50
    public UnityEngine.Transform leftHand; // 0x58
    public UnityEngine.Transform rightShoulder; // 0x60
    public UnityEngine.Transform rightUpperArm; // 0x68
    public UnityEngine.Transform rightForearm; // 0x70
    public UnityEngine.Transform rightHand; // 0x78
    public UnityEngine.Transform leftThigh; // 0x80
    public UnityEngine.Transform leftCalf; // 0x88
    public UnityEngine.Transform leftFoot; // 0x90
    public UnityEngine.Transform leftToes; // 0x98
    public UnityEngine.Transform rightThigh; // 0xA0
    public UnityEngine.Transform rightCalf; // 0xA8
    public UnityEngine.Transform rightFoot; // 0xB0
    public UnityEngine.Transform rightToes; // 0xB8
    public UnityEngine.Transform upperChest; // 0xC0

    // ── Methods ──
    public void GetTransforms(){} // RVA: 0x7FFAC2FF14A0
    public void get_isFilled(){} // RVA: 0x7FFAC2FF1B00
    public void get_isEmpty(){} // RVA: 0x7FFAC2FF24C0
    public void AutoDetectReferences(){} // RVA: 0x7FFAC2FF2E80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ReflectedTypeData : Object
{
    public System.Type IsPopulated; // 0x10
    public System.ComponentModel.AttributeCollection _attributes; // 0x18
    public System.ComponentModel.EventDescriptorCollection _events; // 0x20
    public System.ComponentModel.PropertyDescriptorCollection _properties; // 0x28
    public System.ComponentModel.TypeConverter _converter; // 0x30
    public object[] _editors; // 0x38
    public System.Type[] _editorTypes; // 0x40
    public int _editorCount; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_IsPopulated(){} // RVA: 0x7FFAC9430D90
    public void GetAttributes(){} // RVA: 0x7FFAC9430DC0
    public void GetClassName(){} // RVA: 0x7FFAC84AA740
    public void GetComponentName(){} // RVA: 0x7FFAC9431450
    public void GetConverter(){} // RVA: 0x7FFAC9431520
    public void GetDefaultEvent(){} // RVA: 0x7FFAC9431B10
    public void GetDefaultProperty(){} // RVA: 0x7FFAC9431D90
    public void GetEditor(){} // RVA: 0x7FFAC9431FD0
    public void GetEditorAttribute(){} // RVA: 0x7FFAC9432750
    public void GetEvents(){} // RVA: 0x7FFAC94329F0
    public void GetProperties(){} // RVA: 0x7FFAC9432E40
    public void GetTypeFromName(){} // RVA: 0x7FFAC9433290
    public void Refresh(){} // RVA: 0x7FFAC9433430
}

public class ReflectionData : Object
{
    public UnityEngine.RenderTexture[] texture; // 0x10
    public UnityEngine.MaterialPropertyBlock propertyBlock; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC0642D0
}

public class ReflectionHelper`2 : Object
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7FFAC2C58F40
    public void CreateActionIMessage(){} // RVA: 0x7FFAC2C58F40
    public void CreateFuncIMessageObject(){} // RVA: 0x7FFAC2C58F40
    public void CreateActionIMessageObject(){} // RVA: 0x7FFAC2C58F40
    public void CreateFuncIMessageBool(){} // RVA: 0x7FFAC2C58F40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class Reflector : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2F21310
    public void GetDerivedTypeSet(){} // RVA: 0x7FFAC2C58A90
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
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RelationshipHandle : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Drop(){} // RVA: 0x7FFAC49765F0
    public void DiscordRelationshipType(){} // RVA: 0x7FFAC4976670
    public void User(){} // RVA: 0x7FFAC49766F0
}

public class RelativeBoundingBox : Object
{
    public Google.Protobuf.MessageParser`1<RelativeBoundingBox> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Xmin;
    public float HasXmin; // 0x8
    public float Ymin; // 0x1C
    public int HasYmin;
    public float Width; // 0xC
    public float HasWidth; // 0x20
    public int Height;
    public float HasHeight; // 0x10
    public float width_; // 0x24
    public int HeightFieldNumber;
    public float HeightDefaultValue; // 0x14
    public float height_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82B1000
    public void get_Descriptor(){} // RVA: 0x7FFAC82B1060
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B10E0
    public void .ctor(){} // RVA: 0x7FFAC82B1190 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82B1290
    public void get_Xmin(){} // RVA: 0x7FFAC82B13C0
    public void set_Xmin(){} // RVA: 0x7FFAC82A7C80
    public void get_HasXmin(){} // RVA: 0x7FFAC81F3770
    public void ClearXmin(){} // RVA: 0x7FFAC81F3780
    public void get_Ymin(){} // RVA: 0x7FFAC82B1430
    public void set_Ymin(){} // RVA: 0x7FFAC829E080
    public void get_HasYmin(){} // RVA: 0x7FFAC81F3810
    public void ClearYmin(){} // RVA: 0x7FFAC81F3820
    public void get_Width(){} // RVA: 0x7FFAC82B14A0
    public void set_Width(){} // RVA: 0x7FFAC82A7D70
    public void get_HasWidth(){} // RVA: 0x7FFAC81F6A10
    public void ClearWidth(){} // RVA: 0x7FFAC81F6A20
    public void get_Height(){} // RVA: 0x7FFAC82B1510
    public void set_Height(){} // RVA: 0x7FFAC82A7DF0
    public void get_HasHeight(){} // RVA: 0x7FFAC81F6FD0
    public void ClearHeight(){} // RVA: 0x7FFAC81F6FE0
    public void Equals(){} // RVA: 0x7FFAC82B15E0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82B1800
    public void ToString(){} // RVA: 0x7FFAC82B19C0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B1A10
    public void CalculateSize(){} // RVA: 0x7FFAC82B1AF0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B1C90
    public void .cctor(){} // RVA: 0x7FFAC82B1D90
}

public class RelativeKeypoint : Object
{
    public Google.Protobuf.MessageParser`1<RelativeKeypoint> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int X;
    public float HasX; // 0x8
    public float Y; // 0x1C
    public int HasY;
    public float KeypointLabel; // 0xC
    public float HasKeypointLabel; // 0x20
    public int Score;
    public string HasScore; // 0x10
    public string keypointLabel_; // 0x28
    public int ScoreFieldNumber;
    public float ScoreDefaultValue; // 0x18
    public float score_; // 0x30

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82B3130
    public void get_Descriptor(){} // RVA: 0x7FFAC82B3190
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B3210
    public void .ctor(){} // RVA: 0x7FFAC82B32C0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82B3420
    public void get_X(){} // RVA: 0x7FFAC82B35B0
    public void set_X(){} // RVA: 0x7FFAC82A7C80
    public void get_HasX(){} // RVA: 0x7FFAC81F3770
    public void ClearX(){} // RVA: 0x7FFAC81F3780
    public void get_Y(){} // RVA: 0x7FFAC82B3620
    public void set_Y(){} // RVA: 0x7FFAC829E080
    public void get_HasY(){} // RVA: 0x7FFAC81F3810
    public void ClearY(){} // RVA: 0x7FFAC81F3820
    public void get_KeypointLabel(){} // RVA: 0x7FFAC82B3690
    public void set_KeypointLabel(){} // RVA: 0x7FFAC82B3700
    public void get_HasKeypointLabel(){} // RVA: 0x7FFAC81FF390
    public void ClearKeypointLabel(){} // RVA: 0x7FFAC53F2F70
    public void get_Score(){} // RVA: 0x7FFAC82B3800
    public void set_Score(){} // RVA: 0x7FFAC82B3870
    public void get_HasScore(){} // RVA: 0x7FFAC81F6A10
    public void ClearScore(){} // RVA: 0x7FFAC81F6A20
    public void Equals(){} // RVA: 0x7FFAC82B38E0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82B3AF0
    public void ToString(){} // RVA: 0x7FFAC82B3C90
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B3CE0
    public void CalculateSize(){} // RVA: 0x7FFAC82B3DC0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B3FE0
    public void .cctor(){} // RVA: 0x7FFAC82B40F0
}

public class ReleaseEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC82EBEA0
}

public class RemoteClass : ValueType
{
    public UIntPtr default_vtable; // 0x10
    public UIntPtr xdomain_vtable; // 0x18
    public MonoClass* proxy_class; // 0x20
    public UIntPtr proxy_class_name; // 0x28
    public uint interface_count; // 0x30
}

public class RemoteInputDevice : ValueType
{
    public int remoteId; // 0x10
    public int localId; // 0x14
    public UnityEngine.InputSystem.Layouts.InputDeviceDescription description; // 0x18
}

public class RemoteSender : ValueType
{
    public int senderId; // 0x10
    public UnityEngine.InputSystem.Utilities.InternedString[] layouts; // 0x18
    public RemoteInputDevice[] devices; // 0x20
}

public class RemoveAcesCallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class RemoveDeviceMsg : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC9604890
    public void Process(){} // RVA: 0x7FFAC9604960
}

public class RenderChainStaticIndexAllocator : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.RenderChain> renderChains;

    // ── Methods ──
    public void AllocateIndex(){} // RVA: 0x7FFAC9AE61A0
    public void FreeIndex(){} // RVA: 0x7FFAC9AE63A0
    public void AccessIndex(){} // RVA: 0x7FFAC9AE6450
    public void .cctor(){} // RVA: 0x7FFAC9AE64F0
}

public class RenderMirrorEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class RenderModel : Object
{
    public UnityEngine.Mesh mesh; // 0x10
    public UnityEngine.Material material; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void get_mesh(){} // RVA: 0x7FFAC2F3C380
    public void set_mesh(){} // RVA: 0x7FFAC2F22E30
    public void get_material(){} // RVA: 0x7FFAC2F247C0
    public void set_material(){} // RVA: 0x7FFAC2F87E80
}

public class RenderModelInterfaceHolder : Object
{
    public bool instance; // 0x10
    public bool failedLoadInterface; // 0x11
    public Valve.VR.CVRRenderModels _instance; // 0x18

    // ── Methods ──
    public void get_instance(){} // RVA: 0x7FFAC8CB5AC0
    public void Dispose(){} // RVA: 0x7FFAC8CB5BF0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RenderModelProperties : ValueType
{
    public string ModelName; // 0x10
    public ulong ModelKey; // 0x18
    public uint VendorId; // 0x20
    public uint ModelVersion; // 0x24
}

public class RenderModelPropertiesInternal : ValueType
{
    public byte[] ModelName; // 0x10
    public ulong ModelKey; // 0x18
    public uint VendorId; // 0x20
    public uint ModelVersion; // 0x24
}

public class RenderNodeData : ValueType
{
    public UnityEngine.Material standardMaterial; // 0x10
    public UnityEngine.Material initialMaterial; // 0x18
    public UnityEngine.MaterialPropertyBlock matPropBlock; // 0x20
    public UnityEngine.UIElements.UIR.RenderChainCommand firstCommand; // 0x28
    public UnityEngine.UIElements.UIR.UIRenderDevice device; // 0x30
    public UnityEngine.Texture vectorAtlas; // 0x38
    public UnityEngine.Texture shaderInfoAtlas; // 0x40
    public float dpiScale; // 0x48
    public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.Transform3x4> transformConstants; // 0x50
    public Unity.Collections.NativeSlice`1<UnityEngine.Vector4> clipRectConstants; // 0x60
}

public class RenderRequest : ValueType
{
    public 0x6B179AA8 m_CameraRenderMode; // 0x10
    public UnityEngine.RenderTexture m_ResultRT; // 0x18
    public 0x6B179B00 m_OutputSpace; // 0x20
}

public class RendererNotifyInvisible : ValueType
{
}

public class RenewalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD0660
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class RentArray`1 : ValueType
{
    public Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>[] Array; // 0x10
    public int Length; // 0x18
    public Cysharp.Threading.Tasks.Internal.ArrayPool`1<Cysharp.Threading.Tasks.UniTask`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>> pool; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC68C66B0
    public void Dispose(){} // RVA: 0x7FFAC68C68D0
    public void DisposeManually(){} // RVA: 0x7FFAC68C6950
}

public class RepeatRectUV : ValueType
{
    public UnityEngine.Rect rect; // 0x10
    public UnityEngine.Rect uv; // 0x20
}

public class ReplacementDefinition : Object
{
    public UnityEngine.Shader original; // 0x10
    public UnityEngine.Shader replacement; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ReplacementList : Object
{
    public ReplacementDefinition[] items; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22CE0
}

public class ReplayController : Object
{
    public bool trace; // 0x10
    public bool finished; // 0x11
    public int paused; // 0x14
    public UnityEngine.InputSystem.LowLevel.InputEventTrace position; // 0x18
    public Enumerator createdDevices; // 0x20
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Collections.Generic.KeyValuePair`2<int,int>> m_DeviceIDMappings; // 0x28
    public bool m_CreateNewDevices; // 0x40
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputDevice> m_CreatedDevices; // 0x48
    public System.Action m_OnFinished; // 0x60
    public System.Action`1<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_OnEvent; // 0x68
    public double m_StartTimeAsPerFirstEvent; // 0x70
    public double m_StartTimeAsPerRuntime; // 0x78
    public int m_AllEventsByTimeIndex; // 0x80
    public System.Collections.Generic.List`1<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_AllEventsByTime; // 0x88

    // ── Methods ──
    public void get_trace(){} // RVA: 0x7FFAC2F247C0
    public void get_finished(){} // RVA: 0x7FFAC2FEB5E0
    public void set_finished(){} // RVA: 0x7FFAC2FEB5F0
    public void get_paused(){} // RVA: 0x7FFAC3771DA0
    public void set_paused(){} // RVA: 0x7FFAC3771D90
    public void get_position(){} // RVA: 0x7FFAC33D5A20
    public void set_position(){} // RVA: 0x7FFAC33D4990
    public void get_createdDevices(){} // RVA: 0x7FFAC967B070
    public void .ctor(){} // RVA: 0x7FFAC967B0D0
    public void Dispose(){} // RVA: 0x7FFAC967B180
    public void WithDeviceMappedFromTo(){} // RVA: 0x7FFAC967B510 | overloaded x2
    public void WithAllDevicesMappedToNewInstances(){} // RVA: 0x7FFAC967B650
    public void OnFinished(){} // RVA: 0x7FFAC499B2E0
    public void OnEvent(){} // RVA: 0x7FFAC967B660
    public void PlayOneEvent(){} // RVA: 0x7FFAC967B6C0
    public void Rewind(){} // RVA: 0x7FFAC967B750
    public void PlayAllFramesOneByOne(){} // RVA: 0x7FFAC967B810
    public void PlayAllEvents(){} // RVA: 0x7FFAC967B8C0
    public void PlayAllEventsAccordingToTimestamps(){} // RVA: 0x7FFAC967B960
    public void OnBeginFrame(){} // RVA: 0x7FFAC967BE10
    public void Finished(){} // RVA: 0x7FFAC967C040
    public void QueueEvent(){} // RVA: 0x7FFAC967C100
    public void MoveNext(){} // RVA: 0x7FFAC967C460
    public void ApplyDeviceMapping(){} // RVA: 0x7FFAC967C8D0
}

public class Replica : Object
{
    public System.Threading.Tasks.TaskReplicator _replicator; // 0x10
    public int _timeout; // 0x18
    public int _remainingConcurrency; // 0x1C
    public System.Threading.Tasks.Task _pendingTask; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86DC100
    public void Start(){} // RVA: 0x7FFAC86DC3F0
    public void Wait(){} // RVA: 0x7FFAC86DC480
    public void Execute(){} // RVA: 0x7FFAC86DC4D0
    public void CreateNewReplica(){} // RVA: 0x7FFAC2C70980
    public void ExecuteAction(){} // RVA: 0x7FFAC2C70A40
}

public class Replica`1 : Replica
{
    public ReplicatableUserAction`1<T> _action;
    public T _state;

    // ── Methods ──
    public void .ctor(){}
    public void CreateNewReplica(){} // RVA: 0x7FFAC2C70980
    public void ExecuteAction(){} // RVA: 0x7FFAC2C70A40
}

public class ReplicatableUserAction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C786D0
}

public class RequestCallback : Object
{
    public Callback messageCallback; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    public void HandleMessage(){} // RVA: 0x7FFAC881B160
}

public class RequestCallback`1 : RequestCallback
{
    public Callback<T> callback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void HandleMessage(){} // RVA: 0x7FFAC2C70A40
}

public class RequestLightsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6910B70
    public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
}
