// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 38
// Methods: 528

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        public Depthkit.ClipPlayerEventHandler newFrame; // 0x20
        public Depthkit.ClipPlayerEventHandler newPoster; // 0x28
        public Depthkit.DataSourceEventHandler m_newMetadata; // 0x30
        public string m_metadataFilePath; // 0x38
        public UnityEngine.TextAsset m_metadataFile; // 0x40
        public 0x666A4C3C m_metadataSourceType; // 0x48
        public Depthkit.Metadata m_metadata; // 0x50
        public PerspectiveDataBuffer m_perspectiveDataBuffer; // 0x58
        public Depthkit.ClipPlayer m_player; // 0x60
        public int m_lastFrame; // 0x68
        public UnityEngine.Texture m_currentCPPTexture; // 0x70
        public UnityEngine.Texture2D m_poster; // 0x78
        public bool m_disablePoster; // 0x80
        public System.Collections.Generic.List`1<System.WeakReference> m_dataSourceRoots; // 0x88
        public bool m_doResizeData; // 0x90
        public bool m_doGenerateData; // 0x91
        public float s_edgeChoke;
        public object newFrame; // 0x1
        public Depthkit.ClipPlayerEventHandler newFrame; // 0x83A0

        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x7FFE82BB3DC0
        public void remove_newFrame(){} // RVA: 0x7FFE82BB3EB0
        public void add_newPoster(){} // RVA: 0x7FFE82BB3FA0
        public void remove_newPoster(){} // RVA: 0x7FFE82BB4090
        public void add_m_newMetadata(){} // RVA: 0x7FFE82BB4180
        public void remove_m_newMetadata(){} // RVA: 0x7FFE82BB4270
        public void add_newMetadata(){} // RVA: 0x7FFE82BB4360
        public void remove_newMetadata(){} // RVA: 0x7FFE82BB4530
        public void OnNewFrame(){} // RVA: 0x7FFE82BB4640
        public void OnNewMetadata(){} // RVA: 0x7FFE82BB4660
        public void OnNewPoster(){} // RVA: 0x7FFE82BB4680
        public void get_playerEvents(){} // RVA: 0x7FFE82BB46A0
        public void get_metadataFilePath(){} // RVA: 0x7FFE8143BA80
        public void set_metadataFilePath(){} // RVA: 0x7FFE82BB47D0
        public void get_metadataFile(){} // RVA: 0x7FFE81178740
        public void set_metadataFile(){} // RVA: 0x7FFE82BB4A10
        public void get_metadataSourceType(){} // RVA: 0x7FFE8119C0C0
        public void get_metadata(){} // RVA: 0x7FFE8119C0E0
        public void get_hasMetadata(){} // RVA: 0x7FFE82BB4C70
        public void LoadMetadata(){} // RVA: 0x7FFE82BB4CA0
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7FFE82BB4EF0
        public void get_perspectiveDataBuffer(){} // RVA: 0x7FFE82BB4FD0
        public void get_player(){} // RVA: 0x7FFE81199370
        public void CreatePlayer(){} // RVA: 0x7FFE82BB4FE0
        public void SetPlayer(){} // RVA: 0x7FFE82BB5250 | overloaded x2
        public void get_playerSetup(){} // RVA: 0x7FFE82BB5480
        public void get_playerIsActive(){} // RVA: 0x7FFE82BB5580
        public void get_width(){} // RVA: 0x7FFE82BB5660
        public void get_height(){} // RVA: 0x7FFE82BB56B0
        public void get_gammaCorrectDepth(){} // RVA: 0x7FFE82BB5700
        public void get_gammaCorrectColor(){} // RVA: 0x7FFE82BB57A0
        public void get_cppTexture(){} // RVA: 0x7FFE82BB57F0
        public void get_textureIsFlipped(){} // RVA: 0x7FFE82BB5850
        public void get_poster(){} // RVA: 0x7FFE81463AE0
        public void set_poster(){} // RVA: 0x7FFE82BB58A0
        public void get_disablePoster(){} // RVA: 0x7FFE813A1130
        public void set_disablePoster(){} // RVA: 0x7FFE82BB59E0
        public void GetDataSource(){} // RVA: 0x7FFE810A1420
        public void DoResize(){} // RVA: 0x7FFE82BB5A00
        public void DoGenerate(){} // RVA: 0x7FFE82BB5D80
        public void ResetDataSources(){} // RVA: 0x7FFE82BB6280
        public void SetProperties(){} // RVA: 0x7FFE82BB6D60 | overloaded x3
        public void get_isSetup(){} // RVA: 0x7FFE82BB71D0
        public void OnEnable(){} // RVA: 0x7FFE82BB7210
        public void OnDisable(){} // RVA: 0x7FFE82BB7620
        public void Start(){} // RVA: 0x7FFE82BB78C0
        public void Update(){} // RVA: 0x7FFE82BB79D0
        public void LateUpdate(){} // RVA: 0x7FFE82BB7A90
        public void OnDestroy(){} // RVA: 0x7FFE82BB7B30
        public void OnApplicationQuit(){} // RVA: 0x7FFE82BB7DB0
        public void .ctor(){} // RVA: 0x7FFE82BB7EA0
        public void .cctor(){} // RVA: 0x7FFE82BB7EF0
    }

    public class ClipEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
        public void BeginInvoke(){} // RVA: 0x7FFE81159A60
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class ClipPlayer : MonoBehaviour
    {
        public bool _videoLoaded; // 0x20

        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x7FFE811E99D0
        public void set_videoLoaded(){} // RVA: 0x7FFE811E99E0
        public void CreatePlayer(){} // RVA: 0x7FFE80E45FE0
        public void IsPlayerCreated(){} // RVA: 0x7FFE80E2F150
        public void IsPlayerSetup(){} // RVA: 0x7FFE80E2F150
        public void Load(){} // RVA: 0x7FFE80E2E2E0
        public void StartVideoLoad(){} // RVA: 0x7FFE80E45FE0
        public void LoadAndPlay(){} // RVA: 0x7FFE80E2E2E0
        public void SetVideoPath(){} // RVA: 0x7FFE80E460A0
        public void GetVideoPath(){} // RVA: 0x7FFE80E2E2E0
        public void OnMetadataUpdated(){} // RVA: 0x7FFE80E460A0
        public void Play(){} // RVA: 0x7FFE80E45FE0
        public void Pause(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void RemoveComponents(){} // RVA: 0x7FFE80E45FE0
        public void GetTexture(){} // RVA: 0x7FFE80E2E2E0
        public void IsTextureFlipped(){} // RVA: 0x7FFE80E2F150
        public void GammaCorrectDepth(){} // RVA: 0x7FFE80E2EDB0
        public void GammaCorrectColor(){} // RVA: 0x7FFE80E2EDB0
        public void GetPlayerTypeName(){} // RVA: 0x7FFE80E2E2E0
        public void GetPlayerPrettyName(){} // RVA: 0x7FFE82BC5C00
        public void IsPlaying(){} // RVA: 0x7FFE80E2F150
        public void GetCurrentTime(){} // RVA: 0x7FFE80E33FB0
        public void GetCurrentFrame(){} // RVA: 0x7FFE80E2EDB0
        public void GetDuration(){} // RVA: 0x7FFE80E33FB0
        public void Seek(){} // RVA: 0x7FFE80E53B80
        public void GetVideoWidth(){} // RVA: 0x7FFE80E2EDB0
        public void GetVideoHeight(){} // RVA: 0x7FFE80E2EDB0
        public void SupportsPosterFrame(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE82BC5C40
    }

    public class ClipPlayerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
        public void BeginInvoke(){} // RVA: 0x7FFE81159A60
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class CoreLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFE82BC3380
        public void GetLookName(){} // RVA: 0x7FFE82BC3660
        public void SetDefaults(){} // RVA: 0x7FFE82BC36A0
        public void SetDataSources(){} // RVA: 0x7FFE82BC37D0
        public void .ctor(){} // RVA: 0x7FFE82BC3920
    }

    public class CoreMeshSource : MeshSource
    {
        public float surfaceTriangleCountPercent; // 0x90
        public 0x666A4DF4 m_meshDensity; // 0x94
        public UnityEngine.Vector2Int m_latticeResolution; // 0x98
        public uint m_latticeMaxTriangles; // 0xA0
        public 0x666A4E4C normalGenerationTechnique; // 0xA4

        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x7FFE82BB86E0
        public void set_meshDensity(){} // RVA: 0x7FFE82BB8700
        public void get_latticeMaxTriangles(){} // RVA: 0x7FFE82B06FB0
        public void get_latticeResolution(){} // RVA: 0x7FFE817AE360
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7FFE82BB87B0
        public void ResizeLattice(){} // RVA: 0x7FFE82BB8860
        public void get_vertexBuffer(){} // RVA: 0x7FFE81166120
        public void GetComputeShaderName(){} // RVA: 0x7FFE82BB8990
        public void GetKernelNamePostfix(){} // RVA: 0x7FFE82BB89D0
        public void FindKernelId(){} // RVA: 0x7FFE82BB8A70
        public void GenerateVertexBuffer(){} // RVA: 0x7FFE82BB8CD0
        public void GenerateTriangles(){} // RVA: 0x7FFE82BB97F0 | overloaded x2
        public void GenerateVertices(){} // RVA: 0x7FFE82BB8F80
        public void GenerateNormals(){} // RVA: 0x7FFE82BB94B0
        public void DataSourceName(){} // RVA: 0x7FFE82BB9C20
        public void EnsureVertexBuffer(){} // RVA: 0x7FFE82BB9C60
        public void AcquireResources(){} // RVA: 0x7FFE82BB9D90
        public void FreeResources(){} // RVA: 0x7FFE82BB9F60
        public void OnSetup(){} // RVA: 0x7FFE82BB9FA0
        public void baseResize(){} // RVA: 0x7FFE82BBA020
        public void OnResize(){} // RVA: 0x7FFE82BBA030
        public void GenerateEdgeMask(){} // RVA: 0x7FFE82BBA1D0
        public void OnGenerate(){} // RVA: 0x7FFE82BBA2B0
        public void SetProperties(){} // RVA: 0x7FFE82BBA8F0 | overloaded x3
        public void EnsureMaskGenerator(){} // RVA: 0x7FFE82BBAAB0
        public void .ctor(){} // RVA: 0x7FFE82BBACC0
    }

    public class DataSource : MonoBehaviour
    {
        public Depthkit.DataSourceEvents events; // 0x20
        public bool m_bIsSetup; // 0x28

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFE8144E200
        public void get_dataSourceParent(){} // RVA: 0x7FFE8143BA80
        public void DataSourceName(){} // RVA: 0x7FFE80E2E2E0
        public void GetChild(){} // RVA: 0x7FFE810A1420
        public void ResetChildren(){} // RVA: 0x7FFE82BBB030
        public void AcquireResources(){} // RVA: 0x7FFE810FB310
        public void FreeResources(){} // RVA: 0x7FFE810FB310
        public void OnAwake(){} // RVA: 0x7FFE810FB310
        public void OnCleanup(){} // RVA: 0x7FFE810FB310
        public void OnSetup(){} // RVA: 0x7FFE80E2F150
        public void OnResize(){} // RVA: 0x7FFE80E2F150
        public void OnGenerate(){} // RVA: 0x7FFE80E2F150
        public void OnUpdate(){} // RVA: 0x7FFE810FB310
        public void CanGenerate(){} // RVA: 0x7FFE811E0850
        public void Awake(){} // RVA: 0x7FFE82BBB260
        public void Start(){} // RVA: 0x7FFE82BBB420
        public void ScheduleGenerate(){} // RVA: 0x7FFE82BBB440
        public void ScheduleResize(){} // RVA: 0x7FFE82BBB450
        public void UnscheduleGenerate(){} // RVA: 0x7FFE81873670
        public void UnscheduleResize(){} // RVA: 0x7FFE82BBB460
        public void OnEnable(){} // RVA: 0x7FFE82BBB470
        public void OnDisable(){} // RVA: 0x7FFE82BBB710
        public void Reset(){} // RVA: 0x7FFE82BBB9A0
        public void Setup(){} // RVA: 0x7FFE82BBB9B0
        public void Cleanup(){} // RVA: 0x7FFE82BBBC60
        public void Resize(){} // RVA: 0x7FFE82BBC060
        public void IsSetup(){} // RVA: 0x7FFE815F1380
        public void Generate(){} // RVA: 0x7FFE82BBC460
        public void Update(){} // RVA: 0x7FFE82BBC890
        public void LateUpdate(){} // RVA: 0x7FFE82BBC8B0
        public void .ctor(){} // RVA: 0x7FFE82BBC8F0
    }

    public class DataSourceEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
        public void BeginInvoke(){} // RVA: 0x7FFE81159A60
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class DataSourceEvents : Object
    {
        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7FFE82BBCA60
        public void remove_m_dataGenerated(){} // RVA: 0x7FFE82BBCB50
        public void add_dataGenerated(){} // RVA: 0x7FFE82BBCC40
        public void remove_dataGenerated(){} // RVA: 0x7FFE82BBCE10
        public void add_m_dataResized(){} // RVA: 0x7FFE82BBCF20
        public void remove_m_dataResized(){} // RVA: 0x7FFE82BBD010
        public void add_dataResized(){} // RVA: 0x7FFE82BBD100
        public void remove_dataResized(){} // RVA: 0x7FFE82BBD2D0
        public void OnDataGenerated(){} // RVA: 0x7FFE82BBD3E0
        public void OnDataResized(){} // RVA: 0x7FFE82BBD400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DepthkitLookEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
        public void BeginInvoke(){} // RVA: 0x7FFE81159A60
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class GaussianBlurFilter : Object
    {
        public float radius; // 0x10
        public int reductionFactor; // 0x14

        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x7FFE82BC81D0
        public void get_texture(){} // RVA: 0x7FFE82BC81E0
        public void CreateTextures(){} // RVA: 0x7FFE82BC8210
        public void Setup(){} // RVA: 0x7FFE82BC8700
        public void EnsureTextures(){} // RVA: 0x7FFE82BC87E0
        public void DoBlur(){} // RVA: 0x7FFE82BC8A50
        public void BlurPass(){} // RVA: 0x7FFE82BC8BF0
        public void Release(){} // RVA: 0x7FFE82BC91F0
        public void .ctor(){} // RVA: 0x7FFE82BC9370
        public void .cctor(){} // RVA: 0x7FFE82BC9390
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFE80E4F230 | overloaded x3
    }

    public class IndexedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BB86B0
    }

    public class Info : Object
    {
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7FFE82BC9ED0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82BCA300
    }

    public class Look : MonoBehaviour
    {
        public Depthkit.Clip depthkitClip; // 0x20

        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7FFE82BC3970
        public void get_materialPropertyBlock(){} // RVA: 0x7FFE82BC3A80
        public void GetLookName(){} // RVA: 0x7FFE80E2E2E0
        public void UsesMaterial(){} // RVA: 0x7FFE80E2F150
        public void GetMaterial(){} // RVA: 0x7FFE80E2E2E0
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFE811E0850
        public void GetMaterialPropertyBlock(){} // RVA: 0x7FFE82BC3A80
        public void SetDataSources(){} // RVA: 0x7FFE80E45FE0
        public void ValidateDataSources(){} // RVA: 0x7FFE82BC3AA0
        public void SetMaterialProperties(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnUpdate(){} // RVA: 0x7FFE82BC3B70
        public void SetDefaults(){} // RVA: 0x7FFE82BC3B90
        public void SetLookProperties(){} // RVA: 0x7FFE82BC3C30
        public void Awake(){} // RVA: 0x7FFE82BC44F0
        public void Init(){} // RVA: 0x7FFE82BC4720
        public void Start(){} // RVA: 0x7FFE82BC4A60
        public void OnEnable(){} // RVA: 0x7FFE82BC4A90
        public void OnDisable(){} // RVA: 0x7FFE82BC4BC0
        public void SyncColliderToBounds(){} // RVA: 0x7FFE82BC4DD0
        public void OnMetaDataUpdated(){} // RVA: 0x7FFE82BC51A0
        public void LateUpdate(){} // RVA: 0x7FFE82BC51B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class MaskGenerator : Object
    {
        public Depthkit.Clip clip; // 0x10
        public int scale; // 0x18
        public float invalidateEdgeWidth; // 0x1C
        public float invalidateStrength; // 0x20
        public UnityEngine.ComputeShader m_maskGeneratorCompute; // 0x28
        public 0x665759EC m_maskTextureFormat; // 0x30
        public UnityEngine.RenderTexture m_maskTexture; // 0x38
        public UnityEngine.Vector4 m_maskTextureTS; // 0x40

        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x7FFE8119C0E0
        public void set_perspectivesToSlice(){} // RVA: 0x7FFE812534D0
        public void get_sliceToPerspective(){} // RVA: 0x7FFE811C3500
        public void set_sliceToPerspective(){} // RVA: 0x7FFE811C3510
        public void get_sliceCount(){} // RVA: 0x7FFE82BBD420
        public void set_sliceCount(){} // RVA: 0x7FFE82BBD440
        public void get_blurRadius(){} // RVA: 0x7FFE82BBD450
        public void set_blurRadius(){} // RVA: 0x7FFE82BBD470
        public void get_paddedUVScaleFactor(){} // RVA: 0x7FFE82BBD490
        public void get_maskTexture(){} // RVA: 0x7FFE82BBD690
        public void get_downScale(){} // RVA: 0x7FFE829DF2E0
        public void set_downScale(){} // RVA: 0x7FFE82BBD6E0
        public void get_downScaledMaskTexture(){} // RVA: 0x7FFE82BBD760
        public void DownScalePass(){} // RVA: 0x7FFE82BBD7D0
        public void DownScaleMaskTexture(){} // RVA: 0x7FFE82BBD970
        public void Setup(){} // RVA: 0x7FFE82BBE730
        public void EnsureTexture(){} // RVA: 0x7FFE82BBEC80
        public void Release(){} // RVA: 0x7FFE82BBEF60
        public void SobelFilterMask(){} // RVA: 0x7FFE82BBF110
        public void BlurMask(){} // RVA: 0x7FFE82BBF500
        public void GenerateMask(){} // RVA: 0x7FFE82BBF540
        public void SetProperties(){} // RVA: 0x7FFE82BBFD40 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE82BC0180
    }

    public class MeshSource : DataSource
    {
        public bool recalculateCurrentSurfaceTriangleCount; // 0x50
        public Depthkit.SubMesh[] m_subMeshes; // 0x58
        public uint[] m_subMeshMaxTriangles; // 0x60
        public bool m_forceStereo; // 0x68
        public uint m_currentSubmeshIndex; // 0x6C
        public bool m_useTriangleMesh; // 0x70
        public float radialBiasMin;

        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CurrentSubMesh(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ReserveSubMeshes(){} // RVA: 0x7FFE80E46530
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFE82A22F10
        public void set_currentSubmeshIndex(){} // RVA: 0x7FFE82A22F20
        public void get_triangleBuffer(){} // RVA: 0x7FFE82BC0990
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7FFE82BC09E0
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7FFE82BC0A30
        public void get_maxSurfaceTriangles(){} // RVA: 0x7FFE82BC0A80
        public void set_maxSurfaceTriangles(){} // RVA: 0x7FFE82BC0AD0
        public void get_useTriangleMesh(){} // RVA: 0x7FFE81177320
        public void set_useTriangleMesh(){} // RVA: 0x7FFE82BC0B30
        public void get_triangleMesh(){} // RVA: 0x7FFE82BC0B90
        public void EnsureRadialBias(){} // RVA: 0x7FFE82BC0BD0
        public void AcquireResources(){} // RVA: 0x7FFE82BC0E80
        public void FreeResources(){} // RVA: 0x7FFE82BC0F40
        public void CanGenerate(){} // RVA: 0x7FFE82BC0FB0
        public void OnSetup(){} // RVA: 0x7FFE82BC10B0
        public void OnResize(){} // RVA: 0x7FFE82BC1200
        public void OnUpdate(){} // RVA: 0x7FFE82BC14B0
        public void OnGenerate(){} // RVA: 0x7FFE82BC1680
        public void GetLocalBounds(){} // RVA: 0x7FFE82BC1940
        public void GetWorldBounds(){} // RVA: 0x7FFE82BC1B10
        public void Pause(){} // RVA: 0x7FFE82BC1E50
        public void Continue(){} // RVA: 0x7FFE82BC1EE0
        public void OnBecameVisible(){} // RVA: 0x7FFE82BC1F80
        public void OnBecameInvisible(){} // RVA: 0x7FFE82BC1FA0
        public void CheckVisibility(){} // RVA: 0x7FFE82BC1FC0
        public void SetProperties(){} // RVA: 0x7FFE82BC2230 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE82BC2340
    }

    public class Metadata : Object
    {
        public int MaxPerspectives;
        public uint MAX_PERSPECTIVES; // 0x4
        public float eps;

        // ── Methods ──
        public void Valid(){} // RVA: 0x7FFE82BCA350
        public void get_perspectiveCPPResolution(){} // RVA: 0x7FFE82BCA370
        public void get_perspectiveResolution(){} // RVA: 0x7FFE82BCA3E0
        public void get_paddedTextureDimensions(){} // RVA: 0x7FFE82BCA460
        public void FromSinglePerspective(){} // RVA: 0x7FFE82BCA4E0
        public void CreateFromJSON(){} // RVA: 0x7FFE82BCA7B0
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7FFE82BCB3A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82BCB740
    }

    public class PackedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BB8680
    }

    public class PerspectiveColorBlending : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE82BDB1B0
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BDB2E0
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7FFE82BDB5A0
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7FFE82BDB5E0
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFE82BDB6A0
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFE82BDB6E0
        public void GetEdgeMaskStrength(){} // RVA: 0x7FFE82BDB7A0
        public void SetEdgeMaskStrength(){} // RVA: 0x7FFE82BDB7E0
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFE82BDB8A0
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFE82BDB8E0
        public void GetEdgeMaskEnabled(){} // RVA: 0x7FFE82BDB9A0
        public void SetEdgeMaskEnabled(){} // RVA: 0x7FFE82BDB9F0
        public void GetPerspectiveEnabled(){} // RVA: 0x7FFE82BDBAA0
        public void SetPerspectiveEnabled(){} // RVA: 0x7FFE82BDBAE0
    }

    public class PerspectiveGeometry : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE82BDBB80
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BDBCB0
        public void EnableGeometry(){} // RVA: 0x7FFE82BDC090 | overloaded x2
        public void GetOverrideWeightUnknown(){} // RVA: 0x7FFE82BDC130
        public void SetOverrideWeightUnknown(){} // RVA: 0x7FFE82BDC170
        public void GetWeightUnknown(){} // RVA: 0x7FFE82BDB6A0
        public void SetWeightUnknown(){} // RVA: 0x7FFE82BDC210
        public void MatchViewDependentColorWeight(){} // RVA: 0x7FFE82BDC300 | overloaded x2
        public void GetViewDependentContribution(){} // RVA: 0x7FFE82BDC330
        public void SetViewDependentContribution(){} // RVA: 0x7FFE82BDC360
        public void GetViewDependentWeight(){} // RVA: 0x7FFE82BDB5A0
        public void SetViewDependentWeight(){} // RVA: 0x7FFE82BDC3B0
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7FFE82BDB7A0
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7FFE82BDC470
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7FFE82BDB8A0
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7FFE82BDC530
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE82BCB8A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PlayerEvents : Object
    {
        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x7FFE82BC5D10
        public void remove_playbackStarted(){} // RVA: 0x7FFE82BC5E00
        public void add_playbackPaused(){} // RVA: 0x7FFE82BC5EF0
        public void remove_playbackPaused(){} // RVA: 0x7FFE82BC5FE0
        public void add_playbackStopped(){} // RVA: 0x7FFE82BC60D0
        public void remove_playbackStopped(){} // RVA: 0x7FFE82BC61C0
        public void add_loadingStarted(){} // RVA: 0x7FFE82BC62B0
        public void remove_loadingStarted(){} // RVA: 0x7FFE82BC63A0
        public void add_loadingFinished(){} // RVA: 0x7FFE82BC6490
        public void remove_loadingFinished(){} // RVA: 0x7FFE82BC6580
        public void OnClipPlaybackStarted(){} // RVA: 0x7FFE82BBD3E0
        public void OnClipPlaybackPaused(){} // RVA: 0x7FFE82BBD400
        public void OnClipPlaybackStopped(){} // RVA: 0x7FFE82BB4640
        public void OnClipLoadingStarted(){} // RVA: 0x7FFE82BB4680
        public void OnClipLoadingFinished(){} // RVA: 0x7FFE82BB4660
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProceduralLook : Look
    {
        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x7FFE811E0850
        public void GetMaterial(){} // RVA: 0x7FFE81176D50
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFE811E0850
        public void SetMaterialProperties(){} // RVA: 0x7FFE82BC54A0
        public void OnUpdate(){} // RVA: 0x7FFE82BC5940
        public void .ctor(){} // RVA: 0x7FFE82BC3920
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE82BCBAA0
        public void Update(){} // RVA: 0x7FFE82BCBAB0
        public void LateUpdate(){} // RVA: 0x7FFE82BCBAD0
        public void .ctor(){} // RVA: 0x7FFE82BCBAF0
    }

    public class StudioLiteLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFE82BDE5F0
        public void GetLookName(){} // RVA: 0x7FFE82BDF2A0
        public void SetDefaults(){} // RVA: 0x7FFE82BDF2E0
        public void SetDataSources(){} // RVA: 0x7FFE82BDFA40
        public void OnUpdate(){} // RVA: 0x7FFE82BDFB90
        public void .ctor(){} // RVA: 0x7FFE82BDFEE0
    }

    public class StudioLiteMeshSource : CoreMeshSource
    {
        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x7FFE82BDC760
        public void GetKernelNamePostfix(){} // RVA: 0x7FFE82BDC7A0
        public void GenerateTriangles(){} // RVA: 0x7FFE82BDC8B0
        public void DataSourceName(){} // RVA: 0x7FFE82BDCFA0
        public void OnResize(){} // RVA: 0x7FFE82BDCFE0
        public void GenerateEdgeMask(){} // RVA: 0x7FFE82BDD2F0
        public void OnGenerate(){} // RVA: 0x7FFE82BDD3E0
        public void .ctor(){} // RVA: 0x7FFE82BDE430
    }

    public class StudioLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFE82BDAC10
        public void GetLookName(){} // RVA: 0x7FFE82BDAEF0
        public void SetDataSources(){} // RVA: 0x7FFE82BDAF30
        public void SetDefaults(){} // RVA: 0x7FFE82BDB080
        public void .ctor(){} // RVA: 0x7FFE82BC3920
    }

    public class StudioMeshSource : MeshSource
    {
        public dFixup.* generationMethod; // 0x90
        public UnityEngine.ComputeShader m_generateVolumeCompute; // 0x98
        public UnityEngine.ComputeShader m_generateVolumePreviewCompute; // 0xA0
        public UnityEngine.ComputeShader m_extractSurfaceCompute; // 0xA8
        public UnityEngine.ComputeShader m_sdfFilterCompute; // 0xB0
        public UnityEngine.ComputeShader m_generateNormalWeightsCompute; // 0xB8

        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7FFE82BD1B60
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7FFE82AA02F0
        public void get_volumeBounds(){} // RVA: 0x7FFE81314610
        public void set_volumeBounds(){} // RVA: 0x7FFE82BD1BE0
        public void GetLocalBounds(){} // RVA: 0x7FFE81314610
        public void get_volumeDensity(){} // RVA: 0x7FFE82BD1CD0
        public void set_volumeDensity(){} // RVA: 0x7FFE82BD1CE0
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7FFE812BC010
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7FFE82BD1CF0
        public void set_useTextureAtlas(){} // RVA: 0x7FFE81821900
        public void DataSourceName(){} // RVA: 0x7FFE82BD1D00
        public void GetScaledKernelName(){} // RVA: 0x7FFE82BD1D40
        public void GetExtractVolumeKernelName(){} // RVA: 0x7FFE82BD1F70
        public void OnAwake(){} // RVA: 0x7FFE82BD2140
        public void OnSetup(){} // RVA: 0x7FFE82BD22D0
        public void ResetGPUResources(){} // RVA: 0x7FFE82BD29C0
        public void AcquireResources(){} // RVA: 0x7FFE82BD2A20
        public void FreeResources(){} // RVA: 0x7FFE82BD2CB0
        public void EnsureBuffers(){} // RVA: 0x7FFE82BD30F0
        public void EnsureTextures(){} // RVA: 0x7FFE82BD32B0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7FFE810A1420
        public void EnsureSyncedBuffers(){} // RVA: 0x7FFE82BD3540
        public void SetupViewDependence(){} // RVA: 0x7FFE82BD37A0
        public void OnNewMetadata(){} // RVA: 0x7FFE82BD3E00
        public void ResetVolumeBounds(){} // RVA: 0x7FFE82BD3FF0
        public void ResetSurfaceSensitivity(){} // RVA: 0x7FFE82BD4070
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7FFE82BD4130
        public void OnResize(){} // RVA: 0x7FFE82BD4170
        public void SetProperties(){} // RVA: 0x7FFE82BD5020 | overloaded x3
        public void SetCommonComputeProperties(){} // RVA: 0x7FFE82BD5310
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7FFE82BD58F0
        public void FilterSdf(){} // RVA: 0x7FFE82BD5C90
        public void GenerateNormalWeights(){} // RVA: 0x7FFE82BD63C0
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7FFE82BD6600
        public void GenerateEdgeBlendMask(){} // RVA: 0x7FFE82BD68F0
        public void DispatchSize(){} // RVA: 0x7FFE82BD6970
        public void GenerateVolumePass(){} // RVA: 0x7FFE82BD6A10
        public void GenerateVolume(){} // RVA: 0x7FFE82BD6AB0
        public void ActivePerspectives(){} // RVA: 0x7FFE82BD6BD0
        public void GenerateVolumeMultiPass(){} // RVA: 0x7FFE82BD6CD0
        public void GenerateVolumeSinglePass(){} // RVA: 0x7FFE82BD7290
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7FFE82BD7460
        public void DrawDebug(){} // RVA: 0x7FFE82BD78D0
        public void OnGenerate(){} // RVA: 0x7FFE82BD80E0
        public void OnUpdate(){} // RVA: 0x7FFE82BD8640
        public void EnsureMaskGenerator(){} // RVA: 0x7FFE82BD8F00
        public void get_enableEdgeMask(){} // RVA: 0x7FFE82BD91A0
        public void set_enableEdgeMask(){} // RVA: 0x7FFE82BD91C0
        public void .ctor(){} // RVA: 0x7FFE82BD91D0
        public void .cctor(){} // RVA: 0x7FFE82BD9400
    }

    public class SubMesh : Object
    {
        public uint maxTriangles; // 0x10
        public UnityEngine.ComputeBuffer m_triangleBuffer; // 0x18
        public UnityEngine.ComputeBuffer m_trianglesCount; // 0x20
        public UnityEngine.ComputeBuffer m_dispatchIndirectArgs; // 0x28
        public UnityEngine.ComputeBuffer m_drawIndirectArgs; // 0x30
        public Depthkit.MeshSource m_source; // 0x38

        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_triangleBuffer(){} // RVA: 0x7FFE810FE7C0
        public void get_trianglesCount(){} // RVA: 0x7FFE811290C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7FFE81129130
        public void get_drawIndirectArgs(){} // RVA: 0x7FFE8144E200
        public void Init(){} // RVA: 0x7FFE82BC24B0
        public void CopyTriangleCount(){} // RVA: 0x7FFE82BC2560
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7FFE82BC25D0
        public void PrepareDrawArgs(){} // RVA: 0x7FFE82BC2680
        public void PrepareDispatchArgs(){} // RVA: 0x7FFE82BC2700
        public void EnsureBuffers(){} // RVA: 0x7FFE82BC27A0
        public void Release(){} // RVA: 0x7FFE82BC2B80
        public void set_source(){} // RVA: 0x7FFE81437330
        public void get_triangleMesh(){} // RVA: 0x7FFE82BC2D30
        public void SetProperties(){} // RVA: 0x7FFE82BC3060 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public UnityEngine.ComputeBuffer buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4DDD0
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void MarkDirty(){} // RVA: 0x7FFE80E45FE0
        public void Sync(){} // RVA: 0x7FFE80E2F150
        public void Release(){} // RVA: 0x7FFE80E45FE0
    }

    public class TriangleMesh : Object
    {
        public Depthkit.MeshSource source; // 0x10
        public UnityEngine.Mesh m_mesh; // 0x18

        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x7FFE8151D690
        public void set_TriangleCount(){} // RVA: 0x7FFE82BCBB40
        public void get_mesh(){} // RVA: 0x7FFE82BCBB50
        public void EnsureTriangleMesh(){} // RVA: 0x7FFE82BCC440 | overloaded x3
        public void CreateMesh(){} // RVA: 0x7FFE82BCC850
        public void ReleaseMesh(){} // RVA: 0x7FFE82BCC910
        public void GetCubeVerts(){} // RVA: 0x7FFE82BCCA80
        public void GetCubeTriangles(){} // RVA: 0x7FFE82BCCC50
        public void ResetMeshCube(){} // RVA: 0x7FFE82BCCD60
        public void CreateLattice(){} // RVA: 0x7FFE82BCD060
        public void addVertex(){} // RVA: 0x7FFE82BCD4D0
        public void CreateTriangleLattice(){} // RVA: 0x7FFE82BCD660
        public void CreateCubeMesh(){} // RVA: 0x7FFE82BCDAC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x7FFE82BC6670
        public void IsPlayerCreated(){} // RVA: 0x7FFE82BC6CA0
        public void IsPlayerSetup(){} // RVA: 0x7FFE82BC6D70
        public void SetVideoPath(){} // RVA: 0x7FFE82BC7000
        public void GetVideoPath(){} // RVA: 0x7FFE82BC7090
        public void StartVideoLoad(){} // RVA: 0x7FFE82BC7250
        public void Load(){} // RVA: 0x7FFE82BC7280
        public void OnVideoLoadingComplete(){} // RVA: 0x7FFE82BC7320
        public void OnMetadataUpdated(){} // RVA: 0x7FFE810FB310
        public void LoadAndPlay(){} // RVA: 0x7FFE82BC7350
        public void Play(){} // RVA: 0x7FFE82BC73F0
        public void Pause(){} // RVA: 0x7FFE82BC7480
        public void Stop(){} // RVA: 0x7FFE82BC7510
        public void GetCurrentFrame(){} // RVA: 0x7FFE82BC75A0
        public void GetCurrentTime(){} // RVA: 0x7FFE82BC7600
        public void GetDuration(){} // RVA: 0x7FFE82BC7660
        public void GetTexture(){} // RVA: 0x7FFE82BC7710
        public void IsTextureFlipped(){} // RVA: 0x7FFE810FB320
        public void GammaCorrectDepth(){} // RVA: 0x7FFE82BC7770
        public void GammaCorrectColor(){} // RVA: 0x7FFE82BC77C0
        public void IsPlaying(){} // RVA: 0x7FFE82BC7810
        public void RemoveComponents(){} // RVA: 0x7FFE82BC7870
        public void GetPlayerTypeName(){} // RVA: 0x7FFE82BC7A40
        public void GetPlayerPrettyName(){} // RVA: 0x7FFE82BC7B10
        public void GetPlayerBackend(){} // RVA: 0x7FFE8144E200
        public void Seek(){} // RVA: 0x7FFE82BC7B50
        public void GetVideoWidth(){} // RVA: 0x7FFE82BC7C50
        public void GetVideoHeight(){} // RVA: 0x7FFE82BC7D80
        public void SupportsPosterFrame(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE82BC5C40
    }

    public class Util : Object
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7FFE82BCE0E0
        public void GetScaled2DKernelName(){} // RVA: 0x7FFE82BCE100
        public void GetScaled3DKernelName(){} // RVA: 0x7FFE82BCE330
        public void DispatchGroups(){} // RVA: 0x7FFE82BCE4B0
        public void ClearRenderTexture(){} // RVA: 0x7FFE82BCE610
        public void ClearAppendBuffer(){} // RVA: 0x7FFE82BCE810
        public void ReleaseComputeBuffer(){} // RVA: 0x7FFE82BCEA80
        public void ReleaseRenderTexture(){} // RVA: 0x7FFE82BCEAF0
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7FFE82BCECB0
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7FFE82BCF0A0
        public void TransformBounds(){} // RVA: 0x7FFE82BCF300
        public void CreateRenderTexture(){} // RVA: 0x7FFE82BCF5A0
        public void EnsureRenderTexture(){} // RVA: 0x7FFE82BCF820
        public void EnsureComputeBuffer(){} // RVA: 0x7FFE82BCFD90
        public void ColorForCamera(){} // RVA: 0x7FFE82BCFFE0
        public void RenderPerspectiveGizmo(){} // RVA: 0x7FFE810FB310
        public void RenderMetadataGizmos(){} // RVA: 0x7FFE810FB310
        public void IsVisible(){} // RVA: 0x7FFE82BD01A0
        public void metersToCm(){} // RVA: 0x7FFE82BD0400
        public void cmToMeters(){} // RVA: 0x7FFE82BD0410
        public void EnsureKeyword(){} // RVA: 0x7FFE82BD0420
        public void EnsureComputeShader(){} // RVA: 0x7FFE82BD0520
    }

    public class Version : ValueType
    {
        public byte _major; // 0x10
        public byte _minor; // 0x11
        public byte _patch; // 0x12

        // ── Methods ──
        public void get_major(){} // RVA: 0x7FFE82BC9920
        public void set_major(){} // RVA: 0x7FFE82BC9930
        public void get_minor(){} // RVA: 0x7FFE82BC9940
        public void set_minor(){} // RVA: 0x7FFE81E63F10
        public void get_patch(){} // RVA: 0x7FFE82BC9950
        public void set_patch(){} // RVA: 0x7FFE81E63F60
        public void .ctor(){} // RVA: 0x7FFE82BC9960
        public void ToString(){} // RVA: 0x7FFE82BC9970
        public void op_Implicit(){} // RVA: 0x7FFE82BC9BD0
        public void Equals(){} // RVA: 0x7FFE82BC9C80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE82BC9CA0
        public void op_Equality(){} // RVA: 0x7FFE82BC9CB0
        public void op_Inequality(){} // RVA: 0x7FFE82BC9CE0
        public void op_LessThan(){} // RVA: 0x7FFE82BC9D10
        public void op_GreaterThan(){} // RVA: 0x7FFE82BC9D60
        public void op_LessThanOrEqual(){} // RVA: 0x7FFE82BC9DB0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFE82BC9E40
    }

}