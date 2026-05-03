// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
// Classes: 8
// Methods: 29

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field
{
    public class FiniteFields : Object
    {
        // ── Methods ──
        public void GetBinaryExtensionField(){} // RVA: 0x7FFE8A40F840
        public void GetPrimeField(){} // RVA: 0x7FFE8A40FBA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A40FD20
    }

    public class GF2Polynomial : Object
    {
        public int[] exponents; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4101F0
        public void get_Degree(){} // RVA: 0x7FFE8A4102F0
        public void GetExponentsPresent(){} // RVA: 0x7FFE8A410330
        public void Equals(){} // RVA: 0x7FFE8A4103E0
        public void GetHashCode(){} // RVA: 0x7FFE8A410550
    }

    public class GenericPolynomialExtensionField : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IFiniteField subfield; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IPolynomial minimalPolynomial; // 0x18
        public object field_2; // 0x1C9
        public object field_3; // 0x1CA
        public object field_4; // 0x1CB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Characteristic(){} // RVA: 0x7FFE8A40FF50
        public void get_Dimension(){} // RVA: 0x7FFE8A40FFA0
        public void get_Subfield(){} // RVA: 0x7FFE81116380
        public void get_Degree(){} // RVA: 0x7FFE8A410030
        public void get_MinimalPolynomial(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8A410080
        public void GetHashCode(){} // RVA: 0x7FFE8A410180
    }

    public class IExtensionField
    {
        // ── Methods ──
        public void get_Subfield(){} // RVA: 0x7FFE80E2E2E0
        public void get_Degree(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IFiniteField
    {
        // ── Methods ──
        public void get_Characteristic(){} // RVA: 0x7FFE80E2E2E0
        public void get_Dimension(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IPolynomial
    {
        // ── Methods ──
        public void get_Degree(){} // RVA: 0x7FFE80E2EDB0
        public void GetExponentsPresent(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IPolynomialExtensionField
    {
        // ── Methods ──
        public void get_MinimalPolynomial(){} // RVA: 0x7FFE80E2E2E0
    }

    public class PrimeField : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger characteristic; // 0x10
        public object field_1; // 0x1D5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Characteristic(){} // RVA: 0x7FFE81116380
        public void get_Dimension(){} // RVA: 0x7FFE811EDAF0
        public void Equals(){} // RVA: 0x7FFE8A4105E0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

}