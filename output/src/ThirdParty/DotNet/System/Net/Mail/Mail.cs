// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mail
// Classes: 7
// Methods: 23

namespace ThirdParty.DotNet.System.Net.Mail
{
    public class DomainLiteralReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7617D40
    }

    public class DotAtomReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7617FF0
    }

    public class MailAddress : Object
    {
        public object _displayNameEncoding;
        public object _displayName;
        public object _userName;
        public object _host;
        public object s_encoderFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x761A130
        public void get_DisplayName(){} // RVA: 0xB465B0
        public void get_Address(){} // RVA: 0x761A4F0
        public void get_SmtpAddress(){} // RVA: 0x761A540
        public void ToString(){} // RVA: 0x761A5E0
        public void Equals(){} // RVA: 0x761A730
        public void GetHashCode(){} // RVA: 0x273F540
        public void .cctor(){} // RVA: 0x761A840
    }

    public class MailAddressParser : Object
    {
        // ── Methods ──
        public void ParseAddress(){} // RVA: 0x76182E0
        public void ReadCfwsAndThrowIfIncomplete(){} // RVA: 0x7618860
        public void ParseDomain(){} // RVA: 0x76188D0
        public void ParseLocalPart(){} // RVA: 0x76189D0
        public void ParseDisplayName(){} // RVA: 0x7618D70
        public void NormalizeOrThrow(){} // RVA: 0x76190F0
    }

    public class QuotedPairReader : Object
    {
        // ── Methods ──
        public void CountQuotedChars(){} // RVA: 0x7619180
        public void CountBackslashes(){} // RVA: 0x76193B0
    }

    public class QuotedStringFormatReader : Object
    {
        // ── Methods ──
        public void ReadReverseQuoted(){} // RVA: 0x7619470
        public void ReadReverseUnQuoted(){} // RVA: 0x76196B0
        public void IsValidQtext(){} // RVA: 0x7619850
    }

    public class WhitespaceReader : Object
    {
        // ── Methods ──
        public void ReadFwsReverse(){} // RVA: 0x7619910
        public void ReadCfwsReverse(){} // RVA: 0x7619B90
    }

}