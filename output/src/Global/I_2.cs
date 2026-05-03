// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 40
// Methods: 171

public class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE876E9AD0
}

public class IntChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89D16AB0
}

public class IntPoint : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AC4140 | overloaded x3
    public void op_Equality(){} // RVA: 0x7FFE82AC4DD0
    public void op_Inequality(){} // RVA: 0x7FFE82AC4DF0
    public void Equals(){} // RVA: 0x7FFE82AC4E10
    public void GetHashCode(){} // RVA: 0x7FFE82AC4EA0
}

public class IntRect : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AC4F20 | overloaded x2
}

public class IntegerInput : TextValueInput
{
    // ── Methods ──
    public void get_parentIntegerField(){} // RVA: 0x7FFE87EE68C0
    public void .ctor(){} // RVA: 0x7FFE87EE6940
    public void get_allowedCharacters(){} // RVA: 0x7FFE87EE6B00
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87EE6B60
    public void ValueToString(){} // RVA: 0x7FFE87EE6D90
    public void StringToValue(){} // RVA: 0x7FFE87EE6E80
}

public class Interaction : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class InteractionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE812572A0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE81257380
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InteractionEvent : Object
{
    // ── Methods ──
    public void Activate(){} // RVA: 0x7FFE81250A70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class InteractionEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81257410
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE81257500
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InteractionState : ValueType
{
    public ushort m_TriggerControlIndex; // 0x10
    public byte m_Phase; // 0x12
    public byte m_Flags; // 0x13
    public float m_TimerDuration; // 0x14
    public double m_StartTime; // 0x18
    public double m_TimerStartTime; // 0x20
    public double m_PerformedTime; // 0x28
    public float m_TotalTimeoutCompletionTimeDone; // 0x30
    public float m_TotalTimeoutCompletionTimeRemaining; // 0x34
    public long m_TimerMonitorIndex; // 0x38

    // ── Methods ──
    public void get_triggerControlIndex(){} // RVA: 0x7FFE878F4A20
    public void set_triggerControlIndex(){} // RVA: 0x7FFE878F4A40
    public void get_startTime(){} // RVA: 0x7FFE82A39E80
    public void set_startTime(){} // RVA: 0x7FFE82D1D7B0
    public void get_performedTime(){} // RVA: 0x7FFE826F6CB0
    public void set_performedTime(){} // RVA: 0x7FFE850B2980
    public void get_timerStartTime(){} // RVA: 0x7FFE83BB0D80
    public void set_timerStartTime(){} // RVA: 0x7FFE84D215B0
    public void get_timerDuration(){} // RVA: 0x7FFE82D03B70
    public void set_timerDuration(){} // RVA: 0x7FFE82D03BD0
    public void get_totalTimeoutCompletionDone(){} // RVA: 0x7FFE81124080
    public void set_totalTimeoutCompletionDone(){} // RVA: 0x7FFE81D54160
    public void get_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7FFE81268F50
    public void set_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7FFE81268F60
    public void get_timerMonitorIndex(){} // RVA: 0x7FFE81129130
    public void set_timerMonitorIndex(){} // RVA: 0x7FFE8164D390
    public void get_isTimerRunning(){} // RVA: 0x7FFE878F4AC0
    public void set_isTimerRunning(){} // RVA: 0x7FFE878F4AD0
    public void get_phase(){} // RVA: 0x7FFE82BC9950
    public void set_phase(){} // RVA: 0x7FFE81E63F60
}

public class Internal : Object
{
}

public class InternalCollisionIgnoreSettings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81171710
}

public class InternalEnumerator`1 : ValueType
{
    public System.Array array; // 0x10
    public int idx; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE842583E0
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void MoveNext(){} // RVA: 0x7FFE84258450
    public void get_Current(){} // RVA: 0x7FFE842586D0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE84258640
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE8425F510
}

public class InternalPartitionEnumerable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4BC90
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void TryCopyFromFillBuffer(){} // RVA: 0x7FFE80E4DDD0
    public void GrabChunk(){}
    public void GrabChunk_Single(){}
    public void GrabChunk_Buffered(){}
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class InternalPartitionEnumerator : DynamicPartitionEnumerator_Abstract`2
{
    public System.Collections.Generic.KeyValuePair`2<long,T>[] _localList;
    public SharedBool _hasNoElementsLeft;

    // ── Methods ──
    public void .ctor(){}
    public void GrabNextChunk(){} // RVA: 0x7FFE80E2F760
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class Interop : Object
{
    // ── Methods ──
    public void GetRandomBytes(){} // RVA: 0x7FFE86730E90
    public void MemAlloc(){} // RVA: 0x7FFE86730FA0
}

public class IntersectNode : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class IntersectionResults : ValueType
{
}

public class Interval : Object
{
    public Google.Protobuf.MessageParser`1<Interval> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int YFieldNumber;
    public int YDefaultValue; // 0x8
    public int y_; // 0x1C
    public int LeftXFieldNumber;
    public int LeftXDefaultValue; // 0xC
    public int leftX_; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE86645AD0
    public void get_Descriptor(){} // RVA: 0x7FFE86645B30
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86645BB0
    public void .ctor(){} // RVA: 0x7FFE86645C60 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE86645D60
    public void get_Y(){} // RVA: 0x7FFE86645E90
    public void set_Y(){} // RVA: 0x7FFE8659D0A0
    public void get_HasY(){} // RVA: 0x7FFE8659D0B0
    public void ClearY(){} // RVA: 0x7FFE8659D0C0
    public void get_LeftX(){} // RVA: 0x7FFE86645F00
    public void set_LeftX(){} // RVA: 0x7FFE8659D140
    public void get_HasLeftX(){} // RVA: 0x7FFE8659D150
    public void ClearLeftX(){} // RVA: 0x7FFE8659D160
    public void get_RightX(){} // RVA: 0x7FFE86645F70
    public void set_RightX(){} // RVA: 0x7FFE8662CDC0
    public void get_HasRightX(){} // RVA: 0x7FFE865A0350
    public void ClearRightX(){} // RVA: 0x7FFE865A0360
    public void Equals(){} // RVA: 0x7FFE86646100 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE866461E0
    public void ToString(){} // RVA: 0x7FFE86646260
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866462B0
    public void CalculateSize(){} // RVA: 0x7FFE86646360
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866465A0
    public void .cctor(){} // RVA: 0x7FFE86646660
}

public class IntializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class InventoryColorPaletteData : ValueType
{
}

public class InvocationContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void Invoke(){} // RVA: 0x7FFE85CAA710
}

public class InvocationEntryDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9AD0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class InvocationExpressionProxy : Object
{
    public System.Linq.Expressions.InvocationExpression _node; // 0x10
    public object field_1; // 0xCF
    public object field_2; // 0xD0
    public object field_3; // 0xD1
    public object field_4; // 0xD2
    public object field_5; // 0xD3

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87119DA0
    public void get_Arguments(){} // RVA: 0x7FFE87119A80
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Expression(){} // RVA: 0x7FFE8189C080
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class IsAutoDispose : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE878B8BB0
}

public class IsBurstEnabledDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84008FC0
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class IsBurstEnabled_00000145$BurstDirectCall : Object
{
    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878AEF80
    public void GetFunctionPointer(){} // RVA: 0x7FFE878AF0C0
    public void Constructor(){} // RVA: 0x7FFE878AF230
    public void Initialize(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE878AF230
    public void Invoke(){} // RVA: 0x7FFE878AF2F0
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84008FC0
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class IsCanceledSource : Object
{
}

public class IsLocalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828C6D10
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE828C6E90
}

public class IsOfType`1 : Object
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x7FFE80E2F3B0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class IsRegistered`1 : Object
{
}

public class IsolatingRunSequence : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE865E1780
}

public class Item : ValueType
{
    public UnityEngine.Vector3 Pos; // 0x10

    // ── Methods ──
    public void Lerp(){} // RVA: 0x7FFE82AB8D20
    public void get_Empty(){} // RVA: 0x7FFE82AB8E80
}

public class ItemAttribute : ApiModel
{
    public object _defaultValue; // 0x68
    public ItemAttributeValidation _validator; // 0x70

    // ── Methods ──
    public void get_defaultValue(){} // RVA: 0x7FFE81176D50
    public void set_defaultValue(){} // RVA: 0x7FFE81176D60
    public void get_validator(){} // RVA: 0x7FFE811C3590
    public void set_validator(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A2DEBE0
}

public class ItemAttributeValidation : ApiModel
{
    public string _type; // 0x68

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFE81176D50
    public void set_type(){} // RVA: 0x7FFE81176D60
    public void .ctor(){} // RVA: 0x7FFE8A2DEC30
}

public class IterationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE811EC440
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Iterator`1 : Object
{
    public int threadId;
    public int state;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void Clone(){} // RVA: 0x7FFE80E2E2E0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Select(){} // RVA: 0x7FFE80E2E390
    public void Where(){} // RVA: 0x7FFE80E2E390
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
}

public class iOSInfo : Object
{
    public bool _hasFetchedInfo;
    public long LowMemoryThreshold;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE865D1DC0
    public void FetchInfo(){} // RVA: 0x7FFE865D1DD0
    public void get_CacheDir(){} // RVA: 0x7FFE865D1E90
    public void CheckMemoryStatusThread(){} // RVA: 0x7FFE865D1FD0
    public void PollMemoryStatus(){} // RVA: 0x7FFE865D2290
    public void GetMemoryStatus(){} // RVA: 0x7FFE865D2400
    public void FetchMemoryStatus(){} // RVA: 0x7FFE865D2570
    public void get_FreeDiskSpaceBytes(){} // RVA: 0x7FFE865D2580
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class iOSVibration : Object
{
    // ── Methods ──
    public void Vibrate(){} // RVA: 0x7FFE810FB000
    public void VibrateSimple(){} // RVA: 0x7FFE810FB080
    public void .cctor(){} // RVA: 0x7FFE810FB100
}
