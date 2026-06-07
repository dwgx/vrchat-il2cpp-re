// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 38
// Methods: 528

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip
    {
        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x1E2A830
        public void remove_newFrame(){} // RVA: 0x1E2A920
        public void add_newPoster(){} // RVA: 0x1E2AA10
        public void remove_newPoster(){} // RVA: 0x1E2AB00
        public void add_m_newMetadata(){} // RVA: 0x1E2ABF0
        public void remove_m_newMetadata(){} // RVA: 0x1E2ACE0
        public void add_newMetadata(){} // RVA: 0x1E2ADD0
        public void remove_newMetadata(){} // RVA: 0x1E2AFA0
        public void OnNewFrame(){} // RVA: 0x1E2B0B0
        public void OnNewMetadata(){} // RVA: 0x1E2B0D0
        public void OnNewPoster(){} // RVA: 0x1E2B0F0
        public void get_playerEvents(){} // RVA: 0x1E2B110
        public void get_metadataFilePath(){} // RVA: 0x4976A0
        public void set_metadataFilePath(){} // RVA: 0x1E2B240
        public void get_metadataFile(){} // RVA: 0x35A740
        public void set_metadataFile(){} // RVA: 0x1E2B480
        public void get_metadataSourceType(){} // RVA: 0x37E0C0
        public void get_metadata(){} // RVA: 0x37E0E0
        public void get_hasMetadata(){} // RVA: 0x1E2B6E0
        public void LoadMetadata(){} // RVA: 0x1E2B710
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x1E2B960
        public void get_perspectiveDataBuffer(){} // RVA: 0x1E2BA40
        public void get_player(){} // RVA: 0x37B370
        public void CreatePlayer(){} // RVA: 0x1E2BA50
        public void SetPlayer(){} // RVA: 0x1E2BCC0 | overloaded x2
        public void get_playerSetup(){} // RVA: 0x1E2BEF0
        public void get_playerIsActive(){} // RVA: 0x1E2BFF0
        public void get_width(){} // RVA: 0x1E2C0D0
        public void get_height(){} // RVA: 0x1E2C120
        public void get_gammaCorrectDepth(){} // RVA: 0x1E2C170
        public void get_gammaCorrectColor(){} // RVA: 0x1E2C210
        public void get_cppTexture(){} // RVA: 0x1E2C260
        public void get_textureIsFlipped(){} // RVA: 0x1E2C2C0
        public void get_poster(){} // RVA: 0x4C7C50
        public void set_poster(){} // RVA: 0x1E2C310
        public void get_disablePoster(){} // RVA: 0x5A8B10
        public void set_disablePoster(){} // RVA: 0x1E2C450
        public void GetDataSource(){} // RVA: 0x283FA0
        public void DoResize(){} // RVA: 0x1E2C470
        public void DoGenerate(){} // RVA: 0x1E2C7F0
        public void ResetDataSources(){} // RVA: 0x1E2CCF0
        public void SetProperties(){} // RVA: 0x1E2D7D0 | overloaded x3
        public void get_isSetup(){} // RVA: 0x1E2DC40
        public void OnEnable(){} // RVA: 0x1E2DC80
        public void OnDisable(){} // RVA: 0x1E2E090
        public void Start(){} // RVA: 0x1E2E330
        public void Update(){} // RVA: 0x1E2E440
        public void LateUpdate(){} // RVA: 0x1E2E500
        public void OnDestroy(){} // RVA: 0x1E2E5A0
        public void OnApplicationQuit(){} // RVA: 0x1E2E820
        public void .ctor(){} // RVA: 0x1E2E910
        public void .cctor(){} // RVA: 0x1E2E960
    }

    public class ClipEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
        public void BeginInvoke(){} // RVA: 0x33BA60
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class ClipPlayer
    {
        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x3CB9D0
        public void set_videoLoaded(){} // RVA: 0x3CB9E0
        public void CreatePlayer(){} // RVA: 0x24A50
        public void IsPlayerCreated(){} // RVA: 0xDBE0
        public void IsPlayerSetup(){} // RVA: 0xDBE0
        public void Load(){} // RVA: 0xCD60
        public void StartVideoLoad(){} // RVA: 0x24A50
        public void LoadAndPlay(){} // RVA: 0xCD60
        public void SetVideoPath(){} // RVA: 0x24B10
        public void GetVideoPath(){} // RVA: 0xCD60
        public void OnMetadataUpdated(){} // RVA: 0x24B10
        public void Play(){} // RVA: 0x24A50
        public void Pause(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void RemoveComponents(){} // RVA: 0x24A50
        public void GetTexture(){} // RVA: 0xCD60
        public void IsTextureFlipped(){} // RVA: 0xDBE0
        public void GammaCorrectDepth(){} // RVA: 0xD840
        public void GammaCorrectColor(){} // RVA: 0xD840
        public void GetPlayerTypeName(){} // RVA: 0xCD60
        public void GetPlayerPrettyName(){} // RVA: 0x1E3C640
        public void IsPlaying(){} // RVA: 0xDBE0
        public void GetCurrentTime(){} // RVA: 0x12A40
        public void GetCurrentFrame(){} // RVA: 0xD840
        public void GetDuration(){} // RVA: 0x12A40
        public void Seek(){} // RVA: 0x325B0
        public void GetVideoWidth(){} // RVA: 0xD840
        public void GetVideoHeight(){} // RVA: 0xD840
        public void SupportsPosterFrame(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x1E3C680
    }

    public class ClipPlayerEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
        public void BeginInvoke(){} // RVA: 0x33BA60
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class CoreLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x1E39DE0
        public void GetLookName(){} // RVA: 0x1E3A0C0
        public void SetDefaults(){} // RVA: 0x1E3A100
        public void SetDataSources(){} // RVA: 0x1E3A230
        public void .ctor(){} // RVA: 0x1E3A380
    }

    public class CoreMeshSource
    {
        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x1E2F150
        public void set_meshDensity(){} // RVA: 0x1E2F170
        public void get_latticeMaxTriangles(){} // RVA: 0x1D76590
        public void get_latticeResolution(){} // RVA: 0xA1C8C0
        public void get_scaledPerspectiveResolution(){} // RVA: 0x1E2F220
        public void ResizeLattice(){} // RVA: 0x1E2F2D0
        public void get_vertexBuffer(){} // RVA: 0x348120
        public void GetComputeShaderName(){} // RVA: 0x1E2F400
        public void GetKernelNamePostfix(){} // RVA: 0x1E2F440
        public void FindKernelId(){} // RVA: 0x1E2F4E0
        public void GenerateVertexBuffer(){} // RVA: 0x1E2F740
        public void GenerateTriangles(){} // RVA: 0x1E30260 | overloaded x2
        public void GenerateVertices(){} // RVA: 0x1E2F9F0
        public void GenerateNormals(){} // RVA: 0x1E2FF20
        public void DataSourceName(){} // RVA: 0x1E30690
        public void EnsureVertexBuffer(){} // RVA: 0x1E306D0
        public void AcquireResources(){} // RVA: 0x1E30800
        public void FreeResources(){} // RVA: 0x1E309D0
        public void OnSetup(){} // RVA: 0x1E30A10
        public void baseResize(){} // RVA: 0x1E30A90
        public void OnResize(){} // RVA: 0x1E30AA0
        public void GenerateEdgeMask(){} // RVA: 0x1E30C40
        public void OnGenerate(){} // RVA: 0x1E30D20
        public void SetProperties(){} // RVA: 0x1E31360 | overloaded x3
        public void EnsureMaskGenerator(){} // RVA: 0x1E31520
        public void .ctor(){} // RVA: 0x1E31730
    }

    public class DataSource
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x6374D0
        public void get_dataSourceParent(){} // RVA: 0x4976A0
        public void DataSourceName(){} // RVA: 0xCD60
        public void GetChild(){} // RVA: 0x283FA0
        public void ResetChildren(){} // RVA: 0x1E31AA0
        public void AcquireResources(){} // RVA: 0x2DD310
        public void FreeResources(){} // RVA: 0x2DD310
        public void OnAwake(){} // RVA: 0x2DD310
        public void OnCleanup(){} // RVA: 0x2DD310
        public void OnSetup(){} // RVA: 0xDBE0
        public void OnResize(){} // RVA: 0xDBE0
        public void OnGenerate(){} // RVA: 0xDBE0
        public void OnUpdate(){} // RVA: 0x2DD310
        public void CanGenerate(){} // RVA: 0x3C2850
        public void Awake(){} // RVA: 0x1E31CD0
        public void Start(){} // RVA: 0x1E31E90
        public void ScheduleGenerate(){} // RVA: 0xB04010
        public void ScheduleResize(){} // RVA: 0x1E31EB0
        public void UnscheduleGenerate(){} // RVA: 0xB04020
        public void UnscheduleResize(){} // RVA: 0x1E31EC0
        public void OnEnable(){} // RVA: 0x1E31ED0
        public void OnDisable(){} // RVA: 0x1E32170
        public void Reset(){} // RVA: 0x1E32400
        public void Setup(){} // RVA: 0x1E32410
        public void Cleanup(){} // RVA: 0x1E326C0
        public void Resize(){} // RVA: 0x1E32AC0
        public void IsSetup(){} // RVA: 0x6E8A80
        public void Generate(){} // RVA: 0x1E32EC0
        public void Update(){} // RVA: 0x1E332F0
        public void LateUpdate(){} // RVA: 0x1E33310
        public void .ctor(){} // RVA: 0x1E33350
    }

    public class DataSourceEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
        public void BeginInvoke(){} // RVA: 0x33BA60
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class DataSourceEvents
    {
        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x1E334C0
        public void remove_m_dataGenerated(){} // RVA: 0x1E335B0
        public void add_dataGenerated(){} // RVA: 0x1E336A0
        public void remove_dataGenerated(){} // RVA: 0x1E33870
        public void add_m_dataResized(){} // RVA: 0x1E33980
        public void remove_m_dataResized(){} // RVA: 0x1E33A70
        public void add_dataResized(){} // RVA: 0x1E33B60
        public void remove_dataResized(){} // RVA: 0x1E33D30
        public void OnDataGenerated(){} // RVA: 0x1E33E40
        public void OnDataResized(){} // RVA: 0x1E33E60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DepthkitLookEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
        public void BeginInvoke(){} // RVA: 0x33BA60
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class GaussianBlurFilter
    {
        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x1E3EC10
        public void get_texture(){} // RVA: 0x1E3EC20
        public void CreateTextures(){} // RVA: 0x1E3EC50
        public void Setup(){} // RVA: 0x1E3F140
        public void EnsureTextures(){} // RVA: 0x1E3F220
        public void DoBlur(){} // RVA: 0x1E3F490
        public void BlurPass(){} // RVA: 0x1E3F630
        public void Release(){} // RVA: 0x1E3FC30
        public void .ctor(){} // RVA: 0x1E3FDB0
        public void .cctor(){} // RVA: 0x1E3FDD0
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x2DC60 | overloaded x3
    }

    public class IndexedCoreTriangleSubMesh
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E2F120
    }

    public class Info
    {
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x1E40900
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1E40D30
    }

    public class Look
    {
        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x1E3A3D0
        public void get_materialPropertyBlock(){} // RVA: 0x1E3A4E0
        public void GetLookName(){} // RVA: 0xCD60
        public void UsesMaterial(){} // RVA: 0xDBE0
        public void GetMaterial(){} // RVA: 0xCD60
        public void UsesMaterialPropertyBlock(){} // RVA: 0x3C2850
        public void GetMaterialPropertyBlock(){} // RVA: 0x1E3A4E0
        public void SetDataSources(){} // RVA: 0x24A50
        public void ValidateDataSources(){} // RVA: 0x1E3A500
        public void SetMaterialProperties(){} // RVA: 0x2DD310 | overloaded x2
        public void OnUpdate(){} // RVA: 0xAE50F0
        public void SetDefaults(){} // RVA: 0x1E3A5D0
        public void SetLookProperties(){} // RVA: 0x1E3A670
        public void Awake(){} // RVA: 0x1E3AF30
        public void Init(){} // RVA: 0x1E3B160
        public void Start(){} // RVA: 0x1E3B4A0
        public void OnEnable(){} // RVA: 0x1E3B4D0
        public void OnDisable(){} // RVA: 0x1E3B600
        public void SyncColliderToBounds(){} // RVA: 0x1E3B810
        public void OnMetaDataUpdated(){} // RVA: 0x1E3BBE0
        public void LateUpdate(){} // RVA: 0x1E3BBF0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class MaskGenerator
    {
        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x37E0E0
        public void set_perspectivesToSlice(){} // RVA: 0x4354D0
        public void get_sliceToPerspective(){} // RVA: 0x3A5500
        public void set_sliceToPerspective(){} // RVA: 0x3A5510
        public void get_sliceCount(){} // RVA: 0x1E33E80
        public void set_sliceCount(){} // RVA: 0x1E33EA0
        public void get_blurRadius(){} // RVA: 0x1E33EB0
        public void set_blurRadius(){} // RVA: 0x1E33ED0
        public void get_paddedUVScaleFactor(){} // RVA: 0x1E33EF0
        public void get_maskTexture(){} // RVA: 0x1E340F0
        public void get_downScale(){} // RVA: 0x1C5A600
        public void set_downScale(){} // RVA: 0x1E34140
        public void get_downScaledMaskTexture(){} // RVA: 0x1E341C0
        public void DownScalePass(){} // RVA: 0x1E34230
        public void DownScaleMaskTexture(){} // RVA: 0x1E343D0
        public void Setup(){} // RVA: 0x1E35190
        public void EnsureTexture(){} // RVA: 0x1E356E0
        public void Release(){} // RVA: 0x1E359C0
        public void SobelFilterMask(){} // RVA: 0x1E35B70
        public void BlurMask(){} // RVA: 0x1E35F60
        public void GenerateMask(){} // RVA: 0x1E35FA0
        public void SetProperties(){} // RVA: 0x1E367A0 | overloaded x3
        public void .ctor(){} // RVA: 0x1E36BE0
    }

    public class MeshSource
    {
        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0x283FA0 | overloaded x2
        public void CurrentSubMesh(){} // RVA: 0x283FA0 | overloaded x2
        public void ReserveSubMeshes(){} // RVA: 0x24FA0
        public void get_currentSubmeshIndex(){} // RVA: 0x1C91460
        public void set_currentSubmeshIndex(){} // RVA: 0x1C91470
        public void get_triangleBuffer(){} // RVA: 0x1E373F0
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x1E37440
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x1E37490
        public void get_maxSurfaceTriangles(){} // RVA: 0x1E374E0
        public void set_maxSurfaceTriangles(){} // RVA: 0x1E37530
        public void get_useTriangleMesh(){} // RVA: 0x359320
        public void set_useTriangleMesh(){} // RVA: 0x1E37590
        public void get_triangleMesh(){} // RVA: 0x1E375F0
        public void EnsureRadialBias(){} // RVA: 0x1E37630
        public void AcquireResources(){} // RVA: 0x1E378E0
        public void FreeResources(){} // RVA: 0x1E379A0
        public void CanGenerate(){} // RVA: 0x1E37A10
        public void OnSetup(){} // RVA: 0x1E37B10
        public void OnResize(){} // RVA: 0x1E37C60
        public void OnUpdate(){} // RVA: 0x1E37F10
        public void OnGenerate(){} // RVA: 0x1E380E0
        public void GetLocalBounds(){} // RVA: 0x1E383A0
        public void GetWorldBounds(){} // RVA: 0x1E38570
        public void Pause(){} // RVA: 0x1E388B0
        public void Continue(){} // RVA: 0x1E38940
        public void OnBecameVisible(){} // RVA: 0x1E389E0
        public void OnBecameInvisible(){} // RVA: 0x1E38A00
        public void CheckVisibility(){} // RVA: 0x1E38A20
        public void SetProperties(){} // RVA: 0x1E38C90 | overloaded x3
        public void .ctor(){} // RVA: 0x1E38DA0
    }

    public class Metadata
    {
        // ── Methods ──
        public void Valid(){} // RVA: 0x1E40D80
        public void get_perspectiveCPPResolution(){} // RVA: 0x1E40DA0
        public void get_perspectiveResolution(){} // RVA: 0x1E40E10
        public void get_paddedTextureDimensions(){} // RVA: 0x1E40E90
        public void FromSinglePerspective(){} // RVA: 0x1E40F10
        public void CreateFromJSON(){} // RVA: 0x1E411E0
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x1E41DD0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1E42170
    }

    public class PackedCoreTriangleSubMesh
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E2F0F0
    }

    public class PerspectiveColorBlending
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x1E51BD0
    }

    public class PerspectiveColorBlendingData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E51D00
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x1E51FC0
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x1E52000
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x1E520C0
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x1E52100
        public void GetEdgeMaskStrength(){} // RVA: 0x1E521C0
        public void SetEdgeMaskStrength(){} // RVA: 0x1E52200
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x1E522C0
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x1E52300
        public void GetEdgeMaskEnabled(){} // RVA: 0x1E523C0
        public void SetEdgeMaskEnabled(){} // RVA: 0x1E52410
        public void GetPerspectiveEnabled(){} // RVA: 0x1E524C0
        public void SetPerspectiveEnabled(){} // RVA: 0x1E52500
    }

    public class PerspectiveGeometry
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x1E525A0
    }

    public class PerspectiveGeometryData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E526D0
        public void EnableGeometry(){} // RVA: 0x1E52AB0 | overloaded x2
        public void GetOverrideWeightUnknown(){} // RVA: 0x1E52B50
        public void SetOverrideWeightUnknown(){} // RVA: 0x1E52B90
        public void GetWeightUnknown(){} // RVA: 0x1E520C0
        public void SetWeightUnknown(){} // RVA: 0x1E52C30
        public void MatchViewDependentColorWeight(){} // RVA: 0x1E52D20 | overloaded x2
        public void GetViewDependentContribution(){} // RVA: 0x1E52D50
        public void SetViewDependentContribution(){} // RVA: 0x1E52D80
        public void GetViewDependentWeight(){} // RVA: 0x1E51FC0
        public void SetViewDependentWeight(){} // RVA: 0x1E52DD0
        public void GetViewDependentInFrontAmount(){} // RVA: 0x1E521C0
        public void SetViewDependentInFrontAmount(){} // RVA: 0x1E52E90
        public void GetViewDependentUnseenAmount(){} // RVA: 0x1E522C0
        public void SetViewDependentUnseenAmount(){} // RVA: 0x1E52F50
    }

    public class PlatformValidator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x1E422D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PlayerEvents
    {
        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x1E3C750
        public void remove_playbackStarted(){} // RVA: 0x1E3C840
        public void add_playbackPaused(){} // RVA: 0x1E3C930
        public void remove_playbackPaused(){} // RVA: 0x1E3CA20
        public void add_playbackStopped(){} // RVA: 0x1E3CB10
        public void remove_playbackStopped(){} // RVA: 0x1E3CC00
        public void add_loadingStarted(){} // RVA: 0x1E3CCF0
        public void remove_loadingStarted(){} // RVA: 0x1E3CDE0
        public void add_loadingFinished(){} // RVA: 0x1E3CED0
        public void remove_loadingFinished(){} // RVA: 0x1E3CFC0
        public void OnClipPlaybackStarted(){} // RVA: 0x1E33E40
        public void OnClipPlaybackPaused(){} // RVA: 0x1E33E60
        public void OnClipPlaybackStopped(){} // RVA: 0x1E2B0B0
        public void OnClipLoadingStarted(){} // RVA: 0x1E2B0F0
        public void OnClipLoadingFinished(){} // RVA: 0x1E2B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProceduralLook
    {
        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x3C2850
        public void GetMaterial(){} // RVA: 0x358D50
        public void UsesMaterialPropertyBlock(){} // RVA: 0x3C2850
        public void SetMaterialProperties(){} // RVA: 0x1E3BEE0
        public void OnUpdate(){} // RVA: 0x1E3C380
        public void .ctor(){} // RVA: 0x1E3A380
    }

    public class SetCaptureFrameRate
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x1E424D0
        public void Update(){} // RVA: 0x1E424E0
        public void LateUpdate(){} // RVA: 0x1E42500
        public void .ctor(){} // RVA: 0x1E42520
    }

    public class StudioLiteLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x1E55010
        public void GetLookName(){} // RVA: 0x1E55CC0
        public void SetDefaults(){} // RVA: 0x1E55D00
        public void SetDataSources(){} // RVA: 0x1E56460
        public void OnUpdate(){} // RVA: 0x1E565B0
        public void .ctor(){} // RVA: 0x1E56900
    }

    public class StudioLiteMeshSource
    {
        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x1E53180
        public void GetKernelNamePostfix(){} // RVA: 0x1E531C0
        public void GenerateTriangles(){} // RVA: 0x1E532D0
        public void DataSourceName(){} // RVA: 0x1E539C0
        public void OnResize(){} // RVA: 0x1E53A00
        public void GenerateEdgeMask(){} // RVA: 0x1E53D10
        public void OnGenerate(){} // RVA: 0x1E53E00
        public void .ctor(){} // RVA: 0x1E54E50
    }

    public class StudioLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x1E51630
        public void GetLookName(){} // RVA: 0x1E51910
        public void SetDataSources(){} // RVA: 0x1E51950
        public void SetDefaults(){} // RVA: 0x1E51AA0
        public void .ctor(){} // RVA: 0x1E3A380
    }

    public class StudioMeshSource
    {
        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x1E48590
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x1D12470
        public void get_volumeBounds(){} // RVA: 0x5076F0
        public void set_volumeBounds(){} // RVA: 0x1E48610
        public void GetLocalBounds(){} // RVA: 0x5076F0
        public void get_volumeDensity(){} // RVA: 0x1E48700
        public void set_volumeDensity(){} // RVA: 0x1E48710
        public void get_numLevelOfDetailLevels(){} // RVA: 0x13CBAD0
        public void set_numLevelOfDetailLevels(){} // RVA: 0x13D7860
        public void set_useTextureAtlas(){} // RVA: 0xA90560
        public void DataSourceName(){} // RVA: 0x1E48720
        public void GetScaledKernelName(){} // RVA: 0x1E48760
        public void GetExtractVolumeKernelName(){} // RVA: 0x1E48990
        public void OnAwake(){} // RVA: 0x1E48B60
        public void OnSetup(){} // RVA: 0x1E48CF0
        public void ResetGPUResources(){} // RVA: 0x1E493E0
        public void AcquireResources(){} // RVA: 0x1E49440
        public void FreeResources(){} // RVA: 0x1E496D0
        public void EnsureBuffers(){} // RVA: 0x1E49B10
        public void EnsureTextures(){} // RVA: 0x1E49CD0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x283FA0
        public void EnsureSyncedBuffers(){} // RVA: 0x1E49F60
        public void SetupViewDependence(){} // RVA: 0x1E4A1C0
        public void OnNewMetadata(){} // RVA: 0x1E4A820
        public void ResetVolumeBounds(){} // RVA: 0x1E4AA10
        public void ResetSurfaceSensitivity(){} // RVA: 0x1E4AA90
        public void LoadFrontBiasedDefaults(){} // RVA: 0x1E4AB50
        public void OnResize(){} // RVA: 0x1E4AB90
        public void SetProperties(){} // RVA: 0x1E4BA40 | overloaded x3
        public void SetCommonComputeProperties(){} // RVA: 0x1E4BD30
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x1E4C310
        public void FilterSdf(){} // RVA: 0x1E4C6B0
        public void GenerateNormalWeights(){} // RVA: 0x1E4CDE0
        public void GenerateNormalWeightsCompute(){} // RVA: 0x1E4D020
        public void GenerateEdgeBlendMask(){} // RVA: 0x1E4D310
        public void DispatchSize(){} // RVA: 0x1E4D390
        public void GenerateVolumePass(){} // RVA: 0x1E4D430
        public void GenerateVolume(){} // RVA: 0x1E4D4D0
        public void ActivePerspectives(){} // RVA: 0x1E4D5F0
        public void GenerateVolumeMultiPass(){} // RVA: 0x1E4D6F0
        public void GenerateVolumeSinglePass(){} // RVA: 0x1E4DCB0
        public void ExtractSurfaceFromVolume(){} // RVA: 0x1E4DE80
        public void DrawDebug(){} // RVA: 0x1E4E2F0
        public void OnGenerate(){} // RVA: 0x1E4EB00
        public void OnUpdate(){} // RVA: 0x1E4F060
        public void EnsureMaskGenerator(){} // RVA: 0x1E4F920
        public void get_enableEdgeMask(){} // RVA: 0x1E4FBC0
        public void set_enableEdgeMask(){} // RVA: 0x1E4FBE0
        public void .ctor(){} // RVA: 0x1E4FBF0
        public void .cctor(){} // RVA: 0x1E4FE20
    }

    public class SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0xD840
        public void get_triangleBuffer(){} // RVA: 0x2E07C0
        public void get_trianglesCount(){} // RVA: 0x30B0C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x30B130
        public void get_drawIndirectArgs(){} // RVA: 0x6374D0
        public void Init(){} // RVA: 0x1E38F10
        public void CopyTriangleCount(){} // RVA: 0x1E38FC0
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x1E39030
        public void PrepareDrawArgs(){} // RVA: 0x1E390E0
        public void PrepareDispatchArgs(){} // RVA: 0x1E39160
        public void EnsureBuffers(){} // RVA: 0x1E39200
        public void Release(){} // RVA: 0x1E395E0
        public void set_source(){} // RVA: 0x49B830
        public void get_triangleMesh(){} // RVA: 0x1E39790
        public void SetProperties(){} // RVA: 0x1E39AC0 | overloaded x3
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubMesh`1
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SyncedStructuredBuffer`1
    {
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C800
        public void get_Length(){} // RVA: 0xD840
        public void MarkDirty(){} // RVA: 0x24A50
        public void Sync(){} // RVA: 0xDBE0
        public void Release(){} // RVA: 0x24A50
    }

    public class TriangleMesh
    {
        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x760030
        public void set_TriangleCount(){} // RVA: 0x1E42570
        public void get_mesh(){} // RVA: 0x1E42580
        public void EnsureTriangleMesh(){} // RVA: 0x1E42E70 | overloaded x3
        public void CreateMesh(){} // RVA: 0x1E43280
        public void ReleaseMesh(){} // RVA: 0x1E43340
        public void GetCubeVerts(){} // RVA: 0x1E434B0
        public void GetCubeTriangles(){} // RVA: 0x1E43680
        public void ResetMeshCube(){} // RVA: 0x1E43790
        public void CreateLattice(){} // RVA: 0x1E43A90
        public void addVertex(){} // RVA: 0x1E43F00
        public void CreateTriangleLattice(){} // RVA: 0x1E44090
        public void CreateCubeMesh(){} // RVA: 0x1E444F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityVideoPlayer
    {
        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x1E3D0B0
        public void IsPlayerCreated(){} // RVA: 0x1E3D6E0
        public void IsPlayerSetup(){} // RVA: 0x1E3D7B0
        public void SetVideoPath(){} // RVA: 0x1E3DA40
        public void GetVideoPath(){} // RVA: 0x1E3DAD0
        public void StartVideoLoad(){} // RVA: 0x1E3DC90
        public void Load(){} // RVA: 0x1E3DCC0
        public void OnVideoLoadingComplete(){} // RVA: 0x1E3DD60
        public void OnMetadataUpdated(){} // RVA: 0x2DD310
        public void LoadAndPlay(){} // RVA: 0x1E3DD90
        public void Play(){} // RVA: 0x1E3DE30
        public void Pause(){} // RVA: 0x1E3DEC0
        public void Stop(){} // RVA: 0x1E3DF50
        public void GetCurrentFrame(){} // RVA: 0x1E3DFE0
        public void GetCurrentTime(){} // RVA: 0x1E3E040
        public void GetDuration(){} // RVA: 0x1E3E0A0
        public void GetTexture(){} // RVA: 0x1E3E150
        public void IsTextureFlipped(){} // RVA: 0x2DD320
        public void GammaCorrectDepth(){} // RVA: 0x1E3E1B0
        public void GammaCorrectColor(){} // RVA: 0x1E3E200
        public void IsPlaying(){} // RVA: 0x1E3E250
        public void RemoveComponents(){} // RVA: 0x1E3E2B0
        public void GetPlayerTypeName(){} // RVA: 0x1E3E480
        public void GetPlayerPrettyName(){} // RVA: 0x1E3E550
        public void GetPlayerBackend(){} // RVA: 0x6374D0
        public void Seek(){} // RVA: 0x1E3E590
        public void GetVideoWidth(){} // RVA: 0x1E3E690
        public void GetVideoHeight(){} // RVA: 0x1E3E7C0
        public void SupportsPosterFrame(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x1E3C680
    }

    public class Util
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x1E44B10
        public void GetScaled2DKernelName(){} // RVA: 0x1E44B30
        public void GetScaled3DKernelName(){} // RVA: 0x1E44D60
        public void DispatchGroups(){} // RVA: 0x1E44EE0
        public void ClearRenderTexture(){} // RVA: 0x1E45040
        public void ClearAppendBuffer(){} // RVA: 0x1E45240
        public void ReleaseComputeBuffer(){} // RVA: 0x1E454B0
        public void ReleaseRenderTexture(){} // RVA: 0x1E45520
        public void CopyFromRenderTextureSettings(){} // RVA: 0x1E456E0
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x1E45AD0
        public void TransformBounds(){} // RVA: 0x1E45D30
        public void CreateRenderTexture(){} // RVA: 0x1E45FD0
        public void EnsureRenderTexture(){} // RVA: 0x1E46250
        public void EnsureComputeBuffer(){} // RVA: 0x1E467C0
        public void ColorForCamera(){} // RVA: 0x1E46A10
        public void RenderPerspectiveGizmo(){} // RVA: 0x2DD310
        public void RenderMetadataGizmos(){} // RVA: 0x2DD310
        public void IsVisible(){} // RVA: 0x1E46BD0
        public void metersToCm(){} // RVA: 0x1E46E30
        public void cmToMeters(){} // RVA: 0x1E46E40
        public void EnsureKeyword(){} // RVA: 0x1E46E50
        public void EnsureComputeShader(){} // RVA: 0x1E46F50
    }

    public class Version
    {
        // ── Methods ──
        public void get_major(){} // RVA: 0x1E40360
        public void set_major(){} // RVA: 0x1E40370
        public void get_minor(){} // RVA: 0x1E40380
        public void set_minor(){} // RVA: 0x10EEB00
        public void get_patch(){} // RVA: 0x1E40390
        public void set_patch(){} // RVA: 0x10EEB20
        public void .ctor(){} // RVA: 0x1D765C0
        public void ToString(){} // RVA: 0x1E403A0
        public void op_Implicit(){} // RVA: 0x1E40600
        public void Equals(){} // RVA: 0x1E406B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x1E406D0
        public void op_Equality(){} // RVA: 0x1E406E0
        public void op_Inequality(){} // RVA: 0x1E40710
        public void op_LessThan(){} // RVA: 0x1E40740
        public void op_GreaterThan(){} // RVA: 0x1E40790
        public void op_LessThanOrEqual(){} // RVA: 0x1E407E0
        public void op_GreaterThanOrEqual(){} // RVA: 0x1E40870
    }

}