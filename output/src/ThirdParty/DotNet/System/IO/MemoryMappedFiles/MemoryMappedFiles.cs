// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 30

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl : Object
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x70E0920
        public void CloseMapping(){} // RVA: 0x70E0930
        public void Flush(){} // RVA: 0x70E09B0
        public void ConfigureHandleInheritability(){} // RVA: 0x70E0A50
        public void Unmap(){} // RVA: 0x70E0A70
        public void MapInternal(){} // RVA: 0x70E0AB0
        public void Map(){} // RVA: 0x70E0B60
        public void CreateException(){} // RVA: 0x70E0C50
        public void StringLength(){} // RVA: 0x70E1060
        public void CheckString(){} // RVA: 0x70E1070
        public void OpenHandle(){} // RVA: 0x70E1100
    }

    public class MemoryMappedFile : Object
    {
        public object stream;
        public object keepOpen;
        public object handle;

        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x70E1240
        public void CreateViewAccessor(){} // RVA: 0x70E15F0
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0x70E1790
        public void GetFileAccess(){} // RVA: 0x70E18A0
    }

    public class MemoryMappedView : Object
    {
        public object m_viewHandle;
        public object m_pointerOffset;
        public object m_size;
        public object m_access;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E1940
        public void get_ViewHandle(){} // RVA: 0xB5DBF0
        public void get_PointerOffset(){} // RVA: 0xB465B0
        public void get_Size(){} // RVA: 0xB700F0
        public void get_Access(){} // RVA: 0x1065D50
        public void Create(){} // RVA: 0x70E19B0
        public void Flush(){} // RVA: 0x70E1CC0
        public void Dispose(){} // RVA: 0x70E1DB0
        public void get_IsClosed(){} // RVA: 0x70E1E20
    }

    public class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
        public object m_view;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70E03E0
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x70E04F0
        public void get_PointerOffset(){} // RVA: 0x70E0510
        public void Dispose(){} // RVA: 0x70E05A0
        public void Flush(){} // RVA: 0x70E07F0
    }

}