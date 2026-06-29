// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 640

public class OVRBone : Object
{
    // ── Methods ──
    public void get_Id(){} // RVA: 0x7A8124910
    public void set_Id(){} // RVA: 0x7A80DA0C0
    public void get_ParentBoneIndex(){} // RVA: 0x7AACD9AE0
    public void set_ParentBoneIndex(){} // RVA: 0x7ADFB03E0
    public void get_Transform(){} // RVA: 0x7A80DA7B0
    public void set_Transform(){} // RVA: 0x7A813E420
    public void .ctor(){} // RVA: 0x7ADFB03F0
}

public class OVRBoneCapsule : Object
{
    // ── Methods ──
    public void get_BoneIndex(){} // RVA: 0x7A99CD750
    public void set_BoneIndex(){} // RVA: 0x7A99CDAA0
    public void get_CapsuleRigidbody(){} // RVA: 0x7A80DA7B0
    public void set_CapsuleRigidbody(){} // RVA: 0x7A813E420
    public void get_CapsuleCollider(){} // RVA: 0x7A81052C0
    public void set_CapsuleCollider(){} // RVA: 0x7A81052D0
    public void .ctor(){} // RVA: 0x7ADFB0450
}

public class OVRBoneCapsule[] : Array
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

public class OVRBone[] : Array
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

public class OVRControllerBase : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF13640
    public void Update(){} // RVA: 0x7ADF13920
    public void GetOpenVRControllerState(){} // RVA: 0x7ADF13D80
    public void SetControllerVibration(){} // RVA: 0x7ADF14330
    public void SetControllerLocalizedVibration(){} // RVA: 0x7ADF14440
    public void GetBatteryPercentRemaining(){} // RVA: 0x7A80D7320
    public void ConfigureButtonMap(){} // RVA: 0x7A7E18770
    public void ConfigureTouchMap(){} // RVA: 0x7A7E18770
    public void ConfigureNearTouchMap(){} // RVA: 0x7A7E18770
    public void ConfigureAxis1DMap(){} // RVA: 0x7A7E18770
    public void ConfigureAxis2DMap(){} // RVA: 0x7A7E18770
    public void ResolveToRawMask(){} // RVA: 0x7ADF147E0
}

public class OVRControllerGamepadAndroid : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF16550
    public void ConfigureButtonMap(){} // RVA: 0x7ADF16570
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF16800
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF168D0
}

public class OVRControllerGamepadPC : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF16550
    public void ConfigureButtonMap(){} // RVA: 0x7ADF16570
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF16800
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF168D0
}

public class OVRControllerHands : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF15A00
    public void ConfigureButtonMap(){} // RVA: 0x7ADF15A20
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF15D50
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15E10
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF14FE0
}

public class OVRControllerLHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF15E60
    public void ConfigureButtonMap(){} // RVA: 0x7ADF15E80
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF15D50
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15E10
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF154F0
}

public class OVRControllerLTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF15000
    public void ConfigureButtonMap(){} // RVA: 0x7ADF15020
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15270
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15350
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF153B0
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15490
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF154F0
}

public class OVRControllerRHand : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF160A0
    public void ConfigureButtonMap(){} // RVA: 0x7ADF160C0
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF15D50
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15E10
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF159F0
}

public class OVRControllerRTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF15500
    public void ConfigureButtonMap(){} // RVA: 0x7ADF15520
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15770
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15850
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF158B0
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15990
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF159F0
}

public class OVRControllerRemote : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF162E0
    public void ConfigureButtonMap(){} // RVA: 0x7ADF16300
    public void ConfigureTouchMap(){} // RVA: 0x7ADF15C40
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF15D00
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF15D50
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF15E10
}

public class OVRControllerTouch : OVRControllerBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF14AA0
    public void ConfigureButtonMap(){} // RVA: 0x7ADF14AC0
    public void ConfigureTouchMap(){} // RVA: 0x7ADF14D30
    public void ConfigureNearTouchMap(){} // RVA: 0x7ADF14E20
    public void ConfigureAxis1DMap(){} // RVA: 0x7ADF14E80
    public void ConfigureAxis2DMap(){} // RVA: 0x7ADF14F80
    public void GetBatteryPercentRemaining(){} // RVA: 0x7ADF14FE0
}

public class OVRGLTFAccessor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADEFBE60
    public void GetDataCount(){} // RVA: 0x7A8133100
    public void ToOVRType(){} // RVA: 0x7ADEFC290
    public void ReadAsInt(){} // RVA: 0x7ADEFC4C0
    public void ReadAsFloat(){} // RVA: 0x7ADEFC710
    public void ReadAsVector2(){} // RVA: 0x7ADEFC960
    public void ReadAsVector3(){} // RVA: 0x7ADEFCC20
    public void ReadAsVector4(){} // RVA: 0x7ADEFD0C0
    public void ReadAsColor(){} // RVA: 0x7ADEFD610
    public void ReadAsMatrix4x4(){} // RVA: 0x7ADEFDC20
    public void ReadAsKtxTexture(){} // RVA: 0x7ADEFE0B0
    public void ReadAsBoneWeights(){} // RVA: 0x7ADEFE1F0
    public void GetStrideForType(){} // RVA: 0x7ADEFE6C0
    public void GetMaxValueForType(){} // RVA: 0x7ADEFE720
    public void ReadElementAsUint(){} // RVA: 0x7ADEFE7A0
    public void ReadElementAsFloat(){} // RVA: 0x7ADEFEA40
    public void byteOffset(){} // RVA: 0x7B2E3DEC0
}

public class OVRGLTFLoader : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF01A20
    public void LoadGLB(){} // RVA: 0x7ADF01B00
    public void SetModelShader(){} // RVA: 0x7A8152D90
    public void SetModelAlphaBlendShader(){} // RVA: 0x7A8230620
    public void SetTextureQualityFiltering(){} // RVA: 0x7A87A7CF0
    public void SetMipMapBias(){} // RVA: 0x7ADF02580
    public void DetectTextureQuality(){} // RVA: 0x7ADF025B0
    public void ApplyTextureQuality(){} // RVA: 0x7ADF02730
    public void ValidateGLB(){} // RVA: 0x7ADF028B0
    public void ReadChunk(){} // RVA: 0x7ADF02B10
    public void ValidateChunk(){} // RVA: 0x7ADF02BE0
    public void LoadGLTF(){} // RVA: 0x7ADF02D60
    public void ProcessNode(){} // RVA: 0x7ADF03490
    public void ProcessMesh(){} // RVA: 0x7ADF04660
    public void FlipTraingleIndices(){} // RVA: 0x7ADF06460
    public void ProcessSkin(){} // RVA: 0x7ADF064F0
    public void ProcessMaterial(){} // RVA: 0x7ADF06C40
    public void ProcessTexture(){} // RVA: 0x7ADF06F60
    public void TranscodeTexture(){} // RVA: 0x7ADF075B0
    public void CreateUnityMaterial(){} // RVA: 0x7ADF07630
    public void GetInputNodeType(){} // RVA: 0x7ADF07830
    public void ProcessAnimations(){} // RVA: 0x7ADF07A40
    public void .cctor(){} // RVA: 0x7ADF082F0
    // ── Unresolved (hash) ──
    public void m_jsonData(){} // RVA: 0x7B3FAD508
}

public class OVRHaptics : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7ADF087D0
    public void Process(){} // RVA: 0x7ADF08BE0
}

public class OVRHapticsChannel : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF09550
    public void Preempt(){} // RVA: 0x7ADF09620
    public void Queue(){} // RVA: 0x7ADF09740
    public void Mix(){} // RVA: 0x7ADF09820
    public void Clear(){} // RVA: 0x7ADF09840
}

public class OVRHapticsClip : Object
{
    // ── Methods ──
    public void get_Count(){} // RVA: 0x7A8124910
    public void set_Count(){} // RVA: 0x7A80DA0C0
    public void get_Capacity(){} // RVA: 0x7A8668BC0
    public void set_Capacity(){} // RVA: 0x7A8669360
    public void get_Samples(){} // RVA: 0x7A80DA7B0
    public void set_Samples(){} // RVA: 0x7A813E420
    public void .ctor(){} // RVA: 0x7ADF0B550
    public void WriteSample(){} // RVA: 0x7ADF0B720
    public void Reset(){} // RVA: 0x7A881ACE0
    public void InitializeFromAudioFloatTrack(){} // RVA: 0x7ADF0B7E0
    public void <Count>k__BackingField(){} // RVA: 0x7B3FB4328
}

public class OVRHapticsOutput : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF098B0
    public void Process(){} // RVA: 0x7ADF09C90
    public void Preempt(){} // RVA: 0x7ADF0A6E0
    public void Queue(){} // RVA: 0x7ADF0A7F0
    public void Mix(){} // RVA: 0x7ADF0A8C0
    public void Clear(){} // RVA: 0x7ADF0AF00
}

public class OVRInput : Object
{
    // ── Methods ──
    public void get_pluginSupportsActiveController(){} // RVA: 0x7ADF0C620
    public void .cctor(){} // RVA: 0x7ADF0C760
    public void Update(){} // RVA: 0x7ADF0CDF0
    public void FixedUpdate(){} // RVA: 0x7ADF0D7A0
    public void GetCurrentInteractionProfile(){} // RVA: 0x7ADF0DAB0
    public void GetControllerOrientationTracked(){} // RVA: 0x7ADF0DC90
    public void GetControllerOrientationValid(){} // RVA: 0x7ADF0DD30
    public void GetControllerPositionTracked(){} // RVA: 0x7ADF0DDD0
    public void GetControllerPositionValid(){} // RVA: 0x7ADF0DEE0
    public void GetLocalControllerPosition(){} // RVA: 0x7ADF0DF80
    public void GetLocalControllerVelocity(){} // RVA: 0x7ADF0E380
    public void GetLocalControllerAcceleration(){} // RVA: 0x7ADF0E5D0
    public void GetLocalControllerRotation(){} // RVA: 0x7ADF0E810
    public void GetLocalControllerAngularVelocity(){} // RVA: 0x7ADF0EC00
    public void GetLocalControllerAngularAcceleration(){} // RVA: 0x7ADF0EE50
    public void GetLocalControllerStatesWithoutPrediction(){} // RVA: 0x7ADF0F0A0
    public void GetDominantHand(){} // RVA: 0x7ADF0F540
    public void Get(){} // RVA: 0x7ADF116F0
    public void GetResolvedButton(){} // RVA: 0x7ADF0F7E0
    public void GetDown(){} // RVA: 0x7ADF10A20
    public void GetResolvedButtonDown(){} // RVA: 0x7ADF0FA80
    public void GetUp(){} // RVA: 0x7ADF10CD0
    public void GetResolvedButtonUp(){} // RVA: 0x7ADF0FD30
    public void GetResolvedTouch(){} // RVA: 0x7ADF0FFE0
    public void GetResolvedTouchDown(){} // RVA: 0x7ADF10280
    public void GetResolvedTouchUp(){} // RVA: 0x7ADF10530
    public void GetResolvedNearTouch(){} // RVA: 0x7ADF107E0
    public void GetResolvedNearTouchDown(){} // RVA: 0x7ADF10A80
    public void GetResolvedNearTouchUp(){} // RVA: 0x7ADF10D30
    public void GetResolvedAxis1D(){} // RVA: 0x7ADF10FE0
    public void GetResolvedAxis2D(){} // RVA: 0x7ADF11750
    public void GetConnectedControllers(){} // RVA: 0x7ADF11B80
    public void IsControllerConnected(){} // RVA: 0x7ADF11BE0
    public void GetActiveController(){} // RVA: 0x7ADF11C40
    public void StartVibration(){} // RVA: 0x7ADF11CA0
    public void SetOpenVRLocalPose(){} // RVA: 0x7ADF11EB0
    public void GetOpenVRStringProperty(){} // RVA: 0x7ADF11FE0
    public void UpdateXRControllerNodeIds(){} // RVA: 0x7ADF121B0
    public void UpdateXRControllerHaptics(){} // RVA: 0x7ADF12710
    public void InitHapticInfo(){} // RVA: 0x7ADF12950
    public void PlayHapticImpulse(){} // RVA: 0x7ADF12BA0
    public void IsValidOpenVRDevice(){} // RVA: 0x7ADF12D20
    public void SetControllerVibration(){} // RVA: 0x7ADF12D30
    public void SetControllerLocalizedVibration(){} // RVA: 0x7ADF12FC0
    public void GetControllerBatteryPercentRemaining(){} // RVA: 0x7ADF13240
    public void CalculateAbsMax(){} // RVA: 0x7ADF13450
    public void CalculateDeadzone(){} // RVA: 0x7ADF13590
    public void ShouldResolveController(){} // RVA: 0x7ADF135F0
}

public class OVRKtxTexture : Object
{
    // ── Methods ──
    public void Load(){} // RVA: 0x7ADF16930
    public void .ctor(){} // RVA: 0x7A80D7310
    public void KTX_TTF_BC7_RGBA(){} // RVA: 0x7B2E3DEC0
}

public class OVRLayerAttribute : PropertyAttribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class OVRMixedReality : Object
{
    // ── Methods ──
    public void Update(){} // RVA: 0x7ADF28A70
    public void Cleanup(){} // RVA: 0x7ADF293C0
    public void RecenterPose(){} // RVA: 0x7ADF29690
    public void .cctor(){} // RVA: 0x7ADF29730
}

public class OVRNetwork : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class OVRNetworkTcpClient : Object
{
    // ── Methods ──
    public void get_connectionState(){} // RVA: 0x7ADF9FB20
    public void get_Connected(){} // RVA: 0x7ADF9FB60
    public void Connect(){} // RVA: 0x7ADF9FBB0
    public void ConnectCallback(){} // RVA: 0x7ADF9FD90
    public void Disconnect(){} // RVA: 0x7ADFA0030
    public void Tick(){} // RVA: 0x7ADFA02C0
    public void OnReadDataCallback(){} // RVA: 0x7ADFA0510
    public void .ctor(){} // RVA: 0x7ADFA0990
}

public class OVRP_0_1_0 : Object
{
    // ── Methods ──
    public void ovrp_GetEyeTextureSize(){} // RVA: 0x7ADF62CD0
    public void .cctor(){} // RVA: 0x7ADF62D50
}

public class OVRP_0_1_1 : Object
{
    // ── Methods ──
    public void ovrp_SetOverlayQuad2(){} // RVA: 0x7ADF62E20
    public void .cctor(){} // RVA: 0x7ADF62F20
}

public class OVRP_0_1_2 : Object
{
    // ── Methods ──
    public void ovrp_GetNodePose(){} // RVA: 0x7ADF62FF0
    public void ovrp_SetControllerVibration(){} // RVA: 0x7ADF63090
    public void .cctor(){} // RVA: 0x7ADF63130
}

public class OVRP_0_1_3 : Object
{
    // ── Methods ──
    public void ovrp_GetNodeVelocity(){} // RVA: 0x7ADF63200
    public void ovrp_GetNodeAcceleration(){} // RVA: 0x7ADF632A0
    public void .cctor(){} // RVA: 0x7ADF63340
}

public class OVRP_0_5_0 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7ADF63410
}

public class OVRP_1_0_0 : Object
{
    // ── Methods ──
    public void ovrp_GetTrackingOriginType(){} // RVA: 0x7ADF634E0
    public void ovrp_SetTrackingOriginType(){} // RVA: 0x7ADF63550
    public void ovrp_GetTrackingCalibratedOrigin(){} // RVA: 0x7ADF635D0
    public void ovrp_RecenterTrackingOrigin(){} // RVA: 0x7ADF63660
    public void .cctor(){} // RVA: 0x7ADF636E0
}

public class OVRP_1_10_0 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7ADF66C50
}

public class OVRP_1_11_0 : Object
{
    // ── Methods ──
    public void ovrp_SetDesiredEyeTextureFormat(){} // RVA: 0x7ADF66D20
    public void ovrp_GetDesiredEyeTextureFormat(){} // RVA: 0x7ADF66DA0
    public void .cctor(){} // RVA: 0x7ADF66E10
}

public class OVRP_1_12_0 : Object
{
    // ── Methods ──
    public void ovrp_GetAppFramerate(){} // RVA: 0x7ADF66EE0
    public void ovrp_GetNodePoseState(){} // RVA: 0x7ADF66F50
    public void ovrp_GetControllerState2(){} // RVA: 0x7ADF67020
    public void .cctor(){} // RVA: 0x7ADF670D0
}

public class OVRP_1_15_0 : Object
{
    // ── Methods ──
    public void ovrp_InitializeMixedReality(){} // RVA: 0x7ADF671A0
    public void ovrp_ShutdownMixedReality(){} // RVA: 0x7ADF67210
    public void ovrp_GetMixedRealityInitialized(){} // RVA: 0x7ADF67280
    public void ovrp_UpdateExternalCamera(){} // RVA: 0x7ADF672F0
    public void ovrp_GetExternalCameraCount(){} // RVA: 0x7ADF67360
    public void ovrp_GetExternalCameraName(){} // RVA: 0x7ADF673E0
    public void ovrp_GetExternalCameraIntrinsics(){} // RVA: 0x7ADF674E0
    public void ovrp_GetExternalCameraExtrinsics(){} // RVA: 0x7ADF67570
    public void ovrp_CalculateLayerDesc(){} // RVA: 0x7ADF67600
    public void ovrp_EnqueueSetupLayer(){} // RVA: 0x7ADF676A0
    public void ovrp_EnqueueDestroyLayer(){} // RVA: 0x7ADF67730
    public void ovrp_GetLayerTextureStageCount(){} // RVA: 0x7ADF677B0
    public void ovrp_GetLayerTexturePtr(){} // RVA: 0x7ADF67840
    public void ovrp_EnqueueSubmitLayer(){} // RVA: 0x7ADF678E0
    public void ovrp_GetNodeFrustum2(){} // RVA: 0x7ADF67990
    public void ovrp_GetEyeTextureArrayEnabled(){} // RVA: 0x7ADF67A20
    public void .cctor(){} // RVA: 0x7ADF67A90
}

public class OVRP_1_16_0 : Object
{
    // ── Methods ──
    public void ovrp_UpdateCameraDevices(){} // RVA: 0x7ADF67B60
    public void ovrp_IsCameraDeviceAvailable(){} // RVA: 0x7ADF67BD0
    public void ovrp_SetCameraDevicePreferredColorFrameSize(){} // RVA: 0x7ADF67C50
    public void ovrp_OpenCameraDevice(){} // RVA: 0x7ADF67CE0
    public void ovrp_CloseCameraDevice(){} // RVA: 0x7ADF67D60
    public void ovrp_HasCameraDeviceOpened(){} // RVA: 0x7ADF67DE0
    public void ovrp_IsCameraDeviceColorFrameAvailable(){} // RVA: 0x7ADF67E60
    public void ovrp_GetCameraDeviceColorFrameSize(){} // RVA: 0x7ADF67EE0
    public void ovrp_GetCameraDeviceColorFrameBgraPixels(){} // RVA: 0x7ADF67F70
    public void ovrp_GetControllerState4(){} // RVA: 0x7ADF68010
    public void .cctor(){} // RVA: 0x7ADF680A0
}

public class OVRP_1_17_0 : Object
{
    // ── Methods ──
    public void ovrp_GetExternalCameraPose(){} // RVA: 0x7ADF68170
    public void ovrp_ConvertPoseToCameraSpace(){} // RVA: 0x7ADF68200
    public void ovrp_GetCameraDeviceIntrinsicsParameters(){} // RVA: 0x7ADF682A0
    public void ovrp_DoesCameraDeviceSupportDepth(){} // RVA: 0x7ADF68340
    public void ovrp_GetCameraDeviceDepthSensingMode(){} // RVA: 0x7ADF683D0
    public void ovrp_SetCameraDeviceDepthSensingMode(){} // RVA: 0x7ADF68460
    public void ovrp_GetCameraDevicePreferredDepthQuality(){} // RVA: 0x7ADF684F0
    public void ovrp_SetCameraDevicePreferredDepthQuality(){} // RVA: 0x7ADF68580
    public void ovrp_IsCameraDeviceDepthFrameAvailable(){} // RVA: 0x7ADF68610
    public void ovrp_GetCameraDeviceDepthFrameSize(){} // RVA: 0x7ADF686A0
    public void ovrp_GetCameraDeviceDepthFramePixels(){} // RVA: 0x7ADF68730
    public void ovrp_GetCameraDeviceDepthConfidencePixels(){} // RVA: 0x7ADF687D0
    public void .cctor(){} // RVA: 0x7ADF68870
}

public class OVRP_1_18_0 : Object
{
    // ── Methods ──
    public void ovrp_SetHandNodePoseStateLatency(){} // RVA: 0x7ADF68940
    public void ovrp_GetHandNodePoseStateLatency(){} // RVA: 0x7ADF689C0
    public void ovrp_GetAppHasInputFocus(){} // RVA: 0x7ADF68A40
    public void .cctor(){} // RVA: 0x7ADF68AC0
}

public class OVRP_1_19_0 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7ADF68B90
}

public class OVRP_1_1_0 : Object
{
    // ── Methods ──
    public void ovrp_GetInitialized(){} // RVA: 0x7ADF637B0
    public void _ovrp_GetVersion(){} // RVA: 0x7ADF63820
    public void ovrp_GetVersion(){} // RVA: 0x7ADF63890
    public void _ovrp_GetNativeSDKVersion(){} // RVA: 0x7ADF63990
    public void ovrp_GetNativeSDKVersion(){} // RVA: 0x7ADF63A00
    public void ovrp_GetAudioOutId(){} // RVA: 0x7ADF63B00
    public void ovrp_GetAudioInId(){} // RVA: 0x7ADF63B70
    public void ovrp_GetEyeTextureScale(){} // RVA: 0x7ADF63BE0
    public void ovrp_SetEyeTextureScale(){} // RVA: 0x7ADF63C50
    public void ovrp_GetTrackingOrientationSupported(){} // RVA: 0x7ADF63CD0
    public void ovrp_GetTrackingOrientationEnabled(){} // RVA: 0x7ADF63D40
    public void ovrp_SetTrackingOrientationEnabled(){} // RVA: 0x7ADF63DB0
    public void ovrp_GetTrackingPositionSupported(){} // RVA: 0x7ADF63E30
    public void ovrp_GetTrackingPositionEnabled(){} // RVA: 0x7ADF63EA0
    public void ovrp_SetTrackingPositionEnabled(){} // RVA: 0x7ADF63F10
    public void ovrp_GetNodePresent(){} // RVA: 0x7ADF63F90
    public void ovrp_GetNodeOrientationTracked(){} // RVA: 0x7ADF64010
    public void ovrp_GetNodePositionTracked(){} // RVA: 0x7ADF64090
    public void ovrp_GetNodeFrustum(){} // RVA: 0x7ADF64110
    public void ovrp_GetControllerState(){} // RVA: 0x7ADF641A0
    public void ovrp_GetSystemCpuLevel(){} // RVA: 0x7ADF64240
    public void ovrp_SetSystemCpuLevel(){} // RVA: 0x7ADF642B0
    public void ovrp_GetSystemGpuLevel(){} // RVA: 0x7ADF64330
    public void ovrp_SetSystemGpuLevel(){} // RVA: 0x7ADF643A0
    public void ovrp_GetSystemPowerSavingMode(){} // RVA: 0x7ADF64420
    public void ovrp_GetSystemDisplayFrequency(){} // RVA: 0x7ADF64490
    public void ovrp_GetSystemVSyncCount(){} // RVA: 0x7ADF64500
    public void ovrp_GetSystemVolume(){} // RVA: 0x7ADF64570
    public void ovrp_GetSystemBatteryStatus(){} // RVA: 0x7ADF645E0
    public void ovrp_GetSystemBatteryLevel(){} // RVA: 0x7ADF64650
    public void ovrp_GetSystemBatteryTemperature(){} // RVA: 0x7ADF646C0
    public void _ovrp_GetSystemProductName(){} // RVA: 0x7ADF64730
    public void ovrp_GetSystemProductName(){} // RVA: 0x7ADF647A0
    public void ovrp_ShowSystemUI(){} // RVA: 0x7ADF648A0
    public void ovrp_GetAppMonoscopic(){} // RVA: 0x7ADF64920
    public void ovrp_SetAppMonoscopic(){} // RVA: 0x7ADF64990
    public void ovrp_GetAppHasVrFocus(){} // RVA: 0x7ADF64A10
    public void ovrp_GetAppShouldQuit(){} // RVA: 0x7ADF64A80
    public void ovrp_GetAppShouldRecenter(){} // RVA: 0x7ADF64AF0
    public void _ovrp_GetAppLatencyTimings(){} // RVA: 0x7ADF64B60
    public void ovrp_GetAppLatencyTimings(){} // RVA: 0x7ADF64BD0
    public void ovrp_GetUserPresent(){} // RVA: 0x7ADF64CD0
    public void ovrp_GetUserIPD(){} // RVA: 0x7ADF64D40
    public void ovrp_SetUserIPD(){} // RVA: 0x7ADF64DB0
    public void ovrp_GetUserEyeDepth(){} // RVA: 0x7ADF64E30
    public void ovrp_SetUserEyeDepth(){} // RVA: 0x7ADF64EA0
    public void ovrp_GetUserEyeHeight(){} // RVA: 0x7ADF64F20
    public void ovrp_SetUserEyeHeight(){} // RVA: 0x7ADF64F90
    public void .cctor(){} // RVA: 0x7ADF65010
}

public class OVRP_1_21_0 : Object
{
    // ── Methods ──
    public void ovrp_GetTiledMultiResSupported(){} // RVA: 0x7ADF68C60
    public void ovrp_GetTiledMultiResLevel(){} // RVA: 0x7ADF68CE0
    public void ovrp_SetTiledMultiResLevel(){} // RVA: 0x7ADF68D60
    public void ovrp_GetGPUUtilSupported(){} // RVA: 0x7ADF68DE0
    public void ovrp_GetGPUUtilLevel(){} // RVA: 0x7ADF68E60
    public void ovrp_GetSystemDisplayFrequency2(){} // RVA: 0x7ADF68EE0
    public void ovrp_GetSystemDisplayAvailableFrequencies(){} // RVA: 0x7ADF68F60
    public void ovrp_SetSystemDisplayFrequency(){} // RVA: 0x7ADF68FF0
    public void ovrp_GetAppAsymmetricFov(){} // RVA: 0x7ADF69070
    public void .cctor(){} // RVA: 0x7ADF690F0
}

public class OVRP_1_2_0 : Object
{
    // ── Methods ──
    public void ovrp_SetSystemVSyncCount(){} // RVA: 0x7ADF650E0
    public void ovrpi_SetTrackingCalibratedOrigin(){} // RVA: 0x7ADF65160
    public void .cctor(){} // RVA: 0x7ADF651D0
}

public class OVRP_1_3_0 : Object
{
    // ── Methods ──
    public void ovrp_GetEyeOcclusionMeshEnabled(){} // RVA: 0x7ADF652A0
    public void ovrp_SetEyeOcclusionMeshEnabled(){} // RVA: 0x7ADF65310
    public void ovrp_GetSystemHeadphonesPresent(){} // RVA: 0x7ADF65390
    public void .cctor(){} // RVA: 0x7ADF65400
}

public class OVRP_1_5_0 : Object
{
    // ── Methods ──
    public void ovrp_GetSystemRegion(){} // RVA: 0x7ADF654D0
    public void .cctor(){} // RVA: 0x7ADF65540
}

public class OVRP_1_6_0 : Object
{
    // ── Methods ──
    public void ovrp_GetTrackingIPDEnabled(){} // RVA: 0x7ADF65610
    public void ovrp_SetTrackingIPDEnabled(){} // RVA: 0x7ADF65680
    public void ovrp_GetControllerHapticsDesc(){} // RVA: 0x7ADF65700
    public void ovrp_GetControllerHapticsState(){} // RVA: 0x7ADF657A0
    public void ovrp_SetControllerHaptics(){} // RVA: 0x7ADF65820
    public void ovrp_SetOverlayQuad3(){} // RVA: 0x7ADF658B0
    public void ovrp_GetEyeRecommendedResolutionScale(){} // RVA: 0x7ADF659C0
    public void ovrp_GetAppCpuStartToGpuEndTime(){} // RVA: 0x7ADF65A30
    public void ovrp_GetSystemRecommendedMSAALevel(){} // RVA: 0x7ADF65AA0
    public void .cctor(){} // RVA: 0x7ADF65B10
}

public class OVRP_1_7_0 : Object
{
    // ── Methods ──
    public void ovrp_GetAppChromaticCorrection(){} // RVA: 0x7ADF65BE0
    public void ovrp_SetAppChromaticCorrection(){} // RVA: 0x7ADF65C50
    public void .cctor(){} // RVA: 0x7ADF65CD0
}

public class OVRP_1_8_0 : Object
{
    // ── Methods ──
    public void ovrp_GetBoundaryConfigured(){} // RVA: 0x7ADF65DA0
    public void ovrp_TestBoundaryNode(){} // RVA: 0x7ADF65E10
    public void ovrp_TestBoundaryPoint(){} // RVA: 0x7ADF65EC0
    public void ovrp_GetBoundaryGeometry(){} // RVA: 0x7ADF65F80
    public void ovrp_GetBoundaryDimensions(){} // RVA: 0x7ADF66170
    public void ovrp_GetBoundaryVisible(){} // RVA: 0x7ADF66210
    public void ovrp_SetBoundaryVisible(){} // RVA: 0x7ADF66280
    public void ovrp_Update2(){} // RVA: 0x7ADF66300
    public void ovrp_GetNodePose2(){} // RVA: 0x7ADF663A0
    public void ovrp_GetNodeVelocity2(){} // RVA: 0x7ADF66450
    public void ovrp_GetNodeAcceleration2(){} // RVA: 0x7ADF66500
    public void .cctor(){} // RVA: 0x7ADF665B0
}

public class OVRP_1_9_0 : Object
{
    // ── Methods ──
    public void ovrp_GetSystemHeadsetType(){} // RVA: 0x7ADF66680
    public void ovrp_GetActiveController(){} // RVA: 0x7ADF666F0
    public void ovrp_GetConnectedControllers(){} // RVA: 0x7ADF66760
    public void ovrp_GetBoundaryGeometry2(){} // RVA: 0x7ADF667D0
    public void ovrp_GetAppPerfStats(){} // RVA: 0x7ADF66870
    public void ovrp_ResetAppPerfStats(){} // RVA: 0x7ADF66B10
    public void .cctor(){} // RVA: 0x7ADF66B80
}

public class OVRPermissionsRequester : Object
{
    // ── Methods ──
    public void add_PermissionGranted(){} // RVA: 0x7ADF37AA0
    public void remove_PermissionGranted(){} // RVA: 0x7ADF37BD0
    public void GetPermissionId(){} // RVA: 0x7ADF37D00
    public void IsPermissionSupportedByPlatform(){} // RVA: 0x7ADF37E00
    public void IsPermissionGranted(){} // RVA: 0x7A81BD750
    public void Request(){} // RVA: 0x7A80D7310
    public void ShouldRequestPermission(){} // RVA: 0x7ADF383B0
}

public class OVRTouchpadHelper[] : Array
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

public class ObjectValueCollection : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B1642D80
    public void get_Count(){} // RVA: 0x7B1642E40
    public void get_Item(){} // RVA: 0x7B1642E90
    public void set_Item(){} // RVA: 0x7B1642F80
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0x7B1642FC0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7B16430D0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7B16431E0
    public void System.Collections.IList.get_Item(){} // RVA: 0x7B1643220
    public void System.Collections.IList.set_Item(){} // RVA: 0x7B1643330
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void get_SyncRoot(){} // RVA: 0x7B1643370
    public void get_IsSynchronized(){} // RVA: 0x7A80D7320
    public void get_IsFixedSize(){} // RVA: 0x7A81BD750
    public void Contains(){} // RVA: 0x7B1643430
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7B16434E0
    public void CopyTo(){} // RVA: 0x7B16439B0
    public void Add(){} // RVA: 0x7B1643C40
    public void System.Collections.IList.Add(){} // RVA: 0x7B1643C80
    public void Clear(){} // RVA: 0x7B1643CC0
    public void Remove(){} // RVA: 0x7B1643D40
    public void System.Collections.IList.Remove(){} // RVA: 0x7B1643D80
    public void Insert(){} // RVA: 0x7B1643E00
    public void RemoveAt(){} // RVA: 0x7B1643E40
    public void GetEnumerator(){} // RVA: 0x7B1643E80
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7B1643ED0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7B1643F10
    public void IndexOf(){} // RVA: 0x7B1644050
}

public class ObserverState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AECBD1C0
    public void <.ctor>b__2_0(){} // RVA: 0x7AECBD280
}

public class OnCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81577F0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class OnCapturedToDiskCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnCapturedToMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C5EEB0
    public void Invoke(){} // RVA: 0x7A9C5EF80
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEDCD4F0
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF28FB50
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B188B790
}

public class OnDecodeError : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF431F50
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7AF432040
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class OnOverrideControllerDirtyCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8135E00
    public void Invoke(){} // RVA: 0x7A8135ED0
}

public class OnPerformCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEF37910
    public void Invoke(){} // RVA: 0x7AEF37A80
}

public class OnPhotoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnPhotoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnScreenDeviceInfo : ValueType
{
    // ── Methods ──
    public void AddControl(){} // RVA: 0x7A7EB60C0
    public void RemoveControl(){} // RVA: 0x7A7EB6100
    public void Destroy(){} // RVA: 0x7A7EB6140
}

public class OnStartedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C64CD0
    public void Invoke(){} // RVA: 0x7A8234660
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C5EDE0
    public void Invoke(){} // RVA: 0x7A89D0820
}

public class OnStoppedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEDCD310
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7AF28FA20
    public void EndInvoke(){} // RVA: 0x7AB1565B0
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEDCD310
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7AEDCD400
    public void EndInvoke(){} // RVA: 0x7AB1565B0
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEDCD310
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7B188B6A0
    public void EndInvoke(){} // RVA: 0x7AB1565B0
}

public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81577F0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class OnVideoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class OnVideoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AA9881C0
    public void Invoke(){} // RVA: 0x7AA988290
}

public class Op : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEAB42F0
}

public class OpacityIdUpdateJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7EFF220
}

public class Operator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEEAA150
}

public class OptionData : Object
{
    // ── Methods ──
    public void get_text(){} // RVA: 0x7A80F2570
    public void set_text(){} // RVA: 0x7A80D8E20
    public void get_image(){} // RVA: 0x7A80DA7B0
    public void set_image(){} // RVA: 0x7A813E420
    public void .ctor(){} // RVA: 0x7A8CE4080
}

public class OptionData : Object
{
    // ── Methods ──
    public void get_text(){} // RVA: 0x7A80F2570
    public void set_text(){} // RVA: 0x7A80D8E20
    public void get_image(){} // RVA: 0x7A80DA7B0
    public void set_image(){} // RVA: 0x7A813E420
    public void .ctor(){} // RVA: 0x7A8CE4080
}

public class OptionDataList : Object
{
    // ── Methods ──
    public void get_options(){} // RVA: 0x7A80F2570
    public void set_options(){} // RVA: 0x7A80D8E20
    public void .ctor(){} // RVA: 0x7AF0AC7C0
}

public class OptionDataList : Object
{
    // ── Methods ──
    public void get_options(){} // RVA: 0x7A80F2570
    public void set_options(){} // RVA: 0x7A80D8E20
    public void .ctor(){} // RVA: 0x7AED8B8D0
}

public class OptionData[] : Array
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

public class OptionData[] : Array
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

public class Option[] : Array
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

public class OptionsAndroid : PlatformOptions
{
    // ── Methods ──
    public void get_preferredMaximumResolution(){} // RVA: 0x7A8AB15F0
    public void set_preferredMaximumResolution(){} // RVA: 0x7A9A9BA40
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7A8105330
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7A9A9BA50
    public void get_preferredPeakBitRate(){} // RVA: 0x7A8261690
    public void set_preferredPeakBitRate(){} // RVA: 0x7A9A9BA80
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7A82C2070
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7A9A9BAA0
    public void IsModified(){} // RVA: 0x7A9A9BAB0
    public void BitRateInBitsPerSecond(){} // RVA: 0x7A9A9B880
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7A9A9BB50
    public void StartWithHighestBandwidth(){} // RVA: 0x7A89A1A40
    public void HasChanged(){} // RVA: 0x7A9A9BB90
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A9A9BBB0
    public void .ctor(){} // RVA: 0x7A9A9BBD0
}

public class OptionsApple : PlatformOptions
{
    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x7A8F9ACE0
    public void get_audioMode(){} // RVA: 0x7A8133100
    public void set_audioMode(){} // RVA: 0x7A9A9B780
    public void get_flags(){} // RVA: 0x7A82C2070
    public void set_flags(){} // RVA: 0x7A9A9B7A0
    public void get_preferredPeakBitRate(){} // RVA: 0x7A85D5650
    public void set_preferredPeakBitRate(){} // RVA: 0x7A9A9B7D0
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7A8178B50
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7A9A9B7F0
    public void get_preferredForwardBufferDuration(){} // RVA: 0x7A9A9B800
    public void set_preferredForwardBufferDuration(){} // RVA: 0x7A9A9B810
    public void get_preferredMaximumResolution(){} // RVA: 0x7A8355950
    public void set_preferredMaximumResolution(){} // RVA: 0x7A9A9B830
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7A9A9B840
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7A9A9B850
    public void BitRateInBitsPerSecond(){} // RVA: 0x7A9A9B880
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7A9A9B8C0
    public void .ctor(){} // RVA: 0x7A9A9B900
    public void IsModified(){} // RVA: 0x7A9A9B9C0
    public void HasChanged(){} // RVA: 0x7A9A9BA20
    public void ClearChanges(){} // RVA: 0x7A9A9BA30
}

public class OptionsWebGL : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7A9A9BC50
    public void GetKeyServerAuthToken(){} // RVA: 0x7A82D1450
    public void GetOverrideDecryptionKey(){} // RVA: 0x7A82D1450
    public void .ctor(){} // RVA: 0x7A9A9BC80
}

public class OptionsWindows : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7A9A9B480
    public void StartWithHighestBandwidth(){} // RVA: 0x7A8192400
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A9A9B570
    public void .ctor(){} // RVA: 0x7A9A9B5A0
}

public class OptionsWindowsUWP : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7A9A9B700
    public void StartWithHighestBandwidth(){} // RVA: 0x7A810DDD0
    public void .ctor(){} // RVA: 0x7A9A9B760
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}

public class OutputEventArgs : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A760FA90
}
