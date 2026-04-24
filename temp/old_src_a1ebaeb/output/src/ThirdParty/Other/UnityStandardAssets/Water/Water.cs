// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Water
// Classes: 9
// Methods: 46

namespace ThirdParty.Other.UnityStandardAssets.Water
{
    public class Displace : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8942890
        public void OnEnable(){} // RVA: 0x7ffaa8942a80
        public void OnDisable(){} // RVA: 0x7ffaa8942b50
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class GerstnerDisplace : Displace
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class MeshContainer : Object
    {
        public object normals; // 0x33974330

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8942c20
        public void Update(){} // RVA: 0x7ffaa8942d60
    }

    public class PlanarReflection : MonoBehaviour
    {
        public object clearColor; // 0x336650F0
        public object m_Oldpos; // 0x336650F0
        public object m_HelperCameras; // 0x336650F0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8942e80
        public void CreateReflectionCameraFor(){} // RVA: 0x7ffaa8943090
        public void CreateTextureFor(){} // RVA: 0x7ffaa8943b50
        public void RenderHelpCameras(){} // RVA: 0x7ffaa8943ce0
        public void LateUpdate(){} // RVA: 0x7ffaa8943ff0
        public void WaterTileBeingRendered(){} // RVA: 0x7ffaa8944040
        public void OnEnable(){} // RVA: 0x7ffaa8944230
        public void OnDisable(){} // RVA: 0x7ffaa8944300
        public void RenderReflectionFor(){} // RVA: 0x7ffaa89443d0
        public void SaneCameraSettings(){} // RVA: 0x7ffaa89456b0
        public void CalculateObliqueMatrix(){} // RVA: 0x7ffaa8945800
        public void CalculateReflectionMatrix(){} // RVA: 0x7ffaa8945a00
        public void Sgn(){} // RVA: 0x7ffaa8945b70
        public void CameraSpacePlane(){} // RVA: 0x7ffaa8945ba0
        public void .ctor(){} // RVA: 0x7ffaa8945f90
        // ── Binary Analysis Named ──
        public void SetStandardCameraParameter(){} // RVA: 0x7ffaa89439c0
    }

    public class SpecularLighting : MonoBehaviour
    {
        public object sharedMaterial; // 0x339D4520

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8946060
        public void Update(){} // RVA: 0x7ffaa89462b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Water : MonoBehaviour
    {
        public object textureSize; // 0x339DE320
        public object refractLayers; // 0x339DE320
        public object m_ReflectionTexture; // 0x339DE320
        public object m_OldReflectionTextureSize; // 0x339DE320

        // ── Original Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7ffaa8946770
        public void OnDisable(){} // RVA: 0x7ffaa89475e0
        public void Update(){} // RVA: 0x7ffaa8947c30
        public void UpdateCameraModes(){} // RVA: 0x7ffaa8948100
        public void CreateWaterObjects(){} // RVA: 0x7ffaa8948680
        public void FindHardwareWaterSupport(){} // RVA: 0x7ffaa8949a10
        public void CameraSpacePlane(){} // RVA: 0x7ffaa8949d00
        public void CalculateReflectionMatrix(){} // RVA: 0x7ffaa894a0f0
        public void .ctor(){} // RVA: 0x7ffaa894a210
        // ── Binary Analysis Named ──
        public void GetWaterMode(){} // RVA: 0x7ffaa8949a00
    }

    public class WaterBase : MonoBehaviour
    {
        public object edgeBlend; // 0x339D4520

        // ── Original Methods ──
        public void UpdateShader(){} // RVA: 0x7ffaa894a3b0
        public void WaterTileBeingRendered(){} // RVA: 0x7ffaa894a860
        public void Update(){} // RVA: 0x7ffaa894a980
        public void .ctor(){} // RVA: 0x7ffaa894aa60
    }

    public class WaterBasic : MonoBehaviour
    {
        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaa8942520
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class WaterTile : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa894aab0
        public void AcquireComponents(){} // RVA: 0x7ffaa894aac0
        public void OnWillRenderObject(){} // RVA: 0x7ffaa894b230
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}