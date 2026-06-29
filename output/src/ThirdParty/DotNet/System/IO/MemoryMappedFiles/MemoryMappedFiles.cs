// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 30

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl : Object
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x7AE464810
        public void CloseMapping(){} // RVA: 0x7AE464820
        public void Flush(){} // RVA: 0x7AE464890
        public void ConfigureHandleInheritability(){} // RVA: 0x7AE464930
        public void Unmap(){} // RVA: 0x7AE464950
        public void MapInternal(){} // RVA: 0x7AE464990
        public void Map(){} // RVA: 0x7AE464A40
        public void CreateException(){} // RVA: 0x7AE464B30
        public void StringLength(){} // RVA: 0x7AE464F40
        public void CheckString(){} // RVA: 0x7AE464F50
        public void OpenHandle(){} // RVA: 0x7AE464FE0
    }

    public class MemoryMappedFile : Object
    {
        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x7AE465120
        public void CreateViewAccessor(){} // RVA: 0x7AE4654D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7AE465670
        public void GetFileAccess(){} // RVA: 0x7AE465780
    }

    public class MemoryMappedView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE465820
        public void get_ViewHandle(){} // RVA: 0x7A80F2570
        public void get_PointerOffset(){} // RVA: 0x7A80DA7B0
        public void get_Size(){} // RVA: 0x7A81052C0
        public void get_Access(){} // RVA: 0x7A854FDE0
        public void Create(){} // RVA: 0x7AE465890
        public void Flush(){} // RVA: 0x7AE465BA0
        public void Dispose(){} // RVA: 0x7AE465C90
        public void get_IsClosed(){} // RVA: 0x7AE465D00
    }

    public class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4642D0
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x7AE4643E0
        public void get_PointerOffset(){} // RVA: 0x7AE464400
        public void Dispose(){} // RVA: 0x7AE464490
        public void Flush(){} // RVA: 0x7AE4646E0
    }

}