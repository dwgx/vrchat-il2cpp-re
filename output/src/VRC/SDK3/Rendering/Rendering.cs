// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Rendering
// Classes: 4
// Methods: 79

namespace VRC.SDK3.Rendering
{
    public class VRCAsyncGPUReadback : Object
    {
        // ── Methods ──
        public void Request(){} // RVA: 0xA6BF050
    }

    public class VRCAsyncGPUReadbackRequest : Object
    {
        public object Request;
        public object UdonBehaviour;

        // ── Methods ──
        public void get_done(){} // RVA: 0x110F620
        public void get_hasError(){} // RVA: 0xA6BF1D0
        public void get_width(){} // RVA: 0xA6BF220
        public void get_height(){} // RVA: 0xA6BF270
        public void get_depth(){} // RVA: 0xA6BF2C0
        public void get_layerCount(){} // RVA: 0xA6BF310
        public void get_layerDataSize(){} // RVA: 0xA6BF360
        public void .ctor(){} // RVA: 0xB43310
        public void HandleCallback(){} // RVA: 0xA6BF3B0
        public void TryGetData(){} // RVA: 0x87FE70
    }

    public class VRCCameraSettings : Object
    {
        public object OnCameraSettingsChanged;
        public object GetCameraMode;
        public object _screenCamera;
        public object _photoCamera;
        public object _targetCamera;
        public object TransformGetter;
        public object HasChangedFarClipPlane;
        public object _layerCullSphericalFake;
        public object _layerCullSphericalWarningDisplayed;
        public object _defaultLayerCullDistances;
        public object _excludedLayers;

        // ── Methods ──
        public void get_ScreenCamera(){} // RVA: 0xA6BF6D0
        public void set_ScreenCamera(){} // RVA: 0xA6BF730
        public void get_ScreenCameraRef(){} // RVA: 0xA6BF7F0
        public void set_ScreenCameraRef(){} // RVA: 0xA6BF890
        public void get_PhotoCamera(){} // RVA: 0xA6BF9A0
        public void set_PhotoCamera(){} // RVA: 0xA6BFA00
        public void get_PhotoCameraRef(){} // RVA: 0xA6BFAC0
        public void set_PhotoCameraRef(){} // RVA: 0xA6BFB60
        public void .ctor(){} // RVA: 0xA6BFC70
        public void get_CameraMode(){} // RVA: 0xA6BFD90
        public void get_Position(){} // RVA: 0xA6BFDB0
        public void get_Rotation(){} // RVA: 0xA6BFF00
        public void get_Forward(){} // RVA: 0xA6C0040
        public void get_Up(){} // RVA: 0xA6C00F0
        public void get_Right(){} // RVA: 0xA6C01A0
        public void get_PixelWidth(){} // RVA: 0xA6C0250
        public void get_PixelHeight(){} // RVA: 0xA6C02F0
        public void get_FieldOfView(){} // RVA: 0xA6C0390
        public void get_Aspect(){} // RVA: 0xA6C0430
        public void get_Active(){} // RVA: 0xA6C04D0
        public void get_StereoEnabled(){} // RVA: 0xA6C05A0
        public void get_NearClipPlane(){} // RVA: 0xA6C0640
        public void set_NearClipPlane(){} // RVA: 0xA6C06E0
        public void get_FarClipPlane(){} // RVA: 0xA6C0780
        public void set_FarClipPlane(){} // RVA: 0xA6C0820
        public void get_ClearFlags(){} // RVA: 0xA6C08C0
        public void set_ClearFlags(){} // RVA: 0xA6C0960
        public void get_BackgroundColor(){} // RVA: 0xA6C0A00
        public void set_BackgroundColor(){} // RVA: 0xA6C0AD0
        public void get_AllowHDR(){} // RVA: 0xA6C0BF0
        public void set_AllowHDR(){} // RVA: 0xA6C0C90
        public void get_DepthTextureMode(){} // RVA: 0xA6C0D30
        public void set_DepthTextureMode(){} // RVA: 0xA6C0DD0
        public void get_UseOcclusionCulling(){} // RVA: 0xA6C0F90
        public void set_UseOcclusionCulling(){} // RVA: 0xA6C1030
        public void get_AllowMSAA(){} // RVA: 0xA6C10D0
        public void set_AllowMSAA(){} // RVA: 0xA6C1170
        public void get_CullingMask(){} // RVA: 0xA6C1210
        public void set_CullingMask(){} // RVA: 0xA6C12B0
        public void get_LayerCullDistances(){} // RVA: 0xA6C1550
        public void set_LayerCullDistances(){} // RVA: 0xA6C1570
        public void get_LayerCullSpherical(){} // RVA: 0x14F7430
        public void set_LayerCullSpherical(){} // RVA: 0xA6C1610
        public void OnExitWorld(){} // RVA: 0xA6C16F0
        public void GetEyePosition(){} // RVA: 0xA6C1760
        public void GetEyeRotation(){} // RVA: 0xA6C1D50
        public void GetCurrentCamera(){} // RVA: 0xA6C2360
        public void Equals(){} // RVA: 0xA6C2790
        public void GetHashCode(){} // RVA: 0xA6C2930
        public void ToString(){} // RVA: 0xA6C2A30
        public void SetLayerCullDistances(){} // RVA: 0xA6C2C30
        public void SetCullingMask(){} // RVA: 0xA6C2EC0
        public void .cctor(){} // RVA: 0xA6C3020
        public void <.ctor>b__16_0(){} // RVA: 0x7D18B20
    }

    public class VRCQualitySettings : Object
    {
        public object SetShadowDistanceInternal;
        public object SetShadowDistanceInternalAll;
        public object ResetShadowDistanceInternal;

        // ── Methods ──
        public void get_AntiAliasing(){} // RVA: 0x7B82F00
        public void get_PixelLightCount(){} // RVA: 0x7B828D0
        public void get_LODBias(){} // RVA: 0x7B82CC0
        public void get_MaximumLODLevel(){} // RVA: 0x7B82D70
        public void get_ShadowResolution(){} // RVA: 0x7B82AC0
        public void get_ShadowCascades(){} // RVA: 0x7B82970
        public void get_VSyncCount(){} // RVA: 0x7B82E60
        public void get_ShadowDistance(){} // RVA: 0x7B82A10
        public void ResetShadowDistance(){} // RVA: 0x8623B60
        public void SetShadowDistance(){} // RVA: 0xA6C3210
        public void get_ShadowCascade2Split(){} // RVA: 0x7B82B60
        public void set_ShadowCascade2Split(){} // RVA: 0x7B82BB0
        public void get_ShadowCascade4Split(){} // RVA: 0xA6C32B0
        public void set_ShadowCascade4Split(){} // RVA: 0xA6C3320
    }

}