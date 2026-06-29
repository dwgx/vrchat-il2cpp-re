// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 4
// Methods: 17

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class ReadOnlyAsyncReactiveProperty`1 : Object
    {
        public object triggerEvent;
        public object latestValue;
        public object enumerator;
        public object isValueType;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x899C90
        public void ConsumeEnumerator(){} // RVA: 0xA94080
        public void WithoutCurrent(){} // RVA: 0x87C0A0
        public void GetAsyncEnumerator(){} // RVA: 0x881D60
        public void Dispose(){} // RVA: 0x894290
        public void op_Implicit(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void WaitAsync(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class RealtimePlayerLoopTimer : PlayerLoopTimer
    {
        public object stopwatch;
        public object intervalTicks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x774AFC0
        public void MoveNextCore(){} // RVA: 0x774B090
        public void ResetCore(){} // RVA: 0x774B0F0
    }

    public class ReturnToMainThread : ValueType
    {
        public object playerLoopTiming;
        public object cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3616C0
        public void DisposeAsync(){} // RVA: 0x920590
    }

    public class ReturnToSynchronizationContext : ValueType
    {
        public object syncContext;
        public object dontPostWhenSameContext;
        public object cancellationToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x921200
        public void DisposeAsync(){} // RVA: 0x921210
    }

}