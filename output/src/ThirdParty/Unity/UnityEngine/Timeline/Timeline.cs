// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Timeline
// Classes: 78
// Methods: 765

namespace ThirdParty.Unity.UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE19040
        public void OnBehaviourPlay(){} // RVA: 0x7AEE192C0
        public void OnBehaviourPause(){} // RVA: 0x7AEE193E0
        public void ProcessFrame(){} // RVA: 0x7AEE194E0
        public void OnGraphStart(){} // RVA: 0x7AEE19600
        public void OnPlayableDestroy(){} // RVA: 0x7AEE19730
        public void .ctor(){} // RVA: 0x7AEBB67C0
    }

    public class ActivationMixerPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEDF25A0
        public void get_postPlaybackState(){} // RVA: 0x7A8124910
        public void set_postPlaybackState(){} // RVA: 0x7A80DA0C0
        public void OnPlayableDestroy(){} // RVA: 0x7AEDF2640
        public void ProcessFrame(){} // RVA: 0x7AEDF2770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ActivationPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7A82D1450
        public void CreatePlayable(){} // RVA: 0x7AEDF2AE0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class ActivationTrack : TrackAsset
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7AEDF2C00
        public void get_postPlaybackState(){} // RVA: 0x7A9B79A40
        public void set_postPlaybackState(){} // RVA: 0x7AEDF2C90
        public void CreateTrackMixer(){} // RVA: 0x7AEDF2CB0
        public void UpdateTrackMode(){} // RVA: 0x7AEDF2F00
        public void GatherProperties(){} // RVA: 0x7AEDF2F20
        public void OnCreateClip(){} // RVA: 0x7AEDF3040
        public void .ctor(){} // RVA: 0x7AEDF30D0
    }

    public class AnimationOutputWeightProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEDF3130
        public void FindMixers(){} // RVA: 0x7AEDF3520
        public void Evaluate(){} // RVA: 0x7AEDF3930
    }

    public class AnimationPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7A813E480
        public void set_position(){} // RVA: 0x7A813E4A0
        public void get_rotation(){} // RVA: 0x7AEDF3BB0
        public void set_rotation(){} // RVA: 0x7AEDF3C60
        public void get_eulerAngles(){} // RVA: 0x7A813E4B0
        public void set_eulerAngles(){} // RVA: 0x7A813E4D0
        public void get_useTrackMatchFields(){} // RVA: 0x7A82A20A0
        public void set_useTrackMatchFields(){} // RVA: 0x7A82A2C90
        public void get_matchTargetFields(){} // RVA: 0x7A864E8D0
        public void set_matchTargetFields(){} // RVA: 0x7A9ABBD00
        public void get_removeStartOffset(){} // RVA: 0x7A8193790
        public void set_removeStartOffset(){} // RVA: 0x7A81937A0
        public void get_applyFootIK(){} // RVA: 0x7A83F3AD0
        public void set_applyFootIK(){} // RVA: 0x7A83F3AC0
        public void get_loop(){} // RVA: 0x7A8178B50
        public void set_loop(){} // RVA: 0x7A8178B60
        public void get_hasRootTransforms(){} // RVA: 0x7AEDF3C90
        public void get_appliedOffsetMode(){} // RVA: 0x7A8178B70
        public void set_appliedOffsetMode(){} // RVA: 0x7A8178B80
        public void get_clip(){} // RVA: 0x7A80DA7B0
        public void set_clip(){} // RVA: 0x7AEDF3DA0
        public void get_duration(){} // RVA: 0x7AEDF3EF0
        public void get_outputs(){} // RVA: 0x7AEDF3FA0
        public void CreatePlayable(){} // RVA: 0x7AEDF4180
        public void ShouldApplyOffset(){} // RVA: 0x7AEDF4A70
        public void ShouldApplyScaleRemove(){} // RVA: 0x7AEDF4AE0
        public void get_clipCaps(){} // RVA: 0x7AEDF4B00
        public void ResetOffsets(){} // RVA: 0x7AEDF4CF0
        public void GatherProperties(){} // RVA: 0x7AEDF4D80
        public void HasRootTransforms(){} // RVA: 0x7AEDF4E50
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AEDF4FE0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AEDF5040
        public void OnUpgradeFromVersion(){} // RVA: 0x7AEDF50D0
        public void .ctor(){} // RVA: 0x7AEDF5110
        public void .cctor(){} // RVA: 0x7AEDF5230
    }

    public class AnimationPreviewUpdateCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEDF5520
        public void Evaluate(){} // RVA: 0x7AEDF55E0
        public void FetchPreviewComponents(){} // RVA: 0x7AEDF5860
    }

    public class AnimationTrack : TrackAsset
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7ABBEC980
        public void set_position(){} // RVA: 0x7ABBEC9A0
        public void get_rotation(){} // RVA: 0x7AEDF5BB0
        public void set_rotation(){} // RVA: 0x7AEDF5C60
        public void get_eulerAngles(){} // RVA: 0x7AEDF5C90
        public void set_eulerAngles(){} // RVA: 0x7AEDF5CB0
        public void get_applyOffsets(){} // RVA: 0x7A80D7320
        public void set_applyOffsets(){} // RVA: 0x7A80D7310
        public void get_trackOffset(){} // RVA: 0x7A8F96260
        public void set_trackOffset(){} // RVA: 0x7AEDF5CD0
        public void get_matchTargetFields(){} // RVA: 0x7A880E690
        public void set_matchTargetFields(){} // RVA: 0x7AEDF5CE0
        public void get_infiniteClip(){} // RVA: 0x7A8852A30
        public void set_infiniteClip(){} // RVA: 0x7A8AB8FD0
        public void get_infiniteClipRemoveOffset(){} // RVA: 0x7A9021760
        public void set_infiniteClipRemoveOffset(){} // RVA: 0x7A90226D0
        public void get_avatarMask(){} // RVA: 0x7A8142870
        public void set_avatarMask(){} // RVA: 0x7A8142880
        public void get_applyAvatarMask(){} // RVA: 0x7A8F95560
        public void set_applyAvatarMask(){} // RVA: 0x7AEDF5D50
        public void CanCompileClips(){} // RVA: 0x7AEDF5D60
        public void get_outputs(){} // RVA: 0x7AEDF5EA0
        public void get_inClipMode(){} // RVA: 0x7AEDF5F50
        public void get_infiniteClipOffsetPosition(){} // RVA: 0x7AEDF5F90
        public void set_infiniteClipOffsetPosition(){} // RVA: 0x7AEDF5FB0
        public void get_infiniteClipOffsetRotation(){} // RVA: 0x7AEDF5FD0
        public void set_infiniteClipOffsetRotation(){} // RVA: 0x7AEDF6080
        public void get_infiniteClipOffsetEulerAngles(){} // RVA: 0x7AEDF60B0
        public void set_infiniteClipOffsetEulerAngles(){} // RVA: 0x7AEDF60D0
        public void get_infiniteClipApplyFootIK(){} // RVA: 0x7A90F9F50
        public void set_infiniteClipApplyFootIK(){} // RVA: 0x7ADFA4E10
        public void get_infiniteClipTimeOffset(){} // RVA: 0x7AEDF60F0
        public void set_infiniteClipTimeOffset(){} // RVA: 0x7AEDF6100
        public void get_infiniteClipPreExtrapolation(){} // RVA: 0x7A9B79A40
        public void set_infiniteClipPreExtrapolation(){} // RVA: 0x7A9B79A00
        public void get_infiniteClipPostExtrapolation(){} // RVA: 0x7ABA390E0
        public void set_infiniteClipPostExtrapolation(){} // RVA: 0x7ABA390F0
        public void get_infiniteClipLoop(){} // RVA: 0x7A961A4D0
        public void set_infiniteClipLoop(){} // RVA: 0x7ADF1BDC0
        public void ResetOffsets(){} // RVA: 0x7AEDF6110
        public void CreateClip(){} // RVA: 0x7AEDF61B0
        public void CreateInfiniteClip(){} // RVA: 0x7AEDF62D0
        public void CreateRecordableClip(){} // RVA: 0x7AEDF64B0
        public void OnCreateClip(){} // RVA: 0x7AEDF6790
        public void CalculateItemsHash(){} // RVA: 0x7AEDF6800
        public void UpdateClipOffsets(){} // RVA: 0x7A80D7310
        public void CompileTrackPlayable(){} // RVA: 0x7AEDF6910
        public void UnityEngine.Timeline.ILayerable.CreateLayerMixer(){} // RVA: 0x7AEDF6F30
        public void CreateMixerPlayableGraph(){} // RVA: 0x7AEDF6FD0
        public void GetDefaultBlendCount(){} // RVA: 0x7A82D1450
        public void AttachDefaultBlend(){} // RVA: 0x7A80D7310
        public void AttachOffsetPlayable(){} // RVA: 0x7AEDF7BC0
        public void RequiresMotionXPlayable(){} // RVA: 0x7AEDF7DA0
        public void UsesAbsoluteMotion(){} // RVA: 0x7AEDF7F80
        public void HasController(){} // RVA: 0x7AEDF7F90
        public void GetBinding(){} // RVA: 0x7AEDF8220
        public void CreateGroupMixer(){} // RVA: 0x7AEDF8600
        public void CreateInfiniteTrackPlayable(){} // RVA: 0x7AEDF86F0
        public void ApplyTrackOffset(){} // RVA: 0x7AEDF8C50
        public void GetEvaluationTime(){} // RVA: 0x7AEDF8EE0
        public void GetSequenceTime(){} // RVA: 0x7AEDF8FB0
        public void AssignAnimationClip(){} // RVA: 0x7AEDF9100
        public void GatherProperties(){} // RVA: 0x7A80D7310
        public void GetAnimationClips(){} // RVA: 0x7AEDF9570
        public void GetOffsetMode(){} // RVA: 0x7AEDF9B90
        public void IsRootTransformDisabledByMask(){} // RVA: 0x7AEDF9CC0
        public void GetGenericRootNode(){} // RVA: 0x7AEDFA2A0
        public void AnimatesRootTransform(){} // RVA: 0x7AEDFA680
        public void FindInHierarchyBreadthFirst(){} // RVA: 0x7AEDFA960
        public void get_openClipOffsetPosition(){} // RVA: 0x7AEDF5F90
        public void set_openClipOffsetPosition(){} // RVA: 0x7AEDF5FB0
        public void get_openClipOffsetRotation(){} // RVA: 0x7AEDF5FD0
        public void set_openClipOffsetRotation(){} // RVA: 0x7AEDFABA0
        public void get_openClipOffsetEulerAngles(){} // RVA: 0x7AEDF60B0
        public void set_openClipOffsetEulerAngles(){} // RVA: 0x7AEDF60D0
        public void get_openClipPreExtrapolation(){} // RVA: 0x7A9B79A40
        public void set_openClipPreExtrapolation(){} // RVA: 0x7A9B79A00
        public void get_openClipPostExtrapolation(){} // RVA: 0x7ABA390E0
        public void set_openClipPostExtrapolation(){} // RVA: 0x7ABA390F0
        public void OnUpgradeFromVersion(){} // RVA: 0x7AEDFABE0
        public void .ctor(){} // RVA: 0x7AEDFADD0
        public void .cctor(){} // RVA: 0x7AEDFB000
    }

    public class AudioClipProperties : PlayableBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE0CDD0
    }

    public class AudioMixerProperties : PlayableBehaviour
    {
        // ── Methods ──
        public void PrepareFrame(){} // RVA: 0x7AEE0CDE0
        public void .ctor(){} // RVA: 0x7AEE0CDD0
    }

    public class AudioPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_bufferingTime(){} // RVA: 0x7A82461C0
        public void set_bufferingTime(){} // RVA: 0x7A82461D0
        public void get_clip(){} // RVA: 0x7A80DA7B0
        public void set_clip(){} // RVA: 0x7A813E420
        public void get_loop(){} // RVA: 0x7A81C68D0
        public void set_loop(){} // RVA: 0x7A81C68E0
        public void get_duration(){} // RVA: 0x7AEE0D1D0
        public void get_outputs(){} // RVA: 0x7AEE0D3D0
        public void CreatePlayable(){} // RVA: 0x7AEE0D480
        public void get_clipCaps(){} // RVA: 0x7AEE0D700
        public void .ctor(){} // RVA: 0x7AEE0D710
    }

    public class AudioTrack : TrackAsset
    {
        // ── Methods ──
        public void CreateClip(){} // RVA: 0x7AEE0DA10
        public void CompileClips(){} // RVA: 0x7AEE0DD10
        public void get_outputs(){} // RVA: 0x7AEE0E680
        public void OnValidate(){} // RVA: 0x7AEE0E730
        public void .ctor(){} // RVA: 0x7AEE0E7D0
    }

    public class BasicPlayableBehaviour : ScriptableObject
    {
        // ── Methods ──
        public void get_duration(){} // RVA: 0x7AEE19870
        public void get_outputs(){} // RVA: 0x7AEE198D0
        public void OnGraphStart(){} // RVA: 0x7A80D7310
        public void OnGraphStop(){} // RVA: 0x7A80D7310
        public void OnPlayableCreate(){} // RVA: 0x7A80D7310
        public void OnPlayableDestroy(){} // RVA: 0x7A80D7310
        public void OnBehaviourPlay(){} // RVA: 0x7A80D7310
        public void OnBehaviourPause(){} // RVA: 0x7A80D7310
        public void PrepareFrame(){} // RVA: 0x7A80D7310
        public void ProcessFrame(){} // RVA: 0x7A80D7310
        public void CreatePlayable(){} // RVA: 0x7AEE19930
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class BlendUtility : Object
    {
        // ── Methods ──
        public void Overlaps(){} // RVA: 0x7AEE22F90
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7AEE230D0
        public void UpdateClipIntersection(){} // RVA: 0x7AEE23540
        public void .cctor(){} // RVA: 0x7AEE23730
    }

    public class ControlPlayableAsset : PlayableAsset
    {
        // ── Methods ──
        public void get_controllingDirectors(){} // RVA: 0x7ACDBE8E0
        public void set_controllingDirectors(){} // RVA: 0x7ADE0AE10
        public void get_controllingParticles(){} // RVA: 0x7A83601B0
        public void set_controllingParticles(){} // RVA: 0x7A8358DA0
        public void OnEnable(){} // RVA: 0x7AEE0EAF0
        public void get_duration(){} // RVA: 0x7AC154B90
        public void get_clipCaps(){} // RVA: 0x7AEE0EB50
        public void CreatePlayable(){} // RVA: 0x7AEE0EB60
        public void ConnectPlayablesToMixer(){} // RVA: 0x7AEE0F9A0
        public void CreateActivationPlayable(){} // RVA: 0x7AEE0FDF0
        public void SearchHierarchyAndConnectParticleSystem(){} // RVA: 0x7AEE0FFB0
        public void SearchHierarchyAndConnectDirector(){} // RVA: 0x7AEE103B0
        public void SearchHierarchyAndConnectControlableScripts(){} // RVA: 0x7AEE10920
        public void ConnectMixerAndPlayable(){} // RVA: 0x7AEE10C90
        public void GetComponent(){} // RVA: 0x7A7E00B20
        public void GetControlableScripts(){} // RVA: 0x7AEE10DD0
        public void UpdateDurationAndLoopFlag(){} // RVA: 0x7AEE10E80
        public void GetControllableParticleSystems(){} // RVA: 0x7AEE11980
        public void CacheSubEmitters(){} // RVA: 0x7AEE11C80
        public void GatherProperties(){} // RVA: 0x7AEE11F10
        public void PreviewParticles(){} // RVA: 0x7AEE12320
        public void PreviewActivation(){} // RVA: 0x7AEE12770
        public void PreviewTimeControl(){} // RVA: 0x7AEE12A00
        public void PreviewDirectors(){} // RVA: 0x7AEE12C50
        public void .ctor(){} // RVA: 0x7AEE12FE0
        public void .cctor(){} // RVA: 0x7AEE13060
    }

    public class ControlTrack : TrackAsset
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE137B0
    }

    public class CurveEditUtility : Object
    {
        // ── Methods ──
        public void CreateMatchingCurve(){} // RVA: 0x7AEE13800
    }

    public class CustomSignalEventDrawer : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CustomStyleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class DirectorControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE19AF0
        public void OnPlayableDestroy(){} // RVA: 0x7AEE19D50
        public void PrepareFrame(){} // RVA: 0x7AEE19F20
        public void OnBehaviourPlay(){} // RVA: 0x7AEE1A210
        public void OnBehaviourPause(){} // RVA: 0x7AEE1A3D0
        public void ProcessFrame(){} // RVA: 0x7AEE1A5A0
        public void SyncSpeed(){} // RVA: 0x7AEE1AB10
        public void SyncStart(){} // RVA: 0x7AEE1AEF0
        public void SyncStop(){} // RVA: 0x7AEE1B0B0
        public void DetectDiscontinuity(){} // RVA: 0x7AEE1B290
        public void DetectOutOfSync(){} // RVA: 0x7AEE1B4C0
        public void UpdateTime(){} // RVA: 0x7AEE1B620
        public void .ctor(){} // RVA: 0x7AEE1B860
    }

    public class DiscreteTime : ValueType
    {
        // ── Methods ──
        public void get_tickValue(){} // RVA: 0x7AEE13980
        public void .ctor(){} // RVA: 0x7A7EC2E70
        public void OneTickBefore(){} // RVA: 0x7A7EC2EF0
        public void OneTickAfter(){} // RVA: 0x7A7EC2F00
        public void GetTick(){} // RVA: 0x7A765F710
        public void FromTicks(){} // RVA: 0x7A97F8BA0
        public void CompareTo(){} // RVA: 0x7A7EC2F10
        public void Equals(){} // RVA: 0x7A7EC2FC0
        public void DoubleToDiscreteTime(){} // RVA: 0x7AEE13CE0
        public void FloatToDiscreteTime(){} // RVA: 0x7AEE13D70
        public void IntToDiscreteTime(){} // RVA: 0x7AEE13E00
        public void ToDouble(){} // RVA: 0x7AEE13E60
        public void ToFloat(){} // RVA: 0x7AEE13E80
        public void op_Explicit(){} // RVA: 0x7A97F8BA0
        public void op_Implicit(){} // RVA: 0x7AEE14090
        public void op_Equality(){} // RVA: 0x7AA68A530
        public void op_Inequality(){} // RVA: 0x7AEE14120
        public void op_GreaterThan(){} // RVA: 0x7ADCA8030
        public void op_LessThan(){} // RVA: 0x7ADCA8010
        public void op_LessThanOrEqual(){} // RVA: 0x7ADCA8020
        public void op_GreaterThanOrEqual(){} // RVA: 0x7ADCA8040
        public void op_Addition(){} // RVA: 0x7AA68A420
        public void op_Subtraction(){} // RVA: 0x7AEE14180
        public void ToString(){} // RVA: 0x7A7EC3060
        public void GetHashCode(){} // RVA: 0x7A7EC3100
        public void Min(){} // RVA: 0x7AEE14240
        public void Max(){} // RVA: 0x7AEE142A0
        public void SnapToNearestTick(){} // RVA: 0x7AEE14370
        public void GetNearestTick(){} // RVA: 0x7AEE14420
        public void .cctor(){} // RVA: 0x7AEE14480
    }

    public class Extrapolation : Object
    {
        // ── Methods ──
        public void CalculateExtrapolationTimes(){} // RVA: 0x7AEE239D0
        public void SortClipsByStartTime(){} // RVA: 0x7AEE23ED0
        public void .cctor(){} // RVA: 0x7AEE241E0
    }

    public class FrameRateFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GroupTrack : TrackAsset
    {
        // ── Methods ──
        public void CanCompileClips(){} // RVA: 0x7A80D7320
        public void get_outputs(){} // RVA: 0x7AEE18F90
        public void .ctor(){} // RVA: 0x7AEE18FF0
    }

    public class HashUtility : Object
    {
        // ── Methods ──
        public void CombineHash(){} // RVA: 0x7AEE24560
    }

    public class HideInMenuAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ICurvesOwner
    {
        // ── Methods ──
        public void get_curves(){} // RVA: 0x7A7E00680
        public void get_hasCurves(){} // RVA: 0x7A7E01900
        public void get_duration(){} // RVA: 0x7A7E06760
        public void CreateCurves(){} // RVA: 0x7A7E18800
        public void get_defaultCurvesName(){} // RVA: 0x7A7E00680
        public void get_asset(){} // RVA: 0x7A7E00680
        public void get_assetOwner(){} // RVA: 0x7A7E00680
        public void get_targetTrack(){} // RVA: 0x7A7E00680
    }

    public class IInterval
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7A7E00680
        public void get_intervalEnd(){} // RVA: 0x7A7E00680
    }

    public class ILayerable
    {
        // ── Methods ──
        public void CreateLayerMixer(){} // RVA: 0x7A7E10270
    }

    public class IMarker
    {
        // ── Methods ──
        public void get_time(){} // RVA: 0x7A7E06760
        public void set_time(){} // RVA: 0x7A7E19E10
        public void get_parent(){} // RVA: 0x7A7E00680
        public void Initialize(){} // RVA: 0x7A7E18800
    }

    public class INotificationOptionProvider
    {
        // ── Methods ──
        public void get_flags(){} // RVA: 0x7A7E006E0
    }

    public class IPropertyCollector
    {
        // ── Methods ──
        public void PushActiveGameObject(){} // RVA: 0x7A7E18800
        public void PopActiveGameObject(){} // RVA: 0x7A7E18770
        public void AddFromClip(){} // RVA: 0x7A7E18890
        public void AddFromClips(){} // RVA: 0x7A7E18890
        public void AddFromName(){} // RVA: 0x7A7E18890
        public void AddFromComponent(){} // RVA: 0x7A7E18890
        public void AddObjectProperties(){} // RVA: 0x7A7E18890
    }

    public class IPropertyPreview
    {
        // ── Methods ──
        public void GatherProperties(){} // RVA: 0x7A7E18890
    }

    public class ITimeControl
    {
        // ── Methods ──
        public void SetTime(){} // RVA: 0x7A7E19E10
        public void OnControlTimeStart(){} // RVA: 0x7A7E18770
        public void OnControlTimeStop(){} // RVA: 0x7A7E18770
    }

    public class ITimelineClipAsset
    {
        // ── Methods ──
        public void get_clipCaps(){} // RVA: 0x7A7E00710
    }

    public class ITimelineEvaluateCallback
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7A7E18770
    }

    public class IgnoreOnPlayableTrackAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InfiniteRuntimeClip : RuntimeElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A872E9B0
        public void get_intervalStart(){} // RVA: 0x7A82D1450
        public void get_intervalEnd(){} // RVA: 0x7AEE144D0
        public void set_enable(){} // RVA: 0x7AEE14530
        public void EvaluateAt(){} // RVA: 0x7AEE145B0
        public void DisableAt(){} // RVA: 0x7AEE14610
        public void .cctor(){} // RVA: 0x7AEE14680
    }

    public class IntervalTree`1 : Object
    {
        // ── Methods ──
        public void get_dirty(){} // RVA: 0x7A7E01900
        public void set_dirty(){} // RVA: 0x7A7E18C30
        public void Add(){} // RVA: 0x7A8051B10
        public void IntersectsWith(){} // RVA: 0x7A7E18CB0
        public void IntersectsWithRange(){} // RVA: 0x7A8051B10
        public void UpdateIntervals(){} // RVA: 0x7A7E18770
        public void Query(){} // RVA: 0x7A8051B10
        public void QueryRange(){} // RVA: 0x7A8051B10
        public void Rebuild(){} // RVA: 0x7A7E076F0
        public void Clear(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Marker : ScriptableObject
    {
        // ── Methods ──
        public void get_parent(){} // RVA: 0x7A81052C0
        public void set_parent(){} // RVA: 0x7A81052D0
        public void get_time(){} // RVA: 0x7A9727910
        public void set_time(){} // RVA: 0x7AEE15880
        public void UnityEngine.Timeline.IMarker.Initialize(){} // RVA: 0x7AEE15920
        public void OnInitialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class MarkerList : ValueType
    {
        // ── Methods ──
        public void get_markers(){} // RVA: 0x7A7EC3130
        public void .ctor(){} // RVA: 0x7A7EC3150
        public void Add(){} // RVA: 0x7A7EC3160
        public void Remove(){} // RVA: 0x7A7EC3180
        public void Clear(){} // RVA: 0x7A7EC3190
        public void Contains(){} // RVA: 0x7A7EC31A0
        public void GetMarkers(){} // RVA: 0x7A7EC3130
        public void get_Count(){} // RVA: 0x7A7EC3200
        public void get_Item(){} // RVA: 0x7A7EC3250
        public void GetRawMarkerList(){} // RVA: 0x7A765F710
        public void CreateMarker(){} // RVA: 0x7A7EC3260
        public void HasNotifications(){} // RVA: 0x7A7EC3270
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A75F4910
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A7EC3290
        public void BuildCache(){} // RVA: 0x7A7EC32A0
    }

    public class MarkerTrack : TrackAsset
    {
        // ── Methods ──
        public void get_outputs(){} // RVA: 0x7AEE16820
        public void .ctor(){} // RVA: 0x7AEE16AF0
    }

    public class MatchTargetFieldConstants : Object
    {
        // ── Methods ──
        public void HasAny(){} // RVA: 0x7AEDF5AB0
        public void Toggle(){} // RVA: 0x7AEDF5B20
        public void .cctor(){} // RVA: 0x7AEDF5B30
    }

    public class MenuCategoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE1EE90
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NotificationUtilities : Object
    {
        // ── Methods ──
        public void CreateNotificationsPlayable(){} // RVA: 0x7AEE24660
        public void TrackTypeSupportsNotifications(){} // RVA: 0x7AEE24DE0
    }

    public class ParticleControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE1B870
        public void get_particleSystem(){} // RVA: 0x7A81052C0
        public void set_particleSystem(){} // RVA: 0x7A81052D0
        public void Initialize(){} // RVA: 0x7AEE1BB40
        public void SetRandomSeed(){} // RVA: 0x7AEE1BC00
        public void PrepareFrame(){} // RVA: 0x7AEE1BF10
        public void OnBehaviourPlay(){} // RVA: 0x7AEE1C1C0
        public void OnBehaviourPause(){} // RVA: 0x7AEE1C1C0
        public void Simulate(){} // RVA: 0x7AEE1C1D0
        public void .ctor(){} // RVA: 0x7AEE1C3A0
    }

    public class PlayableTrack : TrackAsset
    {
        // ── Methods ──
        public void OnCreateClip(){} // RVA: 0x7AEE1EC60
        public void .ctor(){} // RVA: 0x7AEE1EDD0
    }

    public class PrefabControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE1C3C0
        public void get_prefabInstance(){} // RVA: 0x7A80F2570
        public void Initialize(){} // RVA: 0x7AEE1C600
        public void OnPlayableDestroy(){} // RVA: 0x7AEE1C9F0
        public void OnBehaviourPlay(){} // RVA: 0x7AEE1CB70
        public void OnBehaviourPause(){} // RVA: 0x7AEE1CC90
        public void SetHideFlagsRecursive(){} // RVA: 0x7AEE1CD90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RuntimeClip : RuntimeClipBase
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7AEE14770
        public void get_duration(){} // RVA: 0x7AEE147A0
        public void .ctor(){} // RVA: 0x7AEE147C0
        public void Create(){} // RVA: 0x7AEE147C0
        public void get_clip(){} // RVA: 0x7A80DA7B0
        public void get_mixer(){} // RVA: 0x7ADAB6B40
        public void get_playable(){} // RVA: 0x7A9D01C90
        public void set_enable(){} // RVA: 0x7AEE14890
        public void SetTime(){} // RVA: 0x7AEE149F0
        public void SetDuration(){} // RVA: 0x7AEE14A50
        public void EvaluateAt(){} // RVA: 0x7AEE14AB0
        public void DisableAt(){} // RVA: 0x7AEE14E00
    }

    public class RuntimeClipBase : RuntimeElement
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7A7E06760
        public void get_duration(){} // RVA: 0x7A7E06760
        public void get_intervalStart(){} // RVA: 0x7AEE15000
        public void get_intervalEnd(){} // RVA: 0x7AEE150B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RuntimeElement : Object
    {
        // ── Methods ──
        public void get_intervalStart(){} // RVA: 0x7A7E00680
        public void get_intervalEnd(){} // RVA: 0x7A7E00680
        public void get_intervalBit(){} // RVA: 0x7A8124910
        public void set_intervalBit(){} // RVA: 0x7A80DA0C0
        public void set_enable(){} // RVA: 0x7A7E18C30
        public void EvaluateAt(){} // RVA: 0x7A7E19F20
        public void DisableAt(){} // RVA: 0x7A7E19ED0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ScheduleRuntimeClip : RuntimeClipBase
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x7AEE15180
        public void get_duration(){} // RVA: 0x7AEE15230
        public void SetTime(){} // RVA: 0x7AEE15280
        public void get_clip(){} // RVA: 0x7A80DA7B0
        public void get_mixer(){} // RVA: 0x7ADAB6B40
        public void get_playable(){} // RVA: 0x7A9D01C90
        public void .ctor(){} // RVA: 0x7AEE152E0
        public void Create(){} // RVA: 0x7AEE152E0
        public void set_enable(){} // RVA: 0x7AEE153C0
        public void EvaluateAt(){} // RVA: 0x7AEE154E0
        public void DisableAt(){} // RVA: 0x7AEE15860
    }

    public class SignalAsset : ScriptableObject
    {
        // ── Methods ──
        public void add_OnEnableCallback(){} // RVA: 0x7AEE16B40
        public void remove_OnEnableCallback(){} // RVA: 0x7AEE16C70
        public void OnEnable(){} // RVA: 0x7AEE16DA0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SignalAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SignalEmitter : Marker
    {
        // ── Methods ──
        public void get_retroactive(){} // RVA: 0x7A84A5BD0
        public void set_retroactive(){} // RVA: 0x7A84A5CD0
        public void get_emitOnce(){} // RVA: 0x7A89FCA90
        public void set_emitOnce(){} // RVA: 0x7A96C67C0
        public void get_asset(){} // RVA: 0x7A83F69F0
        public void set_asset(){} // RVA: 0x7A8105A90
        public void UnityEngine.Playables.INotification.get_id(){} // RVA: 0x7AEE16E00
        public void UnityEngine.Timeline.INotificationOptionProvider.get_flags(){} // RVA: 0x7AEE16FA0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SignalReceiver : MonoBehaviour
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7AEE16FD0
        public void AddReaction(){} // RVA: 0x7AEE171D0
        public void AddEmptyReaction(){} // RVA: 0x7AEE17390
        public void Remove(){} // RVA: 0x7AEE17400
        public void GetRegisteredSignals(){} // RVA: 0x7A8D68180
        public void GetReaction(){} // RVA: 0x7AEE17580
        public void Count(){} // RVA: 0x7AEE175C0
        public void ChangeSignalAtIndex(){} // RVA: 0x7AEE17610
        public void RemoveAtIndex(){} // RVA: 0x7AEE17AD0
        public void ChangeReactionAtIndex(){} // RVA: 0x7AEE17BE0
        public void GetReactionAtIndex(){} // RVA: 0x7AEE17CD0
        public void GetSignalAssetAtIndex(){} // RVA: 0x7AEE17DB0
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7AEE17E90
    }

    public class SignalTrack : MarkerTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE16AF0
    }

    public class SupportsChildTracksAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
    }

    public class TimeControlPlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE1D1C0
        public void Initialize(){} // RVA: 0x7A80D8E20
        public void PrepareFrame(){} // RVA: 0x7AEE1D390
        public void OnBehaviourPlay(){} // RVA: 0x7AEE1D410
        public void OnBehaviourPause(){} // RVA: 0x7AEE1D470
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TimeFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void get_useEditMode(){} // RVA: 0x7A8124910
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        // ── Methods ──
        public void set_timeSource(){} // RVA: 0x7A8EDB600
        public void Create(){} // RVA: 0x7AEE1D4D0
        public void AddNotification(){} // RVA: 0x7AEE1D6E0
        public void OnGraphStart(){} // RVA: 0x7AEE1D7E0
        public void OnBehaviourPause(){} // RVA: 0x7AEE1DA00
        public void PrepareFrame(){} // RVA: 0x7AEE1DCF0
        public void SortNotifications(){} // RVA: 0x7AEE1E0F0
        public void CanRestoreNotification(){} // RVA: 0x7AEE1E310
        public void TriggerNotificationsInRange(){} // RVA: 0x7AEE1E350
        public void SyncDurationWithExternalSource(){} // RVA: 0x7AEE1E610
        public void Trigger_internal(){} // RVA: 0x7AEE1E8E0
        public void Restore_internal(){} // RVA: 0x7A847A460
        public void .ctor(){} // RVA: 0x7AEE1EA80
    }

    public class TimeUtility : Object
    {
        // ── Methods ──
        public void ValidateFrameRate(){} // RVA: 0x7AEE26B90
        public void ToFrames(){} // RVA: 0x7AEE26C50
        public void ToExactFrames(){} // RVA: 0x7AEE26DC0
        public void FromFrames(){} // RVA: 0x7AEE26EA0
        public void OnFrameBoundary(){} // RVA: 0x7AEE273B0
        public void GetEpsilon(){} // RVA: 0x7AEE27020
        public void PreviousFrame(){} // RVA: 0x7AEE27110
        public void NextFrame(){} // RVA: 0x7AEE271B0
        public void PreviousFrameTime(){} // RVA: 0x7AEE27220
        public void NextFrameTime(){} // RVA: 0x7AEE27300
        public void RoundToFrame(){} // RVA: 0x7AEE27480
        public void TimeAsFrames(){} // RVA: 0x7AEE27580
        public void TimeAsTimeCode(){} // RVA: 0x7AEE27710
        public void ParseTimeCode(){} // RVA: 0x7AEE27E10
        public void ParseTimeSeconds(){} // RVA: 0x7AEE28470
        public void GetAnimationClipLength(){} // RVA: 0x7AEE289E0
        public void RemoveChar(){} // RVA: 0x7AEE28BE0
        public void GetClosestFrameRate(){} // RVA: 0x7AEE28CD0
        public void ToFrameRate(){} // RVA: 0x7AEE28F60
        public void ToStandardFrameRate(){} // RVA: 0x7AEE29150
        public void .cctor(){} // RVA: 0x7AEE295C0
    }

    public class TimelineAsset : PlayableAsset
    {
        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7A80D7310
        public void get_editorSettings(){} // RVA: 0x7A8152D80
        public void get_duration(){} // RVA: 0x7AEDFE4A0
        public void get_fixedDuration(){} // RVA: 0x7AEDFE540
        public void set_fixedDuration(){} // RVA: 0x7AEDFE660
        public void get_durationMode(){} // RVA: 0x7A8355950
        public void set_durationMode(){} // RVA: 0x7A83F4180
        public void get_outputs(){} // RVA: 0x7AEDFE700
        public void get_clipCaps(){} // RVA: 0x7AEDFE7B0
        public void get_outputTrackCount(){} // RVA: 0x7AEDFE980
        public void get_rootTrackCount(){} // RVA: 0x7AEDFE9B0
        public void OnValidate(){} // RVA: 0x7AEDFEA00
        public void GetRootTrack(){} // RVA: 0x7AEDFEA40
        public void GetRootTracks(){} // RVA: 0x7AEDFEAC0
        public void GetOutputTrack(){} // RVA: 0x7AEDFEAE0
        public void GetOutputTracks(){} // RVA: 0x7AEDFEB30
        public void GetValidFrameRate(){} // RVA: 0x7AEDFEB50
        public void UpdateRootTrackCache(){} // RVA: 0x7AEDFEC40
        public void UpdateOutputTrackCache(){} // RVA: 0x7AEDFF0F0
        public void get_flattenedTracks(){} // RVA: 0x7AEDFF3A0
        public void get_markerTrack(){} // RVA: 0x7A81A0050
        public void get_trackObjects(){} // RVA: 0x7A81052C0
        public void AddTrackInternal(){} // RVA: 0x7AEDFF5C0
        public void RemoveTrack(){} // RVA: 0x7AEDFF670
        public void CreatePlayable(){} // RVA: 0x7AEDFF7F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A8810990
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AEDFFAC0
        public void __internalAwake(){} // RVA: 0x7AEDFFAD0
        public void GatherProperties(){} // RVA: 0x7AEDFFD50
        public void CreateMarkerTrack(){} // RVA: 0x7AEDFFF60
        public void RemoveMarkerTrack(){} // RVA: 0x7AEE00150
        public void Invalidate(){} // RVA: 0x7AEE00290
        public void UpdateFixedDurationWithItemsDuration(){} // RVA: 0x7AEE00390
        public void CalculateItemsDuration(){} // RVA: 0x7AEE00440
        public void AddSubTracksRecursive(){} // RVA: 0x7AEE006D0
        public void CreateTrack(){} // RVA: 0x7A8051B10
        public void DeleteClip(){} // RVA: 0x7AEE00EE0
        public void DeleteTrack(){} // RVA: 0x7AEE012C0
        public void MoveLastTrackBefore(){} // RVA: 0x7AEE01880
        public void AllocateTrack(){} // RVA: 0x7AEE01C20
        public void DeleteRecordedAnimation(){} // RVA: 0x7AEE02390
        public void .ctor(){} // RVA: 0x7AEE02630
    }

    public class TimelineClip : Object
    {
        // ── Methods ──
        public void UpgradeToLatestVersion(){} // RVA: 0x7AEDFB460
        public void .ctor(){} // RVA: 0x7AEDFB490
        public void get_hasPreExtrapolation(){} // RVA: 0x7AEDFB4C0
        public void get_hasPostExtrapolation(){} // RVA: 0x7AEDFB4E0
        public void get_timeScale(){} // RVA: 0x7AEDFB500
        public void set_timeScale(){} // RVA: 0x7AEDFB610
        public void get_start(){} // RVA: 0x7A9727910
        public void set_start(){} // RVA: 0x7AEDFB730
        public void get_duration(){} // RVA: 0x7AECC3980
        public void set_duration(){} // RVA: 0x7AEDFB940
        public void get_end(){} // RVA: 0x7AEDFBB00
        public void get_clipIn(){} // RVA: 0x7AEDFBB10
        public void set_clipIn(){} // RVA: 0x7AEDFBB40
        public void get_displayName(){} // RVA: 0x7A8142610
        public void set_displayName(){} // RVA: 0x7A8142620
        public void get_clipAssetDuration(){} // RVA: 0x7AEDFBC60
        public void get_curves(){} // RVA: 0x7A81163D0
        public void set_curves(){} // RVA: 0x7A825E460
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7AEDFBCD0
        public void get_hasCurves(){} // RVA: 0x7AEDFBD30
        public void get_asset(){} // RVA: 0x7A8105330
        public void set_asset(){} // RVA: 0x7A80D8E80
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7A8154D80
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7A8154D80
        public void get_underlyingAsset(){} // RVA: 0x7A82D1450
        public void set_underlyingAsset(){} // RVA: 0x7A80D7310
        public void get_parentTrack(){} // RVA: 0x7A8154D80
        public void set_parentTrack(){} // RVA: 0x7AEDFBE70
        public void GetParentTrack(){} // RVA: 0x7A8154D80
        public void SetParentTrack_Internal(){} // RVA: 0x7AEDFBE80
        public void get_easeInDuration(){} // RVA: 0x7AEDFC140
        public void set_easeInDuration(){} // RVA: 0x7AEDFC240
        public void get_easeOutDuration(){} // RVA: 0x7AEDFC380
        public void set_easeOutDuration(){} // RVA: 0x7AEDFC480
        public void get_eastOutTime(){} // RVA: 0x7AEDFC5C0
        public void get_easeOutTime(){} // RVA: 0x7AEDFC5C0
        public void get_blendInDuration(){} // RVA: 0x7AEDFC600
        public void set_blendInDuration(){} // RVA: 0x7AEDFC630
        public void get_blendOutDuration(){} // RVA: 0x7AEDFC6D0
        public void set_blendOutDuration(){} // RVA: 0x7AEDFC700
        public void get_blendInCurveMode(){} // RVA: 0x7A989D5C0
        public void set_blendInCurveMode(){} // RVA: 0x7A98A0B60
        public void get_blendOutCurveMode(){} // RVA: 0x7A98A0C40
        public void set_blendOutCurveMode(){} // RVA: 0x7AE034E90
        public void get_hasBlendIn(){} // RVA: 0x7AEDFC7A0
        public void get_hasBlendOut(){} // RVA: 0x7AEDFC7E0
        public void get_mixInCurve(){} // RVA: 0x7AEDFC820
        public void set_mixInCurve(){} // RVA: 0x7A81533A0
        public void get_mixInPercentage(){} // RVA: 0x7AEDFC930
        public void get_mixInDuration(){} // RVA: 0x7AEDFC950
        public void get_mixOutCurve(){} // RVA: 0x7AEDFCA70
        public void set_mixOutCurve(){} // RVA: 0x7A81A00F0
        public void get_mixOutTime(){} // RVA: 0x7AEDFCB80
        public void get_mixOutDuration(){} // RVA: 0x7AEDFCBF0
        public void get_mixOutPercentage(){} // RVA: 0x7AEDFCC50
        public void get_recordable(){} // RVA: 0x7A9101D40
        public void set_recordable(){} // RVA: 0x7A91004C0
        public void get_exposedParameters(){} // RVA: 0x7AEDFCCB0
        public void get_clipCaps(){} // RVA: 0x7AEDFCD80
        public void Hash(){} // RVA: 0x7AEDFCE20
        public void EvaluateMixOut(){} // RVA: 0x7AEDFCF50
        public void EvaluateMixIn(){} // RVA: 0x7AEDFD100
        public void GetDefaultMixInCurve(){} // RVA: 0x7AEDFD1F0
        public void GetDefaultMixOutCurve(){} // RVA: 0x7AEDFD220
        public void ToLocalTime(){} // RVA: 0x7AEDFD250
        public void ToLocalTimeUnbound(){} // RVA: 0x7AEDFD410
        public void FromLocalTimeUnbound(){} // RVA: 0x7AEDFD480
        public void get_animationClip(){} // RVA: 0x7AEDFD4E0
        public void SanitizeTimeValue(){} // RVA: 0x7AEDFD6B0
        public void get_postExtrapolationMode(){} // RVA: 0x7AEDFD810
        public void set_postExtrapolationMode(){} // RVA: 0x7AEDFD840
        public void get_preExtrapolationMode(){} // RVA: 0x7AEDFD880
        public void set_preExtrapolationMode(){} // RVA: 0x7AEDFD8B0
        public void SetPostExtrapolationTime(){} // RVA: 0x7AEDFD8F0
        public void SetPreExtrapolationTime(){} // RVA: 0x7AEDFD900
        public void IsExtrapolatedTime(){} // RVA: 0x7AEDFD910
        public void IsPreExtrapolatedTime(){} // RVA: 0x7AEDFD9C0
        public void IsPostExtrapolatedTime(){} // RVA: 0x7AEDFDA20
        public void get_extrapolatedStart(){} // RVA: 0x7AEDFDA90
        public void get_extrapolatedDuration(){} // RVA: 0x7AEDFDAB0
        public void GetExtrapolatedTime(){} // RVA: 0x7AEDFDBB0
        public void CreateCurves(){} // RVA: 0x7AEDFDCF0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A98B32B0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AEDFB460
        public void ToString(){} // RVA: 0x7AEDFDE80
        public void ConformEaseValues(){} // RVA: 0x7AEDFE0D0
        public void CalculateEasingRatio(){} // RVA: 0x7AEDFE230
        public void UpdateDirty(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEDFE320
    }

    public class TimelineClipCapsExtensions : Object
    {
        // ── Methods ──
        public void SupportsLooping(){} // RVA: 0x7AEE0EA10
        public void SupportsExtrapolation(){} // RVA: 0x7AEE0EA30
        public void SupportsClipIn(){} // RVA: 0x7AEE0EA60
        public void SupportsSpeedMultiplier(){} // RVA: 0x7AEE0EA90
        public void SupportsBlending(){} // RVA: 0x7AEE0EAC0
        public void HasAll(){} // RVA: 0x7A9624BF0
        public void HasAny(){} // RVA: 0x7AE7F23D0
    }

    public class TimelineClipExtensions : Object
    {
        // ── Methods ──
        public void MoveToTrack(){} // RVA: 0x7AEE24FE0
        public void TryMoveToTrack(){} // RVA: 0x7AEE25510
        public void MoveToTrack_Impl(){} // RVA: 0x7AEE25830
        public void .cctor(){} // RVA: 0x7AEE25AD0
    }

    public class TimelineCreateUtilities : Object
    {
        // ── Methods ──
        public void GenerateUniqueActorName(){} // RVA: 0x7AEE25B80
        public void SaveAssetIntoObject(){} // RVA: 0x7AEE25ED0
        public void RemoveAssetFromObject(){} // RVA: 0x7AEE260A0
        public void CreateAnimationClipForTrack(){} // RVA: 0x7AEE26200
        public void ValidateParentTrack(){} // RVA: 0x7AEE265E0
    }

    public class TimelineHelpURLAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TimelinePlayable : PlayableBehaviour
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEE1EF40
        public void Compile(){} // RVA: 0x7AEE1F370
        public void CompileTrackList(){} // RVA: 0x7AEE1F7E0
        public void CreateTrackOutput(){} // RVA: 0x7AEE1FAB0
        public void CreateTrackPlayable(){} // RVA: 0x7AEE20460
        public void PrepareFrame(){} // RVA: 0x7AEE20A00
        public void Evaluate(){} // RVA: 0x7AEE20A50
        public void CacheTrack(){} // RVA: 0x7AEE21210
        public void ForAOTCompilationOnly(){} // RVA: 0x7AEE212A0
        public void AddPlayableOutputCallbacks(){} // RVA: 0x7AEE21300
        public void AddOutputWeightProcessor(){} // RVA: 0x7AEE213A0
        public void AddEvaluateCallback(){} // RVA: 0x7AEE21620
        public void InvokeOutputCallbacks(){} // RVA: 0x7AEE217B0
        public void TryGetCallbackList(){} // RVA: 0x7AEE22380
        public void .ctor(){} // RVA: 0x7AEE22570
        public void .cctor(){} // RVA: 0x7AEE22BF0
    }

    public class TimelineUndo : Object
    {
        // ── Methods ──
        public void get_undoEnabled(){} // RVA: 0x7A80D7320
        public void PushDestroyUndo(){} // RVA: 0x7AEE26A50
        public void PushUndo(){} // RVA: 0x7A80D7310
        public void RegisterCreatedObjectUndo(){} // RVA: 0x7A80D7310
        public void UndoName(){} // RVA: 0x7AEE26B40
    }

    public class TrackAsset : PlayableAsset
    {
        // ── Methods ──
        public void OnBeforeTrackSerialize(){} // RVA: 0x7A80D7310
        public void OnAfterTrackDeserialize(){} // RVA: 0x7A80D7310
        public void OnUpgradeFromVersion(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AEE034A0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AEE037C0
        public void UpgradeToLatestVersion(){} // RVA: 0x7A80D7310
        public void add_OnClipPlayableCreate(){} // RVA: 0x7AEE03AE0
        public void remove_OnClipPlayableCreate(){} // RVA: 0x7AEE03C50
        public void add_OnTrackAnimationPlayableCreate(){} // RVA: 0x7AEE03DC0
        public void remove_OnTrackAnimationPlayableCreate(){} // RVA: 0x7AEE03F30
        public void get_start(){} // RVA: 0x7AEE040A0
        public void get_end(){} // RVA: 0x7AEE04140
        public void get_duration(){} // RVA: 0x7AEE041E0
        public void get_muted(){} // RVA: 0x7A89FCA90
        public void set_muted(){} // RVA: 0x7A96C67C0
        public void get_mutedInHierarchy(){} // RVA: 0x7AEE04290
        public void get_timelineAsset(){} // RVA: 0x7AEE04540
        public void get_parent(){} // RVA: 0x7A8154D80
        public void set_parent(){} // RVA: 0x7A80FF440
        public void GetClips(){} // RVA: 0x7AEE04820
        public void get_clips(){} // RVA: 0x7AEE04830
        public void get_blendsValid(){} // RVA: 0x7AD89C540
        public void set_blendsValid(){} // RVA: 0x7AD89C550
        public void get_isEmpty(){} // RVA: 0x7AEE04990
        public void get_hasClips(){} // RVA: 0x7AEE04A40
        public void get_hasCurves(){} // RVA: 0x7AEE04A90
        public void get_isSubTrack(){} // RVA: 0x7AEE04BC0
        public void get_outputs(){} // RVA: 0x7AEE04D40
        public void GetChildTracks(){} // RVA: 0x7AEE04DF0
        public void get_customPlayableTypename(){} // RVA: 0x7A83F69F0
        public void set_customPlayableTypename(){} // RVA: 0x7A8105A90
        public void get_curves(){} // RVA: 0x7A8292C30
        public void set_curves(){} // RVA: 0x7A8296DE0
        public void UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName(){} // RVA: 0x7AEE04E10
        public void UnityEngine.Timeline.ICurvesOwner.get_asset(){} // RVA: 0x7A97F8BA0
        public void UnityEngine.Timeline.ICurvesOwner.get_assetOwner(){} // RVA: 0x7AEE04E50
        public void UnityEngine.Timeline.ICurvesOwner.get_targetTrack(){} // RVA: 0x7A97F8BA0
        public void get_subTracksObjects(){} // RVA: 0x7A8152D80
        public void get_locked(){} // RVA: 0x7A84A5BD0
        public void set_locked(){} // RVA: 0x7A84A5CD0
        public void get_lockedInHierarchy(){} // RVA: 0x7AEE04E60
        public void get_supportsNotifications(){} // RVA: 0x7AEE05110
        public void __internalAwake(){} // RVA: 0x7AEE051A0
        public void CreateCurves(){} // RVA: 0x7AEE05360
        public void CreateTrackMixer(){} // RVA: 0x7AEE054C0
        public void CreatePlayable(){} // RVA: 0x7AEE0AAD0
        public void CreateDefaultClip(){} // RVA: 0x7AEE05690
        public void CreateClip(){} // RVA: 0x7AEE05C30
        public void DeleteClip(){} // RVA: 0x7AEE059D0
        public void CreateMarker(){} // RVA: 0x7A8051B10
        public void DeleteMarker(){} // RVA: 0x7AEE05B90
        public void GetMarkers(){} // RVA: 0x7AEE05BA0
        public void GetMarkerCount(){} // RVA: 0x7AEE05BD0
        public void GetMarker(){} // RVA: 0x7AEE05C20
        public void CreateAndAddNewClipOfType(){} // RVA: 0x7AEE05D70
        public void CreateClipOfType(){} // RVA: 0x7AEE05DB0
        public void CreateClipFromPlayableAsset(){} // RVA: 0x7AEE060A0
        public void CreateClipFromAsset(){} // RVA: 0x7AEE063D0
        public void GetMarkersRaw(){} // RVA: 0x7A81163D0
        public void ClearMarkers(){} // RVA: 0x7AEE06690
        public void AddMarker(){} // RVA: 0x7AEE06700
        public void DeleteMarkerRaw(){} // RVA: 0x7AEE06710
        public void GetTimeRangeHash(){} // RVA: 0x7AEE06750
        public void AddClip(){} // RVA: 0x7AEE069C0
        public void CreateNotificationsPlayable(){} // RVA: 0x7AEE06B00
        public void CreatePlayableGraph(){} // RVA: 0x7AEE07020
        public void CompileClips(){} // RVA: 0x7AEE073C0
        public void GatherCompilableTracks(){} // RVA: 0x7AEE078B0
        public void GatherNotifications(){} // RVA: 0x7AEE07BA0
        public void CreateMixerPlayableGraph(){} // RVA: 0x7AEE07EC0
        public void ConfigureTrackAnimation(){} // RVA: 0x7AEE08810
        public void SortClips(){} // RVA: 0x7AEE08970
        public void ClearClipsInternal(){} // RVA: 0x7AEE08BF0
        public void ClearSubTracksInternal(){} // RVA: 0x7AEE08D10
        public void OnClipMove(){} // RVA: 0x7AEE08DE0
        public void CreateNewClipContainerInternal(){} // RVA: 0x7AEE08E40
        public void AddChild(){} // RVA: 0x7AEE09290
        public void MoveLastTrackBefore(){} // RVA: 0x7AEE093E0
        public void RemoveSubTrack(){} // RVA: 0x7AEE09780
        public void RemoveClip(){} // RVA: 0x7AEE09860
        public void GetEvaluationTime(){} // RVA: 0x7AEE09930
        public void GetSequenceTime(){} // RVA: 0x7AEE09BB0
        public void GatherProperties(){} // RVA: 0x7AEE09BD0
        public void GetGameObjectBinding(){} // RVA: 0x7AEE0A2B0
        public void ValidateClipType(){} // RVA: 0x7AEE0A5A0
        public void OnCreateClip(){} // RVA: 0x7A80D7310
        public void UpdateDuration(){} // RVA: 0x7AEE0A8B0
        public void CalculateItemsHash(){} // RVA: 0x7AEE0AA20
        public void Invalidate(){} // RVA: 0x7AEE0AE70
        public void GetNotificationDuration(){} // RVA: 0x7AEE0AFA0
        public void CanCompileClips(){} // RVA: 0x7AEE0B1D0
        public void CanCreateTrackMixer(){} // RVA: 0x7ADCAB2E0
        public void IsCompilable(){} // RVA: 0x7AEE0B230
        public void UpdateChildTrackCache(){} // RVA: 0x7AEE0B540
        public void Hash(){} // RVA: 0x7AEE0B8A0
        public void GetClipsHash(){} // RVA: 0x7AEE0B920
        public void GetAnimationClipHash(){} // RVA: 0x7AEE0BBD0
        public void HasNotifications(){} // RVA: 0x7AEE0BDD0
        public void CanCompileNotifications(){} // RVA: 0x7AEE0BE00
        public void CanCreateMixerRecursive(){} // RVA: 0x7AEE0BE40
        public void .ctor(){} // RVA: 0x7AEE0BFE0
        public void .cctor(){} // RVA: 0x7AEE0C1C0
    }

    public class TrackAssetExtensions : Object
    {
        // ── Methods ──
        public void GetGroup(){} // RVA: 0x7AEE18650
        public void SetGroup(){} // RVA: 0x7AEE18770
        public void ComputeBlendsFromOverlaps(){} // RVA: 0x7AEE18F00
    }

    public class TrackBindingTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
    }

    public class TrackClipTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class TrackColorAttribute : Attribute
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x7A97277F0
        public void .ctor(){} // RVA: 0x7AEE0CD90
    }

    public class TrackMediaType : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class WeightUtility : Object
    {
        // ── Methods ──
        public void NormalizeMixer(){} // RVA: 0x7AEE297C0
    }

}