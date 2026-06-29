// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 71

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream : Stream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7ABA76B70
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void Close(){} // RVA: 0x7B151A2D0
        public void Flush(){} // RVA: 0x7A80D7310
        public void get_Length(){} // RVA: 0x7B151A2E0
        public void get_Position(){} // RVA: 0x7B151A320
        public void set_Position(){} // RVA: 0x7B151A360
        public void Read(){} // RVA: 0x7B151A3A0
        public void Seek(){} // RVA: 0x7B151A470
        public void SetLength(){} // RVA: 0x7B151A4B0
        public void Write(){} // RVA: 0x7B151A4F0
        public void .ctor(){} // RVA: 0x7B151A530
    }

    public class BaseOutputStream : Stream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7ABA76B70
        public void Close(){} // RVA: 0x7B151A2D0
        public void Flush(){} // RVA: 0x7A80D7310
        public void get_Length(){} // RVA: 0x7B151A580
        public void get_Position(){} // RVA: 0x7B151A5C0
        public void set_Position(){} // RVA: 0x7B151A600
        public void Read(){} // RVA: 0x7B151A640
        public void Seek(){} // RVA: 0x7B151A680
        public void SetLength(){} // RVA: 0x7B151A6C0
        public void Write(){} // RVA: 0x7B1386750
        public void WriteByte(){} // RVA: 0x7B151A790
        public void .ctor(){} // RVA: 0x7B151A820
    }

    public class FilterStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151A870
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_CanWrite(){} // RVA: 0x7AE87A550
        public void get_Length(){} // RVA: 0x7AE47D2E0
        public void get_Position(){} // RVA: 0x7AE47D310
        public void set_Position(){} // RVA: 0x7AE804490
        public void Close(){} // RVA: 0x7B151A910
        public void Flush(){} // RVA: 0x7AE203670
        public void Seek(){} // RVA: 0x7AE87A4C0
        public void SetLength(){} // RVA: 0x7AE47D1C0
        public void Read(){} // RVA: 0x7AE87A490
        public void ReadByte(){} // RVA: 0x7ADBF6950
        public void Write(){} // RVA: 0x7AE87A4F0
        public void WriteByte(){} // RVA: 0x7AE87A520
    }

    public class MemoryInputStream : MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151A990
        public void get_CanWrite(){} // RVA: 0x7A80D7320
    }

    public class MemoryOutputStream : MemoryStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7B1357E90
    }

    public class NullOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0x7A80D7310
        public void Write(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7B151A820
    }

    public class PushbackStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151A9A0
        public void ReadByte(){} // RVA: 0x7B151A9B0
        public void Read(){} // RVA: 0x7B151A9F0
        public void Unread(){} // RVA: 0x7B151AA60
    }

    public class StreamOverflowException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class Streams : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Drain(){} // RVA: 0x7B151AAD0
        public void ReadAll(){} // RVA: 0x7B151AB60
        public void ReadAllLimited(){} // RVA: 0x7B14EF960
        public void ReadFully(){} // RVA: 0x7B151AD10
        public void PipeAll(){} // RVA: 0x7B151ADB0
        public void PipeAllLimited(){} // RVA: 0x7B151AE80
        public void WriteBufTo(){} // RVA: 0x7B151AFF0
        public void WriteZeroes(){} // RVA: 0x7B151B0D0
    }

    public class TeeInputStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151B1B0
        public void Close(){} // RVA: 0x7B151B2C0
        public void Read(){} // RVA: 0x7B151B360
        public void ReadByte(){} // RVA: 0x7B151B3F0
    }

    public class TeeOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151B460
        public void Close(){} // RVA: 0x7B151B570
        public void Write(){} // RVA: 0x7B151B610
        public void WriteByte(){} // RVA: 0x7B151B6A0
    }

}