// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 22
// Methods: 94

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x9472150
        public void MultiplyPositive(){} // RVA: 0x1E6A0
        public void CheckResult(){} // RVA: 0x9472260
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DoubleAddMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x94722E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x1E6A0
    }

    public class FixedPointCombMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9472540
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FixedPointPreCompInfo
    {
        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0x2E07C0
        public void set_LookupTable(){} // RVA: 0x343E80
        public void get_Offset(){} // RVA: 0x2F8380
        public void set_Offset(){} // RVA: 0x2DEE30
        public void get_Width(){} // RVA: 0x760030
        public void set_Width(){} // RVA: 0x99E0D0
        public void .ctor(){} // RVA: 0x2EE3B40
    }

    public class FixedPointUtilities
    {
        // ── Methods ──
        public void GetCombSize(){} // RVA: 0x9472820
        public void GetFixedPointPreCompInfo(){} // RVA: 0x9472880
        public void Precompute(){} // RVA: 0x9472910
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9472A90
    }

    public class GlvMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9473200
        public void MultiplyPositive(){} // RVA: 0x9473360
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0xCE10
    }

    public class MixedNafR2LMultiplier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4438000 | overloaded x2
        public void MultiplyPositive(){} // RVA: 0x9473590
        public void ConfigureCurve(){} // RVA: 0x94737C0
    }

    public class MontgomeryLadderMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x94738E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NafL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9473C00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NafR2LMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9473D80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PreCompInfo
    {
    }

    public class ReferenceMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9473F00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ValidityPreCompInfo
    {
        // ── Methods ──
        public void HasFailed(){} // RVA: 0x3A75E0
        public void ReportFailed(){} // RVA: 0x6BD7E0
        public void HasCurveEquationPassed(){} // RVA: 0x543460
        public void ReportCurveEquationPassed(){} // RVA: 0x570B10
        public void HasOrderPassed(){} // RVA: 0x195A940
        public void ReportOrderPassed(){} // RVA: 0x9473F20
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9473F30
    }

    public class WNafL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9473FE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class WNafPreCompInfo
    {
        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0x9474410
        public void get_PromotionCountdown(){} // RVA: 0x5F2AEC0
        public void set_PromotionCountdown(){} // RVA: 0x5E0E890
        public void get_IsPromoted(){} // RVA: 0x9474430
        public void get_ConfWidth(){} // RVA: 0x8ABED0
        public void set_ConfWidth(){} // RVA: 0x8AC660
        public void get_PreComp(){} // RVA: 0x2E07C0
        public void set_PreComp(){} // RVA: 0x343E80
        public void get_PreCompNeg(){} // RVA: 0x30B0C0
        public void set_PreCompNeg(){} // RVA: 0x30B0D0
        public void get_Twice(){} // RVA: 0x30B130
        public void set_Twice(){} // RVA: 0x2DEE90
        public void get_Width(){} // RVA: 0x338CD0
        public void set_Width(){} // RVA: 0x338CE0
        public void .ctor(){} // RVA: 0x9474440
    }

    public class WNafUtilities
    {
        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x9474460
        public void GenerateCompactNaf(){} // RVA: 0x9474680
        public void GenerateCompactWindowNaf(){} // RVA: 0x9474960
        public void GenerateJsf(){} // RVA: 0x9474C90
        public void GenerateNaf(){} // RVA: 0x9475090
        public void GenerateWindowNaf(){} // RVA: 0x9475220
        public void GetNafWeight(){} // RVA: 0x9475610
        public void GetWNafPreCompInfo(){} // RVA: 0x94757B0 | overloaded x2
        public void GetWindowSize(){} // RVA: 0x94759A0 | overloaded x4
        public void MapPointWithPrecomp(){} // RVA: 0x9475A50
        public void Precompute(){} // RVA: 0x9475C30
        public void PrecomputeWithPointMap(){} // RVA: 0x9475DC0
        public void Trim(){} // RVA: 0x9476090 | overloaded x2
        public void ResizeTable(){} // RVA: 0x9476110
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9476190
    }

    public class WTauNafMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9477DE0
        public void MultiplyWTnaf(){} // RVA: 0x94781F0
        public void MultiplyFromWTnaf(){} // RVA: 0x94783B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9478990
    }

    public class WTauNafPreCompInfo
    {
        // ── Methods ──
        public void get_PreComp(){} // RVA: 0x2F8380
        public void set_PreComp(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ZSignedDigitL2RMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9478B30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ZSignedDigitR2LMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x9478C50
        public void .ctor(){} // RVA: 0x2DD310
    }

}