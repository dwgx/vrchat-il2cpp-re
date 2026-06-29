// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.PostFX
// Classes: 2
// Methods: 14

namespace ThirdParty.Cinemachine.Cinemachine.PostFX
{
    public class CinemachinePostProcessing : CinemachineExtension
    {
        public object s_VolumePriority;
        public object m_FocusTracksTarget;
        public object m_FocusTracking;
        public object m_FocusTarget;
        public object m_FocusOffset;
        public object m_Profile;
        public object sVolumeOwnerName;
        public object sVolumes;
        public object mBrainToLayer;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x25FD770
        public void InvalidateCachedProfile(){} // RVA: 0x25FD880
        public void OnEnable(){} // RVA: 0x25FD950
        public void OnDestroy(){} // RVA: 0x25FDA80
        public void PostPipelineStageCallback(){} // RVA: 0x25FDB80
        public void OnCameraCut(){} // RVA: 0x25FE140
        public void ApplyPostFX(){} // RVA: 0x25FE250
        public void GetDynamicBrainVolumes(){} // RVA: 0x25FE8C0
        public void GetPPLayer(){} // RVA: 0x25FF1A0
        public void CleanupLookupTable(){} // RVA: 0x25FF5E0
        public void InitializeModule(){} // RVA: 0x25FF940
        public void .ctor(){} // RVA: 0xB43D60
        public void .cctor(){} // RVA: 0x25FFBF0
    }

    public class CinemachineVolumeSettings : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

}