// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.LogStates
// Classes: 3
// Methods: 34

namespace ThirdParty.Other.ZLogger.LogStates
{
    public class InterpolatedStringLogState : Object
    {
        public ZLogger.Internal.ObjectPool`1<ZLogger.LogStates.InterpolatedStringLogState> NextNode;
        public ZLogger.LogStates.InterpolatedStringLogState ParameterCount; // 0x10
        public int Version; // 0x18
        public System.ValueTuple`4<object,string,string,int> additionalInfo; // 0x20
        public byte[] magicalBoxStorage; // 0x40
        public ZLogger.InterpolatedStringParameter[] parameters; // 0x48
        public int refCount; // 0x50
        public ZLogger.MessageSequence messageSequence; // 0x58
        public ZLogger.Internal.MagicalBox magicalBox; // 0x60
        public short version; // 0x70

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
        public int <ParameterCount>k__BackingField; // 0x10
        public ZLogger.LogStates.VersionedLogState originalState; // 0x18
        public System.Exception exception; // 0x28
        public System.Func`3<ZLogger.LogStates.VersionedLogState,System.Exception,string> formatter; // 0x30
        public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<string,object>> originalStateParameters; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void CreateEntry(){} // RVA: 0x7FFD4E078F40
        public void ToString(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFD4E078F40
    }

    public class VersionedLogState : ValueType
    {
        public ZLogger.LogStates.InterpolatedStringLogState state; // 0x10
        public int version; // 0x18

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