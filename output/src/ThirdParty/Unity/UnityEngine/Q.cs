// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 3
// Methods: 95

namespace ThirdParty.Unity.UnityEngine
{
    public class QualitySettings
    {
        public System.Action`2<int,int> x;

        // ── Methods ──
        public void OnActiveQualityLevelChanged(){} // RVA: 0x70D9E90
        public void IncreaseLevel(){} // RVA: 0x70DA090 | overloaded x2
        public void DecreaseLevel(){} // RVA: 0x70DA130 | overloaded x2
        public void SetQualityLevel(){} // RVA: 0x70DAC90 | overloaded x2
        public void ForEach(){} // RVA: 0x70DA1D0
        public void get_pixelLightCount(){} // RVA: 0x70DA370
        public void set_pixelLightCount(){} // RVA: 0x70DA3C0
        public void get_shadowCascades(){} // RVA: 0x70DA410
        public void set_shadowCascades(){} // RVA: 0x70DA460
        public void get_shadowDistance(){} // RVA: 0x70DA4B0
        public void set_shadowDistance(){} // RVA: 0x70DA500
        public void get_shadowResolution(){} // RVA: 0x70DA560
        public void set_shadowResolution(){} // RVA: 0x70DA5B0
        public void get_shadowCascade2Split(){} // RVA: 0x70DA600
        public void set_shadowCascade2Split(){} // RVA: 0x70DA650
        public void get_shadowCascade4Split(){} // RVA: 0x70DA6B0
        public void set_shadowCascade4Split(){} // RVA: 0x70DA710
        public void get_lodBias(){} // RVA: 0x70DA760
        public void set_lodBias(){} // RVA: 0x70DA7B0
        public void get_maximumLODLevel(){} // RVA: 0x70DA810
        public void get_particleRaycastBudget(){} // RVA: 0x70DA860
        public void set_particleRaycastBudget(){} // RVA: 0x70DA8B0
        public void get_vSyncCount(){} // RVA: 0x70DA900
        public void set_vSyncCount(){} // RVA: 0x70DA950
        public void get_antiAliasing(){} // RVA: 0x70DA9A0
        public void set_antiAliasing(){} // RVA: 0x70DA9F0
        public void get_resolutionScalingFixedDPIFactor(){} // RVA: 0x70DAA40
        public void set_resolutionScalingFixedDPIFactor(){} // RVA: 0x70DAA90
        public void get_count(){} // RVA: 0x70DAAF0
        public void set_streamingMipmapsMemoryBudget(){} // RVA: 0x70DAB40
        public void get_streamingMipmapsMaxLevelReduction(){} // RVA: 0x70DABA0
        public void set_maxQueuedFrames(){} // RVA: 0x70DABF0
        public void GetQualityLevel(){} // RVA: 0x70DAC40
        public void get_names(){} // RVA: 0x70DACF0
        public void get_activeColorSpace(){} // RVA: 0x70DAD40
        public void get_shadowCascade4Split_Injected(){} // RVA: 0x70DAD90
        public void set_shadowCascade4Split_Injected(){} // RVA: 0x70DADE0
    }

    public class Quaternion
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C

        // ── Methods ──
        public void FromToRotation(){} // RVA: 0x7117090
        public void Inverse(){} // RVA: 0x7117110
        public void Slerp(){} // RVA: 0x7117180
        public void SlerpUnclamped(){} // RVA: 0x7117210
        public void Lerp(){} // RVA: 0x71172A0
        public void LerpUnclamped(){} // RVA: 0x7117330
        public void Internal_FromEulerRad(){} // RVA: 0x71173C0
        public void Internal_ToEulerRad(){} // RVA: 0x7117430
        public void Internal_ToAxisAngleRad(){} // RVA: 0x71174A0
        public void AngleAxis(){} // RVA: 0x7117510
        public void LookRotation(){} // RVA: 0x7117610 | overloaded x2
        public void get_Item(){} // RVA: 0x71176F0
        public void set_Item(){} // RVA: 0x7117780
        public void .ctor(){} // RVA: 0x301570
        public void Set(){} // RVA: 0x301570
        public void get_identity(){} // RVA: 0x7117810
        public void op_Multiply(){} // RVA: 0x7117860 | overloaded x2
        public void IsEqualUsingDot(){} // RVA: 0x71179D0
        public void op_Equality(){} // RVA: 0x71179E0
        public void op_Inequality(){} // RVA: 0x7117A40
        public void Dot(){} // RVA: 0x7117AA0
        public void SetLookRotation(){} // RVA: 0x7117AE0 | overloaded x2
        public void Angle(){} // RVA: 0x7117B70
        public void Internal_MakePositive(){} // RVA: 0x7117C00
        public void get_eulerAngles(){} // RVA: 0x32A160
        public void set_eulerAngles(){} // RVA: 0x8F2F60
        public void Euler(){} // RVA: 0x379810 | overloaded x2
        public void ToAngleAxis(){} // RVA: 0x3531F0
        public void SetFromToRotation(){} // RVA: 0x7117C90
        public void RotateTowards(){} // RVA: 0x7117D20
        public void Normalize(){} // RVA: 0x7117FB0 | overloaded x2
        public void get_normalized(){} // RVA: 0x7117FE0
        public void GetHashCode(){} // RVA: 0xE7CB90
        public void Equals(){} // RVA: 0x1D58650 | overloaded x2
        public void ToString(){} // RVA: 0x71180D0 | overloaded x3
        public void .cctor(){} // RVA: 0x7118330
        public void FromToRotation_Injected(){} // RVA: 0x7118380
        public void Inverse_Injected(){} // RVA: 0x71183F0
        public void Slerp_Injected(){} // RVA: 0x7118450
        public void SlerpUnclamped_Injected(){} // RVA: 0x71184D0
        public void Lerp_Injected(){} // RVA: 0x7118550
        public void LerpUnclamped_Injected(){} // RVA: 0x71185D0
        public void Internal_FromEulerRad_Injected(){} // RVA: 0x7118650
        public void Internal_ToEulerRad_Injected(){} // RVA: 0x71186B0
        public void Internal_ToAxisAngleRad_Injected(){} // RVA: 0x7118710
        public void AngleAxis_Injected(){} // RVA: 0x7118780
        public void LookRotation_Injected(){} // RVA: 0x71187F0
    }

    public class QueryParameters
    {
    }

}