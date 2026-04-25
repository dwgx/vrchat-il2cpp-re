// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 29
// Methods: 490

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ playerEvents; // 0x20
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ metadataFilePath; // 0x28
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÎÌÌÌÌÏÏÍ metadataFile; // 0x30
        public string metadataSourceType; // 0x38
        public UnityEngine.TextAsset metadata; // 0x40
        public 0x66609C70 hasMetadata; // 0x48
        public Depthkit.Metadata perspectiveDataBuffer; // 0x50
        public 0x66609C18 player; // 0x58
        public Depthkit.ClipPlayer playerSetup; // 0x60
        public int playerIsActive; // 0x68
        public UnityEngine.Texture width; // 0x70
        public UnityEngine.Texture2D height; // 0x78
        public bool gammaCorrectDepth; // 0x80
        public System.Collections.Generic.List`1<0x66424DA8> gammaCorrectColor; // 0x88
        public bool cppTexture; // 0x90
        public bool textureIsFlipped; // 0x91
        public float poster;

        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x7FFD4FD682C0
        public void remove_newFrame(){} // RVA: 0x7FFD4FD683B0
        public void add_newPoster(){} // RVA: 0x7FFD4FD684A0
        public void remove_newPoster(){} // RVA: 0x7FFD4FD68590
        public void add_m_newMetadata(){} // RVA: 0x7FFD4FD68680
        public void remove_m_newMetadata(){} // RVA: 0x7FFD4FD68770
        public void add_newMetadata(){} // RVA: 0x7FFD4FD68860
        public void remove_newMetadata(){} // RVA: 0x7FFD4FD68A30
        public void OnNewFrame(){} // RVA: 0x7FFD4FD68B40
        public void OnNewMetadata(){} // RVA: 0x7FFD4FD68B60
        public void OnNewPoster(){} // RVA: 0x7FFD4FD68B80
        public void get_playerEvents(){} // RVA: 0x7FFD4FD68BA0
        public void get_metadataFilePath(){} // RVA: 0x7FFD4E5F0140
        public void set_metadataFilePath(){} // RVA: 0x7FFD4FD68CD0
        public void get_metadataFile(){} // RVA: 0x7FFD4E3BE740
        public void set_metadataFile(){} // RVA: 0x7FFD4FD68F10
        public void get_metadataSourceType(){} // RVA: 0x7FFD4E3E20C0
        public void get_metadata(){} // RVA: 0x7FFD4E3E20E0
        public void get_hasMetadata(){} // RVA: 0x7FFD4FD69170
        public void LoadMetadata(){} // RVA: 0x7FFD4FD691A0
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7FFD4FD693F0
        public void get_perspectiveDataBuffer(){} // RVA: 0x7FFD4FD694D0
        public void get_player(){} // RVA: 0x7FFD4E3DF370
        public void CreatePlayer(){} // RVA: 0x7FFD4FD694E0
        public void SetPlayer(){} // RVA: 0x7FFD4FD69750 | overloaded x2
        public void get_playerSetup(){} // RVA: 0x7FFD4FD69980
        public void get_playerIsActive(){} // RVA: 0x7FFD4FD69A80
        public void get_width(){} // RVA: 0x7FFD4FD69B60
        public void get_height(){} // RVA: 0x7FFD4FD69BB0
        public void get_gammaCorrectDepth(){} // RVA: 0x7FFD4FD69C00
        public void get_gammaCorrectColor(){} // RVA: 0x7FFD4FD69CA0
        public void get_cppTexture(){} // RVA: 0x7FFD4FD69CF0
        public void get_textureIsFlipped(){} // RVA: 0x7FFD4FD69D50
        public void get_poster(){} // RVA: 0x7FFD4E505600
        public void set_poster(){} // RVA: 0x7FFD4FD69DA0
        public void get_disablePoster(){} // RVA: 0x7FFD4E55E620
        public void set_disablePoster(){} // RVA: 0x7FFD4FD69EE0
        public void GetDataSource(){} // RVA: 0x7FFD4E2ADC40
        public void DoResize(){} // RVA: 0x7FFD4FD69F00
        public void DoGenerate(){} // RVA: 0x7FFD4FD6A280
        public void ResetDataSources(){} // RVA: 0x7FFD4FD6A780
        public void SetProperties(){} // RVA: 0x7FFD4FD6B260 | overloaded x3
        public void get_isSetup(){} // RVA: 0x7FFD4FD6B6D0
        public void OnEnable(){} // RVA: 0x7FFD4FD6B710
        public void OnDisable(){} // RVA: 0x7FFD4FD6BB20
        public void Start(){} // RVA: 0x7FFD4FD6BDC0
        public void Update(){} // RVA: 0x7FFD4FD6BED0
        public void LateUpdate(){} // RVA: 0x7FFD4FD6BF90
        public void OnDestroy(){} // RVA: 0x7FFD4FD6C030
        public void OnApplicationQuit(){} // RVA: 0x7FFD4FD6C2B0
        public void .ctor(){} // RVA: 0x7FFD4FD6C3A0
        public void .cctor(){} // RVA: 0x7FFD4FD6C3F0
    }

    public class ClipPlayer : MonoBehaviour
    {
        public bool videoLoaded; // 0x20
        public Depthkit.PlayerEvents events; // 0x28

        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x7FFD4E42F9D0
        public void set_videoLoaded(){} // RVA: 0x7FFD4E42F9E0
        public void CreatePlayer(){} // RVA: 0x7FFD4E090980
        public void IsPlayerCreated(){} // RVA: 0x7FFD4E079D00
        public void IsPlayerSetup(){} // RVA: 0x7FFD4E079D00
        public void Load(){} // RVA: 0x7FFD4E078E90
        public void StartVideoLoad(){} // RVA: 0x7FFD4E090980
        public void LoadAndPlay(){} // RVA: 0x7FFD4E078E90
        public void SetVideoPath(){} // RVA: 0x7FFD4E090A40
        public void GetVideoPath(){} // RVA: 0x7FFD4E078E90
        public void OnMetadataUpdated(){} // RVA: 0x7FFD4E090A40
        public void Play(){} // RVA: 0x7FFD4E090980
        public void Pause(){} // RVA: 0x7FFD4E090980
        public void Stop(){} // RVA: 0x7FFD4E090980
        public void RemoveComponents(){} // RVA: 0x7FFD4E090980
        public void GetTexture(){} // RVA: 0x7FFD4E078E90
        public void IsTextureFlipped(){} // RVA: 0x7FFD4E079D00
        public void GammaCorrectDepth(){} // RVA: 0x7FFD4E079960
        public void GammaCorrectColor(){} // RVA: 0x7FFD4E079960
        public void GetPlayerTypeName(){} // RVA: 0x7FFD4E078E90
        public void GetPlayerPrettyName(){} // RVA: 0x7FFD4FD7A0D0
        public void IsPlaying(){} // RVA: 0x7FFD4E079D00
        public void GetCurrentTime(){} // RVA: 0x7FFD4E07EB60
        public void GetCurrentFrame(){} // RVA: 0x7FFD4E079960
        public void GetDuration(){} // RVA: 0x7FFD4E07EB60
        public void Seek(){} // RVA: 0x7FFD4E09E480
        public void GetVideoWidth(){} // RVA: 0x7FFD4E079960
        public void GetVideoHeight(){} // RVA: 0x7FFD4E079960
        public void SupportsPosterFrame(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4FD7A110
    }

    public class CoreLook : ProceduralLook
    {
        public UnityEngine.Shader s_defaultUnlitPhotoLookShader;
        public UnityEngine.Material s_defaultUnlitPhotoLookMaterial; // 0x8

        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFD4FD77870
        public void GetLookName(){} // RVA: 0x7FFD4FD77B50
        public void SetDefaults(){} // RVA: 0x7FFD4FD77B90
        public void SetDataSources(){} // RVA: 0x7FFD4FD77CC0
        public void .ctor(){} // RVA: 0x7FFD4FD77E10
    }

    public class CoreMeshSource : MeshSource
    {
        public float meshDensity; // 0x90
        public 0x66609E28 latticeMaxTriangles; // 0x94
        public UnityEngine.Vector2Int latticeResolution; // 0x98
        public uint scaledPerspectiveResolution; // 0xA0
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÌÏÌÎÏÏÏÎÎÌÏÎÎÎÏÏÎÍÌÏÎÏ vertexBuffer; // 0xA4
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
        public void get_meshDensity(){} // RVA: 0x7FFD4FD6CBE0
        public void set_meshDensity(){} // RVA: 0x7FFD4FD6CC00
        public void get_latticeMaxTriangles(){} // RVA: 0x7FFD4FCBE510
        public void get_latticeResolution(){} // RVA: 0x7FFD4E96DFB0
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7FFD4FD6CCB0
        public void ResizeLattice(){} // RVA: 0x7FFD4FD6CD60
        public void get_vertexBuffer(){} // RVA: 0x7FFD4E3AC120
        public void GetComputeShaderName(){} // RVA: 0x7FFD4FD6CE90
        public void GetKernelNamePostfix(){} // RVA: 0x7FFD4FD6CED0
        public void FindKernelId(){} // RVA: 0x7FFD4FD6CF70
        public void GenerateVertexBuffer(){} // RVA: 0x7FFD4FD6D1D0
        public void GenerateTriangles(){} // RVA: 0x7FFD4FD6DCF0 | overloaded x2
        public void GenerateVertices(){} // RVA: 0x7FFD4FD6D480
        public void GenerateNormals(){} // RVA: 0x7FFD4FD6D9B0
        public void DataSourceName(){} // RVA: 0x7FFD4FD6E120
        public void EnsureVertexBuffer(){} // RVA: 0x7FFD4FD6E160
        public void AcquireResources(){} // RVA: 0x7FFD4FD6E290
        public void FreeResources(){} // RVA: 0x7FFD4FD6E460
        public void OnSetup(){} // RVA: 0x7FFD4FD6E4A0
        public void baseResize(){} // RVA: 0x7FFD4FD6E520
        public void OnResize(){} // RVA: 0x7FFD4FD6E530
        public void GenerateEdgeMask(){} // RVA: 0x7FFD4FD6E6D0
        public void OnGenerate(){} // RVA: 0x7FFD4FD6E7B0
        public void SetProperties(){} // RVA: 0x7FFD4FD6EDF0 | overloaded x3
        public void EnsureMaskGenerator(){} // RVA: 0x7FFD4FD6EFB0
        public void .ctor(){} // RVA: 0x7FFD4FD6F1C0
    }

    public class DataSource : MonoBehaviour
    {
        public Depthkit.DataSourceEvents clip; // 0x20
        public bool dataSourceParent; // 0x28
        public Depthkit.Clip m_clip; // 0x30
        public string m_parent; // 0x38
        public bool m_doUpdate; // 0x40
        public bool m_doResize; // 0x41
        public System.Collections.Generic.List`1<0x66424DA8> m_children; // 0x48

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFD4E5F95E0
        public void get_dataSourceParent(){} // RVA: 0x7FFD4E5F0140
        public void DataSourceName(){} // RVA: 0x7FFD4E078E90
        public void GetChild(){} // RVA: 0x7FFD4E2ADC40
        public void ResetChildren(){} // RVA: 0x7FFD4FD6F530
        public void AcquireResources(){} // RVA: 0x7FFD4E341310
        public void FreeResources(){} // RVA: 0x7FFD4E341310
        public void OnAwake(){} // RVA: 0x7FFD4E341310
        public void OnCleanup(){} // RVA: 0x7FFD4E341310
        public void OnSetup(){} // RVA: 0x7FFD4E079D00
        public void OnResize(){} // RVA: 0x7FFD4E079D00
        public void OnGenerate(){} // RVA: 0x7FFD4E079D00
        public void OnUpdate(){} // RVA: 0x7FFD4E341310
        public void CanGenerate(){} // RVA: 0x7FFD4E426850
        public void Awake(){} // RVA: 0x7FFD4FD6F760
        public void Start(){} // RVA: 0x7FFD4FD6F920
        public void ScheduleGenerate(){} // RVA: 0x7FFD4EB695E0
        public void ScheduleResize(){} // RVA: 0x7FFD4FD6F940
        public void UnscheduleGenerate(){} // RVA: 0x7FFD4EB69060
        public void UnscheduleResize(){} // RVA: 0x7FFD4FD6F950
        public void OnEnable(){} // RVA: 0x7FFD4FD6F960
        public void OnDisable(){} // RVA: 0x7FFD4FD6FC00
        public void Reset(){} // RVA: 0x7FFD4FD6FE90
        public void Setup(){} // RVA: 0x7FFD4FD6FEA0
        public void Cleanup(){} // RVA: 0x7FFD4FD70150
        public void Resize(){} // RVA: 0x7FFD4FD70550
        public void IsSetup(){} // RVA: 0x7FFD4E516BA0
        public void Generate(){} // RVA: 0x7FFD4FD70950
        public void Update(){} // RVA: 0x7FFD4FD70D80
        public void LateUpdate(){} // RVA: 0x7FFD4FD70DA0
        public void .ctor(){} // RVA: 0x7FFD4FD70DE0
    }

    public class DataSourceEvents : Object
    {
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÎÌÌÌÌÏÏÍ m_dataGenerated; // 0x10
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÎÌÌÌÌÏÏÍ m_dataResized; // 0x18

        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7FFD4FD70F50
        public void remove_m_dataGenerated(){} // RVA: 0x7FFD4FD71040
        public void add_dataGenerated(){} // RVA: 0x7FFD4FD71130
        public void remove_dataGenerated(){} // RVA: 0x7FFD4FD71300
        public void add_m_dataResized(){} // RVA: 0x7FFD4FD71410
        public void remove_m_dataResized(){} // RVA: 0x7FFD4FD71500
        public void add_dataResized(){} // RVA: 0x7FFD4FD715F0
        public void remove_dataResized(){} // RVA: 0x7FFD4FD717C0
        public void OnDataGenerated(){} // RVA: 0x7FFD4FD718D0
        public void OnDataResized(){} // RVA: 0x7FFD4FD718F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_hasTexture(){} // RVA: 0x7FFD4FD7C6A0
        public void get_texture(){} // RVA: 0x7FFD4FD7C6B0
        public void CreateTextures(){} // RVA: 0x7FFD4FD7C6E0
        public void Setup(){} // RVA: 0x7FFD4FD7CBD0
        public void EnsureTextures(){} // RVA: 0x7FFD4FD7CCB0
        public void DoBlur(){} // RVA: 0x7FFD4FD7CF20
        public void BlurPass(){} // RVA: 0x7FFD4FD7D0C0
        public void Release(){} // RVA: 0x7FFD4FD7D6C0
        public void .ctor(){} // RVA: 0x7FFD4FD7D840
        public void .cctor(){} // RVA: 0x7FFD4FD7D860
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFD4E099B30 | overloaded x3
    }

    public class Info : Object
    {
        public 0x6660AA30 Version;

        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7FFD4FD7E3A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FD7E7D0
    }

    public class Look : MonoBehaviour
    {
        public Depthkit.Clip materialPropertyBlock; // 0x20
        public bool showPerViewColorDebug; // 0x28
        public bool showCameraFrustums; // 0x29
        public 0x6660A5B8 onUpdated; // 0x30
        public UnityEngine.MaterialPropertyBlock m_materialPropertyBlock; // 0x38
        public Depthkit.MeshSource meshSource; // 0x40
        public UnityEngine.BoxCollider m_collider; // 0x48
        public bool m_bIsInit; // 0x50

        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7FFD4FD77E60
        public void get_materialPropertyBlock(){} // RVA: 0x7FFD4FD77F70
        public void GetLookName(){} // RVA: 0x7FFD4E078E90
        public void UsesMaterial(){} // RVA: 0x7FFD4E079D00
        public void GetMaterial(){} // RVA: 0x7FFD4E078E90
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFD4E426850
        public void GetMaterialPropertyBlock(){} // RVA: 0x7FFD4FD77F70
        public void SetDataSources(){} // RVA: 0x7FFD4E090980
        public void ValidateDataSources(){} // RVA: 0x7FFD4FD77F90
        public void SetMaterialProperties(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void OnUpdate(){} // RVA: 0x7FFD4EB28F90
        public void SetDefaults(){} // RVA: 0x7FFD4FD78060
        public void SetLookProperties(){} // RVA: 0x7FFD4FD78100
        public void Awake(){} // RVA: 0x7FFD4FD789C0
        public void Init(){} // RVA: 0x7FFD4FD78BF0
        public void Start(){} // RVA: 0x7FFD4FD78F30
        public void OnEnable(){} // RVA: 0x7FFD4FD78F60
        public void OnDisable(){} // RVA: 0x7FFD4FD79090
        public void SyncColliderToBounds(){} // RVA: 0x7FFD4FD792A0
        public void OnMetaDataUpdated(){} // RVA: 0x7FFD4FD79670
        public void LateUpdate(){} // RVA: 0x7FFD4FD79680
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class MaskGenerator : Object
    {
        public Depthkit.Clip perspectivesToSlice; // 0x10
        public int sliceToPerspective; // 0x18
        public float sliceCount; // 0x1C
        public float blurRadius; // 0x20
        public UnityEngine.ComputeShader paddedUVScaleFactor; // 0x28
        public 0x664DC180 maskTexture; // 0x30
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
        public void get_perspectivesToSlice(){} // RVA: 0x7FFD4E3E20E0
        public void set_perspectivesToSlice(){} // RVA: 0x7FFD4E4994D0
        public void get_sliceToPerspective(){} // RVA: 0x7FFD4E409500
        public void set_sliceToPerspective(){} // RVA: 0x7FFD4E409510
        public void get_sliceCount(){} // RVA: 0x7FFD4FD71910
        public void set_sliceCount(){} // RVA: 0x7FFD4FD71930
        public void get_blurRadius(){} // RVA: 0x7FFD4FD71940
        public void set_blurRadius(){} // RVA: 0x7FFD4FD71960
        public void get_paddedUVScaleFactor(){} // RVA: 0x7FFD4FD71980
        public void get_maskTexture(){} // RVA: 0x7FFD4FD71B80
        public void get_downScale(){} // RVA: 0x7FFD4FAF5110
        public void set_downScale(){} // RVA: 0x7FFD4FD71BD0
        public void get_downScaledMaskTexture(){} // RVA: 0x7FFD4FD71C50
        public void DownScalePass(){} // RVA: 0x7FFD4FD71CC0
        public void DownScaleMaskTexture(){} // RVA: 0x7FFD4FD71E60
        public void Setup(){} // RVA: 0x7FFD4FD72C20
        public void EnsureTexture(){} // RVA: 0x7FFD4FD73170
        public void Release(){} // RVA: 0x7FFD4FD73450
        public void SobelFilterMask(){} // RVA: 0x7FFD4FD73600
        public void BlurMask(){} // RVA: 0x7FFD4FD739F0
        public void GenerateMask(){} // RVA: 0x7FFD4FD73A30
        public void SetProperties(){} // RVA: 0x7FFD4FD74230 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD4FD74670
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
        public void GetSubMesh(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CurrentSubMesh(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ReserveSubMeshes(){} // RVA: 0x7FFD4E090ED0
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFD4FBDAB70
        public void set_currentSubmeshIndex(){} // RVA: 0x7FFD4FBDAB80
        public void get_triangleBuffer(){} // RVA: 0x7FFD4FD74E80
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7FFD4FD74ED0
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7FFD4FD74F20
        public void get_maxSurfaceTriangles(){} // RVA: 0x7FFD4FD74F70
        public void set_maxSurfaceTriangles(){} // RVA: 0x7FFD4FD74FC0
        public void get_useTriangleMesh(){} // RVA: 0x7FFD4E3BD320
        public void set_useTriangleMesh(){} // RVA: 0x7FFD4FD75020
        public void get_triangleMesh(){} // RVA: 0x7FFD4FD75080
        public void EnsureRadialBias(){} // RVA: 0x7FFD4FD750C0
        public void AcquireResources(){} // RVA: 0x7FFD4FD75370
        public void FreeResources(){} // RVA: 0x7FFD4FD75430
        public void CanGenerate(){} // RVA: 0x7FFD4FD754A0
        public void OnSetup(){} // RVA: 0x7FFD4FD755A0
        public void OnResize(){} // RVA: 0x7FFD4FD756F0
        public void OnUpdate(){} // RVA: 0x7FFD4FD759A0
        public void OnGenerate(){} // RVA: 0x7FFD4FD75B70
        public void GetLocalBounds(){} // RVA: 0x7FFD4FD75E30
        public void GetWorldBounds(){} // RVA: 0x7FFD4FD76000
        public void Pause(){} // RVA: 0x7FFD4FD76340
        public void Continue(){} // RVA: 0x7FFD4FD763D0
        public void OnBecameVisible(){} // RVA: 0x7FFD4FD76470
        public void OnBecameInvisible(){} // RVA: 0x7FFD4FD76490
        public void CheckVisibility(){} // RVA: 0x7FFD4FD764B0
        public void SetProperties(){} // RVA: 0x7FFD4FD76720 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD4FD76830
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
        public 0x6660AB90[] perspectives; // 0x40
        public int perspectivesCount; // 0x48
        public int numRows; // 0x4C
        public int numColumns; // 0x50
        public int numAngles; // 0x54

        // ── Methods ──
        public void Valid(){} // RVA: 0x7FFD4FD7E820
        public void get_perspectiveCPPResolution(){} // RVA: 0x7FFD4FD7E840
        public void get_perspectiveResolution(){} // RVA: 0x7FFD4FD7E8B0
        public void get_paddedTextureDimensions(){} // RVA: 0x7FFD4FD7E930
        public void FromSinglePerspective(){} // RVA: 0x7FFD4FD7E9B0
        public void CreateFromJSON(){} // RVA: 0x7FFD4FD7EC80
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7FFD4FD7F870
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FD7FC10
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD8F7E0
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7FFD4FD8FAA0
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7FFD4FD8FAE0
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFD4FD8FBA0
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFD4FD8FBE0
        public void GetEdgeMaskStrength(){} // RVA: 0x7FFD4FD8FCA0
        public void SetEdgeMaskStrength(){} // RVA: 0x7FFD4FD8FCE0
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFD4FD8FDA0
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFD4FD8FDE0
        public void GetEdgeMaskEnabled(){} // RVA: 0x7FFD4FD8FEA0
        public void SetEdgeMaskEnabled(){} // RVA: 0x7FFD4FD8FEF0
        public void GetPerspectiveEnabled(){} // RVA: 0x7FFD4FD8FFA0
        public void SetPerspectiveEnabled(){} // RVA: 0x7FFD4FD8FFE0
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        public bool[] m_geometryMatchesColorWeights; // 0x30
        public float[] m_viewDependentContributions; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD901B0
        public void EnableGeometry(){} // RVA: 0x7FFD4FD90590 | overloaded x2
        public void GetOverrideWeightUnknown(){} // RVA: 0x7FFD4FD90630
        public void SetOverrideWeightUnknown(){} // RVA: 0x7FFD4FD90670
        public void GetWeightUnknown(){} // RVA: 0x7FFD4FD8FBA0
        public void SetWeightUnknown(){} // RVA: 0x7FFD4FD90710
        public void MatchViewDependentColorWeight(){} // RVA: 0x7FFD4FD90800 | overloaded x2
        public void GetViewDependentContribution(){} // RVA: 0x7FFD4FD90830
        public void SetViewDependentContribution(){} // RVA: 0x7FFD4FD90860
        public void GetViewDependentWeight(){} // RVA: 0x7FFD4FD8FAA0
        public void SetViewDependentWeight(){} // RVA: 0x7FFD4FD908B0
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7FFD4FD8FCA0
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7FFD4FD90970
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7FFD4FD8FDA0
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7FFD4FD90A30
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4FD7FD70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PlayerEvents : Object
    {
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ playbackStarted; // 0x10
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ playbackPaused; // 0x18
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ playbackStopped; // 0x20
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ loadingStarted; // 0x28
        public ÎÎÏÎÌÏÌÍÍÌÏÏÍÏÌÌ.ÍÏÎÌÌÏÌÌÎÌÌÍÍÎÌÌÎÏ loadingFinished; // 0x30

        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x7FFD4FD7A1E0
        public void remove_playbackStarted(){} // RVA: 0x7FFD4FD7A2D0
        public void add_playbackPaused(){} // RVA: 0x7FFD4FD7A3C0
        public void remove_playbackPaused(){} // RVA: 0x7FFD4FD7A4B0
        public void add_playbackStopped(){} // RVA: 0x7FFD4FD7A5A0
        public void remove_playbackStopped(){} // RVA: 0x7FFD4FD7A690
        public void add_loadingStarted(){} // RVA: 0x7FFD4FD7A780
        public void remove_loadingStarted(){} // RVA: 0x7FFD4FD7A870
        public void add_loadingFinished(){} // RVA: 0x7FFD4FD7A960
        public void remove_loadingFinished(){} // RVA: 0x7FFD4FD7AA50
        public void OnClipPlaybackStarted(){} // RVA: 0x7FFD4FD718D0
        public void OnClipPlaybackPaused(){} // RVA: 0x7FFD4FD718F0
        public void OnClipPlaybackStopped(){} // RVA: 0x7FFD4FD68B40
        public void OnClipLoadingStarted(){} // RVA: 0x7FFD4FD68B80
        public void OnClipLoadingFinished(){} // RVA: 0x7FFD4FD68B60
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ProceduralLook : Look
    {
        public 0x664E6940 shadowCastingMode; // 0x58
        public bool receiveShadows; // 0x5C
        public bool interpolateLightProbes; // 0x5D
        public UnityEngine.Transform anchorOverride; // 0x60
        public UnityEngine.Material lookMaterial; // 0x68

        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x7FFD4E426850
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFD4E426850
        public void SetMaterialProperties(){} // RVA: 0x7FFD4FD79970
        public void OnUpdate(){} // RVA: 0x7FFD4FD79E10
        public void .ctor(){} // RVA: 0x7FFD4FD77E10
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        public UnityEngine.Events.UnityEvent onFrameBegin; // 0x20
        public UnityEngine.Events.UnityEvent onFrameEnd; // 0x28
        public int captureFramteRate; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4FD7FF70
        public void Update(){} // RVA: 0x7FFD4FD7FF80
        public void LateUpdate(){} // RVA: 0x7FFD4FD7FFA0
        public void .ctor(){} // RVA: 0x7FFD4FD7FFC0
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
        public void GetDefaultMaterial(){} // RVA: 0x7FFD4FD92AF0
        public void GetLookName(){} // RVA: 0x7FFD4FD937A0
        public void SetDefaults(){} // RVA: 0x7FFD4FD937E0
        public void SetDataSources(){} // RVA: 0x7FFD4FD93F40
        public void OnUpdate(){} // RVA: 0x7FFD4FD94090
        public void .ctor(){} // RVA: 0x7FFD4FD943E0
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
        public void GetComputeShaderName(){} // RVA: 0x7FFD4FD90C60
        public void GetKernelNamePostfix(){} // RVA: 0x7FFD4FD90CA0
        public void GenerateTriangles(){} // RVA: 0x7FFD4FD90DB0
        public void DataSourceName(){} // RVA: 0x7FFD4FD914A0
        public void OnResize(){} // RVA: 0x7FFD4FD914E0
        public void GenerateEdgeMask(){} // RVA: 0x7FFD4FD917F0
        public void OnGenerate(){} // RVA: 0x7FFD4FD918E0
        public void .ctor(){} // RVA: 0x7FFD4FD92930
    }

    public class StudioLook : ProceduralLook
    {
        public UnityEngine.Shader s_defaultUnlitPhotoLookShader;
        public UnityEngine.Material s_defaultUnlitPhotoLookMaterial; // 0x8

        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFD4FD8F110
        public void GetLookName(){} // RVA: 0x7FFD4FD8F3F0
        public void SetDataSources(){} // RVA: 0x7FFD4FD8F430
        public void SetDefaults(){} // RVA: 0x7FFD4FD8F580
        public void .ctor(){} // RVA: 0x7FFD4FD77E10
    }

    public class StudioMeshSource : MeshSource
    {
        public 0x66619708 currentLevelOfDetailLevel; // 0x90
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
        public 0x666197B8 untexturedFragmentSetting; // 0x16C
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
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7FFD4FD86030
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7FFD4FC57F50
        public void get_volumeBounds(){} // RVA: 0x7FFD4FD860B0
        public void set_volumeBounds(){} // RVA: 0x7FFD4FD860D0
        public void GetLocalBounds(){} // RVA: 0x7FFD4FD860B0
        public void get_volumeDensity(){} // RVA: 0x7FFD4FD861C0
        public void set_volumeDensity(){} // RVA: 0x7FFD4FD861D0
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7FFD4FD861E0
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7FFD4FD861F0
        public void set_useTextureAtlas(){} // RVA: 0x7FFD4EAF63C0
        public void DataSourceName(){} // RVA: 0x7FFD4FD86200
        public void GetScaledKernelName(){} // RVA: 0x7FFD4FD86240
        public void GetExtractVolumeKernelName(){} // RVA: 0x7FFD4FD86470
        public void OnAwake(){} // RVA: 0x7FFD4FD86640
        public void OnSetup(){} // RVA: 0x7FFD4FD867D0
        public void ResetGPUResources(){} // RVA: 0x7FFD4FD86EC0
        public void AcquireResources(){} // RVA: 0x7FFD4FD86F20
        public void FreeResources(){} // RVA: 0x7FFD4FD871B0
        public void EnsureBuffers(){} // RVA: 0x7FFD4FD875F0
        public void EnsureTextures(){} // RVA: 0x7FFD4FD877B0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7FFD4E2ADC40
        public void EnsureSyncedBuffers(){} // RVA: 0x7FFD4FD87A40
        public void SetupViewDependence(){} // RVA: 0x7FFD4FD87CA0
        public void OnNewMetadata(){} // RVA: 0x7FFD4FD88300
        public void ResetVolumeBounds(){} // RVA: 0x7FFD4FD884F0
        public void ResetSurfaceSensitivity(){} // RVA: 0x7FFD4FD88570
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7FFD4FD88630
        public void OnResize(){} // RVA: 0x7FFD4FD88670
        public void SetProperties(){} // RVA: 0x7FFD4FD89520 | overloaded x3
        public void SetCommonComputeProperties(){} // RVA: 0x7FFD4FD89810
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7FFD4FD89DF0
        public void FilterSdf(){} // RVA: 0x7FFD4FD8A190
        public void GenerateNormalWeights(){} // RVA: 0x7FFD4FD8A8C0
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7FFD4FD8AB00
        public void GenerateEdgeBlendMask(){} // RVA: 0x7FFD4FD8ADF0
        public void DispatchSize(){} // RVA: 0x7FFD4FD8AE70
        public void GenerateVolumePass(){} // RVA: 0x7FFD4FD8AF10
        public void GenerateVolume(){} // RVA: 0x7FFD4FD8AFB0
        public void ActivePerspectives(){} // RVA: 0x7FFD4FD8B0D0
        public void GenerateVolumeMultiPass(){} // RVA: 0x7FFD4FD8B1D0
        public void GenerateVolumeSinglePass(){} // RVA: 0x7FFD4FD8B790
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7FFD4FD8B960
        public void DrawDebug(){} // RVA: 0x7FFD4FD8BDD0
        public void OnGenerate(){} // RVA: 0x7FFD4FD8C5E0
        public void OnUpdate(){} // RVA: 0x7FFD4FD8CB40
        public void EnsureMaskGenerator(){} // RVA: 0x7FFD4FD8D400
        public void get_enableEdgeMask(){} // RVA: 0x7FFD4FD8D6A0
        public void set_enableEdgeMask(){} // RVA: 0x7FFD4FD8D6C0
        public void .ctor(){} // RVA: 0x7FFD4FD8D6D0
        public void .cctor(){} // RVA: 0x7FFD4FD8D900
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
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void get_triangleBuffer(){} // RVA: 0x7FFD4E3447C0
        public void get_trianglesCount(){} // RVA: 0x7FFD4E36F0C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7FFD4E36F130
        public void get_drawIndirectArgs(){} // RVA: 0x7FFD4E5F95E0
        public void Init(){} // RVA: 0x7FFD4FD769A0
        public void CopyTriangleCount(){} // RVA: 0x7FFD4FD76A50
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7FFD4FD76AC0
        public void PrepareDrawArgs(){} // RVA: 0x7FFD4FD76B70
        public void PrepareDispatchArgs(){} // RVA: 0x7FFD4FD76BF0
        public void EnsureBuffers(){} // RVA: 0x7FFD4FD76C90
        public void Release(){} // RVA: 0x7FFD4FD77070
        public void set_source(){} // RVA: 0x7FFD4E5F0C20
        public void get_triangleMesh(){} // RVA: 0x7FFD4FD77220
        public void SetProperties(){} // RVA: 0x7FFD4FD77550 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public UnityEngine.ComputeBuffer Length; // 0x10
        public 0x66619918[] m_data; // 0x18
        public bool m_dirty; // 0x20
        public string m_name; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E0986D0
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void MarkDirty(){} // RVA: 0x7FFD4E090980
        public void Sync(){} // RVA: 0x7FFD4E079D00
        public void Release(){} // RVA: 0x7FFD4E090980
    }

    public class TriangleMesh : Object
    {
        public Depthkit.MeshSource TriangleCount; // 0x10
        public UnityEngine.Mesh mesh; // 0x18
        public int m_triangleCount; // 0x20
        public UnityEngine.Vector3[] s_cubeVerts;
        public int[] s_cubeTriangles; // 0x8

        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x7FFD4E4FBBE0
        public void set_TriangleCount(){} // RVA: 0x7FFD4FD80010
        public void get_mesh(){} // RVA: 0x7FFD4FD80020
        public void EnsureTriangleMesh(){} // RVA: 0x7FFD4FD80910 | overloaded x3
        public void CreateMesh(){} // RVA: 0x7FFD4FD80D20
        public void ReleaseMesh(){} // RVA: 0x7FFD4FD80DE0
        public void GetCubeVerts(){} // RVA: 0x7FFD4FD80F50
        public void GetCubeTriangles(){} // RVA: 0x7FFD4FD81120
        public void ResetMeshCube(){} // RVA: 0x7FFD4FD81230
        public void CreateLattice(){} // RVA: 0x7FFD4FD81530
        public void addVertex(){} // RVA: 0x7FFD4FD819A0
        public void CreateTriangleLattice(){} // RVA: 0x7FFD4FD81B30
        public void CreateCubeMesh(){} // RVA: 0x7FFD4FD81F90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        public UnityEngine.Video.VideoPlayer m_mediaPlayer; // 0x30
        public UnityEngine.AudioSource m_audioSource; // 0x38

        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x7FFD4FD7AB40
        public void IsPlayerCreated(){} // RVA: 0x7FFD4FD7B170
        public void IsPlayerSetup(){} // RVA: 0x7FFD4FD7B240
        public void SetVideoPath(){} // RVA: 0x7FFD4FD7B4D0
        public void GetVideoPath(){} // RVA: 0x7FFD4FD7B560
        public void StartVideoLoad(){} // RVA: 0x7FFD4FD7B720
        public void Load(){} // RVA: 0x7FFD4FD7B750
        public void OnVideoLoadingComplete(){} // RVA: 0x7FFD4FD7B7F0
        public void OnMetadataUpdated(){} // RVA: 0x7FFD4E341310
        public void LoadAndPlay(){} // RVA: 0x7FFD4FD7B820
        public void Play(){} // RVA: 0x7FFD4FD7B8C0
        public void Pause(){} // RVA: 0x7FFD4FD7B950
        public void Stop(){} // RVA: 0x7FFD4FD7B9E0
        public void GetCurrentFrame(){} // RVA: 0x7FFD4FD7BA70
        public void GetCurrentTime(){} // RVA: 0x7FFD4FD7BAD0
        public void GetDuration(){} // RVA: 0x7FFD4FD7BB30
        public void GetTexture(){} // RVA: 0x7FFD4FD7BBE0
        public void IsTextureFlipped(){} // RVA: 0x7FFD4E341320
        public void GammaCorrectDepth(){} // RVA: 0x7FFD4FD7BC40
        public void GammaCorrectColor(){} // RVA: 0x7FFD4FD7BC90
        public void IsPlaying(){} // RVA: 0x7FFD4FD7BCE0
        public void RemoveComponents(){} // RVA: 0x7FFD4FD7BD40
        public void GetPlayerTypeName(){} // RVA: 0x7FFD4FD7BF10
        public void GetPlayerPrettyName(){} // RVA: 0x7FFD4FD7BFE0
        public void GetPlayerBackend(){} // RVA: 0x7FFD4E5F95E0
        public void Seek(){} // RVA: 0x7FFD4FD7C020
        public void GetVideoWidth(){} // RVA: 0x7FFD4FD7C120
        public void GetVideoHeight(){} // RVA: 0x7FFD4FD7C250
        public void SupportsPosterFrame(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4FD7A110
    }

    public class Util : Object
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7FFD4FD825B0
        public void GetScaled2DKernelName(){} // RVA: 0x7FFD4FD825D0
        public void GetScaled3DKernelName(){} // RVA: 0x7FFD4FD82800
        public void DispatchGroups(){} // RVA: 0x7FFD4FD82980
        public void ClearRenderTexture(){} // RVA: 0x7FFD4FD82AE0
        public void ClearAppendBuffer(){} // RVA: 0x7FFD4FD82CE0
        public void ReleaseComputeBuffer(){} // RVA: 0x7FFD4FD82F50
        public void ReleaseRenderTexture(){} // RVA: 0x7FFD4FD82FC0
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7FFD4FD83180
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7FFD4FD83570
        public void TransformBounds(){} // RVA: 0x7FFD4FD837D0
        public void CreateRenderTexture(){} // RVA: 0x7FFD4FD83A70
        public void EnsureRenderTexture(){} // RVA: 0x7FFD4FD83CF0
        public void EnsureComputeBuffer(){} // RVA: 0x7FFD4FD84260
        public void ColorForCamera(){} // RVA: 0x7FFD4FD844B0
        public void RenderPerspectiveGizmo(){} // RVA: 0x7FFD4E341310
        public void RenderMetadataGizmos(){} // RVA: 0x7FFD4E341310
        public void IsVisible(){} // RVA: 0x7FFD4FD84670
        public void metersToCm(){} // RVA: 0x7FFD4FD848D0
        public void cmToMeters(){} // RVA: 0x7FFD4FD848E0
        public void EnsureKeyword(){} // RVA: 0x7FFD4FD848F0
        public void EnsureComputeShader(){} // RVA: 0x7FFD4FD849F0
    }

}