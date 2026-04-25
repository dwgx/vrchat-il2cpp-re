// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Rendering
// Classes: 13
// Methods: 209

namespace VRC.Rendering
{
    /// <summary>Originally: ÎÌÌÌÏÏÌÏÌÌÌÍÍÏÎÏÏÌÏÏÎÌÍ</summary>
    public class CameraPositionCanWrite_BE89 : Stream
    {
        public ÏÍÌÎÌÌÏÍÏÎÏÌÏÌÍÏÍÎÌÍÏÌÏ _position; // 0x28

        // ── Methods ──
        public void get_Position(){} // RVA: 0x7FFD4F911B50
        public void get_CanWrite(){} // RVA: 0x7FFD4F911BB0
        public void set_CanWrite(){} // RVA: 0x7FFD4F911BE0
        public void .ctor(){} // RVA: 0x7FFD4F9120A0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4F911BE0
        public void BeginRead(){} // RVA: 0x7FFD4F911C20
        public void Read(){} // RVA: 0x7FFD4F911CC0
        public void set_CanSeek(){} // RVA: 0x7FFD4F911BE0
        public void get_ReadTimeout(){} // RVA: 0x7FFD4F911D60
        public void EndRead(){} // RVA: 0x7FFD4F911EE0
        public void SetLength(){} // RVA: 0x7FFD4F911F70
        public void get_CanSeek(){} // RVA: 0x7FFD4F911FD0
        public void BeginWrite(){} // RVA: 0x7FFD4F912000
        public void Dispose(){} // RVA: 0x7FFD4F912320
        public void Cleanup(){} // RVA: 0x7FFD4F911BE0
        public void CopyTo(){} // RVA: 0x7FFD4F911BE0
        public void Seek(){} // RVA: 0x7FFD4F9123F0
        public void Flush(){} // RVA: 0x7FFD4F912450
        public void Close(){} // RVA: 0x7FFD4F9124F0
        public void Write(){} // RVA: 0x7FFD4F912670
        public void set_CanRead(){} // RVA: 0x7FFD4F912710
        public void get_CanRead(){} // RVA: 0x7FFD4F912890
        public void EndWrite(){} // RVA: 0x7FFD4F9128C0
        public void get_Length(){} // RVA: 0x7FFD4F912950
        public void set_Position(){} // RVA: 0x7FFD4F9129B0
    }

    /// <summary>Originally: ÏÍÌÎÌÌÏÍÏÎÏÌÏÌÍÏÍÎÌÍÏÌÏ</summary>
    public class CameraPosition_DAF2 : Stream
    {
        public int _length;
        public System.IO.Stream _canSeek; // 0x28
        public 0x66373EE0 _canRead; // 0x30
        public bool _position; // 0x34
        public ÎÏÍÍÏÍÏÏÍÍÎÎÏÏÍÏÍÏÍÏÎÍÏ _canWrite; // 0x38
        public ÌÍÍÏÍÍÍÌÏÍÍÎÍÍÌÍÎÌÎÏÍÎÍ _position2; // 0x40
        public byte[] ÍÌÏÎÎÎÎÎÏÍÎÍÎÌÏÍÎÌÏÍÎÎÍ; // 0x48
        public int ÌÎÍÍÎÎÌÎÏÌÏÍÎÏÌÌÍÍÏÍÎÏÎ; // 0x50
        public 0x6641E4D0 ÍÎÎÌÏÌÎÎÌÏÍÏÌÍÌÍÍÎÎÎÌÎÌ; // 0x58
        public ÏÏÏÍÏÎÎÏÍÎÍÌÌÎÏÎÌÌÏÍÍÍÎ ÍÏÏÏÌÍÎÌÏÍÌÏÍÌÌÍÎÍÏÏÏÎÌ; // 0x60
        public ÍÏÎÌÍÌÏÎÌÎÍÍÏÏÏÎÌÏÏÍÍÏÍ ÎÍÍÍÏÎÍÏÍÌÎÏÏÌÌÌÍÎÍÍÏÎÍ; // 0x68
        public bool ÏÍÍÏÏÏÎÏÍÍÎÍÎÎÏÍÍÌÏÏÏÍÌ; // 0x70
        public bool ÎÌÍÍÍÌÎÍÌÎÏÌÍÎÎÏÎÍÍÏÍÏÌ; // 0x71

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFD4F909C00
        public void SetLength(){} // RVA: 0x7FFD4F909D70
        public void BeginRead(){} // RVA: 0x7FFD4F909DD0
        public void Read(){} // RVA: 0x7FFD4F90A0E0
        public void set_Length(){} // RVA: 0x7FFD4F90A270
        public void Dispose(){} // RVA: 0x7FFD4F90A420
        public void Cleanup(){} // RVA: 0x7FFD4F90A690
        public void get_Length(){} // RVA: 0x7FFD4F90A860
        public void get_CanSeek(){} // RVA: 0x7FFD4E341320
        public void set_CanSeek(){} // RVA: 0x7FFD4E341320
        public void set_CanRead(){} // RVA: 0x7FFD4F90A8C0
        public void get_CanRead(){} // RVA: 0x7FFD4F90A910
        public void CopyToAsync(){} // RVA: 0x7FFD4F90A940
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void Write(){} // RVA: 0x7FFD4F90A9C0
        public void CopyToAsyncInternal(){} // RVA: 0x7FFD4F90AB40
        public void CopyTo(){} // RVA: 0x7FFD4F90AC90
        public void Seek(){} // RVA: 0x7FFD4F90ACE0
        public void GetCopyBufferSize(){} // RVA: 0x7FFD4F90AD40
        public void Flush(){} // RVA: 0x7FFD4F90ADD0
        public void Close(){} // RVA: 0x7FFD4F90ADE0
        public void TryGetCameraPosition(){} // RVA: 0x7FFD4F90AFD0
        public void Flush_1D59EC004759(){} // RVA: 0x7FFD4F90B100
        public void EndWrite(){} // RVA: 0x7FFD4F90B180
        public void .ctor(){} // RVA: 0x7FFD4F90C420 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4F90B2D0
        public void BeginReadInternal(){} // RVA: 0x7FFD4F90B350
        public void GetCachedPtr(){} // RVA: 0x7FFD4F90B3D0
        public void ReadAsync(){} // RVA: 0x7FFD4F90B540
        public void ReadAsync_5E139461BC2D(){} // RVA: 0x7FFD4F90B5C0
        public void set_CanWrite(){} // RVA: 0x7FFD4F90B730
        public void set_Position(){} // RVA: 0x7FFD4F90B960
        public void get_Position(){} // RVA: 0x7FFD4F90B9C0
        public void BeginWriteInternal(){} // RVA: 0x7FFD4F90BA20
        public void get_CanWrite(){} // RVA: 0x7FFD4F90BC40
        public void RunReadWriteTask(){} // RVA: 0x7FFD4F90BC70
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFD4F90BD50
        public void EndWrite_C5A0A3AA16EA(){} // RVA: 0x7FFD4E341320
        public void BeginWrite(){} // RVA: 0x7FFD4F90C010
        public void WriteAsync(){} // RVA: 0x7FFD4F90C260
        public void EndRead(){} // RVA: 0x7FFD4F90C2C0
        public void BeginEndWriteAsync(){} // RVA: 0x7FFD4F90C970
    }

    /// <summary>Originally: ÍÏÎÎÏÎÌÌÍÎÎÏÍÎÏÌÎÏÍÏÍÏÍ</summary>
    public class EffectmaterialForRenderingGetMaterial_5E1C : Texturetext_35E1
    {
        public ÌÏÍÍÏÌÌÎÎÍÏÍÎÍÍÎÌÌÎÍÏÎÍ _materialForRendering; // 0x7E8
        public bool ÏÍÎÎÍÎÍÎÎÍÏÍÍÏÎÏÍÎÍÎÍÌÎ; // 0x7F0

        // ── Methods ──
        public void GetMaterial_7084143CFF13(){} // RVA: 0x7FFD4E520600
        public void UpdateGameObjectActiveState(){} // RVA: 0x7FFD4E5207E0
        public void GetMaterial(){} // RVA: 0x7FFD4E5209E0
        public void get_fontWeight(){} // RVA: 0x7FFD4E520B70
        public void InitializePurchaseFlow(){} // RVA: 0x7FFD4E520D70
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E520F50
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E521100
        public void .ctor(){} // RVA: 0x7FFD4E5212B0
        public void Initialize(){} // RVA: 0x7FFD4E521300
        public void Rebuild(){} // RVA: 0x7FFD4E521500
        public void set_materialForRendering(){} // RVA: 0x7FFD4E521670
        public void get_materialForRendering(){} // RVA: 0x7FFD4E521A50
        public void DelayedMaterialRebuild(){} // RVA: 0x7FFD4E521A70
        public void Rebuild_BD5732C4DB70(){} // RVA: 0x7FFD4E521C20
    }

    /// <summary>Originally: ÌÌÍÎÎÍÌÎÎÍÏÍÌÍÎÏÌÌÏÌÍÎÎ</summary>
    public class PopulateMesh_0AD8 : Image
    {
        public int _sides; // 0x118
        public float _radius; // 0x11C
        public float _thickness; // 0x120
        public float _uvRangeX; // 0x124
        public bool _useRadialFill; // 0x128
        public float ÌÎÎÎÌÍÏÎÍÌÍÎÌÎÍÌÍÍÍÏÎÍÏ;

        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x7FFD4EB2C100
        public void set_image(){} // RVA: 0x7FFD4EB2C360
        public void get_sprite(){} // RVA: 0x7FFD4EB2C3B0
        public void set_sprite(){} // RVA: 0x7FFD4EB2C8A0
        public void get_vectorImage(){} // RVA: 0x7FFD4EB139E0
        public void set_vectorImage(){} // RVA: 0x7FFD4EB2CD60
        public void get_sourceRect(){} // RVA: 0x7FFD4EB2CDB0
        public void .ctor(){} // RVA: 0x7FFD4EB2D2B0
        public void Initialize(){} // RVA: 0x7FFD4EB2D370
    }

    /// <summary>Originally: ÏÍÏÌÎÍÎÏÎÎÎÏÍÍÎÏÎÏÌÌÍÍÍ</summary>
    public class PopulateMesh_15B3 : Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFD4EB29060
        public void set_image(){} // RVA: 0x7FFD4EB29650
        public void get_sprite(){} // RVA: 0x7FFD4EB29C40
        public void .ctor(){} // RVA: 0x7FFD4EB2A230
        public void Initialize(){} // RVA: 0x7FFD4EB2A2C0
        public void set_vectorImage(){} // RVA: 0x7FFD4EB2A3B0
        public void get_sourceRect(){} // RVA: 0x7FFD4EB2A4A0
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFD4EB16210
        public void set_uv(){} // RVA: 0x7FFD4EB2A590
        public void get_scaleMode(){} // RVA: 0x7FFD4EB2AB80
        public void OnPopulateMesh(){} // RVA: 0x7FFD4EB2AC70
    }

    /// <summary>Originally: ÏÍÏÌÎÍÎÌÎÎÌÌÎÎÌÎÍÍÎÎÍÏÍ</summary>
    public class PopulateMesh_1894 : MaskableGraphic
    {
        public float ÏÏÌÏÏÍÌÌÌÏÏÌÌÍÎÍÍÎÎÏÍÎÎ; // 0xE0

        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x7FFD4FA66F00
        public void set_onCullStateChanged(){} // RVA: 0x7FFD4FA67080
        public void get_maskable(){} // RVA: 0x7FFD4FA67480
        public void set_maskable(){} // RVA: 0x7FFD4FA67880
        public void get_isMaskingGraphic(){} // RVA: 0x7FFD4FA67C80
        public void set_isMaskingGraphic(){} // RVA: 0x7FFD4FA68080
        public void GetModifiedMaterial(){} // RVA: 0x7FFD4FA68480
        public void .ctor(){} // RVA: 0x7FFD4FA68880
        public void Initialize(){} // RVA: 0x7FFD4FA68890
    }

    /// <summary>Originally: ÌÏÎÏÎÏÏÎÏÏÎÏÌÎÍÌÌÏÍÍÎÎÏ</summary>
    public class PopulateMesh_269E : Image
    {
        public 0x663980B8 _mirrorMode; // 0x118
        public bool _flipMirrored; // 0x11C
        public float _flipOffset; // 0x120
        public UnityEngine.Vector2[] ÏÏÎÍÏÎÍÎÏÏÎÎÌÎÍÌÎÏÎÌÏÎÍ;
        public UnityEngine.Vector2[] ÏÍÌÏÎÌÏÏÏÌÎÎÏÎÎÌÎÏÏÌÍÎÍ; // 0x8

        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFD4EB14600
        public void OnPopulateMesh(){} // RVA: 0x7FFD4EB146F0
        public void get_sprite(){} // RVA: 0x7FFD4EB15340
        public void set_sprite(){} // RVA: 0x7FFD4EB155B0
        public void get_vectorImage(){} // RVA: 0x7FFD4EB15820
        public void set_vectorImage(){} // RVA: 0x7FFD4EB158C0
        public void GetAdjustedBorders(){} // RVA: 0x7FFD4EB159B0
        public void .cctor(){} // RVA: 0x7FFD4EB15CF0
        public void set_uv(){} // RVA: 0x7FFD4EB15E30
        public void .ctor(){} // RVA: 0x7FFD4EB15F20
        public void AddQuad(){} // RVA: 0x7FFD4EB15FB0
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFD4EB16210
        public void GetTextureDisplaySize(){} // RVA: 0x7FFD4EB15820
        public void ApplyMeshSpriteColor(){} // RVA: 0x7FFD4EB16300
    }

    /// <summary>Originally: ÏÌÎÏÌÏÌÍÏÍÎÍÍÌÏÏÌÏÎÎÍÍÎ</summary>
    public class PopulateMesh_D259 : MaskableGraphic
    {
        public UnityEngine.Color _geometryColor; // 0xE0
        public UnityEngine.Mesh _inputMesh; // 0xF0
        public float _yScalingRatio; // 0xF8
        public System.Collections.Generic.List`1<UnityEngine.Vector2> ÌÍÌÏÎÍÎÍÎÏÌÌÍÎÌÌÎÍÍÍÏÎÏ; // 0x100
        public System.Collections.Generic.List`1<UnityEngine.UIVertex> ÌÏÌÏÎÌÎÏÏÌÌÌÏÏÏÏÍÍÍÍÎÎÌ; // 0x108
        public System.Collections.Generic.List`1<int> ÎÍÍÌÌÎÏÎÎÌÏÎÍÎÏÎÎÍÍÌÎÍÎ; // 0x110
        public System.Collections.Generic.List`1<UnityEngine.Vector3> ÌÌÌÎÍÎÍÎÏÏÌÎÍÎÍÏÏÏÍÌÏÏÎ;
        public System.Collections.Generic.List`1<UnityEngine.Vector2> ÎÍÎÏÍÎÍÎÎÌÌÏÏÍÍÏÏÌÍÏÌÏÌ; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4EB12A00
        public void OnEnable(){} // RVA: 0x7FFD4EB12C80
        public void OnDisable(){} // RVA: 0x7FFD4EB13690
        public void OnPopulateMesh(){} // RVA: 0x7FFD4EB136E0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFD4EB139E0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFD4EB13A20
        public void GetModifiedMaterial(){} // RVA: 0x7FFD4EB13A70
        public void Cull(){} // RVA: 0x7FFD4EB13AC0
        public void .ctor(){} // RVA: 0x7FFD4EB13B10
        public void Initialize(){} // RVA: 0x7FFD4EB13B30
        public void SetClipSoftness(){} // RVA: 0x7FFD4EB13B80
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EB13BD0
    }

    /// <summary>Originally: ÎÍÎÍÍÏÌÎÍÏÌÎÌÎÏÏÎÌÌÏÌÎÏ</summary>
    public class SetMaterialDirtySetVerticesDirty_FBD6 : Text
    {
        public bool ÎÌÏÍÌÎÍÍÎÍÎÌÌÏÎÎÏÎÍÌÏÎÏ; // 0x110
        public System.Text.RegularExpressions.Regex ÎÏÍÍÌÌÏÎÍÎÎÏÌÌÎÌÎÍÎÌÌÌÍ; // 0x118

        // ── Methods ──
        public void GetisDone(){} // RVA: 0x7FFD4EE8B770
        public void get_cachedTextGenerator(){} // RVA: 0x7FFD4EE8B990
        public void SetLayoutDirty(){} // RVA: 0x7FFD4EE8BBB0
        public void get_mainTexture(){} // RVA: 0x7FFD4EE8BC60
        public void FontTextureChanged(){} // RVA: 0x7FFD4EE8BE80
        public void OnPopulateMesh(){} // RVA: 0x7FFD4EE8C0A0
        public void set_font(){} // RVA: 0x7FFD4EE8C150
        public void get_text(){} // RVA: 0x7FFD4EE8C370
        public void set_text(){} // RVA: 0x7FFD4EE8C590
        public void get_supportRichText(){} // RVA: 0x7FFD4EE8C7B0
        public void SetMaterialDirty(){} // RVA: 0x7FFD4EE8C9D0
        public void SetVerticesDirty(){} // RVA: 0x7FFD4EE8CA70
        public void .ctor(){} // RVA: 0x7FFD4EE8CB10
        public void Initialize(){} // RVA: 0x7FFD4EE8CD50
    }

    /// <summary>Originally: ÌÏÍÍÍÎÎÏÎÌÍÎÎÌÏÍÍÏÍÍÌÍÍ</summary>
    public class mainTexturePopulateMeshSibling_7840 : MonoBehaviour
    {
        public UnityEngine.UI.RawImage _destroyCancellationToken; // 0x20
        public ÏÍÏÌÎÎÏÌÏÌÍÎÏÌÎÏÍÎÍÌÏÏÍ _useGUILayout; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F850B10
        public void RaiseCancellation(){} // RVA: 0x7FFD4F850B50
        public void IsInvoking(){} // RVA: 0x7FFD4F850B70
        public void CancelInvoke(){} // RVA: 0x7FFD4F850B50
        public void Invoke(){} // RVA: 0x7FFD4F850C10
        public void InvokeRepeating(){} // RVA: 0x7FFD4F850DF0
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFD4F850E30
        public void IsInvoking_DA83566997EF(){} // RVA: 0x7FFD4F850FD0
        public void StartCoroutine(){} // RVA: 0x7FFD4F850B50
        public void .ctor_CC8F710061D9(){} // RVA: 0x7FFD4F850FF0
        public void Initialize(){} // RVA: 0x7FFD4F8511A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F851200
        public void StopCoroutine(){} // RVA: 0x7FFD4F8513E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize_849DE918F0A9(){} // RVA: 0x7FFD4F8511A0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F851570
        public void get_useGUILayout(){} // RVA: 0x7FFD4F8511A0
        public void set_useGUILayout(){} // RVA: 0x7FFD4F851600
    }

    /// <summary>Originally: ÍÍÌÌÍÌÌÏÎÌÎÏÌÏÎÌÍÌÎÏÎÎÎ</summary>
    public class mainTexturePopulateMesh_1388 : MaskableGraphic
    {
        public UnityEngine.Sprite _mainTexture; // 0xE0
        public float ÌÌÍÌÎÎÎÏÎÏÌÎÌÌÍÍÍÎÎÍÎÏÎ; // 0xE8
        public float ÌÎÌÏÌÌÏÎÍÏÍÌÏÏÏÍÏÍÎÍÏÍÎ; // 0xEC
        public float ÏÎÎÍÏÎÍÏÏÌÍÏÍÏÏÎÍÍÌÎÏÌÏ; // 0xF0
        public float ÎÌÎÎÌÏÍÎÌÌÏÏÍÎÎÌÏÌÏÌÍÏÌ; // 0xF4
        public float ÍÌÌÌÌÌÏÎÍÎÍÌÍÍÎÍÎÌÍÍÍÎÏ; // 0xF8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FA68880
        public void Initialize(){} // RVA: 0x7FFD56BCFAF0
        public void set_mainTexture(){} // RVA: 0x7FFD56BCFAF0
        public void get_mainTexture(){} // RVA: 0x7FFD56BCFBD0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFD56BCFAF0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFD56BCFAF0
        public void OnPopulateMesh(){} // RVA: 0x7FFD56BCFD40
        public void Cull(){} // RVA: 0x7FFD56BCFAF0
        public void UpdateCull(){} // RVA: 0x7FFD56BCFAF0
        public void SetClipRect(){} // RVA: 0x7FFD56BCFAF0
        public void SetClipSoftness(){} // RVA: 0x7FFD56BCFAF0
        public void OnEnable(){} // RVA: 0x7FFD56BCFAF0
    }

    /// <summary>Originally: ÍÎÏÍÏÍÌÏÏÍÏÍÏÍÌÏÏÌÏÎÎÎÏ</summary>
    public class mainTexturePopulateMesh_3A32 : MaskableGraphic
    {
        public float _mainTexture; // 0xE0
        public float _maskable; // 0xE4
        public float ÎÎÍÏÎÌÍÌÌÍÍÏÌÍÌÌÏÎÍÏÍÏÍ; // 0xE8
        public float ÌÏÌÍÏÌÏÏÏÏÍÎÎÍÏÎÏÏÍÎÌÍÎ; // 0xEC
        public float ÍÏÍÍÌÍÏÍÏÎÌÎÌÌÎÏÍÌÌÍÎÏÍ;
        public UnityEngine.Texture _texture; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56D9E050
        public void get_ipsQuery(){} // RVA: 0x7FFD4E3AC2A0
        public void get_maskable(){} // RVA: 0x7FFD56D9E070
        public void set_maskable(){} // RVA: 0x7FFD56D9E220
        public void set_mainTexture(){} // RVA: 0x7FFD4E3AC2A0
        public void get_mainTexture(){} // RVA: 0x7FFD4E3AC2A0
        public void GetModifiedMaterial(){} // RVA: 0x7FFD4E3AC2A0
        public void OnPopulateMesh(){} // RVA: 0x7FFD56D9E3D0
        public void UpdateCull(){} // RVA: 0x7FFD4E3AC2A0
        public void SetClipRect(){} // RVA: 0x7FFD56D9ECB0
        public void SetClipSoftness(){} // RVA: 0x7FFD56D9EE60
        public void OnEnable(){} // RVA: 0x7FFD56D9F010
    }

    /// <summary>Originally: ÎÏÎÎÌÎÍÍÏÏÎÏÎÌÏÎÏÍÌÌÌÎÎ</summary>
    public class mainTexturePopulateMesh_FA06 : MaskableGraphic
    {
        public UnityEngine.Sprite _mainTexture; // 0xE0
        public 0x6634DCB8 _maskable; // 0xE8
        public bool _isMaskingGraphic; // 0xEC
        public uint ShaderFeatureRectOffsetChannel; // 0xF0
        public bool ShaderFeatureMasking; // 0xF4
        public float yOffset; // 0xF8
        public float ÌÎÍÏÍÏÌÎÌÍÎÏÎÎÏÏÌÍÍÎÏÌÏ; // 0xFC

        // ── Methods ──
        public void get_fillAmount(){} // RVA: 0x7FFD4E5110F0
        public void get_mainTexture(){} // RVA: 0x7FFD4E511100
        public void OnPopulateMesh(){} // RVA: 0x7FFD4E511270
        public void .ctor(){} // RVA: 0x7FFD4E511FC0
        public void Initialize(){} // RVA: 0x7FFD4E511FE0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFD4E512050
        public void GetModifiedMaterial(){} // RVA: 0x7FFD4E5120A0
        public void Cull(){} // RVA: 0x7FFD4E512920
        public void UpdateCull(){} // RVA: 0x7FFD4E513180
        public void SetClipRect(){} // RVA: 0x7FFD4E5131B0
        public void get_domainList(){} // RVA: 0x7FFD4E3C2900
        public void OnEnable(){} // RVA: 0x7FFD4E513360
        public void OnDisable(){} // RVA: 0x7FFD4E5110F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFD4E5110F0
        public void ParentMaskStateChanged(){} // RVA: 0x7FFD4E511FE0
    }

}