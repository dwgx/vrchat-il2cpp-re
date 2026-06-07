// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Rendering
// Classes: 4
// Methods: 87

namespace VRC.SDK3.Rendering
{
    public class VRCAsyncGPUReadback
    {
        // ── Methods ──
        public void Request(){} // RVA: 0x9A13790 | overloaded x4
    }

    public class VRCAsyncGPUReadbackRequest
    {
        public object IsInitialized;
        public object CanExecuteConstraintJobsInEditMode;

        // ── Methods ──
        public void get_done(){} // RVA: 0x849F30
        public void get_hasError(){} // RVA: 0x9A13910
        public void get_width(){} // RVA: 0x9A13960
        public void get_height(){} // RVA: 0x9A139B0
        public void get_depth(){} // RVA: 0x9A13A00
        public void get_layerCount(){} // RVA: 0x9A13A50
        public void get_layerDataSize(){} // RVA: 0x9A13AA0
        public void .ctor(){} // RVA: 0x2DD310
        public void HandleCallback(){} // RVA: 0x9A13AF0
        public void TryGetData(){} // RVA: 0x10840 | overloaded x5
    }

    public class VRCCameraSettings
    {
        // ── Methods ──
        public void get_ScreenCamera(){} // RVA: 0x9A13E10
        public void set_ScreenCamera(){} // RVA: 0x9A13E70
        public void get_ScreenCameraRef(){} // RVA: 0x9A13F30
        public void set_ScreenCameraRef(){} // RVA: 0x9A13FD0
        public void get_PhotoCamera(){} // RVA: 0x9A140E0
        public void set_PhotoCamera(){} // RVA: 0x9A14140
        public void get_PhotoCameraRef(){} // RVA: 0x9A14200
        public void set_PhotoCameraRef(){} // RVA: 0x9A142A0
        public void .ctor(){} // RVA: 0x9A143B0
        public void get_CameraMode(){} // RVA: 0x9A144D0
        public void get_Position(){} // RVA: 0x9A144F0
        public void get_Rotation(){} // RVA: 0x9A145F0
        public void get_Forward(){} // RVA: 0x9A146F0
        public void get_Up(){} // RVA: 0x9A147A0
        public void get_Right(){} // RVA: 0x9A14850
        public void get_PixelWidth(){} // RVA: 0x9A14900
        public void get_PixelHeight(){} // RVA: 0x9A14960
        public void get_FieldOfView(){} // RVA: 0x9A149C0
        public void get_Aspect(){} // RVA: 0x9A14A20
        public void get_Active(){} // RVA: 0x9A14A80
        public void get_StereoEnabled(){} // RVA: 0x9A14B40
        public void get_NearClipPlane(){} // RVA: 0x9A14BA0
        public void set_NearClipPlane(){} // RVA: 0x9A14C00
        public void get_FarClipPlane(){} // RVA: 0x9A14CE0
        public void set_FarClipPlane(){} // RVA: 0x9A14D40
        public void get_ClearFlags(){} // RVA: 0x9A14E20
        public void set_ClearFlags(){} // RVA: 0x9A14E80
        public void get_BackgroundColor(){} // RVA: 0x9A14F60
        public void set_BackgroundColor(){} // RVA: 0x9A14FE0
        public void get_AllowHDR(){} // RVA: 0x9A150D0
        public void set_AllowHDR(){} // RVA: 0x9A15130
        public void get_DepthTextureMode(){} // RVA: 0x9A15210
        public void set_DepthTextureMode(){} // RVA: 0x9A15270
        public void get_UseOcclusionCulling(){} // RVA: 0x9A15470
        public void set_UseOcclusionCulling(){} // RVA: 0x9A154D0
        public void get_AllowMSAA(){} // RVA: 0x9A155B0
        public void set_AllowMSAA(){} // RVA: 0x9A15610
        public void get_CullingMask(){} // RVA: 0x9A156F0
        public void set_CullingMask(){} // RVA: 0x9A15750
        public void get_LayerCullDistances(){} // RVA: 0x9A159A0
        public void set_LayerCullDistances(){} // RVA: 0x9A15A00
        public void get_LayerCullSpherical(){} // RVA: 0xC36000
        public void set_LayerCullSpherical(){} // RVA: 0x9A15AA0
        public void OnExitWorld(){} // RVA: 0x9A15B80
        public void GetEyePosition(){} // RVA: 0x9A15BF0
        public void GetEyeRotation(){} // RVA: 0x9A16170
        public void GetCurrentCamera(){} // RVA: 0x9A16780
        public void Equals(){} // RVA: 0x9A16BE0
        public void GetHashCode(){} // RVA: 0x9A16DA0
        public void ToString(){} // RVA: 0x9A16EA0
        public void SetLayerCullDistances(){} // RVA: 0x9A170A0
        public void SetCullingMask(){} // RVA: 0x9A173B0
        public void .cctor(){} // RVA: 0x9A174D0
        public void <.ctor>b__16_0(){} // RVA: 0x71EFC80
    }

    public class VRCQualitySettings
    {
        // ── Methods ──
        public void get_AntiAliasing(){} // RVA: 0x70DA9A0
        public void get_PixelLightCount(){} // RVA: 0x70DA370
        public void get_LODBias(){} // RVA: 0x70DA760
        public void get_MaximumLODLevel(){} // RVA: 0x70DA810
        public void get_ShadowResolution(){} // RVA: 0x70DA560
        public void get_ShadowCascades(){} // RVA: 0x70DA410
        public void get_VSyncCount(){} // RVA: 0x70DA900
        public void get_ShadowDistance(){} // RVA: 0x70DA4B0
        public void ResetShadowDistance(){} // RVA: 0x79E8450
        public void SetShadowDistance(){} // RVA: 0x9A176C0 | overloaded x2
        public void get_ShadowCascade2Split(){} // RVA: 0x70DA600
        public void set_ShadowCascade2Split(){} // RVA: 0x70DA650
        public void get_ShadowCascade4Split(){} // RVA: 0x9A17760
        public void set_ShadowCascade4Split(){} // RVA: 0x9A177D0
    }

}