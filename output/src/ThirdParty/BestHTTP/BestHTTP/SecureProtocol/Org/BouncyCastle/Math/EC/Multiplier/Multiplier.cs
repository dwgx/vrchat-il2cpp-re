// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 22
// Methods: 94

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFAFBF22150
        public void MultiplyPositive(){} // RVA: 0x7FFAF2ACE6A0
        public void CheckResult(){} // RVA: 0x7FFAFBF22260
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DoubleAddMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF222E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class FixedPointCombMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF22540
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FixedPointPreCompInfo
    {
        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0x7FFAF2D907C0
        public void set_LookupTable(){} // RVA: 0x7FFAF2DF3E80
        public void get_Offset(){} // RVA: 0x7FFAF2DA8380
        public void set_Offset(){} // RVA: 0x7FFAF2D8EE30
        public void get_Width(){} // RVA: 0x7FFAF3210030
        public void set_Width(){} // RVA: 0x7FFAF344E0D0
        public void .ctor(){} // RVA: 0x7FFAF5993B40
    }

    public class FixedPointUtilities
    {
        // ── Methods ──
        public void GetCombSize(){} // RVA: 0x7FFAFBF22820
        public void GetFixedPointPreCompInfo(){} // RVA: 0x7FFAFBF22880
        public void Precompute(){} // RVA: 0x7FFAFBF22910
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF22A90
    }

    public class GlvMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF23200
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23360
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0x7FFAF2ABCE10
    }

    public class MixedNafR2LMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EE8000 | overloaded x2
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23590
        public void ConfigureCurve(){} // RVA: 0x7FFAFBF237C0
    }

    public class MontgomeryLadderMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF238E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NafL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23C00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NafR2LMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23D80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PreCompInfo
    {
    }

    public class ReferenceMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23F00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ValidityPreCompInfo
    {
        // ── Methods ──
        public void HasFailed(){} // RVA: 0x7FFAF2E575E0
        public void ReportFailed(){} // RVA: 0x7FFAF316D7E0
        public void HasCurveEquationPassed(){} // RVA: 0x7FFAF2FF3460
        public void ReportCurveEquationPassed(){} // RVA: 0x7FFAF3020B10
        public void HasOrderPassed(){} // RVA: 0x7FFAF440A940
        public void ReportOrderPassed(){} // RVA: 0x7FFAFBF23F20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF23F30
    }

    public class WNafL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF23FE0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class WNafPreCompInfo
    {
        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0x7FFAFBF24410
        public void get_PromotionCountdown(){} // RVA: 0x7FFAF89DAEC0
        public void set_PromotionCountdown(){} // RVA: 0x7FFAF88BE890
        public void get_IsPromoted(){} // RVA: 0x7FFAFBF24430
        public void get_ConfWidth(){} // RVA: 0x7FFAF335BED0
        public void set_ConfWidth(){} // RVA: 0x7FFAF335C660
        public void get_PreComp(){} // RVA: 0x7FFAF2D907C0
        public void set_PreComp(){} // RVA: 0x7FFAF2DF3E80
        public void get_PreCompNeg(){} // RVA: 0x7FFAF2DBB0C0
        public void set_PreCompNeg(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Twice(){} // RVA: 0x7FFAF2DBB130
        public void set_Twice(){} // RVA: 0x7FFAF2D8EE90
        public void get_Width(){} // RVA: 0x7FFAF2DE8CD0
        public void set_Width(){} // RVA: 0x7FFAF2DE8CE0
        public void .ctor(){} // RVA: 0x7FFAFBF24440
    }

    public class WNafUtilities
    {
        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7FFAFBF24460
        public void GenerateCompactNaf(){} // RVA: 0x7FFAFBF24680
        public void GenerateCompactWindowNaf(){} // RVA: 0x7FFAFBF24960
        public void GenerateJsf(){} // RVA: 0x7FFAFBF24C90
        public void GenerateNaf(){} // RVA: 0x7FFAFBF25090
        public void GenerateWindowNaf(){} // RVA: 0x7FFAFBF25220
        public void GetNafWeight(){} // RVA: 0x7FFAFBF25610
        public void GetWNafPreCompInfo(){} // RVA: 0x7FFAFBF257B0 | overloaded x2
        public void GetWindowSize(){} // RVA: 0x7FFAFBF259A0 | overloaded x4
        public void MapPointWithPrecomp(){} // RVA: 0x7FFAFBF25A50
        public void Precompute(){} // RVA: 0x7FFAFBF25C30
        public void PrecomputeWithPointMap(){} // RVA: 0x7FFAFBF25DC0
        public void Trim(){} // RVA: 0x7FFAFBF26090 | overloaded x2
        public void ResizeTable(){} // RVA: 0x7FFAFBF26110
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF26190
    }

    public class WTauNafMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF27DE0
        public void MultiplyWTnaf(){} // RVA: 0x7FFAFBF281F0
        public void MultiplyFromWTnaf(){} // RVA: 0x7FFAFBF283B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBF28990
    }

    public class WTauNafPreCompInfo
    {
        // ── Methods ──
        public void get_PreComp(){} // RVA: 0x7FFAF2DA8380
        public void set_PreComp(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ZSignedDigitL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF28B30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ZSignedDigitR2LMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFAFBF28C50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}