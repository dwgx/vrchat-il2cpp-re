// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Animations
// Classes: 31
// Methods: 499

namespace ThirdParty.Unity.UnityEngine.Animations
{
    public class AimConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BDB7D0
        public void set_weight(){} // RVA: 0x7FFE87BDB820
        public void get_constraintActive(){} // RVA: 0x7FFE87BDB880
        public void set_constraintActive(){} // RVA: 0x7FFE87BDB8D0
        public void get_locked(){} // RVA: 0x7FFE87BDB930
        public void set_locked(){} // RVA: 0x7FFE87BDB980
        public void get_rotationAtRest(){} // RVA: 0x7FFE87BDB9E0
        public void set_rotationAtRest(){} // RVA: 0x7FFE87BDBA50
        public void get_rotationOffset(){} // RVA: 0x7FFE87BDBAB0
        public void set_rotationOffset(){} // RVA: 0x7FFE87BDBB20
        public void get_rotationAxis(){} // RVA: 0x7FFE87BDBB80
        public void set_rotationAxis(){} // RVA: 0x7FFE87BDBBD0
        public void get_aimVector(){} // RVA: 0x7FFE87BDBC30
        public void set_aimVector(){} // RVA: 0x7FFE87BDBCA0
        public void get_upVector(){} // RVA: 0x7FFE87BDBD00
        public void set_upVector(){} // RVA: 0x7FFE87BDBD70
        public void get_worldUpVector(){} // RVA: 0x7FFE87BDBDD0
        public void set_worldUpVector(){} // RVA: 0x7FFE87BDBE40
        public void get_worldUpObject(){} // RVA: 0x7FFE87BDBEA0
        public void set_worldUpObject(){} // RVA: 0x7FFE87BDBEF0
        public void get_worldUpType(){} // RVA: 0x7FFE87BDBF50
        public void set_worldUpType(){} // RVA: 0x7FFE87BDBFA0
        public void get_sourceCount(){} // RVA: 0x7FFE87BDC000
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BDC000
        public void GetSources(){} // RVA: 0x7FFE87BDC050
        public void SetSources(){} // RVA: 0x7FFE87BDC0B0
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BDC160
        public void AddSource(){} // RVA: 0x7FFE87BDC1C0
        public void RemoveSource(){} // RVA: 0x7FFE87BDC220
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BDC290
        public void GetSource(){} // RVA: 0x7FFE87BDC2F0
        public void GetSourceInternal(){} // RVA: 0x7FFE87BDC390
        public void SetSource(){} // RVA: 0x7FFE87BDC410
        public void SetSourceInternal(){} // RVA: 0x7FFE87BDC490
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BDC500
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFE87BDC6C0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFE87BDC720
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFE87BDC780
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFE87BDC7E0
        public void get_aimVector_Injected(){} // RVA: 0x7FFE87BDC840
        public void set_aimVector_Injected(){} // RVA: 0x7FFE87BDC8A0
        public void get_upVector_Injected(){} // RVA: 0x7FFE87BDC900
        public void set_upVector_Injected(){} // RVA: 0x7FFE87BDC960
        public void get_worldUpVector_Injected(){} // RVA: 0x7FFE87BDC9C0
        public void set_worldUpVector_Injected(){} // RVA: 0x7FFE87BDCA20
        public void AddSource_Injected(){} // RVA: 0x7FFE87BDCA80
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BDCAE0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BDCB50
    }

    public class AnimationClipPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDCBC0
        public void CreateHandle(){} // RVA: 0x7FFE87BDCD60
        public void .ctor(){} // RVA: 0x7FFE87BDCEE0
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
        public void Equals(){} // RVA: 0x7FFE87BDCFE0
        public void SetApplyFootIK(){} // RVA: 0x7FFE87BDD0A0
        public void SetRemoveStartOffset(){} // RVA: 0x7FFE87BDD100
        public void SetOverrideLoopTime(){} // RVA: 0x7FFE87BDD160
        public void SetLoopTime(){} // RVA: 0x7FFE87BDD1C0
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BDD220
        public void SetApplyFootIKInternal(){} // RVA: 0x7FFE87BDD0A0
        public void SetRemoveStartOffsetInternal(){} // RVA: 0x7FFE87BDD100
        public void SetOverrideLoopTimeInternal(){} // RVA: 0x7FFE87BDD160
        public void SetLoopTimeInternal(){} // RVA: 0x7FFE87BDD1C0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BDD290
    }

    public class AnimationHumanStream : ValueType
    {
        public UIntPtr stream; // 0x10
        public object field_1; // 0x9EF8

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFE87BDD300
        public void ThrowIfInvalid(){} // RVA: 0x7FFE87BDD310
        public void set_bodyLocalRotation(){} // RVA: 0x7FFE87BDD380
        public void SetMuscle(){} // RVA: 0x7FFE87BDD430
        public void InternalSetBodyLocalRotation(){} // RVA: 0x7FFE87BDD4F0
        public void InternalSetMuscle(){} // RVA: 0x7FFE87BDD550
        public void InternalSetBodyLocalRotation_Injected(){} // RVA: 0x7FFE87BDD5C0
        public void InternalSetMuscle_Injected(){} // RVA: 0x7FFE87BDD620
    }

    public class AnimationLayerMixerPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDD780 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFE87BDD850
        public void .ctor(){} // RVA: 0x7FFE87BDDAB0
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDDC10
        public void Equals(){} // RVA: 0x7FFE87BDDC70
        public void SetLayerAdditive(){} // RVA: 0x7FFE87BDDD60
        public void SetLayerMaskFromAvatarMask(){} // RVA: 0x7FFE87BDDF20
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BDE1D0
        public void SetLayerAdditiveInternal(){} // RVA: 0x7FFE87BDE270
        public void SetSingleLayerOptimizationInternal(){} // RVA: 0x7FFE87BDE2E0
        public void SetLayerMaskFromAvatarMaskInternal(){} // RVA: 0x7FFE87BDE340
        public void .cctor(){} // RVA: 0x7FFE87BDE3B0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BDE480
    }

    public class AnimationMixerPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDE4E0
        public void CreateHandle(){} // RVA: 0x7FFE87BDE590
        public void .ctor(){} // RVA: 0x7FFE87BDE7F0
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDE8E0
        public void Equals(){} // RVA: 0x7FFE87BDE940
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BDEA30
        public void .cctor(){} // RVA: 0x7FFE87BDEAD0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BDEBA0
    }

    public class AnimationMotionXToDeltaPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDEC00
        public void CreateHandle(){} // RVA: 0x7FFE87BDECA0
        public void .ctor(){} // RVA: 0x7FFE87BDEF10
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDF000
        public void Equals(){} // RVA: 0x7FFE87BDF060
        public void SetAbsoluteMotion(){} // RVA: 0x7FFE87BDF150
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BDF1F0
        public void SetAbsoluteMotionInternal(){} // RVA: 0x7FFE87BDF290
        public void .cctor(){} // RVA: 0x7FFE87BDF2F0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BDF3C0
    }

    public class AnimationOffsetPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDF420
        public void CreateHandle(){} // RVA: 0x7FFE87BDF510
        public void .ctor(){} // RVA: 0x7FFE87BDF7B0
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDF8A0
        public void Equals(){} // RVA: 0x7FFE87BDF900
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BDF9B0
        public void .cctor(){} // RVA: 0x7FFE87BDFA70
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BDFB40
    }

    public class AnimationPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDB5F0
        public void CreateAnimationOutput(){} // RVA: 0x7FFE87BDB780
    }

    public class AnimationPlayableExtensions : Object
    {
        // ── Methods ──
        public void SetAnimatedProperties(){} // RVA: 0x7FFE810A1420
        public void SetAnimatedPropertiesInternal(){} // RVA: 0x7FFE87BDFBC0
    }

    public class AnimationPlayableGraphExtensions : Object
    {
        // ── Methods ──
        public void InternalCreateAnimationOutput(){} // RVA: 0x7FFE87BDFC20
    }

    public class AnimationPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BDFC90
        public void .ctor(){} // RVA: 0x7FFE87BDFE50
        public void get_Null(){} // RVA: 0x7FFE87BDFF40
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
        public void op_Explicit(){} // RVA: 0x7FFE87BE0000
        public void GetTarget(){} // RVA: 0x7FFE87BE0090
        public void SetTarget(){} // RVA: 0x7FFE87BE00E0
        public void InternalGetTarget(){} // RVA: 0x7FFE87BE0090
        public void InternalSetTarget(){} // RVA: 0x7FFE87BE00E0
    }

    public class AnimationPosePlayable : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BE0140
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void Equals(){} // RVA: 0x7FFE87BE0230
        public void .cctor(){} // RVA: 0x7FFE87BE02E0
    }

    public class AnimationRemoveScalePlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BE03B0
        public void CreateHandle(){} // RVA: 0x7FFE87BE0460
        public void .ctor(){} // RVA: 0x7FFE87BE06C0
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BE07B0
        public void Equals(){} // RVA: 0x7FFE87BE0810
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BE08C0
        public void .cctor(){} // RVA: 0x7FFE87BE0960
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BE0A30
    }

    public class AnimationScriptPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
        public void CreateHandle(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE87BE0A90
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void CheckJobTypeValidity(){} // RVA: 0x7FFE80E45FE0
        public void GetJobData(){} // RVA: 0x7FFE810A1420
        public void SetJobData(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE87BE0B80
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BE0C70
        public void .cctor(){} // RVA: 0x7FFE87BE0D20
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BE0DF0
    }

    public class AnimationStream : ValueType
    {
        public uint m_AnimatorBindingsVersion; // 0x10
        public UIntPtr constant; // 0x18
        public UIntPtr input; // 0x20

        // ── Methods ──
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFE8733C3B0
        public void get_isValid(){} // RVA: 0x7FFE87BE0E60
        public void CheckIsValid(){} // RVA: 0x7FFE87BE0E90
        public void get_isHumanStream(){} // RVA: 0x7FFE87BE0F20
        public void AsHuman(){} // RVA: 0x7FFE87BE0F80
        public void GetIsHumanStream(){} // RVA: 0x7FFE87BE1030
        public void GetHumanStream(){} // RVA: 0x7FFE87BE1080
        public void GetIsHumanStream_Injected(){} // RVA: 0x7FFE87BE1030
        public void GetHumanStream_Injected(){} // RVA: 0x7FFE87BE10F0
    }

    public class AnimatorControllerPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFE87BE1620
        public void Create(){} // RVA: 0x7FFE87BE1690
        public void CreateHandle(){} // RVA: 0x7FFE87BE1970
        public void .ctor(){} // RVA: 0x7FFE87BE1B40
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void SetHandle(){} // RVA: 0x7FFE87BE1C20
        public void op_Implicit(){} // RVA: 0x7FFE87BE1D80
        public void op_Explicit(){} // RVA: 0x7FFE87BE1DE0
        public void Equals(){} // RVA: 0x7FFE87BE1F10
        public void GetFloat(){} // RVA: 0x7FFE87BE20A0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFE87BE21F0 | overloaded x2
        public void GetBool(){} // RVA: 0x7FFE87BE2340 | overloaded x2
        public void SetBool(){} // RVA: 0x7FFE87BE2490 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFE87BE25E0 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFE87BE2730 | overloaded x2
        public void SetTrigger(){} // RVA: 0x7FFE87BE2880 | overloaded x2
        public void ResetTrigger(){} // RVA: 0x7FFE87BE29C0 | overloaded x2
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFE87BE2B00 | overloaded x2
        public void GetLayerCount(){} // RVA: 0x7FFE87BE2BA0
        public void GetLayerName(){} // RVA: 0x7FFE87BE2C30
        public void GetLayerIndex(){} // RVA: 0x7FFE87BE2CD0
        public void GetLayerWeight(){} // RVA: 0x7FFE87BE2D70
        public void SetLayerWeight(){} // RVA: 0x7FFE87BE2E10
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7FFE87BE2EC0
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7FFE87BE2FE0
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7FFE87BE3100
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7FFE87BE32B0 | overloaded x2
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7FFE87BE3610 | overloaded x2
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7FFE87BE3450
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7FFE87BE34D0
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7FFE87BE3570
        public void IsInTransition(){} // RVA: 0x7FFE87BE36B0
        public void GetParameterCount(){} // RVA: 0x7FFE87BE3750
        public void GetParameter(){} // RVA: 0x7FFE87BE37E0
        public void CrossFadeInFixedTime(){} // RVA: 0x7FFE87BE3D20 | overloaded x6
        public void CrossFade(){} // RVA: 0x7FFE87BE41C0 | overloaded x6
        public void PlayInFixedTime(){} // RVA: 0x7FFE87BE45A0 | overloaded x6
        public void Play(){} // RVA: 0x7FFE87BE4980 | overloaded x6
        public void HasState(){} // RVA: 0x7FFE87BE4A10
        public void ResolveHash(){} // RVA: 0x7FFE87BE4AC0
        public void CreateHandleInternal(){} // RVA: 0x7FFE87BE4B60
        public void GetAnimatorControllerInternal(){} // RVA: 0x7FFE87BE4C10
        public void GetLayerCountInternal(){} // RVA: 0x7FFE87BE4C60
        public void GetLayerNameInternal(){} // RVA: 0x7FFE87BE4CB0
        public void GetLayerIndexInternal(){} // RVA: 0x7FFE87BE4D10
        public void GetLayerWeightInternal(){} // RVA: 0x7FFE87BE4D70
        public void SetLayerWeightInternal(){} // RVA: 0x7FFE87BE4DD0
        public void GetCurrentAnimatorStateInfoInternal(){} // RVA: 0x7FFE87BE4E40
        public void GetNextAnimatorStateInfoInternal(){} // RVA: 0x7FFE87BE4F00
        public void GetAnimatorTransitionInfoInternal(){} // RVA: 0x7FFE87BE4FC0
        public void GetCurrentAnimatorClipInfoInternal(){} // RVA: 0x7FFE87BE5070
        public void GetAnimatorClipInfoCountInternal(){} // RVA: 0x7FFE87BE50D0
        public void GetNextAnimatorClipInfoInternal(){} // RVA: 0x7FFE87BE5140
        public void ResolveHashInternal(){} // RVA: 0x7FFE87BE51A0
        public void IsInTransitionInternal(){} // RVA: 0x7FFE87BE5200
        public void GetParameterInternal(){} // RVA: 0x7FFE87BE5260
        public void GetParametersArrayInternal(){} // RVA: 0x7FFE87BE52C0
        public void GetParameterCountInternal(){} // RVA: 0x7FFE87BE5310
        public void StringToHash(){} // RVA: 0x7FFE87BE5360
        public void CrossFadeInFixedTimeInternal(){} // RVA: 0x7FFE87BE53B0
        public void CrossFadeInternal(){} // RVA: 0x7FFE87BE5430
        public void PlayInFixedTimeInternal(){} // RVA: 0x7FFE87BE54B0
        public void PlayInternal(){} // RVA: 0x7FFE87BE5530
        public void HasStateInternal(){} // RVA: 0x7FFE87BE55B0
        public void SetFloatString(){} // RVA: 0x7FFE87BE5620
        public void SetFloatID(){} // RVA: 0x7FFE87BE5690
        public void GetFloatString(){} // RVA: 0x7FFE87BE5700
        public void GetFloatID(){} // RVA: 0x7FFE87BE5760
        public void SetBoolString(){} // RVA: 0x7FFE87BE57C0
        public void SetBoolID(){} // RVA: 0x7FFE87BE5830
        public void GetBoolString(){} // RVA: 0x7FFE87BE58A0
        public void GetBoolID(){} // RVA: 0x7FFE87BE5900
        public void SetIntegerString(){} // RVA: 0x7FFE87BE5960
        public void SetIntegerID(){} // RVA: 0x7FFE87BE59D0
        public void GetIntegerString(){} // RVA: 0x7FFE87BE5A40
        public void GetIntegerID(){} // RVA: 0x7FFE87BE5AA0
        public void SetTriggerString(){} // RVA: 0x7FFE87BE5B00
        public void SetTriggerID(){} // RVA: 0x7FFE87BE5B60
        public void ResetTriggerString(){} // RVA: 0x7FFE87BE5BC0
        public void ResetTriggerID(){} // RVA: 0x7FFE87BE5C20
        public void IsParameterControlledByCurveString(){} // RVA: 0x7FFE87BE5C80
        public void IsParameterControlledByCurveID(){} // RVA: 0x7FFE87BE5CE0
        public void .cctor(){} // RVA: 0x7FFE87BE5D40
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFE87BE5EC0
        public void GetCurrentAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFE87BE5F30
        public void GetNextAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFE87BE5FA0
        public void GetAnimatorTransitionInfoInternal_Injected(){} // RVA: 0x7FFE87BE6010
    }

    public class AnimatorJobExtensions : Object
    {
        // ── Methods ──
        public void BindStreamTransform(){} // RVA: 0x7FFE87BE6080
        public void InternalBindStreamTransform(){} // RVA: 0x7FFE87BE6120
    }

    public class ConstraintSource : ValueType
    {
        public UnityEngine.Transform m_SourceTransform; // 0x10
        public float m_Weight; // 0x18

        // ── Methods ──
        public void get_sourceTransform(){} // RVA: 0x7FFE8348B260
        public void set_sourceTransform(){} // RVA: 0x7FFE81D7E9E0
        public void get_weight(){} // RVA: 0x7FFE8111ECF0
        public void set_weight(){} // RVA: 0x7FFE82D03BC0
    }

    public class DiscreteEvaluationAttribute : Attribute
    {
    }

    public class IAnimationJob
    {
        // ── Methods ──
        public void ProcessAnimation(){} // RVA: 0x7FFE810A1420
        public void ProcessRootMotion(){} // RVA: 0x7FFE810A1420
    }

    public class IAnimationWindowPreview
    {
        // ── Methods ──
        public void UpdatePreviewGraph(){}
    }

    public class IConstraint
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE80E42E10
        public void get_constraintActive(){} // RVA: 0x7FFE80E2F150
        public void get_locked(){} // RVA: 0x7FFE80E2F150
        public void get_sourceCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetSource(){}
    }

    public class LookAtConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BE8B30
        public void set_weight(){} // RVA: 0x7FFE87BE8B80
        public void get_roll(){} // RVA: 0x7FFE87BE8BE0
        public void set_roll(){} // RVA: 0x7FFE87BE8C30
        public void get_constraintActive(){} // RVA: 0x7FFE87BE8C90
        public void set_constraintActive(){} // RVA: 0x7FFE87BE8CE0
        public void get_locked(){} // RVA: 0x7FFE87BE8D40
        public void set_locked(){} // RVA: 0x7FFE87BE8D90
        public void get_rotationAtRest(){} // RVA: 0x7FFE87BE8DF0
        public void set_rotationAtRest(){} // RVA: 0x7FFE87BE8E60
        public void get_rotationOffset(){} // RVA: 0x7FFE87BE8EC0
        public void set_rotationOffset(){} // RVA: 0x7FFE87BE8F30
        public void get_worldUpObject(){} // RVA: 0x7FFE87BE8F90
        public void set_worldUpObject(){} // RVA: 0x7FFE87BE8FE0
        public void get_useUpObject(){} // RVA: 0x7FFE87BE9040
        public void set_useUpObject(){} // RVA: 0x7FFE87BE9090
        public void get_sourceCount(){} // RVA: 0x7FFE87BE90F0
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BE90F0
        public void GetSources(){} // RVA: 0x7FFE87BE9140
        public void SetSources(){} // RVA: 0x7FFE87BE91A0
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BE9250
        public void AddSource(){} // RVA: 0x7FFE87BE92B0
        public void RemoveSource(){} // RVA: 0x7FFE87BE9310
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BE9380
        public void GetSource(){} // RVA: 0x7FFE87BE93E0
        public void GetSourceInternal(){} // RVA: 0x7FFE87BE9480
        public void SetSource(){} // RVA: 0x7FFE87BE9500
        public void SetSourceInternal(){} // RVA: 0x7FFE87BE9580
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BE95F0
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFE87BE97B0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFE87BE9810
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFE87BE9870
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFE87BE98D0
        public void AddSource_Injected(){} // RVA: 0x7FFE87BE9930
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BE9990
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BE9A00
    }

    public class MuscleHandle : ValueType
    {
        public 0x66696A0C _humanPartDof; // 0x10

        // ── Methods ──
        public void get_muscleHandleCount(){} // RVA: 0x7FFE87BE9A70
        public void GetMuscleHandles(){} // RVA: 0x7FFE87BE9AC0
        public void GetMuscleHandleCount(){} // RVA: 0x7FFE87BE9A70
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ParentConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BE9B10
        public void set_weight(){} // RVA: 0x7FFE87BE9B60
        public void get_constraintActive(){} // RVA: 0x7FFE87BE9BC0
        public void set_constraintActive(){} // RVA: 0x7FFE87BE9C10
        public void get_locked(){} // RVA: 0x7FFE87BE9C70
        public void set_locked(){} // RVA: 0x7FFE87BE9CC0
        public void get_sourceCount(){} // RVA: 0x7FFE87BE9D20
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BE9D20
        public void get_translationAtRest(){} // RVA: 0x7FFE87BE9D70
        public void set_translationAtRest(){} // RVA: 0x7FFE87BE9DE0
        public void get_rotationAtRest(){} // RVA: 0x7FFE87BE9E40
        public void set_rotationAtRest(){} // RVA: 0x7FFE87BE9EB0
        public void get_translationOffsets(){} // RVA: 0x7FFE87BE9F10
        public void set_translationOffsets(){} // RVA: 0x7FFE87BE9F60
        public void get_rotationOffsets(){} // RVA: 0x7FFE87BE9FC0
        public void set_rotationOffsets(){} // RVA: 0x7FFE87BEA010
        public void get_translationAxis(){} // RVA: 0x7FFE87BEA070
        public void set_translationAxis(){} // RVA: 0x7FFE87BEA0C0
        public void get_rotationAxis(){} // RVA: 0x7FFE87BEA120
        public void set_rotationAxis(){} // RVA: 0x7FFE87BEA170
        public void GetTranslationOffset(){} // RVA: 0x7FFE87BEA1D0
        public void SetTranslationOffset(){} // RVA: 0x7FFE87BEA280
        public void GetTranslationOffsetInternal(){} // RVA: 0x7FFE87BEA310
        public void SetTranslationOffsetInternal(){} // RVA: 0x7FFE87BEA390
        public void GetRotationOffset(){} // RVA: 0x7FFE87BEA400
        public void SetRotationOffset(){} // RVA: 0x7FFE87BEA4B0
        public void GetRotationOffsetInternal(){} // RVA: 0x7FFE87BEA540
        public void SetRotationOffsetInternal(){} // RVA: 0x7FFE87BEA5C0
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BEA630
        public void GetSources(){} // RVA: 0x7FFE87BEA7F0
        public void SetSources(){} // RVA: 0x7FFE87BEA850
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BEA900
        public void AddSource(){} // RVA: 0x7FFE87BEA960
        public void RemoveSource(){} // RVA: 0x7FFE87BEA9C0
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BEAA30
        public void GetSource(){} // RVA: 0x7FFE87BEAA90
        public void GetSourceInternal(){} // RVA: 0x7FFE87BEAB30
        public void SetSource(){} // RVA: 0x7FFE87BEABB0
        public void SetSourceInternal(){} // RVA: 0x7FFE87BEAC30
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFE87BEACA0
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFE87BEAD00
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFE87BEAD60
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFE87BEADC0
        public void GetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFE87BEAE20
        public void SetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFE87BEAE90
        public void GetRotationOffsetInternal_Injected(){} // RVA: 0x7FFE87BEAF00
        public void SetRotationOffsetInternal_Injected(){} // RVA: 0x7FFE87BEAF70
        public void AddSource_Injected(){} // RVA: 0x7FFE87BEAFE0
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BEB040
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BEB0B0
    }

    public class PositionConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BE6190
        public void set_weight(){} // RVA: 0x7FFE87BE61E0
        public void get_translationAtRest(){} // RVA: 0x7FFE87BE6240
        public void set_translationAtRest(){} // RVA: 0x7FFE87BE62B0
        public void get_translationOffset(){} // RVA: 0x7FFE87BE6310
        public void set_translationOffset(){} // RVA: 0x7FFE87BE6380
        public void get_translationAxis(){} // RVA: 0x7FFE87BE63E0
        public void set_translationAxis(){} // RVA: 0x7FFE87BE6430
        public void get_constraintActive(){} // RVA: 0x7FFE87BE6490
        public void set_constraintActive(){} // RVA: 0x7FFE87BE64E0
        public void get_locked(){} // RVA: 0x7FFE87BE6540
        public void set_locked(){} // RVA: 0x7FFE87BE6590
        public void get_sourceCount(){} // RVA: 0x7FFE87BE65F0
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BE65F0
        public void GetSources(){} // RVA: 0x7FFE87BE6640
        public void SetSources(){} // RVA: 0x7FFE87BE66A0
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BE6750
        public void AddSource(){} // RVA: 0x7FFE87BE67B0
        public void RemoveSource(){} // RVA: 0x7FFE87BE6810
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BE6880
        public void GetSource(){} // RVA: 0x7FFE87BE68E0
        public void GetSourceInternal(){} // RVA: 0x7FFE87BE6980
        public void SetSource(){} // RVA: 0x7FFE87BE6A00
        public void SetSourceInternal(){} // RVA: 0x7FFE87BE6A80
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BE6AF0
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFE87BE6CB0
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFE87BE6D10
        public void get_translationOffset_Injected(){} // RVA: 0x7FFE87BE6D70
        public void set_translationOffset_Injected(){} // RVA: 0x7FFE87BE6DD0
        public void AddSource_Injected(){} // RVA: 0x7FFE87BE6E30
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BE6E90
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BE6F00
    }

    public class ProcessAnimationJobStruct`1 : ValueType
    {
        // ── Methods ──
        public void GetJobReflectionData(){} // RVA: 0x7FFE80E2DEE0
        public void Execute(){} // RVA: 0x7FFE80E4EE20
    }

    public class RotationConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BE6F70
        public void set_weight(){} // RVA: 0x7FFE87BE6FC0
        public void get_rotationAtRest(){} // RVA: 0x7FFE87BE7020
        public void set_rotationAtRest(){} // RVA: 0x7FFE87BE7090
        public void get_rotationOffset(){} // RVA: 0x7FFE87BE70F0
        public void set_rotationOffset(){} // RVA: 0x7FFE87BE7160
        public void get_rotationAxis(){} // RVA: 0x7FFE87BE71C0
        public void set_rotationAxis(){} // RVA: 0x7FFE87BE7210
        public void get_constraintActive(){} // RVA: 0x7FFE87BE7270
        public void set_constraintActive(){} // RVA: 0x7FFE87BE72C0
        public void get_locked(){} // RVA: 0x7FFE87BE7320
        public void set_locked(){} // RVA: 0x7FFE87BE7370
        public void get_sourceCount(){} // RVA: 0x7FFE87BE73D0
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BE73D0
        public void GetSources(){} // RVA: 0x7FFE87BE7420
        public void SetSources(){} // RVA: 0x7FFE87BE7480
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BE7530
        public void AddSource(){} // RVA: 0x7FFE87BE7590
        public void RemoveSource(){} // RVA: 0x7FFE87BE75F0
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BE7660
        public void GetSource(){} // RVA: 0x7FFE87BE76C0
        public void GetSourceInternal(){} // RVA: 0x7FFE87BE7760
        public void SetSource(){} // RVA: 0x7FFE87BE77E0
        public void SetSourceInternal(){} // RVA: 0x7FFE87BE7860
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BE78D0
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFE87BE7A90
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFE87BE7AF0
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFE87BE7B50
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFE87BE7BB0
        public void AddSource_Injected(){} // RVA: 0x7FFE87BE7C10
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BE7C70
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BE7CE0
    }

    public class ScaleConstraint : Behaviour
    {
        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFE87BE7D50
        public void set_weight(){} // RVA: 0x7FFE87BE7DA0
        public void get_scaleAtRest(){} // RVA: 0x7FFE87BE7E00
        public void set_scaleAtRest(){} // RVA: 0x7FFE87BE7E70
        public void get_scaleOffset(){} // RVA: 0x7FFE87BE7ED0
        public void set_scaleOffset(){} // RVA: 0x7FFE87BE7F40
        public void get_scalingAxis(){} // RVA: 0x7FFE87BE7FA0
        public void set_scalingAxis(){} // RVA: 0x7FFE87BE7FF0
        public void get_constraintActive(){} // RVA: 0x7FFE87BE8050
        public void set_constraintActive(){} // RVA: 0x7FFE87BE80A0
        public void get_locked(){} // RVA: 0x7FFE87BE8100
        public void set_locked(){} // RVA: 0x7FFE87BE8150
        public void get_sourceCount(){} // RVA: 0x7FFE87BE81B0
        public void GetSourceCountInternal(){} // RVA: 0x7FFE87BE81B0
        public void GetSources(){} // RVA: 0x7FFE87BE8200
        public void SetSources(){} // RVA: 0x7FFE87BE8260
        public void SetSourcesInternal(){} // RVA: 0x7FFE87BE8310
        public void AddSource(){} // RVA: 0x7FFE87BE8370
        public void RemoveSource(){} // RVA: 0x7FFE87BE83D0
        public void RemoveSourceInternal(){} // RVA: 0x7FFE87BE8440
        public void GetSource(){} // RVA: 0x7FFE87BE84A0
        public void GetSourceInternal(){} // RVA: 0x7FFE87BE8540
        public void SetSource(){} // RVA: 0x7FFE87BE85C0
        public void SetSourceInternal(){} // RVA: 0x7FFE87BE8640
        public void ValidateSourceIndex(){} // RVA: 0x7FFE87BE86B0
        public void get_scaleAtRest_Injected(){} // RVA: 0x7FFE87BE8870
        public void set_scaleAtRest_Injected(){} // RVA: 0x7FFE87BE88D0
        public void get_scaleOffset_Injected(){} // RVA: 0x7FFE87BE8930
        public void set_scaleOffset_Injected(){} // RVA: 0x7FFE87BE8990
        public void AddSource_Injected(){} // RVA: 0x7FFE87BE89F0
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFE87BE8A50
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFE87BE8AC0
    }

    public class TransformStreamHandle : ValueType
    {
        public uint m_AnimatorBindingsVersion; // 0x10
        public int handleIndex; // 0x14
        public int skeletonIndex; // 0x18
        public object field_3; // 0xB3C0

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFE87BE1150
        public void get_createdByNative(){} // RVA: 0x7FFE87BE1190
        public void IsSameVersionAsStream(){} // RVA: 0x7FFE87BE11A0
        public void get_hasHandleIndex(){} // RVA: 0x7FFE87BE11B0
        public void get_hasSkeletonIndex(){} // RVA: 0x7FFE87BE11C0
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFE8733C3B0
        public void Resolve(){} // RVA: 0x7FFE87BE11D0
        public void IsResolved(){} // RVA: 0x7FFE87BE11F0
        public void IsResolvedInternal(){} // RVA: 0x7FFE87BE11F0
        public void CheckIsValidAndResolve(){} // RVA: 0x7FFE87BE1240
        public void SetLocalTRS(){} // RVA: 0x7FFE87BE1380
        public void ResolveInternal(){} // RVA: 0x7FFE87BE1470
        public void SetLocalTRSInternal(){} // RVA: 0x7FFE87BE14D0
        public void ResolveInternal_Injected(){} // RVA: 0x7FFE87BE1470
        public void SetLocalTRSInternal_Injected(){} // RVA: 0x7FFE87BE1580
    }

}