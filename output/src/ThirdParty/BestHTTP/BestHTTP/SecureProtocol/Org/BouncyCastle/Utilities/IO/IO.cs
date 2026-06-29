// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 71

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream : Stream
    {
        public object closed;

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x470B600
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xB43320
        public void Close(){} // RVA: 0xA385640
        public void Flush(){} // RVA: 0xB43310
        public void get_Length(){} // RVA: 0xA385650
        public void get_Position(){} // RVA: 0xA385690
        public void set_Position(){} // RVA: 0xA3856D0
        public void Read(){} // RVA: 0xA385710
        public void Seek(){} // RVA: 0xA3857E0
        public void SetLength(){} // RVA: 0xA385820
        public void Write(){} // RVA: 0xA385860
        public void .ctor(){} // RVA: 0xA3858A0
    }

    public class BaseOutputStream : Stream
    {
        public object closed;

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x470B600
        public void Close(){} // RVA: 0xA385640
        public void Flush(){} // RVA: 0xB43310
        public void get_Length(){} // RVA: 0xA3858F0
        public void get_Position(){} // RVA: 0xA385930
        public void set_Position(){} // RVA: 0xA385970
        public void Read(){} // RVA: 0xA3859B0
        public void Seek(){} // RVA: 0xA3859F0
        public void SetLength(){} // RVA: 0xA385A30
        public void Write(){} // RVA: 0xA1F1EF0
        public void WriteByte(){} // RVA: 0xA385B00
        public void .ctor(){} // RVA: 0xA385B90
    }

    public class FilterStream : Stream
    {
        public object s;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA385BE0
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_CanWrite(){} // RVA: 0x74EEF10
        public void get_Length(){} // RVA: 0x70F93D0
        public void get_Position(){} // RVA: 0x70F9400
        public void set_Position(){} // RVA: 0x7479BC0
        public void Close(){} // RVA: 0xA385C80
        public void Flush(){} // RVA: 0x6E861D0
        public void Seek(){} // RVA: 0x74EEE80
        public void SetLength(){} // RVA: 0x70F92B0
        public void Read(){} // RVA: 0x74EEE50
        public void ReadByte(){} // RVA: 0x6881B80
        public void Write(){} // RVA: 0x74EEEB0
        public void WriteByte(){} // RVA: 0x74EEEE0
    }

    public class MemoryInputStream : MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA385D00
        public void get_CanWrite(){} // RVA: 0xB43320
    }

    public class MemoryOutputStream : MemoryStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xA1C37E0
    }

    public class NullOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0xB43310
        public void Write(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xA385B90
    }

    public class PushbackStream : FilterStream
    {
        public object buf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA385D10
        public void ReadByte(){} // RVA: 0xA385D20
        public void Read(){} // RVA: 0xA385D60
        public void Unread(){} // RVA: 0xA385DD0
    }

    public class StreamOverflowException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class Streams : Object
    {
        public object BufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Drain(){} // RVA: 0xA385E40
        public void ReadAll(){} // RVA: 0xA385ED0
        public void ReadAllLimited(){} // RVA: 0xA35AD60
        public void ReadFully(){} // RVA: 0xA386080
        public void PipeAll(){} // RVA: 0xA386120
        public void PipeAllLimited(){} // RVA: 0xA3861F0
        public void WriteBufTo(){} // RVA: 0xA386360
        public void WriteZeroes(){} // RVA: 0xA386440
    }

    public class TeeInputStream : BaseInputStream
    {
        public object input;
        public object tee;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA386520
        public void Close(){} // RVA: 0xA386630
        public void Read(){} // RVA: 0xA3866D0
        public void ReadByte(){} // RVA: 0xA386760
    }

    public class TeeOutputStream : BaseOutputStream
    {
        public object output;
        public object tee;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3867D0
        public void Close(){} // RVA: 0xA3868E0
        public void Write(){} // RVA: 0xA386980
        public void WriteByte(){} // RVA: 0xA386A10
    }

}