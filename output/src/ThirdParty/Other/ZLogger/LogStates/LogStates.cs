// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.LogStates
// Classes: 3
// Methods: 34

namespace ThirdParty.Other.ZLogger.LogStates
{
    public class InterpolatedStringLogState : Object
    {
        public ZLogger.Internal.ObjectPool`1<ZLogger.LogStates.InterpolatedStringLogState> cache;
        public ZLogger.LogStates.InterpolatedStringLogState next; // 0x10
        public int _parameterCount; // 0x18

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFE84A67100
        public void get_ParameterCount(){} // RVA: 0x7FFE813DB630
        public void set_ParameterCount(){} // RVA: 0x7FFE8144DF00
        public void GetEnumerator(){} // RVA: 0x7FFE8A554B10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A554BC0
        public void get_Version(){} // RVA: 0x7FFE86EF7580
        public void .ctor(){} // RVA: 0x7FFE8A554BD0
        public void Create(){} // RVA: 0x7FFE8A554CF0
        public void CreateEntry(){} // RVA: 0x7FFE8A555080
        public void Retain(){} // RVA: 0x7FFE8A5550F0
        public void Release(){} // RVA: 0x7FFE8A555100
        public void DisposeCore(){} // RVA: 0x7FFE8A555250
        public void ToString(){} // RVA: 0x7FFE8A555440 | overloaded x2
        public void GetParameterKeyAsString(){} // RVA: 0x7FFE8A555520
        public void GetParameterValue(){} // RVA: 0x7FFE8A555560
        public void GetAdditionalInfo(){} // RVA: 0x7FFE87EEB8B0
        public void .cctor(){} // RVA: 0x7FFE8A5555C0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFE8A555680
    }

    public class StringFormatterLogState`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void CreateEntry(){} // RVA: 0x7FFE80E2E390
        public void ToString(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFE80E2E390
    }

    public class VersionedLogState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5557D0
        public void CreateEntry(){} // RVA: 0x7FFE8A555840
        public void GetAdditionalInfo(){} // RVA: 0x7FFE8A555860
        public void Release(){} // RVA: 0x7FFE8A555890
        public void Retain(){} // RVA: 0x7FFE8A5558B0
        public void ToString(){} // RVA: 0x7FFE8A5558D0
        public void GetEnumerator(){} // RVA: 0x7FFE8A555910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A555910
        public void ThrowIfVersionUnmatched(){} // RVA: 0x7FFE8A555940
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFE8A555840
    }

}