// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32.SafeHandles
// Classes: 7
// Methods: 15

namespace ThirdParty.DotNet.Microsoft.Win32.SafeHandles
{
    public class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537D9FF0
        public void ReleaseHandle(){} // RVA: 0x7FFD537DA520
    }

    public class SafeHandleCache`1 : Object
    {
        // ── Methods ──
        public void IsCachedInvalidHandle(){} // RVA: 0x7FFD4E079DE0
    }

    public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
    {
        public object IsInvalid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537DA750
        public void get_IsInvalid(){} // RVA: 0x7FFD537DA760
    }

    public class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537D9EF0
        public void ReleaseHandle(){} // RVA: 0x7FFD537D9F40
    }

    public class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x7FFD54155E20
        public void .ctor(){} // RVA: 0x7FFD537D9FF0 | overloaded x2
    }

    public class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void ReleaseHandle(){} // RVA: 0x7FFD537D9FD0
        public void .ctor(){} // RVA: 0x7FFD537D9FF0 | overloaded x2
    }

    public class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537D9FF0
        public void ReleaseHandle(){} // RVA: 0x7FFD537DA730
    }

}