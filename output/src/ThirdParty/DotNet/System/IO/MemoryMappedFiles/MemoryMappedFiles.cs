// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl : Object
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x7FFE871B4F80
        public void CloseMapping(){} // RVA: 0x7FFE871B4F90
        public void Flush(){} // RVA: 0x7FFE871B5000
        public void ConfigureHandleInheritability(){} // RVA: 0x7FFE871B50A0
        public void Unmap(){} // RVA: 0x7FFE871B50C0
        public void MapInternal(){} // RVA: 0x7FFE871B5100
        public void Map(){} // RVA: 0x7FFE871B51C0
        public void CreateException(){} // RVA: 0x7FFE871B52B0
        public void StringLength(){} // RVA: 0x7FFE871B56C0
        public void CheckString(){} // RVA: 0x7FFE871B56D0
        public void OpenHandle(){} // RVA: 0x7FFE871B5760
    }

    public class MemoryMappedFile : Object
    {
        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x7FFE871B58A0
        public void CreateViewAccessor(){} // RVA: 0x7FFE871B5C50
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE871B5DF0 | overloaded x2
        public void GetFileAccess(){} // RVA: 0x7FFE871B5F00
    }

    public class MemoryMappedView : Object
    {
        public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle m_viewHandle; // 0x10
        public long m_pointerOffset; // 0x18
        public long m_size; // 0x20
        public 0x665F1DD4 m_access; // 0x28
        public object field_4; // 0x3DD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871B5FA0
        public void get_ViewHandle(){} // RVA: 0x7FFE81116380
        public void get_PointerOffset(){} // RVA: 0x7FFE810FE7C0
        public void get_Size(){} // RVA: 0x7FFE811290C0
        public void get_Access(){} // RVA: 0x7FFE81549710
        public void Create(){} // RVA: 0x7FFE871B6010
        public void Flush(){} // RVA: 0x7FFE871B6320
        public void Dispose(){} // RVA: 0x7FFE871B6410 | overloaded x2
        public void get_IsClosed(){} // RVA: 0x7FFE871B6480
    }

    public class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
        public System.IO.MemoryMappedFiles.MemoryMappedView m_view; // 0x30
        public object field_1; // 0x3DB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871B4A20
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x7FFE871B4B30
        public void get_PointerOffset(){} // RVA: 0x7FFE871B4B50
        public void Dispose(){} // RVA: 0x7FFE871B4BE0
        public void Flush(){} // RVA: 0x7FFE871B4E50
    }

}