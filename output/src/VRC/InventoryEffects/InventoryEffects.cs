// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 10
// Methods: 40

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        public object Renderer;
        public object Animator;
        public object FrontLeftRotorBone;
        public object FrontRightRotorBone;
        public object BackLeftRotorBone;
        public object BackRightRotorBone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class InventoryEffectAssetReference : Object
    {
        public object Key;
        public object Asset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        public object ContentType;
        public object Assets;

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x310E550
        public void .ctor(){} // RVA: 0x173FE10
    }

    public class InventoryEffectDescriptionKeys : Object
    {
        public object PrimaryMaterial;
        public object ParticleSystem;
        public object PrimaryObject;
        public object SecondaryObject;
        public object PrimaryAudioClip;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        public object Skybox;
        public object BackgroundMusic;
        public object UINormalColor;
        public object UIHighlightColor;
        public object UIPressedColor;
        public object UIDisabledColor;
        public object TransitionBackgroundColor;
        public object Animator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8312CD0
    }

    public class LoadingScreenPreviewOverride : MonoBehaviour
    {
        public object State;
        public object OverrideLocalPosition;
        public object LocalPosition;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        public object _duration;
        public object _targetTransform;
        public object _startTransform;
        public object _endTransform;
        public object _elapsedTime;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x1FF94F0
        public void Update(){} // RVA: 0x8312D50
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WarpEffect : MonoBehaviour
    {
        public object _MAX_EYE_HEIGHT;
        public object _parameters;
        public object _trackedTransform;
        public object _animator;
        public object _audioSources;
        public object _currentMode;
        public object _eyeHeight;
        public object _isTeleport;
        public object _isLocal;
        public object _isPoseTrackingAllowed;
        public object _trackingScale;
        public object _headPoseGetter;
        public object _playerPoseGetter;
        public object _isLoopingEnabled;
        public object _isInitialized;
        public object _cachedHeadPose;
        public object _cachedPlayerPose;
        public object _poseTrackingTimer;
        public object _isLocalHash;
        public object _isTeleportHash;
        public object _isAppearHash;
        public object _activeHash;
        public object _inactiveHash;
        public object _heightHash;
        public object _heightAdjustHash;
        public object _destroyHash;
        public object Completed;

        // ── Methods ──
        public void add_Completed(){} // RVA: 0x8313020
        public void remove_Completed(){} // RVA: 0x8313140
        public void get_AudioSources(){} // RVA: 0xD05CA0
        public void Initialize(){} // RVA: 0x8313260
        public void ActivateEffect(){} // RVA: 0x83134F0
        public void SetTrackedTransform(){} // RVA: 0xB44DC0
        public void SetTrackingScale(){} // RVA: 0x17672E0
        public void SetAudioEnabled(){} // RVA: 0x83138C0
        public void SetPoseTracking(){} // RVA: 0x1FA9F50
        public void DeactivateEffect(){} // RVA: 0x83139D0
        public void SetLooping(){} // RVA: 0xB6B1B0
        public void Update(){} // RVA: 0x8313A50
        public void UpdateTrackedTransform(){} // RVA: 0x8313E40
        public void UpdatePoseTracking(){} // RVA: 0x83147D0
        public void UpdateCachedPoses(){} // RVA: 0x83149E0
        public void IsCompleted(){} // RVA: 0x8314AE0
        public void .ctor(){} // RVA: 0x8314B20
    }

    public class WarpEffectMap : MonoBehaviour
    {
        public object _parameters;
        public object _trackedTransform;

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0xB700F0
        public void get_TrackedTransform(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WarpEffectParams : ScriptableObject
    {
        public object _poseTrackingFlags;
        public object _poseTrackingDuration;
        public object _centerTrackedTransformVertically;
        public object _trackedTransformLocalOffset;
        public object _trackedTransformRemoteOffset;
        public object _delayBeforeShowingAvatar;
        public object _delayBeforeDespawningPlayer;
        public object _previewDistanceFromCamera;
        public object _useReplacementShaderForPreview;

        // ── Methods ──
        public void get_PoseTrackingFlags(){} // RVA: 0xE62D00
        public void get_PoseTrackingDuration(){} // RVA: 0xC152D0
        public void get_CenterTrackedTransformVertically(){} // RVA: 0xC38360
        public void get_TrackedTransformLocalOffset(){} // RVA: 0xB9E050
        public void get_TrackedTransformRemoteOffset(){} // RVA: 0x2408800
        public void get_DelayBeforeShowingAvatar(){} // RVA: 0x12CA360
        public void get_DelayBeforeDespawningPlayer(){} // RVA: 0xD344A0
        public void get_PreviewDistanceFromCamera(){} // RVA: 0xBA9C90
        public void get_UseReplacementShaderForPreview(){} // RVA: 0xC00EC0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

}