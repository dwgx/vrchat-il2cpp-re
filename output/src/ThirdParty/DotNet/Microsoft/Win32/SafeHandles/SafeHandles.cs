// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32.SafeHandles
// Classes: 15
// Methods: 37

namespace ThirdParty.DotNet.Microsoft.Win32.SafeHandles
{
    public class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B420
        public void ReleaseHandle(){} // RVA: 0x669B960
    }

    public class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B320
        public void ReleaseHandle(){} // RVA: 0x669B9D0
    }

    public class SafeHandleCache`1 : Object
    {
        public object s_invalidHandle;

        // ── Methods ──
        public void IsCachedInvalidHandle(){} // RVA: 0x87D390
    }

    public class SafeHandleCache`1 : Object
    {
        public object s_invalidHandle;

        // ── Methods ──
        public void IsCachedInvalidHandle(){} // RVA: 0x4A7B7C0
    }

    public class SafeHandleMinusOneIsInvalid : SafeHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669BBA0
        public void get_IsInvalid(){} // RVA: 0x669B870
    }

    public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669BB70
        public void get_IsInvalid(){} // RVA: 0x669BB80
    }

    public class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B320
        public void ReleaseHandle(){} // RVA: 0x669B370
    }

    public class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B420
        public void ReleaseHandle(){} // RVA: 0x700D0C0
    }

    public class SafeMemoryMappedViewHandle : SafeBuffer
    {
        public object mmap_handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x700D150
        public void Flush(){} // RVA: 0x700D300
        public void ReleaseHandle(){} // RVA: 0x700D3A0
    }

    public class SafePasswordHandle : SafeHandle
    {
        // ── Methods ──
        public void CreateHandle(){} // RVA: 0x669B450
        public void FreeHandle(){} // RVA: 0x669B530
        public void .ctor(){} // RVA: 0x669B590
        public void ReleaseHandle(){} // RVA: 0x669B6B0
        public void Dispose(){} // RVA: 0x669B730
        public void get_IsInvalid(){} // RVA: 0x669B870
        public void Mono_DangerousGetString(){} // RVA: 0x669B880
    }

    public class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public object DefaultInvalidHandle;

        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x700CFE0
        public void .ctor(){} // RVA: 0x669B420
    }

    public class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public object InvalidHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B420
        public void ReleaseHandle(){} // RVA: 0x7649040
        public void .cctor(){} // RVA: 0x7649060
    }

    public class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x669B400
        public void .ctor(){} // RVA: 0x669B420
    }

    public class SafeThreadPoolIOHandle : SafeHandle
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x18F3EB0
        public void .ctor(){} // RVA: 0x669B320
        public void get_IsInvalid(){} // RVA: 0x1825040
        public void ReleaseHandle(){} // RVA: 0x669B8E0
    }

    public class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669B420
        public void ReleaseHandle(){} // RVA: 0x669BB50
    }

}