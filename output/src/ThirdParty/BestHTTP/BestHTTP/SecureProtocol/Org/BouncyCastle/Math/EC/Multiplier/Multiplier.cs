// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 21
// Methods: 88

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier : Object
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7B12A6020
        public void MultiplyPositive(){} // RVA: 0x7A7E00BD0
        public void CheckResult(){} // RVA: 0x7B12A6130
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DoubleAddMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A61B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7A7E00BD0
    }

    public class FixedPointCombMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A6420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FixedPointPreCompInfo : Object
    {
        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0x7A80DA7B0
        public void set_LookupTable(){} // RVA: 0x7A813E420
        public void get_Offset(){} // RVA: 0x7A80F2570
        public void set_Offset(){} // RVA: 0x7A80D8E20
        public void get_Width(){} // RVA: 0x7A851DB90
        public void set_Width(){} // RVA: 0x7A8738180
        public void .ctor(){} // RVA: 0x7AACDA600
    }

    public class FixedPointUtilities : Object
    {
        // ── Methods ──
        public void GetCombSize(){} // RVA: 0x7B12A6700
        public void GetFixedPointPreCompInfo(){} // RVA: 0x7B12A6760
        public void Precompute(){} // RVA: 0x7B12A67E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B12A6960
    }

    public class GlvMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12A7140
        public void MultiplyPositive(){} // RVA: 0x7B12A72A0
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0x7A7E00B20
    }

    public class MixedNafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226C00
        public void MultiplyPositive(){} // RVA: 0x7B12A74D0
        public void ConfigureCurve(){} // RVA: 0x7B12A7700
    }

    public class MontgomeryLadderMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A7820
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A7B50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A7CE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReferenceMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A7E60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ValidityPreCompInfo : Object
    {
        // ── Methods ──
        public void HasFailed(){} // RVA: 0x7A81A2200
        public void ReportFailed(){} // RVA: 0x7A847A240
        public void HasCurveEquationPassed(){} // RVA: 0x7A82FBFB0
        public void ReportCurveEquationPassed(){} // RVA: 0x7A8329980
        public void HasOrderPassed(){} // RVA: 0x7A9716B70
        public void ReportOrderPassed(){} // RVA: 0x7B12A7E80
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B12A7E90
    }

    public class WNafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12A7F40
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class WNafPreCompInfo : Object
    {
        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0x7B12A8320
        public void get_PromotionCountdown(){} // RVA: 0x7ADD19C70
        public void set_PromotionCountdown(){} // RVA: 0x7ADBFCEE0
        public void get_IsPromoted(){} // RVA: 0x7B12A8340
        public void get_ConfWidth(){} // RVA: 0x7A8668BC0
        public void set_ConfWidth(){} // RVA: 0x7A8669360
        public void get_PreComp(){} // RVA: 0x7A80DA7B0
        public void set_PreComp(){} // RVA: 0x7A813E420
        public void get_PreCompNeg(){} // RVA: 0x7A81052C0
        public void set_PreCompNeg(){} // RVA: 0x7A81052D0
        public void get_Twice(){} // RVA: 0x7A8105330
        public void set_Twice(){} // RVA: 0x7A80D8E80
        public void get_Width(){} // RVA: 0x7A8133100
        public void set_Width(){} // RVA: 0x7A8133110
        public void .ctor(){} // RVA: 0x7B12A8350
    }

    public class WNafUtilities : Object
    {
        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7B12A8370
        public void GenerateCompactNaf(){} // RVA: 0x7B12A8590
        public void GenerateCompactWindowNaf(){} // RVA: 0x7B12A8880
        public void GenerateJsf(){} // RVA: 0x7B12A8BC0
        public void GenerateNaf(){} // RVA: 0x7B12A8FE0
        public void GenerateWindowNaf(){} // RVA: 0x7B12A91D0
        public void GetNafWeight(){} // RVA: 0x7B12A9480
        public void GetWNafPreCompInfo(){} // RVA: 0x7B12A9610
        public void GetWindowSize(){} // RVA: 0x7B12A97F0
        public void MapPointWithPrecomp(){} // RVA: 0x7B12A98A0
        public void Precompute(){} // RVA: 0x7B12A9A80
        public void PrecomputeWithPointMap(){} // RVA: 0x7B12A9C20
        public void Trim(){} // RVA: 0x7B12A9EF0
        public void ResizeTable(){} // RVA: 0x7B12A9F70
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B12A9FF0
    }

    public class WTauNafMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12ABD40
        public void MultiplyWTnaf(){} // RVA: 0x7B12AC160
        public void MultiplyFromWTnaf(){} // RVA: 0x7B12AC320
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B12AC910
    }

    public class WTauNafPreCompInfo : Object
    {
        // ── Methods ──
        public void get_PreComp(){} // RVA: 0x7A80F2570
        public void set_PreComp(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ZSignedDigitL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12ACAB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ZSignedDigitR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7B12ACBD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}