// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Formatters
// Classes: 2
// Methods: 10

namespace ThirdParty.Other.ZLogger.Formatters
{
    public class MessageTemplateFormatter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2697880
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class PlainTextZLoggerFormatter : Object
    {
        public object newLine;
        public object exceptionFormatter;
        public object prefixTemplate;
        public object prefixFormatter;
        public object suffixTemplate;
        public object suffixFormatter;

        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0xC2E4C0
        public void SetPrefixFormatter(){} // RVA: 0xA7C6F40
        public void FormatLogEntry(){} // RVA: 0x3190770
        public void DefaultExceptionLoggingFormatter(){} // RVA: 0xA7C7020
        public void WriteExceptionLoggingCore(){} // RVA: 0xA7C7280
        public void Write(){} // RVA: 0xA7C7930
        public void .ctor(){} // RVA: 0xA7C7CF0
        public void .cctor(){} // RVA: 0xA7C7E60
    }

}