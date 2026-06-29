// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine
// Classes: 87
// Methods: 1004

namespace ThirdParty.Cinemachine.Cinemachine
{
    public class AxisBase : ValueType
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7A7673AE0
    }

    public class AxisState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76729E0
        public void Validate(){} // RVA: 0x7A7672A00
        public void Reset(){} // RVA: 0x7A7672A60
        public void SetInputAxisProvider(){} // RVA: 0x7A7672A70
        public void get_HasInputProvider(){} // RVA: 0x7A7672AD0
        public void Update(){} // RVA: 0x7A7672AE0
        public void ClampValue(){} // RVA: 0x7A7672AF0
        public void MaxSpeedUpdate(){} // RVA: 0x7A7672B00
        public void GetMaxSpeed(){} // RVA: 0x7A7672B10
        public void get_ValueRangeLocked(){} // RVA: 0x7A7672B20
        public void set_ValueRangeLocked(){} // RVA: 0x7A7672B30
        public void get_HasRecentering(){} // RVA: 0x7A7672B40
        public void set_HasRecentering(){} // RVA: 0x7A7672B50
    }

    public class AxisStatePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BlendSourceVirtualCamera : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Blend(){} // RVA: 0x7A80F2570
        public void set_Blend(){} // RVA: 0x7A80D8E20
        public void get_Name(){} // RVA: 0x7A9B1B4C0
        public void get_Description(){} // RVA: 0x7A9B1B500
        public void get_Priority(){} // RVA: 0x7A83782A0
        public void set_Priority(){} // RVA: 0x7A84385B0
        public void get_LookAt(){} // RVA: 0x7A81052C0
        public void set_LookAt(){} // RVA: 0x7A81052D0
        public void get_Follow(){} // RVA: 0x7A8105330
        public void set_Follow(){} // RVA: 0x7A80D8E80
        public void get_State(){} // RVA: 0x7A9B1B340
        public void set_State(){} // RVA: 0x7A9B1B3E0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7A82D1450
        public void get_IsValid(){} // RVA: 0x7A9B1B550
        public void get_ParentCamera(){} // RVA: 0x7A82D1450
        public void IsLiveChild(){} // RVA: 0x7A9B1B570
        public void CalculateNewState(){} // RVA: 0x7A9B1B340
        public void UpdateCameraState(){} // RVA: 0x7A9B1B590
        public void InternalUpdateCameraState(){} // RVA: 0x7A80D7310
        public void OnTransitionFromCamera(){} // RVA: 0x7A80D7310
        public void OnTargetObjectWarped(){} // RVA: 0x7A80D7310
    }

    public class CameraState : ValueType
    {
        // ── Methods ──
        public void get_HasLookAt(){} // RVA: 0x7A7672D00
        public void get_CorrectedPosition(){} // RVA: 0x7A7672D60
        public void get_CorrectedOrientation(){} // RVA: 0x7A7672DB0
        public void get_FinalPosition(){} // RVA: 0x7A7672D60
        public void get_FinalOrientation(){} // RVA: 0x7A7672DE0
        public void get_Default(){} // RVA: 0x7A9B145F0
        public void get_NumCustomBlendables(){} // RVA: 0x7A7672E10
        public void set_NumCustomBlendables(){} // RVA: 0x7A7672E20
        public void GetCustomBlendable(){} // RVA: 0x7A7672E30
        public void FindCustomBlendable(){} // RVA: 0x7A7672E60
        public void AddCustomBlendable(){} // RVA: 0x7A7672E70
        public void Lerp(){} // RVA: 0x7A9B15320
        public void InterpolateFOV(){} // RVA: 0x7A9B19490
        public void ApplyPosBlendHint(){} // RVA: 0x7A9B195D0
        public void ApplyRotBlendHint(){} // RVA: 0x7A9B19650
        public void InterpolatePosition(){} // RVA: 0x7A7672E90
        public void .cctor(){} // RVA: 0x7A9B19B80
    }

    public class Cinemachine3rdPersonAim : CinemachineExtension
    {
        // ── Methods ──
        public void get_AimTarget(){} // RVA: 0x7A813E540
        public void set_AimTarget(){} // RVA: 0x7A813E560
        public void OnValidate(){} // RVA: 0x7A9ACAFF0
        public void Reset(){} // RVA: 0x7A9ACB010
        public void OnTransitionFromCamera(){} // RVA: 0x7A9ACB120
        public void DrawReticle(){} // RVA: 0x7A9ACB2A0
        public void ComputeLookAtPoint(){} // RVA: 0x7A9ACB630
        public void ComputeAimTarget(){} // RVA: 0x7A9ACBC50
        public void PostPipelineStageCallback(){} // RVA: 0x7A9ACBED0
        public void .ctor(){} // RVA: 0x7A9ACC220
    }

    public class Cinemachine3rdPersonFollow : CinemachineComponentBase
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9AFCB50
        public void Reset(){} // RVA: 0x7A9AFCBD0
        public void OnDestroy(){} // RVA: 0x7A9AFCC40
        public void get_IsValid(){} // RVA: 0x7A9AFCC90
        public void get_Stage(){} // RVA: 0x7A82D1450
        public void GetMaxDampTime(){} // RVA: 0x7A9AFCDC0
        public void MutateCameraState(){} // RVA: 0x7A9AFCDF0
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AFCE80
        public void PositionCamera(){} // RVA: 0x7A9AFCFF0
        public void GetRigPositions(){} // RVA: 0x7A9AFD710
        public void GetHeading(){} // RVA: 0x7A9AFD930
        public void GetRawRigPositions(){} // RVA: 0x7A9AFDE90
        public void ResolveCollisions(){} // RVA: 0x7A9AFE200
        public void .ctor(){} // RVA: 0x7A9AFE540
    }

    public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9AFE610
        public void get_Stage(){} // RVA: 0x7A81DDCC0
        public void MutateCameraState(){} // RVA: 0x7A9AFE730
        public void ReSeed(){} // RVA: 0x7A9AFF210
        public void Initialize(){} // RVA: 0x7A9AFF340
        public void .ctor(){} // RVA: 0x7A9AFF550
    }

    public class CinemachineBlend : Object
    {
        // ── Methods ──
        public void get_BlendWeight(){} // RVA: 0x7A9B19BD0
        public void get_IsValid(){} // RVA: 0x7A9B19CC0
        public void get_IsComplete(){} // RVA: 0x7A9B19D40
        public void get_Description(){} // RVA: 0x7A9B19D70
        public void Uses(){} // RVA: 0x7A9B19F80
        public void .ctor(){} // RVA: 0x7A9B1A080
        public void UpdateCameraState(){} // RVA: 0x7A9B1A1A0
        public void get_State(){} // RVA: 0x7A9B1A290
        public void CamA(){} // RVA: 0x7B3FA7CD8
    }

    public class CinemachineBlendDefinition : ValueType
    {
        // ── Methods ──
        public void get_BlendTime(){} // RVA: 0x7A7673100
        public void .ctor(){} // RVA: 0x7A7673110
        public void CreateStandardCurves(){} // RVA: 0x7A7673170
        public void get_BlendCurve(){} // RVA: 0x7A7673180
    }

    public class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7A9ACC2F0
        public void Reset(){} // RVA: 0x7A9ACC430
        public void get_LiveChild(){} // RVA: 0x7A81F50F0
        public void set_LiveChild(){} // RVA: 0x7A81F5100
        public void IsLiveChild(){} // RVA: 0x7A9ACC5A0
        public void get_State(){} // RVA: 0x7A9ACC5D0
        public void get_LookAt(){} // RVA: 0x7A9ACC670
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A9ACC680
        public void set_Follow(){} // RVA: 0x7A8142620
        public void OnTargetObjectWarped(){} // RVA: 0x7A9ACC690
        public void ForceCameraPosition(){} // RVA: 0x7A9ACC770
        public void OnTransitionFromCamera(){} // RVA: 0x7A9ACC870
        public void InternalUpdateCameraState(){} // RVA: 0x7A9ACCAA0
        public void OnEnable(){} // RVA: 0x7A9ACD470
        public void OnDisable(){} // RVA: 0x7A9ACD7E0
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9ACD960
        public void OnGuiHandler(){} // RVA: 0x7A9ACD970
        public void get_ChildCameras(){} // RVA: 0x7A9ACDAE0
        public void get_IsBlending(){} // RVA: 0x7A9ACDB00
        public void InvalidateListOfChildren(){} // RVA: 0x7A9ACDB10
        public void UpdateListOfChildren(){} // RVA: 0x7A9ACDBD0
        public void ValidateInstructions(){} // RVA: 0x7A9ACDF70
        public void AdvanceCurrentInstruction(){} // RVA: 0x7A9ACE380
        public void .ctor(){} // RVA: 0x7A9ACE5C0
    }

    public class CinemachineBlenderSettings : ScriptableObject
    {
        // ── Methods ──
        public void GetBlendForVirtualCameras(){} // RVA: 0x7A9B1B760
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class CinemachineBrain : MonoBehaviour
    {
        // ── Methods ──
        public void get_OutputCamera(){} // RVA: 0x7A9ACE790
        public void get_ControlledObject(){} // RVA: 0x7A9ACE900
        public void set_ControlledObject(){} // RVA: 0x7A9ACEA20
        public void get_SoloCamera(){} // RVA: 0x7A9ACEAE0
        public void set_SoloCamera(){} // RVA: 0x7A9ACEB40
        public void GetSoloGUIColor(){} // RVA: 0x7A9ACEDA0
        public void get_DefaultWorldUp(){} // RVA: 0x7A9ACEDC0
        public void OnEnable(){} // RVA: 0x7A9ACEF50
        public void OnDisable(){} // RVA: 0x7A9ACF4C0
        public void OnSceneLoaded(){} // RVA: 0x7A9ACF7C0
        public void OnSceneUnloaded(){} // RVA: 0x7A9ACF860
        public void Awake(){} // RVA: 0x7A9ACF900
        public void Start(){} // RVA: 0x7A9ACF960
        public void OnGuiHandler(){} // RVA: 0x7A9ACF980
        public void AfterPhysics(){} // RVA: 0x7A9ACFE60
        public void LateUpdate(){} // RVA: 0x7A9ACFF00
        public void ManualUpdate(){} // RVA: 0x7A9ACFF10
        public void GetEffectiveDeltaTime(){} // RVA: 0x7A9AD0240
        public void UpdateVirtualCameras(){} // RVA: 0x7A9AD0500
        public void get_ActiveVirtualCamera(){} // RVA: 0x7A9AD0890
        public void DeepCamBFromBlend(){} // RVA: 0x7A9AD0A10
        public void IsLiveInBlend(){} // RVA: 0x7A9AD0AD0
        public void get_IsBlending(){} // RVA: 0x7A9AD0C00
        public void get_ActiveBlend(){} // RVA: 0x7A9AD0C20
        public void set_ActiveBlend(){} // RVA: 0x7A9AD0D20
        public void GetBrainFrame(){} // RVA: 0x7A9AD0E40
        public void SetCameraOverride(){} // RVA: 0x7A9AD0F90
        public void ReleaseCameraOverride(){} // RVA: 0x7A9AD14D0
        public void ProcessActiveCamera(){} // RVA: 0x7A9AD15C0
        public void UpdateFrame0(){} // RVA: 0x7A9AD1D10
        public void ComputeCurrentBlend(){} // RVA: 0x7A9AD2530
        public void IsLive(){} // RVA: 0x7A9AD2B40
        public void get_CurrentCameraState(){} // RVA: 0x7A9AD2D20
        public void set_CurrentCameraState(){} // RVA: 0x7A9AD2DC0
        public void TopCameraFromPriorityQueue(){} // RVA: 0x7A9AD2EB0
        public void LookupBlend(){} // RVA: 0x7A9AD31E0
        public void PushStateToUnityCamera(){} // RVA: 0x7A9AD3440
        public void .ctor(){} // RVA: 0x7A9AD3AD0
        public void .cctor(){} // RVA: 0x7A9AD3F30
    }

    public class CinemachineBrain[] : Array
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

    public class CinemachineClearShot : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7A9AD44F0
        public void get_LiveChild(){} // RVA: 0x7A8142870
        public void set_LiveChild(){} // RVA: 0x7A8142880
        public void get_State(){} // RVA: 0x7A9AD4630
        public void IsLiveChild(){} // RVA: 0x7A9AD46D0
        public void get_LookAt(){} // RVA: 0x7A9ACC670
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A9ACC680
        public void set_Follow(){} // RVA: 0x7A8142620
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AD4700
        public void ForceCameraPosition(){} // RVA: 0x7A9AD47E0
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AD48E0
        public void OnEnable(){} // RVA: 0x7A9AD5020
        public void OnDisable(){} // RVA: 0x7A9AD5340
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9AD54C0
        public void OnGuiHandler(){} // RVA: 0x7A9AD54E0
        public void get_IsBlending(){} // RVA: 0x7A9AD5650
        public void get_ActiveBlend(){} // RVA: 0x7A8B562C0
        public void get_ChildCameras(){} // RVA: 0x7A9AD5660
        public void InvalidateListOfChildren(){} // RVA: 0x7A9AD5680
        public void ResetRandomization(){} // RVA: 0x7A9AD57A0
        public void UpdateListOfChildren(){} // RVA: 0x7A9AD5820
        public void ChooseCurrentCamera(){} // RVA: 0x7A9AD5CE0
        public void Randomize(){} // RVA: 0x7A9AD66D0
        public void LookupBlend(){} // RVA: 0x7A9AD6C10
        public void OnTransitionFromCamera(){} // RVA: 0x7A9AD6E80
        public void .ctor(){} // RVA: 0x7A9AD7010
    }

    public class CinemachineCollider : CinemachineExtension
    {
        // ── Methods ──
        public void IsTargetObscured(){} // RVA: 0x7A9AD7360
        public void CameraWasDisplaced(){} // RVA: 0x7A9AD73C0
        public void GetCameraDisplacementDistance(){} // RVA: 0x7A9AD7430
        public void OnValidate(){} // RVA: 0x7A9AD74A0
        public void OnDestroy(){} // RVA: 0x7A9AD74F0
        public void get_DebugPaths(){} // RVA: 0x7A9AD7560
        public void GetMaxDampTime(){} // RVA: 0x7A9AD7790
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AD77B0
        public void PostPipelineStageCallback(){} // RVA: 0x7A9AD78B0
        public void PreserveLineOfSight(){} // RVA: 0x7A9AD8BA0
        public void PullCameraInFrontOfNearestObstacle(){} // RVA: 0x7A9AD9170
        public void PushCameraBack(){} // RVA: 0x7A9AD9690
        public void GetWalkingDirection(){} // RVA: 0x7A9ADA0F0
        public void GetPushBackDistance(){} // RVA: 0x7A9ADAA40
        public void ClampRayToBounds(){} // RVA: 0x7A9ADABB0
        public void RespectCameraRadius(){} // RVA: 0x7A9ADBB80
        public void CheckForTargetObstructions(){} // RVA: 0x7A9ADC870
        public void IsTargetOffscreen(){} // RVA: 0x7A9ADCCE0
        public void .ctor(){} // RVA: 0x7A9ADD560
        public void .cctor(){} // RVA: 0x7A9ADD6D0
    }

    public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A9B31750
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void OnCollisionEnter(){} // RVA: 0x7A9B31870
        public void OnTriggerEnter(){} // RVA: 0x7A9B31920
        public void GetMassAndVelocity(){} // RVA: 0x7A9B31990
        public void GenerateImpactEvent(){} // RVA: 0x7A9B31E90
        public void OnCollisionEnter2D(){} // RVA: 0x7A9B321E0
        public void OnTriggerEnter2D(){} // RVA: 0x7A9B32240
        public void GetMassAndVelocity2D(){} // RVA: 0x7A9B322B0
        public void GenerateImpactEvent2D(){} // RVA: 0x7A9B32700
        public void .ctor(){} // RVA: 0x7A9B32A50
    }

    public class CinemachineComponentBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7A9B1BAB0
        public void get_FollowTarget(){} // RVA: 0x7A9B1BEC0
        public void get_LookAtTarget(){} // RVA: 0x7A9B1BFC0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7A9B1C0C0
        public void get_FollowTargetGroup(){} // RVA: 0x7A9B1C1A0
        public void get_FollowTargetPosition(){} // RVA: 0x7A9B1C220
        public void get_FollowTargetRotation(){} // RVA: 0x7A9B1C520
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7A9B1C7F0
        public void get_LookAtTargetGroup(){} // RVA: 0x7A9B1C820
        public void get_LookAtTargetPosition(){} // RVA: 0x7A9B1C8B0
        public void get_LookAtTargetRotation(){} // RVA: 0x7A9B1CBB0
        public void get_VcamState(){} // RVA: 0x7A9B1CE80
        public void get_IsValid(){} // RVA: 0x7A7E01900
        public void PrePipelineMutateCameraState(){} // RVA: 0x7A80D7310
        public void get_Stage(){} // RVA: 0x7A7E00710
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7A80D7320
        public void MutateCameraState(){} // RVA: 0x7A7E1DD40
        public void OnTransitionFromCamera(){} // RVA: 0x7A80D7320
        public void OnTargetObjectWarped(){} // RVA: 0x7A80D7310
        public void ForceCameraPosition(){} // RVA: 0x7A80D7310
        public void GetMaxDampTime(){} // RVA: 0x7A889BC60
        public void get_RequiresUserInput(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachineComponentBase[] : Array
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

    public class CinemachineComposer : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9AFF630
        public void get_Stage(){} // RVA: 0x7A81CA9D0
        public void get_TrackedPoint(){} // RVA: 0x7A9AFF760
        public void set_TrackedPoint(){} // RVA: 0x7A9AFF780
        public void GetLookAtPointAndSetTrackedPoint(){} // RVA: 0x7A9AFF790
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AFFC60
        public void ForceCameraPosition(){} // RVA: 0x7A9AFFE60
        public void GetMaxDampTime(){} // RVA: 0x7A9AFFE80
        public void PrePipelineMutateCameraState(){} // RVA: 0x7A9AFFE90
        public void MutateCameraState(){} // RVA: 0x7A9AFFFD0
        public void get_SoftGuideRect(){} // RVA: 0x7A9B00D70
        public void set_SoftGuideRect(){} // RVA: 0x7A9B00DC0
        public void get_HardGuideRect(){} // RVA: 0x7A9B00E80
        public void set_HardGuideRect(){} // RVA: 0x7A9B00F00
        public void RotateToScreenBounds(){} // RVA: 0x7A9B00F70
        public void ClampVerticalBounds(){} // RVA: 0x7A9B01250
        public void .ctor(){} // RVA: 0x7A9B01550
    }

    public class CinemachineConfiner : CinemachineExtension
    {
        // ── Methods ──
        public void CameraWasDisplaced(){} // RVA: 0x7A9ADD910
        public void GetCameraDisplacementDistance(){} // RVA: 0x7A9ADD980
        public void OnValidate(){} // RVA: 0x7A9ADD9E0
        public void ConnectToVcam(){} // RVA: 0x7A9ADD9F0
        public void get_IsValid(){} // RVA: 0x7A9ADDA00
        public void GetMaxDampTime(){} // RVA: 0x7A861F990
        public void PostPipelineStageCallback(){} // RVA: 0x7A9ADDC90
        public void InvalidatePathCache(){} // RVA: 0x7A9ADDF70
        public void ValidatePathCache(){} // RVA: 0x7A9ADE020
        public void ConfinePoint(){} // RVA: 0x7A9ADE990
        public void ConfineScreenEdges(){} // RVA: 0x7A9ADEFE0
        public void .ctor(){} // RVA: 0x7A9ADF810
    }

    public class CinemachineConfiner2D : CinemachineExtension
    {
        // ── Methods ──
        public void InvalidateCache(){} // RVA: 0x7A9ADF860
        public void ValidateCache(){} // RVA: 0x7A9ADF870
        public void PostPipelineStageCallback(){} // RVA: 0x7A9ADF8C0
        public void CalculateHalfFrustumHeight(){} // RVA: 0x7A9AE00F0
        public void OnValidate(){} // RVA: 0x7A9AE01A0
        public void Reset(){} // RVA: 0x7A9AE01C0
        public void .ctor(){} // RVA: 0x7A9AE01D0
    }

    public class CinemachineCore : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7A9B1D030
        public void get_DeltaTime(){} // RVA: 0x7A9B1D160
        public void get_CurrentTime(){} // RVA: 0x7A9B1D220
        public void get_BrainCount(){} // RVA: 0x7A9B1D2E0
        public void GetActiveBrain(){} // RVA: 0x7A9B1D330
        public void AddActiveBrain(){} // RVA: 0x7A9B1D3B0
        public void RemoveActiveBrain(){} // RVA: 0x7A9B1D450
        public void get_VirtualCameraCount(){} // RVA: 0x7A9B1D4B0
        public void GetVirtualCamera(){} // RVA: 0x7A9B1D500
        public void AddActiveCamera(){} // RVA: 0x7A9B1D6C0
        public void RemoveActiveCamera(){} // RVA: 0x7A9B1D730
        public void CameraDestroyed(){} // RVA: 0x7A9B1D7B0
        public void CameraEnabled(){} // RVA: 0x7A9B1D8A0
        public void CameraDisabled(){} // RVA: 0x7A9B1DB00
        public void UpdateAllActiveVirtualCameras(){} // RVA: 0x7A9B1DD40
        public void UpdateVirtualCamera(){} // RVA: 0x7A9B1E4A0
        public void InitializeModule(){} // RVA: 0x7A9B1E990
        public void GetUpdateTarget(){} // RVA: 0x7A9B1EA90
        public void GetVcamUpdateStatus(){} // RVA: 0x7A9B1EDB0
        public void IsLive(){} // RVA: 0x7A9B1EE40
        public void IsLiveInBlend(){} // RVA: 0x7A9B1EFA0
        public void GenerateCameraActivationEvent(){} // RVA: 0x7A9B1F100
        public void GenerateCameraCutEvent(){} // RVA: 0x7A9B1F2F0
        public void FindPotentialTargetBrain(){} // RVA: 0x7A9B1F550
        public void OnTargetObjectWarped(){} // RVA: 0x7A9B1FA20
        public void .ctor(){} // RVA: 0x7A9B1FAF0
        public void .cctor(){} // RVA: 0x7A9B1FCE0
        public void kStreamingVersion(){} // RVA: 0x7B41F0F98
    }

    public class CinemachineDollyCart : MonoBehaviour
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7A9AE14F0
        public void Update(){} // RVA: 0x7A9AE1580
        public void LateUpdate(){} // RVA: 0x7A9AE1690
        public void SetCartPosition(){} // RVA: 0x7A9AE17B0
        public void .ctor(){} // RVA: 0x7A9AE19C0
    }

    public class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
    }

    public class CinemachineExtension : MonoBehaviour
    {
        // ── Methods ──
        public void get_VirtualCamera(){} // RVA: 0x7A9B20480
        public void Awake(){} // RVA: 0x7A9B205C0
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void OnDestroy(){} // RVA: 0x7A9B205E0
        public void EnsureStarted(){} // RVA: 0x7A9B205C0
        public void ConnectToVcam(){} // RVA: 0x7A9B20600
        public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7A80D7310
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7A9B20880
        public void PostPipelineStageCallback(){} // RVA: 0x7A7E1E270
        public void OnTargetObjectWarped(){} // RVA: 0x7A80D7310
        public void ForceCameraPosition(){} // RVA: 0x7A80D7310
        public void OnTransitionFromCamera(){} // RVA: 0x7A80D7320
        public void GetMaxDampTime(){} // RVA: 0x7A889BC60
        public void get_RequiresUserInput(){} // RVA: 0x7A80D7320
        public void GetExtraState(){} // RVA: 0x7A8051B10
        public void GetAllExtraStates(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void Epsilon(){} // RVA: 0x7A8051B10
    }

    public class CinemachineExtension[] : Array
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

    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A9AE1A10
        public void get_LookAt(){} // RVA: 0x7A87D9480
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A8B76160
        public void set_Follow(){} // RVA: 0x7A8B592F0
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AE1AB0
        public void .ctor(){} // RVA: 0x7A9AE26D0
    }

    public class CinemachineFixedSignal : SignalSourceAsset
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7A9B32C10
        public void AxisDuration(){} // RVA: 0x7A9B32C70
        public void GetSignal(){} // RVA: 0x7A9B32D70
        public void AxisValue(){} // RVA: 0x7A9B32F50
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class CinemachineFollowZoom : CinemachineExtension
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9AE28A0
        public void GetMaxDampTime(){} // RVA: 0x7A81A2250
        public void PostPipelineStageCallback(){} // RVA: 0x7A9AE2900
        public void .ctor(){} // RVA: 0x7A9AE2CF0
    }

    public class CinemachineFramingTransposer : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_SoftGuideRect(){} // RVA: 0x7A9B02420
        public void set_SoftGuideRect(){} // RVA: 0x7A9B02470
        public void get_HardGuideRect(){} // RVA: 0x7A9B02530
        public void set_HardGuideRect(){} // RVA: 0x7A9B025B0
        public void OnValidate(){} // RVA: 0x7A9B02620
        public void get_IsValid(){} // RVA: 0x7A9B02710
        public void get_Stage(){} // RVA: 0x7A82D1450
        public void get_BodyAppliesAfterAim(){} // RVA: 0x7A81BD750
        public void get_TrackedPoint(){} // RVA: 0x7A9B02840
        public void set_TrackedPoint(){} // RVA: 0x7A9B02860
        public void OnTargetObjectWarped(){} // RVA: 0x7A9B02880
        public void ForceCameraPosition(){} // RVA: 0x7A9B02A40
        public void GetMaxDampTime(){} // RVA: 0x7A9B02A70
        public void OnTransitionFromCamera(){} // RVA: 0x7A9B02A90
        public void ScreenToOrtho(){} // RVA: 0x7A9B02CC0
        public void OrthoOffsetToScreenBounds(){} // RVA: 0x7A9B02D90
        public void get_LastBounds(){} // RVA: 0x7A9B02EA0
        public void set_LastBounds(){} // RVA: 0x7A9B02EC0
        public void get_LastBoundsMatrix(){} // RVA: 0x7A9B02EE0
        public void set_LastBoundsMatrix(){} // RVA: 0x7A9B02F10
        public void MutateCameraState(){} // RVA: 0x7A9B02F40
        public void GetTargetHeight(){} // RVA: 0x7A9B04AC0
        public void ComputeGroupBounds(){} // RVA: 0x7A9B04CC0
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7A9B054C0
        public void .ctor(){} // RVA: 0x7A9B05CD0
    }

    public class CinemachineFreeLook : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9AE2D50
        public void GetRig(){} // RVA: 0x7A9AE3030
        public void get_RigsAreCreated(){} // RVA: 0x7A9AE3090
        public void get_RigNames(){} // RVA: 0x7A9AE30B0
        public void OnEnable(){} // RVA: 0x7A9AE3170
        public void UpdateInputAxisProvider(){} // RVA: 0x7A9AE3390
        public void OnDestroy(){} // RVA: 0x7A9AE3550
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9AE3770
        public void Reset(){} // RVA: 0x7A9AE37D0
        public void get_PreviousStateIsValid(){} // RVA: 0x7A8359360
        public void set_PreviousStateIsValid(){} // RVA: 0x7A9AE37F0
        public void get_State(){} // RVA: 0x7A9AE3970
        public void get_LookAt(){} // RVA: 0x7A9ACC670
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A9ACC680
        public void set_Follow(){} // RVA: 0x7A8142620
        public void IsLiveChild(){} // RVA: 0x7A9AE3A10
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AE3B20
        public void ForceCameraPosition(){} // RVA: 0x7A9AE3C10
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AE3E80
        public void OnTransitionFromCamera(){} // RVA: 0x7A9AE49E0
        public void RequiresUserInput(){} // RVA: 0x7A81BD750
        public void GetYAxisClosestValue(){} // RVA: 0x7A9AE4F00
        public void SteepestDescent(){} // RVA: 0x7A9AE5670
        public void InvalidateRigCache(){} // RVA: 0x7A9AE3770
        public void DestroyRigs(){} // RVA: 0x7A9AE58C0
        public void CreateRigs(){} // RVA: 0x7A9AE6020
        public void UpdateRigCache(){} // RVA: 0x7A9AE6C30
        public void LocateExistingRigs(){} // RVA: 0x7A9AE71E0
        public void UpdateXAxisHeading(){} // RVA: 0x7A9AE78C0
        public void PushSettingsToRigs(){} // RVA: 0x7A9AE7B50
        public void GetYAxisValue(){} // RVA: 0x7A9AE82C0
        public void CalculateNewState(){} // RVA: 0x7A9AE82F0
        public void GetLocalPositionForCameraFromInput(){} // RVA: 0x7A9AE85A0
        public void UpdateCachedSpline(){} // RVA: 0x7A9AE8890
        public void OnBeforeSerialize(){} // RVA: 0x7A9AE8F20
        public void .ctor(){} // RVA: 0x7A9AE9000
        public void <SteepestDescent>g__AngleFunction|47_0(){} // RVA: 0x7A9AE96D0
        public void <SteepestDescent>g__SlopeOfAngleFunction|47_1(){} // RVA: 0x7A9AE97A0
        public void <SteepestDescent>g__InitialGuess|47_2(){} // RVA: 0x7A9AE9810
        public void <SteepestDescent>g__ChooseBestAngle|47_3(){} // RVA: 0x7A9AE9920
    }

    public class CinemachineGroupComposer : CinemachineComposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9B05E80
        public void get_LastBounds(){} // RVA: 0x7A9B05F50
        public void set_LastBounds(){} // RVA: 0x7A9B05F70
        public void get_LastBoundsMatrix(){} // RVA: 0x7A9B05F90
        public void set_LastBoundsMatrix(){} // RVA: 0x7A9B05FC0
        public void GetMaxDampTime(){} // RVA: 0x7A9B05FF0
        public void MutateCameraState(){} // RVA: 0x7A9B06010
        public void GetTargetHeight(){} // RVA: 0x7A9B07170
        public void GetScreenSpaceGroupBoundingBox(){} // RVA: 0x7A9B073B0
        public void .ctor(){} // RVA: 0x7A9B07930
    }

    public class CinemachineHardLockToTarget : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9B079B0
        public void get_Stage(){} // RVA: 0x7A82D1450
        public void GetMaxDampTime(){} // RVA: 0x7A81B7060
        public void MutateCameraState(){} // RVA: 0x7A9B07AE0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachineHardLookAt : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9B07CB0
        public void get_Stage(){} // RVA: 0x7A81CA9D0
        public void MutateCameraState(){} // RVA: 0x7A9B07DE0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CinemachineImpulseDefinition : Object
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9B32FD0
        public void CreateStandardShapes(){} // RVA: 0x7A9B330C0
        public void GetStandardCurve(){} // RVA: 0x7A9B33CA0
        public void get_ImpulseCurve(){} // RVA: 0x7A9B33D20
        public void CreateEvent(){} // RVA: 0x7A9B33E30
        public void CreateAndReturnEvent(){} // RVA: 0x7A9B33E70
        public void LegacyCreateAndReturnEvent(){} // RVA: 0x7A9B340D0
        public void .ctor(){} // RVA: 0x7A9B344C0
        // ── Unresolved (hash) ──
        public void m_ImpulseChannel(){} // RVA: 0x7B3FA7CD8
    }

    public class CinemachineImpulseDefinitionPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CinemachineImpulseEnvelopePropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CinemachineImpulseListener : CinemachineExtension
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A9B34ED0
        public void PostPipelineStageCallback(){} // RVA: 0x7A9B34F90
        public void .ctor(){} // RVA: 0x7A9B35570
    }

    public class CinemachineImpulseManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Instance(){} // RVA: 0x7A9B35C80
        public void InitializeModule(){} // RVA: 0x7A9B35D40
        public void EvaluateDissipationScale(){} // RVA: 0x7A9B35E90
        public void GetImpulseAt(){} // RVA: 0x7A9B35F90
        public void get_CurrentTime(){} // RVA: 0x7A9B364B0
        public void NewImpulseEvent(){} // RVA: 0x7A9B36550
        public void AddImpulseEvent(){} // RVA: 0x7A9B36650
        public void Clear(){} // RVA: 0x7A9B36750
        public void sInstance(){} // RVA: 0x7B3F87F28
    }

    public class CinemachineImpulseSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9B375F0
        public void Reset(){} // RVA: 0x7A9B37700
        public void GenerateImpulseAtPositionWithVelocity(){} // RVA: 0x7A9B378F0
        public void GenerateImpulseWithVelocity(){} // RVA: 0x7A9B37940
        public void GenerateImpulseWithForce(){} // RVA: 0x7A9B37A60
        public void GenerateImpulse(){} // RVA: 0x7A9B37A60
        public void GenerateImpulseAt(){} // RVA: 0x7A9B378F0
        public void .ctor(){} // RVA: 0x7A9B37C00
    }

    public class CinemachineIndependentImpulseListener : MonoBehaviour
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A9B37D20
        public void OnEnable(){} // RVA: 0x7A9B37DD0
        public void Update(){} // RVA: 0x7A9B37E60
        public void LateUpdate(){} // RVA: 0x7A9B382C0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachineInputAxisDriver : ValueType
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7A7672BF0
        public void Update(){} // RVA: 0x7A7673C70
        public void ClampValue(){} // RVA: 0x7A7673CF0
        public void multiplier(){} // RVA: 0x7B3F8D6A8
    }

    public class CinemachineInputProvider : MonoBehaviour
    {
        // ── Methods ──
        public void GetAxisValue(){} // RVA: 0x7A9B2EF60
        public void ResolveForPlayer(){} // RVA: 0x7A9B2F0A0
        public void OnDisable(){} // RVA: 0x7A8EC2FD0
        public void .ctor(){} // RVA: 0x7A9B2F9A0
        public void <ResolveForPlayer>g__GetFirstMatch|7_0(){} // RVA: 0x7A9B2F9F0
    }

    public class CinemachineMixingCamera : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void GetWeight(){} // RVA: 0x7A9AE9DE0
        public void SetWeight(){} // RVA: 0x7A9AEA120
        public void get_LiveChild(){} // RVA: 0x7A8B69B70
        public void set_LiveChild(){} // RVA: 0x7A8B4DC50
        public void get_State(){} // RVA: 0x7A9AEA3F0
        public void get_LookAt(){} // RVA: 0x7A8B772D0
        public void set_LookAt(){} // RVA: 0x7A8B58850
        public void get_Follow(){} // RVA: 0x7A8815B70
        public void set_Follow(){} // RVA: 0x7A8B58420
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AEA490
        public void ForceCameraPosition(){} // RVA: 0x7A9AEA570
        public void OnEnable(){} // RVA: 0x7A9AEA670
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9AEA690
        public void OnValidate(){} // RVA: 0x7A9AEA6A0
        public void IsLiveChild(){} // RVA: 0x7A9AEA750
        public void get_ChildCameras(){} // RVA: 0x7A9AEA810
        public void InvalidateListOfChildren(){} // RVA: 0x7A9AEA830
        public void ValidateListOfChildren(){} // RVA: 0x7A9AEA950
        public void OnTransitionFromCamera(){} // RVA: 0x7A9AEAE00
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AEAF60
        public void .ctor(){} // RVA: 0x7A9AEB660
    }

    public class CinemachineOrbitalTransposer : CinemachineTransposer
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9B081A0
        public void UpdateHeading(){} // RVA: 0x7A9B083D0
        public void OnEnable(){} // RVA: 0x7A9B08570
        public void UpdateInputAxisProvider(){} // RVA: 0x7A9B08790
        public void OnTargetObjectWarped(){} // RVA: 0x7A9B08900
        public void ForceCameraPosition(){} // RVA: 0x7A9B08C00
        public void OnTransitionFromCamera(){} // RVA: 0x7A9B08D60
        public void GetAxisClosestValue(){} // RVA: 0x7A9B08FA0
        public void MutateCameraState(){} // RVA: 0x7A9B09700
        public void GetTargetCameraPosition(){} // RVA: 0x7A9B0A690
        public void get_RequiresUserInput(){} // RVA: 0x7A81BD750
        public void GetTargetHeading(){} // RVA: 0x7A9B0AAF0
        public void .ctor(){} // RVA: 0x7A9B0B460
    }

    public class CinemachineOrbitalTransposer[] : Array
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

    public class CinemachinePOV : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A813E380
        public void get_Stage(){} // RVA: 0x7A81CA9D0
        public void OnValidate(){} // RVA: 0x7A9B0BC20
        public void OnEnable(){} // RVA: 0x7A9B0BD30
        public void UpdateInputAxisProvider(){} // RVA: 0x7A9B0BD40
        public void PrePipelineMutateCameraState(){} // RVA: 0x7A80D7310
        public void MutateCameraState(){} // RVA: 0x7A9B0C010
        public void GetRecenterTarget(){} // RVA: 0x7A9B0C7C0
        public void NormalizeAngle(){} // RVA: 0x7A9B0CC70
        public void ForceCameraPosition(){} // RVA: 0x7A9B0CCA0
        public void OnTransitionFromCamera(){} // RVA: 0x7A9B0CCC0
        public void get_RequiresUserInput(){} // RVA: 0x7A81BD750
        public void SetAxesForRotation(){} // RVA: 0x7A9B0CF30
        public void .ctor(){} // RVA: 0x7A9B0DA00
    }

    public class CinemachinePath : CinemachinePathBase
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7A889BC60
        public void get_MaxPos(){} // RVA: 0x7A9AEB880
        public void get_Looped(){} // RVA: 0x7A8192400
        public void Reset(){} // RVA: 0x7A9AEB8C0
        public void OnValidate(){} // RVA: 0x7A9AEBA80
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7A851DB90
        public void GetBoundingIndices(){} // RVA: 0x7A9AEBAA0
        public void EvaluateLocalPosition(){} // RVA: 0x7A9AEBB90
        public void EvaluateLocalTangent(){} // RVA: 0x7A9AEBEB0
        public void EvaluateLocalOrientation(){} // RVA: 0x7A9AEC110
        public void GetRoll(){} // RVA: 0x7A9AEC520
        public void RollAroundForward(){} // RVA: 0x7A9AEC650
        public void .ctor(){} // RVA: 0x7A9AEC6A0
    }

    public class CinemachinePathBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7A7E155B0
        public void get_MaxPos(){} // RVA: 0x7A7E155B0
        public void get_Looped(){} // RVA: 0x7A7E01900
        public void StandardizePos(){} // RVA: 0x7A9B20D10
        public void EvaluatePosition(){} // RVA: 0x7A9B20E00
        public void EvaluateTangent(){} // RVA: 0x7A9B20F20
        public void EvaluateOrientation(){} // RVA: 0x7A9B21040
        public void EvaluateLocalPosition(){} // RVA: 0x7A7E008E0
        public void EvaluateLocalTangent(){} // RVA: 0x7A7E008E0
        public void EvaluateLocalOrientation(){} // RVA: 0x7A7E008E0
        public void FindClosestPoint(){} // RVA: 0x7A9B212B0
        public void MinUnit(){} // RVA: 0x7A9B21700
        public void MaxUnit(){} // RVA: 0x7A9B21730
        public void StandardizeUnit(){} // RVA: 0x7A9B21760
        public void EvaluatePositionAtUnit(){} // RVA: 0x7A9B21810
        public void EvaluateTangentAtUnit(){} // RVA: 0x7A9B21870
        public void EvaluateOrientationAtUnit(){} // RVA: 0x7A9B218D0
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7A7E00710
        public void InvalidateDistanceCache(){} // RVA: 0x7A9B21930
        public void DistanceCacheIsValid(){} // RVA: 0x7A9B219E0
        public void get_PathLength(){} // RVA: 0x7A9B21A80
        public void StandardizePathDistance(){} // RVA: 0x7A9B21AF0
        public void ToNativePathUnits(){} // RVA: 0x7A9B21BB0
        public void FromPathNativeUnits(){} // RVA: 0x7A9B21D30
        public void ResamplePath(){} // RVA: 0x7A9B21E50
        public void .ctor(){} // RVA: 0x7A9B22340
    }

    public class CinemachinePipeline : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachinePixelPerfect : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class CinemachineSameAsFollowTarget : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9B0DD60
        public void get_Stage(){} // RVA: 0x7A81CA9D0
        public void GetMaxDampTime(){} // RVA: 0x7A81B7060
        public void MutateCameraState(){} // RVA: 0x7A9B0DE90
        public void .ctor(){} // RVA: 0x7A9B0E1C0
    }

    public class CinemachineSmoothPath : CinemachinePathBase
    {
        // ── Methods ──
        public void get_MinPos(){} // RVA: 0x7A889BC60
        public void get_MaxPos(){} // RVA: 0x7A9AEB880
        public void get_Looped(){} // RVA: 0x7A8192400
        public void get_DistanceCacheSampleStepsPerSegment(){} // RVA: 0x7A851DB90
        public void OnValidate(){} // RVA: 0x7A9AEBA80
        public void Reset(){} // RVA: 0x7A9AEC840
        public void InvalidateDistanceCache(){} // RVA: 0x7A9AEC9F0
        public void UpdateControlPoints(){} // RVA: 0x7A9AECB40
        public void GetBoundingIndices(){} // RVA: 0x7A9AECED0
        public void EvaluateLocalPosition(){} // RVA: 0x7A9AECFB0
        public void EvaluateLocalTangent(){} // RVA: 0x7A9AED330
        public void EvaluateLocalOrientation(){} // RVA: 0x7A9AED600
        public void RollAroundForward(){} // RVA: 0x7A9AEC650
        public void .ctor(){} // RVA: 0x7A9AEDAF0
    }

    public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7A9AEDC20
        public void get_LiveChild(){} // RVA: 0x7A8592710
        public void set_LiveChild(){} // RVA: 0x7A84442D0
        public void IsLiveChild(){} // RVA: 0x7A9AEDD60
        public void get_State(){} // RVA: 0x7A9AEDD90
        public void get_LookAt(){} // RVA: 0x7A9ACC670
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A9ACC680
        public void set_Follow(){} // RVA: 0x7A8142620
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AEDE30
        public void ForceCameraPosition(){} // RVA: 0x7A9AEDF10
        public void OnTransitionFromCamera(){} // RVA: 0x7A9AEE010
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AEE120
        public void OnEnable(){} // RVA: 0x7A9AEEA10
        public void OnDisable(){} // RVA: 0x7A9AEED30
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9AEEEB0
        public void OnGuiHandler(){} // RVA: 0x7A9AEEEC0
        public void get_ChildCameras(){} // RVA: 0x7A9AEF030
        public void get_IsBlending(){} // RVA: 0x7A9AEF050
        public void get_ActiveBlend(){} // RVA: 0x7A8B54430
        public void CreateFakeHash(){} // RVA: 0x7A9AEF060
        public void LookupFakeHash(){} // RVA: 0x7A9AEF120
        public void InvalidateListOfChildren(){} // RVA: 0x7A9AEF4D0
        public void UpdateListOfChildren(){} // RVA: 0x7A9AEF590
        public void ValidateInstructions(){} // RVA: 0x7A9AEF940
        public void ChooseCurrentCamera(){} // RVA: 0x7A9AEFF90
        public void GetClipHash(){} // RVA: 0x7A9AF0820
        public void LookupBlend(){} // RVA: 0x7A9AF09B0
        public void .ctor(){} // RVA: 0x7A9AF0C20
    }

    public class CinemachineStoryboard : CinemachineExtension
    {
        // ── Methods ──
        public void PostPipelineStageCallback(){} // RVA: 0x7A9AF0F60
        public void UpdateRenderCanvas(){} // RVA: 0x7A9AF1180
        public void ConnectToVcam(){} // RVA: 0x7A9AF13E0
        public void get_CanvasName(){} // RVA: 0x7A9AF15B0
        public void CameraUpdatedCallback(){} // RVA: 0x7A9AF16E0
        public void LocateMyCanvas(){} // RVA: 0x7A9AF1A80
        public void CreateCanvas(){} // RVA: 0x7A9AF23A0
        public void DestroyCanvas(){} // RVA: 0x7A9AF2ED0
        public void PlaceImage(){} // RVA: 0x7A9AF3250
        public void StaticBlendingHandler(){} // RVA: 0x7A9AF3E80
        public void InitializeModule(){} // RVA: 0x7A9AF4270
        public void .ctor(){} // RVA: 0x7A9AF43E0
    }

    public class CinemachineTargetGroup : MonoBehaviour
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9AF45B0
        public void Reset(){} // RVA: 0x7A9AF4640
        public void get_Transform(){} // RVA: 0x7A864E8E0
        public void get_BoundingBox(){} // RVA: 0x7A9AF46D0
        public void set_BoundingBox(){} // RVA: 0x7A9AF4760
        public void get_Sphere(){} // RVA: 0x7A9AF4780
        public void set_Sphere(){} // RVA: 0x7A81E8E10
        public void get_IsEmpty(){} // RVA: 0x7A9AF4800
        public void AddMember(){} // RVA: 0x7A9AF48A0
        public void RemoveMember(){} // RVA: 0x7A9AF4B90
        public void FindMember(){} // RVA: 0x7A9AF4D60
        public void GetWeightedBoundsForMember(){} // RVA: 0x7A9AF4F00
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7A9AF50E0
        public void get_CachedCountIsValid(){} // RVA: 0x7A9AF58B0
        public void IndexIsValid(){} // RVA: 0x7A9AF5920
        public void WeightedMemberBoundsForValidMember(){} // RVA: 0x7A9AF5940
        public void DoUpdate(){} // RVA: 0x7A9AF5B00
        public void UpdateMemberValidity(){} // RVA: 0x7A9AF5E50
        public void CalculateAveragePosition(){} // RVA: 0x7A9AF61D0
        public void CalculateBoundingBox(){} // RVA: 0x7A9AF6490
        public void CalculateBoundingSphere(){} // RVA: 0x7A9AF6A30
        public void CalculateAverageOrientation(){} // RVA: 0x7A9AF6E60
        public void FixedUpdate(){} // RVA: 0x7A9AF7660
        public void Update(){} // RVA: 0x7A9AF7670
        public void LateUpdate(){} // RVA: 0x7A9AF7710
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7A9AF7720
        public void .ctor(){} // RVA: 0x7A9AF84B0
    }

    public class CinemachineTrackedDolly : CinemachineComponentBase
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A9B0E240
        public void get_Stage(){} // RVA: 0x7A82D1450
        public void GetMaxDampTime(){} // RVA: 0x7A9B0E360
        public void MutateCameraState(){} // RVA: 0x7A9B0E410
        public void GetCameraOrientationAtPathPoint(){} // RVA: 0x7A9B0F660
        public void get_AngularDamping(){} // RVA: 0x7A9B0FD40
        public void .ctor(){} // RVA: 0x7A9B0FDF0
    }

    public class CinemachineTransposer : CinemachineComponentBase
    {
        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7A9B0FF50
        public void get_HideOffsetInInspector(){} // RVA: 0x7A8359360
        public void set_HideOffsetInInspector(){} // RVA: 0x7A8A21900
        public void get_EffectiveOffset(){} // RVA: 0x7A9B0FFA0
        public void get_IsValid(){} // RVA: 0x7A9B0FFE0
        public void get_Stage(){} // RVA: 0x7A82D1450
        public void GetMaxDampTime(){} // RVA: 0x7A9B10110
        public void MutateCameraState(){} // RVA: 0x7A9B101A0
        public void OnTargetObjectWarped(){} // RVA: 0x7A9B10860
        public void ForceCameraPosition(){} // RVA: 0x7A9B109D0
        public void InitPrevFrameStateInfo(){} // RVA: 0x7A9B10D20
        public void TrackTarget(){} // RVA: 0x7A9B10F80
        public void GetOffsetForMinimumTargetDistance(){} // RVA: 0x7A9B120A0
        public void get_Damping(){} // RVA: 0x7A9B12640
        public void get_AngularDamping(){} // RVA: 0x7A9B12680
        public void GetTargetCameraPosition(){} // RVA: 0x7A9B12760
        public void GetReferenceOrientation(){} // RVA: 0x7A9B12A60
        public void .ctor(){} // RVA: 0x7A9B130E0
    }

    public class CinemachineTriggerAction : MonoBehaviour
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7A9B2FE70
        public void InternalDoTriggerEnter(){} // RVA: 0x7A9B2FF90
        public void InternalDoTriggerExit(){} // RVA: 0x7A9B30120
        public void OnTriggerEnter(){} // RVA: 0x7A9B30200
        public void OnTriggerExit(){} // RVA: 0x7A9B30280
        public void OnCollisionEnter(){} // RVA: 0x7A9B30300
        public void OnCollisionExit(){} // RVA: 0x7A9B30340
        public void OnTriggerEnter2D(){} // RVA: 0x7A9B30200
        public void OnTriggerExit2D(){} // RVA: 0x7A9B30280
        public void OnCollisionEnter2D(){} // RVA: 0x7A9B30380
        public void OnCollisionExit2D(){} // RVA: 0x7A9B303C0
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A9B30400
    }

    public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A9AEDD90
        public void get_LookAt(){} // RVA: 0x7A9ACC670
        public void set_LookAt(){} // RVA: 0x7A8881790
        public void get_Follow(){} // RVA: 0x7A9ACC680
        public void set_Follow(){} // RVA: 0x7A8142620
        public void GetMaxDampTime(){} // RVA: 0x7A9AF86B0
        public void InternalUpdateCameraState(){} // RVA: 0x7A9AF8840
        public void OnEnable(){} // RVA: 0x7A9AF8D20
        public void OnDestroy(){} // RVA: 0x7A9AF93C0
        public void OnValidate(){} // RVA: 0x7A9AF9740
        public void OnTransformChildrenChanged(){} // RVA: 0x7A9AF9810
        public void Reset(){} // RVA: 0x7A9AF9870
        public void DestroyPipeline(){} // RVA: 0x7A9AF9890
        public void CreatePipeline(){} // RVA: 0x7A9AF9FB0
        public void InvalidateComponentPipeline(){} // RVA: 0x7A9AF9810
        public void GetComponentOwner(){} // RVA: 0x7A9AFA320
        public void GetComponentPipeline(){} // RVA: 0x7A9AFA340
        public void GetCinemachineComponent(){} // RVA: 0x7A8051B10
        public void AddCinemachineComponent(){} // RVA: 0x7A8051B10
        public void DestroyCinemachineComponent(){} // RVA: 0x7A7E18770
        public void UpdateComponentPipeline(){} // RVA: 0x7A9AFA410
        public void SetFlagsForHiddenChild(){} // RVA: 0x7A9AFAC60
        public void CalculateNewState(){} // RVA: 0x7A9AFAE10
        public void OnTargetObjectWarped(){} // RVA: 0x7A9AFB8E0
        public void ForceCameraPosition(){} // RVA: 0x7A9AFBC90
        public void SetStateRawPosition(){} // RVA: 0x7A9AFBE60
        public void OnTransitionFromCamera(){} // RVA: 0x7A9AFBE80
        public void RequiresUserInput(){} // RVA: 0x7A9AFC3A0
        public void OnBeforeSerialize(){} // RVA: 0x7A9AFC660
        public void .ctor(){} // RVA: 0x7A9AFC740
    }

    public class CinemachineVirtualCameraBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_ValidatingStreamVersion(){} // RVA: 0x7A9B22450
        public void set_ValidatingStreamVersion(){} // RVA: 0x7A8133110
        public void GetMaxDampTime(){} // RVA: 0x7A9B224C0
        public void DetachedFollowTargetDamp(){} // RVA: 0x7A9B227D0
        public void DetachedLookAtTargetDamp(){} // RVA: 0x7A9B22AA0
        public void AddExtension(){} // RVA: 0x7A9B22B50
        public void RemoveExtension(){} // RVA: 0x7A9B22CB0
        public void get_mExtensions(){} // RVA: 0x7A8178B90
        public void set_mExtensions(){} // RVA: 0x7A8230620
        public void InvokePostPipelineStageCallback(){} // RVA: 0x7A9B22D10
        public void InvokePrePipelineMutateCameraStateCallback(){} // RVA: 0x7A9B23020
        public void InvokeOnTransitionInExtensions(){} // RVA: 0x7A9B23320
        public void get_Name(){} // RVA: 0x7A8357950
        public void get_Description(){} // RVA: 0x7A9B23550
        public void get_Priority(){} // RVA: 0x7A864E8D0
        public void set_Priority(){} // RVA: 0x7A9ABBD00
        public void ApplyPositionBlendMethod(){} // RVA: 0x7A9B23590
        public void get_VirtualCameraGameObject(){} // RVA: 0x7A9B235C0
        public void get_IsValid(){} // RVA: 0x7A9B236D0
        public void get_State(){} // RVA: 0x7A7E00490
        public void get_ParentCamera(){} // RVA: 0x7A9B237A0
        public void IsLiveChild(){} // RVA: 0x7A80D7320
        public void get_LookAt(){} // RVA: 0x7A7E00680
        public void set_LookAt(){} // RVA: 0x7A7E18800
        public void get_Follow(){} // RVA: 0x7A7E00680
        public void set_Follow(){} // RVA: 0x7A7E18800
        public void get_PreviousStateIsValid(){} // RVA: 0x7A8359360
        public void set_PreviousStateIsValid(){} // RVA: 0x7A8A21900
        public void UpdateCameraState(){} // RVA: 0x7A9B23840
        public void InternalUpdateCameraState(){} // RVA: 0x7A7E1DD40
        public void OnTransitionFromCamera(){} // RVA: 0x7A9B238E0
        public void OnDestroy(){} // RVA: 0x7A9B239B0
        public void OnTransformParentChanged(){} // RVA: 0x7A9B23AE0
        public void Start(){} // RVA: 0x7A828BB70
        public void RequiresUserInput(){} // RVA: 0x7A9B23B80
        public void EnsureStarted(){} // RVA: 0x7A9B23D00
        public void GetInputAxisProvider(){} // RVA: 0x7A9B23DD0
        public void OnValidate(){} // RVA: 0x7A9B23EA0
        public void OnEnable(){} // RVA: 0x7A9B23F10
        public void OnDisable(){} // RVA: 0x7A9B24290
        public void Update(){} // RVA: 0x7A9B24300
        public void UpdateSlaveStatus(){} // RVA: 0x7A9B24310
        public void ResolveLookAt(){} // RVA: 0x7A9B244F0
        public void ResolveFollow(){} // RVA: 0x7A9B24610
        public void UpdateVcamPoolStatus(){} // RVA: 0x7A9B24730
        public void MoveToTopOfPrioritySubqueue(){} // RVA: 0x7A9B24960
        public void OnTargetObjectWarped(){} // RVA: 0x7A9B24970
        public void ForceCameraPosition(){} // RVA: 0x7A9B24A80
        public void GetInheritPosition(){} // RVA: 0x7A9B24BA0
        public void CreateBlend(){} // RVA: 0x7A9B24CE0
        public void PullStateFromVirtualCamera(){} // RVA: 0x7A9B25160
        public void InvalidateCachedTargets(){} // RVA: 0x7A9B25490
        public void get_FollowTargetChanged(){} // RVA: 0x7A9905F60
        public void set_FollowTargetChanged(){} // RVA: 0x7A8935600
        public void get_LookAtTargetChanged(){} // RVA: 0x7A9B256A0
        public void set_LookAtTargetChanged(){} // RVA: 0x7A9B256B0
        public void UpdateTargetCache(){} // RVA: 0x7A9B256C0
        public void get_AbstractFollowTargetGroup(){} // RVA: 0x7A825E100
        public void get_FollowTargetAsVcam(){} // RVA: 0x7A82C2060
        public void get_AbstractLookAtTargetGroup(){} // RVA: 0x7A87D9C10
        public void get_LookAtTargetAsVcam(){} // RVA: 0x7A8555100
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A9B25D10
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A9B25D30
        public void LegacyUpgrade(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void CancelDamping(){} // RVA: 0x7A9B25DE0
        public void .ctor(){} // RVA: 0x7A9B26040
    }

    public class CinemachineVirtualCameraBase[] : Array
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

    public class CinemachineVirtualCamera[] : Array
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

    public class ConfinerOven : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B262E0
        public void GetBakedSolution(){} // RVA: 0x7A9B26410
        public void get_State(){} // RVA: 0x7A87A7DA0
        public void set_State(){} // RVA: 0x7A87A7CF0
        public void Initialize(){} // RVA: 0x7A9B26870
        public void BakeConfiner(){} // RVA: 0x7A9B270C0
        public void <Initialize>g__GetPolygonBoundingBox|24_0(){} // RVA: 0x7A9B27710
        public void <Initialize>g__MidPointOfIntRect|24_1(){} // RVA: 0x7A9B278D0
        public void <BakeConfiner>g__ComputeSkeleton|25_0(){} // RVA: 0x7A9B27900
        // ── Unresolved (hash) ──
        public void m_MinFrustumHeightWithBones(){} // RVA: 0x7B40D0D48
    }

    public class DocumentationSortingAttribute : Attribute
    {
        // ── Methods ──
        public void get_Category(){} // RVA: 0x7A8124910
        public void set_Category(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class GroupWeightManipulator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A9B31310
        public void OnValidate(){} // RVA: 0x7A9B313A0
        public void Update(){} // RVA: 0x7A9B31410
        public void UpdateWeights(){} // RVA: 0x7A9B315E0
        public void .ctor(){} // RVA: 0x7A9B316D0
    }

    public class ICameraOverrideStack
    {
        // ── Methods ──
        public void SetCameraOverride(){} // RVA: 0x7A7E08730
        public void ReleaseCameraOverride(){} // RVA: 0x7A7E189D0
        public void get_DefaultWorldUp(){} // RVA: 0x7A7E00490
    }

    public class ICinemachineCamera
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_Description(){} // RVA: 0x7A7E00680
        public void get_Priority(){} // RVA: 0x7A7E00710
        public void set_Priority(){} // RVA: 0x7A7E189D0
        public void get_LookAt(){} // RVA: 0x7A7E00680
        public void set_LookAt(){} // RVA: 0x7A7E18800
        public void get_Follow(){} // RVA: 0x7A7E00680
        public void set_Follow(){} // RVA: 0x7A7E18800
        public void get_State(){} // RVA: 0x7A7E00490
        public void get_VirtualCameraGameObject(){} // RVA: 0x7A7E00680
        public void get_IsValid(){} // RVA: 0x7A7E01900
        public void get_ParentCamera(){} // RVA: 0x7A7E00680
        public void IsLiveChild(){} // RVA: 0x7A7E03AD0
        public void UpdateCameraState(){} // RVA: 0x7A7E1DD40
        public void InternalUpdateCameraState(){} // RVA: 0x7A7E1DD40
        public void OnTransitionFromCamera(){} // RVA: 0x7A7E199F0
        public void OnTargetObjectWarped(){} // RVA: 0x7A7E18890
    }

    public class ICinemachineTargetGroup
    {
        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7A7E00680
        public void get_BoundingBox(){} // RVA: 0x7A7E00490
        public void get_Sphere(){} // RVA: 0x7A7E00490
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void GetViewSpaceBoundingBox(){} // RVA: 0x7A7E00560
        public void GetViewSpaceAngularBounds(){} // RVA: 0x7A7E1DB70
    }

    public class ISignalSource6D
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7A7E155B0
        public void GetSignal(){} // RVA: 0x7A7E26590
    }

    public class LensSettings : ValueType
    {
        // ── Methods ──
        public void get_Orthographic(){} // RVA: 0x7A7673EE0
        public void set_Orthographic(){} // RVA: 0x7A7673F00
        public void get_SensorSize(){} // RVA: 0x7A7673F10
        public void set_SensorSize(){} // RVA: 0x7A7673F30
        public void get_Aspect(){} // RVA: 0x7A7673F40
        public void get_IsPhysicalCamera(){} // RVA: 0x7A7673F50
        public void set_IsPhysicalCamera(){} // RVA: 0x7A7673F70
        public void FromCamera(){} // RVA: 0x7A9B28FB0
        public void SnapshotCameraReadOnlyProperties(){} // RVA: 0x7A7673F90
        public void .ctor(){} // RVA: 0x7A76740A0
        public void Lerp(){} // RVA: 0x7A9B298B0
        public void Validate(){} // RVA: 0x7A76740F0
        public void .cctor(){} // RVA: 0x7A9B29B90
    }

    public class LensSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NoSaveDuringPlayAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NoiseSettings : SignalSourceAsset
    {
        // ── Methods ──
        public void GetCombinedFilterResults(){} // RVA: 0x7A9B29C20
        public void get_SignalDuration(){} // RVA: 0x7A889BC60
        public void GetSignal(){} // RVA: 0x7A9B29DA0
        public void .ctor(){} // RVA: 0x7A9B29F50
    }

    public class NoiseSettingsPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NotNullAttribute : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B1B150
        public void SetState(){} // RVA: 0x7A9B1B250
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_Description(){} // RVA: 0x7A9B1B300
        public void get_Priority(){} // RVA: 0x7A83782A0
        public void set_Priority(){} // RVA: 0x7A84385B0
        public void get_LookAt(){} // RVA: 0x7A81052C0
        public void set_LookAt(){} // RVA: 0x7A81052D0
        public void get_Follow(){} // RVA: 0x7A8105330
        public void set_Follow(){} // RVA: 0x7A80D8E80
        public void get_State(){} // RVA: 0x7A9B1B340
        public void set_State(){} // RVA: 0x7A9B1B3E0
        public void get_VirtualCameraGameObject(){} // RVA: 0x7A82D1450
        public void get_IsValid(){} // RVA: 0x7A81BD750
        public void get_ParentCamera(){} // RVA: 0x7A82D1450
        public void IsLiveChild(){} // RVA: 0x7A80D7320
        public void UpdateCameraState(){} // RVA: 0x7A80D7310
        public void InternalUpdateCameraState(){} // RVA: 0x7A80D7310
        public void OnTransitionFromCamera(){} // RVA: 0x7A80D7310
        public void OnTargetObjectWarped(){} // RVA: 0x7A80D7310
    }

    public class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RuntimeUtility : Object
    {
        // ── Methods ──
        public void DestroyObject(){} // RVA: 0x7A9B2A190
        public void IsPrefab(){} // RVA: 0x7A80D7320
        public void RaycastIgnoreTag(){} // RVA: 0x7A9B2A280
        public void SphereCastIgnoreTag(){} // RVA: 0x7A9B2A680
        public void GetScratchCollider(){} // RVA: 0x7A9B2B240
        public void DestroyScratchCollider(){} // RVA: 0x7A9B2B7E0
        public void NormalizeCurve(){} // RVA: 0x7A9B2BAD0
        public void .cctor(){} // RVA: 0x7A9B2BD00
    }

    public class SaveDuringPlayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SignalSourceAsset : ScriptableObject
    {
        // ── Methods ──
        public void get_SignalDuration(){} // RVA: 0x7A7E155B0
        public void GetSignal(){} // RVA: 0x7A7E26590
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class TagFieldAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TargetPositionCache : Object
    {
        // ── Methods ──
        public void get_CacheMode(){} // RVA: 0x7A9B2BE50
        public void set_CacheMode(){} // RVA: 0x7A9B2BE90
        public void get_IsRecording(){} // RVA: 0x7A9B2BF00
        public void get_CurrentPlaybackTimeValid(){} // RVA: 0x7A9B2BF50
        public void get_IsEmpty(){} // RVA: 0x7A9B2BFE0
        public void get_CacheTimeRange(){} // RVA: 0x7A9B2C030
        public void get_HasCurrentTime(){} // RVA: 0x7A9B2C080
        public void ClearCache(){} // RVA: 0x7A9B2C0E0
        public void CreatePlaybackCurves(){} // RVA: 0x7A9B2C250
        public void GetTargetPosition(){} // RVA: 0x7A9B2C4B0
        public void GetTargetRotation(){} // RVA: 0x7A9B2C970
        public void .ctor(){} // RVA: 0x7A80D7310
        public void UseCache(){} // RVA: 0x7B41F0F98
    }

    public class UpdateTracker : Object
    {
        // ── Methods ──
        public void InitializeModule(){} // RVA: 0x7A9B2E1A0
        public void UpdateTargets(){} // RVA: 0x7A9B2E220
        public void GetPreferredUpdate(){} // RVA: 0x7A9B2E760
        public void OnUpdate(){} // RVA: 0x7A9B2EAD0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9B2EB90
        public void mUpdateStatus(){} // RVA: 0x7B41F0F98
    }

    public class VcamTargetPropertyAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}