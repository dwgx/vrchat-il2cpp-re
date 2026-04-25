// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 41
// Methods: 192

public class Int128 : ValueType
{
    public long hi; // 0x10
    public ulong lo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC485BDA0 | overloaded x3
    public void IsNegative(){} // RVA: 0x7FFAC485C530
    public void op_Equality(){} // RVA: 0x7FFAC485C540
    public void op_Inequality(){} // RVA: 0x7FFAC485C600
    public void Equals(){} // RVA: 0x7FFAC485C6C0
    public void GetHashCode(){} // RVA: 0x7FFAC485C750
    public void op_GreaterThan(){} // RVA: 0x7FFAC485C770
    public void op_LessThan(){} // RVA: 0x7FFAC485C790
    public void op_Addition(){} // RVA: 0x7FFAC485C7B0
    public void op_Subtraction(){} // RVA: 0x7FFAC485C7E0
    public void op_UnaryNegation(){} // RVA: 0x7FFAC485C850
    public void op_Explicit(){} // RVA: 0x7FFAC485C890
    public void Int128Mul(){} // RVA: 0x7FFAC485C950
}

public class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs`1
{
    public bool _wrapExceptionsInIOExceptions; // 0xD8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93413A0
}

public class IntChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACB8D2290
}

public class IntPoint : ValueType
{
    public long X; // 0x10
    public long Y; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC485BDA0 | overloaded x3
    public void op_Equality(){} // RVA: 0x7FFAC485CA30
    public void op_Inequality(){} // RVA: 0x7FFAC485CA50
    public void Equals(){} // RVA: 0x7FFAC485CA70
    public void GetHashCode(){} // RVA: 0x7FFAC485CB00
}

public class IntRect : ValueType
{
    public long left; // 0x10
    public long top; // 0x18
    public long right; // 0x20
    public long bottom; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC485CB80 | overloaded x2
}

public class IntegerInput : TextValueInput
{
    public object parentIntegerField;
    public object allowedCharacters;

    // ── Methods ──
    public void get_parentIntegerField(){} // RVA: 0x7FFAC9B3E020
    public void .ctor(){} // RVA: 0x7FFAC9B3E0A0
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9B3E260
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B3E2C0
    public void ValueToString(){} // RVA: 0x7FFAC9B3E4F0
    public void StringToValue(){} // RVA: 0x7FFAC9B3E5E0
}

public class Interaction : Object
{
    public RootMotion.FinalIK.InteractionObject interactionObject; // 0x10
    public 0x6B1C0330[] effectors; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class InteractionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D2A0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC307D380
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InteractionEvent : Object
{
    public float time; // 0x10
    public bool pause; // 0x14
    public bool pickUp; // 0x15
    public AnimatorEvent[] animations; // 0x18
    public Message[] messages; // 0x20
    public UnityEngine.Events.UnityEvent unityEvent; // 0x28

    // ── Methods ──
    public void Activate(){} // RVA: 0x7FFAC3076A70
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class InteractionEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D410
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC307D500
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InteractionState : ValueType
{
    public ushort triggerControlIndex; // 0x10
    public byte startTime; // 0x12
    public byte performedTime; // 0x13
    public float timerStartTime; // 0x14
    public double timerDuration; // 0x18
    public double totalTimeoutCompletionDone; // 0x20
    public double totalTimeoutCompletionTimeRemaining; // 0x28
    public float timerMonitorIndex; // 0x30
    public float isTimerRunning; // 0x34
    public long phase; // 0x38

    // ── Methods ──
    public void get_triggerControlIndex(){} // RVA: 0x7FFAC954C2E0
    public void set_triggerControlIndex(){} // RVA: 0x7FFAC954C300
    public void get_startTime(){} // RVA: 0x7FFAC47D1AE0
    public void set_startTime(){} // RVA: 0x7FFAC4AB3ED0
    public void get_performedTime(){} // RVA: 0x7FFAC4422FA0
    public void set_performedTime(){} // RVA: 0x7FFAC6D2C430
    public void get_timerStartTime(){} // RVA: 0x7FFAC5873C20
    public void set_timerStartTime(){} // RVA: 0x7FFAC69C0110
    public void get_timerDuration(){} // RVA: 0x7FFAC4A9B900
    public void set_timerDuration(){} // RVA: 0x7FFAC4A9B8F0
    public void get_totalTimeoutCompletionDone(){} // RVA: 0x7FFAC2F4A080
    public void set_totalTimeoutCompletionDone(){} // RVA: 0x7FFAC4447440
    public void get_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7FFAC308EF50
    public void set_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7FFAC308EF60
    public void get_timerMonitorIndex(){} // RVA: 0x7FFAC2F4F130
    public void set_timerMonitorIndex(){} // RVA: 0x7FFAC33D3BF0
    public void get_isTimerRunning(){} // RVA: 0x7FFAC954C380
    public void set_isTimerRunning(){} // RVA: 0x7FFAC954C390
    public void get_phase(){} // RVA: 0x7FFAC495DE20
    public void set_phase(){} // RVA: 0x7FFAC3B9B990
}

public class Internal : Object
{
    public int hash_code_of_ptr_seed;
}

public class InternalCollisionIgnoreSettings : Object
{
    public bool ignoreAll; // 0x10
    public UnityEngine.ConfigurableJoint[] muscles; // 0x18
    public 0x6B1BDBA8[] groups; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F97710
}

public class InternalEnumerator`1 : ValueType
{
    public System.Array Current;
    public int System.Collections.IEnumerator.Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
}

public class InternalPartitionEnumerable : Object
{
    public System.Collections.Generic.IEnumerator`1<T> _sharedReader;
    public SharedLong _sharedIndex;
    public System.Collections.Generic.KeyValuePair`2<long,T>[] _fillBuffer;
    public int _fillBufferSize;
    public int _fillBufferCurrentPosition;
    public int _activeCopiers;
    public SharedBool _hasNoElementsLeft;
    public SharedBool _sourceDepleted;
    public object _sharedLock;
    public bool _disposed;
    public SharedInt _activePartitionCount;
    public bool _useSingleChunking;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C76590
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void TryCopyFromFillBuffer(){} // RVA: 0x7FFAC2C786D0
    public void GrabChunk(){}
    public void GrabChunk_Single(){}
    public void GrabChunk_Buffered(){}
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class InternalPartitionEnumerator : DynamicPartitionEnumerator_Abstract`2
{
    public System.Collections.Generic.KeyValuePair`2<long,T>[] HasNoElementsLeft;
    public SharedBool Current;
    public SharedInt _activePartitionCount;
    public InternalPartitionEnumerable<T> _enumerable;

    // ── Methods ──
    public void .ctor(){}
    public void GrabNextChunk(){} // RVA: 0x7FFAC2C5A310
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class Interop : Object
{
    // ── Methods ──
    public void GetRandomBytes(){} // RVA: 0x7FFAC8387590
    public void MemAlloc(){} // RVA: 0x7FFAC83876A0
}

public class IntersectNode : Object
{
    public TEdge Edge1; // 0x10
    public TEdge Edge2; // 0x18
    public IntPoint Pt; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class IntersectionResults : ValueType
{
    public UnityEngine.Vector3 point; // 0x10
    public UnityEngine.Vector3 normal; // 0x1C
    public UnityEngine.Vector2 UVs; // 0x28
    public float distance; // 0x30
}

public class Interval : Object
{
    public Google.Protobuf.MessageParser`1<Interval> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Y;
    public int HasY; // 0x8
    public int LeftX; // 0x1C
    public int HasLeftX;
    public int RightX; // 0xC
    public int HasRightX; // 0x20
    public int RightXFieldNumber;
    public int RightXDefaultValue; // 0x10
    public int rightX_; // 0x24

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC829C1B0
    public void get_Descriptor(){} // RVA: 0x7FFAC829C210
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC829C290
    public void .ctor(){} // RVA: 0x7FFAC829C340 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC829C440
    public void get_Y(){} // RVA: 0x7FFAC829C570
    public void set_Y(){} // RVA: 0x7FFAC81F3760
    public void get_HasY(){} // RVA: 0x7FFAC81F3770
    public void ClearY(){} // RVA: 0x7FFAC81F3780
    public void get_LeftX(){} // RVA: 0x7FFAC829C5E0
    public void set_LeftX(){} // RVA: 0x7FFAC81F3800
    public void get_HasLeftX(){} // RVA: 0x7FFAC81F3810
    public void ClearLeftX(){} // RVA: 0x7FFAC81F3820
    public void get_RightX(){} // RVA: 0x7FFAC829C650
    public void set_RightX(){} // RVA: 0x7FFAC82834A0
    public void get_HasRightX(){} // RVA: 0x7FFAC81F6A10
    public void ClearRightX(){} // RVA: 0x7FFAC81F6A20
    public void Equals(){} // RVA: 0x7FFAC829C7E0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC829C8C0
    public void ToString(){} // RVA: 0x7FFAC829C940
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC829C990
    public void CalculateSize(){} // RVA: 0x7FFAC829CA40
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC829CC80
    public void .cctor(){} // RVA: 0x7FFAC829CD40
}

public class IntializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class InventoryColorPaletteData : ValueType
{
    public string Current; // 0x10
    public string Default; // 0x18
}

public class InvocationContext : Object
{
    public System.Threading.SendOrPostCallback m_Delegate; // 0x10
    public object m_State; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void Invoke(){} // RVA: 0x7FFAC78F43D0
}

public class InvocationEntryDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class InvocationExpressionProxy : Object
{
    public System.Linq.Expressions.InvocationExpression Arguments; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71970
    public void get_Arguments(){} // RVA: 0x7FFAC8D71650
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Expression(){} // RVA: 0x7FFAC356B610
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class IsAutoDispose : Object
{
    public Unity.Burst.SharedStatic`1<Unity.Collections.Long1024> Ref;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC9510470
}

public class IsBurstEnabledDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAAD40
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class IsBurstEnabled_00000145$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9506840
    public void GetFunctionPointer(){} // RVA: 0x7FFAC9506980
    public void Constructor(){} // RVA: 0x7FFAC9506AF0
    public void Initialize(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9506AF0
    public void Invoke(){} // RVA: 0x7FFAC9506BB0
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAAD40
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class IsCanceledSource : Object
{
    public Cysharp.Threading.Tasks.IUniTaskSource`1<T> source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
}

public class IsLocalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AE32D0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class IsOfType`1 : Object
{
    public IsOfType`1<T> s_Instance;

    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class IsRegistered`1 : Object
{
    public bool Value;
}

public class IsolatingRunSequence : Object
{
    public byte level; // 0x10
    public 0x6B29E488 sos; // 0x11
    public 0x6B29E488 eos; // 0x12
    public int length; // 0x14
    public int[] indexes; // 0x18
    public byte[] types; // 0x20
    public byte[] resolvedLevels; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8237E40
}

public class Item : ValueType
{
    public UnityEngine.Vector3 Empty; // 0x10
    public UnityEngine.Quaternion Rot; // 0x1C

    // ── Methods ──
    public void Lerp(){} // RVA: 0x7FFAC4850980
    public void get_Empty(){} // RVA: 0x7FFAC4850AE0
}

public class ItemAttribute : ApiModel
{
    public object defaultValue; // 0x68
    public ItemAttributeValidation validator; // 0x70

    // ── Methods ──
    public void get_defaultValue(){} // RVA: 0x7FFAC2F9CD50
    public void set_defaultValue(){} // RVA: 0x7FFAC2F9CD60
    public void get_validator(){} // RVA: 0x7FFAC2FE9590
    public void set_validator(){} // RVA: 0x7FFAC2FE95A0
    public void .ctor(){} // RVA: 0x7FFACBE7FC70
}

public class ItemAttributeValidation : ApiModel
{
    public string type; // 0x68

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFAC2F9CD50
    public void set_type(){} // RVA: 0x7FFAC2F9CD60
    public void .ctor(){} // RVA: 0x7FFACBE7FCC0
}

public class IterationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC3012440
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Iterator`1 : Object
{
    public int Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x14
    public string current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5F39810
    public void get_Current(){} // RVA: 0x7FFAC2F247C0
    public void Clone(){} // RVA: 0x7FFAC2C58E90
    public void Dispose(){} // RVA: 0x7FFAC5F39BD0
    public void GetEnumerator(){} // RVA: 0x7FFAC5F398B0
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Select(){} // RVA: 0x7FFAC2C58F40
    public void Where(){} // RVA: 0x7FFAC2C58F40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC5F399C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC5C85BA0
}

public class iOSInfo : Object
{
    public bool CacheDir;
    public long FreeDiskSpaceBytes;
    public System.Threading.Thread _pollMemoryStatusThread; // 0x8
    public long _cachedMemoryAvailable; // 0x10
    public string _cacheDir; // 0x18

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC8228480
    public void FetchInfo(){} // RVA: 0x7FFAC8228490
    public void get_CacheDir(){} // RVA: 0x7FFAC8228550
    public void CheckMemoryStatusThread(){} // RVA: 0x7FFAC8228690
    public void PollMemoryStatus(){} // RVA: 0x7FFAC8228950
    public void GetMemoryStatus(){} // RVA: 0x7FFAC8228AC0
    public void FetchMemoryStatus(){} // RVA: 0x7FFAC8228C30
    public void get_FreeDiskSpaceBytes(){} // RVA: 0x7FFAC8228C40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class iOSVibration : Object
{
    public System.Lazy`1<bool> SupportsVibration;

    // ── Methods ──
    public void Vibrate(){} // RVA: 0x7FFAC2F21000
    public void VibrateSimple(){} // RVA: 0x7FFAC2F21080
    public void .cctor(){} // RVA: 0x7FFAC2F21100
}
