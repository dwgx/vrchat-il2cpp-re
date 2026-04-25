// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Animations
// Classes: 31
// Methods: 498

namespace ThirdParty.Unity.UnityEngine.Animations
{
    public class AimConstraint : Behaviour
    {
        public object weight;
        public object constraintActive;
        public object locked;
        public object rotationAtRest;
        public object rotationOffset;
        public object rotationAxis;
        public object aimVector;
        public object upVector;
        public object worldUpVector;
        public object worldUpObject;
        public object worldUpType;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC9833280
        public void set_weight(){} // RVA: 0x7FFAC98332D0
        public void get_constraintActive(){} // RVA: 0x7FFAC9833330
        public void set_constraintActive(){} // RVA: 0x7FFAC9833380
        public void get_locked(){} // RVA: 0x7FFAC98333E0
        public void set_locked(){} // RVA: 0x7FFAC9833430
        public void get_rotationAtRest(){} // RVA: 0x7FFAC9833490
        public void set_rotationAtRest(){} // RVA: 0x7FFAC9833500
        public void get_rotationOffset(){} // RVA: 0x7FFAC9833560
        public void set_rotationOffset(){} // RVA: 0x7FFAC98335D0
        public void get_rotationAxis(){} // RVA: 0x7FFAC9833630
        public void set_rotationAxis(){} // RVA: 0x7FFAC9833680
        public void get_aimVector(){} // RVA: 0x7FFAC98336E0
        public void set_aimVector(){} // RVA: 0x7FFAC9833750
        public void get_upVector(){} // RVA: 0x7FFAC98337B0
        public void set_upVector(){} // RVA: 0x7FFAC9833820
        public void get_worldUpVector(){} // RVA: 0x7FFAC9833880
        public void set_worldUpVector(){} // RVA: 0x7FFAC98338F0
        public void get_worldUpObject(){} // RVA: 0x7FFAC9833950
        public void set_worldUpObject(){} // RVA: 0x7FFAC98339A0
        public void get_worldUpType(){} // RVA: 0x7FFAC9833A00
        public void set_worldUpType(){} // RVA: 0x7FFAC9833A50
        public void get_sourceCount(){} // RVA: 0x7FFAC9833AB0
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC9833AB0
        public void GetSources(){} // RVA: 0x7FFAC9833B00
        public void SetSources(){} // RVA: 0x7FFAC9833B60
        public void SetSourcesInternal(){} // RVA: 0x7FFAC9833C10
        public void AddSource(){} // RVA: 0x7FFAC9833C70
        public void RemoveSource(){} // RVA: 0x7FFAC9833CD0
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC9833D40
        public void GetSource(){} // RVA: 0x7FFAC9833DA0
        public void GetSourceInternal(){} // RVA: 0x7FFAC9833E40
        public void SetSource(){} // RVA: 0x7FFAC9833EC0
        public void SetSourceInternal(){} // RVA: 0x7FFAC9833F40
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC9833FB0
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFAC9834170
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFAC98341D0
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFAC9834230
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFAC9834290
        public void get_aimVector_Injected(){} // RVA: 0x7FFAC98342F0
        public void set_aimVector_Injected(){} // RVA: 0x7FFAC9834350
        public void get_upVector_Injected(){} // RVA: 0x7FFAC98343B0
        public void set_upVector_Injected(){} // RVA: 0x7FFAC9834410
        public void get_worldUpVector_Injected(){} // RVA: 0x7FFAC9834470
        public void set_worldUpVector_Injected(){} // RVA: 0x7FFAC98344D0
        public void AddSource_Injected(){} // RVA: 0x7FFAC9834530
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC9834590
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC9834600
    }

    public class AnimationClipPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9834670
        public void CreateHandle(){} // RVA: 0x7FFAC9834810
        public void .ctor(){} // RVA: 0x7FFAC9834990
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
        public void Equals(){} // RVA: 0x7FFAC9834A90
        public void SetApplyFootIK(){} // RVA: 0x7FFAC9834B50
        public void SetRemoveStartOffset(){} // RVA: 0x7FFAC9834BB0
        public void SetOverrideLoopTime(){} // RVA: 0x7FFAC9834C10
        public void SetLoopTime(){} // RVA: 0x7FFAC9834C70
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9834CD0
        public void SetApplyFootIKInternal(){} // RVA: 0x7FFAC9834B50
        public void SetRemoveStartOffsetInternal(){} // RVA: 0x7FFAC9834BB0
        public void SetOverrideLoopTimeInternal(){} // RVA: 0x7FFAC9834C10
        public void SetLoopTimeInternal(){} // RVA: 0x7FFAC9834C70
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC9834D40
    }

    public class AnimationHumanStream : ValueType
    {
        public UIntPtr isValid; // 0x10

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFAC9834DB0
        public void ThrowIfInvalid(){} // RVA: 0x7FFAC9834DC0
        public void set_bodyLocalRotation(){} // RVA: 0x7FFAC9834E30
        public void SetMuscle(){} // RVA: 0x7FFAC9834EE0
        public void InternalSetBodyLocalRotation(){} // RVA: 0x7FFAC9834FA0
        public void InternalSetMuscle(){} // RVA: 0x7FFAC9835000
        public void InternalSetBodyLocalRotation_Injected(){} // RVA: 0x7FFAC9835070
        public void InternalSetMuscle_Injected(){} // RVA: 0x7FFAC98350D0
    }

    public class AnimationLayerMixerPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9835230 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFAC9835300
        public void .ctor(){} // RVA: 0x7FFAC9835560
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC98356C0
        public void Equals(){} // RVA: 0x7FFAC9835720
        public void SetLayerAdditive(){} // RVA: 0x7FFAC9835810
        public void SetLayerMaskFromAvatarMask(){} // RVA: 0x7FFAC98359D0
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9835C80
        public void SetLayerAdditiveInternal(){} // RVA: 0x7FFAC9835D20
        public void SetSingleLayerOptimizationInternal(){} // RVA: 0x7FFAC9835D90
        public void SetLayerMaskFromAvatarMaskInternal(){} // RVA: 0x7FFAC9835DF0
        public void .cctor(){} // RVA: 0x7FFAC9835E60
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC9835F30
    }

    public class AnimationMixerPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9835F90
        public void CreateHandle(){} // RVA: 0x7FFAC9836040
        public void .ctor(){} // RVA: 0x7FFAC98362A0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9836390
        public void Equals(){} // RVA: 0x7FFAC98363F0
        public void CreateHandleInternal(){} // RVA: 0x7FFAC98364E0
        public void .cctor(){} // RVA: 0x7FFAC9836580
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC9836650
    }

    public class AnimationMotionXToDeltaPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC98366B0
        public void CreateHandle(){} // RVA: 0x7FFAC9836750
        public void .ctor(){} // RVA: 0x7FFAC98369C0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9836AB0
        public void Equals(){} // RVA: 0x7FFAC9836B10
        public void SetAbsoluteMotion(){} // RVA: 0x7FFAC9836C00
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9836CA0
        public void SetAbsoluteMotionInternal(){} // RVA: 0x7FFAC9836D40
        public void .cctor(){} // RVA: 0x7FFAC9836DA0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC9836E70
    }

    public class AnimationOffsetPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9836ED0
        public void CreateHandle(){} // RVA: 0x7FFAC9836FC0
        public void .ctor(){} // RVA: 0x7FFAC9837260
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9837350
        public void Equals(){} // RVA: 0x7FFAC98373B0
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9837460
        public void .cctor(){} // RVA: 0x7FFAC9837520
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC98375F0
    }

    public class AnimationPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC98330A0
        public void CreateAnimationOutput(){} // RVA: 0x7FFAC9833230
    }

    public class AnimationPlayableExtensions : Object
    {
        // ── Methods ──
        public void SetAnimatedProperties(){} // RVA: 0x7FFAC2E8DC40
        public void SetAnimatedPropertiesInternal(){} // RVA: 0x7FFAC9837670
    }

    public class AnimationPlayableGraphExtensions : Object
    {
        // ── Methods ──
        public void InternalCreateAnimationOutput(){} // RVA: 0x7FFAC98376D0
    }

    public class AnimationPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle Null; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9837740
        public void .ctor(){} // RVA: 0x7FFAC9837900
        public void get_Null(){} // RVA: 0x7FFAC98379F0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
        public void op_Explicit(){} // RVA: 0x7FFAC9837AB0
        public void GetTarget(){} // RVA: 0x7FFAC9837B40
        public void SetTarget(){} // RVA: 0x7FFAC9837B90
        public void InternalGetTarget(){} // RVA: 0x7FFAC9837B40
        public void InternalSetTarget(){} // RVA: 0x7FFAC9837B90
    }

    public class AnimationPosePlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9837BF0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void Equals(){} // RVA: 0x7FFAC9837CE0
        public void .cctor(){} // RVA: 0x7FFAC9837D90
    }

    public class AnimationRemoveScalePlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9837E60
        public void CreateHandle(){} // RVA: 0x7FFAC9837F10
        public void .ctor(){} // RVA: 0x7FFAC9838170
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9838260
        public void Equals(){} // RVA: 0x7FFAC98382C0
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9838370
        public void .cctor(){} // RVA: 0x7FFAC9838410
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC98384E0
    }

    public class AnimationScriptPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10
        public UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void CreateHandle(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC9838540
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void CheckJobTypeValidity(){} // RVA: 0x7FFAC2C70980
        public void GetJobData(){} // RVA: 0x7FFAC2E8DC40
        public void SetJobData(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC9838630
        public void CreateHandleInternal(){} // RVA: 0x7FFAC9838720
        public void .cctor(){} // RVA: 0x7FFAC98387D0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC98388A0
    }

    public class AnimationStream : ValueType
    {
        public uint animatorBindingsVersion; // 0x10
        public UIntPtr isValid; // 0x18
        public UIntPtr isHumanStream; // 0x20
        public UIntPtr output; // 0x28
        public UIntPtr workspace; // 0x30
        public UIntPtr inputStreamAccessor; // 0x38
        public UIntPtr animationHandleBinder; // 0x40

        // ── Methods ──
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFAC8F93F90
        public void get_isValid(){} // RVA: 0x7FFAC9838910
        public void CheckIsValid(){} // RVA: 0x7FFAC9838940
        public void get_isHumanStream(){} // RVA: 0x7FFAC98389D0
        public void AsHuman(){} // RVA: 0x7FFAC9838A30
        public void GetIsHumanStream(){} // RVA: 0x7FFAC9838AE0
        public void GetHumanStream(){} // RVA: 0x7FFAC9838B30
        public void GetIsHumanStream_Injected(){} // RVA: 0x7FFAC9838AE0
        public void GetHumanStream_Injected(){} // RVA: 0x7FFAC9838BA0
    }

    public class AnimatorControllerPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle Null; // 0x10
        public UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAC98390D0
        public void Create(){} // RVA: 0x7FFAC9839140
        public void CreateHandle(){} // RVA: 0x7FFAC9839420
        public void .ctor(){} // RVA: 0x7FFAC98395F0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void SetHandle(){} // RVA: 0x7FFAC98396D0
        public void op_Implicit(){} // RVA: 0x7FFAC9839830
        public void op_Explicit(){} // RVA: 0x7FFAC9839890
        public void Equals(){} // RVA: 0x7FFAC98399C0
        public void GetFloat(){} // RVA: 0x7FFAC9839B50 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAC9839CA0 | overloaded x2
        public void GetBool(){} // RVA: 0x7FFAC9839DF0 | overloaded x2
        public void SetBool(){} // RVA: 0x7FFAC9839F40 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFAC983A090 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFAC983A1E0 | overloaded x2
        public void SetTrigger(){} // RVA: 0x7FFAC983A330 | overloaded x2
        public void ResetTrigger(){} // RVA: 0x7FFAC983A470 | overloaded x2
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFAC983A5B0 | overloaded x2
        public void GetLayerCount(){} // RVA: 0x7FFAC983A650
        public void GetLayerName(){} // RVA: 0x7FFAC983A6E0
        public void GetLayerIndex(){} // RVA: 0x7FFAC983A780
        public void GetLayerWeight(){} // RVA: 0x7FFAC983A820
        public void SetLayerWeight(){} // RVA: 0x7FFAC983A8C0
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7FFAC983A970
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7FFAC983AA90
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7FFAC983ABB0
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7FFAC983AD60 | overloaded x2
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7FFAC983B0C0 | overloaded x2
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7FFAC983AF00
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7FFAC983AF80
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7FFAC983B020
        public void IsInTransition(){} // RVA: 0x7FFAC983B160
        public void GetParameterCount(){} // RVA: 0x7FFAC983B200
        public void GetParameter(){} // RVA: 0x7FFAC983B290
        public void CrossFadeInFixedTime(){} // RVA: 0x7FFAC983B7D0 | overloaded x6
        public void CrossFade(){} // RVA: 0x7FFAC983BC70 | overloaded x6
        public void PlayInFixedTime(){} // RVA: 0x7FFAC983C050 | overloaded x6
        public void Play(){} // RVA: 0x7FFAC983C430 | overloaded x6
        public void HasState(){} // RVA: 0x7FFAC983C4C0
        public void ResolveHash(){} // RVA: 0x7FFAC983C570
        public void CreateHandleInternal(){} // RVA: 0x7FFAC983C610
        public void GetAnimatorControllerInternal(){} // RVA: 0x7FFAC983C6C0
        public void GetLayerCountInternal(){} // RVA: 0x7FFAC983C710
        public void GetLayerNameInternal(){} // RVA: 0x7FFAC983C760
        public void GetLayerIndexInternal(){} // RVA: 0x7FFAC983C7C0
        public void GetLayerWeightInternal(){} // RVA: 0x7FFAC983C820
        public void SetLayerWeightInternal(){} // RVA: 0x7FFAC983C880
        public void GetCurrentAnimatorStateInfoInternal(){} // RVA: 0x7FFAC983C8F0
        public void GetNextAnimatorStateInfoInternal(){} // RVA: 0x7FFAC983C9B0
        public void GetAnimatorTransitionInfoInternal(){} // RVA: 0x7FFAC983CA70
        public void GetCurrentAnimatorClipInfoInternal(){} // RVA: 0x7FFAC983CB20
        public void GetAnimatorClipInfoCountInternal(){} // RVA: 0x7FFAC983CB80
        public void GetNextAnimatorClipInfoInternal(){} // RVA: 0x7FFAC983CBF0
        public void ResolveHashInternal(){} // RVA: 0x7FFAC983CC50
        public void IsInTransitionInternal(){} // RVA: 0x7FFAC983CCB0
        public void GetParameterInternal(){} // RVA: 0x7FFAC983CD10
        public void GetParameterCountInternal(){} // RVA: 0x7FFAC983CD70
        public void StringToHash(){} // RVA: 0x7FFAC983CDC0
        public void CrossFadeInFixedTimeInternal(){} // RVA: 0x7FFAC983CE10
        public void CrossFadeInternal(){} // RVA: 0x7FFAC983CE90
        public void PlayInFixedTimeInternal(){} // RVA: 0x7FFAC983CF10
        public void PlayInternal(){} // RVA: 0x7FFAC983CF90
        public void HasStateInternal(){} // RVA: 0x7FFAC983D010
        public void SetFloatString(){} // RVA: 0x7FFAC983D080
        public void SetFloatID(){} // RVA: 0x7FFAC983D0F0
        public void GetFloatString(){} // RVA: 0x7FFAC983D160
        public void GetFloatID(){} // RVA: 0x7FFAC983D1C0
        public void SetBoolString(){} // RVA: 0x7FFAC983D220
        public void SetBoolID(){} // RVA: 0x7FFAC983D290
        public void GetBoolString(){} // RVA: 0x7FFAC983D300
        public void GetBoolID(){} // RVA: 0x7FFAC983D360
        public void SetIntegerString(){} // RVA: 0x7FFAC983D3C0
        public void SetIntegerID(){} // RVA: 0x7FFAC983D430
        public void GetIntegerString(){} // RVA: 0x7FFAC983D4A0
        public void GetIntegerID(){} // RVA: 0x7FFAC983D500
        public void SetTriggerString(){} // RVA: 0x7FFAC983D560
        public void SetTriggerID(){} // RVA: 0x7FFAC983D5C0
        public void ResetTriggerString(){} // RVA: 0x7FFAC983D620
        public void ResetTriggerID(){} // RVA: 0x7FFAC983D680
        public void IsParameterControlledByCurveString(){} // RVA: 0x7FFAC983D6E0
        public void IsParameterControlledByCurveID(){} // RVA: 0x7FFAC983D740
        public void .cctor(){} // RVA: 0x7FFAC983D7A0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFAC983D920
        public void GetCurrentAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFAC983D990
        public void GetNextAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFAC983DA00
        public void GetAnimatorTransitionInfoInternal_Injected(){} // RVA: 0x7FFAC983DA70
    }

    public class AnimatorJobExtensions : Object
    {
        // ── Methods ──
        public void BindStreamTransform(){} // RVA: 0x7FFAC983DAE0
        public void InternalBindStreamTransform(){} // RVA: 0x7FFAC983DB80
    }

    public class ConstraintSource : ValueType
    {
        public UnityEngine.Transform sourceTransform; // 0x10
        public float weight; // 0x18

        // ── Methods ──
        public void get_sourceTransform(){} // RVA: 0x7FFAC51D9A30
        public void set_sourceTransform(){} // RVA: 0x7FFAC38DFE40
        public void get_weight(){} // RVA: 0x7FFAC2F44CF0
        public void set_weight(){} // RVA: 0x7FFAC4A9B920
    }

    public class DiscreteEvaluationAttribute : Attribute
    {
    }

    public class IAnimationJob
    {
        // ── Methods ──
        public void ProcessAnimation(){} // RVA: 0x7FFAC2E8DC40
        public void ProcessRootMotion(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAnimationWindowPreview
    {
        // ── Methods ──
        public void UpdatePreviewGraph(){}
    }

    public class IConstraint
    {
        public object weight;
        public object constraintActive;
        public object locked;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC2C6D880
        public void get_constraintActive(){} // RVA: 0x7FFAC2C59D00
        public void get_locked(){} // RVA: 0x7FFAC2C59D00
        public void get_sourceCount(){} // RVA: 0x7FFAC2C59960
        public void GetSource(){}
    }

    public class LookAtConstraint : Behaviour
    {
        public object weight;
        public object roll;
        public object constraintActive;
        public object locked;
        public object rotationAtRest;
        public object rotationOffset;
        public object worldUpObject;
        public object useUpObject;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC9840590
        public void set_weight(){} // RVA: 0x7FFAC98405E0
        public void get_roll(){} // RVA: 0x7FFAC9840640
        public void set_roll(){} // RVA: 0x7FFAC9840690
        public void get_constraintActive(){} // RVA: 0x7FFAC98406F0
        public void set_constraintActive(){} // RVA: 0x7FFAC9840740
        public void get_locked(){} // RVA: 0x7FFAC98407A0
        public void set_locked(){} // RVA: 0x7FFAC98407F0
        public void get_rotationAtRest(){} // RVA: 0x7FFAC9840850
        public void set_rotationAtRest(){} // RVA: 0x7FFAC98408C0
        public void get_rotationOffset(){} // RVA: 0x7FFAC9840920
        public void set_rotationOffset(){} // RVA: 0x7FFAC9840990
        public void get_worldUpObject(){} // RVA: 0x7FFAC98409F0
        public void set_worldUpObject(){} // RVA: 0x7FFAC9840A40
        public void get_useUpObject(){} // RVA: 0x7FFAC9840AA0
        public void set_useUpObject(){} // RVA: 0x7FFAC9840AF0
        public void get_sourceCount(){} // RVA: 0x7FFAC9840B50
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC9840B50
        public void GetSources(){} // RVA: 0x7FFAC9840BA0
        public void SetSources(){} // RVA: 0x7FFAC9840C00
        public void SetSourcesInternal(){} // RVA: 0x7FFAC9840CB0
        public void AddSource(){} // RVA: 0x7FFAC9840D10
        public void RemoveSource(){} // RVA: 0x7FFAC9840D70
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC9840DE0
        public void GetSource(){} // RVA: 0x7FFAC9840E40
        public void GetSourceInternal(){} // RVA: 0x7FFAC9840EE0
        public void SetSource(){} // RVA: 0x7FFAC9840F60
        public void SetSourceInternal(){} // RVA: 0x7FFAC9840FE0
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC9841050
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFAC9841210
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFAC9841270
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFAC98412D0
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFAC9841330
        public void AddSource_Injected(){} // RVA: 0x7FFAC9841390
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC98413F0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC9841460
    }

    public class MuscleHandle : ValueType
    {
        public 0x6B29CC20 muscleHandleCount; // 0x10
        public int <dof>k__BackingField; // 0x14

        // ── Methods ──
        public void get_muscleHandleCount(){} // RVA: 0x7FFAC98414D0
        public void GetMuscleHandles(){} // RVA: 0x7FFAC9841520
        public void GetMuscleHandleCount(){} // RVA: 0x7FFAC98414D0
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ParentConstraint : Behaviour
    {
        public object weight;
        public object constraintActive;
        public object locked;
        public object sourceCount;
        public object translationAtRest;
        public object rotationAtRest;
        public object translationOffsets;
        public object rotationOffsets;
        public object translationAxis;
        public object rotationAxis;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC9841570
        public void set_weight(){} // RVA: 0x7FFAC98415C0
        public void get_constraintActive(){} // RVA: 0x7FFAC9841620
        public void set_constraintActive(){} // RVA: 0x7FFAC9841670
        public void get_locked(){} // RVA: 0x7FFAC98416D0
        public void set_locked(){} // RVA: 0x7FFAC9841720
        public void get_sourceCount(){} // RVA: 0x7FFAC9841780
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC9841780
        public void get_translationAtRest(){} // RVA: 0x7FFAC98417D0
        public void set_translationAtRest(){} // RVA: 0x7FFAC9841840
        public void get_rotationAtRest(){} // RVA: 0x7FFAC98418A0
        public void set_rotationAtRest(){} // RVA: 0x7FFAC9841910
        public void get_translationOffsets(){} // RVA: 0x7FFAC9841970
        public void set_translationOffsets(){} // RVA: 0x7FFAC98419C0
        public void get_rotationOffsets(){} // RVA: 0x7FFAC9841A20
        public void set_rotationOffsets(){} // RVA: 0x7FFAC9841A70
        public void get_translationAxis(){} // RVA: 0x7FFAC9841AD0
        public void set_translationAxis(){} // RVA: 0x7FFAC9841B20
        public void get_rotationAxis(){} // RVA: 0x7FFAC9841B80
        public void set_rotationAxis(){} // RVA: 0x7FFAC9841BD0
        public void GetTranslationOffset(){} // RVA: 0x7FFAC9841C30
        public void SetTranslationOffset(){} // RVA: 0x7FFAC9841CE0
        public void GetTranslationOffsetInternal(){} // RVA: 0x7FFAC9841D70
        public void SetTranslationOffsetInternal(){} // RVA: 0x7FFAC9841DF0
        public void GetRotationOffset(){} // RVA: 0x7FFAC9841E60
        public void SetRotationOffset(){} // RVA: 0x7FFAC9841F10
        public void GetRotationOffsetInternal(){} // RVA: 0x7FFAC9841FA0
        public void SetRotationOffsetInternal(){} // RVA: 0x7FFAC9842020
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC9842090
        public void GetSources(){} // RVA: 0x7FFAC9842250
        public void SetSources(){} // RVA: 0x7FFAC98422B0
        public void SetSourcesInternal(){} // RVA: 0x7FFAC9842360
        public void AddSource(){} // RVA: 0x7FFAC98423C0
        public void RemoveSource(){} // RVA: 0x7FFAC9842420
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC9842490
        public void GetSource(){} // RVA: 0x7FFAC98424F0
        public void GetSourceInternal(){} // RVA: 0x7FFAC9842590
        public void SetSource(){} // RVA: 0x7FFAC9842610
        public void SetSourceInternal(){} // RVA: 0x7FFAC9842690
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFAC9842700
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFAC9842760
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFAC98427C0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFAC9842820
        public void GetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFAC9842880
        public void SetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFAC98428F0
        public void GetRotationOffsetInternal_Injected(){} // RVA: 0x7FFAC9842960
        public void SetRotationOffsetInternal_Injected(){} // RVA: 0x7FFAC98429D0
        public void AddSource_Injected(){} // RVA: 0x7FFAC9842A40
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC9842AA0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC9842B10
    }

    public class PositionConstraint : Behaviour
    {
        public object weight;
        public object translationAtRest;
        public object translationOffset;
        public object translationAxis;
        public object constraintActive;
        public object locked;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC983DBF0
        public void set_weight(){} // RVA: 0x7FFAC983DC40
        public void get_translationAtRest(){} // RVA: 0x7FFAC983DCA0
        public void set_translationAtRest(){} // RVA: 0x7FFAC983DD10
        public void get_translationOffset(){} // RVA: 0x7FFAC983DD70
        public void set_translationOffset(){} // RVA: 0x7FFAC983DDE0
        public void get_translationAxis(){} // RVA: 0x7FFAC983DE40
        public void set_translationAxis(){} // RVA: 0x7FFAC983DE90
        public void get_constraintActive(){} // RVA: 0x7FFAC983DEF0
        public void set_constraintActive(){} // RVA: 0x7FFAC983DF40
        public void get_locked(){} // RVA: 0x7FFAC983DFA0
        public void set_locked(){} // RVA: 0x7FFAC983DFF0
        public void get_sourceCount(){} // RVA: 0x7FFAC983E050
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC983E050
        public void GetSources(){} // RVA: 0x7FFAC983E0A0
        public void SetSources(){} // RVA: 0x7FFAC983E100
        public void SetSourcesInternal(){} // RVA: 0x7FFAC983E1B0
        public void AddSource(){} // RVA: 0x7FFAC983E210
        public void RemoveSource(){} // RVA: 0x7FFAC983E270
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC983E2E0
        public void GetSource(){} // RVA: 0x7FFAC983E340
        public void GetSourceInternal(){} // RVA: 0x7FFAC983E3E0
        public void SetSource(){} // RVA: 0x7FFAC983E460
        public void SetSourceInternal(){} // RVA: 0x7FFAC983E4E0
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC983E550
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFAC983E710
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFAC983E770
        public void get_translationOffset_Injected(){} // RVA: 0x7FFAC983E7D0
        public void set_translationOffset_Injected(){} // RVA: 0x7FFAC983E830
        public void AddSource_Injected(){} // RVA: 0x7FFAC983E890
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC983E8F0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC983E960
    }

    public class ProcessAnimationJobStruct`1 : ValueType
    {
        public UIntPtr jobReflectionData;

        // ── Methods ──
        public void GetJobReflectionData(){} // RVA: 0x7FFAC2C58A90
        public void Execute(){} // RVA: 0x7FFAC2C79720
    }

    public class RotationConstraint : Behaviour
    {
        public object weight;
        public object rotationAtRest;
        public object rotationOffset;
        public object rotationAxis;
        public object constraintActive;
        public object locked;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC983E9D0
        public void set_weight(){} // RVA: 0x7FFAC983EA20
        public void get_rotationAtRest(){} // RVA: 0x7FFAC983EA80
        public void set_rotationAtRest(){} // RVA: 0x7FFAC983EAF0
        public void get_rotationOffset(){} // RVA: 0x7FFAC983EB50
        public void set_rotationOffset(){} // RVA: 0x7FFAC983EBC0
        public void get_rotationAxis(){} // RVA: 0x7FFAC983EC20
        public void set_rotationAxis(){} // RVA: 0x7FFAC983EC70
        public void get_constraintActive(){} // RVA: 0x7FFAC983ECD0
        public void set_constraintActive(){} // RVA: 0x7FFAC983ED20
        public void get_locked(){} // RVA: 0x7FFAC983ED80
        public void set_locked(){} // RVA: 0x7FFAC983EDD0
        public void get_sourceCount(){} // RVA: 0x7FFAC983EE30
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC983EE30
        public void GetSources(){} // RVA: 0x7FFAC983EE80
        public void SetSources(){} // RVA: 0x7FFAC983EEE0
        public void SetSourcesInternal(){} // RVA: 0x7FFAC983EF90
        public void AddSource(){} // RVA: 0x7FFAC983EFF0
        public void RemoveSource(){} // RVA: 0x7FFAC983F050
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC983F0C0
        public void GetSource(){} // RVA: 0x7FFAC983F120
        public void GetSourceInternal(){} // RVA: 0x7FFAC983F1C0
        public void SetSource(){} // RVA: 0x7FFAC983F240
        public void SetSourceInternal(){} // RVA: 0x7FFAC983F2C0
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC983F330
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFAC983F4F0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFAC983F550
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFAC983F5B0
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFAC983F610
        public void AddSource_Injected(){} // RVA: 0x7FFAC983F670
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC983F6D0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC983F740
    }

    public class ScaleConstraint : Behaviour
    {
        public object weight;
        public object scaleAtRest;
        public object scaleOffset;
        public object scalingAxis;
        public object constraintActive;
        public object locked;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFAC983F7B0
        public void set_weight(){} // RVA: 0x7FFAC983F800
        public void get_scaleAtRest(){} // RVA: 0x7FFAC983F860
        public void set_scaleAtRest(){} // RVA: 0x7FFAC983F8D0
        public void get_scaleOffset(){} // RVA: 0x7FFAC983F930
        public void set_scaleOffset(){} // RVA: 0x7FFAC983F9A0
        public void get_scalingAxis(){} // RVA: 0x7FFAC983FA00
        public void set_scalingAxis(){} // RVA: 0x7FFAC983FA50
        public void get_constraintActive(){} // RVA: 0x7FFAC983FAB0
        public void set_constraintActive(){} // RVA: 0x7FFAC983FB00
        public void get_locked(){} // RVA: 0x7FFAC983FB60
        public void set_locked(){} // RVA: 0x7FFAC983FBB0
        public void get_sourceCount(){} // RVA: 0x7FFAC983FC10
        public void GetSourceCountInternal(){} // RVA: 0x7FFAC983FC10
        public void GetSources(){} // RVA: 0x7FFAC983FC60
        public void SetSources(){} // RVA: 0x7FFAC983FCC0
        public void SetSourcesInternal(){} // RVA: 0x7FFAC983FD70
        public void AddSource(){} // RVA: 0x7FFAC983FDD0
        public void RemoveSource(){} // RVA: 0x7FFAC983FE30
        public void RemoveSourceInternal(){} // RVA: 0x7FFAC983FEA0
        public void GetSource(){} // RVA: 0x7FFAC983FF00
        public void GetSourceInternal(){} // RVA: 0x7FFAC983FFA0
        public void SetSource(){} // RVA: 0x7FFAC9840020
        public void SetSourceInternal(){} // RVA: 0x7FFAC98400A0
        public void ValidateSourceIndex(){} // RVA: 0x7FFAC9840110
        public void get_scaleAtRest_Injected(){} // RVA: 0x7FFAC98402D0
        public void set_scaleAtRest_Injected(){} // RVA: 0x7FFAC9840330
        public void get_scaleOffset_Injected(){} // RVA: 0x7FFAC9840390
        public void set_scaleOffset_Injected(){} // RVA: 0x7FFAC98403F0
        public void AddSource_Injected(){} // RVA: 0x7FFAC9840450
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFAC98404B0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFAC9840520
    }

    public class TransformStreamHandle : ValueType
    {
        public uint createdByNative; // 0x10
        public int hasHandleIndex; // 0x14
        public int hasSkeletonIndex; // 0x18

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFAC9838C00
        public void get_createdByNative(){} // RVA: 0x7FFAC9838C40
        public void IsSameVersionAsStream(){} // RVA: 0x7FFAC9838C50
        public void get_hasHandleIndex(){} // RVA: 0x7FFAC9838C60
        public void get_hasSkeletonIndex(){} // RVA: 0x7FFAC9838C70
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFAC8F93F90
        public void Resolve(){} // RVA: 0x7FFAC9838C80
        public void IsResolved(){} // RVA: 0x7FFAC9838CA0
        public void IsResolvedInternal(){} // RVA: 0x7FFAC9838CA0
        public void CheckIsValidAndResolve(){} // RVA: 0x7FFAC9838CF0
        public void SetLocalTRS(){} // RVA: 0x7FFAC9838E30
        public void ResolveInternal(){} // RVA: 0x7FFAC9838F20
        public void SetLocalTRSInternal(){} // RVA: 0x7FFAC9838F80
        public void ResolveInternal_Injected(){} // RVA: 0x7FFAC9838F20
        public void SetLocalTRSInternal_Injected(){} // RVA: 0x7FFAC9839030
    }

}