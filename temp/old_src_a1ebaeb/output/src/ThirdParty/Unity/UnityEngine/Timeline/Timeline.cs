// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 73
// Methods: 785

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        public object m_InitialState; // 0x337BF110

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1f4aa0
        public void OnBehaviourPlay(){} // RVA: 0x7ffaaf1f4d20
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f4e40
        public void ProcessFrame(){} // RVA: 0x7ffaaf1f4f50
        public void OnGraphStart(){} // RVA: 0x7ffaaf1f5070
        public void OnPlayableDestroy(){} // RVA: 0x7ffaaf1f51a0
        public void .ctor(){} // RVA: 0x7ffaaef823e0
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        public object m_BoundGameObject; // 0x33C0D760
        public object postPlaybackState; // 0x17000001

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1ce170
        public void get_postPlaybackState(){} // RVA: 0x7ffaa897f5c0
        public void set_postPlaybackState(){} // RVA: 0x7ffaa89350c0
        public void OnPlayableDestroy(){} // RVA: 0x7ffaaf1ce210
        public void ProcessFrame(){} // RVA: 0x7ffaaf1ce340
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        // ── Original Methods ──
        public void get_clipCaps(){} // RVA: 0x7ffaa8f22da0
        public void CreatePlayable(){} // RVA: 0x7ffaaf1ce6a0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class ActivationTrack : TrackAsset
    {
        // ── Original Methods ──
        public void CanCompileClips(){} // RVA: 0x7ffaaf1ce7c0
        public void get_postPlaybackState(){} // RVA: 0x7ffaaa2a7de0
        public void set_postPlaybackState(){} // RVA: 0x7ffaaf1ce850
        public void CreateTrackMixer(){} // RVA: 0x7ffaaf1ce870
        public void UpdateTrackMode(){} // RVA: 0x7ffaaf1ceab0
        public void GatherProperties(){} // RVA: 0x7ffaaf1cead0
        public void OnCreateClip(){} // RVA: 0x7ffaaf1cebf0
        public void .ctor(){} // RVA: 0x7ffaaf1cec80
    }

    public class AnimationOutputWeightProcessor : Object
    {
        public object m_Mixers; // 0x339DEE50

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1cece0
        public void FindMixers(){} // RVA: 0x7ffaaf1cf0c0
        public void FindMixers(){} // RVA: 0x7ffaaf1cf0c0
        public void Evaluate(){} // RVA: 0x7ffaaf1cf4d0
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        public object m_EulerAngles; // 0x33391020
        public object m_RemoveStartOffset; // 0x33391020
        public object _appliedOffsetMode; // 0x33391020, was: <appliedOffsetMode>k__BackingF
        public object m_Rotation; // 0x33391020
        public object position; // 0x17000004
        public object rotation; // 0x17000005
        public object eulerAngles; // 0x17000006
        public object useTrackMatchFields; // 0x17000007

        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaa8998ee0
        public void set_position(){} // RVA: 0x7ffaa8998f00
        public void get_rotation(){} // RVA: 0x7ffaaf1cf740
        public void set_rotation(){} // RVA: 0x7ffaaf1cf7f0
        public void get_eulerAngles(){} // RVA: 0x7ffaa8998f10
        public void set_eulerAngles(){} // RVA: 0x7ffaa8998f30
        public void get_useTrackMatchFields(){} // RVA: 0x7ffaa8bfcc70
        public void set_useTrackMatchFields(){} // RVA: 0x7ffaa8bfbbe0
        public void get_matchTargetFields(){} // RVA: 0x7ffaa8de7460
        public void set_matchTargetFields(){} // RVA: 0x7ffaaa1eabc0
        public void get_removeStartOffset(){} // RVA: 0x7ffaa89edc00
        public void set_removeStartOffset(){} // RVA: 0x7ffaa89edc10
        public void get_applyFootIK(){} // RVA: 0x7ffaa8bfb9f0
        public void set_applyFootIK(){} // RVA: 0x7ffaa8bfb120
        public void get_loop(){} // RVA: 0x7ffaa89d30a0
        public void set_loop(){} // RVA: 0x7ffaa89d30b0
        public void get_hasRootTransforms(){} // RVA: 0x7ffaaf1cf820
        public void get_appliedOffsetMode(){} // RVA: 0x7ffaa89d30c0
        public void set_appliedOffsetMode(){} // RVA: 0x7ffaa89d30d0
        public void get_clip(){} // RVA: 0x7ffaa89357c0
        public void set_clip(){} // RVA: 0x7ffaaf1cf930
        public void get_duration(){} // RVA: 0x7ffaaf1cfa80
        public void get_outputs(){} // RVA: 0x7ffaaf1cfb30
        public void CreatePlayable(){} // RVA: 0x7ffaaf1cfd10
        public void CreatePlayable(){} // RVA: 0x7ffaaf1cfd10
        public void ShouldApplyOffset(){} // RVA: 0x7ffaaf1d05f0
        public void ShouldApplyScaleRemove(){} // RVA: 0x7ffaaf1d0660
        public void get_clipCaps(){} // RVA: 0x7ffaaf1d0680
        public void ResetOffsets(){} // RVA: 0x7ffaaf1d0870
        public void GatherProperties(){} // RVA: 0x7ffaaf1d0900
        public void HasRootTransforms(){} // RVA: 0x7ffaaf1d09d0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaaf1d0b60
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf1d0bc0
        public void OnUpgradeFromVersion(){} // RVA: 0x7ffaaf1d0c50
        public void .ctor(){} // RVA: 0x7ffaaf1d0c90
        public void .cctor(){} // RVA: 0x7ffaaf1d0db0
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        public object m_PreviewComponents; // 0x3383FA90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1d10a0
        public void Evaluate(){} // RVA: 0x7ffaaf1d1160
        public void FetchPreviewComponents(){} // RVA: 0x7ffaaf1d13d0
    }

    public class AnimationTrack : TrackAsset
    {
        public object m_InfiniteClipPreExtrapolation; // 0x337BF780
        public object m_InfiniteClipOffsetEulerAngles; // 0x337BF780
        public object m_InfiniteClipApplyFootIK; // 0x337BF780
        public object m_Position; // 0x337BF780
        public object m_ApplyAvatarMask; // 0x337BF780
        public object s_CachedQueue; // 0x337BF780
        public object m_ApplyOffsets; // 0x337BF780
        public object position; // 0x17000014
        public object rotation; // 0x17000015
        public object eulerAngles; // 0x17000016
        public object applyOffsets; // 0x17000017
        public object trackOffset; // 0x17000018
        public object matchTargetFields; // 0x17000019
        public object infiniteClip; // 0x1700001A

        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaac120470
        public void set_position(){} // RVA: 0x7ffaac120490
        public void get_rotation(){} // RVA: 0x7ffaaf1d1720
        public void set_rotation(){} // RVA: 0x7ffaaf1d17d0
        public void get_eulerAngles(){} // RVA: 0x7ffaaf1d1800
        public void set_eulerAngles(){} // RVA: 0x7ffaaf1d1820
        public void get_applyOffsets(){} // RVA: 0x7ffaa8932320
        public void set_applyOffsets(){} // RVA: 0x7ffaa8932310
        public void get_trackOffset(){} // RVA: 0x7ffaa96c76b0
        public void set_trackOffset(){} // RVA: 0x7ffaaf1d1840
        public void get_matchTargetFields(){} // RVA: 0x7ffaa90bdfd0
        public void set_matchTargetFields(){} // RVA: 0x7ffaaf1d1850
        public void get_infiniteClip(){} // RVA: 0x7ffaa8f205f0
        public void set_infiniteClip(){} // RVA: 0x7ffaa8f20bd0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7ffaa9757e70
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7ffaa975cbc0
        public void get_avatarMask(){} // RVA: 0x7ffaa899d2a0
        public void set_avatarMask(){} // RVA: 0x7ffaa899d2b0
        public void get_applyAvatarMask(){} // RVA: 0x7ffaa96c75d0
        public void set_applyAvatarMask(){} // RVA: 0x7ffaaf1d18c0
        public void CanCompileClips(){} // RVA: 0x7ffaaf1d18d0
        public void get_outputs(){} // RVA: 0x7ffaaf1d1a10
        public void get_inClipMode(){} // RVA: 0x7ffaaf1d1ac0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7ffaaf1d1b00
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7ffaaf1d1b20
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7ffaaf1d1b40
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7ffaaf1d1bf0
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7ffaaf1d1c20
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7ffaaf1d1c40
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7ffaa975a190
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7ffaa975cc90
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7ffaaf1d1c60
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7ffaaf1d1c70
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7ffaaa2a7de0
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7ffaaa2a7dd0
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7ffaabf46920
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7ffaabf46930
        public void get_infiniteClipLoop(){} // RVA: 0x7ffaa9d2b2b0
        public void set_infiniteClipLoop(){} // RVA: 0x7ffaae2e83d0
        public void ResetOffsets(){} // RVA: 0x7ffaaf1d1c80
        public void CreateClip(){} // RVA: 0x7ffaaf1d1d20
        public void CreateInfiniteClip(){} // RVA: 0x7ffaaf1d1e40
        public void CreateRecordableClip(){} // RVA: 0x7ffaaf1d2020
        public void OnCreateClip(){} // RVA: 0x7ffaaf1d2300
        public void CalculateItemsHash(){} // RVA: 0x7ffaaf1d2370
        public void UpdateClipOffsets(){} // RVA: 0x7ffaa8932310
        public void CompileTrackPlayable(){} // RVA: 0x7ffaaf1d2480
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7ffaaf1d2a90
        public void CreateMixerPlayableGraph(){} // RVA: 0x7ffaaf1d2b30
        public void AttachDefaultBlend(){} // RVA: 0x7ffaa8932310
        public void AttachOffsetPlayable(){} // RVA: 0x7ffaaf1d36f0
        public void RequiresMotionXPlayable(){} // RVA: 0x7ffaaf1d38d0
        public void UsesAbsoluteMotion(){} // RVA: 0x7ffaaf1d3ab0
        public void HasController(){} // RVA: 0x7ffaaf1d3ac0
        public void CreateGroupMixer(){} // RVA: 0x7ffaaf1d4130
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7ffaaf1d4220
        public void ApplyTrackOffset(){} // RVA: 0x7ffaaf1d4780
        public void AssignAnimationClip(){} // RVA: 0x7ffaaf1d4c30
        public void GatherProperties(){} // RVA: 0x7ffaa8932310
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7ffaaf1d57e0
        public void AnimatesRootTransform(){} // RVA: 0x7ffaaf1d61a0
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7ffaaf1d6450
        public void get_openClipOffsetPosition(){} // RVA: 0x7ffaaf1d1b00
        public void set_openClipOffsetPosition(){} // RVA: 0x7ffaaf1d1b20
        public void get_openClipOffsetRotation(){} // RVA: 0x7ffaaf1d1b40
        public void set_openClipOffsetRotation(){} // RVA: 0x7ffaaf1d6690
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7ffaaf1d1c20
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7ffaaf1d1c40
        public void get_openClipPreExtrapolation(){} // RVA: 0x7ffaaa2a7de0
        public void set_openClipPreExtrapolation(){} // RVA: 0x7ffaaa2a7dd0
        public void get_openClipPostExtrapolation(){} // RVA: 0x7ffaabf46920
        public void set_openClipPostExtrapolation(){} // RVA: 0x7ffaabf46930
        public void OnUpgradeFromVersion(){} // RVA: 0x7ffaaf1d66d0
        public void .ctor(){} // RVA: 0x7ffaaf1d68c0
        public void .cctor(){} // RVA: 0x7ffaaf1d6af0
        // ── Binary Analysis Named ──
        public void GetDefaultBlendCount(){} // RVA: 0x7ffaa8f22da0
        public void GetBinding(){} // RVA: 0x7ffaaf1d3d50
        public void GetEvaluationTime(){} // RVA: 0x7ffaaf1d4a10
        public void GetSequenceTime(){} // RVA: 0x7ffaaf1d4ae0
        public void GetAnimationClips(){} // RVA: 0x7ffaaf1d50b0
        public void GetOffsetMode(){} // RVA: 0x7ffaaf1d56b0
        public void GetGenericRootNode(){} // RVA: 0x7ffaaf1d5dc0
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1e86d0
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        public object spatialBlend; // 0x337E61F0

        // ── Original Methods ──
        public void PrepareFrame(){} // RVA: 0x7ffaaf1e86e0
        public void .ctor(){} // RVA: 0x7ffaaf1e86d0
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        public object m_bufferingTime; // 0x336D55E0

        // ── Original Methods ──
        public void get_bufferingTime(){} // RVA: 0x7ffaa8a9ff50
        public void set_bufferingTime(){} // RVA: 0x7ffaa8a9ff60
        public void get_clip(){} // RVA: 0x7ffaa89357c0
        public void set_clip(){} // RVA: 0x7ffaa8998e80
        public void get_loop(){} // RVA: 0x7ffaa8a209d0
        public void set_loop(){} // RVA: 0x7ffaa8a209e0
        public void get_duration(){} // RVA: 0x7ffaaf1e8ad0
        public void get_outputs(){} // RVA: 0x7ffaaf1e8cd0
        public void CreatePlayable(){} // RVA: 0x7ffaaf1e8d80
        public void get_clipCaps(){} // RVA: 0x7ffaaf1e9000
        public void .ctor(){} // RVA: 0x7ffaaf1e9010
    }

    public class AudioTrack : TrackAsset
    {
        // ── Original Methods ──
        public void CreateClip(){} // RVA: 0x7ffaaf1e9310
        public void CompileClips(){} // RVA: 0x7ffaaf1e9610
        public void get_outputs(){} // RVA: 0x7ffaaf1e9f80
        public void OnValidate(){} // RVA: 0x7ffaaf1ea030
        public void .ctor(){} // RVA: 0x7ffaaf1ea0d0
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        // ── Original Methods ──
        public void get_duration(){} // RVA: 0x7ffaaf1f52e0
        public void get_outputs(){} // RVA: 0x7ffaaf1f5340
        public void OnGraphStart(){} // RVA: 0x7ffaa8932310
        public void OnGraphStop(){} // RVA: 0x7ffaa8932310
        public void OnPlayableCreate(){} // RVA: 0x7ffaa8932310
        public void OnPlayableDestroy(){} // RVA: 0x7ffaa8932310
        public void OnBehaviourPlay(){} // RVA: 0x7ffaa8932310
        public void OnBehaviourPause(){} // RVA: 0x7ffaa8932310
        public void PrepareFrame(){} // RVA: 0x7ffaa8932310
        public void ProcessFrame(){} // RVA: 0x7ffaa8932310
        public void CreatePlayable(){} // RVA: 0x7ffaaf1f53a0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class BlendUtility : Object
    {
        // ── Original Methods ──
        public void Overlaps(){} // RVA: 0x7ffaaf1fe8f0
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7ffaaf1fea30
        public void UpdateClipIntersection(){} // RVA: 0x7ffaaf1fee50
        public void .cctor(){} // RVA: 0x7ffaaf1ff040
    }

    public class ControlPlayableAsset : PlayableAsset
    {
        public object k_EmptyParticlesList; // 0x3171F270
        public object prefabGameObject; // 0x3171F270
        public object updateDirector; // 0x3171F270
        public object active; // 0x3171F270
        public object m_ControlDirectorAsset; // 0x3171F270
        public object s_ProcessedDirectors; // 0x3171F270
        public object _controllingParticles; // 0x3171F270, was: <controllingParticles>k__Backi

        // ── Original Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7ffaad109aa0
        public void set_controllingDirectors(){} // RVA: 0x7ffaae1d6c30
        public void get_controllingParticles(){} // RVA: 0x7ffaa8b6a4b0
        public void set_controllingParticles(){} // RVA: 0x7ffaa8b65090
        public void OnEnable(){} // RVA: 0x7ffaaf1ea400
        public void get_duration(){} // RVA: 0x7ffaac639e90
        public void get_clipCaps(){} // RVA: 0x7ffaaf1ea460
        public void CreatePlayable(){} // RVA: 0x7ffaaf1ea470
        public void ConnectPlayablesToMixer(){} // RVA: 0x7ffaaf1eb2b0
        public void CreateActivationPlayable(){} // RVA: 0x7ffaaf1eb700
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7ffaaf1eb8c0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7ffaaf1ebca0
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7ffaaf1ec1f0
        public void ConnectMixerAndPlayable(){} // RVA: 0x7ffaaf1ec6e0
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7ffaaf1ec8d0
        public void CacheSubEmitters(){} // RVA: 0x7ffaaf1ed6c0
        public void GatherProperties(){} // RVA: 0x7ffaaf1ed950
        public void PreviewParticles(){} // RVA: 0x7ffaaf1edd60
        public void PreviewActivation(){} // RVA: 0x7ffaaf1ee1b0
        public void PreviewTimeControl(){} // RVA: 0x7ffaaf1ee430
        public void PreviewDirectors(){} // RVA: 0x7ffaaf1ee680
        public void .ctor(){} // RVA: 0x7ffaaf1eea00
        public void .cctor(){} // RVA: 0x7ffaaf1eea80
        // ── Binary Analysis Named ──
        public void GetComponent(){} // RVA: 0x7ffaa8649280
        public void GetControlableScripts(){} // RVA: 0x7ffaaf1ec820
        public void GetControllableParticleSystems(){} // RVA: 0x7ffaaf1ed3c0
        public void GetControllableParticleSystems(){} // RVA: 0x7ffaaf1ed3c0
    }

    public class ControlTrack : TrackAsset
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1ef1d0
    }

    public class CurveEditUtility : Object
    {
        // ── Original Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7ffaaf1ef220
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CustomStyleAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        public object m_SyncTime; // 0x33A8F990

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1f5560
        public void OnPlayableDestroy(){} // RVA: 0x7ffaaf1f57c0
        public void PrepareFrame(){} // RVA: 0x7ffaaf1f5990
        public void OnBehaviourPlay(){} // RVA: 0x7ffaaf1f5c80
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f5e40
        public void ProcessFrame(){} // RVA: 0x7ffaaf1f6020
        public void SyncSpeed(){} // RVA: 0x7ffaaf1f6590
        public void SyncStart(){} // RVA: 0x7ffaaf1f6970
        public void SyncStop(){} // RVA: 0x7ffaaf1f6b30
        public void DetectDiscontinuity(){} // RVA: 0x7ffaaf1f6d10
        public void DetectOutOfSync(){} // RVA: 0x7ffaaf1f6f40
        public void UpdateTime(){} // RVA: 0x7ffaaf1f70a0
        public void .ctor(){} // RVA: 0x7ffaaf1f72e0
    }

    public class DiscreteTime : ValueType
    {
        public object m_DiscreteTime; // 0x339145C0

        // ── Original Methods ──
        public void get_tickValue(){} // RVA: 0x7ffaaf1ef3f0
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void .ctor(){} // RVA: 0x7ffaaf1ef560
        public void OneTickBefore(){} // RVA: 0x7ffaaf1ef5e0
        public void OneTickAfter(){} // RVA: 0x7ffaaf1ef5f0
        public void FromTicks(){} // RVA: 0x7ffaa9f19100
        public void CompareTo(){} // RVA: 0x7ffaaf1ef600
        public void Equals(){} // RVA: 0x7ffaaf1ef6b0
        public void Equals(){} // RVA: 0x7ffaaf1ef6b0
        public void FloatToDiscreteTime(){} // RVA: 0x7ffaaf1ef7e0
        public void IntToDiscreteTime(){} // RVA: 0x7ffaaf1ef870
        public void ToDouble(){} // RVA: 0x7ffaaf1ef8d0
        public void ToFloat(){} // RVA: 0x7ffaaf1ef8f0
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Implicit(){} // RVA: 0x7ffaaf1efb00
        public void op_Explicit(){} // RVA: 0x7ffaa9f19100
        public void op_Equality(){} // RVA: 0x7ffaaad0d3c0
        public void op_Inequality(){} // RVA: 0x7ffaaf1efb90
        public void op_GreaterThan(){} // RVA: 0x7ffaae071d90
        public void op_LessThan(){} // RVA: 0x7ffaae071d70
        public void op_LessThanOrEqual(){} // RVA: 0x7ffaae071d80
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ffaae071da0
        public void op_Addition(){} // RVA: 0x7ffaaad0d2b0
        public void op_Subtraction(){} // RVA: 0x7ffaaf1efbf0
        public void ToString(){} // RVA: 0x7ffaaf1efc00
        public void Min(){} // RVA: 0x7ffaaf1efcb0
        public void Max(){} // RVA: 0x7ffaaf1efd10
        public void SnapToNearestTick(){} // RVA: 0x7ffaaf1efde0
        public void SnapToNearestTick(){} // RVA: 0x7ffaaf1efde0
        public void .cctor(){} // RVA: 0x7ffaaf1efef0
        // ── Binary Analysis Named ──
        public void GetTick(){} // RVA: 0x7ffaa950bda0
        public void DoubleToDiscreteTime(){} // RVA: 0x7ffaaf1ef750
        public void GetHashCode(){} // RVA: 0x7ffaaf1efca0
        public void GetNearestTick(){} // RVA: 0x7ffaaf1efe90
    }

    public class Extrapolation : Object
    {
        // ── Original Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7ffaaf1ff2e0
        public void SortClipsByStartTime(){} // RVA: 0x7ffaaf1ff7b0
        public void .cctor(){} // RVA: 0x7ffaaf1ffac0
    }

    public class GroupTrack : TrackAsset
    {
        // ── Original Methods ──
        public void CanCompileClips(){} // RVA: 0x7ffaa8932320
        public void get_outputs(){} // RVA: 0x7ffaaf1f49f0
        public void .ctor(){} // RVA: 0x7ffaaf1f4a50
    }

    public class HashUtility : Object
    {
        // ── Original Methods ──
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
        public void CombineHash(){} // RVA: 0x7ffaaf1ffe40
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ICurvesOwner
    {
        // ── Original Methods ──
        public void get_curves(){} // RVA: 0x7ffaa86491d0
        public void get_hasCurves(){} // RVA: 0x7ffaa864a040
        public void get_duration(){} // RVA: 0x7ffaa864eea0
        public void CreateCurves(){} // RVA: 0x7ffaa8660d80
        public void get_defaultCurvesName(){} // RVA: 0x7ffaa86491d0
        public void get_asset(){} // RVA: 0x7ffaa86491d0
        public void get_assetOwner(){} // RVA: 0x7ffaa86491d0
        public void get_targetTrack(){} // RVA: 0x7ffaa86491d0
    }

    public class IInterval
    {
        // ── Original Methods ──
        public void get_intervalStart(){} // RVA: 0x7ffaa86491d0
        public void get_intervalEnd(){} // RVA: 0x7ffaa86491d0
    }

    public class ILayerable
    {
        // ── Original Methods ──
        public void CreateLayerMixer(){}
    }

    public class IMarker
    {
        // ── Original Methods ──
        public void get_time(){} // RVA: 0x7ffaa864eea0
        public void set_time(){} // RVA: 0x7ffaa86623c0
        public void get_parent(){} // RVA: 0x7ffaa86491d0
        public void Initialize(){} // RVA: 0x7ffaa8660d80
    }

    public class INotificationOptionProvider
    {
        // ── Original Methods ──
        public void get_flags(){} // RVA: 0x7ffaa8649100
    }

    public class IPropertyCollector
    {
        // ── Original Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7ffaa8660d80
        public void PopActiveGameObject(){} // RVA: 0x7ffaa8660cc0
        public void AddFromClip(){} // RVA: 0x7ffaa8669e70
        public void AddFromClips(){} // RVA: 0x7ffaa8669e70
        public void AddFromName(){} // RVA: 0x7ffaa8669e70
        public void AddFromName(){} // RVA: 0x7ffaa8669e70
        public void AddFromClip(){} // RVA: 0x7ffaa8669e70
        public void AddFromClips(){} // RVA: 0x7ffaa8669e70
        public void AddFromName(){} // RVA: 0x7ffaa8669e70
        public void AddFromName(){} // RVA: 0x7ffaa8669e70
        public void AddFromName(){} // RVA: 0x7ffaa8669e70
        public void AddFromComponent(){} // RVA: 0x7ffaa8669e70
        public void AddObjectProperties(){} // RVA: 0x7ffaa8669e70
    }

    public class IPropertyPreview
    {
        // ── Original Methods ──
        public void GatherProperties(){} // RVA: 0x7ffaa8669e70
    }

    public class ITimeControl
    {
        // ── Original Methods ──
        public void OnControlTimeStart(){} // RVA: 0x7ffaa8660cc0
        public void OnControlTimeStop(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetTime(){} // RVA: 0x7ffaa86623c0
    }

    public class ITimelineClipAsset
    {
        // ── Original Methods ──
        public void get_clipCaps(){} // RVA: 0x7ffaa8649ca0
    }

    public class ITimelineEvaluateCallback
    {
        // ── Original Methods ──
        public void Evaluate(){} // RVA: 0x7ffaa8660cc0
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9001710
        public void get_intervalStart(){} // RVA: 0x7ffaa8f22da0
        public void get_intervalEnd(){} // RVA: 0x7ffaaf1eff40
        public void set_enable(){} // RVA: 0x7ffaaf1effa0
        public void EvaluateAt(){} // RVA: 0x7ffaaf1f0020
        public void DisableAt(){} // RVA: 0x7ffaaf1f0080
        public void .cctor(){} // RVA: 0x7ffaaf1f00f0
    }

    public class IntervalTreeNode : ValueType
    {
        public object last; // 0x310955C0
    }

    public class IntervalTree`1 : Object
    {
        public object kCenterUnknown; // 0x31095440
        public object _dirty; // 0x31095440, was: <dirty>k__BackingField
        public object dirty; // 0x170000A2

        // ── Original Methods ──
        public void get_dirty(){} // RVA: 0x7ffaa864a040
        public void set_dirty(){} // RVA: 0x7ffaa86613a0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x7ffaa887e5c0
        public void UpdateIntervals(){} // RVA: 0x7ffaa8660cc0
        public void Query(){} // RVA: 0x7ffaa887e5c0
        public void QueryRange(){} // RVA: 0x7ffaa887e5c0
        public void Rebuild(){} // RVA: 0x7ffaa86505d0
        public void Rebuild(){} // RVA: 0x7ffaa86505d0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Marker : ScriptableObject
    {
        // ── Original Methods ──
        public void get_parent(){} // RVA: 0x7ffaa89600c0
        public void set_parent(){} // RVA: 0x7ffaa89600d0
        public void get_time(){} // RVA: 0x7ffaa9e49c40
        public void set_time(){} // RVA: 0x7ffaaf1f1300
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7ffaaf1f13a0
        public void OnInitialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class MarkerList : ValueType
    {
        public object m_CacheDirty; // 0x3366CDA0
        public object clipList; // 0x34B5D8D0

        // ── Original Methods ──
        public void get_markers(){} // RVA: 0x7ffaaf1f1540
        public void .ctor(){} // RVA: 0x7ffaaf1f1560
        public void Add(){} // RVA: 0x7ffaaf1f16e0
        public void Remove(){} // RVA: 0x7ffaaf1f1960
        public void Remove(){} // RVA: 0x7ffaaf1f1960
        public void Clear(){} // RVA: 0x7ffaaf1f1a20
        public void Contains(){} // RVA: 0x7ffaaf1f1a90
        public void get_Count(){} // RVA: 0x7ffaaf1f1af0
        public void get_Item(){} // RVA: 0x7ffaaf1f1b40
        public void CreateMarker(){} // RVA: 0x7ffaaf1f1bc0
        public void HasNotifications(){} // RVA: 0x7ffaaf1f1ef0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaa8c586c0
        public void BuildCache(){} // RVA: 0x7ffaaf1f1f10
        // ── Binary Analysis Named ──
        public void GetMarkers(){} // RVA: 0x7ffaaf1f1540
        public void GetRawMarkerList(){} // RVA: 0x7ffaa950bda0
    }

    public class MarkerTrack : TrackAsset
    {
        // ── Original Methods ──
        public void get_outputs(){} // RVA: 0x7ffaaf1f2270
        public void .ctor(){} // RVA: 0x7ffaaf1f2540
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class NotificationUtilities : Object
    {
        // ── Original Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7ffaaf1fff40
        public void CreateNotificationsPlayable(){} // RVA: 0x7ffaaf1fff40
        public void CreateNotificationsPlayable(){} // RVA: 0x7ffaaf1fff40
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7ffaaf200680
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        public object m_LastParticleTime; // 0x33CAB930

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1f72f0
        public void get_particleSystem(){} // RVA: 0x7ffaa89600c0
        public void set_particleSystem(){} // RVA: 0x7ffaa89600d0
        public void Initialize(){} // RVA: 0x7ffaaf1f75c0
        public void PrepareFrame(){} // RVA: 0x7ffaaf1f7990
        public void OnBehaviourPlay(){} // RVA: 0x7ffaaf1f7c40
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f7c40
        public void Simulate(){} // RVA: 0x7ffaaf1f7c50
        public void .ctor(){} // RVA: 0x7ffaaf1f7e20
        // ── Binary Analysis Named ──
        public void SetRandomSeed(){} // RVA: 0x7ffaaf1f7680
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Original Methods ──
        public void OnCreateClip(){} // RVA: 0x7ffaaf1fa680
        public void .ctor(){} // RVA: 0x7ffaaf1fa7f0
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1f7e40
        public void get_prefabInstance(){} // RVA: 0x7ffaa894d380
        public void Initialize(){} // RVA: 0x7ffaaf1f8070
        public void OnPlayableDestroy(){} // RVA: 0x7ffaaf1f8460
        public void OnBehaviourPlay(){} // RVA: 0x7ffaaf1f85e0
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f8700
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetHideFlagsRecursive(){} // RVA: 0x7ffaaf1f8810
    }

    public class RuntimeClip : RuntimeClipBase
    {
        public object m_ParentMixer; // 0x3381F780
        public object start; // 0x170000A3

        // ── Original Methods ──
        public void get_start(){} // RVA: 0x7ffaaf1f01e0
        public void get_duration(){} // RVA: 0x7ffaaf1f0210
        public void .ctor(){} // RVA: 0x7ffaaf1f0230
        public void Create(){} // RVA: 0x7ffaaf1f0230
        public void get_clip(){} // RVA: 0x7ffaa89357c0
        public void get_mixer(){} // RVA: 0x7ffaade810e0
        public void get_playable(){} // RVA: 0x7ffaaa4204b0
        public void set_enable(){} // RVA: 0x7ffaaf1f0300
        public void EvaluateAt(){} // RVA: 0x7ffaaf1f0520
        public void DisableAt(){} // RVA: 0x7ffaaf1f0870
        // ── Binary Analysis Named ──
        public void SetTime(){} // RVA: 0x7ffaaf1f0460
        public void SetDuration(){} // RVA: 0x7ffaaf1f04c0
    }

    public class RuntimeClipBase : RuntimeElement
    {
        // ── Original Methods ──
        public void get_start(){} // RVA: 0x7ffaa864eea0
        public void get_duration(){} // RVA: 0x7ffaa864eea0
        public void get_intervalStart(){} // RVA: 0x7ffaaf1f0a80
        public void get_intervalEnd(){} // RVA: 0x7ffaaf1f0b30
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class RuntimeElement : Object
    {
        // ── Original Methods ──
        public void get_intervalStart(){} // RVA: 0x7ffaa86491d0
        public void get_intervalEnd(){} // RVA: 0x7ffaa86491d0
        public void get_intervalBit(){} // RVA: 0x7ffaa897f5c0
        public void set_intervalBit(){} // RVA: 0x7ffaa89350c0
        public void set_enable(){} // RVA: 0x7ffaa86613a0
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        public object m_ParentMixer; // 0x33A4EAF0
        public object m_Started; // 0x33A4EAF0
        public object start; // 0x170000B1
        public object duration; // 0x170000B2

        // ── Original Methods ──
        public void get_start(){} // RVA: 0x7ffaaf1f0c00
        public void get_duration(){} // RVA: 0x7ffaaf1f0cb0
        public void get_clip(){} // RVA: 0x7ffaa89357c0
        public void get_mixer(){} // RVA: 0x7ffaade810e0
        public void get_playable(){} // RVA: 0x7ffaaa4204b0
        public void .ctor(){} // RVA: 0x7ffaaf1f0d60
        public void Create(){} // RVA: 0x7ffaaf1f0d60
        public void set_enable(){} // RVA: 0x7ffaaf1f0e40
        public void EvaluateAt(){} // RVA: 0x7ffaaf1f0f60
        public void DisableAt(){} // RVA: 0x7ffaaf1f12e0
        // ── Binary Analysis Named ──
        public void SetTime(){} // RVA: 0x7ffaaf1f0d00
    }

    public class SignalAsset : ScriptableObject
    {
        // ── Original Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7ffaaf1f2590
        public void remove_OnEnableCallback(){} // RVA: 0x7ffaaf1f26c0
        public void OnEnable(){} // RVA: 0x7ffaaf1f27f0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SignalEmitter : Marker
    {
        public object m_Asset; // 0x334576D0
        public object retroactive; // 0x170000C0

        // ── Original Methods ──
        public void get_retroactive(){} // RVA: 0x7ffaa8b0edb0
        public void set_retroactive(){} // RVA: 0x7ffaa96574d0
        public void get_emitOnce(){} // RVA: 0x7ffaa92971f0
        public void set_emitOnce(){} // RVA: 0x7ffaa9dde1d0
        public void get_asset(){} // RVA: 0x7ffaa8bfcc80
        public void set_asset(){} // RVA: 0x7ffaa8960890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7ffaaf1f2850
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7ffaaf1f29f0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SignalReceiver : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnNotify(){} // RVA: 0x7ffaaf1f2a20
        public void AddReaction(){} // RVA: 0x7ffaaf1f2c20
        public void AddEmptyReaction(){} // RVA: 0x7ffaaf1f2de0
        public void Remove(){} // RVA: 0x7ffaaf1f2e50
        public void Count(){} // RVA: 0x7ffaaf1f3010
        public void ChangeSignalAtIndex(){} // RVA: 0x7ffaaf1f3060
        public void RemoveAtIndex(){} // RVA: 0x7ffaaf1f3520
        public void ChangeReactionAtIndex(){} // RVA: 0x7ffaaf1f3630
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaaf1f38e0
        // ── Binary Analysis Named ──
        public void GetRegisteredSignals(){} // RVA: 0x7ffaa8f9a3e0
        public void GetReaction(){} // RVA: 0x7ffaaf1f2fd0
        public void GetReactionAtIndex(){} // RVA: 0x7ffaaf1f3720
        public void GetSignalAssetAtIndex(){} // RVA: 0x7ffaaf1f3800
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1f2540
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2965c0
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1f8c50
        public void Initialize(){} // RVA: 0x7ffaa8933e30
        public void PrepareFrame(){} // RVA: 0x7ffaaf1f8e10
        public void OnBehaviourPlay(){} // RVA: 0x7ffaaf1f8e90
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f8ef0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public object m_NeedSortNotifications; // 0x33A36CF0

        // ── Original Methods ──
        public void set_timeSource(){} // RVA: 0x7ffaa95fffc0
        public void Create(){} // RVA: 0x7ffaaf1f8f50
        public void AddNotification(){} // RVA: 0x7ffaaf1f9150
        public void OnGraphStart(){} // RVA: 0x7ffaaf1f9250
        public void OnBehaviourPause(){} // RVA: 0x7ffaaf1f9470
        public void PrepareFrame(){} // RVA: 0x7ffaaf1f9740
        public void SortNotifications(){} // RVA: 0x7ffaaf1f9b30
        public void CanRestoreNotification(){} // RVA: 0x7ffaaf1f9d50
        public void TriggerNotificationsInRange(){} // RVA: 0x7ffaaf1f9d90
        public void SyncDurationWithExternalSource(){} // RVA: 0x7ffaaf1fa040
        public void Trigger_internal(){} // RVA: 0x7ffaaf1fa300
        public void Restore_internal(){} // RVA: 0x7ffaa97393e0
        public void .ctor(){} // RVA: 0x7ffaaf1fa4a0
    }

    public class TimeUtility : Object
    {
        public object k_MaxTimelineDurationInSeconds; // 0x33CD0340
        public object 8؏f; // 0x33C458A0

        // ── Original Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7ffaaf202430
        public void ToFrames(){} // RVA: 0x7ffaaf2024f0
        public void ToExactFrames(){} // RVA: 0x7ffaaf202660
        public void FromFrames(){} // RVA: 0x7ffaaf202740
        public void FromFrames(){} // RVA: 0x7ffaaf202740
        public void OnFrameBoundary(){} // RVA: 0x7ffaaf202c50
        public void PreviousFrame(){} // RVA: 0x7ffaaf2029b0
        public void NextFrame(){} // RVA: 0x7ffaaf202a50
        public void PreviousFrameTime(){} // RVA: 0x7ffaaf202ac0
        public void NextFrameTime(){} // RVA: 0x7ffaaf202ba0
        public void OnFrameBoundary(){} // RVA: 0x7ffaaf202c50
        public void RoundToFrame(){} // RVA: 0x7ffaaf202d20
        public void TimeAsFrames(){} // RVA: 0x7ffaaf202e20
        public void TimeAsTimeCode(){} // RVA: 0x7ffaaf202fb0
        public void ParseTimeCode(){} // RVA: 0x7ffaaf2036b0
        public void ParseTimeSeconds(){} // RVA: 0x7ffaaf203d90
        public void RemoveChar(){} // RVA: 0x7ffaaf2044c0
        public void ToFrameRate(){} // RVA: 0x7ffaaf204820
        public void ToStandardFrameRate(){} // RVA: 0x7ffaaf204a10
        public void .cctor(){} // RVA: 0x7ffaaf204e80
        // ── Binary Analysis Named ──
        public void GetEpsilon(){} // RVA: 0x7ffaaf2028c0
        public void GetAnimationClipLength(){} // RVA: 0x7ffaaf2042c0
        public void GetClosestFrameRate(){} // RVA: 0x7ffaaf204590
    }

    public class TimelineAsset : PlayableAsset
    {
        public object m_Tracks; // 0x318C3840
        public object m_CacheRootTracks; // 0x318C3840
        public object m_DurationMode; // 0x318C3840

        // ── Original Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7ffaa8932310
        public void get_editorSettings(){} // RVA: 0x7ffaa89ad730
        public void get_duration(){} // RVA: 0x7ffaaf1d9fb0
        public void get_fixedDuration(){} // RVA: 0x7ffaaf1da050
        public void set_fixedDuration(){} // RVA: 0x7ffaaf1da170
        public void get_durationMode(){} // RVA: 0x7ffaa8b023d0
        public void set_durationMode(){} // RVA: 0x7ffaa8bfb270
        public void get_outputs(){} // RVA: 0x7ffaaf1da210
        public void get_clipCaps(){} // RVA: 0x7ffaaf1da2c0
        public void get_outputTrackCount(){} // RVA: 0x7ffaaf1da480
        public void get_rootTrackCount(){} // RVA: 0x7ffaaf1da4b0
        public void OnValidate(){} // RVA: 0x7ffaaf1da500
        public void UpdateRootTrackCache(){} // RVA: 0x7ffaaf1da740
        public void UpdateOutputTrackCache(){} // RVA: 0x7ffaaf1dabc0
        public void get_flattenedTracks(){} // RVA: 0x7ffaaf1dae60
        public void get_markerTrack(){} // RVA: 0x7ffaa89fa500
        public void get_trackObjects(){} // RVA: 0x7ffaa89600c0
        public void AddTrackInternal(){} // RVA: 0x7ffaaf1db070
        public void RemoveTrack(){} // RVA: 0x7ffaaf1db120
        public void CreatePlayable(){} // RVA: 0x7ffaaf1db2a0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa90bf2b0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf1db570
        public void __internalAwake(){} // RVA: 0x7ffaaf1db580
        public void GatherProperties(){} // RVA: 0x7ffaaf1db7e0
        public void CreateMarkerTrack(){} // RVA: 0x7ffaaf1db9f0
        public void RemoveMarkerTrack(){} // RVA: 0x7ffaaf1dbbe0
        public void Invalidate(){} // RVA: 0x7ffaaf1dbd20
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7ffaaf1dbe20
        public void CalculateItemsDuration(){} // RVA: 0x7ffaaf1dbed0
        public void AddSubTracksRecursive(){} // RVA: 0x7ffaaf1dc150
        public void CreateTrack(){} // RVA: 0x7ffaa887e5c0
        public void CreateTrack(){} // RVA: 0x7ffaa887e5c0
        public void CreateTrack(){} // RVA: 0x7ffaa887e5c0
        public void CreateTrack(){} // RVA: 0x7ffaa887e5c0
        public void DeleteClip(){} // RVA: 0x7ffaaf1dc950
        public void DeleteTrack(){} // RVA: 0x7ffaaf1dcd30
        public void MoveLastTrackBefore(){} // RVA: 0x7ffaaf1dd2f0
        public void AllocateTrack(){} // RVA: 0x7ffaaf1dd680
        public void DeleteRecordedAnimation(){} // RVA: 0x7ffaaf1dde10
        public void DeleteRecordedAnimation(){} // RVA: 0x7ffaaf1dde10
        public void .ctor(){} // RVA: 0x7ffaaf1de0b0
        // ── Binary Analysis Named ──
        public void GetRootTrack(){} // RVA: 0x7ffaaf1da540
        public void GetRootTracks(){} // RVA: 0x7ffaaf1da5c0
        public void GetOutputTrack(){} // RVA: 0x7ffaaf1da5e0
        public void GetOutputTracks(){} // RVA: 0x7ffaaf1da630
        public void GetValidFrameRate(){} // RVA: 0x7ffaaf1da650
    }

    public class TimelineClip : Object
    {
        public object kDefaultClipCaps; // 0x3379F4F0
        public object kTimeScaleMax; // 0x3379F4F0
        public object kMaxTimeValue; // 0x3379F4F0
        public object m_Asset; // 0x3379F4F0
        public object m_ParentTrack; // 0x3379F4F0
        public object m_BlendInDuration; // 0x3379F4F0
        public object m_MixOutCurve; // 0x3379F4F0
        public object m_ExposedParameterNames; // 0x3379F4F0
        public object m_PostExtrapolationMode; // 0x3379F4F0
        public object m_PreExtrapolationTime; // 0x3379F4F0

        // ── Original Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7ffaaf1d6f50
        public void .ctor(){} // RVA: 0x7ffaaf1d6f80
        public void get_hasPreExtrapolation(){} // RVA: 0x7ffaaf1d6fb0
        public void get_hasPostExtrapolation(){} // RVA: 0x7ffaaf1d6fd0
        public void get_timeScale(){} // RVA: 0x7ffaaf1d6ff0
        public void set_timeScale(){} // RVA: 0x7ffaaf1d7100
        public void get_start(){} // RVA: 0x7ffaa9e49c40
        public void set_start(){} // RVA: 0x7ffaaf1d7220
        public void get_duration(){} // RVA: 0x7ffaaf09f750
        public void set_duration(){} // RVA: 0x7ffaaf1d7430
        public void get_end(){} // RVA: 0x7ffaaf1d75f0
        public void get_clipIn(){} // RVA: 0x7ffaaf1d7600
        public void set_clipIn(){} // RVA: 0x7ffaaf1d7630
        public void get_displayName(){} // RVA: 0x7ffaa899d040
        public void set_displayName(){} // RVA: 0x7ffaa899d050
        public void get_clipAssetDuration(){} // RVA: 0x7ffaaf1d7750
        public void get_curves(){} // RVA: 0x7ffaa8971010
        public void set_curves(){} // RVA: 0x7ffaa8f7b010
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7ffaaf1d77c0
        public void get_hasCurves(){} // RVA: 0x7ffaaf1d7820
        public void get_asset(){} // RVA: 0x7ffaa8960130
        public void set_asset(){} // RVA: 0x7ffaa8933e90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7ffaa89af740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7ffaa89af740
        public void get_underlyingAsset(){} // RVA: 0x7ffaa8f22da0
        public void set_underlyingAsset(){} // RVA: 0x7ffaa8932310
        public void get_parentTrack(){} // RVA: 0x7ffaa89af740
        public void set_parentTrack(){} // RVA: 0x7ffaaf1d7960
        public void get_easeInDuration(){} // RVA: 0x7ffaaf1d7c30
        public void set_easeInDuration(){} // RVA: 0x7ffaaf1d7d30
        public void get_easeOutDuration(){} // RVA: 0x7ffaaf1d7e80
        public void set_easeOutDuration(){} // RVA: 0x7ffaaf1d7f80
        public void get_eastOutTime(){} // RVA: 0x7ffaaf1d80d0
        public void get_easeOutTime(){} // RVA: 0x7ffaaf1d80d0
        public void get_blendInDuration(){} // RVA: 0x7ffaaf1d8110
        public void set_blendInDuration(){} // RVA: 0x7ffaaf1d8140
        public void get_blendOutDuration(){} // RVA: 0x7ffaaf1d81e0
        public void set_blendOutDuration(){} // RVA: 0x7ffaaf1d8210
        public void get_blendInCurveMode(){} // RVA: 0x7ffaa9fb1a70
        public void set_blendInCurveMode(){} // RVA: 0x7ffaa9fb1a60
        public void get_blendOutCurveMode(){} // RVA: 0x7ffaa9fb8830
        public void set_blendOutCurveMode(){} // RVA: 0x7ffaae401520
        public void get_hasBlendIn(){} // RVA: 0x7ffaaf1d82b0
        public void get_hasBlendOut(){} // RVA: 0x7ffaaf1d82f0
        public void get_mixInCurve(){} // RVA: 0x7ffaaf1d8330
        public void set_mixInCurve(){} // RVA: 0x7ffaa89add60
        public void get_mixInPercentage(){} // RVA: 0x7ffaaf1d8440
        public void get_mixInDuration(){} // RVA: 0x7ffaaf1d8460
        public void get_mixOutCurve(){} // RVA: 0x7ffaaf1d8590
        public void set_mixOutCurve(){} // RVA: 0x7ffaa89fa5a0
        public void get_mixOutTime(){} // RVA: 0x7ffaaf1d86a0
        public void get_mixOutDuration(){} // RVA: 0x7ffaaf1d8720
        public void get_mixOutPercentage(){} // RVA: 0x7ffaaf1d8790
        public void get_recordable(){} // RVA: 0x7ffaa982f2b0
        public void set_recordable(){} // RVA: 0x7ffaa9839000
        public void get_exposedParameters(){} // RVA: 0x7ffaaf1d8800
        public void get_clipCaps(){} // RVA: 0x7ffaaf1d88d0
        public void Hash(){} // RVA: 0x7ffaaf1d8970
        public void EvaluateMixOut(){} // RVA: 0x7ffaaf1d8aa0
        public void EvaluateMixIn(){} // RVA: 0x7ffaaf1d8c00
        public void ToLocalTime(){} // RVA: 0x7ffaaf1d8d50
        public void ToLocalTimeUnbound(){} // RVA: 0x7ffaaf1d8f20
        public void FromLocalTimeUnbound(){} // RVA: 0x7ffaaf1d8f90
        public void get_animationClip(){} // RVA: 0x7ffaaf1d8ff0
        public void SanitizeTimeValue(){} // RVA: 0x7ffaaf1d91c0
        public void get_postExtrapolationMode(){} // RVA: 0x7ffaaf1d9320
        public void set_postExtrapolationMode(){} // RVA: 0x7ffaaf1d9350
        public void get_preExtrapolationMode(){} // RVA: 0x7ffaaf1d9390
        public void set_preExtrapolationMode(){} // RVA: 0x7ffaaf1d93c0
        public void IsExtrapolatedTime(){} // RVA: 0x7ffaaf1d9420
        public void IsPreExtrapolatedTime(){} // RVA: 0x7ffaaf1d94d0
        public void IsPostExtrapolatedTime(){} // RVA: 0x7ffaaf1d9530
        public void get_extrapolatedStart(){} // RVA: 0x7ffaaf1d95a0
        public void get_extrapolatedDuration(){} // RVA: 0x7ffaaf1d95c0
        public void CreateCurves(){} // RVA: 0x7ffaaf1d9800
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa9fd79e0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf1d6f50
        public void ToString(){} // RVA: 0x7ffaaf1d9990
        public void ConformEaseValues(){} // RVA: 0x7ffaaf1d9be0
        public void CalculateEasingRatio(){} // RVA: 0x7ffaaf1d9d40
        public void UpdateDirty(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf1d9e30
        // ── Binary Analysis Named ──
        public void GetParentTrack(){} // RVA: 0x7ffaa89af740
        public void SetParentTrack_Internal(){} // RVA: 0x7ffaaf1d7970
        public void GetDefaultMixInCurve(){} // RVA: 0x7ffaaf1d8cf0
        public void GetDefaultMixOutCurve(){} // RVA: 0x7ffaaf1d8d20
        public void SetPostExtrapolationTime(){} // RVA: 0x7ffaaf1d9400
        public void SetPreExtrapolationTime(){} // RVA: 0x7ffaaf1d9410
        public void GetExtrapolatedTime(){} // RVA: 0x7ffaaf1d96c0
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Original Methods ──
        public void SupportsLooping(){} // RVA: 0x7ffaaf1ea310
        public void SupportsExtrapolation(){} // RVA: 0x7ffaaf1ea340
        public void SupportsClipIn(){} // RVA: 0x7ffaaf1ea370
        public void SupportsSpeedMultiplier(){} // RVA: 0x7ffaaf1ea3a0
        public void SupportsBlending(){} // RVA: 0x7ffaaf1ea3d0
        public void HasAll(){} // RVA: 0x7ffaa9d5f390
        public void HasAny(){} // RVA: 0x7ffaaebbad30
    }

    public class TimelineClipExtensions : Object
    {
        // ── Original Methods ──
        public void MoveToTrack(){} // RVA: 0x7ffaaf200880
        public void TryMoveToTrack(){} // RVA: 0x7ffaaf200db0
        public void MoveToTrack_Impl(){} // RVA: 0x7ffaaf2010d0
        public void .cctor(){} // RVA: 0x7ffaaf201370
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Original Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7ffaaf201420
        public void SaveAssetIntoObject(){} // RVA: 0x7ffaaf201770
        public void RemoveAssetFromObject(){} // RVA: 0x7ffaaf201940
        public void CreateAnimationClipForTrack(){} // RVA: 0x7ffaaf201aa0
        public void ValidateParentTrack(){} // RVA: 0x7ffaaf201e80
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TimelinePlayable : PlayableBehaviour
    {
        public object m_CurrentListOfActiveClips; // 0x3383D050
        public object muteAudioScrubbing; // 0x3383D050
        public object m_ForceEvaluateNextEvaluate; // 0x3383D050

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf1fa8f0
        public void Compile(){} // RVA: 0x7ffaaf1fad10
        public void CompileTrackList(){} // RVA: 0x7ffaaf1fb180
        public void CreateTrackOutput(){} // RVA: 0x7ffaaf1fb440
        public void CreateTrackPlayable(){} // RVA: 0x7ffaaf1fbdf0
        public void PrepareFrame(){} // RVA: 0x7ffaaf1fc390
        public void Evaluate(){} // RVA: 0x7ffaaf1fc3e0
        public void CacheTrack(){} // RVA: 0x7ffaaf1fcba0
        public void ForAOTCompilationOnly(){} // RVA: 0x7ffaaf1fcc30
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7ffaaf1fcc90
        public void AddOutputWeightProcessor(){} // RVA: 0x7ffaaf1fcd30
        public void AddEvaluateCallback(){} // RVA: 0x7ffaaf1fcfb0
        public void InvokeOutputCallbacks(){} // RVA: 0x7ffaaf1fd140
        public void TryGetCallbackList(){} // RVA: 0x7ffaaf1fdcc0
        public void .ctor(){} // RVA: 0x7ffaaf1fdeb0
        public void .cctor(){} // RVA: 0x7ffaaf1fe530
    }

    public class TimelineUndo : Object
    {
        // ── Original Methods ──
        public void get_undoEnabled(){} // RVA: 0x7ffaa8932320
        public void PushDestroyUndo(){} // RVA: 0x7ffaaf2022f0
        public void PushUndo(){} // RVA: 0x7ffaa8932310
        public void PushUndo(){} // RVA: 0x7ffaa8932310
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7ffaa8932310
        public void UndoName(){} // RVA: 0x7ffaaf2023e0
    }

    public class TrackAsset : PlayableAsset
    {
        public object m_AnimClip; // 0x318C3BD0
        public object OnClipPlayableCreate; // 0x318C3BD0
        public object m_Muted; // 0x318C3BD0
        public object m_Parent; // 0x318C3BD0
        public object m_ClipsCache; // 0x318C3BD0
        public object m_CacheSorted; // 0x318C3BD0
        public object s_EmptyCache; // 0x318C3BD0
        public object m_Clips; // 0x318C3BD0
        public object kMaxTime; // 0x339145C0
        public object m_Cache; // 0x3366CDA0
        public object trackList; // 0x34B5D8D0

        // ── Original Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0x7ffaa8932310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnUpgradeFromVersion(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaaf1def40
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf1df240
        public void UpgradeToLatestVersion(){} // RVA: 0x7ffaa8932310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7ffaaf1df550
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7ffaaf1df6b0
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7ffaaf1df810
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7ffaaf1df970
        public void get_start(){} // RVA: 0x7ffaaf1dfad0
        public void get_end(){} // RVA: 0x7ffaaf1dfb70
        public void get_duration(){} // RVA: 0x7ffaaf1dfc10
        public void get_muted(){} // RVA: 0x7ffaa92971f0
        public void set_muted(){} // RVA: 0x7ffaa9dde1d0
        public void get_mutedInHierarchy(){} // RVA: 0x7ffaaf1dfcc0
        public void get_timelineAsset(){} // RVA: 0x7ffaaf1dff70
        public void get_parent(){} // RVA: 0x7ffaa89af740
        public void set_parent(){} // RVA: 0x7ffaa895a200
        public void get_clips(){} // RVA: 0x7ffaaf1e0260
        public void get_blendsValid(){} // RVA: 0x7ffaadc67670
        public void set_blendsValid(){} // RVA: 0x7ffaadc67680
        public void get_isEmpty(){} // RVA: 0x7ffaaf1e03c0
        public void get_hasClips(){} // RVA: 0x7ffaaf1e0470
        public void get_hasCurves(){} // RVA: 0x7ffaaf1e04c0
        public void get_isSubTrack(){} // RVA: 0x7ffaaf1e05f0
        public void get_outputs(){} // RVA: 0x7ffaaf1e0770
        public void get_customPlayableTypename(){} // RVA: 0x7ffaa8bfcc80
        public void set_customPlayableTypename(){} // RVA: 0x7ffaa8960890
        public void get_curves(){} // RVA: 0x7ffaa8bf45b0
        public void set_curves(){} // RVA: 0x7ffaa8bf45c0
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7ffaaf1e0840
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7ffaa9f19100
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7ffaaf1e0880
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7ffaa9f19100
        public void get_subTracksObjects(){} // RVA: 0x7ffaa89ad730
        public void get_locked(){} // RVA: 0x7ffaa8b0edb0
        public void set_locked(){} // RVA: 0x7ffaa96574d0
        public void get_lockedInHierarchy(){} // RVA: 0x7ffaaf1e0890
        public void get_supportsNotifications(){} // RVA: 0x7ffaaf1e0b40
        public void __internalAwake(){} // RVA: 0x7ffaaf1e0bd0
        public void CreateCurves(){} // RVA: 0x7ffaaf1e0d90
        public void CreateTrackMixer(){} // RVA: 0x7ffaaf1e0ef0
        public void CreatePlayable(){} // RVA: 0x7ffaaf1e6460
        public void CreateDefaultClip(){} // RVA: 0x7ffaaf1e10c0
        public void CreateClip(){} // RVA: 0x7ffaaf1e1670
        public void DeleteClip(){} // RVA: 0x7ffaaf1e1410
        public void CreateMarker(){} // RVA: 0x7ffaa887e5c0
        public void CreateMarker(){} // RVA: 0x7ffaa887e5c0
        public void DeleteMarker(){} // RVA: 0x7ffaaf1e15d0
        public void CreateClip(){} // RVA: 0x7ffaaf1e1670
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7ffaaf1e17b0
        public void CreateClipOfType(){} // RVA: 0x7ffaaf1e17f0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7ffaaf1e1ae0
        public void CreateClipFromAsset(){} // RVA: 0x7ffaaf1e1e10
        public void ClearMarkers(){} // RVA: 0x7ffaaf1e20d0
        public void AddMarker(){} // RVA: 0x7ffaaf1e2140
        public void DeleteMarkerRaw(){} // RVA: 0x7ffaaf1e2150
        public void AddClip(){} // RVA: 0x7ffaaf1e23f0
        public void CreateNotificationsPlayable(){} // RVA: 0x7ffaaf1e2530
        public void CreatePlayableGraph(){} // RVA: 0x7ffaaf1e2a40
        public void CompileClips(){} // RVA: 0x7ffaaf1e2de0
        public void GatherCompilableTracks(){} // RVA: 0x7ffaaf1e32d0
        public void GatherNotifications(){} // RVA: 0x7ffaaf1e35b0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7ffaaf1e38c0
        public void ConfigureTrackAnimation(){} // RVA: 0x7ffaaf1e4220
        public void SortClips(){} // RVA: 0x7ffaaf1e4380
        public void ClearClipsInternal(){} // RVA: 0x7ffaaf1e4600
        public void ClearSubTracksInternal(){} // RVA: 0x7ffaaf1e4720
        public void OnClipMove(){} // RVA: 0x7ffaaf1e47f0
        public void CreateNewClipContainerInternal(){} // RVA: 0x7ffaaf1e4850
        public void AddChild(){} // RVA: 0x7ffaaf1e4c80
        public void MoveLastTrackBefore(){} // RVA: 0x7ffaaf1e4dd0
        public void RemoveSubTrack(){} // RVA: 0x7ffaaf1e5160
        public void RemoveClip(){} // RVA: 0x7ffaaf1e5240
        public void GatherProperties(){} // RVA: 0x7ffaaf1e5580
        public void ValidateClipType(){} // RVA: 0x7ffaaf1e5f30
        public void OnCreateClip(){} // RVA: 0x7ffaa8932310
        public void UpdateDuration(){} // RVA: 0x7ffaaf1e6240
        public void CalculateItemsHash(){} // RVA: 0x7ffaaf1e63b0
        public void CreatePlayable(){} // RVA: 0x7ffaaf1e6460
        public void Invalidate(){} // RVA: 0x7ffaaf1e6800
        public void CanCompileClips(){} // RVA: 0x7ffaaf1e6b30
        public void CanCreateTrackMixer(){} // RVA: 0x7ffaae075080
        public void IsCompilable(){} // RVA: 0x7ffaaf1e6b90
        public void UpdateChildTrackCache(){} // RVA: 0x7ffaaf1e6e90
        public void Hash(){} // RVA: 0x7ffaaf1e71d0
        public void HasNotifications(){} // RVA: 0x7ffaaf1e76e0
        public void CanCompileNotifications(){} // RVA: 0x7ffaaf1e7710
        public void CanCreateMixerRecursive(){} // RVA: 0x7ffaaf1e7750
        public void .ctor(){} // RVA: 0x7ffaaf1e78f0
        public void .cctor(){} // RVA: 0x7ffaaf1e7ad0
        // ── Binary Analysis Named ──
        public void GetClips(){} // RVA: 0x7ffaaf1e0250
        public void GetChildTracks(){} // RVA: 0x7ffaaf1e0820
        public void GetMarkers(){} // RVA: 0x7ffaaf1e15e0
        public void GetMarkerCount(){} // RVA: 0x7ffaaf1e1610
        public void GetMarker(){} // RVA: 0x7ffaaf1e1660
        public void GetMarkersRaw(){} // RVA: 0x7ffaa8971010
        public void GetTimeRangeHash(){} // RVA: 0x7ffaaf1e2190
        public void GetEvaluationTime(){} // RVA: 0x7ffaaf1e5310
        public void GetSequenceTime(){} // RVA: 0x7ffaaf1e5560
        public void GetGameObjectBinding(){} // RVA: 0x7ffaaf1e5c40
        public void GetNotificationDuration(){} // RVA: 0x7ffaaf1e6930
        public void GetClipsHash(){} // RVA: 0x7ffaaf1e7250
        public void GetAnimationClipHash(){} // RVA: 0x7ffaaf1e74f0
    }

    public class TrackAssetExtensions : Object
    {
        // ── Original Methods ──
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7ffaaf1f4960
        // ── Binary Analysis Named ──
        public void GetGroup(){} // RVA: 0x7ffaaf1f40a0
        public void SetGroup(){} // RVA: 0x7ffaaf1f41d0
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        public object childType; // 0x337BD280

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2965c0
        public void .ctor(){} // RVA: 0x7ffaaa2965c0
    }

    public class TrackClipTypeAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class TrackColorAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_color(){} // RVA: 0x7ffaa9e49b20
        public void .ctor(){} // RVA: 0x7ffaaf1e8690
    }

    public class WeightUtility : Object
    {
        // ── Original Methods ──
        public void NormalizeMixer(){} // RVA: 0x7ffaaf205080
    }

}