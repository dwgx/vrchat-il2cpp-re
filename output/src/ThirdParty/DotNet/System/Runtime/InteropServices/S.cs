// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 6
// Methods: 26

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class SafeBuffer
    {
        public object Uninitialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D3E0C0
        public void Initialize(){} // RVA: 0x5D3E140
        public void AcquirePointer(){} // RVA: 0x5D3E210
        public void ReleasePointer(){} // RVA: 0x5D3E2E0
        public void get_ByteLength(){} // RVA: 0x5D3E390
        public void NotInitialized(){} // RVA: 0x5D3E440
        public void .cctor(){} // RVA: 0x5D3E4B0
    }

    public class SafeHandle
    {
        public UIntPtr handle; // 0x10
        public int _state; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D3EB80
        public void Finalize(){} // RVA: 0x5D3EC10
        public void SetHandle(){} // RVA: 0x1967700
        public void DangerousGetHandle(){} // RVA: 0x2F8380
        public void get_IsClosed(){} // RVA: 0x5D3EC80
        public void get_IsInvalid(){} // RVA: 0xDBE0
        public void Close(){} // RVA: 0x5AB1BC0
        public void Dispose(){} // RVA: 0x5D3EC90 | overloaded x2
        public void ReleaseHandle(){} // RVA: 0xDBE0
        public void SetHandleAsInvalid(){} // RVA: 0x5D3ED50
        public void DangerousAddRef(){} // RVA: 0x5D3EE80
        public void DangerousRelease(){} // RVA: 0x5D3F010
        public void InternalDispose(){} // RVA: 0x5D3F020
        public void InternalFinalize(){} // RVA: 0x5D3F0C0
        public void DangerousReleaseInternal(){} // RVA: 0x5D3F0E0
    }

    public class SequenceMarshal
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x62C2500
    }

    public class SequenceMarshal
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x5D3D4F0
    }

    public class StructLayoutAttribute
    {
    }

    public class SuppressGCTransitionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}