// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
// Classes: 3
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SigI
{
    public class NameOrPseudonym : Asn1Encodable
    {
        public object pseudonym;
        public object surname;
        public object givenName;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F4230
        public void .ctor(){} // RVA: 0x6E796B0
        public void get_Pseudonym(){} // RVA: 0xB5DBF0
        public void get_Surname(){} // RVA: 0xB465B0
        public void GetGivenName(){} // RVA: 0xA3F47E0
        public void ToAsn1Object(){} // RVA: 0xA3F4AD0
    }

    public class PersonalData : Asn1Encodable
    {
        public object nameOrPseudonym;
        public object nameDistinguisher;
        public object dateOfBirth;
        public object placeOfBirth;
        public object gender;
        public object postalAddress;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F4C20
        public void .ctor(){} // RVA: 0xA3F5180
        public void get_NameOrPseudonym(){} // RVA: 0xB5DBF0
        public void get_NameDistinguisher(){} // RVA: 0xB465B0
        public void get_DateOfBirth(){} // RVA: 0xB700F0
        public void get_PlaceOfBirth(){} // RVA: 0xB70160
        public void get_Gender(){} // RVA: 0xD33E60
        public void get_PostalAddress(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA3F5390
    }

    public class SigIObjectIdentifiers : Object
    {
        public object IdSigI;
        public object IdSigIKP;
        public object IdSigICP;
        public object IdSigION;
        public object IdSigIKPDirectoryService;
        public object IdSigIONPersonalData;
        public object IdSigICPSigConform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3F5860
    }

}