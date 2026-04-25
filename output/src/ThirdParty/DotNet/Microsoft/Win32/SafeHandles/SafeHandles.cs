// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32.SafeHandles
// Classes: 14
// Methods: 39

namespace ThirdParty.DotNet.Microsoft.Win32.SafeHandles
{
    public class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0
        public void ReleaseHandle(){} // RVA: 0x7FFAC83BA520
    }

    public class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9EF0
        public void ReleaseHandle(){} // RVA: 0x7FFAC83BA590
    }

    public class SafeHandleCache`1 : Object
    {
        public T s_invalidHandle;

        // ── Methods ──
        public void IsCachedInvalidHandle(){} // RVA: 0x7FFAC2C59DE0
    }

    public class SafeHandleMinusOneIsInvalid : SafeHandle
    {
        public object IsInvalid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83BA780
        public void get_IsInvalid(){} // RVA: 0x7FFAC83BA430
    }

    public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
    {
        public object IsInvalid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83BA750
        public void get_IsInvalid(){} // RVA: 0x7FFAC83BA760
    }

    public class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9EF0
        public void ReleaseHandle(){} // RVA: 0x7FFAC83B9F40
    }

    public class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0
        public void ReleaseHandle(){} // RVA: 0x7FFAC8D35F00
    }

    public class SafeMemoryMappedViewHandle : SafeBuffer
    {
        public UIntPtr mmap_handle; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D35F90
        public void Flush(){} // RVA: 0x7FFAC8D36140
        public void ReleaseHandle(){} // RVA: 0x7FFAC8D361E0
    }

    public class SafePasswordHandle : SafeHandle
    {
        public object IsInvalid;

        // ── Methods ──
        public void CreateHandle(){} // RVA: 0x7FFAC83BA020
        public void FreeHandle(){} // RVA: 0x7FFAC83BA100
        public void .ctor(){} // RVA: 0x7FFAC83BA160
        public void ReleaseHandle(){} // RVA: 0x7FFAC83BA270
        public void Dispose(){} // RVA: 0x7FFAC83BA2F0
        public void get_IsInvalid(){} // RVA: 0x7FFAC83BA430
        public void Mono_DangerousGetString(){} // RVA: 0x7FFAC83BA440
    }

    public class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public int DefaultInvalidHandle;

        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x7FFAC8D35E20
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0 | overloaded x2
    }

    public class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0 | overloaded x2
        public void ReleaseHandle(){} // RVA: 0x7FFAC93806A0
        public void .cctor(){} // RVA: 0x7FFAC93806C0
    }

    public class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x7FFAC83B9FD0
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0 | overloaded x2
    }

    public class SafeThreadPoolIOHandle : SafeHandle
    {
        public object IsInvalid;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC35D2DD0
        public void .ctor(){} // RVA: 0x7FFAC83B9EF0
        public void get_IsInvalid(){} // RVA: 0x7FFAC353FA50
        public void ReleaseHandle(){} // RVA: 0x7FFAC83BA4A0
    }

    public class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83B9FF0
        public void ReleaseHandle(){} // RVA: 0x7FFAC83BA730
    }

}