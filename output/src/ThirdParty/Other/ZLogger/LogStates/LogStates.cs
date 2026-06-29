// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.LogStates
// Classes: 4
// Methods: 34

namespace ThirdParty.Other.ZLogger.LogStates
{
    public class InterpolatedStringLogState : Object
    {
        public object cache;
        public object next;
        public object _parameterCount;
        public object additionalInfo;
        public object magicalBoxStorage;
        public object parameters;
        public object refCount;
        public object messageSequence;
        public object magicalBox;
        public object version;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x4865E00
        public void get_ParameterCount(){} // RVA: 0xE62D00
        public void set_ParameterCount(){} // RVA: 0x1033F40
        public void GetEnumerator(){} // RVA: 0xA7C36C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA7C3770
        public void get_Version(){} // RVA: 0x6E24BA0
        public void .ctor(){} // RVA: 0xA7C3780
        public void Create(){} // RVA: 0xA7C38A0
        public void CreateEntry(){} // RVA: 0xA7C3C30
        public void Retain(){} // RVA: 0xA7C3CA0
        public void Release(){} // RVA: 0xA7C3CB0
        public void DisposeCore(){} // RVA: 0xA7C3E00
        public void ToString(){} // RVA: 0xA7C3FF0
        public void GetParameterKeyAsString(){} // RVA: 0xA7C40D0
        public void GetParameterValue(){} // RVA: 0xA7C4110
        public void GetAdditionalInfo(){} // RVA: 0x5BDB670
        public void .cctor(){} // RVA: 0xA7C4170
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0xA7C4230
    }

    public class StringFormatterLogState`1 : ValueType
    {
        public object _parameterCount;
        public object originalState;
        public object exception;
        public object formatter;
        public object originalStateParameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void CreateEntry(){} // RVA: 0x87C540
        public void ToString(){} // RVA: 0x894320
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x87C540
    }

    public class StringFormatterLogState`1 : ValueType
    {
        public object _parameterCount;
        public object originalState;
        public object exception;
        public object formatter;
        public object originalStateParameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A30A0
        public void CreateEntry(){} // RVA: 0x4A30D0
    }

    public class VersionedLogState : ValueType
    {
        public object state;
        public object version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7B8F0
        public void CreateEntry(){} // RVA: 0xA7B960
        public void GetAdditionalInfo(){} // RVA: 0xA7B980
        public void Release(){} // RVA: 0xA7B9B0
        public void Retain(){} // RVA: 0xA7B9D0
        public void ToString(){} // RVA: 0xA7B9F0
        public void GetEnumerator(){} // RVA: 0xA7BA30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA7BA30
        public void ThrowIfVersionUnmatched(){} // RVA: 0xA7BA60
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0xA7B960
    }

}