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
        public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
        public void get_ParameterCount(){} // RVA: 0x7FFAC3157800
        public void set_ParameterCount(){} // RVA: 0x7FFAC392CD10
        public void GetEnumerator(){} // RVA: 0x7FFACC0EEB40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC0EEBF0
        public void get_Version(){} // RVA: 0x7FFAC8B4DF10
        public void .ctor(){} // RVA: 0x7FFACC0EEC00
        public void Create(){} // RVA: 0x7FFACC0EED20
        public void CreateEntry(){} // RVA: 0x7FFACC0EF0B0
        public void Retain(){} // RVA: 0x7FFACC0EF120
        public void Release(){} // RVA: 0x7FFACC0EF130
        public void DisposeCore(){} // RVA: 0x7FFACC0EF280
        public void ToString(){} // RVA: 0x7FFACC0EF470 | overloaded x2
        public void GetParameterKeyAsString(){} // RVA: 0x7FFACC0EF550
        public void GetParameterValue(){} // RVA: 0x7FFACC0EF590
        public void GetAdditionalInfo(){} // RVA: 0x7FFAC9B43010
        public void .cctor(){} // RVA: 0x7FFACC0EF5F0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFACC0EF6B0
    }

    public class StringFormatterLogState`1 : ValueType
    {
        public int <ParameterCount>k__BackingField;
        public T originalState;
        public System.Exception exception;
        public System.Func`3<T,System.Exception,string> formatter;
        public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<string,object>> originalStateParameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void CreateEntry(){} // RVA: 0x7FFAC2C58F40
        public void ToString(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFAC2C58F40
    }

    public class VersionedLogState : ValueType
    {
        public ZLogger.LogStates.InterpolatedStringLogState state; // 0x10
        public int version; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0EF800
        public void CreateEntry(){} // RVA: 0x7FFACC0EF870
        public void GetAdditionalInfo(){} // RVA: 0x7FFACC0EF890
        public void Release(){} // RVA: 0x7FFACC0EF8C0
        public void Retain(){} // RVA: 0x7FFACC0EF8E0
        public void ToString(){} // RVA: 0x7FFACC0EF900
        public void GetEnumerator(){} // RVA: 0x7FFACC0EF940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC0EF940
        public void ThrowIfVersionUnmatched(){} // RVA: 0x7FFACC0EF970
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFACC0EF870
    }

}