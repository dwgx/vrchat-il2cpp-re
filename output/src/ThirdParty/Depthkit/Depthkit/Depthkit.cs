// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 29
// Methods: 490

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        public object playerEvents;
        public object metadataFilePath;
        public object metadataFile;
        public object metadataSourceType;
        public object metadata;
        public object hasMetadata;
        public object perspectiveDataBuffer;
        public object player;
        public object playerSetup;
        public object playerIsActive;
        public object width;
        public object height;
        public object gammaCorrectDepth;
        public object gammaCorrectColor;
        public object cppTexture;
        public object textureIsFlipped;
        public object poster;
        public object disablePoster;
        public object isSetup;

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
        public tionX videoLoaded; // 0x10
        public int consecutiveMoveCount; // 0x18
        public moryFailure.in lastMoveDirection; // 0x1C
        public float lastMoveTime; // 0x20
        public moryFailure.en>>.Remove eventData; // 0x28
        public ilAddress.ActionProperty device; // 0x30

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
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFD4FD77870
        public void GetLookName(){} // RVA: 0x7FFD4FD77B50
        public void SetDefaults(){} // RVA: 0x7FFD4FD77B90
        public void SetDataSources(){} // RVA: 0x7FFD4FD77CC0
        public void .ctor(){} // RVA: 0x7FFD4FD77E10
    }

    public class CoreMeshSource : MeshSource
    {
        public object meshDensity;
        public object latticeMaxTriangles;
        public object latticeResolution;
        public object scaledPerspectiveResolution;
        public object vertexBuffer;

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
        public object clip;
        public object dataSourceParent;

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
        public object hasTexture;
        public object texture;

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
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7FFD4FD7E3A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FD7E7D0
    }

    public class Look : MonoBehaviour
    {
        public object materialPropertyBlock;

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
        public int perspectivesToSlice; // 0x10
        public ileFullDirectoryInformation<B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.Details> sliceToPerspective; // 0x18
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.Details sliceCount; // 0x20
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ blurRadius; // 0x28
        public ÌÍÏÏÏ.ÌÎÍÍÏÍÏÎÏÎÏÌÍÏÏÏ paddedUVScaleFactor; // 0x30

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
        public object currentSubmeshIndex;
        public object triangleBuffer;
        public object triangleBufferDispatchIndirectArgs;
        public object triangleBufferDrawIndirectArgs;
        public object maxSurfaceTriangles;
        public object useTriangleMesh;
        public object triangleMesh;

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
        public object perspectiveCPPResolution;
        public object perspectiveResolution;
        public object paddedTextureDimensions;

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
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4FD7FF70
        public void Update(){} // RVA: 0x7FFD4FD7FF80
        public void LateUpdate(){} // RVA: 0x7FFD4FD7FFA0
        public void .ctor(){} // RVA: 0x7FFD4FD7FFC0
    }

    public class StudioLiteLook : ProceduralLook
    {
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
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7FFD4FD8F110
        public void GetLookName(){} // RVA: 0x7FFD4FD8F3F0
        public void SetDataSources(){} // RVA: 0x7FFD4FD8F430
        public void SetDefaults(){} // RVA: 0x7FFD4FD8F580
        public void .ctor(){} // RVA: 0x7FFD4FD77E10
    }

    public class StudioMeshSource : MeshSource
    {
        public object currentLevelOfDetailLevel;
        public object volumeBounds;
        public object volumeDensity;
        public object numLevelOfDetailLevels;
        public object useTextureAtlas;
        public object enableEdgeMask;

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
        public object triangleBuffer;
        public object trianglesCount;
        public object dispatchIndirectArgs;
        public object drawIndirectArgs;
        public object source;
        public object triangleMesh;

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
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E0986D0
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void MarkDirty(){} // RVA: 0x7FFD4E090980
        public void Sync(){} // RVA: 0x7FFD4E079D00
        public void Release(){} // RVA: 0x7FFD4E090980
    }

    public class TriangleMesh : Object
    {
        public object TriangleCount;
        public object mesh;

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