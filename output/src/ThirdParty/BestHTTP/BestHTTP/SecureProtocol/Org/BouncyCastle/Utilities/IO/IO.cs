// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x3C85330
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void Close(){} // RVA: 0x96E0850
        public void Flush(){} // RVA: 0x2DD310
        public void get_Length(){} // RVA: 0x96E0860
        public void get_Position(){} // RVA: 0x96E08A0
        public void set_Position(){} // RVA: 0x96E08E0
        public void Read(){} // RVA: 0x96E0920
        public void Seek(){} // RVA: 0x96E09F0
        public void SetLength(){} // RVA: 0x96E0A30
        public void Write(){} // RVA: 0x96E0A70
        public void .ctor(){} // RVA: 0x96E0AB0
    }

    public class BaseOutputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C85330
        public void Close(){} // RVA: 0x96E0850
        public void Flush(){} // RVA: 0x2DD310
        public void get_Length(){} // RVA: 0x96E0B00
        public void get_Position(){} // RVA: 0x96E0B40
        public void set_Position(){} // RVA: 0x96E0B80
        public void Read(){} // RVA: 0x96E0BC0
        public void Seek(){} // RVA: 0x96E0C00
        public void SetLength(){} // RVA: 0x96E0C40
        public void Write(){} // RVA: 0x9550310 | overloaded x2
        public void WriteByte(){} // RVA: 0x96E0D00
        public void .ctor(){} // RVA: 0x96E0D90
    }

    public class FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E0DE0
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_CanWrite(){} // RVA: 0x6A89DD0
        public void get_Length(){} // RVA: 0x668EC70
        public void get_Position(){} // RVA: 0x668ECA0
        public void set_Position(){} // RVA: 0x6A142C0
        public void Close(){} // RVA: 0x96E0E80
        public void Flush(){} // RVA: 0x6415940
        public void Seek(){} // RVA: 0x6A89D40
        public void SetLength(){} // RVA: 0x668EB50
        public void Read(){} // RVA: 0x6A89D10
        public void ReadByte(){} // RVA: 0x5E081B0
        public void Write(){} // RVA: 0x6A89D70
        public void WriteByte(){} // RVA: 0x6A89DA0
    }

    public class MemoryInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E0F00
        public void get_CanWrite(){} // RVA: 0x2DD320
    }

    public class MemoryOutputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x9521B80
    }

    public class NullOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0x2DD310
        public void Write(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x96E0D90
    }

    public class PushbackStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E0F10
        public void ReadByte(){} // RVA: 0x96E0F20
        public void Read(){} // RVA: 0x96E0F60
        public void Unread(){} // RVA: 0x96E0FD0
    }

    public class StreamOverflowException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x3
    }

    public class Streams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Drain(){} // RVA: 0x96E1040
        public void ReadAll(){} // RVA: 0x96E10D0
        public void ReadAllLimited(){} // RVA: 0x96B6960
        public void ReadFully(){} // RVA: 0x96E1280 | overloaded x2
        public void PipeAll(){} // RVA: 0x96E1320
        public void PipeAllLimited(){} // RVA: 0x96E13F0
        public void WriteBufTo(){} // RVA: 0x96E1560 | overloaded x2
        public void WriteZeroes(){} // RVA: 0x96E1640
    }

    public class TeeInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E1720
        public void Close(){} // RVA: 0x96E1830
        public void Read(){} // RVA: 0x96E18D0
        public void ReadByte(){} // RVA: 0x96E1960
    }

    public class TeeOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E19D0
        public void Close(){} // RVA: 0x96E1AE0
        public void Write(){} // RVA: 0x96E1B80
        public void WriteByte(){} // RVA: 0x96E1C10
    }

}