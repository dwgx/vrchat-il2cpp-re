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
        public void get_IsLittleEndian(){} // RVA: 0x7FFD4E426850
        public void GetBytesInternal(){} // RVA: 0x7FFD4E2ADC40
        public void FromBytesInternal(){} // RVA: 0x7FFD4E2ADC40
        public void GetBytes(){} // RVA: 0x7FFD551F7E10 | overloaded x8
        public void ToBool(){} // RVA: 0x7FFD551F7F40
        public void ToShort(){} // RVA: 0x7FFD551F8050
        public void ToUShort(){} // RVA: 0x7FFD551F8160
        public void ToInt(){} // RVA: 0x7FFD551F8270
        public void ToUInt(){} // RVA: 0x7FFD551F8380
        public void ToLong(){} // RVA: 0x7FFD551F8490
        public void ToULong(){} // RVA: 0x7FFD551F85A0
        public void ToFloat(){} // RVA: 0x7FFD551F86B0
    }

    public class BunchCollection : Object
    {
        public object Hash;
        public object IsAssembled;
        public object Count;
        public object Bunches;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD551F88B0 | overloaded x2
        public void AddBunch(){} // RVA: 0x7FFD551F8BD0
        public void get_Hash(){} // RVA: 0x7FFD551F8CD0
        public void ToArray(){} // RVA: 0x7FFD551F8D70
        public void get_IsAssembled(){} // RVA: 0x7FFD551F91B0
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void get_Bunches(){} // RVA: 0x7FFD551F9200
    }

    public class ByteManipulation : Object
    {
        public object OneByteArray;
        public object TwoByteArray;
        public object FourByteArray;
        public object EightByteArray;

        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7FFD551F96D0
        public void get_TwoByteArray(){} // RVA: 0x7FFD551F9810
        public void get_FourByteArray(){} // RVA: 0x7FFD551F9960
        public void get_EightByteArray(){} // RVA: 0x7FFD551F9AB0
        public void ToBytes(){} // RVA: 0x7FFD551FA730 | overloaded x6
        public void GetChar(){} // RVA: 0x7FFD551F9C40
        public void GetByte(){} // RVA: 0x7FFD551F9D40
        public void GetShort(){} // RVA: 0x7FFD551F9F50
        public void GetInt(){} // RVA: 0x7FFD551FA270
        public void GetFloat(){} // RVA: 0x7FFD551FA5D0
        public void GetLong(){} // RVA: 0x7FFD551FAAB0
        public void BitPack(){} // RVA: 0x7FFD551FAC80
        public void BitUnpack(){} // RVA: 0x7FFD551FADF0
    }

    public class Compress : Object
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7FFD551FAF90
        public void Inflate(){} // RVA: 0x7FFD551FB260
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x7FFD551FB580 | overloaded x2
        public void Fletcher32(){} // RVA: 0x7FFD551FB7F0 | overloaded x2
    }

}