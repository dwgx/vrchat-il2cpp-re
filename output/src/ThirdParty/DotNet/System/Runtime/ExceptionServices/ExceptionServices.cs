// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.ExceptionServices
// Classes: 3
// Methods: 7

namespace ThirdParty.DotNet.System.Runtime.ExceptionServices
{
    public class ExceptionDispatchInfo : Object
    {
        public System.Exception m_Exception; // 0x10
        public object m_stackTrace; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86884DE0
        public void get_BinaryStackTraceArray(){} // RVA: 0x7FFE810FE7C0
        public void Capture(){} // RVA: 0x7FFE86885020
        public void get_SourceException(){} // RVA: 0x7FFE81116380
        public void Throw(){} // RVA: 0x7FFE86764320 | overloaded x2
    }

    public class FirstChanceExceptionEventArgs : EventArgs
    {
    }

    public class HandleProcessCorruptedStateExceptionsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}