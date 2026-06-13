// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 793

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x703A180
        public void OnBehaviourPlay(){} // RVA: 0x703A400
        public void OnBehaviourPause(){} // RVA: 0x703A520
        public void ProcessFrame(){} // RVA: 0x703A630
        public void OnGraphStart(){} // RVA: 0x703A750
        public void OnPlayableDestroy(){} // RVA: 0x703A880
        public void .ctor(){} // RVA: 0x6DC7CB0
    }

    public class ActivationMixerPlayable
    {
        public 0x659A2120 m_PostPlaybackState; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7013850
        public void get_postPlaybackState(){} // RVA: 0x32A5C0
        public void set_postPlaybackState(){} // RVA: 0x2E00C0
        public void OnPlayableDestroy(){} // RVA: 0x70138F0
        public void ProcessFrame(){} // RVA: 0x7013A20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ActivationPlayableAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x519240
        public void CreatePlayable(){} // RVA: 0x7013D80
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class ActivationTrack
    {
        public 0x659A2120 m_PostPlaybackState; // 0xA0

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7013EA0
        public void get_postPlaybackState(){} // RVA: 0x1D76590
        public void set_postPlaybackState(){} // RVA: 0x7013F30
        public void CreateTrackMixer(){} // RVA: 0x7013F50
        public void UpdateTrackMode(){} // RVA: 0x7014190
        public void GatherProperties(){} // RVA: 0x70141B0
        public void OnCreateClip(){} // RVA: 0x70142D0
        public void .ctor(){} // RVA: 0x7014360
    }

    public class AnimationOutputWeightProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70143C0
        public void FindMixers(){} // RVA: 0x70147A0 | overloaded x2
        public void Evaluate(){} // RVA: 0x7014BB0
    }

    public class AnimationPlayableAsset
    {
        public UnityEngine.AnimationClip m_Clip; // 0x18
        public UnityEngine.Vector3 m_Position; // 0x20
        public UnityEngine.Vector3 m_EulerAngles; // 0x2C
        public bool m_UseTrackMatchFields; // 0x38
        public 0x659A2490 m_MatchTargetFields; // 0x3C
        public bool m_RemoveStartOffset; // 0x40
        public bool m_ApplyFootIK; // 0x41
        public 0x659A2280 m_Loop; // 0x44
        public 0x659A2540 <appliedOffsetMode>k__BackingField; // 0x48
        public int k_LatestVersion;
        public int m_Version; // 0x4C
        public UnityEngine.Quaternion m_Rotation; // 0x50

        // ── Methods ──
        public void get_position(){} // RVA: 0x343EE0
        public void set_position(){} // RVA: 0x343F00
        public void get_rotation(){} // RVA: 0x7014E20
        public void set_rotation(){} // RVA: 0x7014ED0
        public void get_eulerAngles(){} // RVA: 0x343F10
        public void set_eulerAngles(){} // RVA: 0x343F30
        public void get_useTrackMatchFields(){} // RVA: 0x4A6500
        public void set_useTrackMatchFields(){} // RVA: 0x4A78C0
        public void get_matchTargetFields(){} // RVA: 0x891AF0
        public void set_matchTargetFields(){} // RVA: 0x1CB95F0
        public void get_removeStartOffset(){} // RVA: 0x398C00
        public void set_removeStartOffset(){} // RVA: 0x398C10
        public void get_applyFootIK(){} // RVA: 0x65EEC0
        public void set_applyFootIK(){} // RVA: 0x65EEB0
        public void get_loop(){} // RVA: 0x37E0A0
        public void set_loop(){} // RVA: 0x37E0B0
        public void get_hasRootTransforms(){} // RVA: 0x7014F00
        public void get_appliedOffsetMode(){} // RVA: 0x37E0C0
        public void set_appliedOffsetMode(){} // RVA: 0x37E0D0
        public void get_clip(){} // RVA: 0x2E07C0
        public void set_clip(){} // RVA: 0x7015010
        public void get_duration(){} // RVA: 0x7015160
        public void get_outputs(){} // RVA: 0x7015210
        public void CreatePlayable(){} // RVA: 0x70153F0 | overloaded x2
        public void ShouldApplyOffset(){} // RVA: 0x7015CD0
        public void ShouldApplyScaleRemove(){} // RVA: 0x7015D40
        public void get_clipCaps(){} // RVA: 0x7015D60
        public void ResetOffsets(){} // RVA: 0x7015F50
        public void GatherProperties(){} // RVA: 0x7015FE0
        public void HasRootTransforms(){} // RVA: 0x70160B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7016240
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x70162A0
        public void OnUpgradeFromVersion(){} // RVA: 0x7016330
        public void .ctor(){} // RVA: 0x7016370
        public void .cctor(){} // RVA: 0x7016490
    }

    public class AnimationPreviewUpdateCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7016780
        public void Evaluate(){} // RVA: 0x7016840
        public void FetchPreviewComponents(){} // RVA: 0x7016AB0
    }

    public class AnimationTrack
    {
        public string k_DefaultInfiniteClipName;
        public string k_DefaultRecordableClipName;
        public 0x659A2800 m_InfiniteClipPreExtrapolation; // 0xA0
        public 0x659A2800 m_InfiniteClipPostExtrapolation; // 0xA4
        public UnityEngine.Vector3 m_InfiniteClipOffsetPosition; // 0xA8
        public UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
        public double m_InfiniteClipTimeOffset; // 0xC0
        public bool m_InfiniteClipRemoveOffset; // 0xC8
        public bool m_InfiniteClipApplyFootIK; // 0xC9
        public 0x659A2280 mInfiniteClipLoop; // 0xCC
        public 0x659A2490 m_MatchTargetFields; // 0xD0
        public UnityEngine.Vector3 m_Position; // 0xD4
        public UnityEngine.Vector3 m_EulerAngles; // 0xE0
        public UnityEngine.AvatarMask m_AvatarMask; // 0xF0
        public bool m_ApplyAvatarMask; // 0xF8
        public 0x659A24E8 m_TrackOffset; // 0xFC
        public UnityEngine.AnimationClip m_InfiniteClip; // 0x100
        public System.Collections.Generic.Queue`1<UnityEngine.Transform> s_CachedQueue;
        public UnityEngine.Quaternion m_OpenClipOffsetRotation; // 0x108
        public UnityEngine.Quaternion m_Rotation; // 0x118
        public bool m_ApplyOffsets; // 0x128

        // ── Methods ──
        public void get_position(){} // RVA: 0x3DF13B0
        public void set_position(){} // RVA: 0x3DF13D0
        public void get_rotation(){} // RVA: 0x7016E00
        public void set_rotation(){} // RVA: 0x7016EB0
        public void get_eulerAngles(){} // RVA: 0x7016EE0
        public void set_eulerAngles(){} // RVA: 0x7016F00
        public void get_applyOffsets(){} // RVA: 0x2DD320
        public void set_applyOffsets(){} // RVA: 0x2DD310
        public void get_trackOffset(){} // RVA: 0x120BB40
        public void set_trackOffset(){} // RVA: 0x7016F20
        public void get_matchTargetFields(){} // RVA: 0xA50BB0
        public void set_matchTargetFields(){} // RVA: 0x7016F30
        public void get_infiniteClip(){} // RVA: 0xA94E10
        public void set_infiniteClip(){} // RVA: 0xCF6DE0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x126AF80
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x126BEE0
        public void get_avatarMask(){} // RVA: 0x3482A0
        public void set_avatarMask(){} // RVA: 0x3482B0
        public void get_applyAvatarMask(){} // RVA: 0x1209D80
        public void set_applyAvatarMask(){} // RVA: 0x7016FA0
        public void CanCompileClips(){} // RVA: 0x7016FB0
        public void get_outputs(){} // RVA: 0x70170F0
        public void get_inClipMode(){} // RVA: 0x70171A0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x70171E0
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7017200
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7017220
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x70172D0
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7017300
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7017320
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x13428A0
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x61B8650
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7017340
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7017350
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x1D76590
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x1D76550
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x3C49C00
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x3C49C10
        public void get_infiniteClipLoop(){} // RVA: 0x1884A40
        public void set_infiniteClipLoop(){} // RVA: 0x612FAE0
        public void ResetOffsets(){} // RVA: 0x7017360
        public void CreateClip(){} // RVA: 0x7017400
        public void CreateInfiniteClip(){} // RVA: 0x7017520
        public void CreateRecordableClip(){} // RVA: 0x7017700
        public void OnCreateClip(){} // RVA: 0x70179E0
        public void CalculateItemsHash(){} // RVA: 0x7017A50
        public void UpdateClipOffsets(){} // RVA: 0x2DD310
        public void CompileTrackPlayable(){} // RVA: 0x7017B60
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7018170
        public void CreateMixerPlayableGraph(){} // RVA: 0x7018210
        public void GetDefaultBlendCount(){} // RVA: 0x519240
        public void AttachDefaultBlend(){} // RVA: 0x2DD310
        public void AttachOffsetPlayable(){} // RVA: 0x7018DD0
        public void RequiresMotionXPlayable(){} // RVA: 0x7018FB0
        public void UsesAbsoluteMotion(){} // RVA: 0x7019190
        public void HasController(){} // RVA: 0x70191A0
        public void GetBinding(){} // RVA: 0x7019430
        public void CreateGroupMixer(){} // RVA: 0x7019810
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7019900
        public void ApplyTrackOffset(){} // RVA: 0x7019E60
        public void GetEvaluationTime(){} // RVA: 0x701A0F0
        public void GetSequenceTime(){} // RVA: 0x701A1C0
        public void AssignAnimationClip(){} // RVA: 0x701A310
        public void GatherProperties(){} // RVA: 0x2DD310
        public void GetAnimationClips(){} // RVA: 0x701A790
        public void GetOffsetMode(){} // RVA: 0x701AD90
        public void IsRootTransformDisabledByMask(){} // RVA: 0x701AEC0
        public void GetGenericRootNode(){} // RVA: 0x701B4A0
        public void AnimatesRootTransform(){} // RVA: 0x701B880
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x701BB30
        public void get_openClipOffsetPosition(){} // RVA: 0x70171E0
        public void set_openClipOffsetPosition(){} // RVA: 0x7017200
        public void get_openClipOffsetRotation(){} // RVA: 0x7017220
        public void set_openClipOffsetRotation(){} // RVA: 0x701BD70
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7017300
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7017320
        public void get_openClipPreExtrapolation(){} // RVA: 0x1D76590
        public void set_openClipPreExtrapolation(){} // RVA: 0x1D76550
        public void get_openClipPostExtrapolation(){} // RVA: 0x3C49C00
        public void set_openClipPostExtrapolation(){} // RVA: 0x3C49C10
        public void OnUpgradeFromVersion(){} // RVA: 0x701BDB0
        public void .ctor(){} // RVA: 0x701BFA0
        public void .cctor(){} // RVA: 0x701C1D0
    }

    public class AudioClipProperties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x702DDB0
    }

    public class AudioMixerProperties
    {
        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x702DDC0
        public void .ctor(){} // RVA: 0x702DDB0
    }

    public class AudioPlayableAsset
    {
        public UnityEngine.AudioClip m_Clip; // 0x18
        public bool m_Loop; // 0x20
        public float m_bufferingTime; // 0x24
        public UnityEngine.Timeline.AudioClipProperties m_ClipProperties; // 0x28

        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x44AF50
        public void set_bufferingTime(){} // RVA: 0x44AF60
        public void get_clip(){} // RVA: 0x2E07C0
        public void set_clip(){} // RVA: 0x343E80
        public void get_loop(){} // RVA: 0x3CB9D0
        public void set_loop(){} // RVA: 0x3CB9E0
        public void get_duration(){} // RVA: 0x702E1B0
        public void get_outputs(){} // RVA: 0x702E3B0
        public void CreatePlayable(){} // RVA: 0x702E460
        public void get_clipCaps(){} // RVA: 0x702E6E0
        public void .ctor(){} // RVA: 0x702E6F0
    }

    public class AudioTrack
    {
        public UnityEngine.Timeline.AudioMixerProperties m_TrackProperties; // 0xA0

        // ── Methods ──
        public void CreateClip(){} // RVA: 0x702E9F0
        public void CompileClips(){} // RVA: 0x702ECF0
        public void get_outputs(){} // RVA: 0x702F660
        public void OnValidate(){} // RVA: 0x702F710
        public void .ctor(){} // RVA: 0x702F7B0
    }

    public class BasicPlayableBehaviour
    {
        // ── Methods ──
        public void get_duration(){} // RVA: 0x703A9C0
        public void get_outputs(){} // RVA: 0x703AA20
        public void OnGraphStart(){} // RVA: 0x2DD310
        public void OnGraphStop(){} // RVA: 0x2DD310
        public void OnPlayableCreate(){} // RVA: 0x2DD310
        public void OnPlayableDestroy(){} // RVA: 0x2DD310
        public void OnBehaviourPlay(){} // RVA: 0x2DD310
        public void OnBehaviourPause(){} // RVA: 0x2DD310
        public void PrepareFrame(){} // RVA: 0x2DD310
        public void ProcessFrame(){} // RVA: 0x2DD310
        public void CreatePlayable(){} // RVA: 0x703AA80
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class BlendUtility
    {
        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7044040
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7044180
        public void UpdateClipIntersection(){} // RVA: 0x70445A0
        public void .cctor(){} // RVA: 0x7044790
    }

    public class ControlPlayableAsset
    {
        public int k_MaxRandInt;
        public System.Collections.Generic.List`1<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;
        public System.Collections.Generic.List`1<UnityEngine.ParticleSystem> k_EmptyParticlesList; // 0x8
        public System.Collections.Generic.HashSet`1<UnityEngine.ParticleSystem> s_SubEmitterCollector; // 0x10

        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x4FE4B90
        public void set_controllingDirectors(){} // RVA: 0x601E3A0
        public void get_controllingParticles(){} // RVA: 0x5A6E50
        public void set_controllingParticles(){} // RVA: 0x59F960
        public void OnEnable(){} // RVA: 0x702FAE0
        public void get_duration(){} // RVA: 0x4363CB0
        public void get_clipCaps(){} // RVA: 0x702FB40
        public void CreatePlayable(){} // RVA: 0x702FB50
        public void ConnectPlayablesToMixer(){} // RVA: 0x7030990
        public void CreateActivationPlayable(){} // RVA: 0x7030DE0
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7030FA0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7031380
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x70318D0
        public void ConnectMixerAndPlayable(){} // RVA: 0x7031DC0
        public void GetComponent(){} // RVA: 0xCE10
        public void GetControlableScripts(){} // RVA: 0x7031F00
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7031FB0
        public void GetControllableParticleSystems(){} // RVA: 0x7032AA0 | overloaded x2
        public void CacheSubEmitters(){} // RVA: 0x7032DA0
        public void GatherProperties(){} // RVA: 0x7033030
        public void PreviewParticles(){} // RVA: 0x7033440
        public void PreviewActivation(){} // RVA: 0x7033890
        public void PreviewTimeControl(){} // RVA: 0x7033B10
        public void PreviewDirectors(){} // RVA: 0x7033D60
        public void .ctor(){} // RVA: 0x70340E0
        public void .cctor(){} // RVA: 0x7034160
    }

    public class ControlTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70348B0
    }

    public class CurveEditUtility
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7034900
    }

    public class CustomSignalEventDrawer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CustomStyleAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class DirectorControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x703AC40
        public void OnPlayableDestroy(){} // RVA: 0x703AEA0
        public void PrepareFrame(){} // RVA: 0x703B070
        public void OnBehaviourPlay(){} // RVA: 0x703B360
        public void OnBehaviourPause(){} // RVA: 0x703B520
        public void ProcessFrame(){} // RVA: 0x703B700
        public void SyncSpeed(){} // RVA: 0x703BC70
        public void SyncStart(){} // RVA: 0x703C050
        public void SyncStop(){} // RVA: 0x703C210
        public void DetectDiscontinuity(){} // RVA: 0x703C3F0
        public void DetectOutOfSync(){} // RVA: 0x703C620
        public void UpdateTime(){} // RVA: 0x703C780
        public void .ctor(){} // RVA: 0x703C9C0
    }

    public class DiscreteTime
    {
        public double k_Tick;

        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7034AD0
        public void .ctor(){} // RVA: 0x7034C40 | overloaded x6
        public void OneTickBefore(){} // RVA: 0x7034CC0
        public void OneTickAfter(){} // RVA: 0x7034CD0
        public void GetTick(){} // RVA: 0x1AD4690
        public void FromTicks(){} // RVA: 0x1A3F520
        public void CompareTo(){} // RVA: 0x7034CE0
        public void Equals(){} // RVA: 0x7034D90 | overloaded x2
        public void DoubleToDiscreteTime(){} // RVA: 0x7034E30
        public void FloatToDiscreteTime(){} // RVA: 0x7034EC0
        public void IntToDiscreteTime(){} // RVA: 0x7034F50
        public void ToDouble(){} // RVA: 0x7034FB0
        public void ToFloat(){} // RVA: 0x7034FD0
        public void op_Explicit(){} // RVA: 0x1A3F520 | overloaded x6
        public void op_Implicit(){} // RVA: 0x70351E0
        public void op_Equality(){} // RVA: 0x2878D00
        public void op_Inequality(){} // RVA: 0x7035270
        public void op_GreaterThan(){} // RVA: 0x5EB94D0
        public void op_LessThan(){} // RVA: 0x5EB94B0
        public void op_LessThanOrEqual(){} // RVA: 0x5EB94C0
        public void op_GreaterThanOrEqual(){} // RVA: 0x5EB94E0
        public void op_Addition(){} // RVA: 0x2878BF0
        public void op_Subtraction(){} // RVA: 0x70352D0
        public void ToString(){} // RVA: 0x70352E0
        public void GetHashCode(){} // RVA: 0x7035380
        public void Min(){} // RVA: 0x7035390
        public void Max(){} // RVA: 0x70353F0
        public void SnapToNearestTick(){} // RVA: 0x70354C0 | overloaded x2
        public void GetNearestTick(){} // RVA: 0x7035570
        public void .cctor(){} // RVA: 0x70355D0
    }

    public class Extrapolation
    {
        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7044A30
        public void SortClipsByStartTime(){} // RVA: 0x7044F00
        public void .cctor(){} // RVA: 0x7045210
    }

    public class FrameRateFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GroupTrack
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x2DD320
        public void get_outputs(){} // RVA: 0x703A0D0
        public void .ctor(){} // RVA: 0x703A130
    }

    public class HashUtility
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7045590 | overloaded x7
    }

    public class HideInMenuAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ICurvesOwner
    {
        // ── Methods ──
        public void get_curves(){} // RVA: 0xCD60
        public void get_hasCurves(){} // RVA: 0xDBE0
        public void get_duration(){} // RVA: 0x12A40
        public void CreateCurves(){} // RVA: 0x24B10
        public void get_defaultCurvesName(){} // RVA: 0xCD60
        public void get_asset(){} // RVA: 0xCD60
        public void get_assetOwner(){} // RVA: 0xCD60
        public void get_targetTrack(){} // RVA: 0xCD60
    }

    public class IInterval
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0xCD60
        public void get_intervalEnd(){} // RVA: 0xCD60
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){}
    }

    public class IMarker
    {
        // ── Methods ──
        public void get_time(){} // RVA: 0x12A40
        public void set_time(){} // RVA: 0x26100
        public void get_parent(){} // RVA: 0xCD60
        public void Initialize(){} // RVA: 0x24B10
    }

    public class INotificationOptionProvider
    {
        // ── Methods ──
        public void get_flags(){} // RVA: 0xCC90
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x24B10
        public void PopActiveGameObject(){} // RVA: 0x24A50
        public void AddFromClip(){} // RVA: 0x2DC60 | overloaded x2
        public void AddFromClips(){} // RVA: 0x2DC60 | overloaded x2
        public void AddFromName(){} // RVA: 0x2DC60 | overloaded x5
        public void AddFromComponent(){} // RVA: 0x2DC60
        public void AddObjectProperties(){} // RVA: 0x2DC60
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x2DC60
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x26100
        public void OnControlTimeStart(){} // RVA: 0x24A50
        public void OnControlTimeStop(){} // RVA: 0x24A50
    }

    public class ITimelineClipAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0xD840
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x24A50
    }

    public class IgnoreOnPlayableTrackAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class InfiniteRuntimeClip
    {
        public UnityEngine.Playables.Playable m_Playable; // 0x18
        public long kIntervalEnd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9949A0
        public void get_intervalStart(){} // RVA: 0x519240
        public void get_intervalEnd(){} // RVA: 0x7035620
        public void set_enable(){} // RVA: 0x7035680
        public void EvaluateAt(){} // RVA: 0x7035700
        public void DisableAt(){} // RVA: 0x7035760
        public void .cctor(){} // RVA: 0x70357D0
    }

    public class IntervalTreeNode
    {
    }

    public class IntervalTree`1
    {
        public int kMinNodeSize;

        // ── Methods ──
        public void get_dirty(){} // RVA: 0xDBE0
        public void set_dirty(){} // RVA: 0x25130
        public void Add(){} // RVA: 0x283FA0
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x283FA0
        public void UpdateIntervals(){} // RVA: 0x24A50
        public void Query(){} // RVA: 0x283FA0
        public void QueryRange(){} // RVA: 0x283FA0
        public void Rebuild(){} // RVA: 0x14170 | overloaded x2
        public void Clear(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Marker
    {
        public double m_Time; // 0x18
        public UnityEngine.Timeline.TrackAsset <parent>k__BackingField; // 0x20

        // ── Methods ──
        public void get_parent(){} // RVA: 0x30B0C0
        public void set_parent(){} // RVA: 0x30B0D0
        public void get_time(){} // RVA: 0x196AD00
        public void set_time(){} // RVA: 0x70369E0
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7036A80
        public void OnInitialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class MarkerList
    {
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> m_Objects; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> m_Cache; // 0x18
        public bool m_CacheDirty; // 0x20

        // ── Methods ──
        public void get_markers(){} // RVA: 0x7036C20
        public void .ctor(){} // RVA: 0x7036C40
        public void Add(){} // RVA: 0x7036DC0
        public void Remove(){} // RVA: 0x7037040 | overloaded x2
        public void Clear(){} // RVA: 0x7037100
        public void Contains(){} // RVA: 0x7037170
        public void GetMarkers(){} // RVA: 0x7036C20
        public void get_Count(){} // RVA: 0x70371D0
        public void get_Item(){} // RVA: 0x7037220
        public void GetRawMarkerList(){} // RVA: 0x1AD4690
        public void CreateMarker(){} // RVA: 0x70372A0
        public void HasNotifications(){} // RVA: 0x70375D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6BD7E0
        public void BuildCache(){} // RVA: 0x70375F0
    }

    public class MarkerTrack
    {
        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7037950
        public void .ctor(){} // RVA: 0x7037C20
    }

    public class MatchTargetFieldConstants
    {
        // ── Methods ──
        public void HasAny(){} // RVA: 0x7016D00
        public void Toggle(){} // RVA: 0x7016D70
        public void .cctor(){} // RVA: 0x7016D80
    }

    public class MenuCategoryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x703FF90
    }

    public class NotKeyableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NotificationUtilities
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7045690 | overloaded x3
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7045DD0
    }

    public class ParticleControlPlayable
    {
        public float kUnsetTime;

        // ── Methods ──
        public void Create(){} // RVA: 0x703C9D0
        public void get_particleSystem(){} // RVA: 0x30B0C0
        public void set_particleSystem(){} // RVA: 0x30B0D0
        public void Initialize(){} // RVA: 0x703CCA0
        public void SetRandomSeed(){} // RVA: 0x703CD60
        public void PrepareFrame(){} // RVA: 0x703D070
        public void OnBehaviourPlay(){} // RVA: 0x703D320
        public void OnBehaviourPause(){} // RVA: 0x703D320
        public void Simulate(){} // RVA: 0x703D330
        public void .ctor(){} // RVA: 0x703D500
    }

    public class PlayableTrack
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x703FD60
        public void .ctor(){} // RVA: 0x703FED0
    }

    public class PrefabControlPlayable
    {
        public UnityEngine.GameObject m_Instance; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x703D520
        public void get_prefabInstance(){} // RVA: 0x2F8380
        public void Initialize(){} // RVA: 0x703D750
        public void OnPlayableDestroy(){} // RVA: 0x703DB40
        public void OnBehaviourPlay(){} // RVA: 0x703DCC0
        public void OnBehaviourPause(){} // RVA: 0x703DDE0
        public void SetHideFlagsRecursive(){} // RVA: 0x703DEF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RuntimeClip
    {
        public UnityEngine.Timeline.TimelineClip m_Clip; // 0x18
        public UnityEngine.Playables.Playable m_Playable; // 0x20
        public UnityEngine.Playables.Playable m_ParentMixer; // 0x30

        // ── Methods ──
        public void get_start(){} // RVA: 0x70358C0
        public void get_duration(){} // RVA: 0x70358F0
        public void .ctor(){} // RVA: 0x7035910
        public void Create(){} // RVA: 0x7035910
        public void get_clip(){} // RVA: 0x2E07C0
        public void get_mixer(){} // RVA: 0x5CC8940
        public void get_playable(){} // RVA: 0x1EFB630
        public void set_enable(){} // RVA: 0x70359E0
        public void SetTime(){} // RVA: 0x7035B40
        public void SetDuration(){} // RVA: 0x7035BA0
        public void EvaluateAt(){} // RVA: 0x7035C00
        public void DisableAt(){} // RVA: 0x7035F50
    }

    public class RuntimeClipBase
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x12A40
        public void get_duration(){} // RVA: 0x12A40
        public void get_intervalStart(){} // RVA: 0x7036160
        public void get_intervalEnd(){} // RVA: 0x7036210
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RuntimeElement
    {
        public int <intervalBit>k__BackingField; // 0x10

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0xCD60
        public void get_intervalEnd(){} // RVA: 0xCD60
        public void get_intervalBit(){} // RVA: 0x32A5C0
        public void set_intervalBit(){} // RVA: 0x2E00C0
        public void set_enable(){} // RVA: 0x25130
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ScheduleRuntimeClip
    {
        public UnityEngine.Timeline.TimelineClip m_Clip; // 0x18
        public UnityEngine.Playables.Playable m_Playable; // 0x20
        public UnityEngine.Playables.Playable m_ParentMixer; // 0x30
        public double m_StartDelay; // 0x40
        public double m_FinishTail; // 0x48
        public bool m_Started; // 0x50

        // ── Methods ──
        public void get_start(){} // RVA: 0x70362E0
        public void get_duration(){} // RVA: 0x7036390
        public void SetTime(){} // RVA: 0x70363E0
        public void get_clip(){} // RVA: 0x2E07C0
        public void get_mixer(){} // RVA: 0x5CC8940
        public void get_playable(){} // RVA: 0x1EFB630
        public void .ctor(){} // RVA: 0x7036440
        public void Create(){} // RVA: 0x7036440
        public void set_enable(){} // RVA: 0x7036520
        public void EvaluateAt(){} // RVA: 0x7036640
        public void DisableAt(){} // RVA: 0x70369C0
    }

    public class SignalAsset
    {
        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7037C70
        public void remove_OnEnableCallback(){} // RVA: 0x7037DA0
        public void OnEnable(){} // RVA: 0x7037ED0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SignalEmitter
    {
        public bool m_Retroactive; // 0x28
        public bool m_EmitOnce; // 0x29
        public UnityEngine.Timeline.SignalAsset m_Asset; // 0x30

        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x6E8A80
        public void set_retroactive(){} // RVA: 0x6E8B80
        public void get_emitOnce(){} // RVA: 0xC36000
        public void set_emitOnce(){} // RVA: 0x190AB20
        public void get_asset(){} // RVA: 0x6374D0
        public void set_asset(){} // RVA: 0x30B890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7037F30
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x70380D0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SignalReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7038100
        public void AddReaction(){} // RVA: 0x7038300
        public void AddEmptyReaction(){} // RVA: 0x70384C0
        public void Remove(){} // RVA: 0x7038530
        public void GetRegisteredSignals(){} // RVA: 0xF9D710
        public void GetReaction(){} // RVA: 0x70386B0
        public void Count(){} // RVA: 0x70386F0
        public void ChangeSignalAtIndex(){} // RVA: 0x7038740
        public void RemoveAtIndex(){} // RVA: 0x7038C00
        public void ChangeReactionAtIndex(){} // RVA: 0x7038D10
        public void GetReactionAtIndex(){} // RVA: 0x7038E00
        public void GetSignalAssetAtIndex(){} // RVA: 0x7038EE0
        public void OnEnable(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x7038FC0
    }

    public class SignalTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7037C20
    }

    public class SupportsChildTracksAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
    }

    public class TimeControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x703E330
        public void Initialize(){} // RVA: 0x2DEE30
        public void PrepareFrame(){} // RVA: 0x703E4F0
        public void OnBehaviourPlay(){} // RVA: 0x703E570
        public void OnBehaviourPause(){} // RVA: 0x703E5D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TimeFieldAttribute
    {
        public 0x659A4220 <useEditMode>k__BackingField; // 0x10

        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class TimeNotificationBehaviour
    {
        public System.Collections.Generic.List`1<NotificationEntry> m_Notifications; // 0x10

        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x111C380
        public void Create(){} // RVA: 0x703E630
        public void AddNotification(){} // RVA: 0x703E830
        public void OnGraphStart(){} // RVA: 0x703E930
        public void OnBehaviourPause(){} // RVA: 0x703EB50
        public void PrepareFrame(){} // RVA: 0x703EE20
        public void SortNotifications(){} // RVA: 0x703F210
        public void CanRestoreNotification(){} // RVA: 0x703F430
        public void TriggerNotificationsInRange(){} // RVA: 0x703F470
        public void SyncDurationWithExternalSource(){} // RVA: 0x703F720
        public void Trigger_internal(){} // RVA: 0x703F9E0
        public void Restore_internal(){} // RVA: 0x6BDA00
        public void .ctor(){} // RVA: 0x703FB80
    }

    public class TimeUtility
    {
        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7047B80
        public void ToFrames(){} // RVA: 0x7047C40
        public void ToExactFrames(){} // RVA: 0x7047DB0
        public void FromFrames(){} // RVA: 0x7047E90 | overloaded x2
        public void OnFrameBoundary(){} // RVA: 0x70483A0 | overloaded x2
        public void GetEpsilon(){} // RVA: 0x7048010
        public void PreviousFrame(){} // RVA: 0x7048100
        public void NextFrame(){} // RVA: 0x70481A0
        public void PreviousFrameTime(){} // RVA: 0x7048210
        public void NextFrameTime(){} // RVA: 0x70482F0
        public void RoundToFrame(){} // RVA: 0x7048470
        public void TimeAsFrames(){} // RVA: 0x7048570
        public void TimeAsTimeCode(){} // RVA: 0x7048700
        public void ParseTimeCode(){} // RVA: 0x7048E00
        public void ParseTimeSeconds(){} // RVA: 0x70494E0
        public void GetAnimationClipLength(){} // RVA: 0x7049A10
        public void RemoveChar(){} // RVA: 0x7049C10
        public void GetClosestFrameRate(){} // RVA: 0x7049CE0
        public void ToFrameRate(){} // RVA: 0x7049F70
        public void ToStandardFrameRate(){} // RVA: 0x704A160
        public void .cctor(){} // RVA: 0x704A5D0
    }

    public class TimelineAsset
    {
        public int k_LatestVersion;
        public int m_Version; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.ScriptableObject> m_Tracks; // 0x20
        public double m_FixedDuration; // 0x28
        public UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks; // 0x38
        public UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks; // 0x40
        public EditorSettings m_EditorSettings; // 0x48
        public 0x659A2A10 m_DurationMode; // 0x50
        public UnityEngine.Timeline.MarkerTrack m_MarkerTrack; // 0x58

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x2DD310
        public void get_editorSettings(){} // RVA: 0x358730
        public void get_duration(){} // RVA: 0x701F690
        public void get_fixedDuration(){} // RVA: 0x701F730
        public void set_fixedDuration(){} // RVA: 0x701F850
        public void get_durationMode(){} // RVA: 0x59C540
        public void set_durationMode(){} // RVA: 0x65F570
        public void get_outputs(){} // RVA: 0x701F8F0
        public void get_clipCaps(){} // RVA: 0x701F9A0
        public void get_outputTrackCount(){} // RVA: 0x701FB60
        public void get_rootTrackCount(){} // RVA: 0x701FB90
        public void OnValidate(){} // RVA: 0x701FBE0
        public void GetRootTrack(){} // RVA: 0x701FC20
        public void GetRootTracks(){} // RVA: 0x701FCA0
        public void GetOutputTrack(){} // RVA: 0x701FCC0
        public void GetOutputTracks(){} // RVA: 0x701FD10
        public void GetValidFrameRate(){} // RVA: 0x701FD30
        public void UpdateRootTrackCache(){} // RVA: 0x701FE20
        public void UpdateOutputTrackCache(){} // RVA: 0x70202A0
        public void get_flattenedTracks(){} // RVA: 0x7020540
        public void get_markerTrack(){} // RVA: 0x3A5500
        public void get_trackObjects(){} // RVA: 0x30B0C0
        public void AddTrackInternal(){} // RVA: 0x7020750
        public void RemoveTrack(){} // RVA: 0x7020800
        public void CreatePlayable(){} // RVA: 0x7020980
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xA52E70
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7020C50
        public void __internalAwake(){} // RVA: 0x7020C60
        public void GatherProperties(){} // RVA: 0x7020EC0
        public void CreateMarkerTrack(){} // RVA: 0x70210D0
        public void RemoveMarkerTrack(){} // RVA: 0x70212C0
        public void Invalidate(){} // RVA: 0x7021400
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7021500
        public void CalculateItemsDuration(){} // RVA: 0x70215B0
        public void AddSubTracksRecursive(){} // RVA: 0x7021830
        public void CreateTrack(){} // RVA: 0x283FA0 | overloaded x4
        public void DeleteClip(){} // RVA: 0x7022030
        public void DeleteTrack(){} // RVA: 0x7022410
        public void MoveLastTrackBefore(){} // RVA: 0x70229D0
        public void AllocateTrack(){} // RVA: 0x7022D60
        public void DeleteRecordedAnimation(){} // RVA: 0x70234F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7023790
    }

    public class TimelineClip
    {
        public int k_LatestVersion;
        public int m_Version; // 0x10
        public 0x659A3040 kDefaultClipCaps;
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
        public 0x659A2858 m_BlendInCurveMode; // 0x78
        public 0x659A2858 m_BlendOutCurveMode; // 0x7C
        public System.Collections.Generic.List`1<string> m_ExposedParameterNames; // 0x80
        public UnityEngine.AnimationClip m_AnimationCurves; // 0x88
        public bool m_Recordable; // 0x90
        public 0x659A2800 m_PostExtrapolationMode; // 0x94
        public 0x659A2800 m_PreExtrapolationMode; // 0x98
        public double m_PostExtrapolationTime; // 0xA0
        public double m_PreExtrapolationTime; // 0xA8
        public string m_DisplayName; // 0xB0

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x701C630
        public void .ctor(){} // RVA: 0x701C660
        public void get_hasPreExtrapolation(){} // RVA: 0x701C690
        public void get_hasPostExtrapolation(){} // RVA: 0x701C6B0
        public void get_timeScale(){} // RVA: 0x701C6D0
        public void set_timeScale(){} // RVA: 0x701C7E0
        public void get_start(){} // RVA: 0x196AD00
        public void set_start(){} // RVA: 0x701C900
        public void get_duration(){} // RVA: 0x6EE5040
        public void set_duration(){} // RVA: 0x701CB10
        public void get_end(){} // RVA: 0x701CCD0
        public void get_clipIn(){} // RVA: 0x701CCE0
        public void set_clipIn(){} // RVA: 0x701CD10
        public void get_displayName(){} // RVA: 0x348040
        public void set_displayName(){} // RVA: 0x348050
        public void get_clipAssetDuration(){} // RVA: 0x701CE30
        public void get_curves(){} // RVA: 0x31C010
        public void set_curves(){} // RVA: 0x463060
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x701CEA0
        public void get_hasCurves(){} // RVA: 0x701CF00
        public void get_asset(){} // RVA: 0x30B130
        public void set_asset(){} // RVA: 0x2DEE90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x35A740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x35A740
        public void get_underlyingAsset(){} // RVA: 0x519240
        public void set_underlyingAsset(){} // RVA: 0x2DD310
        public void get_parentTrack(){} // RVA: 0x35A740
        public void set_parentTrack(){} // RVA: 0x701D040
        public void GetParentTrack(){} // RVA: 0x35A740
        public void SetParentTrack_Internal(){} // RVA: 0x701D050
        public void get_easeInDuration(){} // RVA: 0x701D310
        public void set_easeInDuration(){} // RVA: 0x701D410
        public void get_easeOutDuration(){} // RVA: 0x701D560
        public void set_easeOutDuration(){} // RVA: 0x701D660
        public void get_eastOutTime(){} // RVA: 0x701D7B0
        public void get_easeOutTime(){} // RVA: 0x701D7B0
        public void get_blendInDuration(){} // RVA: 0x701D7F0
        public void set_blendInDuration(){} // RVA: 0x701D820
        public void get_blendOutDuration(){} // RVA: 0x701D8C0
        public void set_blendOutDuration(){} // RVA: 0x701D8F0
        public void get_blendInCurveMode(){} // RVA: 0x1AE3800
        public void set_blendInCurveMode(){} // RVA: 0x1AE6D80
        public void get_blendOutCurveMode(){} // RVA: 0x1AE6E60
        public void set_blendOutCurveMode(){} // RVA: 0x6248F70
        public void get_hasBlendIn(){} // RVA: 0x701D990
        public void get_hasBlendOut(){} // RVA: 0x701D9D0
        public void get_mixInCurve(){} // RVA: 0x701DA10
        public void set_mixInCurve(){} // RVA: 0x358D60
        public void get_mixInPercentage(){} // RVA: 0x701DB20
        public void get_mixInDuration(){} // RVA: 0x701DB40
        public void get_mixOutCurve(){} // RVA: 0x701DC70
        public void set_mixOutCurve(){} // RVA: 0x3A55A0
        public void get_mixOutTime(){} // RVA: 0x701DD80
        public void get_mixOutDuration(){} // RVA: 0x701DE00
        public void get_mixOutPercentage(){} // RVA: 0x701DE70
        public void get_recordable(){} // RVA: 0x134A670
        public void set_recordable(){} // RVA: 0x1348E00
        public void get_exposedParameters(){} // RVA: 0x701DEE0
        public void get_clipCaps(){} // RVA: 0x701DFB0
        public void Hash(){} // RVA: 0x701E050
        public void EvaluateMixOut(){} // RVA: 0x701E180
        public void EvaluateMixIn(){} // RVA: 0x701E2E0
        public void GetDefaultMixInCurve(){} // RVA: 0x701E3D0
        public void GetDefaultMixOutCurve(){} // RVA: 0x701E400
        public void ToLocalTime(){} // RVA: 0x701E430
        public void ToLocalTimeUnbound(){} // RVA: 0x701E600
        public void FromLocalTimeUnbound(){} // RVA: 0x701E670
        public void get_animationClip(){} // RVA: 0x701E6D0
        public void SanitizeTimeValue(){} // RVA: 0x701E8A0
        public void get_postExtrapolationMode(){} // RVA: 0x701EA00
        public void set_postExtrapolationMode(){} // RVA: 0x701EA30
        public void get_preExtrapolationMode(){} // RVA: 0x701EA70
        public void set_preExtrapolationMode(){} // RVA: 0x701EAA0
        public void SetPostExtrapolationTime(){} // RVA: 0x701EAE0
        public void SetPreExtrapolationTime(){} // RVA: 0x701EAF0
        public void IsExtrapolatedTime(){} // RVA: 0x701EB00
        public void IsPreExtrapolatedTime(){} // RVA: 0x701EBB0
        public void IsPostExtrapolatedTime(){} // RVA: 0x701EC10
        public void get_extrapolatedStart(){} // RVA: 0x701EC80
        public void get_extrapolatedDuration(){} // RVA: 0x701ECA0
        public void GetExtrapolatedTime(){} // RVA: 0x701EDA0
        public void CreateCurves(){} // RVA: 0x701EEE0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x1AF9470
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x701C630
        public void ToString(){} // RVA: 0x701F070
        public void ConformEaseValues(){} // RVA: 0x701F2C0
        public void CalculateEasingRatio(){} // RVA: 0x701F420
        public void UpdateDirty(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x701F510
    }

    public class TimelineClipCapsExtensions
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x702F9F0
        public void SupportsExtrapolation(){} // RVA: 0x702FA20
        public void SupportsClipIn(){} // RVA: 0x702FA50
        public void SupportsSpeedMultiplier(){} // RVA: 0x702FA80
        public void SupportsBlending(){} // RVA: 0x702FAB0
        public void HasAll(){} // RVA: 0x188F1C0
        public void HasAny(){} // RVA: 0x6A02210
    }

    public class TimelineClipExtensions
    {
        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7045FD0
        public void TryMoveToTrack(){} // RVA: 0x7046500
        public void MoveToTrack_Impl(){} // RVA: 0x7046820
        public void .cctor(){} // RVA: 0x7046AC0
    }

    public class TimelineCreateUtilities
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7046B70
        public void SaveAssetIntoObject(){} // RVA: 0x7046EC0
        public void RemoveAssetFromObject(){} // RVA: 0x7047090
        public void CreateAnimationClipForTrack(){} // RVA: 0x70471F0
        public void ValidateParentTrack(){} // RVA: 0x70475D0
    }

    public class TimelineHelpURLAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TimelinePlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7040040
        public void Compile(){} // RVA: 0x7040460
        public void CompileTrackList(){} // RVA: 0x70408D0
        public void CreateTrackOutput(){} // RVA: 0x7040B90
        public void CreateTrackPlayable(){} // RVA: 0x7041540
        public void PrepareFrame(){} // RVA: 0x7041AE0
        public void Evaluate(){} // RVA: 0x7041B30
        public void CacheTrack(){} // RVA: 0x70422F0
        public void ForAOTCompilationOnly(){} // RVA: 0x7042380
        public void AddPlayableOutputCallbacks(){} // RVA: 0x70423E0
        public void AddOutputWeightProcessor(){} // RVA: 0x7042480
        public void AddEvaluateCallback(){} // RVA: 0x7042700
        public void InvokeOutputCallbacks(){} // RVA: 0x7042890
        public void TryGetCallbackList(){} // RVA: 0x7043410
        public void .ctor(){} // RVA: 0x7043600
        public void .cctor(){} // RVA: 0x7043C80
    }

    public class TimelineUndo
    {
        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x2DD320
        public void PushDestroyUndo(){} // RVA: 0x7047A40
        public void PushUndo(){} // RVA: 0x2DD310 | overloaded x2
        public void RegisterCreatedObjectUndo(){} // RVA: 0x2DD310
        public void UndoName(){} // RVA: 0x7047B30
    }

    public class TrackAsset
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
        public void OnBeforeTrackSerialize(){} // RVA: 0x2DD310
        public void OnAfterTrackDeserialize(){} // RVA: 0x2DD310
        public void OnUpgradeFromVersion(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7024620
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7024920
        public void UpgradeToLatestVersion(){} // RVA: 0x2DD310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7024C30
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7024D90
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7024EF0
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7025050
        public void get_start(){} // RVA: 0x70251B0
        public void get_end(){} // RVA: 0x7025250
        public void get_duration(){} // RVA: 0x70252F0
        public void get_muted(){} // RVA: 0xC36000
        public void set_muted(){} // RVA: 0x190AB20
        public void get_mutedInHierarchy(){} // RVA: 0x70253A0
        public void get_timelineAsset(){} // RVA: 0x7025650
        public void get_parent(){} // RVA: 0x35A740
        public void set_parent(){} // RVA: 0x305200
        public void GetClips(){} // RVA: 0x7025930
        public void get_clips(){} // RVA: 0x7025940
        public void get_blendsValid(){} // RVA: 0x5AAEFD0
        public void set_blendsValid(){} // RVA: 0x5AAEFE0
        public void get_isEmpty(){} // RVA: 0x7025AA0
        public void get_hasClips(){} // RVA: 0x7025B50
        public void get_hasCurves(){} // RVA: 0x7025BA0
        public void get_isSubTrack(){} // RVA: 0x7025CD0
        public void get_outputs(){} // RVA: 0x7025E50
        public void GetChildTracks(){} // RVA: 0x7025F00
        public void get_customPlayableTypename(){} // RVA: 0x6374D0
        public void set_customPlayableTypename(){} // RVA: 0x30B890
        public void get_curves(){} // RVA: 0x4976A0
        public void set_curves(){} // RVA: 0x49B830
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7025F20
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x1A3F520
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7025F60
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x1A3F520
        public void get_subTracksObjects(){} // RVA: 0x358730
        public void get_locked(){} // RVA: 0x6E8A80
        public void set_locked(){} // RVA: 0x6E8B80
        public void get_lockedInHierarchy(){} // RVA: 0x7025F70
        public void get_supportsNotifications(){} // RVA: 0x7026220
        public void __internalAwake(){} // RVA: 0x70262B0
        public void CreateCurves(){} // RVA: 0x7026470
        public void CreateTrackMixer(){} // RVA: 0x70265D0
        public void CreatePlayable(){} // RVA: 0x702BB40 | overloaded x2
        public void CreateDefaultClip(){} // RVA: 0x70267A0
        public void CreateClip(){} // RVA: 0x7026D50 | overloaded x2
        public void DeleteClip(){} // RVA: 0x7026AF0
        public void CreateMarker(){} // RVA: 0x283FA0 | overloaded x2
        public void DeleteMarker(){} // RVA: 0x7026CB0
        public void GetMarkers(){} // RVA: 0x7026CC0
        public void GetMarkerCount(){} // RVA: 0x7026CF0
        public void GetMarker(){} // RVA: 0x7026D40
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7026E90
        public void CreateClipOfType(){} // RVA: 0x7026ED0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x70271C0
        public void CreateClipFromAsset(){} // RVA: 0x70274F0
        public void GetMarkersRaw(){} // RVA: 0x31C010
        public void ClearMarkers(){} // RVA: 0x70277B0
        public void AddMarker(){} // RVA: 0x7027820
        public void DeleteMarkerRaw(){} // RVA: 0x7027830
        public void GetTimeRangeHash(){} // RVA: 0x7027870
        public void AddClip(){} // RVA: 0x7027AD0
        public void CreateNotificationsPlayable(){} // RVA: 0x7027C10
        public void CreatePlayableGraph(){} // RVA: 0x7028120
        public void CompileClips(){} // RVA: 0x70284C0
        public void GatherCompilableTracks(){} // RVA: 0x70289B0
        public void GatherNotifications(){} // RVA: 0x7028C90
        public void CreateMixerPlayableGraph(){} // RVA: 0x7028FA0
        public void ConfigureTrackAnimation(){} // RVA: 0x7029900
        public void SortClips(){} // RVA: 0x7029A60
        public void ClearClipsInternal(){} // RVA: 0x7029CE0
        public void ClearSubTracksInternal(){} // RVA: 0x7029E00
        public void OnClipMove(){} // RVA: 0x7029ED0
        public void CreateNewClipContainerInternal(){} // RVA: 0x7029F30
        public void AddChild(){} // RVA: 0x702A360
        public void MoveLastTrackBefore(){} // RVA: 0x702A4B0
        public void RemoveSubTrack(){} // RVA: 0x702A840
        public void RemoveClip(){} // RVA: 0x702A920
        public void GetEvaluationTime(){} // RVA: 0x702A9F0
        public void GetSequenceTime(){} // RVA: 0x702AC40
        public void GatherProperties(){} // RVA: 0x702AC60
        public void GetGameObjectBinding(){} // RVA: 0x702B320
        public void ValidateClipType(){} // RVA: 0x702B610
        public void OnCreateClip(){} // RVA: 0x2DD310
        public void UpdateDuration(){} // RVA: 0x702B920
        public void CalculateItemsHash(){} // RVA: 0x702BA90
        public void Invalidate(){} // RVA: 0x702BEE0
        public void GetNotificationDuration(){} // RVA: 0x702C010
        public void CanCompileClips(){} // RVA: 0x702C210
        public void CanCreateTrackMixer(){} // RVA: 0x5EBC7C0
        public void IsCompilable(){} // RVA: 0x702C270
        public void UpdateChildTrackCache(){} // RVA: 0x702C570
        public void Hash(){} // RVA: 0x702C8B0
        public void GetClipsHash(){} // RVA: 0x702C930
        public void GetAnimationClipHash(){} // RVA: 0x702CBD0
        public void HasNotifications(){} // RVA: 0x702CDC0
        public void CanCompileNotifications(){} // RVA: 0x702CDF0
        public void CanCreateMixerRecursive(){} // RVA: 0x702CE30
        public void .ctor(){} // RVA: 0x702CFD0
        public void .cctor(){} // RVA: 0x702D1B0
    }

    public class TrackAssetExtensions
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7039780
        public void SetGroup(){} // RVA: 0x70398B0
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x703A040
    }

    public class TrackBindingTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50 | overloaded x2
    }

    public class TrackClipTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class TrackColorAttribute
    {
        public UnityEngine.Color m_Color; // 0x10

        // ── Methods ──
        public void get_color(){} // RVA: 0x196ABE0
        public void .ctor(){} // RVA: 0x702DD70
    }

    public class TrackMediaType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class WeightUtility
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x704A7D0
    }

}