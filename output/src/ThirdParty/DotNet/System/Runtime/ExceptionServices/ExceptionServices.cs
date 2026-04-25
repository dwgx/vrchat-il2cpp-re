// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.ExceptionServices
// Classes: 3
// Methods: 7

namespace ThirdParty.DotNet.System.Runtime.ExceptionServices
{
    public class ExceptionDispatchInfo : Object
    {
        public System.Exception BinaryStackTraceArray; // 0x10
        public object SourceException; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DB5B0
        public void get_BinaryStackTraceArray(){} // RVA: 0x7FFAC2F247C0
        public void Capture(){} // RVA: 0x7FFAC84DB7F0
        public void get_SourceException(){} // RVA: 0x7FFAC2F3C380
        public void Throw(){} // RVA: 0x7FFAC83BAA20 | overloaded x2
    }

    public class FirstChanceExceptionEventArgs : EventArgs
    {
    }

    public class HandleProcessCorruptedStateExceptionsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}