// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 31
// Methods: 500

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        public object m_newMetadata; // 0x30BAB710
        public object m_metadataSourceType; // 0x30BAB710
        public object m_player; // 0x30BAB710
        public object m_poster; // 0x30BAB710
        public object m_doResizeData; // 0x30BAB710
        public object X00;
        public object newMetadata; // 0x31717720
        public object playerEvents; // 0x17000001

        // ── Original Methods ──
        public void add_newFrame(){} // RVA: 0x7ffaaa34fd50
        public void remove_newFrame(){} // RVA: 0x7ffaaa34fe40
        public void add_newPoster(){} // RVA: 0x7ffaaa34ff30
        public void remove_newPoster(){} // RVA: 0x7ffaaa350020
        public void add_m_newMetadata(){} // RVA: 0x7ffaaa350110
        public void remove_m_newMetadata(){} // RVA: 0x7ffaaa350200
        public void add_newMetadata(){} // RVA: 0x7ffaaa3502f0
        public void remove_newMetadata(){} // RVA: 0x7ffaaa3504c0
        public void OnNewFrame(){} // RVA: 0x7ffaaa3505d0
        public void OnNewMetadata(){} // RVA: 0x7ffaaa3505f0
        public void OnNewPoster(){} // RVA: 0x7ffaaa350610
        public void get_playerEvents(){} // RVA: 0x7ffaaa350630
        public void get_metadataFilePath(){} // RVA: 0x7ffaa8bf45b0
        public void set_metadataFilePath(){} // RVA: 0x7ffaaa350760
        public void get_metadataFile(){} // RVA: 0x7ffaa89af740
        public void set_metadataFile(){} // RVA: 0x7ffaaa3509a0
        public void get_metadataSourceType(){} // RVA: 0x7ffaa89d30c0
        public void get_metadata(){} // RVA: 0x7ffaa89d30e0
        public void get_hasMetadata(){} // RVA: 0x7ffaaa350c00
        public void LoadMetadata(){} // RVA: 0x7ffaaa350c30
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7ffaaa350e80
        public void get_perspectiveDataBuffer(){} // RVA: 0x7ffaaa350f60
        public void get_player(){} // RVA: 0x7ffaa89d0370
        public void CreatePlayer(){} // RVA: 0x7ffaaa350f70
        public void get_playerSetup(){} // RVA: 0x7ffaaa351410
        public void get_playerIsActive(){} // RVA: 0x7ffaaa351510
        public void get_width(){} // RVA: 0x7ffaaa3515f0
        public void get_height(){} // RVA: 0x7ffaaa351640
        public void get_gammaCorrectDepth(){} // RVA: 0x7ffaaa351690
        public void get_gammaCorrectColor(){} // RVA: 0x7ffaaa351730
        public void get_cppTexture(){} // RVA: 0x7ffaaa351780
        public void get_textureIsFlipped(){} // RVA: 0x7ffaaa3517e0
        public void get_poster(){} // RVA: 0x7ffaa8af68f0
        public void set_poster(){} // RVA: 0x7ffaaa351830
        public void get_disablePoster(){} // RVA: 0x7ffaa8b680a0
        public void set_disablePoster(){} // RVA: 0x7ffaaa351970
        public void ResetDataSources(){} // RVA: 0x7ffaaa352210
        public void get_isSetup(){} // RVA: 0x7ffaaa353160
        public void OnEnable(){} // RVA: 0x7ffaaa3531a0
        public void OnDisable(){} // RVA: 0x7ffaaa3535b0
        public void Start(){} // RVA: 0x7ffaaa353850
        public void Update(){} // RVA: 0x7ffaaa353960
        public void LateUpdate(){} // RVA: 0x7ffaaa353a20
        public void OnDestroy(){} // RVA: 0x7ffaaa353ac0
        public void OnApplicationQuit(){} // RVA: 0x7ffaaa353d40
        public void .ctor(){} // RVA: 0x7ffaaa353e30
        public void .cctor(){} // RVA: 0x7ffaaa353e80
        // ── Binary Analysis Named ──
        public void SetPlayer(){} // RVA: 0x7ffaaa3511e0
        public void SetPlayer(){} // RVA: 0x7ffaaa3511e0
        public void GetDataSource(){} // RVA: 0x7ffaa887e5c0
        public void DoResize(){} // RVA: 0x7ffaaa351990
        public void DoGenerate(){} // RVA: 0x7ffaaa351d10
        public void SetProperties(){} // RVA: 0x7ffaaa352cf0
        public void SetProperties(){} // RVA: 0x7ffaaa352cf0
        public void SetProperties(){} // RVA: 0x7ffaaa352cf0
    }

    public class ClipPlayer : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_videoLoaded(){} // RVA: 0x7ffaa8a209d0
        public void set_videoLoaded(){} // RVA: 0x7ffaa8a209e0
        public void CreatePlayer(){} // RVA: 0x7ffaa8660cc0
        public void IsPlayerCreated(){} // RVA: 0x7ffaa864a040
        public void IsPlayerSetup(){} // RVA: 0x7ffaa864a040
        public void Load(){} // RVA: 0x7ffaa86491d0
        public void StartVideoLoad(){} // RVA: 0x7ffaa8660cc0
        public void LoadAndPlay(){} // RVA: 0x7ffaa86491d0
        public void OnMetadataUpdated(){} // RVA: 0x7ffaa8660d80
        public void Play(){} // RVA: 0x7ffaa8660cc0
        public void Pause(){} // RVA: 0x7ffaa8660cc0
        public void Stop(){} // RVA: 0x7ffaa8660cc0
        public void RemoveComponents(){} // RVA: 0x7ffaa8660cc0
        public void IsTextureFlipped(){} // RVA: 0x7ffaa864a040
        public void GammaCorrectDepth(){} // RVA: 0x7ffaa8649ca0
        public void GammaCorrectColor(){} // RVA: 0x7ffaa8649ca0
        public void IsPlaying(){} // RVA: 0x7ffaa864a040
        public void Seek(){} // RVA: 0x7ffaa866e7c0
        public void SupportsPosterFrame(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaaa361b90
        // ── Binary Analysis Named ──
        public void SetVideoPath(){} // RVA: 0x7ffaa8660d80
        public void GetVideoPath(){} // RVA: 0x7ffaa86491d0
        public void GetTexture(){} // RVA: 0x7ffaa86491d0
        public void GetPlayerTypeName(){} // RVA: 0x7ffaa86491d0
        public void GetPlayerPrettyName(){} // RVA: 0x7ffaaa361b50
        public void GetCurrentTime(){} // RVA: 0x7ffaa864eea0
        public void GetCurrentFrame(){} // RVA: 0x7ffaa8649ca0
        public void GetDuration(){} // RVA: 0x7ffaa864eea0
        public void GetVideoWidth(){} // RVA: 0x7ffaa8649ca0
        public void GetVideoHeight(){} // RVA: 0x7ffaa8649ca0
    }

    public class CoreLook : ProceduralLook
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa35f890
        // ── Binary Analysis Named ──
        public void GetDefaultMaterial(){} // RVA: 0x7ffaaa35f2f0
        public void GetLookName(){} // RVA: 0x7ffaaa35f5d0
        public void SetDefaults(){} // RVA: 0x7ffaaa35f610
        public void SetDataSources(){} // RVA: 0x7ffaaa35f740
    }

    public class CoreMeshSource : MeshSource
    {
        public object m_latticeResolution; // 0x3390CC60
        public object adjustableNormalSlope; // 0x3390CC60
        public object ditherEdge; // 0x3390CC60
        public object m_vertexBuffer; // 0x3390CC60
        public object maskGenerator; // 0x3390CC60
        public object meshDensity; // 0x17000014
        public object latticeMaxTriangles; // 0x17000015
        public object latticeResolution; // 0x17000016
        public object scaledPerspectiveResolution; // 0x17000017
        public object vertexBuffer; // 0x17000018

        // ── Original Methods ──
        public void get_meshDensity(){} // RVA: 0x7ffaaa354670
        public void set_meshDensity(){} // RVA: 0x7ffaaa354690
        public void get_latticeMaxTriangles(){} // RVA: 0x7ffaaa2a7de0
        public void get_latticeResolution(){} // RVA: 0x7ffaa8f75d20
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7ffaaa354740
        public void ResizeLattice(){} // RVA: 0x7ffaaa3547f0
        public void get_vertexBuffer(){} // RVA: 0x7ffaa899d120
        public void FindKernelId(){} // RVA: 0x7ffaaa354a00
        public void GenerateVertexBuffer(){} // RVA: 0x7ffaaa354c60
        public void GenerateTriangles(){} // RVA: 0x7ffaaa355780
        public void GenerateVertices(){} // RVA: 0x7ffaaa354f10
        public void GenerateNormals(){} // RVA: 0x7ffaaa355440
        public void GenerateTriangles(){} // RVA: 0x7ffaaa355780
        public void DataSourceName(){} // RVA: 0x7ffaaa355bb0
        public void EnsureVertexBuffer(){} // RVA: 0x7ffaaa355bf0
        public void AcquireResources(){} // RVA: 0x7ffaaa355d20
        public void FreeResources(){} // RVA: 0x7ffaaa355ef0
        public void OnSetup(){} // RVA: 0x7ffaaa355f30
        public void baseResize(){} // RVA: 0x7ffaaa355fb0
        public void OnResize(){} // RVA: 0x7ffaaa355fc0
        public void GenerateEdgeMask(){} // RVA: 0x7ffaaa356160
        public void OnGenerate(){} // RVA: 0x7ffaaa356240
        public void EnsureMaskGenerator(){} // RVA: 0x7ffaaa356a40
        public void .ctor(){} // RVA: 0x7ffaaa356c50
        // ── Binary Analysis Named ──
        public void GetComputeShaderName(){} // RVA: 0x7ffaaa354920
        public void GetKernelNamePostfix(){} // RVA: 0x7ffaaa354960
        public void SetProperties(){} // RVA: 0x7ffaaa356880
        public void SetProperties(){} // RVA: 0x7ffaaa356880
        public void SetProperties(){} // RVA: 0x7ffaaa356880
    }

    public class DataSource : MonoBehaviour
    {
        public object m_clip; // 0x30B80AB0
        public object m_doResize; // 0x30B80AB0
        public object X00; // 0x30B80930

        // ── Original Methods ──
        public void get_clip(){} // RVA: 0x7ffaa8bfcc80
        public void get_dataSourceParent(){} // RVA: 0x7ffaa8bf45b0
        public void DataSourceName(){} // RVA: 0x7ffaa86491d0
        public void ResetChildren(){} // RVA: 0x7ffaaa356fc0
        public void AcquireResources(){} // RVA: 0x7ffaa8932310
        public void FreeResources(){} // RVA: 0x7ffaa8932310
        public void OnAwake(){} // RVA: 0x7ffaa8932310
        public void OnCleanup(){} // RVA: 0x7ffaa8932310
        public void OnSetup(){} // RVA: 0x7ffaa864a040
        public void OnResize(){} // RVA: 0x7ffaa864a040
        public void OnGenerate(){} // RVA: 0x7ffaa864a040
        public void OnUpdate(){} // RVA: 0x7ffaa8932310
        public void CanGenerate(){} // RVA: 0x7ffaa8a17850
        public void Awake(){} // RVA: 0x7ffaaa3571f0
        public void Start(){} // RVA: 0x7ffaaa3573b0
        public void ScheduleGenerate(){} // RVA: 0x7ffaa9174f30
        public void ScheduleResize(){} // RVA: 0x7ffaaa3573d0
        public void UnscheduleGenerate(){} // RVA: 0x7ffaa9175100
        public void UnscheduleResize(){} // RVA: 0x7ffaaa3573e0
        public void OnEnable(){} // RVA: 0x7ffaaa3573f0
        public void OnDisable(){} // RVA: 0x7ffaaa357690
        public void Reset(){} // RVA: 0x7ffaa9a28a10
        public void Cleanup(){} // RVA: 0x7ffaaa357bd0
        public void Resize(){} // RVA: 0x7ffaaa357fd0
        public void IsSetup(){} // RVA: 0x7ffaa8b0edb0
        public void Generate(){} // RVA: 0x7ffaaa3583d0
        public void Update(){} // RVA: 0x7ffaaa358800
        public void LateUpdate(){} // RVA: 0x7ffaaa358820
        public void .ctor(){} // RVA: 0x7ffaaa358860
        // ── Binary Analysis Named ──
        public void GetChild(){} // RVA: 0x7ffaa887e5c0
        public void Setup(){} // RVA: 0x7ffaaa357920
    }

    public class DataSourceEvents : Object
    {
        // ── Original Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7ffaaa3589d0
        public void remove_m_dataGenerated(){} // RVA: 0x7ffaaa358ac0
        public void add_dataGenerated(){} // RVA: 0x7ffaaa358bb0
        public void remove_dataGenerated(){} // RVA: 0x7ffaaa358d80
        public void add_m_dataResized(){} // RVA: 0x7ffaaa358e90
        public void remove_m_dataResized(){} // RVA: 0x7ffaaa358f80
        public void add_dataResized(){} // RVA: 0x7ffaaa359070
        public void remove_dataResized(){} // RVA: 0x7ffaaa359240
        public void OnDataGenerated(){} // RVA: 0x7ffaaa359350
        public void OnDataResized(){} // RVA: 0x7ffaaa359370
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class GaussianBlurFilter : Object
    {
        public object slices; // 0x33A4D240
        public object m_currentTexture; // 0x33A4D240
        public object m_pongSize; // 0x33A4D240
        public object hasTexture; // 0x17000036
        public object texture; // 0x17000037

        // ── Original Methods ──
        public void get_hasTexture(){} // RVA: 0x7ffaaa364120
        public void get_texture(){} // RVA: 0x7ffaaa364130
        public void CreateTextures(){} // RVA: 0x7ffaaa364160
        public void EnsureTextures(){} // RVA: 0x7ffaaa364730
        public void BlurPass(){} // RVA: 0x7ffaaa364b40
        public void Release(){} // RVA: 0x7ffaaa365140
        public void .ctor(){} // RVA: 0x7ffaaa3652c0
        public void .cctor(){} // RVA: 0x7ffaaa3652e0
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaaa364650
        public void DoBlur(){} // RVA: 0x7ffaaa3649a0
    }

    public class IPropertyTransfer
    {
        // ── Binary Analysis Named ──
        public void SetProperties(){} // RVA: 0x7ffaa8669e70
        public void SetProperties(){} // RVA: 0x7ffaa8669e70
        public void SetProperties(){} // RVA: 0x7ffaa8669e70
    }

    public class Info : Object
    {
        // ── Original Methods ──
        public void IsPlatformValid(){} // RVA: 0x7ffaaa365e20
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaa366250
    }

    public class Look : MonoBehaviour
    {
        public object showCameraFrustums; // 0x33392C30
        public object meshSource; // 0x33392C30
        public object X00; // 0x40000B3

        // ── Original Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7ffaaa35f8e0
        public void get_materialPropertyBlock(){} // RVA: 0x7ffaaa35f9f0
        public void UsesMaterial(){} // RVA: 0x7ffaa864a040
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7ffaa8a17850
        public void ValidateDataSources(){} // RVA: 0x7ffaaa35fa10
        public void OnUpdate(){} // RVA: 0x7ffaa9134e10
        public void Awake(){} // RVA: 0x7ffaaa360440
        public void Init(){} // RVA: 0x7ffaaa360670
        public void Start(){} // RVA: 0x7ffaaa3609b0
        public void OnEnable(){} // RVA: 0x7ffaaa3609e0
        public void OnDisable(){} // RVA: 0x7ffaaa360b10
        public void SyncColliderToBounds(){} // RVA: 0x7ffaaa360d20
        public void OnMetaDataUpdated(){} // RVA: 0x7ffaaa3610f0
        public void LateUpdate(){} // RVA: 0x7ffaaa361100
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetLookName(){} // RVA: 0x7ffaa86491d0
        public void GetMaterial(){} // RVA: 0x7ffaa86491d0
        public void GetMaterialPropertyBlock(){} // RVA: 0x7ffaaa35f9f0
        public void SetDataSources(){} // RVA: 0x7ffaa8660cc0
        public void SetMaterialProperties(){} // RVA: 0x7ffaa8932310
        public void SetMaterialProperties(){} // RVA: 0x7ffaa8932310
        public void SetDefaults(){} // RVA: 0x7ffaaa35fae0
        public void SetLookProperties(){} // RVA: 0x7ffaaa35fb80
    }

    public class MaskGenerator : Object
    {
        public object invalidateEdgeWidth; // 0x339B6200
        public object m_maskTextureFormat; // 0x339B6200
        public object m_perspectivesToSlice; // 0x339B6200
        public object enableMaskDebug; // 0x339B6200
        public object m_sobelFilterCompute; // 0x339B6200
        public object m_downScaleCompute; // 0x339B6200

        // ── Original Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x7ffaa89d30e0
        public void set_perspectivesToSlice(){} // RVA: 0x7ffaa8a8a4d0
        public void get_sliceToPerspective(){} // RVA: 0x7ffaa89fa500
        public void set_sliceToPerspective(){} // RVA: 0x7ffaa89fa510
        public void get_sliceCount(){} // RVA: 0x7ffaaa359390
        public void set_sliceCount(){} // RVA: 0x7ffaaa3593b0
        public void get_blurRadius(){} // RVA: 0x7ffaaa3593c0
        public void set_blurRadius(){} // RVA: 0x7ffaaa3593e0
        public void get_paddedUVScaleFactor(){} // RVA: 0x7ffaaa359400
        public void get_maskTexture(){} // RVA: 0x7ffaaa359600
        public void get_downScale(){} // RVA: 0x7ffaaa0f8ab0
        public void set_downScale(){} // RVA: 0x7ffaaa359650
        public void get_downScaledMaskTexture(){} // RVA: 0x7ffaaa3596d0
        public void EnsureTexture(){} // RVA: 0x7ffaaa35abf0
        public void Release(){} // RVA: 0x7ffaaa35aed0
        public void SobelFilterMask(){} // RVA: 0x7ffaaa35b080
        public void BlurMask(){} // RVA: 0x7ffaaa35b470
        public void GenerateMask(){} // RVA: 0x7ffaaa35b4b0
        public void .ctor(){} // RVA: 0x7ffaaa35c0f0
        // ── Binary Analysis Named ──
        public void DownScalePass(){} // RVA: 0x7ffaaa359740
        public void DownScaleMaskTexture(){} // RVA: 0x7ffaaa3598e0
        public void Setup(){} // RVA: 0x7ffaaa35a6a0
        public void SetProperties(){} // RVA: 0x7ffaaa35bcb0
        public void SetProperties(){} // RVA: 0x7ffaaa35bcb0
        public void SetProperties(){} // RVA: 0x7ffaaa35bcb0
    }

    public class MeshSource : DataSource
    {
        public object m_subMeshMaxTriangles; // 0x30BB0630
        public object m_useTriangleMesh; // 0x30BB0630
        public object radialBiasDefault; // 0x30BB0630
        public object radialBiasPerspInMeters; // 0x30BB0630
        public object m_wasPlaying; // 0x30BB0630
        public object m_seenOnce; // 0x30BB0630
        public object currentSubmeshIndex; // 0x17000023
        public object triangleBuffer; // 0x17000024
        public object triangleBufferDispatchIndirectArgs; // 0x17000025
        public object triangleBufferDrawIndirectArgs; // 0x17000026
        public object maxSurfaceTriangles; // 0x17000027
        public object useTriangleMesh; // 0x17000028

        // ── Original Methods ──
        public void CurrentSubMesh(){} // RVA: 0x7ffaa887e5c0
        public void CurrentSubMesh(){} // RVA: 0x7ffaa887e5c0
        public void ReserveSubMeshes(){} // RVA: 0x7ffaa8661210
        public void get_currentSubmeshIndex(){} // RVA: 0x7ffaaa1c2a60
        public void set_currentSubmeshIndex(){} // RVA: 0x7ffaaa1c2a70
        public void get_triangleBuffer(){} // RVA: 0x7ffaaa35c900
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7ffaaa35c950
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7ffaaa35c9a0
        public void get_maxSurfaceTriangles(){} // RVA: 0x7ffaaa35c9f0
        public void set_maxSurfaceTriangles(){} // RVA: 0x7ffaaa35ca40
        public void get_useTriangleMesh(){} // RVA: 0x7ffaa89ae320
        public void set_useTriangleMesh(){} // RVA: 0x7ffaaa35caa0
        public void get_triangleMesh(){} // RVA: 0x7ffaaa35cb00
        public void EnsureRadialBias(){} // RVA: 0x7ffaaa35cb40
        public void AcquireResources(){} // RVA: 0x7ffaaa35cdf0
        public void FreeResources(){} // RVA: 0x7ffaaa35ceb0
        public void CanGenerate(){} // RVA: 0x7ffaaa35cf20
        public void OnSetup(){} // RVA: 0x7ffaaa35d020
        public void OnResize(){} // RVA: 0x7ffaaa35d170
        public void OnUpdate(){} // RVA: 0x7ffaaa35d420
        public void OnGenerate(){} // RVA: 0x7ffaaa35d5f0
        public void Pause(){} // RVA: 0x7ffaaa35ddc0
        public void Continue(){} // RVA: 0x7ffaaa35de50
        public void OnBecameVisible(){} // RVA: 0x7ffaaa35def0
        public void OnBecameInvisible(){} // RVA: 0x7ffaaa35df10
        public void .ctor(){} // RVA: 0x7ffaaa35e2b0
        // ── Binary Analysis Named ──
        public void GetSubMesh(){} // RVA: 0x7ffaa887e5c0
        public void GetSubMesh(){} // RVA: 0x7ffaa887e5c0
        public void GetLocalBounds(){} // RVA: 0x7ffaaa35d8b0
        public void GetWorldBounds(){} // RVA: 0x7ffaaa35da80
        public void CheckVisibility(){} // RVA: 0x7ffaaa35df30
        public void SetProperties(){} // RVA: 0x7ffaaa35e1a0
        public void SetProperties(){} // RVA: 0x7ffaaa35e1a0
        public void SetProperties(){} // RVA: 0x7ffaaa35e1a0
    }

    public class Metadata : Object
    {
        public object eps; // 0x3395E070
        public object format; // 0x3395E070
        public object boundsCenter; // 0x3395E070
        public object perspectivesCount; // 0x3395E070
        public object numAngles; // 0x3395E070
        public object perspectiveCPPResolution; // 0x1700003B
        public object perspectiveResolution; // 0x1700003C
        public object paddedTextureDimensions; // 0x1700003D

        // ── Original Methods ──
        public void Valid(){} // RVA: 0x7ffaaa3662a0
        public void get_perspectiveCPPResolution(){} // RVA: 0x7ffaaa3662c0
        public void get_perspectiveResolution(){} // RVA: 0x7ffaaa366330
        public void get_paddedTextureDimensions(){} // RVA: 0x7ffaaa3663b0
        public void FromSinglePerspective(){} // RVA: 0x7ffaaa366430
        public void CreateFromJSON(){} // RVA: 0x7ffaaa366700
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7ffaaa3672f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaa367690
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa377260
        // ── Binary Analysis Named ──
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7ffaaa377520
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7ffaaa377560
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7ffaaa377620
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7ffaaa377660
        public void GetEdgeMaskStrength(){} // RVA: 0x7ffaaa377720
        public void SetEdgeMaskStrength(){} // RVA: 0x7ffaaa377760
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7ffaaa377820
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7ffaaa377860
        public void GetEdgeMaskEnabled(){} // RVA: 0x7ffaaa377920
        public void SetEdgeMaskEnabled(){} // RVA: 0x7ffaaa377970
        public void GetPerspectiveEnabled(){} // RVA: 0x7ffaaa377a20
        public void SetPerspectiveEnabled(){} // RVA: 0x7ffaaa377a60
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa377c30
        public void EnableGeometry(){} // RVA: 0x7ffaaa378010
        public void EnableGeometry(){} // RVA: 0x7ffaaa378010
        public void MatchViewDependentColorWeight(){} // RVA: 0x7ffaaa378280
        public void MatchViewDependentColorWeight(){} // RVA: 0x7ffaaa378280
        // ── Binary Analysis Named ──
        public void GetOverrideWeightUnknown(){} // RVA: 0x7ffaaa3780b0
        public void SetOverrideWeightUnknown(){} // RVA: 0x7ffaaa3780f0
        public void GetWeightUnknown(){} // RVA: 0x7ffaaa377620
        public void SetWeightUnknown(){} // RVA: 0x7ffaaa378190
        public void GetViewDependentContribution(){} // RVA: 0x7ffaaa3782b0
        public void SetViewDependentContribution(){} // RVA: 0x7ffaaa3782e0
        public void GetViewDependentWeight(){} // RVA: 0x7ffaaa377520
        public void SetViewDependentWeight(){} // RVA: 0x7ffaaa378330
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7ffaaa377720
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7ffaaa3783f0
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7ffaaa377820
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7ffaaa3784b0
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaa3677f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PlayerEvents : Object
    {
        public object playbackStopped; // 0x339FEBE0
        public object X00;

        // ── Original Methods ──
        public void add_playbackStarted(){} // RVA: 0x7ffaaa361c60
        public void remove_playbackStarted(){} // RVA: 0x7ffaaa361d50
        public void add_playbackPaused(){} // RVA: 0x7ffaaa361e40
        public void remove_playbackPaused(){} // RVA: 0x7ffaaa361f30
        public void add_playbackStopped(){} // RVA: 0x7ffaaa362020
        public void remove_playbackStopped(){} // RVA: 0x7ffaaa362110
        public void add_loadingStarted(){} // RVA: 0x7ffaaa362200
        public void remove_loadingStarted(){} // RVA: 0x7ffaaa3622f0
        public void add_loadingFinished(){} // RVA: 0x7ffaaa3623e0
        public void remove_loadingFinished(){} // RVA: 0x7ffaaa3624d0
        public void OnClipPlaybackStarted(){} // RVA: 0x7ffaaa359350
        public void OnClipPlaybackPaused(){} // RVA: 0x7ffaaa359370
        public void OnClipPlaybackStopped(){} // RVA: 0x7ffaaa3505d0
        public void OnClipLoadingStarted(){} // RVA: 0x7ffaaa350610
        public void OnClipLoadingFinished(){} // RVA: 0x7ffaaa3505f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ProceduralLook : Look
    {
        public object interpolateLightProbes; // 0x333929D0
        public object s_defaultUnlitPhotoLookShader; // 0x33392770

        // ── Original Methods ──
        public void UsesMaterial(){} // RVA: 0x7ffaa8a17850
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7ffaa8a17850
        public void OnUpdate(){} // RVA: 0x7ffaaa361890
        public void .ctor(){} // RVA: 0x7ffaaa35f890
        // ── Binary Analysis Named ──
        public void GetMaterial(){} // RVA: 0x7ffaa89add50
        public void SetMaterialProperties(){} // RVA: 0x7ffaaa3613f0
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        public object captureFramteRate; // 0x33AA5350

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaa3679f0
        public void Update(){} // RVA: 0x7ffaaa367a00
        public void LateUpdate(){} // RVA: 0x7ffaaa367a20
        public void .ctor(){} // RVA: 0x7ffaaa367a40
    }

    public class StudioLiteLook : ProceduralLook
    {
        public object s_defaultMainShader; // 0x336851A0
        public object s_defaultMainEdgeStencilMaterial; // 0x336851A0
        public object s_defaultFillShader; // 0x336851A0
        public object s_defaultFillEdgeMaterial; // 0x336851A0
        public object mainPerspective; // 0x336851A0
        public object fillPerspectivesEdges; // 0x336851A0
        public object showFill; // 0x336851A0
        public object X00; // 0xE
        public object enableAdaptiveThreshold; // 0x3390C980
        public object minDitherWidth; // 0x3390C980
        public object `00; // 0x4000001

        // ── Original Methods ──
        public void OnUpdate(){} // RVA: 0x7ffaaa37bb10
        public void .ctor(){} // RVA: 0x7ffaaa37be60
        // ── Binary Analysis Named ──
        public void GetDefaultMaterial(){} // RVA: 0x7ffaaa37a570
        public void GetLookName(){} // RVA: 0x7ffaaa37b220
        public void SetDefaults(){} // RVA: 0x7ffaaa37b260
        public void SetDataSources(){} // RVA: 0x7ffaaa37b9c0
    }

    public class StudioLiteMeshSource : CoreMeshSource
    {
        public object enableAdaptiveThreshold; // 0x3390C980
        public object minDitherWidth; // 0x3390C980

        // ── Original Methods ──
        public void GenerateTriangles(){} // RVA: 0x7ffaaa378830
        public void DataSourceName(){} // RVA: 0x7ffaaa378f20
        public void OnResize(){} // RVA: 0x7ffaaa378f60
        public void GenerateEdgeMask(){} // RVA: 0x7ffaaa379270
        public void OnGenerate(){} // RVA: 0x7ffaaa379360
        public void .ctor(){} // RVA: 0x7ffaaa37a3b0
        // ── Binary Analysis Named ──
        public void GetComputeShaderName(){} // RVA: 0x7ffaaa3786e0
        public void GetKernelNamePostfix(){} // RVA: 0x7ffaaa378720
    }

    public class StudioLook : ProceduralLook
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa35f890
        // ── Binary Analysis Named ──
        public void GetDefaultMaterial(){} // RVA: 0x7ffaaa376b90
        public void GetLookName(){} // RVA: 0x7ffaaa376e70
        public void SetDataSources(){} // RVA: 0x7ffaaa376eb0
        public void SetDefaults(){} // RVA: 0x7ffaaa377000
    }

    public class StudioMeshSource : MeshSource
    {
        public object m_generateVolumePreviewCompute; // 0x318AA950
        public object m_generateNormalWeightsCompute; // 0x318AA950
        public object volumePreviewAlpha; // 0x318AA950
        public object levelOfDetailDistance; // 0x318AA950
        public object m_mainCamera; // 0x318AA950
        public object m_voxelGridDimensions; // 0x318AA950
        public object surfaceSmoothingRadius; // 0x318AA950
        public object surfaceSensitivityDefault; // 0x318AA950
        public object weightUnseenMinDefault; // 0x318AA950
        public object weightInFrontMinDefault; // 0x318AA950
        public object weightUnseenMax; // 0x318AA950
        public object weightInFrontMax; // 0x318AA950
        public object surfaceNormalColorBlendingPower; // 0x318AA950
        public object disparityMin; // 0x318AA950
        public object enableViewDependentGeometry; // 0x318AA950
        public object m_sdfBuffers; // 0x318AA950
        public object m_triangleConnectionTableSize; // 0x318AA950
        public object m_triangleBufferSize; // 0x318AA950
        public object m_normalWeightTexture; // 0x318AA950
        public object m_generateVolumeKernelGroupSize; // 0x318AA950
        public object m_normalWeightKId; // 0x318AA950
        public object m_generateVolumeMultiPassAccumulateKId; // 0x318AA950
        public object perspectiveColorBlendingData; // 0x318AA950
        public object perspectivesCount; // 0x318AA950
        public object triangleOffsets; // 0x318AA950
        public object maskGenerator; // 0x318AA950
        public object X00; // 0x85388D08
        public object `>;1; // 0x60001B2
        public object X00; // 0x4000120
        public object X00; // 0xB42353C0
        public object X00; // 0x67193C92

        // ── Original Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7ffaaa36dab0
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7ffaaa23fe60
        public void get_volumeBounds(){} // RVA: 0x7ffaaa36db30
        public void set_volumeBounds(){} // RVA: 0x7ffaaa36db50
        public void get_volumeDensity(){} // RVA: 0x7ffaaa36dc40
        public void set_volumeDensity(){} // RVA: 0x7ffaaa36dc50
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7ffaaa36dc60
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7ffaaa36dc70
        public void set_useTextureAtlas(){} // RVA: 0x7ffaa9102fe0
        public void DataSourceName(){} // RVA: 0x7ffaaa36dc80
        public void OnAwake(){} // RVA: 0x7ffaaa36e0c0
        public void OnSetup(){} // RVA: 0x7ffaaa36e250
        public void ResetGPUResources(){} // RVA: 0x7ffaaa36e940
        public void AcquireResources(){} // RVA: 0x7ffaaa36e9a0
        public void FreeResources(){} // RVA: 0x7ffaaa36ec30
        public void EnsureBuffers(){} // RVA: 0x7ffaaa36f070
        public void EnsureTextures(){} // RVA: 0x7ffaaa36f230
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7ffaa887e5c0
        public void EnsureSyncedBuffers(){} // RVA: 0x7ffaaa36f4c0
        public void OnNewMetadata(){} // RVA: 0x7ffaaa36fd80
        public void ResetVolumeBounds(){} // RVA: 0x7ffaaa36ff70
        public void ResetSurfaceSensitivity(){} // RVA: 0x7ffaaa36fff0
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7ffaaa3700b0
        public void OnResize(){} // RVA: 0x7ffaaa3700f0
        public void FilterSdf(){} // RVA: 0x7ffaaa371c10
        public void GenerateNormalWeights(){} // RVA: 0x7ffaaa372340
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7ffaaa372580
        public void GenerateEdgeBlendMask(){} // RVA: 0x7ffaaa372870
        public void DispatchSize(){} // RVA: 0x7ffaaa3728f0
        public void GenerateVolumePass(){} // RVA: 0x7ffaaa372990
        public void GenerateVolume(){} // RVA: 0x7ffaaa372a30
        public void ActivePerspectives(){} // RVA: 0x7ffaaa372b50
        public void GenerateVolumeMultiPass(){} // RVA: 0x7ffaaa372c50
        public void GenerateVolumeSinglePass(){} // RVA: 0x7ffaaa373210
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7ffaaa3733e0
        public void DrawDebug(){} // RVA: 0x7ffaaa373850
        public void OnGenerate(){} // RVA: 0x7ffaaa374060
        public void OnUpdate(){} // RVA: 0x7ffaaa3745c0
        public void EnsureMaskGenerator(){} // RVA: 0x7ffaaa374e80
        public void get_enableEdgeMask(){} // RVA: 0x7ffaaa375120
        public void set_enableEdgeMask(){} // RVA: 0x7ffaaa375140
        public void .ctor(){} // RVA: 0x7ffaaa375150
        public void .cctor(){} // RVA: 0x7ffaaa375380
        // ── Binary Analysis Named ──
        public void GetLocalBounds(){} // RVA: 0x7ffaaa36db30
        public void GetScaledKernelName(){} // RVA: 0x7ffaaa36dcc0
        public void GetExtractVolumeKernelName(){} // RVA: 0x7ffaaa36def0
        public void SetupViewDependence(){} // RVA: 0x7ffaaa36f720
        public void SetProperties(){} // RVA: 0x7ffaaa370fa0
        public void SetProperties(){} // RVA: 0x7ffaaa370fa0
        public void SetProperties(){} // RVA: 0x7ffaaa370fa0
        public void SetCommonComputeProperties(){} // RVA: 0x7ffaaa371290
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7ffaaa371870
    }

    public class SubMesh : Object
    {
        public object m_trianglesCount; // 0x313D2FA0
        public object m_source; // 0x313D2FA0

        // ── Original Methods ──
        public void get_triangleBuffer(){} // RVA: 0x7ffaa89357c0
        public void get_trianglesCount(){} // RVA: 0x7ffaa89600c0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7ffaa8960130
        public void get_drawIndirectArgs(){} // RVA: 0x7ffaa8bfcc80
        public void Init(){} // RVA: 0x7ffaaa35e420
        public void CopyTriangleCount(){} // RVA: 0x7ffaaa35e4d0
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7ffaaa35e540
        public void PrepareDrawArgs(){} // RVA: 0x7ffaaa35e5f0
        public void PrepareDispatchArgs(){} // RVA: 0x7ffaaa35e670
        public void EnsureBuffers(){} // RVA: 0x7ffaaa35e710
        public void Release(){} // RVA: 0x7ffaaa35eaf0
        public void set_source(){} // RVA: 0x7ffaa8bf45c0
        public void get_triangleMesh(){} // RVA: 0x7ffaaa35eca0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void SetProperties(){} // RVA: 0x7ffaaa35efd0
        public void SetProperties(){} // RVA: 0x7ffaaa35efd0
        public void SetProperties(){} // RVA: 0x7ffaaa35efd0
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7ffaa8649ca0
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public object m_dirty; // 0x313D3350

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8668a10
        public void get_Length(){} // RVA: 0x7ffaa8649ca0
        public void MarkDirty(){} // RVA: 0x7ffaa8660cc0
        public void Sync(){} // RVA: 0x7ffaa864a040
        public void Release(){} // RVA: 0x7ffaa8660cc0
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public object m_dirty; // 0x335770C0
        public object Length; // 0x1700003E

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3dec80
        public void get_Length(){} // RVA: 0x7ffaac3dedf0
        public void MarkDirty(){} // RVA: 0x7ffaa976fab0
        public void Sync(){} // RVA: 0x7ffaac3df040
        public void Release(){} // RVA: 0x7ffaac3defb0
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        public object m_dirty; // 0x33629F90
        public object Length; // 0x1700003E

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3dec80
        public void get_Length(){} // RVA: 0x7ffaac3dedf0
        public void MarkDirty(){} // RVA: 0x7ffaa976fab0
        public void Sync(){} // RVA: 0x7ffaac3dee10
        public void Release(){} // RVA: 0x7ffaac3defb0
    }

    public class TriangleMesh : Object
    {
        public object m_triangleCount; // 0x33456F20

        // ── Original Methods ──
        public void get_TriangleCount(){} // RVA: 0x7ffaa8aeced0
        public void set_TriangleCount(){} // RVA: 0x7ffaaa367a90
        public void get_mesh(){} // RVA: 0x7ffaaa367aa0
        public void EnsureTriangleMesh(){} // RVA: 0x7ffaaa368390
        public void EnsureTriangleMesh(){} // RVA: 0x7ffaaa368390
        public void EnsureTriangleMesh(){} // RVA: 0x7ffaaa368390
        public void CreateMesh(){} // RVA: 0x7ffaaa3687a0
        public void ReleaseMesh(){} // RVA: 0x7ffaaa368860
        public void ResetMeshCube(){} // RVA: 0x7ffaaa368cb0
        public void CreateLattice(){} // RVA: 0x7ffaaa368fb0
        public void addVertex(){} // RVA: 0x7ffaaa369420
        public void CreateTriangleLattice(){} // RVA: 0x7ffaaa3695b0
        public void CreateCubeMesh(){} // RVA: 0x7ffaaa369a10
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCubeVerts(){} // RVA: 0x7ffaaa3689d0
        public void GetCubeTriangles(){} // RVA: 0x7ffaaa368ba0
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        // ── Original Methods ──
        public void CreatePlayer(){} // RVA: 0x7ffaaa3625c0
        public void IsPlayerCreated(){} // RVA: 0x7ffaaa362bf0
        public void IsPlayerSetup(){} // RVA: 0x7ffaaa362cc0
        public void StartVideoLoad(){} // RVA: 0x7ffaaa3631a0
        public void Load(){} // RVA: 0x7ffaaa3631d0
        public void OnVideoLoadingComplete(){} // RVA: 0x7ffaaa363270
        public void OnMetadataUpdated(){} // RVA: 0x7ffaa8932310
        public void LoadAndPlay(){} // RVA: 0x7ffaaa3632a0
        public void Play(){} // RVA: 0x7ffaaa363340
        public void Pause(){} // RVA: 0x7ffaaa3633d0
        public void Stop(){} // RVA: 0x7ffaaa363460
        public void IsTextureFlipped(){} // RVA: 0x7ffaa8932320
        public void GammaCorrectDepth(){} // RVA: 0x7ffaaa3636c0
        public void GammaCorrectColor(){} // RVA: 0x7ffaaa363710
        public void IsPlaying(){} // RVA: 0x7ffaaa363760
        public void RemoveComponents(){} // RVA: 0x7ffaaa3637c0
        public void Seek(){} // RVA: 0x7ffaaa363aa0
        public void SupportsPosterFrame(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaaa361b90
        // ── Binary Analysis Named ──
        public void SetVideoPath(){} // RVA: 0x7ffaaa362f50
        public void GetVideoPath(){} // RVA: 0x7ffaaa362fe0
        public void GetCurrentFrame(){} // RVA: 0x7ffaaa3634f0
        public void GetCurrentTime(){} // RVA: 0x7ffaaa363550
        public void GetDuration(){} // RVA: 0x7ffaaa3635b0
        public void GetTexture(){} // RVA: 0x7ffaaa363660
        public void GetPlayerTypeName(){} // RVA: 0x7ffaaa363990
        public void GetPlayerPrettyName(){} // RVA: 0x7ffaaa363a60
        public void GetPlayerBackend(){} // RVA: 0x7ffaa8bfcc80
        public void GetVideoWidth(){} // RVA: 0x7ffaaa363ba0
        public void GetVideoHeight(){} // RVA: 0x7ffaaa363cd0
    }

    public class Util : Object
    {
        // ── Original Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7ffaaa36a030
        public void DispatchGroups(){} // RVA: 0x7ffaaa36a400
        public void ClearRenderTexture(){} // RVA: 0x7ffaaa36a560
        public void ClearAppendBuffer(){} // RVA: 0x7ffaaa36a760
        public void ReleaseComputeBuffer(){} // RVA: 0x7ffaaa36a9d0
        public void ReleaseRenderTexture(){} // RVA: 0x7ffaaa36aa40
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7ffaaa36ac00
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7ffaaa36aff0
        public void TransformBounds(){} // RVA: 0x7ffaaa36b250
        public void CreateRenderTexture(){} // RVA: 0x7ffaaa36b4f0
        public void EnsureRenderTexture(){} // RVA: 0x7ffaaa36b770
        public void EnsureComputeBuffer(){} // RVA: 0x7ffaaa36bce0
        public void ColorForCamera(){} // RVA: 0x7ffaaa36bf30
        public void RenderPerspectiveGizmo(){} // RVA: 0x7ffaa8932310
        public void RenderMetadataGizmos(){} // RVA: 0x7ffaa8932310
        public void IsVisible(){} // RVA: 0x7ffaaa36c0f0
        public void metersToCm(){} // RVA: 0x7ffaaa36c350
        public void cmToMeters(){} // RVA: 0x7ffaaa36c360
        public void EnsureKeyword(){} // RVA: 0x7ffaaa36c370
        public void EnsureComputeShader(){} // RVA: 0x7ffaaa36c470
        // ── Binary Analysis Named ──
        public void GetScaled2DKernelName(){} // RVA: 0x7ffaaa36a050
        public void GetScaled3DKernelName(){} // RVA: 0x7ffaaa36a280
    }

}