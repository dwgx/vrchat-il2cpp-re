// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 793

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B7B050
        public void OnBehaviourPlay(){} // RVA: 0x7FFE87B7B2D0
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7B3F0
        public void ProcessFrame(){} // RVA: 0x7FFE87B7B500
        public void OnGraphStart(){} // RVA: 0x7FFE87B7B620
        public void OnPlayableDestroy(){} // RVA: 0x7FFE87B7B750
        public void .ctor(){} // RVA: 0x7FFE87908B50
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        public 0x6667A5AC m_PostPlaybackState; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B54720
        public void get_postPlaybackState(){} // RVA: 0x7FFE811485C0
        public void set_postPlaybackState(){} // RVA: 0x7FFE810FE0C0
        public void OnPlayableDestroy(){} // RVA: 0x7FFE87B547C0
        public void ProcessFrame(){} // RVA: 0x7FFE87B548F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFE813240E0
        public void CreatePlayable(){} // RVA: 0x7FFE87B54C50
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class ActivationTrack : TrackAsset
    {
        public 0x6667A5AC m_PostPlaybackState; // 0xA0

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFE87B54D70
        public void get_postPlaybackState(){} // RVA: 0x7FFE82B06FB0
        public void set_postPlaybackState(){} // RVA: 0x7FFE87B54E00
        public void CreateTrackMixer(){} // RVA: 0x7FFE87B54E20
        public void UpdateTrackMode(){} // RVA: 0x7FFE87B55060
        public void GatherProperties(){} // RVA: 0x7FFE87B55080
        public void OnCreateClip(){} // RVA: 0x7FFE87B551A0
        public void .ctor(){} // RVA: 0x7FFE87B55230
    }

    public class AnimationOutputWeightProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B55290
        public void FindMixers(){} // RVA: 0x7FFE87B55670 | overloaded x2
        public void Evaluate(){} // RVA: 0x7FFE87B55A80
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        public UnityEngine.AnimationClip m_Clip; // 0x18
        public UnityEngine.Vector3 m_Position; // 0x20
        public UnityEngine.Vector3 m_EulerAngles; // 0x2C
        public bool m_UseTrackMatchFields; // 0x38
        public 0x6667A91C m_MatchTargetFields; // 0x3C
        public bool m_RemoveStartOffset; // 0x40
        public bool m_ApplyFootIK; // 0x41
        public 0x6667A70C m_Loop; // 0x44
        public 0x6667A9CC _appliedOffsetMode; // 0x48
        public int k_LatestVersion;
        public int m_Version; // 0x4C
        public UnityEngine.Quaternion m_Rotation; // 0x50
        public object field_12; // 0x4
        public object field_13; // 0x5

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE81161EE0
        public void set_position(){} // RVA: 0x7FFE81161F00
        public void get_rotation(){} // RVA: 0x7FFE87B55CF0
        public void set_rotation(){} // RVA: 0x7FFE87B55DA0
        public void get_eulerAngles(){} // RVA: 0x7FFE81161F10
        public void set_eulerAngles(){} // RVA: 0x7FFE81161F30
        public void get_useTrackMatchFields(){} // RVA: 0x7FFE812CF770
        public void set_useTrackMatchFields(){} // RVA: 0x7FFE812D0010
        public void get_matchTargetFields(){} // RVA: 0x7FFE816311C0
        public void set_matchTargetFields(){} // RVA: 0x7FFE82A4B070
        public void get_removeStartOffset(){} // RVA: 0x7FFE811B6C00
        public void set_removeStartOffset(){} // RVA: 0x7FFE811B6C10
        public void get_applyFootIK(){} // RVA: 0x7FFE814645D0
        public void set_applyFootIK(){} // RVA: 0x7FFE814641E0
        public void get_loop(){} // RVA: 0x7FFE8119C0A0
        public void set_loop(){} // RVA: 0x7FFE8119C0B0
        public void get_hasRootTransforms(){} // RVA: 0x7FFE87B55DD0
        public void get_appliedOffsetMode(){} // RVA: 0x7FFE8119C0C0
        public void set_appliedOffsetMode(){} // RVA: 0x7FFE8119C0D0
        public void get_clip(){} // RVA: 0x7FFE810FE7C0
        public void set_clip(){} // RVA: 0x7FFE87B55EE0
        public void get_duration(){} // RVA: 0x7FFE87B56030
        public void get_outputs(){} // RVA: 0x7FFE87B560E0
        public void CreatePlayable(){} // RVA: 0x7FFE87B562C0 | overloaded x2
        public void ShouldApplyOffset(){} // RVA: 0x7FFE87B56BA0
        public void ShouldApplyScaleRemove(){} // RVA: 0x7FFE87B56C10
        public void get_clipCaps(){} // RVA: 0x7FFE87B56C30
        public void ResetOffsets(){} // RVA: 0x7FFE87B56E20
        public void GatherProperties(){} // RVA: 0x7FFE87B56EB0
        public void HasRootTransforms(){} // RVA: 0x7FFE87B56F80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE87B57110
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87B57170
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFE87B57200
        public void .ctor(){} // RVA: 0x7FFE87B57240
        public void .cctor(){} // RVA: 0x7FFE87B57360
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B57650
        public void Evaluate(){} // RVA: 0x7FFE87B57710
        public void FetchPreviewComponents(){} // RVA: 0x7FFE87B57980
    }

    public class AnimationTrack : TrackAsset
    {
        public string k_DefaultInfiniteClipName;
        public string k_DefaultRecordableClipName;
        public 0x6667AC8C m_InfiniteClipPreExtrapolation; // 0xA0
        public 0x6667AC8C m_InfiniteClipPostExtrapolation; // 0xA4
        public UnityEngine.Vector3 m_InfiniteClipOffsetPosition; // 0xA8
        public UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
        public double m_InfiniteClipTimeOffset; // 0xC0
        public bool m_InfiniteClipRemoveOffset; // 0xC8
        public bool m_InfiniteClipApplyFootIK; // 0xC9
        public 0x6667A70C mInfiniteClipLoop; // 0xCC
        public 0x6667A91C m_MatchTargetFields; // 0xD0
        public UnityEngine.Vector3 m_Position; // 0xD4
        public UnityEngine.Vector3 m_EulerAngles; // 0xE0
        public UnityEngine.AvatarMask m_AvatarMask; // 0xF0
        public bool m_ApplyAvatarMask; // 0xF8
        public 0x6667A974 m_TrackOffset; // 0xFC
        public UnityEngine.AnimationClip m_InfiniteClip; // 0x100
        public System.Collections.Generic.Queue`1<UnityEngine.Transform> s_CachedQueue;
        public UnityEngine.Quaternion m_OpenClipOffsetRotation; // 0x108
        public UnityEngine.Quaternion m_Rotation; // 0x118
        public bool m_ApplyOffsets; // 0x128
        public object field_21; // 0x14
        public object field_22; // 0x15
        public object field_23; // 0x16
        public object field_24; // 0x17

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE84A61A80
        public void set_position(){} // RVA: 0x7FFE84A61AA0
        public void get_rotation(){} // RVA: 0x7FFE87B57CD0
        public void set_rotation(){} // RVA: 0x7FFE87B57D80
        public void get_eulerAngles(){} // RVA: 0x7FFE87B57DB0
        public void set_eulerAngles(){} // RVA: 0x7FFE87B57DD0
        public void get_applyOffsets(){} // RVA: 0x7FFE810FB320
        public void set_applyOffsets(){} // RVA: 0x7FFE810FB310
        public void get_trackOffset(){} // RVA: 0x7FFE81F82930
        public void set_trackOffset(){} // RVA: 0x7FFE87B57DF0
        public void get_matchTargetFields(){} // RVA: 0x7FFE817E0030
        public void set_matchTargetFields(){} // RVA: 0x7FFE87B57E00
        public void get_infiniteClip(){} // RVA: 0x7FFE81828B50
        public void set_infiniteClip(){} // RVA: 0x7FFE81A58AB0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7FFE81FF3AD0
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7FFE81FE9F60
        public void get_avatarMask(){} // RVA: 0x7FFE811662A0
        public void set_avatarMask(){} // RVA: 0x7FFE811662B0
        public void get_applyAvatarMask(){} // RVA: 0x7FFE81F84060
        public void set_applyAvatarMask(){} // RVA: 0x7FFE87B57E70
        public void CanCompileClips(){} // RVA: 0x7FFE87B57E80
        public void get_outputs(){} // RVA: 0x7FFE87B57FC0
        public void get_inClipMode(){} // RVA: 0x7FFE87B58070
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7FFE87B580B0
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7FFE87B580D0
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7FFE87B580F0
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7FFE87B581A0
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFE87B581D0
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFE87B581F0
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFE81FF0890
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7FFE81FEC630
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7FFE87B58210
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7FFE87B58220
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7FFE82B06FB0
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7FFE82B06FC0
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7FFE848BEED0
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7FFE848BEEE0
        public void get_infiniteClipLoop(){} // RVA: 0x7FFE825F9DC0
        public void set_infiniteClipLoop(){} // RVA: 0x7FFE86C708B0
        public void ResetOffsets(){} // RVA: 0x7FFE87B58230
        public void CreateClip(){} // RVA: 0x7FFE87B582D0
        public void CreateInfiniteClip(){} // RVA: 0x7FFE87B583F0
        public void CreateRecordableClip(){} // RVA: 0x7FFE87B585D0
        public void OnCreateClip(){} // RVA: 0x7FFE87B588B0
        public void CalculateItemsHash(){} // RVA: 0x7FFE87B58920
        public void UpdateClipOffsets(){} // RVA: 0x7FFE810FB310
        public void CompileTrackPlayable(){} // RVA: 0x7FFE87B58A30
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7FFE87B59040
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFE87B590E0
        public void GetDefaultBlendCount(){} // RVA: 0x7FFE813240E0
        public void AttachDefaultBlend(){} // RVA: 0x7FFE810FB310
        public void AttachOffsetPlayable(){} // RVA: 0x7FFE87B59CA0
        public void RequiresMotionXPlayable(){} // RVA: 0x7FFE87B59E80
        public void UsesAbsoluteMotion(){} // RVA: 0x7FFE87B5A060
        public void HasController(){} // RVA: 0x7FFE87B5A070
        public void GetBinding(){} // RVA: 0x7FFE87B5A300
        public void CreateGroupMixer(){} // RVA: 0x7FFE87B5A6E0
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7FFE87B5A7D0
        public void ApplyTrackOffset(){} // RVA: 0x7FFE87B5AD30
        public void GetEvaluationTime(){} // RVA: 0x7FFE87B5AFC0
        public void GetSequenceTime(){} // RVA: 0x7FFE87B5B090
        public void AssignAnimationClip(){} // RVA: 0x7FFE87B5B1E0
        public void GatherProperties(){} // RVA: 0x7FFE810FB310
        public void GetAnimationClips(){} // RVA: 0x7FFE87B5B660
        public void GetOffsetMode(){} // RVA: 0x7FFE87B5BC60
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7FFE87B5BD90
        public void GetGenericRootNode(){} // RVA: 0x7FFE87B5C370
        public void AnimatesRootTransform(){} // RVA: 0x7FFE87B5C750
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7FFE87B5CA00
        public void get_openClipOffsetPosition(){} // RVA: 0x7FFE87B580B0
        public void set_openClipOffsetPosition(){} // RVA: 0x7FFE87B580D0
        public void get_openClipOffsetRotation(){} // RVA: 0x7FFE87B580F0
        public void set_openClipOffsetRotation(){} // RVA: 0x7FFE87B5CC40
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7FFE87B581D0
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7FFE87B581F0
        public void get_openClipPreExtrapolation(){} // RVA: 0x7FFE82B06FB0
        public void set_openClipPreExtrapolation(){} // RVA: 0x7FFE82B06FC0
        public void get_openClipPostExtrapolation(){} // RVA: 0x7FFE848BEED0
        public void set_openClipPostExtrapolation(){} // RVA: 0x7FFE848BEEE0
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFE87B5CC80
        public void .ctor(){} // RVA: 0x7FFE87B5CE70
        public void .cctor(){} // RVA: 0x7FFE87B5D0A0
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B6EC80
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7FFE87B6EC90
        public void .ctor(){} // RVA: 0x7FFE87B6EC80
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        public UnityEngine.AudioClip m_Clip; // 0x18
        public bool m_Loop; // 0x20
        public float m_bufferingTime; // 0x24
        public UnityEngine.Timeline.AudioClipProperties m_ClipProperties; // 0x28
        public object field_4; // 0x8B
        public object field_5; // 0x8C

        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x7FFE81268F50
        public void set_bufferingTime(){} // RVA: 0x7FFE81268F60
        public void get_clip(){} // RVA: 0x7FFE810FE7C0
        public void set_clip(){} // RVA: 0x7FFE81161E80
        public void get_loop(){} // RVA: 0x7FFE811E99D0
        public void set_loop(){} // RVA: 0x7FFE811E99E0
        public void get_duration(){} // RVA: 0x7FFE87B6F080
        public void get_outputs(){} // RVA: 0x7FFE87B6F280
        public void CreatePlayable(){} // RVA: 0x7FFE87B6F330
        public void get_clipCaps(){} // RVA: 0x7FFE87B6F5B0
        public void .ctor(){} // RVA: 0x7FFE87B6F5C0
    }

    public class AudioTrack : TrackAsset
    {
        public UnityEngine.Timeline.AudioMixerProperties m_TrackProperties; // 0xA0

        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7FFE87B6F8C0
        public void CompileClips(){} // RVA: 0x7FFE87B6FBC0
        public void get_outputs(){} // RVA: 0x7FFE87B70530
        public void OnValidate(){} // RVA: 0x7FFE87B705E0
        public void .ctor(){} // RVA: 0x7FFE87B70680
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        // ── Methods ──
        public void get_duration(){} // RVA: 0x7FFE87B7B890
        public void get_outputs(){} // RVA: 0x7FFE87B7B8F0
        public void OnGraphStart(){} // RVA: 0x7FFE810FB310
        public void OnGraphStop(){} // RVA: 0x7FFE810FB310
        public void OnPlayableCreate(){} // RVA: 0x7FFE810FB310
        public void OnPlayableDestroy(){} // RVA: 0x7FFE810FB310
        public void OnBehaviourPlay(){} // RVA: 0x7FFE810FB310
        public void OnBehaviourPause(){} // RVA: 0x7FFE810FB310
        public void PrepareFrame(){} // RVA: 0x7FFE810FB310
        public void ProcessFrame(){} // RVA: 0x7FFE810FB310
        public void CreatePlayable(){} // RVA: 0x7FFE87B7B950
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class BlendUtility : Object
    {
        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7FFE87B84F10
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFE87B85050
        public void UpdateClipIntersection(){} // RVA: 0x7FFE87B85470
        public void .cctor(){} // RVA: 0x7FFE87B85660
    }

    public class ControlPlayableAsset : PlayableAsset
    {
        public int k_MaxRandInt;
        public System.Collections.Generic.List`1<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;
        public System.Collections.Generic.List`1<UnityEngine.ParticleSystem> k_EmptyParticlesList; // 0x8
        public System.Collections.Generic.HashSet`1<UnityEngine.ParticleSystem> s_SubEmitterCollector; // 0x10

        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7FFE85BA8C00
        public void set_controllingDirectors(){} // RVA: 0x7FFE86B5F180
        public void get_controllingParticles(){} // RVA: 0x7FFE813A0820
        public void set_controllingParticles(){} // RVA: 0x7FFE813A0700
        public void OnEnable(){} // RVA: 0x7FFE87B709B0
        public void get_duration(){} // RVA: 0x7FFE84FAF530
        public void get_clipCaps(){} // RVA: 0x7FFE87B70A10
        public void CreatePlayable(){} // RVA: 0x7FFE87B70A20
        public void ConnectPlayablesToMixer(){} // RVA: 0x7FFE87B71860
        public void CreateActivationPlayable(){} // RVA: 0x7FFE87B71CB0
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7FFE87B71E70
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7FFE87B72250
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7FFE87B727A0
        public void ConnectMixerAndPlayable(){} // RVA: 0x7FFE87B72C90
        public void GetComponent(){} // RVA: 0x7FFE80E2E390
        public void GetControlableScripts(){} // RVA: 0x7FFE87B72DD0
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7FFE87B72E80
        public void GetControllableParticleSystems(){} // RVA: 0x7FFE87B73970 | overloaded x2
        public void CacheSubEmitters(){} // RVA: 0x7FFE87B73C70
        public void GatherProperties(){} // RVA: 0x7FFE87B73F00
        public void PreviewParticles(){} // RVA: 0x7FFE87B74310
        public void PreviewActivation(){} // RVA: 0x7FFE87B74760
        public void PreviewTimeControl(){} // RVA: 0x7FFE87B749E0
        public void PreviewDirectors(){} // RVA: 0x7FFE87B74C30
        public void .ctor(){} // RVA: 0x7FFE87B74FB0
        public void .cctor(){} // RVA: 0x7FFE87B75030
    }

    public class ControlTrack : TrackAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B75780
    }

    public class CurveEditUtility : Object
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7FFE87B757D0
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CustomStyleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B7BB10
        public void OnPlayableDestroy(){} // RVA: 0x7FFE87B7BD70
        public void PrepareFrame(){} // RVA: 0x7FFE87B7BF40
        public void OnBehaviourPlay(){} // RVA: 0x7FFE87B7C230
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7C3F0
        public void ProcessFrame(){} // RVA: 0x7FFE87B7C5D0
        public void SyncSpeed(){} // RVA: 0x7FFE87B7CB40
        public void SyncStart(){} // RVA: 0x7FFE87B7CF20
        public void SyncStop(){} // RVA: 0x7FFE87B7D0E0
        public void DetectDiscontinuity(){} // RVA: 0x7FFE87B7D2C0
        public void DetectOutOfSync(){} // RVA: 0x7FFE87B7D4F0
        public void UpdateTime(){} // RVA: 0x7FFE87B7D650
        public void .ctor(){} // RVA: 0x7FFE87B7D890
    }

    public class DiscreteTime : ValueType
    {
        public double k_Tick;

        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7FFE87B759A0
        public void .ctor(){} // RVA: 0x7FFE87B75B10 | overloaded x6
        public void OneTickBefore(){} // RVA: 0x7FFE87B75B90
        public void OneTickAfter(){} // RVA: 0x7FFE87B75BA0
        public void GetTick(){} // RVA: 0x7FFE8284EF60
        public void FromTicks(){} // RVA: 0x7FFE827C4A80
        public void CompareTo(){} // RVA: 0x7FFE87B75BB0
        public void Equals(){} // RVA: 0x7FFE87B75C60 | overloaded x2
        public void DoubleToDiscreteTime(){} // RVA: 0x7FFE87B75D00
        public void FloatToDiscreteTime(){} // RVA: 0x7FFE87B75D90
        public void IntToDiscreteTime(){} // RVA: 0x7FFE87B75E20
        public void ToDouble(){} // RVA: 0x7FFE87B75E80
        public void ToFloat(){} // RVA: 0x7FFE87B75EA0
        public void op_Explicit(){} // RVA: 0x7FFE827C4A80 | overloaded x6
        public void op_Implicit(){} // RVA: 0x7FFE87B760B0
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE87B76140
        public void op_GreaterThan(){} // RVA: 0x7FFE869FA370
        public void op_LessThan(){} // RVA: 0x7FFE869FA350
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE869FA360
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE869FA380
        public void op_Addition(){} // RVA: 0x7FFE835C1B90
        public void op_Subtraction(){} // RVA: 0x7FFE87B761A0
        public void ToString(){} // RVA: 0x7FFE87B761B0
        public void GetHashCode(){} // RVA: 0x7FFE87B76250
        public void Min(){} // RVA: 0x7FFE87B76260
        public void Max(){} // RVA: 0x7FFE87B762C0
        public void SnapToNearestTick(){} // RVA: 0x7FFE87B76390 | overloaded x2
        public void GetNearestTick(){} // RVA: 0x7FFE87B76440
        public void .cctor(){} // RVA: 0x7FFE87B764A0
    }

    public class Extrapolation : Object
    {
        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7FFE87B85900
        public void SortClipsByStartTime(){} // RVA: 0x7FFE87B85DD0
        public void .cctor(){} // RVA: 0x7FFE87B860E0
    }

    public class FrameRateFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GroupTrack : TrackAsset
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFE810FB320
        public void get_outputs(){} // RVA: 0x7FFE87B7AFA0
        public void .ctor(){} // RVA: 0x7FFE87B7B000
    }

    public class HashUtility : Object
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7FFE87B86460 | overloaded x7
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ICurvesOwner
    {
        // ── Methods ──
        public void get_curves(){} // RVA: 0x7FFE80E2E2E0
        public void get_hasCurves(){} // RVA: 0x7FFE80E2F150
        public void get_duration(){} // RVA: 0x7FFE80E33FB0
        public void CreateCurves(){} // RVA: 0x7FFE80E460A0
        public void get_defaultCurvesName(){} // RVA: 0x7FFE80E2E2E0
        public void get_asset(){} // RVA: 0x7FFE80E2E2E0
        public void get_assetOwner(){} // RVA: 0x7FFE80E2E2E0
        public void get_targetTrack(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IInterval
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFE80E2E2E0
        public void get_intervalEnd(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){}
    }

    public class IMarker
    {
        // ── Methods ──
        public void get_time(){} // RVA: 0x7FFE80E33FB0
        public void set_time(){} // RVA: 0x7FFE80E476E0
        public void get_parent(){} // RVA: 0x7FFE80E2E2E0
        public void Initialize(){} // RVA: 0x7FFE80E460A0
    }

    public class INotificationOptionProvider
    {
        // ── Methods ──
        public void get_flags(){} // RVA: 0x7FFE80E2E210
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7FFE80E460A0
        public void PopActiveGameObject(){} // RVA: 0x7FFE80E45FE0
        public void AddFromClip(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void AddFromClips(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void AddFromName(){} // RVA: 0x7FFE80E4F230 | overloaded x5
        public void AddFromComponent(){} // RVA: 0x7FFE80E4F230
        public void AddObjectProperties(){} // RVA: 0x7FFE80E4F230
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x7FFE80E4F230
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x7FFE80E476E0
        public void OnControlTimeStart(){} // RVA: 0x7FFE80E45FE0
        public void OnControlTimeStop(){} // RVA: 0x7FFE80E45FE0
    }

    public class ITimelineClipAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFE80E45FE0
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        public UnityEngine.Playables.Playable m_Playable; // 0x18
        public long kIntervalEnd;
        public object field_2; // 0x9D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE817036E0
        public void get_intervalStart(){} // RVA: 0x7FFE813240E0
        public void get_intervalEnd(){} // RVA: 0x7FFE87B764F0
        public void set_enable(){} // RVA: 0x7FFE87B76550
        public void EvaluateAt(){} // RVA: 0x7FFE87B765D0
        public void DisableAt(){} // RVA: 0x7FFE87B76630
        public void .cctor(){} // RVA: 0x7FFE87B766A0
    }

    public class IntervalTreeNode : ValueType
    {
    }

    public class IntervalTree`1 : Object
    {
        public int kMinNodeSize;

        // ── Methods ──
        public void get_dirty(){} // RVA: 0x7FFE80E2F150
        public void set_dirty(){} // RVA: 0x7FFE80E466C0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x7FFE810A1420
        public void UpdateIntervals(){} // RVA: 0x7FFE80E45FE0
        public void Query(){} // RVA: 0x7FFE810A1420
        public void QueryRange(){} // RVA: 0x7FFE810A1420
        public void Rebuild(){} // RVA: 0x7FFE80E356E0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Marker : ScriptableObject
    {
        public double m_Time; // 0x18
        public UnityEngine.Timeline.TrackAsset _parent; // 0x20

        // ── Methods ──
        public void get_parent(){} // RVA: 0x7FFE811290C0
        public void set_parent(){} // RVA: 0x7FFE811290D0
        public void get_time(){} // RVA: 0x7FFE826F6CB0
        public void set_time(){} // RVA: 0x7FFE87B778B0
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7FFE87B77950
        public void OnInitialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class MarkerList : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> m_Objects; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> m_Cache; // 0x18
        public bool m_CacheDirty; // 0x20

        // ── Methods ──
        public void get_markers(){} // RVA: 0x7FFE87B77AF0
        public void .ctor(){} // RVA: 0x7FFE87B77B10
        public void Add(){} // RVA: 0x7FFE87B77C90
        public void Remove(){} // RVA: 0x7FFE87B77F10 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE87B77FD0
        public void Contains(){} // RVA: 0x7FFE87B78040
        public void GetMarkers(){} // RVA: 0x7FFE87B77AF0
        public void get_Count(){} // RVA: 0x7FFE87B780A0
        public void get_Item(){} // RVA: 0x7FFE87B780F0
        public void GetRawMarkerList(){} // RVA: 0x7FFE8284EF60
        public void CreateMarker(){} // RVA: 0x7FFE87B78170
        public void HasNotifications(){} // RVA: 0x7FFE87B784A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE814B8390
        public void BuildCache(){} // RVA: 0x7FFE87B784C0
    }

    public class MarkerTrack : TrackAsset
    {
        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7FFE87B78820
        public void .ctor(){} // RVA: 0x7FFE87B78AF0
    }

    public class MatchTargetFieldConstants : Object
    {
        // ── Methods ──
        public void HasAny(){} // RVA: 0x7FFE87B57BD0
        public void Toggle(){} // RVA: 0x7FFE87B57C40
        public void .cctor(){} // RVA: 0x7FFE87B57C50
    }

    public class MenuCategoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B80E60
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NotificationUtilities : Object
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFE87B86560 | overloaded x3
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7FFE87B86CA0
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        public float kUnsetTime;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B7D8A0
        public void get_particleSystem(){} // RVA: 0x7FFE811290C0
        public void set_particleSystem(){} // RVA: 0x7FFE811290D0
        public void Initialize(){} // RVA: 0x7FFE87B7DB70
        public void SetRandomSeed(){} // RVA: 0x7FFE87B7DC30
        public void PrepareFrame(){} // RVA: 0x7FFE87B7DF40
        public void OnBehaviourPlay(){} // RVA: 0x7FFE87B7E1F0
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7E1F0
        public void Simulate(){} // RVA: 0x7FFE87B7E200
        public void .ctor(){} // RVA: 0x7FFE87B7E3D0
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7FFE87B80C30
        public void .ctor(){} // RVA: 0x7FFE87B80DA0
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        public UnityEngine.GameObject m_Instance; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B7E3F0
        public void get_prefabInstance(){} // RVA: 0x7FFE81116380
        public void Initialize(){} // RVA: 0x7FFE87B7E620
        public void OnPlayableDestroy(){} // RVA: 0x7FFE87B7EA10
        public void OnBehaviourPlay(){} // RVA: 0x7FFE87B7EB90
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7ECB0
        public void SetHideFlagsRecursive(){} // RVA: 0x7FFE87B7EDC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeClip : RuntimeClipBase
    {
        public UnityEngine.Timeline.TimelineClip m_Clip; // 0x18
        public UnityEngine.Playables.Playable m_Playable; // 0x20
        public UnityEngine.Playables.Playable m_ParentMixer; // 0x30
        public object field_3; // 0xA3
        public object field_4; // 0xA4
        public object field_5; // 0xA5

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFE87B76790
        public void get_duration(){} // RVA: 0x7FFE87B767C0
        public void .ctor(){} // RVA: 0x7FFE87B767E0
        public void Create(){} // RVA: 0x7FFE87B767E0
        public void get_clip(){} // RVA: 0x7FFE810FE7C0
        public void get_mixer(){} // RVA: 0x7FFE86809840
        public void get_playable(){} // RVA: 0x7FFE82C84C90
        public void set_enable(){} // RVA: 0x7FFE87B768B0
        public void SetTime(){} // RVA: 0x7FFE87B76A10
        public void SetDuration(){} // RVA: 0x7FFE87B76A70
        public void EvaluateAt(){} // RVA: 0x7FFE87B76AD0
        public void DisableAt(){} // RVA: 0x7FFE87B76E20
    }

    public class RuntimeClipBase : RuntimeElement
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFE80E33FB0
        public void get_duration(){} // RVA: 0x7FFE80E33FB0
        public void get_intervalStart(){} // RVA: 0x7FFE87B77030
        public void get_intervalEnd(){} // RVA: 0x7FFE87B770E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeElement : Object
    {
        public int _intervalBit; // 0x10
        public object field_1; // 0xAD
        public object field_2; // 0xAE
        public object field_3; // 0xAF

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFE80E2E2E0
        public void get_intervalEnd(){} // RVA: 0x7FFE80E2E2E0
        public void get_intervalBit(){} // RVA: 0x7FFE811485C0
        public void set_intervalBit(){} // RVA: 0x7FFE810FE0C0
        public void set_enable(){} // RVA: 0x7FFE80E466C0
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        public UnityEngine.Timeline.TimelineClip m_Clip; // 0x18
        public UnityEngine.Playables.Playable m_Playable; // 0x20
        public UnityEngine.Playables.Playable m_ParentMixer; // 0x30
        public double m_StartDelay; // 0x40
        public double m_FinishTail; // 0x48
        public bool m_Started; // 0x50

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFE87B771B0
        public void get_duration(){} // RVA: 0x7FFE87B77260
        public void SetTime(){} // RVA: 0x7FFE87B772B0
        public void get_clip(){} // RVA: 0x7FFE810FE7C0
        public void get_mixer(){} // RVA: 0x7FFE86809840
        public void get_playable(){} // RVA: 0x7FFE82C84C90
        public void .ctor(){} // RVA: 0x7FFE87B77310
        public void Create(){} // RVA: 0x7FFE87B77310
        public void set_enable(){} // RVA: 0x7FFE87B773F0
        public void EvaluateAt(){} // RVA: 0x7FFE87B77510
        public void DisableAt(){} // RVA: 0x7FFE87B77890
    }

    public class SignalAsset : ScriptableObject
    {
        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7FFE87B78B40
        public void remove_OnEnableCallback(){} // RVA: 0x7FFE87B78C70
        public void OnEnable(){} // RVA: 0x7FFE87B78DA0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SignalEmitter : Marker
    {
        public bool m_Retroactive; // 0x28
        public bool m_EmitOnce; // 0x29
        public UnityEngine.Timeline.SignalAsset m_Asset; // 0x30
        public object field_3; // 0xC0
        public object field_4; // 0xC1

        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x7FFE815F1380
        public void set_retroactive(){} // RVA: 0x7FFE81C15740
        public void get_emitOnce(){} // RVA: 0x7FFE819C2EA0
        public void set_emitOnce(){} // RVA: 0x7FFE8268C820
        public void get_asset(){} // RVA: 0x7FFE8144E200
        public void set_asset(){} // RVA: 0x7FFE81129890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7FFE87B78E00
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7FFE87B78FA0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SignalReceiver : MonoBehaviour
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFE87B78FD0
        public void AddReaction(){} // RVA: 0x7FFE87B791D0
        public void AddEmptyReaction(){} // RVA: 0x7FFE87B79390
        public void Remove(){} // RVA: 0x7FFE87B79400
        public void GetRegisteredSignals(){} // RVA: 0x7FFE81D28EA0
        public void GetReaction(){} // RVA: 0x7FFE87B79580
        public void Count(){} // RVA: 0x7FFE87B795C0
        public void ChangeSignalAtIndex(){} // RVA: 0x7FFE87B79610
        public void RemoveAtIndex(){} // RVA: 0x7FFE87B79AD0
        public void ChangeReactionAtIndex(){} // RVA: 0x7FFE87B79BE0
        public void GetReactionAtIndex(){} // RVA: 0x7FFE87B79CD0
        public void GetSignalAssetAtIndex(){} // RVA: 0x7FFE87B79DB0
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE87B79E90
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B78AF0
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B7F200
        public void Initialize(){} // RVA: 0x7FFE810FCE30
        public void PrepareFrame(){} // RVA: 0x7FFE87B7F3C0
        public void OnBehaviourPlay(){} // RVA: 0x7FFE87B7F440
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7F4A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TimeFieldAttribute : PropertyAttribute
    {
        public 0x6667C6AC _useEditMode; // 0x10

        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public System.Collections.Generic.List`1<NotificationEntry> m_Notifications; // 0x10

        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x7FFE81E8E800
        public void Create(){} // RVA: 0x7FFE87B7F500
        public void AddNotification(){} // RVA: 0x7FFE87B7F700
        public void OnGraphStart(){} // RVA: 0x7FFE87B7F800
        public void OnBehaviourPause(){} // RVA: 0x7FFE87B7FA20
        public void PrepareFrame(){} // RVA: 0x7FFE87B7FCF0
        public void SortNotifications(){} // RVA: 0x7FFE87B800E0
        public void CanRestoreNotification(){} // RVA: 0x7FFE87B80300
        public void TriggerNotificationsInRange(){} // RVA: 0x7FFE87B80340
        public void SyncDurationWithExternalSource(){} // RVA: 0x7FFE87B805F0
        public void Trigger_internal(){} // RVA: 0x7FFE87B808B0
        public void Restore_internal(){} // RVA: 0x7FFE81FCAC70
        public void .ctor(){} // RVA: 0x7FFE87B80A50
    }

    public class TimeUtility : Object
    {
        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7FFE87B88A50
        public void ToFrames(){} // RVA: 0x7FFE87B88B10
        public void ToExactFrames(){} // RVA: 0x7FFE87B88C80
        public void FromFrames(){} // RVA: 0x7FFE87B88D60 | overloaded x2
        public void OnFrameBoundary(){} // RVA: 0x7FFE87B89270 | overloaded x2
        public void GetEpsilon(){} // RVA: 0x7FFE87B88EE0
        public void PreviousFrame(){} // RVA: 0x7FFE87B88FD0
        public void NextFrame(){} // RVA: 0x7FFE87B89070
        public void PreviousFrameTime(){} // RVA: 0x7FFE87B890E0
        public void NextFrameTime(){} // RVA: 0x7FFE87B891C0
        public void RoundToFrame(){} // RVA: 0x7FFE87B89340
        public void TimeAsFrames(){} // RVA: 0x7FFE87B89440
        public void TimeAsTimeCode(){} // RVA: 0x7FFE87B895D0
        public void ParseTimeCode(){} // RVA: 0x7FFE87B89CD0
        public void ParseTimeSeconds(){} // RVA: 0x7FFE87B8A3B0
        public void GetAnimationClipLength(){} // RVA: 0x7FFE87B8A8E0
        public void RemoveChar(){} // RVA: 0x7FFE87B8AAE0
        public void GetClosestFrameRate(){} // RVA: 0x7FFE87B8ABB0
        public void ToFrameRate(){} // RVA: 0x7FFE87B8AE40
        public void ToStandardFrameRate(){} // RVA: 0x7FFE87B8B030
        public void .cctor(){} // RVA: 0x7FFE87B8B4A0
    }

    public class TimelineAsset : PlayableAsset
    {
        public int k_LatestVersion;
        public int m_Version; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> m_Tracks; // 0x20
        public double m_FixedDuration; // 0x28
        public UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks; // 0x38
        public UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks; // 0x40
        public EditorSettings m_EditorSettings; // 0x48
        public 0x6667AE9C m_DurationMode; // 0x50
        public UnityEngine.Timeline.MarkerTrack m_MarkerTrack; // 0x58
        public object field_10; // 0x60

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFE810FB310
        public void get_editorSettings(){} // RVA: 0x7FFE81176730
        public void get_duration(){} // RVA: 0x7FFE87B60560
        public void get_fixedDuration(){} // RVA: 0x7FFE87B60600
        public void set_fixedDuration(){} // RVA: 0x7FFE87B60720
        public void get_durationMode(){} // RVA: 0x7FFE8139DAD0
        public void set_durationMode(){} // RVA: 0x7FFE81463B00
        public void get_outputs(){} // RVA: 0x7FFE87B607C0
        public void get_clipCaps(){} // RVA: 0x7FFE87B60870
        public void get_outputTrackCount(){} // RVA: 0x7FFE87B60A30
        public void get_rootTrackCount(){} // RVA: 0x7FFE87B60A60
        public void OnValidate(){} // RVA: 0x7FFE87B60AB0
        public void GetRootTrack(){} // RVA: 0x7FFE87B60AF0
        public void GetRootTracks(){} // RVA: 0x7FFE87B60B70
        public void GetOutputTrack(){} // RVA: 0x7FFE87B60B90
        public void GetOutputTracks(){} // RVA: 0x7FFE87B60BE0
        public void GetValidFrameRate(){} // RVA: 0x7FFE87B60C00
        public void UpdateRootTrackCache(){} // RVA: 0x7FFE87B60CF0
        public void UpdateOutputTrackCache(){} // RVA: 0x7FFE87B61170
        public void get_flattenedTracks(){} // RVA: 0x7FFE87B61410
        public void get_markerTrack(){} // RVA: 0x7FFE811C3500
        public void get_trackObjects(){} // RVA: 0x7FFE811290C0
        public void AddTrackInternal(){} // RVA: 0x7FFE87B61620
        public void RemoveTrack(){} // RVA: 0x7FFE87B616D0
        public void CreatePlayable(){} // RVA: 0x7FFE87B61850
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE817E01F0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87B61B20
        public void __internalAwake(){} // RVA: 0x7FFE87B61B30
        public void GatherProperties(){} // RVA: 0x7FFE87B61D90
        public void CreateMarkerTrack(){} // RVA: 0x7FFE87B61FA0
        public void RemoveMarkerTrack(){} // RVA: 0x7FFE87B62190
        public void Invalidate(){} // RVA: 0x7FFE87B622D0
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7FFE87B623D0
        public void CalculateItemsDuration(){} // RVA: 0x7FFE87B62480
        public void AddSubTracksRecursive(){} // RVA: 0x7FFE87B62700
        public void CreateTrack(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void DeleteClip(){} // RVA: 0x7FFE87B62F00
        public void DeleteTrack(){} // RVA: 0x7FFE87B632E0
        public void MoveLastTrackBefore(){} // RVA: 0x7FFE87B638A0
        public void AllocateTrack(){} // RVA: 0x7FFE87B63C30
        public void DeleteRecordedAnimation(){} // RVA: 0x7FFE87B643C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87B64660
    }

    public class TimelineClip : Object
    {
        public int k_LatestVersion;
        public int m_Version; // 0x10
        public 0x6667B4CC kDefaultClipCaps;
        public float kDefaultClipDurationInSeconds; // 0x4
        public double kTimeScaleMin; // 0x8
        public double kTimeScaleMax; // 0x10
        public string kDefaultCurvesName; // 0x18
        public double kMinDuration; // 0x20
        public double kMaxTimeValue; // 0x28
        public double m_Start; // 0x18
        public double m_ClipIn; // 0x20
        public UnityEngine.Object m_Asset; // 0x28
        public double m_Duration; // 0x30
        public double m_TimeScale; // 0x38
        public UnityEngine.Timeline.TrackAsset m_ParentTrack; // 0x40
        public double m_EaseInDuration; // 0x48
        public double m_EaseOutDuration; // 0x50
        public double m_BlendInDuration; // 0x58
        public double m_BlendOutDuration; // 0x60
        public UnityEngine.AnimationCurve m_MixInCurve; // 0x68
        public UnityEngine.AnimationCurve m_MixOutCurve; // 0x70
        public 0x6667ACE4 m_BlendInCurveMode; // 0x78
        public 0x6667ACE4 m_BlendOutCurveMode; // 0x7C
        public System.Collections.Generic.List`1<string> m_ExposedParameterNames; // 0x80
        public UnityEngine.AnimationClip m_AnimationCurves; // 0x88
        public bool m_Recordable; // 0x90
        public 0x6667AC8C m_PostExtrapolationMode; // 0x94
        public 0x6667AC8C m_PreExtrapolationMode; // 0x98
        public double m_PostExtrapolationTime; // 0xA0
        public double m_PreExtrapolationTime; // 0xA8
        public string m_DisplayName; // 0xB0
        public object field_31; // 0x36
        public object field_32; // 0x37
        public object field_33; // 0x38
        public object field_34; // 0x39
        public object field_35; // 0x3A
        public object field_36; // 0x3B
        public object field_37; // 0x3C
        public object field_38; // 0x3D
        public object field_39; // 0x3E
        public object field_40; // 0x3F
        public object field_41; // 0x40

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFE87B5D500
        public void .ctor(){} // RVA: 0x7FFE87B5D530
        public void get_hasPreExtrapolation(){} // RVA: 0x7FFE87B5D560
        public void get_hasPostExtrapolation(){} // RVA: 0x7FFE87B5D580
        public void get_timeScale(){} // RVA: 0x7FFE87B5D5A0
        public void set_timeScale(){} // RVA: 0x7FFE87B5D6B0
        public void get_start(){} // RVA: 0x7FFE826F6CB0
        public void set_start(){} // RVA: 0x7FFE87B5D7D0
        public void get_duration(){} // RVA: 0x7FFE87A25ED0
        public void set_duration(){} // RVA: 0x7FFE87B5D9E0
        public void get_end(){} // RVA: 0x7FFE87B5DBA0
        public void get_clipIn(){} // RVA: 0x7FFE87B5DBB0
        public void set_clipIn(){} // RVA: 0x7FFE87B5DBE0
        public void get_displayName(){} // RVA: 0x7FFE81166040
        public void set_displayName(){} // RVA: 0x7FFE81166050
        public void get_clipAssetDuration(){} // RVA: 0x7FFE87B5DD00
        public void get_curves(){} // RVA: 0x7FFE8113A010
        public void set_curves(){} // RVA: 0x7FFE81280F90
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFE87B5DD70
        public void get_hasCurves(){} // RVA: 0x7FFE87B5DDD0
        public void get_asset(){} // RVA: 0x7FFE81129130
        public void set_asset(){} // RVA: 0x7FFE810FCE90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFE81178740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFE81178740
        public void get_underlyingAsset(){} // RVA: 0x7FFE813240E0
        public void set_underlyingAsset(){} // RVA: 0x7FFE810FB310
        public void get_parentTrack(){} // RVA: 0x7FFE81178740
        public void set_parentTrack(){} // RVA: 0x7FFE87B5DF10
        public void GetParentTrack(){} // RVA: 0x7FFE81178740
        public void SetParentTrack_Internal(){} // RVA: 0x7FFE87B5DF20
        public void get_easeInDuration(){} // RVA: 0x7FFE87B5E1E0
        public void set_easeInDuration(){} // RVA: 0x7FFE87B5E2E0
        public void get_easeOutDuration(){} // RVA: 0x7FFE87B5E430
        public void set_easeOutDuration(){} // RVA: 0x7FFE87B5E530
        public void get_eastOutTime(){} // RVA: 0x7FFE87B5E680
        public void get_easeOutTime(){} // RVA: 0x7FFE87B5E680
        public void get_blendInDuration(){} // RVA: 0x7FFE87B5E6C0
        public void set_blendInDuration(){} // RVA: 0x7FFE87B5E6F0
        public void get_blendOutDuration(){} // RVA: 0x7FFE87B5E790
        public void set_blendOutDuration(){} // RVA: 0x7FFE87B5E7C0
        public void get_blendInCurveMode(){} // RVA: 0x7FFE8286C0A0
        public void set_blendInCurveMode(){} // RVA: 0x7FFE82862F10
        public void get_blendOutCurveMode(){} // RVA: 0x7FFE8286B570
        public void set_blendOutCurveMode(){} // RVA: 0x7FFE86D89990
        public void get_hasBlendIn(){} // RVA: 0x7FFE87B5E860
        public void get_hasBlendOut(){} // RVA: 0x7FFE87B5E8A0
        public void get_mixInCurve(){} // RVA: 0x7FFE87B5E8E0
        public void set_mixInCurve(){} // RVA: 0x7FFE81176D60
        public void get_mixInPercentage(){} // RVA: 0x7FFE87B5E9F0
        public void get_mixInDuration(){} // RVA: 0x7FFE87B5EA10
        public void get_mixOutCurve(){} // RVA: 0x7FFE87B5EB40
        public void set_mixOutCurve(){} // RVA: 0x7FFE811C35A0
        public void get_mixOutTime(){} // RVA: 0x7FFE87B5EC50
        public void get_mixOutDuration(){} // RVA: 0x7FFE87B5ECD0
        public void get_mixOutPercentage(){} // RVA: 0x7FFE87B5ED40
        public void get_recordable(){} // RVA: 0x7FFE820BF400
        public void set_recordable(){} // RVA: 0x7FFE820BFEB0
        public void get_exposedParameters(){} // RVA: 0x7FFE87B5EDB0
        public void get_clipCaps(){} // RVA: 0x7FFE87B5EE80
        public void Hash(){} // RVA: 0x7FFE87B5EF20
        public void EvaluateMixOut(){} // RVA: 0x7FFE87B5F050
        public void EvaluateMixIn(){} // RVA: 0x7FFE87B5F1B0
        public void GetDefaultMixInCurve(){} // RVA: 0x7FFE87B5F2A0
        public void GetDefaultMixOutCurve(){} // RVA: 0x7FFE87B5F2D0
        public void ToLocalTime(){} // RVA: 0x7FFE87B5F300
        public void ToLocalTimeUnbound(){} // RVA: 0x7FFE87B5F4D0
        public void FromLocalTimeUnbound(){} // RVA: 0x7FFE87B5F540
        public void get_animationClip(){} // RVA: 0x7FFE87B5F5A0
        public void SanitizeTimeValue(){} // RVA: 0x7FFE87B5F770
        public void get_postExtrapolationMode(){} // RVA: 0x7FFE87B5F8D0
        public void set_postExtrapolationMode(){} // RVA: 0x7FFE87B5F900
        public void get_preExtrapolationMode(){} // RVA: 0x7FFE87B5F940
        public void set_preExtrapolationMode(){} // RVA: 0x7FFE87B5F970
        public void SetPostExtrapolationTime(){} // RVA: 0x7FFE87B5F9B0
        public void SetPreExtrapolationTime(){} // RVA: 0x7FFE87B5F9C0
        public void IsExtrapolatedTime(){} // RVA: 0x7FFE87B5F9D0
        public void IsPreExtrapolatedTime(){} // RVA: 0x7FFE87B5FA80
        public void IsPostExtrapolatedTime(){} // RVA: 0x7FFE87B5FAE0
        public void get_extrapolatedStart(){} // RVA: 0x7FFE87B5FB50
        public void get_extrapolatedDuration(){} // RVA: 0x7FFE87B5FB70
        public void GetExtrapolatedTime(){} // RVA: 0x7FFE87B5FC70
        public void CreateCurves(){} // RVA: 0x7FFE87B5FDB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE82880410
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87B5D500
        public void ToString(){} // RVA: 0x7FFE87B5FF40
        public void ConformEaseValues(){} // RVA: 0x7FFE87B60190
        public void CalculateEasingRatio(){} // RVA: 0x7FFE87B602F0
        public void UpdateDirty(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87B603E0
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7FFE87B708C0
        public void SupportsExtrapolation(){} // RVA: 0x7FFE87B708F0
        public void SupportsClipIn(){} // RVA: 0x7FFE87B70920
        public void SupportsSpeedMultiplier(){} // RVA: 0x7FFE87B70950
        public void SupportsBlending(){} // RVA: 0x7FFE87B70980
        public void HasAll(){} // RVA: 0x7FFE826077A0
        public void HasAny(){} // RVA: 0x7FFE87541510
    }

    public class TimelineClipExtensions : Object
    {
        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7FFE87B86EA0
        public void TryMoveToTrack(){} // RVA: 0x7FFE87B873D0
        public void MoveToTrack_Impl(){} // RVA: 0x7FFE87B876F0
        public void .cctor(){} // RVA: 0x7FFE87B87990
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7FFE87B87A40
        public void SaveAssetIntoObject(){} // RVA: 0x7FFE87B87D90
        public void RemoveAssetFromObject(){} // RVA: 0x7FFE87B87F60
        public void CreateAnimationClipForTrack(){} // RVA: 0x7FFE87B880C0
        public void ValidateParentTrack(){} // RVA: 0x7FFE87B884A0
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TimelinePlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87B80F10
        public void Compile(){} // RVA: 0x7FFE87B81330
        public void CompileTrackList(){} // RVA: 0x7FFE87B817A0
        public void CreateTrackOutput(){} // RVA: 0x7FFE87B81A60
        public void CreateTrackPlayable(){} // RVA: 0x7FFE87B82410
        public void PrepareFrame(){} // RVA: 0x7FFE87B829B0
        public void Evaluate(){} // RVA: 0x7FFE87B82A00
        public void CacheTrack(){} // RVA: 0x7FFE87B831C0
        public void ForAOTCompilationOnly(){} // RVA: 0x7FFE87B83250
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7FFE87B832B0
        public void AddOutputWeightProcessor(){} // RVA: 0x7FFE87B83350
        public void AddEvaluateCallback(){} // RVA: 0x7FFE87B835D0
        public void InvokeOutputCallbacks(){} // RVA: 0x7FFE87B83760
        public void TryGetCallbackList(){} // RVA: 0x7FFE87B842E0
        public void .ctor(){} // RVA: 0x7FFE87B844D0
        public void .cctor(){} // RVA: 0x7FFE87B84B50
    }

    public class TimelineUndo : Object
    {
        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x7FFE810FB320
        public void PushDestroyUndo(){} // RVA: 0x7FFE87B88910
        public void PushUndo(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7FFE810FB310
        public void UndoName(){} // RVA: 0x7FFE87B88A00
    }

    public class TrackAsset : PlayableAsset
    {
        public int k_LatestVersion;
        public int m_Version; // 0x18
        public UnityEngine.AnimationClip m_AnimClip; // 0x20
        public TransientBuildData s_BuildData;
        public string kDefaultCurvesName;
        public System.Action`3<UnityEngine.Timeline.TimelineClip,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnClipPlayableCreate; // 0x18
        public System.Action`3<UnityEngine.Timeline.TrackAsset,UnityEngine.GameObject,UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate; // 0x20
        public bool m_Locked; // 0x28
        public bool m_Muted; // 0x29
        public string m_CustomPlayableFullTypename; // 0x30
        public UnityEngine.AnimationClip m_Curves; // 0x38
        public UnityEngine.Playables.PlayableAsset m_Parent; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> m_Children; // 0x48
        public int m_ItemsHash; // 0x50
        public UnityEngine.Timeline.TimelineClip[] m_ClipsCache; // 0x58
        public UnityEngine.Timeline.DiscreteTime m_Start; // 0x60
        public UnityEngine.Timeline.DiscreteTime m_End; // 0x68
        public bool m_CacheSorted; // 0x70
        public bool m_BlendsValid; // 0x71
        public System.Nullable`1<bool> m_SupportsNotifications; // 0x72
        public UnityEngine.Timeline.TrackAsset[] s_EmptyCache; // 0x28
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache; // 0x78
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Timeline.TimelineClip> m_Clips; // 0x80

        // ── Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE87B654F0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87B657F0
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFE810FB310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7FFE87B65B00
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7FFE87B65C60
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFE87B65DC0
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFE87B65F20
        public void get_start(){} // RVA: 0x7FFE87B66080
        public void get_end(){} // RVA: 0x7FFE87B66120
        public void get_duration(){} // RVA: 0x7FFE87B661C0
        public void get_muted(){} // RVA: 0x7FFE819C2EA0
        public void set_muted(){} // RVA: 0x7FFE8268C820
        public void get_mutedInHierarchy(){} // RVA: 0x7FFE87B66270
        public void get_timelineAsset(){} // RVA: 0x7FFE87B66520
        public void get_parent(){} // RVA: 0x7FFE81178740
        public void set_parent(){} // RVA: 0x7FFE81123200
        public void GetClips(){} // RVA: 0x7FFE87B66800
        public void get_clips(){} // RVA: 0x7FFE87B66810
        public void get_blendsValid(){} // RVA: 0x7FFE865EFE00
        public void set_blendsValid(){} // RVA: 0x7FFE865EFE10
        public void get_isEmpty(){} // RVA: 0x7FFE87B66970
        public void get_hasClips(){} // RVA: 0x7FFE87B66A20
        public void get_hasCurves(){} // RVA: 0x7FFE87B66A70
        public void get_isSubTrack(){} // RVA: 0x7FFE87B66BA0
        public void get_outputs(){} // RVA: 0x7FFE87B66D20
        public void GetChildTracks(){} // RVA: 0x7FFE87B66DD0
        public void get_customPlayableTypename(){} // RVA: 0x7FFE8144E200
        public void set_customPlayableTypename(){} // RVA: 0x7FFE81129890
        public void get_curves(){} // RVA: 0x7FFE8143BA80
        public void set_curves(){} // RVA: 0x7FFE81437330
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFE87B66DF0
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7FFE827C4A80
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFE87B66E30
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFE827C4A80
        public void get_subTracksObjects(){} // RVA: 0x7FFE81176730
        public void get_locked(){} // RVA: 0x7FFE815F1380
        public void set_locked(){} // RVA: 0x7FFE81C15740
        public void get_lockedInHierarchy(){} // RVA: 0x7FFE87B66E40
        public void get_supportsNotifications(){} // RVA: 0x7FFE87B670F0
        public void __internalAwake(){} // RVA: 0x7FFE87B67180
        public void CreateCurves(){} // RVA: 0x7FFE87B67340
        public void CreateTrackMixer(){} // RVA: 0x7FFE87B674A0
        public void CreatePlayable(){} // RVA: 0x7FFE87B6CA10 | overloaded x2
        public void CreateDefaultClip(){} // RVA: 0x7FFE87B67670
        public void CreateClip(){} // RVA: 0x7FFE87B67C20 | overloaded x2
        public void DeleteClip(){} // RVA: 0x7FFE87B679C0
        public void CreateMarker(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void DeleteMarker(){} // RVA: 0x7FFE87B67B80
        public void GetMarkers(){} // RVA: 0x7FFE87B67B90
        public void GetMarkerCount(){} // RVA: 0x7FFE87B67BC0
        public void GetMarker(){} // RVA: 0x7FFE87B67C10
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7FFE87B67D60
        public void CreateClipOfType(){} // RVA: 0x7FFE87B67DA0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7FFE87B68090
        public void CreateClipFromAsset(){} // RVA: 0x7FFE87B683C0
        public void GetMarkersRaw(){} // RVA: 0x7FFE8113A010
        public void ClearMarkers(){} // RVA: 0x7FFE87B68680
        public void AddMarker(){} // RVA: 0x7FFE87B686F0
        public void DeleteMarkerRaw(){} // RVA: 0x7FFE87B68700
        public void GetTimeRangeHash(){} // RVA: 0x7FFE87B68740
        public void AddClip(){} // RVA: 0x7FFE87B689A0
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFE87B68AE0
        public void CreatePlayableGraph(){} // RVA: 0x7FFE87B68FF0
        public void CompileClips(){} // RVA: 0x7FFE87B69390
        public void GatherCompilableTracks(){} // RVA: 0x7FFE87B69880
        public void GatherNotifications(){} // RVA: 0x7FFE87B69B60
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFE87B69E70
        public void ConfigureTrackAnimation(){} // RVA: 0x7FFE87B6A7D0
        public void SortClips(){} // RVA: 0x7FFE87B6A930
        public void ClearClipsInternal(){} // RVA: 0x7FFE87B6ABB0
        public void ClearSubTracksInternal(){} // RVA: 0x7FFE87B6ACD0
        public void OnClipMove(){} // RVA: 0x7FFE87B6ADA0
        public void CreateNewClipContainerInternal(){} // RVA: 0x7FFE87B6AE00
        public void AddChild(){} // RVA: 0x7FFE87B6B230
        public void MoveLastTrackBefore(){} // RVA: 0x7FFE87B6B380
        public void RemoveSubTrack(){} // RVA: 0x7FFE87B6B710
        public void RemoveClip(){} // RVA: 0x7FFE87B6B7F0
        public void GetEvaluationTime(){} // RVA: 0x7FFE87B6B8C0
        public void GetSequenceTime(){} // RVA: 0x7FFE87B6BB10
        public void GatherProperties(){} // RVA: 0x7FFE87B6BB30
        public void GetGameObjectBinding(){} // RVA: 0x7FFE87B6C1F0
        public void ValidateClipType(){} // RVA: 0x7FFE87B6C4E0
        public void OnCreateClip(){} // RVA: 0x7FFE810FB310
        public void UpdateDuration(){} // RVA: 0x7FFE87B6C7F0
        public void CalculateItemsHash(){} // RVA: 0x7FFE87B6C960
        public void Invalidate(){} // RVA: 0x7FFE87B6CDB0
        public void GetNotificationDuration(){} // RVA: 0x7FFE87B6CEE0
        public void CanCompileClips(){} // RVA: 0x7FFE87B6D0E0
        public void CanCreateTrackMixer(){} // RVA: 0x7FFE869FD660
        public void IsCompilable(){} // RVA: 0x7FFE87B6D140
        public void UpdateChildTrackCache(){} // RVA: 0x7FFE87B6D440
        public void Hash(){} // RVA: 0x7FFE87B6D780
        public void GetClipsHash(){} // RVA: 0x7FFE87B6D800
        public void GetAnimationClipHash(){} // RVA: 0x7FFE87B6DAA0
        public void HasNotifications(){} // RVA: 0x7FFE87B6DC90
        public void CanCompileNotifications(){} // RVA: 0x7FFE87B6DCC0
        public void CanCreateMixerRecursive(){} // RVA: 0x7FFE87B6DD00
        public void .ctor(){} // RVA: 0x7FFE87B6DEA0
        public void .cctor(){} // RVA: 0x7FFE87B6E080
    }

    public class TrackAssetExtensions : Object
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7FFE87B7A650
        public void SetGroup(){} // RVA: 0x7FFE87B7A780
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFE87B7AF10
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x2
    }

    public class TrackClipTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class TrackColorAttribute : Attribute
    {
        public UnityEngine.Color m_Color; // 0x10

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFE826F6B90
        public void .ctor(){} // RVA: 0x7FFE87B6EC40
    }

    public class TrackMediaType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class WeightUtility : Object
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7FFE87B8B6A0
    }

}