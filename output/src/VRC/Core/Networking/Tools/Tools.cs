// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 51

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan
    {
        // ── Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x7FFAF2E72850
        public void GetBytesInternal(){} // RVA: 0x7FFAF2D33FA0
        public void FromBytesInternal(){} // RVA: 0x7FFAF2D33FA0
        public void GetBytes(){} // RVA: 0x7FFAFA0EFB70 | overloaded x8
        public void ToBool(){} // RVA: 0x7FFAFA0EFCA0
        public void ToShort(){} // RVA: 0x7FFAFA0EFDB0
        public void ToUShort(){} // RVA: 0x7FFAFA0EFEC0
        public void ToInt(){} // RVA: 0x7FFAFA0EFFD0
        public void ToUInt(){} // RVA: 0x7FFAFA0F00E0
        public void ToLong(){} // RVA: 0x7FFAFA0F01F0
        public void ToULong(){} // RVA: 0x7FFAFA0F0300
        public void ToFloat(){} // RVA: 0x7FFAFA0F0410
    }

    public class BunchCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0F0610 | overloaded x2
        public void AddBunch(){} // RVA: 0x7FFAFA0F0930
        public void get_Hash(){} // RVA: 0x7FFAFA0F0A30
        public void ToArray(){} // RVA: 0x7FFAFA0F0AD0
        public void get_IsAssembled(){} // RVA: 0x7FFAFA0F0F10
        public void get_Count(){} // RVA: 0x7FFAF306ED50
        public void get_Bunches(){} // RVA: 0x7FFAFA0F0F60
    }

    public class ByteManipulation
    {
        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7FFAFA0F1430
        public void get_TwoByteArray(){} // RVA: 0x7FFAFA0F1570
        public void get_FourByteArray(){} // RVA: 0x7FFAFA0F16C0
        public void get_EightByteArray(){} // RVA: 0x7FFAFA0F1810
        public void ToBytes(){} // RVA: 0x7FFAFA0F2490 | overloaded x6
        public void GetChar(){} // RVA: 0x7FFAFA0F19A0
        public void GetByte(){} // RVA: 0x7FFAFA0F1AA0
        public void GetShort(){} // RVA: 0x7FFAFA0F1CB0
        public void GetInt(){} // RVA: 0x7FFAFA0F1FD0
        public void GetFloat(){} // RVA: 0x7FFAFA0F2330
        public void GetLong(){} // RVA: 0x7FFAFA0F2810
        public void BitPack(){} // RVA: 0x7FFAFA0F29E0
        public void BitUnpack(){} // RVA: 0x7FFAFA0F2B50
    }

    public class Compress
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7FFAFA0F2CF0
        public void Inflate(){} // RVA: 0x7FFAFA0F2FC0
    }

    public class Hash
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x7FFAFA0F32E0 | overloaded x2
        public void Fletcher32(){} // RVA: 0x7FFAFA0F3550 | overloaded x2
    }

}