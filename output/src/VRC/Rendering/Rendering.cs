// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Rendering
// Classes: 14
// Methods: 224

namespace VRC.Rendering
{
    /// <summary>Originally: ÎÌÌÌÏÏÌÏÌÌÌÍÍÏÎÏÏÌÏÏÎÌÍ</summary>
    public class CameraPositionCanWrite_BE89_BE89 : Stream
    {
        public ÏÍÌÎÌÌÏÍÏÎÏÌÏÌÍÏÍÎÌÍÏÌÏ _position; // 0x28

        // ── Methods ──
        public void get_Position(){} // RVA: 0x7FFAC44F1B50
        public void get_CanWrite(){} // RVA: 0x7FFAC44F1BB0
        public void set_CanWrite(){} // RVA: 0x7FFAC44F1BE0
        public void .ctor(){} // RVA: 0x7FFAC44F20A0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC44F1BE0
        public void BeginRead(){} // RVA: 0x7FFAC44F1C20
        public void Read(){} // RVA: 0x7FFAC44F1CC0
        public void set_CanSeek(){} // RVA: 0x7FFAC44F1BE0
        public void get_ReadTimeout(){} // RVA: 0x7FFAC44F1D60
        public void EndRead(){} // RVA: 0x7FFAC44F1EE0
        public void SetLength(){} // RVA: 0x7FFAC44F1F70
        public void get_CanSeek(){} // RVA: 0x7FFAC44F1FD0
        public void BeginWrite(){} // RVA: 0x7FFAC44F2000
        public void Dispose(){} // RVA: 0x7FFAC44F2320
        public void Cleanup(){} // RVA: 0x7FFAC44F1BE0
        public void CopyTo(){} // RVA: 0x7FFAC44F1BE0
        public void Seek(){} // RVA: 0x7FFAC44F23F0
        public void Flush(){} // RVA: 0x7FFAC44F2450
        public void Close(){} // RVA: 0x7FFAC44F24F0
        public void Write(){} // RVA: 0x7FFAC44F2670
        public void set_CanRead(){} // RVA: 0x7FFAC44F2710
        public void get_CanRead(){} // RVA: 0x7FFAC44F2890
        public void EndWrite(){} // RVA: 0x7FFAC44F28C0
        public void get_Length(){} // RVA: 0x7FFAC44F2950
        public void set_Position(){} // RVA: 0x7FFAC44F29B0
    }

    /// <summary>Originally: ÏÍÌÎÌÌÏÍÏÎÏÌÏÌÍÏÍÎÌÍÏÌÏ</summary>
    public class CameraPosition_DAF2_DAF2 : Stream
    {
        public int _length;
        public System.IO.Stream _canSeek; // 0x28
        public 0x6B013EE0 _canRead; // 0x30
        public bool _position; // 0x34
        public ÎÏÍÍÏÍÏÏÍÍÎÎÏÏÍÏÍÏÍÏÎÍÏ _canWrite; // 0x38
        public ÌÍÍÏÍÍÍÌÏÍÍÎÍÍÌÍÎÌÎÏÍÎÍ _position2; // 0x40
        public byte[] ÍÌÏÎÎÎÎÎÏÍÎÍÎÌÏÍÎÌÏÍÎÎÍ; // 0x48
        public int ÌÎÍÍÎÎÌÎÏÌÏÍÎÏÌÌÍÍÏÍÎÏÎ; // 0x50
        public System.AsyncCallback ÍÎÎÌÏÌÎÎÌÏÍÏÌÍÌÍÍÎÎÎÌÎÌ; // 0x58
        public ÏÏÏÍÏÎÎÏÍÎÍÌÌÎÏÎÌÌÏÍÍÍÎ ÍÏÏÏÌÍÎÌÏÍÌÏÍÌÌÍÎÍÏÏÏÎÌ; // 0x60
        public ÍÏÎÌÍÌÏÎÌÎÍÍÏÏÏÎÌÏÏÍÍÏÍ ÎÍÍÍÏÎÍÏÍÌÎÏÏÌÌÌÍÎÍÍÏÎÍ; // 0x68
        public bool ÏÍÍÏÏÏÎÏÍÍÎÍÎÎÏÍÍÌÏÏÏÍÌ; // 0x70
        public bool ÎÌÍÍÍÌÎÍÌÎÏÌÍÎÎÏÎÍÍÏÍÏÌ; // 0x71

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFAC44E9C00
        public void SetLength(){} // RVA: 0x7FFAC44E9D70
        public void BeginRead(){} // RVA: 0x7FFAC44E9DD0
        public void Read(){} // RVA: 0x7FFAC44EA0E0
        public void set_Length(){} // RVA: 0x7FFAC44EA270
        public void Dispose(){} // RVA: 0x7FFAC44EA420
        public void Cleanup(){} // RVA: 0x7FFAC44EA690
        public void get_Length(){} // RVA: 0x7FFAC44EA860
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void set_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void set_CanRead(){} // RVA: 0x7FFAC44EA8C0
        public void get_CanRead(){} // RVA: 0x7FFAC44EA910
        public void CopyToAsync(){} // RVA: 0x7FFAC44EA940
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void Write(){} // RVA: 0x7FFAC44EA9C0
        public void CopyToAsyncInternal(){} // RVA: 0x7FFAC44EAB40
        public void CopyTo(){} // RVA: 0x7FFAC44EAC90
        public void Seek(){} // RVA: 0x7FFAC44EACE0
        public void GetCopyBufferSize(){} // RVA: 0x7FFAC44EAD40
        public void Flush(){} // RVA: 0x7FFAC44EADD0
        public void Close(){} // RVA: 0x7FFAC44EADE0
        public void TryGetCameraPosition(){} // RVA: 0x7FFAC44EAFD0
        public void Flush_1D59EC004759(){} // RVA: 0x7FFAC44EB100
        public void EndWrite(){} // RVA: 0x7FFAC44EB180
        public void .ctor(){} // RVA: 0x7FFAC44EC420 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC44EB2D0
        public void BeginReadInternal(){} // RVA: 0x7FFAC44EB350
        public void GetCachedPtr(){} // RVA: 0x7FFAC44EB3D0
        public void ReadAsync(){} // RVA: 0x7FFAC44EB540
        public void ReadAsync_5E139461BC2D(){} // RVA: 0x7FFAC44EB5C0
        public void set_CanWrite(){} // RVA: 0x7FFAC44EB730
        public void set_Position(){} // RVA: 0x7FFAC44EB960
        public void get_Position(){} // RVA: 0x7FFAC44EB9C0
        public void BeginWriteInternal(){} // RVA: 0x7FFAC44EBA20
        public void get_CanWrite(){} // RVA: 0x7FFAC44EBC40
        public void RunReadWriteTask(){} // RVA: 0x7FFAC44EBC70
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFAC44EBD50
        public void EndWrite_C5A0A3AA16EA(){} // RVA: 0x7FFAC2F21320
        public void BeginWrite(){} // RVA: 0x7FFAC44EC010
        public void WriteAsync(){} // RVA: 0x7FFAC44EC260
        public void EndRead(){} // RVA: 0x7FFAC44EC2C0
        public void BeginEndWriteAsync(){} // RVA: 0x7FFAC44EC970
    }

    /// <summary>Originally: ÍÏÎÎÏÎÌÌÍÎÎÏÍÎÏÌÎÏÍÏÍÏÍ</summary>
    public class EffectmaterialForRenderingGetMaterial_5E1C_5E1C : Texturetext_35E1_35E1
    {
        public ÌÏÍÍÏÌÌÎÎÍÏÍÎÍÍÎÌÌÎÍÏÎÍ _materialForRendering; // 0x7E8
        public bool ÏÍÎÎÍÎÍÎÎÍÏÍÍÏÎÏÍÎÍÎÍÌÎ; // 0x7F0

        // ── Methods ──
        public void GetMaterial_7084143CFF13(){} // RVA: 0x7FFAC3100600
        public void UpdateGameObjectActiveState(){} // RVA: 0x7FFAC31007E0
        public void GetMaterial(){} // RVA: 0x7FFAC31009E0
        public void get_fontWeight(){} // RVA: 0x7FFAC3100B70
        public void InitializePurchaseFlow(){} // RVA: 0x7FFAC3100D70
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAC3100F50
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAC3101100
        public void .ctor(){} // RVA: 0x7FFAC31012B0
        public void Initialize(){} // RVA: 0x7FFAC3101300
        public void Rebuild(){} // RVA: 0x7FFAC3101500
        public void set_materialForRendering(){} // RVA: 0x7FFAC3101670
        public void get_materialForRendering(){} // RVA: 0x7FFAC3101A50
        public void DelayedMaterialRebuild(){} // RVA: 0x7FFAC3101A70
        public void Rebuild_BD5732C4DB70(){} // RVA: 0x7FFAC3101C20
    }

    /// <summary>Originally: ÌÏÎÎÎÌÍÌÎÌÏÎÍÎÌÏÍÎÏÏÏÏÎ</summary>
    public class PivotBasedCameraRig_0A25 : MonoBehaviour
    {
        public int _maxLineCount; // 0x20
        public 0x6B234000 _overflowMode; // 0x24
        public bool _autoTruncate; // 0x28
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÎÏÎÎÌÎÏÍÍÌÍÌÍÎÍÏÍÍÌÌÍÌ; // 0x30
        public UnityEngine.UI.ContentSizeFitter ÌÌÎÎÌÏÌÎÍÌÏÍÏÍÌÌÌÍÏÎÎÎÏ; // 0x38
        public System.Threading.CancellationTokenSource ÏÏÍÍÍÌÏÍÌÌÏÌÍÌÏÏÌÌÏÍÏÌÌ; // 0x40

        // ── Methods ──
        public void Awake_44633282D77E(){} // RVA: 0x7FFACB9A50E0
        public void OnDisable(){} // RVA: 0x7FFACB9A51D0
        public void IsInvoking(){} // RVA: 0x7FFACB9A52C0
        public void CancelInvoke(){} // RVA: 0x7FFACB9A53B0
        public void Invoke(){} // RVA: 0x7FFACB9A5640
        public void Awake(){} // RVA: 0x7FFACB9A58D0
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
        public void Initialize(){} // RVA: 0x7FFACB9A5A40
        public void StartCoroutine(){} // RVA: 0x7FFACB9A5BB0
        public void OnEnable(){} // RVA: 0x7FFACB9A5CA0
        public void OnTriggerEnter(){} // RVA: 0x7FFACB9A5D90
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB9A5F20
        public void StopCoroutine(){} // RVA: 0x7FFACB9A6010
        public void OnApplicationPause(){} // RVA: 0x7FFACB9A6100
        public void OnApplicationQuit(){} // RVA: 0x7FFACB9A62E0
    }

    /// <summary>Originally: ÌÌÍÎÎÍÌÎÎÍÏÍÌÍÎÏÌÌÏÌÍÎÎ</summary>
    public class PopulateMesh_0AD8_0AD8 : Image
    {
        public int _sides; // 0x118
        public float _radius; // 0x11C
        public float _thickness; // 0x120
        public float _uvRangeX; // 0x124
        public bool _useRadialFill; // 0x128
        public float ÌÎÎÎÌÍÏÎÍÌÍÎÌÎÍÌÍÍÍÏÎÍÏ;

        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x7FFAC370C100
        public void set_image(){} // RVA: 0x7FFAC370C360
        public void get_sprite(){} // RVA: 0x7FFAC370C3B0
        public void set_sprite(){} // RVA: 0x7FFAC370C8A0
        public void get_vectorImage(){} // RVA: 0x7FFAC36F39E0
        public void set_vectorImage(){} // RVA: 0x7FFAC370CD60
        public void get_sourceRect(){} // RVA: 0x7FFAC370CDB0
        public void .ctor(){} // RVA: 0x7FFAC370D2B0
        public void Initialize(){} // RVA: 0x7FFAC370D370
    }

    /// <summary>Originally: ÏÍÏÌÎÍÎÏÎÎÎÏÍÍÎÏÎÏÌÌÍÍÍ</summary>
    public class PopulateMesh_15B3_15B3 : Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFAC3709060
        public void set_image(){} // RVA: 0x7FFAC3709650
        public void get_sprite(){} // RVA: 0x7FFAC3709C40
        public void .ctor(){} // RVA: 0x7FFAC370A230
        public void Initialize(){} // RVA: 0x7FFAC370A2C0
        public void set_vectorImage(){} // RVA: 0x7FFAC370A3B0
        public void get_sourceRect(){} // RVA: 0x7FFAC370A4A0
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFAC36F6210
        public void set_uv(){} // RVA: 0x7FFAC370A590
        public void get_scaleMode(){} // RVA: 0x7FFAC370AB80
        public void OnPopulateMesh(){} // RVA: 0x7FFAC370AC70
    }

    /// <summary>Originally: ÏÍÏÌÎÍÎÌÎÎÌÌÎÎÌÎÍÍÎÎÍÏÍ</summary>
    public class PopulateMesh_1894_1894 : MaskableGraphic
    {
        public float ÏÏÌÏÏÍÌÌÌÏÏÌÌÍÎÍÍÎÎÏÍÎÎ; // 0xE0

        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x7FFAC4646F00
        public void set_onCullStateChanged(){} // RVA: 0x7FFAC4647080
        public void get_maskable(){} // RVA: 0x7FFAC4647480
        public void set_maskable(){} // RVA: 0x7FFAC4647880
        public void get_isMaskingGraphic(){} // RVA: 0x7FFAC4647C80
        public void set_isMaskingGraphic(){} // RVA: 0x7FFAC4648080
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC4648480
        public void .ctor(){} // RVA: 0x7FFAC4648880
        public void Initialize(){} // RVA: 0x7FFAC4648890
    }

    /// <summary>Originally: ÌÏÎÏÎÏÏÎÏÏÎÏÌÎÍÌÌÏÍÍÎÎÏ</summary>
    public class PopulateMesh_269E_269E : Image
    {
        public 0x6B0380B8 _mirrorMode; // 0x118
        public bool _flipMirrored; // 0x11C
        public float _flipOffset; // 0x120
        public UnityEngine.Vector2[] ÏÏÎÍÏÎÍÎÏÏÎÎÌÎÍÌÎÏÎÌÏÎÍ;
        public UnityEngine.Vector2[] ÏÍÌÏÎÌÏÏÏÌÎÎÏÎÎÌÎÏÏÌÍÎÍ; // 0x8

        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFAC36F4600
        public void OnPopulateMesh(){} // RVA: 0x7FFAC36F46F0
        public void get_sprite(){} // RVA: 0x7FFAC36F5340
        public void set_sprite(){} // RVA: 0x7FFAC36F55B0
        public void get_vectorImage(){} // RVA: 0x7FFAC36F5820
        public void set_vectorImage(){} // RVA: 0x7FFAC36F58C0
        public void GetAdjustedBorders(){} // RVA: 0x7FFAC36F59B0
        public void .cctor(){} // RVA: 0x7FFAC36F5CF0
        public void set_uv(){} // RVA: 0x7FFAC36F5E30
        public void .ctor(){} // RVA: 0x7FFAC36F5F20
        public void AddQuad(){} // RVA: 0x7FFAC36F5FB0
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFAC36F6210
        public void GetTextureDisplaySize(){} // RVA: 0x7FFAC36F5820
        public void ApplyMeshSpriteColor(){} // RVA: 0x7FFAC36F6300
    }

    /// <summary>Originally: ÏÌÎÏÌÏÌÍÏÍÎÍÍÌÏÏÌÏÎÎÍÍÎ</summary>
    public class PopulateMesh_D259_D259 : MaskableGraphic
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
        public void .cctor(){} // RVA: 0x7FFAC36F2A00
        public void OnEnable(){} // RVA: 0x7FFAC36F2C80
        public void OnDisable(){} // RVA: 0x7FFAC36F3690
        public void OnPopulateMesh(){} // RVA: 0x7FFAC36F36E0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFAC36F39E0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFAC36F3A20
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC36F3A70
        public void Cull(){} // RVA: 0x7FFAC36F3AC0
        public void .ctor(){} // RVA: 0x7FFAC36F3B10
        public void Initialize(){} // RVA: 0x7FFAC36F3B30
        public void SetClipSoftness(){} // RVA: 0x7FFAC36F3B80
        public void OnBecameInvisible(){} // RVA: 0x7FFAC36F3BD0
    }

    /// <summary>Originally: ÎÍÎÍÍÏÌÎÍÏÌÎÌÎÏÏÎÌÌÏÌÎÏ</summary>
    public class SetMaterialDirtySetVerticesDirty_FBD6_FBD6 : Text
    {
        public bool ÎÌÏÍÌÎÍÍÎÍÎÌÌÏÎÎÏÎÍÌÏÎÏ; // 0x110
        public System.Text.RegularExpressions.Regex ÎÏÍÍÌÌÏÎÍÎÎÏÌÌÎÌÎÍÎÌÌÌÍ; // 0x118

        // ── Methods ──
        public void GetisDone(){} // RVA: 0x7FFAC3A6B770
        public void get_cachedTextGenerator(){} // RVA: 0x7FFAC3A6B990
        public void SetLayoutDirty(){} // RVA: 0x7FFAC3A6BBB0
        public void get_mainTexture(){} // RVA: 0x7FFAC3A6BC60
        public void FontTextureChanged(){} // RVA: 0x7FFAC3A6BE80
        public void OnPopulateMesh(){} // RVA: 0x7FFAC3A6C0A0
        public void set_font(){} // RVA: 0x7FFAC3A6C150
        public void get_text(){} // RVA: 0x7FFAC3A6C370
        public void set_text(){} // RVA: 0x7FFAC3A6C590
        public void get_supportRichText(){} // RVA: 0x7FFAC3A6C7B0
        public void SetMaterialDirty(){} // RVA: 0x7FFAC3A6C9D0
        public void SetVerticesDirty(){} // RVA: 0x7FFAC3A6CA70
        public void .ctor(){} // RVA: 0x7FFAC3A6CB10
        public void Initialize(){} // RVA: 0x7FFAC3A6CD50
    }

    /// <summary>Originally: ÌÏÍÍÍÎÎÏÎÌÍÎÎÌÏÍÍÏÍÍÌÍÍ</summary>
    public class mainTexturePopulateMeshSibling_7840_7840 : MonoBehaviour
    {
        public UnityEngine.UI.RawImage _destroyCancellationToken; // 0x20
        public ÏÍÏÌÎÎÏÌÏÌÍÎÏÌÎÏÍÎÍÌÏÏÍ _useGUILayout; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4430B10
        public void RaiseCancellation(){} // RVA: 0x7FFAC4430B50
        public void IsInvoking(){} // RVA: 0x7FFAC4430B70
        public void CancelInvoke(){} // RVA: 0x7FFAC4430B50
        public void Invoke(){} // RVA: 0x7FFAC4430C10
        public void InvokeRepeating(){} // RVA: 0x7FFAC4430DF0
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFAC4430E30
        public void IsInvoking_DA83566997EF(){} // RVA: 0x7FFAC4430FD0
        public void StartCoroutine(){} // RVA: 0x7FFAC4430B50
        public void .ctor_CC8F710061D9(){} // RVA: 0x7FFAC4430FF0
        public void Initialize(){} // RVA: 0x7FFAC44311A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC4431200
        public void StopCoroutine(){} // RVA: 0x7FFAC44313E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize_849DE918F0A9(){} // RVA: 0x7FFAC44311A0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC4431570
        public void get_useGUILayout(){} // RVA: 0x7FFAC44311A0
        public void set_useGUILayout(){} // RVA: 0x7FFAC4431600
    }

    /// <summary>Originally: ÍÍÌÌÍÌÌÏÎÌÎÏÌÏÎÌÍÌÎÏÎÎÎ</summary>
    public class mainTexturePopulateMesh_1388_1388 : MaskableGraphic
    {
        public UnityEngine.Sprite _mainTexture; // 0xE0
        public float ÌÌÍÌÎÎÎÏÎÏÌÎÌÌÍÍÍÎÎÍÎÏÎ; // 0xE8
        public float ÌÎÌÏÌÌÏÎÍÏÍÌÏÏÏÍÏÍÎÍÏÍÎ; // 0xEC
        public float ÏÎÎÍÏÎÍÏÏÌÍÏÍÏÏÎÍÍÌÎÏÌÏ; // 0xF0
        public float ÎÌÎÎÌÏÍÎÌÌÏÏÍÎÎÌÏÌÏÌÍÏÌ; // 0xF4
        public float ÍÌÌÌÌÌÏÎÍÎÍÌÍÍÎÍÎÌÍÍÍÎÏ; // 0xF8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4648880
        public void Initialize(){} // RVA: 0x7FFACB7AFAF0
        public void set_mainTexture(){} // RVA: 0x7FFACB7AFAF0
        public void get_mainTexture(){} // RVA: 0x7FFACB7AFBD0
        public void get_isMaskingGraphic(){} // RVA: 0x7FFACB7AFAF0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFACB7AFAF0
        public void OnPopulateMesh(){} // RVA: 0x7FFACB7AFD40
        public void Cull(){} // RVA: 0x7FFACB7AFAF0
        public void UpdateCull(){} // RVA: 0x7FFACB7AFAF0
        public void SetClipRect(){} // RVA: 0x7FFACB7AFAF0
        public void SetClipSoftness(){} // RVA: 0x7FFACB7AFAF0
        public void OnEnable(){} // RVA: 0x7FFACB7AFAF0
    }

    /// <summary>Originally: ÍÎÏÍÏÍÌÏÏÍÏÍÏÍÌÏÏÌÏÎÎÎÏ</summary>
    public class mainTexturePopulateMesh_3A32_3A32 : MaskableGraphic
    {
        public float _mainTexture; // 0xE0
        public float _maskable; // 0xE4
        public float ÎÎÍÏÎÌÍÌÌÍÍÏÌÍÌÌÏÎÍÏÍÏÍ; // 0xE8
        public float ÌÏÌÍÏÌÏÏÏÏÍÎÎÍÏÎÏÏÍÎÌÍÎ; // 0xEC
        public float ÍÏÍÍÌÍÏÍÏÎÌÎÌÌÎÏÍÌÌÍÎÏÍ;
        public UnityEngine.Texture _texture; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACB97E050
        public void get_ipsQuery(){} // RVA: 0x7FFAC2F8C2A0
        public void get_maskable(){} // RVA: 0x7FFACB97E070
        public void set_maskable(){} // RVA: 0x7FFACB97E220
        public void set_mainTexture(){} // RVA: 0x7FFAC2F8C2A0
        public void get_mainTexture(){} // RVA: 0x7FFAC2F8C2A0
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC2F8C2A0
        public void OnPopulateMesh(){} // RVA: 0x7FFACB97E3D0
        public void UpdateCull(){} // RVA: 0x7FFAC2F8C2A0
        public void SetClipRect(){} // RVA: 0x7FFACB97ECB0
        public void SetClipSoftness(){} // RVA: 0x7FFACB97EE60
        public void OnEnable(){} // RVA: 0x7FFACB97F010
    }

    /// <summary>Originally: ÎÏÎÎÌÎÍÍÏÏÎÏÎÌÏÎÏÍÌÌÌÎÎ</summary>
    public class mainTexturePopulateMesh_FA06_FA06 : MaskableGraphic
    {
        public UnityEngine.Sprite _mainTexture; // 0xE0
        public 0x6AFEDCB8 _maskable; // 0xE8
        public bool _isMaskingGraphic; // 0xEC
        public uint ShaderFeatureRectOffsetChannel; // 0xF0
        public bool ShaderFeatureMasking; // 0xF4
        public float yOffset; // 0xF8
        public float ÌÎÍÏÍÏÌÎÌÍÎÏÎÎÏÏÌÍÍÎÏÌÏ; // 0xFC

        // ── Methods ──
        public void get_fillAmount(){} // RVA: 0x7FFAC30F10F0
        public void get_mainTexture(){} // RVA: 0x7FFAC30F1100
        public void OnPopulateMesh(){} // RVA: 0x7FFAC30F1270
        public void .ctor(){} // RVA: 0x7FFAC30F1FC0
        public void Initialize(){} // RVA: 0x7FFAC30F1FE0
        public void set_isMaskingGraphic(){} // RVA: 0x7FFAC30F2050
        public void GetModifiedMaterial(){} // RVA: 0x7FFAC30F20A0
        public void Cull(){} // RVA: 0x7FFAC30F2920
        public void UpdateCull(){} // RVA: 0x7FFAC30F3180
        public void SetClipRect(){} // RVA: 0x7FFAC30F31B0
        public void get_domainList(){} // RVA: 0x7FFAC2FA2900
        public void OnEnable(){} // RVA: 0x7FFAC30F3360
        public void OnDisable(){} // RVA: 0x7FFAC30F10F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC30F10F0
        public void ParentMaskStateChanged(){} // RVA: 0x7FFAC30F1FE0
    }

}