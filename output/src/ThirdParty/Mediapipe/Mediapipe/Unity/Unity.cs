// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity
// Classes: 53
// Methods: 533

namespace ThirdParty.Mediapipe.Mediapipe.Unity
{
    public class AnnotationController`1 : MonoBehaviour
    {
        public T annotation;
        public bool isStale;
        public UnityEngine.Vector2Int _imageSize;

        // ── Methods ──
        public void get_isMirrored(){} // RVA: 0x7FFE80E2F150
        public void set_isMirrored(){} // RVA: 0x7FFE80E466C0
        public void get_rotationAngle(){} // RVA: 0x7FFE80E2EDB0
        public void set_rotationAngle(){} // RVA: 0x7FFE80E46530
        public void get_imageSize(){}
        public void set_imageSize(){}
        public void Start(){} // RVA: 0x7FFE80E45FE0
        public void LateUpdate(){} // RVA: 0x7FFE80E45FE0
        public void OnDestroy(){} // RVA: 0x7FFE80E45FE0
        public void SyncNow(){} // RVA: 0x7FFE80E45FE0
        public void UpdateCurrentTarget(){} // RVA: 0x7FFE810A1420
        public void IsTargetChanged(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Arrow : MonoBehaviour
    {
        public UnityEngine.Color _color; // 0x20
        public UnityEngine.Vector3 _direction; // 0x30
        public float _magnitude; // 0x3C
        public float _capScale; // 0x40
        public float _lineWidth; // 0x44

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86674110
        public void get_cone(){} // RVA: 0x7FFE86674190
        public void get_lineRenderer(){} // RVA: 0x7FFE866743D0
        public void get_direction(){} // RVA: 0x7FFE828CAED0
        public void set_direction(){} // RVA: 0x7FFE86674460
        public void get_magnitude(){} // RVA: 0x7FFE8178C5D0
        public void set_magnitude(){} // RVA: 0x7FFE866744B0
        public void get_color(){} // RVA: 0x7FFE82C84C90
        public void set_color(){} // RVA: 0x7FFE86674520
        public void SetVector(){} // RVA: 0x7FFE86674550
        public void SetCapScale(){} // RVA: 0x7FFE86674690
        public void SetLineWidth(){} // RVA: 0x7FFE866746A0
        public void ApplyColor(){} // RVA: 0x7FFE866746B0
        public void ApplyDirection(){} // RVA: 0x7FFE86674850
        public void ApplyMagnitude(){} // RVA: 0x7FFE86674A30
        public void ApplyCapScale(){} // RVA: 0x7FFE86674D90
        public void ApplyLineWidth(){} // RVA: 0x7FFE86674E70
        public void .ctor(){} // RVA: 0x7FFE86674F50
    }

    public class AssetBundleResourceManager : ResourceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86692610
        public void PrepareAssetAsync(){} // RVA: 0x7FFE86692920
        public void PathToResourceAsFile(){} // RVA: 0x7FFE86692A30
        public void GetResourceContents(){} // RVA: 0x7FFE86692AC0
        public void GetCachePathFor(){} // RVA: 0x7FFE86692B90
        public void .cctor(){} // RVA: 0x7FFE86692C30
    }

    public class CircleAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86675000
        public void OnDisable(){} // RVA: 0x7FFE86675040
        public void SetColor(){} // RVA: 0x7FFE86675140
        public void SetLineWidth(){} // RVA: 0x7FFE86675170
        public void Draw(){} // RVA: 0x7FFE86675180
        public void ApplyColor(){} // RVA: 0x7FFE86675560
        public void ApplyLineWidth(){} // RVA: 0x7FFE86675700
        public void .ctor(){} // RVA: 0x7FFE86675810
    }

    public class Connection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class ConnectionAnnotation : LineAnnotation
    {
        public Mediapipe.Unity.Connection _currentTarget; // 0x50

        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x7FFE86675870
        public void Draw(){} // RVA: 0x7FFE86675880
        public void Redraw(){} // RVA: 0x7FFE86675A40
        public void ActivateFor(){} // RVA: 0x7FFE86675A50
        public void .ctor(){} // RVA: 0x7FFE86675810
    }

    public class ConnectionListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void Fill(){} // RVA: 0x7FFE86675AD0
        public void SetColor(){} // RVA: 0x7FFE86675E00
        public void SetLineWidth(){} // RVA: 0x7FFE86675E30
        public void Draw(){} // RVA: 0x7FFE86675E40
        public void Redraw(){} // RVA: 0x7FFE86675FF0
        public void InstantiateChild(){} // RVA: 0x7FFE86676210
        public void ApplyColor(){} // RVA: 0x7FFE866762B0
        public void ApplyLineWidth(){} // RVA: 0x7FFE866764F0
        public void .ctor(){} // RVA: 0x7FFE86676710
    }

    public class DetectionAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.RectangleAnnotation _boundingBoxAnnotation; // 0x30
        public Mediapipe.Unity.PointListAnnotation _keypointsAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86676A50
        public void set_rotationAngle(){} // RVA: 0x7FFE86676AE0
        public void SetLineWidth(){} // RVA: 0x7FFE86676B60
        public void SetKeypointRadius(){} // RVA: 0x7FFE86676B90
        public void Draw(){} // RVA: 0x7FFE866771A0 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFE86677890
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DetectionAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86677930
        public void DrawLater(){} // RVA: 0x7FFE866779A0
        public void SyncNow(){} // RVA: 0x7FFE86677A00
        public void .ctor(){} // RVA: 0x7FFE86677A30
    }

    public class DetectionListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetLineWidth(){} // RVA: 0x7FFE86677AA0
        public void SetKeypointRadius(){} // RVA: 0x7FFE86677AB0
        public void Draw(){} // RVA: 0x7FFE86677E10 | overloaded x4
        public void InstantiateChild(){} // RVA: 0x7FFE86677E40
        public void ApplyLineWidth(){} // RVA: 0x7FFE86677EE0
        public void ApplyKeypointRadius(){} // RVA: 0x7FFE86678110
        public void .ctor(){} // RVA: 0x7FFE86678340
    }

    public class DetectionListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE866785C0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFE86678650 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE866786C0
        public void .ctor(){} // RVA: 0x7FFE866786F0
    }

    public class DetectionResultAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86677930
        public void DrawLater(){} // RVA: 0x7FFE86678760
        public void SyncNow(){} // RVA: 0x7FFE86678810
        public void .ctor(){} // RVA: 0x7FFE86678970
    }

    public class FaceLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation _landmarkListAnnotation; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation _connectionListAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86678C60
        public void set_rotationAngle(){} // RVA: 0x7FFE86678CD0
        public void Start(){} // RVA: 0x7FFE86678D30
        public void SetLandmarkColor(){} // RVA: 0x7FFE86678DA0
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86678DE0
        public void SetConnectionColor(){} // RVA: 0x7FFE86678E10
        public void SetConnectionWidth(){} // RVA: 0x7FFE86678E50
        public void Draw(){} // RVA: 0x7FFE86679060 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE866790F0
    }

    public class FaceLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE8667A9A0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFE8667AA90 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE8667AB00
        public void .ctor(){} // RVA: 0x7FFE8667AB40
    }

    public class FaceLandmarkListWithIrisAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.FaceLandmarkListAnnotation _faceLandmarkListAnnotation; // 0x30
        public Mediapipe.Unity.IrisLandmarkListAnnotation _leftIrisLandmarkListAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86676A50
        public void set_rotationAngle(){} // RVA: 0x7FFE86676AE0
        public void SetFaceLandmarkColor(){} // RVA: 0x7FFE8667ABC0
        public void SetIrisLandmarkColor(){} // RVA: 0x7FFE8667AC00
        public void SetFaceLandmarkRadius(){} // RVA: 0x7FFE8667AC80
        public void SetIrisLandmarkRadius(){} // RVA: 0x7FFE8667ACB0
        public void SetFaceConnectionColor(){} // RVA: 0x7FFE8667AD20
        public void SetFaceConnectionWidth(){} // RVA: 0x7FFE8667AD60
        public void SetIrisCircleColor(){} // RVA: 0x7FFE8667AD90
        public void SetIrisCircleWidth(){} // RVA: 0x7FFE8667AE10
        public void Draw(){} // RVA: 0x7FFE8667AFF0 | overloaded x4
        public void DrawFaceLandmarkList(){} // RVA: 0x7FFE8667B1E0 | overloaded x2
        public void DrawLeftIrisLandmarkList(){} // RVA: 0x7FFE8667B2C0 | overloaded x2
        public void DrawRightIrisLandmarkList(){} // RVA: 0x7FFE8667B320 | overloaded x2
        public void PartitionLandmarkList(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class FaceLandmarkerResultAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE866789E0
        public void DrawLater(){} // RVA: 0x7FFE86678A20
        public void UpdateCurrentTarget(){} // RVA: 0x7FFE86678A80
        public void SyncNow(){} // RVA: 0x7FFE86678AD0
        public void .ctor(){} // RVA: 0x7FFE86678BF0
    }

    public class GpuManager : Object
    {
        public object _SetupLock;
        public UIntPtr _CurrentContext; // 0x8
        public bool _IsContextInitialized; // 0x10

        // ── Methods ──
        public void get_GpuResources(){} // RVA: 0x7FFE86691840
        public void set_GpuResources(){} // RVA: 0x7FFE866918A0
        public void get_GlCalculatorHelper(){} // RVA: 0x7FFE86691960
        public void set_GlCalculatorHelper(){} // RVA: 0x7FFE866919C0
        public void get_IsInitialized(){} // RVA: 0x7FFE86691A80
        public void set_IsInitialized(){} // RVA: 0x7FFE86691AE0
        public void Initialize(){} // RVA: 0x7FFE86691B40
        public void Shutdown(){} // RVA: 0x7FFE86691B80
        public void .cctor(){} // RVA: 0x7FFE86691D30
    }

    public class HandLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation _landmarkListAnnotation; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation _connectionListAnnotation; // 0x38
        public UnityEngine.Color _leftLandmarkColor; // 0x40

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86678C60
        public void set_rotationAngle(){} // RVA: 0x7FFE86678CD0
        public void get_Item(){} // RVA: 0x7FFE8667B5F0
        public void Start(){} // RVA: 0x7FFE8667B690
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE850A4980
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE8667B700
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86678DE0
        public void SetConnectionColor(){} // RVA: 0x7FFE86678E10
        public void SetConnectionWidth(){} // RVA: 0x7FFE86678E50
        public void SetHandedness(){} // RVA: 0x7FFE8667BAA0 | overloaded x5
        public void Draw(){} // RVA: 0x7FFE8667BC90 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE8667BD20
    }

    public class HandLandmarkerResultAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE8667B350
        public void DrawLater(){} // RVA: 0x7FFE8667B390
        public void UpdateCurrentTarget(){} // RVA: 0x7FFE8667B3F0
        public void SyncNow(){} // RVA: 0x7FFE8667B440
        public void .ctor(){} // RVA: 0x7FFE8667B580
    }

    public class HierarchicalAnnotation : MonoBehaviour
    {
        public Mediapipe.Unity.IHierachicalAnnotation _root; // 0x20
        public bool _isMirrored; // 0x28
        public 0x6660F46C _rotationAngle; // 0x2C
        public object field_3; // 0x246
        public object field_4; // 0x247

        // ── Methods ──
        public void get_root(){} // RVA: 0x7FFE8667C6C0
        public void set_root(){} // RVA: 0x7FFE811290D0
        public void GetAnnotationLayer(){} // RVA: 0x7FFE8667CA60
        public void GetScreenRect(){} // RVA: 0x7FFE8667CB80
        public void get_isActive(){} // RVA: 0x7FFE8667CD10
        public void get_isActiveInHierarchy(){} // RVA: 0x7FFE8667CDB0
        public void SetActive(){} // RVA: 0x7FFE8667CE50
        public void ActivateFor(){} // RVA: 0x7FFE810A1420
        public void get_isMirrored(){} // RVA: 0x7FFE815F1380
        public void set_isMirrored(){} // RVA: 0x7FFE81C15740
        public void get_rotationAngle(){} // RVA: 0x7FFE81F84A50
        public void set_rotationAngle(){} // RVA: 0x7FFE82883A50
        public void InstantiateChild(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Mediapipe.Unity.IHierachicalAnnotation.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class HolisticLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.FaceLandmarkListWithIrisAnnotation _faceLandmarkListAnnotation; // 0x30
        public Mediapipe.Unity.PoseLandmarkListAnnotation _poseLandmarkListAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE8667CFB0
        public void set_rotationAngle(){} // RVA: 0x7FFE8667D080
        public void Start(){} // RVA: 0x7FFE8667D140
        public void Draw(){} // RVA: 0x7FFE8667D420 | overloaded x2
        public void RedrawWristJoints(){} // RVA: 0x7FFE8667D490
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class HolisticLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE8667D8E0 | overloaded x2
        public void DrawFaceLandmarkListLater(){} // RVA: 0x7FFE8667DB10 | overloaded x2
        public void DrawPoseLandmarkListLater(){} // RVA: 0x7FFE8667DBE0 | overloaded x2
        public void DrawLeftHandLandmarkListLater(){} // RVA: 0x7FFE8667DCB0 | overloaded x2
        public void DrawRightHandLandmarkListLater(){} // RVA: 0x7FFE8667DD80 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE8667DDF0
        public void .ctor(){} // RVA: 0x7FFE8667DE50
    }

    public class IHierachicalAnnotation
    {
        // ── Methods ──
        public void get_root(){} // RVA: 0x7FFE80E2E2E0
        public void get_transform(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ImageFrameExtension : Object
    {
        // ── Methods ──
        public void TryReadChannelNormalized(){} // RVA: 0x7FFE86690E00 | overloaded x3
        public void TryReadChannel(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ByteNormalizer(){} // RVA: 0x7FFE866917E0
        public void UshortNormalizer(){} // RVA: 0x7FFE86691800
        public void IsChannelNumberValid(){} // RVA: 0x7FFE86691820
    }

    public class IrisLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation _landmarkListAnnotation; // 0x30
        public Mediapipe.Unity.CircleAnnotation _circleAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86678C60
        public void set_rotationAngle(){} // RVA: 0x7FFE86678CD0
        public void SetLandmarkColor(){} // RVA: 0x7FFE86678DA0
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86678DE0
        public void SetCircleColor(){} // RVA: 0x7FFE8667DED0
        public void SetCircleWidth(){} // RVA: 0x7FFE8667DF10
        public void Draw(){} // RVA: 0x7FFE8667E480 | overloaded x4
        public void CalculateRadius(){} // RVA: 0x7FFE8667E5A0 | overloaded x2
        public void CalculateDistance(){} // RVA: 0x7FFE8667EB90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LabelAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void Draw(){} // RVA: 0x7FFE8667EDA0
        public void GetFontSize(){} // RVA: 0x7FFE8667F490
        public void DecideTextColor(){} // RVA: 0x7FFE8667F4E0
        public void CalcRelativeLuminance(){} // RVA: 0x7FFE8667F5E0
        public void CalcContrastRatio(){} // RVA: 0x7FFE8667F6E0
        public void ActivateFor(){} // RVA: 0x7FFE8667F750
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class LineAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8667F7D0
        public void OnDisable(){} // RVA: 0x7FFE8667F810
        public void SetColor(){} // RVA: 0x7FFE8667F820
        public void SetLineWidth(){} // RVA: 0x7FFE8667F850
        public void Draw(){} // RVA: 0x7FFE8667F960 | overloaded x2
        public void ApplyColor(){} // RVA: 0x7FFE8667FBC0
        public void ApplyLineWidth(){} // RVA: 0x7FFE8667FD60
        public void .ctor(){} // RVA: 0x7FFE86675810
    }

    public class ListAnnotation`1 : HierarchicalAnnotation
    {
        public UnityEngine.GameObject _annotationPrefab;
        public System.Collections.Generic.List`1<T> _children;
        public object field_2; // 0x24F
        public object field_3; // 0x250
        public object field_4; // 0x251

        // ── Methods ──
        public void get_children(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_count(){} // RVA: 0x7FFE80E2EDB0
        public void Fill(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void set_isMirrored(){} // RVA: 0x7FFE80E466C0
        public void set_rotationAngle(){} // RVA: 0x7FFE80E46530
        public void Destroy(){} // RVA: 0x7FFE80E45FE0
        public void InstantiateChild(){} // RVA: 0x7FFE810A1420
        public void CallActionForAll(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Logger : Object
    {
        public 0x6660EFF4 _minLogLevel;

        // ── Methods ──
        public void set_MinLogLevel(){} // RVA: 0x7FFE86692570
        public void .cctor(){} // RVA: 0x7FFE866925D0
    }

    public class MaskAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8667FE70
        public void OnDisable(){} // RVA: 0x7FFE8667FEB0
        public void OnDestroy(){} // RVA: 0x7FFE8667FF90
        public void Init(){} // RVA: 0x7FFE86680010
        public void Read(){} // RVA: 0x7FFE86680200
        public void Clear(){} // RVA: 0x7FFE86680230
        public void Draw(){} // RVA: 0x7FFE866802A0 | overloaded x2
        public void CreateMonoColorTexture(){} // RVA: 0x7FFE866802E0
        public void InitMaskBuffer(){} // RVA: 0x7FFE86680480
        public void ApplyMaterial(){} // RVA: 0x7FFE866806E0
        public void ApplyMaskTexture(){} // RVA: 0x7FFE86680940
        public void ApplyThreshold(){} // RVA: 0x7FFE86680B30
        public void .ctor(){} // RVA: 0x7FFE86680C40
    }

    public class MaskAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void InitScreen(){} // RVA: 0x7FFE86680CA0
        public void DrawNow(){} // RVA: 0x7FFE86680CD0
        public void DrawLater(){} // RVA: 0x7FFE86680D80
        public void UpdateMaskArray(){} // RVA: 0x7FFE86680E10
        public void SyncNow(){} // RVA: 0x7FFE86680E50
        public void .ctor(){} // RVA: 0x7FFE86680EC0
    }

    public class MaskOverlayAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86680F30
        public void OnDisable(){} // RVA: 0x7FFE86681080
        public void OnDestroy(){} // RVA: 0x7FFE86681240
        public void Init(){} // RVA: 0x7FFE866813B0
        public void SetMaskTexture(){} // RVA: 0x7FFE866818D0
        public void SetThreshold(){} // RVA: 0x7FFE86681950
        public void Read(){} // RVA: 0x7FFE866819A0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE866819E0
        public void Draw(){} // RVA: 0x7FFE86681AD0 | overloaded x3
        public void CreateMonoColorTexture(){} // RVA: 0x7FFE86681B10
        public void InitMaskBuffer(){} // RVA: 0x7FFE86681CB0
        public void ApplyMaterial(){} // RVA: 0x7FFE86681F20
        public void ApplyMaskTexture(){} // RVA: 0x7FFE86682180
        public void ApplyThreshold(){} // RVA: 0x7FFE86682370
        public void .ctor(){} // RVA: 0x7FFE86682480
    }

    public class MultiFaceLandmarkListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetFaceLandmarkRadius(){} // RVA: 0x7FFE866824E0
        public void SetIrisLandmarkRadius(){} // RVA: 0x7FFE866824F0
        public void SetFaceLandmarkColor(){} // RVA: 0x7FFE86682500
        public void SetIrisLandmarkColor(){} // RVA: 0x7FFE86682530
        public void SetFaceConnectionWidth(){} // RVA: 0x7FFE86682560
        public void SetFaceConnectionColor(){} // RVA: 0x7FFE86682570
        public void SetIrisCircleWidth(){} // RVA: 0x7FFE866825A0
        public void SetIrisCircleColor(){} // RVA: 0x7FFE866825B0
        public void Draw(){} // RVA: 0x7FFE866826F0 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFE86682800
        public void ApplyFaceLandmarkRadius(){} // RVA: 0x7FFE86682AA0
        public void ApplyIrisLandmarkRadius(){} // RVA: 0x7FFE86682CE0
        public void ApplyFaceLandmarkColor(){} // RVA: 0x7FFE86682F00
        public void ApplyIrisLandmarkColor(){} // RVA: 0x7FFE86683160
        public void ApplyFaceConnectionWidth(){} // RVA: 0x7FFE866833A0
        public void ApplyFaceConnectionColor(){} // RVA: 0x7FFE866835E0
        public void ApplyIrisCircleWidth(){} // RVA: 0x7FFE86683840
        public void ApplyIrisCircleColor(){} // RVA: 0x7FFE86683A60
        public void .ctor(){} // RVA: 0x7FFE86683CA0
    }

    public class MultiFaceLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86677930
        public void DrawLater(){} // RVA: 0x7FFE86684070
        public void SyncNow(){} // RVA: 0x7FFE866840D0
        public void .ctor(){} // RVA: 0x7FFE866841F0
    }

    public class MultiHandLandmarkListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE86684260
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE86684290
        public void SetLandmarkRadius(){} // RVA: 0x7FFE866842C0
        public void SetConnectionColor(){} // RVA: 0x7FFE866842D0
        public void SetConnectionWidth(){} // RVA: 0x7FFE86684300
        public void SetHandedness(){} // RVA: 0x7FFE86684610 | overloaded x2
        public void Draw(){} // RVA: 0x7FFE86684A20 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFE86684B30
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFE86684C00
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFE86684E20
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFE86685040
        public void ApplyConnectionColor(){} // RVA: 0x7FFE86685270
        public void ApplyConnectionWidth(){} // RVA: 0x7FFE866854C0
        public void .ctor(){} // RVA: 0x7FFE866856F0
    }

    public class MultiHandLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86685A30
        public void DrawLater(){} // RVA: 0x7FFE86685B50 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE86685BB0
        public void .ctor(){} // RVA: 0x7FFE86685D40
    }

    public class MultiPoseLandmarkListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE86685DB0
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE86685DE0
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86685E10
        public void SetConnectionColor(){} // RVA: 0x7FFE86685E20
        public void SetConnectionWidth(){} // RVA: 0x7FFE86685E50
        public void Draw(){} // RVA: 0x7FFE86685F70 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFE86686080
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFE86686180
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFE866863C0
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFE86686600
        public void ApplyConnectionColor(){} // RVA: 0x7FFE86686830
        public void ApplyConnectionWidth(){} // RVA: 0x7FFE86686A80
        public void .ctor(){} // RVA: 0x7FFE86686CB0
    }

    public class MultiPoseLandmarkListWithMaskAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE86686FD0
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE86687000
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86687030
        public void SetConnectionColor(){} // RVA: 0x7FFE86687040
        public void SetConnectionWidth(){} // RVA: 0x7FFE86687070
        public void InitMask(){} // RVA: 0x7FFE86687080
        public void SetMaskTexture(){} // RVA: 0x7FFE86687090
        public void SetMaskThreshold(){} // RVA: 0x7FFE86687120
        public void ReadMask(){} // RVA: 0x7FFE86687130
        public void Draw(){} // RVA: 0x7FFE86687210
        public void InstantiateChild(){} // RVA: 0x7FFE86687320
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFE86687530
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFE86687780
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFE866879D0
        public void ApplyConnectionColor(){} // RVA: 0x7FFE86687C10
        public void ApplyConnectionWidth(){} // RVA: 0x7FFE86687E70
        public void ApplyMaskTexture(){} // RVA: 0x7FFE866880B0
        public void ApplyMaskThreshold(){} // RVA: 0x7FFE866882F0
        public void .ctor(){} // RVA: 0x7FFE86688520
    }

    public class NormalizedLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86688850 | overloaded x3
        public void DrawLater(){} // RVA: 0x7FFE86688950 | overloaded x3
        public void SyncNow(){} // RVA: 0x7FFE866889B0
        public void FlattenNormalizedLandmarkLists(){} // RVA: 0x7FFE866889E0
        public void .ctor(){} // RVA: 0x7FFE86688D40
    }

    public class NormalizedRectAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86688E50
        public void DrawLater(){} // RVA: 0x7FFE86688EC0
        public void SyncNow(){} // RVA: 0x7FFE86688F20
        public void .ctor(){} // RVA: 0x7FFE86688F50
    }

    public class NormalizedRectListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE86688E50
        public void DrawLater(){} // RVA: 0x7FFE86688FC0
        public void SyncNow(){} // RVA: 0x7FFE86689020
        public void .ctor(){} // RVA: 0x7FFE866891E0
    }

    public class OutputStream`1 : Object
    {
        public int _Counter;
        public Mediapipe.GlobalInstanceTable`2<int,Mediapipe.Unity.OutputStream`1<T>> _InstanceTable;

        // ── Methods ──
        public void get_outputPacket(){} // RVA: 0x7FFE80E2E2E0
        public void add_OnReceived(){} // RVA: 0x7FFE80E460A0
        public void remove_OnReceived(){} // RVA: 0x7FFE80E460A0
        public void get_referencePacket(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void DisposeManaged(){} // RVA: 0x7FFE80E45FE0
        public void DisposeUnmanaged(){} // RVA: 0x7FFE80E45FE0
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
        public void StartPolling(){} // RVA: 0x7FFE80E45FE0
        public void AddListener(){} // RVA: 0x7FFE80E4B8B0
        public void RemoveListener(){} // RVA: 0x7FFE80E460A0
        public void WaitNextAsync(){} // RVA: 0x7FFE80E2E2E0
        public void WaitNextInternal(){} // RVA: 0x7FFE80E2E2E0
        public void StartWaitNextTask(){} // RVA: 0x7FFE80E2E2E0
        public void Next(){} // RVA: 0x7FFE80E2F3B0
        public void ClearWaitTask(){} // RVA: 0x7FFE80E45FE0
        public void InvokeOnReceived(){} // RVA: 0x7FFE80E460A0
        public void ThrowIfDisposed(){} // RVA: 0x7FFE80E45FE0
        public void InvokeIfOutputStreamFound(){} // RVA: 0x7FFE80E447F0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class PointAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE86689250
        public void OnDisable(){} // RVA: 0x7FFE86689290
        public void SetColor(){} // RVA: 0x7FFE866892A0
        public void SetRadius(){} // RVA: 0x7FFE866892D0
        public void Draw(){} // RVA: 0x7FFE86689C50 | overloaded x6
        public void ApplyColor(){} // RVA: 0x7FFE86689EA0
        public void ApplyRadius(){} // RVA: 0x7FFE86689F60
        public void GetColor(){} // RVA: 0x7FFE8668A080
        public void .ctor(){} // RVA: 0x7FFE8668A100
    }

    public class PointListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFE8668A160
        public void SetRadius(){} // RVA: 0x7FFE8668A190
        public void Draw(){} // RVA: 0x7FFE8668A820 | overloaded x9
        public void InstantiateChild(){} // RVA: 0x7FFE8668A930
        public void ApplyColor(){} // RVA: 0x7FFE8668A9D0
        public void ApplyRadius(){} // RVA: 0x7FFE8668AC10
        public void .ctor(){} // RVA: 0x7FFE8668AE30
    }

    public class PoseLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation _landmarkListAnnotation; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation _connectionListAnnotation; // 0x38
        public UnityEngine.Color _leftLandmarkColor; // 0x40

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86678C60
        public void set_rotationAngle(){} // RVA: 0x7FFE86678CD0
        public void get_Item(){} // RVA: 0x7FFE8668BFF0
        public void Start(){} // RVA: 0x7FFE8668C090
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE8668C180
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE8668C1B0
        public void SetLandmarkRadius(){} // RVA: 0x7FFE86678DE0
        public void SetConnectionColor(){} // RVA: 0x7FFE86678E10
        public void SetConnectionWidth(){} // RVA: 0x7FFE86678E50
        public void Draw(){} // RVA: 0x7FFE8668C890 | overloaded x10
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFE8668C940
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFE8668CB70
        public void ApplyMask(){} // RVA: 0x7FFE8668CDA0
        public void .ctor(){} // RVA: 0x7FFE8668D340
        public void .cctor(){} // RVA: 0x7FFE8668D3A0
    }

    public class PoseLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFE8667A9A0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFE8668E440 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE8668E4B0
        public void .ctor(){} // RVA: 0x7FFE8668E580
    }

    public class PoseLandmarkListWithMaskAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PoseLandmarkListAnnotation _poseLandmarkListAnnotation; // 0x30
        public Mediapipe.Unity.MaskOverlayAnnotation _maskOverlayAnnotation; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFE86678C60
        public void set_rotationAngle(){} // RVA: 0x7FFE86678CD0
        public void InitMask(){} // RVA: 0x7FFE8668E5F0
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFE8668E620
        public void SetRightLandmarkColor(){} // RVA: 0x7FFE8668E660
        public void SetLandmarkRadius(){} // RVA: 0x7FFE8667AC80
        public void SetConnectionColor(){} // RVA: 0x7FFE8667AD20
        public void SetConnectionWidth(){} // RVA: 0x7FFE8667AD60
        public void SetMaskTexture(){} // RVA: 0x7FFE8668E6A0
        public void SetMaskThreshold(){} // RVA: 0x7FFE8668E730
        public void ReadMask(){} // RVA: 0x7FFE8668E760
        public void Draw(){} // RVA: 0x7FFE8668E7B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PoseLandmarkerResultAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void InitScreen(){} // RVA: 0x7FFE8668B6E0
        public void DrawNow(){} // RVA: 0x7FFE8668B710
        public void DrawLater(){} // RVA: 0x7FFE8668B750
        public void ReadMask(){} // RVA: 0x7FFE8668B780
        public void UpdateCurrentTarget(){} // RVA: 0x7FFE8668B8A0
        public void SyncNow(){} // RVA: 0x7FFE8668B9F0
        public void .ctor(){} // RVA: 0x7FFE8668BF10
    }

    public class PoseWorldLandmarkListAnnotationController : AnnotationController`1
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8668E860
        public void DrawNow(){} // RVA: 0x7FFE8668E9D0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFE8668EAC0 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFE8668EB30
        public void .ctor(){} // RVA: 0x7FFE8668EC10
    }

    public class RectangleAnnotation : HierarchicalAnnotation
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE8668ECA0
        public void OnDisable(){} // RVA: 0x7FFE8668ECE0
        public void SetColor(){} // RVA: 0x7FFE8668EDB0
        public void SetLineWidth(){} // RVA: 0x7FFE8668EDE0
        public void Draw(){} // RVA: 0x7FFE8668F4B0 | overloaded x5
        public void ApplyColor(){} // RVA: 0x7FFE8668F650
        public void ApplyLineWidth(){} // RVA: 0x7FFE8668F7F0
        public void .ctor(){} // RVA: 0x7FFE8668F900
        public void .cctor(){} // RVA: 0x7FFE8668F960
    }

    public class RectangleListAnnotation : ListAnnotation`1
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFE8668FB50
        public void SetLineWidth(){} // RVA: 0x7FFE8668FB80
        public void Draw(){} // RVA: 0x7FFE8668FCA0 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFE8668FE50
        public void ApplyColor(){} // RVA: 0x7FFE8668FEF0
        public void ApplyLineWidth(){} // RVA: 0x7FFE86690130
        public void .ctor(){} // RVA: 0x7FFE86690350
    }

    public class RotationAngleExtension : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE86693E10
        public void Reverse(){} // RVA: 0x7FFE86693E40
        public void GetEulerAngles(){} // RVA: 0x7FFE86693E70
    }

    public class StreamingAssetsResourceManager : ResourceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86693360 | overloaded x2
        public void PrepareAssetAsync(){} // RVA: 0x7FFE866933B0
        public void PathToResourceAsFile(){} // RVA: 0x7FFE86693520
        public void GetResourceContents(){} // RVA: 0x7FFE866935B0
        public void CreateCacheFile(){} // RVA: 0x7FFE86693680
        public void GetAssetPathFor(){} // RVA: 0x7FFE86693720
        public void GetCachePathFor(){} // RVA: 0x7FFE866937C0
        public void .cctor(){} // RVA: 0x7FFE86693910
    }

}