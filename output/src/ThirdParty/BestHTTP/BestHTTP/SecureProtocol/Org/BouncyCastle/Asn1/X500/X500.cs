// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
// Classes: 3
// Methods: 22

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Type; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD5CE30
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD5CF60
    }

    public class DirectoryString : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerStringBase str; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD5D3B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD5D460 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC84AA530
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class Rdn : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set IsMultiValued; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD5D930 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBD5D5B0
        public void get_IsMultiValued(){} // RVA: 0x7FFACBD5D9F0
        public void get_Count(){} // RVA: 0x7FFAC8D71650
        public void GetFirst(){} // RVA: 0x7FFACBD5DA30
        public void GetTypesAndValues(){} // RVA: 0x7FFACBD5DAA0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

}