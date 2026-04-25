// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.PostFX
// Classes: 2
// Methods: 14

namespace ThirdParty.Cinemachine.Cinemachine.PostFX
{
    public class CinemachinePostProcessing : CinemachineExtension
    {
        public float IsValid;
        public bool m_FocusTracksTarget; // 0x30
        public 0x6658CBD0 m_FocusTracking; // 0x34
        public UnityEngine.Transform m_FocusTarget; // 0x38
        public float m_FocusOffset; // 0x40
        public UnityEngine.Rendering.PostProcessing.PostProcessProfile m_Profile; // 0x48
        public string sVolumeOwnerName; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessVolume> sVolumes; // 0x10
        public System.Collections.Generic.Dictionary`2<Cinemachine.CinemachineBrain,UnityEngine.Rendering.PostProcessing.PostProcessLayer> mBrainToLayer; // 0x18

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFD4FC94D40
        public void InvalidateCachedProfile(){} // RVA: 0x7FFD4FC94E50
        public void OnEnable(){} // RVA: 0x7FFD4FC94F20
        public void OnDestroy(){} // RVA: 0x7FFD4FC95040
        public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC95120
        public void OnCameraCut(){} // RVA: 0x7FFD4FC956F0
        public void ApplyPostFX(){} // RVA: 0x7FFD4FC95840
        public void GetDynamicBrainVolumes(){} // RVA: 0x7FFD4FC95EE0
        public void GetPPLayer(){} // RVA: 0x7FFD4FC96560
        public void CleanupLookupTable(){} // RVA: 0x7FFD4FC969E0
        public void InitializeModule(){} // RVA: 0x7FFD4FC96D30
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD4FC96FE0
    }

    public class CinemachineVolumeSettings : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}