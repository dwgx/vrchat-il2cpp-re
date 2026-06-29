// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B19561D0
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void Flush(){} // RVA: 0x7B1956310
        public void SetLength(){} // RVA: 0x7B1956410
        public void Read(){} // RVA: 0x7B19564E0
        public void Write(){} // RVA: 0x7B19565E0
        public void Dispose(){} // RVA: 0x7B1956730
        public void AcquireMutex(){} // RVA: 0x7B1956750
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1956930
        public void CreateLogger(){} // RVA: 0x7B1956BA0
        public void Dispose(){} // RVA: 0x7B1956C60
        public void DisposeAsync(){} // RVA: 0x7B1956CF0
        public void SetScopeProvider(){} // RVA: 0x7A81052D0
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        // ── Methods ──
        public void get_FileShared(){} // RVA: 0x7A82A20A0
        public void .ctor(){} // RVA: 0x7B1956920
    }

}