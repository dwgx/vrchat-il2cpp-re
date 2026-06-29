// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 4
// Methods: 67

namespace ThirdParty.DotNet.System
{
    public class GC : Object
    {
        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x7ADCD6640
        public void GetMaxGeneration(){} // RVA: 0x7A82D1450
        public void InternalCollect(){} // RVA: 0x7ADCD6650
        public void RecordPressure(){} // RVA: 0x7A80D7310
        public void register_ephemeron_array(){} // RVA: 0x7ADCD6670
        public void get_ephemeron_tombstone(){} // RVA: 0x7ADCD6770
        public void GetMemoryInfo(){} // RVA: 0x7ADCD6790
        public void AddMemoryPressure(){} // RVA: 0x7ADCD67B0
        public void RemoveMemoryPressure(){} // RVA: 0x7ADCD6870
        public void Collect(){} // RVA: 0x7ADCD69C0
        public void CollectionCount(){} // RVA: 0x7ADCD6B00
        public void KeepAlive(){} // RVA: 0x7A80D7310
        public void get_MaxGeneration(){} // RVA: 0x7ADCD6BC0
        public void _SuppressFinalize(){} // RVA: 0x7ADCD6C10
        public void SuppressFinalize(){} // RVA: 0x7ADCD6DA0
        public void _ReRegisterForFinalize(){} // RVA: 0x7ADCD6F90
        public void ReRegisterForFinalize(){} // RVA: 0x7ADCD7120
        public void GetTotalMemory(){} // RVA: 0x7ADCD7310
        public void .cctor(){} // RVA: 0x7ADCD7340
    }

    public class Gen2GcCallback : CriticalFinalizerObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Register(){} // RVA: 0x7ADC6C090
        public void Setup(){} // RVA: 0x7ADC6C150
        public void Finalize(){} // RVA: 0x7ADC6C1C0
    }

    public class Guid : ValueType
    {
        // ── Methods ──
        public void NewGuid(){} // RVA: 0x7ADC814D0
        public void .ctor(){} // RVA: 0x7A7E3B120
        public void Parse(){} // RVA: 0x7ADC81BE0
        public void TryParse(){} // RVA: 0x7ADC81D50
        public void ParseExact(){} // RVA: 0x7ADC81F40
        public void TryParseExact(){} // RVA: 0x7ADC82320
        public void TryParseGuid(){} // RVA: 0x7ADC82450
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x7ADC82640
        public void TryParseGuidWithNoStyle(){} // RVA: 0x7ADC82FC0
        public void TryParseGuidWithDashes(){} // RVA: 0x7ADC83460
        public void StringToShort(){} // RVA: 0x7ADC83850
        public void StringToInt(){} // RVA: 0x7ADC83900
        public void StringToLong(){} // RVA: 0x7ADC83AA0
        public void EatAllWhitespace(){} // RVA: 0x7ADC83B90
        public void IsHexPrefix(){} // RVA: 0x7ADC83E90
        public void WriteByteHelper(){} // RVA: 0x7A7E3B130
        public void ToByteArray(){} // RVA: 0x7A7E3B150
        public void ToString(){} // RVA: 0x7A7E3B270
        public void GetHashCode(){} // RVA: 0x7A7E3B1B0
        public void Equals(){} // RVA: 0x7A7E3B1D0
        public void GetResult(){} // RVA: 0x7A7E3B210
        public void CompareTo(){} // RVA: 0x7A7E3B240
        public void op_Equality(){} // RVA: 0x7ADC84710
        public void op_Inequality(){} // RVA: 0x7ADC84740
        public void HexToChar(){} // RVA: 0x7ADC84780
        public void HexsToChars(){} // RVA: 0x7ADC847A0
        public void HexsToCharsHexOutput(){} // RVA: 0x7ADC84820
        public void TryFormat(){} // RVA: 0x7A7E3B280
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x7A7E3B2C0
    }

    public class Guid[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D17A0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA280090
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}