// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Formatters
// Classes: 2
// Methods: 12

namespace ThirdParty.Other.ZLogger.Formatters
{
    public class MessageTemplateFormatter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4935D20
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class PlainTextZLoggerFormatter : Object
    {
        public byte[] WithLineBreak;
        public System.Action`2<System.Buffers.IBufferWriter`1<byte>,System.Exception> exceptionFormatter; // 0x10
        public ZLogger.MessageTemplateHolder prefixTemplate; // 0x18
        public ZLogger.Formatters.MessageTemplateFormatter prefixFormatter; // 0x20
        public ZLogger.MessageTemplateHolder suffixTemplate; // 0x28
        public ZLogger.Formatters.MessageTemplateFormatter suffixFormatter; // 0x30

        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7FFAC3006850
        public void SetPrefixFormatter(){} // RVA: 0x7FFACC0F23D0
        public void FormatLogEntry(){} // RVA: 0x7FFAC2E8DC40
        public void DefaultExceptionLoggingFormatter(){} // RVA: 0x7FFACC0F24B0
        public void WriteExceptionLoggingCore(){} // RVA: 0x7FFACC0F2710
        public void Write(){} // RVA: 0x7FFACC0F2DC0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFACC0F3180
        public void .cctor(){} // RVA: 0x7FFACC0F32F0
    }

}