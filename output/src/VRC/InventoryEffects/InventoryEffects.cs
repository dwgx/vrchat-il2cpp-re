// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 7
// Methods: 37

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        public ure Renderer; // 0x20
        public stfix Animator; // 0x28
        public BuffersImpl FrontLeftRotorBone; // 0x30
        public BuffersImpl FrontRightRotorBone; // 0x38
        public BuffersImpl BackLeftRotorBone; // 0x40
        public BuffersImpl BackRightRotorBone; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        public _errorReceived.vokeErrorReceivedCallback_Internal ContentType; // 0x18
        public URA.woDigitYearMax<_errorReceived.okeClockResyncOccurredCallback_Internal> Assets; // 0x20

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E07D200
        public void .ctor(){} // RVA: 0x7FFD4EECC310
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        public tmapST Skybox; // 0x20
        public ies BackgroundMusic; // 0x28
        public object UINormalColor; // 0x30
        public object UIHighlightColor; // 0x40
        public object UIPressedColor; // 0x50
        public object UIDisabledColor; // 0x60
        public object TransitionBackgroundColor; // 0x70
        public stfix Animator; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5527DE40
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        public float _duration; // 0x20
        public object _targetTransform; // 0x28
        public object _startTransform; // 0x30
        public object _endTransform; // 0x38
        public float _elapsedTime; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4F5F0AC0
        public void Update(){} // RVA: 0x7FFD5527DEC0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WarpEffect : MonoBehaviour
    {
        public float AudioSources;
        public _errorReceived.sterPortal _parameters; // 0x20
        public object _trackedTransform; // 0x28
        public stfix _animator; // 0x30
        public t[] _audioSources; // 0x38
        public lMarker__SystemVoid _currentMode; // 0x40
        public float _eyeHeight; // 0x44
        public bool _isTeleport; // 0x48
        public bool _isLocal; // 0x49
        public bool _isPoseTrackingAllowed; // 0x4A
        public float _trackingScale; // 0x4C
        public ormation<aphy<?>> _headPoseGetter; // 0x50
        public ormation<aphy<?>> _playerPoseGetter; // 0x58
        public bool _isLoopingEnabled; // 0x60
        public bool _isInitialized; // 0x61
        public object _cachedHeadPose; // 0x64
        public object _cachedPlayerPose; // 0x80
        public float _poseTrackingTimer; // 0x9C
        public int _isLocalHash; // 0xA0
        public int _isTeleportHash; // 0xA4
        public int _isAppearHash; // 0xA8
        public int _activeHash; // 0xAC
        public int _inactiveHash; // 0xB0
        public int _heightHash; // 0xB4
        public int _heightAdjustHash; // 0xB8
        public int _destroyHash; // 0xBC
        public ileFullDirectoryInformation<_errorReceived.?> Completed; // 0xC0

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
        public _errorReceived.sterPortal Parameters; // 0x20
        public object TrackedTransform; // 0x28

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFD4E36F0C0
        public void get_TrackedTransform(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WarpEffectParams : ScriptableObject
    {
        public ÌÏÎÎÍÏÍÏÌÏÌÏÎÏÌÍÎÍÍ PoseTrackingFlags; // 0x18
        public float PoseTrackingDuration; // 0x1C
        public bool CenterTrackedTransformVertically; // 0x20
        public amut TrackedTransformLocalOffset; // 0x24
        public amut TrackedTransformRemoteOffset; // 0x30
        public float DelayBeforeShowingAvatar; // 0x3C
        public float DelayBeforeDespawningPlayer; // 0x40
        public amut PreviewDistanceFromCamera; // 0x44
        public bool UseReplacementShaderForPreview; // 0x50

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