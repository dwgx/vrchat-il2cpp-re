// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 1018

public class OVRBoneCapsule : Object
{
    // ── Methods ──
    public void get_BoneIndex(){} // RVA: 0x24EA1D0
    public void set_BoneIndex(){} // RVA: 0x24EAB10
    public void get_CapsuleRigidbody(){} // RVA: 0xB465B0
    public void set_CapsuleRigidbody(){} // RVA: 0xBA9BA0
    public void get_CapsuleCollider(){} // RVA: 0xB700F0
    public void set_CapsuleCollider(){} // RVA: 0xB70100
    public void .ctor(){} // RVA: 0x6C36960
}

public class OVRBoneCapsule[] : Array
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

public class OVRBone[] : Array
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

public class OVRBoundary : Object
{
    // ── Methods ──
    public void GetConfigured(){} // RVA: 0x6B73510
    public void TestNode(){} // RVA: 0x6B73720
    public void TestPoint(){} // RVA: 0x6B73990
    public void GetGeometry(){} // RVA: 0x6B73AE0
    public void GetDimensions(){} // RVA: 0x6B73F30
    public void GetVisible(){} // RVA: 0x6B741E0
    public void SetVisible(){} // RVA: 0x6B743F0
    public void .ctor(){} // RVA: 0x6B74620
    public void .cctor(){} // RVA: 0x6B746E0
}

public class OVRCameraComposition : OVRComposition
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B68880
    public void Cleanup(){} // RVA: 0x6B695B0
    public void RecenterPose(){} // RVA: 0x64D9FC0
    public void RefreshCameraFramePlaneObject(){} // RVA: 0x6B69880
    public void UpdateCameraFramePlaneObject(){} // RVA: 0x6B69E90
    public void RefreshBoundaryMesh(){} // RVA: 0x6B6B1A0
}

public class OVRCameraFrameCompositionManager : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x6B6B440
    public void OnPreRender(){} // RVA: 0x6B6BAA0
    public void OnPostRender(){} // RVA: 0x6B6C1A0
    public void OnCameraBeginRendering(){} // RVA: 0x6B6C2B0
    public void OnCameraEndRendering(){} // RVA: 0x6B6C470
    public void .ctor(){} // RVA: 0xB43D60
}

public class OVRComposition : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B6C720
    public void CompositionMethod(){} // RVA: 0x87C130
    public void Update(){} // RVA: 0x899AC0
    public void Cleanup(){} // RVA: 0x894290
    public void RecenterPose(){} // RVA: 0xB43310
    public void RefreshCameraRig(){} // RVA: 0x6B6C730
    public void ComputeCameraWorldSpacePose(){} // RVA: 0x6B6CAD0
    public void ComputeCameraTrackingSpacePose(){} // RVA: 0x6B6CC10
}

public class OVRCompositionUtil : Object
{
    // ── Methods ──
    public void SafeDestroy(){} // RVA: 0x6B6D1E0
    public void ConvertCameraDevice(){} // RVA: 0x6B6D440
    public void ToBoundaryType(){} // RVA: 0x6B6D470
    public void GetWorldPosition(){} // RVA: 0x6B6D540
    public void GetMaximumBoundaryDistance(){} // RVA: 0x6B6D690
    public void BuildBoundaryMesh(){} // RVA: 0x6B6DA30
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRControllerBase : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9A4A0
    public void Update(){} // RVA: 0x6B9A780
    public void GetOpenVRControllerState(){} // RVA: 0x6B9ABE0
    public void SetControllerVibration(){} // RVA: 0x6B9B190
    public void SetControllerLocalizedVibration(){} // RVA: 0x6B9B2A0
    public void GetBatteryPercentRemaining(){} // RVA: 0xB43320
    public void ConfigureButtonMap(){} // RVA: 0x894290
    public void ConfigureTouchMap(){} // RVA: 0x894290
    public void ConfigureNearTouchMap(){} // RVA: 0x894290
    public void ConfigureAxis1DMap(){} // RVA: 0x894290
    public void ConfigureAxis2DMap(){} // RVA: 0x894290
    public void ResolveToRawMask(){} // RVA: 0x6B9B640
}

public class OVRControllerGamepadAndroid : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D3B0
    public void ConfigureButtonMap(){} // RVA: 0x6B9D3D0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9D660
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9D730
}

public class OVRControllerGamepadPC : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D3B0
    public void ConfigureButtonMap(){} // RVA: 0x6B9D3D0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9D660
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9D730
}

public class OVRControllerHands : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9C860
    public void ConfigureButtonMap(){} // RVA: 0x6B9C880
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9BE40
}

public class OVRControllerLHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9CCC0
    public void ConfigureButtonMap(){} // RVA: 0x6B9CCE0
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C350
}

public class OVRControllerLTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9BE60
    public void ConfigureButtonMap(){} // RVA: 0x6B9BE80
    public void ConfigureTouchMap(){} // RVA: 0x6B9C0D0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9C1B0
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9C210
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9C2F0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C350
}

public class OVRControllerRHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9CF00
    public void ConfigureButtonMap(){} // RVA: 0x6B9CF20
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C850
}

public class OVRControllerRTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9C360
    public void ConfigureButtonMap(){} // RVA: 0x6B9C380
    public void ConfigureTouchMap(){} // RVA: 0x6B9C5D0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9C6B0
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9C710
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9C7F0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9C850
}

public class OVRControllerRemote : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9D140
    public void ConfigureButtonMap(){} // RVA: 0x6B9D160
    public void ConfigureTouchMap(){} // RVA: 0x6B9CAA0
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9CB60
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9CBB0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9CC70
}

public class OVRControllerTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B9B900
    public void ConfigureButtonMap(){} // RVA: 0x6B9B920
    public void ConfigureTouchMap(){} // RVA: 0x6B9BB90
    public void ConfigureNearTouchMap(){} // RVA: 0x6B9BC80
    public void ConfigureAxis1DMap(){} // RVA: 0x6B9BCE0
    public void ConfigureAxis2DMap(){} // RVA: 0x6B9BDE0
    public void GetBatteryPercentRemaining(){} // RVA: 0x6B9BE40
}

public class OVRDirectComposition : OVRCameraComposition
{
    // ── Methods ──
    public void CompositionMethod(){} // RVA: 0xC3CCE0
    public void .ctor(){} // RVA: 0x6B6E060
    public void RefreshCameraObjects(){} // RVA: 0x6B6E0C0
    public void Update(){} // RVA: 0x6B6EAB0
    public void Cleanup(){} // RVA: 0x6B6F5B0
}

public class OVRDisplay : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B7E110
    public void Update(){} // RVA: 0x6B7E1C0
    public void add_RecenteredPose(){} // RVA: 0x6B7E520
    public void remove_RecenteredPose(){} // RVA: 0x6B7E610
    public void RecenterPose(){} // RVA: 0x6B7E700
    public void get_acceleration(){} // RVA: 0x6B7E830
    public void get_angularAcceleration(){} // RVA: 0x6B7E980
    public void get_velocity(){} // RVA: 0x6B7EAD0
    public void get_angularVelocity(){} // RVA: 0x6B7EC20
    public void GetEyeRenderDesc(){} // RVA: 0x6B7ED70
    public void get_latency(){} // RVA: 0x6B7EDC0
    public void get_appFramerate(){} // RVA: 0x6B7F240
    public void get_recommendedMSAALevel(){} // RVA: 0x6B7F2C0
    public void get_displayFrequenciesAvailable(){} // RVA: 0x6B7F4E0
    public void get_displayFrequency(){} // RVA: 0x6B7F530
    public void set_displayFrequency(){} // RVA: 0x6B7F580
    public void UpdateTextures(){} // RVA: 0x6B7F750
    public void ConfigureEyeDesc(){} // RVA: 0x6B7F780
}

public class OVRExtensions : Object
{
    // ── Methods ──
    public void ToTrackingSpacePose(){} // RVA: 0x6B794B0
    public void ToWorldSpacePose(){} // RVA: 0x6B79EE0
    public void ToHeadSpacePose(){} // RVA: 0x6B7A200
    public void ToOVRPose(){} // RVA: 0x6B7A860
    public void FromOVRPose(){} // RVA: 0x6B7A5C0
    public void ToFrustum(){} // RVA: 0x6B7A8D0
    public void FromColorf(){} // RVA: 0x2315EC0
    public void ToColorf(){} // RVA: 0x2315EC0
    public void FromVector3f(){} // RVA: 0x2331CF0
    public void FromFlippedXVector3f(){} // RVA: 0x6B7A910
    public void FromFlippedZVector3f(){} // RVA: 0x1924B40
    public void ToVector3f(){} // RVA: 0x2331CF0
    public void ToFlippedXVector3f(){} // RVA: 0x6B7A910
    public void ToFlippedZVector3f(){} // RVA: 0x1924B40
    public void FromVector4f(){} // RVA: 0x2315EC0
    public void ToVector4f(){} // RVA: 0x2315EC0
    public void FromQuatf(){} // RVA: 0x2315EC0
    public void FromFlippedXQuatf(){} // RVA: 0x6B7A930
    public void FromFlippedZQuatf(){} // RVA: 0x6B7A960
    public void ToQuatf(){} // RVA: 0x2315EC0
    public void ToFlippedXQuatf(){} // RVA: 0x6B7A930
    public void ToFlippedZQuatf(){} // RVA: 0x6B7A960
    public void ConvertToHMDMatrix34(){} // RVA: 0x6B7A990
    public void FindChildRecursive(){} // RVA: 0x6B7AA10
    public void Equals(){} // RVA: 0x6B7AC00
    public void CopyFrom(){} // RVA: 0x6B7AE50
    public void ToSpaceStorageLocation(){} // RVA: 0x6B7B080
}

public class OVRExternalComposition : OVRComposition
{
    // ── Methods ──
    public void CompositionMethod(){} // RVA: 0xDAC980
    public void .ctor(){} // RVA: 0x6B6F690
    public void RefreshCameraObjects(){} // RVA: 0x6B6F880
    public void Update(){} // RVA: 0x6B70CA0
    public void Cleanup(){} // RVA: 0x6B724F0
    public void CacheAudioData(){} // RVA: 0x6B72630
    public void GetAndResetAudioData(){} // RVA: 0x6B727E0
}

public class OVRGLTFAccessor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B829E0
    public void GetDataCount(){} // RVA: 0xB9E080
    public void ToOVRType(){} // RVA: 0x6B82E10
    public void ReadAsInt(){} // RVA: 0x6B83040
    public void ReadAsFloat(){} // RVA: 0x6B83290
    public void ReadAsVector2(){} // RVA: 0x6B834E0
    public void ReadAsVector3(){} // RVA: 0x6B837A0
    public void ReadAsVector4(){} // RVA: 0x6B83C40
    public void ReadAsColor(){} // RVA: 0x6B84190
    public void ReadAsMatrix4x4(){} // RVA: 0x6B847A0
    public void ReadAsKtxTexture(){} // RVA: 0x6B84C30
    public void ReadAsBoneWeights(){} // RVA: 0x6B84D70
    public void GetStrideForType(){} // RVA: 0x6B85240
    public void GetMaxValueForType(){} // RVA: 0x6B852A0
    public void ReadElementAsUint(){} // RVA: 0x6B85320
    public void ReadElementAsFloat(){} // RVA: 0x6B855C0
}

public class OVRGLTFAnimatinonNode : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B85620
    public void AddChannel(){} // RVA: 0x6B85D10
    public void UpdatePose(){} // RVA: 0x6B868C0
    public void GetCardinalThumbsticks(){} // RVA: 0x6B86F60
    public void GetCardinalWeights(){} // RVA: 0x6B870D0
    public void ProcessAnimationSampler(){} // RVA: 0x6B872B0
    public void GetTransformType(){} // RVA: 0x6B87AE0
    public void ToOVRInterpolationType(){} // RVA: 0x6B87C70
    public void CopyData(){} // RVA: 0x8943B0
    public void CloneVector3(){} // RVA: 0x6B87E60
    public void CloneQuaternion(){} // RVA: 0x6B87E80
    public void .cctor(){} // RVA: 0x6B87EA0
}

public class OVRGLTFLoader : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B88630
    public void LoadGLB(){} // RVA: 0x6B88710
    public void SetModelShader(){} // RVA: 0xBBF900
    public void SetModelAlphaBlendShader(){} // RVA: 0xCA4DF0
    public void SetTextureQualityFiltering(){} // RVA: 0x12BB640
    public void SetMipMapBias(){} // RVA: 0x6B892D0
    public void DetectTextureQuality(){} // RVA: 0x6B89300
    public void ApplyTextureQuality(){} // RVA: 0x6B893E0
    public void ValidateGLB(){} // RVA: 0x6B89560
    public void ReadChunk(){} // RVA: 0x6B897C0
    public void ValidateChunk(){} // RVA: 0x6B89890
    public void LoadGLTF(){} // RVA: 0x6B89A10
    public void ProcessNode(){} // RVA: 0x6B8A170
    public void ProcessMesh(){} // RVA: 0x6B8B5A0
    public void FlipTraingleIndices(){} // RVA: 0x6B8D280
    public void ProcessSkin(){} // RVA: 0x6B8D310
    public void ProcessMaterial(){} // RVA: 0x6B8DA90
    public void ProcessTexture(){} // RVA: 0x6B8DDB0
    public void TranscodeTexture(){} // RVA: 0x6B8E400
    public void CreateUnityMaterial(){} // RVA: 0x6B8E480
    public void GetInputNodeType(){} // RVA: 0x6B8E690
    public void ProcessAnimations(){} // RVA: 0x6B8E8A0
    public void .cctor(){} // RVA: 0x6B8F150
}

public class OVRHaptics : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x6B8F630
    public void Process(){} // RVA: 0x6B8FA40
}

public class OVRHapticsChannel : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B903B0
    public void Preempt(){} // RVA: 0x6B90480
    public void Queue(){} // RVA: 0x6B905A0
    public void Mix(){} // RVA: 0x6B90680
    public void Clear(){} // RVA: 0x6B906A0
}

public class OVRHapticsClip : Object
{
    // ── Methods ──
    public void get_Count(){} // RVA: 0xB8F8F0
    public void set_Count(){} // RVA: 0xB460A0
    public void get_Capacity(){} // RVA: 0x116A650
    public void set_Capacity(){} // RVA: 0x116BB10
    public void get_Samples(){} // RVA: 0xB465B0
    public void set_Samples(){} // RVA: 0xBA9BA0
    public void .ctor(){} // RVA: 0x6B923B0
    public void WriteSample(){} // RVA: 0x6B92640
    public void Reset(){} // RVA: 0x132A2D0
    public void InitializeFromAudioFloatTrack(){} // RVA: 0x6B92700
}

public class OVRHapticsOutput : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B90710
    public void Process(){} // RVA: 0x6B90AF0
    public void Preempt(){} // RVA: 0x6B91540
    public void Queue(){} // RVA: 0x6B91650
    public void Mix(){} // RVA: 0x6B91720
    public void Clear(){} // RVA: 0x6B91D60
}

public class OVRInput : Object
{
    // ── Methods ──
    public void get_pluginSupportsActiveController(){} // RVA: 0x6B93490
    public void .cctor(){} // RVA: 0x6B935D0
    public void Update(){} // RVA: 0x6B93C60
    public void FixedUpdate(){} // RVA: 0x6B94610
    public void GetCurrentInteractionProfile(){} // RVA: 0x6B94920
    public void GetControllerOrientationTracked(){} // RVA: 0x6B94B00
    public void GetControllerOrientationValid(){} // RVA: 0x6B94BA0
    public void GetControllerPositionTracked(){} // RVA: 0x6B94C40
    public void GetControllerPositionValid(){} // RVA: 0x6B94D50
    public void GetLocalControllerPosition(){} // RVA: 0x6B94DF0
    public void GetLocalControllerVelocity(){} // RVA: 0x6B951F0
    public void GetLocalControllerAcceleration(){} // RVA: 0x6B95440
    public void GetLocalControllerRotation(){} // RVA: 0x6B95680
    public void GetLocalControllerAngularVelocity(){} // RVA: 0x6B95A70
    public void GetLocalControllerAngularAcceleration(){} // RVA: 0x6B95CC0
    public void GetLocalControllerStatesWithoutPrediction(){} // RVA: 0x6B95F10
    public void GetDominantHand(){} // RVA: 0x6B963B0
    public void Get(){} // RVA: 0x6B98560
    public void GetResolvedButton(){} // RVA: 0x6B96650
    public void GetDown(){} // RVA: 0x6B97890
    public void GetResolvedButtonDown(){} // RVA: 0x6B968F0
    public void GetUp(){} // RVA: 0x6B97B40
    public void GetResolvedButtonUp(){} // RVA: 0x6B96BA0
    public void GetResolvedTouch(){} // RVA: 0x6B96E50
    public void GetResolvedTouchDown(){} // RVA: 0x6B970F0
    public void GetResolvedTouchUp(){} // RVA: 0x6B973A0
    public void GetResolvedNearTouch(){} // RVA: 0x6B97650
    public void GetResolvedNearTouchDown(){} // RVA: 0x6B978F0
    public void GetResolvedNearTouchUp(){} // RVA: 0x6B97BA0
    public void GetResolvedAxis1D(){} // RVA: 0x6B97E50
    public void GetResolvedAxis2D(){} // RVA: 0x6B985C0
    public void GetConnectedControllers(){} // RVA: 0x6B989F0
    public void IsControllerConnected(){} // RVA: 0x6B98A50
    public void GetActiveController(){} // RVA: 0x6B98AB0
    public void StartVibration(){} // RVA: 0x6B98B10
    public void SetOpenVRLocalPose(){} // RVA: 0x6B98D20
    public void GetOpenVRStringProperty(){} // RVA: 0x6B98E50
    public void UpdateXRControllerNodeIds(){} // RVA: 0x6B99020
    public void UpdateXRControllerHaptics(){} // RVA: 0x6B99570
    public void InitHapticInfo(){} // RVA: 0x6B997B0
    public void PlayHapticImpulse(){} // RVA: 0x6B99A00
    public void IsValidOpenVRDevice(){} // RVA: 0x6B99B80
    public void SetControllerVibration(){} // RVA: 0x6B99B90
    public void SetControllerLocalizedVibration(){} // RVA: 0x6B99E20
    public void GetControllerBatteryPercentRemaining(){} // RVA: 0x6B9A0A0
    public void CalculateAbsMax(){} // RVA: 0x6B9A2B0
    public void CalculateDeadzone(){} // RVA: 0x6B9A3F0
    public void ShouldResolveController(){} // RVA: 0x6B9A450
}

public class OVRKtxTexture : Object
{
    // ── Methods ──
    public void Load(){} // RVA: 0x6B9D790
    public void .ctor(){} // RVA: 0xB43310
}

public class OVRLayerAttribute : PropertyAttribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF48510
}

public class OVRMixedReality : Object
{
    // ── Methods ──
    public void Update(){} // RVA: 0x6BAF6E0
    public void Cleanup(){} // RVA: 0x6BB0030
    public void RecenterPose(){} // RVA: 0x6BB0300
    public void .cctor(){} // RVA: 0x6BB03A0
}

public class OVRMixedRealityCaptureConfiguration
{
    // ── Methods ──
    public void get_enableMixedReality(){} // RVA: 0x87D280
    public void set_enableMixedReality(){} // RVA: 0x894750
    public void get_extraHiddenLayers(){} // RVA: 0x87C130
    public void set_extraHiddenLayers(){} // RVA: 0x8944F0
    public void get_extraVisibleLayers(){} // RVA: 0x87C130
    public void set_extraVisibleLayers(){} // RVA: 0x8944F0
    public void get_dynamicCullingMask(){} // RVA: 0x87D280
    public void set_dynamicCullingMask(){} // RVA: 0x894750
    public void get_compositionMethod(){} // RVA: 0x87C130
    public void set_compositionMethod(){} // RVA: 0x8944F0
    public void get_externalCompositionBackdropColorRift(){} // RVA: 0x87BEB0
    public void set_externalCompositionBackdropColorRift(){} // RVA: 0x894320
    public void get_externalCompositionBackdropColorQuest(){} // RVA: 0x87BEB0
    public void set_externalCompositionBackdropColorQuest(){} // RVA: 0x894320
    public void get_capturingCameraDevice(){} // RVA: 0x87C130
    public void set_capturingCameraDevice(){} // RVA: 0x8944F0
    public void get_flipCameraFrameHorizontally(){} // RVA: 0x87D280
    public void set_flipCameraFrameHorizontally(){} // RVA: 0x894750
    public void get_flipCameraFrameVertically(){} // RVA: 0x87D280
    public void set_flipCameraFrameVertically(){} // RVA: 0x894750
    public void get_handPoseStateLatency(){} // RVA: 0x890F90
    public void set_handPoseStateLatency(){} // RVA: 0x8A23A0
    public void get_sandwichCompositionRenderLatency(){} // RVA: 0x890F90
    public void set_sandwichCompositionRenderLatency(){} // RVA: 0x8A23A0
    public void get_sandwichCompositionBufferedFrames(){} // RVA: 0x87C130
    public void set_sandwichCompositionBufferedFrames(){} // RVA: 0x8944F0
    public void get_chromaKeyColor(){} // RVA: 0x87BEB0
    public void set_chromaKeyColor(){} // RVA: 0x894320
    public void get_chromaKeySimilarity(){} // RVA: 0x890F90
    public void set_chromaKeySimilarity(){} // RVA: 0x8A23A0
    public void get_chromaKeySmoothRange(){} // RVA: 0x890F90
    public void set_chromaKeySmoothRange(){} // RVA: 0x8A23A0
    public void get_chromaKeySpillRange(){} // RVA: 0x890F90
    public void set_chromaKeySpillRange(){} // RVA: 0x8A23A0
    public void get_useDynamicLighting(){} // RVA: 0x87D280
    public void set_useDynamicLighting(){} // RVA: 0x894750
    public void get_depthQuality(){} // RVA: 0x87C130
    public void set_depthQuality(){} // RVA: 0x8944F0
    public void get_dynamicLightingSmoothFactor(){} // RVA: 0x890F90
    public void set_dynamicLightingSmoothFactor(){} // RVA: 0x8A23A0
    public void get_dynamicLightingDepthVariationClampingValue(){} // RVA: 0x890F90
    public void set_dynamicLightingDepthVariationClampingValue(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenType(){} // RVA: 0x87C130
    public void set_virtualGreenScreenType(){} // RVA: 0x8944F0
    public void get_virtualGreenScreenTopY(){} // RVA: 0x890F90
    public void set_virtualGreenScreenTopY(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenBottomY(){} // RVA: 0x890F90
    public void set_virtualGreenScreenBottomY(){} // RVA: 0x8A23A0
    public void get_virtualGreenScreenApplyDepthCulling(){} // RVA: 0x87D280
    public void set_virtualGreenScreenApplyDepthCulling(){} // RVA: 0x894750
    public void get_virtualGreenScreenDepthTolerance(){} // RVA: 0x890F90
    public void set_virtualGreenScreenDepthTolerance(){} // RVA: 0x8A23A0
    public void get_mrcActivationMode(){} // RVA: 0x87C130
    public void set_mrcActivationMode(){} // RVA: 0x8944F0
    public void get_instantiateMixedRealityCameraGameObject(){} // RVA: 0x87C0A0
    public void set_instantiateMixedRealityCameraGameObject(){} // RVA: 0x894320
}

public class OVRNativeBuffer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B7CF00
    public void Finalize(){} // RVA: 0x6B7CF10
    public void Reset(){} // RVA: 0x6B7CF60
    public void GetCapacity(){} // RVA: 0x116A650
    public void GetPointer(){} // RVA: 0x6B7CF70
    public void Dispose(){} // RVA: 0x6B7D000
    public void Reallocate(){} // RVA: 0x6B7D020
    public void Release(){} // RVA: 0x6B7D0E0
}

public class OVRNodeStateProperties : Object
{
    // ── Methods ──
    public void IsHmdPresent(){} // RVA: 0x6B7B140
    public void GetNodeStatePropertyVector3(){} // RVA: 0x6B7B270
    public void GetNodeStatePropertyQuaternion(){} // RVA: 0x6B7B8A0
    public void ValidateProperty(){} // RVA: 0x6B7BB20
    public void GetUnityXRNodeStateVector3(){} // RVA: 0x6B7BE50
    public void GetUnityXRNodeStateQuaternion(){} // RVA: 0x6B7C030
    public void .cctor(){} // RVA: 0x6B7C150
}

public class OVRP_0_1_0 : Object
{
    // ── Methods ──
    public void ovrp_GetEyeTextureSize(){} // RVA: 0x6BE9630
    public void .cctor(){} // RVA: 0x6BE96B0
}

public class OVRP_0_1_1 : Object
{
    // ── Methods ──
    public void ovrp_SetOverlayQuad2(){} // RVA: 0x6BE9780
    public void .cctor(){} // RVA: 0x6BE9880
}

public class OVRP_0_1_2 : Object
{
    // ── Methods ──
    public void ovrp_GetNodePose(){} // RVA: 0x6BE9950
    public void ovrp_SetControllerVibration(){} // RVA: 0x6BE99F0
    public void .cctor(){} // RVA: 0x6BE9A90
}

public class OVRP_0_1_3 : Object
{
    // ── Methods ──
    public void ovrp_GetNodeVelocity(){} // RVA: 0x6BE9B60
    public void ovrp_GetNodeAcceleration(){} // RVA: 0x6BE9C00
    public void .cctor(){} // RVA: 0x6BE9CA0
}

public class OVRP_0_5_0 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BE9D70
}

public class OVRP_1_0_0 : Object
{
    // ── Methods ──
    public void ovrp_GetTrackingOriginType(){} // RVA: 0x6BE9E40
    public void ovrp_SetTrackingOriginType(){} // RVA: 0x6BE9EB0
    public void ovrp_GetTrackingCalibratedOrigin(){} // RVA: 0x6BE9F30
    public void ovrp_RecenterTrackingOrigin(){} // RVA: 0x6BE9FC0
    public void .cctor(){} // RVA: 0x6BEA040
}

public class OVRP_1_10_0 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BED5B0
}

public class OVRP_1_11_0 : Object
{
    // ── Methods ──
    public void ovrp_SetDesiredEyeTextureFormat(){} // RVA: 0x6BED680
    public void ovrp_GetDesiredEyeTextureFormat(){} // RVA: 0x6BED700
    public void .cctor(){} // RVA: 0x6BED770
}

public class OVRP_1_1_0 : Object
{
    // ── Methods ──
    public void ovrp_GetInitialized(){} // RVA: 0x6BEA110
    public void _ovrp_GetVersion(){} // RVA: 0x6BEA180
    public void ovrp_GetVersion(){} // RVA: 0x6BEA1F0
    public void _ovrp_GetNativeSDKVersion(){} // RVA: 0x6BEA2F0
    public void ovrp_GetNativeSDKVersion(){} // RVA: 0x6BEA360
    public void ovrp_GetAudioOutId(){} // RVA: 0x6BEA460
    public void ovrp_GetAudioInId(){} // RVA: 0x6BEA4D0
    public void ovrp_GetEyeTextureScale(){} // RVA: 0x6BEA540
    public void ovrp_SetEyeTextureScale(){} // RVA: 0x6BEA5B0
    public void ovrp_GetTrackingOrientationSupported(){} // RVA: 0x6BEA630
    public void ovrp_GetTrackingOrientationEnabled(){} // RVA: 0x6BEA6A0
    public void ovrp_SetTrackingOrientationEnabled(){} // RVA: 0x6BEA710
    public void ovrp_GetTrackingPositionSupported(){} // RVA: 0x6BEA790
    public void ovrp_GetTrackingPositionEnabled(){} // RVA: 0x6BEA800
    public void ovrp_SetTrackingPositionEnabled(){} // RVA: 0x6BEA870
    public void ovrp_GetNodePresent(){} // RVA: 0x6BEA8F0
    public void ovrp_GetNodeOrientationTracked(){} // RVA: 0x6BEA970
    public void ovrp_GetNodePositionTracked(){} // RVA: 0x6BEA9F0
    public void ovrp_GetNodeFrustum(){} // RVA: 0x6BEAA70
    public void ovrp_GetControllerState(){} // RVA: 0x6BEAB00
    public void ovrp_GetSystemCpuLevel(){} // RVA: 0x6BEABA0
    public void ovrp_SetSystemCpuLevel(){} // RVA: 0x6BEAC10
    public void ovrp_GetSystemGpuLevel(){} // RVA: 0x6BEAC90
    public void ovrp_SetSystemGpuLevel(){} // RVA: 0x6BEAD00
    public void ovrp_GetSystemPowerSavingMode(){} // RVA: 0x6BEAD80
    public void ovrp_GetSystemDisplayFrequency(){} // RVA: 0x6BEADF0
    public void ovrp_GetSystemVSyncCount(){} // RVA: 0x6BEAE60
    public void ovrp_GetSystemVolume(){} // RVA: 0x6BEAED0
    public void ovrp_GetSystemBatteryStatus(){} // RVA: 0x6BEAF40
    public void ovrp_GetSystemBatteryLevel(){} // RVA: 0x6BEAFB0
    public void ovrp_GetSystemBatteryTemperature(){} // RVA: 0x6BEB020
    public void _ovrp_GetSystemProductName(){} // RVA: 0x6BEB090
    public void ovrp_GetSystemProductName(){} // RVA: 0x6BEB100
    public void ovrp_ShowSystemUI(){} // RVA: 0x6BEB200
    public void ovrp_GetAppMonoscopic(){} // RVA: 0x6BEB280
    public void ovrp_SetAppMonoscopic(){} // RVA: 0x6BEB2F0
    public void ovrp_GetAppHasVrFocus(){} // RVA: 0x6BEB370
    public void ovrp_GetAppShouldQuit(){} // RVA: 0x6BEB3E0
    public void ovrp_GetAppShouldRecenter(){} // RVA: 0x6BEB450
    public void _ovrp_GetAppLatencyTimings(){} // RVA: 0x6BEB4C0
    public void ovrp_GetAppLatencyTimings(){} // RVA: 0x6BEB530
    public void ovrp_GetUserPresent(){} // RVA: 0x6BEB630
    public void ovrp_GetUserIPD(){} // RVA: 0x6BEB6A0
    public void ovrp_SetUserIPD(){} // RVA: 0x6BEB710
    public void ovrp_GetUserEyeDepth(){} // RVA: 0x6BEB790
    public void ovrp_SetUserEyeDepth(){} // RVA: 0x6BEB800
    public void ovrp_GetUserEyeHeight(){} // RVA: 0x6BEB880
    public void ovrp_SetUserEyeHeight(){} // RVA: 0x6BEB8F0
    public void .cctor(){} // RVA: 0x6BEB970
}

public class OVRP_1_2_0 : Object
{
    // ── Methods ──
    public void ovrp_SetSystemVSyncCount(){} // RVA: 0x6BEBA40
    public void ovrpi_SetTrackingCalibratedOrigin(){} // RVA: 0x6BEBAC0
    public void .cctor(){} // RVA: 0x6BEBB30
}

public class OVRP_1_3_0 : Object
{
    // ── Methods ──
    public void ovrp_GetEyeOcclusionMeshEnabled(){} // RVA: 0x6BEBC00
    public void ovrp_SetEyeOcclusionMeshEnabled(){} // RVA: 0x6BEBC70
    public void ovrp_GetSystemHeadphonesPresent(){} // RVA: 0x6BEBCF0
    public void .cctor(){} // RVA: 0x6BEBD60
}

public class OVRP_1_5_0 : Object
{
    // ── Methods ──
    public void ovrp_GetSystemRegion(){} // RVA: 0x6BEBE30
    public void .cctor(){} // RVA: 0x6BEBEA0
}

public class OVRP_1_6_0 : Object
{
    // ── Methods ──
    public void ovrp_GetTrackingIPDEnabled(){} // RVA: 0x6BEBF70
    public void ovrp_SetTrackingIPDEnabled(){} // RVA: 0x6BEBFE0
    public void ovrp_GetControllerHapticsDesc(){} // RVA: 0x6BEC060
    public void ovrp_GetControllerHapticsState(){} // RVA: 0x6BEC100
    public void ovrp_SetControllerHaptics(){} // RVA: 0x6BEC180
    public void ovrp_SetOverlayQuad3(){} // RVA: 0x6BEC210
    public void ovrp_GetEyeRecommendedResolutionScale(){} // RVA: 0x6BEC320
    public void ovrp_GetAppCpuStartToGpuEndTime(){} // RVA: 0x6BEC390
    public void ovrp_GetSystemRecommendedMSAALevel(){} // RVA: 0x6BEC400
    public void .cctor(){} // RVA: 0x6BEC470
}

public class OVRP_1_7_0 : Object
{
    // ── Methods ──
    public void ovrp_GetAppChromaticCorrection(){} // RVA: 0x6BEC540
    public void ovrp_SetAppChromaticCorrection(){} // RVA: 0x6BEC5B0
    public void .cctor(){} // RVA: 0x6BEC630
}

public class OVRP_1_8_0 : Object
{
    // ── Methods ──
    public void ovrp_GetBoundaryConfigured(){} // RVA: 0x6BEC700
    public void ovrp_TestBoundaryNode(){} // RVA: 0x6BEC770
    public void ovrp_TestBoundaryPoint(){} // RVA: 0x6BEC820
    public void ovrp_GetBoundaryGeometry(){} // RVA: 0x6BEC8E0
    public void ovrp_GetBoundaryDimensions(){} // RVA: 0x6BECAD0
    public void ovrp_GetBoundaryVisible(){} // RVA: 0x6BECB70
    public void ovrp_SetBoundaryVisible(){} // RVA: 0x6BECBE0
    public void ovrp_Update2(){} // RVA: 0x6BECC60
    public void ovrp_GetNodePose2(){} // RVA: 0x6BECD00
    public void ovrp_GetNodeVelocity2(){} // RVA: 0x6BECDB0
    public void ovrp_GetNodeAcceleration2(){} // RVA: 0x6BECE60
    public void .cctor(){} // RVA: 0x6BECF10
}

public class OVRP_1_9_0 : Object
{
    // ── Methods ──
    public void ovrp_GetSystemHeadsetType(){} // RVA: 0x6BECFE0
    public void ovrp_GetActiveController(){} // RVA: 0x6BED050
    public void ovrp_GetConnectedControllers(){} // RVA: 0x6BED0C0
    public void ovrp_GetBoundaryGeometry2(){} // RVA: 0x6BED130
    public void ovrp_GetAppPerfStats(){} // RVA: 0x6BED1D0
    public void ovrp_ResetAppPerfStats(){} // RVA: 0x6BED470
    public void .cctor(){} // RVA: 0x6BED4E0
}

public class OVRPermissionsRequester : Object
{
    // ── Methods ──
    public void add_PermissionGranted(){} // RVA: 0x6BBE580
    public void remove_PermissionGranted(){} // RVA: 0x6BBE6B0
    public void GetPermissionId(){} // RVA: 0x6BBE7E0
    public void IsPermissionSupportedByPlatform(){} // RVA: 0x6BBE8E0
    public void IsPermissionGranted(){} // RVA: 0xC2E4C0
    public void Request(){} // RVA: 0xB43310
    public void ShouldRequestPermission(){} // RVA: 0x6BBEE90
}

public class OVRPlugin : Object
{
    // ── Methods ──
    public void get_version(){} // RVA: 0x6BBF460
    public void get_nativeSDKVersion(){} // RVA: 0x6BBFCA0
    public void SetLogCallback2(){} // RVA: 0x6BC0150
    public void get_initialized(){} // RVA: 0x6BC0340
    public void get_nativeXrApi(){} // RVA: 0x6BC03F0
    public void get_chromatic(){} // RVA: 0x6BC0690
    public void set_chromatic(){} // RVA: 0x6BC0840
    public void get_monoscopic(){} // RVA: 0x6BC0A20
    public void set_monoscopic(){} // RVA: 0x6BC0B00
    public void get_rotation(){} // RVA: 0x6BC0C00
    public void set_rotation(){} // RVA: 0x6BC0CE0
    public void get_position(){} // RVA: 0x6BC0DE0
    public void set_position(){} // RVA: 0x6BC0EC0
    public void get_useIPDInPositionTracking(){} // RVA: 0x6BC0FC0
    public void set_useIPDInPositionTracking(){} // RVA: 0x6BC1190
    public void get_positionSupported(){} // RVA: 0x6BC1370
    public void get_positionTracked(){} // RVA: 0x6BC1450
    public void get_powerSaving(){} // RVA: 0x6BC14E0
    public void get_hmdPresent(){} // RVA: 0x6BC15C0
    public void get_userPresent(){} // RVA: 0x6BC1650
    public void get_headphonesPresent(){} // RVA: 0x6BC1730
    public void get_recommendedMSAALevel(){} // RVA: 0x6BC1810
    public void get_systemRegion(){} // RVA: 0x6BC19E0
    public void get_audioOutId(){} // RVA: 0x6BC1BA0
    public void get_audioInId(){} // RVA: 0x6BC2030
    public void get_hasVrFocus(){} // RVA: 0x6BC24C0
    public void get_hasInputFocus(){} // RVA: 0x6BC2570
    public void get_shouldQuit(){} // RVA: 0x6BC2720
    public void get_shouldRecenter(){} // RVA: 0x6BC27D0
    public void get_productName(){} // RVA: 0x6BC2880
    public void get_latency(){} // RVA: 0x6BC29B0
    public void get_eyeDepth(){} // RVA: 0x6BC2B30
    public void set_eyeDepth(){} // RVA: 0x6BC2C10
    public void get_eyeHeight(){} // RVA: 0x6BC2CD0
    public void set_eyeHeight(){} // RVA: 0x6BC2D70
    public void get_batteryLevel(){} // RVA: 0x6BC2E30
    public void get_batteryTemperature(){} // RVA: 0x6BC2ED0
    public void get_suggestedCpuPerfLevel(){} // RVA: 0x6BC2F70
    public void set_suggestedCpuPerfLevel(){} // RVA: 0x6BC3120
    public void get_suggestedGpuPerfLevel(){} // RVA: 0x6BC32B0
    public void set_suggestedGpuPerfLevel(){} // RVA: 0x6BC3460
    public void get_cpuLevel(){} // RVA: 0x6BC35F0
    public void set_cpuLevel(){} // RVA: 0x6BC3690
    public void get_gpuLevel(){} // RVA: 0x6BC3740
    public void set_gpuLevel(){} // RVA: 0x6BC37E0
    public void get_vsyncCount(){} // RVA: 0x6BC3890
    public void set_vsyncCount(){} // RVA: 0x6BC3930
    public void get_systemVolume(){} // RVA: 0x6BC39E0
    public void get_ipd(){} // RVA: 0x6BC3A80
    public void set_ipd(){} // RVA: 0x6BC3B20
    public void get_occlusionMesh(){} // RVA: 0x6BC3BE0
    public void set_occlusionMesh(){} // RVA: 0x6BC3CC0
    public void get_batteryStatus(){} // RVA: 0x6BC3DC0
    public void GetEyeFrustum(){} // RVA: 0x6BC3E60
    public void GetEyeTextureSize(){} // RVA: 0x6BC3F30
    public void GetTrackerPose(){} // RVA: 0x6BC3FE0
    public void GetTrackerFrustum(){} // RVA: 0x6BC4060
    public void ShowUI(){} // RVA: 0x6BC4130
    public void EnqueueSubmitLayer(){} // RVA: 0x6BC41F0
    public void CalculateLayerDesc(){} // RVA: 0x6BC4970
    public void EnqueueSetupLayer(){} // RVA: 0x6BC4C30
    public void EnqueueDestroyLayer(){} // RVA: 0x6BC5270
    public void GetLayerTexture(){} // RVA: 0x6BC5440
    public void GetLayerTextureStageCount(){} // RVA: 0x6BC5630
    public void GetLayerAndroidSurfaceObject(){} // RVA: 0x6BC5810
    public void UpdateNodePhysicsPoses(){} // RVA: 0x6BC59E0
    public void GetNodePose(){} // RVA: 0x6BC5BA0
    public void GetNodeVelocity(){} // RVA: 0x6BC5FA0
    public void GetNodeAngularVelocity(){} // RVA: 0x6BC63B0
    public void GetNodeAcceleration(){} // RVA: 0x6BC65B0
    public void GetNodeAngularAcceleration(){} // RVA: 0x6BC69B0
    public void GetNodePresent(){} // RVA: 0x6BC6BB0
    public void GetNodeOrientationTracked(){} // RVA: 0x6BC6C10
    public void GetNodeOrientationValid(){} // RVA: 0x6BC6CD0
    public void GetNodePositionTracked(){} // RVA: 0x6BC6EC0
    public void GetNodePositionValid(){} // RVA: 0x6BC6F20
    public void GetNodePoseStateRaw(){} // RVA: 0x6BC7150
    public void GetNodePoseStateAtTime(){} // RVA: 0x6BC7570
    public void GetNodePoseStateImmediate(){} // RVA: 0x6BC7810
    public void GetCurrentTrackingTransformPose(){} // RVA: 0x6BC7AA0
    public void GetTrackingTransformRawPose(){} // RVA: 0x6BC7CC0
    public void GetTrackingTransformRelativePose(){} // RVA: 0x6BC7EE0
    public void GetControllerState(){} // RVA: 0x6BC8150
    public void GetControllerState2(){} // RVA: 0x6BC8230
    public void GetControllerState4(){} // RVA: 0x6BC84D0
    public void GetControllerState5(){} // RVA: 0x6BC88C0
    public void GetCurrentInteractionProfile(){} // RVA: 0x6BC8D20
    public void SetControllerVibration(){} // RVA: 0x6BC8EC0
    public void SetControllerLocalizedVibration(){} // RVA: 0x6BC8FA0
    public void GetControllerHapticsDesc(){} // RVA: 0x6BC9170
    public void GetControllerHapticsState(){} // RVA: 0x6BC9350
    public void SetControllerHaptics(){} // RVA: 0x6BC94F0
    public void GetEyeRecommendedResolutionScale(){} // RVA: 0x6BC96B0
    public void GetAppCpuStartToGpuEndTime(){} // RVA: 0x6BC9840
    public void GetBoundaryConfigured(){} // RVA: 0x6BC99C0
    public void TestBoundaryNode(){} // RVA: 0x6BC9B50
    public void TestBoundaryPoint(){} // RVA: 0x6BC9D20
    public void GetBoundaryGeometry(){} // RVA: 0x6BC9F10
    public void GetBoundaryGeometry2(){} // RVA: 0x6BCA220
    public void GetAppPerfStats(){} // RVA: 0x6BCA3E0
    public void ResetAppPerfStats(){} // RVA: 0x6BCA8C0
    public void GetAppFramerate(){} // RVA: 0x6BCAB20
    public void SetHandNodePoseStateLatency(){} // RVA: 0x6BCACA0
    public void GetHandNodePoseStateLatency(){} // RVA: 0x6BCAE40
    public void GetDesiredEyeTextureFormat(){} // RVA: 0x6BCB000
    public void SetDesiredEyeTextureFormat(){} // RVA: 0x6BCB190
    public void InitializeMixedReality(){} // RVA: 0x6BCB330
    public void ShutdownMixedReality(){} // RVA: 0x6BCB4C0
    public void IsMixedRealityInitialized(){} // RVA: 0x6BCB650
    public void GetExternalCameraCount(){} // RVA: 0x6BCB7E0
    public void UpdateExternalCamera(){} // RVA: 0x6BCB990
    public void GetMixedRealityCameraInfo(){} // RVA: 0x6BCBB20
    public void OverrideExternalCameraFov(){} // RVA: 0x6BCBD90
    public void GetUseOverriddenExternalCameraFov(){} // RVA: 0x6BCBF50
    public void OverrideExternalCameraStaticPose(){} // RVA: 0x6BCC120
    public void GetUseOverriddenExternalCameraStaticPose(){} // RVA: 0x6BCC2E0
    public void ResetDefaultExternalCamera(){} // RVA: 0x6BCC4B0
    public void SetDefaultExternalCamera(){} // RVA: 0x6BCC640
    public void SetExternalCameraProperties(){} // RVA: 0x6BCC820
    public void IsInsightPassthroughSupported(){} // RVA: 0x6BCCA00
    public void InitializeInsightPassthrough(){} // RVA: 0x6BCCC40
    public void ShutdownInsightPassthrough(){} // RVA: 0x6BCCDD0
    public void IsInsightPassthroughInitialized(){} // RVA: 0x6BCCF60
    public void GetInsightPassthroughInitializationState(){} // RVA: 0x6BCD0F0
    public void CreateInsightTriangleMesh(){} // RVA: 0x6BCD280
    public void DestroyInsightTriangleMesh(){} // RVA: 0x6BCD510
    public void AddInsightPassthroughSurfaceGeometry(){} // RVA: 0x6BCD6B0
    public void DestroyInsightPassthroughGeometryInstance(){} // RVA: 0x6BCD8B0
    public void UpdateInsightPassthroughGeometryTransform(){} // RVA: 0x6BCDA50
    public void SetInsightPassthroughStyle(){} // RVA: 0x6BCDC30
    public void SetInsightPassthroughKeyboardHandsIntensity(){} // RVA: 0x6BCDE00
    public void GetPassthroughCapabilityFlags(){} // RVA: 0x6BCDFC0
    public void GetBoundaryDimensions(){} // RVA: 0x6BCE250
    public void GetBoundaryVisible(){} // RVA: 0x6BCE420
    public void SetBoundaryVisible(){} // RVA: 0x6BCE5B0
    public void GetSystemHeadsetType(){} // RVA: 0x6BCE770
    public void GetActiveController(){} // RVA: 0x6BCE8F0
    public void GetConnectedControllers(){} // RVA: 0x6BCEA70
    public void ToBool(){} // RVA: 0x67F8240
    public void GetTrackingOriginType(){} // RVA: 0x6BCEBF0
    public void SetTrackingOriginType(){} // RVA: 0x6BCEC90
    public void GetTrackingCalibratedOrigin(){} // RVA: 0x6BCED50
    public void SetTrackingCalibratedOrigin(){} // RVA: 0x6BCEE20
    public void RecenterTrackingOrigin(){} // RVA: 0x6BCEED0
    public void UpdateCameraDevices(){} // RVA: 0x6BCEF90
    public void IsCameraDeviceAvailable(){} // RVA: 0x6BCF120
    public void SetCameraDevicePreferredColorFrameSize(){} // RVA: 0x6BCF2C0
    public void OpenCameraDevice(){} // RVA: 0x6BCF480
    public void CloseCameraDevice(){} // RVA: 0x6BCF620
    public void HasCameraDeviceOpened(){} // RVA: 0x6BCF7C0
    public void IsCameraDeviceColorFrameAvailable(){} // RVA: 0x6BCF960
    public void GetCameraDeviceColorFrameTexture(){} // RVA: 0x6BCFB00
    public void DoesCameraDeviceSupportDepth(){} // RVA: 0x6BCFF70
    public void SetCameraDeviceDepthSensingMode(){} // RVA: 0x6BD0130
    public void SetCameraDevicePreferredDepthQuality(){} // RVA: 0x6BD02E0
    public void IsCameraDeviceDepthFrameAvailable(){} // RVA: 0x6BD0490
    public void GetCameraDeviceDepthFrameTexture(){} // RVA: 0x6BD0650
    public void GetCameraDeviceDepthConfidenceTexture(){} // RVA: 0x6BD0AF0
    public void get_foveatedRenderingSupported(){} // RVA: 0x6BD0F80
    public void get_eyeTrackedFoveatedRenderingSupported(){} // RVA: 0x6BD0FF0
    public void get_eyeTrackedFoveatedRenderingEnabled(){} // RVA: 0x6BD1190
    public void set_eyeTrackedFoveatedRenderingEnabled(){} // RVA: 0x6BD1350
    public void get_fixedFoveatedRenderingSupported(){} // RVA: 0x6BD1510
    public void get_foveatedRenderingLevel(){} // RVA: 0x6BD16C0
    public void set_foveatedRenderingLevel(){} // RVA: 0x6BD1880
    public void get_fixedFoveatedRenderingLevel(){} // RVA: 0x6BD1A40
    public void set_fixedFoveatedRenderingLevel(){} // RVA: 0x6BD1A90
    public void get_useDynamicFixedFoveatedRendering(){} // RVA: 0x6BD1AE0
    public void set_useDynamicFixedFoveatedRendering(){} // RVA: 0x6BD1CB0
    public void get_tiledMultiResSupported(){} // RVA: 0x6BD1E70
    public void get_tiledMultiResLevel(){} // RVA: 0x6BD1EC0
    public void set_tiledMultiResLevel(){} // RVA: 0x6BD1F10
    public void get_gpuUtilSupported(){} // RVA: 0x6BD1F60
    public void get_gpuUtilLevel(){} // RVA: 0x6BD2110
    public void get_systemDisplayFrequenciesAvailable(){} // RVA: 0x6BD22E0
    public void get_systemDisplayFrequency(){} // RVA: 0x6BD2750
    public void set_systemDisplayFrequency(){} // RVA: 0x6BD2A50
    public void get_eyeFovPremultipliedAlphaModeEnabled(){} // RVA: 0x6BD2BF0
    public void set_eyeFovPremultipliedAlphaModeEnabled(){} // RVA: 0x6BD2D90
    public void GetNodeFrustum2(){} // RVA: 0x6BD2F40
    public void get_AsymmetricFovEnabled(){} // RVA: 0x6BD3100
    public void get_EyeTextureArrayEnabled(){} // RVA: 0x6BD32B0
    public void get_localDimmingSupported(){} // RVA: 0x6BD3440
    public void get_localDimming(){} // RVA: 0x6BD35F0
    public void set_localDimming(){} // RVA: 0x6BD37D0
    public void GetDominantHand(){} // RVA: 0x6BD3990
    public void SendEvent(){} // RVA: 0x6BD3B40
    public void SetHeadPoseModifier(){} // RVA: 0x6BD3F20
    public void GetHeadPoseModifier(){} // RVA: 0x6BD40E0
    public void IsPerfMetricsSupported(){} // RVA: 0x6BD4320
    public void GetPerfMetricsFloat(){} // RVA: 0x6BD44E0
    public void GetPerfMetricsInt(){} // RVA: 0x6BD46C0
    public void GetTimeInSeconds(){} // RVA: 0x6BD48B0
    public void SetColorScaleAndOffset(){} // RVA: 0xB43320
    public void AddCustomMetadata(){} // RVA: 0x6BD4A70
    public void SetDeveloperMode(){} // RVA: 0x6BD4C60
    public void GetAdaptiveGPUPerformanceScale(){} // RVA: 0x6BD4E00
    public void GetHandTrackingEnabled(){} // RVA: 0x6BD4FC0
    public void GetHandState(){} // RVA: 0x6BD5170
    public void GetSkeleton(){} // RVA: 0x6BD5D00
    public void GetSkeleton2(){} // RVA: 0x6BD5F50
    public void get_bodyTrackingSupported(){} // RVA: 0x6BD7F20
    public void get_bodyTrackingEnabled(){} // RVA: 0x6BD80D0
    public void GetBodyState(){} // RVA: 0x6BD8280
    public void GetMesh(){} // RVA: 0x6BD9740
    public void StartKeyboardTracking(){} // RVA: 0x6BD9B30
    public void StopKeyboardTracking(){} // RVA: 0x6BD9CD0
    public void GetKeyboardState(){} // RVA: 0x6BD9E60
    public void GetSystemKeyboardDescription(){} // RVA: 0x6BDA040
    public void get_faceTrackingEnabled(){} // RVA: 0x6BDA1A0
    public void get_faceTrackingSupported(){} // RVA: 0x6BDA350
    public void GetFaceState(){} // RVA: 0x6BDA500
    public void get_eyeTrackingEnabled(){} // RVA: 0x6BDB5B0
    public void get_eyeTrackingSupported(){} // RVA: 0x6BDB760
    public void GetEyeGazesState(){} // RVA: 0x6BDB910
    public void StartEyeTracking(){} // RVA: 0x6BDBCB0
    public void StopEyeTracking(){} // RVA: 0x6BDBE40
    public void StartFaceTracking(){} // RVA: 0x6BDBFD0
    public void StopFaceTracking(){} // RVA: 0x6BDC160
    public void StartBodyTracking(){} // RVA: 0x6BDC2F0
    public void StopBodyTracking(){} // RVA: 0x6BDC480
    public void GetLocalTrackingSpaceRecenterCount(){} // RVA: 0x6BDC610
    public void GetSystemHmd3DofModeEnabled(){} // RVA: 0x6BDC7C0
    public void SetClientColorDesc(){} // RVA: 0x6BDC970
    public void GetHmdColorDesc(){} // RVA: 0x6BDCB60
    public void PollEvent(){} // RVA: 0x6BDCD80
    public void GetNativeOpenXRInstance(){} // RVA: 0x6BDD130
    public void GetNativeOpenXRSession(){} // RVA: 0x6BDD2E0
    public void SetKeyboardOverlayUV(){} // RVA: 0x6BDD490
    public void CreateSpatialAnchor(){} // RVA: 0x6BDD640
    public void SetSpaceComponentStatus(){} // RVA: 0x6BDD800
    public void GetSpaceComponentStatus(){} // RVA: 0x6BDDA00
    public void EnumerateSpaceSupportedComponents(){} // RVA: 0x6BDDBF0
    public void SaveSpace(){} // RVA: 0x6BDDDD0
    public void EraseSpace(){} // RVA: 0x6BDDFA0
    public void GetSpaceUuid(){} // RVA: 0x6BDE170
    public void QuerySpaces(){} // RVA: 0x6BDE320
    public void RetrieveSpaceQueryResults(){} // RVA: 0x6BDE5D0
    public void TryLocateSpace(){} // RVA: 0x6BDEAE0
    public void LocateSpace(){} // RVA: 0x6BDECF0
    public void DestroySpace(){} // RVA: 0x6BDEDE0
    public void GetSpaceContainer(){} // RVA: 0x6BDEF80
    public void GetSpaceBoundingBox2D(){} // RVA: 0x6BDF3C0
    public void GetSpaceBoundingBox3D(){} // RVA: 0x6BDF570
    public void GetSpaceSemanticLabels(){} // RVA: 0x6BDF730
    public void GetSpaceRoomLayout(){} // RVA: 0x6BDFAF0
    public void GetSpaceBoundary2D(){} // RVA: 0x6BE0250
    public void RequestSceneCapture(){} // RVA: 0x6BE0800
    public void GetRenderModelPaths(){} // RVA: 0x6BE0BB0
    public void GetRenderModelProperties(){} // RVA: 0x6BE0F10
    public void LoadRenderModel(){} // RVA: 0x6BE1460
    public void FeatureFidelitySetFeatureEnable(){} // RVA: 0x6BE1740
    public void FeatureFidelitySetFeatureFidelity(){} // RVA: 0x6BE18F0
    public void FeatureFidelityGetFeatureState(){} // RVA: 0x6BE1AA0
    public void .cctor(){} // RVA: 0x6BE1CB0
}

public class OVRPose : ValueType
{
    // ── Methods ──
    public void get_identity(){} // RVA: 0x6B7C230
    public void Equals(){} // RVA: 0x8C94B0
    public void GetHashCode(){} // RVA: 0x8C94C0
    public void op_Equality(){} // RVA: 0x6B7C4D0
    public void op_Inequality(){} // RVA: 0x6B7C570
    public void op_Multiply(){} // RVA: 0x6B7C620
    public void Inverse(){} // RVA: 0x8C94D0
    public void flipZ(){} // RVA: 0x8C9510
    public void ToPosef_Legacy(){} // RVA: 0x8C9570
    public void ToPosef(){} // RVA: 0x8C95E0
    public void Rotate180AlongX(){} // RVA: 0x8C9660
}

public class OVRSandwichComposition : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ObjectValueCollection : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA4AE260
    public void get_Count(){} // RVA: 0xA4AE320
    public void get_Item(){} // RVA: 0xA4AE370
    public void set_Item(){} // RVA: 0xA4AE460
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0xA4AE4A0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0xA4AE5B0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0xA4AE6C0
    public void System.Collections.IList.get_Item(){} // RVA: 0xA4AE700
    public void System.Collections.IList.set_Item(){} // RVA: 0xA4AE810
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void get_SyncRoot(){} // RVA: 0xA4AE850
    public void get_IsSynchronized(){} // RVA: 0xB43320
    public void get_IsFixedSize(){} // RVA: 0xC2E4C0
    public void Contains(){} // RVA: 0xA4AE910
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0xA4AE9C0
    public void CopyTo(){} // RVA: 0xA4AEE90
    public void Add(){} // RVA: 0xA4AF120
    public void System.Collections.IList.Add(){} // RVA: 0xA4AF160
    public void Clear(){} // RVA: 0xA4AF1A0
    public void Remove(){} // RVA: 0xA4AF220
    public void System.Collections.IList.Remove(){} // RVA: 0xA4AF260
    public void Insert(){} // RVA: 0xA4AF2E0
    public void RemoveAt(){} // RVA: 0xA4AF320
    public void GetEnumerator(){} // RVA: 0xA4AF360
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA4AF3B0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0xA4AF3F0
    public void IndexOf(){} // RVA: 0xA4AF530
}

public class ObserverState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x792AD30
    public void <.ctor>b__2_0(){} // RVA: 0x792ADF0
}

public class OnCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnCapturedToDiskCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnCapturedToMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB610
    public void Invoke(){} // RVA: 0x26DB6E0
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80DD890
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA6F8980
}

public class OnFinishedCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnPerformCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7C43D00
    public void Invoke(){} // RVA: 0x7C43E70
}

public class OnPhotoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnPhotoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnScreenDeviceInfo : ValueType
{
    // ── Methods ──
    public void AddControl(){} // RVA: 0x938100
    public void RemoveControl(){} // RVA: 0x938140
    public void Destroy(){} // RVA: 0x938180
}

public class OnStartedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1430
    public void Invoke(){} // RVA: 0xCA8D60
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26DB540
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class OnStoppedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54D60
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x7A54E50
    public void EndInvoke(){} // RVA: 0x3DFBD50
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54D60
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x7A54E50
    public void EndInvoke(){} // RVA: 0x3DFBD50
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A54D60
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x7A54E50
    public void EndInvoke(){} // RVA: 0x3DFBD50
}

public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class OnVideoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OnVideoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A76F0
    public void Invoke(){} // RVA: 0x35A77C0
}

public class OpacityIdUpdateJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x99DDC0
}

public class OptionData : Object
{
    // ── Methods ──
    public void get_text(){} // RVA: 0xB5DBF0
    public void set_text(){} // RVA: 0xB44D60
    public void get_image(){} // RVA: 0xB465B0
    public void set_image(){} // RVA: 0xBA9BA0
    public void .ctor(){} // RVA: 0x17C92C0
}

public class OptionData : Object
{
    // ── Methods ──
    public void get_text(){} // RVA: 0xB5DBF0
    public void set_text(){} // RVA: 0xB44D60
    public void get_image(){} // RVA: 0xB465B0
    public void set_image(){} // RVA: 0xBA9BA0
    public void get_color(){} // RVA: 0x16CD810
    public void set_color(){} // RVA: 0x16DCCA0
    public void .ctor(){} // RVA: 0x79F9080
}

public class OptionDataList : Object
{
    // ── Methods ──
    public void get_options(){} // RVA: 0xB5DBF0
    public void set_options(){} // RVA: 0xB44D60
    public void .ctor(){} // RVA: 0x7E3C070
}

public class OptionDataList : Object
{
    // ── Methods ──
    public void get_options(){} // RVA: 0xB5DBF0
    public void set_options(){} // RVA: 0xB44D60
    public void .ctor(){} // RVA: 0x79F9150
}

public class OptionData[] : Array
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

public class OptionData[] : Array
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

public class Option[] : Array
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

public class OptionsAndroid : PlatformOptions
{
    // ── Methods ──
    public void get_generateMipmaps(){} // RVA: 0xB68DF0
    public void set_generateMipmaps(){} // RVA: 0x2547FB0
    public void get_previousAudioMode(){} // RVA: 0xE9CE60
    public void get_audioMode(){} // RVA: 0x18A0130
    public void set_audioMode(){} // RVA: 0x2547FC0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547FE0
    public void get_preferredMaximumResolution(){} // RVA: 0x114DAD0
    public void set_preferredMaximumResolution(){} // RVA: 0x2548000
    public void get_customPreferredMaximumResolution(){} // RVA: 0xBC1B30
    public void set_customPreferredMaximumResolution(){} // RVA: 0x2548010
    public void get_preferredPeakBitRate(){} // RVA: 0x1767220
    public void set_preferredPeakBitRate(){} // RVA: 0x2548040
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x1D46130
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x2548060
    public void get_allowUnsupportedVideoTrackVariants(){} // RVA: 0xC00EC0
    public void set_allowUnsupportedVideoTrackVariants(){} // RVA: 0x2548070
    public void IsModified(){} // RVA: 0x2548080
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x2548140
    public void StartWithHighestBandwidth(){} // RVA: 0x100AD20
    public void HasChanged(){} // RVA: 0x2548190
    public void ClearChanges(){} // RVA: 0x25481B0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x25481C0
    public void .ctor(){} // RVA: 0x25481F0
}

public class OptionsApple : PlatformOptions
{
    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x1AE5AC0
    public void get_audioMode(){} // RVA: 0xB9E080
    public void set_audioMode(){} // RVA: 0x2547CC0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547CE0
    public void get_flags(){} // RVA: 0xE9CE60
    public void set_flags(){} // RVA: 0x2547D00
    public void get_preferredPeakBitRate(){} // RVA: 0xD344A0
    public void set_preferredPeakBitRate(){} // RVA: 0x2547D30
    public void get_preferredPeakBitRateUnits(){} // RVA: 0xBE5870
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x2547D50
    public void get_preferredForwardBufferDuration(){} // RVA: 0x2547D60
    public void set_preferredForwardBufferDuration(){} // RVA: 0x2547D70
    public void get_preferredMaximumResolution(){} // RVA: 0xE32C80
    public void set_preferredMaximumResolution(){} // RVA: 0x2547D90
    public void get_customPreferredMaximumResolution(){} // RVA: 0x2547DA0
    public void set_customPreferredMaximumResolution(){} // RVA: 0x2547DB0
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x2547E20
    public void .ctor(){} // RVA: 0x2547E60
    public void IsModified(){} // RVA: 0x2547F20
    public void HasChanged(){} // RVA: 0x2547F90
    public void ClearChanges(){} // RVA: 0x2547FA0
}

public class OptionsOpenHarmony : PlatformOptions
{
    // ── Methods ──
    public void get_generateMipmaps(){} // RVA: 0xC27380
    public void set_generateMipmaps(){} // RVA: 0x2548270
    public void get_useNormalizedOHMUrl(){} // RVA: 0xD96880
    public void set_useNormalizedOHMUrl(){} // RVA: 0x2548280
    public void get_previousAudioMode(){} // RVA: 0xB9E080
    public void get_audioMode(){} // RVA: 0xE9CE60
    public void set_audioMode(){} // RVA: 0x2548290
    public void get_IsUsingAudioCapture(){} // RVA: 0x25482B0
    public void get_preferredMaximumResolution(){} // RVA: 0x18A0130
    public void set_preferredMaximumResolution(){} // RVA: 0x25482D0
    public void get_customPreferredMaximumResolution(){} // RVA: 0x25482E0
    public void set_customPreferredMaximumResolution(){} // RVA: 0x25482F0
    public void IsModified(){} // RVA: 0x2548320
    public void BitRateInBitsPerSecond(){} // RVA: 0x2547DE0
    public void HasChanged(){} // RVA: 0x2548190
    public void ClearChanges(){} // RVA: 0x25481B0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0xB43310
    public void .ctor(){} // RVA: 0x2548360
}

public class OptionsWebGL : PlatformOptions
{
    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x1AE5AC0
    public void get_audioMode(){} // RVA: 0xB9E080
    public void set_audioMode(){} // RVA: 0x25483C0
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547CE0
    public void IsModified(){} // RVA: 0x25483E0
    public void HasChanged(){} // RVA: 0x2548410
    public void ClearChanges(){} // RVA: 0x25481B0
    public void GetKeyServerAuthToken(){} // RVA: 0xDAC980
    public void GetOverrideDecryptionKey(){} // RVA: 0xDAC980
    public void .ctor(){} // RVA: 0x2548420
}

public class OptionsWindows : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x25479C0
    public void StartWithHighestBandwidth(){} // RVA: 0xBFDA40
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547AA0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x2547AB0
    public void .ctor(){} // RVA: 0x2547AE0
}

public class OptionsWindowsUWP : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x2547C30
    public void StartWithHighestBandwidth(){} // RVA: 0xB78D60
    public void get_IsUsingAudioCapture(){} // RVA: 0x2547C90
    public void .ctor(){} // RVA: 0x2547CA0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x260A0
}
