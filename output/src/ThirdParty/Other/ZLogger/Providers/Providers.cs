// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        public object innerStream;
        public object mutex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C2650
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
        public void Seek(){} // RVA: 0x74EEE80
        public void Flush(){} // RVA: 0xA7C2790
        public void SetLength(){} // RVA: 0xA7C2890
        public void Read(){} // RVA: 0xA7C2960
        public void Write(){} // RVA: 0xA7C2A60
        public void Dispose(){} // RVA: 0xA7C2BB0
        public void AcquireMutex(){} // RVA: 0xA7C2BD0
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        public object options;
        public object streamWriter;
        public object scopeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C2DB0
        public void CreateLogger(){} // RVA: 0xA7C3020
        public void Dispose(){} // RVA: 0xA7C30E0
        public void DisposeAsync(){} // RVA: 0xA7C3170
        public void SetScopeProvider(){} // RVA: 0xB70100
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        public object _fileShared;

        // ── Methods ──
        public void get_FileShared(){} // RVA: 0xD16660
        public void .ctor(){} // RVA: 0xA7C2DA0
    }

}