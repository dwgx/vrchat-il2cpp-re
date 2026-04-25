// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 793

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public 0x6B282130 postPlayback; // 0x18
        public 0x6B282188 m_InitialState; // 0x1C

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97D2AD0
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC97D2D50
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D2E70
        public void ProcessFrame(){} // RVA: 0x7FFAC97D2F80
        public void OnGraphStart(){} // RVA: 0x7FFAC97D30A0
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC97D31D0
        public void .ctor(){} // RVA: 0x7FFAC9560410
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        public 0x6B2807C0 postPlaybackState; // 0x10
        public bool m_BoundGameObjectInitialStateIsActive; // 0x14
        public UnityEngine.GameObject m_BoundGameObject; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97AC1A0
        public void get_postPlaybackState(){} // RVA: 0x7FFAC2F6E5C0
        public void set_postPlaybackState(){} // RVA: 0x7FFAC2F240C0
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC97AC240
        public void ProcessFrame(){} // RVA: 0x7FFAC97AC370
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        public object clipCaps;

        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFAC34F9180
        public void CreatePlayable(){} // RVA: 0x7FFAC97AC6D0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class ActivationTrack : TrackAsset
    {
        public 0x6B2807C0 postPlaybackState; // 0xA0
        public UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer; // 0xA8

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFAC97AC7F0
        public void get_postPlaybackState(){} // RVA: 0x7FFAC489E510
        public void set_postPlaybackState(){} // RVA: 0x7FFAC97AC880
        public void CreateTrackMixer(){} // RVA: 0x7FFAC97AC8A0
        public void UpdateTrackMode(){} // RVA: 0x7FFAC97ACAE0
        public void GatherProperties(){} // RVA: 0x7FFAC97ACB00
        public void OnCreateClip(){} // RVA: 0x7FFAC97ACC20
        public void .ctor(){} // RVA: 0x7FFAC97ACCB0
    }

    public class AnimationOutputWeightProcessor : Object
    {
        public UnityEngine.Animations.AnimationPlayableOutput m_Output; // 0x10
        public UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_MotionXPlayable; // 0x20
        public System.Collections.Generic.List`1<WeightInfo> m_Mixers; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97ACD10
        public void FindMixers(){} // RVA: 0x7FFAC97AD0F0 | overloaded x2
        public void Evaluate(){} // RVA: 0x7FFAC97AD500
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        public UnityEngine.AnimationClip position; // 0x18
        public UnityEngine.Vector3 rotation; // 0x20
        public UnityEngine.Vector3 eulerAngles; // 0x2C
        public bool useTrackMatchFields; // 0x38
        public 0x6B280B30 matchTargetFields; // 0x3C
        public bool removeStartOffset; // 0x40
        public bool applyFootIK; // 0x41
        public 0x6B280920 loop; // 0x44
        public 0x6B280BE0 hasRootTransforms; // 0x48
        public int appliedOffsetMode;
        public int clip; // 0x4C
        public UnityEngine.Quaternion duration; // 0x50

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC2F87EE0
        public void set_position(){} // RVA: 0x7FFAC2F87F00
        public void get_rotation(){} // RVA: 0x7FFAC97AD770
        public void set_rotation(){} // RVA: 0x7FFAC97AD820
        public void get_eulerAngles(){} // RVA: 0x7FFAC2F87F10
        public void set_eulerAngles(){} // RVA: 0x7FFAC2F87F30
        public void get_useTrackMatchFields(){} // RVA: 0x7FFAC31D95D0
        public void set_useTrackMatchFields(){} // RVA: 0x7FFAC31D95C0
        public void get_matchTargetFields(){} // RVA: 0x7FFAC33BD4A0
        public void set_matchTargetFields(){} // RVA: 0x7FFAC47E2CD0
        public void get_removeStartOffset(){} // RVA: 0x7FFAC2FDCC00
        public void set_removeStartOffset(){} // RVA: 0x7FFAC2FDCC10
        public void get_applyFootIK(){} // RVA: 0x7FFAC31D8A60
        public void set_applyFootIK(){} // RVA: 0x7FFAC31D8A10
        public void get_loop(){} // RVA: 0x7FFAC2FC20A0
        public void set_loop(){} // RVA: 0x7FFAC2FC20B0
        public void get_hasRootTransforms(){} // RVA: 0x7FFAC97AD850
        public void get_appliedOffsetMode(){} // RVA: 0x7FFAC2FC20C0
        public void set_appliedOffsetMode(){} // RVA: 0x7FFAC2FC20D0
        public void get_clip(){} // RVA: 0x7FFAC2F247C0
        public void set_clip(){} // RVA: 0x7FFAC97AD960
        public void get_duration(){} // RVA: 0x7FFAC97ADAB0
        public void get_outputs(){} // RVA: 0x7FFAC97ADB60
        public void CreatePlayable(){} // RVA: 0x7FFAC97ADD40 | overloaded x2
        public void ShouldApplyOffset(){} // RVA: 0x7FFAC97AE620
        public void ShouldApplyScaleRemove(){} // RVA: 0x7FFAC97AE690
        public void get_clipCaps(){} // RVA: 0x7FFAC97AE6B0
        public void ResetOffsets(){} // RVA: 0x7FFAC97AE8A0
        public void GatherProperties(){} // RVA: 0x7FFAC97AE930
        public void HasRootTransforms(){} // RVA: 0x7FFAC97AEA00
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC97AEB90
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC97AEBF0
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAC97AEC80
        public void .ctor(){} // RVA: 0x7FFAC97AECC0
        public void .cctor(){} // RVA: 0x7FFAC97AEDE0
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        public UnityEngine.Animations.AnimationPlayableOutput m_Output; // 0x10
        public UnityEngine.Playables.PlayableGraph m_Graph; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Animations.IAnimationWindowPreview> m_PreviewComponents; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97AF0D0
        public void Evaluate(){} // RVA: 0x7FFAC97AF190
        public void FetchPreviewComponents(){} // RVA: 0x7FFAC97AF400
    }

    public class AnimationTrack : TrackAsset
    {
        public string position;
        public string rotation;
        public 0x6B280EA0 eulerAngles; // 0xA0
        public 0x6B280EA0 applyOffsets; // 0xA4
        public UnityEngine.Vector3 trackOffset; // 0xA8
        public UnityEngine.Vector3 matchTargetFields; // 0xB4
        public double infiniteClip; // 0xC0
        public bool infiniteClipRemoveOffset; // 0xC8
        public bool avatarMask; // 0xC9
        public 0x6B280920 applyAvatarMask; // 0xCC
        public 0x6B280B30 outputs; // 0xD0
        public UnityEngine.Vector3 inClipMode; // 0xD4
        public UnityEngine.Vector3 infiniteClipOffsetPosition; // 0xE0
        public UnityEngine.AvatarMask infiniteClipOffsetRotation; // 0xF0
        public bool infiniteClipOffsetEulerAngles; // 0xF8
        public 0x6B280B88 infiniteClipApplyFootIK; // 0xFC
        public UnityEngine.AnimationClip infiniteClipTimeOffset; // 0x100
        public System.Collections.Generic.Queue`1<UnityEngine.Transform> infiniteClipPreExtrapolation;
        public UnityEngine.Quaternion infiniteClipPostExtrapolation; // 0x108
        public UnityEngine.Quaternion infiniteClipLoop; // 0x118
        public bool openClipOffsetPosition; // 0x128

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC6715360
        public void set_position(){} // RVA: 0x7FFAC6715380
        public void get_rotation(){} // RVA: 0x7FFAC97AF750
        public void set_rotation(){} // RVA: 0x7FFAC97AF800
        public void get_eulerAngles(){} // RVA: 0x7FFAC97AF830
        public void set_eulerAngles(){} // RVA: 0x7FFAC97AF850
        public void get_applyOffsets(){} // RVA: 0x7FFAC2F21320
        public void set_applyOffsets(){} // RVA: 0x7FFAC2F21310
        public void get_trackOffset(){} // RVA: 0x7FFAC3C8BB20
        public void set_trackOffset(){} // RVA: 0x7FFAC97AF870
        public void get_matchTargetFields(){} // RVA: 0x7FFAC3696B20
        public void set_matchTargetFields(){} // RVA: 0x7FFAC97AF880
        public void get_infiniteClip(){} // RVA: 0x7FFAC34F6C80
        public void set_infiniteClip(){} // RVA: 0x7FFAC34F6750
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7FFAC3D2B010
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7FFAC3D23EE0
        public void get_avatarMask(){} // RVA: 0x7FFAC2F8C2A0
        public void set_avatarMask(){} // RVA: 0x7FFAC2F8C2B0
        public void get_applyAvatarMask(){} // RVA: 0x7FFAC3C8E090
        public void set_applyAvatarMask(){} // RVA: 0x7FFAC97AF8F0
        public void CanCompileClips(){} // RVA: 0x7FFAC97AF900
        public void get_outputs(){} // RVA: 0x7FFAC97AFA40
        public void get_inClipMode(){} // RVA: 0x7FFAC97AFAF0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7FFAC97AFB30
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7FFAC97AFB50
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7FFAC97AFB70
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7FFAC97AFC20
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFAC97AFC50
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFAC97AFC70
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFAC3D233D0
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7FFAC3D24CD0
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7FFAC97AFC90
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7FFAC97AFCA0
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7FFAC489E510
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7FFAC489E550
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7FFAC6539470
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7FFAC6539480
        public void get_infiniteClipLoop(){} // RVA: 0x7FFAC43065A0
        public void set_infiniteClipLoop(){} // RVA: 0x7FFAC88C71C0
        public void ResetOffsets(){} // RVA: 0x7FFAC97AFCB0
        public void CreateClip(){} // RVA: 0x7FFAC97AFD50
        public void CreateInfiniteClip(){} // RVA: 0x7FFAC97AFE70
        public void CreateRecordableClip(){} // RVA: 0x7FFAC97B0050
        public void OnCreateClip(){} // RVA: 0x7FFAC97B0330
        public void CalculateItemsHash(){} // RVA: 0x7FFAC97B03A0
        public void UpdateClipOffsets(){} // RVA: 0x7FFAC2F21310
        public void CompileTrackPlayable(){} // RVA: 0x7FFAC97B04B0
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7FFAC97B0AC0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFAC97B0B60
        public void GetDefaultBlendCount(){} // RVA: 0x7FFAC34F9180
        public void AttachDefaultBlend(){} // RVA: 0x7FFAC2F21310
        public void AttachOffsetPlayable(){} // RVA: 0x7FFAC97B1720
        public void RequiresMotionXPlayable(){} // RVA: 0x7FFAC97B1900
        public void UsesAbsoluteMotion(){} // RVA: 0x7FFAC97B1AE0
        public void HasController(){} // RVA: 0x7FFAC97B1AF0
        public void GetBinding(){} // RVA: 0x7FFAC97B1D80
        public void CreateGroupMixer(){} // RVA: 0x7FFAC97B2160
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7FFAC97B2250
        public void ApplyTrackOffset(){} // RVA: 0x7FFAC97B27B0
        public void GetEvaluationTime(){} // RVA: 0x7FFAC97B2A40
        public void GetSequenceTime(){} // RVA: 0x7FFAC97B2B10
        public void AssignAnimationClip(){} // RVA: 0x7FFAC97B2C60
        public void GatherProperties(){} // RVA: 0x7FFAC2F21310
        public void GetAnimationClips(){} // RVA: 0x7FFAC97B30E0
        public void GetOffsetMode(){} // RVA: 0x7FFAC97B36E0
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7FFAC97B3810
        public void GetGenericRootNode(){} // RVA: 0x7FFAC97B3DF0
        public void AnimatesRootTransform(){} // RVA: 0x7FFAC97B41D0
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7FFAC97B4480
        public void get_openClipOffsetPosition(){} // RVA: 0x7FFAC97AFB30
        public void set_openClipOffsetPosition(){} // RVA: 0x7FFAC97AFB50
        public void get_openClipOffsetRotation(){} // RVA: 0x7FFAC97AFB70
        public void set_openClipOffsetRotation(){} // RVA: 0x7FFAC97B46C0
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7FFAC97AFC50
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7FFAC97AFC70
        public void get_openClipPreExtrapolation(){} // RVA: 0x7FFAC489E510
        public void set_openClipPreExtrapolation(){} // RVA: 0x7FFAC489E550
        public void get_openClipPostExtrapolation(){} // RVA: 0x7FFAC6539470
        public void set_openClipPostExtrapolation(){} // RVA: 0x7FFAC6539480
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAC97B4700
        public void .ctor(){} // RVA: 0x7FFAC97B48F0
        public void .cctor(){} // RVA: 0x7FFAC97B4B20
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        public float volume; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97C6700
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        public float volume; // 0x10
        public float stereoPan; // 0x14
        public float spatialBlend; // 0x18

        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7FFAC97C6710
        public void .ctor(){} // RVA: 0x7FFAC97C6700
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        public UnityEngine.AudioClip bufferingTime; // 0x18
        public bool clip; // 0x20
        public float loop; // 0x24
        public UnityEngine.Timeline.AudioClipProperties duration; // 0x28

        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x7FFAC308EF50
        public void set_bufferingTime(){} // RVA: 0x7FFAC308EF60
        public void get_clip(){} // RVA: 0x7FFAC2F247C0
        public void set_clip(){} // RVA: 0x7FFAC2F87E80
        public void get_loop(){} // RVA: 0x7FFAC300F9D0
        public void set_loop(){} // RVA: 0x7FFAC300F9E0
        public void get_duration(){} // RVA: 0x7FFAC97C6B00
        public void get_outputs(){} // RVA: 0x7FFAC97C6D00
        public void CreatePlayable(){} // RVA: 0x7FFAC97C6DB0
        public void get_clipCaps(){} // RVA: 0x7FFAC97C7030
        public void .ctor(){} // RVA: 0x7FFAC97C7040
    }

    public class AudioTrack : TrackAsset
    {
        public UnityEngine.Timeline.AudioMixerProperties outputs; // 0xA0

        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7FFAC97C7340
        public void CompileClips(){} // RVA: 0x7FFAC97C7640
        public void get_outputs(){} // RVA: 0x7FFAC97C7FB0
        public void OnValidate(){} // RVA: 0x7FFAC97C8060
        public void .ctor(){} // RVA: 0x7FFAC97C8100
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        public object duration;
        public object outputs;

        // ── Methods ──
        public void get_duration(){} // RVA: 0x7FFAC97D3310
        public void get_outputs(){} // RVA: 0x7FFAC97D3370
        public void OnGraphStart(){} // RVA: 0x7FFAC2F21310
        public void OnGraphStop(){} // RVA: 0x7FFAC2F21310
        public void OnPlayableCreate(){} // RVA: 0x7FFAC2F21310
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC2F21310
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC2F21310
        public void OnBehaviourPause(){} // RVA: 0x7FFAC2F21310
        public void PrepareFrame(){} // RVA: 0x7FFAC2F21310
        public void ProcessFrame(){} // RVA: 0x7FFAC2F21310
        public void CreatePlayable(){} // RVA: 0x7FFAC97D33D0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class BlendUtility : Object
    {
        public double kMinOverlapTime;

        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7FFAC97DC990
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFAC97DCAD0
        public void UpdateClipIntersection(){} // RVA: 0x7FFAC97DCEF0
        public void .cctor(){} // RVA: 0x7FFAC97DD0E0
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
        public 0x6B282130 postPlayback; // 0x3C
        public 0x6B282290 directorOnClipEnd; // 0x40
        public UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset; // 0x48
        public double m_Duration; // 0x50
        public bool m_SupportLoop; // 0x58
        public System.Collections.Generic.HashSet`1<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors; // 0x18
        public System.Collections.Generic.HashSet`1<UnityEngine.GameObject> s_CreatedPrefabs; // 0x20
        public bool <controllingDirectors>k__BackingField; // 0x59
        public bool <controllingParticles>k__BackingField; // 0x5A

        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7FFAC778CF40
        public void set_controllingDirectors(){} // RVA: 0x7FFAC87B5A20
        public void get_controllingParticles(){} // RVA: 0x7FFAC313BB50
        public void set_controllingParticles(){} // RVA: 0x7FFAC3142110
        public void OnEnable(){} // RVA: 0x7FFAC97C8430
        public void get_duration(){} // RVA: 0x7FFAC6C28EF0
        public void get_clipCaps(){} // RVA: 0x7FFAC97C8490
        public void CreatePlayable(){} // RVA: 0x7FFAC97C84A0
        public void ConnectPlayablesToMixer(){} // RVA: 0x7FFAC97C92E0
        public void CreateActivationPlayable(){} // RVA: 0x7FFAC97C9730
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7FFAC97C98F0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7FFAC97C9CD0
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7FFAC97CA220
        public void ConnectMixerAndPlayable(){} // RVA: 0x7FFAC97CA710
        public void GetComponent(){} // RVA: 0x7FFAC2C58F40
        public void GetControlableScripts(){} // RVA: 0x7FFAC97CA850
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7FFAC97CA900
        public void GetControllableParticleSystems(){} // RVA: 0x7FFAC97CB3F0 | overloaded x2
        public void CacheSubEmitters(){} // RVA: 0x7FFAC97CB6F0
        public void GatherProperties(){} // RVA: 0x7FFAC97CB980
        public void PreviewParticles(){} // RVA: 0x7FFAC97CBD90
        public void PreviewActivation(){} // RVA: 0x7FFAC97CC1E0
        public void PreviewTimeControl(){} // RVA: 0x7FFAC97CC460
        public void PreviewDirectors(){} // RVA: 0x7FFAC97CC6B0
        public void .ctor(){} // RVA: 0x7FFAC97CCA30
        public void .cctor(){} // RVA: 0x7FFAC97CCAB0
    }

    public class ControlTrack : TrackAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97CD200
    }

    public class CurveEditUtility : Object
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7FFAC97CD250
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CustomStyleAttribute : Attribute
    {
        public string ussStyle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        public UnityEngine.Playables.PlayableDirector director; // 0x10
        public 0x6B282290 pauseAction; // 0x18
        public bool m_SyncTime; // 0x1C
        public double m_AssetDuration; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97D3590
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC97D37F0
        public void PrepareFrame(){} // RVA: 0x7FFAC97D39C0
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC97D3CB0
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D3E70
        public void ProcessFrame(){} // RVA: 0x7FFAC97D4050
        public void SyncSpeed(){} // RVA: 0x7FFAC97D45C0
        public void SyncStart(){} // RVA: 0x7FFAC97D49A0
        public void SyncStop(){} // RVA: 0x7FFAC97D4B60
        public void DetectDiscontinuity(){} // RVA: 0x7FFAC97D4D40
        public void DetectOutOfSync(){} // RVA: 0x7FFAC97D4F70
        public void UpdateTime(){} // RVA: 0x7FFAC97D50D0
        public void .ctor(){} // RVA: 0x7FFAC97D5310
    }

    public class DiscreteTime : ValueType
    {
        public double tickValue;
        public UnityEngine.Timeline.DiscreteTime kMaxTime;
        public long m_DiscreteTime; // 0x10

        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7FFAC97CD420
        public void .ctor(){} // RVA: 0x7FFAC97CD590 | overloaded x6
        public void OneTickBefore(){} // RVA: 0x7FFAC97CD610
        public void OneTickAfter(){} // RVA: 0x7FFAC97CD620
        public void GetTick(){} // RVA: 0x7FFAC3AD9F60
        public void FromTicks(){} // RVA: 0x7FFAC44F81E0
        public void CompareTo(){} // RVA: 0x7FFAC97CD630
        public void Equals(){} // RVA: 0x7FFAC97CD6E0 | overloaded x2
        public void DoubleToDiscreteTime(){} // RVA: 0x7FFAC97CD780
        public void FloatToDiscreteTime(){} // RVA: 0x7FFAC97CD810
        public void IntToDiscreteTime(){} // RVA: 0x7FFAC97CD8A0
        public void ToDouble(){} // RVA: 0x7FFAC97CD900
        public void ToFloat(){} // RVA: 0x7FFAC97CD920
        public void op_Explicit(){} // RVA: 0x7FFAC44F81E0 | overloaded x6
        public void op_Implicit(){} // RVA: 0x7FFAC97CDB30
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC97CDBC0
        public void op_GreaterThan(){} // RVA: 0x7FFAC8650B80
        public void op_LessThan(){} // RVA: 0x7FFAC8650B60
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC8650B70
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC8650B90
        public void op_Addition(){} // RVA: 0x7FFAC530B350
        public void op_Subtraction(){} // RVA: 0x7FFAC97CDC20
        public void ToString(){} // RVA: 0x7FFAC97CDC30
        public void GetHashCode(){} // RVA: 0x7FFAC97CDCD0
        public void Min(){} // RVA: 0x7FFAC97CDCE0
        public void Max(){} // RVA: 0x7FFAC97CDD40
        public void SnapToNearestTick(){} // RVA: 0x7FFAC97CDE10 | overloaded x2
        public void GetNearestTick(){} // RVA: 0x7FFAC97CDEC0
        public void .cctor(){} // RVA: 0x7FFAC97CDF20
    }

    public class Extrapolation : Object
    {
        public double kMinExtrapolationTime;

        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7FFAC97DD380
        public void SortClipsByStartTime(){} // RVA: 0x7FFAC97DD850
        public void .cctor(){} // RVA: 0x7FFAC97DDB60
    }

    public class FrameRateFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GroupTrack : TrackAsset
    {
        public object outputs;

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFAC2F21320
        public void get_outputs(){} // RVA: 0x7FFAC97D2A20
        public void .ctor(){} // RVA: 0x7FFAC97D2A80
    }

    public class HashUtility : Object
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7FFAC97DDEE0 | overloaded x7
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_curves(){} // RVA: 0x7FFAC2C58E90
        public void get_hasCurves(){} // RVA: 0x7FFAC2C59D00
        public void get_duration(){} // RVA: 0x7FFAC2C5EB60
        public void CreateCurves(){} // RVA: 0x7FFAC2C70A40
        public void get_defaultCurvesName(){} // RVA: 0x7FFAC2C58E90
        public void get_asset(){} // RVA: 0x7FFAC2C58E90
        public void get_assetOwner(){} // RVA: 0x7FFAC2C58E90
        public void get_targetTrack(){} // RVA: 0x7FFAC2C58E90
    }

    public class IInterval
    {
        public object intervalStart;
        public object intervalEnd;

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFAC2C58E90
        public void get_intervalEnd(){} // RVA: 0x7FFAC2C58E90
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
        public void get_time(){} // RVA: 0x7FFAC2C5EB60
        public void set_time(){} // RVA: 0x7FFAC2C72080
        public void get_parent(){} // RVA: 0x7FFAC2C58E90
        public void Initialize(){} // RVA: 0x7FFAC2C70A40
    }

    public class INotificationOptionProvider
    {
        public object flags;

        // ── Methods ──
        public void get_flags(){} // RVA: 0x7FFAC2C58DC0
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7FFAC2C70A40
        public void PopActiveGameObject(){} // RVA: 0x7FFAC2C70980
        public void AddFromClip(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void AddFromClips(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void AddFromName(){} // RVA: 0x7FFAC2C79B30 | overloaded x5
        public void AddFromComponent(){} // RVA: 0x7FFAC2C79B30
        public void AddObjectProperties(){} // RVA: 0x7FFAC2C79B30
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x7FFAC2C79B30
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x7FFAC2C72080
        public void OnControlTimeStart(){} // RVA: 0x7FFAC2C70980
        public void OnControlTimeStop(){} // RVA: 0x7FFAC2C70980
    }

    public class ITimelineClipAsset
    {
        public object clipCaps;

        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFAC2C59960
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFAC2C70980
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        public UnityEngine.Playables.Playable intervalStart; // 0x18
        public long intervalEnd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC35D34F0
        public void get_intervalStart(){} // RVA: 0x7FFAC34F9180
        public void get_intervalEnd(){} // RVA: 0x7FFAC97CDF70
        public void set_enable(){} // RVA: 0x7FFAC97CDFD0
        public void EvaluateAt(){} // RVA: 0x7FFAC97CE050
        public void DisableAt(){} // RVA: 0x7FFAC97CE0B0
        public void .cctor(){} // RVA: 0x7FFAC97CE120
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
        public System.Collections.Generic.List`1<Entry<T>> m_Entries;
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;
        public bool <dirty>k__BackingField;

        // ── Methods ──
        public void get_dirty(){} // RVA: 0x7FFAC2C59D00
        public void set_dirty(){} // RVA: 0x7FFAC2C71060
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateIntervals(){} // RVA: 0x7FFAC2C70980
        public void Query(){} // RVA: 0x7FFAC2E8DC40
        public void QueryRange(){} // RVA: 0x7FFAC2E8DC40
        public void Rebuild(){} // RVA: 0x7FFAC2C60290 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Marker : ScriptableObject
    {
        public double parent; // 0x18
        public UnityEngine.Timeline.TrackAsset time; // 0x20

        // ── Methods ──
        public void get_parent(){} // RVA: 0x7FFAC2F4F0C0
        public void set_parent(){} // RVA: 0x7FFAC2F4F0D0
        public void get_time(){} // RVA: 0x7FFAC4422FA0
        public void set_time(){} // RVA: 0x7FFAC97CF330
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7FFAC97CF3D0
        public void OnInitialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class MarkerList : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> markers; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> Count; // 0x18
        public bool Item; // 0x20
        public bool m_HasNotifications; // 0x21

        // ── Methods ──
        public void get_markers(){} // RVA: 0x7FFAC97CF570
        public void .ctor(){} // RVA: 0x7FFAC97CF590
        public void Add(){} // RVA: 0x7FFAC97CF710
        public void Remove(){} // RVA: 0x7FFAC97CF990 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC97CFA50
        public void Contains(){} // RVA: 0x7FFAC97CFAC0
        public void GetMarkers(){} // RVA: 0x7FFAC97CF570
        public void get_Count(){} // RVA: 0x7FFAC97CFB20
        public void get_Item(){} // RVA: 0x7FFAC97CFB70
        public void GetRawMarkerList(){} // RVA: 0x7FFAC3AD9F60
        public void CreateMarker(){} // RVA: 0x7FFAC97CFBF0
        public void HasNotifications(){} // RVA: 0x7FFAC97CFF20
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC322C870
        public void BuildCache(){} // RVA: 0x7FFAC97CFF40
    }

    public class MarkerTrack : TrackAsset
    {
        public object outputs;

        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7FFAC97D02A0
        public void .ctor(){} // RVA: 0x7FFAC97D0570
    }

    public class MatchTargetFieldConstants : Object
    {
        public 0x6B280B30 All;
        public 0x6B280B30 None; // 0x4
        public 0x6B280B30 Position; // 0x8
        public 0x6B280B30 Rotation; // 0xC

        // ── Methods ──
        public void HasAny(){} // RVA: 0x7FFAC97AF650
        public void Toggle(){} // RVA: 0x7FFAC97AF6C0
        public void .cctor(){} // RVA: 0x7FFAC97AF6D0
    }

    public class MenuCategoryAttribute : Attribute
    {
        public string category; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97D88E0
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NotificationUtilities : Object
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFAC97DDFE0 | overloaded x3
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7FFAC97DE720
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        public float particleSystem;
        public float m_LastPlayableTime; // 0x10
        public float m_LastParticleTime; // 0x14
        public uint m_RandomSeed; // 0x18
        public UnityEngine.ParticleSystem <particleSystem>k__BackingField; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97D5320
        public void get_particleSystem(){} // RVA: 0x7FFAC2F4F0C0
        public void set_particleSystem(){} // RVA: 0x7FFAC2F4F0D0
        public void Initialize(){} // RVA: 0x7FFAC97D55F0
        public void SetRandomSeed(){} // RVA: 0x7FFAC97D56B0
        public void PrepareFrame(){} // RVA: 0x7FFAC97D59C0
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC97D5C70
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D5C70
        public void Simulate(){} // RVA: 0x7FFAC97D5C80
        public void .ctor(){} // RVA: 0x7FFAC97D5E50
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7FFAC97D86B0
        public void .ctor(){} // RVA: 0x7FFAC97D8820
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        public UnityEngine.GameObject prefabInstance; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97D5E70
        public void get_prefabInstance(){} // RVA: 0x7FFAC2F3C380
        public void Initialize(){} // RVA: 0x7FFAC97D60A0
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC97D6490
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC97D6610
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D6730
        public void SetHideFlagsRecursive(){} // RVA: 0x7FFAC97D6840
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeClip : RuntimeClipBase
    {
        public UnityEngine.Timeline.TimelineClip start; // 0x18
        public UnityEngine.Playables.Playable duration; // 0x20
        public UnityEngine.Playables.Playable clip; // 0x30

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAC97CE210
        public void get_duration(){} // RVA: 0x7FFAC97CE240
        public void .ctor(){} // RVA: 0x7FFAC97CE260
        public void Create(){} // RVA: 0x7FFAC97CE260
        public void get_clip(){} // RVA: 0x7FFAC2F247C0
        public void get_mixer(){} // RVA: 0x7FFAC845FF30
        public void get_playable(){} // RVA: 0x7FFAC4A19630
        public void set_enable(){} // RVA: 0x7FFAC97CE330
        public void SetTime(){} // RVA: 0x7FFAC97CE490
        public void SetDuration(){} // RVA: 0x7FFAC97CE4F0
        public void EvaluateAt(){} // RVA: 0x7FFAC97CE550
        public void DisableAt(){} // RVA: 0x7FFAC97CE8A0
    }

    public class RuntimeClipBase : RuntimeElement
    {
        public object start;
        public object duration;
        public object intervalStart;
        public object intervalEnd;

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAC2C5EB60
        public void get_duration(){} // RVA: 0x7FFAC2C5EB60
        public void get_intervalStart(){} // RVA: 0x7FFAC97CEAB0
        public void get_intervalEnd(){} // RVA: 0x7FFAC97CEB60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeElement : Object
    {
        public int intervalStart; // 0x10

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFAC2C58E90
        public void get_intervalEnd(){} // RVA: 0x7FFAC2C58E90
        public void get_intervalBit(){} // RVA: 0x7FFAC2F6E5C0
        public void set_intervalBit(){} // RVA: 0x7FFAC2F240C0
        public void set_enable(){} // RVA: 0x7FFAC2C71060
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_start(){} // RVA: 0x7FFAC97CEC30
        public void get_duration(){} // RVA: 0x7FFAC97CECE0
        public void SetTime(){} // RVA: 0x7FFAC97CED30
        public void get_clip(){} // RVA: 0x7FFAC2F247C0
        public void get_mixer(){} // RVA: 0x7FFAC845FF30
        public void get_playable(){} // RVA: 0x7FFAC4A19630
        public void .ctor(){} // RVA: 0x7FFAC97CED90
        public void Create(){} // RVA: 0x7FFAC97CED90
        public void set_enable(){} // RVA: 0x7FFAC97CEE70
        public void EvaluateAt(){} // RVA: 0x7FFAC97CEF90
        public void DisableAt(){} // RVA: 0x7FFAC97CF310
    }

    public class SignalAsset : ScriptableObject
    {
        public System.Action`1<UnityEngine.Timeline.SignalAsset> OnEnableCallback;

        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7FFAC97D05C0
        public void remove_OnEnableCallback(){} // RVA: 0x7FFAC97D06F0
        public void OnEnable(){} // RVA: 0x7FFAC97D0820
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SignalEmitter : Marker
    {
        public bool retroactive; // 0x28
        public bool emitOnce; // 0x29
        public UnityEngine.Timeline.SignalAsset asset; // 0x30

        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x7FFAC30F6BA0
        public void set_retroactive(){} // RVA: 0x7FFAC3C24F40
        public void get_emitOnce(){} // RVA: 0x7FFAC386C550
        public void set_emitOnce(){} // RVA: 0x7FFAC43B4D70
        public void get_asset(){} // RVA: 0x7FFAC31D95E0
        public void set_asset(){} // RVA: 0x7FFAC2F4F890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7FFAC97D0880
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7FFAC97D0A20
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SignalReceiver : MonoBehaviour
    {
        public EventKeyValue m_Events; // 0x20

        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFAC97D0A50
        public void AddReaction(){} // RVA: 0x7FFAC97D0C50
        public void AddEmptyReaction(){} // RVA: 0x7FFAC97D0E10
        public void Remove(){} // RVA: 0x7FFAC97D0E80
        public void GetRegisteredSignals(){} // RVA: 0x7FFAC356A5F0
        public void GetReaction(){} // RVA: 0x7FFAC97D1000
        public void Count(){} // RVA: 0x7FFAC97D1040
        public void ChangeSignalAtIndex(){} // RVA: 0x7FFAC97D1090
        public void RemoveAtIndex(){} // RVA: 0x7FFAC97D1550
        public void ChangeReactionAtIndex(){} // RVA: 0x7FFAC97D1660
        public void GetReactionAtIndex(){} // RVA: 0x7FFAC97D1750
        public void GetSignalAssetAtIndex(){} // RVA: 0x7FFAC97D1830
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC97D1910
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97D0570
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        public System.Type childType; // 0x10
        public int levels; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        public UnityEngine.Timeline.ITimeControl m_timeControl; // 0x10
        public bool m_started; // 0x18

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC97D6C80
        public void Initialize(){} // RVA: 0x7FFAC2F22E30
        public void PrepareFrame(){} // RVA: 0x7FFAC97D6E40
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC97D6EC0
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D6F20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TimeFieldAttribute : PropertyAttribute
    {
        public 0x6B2828C0 useEditMode; // 0x10

        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public System.Collections.Generic.List`1<NotificationEntry> timeSource; // 0x10
        public double m_PreviousTime; // 0x18
        public bool m_NeedSortNotifications; // 0x20
        public UnityEngine.Playables.Playable m_TimeSource; // 0x28

        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x7FFAC3BCC210
        public void Create(){} // RVA: 0x7FFAC97D6F80
        public void AddNotification(){} // RVA: 0x7FFAC97D7180
        public void OnGraphStart(){} // RVA: 0x7FFAC97D7280
        public void OnBehaviourPause(){} // RVA: 0x7FFAC97D74A0
        public void PrepareFrame(){} // RVA: 0x7FFAC97D7770
        public void SortNotifications(){} // RVA: 0x7FFAC97D7B60
        public void CanRestoreNotification(){} // RVA: 0x7FFAC97D7D80
        public void TriggerNotificationsInRange(){} // RVA: 0x7FFAC97D7DC0
        public void SyncDurationWithExternalSource(){} // RVA: 0x7FFAC97D8070
        public void Trigger_internal(){} // RVA: 0x7FFAC97D8330
        public void Restore_internal(){} // RVA: 0x7FFAC322C880
        public void .ctor(){} // RVA: 0x7FFAC97D84D0
    }

    public class TimeUtility : Object
    {
        public double kTimeEpsilon;
        public double kFrameRateEpsilon; // 0x8
        public double k_MaxTimelineDurationInSeconds; // 0x10
        public double kFrameRateRounding; // 0x18

        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7FFAC97E04D0
        public void ToFrames(){} // RVA: 0x7FFAC97E0590
        public void ToExactFrames(){} // RVA: 0x7FFAC97E0700
        public void FromFrames(){} // RVA: 0x7FFAC97E07E0 | overloaded x2
        public void OnFrameBoundary(){} // RVA: 0x7FFAC97E0CF0 | overloaded x2
        public void GetEpsilon(){} // RVA: 0x7FFAC97E0960
        public void PreviousFrame(){} // RVA: 0x7FFAC97E0A50
        public void NextFrame(){} // RVA: 0x7FFAC97E0AF0
        public void PreviousFrameTime(){} // RVA: 0x7FFAC97E0B60
        public void NextFrameTime(){} // RVA: 0x7FFAC97E0C40
        public void RoundToFrame(){} // RVA: 0x7FFAC97E0DC0
        public void TimeAsFrames(){} // RVA: 0x7FFAC97E0EC0
        public void TimeAsTimeCode(){} // RVA: 0x7FFAC97E1050
        public void ParseTimeCode(){} // RVA: 0x7FFAC97E1750
        public void ParseTimeSeconds(){} // RVA: 0x7FFAC97E1E30
        public void GetAnimationClipLength(){} // RVA: 0x7FFAC97E2360
        public void RemoveChar(){} // RVA: 0x7FFAC97E2560
        public void GetClosestFrameRate(){} // RVA: 0x7FFAC97E2630
        public void ToFrameRate(){} // RVA: 0x7FFAC97E28C0
        public void ToStandardFrameRate(){} // RVA: 0x7FFAC97E2AB0
        public void .cctor(){} // RVA: 0x7FFAC97E2F20
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
        public EditorSettings rootTrackCount; // 0x48
        public 0x6B2810B0 flattenedTracks; // 0x50
        public UnityEngine.Timeline.MarkerTrack markerTrack; // 0x58

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAC2F21310
        public void get_editorSettings(){} // RVA: 0x7FFAC2F9C730
        public void get_duration(){} // RVA: 0x7FFAC97B7FE0
        public void get_fixedDuration(){} // RVA: 0x7FFAC97B8080
        public void set_fixedDuration(){} // RVA: 0x7FFAC97B81A0
        public void get_durationMode(){} // RVA: 0x7FFAC30F10E0
        public void set_durationMode(){} // RVA: 0x7FFAC31D9010
        public void get_outputs(){} // RVA: 0x7FFAC97B8240
        public void get_clipCaps(){} // RVA: 0x7FFAC97B82F0
        public void get_outputTrackCount(){} // RVA: 0x7FFAC97B84B0
        public void get_rootTrackCount(){} // RVA: 0x7FFAC97B84E0
        public void OnValidate(){} // RVA: 0x7FFAC97B8530
        public void GetRootTrack(){} // RVA: 0x7FFAC97B8570
        public void GetRootTracks(){} // RVA: 0x7FFAC97B85F0
        public void GetOutputTrack(){} // RVA: 0x7FFAC97B8610
        public void GetOutputTracks(){} // RVA: 0x7FFAC97B8660
        public void GetValidFrameRate(){} // RVA: 0x7FFAC97B8680
        public void UpdateRootTrackCache(){} // RVA: 0x7FFAC97B8770
        public void UpdateOutputTrackCache(){} // RVA: 0x7FFAC97B8BF0
        public void get_flattenedTracks(){} // RVA: 0x7FFAC97B8E90
        public void get_markerTrack(){} // RVA: 0x7FFAC2FE9500
        public void get_trackObjects(){} // RVA: 0x7FFAC2F4F0C0
        public void AddTrackInternal(){} // RVA: 0x7FFAC97B90A0
        public void RemoveTrack(){} // RVA: 0x7FFAC97B9150
        public void CreatePlayable(){} // RVA: 0x7FFAC97B92D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC36970B0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC97B95A0
        public void __internalAwake(){} // RVA: 0x7FFAC97B95B0
        public void GatherProperties(){} // RVA: 0x7FFAC97B9810
        public void CreateMarkerTrack(){} // RVA: 0x7FFAC97B9A20
        public void RemoveMarkerTrack(){} // RVA: 0x7FFAC97B9C10
        public void Invalidate(){} // RVA: 0x7FFAC97B9D50
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7FFAC97B9E50
        public void CalculateItemsDuration(){} // RVA: 0x7FFAC97B9F00
        public void AddSubTracksRecursive(){} // RVA: 0x7FFAC97BA180
        public void CreateTrack(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void DeleteClip(){} // RVA: 0x7FFAC97BA980
        public void DeleteTrack(){} // RVA: 0x7FFAC97BAD60
        public void MoveLastTrackBefore(){} // RVA: 0x7FFAC97BB320
        public void AllocateTrack(){} // RVA: 0x7FFAC97BB6B0
        public void DeleteRecordedAnimation(){} // RVA: 0x7FFAC97BBE40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC97BC0E0
    }

    public class TimelineClip : Object
    {
        public int hasPreExtrapolation;
        public int hasPostExtrapolation; // 0x10
        public 0x6B2816E0 timeScale;
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
        public 0x6B280EF8 blendInDuration; // 0x78
        public 0x6B280EF8 blendOutDuration; // 0x7C
        public System.Collections.Generic.List`1<string> blendInCurveMode; // 0x80
        public UnityEngine.AnimationClip blendOutCurveMode; // 0x88
        public bool hasBlendIn; // 0x90
        public 0x6B280EA0 hasBlendOut; // 0x94
        public 0x6B280EA0 mixInCurve; // 0x98
        public double mixInPercentage; // 0xA0
        public double mixInDuration; // 0xA8
        public string mixOutCurve; // 0xB0

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAC97B4F80
        public void .ctor(){} // RVA: 0x7FFAC97B4FB0
        public void get_hasPreExtrapolation(){} // RVA: 0x7FFAC97B4FE0
        public void get_hasPostExtrapolation(){} // RVA: 0x7FFAC97B5000
        public void get_timeScale(){} // RVA: 0x7FFAC97B5020
        public void set_timeScale(){} // RVA: 0x7FFAC97B5130
        public void get_start(){} // RVA: 0x7FFAC4422FA0
        public void set_start(){} // RVA: 0x7FFAC97B5250
        public void get_duration(){} // RVA: 0x7FFAC967D770
        public void set_duration(){} // RVA: 0x7FFAC97B5460
        public void get_end(){} // RVA: 0x7FFAC97B5620
        public void get_clipIn(){} // RVA: 0x7FFAC97B5630
        public void set_clipIn(){} // RVA: 0x7FFAC97B5660
        public void get_displayName(){} // RVA: 0x7FFAC2F8C040
        public void set_displayName(){} // RVA: 0x7FFAC2F8C050
        public void get_clipAssetDuration(){} // RVA: 0x7FFAC97B5780
        public void get_curves(){} // RVA: 0x7FFAC2F60010
        public void set_curves(){} // RVA: 0x7FFAC354E300
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFAC97B57F0
        public void get_hasCurves(){} // RVA: 0x7FFAC97B5850
        public void get_asset(){} // RVA: 0x7FFAC2F4F130
        public void set_asset(){} // RVA: 0x7FFAC2F22E90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFAC2F9E740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFAC2F9E740
        public void get_underlyingAsset(){} // RVA: 0x7FFAC34F9180
        public void set_underlyingAsset(){} // RVA: 0x7FFAC2F21310
        public void get_parentTrack(){} // RVA: 0x7FFAC2F9E740
        public void set_parentTrack(){} // RVA: 0x7FFAC97B5990
        public void GetParentTrack(){} // RVA: 0x7FFAC2F9E740
        public void SetParentTrack_Internal(){} // RVA: 0x7FFAC97B59A0
        public void get_easeInDuration(){} // RVA: 0x7FFAC97B5C60
        public void set_easeInDuration(){} // RVA: 0x7FFAC97B5D60
        public void get_easeOutDuration(){} // RVA: 0x7FFAC97B5EB0
        public void set_easeOutDuration(){} // RVA: 0x7FFAC97B5FB0
        public void get_eastOutTime(){} // RVA: 0x7FFAC97B6100
        public void get_easeOutTime(){} // RVA: 0x7FFAC97B6100
        public void get_blendInDuration(){} // RVA: 0x7FFAC97B6140
        public void set_blendInDuration(){} // RVA: 0x7FFAC97B6170
        public void get_blendOutDuration(){} // RVA: 0x7FFAC97B6210
        public void set_blendOutDuration(){} // RVA: 0x7FFAC97B6240
        public void get_blendInCurveMode(){} // RVA: 0x7FFAC4596EF0
        public void set_blendInCurveMode(){} // RVA: 0x7FFAC45963A0
        public void get_blendOutCurveMode(){} // RVA: 0x7FFAC4598F70
        public void set_blendOutCurveMode(){} // RVA: 0x7FFAC89E0310
        public void get_hasBlendIn(){} // RVA: 0x7FFAC97B62E0
        public void get_hasBlendOut(){} // RVA: 0x7FFAC97B6320
        public void get_mixInCurve(){} // RVA: 0x7FFAC97B6360
        public void set_mixInCurve(){} // RVA: 0x7FFAC2F9CD60
        public void get_mixInPercentage(){} // RVA: 0x7FFAC97B6470
        public void get_mixInDuration(){} // RVA: 0x7FFAC97B6490
        public void get_mixOutCurve(){} // RVA: 0x7FFAC97B65C0
        public void set_mixOutCurve(){} // RVA: 0x7FFAC2FE95A0
        public void get_mixOutTime(){} // RVA: 0x7FFAC97B66D0
        public void get_mixOutDuration(){} // RVA: 0x7FFAC97B6750
        public void get_mixOutPercentage(){} // RVA: 0x7FFAC97B67C0
        public void get_recordable(){} // RVA: 0x7FFAC3E0D160
        public void set_recordable(){} // RVA: 0x7FFAC3E089B0
        public void get_exposedParameters(){} // RVA: 0x7FFAC97B6830
        public void get_clipCaps(){} // RVA: 0x7FFAC97B6900
        public void Hash(){} // RVA: 0x7FFAC97B69A0
        public void EvaluateMixOut(){} // RVA: 0x7FFAC97B6AD0
        public void EvaluateMixIn(){} // RVA: 0x7FFAC97B6C30
        public void GetDefaultMixInCurve(){} // RVA: 0x7FFAC97B6D20
        public void GetDefaultMixOutCurve(){} // RVA: 0x7FFAC97B6D50
        public void ToLocalTime(){} // RVA: 0x7FFAC97B6D80
        public void ToLocalTimeUnbound(){} // RVA: 0x7FFAC97B6F50
        public void FromLocalTimeUnbound(){} // RVA: 0x7FFAC97B6FC0
        public void get_animationClip(){} // RVA: 0x7FFAC97B7020
        public void SanitizeTimeValue(){} // RVA: 0x7FFAC97B71F0
        public void get_postExtrapolationMode(){} // RVA: 0x7FFAC97B7350
        public void set_postExtrapolationMode(){} // RVA: 0x7FFAC97B7380
        public void get_preExtrapolationMode(){} // RVA: 0x7FFAC97B73C0
        public void set_preExtrapolationMode(){} // RVA: 0x7FFAC97B73F0
        public void SetPostExtrapolationTime(){} // RVA: 0x7FFAC97B7430
        public void SetPreExtrapolationTime(){} // RVA: 0x7FFAC97B7440
        public void IsExtrapolatedTime(){} // RVA: 0x7FFAC97B7450
        public void IsPreExtrapolatedTime(){} // RVA: 0x7FFAC97B7500
        public void IsPostExtrapolatedTime(){} // RVA: 0x7FFAC97B7560
        public void get_extrapolatedStart(){} // RVA: 0x7FFAC97B75D0
        public void get_extrapolatedDuration(){} // RVA: 0x7FFAC97B75F0
        public void GetExtrapolatedTime(){} // RVA: 0x7FFAC97B76F0
        public void CreateCurves(){} // RVA: 0x7FFAC97B7830
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC45B41D0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC97B4F80
        public void ToString(){} // RVA: 0x7FFAC97B79C0
        public void ConformEaseValues(){} // RVA: 0x7FFAC97B7C10
        public void CalculateEasingRatio(){} // RVA: 0x7FFAC97B7D70
        public void UpdateDirty(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC97B7E60
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7FFAC97C8340
        public void SupportsExtrapolation(){} // RVA: 0x7FFAC97C8370
        public void SupportsClipIn(){} // RVA: 0x7FFAC97C83A0
        public void SupportsSpeedMultiplier(){} // RVA: 0x7FFAC97C83D0
        public void SupportsBlending(){} // RVA: 0x7FFAC97C8400
        public void HasAll(){} // RVA: 0x7FFAC4312F10
        public void HasAny(){} // RVA: 0x7FFAC9198D60
    }

    public class TimelineClipExtensions : Object
    {
        public string k_UndoSetParentTrackText;

        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7FFAC97DE920
        public void TryMoveToTrack(){} // RVA: 0x7FFAC97DEE50
        public void MoveToTrack_Impl(){} // RVA: 0x7FFAC97DF170
        public void .cctor(){} // RVA: 0x7FFAC97DF410
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7FFAC97DF4C0
        public void SaveAssetIntoObject(){} // RVA: 0x7FFAC97DF810
        public void RemoveAssetFromObject(){} // RVA: 0x7FFAC97DF9E0
        public void CreateAnimationClipForTrack(){} // RVA: 0x7FFAC97DFB40
        public void ValidateParentTrack(){} // RVA: 0x7FFAC97DFF20
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void Create(){} // RVA: 0x7FFAC97D8990
        public void Compile(){} // RVA: 0x7FFAC97D8DB0
        public void CompileTrackList(){} // RVA: 0x7FFAC97D9220
        public void CreateTrackOutput(){} // RVA: 0x7FFAC97D94E0
        public void CreateTrackPlayable(){} // RVA: 0x7FFAC97D9E90
        public void PrepareFrame(){} // RVA: 0x7FFAC97DA430
        public void Evaluate(){} // RVA: 0x7FFAC97DA480
        public void CacheTrack(){} // RVA: 0x7FFAC97DAC40
        public void ForAOTCompilationOnly(){} // RVA: 0x7FFAC97DACD0
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7FFAC97DAD30
        public void AddOutputWeightProcessor(){} // RVA: 0x7FFAC97DADD0
        public void AddEvaluateCallback(){} // RVA: 0x7FFAC97DB050
        public void InvokeOutputCallbacks(){} // RVA: 0x7FFAC97DB1E0
        public void TryGetCallbackList(){} // RVA: 0x7FFAC97DBD60
        public void .ctor(){} // RVA: 0x7FFAC97DBF50
        public void .cctor(){} // RVA: 0x7FFAC97DC5D0
    }

    public class TimelineUndo : Object
    {
        public object undoEnabled;

        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x7FFAC2F21320
        public void PushDestroyUndo(){} // RVA: 0x7FFAC97E0390
        public void PushUndo(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7FFAC2F21310
        public void UndoName(){} // RVA: 0x7FFAC97E0480
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
        public void OnBeforeTrackSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC97BCF70
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC97BD270
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAC2F21310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7FFAC97BD580
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7FFAC97BD6E0
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFAC97BD840
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFAC97BD9A0
        public void get_start(){} // RVA: 0x7FFAC97BDB00
        public void get_end(){} // RVA: 0x7FFAC97BDBA0
        public void get_duration(){} // RVA: 0x7FFAC97BDC40
        public void get_muted(){} // RVA: 0x7FFAC386C550
        public void set_muted(){} // RVA: 0x7FFAC43B4D70
        public void get_mutedInHierarchy(){} // RVA: 0x7FFAC97BDCF0
        public void get_timelineAsset(){} // RVA: 0x7FFAC97BDFA0
        public void get_parent(){} // RVA: 0x7FFAC2F9E740
        public void set_parent(){} // RVA: 0x7FFAC2F49200
        public void GetClips(){} // RVA: 0x7FFAC97BE280
        public void get_clips(){} // RVA: 0x7FFAC97BE290
        public void get_blendsValid(){} // RVA: 0x7FFAC82464C0
        public void set_blendsValid(){} // RVA: 0x7FFAC82464D0
        public void get_isEmpty(){} // RVA: 0x7FFAC97BE3F0
        public void get_hasClips(){} // RVA: 0x7FFAC97BE4A0
        public void get_hasCurves(){} // RVA: 0x7FFAC97BE4F0
        public void get_isSubTrack(){} // RVA: 0x7FFAC97BE620
        public void get_outputs(){} // RVA: 0x7FFAC97BE7A0
        public void GetChildTracks(){} // RVA: 0x7FFAC97BE850
        public void get_customPlayableTypename(){} // RVA: 0x7FFAC31D95E0
        public void set_customPlayableTypename(){} // RVA: 0x7FFAC2F4F890
        public void get_curves(){} // RVA: 0x7FFAC31D0140
        public void set_curves(){} // RVA: 0x7FFAC31D0C20
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFAC97BE870
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7FFAC44F81E0
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFAC97BE8B0
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFAC44F81E0
        public void get_subTracksObjects(){} // RVA: 0x7FFAC2F9C730
        public void get_locked(){} // RVA: 0x7FFAC30F6BA0
        public void set_locked(){} // RVA: 0x7FFAC3C24F40
        public void get_lockedInHierarchy(){} // RVA: 0x7FFAC97BE8C0
        public void get_supportsNotifications(){} // RVA: 0x7FFAC97BEB70
        public void __internalAwake(){} // RVA: 0x7FFAC97BEC00
        public void CreateCurves(){} // RVA: 0x7FFAC97BEDC0
        public void CreateTrackMixer(){} // RVA: 0x7FFAC97BEF20
        public void CreatePlayable(){} // RVA: 0x7FFAC97C4490 | overloaded x2
        public void CreateDefaultClip(){} // RVA: 0x7FFAC97BF0F0
        public void CreateClip(){} // RVA: 0x7FFAC97BF6A0 | overloaded x2
        public void DeleteClip(){} // RVA: 0x7FFAC97BF440
        public void CreateMarker(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void DeleteMarker(){} // RVA: 0x7FFAC97BF600
        public void GetMarkers(){} // RVA: 0x7FFAC97BF610
        public void GetMarkerCount(){} // RVA: 0x7FFAC97BF640
        public void GetMarker(){} // RVA: 0x7FFAC97BF690
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7FFAC97BF7E0
        public void CreateClipOfType(){} // RVA: 0x7FFAC97BF820
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7FFAC97BFB10
        public void CreateClipFromAsset(){} // RVA: 0x7FFAC97BFE40
        public void GetMarkersRaw(){} // RVA: 0x7FFAC2F60010
        public void ClearMarkers(){} // RVA: 0x7FFAC97C0100
        public void AddMarker(){} // RVA: 0x7FFAC97C0170
        public void DeleteMarkerRaw(){} // RVA: 0x7FFAC97C0180
        public void GetTimeRangeHash(){} // RVA: 0x7FFAC97C01C0
        public void AddClip(){} // RVA: 0x7FFAC97C0420
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFAC97C0560
        public void CreatePlayableGraph(){} // RVA: 0x7FFAC97C0A70
        public void CompileClips(){} // RVA: 0x7FFAC97C0E10
        public void GatherCompilableTracks(){} // RVA: 0x7FFAC97C1300
        public void GatherNotifications(){} // RVA: 0x7FFAC97C15E0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFAC97C18F0
        public void ConfigureTrackAnimation(){} // RVA: 0x7FFAC97C2250
        public void SortClips(){} // RVA: 0x7FFAC97C23B0
        public void ClearClipsInternal(){} // RVA: 0x7FFAC97C2630
        public void ClearSubTracksInternal(){} // RVA: 0x7FFAC97C2750
        public void OnClipMove(){} // RVA: 0x7FFAC97C2820
        public void CreateNewClipContainerInternal(){} // RVA: 0x7FFAC97C2880
        public void AddChild(){} // RVA: 0x7FFAC97C2CB0
        public void MoveLastTrackBefore(){} // RVA: 0x7FFAC97C2E00
        public void RemoveSubTrack(){} // RVA: 0x7FFAC97C3190
        public void RemoveClip(){} // RVA: 0x7FFAC97C3270
        public void GetEvaluationTime(){} // RVA: 0x7FFAC97C3340
        public void GetSequenceTime(){} // RVA: 0x7FFAC97C3590
        public void GatherProperties(){} // RVA: 0x7FFAC97C35B0
        public void GetGameObjectBinding(){} // RVA: 0x7FFAC97C3C70
        public void ValidateClipType(){} // RVA: 0x7FFAC97C3F60
        public void OnCreateClip(){} // RVA: 0x7FFAC2F21310
        public void UpdateDuration(){} // RVA: 0x7FFAC97C4270
        public void CalculateItemsHash(){} // RVA: 0x7FFAC97C43E0
        public void Invalidate(){} // RVA: 0x7FFAC97C4830
        public void GetNotificationDuration(){} // RVA: 0x7FFAC97C4960
        public void CanCompileClips(){} // RVA: 0x7FFAC97C4B60
        public void CanCreateTrackMixer(){} // RVA: 0x7FFAC8653E70
        public void IsCompilable(){} // RVA: 0x7FFAC97C4BC0
        public void UpdateChildTrackCache(){} // RVA: 0x7FFAC97C4EC0
        public void Hash(){} // RVA: 0x7FFAC97C5200
        public void GetClipsHash(){} // RVA: 0x7FFAC97C5280
        public void GetAnimationClipHash(){} // RVA: 0x7FFAC97C5520
        public void HasNotifications(){} // RVA: 0x7FFAC97C5710
        public void CanCompileNotifications(){} // RVA: 0x7FFAC97C5740
        public void CanCreateMixerRecursive(){} // RVA: 0x7FFAC97C5780
        public void .ctor(){} // RVA: 0x7FFAC97C5920
        public void .cctor(){} // RVA: 0x7FFAC97C5B00
    }

    public class TrackAssetExtensions : Object
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7FFAC97D20D0
        public void SetGroup(){} // RVA: 0x7FFAC97D2200
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFAC97D2990
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        public System.Type type; // 0x10
        public 0x6B282760 flags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
    }

    public class TrackClipTypeAttribute : Attribute
    {
        public System.Type inspectedType; // 0x10
        public bool allowAutoCreate; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class TrackColorAttribute : Attribute
    {
        public UnityEngine.Color color; // 0x10

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFAC4422E80
        public void .ctor(){} // RVA: 0x7FFAC97C66C0
    }

    public class TrackMediaType : Attribute
    {
        public 0x6B281058 m_MediaType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class WeightUtility : Object
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7FFAC97E3120
    }

}