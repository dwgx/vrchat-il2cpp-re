// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
// Classes: 9
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
    public class ECEndomorphism
    {
        public object PointMap;
        public object HasEfficientPointMap;

        // ── Methods ──
        public void get_PointMap(){} // RVA: 0x7FFAC2C58E90
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFAC2C59D00
    }

    public class EndoPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ECEndomorphism Endomorphism; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint MappedPoint; // 0x18

        // ── Methods ──
        public void get_Endomorphism(){} // RVA: 0x7FFAC2F3C380
        public void set_Endomorphism(){} // RVA: 0x7FFAC2F22E30
        public void get_MappedPoint(){} // RVA: 0x7FFAC2F247C0
        public void set_MappedPoint(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EndoUtilities : Object
    {
        public string PRECOMP_NAME;

        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0x7FFACBA81B80
        public void MapPoint(){} // RVA: 0x7FFACBA81E20
        public void CalculateB(){} // RVA: 0x7FFACBA82020
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA82140
    }

    public class GlvEndomorphism
    {
        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0x7FFAC2C58F40
    }

    public class GlvTypeAEndomorphism : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.GlvTypeAParameters PointMap; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPointMap HasEfficientPointMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA823D0
        public void DecomposeScalar(){} // RVA: 0x7FFACBA825A0
        public void get_PointMap(){} // RVA: 0x7FFAC2F247C0
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFAC3006850
    }

    public class GlvTypeAParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger I; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Lambda; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters SplitParams; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void get_I(){} // RVA: 0x7FFAC2F3C380
        public void get_Lambda(){} // RVA: 0x7FFAC2F247C0
        public void get_SplitParams(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class GlvTypeBEndomorphism : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters PointMap; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPointMap HasEfficientPointMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA82630
        public void DecomposeScalar(){} // RVA: 0x7FFACBA82800
        public void get_PointMap(){} // RVA: 0x7FFAC2F247C0
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFAC3006850
    }

    public class GlvTypeBParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Beta; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Lambda; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters SplitParams; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void get_Beta(){} // RVA: 0x7FFAC2F3C380
        public void get_Lambda(){} // RVA: 0x7FFAC2F247C0
        public void get_SplitParams(){} // RVA: 0x7FFAC2F4F0C0
        public void get_V1(){} // RVA: 0x7FFACBA82A30
        public void get_V2(){} // RVA: 0x7FFACBA82B50
        public void get_G1(){} // RVA: 0x7FFAC3760180
        public void get_G2(){} // RVA: 0x7FFAC8EBC2E0
        public void get_Bits(){} // RVA: 0x7FFAC623DF40
    }

    public class ScalarSplitParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger V1A; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger V1B; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger V2A; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger V2B; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G1; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G2; // 0x38
        public int Bits; // 0x40

        // ── Methods ──
        public void CheckVector(){} // RVA: 0x7FFACBA82C70
        public void .ctor(){} // RVA: 0x7FFACBA82CF0
        public void get_V1A(){} // RVA: 0x7FFAC2F3C380
        public void get_V1B(){} // RVA: 0x7FFAC2F247C0
        public void get_V2A(){} // RVA: 0x7FFAC2F4F0C0
        public void get_V2B(){} // RVA: 0x7FFAC2F4F130
        public void get_G1(){} // RVA: 0x7FFAC31D95E0
        public void get_G2(){} // RVA: 0x7FFAC31D0140
        public void get_Bits(){} // RVA: 0x7FFAC2FC2080
    }

}