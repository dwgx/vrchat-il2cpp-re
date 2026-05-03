// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
// Classes: 3
// Methods: 21

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
{
    public class NameOrPseudonym : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString pseudonym; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString surname; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B1360
        public void .ctor(){} // RVA: 0x7FFE86F49820 | overloaded x4
        public void get_Pseudonym(){} // RVA: 0x7FFE81116380
        public void get_Surname(){} // RVA: 0x7FFE810FE7C0
        public void GetGivenName(){} // RVA: 0x7FFE8A1B1910
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B1C10
    }

    public class PersonalData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym nameOrPseudonym; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger nameDistinguisher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime dateOfBirth; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString placeOfBirth; // 0x28
        public string gender; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString postalAddress; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B1D60
        public void .ctor(){} // RVA: 0x7FFE8A1B22C0 | overloaded x2
        public void get_NameOrPseudonym(){} // RVA: 0x7FFE81116380
        public void get_NameDistinguisher(){} // RVA: 0x7FFE810FE7C0
        public void get_DateOfBirth(){} // RVA: 0x7FFE811290C0
        public void get_PlaceOfBirth(){} // RVA: 0x7FFE81129130
        public void get_Gender(){} // RVA: 0x7FFE8144E200
        public void get_PostalAddress(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B24D0
    }

    public class SigIObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1B2990
    }

}