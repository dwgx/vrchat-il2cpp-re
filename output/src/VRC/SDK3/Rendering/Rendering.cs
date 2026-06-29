// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Rendering
// Classes: 4
// Methods: 79

namespace VRC.SDK3.Rendering
{
    public class VRCAsyncGPUReadback : Object
    {
        // ── Methods ──
        public void Request(){} // RVA: 0x7B1852B20
    }

    public class VRCAsyncGPUReadbackRequest : Object
    {
        // ── Methods ──
        public void get_done(){} // RVA: 0x7A8606F20
        public void get_hasError(){} // RVA: 0x7B1852CA0
        public void get_width(){} // RVA: 0x7B1852CF0
        public void get_height(){} // RVA: 0x7B1852D40
        public void get_depth(){} // RVA: 0x7B1852D90
        public void get_layerCount(){} // RVA: 0x7B1852DE0
        public void get_layerDataSize(){} // RVA: 0x7B1852E30
        public void .ctor(){} // RVA: 0x7A80D7310
        public void HandleCallback(){} // RVA: 0x7B1852E80
        public void TryGetData(){} // RVA: 0x7A7E039E0
    }

    public class VRCCameraSettings : Object
    {
        // ── Methods ──
        public void get_ScreenCamera(){} // RVA: 0x7B18531A0
        public void set_ScreenCamera(){} // RVA: 0x7B1853200
        public void get_ScreenCameraRef(){} // RVA: 0x7B18532C0
        public void set_ScreenCameraRef(){} // RVA: 0x7B1853360
        public void get_PhotoCamera(){} // RVA: 0x7B1853470
        public void set_PhotoCamera(){} // RVA: 0x7B18534D0
        public void get_PhotoCameraRef(){} // RVA: 0x7B1853590
        public void set_PhotoCameraRef(){} // RVA: 0x7B1853630
        public void .ctor(){} // RVA: 0x7B1853740
        public void get_CameraMode(){} // RVA: 0x7B1853860
        public void get_Position(){} // RVA: 0x7B1853880
        public void get_Rotation(){} // RVA: 0x7B1853980
        public void get_Forward(){} // RVA: 0x7B1853A80
        public void get_Up(){} // RVA: 0x7B1853B30
        public void get_Right(){} // RVA: 0x7B1853BE0
        public void get_PixelWidth(){} // RVA: 0x7B1853C90
        public void get_PixelHeight(){} // RVA: 0x7B1853CF0
        public void get_FieldOfView(){} // RVA: 0x7B1853D50
        public void get_Aspect(){} // RVA: 0x7B1853DB0
        public void get_Active(){} // RVA: 0x7B1853E10
        public void get_StereoEnabled(){} // RVA: 0x7B1853ED0
        public void get_NearClipPlane(){} // RVA: 0x7B1853F30
        public void set_NearClipPlane(){} // RVA: 0x7B1853F90
        public void get_FarClipPlane(){} // RVA: 0x7B1854070
        public void set_FarClipPlane(){} // RVA: 0x7B18540D0
        public void get_ClearFlags(){} // RVA: 0x7B18541B0
        public void set_ClearFlags(){} // RVA: 0x7B1854210
        public void get_BackgroundColor(){} // RVA: 0x7B18542F0
        public void set_BackgroundColor(){} // RVA: 0x7B1854370
        public void get_AllowHDR(){} // RVA: 0x7B1854460
        public void set_AllowHDR(){} // RVA: 0x7B18544C0
        public void get_DepthTextureMode(){} // RVA: 0x7B18545A0
        public void set_DepthTextureMode(){} // RVA: 0x7B1854600
        public void get_UseOcclusionCulling(){} // RVA: 0x7B1854800
        public void set_UseOcclusionCulling(){} // RVA: 0x7B1854860
        public void get_AllowMSAA(){} // RVA: 0x7B1854940
        public void set_AllowMSAA(){} // RVA: 0x7B18549A0
        public void get_CullingMask(){} // RVA: 0x7B1854A80
        public void set_CullingMask(){} // RVA: 0x7B1854AE0
        public void get_LayerCullDistances(){} // RVA: 0x7B1854D40
        public void set_LayerCullDistances(){} // RVA: 0x7B1854DA0
        public void get_LayerCullSpherical(){} // RVA: 0x7A89FCA90
        public void set_LayerCullSpherical(){} // RVA: 0x7B1854E40
        public void OnExitWorld(){} // RVA: 0x7B1854F20
        public void GetEyePosition(){} // RVA: 0x7B1854F90
        public void GetEyeRotation(){} // RVA: 0x7B1855500
        public void GetCurrentCamera(){} // RVA: 0x7B1855B10
        public void Equals(){} // RVA: 0x7B1855F70
        public void GetHashCode(){} // RVA: 0x7B1856110
        public void ToString(){} // RVA: 0x7B1856210
        public void SetLayerCullDistances(){} // RVA: 0x7B1856410
        public void SetCullingMask(){} // RVA: 0x7B1856730
        public void .cctor(){} // RVA: 0x7B1856860
        public void <.ctor>b__16_0(){} // RVA: 0x7AEFCF210
    }

    public class VRCQualitySettings : Object
    {
        // ── Methods ──
        public void get_AntiAliasing(){} // RVA: 0x7AEEB9850
        public void get_PixelLightCount(){} // RVA: 0x7AEEB9220
        public void get_LODBias(){} // RVA: 0x7AEEB9610
        public void get_MaximumLODLevel(){} // RVA: 0x7AEEB96C0
        public void get_ShadowResolution(){} // RVA: 0x7AEEB9410
        public void get_ShadowCascades(){} // RVA: 0x7AEEB92C0
        public void get_VSyncCount(){} // RVA: 0x7AEEB97B0
        public void get_ShadowDistance(){} // RVA: 0x7AEEB9360
        public void ResetShadowDistance(){} // RVA: 0x7AF7CA130
        public void SetShadowDistance(){} // RVA: 0x7B1856A50
        public void get_ShadowCascade2Split(){} // RVA: 0x7AEEB94B0
        public void set_ShadowCascade2Split(){} // RVA: 0x7AEEB9500
        public void get_ShadowCascade4Split(){} // RVA: 0x7B1856AF0
        public void set_ShadowCascade4Split(){} // RVA: 0x7B1856B60
    }

}