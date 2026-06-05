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
        public void GetCollectionCount(){} // RVA: 0x7FFAF8997AB0
        public void GetMaxGeneration(){} // RVA: 0x7FFAF2FC9240
        public void InternalCollect(){} // RVA: 0x7FFAF8997AC0
        public void RecordPressure(){} // RVA: 0x7FFAF2D8D310
        public void register_ephemeron_array(){} // RVA: 0x7FFAF8997AE0
        public void get_ephemeron_tombstone(){} // RVA: 0x7FFAF8997BE0
        public void GetMemoryInfo(){} // RVA: 0x7FFAF8997C00
        public void AddMemoryPressure(){} // RVA: 0x7FFAF8997C20
        public void RemoveMemoryPressure(){} // RVA: 0x7FFAF8997CE0
        public void Collect(){} // RVA: 0x7FFAF8997E30 | overloaded x2
        public void CollectionCount(){} // RVA: 0x7FFAF8997F70
        public void KeepAlive(){} // RVA: 0x7FFAF2D8D310
        public void get_MaxGeneration(){} // RVA: 0x7FFAF8998030
        public void _SuppressFinalize(){} // RVA: 0x7FFAF8998080
        public void SuppressFinalize(){} // RVA: 0x7FFAF89981F0
        public void _ReRegisterForFinalize(){} // RVA: 0x7FFAF89983D0
        public void ReRegisterForFinalize(){} // RVA: 0x7FFAF8998550
        public void GetTotalMemory(){} // RVA: 0x7FFAF8998730
        public void .cctor(){} // RVA: 0x7FFAF8998760
    }

    public class Gen2GcCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Register(){} // RVA: 0x7FFAF892D690
        public void Setup(){} // RVA: 0x7FFAF892D750
        public void Finalize(){} // RVA: 0x7FFAF892D7C0
    }

    public class Guid
    {
        // ── Methods ──
        public void NewGuid(){} // RVA: 0x7FFAF8942970
        public void .ctor(){} // RVA: 0x7FFAF8942E20 | overloaded x6
        public void Parse(){} // RVA: 0x7FFAF8943070 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAF89431E0 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFAF89433D0 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAF89437C0 | overloaded x2
        public void TryParseGuid(){} // RVA: 0x7FFAF89438F0
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x7FFAF8943AE0
        public void TryParseGuidWithNoStyle(){} // RVA: 0x7FFAF8944480
        public void TryParseGuidWithDashes(){} // RVA: 0x7FFAF8944950
        public void StringToShort(){} // RVA: 0x7FFAF8944D40 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFAF8944DF0 | overloaded x2
        public void StringToLong(){} // RVA: 0x7FFAF8944F90
        public void EatAllWhitespace(){} // RVA: 0x7FFAF8945080
        public void IsHexPrefix(){} // RVA: 0x7FFAF8945360
        public void WriteByteHelper(){} // RVA: 0x7FFAF8945430
        public void ToByteArray(){} // RVA: 0x7FFAF8945550
        public void ToString(){} // RVA: 0x7FFAF8945D90 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAF8945660
        public void Equals(){} // RVA: 0x7FFAF8945720 | overloaded x2
        public void GetResult(){} // RVA: 0x7FFAF8945750
        public void CompareTo(){} // RVA: 0x7FFAF8945A40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF8945BE0
        public void op_Inequality(){} // RVA: 0x7FFAF8945C10
        public void HexToChar(){} // RVA: 0x7FFAF8945C50
        public void HexsToChars(){} // RVA: 0x7FFAF8945C70
        public void HexsToCharsHexOutput(){} // RVA: 0x7FFAF8945CF0
        public void TryFormat(){} // RVA: 0x7FFAF8945FD0
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x7FFAF89469D0
    }

}