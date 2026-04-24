// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b09a20
        public void get_CanRead(){} // RVA: 0x7ffaae5cd6c0
        public void get_CanSeek(){} // RVA: 0x7ffaae5cd6f0
        public void get_CanWrite(){} // RVA: 0x7ffaaec42920
        public void get_Length(){} // RVA: 0x7ffaae8476b0
        public void get_Position(){} // RVA: 0x7ffaae8476e0
        public void set_Position(){} // RVA: 0x7ffaaebccde0
        public void Seek(){} // RVA: 0x7ffaaec42890
        public void Flush(){} // RVA: 0x7ffab1b09b60
        public void Read(){} // RVA: 0x7ffab1b09d20
        public void Write(){} // RVA: 0x7ffab1b09e20
        public void Dispose(){} // RVA: 0x7ffab1b09f60
        public void AcquireMutex(){} // RVA: 0x7ffab1b09f80
        // ── Binary Analysis Named ──
        public void SetLength(){} // RVA: 0x7ffab1b09c60
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        public object scopeProvider; // 0x350641D0
        public object Microsoft.Extensions.Options; // 0xB40C8A30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b0a160
        public void CreateLogger(){} // RVA: 0x7ffab1b0a3c0
        public void Dispose(){} // RVA: 0x7ffab1b0a470
        public void DisposeAsync(){} // RVA: 0x7ffab1b0a500
        // ── Binary Analysis Named ──
        public void SetScopeProvider(){} // RVA: 0x7ffaa89600d0
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        // ── Original Methods ──
        public void get_FileShared(){} // RVA: 0x7ffaa8bfcc70
        public void .ctor(){} // RVA: 0x7ffab1b0a150
    }

}