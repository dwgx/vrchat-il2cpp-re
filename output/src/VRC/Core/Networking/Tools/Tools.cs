// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 51

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan
    {
        // ── Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x3C2850
        public void GetBytesInternal(){} // RVA: 0x283FA0
        public void FromBytesInternal(){} // RVA: 0x283FA0
        public void GetBytes(){} // RVA: 0x763FB70 | overloaded x8
        public void ToBool(){} // RVA: 0x763FCA0
        public void ToShort(){} // RVA: 0x763FDB0
        public void ToUShort(){} // RVA: 0x763FEC0
        public void ToInt(){} // RVA: 0x763FFD0
        public void ToUInt(){} // RVA: 0x76400E0
        public void ToLong(){} // RVA: 0x76401F0
        public void ToULong(){} // RVA: 0x7640300
        public void ToFloat(){} // RVA: 0x7640410
    }

    public class BunchCollection
    {
        public System.Collections.Generic.Dictionary`2<int,byte[]> _bunches; // 0x10
        public int _count; // 0x18
        public System.Nullable`1<uint> _hash; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7640610 | overloaded x2
        public void AddBunch(){} // RVA: 0x7640930
        public void get_Hash(){} // RVA: 0x7640A30
        public void ToArray(){} // RVA: 0x7640AD0
        public void get_IsAssembled(){} // RVA: 0x7640F10
        public void get_Count(){} // RVA: 0x5BED50
        public void get_Bunches(){} // RVA: 0x7640F60
    }

    public class ByteManipulation
    {
        public byte[] _oneByteArray; // 0xFFFFFFFF
        public byte[] _twoByteArray; // 0xFFFFFFFF
        public byte[] _fourByteArray; // 0xFFFFFFFF
        public byte[] _eightByteArray; // 0xFFFFFFFF

        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7641430
        public void get_TwoByteArray(){} // RVA: 0x7641570
        public void get_FourByteArray(){} // RVA: 0x76416C0
        public void get_EightByteArray(){} // RVA: 0x7641810
        public void ToBytes(){} // RVA: 0x7642490 | overloaded x6
        public void GetChar(){} // RVA: 0x76419A0
        public void GetByte(){} // RVA: 0x7641AA0
        public void GetShort(){} // RVA: 0x7641CB0
        public void GetInt(){} // RVA: 0x7641FD0
        public void GetFloat(){} // RVA: 0x7642330
        public void GetLong(){} // RVA: 0x7642810
        public void BitPack(){} // RVA: 0x76429E0
        public void BitUnpack(){} // RVA: 0x7642B50
    }

    public class Compress
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7642CF0
        public void Inflate(){} // RVA: 0x7642FC0
    }

    public class Hash
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x76432E0 | overloaded x2
        public void Fletcher32(){} // RVA: 0x7643550 | overloaded x2
    }

}