// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mail
// Classes: 7
// Methods: 23

namespace ThirdParty.DotNet.System.Net.Mail
{
    public class DomainLiteralReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7AE9A5C20
    }

    public class DotAtomReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7AE9A5EE0
    }

    public class MailAddress : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9A7F20
        public void get_DisplayName(){} // RVA: 0x7A80DA7B0
        public void get_Address(){} // RVA: 0x7AE9A82F0
        public void get_SmtpAddress(){} // RVA: 0x7AE9A8340
        public void ToString(){} // RVA: 0x7AE9A83E0
        public void Equals(){} // RVA: 0x7AE9A8530
        public void GetHashCode(){} // RVA: 0x7A9CC18D0
        public void .cctor(){} // RVA: 0x7AE9A8640
    }

    public class MailAddressParser : Object
    {
        // ── Methods ──
        public void ParseAddress(){} // RVA: 0x7AE9A61E0
        public void ReadCfwsAndThrowIfIncomplete(){} // RVA: 0x7AE9A6780
        public void ParseDomain(){} // RVA: 0x7AE9A67F0
        public void ParseLocalPart(){} // RVA: 0x7AE9A68F0
        public void ParseDisplayName(){} // RVA: 0x7AE9A6C90
        public void NormalizeOrThrow(){} // RVA: 0x7AE9A6EB0
    }

    public class QuotedPairReader : Object
    {
        // ── Methods ──
        public void CountQuotedChars(){} // RVA: 0x7AE9A6F40
        public void CountBackslashes(){} // RVA: 0x7AE9A7170
    }

    public class QuotedStringFormatReader : Object
    {
        // ── Methods ──
        public void ReadReverseQuoted(){} // RVA: 0x7AE9A7230
        public void ReadReverseUnQuoted(){} // RVA: 0x7AE9A7480
        public void IsValidQtext(){} // RVA: 0x7AE9A7630
    }

    public class WhitespaceReader : Object
    {
        // ── Methods ──
        public void ReadFwsReverse(){} // RVA: 0x7AE9A76F0
        public void ReadCfwsReverse(){} // RVA: 0x7AE9A7970
    }

}