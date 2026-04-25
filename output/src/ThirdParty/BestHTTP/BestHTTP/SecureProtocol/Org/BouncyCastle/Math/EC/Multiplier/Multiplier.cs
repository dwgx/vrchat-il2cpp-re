// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
// Classes: 22
// Methods: 94

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
    public class AbstractECMultiplier : Object
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFACBA7AF00
        public void MultiplyPositive(){} // RVA: 0x7FFAC2C6A6F0
        public void CheckResult(){} // RVA: 0x7FFACBA7B010
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DoubleAddMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7B090
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECMultiplier
    {
        // ── Methods ──
        public void Multiply(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class FixedPointCombMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7B2F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FixedPointPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint LookupTable; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECLookupTable Offset; // 0x18
        public int Width; // 0x20

        // ── Methods ──
        public void get_LookupTable(){} // RVA: 0x7FFAC2F247C0
        public void set_LookupTable(){} // RVA: 0x7FFAC2F87E80
        public void get_Offset(){} // RVA: 0x7FFAC2F3C380
        public void set_Offset(){} // RVA: 0x7FFAC2F22E30
        public void get_Width(){} // RVA: 0x7FFAC30DBBE0
        public void set_Width(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC5875C30
    }

    public class FixedPointUtilities : Object
    {
        public string PRECOMP_NAME;

        // ── Methods ──
        public void GetCombSize(){} // RVA: 0x7FFACBA7B5D0
        public void GetFixedPointPreCompInfo(){} // RVA: 0x7FFACBA7B630
        public void Precompute(){} // RVA: 0x7FFACBA7B6C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA7B840
    }

    public class GlvMultiplier : AbstractECMultiplier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve curve; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA7BFB0
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7C110
    }

    public class IPreCompCallback
    {
        // ── Methods ──
        public void Precompute(){} // RVA: 0x7FFAC2C58F40
    }

    public class MixedNafR2LMultiplier : AbstractECMultiplier
    {
        public int additionCoord; // 0x10
        public int doublingCoord; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CEC5A0 | overloaded x2
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7C340
        public void ConfigureCurve(){} // RVA: 0x7FFACBA7C570
    }

    public class MontgomeryLadderMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7C690
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7C9B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NafR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7CB30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PreCompInfo
    {
    }

    public class ReferenceMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7CCB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ValidityPreCompInfo : Object
    {
        public string PRECOMP_NAME;
        public bool failed; // 0x10
        public bool curveEquationPassed; // 0x11
        public bool orderPassed; // 0x12

        // ── Methods ──
        public void HasFailed(){} // RVA: 0x7FFAC2FEB5E0
        public void ReportFailed(){} // RVA: 0x7FFAC322C870
        public void HasCurveEquationPassed(){} // RVA: 0x7FFAC3771DA0
        public void ReportCurveEquationPassed(){} // RVA: 0x7FFAC47A90B0
        public void HasOrderPassed(){} // RVA: 0x7FFAC3AE1A90
        public void ReportOrderPassed(){} // RVA: 0x7FFACBA7CCD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA7CCE0
    }

    public class WNafL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA7CD90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class WNafPreCompInfo : Object
    {
        public int PromotionCountdown; // 0x10
        public int IsPromoted; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] ConfWidth; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] PreComp; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint PreCompNeg; // 0x28
        public int Twice; // 0x30

        // ── Methods ──
        public void DecrementPromotionCountdown(){} // RVA: 0x7FFACBA7D1C0
        public void get_PromotionCountdown(){} // RVA: 0x7FFAC86C2530
        public void set_PromotionCountdown(){} // RVA: 0x7FFAC85A5EF0
        public void get_IsPromoted(){} // RVA: 0x7FFACBA7D1E0
        public void get_ConfWidth(){} // RVA: 0x7FFAC33D5A20
        public void set_ConfWidth(){} // RVA: 0x7FFAC33D4990
        public void get_PreComp(){} // RVA: 0x7FFAC2F247C0
        public void set_PreComp(){} // RVA: 0x7FFAC2F87E80
        public void get_PreCompNeg(){} // RVA: 0x7FFAC2F4F0C0
        public void set_PreCompNeg(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Twice(){} // RVA: 0x7FFAC2F4F130
        public void set_Twice(){} // RVA: 0x7FFAC2F22E90
        public void get_Width(){} // RVA: 0x7FFAC2F7CCD0
        public void set_Width(){} // RVA: 0x7FFAC2F7CCE0
        public void .ctor(){} // RVA: 0x7FFACBA7D1F0
    }

    public class WNafUtilities : Object
    {
        public string PRECOMP_NAME;
        public int[] DEFAULT_WINDOW_SIZE_CUTOFFS; // 0x8
        public int MAX_WIDTH; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] EMPTY_POINTS; // 0x18

        // ── Methods ──
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBA7D210
        public void GenerateCompactNaf(){} // RVA: 0x7FFACBA7D430
        public void GenerateCompactWindowNaf(){} // RVA: 0x7FFACBA7D710
        public void GenerateJsf(){} // RVA: 0x7FFACBA7DA40
        public void GenerateNaf(){} // RVA: 0x7FFACBA7DE40
        public void GenerateWindowNaf(){} // RVA: 0x7FFACBA7DFD0
        public void GetNafWeight(){} // RVA: 0x7FFACBA7E3C0
        public void GetWNafPreCompInfo(){} // RVA: 0x7FFACBA7E560 | overloaded x2
        public void GetWindowSize(){} // RVA: 0x7FFACBA7E750 | overloaded x4
        public void MapPointWithPrecomp(){} // RVA: 0x7FFACBA7E800
        public void Precompute(){} // RVA: 0x7FFACBA7E9E0
        public void PrecomputeWithPointMap(){} // RVA: 0x7FFACBA7EB70
        public void Trim(){} // RVA: 0x7FFACBA7EE40 | overloaded x2
        public void ResizeTable(){} // RVA: 0x7FFACBA7EEC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA7EF40
    }

    public class WTauNafMultiplier : AbstractECMultiplier
    {
        public string PRECOMP_NAME;

        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA80B90
        public void MultiplyWTnaf(){} // RVA: 0x7FFACBA80FA0
        public void MultiplyFromWTnaf(){} // RVA: 0x7FFACBA81160
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA81740
    }

    public class WTauNafPreCompInfo : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.AbstractF2mPoint[] PreComp; // 0x10

        // ── Methods ──
        public void get_PreComp(){} // RVA: 0x7FFAC2F3C380
        public void set_PreComp(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ZSignedDigitL2RMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA818E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ZSignedDigitR2LMultiplier : AbstractECMultiplier
    {
        // ── Methods ──
        public void MultiplyPositive(){} // RVA: 0x7FFACBA81A00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}