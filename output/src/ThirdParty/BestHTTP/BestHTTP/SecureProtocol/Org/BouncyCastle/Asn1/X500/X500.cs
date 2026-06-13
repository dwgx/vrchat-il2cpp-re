// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
// Classes: 3
// Methods: 22

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
{
    public class AttributeTypeAndValue
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier type; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x9754050
        public void get_Type(){} // RVA: 0x2F8380
        public void get_Value(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9754180
    }

    public class DirectoryString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97545D0 | overloaded x2
        public void .ctor(){} // RVA: 0x9754680 | overloaded x2
        public void GetString(){} // RVA: 0x5D12EF0
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class Rdn
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set values; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9754B50 | overloaded x4
        public void GetInstance(){} // RVA: 0x97547D0
        public void get_IsMultiValued(){} // RVA: 0x9754C10
        public void get_Count(){} // RVA: 0x65DABF0
        public void GetFirst(){} // RVA: 0x9754C50
        public void GetTypesAndValues(){} // RVA: 0x9754CC0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

}