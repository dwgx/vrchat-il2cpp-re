// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Avatars.Components
// Classes: 18
// Methods: 112

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAccessoryDescriptor : AssetPart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6D0FB0
    }

    public class VRCAnimatorLayerControl : VRC_AnimatorLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6CB4A0
    }

    public class VRCAnimatorLocomotionControl : VRC_AnimatorLocomotionControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRCAnimatorPlayAudio : VRC_AnimatorPlayAudio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6CB4B0
    }

    public class VRCAnimatorTemporaryPoseSpace : VRC_AnimatorTemporaryPoseSpace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6CB500
    }

    public class VRCAnimatorTrackingControl : VRC_AnimatorTrackingControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRCAvatarDescriptor : VRC_AvatarDescriptor
    {
        public object customExpressions;
        public object expressionsMenu;
        public object expressionParameters;
        public object enableEyeLook;
        public object customEyeLookSettings;
        public object customizeAnimationLayers;
        public object baseAnimationLayers;
        public object specialAnimationLayers;
        public object AnimationPreset;
        public object animationHashSet;
        public object autoFootsteps;
        public object autoLocomotion;
        public object COLLIDER_MAX_SIZE;
        public object collider_head;
        public object collider_torso;
        public object collider_footR;
        public object collider_footL;
        public object collider_handR;
        public object collider_handL;
        public object collider_fingerIndexL;
        public object collider_fingerMiddleL;
        public object collider_fingerRingL;
        public object collider_fingerLittleL;
        public object collider_fingerIndexR;
        public object collider_fingerMiddleR;
        public object collider_fingerRingR;
        public object collider_fingerLittleR;

        // ── Methods ──
        public void GetExpressionParameterCount(){} // RVA: 0xA6CB510
        public void GetExpressionParameter(){} // RVA: 0xA6CB610
        public void CalcHeadCollider(){} // RVA: 0xA6CB730
        public void CalcTorsoCollider(){} // RVA: 0xA6CC3B0
        public void CalcPalmCollider(){} // RVA: 0xA6CD050
        public void CalcFootCollider(){} // RVA: 0xA6CE120
        public void CalcFingerCollider(){} // RVA: 0xA6CEA10
        public void MaxScale(){} // RVA: 0xA6CF110
        public void .ctor(){} // RVA: 0xA6CF140
        public void <CalcPalmCollider>g__AddBone|37_0(){} // RVA: 0xA6CFD90
        public void <CalcFootCollider>g__FindEndBone|38_0(){} // RVA: 0xA6CFF60
    }

    public class VRCAvatarParameterDriver : VRC_AvatarParameterDriver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6D0560
    }

    public class VRCHeadChop : MonoBehaviour
    {
        public object targetBones;
        public object globalScaleFactor;
        public object MaxBoneCount;
        public object MaxComponentCount;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0xA6D0630
        public void Start(){} // RVA: 0xB43310
        public void AppendDesiredTransformScaleFactors(){} // RVA: 0xA6D0820
        public void .ctor(){} // RVA: 0xA6D0E40
    }

    public class VRCHeadChop[] : Array
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

    public class VRCImpostorEnvironment : MonoBehaviour
    {
        public object SkyColor;
        public object EquatorColor;
        public object GroundColor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6D0F50
    }

    public class VRCImpostorSettings : MonoBehaviour
    {
        public object resolutionScale;
        public object transformsToIgnore;
        public object extraChildTransforms;
        public object reparentHere;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class VRCPlayableLayerControl : VRC_PlayableLayerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class VRCRaycast : MonoBehaviour
    {
        public object rootTransform;
        public object raycastDirection;
        public object distance;
        public object applyTransformScale;
        public object collisionMode;
        public object customCollisionLayers;
        public object _worldLayerMask;
        public object _playerLayerMask;
        public object _cachedEffectiveTransform;
        public object resultTransform;
        public object applyRotation;
        public object alignmentAxis;
        public object behaviorOnMiss;
        public object parameter;
        public object _hasInitializedAnimatorParameters;
        public object _submittedWorldSpaceDirection;
        public object MaximumAllowedDistance;
        public object _defaultPhysicsScene;
        public object _commandIndex;
        public object _startCompleted;
        public object _initExternallyBlocked;
        public object OnInitializeParameters;
        public object PARAM_HIT;
        public object PARAM_RATIO;
        public object PARAM_DISTANCE;
        public object param_HitValue;
        public object param_Hit;
        public object param_RatioValue;
        public object param_Ratio;
        public object param_DistanceValue;
        public object param_Distance;

        // ── Methods ──
        public void get_RootTransform(){} // RVA: 0xB700F0
        public void set_RootTransform(){} // RVA: 0xB70100
        public void get_RaycastDirection(){} // RVA: 0xBBF8C0
        public void set_RaycastDirection(){} // RVA: 0xBBF8E0
        public void get_Distance(){} // RVA: 0xC120F0
        public void set_Distance(){} // RVA: 0xA6C85A0
        public void get_ApplyTransformScale(){} // RVA: 0xD16660
        public void set_ApplyTransformScale(){} // RVA: 0xD14C10
        public void get_RaycastCollisionMode(){} // RVA: 0x114DAD0
        public void set_RaycastCollisionMode(){} // RVA: 0x25671C0
        public void get_CustomCollisionLayers(){} // RVA: 0xBE5850
        public void set_CustomCollisionLayers(){} // RVA: 0xBE5860
        public void get_ResultTransform(){} // RVA: 0xC0FFC0
        public void set_ResultTransform(){} // RVA: 0xC0FFD0
        public void get_ApplyRotation(){} // RVA: 0xB6B1A0
        public void set_ApplyRotation(){} // RVA: 0xB6B1B0
        public void get_AlignmentAxis(){} // RVA: 0xD98E40
        public void set_AlignmentAxis(){} // RVA: 0xA6C85B0
        public void get_BehaviorOnMiss(){} // RVA: 0x19C6270
        public void set_BehaviorOnMiss(){} // RVA: 0xCE5450
        public void get_Parameter(){} // RVA: 0xCD3320
        public void set_Parameter(){} // RVA: 0xCD4740
        public void get_CommandIndex(){} // RVA: 0xF3A950
        public void set_CommandIndex(){} // RVA: 0x17AFA20
        public void get_InitExternallyBlocked(){} // RVA: 0x712F980
        public void set_InitExternallyBlocked(){} // RVA: 0xA6C85C0
        public void get_EffectiveTransform(){} // RVA: 0xA6C85D0
        public void Awake(){} // RVA: 0xA6C86C0
        public void Start(){} // RVA: 0xA6C88D0
        public void VRC.Dynamics.IParameterSetup.InitParameters(){} // RVA: 0xA6C8900
        public void TriggerInitializeParameters(){} // RVA: 0xA6C8910
        public void OnEnable(){} // RVA: 0xA6C89A0
        public void OnDisable(){} // RVA: 0xA6C89D0
        public void Register(){} // RVA: 0xA6C89E0
        public void Unregister(){} // RVA: 0xA6C89D0
        public void PopulateRaycastCommand(){} // RVA: 0xA6C8A00
        public void CalculateWorldSpaceDirection(){} // RVA: 0xA6C8C90
        public void CalculateEffectiveDistance(){} // RVA: 0xA6C8EC0
        public void HandleRaycastResult(){} // RVA: 0xA6C9050
        public void SetResult(){} // RVA: 0xA6C9430
        public void SetAnimatorParameterValues(){} // RVA: 0xA6C9940
        public void IsFiniteVector(){} // RVA: 0xA6C9A20
        public void OnDrawGizmosSelected(){} // RVA: 0xA6C9A40
        public void .ctor(){} // RVA: 0xA6C9D50
        public void .cctor(){} // RVA: 0xA6C9E30
    }

    public class VRCRaycastHandler : Object
    {
        public object _activeRaycastComponents;
        public object _pendingAddSet;
        public object _pendingRemoveSet;
        public object _batchHandle;
        public object _commandBuffer;
        public object _resultBuffer;
        public object _currentBatchSize;
        public object _bufferCapacity;
        public object _isInitialized;

        // ── Methods ──
        public void get_ProcessingRaycasts(){} // RVA: 0xA6C9EB0
        public void Initialize(){} // RVA: 0xA6C9EF0
        public void Uninitialize(){} // RVA: 0xA6CA380
        public void AddRaycaster(){} // RVA: 0xA6CA6C0
        public void RemoveRaycaster(){} // RVA: 0xA6CA820
        public void AddressPendingRaycasters(){} // RVA: 0xA6CA940
        public void EnsureBuffers(){} // RVA: 0xA6CAC80
        public void UpdateRaycastHandler(){} // RVA: 0xA6CAEE0
        public void SubmitRaycasts(){} // RVA: 0xA6CAF30
        public void CompleteRaycasts(){} // RVA: 0xA6CB2D0
    }

    public class VRCRaycast[] : Array
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

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA691450
    }

    public class VRCStation : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA69D290
    }

}