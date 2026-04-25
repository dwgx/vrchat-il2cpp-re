// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Water
// Classes: 9
// Methods: 46

namespace ThirdParty.Other.UnityStandardAssets.Water
{
    public class Displace : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F31890
        public void OnEnable(){} // RVA: 0x7FFAC2F31A80
        public void OnDisable(){} // RVA: 0x7FFAC2F31B50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class GerstnerDisplace : Displace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class MeshContainer : Object
    {
        public UnityEngine.Mesh mesh; // 0x10
        public UnityEngine.Vector3[] vertices; // 0x18
        public UnityEngine.Vector3[] normals; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F31C20
        public void Update(){} // RVA: 0x7FFAC2F31D60
    }

    public class PlanarReflection : MonoBehaviour
    {
        public UnityEngine.LayerMask reflectionMask; // 0x20
        public bool reflectSkybox; // 0x24
        public UnityEngine.Color clearColor; // 0x28
        public string reflectionSampler; // 0x38
        public float clipPlaneOffset; // 0x40
        public UnityEngine.Vector3 m_Oldpos; // 0x44
        public UnityEngine.Camera m_ReflectionCamera; // 0x50
        public UnityEngine.Material m_SharedMaterial; // 0x58
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,bool> m_HelperCameras; // 0x60

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F31E80
        public void CreateReflectionCameraFor(){} // RVA: 0x7FFAC2F32090
        public void SetStandardCameraParameter(){} // RVA: 0x7FFAC2F329C0
        public void CreateTextureFor(){} // RVA: 0x7FFAC2F32B50
        public void RenderHelpCameras(){} // RVA: 0x7FFAC2F32CE0
        public void LateUpdate(){} // RVA: 0x7FFAC2F32FF0
        public void WaterTileBeingRendered(){} // RVA: 0x7FFAC2F33040
        public void OnEnable(){} // RVA: 0x7FFAC2F33230
        public void OnDisable(){} // RVA: 0x7FFAC2F33300
        public void RenderReflectionFor(){} // RVA: 0x7FFAC2F333D0
        public void SaneCameraSettings(){} // RVA: 0x7FFAC2F346B0
        public void CalculateObliqueMatrix(){} // RVA: 0x7FFAC2F34800
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFAC2F34A00
        public void Sgn(){} // RVA: 0x7FFAC2F34B70
        public void CameraSpacePlane(){} // RVA: 0x7FFAC2F34BA0
        public void .ctor(){} // RVA: 0x7FFAC2F34F90
    }

    public class SpecularLighting : MonoBehaviour
    {
        public UnityEngine.Transform specularLight; // 0x20
        public UnityStandardAssets.Water.WaterBase m_WaterBase; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F35060
        public void Update(){} // RVA: 0x7FFAC2F352B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Water : MonoBehaviour
    {
        public 0x6B1BAA80 waterMode; // 0x20
        public bool disablePixelLights; // 0x24
        public int textureSize; // 0x28
        public float clipPlaneOffset; // 0x2C
        public UnityEngine.LayerMask reflectLayers; // 0x30
        public UnityEngine.LayerMask refractLayers; // 0x34
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,UnityEngine.Camera> m_ReflectionCameras; // 0x38
        public System.Collections.Generic.Dictionary`2<UnityEngine.Camera,UnityEngine.Camera> m_RefractionCameras; // 0x40
        public UnityEngine.RenderTexture m_ReflectionTexture; // 0x48
        public UnityEngine.RenderTexture m_RefractionTexture; // 0x50
        public 0x6B1BAA80 m_HardwareWaterSupport; // 0x58
        public int m_OldReflectionTextureSize; // 0x5C
        public int m_OldRefractionTextureSize; // 0x60
        public bool s_InsideWater;

        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFAC2F35770
        public void OnDisable(){} // RVA: 0x7FFAC2F365E0
        public void Update(){} // RVA: 0x7FFAC2F36C30
        public void UpdateCameraModes(){} // RVA: 0x7FFAC2F37100
        public void CreateWaterObjects(){} // RVA: 0x7FFAC2F37680
        public void GetWaterMode(){} // RVA: 0x7FFAC2F38A00
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFAC2F38A10
        public void CameraSpacePlane(){} // RVA: 0x7FFAC2F38D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFAC2F390F0
        public void .ctor(){} // RVA: 0x7FFAC2F39210
    }

    public class WaterBase : MonoBehaviour
    {
        public UnityEngine.Material sharedMaterial; // 0x20
        public 0x6B1BAB30 waterQuality; // 0x28
        public bool edgeBlend; // 0x2C

        // ── Methods ──
        public void UpdateShader(){} // RVA: 0x7FFAC2F393B0
        public void WaterTileBeingRendered(){} // RVA: 0x7FFAC2F39860
        public void Update(){} // RVA: 0x7FFAC2F39980
        public void .ctor(){} // RVA: 0x7FFAC2F39A60
    }

    public class WaterBasic : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC2F31520
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class WaterTile : MonoBehaviour
    {
        public UnityStandardAssets.Water.PlanarReflection reflection; // 0x20
        public UnityStandardAssets.Water.WaterBase waterBase; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F39AB0
        public void AcquireComponents(){} // RVA: 0x7FFAC2F39AC0
        public void OnWillRenderObject(){} // RVA: 0x7FFAC2F3A230
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}