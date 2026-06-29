// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 4
// Methods: 67

namespace ThirdParty.DotNet.System
{
    public class GC : Object
    {
        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x695F9D0
        public void GetMaxGeneration(){} // RVA: 0xDAC980
        public void InternalCollect(){} // RVA: 0x695F9E0
        public void RecordPressure(){} // RVA: 0xB43310
        public void register_ephemeron_array(){} // RVA: 0x695FA00
        public void get_ephemeron_tombstone(){} // RVA: 0x695FB00
        public void GetMemoryInfo(){} // RVA: 0x695FB20
        public void AddMemoryPressure(){} // RVA: 0x695FB40
        public void RemoveMemoryPressure(){} // RVA: 0x695FC00
        public void Collect(){} // RVA: 0x695FD50
        public void CollectionCount(){} // RVA: 0x695FE90
        public void KeepAlive(){} // RVA: 0xB43310
        public void get_MaxGeneration(){} // RVA: 0x695FF50
        public void _SuppressFinalize(){} // RVA: 0x695FFA0
        public void SuppressFinalize(){} // RVA: 0x6960130
        public void _ReRegisterForFinalize(){} // RVA: 0x6960320
        public void ReRegisterForFinalize(){} // RVA: 0x69604B0
        public void GetTotalMemory(){} // RVA: 0x69606A0
        public void .cctor(){} // RVA: 0x69606D0
    }

    public class Gen2GcCallback : CriticalFinalizerObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Register(){} // RVA: 0x68F68B0
        public void Setup(){} // RVA: 0x68F6970
        public void Finalize(){} // RVA: 0x68F69E0
    }

    public class Guid : ValueType
    {
        // ── Methods ──
        public void NewGuid(){} // RVA: 0x690BE60
        public void .ctor(){} // RVA: 0x8B8FD0
        public void Parse(){} // RVA: 0x690C570
        public void TryParse(){} // RVA: 0x690C6E0
        public void ParseExact(){} // RVA: 0x690C8D0
        public void TryParseExact(){} // RVA: 0x690CCB0
        public void TryParseGuid(){} // RVA: 0x690CDE0
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x690CFD0
        public void TryParseGuidWithNoStyle(){} // RVA: 0x690DA60
        public void TryParseGuidWithDashes(){} // RVA: 0x690DEE0
        public void StringToShort(){} // RVA: 0x690E2D0
        public void StringToInt(){} // RVA: 0x690E380
        public void StringToLong(){} // RVA: 0x690E520
        public void EatAllWhitespace(){} // RVA: 0x690E610
        public void IsHexPrefix(){} // RVA: 0x690E9D0
        public void WriteByteHelper(){} // RVA: 0x8B8FE0
        public void ToByteArray(){} // RVA: 0x8B9000
        public void ToString(){} // RVA: 0x8B9120
        public void GetHashCode(){} // RVA: 0x8B9060
        public void Equals(){} // RVA: 0x8B9080
        public void GetResult(){} // RVA: 0x8B90C0
        public void CompareTo(){} // RVA: 0x8B90F0
        public void op_Equality(){} // RVA: 0x690F240
        public void op_Inequality(){} // RVA: 0x690F270
        public void HexToChar(){} // RVA: 0x690F2B0
        public void HexsToChars(){} // RVA: 0x690F2D0
        public void HexsToCharsHexOutput(){} // RVA: 0x690F350
        public void TryFormat(){} // RVA: 0x8B9130
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x8B9170
    }

    public class Guid[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAFAE0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B920
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}