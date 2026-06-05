// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 43
// Methods: 547

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip
    {
        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x7FFAF48DA830
        public void remove_newFrame(){} // RVA: 0x7FFAF48DA920
        public void add_newPoster(){} // RVA: 0x7FFAF48DAA10
        public void remove_newPoster(){} // RVA: 0x7FFAF48DAB00
        public void add_m_newMetadata(){} // RVA: 0x7FFAF48DABF0
        public void remove_m_newMetadata(){} // RVA: 0x7FFAF48DACE0
        public void add_newMetadata(){} // RVA: 0x7FFAF48DADD0
        public void remove_newMetadata(){} // RVA: 0x7FFAF48DAFA0
        public void OnNewFrame(){} // RVA: 0x7FFAF48DB0B0
        public void OnNewMetadata(){} // RVA: 0x7FFAF48DB0D0
        public void OnNewPoster(){} // RVA: 0x7FFAF48DB0F0
        public void get_playerEvents(){} // RVA: 0x7FFAF48DB110
        public void get_metadataFilePath(){} // RVA: 0x7FFAF2F476A0
        public void set_metadataFilePath(){} // RVA: 0x7FFAF48DB240
        public void get_metadataFile(){} // RVA: 0x7FFAF2E0A740
        public void set_metadataFile(){} // RVA: 0x7FFAF48DB480
        public void get_metadataSourceType(){} // RVA: 0x7FFAF2E2E0C0
        public void get_metadata(){} // RVA: 0x7FFAF2E2E0E0
        public void get_hasMetadata(){} // RVA: 0x7FFAF48DB6E0
        public void LoadMetadata(){} // RVA: 0x7FFAF48DB710
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7FFAF48DB960
        public void get_perspectiveDataBuffer(){} // RVA: 0x7FFAF48DBA40
        public void get_player(){} // RVA: 0x7FFAF2E2B370
        public void CreatePlayer(){} // RVA: 0x7FFAF48DBA50
        public void SetPlayer(){} // RVA: 0x7FFAF48DBCC0 | overloaded x2
        public void get_playerSetup(){} // RVA: 0x7FFAF48DBEF0
        public void get_playerIsActive(){} // RVA: 0x7FFAF48DBFF0
        public void get_width(){} // RVA: 0x7FFAF48DC0D0
        public void get_height(){} // RVA: 0x7FFAF48DC120
        public void get_gammaCorrectDepth(){} // RVA: 0x7FFAF48DC170
        public void get_gammaCorrectColor(){} // RVA: 0x7FFAF48DC210
        public void get_cppTexture(){} // RVA: 0x7FFAF48DC260
        public void get_textureIsFlipped(){} // RVA: 0x7FFAF48DC2C0
        public void get_poster(){} // RVA: 0x7FFAF2F77C50
        public void set_poster(){} // RVA: 0x7FFAF48DC310
        public void get_disablePoster(){} // RVA: 0x7FFAF3058B10
        public void set_disablePoster(){} // RVA: 0x7FFAF48DC450
        public void GetDataSource(){} // RVA: 0x7FFAF2D33FA0
        public void DoResize(){} // RVA: 0x7FFAF48DC470
        public void DoGenerate(){} // RVA: 0x7FFAF48DC7F0
        public void ResetDataSources(){} // RVA: 0x7FFAF48DCCF0
        public void SetProperties(){} // RVA: 0x7FFAF48DD7D0 | overloaded x3
        public void get_isSetup(){} // RVA: 0x7FFAF48DDC40
        public void OnEnable(){} // RVA: 0x7FFAF48DDC80
        public void OnDisable(){} // RVA: 0x7FFAF48DE090
        public void Start(){} // RVA: 0x7FFAF48DE330
        public void Update(){} // RVA: 0x7FFAF48DE440
        public void LateUpdate(){} // RVA: 0x7FFAF48DE500
        public void OnDestroy(){} // RVA: 0x7FFAF48DE5A0
        public void OnApplicationQuit(){} // RVA: 0x7FFAF48DE820
        public void .ctor(){} // RVA: 0x7FFAF48DE910
        public void .cctor(){} // RVA: 0x7FFAF48DE960
    }

    public class ClipEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
        public void BeginInvoke(){} // RVA: 0x7FFAF2DEBA60
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class ClipPlayer
    {
        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x7FFAF2E7B9D0
        public void set_videoLoaded(){} // RVA: 0x7FFAF2E7B9E0
        public void CreatePlayer(){} // RVA: 0x7FFAF2AD4A50
        public void IsPlayerCreated(){} // RVA: 0x7FFAF2ABDBE0
        public void IsPlayerSetup(){} // RVA: 0x7FFAF2ABDBE0
        public void Load(){} // RVA: 0x7FFAF2ABCD60
        public void StartVideoLoad(){} // RVA: 0x7FFAF2AD4A50
        public void LoadAndPlay(){} // RVA: 0x7FFAF2ABCD60
        public void SetVideoPath(){} // RVA: 0x7FFAF2AD4B10
        public void GetVideoPath(){} // RVA: 0x7FFAF2ABCD60
        public void OnMetadataUpdated(){} // RVA: 0x7FFAF2AD4B10
        public void Play(){} // RVA: 0x7FFAF2AD4A50
        public void Pause(){} // RVA: 0x7FFAF2AD4A50
        public void Stop(){} // RVA: 0x7FFAF2AD4A50
        public void RemoveComponents(){} // RVA: 0x7FFAF2AD4A50
        public void GetTexture(){} // RVA: 0x7FFAF2ABCD60
        public void IsTextureFlipped(){} // RVA: 0x7FFAF2ABDBE0
        public void GammaCorrectDepth(){} // RVA: 0x7FFAF2ABD840
        public void GammaCorrectColor(){} // RVA: 0x7FFAF2ABD840
        public void GetPlayerTypeName(){} // RVA: 0x7FFAF2ABCD60
        public void GetPlayerPrettyName(){} // RVA: 0x7FFAF48EC640
        public void IsPlaying(){} // RVA: 0x7FFAF2ABDBE0
        public void GetCurrentTime(){} // RVA: 0x7FFAF2AC2A40
        public void GetCurrentFrame(){} // RVA: 0x7FFAF2ABD840
        public void GetDuration(){} // RVA: 0x7FFAF2AC2A40
        public void Seek(){} // RVA: 0x7FFAF2AE25B0
        public void GetVideoWidth(){} // RVA: 0x7FFAF2ABD840
        public void GetVideoHeight(){} // RVA: 0x7FFAF2ABD840
        public void SupportsPosterFrame(){} // RVA: 0x7FFAF2ABDBE0
        public void .ctor(){} // RVA: 0x7FFAF48EC680
    }

    public class ClipPlayerEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
        public void BeginInvoke(){} // RVA: 0x7FFAF2DEBA60
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class CoreLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAF48E9DE0
        public void GetLookName(){} // RVA: 0x7FFAF48EA0C0
        public void SetDefaults(){} // RVA: 0x7FFAF48EA100
        public void SetDataSources(){} // RVA: 0x7FFAF48EA230
        public void .ctor(){} // RVA: 0x7FFAF48EA380
    }

    public class CoreMeshSource
    {
        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x7FFAF48DF150
        public void set_meshDensity(){} // RVA: 0x7FFAF48DF170
        public void get_latticeMaxTriangles(){} // RVA: 0x7FFAF4826590
        public void get_latticeResolution(){} // RVA: 0x7FFAF34CC8C0
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7FFAF48DF220
        public void ResizeLattice(){} // RVA: 0x7FFAF48DF2D0
        public void get_vertexBuffer(){} // RVA: 0x7FFAF2DF8120
        public void GetComputeShaderName(){} // RVA: 0x7FFAF48DF400
        public void GetKernelNamePostfix(){} // RVA: 0x7FFAF48DF440
        public void FindKernelId(){} // RVA: 0x7FFAF48DF4E0
        public void GenerateVertexBuffer(){} // RVA: 0x7FFAF48DF740
        public void GenerateTriangles(){} // RVA: 0x7FFAF48E0260 | overloaded x2
        public void GenerateVertices(){} // RVA: 0x7FFAF48DF9F0
        public void GenerateNormals(){} // RVA: 0x7FFAF48DFF20
        public void DataSourceName(){} // RVA: 0x7FFAF48E0690
        public void EnsureVertexBuffer(){} // RVA: 0x7FFAF48E06D0
        public void AcquireResources(){} // RVA: 0x7FFAF48E0800
        public void FreeResources(){} // RVA: 0x7FFAF48E09D0
        public void OnSetup(){} // RVA: 0x7FFAF48E0A10
        public void baseResize(){} // RVA: 0x7FFAF48E0A90
        public void OnResize(){} // RVA: 0x7FFAF48E0AA0
        public void GenerateEdgeMask(){} // RVA: 0x7FFAF48E0C40
        public void OnGenerate(){} // RVA: 0x7FFAF48E0D20
        public void SetProperties(){} // RVA: 0x7FFAF48E1360 | overloaded x3
        public void EnsureMaskGenerator(){} // RVA: 0x7FFAF48E1520
        public void .ctor(){} // RVA: 0x7FFAF48E1730
    }

    public class DataSource
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFAF30E74D0
        public void get_dataSourceParent(){} // RVA: 0x7FFAF2F476A0
        public void DataSourceName(){} // RVA: 0x7FFAF2ABCD60
        public void GetChild(){} // RVA: 0x7FFAF2D33FA0
        public void ResetChildren(){} // RVA: 0x7FFAF48E1AA0
        public void AcquireResources(){} // RVA: 0x7FFAF2D8D310
        public void FreeResources(){} // RVA: 0x7FFAF2D8D310
        public void OnAwake(){} // RVA: 0x7FFAF2D8D310
        public void OnCleanup(){} // RVA: 0x7FFAF2D8D310
        public void OnSetup(){} // RVA: 0x7FFAF2ABDBE0
        public void OnResize(){} // RVA: 0x7FFAF2ABDBE0
        public void OnGenerate(){} // RVA: 0x7FFAF2ABDBE0
        public void OnUpdate(){} // RVA: 0x7FFAF2D8D310
        public void CanGenerate(){} // RVA: 0x7FFAF2E72850
        public void Awake(){} // RVA: 0x7FFAF48E1CD0
        public void Start(){} // RVA: 0x7FFAF48E1E90
        public void ScheduleGenerate(){} // RVA: 0x7FFAF35B4010
        public void ScheduleResize(){} // RVA: 0x7FFAF48E1EB0
        public void UnscheduleGenerate(){} // RVA: 0x7FFAF35B4020
        public void UnscheduleResize(){} // RVA: 0x7FFAF48E1EC0
        public void OnEnable(){} // RVA: 0x7FFAF48E1ED0
        public void OnDisable(){} // RVA: 0x7FFAF48E2170
        public void Reset(){} // RVA: 0x7FFAF48E2400
        public void Setup(){} // RVA: 0x7FFAF48E2410
        public void Cleanup(){} // RVA: 0x7FFAF48E26C0
        public void Resize(){} // RVA: 0x7FFAF48E2AC0
        public void IsSetup(){} // RVA: 0x7FFAF3198A80
        public void Generate(){} // RVA: 0x7FFAF48E2EC0
        public void Update(){} // RVA: 0x7FFAF48E32F0
        public void LateUpdate(){} // RVA: 0x7FFAF48E3310
        public void .ctor(){} // RVA: 0x7FFAF48E3350
    }

    public class DataSourceEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
        public void BeginInvoke(){} // RVA: 0x7FFAF2DEBA60
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class DataSourceEvents
    {
        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7FFAF48E34C0
        public void remove_m_dataGenerated(){} // RVA: 0x7FFAF48E35B0
        public void add_dataGenerated(){} // RVA: 0x7FFAF48E36A0
        public void remove_dataGenerated(){} // RVA: 0x7FFAF48E3870
        public void add_m_dataResized(){} // RVA: 0x7FFAF48E3980
        public void remove_m_dataResized(){} // RVA: 0x7FFAF48E3A70
        public void add_dataResized(){} // RVA: 0x7FFAF48E3B60
        public void remove_dataResized(){} // RVA: 0x7FFAF48E3D30
        public void OnDataGenerated(){} // RVA: 0x7FFAF48E3E40
        public void OnDataResized(){} // RVA: 0x7FFAF48E3E60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DepthkitLookEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
        public void BeginInvoke(){} // RVA: 0x7FFAF2DEBA60
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class GaussianBlurFilter
    {
        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x7FFAF48EEC10
        public void get_texture(){} // RVA: 0x7FFAF48EEC20
        public void CreateTextures(){} // RVA: 0x7FFAF48EEC50
        public void Setup(){} // RVA: 0x7FFAF48EF140
        public void EnsureTextures(){} // RVA: 0x7FFAF48EF220
        public void DoBlur(){} // RVA: 0x7FFAF48EF490
        public void BlurPass(){} // RVA: 0x7FFAF48EF630
        public void Release(){} // RVA: 0x7FFAF48EFC30
        public void .ctor(){} // RVA: 0x7FFAF48EFDB0
        public void .cctor(){} // RVA: 0x7FFAF48EFDD0
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7FFAF2ADDC60 | overloaded x3
    }

    public class IndexedCoreTriangleSubMesh
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48DF120
    }

    public class Info
    {
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7FFAF48F0900
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF48F0D30
    }

    public class Look
    {
        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7FFAF48EA3D0
        public void get_materialPropertyBlock(){} // RVA: 0x7FFAF48EA4E0
        public void GetLookName(){} // RVA: 0x7FFAF2ABCD60
        public void UsesMaterial(){} // RVA: 0x7FFAF2ABDBE0
        public void GetMaterial(){} // RVA: 0x7FFAF2ABCD60
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFAF2E72850
        public void GetMaterialPropertyBlock(){} // RVA: 0x7FFAF48EA4E0
        public void SetDataSources(){} // RVA: 0x7FFAF2AD4A50
        public void ValidateDataSources(){} // RVA: 0x7FFAF48EA500
        public void SetMaterialProperties(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnUpdate(){} // RVA: 0x7FFAF35950F0
        public void SetDefaults(){} // RVA: 0x7FFAF48EA5D0
        public void SetLookProperties(){} // RVA: 0x7FFAF48EA670
        public void Awake(){} // RVA: 0x7FFAF48EAF30
        public void Init(){} // RVA: 0x7FFAF48EB160
        public void Start(){} // RVA: 0x7FFAF48EB4A0
        public void OnEnable(){} // RVA: 0x7FFAF48EB4D0
        public void OnDisable(){} // RVA: 0x7FFAF48EB600
        public void SyncColliderToBounds(){} // RVA: 0x7FFAF48EB810
        public void OnMetaDataUpdated(){} // RVA: 0x7FFAF48EBBE0
        public void LateUpdate(){} // RVA: 0x7FFAF48EBBF0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class MaskGenerator
    {
        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x7FFAF2E2E0E0
        public void set_perspectivesToSlice(){} // RVA: 0x7FFAF2EE54D0
        public void get_sliceToPerspective(){} // RVA: 0x7FFAF2E55500
        public void set_sliceToPerspective(){} // RVA: 0x7FFAF2E55510
        public void get_sliceCount(){} // RVA: 0x7FFAF48E3E80
        public void set_sliceCount(){} // RVA: 0x7FFAF48E3EA0
        public void get_blurRadius(){} // RVA: 0x7FFAF48E3EB0
        public void set_blurRadius(){} // RVA: 0x7FFAF48E3ED0
        public void get_paddedUVScaleFactor(){} // RVA: 0x7FFAF48E3EF0
        public void get_maskTexture(){} // RVA: 0x7FFAF48E40F0
        public void get_downScale(){} // RVA: 0x7FFAF470A600
        public void set_downScale(){} // RVA: 0x7FFAF48E4140
        public void get_downScaledMaskTexture(){} // RVA: 0x7FFAF48E41C0
        public void DownScalePass(){} // RVA: 0x7FFAF48E4230
        public void DownScaleMaskTexture(){} // RVA: 0x7FFAF48E43D0
        public void Setup(){} // RVA: 0x7FFAF48E5190
        public void EnsureTexture(){} // RVA: 0x7FFAF48E56E0
        public void Release(){} // RVA: 0x7FFAF48E59C0
        public void SobelFilterMask(){} // RVA: 0x7FFAF48E5B70
        public void BlurMask(){} // RVA: 0x7FFAF48E5F60
        public void GenerateMask(){} // RVA: 0x7FFAF48E5FA0
        public void SetProperties(){} // RVA: 0x7FFAF48E67A0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF48E6BE0
    }

    public class MeshSource
    {
        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void CurrentSubMesh(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void ReserveSubMeshes(){} // RVA: 0x7FFAF2AD4FA0
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFAF4741460
        public void set_currentSubmeshIndex(){} // RVA: 0x7FFAF4741470
        public void get_triangleBuffer(){} // RVA: 0x7FFAF48E73F0
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7FFAF48E7440
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7FFAF48E7490
        public void get_maxSurfaceTriangles(){} // RVA: 0x7FFAF48E74E0
        public void set_maxSurfaceTriangles(){} // RVA: 0x7FFAF48E7530
        public void get_useTriangleMesh(){} // RVA: 0x7FFAF2E09320
        public void set_useTriangleMesh(){} // RVA: 0x7FFAF48E7590
        public void get_triangleMesh(){} // RVA: 0x7FFAF48E75F0
        public void EnsureRadialBias(){} // RVA: 0x7FFAF48E7630
        public void AcquireResources(){} // RVA: 0x7FFAF48E78E0
        public void FreeResources(){} // RVA: 0x7FFAF48E79A0
        public void CanGenerate(){} // RVA: 0x7FFAF48E7A10
        public void OnSetup(){} // RVA: 0x7FFAF48E7B10
        public void OnResize(){} // RVA: 0x7FFAF48E7C60
        public void OnUpdate(){} // RVA: 0x7FFAF48E7F10
        public void OnGenerate(){} // RVA: 0x7FFAF48E80E0
        public void GetLocalBounds(){} // RVA: 0x7FFAF48E83A0
        public void GetWorldBounds(){} // RVA: 0x7FFAF48E8570
        public void Pause(){} // RVA: 0x7FFAF48E88B0
        public void Continue(){} // RVA: 0x7FFAF48E8940
        public void OnBecameVisible(){} // RVA: 0x7FFAF48E89E0
        public void OnBecameInvisible(){} // RVA: 0x7FFAF48E8A00
        public void CheckVisibility(){} // RVA: 0x7FFAF48E8A20
        public void SetProperties(){} // RVA: 0x7FFAF48E8C90 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF48E8DA0
    }

    public class Metadata
    {
        // ── Methods ──
        public void Valid(){} // RVA: 0x7FFAF48F0D80
        public void get_perspectiveCPPResolution(){} // RVA: 0x7FFAF48F0DA0
        public void get_perspectiveResolution(){} // RVA: 0x7FFAF48F0E10
        public void get_paddedTextureDimensions(){} // RVA: 0x7FFAF48F0E90
        public void FromSinglePerspective(){} // RVA: 0x7FFAF48F0F10
        public void CreateFromJSON(){} // RVA: 0x7FFAF48F11E0
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7FFAF48F1DD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF48F2170
    }

    public class PackedCoreTriangleSubMesh
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48DF0F0
    }

    public class PerspectiveColorBlending
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF4901BD0
    }

    public class PerspectiveColorBlendingData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4901D00
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7FFAF4901FC0
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7FFAF4902000
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFAF49020C0
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7FFAF4902100
        public void GetEdgeMaskStrength(){} // RVA: 0x7FFAF49021C0
        public void SetEdgeMaskStrength(){} // RVA: 0x7FFAF4902200
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFAF49022C0
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7FFAF4902300
        public void GetEdgeMaskEnabled(){} // RVA: 0x7FFAF49023C0
        public void SetEdgeMaskEnabled(){} // RVA: 0x7FFAF4902410
        public void GetPerspectiveEnabled(){} // RVA: 0x7FFAF49024C0
        public void SetPerspectiveEnabled(){} // RVA: 0x7FFAF4902500
    }

    public class PerspectiveGeometry
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF49025A0
    }

    public class PerspectiveGeometryData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF49026D0
        public void EnableGeometry(){} // RVA: 0x7FFAF4902AB0 | overloaded x2
        public void GetOverrideWeightUnknown(){} // RVA: 0x7FFAF4902B50
        public void SetOverrideWeightUnknown(){} // RVA: 0x7FFAF4902B90
        public void GetWeightUnknown(){} // RVA: 0x7FFAF49020C0
        public void SetWeightUnknown(){} // RVA: 0x7FFAF4902C30
        public void MatchViewDependentColorWeight(){} // RVA: 0x7FFAF4902D20 | overloaded x2
        public void GetViewDependentContribution(){} // RVA: 0x7FFAF4902D50
        public void SetViewDependentContribution(){} // RVA: 0x7FFAF4902D80
        public void GetViewDependentWeight(){} // RVA: 0x7FFAF4901FC0
        public void SetViewDependentWeight(){} // RVA: 0x7FFAF4902DD0
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7FFAF49021C0
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7FFAF4902E90
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7FFAF49022C0
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7FFAF4902F50
    }

    public class PlatformValidator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF48F22D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class PlayerEvents
    {
        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x7FFAF48EC750
        public void remove_playbackStarted(){} // RVA: 0x7FFAF48EC840
        public void add_playbackPaused(){} // RVA: 0x7FFAF48EC930
        public void remove_playbackPaused(){} // RVA: 0x7FFAF48ECA20
        public void add_playbackStopped(){} // RVA: 0x7FFAF48ECB10
        public void remove_playbackStopped(){} // RVA: 0x7FFAF48ECC00
        public void add_loadingStarted(){} // RVA: 0x7FFAF48ECCF0
        public void remove_loadingStarted(){} // RVA: 0x7FFAF48ECDE0
        public void add_loadingFinished(){} // RVA: 0x7FFAF48ECED0
        public void remove_loadingFinished(){} // RVA: 0x7FFAF48ECFC0
        public void OnClipPlaybackStarted(){} // RVA: 0x7FFAF48E3E40
        public void OnClipPlaybackPaused(){} // RVA: 0x7FFAF48E3E60
        public void OnClipPlaybackStopped(){} // RVA: 0x7FFAF48DB0B0
        public void OnClipLoadingStarted(){} // RVA: 0x7FFAF48DB0F0
        public void OnClipLoadingFinished(){} // RVA: 0x7FFAF48DB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ProceduralLook
    {
        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x7FFAF2E72850
        public void GetMaterial(){} // RVA: 0x7FFAF2E08D50
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7FFAF2E72850
        public void SetMaterialProperties(){} // RVA: 0x7FFAF48EBEE0
        public void OnUpdate(){} // RVA: 0x7FFAF48EC380
        public void .ctor(){} // RVA: 0x7FFAF48EA380
    }

    public class SetCaptureFrameRate
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF48F24D0
        public void Update(){} // RVA: 0x7FFAF48F24E0
        public void LateUpdate(){} // RVA: 0x7FFAF48F2500
        public void .ctor(){} // RVA: 0x7FFAF48F2520
    }

    public class StudioLiteLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAF4905010
        public void GetLookName(){} // RVA: 0x7FFAF4905CC0
        public void SetDefaults(){} // RVA: 0x7FFAF4905D00
        public void SetDataSources(){} // RVA: 0x7FFAF4906460
        public void OnUpdate(){} // RVA: 0x7FFAF49065B0
        public void .ctor(){} // RVA: 0x7FFAF4906900
    }

    public class StudioLiteMeshSource
    {
        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x7FFAF4903180
        public void GetKernelNamePostfix(){} // RVA: 0x7FFAF49031C0
        public void GenerateTriangles(){} // RVA: 0x7FFAF49032D0
        public void DataSourceName(){} // RVA: 0x7FFAF49039C0
        public void OnResize(){} // RVA: 0x7FFAF4903A00
        public void GenerateEdgeMask(){} // RVA: 0x7FFAF4903D10
        public void OnGenerate(){} // RVA: 0x7FFAF4903E00
        public void .ctor(){} // RVA: 0x7FFAF4904E50
    }

    public class StudioLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFAF4901630
        public void GetLookName(){} // RVA: 0x7FFAF4901910
        public void SetDataSources(){} // RVA: 0x7FFAF4901950
        public void SetDefaults(){} // RVA: 0x7FFAF4901AA0
        public void .ctor(){} // RVA: 0x7FFAF48EA380
    }

    public class StudioMeshSource
    {
        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7FFAF48F8590
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7FFAF47C2470
        public void get_volumeBounds(){} // RVA: 0x7FFAF2FB76F0
        public void set_volumeBounds(){} // RVA: 0x7FFAF48F8610
        public void GetLocalBounds(){} // RVA: 0x7FFAF2FB76F0
        public void get_volumeDensity(){} // RVA: 0x7FFAF48F8700
        public void set_volumeDensity(){} // RVA: 0x7FFAF48F8710
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7FFAF3E7BAD0
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7FFAF3E87860
        public void set_useTextureAtlas(){} // RVA: 0x7FFAF3540560
        public void DataSourceName(){} // RVA: 0x7FFAF48F8720
        public void GetScaledKernelName(){} // RVA: 0x7FFAF48F8760
        public void GetExtractVolumeKernelName(){} // RVA: 0x7FFAF48F8990
        public void OnAwake(){} // RVA: 0x7FFAF48F8B60
        public void OnSetup(){} // RVA: 0x7FFAF48F8CF0
        public void ResetGPUResources(){} // RVA: 0x7FFAF48F93E0
        public void AcquireResources(){} // RVA: 0x7FFAF48F9440
        public void FreeResources(){} // RVA: 0x7FFAF48F96D0
        public void EnsureBuffers(){} // RVA: 0x7FFAF48F9B10
        public void EnsureTextures(){} // RVA: 0x7FFAF48F9CD0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7FFAF2D33FA0
        public void EnsureSyncedBuffers(){} // RVA: 0x7FFAF48F9F60
        public void SetupViewDependence(){} // RVA: 0x7FFAF48FA1C0
        public void OnNewMetadata(){} // RVA: 0x7FFAF48FA820
        public void ResetVolumeBounds(){} // RVA: 0x7FFAF48FAA10
        public void ResetSurfaceSensitivity(){} // RVA: 0x7FFAF48FAA90
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7FFAF48FAB50
        public void OnResize(){} // RVA: 0x7FFAF48FAB90
        public void SetProperties(){} // RVA: 0x7FFAF48FBA40 | overloaded x3
        public void SetCommonComputeProperties(){} // RVA: 0x7FFAF48FBD30
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7FFAF48FC310
        public void FilterSdf(){} // RVA: 0x7FFAF48FC6B0
        public void GenerateNormalWeights(){} // RVA: 0x7FFAF48FCDE0
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7FFAF48FD020
        public void GenerateEdgeBlendMask(){} // RVA: 0x7FFAF48FD310
        public void DispatchSize(){} // RVA: 0x7FFAF48FD390
        public void GenerateVolumePass(){} // RVA: 0x7FFAF48FD430
        public void GenerateVolume(){} // RVA: 0x7FFAF48FD4D0
        public void ActivePerspectives(){} // RVA: 0x7FFAF48FD5F0
        public void GenerateVolumeMultiPass(){} // RVA: 0x7FFAF48FD6F0
        public void GenerateVolumeSinglePass(){} // RVA: 0x7FFAF48FDCB0
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7FFAF48FDE80
        public void DrawDebug(){} // RVA: 0x7FFAF48FE2F0
        public void OnGenerate(){} // RVA: 0x7FFAF48FEB00
        public void OnUpdate(){} // RVA: 0x7FFAF48FF060
        public void EnsureMaskGenerator(){} // RVA: 0x7FFAF48FF920
        public void get_enableEdgeMask(){} // RVA: 0x7FFAF48FFBC0
        public void set_enableEdgeMask(){} // RVA: 0x7FFAF48FFBE0
        public void .ctor(){} // RVA: 0x7FFAF48FFBF0
        public void .cctor(){} // RVA: 0x7FFAF48FFE20
    }

    public class SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAF2ABD840
        public void get_triangleBuffer(){} // RVA: 0x7FFAF2D907C0
        public void get_trianglesCount(){} // RVA: 0x7FFAF2DBB0C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7FFAF2DBB130
        public void get_drawIndirectArgs(){} // RVA: 0x7FFAF30E74D0
        public void Init(){} // RVA: 0x7FFAF48E8F10
        public void CopyTriangleCount(){} // RVA: 0x7FFAF48E8FC0
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7FFAF48E9030
        public void PrepareDrawArgs(){} // RVA: 0x7FFAF48E90E0
        public void PrepareDispatchArgs(){} // RVA: 0x7FFAF48E9160
        public void EnsureBuffers(){} // RVA: 0x7FFAF48E9200
        public void Release(){} // RVA: 0x7FFAF48E95E0
        public void set_source(){} // RVA: 0x7FFAF2F4B830
        public void get_triangleMesh(){} // RVA: 0x7FFAF48E9790
        public void SetProperties(){} // RVA: 0x7FFAF48E9AC0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SubMesh`1
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAF2ABD840
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SubMesh`1
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAF6B68870
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SubMesh`1
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7FFAF6B68790
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SyncedStructuredBuffer`1
    {
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADC800
        public void get_Length(){} // RVA: 0x7FFAF2ABD840
        public void MarkDirty(){} // RVA: 0x7FFAF2AD4A50
        public void Sync(){} // RVA: 0x7FFAF2ABDBE0
        public void Release(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B75220
        public void get_Length(){} // RVA: 0x7FFAF6B75390
        public void MarkDirty(){} // RVA: 0x7FFAF3D32B00
        public void Sync(){} // RVA: 0x7FFAF6B755E0
        public void Release(){} // RVA: 0x7FFAF6B75550
    }

    public class SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B75220
        public void get_Length(){} // RVA: 0x7FFAF6B75390
        public void MarkDirty(){} // RVA: 0x7FFAF3D32B00
        public void Sync(){} // RVA: 0x7FFAF6B753B0
        public void Release(){} // RVA: 0x7FFAF6B75550
    }

    public class SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B75220
        public void get_Length(){} // RVA: 0x7FFAF6B75390
        public void MarkDirty(){} // RVA: 0x7FFAF3D32B00
        public void Sync(){} // RVA: 0x7FFAF6B75AC0
        public void Release(){} // RVA: 0x7FFAF6B75550
    }

    public class TriangleMesh
    {
        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x7FFAF3210030
        public void set_TriangleCount(){} // RVA: 0x7FFAF48F2570
        public void get_mesh(){} // RVA: 0x7FFAF48F2580
        public void EnsureTriangleMesh(){} // RVA: 0x7FFAF48F2E70 | overloaded x3
        public void CreateMesh(){} // RVA: 0x7FFAF48F3280
        public void ReleaseMesh(){} // RVA: 0x7FFAF48F3340
        public void GetCubeVerts(){} // RVA: 0x7FFAF48F34B0
        public void GetCubeTriangles(){} // RVA: 0x7FFAF48F3680
        public void ResetMeshCube(){} // RVA: 0x7FFAF48F3790
        public void CreateLattice(){} // RVA: 0x7FFAF48F3A90
        public void addVertex(){} // RVA: 0x7FFAF48F3F00
        public void CreateTriangleLattice(){} // RVA: 0x7FFAF48F4090
        public void CreateCubeMesh(){} // RVA: 0x7FFAF48F44F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnityVideoPlayer
    {
        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x7FFAF48ED0B0
        public void IsPlayerCreated(){} // RVA: 0x7FFAF48ED6E0
        public void IsPlayerSetup(){} // RVA: 0x7FFAF48ED7B0
        public void SetVideoPath(){} // RVA: 0x7FFAF48EDA40
        public void GetVideoPath(){} // RVA: 0x7FFAF48EDAD0
        public void StartVideoLoad(){} // RVA: 0x7FFAF48EDC90
        public void Load(){} // RVA: 0x7FFAF48EDCC0
        public void OnVideoLoadingComplete(){} // RVA: 0x7FFAF48EDD60
        public void OnMetadataUpdated(){} // RVA: 0x7FFAF2D8D310
        public void LoadAndPlay(){} // RVA: 0x7FFAF48EDD90
        public void Play(){} // RVA: 0x7FFAF48EDE30
        public void Pause(){} // RVA: 0x7FFAF48EDEC0
        public void Stop(){} // RVA: 0x7FFAF48EDF50
        public void GetCurrentFrame(){} // RVA: 0x7FFAF48EDFE0
        public void GetCurrentTime(){} // RVA: 0x7FFAF48EE040
        public void GetDuration(){} // RVA: 0x7FFAF48EE0A0
        public void GetTexture(){} // RVA: 0x7FFAF48EE150
        public void IsTextureFlipped(){} // RVA: 0x7FFAF2D8D320
        public void GammaCorrectDepth(){} // RVA: 0x7FFAF48EE1B0
        public void GammaCorrectColor(){} // RVA: 0x7FFAF48EE200
        public void IsPlaying(){} // RVA: 0x7FFAF48EE250
        public void RemoveComponents(){} // RVA: 0x7FFAF48EE2B0
        public void GetPlayerTypeName(){} // RVA: 0x7FFAF48EE480
        public void GetPlayerPrettyName(){} // RVA: 0x7FFAF48EE550
        public void GetPlayerBackend(){} // RVA: 0x7FFAF30E74D0
        public void Seek(){} // RVA: 0x7FFAF48EE590
        public void GetVideoWidth(){} // RVA: 0x7FFAF48EE690
        public void GetVideoHeight(){} // RVA: 0x7FFAF48EE7C0
        public void SupportsPosterFrame(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF48EC680
    }

    public class Util
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7FFAF48F4B10
        public void GetScaled2DKernelName(){} // RVA: 0x7FFAF48F4B30
        public void GetScaled3DKernelName(){} // RVA: 0x7FFAF48F4D60
        public void DispatchGroups(){} // RVA: 0x7FFAF48F4EE0
        public void ClearRenderTexture(){} // RVA: 0x7FFAF48F5040
        public void ClearAppendBuffer(){} // RVA: 0x7FFAF48F5240
        public void ReleaseComputeBuffer(){} // RVA: 0x7FFAF48F54B0
        public void ReleaseRenderTexture(){} // RVA: 0x7FFAF48F5520
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7FFAF48F56E0
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7FFAF48F5AD0
        public void TransformBounds(){} // RVA: 0x7FFAF48F5D30
        public void CreateRenderTexture(){} // RVA: 0x7FFAF48F5FD0
        public void EnsureRenderTexture(){} // RVA: 0x7FFAF48F6250
        public void EnsureComputeBuffer(){} // RVA: 0x7FFAF48F67C0
        public void ColorForCamera(){} // RVA: 0x7FFAF48F6A10
        public void RenderPerspectiveGizmo(){} // RVA: 0x7FFAF2D8D310
        public void RenderMetadataGizmos(){} // RVA: 0x7FFAF2D8D310
        public void IsVisible(){} // RVA: 0x7FFAF48F6BD0
        public void metersToCm(){} // RVA: 0x7FFAF48F6E30
        public void cmToMeters(){} // RVA: 0x7FFAF48F6E40
        public void EnsureKeyword(){} // RVA: 0x7FFAF48F6E50
        public void EnsureComputeShader(){} // RVA: 0x7FFAF48F6F50
    }

    public class Version
    {
        // ── Methods ──
        public void get_major(){} // RVA: 0x7FFAF48F0360
        public void set_major(){} // RVA: 0x7FFAF48F0370
        public void get_minor(){} // RVA: 0x7FFAF48F0380
        public void set_minor(){} // RVA: 0x7FFAF3B9EB00
        public void get_patch(){} // RVA: 0x7FFAF48F0390
        public void set_patch(){} // RVA: 0x7FFAF3B9EB20
        public void .ctor(){} // RVA: 0x7FFAF48265C0
        public void ToString(){} // RVA: 0x7FFAF48F03A0
        public void op_Implicit(){} // RVA: 0x7FFAF48F0600
        public void Equals(){} // RVA: 0x7FFAF48F06B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF48F06D0
        public void op_Equality(){} // RVA: 0x7FFAF48F06E0
        public void op_Inequality(){} // RVA: 0x7FFAF48F0710
        public void op_LessThan(){} // RVA: 0x7FFAF48F0740
        public void op_GreaterThan(){} // RVA: 0x7FFAF48F0790
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAF48F07E0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAF48F0870
    }

}