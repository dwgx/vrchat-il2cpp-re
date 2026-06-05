// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.MemoryMappedFiles
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.System.IO.MemoryMappedFiles
{
    public class MemoryMapImpl
    {
        // ── Methods ──
        public void OpenHandleInternal(){} // RVA: 0x7FFAF9126090
        public void CloseMapping(){} // RVA: 0x7FFAF91260A0
        public void Flush(){} // RVA: 0x7FFAF9126110
        public void ConfigureHandleInheritability(){} // RVA: 0x7FFAF91261B0
        public void Unmap(){} // RVA: 0x7FFAF91261D0
        public void MapInternal(){} // RVA: 0x7FFAF9126210
        public void Map(){} // RVA: 0x7FFAF91262D0
        public void CreateException(){} // RVA: 0x7FFAF91263C0
        public void StringLength(){} // RVA: 0x7FFAF91267D0
        public void CheckString(){} // RVA: 0x7FFAF91267E0
        public void OpenHandle(){} // RVA: 0x7FFAF9126870
    }

    public class MemoryMappedFile : CreateFromFile
    {
        // ── Methods ──
        public void CreateFromFile(){} // RVA: 0x7FFAF91269B0
        public void CreateViewAccessor(){} // RVA: 0x7FFAF9126D60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF9126F00 | overloaded x2
        public void GetFileAccess(){} // RVA: 0x7FFAF9127010
    }

    public class MemoryMappedView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91270B0
        public void get_ViewHandle(){} // RVA: 0x7FFAF2DA8380
        public void get_PointerOffset(){} // RVA: 0x7FFAF2D907C0
        public void get_Size(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Access(){} // RVA: 0x7FFAF3241DC0
        public void Create(){} // RVA: 0x7FFAF9127120
        public void Flush(){} // RVA: 0x7FFAF9127430
        public void Dispose(){} // RVA: 0x7FFAF9127520 | overloaded x2
        public void get_IsClosed(){} // RVA: 0x7FFAF9127590
    }

    public class MemoryMappedViewAccessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9125B30
        public void get_SafeMemoryMappedViewHandle(){} // RVA: 0x7FFAF9125C40
        public void get_PointerOffset(){} // RVA: 0x7FFAF9125C60
        public void Dispose(){} // RVA: 0x7FFAF9125CF0
        public void Flush(){} // RVA: 0x7FFAF9125F60
    }

}