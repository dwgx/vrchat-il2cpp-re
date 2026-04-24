// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 7
// Methods: 37

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        public object FrontLeftRotorBone; // 0x33915B80
        public object BackRightRotorBone; // 0x33915B80

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        // ── Original Methods ──
        public void TryGetValue(){} // RVA: 0x7ffaa864d540
        public void .ctor(){} // RVA: 0x7ffaa94d7100
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        public object UINormalColor; // 0x33C848D0
        public object UIDisabledColor; // 0x33C848D0
        public object _duration; // 0x333CB0A0
        public object _endTransform; // 0x333CB0A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf880860
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        public object _startTransform; // 0x333CB0A0

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa9bf7bf0
        public void Update(){} // RVA: 0x7ffaaf8808e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class WarpEffect : MonoBehaviour
    {
        public object _trackedTransform; // 0x33ACC6E0
        public object _currentMode; // 0x33ACC6E0
        public object _isLocal; // 0x33ACC6E0
        public object _headPoseGetter; // 0x33ACC6E0
        public object _isInitialized; // 0x33ACC6E0
        public object _poseTrackingTimer; // 0x33ACC6E0
        public object _isAppearHash; // 0x33ACC6E0
        public object _heightHash; // 0x33ACC6E0
        public object Completed; // 0x33ACC6E0
        public object X00;

        // ── Original Methods ──
        public void add_Completed(){} // RVA: 0x7ffaaf880b00
        public void remove_Completed(){} // RVA: 0x7ffaaf880c00
        public void get_AudioSources(){} // RVA: 0x7ffaa8bf45b0
        public void Initialize(){} // RVA: 0x7ffaaf880d00
        public void ActivateEffect(){} // RVA: 0x7ffaaf881130
        public void DeactivateEffect(){} // RVA: 0x7ffaaf881620
        public void Update(){} // RVA: 0x7ffaaf881770
        public void UpdateTrackedTransform(){} // RVA: 0x7ffaaf881da0
        public void UpdatePoseTracking(){} // RVA: 0x7ffaaf8826c0
        public void UpdateCachedPoses(){} // RVA: 0x7ffaaf882850
        public void IsCompleted(){} // RVA: 0x7ffaaf882950
        public void .ctor(){} // RVA: 0x7ffaaf8829f0
        // ── Binary Analysis Named ──
        public void SetTrackedTransform(){} // RVA: 0x7ffaa8933e90
        public void SetTrackingScale(){} // RVA: 0x7ffaa9167b70
        public void SetAudioEnabled(){} // RVA: 0x7ffaaf881570
        public void SetPoseTracking(){} // RVA: 0x7ffaa9b8b940
        public void SetLooping(){} // RVA: 0x7ffaa895b030
    }

    public class WarpEffectMap : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_Parameters(){} // RVA: 0x7ffaa89600c0
        public void get_TrackedTransform(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class WarpEffectParams : ScriptableObject
    {
        public object _centerTrackedTransformVertically; // 0x3366D470
        public object _delayBeforeShowingAvatar; // 0x3366D470
        public object _useReplacementShaderForPreview; // 0x3366D470
        public object PoseTrackingFlags; // 0x17000004
        public object PoseTrackingDuration; // 0x17000005
        public object CenterTrackedTransformVertically; // 0x17000006

        // ── Original Methods ──
        public void get_PoseTrackingFlags(){} // RVA: 0x7ffaa8b945a0
        public void get_PoseTrackingDuration(){} // RVA: 0x7ffaa89ff570
        public void get_CenterTrackedTransformVertically(){} // RVA: 0x7ffaa8a209d0
        public void get_TrackedTransformLocalOffset(){} // RVA: 0x7ffaa898dca0
        public void get_TrackedTransformRemoteOffset(){} // RVA: 0x7ffaadcebcf0
        public void get_DelayBeforeShowingAvatar(){} // RVA: 0x7ffaa9068340
        public void get_DelayBeforeDespawningPlayer(){} // RVA: 0x7ffaa8af93a0
        public void get_PreviewDistanceFromCamera(){} // RVA: 0x7ffaa8998f70
        public void get_UseReplacementShaderForPreview(){} // RVA: 0x7ffaa89ec8e0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

}