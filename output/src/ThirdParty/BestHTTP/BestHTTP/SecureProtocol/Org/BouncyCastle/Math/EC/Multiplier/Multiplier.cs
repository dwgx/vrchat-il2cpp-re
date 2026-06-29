// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 21
// Methods: 88

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier : Object
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0xA111990
        public void MultiplyPositive(){} // RVA: 0x87C5F0
        public void CheckResult(){} // RVA: 0xA111AA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DoubleAddMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA111B20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x87C5F0
    }

    public class FixedPointCombMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA111D90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FixedPointPreCompInfo : Object
    {
        public object m_offset;
        public object m_lookupTable;
        public object m_width;

        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0xB465B0
        public void set_LookupTable(){} // RVA: 0xBA9BA0
        public void get_Offset(){} // RVA: 0xB5DBF0
        public void set_Offset(){} // RVA: 0xB44D60
        public void get_Width(){} // RVA: 0xFEAE90
        public void set_Width(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0x3928BD0
    }

    public class FixedPointUtilities : Object
    {
        public object PRECOMP_NAME;

        // ── Methods ──
        public void GetCombSize(){} // RVA: 0xA112070
        public void GetFixedPointPreCompInfo(){} // RVA: 0xA1120D0
        public void Precompute(){} // RVA: 0xA112150
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1122D0
    }

    public class GlvMultiplier : AbstractECMultiplier
    {
        public object curve;
        public object glvEndomorphism;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA112AB0
        public void MultiplyPositive(){} // RVA: 0xA112C10
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0x87C540
    }

    public class MixedNafR2LMultiplier : AbstractECMultiplier
    {
        public object additionCoord;
        public object doublingCoord;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F358F0
        public void MultiplyPositive(){} // RVA: 0xA112E40
        public void ConfigureCurve(){} // RVA: 0xA113070
    }

    public class MontgomeryLadderMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA113190
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA1134C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA113650
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReferenceMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA1137D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ValidityPreCompInfo : Object
    {
        public object PRECOMP_NAME;
        public object failed;
        public object curveEquationPassed;
        public object orderPassed;

        // ── Methods ──
        public void HasFailed(){} // RVA: 0xC120A0
        public void ReportFailed(){} // RVA: 0xF482F0
        public void HasCurveEquationPassed(){} // RVA: 0xDD5C50
        public void ReportCurveEquationPassed(){} // RVA: 0xE02D30
        public void HasOrderPassed(){} // RVA: 0x22201E0
        public void ReportOrderPassed(){} // RVA: 0xA1137F0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA113800
    }

    public class WNafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA1138B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class WNafPreCompInfo : Object
    {
        public object m_promotionCountdown;
        public object m_confWidth;
        public object m_preComp;
        public object m_preCompNeg;
        public object m_twice;
        public object m_width;

        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0xA113C90
        public void get_PromotionCountdown(){} // RVA: 0x69A2AA0
        public void set_PromotionCountdown(){} // RVA: 0x6888150
        public void get_IsPromoted(){} // RVA: 0xA113CB0
        public void get_ConfWidth(){} // RVA: 0x116A650
        public void set_ConfWidth(){} // RVA: 0x116BB10
        public void get_PreComp(){} // RVA: 0xB465B0
        public void set_PreComp(){} // RVA: 0xBA9BA0
        public void get_PreCompNeg(){} // RVA: 0xB700F0
        public void set_PreCompNeg(){} // RVA: 0xB70100
        public void get_Twice(){} // RVA: 0xB70160
        public void set_Twice(){} // RVA: 0xB44DC0
        public void get_Width(){} // RVA: 0xB9E080
        public void set_Width(){} // RVA: 0xB9E090
        public void .ctor(){} // RVA: 0xA113CC0
    }

    public class WNafUtilities : Object
    {
        public object PRECOMP_NAME;
        public object DEFAULT_WINDOW_SIZE_CUTOFFS;
        public object MAX_WIDTH;
        public object EMPTY_POINTS;

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0xA113CE0
        public void GenerateCompactNaf(){} // RVA: 0xA113F00
        public void GenerateCompactWindowNaf(){} // RVA: 0xA1141F0
        public void GenerateJsf(){} // RVA: 0xA114530
        public void GenerateNaf(){} // RVA: 0xA114950
        public void GenerateWindowNaf(){} // RVA: 0xA114B40
        public void GetNafWeight(){} // RVA: 0xA114DF0
        public void GetWNafPreCompInfo(){} // RVA: 0xA114F80
        public void GetWindowSize(){} // RVA: 0xA115160
        public void MapPointWithPrecomp(){} // RVA: 0xA115210
        public void Precompute(){} // RVA: 0xA1153F0
        public void PrecomputeWithPointMap(){} // RVA: 0xA115590
        public void Trim(){} // RVA: 0xA115860
        public void ResizeTable(){} // RVA: 0xA1158E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA115960
    }

    public class WTauNafMultiplier : AbstractECMultiplier
    {
        public object PRECOMP_NAME;

        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA1176B0
        public void MultiplyWTnaf(){} // RVA: 0xA117AD0
        public void MultiplyFromWTnaf(){} // RVA: 0xA117C90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA118280
    }

    public class WTauNafPreCompInfo : Object
    {
        public object m_preComp;

        // ── Methods ──
        public void get_PreComp(){} // RVA: 0xB5DBF0
        public void set_PreComp(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ZSignedDigitL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA118420
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ZSignedDigitR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0xA118540
        public void .ctor(){} // RVA: 0xB43310
    }

}