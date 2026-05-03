// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 3
// Methods: 95

namespace ThirdParty.Unity.UnityEngine
{
    public class QualitySettings : Object
    {
        public System.Action`2<int,int> activeQualityLevelChanged;
        public object field_1; // 0xAD8
        public object field_2; // 0xB88
        public object field_3; // 0xC38
        public object field_4; // 0xCE8
        public object field_5; // 0xD98
        public object field_6; // 0xE48
        public object field_7; // 0xEF8
        public object field_8; // 0xFA8
        public object field_9; // 0x1000
        public object field_10; // 0x10B0
        public object field_11; // 0x1160
        public object field_12; // 0x1210
        public object field_13; // 0x12C0
        public object field_14;
        public object field_15; // 0x1370
        public object field_16;
        public object field_17; // 0x14D0

        // ── Methods ──
        public void OnActiveQualityLevelChanged(){} // RVA: 0x7FFE87C1AB30
        public void IncreaseLevel(){} // RVA: 0x7FFE87C1AD30 | overloaded x2
        public void DecreaseLevel(){} // RVA: 0x7FFE87C1ADD0 | overloaded x2
        public void SetQualityLevel(){} // RVA: 0x7FFE87C1B930 | overloaded x2
        public void ForEach(){} // RVA: 0x7FFE87C1AE70
        public void get_pixelLightCount(){} // RVA: 0x7FFE87C1B010
        public void set_pixelLightCount(){} // RVA: 0x7FFE87C1B060
        public void get_shadowCascades(){} // RVA: 0x7FFE87C1B0B0
        public void set_shadowCascades(){} // RVA: 0x7FFE87C1B100
        public void get_shadowDistance(){} // RVA: 0x7FFE87C1B150
        public void set_shadowDistance(){} // RVA: 0x7FFE87C1B1A0
        public void get_shadowResolution(){} // RVA: 0x7FFE87C1B200
        public void set_shadowResolution(){} // RVA: 0x7FFE87C1B250
        public void get_shadowCascade2Split(){} // RVA: 0x7FFE87C1B2A0
        public void set_shadowCascade2Split(){} // RVA: 0x7FFE87C1B2F0
        public void get_shadowCascade4Split(){} // RVA: 0x7FFE87C1B350
        public void set_shadowCascade4Split(){} // RVA: 0x7FFE87C1B3B0
        public void get_lodBias(){} // RVA: 0x7FFE87C1B400
        public void set_lodBias(){} // RVA: 0x7FFE87C1B450
        public void get_maximumLODLevel(){} // RVA: 0x7FFE87C1B4B0
        public void get_particleRaycastBudget(){} // RVA: 0x7FFE87C1B500
        public void set_particleRaycastBudget(){} // RVA: 0x7FFE87C1B550
        public void get_vSyncCount(){} // RVA: 0x7FFE87C1B5A0
        public void set_vSyncCount(){} // RVA: 0x7FFE87C1B5F0
        public void get_antiAliasing(){} // RVA: 0x7FFE87C1B640
        public void set_antiAliasing(){} // RVA: 0x7FFE87C1B690
        public void get_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFE87C1B6E0
        public void set_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFE87C1B730
        public void get_count(){} // RVA: 0x7FFE87C1B790
        public void set_streamingMipmapsMemoryBudget(){} // RVA: 0x7FFE87C1B7E0
        public void get_streamingMipmapsMaxLevelReduction(){} // RVA: 0x7FFE87C1B840
        public void set_maxQueuedFrames(){} // RVA: 0x7FFE87C1B890
        public void GetQualityLevel(){} // RVA: 0x7FFE87C1B8E0
        public void get_names(){} // RVA: 0x7FFE87C1B990
        public void get_activeColorSpace(){} // RVA: 0x7FFE87C1B9E0
        public void get_shadowCascade4Split_Injected(){} // RVA: 0x7FFE87C1BA30
        public void set_shadowCascade4Split_Injected(){} // RVA: 0x7FFE87C1BA80
    }

    public class Quaternion : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C

        // ── Methods ──
        public void FromToRotation(){} // RVA: 0x7FFE87C57D50
        public void Inverse(){} // RVA: 0x7FFE87C57DD0
        public void Slerp(){} // RVA: 0x7FFE87C57E40
        public void SlerpUnclamped(){} // RVA: 0x7FFE87C57ED0
        public void Lerp(){} // RVA: 0x7FFE87C57F60
        public void LerpUnclamped(){} // RVA: 0x7FFE87C57FF0
        public void Internal_FromEulerRad(){} // RVA: 0x7FFE87C58080
        public void Internal_ToEulerRad(){} // RVA: 0x7FFE87C580F0
        public void Internal_ToAxisAngleRad(){} // RVA: 0x7FFE87C58160
        public void AngleAxis(){} // RVA: 0x7FFE87C581D0
        public void LookRotation(){} // RVA: 0x7FFE87C582D0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE87C583B0
        public void set_Item(){} // RVA: 0x7FFE87C58440
        public void .ctor(){} // RVA: 0x7FFE8111F570
        public void Set(){} // RVA: 0x7FFE8111F570
        public void get_identity(){} // RVA: 0x7FFE87C584D0
        public void op_Multiply(){} // RVA: 0x7FFE87C58520 | overloaded x2
        public void IsEqualUsingDot(){} // RVA: 0x7FFE87C58690
        public void op_Equality(){} // RVA: 0x7FFE87C586A0
        public void op_Inequality(){} // RVA: 0x7FFE87C58700
        public void Dot(){} // RVA: 0x7FFE87C58760
        public void SetLookRotation(){} // RVA: 0x7FFE87C587A0 | overloaded x2
        public void Angle(){} // RVA: 0x7FFE87C58830
        public void Internal_MakePositive(){} // RVA: 0x7FFE87C588C0
        public void get_eulerAngles(){} // RVA: 0x7FFE81148160
        public void set_eulerAngles(){} // RVA: 0x7FFE816A50B0
        public void Euler(){} // RVA: 0x7FFE81197810 | overloaded x2
        public void ToAngleAxis(){} // RVA: 0x7FFE811711F0
        public void SetFromToRotation(){} // RVA: 0x7FFE87C58950
        public void RotateTowards(){} // RVA: 0x7FFE87C589E0
        public void Normalize(){} // RVA: 0x7FFE87C58C70 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFE87C58CA0
        public void GetHashCode(){} // RVA: 0x7FFE81BDC9F0
        public void Equals(){} // RVA: 0x7FFE82AE64D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87C58D90 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87C58FF0
        public void FromToRotation_Injected(){} // RVA: 0x7FFE87C59040
        public void Inverse_Injected(){} // RVA: 0x7FFE87C590B0
        public void Slerp_Injected(){} // RVA: 0x7FFE87C59110
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFE87C59190
        public void Lerp_Injected(){} // RVA: 0x7FFE87C59210
        public void LerpUnclamped_Injected(){} // RVA: 0x7FFE87C59290
        public void Internal_FromEulerRad_Injected(){} // RVA: 0x7FFE87C59310
        public void Internal_ToEulerRad_Injected(){} // RVA: 0x7FFE87C59370
        public void Internal_ToAxisAngleRad_Injected(){} // RVA: 0x7FFE87C593D0
        public void AngleAxis_Injected(){} // RVA: 0x7FFE87C59440
        public void LookRotation_Injected(){} // RVA: 0x7FFE87C594B0
    }

    public class QueryParameters : ValueType
    {
    }

}