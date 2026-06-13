// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mail
// Classes: 7
// Methods: 26

namespace ThirdParty.DotNet.System.Net.Mail
{
    public class DomainLiteralReader
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x6BB6CE0
    }

    public class DotAtomReader
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x6BB6FA0
    }

    public class MailAddress
    {
        public System.Text.Encoding _displayNameEncoding; // 0x10
        public string _displayName; // 0x18
        public string _userName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BB9020 | overloaded x3
        public void get_DisplayName(){} // RVA: 0x2E07C0
        public void get_Address(){} // RVA: 0x6BB93F0
        public void get_SmtpAddress(){} // RVA: 0x6BB9440
        public void ToString(){} // RVA: 0x6BB94E0
        public void Equals(){} // RVA: 0x6BB9630
        public void GetHashCode(){} // RVA: 0x1EBC800
        public void .cctor(){} // RVA: 0x6BB9740
    }

    public class MailAddressParser
    {
        // ── Methods ──
        public void ParseAddress(){} // RVA: 0x6BB72B0 | overloaded x2
        public void ReadCfwsAndThrowIfIncomplete(){} // RVA: 0x6BB7860
        public void ParseDomain(){} // RVA: 0x6BB78D0
        public void ParseLocalPart(){} // RVA: 0x6BB79D0
        public void ParseDisplayName(){} // RVA: 0x6BB7D90
        public void NormalizeOrThrow(){} // RVA: 0x6BB7FB0
    }

    public class QuotedPairReader
    {
        // ── Methods ──
        public void CountQuotedChars(){} // RVA: 0x6BB8040
        public void CountBackslashes(){} // RVA: 0x6BB8270
    }

    public class QuotedStringFormatReader
    {
        // ── Methods ──
        public void ReadReverseQuoted(){} // RVA: 0x6BB8330
        public void ReadReverseUnQuoted(){} // RVA: 0x6BB8580
        public void IsValidQtext(){} // RVA: 0x6BB8730
    }

    public class WhitespaceReader
    {
        // ── Methods ──
        public void ReadFwsReverse(){} // RVA: 0x6BB87F0
        public void ReadCfwsReverse(){} // RVA: 0x6BB8A70
    }

}