// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream
    {
        public System.IO.FileStream innerStream; // 0x28
        public System.Threading.Mutex mutex; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B14270
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_CanWrite(){} // RVA: 0x6A89DD0
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x6A142C0
        public void Seek(){} // RVA: 0x6A89D40
        public void Flush(){} // RVA: 0x9B143B0
        public void SetLength(){} // RVA: 0x9B144B0
        public void Read(){} // RVA: 0x9B14570
        public void Write(){} // RVA: 0x9B14670
        public void Dispose(){} // RVA: 0x9B147B0
        public void AcquireMutex(){} // RVA: 0x9B147D0
    }

    public class ZLoggerFileLoggerProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B149B0
        public void CreateLogger(){} // RVA: 0x9B14C10
        public void Dispose(){} // RVA: 0x9B14CC0
        public void DisposeAsync(){} // RVA: 0x9B14D50
        public void SetScopeProvider(){} // RVA: 0x30B0D0
    }

    public class ZLoggerFileOptions
    {
        public bool <FileShared>k__BackingField; // 0x38

        // ── Methods ──
        public void get_FileShared(){} // RVA: 0x4A6500
        public void .ctor(){} // RVA: 0x9B149A0
    }

}