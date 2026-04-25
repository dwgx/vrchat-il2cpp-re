// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Mime
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Net.Mime
{
    public class EncodedStreamFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MailBnfHelper : Object
    {
        public bool[] Atext;
        public bool[] Qtext; // 0x8
        public bool[] Dtext; // 0x10
        public bool[] Ftext; // 0x18
        public bool[] Ttext; // 0x20
        public bool[] Ctext; // 0x28
        public int Ascii7bitMaxValue; // 0x30
        public char Quote; // 0x34
        public char Space; // 0x36
        public char Tab; // 0x38
        public char CR; // 0x3A
        public char LF; // 0x3C
        public char StartComment; // 0x3E
        public char EndComment; // 0x40
        public char Backslash; // 0x42
        public char At; // 0x44
        public char EndAngleBracket; // 0x46
        public char StartAngleBracket; // 0x48
        public char StartSquareBracket; // 0x4A
        public char EndSquareBracket; // 0x4C
        public char Comma; // 0x4E
        public char Dot; // 0x50
        public char[] s_colonSeparator; // 0x58
        public string[] s_months; // 0x60

        // ── Methods ──
        public void CreateCharactersAllowedInAtoms(){} // RVA: 0x7FFAC934C5B0
        public void CreateCharactersAllowedInQuotedStrings(){} // RVA: 0x7FFAC934C760
        public void CreateCharactersAllowedInDomainLiterals(){} // RVA: 0x7FFAC934C850
        public void CreateCharactersAllowedInHeaderNames(){} // RVA: 0x7FFAC934C940
        public void CreateCharactersAllowedInTokens(){} // RVA: 0x7FFAC934C9D0
        public void CreateCharactersAllowedInComments(){} // RVA: 0x7FFAC934CAF0
        public void IsAllowedWhiteSpace(){} // RVA: 0x7FFAC934CC00
        public void .cctor(){} // RVA: 0x7FFAC934CCD0
    }

}