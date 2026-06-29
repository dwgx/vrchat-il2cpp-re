// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Tools
// Classes: 5
// Methods: 36

namespace VRC.Core.Networking.Tools
{
    public class BitConverterSpan : Object
    {
        // ── Methods ──
        public void get_IsLittleEndian(){} // RVA: 0x7A81BD750
        public void GetBytesInternal(){} // RVA: 0x7AA3F9490
        public void FromBytesInternal(){} // RVA: 0x7AA3F90C0
        public void GetBytes(){} // RVA: 0x7AF41E900
        public void ToBool(){} // RVA: 0x7AF41EA30
        public void ToShort(){} // RVA: 0x7AF41EB40
        public void ToUShort(){} // RVA: 0x7AF41EC50
        public void ToInt(){} // RVA: 0x7AF41ED60
        public void ToUInt(){} // RVA: 0x7AF41EE70
        public void ToLong(){} // RVA: 0x7AF41EF80
        public void ToULong(){} // RVA: 0x7AF41F090
        public void ToFloat(){} // RVA: 0x7AF41F1A0
    }

    public class BunchCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF41F3A0
        public void AddBunch(){} // RVA: 0x7AF41F6C0
        public void get_Hash(){} // RVA: 0x7AF41F7C0
        public void ToArray(){} // RVA: 0x7AF41F860
        public void get_IsAssembled(){} // RVA: 0x7AF41FCC0
        public void get_Count(){} // RVA: 0x7A83782A0
        public void get_Bunches(){} // RVA: 0x7AF41FD10
    }

    public class ByteManipulation : Object
    {
        // ── Methods ──
        public void get_OneByteArray(){} // RVA: 0x7AF4201E0
        public void get_TwoByteArray(){} // RVA: 0x7AF420320
        public void get_FourByteArray(){} // RVA: 0x7AF420470
        public void get_EightByteArray(){} // RVA: 0x7AF4205C0
        public void ToBytes(){} // RVA: 0x7AF421240
        public void GetChar(){} // RVA: 0x7AF420750
        public void GetByte(){} // RVA: 0x7AF420850
        public void GetShort(){} // RVA: 0x7AF420A60
        public void GetInt(){} // RVA: 0x7AF420D80
        public void GetFloat(){} // RVA: 0x7AF4210E0
        public void GetLong(){} // RVA: 0x7AF4215C0
        public void BitPack(){} // RVA: 0x7AF421790
        public void BitUnpack(){} // RVA: 0x7AF421900
    }

    public class Compress : Object
    {
        // ── Methods ──
        public void Deflate(){} // RVA: 0x7AF421AA0
        public void Inflate(){} // RVA: 0x7AF421D80
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Fletcher16(){} // RVA: 0x7AF4220B0
        public void Fletcher32(){} // RVA: 0x7AF422320
    }

}