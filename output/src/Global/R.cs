// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 350

public class RBTreeEnumerator
{
    public System.Data.RBTree`1<T> _tree;
    public int _version;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BAA0 | overloaded x2
    public void Dispose(){} // RVA: 0x24A50
    public void MoveNext(){} // RVA: 0xDBE0
    public void get_Current(){} // RVA: 0x283FA0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xCD60
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x24A50
}

public class RBTreeEnumerator
{
    public System.Data.RBTree`1<System.Data.DataRow> _tree; // 0x10
    public int _version; // 0x18
}

public class RBTreeEnumerator
{
    public System.Data.RBTree`1<int> _tree; // 0x10
    public int _version; // 0x18
}

public class REG_TZI_FORMAT
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5BF2C00
}

public class RaiseDataUsage
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x1AFE3C0
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class RaiseMessageToAll
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class RaiseMessageToPlayer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4392A0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x7653760
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class Range
{
    public int mStart; // 0x10
    public int mEnd; // 0x14

    // ── Methods ──
    public void Dispose(){} // RVA: 0x6D76C00
}

public class Range
{
    public int MsgType; // 0x10
    public int mEnd; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4438000
    public void get_Start(){} // RVA: 0x32A5C0
    public void set_Start(){} // RVA: 0x2E00C0
    public void get_End(){} // RVA: 0x8ABED0
    public void set_End(){} // RVA: 0x8AC660
}

public class Range
{
    public int mStart; // 0x10
    public int mEnd; // 0x14

    // ── Methods ──
    public void IsInRange(){} // RVA: 0x43C1A0
    public void .ctor(){} // RVA: 0x43C2A0
}

public class RangeIntEqualityComparer
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x6D64D50
    public void GetHashCode(){} // RVA: 0x6D64D70
    public void .ctor(){} // RVA: 0x2DD310
}

public class RawData
{
}

public class RawTexture
{
    // ── Methods ──
    public void WriteRawInt2Packed(){} // RVA: 0x7344210
    public void WriteRawFloat4Packed(){} // RVA: 0x73442B0
}

public class RayHitComparer
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x3189F0
    public void .ctor(){} // RVA: 0x2DD310
}

public class Raycast2DCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x74DA6F0
    public void Invoke(){} // RVA: 0x74DA7C0
    public void BeginInvoke(){} // RVA: 0x74DA820
    public void EndInvoke(){} // RVA: 0x74DA910
}

public class Raycast3DCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x74DA150
    public void Invoke(){} // RVA: 0x74DA220
    public void BeginInvoke(){} // RVA: 0x74DA260
    public void EndInvoke(){} // RVA: 0x61D7A00
}

public class RaycastAllCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x74DA360
    public void Invoke(){} // RVA: 0x74DA430
    public void BeginInvoke(){} // RVA: 0x74DA470
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class RaycastHit
{
}

public class RaycastHitComparer
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x61F8920
    public void .ctor(){} // RVA: 0x2DD310
    public void .cctor(){} // RVA: 0x74F5CE0
}

public class RaycastHitData
{
    public UnityEngine.UI.Graphic <graphic>k__BackingField; // 0x10
    public UnityEngine.Vector3 <worldHitPosition>k__BackingField; // 0x18
    public UnityEngine.Vector2 <screenPosition>k__BackingField; // 0x24
    public float <distance>k__BackingField; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6EBBDE0
    public void get_graphic(){} // RVA: 0x1AD4690
    public void get_worldHitPosition(){} // RVA: 0x37CA300
    public void get_screenPosition(){} // RVA: 0x2F0FE60
    public void get_distance(){} // RVA: 0x3AA570
}

public class ReachCone
{
    public UnityEngine.Vector3[] tetrahedron; // 0x10
    public float volume; // 0x18
    public UnityEngine.Vector3 S; // 0x1C
    public UnityEngine.Vector3 B; // 0x28

    // ── Methods ──
    public void get_o(){} // RVA: 0x4467C0
    public void get_a(){} // RVA: 0x446800
    public void get_b(){} // RVA: 0x446840
    public void get_c(){} // RVA: 0x446880
    public void .ctor(){} // RVA: 0x4468C0
    public void get_isValid(){} // RVA: 0x446AA0
    public void Calculate(){} // RVA: 0x446AB0
}

public class ReadActionJson
{
    // ── Methods ──
    public void ToAction(){} // RVA: 0x6D8F7C0
}

public class ReadAllAsyncEnumerable
{
    public System.Action`1<object> CancellationCallback1Delegate;

    // ── Methods ──
    public void .ctor(){}
    public void GetAsyncEnumerator(){}
    public void get_Current(){} // RVA: 0x283FA0
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0xC770
    public void CancellationCallback1(){} // RVA: 0x24AE0
    public void CancellationCallback2(){} // RVA: 0x24AE0
}

public class ReadAllAsyncEnumerable
{
    public System.Action`1<object> CancellationCallback1Delegate; // 0x10
}

public class ReadAllAsyncEnumerable
{
    public System.Action`1<object> CancellationCallback1Delegate; // 0x10
}

public class ReadAllAsyncEnumerable
{
    public System.Action`1<object> CancellationCallback1Delegate; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3E4B210
    public void GetAsyncEnumerator(){} // RVA: 0x3E4B420
    public void get_Current(){} // RVA: 0x3E4B710
    public void MoveNextAsync(){} // RVA: 0x3E4B780
    public void DisposeAsync(){} // RVA: 0x3E4B030
    public void CancellationCallback1(){} // RVA: 0x3E4B810
    public void CancellationCallback2(){} // RVA: 0x3E4B8E0
}

public class ReadBoneJob
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x45ABB60
}

public class ReadBufferState
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B47FB0
}

public class ReadDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E5F340
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x5E5F420
    public void EndInvoke(){} // RVA: 0x1969E40
}

public class ReadFileJson
{
    // ── Methods ──
    public void ToAsset(){} // RVA: 0x6D889F0
}

public class ReadFileJson
{
    // ── Methods ──
    public void ToMaps(){} // RVA: 0x6D908A0
}

public class ReadInstanceDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x1AFE3C0
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class ReadMapJson
{
}

public class ReadMethod
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E5F340
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x6CC7EE0
    public void EndInvoke(){} // RVA: 0x1969E40
}

public class ReadOnly
{
    public void* m_Buffer;
    public int m_Length;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void get_Length(){} // RVA: 0xD840
    public void ToArray(){} // RVA: 0xCD60
    public void get_Item(){} // RVA: 0x283FA0
    public void get_IsCreated(){} // RVA: 0xDBE0
    public void GetEnumerator(){} // RVA: 0x283FA0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x1CC5B50
    public void get_Length(){} // RVA: 0x3C4E030
    public void ToArray(){} // RVA: 0x3E4EA00
    public void get_Item(){} // RVA: 0x3C50410
    public void get_IsCreated(){} // RVA: 0x34C1790
    public void GetEnumerator(){} // RVA: 0x3C50730
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3E4EB90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3E4EB90
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnly
{
    public void* m_Buffer; // 0x10
    public int m_Length; // 0x18
}

public class ReadOnlyArrayList
{
    public System.Collections.ArrayList _list; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E07CF0
    public void get_Count(){} // RVA: 0x5E07D60
    public void get_IsReadOnly(){} // RVA: 0x3C2850
    public void get_IsFixedSize(){} // RVA: 0x3C2850
    public void get_IsSynchronized(){} // RVA: 0x5E07D90
    public void get_Item(){} // RVA: 0x5E07DC0
    public void set_Item(){} // RVA: 0x5E07DF0
    public void get_SyncRoot(){} // RVA: 0x5E07E40
    public void Add(){} // RVA: 0x5E07E70
    public void AddRange(){} // RVA: 0x5E07EC0
    public void set_Capacity(){} // RVA: 0x5E07F10
    public void Clear(){} // RVA: 0x5E07F60
    public void Clone(){} // RVA: 0x5E07FB0
    public void Contains(){} // RVA: 0x5E08120
    public void CopyTo(){} // RVA: 0x5E08180 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x5E081B0
    public void IndexOf(){} // RVA: 0x5E081E0
    public void Insert(){} // RVA: 0x5E08210
    public void InsertRange(){} // RVA: 0x5E08260
    public void Remove(){} // RVA: 0x5E082B0
    public void RemoveAt(){} // RVA: 0x5E08300
    public void RemoveRange(){} // RVA: 0x5E08350
    public void Reverse(){} // RVA: 0x5E083A0
    public void Sort(){} // RVA: 0x5E083F0
    public void ToArray(){} // RVA: 0x5E08470 | overloaded x2
}

public class ReadOnlyIPAddress
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6CCEEF0
}

public class ReadOnlyKeyCollection
{
    public System.Collections.Generic.IReadOnlyCollection`1<string> m_Keys; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9808470
    public void get_Count(){} // RVA: 0x9808530
    public void get_IsReadOnly(){} // RVA: 0x3C2850
    public void get_SyncRoot(){} // RVA: 0x9808580
    public void get_IsSynchronized(){} // RVA: 0x2DD320
    public void Add(){} // RVA: 0x98085E0
    public void Clear(){} // RVA: 0x9808620
    public void Contains(){} // RVA: 0x9808660
    public void CopyTo(){} // RVA: 0x9808890 | overloaded x2
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9808A70
    public void GetEnumerator(){} // RVA: 0x9808A70
    public void Remove(){} // RVA: 0x9808AC0
}

public class ReadPlayerDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F6E90
    public void Invoke(){} // RVA: 0xC09580
    public void BeginInvoke(){} // RVA: 0x76536C0
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class ReadTransformJob
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x45ABB60
}

public class ReadWriteParameters
{
}

public class ReadWriteTask
{
    public bool _isRead; // 0x58

    // ── Methods ──
    public void ClearBeginState(){} // RVA: 0x5E52310
    public void .ctor(){} // RVA: 0x5E523C0
    public void InvokeAsyncCallback(){} // RVA: 0x5E52740
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x5E52810
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0x3C2850
}

public class Reader
{
    public System.Threading.ExecutionContext m_ec; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void DangerousGetRawExecutionContext(){} // RVA: 0x1AD4690
    public void get_IsNull(){} // RVA: 0x1D26810
    public void IsDefaultFTContext(){} // RVA: 0x5F31DB0
    public void get_IsFlowSuppressed(){} // RVA: 0x5F31DD0
    public void get_SynchronizationContext(){} // RVA: 0x5F31DF0
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x5F31E10
    public void get_LogicalCallContext(){} // RVA: 0x5F31E30
    public void GetLocalValue(){} // RVA: 0x5F31EA0
    public void HasSameLocalValues(){} // RVA: 0x5F31F20
}

public class Reader
{
    public System.Runtime.Remoting.Messaging.LogicalCallContext InvokeMayRunArbitraryCode; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_IsNull(){} // RVA: 0x1D26810
    public void get_HasInfo(){} // RVA: 0x5CF4320
    public void Clone(){} // RVA: 0x5CF4340
    public void GetData(){} // RVA: 0x5CF43B0
}

public class Reader
{
    public System.Runtime.Remoting.Messaging.LogicalCallContext m_ctx; // 0x10

    // ── Methods ──
    public void Read16(){} // RVA: 0x99FB9E0
    public void Read32(){} // RVA: 0x99FBA30
    public void Read8(){} // RVA: 0x99FBAC0
    public void ReadAllBytesFromStream(){} // RVA: 0x99FBAF0
    public void ReadString(){} // RVA: 0x99FBCA0
    public void ReadVarInt(){} // RVA: 0x99FBD10
}

public class ReaderCache
{
    // ── Methods ──
    public void TryReadTo(){} // RVA: 0x9B17EA0 | overloaded x2
    public void ReadBoxed(){} // RVA: 0x1BF70 | overloaded x2
    public void Register(){} // RVA: 0x24A80
    public void EnumJsonWrite(){} // RVA: 0x283FA0
    public void EnumStringWrite(){} // RVA: 0xFB40
    public void EnumUtf8Write(){} // RVA: 0xFB40
    public void GuidJsonWrite(){} // RVA: 0x9B181F0
    public void DateTimeOffsetJsonWrite(){} // RVA: 0x9B182B0
    public void JsonSerialize(){} // RVA: 0x283FA0
    public void StringAppendFormatted(){} // RVA: 0xFB40
    public void Utf8AppendFormatted(){} // RVA: 0xFB40
    public void .cctor(){} // RVA: 0x9B18370
}

public class ReaderCallbackInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF19AE0
    public void ReadObject(){} // RVA: 0x6ABBA30
}

public class ReapplyDrivenProperties
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
}

public class RebindingOperation
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
    public void get_action(){} // RVA: 0x2F8380
    public void get_bindingMask(){} // RVA: 0x4495450
    public void get_candidates(){} // RVA: 0x6D9B4F0
    public void get_scores(){} // RVA: 0x6D9B510
    public void get_magnitudes(){} // RVA: 0x6D9B5D0
    public void get_selectedControl(){} // RVA: 0x6D9B690
    public void get_started(){} // RVA: 0x6D9B700
    public void get_completed(){} // RVA: 0x6D9B710
    public void get_canceled(){} // RVA: 0x6D9B720
    public void get_startTime(){} // RVA: 0x6D9B730
    public void get_timeout(){} // RVA: 0x3DF1600
    public void get_expectedControlType(){} // RVA: 0x6D9B740
    public void WithAction(){} // RVA: 0x6D9B7A0
    public void WithMatchingEventsBeingSuppressed(){} // RVA: 0x6D9B9B0
    public void WithCancelingThrough(){} // RVA: 0x6D9BB00 | overloaded x2
    public void WithExpectedControlType(){} // RVA: 0xCD60 | overloaded x3
    public void WithTargetBinding(){} // RVA: 0x6D9BEB0
    public void WithBindingMask(){} // RVA: 0x6D9CA50
    public void WithBindingGroup(){} // RVA: 0x6D9CAE0
    public void WithoutGeneralizingPathOfSelectedControl(){} // RVA: 0x6D9CCC0
    public void WithRebindAddingNewBinding(){} // RVA: 0x6D9CCD0
    public void WithMagnitudeHavingToBeGreaterThan(){} // RVA: 0x6D9CD40
    public void WithoutIgnoringNoisyControls(){} // RVA: 0x6D9CE50
    public void WithControlsHavingToMatchPath(){} // RVA: 0x6D9CEC0
    public void WithControlsExcluding(){} // RVA: 0x6D9D0D0
    public void WithTimeout(){} // RVA: 0x6D9D2E0
    public void OnComplete(){} // RVA: 0x6D9F0A0 | overloaded x2
    public void OnCancel(){} // RVA: 0x6D9F4D0 | overloaded x2
    public void OnPotentialMatch(){} // RVA: 0x6D9D3B0
    public void OnGeneratePath(){} // RVA: 0x6D9D410
    public void OnComputeScore(){} // RVA: 0x6D9D470
    public void OnApplyBinding(){} // RVA: 0x6D9D4D0
    public void OnMatchWaitForAnother(){} // RVA: 0x6D9D530
    public void Start(){} // RVA: 0x6D9D540
    public void Cancel(){} // RVA: 0x6D9D900
    public void Complete(){} // RVA: 0x6D9D950
    public void AddCandidate(){} // RVA: 0x6D9D970
    public void RemoveCandidate(){} // RVA: 0x6D9DAF0
    public void Dispose(){} // RVA: 0x6D9DC40
    public void Finalize(){} // RVA: 0x6D9DD30
    public void Reset(){} // RVA: 0x6D9DE40
    public void HookOnEvent(){} // RVA: 0x6D9E090
    public void UnhookOnEvent(){} // RVA: 0x6D9E1B0
    public void OnEvent(){} // RVA: 0x6D9E220
    public void SortCandidatesByScore(){} // RVA: 0x6D9EBA0
    public void HavePathMatch(){} // RVA: 0x6D9ED50
    public void HookOnAfterUpdate(){} // RVA: 0x6D9EDD0
    public void UnhookOnAfterUpdate(){} // RVA: 0x6D9EEF0
    public void OnAfterUpdate(){} // RVA: 0x6D9EF60
    public void ResetAfterMatchCompleted(){} // RVA: 0x6D9F510
    public void ThrowIfRebindInProgress(){} // RVA: 0x6D9F610
    public void GeneratePathForControl(){} // RVA: 0x6D9F680
    public void .ctor(){} // RVA: 0x6D9F830
}

public class ReceiveContext
{
    public System.Net.Sockets.Socket workSocket; // 0x10
    public int ReceivedHeaderBytes; // 0x18
    public byte[] HeaderBuffer; // 0x20
    public int ExpectedMessageBytes; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x623FE10
    public void get_ReadingHeader(){} // RVA: 0x104D6D0
    public void get_CurrentBuffer(){} // RVA: 0x623FF20
    public void get_CurrentOffset(){} // RVA: 0x623FF30
    public void get_CurrentExpected(){} // RVA: 0x623FF40
    public void Reset(){} // RVA: 0x623FF50
}

public class ReceiveTrackingValues
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x620AE10
}

public class ReceiverData
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7695970
    public void Dispose(){} // RVA: 0x7695AC0
}

public class ReceiverData
{
}

public class Recentering
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1D11960
    public void Validate(){} // RVA: 0x1D11980
    public void CopyStateFrom(){} // RVA: 0x1D119A0
    public void CancelRecentering(){} // RVA: 0x1D119C0
    public void RecenterNow(){} // RVA: 0x1D11A20
    public void DoRecentering(){} // RVA: 0x1D11A30
    public void LegacyUpgrade(){} // RVA: 0x1D11D00
}

public class RecognizedAttribute
{
    public string EndOfCookie; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x820840
    public void get_Token(){} // RVA: 0x1EA9890
    public void IsEqualTo(){} // RVA: 0x6B35FE0
}

public class RecoilOffset
{
    // ── Methods ──
    public void Start(){} // RVA: 0x454F00
    public void Apply(){} // RVA: 0x454F80
    public void .ctor(){} // RVA: 0x455480
}

public class Record
{
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<T> m_Owner;
    public int m_IndexPlusOne;
    public uint m_Version;

    // ── Methods ──
    public void get_header(){} // RVA: 0x283FA0
    public void get_recordIndex(){} // RVA: 0xD840
    public void get_valid(){} // RVA: 0xDBE0
    public void get_owner(){} // RVA: 0xCD60
    public void get_index(){} // RVA: 0xD840
    public void get_time(){} // RVA: 0x12A40
    public void get_control(){} // RVA: 0xCD60
    public void get_next(){} // RVA: 0x283FA0
    public void get_previous(){} // RVA: 0x283FA0
    public void .ctor(){} // RVA: 0x2BAA0 | overloaded x2
    public void ReadValue(){} // RVA: 0x283FA0
    public void GetUnsafeMemoryPtr(){} // RVA: 0x283FA0
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x283FA0
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x283FA0
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x283FA0
    public void CopyFrom(){} // RVA: 0x283FA0
    public void CheckValid(){} // RVA: 0x24A50
    public void Equals(){} // RVA: 0xDE40 | overloaded x2
    public void GetHashCode(){} // RVA: 0xD840
    public void ToString(){} // RVA: 0xCD60
}

public class Record
{
    public UnityEngine.InputSystem.LowLevel.InputStateHistory m_Owner; // 0x10
    public int m_IndexPlusOne; // 0x18
    public uint m_Version; // 0x1C

    // ── Methods ──
    public void get_header(){} // RVA: 0x6EED830
    public void get_recordIndex(){} // RVA: 0x3F4B990
    public void get_version(){} // RVA: 0x1EA98B0
    public void get_valid(){} // RVA: 0x6EED860
    public void get_owner(){} // RVA: 0x1AD4690
    public void get_index(){} // RVA: 0x6EED8B0
    public void get_time(){} // RVA: 0x6EED8F0
    public void get_control(){} // RVA: 0x6EED930
    public void get_next(){} // RVA: 0x6EEDAB0
    public void get_previous(){} // RVA: 0x6EEDBD0
    public void .ctor(){} // RVA: 0x3F4C140
    public void ReadValue(){} // RVA: 0x283FA0
    public void ReadValueAsObject(){} // RVA: 0x6EEDCF0
    public void GetUnsafeMemoryPtr(){} // RVA: 0x6EEDD40
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x6EEDD60
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x6EEDE00
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x6EEDE20
    public void CopyFrom(){} // RVA: 0x6EEDF00
    public void CheckValid(){} // RVA: 0x6EEE3D0
    public void Equals(){} // RVA: 0x6EEE4A0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x3F4CB90
    public void ToString(){} // RVA: 0x6EEE540
}

public class Record
{
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> m_Owner; // 0x10
    public int m_IndexPlusOne; // 0x18
    public uint m_Version; // 0x1C

    // ── Methods ──
    public void get_header(){} // RVA: 0x3F4B940
    public void get_recordIndex(){} // RVA: 0x3F4B990
    public void get_valid(){} // RVA: 0x3F4B9A0
    public void get_owner(){} // RVA: 0x1AD4690
    public void get_index(){} // RVA: 0x3F4BA30
    public void get_time(){} // RVA: 0x3F4BAD0
    public void get_control(){} // RVA: 0x3F4BB70
    public void get_next(){} // RVA: 0x3F4BE60
    public void get_previous(){} // RVA: 0x3F4BFD0
    public void .ctor(){} // RVA: 0x3F4C1C0 | overloaded x2
    public void ReadValue(){} // RVA: 0x3F4C230
    public void GetUnsafeMemoryPtr(){} // RVA: 0x3F4C350
    public void GetUnsafeMemoryPtrUnchecked(){} // RVA: 0x3F4C3C0
    public void GetUnsafeExtraMemoryPtr(){} // RVA: 0x3F4C4F0
    public void GetUnsafeExtraMemoryPtrUnchecked(){} // RVA: 0x3F4C560
    public void CopyFrom(){} // RVA: 0x3F4C680
    public void CheckValid(){} // RVA: 0x3F4C960
    public void Equals(){} // RVA: 0x3F4CA70 | overloaded x2
    public void GetHashCode(){} // RVA: 0x3F4CB90
    public void ToString(){} // RVA: 0x3F4CBE0
}

public class RecordHeader
{
    public double time; // 0x10
    public uint version; // 0x18

    // ── Methods ──
    public void get_statePtrWithControlIndex(){} // RVA: 0x3DF6A30
    public void get_statePtrWithoutControlIndex(){} // RVA: 0x5EAD240
}

public class RecordLayerBuffer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x952AAB0
    public void SendToRecordLayer(){} // RVA: 0x952AAC0
}
