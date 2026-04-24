// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.PostFX
// Classes: 2
// Methods: 14

namespace ThirdParty.Cinemachine.Cinemachine.PostFX
{
    public class CinemachinePostProcessing : CinemachineExtension
    {
        public object m_FocusTracking; // 0x33836D30
        public object m_Profile; // 0x33836D30
        public object mBrainToLayer; // 0x33836D30
        public object IsValid; // 0x170000F7
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void get_IsValid(){} // RVA: 0x7ffaaa27cc50
        public void InvalidateCachedProfile(){} // RVA: 0x7ffaaa27cd60
        public void OnEnable(){} // RVA: 0x7ffaaa27ce30
        public void OnDestroy(){} // RVA: 0x7ffaaa27cf50
        public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa27d030
        public void OnCameraCut(){} // RVA: 0x7ffaaa27d600
        public void ApplyPostFX(){} // RVA: 0x7ffaaa27d750
        public void CleanupLookupTable(){} // RVA: 0x7ffaaa27e8f0
        public void InitializeModule(){} // RVA: 0x7ffaaa27ec40
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaaa27eef0
        // ── Binary Analysis Named ──
        public void GetDynamicBrainVolumes(){} // RVA: 0x7ffaaa27ddf0
        public void GetPPLayer(){} // RVA: 0x7ffaaa27e470
    }

    public class CinemachineVolumeSettings : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}