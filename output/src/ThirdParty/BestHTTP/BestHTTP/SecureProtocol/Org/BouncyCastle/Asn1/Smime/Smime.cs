// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
// Classes: 6
// Methods: 20

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
{
    public class SmimeAttributes : Object
    {
        public object SmimeCapabilities;
        public object EncrypKeyPref;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4088C0
    }

    public class SmimeCapabilities : Asn1Encodable
    {
        public object PreferSignedData;
        public object CannotDecryptAny;
        public object SmimeCapabilitesVersions;
        public object Aes256Cbc;
        public object Aes192Cbc;
        public object Aes128Cbc;
        public object IdeaCbc;
        public object Cast5Cbc;
        public object DesCbc;
        public object DesEde3Cbc;
        public object RC2Cbc;
        public object capabilities;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA408A20
        public void .ctor(){} // RVA: 0xB44D60
        public void GetCapabilities(){} // RVA: 0xA408CE0
        public void GetCapabilitiesForOid(){} // RVA: 0xA408D60
        public void DoGetCapabilitiesForOid(){} // RVA: 0xA408E10
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0xA4092E0
    }

    public class SmimeCapabilitiesAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA409970
    }

    public class SmimeCapability : Asn1Encodable
    {
        public object PreferSignedData;
        public object CannotDecryptAny;
        public object SmimeCapabilitiesVersions;
        public object DesCbc;
        public object DesEde3Cbc;
        public object RC2Cbc;
        public object capabilityID;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA409D30
        public void GetInstance(){} // RVA: 0xA409E60
        public void get_CapabilityID(){} // RVA: 0xB5DBF0
        public void get_Parameters(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA409FF0
        public void .cctor(){} // RVA: 0xA40A200
    }

    public class SmimeCapabilityVector : Object
    {
        public object capabilities;

        // ── Methods ──
        public void AddCapability(){} // RVA: 0xA40A780
        public void ToAsn1EncodableVector(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xA40A8B0
    }

    public class SmimeEncryptionKeyPreferenceAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA40AB50
    }

}