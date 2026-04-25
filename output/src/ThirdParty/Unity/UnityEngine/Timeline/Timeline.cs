// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 73
// Methods: 785

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public 0x665E2130 postPlayback; // 0x18
        public 0x665E2188 m_InitialState; // 0x1C

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF2AD0
        public void OnBehaviourPlay(){} // RVA: 0x7FFD54BF2D50
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF2E70
        public void ProcessFrame(){} // RVA: 0x7FFD54BF2F80
        public void OnGraphStart(){} // RVA: 0x7FFD54BF30A0
        public void OnPlayableDestroy(){} // RVA: 0x7FFD54BF31D0
        public void .ctor(){} // RVA: 0x7FFD54980410
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        public 0x665E07C0 postPlaybackState; // 0x10
        public bool m_BoundGameObjectInitialStateIsActive; // 0x14
        public UnityEngine.GameObject m_BoundGameObject; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BCC1A0
        public void get_postPlaybackState(){} // RVA: 0x7FFD4E38E5C0
        public void set_postPlaybackState(){} // RVA: 0x7FFD4E3440C0
        public void OnPlayableDestroy(){} // RVA: 0x7FFD54BCC240
        public void ProcessFrame(){} // RVA: 0x7FFD54BCC370
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        public byte[] clipCaps; // 0x18

        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFD4E919180
        public void CreatePlayable(){} // RVA: 0x7FFD54BCC6D0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class ActivationTrack : TrackAsset
    {
        public 0x665E07C0 postPlaybackState; // 0xA0
        public UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer; // 0xA8

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFD54BCC7F0
        public void get_postPlaybackState(){} // RVA: 0x7FFD4FCBE510
        public void set_postPlaybackState(){} // RVA: 0x7FFD54BCC880
        public void CreateTrackMixer(){} // RVA: 0x7FFD54BCC8A0
        public void UpdateTrackMode(){} // RVA: 0x7FFD54BCCAE0
        public void GatherProperties(){} // RVA: 0x7FFD54BCCB00
        public void OnCreateClip(){} // RVA: 0x7FFD54BCCC20
        public void .ctor(){} // RVA: 0x7FFD54BCCCB0
    }

    public class AnimationOutputWeightProcessor : Object
    {
        public UnityEngine.Animations.AnimationPlayableOutput m_Output; // 0x10
        public UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_MotionXPlayable; // 0x20
        public System.Collections.Generic.List`1<0x665E0870> m_Mixers; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BCCD10
        public void FindMixers(){} // RVA: 0x7FFD54BCD0F0 | overloaded x2
        public void Evaluate(){} // RVA: 0x7FFD54BCD500
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        public UnityEngine.AnimationClip position; // 0x18
        public UnityEngine.Vector3 rotation; // 0x20
        public UnityEngine.Vector3 eulerAngles; // 0x2C
        public bool useTrackMatchFields; // 0x38
        public 0x665E0B30 matchTargetFields; // 0x3C
        public bool removeStartOffset; // 0x40
        public bool applyFootIK; // 0x41
        public 0x665E0920 loop; // 0x44
        public 0x665E0BE0 hasRootTransforms; // 0x48
        public int appliedOffsetMode;
        public int clip; // 0x4C
        public UnityEngine.Quaternion duration; // 0x50

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFD4E3A7EE0
        public void set_position(){} // RVA: 0x7FFD4E3A7F00
        public void get_rotation(){} // RVA: 0x7FFD54BCD770
        public void set_rotation(){} // RVA: 0x7FFD54BCD820
        public void get_eulerAngles(){} // RVA: 0x7FFD4E3A7F10
        public void set_eulerAngles(){} // RVA: 0x7FFD4E3A7F30
        public void get_useTrackMatchFields(){} // RVA: 0x7FFD4E5F95D0
        public void set_useTrackMatchFields(){} // RVA: 0x7FFD4E5F95C0
        public void get_matchTargetFields(){} // RVA: 0x7FFD4E7DD4A0
        public void set_matchTargetFields(){} // RVA: 0x7FFD4FC02CD0
        public void get_removeStartOffset(){} // RVA: 0x7FFD4E3FCC00
        public void set_removeStartOffset(){} // RVA: 0x7FFD4E3FCC10
        public void get_applyFootIK(){} // RVA: 0x7FFD4E5F8A60
        public void set_applyFootIK(){} // RVA: 0x7FFD4E5F8A10
        public void get_loop(){} // RVA: 0x7FFD4E3E20A0
        public void set_loop(){} // RVA: 0x7FFD4E3E20B0
        public void get_hasRootTransforms(){} // RVA: 0x7FFD54BCD850
        public void get_appliedOffsetMode(){} // RVA: 0x7FFD4E3E20C0
        public void set_appliedOffsetMode(){} // RVA: 0x7FFD4E3E20D0
        public void get_clip(){} // RVA: 0x7FFD4E3447C0
        public void set_clip(){} // RVA: 0x7FFD54BCD960
        public void get_duration(){} // RVA: 0x7FFD54BCDAB0
        public void get_outputs(){} // RVA: 0x7FFD54BCDB60
        public void CreatePlayable(){} // RVA: 0x7FFD54BCDD40 | overloaded x2
        public void ShouldApplyOffset(){} // RVA: 0x7FFD54BCE620
        public void ShouldApplyScaleRemove(){} // RVA: 0x7FFD54BCE690
        public void get_clipCaps(){} // RVA: 0x7FFD54BCE6B0
        public void ResetOffsets(){} // RVA: 0x7FFD54BCE8A0
        public void GatherProperties(){} // RVA: 0x7FFD54BCE930
        public void HasRootTransforms(){} // RVA: 0x7FFD54BCEA00
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD54BCEB90
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54BCEBF0
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFD54BCEC80
        public void .ctor(){} // RVA: 0x7FFD54BCECC0
        public void .cctor(){} // RVA: 0x7FFD54BCEDE0
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        public UnityEngine.Animations.AnimationPlayableOutput m_Output; // 0x10
        public UnityEngine.Playables.PlayableGraph m_Graph; // 0x20
        public System.Collections.Generic.List`1<0x665FD250> m_PreviewComponents; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BCF0D0
        public void Evaluate(){} // RVA: 0x7FFD54BCF190
        public void FetchPreviewComponents(){} // RVA: 0x7FFD54BCF400
    }

    public class AnimationTrack : TrackAsset
    {
        public string position;
        public string rotation;
        public 0x665E0EA0 eulerAngles; // 0xA0
        public 0x665E0EA0 applyOffsets; // 0xA4
        public UnityEngine.Vector3 trackOffset; // 0xA8
        public UnityEngine.Vector3 matchTargetFields; // 0xB4
        public double infiniteClip; // 0xC0
        public bool infiniteClipRemoveOffset; // 0xC8
        public bool avatarMask; // 0xC9
        public 0x665E0920 applyAvatarMask; // 0xCC
        public 0x665E0B30 outputs; // 0xD0
        public UnityEngine.Vector3 inClipMode; // 0xD4
        public UnityEngine.Vector3 infiniteClipOffsetPosition; // 0xE0
        public UnityEngine.AvatarMask infiniteClipOffsetRotation; // 0xF0
        public bool infiniteClipOffsetEulerAngles; // 0xF8
        public 0x665E0B88 infiniteClipApplyFootIK; // 0xFC
        public UnityEngine.AnimationClip infiniteClipTimeOffset; // 0x100
        public System.Collections.Generic.Queue`1<UnityEngine.Transform> infiniteClipPreExtrapolation;
        public UnityEngine.Quaternion infiniteClipPostExtrapolation; // 0x108
        public UnityEngine.Quaternion infiniteClipLoop; // 0x118
        public bool openClipOffsetPosition; // 0x128

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFD51B35360
        public void set_position(){} // RVA: 0x7FFD51B35380
        public void get_rotation(){} // RVA: 0x7FFD54BCF750
        public void set_rotation(){} // RVA: 0x7FFD54BCF800
        public void get_eulerAngles(){} // RVA: 0x7FFD54BCF830
        public void set_eulerAngles(){} // RVA: 0x7FFD54BCF850
        public void get_applyOffsets(){} // RVA: 0x7FFD4E341320
        public void set_applyOffsets(){} // RVA: 0x7FFD4E341310
        public void get_trackOffset(){} // RVA: 0x7FFD4F0ABB20
        public void set_trackOffset(){} // RVA: 0x7FFD54BCF870
        public void get_matchTargetFields(){} // RVA: 0x7FFD4EAB6B20
        public void set_matchTargetFields(){} // RVA: 0x7FFD54BCF880
        public void get_infiniteClip(){} // RVA: 0x7FFD4E916C80
        public void set_infiniteClip(){} // RVA: 0x7FFD4E916750
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7FFD4F14B010
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7FFD4F143EE0
        public void get_avatarMask(){} // RVA: 0x7FFD4E3AC2A0
        public void set_avatarMask(){} // RVA: 0x7FFD4E3AC2B0
        public void get_applyAvatarMask(){} // RVA: 0x7FFD4F0AE090
        public void set_applyAvatarMask(){} // RVA: 0x7FFD54BCF8F0
        public void CanCompileClips(){} // RVA: 0x7FFD54BCF900
        public void get_outputs(){} // RVA: 0x7FFD54BCFA40
        public void get_inClipMode(){} // RVA: 0x7FFD54BCFAF0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7FFD54BCFB30
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7FFD54BCFB50
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7FFD54BCFB70
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7FFD54BCFC20
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFD54BCFC50
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFD54BCFC70
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFD4F1433D0
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7FFD4F144CD0
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7FFD54BCFC90
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7FFD54BCFCA0
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7FFD4FCBE510
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7FFD4FCBE550
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7FFD51959470
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7FFD51959480
        public void get_infiniteClipLoop(){} // RVA: 0x7FFD4F7265A0
        public void set_infiniteClipLoop(){} // RVA: 0x7FFD53CE71C0
        public void ResetOffsets(){} // RVA: 0x7FFD54BCFCB0
        public void CreateClip(){} // RVA: 0x7FFD54BCFD50
        public void CreateInfiniteClip(){} // RVA: 0x7FFD54BCFE70
        public void CreateRecordableClip(){} // RVA: 0x7FFD54BD0050
        public void OnCreateClip(){} // RVA: 0x7FFD54BD0330
        public void CalculateItemsHash(){} // RVA: 0x7FFD54BD03A0
        public void UpdateClipOffsets(){} // RVA: 0x7FFD4E341310
        public void CompileTrackPlayable(){} // RVA: 0x7FFD54BD04B0
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7FFD54BD0AC0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFD54BD0B60
        public void GetDefaultBlendCount(){} // RVA: 0x7FFD4E919180
        public void AttachDefaultBlend(){} // RVA: 0x7FFD4E341310
        public void AttachOffsetPlayable(){} // RVA: 0x7FFD54BD1720
        public void RequiresMotionXPlayable(){} // RVA: 0x7FFD54BD1900
        public void UsesAbsoluteMotion(){} // RVA: 0x7FFD54BD1AE0
        public void HasController(){} // RVA: 0x7FFD54BD1AF0
        public void GetBinding(){} // RVA: 0x7FFD54BD1D80
        public void CreateGroupMixer(){} // RVA: 0x7FFD54BD2160
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7FFD54BD2250
        public void ApplyTrackOffset(){} // RVA: 0x7FFD54BD27B0
        public void GetEvaluationTime(){} // RVA: 0x7FFD54BD2A40
        public void GetSequenceTime(){} // RVA: 0x7FFD54BD2B10
        public void AssignAnimationClip(){} // RVA: 0x7FFD54BD2C60
        public void GatherProperties(){} // RVA: 0x7FFD4E341310
        public void GetAnimationClips(){} // RVA: 0x7FFD54BD30E0
        public void GetOffsetMode(){} // RVA: 0x7FFD54BD36E0
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7FFD54BD3810
        public void GetGenericRootNode(){} // RVA: 0x7FFD54BD3DF0
        public void AnimatesRootTransform(){} // RVA: 0x7FFD54BD41D0
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7FFD54BD4480
        public void get_openClipOffsetPosition(){} // RVA: 0x7FFD54BCFB30
        public void set_openClipOffsetPosition(){} // RVA: 0x7FFD54BCFB50
        public void get_openClipOffsetRotation(){} // RVA: 0x7FFD54BCFB70
        public void set_openClipOffsetRotation(){} // RVA: 0x7FFD54BD46C0
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7FFD54BCFC50
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7FFD54BCFC70
        public void get_openClipPreExtrapolation(){} // RVA: 0x7FFD4FCBE510
        public void set_openClipPreExtrapolation(){} // RVA: 0x7FFD4FCBE550
        public void get_openClipPostExtrapolation(){} // RVA: 0x7FFD51959470
        public void set_openClipPostExtrapolation(){} // RVA: 0x7FFD51959480
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFD54BD4700
        public void .ctor(){} // RVA: 0x7FFD54BD48F0
        public void .cctor(){} // RVA: 0x7FFD54BD4B20
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        public float volume; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BE6700
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        public float volume; // 0x10
        public float stereoPan; // 0x14
        public float spatialBlend; // 0x18

        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7FFD54BE6710
        public void .ctor(){} // RVA: 0x7FFD54BE6700
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        public UnityEngine.AudioClip bufferingTime; // 0x18
        public bool clip; // 0x20
        public float loop; // 0x24
        public UnityEngine.Timeline.AudioClipProperties duration; // 0x28

        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x7FFD4E4AEF50
        public void set_bufferingTime(){} // RVA: 0x7FFD4E4AEF60
        public void get_clip(){} // RVA: 0x7FFD4E3447C0
        public void set_clip(){} // RVA: 0x7FFD4E3A7E80
        public void get_loop(){} // RVA: 0x7FFD4E42F9D0
        public void set_loop(){} // RVA: 0x7FFD4E42F9E0
        public void get_duration(){} // RVA: 0x7FFD54BE6B00
        public void get_outputs(){} // RVA: 0x7FFD54BE6D00
        public void CreatePlayable(){} // RVA: 0x7FFD54BE6DB0
        public void get_clipCaps(){} // RVA: 0x7FFD54BE7030
        public void .ctor(){} // RVA: 0x7FFD54BE7040
    }

    public class AudioTrack : TrackAsset
    {
        public UnityEngine.Timeline.AudioMixerProperties outputs; // 0xA0

        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7FFD54BE7340
        public void CompileClips(){} // RVA: 0x7FFD54BE7640
        public void get_outputs(){} // RVA: 0x7FFD54BE7FB0
        public void OnValidate(){} // RVA: 0x7FFD54BE8060
        public void .ctor(){} // RVA: 0x7FFD54BE8100
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        public object duration;
        public object outputs;

        // ── Methods ──
        public void get_duration(){} // RVA: 0x7FFD54BF3310
        public void get_outputs(){} // RVA: 0x7FFD54BF3370
        public void OnGraphStart(){} // RVA: 0x7FFD4E341310
        public void OnGraphStop(){} // RVA: 0x7FFD4E341310
        public void OnPlayableCreate(){} // RVA: 0x7FFD4E341310
        public void OnPlayableDestroy(){} // RVA: 0x7FFD4E341310
        public void OnBehaviourPlay(){} // RVA: 0x7FFD4E341310
        public void OnBehaviourPause(){} // RVA: 0x7FFD4E341310
        public void PrepareFrame(){} // RVA: 0x7FFD4E341310
        public void ProcessFrame(){} // RVA: 0x7FFD4E341310
        public void CreatePlayable(){} // RVA: 0x7FFD54BF33D0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class BlendUtility : Object
    {
        public double kMinOverlapTime;

        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7FFD54BFC990
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFD54BFCAD0
        public void UpdateClipIntersection(){} // RVA: 0x7FFD54BFCEF0
        public void .cctor(){} // RVA: 0x7FFD54BFD0E0
    }

    public class ControlPlayableAsset : PlayableAsset
    {
        public int controllingDirectors;
        public System.Collections.Generic.List`1<UnityEngine.Playables.PlayableDirector> controllingParticles;
        public System.Collections.Generic.List`1<UnityEngine.ParticleSystem> duration; // 0x8
        public System.Collections.Generic.HashSet`1<UnityEngine.ParticleSystem> clipCaps; // 0x10
        public UnityEngine.ExposedReference`1<UnityEngine.GameObject> sourceGameObject; // 0x18
        public UnityEngine.GameObject prefabGameObject; // 0x28
        public bool updateParticle; // 0x30
        public uint particleRandomSeed; // 0x34
        public bool updateDirector; // 0x38
        public bool updateITimeControl; // 0x39
        public bool searchHierarchy; // 0x3A
        public bool active; // 0x3B
        public 0x665E2130 postPlayback; // 0x3C
        public 0x665E2290 directorOnClipEnd; // 0x40
        public UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset; // 0x48
        public double m_Duration; // 0x50
        public bool m_SupportLoop; // 0x58
        public System.Collections.Generic.HashSet`1<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors; // 0x18
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> s_CreatedPrefabs; // 0x20
        public bool <controllingDirectors>k__BackingField; // 0x59
        public bool <controllingParticles>k__BackingField; // 0x5A

        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7FFD52BACF40
        public void set_controllingDirectors(){} // RVA: 0x7FFD53BD5A20
        public void get_controllingParticles(){} // RVA: 0x7FFD4E55BB50
        public void set_controllingParticles(){} // RVA: 0x7FFD4E562110
        public void OnEnable(){} // RVA: 0x7FFD54BE8430
        public void get_duration(){} // RVA: 0x7FFD52048EF0
        public void get_clipCaps(){} // RVA: 0x7FFD54BE8490
        public void CreatePlayable(){} // RVA: 0x7FFD54BE84A0
        public void ConnectPlayablesToMixer(){} // RVA: 0x7FFD54BE92E0
        public void CreateActivationPlayable(){} // RVA: 0x7FFD54BE9730
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7FFD54BE98F0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7FFD54BE9CD0
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7FFD54BEA220
        public void ConnectMixerAndPlayable(){} // RVA: 0x7FFD54BEA710
        public void GetComponent(){} // RVA: 0x7FFD4E078F40
        public void GetControlableScripts(){} // RVA: 0x7FFD54BEA850
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7FFD54BEA900
        public void GetControllableParticleSystems(){} // RVA: 0x7FFD54BEB3F0 | overloaded x2
        public void CacheSubEmitters(){} // RVA: 0x7FFD54BEB6F0
        public void GatherProperties(){} // RVA: 0x7FFD54BEB980
        public void PreviewParticles(){} // RVA: 0x7FFD54BEBD90
        public void PreviewActivation(){} // RVA: 0x7FFD54BEC1E0
        public void PreviewTimeControl(){} // RVA: 0x7FFD54BEC460
        public void PreviewDirectors(){} // RVA: 0x7FFD54BEC6B0
        public void .ctor(){} // RVA: 0x7FFD54BECA30
        public void .cctor(){} // RVA: 0x7FFD54BECAB0
    }

    public class ControlTrack : TrackAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BED200
    }

    public class CurveEditUtility : Object
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7FFD54BED250
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CustomStyleAttribute : Attribute
    {
        public string ussStyle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        public UnityEngine.Playables.PlayableDirector director; // 0x10
        public 0x665E2290 pauseAction; // 0x18
        public bool m_SyncTime; // 0x1C
        public double m_AssetDuration; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF3590
        public void OnPlayableDestroy(){} // RVA: 0x7FFD54BF37F0
        public void PrepareFrame(){} // RVA: 0x7FFD54BF39C0
        public void OnBehaviourPlay(){} // RVA: 0x7FFD54BF3CB0
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF3E70
        public void ProcessFrame(){} // RVA: 0x7FFD54BF4050
        public void SyncSpeed(){} // RVA: 0x7FFD54BF45C0
        public void SyncStart(){} // RVA: 0x7FFD54BF49A0
        public void SyncStop(){} // RVA: 0x7FFD54BF4B60
        public void DetectDiscontinuity(){} // RVA: 0x7FFD54BF4D40
        public void DetectOutOfSync(){} // RVA: 0x7FFD54BF4F70
        public void UpdateTime(){} // RVA: 0x7FFD54BF50D0
        public void .ctor(){} // RVA: 0x7FFD54BF5310
    }

    public class DiscreteTime : ValueType
    {
        public double tickValue;
        public UnityEngine.Timeline.DiscreteTime kMaxTime;
        public long m_DiscreteTime; // 0x10

        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7FFD54BED420
        public void .ctor(){} // RVA: 0x7FFD54BED590 | overloaded x6
        public void OneTickBefore(){} // RVA: 0x7FFD54BED610
        public void OneTickAfter(){} // RVA: 0x7FFD54BED620
        public void GetTick(){} // RVA: 0x7FFD4EEF9F60
        public void FromTicks(){} // RVA: 0x7FFD4F9181E0
        public void CompareTo(){} // RVA: 0x7FFD54BED630
        public void Equals(){} // RVA: 0x7FFD54BED6E0 | overloaded x2
        public void DoubleToDiscreteTime(){} // RVA: 0x7FFD54BED780
        public void FloatToDiscreteTime(){} // RVA: 0x7FFD54BED810
        public void IntToDiscreteTime(){} // RVA: 0x7FFD54BED8A0
        public void ToDouble(){} // RVA: 0x7FFD54BED900
        public void ToFloat(){} // RVA: 0x7FFD54BED920
        public void op_Explicit(){} // RVA: 0x7FFD4F9181E0 | overloaded x6
        public void op_Implicit(){} // RVA: 0x7FFD54BEDB30
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD54BEDBC0
        public void op_GreaterThan(){} // RVA: 0x7FFD53A70B80
        public void op_LessThan(){} // RVA: 0x7FFD53A70B60
        public void op_LessThanOrEqual(){} // RVA: 0x7FFD53A70B70
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFD53A70B90
        public void op_Addition(){} // RVA: 0x7FFD5072B350
        public void op_Subtraction(){} // RVA: 0x7FFD54BEDC20
        public void ToString(){} // RVA: 0x7FFD54BEDC30
        public void GetHashCode(){} // RVA: 0x7FFD54BEDCD0
        public void Min(){} // RVA: 0x7FFD54BEDCE0
        public void Max(){} // RVA: 0x7FFD54BEDD40
        public void SnapToNearestTick(){} // RVA: 0x7FFD54BEDE10 | overloaded x2
        public void GetNearestTick(){} // RVA: 0x7FFD54BEDEC0
        public void .cctor(){} // RVA: 0x7FFD54BEDF20
    }

    public class Extrapolation : Object
    {
        public double kMinExtrapolationTime;

        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7FFD54BFD380
        public void SortClipsByStartTime(){} // RVA: 0x7FFD54BFD850
        public void .cctor(){} // RVA: 0x7FFD54BFDB60
    }

    public class GroupTrack : TrackAsset
    {
        public object outputs;

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFD4E341320
        public void get_outputs(){} // RVA: 0x7FFD54BF2A20
        public void .ctor(){} // RVA: 0x7FFD54BF2A80
    }

    public class HashUtility : Object
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7FFD54BFDEE0 | overloaded x7
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ICurvesOwner
    {
        public object curves;
        public object hasCurves;
        public object duration;
        public object defaultCurvesName;
        public object asset;
        public object assetOwner;
        public object targetTrack;

        // ── Methods ──
        public void get_curves(){} // RVA: 0x7FFD4E078E90
        public void get_hasCurves(){} // RVA: 0x7FFD4E079D00
        public void get_duration(){} // RVA: 0x7FFD4E07EB60
        public void CreateCurves(){} // RVA: 0x7FFD4E090A40
        public void get_defaultCurvesName(){} // RVA: 0x7FFD4E078E90
        public void get_asset(){} // RVA: 0x7FFD4E078E90
        public void get_assetOwner(){} // RVA: 0x7FFD4E078E90
        public void get_targetTrack(){} // RVA: 0x7FFD4E078E90
    }

    public class IInterval
    {
        public <>c<T> intervalStart;
        public object intervalEnd;

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFD4E078E90
        public void get_intervalEnd(){} // RVA: 0x7FFD4E078E90
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){}
    }

    public class IMarker
    {
        public object time;
        public object parent;

        // ── Methods ──
        public void get_time(){} // RVA: 0x7FFD4E07EB60
        public void set_time(){} // RVA: 0x7FFD4E092080
        public void get_parent(){} // RVA: 0x7FFD4E078E90
        public void Initialize(){} // RVA: 0x7FFD4E090A40
    }

    public class INotificationOptionProvider
    {
        public object flags;

        // ── Methods ──
        public void get_flags(){} // RVA: 0x7FFD4E078DC0
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7FFD4E090A40
        public void PopActiveGameObject(){} // RVA: 0x7FFD4E090980
        public void AddFromClip(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void AddFromClips(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void AddFromName(){} // RVA: 0x7FFD4E099B30 | overloaded x5
        public void AddFromComponent(){} // RVA: 0x7FFD4E099B30
        public void AddObjectProperties(){} // RVA: 0x7FFD4E099B30
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x7FFD4E099B30
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x7FFD4E092080
        public void OnControlTimeStart(){} // RVA: 0x7FFD4E090980
        public void OnControlTimeStop(){} // RVA: 0x7FFD4E090980
    }

    public class ITimelineClipAsset
    {
        public object clipCaps;

        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFD4E079960
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFD4E090980
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        public UnityEngine.Playables.Playable intervalStart; // 0x18
        public long intervalEnd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E9F34F0
        public void get_intervalStart(){} // RVA: 0x7FFD4E919180
        public void get_intervalEnd(){} // RVA: 0x7FFD54BEDF70
        public void set_enable(){} // RVA: 0x7FFD54BEDFD0
        public void EvaluateAt(){} // RVA: 0x7FFD54BEE050
        public void DisableAt(){} // RVA: 0x7FFD54BEE0B0
        public void .cctor(){} // RVA: 0x7FFD54BEE120
    }

    public class IntervalTreeNode : ValueType
    {
        public long center; // 0x10
        public int first; // 0x18
        public int last; // 0x1C
        public int left; // 0x20
        public int right; // 0x24
    }

    public class IntervalTree`1 : Object
    {
        public int dirty;
        public int kInvalidNode;
        public long kCenterUnknown;
        public System.Collections.Generic.List`1<0x665E1A50<T>> m_Entries;
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;
        public bool <dirty>k__BackingField;

        // ── Methods ──
        public void get_dirty(){} // RVA: 0x7FFD4E079D00
        public void set_dirty(){} // RVA: 0x7FFD4E091060
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateIntervals(){} // RVA: 0x7FFD4E090980
        public void Query(){} // RVA: 0x7FFD4E2ADC40
        public void QueryRange(){} // RVA: 0x7FFD4E2ADC40
        public void Rebuild(){} // RVA: 0x7FFD4E080290 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Marker : ScriptableObject
    {
        public double parent; // 0x18
        public UnityEngine.Timeline.TrackAsset time; // 0x20

        // ── Methods ──
        public void get_parent(){} // RVA: 0x7FFD4E36F0C0
        public void set_parent(){} // RVA: 0x7FFD4E36F0D0
        public void get_time(){} // RVA: 0x7FFD4F842FA0
        public void set_time(){} // RVA: 0x7FFD54BEF330
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7FFD54BEF3D0
        public void OnInitialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class MarkerList : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> markers; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> Count; // 0x18
        public bool Item; // 0x20
        public bool m_HasNotifications; // 0x21

        // ── Methods ──
        public void get_markers(){} // RVA: 0x7FFD54BEF570
        public void .ctor(){} // RVA: 0x7FFD54BEF590
        public void Add(){} // RVA: 0x7FFD54BEF710
        public void Remove(){} // RVA: 0x7FFD54BEF990 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD54BEFA50
        public void Contains(){} // RVA: 0x7FFD54BEFAC0
        public void GetMarkers(){} // RVA: 0x7FFD54BEF570
        public void get_Count(){} // RVA: 0x7FFD54BEFB20
        public void get_Item(){} // RVA: 0x7FFD54BEFB70
        public void GetRawMarkerList(){} // RVA: 0x7FFD4EEF9F60
        public void CreateMarker(){} // RVA: 0x7FFD54BEFBF0
        public void HasNotifications(){} // RVA: 0x7FFD54BEFF20
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4E64C870
        public void BuildCache(){} // RVA: 0x7FFD54BEFF40
    }

    public class MarkerTrack : TrackAsset
    {
        public object outputs;

        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7FFD54BF02A0
        public void .ctor(){} // RVA: 0x7FFD54BF0570
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NotificationUtilities : Object
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFD54BFDFE0 | overloaded x3
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7FFD54BFE720
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        public float particleSystem;
        public float m_LastPlayableTime; // 0x10
        public float m_LastParticleTime; // 0x14
        public uint m_RandomSeed; // 0x18
        public UnityEngine.ParticleSystem <particleSystem>k__BackingField; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF5320
        public void get_particleSystem(){} // RVA: 0x7FFD4E36F0C0
        public void set_particleSystem(){} // RVA: 0x7FFD4E36F0D0
        public void Initialize(){} // RVA: 0x7FFD54BF55F0
        public void SetRandomSeed(){} // RVA: 0x7FFD54BF56B0
        public void PrepareFrame(){} // RVA: 0x7FFD54BF59C0
        public void OnBehaviourPlay(){} // RVA: 0x7FFD54BF5C70
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF5C70
        public void Simulate(){} // RVA: 0x7FFD54BF5C80
        public void .ctor(){} // RVA: 0x7FFD54BF5E50
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7FFD54BF86B0
        public void .ctor(){} // RVA: 0x7FFD54BF8820
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        public UnityEngine.GameObject prefabInstance; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF5E70
        public void get_prefabInstance(){} // RVA: 0x7FFD4E35C380
        public void Initialize(){} // RVA: 0x7FFD54BF60A0
        public void OnPlayableDestroy(){} // RVA: 0x7FFD54BF6490
        public void OnBehaviourPlay(){} // RVA: 0x7FFD54BF6610
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF6730
        public void SetHideFlagsRecursive(){} // RVA: 0x7FFD54BF6840
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeClip : RuntimeClipBase
    {
        public UnityEngine.Timeline.TimelineClip start; // 0x18
        public UnityEngine.Playables.Playable duration; // 0x20
        public UnityEngine.Playables.Playable clip; // 0x30

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFD54BEE210
        public void get_duration(){} // RVA: 0x7FFD54BEE240
        public void .ctor(){} // RVA: 0x7FFD54BEE260
        public void Create(){} // RVA: 0x7FFD54BEE260
        public void get_clip(){} // RVA: 0x7FFD4E3447C0
        public void get_mixer(){} // RVA: 0x7FFD5387FF30
        public void get_playable(){} // RVA: 0x7FFD4FE39630
        public void set_enable(){} // RVA: 0x7FFD54BEE330
        public void SetTime(){} // RVA: 0x7FFD54BEE490
        public void SetDuration(){} // RVA: 0x7FFD54BEE4F0
        public void EvaluateAt(){} // RVA: 0x7FFD54BEE550
        public void DisableAt(){} // RVA: 0x7FFD54BEE8A0
    }

    public class RuntimeClipBase : RuntimeElement
    {
        public object start;
        public object duration;
        public object intervalStart;
        public object intervalEnd;

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFD4E07EB60
        public void get_duration(){} // RVA: 0x7FFD4E07EB60
        public void get_intervalStart(){} // RVA: 0x7FFD54BEEAB0
        public void get_intervalEnd(){} // RVA: 0x7FFD54BEEB60
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeElement : Object
    {
        public int intervalStart; // 0x10

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFD4E078E90
        public void get_intervalEnd(){} // RVA: 0x7FFD4E078E90
        public void get_intervalBit(){} // RVA: 0x7FFD4E38E5C0
        public void set_intervalBit(){} // RVA: 0x7FFD4E3440C0
        public void set_enable(){} // RVA: 0x7FFD4E091060
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        public UnityEngine.Timeline.TimelineClip start; // 0x18
        public UnityEngine.Playables.Playable duration; // 0x20
        public UnityEngine.Playables.Playable clip; // 0x30
        public double mixer; // 0x40
        public double playable; // 0x48
        public bool enable; // 0x50

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFD54BEEC30
        public void get_duration(){} // RVA: 0x7FFD54BEECE0
        public void SetTime(){} // RVA: 0x7FFD54BEED30
        public void get_clip(){} // RVA: 0x7FFD4E3447C0
        public void get_mixer(){} // RVA: 0x7FFD5387FF30
        public void get_playable(){} // RVA: 0x7FFD4FE39630
        public void .ctor(){} // RVA: 0x7FFD54BEED90
        public void Create(){} // RVA: 0x7FFD54BEED90
        public void set_enable(){} // RVA: 0x7FFD54BEEE70
        public void EvaluateAt(){} // RVA: 0x7FFD54BEEF90
        public void DisableAt(){} // RVA: 0x7FFD54BEF310
    }

    public class SignalAsset : ScriptableObject
    {
        public System.Action`1<UnityEngine.Timeline.SignalAsset> OnEnableCallback;

        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7FFD54BF05C0
        public void remove_OnEnableCallback(){} // RVA: 0x7FFD54BF06F0
        public void OnEnable(){} // RVA: 0x7FFD54BF0820
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SignalEmitter : Marker
    {
        public bool retroactive; // 0x28
        public bool emitOnce; // 0x29
        public UnityEngine.Timeline.SignalAsset asset; // 0x30

        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x7FFD4E516BA0
        public void set_retroactive(){} // RVA: 0x7FFD4F044F40
        public void get_emitOnce(){} // RVA: 0x7FFD4EC8C550
        public void set_emitOnce(){} // RVA: 0x7FFD4F7D4D70
        public void get_asset(){} // RVA: 0x7FFD4E5F95E0
        public void set_asset(){} // RVA: 0x7FFD4E36F890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7FFD54BF0880
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7FFD54BF0A20
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SignalReceiver : MonoBehaviour
    {
        public 0x665E1F20 m_Events; // 0x20

        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFD54BF0A50
        public void AddReaction(){} // RVA: 0x7FFD54BF0C50
        public void AddEmptyReaction(){} // RVA: 0x7FFD54BF0E10
        public void Remove(){} // RVA: 0x7FFD54BF0E80
        public void GetRegisteredSignals(){} // RVA: 0x7FFD4E98A5F0
        public void GetReaction(){} // RVA: 0x7FFD54BF1000
        public void Count(){} // RVA: 0x7FFD54BF1040
        public void ChangeSignalAtIndex(){} // RVA: 0x7FFD54BF1090
        public void RemoveAtIndex(){} // RVA: 0x7FFD54BF1550
        public void ChangeReactionAtIndex(){} // RVA: 0x7FFD54BF1660
        public void GetReactionAtIndex(){} // RVA: 0x7FFD54BF1750
        public void GetSignalAssetAtIndex(){} // RVA: 0x7FFD54BF1830
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD54BF1910
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54BF0570
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        public System.Type childType; // 0x10
        public int levels; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCAC310
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        public UnityEngine.Timeline.ITimeControl m_timeControl; // 0x10
        public bool m_started; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF6C80
        public void Initialize(){} // RVA: 0x7FFD4E342E30
        public void PrepareFrame(){} // RVA: 0x7FFD54BF6E40
        public void OnBehaviourPlay(){} // RVA: 0x7FFD54BF6EC0
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF6F20
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public System.Collections.Generic.List`1<0x665E24F8> timeSource; // 0x10
        public double m_PreviousTime; // 0x18
        public bool m_NeedSortNotifications; // 0x20
        public UnityEngine.Playables.Playable m_TimeSource; // 0x28

        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x7FFD4EFEC210
        public void Create(){} // RVA: 0x7FFD54BF6F80
        public void AddNotification(){} // RVA: 0x7FFD54BF7180
        public void OnGraphStart(){} // RVA: 0x7FFD54BF7280
        public void OnBehaviourPause(){} // RVA: 0x7FFD54BF74A0
        public void PrepareFrame(){} // RVA: 0x7FFD54BF7770
        public void SortNotifications(){} // RVA: 0x7FFD54BF7B60
        public void CanRestoreNotification(){} // RVA: 0x7FFD54BF7D80
        public void TriggerNotificationsInRange(){} // RVA: 0x7FFD54BF7DC0
        public void SyncDurationWithExternalSource(){} // RVA: 0x7FFD54BF8070
        public void Trigger_internal(){} // RVA: 0x7FFD54BF8330
        public void Restore_internal(){} // RVA: 0x7FFD4E64C880
        public void .ctor(){} // RVA: 0x7FFD54BF84D0
    }

    public class TimeUtility : Object
    {
        public double kTimeEpsilon;
        public double kFrameRateEpsilon; // 0x8
        public double k_MaxTimelineDurationInSeconds; // 0x10
        public double kFrameRateRounding; // 0x18

        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7FFD54C004D0
        public void ToFrames(){} // RVA: 0x7FFD54C00590
        public void ToExactFrames(){} // RVA: 0x7FFD54C00700
        public void FromFrames(){} // RVA: 0x7FFD54C007E0 | overloaded x2
        public void OnFrameBoundary(){} // RVA: 0x7FFD54C00CF0 | overloaded x2
        public void GetEpsilon(){} // RVA: 0x7FFD54C00960
        public void PreviousFrame(){} // RVA: 0x7FFD54C00A50
        public void NextFrame(){} // RVA: 0x7FFD54C00AF0
        public void PreviousFrameTime(){} // RVA: 0x7FFD54C00B60
        public void NextFrameTime(){} // RVA: 0x7FFD54C00C40
        public void RoundToFrame(){} // RVA: 0x7FFD54C00DC0
        public void TimeAsFrames(){} // RVA: 0x7FFD54C00EC0
        public void TimeAsTimeCode(){} // RVA: 0x7FFD54C01050
        public void ParseTimeCode(){} // RVA: 0x7FFD54C01750
        public void ParseTimeSeconds(){} // RVA: 0x7FFD54C01E30
        public void GetAnimationClipLength(){} // RVA: 0x7FFD54C02360
        public void RemoveChar(){} // RVA: 0x7FFD54C02560
        public void GetClosestFrameRate(){} // RVA: 0x7FFD54C02630
        public void ToFrameRate(){} // RVA: 0x7FFD54C028C0
        public void ToStandardFrameRate(){} // RVA: 0x7FFD54C02AB0
        public void .cctor(){} // RVA: 0x7FFD54C02F20
    }

    public class TimelineAsset : PlayableAsset
    {
        public int editorSettings;
        public int duration; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> fixedDuration; // 0x20
        public double durationMode; // 0x28
        public UnityEngine.Timeline.TrackAsset[] outputs; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Timeline.TrackAsset> clipCaps; // 0x38
        public UnityEngine.Timeline.TrackAsset[] outputTrackCount; // 0x40
        public 0x665E1108 rootTrackCount; // 0x48
        public 0x665E10B0 flattenedTracks; // 0x50
        public UnityEngine.Timeline.MarkerTrack markerTrack; // 0x58

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFD4E341310
        public void get_editorSettings(){} // RVA: 0x7FFD4E3BC730
        public void get_duration(){} // RVA: 0x7FFD54BD7FE0
        public void get_fixedDuration(){} // RVA: 0x7FFD54BD8080
        public void set_fixedDuration(){} // RVA: 0x7FFD54BD81A0
        public void get_durationMode(){} // RVA: 0x7FFD4E5110E0
        public void set_durationMode(){} // RVA: 0x7FFD4E5F9010
        public void get_outputs(){} // RVA: 0x7FFD54BD8240
        public void get_clipCaps(){} // RVA: 0x7FFD54BD82F0
        public void get_outputTrackCount(){} // RVA: 0x7FFD54BD84B0
        public void get_rootTrackCount(){} // RVA: 0x7FFD54BD84E0
        public void OnValidate(){} // RVA: 0x7FFD54BD8530
        public void GetRootTrack(){} // RVA: 0x7FFD54BD8570
        public void GetRootTracks(){} // RVA: 0x7FFD54BD85F0
        public void GetOutputTrack(){} // RVA: 0x7FFD54BD8610
        public void GetOutputTracks(){} // RVA: 0x7FFD54BD8660
        public void GetValidFrameRate(){} // RVA: 0x7FFD54BD8680
        public void UpdateRootTrackCache(){} // RVA: 0x7FFD54BD8770
        public void UpdateOutputTrackCache(){} // RVA: 0x7FFD54BD8BF0
        public void get_flattenedTracks(){} // RVA: 0x7FFD54BD8E90
        public void get_markerTrack(){} // RVA: 0x7FFD4E409500
        public void get_trackObjects(){} // RVA: 0x7FFD4E36F0C0
        public void AddTrackInternal(){} // RVA: 0x7FFD54BD90A0
        public void RemoveTrack(){} // RVA: 0x7FFD54BD9150
        public void CreatePlayable(){} // RVA: 0x7FFD54BD92D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4EAB70B0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54BD95A0
        public void __internalAwake(){} // RVA: 0x7FFD54BD95B0
        public void GatherProperties(){} // RVA: 0x7FFD54BD9810
        public void CreateMarkerTrack(){} // RVA: 0x7FFD54BD9A20
        public void RemoveMarkerTrack(){} // RVA: 0x7FFD54BD9C10
        public void Invalidate(){} // RVA: 0x7FFD54BD9D50
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7FFD54BD9E50
        public void CalculateItemsDuration(){} // RVA: 0x7FFD54BD9F00
        public void AddSubTracksRecursive(){} // RVA: 0x7FFD54BDA180
        public void CreateTrack(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void DeleteClip(){} // RVA: 0x7FFD54BDA980
        public void DeleteTrack(){} // RVA: 0x7FFD54BDAD60
        public void MoveLastTrackBefore(){} // RVA: 0x7FFD54BDB320
        public void AllocateTrack(){} // RVA: 0x7FFD54BDB6B0
        public void DeleteRecordedAnimation(){} // RVA: 0x7FFD54BDBE40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54BDC0E0
    }

    public class TimelineClip : Object
    {
        public int hasPreExtrapolation;
        public int hasPostExtrapolation; // 0x10
        public 0x665E16E0 timeScale;
        public float start; // 0x4
        public double duration; // 0x8
        public double end; // 0x10
        public string clipIn; // 0x18
        public double displayName; // 0x20
        public double clipAssetDuration; // 0x28
        public double curves; // 0x18
        public double UnityEngine.Timeline.ICurvesOwner.defaultCurvesName; // 0x20
        public UnityEngine.Object hasCurves; // 0x28
        public double asset; // 0x30
        public double UnityEngine.Timeline.ICurvesOwner.assetOwner; // 0x38
        public UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack; // 0x40
        public double underlyingAsset; // 0x48
        public double parentTrack; // 0x50
        public double easeInDuration; // 0x58
        public double easeOutDuration; // 0x60
        public UnityEngine.AnimationCurve eastOutTime; // 0x68
        public UnityEngine.AnimationCurve easeOutTime; // 0x70
        public 0x665E0EF8 blendInDuration; // 0x78
        public 0x665E0EF8 blendOutDuration; // 0x7C
        public System.Collections.Generic.List`1<string> blendInCurveMode; // 0x80
        public UnityEngine.AnimationClip blendOutCurveMode; // 0x88
        public bool hasBlendIn; // 0x90
        public 0x665E0EA0 hasBlendOut; // 0x94
        public 0x665E0EA0 mixInCurve; // 0x98
        public double mixInPercentage; // 0xA0
        public double mixInDuration; // 0xA8
        public string mixOutCurve; // 0xB0

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFD54BD4F80
        public void .ctor(){} // RVA: 0x7FFD54BD4FB0
        public void get_hasPreExtrapolation(){} // RVA: 0x7FFD54BD4FE0
        public void get_hasPostExtrapolation(){} // RVA: 0x7FFD54BD5000
        public void get_timeScale(){} // RVA: 0x7FFD54BD5020
        public void set_timeScale(){} // RVA: 0x7FFD54BD5130
        public void get_start(){} // RVA: 0x7FFD4F842FA0
        public void set_start(){} // RVA: 0x7FFD54BD5250
        public void get_duration(){} // RVA: 0x7FFD54A9D770
        public void set_duration(){} // RVA: 0x7FFD54BD5460
        public void get_end(){} // RVA: 0x7FFD54BD5620
        public void get_clipIn(){} // RVA: 0x7FFD54BD5630
        public void set_clipIn(){} // RVA: 0x7FFD54BD5660
        public void get_displayName(){} // RVA: 0x7FFD4E3AC040
        public void set_displayName(){} // RVA: 0x7FFD4E3AC050
        public void get_clipAssetDuration(){} // RVA: 0x7FFD54BD5780
        public void get_curves(){} // RVA: 0x7FFD4E380010
        public void set_curves(){} // RVA: 0x7FFD4E96E300
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFD54BD57F0
        public void get_hasCurves(){} // RVA: 0x7FFD54BD5850
        public void get_asset(){} // RVA: 0x7FFD4E36F130
        public void set_asset(){} // RVA: 0x7FFD4E342E90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFD4E3BE740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFD4E3BE740
        public void get_underlyingAsset(){} // RVA: 0x7FFD4E919180
        public void set_underlyingAsset(){} // RVA: 0x7FFD4E341310
        public void get_parentTrack(){} // RVA: 0x7FFD4E3BE740
        public void set_parentTrack(){} // RVA: 0x7FFD54BD5990
        public void GetParentTrack(){} // RVA: 0x7FFD4E3BE740
        public void SetParentTrack_Internal(){} // RVA: 0x7FFD54BD59A0
        public void get_easeInDuration(){} // RVA: 0x7FFD54BD5C60
        public void set_easeInDuration(){} // RVA: 0x7FFD54BD5D60
        public void get_easeOutDuration(){} // RVA: 0x7FFD54BD5EB0
        public void set_easeOutDuration(){} // RVA: 0x7FFD54BD5FB0
        public void get_eastOutTime(){} // RVA: 0x7FFD54BD6100
        public void get_easeOutTime(){} // RVA: 0x7FFD54BD6100
        public void get_blendInDuration(){} // RVA: 0x7FFD54BD6140
        public void set_blendInDuration(){} // RVA: 0x7FFD54BD6170
        public void get_blendOutDuration(){} // RVA: 0x7FFD54BD6210
        public void set_blendOutDuration(){} // RVA: 0x7FFD54BD6240
        public void get_blendInCurveMode(){} // RVA: 0x7FFD4F9B6EF0
        public void set_blendInCurveMode(){} // RVA: 0x7FFD4F9B63A0
        public void get_blendOutCurveMode(){} // RVA: 0x7FFD4F9B8F70
        public void set_blendOutCurveMode(){} // RVA: 0x7FFD53E00310
        public void get_hasBlendIn(){} // RVA: 0x7FFD54BD62E0
        public void get_hasBlendOut(){} // RVA: 0x7FFD54BD6320
        public void get_mixInCurve(){} // RVA: 0x7FFD54BD6360
        public void set_mixInCurve(){} // RVA: 0x7FFD4E3BCD60
        public void get_mixInPercentage(){} // RVA: 0x7FFD54BD6470
        public void get_mixInDuration(){} // RVA: 0x7FFD54BD6490
        public void get_mixOutCurve(){} // RVA: 0x7FFD54BD65C0
        public void set_mixOutCurve(){} // RVA: 0x7FFD4E4095A0
        public void get_mixOutTime(){} // RVA: 0x7FFD54BD66D0
        public void get_mixOutDuration(){} // RVA: 0x7FFD54BD6750
        public void get_mixOutPercentage(){} // RVA: 0x7FFD54BD67C0
        public void get_recordable(){} // RVA: 0x7FFD4F22D160
        public void set_recordable(){} // RVA: 0x7FFD4F2289B0
        public void get_exposedParameters(){} // RVA: 0x7FFD54BD6830
        public void get_clipCaps(){} // RVA: 0x7FFD54BD6900
        public void Hash(){} // RVA: 0x7FFD54BD69A0
        public void EvaluateMixOut(){} // RVA: 0x7FFD54BD6AD0
        public void EvaluateMixIn(){} // RVA: 0x7FFD54BD6C30
        public void GetDefaultMixInCurve(){} // RVA: 0x7FFD54BD6D20
        public void GetDefaultMixOutCurve(){} // RVA: 0x7FFD54BD6D50
        public void ToLocalTime(){} // RVA: 0x7FFD54BD6D80
        public void ToLocalTimeUnbound(){} // RVA: 0x7FFD54BD6F50
        public void FromLocalTimeUnbound(){} // RVA: 0x7FFD54BD6FC0
        public void get_animationClip(){} // RVA: 0x7FFD54BD7020
        public void SanitizeTimeValue(){} // RVA: 0x7FFD54BD71F0
        public void get_postExtrapolationMode(){} // RVA: 0x7FFD54BD7350
        public void set_postExtrapolationMode(){} // RVA: 0x7FFD54BD7380
        public void get_preExtrapolationMode(){} // RVA: 0x7FFD54BD73C0
        public void set_preExtrapolationMode(){} // RVA: 0x7FFD54BD73F0
        public void SetPostExtrapolationTime(){} // RVA: 0x7FFD54BD7430
        public void SetPreExtrapolationTime(){} // RVA: 0x7FFD54BD7440
        public void IsExtrapolatedTime(){} // RVA: 0x7FFD54BD7450
        public void IsPreExtrapolatedTime(){} // RVA: 0x7FFD54BD7500
        public void IsPostExtrapolatedTime(){} // RVA: 0x7FFD54BD7560
        public void get_extrapolatedStart(){} // RVA: 0x7FFD54BD75D0
        public void get_extrapolatedDuration(){} // RVA: 0x7FFD54BD75F0
        public void GetExtrapolatedTime(){} // RVA: 0x7FFD54BD76F0
        public void CreateCurves(){} // RVA: 0x7FFD54BD7830
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4F9D41D0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54BD4F80
        public void ToString(){} // RVA: 0x7FFD54BD79C0
        public void ConformEaseValues(){} // RVA: 0x7FFD54BD7C10
        public void CalculateEasingRatio(){} // RVA: 0x7FFD54BD7D70
        public void UpdateDirty(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54BD7E60
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7FFD54BE8340
        public void SupportsExtrapolation(){} // RVA: 0x7FFD54BE8370
        public void SupportsClipIn(){} // RVA: 0x7FFD54BE83A0
        public void SupportsSpeedMultiplier(){} // RVA: 0x7FFD54BE83D0
        public void SupportsBlending(){} // RVA: 0x7FFD54BE8400
        public void HasAll(){} // RVA: 0x7FFD4F732F10
        public void HasAny(){} // RVA: 0x7FFD545B8D60
    }

    public class TimelineClipExtensions : Object
    {
        public string k_UndoSetParentTrackText;

        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7FFD54BFE920
        public void TryMoveToTrack(){} // RVA: 0x7FFD54BFEE50
        public void MoveToTrack_Impl(){} // RVA: 0x7FFD54BFF170
        public void .cctor(){} // RVA: 0x7FFD54BFF410
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7FFD54BFF4C0
        public void SaveAssetIntoObject(){} // RVA: 0x7FFD54BFF810
        public void RemoveAssetFromObject(){} // RVA: 0x7FFD54BFF9E0
        public void CreateAnimationClipForTrack(){} // RVA: 0x7FFD54BFFB40
        public void ValidateParentTrack(){} // RVA: 0x7FFD54BFFF20
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TimelinePlayable : PlayableBehaviour
    {
        public UnityEngine.Timeline.IntervalTree`1<UnityEngine.Timeline.RuntimeElement> m_IntervalTree; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Timeline.RuntimeElement> m_ActiveClips; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips; // 0x20
        public int m_ActiveBit; // 0x28
        public System.Collections.Generic.Dictionary`2<UnityEngine.Timeline.TrackAsset,UnityEngine.Playables.Playable> m_PlayableCache; // 0x30
        public bool muteAudioScrubbing;
        public System.Collections.Generic.Dictionary`2<UnityEngine.Timeline.AnimationTrack,System.Collections.Generic.List`1<UnityEngine.Timeline.ITimelineEvaluateCallback>> m_EvaluateCallbacks; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Timeline.ITimelineEvaluateCallback> m_AlwaysEvaluateCallbacks; // 0x40
        public System.Collections.Generic.HashSet`1<UnityEngine.Timeline.ITimelineEvaluateCallback> m_ForceEvaluateNextEvaluate; // 0x48
        public System.Collections.Generic.HashSet`1<UnityEngine.Timeline.ITimelineEvaluateCallback> m_InvokedThisFrame; // 0x50
        public System.Collections.Generic.HashSet`1<UnityEngine.Timeline.AnimationTrack> m_ActiveTracksToEvaluateCache; // 0x58

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54BF8990
        public void Compile(){} // RVA: 0x7FFD54BF8DB0
        public void CompileTrackList(){} // RVA: 0x7FFD54BF9220
        public void CreateTrackOutput(){} // RVA: 0x7FFD54BF94E0
        public void CreateTrackPlayable(){} // RVA: 0x7FFD54BF9E90
        public void PrepareFrame(){} // RVA: 0x7FFD54BFA430
        public void Evaluate(){} // RVA: 0x7FFD54BFA480
        public void CacheTrack(){} // RVA: 0x7FFD54BFAC40
        public void ForAOTCompilationOnly(){} // RVA: 0x7FFD54BFACD0
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7FFD54BFAD30
        public void AddOutputWeightProcessor(){} // RVA: 0x7FFD54BFADD0
        public void AddEvaluateCallback(){} // RVA: 0x7FFD54BFB050
        public void InvokeOutputCallbacks(){} // RVA: 0x7FFD54BFB1E0
        public void TryGetCallbackList(){} // RVA: 0x7FFD54BFBD60
        public void .ctor(){} // RVA: 0x7FFD54BFBF50
        public void .cctor(){} // RVA: 0x7FFD54BFC5D0
    }

    public class TimelineUndo : Object
    {
        public <>c undoEnabled;

        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x7FFD4E341320
        public void PushDestroyUndo(){} // RVA: 0x7FFD54C00390
        public void PushUndo(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7FFD4E341310
        public void UndoName(){} // RVA: 0x7FFD54C00480
    }

    public class TrackAsset : PlayableAsset
    {
        public int start;
        public int end; // 0x18
        public UnityEngine.AnimationClip duration; // 0x20
        public TransientBuildData muted;
        public string mutedInHierarchy;
        public System.Action`3<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> timelineAsset; // 0x18
        public System.Action`3<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> parent; // 0x20
        public bool clips; // 0x28
        public bool blendsValid; // 0x29
        public string isEmpty; // 0x30
        public UnityEngine.AnimationClip hasClips; // 0x38
        public UnityEngine.Playables.PlayableAsset hasCurves; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> isSubTrack; // 0x48
        public int outputs; // 0x50
        public UnityEngine.Timeline.TimelineClip[] customPlayableTypename; // 0x58
        public UnityEngine.Timeline.DiscreteTime curves; // 0x60
        public UnityEngine.Timeline.DiscreteTime UnityEngine.Timeline.ICurvesOwner.defaultCurvesName; // 0x68
        public bool UnityEngine.Timeline.ICurvesOwner.asset; // 0x70
        public bool UnityEngine.Timeline.ICurvesOwner.assetOwner; // 0x71
        public System.Nullable`1<bool> UnityEngine.Timeline.ICurvesOwner.targetTrack; // 0x72
        public UnityEngine.Timeline.TrackAsset[] subTracksObjects; // 0x28
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Timeline.TrackAsset> locked; // 0x78
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute> lockedInHierarchy; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Timeline.TimelineClip> supportsNotifications; // 0x80
        public UnityEngine.Timeline.MarkerList m_Markers; // 0x88

        // ── Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0x7FFD4E341310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD54BDCF70
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54BDD270
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFD4E341310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7FFD54BDD580
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7FFD54BDD6E0
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFD54BDD840
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFD54BDD9A0
        public void get_start(){} // RVA: 0x7FFD54BDDB00
        public void get_end(){} // RVA: 0x7FFD54BDDBA0
        public void get_duration(){} // RVA: 0x7FFD54BDDC40
        public void get_muted(){} // RVA: 0x7FFD4EC8C550
        public void set_muted(){} // RVA: 0x7FFD4F7D4D70
        public void get_mutedInHierarchy(){} // RVA: 0x7FFD54BDDCF0
        public void get_timelineAsset(){} // RVA: 0x7FFD54BDDFA0
        public void get_parent(){} // RVA: 0x7FFD4E3BE740
        public void set_parent(){} // RVA: 0x7FFD4E369200
        public void GetClips(){} // RVA: 0x7FFD54BDE280
        public void get_clips(){} // RVA: 0x7FFD54BDE290
        public void get_blendsValid(){} // RVA: 0x7FFD536664C0
        public void set_blendsValid(){} // RVA: 0x7FFD536664D0
        public void get_isEmpty(){} // RVA: 0x7FFD54BDE3F0
        public void get_hasClips(){} // RVA: 0x7FFD54BDE4A0
        public void get_hasCurves(){} // RVA: 0x7FFD54BDE4F0
        public void get_isSubTrack(){} // RVA: 0x7FFD54BDE620
        public void get_outputs(){} // RVA: 0x7FFD54BDE7A0
        public void GetChildTracks(){} // RVA: 0x7FFD54BDE850
        public void get_customPlayableTypename(){} // RVA: 0x7FFD4E5F95E0
        public void set_customPlayableTypename(){} // RVA: 0x7FFD4E36F890
        public void get_curves(){} // RVA: 0x7FFD4E5F0140
        public void set_curves(){} // RVA: 0x7FFD4E5F0C20
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFD54BDE870
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7FFD4F9181E0
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFD54BDE8B0
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFD4F9181E0
        public void get_subTracksObjects(){} // RVA: 0x7FFD4E3BC730
        public void get_locked(){} // RVA: 0x7FFD4E516BA0
        public void set_locked(){} // RVA: 0x7FFD4F044F40
        public void get_lockedInHierarchy(){} // RVA: 0x7FFD54BDE8C0
        public void get_supportsNotifications(){} // RVA: 0x7FFD54BDEB70
        public void __internalAwake(){} // RVA: 0x7FFD54BDEC00
        public void CreateCurves(){} // RVA: 0x7FFD54BDEDC0
        public void CreateTrackMixer(){} // RVA: 0x7FFD54BDEF20
        public void CreatePlayable(){} // RVA: 0x7FFD54BE4490 | overloaded x2
        public void CreateDefaultClip(){} // RVA: 0x7FFD54BDF0F0
        public void CreateClip(){} // RVA: 0x7FFD54BDF6A0 | overloaded x2
        public void DeleteClip(){} // RVA: 0x7FFD54BDF440
        public void CreateMarker(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void DeleteMarker(){} // RVA: 0x7FFD54BDF600
        public void GetMarkers(){} // RVA: 0x7FFD54BDF610
        public void GetMarkerCount(){} // RVA: 0x7FFD54BDF640
        public void GetMarker(){} // RVA: 0x7FFD54BDF690
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7FFD54BDF7E0
        public void CreateClipOfType(){} // RVA: 0x7FFD54BDF820
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7FFD54BDFB10
        public void CreateClipFromAsset(){} // RVA: 0x7FFD54BDFE40
        public void GetMarkersRaw(){} // RVA: 0x7FFD4E380010
        public void ClearMarkers(){} // RVA: 0x7FFD54BE0100
        public void AddMarker(){} // RVA: 0x7FFD54BE0170
        public void DeleteMarkerRaw(){} // RVA: 0x7FFD54BE0180
        public void GetTimeRangeHash(){} // RVA: 0x7FFD54BE01C0
        public void AddClip(){} // RVA: 0x7FFD54BE0420
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFD54BE0560
        public void CreatePlayableGraph(){} // RVA: 0x7FFD54BE0A70
        public void CompileClips(){} // RVA: 0x7FFD54BE0E10
        public void GatherCompilableTracks(){} // RVA: 0x7FFD54BE1300
        public void GatherNotifications(){} // RVA: 0x7FFD54BE15E0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFD54BE18F0
        public void ConfigureTrackAnimation(){} // RVA: 0x7FFD54BE2250
        public void SortClips(){} // RVA: 0x7FFD54BE23B0
        public void ClearClipsInternal(){} // RVA: 0x7FFD54BE2630
        public void ClearSubTracksInternal(){} // RVA: 0x7FFD54BE2750
        public void OnClipMove(){} // RVA: 0x7FFD54BE2820
        public void CreateNewClipContainerInternal(){} // RVA: 0x7FFD54BE2880
        public void AddChild(){} // RVA: 0x7FFD54BE2CB0
        public void MoveLastTrackBefore(){} // RVA: 0x7FFD54BE2E00
        public void RemoveSubTrack(){} // RVA: 0x7FFD54BE3190
        public void RemoveClip(){} // RVA: 0x7FFD54BE3270
        public void GetEvaluationTime(){} // RVA: 0x7FFD54BE3340
        public void GetSequenceTime(){} // RVA: 0x7FFD54BE3590
        public void GatherProperties(){} // RVA: 0x7FFD54BE35B0
        public void GetGameObjectBinding(){} // RVA: 0x7FFD54BE3C70
        public void ValidateClipType(){} // RVA: 0x7FFD54BE3F60
        public void OnCreateClip(){} // RVA: 0x7FFD4E341310
        public void UpdateDuration(){} // RVA: 0x7FFD54BE4270
        public void CalculateItemsHash(){} // RVA: 0x7FFD54BE43E0
        public void Invalidate(){} // RVA: 0x7FFD54BE4830
        public void GetNotificationDuration(){} // RVA: 0x7FFD54BE4960
        public void CanCompileClips(){} // RVA: 0x7FFD54BE4B60
        public void CanCreateTrackMixer(){} // RVA: 0x7FFD53A73E70
        public void IsCompilable(){} // RVA: 0x7FFD54BE4BC0
        public void UpdateChildTrackCache(){} // RVA: 0x7FFD54BE4EC0
        public void Hash(){} // RVA: 0x7FFD54BE5200
        public void GetClipsHash(){} // RVA: 0x7FFD54BE5280
        public void GetAnimationClipHash(){} // RVA: 0x7FFD54BE5520
        public void HasNotifications(){} // RVA: 0x7FFD54BE5710
        public void CanCompileNotifications(){} // RVA: 0x7FFD54BE5740
        public void CanCreateMixerRecursive(){} // RVA: 0x7FFD54BE5780
        public void .ctor(){} // RVA: 0x7FFD54BE5920
        public void .cctor(){} // RVA: 0x7FFD54BE5B00
    }

    public class TrackAssetExtensions : Object
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7FFD54BF20D0
        public void SetGroup(){} // RVA: 0x7FFD54BF2200
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFD54BF2990
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        public System.Type type; // 0x10
        public 0x665E2760 flags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCAC310 | overloaded x2
    }

    public class TrackClipTypeAttribute : Attribute
    {
        public System.Type inspectedType; // 0x10
        public bool allowAutoCreate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class TrackColorAttribute : Attribute
    {
        public UnityEngine.Color color; // 0x10

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFD4F842E80
        public void .ctor(){} // RVA: 0x7FFD54BE66C0
    }

    public class WeightUtility : Object
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7FFD54C03120
    }

}