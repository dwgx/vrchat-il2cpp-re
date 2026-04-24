// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 51

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan : Object
    {
        // ── Original Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x7ffaa8a17850
        public void FromBytesInternal(){} // RVA: 0x7ffaa887e5c0
        public void ToBool(){} // RVA: 0x7ffaaf7fa960
        public void ToShort(){} // RVA: 0x7ffaaf7faa70
        public void ToUShort(){} // RVA: 0x7ffaaf7fab80
        public void ToInt(){} // RVA: 0x7ffaaf7fac90
        public void ToUInt(){} // RVA: 0x7ffaaf7fada0
        public void ToLong(){} // RVA: 0x7ffaaf7faeb0
        public void ToULong(){} // RVA: 0x7ffaaf7fafc0
        public void ToFloat(){} // RVA: 0x7ffaaf7fb0d0
        // ── Binary Analysis Named ──
        public void GetBytesInternal(){} // RVA: 0x7ffaa887e5c0
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
        public void GetBytes(){} // RVA: 0x7ffaaf7fa830
    }

    public class BunchCollection : Object
    {
        public object _hash; // 0x33995680

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf7fb2d0
        public void .ctor(){} // RVA: 0x7ffaaf7fb2d0
        public void AddBunch(){} // RVA: 0x7ffaaf7fb5f0
        public void get_Hash(){} // RVA: 0x7ffaaf7fb6f0
        public void ToArray(){} // RVA: 0x7ffaaf7fb790
        public void get_IsAssembled(){} // RVA: 0x7ffaaf7fbbd0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void get_Bunches(){} // RVA: 0x7ffaaf7fbc20
    }

    public class ByteManipulation : Object
    {
        public object _fourByteArray; // 0x338146C0
        public object Uint32ToBytesHelper; // 0x338146C0
        public object BitsToBytes; // 0x338146C0
        public object OneByteArray; // 0x17000341
        public object TwoByteArray; // 0x17000342
        public object FourByteArray; // 0x17000343

        // ── Original Methods ──
        public void get_OneByteArray(){} // RVA: 0x7ffaaf7fc0f0
        public void get_TwoByteArray(){} // RVA: 0x7ffaaf7fc230
        public void get_FourByteArray(){} // RVA: 0x7ffaaf7fc380
        public void get_EightByteArray(){} // RVA: 0x7ffaaf7fc4d0
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void ToBytes(){} // RVA: 0x7ffaaf7fd150
        public void BitPack(){} // RVA: 0x7ffaaf7fd6a0
        public void BitUnpack(){} // RVA: 0x7ffaaf7fd810
        // ── Binary Analysis Named ──
        public void GetChar(){} // RVA: 0x7ffaaf7fc660
        public void GetByte(){} // RVA: 0x7ffaaf7fc760
        public void GetShort(){} // RVA: 0x7ffaaf7fc970
        public void GetInt(){} // RVA: 0x7ffaaf7fcc90
        public void GetFloat(){} // RVA: 0x7ffaaf7fcff0
        public void GetLong(){} // RVA: 0x7ffaaf7fd4d0
    }

    public class Compress : Object
    {
        // ── Original Methods ──
        public void Deflate(){} // RVA: 0x7ffaaf7fd9b0
        public void Inflate(){} // RVA: 0x7ffaaf7fdc80
    }

    public class Hash : Object
    {
        // ── Original Methods ──
        public void Fletcher16(){} // RVA: 0x7ffaaf7fdfa0
        public void Fletcher16(){} // RVA: 0x7ffaaf7fdfa0
        public void Fletcher32(){} // RVA: 0x7ffaaf7fe210
        public void Fletcher32(){} // RVA: 0x7ffaaf7fe210
    }

}