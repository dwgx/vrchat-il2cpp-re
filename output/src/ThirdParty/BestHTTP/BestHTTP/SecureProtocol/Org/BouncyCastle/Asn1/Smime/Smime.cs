// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
// Classes: 6
// Methods: 25

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Smime
{
    public class SmimeAttributes : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilities;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncrypKeyPref; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD6C1B0
    }

    public class SmimeCapabilities : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitesVersions; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Aes256Cbc; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Aes192Cbc; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Aes128Cbc; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdeaCbc; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Cast5Cbc; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DesCbc; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence capabilities; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD6C310
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetCapabilities(){} // RVA: 0x7FFACBD6C5D0
        public void GetCapabilitiesForOid(){} // RVA: 0x7FFACBD6C650
        public void DoGetCapabilitiesForOid(){} // RVA: 0x7FFACBD6C700
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFACBD6CBF0
    }

    public class SmimeCapabilitiesAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD6D280
    }

    public class SmimeCapability : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CapabilityID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Parameters; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitiesVersions; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DesCbc; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier capabilityID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD6D640 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD6D770
        public void get_CapabilityID(){} // RVA: 0x7FFAC2F3C380
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD6D900
        public void .cctor(){} // RVA: 0x7FFACBD6DB00
    }

    public class SmimeCapabilityVector : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector capabilities; // 0x10

        // ── Methods ──
        public void AddCapability(){} // RVA: 0x7FFACBD6E080 | overloaded x3
        public void ToAsn1EncodableVector(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFACBD6E1B0
    }

    public class SmimeEncryptionKeyPreferenceAttribute : AttributeX509
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD6E450 | overloaded x3
    }

}