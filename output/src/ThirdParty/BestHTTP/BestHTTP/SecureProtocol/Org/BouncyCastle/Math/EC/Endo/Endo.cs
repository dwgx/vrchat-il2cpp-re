// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
// Classes: 9
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
    public class ECEndomorphism
    {
        // ── Methods ──
        public void get_PointMap(){} // RVA: 0x87C0A0
        public void get_HasEfficientPointMap(){} // RVA: 0x87D280
    }

    public class EndoPreCompInfo : Object
    {
        public object m_endomorphism;
        public object m_mappedPoint;

        // ── Methods ──
        public void get_Endomorphism(){} // RVA: 0xB5DBF0
        public void set_Endomorphism(){} // RVA: 0xB44D60
        public void get_MappedPoint(){} // RVA: 0xB465B0
        public void set_MappedPoint(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EndoUtilities : Object
    {
        public object PRECOMP_NAME;

        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0xA1186C0
        public void MapPoint(){} // RVA: 0xA118960
        public void CalculateB(){} // RVA: 0xA118B50
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA118C70
    }

    public class GlvEndomorphism
    {
        // ── Methods ──
        public void DecomposeScalar(){} // RVA: 0x87C540
    }

    public class GlvTypeAEndomorphism : Object
    {
        public object m_parameters;
        public object m_pointMap;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA118F00
        public void DecomposeScalar(){} // RVA: 0xA1190D0
        public void get_PointMap(){} // RVA: 0xB465B0
        public void get_HasEfficientPointMap(){} // RVA: 0xC2E4C0
    }

    public class GlvTypeAParameters : Object
    {
        public object m_i;
        public object m_lambda;
        public object m_splitParams;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_I(){} // RVA: 0xB5DBF0
        public void get_Lambda(){} // RVA: 0xB465B0
        public void get_SplitParams(){} // RVA: 0xB700F0
    }

    public class GlvTypeBEndomorphism : Object
    {
        public object m_parameters;
        public object m_pointMap;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA119160
        public void DecomposeScalar(){} // RVA: 0xA119330
        public void get_PointMap(){} // RVA: 0xB465B0
        public void get_HasEfficientPointMap(){} // RVA: 0xC2E4C0
    }

    public class GlvTypeBParameters : Object
    {
        public object m_beta;
        public object m_lambda;
        public object m_splitParams;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_Beta(){} // RVA: 0xB5DBF0
        public void get_Lambda(){} // RVA: 0xB465B0
        public void get_SplitParams(){} // RVA: 0xB700F0
        public void get_V1(){} // RVA: 0xA119560
        public void get_V2(){} // RVA: 0xA119680
        public void get_G1(){} // RVA: 0x13E8D50
        public void get_G2(){} // RVA: 0x718D430
        public void get_Bits(){} // RVA: 0x4219980
    }

    public class ScalarSplitParameters : Object
    {
        public object m_v1A;
        public object m_v1B;
        public object m_v2A;
        public object m_v2B;
        public object m_g1;
        public object m_g2;
        public object m_bits;

        // ── Methods ──
        public void CheckVector(){} // RVA: 0xA1197A0
        public void .ctor(){} // RVA: 0xA119820
        public void get_V1A(){} // RVA: 0xB5DBF0
        public void get_V1B(){} // RVA: 0xB465B0
        public void get_V2A(){} // RVA: 0xB700F0
        public void get_V2B(){} // RVA: 0xB70160
        public void get_G1(){} // RVA: 0xD33E60
        public void get_G2(){} // RVA: 0xD05CA0
        public void get_Bits(){} // RVA: 0xBE5850
    }

}