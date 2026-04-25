// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 68

namespace ThirdParty.DotNet.System
{
    public class GC : Object
    {
        public object MaxGeneration;

        // ── Methods ──
        public void GetCollectionCount(){} // RVA: 0x7FFAC867F160
        public void GetMaxGeneration(){} // RVA: 0x7FFAC34F9180
        public void InternalCollect(){} // RVA: 0x7FFAC867F170
        public void RecordPressure(){} // RVA: 0x7FFAC2F21310
        public void register_ephemeron_array(){} // RVA: 0x7FFAC867F190
        public void get_ephemeron_tombstone(){} // RVA: 0x7FFAC867F290
        public void GetMemoryInfo(){} // RVA: 0x7FFAC867F2B0
        public void AddMemoryPressure(){} // RVA: 0x7FFAC867F2D0
        public void RemoveMemoryPressure(){} // RVA: 0x7FFAC867F390
        public void Collect(){} // RVA: 0x7FFAC867F4E0 | overloaded x2
        public void CollectionCount(){} // RVA: 0x7FFAC867F620
        public void KeepAlive(){} // RVA: 0x7FFAC2F21310
        public void get_MaxGeneration(){} // RVA: 0x7FFAC867F6E0
        public void _SuppressFinalize(){} // RVA: 0x7FFAC867F730
        public void SuppressFinalize(){} // RVA: 0x7FFAC867F8A0
        public void _ReRegisterForFinalize(){} // RVA: 0x7FFAC867FA80
        public void ReRegisterForFinalize(){} // RVA: 0x7FFAC867FC00
        public void GetTotalMemory(){} // RVA: 0x7FFAC867FDE0
        public void .cctor(){} // RVA: 0x7FFAC867FE10
    }

    public class Gen2GcCallback : CriticalFinalizerObject
    {
        public System.Func`2<object,bool> _callback; // 0x10
        public System.Runtime.InteropServices.GCHandle _weakTargetObj; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Register(){} // RVA: 0x7FFAC8614D00
        public void Setup(){} // RVA: 0x7FFAC8614DC0
        public void Finalize(){} // RVA: 0x7FFAC8614E30
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
        public void NewGuid(){} // RVA: 0x7FFAC8629FE0
        public void .ctor(){} // RVA: 0x7FFAC862A490 | overloaded x6
        public void Parse(){} // RVA: 0x7FFAC862A6E0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAC862A850 | overloaded x2
        public void ParseExact(){} // RVA: 0x7FFAC862AA40 | overloaded x2
        public void TryParseExact(){} // RVA: 0x7FFAC862AE30 | overloaded x2
        public void TryParseGuid(){} // RVA: 0x7FFAC862AF60
        public void TryParseGuidWithHexPrefix(){} // RVA: 0x7FFAC862B150
        public void TryParseGuidWithNoStyle(){} // RVA: 0x7FFAC862BAF0
        public void TryParseGuidWithDashes(){} // RVA: 0x7FFAC862BFC0
        public void StringToShort(){} // RVA: 0x7FFAC862C3B0 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFAC862C460 | overloaded x2
        public void StringToLong(){} // RVA: 0x7FFAC862C600
        public void EatAllWhitespace(){} // RVA: 0x7FFAC862C6F0
        public void IsHexPrefix(){} // RVA: 0x7FFAC862C9D0
        public void WriteByteHelper(){} // RVA: 0x7FFAC862CAA0
        public void ToByteArray(){} // RVA: 0x7FFAC862CBC0
        public void ToString(){} // RVA: 0x7FFAC862D400 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC862CCD0
        public void Equals(){} // RVA: 0x7FFAC862CD90 | overloaded x2
        public void GetResult(){} // RVA: 0x7FFAC862CDC0
        public void CompareTo(){} // RVA: 0x7FFAC862D0B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC862D250
        public void op_Inequality(){} // RVA: 0x7FFAC862D280
        public void HexToChar(){} // RVA: 0x7FFAC862D2C0
        public void HexsToChars(){} // RVA: 0x7FFAC862D2E0
        public void HexsToCharsHexOutput(){} // RVA: 0x7FFAC862D360
        public void TryFormat(){} // RVA: 0x7FFAC862D640
        public void System.ISpanFormattable.TryFormat(){} // RVA: 0x7FFAC862E040
    }

}