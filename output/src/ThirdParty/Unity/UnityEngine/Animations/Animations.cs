// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Animations
// Classes: 27
// Methods: 492

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
        public void get_weight(){} // RVA: 0x7FFD54C53280
        public void set_weight(){} // RVA: 0x7FFD54C532D0
        public void get_constraintActive(){} // RVA: 0x7FFD54C53330
        public void set_constraintActive(){} // RVA: 0x7FFD54C53380
        public void get_locked(){} // RVA: 0x7FFD54C533E0
        public void set_locked(){} // RVA: 0x7FFD54C53430
        public void get_rotationAtRest(){} // RVA: 0x7FFD54C53490
        public void set_rotationAtRest(){} // RVA: 0x7FFD54C53500
        public void get_rotationOffset(){} // RVA: 0x7FFD54C53560
        public void set_rotationOffset(){} // RVA: 0x7FFD54C535D0
        public void get_rotationAxis(){} // RVA: 0x7FFD54C53630
        public void set_rotationAxis(){} // RVA: 0x7FFD54C53680
        public void get_aimVector(){} // RVA: 0x7FFD54C536E0
        public void set_aimVector(){} // RVA: 0x7FFD54C53750
        public void get_upVector(){} // RVA: 0x7FFD54C537B0
        public void set_upVector(){} // RVA: 0x7FFD54C53820
        public void get_worldUpVector(){} // RVA: 0x7FFD54C53880
        public void set_worldUpVector(){} // RVA: 0x7FFD54C538F0
        public void get_worldUpObject(){} // RVA: 0x7FFD54C53950
        public void set_worldUpObject(){} // RVA: 0x7FFD54C539A0
        public void get_worldUpType(){} // RVA: 0x7FFD54C53A00
        public void set_worldUpType(){} // RVA: 0x7FFD54C53A50
        public void get_sourceCount(){} // RVA: 0x7FFD54C53AB0
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C53AB0
        public void GetSources(){} // RVA: 0x7FFD54C53B00
        public void SetSources(){} // RVA: 0x7FFD54C53B60
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C53C10
        public void AddSource(){} // RVA: 0x7FFD54C53C70
        public void RemoveSource(){} // RVA: 0x7FFD54C53CD0
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C53D40
        public void GetSource(){} // RVA: 0x7FFD54C53DA0
        public void GetSourceInternal(){} // RVA: 0x7FFD54C53E40
        public void SetSource(){} // RVA: 0x7FFD54C53EC0
        public void SetSourceInternal(){} // RVA: 0x7FFD54C53F40
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C53FB0
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFD54C54170
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFD54C541D0
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFD54C54230
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFD54C54290
        public void get_aimVector_Injected(){} // RVA: 0x7FFD54C542F0
        public void set_aimVector_Injected(){} // RVA: 0x7FFD54C54350
        public void get_upVector_Injected(){} // RVA: 0x7FFD54C543B0
        public void set_upVector_Injected(){} // RVA: 0x7FFD54C54410
        public void get_worldUpVector_Injected(){} // RVA: 0x7FFD54C54470
        public void set_worldUpVector_Injected(){} // RVA: 0x7FFD54C544D0
        public void AddSource_Injected(){} // RVA: 0x7FFD54C54530
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C54590
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C54600
    }

    public class AnimationClipPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C54670
        public void CreateHandle(){} // RVA: 0x7FFD54C54810
        public void .ctor(){} // RVA: 0x7FFD54C54990
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
        public void Equals(){} // RVA: 0x7FFD54C54A90
        public void SetApplyFootIK(){} // RVA: 0x7FFD54C54B50
        public void SetRemoveStartOffset(){} // RVA: 0x7FFD54C54BB0
        public void SetOverrideLoopTime(){} // RVA: 0x7FFD54C54C10
        public void SetLoopTime(){} // RVA: 0x7FFD54C54C70
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C54CD0
        public void SetApplyFootIKInternal(){} // RVA: 0x7FFD54C54B50
        public void SetRemoveStartOffsetInternal(){} // RVA: 0x7FFD54C54BB0
        public void SetOverrideLoopTimeInternal(){} // RVA: 0x7FFD54C54C10
        public void SetLoopTimeInternal(){} // RVA: 0x7FFD54C54C70
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C54D40
    }

    public class AnimationHumanStream : ValueType
    {
        public UIntPtr isValid; // 0x10

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFD54C54DB0
        public void ThrowIfInvalid(){} // RVA: 0x7FFD54C54DC0
        public void set_bodyLocalRotation(){} // RVA: 0x7FFD54C54E30
        public void SetMuscle(){} // RVA: 0x7FFD54C54EE0
        public void InternalSetBodyLocalRotation(){} // RVA: 0x7FFD54C54FA0
        public void InternalSetMuscle(){} // RVA: 0x7FFD54C55000
        public void InternalSetBodyLocalRotation_Injected(){} // RVA: 0x7FFD54C55070
        public void InternalSetMuscle_Injected(){} // RVA: 0x7FFD54C550D0
    }

    public class AnimationLayerMixerPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.yScale m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C55230 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFD54C55300
        public void .ctor(){} // RVA: 0x7FFD54C55560
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C556C0
        public void Equals(){} // RVA: 0x7FFD54C55720
        public void SetLayerAdditive(){} // RVA: 0x7FFD54C55810
        public void SetLayerMaskFromAvatarMask(){} // RVA: 0x7FFD54C559D0
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C55C80
        public void SetLayerAdditiveInternal(){} // RVA: 0x7FFD54C55D20
        public void SetSingleLayerOptimizationInternal(){} // RVA: 0x7FFD54C55D90
        public void SetLayerMaskFromAvatarMaskInternal(){} // RVA: 0x7FFD54C55DF0
        public void .cctor(){} // RVA: 0x7FFD54C55E60
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C55F30
    }

    public class AnimationMixerPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.ts m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C55F90
        public void CreateHandle(){} // RVA: 0x7FFD54C56040
        public void .ctor(){} // RVA: 0x7FFD54C562A0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C56390
        public void Equals(){} // RVA: 0x7FFD54C563F0
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C564E0
        public void .cctor(){} // RVA: 0x7FFD54C56580
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C56650
    }

    public class AnimationMotionXToDeltaPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.eeping m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C566B0
        public void CreateHandle(){} // RVA: 0x7FFD54C56750
        public void .ctor(){} // RVA: 0x7FFD54C569C0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C56AB0
        public void Equals(){} // RVA: 0x7FFD54C56B10
        public void SetAbsoluteMotion(){} // RVA: 0x7FFD54C56C00
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C56CA0
        public void SetAbsoluteMotionInternal(){} // RVA: 0x7FFD54C56D40
        public void .cctor(){} // RVA: 0x7FFD54C56DA0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C56E70
    }

    public class AnimationOffsetPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.et_sleepMode m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C56ED0
        public void CreateHandle(){} // RVA: 0x7FFD54C56FC0
        public void .ctor(){} // RVA: 0x7FFD54C57260
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C57350
        public void Equals(){} // RVA: 0x7FFD54C573B0
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C57460
        public void .cctor(){} // RVA: 0x7FFD54C57520
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C575F0
    }

    public class AnimationPlayableExtensions : Object
    {
        // ── Methods ──
        public void SetAnimatedProperties(){} // RVA: 0x7FFD4E2ADC40
        public void SetAnimatedPropertiesInternal(){} // RVA: 0x7FFD54C57670
    }

    public class AnimationPlayableOutput : ValueType
    {
        public oUpdateAPI.gerUpdate Null; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C57740
        public void .ctor(){} // RVA: 0x7FFD54C57900
        public void get_Null(){} // RVA: 0x7FFD54C579F0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
        public void op_Explicit(){} // RVA: 0x7FFD54C57AB0
        public void GetTarget(){} // RVA: 0x7FFD54C57B40
        public void SetTarget(){} // RVA: 0x7FFD54C57B90
        public void InternalGetTarget(){} // RVA: 0x7FFD54C57B40
        public void InternalSetTarget(){} // RVA: 0x7FFD54C57B90
    }

    public class AnimationPosePlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.liderWithFilter_Internal m_NullPlayable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C57BF0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void Equals(){} // RVA: 0x7FFD54C57CE0
        public void .cctor(){} // RVA: 0x7FFD54C57D90
    }

    public class AnimationRemoveScalePlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.al m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C57E60
        public void CreateHandle(){} // RVA: 0x7FFD54C57F10
        public void .ctor(){} // RVA: 0x7FFD54C58170
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C58260
        public void Equals(){} // RVA: 0x7FFD54C582C0
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C58370
        public void .cctor(){} // RVA: 0x7FFD54C58410
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C584E0
    }

    public class AnimationScriptPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents m_Handle; // 0x10
        public verlapped.Filter_Internal m_NullPlayable;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void CreateHandle(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD54C58540
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void CheckJobTypeValidity(){} // RVA: 0x7FFD4E090980
        public void GetJobData(){} // RVA: 0x7FFD4E2ADC40
        public void SetJobData(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD54C58630
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C58720
        public void .cctor(){} // RVA: 0x7FFD54C587D0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C588A0
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
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFD543B3F90
        public void get_isValid(){} // RVA: 0x7FFD54C58910
        public void CheckIsValid(){} // RVA: 0x7FFD54C58940
        public void get_isHumanStream(){} // RVA: 0x7FFD54C589D0
        public void AsHuman(){} // RVA: 0x7FFD54C58A30
        public void GetIsHumanStream(){} // RVA: 0x7FFD54C58AE0
        public void GetHumanStream(){} // RVA: 0x7FFD54C58B30
        public void GetIsHumanStream_Injected(){} // RVA: 0x7FFD54C58AE0
        public void GetHumanStream_Injected(){} // RVA: 0x7FFD54C58BA0
    }

    public class AnimatorControllerPlayable : ValueType
    {
        public oUpdateAPI.osPlatformEvents Null; // 0x10
        public verlapped.s_Injected m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFD54C590D0
        public void Create(){} // RVA: 0x7FFD54C59140
        public void CreateHandle(){} // RVA: 0x7FFD54C59420
        public void .ctor(){} // RVA: 0x7FFD54C595F0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void SetHandle(){} // RVA: 0x7FFD54C596D0
        public void op_Implicit(){} // RVA: 0x7FFD54C59830
        public void op_Explicit(){} // RVA: 0x7FFD54C59890
        public void Equals(){} // RVA: 0x7FFD54C599C0
        public void GetFloat(){} // RVA: 0x7FFD54C59B50 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFD54C59CA0 | overloaded x2
        public void GetBool(){} // RVA: 0x7FFD54C59DF0 | overloaded x2
        public void SetBool(){} // RVA: 0x7FFD54C59F40 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFD54C5A090 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFD54C5A1E0 | overloaded x2
        public void SetTrigger(){} // RVA: 0x7FFD54C5A330 | overloaded x2
        public void ResetTrigger(){} // RVA: 0x7FFD54C5A470 | overloaded x2
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFD54C5A5B0 | overloaded x2
        public void GetLayerCount(){} // RVA: 0x7FFD54C5A650
        public void GetLayerName(){} // RVA: 0x7FFD54C5A6E0
        public void GetLayerIndex(){} // RVA: 0x7FFD54C5A780
        public void GetLayerWeight(){} // RVA: 0x7FFD54C5A820
        public void SetLayerWeight(){} // RVA: 0x7FFD54C5A8C0
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7FFD54C5A970
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7FFD54C5AA90
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7FFD54C5ABB0
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7FFD54C5AD60 | overloaded x2
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7FFD54C5B0C0 | overloaded x2
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7FFD54C5AF00
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7FFD54C5AF80
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7FFD54C5B020
        public void IsInTransition(){} // RVA: 0x7FFD54C5B160
        public void GetParameterCount(){} // RVA: 0x7FFD54C5B200
        public void GetParameter(){} // RVA: 0x7FFD54C5B290
        public void CrossFadeInFixedTime(){} // RVA: 0x7FFD54C5B7D0 | overloaded x6
        public void CrossFade(){} // RVA: 0x7FFD54C5BC70 | overloaded x6
        public void PlayInFixedTime(){} // RVA: 0x7FFD54C5C050 | overloaded x6
        public void Play(){} // RVA: 0x7FFD54C5C430 | overloaded x6
        public void HasState(){} // RVA: 0x7FFD54C5C4C0
        public void ResolveHash(){} // RVA: 0x7FFD54C5C570
        public void CreateHandleInternal(){} // RVA: 0x7FFD54C5C610
        public void GetAnimatorControllerInternal(){} // RVA: 0x7FFD54C5C6C0
        public void GetLayerCountInternal(){} // RVA: 0x7FFD54C5C710
        public void GetLayerNameInternal(){} // RVA: 0x7FFD54C5C760
        public void GetLayerIndexInternal(){} // RVA: 0x7FFD54C5C7C0
        public void GetLayerWeightInternal(){} // RVA: 0x7FFD54C5C820
        public void SetLayerWeightInternal(){} // RVA: 0x7FFD54C5C880
        public void GetCurrentAnimatorStateInfoInternal(){} // RVA: 0x7FFD54C5C8F0
        public void GetNextAnimatorStateInfoInternal(){} // RVA: 0x7FFD54C5C9B0
        public void GetAnimatorTransitionInfoInternal(){} // RVA: 0x7FFD54C5CA70
        public void GetCurrentAnimatorClipInfoInternal(){} // RVA: 0x7FFD54C5CB20
        public void GetAnimatorClipInfoCountInternal(){} // RVA: 0x7FFD54C5CB80
        public void GetNextAnimatorClipInfoInternal(){} // RVA: 0x7FFD54C5CBF0
        public void ResolveHashInternal(){} // RVA: 0x7FFD54C5CC50
        public void IsInTransitionInternal(){} // RVA: 0x7FFD54C5CCB0
        public void GetParameterInternal(){} // RVA: 0x7FFD54C5CD10
        public void GetParameterCountInternal(){} // RVA: 0x7FFD54C5CD70
        public void StringToHash(){} // RVA: 0x7FFD54C5CDC0
        public void CrossFadeInFixedTimeInternal(){} // RVA: 0x7FFD54C5CE10
        public void CrossFadeInternal(){} // RVA: 0x7FFD54C5CE90
        public void PlayInFixedTimeInternal(){} // RVA: 0x7FFD54C5CF10
        public void PlayInternal(){} // RVA: 0x7FFD54C5CF90
        public void HasStateInternal(){} // RVA: 0x7FFD54C5D010
        public void SetFloatString(){} // RVA: 0x7FFD54C5D080
        public void SetFloatID(){} // RVA: 0x7FFD54C5D0F0
        public void GetFloatString(){} // RVA: 0x7FFD54C5D160
        public void GetFloatID(){} // RVA: 0x7FFD54C5D1C0
        public void SetBoolString(){} // RVA: 0x7FFD54C5D220
        public void SetBoolID(){} // RVA: 0x7FFD54C5D290
        public void GetBoolString(){} // RVA: 0x7FFD54C5D300
        public void GetBoolID(){} // RVA: 0x7FFD54C5D360
        public void SetIntegerString(){} // RVA: 0x7FFD54C5D3C0
        public void SetIntegerID(){} // RVA: 0x7FFD54C5D430
        public void GetIntegerString(){} // RVA: 0x7FFD54C5D4A0
        public void GetIntegerID(){} // RVA: 0x7FFD54C5D500
        public void SetTriggerString(){} // RVA: 0x7FFD54C5D560
        public void SetTriggerID(){} // RVA: 0x7FFD54C5D5C0
        public void ResetTriggerString(){} // RVA: 0x7FFD54C5D620
        public void ResetTriggerID(){} // RVA: 0x7FFD54C5D680
        public void IsParameterControlledByCurveString(){} // RVA: 0x7FFD54C5D6E0
        public void IsParameterControlledByCurveID(){} // RVA: 0x7FFD54C5D740
        public void .cctor(){} // RVA: 0x7FFD54C5D7A0
        public void CreateHandleInternal_Injected(){} // RVA: 0x7FFD54C5D920
        public void GetCurrentAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFD54C5D990
        public void GetNextAnimatorStateInfoInternal_Injected(){} // RVA: 0x7FFD54C5DA00
        public void GetAnimatorTransitionInfoInternal_Injected(){} // RVA: 0x7FFD54C5DA70
    }

    public class ConstraintSource : ValueType
    {
        public object sourceTransform; // 0x10
        public float weight; // 0x18

        // ── Methods ──
        public void get_sourceTransform(){} // RVA: 0x7FFD505F9A30
        public void set_sourceTransform(){} // RVA: 0x7FFD4ECFFE40
        public void get_weight(){} // RVA: 0x7FFD4E364CF0
        public void set_weight(){} // RVA: 0x7FFD4FEBB920
    }

    public class DiscreteEvaluationAttribute : Attribute
    {
    }

    public class IAnimationJob
    {
        // ── Methods ──
        public void ProcessAnimation(){} // RVA: 0x7FFD4E2ADC40
        public void ProcessRootMotion(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IConstraint
    {
        public object weight;
        public object constraintActive;
        public object locked;
        public object sourceCount;

        // ── Methods ──
        public void get_weight(){} // RVA: 0x7FFD4E08D880
        public void get_constraintActive(){} // RVA: 0x7FFD4E079D00
        public void get_locked(){} // RVA: 0x7FFD4E079D00
        public void get_sourceCount(){} // RVA: 0x7FFD4E079960
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
        public void get_weight(){} // RVA: 0x7FFD54C60590
        public void set_weight(){} // RVA: 0x7FFD54C605E0
        public void get_roll(){} // RVA: 0x7FFD54C60640
        public void set_roll(){} // RVA: 0x7FFD54C60690
        public void get_constraintActive(){} // RVA: 0x7FFD54C606F0
        public void set_constraintActive(){} // RVA: 0x7FFD54C60740
        public void get_locked(){} // RVA: 0x7FFD54C607A0
        public void set_locked(){} // RVA: 0x7FFD54C607F0
        public void get_rotationAtRest(){} // RVA: 0x7FFD54C60850
        public void set_rotationAtRest(){} // RVA: 0x7FFD54C608C0
        public void get_rotationOffset(){} // RVA: 0x7FFD54C60920
        public void set_rotationOffset(){} // RVA: 0x7FFD54C60990
        public void get_worldUpObject(){} // RVA: 0x7FFD54C609F0
        public void set_worldUpObject(){} // RVA: 0x7FFD54C60A40
        public void get_useUpObject(){} // RVA: 0x7FFD54C60AA0
        public void set_useUpObject(){} // RVA: 0x7FFD54C60AF0
        public void get_sourceCount(){} // RVA: 0x7FFD54C60B50
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C60B50
        public void GetSources(){} // RVA: 0x7FFD54C60BA0
        public void SetSources(){} // RVA: 0x7FFD54C60C00
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C60CB0
        public void AddSource(){} // RVA: 0x7FFD54C60D10
        public void RemoveSource(){} // RVA: 0x7FFD54C60D70
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C60DE0
        public void GetSource(){} // RVA: 0x7FFD54C60E40
        public void GetSourceInternal(){} // RVA: 0x7FFD54C60EE0
        public void SetSource(){} // RVA: 0x7FFD54C60F60
        public void SetSourceInternal(){} // RVA: 0x7FFD54C60FE0
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C61050
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFD54C61210
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFD54C61270
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFD54C612D0
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFD54C61330
        public void AddSource_Injected(){} // RVA: 0x7FFD54C61390
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C613F0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C61460
    }

    public class MuscleHandle : ValueType
    {
        public reLayerCollision_Internal muscleHandleCount; // 0x10
        public int <dof>k__BackingField; // 0x14

        // ── Methods ──
        public void get_muscleHandleCount(){} // RVA: 0x7FFD54C614D0
        public void GetMuscleHandles(){} // RVA: 0x7FFD54C61520
        public void GetMuscleHandleCount(){} // RVA: 0x7FFD54C614D0
    }

    public class NotKeyableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_weight(){} // RVA: 0x7FFD54C61570
        public void set_weight(){} // RVA: 0x7FFD54C615C0
        public void get_constraintActive(){} // RVA: 0x7FFD54C61620
        public void set_constraintActive(){} // RVA: 0x7FFD54C61670
        public void get_locked(){} // RVA: 0x7FFD54C616D0
        public void set_locked(){} // RVA: 0x7FFD54C61720
        public void get_sourceCount(){} // RVA: 0x7FFD54C61780
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C61780
        public void get_translationAtRest(){} // RVA: 0x7FFD54C617D0
        public void set_translationAtRest(){} // RVA: 0x7FFD54C61840
        public void get_rotationAtRest(){} // RVA: 0x7FFD54C618A0
        public void set_rotationAtRest(){} // RVA: 0x7FFD54C61910
        public void get_translationOffsets(){} // RVA: 0x7FFD54C61970
        public void set_translationOffsets(){} // RVA: 0x7FFD54C619C0
        public void get_rotationOffsets(){} // RVA: 0x7FFD54C61A20
        public void set_rotationOffsets(){} // RVA: 0x7FFD54C61A70
        public void get_translationAxis(){} // RVA: 0x7FFD54C61AD0
        public void set_translationAxis(){} // RVA: 0x7FFD54C61B20
        public void get_rotationAxis(){} // RVA: 0x7FFD54C61B80
        public void set_rotationAxis(){} // RVA: 0x7FFD54C61BD0
        public void GetTranslationOffset(){} // RVA: 0x7FFD54C61C30
        public void SetTranslationOffset(){} // RVA: 0x7FFD54C61CE0
        public void GetTranslationOffsetInternal(){} // RVA: 0x7FFD54C61D70
        public void SetTranslationOffsetInternal(){} // RVA: 0x7FFD54C61DF0
        public void GetRotationOffset(){} // RVA: 0x7FFD54C61E60
        public void SetRotationOffset(){} // RVA: 0x7FFD54C61F10
        public void GetRotationOffsetInternal(){} // RVA: 0x7FFD54C61FA0
        public void SetRotationOffsetInternal(){} // RVA: 0x7FFD54C62020
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C62090
        public void GetSources(){} // RVA: 0x7FFD54C62250
        public void SetSources(){} // RVA: 0x7FFD54C622B0
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C62360
        public void AddSource(){} // RVA: 0x7FFD54C623C0
        public void RemoveSource(){} // RVA: 0x7FFD54C62420
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C62490
        public void GetSource(){} // RVA: 0x7FFD54C624F0
        public void GetSourceInternal(){} // RVA: 0x7FFD54C62590
        public void SetSource(){} // RVA: 0x7FFD54C62610
        public void SetSourceInternal(){} // RVA: 0x7FFD54C62690
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFD54C62700
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFD54C62760
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFD54C627C0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFD54C62820
        public void GetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFD54C62880
        public void SetTranslationOffsetInternal_Injected(){} // RVA: 0x7FFD54C628F0
        public void GetRotationOffsetInternal_Injected(){} // RVA: 0x7FFD54C62960
        public void SetRotationOffsetInternal_Injected(){} // RVA: 0x7FFD54C629D0
        public void AddSource_Injected(){} // RVA: 0x7FFD54C62A40
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C62AA0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C62B10
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
        public void get_weight(){} // RVA: 0x7FFD54C5DBF0
        public void set_weight(){} // RVA: 0x7FFD54C5DC40
        public void get_translationAtRest(){} // RVA: 0x7FFD54C5DCA0
        public void set_translationAtRest(){} // RVA: 0x7FFD54C5DD10
        public void get_translationOffset(){} // RVA: 0x7FFD54C5DD70
        public void set_translationOffset(){} // RVA: 0x7FFD54C5DDE0
        public void get_translationAxis(){} // RVA: 0x7FFD54C5DE40
        public void set_translationAxis(){} // RVA: 0x7FFD54C5DE90
        public void get_constraintActive(){} // RVA: 0x7FFD54C5DEF0
        public void set_constraintActive(){} // RVA: 0x7FFD54C5DF40
        public void get_locked(){} // RVA: 0x7FFD54C5DFA0
        public void set_locked(){} // RVA: 0x7FFD54C5DFF0
        public void get_sourceCount(){} // RVA: 0x7FFD54C5E050
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C5E050
        public void GetSources(){} // RVA: 0x7FFD54C5E0A0
        public void SetSources(){} // RVA: 0x7FFD54C5E100
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C5E1B0
        public void AddSource(){} // RVA: 0x7FFD54C5E210
        public void RemoveSource(){} // RVA: 0x7FFD54C5E270
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C5E2E0
        public void GetSource(){} // RVA: 0x7FFD54C5E340
        public void GetSourceInternal(){} // RVA: 0x7FFD54C5E3E0
        public void SetSource(){} // RVA: 0x7FFD54C5E460
        public void SetSourceInternal(){} // RVA: 0x7FFD54C5E4E0
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C5E550
        public void get_translationAtRest_Injected(){} // RVA: 0x7FFD54C5E710
        public void set_translationAtRest_Injected(){} // RVA: 0x7FFD54C5E770
        public void get_translationOffset_Injected(){} // RVA: 0x7FFD54C5E7D0
        public void set_translationOffset_Injected(){} // RVA: 0x7FFD54C5E830
        public void AddSource_Injected(){} // RVA: 0x7FFD54C5E890
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C5E8F0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C5E960
    }

    public class ProcessAnimationJobStruct`1 : ValueType
    {
        public UIntPtr jobReflectionData;

        // ── Methods ──
        public void GetJobReflectionData(){} // RVA: 0x7FFD4E078A90
        public void Execute(){} // RVA: 0x7FFD4E099720
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
        public void get_weight(){} // RVA: 0x7FFD54C5E9D0
        public void set_weight(){} // RVA: 0x7FFD54C5EA20
        public void get_rotationAtRest(){} // RVA: 0x7FFD54C5EA80
        public void set_rotationAtRest(){} // RVA: 0x7FFD54C5EAF0
        public void get_rotationOffset(){} // RVA: 0x7FFD54C5EB50
        public void set_rotationOffset(){} // RVA: 0x7FFD54C5EBC0
        public void get_rotationAxis(){} // RVA: 0x7FFD54C5EC20
        public void set_rotationAxis(){} // RVA: 0x7FFD54C5EC70
        public void get_constraintActive(){} // RVA: 0x7FFD54C5ECD0
        public void set_constraintActive(){} // RVA: 0x7FFD54C5ED20
        public void get_locked(){} // RVA: 0x7FFD54C5ED80
        public void set_locked(){} // RVA: 0x7FFD54C5EDD0
        public void get_sourceCount(){} // RVA: 0x7FFD54C5EE30
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C5EE30
        public void GetSources(){} // RVA: 0x7FFD54C5EE80
        public void SetSources(){} // RVA: 0x7FFD54C5EEE0
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C5EF90
        public void AddSource(){} // RVA: 0x7FFD54C5EFF0
        public void RemoveSource(){} // RVA: 0x7FFD54C5F050
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C5F0C0
        public void GetSource(){} // RVA: 0x7FFD54C5F120
        public void GetSourceInternal(){} // RVA: 0x7FFD54C5F1C0
        public void SetSource(){} // RVA: 0x7FFD54C5F240
        public void SetSourceInternal(){} // RVA: 0x7FFD54C5F2C0
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C5F330
        public void get_rotationAtRest_Injected(){} // RVA: 0x7FFD54C5F4F0
        public void set_rotationAtRest_Injected(){} // RVA: 0x7FFD54C5F550
        public void get_rotationOffset_Injected(){} // RVA: 0x7FFD54C5F5B0
        public void set_rotationOffset_Injected(){} // RVA: 0x7FFD54C5F610
        public void AddSource_Injected(){} // RVA: 0x7FFD54C5F670
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C5F6D0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C5F740
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
        public void get_weight(){} // RVA: 0x7FFD54C5F7B0
        public void set_weight(){} // RVA: 0x7FFD54C5F800
        public void get_scaleAtRest(){} // RVA: 0x7FFD54C5F860
        public void set_scaleAtRest(){} // RVA: 0x7FFD54C5F8D0
        public void get_scaleOffset(){} // RVA: 0x7FFD54C5F930
        public void set_scaleOffset(){} // RVA: 0x7FFD54C5F9A0
        public void get_scalingAxis(){} // RVA: 0x7FFD54C5FA00
        public void set_scalingAxis(){} // RVA: 0x7FFD54C5FA50
        public void get_constraintActive(){} // RVA: 0x7FFD54C5FAB0
        public void set_constraintActive(){} // RVA: 0x7FFD54C5FB00
        public void get_locked(){} // RVA: 0x7FFD54C5FB60
        public void set_locked(){} // RVA: 0x7FFD54C5FBB0
        public void get_sourceCount(){} // RVA: 0x7FFD54C5FC10
        public void GetSourceCountInternal(){} // RVA: 0x7FFD54C5FC10
        public void GetSources(){} // RVA: 0x7FFD54C5FC60
        public void SetSources(){} // RVA: 0x7FFD54C5FCC0
        public void SetSourcesInternal(){} // RVA: 0x7FFD54C5FD70
        public void AddSource(){} // RVA: 0x7FFD54C5FDD0
        public void RemoveSource(){} // RVA: 0x7FFD54C5FE30
        public void RemoveSourceInternal(){} // RVA: 0x7FFD54C5FEA0
        public void GetSource(){} // RVA: 0x7FFD54C5FF00
        public void GetSourceInternal(){} // RVA: 0x7FFD54C5FFA0
        public void SetSource(){} // RVA: 0x7FFD54C60020
        public void SetSourceInternal(){} // RVA: 0x7FFD54C600A0
        public void ValidateSourceIndex(){} // RVA: 0x7FFD54C60110
        public void get_scaleAtRest_Injected(){} // RVA: 0x7FFD54C602D0
        public void set_scaleAtRest_Injected(){} // RVA: 0x7FFD54C60330
        public void get_scaleOffset_Injected(){} // RVA: 0x7FFD54C60390
        public void set_scaleOffset_Injected(){} // RVA: 0x7FFD54C603F0
        public void AddSource_Injected(){} // RVA: 0x7FFD54C60450
        public void GetSourceInternal_Injected(){} // RVA: 0x7FFD54C604B0
        public void SetSourceInternal_Injected(){} // RVA: 0x7FFD54C60520
    }

    public class TransformStreamHandle : ValueType
    {
        public uint createdByNative; // 0x10
        public int hasHandleIndex; // 0x14
        public int hasSkeletonIndex; // 0x18

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFD54C58C00
        public void get_createdByNative(){} // RVA: 0x7FFD54C58C40
        public void IsSameVersionAsStream(){} // RVA: 0x7FFD54C58C50
        public void get_hasHandleIndex(){} // RVA: 0x7FFD54C58C60
        public void get_hasSkeletonIndex(){} // RVA: 0x7FFD54C58C70
        public void get_animatorBindingsVersion(){} // RVA: 0x7FFD543B3F90
        public void Resolve(){} // RVA: 0x7FFD54C58C80
        public void IsResolved(){} // RVA: 0x7FFD54C58CA0
        public void IsResolvedInternal(){} // RVA: 0x7FFD54C58CA0
        public void CheckIsValidAndResolve(){} // RVA: 0x7FFD54C58CF0
        public void SetLocalTRS(){} // RVA: 0x7FFD54C58E30
        public void ResolveInternal(){} // RVA: 0x7FFD54C58F20
        public void SetLocalTRSInternal(){} // RVA: 0x7FFD54C58F80
        public void ResolveInternal_Injected(){} // RVA: 0x7FFD54C58F20
        public void SetLocalTRSInternal_Injected(){} // RVA: 0x7FFD54C59030
    }

}