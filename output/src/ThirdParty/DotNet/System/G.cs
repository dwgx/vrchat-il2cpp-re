// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 2
// Methods: 64

namespace ThirdParty.DotNet.System
{
    public class GC : Object
    {
        public object MaxGeneration;

        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x7FFD53A9F160
        public void GetMaxGeneration(){} // RVA: 0x7FFD4E919180
        public void InternalCollect(){} // RVA: 0x7FFD53A9F170
        public void RecordPressure(){} // RVA: 0x7FFD4E341310
        public void register_ephemeron_array(){} // RVA: 0x7FFD53A9F190
        public void get_ephemeron_tombstone(){} // RVA: 0x7FFD53A9F290
        public void GetMemoryInfo(){} // RVA: 0x7FFD53A9F2B0
        public void AddMemoryPressure(){} // RVA: 0x7FFD53A9F2D0
        public void RemoveMemoryPressure(){} // RVA: 0x7FFD53A9F390
        public void Collect(){} // RVA: 0x7FFD53A9F4E0 | overloaded x2
        public void CollectionCount(){} // RVA: 0x7FFD53A9F620
        public void KeepAlive(){} // RVA: 0x7FFD4E341310
        public void get_MaxGeneration(){} // RVA: 0x7FFD53A9F6E0
        public void _SuppressFinalize(){} // RVA: 0x7FFD53A9F730
        public void SuppressFinalize(){} // RVA: 0x7FFD53A9F8A0
        public void _ReRegisterForFinalize(){} // RVA: 0x7FFD53A9FA80
        public void ReRegisterForFinalize(){} // RVA: 0x7FFD53A9FC00
        public void GetTotalMemory(){} // RVA: 0x7FFD53A9FDE0
        public void .cctor(){} // RVA: 0x7FFD53A9FE10
    }

    public class Guid : ValueType
    {
        public System.Guid Empty;
        public int _a; // 0x10
        public short _b; // 0x14
        public short _c; // 0x16
        public byte _d; // 0x18
        public byte _e; // 0x19
        public byte _f; // 0x1A
        public byte _g; // 0x1B
        public byte _h; // 0x1C
        public byte _i; // 0x1D
        public byte _j; // 0x1E
        public byte _k; // 0x1F

        // ── Methods ──
        public void NewGuid(){} // RVA: 0x7FFD53A49FE0
        public void .ctor(){} // RVA: 0x7FFD53A4A490 | overloaded x6
        public void Parse(){} // RVA: 0x7FFD53A4A6E0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFD53A4A850 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFD53A4AA40 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFD53A4AE30 | overloaded x2
        public void TryParseGuid(){} // RVA: 0x7FFD53A4AF60
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x7FFD53A4B150
        public void TryParseGuidWithNoStyle(){} // RVA: 0x7FFD53A4BAF0
        public void TryParseGuidWithDashes(){} // RVA: 0x7FFD53A4BFC0
        public void StringToShort(){} // RVA: 0x7FFD53A4C3B0 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFD53A4C460 | overloaded x2
        public void StringToLong(){} // RVA: 0x7FFD53A4C600
        public void EatAllWhitespace(){} // RVA: 0x7FFD53A4C6F0
        public void IsHexPrefix(){} // RVA: 0x7FFD53A4C9D0
        public void WriteByteHelper(){} // RVA: 0x7FFD53A4CAA0
        public void ToByteArray(){} // RVA: 0x7FFD53A4CBC0
        public void ToString(){} // RVA: 0x7FFD53A4D400 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD53A4CCD0
        public void Equals(){} // RVA: 0x7FFD53A4CD90 | overloaded x2
        public void GetResult(){} // RVA: 0x7FFD53A4CDC0
        public void CompareTo(){} // RVA: 0x7FFD53A4D0B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD53A4D250
        public void op_Inequality(){} // RVA: 0x7FFD53A4D280
        public void HexToChar(){} // RVA: 0x7FFD53A4D2C0
        public void HexsToChars(){} // RVA: 0x7FFD53A4D2E0
        public void HexsToCharsHexOutput(){} // RVA: 0x7FFD53A4D360
        public void TryFormat(){} // RVA: 0x7FFD53A4D640
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x7FFD53A4E040
    }

}