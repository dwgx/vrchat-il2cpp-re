// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        public System.IO.FileStream CanRead; // 0x28
        public System.Threading.Mutex CanSeek; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0EDB10
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void Flush(){} // RVA: 0x7FFACC0EDC50
        public void SetLength(){} // RVA: 0x7FFACC0EDD50
        public void Read(){} // RVA: 0x7FFACC0EDE10
        public void Write(){} // RVA: 0x7FFACC0EDF10
        public void Dispose(){} // RVA: 0x7FFACC0EE050
        public void AcquireMutex(){} // RVA: 0x7FFACC0EE070
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        public ZLogger.Providers.ZLoggerFileOptions options; // 0x10
        public ZLogger.AsyncStreamLineMessageWriter streamWriter; // 0x18
        public Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0EE250
        public void CreateLogger(){} // RVA: 0x7FFACC0EE4B0
        public void Dispose(){} // RVA: 0x7FFACC0EE560
        public void DisposeAsync(){} // RVA: 0x7FFACC0EE5F0
        public void SetScopeProvider(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        public bool FileShared; // 0x38

        // ── Methods ──
        public void get_FileShared(){} // RVA: 0x7FFAC31D95D0
        public void .ctor(){} // RVA: 0x7FFACC0EE240
    }

}