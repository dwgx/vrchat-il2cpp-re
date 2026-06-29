// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
// Classes: 8
// Methods: 29

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
    public class FiniteFields : Object
    {
        public object GF_2;
        public object GF_3;

        // ── Methods ──
        public void GetBinaryExtensionField(){} // RVA: 0xA65D660
        public void GetPrimeField(){} // RVA: 0xA65D9C0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA65DB40
    }

    public class GF2Polynomial : Object
    {
        public object exponents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA65DFF0
        public void get_Degree(){} // RVA: 0xA65E0F0
        public void GetExponentsPresent(){} // RVA: 0xA65E130
        public void Equals(){} // RVA: 0xA65E1E0
        public void GetHashCode(){} // RVA: 0xA65E320
    }

    public class GenericPolynomialExtensionField : Object
    {
        public object subfield;
        public object minimalPolynomial;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Characteristic(){} // RVA: 0xA65DD70
        public void get_Dimension(){} // RVA: 0xA65DDC0
        public void get_Subfield(){} // RVA: 0xB5DBF0
        public void get_Degree(){} // RVA: 0xA65DE50
        public void get_MinimalPolynomial(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA65DEA0
        public void GetHashCode(){} // RVA: 0xA65DF80
    }

    public class IExtensionField
    {
        // ── Methods ──
        public void get_Subfield(){} // RVA: 0x87C0A0
        public void get_Degree(){} // RVA: 0x87C130
    }

    public class IFiniteField
    {
        // ── Methods ──
        public void get_Characteristic(){} // RVA: 0x87C0A0
        public void get_Dimension(){} // RVA: 0x87C130
    }

    public class IPolynomial
    {
        // ── Methods ──
        public void get_Degree(){} // RVA: 0x87C130
        public void GetExponentsPresent(){} // RVA: 0x87C0A0
    }

    public class IPolynomialExtensionField
    {
        // ── Methods ──
        public void get_MinimalPolynomial(){} // RVA: 0x87C0A0
    }

    public class PrimeField : Object
    {
        public object characteristic;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Characteristic(){} // RVA: 0xB5DBF0
        public void get_Dimension(){} // RVA: 0xC3CCE0
        public void Equals(){} // RVA: 0xA65E3B0
        public void GetHashCode(){} // RVA: 0x1269730
    }

}