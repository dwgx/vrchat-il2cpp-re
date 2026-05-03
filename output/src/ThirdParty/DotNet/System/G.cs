// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 68

namespace ThirdParty.DotNet.System
{
    public class GC : Object
    {
        public object EPHEMERON_TOMBSTONE;

        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x7FFE86A28950
        public void GetMaxGeneration(){} // RVA: 0x7FFE813240E0
        public void InternalCollect(){} // RVA: 0x7FFE86A28960
        public void RecordPressure(){} // RVA: 0x7FFE810FB310
        public void register_ephemeron_array(){} // RVA: 0x7FFE86A28980
        public void get_ephemeron_tombstone(){} // RVA: 0x7FFE86A28A80
        public void GetMemoryInfo(){} // RVA: 0x7FFE86A28AA0
        public void AddMemoryPressure(){} // RVA: 0x7FFE86A28AC0
        public void RemoveMemoryPressure(){} // RVA: 0x7FFE86A28B80
        public void Collect(){} // RVA: 0x7FFE86A28CD0 | overloaded x2
        public void CollectionCount(){} // RVA: 0x7FFE86A28E10
        public void KeepAlive(){} // RVA: 0x7FFE810FB310
        public void get_MaxGeneration(){} // RVA: 0x7FFE86A28ED0
        public void _SuppressFinalize(){} // RVA: 0x7FFE86A28F20
        public void SuppressFinalize(){} // RVA: 0x7FFE86A29090
        public void _ReRegisterForFinalize(){} // RVA: 0x7FFE86A29270
        public void ReRegisterForFinalize(){} // RVA: 0x7FFE86A293F0
        public void GetTotalMemory(){} // RVA: 0x7FFE86A295D0
        public void .cctor(){} // RVA: 0x7FFE86A29600
    }

    public class Gen2GcCallback : CriticalFinalizerObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Register(){} // RVA: 0x7FFE869BE4D0
        public void Setup(){} // RVA: 0x7FFE869BE590
        public void Finalize(){} // RVA: 0x7FFE869BE600
    }

    public class Guid : ValueType
    {
        // ── Methods ──
        public void NewGuid(){} // RVA: 0x7FFE869D37B0
        public void .ctor(){} // RVA: 0x7FFE869D3C60 | overloaded x6
        public void Parse(){} // RVA: 0x7FFE869D3EB0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFE869D4020 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFE869D4210 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFE869D4600 | overloaded x2
        public void TryParseGuid(){} // RVA: 0x7FFE869D4730
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x7FFE869D4920
        public void TryParseGuidWithNoStyle(){} // RVA: 0x7FFE869D52C0
        public void TryParseGuidWithDashes(){} // RVA: 0x7FFE869D5790
        public void StringToShort(){} // RVA: 0x7FFE869D5B80 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFE869D5C30 | overloaded x2
        public void StringToLong(){} // RVA: 0x7FFE869D5DD0
        public void EatAllWhitespace(){} // RVA: 0x7FFE869D5EC0
        public void IsHexPrefix(){} // RVA: 0x7FFE869D61A0
        public void WriteByteHelper(){} // RVA: 0x7FFE869D6270
        public void ToByteArray(){} // RVA: 0x7FFE869D6390
        public void ToString(){} // RVA: 0x7FFE869D6BD0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE869D64A0
        public void Equals(){} // RVA: 0x7FFE869D6560 | overloaded x2
        public void GetResult(){} // RVA: 0x7FFE869D6590
        public void CompareTo(){} // RVA: 0x7FFE869D6880 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE869D6A20
        public void op_Inequality(){} // RVA: 0x7FFE869D6A50
        public void HexToChar(){} // RVA: 0x7FFE869D6A90
        public void HexsToChars(){} // RVA: 0x7FFE869D6AB0
        public void HexsToCharsHexOutput(){} // RVA: 0x7FFE869D6B30
        public void TryFormat(){} // RVA: 0x7FFE869D6E10
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x7FFE869D7810
    }

}