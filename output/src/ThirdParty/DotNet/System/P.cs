// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 4
// Methods: 13

namespace ThirdParty.DotNet.System
{
    public class ParamsArray : ValueType
    {
        public object[] Length;
        public object[] Item; // 0x8
        public object[] s_threeArgArray; // 0x10
        public object _arg0; // 0x10
        public object _arg1; // 0x18
        public object _arg2; // 0x20
        public object[] _args; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A656E0 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFD510E4BA0
        public void get_Item(){} // RVA: 0x7FFD53A658B0
        public void GetAtSlow(){} // RVA: 0x7FFD53A65960
        public void .cctor(){} // RVA: 0x7FFD53A659B0
    }

    public class Pinnable`1 : Object
    {
        public T1717725648 Data;
    }

    public class Predicate`1 : MulticastDelegate
    {
    }

    public class Progress`1 : Object
    {
        public sageKind.ironmentVariable_native _synchronizationContext;
        public ileFullDirectoryInformation<T1717584336> _handler;
        public sageKind.st _invokeHandlers;
        public tTable<T1717584336> ProgressChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void OnReport(){} // RVA: 0x7FFD4E2ADC40
        public void System.IProgress<T>.Report(){} // RVA: 0x7FFD4E2ADC40
        public void InvokeHandlers(){} // RVA: 0x7FFD4E090A40
    }

}