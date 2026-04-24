// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 7
// Methods: 37

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        public int parameterCount;
        public m.nformation constructor;

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E07D200
        public void .ctor(){} // RVA: 0x7FFD4EECC310
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5527DE40
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4F5F0AC0
        public void Update(){} // RVA: 0x7FFD5527DEC0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WarpEffect : MonoBehaviour
    {
        public object AudioSources;

        // ── Methods ──
        public void add_Completed(){} // RVA: 0x7FFD5527E0E0
        public void remove_Completed(){} // RVA: 0x7FFD5527E1E0
        public void get_AudioSources(){} // RVA: 0x7FFD4E5F0140
        public void Initialize(){} // RVA: 0x7FFD5527E2E0
        public void ActivateEffect(){} // RVA: 0x7FFD5527E710
        public void SetTrackedTransform(){} // RVA: 0x7FFD4E342E90
        public void SetTrackingScale(){} // RVA: 0x7FFD4EB546A0
        public void SetAudioEnabled(){} // RVA: 0x7FFD5527EB50
        public void SetPoseTracking(){} // RVA: 0x7FFD4F584B40
        public void DeactivateEffect(){} // RVA: 0x7FFD5527EC00
        public void SetLooping(){} // RVA: 0x7FFD4E36A030
        public void Update(){} // RVA: 0x7FFD5527ED50
        public void UpdateTrackedTransform(){} // RVA: 0x7FFD5527F380
        public void UpdatePoseTracking(){} // RVA: 0x7FFD5527FCA0
        public void UpdateCachedPoses(){} // RVA: 0x7FFD5527FE30
        public void IsCompleted(){} // RVA: 0x7FFD5527FF30
        public void .ctor(){} // RVA: 0x7FFD5527FFD0
    }

    public class WarpEffectMap : MonoBehaviour
    {
        public object Parameters;
        public object TrackedTransform;

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFD4E36F0C0
        public void get_TrackedTransform(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WarpEffectParams : ScriptableObject
    {
        public object PoseTrackingFlags;
        public object PoseTrackingDuration;
        public object CenterTrackedTransformVertically;
        public object TrackedTransformLocalOffset;
        public object TrackedTransformRemoteOffset;
        public object DelayBeforeShowingAvatar;
        public object DelayBeforeDespawningPlayer;
        public object PreviewDistanceFromCamera;
        public object UseReplacementShaderForPreview;

        // ── Methods ──
        public void get_PoseTrackingFlags(){} // RVA: 0x7FFD4E577800
        public void get_PoseTrackingDuration(){} // RVA: 0x7FFD4E40E570
        public void get_CenterTrackedTransformVertically(){} // RVA: 0x7FFD4E42F9D0
        public void get_TrackedTransformLocalOffset(){} // RVA: 0x7FFD4E39CCA0
        public void get_TrackedTransformRemoteOffset(){} // RVA: 0x7FFD536EAB40
        public void get_DelayBeforeShowingAvatar(){} // RVA: 0x7FFD4EA5CE20
        public void get_DelayBeforeDespawningPlayer(){} // RVA: 0x7FFD4E5080B0
        public void get_PreviewDistanceFromCamera(){} // RVA: 0x7FFD4E3A7F70
        public void get_UseReplacementShaderForPreview(){} // RVA: 0x7FFD4E3FB8E0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

}