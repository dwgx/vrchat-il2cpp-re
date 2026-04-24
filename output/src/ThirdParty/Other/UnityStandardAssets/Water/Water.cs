// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Water
// Classes: 9
// Methods: 46

namespace ThirdParty.Other.UnityStandardAssets.Water
{
    public class Displace : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E351890
        public void OnEnable(){} // RVA: 0x7FFD4E351A80
        public void OnDisable(){} // RVA: 0x7FFD4E351B50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class GerstnerDisplace : Displace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class MeshContainer : Object
    {
        public object mesh; // 0x10
        public amut[] vertices; // 0x18
        public amut[] normals; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E351C20
        public void Update(){} // RVA: 0x7FFD4E351D60
    }

    public class PlanarReflection : MonoBehaviour
    {
        public object reflectionMask; // 0x20
        public bool reflectSkybox; // 0x24
        public object clearColor; // 0x28
        public string reflectionSampler; // 0x38
        public float clipPlaneOffset; // 0x40
        public amut m_Oldpos; // 0x44
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ m_ReflectionCamera; // 0x50
        public atrix_Injected m_SharedMaterial; // 0x58
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,bool> m_HelperCameras; // 0x60

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E351E80
        public void CreateReflectionCameraFor(){} // RVA: 0x7FFD4E352090
        public void SetStandardCameraParameter(){} // RVA: 0x7FFD4E3529C0
        public void CreateTextureFor(){} // RVA: 0x7FFD4E352B50
        public void RenderHelpCameras(){} // RVA: 0x7FFD4E352CE0
        public void LateUpdate(){} // RVA: 0x7FFD4E352FF0
        public void WaterTileBeingRendered(){} // RVA: 0x7FFD4E353040
        public void OnEnable(){} // RVA: 0x7FFD4E353230
        public void OnDisable(){} // RVA: 0x7FFD4E353300
        public void RenderReflectionFor(){} // RVA: 0x7FFD4E3533D0
        public void SaneCameraSettings(){} // RVA: 0x7FFD4E3546B0
        public void CalculateObliqueMatrix(){} // RVA: 0x7FFD4E354800
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFD4E354A00
        public void Sgn(){} // RVA: 0x7FFD4E354B70
        public void CameraSpacePlane(){} // RVA: 0x7FFD4E354BA0
        public void .ctor(){} // RVA: 0x7FFD4E354F90
    }

    public class SpecularLighting : MonoBehaviour
    {
        public object specularLight; // 0x20
        public nput.PacketNum m_WaterBase; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E355060
        public void Update(){} // RVA: 0x7FFD4E3552B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Water : MonoBehaviour
    {
        public unt waterMode; // 0x20
        public bool disablePixelLights; // 0x24
        public int textureSize; // 0x28
        public float clipPlaneOffset; // 0x2C
        public object reflectLayers; // 0x30
        public object refractLayers; // 0x34
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> m_ReflectionCameras; // 0x38
        public URA.DateTime<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> m_RefractionCameras; // 0x40
        public Offset m_ReflectionTexture; // 0x48
        public Offset m_RefractionTexture; // 0x50
        public unt m_HardwareWaterSupport; // 0x58
        public int m_OldReflectionTextureSize; // 0x5C
        public int m_OldRefractionTextureSize; // 0x60
        public bool s_InsideWater;

        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFD4E355770
        public void OnDisable(){} // RVA: 0x7FFD4E3565E0
        public void Update(){} // RVA: 0x7FFD4E356C30
        public void UpdateCameraModes(){} // RVA: 0x7FFD4E357100
        public void CreateWaterObjects(){} // RVA: 0x7FFD4E357680
        public void GetWaterMode(){} // RVA: 0x7FFD4E358A00
        public void FindHardwareWaterSupport(){} // RVA: 0x7FFD4E358A10
        public void CameraSpacePlane(){} // RVA: 0x7FFD4E358D00
        public void CalculateReflectionMatrix(){} // RVA: 0x7FFD4E3590F0
        public void .ctor(){} // RVA: 0x7FFD4E359210
    }

    public class WaterBase : MonoBehaviour
    {
        public atrix_Injected sharedMaterial; // 0x20
        public nput.lerState_t waterQuality; // 0x28
        public bool edgeBlend; // 0x2C

        // ── Methods ──
        public void UpdateShader(){} // RVA: 0x7FFD4E3593B0
        public void WaterTileBeingRendered(){} // RVA: 0x7FFD4E359860
        public void Update(){} // RVA: 0x7FFD4E359980
        public void .ctor(){} // RVA: 0x7FFD4E359A60
    }

    public class WaterBasic : MonoBehaviour
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD4E351520
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WaterTile : MonoBehaviour
    {
        public nput.se reflection; // 0x20
        public nput.PacketNum waterBase; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E359AB0
        public void AcquireComponents(){} // RVA: 0x7FFD4E359AC0
        public void OnWillRenderObject(){} // RVA: 0x7FFD4E35A230
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}