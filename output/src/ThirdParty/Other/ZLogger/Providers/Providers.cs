// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        public System.IO.FileStream innerStream; // 0x28
        public System.Threading.Mutex mutex; // 0x30
        public object field_2; // 0x19
        public object field_3; // 0x1A
        public object field_4; // 0x1B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A553AE0
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void Flush(){} // RVA: 0x7FFE8A553C20
        public void SetLength(){} // RVA: 0x7FFE8A553D20
        public void Read(){} // RVA: 0x7FFE8A553DE0
        public void Write(){} // RVA: 0x7FFE8A553EE0
        public void Dispose(){} // RVA: 0x7FFE8A554020
        public void AcquireMutex(){} // RVA: 0x7FFE8A554040
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A554220
        public void CreateLogger(){} // RVA: 0x7FFE8A554480
        public void Dispose(){} // RVA: 0x7FFE8A554530
        public void DisposeAsync(){} // RVA: 0x7FFE8A5545C0
        public void SetScopeProvider(){} // RVA: 0x7FFE811290D0
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        public bool _fileShared; // 0x38

        // ── Methods ──
        public void get_FileShared(){} // RVA: 0x7FFE812CF770
        public void .ctor(){} // RVA: 0x7FFE8A554210
    }

}