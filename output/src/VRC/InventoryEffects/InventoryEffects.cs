// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.InventoryEffects
// Classes: 9
// Methods: 39

namespace VRC.InventoryEffects
{
    public class DroneSkinMapCore : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class InventoryEffectAssetReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class InventoryEffectDescription : ScriptableObject
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFE80E32650
        public void .ctor(){} // RVA: 0x7FFE81BF25F0
    }

    public class InventoryEffectDescriptionKeys : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LoadingScreenMap : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE882107B0
    }

    public class LocalPositionTracker : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8248F710
        public void Update(){} // RVA: 0x7FFE88210830
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class WarpEffect : MonoBehaviour
    {
        public float _MAX_EYE_HEIGHT;

        // ── Methods ──
        public void add_Completed(){} // RVA: 0x7FFE88210A50
        public void remove_Completed(){} // RVA: 0x7FFE88210B50
        public void get_AudioSources(){} // RVA: 0x7FFE8143BA80
        public void Initialize(){} // RVA: 0x7FFE88210C50
        public void ActivateEffect(){} // RVA: 0x7FFE88211080
        public void SetTrackedTransform(){} // RVA: 0x7FFE810FCE90
        public void SetTrackingScale(){} // RVA: 0x7FFE81C1C3E0
        public void SetAudioEnabled(){} // RVA: 0x7FFE882114C0
        public void SetPoseTracking(){} // RVA: 0x7FFE82444AD0
        public void DeactivateEffect(){} // RVA: 0x7FFE88211570
        public void SetLooping(){} // RVA: 0x7FFE81124030
        public void Update(){} // RVA: 0x7FFE882116C0
        public void UpdateTrackedTransform(){} // RVA: 0x7FFE88211CF0
        public void UpdatePoseTracking(){} // RVA: 0x7FFE88212610
        public void UpdateCachedPoses(){} // RVA: 0x7FFE882127A0
        public void IsCompleted(){} // RVA: 0x7FFE882128A0
        public void .ctor(){} // RVA: 0x7FFE88212940
    }

    public class WarpEffectMap : MonoBehaviour
    {
        public VRC.InventoryEffects.WarpEffectParams _parameters; // 0x20
        public UnityEngine.Transform _trackedTransform; // 0x28

        // ── Methods ──
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void get_TrackedTransform(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class WarpEffectParams : ScriptableObject
    {
        public 0x666D6754 _poseTrackingFlags; // 0x18
        public float _poseTrackingDuration; // 0x1C
        public bool _centerTrackedTransformVertically; // 0x20
        public UnityEngine.Vector3 _trackedTransformLocalOffset; // 0x24
        public UnityEngine.Vector3 _trackedTransformRemoteOffset; // 0x30
        public float _delayBeforeShowingAvatar; // 0x3C
        public float _delayBeforeDespawningPlayer; // 0x40
        public UnityEngine.Vector3 _previewDistanceFromCamera; // 0x44
        public bool _useReplacementShaderForPreview; // 0x50

        // ── Methods ──
        public void get_PoseTrackingFlags(){} // RVA: 0x7FFE813DB630
        public void get_PoseTrackingDuration(){} // RVA: 0x7FFE811C8570
        public void get_CenterTrackedTransformVertically(){} // RVA: 0x7FFE811E99D0
        public void get_TrackedTransformLocalOffset(){} // RVA: 0x7FFE81156CA0
        public void get_TrackedTransformRemoteOffset(){} // RVA: 0x7FFE828CAED0
        public void get_DelayBeforeShowingAvatar(){} // RVA: 0x7FFE8178C5D0
        public void get_DelayBeforeDespawningPlayer(){} // RVA: 0x7FFE815E8460
        public void get_PreviewDistanceFromCamera(){} // RVA: 0x7FFE81161F70
        public void get_UseReplacementShaderForPreview(){} // RVA: 0x7FFE811B58E0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

}