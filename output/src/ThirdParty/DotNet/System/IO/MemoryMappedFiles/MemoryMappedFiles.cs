// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl : Object
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x7FFAC8E0CB50
        public void CloseMapping(){} // RVA: 0x7FFAC8E0CB60
        public void Flush(){} // RVA: 0x7FFAC8E0CBD0
        public void ConfigureHandleInheritability(){} // RVA: 0x7FFAC8E0CC70
        public void Unmap(){} // RVA: 0x7FFAC8E0CC90
        public void MapInternal(){} // RVA: 0x7FFAC8E0CCD0
        public void Map(){} // RVA: 0x7FFAC8E0CD90
        public void CreateException(){} // RVA: 0x7FFAC8E0CE80
        public void StringLength(){} // RVA: 0x7FFAC8E0D290
        public void CheckString(){} // RVA: 0x7FFAC8E0D2A0
        public void OpenHandle(){} // RVA: 0x7FFAC8E0D330
    }

    public class MemoryMappedFile : Object
    {
        public System.IO.FileStream stream; // 0x10
        public bool keepOpen; // 0x18
        public Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle handle; // 0x20

        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x7FFAC8E0D470
        public void CreateViewAccessor(){} // RVA: 0x7FFAC8E0D820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC8E0D9C0 | overloaded x2
        public void GetFileAccess(){} // RVA: 0x7FFAC8E0DAD0
    }

    public class MemoryMappedView : Object
    {
        public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle ViewHandle; // 0x10
        public long PointerOffset; // 0x18
        public long Size; // 0x20
        public 0x6B1F8510 Access; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E0DB70
        public void get_ViewHandle(){} // RVA: 0x7FFAC2F3C380
        public void get_PointerOffset(){} // RVA: 0x7FFAC2F247C0
        public void get_Size(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Access(){} // RVA: 0x7FFAC32EC4C0
        public void Create(){} // RVA: 0x7FFAC8E0DBE0
        public void Flush(){} // RVA: 0x7FFAC8E0DEF0
        public void Dispose(){} // RVA: 0x7FFAC8E0DFE0 | overloaded x2
        public void get_IsClosed(){} // RVA: 0x7FFAC8E0E050
    }

    public class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
        public System.IO.MemoryMappedFiles.MemoryMappedView SafeMemoryMappedViewHandle; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E0C5F0
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x7FFAC8E0C700
        public void get_PointerOffset(){} // RVA: 0x7FFAC8E0C720
        public void Dispose(){} // RVA: 0x7FFAC8E0C7B0
        public void Flush(){} // RVA: 0x7FFAC8E0CA20
    }

}