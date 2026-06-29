// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 46
// Methods: 574

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x7A9C2F020
        public void remove_newFrame(){} // RVA: 0x7A9C2F110
        public void add_newPoster(){} // RVA: 0x7A9C2F200
        public void remove_newPoster(){} // RVA: 0x7A9C2F2F0
        public void add_m_newMetadata(){} // RVA: 0x7A9C2F3E0
        public void remove_m_newMetadata(){} // RVA: 0x7A9C2F4D0
        public void add_newMetadata(){} // RVA: 0x7A9C2F5C0
        public void remove_newMetadata(){} // RVA: 0x7A9C2F790
        public void OnNewFrame(){} // RVA: 0x7A9C2F8B0
        public void OnNewMetadata(){} // RVA: 0x7A9C2F8D0
        public void OnNewPoster(){} // RVA: 0x7A9C2F8F0
        public void get_playerEvents(){} // RVA: 0x7A9C2F910
        public void get_metadataFilePath(){} // RVA: 0x7A8292C30
        public void set_metadataFilePath(){} // RVA: 0x7A9C2FA40
        public void get_metadataFile(){} // RVA: 0x7A8154D80
        public void set_metadataFile(){} // RVA: 0x7A9C2FC80
        public void get_metadataSourceType(){} // RVA: 0x7A8178B70
        public void get_metadata(){} // RVA: 0x7A8178B90
        public void get_hasMetadata(){} // RVA: 0x7A9C2FEE0
        public void LoadMetadata(){} // RVA: 0x7A9C2FF10
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x7A9C30160
        public void get_perspectiveDataBuffer(){} // RVA: 0x7A9C30240
        public void get_player(){} // RVA: 0x7A8175DF0
        public void CreatePlayer(){} // RVA: 0x7A9C30250
        public void SetPlayer(){} // RVA: 0x7A9C304D0
        public void get_playerSetup(){} // RVA: 0x7A9C30700
        public void get_playerIsActive(){} // RVA: 0x7A9C30800
        public void get_width(){} // RVA: 0x7A9C308E0
        public void get_height(){} // RVA: 0x7A9C30930
        public void get_gammaCorrectDepth(){} // RVA: 0x7A9C30980
        public void get_gammaCorrectColor(){} // RVA: 0x7A9C30A20
        public void get_cppTexture(){} // RVA: 0x7A9C30A70
        public void get_textureIsFlipped(){} // RVA: 0x7A9C30AD0
        public void get_poster(){} // RVA: 0x7A82C2060
        public void set_poster(){} // RVA: 0x7A9C30B20
        public void get_disablePoster(){} // RVA: 0x7A8361EA0
        public void set_disablePoster(){} // RVA: 0x7A9C30C60
        public void GetDataSource(){} // RVA: 0x7A8051B10
        public void DoResize(){} // RVA: 0x7A9C30C80
        public void DoGenerate(){} // RVA: 0x7A9C31020
        public void ResetDataSources(){} // RVA: 0x7A9C31540
        public void SetProperties(){} // RVA: 0x7A9C32010
        public void get_isSetup(){} // RVA: 0x7A9C32470
        public void OnEnable(){} // RVA: 0x7A9C324B0
        public void OnDisable(){} // RVA: 0x7A9C328F0
        public void Start(){} // RVA: 0x7A9C32BB0
        public void Update(){} // RVA: 0x7A9C32CC0
        public void LateUpdate(){} // RVA: 0x7A9C32D80
        public void OnDestroy(){} // RVA: 0x7A9C32E20
        public void OnApplicationQuit(){} // RVA: 0x7A9C330B0
        public void .ctor(){} // RVA: 0x7A9C331A0
        public void .cctor(){} // RVA: 0x7A9C331F0
    }

    public class ClipEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
        public void BeginInvoke(){} // RVA: 0x7A8135EE0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class ClipPlayer : MonoBehaviour
    {
        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0x7A81C68D0
        public void set_videoLoaded(){} // RVA: 0x7A81C68E0
        public void CreatePlayer(){} // RVA: 0x7A7E18770
        public void IsPlayerCreated(){} // RVA: 0x7A7E01900
        public void IsPlayerSetup(){} // RVA: 0x7A7E01900
        public void Load(){} // RVA: 0x7A7E00680
        public void StartVideoLoad(){} // RVA: 0x7A7E18770
        public void LoadAndPlay(){} // RVA: 0x7A7E00680
        public void SetVideoPath(){} // RVA: 0x7A7E18800
        public void GetVideoPath(){} // RVA: 0x7A7E00680
        public void OnMetadataUpdated(){} // RVA: 0x7A7E18800
        public void Play(){} // RVA: 0x7A7E18770
        public void Pause(){} // RVA: 0x7A7E18770
        public void Stop(){} // RVA: 0x7A7E18770
        public void RemoveComponents(){} // RVA: 0x7A7E18770
        public void GetTexture(){} // RVA: 0x7A7E00680
        public void IsTextureFlipped(){} // RVA: 0x7A7E01900
        public void GammaCorrectDepth(){} // RVA: 0x7A7E00710
        public void GammaCorrectColor(){} // RVA: 0x7A7E00710
        public void GetPlayerTypeName(){} // RVA: 0x7A7E00680
        public void GetPlayerPrettyName(){} // RVA: 0x7A9C40FC0
        public void IsPlaying(){} // RVA: 0x7A7E01900
        public void GetCurrentTime(){} // RVA: 0x7A7E06760
        public void GetCurrentFrame(){} // RVA: 0x7A7E00710
        public void GetDuration(){} // RVA: 0x7A7E06760
        public void Seek(){} // RVA: 0x7A7E262C0
        public void GetVideoWidth(){} // RVA: 0x7A7E00710
        public void GetVideoHeight(){} // RVA: 0x7A7E00710
        public void SupportsPosterFrame(){} // RVA: 0x7A7E01900
        public void .ctor(){} // RVA: 0x7A9C41000
    }

    public class ClipPlayerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
        public void BeginInvoke(){} // RVA: 0x7A8135EE0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class CoreLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7A9C3E750
        public void GetLookName(){} // RVA: 0x7A9C3EA30
        public void SetDefaults(){} // RVA: 0x7A9C3EA70
        public void SetDataSources(){} // RVA: 0x7A9C3EBA0
        public void .ctor(){} // RVA: 0x7A9C3ECF0
    }

    public class CoreMeshSource : MeshSource
    {
        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x7A9C339E0
        public void set_meshDensity(){} // RVA: 0x7A9C33A00
        public void get_latticeMaxTriangles(){} // RVA: 0x7A9B79A40
        public void get_latticeResolution(){} // RVA: 0x7A87D9C10
        public void get_scaledPerspectiveResolution(){} // RVA: 0x7A9C33AB0
        public void ResizeLattice(){} // RVA: 0x7A9C33B60
        public void get_vertexBuffer(){} // RVA: 0x7A81426F0
        public void GetComputeShaderName(){} // RVA: 0x7A9C33C90
        public void GetKernelNamePostfix(){} // RVA: 0x7A9C33CD0
        public void FindKernelId(){} // RVA: 0x7A9C33D70
        public void GenerateVertexBuffer(){} // RVA: 0x7A9C33FD0
        public void GenerateTriangles(){} // RVA: 0x7A9C34BB0
        public void GenerateVertices(){} // RVA: 0x7A9C34340
        public void GenerateNormals(){} // RVA: 0x7A9C34870
        public void DataSourceName(){} // RVA: 0x7A9C34FE0
        public void EnsureVertexBuffer(){} // RVA: 0x7A9C35020
        public void AcquireResources(){} // RVA: 0x7A9C35140
        public void FreeResources(){} // RVA: 0x7A9C35310
        public void OnSetup(){} // RVA: 0x7A9C35350
        public void baseResize(){} // RVA: 0x7A9C353D0
        public void OnResize(){} // RVA: 0x7A9C353E0
        public void GenerateEdgeMask(){} // RVA: 0x7A9C35590
        public void OnGenerate(){} // RVA: 0x7A9C35670
        public void SetProperties(){} // RVA: 0x7A9C35B50
        public void EnsureMaskGenerator(){} // RVA: 0x7A9C35D10
        public void .ctor(){} // RVA: 0x7A9C35F20
    }

    public class DataSource : MonoBehaviour
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x7A83F69F0
        public void get_dataSourceParent(){} // RVA: 0x7A8292C30
        public void DataSourceName(){} // RVA: 0x7A7E00680
        public void GetChild(){} // RVA: 0x7A8051B10
        public void ResetChildren(){} // RVA: 0x7A9C36290
        public void AcquireResources(){} // RVA: 0x7A80D7310
        public void FreeResources(){} // RVA: 0x7A80D7310
        public void OnAwake(){} // RVA: 0x7A80D7310
        public void OnCleanup(){} // RVA: 0x7A80D7310
        public void OnSetup(){} // RVA: 0x7A7E01900
        public void OnResize(){} // RVA: 0x7A7E01900
        public void OnGenerate(){} // RVA: 0x7A7E01900
        public void OnUpdate(){} // RVA: 0x7A80D7310
        public void CanGenerate(){} // RVA: 0x7A81BD750
        public void Awake(){} // RVA: 0x7A9C364C0
        public void Start(){} // RVA: 0x7A9C36680
        public void ScheduleGenerate(){} // RVA: 0x7A88A0900
        public void ScheduleResize(){} // RVA: 0x7A9C366A0
        public void UnscheduleGenerate(){} // RVA: 0x7A88A0910
        public void UnscheduleResize(){} // RVA: 0x7A9C366B0
        public void OnEnable(){} // RVA: 0x7A9C366C0
        public void OnDisable(){} // RVA: 0x7A9C369A0
        public void Reset(){} // RVA: 0x7A9C36C50
        public void Setup(){} // RVA: 0x7A9C36C60
        public void Cleanup(){} // RVA: 0x7A9C36F30
        public void Resize(){} // RVA: 0x7A9C37350
        public void IsSetup(){} // RVA: 0x7A84A5BD0
        public void Generate(){} // RVA: 0x7A9C37770
        public void Update(){} // RVA: 0x7A9C37BC0
        public void LateUpdate(){} // RVA: 0x7A9C37BE0
        public void .ctor(){} // RVA: 0x7A9C37C20
    }

    public class DataSourceEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
        public void BeginInvoke(){} // RVA: 0x7A8135EE0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class DataSourceEvents : Object
    {
        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x7A9C37D90
        public void remove_m_dataGenerated(){} // RVA: 0x7A9C37E80
        public void add_dataGenerated(){} // RVA: 0x7A9C37F70
        public void remove_dataGenerated(){} // RVA: 0x7A9C38140
        public void add_m_dataResized(){} // RVA: 0x7A9C38260
        public void remove_m_dataResized(){} // RVA: 0x7A9C38350
        public void add_dataResized(){} // RVA: 0x7A9C38440
        public void remove_dataResized(){} // RVA: 0x7A9C38610
        public void OnDataGenerated(){} // RVA: 0x7A9C38730
        public void OnDataResized(){} // RVA: 0x7A9C38750
        public void .ctor(){} // RVA: 0x7A80D7310
        // ── Unresolved (hash) ──
        public void m_dataGenerated(){} // RVA: 0x7B3F53ED8
    }

    public class DepthkitLookEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
        public void BeginInvoke(){} // RVA: 0x7A8135EE0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class GaussianBlurFilter : Object
    {
        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x7A9C435A0
        public void get_texture(){} // RVA: 0x7A9C435B0
        public void CreateTextures(){} // RVA: 0x7A9C435E0
        public void Setup(){} // RVA: 0x7A9C43AD0
        public void EnsureTextures(){} // RVA: 0x7A9C43BB0
        public void DoBlur(){} // RVA: 0x7A9C43E20
        public void BlurPass(){} // RVA: 0x7A9C43FC0
        public void Release(){} // RVA: 0x7A9C445C0
        public void .ctor(){} // RVA: 0x7A9C44760
        public void .cctor(){} // RVA: 0x7A9C44780
        public void radius(){} // RVA: 0x7B41F0FE8
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x7A7E18890
    }

    public class IndexedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C339B0
    }

    public class Info : Object
    {
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x7A9C452B0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9C456E0
    }

    public class Look : MonoBehaviour
    {
        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x7A9C3ED40
        public void get_materialPropertyBlock(){} // RVA: 0x7A9C3EE50
        public void GetLookName(){} // RVA: 0x7A7E00680
        public void UsesMaterial(){} // RVA: 0x7A7E01900
        public void GetMaterial(){} // RVA: 0x7A7E00680
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7A81BD750
        public void GetMaterialPropertyBlock(){} // RVA: 0x7A9C3EE50
        public void SetDataSources(){} // RVA: 0x7A7E18770
        public void ValidateDataSources(){} // RVA: 0x7A9C3EE70
        public void SetMaterialProperties(){} // RVA: 0x7A80D7310
        public void OnUpdate(){} // RVA: 0x7A8881850
        public void SetDefaults(){} // RVA: 0x7A9C3EF40
        public void SetLookProperties(){} // RVA: 0x7A9C3EFE0
        public void Awake(){} // RVA: 0x7A9C3F8B0
        public void Init(){} // RVA: 0x7A9C3FAE0
        public void Start(){} // RVA: 0x7A9C3FE20
        public void OnEnable(){} // RVA: 0x7A9C3FE50
        public void OnDisable(){} // RVA: 0x7A9C3FF80
        public void SyncColliderToBounds(){} // RVA: 0x7A9C401A0
        public void OnMetaDataUpdated(){} // RVA: 0x7A9C40560
        public void LateUpdate(){} // RVA: 0x7A9C40570
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class MaskGenerator : Object
    {
        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0x7A8178B90
        public void set_perspectivesToSlice(){} // RVA: 0x7A8230620
        public void get_sliceToPerspective(){} // RVA: 0x7A81A0050
        public void set_sliceToPerspective(){} // RVA: 0x7A81A0060
        public void get_sliceCount(){} // RVA: 0x7A9C38770
        public void set_sliceCount(){} // RVA: 0x7A9C38790
        public void get_blurRadius(){} // RVA: 0x7A9C387A0
        public void set_blurRadius(){} // RVA: 0x7A9C387C0
        public void get_paddedUVScaleFactor(){} // RVA: 0x7A9C387E0
        public void get_maskTexture(){} // RVA: 0x7A9C389D0
        public void get_downScale(){} // RVA: 0x7A9A18C60
        public void set_downScale(){} // RVA: 0x7A9C38A20
        public void get_downScaledMaskTexture(){} // RVA: 0x7A9C38AA0
        public void DownScalePass(){} // RVA: 0x7A9C38B10
        public void DownScaleMaskTexture(){} // RVA: 0x7A9C38CB0
        public void Setup(){} // RVA: 0x7A9C39A80
        public void EnsureTexture(){} // RVA: 0x7A9C39FC0
        public void Release(){} // RVA: 0x7A9C3A2A0
        public void SobelFilterMask(){} // RVA: 0x7A9C3A460
        public void BlurMask(){} // RVA: 0x7A9C3A850
        public void GenerateMask(){} // RVA: 0x7A9C3A890
        public void SetProperties(){} // RVA: 0x7A9C3B090
        public void .ctor(){} // RVA: 0x7A9C3B4D0
    }

    public class MeshSource : DataSource
    {
        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0x7A8051B10
        public void CurrentSubMesh(){} // RVA: 0x7A8051B10
        public void ReserveSubMeshes(){} // RVA: 0x7A7E189D0
        public void get_currentSubmeshIndex(){} // RVA: 0x7A9A93890
        public void set_currentSubmeshIndex(){} // RVA: 0x7A9A938A0
        public void get_triangleBuffer(){} // RVA: 0x7A9C3BCE0
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x7A9C3BD30
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x7A9C3BD80
        public void get_maxSurfaceTriangles(){} // RVA: 0x7A9C3BDD0
        public void set_maxSurfaceTriangles(){} // RVA: 0x7A9C3BE20
        public void get_useTriangleMesh(){} // RVA: 0x7A8153980
        public void set_useTriangleMesh(){} // RVA: 0x7A9C3BE80
        public void get_triangleMesh(){} // RVA: 0x7A9C3BEE0
        public void EnsureRadialBias(){} // RVA: 0x7A9C3BF20
        public void AcquireResources(){} // RVA: 0x7A9C3C1F0
        public void FreeResources(){} // RVA: 0x7A9C3C2C0
        public void CanGenerate(){} // RVA: 0x7A9C3C340
        public void OnSetup(){} // RVA: 0x7A9C3C440
        public void OnResize(){} // RVA: 0x7A9C3C5B0
        public void OnUpdate(){} // RVA: 0x7A9C3C870
        public void OnGenerate(){} // RVA: 0x7A9C3CA40
        public void GetLocalBounds(){} // RVA: 0x7A9C3CD10
        public void GetWorldBounds(){} // RVA: 0x7A9C3CEE0
        public void Pause(){} // RVA: 0x7A9C3D220
        public void Continue(){} // RVA: 0x7A9C3D2B0
        public void OnBecameVisible(){} // RVA: 0x7A9C3D350
        public void OnBecameInvisible(){} // RVA: 0x7A9C3D370
        public void CheckVisibility(){} // RVA: 0x7A9C3D390
        public void SetProperties(){} // RVA: 0x7A9C3D600
        public void .ctor(){} // RVA: 0x7A9C3D710
    }

    public class Metadata : Object
    {
        // ── Methods ──
        public void Valid(){} // RVA: 0x7A9C45730
        public void get_perspectiveCPPResolution(){} // RVA: 0x7A9C45750
        public void get_perspectiveResolution(){} // RVA: 0x7A9C457C0
        public void get_paddedTextureDimensions(){} // RVA: 0x7A9C45840
        public void FromSinglePerspective(){} // RVA: 0x7A9C458C0
        public void CreateFromJSON(){} // RVA: 0x7A9C45BA0
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x7A9C46770
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9C46A90
        public void MaxPerspectives(){} // RVA: 0x7B3FB4428
    }

    public class PackedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C33980
    }

    public class PerspectiveColorBlending : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A9C56540
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C56610
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x7A9C56890
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x7A9C568D0
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x7A9C56990
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x7A9C569D0
        public void GetEdgeMaskStrength(){} // RVA: 0x7A9C56A90
        public void SetEdgeMaskStrength(){} // RVA: 0x7A9C56AD0
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x7A9C56B90
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x7A9C56BD0
        public void GetEdgeMaskEnabled(){} // RVA: 0x7A9C56C90
        public void SetEdgeMaskEnabled(){} // RVA: 0x7A9C56CE0
        public void GetPerspectiveEnabled(){} // RVA: 0x7A9C56D90
        public void SetPerspectiveEnabled(){} // RVA: 0x7A9C56DD0
    }

    public class PerspectiveColorBlending[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PerspectiveGeometry : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A9C56E70
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C56F40
        public void EnableGeometry(){} // RVA: 0x7A9C572E0
        public void GetOverrideWeightUnknown(){} // RVA: 0x7A9C57380
        public void SetOverrideWeightUnknown(){} // RVA: 0x7A9C573C0
        public void GetWeightUnknown(){} // RVA: 0x7A9C56990
        public void SetWeightUnknown(){} // RVA: 0x7A9C57460
        public void MatchViewDependentColorWeight(){} // RVA: 0x7A9C57550
        public void GetViewDependentContribution(){} // RVA: 0x7A9C57580
        public void SetViewDependentContribution(){} // RVA: 0x7A9C575B0
        public void GetViewDependentWeight(){} // RVA: 0x7A9C56890
        public void SetViewDependentWeight(){} // RVA: 0x7A9C57600
        public void GetViewDependentInFrontAmount(){} // RVA: 0x7A9C56A90
        public void SetViewDependentInFrontAmount(){} // RVA: 0x7A9C576C0
        public void GetViewDependentUnseenAmount(){} // RVA: 0x7A9C56B90
        public void SetViewDependentUnseenAmount(){} // RVA: 0x7A9C57780
        // ── Unresolved (hash) ──
        public void m_geometryMatchesColorWeights(){} // RVA: 0x7B3FB4328
    }

    public class PerspectiveGeometry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A9C46BF0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class PlayerEvents : Object
    {
        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x7A9C410D0
        public void remove_playbackStarted(){} // RVA: 0x7A9C411C0
        public void add_playbackPaused(){} // RVA: 0x7A9C412B0
        public void remove_playbackPaused(){} // RVA: 0x7A9C413A0
        public void add_playbackStopped(){} // RVA: 0x7A9C41490
        public void remove_playbackStopped(){} // RVA: 0x7A9C41580
        public void add_loadingStarted(){} // RVA: 0x7A9C41670
        public void remove_loadingStarted(){} // RVA: 0x7A9C41760
        public void add_loadingFinished(){} // RVA: 0x7A9C41850
        public void remove_loadingFinished(){} // RVA: 0x7A9C41940
        public void OnClipPlaybackStarted(){} // RVA: 0x7A9C38730
        public void OnClipPlaybackPaused(){} // RVA: 0x7A9C38750
        public void OnClipPlaybackStopped(){} // RVA: 0x7A9C2F8B0
        public void OnClipLoadingStarted(){} // RVA: 0x7A9C2F8F0
        public void OnClipLoadingFinished(){} // RVA: 0x7A9C2F8D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void playbackStarted(){} // RVA: 0x7B3F54258
    }

    public class ProceduralLook : Look
    {
        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0x7A81BD750
        public void GetMaterial(){} // RVA: 0x7A8153390
        public void UsesMaterialPropertyBlock(){} // RVA: 0x7A81BD750
        public void SetMaterialProperties(){} // RVA: 0x7A9C40860
        public void OnUpdate(){} // RVA: 0x7A9C40D00
        public void .ctor(){} // RVA: 0x7A9C3ECF0
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A9C46E00
        public void Update(){} // RVA: 0x7A9C46E10
        public void LateUpdate(){} // RVA: 0x7A9C46E30
        public void .ctor(){} // RVA: 0x7A9C46E50
    }

    public class StudioLiteLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7A9C59890
        public void GetLookName(){} // RVA: 0x7A9C5A540
        public void SetDefaults(){} // RVA: 0x7A9C5A580
        public void SetDataSources(){} // RVA: 0x7A9C5ACE0
        public void OnUpdate(){} // RVA: 0x7A9C5AE30
        public void .ctor(){} // RVA: 0x7A9C5B190
    }

    public class StudioLiteMeshSource : CoreMeshSource
    {
        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x7A9C579B0
        public void GetKernelNamePostfix(){} // RVA: 0x7A9C579F0
        public void GenerateTriangles(){} // RVA: 0x7A9C57B00
        public void DataSourceName(){} // RVA: 0x7A9C58200
        public void OnResize(){} // RVA: 0x7A9C58240
        public void GenerateEdgeMask(){} // RVA: 0x7A9C58560
        public void OnGenerate(){} // RVA: 0x7A9C58650
        public void .ctor(){} // RVA: 0x7A9C596D0
    }

    public class StudioLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x7A9C55FA0
        public void GetLookName(){} // RVA: 0x7A9C56280
        public void SetDataSources(){} // RVA: 0x7A9C562C0
        public void SetDefaults(){} // RVA: 0x7A9C56410
        public void .ctor(){} // RVA: 0x7A9C3ECF0
    }

    public class StudioMeshSource : MeshSource
    {
        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x7A9C4CEB0
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x7A9B14850
        public void get_volumeBounds(){} // RVA: 0x7A9A831A0
        public void set_volumeBounds(){} // RVA: 0x7A9C4CF30
        public void GetLocalBounds(){} // RVA: 0x7A9A831A0
        public void get_volumeDensity(){} // RVA: 0x7A9C4D020
        public void set_volumeDensity(){} // RVA: 0x7A9C4D030
        public void get_numLevelOfDetailLevels(){} // RVA: 0x7A9183130
        public void set_numLevelOfDetailLevels(){} // RVA: 0x7A918EF30
        public void set_useTextureAtlas(){} // RVA: 0x7A884E150
        public void DataSourceName(){} // RVA: 0x7A9C4D040
        public void GetScaledKernelName(){} // RVA: 0x7A9C4D080
        public void GetExtractVolumeKernelName(){} // RVA: 0x7A9C4D2B0
        public void OnAwake(){} // RVA: 0x7A9C4D480
        public void OnSetup(){} // RVA: 0x7A9C4D610
        public void ResetGPUResources(){} // RVA: 0x7A9C4DD00
        public void AcquireResources(){} // RVA: 0x7A9C4DD60
        public void FreeResources(){} // RVA: 0x7A9C4DFF0
        public void EnsureBuffers(){} // RVA: 0x7A9C4E440
        public void EnsureTextures(){} // RVA: 0x7A9C4E600
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0x7A8051B10
        public void EnsureSyncedBuffers(){} // RVA: 0x7A9C4E880
        public void SetupViewDependence(){} // RVA: 0x7A9C4EAF0
        public void OnNewMetadata(){} // RVA: 0x7A9C4F1A0
        public void ResetVolumeBounds(){} // RVA: 0x7A9C4F390
        public void ResetSurfaceSensitivity(){} // RVA: 0x7A9C4F410
        public void LoadFrontBiasedDefaults(){} // RVA: 0x7A9C4F4E0
        public void OnResize(){} // RVA: 0x7A9C4F520
        public void SetProperties(){} // RVA: 0x7A9C50380
        public void SetCommonComputeProperties(){} // RVA: 0x7A9C50670
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x7A9C50C40
        public void FilterSdf(){} // RVA: 0x7A9C50FE0
        public void GenerateNormalWeights(){} // RVA: 0x7A9C51710
        public void GenerateNormalWeightsCompute(){} // RVA: 0x7A9C51950
        public void GenerateEdgeBlendMask(){} // RVA: 0x7A9C51C40
        public void DispatchSize(){} // RVA: 0x7A9C51CC0
        public void GenerateVolumePass(){} // RVA: 0x7A9C51D70
        public void GenerateVolume(){} // RVA: 0x7A9C51E10
        public void ActivePerspectives(){} // RVA: 0x7A9C51F30
        public void GenerateVolumeMultiPass(){} // RVA: 0x7A9C52040
        public void GenerateVolumeSinglePass(){} // RVA: 0x7A9C52610
        public void ExtractSurfaceFromVolume(){} // RVA: 0x7A9C527E0
        public void DrawDebug(){} // RVA: 0x7A9C52C50
        public void OnGenerate(){} // RVA: 0x7A9C53460
        public void OnUpdate(){} // RVA: 0x7A9C539C0
        public void EnsureMaskGenerator(){} // RVA: 0x7A9C54290
        public void get_enableEdgeMask(){} // RVA: 0x7A9C54530
        public void set_enableEdgeMask(){} // RVA: 0x7A9C54550
        public void .ctor(){} // RVA: 0x7A9C54560
        public void .cctor(){} // RVA: 0x7A9C54790
    }

    public class SubMesh : Object
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7A7E00710
        public void get_triangleBuffer(){} // RVA: 0x7A80DA7B0
        public void get_trianglesCount(){} // RVA: 0x7A81052C0
        public void get_dispatchIndirectArgs(){} // RVA: 0x7A8105330
        public void get_drawIndirectArgs(){} // RVA: 0x7A83F69F0
        public void Init(){} // RVA: 0x7A9C3D880
        public void CopyTriangleCount(){} // RVA: 0x7A9C3D930
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x7A9C3D9A0
        public void PrepareDrawArgs(){} // RVA: 0x7A9C3DA50
        public void PrepareDispatchArgs(){} // RVA: 0x7A9C3DAD0
        public void EnsureBuffers(){} // RVA: 0x7A9C3DB70
        public void Release(){} // RVA: 0x7A9C3DF50
        public void set_source(){} // RVA: 0x7A8296DE0
        public void get_triangleMesh(){} // RVA: 0x7A9C3E100
        public void SetProperties(){} // RVA: 0x7A9C3E430
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubMesh[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7A7E00710
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7ABEADC50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x7ABEADB70
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18AE0
        public void get_Length(){} // RVA: 0x7A7E00710
        public void MarkDirty(){} // RVA: 0x7A7E18770
        public void Sync(){} // RVA: 0x7A7E01900
        public void Release(){} // RVA: 0x7A7E18770
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABEAED40
        public void get_Length(){} // RVA: 0x7ABEAEEB0
        public void MarkDirty(){} // RVA: 0x7A9039410
        public void Sync(){} // RVA: 0x7ABEAF5E0
        public void Release(){} // RVA: 0x7ABEAF070
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABEAED40
        public void get_Length(){} // RVA: 0x7ABEAEEB0
        public void MarkDirty(){} // RVA: 0x7A9039410
        public void Sync(){} // RVA: 0x7ABEAEED0
        public void Release(){} // RVA: 0x7ABEAF070
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABEAED40
        public void get_Length(){} // RVA: 0x7ABEAEEB0
        public void MarkDirty(){} // RVA: 0x7A9039410
        public void Sync(){} // RVA: 0x7ABEAF100
        public void Release(){} // RVA: 0x7ABEAF070
    }

    public class TriangleMesh : Object
    {
        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0x7A851DB90
        public void set_TriangleCount(){} // RVA: 0x7A9C46EA0
        public void get_mesh(){} // RVA: 0x7A9C46EB0
        public void EnsureTriangleMesh(){} // RVA: 0x7A9C47790
        public void CreateMesh(){} // RVA: 0x7A9C47B90
        public void ReleaseMesh(){} // RVA: 0x7A9C47C50
        public void GetCubeVerts(){} // RVA: 0x7A9C47DC0
        public void GetCubeTriangles(){} // RVA: 0x7A9C47F90
        public void ResetMeshCube(){} // RVA: 0x7A9C480A0
        public void CreateLattice(){} // RVA: 0x7A9C48390
        public void addVertex(){} // RVA: 0x7A9C48820
        public void CreateTriangleLattice(){} // RVA: 0x7A9C489B0
        public void CreateCubeMesh(){} // RVA: 0x7A9C48E10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void source(){} // RVA: 0x7B3FA7CD8
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x7A9C41A30
        public void IsPlayerCreated(){} // RVA: 0x7A9C42060
        public void IsPlayerSetup(){} // RVA: 0x7A9C42130
        public void SetVideoPath(){} // RVA: 0x7A9C423D0
        public void GetVideoPath(){} // RVA: 0x7A9C42460
        public void StartVideoLoad(){} // RVA: 0x7A9C42620
        public void Load(){} // RVA: 0x7A9C42650
        public void OnVideoLoadingComplete(){} // RVA: 0x7A9C426F0
        public void OnMetadataUpdated(){} // RVA: 0x7A80D7310
        public void LoadAndPlay(){} // RVA: 0x7A9C42720
        public void Play(){} // RVA: 0x7A9C427C0
        public void Pause(){} // RVA: 0x7A9C42850
        public void Stop(){} // RVA: 0x7A9C428E0
        public void GetCurrentFrame(){} // RVA: 0x7A9C42970
        public void GetCurrentTime(){} // RVA: 0x7A9C429D0
        public void GetDuration(){} // RVA: 0x7A9C42A30
        public void GetTexture(){} // RVA: 0x7A9C42AE0
        public void IsTextureFlipped(){} // RVA: 0x7A80D7320
        public void GammaCorrectDepth(){} // RVA: 0x7A9C42B40
        public void GammaCorrectColor(){} // RVA: 0x7A9C42B90
        public void IsPlaying(){} // RVA: 0x7A9C42BE0
        public void RemoveComponents(){} // RVA: 0x7A9C42C40
        public void GetPlayerTypeName(){} // RVA: 0x7A9C42E10
        public void GetPlayerPrettyName(){} // RVA: 0x7A9C42EE0
        public void GetPlayerBackend(){} // RVA: 0x7A83F69F0
        public void Seek(){} // RVA: 0x7A9C42F20
        public void GetVideoWidth(){} // RVA: 0x7A9C43020
        public void GetVideoHeight(){} // RVA: 0x7A9C43150
        public void SupportsPosterFrame(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A9C41000
    }

    public class Util : Object
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x7A9C49430
        public void GetScaled2DKernelName(){} // RVA: 0x7A9C49450
        public void GetScaled3DKernelName(){} // RVA: 0x7A9C49680
        public void DispatchGroups(){} // RVA: 0x7A9C49800
        public void ClearRenderTexture(){} // RVA: 0x7A9C49960
        public void ClearAppendBuffer(){} // RVA: 0x7A9C49B60
        public void ReleaseComputeBuffer(){} // RVA: 0x7A9C49DD0
        public void ReleaseRenderTexture(){} // RVA: 0x7A9C49E40
        public void CopyFromRenderTextureSettings(){} // RVA: 0x7A9C4A000
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x7A9C4A3F0
        public void TransformBounds(){} // RVA: 0x7A9C4A650
        public void CreateRenderTexture(){} // RVA: 0x7A9C4A8F0
        public void EnsureRenderTexture(){} // RVA: 0x7A9C4AB70
        public void EnsureComputeBuffer(){} // RVA: 0x7A9C4B0E0
        public void ColorForCamera(){} // RVA: 0x7A9C4B330
        public void RenderPerspectiveGizmo(){} // RVA: 0x7A80D7310
        public void RenderMetadataGizmos(){} // RVA: 0x7A80D7310
        public void IsVisible(){} // RVA: 0x7A9C4B4F0
        public void metersToCm(){} // RVA: 0x7A9C4B750
        public void cmToMeters(){} // RVA: 0x7A9C4B760
        public void EnsureKeyword(){} // RVA: 0x7A9C4B770
        public void EnsureComputeShader(){} // RVA: 0x7A9C4B870
    }

    public class Version : ValueType
    {
        // ── Methods ──
        public void get_major(){} // RVA: 0x7A767CAD0
        public void set_major(){} // RVA: 0x7A767CAE0
        public void get_minor(){} // RVA: 0x7A767CAF0
        public void set_minor(){} // RVA: 0x7A763C970
        public void get_patch(){} // RVA: 0x7A767CB00
        public void set_patch(){} // RVA: 0x7A763C9C0
        public void .ctor(){} // RVA: 0x7A76773F0
        public void ToString(){} // RVA: 0x7A767CB10
        public void op_Implicit(){} // RVA: 0x7A9C44FB0
        public void Equals(){} // RVA: 0x7A767CBC0
        public void GetHashCode(){} // RVA: 0x7A767CBF0
        public void op_Equality(){} // RVA: 0x7A9C45090
        public void op_Inequality(){} // RVA: 0x7A9C450C0
        public void op_LessThan(){} // RVA: 0x7A9C450F0
        public void op_GreaterThan(){} // RVA: 0x7A9C45140
        public void op_LessThanOrEqual(){} // RVA: 0x7A9C45190
        public void op_GreaterThanOrEqual(){} // RVA: 0x7A9C45220
    }

}