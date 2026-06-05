// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 793

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AEA180
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF9AEA400
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AEA520
        public void ProcessFrame(){} // RVA: 0x7FFAF9AEA630
        public void OnGraphStart(){} // RVA: 0x7FFAF9AEA750
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF9AEA880
        public void .ctor(){} // RVA: 0x7FFAF9877CB0
    }

    public class ActivationMixerPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AC3850
        public void get_postPlaybackState(){} // RVA: 0x7FFAF2DDA5C0
        public void set_postPlaybackState(){} // RVA: 0x7FFAF2D900C0
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF9AC38F0
        public void ProcessFrame(){} // RVA: 0x7FFAF9AC3A20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ActivationPlayableAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFAF2FC9240
        public void CreatePlayable(){} // RVA: 0x7FFAF9AC3D80
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class ActivationTrack
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFAF9AC3EA0
        public void get_postPlaybackState(){} // RVA: 0x7FFAF4826590
        public void set_postPlaybackState(){} // RVA: 0x7FFAF9AC3F30
        public void CreateTrackMixer(){} // RVA: 0x7FFAF9AC3F50
        public void UpdateTrackMode(){} // RVA: 0x7FFAF9AC4190
        public void GatherProperties(){} // RVA: 0x7FFAF9AC41B0
        public void OnCreateClip(){} // RVA: 0x7FFAF9AC42D0
        public void .ctor(){} // RVA: 0x7FFAF9AC4360
    }

    public class AnimationOutputWeightProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9AC43C0
        public void FindMixers(){} // RVA: 0x7FFAF9AC47A0 | overloaded x2
        public void Evaluate(){} // RVA: 0x7FFAF9AC4BB0
    }

    public class AnimationPlayableAsset
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAF2DF3EE0
        public void set_position(){} // RVA: 0x7FFAF2DF3F00
        public void get_rotation(){} // RVA: 0x7FFAF9AC4E20
        public void set_rotation(){} // RVA: 0x7FFAF9AC4ED0
        public void get_eulerAngles(){} // RVA: 0x7FFAF2DF3F10
        public void set_eulerAngles(){} // RVA: 0x7FFAF2DF3F30
        public void get_useTrackMatchFields(){} // RVA: 0x7FFAF2F56500
        public void set_useTrackMatchFields(){} // RVA: 0x7FFAF2F578C0
        public void get_matchTargetFields(){} // RVA: 0x7FFAF3341AF0
        public void set_matchTargetFields(){} // RVA: 0x7FFAF47695F0
        public void get_removeStartOffset(){} // RVA: 0x7FFAF2E48C00
        public void set_removeStartOffset(){} // RVA: 0x7FFAF2E48C10
        public void get_applyFootIK(){} // RVA: 0x7FFAF310EEC0
        public void set_applyFootIK(){} // RVA: 0x7FFAF310EEB0
        public void get_loop(){} // RVA: 0x7FFAF2E2E0A0
        public void set_loop(){} // RVA: 0x7FFAF2E2E0B0
        public void get_hasRootTransforms(){} // RVA: 0x7FFAF9AC4F00
        public void get_appliedOffsetMode(){} // RVA: 0x7FFAF2E2E0C0
        public void set_appliedOffsetMode(){} // RVA: 0x7FFAF2E2E0D0
        public void get_clip(){} // RVA: 0x7FFAF2D907C0
        public void set_clip(){} // RVA: 0x7FFAF9AC5010
        public void get_duration(){} // RVA: 0x7FFAF9AC5160
        public void get_outputs(){} // RVA: 0x7FFAF9AC5210
        public void CreatePlayable(){} // RVA: 0x7FFAF9AC53F0 | overloaded x2
        public void ShouldApplyOffset(){} // RVA: 0x7FFAF9AC5CD0
        public void ShouldApplyScaleRemove(){} // RVA: 0x7FFAF9AC5D40
        public void get_clipCaps(){} // RVA: 0x7FFAF9AC5D60
        public void ResetOffsets(){} // RVA: 0x7FFAF9AC5F50
        public void GatherProperties(){} // RVA: 0x7FFAF9AC5FE0
        public void HasRootTransforms(){} // RVA: 0x7FFAF9AC60B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF9AC6240
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF9AC62A0
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAF9AC6330
        public void .ctor(){} // RVA: 0x7FFAF9AC6370
        public void .cctor(){} // RVA: 0x7FFAF9AC6490
    }

    public class AnimationPreviewUpdateCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9AC6780
        public void Evaluate(){} // RVA: 0x7FFAF9AC6840
        public void FetchPreviewComponents(){} // RVA: 0x7FFAF9AC6AB0
    }

    public class AnimationTrack
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAF68A13B0
        public void set_position(){} // RVA: 0x7FFAF68A13D0
        public void get_rotation(){} // RVA: 0x7FFAF9AC6E00
        public void set_rotation(){} // RVA: 0x7FFAF9AC6EB0
        public void get_eulerAngles(){} // RVA: 0x7FFAF9AC6EE0
        public void set_eulerAngles(){} // RVA: 0x7FFAF9AC6F00
        public void get_applyOffsets(){} // RVA: 0x7FFAF2D8D320
        public void set_applyOffsets(){} // RVA: 0x7FFAF2D8D310
        public void get_trackOffset(){} // RVA: 0x7FFAF3CBBB40
        public void set_trackOffset(){} // RVA: 0x7FFAF9AC6F20
        public void get_matchTargetFields(){} // RVA: 0x7FFAF3500BB0
        public void set_matchTargetFields(){} // RVA: 0x7FFAF9AC6F30
        public void get_infiniteClip(){} // RVA: 0x7FFAF3544E10
        public void set_infiniteClip(){} // RVA: 0x7FFAF37A6DE0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7FFAF3D1AF80
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7FFAF3D1BEE0
        public void get_avatarMask(){} // RVA: 0x7FFAF2DF82A0
        public void set_avatarMask(){} // RVA: 0x7FFAF2DF82B0
        public void get_applyAvatarMask(){} // RVA: 0x7FFAF3CB9D80
        public void set_applyAvatarMask(){} // RVA: 0x7FFAF9AC6FA0
        public void CanCompileClips(){} // RVA: 0x7FFAF9AC6FB0
        public void get_outputs(){} // RVA: 0x7FFAF9AC70F0
        public void get_inClipMode(){} // RVA: 0x7FFAF9AC71A0
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7FFAF9AC71E0
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7FFAF9AC7200
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7FFAF9AC7220
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7FFAF9AC72D0
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFAF9AC7300
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7FFAF9AC7320
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7FFAF3DF28A0
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7FFAF8C68650
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7FFAF9AC7340
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7FFAF9AC7350
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7FFAF4826590
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7FFAF4826550
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7FFAF66F9C00
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7FFAF66F9C10
        public void get_infiniteClipLoop(){} // RVA: 0x7FFAF4334A40
        public void set_infiniteClipLoop(){} // RVA: 0x7FFAF8BDFAE0
        public void ResetOffsets(){} // RVA: 0x7FFAF9AC7360
        public void CreateClip(){} // RVA: 0x7FFAF9AC7400
        public void CreateInfiniteClip(){} // RVA: 0x7FFAF9AC7520
        public void CreateRecordableClip(){} // RVA: 0x7FFAF9AC7700
        public void OnCreateClip(){} // RVA: 0x7FFAF9AC79E0
        public void CalculateItemsHash(){} // RVA: 0x7FFAF9AC7A50
        public void UpdateClipOffsets(){} // RVA: 0x7FFAF2D8D310
        public void CompileTrackPlayable(){} // RVA: 0x7FFAF9AC7B60
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7FFAF9AC8170
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFAF9AC8210
        public void GetDefaultBlendCount(){} // RVA: 0x7FFAF2FC9240
        public void AttachDefaultBlend(){} // RVA: 0x7FFAF2D8D310
        public void AttachOffsetPlayable(){} // RVA: 0x7FFAF9AC8DD0
        public void RequiresMotionXPlayable(){} // RVA: 0x7FFAF9AC8FB0
        public void UsesAbsoluteMotion(){} // RVA: 0x7FFAF9AC9190
        public void HasController(){} // RVA: 0x7FFAF9AC91A0
        public void GetBinding(){} // RVA: 0x7FFAF9AC9430
        public void CreateGroupMixer(){} // RVA: 0x7FFAF9AC9810
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7FFAF9AC9900
        public void ApplyTrackOffset(){} // RVA: 0x7FFAF9AC9E60
        public void GetEvaluationTime(){} // RVA: 0x7FFAF9ACA0F0
        public void GetSequenceTime(){} // RVA: 0x7FFAF9ACA1C0
        public void AssignAnimationClip(){} // RVA: 0x7FFAF9ACA310
        public void GatherProperties(){} // RVA: 0x7FFAF2D8D310
        public void GetAnimationClips(){} // RVA: 0x7FFAF9ACA790
        public void GetOffsetMode(){} // RVA: 0x7FFAF9ACAD90
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7FFAF9ACAEC0
        public void GetGenericRootNode(){} // RVA: 0x7FFAF9ACB4A0
        public void AnimatesRootTransform(){} // RVA: 0x7FFAF9ACB880
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7FFAF9ACBB30
        public void get_openClipOffsetPosition(){} // RVA: 0x7FFAF9AC71E0
        public void set_openClipOffsetPosition(){} // RVA: 0x7FFAF9AC7200
        public void get_openClipOffsetRotation(){} // RVA: 0x7FFAF9AC7220
        public void set_openClipOffsetRotation(){} // RVA: 0x7FFAF9ACBD70
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7FFAF9AC7300
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7FFAF9AC7320
        public void get_openClipPreExtrapolation(){} // RVA: 0x7FFAF4826590
        public void set_openClipPreExtrapolation(){} // RVA: 0x7FFAF4826550
        public void get_openClipPostExtrapolation(){} // RVA: 0x7FFAF66F9C00
        public void set_openClipPostExtrapolation(){} // RVA: 0x7FFAF66F9C10
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAF9ACBDB0
        public void .ctor(){} // RVA: 0x7FFAF9ACBFA0
        public void .cctor(){} // RVA: 0x7FFAF9ACC1D0
    }

    public class AudioClipProperties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9ADDDB0
    }

    public class AudioMixerProperties
    {
        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7FFAF9ADDDC0
        public void .ctor(){} // RVA: 0x7FFAF9ADDDB0
    }

    public class AudioPlayableAsset
    {
        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x7FFAF2EFAF50
        public void set_bufferingTime(){} // RVA: 0x7FFAF2EFAF60
        public void get_clip(){} // RVA: 0x7FFAF2D907C0
        public void set_clip(){} // RVA: 0x7FFAF2DF3E80
        public void get_loop(){} // RVA: 0x7FFAF2E7B9D0
        public void set_loop(){} // RVA: 0x7FFAF2E7B9E0
        public void get_duration(){} // RVA: 0x7FFAF9ADE1B0
        public void get_outputs(){} // RVA: 0x7FFAF9ADE3B0
        public void CreatePlayable(){} // RVA: 0x7FFAF9ADE460
        public void get_clipCaps(){} // RVA: 0x7FFAF9ADE6E0
        public void .ctor(){} // RVA: 0x7FFAF9ADE6F0
    }

    public class AudioTrack
    {
        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7FFAF9ADE9F0
        public void CompileClips(){} // RVA: 0x7FFAF9ADECF0
        public void get_outputs(){} // RVA: 0x7FFAF9ADF660
        public void OnValidate(){} // RVA: 0x7FFAF9ADF710
        public void .ctor(){} // RVA: 0x7FFAF9ADF7B0
    }

    public class BasicPlayableBehaviour
    {
        // ── Methods ──
        public void get_duration(){} // RVA: 0x7FFAF9AEA9C0
        public void get_outputs(){} // RVA: 0x7FFAF9AEAA20
        public void OnGraphStart(){} // RVA: 0x7FFAF2D8D310
        public void OnGraphStop(){} // RVA: 0x7FFAF2D8D310
        public void OnPlayableCreate(){} // RVA: 0x7FFAF2D8D310
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF2D8D310
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF2D8D310
        public void OnBehaviourPause(){} // RVA: 0x7FFAF2D8D310
        public void PrepareFrame(){} // RVA: 0x7FFAF2D8D310
        public void ProcessFrame(){} // RVA: 0x7FFAF2D8D310
        public void CreatePlayable(){} // RVA: 0x7FFAF9AEAA80
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class BlendUtility
    {
        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7FFAF9AF4040
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFAF9AF4180
        public void UpdateClipIntersection(){} // RVA: 0x7FFAF9AF45A0
        public void .cctor(){} // RVA: 0x7FFAF9AF4790
    }

    public class ControlPlayableAsset
    {
        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7FFAF7A94B90
        public void set_controllingDirectors(){} // RVA: 0x7FFAF8ACE3A0
        public void get_controllingParticles(){} // RVA: 0x7FFAF3056E50
        public void set_controllingParticles(){} // RVA: 0x7FFAF304F960
        public void OnEnable(){} // RVA: 0x7FFAF9ADFAE0
        public void get_duration(){} // RVA: 0x7FFAF6E13CB0
        public void get_clipCaps(){} // RVA: 0x7FFAF9ADFB40
        public void CreatePlayable(){} // RVA: 0x7FFAF9ADFB50
        public void ConnectPlayablesToMixer(){} // RVA: 0x7FFAF9AE0990
        public void CreateActivationPlayable(){} // RVA: 0x7FFAF9AE0DE0
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7FFAF9AE0FA0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7FFAF9AE1380
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7FFAF9AE18D0
        public void ConnectMixerAndPlayable(){} // RVA: 0x7FFAF9AE1DC0
        public void GetComponent(){} // RVA: 0x7FFAF2ABCE10
        public void GetControlableScripts(){} // RVA: 0x7FFAF9AE1F00
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7FFAF9AE1FB0
        public void GetControllableParticleSystems(){} // RVA: 0x7FFAF9AE2AA0 | overloaded x2
        public void CacheSubEmitters(){} // RVA: 0x7FFAF9AE2DA0
        public void GatherProperties(){} // RVA: 0x7FFAF9AE3030
        public void PreviewParticles(){} // RVA: 0x7FFAF9AE3440
        public void PreviewActivation(){} // RVA: 0x7FFAF9AE3890
        public void PreviewTimeControl(){} // RVA: 0x7FFAF9AE3B10
        public void PreviewDirectors(){} // RVA: 0x7FFAF9AE3D60
        public void .ctor(){} // RVA: 0x7FFAF9AE40E0
        public void .cctor(){} // RVA: 0x7FFAF9AE4160
    }

    public class ControlTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9AE48B0
    }

    public class CurveEditUtility
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7FFAF9AE4900
    }

    public class CustomSignalEventDrawer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CustomStyleAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class DirectorControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AEAC40
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF9AEAEA0
        public void PrepareFrame(){} // RVA: 0x7FFAF9AEB070
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF9AEB360
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AEB520
        public void ProcessFrame(){} // RVA: 0x7FFAF9AEB700
        public void SyncSpeed(){} // RVA: 0x7FFAF9AEBC70
        public void SyncStart(){} // RVA: 0x7FFAF9AEC050
        public void SyncStop(){} // RVA: 0x7FFAF9AEC210
        public void DetectDiscontinuity(){} // RVA: 0x7FFAF9AEC3F0
        public void DetectOutOfSync(){} // RVA: 0x7FFAF9AEC620
        public void UpdateTime(){} // RVA: 0x7FFAF9AEC780
        public void .ctor(){} // RVA: 0x7FFAF9AEC9C0
    }

    public class DiscreteTime
    {
        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7FFAF9AE4AD0
        public void .ctor(){} // RVA: 0x7FFAF9AE4C40 | overloaded x6
        public void OneTickBefore(){} // RVA: 0x7FFAF9AE4CC0
        public void OneTickAfter(){} // RVA: 0x7FFAF9AE4CD0
        public void GetTick(){} // RVA: 0x7FFAF4584690
        public void FromTicks(){} // RVA: 0x7FFAF44EF520
        public void CompareTo(){} // RVA: 0x7FFAF9AE4CE0
        public void Equals(){} // RVA: 0x7FFAF9AE4D90 | overloaded x2
        public void DoubleToDiscreteTime(){} // RVA: 0x7FFAF9AE4E30
        public void FloatToDiscreteTime(){} // RVA: 0x7FFAF9AE4EC0
        public void IntToDiscreteTime(){} // RVA: 0x7FFAF9AE4F50
        public void ToDouble(){} // RVA: 0x7FFAF9AE4FB0
        public void ToFloat(){} // RVA: 0x7FFAF9AE4FD0
        public void op_Explicit(){} // RVA: 0x7FFAF44EF520 | overloaded x6
        public void op_Implicit(){} // RVA: 0x7FFAF9AE51E0
        public void op_Equality(){} // RVA: 0x7FFAF5328D00
        public void op_Inequality(){} // RVA: 0x7FFAF9AE5270
        public void op_GreaterThan(){} // RVA: 0x7FFAF89694D0
        public void op_LessThan(){} // RVA: 0x7FFAF89694B0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAF89694C0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAF89694E0
        public void op_Addition(){} // RVA: 0x7FFAF5328BF0
        public void op_Subtraction(){} // RVA: 0x7FFAF9AE52D0
        public void ToString(){} // RVA: 0x7FFAF9AE52E0
        public void GetHashCode(){} // RVA: 0x7FFAF9AE5380
        public void Min(){} // RVA: 0x7FFAF9AE5390
        public void Max(){} // RVA: 0x7FFAF9AE53F0
        public void SnapToNearestTick(){} // RVA: 0x7FFAF9AE54C0 | overloaded x2
        public void GetNearestTick(){} // RVA: 0x7FFAF9AE5570
        public void .cctor(){} // RVA: 0x7FFAF9AE55D0
    }

    public class Extrapolation
    {
        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7FFAF9AF4A30
        public void SortClipsByStartTime(){} // RVA: 0x7FFAF9AF4F00
        public void .cctor(){} // RVA: 0x7FFAF9AF5210
    }

    public class FrameRateFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GroupTrack
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7FFAF2D8D320
        public void get_outputs(){} // RVA: 0x7FFAF9AEA0D0
        public void .ctor(){} // RVA: 0x7FFAF9AEA130
    }

    public class HashUtility
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7FFAF9AF5590 | overloaded x7
    }

    public class HideInMenuAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ICurvesOwner
    {
        // ── Methods ──
        public void get_curves(){} // RVA: 0x7FFAF2ABCD60
        public void get_hasCurves(){} // RVA: 0x7FFAF2ABDBE0
        public void get_duration(){} // RVA: 0x7FFAF2AC2A40
        public void CreateCurves(){} // RVA: 0x7FFAF2AD4B10
        public void get_defaultCurvesName(){} // RVA: 0x7FFAF2ABCD60
        public void get_asset(){} // RVA: 0x7FFAF2ABCD60
        public void get_assetOwner(){} // RVA: 0x7FFAF2ABCD60
        public void get_targetTrack(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IInterval
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFAF2ABCD60
        public void get_intervalEnd(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){}
    }

    public class IMarker
    {
        // ── Methods ──
        public void get_time(){} // RVA: 0x7FFAF2AC2A40
        public void set_time(){} // RVA: 0x7FFAF2AD6100
        public void get_parent(){} // RVA: 0x7FFAF2ABCD60
        public void Initialize(){} // RVA: 0x7FFAF2AD4B10
    }

    public class INotificationOptionProvider
    {
        // ── Methods ──
        public void get_flags(){} // RVA: 0x7FFAF2ABCC90
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7FFAF2AD4B10
        public void PopActiveGameObject(){} // RVA: 0x7FFAF2AD4A50
        public void AddFromClip(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void AddFromClips(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void AddFromName(){} // RVA: 0x7FFAF2ADDC60 | overloaded x5
        public void AddFromComponent(){} // RVA: 0x7FFAF2ADDC60
        public void AddObjectProperties(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x7FFAF2ADDC60
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x7FFAF2AD6100
        public void OnControlTimeStart(){} // RVA: 0x7FFAF2AD4A50
        public void OnControlTimeStop(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ITimelineClipAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7FFAF2ABD840
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IgnoreOnPlayableTrackAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class InfiniteRuntimeClip
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF34449A0
        public void get_intervalStart(){} // RVA: 0x7FFAF2FC9240
        public void get_intervalEnd(){} // RVA: 0x7FFAF9AE5620
        public void set_enable(){} // RVA: 0x7FFAF9AE5680
        public void EvaluateAt(){} // RVA: 0x7FFAF9AE5700
        public void DisableAt(){} // RVA: 0x7FFAF9AE5760
        public void .cctor(){} // RVA: 0x7FFAF9AE57D0
    }

    public class IntervalTreeNode
    {
    }

    public class IntervalTree`1
    {
        // ── Methods ──
        public void get_dirty(){} // RVA: 0x7FFAF2ABDBE0
        public void set_dirty(){} // RVA: 0x7FFAF2AD5130
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void IntersectsWith(){}
        public void IntersectsWithRange(){} // RVA: 0x7FFAF2D33FA0
        public void UpdateIntervals(){} // RVA: 0x7FFAF2AD4A50
        public void Query(){} // RVA: 0x7FFAF2D33FA0
        public void QueryRange(){} // RVA: 0x7FFAF2D33FA0
        public void Rebuild(){} // RVA: 0x7FFAF2AC4170 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class Marker
    {
        // ── Methods ──
        public void get_parent(){} // RVA: 0x7FFAF2DBB0C0
        public void set_parent(){} // RVA: 0x7FFAF2DBB0D0
        public void get_time(){} // RVA: 0x7FFAF441AD00
        public void set_time(){} // RVA: 0x7FFAF9AE69E0
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7FFAF9AE6A80
        public void OnInitialize(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class MarkerList
    {
        // ── Methods ──
        public void get_markers(){} // RVA: 0x7FFAF9AE6C20
        public void .ctor(){} // RVA: 0x7FFAF9AE6C40
        public void Add(){} // RVA: 0x7FFAF9AE6DC0
        public void Remove(){} // RVA: 0x7FFAF9AE7040 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF9AE7100
        public void Contains(){} // RVA: 0x7FFAF9AE7170
        public void GetMarkers(){} // RVA: 0x7FFAF9AE6C20
        public void get_Count(){} // RVA: 0x7FFAF9AE71D0
        public void get_Item(){} // RVA: 0x7FFAF9AE7220
        public void GetRawMarkerList(){} // RVA: 0x7FFAF4584690
        public void CreateMarker(){} // RVA: 0x7FFAF9AE72A0
        public void HasNotifications(){} // RVA: 0x7FFAF9AE75D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF2D8D310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF316D7E0
        public void BuildCache(){} // RVA: 0x7FFAF9AE75F0
    }

    public class MarkerTrack
    {
        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7FFAF9AE7950
        public void .ctor(){} // RVA: 0x7FFAF9AE7C20
    }

    public class MatchTargetFieldConstants
    {
        // ── Methods ──
        public void HasAny(){} // RVA: 0x7FFAF9AC6D00
        public void Toggle(){} // RVA: 0x7FFAF9AC6D70
        public void .cctor(){} // RVA: 0x7FFAF9AC6D80
    }

    public class MenuCategoryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9AEFF90
    }

    public class NotKeyableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NotificationUtilities
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFAF9AF5690 | overloaded x3
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7FFAF9AF5DD0
    }

    public class ParticleControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AEC9D0
        public void get_particleSystem(){} // RVA: 0x7FFAF2DBB0C0
        public void set_particleSystem(){} // RVA: 0x7FFAF2DBB0D0
        public void Initialize(){} // RVA: 0x7FFAF9AECCA0
        public void SetRandomSeed(){} // RVA: 0x7FFAF9AECD60
        public void PrepareFrame(){} // RVA: 0x7FFAF9AED070
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF9AED320
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AED320
        public void Simulate(){} // RVA: 0x7FFAF9AED330
        public void .ctor(){} // RVA: 0x7FFAF9AED500
    }

    public class PlayableTrack
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7FFAF9AEFD60
        public void .ctor(){} // RVA: 0x7FFAF9AEFED0
    }

    public class PrefabControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AED520
        public void get_prefabInstance(){} // RVA: 0x7FFAF2DA8380
        public void Initialize(){} // RVA: 0x7FFAF9AED750
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF9AEDB40
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF9AEDCC0
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AEDDE0
        public void SetHideFlagsRecursive(){} // RVA: 0x7FFAF9AEDEF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RuntimeClip
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAF9AE58C0
        public void get_duration(){} // RVA: 0x7FFAF9AE58F0
        public void .ctor(){} // RVA: 0x7FFAF9AE5910
        public void Create(){} // RVA: 0x7FFAF9AE5910
        public void get_clip(){} // RVA: 0x7FFAF2D907C0
        public void get_mixer(){} // RVA: 0x7FFAF8778940
        public void get_playable(){} // RVA: 0x7FFAF49AB630
        public void set_enable(){} // RVA: 0x7FFAF9AE59E0
        public void SetTime(){} // RVA: 0x7FFAF9AE5B40
        public void SetDuration(){} // RVA: 0x7FFAF9AE5BA0
        public void EvaluateAt(){} // RVA: 0x7FFAF9AE5C00
        public void DisableAt(){} // RVA: 0x7FFAF9AE5F50
    }

    public class RuntimeClipBase
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAF2AC2A40
        public void get_duration(){} // RVA: 0x7FFAF2AC2A40
        public void get_intervalStart(){} // RVA: 0x7FFAF9AE6160
        public void get_intervalEnd(){} // RVA: 0x7FFAF9AE6210
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RuntimeElement
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7FFAF2ABCD60
        public void get_intervalEnd(){} // RVA: 0x7FFAF2ABCD60
        public void get_intervalBit(){} // RVA: 0x7FFAF2DDA5C0
        public void set_intervalBit(){} // RVA: 0x7FFAF2D900C0
        public void set_enable(){} // RVA: 0x7FFAF2AD5130
        public void EvaluateAt(){}
        public void DisableAt(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ScheduleRuntimeClip
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAF9AE62E0
        public void get_duration(){} // RVA: 0x7FFAF9AE6390
        public void SetTime(){} // RVA: 0x7FFAF9AE63E0
        public void get_clip(){} // RVA: 0x7FFAF2D907C0
        public void get_mixer(){} // RVA: 0x7FFAF8778940
        public void get_playable(){} // RVA: 0x7FFAF49AB630
        public void .ctor(){} // RVA: 0x7FFAF9AE6440
        public void Create(){} // RVA: 0x7FFAF9AE6440
        public void set_enable(){} // RVA: 0x7FFAF9AE6520
        public void EvaluateAt(){} // RVA: 0x7FFAF9AE6640
        public void DisableAt(){} // RVA: 0x7FFAF9AE69C0
    }

    public class SignalAsset
    {
        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7FFAF9AE7C70
        public void remove_OnEnableCallback(){} // RVA: 0x7FFAF9AE7DA0
        public void OnEnable(){} // RVA: 0x7FFAF9AE7ED0
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SignalEmitter
    {
        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x7FFAF3198A80
        public void set_retroactive(){} // RVA: 0x7FFAF3198B80
        public void get_emitOnce(){} // RVA: 0x7FFAF36E6000
        public void set_emitOnce(){} // RVA: 0x7FFAF43BAB20
        public void get_asset(){} // RVA: 0x7FFAF30E74D0
        public void set_asset(){} // RVA: 0x7FFAF2DBB890
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7FFAF9AE7F30
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7FFAF9AE80D0
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SignalReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFAF9AE8100
        public void AddReaction(){} // RVA: 0x7FFAF9AE8300
        public void AddEmptyReaction(){} // RVA: 0x7FFAF9AE84C0
        public void Remove(){} // RVA: 0x7FFAF9AE8530
        public void GetRegisteredSignals(){} // RVA: 0x7FFAF3A4D710
        public void GetReaction(){} // RVA: 0x7FFAF9AE86B0
        public void Count(){} // RVA: 0x7FFAF9AE86F0
        public void ChangeSignalAtIndex(){} // RVA: 0x7FFAF9AE8740
        public void RemoveAtIndex(){} // RVA: 0x7FFAF9AE8C00
        public void ChangeReactionAtIndex(){} // RVA: 0x7FFAF9AE8D10
        public void GetReactionAtIndex(){} // RVA: 0x7FFAF9AE8E00
        public void GetSignalAssetAtIndex(){} // RVA: 0x7FFAF9AE8EE0
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF9AE8FC0
    }

    public class SignalTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9AE7C20
    }

    public class SupportsChildTracksAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50
    }

    public class TimeControlPlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AEE330
        public void Initialize(){} // RVA: 0x7FFAF2D8EE30
        public void PrepareFrame(){} // RVA: 0x7FFAF9AEE4F0
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF9AEE570
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AEE5D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TimeFieldAttribute
    {
        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0x7FFAF2DDA5C0
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class TimeNotificationBehaviour
    {
        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x7FFAF3BCC380
        public void Create(){} // RVA: 0x7FFAF9AEE630
        public void AddNotification(){} // RVA: 0x7FFAF9AEE830
        public void OnGraphStart(){} // RVA: 0x7FFAF9AEE930
        public void OnBehaviourPause(){} // RVA: 0x7FFAF9AEEB50
        public void PrepareFrame(){} // RVA: 0x7FFAF9AEEE20
        public void SortNotifications(){} // RVA: 0x7FFAF9AEF210
        public void CanRestoreNotification(){} // RVA: 0x7FFAF9AEF430
        public void TriggerNotificationsInRange(){} // RVA: 0x7FFAF9AEF470
        public void SyncDurationWithExternalSource(){} // RVA: 0x7FFAF9AEF720
        public void Trigger_internal(){} // RVA: 0x7FFAF9AEF9E0
        public void Restore_internal(){} // RVA: 0x7FFAF316DA00
        public void .ctor(){} // RVA: 0x7FFAF9AEFB80
    }

    public class TimeUtility
    {
        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7FFAF9AF7B80
        public void ToFrames(){} // RVA: 0x7FFAF9AF7C40
        public void ToExactFrames(){} // RVA: 0x7FFAF9AF7DB0
        public void FromFrames(){} // RVA: 0x7FFAF9AF7E90 | overloaded x2
        public void OnFrameBoundary(){} // RVA: 0x7FFAF9AF83A0 | overloaded x2
        public void GetEpsilon(){} // RVA: 0x7FFAF9AF8010
        public void PreviousFrame(){} // RVA: 0x7FFAF9AF8100
        public void NextFrame(){} // RVA: 0x7FFAF9AF81A0
        public void PreviousFrameTime(){} // RVA: 0x7FFAF9AF8210
        public void NextFrameTime(){} // RVA: 0x7FFAF9AF82F0
        public void RoundToFrame(){} // RVA: 0x7FFAF9AF8470
        public void TimeAsFrames(){} // RVA: 0x7FFAF9AF8570
        public void TimeAsTimeCode(){} // RVA: 0x7FFAF9AF8700
        public void ParseTimeCode(){} // RVA: 0x7FFAF9AF8E00
        public void ParseTimeSeconds(){} // RVA: 0x7FFAF9AF94E0
        public void GetAnimationClipLength(){} // RVA: 0x7FFAF9AF9A10
        public void RemoveChar(){} // RVA: 0x7FFAF9AF9C10
        public void GetClosestFrameRate(){} // RVA: 0x7FFAF9AF9CE0
        public void ToFrameRate(){} // RVA: 0x7FFAF9AF9F70
        public void ToStandardFrameRate(){} // RVA: 0x7FFAF9AFA160
        public void .cctor(){} // RVA: 0x7FFAF9AFA5D0
    }

    public class TimelineAsset
    {
        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAF2D8D310
        public void get_editorSettings(){} // RVA: 0x7FFAF2E08730
        public void get_duration(){} // RVA: 0x7FFAF9ACF690
        public void get_fixedDuration(){} // RVA: 0x7FFAF9ACF730
        public void set_fixedDuration(){} // RVA: 0x7FFAF9ACF850
        public void get_durationMode(){} // RVA: 0x7FFAF304C540
        public void set_durationMode(){} // RVA: 0x7FFAF310F570
        public void get_outputs(){} // RVA: 0x7FFAF9ACF8F0
        public void get_clipCaps(){} // RVA: 0x7FFAF9ACF9A0
        public void get_outputTrackCount(){} // RVA: 0x7FFAF9ACFB60
        public void get_rootTrackCount(){} // RVA: 0x7FFAF9ACFB90
        public void OnValidate(){} // RVA: 0x7FFAF9ACFBE0
        public void GetRootTrack(){} // RVA: 0x7FFAF9ACFC20
        public void GetRootTracks(){} // RVA: 0x7FFAF9ACFCA0
        public void GetOutputTrack(){} // RVA: 0x7FFAF9ACFCC0
        public void GetOutputTracks(){} // RVA: 0x7FFAF9ACFD10
        public void GetValidFrameRate(){} // RVA: 0x7FFAF9ACFD30
        public void UpdateRootTrackCache(){} // RVA: 0x7FFAF9ACFE20
        public void UpdateOutputTrackCache(){} // RVA: 0x7FFAF9AD02A0
        public void get_flattenedTracks(){} // RVA: 0x7FFAF9AD0540
        public void get_markerTrack(){} // RVA: 0x7FFAF2E55500
        public void get_trackObjects(){} // RVA: 0x7FFAF2DBB0C0
        public void AddTrackInternal(){} // RVA: 0x7FFAF9AD0750
        public void RemoveTrack(){} // RVA: 0x7FFAF9AD0800
        public void CreatePlayable(){} // RVA: 0x7FFAF9AD0980
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF3502E70
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF9AD0C50
        public void __internalAwake(){} // RVA: 0x7FFAF9AD0C60
        public void GatherProperties(){} // RVA: 0x7FFAF9AD0EC0
        public void CreateMarkerTrack(){} // RVA: 0x7FFAF9AD10D0
        public void RemoveMarkerTrack(){} // RVA: 0x7FFAF9AD12C0
        public void Invalidate(){} // RVA: 0x7FFAF9AD1400
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7FFAF9AD1500
        public void CalculateItemsDuration(){} // RVA: 0x7FFAF9AD15B0
        public void AddSubTracksRecursive(){} // RVA: 0x7FFAF9AD1830
        public void CreateTrack(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void DeleteClip(){} // RVA: 0x7FFAF9AD2030
        public void DeleteTrack(){} // RVA: 0x7FFAF9AD2410
        public void MoveLastTrackBefore(){} // RVA: 0x7FFAF9AD29D0
        public void AllocateTrack(){} // RVA: 0x7FFAF9AD2D60
        public void DeleteRecordedAnimation(){} // RVA: 0x7FFAF9AD34F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF9AD3790
    }

    public class TimelineClip
    {
        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAF9ACC630
        public void .ctor(){} // RVA: 0x7FFAF9ACC660
        public void get_hasPreExtrapolation(){} // RVA: 0x7FFAF9ACC690
        public void get_hasPostExtrapolation(){} // RVA: 0x7FFAF9ACC6B0
        public void get_timeScale(){} // RVA: 0x7FFAF9ACC6D0
        public void set_timeScale(){} // RVA: 0x7FFAF9ACC7E0
        public void get_start(){} // RVA: 0x7FFAF441AD00
        public void set_start(){} // RVA: 0x7FFAF9ACC900
        public void get_duration(){} // RVA: 0x7FFAF9995040
        public void set_duration(){} // RVA: 0x7FFAF9ACCB10
        public void get_end(){} // RVA: 0x7FFAF9ACCCD0
        public void get_clipIn(){} // RVA: 0x7FFAF9ACCCE0
        public void set_clipIn(){} // RVA: 0x7FFAF9ACCD10
        public void get_displayName(){} // RVA: 0x7FFAF2DF8040
        public void set_displayName(){} // RVA: 0x7FFAF2DF8050
        public void get_clipAssetDuration(){} // RVA: 0x7FFAF9ACCE30
        public void get_curves(){} // RVA: 0x7FFAF2DCC010
        public void set_curves(){} // RVA: 0x7FFAF2F13060
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFAF9ACCEA0
        public void get_hasCurves(){} // RVA: 0x7FFAF9ACCF00
        public void get_asset(){} // RVA: 0x7FFAF2DBB130
        public void set_asset(){} // RVA: 0x7FFAF2D8EE90
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFAF2E0A740
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFAF2E0A740
        public void get_underlyingAsset(){} // RVA: 0x7FFAF2FC9240
        public void set_underlyingAsset(){} // RVA: 0x7FFAF2D8D310
        public void get_parentTrack(){} // RVA: 0x7FFAF2E0A740
        public void set_parentTrack(){} // RVA: 0x7FFAF9ACD040
        public void GetParentTrack(){} // RVA: 0x7FFAF2E0A740
        public void SetParentTrack_Internal(){} // RVA: 0x7FFAF9ACD050
        public void get_easeInDuration(){} // RVA: 0x7FFAF9ACD310
        public void set_easeInDuration(){} // RVA: 0x7FFAF9ACD410
        public void get_easeOutDuration(){} // RVA: 0x7FFAF9ACD560
        public void set_easeOutDuration(){} // RVA: 0x7FFAF9ACD660
        public void get_eastOutTime(){} // RVA: 0x7FFAF9ACD7B0
        public void get_easeOutTime(){} // RVA: 0x7FFAF9ACD7B0
        public void get_blendInDuration(){} // RVA: 0x7FFAF9ACD7F0
        public void set_blendInDuration(){} // RVA: 0x7FFAF9ACD820
        public void get_blendOutDuration(){} // RVA: 0x7FFAF9ACD8C0
        public void set_blendOutDuration(){} // RVA: 0x7FFAF9ACD8F0
        public void get_blendInCurveMode(){} // RVA: 0x7FFAF4593800
        public void set_blendInCurveMode(){} // RVA: 0x7FFAF4596D80
        public void get_blendOutCurveMode(){} // RVA: 0x7FFAF4596E60
        public void set_blendOutCurveMode(){} // RVA: 0x7FFAF8CF8F70
        public void get_hasBlendIn(){} // RVA: 0x7FFAF9ACD990
        public void get_hasBlendOut(){} // RVA: 0x7FFAF9ACD9D0
        public void get_mixInCurve(){} // RVA: 0x7FFAF9ACDA10
        public void set_mixInCurve(){} // RVA: 0x7FFAF2E08D60
        public void get_mixInPercentage(){} // RVA: 0x7FFAF9ACDB20
        public void get_mixInDuration(){} // RVA: 0x7FFAF9ACDB40
        public void get_mixOutCurve(){} // RVA: 0x7FFAF9ACDC70
        public void set_mixOutCurve(){} // RVA: 0x7FFAF2E555A0
        public void get_mixOutTime(){} // RVA: 0x7FFAF9ACDD80
        public void get_mixOutDuration(){} // RVA: 0x7FFAF9ACDE00
        public void get_mixOutPercentage(){} // RVA: 0x7FFAF9ACDE70
        public void get_recordable(){} // RVA: 0x7FFAF3DFA670
        public void set_recordable(){} // RVA: 0x7FFAF3DF8E00
        public void get_exposedParameters(){} // RVA: 0x7FFAF9ACDEE0
        public void get_clipCaps(){} // RVA: 0x7FFAF9ACDFB0
        public void Hash(){} // RVA: 0x7FFAF9ACE050
        public void EvaluateMixOut(){} // RVA: 0x7FFAF9ACE180
        public void EvaluateMixIn(){} // RVA: 0x7FFAF9ACE2E0
        public void GetDefaultMixInCurve(){} // RVA: 0x7FFAF9ACE3D0
        public void GetDefaultMixOutCurve(){} // RVA: 0x7FFAF9ACE400
        public void ToLocalTime(){} // RVA: 0x7FFAF9ACE430
        public void ToLocalTimeUnbound(){} // RVA: 0x7FFAF9ACE600
        public void FromLocalTimeUnbound(){} // RVA: 0x7FFAF9ACE670
        public void get_animationClip(){} // RVA: 0x7FFAF9ACE6D0
        public void SanitizeTimeValue(){} // RVA: 0x7FFAF9ACE8A0
        public void get_postExtrapolationMode(){} // RVA: 0x7FFAF9ACEA00
        public void set_postExtrapolationMode(){} // RVA: 0x7FFAF9ACEA30
        public void get_preExtrapolationMode(){} // RVA: 0x7FFAF9ACEA70
        public void set_preExtrapolationMode(){} // RVA: 0x7FFAF9ACEAA0
        public void SetPostExtrapolationTime(){} // RVA: 0x7FFAF9ACEAE0
        public void SetPreExtrapolationTime(){} // RVA: 0x7FFAF9ACEAF0
        public void IsExtrapolatedTime(){} // RVA: 0x7FFAF9ACEB00
        public void IsPreExtrapolatedTime(){} // RVA: 0x7FFAF9ACEBB0
        public void IsPostExtrapolatedTime(){} // RVA: 0x7FFAF9ACEC10
        public void get_extrapolatedStart(){} // RVA: 0x7FFAF9ACEC80
        public void get_extrapolatedDuration(){} // RVA: 0x7FFAF9ACECA0
        public void GetExtrapolatedTime(){} // RVA: 0x7FFAF9ACEDA0
        public void CreateCurves(){} // RVA: 0x7FFAF9ACEEE0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF45A9470
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF9ACC630
        public void ToString(){} // RVA: 0x7FFAF9ACF070
        public void ConformEaseValues(){} // RVA: 0x7FFAF9ACF2C0
        public void CalculateEasingRatio(){} // RVA: 0x7FFAF9ACF420
        public void UpdateDirty(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9ACF510
    }

    public class TimelineClipCapsExtensions
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7FFAF9ADF9F0
        public void SupportsExtrapolation(){} // RVA: 0x7FFAF9ADFA20
        public void SupportsClipIn(){} // RVA: 0x7FFAF9ADFA50
        public void SupportsSpeedMultiplier(){} // RVA: 0x7FFAF9ADFA80
        public void SupportsBlending(){} // RVA: 0x7FFAF9ADFAB0
        public void HasAll(){} // RVA: 0x7FFAF433F1C0
        public void HasAny(){} // RVA: 0x7FFAF94B2210
    }

    public class TimelineClipExtensions
    {
        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7FFAF9AF5FD0
        public void TryMoveToTrack(){} // RVA: 0x7FFAF9AF6500
        public void MoveToTrack_Impl(){} // RVA: 0x7FFAF9AF6820
        public void .cctor(){} // RVA: 0x7FFAF9AF6AC0
    }

    public class TimelineCreateUtilities
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7FFAF9AF6B70
        public void SaveAssetIntoObject(){} // RVA: 0x7FFAF9AF6EC0
        public void RemoveAssetFromObject(){} // RVA: 0x7FFAF9AF7090
        public void CreateAnimationClipForTrack(){} // RVA: 0x7FFAF9AF71F0
        public void ValidateParentTrack(){} // RVA: 0x7FFAF9AF75D0
    }

    public class TimelineHelpURLAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TimelinePlayable
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9AF0040
        public void Compile(){} // RVA: 0x7FFAF9AF0460
        public void CompileTrackList(){} // RVA: 0x7FFAF9AF08D0
        public void CreateTrackOutput(){} // RVA: 0x7FFAF9AF0B90
        public void CreateTrackPlayable(){} // RVA: 0x7FFAF9AF1540
        public void PrepareFrame(){} // RVA: 0x7FFAF9AF1AE0
        public void Evaluate(){} // RVA: 0x7FFAF9AF1B30
        public void CacheTrack(){} // RVA: 0x7FFAF9AF22F0
        public void ForAOTCompilationOnly(){} // RVA: 0x7FFAF9AF2380
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7FFAF9AF23E0
        public void AddOutputWeightProcessor(){} // RVA: 0x7FFAF9AF2480
        public void AddEvaluateCallback(){} // RVA: 0x7FFAF9AF2700
        public void InvokeOutputCallbacks(){} // RVA: 0x7FFAF9AF2890
        public void TryGetCallbackList(){} // RVA: 0x7FFAF9AF3410
        public void .ctor(){} // RVA: 0x7FFAF9AF3600
        public void .cctor(){} // RVA: 0x7FFAF9AF3C80
    }

    public class TimelineUndo
    {
        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x7FFAF2D8D320
        public void PushDestroyUndo(){} // RVA: 0x7FFAF9AF7A40
        public void PushUndo(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7FFAF2D8D310
        public void UndoName(){} // RVA: 0x7FFAF9AF7B30
    }

    public class TrackAsset
    {
        // ── Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0x7FFAF2D8D310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7FFAF2D8D310
        public void OnUpgradeFromVersion(){} // RVA: 0x7FFAF2D8D310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF9AD4620
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF9AD4920
        public void UpgradeToLatestVersion(){} // RVA: 0x7FFAF2D8D310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7FFAF9AD4C30
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7FFAF9AD4D90
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFAF9AD4EF0
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7FFAF9AD5050
        public void get_start(){} // RVA: 0x7FFAF9AD51B0
        public void get_end(){} // RVA: 0x7FFAF9AD5250
        public void get_duration(){} // RVA: 0x7FFAF9AD52F0
        public void get_muted(){} // RVA: 0x7FFAF36E6000
        public void set_muted(){} // RVA: 0x7FFAF43BAB20
        public void get_mutedInHierarchy(){} // RVA: 0x7FFAF9AD53A0
        public void get_timelineAsset(){} // RVA: 0x7FFAF9AD5650
        public void get_parent(){} // RVA: 0x7FFAF2E0A740
        public void set_parent(){} // RVA: 0x7FFAF2DB5200
        public void GetClips(){} // RVA: 0x7FFAF9AD5930
        public void get_clips(){} // RVA: 0x7FFAF9AD5940
        public void get_blendsValid(){} // RVA: 0x7FFAF855EFD0
        public void set_blendsValid(){} // RVA: 0x7FFAF855EFE0
        public void get_isEmpty(){} // RVA: 0x7FFAF9AD5AA0
        public void get_hasClips(){} // RVA: 0x7FFAF9AD5B50
        public void get_hasCurves(){} // RVA: 0x7FFAF9AD5BA0
        public void get_isSubTrack(){} // RVA: 0x7FFAF9AD5CD0
        public void get_outputs(){} // RVA: 0x7FFAF9AD5E50
        public void GetChildTracks(){} // RVA: 0x7FFAF9AD5F00
        public void get_customPlayableTypename(){} // RVA: 0x7FFAF30E74D0
        public void set_customPlayableTypename(){} // RVA: 0x7FFAF2DBB890
        public void get_curves(){} // RVA: 0x7FFAF2F476A0
        public void set_curves(){} // RVA: 0x7FFAF2F4B830
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7FFAF9AD5F20
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7FFAF44EF520
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7FFAF9AD5F60
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7FFAF44EF520
        public void get_subTracksObjects(){} // RVA: 0x7FFAF2E08730
        public void get_locked(){} // RVA: 0x7FFAF3198A80
        public void set_locked(){} // RVA: 0x7FFAF3198B80
        public void get_lockedInHierarchy(){} // RVA: 0x7FFAF9AD5F70
        public void get_supportsNotifications(){} // RVA: 0x7FFAF9AD6220
        public void __internalAwake(){} // RVA: 0x7FFAF9AD62B0
        public void CreateCurves(){} // RVA: 0x7FFAF9AD6470
        public void CreateTrackMixer(){} // RVA: 0x7FFAF9AD65D0
        public void CreatePlayable(){} // RVA: 0x7FFAF9ADBB40 | overloaded x2
        public void CreateDefaultClip(){} // RVA: 0x7FFAF9AD67A0
        public void CreateClip(){} // RVA: 0x7FFAF9AD6D50 | overloaded x2
        public void DeleteClip(){} // RVA: 0x7FFAF9AD6AF0
        public void CreateMarker(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void DeleteMarker(){} // RVA: 0x7FFAF9AD6CB0
        public void GetMarkers(){} // RVA: 0x7FFAF9AD6CC0
        public void GetMarkerCount(){} // RVA: 0x7FFAF9AD6CF0
        public void GetMarker(){} // RVA: 0x7FFAF9AD6D40
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7FFAF9AD6E90
        public void CreateClipOfType(){} // RVA: 0x7FFAF9AD6ED0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7FFAF9AD71C0
        public void CreateClipFromAsset(){} // RVA: 0x7FFAF9AD74F0
        public void GetMarkersRaw(){} // RVA: 0x7FFAF2DCC010
        public void ClearMarkers(){} // RVA: 0x7FFAF9AD77B0
        public void AddMarker(){} // RVA: 0x7FFAF9AD7820
        public void DeleteMarkerRaw(){} // RVA: 0x7FFAF9AD7830
        public void GetTimeRangeHash(){} // RVA: 0x7FFAF9AD7870
        public void AddClip(){} // RVA: 0x7FFAF9AD7AD0
        public void CreateNotificationsPlayable(){} // RVA: 0x7FFAF9AD7C10
        public void CreatePlayableGraph(){} // RVA: 0x7FFAF9AD8120
        public void CompileClips(){} // RVA: 0x7FFAF9AD84C0
        public void GatherCompilableTracks(){} // RVA: 0x7FFAF9AD89B0
        public void GatherNotifications(){} // RVA: 0x7FFAF9AD8C90
        public void CreateMixerPlayableGraph(){} // RVA: 0x7FFAF9AD8FA0
        public void ConfigureTrackAnimation(){} // RVA: 0x7FFAF9AD9900
        public void SortClips(){} // RVA: 0x7FFAF9AD9A60
        public void ClearClipsInternal(){} // RVA: 0x7FFAF9AD9CE0
        public void ClearSubTracksInternal(){} // RVA: 0x7FFAF9AD9E00
        public void OnClipMove(){} // RVA: 0x7FFAF9AD9ED0
        public void CreateNewClipContainerInternal(){} // RVA: 0x7FFAF9AD9F30
        public void AddChild(){} // RVA: 0x7FFAF9ADA360
        public void MoveLastTrackBefore(){} // RVA: 0x7FFAF9ADA4B0
        public void RemoveSubTrack(){} // RVA: 0x7FFAF9ADA840
        public void RemoveClip(){} // RVA: 0x7FFAF9ADA920
        public void GetEvaluationTime(){} // RVA: 0x7FFAF9ADA9F0
        public void GetSequenceTime(){} // RVA: 0x7FFAF9ADAC40
        public void GatherProperties(){} // RVA: 0x7FFAF9ADAC60
        public void GetGameObjectBinding(){} // RVA: 0x7FFAF9ADB320
        public void ValidateClipType(){} // RVA: 0x7FFAF9ADB610
        public void OnCreateClip(){} // RVA: 0x7FFAF2D8D310
        public void UpdateDuration(){} // RVA: 0x7FFAF9ADB920
        public void CalculateItemsHash(){} // RVA: 0x7FFAF9ADBA90
        public void Invalidate(){} // RVA: 0x7FFAF9ADBEE0
        public void GetNotificationDuration(){} // RVA: 0x7FFAF9ADC010
        public void CanCompileClips(){} // RVA: 0x7FFAF9ADC210
        public void CanCreateTrackMixer(){} // RVA: 0x7FFAF896C7C0
        public void IsCompilable(){} // RVA: 0x7FFAF9ADC270
        public void UpdateChildTrackCache(){} // RVA: 0x7FFAF9ADC570
        public void Hash(){} // RVA: 0x7FFAF9ADC8B0
        public void GetClipsHash(){} // RVA: 0x7FFAF9ADC930
        public void GetAnimationClipHash(){} // RVA: 0x7FFAF9ADCBD0
        public void HasNotifications(){} // RVA: 0x7FFAF9ADCDC0
        public void CanCompileNotifications(){} // RVA: 0x7FFAF9ADCDF0
        public void CanCreateMixerRecursive(){} // RVA: 0x7FFAF9ADCE30
        public void .ctor(){} // RVA: 0x7FFAF9ADCFD0
        public void .cctor(){} // RVA: 0x7FFAF9ADD1B0
    }

    public class TrackAssetExtensions
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7FFAF9AE9780
        public void SetGroup(){} // RVA: 0x7FFAF9AE98B0
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7FFAF9AEA040
    }

    public class TrackBindingTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50 | overloaded x2
    }

    public class TrackClipTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
    }

    public class TrackColorAttribute
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFAF441ABE0
        public void .ctor(){} // RVA: 0x7FFAF9ADDD70
    }

    public class TrackMediaType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class WeightUtility
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7FFAF9AFA7D0
    }

}