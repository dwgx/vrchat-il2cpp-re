// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 2
// Methods: 18

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class SingleProducerSingleConsumerQueue`1
    {
        public Segment<T> _head;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Enqueue(){} // RVA: 0x283FA0
        public void EnqueueSlow(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void TryPeek(){} // RVA: 0xDE40
        public void TryDequeueSlow(){} // RVA: 0x283FA0
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class SingleProducerSingleConsumerQueue`1 : Ђ10
    {
        public Segment<ZLogger.IZLoggerEntry> _head; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40280F0
        public void Enqueue(){} // RVA: 0x4028210
        public void EnqueueSlow(){} // RVA: 0x40282B0
        public void TryDequeue(){} // RVA: 0x40285B0
        public void TryPeek(){} // RVA: 0x40286D0
        public void TryDequeueSlow(){} // RVA: 0x40287A0
        public void get_IsEmpty(){} // RVA: 0x4028A40
        public void GetEnumerator(){} // RVA: 0x4028AA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4028B30
    }

}