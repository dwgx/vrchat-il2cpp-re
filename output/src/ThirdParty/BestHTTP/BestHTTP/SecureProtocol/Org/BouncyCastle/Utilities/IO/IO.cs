// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAF6735330
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void Close(){} // RVA: 0x7FFAFC190850
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void get_Length(){} // RVA: 0x7FFAFC190860
        public void get_Position(){} // RVA: 0x7FFAFC1908A0
        public void set_Position(){} // RVA: 0x7FFAFC1908E0
        public void Read(){} // RVA: 0x7FFAFC190920
        public void Seek(){} // RVA: 0x7FFAFC1909F0
        public void SetLength(){} // RVA: 0x7FFAFC190A30
        public void Write(){} // RVA: 0x7FFAFC190A70
        public void .ctor(){} // RVA: 0x7FFAFC190AB0
    }

    public class BaseOutputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF6735330
        public void Close(){} // RVA: 0x7FFAFC190850
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void get_Length(){} // RVA: 0x7FFAFC190B00
        public void get_Position(){} // RVA: 0x7FFAFC190B40
        public void set_Position(){} // RVA: 0x7FFAFC190B80
        public void Read(){} // RVA: 0x7FFAFC190BC0
        public void Seek(){} // RVA: 0x7FFAFC190C00
        public void SetLength(){} // RVA: 0x7FFAFC190C40
        public void Write(){} // RVA: 0x7FFAFC000310 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAFC190D00
        public void .ctor(){} // RVA: 0x7FFAFC190D90
    }

    public class FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC190DE0
        public void get_CanRead(){} // RVA: 0x7FFAF8EC5140
        public void get_CanSeek(){} // RVA: 0x7FFAF8EC5170
        public void get_CanWrite(){} // RVA: 0x7FFAF9539DD0
        public void get_Length(){} // RVA: 0x7FFAF913EC70
        public void get_Position(){} // RVA: 0x7FFAF913ECA0
        public void set_Position(){} // RVA: 0x7FFAF94C42C0
        public void Close(){} // RVA: 0x7FFAFC190E80
        public void Flush(){} // RVA: 0x7FFAF8EC5940
        public void Seek(){} // RVA: 0x7FFAF9539D40
        public void SetLength(){} // RVA: 0x7FFAF913EB50
        public void Read(){} // RVA: 0x7FFAF9539D10
        public void ReadByte(){} // RVA: 0x7FFAF88B81B0
        public void Write(){} // RVA: 0x7FFAF9539D70
        public void WriteByte(){} // RVA: 0x7FFAF9539DA0
    }

    public class MemoryInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC190F00
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
    }

    public class MemoryOutputStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAFBFD1B80
    }

    public class NullOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0x7FFAF2D8D310
        public void Write(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAFC190D90
    }

    public class PushbackStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC190F10
        public void ReadByte(){} // RVA: 0x7FFAFC190F20
        public void Read(){} // RVA: 0x7FFAFC190F60
        public void Unread(){} // RVA: 0x7FFAFC190FD0
    }

    public class StreamOverflowException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D54B0 | overloaded x3
    }

    public class Streams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Drain(){} // RVA: 0x7FFAFC191040
        public void ReadAll(){} // RVA: 0x7FFAFC1910D0
        public void ReadAllLimited(){} // RVA: 0x7FFAFC166960
        public void ReadFully(){} // RVA: 0x7FFAFC191280 | overloaded x2
        public void PipeAll(){} // RVA: 0x7FFAFC191320
        public void PipeAllLimited(){} // RVA: 0x7FFAFC1913F0
        public void WriteBufTo(){} // RVA: 0x7FFAFC191560 | overloaded x2
        public void WriteZeroes(){} // RVA: 0x7FFAFC191640
    }

    public class TeeInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC191720
        public void Close(){} // RVA: 0x7FFAFC191830
        public void Read(){} // RVA: 0x7FFAFC1918D0
        public void ReadByte(){} // RVA: 0x7FFAFC191960
    }

    public class TeeOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1919D0
        public void Close(){} // RVA: 0x7FFAFC191AE0
        public void Write(){} // RVA: 0x7FFAFC191B80
        public void WriteByte(){} // RVA: 0x7FFAFC191C10
    }

}