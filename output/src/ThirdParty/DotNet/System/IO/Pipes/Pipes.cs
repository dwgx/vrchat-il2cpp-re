// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 1
// Methods: 10

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public 0x66426248 Overlapped;
        public System.Threading.CancellationTokenRegistration _cancellationRegistration;
        public int _errorCode;
        public 0x66425C18* _overlapped;
        public System.Buffers.MemoryHandle _pinnedMemory;
        public int _state;

        // ── Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x7FFD4E2ADC40
        public void RegisterForCancellation(){} // RVA: 0x7FFD4E090BF0
        public void ReleaseResources(){} // RVA: 0x7FFD4E090980
        public void SetCompletedSynchronously(){} // RVA: 0x7FFD4E090980
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x7FFD4E090ED0
        public void Cancel(){} // RVA: 0x7FFD4E090980
        public void HandleUnexpectedCancellation(){} // RVA: 0x7FFD4E090980
        public void CompleteCallback(){} // RVA: 0x7FFD4E090ED0
    }

}