// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.LogStates
// Classes: 4
// Methods: 34

namespace ThirdParty.Other.ZLogger.LogStates
{
    public class InterpolatedStringLogState : ZLogger.Internal
    {
        public ZLogger.Internal.ObjectPool`1<ZLogger.LogStates.InterpolatedStringLogState> cache;
        public ZLogger.LogStates.InterpolatedStringLogState next; // 0x10
        public int <ParameterCount>k__BackingField; // 0x18

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x3DF6A30
        public void get_ParameterCount(){} // RVA: 0x5BED50
        public void set_ParameterCount(){} // RVA: 0x6374E0
        public void GetEnumerator(){} // RVA: 0x9B152A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9B15350
        public void get_Version(){} // RVA: 0x63B6B50
        public void .ctor(){} // RVA: 0x9B15360
        public void Create(){} // RVA: 0x9B15480
        public void CreateEntry(){} // RVA: 0x9B15810
        public void Retain(){} // RVA: 0x9B15880
        public void Release(){} // RVA: 0x9B15890
        public void DisposeCore(){} // RVA: 0x9B159E0
        public void ToString(){} // RVA: 0x9B15BD0 | overloaded x2
        public void GetParameterKeyAsString(){} // RVA: 0x9B15CB0
        public void GetParameterValue(){} // RVA: 0x9B15CF0
        public void GetAdditionalInfo(){} // RVA: 0x50D1DB0
        public void .cctor(){} // RVA: 0x9B15D50
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x9B15E10
    }

    public class StringFormatterLogState`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void CreateEntry(){} // RVA: 0xCE10
        public void ToString(){} // RVA: 0x24B10 | overloaded x2
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0xCE10
    }

    public class StringFormatterLogState`1
    {
    }

    public class VersionedLogState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B15F60
        public void CreateEntry(){} // RVA: 0x9B15FD0
        public void GetAdditionalInfo(){} // RVA: 0x9B15FF0
        public void Release(){} // RVA: 0x9B16020
        public void Retain(){} // RVA: 0x9B16040
        public void ToString(){} // RVA: 0x9B16060
        public void GetEnumerator(){} // RVA: 0x9B160A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9B160A0
        public void ThrowIfVersionUnmatched(){} // RVA: 0x9B160D0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x9B15FD0
    }

}