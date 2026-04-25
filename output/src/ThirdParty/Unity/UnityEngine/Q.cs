// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 3
// Methods: 95

namespace ThirdParty.Unity.UnityEngine
{
    public class QualitySettings : Object
    {
        public System.Action`2<int,int> pixelLightCount;

        // ── Methods ──
        public void OnActiveQualityLevelChanged(){} // RVA: 0x7FFAC98724E0
        public void IncreaseLevel(){} // RVA: 0x7FFAC98726E0 | overloaded x2
        public void DecreaseLevel(){} // RVA: 0x7FFAC9872780 | overloaded x2
        public void SetQualityLevel(){} // RVA: 0x7FFAC98732E0 | overloaded x2
        public void ForEach(){} // RVA: 0x7FFAC9872820
        public void get_pixelLightCount(){} // RVA: 0x7FFAC98729C0
        public void set_pixelLightCount(){} // RVA: 0x7FFAC9872A10
        public void get_shadowCascades(){} // RVA: 0x7FFAC9872A60
        public void set_shadowCascades(){} // RVA: 0x7FFAC9872AB0
        public void get_shadowDistance(){} // RVA: 0x7FFAC9872B00
        public void set_shadowDistance(){} // RVA: 0x7FFAC9872B50
        public void get_shadowResolution(){} // RVA: 0x7FFAC9872BB0
        public void set_shadowResolution(){} // RVA: 0x7FFAC9872C00
        public void get_shadowCascade2Split(){} // RVA: 0x7FFAC9872C50
        public void set_shadowCascade2Split(){} // RVA: 0x7FFAC9872CA0
        public void get_shadowCascade4Split(){} // RVA: 0x7FFAC9872D00
        public void set_shadowCascade4Split(){} // RVA: 0x7FFAC9872D60
        public void get_lodBias(){} // RVA: 0x7FFAC9872DB0
        public void set_lodBias(){} // RVA: 0x7FFAC9872E00
        public void get_maximumLODLevel(){} // RVA: 0x7FFAC9872E60
        public void get_particleRaycastBudget(){} // RVA: 0x7FFAC9872EB0
        public void set_particleRaycastBudget(){} // RVA: 0x7FFAC9872F00
        public void get_vSyncCount(){} // RVA: 0x7FFAC9872F50
        public void set_vSyncCount(){} // RVA: 0x7FFAC9872FA0
        public void get_antiAliasing(){} // RVA: 0x7FFAC9872FF0
        public void set_antiAliasing(){} // RVA: 0x7FFAC9873040
        public void get_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFAC9873090
        public void set_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFAC98730E0
        public void get_count(){} // RVA: 0x7FFAC9873140
        public void set_streamingMipmapsMemoryBudget(){} // RVA: 0x7FFAC9873190
        public void get_streamingMipmapsMaxLevelReduction(){} // RVA: 0x7FFAC98731F0
        public void set_maxQueuedFrames(){} // RVA: 0x7FFAC9873240
        public void GetQualityLevel(){} // RVA: 0x7FFAC9873290
        public void get_names(){} // RVA: 0x7FFAC9873340
        public void get_activeColorSpace(){} // RVA: 0x7FFAC9873390
        public void get_shadowCascade4Split_Injected(){} // RVA: 0x7FFAC98733E0
        public void set_shadowCascade4Split_Injected(){} // RVA: 0x7FFAC9873430
    }

    public class Quaternion : ValueType
    {
        public float Item; // 0x10
        public float identity; // 0x14
        public float eulerAngles; // 0x18
        public float normalized; // 0x1C
        public UnityEngine.Quaternion identityQuaternion;
        public float kEpsilon;

        // ── Methods ──
        public void FromToRotation(){} // RVA: 0x7FFAC98AF530
        public void Inverse(){} // RVA: 0x7FFAC98AF5B0
        public void Slerp(){} // RVA: 0x7FFAC98AF620
        public void SlerpUnclamped(){} // RVA: 0x7FFAC98AF6B0
        public void Lerp(){} // RVA: 0x7FFAC98AF740
        public void LerpUnclamped(){} // RVA: 0x7FFAC98AF7D0
        public void Internal_FromEulerRad(){} // RVA: 0x7FFAC98AF860
        public void Internal_ToEulerRad(){} // RVA: 0x7FFAC98AF8D0
        public void Internal_ToAxisAngleRad(){} // RVA: 0x7FFAC98AF940
        public void AngleAxis(){} // RVA: 0x7FFAC98AF9B0
        public void LookRotation(){} // RVA: 0x7FFAC98AFAB0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC98AFB90
        public void set_Item(){} // RVA: 0x7FFAC98AFC20
        public void .ctor(){} // RVA: 0x7FFAC2F45570
        public void Set(){} // RVA: 0x7FFAC2F45570
        public void get_identity(){} // RVA: 0x7FFAC98AFCB0
        public void op_Multiply(){} // RVA: 0x7FFAC98AFD00 | overloaded x2
        public void IsEqualUsingDot(){} // RVA: 0x7FFAC98AFE70
        public void op_Equality(){} // RVA: 0x7FFAC98AFE80
        public void op_Inequality(){} // RVA: 0x7FFAC98AFEE0
        public void Dot(){} // RVA: 0x7FFAC98AFF40
        public void SetLookRotation(){} // RVA: 0x7FFAC98AFF80 | overloaded x2
        public void Angle(){} // RVA: 0x7FFAC98B0010
        public void Internal_MakePositive(){} // RVA: 0x7FFAC98B00A0
        public void get_eulerAngles(){} // RVA: 0x7FFAC2F6E160
        public void set_eulerAngles(){} // RVA: 0x7FFAC3440780
        public void Euler(){} // RVA: 0x7FFAC2FBD810 | overloaded x2
        public void ToAngleAxis(){} // RVA: 0x7FFAC2F971F0
        public void SetFromToRotation(){} // RVA: 0x7FFAC98B0130
        public void RotateTowards(){} // RVA: 0x7FFAC98B01C0
        public void Normalize(){} // RVA: 0x7FFAC98B0450 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFAC98B0480
        public void GetHashCode(){} // RVA: 0x7FFAC3AB0630
        public void Equals(){} // RVA: 0x7FFAC487E150 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC98B0570 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC98B07D0
        public void FromToRotation_Injected(){} // RVA: 0x7FFAC98B0820
        public void Inverse_Injected(){} // RVA: 0x7FFAC98B0890
        public void Slerp_Injected(){} // RVA: 0x7FFAC98B08F0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFAC98B0970
        public void Lerp_Injected(){} // RVA: 0x7FFAC98B09F0
        public void LerpUnclamped_Injected(){} // RVA: 0x7FFAC98B0A70
        public void Internal_FromEulerRad_Injected(){} // RVA: 0x7FFAC98B0AF0
        public void Internal_ToEulerRad_Injected(){} // RVA: 0x7FFAC98B0B50
        public void Internal_ToAxisAngleRad_Injected(){} // RVA: 0x7FFAC98B0BB0
        public void AngleAxis_Injected(){} // RVA: 0x7FFAC98B0C20
        public void LookRotation_Injected(){} // RVA: 0x7FFAC98B0C90
    }

    public class QueryParameters : ValueType
    {
        public int layerMask; // 0x10
        public bool hitMultipleFaces; // 0x14
        public 0x6B2A0218 hitTriggers; // 0x18
        public bool hitBackfaces; // 0x1C
    }

}