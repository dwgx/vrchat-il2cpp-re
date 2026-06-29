// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 4
// Methods: 114

namespace ThirdParty.Unity.UnityEngine
{
    public class QualitySettings : Object
    {
        public object activeQualityLevelChanged;

        // ── Methods ──
        public void OnActiveQualityLevelChanged(){} // RVA: 0x7B823F0
        public void IncreaseLevel(){} // RVA: 0x7B825F0
        public void DecreaseLevel(){} // RVA: 0x7B82690
        public void SetQualityLevel(){} // RVA: 0x7B831F0
        public void ForEach(){} // RVA: 0x7B82730
        public void get_pixelLightCount(){} // RVA: 0x7B828D0
        public void set_pixelLightCount(){} // RVA: 0x7B82920
        public void get_shadowCascades(){} // RVA: 0x7B82970
        public void set_shadowCascades(){} // RVA: 0x7B829C0
        public void get_shadowDistance(){} // RVA: 0x7B82A10
        public void set_shadowDistance(){} // RVA: 0x7B82A60
        public void get_shadowResolution(){} // RVA: 0x7B82AC0
        public void set_shadowResolution(){} // RVA: 0x7B82B10
        public void get_shadowCascade2Split(){} // RVA: 0x7B82B60
        public void set_shadowCascade2Split(){} // RVA: 0x7B82BB0
        public void get_shadowCascade4Split(){} // RVA: 0x7B82C10
        public void set_shadowCascade4Split(){} // RVA: 0x7B82C70
        public void get_lodBias(){} // RVA: 0x7B82CC0
        public void set_lodBias(){} // RVA: 0x7B82D10
        public void get_maximumLODLevel(){} // RVA: 0x7B82D70
        public void get_particleRaycastBudget(){} // RVA: 0x7B82DC0
        public void set_particleRaycastBudget(){} // RVA: 0x7B82E10
        public void get_vSyncCount(){} // RVA: 0x7B82E60
        public void set_vSyncCount(){} // RVA: 0x7B82EB0
        public void get_antiAliasing(){} // RVA: 0x7B82F00
        public void set_antiAliasing(){} // RVA: 0x7B82F50
        public void get_resolutionScalingFixedDPIFactor(){} // RVA: 0x7B82FA0
        public void set_resolutionScalingFixedDPIFactor(){} // RVA: 0x7B82FF0
        public void get_count(){} // RVA: 0x7B83050
        public void set_streamingMipmapsMemoryBudget(){} // RVA: 0x7B830A0
        public void get_streamingMipmapsMaxLevelReduction(){} // RVA: 0x7B83100
        public void set_maxQueuedFrames(){} // RVA: 0x7B83150
        public void GetQualityLevel(){} // RVA: 0x7B831A0
        public void get_names(){} // RVA: 0x7B83250
        public void get_activeColorSpace(){} // RVA: 0x7B832A0
        public void get_shadowCascade4Split_Injected(){} // RVA: 0x7B832F0
        public void set_shadowCascade4Split_Injected(){} // RVA: 0x7B83340
    }

    public class QualitySettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Quaternion : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object w;
        public object identityQuaternion;
        public object kEpsilon;

        // ── Methods ──
        public void FromToRotation(){} // RVA: 0x7BE8800
        public void Inverse(){} // RVA: 0x7BE8880
        public void Slerp(){} // RVA: 0x7BE88F0
        public void SlerpUnclamped(){} // RVA: 0x7BE8980
        public void Lerp(){} // RVA: 0x7BE8A10
        public void LerpUnclamped(){} // RVA: 0x7BE8AA0
        public void Internal_FromEulerRad(){} // RVA: 0x7BE8B30
        public void Internal_ToEulerRad(){} // RVA: 0x7BE8BA0
        public void Internal_ToAxisAngleRad(){} // RVA: 0x7BE8C10
        public void AngleAxis(){} // RVA: 0x7BE8C80
        public void LookRotation(){} // RVA: 0x7BE8D80
        public void get_Item(){} // RVA: 0x9649D0
        public void set_Item(){} // RVA: 0x9649E0
        public void .ctor(){} // RVA: 0x4FE0
        public void Set(){} // RVA: 0x4FE0
        public void get_identity(){} // RVA: 0x7BE8F80
        public void op_Multiply(){} // RVA: 0x7BE8FD0
        public void IsEqualUsingDot(){} // RVA: 0x7BE9140
        public void op_Equality(){} // RVA: 0x7BE9150
        public void op_Inequality(){} // RVA: 0x7BE91B0
        public void Dot(){} // RVA: 0x7BE9210
        public void SetLookRotation(){} // RVA: 0x964A20
        public void Angle(){} // RVA: 0x7BE92E0
        public void Internal_MakePositive(){} // RVA: 0x7BE9370
        public void get_eulerAngles(){} // RVA: 0x964AB0
        public void set_eulerAngles(){} // RVA: 0x964AE0
        public void Euler(){} // RVA: 0xBE0FF0
        public void ToAngleAxis(){} // RVA: 0x964B10
        public void SetFromToRotation(){} // RVA: 0x964B20
        public void RotateTowards(){} // RVA: 0x7BE9490
        public void Normalize(){} // RVA: 0x964BB0
        public void get_normalized(){} // RVA: 0x964BE0
        public void GetHashCode(){} // RVA: 0x964C10
        public void Equals(){} // RVA: 0x963C50
        public void ToString(){} // RVA: 0x964CD0
        public void .cctor(){} // RVA: 0x7BE9A90
        public void FromToRotation_Injected(){} // RVA: 0x7BE9AE0
        public void Inverse_Injected(){} // RVA: 0x7BE9B50
        public void Slerp_Injected(){} // RVA: 0x7BE9BB0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7BE9C30
        public void Lerp_Injected(){} // RVA: 0x7BE9CB0
        public void LerpUnclamped_Injected(){} // RVA: 0x7BE9D30
        public void Internal_FromEulerRad_Injected(){} // RVA: 0x7BE9DB0
        public void Internal_ToEulerRad_Injected(){} // RVA: 0x7BE9E10
        public void Internal_ToAxisAngleRad_Injected(){} // RVA: 0x7BE9E70
        public void AngleAxis_Injected(){} // RVA: 0x7BE9EE0
        public void LookRotation_Injected(){} // RVA: 0x7BE9F50
    }

    public class Quaternion[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB63F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E701F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}