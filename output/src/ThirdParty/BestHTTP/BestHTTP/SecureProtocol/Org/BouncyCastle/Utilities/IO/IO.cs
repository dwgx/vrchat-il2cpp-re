// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
// Classes: 11
// Methods: 76

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
    public class BaseInputStream : Stream
    {
        public bool closed; // 0x28
        public object field_1; // 0xFA
        public object field_2; // 0xFB
        public object field_3; // 0xFC
        public object field_4; // 0xFD

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFE815217E0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void Close(){} // RVA: 0x7FFE8A142C30
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_Length(){} // RVA: 0x7FFE8A142C40
        public void get_Position(){} // RVA: 0x7FFE8A142C80
        public void set_Position(){} // RVA: 0x7FFE8A142CC0
        public void Read(){} // RVA: 0x7FFE8A142D00
        public void Seek(){} // RVA: 0x7FFE8A142DD0
        public void SetLength(){} // RVA: 0x7FFE8A142E10
        public void Write(){} // RVA: 0x7FFE8A142E50
        public void .ctor(){} // RVA: 0x7FFE8A142E90
    }

    public class BaseOutputStream : Stream
    {
        public bool closed; // 0x28
        public object field_1; // 0xFF
        public object field_2; // 0x100
        public object field_3; // 0x101
        public object field_4; // 0x102

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE815217E0
        public void Close(){} // RVA: 0x7FFE8A142C30
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_Length(){} // RVA: 0x7FFE8A142EE0
        public void get_Position(){} // RVA: 0x7FFE8A142F20
        public void set_Position(){} // RVA: 0x7FFE8A142F60
        public void Read(){} // RVA: 0x7FFE8A142FA0
        public void Seek(){} // RVA: 0x7FFE8A142FE0
        public void SetLength(){} // RVA: 0x7FFE8A143020
        public void Write(){} // RVA: 0x7FFE89FB26E0 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE8A1430E0
        public void .ctor(){} // RVA: 0x7FFE8A143170
    }

    public class FilterStream : Stream
    {
        public System.IO.Stream s; // 0x28
        public object field_1; // 0x104
        public object field_2; // 0x105
        public object field_3; // 0x106
        public object field_4; // 0x107

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1431C0
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_CanWrite(){} // RVA: 0x7FFE875C90C0
        public void get_Length(){} // RVA: 0x7FFE871CDB60
        public void get_Position(){} // RVA: 0x7FFE871CDB90
        public void set_Position(){} // RVA: 0x7FFE875535C0
        public void Close(){} // RVA: 0x7FFE8A143260
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void Seek(){} // RVA: 0x7FFE875C9030
        public void SetLength(){} // RVA: 0x7FFE871CDA40
        public void Read(){} // RVA: 0x7FFE875C9000
        public void ReadByte(){} // RVA: 0x7FFE86948FF0
        public void Write(){} // RVA: 0x7FFE875C9060
        public void WriteByte(){} // RVA: 0x7FFE875C9090
    }

    public class MemoryInputStream : MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1432E0
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
    }

    public class MemoryOutputStream : MemoryStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE89F83F50
    }

    public class NullOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void WriteByte(){} // RVA: 0x7FFE810FB310
        public void Write(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8A143170
    }

    public class PushbackStream : FilterStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1432F0
        public void ReadByte(){} // RVA: 0x7FFE8A143300
        public void Read(){} // RVA: 0x7FFE8A143340
        public void Unread(){} // RVA: 0x7FFE8A1433B0
    }

    public class StreamOverflowException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x3
    }

    public class Streams : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Drain(){} // RVA: 0x7FFE8A143420
        public void ReadAll(){} // RVA: 0x7FFE8A1434B0
        public void ReadAllLimited(){} // RVA: 0x7FFE8A118D40
        public void ReadFully(){} // RVA: 0x7FFE8A143660 | overloaded x2
        public void PipeAll(){} // RVA: 0x7FFE8A143700
        public void PipeAllLimited(){} // RVA: 0x7FFE8A1437D0
        public void WriteBufTo(){} // RVA: 0x7FFE8A143940 | overloaded x2
        public void WriteZeroes(){} // RVA: 0x7FFE8A143A20
    }

    public class TeeInputStream : BaseInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A143B00
        public void Close(){} // RVA: 0x7FFE8A143C10
        public void Read(){} // RVA: 0x7FFE8A143CB0
        public void ReadByte(){} // RVA: 0x7FFE8A143D40
    }

    public class TeeOutputStream : BaseOutputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A143DB0
        public void Close(){} // RVA: 0x7FFE8A143EC0
        public void Write(){} // RVA: 0x7FFE8A143F60
        public void WriteByte(){} // RVA: 0x7FFE8A143FF0
    }

}