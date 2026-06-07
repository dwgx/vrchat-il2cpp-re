// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x6676090
        public void CloseMapping(){} // RVA: 0x66760A0
        public void Flush(){} // RVA: 0x6676110
        public void ConfigureHandleInheritability(){} // RVA: 0x66761B0
        public void Unmap(){} // RVA: 0x66761D0
        public void MapInternal(){} // RVA: 0x6676210
        public void Map(){} // RVA: 0x66762D0
        public void CreateException(){} // RVA: 0x66763C0
        public void StringLength(){} // RVA: 0x66767D0
        public void CheckString(){} // RVA: 0x66767E0
        public void OpenHandle(){} // RVA: 0x6676870
    }

    public class MemoryMappedFile : CreateFromFile
    {
        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x66769B0
        public void CreateViewAccessor(){} // RVA: 0x6676D60
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x6676F00 | overloaded x2
        public void GetFileAccess(){} // RVA: 0x6677010
    }

    public class MemoryMappedView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66770B0
        public void get_ViewHandle(){} // RVA: 0x2F8380
        public void get_PointerOffset(){} // RVA: 0x2E07C0
        public void get_Size(){} // RVA: 0x30B0C0
        public void get_Access(){} // RVA: 0x791DC0
        public void Create(){} // RVA: 0x6677120
        public void Flush(){} // RVA: 0x6677430
        public void Dispose(){} // RVA: 0x6677520 | overloaded x2
        public void get_IsClosed(){} // RVA: 0x6677590
    }

    public class MemoryMappedViewAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6675B30
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x6675C40
        public void get_PointerOffset(){} // RVA: 0x6675C60
        public void Dispose(){} // RVA: 0x6675CF0
        public void Flush(){} // RVA: 0x6675F60
    }

}