// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
// Classes: 9
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
    public class ECEndomorphism
    {
        // ── Methods ──
        public void get_PointMap(){} // RVA: 0x7FFE80E2E2E0
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFE80E2F150
    }

    public class EndoPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_mappedPoint; // 0x18

        // ── Methods ──
        public void get_Endomorphism(){} // RVA: 0x7FFE81116380
        public void set_Endomorphism(){} // RVA: 0x7FFE810FCE30
        public void get_MappedPoint(){} // RVA: 0x7FFE810FE7C0
        public void set_MappedPoint(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EndoUtilities : Object
    {
        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0x7FFE89EDB1A0
        public void MapPoint(){} // RVA: 0x7FFE89EDB440
        public void CalculateB(){} // RVA: 0x7FFE89EDB640
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EDB760
    }

    public class GlvEndomorphism
    {
        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0x7FFE80E2E390
    }

    public class GlvTypeAEndomorphism : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.GlvTypeAParameters m_parameters; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPointMap m_pointMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EDB9F0
        public void DecomposeScalar(){} // RVA: 0x7FFE89EDBBC0
        public void get_PointMap(){} // RVA: 0x7FFE810FE7C0
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFE811E0850
    }

    public class GlvTypeAParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_i; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_lambda; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters m_splitParams; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void get_I(){} // RVA: 0x7FFE81116380
        public void get_Lambda(){} // RVA: 0x7FFE810FE7C0
        public void get_SplitParams(){} // RVA: 0x7FFE811290C0
    }

    public class GlvTypeBEndomorphism : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters m_parameters; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPointMap m_pointMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EDBC50
        public void DecomposeScalar(){} // RVA: 0x7FFE89EDBE20
        public void get_PointMap(){} // RVA: 0x7FFE810FE7C0
        public void get_HasEfficientPointMap(){} // RVA: 0x7FFE811E0850
    }

    public class GlvTypeBParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_beta; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_lambda; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters m_splitParams; // 0x20
        public object field_3; // 0x226
        public object field_4; // 0x227
        public object field_5; // 0x228
        public object field_6; // 0x229
        public object field_7; // 0x22A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void get_Beta(){} // RVA: 0x7FFE81116380
        public void get_Lambda(){} // RVA: 0x7FFE810FE7C0
        public void get_SplitParams(){} // RVA: 0x7FFE811290C0
        public void get_V1(){} // RVA: 0x7FFE89EDC050
        public void get_V2(){} // RVA: 0x7FFE89EDC170
        public void get_G1(){} // RVA: 0x7FFE81889350
        public void get_G2(){} // RVA: 0x7FFE87264730
        public void get_Bits(){} // RVA: 0x7FFE8453CE10
    }

    public class ScalarSplitParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_v1A; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_v1B; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_v2A; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_v2B; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_g1; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_g2; // 0x38
        public int m_bits; // 0x40

        // ── Methods ──
        public void CheckVector(){} // RVA: 0x7FFE89EDC290
        public void .ctor(){} // RVA: 0x7FFE89EDC310
        public void get_V1A(){} // RVA: 0x7FFE81116380
        public void get_V1B(){} // RVA: 0x7FFE810FE7C0
        public void get_V2A(){} // RVA: 0x7FFE811290C0
        public void get_V2B(){} // RVA: 0x7FFE81129130
        public void get_G1(){} // RVA: 0x7FFE8144E200
        public void get_G2(){} // RVA: 0x7FFE8143BA80
        public void get_Bits(){} // RVA: 0x7FFE8119C080
    }

}