// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mail
// Classes: 7
// Methods: 26

namespace ThirdParty.DotNet.System.Net.Mail
{
    public class DomainLiteralReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7FFE876F5F90
    }

    public class DotAtomReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7FFE876F6250
    }

    public class MailAddress : Object
    {
        public System.Text.Encoding _displayNameEncoding; // 0x10
        public string _displayName; // 0x18
        public string _userName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876F82D0 | overloaded x3
        public void get_DisplayName(){} // RVA: 0x7FFE810FE7C0
        public void get_Address(){} // RVA: 0x7FFE876F86A0
        public void get_SmtpAddress(){} // RVA: 0x7FFE876F86F0
        public void ToString(){} // RVA: 0x7FFE876F8790
        public void Equals(){} // RVA: 0x7FFE876F88E0
        public void GetHashCode(){} // RVA: 0x7FFE82C46B00
        public void .cctor(){} // RVA: 0x7FFE876F89F0
    }

    public class MailAddressParser : Object
    {
        // ── Methods ──
        public void ParseAddress(){} // RVA: 0x7FFE876F6560 | overloaded x2
        public void ReadCfwsAndThrowIfIncomplete(){} // RVA: 0x7FFE876F6B10
        public void ParseDomain(){} // RVA: 0x7FFE876F6B80
        public void ParseLocalPart(){} // RVA: 0x7FFE876F6C80
        public void ParseDisplayName(){} // RVA: 0x7FFE876F7040
        public void NormalizeOrThrow(){} // RVA: 0x7FFE876F7260
    }

    public class QuotedPairReader : Object
    {
        // ── Methods ──
        public void CountQuotedChars(){} // RVA: 0x7FFE876F72F0
        public void CountBackslashes(){} // RVA: 0x7FFE876F7520
    }

    public class QuotedStringFormatReader : Object
    {
        // ── Methods ──
        public void ReadReverseQuoted(){} // RVA: 0x7FFE876F75E0
        public void ReadReverseUnQuoted(){} // RVA: 0x7FFE876F7830
        public void IsValidQtext(){} // RVA: 0x7FFE876F79E0
    }

    public class WhitespaceReader : Object
    {
        // ── Methods ──
        public void ReadFwsReverse(){} // RVA: 0x7FFE876F7AA0
        public void ReadCfwsReverse(){} // RVA: 0x7FFE876F7D20
    }

}