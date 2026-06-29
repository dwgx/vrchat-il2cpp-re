// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
// Classes: 3
// Methods: 16

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X500
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public object type;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA3F9350
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_Value(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3F9610
    }

    public class DirectoryString : Asn1Encodable
    {
        public object str;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3F9A60
        public void .ctor(){} // RVA: 0xA3F9B10
        public void GetString(){} // RVA: 0x678C250
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class Rdn : Asn1Encodable
    {
        public object values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3F9FD0
        public void GetInstance(){} // RVA: 0xA3F9C60
        public void get_IsMultiValued(){} // RVA: 0xA3FA090
        public void get_Count(){} // RVA: 0x7048FE0
        public void GetFirst(){} // RVA: 0xA3FA0D0
        public void GetTypesAndValues(){} // RVA: 0xA3FA140
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

}