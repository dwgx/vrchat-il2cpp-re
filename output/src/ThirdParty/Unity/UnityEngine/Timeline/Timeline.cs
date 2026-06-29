// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 765

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        public object gameObject;
        public object postPlayback;
        public object m_InitialState;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA2E40
        public void OnBehaviourPlay(){} // RVA: 0x7AA30C0
        public void OnBehaviourPause(){} // RVA: 0x7AA31B0
        public void ProcessFrame(){} // RVA: 0x7AA32B0
        public void OnGraphStart(){} // RVA: 0x7AA33A0
        public void OnPlayableDestroy(){} // RVA: 0x7AA34A0
        public void .ctor(){} // RVA: 0x7825FC0
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        public object m_PostPlaybackState;
        public object m_BoundGameObjectInitialStateIsActive;
        public object m_BoundGameObject;

        // ── Methods ──
        public void Create(){} // RVA: 0x7A7C8E0
        public void get_postPlaybackState(){} // RVA: 0xB8F8F0
        public void set_postPlaybackState(){} // RVA: 0xB460A0
        public void OnPlayableDestroy(){} // RVA: 0x7A7C980
        public void ProcessFrame(){} // RVA: 0x7A7CAB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0xDAC980
        public void CreatePlayable(){} // RVA: 0x7A7CDD0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class ActivationTrack : TrackAsset
    {
        public object m_PostPlaybackState;
        public object m_ActivationMixer;

        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7A7CEF0
        public void get_postPlaybackState(){} // RVA: 0x262A8F0
        public void set_postPlaybackState(){} // RVA: 0x7A7CF80
        public void CreateTrackMixer(){} // RVA: 0x7A7CFA0
        public void UpdateTrackMode(){} // RVA: 0x7A7D1F0
        public void GatherProperties(){} // RVA: 0x7A7D210
        public void OnCreateClip(){} // RVA: 0x7A7D330
        public void .ctor(){} // RVA: 0x7A7D3C0
    }

    public class AnimationOutputWeightProcessor : Object
    {
        public object m_Output;
        public object m_MotionXPlayable;
        public object m_Mixers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7D420
        public void FindMixers(){} // RVA: 0x7A7D810
        public void Evaluate(){} // RVA: 0x7A7DC50
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        public object m_Clip;
        public object m_Position;
        public object m_EulerAngles;
        public object m_UseTrackMatchFields;
        public object m_MatchTargetFields;
        public object m_RemoveStartOffset;
        public object m_ApplyFootIK;
        public object m_Loop;
        public object _appliedOffsetMode;
        public object k_LatestVersion;
        public object m_Version;
        public object m_Rotation;

        // ── Methods ──
        public void get_position(){} // RVA: 0xBA9C00
        public void set_position(){} // RVA: 0xBA9C20
        public void get_rotation(){} // RVA: 0x7A7DED0
        public void set_rotation(){} // RVA: 0x7A7DF80
        public void get_eulerAngles(){} // RVA: 0xBA9C30
        public void set_eulerAngles(){} // RVA: 0xBA9C50
        public void get_useTrackMatchFields(){} // RVA: 0xD16660
        public void set_useTrackMatchFields(){} // RVA: 0xD14C10
        public void get_matchTargetFields(){} // RVA: 0x114DAD0
        public void set_matchTargetFields(){} // RVA: 0x25671C0
        public void get_removeStartOffset(){} // RVA: 0xC02470
        public void set_removeStartOffset(){} // RVA: 0xC02480
        public void get_applyFootIK(){} // RVA: 0xEEA010
        public void set_applyFootIK(){} // RVA: 0xEEA000
        public void get_loop(){} // RVA: 0xBE5870
        public void set_loop(){} // RVA: 0xBE5880
        public void get_hasRootTransforms(){} // RVA: 0x7A7DFB0
        public void get_appliedOffsetMode(){} // RVA: 0xBE5890
        public void set_appliedOffsetMode(){} // RVA: 0xBE58A0
        public void get_clip(){} // RVA: 0xB465B0
        public void set_clip(){} // RVA: 0x7A7E0C0
        public void get_duration(){} // RVA: 0x7A7E210
        public void get_outputs(){} // RVA: 0x7A7E2C0
        public void CreatePlayable(){} // RVA: 0x7A7E4A0
        public void ShouldApplyOffset(){} // RVA: 0x7A7EC20
        public void ShouldApplyScaleRemove(){} // RVA: 0x7A7EC90
        public void get_clipCaps(){} // RVA: 0x7A7ECB0
        public void ResetOffsets(){} // RVA: 0x7A7EE70
        public void GatherProperties(){} // RVA: 0x7A7EF00
        public void HasRootTransforms(){} // RVA: 0x7A7EFD0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A7F170
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A7F1D0
        public void OnUpgradeFromVersion(){} // RVA: 0x7A7F260
        public void .ctor(){} // RVA: 0x7A7F2A0
        public void .cctor(){} // RVA: 0x7A7F3C0
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        public object m_Output;
        public object m_Graph;
        public object m_PreviewComponents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F6B0
        public void Evaluate(){} // RVA: 0x7A7F770
        public void FetchPreviewComponents(){} // RVA: 0x7A7F9F0
    }

    public class AnimationTrack : TrackAsset
    {
        public object k_DefaultInfiniteClipName;
        public object k_DefaultRecordableClipName;
        public object m_InfiniteClipPreExtrapolation;
        public object m_InfiniteClipPostExtrapolation;
        public object m_InfiniteClipOffsetPosition;
        public object m_InfiniteClipOffsetEulerAngles;
        public object m_InfiniteClipTimeOffset;
        public object m_InfiniteClipRemoveOffset;
        public object m_InfiniteClipApplyFootIK;
        public object mInfiniteClipLoop;
        public object m_MatchTargetFields;
        public object m_Position;
        public object m_EulerAngles;
        public object m_AvatarMask;
        public object m_ApplyAvatarMask;
        public object m_TrackOffset;
        public object m_InfiniteClip;
        public object s_CachedQueue;
        public object m_OpenClipOffsetRotation;
        public object m_Rotation;
        public object m_ApplyOffsets;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7A7FCD0
        public void set_position(){} // RVA: 0x7A7FCF0
        public void get_rotation(){} // RVA: 0x7A7FD10
        public void set_rotation(){} // RVA: 0x7A7FDC0
        public void get_eulerAngles(){} // RVA: 0x7A7FDF0
        public void set_eulerAngles(){} // RVA: 0x7A7FE10
        public void get_applyOffsets(){} // RVA: 0xB43320
        public void set_applyOffsets(){} // RVA: 0xB43310
        public void get_trackOffset(){} // RVA: 0x25585C0
        public void set_trackOffset(){} // RVA: 0x7A7FE30
        public void get_matchTargetFields(){} // RVA: 0x131DCD0
        public void set_matchTargetFields(){} // RVA: 0x7A7FE40
        public void get_infiniteClip(){} // RVA: 0x10B4170
        public void set_infiniteClip(){} // RVA: 0x15B42C0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x1C11610
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x1C10980
        public void get_avatarMask(){} // RVA: 0xBAE5A0
        public void set_avatarMask(){} // RVA: 0xBAE5B0
        public void get_applyAvatarMask(){} // RVA: 0x1AE5AD0
        public void set_applyAvatarMask(){} // RVA: 0x1AE3600
        public void CanCompileClips(){} // RVA: 0x7A7FEB0
        public void get_outputs(){} // RVA: 0x7A7FFF0
        public void get_inClipMode(){} // RVA: 0x7A800A0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x485F800
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x485F820
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7A800E0
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7A80190
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x485F840
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x485F860
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x1C4B8A0
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x6C2B4F0
        public void get_infiniteClipTimeOffset(){} // RVA: 0x25585E0
        public void set_infiniteClipTimeOffset(){} // RVA: 0x25585D0
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x262A8F0
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x262A940
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x6C8E620
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x6C8E630
        public void get_infiniteClipLoop(){} // RVA: 0x214AA20
        public void set_infiniteClipLoop(){} // RVA: 0x6BA2C20
        public void ResetOffsets(){} // RVA: 0x7A801C0
        public void CreateClip(){} // RVA: 0x7A80260
        public void CreateInfiniteClip(){} // RVA: 0x7A80380
        public void CreateRecordableClip(){} // RVA: 0x7A80560
        public void OnCreateClip(){} // RVA: 0x7A80840
        public void CalculateItemsHash(){} // RVA: 0x7A808B0
        public void UpdateClipOffsets(){} // RVA: 0xB43310
        public void CompileTrackPlayable(){} // RVA: 0x7A809C0
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7A80FE0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7A81080
        public void GetDefaultBlendCount(){} // RVA: 0xDAC980
        public void AttachDefaultBlend(){} // RVA: 0xB43310
        public void AttachOffsetPlayable(){} // RVA: 0x7A81C70
        public void RequiresMotionXPlayable(){} // RVA: 0x7A81E50
        public void UsesAbsoluteMotion(){} // RVA: 0x7A82030
        public void HasController(){} // RVA: 0x7A82040
        public void GetBinding(){} // RVA: 0x7A82290
        public void CreateGroupMixer(){} // RVA: 0x7A82670
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7A82760
        public void ApplyTrackOffset(){} // RVA: 0x7A82CC0
        public void GetEvaluationTime(){} // RVA: 0x7A82F50
        public void GetSequenceTime(){} // RVA: 0x7A83020
        public void AssignAnimationClip(){} // RVA: 0x7A83170
        public void GatherProperties(){} // RVA: 0xB43310
        public void GetAnimationClips(){} // RVA: 0x7A835B0
        public void GetOffsetMode(){} // RVA: 0x7A83BD0
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7A83D00
        public void GetGenericRootNode(){} // RVA: 0x7A84270
        public void AnimatesRootTransform(){} // RVA: 0x7A845A0
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7A84880
        public void get_openClipOffsetPosition(){} // RVA: 0x485F800
        public void set_openClipOffsetPosition(){} // RVA: 0x485F820
        public void get_openClipOffsetRotation(){} // RVA: 0x7A800E0
        public void set_openClipOffsetRotation(){} // RVA: 0x7A84AC0
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x485F840
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x485F860
        public void get_openClipPreExtrapolation(){} // RVA: 0x262A8F0
        public void set_openClipPreExtrapolation(){} // RVA: 0x262A940
        public void get_openClipPostExtrapolation(){} // RVA: 0x6C8E620
        public void set_openClipPostExtrapolation(){} // RVA: 0x6C8E630
        public void OnUpgradeFromVersion(){} // RVA: 0x7A84B00
        public void .ctor(){} // RVA: 0x7A84CF0
        public void .cctor(){} // RVA: 0x7A84F20
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        public object volume;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A96B50
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        public object volume;
        public object stereoPan;
        public object spatialBlend;

        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7A96B60
        public void .ctor(){} // RVA: 0x7A96B50
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        public object m_Clip;
        public object m_Loop;
        public object m_bufferingTime;
        public object m_ClipProperties;

        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0xCBAD90
        public void set_bufferingTime(){} // RVA: 0xCBADA0
        public void get_clip(){} // RVA: 0xB465B0
        public void set_clip(){} // RVA: 0xBA9BA0
        public void get_loop(){} // RVA: 0xC38360
        public void set_loop(){} // RVA: 0xC38370
        public void get_duration(){} // RVA: 0x7A96F50
        public void get_outputs(){} // RVA: 0x7A970C0
        public void CreatePlayable(){} // RVA: 0x7A97170
        public void get_clipCaps(){} // RVA: 0x7A973C0
        public void .ctor(){} // RVA: 0x7A973D0
    }

    public class AudioTrack : TrackAsset
    {
        public object m_TrackProperties;

        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7A976D0
        public void CompileClips(){} // RVA: 0x7A979A0
        public void get_outputs(){} // RVA: 0x7A982E0
        public void OnValidate(){} // RVA: 0x7A98390
        public void .ctor(){} // RVA: 0x7A98430
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        // ── Methods ──
        public void get_duration(){} // RVA: 0x7AA35E0
        public void get_outputs(){} // RVA: 0x7AA3640
        public void OnGraphStart(){} // RVA: 0xB43310
        public void OnGraphStop(){} // RVA: 0xB43310
        public void OnPlayableCreate(){} // RVA: 0xB43310
        public void OnPlayableDestroy(){} // RVA: 0xB43310
        public void OnBehaviourPlay(){} // RVA: 0xB43310
        public void OnBehaviourPause(){} // RVA: 0xB43310
        public void PrepareFrame(){} // RVA: 0xB43310
        public void ProcessFrame(){} // RVA: 0xB43310
        public void CreatePlayable(){} // RVA: 0x7AA36A0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class BlendUtility : Object
    {
        public object kMinOverlapTime;

        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7AAC990
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7AACAD0
        public void UpdateClipIntersection(){} // RVA: 0x7AACF40
        public void .cctor(){} // RVA: 0x7AAD130
    }

    public class ControlPlayableAsset : PlayableAsset
    {
        public object k_MaxRandInt;
        public object k_EmptyDirectorsList;
        public object k_EmptyParticlesList;
        public object s_SubEmitterCollector;
        public object sourceGameObject;
        public object prefabGameObject;
        public object updateParticle;
        public object particleRandomSeed;
        public object updateDirector;
        public object updateITimeControl;
        public object searchHierarchy;
        public object active;
        public object postPlayback;
        public object directorOnClipEnd;
        public object m_ControlDirectorAsset;
        public object m_Duration;
        public object m_SupportLoop;
        public object s_ProcessedDirectors;
        public object s_CreatedPrefabs;
        public object _controllingDirectors;
        public object _controllingParticles;

        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x5C8BB10
        public void set_controllingDirectors(){} // RVA: 0x6A92EB0
        public void get_controllingParticles(){} // RVA: 0xE38E00
        public void set_controllingParticles(){} // RVA: 0xE3F4E0
        public void OnEnable(){} // RVA: 0x7A98750
        public void get_duration(){} // RVA: 0x4E418C0
        public void get_clipCaps(){} // RVA: 0x7A987B0
        public void CreatePlayable(){} // RVA: 0x7A987C0
        public void ConnectPlayablesToMixer(){} // RVA: 0x7A996F0
        public void CreateActivationPlayable(){} // RVA: 0x7A99B00
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7A99CC0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7A9A0C0
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7A9A630
        public void ConnectMixerAndPlayable(){} // RVA: 0x7A9A9A0
        public void GetComponent(){} // RVA: 0x87C540
        public void GetControlableScripts(){} // RVA: 0x7A9AAE0
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7A9AB90
        public void GetControllableParticleSystems(){} // RVA: 0x7A9B660
        public void CacheSubEmitters(){} // RVA: 0x7A9B9D0
        public void GatherProperties(){} // RVA: 0x7A9BC90
        public void PreviewParticles(){} // RVA: 0x7A9C170
        public void PreviewActivation(){} // RVA: 0x7A9C670
        public void PreviewTimeControl(){} // RVA: 0x7A9C900
        public void PreviewDirectors(){} // RVA: 0x7A9CB50
        public void .ctor(){} // RVA: 0x7A9CEE0
        public void .cctor(){} // RVA: 0x7A9CF60
    }

    public class ControlTrack : TrackAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9D6B0
    }

    public class CurveEditUtility : Object
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7A9D700
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class CustomStyleAttribute : Attribute
    {
        public object ussStyle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        public object director;
        public object pauseAction;
        public object m_SyncTime;
        public object m_AssetDuration;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA3860
        public void OnPlayableDestroy(){} // RVA: 0x7AA3AC0
        public void PrepareFrame(){} // RVA: 0x7AA3C50
        public void OnBehaviourPlay(){} // RVA: 0x7AA3F00
        public void OnBehaviourPause(){} // RVA: 0x7AA40C0
        public void ProcessFrame(){} // RVA: 0x7AA4290
        public void SyncSpeed(){} // RVA: 0x7AA4780
        public void SyncStart(){} // RVA: 0x7AA4BE0
        public void SyncStop(){} // RVA: 0x7AA4DD0
        public void DetectDiscontinuity(){} // RVA: 0x7AA4F70
        public void DetectOutOfSync(){} // RVA: 0x7AA5160
        public void UpdateTime(){} // RVA: 0x7AA52C0
        public void .ctor(){} // RVA: 0x7AA5540
    }

    public class DiscreteTime : ValueType
    {
        public object k_Tick;
        public object kMaxTime;
        public object m_DiscreteTime;

        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7A9D800
        public void .ctor(){} // RVA: 0x946EB0
        public void OneTickBefore(){} // RVA: 0x946F30
        public void OneTickAfter(){} // RVA: 0x946F40
        public void GetTick(){} // RVA: 0x77900
        public void FromTicks(){} // RVA: 0x2303260
        public void CompareTo(){} // RVA: 0x946F50
        public void Equals(){} // RVA: 0x947000
        public void DoubleToDiscreteTime(){} // RVA: 0x7A9DB60
        public void FloatToDiscreteTime(){} // RVA: 0x7A9DBF0
        public void IntToDiscreteTime(){} // RVA: 0x7A9DC80
        public void ToDouble(){} // RVA: 0x7A9DCE0
        public void ToFloat(){} // RVA: 0x7A9DD00
        public void op_Explicit(){} // RVA: 0x2303260
        public void op_Implicit(){} // RVA: 0x7A9DF10
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void op_Inequality(){} // RVA: 0x7A9DFA0
        public void op_GreaterThan(){} // RVA: 0x6932420
        public void op_LessThan(){} // RVA: 0x6932400
        public void op_LessThanOrEqual(){} // RVA: 0x6932410
        public void op_GreaterThanOrEqual(){} // RVA: 0x6932430
        public void op_Addition(){} // RVA: 0x2AFB490
        public void op_Subtraction(){} // RVA: 0x7A9E000
        public void ToString(){} // RVA: 0x9470A0
        public void GetHashCode(){} // RVA: 0x947140
        public void Min(){} // RVA: 0x7A9E0C0
        public void Max(){} // RVA: 0x7A9E120
        public void SnapToNearestTick(){} // RVA: 0x7A9E1F0
        public void GetNearestTick(){} // RVA: 0x7A9E2A0
        public void .cctor(){} // RVA: 0x7A9E300
    }

    public class Extrapolation : Object
    {
        public object kMinExtrapolationTime;

        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7AAD3D0
        public void SortClipsByStartTime(){} // RVA: 0x7AAD8D0
        public void .cctor(){} // RVA: 0x7AADBE0
    }

    public class FrameRateFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class GroupTrack : TrackAsset
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0xB43320
        public void get_outputs(){} // RVA: 0x7AA2D90
        public void .ctor(){} // RVA: 0x7AA2DF0
    }

    public class HashUtility : Object
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7AADF60
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ICurvesOwner
    {
        // ── Methods ──
        public void get_curves(){} // RVA: 0x87C0A0
        public void get_hasCurves(){} // RVA: 0x87D280
        public void get_duration(){} // RVA: 0x8820E0
        public void CreateCurves(){} // RVA: 0x894320
        public void get_defaultCurvesName(){} // RVA: 0x87C0A0
        public void get_asset(){} // RVA: 0x87C0A0
        public void get_assetOwner(){} // RVA: 0x87C0A0
        public void get_targetTrack(){} // RVA: 0x87C0A0
    }

    public class IInterval
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x87C0A0
        public void get_intervalEnd(){} // RVA: 0x87C0A0
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){} // RVA: 0x88BC90
    }

    public class IMarker
    {
        // ── Methods ──
        public void get_time(){} // RVA: 0x8820E0
        public void set_time(){} // RVA: 0x895980
        public void get_parent(){} // RVA: 0x87C0A0
        public void Initialize(){} // RVA: 0x894320
    }

    public class INotificationOptionProvider
    {
        // ── Methods ──
        public void get_flags(){} // RVA: 0x87C100
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x894320
        public void PopActiveGameObject(){} // RVA: 0x894290
        public void AddFromClip(){} // RVA: 0x8943B0
        public void AddFromClips(){} // RVA: 0x8943B0
        public void AddFromName(){} // RVA: 0x8943B0
        public void AddFromComponent(){} // RVA: 0x8943B0
        public void AddObjectProperties(){} // RVA: 0x8943B0
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x8943B0
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x895980
        public void OnControlTimeStart(){} // RVA: 0x894290
        public void OnControlTimeStop(){} // RVA: 0x894290
    }

    public class ITimelineClipAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x87C130
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x894290
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        public object m_Playable;
        public object kIntervalEnd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x125D9D0
        public void get_intervalStart(){} // RVA: 0xDAC980
        public void get_intervalEnd(){} // RVA: 0x7A9E350
        public void set_enable(){} // RVA: 0x7A9E3B0
        public void EvaluateAt(){} // RVA: 0x7A9E430
        public void DisableAt(){} // RVA: 0x7A9E490
        public void .cctor(){} // RVA: 0x7A9E500
    }

    public class IntervalTree`1 : Object
    {
        public object kMinNodeSize;
        public object kInvalidNode;
        public object kCenterUnknown;
        public object m_Entries;
        public object m_Nodes;
        public object _dirty;

        // ── Methods ──
        public void get_dirty(){} // RVA: 0x87D280
        public void set_dirty(){} // RVA: 0x894750
        public void Add(){} // RVA: 0xA94080
        public void IntersectsWith(){} // RVA: 0x8947D0
        public void IntersectsWithRange(){} // RVA: 0xA94080
        public void UpdateIntervals(){} // RVA: 0x894290
        public void Query(){} // RVA: 0xA94080
        public void QueryRange(){} // RVA: 0xA94080
        public void Rebuild(){} // RVA: 0x8830B0
        public void Clear(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class Marker : ScriptableObject
    {
        public object m_Time;
        public object _parent;

        // ── Methods ──
        public void get_parent(){} // RVA: 0xB700F0
        public void set_parent(){} // RVA: 0xB70100
        public void get_time(){} // RVA: 0x22344D0
        public void set_time(){} // RVA: 0x7A9F700
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7A9F7A0
        public void OnInitialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class MarkerList : ValueType
    {
        public object m_Objects;
        public object m_Cache;
        public object m_CacheDirty;
        public object m_HasNotifications;

        // ── Methods ──
        public void get_markers(){} // RVA: 0x947210
        public void .ctor(){} // RVA: 0x947230
        public void Add(){} // RVA: 0x947240
        public void Remove(){} // RVA: 0x947260
        public void Clear(){} // RVA: 0x947270
        public void Contains(){} // RVA: 0x947280
        public void GetMarkers(){} // RVA: 0x947210
        public void get_Count(){} // RVA: 0x9472E0
        public void get_Item(){} // RVA: 0x947330
        public void GetRawMarkerList(){} // RVA: 0x77900
        public void CreateMarker(){} // RVA: 0x947340
        public void HasNotifications(){} // RVA: 0x947350
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x3FC0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x947370
        public void BuildCache(){} // RVA: 0x947380
    }

    public class MarkerTrack : TrackAsset
    {
        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7AA0690
        public void .ctor(){} // RVA: 0x7AA0980
    }

    public class MatchTargetFieldConstants : Object
    {
        public object All;
        public object None;
        public object Position;
        public object Rotation;

        // ── Methods ──
        public void HasAny(){} // RVA: 0x7A7FBD0
        public void Toggle(){} // RVA: 0x7A7FC40
        public void .cctor(){} // RVA: 0x7A7FC50
    }

    public class MenuCategoryAttribute : Attribute
    {
        public object category;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA8900
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NotificationUtilities : Object
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7AAE060
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7AAE7A0
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        public object kUnsetTime;
        public object m_LastPlayableTime;
        public object m_LastParticleTime;
        public object m_RandomSeed;
        public object _particleSystem;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA5550
        public void get_particleSystem(){} // RVA: 0xB700F0
        public void set_particleSystem(){} // RVA: 0xB70100
        public void Initialize(){} // RVA: 0x7AA5820
        public void SetRandomSeed(){} // RVA: 0x7AA58E0
        public void PrepareFrame(){} // RVA: 0x7AA5BA0
        public void OnBehaviourPlay(){} // RVA: 0x7AA5D60
        public void OnBehaviourPause(){} // RVA: 0x7AA5D60
        public void Simulate(){} // RVA: 0x7AA5D70
        public void .ctor(){} // RVA: 0x7AA5F80
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7AA86C0
        public void .ctor(){} // RVA: 0x7AA8830
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        public object m_Instance;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA5FA0
        public void get_prefabInstance(){} // RVA: 0xB5DBF0
        public void Initialize(){} // RVA: 0x7AA61E0
        public void OnPlayableDestroy(){} // RVA: 0x7AA65D0
        public void OnBehaviourPlay(){} // RVA: 0x7AA67D0
        public void OnBehaviourPause(){} // RVA: 0x7AA68C0
        public void SetHideFlagsRecursive(){} // RVA: 0x7AA69C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeClip : RuntimeClipBase
    {
        public object m_Clip;
        public object m_Playable;
        public object m_ParentMixer;

        // ── Methods ──
        public void get_start(){} // RVA: 0x7A9E5F0
        public void get_duration(){} // RVA: 0x7A9E620
        public void .ctor(){} // RVA: 0x7A9E640
        public void Create(){} // RVA: 0x7A9E640
        public void get_clip(){} // RVA: 0xB465B0
        public void get_mixer(){} // RVA: 0x16CD820
        public void get_playable(){} // RVA: 0x16CD810
        public void set_enable(){} // RVA: 0x7A9E710
        public void SetTime(){} // RVA: 0x7A9E870
        public void SetDuration(){} // RVA: 0x7A9E8D0
        public void EvaluateAt(){} // RVA: 0x7A9E930
        public void DisableAt(){} // RVA: 0x7A9EC80
    }

    public class RuntimeClipBase : RuntimeElement
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x8820E0
        public void get_duration(){} // RVA: 0x8820E0
        public void get_intervalStart(){} // RVA: 0x7A9EE80
        public void get_intervalEnd(){} // RVA: 0x7A9EF30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeElement : Object
    {
        public object _intervalBit;

        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x87C0A0
        public void get_intervalEnd(){} // RVA: 0x87C0A0
        public void get_intervalBit(){} // RVA: 0xB8F8F0
        public void set_intervalBit(){} // RVA: 0xB460A0
        public void set_enable(){} // RVA: 0x894750
        public void EvaluateAt(){} // RVA: 0x895A90
        public void DisableAt(){} // RVA: 0x895A40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        public object m_Clip;
        public object m_Playable;
        public object m_ParentMixer;
        public object m_StartDelay;
        public object m_FinishTail;
        public object m_Started;

        // ── Methods ──
        public void get_start(){} // RVA: 0x7A9F000
        public void get_duration(){} // RVA: 0x7A9F0B0
        public void SetTime(){} // RVA: 0x7A9F100
        public void get_clip(){} // RVA: 0xB465B0
        public void get_mixer(){} // RVA: 0x16CD820
        public void get_playable(){} // RVA: 0x16CD810
        public void .ctor(){} // RVA: 0x7A9F160
        public void Create(){} // RVA: 0x7A9F160
        public void set_enable(){} // RVA: 0x7A9F240
        public void EvaluateAt(){} // RVA: 0x7A9F360
        public void DisableAt(){} // RVA: 0x7A9F6E0
    }

    public class SignalAsset : ScriptableObject
    {
        public object OnEnableCallback;

        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7AA09D0
        public void remove_OnEnableCallback(){} // RVA: 0x7AA0B00
        public void OnEnable(){} // RVA: 0x7AA0C30
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SignalAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SignalEmitter : Marker
    {
        public object m_Retroactive;
        public object m_EmitOnce;
        public object m_Asset;

        // ── Methods ──
        public void get_retroactive(){} // RVA: 0xF73960
        public void set_retroactive(){} // RVA: 0xF73A60
        public void get_emitOnce(){} // RVA: 0x14F7430
        public void set_emitOnce(){} // RVA: 0x21CBB70
        public void get_asset(){} // RVA: 0xD33E60
        public void set_asset(){} // RVA: 0xB708C0
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7AA0C90
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7AA0DA0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SignalReceiver : MonoBehaviour
    {
        public object m_Events;

        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7AA0DD0
        public void AddReaction(){} // RVA: 0x7AA0FD0
        public void AddEmptyReaction(){} // RVA: 0x7AA1190
        public void Remove(){} // RVA: 0x7AA1200
        public void GetRegisteredSignals(){} // RVA: 0x1853470
        public void GetReaction(){} // RVA: 0x7AA1380
        public void Count(){} // RVA: 0x7AA13C0
        public void ChangeSignalAtIndex(){} // RVA: 0x7AA1410
        public void RemoveAtIndex(){} // RVA: 0x7AA18D0
        public void ChangeReactionAtIndex(){} // RVA: 0x7AA19E0
        public void GetReactionAtIndex(){} // RVA: 0x7AA1AD0
        public void GetSignalAssetAtIndex(){} // RVA: 0x7AA1BB0
        public void OnEnable(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x7AA1C90
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA0980
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        public object childType;
        public object levels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        public object m_timeControl;
        public object m_started;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA6D10
        public void Initialize(){} // RVA: 0xB44D60
        public void PrepareFrame(){} // RVA: 0x7AA6EE0
        public void OnBehaviourPlay(){} // RVA: 0x7AA6F60
        public void OnBehaviourPause(){} // RVA: 0x7AA6FC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TimeFieldAttribute : PropertyAttribute
    {
        public object _useEditMode;

        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x7AA88F0
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public object m_Notifications;
        public object m_PreviousTime;
        public object m_NeedSortNotifications;
        public object m_TimeSource;

        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x19F35A0
        public void Create(){} // RVA: 0x7AA7020
        public void AddNotification(){} // RVA: 0x7AA71F0
        public void OnGraphStart(){} // RVA: 0x7AA72F0
        public void OnBehaviourPause(){} // RVA: 0x7AA7510
        public void PrepareFrame(){} // RVA: 0x7AA77C0
        public void SortNotifications(){} // RVA: 0x7AA7BC0
        public void CanRestoreNotification(){} // RVA: 0x7AA7DE0
        public void TriggerNotificationsInRange(){} // RVA: 0x7AA7E20
        public void SyncDurationWithExternalSource(){} // RVA: 0x7AA80E0
        public void Trigger_internal(){} // RVA: 0x7AA8340
        public void Restore_internal(){} // RVA: 0xF48510
        public void .ctor(){} // RVA: 0x7AA84E0
    }

    public class TimeUtility : Object
    {
        public object kTimeEpsilon;
        public object kFrameRateEpsilon;
        public object k_MaxTimelineDurationInSeconds;
        public object kFrameRateRounding;

        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7AB04E0
        public void ToFrames(){} // RVA: 0x7AB05A0
        public void ToExactFrames(){} // RVA: 0x7AB0710
        public void FromFrames(){} // RVA: 0x7AB07F0
        public void OnFrameBoundary(){} // RVA: 0x7AB0D00
        public void GetEpsilon(){} // RVA: 0x7AB0970
        public void PreviousFrame(){} // RVA: 0x7AB0A60
        public void NextFrame(){} // RVA: 0x7AB0B00
        public void PreviousFrameTime(){} // RVA: 0x7AB0B70
        public void NextFrameTime(){} // RVA: 0x7AB0C50
        public void RoundToFrame(){} // RVA: 0x7AB0DD0
        public void TimeAsFrames(){} // RVA: 0x7AB0ED0
        public void TimeAsTimeCode(){} // RVA: 0x7AB1060
        public void ParseTimeCode(){} // RVA: 0x7AB1750
        public void ParseTimeSeconds(){} // RVA: 0x7AB1DB0
        public void GetAnimationClipLength(){} // RVA: 0x7AB2320
        public void RemoveChar(){} // RVA: 0x7AB2470
        public void GetClosestFrameRate(){} // RVA: 0x7AB2560
        public void ToFrameRate(){} // RVA: 0x7AB27F0
        public void ToStandardFrameRate(){} // RVA: 0x7AB29E0
        public void .cctor(){} // RVA: 0x7AB2E10
    }

    public class TimelineAsset : PlayableAsset
    {
        public object k_LatestVersion;
        public object m_Version;
        public object m_Tracks;
        public object m_FixedDuration;
        public object m_CacheOutputTracks;
        public object m_CacheRootTracks;
        public object m_CacheFlattenedTracks;
        public object m_EditorSettings;
        public object m_DurationMode;
        public object m_MarkerTrack;

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0xB43310
        public void get_editorSettings(){} // RVA: 0xBBF8F0
        public void get_duration(){} // RVA: 0x7A88460
        public void get_fixedDuration(){} // RVA: 0x7A88500
        public void set_fixedDuration(){} // RVA: 0x7A88620
        public void get_durationMode(){} // RVA: 0xE32C80
        public void set_durationMode(){} // RVA: 0xEEA060
        public void get_outputs(){} // RVA: 0x7A886C0
        public void get_clipCaps(){} // RVA: 0x7A88770
        public void get_outputTrackCount(){} // RVA: 0x7A88940
        public void get_rootTrackCount(){} // RVA: 0x7A88970
        public void OnValidate(){} // RVA: 0x7A889C0
        public void GetRootTrack(){} // RVA: 0x7A88A00
        public void GetRootTracks(){} // RVA: 0x7A88A80
        public void GetOutputTrack(){} // RVA: 0x7A88AA0
        public void GetOutputTracks(){} // RVA: 0x7A88AF0
        public void GetValidFrameRate(){} // RVA: 0x7A88B10
        public void UpdateRootTrackCache(){} // RVA: 0x7A88C00
        public void UpdateOutputTrackCache(){} // RVA: 0x7A890B0
        public void get_flattenedTracks(){} // RVA: 0x7A89350
        public void get_markerTrack(){} // RVA: 0xC0FFC0
        public void get_trackObjects(){} // RVA: 0xB700F0
        public void AddTrackInternal(){} // RVA: 0x7A89570
        public void RemoveTrack(){} // RVA: 0x7A89620
        public void CreatePlayable(){} // RVA: 0x7A897A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x1320080
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A89A70
        public void __internalAwake(){} // RVA: 0x7A89A80
        public void GatherProperties(){} // RVA: 0x7A89D00
        public void CreateMarkerTrack(){} // RVA: 0x7A89F10
        public void RemoveMarkerTrack(){} // RVA: 0x7A8A100
        public void Invalidate(){} // RVA: 0x7A8A240
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7A8A340
        public void CalculateItemsDuration(){} // RVA: 0x7A8A3F0
        public void AddSubTracksRecursive(){} // RVA: 0x7A8A680
        public void CreateTrack(){} // RVA: 0xA94080
        public void DeleteClip(){} // RVA: 0x7A8AEB0
        public void DeleteTrack(){} // RVA: 0x7A8B290
        public void MoveLastTrackBefore(){} // RVA: 0x7A8B850
        public void AllocateTrack(){} // RVA: 0x7A8BBF0
        public void DeleteRecordedAnimation(){} // RVA: 0x7A8C340
        public void .ctor(){} // RVA: 0x7A8C5E0
    }

    public class TimelineClip : Object
    {
        public object k_LatestVersion;
        public object m_Version;
        public object kDefaultClipCaps;
        public object kDefaultClipDurationInSeconds;
        public object kTimeScaleMin;
        public object kTimeScaleMax;
        public object kDefaultCurvesName;
        public object kMinDuration;
        public object kMaxTimeValue;
        public object m_Start;
        public object m_ClipIn;
        public object m_Asset;
        public object m_Duration;
        public object m_TimeScale;
        public object m_ParentTrack;
        public object m_EaseInDuration;
        public object m_EaseOutDuration;
        public object m_BlendInDuration;
        public object m_BlendOutDuration;
        public object m_MixInCurve;
        public object m_MixOutCurve;
        public object m_BlendInCurveMode;
        public object m_BlendOutCurveMode;
        public object m_ExposedParameterNames;
        public object m_AnimationCurves;
        public object m_Recordable;
        public object m_PostExtrapolationMode;
        public object m_PreExtrapolationMode;
        public object m_PostExtrapolationTime;
        public object m_PreExtrapolationTime;
        public object m_DisplayName;

        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7A85380
        public void .ctor(){} // RVA: 0x7A853B0
        public void get_hasPreExtrapolation(){} // RVA: 0x7A853E0
        public void get_hasPostExtrapolation(){} // RVA: 0x7A85400
        public void get_timeScale(){} // RVA: 0x7A85420
        public void set_timeScale(){} // RVA: 0x7A85530
        public void get_start(){} // RVA: 0x22344D0
        public void set_start(){} // RVA: 0x7A85650
        public void get_duration(){} // RVA: 0x7931490
        public void set_duration(){} // RVA: 0x7A85860
        public void get_end(){} // RVA: 0x7A85A20
        public void get_clipIn(){} // RVA: 0x7A85A30
        public void set_clipIn(){} // RVA: 0x7A85A60
        public void get_displayName(){} // RVA: 0xBAE340
        public void set_displayName(){} // RVA: 0xBAE350
        public void get_clipAssetDuration(){} // RVA: 0x7A85B80
        public void get_curves(){} // RVA: 0xB813B0
        public void set_curves(){} // RVA: 0xD5CBB0
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7A85BF0
        public void get_hasCurves(){} // RVA: 0x7A85C50
        public void get_asset(){} // RVA: 0xB70160
        public void set_asset(){} // RVA: 0xB44DC0
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0xBC1B30
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0xBC1B30
        public void get_underlyingAsset(){} // RVA: 0xDAC980
        public void set_underlyingAsset(){} // RVA: 0xB43310
        public void get_parentTrack(){} // RVA: 0xBC1B30
        public void set_parentTrack(){} // RVA: 0x7A85D50
        public void GetParentTrack(){} // RVA: 0xBC1B30
        public void SetParentTrack_Internal(){} // RVA: 0x7A85D60
        public void get_easeInDuration(){} // RVA: 0x7A86020
        public void set_easeInDuration(){} // RVA: 0x7A86120
        public void get_easeOutDuration(){} // RVA: 0x7A86260
        public void set_easeOutDuration(){} // RVA: 0x7A86360
        public void get_eastOutTime(){} // RVA: 0x7A864A0
        public void get_easeOutTime(){} // RVA: 0x7A864A0
        public void get_blendInDuration(){} // RVA: 0x7A864E0
        public void set_blendInDuration(){} // RVA: 0x7A86510
        public void get_blendOutDuration(){} // RVA: 0x7A865B0
        public void set_blendOutDuration(){} // RVA: 0x7A865E0
        public void get_blendInCurveMode(){} // RVA: 0x23ADD10
        public void set_blendInCurveMode(){} // RVA: 0x23B2A80
        public void get_blendOutCurveMode(){} // RVA: 0x23A4270
        public void set_blendOutCurveMode(){} // RVA: 0x6CB6340
        public void get_hasBlendIn(){} // RVA: 0x7A86680
        public void get_hasBlendOut(){} // RVA: 0x7A866C0
        public void get_mixInCurve(){} // RVA: 0x7A86700
        public void set_mixInCurve(){} // RVA: 0xBBFFA0
        public void get_mixInPercentage(){} // RVA: 0x7A86830
        public void get_mixInDuration(){} // RVA: 0x7A86850
        public void get_mixOutCurve(){} // RVA: 0x7A86970
        public void set_mixOutCurve(){} // RVA: 0xC10060
        public void get_mixOutTime(){} // RVA: 0x7A86AA0
        public void get_mixOutDuration(){} // RVA: 0x7A86B10
        public void get_mixOutPercentage(){} // RVA: 0x7A86B70
        public void get_recordable(){} // RVA: 0x1C4D9A0
        public void set_recordable(){} // RVA: 0x1C4DB10
        public void get_exposedParameters(){} // RVA: 0x7A86BD0
        public void get_clipCaps(){} // RVA: 0x7A86CA0
        public void Hash(){} // RVA: 0x7A86D40
        public void EvaluateMixOut(){} // RVA: 0x7A86E70
        public void EvaluateMixIn(){} // RVA: 0x7A87070
        public void GetDefaultMixInCurve(){} // RVA: 0x7A871C0
        public void GetDefaultMixOutCurve(){} // RVA: 0x7A871F0
        public void ToLocalTime(){} // RVA: 0x7A87220
        public void ToLocalTimeUnbound(){} // RVA: 0x7A873E0
        public void FromLocalTimeUnbound(){} // RVA: 0x7A87450
        public void get_animationClip(){} // RVA: 0x7A874B0
        public void SanitizeTimeValue(){} // RVA: 0x7A87680
        public void get_postExtrapolationMode(){} // RVA: 0x7A877E0
        public void set_postExtrapolationMode(){} // RVA: 0x7A87810
        public void get_preExtrapolationMode(){} // RVA: 0x7A87850
        public void set_preExtrapolationMode(){} // RVA: 0x7A87880
        public void SetPostExtrapolationTime(){} // RVA: 0x7A878C0
        public void SetPreExtrapolationTime(){} // RVA: 0x7A878D0
        public void IsExtrapolatedTime(){} // RVA: 0x7A878E0
        public void IsPreExtrapolatedTime(){} // RVA: 0x7A87990
        public void IsPostExtrapolatedTime(){} // RVA: 0x7A879F0
        public void get_extrapolatedStart(){} // RVA: 0x7A87A60
        public void get_extrapolatedDuration(){} // RVA: 0x7A87A80
        public void GetExtrapolatedTime(){} // RVA: 0x7A87B80
        public void CreateCurves(){} // RVA: 0x7A87CC0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x23E2740
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A85380
        public void ToString(){} // RVA: 0x7A87E50
        public void ConformEaseValues(){} // RVA: 0x7A88090
        public void CalculateEasingRatio(){} // RVA: 0x7A881F0
        public void UpdateDirty(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7A882E0
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7A98670
        public void SupportsExtrapolation(){} // RVA: 0x7A98690
        public void SupportsClipIn(){} // RVA: 0x7A986C0
        public void SupportsSpeedMultiplier(){} // RVA: 0x7A986F0
        public void SupportsBlending(){} // RVA: 0x7A98720
        public void HasAll(){} // RVA: 0x2154E40
        public void HasAny(){} // RVA: 0x7467AD0
    }

    public class TimelineClipExtensions : Object
    {
        public object k_UndoSetParentTrackText;

        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7AAE9C0
        public void TryMoveToTrack(){} // RVA: 0x7AAEEF0
        public void MoveToTrack_Impl(){} // RVA: 0x7AAF210
        public void .cctor(){} // RVA: 0x7AAF4B0
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7AAF560
        public void SaveAssetIntoObject(){} // RVA: 0x7AAF8A0
        public void RemoveAssetFromObject(){} // RVA: 0x7AAFA30
        public void CreateAnimationClipForTrack(){} // RVA: 0x7AAFB90
        public void ValidateParentTrack(){} // RVA: 0x7AAFEF0
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TimelinePlayable : PlayableBehaviour
    {
        public object m_IntervalTree;
        public object m_ActiveClips;
        public object m_CurrentListOfActiveClips;
        public object m_ActiveBit;
        public object m_PlayableCache;
        public object muteAudioScrubbing;
        public object m_EvaluateCallbacks;
        public object m_AlwaysEvaluateCallbacks;
        public object m_ForceEvaluateNextEvaluate;
        public object m_InvokedThisFrame;
        public object m_ActiveTracksToEvaluateCache;

        // ── Methods ──
        public void Create(){} // RVA: 0x7AA8980
        public void Compile(){} // RVA: 0x7AA8D70
        public void CompileTrackList(){} // RVA: 0x7AA91E0
        public void CreateTrackOutput(){} // RVA: 0x7AA94B0
        public void CreateTrackPlayable(){} // RVA: 0x7AA9E60
        public void PrepareFrame(){} // RVA: 0x7AAA400
        public void Evaluate(){} // RVA: 0x7AAA450
        public void CacheTrack(){} // RVA: 0x7AAAC10
        public void ForAOTCompilationOnly(){} // RVA: 0x7AAACA0
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7AAAD00
        public void AddOutputWeightProcessor(){} // RVA: 0x7AAADA0
        public void AddEvaluateCallback(){} // RVA: 0x7AAB020
        public void InvokeOutputCallbacks(){} // RVA: 0x7AAB1B0
        public void TryGetCallbackList(){} // RVA: 0x7AABD80
        public void .ctor(){} // RVA: 0x7AABF70
        public void .cctor(){} // RVA: 0x7AAC5F0
    }

    public class TimelineUndo : Object
    {
        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0xB43320
        public void PushDestroyUndo(){} // RVA: 0x7AB0370
        public void PushUndo(){} // RVA: 0xB43310
        public void RegisterCreatedObjectUndo(){} // RVA: 0xB43310
        public void UndoName(){} // RVA: 0x7AB0490
    }

    public class TrackAsset : PlayableAsset
    {
        public object k_LatestVersion;
        public object m_Version;
        public object m_AnimClip;
        public object s_BuildData;
        public object kDefaultCurvesName;
        public object OnClipPlayableCreate;
        public object OnTrackAnimationPlayableCreate;
        public object m_Locked;
        public object m_Muted;
        public object m_CustomPlayableFullTypename;
        public object m_Curves;
        public object m_Parent;
        public object m_Children;
        public object m_ItemsHash;
        public object m_ClipsCache;
        public object m_Start;
        public object m_End;
        public object m_CacheSorted;
        public object m_BlendsValid;
        public object m_SupportsNotifications;
        public object s_EmptyCache;
        public object m_ChildTrackCache;
        public object s_TrackBindingTypeAttributeCache;
        public object m_Clips;
        public object m_Markers;

        // ── Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0xB43310
        public void OnAfterTrackDeserialize(){} // RVA: 0xB43310
        public void OnUpgradeFromVersion(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A8D450
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A8D770
        public void UpgradeToLatestVersion(){} // RVA: 0xB43310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7A8DA90
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7A8DC00
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7A8DD70
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7A8DEE0
        public void get_start(){} // RVA: 0x7A8E050
        public void get_end(){} // RVA: 0x7A8E0F0
        public void get_duration(){} // RVA: 0x7A8E190
        public void get_muted(){} // RVA: 0x14F7430
        public void set_muted(){} // RVA: 0x21CBB70
        public void get_mutedInHierarchy(){} // RVA: 0x7A8E240
        public void get_timelineAsset(){} // RVA: 0x7A8E4F0
        public void get_parent(){} // RVA: 0xBC1B30
        public void set_parent(){} // RVA: 0xB6A8C0
        public void GetClips(){} // RVA: 0x7A8E7D0
        public void get_clips(){} // RVA: 0x7A8E7E0
        public void get_blendsValid(){} // RVA: 0x6529A10
        public void set_blendsValid(){} // RVA: 0x6529A20
        public void get_isEmpty(){} // RVA: 0x7A8E940
        public void get_hasClips(){} // RVA: 0x7A8E9F0
        public void get_hasCurves(){} // RVA: 0x7A8EA40
        public void get_isSubTrack(){} // RVA: 0x7A8EB30
        public void get_outputs(){} // RVA: 0x7A8ECA0
        public void GetChildTracks(){} // RVA: 0x7A8ED50
        public void get_customPlayableTypename(){} // RVA: 0xD33E60
        public void set_customPlayableTypename(){} // RVA: 0xB708C0
        public void get_curves(){} // RVA: 0xD05CA0
        public void set_curves(){} // RVA: 0xD09D70
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7A8ED70
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x2303260
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7A8EDB0
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x2303260
        public void get_subTracksObjects(){} // RVA: 0xBBF8F0
        public void get_locked(){} // RVA: 0xF73960
        public void set_locked(){} // RVA: 0xF73A60
        public void get_lockedInHierarchy(){} // RVA: 0x7A8EDC0
        public void get_supportsNotifications(){} // RVA: 0x7A8F070
        public void __internalAwake(){} // RVA: 0x7A8F100
        public void CreateCurves(){} // RVA: 0x7A8F2C0
        public void CreateTrackMixer(){} // RVA: 0x7A8F420
        public void CreatePlayable(){} // RVA: 0x7A94940
        public void CreateDefaultClip(){} // RVA: 0x7A8F5F0
        public void CreateClip(){} // RVA: 0x7A8FB60
        public void DeleteClip(){} // RVA: 0x7A8F900
        public void CreateMarker(){} // RVA: 0xA94080
        public void DeleteMarker(){} // RVA: 0x7A8FAC0
        public void GetMarkers(){} // RVA: 0x7A8FAD0
        public void GetMarkerCount(){} // RVA: 0x7A8FB00
        public void GetMarker(){} // RVA: 0x7A8FB50
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7A8FCA0
        public void CreateClipOfType(){} // RVA: 0x7A8FCE0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7A8FF90
        public void CreateClipFromAsset(){} // RVA: 0x7A902C0
        public void GetMarkersRaw(){} // RVA: 0xB813B0
        public void ClearMarkers(){} // RVA: 0x7A90580
        public void AddMarker(){} // RVA: 0x7A905F0
        public void DeleteMarkerRaw(){} // RVA: 0x7A90600
        public void GetTimeRangeHash(){} // RVA: 0x7A90640
        public void AddClip(){} // RVA: 0x7A908B0
        public void CreateNotificationsPlayable(){} // RVA: 0x7A909F0
        public void CreatePlayableGraph(){} // RVA: 0x7A90F10
        public void CompileClips(){} // RVA: 0x7A912B0
        public void GatherCompilableTracks(){} // RVA: 0x7A91770
        public void GatherNotifications(){} // RVA: 0x7A91A60
        public void CreateMixerPlayableGraph(){} // RVA: 0x7A91D80
        public void ConfigureTrackAnimation(){} // RVA: 0x7A926A0
        public void SortClips(){} // RVA: 0x7A92800
        public void ClearClipsInternal(){} // RVA: 0x7A92A80
        public void ClearSubTracksInternal(){} // RVA: 0x7A92BA0
        public void OnClipMove(){} // RVA: 0x7A92C70
        public void CreateNewClipContainerInternal(){} // RVA: 0x7A92CD0
        public void AddChild(){} // RVA: 0x7A93120
        public void MoveLastTrackBefore(){} // RVA: 0x7A93270
        public void RemoveSubTrack(){} // RVA: 0x7A93610
        public void RemoveClip(){} // RVA: 0x7A936F0
        public void GetEvaluationTime(){} // RVA: 0x7A937C0
        public void GetSequenceTime(){} // RVA: 0x7A93A40
        public void GatherProperties(){} // RVA: 0x7A93A60
        public void GetGameObjectBinding(){} // RVA: 0x7A94140
        public void ValidateClipType(){} // RVA: 0x7A94400
        public void OnCreateClip(){} // RVA: 0xB43310
        public void UpdateDuration(){} // RVA: 0x7A94720
        public void CalculateItemsHash(){} // RVA: 0x7A94890
        public void Invalidate(){} // RVA: 0x7A94CE0
        public void GetNotificationDuration(){} // RVA: 0x7A94E10
        public void CanCompileClips(){} // RVA: 0x7A95040
        public void CanCreateTrackMixer(){} // RVA: 0x6935490
        public void IsCompilable(){} // RVA: 0x7A950A0
        public void UpdateChildTrackCache(){} // RVA: 0x7A95380
        public void Hash(){} // RVA: 0x7A956E0
        public void GetClipsHash(){} // RVA: 0x7A95760
        public void GetAnimationClipHash(){} // RVA: 0x7A95A10
        public void HasNotifications(){} // RVA: 0x7A95B50
        public void CanCompileNotifications(){} // RVA: 0x7A95B80
        public void CanCreateMixerRecursive(){} // RVA: 0x7A95BC0
        public void .ctor(){} // RVA: 0x7A95D60
        public void .cctor(){} // RVA: 0x7A95F30
    }

    public class TrackAssetExtensions : Object
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7AA2450
        public void SetGroup(){} // RVA: 0x7AA2570
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7AA2D00
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        public object type;
        public object flags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class TrackClipTypeAttribute : Attribute
    {
        public object inspectedType;
        public object allowAutoCreate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class TrackColorAttribute : Attribute
    {
        public object m_Color;

        // ── Methods ──
        public void get_color(){} // RVA: 0x22343B0
        public void .ctor(){} // RVA: 0x7A96B10
    }

    public class TrackMediaType : Attribute
    {
        public object m_MediaType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class WeightUtility : Object
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7AB2FA0
    }

}