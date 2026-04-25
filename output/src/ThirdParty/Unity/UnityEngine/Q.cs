// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 2
// Methods: 95

namespace ThirdParty.Unity.UnityEngine
{
    public class QualitySettings : Object
    {
        public object pixelLightCount;
        public object shadowCascades;
        public object shadowDistance;
        public object shadowResolution;
        public object shadowCascade2Split;
        public object shadowCascade4Split;
        public object lodBias;
        public object maximumLODLevel;
        public object particleRaycastBudget;
        public object vSyncCount;
        public object antiAliasing;
        public object resolutionScalingFixedDPIFactor;
        public object count;
        public object streamingMipmapsMemoryBudget;
        public object streamingMipmapsMaxLevelReduction;
        public object maxQueuedFrames;
        public object names;
        public object activeColorSpace;

        // ── Methods ──
        public void OnActiveQualityLevelChanged(){} // RVA: 0x7FFD54C924E0
        public void IncreaseLevel(){} // RVA: 0x7FFD54C926E0 | overloaded x2
        public void DecreaseLevel(){} // RVA: 0x7FFD54C92780 | overloaded x2
        public void SetQualityLevel(){} // RVA: 0x7FFD54C932E0 | overloaded x2
        public void ForEach(){} // RVA: 0x7FFD54C92820
        public void get_pixelLightCount(){} // RVA: 0x7FFD54C929C0
        public void set_pixelLightCount(){} // RVA: 0x7FFD54C92A10
        public void get_shadowCascades(){} // RVA: 0x7FFD54C92A60
        public void set_shadowCascades(){} // RVA: 0x7FFD54C92AB0
        public void get_shadowDistance(){} // RVA: 0x7FFD54C92B00
        public void set_shadowDistance(){} // RVA: 0x7FFD54C92B50
        public void get_shadowResolution(){} // RVA: 0x7FFD54C92BB0
        public void set_shadowResolution(){} // RVA: 0x7FFD54C92C00
        public void get_shadowCascade2Split(){} // RVA: 0x7FFD54C92C50
        public void set_shadowCascade2Split(){} // RVA: 0x7FFD54C92CA0
        public void get_shadowCascade4Split(){} // RVA: 0x7FFD54C92D00
        public void set_shadowCascade4Split(){} // RVA: 0x7FFD54C92D60
        public void get_lodBias(){} // RVA: 0x7FFD54C92DB0
        public void set_lodBias(){} // RVA: 0x7FFD54C92E00
        public void get_maximumLODLevel(){} // RVA: 0x7FFD54C92E60
        public void get_particleRaycastBudget(){} // RVA: 0x7FFD54C92EB0
        public void set_particleRaycastBudget(){} // RVA: 0x7FFD54C92F00
        public void get_vSyncCount(){} // RVA: 0x7FFD54C92F50
        public void set_vSyncCount(){} // RVA: 0x7FFD54C92FA0
        public void get_antiAliasing(){} // RVA: 0x7FFD54C92FF0
        public void set_antiAliasing(){} // RVA: 0x7FFD54C93040
        public void get_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFD54C93090
        public void set_resolutionScalingFixedDPIFactor(){} // RVA: 0x7FFD54C930E0
        public void get_count(){} // RVA: 0x7FFD54C93140
        public void set_streamingMipmapsMemoryBudget(){} // RVA: 0x7FFD54C93190
        public void get_streamingMipmapsMaxLevelReduction(){} // RVA: 0x7FFD54C931F0
        public void set_maxQueuedFrames(){} // RVA: 0x7FFD54C93240
        public void GetQualityLevel(){} // RVA: 0x7FFD54C93290
        public void get_names(){} // RVA: 0x7FFD54C93340
        public void get_activeColorSpace(){} // RVA: 0x7FFD54C93390
        public void get_shadowCascade4Split_Injected(){} // RVA: 0x7FFD54C933E0
        public void set_shadowCascade4Split_Injected(){} // RVA: 0x7FFD54C93430
    }

    public class Quaternion : ValueType
    {
        public object Item;
        public object identity;
        public object eulerAngles;
        public object normalized;

        // ── Methods ──
        public void FromToRotation(){} // RVA: 0x7FFD54CCF530
        public void Inverse(){} // RVA: 0x7FFD54CCF5B0
        public void Slerp(){} // RVA: 0x7FFD54CCF620
        public void SlerpUnclamped(){} // RVA: 0x7FFD54CCF6B0
        public void Lerp(){} // RVA: 0x7FFD54CCF740
        public void LerpUnclamped(){} // RVA: 0x7FFD54CCF7D0
        public void Internal_FromEulerRad(){} // RVA: 0x7FFD54CCF860
        public void Internal_ToEulerRad(){} // RVA: 0x7FFD54CCF8D0
        public void Internal_ToAxisAngleRad(){} // RVA: 0x7FFD54CCF940
        public void AngleAxis(){} // RVA: 0x7FFD54CCF9B0
        public void LookRotation(){} // RVA: 0x7FFD54CCFAB0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD54CCFB90
        public void set_Item(){} // RVA: 0x7FFD54CCFC20
        public void .ctor(){} // RVA: 0x7FFD4E365570
        public void Set(){} // RVA: 0x7FFD4E365570
        public void get_identity(){} // RVA: 0x7FFD54CCFCB0
        public void op_Multiply(){} // RVA: 0x7FFD54CCFD00 | overloaded x2
        public void IsEqualUsingDot(){} // RVA: 0x7FFD54CCFE70
        public void op_Equality(){} // RVA: 0x7FFD54CCFE80
        public void op_Inequality(){} // RVA: 0x7FFD54CCFEE0
        public void Dot(){} // RVA: 0x7FFD54CCFF40
        public void SetLookRotation(){} // RVA: 0x7FFD54CCFF80 | overloaded x2
        public void Angle(){} // RVA: 0x7FFD54CD0010
        public void Internal_MakePositive(){} // RVA: 0x7FFD54CD00A0
        public void get_eulerAngles(){} // RVA: 0x7FFD4E38E160
        public void set_eulerAngles(){} // RVA: 0x7FFD4E860780
        public void Euler(){} // RVA: 0x7FFD4E3DD810 | overloaded x2
        public void ToAngleAxis(){} // RVA: 0x7FFD4E3B71F0
        public void SetFromToRotation(){} // RVA: 0x7FFD54CD0130
        public void RotateTowards(){} // RVA: 0x7FFD54CD01C0
        public void Normalize(){} // RVA: 0x7FFD54CD0450 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFD54CD0480
        public void GetHashCode(){} // RVA: 0x7FFD4EED0630
        public void Equals(){} // RVA: 0x7FFD4FC9E150 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54CD0570 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54CD07D0
        public void FromToRotation_Injected(){} // RVA: 0x7FFD54CD0820
        public void Inverse_Injected(){} // RVA: 0x7FFD54CD0890
        public void Slerp_Injected(){} // RVA: 0x7FFD54CD08F0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFD54CD0970
        public void Lerp_Injected(){} // RVA: 0x7FFD54CD09F0
        public void LerpUnclamped_Injected(){} // RVA: 0x7FFD54CD0A70
        public void Internal_FromEulerRad_Injected(){} // RVA: 0x7FFD54CD0AF0
        public void Internal_ToEulerRad_Injected(){} // RVA: 0x7FFD54CD0B50
        public void Internal_ToAxisAngleRad_Injected(){} // RVA: 0x7FFD54CD0BB0
        public void AngleAxis_Injected(){} // RVA: 0x7FFD54CD0C20
        public void LookRotation_Injected(){} // RVA: 0x7FFD54CD0C90
    }

}