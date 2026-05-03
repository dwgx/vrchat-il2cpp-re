// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 51

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan : Object
    {
        // ── Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x7FFE811E0850
        public void GetBytesInternal(){} // RVA: 0x7FFE810A1420
        public void FromBytesInternal(){} // RVA: 0x7FFE810A1420
        public void GetBytes(){} // RVA: 0x7FFE8817CBC0 | overloaded x8
        public void ToBool(){} // RVA: 0x7FFE8817CCF0
        public void ToShort(){} // RVA: 0x7FFE8817CE00
        public void ToUShort(){} // RVA: 0x7FFE8817CF10
        public void ToInt(){} // RVA: 0x7FFE8817D020
        public void ToUInt(){} // RVA: 0x7FFE8817D130
        public void ToLong(){} // RVA: 0x7FFE8817D240
        public void ToULong(){} // RVA: 0x7FFE8817D350
        public void ToFloat(){} // RVA: 0x7FFE8817D460
    }

    public class BunchCollection : Object
    {
        public System.Collections.Generic.Dictionary`2<int,byte[]> _bunches; // 0x10
        public int _count; // 0x18
        public System.Nullable`1<uint> _hash; // 0x1C
        public object field_3; // 0x5AA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8817D660 | overloaded x2
        public void AddBunch(){} // RVA: 0x7FFE8817D980
        public void get_Hash(){} // RVA: 0x7FFE8817DA80
        public void ToArray(){} // RVA: 0x7FFE8817DB20
        public void get_IsAssembled(){} // RVA: 0x7FFE8817DF60
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_Bunches(){} // RVA: 0x7FFE8817DFB0
    }

    public class ByteManipulation : Object
    {
        public byte[] _oneByteArray; // 0xFFFF
        public byte[] _twoByteArray; // 0xFFFF
        public byte[] _fourByteArray; // 0xFFFF
        public byte[] _eightByteArray; // 0xFFFF

        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7FFE8817E480
        public void get_TwoByteArray(){} // RVA: 0x7FFE8817E5C0
        public void get_FourByteArray(){} // RVA: 0x7FFE8817E710
        public void get_EightByteArray(){} // RVA: 0x7FFE8817E860
        public void ToBytes(){} // RVA: 0x7FFE8817F4E0 | overloaded x6
        public void GetChar(){} // RVA: 0x7FFE8817E9F0
        public void GetByte(){} // RVA: 0x7FFE8817EAF0
        public void GetShort(){} // RVA: 0x7FFE8817ED00
        public void GetInt(){} // RVA: 0x7FFE8817F020
        public void GetFloat(){} // RVA: 0x7FFE8817F380
        public void GetLong(){} // RVA: 0x7FFE8817F860
        public void BitPack(){} // RVA: 0x7FFE8817FA30
        public void BitUnpack(){} // RVA: 0x7FFE8817FBA0
    }

    public class Compress : Object
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7FFE8817FD40
        public void Inflate(){} // RVA: 0x7FFE88180010
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x7FFE88180330 | overloaded x2
        public void Fletcher32(){} // RVA: 0x7FFE881805A0 | overloaded x2
    }

}