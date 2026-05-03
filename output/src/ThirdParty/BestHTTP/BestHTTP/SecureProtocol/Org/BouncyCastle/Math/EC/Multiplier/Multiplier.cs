// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 22
// Methods: 94

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier : Object
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFE89ED4520
        public void MultiplyPositive(){} // RVA: 0x7FFE80E3FC10
        public void CheckResult(){} // RVA: 0x7FFE89ED4630
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DoubleAddMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED46B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFE80E3FC10
    }

    public class FixedPointCombMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED4910
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FixedPointPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_offset; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECLookupTable m_lookupTable; // 0x18
        public int m_width; // 0x20

        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0x7FFE810FE7C0
        public void set_LookupTable(){} // RVA: 0x7FFE81161E80
        public void get_Offset(){} // RVA: 0x7FFE81116380
        public void set_Offset(){} // RVA: 0x7FFE810FCE30
        public void get_Width(){} // RVA: 0x7FFE8151D690
        public void set_Width(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE83BB2D90
    }

    public class FixedPointUtilities : Object
    {
        // ── Methods ──
        public void GetCombSize(){} // RVA: 0x7FFE89ED4BF0
        public void GetFixedPointPreCompInfo(){} // RVA: 0x7FFE89ED4C50
        public void Precompute(){} // RVA: 0x7FFE89ED4CE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89ED4E60
    }

    public class GlvMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89ED55D0
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED5730
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0x7FFE80E2E390
    }

    public class MixedNafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE85072A80 | overloaded x2
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED5960
        public void ConfigureCurve(){} // RVA: 0x7FFE89ED5B90
    }

    public class MontgomeryLadderMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED5CB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED5FD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED6150
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PreCompInfo
    {
    }

    public class ReferenceMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED62D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ValidityPreCompInfo : Object
    {
        // ── Methods ──
        public void HasFailed(){} // RVA: 0x7FFE811C55E0
        public void ReportFailed(){} // RVA: 0x7FFE814B8390
        public void HasCurveEquationPassed(){} // RVA: 0x7FFE81346E30
        public void ReportCurveEquationPassed(){} // RVA: 0x7FFE813752C0
        public void HasOrderPassed(){} // RVA: 0x7FFE826E3520
        public void ReportOrderPassed(){} // RVA: 0x7FFE89ED62F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89ED6300
    }

    public class WNafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89ED63B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class WNafPreCompInfo : Object
    {
        public int m_promotionCountdown; // 0x10
        public int m_confWidth; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] m_preComp; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] m_preCompNeg; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_twice; // 0x28
        public int m_width; // 0x30
        public object field_6; // 0x213

        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0x7FFE89ED67E0
        public void get_PromotionCountdown(){} // RVA: 0x7FFE86A6BCE0
        public void set_PromotionCountdown(){} // RVA: 0x7FFE8694F6D0
        public void get_IsPromoted(){} // RVA: 0x7FFE89ED6800
        public void get_ConfWidth(){} // RVA: 0x7FFE8164B230
        public void set_ConfWidth(){} // RVA: 0x7FFE8164E0F0
        public void get_PreComp(){} // RVA: 0x7FFE810FE7C0
        public void set_PreComp(){} // RVA: 0x7FFE81161E80
        public void get_PreCompNeg(){} // RVA: 0x7FFE811290C0
        public void set_PreCompNeg(){} // RVA: 0x7FFE811290D0
        public void get_Twice(){} // RVA: 0x7FFE81129130
        public void set_Twice(){} // RVA: 0x7FFE810FCE90
        public void get_Width(){} // RVA: 0x7FFE81156CD0
        public void set_Width(){} // RVA: 0x7FFE81156CE0
        public void .ctor(){} // RVA: 0x7FFE89ED6810
    }

    public class WNafUtilities : Object
    {
        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7FFE89ED6830
        public void GenerateCompactNaf(){} // RVA: 0x7FFE89ED6A50
        public void GenerateCompactWindowNaf(){} // RVA: 0x7FFE89ED6D30
        public void GenerateJsf(){} // RVA: 0x7FFE89ED7060
        public void GenerateNaf(){} // RVA: 0x7FFE89ED7460
        public void GenerateWindowNaf(){} // RVA: 0x7FFE89ED75F0
        public void GetNafWeight(){} // RVA: 0x7FFE89ED79E0
        public void GetWNafPreCompInfo(){} // RVA: 0x7FFE89ED7B80 | overloaded x2
        public void GetWindowSize(){} // RVA: 0x7FFE89ED7D70 | overloaded x4
        public void MapPointWithPrecomp(){} // RVA: 0x7FFE89ED7E20
        public void Precompute(){} // RVA: 0x7FFE89ED8000
        public void PrecomputeWithPointMap(){} // RVA: 0x7FFE89ED8190
        public void Trim(){} // RVA: 0x7FFE89ED8460 | overloaded x2
        public void ResizeTable(){} // RVA: 0x7FFE89ED84E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89ED8560
    }

    public class WTauNafMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89EDA1B0
        public void MultiplyWTnaf(){} // RVA: 0x7FFE89EDA5C0
        public void MultiplyFromWTnaf(){} // RVA: 0x7FFE89EDA780
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EDAD60
    }

    public class WTauNafPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.AbstractF2mPoint[] m_preComp; // 0x10

        // ── Methods ──
        public void get_PreComp(){} // RVA: 0x7FFE81116380
        public void set_PreComp(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ZSignedDigitL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89EDAF00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ZSignedDigitR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFE89EDB020
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}