// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 68

namespace ThirdParty.DotNet.System
{
    public class GC
    {
        public object HaveRegistry;

        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x5EE7AB0
        public void GetMaxGeneration(){} // RVA: 0x519240
        public void InternalCollect(){} // RVA: 0x5EE7AC0
        public void RecordPressure(){} // RVA: 0x2DD310
        public void register_ephemeron_array(){} // RVA: 0x5EE7AE0
        public void get_ephemeron_tombstone(){} // RVA: 0x5EE7BE0
        public void GetMemoryInfo(){} // RVA: 0x5EE7C00
        public void AddMemoryPressure(){} // RVA: 0x5EE7C20
        public void RemoveMemoryPressure(){} // RVA: 0x5EE7CE0
        public void Collect(){} // RVA: 0x5EE7E30 | overloaded x2
        public void CollectionCount(){} // RVA: 0x5EE7F70
        public void KeepAlive(){} // RVA: 0x2DD310
        public void get_MaxGeneration(){} // RVA: 0x5EE8030
        public void _SuppressFinalize(){} // RVA: 0x5EE8080
        public void SuppressFinalize(){} // RVA: 0x5EE81F0
        public void _ReRegisterForFinalize(){} // RVA: 0x5EE83D0
        public void ReRegisterForFinalize(){} // RVA: 0x5EE8550
        public void GetTotalMemory(){} // RVA: 0x5EE8730
        public void .cctor(){} // RVA: 0x5EE8760
    }

    public class Gen2GcCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Register(){} // RVA: 0x5E7D690
        public void Setup(){} // RVA: 0x5E7D750
        public void Finalize(){} // RVA: 0x5E7D7C0
    }

    public class Guid
    {
        // ── Methods ──
        public void NewGuid(){} // RVA: 0x5E92970
        public void .ctor(){} // RVA: 0x5E92E20 | overloaded x6
        public void Parse(){} // RVA: 0x5E93070 | overloaded x2
        public void TryParse(){} // RVA: 0x5E931E0 | overloaded x2
        public void ParseExact(){} // RVA: 0x5E933D0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x5E937C0 | overloaded x2
        public void TryParseGuid(){} // RVA: 0x5E938F0
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x5E93AE0
        public void TryParseGuidWithNoStyle(){} // RVA: 0x5E94480
        public void TryParseGuidWithDashes(){} // RVA: 0x5E94950
        public void StringToShort(){} // RVA: 0x5E94D40 | overloaded x2
        public void StringToInt(){} // RVA: 0x5E94DF0 | overloaded x2
        public void StringToLong(){} // RVA: 0x5E94F90
        public void EatAllWhitespace(){} // RVA: 0x5E95080
        public void IsHexPrefix(){} // RVA: 0x5E95360
        public void WriteByteHelper(){} // RVA: 0x5E95430
        public void ToByteArray(){} // RVA: 0x5E95550
        public void ToString(){} // RVA: 0x5E95D90 | overloaded x3
        public void GetHashCode(){} // RVA: 0x5E95660
        public void Equals(){} // RVA: 0x5E95720 | overloaded x2
        public void GetResult(){} // RVA: 0x5E95750
        public void CompareTo(){} // RVA: 0x5E95A40 | overloaded x2
        public void op_Equality(){} // RVA: 0x5E95BE0
        public void op_Inequality(){} // RVA: 0x5E95C10
        public void HexToChar(){} // RVA: 0x5E95C50
        public void HexsToChars(){} // RVA: 0x5E95C70
        public void HexsToCharsHexOutput(){} // RVA: 0x5E95CF0
        public void TryFormat(){} // RVA: 0x5E95FD0
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x5E969D0
    }

}