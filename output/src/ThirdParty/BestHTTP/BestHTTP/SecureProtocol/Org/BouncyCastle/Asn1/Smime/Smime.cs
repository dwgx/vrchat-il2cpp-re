// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
// Classes: 6
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
{
    public class SmimeAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1C57D0
    }

    public class SmimeCapabilities : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1C5930
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetCapabilities(){} // RVA: 0x7FFE8A1C5BF0
        public void GetCapabilitiesForOid(){} // RVA: 0x7FFE8A1C5C70
        public void DoGetCapabilitiesForOid(){} // RVA: 0x7FFE8A1C5D20
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE8A1C6210
    }

    public class SmimeCapabilitiesAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1C68A0
    }

    public class SmimeCapability : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1C6C60 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1C6D90
        public void get_CapabilityID(){} // RVA: 0x7FFE81116380
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1C6F20
        public void .cctor(){} // RVA: 0x7FFE8A1C7120
    }

    public class SmimeCapabilityVector : Object
    {
        // ── Methods ──
        public void AddCapability(){} // RVA: 0x7FFE8A1C76A0 | overloaded x3
        public void ToAsn1EncodableVector(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE8A1C77D0
    }

    public class SmimeEncryptionKeyPreferenceAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1C7A70 | overloaded x3
    }

}