// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
// Classes: 3
// Methods: 21

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
{
    public class NameOrPseudonym : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString Pseudonym; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString Surname; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence givenName; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD57D40
        public void .ctor(){} // RVA: 0x7FFAC8BA01A0 | overloaded x4
        public void get_Pseudonym(){} // RVA: 0x7FFAC2F3C380
        public void get_Surname(){} // RVA: 0x7FFAC2F247C0
        public void GetGivenName(){} // RVA: 0x7FFACBD582F0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD585F0
    }

    public class PersonalData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym NameOrPseudonym; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger NameDistinguisher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime DateOfBirth; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString PlaceOfBirth; // 0x28
        public string Gender; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500.DirectoryString PostalAddress; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD58740
        public void .ctor(){} // RVA: 0x7FFACBD58CA0 | overloaded x2
        public void get_NameOrPseudonym(){} // RVA: 0x7FFAC2F3C380
        public void get_NameDistinguisher(){} // RVA: 0x7FFAC2F247C0
        public void get_DateOfBirth(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PlaceOfBirth(){} // RVA: 0x7FFAC2F4F130
        public void get_Gender(){} // RVA: 0x7FFAC31D95E0
        public void get_PostalAddress(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBD58EB0
    }

    public class SigIObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigI;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIKP; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigICP; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigION; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIKPDirectoryService; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIONPersonalData; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigICPSigConform; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD59370
    }

}