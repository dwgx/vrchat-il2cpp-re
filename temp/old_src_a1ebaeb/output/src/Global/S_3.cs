// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 22
// Methods: 53

public class Segment : Object
{
    public object _headAndTail; // 0x3868DBF8
    public object _nextSegment; // 0x3868DBF8
    public object .ctor; // 0xB3F6FFF0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac2f2980
    public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
    public void get_FreezeOffset(){} // RVA: 0x7ffaac2f2220
    public void EnsureFrozenForEnqueues(){} // RVA: 0x7ffaac2f2a60
    public void TryDequeue(){} // RVA: 0x7ffaac2f2b60
    public void TryPeek(){} // RVA: 0x7ffaac2f2da0
    public void TryEnqueue(){} // RVA: 0x7ffaac2f2f80
}

public class SingleConsumerUnboundedChannelReader : ChannelReader`1
{
    public object cancellationToken; // 0x39CE4600
    public object isWaiting; // 0x39CE4600

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac337dc0
    public void get_Completion(){} // RVA: 0x7ffaac337ee0
    public void TryRead(){} // RVA: 0x7ffaac3380e0
    public void WaitToReadAsync(){} // RVA: 0x7ffaac338570
    public void SingalContinuation(){} // RVA: 0x7ffaac338ad0
    public void SingalCancellation(){} // RVA: 0x7ffaac338b10
    public void SingalCompleted(){} // RVA: 0x7ffaac338b60
    public void ReadAllAsync(){} // RVA: 0x7ffaac338be0
    public void Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7ffaac338c60
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaac338cb0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x7ffaac338d00
    public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x7ffaac338d50
    public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7ffaac338dd0
    public void CancellationCallback(){} // RVA: 0x7ffaac338e10
}

public class SingleConsumerUnboundedChannelReader : ChannelReader`1
{
    public object cancellationToken; // 0x39EF2E38
    public object isWaiting; // 0x39EF2E38

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac33a080
    public void get_Completion(){} // RVA: 0x7ffaac33a1a0
    public void TryRead(){} // RVA: 0x7ffaac33a3a0
    public void WaitToReadAsync(){} // RVA: 0x7ffaac33a970
    public void SingalContinuation(){} // RVA: 0x7ffaac33aed0
    public void SingalCancellation(){} // RVA: 0x7ffaac33af10
    public void SingalCompleted(){} // RVA: 0x7ffaac33af60
    public void ReadAllAsync(){} // RVA: 0x7ffaac33afe0
    public void Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7ffaac33b060
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaac33b0b0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){} // RVA: 0x7ffaac33b100
    public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){} // RVA: 0x7ffaac33b150
    public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7ffaac33b1d0
    public void CancellationCallback(){} // RVA: 0x7ffaac33b210
}

public class SingleConsumerUnboundedChannelWriter : ChannelWriter`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void TryWrite(){} // RVA: 0x7ffaac33d280
    public void TryComplete(){} // RVA: 0x7ffaac33d4f0
}

public class SingleConsumerUnboundedChannelWriter : ChannelWriter`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void TryWrite(){} // RVA: 0x7ffaac33e0a0
    public void TryComplete(){} // RVA: 0x7ffaac33e320
}

public class SizeGroup : Object
{
    // ── Original Methods ──
    public void get_Count(){} // RVA: 0x7ffaa8f3de30
    public void TryGetArray(){} // RVA: 0x7ffaac342be0
    public void ReturnArray(){} // RVA: 0x7ffaac342680
    public void Cleanup(){} // RVA: 0x7ffaac3426b0
    public void Contains(){} // RVA: 0x7ffaac342730
    public void .ctor(){} // RVA: 0x7ffaac342760
}

public class SizeGroup : Object
{
}

public class SizeGroup : Object
{
}

public class SizeGroup : Object
{
    // ── Original Methods ──
    public void get_Count(){} // RVA: 0x7ffaa8f3de30
    public void TryGetArray(){} // RVA: 0x7ffaac3429a0
    public void ReturnArray(){} // RVA: 0x7ffaac342680
    public void Cleanup(){} // RVA: 0x7ffaac3426b0
    public void Contains(){} // RVA: 0x7ffaac342730
    public void .ctor(){} // RVA: 0x7ffaac342760
}

public class Slot : ValueType
{
}

public class Slot : ValueType
{
}

public class Slot : ValueType
{
    public object next; // 0x38695268
}

public class Slot : ValueType
{
    public object value; // 0x38702658
}

public class Slot : ValueType
{
    public object value; // 0x3872D7E8
}

public class Slot : ValueType
{
    public object next; // 0x3877DF20
}

public class Slot : ValueType
{
}

public class Slot : ValueType
{
    public object next; // 0x38782878
}

public class Slot : ValueType
{
    public object next; // 0x389ACE88
}

public class Slot : ValueType
{
    public object value; // 0x39FB1690
}

public class Slot : ValueType
{
    public object value; // 0x3A0B2A70
}

public class Slot : ValueType
{
    public object value; // 0x3A2AD668
}

public class Slot : ValueType
{
    public object value; // 0x3A496650
}
