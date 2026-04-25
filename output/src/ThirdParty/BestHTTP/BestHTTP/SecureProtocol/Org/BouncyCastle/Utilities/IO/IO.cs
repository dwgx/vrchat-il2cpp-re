// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream : Stream
    {
        public bool CanRead; // 0x28

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAC32C5AF0
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void Close(){} // RVA: 0x7FFACBCE9610
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_Length(){} // RVA: 0x7FFACBCE9620
        public void get_Position(){} // RVA: 0x7FFACBCE9660
        public void set_Position(){} // RVA: 0x7FFACBCE96A0
        public void Read(){} // RVA: 0x7FFACBCE96E0
        public void Seek(){} // RVA: 0x7FFACBCE97B0
        public void SetLength(){} // RVA: 0x7FFACBCE97F0
        public void Write(){} // RVA: 0x7FFACBCE9830
        public void .ctor(){} // RVA: 0x7FFACBCE9870
    }

    public class BaseOutputStream : Stream
    {
        public bool CanRead; // 0x28

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC32C5AF0
        public void Close(){} // RVA: 0x7FFACBCE9610
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_Length(){} // RVA: 0x7FFACBCE98C0
        public void get_Position(){} // RVA: 0x7FFACBCE9900
        public void set_Position(){} // RVA: 0x7FFACBCE9940
        public void Read(){} // RVA: 0x7FFACBCE9980
        public void Seek(){} // RVA: 0x7FFACBCE99C0
        public void SetLength(){} // RVA: 0x7FFACBCE9A00
        public void Write(){} // RVA: 0x7FFACBB590C0 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFACBCE9AC0
        public void .ctor(){} // RVA: 0x7FFACBCE9B50
    }

    public class FilterStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE9BA0
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Close(){} // RVA: 0x7FFACBCE9C40
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
        public void Read(){} // RVA: 0x7FFAC9220890
        public void ReadByte(){} // RVA: 0x7FFAC859F810
        public void Write(){} // RVA: 0x7FFAC92208F0
        public void WriteByte(){} // RVA: 0x7FFAC9220920
    }

    public class MemoryInputStream : MemoryStream
    {
        public object CanWrite;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE9CC0
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
    }

    public class MemoryOutputStream : MemoryStream
    {
        public object CanRead;

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFACBB2A930
    }

    public class NullOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0x7FFAC2F21310
        public void Write(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFACBCE9B50
    }

    public class PushbackStream : FilterStream
    {
        public int buf; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE9CD0
        public void ReadByte(){} // RVA: 0x7FFACBCE9CE0
        public void Read(){} // RVA: 0x7FFACBCE9D20
        public void Unread(){} // RVA: 0x7FFACBCE9D90
    }

    public class StreamOverflowException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x3
    }

    public class Streams : Object
    {
        public int BufferSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Drain(){} // RVA: 0x7FFACBCE9E00
        public void ReadAll(){} // RVA: 0x7FFACBCE9E90
        public void ReadAllLimited(){} // RVA: 0x7FFACBCBF720
        public void ReadFully(){} // RVA: 0x7FFACBCEA040 | overloaded x2
        public void PipeAll(){} // RVA: 0x7FFACBCEA0E0
        public void PipeAllLimited(){} // RVA: 0x7FFACBCEA1B0
        public void WriteBufTo(){} // RVA: 0x7FFACBCEA320 | overloaded x2
        public void WriteZeroes(){} // RVA: 0x7FFACBCEA400
    }

    public class TeeInputStream : BaseInputStream
    {
        public System.IO.Stream input; // 0x30
        public System.IO.Stream tee; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEA4E0
        public void Close(){} // RVA: 0x7FFACBCEA5F0
        public void Read(){} // RVA: 0x7FFACBCEA690
        public void ReadByte(){} // RVA: 0x7FFACBCEA720
    }

    public class TeeOutputStream : BaseOutputStream
    {
        public System.IO.Stream output; // 0x30
        public System.IO.Stream tee; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEA790
        public void Close(){} // RVA: 0x7FFACBCEA8A0
        public void Write(){} // RVA: 0x7FFACBCEA940
        public void WriteByte(){} // RVA: 0x7FFACBCEA9D0
    }

}