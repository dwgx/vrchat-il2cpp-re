// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
// Classes: 3
// Methods: 22

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier type; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1B6450
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1B6580
    }

    public class DirectoryString : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1B69D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1B6A80 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE86853DF0
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class Rdn : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set values; // 0x10
        public object field_1; // 0x751

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1B6F50 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A1B6BD0
        public void get_IsMultiValued(){} // RVA: 0x7FFE8A1B7010
        public void get_Count(){} // RVA: 0x7FFE87119A80
        public void GetFirst(){} // RVA: 0x7FFE8A1B7050
        public void GetTypesAndValues(){} // RVA: 0x7FFE8A1B70C0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

}