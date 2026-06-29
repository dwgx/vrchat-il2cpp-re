// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit
// Classes: 46
// Methods: 569

namespace ThirdParty.Depthkit.Depthkit
{
    public class Clip : MonoBehaviour
    {
        // ── Methods ──
        public void add_newFrame(){} // RVA: 0x26AD0D0
        public void remove_newFrame(){} // RVA: 0x26AD1C0
        public void add_newPoster(){} // RVA: 0x26AD2B0
        public void remove_newPoster(){} // RVA: 0x26AD3A0
        public void add_m_newMetadata(){} // RVA: 0x26AD490
        public void remove_m_newMetadata(){} // RVA: 0x26AD580
        public void add_newMetadata(){} // RVA: 0x26AD670
        public void remove_newMetadata(){} // RVA: 0x26AD840
        public void OnNewFrame(){} // RVA: 0x26AD960
        public void OnNewMetadata(){} // RVA: 0x26AD980
        public void OnNewPoster(){} // RVA: 0x26AD9A0
        public void get_playerEvents(){} // RVA: 0x26AD9C0
        public void get_metadataFilePath(){} // RVA: 0xD05CA0
        public void set_metadataFilePath(){} // RVA: 0x26ADAF0
        public void get_metadataFile(){} // RVA: 0xBC1B30
        public void set_metadataFile(){} // RVA: 0x26ADD00
        public void get_metadataSourceType(){} // RVA: 0xBE5890
        public void get_metadata(){} // RVA: 0xBE58B0
        public void get_hasMetadata(){} // RVA: 0x26ADF60
        public void LoadMetadata(){} // RVA: 0x26ADF90
        public void EnsurePerspectiveDataBuffer(){} // RVA: 0x26AE1E0
        public void get_perspectiveDataBuffer(){} // RVA: 0x26AE2C0
        public void get_player(){} // RVA: 0xBE2C60
        public void CreatePlayer(){} // RVA: 0x26AE2D0
        public void SetPlayer(){} // RVA: 0x26AE610
        public void get_playerSetup(){} // RVA: 0x26AE7D0
        public void get_playerIsActive(){} // RVA: 0x26AE8D0
        public void get_width(){} // RVA: 0x26AE9B0
        public void get_height(){} // RVA: 0x26AEA00
        public void get_gammaCorrectDepth(){} // RVA: 0x26AEA50
        public void get_gammaCorrectColor(){} // RVA: 0x26AEAF0
        public void get_cppTexture(){} // RVA: 0x26AEB40
        public void get_textureIsFlipped(){} // RVA: 0x26AEBA0
        public void get_poster(){} // RVA: 0xCD3320
        public void set_poster(){} // RVA: 0x26AEBF0
        public void get_disablePoster(){} // RVA: 0xE3F400
        public void set_disablePoster(){} // RVA: 0x26AED30
        public void GetDataSource(){} // RVA: 0xA94080
        public void DoResize(){} // RVA: 0x26AED50
        public void DoGenerate(){} // RVA: 0x26AF0F0
        public void ResetDataSources(){} // RVA: 0x26AF610
        public void SetProperties(){} // RVA: 0x26B0130
        public void get_isSetup(){} // RVA: 0x26B0880
        public void OnEnable(){} // RVA: 0x26B08C0
        public void OnDisable(){} // RVA: 0x26B0D00
        public void Start(){} // RVA: 0x26B0FC0
        public void Update(){} // RVA: 0x26B10D0
        public void LateUpdate(){} // RVA: 0x26B1190
        public void OnDestroy(){} // RVA: 0x26B1240
        public void OnApplicationQuit(){} // RVA: 0x26B14D0
        public void .ctor(){} // RVA: 0x26B15C0
        public void .cctor(){} // RVA: 0x26B1610
    }

    public class ClipEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
        public void BeginInvoke(){} // RVA: 0xBA10C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class ClipPlayer : MonoBehaviour
    {
        // ── Methods ──
        public void get_videoLoaded(){} // RVA: 0xC38360
        public void set_videoLoaded(){} // RVA: 0xC38370
        public void CreatePlayer(){} // RVA: 0x894290
        public void IsPlayerCreated(){} // RVA: 0x87D280
        public void IsPlayerSetup(){} // RVA: 0x87D280
        public void Load(){} // RVA: 0x87C0A0
        public void StartVideoLoad(){} // RVA: 0x894290
        public void LoadAndPlay(){} // RVA: 0x87C0A0
        public void SetVideoPath(){} // RVA: 0x894320
        public void GetVideoPath(){} // RVA: 0x87C0A0
        public void OnMetadataUpdated(){} // RVA: 0x894320
        public void Play(){} // RVA: 0x894290
        public void Pause(){} // RVA: 0x894290
        public void Stop(){} // RVA: 0x894290
        public void RemoveComponents(){} // RVA: 0x894290
        public void GetTexture(){} // RVA: 0x87C0A0
        public void IsTextureFlipped(){} // RVA: 0x87D280
        public void GammaCorrectDepth(){} // RVA: 0x87C130
        public void GammaCorrectColor(){} // RVA: 0x87C130
        public void GetPlayerTypeName(){} // RVA: 0x87C0A0
        public void GetPlayerPrettyName(){} // RVA: 0x26BEDB0
        public void IsPlaying(){} // RVA: 0x87D280
        public void GetCurrentTime(){} // RVA: 0x8820E0
        public void GetCurrentFrame(){} // RVA: 0x87C130
        public void GetDuration(){} // RVA: 0x8820E0
        public void Seek(){} // RVA: 0x8A23A0
        public void GetVideoWidth(){} // RVA: 0x87C130
        public void GetVideoHeight(){} // RVA: 0x87C130
        public void SupportsPosterFrame(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x26BEDF0
    }

    public class ClipPlayerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
        public void BeginInvoke(){} // RVA: 0xBA10C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class CoreLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x26BC1D0
        public void GetLookName(){} // RVA: 0x26BC4B0
        public void SetDefaults(){} // RVA: 0x26BC4F0
        public void SetDataSources(){} // RVA: 0x26BC620
        public void .ctor(){} // RVA: 0x26BC770
    }

    public class CoreMeshSource : MeshSource
    {
        // ── Methods ──
        public void get_meshDensity(){} // RVA: 0x26B1B90
        public void set_meshDensity(){} // RVA: 0x26B1BB0
        public void get_latticeMaxTriangles(){} // RVA: 0x262A8F0
        public void get_latticeResolution(){} // RVA: 0x106A7D0
        public void get_scaledPerspectiveResolution(){} // RVA: 0x26B1C60
        public void ResizeLattice(){} // RVA: 0x26B1D10
        public void get_vertexBuffer(){} // RVA: 0xBAE420
        public void GetComputeShaderName(){} // RVA: 0x26B1E40
        public void GetKernelNamePostfix(){} // RVA: 0x26B1E80
        public void FindKernelId(){} // RVA: 0x26B1F20
        public void GenerateVertexBuffer(){} // RVA: 0x26B2180
        public void GenerateTriangles(){} // RVA: 0x26B2D70
        public void GenerateVertices(){} // RVA: 0x26B24F0
        public void GenerateNormals(){} // RVA: 0x26B2A00
        public void DataSourceName(){} // RVA: 0x26B31E0
        public void EnsureVertexBuffer(){} // RVA: 0x26B3220
        public void AcquireResources(){} // RVA: 0x26B3360
        public void FreeResources(){} // RVA: 0x26B3530
        public void OnSetup(){} // RVA: 0x26B3570
        public void baseResize(){} // RVA: 0x26B35F0
        public void OnResize(){} // RVA: 0x26B3600
        public void GenerateEdgeMask(){} // RVA: 0x26B37B0
        public void OnGenerate(){} // RVA: 0x26B3890
        public void SetProperties(){} // RVA: 0x26B3C90
        public void EnsureMaskGenerator(){} // RVA: 0x26B3E90
        public void .ctor(){} // RVA: 0x26B40A0
    }

    public class DataSource : MonoBehaviour
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0xD33E60
        public void get_dataSourceParent(){} // RVA: 0xD05CA0
        public void DataSourceName(){} // RVA: 0x87C0A0
        public void GetChild(){} // RVA: 0xA94080
        public void ResetChildren(){} // RVA: 0x26B42E0
        public void AcquireResources(){} // RVA: 0xB43310
        public void FreeResources(){} // RVA: 0xB43310
        public void OnAwake(){} // RVA: 0xB43310
        public void OnCleanup(){} // RVA: 0xB43310
        public void OnSetup(){} // RVA: 0x87D280
        public void OnResize(){} // RVA: 0x87D280
        public void OnGenerate(){} // RVA: 0x87D280
        public void OnUpdate(){} // RVA: 0xB43310
        public void CanGenerate(){} // RVA: 0xC2E4C0
        public void Awake(){} // RVA: 0x26B4530
        public void Start(){} // RVA: 0x26B46F0
        public void ScheduleGenerate(){} // RVA: 0x26B4710
        public void ScheduleResize(){} // RVA: 0x26B4720
        public void UnscheduleGenerate(){} // RVA: 0x13D2170
        public void UnscheduleResize(){} // RVA: 0x26B4730
        public void OnEnable(){} // RVA: 0x26B4740
        public void OnDisable(){} // RVA: 0x26B4A20
        public void Reset(){} // RVA: 0x1D9AEF0
        public void Setup(){} // RVA: 0x26B4CD0
        public void Cleanup(){} // RVA: 0x26B4FA0
        public void Resize(){} // RVA: 0x26B53C0
        public void IsSetup(){} // RVA: 0xF73960
        public void Generate(){} // RVA: 0x26B5780
        public void Update(){} // RVA: 0x26B5B70
        public void LateUpdate(){} // RVA: 0x26B5B90
        public void .ctor(){} // RVA: 0x26B5BD0
    }

    public class DataSourceEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
        public void BeginInvoke(){} // RVA: 0xBA10C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class DataSourceEvents : Object
    {
        // ── Methods ──
        public void add_m_dataGenerated(){} // RVA: 0x26B5D40
        public void remove_m_dataGenerated(){} // RVA: 0x26B5E30
        public void add_dataGenerated(){} // RVA: 0x26B5F20
        public void remove_dataGenerated(){} // RVA: 0x26B60F0
        public void add_m_dataResized(){} // RVA: 0x26B6210
        public void remove_m_dataResized(){} // RVA: 0x26B6300
        public void add_dataResized(){} // RVA: 0x26B63F0
        public void remove_dataResized(){} // RVA: 0x26B65C0
        public void OnDataGenerated(){} // RVA: 0x26B66E0
        public void OnDataResized(){} // RVA: 0x26B6700
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DepthkitLookEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
        public void BeginInvoke(){} // RVA: 0xBA10C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class GaussianBlurFilter : Object
    {
        // ── Methods ──
        public void get_hasTexture(){} // RVA: 0x26C1120
        public void get_texture(){} // RVA: 0x26C1130
        public void CreateTextures(){} // RVA: 0x26C1160
        public void Setup(){} // RVA: 0x26C1550
        public void EnsureTextures(){} // RVA: 0x26C1620
        public void DoBlur(){} // RVA: 0x26C1890
        public void BlurPass(){} // RVA: 0x26C1A90
        public void Release(){} // RVA: 0x26C20D0
        public void .ctor(){} // RVA: 0x26C2270
        public void .cctor(){} // RVA: 0x26C2290
    }

    public class IPropertyTransfer
    {
        // ── Methods ──
        public void SetProperties(){} // RVA: 0x8943B0
    }

    public class IndexedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26B1B60
    }

    public class Info : Object
    {
        // ── Methods ──
        public void IsPlatformValid(){} // RVA: 0x26C2B20
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x26C2F50
    }

    public class Look : MonoBehaviour
    {
        // ── Methods ──
        public void EnsureMaterialPropertyBlock(){} // RVA: 0x26BC7C0
        public void get_materialPropertyBlock(){} // RVA: 0x26BC8D0
        public void GetLookName(){} // RVA: 0x87C0A0
        public void UsesMaterial(){} // RVA: 0x87D280
        public void GetMaterial(){} // RVA: 0x87C0A0
        public void UsesMaterialPropertyBlock(){} // RVA: 0xC2E4C0
        public void GetMaterialPropertyBlock(){} // RVA: 0x26BC8D0
        public void SetDataSources(){} // RVA: 0x894290
        public void ValidateDataSources(){} // RVA: 0x26BC8F0
        public void SetMaterialProperties(){} // RVA: 0xB43310
        public void OnUpdate(){} // RVA: 0x26BC9C0
        public void SetDefaults(){} // RVA: 0x26BC9E0
        public void SetLookProperties(){} // RVA: 0x26BCA80
        public void Awake(){} // RVA: 0x26BD3E0
        public void Init(){} // RVA: 0x26BD610
        public void Start(){} // RVA: 0x26BD950
        public void OnEnable(){} // RVA: 0x26BD980
        public void OnDisable(){} // RVA: 0x26BDAB0
        public void SyncColliderToBounds(){} // RVA: 0x26BDCD0
        public void OnMetaDataUpdated(){} // RVA: 0x26BE190
        public void LateUpdate(){} // RVA: 0x26BE1A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class MaskGenerator : Object
    {
        // ── Methods ──
        public void get_perspectivesToSlice(){} // RVA: 0xBE58B0
        public void set_perspectivesToSlice(){} // RVA: 0xCA4DF0
        public void get_sliceToPerspective(){} // RVA: 0xC0FFC0
        public void set_sliceToPerspective(){} // RVA: 0xC0FFD0
        public void get_sliceCount(){} // RVA: 0x26B6720
        public void set_sliceCount(){} // RVA: 0x26B6740
        public void get_blurRadius(){} // RVA: 0x26B6750
        public void set_blurRadius(){} // RVA: 0x26B6770
        public void get_paddedUVScaleFactor(){} // RVA: 0x26B6790
        public void get_maskTexture(){} // RVA: 0x26B6980
        public void get_downScale(){} // RVA: 0xD34730
        public void set_downScale(){} // RVA: 0x26B69D0
        public void get_downScaledMaskTexture(){} // RVA: 0x26B6A50
        public void DownScalePass(){} // RVA: 0x26B6AC0
        public void DownScaleMaskTexture(){} // RVA: 0x26B6C90
        public void Setup(){} // RVA: 0x26B7980
        public void EnsureTexture(){} // RVA: 0x26B7EB0
        public void Release(){} // RVA: 0x26B8190
        public void SobelFilterMask(){} // RVA: 0x26B8350
        public void BlurMask(){} // RVA: 0x26B8630
        public void GenerateMask(){} // RVA: 0x26B8670
        public void SetProperties(){} // RVA: 0x26B8E50
        public void .ctor(){} // RVA: 0x26B9350
    }

    public class MeshSource : DataSource
    {
        // ── Methods ──
        public void GetSubMesh(){} // RVA: 0xA94080
        public void CurrentSubMesh(){} // RVA: 0xA94080
        public void ReserveSubMeshes(){} // RVA: 0x8944F0
        public void get_currentSubmeshIndex(){} // RVA: 0x25406F0
        public void set_currentSubmeshIndex(){} // RVA: 0x2540700
        public void get_triangleBuffer(){} // RVA: 0x26B9840
        public void get_triangleBufferDispatchIndirectArgs(){} // RVA: 0x26B9890
        public void get_triangleBufferDrawIndirectArgs(){} // RVA: 0x26B98E0
        public void get_maxSurfaceTriangles(){} // RVA: 0x26B9930
        public void set_maxSurfaceTriangles(){} // RVA: 0x26B9980
        public void get_useTriangleMesh(){} // RVA: 0xBC03E0
        public void set_useTriangleMesh(){} // RVA: 0x26B99E0
        public void get_triangleMesh(){} // RVA: 0x26B9A40
        public void EnsureRadialBias(){} // RVA: 0x26B9A80
        public void AcquireResources(){} // RVA: 0x26B9D50
        public void FreeResources(){} // RVA: 0x26B9E20
        public void CanGenerate(){} // RVA: 0x26B9EA0
        public void OnSetup(){} // RVA: 0x26B9FA0
        public void OnResize(){} // RVA: 0x26BA110
        public void OnUpdate(){} // RVA: 0x26BA3D0
        public void OnGenerate(){} // RVA: 0x26BA5A0
        public void GetLocalBounds(){} // RVA: 0x26BA890
        public void GetWorldBounds(){} // RVA: 0x26BAA60
        public void Pause(){} // RVA: 0x26BADB0
        public void Continue(){} // RVA: 0x26BAE40
        public void OnBecameVisible(){} // RVA: 0x26BAEE0
        public void OnBecameInvisible(){} // RVA: 0x26BAF00
        public void CheckVisibility(){} // RVA: 0x26BAF20
        public void SetProperties(){} // RVA: 0x26BB190
        public void .ctor(){} // RVA: 0x26BB2A0
    }

    public class Metadata : Object
    {
        // ── Methods ──
        public void Valid(){} // RVA: 0x26C2FA0
        public void get_perspectiveCPPResolution(){} // RVA: 0x26C2FC0
        public void get_perspectiveResolution(){} // RVA: 0x26C3030
        public void get_paddedTextureDimensions(){} // RVA: 0x26C30B0
        public void FromSinglePerspective(){} // RVA: 0x26C3130
        public void CreateFromJSON(){} // RVA: 0x26C3410
        public void FillPersistentMetadataFromPerspectives(){} // RVA: 0x26C3FE0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x26C4300
    }

    public class PackedCoreTriangleSubMesh : SubMesh`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26B1B30
    }

    public class PerspectiveColorBlending : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x26D2CB0
    }

    public class PerspectiveColorBlendingData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26D2D80
        public void GetViewDependentColorBlendContribution(){} // RVA: 0x26D3000
        public void SetViewDependentColorBlendContribution(){} // RVA: 0x26D3040
        public void GetEdgeMaskBlendEdgeMin(){} // RVA: 0x26D3100
        public void SetEdgeMaskBlendEdgeMin(){} // RVA: 0x26D3140
        public void GetEdgeMaskStrength(){} // RVA: 0x26D3200
        public void SetEdgeMaskStrength(){} // RVA: 0x26D3240
        public void GetEdgeMaskBlendEdgeMax(){} // RVA: 0x26D3300
        public void SetEdgeMaskBlendEdgeMax(){} // RVA: 0x26D3340
        public void GetEdgeMaskEnabled(){} // RVA: 0x26D3400
        public void SetEdgeMaskEnabled(){} // RVA: 0x26D3450
        public void GetPerspectiveEnabled(){} // RVA: 0x26D3500
        public void SetPerspectiveEnabled(){} // RVA: 0x26D3540
    }

    public class PerspectiveColorBlending[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PerspectiveGeometry : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x26D35E0
    }

    public class PerspectiveGeometryData : SyncedStructuredBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26D36B0
        public void EnableGeometry(){} // RVA: 0x26D3A50
        public void GetOverrideWeightUnknown(){} // RVA: 0x26D3AF0
        public void SetOverrideWeightUnknown(){} // RVA: 0x26D3B30
        public void GetWeightUnknown(){} // RVA: 0x26D3100
        public void SetWeightUnknown(){} // RVA: 0x26D3BD0
        public void MatchViewDependentColorWeight(){} // RVA: 0x26D3CC0
        public void GetViewDependentContribution(){} // RVA: 0x26D3CF0
        public void SetViewDependentContribution(){} // RVA: 0x26D3D20
        public void GetViewDependentWeight(){} // RVA: 0x26D3000
        public void SetViewDependentWeight(){} // RVA: 0x26D3D70
        public void GetViewDependentInFrontAmount(){} // RVA: 0x26D3200
        public void SetViewDependentInFrontAmount(){} // RVA: 0x26D3E30
        public void GetViewDependentUnseenAmount(){} // RVA: 0x26D3300
        public void SetViewDependentUnseenAmount(){} // RVA: 0x26D3EF0
    }

    public class PerspectiveGeometry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlatformValidator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x26C4460
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class PlayerEvents : Object
    {
        // ── Methods ──
        public void add_playbackStarted(){} // RVA: 0x26BEEC0
        public void remove_playbackStarted(){} // RVA: 0x26BEFB0
        public void add_playbackPaused(){} // RVA: 0x26BF0A0
        public void remove_playbackPaused(){} // RVA: 0x26BF190
        public void add_playbackStopped(){} // RVA: 0x26BF280
        public void remove_playbackStopped(){} // RVA: 0x26BF370
        public void add_loadingStarted(){} // RVA: 0x26BF460
        public void remove_loadingStarted(){} // RVA: 0x26BF550
        public void add_loadingFinished(){} // RVA: 0x26BF640
        public void remove_loadingFinished(){} // RVA: 0x26BF730
        public void OnClipPlaybackStarted(){} // RVA: 0x26B66E0
        public void OnClipPlaybackPaused(){} // RVA: 0x26B6700
        public void OnClipPlaybackStopped(){} // RVA: 0x26AD960
        public void OnClipLoadingStarted(){} // RVA: 0x26AD9A0
        public void OnClipLoadingFinished(){} // RVA: 0x26AD980
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ProceduralLook : Look
    {
        // ── Methods ──
        public void UsesMaterial(){} // RVA: 0xC2E4C0
        public void GetMaterial(){} // RVA: 0xBBFF90
        public void UsesMaterialPropertyBlock(){} // RVA: 0xC2E4C0
        public void SetMaterialProperties(){} // RVA: 0x26BE410
        public void OnUpdate(){} // RVA: 0x26BEAF0
        public void .ctor(){} // RVA: 0x26BC770
    }

    public class SetCaptureFrameRate : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x26C4670
        public void Update(){} // RVA: 0x26C4680
        public void LateUpdate(){} // RVA: 0x26C46A0
        public void .ctor(){} // RVA: 0x26C46C0
    }

    public class StudioLiteLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x26D6020
        public void GetLookName(){} // RVA: 0x26D6CD0
        public void SetDefaults(){} // RVA: 0x26D6D10
        public void SetDataSources(){} // RVA: 0x26D7470
        public void OnUpdate(){} // RVA: 0x26D75C0
        public void .ctor(){} // RVA: 0x26D7920
    }

    public class StudioLiteMeshSource : CoreMeshSource
    {
        // ── Methods ──
        public void GetComputeShaderName(){} // RVA: 0x26D4120
        public void GetKernelNamePostfix(){} // RVA: 0x26D4160
        public void GenerateTriangles(){} // RVA: 0x26D4270
        public void DataSourceName(){} // RVA: 0x26D49D0
        public void OnResize(){} // RVA: 0x26D4A10
        public void GenerateEdgeMask(){} // RVA: 0x26D4D50
        public void OnGenerate(){} // RVA: 0x26D4E40
        public void .ctor(){} // RVA: 0x26D5ED0
    }

    public class StudioLook : ProceduralLook
    {
        // ── Methods ──
        public void GetDefaultMaterial(){} // RVA: 0x26D2710
        public void GetLookName(){} // RVA: 0x26D29F0
        public void SetDataSources(){} // RVA: 0x26D2A30
        public void SetDefaults(){} // RVA: 0x26D2B80
        public void .ctor(){} // RVA: 0x26BC770
    }

    public class StudioMeshSource : MeshSource
    {
        // ── Methods ──
        public void set_currentLevelOfDetailLevel(){} // RVA: 0x26CA660
        public void get_currentLevelOfDetailLevel(){} // RVA: 0x25C0CD0
        public void get_volumeBounds(){} // RVA: 0xDA1D20
        public void set_volumeBounds(){} // RVA: 0x26CA6E0
        public void GetLocalBounds(){} // RVA: 0xDA1D20
        public void get_volumeDensity(){} // RVA: 0x26CA7D0
        public void set_volumeDensity(){} // RVA: 0x26CA7E0
        public void get_numLevelOfDetailLevels(){} // RVA: 0x1AE6530
        public void set_numLevelOfDetailLevels(){} // RVA: 0x1CA09C0
        public void set_useTextureAtlas(){} // RVA: 0x135ADB0
        public void DataSourceName(){} // RVA: 0x26CA7F0
        public void GetScaledKernelName(){} // RVA: 0x26CA830
        public void GetExtractVolumeKernelName(){} // RVA: 0x26CAA60
        public void OnAwake(){} // RVA: 0x26CAC30
        public void OnSetup(){} // RVA: 0x26CADC0
        public void ResetGPUResources(){} // RVA: 0x26CB3A0
        public void AcquireResources(){} // RVA: 0x26CB400
        public void FreeResources(){} // RVA: 0x26CB690
        public void EnsureBuffers(){} // RVA: 0x26CBAE0
        public void EnsureTextures(){} // RVA: 0x26CBCA0
        public void EnsurePerPerspectiveBuffer(){} // RVA: 0xA94080
        public void EnsureSyncedBuffers(){} // RVA: 0x26CBF20
        public void SetupViewDependence(){} // RVA: 0x26CC190
        public void OnNewMetadata(){} // RVA: 0x26CC730
        public void ResetVolumeBounds(){} // RVA: 0x26CC920
        public void ResetSurfaceSensitivity(){} // RVA: 0x26CC9A0
        public void LoadFrontBiasedDefaults(){} // RVA: 0x26CCA70
        public void OnResize(){} // RVA: 0x26CCAB0
        public void SetProperties(){} // RVA: 0x26CD7F0
        public void SetCommonComputeProperties(){} // RVA: 0x26CD9D0
        public void SetVolumeGenerationPassProperties(){} // RVA: 0x26CDF50
        public void FilterSdf(){} // RVA: 0x26CE1B0
        public void GenerateNormalWeights(){} // RVA: 0x26CE960
        public void GenerateNormalWeightsCompute(){} // RVA: 0x26CEB30
        public void GenerateEdgeBlendMask(){} // RVA: 0x26CEE20
        public void DispatchSize(){} // RVA: 0x26CEEA0
        public void GenerateVolumePass(){} // RVA: 0x26CEF50
        public void GenerateVolume(){} // RVA: 0x26CEFF0
        public void ActivePerspectives(){} // RVA: 0x26CF110
        public void GenerateVolumeMultiPass(){} // RVA: 0x26CF220
        public void GenerateVolumeSinglePass(){} // RVA: 0x26CF830
        public void ExtractSurfaceFromVolume(){} // RVA: 0x26CFA00
        public void DrawDebug(){} // RVA: 0x26CFE70
        public void OnGenerate(){} // RVA: 0x26D0690
        public void OnUpdate(){} // RVA: 0x26D0C00
        public void EnsureMaskGenerator(){} // RVA: 0x26D1500
        public void get_enableEdgeMask(){} // RVA: 0x26D17A0
        public void set_enableEdgeMask(){} // RVA: 0x26D17C0
        public void .ctor(){} // RVA: 0x26D17D0
        public void .cctor(){} // RVA: 0x26D1A00
    }

    public class SubMesh : Object
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x87C130
        public void get_triangleBuffer(){} // RVA: 0xB465B0
        public void get_trianglesCount(){} // RVA: 0xB700F0
        public void get_dispatchIndirectArgs(){} // RVA: 0xB70160
        public void get_drawIndirectArgs(){} // RVA: 0xD33E60
        public void Init(){} // RVA: 0x26BB3D0
        public void CopyTriangleCount(){} // RVA: 0x26BB490
        public void calculateMaxTrianglesNeeded(){} // RVA: 0x26BB510
        public void PrepareDrawArgs(){} // RVA: 0x26BB5C0
        public void PrepareDispatchArgs(){} // RVA: 0x26BB640
        public void EnsureBuffers(){} // RVA: 0x26BB6E0
        public void Release(){} // RVA: 0x26BBAC0
        public void set_source(){} // RVA: 0xD09D70
        public void get_triangleMesh(){} // RVA: 0x26BBCB0
        public void SetProperties(){} // RVA: 0x26BBF50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubMesh[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0x894290
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x4BA4B40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubMesh`1 : SubMesh
    {
        // ── Methods ──
        public void GetDataTypeSizeInBytes(){} // RVA: 0x4BA4A90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void F(){} // RVA: 0xD06C518
        public void .ctor(){} // RVA: 0x4BA5BD0
        public void get_Length(){} // RVA: 0x4BA5D40
        public void MarkDirty(){} // RVA: 0x1B68750
        public void Sync(){} // RVA: 0x4BA5F90
        public void Release(){} // RVA: 0x4BA5F00
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894600
        public void get_Length(){} // RVA: 0x87C130
        public void MarkDirty(){} // RVA: 0x894290
        public void Sync(){} // RVA: 0x87D280
        public void Release(){} // RVA: 0x894290
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA5BD0
        public void get_Length(){} // RVA: 0x4BA5D40
        public void MarkDirty(){} // RVA: 0x1B68750
        public void Sync(){} // RVA: 0x4BA6470
        public void Release(){} // RVA: 0x4BA5F00
    }

    public class SyncedStructuredBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA5BD0
        public void get_Length(){} // RVA: 0x4BA5D40
        public void MarkDirty(){} // RVA: 0x1B68750
        public void Sync(){} // RVA: 0x4BA5D60
        public void Release(){} // RVA: 0x4BA5F00
    }

    public class TriangleMesh : Object
    {
        // ── Methods ──
        public void get_TriangleCount(){} // RVA: 0xFEAE90
        public void set_TriangleCount(){} // RVA: 0x26C4710
        public void get_mesh(){} // RVA: 0x26C4720
        public void EnsureTriangleMesh(){} // RVA: 0x26C5090
        public void CreateMesh(){} // RVA: 0x26C54E0
        public void ReleaseMesh(){} // RVA: 0x26C5570
        public void GetCubeVerts(){} // RVA: 0x26C5710
        public void GetCubeTriangles(){} // RVA: 0x26C58E0
        public void ResetMeshCube(){} // RVA: 0x26C59F0
        public void CreateLattice(){} // RVA: 0x26C5CE0
        public void addVertex(){} // RVA: 0x26C6170
        public void CreateTriangleLattice(){} // RVA: 0x26C6300
        public void CreateCubeMesh(){} // RVA: 0x26C6770
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityVideoPlayer : ClipPlayer
    {
        // ── Methods ──
        public void CreatePlayer(){} // RVA: 0x26BF820
        public void IsPlayerCreated(){} // RVA: 0x26BFDC0
        public void IsPlayerSetup(){} // RVA: 0x26BFE90
        public void SetVideoPath(){} // RVA: 0x26C0040
        public void GetVideoPath(){} // RVA: 0x26C0090
        public void StartVideoLoad(){} // RVA: 0x26C0130
        public void Load(){} // RVA: 0x26C0160
        public void OnVideoLoadingComplete(){} // RVA: 0x26C0200
        public void OnMetadataUpdated(){} // RVA: 0xB43310
        public void LoadAndPlay(){} // RVA: 0x26C0230
        public void Play(){} // RVA: 0x26C02D0
        public void Pause(){} // RVA: 0x26C03A0
        public void Stop(){} // RVA: 0x26C0470
        public void GetCurrentFrame(){} // RVA: 0x26C0540
        public void GetCurrentTime(){} // RVA: 0x26C05E0
        public void GetDuration(){} // RVA: 0x26C0680
        public void GetTexture(){} // RVA: 0x26C0730
        public void IsTextureFlipped(){} // RVA: 0xB43320
        public void GammaCorrectDepth(){} // RVA: 0x26C0750
        public void GammaCorrectColor(){} // RVA: 0x26C07A0
        public void IsPlaying(){} // RVA: 0x26C07F0
        public void RemoveComponents(){} // RVA: 0x26C0890
        public void GetPlayerTypeName(){} // RVA: 0x26C0A70
        public void GetPlayerPrettyName(){} // RVA: 0x26C0B10
        public void GetPlayerBackend(){} // RVA: 0xD33E60
        public void Seek(){} // RVA: 0x26C0B50
        public void GetVideoWidth(){} // RVA: 0x26C0C50
        public void GetVideoHeight(){} // RVA: 0x26C0D40
        public void SupportsPosterFrame(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x26BEDF0
    }

    public class Util : Object
    {
        // ── Methods ──
        public void NextMultipleOfX(){} // RVA: 0x26C6D90
        public void GetScaled2DKernelName(){} // RVA: 0x26C6DB0
        public void GetScaled3DKernelName(){} // RVA: 0x26C6FE0
        public void DispatchGroups(){} // RVA: 0x26C7160
        public void ClearRenderTexture(){} // RVA: 0x26C7300
        public void ClearAppendBuffer(){} // RVA: 0x26C7540
        public void ReleaseComputeBuffer(){} // RVA: 0x26C7900
        public void ReleaseRenderTexture(){} // RVA: 0x26C7970
        public void CopyFromRenderTextureSettings(){} // RVA: 0x26C7AC0
        public void ComposeExtrinsicsMatrix(){} // RVA: 0x26C7E60
        public void TransformBounds(){} // RVA: 0x26C80C0
        public void CreateRenderTexture(){} // RVA: 0x26C8450
        public void EnsureRenderTexture(){} // RVA: 0x26C85E0
        public void EnsureComputeBuffer(){} // RVA: 0x26C8B20
        public void ColorForCamera(){} // RVA: 0x26C8DA0
        public void RenderPerspectiveGizmo(){} // RVA: 0xB43310
        public void RenderMetadataGizmos(){} // RVA: 0xB43310
        public void IsVisible(){} // RVA: 0x26C8F60
        public void metersToCm(){} // RVA: 0x26C9200
        public void cmToMeters(){} // RVA: 0x26C9210
        public void EnsureKeyword(){} // RVA: 0x26C9220
        public void EnsureComputeShader(){} // RVA: 0x26C92B0
    }

    public class Version : ValueType
    {
        // ── Methods ──
        public void get_major(){} // RVA: 0x90520
        public void set_major(){} // RVA: 0x90530
        public void get_minor(){} // RVA: 0x90540
        public void set_minor(){} // RVA: 0x541E0
        public void get_patch(){} // RVA: 0x90550
        public void set_patch(){} // RVA: 0x54210
        public void .ctor(){} // RVA: 0x8C060
        public void ToString(){} // RVA: 0x90560
        public void op_Implicit(){} // RVA: 0x26C2820
        public void Equals(){} // RVA: 0x90610
        public void GetHashCode(){} // RVA: 0x90640
        public void op_Equality(){} // RVA: 0x26C2900
        public void op_Inequality(){} // RVA: 0x26C2930
        public void op_LessThan(){} // RVA: 0x26C2960
        public void op_GreaterThan(){} // RVA: 0x26C29B0
        public void op_LessThanOrEqual(){} // RVA: 0x26C2A00
        public void op_GreaterThanOrEqual(){} // RVA: 0x26C2A90
    }

}