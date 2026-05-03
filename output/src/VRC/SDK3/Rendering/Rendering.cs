// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Rendering
// Classes: 4
// Methods: 87

namespace VRC.SDK3.Rendering
{
    public class VRCAsyncGPUReadback : Object
    {
        // ── Methods ──
        public void Request(){} // RVA: 0x7FFE8A46F200 | overloaded x4
    }

    public class VRCAsyncGPUReadbackRequest : Object
    {
        public UnityEngine.Rendering.AsyncGPUReadbackRequest Request; // 0x10
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver UdonBehaviour; // 0x20
        public object field_2; // 0x7E
        public object field_3; // 0x7F
        public object field_4; // 0x80
        public object field_5; // 0x81
        public object field_6; // 0x82

        // ── Methods ──
        public void get_done(){} // RVA: 0x7FFE815F7980
        public void get_hasError(){} // RVA: 0x7FFE8A46F380
        public void get_width(){} // RVA: 0x7FFE8A46F3D0
        public void get_height(){} // RVA: 0x7FFE8A46F420
        public void get_depth(){} // RVA: 0x7FFE8A46F470
        public void get_layerCount(){} // RVA: 0x7FFE8A46F4C0
        public void get_layerDataSize(){} // RVA: 0x7FFE8A46F510
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void HandleCallback(){} // RVA: 0x7FFE8A46F560
        public void TryGetData(){} // RVA: 0x7FFE80E31D70 | overloaded x5
    }

    public class VRCCameraSettings : Object
    {
        public System.Action`1<UnityEngine.Camera> OnCameraSettingsChanged;
        public System.Func`1<0x6665C67C> GetCameraMode; // 0x10
        public VRC.SDK3.Rendering.VRCCameraSettings _screenCamera; // 0x8
        public VRC.SDK3.Rendering.VRCCameraSettings _photoCamera; // 0x10
        public UnityEngine.Camera _targetCamera; // 0x18
        public System.Func`1<UnityEngine.Transform> TransformGetter; // 0x20
        public bool HasChangedFarClipPlane; // 0x28
        public bool _layerCullSphericalFake; // 0x29
        public bool _layerCullSphericalWarningDisplayed; // 0x18
        public float[] _defaultLayerCullDistances; // 0x20
        public int[] _excludedLayers; // 0x28
        public object field_11; // 0x85
        public object field_12; // 0x86
        public object field_13; // 0x87
        public object field_14; // 0x88
        public object field_15; // 0x89
        public object field_16; // 0x8A
        public object field_17; // 0x8B
        public object field_18; // 0x8C
        public object field_19; // 0x8D
        public object field_20; // 0x8E
        public object field_21; // 0x8F
        public object field_22; // 0x90
        public object field_23; // 0x91
        public object field_24; // 0x92
        public object field_25; // 0x93
        public object field_26; // 0x94

        // ── Methods ──
        public void get_ScreenCamera(){} // RVA: 0x7FFE8A46F880
        public void set_ScreenCamera(){} // RVA: 0x7FFE8A46F8E0
        public void get_ScreenCameraRef(){} // RVA: 0x7FFE8A46F9A0
        public void set_ScreenCameraRef(){} // RVA: 0x7FFE8A46FA40
        public void get_PhotoCamera(){} // RVA: 0x7FFE8A46FB50
        public void set_PhotoCamera(){} // RVA: 0x7FFE8A46FBB0
        public void get_PhotoCameraRef(){} // RVA: 0x7FFE8A46FC70
        public void set_PhotoCameraRef(){} // RVA: 0x7FFE8A46FD10
        public void .ctor(){} // RVA: 0x7FFE8A46FE20
        public void get_CameraMode(){} // RVA: 0x7FFE8A46FF40
        public void get_Position(){} // RVA: 0x7FFE8A46FF60
        public void get_Rotation(){} // RVA: 0x7FFE8A470060
        public void get_Forward(){} // RVA: 0x7FFE8A470160
        public void get_Up(){} // RVA: 0x7FFE8A470210
        public void get_Right(){} // RVA: 0x7FFE8A4702C0
        public void get_PixelWidth(){} // RVA: 0x7FFE8A470370
        public void get_PixelHeight(){} // RVA: 0x7FFE8A4703D0
        public void get_FieldOfView(){} // RVA: 0x7FFE8A470430
        public void get_Aspect(){} // RVA: 0x7FFE8A470490
        public void get_Active(){} // RVA: 0x7FFE8A4704F0
        public void get_StereoEnabled(){} // RVA: 0x7FFE8A4705B0
        public void get_NearClipPlane(){} // RVA: 0x7FFE8A470610
        public void set_NearClipPlane(){} // RVA: 0x7FFE8A470670
        public void get_FarClipPlane(){} // RVA: 0x7FFE8A470750
        public void set_FarClipPlane(){} // RVA: 0x7FFE8A4707B0
        public void get_ClearFlags(){} // RVA: 0x7FFE8A470890
        public void set_ClearFlags(){} // RVA: 0x7FFE8A4708F0
        public void get_BackgroundColor(){} // RVA: 0x7FFE8A4709D0
        public void set_BackgroundColor(){} // RVA: 0x7FFE8A470A50
        public void get_AllowHDR(){} // RVA: 0x7FFE8A470B40
        public void set_AllowHDR(){} // RVA: 0x7FFE8A470BA0
        public void get_DepthTextureMode(){} // RVA: 0x7FFE8A470C80
        public void set_DepthTextureMode(){} // RVA: 0x7FFE8A470CE0
        public void get_UseOcclusionCulling(){} // RVA: 0x7FFE8A470EE0
        public void set_UseOcclusionCulling(){} // RVA: 0x7FFE8A470F40
        public void get_AllowMSAA(){} // RVA: 0x7FFE8A471020
        public void set_AllowMSAA(){} // RVA: 0x7FFE8A471080
        public void get_CullingMask(){} // RVA: 0x7FFE8A471160
        public void set_CullingMask(){} // RVA: 0x7FFE8A4711C0
        public void get_LayerCullDistances(){} // RVA: 0x7FFE8A471410
        public void set_LayerCullDistances(){} // RVA: 0x7FFE8A471470
        public void get_LayerCullSpherical(){} // RVA: 0x7FFE819C2EA0
        public void set_LayerCullSpherical(){} // RVA: 0x7FFE8A471510
        public void OnExitWorld(){} // RVA: 0x7FFE8A4715F0
        public void GetEyePosition(){} // RVA: 0x7FFE8A471660
        public void GetEyeRotation(){} // RVA: 0x7FFE8A471BE0
        public void GetCurrentCamera(){} // RVA: 0x7FFE8A4721F0
        public void Equals(){} // RVA: 0x7FFE8A472650
        public void GetHashCode(){} // RVA: 0x7FFE8A472810
        public void ToString(){} // RVA: 0x7FFE8A472910
        public void SetLayerCullDistances(){} // RVA: 0x7FFE8A472B10
        public void SetCullingMask(){} // RVA: 0x7FFE8A472E20
        public void .cctor(){} // RVA: 0x7FFE8A472F40
        public void <.ctor>b__16_0(){} // RVA: 0x7FFE87D2FE20
    }

    public class VRCQualitySettings : Object
    {
        public System.Action`4<float,float,float,float> SetShadowDistanceInternal;
        public System.Action`1<float> SetShadowDistanceInternalAll; // 0x8
        public System.Action ResetShadowDistanceInternal; // 0x10
        public object field_3; // 0xA0
        public object field_4; // 0xA1
        public object field_5; // 0xA2
        public object field_6; // 0xA3
        public object field_7; // 0xA4
        public object field_8; // 0xA5
        public object field_9; // 0xA6

        // ── Methods ──
        public void get_AntiAliasing(){} // RVA: 0x7FFE87C1B640
        public void get_PixelLightCount(){} // RVA: 0x7FFE87C1B010
        public void get_LODBias(){} // RVA: 0x7FFE87C1B400
        public void get_MaximumLODLevel(){} // RVA: 0x7FFE87C1B4B0
        public void get_ShadowResolution(){} // RVA: 0x7FFE87C1B200
        public void get_ShadowCascades(){} // RVA: 0x7FFE87C1B0B0
        public void get_VSyncCount(){} // RVA: 0x7FFE87C1B5A0
        public void get_ShadowDistance(){} // RVA: 0x7FFE87C1B150
        public void ResetShadowDistance(){} // RVA: 0x7FFE884FEC30
        public void SetShadowDistance(){} // RVA: 0x7FFE8A473130 | overloaded x2
        public void get_ShadowCascade2Split(){} // RVA: 0x7FFE87C1B2A0
        public void set_ShadowCascade2Split(){} // RVA: 0x7FFE87C1B2F0
        public void get_ShadowCascade4Split(){} // RVA: 0x7FFE8A4731D0
        public void set_ShadowCascade4Split(){} // RVA: 0x7FFE8A473240
    }

}