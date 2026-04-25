// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Rendering
// Classes: 4
// Methods: 87

namespace VRC.SDK3.Rendering
{
    public class VRCAsyncGPUReadback : Object
    {
        // ── Methods ──
        public void Request(){} // RVA: 0x7FFACC009950 | overloaded x4
    }

    public class VRCAsyncGPUReadbackRequest : Object
    {
        public UnityEngine.Rendering.AsyncGPUReadbackRequest done; // 0x10
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver hasError; // 0x20

        // ── Methods ──
        public void get_done(){} // RVA: 0x7FFAC3381B60
        public void get_hasError(){} // RVA: 0x7FFACC009AD0
        public void get_width(){} // RVA: 0x7FFACC009B20
        public void get_height(){} // RVA: 0x7FFACC009B70
        public void get_depth(){} // RVA: 0x7FFACC009BC0
        public void get_layerCount(){} // RVA: 0x7FFACC009C10
        public void get_layerDataSize(){} // RVA: 0x7FFACC009C60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void HandleCallback(){} // RVA: 0x7FFACC009CB0
        public void TryGetData(){} // RVA: 0x7FFAC2C5C920 | overloaded x5
    }

    public class VRCCameraSettings : Object
    {
        public System.Action`1<UnityEngine.Camera> ScreenCamera;
        public System.Func`1<0x6B262AA0> ScreenCameraRef; // 0x10
        public VRC.SDK3.Rendering.VRCCameraSettings PhotoCamera; // 0x8
        public VRC.SDK3.Rendering.VRCCameraSettings PhotoCameraRef; // 0x10
        public UnityEngine.Camera CameraMode; // 0x18
        public System.Func`1<UnityEngine.Transform> Position; // 0x20
        public bool Rotation; // 0x28
        public bool Forward; // 0x29
        public bool Up; // 0x18
        public float[] Right; // 0x20
        public int[] PixelWidth; // 0x28

        // ── Methods ──
        public void get_ScreenCamera(){} // RVA: 0x7FFACC009FD0
        public void set_ScreenCamera(){} // RVA: 0x7FFACC00A030
        public void get_ScreenCameraRef(){} // RVA: 0x7FFACC00A0F0
        public void set_ScreenCameraRef(){} // RVA: 0x7FFACC00A190
        public void get_PhotoCamera(){} // RVA: 0x7FFACC00A2A0
        public void set_PhotoCamera(){} // RVA: 0x7FFACC00A300
        public void get_PhotoCameraRef(){} // RVA: 0x7FFACC00A3C0
        public void set_PhotoCameraRef(){} // RVA: 0x7FFACC00A460
        public void .ctor(){} // RVA: 0x7FFACC00A570
        public void get_CameraMode(){} // RVA: 0x7FFACC00A690
        public void get_Position(){} // RVA: 0x7FFACC00A6B0
        public void get_Rotation(){} // RVA: 0x7FFACC00A7B0
        public void get_Forward(){} // RVA: 0x7FFACC00A8B0
        public void get_Up(){} // RVA: 0x7FFACC00A960
        public void get_Right(){} // RVA: 0x7FFACC00AA10
        public void get_PixelWidth(){} // RVA: 0x7FFACC00AAC0
        public void get_PixelHeight(){} // RVA: 0x7FFACC00AB20
        public void get_FieldOfView(){} // RVA: 0x7FFACC00AB80
        public void get_Aspect(){} // RVA: 0x7FFACC00ABE0
        public void get_Active(){} // RVA: 0x7FFACC00AC40
        public void get_StereoEnabled(){} // RVA: 0x7FFACC00AD00
        public void get_NearClipPlane(){} // RVA: 0x7FFACC00AD60
        public void set_NearClipPlane(){} // RVA: 0x7FFACC00ADC0
        public void get_FarClipPlane(){} // RVA: 0x7FFACC00AEA0
        public void set_FarClipPlane(){} // RVA: 0x7FFACC00AF00
        public void get_ClearFlags(){} // RVA: 0x7FFACC00AFE0
        public void set_ClearFlags(){} // RVA: 0x7FFACC00B040
        public void get_BackgroundColor(){} // RVA: 0x7FFACC00B120
        public void set_BackgroundColor(){} // RVA: 0x7FFACC00B1A0
        public void get_AllowHDR(){} // RVA: 0x7FFACC00B290
        public void set_AllowHDR(){} // RVA: 0x7FFACC00B2F0
        public void get_DepthTextureMode(){} // RVA: 0x7FFACC00B3D0
        public void set_DepthTextureMode(){} // RVA: 0x7FFACC00B430
        public void get_UseOcclusionCulling(){} // RVA: 0x7FFACC00B630
        public void set_UseOcclusionCulling(){} // RVA: 0x7FFACC00B690
        public void get_AllowMSAA(){} // RVA: 0x7FFACC00B770
        public void set_AllowMSAA(){} // RVA: 0x7FFACC00B7D0
        public void get_CullingMask(){} // RVA: 0x7FFACC00B8B0
        public void set_CullingMask(){} // RVA: 0x7FFACC00B910
        public void get_LayerCullDistances(){} // RVA: 0x7FFACC00BB60
        public void set_LayerCullDistances(){} // RVA: 0x7FFACC00BBC0
        public void get_LayerCullSpherical(){} // RVA: 0x7FFAC386C550
        public void set_LayerCullSpherical(){} // RVA: 0x7FFACC00BC60
        public void OnExitWorld(){} // RVA: 0x7FFACC00BD40
        public void GetEyePosition(){} // RVA: 0x7FFACC00BDB0
        public void GetEyeRotation(){} // RVA: 0x7FFACC00C330
        public void GetCurrentCamera(){} // RVA: 0x7FFACC00C940
        public void Equals(){} // RVA: 0x7FFACC00CDA0
        public void GetHashCode(){} // RVA: 0x7FFACC00CF60
        public void ToString(){} // RVA: 0x7FFACC00D060
        public void SetLayerCullDistances(){} // RVA: 0x7FFACC00D260
        public void SetCullingMask(){} // RVA: 0x7FFACC00D570
        public void .cctor(){} // RVA: 0x7FFACC00D690
        public void <.ctor>b__16_0(){} // RVA: 0x7FFAC9987580
    }

    public class VRCQualitySettings : Object
    {
        public System.Action`4<float,float,float,float> AntiAliasing;
        public System.Action`1<float> PixelLightCount; // 0x8
        public System.Action LODBias; // 0x10

        // ── Methods ──
        public void get_AntiAliasing(){} // RVA: 0x7FFAC9872FF0
        public void get_PixelLightCount(){} // RVA: 0x7FFAC98729C0
        public void get_LODBias(){} // RVA: 0x7FFAC9872DB0
        public void get_MaximumLODLevel(){} // RVA: 0x7FFAC9872E60
        public void get_ShadowResolution(){} // RVA: 0x7FFAC9872BB0
        public void get_ShadowCascades(){} // RVA: 0x7FFAC9872A60
        public void get_VSyncCount(){} // RVA: 0x7FFAC9872F50
        public void get_ShadowDistance(){} // RVA: 0x7FFAC9872B00
        public void ResetShadowDistance(){} // RVA: 0x7FFACA13F070
        public void SetShadowDistance(){} // RVA: 0x7FFACC00D880 | overloaded x2
        public void get_ShadowCascade2Split(){} // RVA: 0x7FFAC9872C50
        public void set_ShadowCascade2Split(){} // RVA: 0x7FFAC9872CA0
        public void get_ShadowCascade4Split(){} // RVA: 0x7FFACC00D920
        public void set_ShadowCascade4Split(){} // RVA: 0x7FFACC00D990
    }

}