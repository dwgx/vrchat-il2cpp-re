// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 47
// Methods: 968

namespace ThirdParty.Unity.UnityEngine
{
    public class AddComponentMenu : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCAC310 | overloaded x2
    }

    public class AnchoredJoint2D : Joint2D
    {
        public object anchor;
        public object connectedAnchor;
        public object autoConfigureConnectedAnchor;

        // ── Methods ──
        public void get_anchor(){} // RVA: 0x7FFD54DA3300
        public void set_anchor(){} // RVA: 0x7FFD54DA3360
        public void get_connectedAnchor(){} // RVA: 0x7FFD54DA33C0
        public void set_connectedAnchor(){} // RVA: 0x7FFD54DA3420
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFD54DA3480
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFD54DA34D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_anchor_Injected(){} // RVA: 0x7FFD54DA3530
        public void set_anchor_Injected(){} // RVA: 0x7FFD54DA3590
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFD54DA35F0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFD54DA3650
    }

    public class AndroidJNIHelper : Object
    {
        // ── Methods ──
        public void GetConstructorID(){} // RVA: 0x7FFD54C3CDE0 | overloaded x2
        public void GetMethodID(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GetFieldID(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CreateJavaRunnable(){} // RVA: 0x7FFD54C38CF0
        public void CreateJavaProxy(){} // RVA: 0x7FFD54C3E590
        public void CreateJNIArgArray(){} // RVA: 0x7FFD54C3E7E0
        public void DeleteJNIArgArray(){} // RVA: 0x7FFD54C3E910
        public void ConvertFromJNIArray(){} // RVA: 0x7FFD4E2ADC40
        public void Box(){} // RVA: 0x7FFD54C3EC20 | overloaded x3
    }

    public class AndroidJavaObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFD54C373A0 | overloaded x2
        public void Call(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void GetStatic(){} // RVA: 0x7FFD4E2ADC40
        public void GetRawObject(){} // RVA: 0x7FFD54C36CE0
        public void GetRawClass(){} // RVA: 0x7FFD53C24860
        public void CloneReference(){} // RVA: 0x7FFD54C36D00
        public void CallStatic(){} // RVA: 0x7FFD4E2ADC40
        public void DebugPrint(){} // RVA: 0x7FFD54C36F20
        public void _AndroidJavaObject(){} // RVA: 0x7FFD54C37140 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD53791850
        public void _Call(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void _Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void _CallStatic(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void _GetStatic(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AndroidJavaObjectDeleteLocalRef(){} // RVA: 0x7FFD54C37630
        public void AndroidJavaClassDeleteLocalRef(){} // RVA: 0x7FFD54C376E0
        public void FromJavaArrayDeleteLocalRef(){} // RVA: 0x7FFD4E2ADC40
        public void _GetRawObject(){} // RVA: 0x7FFD54C36CE0
        public void _GetRawClass(){} // RVA: 0x7FFD53C24860
    }

    public class AndroidJavaProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C354B0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD54C35510
        public void Invoke(){} // RVA: 0x7FFD54C36180 | overloaded x3
        public void equals(){} // RVA: 0x7FFD54C365A0
        public void hashCode(){} // RVA: 0x7FFD54C36620
        public void toString(){} // RVA: 0x7FFD54C36710
        public void GetProxyObject(){} // RVA: 0x7FFD54C36770
        public void GetRawProxy(){} // RVA: 0x7FFD54C36790
        public void .cctor(){} // RVA: 0x7FFD54C368A0
    }

    public class Animation : Behaviour
    {
        public object clip;
        public object playAutomatically;
        public object wrapMode;
        public object isPlaying;
        public object Item;
        public object animatePhysics;
        public object animateOnlyIfVisible;
        public object cullingType;
        public object localBounds;

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFD54C45EC0
        public void set_clip(){} // RVA: 0x7FFD54C45F10
        public void get_playAutomatically(){} // RVA: 0x7FFD54C45F70
        public void set_playAutomatically(){} // RVA: 0x7FFD54C45FC0
        public void get_wrapMode(){} // RVA: 0x7FFD54C46020
        public void set_wrapMode(){} // RVA: 0x7FFD54C46070
        public void Stop(){} // RVA: 0x7FFD54C46120 | overloaded x2
        public void StopNamed(){} // RVA: 0x7FFD54C46120
        public void Rewind(){} // RVA: 0x7FFD54C461D0 | overloaded x2
        public void RewindNamed(){} // RVA: 0x7FFD54C461D0
        public void Sample(){} // RVA: 0x7FFD54C46230
        public void get_isPlaying(){} // RVA: 0x7FFD54C46280
        public void IsPlaying(){} // RVA: 0x7FFD54C462D0
        public void get_Item(){} // RVA: 0x7FFD54C46330
        public void Play(){} // RVA: 0x7FFD54C46E60 | overloaded x6
        public void PlayDefaultAnimation(){} // RVA: 0x7FFD54C463F0
        public void CrossFade(){} // RVA: 0x7FFD54C46620 | overloaded x3
        public void Blend(){} // RVA: 0x7FFD54C46790 | overloaded x3
        public void CrossFadeQueued(){} // RVA: 0x7FFD54C469A0 | overloaded x4
        public void PlayQueued(){} // RVA: 0x7FFD54C46B20 | overloaded x3
        public void AddClip(){} // RVA: 0x7FFD54C46CC0 | overloaded x3
        public void RemoveClip(){} // RVA: 0x7FFD54C46DB0 | overloaded x2
        public void RemoveClipNamed(){} // RVA: 0x7FFD54C46DB0
        public void GetClipCount(){} // RVA: 0x7FFD54C46E10
        public void SyncLayer(){} // RVA: 0x7FFD54C46E70
        public void GetEnumerator(){} // RVA: 0x7FFD54C46ED0
        public void GetState(){} // RVA: 0x7FFD54C46330
        public void GetStateAtIndex(){} // RVA: 0x7FFD54C46F70
        public void GetStateCount(){} // RVA: 0x7FFD54C46FD0
        public void GetClip(){} // RVA: 0x7FFD54C47020
        public void get_animatePhysics(){} // RVA: 0x7FFD54C470E0
        public void set_animatePhysics(){} // RVA: 0x7FFD54C47130
        public void get_animateOnlyIfVisible(){} // RVA: 0x7FFD54C47190
        public void set_animateOnlyIfVisible(){} // RVA: 0x7FFD54C471E0
        public void get_cullingType(){} // RVA: 0x7FFD54C47240
        public void set_cullingType(){} // RVA: 0x7FFD54C47290
        public void get_localBounds(){} // RVA: 0x7FFD54C472F0
        public void set_localBounds(){} // RVA: 0x7FFD54C47360
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_localBounds_Injected(){} // RVA: 0x7FFD54C473C0
        public void set_localBounds_Injected(){} // RVA: 0x7FFD54C47420
    }

    public class AnimationClip : Motion
    {
        public object length;
        public object frameRate;
        public object wrapMode;
        public object localBounds;
        public object legacy;
        public object humanMotion;
        public object empty;
        public object hasGenericRootTransform;
        public object hasMotionFloatCurves;
        public object hasMotionCurves;
        public object hasRootCurves;
        public object hasRootMotion;
        public object events;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C47FD0
        public void Internal_CreateAnimationClip(){} // RVA: 0x7FFD54C48060
        public void SampleAnimation(){} // RVA: 0x7FFD54C48170 | overloaded x2
        public void get_length(){} // RVA: 0x7FFD54C481F0
        public void get_frameRate(){} // RVA: 0x7FFD54C48240
        public void set_frameRate(){} // RVA: 0x7FFD54C48290
        public void SetCurve(){} // RVA: 0x7FFD54C482F0
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFD54C48380
        public void ClearCurves(){} // RVA: 0x7FFD54C483D0
        public void get_wrapMode(){} // RVA: 0x7FFD54C48420
        public void set_wrapMode(){} // RVA: 0x7FFD54C48470
        public void get_localBounds(){} // RVA: 0x7FFD54C484D0
        public void set_localBounds(){} // RVA: 0x7FFD54C48540
        public void get_legacy(){} // RVA: 0x7FFD54C485A0
        public void set_legacy(){} // RVA: 0x7FFD54C485F0
        public void get_humanMotion(){} // RVA: 0x7FFD54C48650
        public void get_empty(){} // RVA: 0x7FFD54C486A0
        public void get_hasGenericRootTransform(){} // RVA: 0x7FFD54C486F0
        public void get_hasMotionFloatCurves(){} // RVA: 0x7FFD54C48740
        public void get_hasMotionCurves(){} // RVA: 0x7FFD54C48790
        public void get_hasRootCurves(){} // RVA: 0x7FFD54C487E0
        public void get_hasRootMotion(){} // RVA: 0x7FFD54C48830
        public void get_events(){} // RVA: 0x7FFD54C48880
        public void set_events(){} // RVA: 0x7FFD54C48930
        public void SetEventsInternal(){} // RVA: 0x7FFD54C48930
        public void GetEventsInternal(){} // RVA: 0x7FFD54C48990
        public void get_localBounds_Injected(){} // RVA: 0x7FFD54C489E0
        public void set_localBounds_Injected(){} // RVA: 0x7FFD54C48A40
    }

    public class AnimationCurve : Object
    {
        public object keys;
        public object Item;
        public object length;
        public object preWrapMode;
        public object postWrapMode;

        // ── Methods ──
        public void Internal_Destroy(){} // RVA: 0x7FFD54C71CF0
        public void Internal_Create(){} // RVA: 0x7FFD54C71D40
        public void Internal_Equals(){} // RVA: 0x7FFD54C71D90
        public void Internal_CopyFrom(){} // RVA: 0x7FFD54C71DF0
        public void Finalize(){} // RVA: 0x7FFD54C71E50
        public void Evaluate(){} // RVA: 0x7FFD54C71ED0
        public void get_keys(){} // RVA: 0x7FFD54C71F30
        public void set_keys(){} // RVA: 0x7FFD54C71F80
        public void AddKey(){} // RVA: 0x7FFD54C72050 | overloaded x2
        public void AddKey_Internal(){} // RVA: 0x7FFD54C720C0
        public void MoveKey(){} // RVA: 0x7FFD54C72120
        public void ClearKeys(){} // RVA: 0x7FFD54C72190
        public void RemoveKey(){} // RVA: 0x7FFD54C721E0
        public void get_Item(){} // RVA: 0x7FFD54C72240
        public void get_length(){} // RVA: 0x7FFD54C722F0
        public void SetKeys(){} // RVA: 0x7FFD54C71F80
        public void GetKey(){} // RVA: 0x7FFD54C72340
        public void GetKeys(){} // RVA: 0x7FFD54C71F30
        public void GetHashCode(){} // RVA: 0x7FFD54C723C0
        public void SmoothTangents(){} // RVA: 0x7FFD54C72410
        public void Constant(){} // RVA: 0x7FFD54C72480
        public void Linear(){} // RVA: 0x7FFD54C724A0
        public void EaseInOut(){} // RVA: 0x7FFD54C72690
        public void get_preWrapMode(){} // RVA: 0x7FFD54C72850
        public void set_preWrapMode(){} // RVA: 0x7FFD54C728A0
        public void get_postWrapMode(){} // RVA: 0x7FFD54C72900
        public void set_postWrapMode(){} // RVA: 0x7FFD54C72950
        public void .ctor(){} // RVA: 0x7FFD54C72A10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54C72B80 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD54C72CF0
        public void AddKey_Internal_Injected(){} // RVA: 0x7FFD54C72D60
        public void MoveKey_Injected(){} // RVA: 0x7FFD54C72DC0
        public void GetKey_Injected(){} // RVA: 0x7FFD54C72E30
    }

    public class AnimationEvent : Object
    {
        public object stringParameter;
        public object functionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C47E30
        public void get_stringParameter(){} // RVA: 0x7FFD545DAEE0
        public void get_functionName(){} // RVA: 0x7FFD50CC1130
    }

    public class AnimationState : TrackedReference
    {
        public object enabled;
        public object weight;
        public object wrapMode;
        public object time;
        public object normalizedTime;
        public object speed;
        public object normalizedSpeed;
        public object length;
        public object layer;
        public object clip;
        public object name;
        public object blendMode;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFD54C47570
        public void set_enabled(){} // RVA: 0x7FFD54C475C0
        public void get_weight(){} // RVA: 0x7FFD54C47620
        public void set_weight(){} // RVA: 0x7FFD54C47670
        public void get_wrapMode(){} // RVA: 0x7FFD54C476D0
        public void set_wrapMode(){} // RVA: 0x7FFD54C47720
        public void get_time(){} // RVA: 0x7FFD54C47780
        public void set_time(){} // RVA: 0x7FFD54C477D0
        public void get_normalizedTime(){} // RVA: 0x7FFD54C47830
        public void set_normalizedTime(){} // RVA: 0x7FFD54C47880
        public void get_speed(){} // RVA: 0x7FFD54C478E0
        public void set_speed(){} // RVA: 0x7FFD54C47930
        public void get_normalizedSpeed(){} // RVA: 0x7FFD54C47990
        public void set_normalizedSpeed(){} // RVA: 0x7FFD54C479E0
        public void get_length(){} // RVA: 0x7FFD54C47A40
        public void get_layer(){} // RVA: 0x7FFD54C47A90
        public void set_layer(){} // RVA: 0x7FFD54C47AE0
        public void get_clip(){} // RVA: 0x7FFD54C47B40
        public void get_name(){} // RVA: 0x7FFD54C47B90
        public void set_name(){} // RVA: 0x7FFD54C47BE0
        public void get_blendMode(){} // RVA: 0x7FFD54C47C40
        public void set_blendMode(){} // RVA: 0x7FFD54C47C90
        public void AddMixingTransform(){} // RVA: 0x7FFD54C47D60 | overloaded x2
        public void RemoveMixingTransform(){} // RVA: 0x7FFD54C47DD0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Animator : Behaviour
    {
        public object isOptimizable;
        public object isHuman;
        public object hasRootMotion;
        public object isRootPositionOrRotationControlledByCurves;
        public object humanScale;
        public object isInitialized;
        public object deltaPosition;
        public object deltaRotation;
        public object velocity;
        public object angularVelocity;
        public object rootPosition;
        public object rootRotation;
        public object applyRootMotion;
        public object noDiscreteIntBindings;
        public object linearVelocityBlending;
        public object animatePhysics;
        public object updateMode;
        public object hasTransformHierarchy;
        public object allowConstantClipSamplingOptimization;
        public object gravityWeight;
        public object bodyPosition;
        public object bodyPositionInternal;
        public object bodyRotation;
        public object bodyRotationInternal;
        public object stabilizeFeet;
        public object layerCount;
        public object parameters;
        public object parameterCount;
        public object feetPivotActive;
        public object pivotWeight;
        public object pivotPosition;
        public object isMatchingTarget;
        public object speed;
        public object targetPosition;
        public object targetRotation;
        public object avatarRoot;
        public object cullingMode;
        public object playbackTime;
        public object recorderStartTime;
        public object recorderStopTime;
        public object recorderMode;
        public object runtimeAnimatorController;
        public object hasBoundPlayables;
        public object avatar;
        public object playableGraph;
        public object layersAffectMassCenter;
        public object leftFeetBottomHeight;
        public object rightFeetBottomHeight;
        public object supportsOnAnimatorMove;
        public object logWarnings;
        public object fireEvents;
        public object keepAnimatorControllerStateOnDisable;
        public object keepAnimatorStateOnDisable;
        public object writeDefaultValuesOnDisable;

        // ── Methods ──
        public void get_isOptimizable(){} // RVA: 0x7FFD54C48DB0
        public void get_isHuman(){} // RVA: 0x7FFD54C48E00
        public void get_hasRootMotion(){} // RVA: 0x7FFD54C48E50
        public void get_isRootPositionOrRotationControlledByCurves(){} // RVA: 0x7FFD54C48EA0
        public void get_humanScale(){} // RVA: 0x7FFD54C48EF0
        public void get_isInitialized(){} // RVA: 0x7FFD54C48F40
        public void GetFloat(){} // RVA: 0x7FFD54C48FF0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFD54C491B0 | overloaded x4
        public void GetBool(){} // RVA: 0x7FFD54C49290 | overloaded x2
        public void SetBool(){} // RVA: 0x7FFD54C49360 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFD54C49430 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFD54C49500 | overloaded x2
        public void SetTrigger(){} // RVA: 0x7FFD54C495D0 | overloaded x2
        public void ResetTrigger(){} // RVA: 0x7FFD54C49690 | overloaded x2
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFD54C49750 | overloaded x2
        public void get_deltaPosition(){} // RVA: 0x7FFD54C497B0
        public void get_deltaRotation(){} // RVA: 0x7FFD54C49820
        public void get_velocity(){} // RVA: 0x7FFD54C49890
        public void get_angularVelocity(){} // RVA: 0x7FFD54C49900
        public void get_rootPosition(){} // RVA: 0x7FFD54C49970
        public void set_rootPosition(){} // RVA: 0x7FFD54C499E0
        public void get_rootRotation(){} // RVA: 0x7FFD54C49A40
        public void set_rootRotation(){} // RVA: 0x7FFD54C49AB0
        public void get_applyRootMotion(){} // RVA: 0x7FFD54C49B10
        public void set_applyRootMotion(){} // RVA: 0x7FFD54C49B60
        public void get_noDiscreteIntBindings(){} // RVA: 0x7FFD54C49BC0
        public void set_noDiscreteIntBindings(){} // RVA: 0x7FFD54C49C10
        public void get_linearVelocityBlending(){} // RVA: 0x7FFD54C49C70
        public void set_linearVelocityBlending(){} // RVA: 0x7FFD54C49CC0
        public void get_animatePhysics(){} // RVA: 0x7FFD54C49D20
        public void set_animatePhysics(){} // RVA: 0x7FFD54C49D80
        public void get_updateMode(){} // RVA: 0x7FFD54C49DF0
        public void set_updateMode(){} // RVA: 0x7FFD54C49E40
        public void get_hasTransformHierarchy(){} // RVA: 0x7FFD54C49EA0
        public void get_allowConstantClipSamplingOptimization(){} // RVA: 0x7FFD54C49EF0
        public void set_allowConstantClipSamplingOptimization(){} // RVA: 0x7FFD54C49F40
        public void get_gravityWeight(){} // RVA: 0x7FFD54C49FA0
        public void get_bodyPosition(){} // RVA: 0x7FFD54C49FF0
        public void set_bodyPosition(){} // RVA: 0x7FFD54C4A090
        public void get_bodyPositionInternal(){} // RVA: 0x7FFD54C4A110
        public void set_bodyPositionInternal(){} // RVA: 0x7FFD54C4A180
        public void get_bodyRotation(){} // RVA: 0x7FFD54C4A1E0
        public void set_bodyRotation(){} // RVA: 0x7FFD54C4A270
        public void get_bodyRotationInternal(){} // RVA: 0x7FFD54C4A2E0
        public void set_bodyRotationInternal(){} // RVA: 0x7FFD54C4A350
        public void GetIKPosition(){} // RVA: 0x7FFD54C4A3B0
        public void GetGoalPosition(){} // RVA: 0x7FFD54C4A450
        public void SetIKPosition(){} // RVA: 0x7FFD54C4A4D0
        public void SetGoalPosition(){} // RVA: 0x7FFD54C4A560
        public void GetIKRotation(){} // RVA: 0x7FFD54C4A5D0
        public void GetGoalRotation(){} // RVA: 0x7FFD54C4A670
        public void SetIKRotation(){} // RVA: 0x7FFD54C4A6F0
        public void SetGoalRotation(){} // RVA: 0x7FFD54C4A770
        public void GetIKPositionWeight(){} // RVA: 0x7FFD54C4A7E0
        public void GetGoalWeightPosition(){} // RVA: 0x7FFD54C4A850
        public void SetIKPositionWeight(){} // RVA: 0x7FFD54C4A8B0
        public void SetGoalWeightPosition(){} // RVA: 0x7FFD54C4A930
        public void GetIKRotationWeight(){} // RVA: 0x7FFD54C4A9A0
        public void GetGoalWeightRotation(){} // RVA: 0x7FFD54C4AA10
        public void SetIKRotationWeight(){} // RVA: 0x7FFD54C4AA70
        public void SetGoalWeightRotation(){} // RVA: 0x7FFD54C4AAF0
        public void GetIKHintPosition(){} // RVA: 0x7FFD54C4AB60
        public void GetHintPosition(){} // RVA: 0x7FFD54C4AC00
        public void SetIKHintPosition(){} // RVA: 0x7FFD54C4AC80
        public void SetHintPosition(){} // RVA: 0x7FFD54C4AD10
        public void GetIKHintPositionWeight(){} // RVA: 0x7FFD54C4AD80
        public void GetHintWeightPosition(){} // RVA: 0x7FFD54C4ADF0
        public void SetIKHintPositionWeight(){} // RVA: 0x7FFD54C4AE50
        public void SetHintWeightPosition(){} // RVA: 0x7FFD54C4AED0
        public void SetLookAtPosition(){} // RVA: 0x7FFD54C4AF40
        public void SetLookAtPositionInternal(){} // RVA: 0x7FFD54C4AFC0
        public void SetLookAtWeight(){} // RVA: 0x7FFD54C4B2A0 | overloaded x5
        public void SetLookAtWeightInternal(){} // RVA: 0x7FFD54C4B300
        public void SetBoneLocalRotation(){} // RVA: 0x7FFD54C4B390
        public void SetBoneLocalRotationInternal(){} // RVA: 0x7FFD54C4B450
        public void GetBehaviour(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ConvertStateMachineBehaviour(){} // RVA: 0x7FFD4E078F80
        public void GetBehaviours(){} // RVA: 0x7FFD54C4B580 | overloaded x2
        public void InternalGetBehaviours(){} // RVA: 0x7FFD54C4B520
        public void InternalGetBehavioursByKey(){} // RVA: 0x7FFD54C4B6C0
        public void get_stabilizeFeet(){} // RVA: 0x7FFD54C4B740
        public void set_stabilizeFeet(){} // RVA: 0x7FFD54C4B790
        public void get_layerCount(){} // RVA: 0x7FFD54C4B7F0
        public void GetLayerName(){} // RVA: 0x7FFD54C4B840
        public void GetLayerIndex(){} // RVA: 0x7FFD54C4B8A0
        public void GetLayerWeight(){} // RVA: 0x7FFD54C4B900
        public void SetLayerWeight(){} // RVA: 0x7FFD54C4B960
        public void GetAnimatorStateInfo(){} // RVA: 0x7FFD54C4B9D0
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7FFD54C4BA50
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7FFD54C4BB00
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7FFD54C4BC20 | overloaded x2
        public void GetAnimatorClipInfoCount(){} // RVA: 0x7FFD54C4BCC0
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7FFD54C4BD30
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7FFD54C4BD90
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7FFD54C4BEB0 | overloaded x2
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7FFD54C4BFB0 | overloaded x2
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7FFD54C4BF30
        public void IsInTransition(){} // RVA: 0x7FFD54C4C030
        public void get_parameters(){} // RVA: 0x7FFD54C4C090
        public void get_parameterCount(){} // RVA: 0x7FFD54C4C0E0
        public void GetParameterInternal(){} // RVA: 0x7FFD54C4C130
        public void GetParameter(){} // RVA: 0x7FFD54C4C190
        public void get_feetPivotActive(){} // RVA: 0x7FFD54C4C280
        public void set_feetPivotActive(){} // RVA: 0x7FFD54C4C2D0
        public void get_pivotWeight(){} // RVA: 0x7FFD54C4C330
        public void get_pivotPosition(){} // RVA: 0x7FFD54C4C380
        public void MatchTarget(){} // RVA: 0x7FFD54C4C650 | overloaded x4
        public void InterruptMatchTarget(){} // RVA: 0x7FFD54C4C780 | overloaded x2
        public void get_isMatchingTarget(){} // RVA: 0x7FFD54C4C7E0
        public void get_speed(){} // RVA: 0x7FFD54C4C830
        public void set_speed(){} // RVA: 0x7FFD54C4C880
        public void ForceStateNormalizedTime(){} // RVA: 0x7FFD54C4C8E0
        public void CrossFadeInFixedTime(){} // RVA: 0x7FFD54C4CE30 | overloaded x8
        public void WriteDefaultValues(){} // RVA: 0x7FFD54C4CEB0
        public void CrossFade(){} // RVA: 0x7FFD54C4D210 | overloaded x8
        public void PlayInFixedTime(){} // RVA: 0x7FFD54C4D420 | overloaded x6
        public void Play(){} // RVA: 0x7FFD54C4D5D0 | overloaded x6
        public void SetTarget(){} // RVA: 0x7FFD54C4D600
        public void get_targetPosition(){} // RVA: 0x7FFD54C4D670
        public void get_targetRotation(){} // RVA: 0x7FFD54C4D6E0
        public void IsControlled(){} // RVA: 0x7FFD506288B0
        public void IsBoneTransform(){} // RVA: 0x7FFD54C4D750
        public void get_avatarRoot(){} // RVA: 0x7FFD54C4D7B0
        public void GetBoneTransform(){} // RVA: 0x7FFD54C4D800
        public void GetBoneTransformInternal(){} // RVA: 0x7FFD54C4DC30
        public void get_cullingMode(){} // RVA: 0x7FFD54C4DC90
        public void set_cullingMode(){} // RVA: 0x7FFD54C4DCE0
        public void StartPlayback(){} // RVA: 0x7FFD54C4DD40
        public void StopPlayback(){} // RVA: 0x7FFD54C4DD90
        public void get_playbackTime(){} // RVA: 0x7FFD54C4DDE0
        public void set_playbackTime(){} // RVA: 0x7FFD54C4DE30
        public void StartRecording(){} // RVA: 0x7FFD54C4DE90
        public void StopRecording(){} // RVA: 0x7FFD54C4DEF0
        public void get_recorderStartTime(){} // RVA: 0x7FFD54C4DF40
        public void set_recorderStartTime(){} // RVA: 0x7FFD4E341310
        public void GetRecorderStartTime(){} // RVA: 0x7FFD54C4DF40
        public void get_recorderStopTime(){} // RVA: 0x7FFD54C4DF90
        public void set_recorderStopTime(){} // RVA: 0x7FFD4E341310
        public void GetRecorderStopTime(){} // RVA: 0x7FFD54C4DF90
        public void get_recorderMode(){} // RVA: 0x7FFD54C4DFE0
        public void get_runtimeAnimatorController(){} // RVA: 0x7FFD54C4E030
        public void set_runtimeAnimatorController(){} // RVA: 0x7FFD54C4E080
        public void get_hasBoundPlayables(){} // RVA: 0x7FFD54C4E0E0
        public void ClearInternalControllerPlayable(){} // RVA: 0x7FFD54C4E130
        public void HasState(){} // RVA: 0x7FFD54C4E180
        public void StringToHash(){} // RVA: 0x7FFD54C4E1F0
        public void get_avatar(){} // RVA: 0x7FFD54C4E240
        public void set_avatar(){} // RVA: 0x7FFD54C4E290
        public void GetStats(){} // RVA: 0x7FFD54C4E2F0
        public void get_playableGraph(){} // RVA: 0x7FFD54C4E340
        public void GetCurrentGraph(){} // RVA: 0x7FFD54C4E3C0
        public void CheckIfInIKPass(){} // RVA: 0x7FFD54C4E420
        public void IsInIKPass(){} // RVA: 0x7FFD54C4E520
        public void SetFloatString(){} // RVA: 0x7FFD54C49050
        public void SetFloatID(){} // RVA: 0x7FFD54C49140
        public void GetFloatString(){} // RVA: 0x7FFD54C48F90
        public void GetFloatID(){} // RVA: 0x7FFD54C48FF0
        public void SetBoolString(){} // RVA: 0x7FFD54C492F0
        public void SetBoolID(){} // RVA: 0x7FFD54C49360
        public void GetBoolString(){} // RVA: 0x7FFD54C49230
        public void GetBoolID(){} // RVA: 0x7FFD54C49290
        public void SetIntegerString(){} // RVA: 0x7FFD54C49490
        public void SetIntegerID(){} // RVA: 0x7FFD54C49500
        public void GetIntegerString(){} // RVA: 0x7FFD54C493D0
        public void GetIntegerID(){} // RVA: 0x7FFD54C49430
        public void SetTriggerString(){} // RVA: 0x7FFD54C49570
        public void SetTriggerID(){} // RVA: 0x7FFD54C495D0
        public void ResetTriggerString(){} // RVA: 0x7FFD54C49630
        public void ResetTriggerID(){} // RVA: 0x7FFD54C49690
        public void IsParameterControlledByCurveString(){} // RVA: 0x7FFD54C496F0
        public void IsParameterControlledByCurveID(){} // RVA: 0x7FFD54C49750
        public void SetFloatStringDamp(){} // RVA: 0x7FFD54C490C0
        public void SetFloatIDDamp(){} // RVA: 0x7FFD54C491B0
        public void get_layersAffectMassCenter(){} // RVA: 0x7FFD54C4E570
        public void set_layersAffectMassCenter(){} // RVA: 0x7FFD54C4E5C0
        public void get_leftFeetBottomHeight(){} // RVA: 0x7FFD54C4E620
        public void get_rightFeetBottomHeight(){} // RVA: 0x7FFD54C4E670
        public void get_supportsOnAnimatorMove(){} // RVA: 0x7FFD54C4E6C0
        public void OnUpdateModeChanged(){} // RVA: 0x7FFD54C4E710
        public void OnCullingModeChanged(){} // RVA: 0x7FFD54C4E760
        public void WriteDefaultPose(){} // RVA: 0x7FFD54C4E7B0
        public void Update(){} // RVA: 0x7FFD54C4E800
        public void Rebind(){} // RVA: 0x7FFD54C4E8C0 | overloaded x2
        public void ApplyBuiltinRootMotion(){} // RVA: 0x7FFD54C4E920
        public void EvaluateController(){} // RVA: 0x7FFD54C4E9D0 | overloaded x2
        public void GetCurrentStateName(){} // RVA: 0x7FFD54C4EA30
        public void GetNextStateName(){} // RVA: 0x7FFD54C4EA90
        public void GetAnimatorStateName(){} // RVA: 0x7FFD54C4EAF0
        public void ResolveHash(){} // RVA: 0x7FFD54C4EB60
        public void get_logWarnings(){} // RVA: 0x7FFD54C4EBC0
        public void set_logWarnings(){} // RVA: 0x7FFD54C4EC10
        public void get_fireEvents(){} // RVA: 0x7FFD54C4EC70
        public void set_fireEvents(){} // RVA: 0x7FFD54C4ECC0
        public void get_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7FFD54C4ED20
        public void set_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7FFD54C4ED70
        public void get_keepAnimatorStateOnDisable(){} // RVA: 0x7FFD54C4ED20
        public void set_keepAnimatorStateOnDisable(){} // RVA: 0x7FFD54C4ED70
        public void get_writeDefaultValuesOnDisable(){} // RVA: 0x7FFD54C4EDD0
        public void set_writeDefaultValuesOnDisable(){} // RVA: 0x7FFD54C4EE20
        public void GetVector(){} // RVA: 0x7FFD54C4EE80 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void GetQuaternion(){} // RVA: 0x7FFD54C4EEE0 | overloaded x2
        public void SetQuaternion(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_deltaPosition_Injected(){} // RVA: 0x7FFD54C4EF30
        public void get_deltaRotation_Injected(){} // RVA: 0x7FFD54C4EF90
        public void get_velocity_Injected(){} // RVA: 0x7FFD54C4EFF0
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFD54C4F050
        public void get_rootPosition_Injected(){} // RVA: 0x7FFD54C4F0B0
        public void set_rootPosition_Injected(){} // RVA: 0x7FFD54C4F110
        public void get_rootRotation_Injected(){} // RVA: 0x7FFD54C4F170
        public void set_rootRotation_Injected(){} // RVA: 0x7FFD54C4F1D0
        public void get_bodyPositionInternal_Injected(){} // RVA: 0x7FFD54C4F230
        public void set_bodyPositionInternal_Injected(){} // RVA: 0x7FFD54C4F290
        public void get_bodyRotationInternal_Injected(){} // RVA: 0x7FFD54C4F2F0
        public void set_bodyRotationInternal_Injected(){} // RVA: 0x7FFD54C4F350
        public void GetGoalPosition_Injected(){} // RVA: 0x7FFD54C4F3B0
        public void SetGoalPosition_Injected(){} // RVA: 0x7FFD54C4F420
        public void GetGoalRotation_Injected(){} // RVA: 0x7FFD54C4F490
        public void SetGoalRotation_Injected(){} // RVA: 0x7FFD54C4F500
        public void GetHintPosition_Injected(){} // RVA: 0x7FFD54C4F570
        public void SetHintPosition_Injected(){} // RVA: 0x7FFD54C4F5E0
        public void SetLookAtPositionInternal_Injected(){} // RVA: 0x7FFD54C4F650
        public void SetBoneLocalRotationInternal_Injected(){} // RVA: 0x7FFD54C4F6B0
        public void get_pivotPosition_Injected(){} // RVA: 0x7FFD54C4F720
        public void MatchTarget_Injected(){} // RVA: 0x7FFD54C4F780
        public void get_targetPosition_Injected(){} // RVA: 0x7FFD54C4F810
        public void get_targetRotation_Injected(){} // RVA: 0x7FFD54C4F870
    }

    public class AnimatorClipInfo : ValueType
    {
        public object clip;
        public object weight;

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFD54C48AA0
        public void get_weight(){} // RVA: 0x7FFD4E364D30
        public void InstanceIDToAnimationClipPPtr(){} // RVA: 0x7FFD54C48B00
    }

    public class AnimatorControllerParameter : Object
    {
        public object name;
        public object nameHash;
        public object type;
        public object defaultFloat;
        public object defaultInt;
        public object defaultBool;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD510E4750
        public void get_nameHash(){} // RVA: 0x7FFD54C4F8D0
        public void get_type(){} // RVA: 0x7FFD51ABDCA0
        public void set_type(){} // RVA: 0x7FFD4ED4CD10
        public void get_defaultFloat(){} // RVA: 0x7FFD54C34E00
        public void set_defaultFloat(){} // RVA: 0x7FFD4E40E580
        public void get_defaultInt(){} // RVA: 0x7FFD520B0D40
        public void set_defaultInt(){} // RVA: 0x7FFD4E9FB7A0
        public void get_defaultBool(){} // RVA: 0x7FFD54C4F920
        public void set_defaultBool(){} // RVA: 0x7FFD4F842FB0
        public void Equals(){} // RVA: 0x7FFD54C4F930
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
        public void .ctor(){} // RVA: 0x7FFD54C4FA40
    }

    public class AnimatorOverrideController : RuntimeAnimatorController
    {
        public object runtimeAnimatorController;
        public object Item;
        public object Item;
        public object overridesCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C4FBB0 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFD54C4FCA0
        public void get_runtimeAnimatorController(){} // RVA: 0x7FFD54C4FD00
        public void set_runtimeAnimatorController(){} // RVA: 0x7FFD54C4FD50
        public void get_Item(){} // RVA: 0x7FFD54C4FF00 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD54C4FF70 | overloaded x2
        public void Internal_GetClipByName(){} // RVA: 0x7FFD54C4FE90
        public void Internal_SetClipByName(){} // RVA: 0x7FFD54C4FE20
        public void GetClip(){} // RVA: 0x7FFD54C4FF90
        public void SetClip(){} // RVA: 0x7FFD54C50000
        public void SendNotification(){} // RVA: 0x7FFD54C50080
        public void GetOriginalClip(){} // RVA: 0x7FFD54C500D0
        public void GetOverrideClip(){} // RVA: 0x7FFD54C50130
        public void get_overridesCount(){} // RVA: 0x7FFD54C50190
        public void GetOverrides(){} // RVA: 0x7FFD54C501E0
        public void ApplyOverrides(){} // RVA: 0x7FFD54C50450
        public void OnInvalidateOverrideController(){} // RVA: 0x7FFD54C50790
    }

    public class AnimatorStateInfo : ValueType
    {
        public object fullPathHash;
        public object shortNameHash;
        public object normalizedTime;
        public object length;
        public object speed;
        public object speedMultiplier;
        public object tagHash;
        public object loop;

        // ── Methods ──
        public void IsName(){} // RVA: 0x7FFD54C48B50
        public void get_fullPathHash(){} // RVA: 0x7FFD5195D9A0
        public void get_shortNameHash(){} // RVA: 0x7FFD543B3F90
        public void get_normalizedTime(){} // RVA: 0x7FFD4E364D00
        public void get_length(){} // RVA: 0x7FFD54C34DF0
        public void get_speed(){} // RVA: 0x7FFD50CC0690
        public void get_speedMultiplier(){} // RVA: 0x7FFD54C31DF0
        public void get_tagHash(){} // RVA: 0x7FFD510E4740
        public void IsTag(){} // RVA: 0x7FFD54C48BD0
        public void get_loop(){} // RVA: 0x7FFD54C31E00
    }

    public class AnimatorTransitionInfo : ValueType
    {
        public object fullPathHash;
        public object nameHash;
        public object userNameHash;
        public object durationUnit;
        public object duration;
        public object normalizedTime;
        public object anyState;

        // ── Methods ──
        public void IsName(){} // RVA: 0x7FFD54C48C40
        public void IsUserName(){} // RVA: 0x7FFD54C48D00
        public void get_fullPathHash(){} // RVA: 0x7FFD543B3F90
        public void get_nameHash(){} // RVA: 0x7FFD5195D9A0
        public void get_userNameHash(){} // RVA: 0x7FFD51DEBEA0
        public void get_durationUnit(){} // RVA: 0x7FFD54C48D70
        public void get_duration(){} // RVA: 0x7FFD54C34DF0
        public void get_normalizedTime(){} // RVA: 0x7FFD50CC0690
        public void get_anyState(){} // RVA: 0x7FFD54C48D80
    }

    public class Application : Object
    {
        public object isPlaying;
        public object isFocused;
        public object buildGUID;
        public object runInBackground;
        public object isBatchMode;
        public object dataPath;
        public object streamingAssetsPath;
        public object persistentDataPath;
        public object temporaryCachePath;
        public object unityVersion;
        public object version;
        public object installMode;
        public object productName;
        public object companyName;
        public object cloudProjectId;
        public object targetFrameRate;
        public object backgroundLoadingPriority;
        public object platform;
        public object isMobilePlatform;
        public object systemLanguage;
        public object internetReachability;
        public object isEditor;

        // ── Methods ──
        public void Quit(){} // RVA: 0x7FFD54C72EF0 | overloaded x2
        public void get_isPlaying(){} // RVA: 0x7FFD54C72F70
        public void get_isFocused(){} // RVA: 0x7FFD54C72FC0
        public void get_buildGUID(){} // RVA: 0x7FFD54C73010
        public void get_runInBackground(){} // RVA: 0x7FFD54C73060
        public void set_runInBackground(){} // RVA: 0x7FFD54C730B0
        public void get_isBatchMode(){} // RVA: 0x7FFD54C73100
        public void get_dataPath(){} // RVA: 0x7FFD54C73150
        public void get_streamingAssetsPath(){} // RVA: 0x7FFD54C731A0
        public void get_persistentDataPath(){} // RVA: 0x7FFD54C731F0
        public void get_temporaryCachePath(){} // RVA: 0x7FFD54C73240
        public void get_unityVersion(){} // RVA: 0x7FFD54C73290
        public void get_version(){} // RVA: 0x7FFD54C732E0
        public void get_installMode(){} // RVA: 0x7FFD54C73330
        public void get_productName(){} // RVA: 0x7FFD54C73380
        public void get_companyName(){} // RVA: 0x7FFD54C733D0
        public void get_cloudProjectId(){} // RVA: 0x7FFD54C73420
        public void OpenURL(){} // RVA: 0x7FFD54C73470
        public void get_targetFrameRate(){} // RVA: 0x7FFD54C734C0
        public void set_targetFrameRate(){} // RVA: 0x7FFD54C73510
        public void SetLogCallbackDefined(){} // RVA: 0x7FFD54C73560
        public void GetStackTraceLogType(){} // RVA: 0x7FFD54C735B0
        public void set_backgroundLoadingPriority(){} // RVA: 0x7FFD54C73600
        public void RequestUserAuthorization(){} // RVA: 0x7FFD54C73650
        public void HasUserAuthorization(){} // RVA: 0x7FFD54C736A0
        public void get_platform(){} // RVA: 0x7FFD54C736F0
        public void get_isMobilePlatform(){} // RVA: 0x7FFD54C73740
        public void get_systemLanguage(){} // RVA: 0x7FFD54C73830
        public void get_internetReachability(){} // RVA: 0x7FFD54C73880
        public void add_lowMemory(){} // RVA: 0x7FFD54C738D0
        public void remove_lowMemory(){} // RVA: 0x7FFD54C73A20
        public void CallLowMemory(){} // RVA: 0x7FFD54C73B70
        public void HasLogCallback(){} // RVA: 0x7FFD54C73CB0
        public void add_logMessageReceivedThreaded(){} // RVA: 0x7FFD54C73D40
        public void remove_logMessageReceivedThreaded(){} // RVA: 0x7FFD54C73EC0
        public void CallLogCallback(){} // RVA: 0x7FFD54C74000
        public void add_onBeforeRender(){} // RVA: 0x7FFD54C740F0
        public void remove_onBeforeRender(){} // RVA: 0x7FFD54C74140
        public void add_focusChanged(){} // RVA: 0x7FFD54C74190
        public void remove_focusChanged(){} // RVA: 0x7FFD54C742F0
        public void add_wantsToQuit(){} // RVA: 0x7FFD54C74450
        public void remove_wantsToQuit(){} // RVA: 0x7FFD54C745B0
        public void add_quitting(){} // RVA: 0x7FFD54C74710
        public void remove_quitting(){} // RVA: 0x7FFD54C74860
        public void Internal_ApplicationWantsToQuit(){} // RVA: 0x7FFD54C749B0
        public void Internal_ApplicationQuit(){} // RVA: 0x7FFD54C74B60
        public void Internal_ApplicationUnload(){} // RVA: 0x7FFD54C74D00
        public void InvokeOnBeforeRender(){} // RVA: 0x7FFD54C74DA0
        public void InvokeFocusChanged(){} // RVA: 0x7FFD54C74DF0
        public void InvokeDeepLinkActivated(){} // RVA: 0x7FFD54C74E90
        public void get_isEditor(){} // RVA: 0x7FFD506288B0
        public void .cctor(){} // RVA: 0x7FFD54C74F30
    }

    public class AreaEffector2D : Effector2D
    {
        public object forceAngle;
        public object useGlobalAngle;
        public object forceMagnitude;
        public object forceVariation;
        public object drag;
        public object angularDrag;
        public object forceTarget;

        // ── Methods ──
        public void get_forceAngle(){} // RVA: 0x7FFD54DA5B60
        public void set_forceAngle(){} // RVA: 0x7FFD54DA5BB0
        public void get_useGlobalAngle(){} // RVA: 0x7FFD54DA5C10
        public void set_useGlobalAngle(){} // RVA: 0x7FFD54DA5C60
        public void get_forceMagnitude(){} // RVA: 0x7FFD54DA5CC0
        public void set_forceMagnitude(){} // RVA: 0x7FFD54DA5D10
        public void get_forceVariation(){} // RVA: 0x7FFD54DA5D70
        public void set_forceVariation(){} // RVA: 0x7FFD54DA5DC0
        public void get_drag(){} // RVA: 0x7FFD54DA5E20
        public void set_drag(){} // RVA: 0x7FFD54DA5E70
        public void get_angularDrag(){} // RVA: 0x7FFD54DA5ED0
        public void set_angularDrag(){} // RVA: 0x7FFD54DA5F20
        public void get_forceTarget(){} // RVA: 0x7FFD54DA5F80
        public void set_forceTarget(){} // RVA: 0x7FFD54DA5FD0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ArticulationBody : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AssemblyFullName : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54CDB8F0
        public void GetHashCode(){} // RVA: 0x7FFD54CDBAA0
        public void ToString(){} // RVA: 0x7FFD54CDBB40
    }

    public class AssemblyIsEditorAssembly : Attribute
    {
    }

    public class AssemblyVersion : ValueType
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFD54CDB410
        public void ToString(){} // RVA: 0x7FFD54CDB450
        public void Equals(){} // RVA: 0x7FFD54CDB690
        public void GetHashCode(){} // RVA: 0x7FFD54CDB740
    }

    public class AssetBundle : Object
    {
        public ArgCount.safeTypeForwarders isStreamedSceneAssetBundle; // 0x10
        public bool _haveResult; // 0x28
        public bool _useBuilder; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C62B80
        public void LoadFromFile_Internal(){} // RVA: 0x7FFD54C62BD0
        public void LoadFromFile(){} // RVA: 0x7FFD54C62C40
        public void get_isStreamedSceneAssetBundle(){} // RVA: 0x7FFD54C62CA0
        public void LoadAsset(){} // RVA: 0x7FFD54C62DD0 | overloaded x3
        public void LoadAsset_Internal(){} // RVA: 0x7FFD54C62F70
        public void LoadAssetWithSubAssetsAsync(){} // RVA: 0x7FFD54C63200 | overloaded x2
        public void LoadAllAssetsAsync(){} // RVA: 0x7FFD54C634F0 | overloaded x2
        public void Unload(){} // RVA: 0x7FFD54C635C0
        public void UnloadAsync(){} // RVA: 0x7FFD54C63620
        public void GetAllAssetNames(){} // RVA: 0x7FFD54C63680
        public void GetAllScenePaths(){} // RVA: 0x7FFD54C636D0
        public void LoadAssetWithSubAssetsAsync_Internal(){} // RVA: 0x7FFD54C63720
    }

    public class AssetBundleCreateRequest : AsyncOperation
    {
        public object assetBundle;

        // ── Methods ──
        public void get_assetBundle(){} // RVA: 0x7FFD54C637A0
    }

    public class AssetBundleRecompressOperation : AsyncOperation
    {
    }

    public class AssetBundleRequest : ResourceRequest
    {
        public object asset;
        public object allAssets;

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFD54C637F0
        public void get_asset(){} // RVA: 0x7FFD4E3F5BC0
        public void get_allAssets(){} // RVA: 0x7FFD54C63840
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AssetBundleUnloadOperation : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AssetFileNameExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
    }

    public class AsyncInstantiateOperation : AsyncOperation
    {
        public object Result;

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFD545DAEE0
    }

    public class AsyncInstantiateOperationHelper : Object
    {
        // ── Methods ──
        public void SetAsyncInstantiateOperationResult(){} // RVA: 0x7FFD54CD93C0
    }

    public class AsyncInstantiateOperation`1 : CustomYieldInstruction
    {
        public object keepWaiting;
        public object isDone;
        public object progress;
        public object Result;

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFD4E079D00
        public void add_completed(){} // RVA: 0x7FFD4E090A40
        public void remove_completed(){} // RVA: 0x7FFD4E090A40
        public void get_isDone(){} // RVA: 0x7FFD4E079D00
        public void get_progress(){} // RVA: 0x7FFD4E08D880
        public void get_Result(){} // RVA: 0x7FFD4E078E90
    }

    public class AsyncOperation : YieldInstruction
    {
        public object isDone;
        public object progress;
        public object allowSceneActivation;

        // ── Methods ──
        public void InternalDestroy(){} // RVA: 0x7FFD54CD9420
        public void get_isDone(){} // RVA: 0x7FFD54CD9470
        public void get_progress(){} // RVA: 0x7FFD54CD94C0
        public void set_allowSceneActivation(){} // RVA: 0x7FFD54CD9510
        public void Finalize(){} // RVA: 0x7FFD54CD9570
        public void InvokeCompletionEvent(){} // RVA: 0x7FFD54CD95F0
        public void add_completed(){} // RVA: 0x7FFD54CD9670
        public void remove_completed(){} // RVA: 0x7FFD54CD97F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AttributeHelperEngine : Object
    {
        // ── Methods ──
        public void GetParentTypeDisallowingMultipleInclusion(){} // RVA: 0x7FFD54CD98F0
        public void GetRequiredComponents(){} // RVA: 0x7FFD54CD9AB0
        public void GetExecuteMode(){} // RVA: 0x7FFD54CD9F70
        public void CheckIsEditorScript(){} // RVA: 0x7FFD54CDA0F0
        public void GetDefaultExecutionOrderFor(){} // RVA: 0x7FFD54CDA370
        public void GetCustomAttributeOfType(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD54CDA520
    }

    public class AudioBehaviour : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioChorusFilter : Behaviour
    {
        public object dryMix;
        public object wetMix1;
        public object wetMix2;
        public object wetMix3;
        public object delay;
        public object rate;
        public object depth;
        public object feedback;

        // ── Methods ──
        public void get_dryMix(){} // RVA: 0x7FFD54C68B10
        public void set_dryMix(){} // RVA: 0x7FFD54C68B60
        public void get_wetMix1(){} // RVA: 0x7FFD54C68BC0
        public void set_wetMix1(){} // RVA: 0x7FFD54C68C10
        public void get_wetMix2(){} // RVA: 0x7FFD54C68C70
        public void set_wetMix2(){} // RVA: 0x7FFD54C68CC0
        public void get_wetMix3(){} // RVA: 0x7FFD54C68D20
        public void set_wetMix3(){} // RVA: 0x7FFD54C68D70
        public void get_delay(){} // RVA: 0x7FFD54C68DD0
        public void set_delay(){} // RVA: 0x7FFD54C68E20
        public void get_rate(){} // RVA: 0x7FFD54C68E80
        public void set_rate(){} // RVA: 0x7FFD54C68ED0
        public void get_depth(){} // RVA: 0x7FFD54C68F30
        public void set_depth(){} // RVA: 0x7FFD54C68F80
        public void get_feedback(){} // RVA: 0x7FFD54C68FE0
        public void set_feedback(){} // RVA: 0x7FFD54C69050
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioClip : Object
    {
        public object length;
        public object samples;
        public object channels;
        public object frequency;
        public object loadType;
        public object preloadAudioData;
        public object ambisonic;
        public object loadInBackground;
        public object loadState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C63ED0
        public void GetData(){} // RVA: 0x7FFD54C64570 | overloaded x2
        public void SetData(){} // RVA: 0x7FFD54C64760 | overloaded x2
        public void Construct_Internal(){} // RVA: 0x7FFD54C640D0
        public void GetName(){} // RVA: 0x7FFD54C64120
        public void CreateUserSound(){} // RVA: 0x7FFD54C64170
        public void get_length(){} // RVA: 0x7FFD54C64200
        public void get_samples(){} // RVA: 0x7FFD54C64250
        public void get_channels(){} // RVA: 0x7FFD54C642A0
        public void get_frequency(){} // RVA: 0x7FFD54C642F0
        public void get_loadType(){} // RVA: 0x7FFD54C64340
        public void LoadAudioData(){} // RVA: 0x7FFD54C64390
        public void UnloadAudioData(){} // RVA: 0x7FFD54C643E0
        public void get_preloadAudioData(){} // RVA: 0x7FFD54C64430
        public void get_ambisonic(){} // RVA: 0x7FFD54C64480
        public void get_loadInBackground(){} // RVA: 0x7FFD54C644D0
        public void get_loadState(){} // RVA: 0x7FFD54C64520
        public void Create(){} // RVA: 0x7FFD54C64A30 | overloaded x2
        public void add_m_PCMReaderCallback(){} // RVA: 0x7FFD54C64E30
        public void remove_m_PCMReaderCallback(){} // RVA: 0x7FFD54C64F20
        public void add_m_PCMSetPositionCallback(){} // RVA: 0x7FFD54C65010
        public void remove_m_PCMSetPositionCallback(){} // RVA: 0x7FFD54C65100
        public void InvokePCMReaderCallback_Internal(){} // RVA: 0x7FFD54C651F0
        public void InvokePCMSetPositionCallback_Internal(){} // RVA: 0x7FFD54C65210
    }

    public class AudioDistortionFilter : Behaviour
    {
        public object distortionLevel;

        // ── Methods ──
        public void get_distortionLevel(){} // RVA: 0x7FFD54C687A0
        public void set_distortionLevel(){} // RVA: 0x7FFD54C687F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioEchoFilter : Behaviour
    {
        public object delay;
        public object decayRatio;
        public object dryMix;
        public object wetMix;

        // ── Methods ──
        public void get_delay(){} // RVA: 0x7FFD54C68850
        public void set_delay(){} // RVA: 0x7FFD54C688A0
        public void get_decayRatio(){} // RVA: 0x7FFD54C68900
        public void set_decayRatio(){} // RVA: 0x7FFD54C68950
        public void get_dryMix(){} // RVA: 0x7FFD54C689B0
        public void set_dryMix(){} // RVA: 0x7FFD54C68A00
        public void get_wetMix(){} // RVA: 0x7FFD54C68A60
        public void set_wetMix(){} // RVA: 0x7FFD54C68AB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioHighPassFilter : Behaviour
    {
        public object cutoffFrequency;
        public object highpassResonanceQ;

        // ── Methods ──
        public void get_cutoffFrequency(){} // RVA: 0x7FFD54C68640
        public void set_cutoffFrequency(){} // RVA: 0x7FFD54C68690
        public void get_highpassResonanceQ(){} // RVA: 0x7FFD54C686F0
        public void set_highpassResonanceQ(){} // RVA: 0x7FFD54C68740
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioListener : AudioBehaviour
    {
        public object volume;
        public object pause;

        // ── Methods ──
        public void get_volume(){} // RVA: 0x7FFD54C65230
        public void set_volume(){} // RVA: 0x7FFD54C65280
        public void get_pause(){} // RVA: 0x7FFD54C652E0
        public void set_pause(){} // RVA: 0x7FFD54C65330
    }

    public class AudioLowPassFilter : Behaviour
    {
        public object customCutoffCurve;
        public object cutoffFrequency;
        public object lowpassResonanceQ;

        // ── Methods ──
        public void GetCustomLowpassLevelCurveCopy(){} // RVA: 0x7FFD54C68430
        public void SetCustomLowpassLevelCurveHelper(){} // RVA: 0x7FFD54C68480
        public void get_customCutoffCurve(){} // RVA: 0x7FFD54C68430
        public void set_customCutoffCurve(){} // RVA: 0x7FFD54C68480
        public void get_cutoffFrequency(){} // RVA: 0x7FFD54C684E0
        public void set_cutoffFrequency(){} // RVA: 0x7FFD54C68530
        public void get_lowpassResonanceQ(){} // RVA: 0x7FFD54C68590
        public void set_lowpassResonanceQ(){} // RVA: 0x7FFD54C685E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioReverbFilter : Behaviour
    {
        public object reverbPreset;
        public object dryLevel;
        public object room;
        public object roomHF;
        public object roomRolloffFactor;
        public object decayTime;
        public object decayHFRatio;
        public object reflectionsLevel;
        public object reflectionsDelay;
        public object reverbLevel;
        public object reverbDelay;
        public object diffusion;
        public object density;
        public object hfReference;
        public object roomLF;
        public object lfReference;

        // ── Methods ──
        public void get_reverbPreset(){} // RVA: 0x7FFD54C690B0
        public void set_reverbPreset(){} // RVA: 0x7FFD54C69100
        public void get_dryLevel(){} // RVA: 0x7FFD54C69160
        public void set_dryLevel(){} // RVA: 0x7FFD54C691B0
        public void get_room(){} // RVA: 0x7FFD54C69210
        public void set_room(){} // RVA: 0x7FFD54C69260
        public void get_roomHF(){} // RVA: 0x7FFD54C692C0
        public void set_roomHF(){} // RVA: 0x7FFD54C69310
        public void get_roomRolloffFactor(){} // RVA: 0x7FFD54C69370
        public void set_roomRolloffFactor(){} // RVA: 0x7FFD54C693E0
        public void get_decayTime(){} // RVA: 0x7FFD54C69440
        public void set_decayTime(){} // RVA: 0x7FFD54C69490
        public void get_decayHFRatio(){} // RVA: 0x7FFD54C694F0
        public void set_decayHFRatio(){} // RVA: 0x7FFD54C69540
        public void get_reflectionsLevel(){} // RVA: 0x7FFD54C695A0
        public void set_reflectionsLevel(){} // RVA: 0x7FFD54C695F0
        public void get_reflectionsDelay(){} // RVA: 0x7FFD54C69650
        public void set_reflectionsDelay(){} // RVA: 0x7FFD54C696A0
        public void get_reverbLevel(){} // RVA: 0x7FFD54C69700
        public void set_reverbLevel(){} // RVA: 0x7FFD54C69750
        public void get_reverbDelay(){} // RVA: 0x7FFD54C697B0
        public void set_reverbDelay(){} // RVA: 0x7FFD54C69800
        public void get_diffusion(){} // RVA: 0x7FFD54C69860
        public void set_diffusion(){} // RVA: 0x7FFD54C698B0
        public void get_density(){} // RVA: 0x7FFD54C69910
        public void set_density(){} // RVA: 0x7FFD54C69960
        public void get_hfReference(){} // RVA: 0x7FFD54C699C0
        public void set_hfReference(){} // RVA: 0x7FFD54C69A10
        public void get_roomLF(){} // RVA: 0x7FFD54C69A70
        public void set_roomLF(){} // RVA: 0x7FFD54C69AC0
        public void get_lfReference(){} // RVA: 0x7FFD54C69B20
        public void set_lfReference(){} // RVA: 0x7FFD54C69B70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioReverbZone : Behaviour
    {
        public object minDistance;
        public object maxDistance;
        public object reverbPreset;
        public object room;
        public object roomHF;
        public object roomLF;
        public object decayTime;
        public object decayHFRatio;
        public object reflections;
        public object reflectionsDelay;
        public object reverb;
        public object reverbDelay;
        public object HFReference;
        public object LFReference;
        public object roomRolloffFactor;
        public object diffusion;
        public object density;

        // ── Methods ──
        public void get_minDistance(){} // RVA: 0x7FFD54C67860
        public void set_minDistance(){} // RVA: 0x7FFD54C678B0
        public void get_maxDistance(){} // RVA: 0x7FFD54C67910
        public void set_maxDistance(){} // RVA: 0x7FFD54C67960
        public void get_reverbPreset(){} // RVA: 0x7FFD54C679C0
        public void set_reverbPreset(){} // RVA: 0x7FFD54C67A10
        public void get_room(){} // RVA: 0x7FFD54C67A70
        public void set_room(){} // RVA: 0x7FFD54C67AC0
        public void get_roomHF(){} // RVA: 0x7FFD54C67B20
        public void set_roomHF(){} // RVA: 0x7FFD54C67B70
        public void get_roomLF(){} // RVA: 0x7FFD54C67BD0
        public void set_roomLF(){} // RVA: 0x7FFD54C67C20
        public void get_decayTime(){} // RVA: 0x7FFD54C67C80
        public void set_decayTime(){} // RVA: 0x7FFD54C67CD0
        public void get_decayHFRatio(){} // RVA: 0x7FFD54C67D30
        public void set_decayHFRatio(){} // RVA: 0x7FFD54C67D80
        public void get_reflections(){} // RVA: 0x7FFD54C67DE0
        public void set_reflections(){} // RVA: 0x7FFD54C67E30
        public void get_reflectionsDelay(){} // RVA: 0x7FFD54C67E90
        public void set_reflectionsDelay(){} // RVA: 0x7FFD54C67EE0
        public void get_reverb(){} // RVA: 0x7FFD54C67F40
        public void set_reverb(){} // RVA: 0x7FFD54C67F90
        public void get_reverbDelay(){} // RVA: 0x7FFD54C67FF0
        public void set_reverbDelay(){} // RVA: 0x7FFD54C68040
        public void get_HFReference(){} // RVA: 0x7FFD54C680A0
        public void set_HFReference(){} // RVA: 0x7FFD54C680F0
        public void get_LFReference(){} // RVA: 0x7FFD54C68150
        public void set_LFReference(){} // RVA: 0x7FFD54C681A0
        public void get_roomRolloffFactor(){} // RVA: 0x7FFD54C68200
        public void set_roomRolloffFactor(){} // RVA: 0x7FFD54C68270
        public void get_diffusion(){} // RVA: 0x7FFD54C682D0
        public void set_diffusion(){} // RVA: 0x7FFD54C68320
        public void get_density(){} // RVA: 0x7FFD54C68380
        public void set_density(){} // RVA: 0x7FFD54C683D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioSettings : Object
    {
        public object driverCapabilities;
        public object speakerMode;
        public object dspTime;
        public object outputSampleRate;

        // ── Methods ──
        public void GetSpeakerMode(){} // RVA: 0x7FFD54C63890
        public void SetConfiguration(){} // RVA: 0x7FFD54C638E0
        public void GetSampleRate(){} // RVA: 0x7FFD53E10760
        public void get_driverCapabilities(){} // RVA: 0x7FFD54C63930
        public void get_speakerMode(){} // RVA: 0x7FFD54C63890
        public void get_dspTime(){} // RVA: 0x7FFD54C63980
        public void get_outputSampleRate(){} // RVA: 0x7FFD53E10760
        public void GetDSPBufferSize(){} // RVA: 0x7FFD54C639D0
        public void GetConfiguration(){} // RVA: 0x7FFD54C63A30
        public void Reset(){} // RVA: 0x7FFD54C63A90
        public void add_OnAudioConfigurationChanged(){} // RVA: 0x7FFD54C63AF0
        public void remove_OnAudioConfigurationChanged(){} // RVA: 0x7FFD54C63C00
        public void InvokeOnAudioConfigurationChanged(){} // RVA: 0x7FFD54C63D10
        public void InvokeOnAudioSystemShuttingDown(){} // RVA: 0x7FFD54C63D70
        public void InvokeOnAudioSystemStartedUp(){} // RVA: 0x7FFD54C63DD0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void SetConfiguration_Injected(){} // RVA: 0x7FFD54C63E30
        public void GetConfiguration_Injected(){} // RVA: 0x7FFD54C63E80
    }

    public class AudioSource : AudioBehaviour
    {
        public object volume;
        public object pitch;
        public object time;
        public object timeSamples;
        public object clip;
        public object outputAudioMixerGroup;
        public object isPlaying;
        public object isVirtual;
        public object loop;
        public object ignoreListenerVolume;
        public object playOnAwake;
        public object ignoreListenerPause;
        public object velocityUpdateMode;
        public object panStereo;
        public object spatialBlend;
        public object spatialize;
        public object spatializePostEffects;
        public object reverbZoneMix;
        public object bypassEffects;
        public object bypassListenerEffects;
        public object bypassReverbZones;
        public object dopplerLevel;
        public object spread;
        public object priority;
        public object mute;
        public object minDistance;
        public object maxDistance;
        public object rolloffMode;
        public object minVolume;
        public object maxVolume;
        public object rolloffFactor;

        // ── Methods ──
        public void GetPitch(){} // RVA: 0x7FFD54C65380
        public void SetPitch(){} // RVA: 0x7FFD54C653D0
        public void PlayHelper(){} // RVA: 0x7FFD54C65430
        public void Play(){} // RVA: 0x7FFD54C65430 | overloaded x3
        public void PlayOneShotHelper(){} // RVA: 0x7FFD54C654F0
        public void Stop(){} // RVA: 0x7FFD54C65EA0 | overloaded x2
        public void SetCustomCurveHelper(){} // RVA: 0x7FFD54C655C0
        public void GetCustomCurveHelper(){} // RVA: 0x7FFD54C65630
        public void GetOutputDataHelper(){} // RVA: 0x7FFD54C65690
        public void GetSpectrumDataHelper(){} // RVA: 0x7FFD54C65700
        public void get_volume(){} // RVA: 0x7FFD54C65780
        public void set_volume(){} // RVA: 0x7FFD54C657D0
        public void get_pitch(){} // RVA: 0x7FFD54C65380
        public void set_pitch(){} // RVA: 0x7FFD54C653D0
        public void get_time(){} // RVA: 0x7FFD54C65830
        public void set_time(){} // RVA: 0x7FFD54C65880
        public void get_timeSamples(){} // RVA: 0x7FFD54C658E0
        public void set_timeSamples(){} // RVA: 0x7FFD54C65930
        public void get_clip(){} // RVA: 0x7FFD54C65990
        public void set_clip(){} // RVA: 0x7FFD54C659E0
        public void get_outputAudioMixerGroup(){} // RVA: 0x7FFD54C65A40
        public void set_outputAudioMixerGroup(){} // RVA: 0x7FFD54C65A90
        public void PlayDelayed(){} // RVA: 0x7FFD54C65B50
        public void PlayScheduled(){} // RVA: 0x7FFD54C65BD0
        public void PlayOneShot(){} // RVA: 0x7FFD54C65C60 | overloaded x2
        public void SetScheduledStartTime(){} // RVA: 0x7FFD54C65DE0
        public void SetScheduledEndTime(){} // RVA: 0x7FFD54C65E40
        public void Pause(){} // RVA: 0x7FFD54C65F00
        public void UnPause(){} // RVA: 0x7FFD54C65F50
        public void get_isPlaying(){} // RVA: 0x7FFD54C65FA0
        public void get_isVirtual(){} // RVA: 0x7FFD54C65FF0
        public void PlayClipAtPoint(){} // RVA: 0x7FFD54C66070 | overloaded x2
        public void get_loop(){} // RVA: 0x7FFD54C66550
        public void set_loop(){} // RVA: 0x7FFD54C665A0
        public void get_ignoreListenerVolume(){} // RVA: 0x7FFD54C66600
        public void set_ignoreListenerVolume(){} // RVA: 0x7FFD54C66650
        public void get_playOnAwake(){} // RVA: 0x7FFD54C666B0
        public void set_playOnAwake(){} // RVA: 0x7FFD54C66700
        public void get_ignoreListenerPause(){} // RVA: 0x7FFD54C66760
        public void set_ignoreListenerPause(){} // RVA: 0x7FFD54C667B0
        public void get_velocityUpdateMode(){} // RVA: 0x7FFD54C66810
        public void set_velocityUpdateMode(){} // RVA: 0x7FFD54C66860
        public void get_panStereo(){} // RVA: 0x7FFD54C668C0
        public void set_panStereo(){} // RVA: 0x7FFD54C66910
        public void get_spatialBlend(){} // RVA: 0x7FFD54C66970
        public void set_spatialBlend(){} // RVA: 0x7FFD54C669C0
        public void get_spatialize(){} // RVA: 0x7FFD54C66A20
        public void set_spatialize(){} // RVA: 0x7FFD54C66A70
        public void get_spatializePostEffects(){} // RVA: 0x7FFD54C66AD0
        public void set_spatializePostEffects(){} // RVA: 0x7FFD54C66B20
        public void SetCustomCurve(){} // RVA: 0x7FFD54C655C0
        public void GetCustomCurve(){} // RVA: 0x7FFD54C65630
        public void get_reverbZoneMix(){} // RVA: 0x7FFD54C66B80
        public void set_reverbZoneMix(){} // RVA: 0x7FFD54C66BD0
        public void get_bypassEffects(){} // RVA: 0x7FFD54C66C30
        public void set_bypassEffects(){} // RVA: 0x7FFD54C66C80
        public void get_bypassListenerEffects(){} // RVA: 0x7FFD54C66CE0
        public void set_bypassListenerEffects(){} // RVA: 0x7FFD54C66D30
        public void get_bypassReverbZones(){} // RVA: 0x7FFD54C66D90
        public void set_bypassReverbZones(){} // RVA: 0x7FFD54C66DE0
        public void get_dopplerLevel(){} // RVA: 0x7FFD54C66E40
        public void set_dopplerLevel(){} // RVA: 0x7FFD54C66E90
        public void get_spread(){} // RVA: 0x7FFD54C66EF0
        public void set_spread(){} // RVA: 0x7FFD54C66F40
        public void get_priority(){} // RVA: 0x7FFD54C66FA0
        public void set_priority(){} // RVA: 0x7FFD54C66FF0
        public void get_mute(){} // RVA: 0x7FFD54C67050
        public void set_mute(){} // RVA: 0x7FFD54C670A0
        public void get_minDistance(){} // RVA: 0x7FFD54C67100
        public void set_minDistance(){} // RVA: 0x7FFD54C67150
        public void get_maxDistance(){} // RVA: 0x7FFD54C671B0
        public void set_maxDistance(){} // RVA: 0x7FFD54C67200
        public void get_rolloffMode(){} // RVA: 0x7FFD54C67260
        public void set_rolloffMode(){} // RVA: 0x7FFD54C672B0
        public void GetOutputData(){} // RVA: 0x7FFD54C67380 | overloaded x2
        public void GetSpectrumData(){} // RVA: 0x7FFD54C67420 | overloaded x2
        public void get_minVolume(){} // RVA: 0x7FFD54C67430
        public void set_minVolume(){} // RVA: 0x7FFD54C674A0
        public void get_maxVolume(){} // RVA: 0x7FFD54C67500
        public void set_maxVolume(){} // RVA: 0x7FFD54C67570
        public void get_rolloffFactor(){} // RVA: 0x7FFD54C675D0
        public void set_rolloffFactor(){} // RVA: 0x7FFD54C67640
        public void SetSpatializerFloat(){} // RVA: 0x7FFD54C676A0
        public void GetSpatializerFloat(){} // RVA: 0x7FFD54C67710
        public void GetAmbisonicDecoderFloat(){} // RVA: 0x7FFD54C67780
        public void SetAmbisonicDecoderFloat(){} // RVA: 0x7FFD54C677F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Avatar : Object
    {
        public object isValid;
        public object isHuman;
        public object humanDescription;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C50880
        public void get_isValid(){} // RVA: 0x7FFD54C508D0
        public void get_isHuman(){} // RVA: 0x7FFD54C50920
        public void get_humanDescription(){} // RVA: 0x7FFD54C50970
        public void GetAxisLength(){} // RVA: 0x7FFD54C509F0
        public void GetPostRotation(){} // RVA: 0x7FFD54C50A90
        public void Internal_GetAxisLength(){} // RVA: 0x7FFD54C50B60
        public void Internal_GetPostRotation(){} // RVA: 0x7FFD54C50BC0
        public void get_humanDescription_Injected(){} // RVA: 0x7FFD54C50C40
        public void Internal_GetPostRotation_Injected(){} // RVA: 0x7FFD54C50CA0
    }

    public class AvatarMask : Object
    {
        public object transformCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C50FE0
        public void Internal_Create(){} // RVA: 0x7FFD54C51070
        public void GetHumanoidBodyPartActive(){} // RVA: 0x7FFD54C510C0
        public void SetHumanoidBodyPartActive(){} // RVA: 0x7FFD54C51120
        public void get_transformCount(){} // RVA: 0x7FFD54C51190
        public void set_transformCount(){} // RVA: 0x7FFD54C511E0
        public void AddTransformPath(){} // RVA: 0x7FFD54C512B0 | overloaded x2
        public void RemoveTransformPath(){} // RVA: 0x7FFD54C51390 | overloaded x2
        public void GetTransformPath(){} // RVA: 0x7FFD54C51400
        public void SetTransformPath(){} // RVA: 0x7FFD54C51460
        public void GetTransformWeight(){} // RVA: 0x7FFD54C514D0
        public void SetTransformWeight(){} // RVA: 0x7FFD54C51530
        public void GetTransformActive(){} // RVA: 0x7FFD54C515A0
        public void SetTransformActive(){} // RVA: 0x7FFD54C51610
    }

}