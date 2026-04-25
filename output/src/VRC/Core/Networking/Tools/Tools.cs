// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 51

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan : Object
    {
        public object IsLittleEndian;

        // ── Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x7FFAC3006850
        public void GetBytesInternal(){} // RVA: 0x7FFAC2E8DC40
        public void FromBytesInternal(){} // RVA: 0x7FFAC2E8DC40
        public void GetBytes(){} // RVA: 0x7FFAC9DD7E10 | overloaded x8
        public void ToBool(){} // RVA: 0x7FFAC9DD7F40
        public void ToShort(){} // RVA: 0x7FFAC9DD8050
        public void ToUShort(){} // RVA: 0x7FFAC9DD8160
        public void ToInt(){} // RVA: 0x7FFAC9DD8270
        public void ToUInt(){} // RVA: 0x7FFAC9DD8380
        public void ToLong(){} // RVA: 0x7FFAC9DD8490
        public void ToULong(){} // RVA: 0x7FFAC9DD85A0
        public void ToFloat(){} // RVA: 0x7FFAC9DD86B0
    }

    public class BunchCollection : Object
    {
        public System.Collections.Generic.Dictionary`2<int,byte[]> Hash; // 0x10
        public int IsAssembled; // 0x18
        public System.Nullable`1<uint> Count; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DD88B0 | overloaded x2
        public void AddBunch(){} // RVA: 0x7FFAC9DD8BD0
        public void get_Hash(){} // RVA: 0x7FFAC9DD8CD0
        public void ToArray(){} // RVA: 0x7FFAC9DD8D70
        public void get_IsAssembled(){} // RVA: 0x7FFAC9DD91B0
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_Bunches(){} // RVA: 0x7FFAC9DD9200
    }

    public class ByteManipulation : Object
    {
        public byte[] OneByteArray; // 0xFFFF
        public byte[] TwoByteArray; // 0xFFFF
        public byte[] FourByteArray; // 0xFFFF
        public byte[] EightByteArray; // 0xFFFF
        public Uint16ToBytes Uint16ToBytesHelper; // 0xFFFF
        public Uint32ToBytes Uint32ToBytesHelper; // 0xFFFF
        public FloatToBytes FloatToBytesHelper; // 0xFFFF
        public Uint64ToBytes Uint64ToBytesHelper; // 0xFFFF
        public float BitsToBytes;

        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7FFAC9DD96D0
        public void get_TwoByteArray(){} // RVA: 0x7FFAC9DD9810
        public void get_FourByteArray(){} // RVA: 0x7FFAC9DD9960
        public void get_EightByteArray(){} // RVA: 0x7FFAC9DD9AB0
        public void ToBytes(){} // RVA: 0x7FFAC9DDA730 | overloaded x6
        public void GetChar(){} // RVA: 0x7FFAC9DD9C40
        public void GetByte(){} // RVA: 0x7FFAC9DD9D40
        public void GetShort(){} // RVA: 0x7FFAC9DD9F50
        public void GetInt(){} // RVA: 0x7FFAC9DDA270
        public void GetFloat(){} // RVA: 0x7FFAC9DDA5D0
        public void GetLong(){} // RVA: 0x7FFAC9DDAAB0
        public void BitPack(){} // RVA: 0x7FFAC9DDAC80
        public void BitUnpack(){} // RVA: 0x7FFAC9DDADF0
    }

    public class Compress : Object
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7FFAC9DDAF90
        public void Inflate(){} // RVA: 0x7FFAC9DDB260
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x7FFAC9DDB580 | overloaded x2
        public void Fletcher32(){} // RVA: 0x7FFAC9DDB7F0 | overloaded x2
    }

}