// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 38
// Methods: 528

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        public Depthkit.ClipPlayerEventHandler playerEvents; // 0x20
        public Depthkit.ClipPlayerEventHandler metadataFilePath; // 0x28
        public Depthkit.DataSourceEventHandler metadataFile; // 0x30
        public string metadataSourceType; // 0x38
        public UnityEngine.TextAsset metadata; // 0x40
        public 0x6B2A9C70 hasMetadata; // 0x48
        public Depthkit.Metadata perspectiveDataBuffer; // 0x50
        public PerspectiveDataBuffer player; // 0x58
        public Depthkit.ClipPlayer playerSetup; // 0x60
        public int playerIsActive; // 0x68
        public UnityEngine.Texture width; // 0x70
        public UnityEngine.Texture2D height; // 0x78
        public bool gammaCorrectDepth; // 0x80
        public System.Collections.Generic.List`1<System.WeakReference> gammaCorrectColor; // 0x88
        public bool cppTexture; // 0x90
        public bool textureIsFlipped; // 0x91
        public float poster;

        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x7FFAC49482C0
        public void remove_newFrame(){} // RVA: 0x7FFAC49483B0
        public void add_newPoster(){} // RVA: 0x7FFAC49484A0
        public void remove_newPoster(){} // RVA: 0x7FFAC4948590
        public void add_m_newMetadata(){} // RVA: 0x7FFAC4948680
        public void remove_m_newMetadata(){} // RVA: 0x7FFAC4948770
        public void add_newMetadata(){} // RVA: 0x7FFAC4948860
        public void remove_newMetadata(){} // RVA: 0x7FFAC4948A30
        public void OnNewFrame(){} // RVA: 0x7FFAC4948B40
        public void OnNewMetadata(){} // RVA: 0x7FFAC4948B60
        public void OnNewPoster(){} // RVA: 0x7FFAC4948B80
        public void get_playerEvents(){} // RVA: 0x7FFAC4948BA0
        public void get_metadataFilePath(){} // RVA: 0x7FFAC31D0140
        public void set_metadataFilePath(){} // RVA: 0x7FFAC4948CD0
        public void get_metadataFile(){} // RVA: 0x7FFAC2F9E740
        public void set_metadataFile(){} // RVA: 0x7FFAC4948F10
        public void get_metadataSourceType(){} // RVA: 0x7FFAC2FC20C0
        public void get_metadata(){} // RVA: 0x7FFAC2FC20E0
        public void get_hasMetadata(){} // RVA: 0x7FFAC4949170
        public void LoadMetadata(){} // RVA: 0x7FFAC49491A0
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7FFAC49493F0
        public void get_perspectiveDataBuffer(){} // RVA: 0x7FFAC49494D0
        public void get_player(){} // RVA: 0x7FFAC2FBF370
        public void CreatePlayer(){} // RVA: 0x7FFAC49494E0
        public void SetPlayer(){} // RVA: 0x7FFAC4949750 | overloaded x2
        public void get_playerSetup(){} // RVA: 0x7FFAC4949980
        public void get_playerIsActive(){} // RVA: 0x7FFAC4949A80
        public void get_width(){} // RVA: 0x7FFAC4949B60
        public void get_height(){} // RVA: 0x7FFAC4949BB0
        public void get_gammaCorrectDepth(){} // RVA: 0x7FFAC4949C00
        public void get_gammaCorrectColor(){} // RVA: 0x7FFAC4949CA0
        public void get_cppTexture(){} // RVA: 0x7FFAC4949CF0
        public void get_textureIsFlipped(){} // RVA: 0x7FFAC4949D50
        public void get_poster(){} // RVA: 0x7FFAC30E5600
        public void set_poster(){} // RVA: 0x7FFAC4949DA0
        public void get_disablePoster(){} // RVA: 0x7FFAC313E620
        public void set_disablePoster(){} // RVA: 0x7FFAC4949EE0
        public void GetDataSource(){} // RVA: 0x7FFAC2E8DC40
        public void DoResize(){} // RVA: 0x7FFAC4949F00
        public void DoGenerate(){} // RVA: 0x7FFAC494A280
        public void ResetDataSources(){} // RVA: 0x7FFAC494A780
        public void SetProperties(){} // RVA: 0x7FFAC494B260 | overloaded x3
        public void get_isSetup(){} // RVA: 0x7FFAC494B6D0
        public void OnEnable(){} // RVA: 0x7FFAC494B710
        public void OnDisable(){} // RVA: 0x7FFAC494BB20
        public void Start(){} // RVA: 0x7FFAC494BDC0
        public void Update(){} // RVA: 0x7FFAC494BED0
        public void LateUpdate(){} // RVA: 0x7FFAC494BF90
        public void OnDestroy(){} // RVA: 0x7FFAC494C030
        public void OnApplicationQuit(){} // RVA: 0x7FFAC494C2B0
        public void .ctor(){} // RVA: 0x7FFAC494C3A0
        public void .cctor(){} // RVA: 0x7FFAC494C3F0
    }

    public class ClipEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class ClipPlayer : MonoBehaviour
    {
        public bool videoLoaded; // 0x20
        public Depthkit.PlayerEvents events; // 0x28

        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x7FFAC300F9D0
        public void set_videoLoaded(){} // RVA: 0x7FFAC300F9E0
        public void CreatePlayer(){} // RVA: 0x7FFAC2C70980
        public void IsPlayerCreated(){} // RVA: 0x7FFAC2C59D00
        public void IsPlayerSetup(){} // RVA: 0x7FFAC2C59D00
        public void Load(){} // RVA: 0x7FFAC2C58E90
        public void StartVideoLoad(){} // RVA: 0x7FFAC2C70980
        public void LoadAndPlay(){} // RVA: 0x7FFAC2C58E90
        public void SetVideoPath(){} // RVA: 0x7FFAC2C70A40
        public void GetVideoPath(){} // RVA: 0x7FFAC2C58E90
        public void OnMetadataUpdated(){} // RVA: 0x7FFAC2C70A40
        public void Play(){} // RVA: 0x7FFAC2C70980
        public void Pause(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void RemoveComponents(){} // RVA: 0x7FFAC2C70980
        public void GetTexture(){} // RVA: 0x7FFAC2C58E90
        public void IsTextureFlipped(){} // RVA: 0x7FFAC2C59D00
        public void GammaCorrectDepth(){} // RVA: 0x7FFAC2C59960
        public void GammaCorrectColor(){} // RVA: 0x7FFAC2C59960
        public void GetPlayerTypeName(){} // RVA: 0x7FFAC2C58E90
        public void GetPlayerPrettyName(){} // RVA: 0x7FFAC495A0D0
        public void IsPlaying(){} // RVA: 0x7FFAC2C59D00
        public void GetCurrentTime(){} // RVA: 0x7FFAC2C5EB60
        public void GetCurrentFrame(){} // RVA: 0x7FFAC2C59960
        public void GetDuration(){} // RVA: 0x7FFAC2C5EB60
        public void Seek(){} // RVA: 0x7FFAC2C7E480
        public void GetVideoWidth(){} // RVA: 0x7FFAC2C59960
        public void GetVideoHeight(){} // RVA: 0x7FFAC2C59960
        public void SupportsPosterFrame(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC495A110
    }

    public class ClipPlayerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class CoreLook : ProceduralLook
    {
        public UnityEngine.Shader s_defaultUnlitPhotoLookShader;
        public UnityEngine.Material s_defaultUnlitPhotoLookMaterial; // 0x8

        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAC4957870
        public void GetLookName(){} // RVA: 0x7FFAC4957B50
        public void SetDefaults(){} // RVA: 0x7FFAC4957B90
        public void SetDataSources(){} // RVA: 0x7FFAC4957CC0
        public void .ctor(){} // RVA: 0x7FFAC4957E10
    }

    public class CoreMeshSource : MeshSource
    {
        public float meshDensity; // 0x90
        public 0x6B2A9E28 latticeMaxTriangles; // 0x94
        public UnityEngine.Vector2Int latticeResolution; // 0x98
        public uint scaledPerspectiveResolution; // 0xA0
        public 0x6B2A9E80 vertexBuffer; // 0xA4
        public float adjustableNormalSlope; // 0xA8
        public float edgeCompressionNoiseThreshold; // 0xAC
        public float clipThreshold; // 0xB0
        public bool ditherEdge; // 0xB4
        public float ditherWidth; // 0xB8
        public uint vertexCount; // 0xBC
        public UnityEngine.ComputeBuffer m_vertexBuffer; // 0xC0
        public int m_vertexBufferSlices; // 0xC8
        public UnityEngine.ComputeShader m_generateDataCompute; // 0xD0
        public Depthkit.MaskGenerator maskGenerator; // 0xD8

        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x7FFAC494CBE0
        public void set_meshDensity(){} // RVA: 0x7FFAC494CC00
        public void get_latticeMaxTriangles(){} // RVA: 0x7FFAC489E510
        public void get_latticeResolution(){} // RVA: 0x7FFAC354DFB0
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7FFAC494CCB0
        public void ResizeLattice(){} // RVA: 0x7FFAC494CD60
        public void get_vertexBuffer(){} // RVA: 0x7FFAC2F8C120
        public void GetComputeShaderName(){} // RVA: 0x7FFAC494CE90
        public void GetKernelNamePostfix(){} // RVA: 0x7FFAC494CED0
        public void FindKernelId(){} // RVA: 0x7FFAC494CF70
        public void GenerateVertexBuffer(){} // RVA: 0x7FFAC494D1D0
        public void GenerateTriangles(){} // RVA: 0x7FFAC494DCF0 | overloaded x2
        public void GenerateVertices(){} // RVA: 0x7FFAC494D480
        public void GenerateNormals(){} // RVA: 0x7FFAC494D9B0
        public void DataSourceName(){} // RVA: 0x7FFAC494E120
        public void EnsureVertexBuffer(){} // RVA: 0x7FFAC494E160
        public void AcquireResources(){} // RVA: 0x7FFAC494E290
        public void FreeResources(){} // RVA: 0x7FFAC494E460
        public void OnSetup(){} // RVA: 0x7FFAC494E4A0
        public void baseResize(){} // RVA: 0x7FFAC494E520
        public void OnResize(){} // RVA: 0x7FFAC494E530
        public void GenerateEdgeMask(){} // RVA: 0x7FFAC494E6D0
        public void OnGenerate(){} // RVA: 0x7FFAC494E7B0
        public void SetProperties(){} // RVA: 0x7FFAC494EDF0 | overloaded x3
        public void EnsureMaskGenerator(){} // RVA: 0x7FFAC494EFB0
        public void .ctor(){} // RVA: 0x7FFAC494F1C0
    }

    public class DataSource : MonoBehaviour
    {
        public Depthkit.DataSourceEvents clip; // 0x20
        public bool dataSourceParent; // 0x28
        public Depthkit.Clip m_clip; // 0x30
        public string m_parent; // 0x38
        public bool m_doUpdate; // 0x40
        public bool m_doResize; // 0x41
        public System.Collections.Generic.List`1<System.WeakReference> m_children; // 0x48

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFAC31D95E0
        public void get_dataSourceParent(){} // RVA: 0x7FFAC31D0140
        public void DataSourceName(){} // RVA: 0x7FFAC2C58E90
        public void GetChild(){} // RVA: 0x7FFAC2E8DC40
        public void ResetChildren(){} // RVA: 0x7FFAC494F530
        public void AcquireResources(){} // RVA: 0x7FFAC2F21310
        public void FreeResources(){} // RVA: 0x7FFAC2F21310
        public void OnAwake(){} // RVA: 0x7FFAC2F21310
        public void OnCleanup(){} // RVA: 0x7FFAC2F21310
        public void OnSetup(){} // RVA: 0x7FFAC2C59D00
        public void OnResize(){} // RVA: 0x7FFAC2C59D00
        public void OnGenerate(){} // RVA: 0x7FFAC2C59D00
        public void OnUpdate(){} // RVA: 0x7FFAC2F21310
        public void CanGenerate(){} // RVA: 0x7FFAC3006850
        public void Awake(){} // RVA: 0x7FFAC494F760
        public void Start(){} // RVA: 0x7FFAC494F920
        public void ScheduleGenerate(){} // RVA: 0x7FFAC37495E0
        public void ScheduleResize(){} // RVA: 0x7FFAC494F940
        public void UnscheduleGenerate(){} // RVA: 0x7FFAC3749060
        public void UnscheduleResize(){} // RVA: 0x7FFAC494F950
        public void OnEnable(){} // RVA: 0x7FFAC494F960
        public void OnDisable(){} // RVA: 0x7FFAC494FC00
        public void Reset(){} // RVA: 0x7FFAC494FE90
        public void Setup(){} // RVA: 0x7FFAC494FEA0
        public void Cleanup(){} // RVA: 0x7FFAC4950150
        public void Resize(){} // RVA: 0x7FFAC4950550
        public void IsSetup(){} // RVA: 0x7FFAC30F6BA0
        public void Generate(){} // RVA: 0x7FFAC4950950
        public void Update(){} // RVA: 0x7FFAC4950D80
        public void LateUpdate(){} // RVA: 0x7FFAC4950DA0
        public void .ctor(){} // RVA: 0x7FFAC4950DE0
    }

    public class DataSourceEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class DataSourceEvents : Object
    {
        public Depthkit.DataSourceEventHandler m_dataGenerated; // 0x10
        public Depthkit.DataSourceEventHandler m_dataResized; // 0x18

        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7FFAC4950F50
        public void remove_m_dataGenerated(){} // RVA: 0x7FFAC4951040
        public void add_dataGenerated(){} // RVA: 0x7FFAC4951130
        public void remove_dataGenerated(){} // RVA: 0x7FFAC4951300
        public void add_m_dataResized(){} // RVA: 0x7FFAC4951410
        public void remove_m_dataResized(){} // RVA: 0x7FFAC4951500
        public void add_dataResized(){} // RVA: 0x7FFAC49515F0
        public void remove_dataResized(){} // RVA: 0x7FFAC49517C0
        public void OnDataGenerated(){} // RVA: 0x7FFAC49518D0
        public void OnDataResized(){} // RVA: 0x7FFAC49518F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DepthkitLookEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class GaussianBlurFilter : Object
    {
        public float hasTexture; // 0x10
        public int texture; // 0x14
        public int slices; // 0x18
        public int m_prevReductionFactor; // 0x1C
        public UnityEngine.RenderTexture[] m_textures; // 0x20
        public int m_currentTexture; // 0x28
        public UnityEngine.ComputeShader m_blurCompute; // 0x30
        public string s_defaultComputeBlurShaderName;
        public UnityEngine.Vector4 m_pongSize; // 0x38

        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x7FFAC495C6A0
        public void get_texture(){} // RVA: 0x7FFAC495C6B0
        public void CreateTextures(){} // RVA: 0x7FFAC495C6E0
        public void Setup(){} // RVA: 0x7FFAC495CBD0
        public void EnsureTextures(){} // RVA: 0x7FFAC495CCB0
        public void DoBlur(){} // RVA: 0x7FFAC495CF20
        public void BlurPass(){} // RVA: 0x7FFAC495D0C0
        public void Release(){} // RVA: 0x7FFAC495D6C0
        public void .ctor(){} // RVA: 0x7FFAC495D840
        public void .cctor(){} // RVA: 0x7FFAC495D860
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFAC2C79B30 | overloaded x3
    }

    public class IndexedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC494CBB0
    }

    public class Info : Object
    {
        public Depthkit.Version Version;

        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7FFAC495E3A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC495E7D0
    }

    public class Look : MonoBehaviour
    {
        public Depthkit.Clip materialPropertyBlock; // 0x20
        public bool showPerViewColorDebug; // 0x28
        public bool showCameraFrustums; // 0x29
        public Depthkit.DepthkitLookEventHandler onUpdated; // 0x30
        public UnityEngine.MaterialPropertyBlock m_materialPropertyBlock; // 0x38
        public Depthkit.MeshSource meshSource; // 0x40
        public UnityEngine.BoxCollider m_collider; // 0x48
        public bool m_bIsInit; // 0x50

        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7FFAC4957E60
        public void get_materialPropertyBlock(){} // RVA: 0x7FFAC4957F70
        public void GetLookName(){} // RVA: 0x7FFAC2C58E90
        public void UsesMaterial(){} // RVA: 0x7FFAC2C59D00
        public void GetMaterial(){} // RVA: 0x7FFAC2C58E90
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFAC3006850
        public void GetMaterialPropertyBlock(){} // RVA: 0x7FFAC4957F70
        public void SetDataSources(){} // RVA: 0x7FFAC2C70980
        public void ValidateDataSources(){} // RVA: 0x7FFAC4957F90
        public void SetMaterialProperties(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnUpdate(){} // RVA: 0x7FFAC3708F90
        public void SetDefaults(){} // RVA: 0x7FFAC4958060
        public void SetLookProperties(){} // RVA: 0x7FFAC4958100
        public void Awake(){} // RVA: 0x7FFAC49589C0
        public void Init(){} // RVA: 0x7FFAC4958BF0
        public void Start(){} // RVA: 0x7FFAC4958F30
        public void OnEnable(){} // RVA: 0x7FFAC4958F60
        public void OnDisable(){} // RVA: 0x7FFAC4959090
        public void SyncColliderToBounds(){} // RVA: 0x7FFAC49592A0
        public void OnMetaDataUpdated(){} // RVA: 0x7FFAC4959670
        public void LateUpdate(){} // RVA: 0x7FFAC4959680
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class MaskGenerator : Object
    {
        public Depthkit.Clip perspectivesToSlice; // 0x10
        public int sliceToPerspective; // 0x18
        public float sliceCount; // 0x1C
        public float blurRadius; // 0x20
        public UnityEngine.ComputeShader paddedUVScaleFactor; // 0x28
        public 0x6B17C180 maskTexture; // 0x30
        public UnityEngine.RenderTexture downScale; // 0x38
        public UnityEngine.Vector4 downScaledMaskTexture; // 0x40
        public UnityEngine.Vector4[] m_perspectivesToSlice; // 0x50
        public UnityEngine.Vector4[] m_sliceToPerspective; // 0x58
        public bool enableBlur; // 0x60
        public bool enableMaskDebug; // 0x61
        public Depthkit.GaussianBlurFilter m_blurFilter; // 0x68
        public float sobelMultiplier; // 0x70
        public UnityEngine.ComputeShader m_sobelFilterCompute; // 0x78
        public int m_sobelFilterKId; // 0x80
        public int m_downScale; // 0x84
        public UnityEngine.ComputeShader m_downScaleCompute; // 0x88
        public int m_downScaleKId; // 0x90
        public UnityEngine.RenderTexture m_downScaledMaskTexture; // 0x98

        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x7FFAC2FC20E0
        public void set_perspectivesToSlice(){} // RVA: 0x7FFAC30794D0
        public void get_sliceToPerspective(){} // RVA: 0x7FFAC2FE9500
        public void set_sliceToPerspective(){} // RVA: 0x7FFAC2FE9510
        public void get_sliceCount(){} // RVA: 0x7FFAC4951910
        public void set_sliceCount(){} // RVA: 0x7FFAC4951930
        public void get_blurRadius(){} // RVA: 0x7FFAC4951940
        public void set_blurRadius(){} // RVA: 0x7FFAC4951960
        public void get_paddedUVScaleFactor(){} // RVA: 0x7FFAC4951980
        public void get_maskTexture(){} // RVA: 0x7FFAC4951B80
        public void get_downScale(){} // RVA: 0x7FFAC46D5110
        public void set_downScale(){} // RVA: 0x7FFAC4951BD0
        public void get_downScaledMaskTexture(){} // RVA: 0x7FFAC4951C50
        public void DownScalePass(){} // RVA: 0x7FFAC4951CC0
        public void DownScaleMaskTexture(){} // RVA: 0x7FFAC4951E60
        public void Setup(){} // RVA: 0x7FFAC4952C20
        public void EnsureTexture(){} // RVA: 0x7FFAC4953170
        public void Release(){} // RVA: 0x7FFAC4953450
        public void SobelFilterMask(){} // RVA: 0x7FFAC4953600
        public void BlurMask(){} // RVA: 0x7FFAC49539F0
        public void GenerateMask(){} // RVA: 0x7FFAC4953A30
        public void SetProperties(){} // RVA: 0x7FFAC4954230 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC4954670
    }

    public class MeshSource : DataSource
    {
        public bool currentSubmeshIndex; // 0x50
        public Depthkit.SubMesh[] triangleBuffer; // 0x58
        public uint[] triangleBufferDispatchIndirectArgs; // 0x60
        public bool triangleBufferDrawIndirectArgs; // 0x68
        public uint maxSurfaceTriangles; // 0x6C
        public bool useTriangleMesh; // 0x70
        public float triangleMesh;
        public float radialBiasMax;
        public float radialBiasDefault;
        public float radialBias; // 0x74
        public float[] radialBiasPersp; // 0x78
        public UnityEngine.Vector4[] radialBiasPerspInMeters; // 0x80
        public bool pauseDataGenerationWhenInvisible; // 0x88
        public bool pausePlayerWhenInvisible; // 0x89
        public bool m_wasPlaying; // 0x8A
        public bool m_doGeneration; // 0x8B
        public bool m_pausedFromRenderer; // 0x8C
        public bool m_seenOnce; // 0x8D

        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CurrentSubMesh(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ReserveSubMeshes(){} // RVA: 0x7FFAC2C70ED0
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFAC47BAB70
        public void set_currentSubmeshIndex(){} // RVA: 0x7FFAC47BAB80
        public void get_triangleBuffer(){} // RVA: 0x7FFAC4954E80
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7FFAC4954ED0
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7FFAC4954F20
        public void get_maxSurfaceTriangles(){} // RVA: 0x7FFAC4954F70
        public void set_maxSurfaceTriangles(){} // RVA: 0x7FFAC4954FC0
        public void get_useTriangleMesh(){} // RVA: 0x7FFAC2F9D320
        public void set_useTriangleMesh(){} // RVA: 0x7FFAC4955020
        public void get_triangleMesh(){} // RVA: 0x7FFAC4955080
        public void EnsureRadialBias(){} // RVA: 0x7FFAC49550C0
        public void AcquireResources(){} // RVA: 0x7FFAC4955370
        public void FreeResources(){} // RVA: 0x7FFAC4955430
        public void CanGenerate(){} // RVA: 0x7FFAC49554A0
        public void OnSetup(){} // RVA: 0x7FFAC49555A0
        public void OnResize(){} // RVA: 0x7FFAC49556F0
        public void OnUpdate(){} // RVA: 0x7FFAC49559A0
        public void OnGenerate(){} // RVA: 0x7FFAC4955B70
        public void GetLocalBounds(){} // RVA: 0x7FFAC4955E30
        public void GetWorldBounds(){} // RVA: 0x7FFAC4956000
        public void Pause(){} // RVA: 0x7FFAC4956340
        public void Continue(){} // RVA: 0x7FFAC49563D0
        public void OnBecameVisible(){} // RVA: 0x7FFAC4956470
        public void OnBecameInvisible(){} // RVA: 0x7FFAC4956490
        public void CheckVisibility(){} // RVA: 0x7FFAC49564B0
        public void SetProperties(){} // RVA: 0x7FFAC4956720 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC4956830
    }

    public class Metadata : Object
    {
        public int perspectiveCPPResolution;
        public uint perspectiveResolution; // 0x4
        public float paddedTextureDimensions;
        public int _versionMajor; // 0x10
        public int _versionMinor; // 0x14
        public string format; // 0x18
        public int textureWidth; // 0x20
        public int textureHeight; // 0x24
        public UnityEngine.Vector3 boundsCenter; // 0x28
        public UnityEngine.Vector3 boundsSize; // 0x34
        public Perspective[] perspectives; // 0x40
        public int perspectivesCount; // 0x48
        public int numRows; // 0x4C
        public int numColumns; // 0x50
        public int numAngles; // 0x54

        // ── Methods ──
        public void Valid(){} // RVA: 0x7FFAC495E820
        public void get_perspectiveCPPResolution(){} // RVA: 0x7FFAC495E840
        public void get_perspectiveResolution(){} // RVA: 0x7FFAC495E8B0
        public void get_paddedTextureDimensions(){} // RVA: 0x7FFAC495E930
        public void FromSinglePerspective(){} // RVA: 0x7FFAC495E9B0
        public void CreateFromJSON(){} // RVA: 0x7FFAC495EC80
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7FFAC495F870
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC495FC10
    }

    public class PackedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC494CB80
    }

    public class PerspectiveColorBlending : ValueType
    {
        public int enabled; // 0x10
        public float edgeMaskEnabled; // 0x14
        public float edgeMaskBlendEdgeMin; // 0x18
        public float edgeMaskBlendEdgeMax; // 0x1C
        public float edgeMaskStrength; // 0x20
        public float viewWeightPowerContribution; // 0x24
        public float pad0; // 0x28
        public float pad1; // 0x2C

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC496F6B0
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC496F7E0
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7FFAC496FAA0
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7FFAC496FAE0
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFAC496FBA0
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFAC496FBE0
        public void GetEdgeMaskStrength(){} // RVA: 0x7FFAC496FCA0
        public void SetEdgeMaskStrength(){} // RVA: 0x7FFAC496FCE0
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFAC496FDA0
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFAC496FDE0
        public void GetEdgeMaskEnabled(){} // RVA: 0x7FFAC496FEA0
        public void SetEdgeMaskEnabled(){} // RVA: 0x7FFAC496FEF0
        public void GetPerspectiveEnabled(){} // RVA: 0x7FFAC496FFA0
        public void SetPerspectiveEnabled(){} // RVA: 0x7FFAC496FFE0
    }

    public class PerspectiveGeometry : ValueType
    {
        public int enabled; // 0x10
        public int overrideWeightUnknown; // 0x14
        public float weightUnknown; // 0x18
        public float viewDependentUnseenAmount; // 0x1C
        public float viewDependentInFrontAmount; // 0x20
        public float viewDependentWeight; // 0x24
        public float pad2; // 0x28
        public float pad1; // 0x2C

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC4970080
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        public bool[] m_geometryMatchesColorWeights; // 0x30
        public float[] m_viewDependentContributions; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49701B0
        public void EnableGeometry(){} // RVA: 0x7FFAC4970590 | overloaded x2
        public void GetOverrideWeightUnknown(){} // RVA: 0x7FFAC4970630
        public void SetOverrideWeightUnknown(){} // RVA: 0x7FFAC4970670
        public void GetWeightUnknown(){} // RVA: 0x7FFAC496FBA0
        public void SetWeightUnknown(){} // RVA: 0x7FFAC4970710
        public void MatchViewDependentColorWeight(){} // RVA: 0x7FFAC4970800 | overloaded x2
        public void GetViewDependentContribution(){} // RVA: 0x7FFAC4970830
        public void SetViewDependentContribution(){} // RVA: 0x7FFAC4970860
        public void GetViewDependentWeight(){} // RVA: 0x7FFAC496FAA0
        public void SetViewDependentWeight(){} // RVA: 0x7FFAC49708B0
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7FFAC496FCA0
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7FFAC4970970
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7FFAC496FDA0
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7FFAC4970A30
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC495FD70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PlayerEvents : Object
    {
        public Depthkit.ClipPlayerEventHandler playbackStarted; // 0x10
        public Depthkit.ClipPlayerEventHandler playbackPaused; // 0x18
        public Depthkit.ClipPlayerEventHandler playbackStopped; // 0x20
        public Depthkit.ClipPlayerEventHandler loadingStarted; // 0x28
        public Depthkit.ClipPlayerEventHandler loadingFinished; // 0x30

        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x7FFAC495A1E0
        public void remove_playbackStarted(){} // RVA: 0x7FFAC495A2D0
        public void add_playbackPaused(){} // RVA: 0x7FFAC495A3C0
        public void remove_playbackPaused(){} // RVA: 0x7FFAC495A4B0
        public void add_playbackStopped(){} // RVA: 0x7FFAC495A5A0
        public void remove_playbackStopped(){} // RVA: 0x7FFAC495A690
        public void add_loadingStarted(){} // RVA: 0x7FFAC495A780
        public void remove_loadingStarted(){} // RVA: 0x7FFAC495A870
        public void add_loadingFinished(){} // RVA: 0x7FFAC495A960
        public void remove_loadingFinished(){} // RVA: 0x7FFAC495AA50
        public void OnClipPlaybackStarted(){} // RVA: 0x7FFAC49518D0
        public void OnClipPlaybackPaused(){} // RVA: 0x7FFAC49518F0
        public void OnClipPlaybackStopped(){} // RVA: 0x7FFAC4948B40
        public void OnClipLoadingStarted(){} // RVA: 0x7FFAC4948B80
        public void OnClipLoadingFinished(){} // RVA: 0x7FFAC4948B60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProceduralLook : Look
    {
        public 0x6B186940 shadowCastingMode; // 0x58
        public bool receiveShadows; // 0x5C
        public bool interpolateLightProbes; // 0x5D
        public UnityEngine.Transform anchorOverride; // 0x60
        public UnityEngine.Material lookMaterial; // 0x68

        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x7FFAC3006850
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFAC3006850
        public void SetMaterialProperties(){} // RVA: 0x7FFAC4959970
        public void OnUpdate(){} // RVA: 0x7FFAC4959E10
        public void .ctor(){} // RVA: 0x7FFAC4957E10
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        public UnityEngine.Events.UnityEvent onFrameBegin; // 0x20
        public UnityEngine.Events.UnityEvent onFrameEnd; // 0x28
        public int captureFramteRate; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC495FF70
        public void Update(){} // RVA: 0x7FFAC495FF80
        public void LateUpdate(){} // RVA: 0x7FFAC495FFA0
        public void .ctor(){} // RVA: 0x7FFAC495FFC0
    }

    public class StudioLiteLook : ProceduralLook
    {
        public UnityEngine.Shader s_defaultMainStencilShader;
        public UnityEngine.Material s_defaultMainStencilMaterial; // 0x8
        public UnityEngine.Shader s_defaultMainShader; // 0x10
        public UnityEngine.Material s_defaultMainMaterial; // 0x18
        public UnityEngine.Shader s_defaultMainEdgeStencilShader; // 0x20
        public UnityEngine.Material s_defaultMainEdgeStencilMaterial; // 0x28
        public UnityEngine.Shader s_defaultMainEdgeShader; // 0x30
        public UnityEngine.Material s_defaultMainEdgeMaterial; // 0x38
        public UnityEngine.Shader s_defaultFillShader; // 0x40
        public UnityEngine.Material s_defaultFillMaterial; // 0x48
        public UnityEngine.Shader s_defaultFillEdgeShader; // 0x50
        public UnityEngine.Material s_defaultFillEdgeMaterial; // 0x58
        public UnityEngine.Material mainPerspectiveStencil; // 0x70
        public UnityEngine.Material mainPerspectiveEdgeStencil; // 0x78
        public UnityEngine.Material mainPerspective; // 0x80
        public UnityEngine.Material mainPerspectiveEdge; // 0x88
        public UnityEngine.Material fillPerspectives; // 0x90
        public UnityEngine.Material fillPerspectivesEdges; // 0x98
        public bool showMain; // 0xA0
        public bool showMainEdge; // 0xA1
        public bool showFill; // 0xA2
        public bool showFillEdge; // 0xA3

        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAC4972AF0
        public void GetLookName(){} // RVA: 0x7FFAC49737A0
        public void SetDefaults(){} // RVA: 0x7FFAC49737E0
        public void SetDataSources(){} // RVA: 0x7FFAC4973F40
        public void OnUpdate(){} // RVA: 0x7FFAC4974090
        public void .ctor(){} // RVA: 0x7FFAC49743E0
    }

    public class StudioLiteMeshSource : CoreMeshSource
    {
        public UnityEngine.Transform volumeViewpoint; // 0xE0
        public int maxPerspectivesToRender; // 0xE8
        public bool enableAdaptiveThreshold; // 0xEC
        public float maxViewAngleCosThreshold; // 0xF0
        public float minClipThreshold; // 0xF4
        public float minDitherWidth; // 0xF8

        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x7FFAC4970C60
        public void GetKernelNamePostfix(){} // RVA: 0x7FFAC4970CA0
        public void GenerateTriangles(){} // RVA: 0x7FFAC4970DB0
        public void DataSourceName(){} // RVA: 0x7FFAC49714A0
        public void OnResize(){} // RVA: 0x7FFAC49714E0
        public void GenerateEdgeMask(){} // RVA: 0x7FFAC49717F0
        public void OnGenerate(){} // RVA: 0x7FFAC49718E0
        public void .ctor(){} // RVA: 0x7FFAC4972930
    }

    public class StudioLook : ProceduralLook
    {
        public UnityEngine.Shader s_defaultUnlitPhotoLookShader;
        public UnityEngine.Material s_defaultUnlitPhotoLookMaterial; // 0x8

        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAC496F110
        public void GetLookName(){} // RVA: 0x7FFAC496F3F0
        public void SetDataSources(){} // RVA: 0x7FFAC496F430
        public void SetDefaults(){} // RVA: 0x7FFAC496F580
        public void .ctor(){} // RVA: 0x7FFAC4957E10
    }

    public class StudioMeshSource : MeshSource
    {
        public 0x6B2B9708 currentLevelOfDetailLevel; // 0x90
        public UnityEngine.ComputeShader volumeBounds; // 0x98
        public UnityEngine.ComputeShader volumeDensity; // 0xA0
        public UnityEngine.ComputeShader numLevelOfDetailLevels; // 0xA8
        public UnityEngine.ComputeShader useTextureAtlas; // 0xB0
        public UnityEngine.ComputeShader enableEdgeMask; // 0xB8
        public bool showVolumePreview; // 0xC0
        public UnityEngine.Material m_volumePreviewMaterial; // 0xC8
        public float volumePreviewAlpha; // 0xD0
        public float volumePreviewPointSize; // 0xD4
        public bool automaticLevelOfDetail; // 0xD8
        public float levelOfDetailDistance; // 0xDC
        public int m_currentLODLevel; // 0xE0
        public int m_currentLODIsoScalar; // 0xE4
        public UnityEngine.Camera m_mainCamera; // 0xE8
        public UnityEngine.Bounds m_volumeBounds; // 0xF0
        public float m_volumeDensity; // 0x108
        public UnityEngine.Vector3Int m_voxelGridDimensions; // 0x10C
        public int <numLevelOfDetailLevels>k__BackingField; // 0x118
        public int m_totalVoxelCount; // 0x11C
        public float surfaceSmoothingRadius; // 0x120
        public bool enableSurfaceSmoothing; // 0x124
        public float m_surfaceSensitivityThreshold; // 0x128
        public float surfaceSensitivityDefault;
        public float weightUnknownDefault;
        public float weightUnseenMaxDefault;
        public float weightUnseenMinDefault;
        public float weightUnseenFalloffPowerDefault;
        public float weightInFrontMaxDefault;
        public float weightInFrontMinDefault;
        public float surfaceSensitivity; // 0x12C
        public float weightUnknown; // 0x130
        public float weightUnseenMax; // 0x134
        public float weightUnseenMin; // 0x138
        public float weightUnseenFalloffPower; // 0x13C
        public float weightInFrontMax; // 0x140
        public float weightInFrontMin; // 0x144
        public UnityEngine.Transform volumeViewpoint; // 0x148
        public float surfaceNormalColorBlendingPower; // 0x150
        public float perViewDisparityThreshold; // 0x154
        public float perViewDisparityBlendWidth; // 0x158
        public float disparityMin; // 0x15C
        public float globalViewDependentColorBlendWeight; // 0x160
        public float globalViewDependentGeometryBlendWeight; // 0x164
        public bool enableViewDependentGeometry; // 0x168
        public 0x6B2B97B8 untexturedFragmentSetting; // 0x16C
        public UnityEngine.Color untexturedColor; // 0x170
        public UnityEngine.ComputeBuffer[] m_sdfBuffers; // 0x180
        public int m_currentSdfBuffer; // 0x188
        public UnityEngine.ComputeBuffer m_pointsBuffer; // 0x190
        public int m_triangleConnectionTableSize;
        public int m_triangleOffsetsSize;
        public int m_numberOfTrianglesSize;
        public int m_triangleBufferSize;
        public UnityEngine.ComputeBuffer m_triangleBuffer; // 0x198
        public UnityEngine.Material m_halfBlitMaterial; // 0x1A0
        public UnityEngine.RenderTexture m_normalWeightTexture; // 0x1A8
        public UnityEngine.Vector4 m_normalWeightTextureTexelSize; // 0x1B0
        public UnityEngine.Material m_normalWeightGenerationMaterial; // 0x1C0
        public int m_generateVolumeKernelGroupSize; // 0x1C8
        public int m_extractSurfaceKernelGroupSize; // 0x1CC
        public int m_extractSurfaceKId; // 0x1D0
        public int m_normalWeightKId; // 0x1D4
        public int m_generateVolumeSinglePassKId; // 0x1D8
        public int m_generateVolumeMultiPassInitKId; // 0x1DC
        public int m_generateVolumeMultiPassAccumulateKId; // 0x1E0
        public int m_generateVolumeMultiPassResolveKId; // 0x1E4
        public int m_generateVolumePreviewKId; // 0x1E8
        public Depthkit.PerspectiveColorBlendingData perspectiveColorBlendingData; // 0x1F0
        public Depthkit.PerspectiveGeometryData perspectiveGeometryData; // 0x1F8
        public bool[] overrideRadialBias; // 0x200
        public int perspectivesCount; // 0x208
        public int normalWeightResolutionReduction; // 0x20C
        public bool m_useTextureAtlas; // 0x210
        public int[] triangleOffsets;
        public int[,] triangleConnectionTable; // 0x8
        public int[] nrOfTriangles; // 0x10
        public Depthkit.MaskGenerator maskGenerator; // 0x218
        public bool m_enableEdgeMask; // 0x220

        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7FFAC4966030
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7FFAC4837F50
        public void get_volumeBounds(){} // RVA: 0x7FFAC49660B0
        public void set_volumeBounds(){} // RVA: 0x7FFAC49660D0
        public void GetLocalBounds(){} // RVA: 0x7FFAC49660B0
        public void get_volumeDensity(){} // RVA: 0x7FFAC49661C0
        public void set_volumeDensity(){} // RVA: 0x7FFAC49661D0
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7FFAC49661E0
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7FFAC49661F0
        public void set_useTextureAtlas(){} // RVA: 0x7FFAC36D63C0
        public void DataSourceName(){} // RVA: 0x7FFAC4966200
        public void GetScaledKernelName(){} // RVA: 0x7FFAC4966240
        public void GetExtractVolumeKernelName(){} // RVA: 0x7FFAC4966470
        public void OnAwake(){} // RVA: 0x7FFAC4966640
        public void OnSetup(){} // RVA: 0x7FFAC49667D0
        public void ResetGPUResources(){} // RVA: 0x7FFAC4966EC0
        public void AcquireResources(){} // RVA: 0x7FFAC4966F20
        public void FreeResources(){} // RVA: 0x7FFAC49671B0
        public void EnsureBuffers(){} // RVA: 0x7FFAC49675F0
        public void EnsureTextures(){} // RVA: 0x7FFAC49677B0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7FFAC2E8DC40
        public void EnsureSyncedBuffers(){} // RVA: 0x7FFAC4967A40
        public void SetupViewDependence(){} // RVA: 0x7FFAC4967CA0
        public void OnNewMetadata(){} // RVA: 0x7FFAC4968300
        public void ResetVolumeBounds(){} // RVA: 0x7FFAC49684F0
        public void ResetSurfaceSensitivity(){} // RVA: 0x7FFAC4968570
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7FFAC4968630
        public void OnResize(){} // RVA: 0x7FFAC4968670
        public void SetProperties(){} // RVA: 0x7FFAC4969520 | overloaded x3
        public void SetCommonComputeProperties(){} // RVA: 0x7FFAC4969810
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7FFAC4969DF0
        public void FilterSdf(){} // RVA: 0x7FFAC496A190
        public void GenerateNormalWeights(){} // RVA: 0x7FFAC496A8C0
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7FFAC496AB00
        public void GenerateEdgeBlendMask(){} // RVA: 0x7FFAC496ADF0
        public void DispatchSize(){} // RVA: 0x7FFAC496AE70
        public void GenerateVolumePass(){} // RVA: 0x7FFAC496AF10
        public void GenerateVolume(){} // RVA: 0x7FFAC496AFB0
        public void ActivePerspectives(){} // RVA: 0x7FFAC496B0D0
        public void GenerateVolumeMultiPass(){} // RVA: 0x7FFAC496B1D0
        public void GenerateVolumeSinglePass(){} // RVA: 0x7FFAC496B790
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7FFAC496B960
        public void DrawDebug(){} // RVA: 0x7FFAC496BDD0
        public void OnGenerate(){} // RVA: 0x7FFAC496C5E0
        public void OnUpdate(){} // RVA: 0x7FFAC496CB40
        public void EnsureMaskGenerator(){} // RVA: 0x7FFAC496D400
        public void get_enableEdgeMask(){} // RVA: 0x7FFAC496D6A0
        public void set_enableEdgeMask(){} // RVA: 0x7FFAC496D6C0
        public void .ctor(){} // RVA: 0x7FFAC496D6D0
        public void .cctor(){} // RVA: 0x7FFAC496D900
    }

    public class SubMesh : Object
    {
        public uint triangleBuffer; // 0x10
        public UnityEngine.ComputeBuffer trianglesCount; // 0x18
        public UnityEngine.ComputeBuffer dispatchIndirectArgs; // 0x20
        public UnityEngine.ComputeBuffer drawIndirectArgs; // 0x28
        public UnityEngine.ComputeBuffer source; // 0x30
        public Depthkit.MeshSource triangleMesh; // 0x38
        public bool useTriangleMesh; // 0x40
        public Depthkit.TriangleMesh m_triangleMesh; // 0x48

        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_triangleBuffer(){} // RVA: 0x7FFAC2F247C0
        public void get_trianglesCount(){} // RVA: 0x7FFAC2F4F0C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7FFAC2F4F130
        public void get_drawIndirectArgs(){} // RVA: 0x7FFAC31D95E0
        public void Init(){} // RVA: 0x7FFAC49569A0
        public void CopyTriangleCount(){} // RVA: 0x7FFAC4956A50
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7FFAC4956AC0
        public void PrepareDrawArgs(){} // RVA: 0x7FFAC4956B70
        public void PrepareDispatchArgs(){} // RVA: 0x7FFAC4956BF0
        public void EnsureBuffers(){} // RVA: 0x7FFAC4956C90
        public void Release(){} // RVA: 0x7FFAC4957070
        public void set_source(){} // RVA: 0x7FFAC31D0C20
        public void get_triangleMesh(){} // RVA: 0x7FFAC4957220
        public void SetProperties(){} // RVA: 0x7FFAC4957550 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public UnityEngine.ComputeBuffer Length;
        public T[] m_data;
        public bool m_dirty;
        public string m_name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C786D0
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void MarkDirty(){} // RVA: 0x7FFAC2C70980
        public void Sync(){} // RVA: 0x7FFAC2C59D00
        public void Release(){} // RVA: 0x7FFAC2C70980
    }

    public class TriangleMesh : Object
    {
        public Depthkit.MeshSource TriangleCount; // 0x10
        public UnityEngine.Mesh mesh; // 0x18
        public int m_triangleCount; // 0x20
        public UnityEngine.Vector3[] s_cubeVerts;
        public int[] s_cubeTriangles; // 0x8

        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x7FFAC30DBBE0
        public void set_TriangleCount(){} // RVA: 0x7FFAC4960010
        public void get_mesh(){} // RVA: 0x7FFAC4960020
        public void EnsureTriangleMesh(){} // RVA: 0x7FFAC4960910 | overloaded x3
        public void CreateMesh(){} // RVA: 0x7FFAC4960D20
        public void ReleaseMesh(){} // RVA: 0x7FFAC4960DE0
        public void GetCubeVerts(){} // RVA: 0x7FFAC4960F50
        public void GetCubeTriangles(){} // RVA: 0x7FFAC4961120
        public void ResetMeshCube(){} // RVA: 0x7FFAC4961230
        public void CreateLattice(){} // RVA: 0x7FFAC4961530
        public void addVertex(){} // RVA: 0x7FFAC49619A0
        public void CreateTriangleLattice(){} // RVA: 0x7FFAC4961B30
        public void CreateCubeMesh(){} // RVA: 0x7FFAC4961F90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        public UnityEngine.Video.VideoPlayer m_mediaPlayer; // 0x30
        public UnityEngine.AudioSource m_audioSource; // 0x38

        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x7FFAC495AB40
        public void IsPlayerCreated(){} // RVA: 0x7FFAC495B170
        public void IsPlayerSetup(){} // RVA: 0x7FFAC495B240
        public void SetVideoPath(){} // RVA: 0x7FFAC495B4D0
        public void GetVideoPath(){} // RVA: 0x7FFAC495B560
        public void StartVideoLoad(){} // RVA: 0x7FFAC495B720
        public void Load(){} // RVA: 0x7FFAC495B750
        public void OnVideoLoadingComplete(){} // RVA: 0x7FFAC495B7F0
        public void OnMetadataUpdated(){} // RVA: 0x7FFAC2F21310
        public void LoadAndPlay(){} // RVA: 0x7FFAC495B820
        public void Play(){} // RVA: 0x7FFAC495B8C0
        public void Pause(){} // RVA: 0x7FFAC495B950
        public void Stop(){} // RVA: 0x7FFAC495B9E0
        public void GetCurrentFrame(){} // RVA: 0x7FFAC495BA70
        public void GetCurrentTime(){} // RVA: 0x7FFAC495BAD0
        public void GetDuration(){} // RVA: 0x7FFAC495BB30
        public void GetTexture(){} // RVA: 0x7FFAC495BBE0
        public void IsTextureFlipped(){} // RVA: 0x7FFAC2F21320
        public void GammaCorrectDepth(){} // RVA: 0x7FFAC495BC40
        public void GammaCorrectColor(){} // RVA: 0x7FFAC495BC90
        public void IsPlaying(){} // RVA: 0x7FFAC495BCE0
        public void RemoveComponents(){} // RVA: 0x7FFAC495BD40
        public void GetPlayerTypeName(){} // RVA: 0x7FFAC495BF10
        public void GetPlayerPrettyName(){} // RVA: 0x7FFAC495BFE0
        public void GetPlayerBackend(){} // RVA: 0x7FFAC31D95E0
        public void Seek(){} // RVA: 0x7FFAC495C020
        public void GetVideoWidth(){} // RVA: 0x7FFAC495C120
        public void GetVideoHeight(){} // RVA: 0x7FFAC495C250
        public void SupportsPosterFrame(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC495A110
    }

    public class Util : Object
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7FFAC49625B0
        public void GetScaled2DKernelName(){} // RVA: 0x7FFAC49625D0
        public void GetScaled3DKernelName(){} // RVA: 0x7FFAC4962800
        public void DispatchGroups(){} // RVA: 0x7FFAC4962980
        public void ClearRenderTexture(){} // RVA: 0x7FFAC4962AE0
        public void ClearAppendBuffer(){} // RVA: 0x7FFAC4962CE0
        public void ReleaseComputeBuffer(){} // RVA: 0x7FFAC4962F50
        public void ReleaseRenderTexture(){} // RVA: 0x7FFAC4962FC0
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7FFAC4963180
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7FFAC4963570
        public void TransformBounds(){} // RVA: 0x7FFAC49637D0
        public void CreateRenderTexture(){} // RVA: 0x7FFAC4963A70
        public void EnsureRenderTexture(){} // RVA: 0x7FFAC4963CF0
        public void EnsureComputeBuffer(){} // RVA: 0x7FFAC4964260
        public void ColorForCamera(){} // RVA: 0x7FFAC49644B0
        public void RenderPerspectiveGizmo(){} // RVA: 0x7FFAC2F21310
        public void RenderMetadataGizmos(){} // RVA: 0x7FFAC2F21310
        public void IsVisible(){} // RVA: 0x7FFAC4964670
        public void metersToCm(){} // RVA: 0x7FFAC49648D0
        public void cmToMeters(){} // RVA: 0x7FFAC49648E0
        public void EnsureKeyword(){} // RVA: 0x7FFAC49648F0
        public void EnsureComputeShader(){} // RVA: 0x7FFAC49649F0
    }

    public class Version : ValueType
    {
        public byte major; // 0x10
        public byte minor; // 0x11
        public byte patch; // 0x12

        // ── Methods ──
        public void get_major(){} // RVA: 0x7FFAC495DDF0
        public void set_major(){} // RVA: 0x7FFAC495DE00
        public void get_minor(){} // RVA: 0x7FFAC495DE10
        public void set_minor(){} // RVA: 0x7FFAC3B9B9B0
        public void get_patch(){} // RVA: 0x7FFAC495DE20
        public void set_patch(){} // RVA: 0x7FFAC3B9B990
        public void .ctor(){} // RVA: 0x7FFAC495DE30
        public void ToString(){} // RVA: 0x7FFAC495DE40
        public void op_Implicit(){} // RVA: 0x7FFAC495E0A0
        public void Equals(){} // RVA: 0x7FFAC495E150 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC495E170
        public void op_Equality(){} // RVA: 0x7FFAC495E180
        public void op_Inequality(){} // RVA: 0x7FFAC495E1B0
        public void op_LessThan(){} // RVA: 0x7FFAC495E1E0
        public void op_GreaterThan(){} // RVA: 0x7FFAC495E230
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC495E280
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC495E310
    }

}