// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Pipes
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.IO.Pipes
{
    public class PipeAccessRule : AccessRule
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae832ce0
        public void .ctor(){} // RVA: 0x7ffaae832ce0
        public void AccessMaskFromRights(){} // RVA: 0x7ffaae832d80
    }

    public class PipeCompletionSource`1 : TaskCompletionSource`1
    {
        public object _errorCode; // 0x30B30870
        public object _state; // 0x30B30870
        public object Overlapped; // 0x170003E2

        // ── Original Methods ──
        public void .ctor(){}
        public void get_Overlapped(){} // RVA: 0x7ffaa887e5c0
        public void RegisterForCancellation(){} // RVA: 0x7ffaa8660f30
        public void ReleaseResources(){} // RVA: 0x7ffaa8660cc0
        public void AsyncCallback(){}
        public void HandleError(){} // RVA: 0x7ffaa8661210
        public void Cancel(){} // RVA: 0x7ffaa8660cc0
        public void HandleUnexpectedCancellation(){} // RVA: 0x7ffaa8660cc0
        public void CompleteCallback(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void SetCompletedSynchronously(){} // RVA: 0x7ffaa8660cc0
    }

    public class PipeSecurity : NativeObjectSecurity
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae832e60
        public void .ctor(){} // RVA: 0x7ffaae832e60
        public void AddAccessRule(){} // RVA: 0x7ffaae832f60
    }

}