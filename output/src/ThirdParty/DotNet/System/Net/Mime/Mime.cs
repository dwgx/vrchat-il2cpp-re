// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mime
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Net.Mime
{
    public class EncodedStreamFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MailBnfHelper : Object
    {
        public object Atext;
        public object Qtext;
        public object Dtext;
        public object Ftext;
        public object Ttext;
        public object Ctext;
        public object Ascii7bitMaxValue;
        public object Quote;
        public object Space;
        public object Tab;
        public object CR;
        public object LF;
        public object StartComment;
        public object EndComment;
        public object Backslash;
        public object At;
        public object EndAngleBracket;
        public object StartAngleBracket;
        public object StartSquareBracket;
        public object EndSquareBracket;
        public object Comma;
        public object Dot;
        public object s_colonSeparator;
        public object s_months;

        // ── Methods ──
        public void CreateCharactersAllowedInAtoms(){} // RVA: 0x7616A70
        public void CreateCharactersAllowedInQuotedStrings(){} // RVA: 0x7616C20
        public void CreateCharactersAllowedInDomainLiterals(){} // RVA: 0x7616D10
        public void CreateCharactersAllowedInHeaderNames(){} // RVA: 0x7616E00
        public void CreateCharactersAllowedInTokens(){} // RVA: 0x7616E90
        public void CreateCharactersAllowedInComments(){} // RVA: 0x7616FB0
        public void IsAllowedWhiteSpace(){} // RVA: 0x76170C0
        public void .cctor(){} // RVA: 0x7617190
    }

}