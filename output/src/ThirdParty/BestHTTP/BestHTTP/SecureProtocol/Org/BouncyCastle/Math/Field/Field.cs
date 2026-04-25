// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
// Classes: 8
// Methods: 29

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
    public class FiniteFields : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IFiniteField GF_2;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IFiniteField GF_3; // 0x8

        // ── Methods ──
        public void GetBinaryExtensionField(){} // RVA: 0x7FFACBFAECD0
        public void GetPrimeField(){} // RVA: 0x7FFACBFAF030
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBFAF1B0
    }

    public class GF2Polynomial : Object
    {
        public int[] Degree; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFAF680
        public void get_Degree(){} // RVA: 0x7FFACBFAF780
        public void GetExponentsPresent(){} // RVA: 0x7FFACBFAF7C0
        public void Equals(){} // RVA: 0x7FFACBFAF870
        public void GetHashCode(){} // RVA: 0x7FFACBFAF9E0
    }

    public class GenericPolynomialExtensionField : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IFiniteField Characteristic; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IPolynomial Dimension; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Characteristic(){} // RVA: 0x7FFACBFAF3E0
        public void get_Dimension(){} // RVA: 0x7FFACBFAF430
        public void get_Subfield(){} // RVA: 0x7FFAC2F3C380
        public void get_Degree(){} // RVA: 0x7FFACBFAF4C0
        public void get_MinimalPolynomial(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBFAF510
        public void GetHashCode(){} // RVA: 0x7FFACBFAF610
    }

    public class IExtensionField
    {
        public object Subfield;
        public object Degree;

        // ── Methods ──
        public void get_Subfield(){} // RVA: 0x7FFAC2C58E90
        public void get_Degree(){} // RVA: 0x7FFAC2C59960
    }

    public class IFiniteField
    {
        public object Characteristic;
        public object Dimension;

        // ── Methods ──
        public void get_Characteristic(){} // RVA: 0x7FFAC2C58E90
        public void get_Dimension(){} // RVA: 0x7FFAC2C59960
    }

    public class IPolynomial
    {
        public object Degree;

        // ── Methods ──
        public void get_Degree(){} // RVA: 0x7FFAC2C59960
        public void GetExponentsPresent(){} // RVA: 0x7FFAC2C58E90
    }

    public class IPolynomialExtensionField
    {
        public object MinimalPolynomial;

        // ── Methods ──
        public void get_MinimalPolynomial(){} // RVA: 0x7FFAC2C58E90
    }

    public class PrimeField : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Characteristic; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Characteristic(){} // RVA: 0x7FFAC2F3C380
        public void get_Dimension(){} // RVA: 0x7FFAC3013AF0
        public void Equals(){} // RVA: 0x7FFACBFAFA70
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

}