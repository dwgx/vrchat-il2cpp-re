// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mail
// Classes: 7
// Methods: 26

namespace ThirdParty.DotNet.System.Net.Mail
{
    public class DomainLiteralReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7FFAC934D860
    }

    public class DotAtomReader : Object
    {
        // ── Methods ──
        public void ReadReverse(){} // RVA: 0x7FFAC934DB20
    }

    public class MailAddress : Object
    {
        public System.Text.Encoding DisplayName; // 0x10
        public string Address; // 0x18
        public string SmtpAddress; // 0x20
        public string _host; // 0x28
        public System.Net.Mime.EncodedStreamFactory s_encoderFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC934FBA0 | overloaded x3
        public void get_DisplayName(){} // RVA: 0x7FFAC2F247C0
        public void get_Address(){} // RVA: 0x7FFAC934FF70
        public void get_SmtpAddress(){} // RVA: 0x7FFAC934FFC0
        public void ToString(){} // RVA: 0x7FFAC9350060
        public void Equals(){} // RVA: 0x7FFAC93501B0
        public void GetHashCode(){} // RVA: 0x7FFAC49DB960
        public void .cctor(){} // RVA: 0x7FFAC93502C0
    }

    public class MailAddressParser : Object
    {
        // ── Methods ──
        public void ParseAddress(){} // RVA: 0x7FFAC934DE30 | overloaded x2
        public void ReadCfwsAndThrowIfIncomplete(){} // RVA: 0x7FFAC934E3E0
        public void ParseDomain(){} // RVA: 0x7FFAC934E450
        public void ParseLocalPart(){} // RVA: 0x7FFAC934E550
        public void ParseDisplayName(){} // RVA: 0x7FFAC934E910
        public void NormalizeOrThrow(){} // RVA: 0x7FFAC934EB30
    }

    public class QuotedPairReader : Object
    {
        // ── Methods ──
        public void CountQuotedChars(){} // RVA: 0x7FFAC934EBC0
        public void CountBackslashes(){} // RVA: 0x7FFAC934EDF0
    }

    public class QuotedStringFormatReader : Object
    {
        // ── Methods ──
        public void ReadReverseQuoted(){} // RVA: 0x7FFAC934EEB0
        public void ReadReverseUnQuoted(){} // RVA: 0x7FFAC934F100
        public void IsValidQtext(){} // RVA: 0x7FFAC934F2B0
    }

    public class WhitespaceReader : Object
    {
        // ── Methods ──
        public void ReadFwsReverse(){} // RVA: 0x7FFAC934F370
        public void ReadCfwsReverse(){} // RVA: 0x7FFAC934F5F0
    }

}