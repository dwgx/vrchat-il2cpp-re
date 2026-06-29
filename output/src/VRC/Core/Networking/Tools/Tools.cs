// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 36

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan : Object
    {
        // ── Methods ──
        public void FromBytesInternal(){} // RVA: 0xA94080
        public void GetBytesInternal(){} // RVA: 0x3014590
        public void get_IsLittleEndian(){} // RVA: 0xC2E4C0
        public void GetBytes(){} // RVA: 0x8279620
        public void ToBool(){} // RVA: 0x8279750
        public void ToShort(){} // RVA: 0x8279860
        public void ToUShort(){} // RVA: 0x8279970
        public void ToInt(){} // RVA: 0x8279A80
        public void ToUInt(){} // RVA: 0x8279B90
        public void ToLong(){} // RVA: 0x8279CA0
        public void ToULong(){} // RVA: 0x8279DB0
        public void ToFloat(){} // RVA: 0x8279EC0
    }

    public class BunchCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x827A0C0
        public void AddBunch(){} // RVA: 0x827A3E0
        public void get_Hash(){} // RVA: 0x827A4E0
        public void ToArray(){} // RVA: 0x827A580
        public void get_IsAssembled(){} // RVA: 0x827A9E0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Bunches(){} // RVA: 0x827AA30
    }

    public class ByteManipulation : Object
    {
        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x827AF00
        public void get_TwoByteArray(){} // RVA: 0x827B040
        public void get_FourByteArray(){} // RVA: 0x827B190
        public void get_EightByteArray(){} // RVA: 0x827B2E0
        public void ToBytes(){} // RVA: 0x827BF60
        public void GetChar(){} // RVA: 0x827B470
        public void GetByte(){} // RVA: 0x827B570
        public void GetShort(){} // RVA: 0x827B780
        public void GetInt(){} // RVA: 0x827BAA0
        public void GetFloat(){} // RVA: 0x827BE00
        public void GetLong(){} // RVA: 0x827C2E0
        public void BitPack(){} // RVA: 0x827C4B0
        public void BitUnpack(){} // RVA: 0x827C620
    }

    public class Compress : Object
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x827C7C0
        public void Inflate(){} // RVA: 0x827CAA0
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x827CDD0
        public void Fletcher32(){} // RVA: 0x827D040
    }

}