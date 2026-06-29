// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Water
// Classes: 9
// Methods: 46

namespace ThirdParty.Other.UnityStandardAssets.Water
{
    public class Displace : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0xB53E50
        public void OnEnable(){} // RVA: 0xB53FA0
        public void OnDisable(){} // RVA: 0xB54000
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class GerstnerDisplace : Displace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class MeshContainer : Object
    {
        public object mesh;
        public object vertices;
        public object normals;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB54060
        public void Update(){} // RVA: 0xB541A0
    }

    public class PlanarReflection : MonoBehaviour
    {
        public object reflectionMask;
        public object reflectSkybox;
        public object clearColor;
        public object reflectionSampler;
        public object clipPlaneOffset;
        public object m_Oldpos;
        public object m_ReflectionCamera;
        public object m_SharedMaterial;
        public object m_HelperCameras;

        // ── Methods ──
        public void Start(){} // RVA: 0xB542C0
        public void CreateReflectionCameraFor(){} // RVA: 0xB54420
        public void SetStandardCameraParameter(){} // RVA: 0xB54A40
        public void CreateTextureFor(){} // RVA: 0xB54B50
        public void RenderHelpCameras(){} // RVA: 0xB54D10
        public void LateUpdate(){} // RVA: 0xB55020
        public void WaterTileBeingRendered(){} // RVA: 0xB55070
        public void OnEnable(){} // RVA: 0xB55230
        public void OnDisable(){} // RVA: 0xB55290
        public void RenderReflectionFor(){} // RVA: 0xB552F0
        public void SaneCameraSettings(){} // RVA: 0xB56420
        public void CalculateObliqueMatrix(){} // RVA: 0xB56650
        public void CalculateReflectionMatrix(){} // RVA: 0xB568F0
        public void Sgn(){} // RVA: 0xB56A60
        public void CameraSpacePlane(){} // RVA: 0xB56A90
        public void .ctor(){} // RVA: 0xB56EC0
    }

    public class SpecularLighting : MonoBehaviour
    {
        public object specularLight;
        public object m_WaterBase;

        // ── Methods ──
        public void Start(){} // RVA: 0xB56F90
        public void Update(){} // RVA: 0xB57130
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Water : MonoBehaviour
    {
        public object waterMode;
        public object disablePixelLights;
        public object textureSize;
        public object clipPlaneOffset;
        public object reflectLayers;
        public object refractLayers;
        public object m_ReflectionCameras;
        public object m_RefractionCameras;
        public object m_ReflectionTexture;
        public object m_RefractionTexture;
        public object m_HardwareWaterSupport;
        public object m_OldReflectionTextureSize;
        public object m_OldRefractionTextureSize;
        public object s_InsideWater;

        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0xB57550
        public void OnDisable(){} // RVA: 0xB58470
        public void Update(){} // RVA: 0xB58C20
        public void UpdateCameraModes(){} // RVA: 0xB590B0
        public void CreateWaterObjects(){} // RVA: 0xB59460
        public void GetWaterMode(){} // RVA: 0xB5A900
        public void FindHardwareWaterSupport(){} // RVA: 0xB5A910
        public void CameraSpacePlane(){} // RVA: 0xB5ABC0
        public void CalculateReflectionMatrix(){} // RVA: 0xB5AFF0
        public void .ctor(){} // RVA: 0xB5B110
    }

    public class WaterBase : MonoBehaviour
    {
        public object sharedMaterial;
        public object waterQuality;
        public object edgeBlend;

        // ── Methods ──
        public void UpdateShader(){} // RVA: 0xB5B2B0
        public void WaterTileBeingRendered(){} // RVA: 0xB5B4A0
        public void Update(){} // RVA: 0xB5B590
        public void .ctor(){} // RVA: 0xB5B670
    }

    public class WaterBasic : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0xB53B00
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WaterTile : MonoBehaviour
    {
        public object reflection;
        public object waterBase;

        // ── Methods ──
        public void Start(){} // RVA: 0xB5B6C0
        public void AcquireComponents(){} // RVA: 0xB5B6D0
        public void OnWillRenderObject(){} // RVA: 0xB5BBD0
        public void .ctor(){} // RVA: 0xB43D60
    }

}