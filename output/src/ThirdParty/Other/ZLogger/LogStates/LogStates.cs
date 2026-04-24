// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.LogStates
// Classes: 3
// Methods: 34

namespace ThirdParty.Other.ZLogger.LogStates
{
    public class InterpolatedStringLogState : Object
    {
        public object NextNode;
        public object ParameterCount;
        public object Version;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
        public void get_ParameterCount(){} // RVA: 0x7FFD4E577800
        public void set_ParameterCount(){} // RVA: 0x7FFD4ED4CD10
        public void GetEnumerator(){} // RVA: 0x7FFD5750EB40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5750EBF0
        public void get_Version(){} // RVA: 0x7FFD53F6DF10
        public void .ctor(){} // RVA: 0x7FFD5750EC00
        public void Create(){} // RVA: 0x7FFD5750ED20
        public void CreateEntry(){} // RVA: 0x7FFD5750F0B0
        public void Retain(){} // RVA: 0x7FFD5750F120
        public void Release(){} // RVA: 0x7FFD5750F130
        public void DisposeCore(){} // RVA: 0x7FFD5750F280
        public void ToString(){} // RVA: 0x7FFD5750F470 | overloaded x2
        public void GetParameterKeyAsString(){} // RVA: 0x7FFD5750F550
        public void GetParameterValue(){} // RVA: 0x7FFD5750F590
        public void GetAdditionalInfo(){} // RVA: 0x7FFD54F63010
        public void .cctor(){} // RVA: 0x7FFD5750F5F0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFD5750F6B0
    }

    public class StringFormatterLogState`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void CreateEntry(){} // RVA: 0x7FFD4E078F40
        public void ToString(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFD4E078F40
    }

    public class VersionedLogState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750F800
        public void CreateEntry(){} // RVA: 0x7FFD5750F870
        public void GetAdditionalInfo(){} // RVA: 0x7FFD5750F890
        public void Release(){} // RVA: 0x7FFD5750F8C0
        public void Retain(){} // RVA: 0x7FFD5750F8E0
        public void ToString(){} // RVA: 0x7FFD5750F900
        public void GetEnumerator(){} // RVA: 0x7FFD5750F940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5750F940
        public void ThrowIfVersionUnmatched(){} // RVA: 0x7FFD5750F970
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFD5750F870
    }

}