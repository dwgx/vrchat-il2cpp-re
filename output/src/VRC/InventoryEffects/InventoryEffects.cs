// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 9
// Methods: 39

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        public UnityEngine.SkinnedMeshRenderer Renderer; // 0x20
        public UnityEngine.Animator Animator; // 0x28
        public UnityEngine.GameObject FrontLeftRotorBone; // 0x30
        public UnityEngine.GameObject FrontRightRotorBone; // 0x38
        public UnityEngine.GameObject BackLeftRotorBone; // 0x40
        public UnityEngine.GameObject BackRightRotorBone; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class InventoryEffectAssetReference : Object
    {
        public string Key; // 0x10
        public UnityEngine.Object Asset; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        public 0x6B2DBF18 ContentType; // 0x18
        public System.Collections.Generic.List`1<VRC.InventoryEffects.InventoryEffectAssetReference> Assets; // 0x20

        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAC2C5D200
        public void .ctor(){} // RVA: 0x7FFAC3AAC310
    }

    public class InventoryEffectDescriptionKeys : Object
    {
        public string PrimaryMaterial;
        public string ParticleSystem;
        public string PrimaryObject;
        public string SecondaryObject;
        public string PrimaryAudioClip;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        public UnityEngine.Cubemap Skybox; // 0x20
        public UnityEngine.AudioClip BackgroundMusic; // 0x28
        public UnityEngine.Color UINormalColor; // 0x30
        public UnityEngine.Color UIHighlightColor; // 0x40
        public UnityEngine.Color UIPressedColor; // 0x50
        public UnityEngine.Color UIDisabledColor; // 0x60
        public UnityEngine.Color TransitionBackgroundColor; // 0x70
        public UnityEngine.Animator Animator; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E5DE40
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        public float _duration; // 0x20
        public UnityEngine.Transform _targetTransform; // 0x28
        public UnityEngine.Transform _startTransform; // 0x30
        public UnityEngine.Transform _endTransform; // 0x38
        public float _elapsedTime; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC41D0AC0
        public void Update(){} // RVA: 0x7FFAC9E5DEC0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class WarpEffect : MonoBehaviour
    {
        public float AudioSources;
        public VRC.InventoryEffects.WarpEffectParams _parameters; // 0x20
        public UnityEngine.Transform _trackedTransform; // 0x28
        public UnityEngine.Animator _animator; // 0x30
        public UnityEngine.AudioSource[] _audioSources; // 0x38
        public 0x6B2DC180 _currentMode; // 0x40
        public float _eyeHeight; // 0x44
        public bool _isTeleport; // 0x48
        public bool _isLocal; // 0x49
        public bool _isPoseTrackingAllowed; // 0x4A
        public float _trackingScale; // 0x4C
        public System.Func`1<System.Nullable`1<UnityEngine.Pose>> _headPoseGetter; // 0x50
        public System.Func`1<System.Nullable`1<UnityEngine.Pose>> _playerPoseGetter; // 0x58
        public bool _isLoopingEnabled; // 0x60
        public bool _isInitialized; // 0x61
        public UnityEngine.Pose _cachedHeadPose; // 0x64
        public UnityEngine.Pose _cachedPlayerPose; // 0x80
        public float _poseTrackingTimer; // 0x9C
        public int _isLocalHash; // 0xA0
        public int _isTeleportHash; // 0xA4
        public int _isAppearHash; // 0xA8
        public int _activeHash; // 0xAC
        public int _inactiveHash; // 0xB0
        public int _heightHash; // 0xB4
        public int _heightAdjustHash; // 0xB8
        public int _destroyHash; // 0xBC
        public System.Action`1<VRC.InventoryEffects.WarpEffect> Completed; // 0xC0

        // ── Methods ──
        public void add_Completed(){} // RVA: 0x7FFAC9E5E0E0
        public void remove_Completed(){} // RVA: 0x7FFAC9E5E1E0
        public void get_AudioSources(){} // RVA: 0x7FFAC31D0140
        public void Initialize(){} // RVA: 0x7FFAC9E5E2E0
        public void ActivateEffect(){} // RVA: 0x7FFAC9E5E710
        public void SetTrackedTransform(){} // RVA: 0x7FFAC2F22E90
        public void SetTrackingScale(){} // RVA: 0x7FFAC37346A0
        public void SetAudioEnabled(){} // RVA: 0x7FFAC9E5EB50
        public void SetPoseTracking(){} // RVA: 0x7FFAC4164B40
        public void DeactivateEffect(){} // RVA: 0x7FFAC9E5EC00
        public void SetLooping(){} // RVA: 0x7FFAC2F4A030
        public void Update(){} // RVA: 0x7FFAC9E5ED50
        public void UpdateTrackedTransform(){} // RVA: 0x7FFAC9E5F380
        public void UpdatePoseTracking(){} // RVA: 0x7FFAC9E5FCA0
        public void UpdateCachedPoses(){} // RVA: 0x7FFAC9E5FE30
        public void IsCompleted(){} // RVA: 0x7FFAC9E5FF30
        public void .ctor(){} // RVA: 0x7FFAC9E5FFD0
    }

    public class WarpEffectMap : MonoBehaviour
    {
        public VRC.InventoryEffects.WarpEffectParams Parameters; // 0x20
        public UnityEngine.Transform TrackedTransform; // 0x28

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_TrackedTransform(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class WarpEffectParams : ScriptableObject
    {
        public 0x6B2DC288 PoseTrackingFlags; // 0x18
        public float PoseTrackingDuration; // 0x1C
        public bool CenterTrackedTransformVertically; // 0x20
        public UnityEngine.Vector3 TrackedTransformLocalOffset; // 0x24
        public UnityEngine.Vector3 TrackedTransformRemoteOffset; // 0x30
        public float DelayBeforeShowingAvatar; // 0x3C
        public float DelayBeforeDespawningPlayer; // 0x40
        public UnityEngine.Vector3 PreviewDistanceFromCamera; // 0x44
        public bool UseReplacementShaderForPreview; // 0x50

        // ── Methods ──
        public void get_PoseTrackingFlags(){} // RVA: 0x7FFAC3157800
        public void get_PoseTrackingDuration(){} // RVA: 0x7FFAC2FEE570
        public void get_CenterTrackedTransformVertically(){} // RVA: 0x7FFAC300F9D0
        public void get_TrackedTransformLocalOffset(){} // RVA: 0x7FFAC2F7CCA0
        public void get_TrackedTransformRemoteOffset(){} // RVA: 0x7FFAC82CAB40
        public void get_DelayBeforeShowingAvatar(){} // RVA: 0x7FFAC363CE20
        public void get_DelayBeforeDespawningPlayer(){} // RVA: 0x7FFAC30E80B0
        public void get_PreviewDistanceFromCamera(){} // RVA: 0x7FFAC2F87F70
        public void get_UseReplacementShaderForPreview(){} // RVA: 0x7FFAC2FDB8E0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

}