// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Providers
// Classes: 3
// Methods: 21

namespace ThirdParty.Other.ZLogger.Providers
{
    public class SharedFileStream : Stream
    {
        public object CanRead;
        public object CanSeek;
        public object CanWrite;
        public object Length;
        public object Position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750DB10
        public void get_CanRead(){} // RVA: 0x7FFD53FCC4C0
        public void get_CanSeek(){} // RVA: 0x7FFD53FCC4F0
        public void get_CanWrite(){} // RVA: 0x7FFD54640950
        public void get_Length(){} // RVA: 0x7FFD54245730
        public void get_Position(){} // RVA: 0x7FFD54245760
        public void set_Position(){} // RVA: 0x7FFD545CAE10
        public void Seek(){} // RVA: 0x7FFD546408C0
        public void Flush(){} // RVA: 0x7FFD5750DC50
        public void SetLength(){} // RVA: 0x7FFD5750DD50
        public void Read(){} // RVA: 0x7FFD5750DE10
        public void Write(){} // RVA: 0x7FFD5750DF10
        public void Dispose(){} // RVA: 0x7FFD5750E050
        public void AcquireMutex(){} // RVA: 0x7FFD5750E070
    }

    public class ZLoggerFileLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750E250
        public void CreateLogger(){} // RVA: 0x7FFD5750E4B0
        public void Dispose(){} // RVA: 0x7FFD5750E560
        public void DisposeAsync(){} // RVA: 0x7FFD5750E5F0
        public void SetScopeProvider(){} // RVA: 0x7FFD4E36F0D0
    }

    public class ZLoggerFileOptions : ZLoggerOptions
    {
        public object FileShared;

        // ── Methods ──
        public void get_FileShared(){} // RVA: 0x7FFD4E5F95D0
        public void .ctor(){} // RVA: 0x7FFD5750E240
    }

}