// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity
// Classes: 53
// Methods: 533

namespace ThirdParty.Mediapipe.Mediapipe.Unity
{
    public class AnnotationController`1 : MonoBehaviour
    {
        public Mediapipe.Unity.MaskAnnotation isMirrored; // 0x20
        public bool rotationAngle; // 0x28
        public UnityEngine.Vector2Int imageSize; // 0x2C

        // ── Methods ──
        public void get_isMirrored(){} // RVA: 0x7FFD4E079D00
        public void set_isMirrored(){} // RVA: 0x7FFD4E091060
        public void get_rotationAngle(){} // RVA: 0x7FFD4E079960
        public void set_rotationAngle(){} // RVA: 0x7FFD4E090ED0
        public void get_imageSize(){}
        public void set_imageSize(){}
        public void Start(){} // RVA: 0x7FFD4E090980
        public void LateUpdate(){} // RVA: 0x7FFD4E090980
        public void OnDestroy(){} // RVA: 0x7FFD4E090980
        public void SyncNow(){} // RVA: 0x7FFD4E090980
        public void UpdateCurrentTarget(){} // RVA: 0x7FFD4E2ADC40
        public void IsTargetChanged(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Arrow : MonoBehaviour
    {
        public UnityEngine.Color cone; // 0x20
        public UnityEngine.Vector3 lineRenderer; // 0x30
        public float direction; // 0x3C
        public float magnitude; // 0x40
        public float color; // 0x44
        public UnityEngine.Transform _cone; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD536EA7F0
        public void get_cone(){} // RVA: 0x7FFD536EA870
        public void get_lineRenderer(){} // RVA: 0x7FFD536EAAB0
        public void get_direction(){} // RVA: 0x7FFD536EAB40
        public void set_direction(){} // RVA: 0x7FFD536EAB60
        public void get_magnitude(){} // RVA: 0x7FFD4EA5CE20
        public void set_magnitude(){} // RVA: 0x7FFD536EABB0
        public void get_color(){} // RVA: 0x7FFD4FE39630
        public void set_color(){} // RVA: 0x7FFD536EAC20
        public void SetVector(){} // RVA: 0x7FFD536EAC50
        public void SetCapScale(){} // RVA: 0x7FFD536EAD90
        public void SetLineWidth(){} // RVA: 0x7FFD536EADA0
        public void ApplyColor(){} // RVA: 0x7FFD536EADB0
        public void ApplyDirection(){} // RVA: 0x7FFD536EAF50
        public void ApplyMagnitude(){} // RVA: 0x7FFD536EB130
        public void ApplyCapScale(){} // RVA: 0x7FFD536EB490
        public void ApplyLineWidth(){} // RVA: 0x7FFD536EB570
        public void .ctor(){} // RVA: 0x7FFD536EB650
    }

    public class AssetBundleResourceManager : ResourceManager
    {
        public string _TAG;
        public string _AssetBundlePath; // 0x8
        public string _CachePathRoot; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53708D10
        public void PrepareAssetAsync(){} // RVA: 0x7FFD53709020
        public void PathToResourceAsFile(){} // RVA: 0x7FFD53709130
        public void GetResourceContents(){} // RVA: 0x7FFD537091C0
        public void GetCachePathFor(){} // RVA: 0x7FFD53709290
        public void .cctor(){} // RVA: 0x7FFD53709330
    }

    public class CircleAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.LineRenderer _lineRenderer; // 0x30
        public UnityEngine.Color _color; // 0x38
        public float _lineWidth; // 0x48

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD536EB700
        public void OnDisable(){} // RVA: 0x7FFD536EB740
        public void SetColor(){} // RVA: 0x7FFD536EB840
        public void SetLineWidth(){} // RVA: 0x7FFD536EB870
        public void Draw(){} // RVA: 0x7FFD536EB880
        public void ApplyColor(){} // RVA: 0x7FFD536EBC60
        public void ApplyLineWidth(){} // RVA: 0x7FFD536EBE00
        public void .ctor(){} // RVA: 0x7FFD536EBF10
    }

    public class Connection : Object
    {
        public Mediapipe.Unity.HierarchicalAnnotation start; // 0x10
        public Mediapipe.Unity.HierarchicalAnnotation end; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
    }

    public class ConnectionAnnotation : LineAnnotation
    {
        public Mediapipe.Unity.Connection isEmpty; // 0x50

        // ── Methods ──
        public void get_isEmpty(){} // RVA: 0x7FFD536EBF70
        public void Draw(){} // RVA: 0x7FFD536EBF80
        public void Redraw(){} // RVA: 0x7FFD536EC140
        public void ActivateFor(){} // RVA: 0x7FFD536EC150
        public void .ctor(){} // RVA: 0x7FFD536EBF10
    }

    public class ConnectionListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _color; // 0x40
        public float _lineWidth; // 0x50

        // ── Methods ──
        public void Fill(){} // RVA: 0x7FFD536EC1D0
        public void SetColor(){} // RVA: 0x7FFD536EC500
        public void SetLineWidth(){} // RVA: 0x7FFD536EC530
        public void Draw(){} // RVA: 0x7FFD536EC540
        public void Redraw(){} // RVA: 0x7FFD536EC6F0
        public void InstantiateChild(){} // RVA: 0x7FFD536EC910
        public void ApplyColor(){} // RVA: 0x7FFD536EC9B0
        public void ApplyLineWidth(){} // RVA: 0x7FFD536ECBF0
        public void .ctor(){} // RVA: 0x7FFD536ECE10
    }

    public class DetectionAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.RectangleAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.PointListAnnotation rotationAngle; // 0x38
        public Mediapipe.Unity.LabelAnnotation _labelAnnotation; // 0x40

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536ED150
        public void set_rotationAngle(){} // RVA: 0x7FFD536ED1E0
        public void SetLineWidth(){} // RVA: 0x7FFD536ED260
        public void SetKeypointRadius(){} // RVA: 0x7FFD536ED290
        public void Draw(){} // RVA: 0x7FFD536ED8A0 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFD536EDF90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DetectionAnnotationController : AnnotationController`1
    {
        public float _threshold; // 0x38
        public Mediapipe.Detection _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536EE030
        public void DrawLater(){} // RVA: 0x7FFD536EE0A0
        public void SyncNow(){} // RVA: 0x7FFD536EE100
        public void .ctor(){} // RVA: 0x7FFD536EE130
    }

    public class DetectionListAnnotation : ListAnnotation`1
    {
        public float _lineWidth; // 0x40
        public float _keypointRadius; // 0x44

        // ── Methods ──
        public void SetLineWidth(){} // RVA: 0x7FFD536EE1A0
        public void SetKeypointRadius(){} // RVA: 0x7FFD536EE1B0
        public void Draw(){} // RVA: 0x7FFD536EE510 | overloaded x4
        public void InstantiateChild(){} // RVA: 0x7FFD536EE540
        public void ApplyLineWidth(){} // RVA: 0x7FFD536EE5E0
        public void ApplyKeypointRadius(){} // RVA: 0x7FFD536EE810
        public void .ctor(){} // RVA: 0x7FFD536EEA40
    }

    public class DetectionListAnnotationController : AnnotationController`1
    {
        public float _threshold; // 0x38
        public System.Collections.Generic.IReadOnlyList`1<Mediapipe.Detection> _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536EECC0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFD536EED50 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD536EEDC0
        public void .ctor(){} // RVA: 0x7FFD536EEDF0
    }

    public class DetectionResultAnnotationController : AnnotationController`1
    {
        public float _threshold; // 0x38
        public Mediapipe.Tasks.Components.Containers.DetectionResult _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536EE030
        public void DrawLater(){} // RVA: 0x7FFD536EEE60
        public void SyncNow(){} // RVA: 0x7FFD536EEF10
        public void .ctor(){} // RVA: 0x7FFD536EF070
    }

    public class FaceLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation rotationAngle; // 0x38
        public int _LandmarkCount;
        public System.Collections.Generic.List`1<System.ValueTuple`2<int,int>> _connections; // 0x40

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536EF360
        public void set_rotationAngle(){} // RVA: 0x7FFD536EF3D0
        public void Start(){} // RVA: 0x7FFD536EF430
        public void SetLandmarkColor(){} // RVA: 0x7FFD536EF4A0
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536EF4E0
        public void SetConnectionColor(){} // RVA: 0x7FFD536EF510
        public void SetConnectionWidth(){} // RVA: 0x7FFD536EF550
        public void Draw(){} // RVA: 0x7FFD536EF760 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD536EF7F0
    }

    public class FaceLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public int _circleVertices; // 0x3C
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536F10A0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFD536F1190 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD536F1200
        public void .ctor(){} // RVA: 0x7FFD536F1240
    }

    public class FaceLandmarkListWithIrisAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.FaceLandmarkListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.IrisLandmarkListAnnotation rotationAngle; // 0x38
        public Mediapipe.Unity.IrisLandmarkListAnnotation _rightIrisLandmarkListAnnotation; // 0x40
        public int _FaceLandmarkCount;
        public int _IrisLandmarkCount;

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536ED150
        public void set_rotationAngle(){} // RVA: 0x7FFD536ED1E0
        public void SetFaceLandmarkColor(){} // RVA: 0x7FFD536F12C0
        public void SetIrisLandmarkColor(){} // RVA: 0x7FFD536F1300
        public void SetFaceLandmarkRadius(){} // RVA: 0x7FFD536F1380
        public void SetIrisLandmarkRadius(){} // RVA: 0x7FFD536F13B0
        public void SetFaceConnectionColor(){} // RVA: 0x7FFD536F1420
        public void SetFaceConnectionWidth(){} // RVA: 0x7FFD536F1460
        public void SetIrisCircleColor(){} // RVA: 0x7FFD536F1490
        public void SetIrisCircleWidth(){} // RVA: 0x7FFD536F1510
        public void Draw(){} // RVA: 0x7FFD536F16F0 | overloaded x4
        public void DrawFaceLandmarkList(){} // RVA: 0x7FFD536F18E0 | overloaded x2
        public void DrawLeftIrisLandmarkList(){} // RVA: 0x7FFD536F19C0 | overloaded x2
        public void DrawRightIrisLandmarkList(){} // RVA: 0x7FFD536F1A20 | overloaded x2
        public void PartitionLandmarkList(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FaceLandmarkerResultAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public Mediapipe.Tasks.Vision.FaceLandmarker.FaceLandmarkerResult _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536EF0E0
        public void DrawLater(){} // RVA: 0x7FFD536EF120
        public void UpdateCurrentTarget(){} // RVA: 0x7FFD536EF180
        public void SyncNow(){} // RVA: 0x7FFD536EF1D0
        public void .ctor(){} // RVA: 0x7FFD536EF2F0
    }

    public class GpuManager : Object
    {
        public object GpuResources;
        public UIntPtr GlCalculatorHelper; // 0x8
        public bool IsInitialized; // 0x10
        public Mediapipe.GpuResources <GpuResources>k__BackingField; // 0x18
        public Mediapipe.GlCalculatorHelper <GlCalculatorHelper>k__BackingField; // 0x20
        public bool <IsInitialized>k__BackingField; // 0x28

        // ── Methods ──
        public void get_GpuResources(){} // RVA: 0x7FFD53707F40
        public void set_GpuResources(){} // RVA: 0x7FFD53707FA0
        public void get_GlCalculatorHelper(){} // RVA: 0x7FFD53708060
        public void set_GlCalculatorHelper(){} // RVA: 0x7FFD537080C0
        public void get_IsInitialized(){} // RVA: 0x7FFD53708180
        public void set_IsInitialized(){} // RVA: 0x7FFD537081E0
        public void Initialize(){} // RVA: 0x7FFD53708240
        public void Shutdown(){} // RVA: 0x7FFD53708280
        public void .cctor(){} // RVA: 0x7FFD53708430
    }

    public class HandLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation rotationAngle; // 0x38
        public UnityEngine.Color Item; // 0x40
        public UnityEngine.Color _rightLandmarkColor; // 0x50
        public int _LandmarkCount;
        public System.Collections.Generic.List`1<System.ValueTuple`2<int,int>> _connections; // 0x60

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536EF360
        public void set_rotationAngle(){} // RVA: 0x7FFD536EF3D0
        public void get_Item(){} // RVA: 0x7FFD536F1CF0
        public void Start(){} // RVA: 0x7FFD536F1D90
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD5213E430
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD536F1E00
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536EF4E0
        public void SetConnectionColor(){} // RVA: 0x7FFD536EF510
        public void SetConnectionWidth(){} // RVA: 0x7FFD536EF550
        public void SetHandedness(){} // RVA: 0x7FFD536F21A0 | overloaded x5
        public void Draw(){} // RVA: 0x7FFD536F2390 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD536F2420
    }

    public class HandLandmarkerResultAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public Mediapipe.Tasks.Vision.HandLandmarker.HandLandmarkerResult _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536F1A50
        public void DrawLater(){} // RVA: 0x7FFD536F1A90
        public void UpdateCurrentTarget(){} // RVA: 0x7FFD536F1AF0
        public void SyncNow(){} // RVA: 0x7FFD536F1B40
        public void .ctor(){} // RVA: 0x7FFD536F1C80
    }

    public class HierarchicalAnnotation : MonoBehaviour
    {
        public Mediapipe.Unity.IHierachicalAnnotation root; // 0x20
        public bool isActive; // 0x28
        public 0x66575BA8 isActiveInHierarchy; // 0x2C

        // ── Methods ──
        public void get_root(){} // RVA: 0x7FFD536F2DC0
        public void set_root(){} // RVA: 0x7FFD4E36F0D0
        public void GetAnnotationLayer(){} // RVA: 0x7FFD536F3160
        public void GetScreenRect(){} // RVA: 0x7FFD536F3280
        public void get_isActive(){} // RVA: 0x7FFD536F3410
        public void get_isActiveInHierarchy(){} // RVA: 0x7FFD536F34B0
        public void SetActive(){} // RVA: 0x7FFD536F3550
        public void ActivateFor(){} // RVA: 0x7FFD4E2ADC40
        public void get_isMirrored(){} // RVA: 0x7FFD4E516BA0
        public void set_isMirrored(){} // RVA: 0x7FFD4F044F40
        public void get_rotationAngle(){} // RVA: 0x7FFD4F0A91D0
        public void set_rotationAngle(){} // RVA: 0x7FFD4F9D6490
        public void InstantiateChild(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Mediapipe.Unity.IHierachicalAnnotation.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class HolisticLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.FaceLandmarkListWithIrisAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.PoseLandmarkListAnnotation rotationAngle; // 0x38
        public Mediapipe.Unity.HandLandmarkListAnnotation _leftHandLandmarkListAnnotation; // 0x40
        public Mediapipe.Unity.HandLandmarkListAnnotation _rightHandLandmarkListAnnotation; // 0x48
        public Mediapipe.Unity.ConnectionListAnnotation _connectionListAnnotation; // 0x50

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536F36B0
        public void set_rotationAngle(){} // RVA: 0x7FFD536F3780
        public void Start(){} // RVA: 0x7FFD536F3840
        public void Draw(){} // RVA: 0x7FFD536F3B20 | overloaded x2
        public void RedrawWristJoints(){} // RVA: 0x7FFD536F3B90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class HolisticLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public int _circleVertices; // 0x3C
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentFaceLandmarkList; // 0x40
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentPoseLandmarkList; // 0x48
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentLeftHandLandmarkList; // 0x50
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentRightHandLandmarkList; // 0x58

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536F3FE0 | overloaded x2
        public void DrawFaceLandmarkListLater(){} // RVA: 0x7FFD536F4210 | overloaded x2
        public void DrawPoseLandmarkListLater(){} // RVA: 0x7FFD536F42E0 | overloaded x2
        public void DrawLeftHandLandmarkListLater(){} // RVA: 0x7FFD536F43B0 | overloaded x2
        public void DrawRightHandLandmarkListLater(){} // RVA: 0x7FFD536F4480 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD536F44F0
        public void .ctor(){} // RVA: 0x7FFD536F4550
    }

    public class IHierachicalAnnotation
    {
        public object root;
        public object transform;

        // ── Methods ──
        public void get_root(){} // RVA: 0x7FFD4E078E90
        public void get_transform(){} // RVA: 0x7FFD4E078E90
    }

    public class ImageFrameExtension : Object
    {
        // ── Methods ──
        public void TryReadChannelNormalized(){} // RVA: 0x7FFD53707500 | overloaded x3
        public void TryReadChannel(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ByteNormalizer(){} // RVA: 0x7FFD53707EE0
        public void UshortNormalizer(){} // RVA: 0x7FFD53707F00
        public void IsChannelNumberValid(){} // RVA: 0x7FFD53707F20
    }

    public class IrisLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.CircleAnnotation rotationAngle; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536EF360
        public void set_rotationAngle(){} // RVA: 0x7FFD536EF3D0
        public void SetLandmarkColor(){} // RVA: 0x7FFD536EF4A0
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536EF4E0
        public void SetCircleColor(){} // RVA: 0x7FFD536F45D0
        public void SetCircleWidth(){} // RVA: 0x7FFD536F4610
        public void Draw(){} // RVA: 0x7FFD536F4B80 | overloaded x4
        public void CalculateRadius(){} // RVA: 0x7FFD536F4CA0 | overloaded x2
        public void CalculateDistance(){} // RVA: 0x7FFD536F5290 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LabelAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.UI.Text _labelText; // 0x30
        public UnityEngine.Transform _backgroundTransform; // 0x38

        // ── Methods ──
        public void Draw(){} // RVA: 0x7FFD536F54A0
        public void GetFontSize(){} // RVA: 0x7FFD536F5B90
        public void DecideTextColor(){} // RVA: 0x7FFD536F5BE0
        public void CalcRelativeLuminance(){} // RVA: 0x7FFD536F5CE0
        public void CalcContrastRatio(){} // RVA: 0x7FFD536F5DE0
        public void ActivateFor(){} // RVA: 0x7FFD536F5E50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LineAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.LineRenderer _lineRenderer; // 0x30
        public UnityEngine.Color _color; // 0x38
        public float _lineWidth; // 0x48

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD536F5ED0
        public void OnDisable(){} // RVA: 0x7FFD536F5F10
        public void SetColor(){} // RVA: 0x7FFD536F5F20
        public void SetLineWidth(){} // RVA: 0x7FFD536F5F50
        public void Draw(){} // RVA: 0x7FFD536F6060 | overloaded x2
        public void ApplyColor(){} // RVA: 0x7FFD536F62C0
        public void ApplyLineWidth(){} // RVA: 0x7FFD536F6460
        public void .ctor(){} // RVA: 0x7FFD536EBF10
    }

    public class ListAnnotation`1 : HierarchicalAnnotation
    {
        public UnityEngine.GameObject children; // 0x30
        public System.Collections.Generic.List`1<Mediapipe.Unity.RectangleAnnotation> Item; // 0x38

        // ── Methods ──
        public void get_children(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_count(){} // RVA: 0x7FFD4E079960
        public void Fill(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void set_isMirrored(){} // RVA: 0x7FFD4E091060
        public void set_rotationAngle(){} // RVA: 0x7FFD4E090ED0
        public void Destroy(){} // RVA: 0x7FFD4E090980
        public void InstantiateChild(){} // RVA: 0x7FFD4E2ADC40
        public void CallActionForAll(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Logger : Object
    {
        public 0x66575730 MinLogLevel;

        // ── Methods ──
        public void set_MinLogLevel(){} // RVA: 0x7FFD53708C70
        public void .cctor(){} // RVA: 0x7FFD53708CD0
    }

    public class MaskAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.UI.RawImage _screen; // 0x30
        public UnityEngine.Shader _maskShader; // 0x38
        public UnityEngine.Texture2D _maskTexture; // 0x40
        public UnityEngine.Color _color; // 0x48
        public float _threshold; // 0x58
        public UnityEngine.Material _prevMaterial; // 0x60
        public UnityEngine.Material _material; // 0x68
        public UnityEngine.GraphicsBuffer _maskBuffer; // 0x70
        public float[] _maskArray; // 0x78

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD536F6570
        public void OnDisable(){} // RVA: 0x7FFD536F65B0
        public void OnDestroy(){} // RVA: 0x7FFD536F6690
        public void Init(){} // RVA: 0x7FFD536F6710
        public void Read(){} // RVA: 0x7FFD536F6900
        public void Clear(){} // RVA: 0x7FFD536F6930
        public void Draw(){} // RVA: 0x7FFD536F69A0 | overloaded x2
        public void CreateMonoColorTexture(){} // RVA: 0x7FFD536F69E0
        public void InitMaskBuffer(){} // RVA: 0x7FFD536F6B80
        public void ApplyMaterial(){} // RVA: 0x7FFD536F6DE0
        public void ApplyMaskTexture(){} // RVA: 0x7FFD536F7040
        public void ApplyThreshold(){} // RVA: 0x7FFD536F7230
        public void .ctor(){} // RVA: 0x7FFD536F7340
    }

    public class MaskAnnotationController : AnnotationController`1
    {
        public int _maskWidth; // 0x38
        public int _maskHeight; // 0x3C
        public Mediapipe.ImageFrame _currentTarget; // 0x40

        // ── Methods ──
        public void InitScreen(){} // RVA: 0x7FFD536F73A0
        public void DrawNow(){} // RVA: 0x7FFD536F73D0
        public void DrawLater(){} // RVA: 0x7FFD536F7480
        public void UpdateMaskArray(){} // RVA: 0x7FFD536F7510
        public void SyncNow(){} // RVA: 0x7FFD536F7550
        public void .ctor(){} // RVA: 0x7FFD536F75C0
    }

    public class MaskOverlayAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.Shader _maskShader; // 0x30
        public UnityEngine.Texture2D _maskTexture; // 0x38
        public UnityEngine.Color _color; // 0x40
        public float _threshold; // 0x50
        public UnityEngine.GameObject _screenObject; // 0x58
        public UnityEngine.UI.RawImage _screen; // 0x60
        public UnityEngine.Material _prevMaterial; // 0x68
        public UnityEngine.Material _material; // 0x70
        public UnityEngine.GraphicsBuffer _maskBuffer; // 0x78
        public float[] _maskArray; // 0x80

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD536F7630
        public void OnDisable(){} // RVA: 0x7FFD536F7780
        public void OnDestroy(){} // RVA: 0x7FFD536F7940
        public void Init(){} // RVA: 0x7FFD536F7AB0
        public void SetMaskTexture(){} // RVA: 0x7FFD536F7FD0
        public void SetThreshold(){} // RVA: 0x7FFD536F8050
        public void Read(){} // RVA: 0x7FFD536F80A0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD536F80E0
        public void Draw(){} // RVA: 0x7FFD536F81D0 | overloaded x3
        public void CreateMonoColorTexture(){} // RVA: 0x7FFD536F8210
        public void InitMaskBuffer(){} // RVA: 0x7FFD536F83B0
        public void ApplyMaterial(){} // RVA: 0x7FFD536F8620
        public void ApplyMaskTexture(){} // RVA: 0x7FFD536F8880
        public void ApplyThreshold(){} // RVA: 0x7FFD536F8A70
        public void .ctor(){} // RVA: 0x7FFD536F8B80
    }

    public class MultiFaceLandmarkListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _faceLandmarkColor; // 0x40
        public UnityEngine.Color _irisLandmarkColor; // 0x50
        public float _faceLandmarkRadius; // 0x60
        public float _irisLandmarkRadius; // 0x64
        public UnityEngine.Color _faceConnectionColor; // 0x68
        public UnityEngine.Color _irisCircleColor; // 0x78
        public float _faceConnectionWidth; // 0x88
        public float _irisCircleWidth; // 0x8C

        // ── Methods ──
        public void SetFaceLandmarkRadius(){} // RVA: 0x7FFD536F8BE0
        public void SetIrisLandmarkRadius(){} // RVA: 0x7FFD536F8BF0
        public void SetFaceLandmarkColor(){} // RVA: 0x7FFD536F8C00
        public void SetIrisLandmarkColor(){} // RVA: 0x7FFD536F8C30
        public void SetFaceConnectionWidth(){} // RVA: 0x7FFD536F8C60
        public void SetFaceConnectionColor(){} // RVA: 0x7FFD536F8C70
        public void SetIrisCircleWidth(){} // RVA: 0x7FFD536F8CA0
        public void SetIrisCircleColor(){} // RVA: 0x7FFD536F8CB0
        public void Draw(){} // RVA: 0x7FFD536F8DF0 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFD536F8F00
        public void ApplyFaceLandmarkRadius(){} // RVA: 0x7FFD536F91A0
        public void ApplyIrisLandmarkRadius(){} // RVA: 0x7FFD536F93E0
        public void ApplyFaceLandmarkColor(){} // RVA: 0x7FFD536F9600
        public void ApplyIrisLandmarkColor(){} // RVA: 0x7FFD536F9860
        public void ApplyFaceConnectionWidth(){} // RVA: 0x7FFD536F9AA0
        public void ApplyFaceConnectionColor(){} // RVA: 0x7FFD536F9CE0
        public void ApplyIrisCircleWidth(){} // RVA: 0x7FFD536F9F40
        public void ApplyIrisCircleColor(){} // RVA: 0x7FFD536FA160
        public void .ctor(){} // RVA: 0x7FFD536FA3A0
    }

    public class MultiFaceLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public System.Collections.Generic.IReadOnlyList`1<0x66572768> _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536EE030
        public void DrawLater(){} // RVA: 0x7FFD536FA770
        public void SyncNow(){} // RVA: 0x7FFD536FA7D0
        public void .ctor(){} // RVA: 0x7FFD536FA8F0
    }

    public class MultiHandLandmarkListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _leftLandmarkColor; // 0x40
        public UnityEngine.Color _rightLandmarkColor; // 0x50
        public float _landmarkRadius; // 0x60
        public UnityEngine.Color _connectionColor; // 0x64
        public float _connectionWidth; // 0x74

        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD536FA960
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD536FA990
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536FA9C0
        public void SetConnectionColor(){} // RVA: 0x7FFD536FA9D0
        public void SetConnectionWidth(){} // RVA: 0x7FFD536FAA00
        public void SetHandedness(){} // RVA: 0x7FFD536FAD10 | overloaded x2
        public void Draw(){} // RVA: 0x7FFD536FB120 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFD536FB230
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFD536FB300
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFD536FB520
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFD536FB740
        public void ApplyConnectionColor(){} // RVA: 0x7FFD536FB970
        public void ApplyConnectionWidth(){} // RVA: 0x7FFD536FBBC0
        public void .ctor(){} // RVA: 0x7FFD536FBDF0
    }

    public class MultiHandLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public System.Collections.Generic.IReadOnlyList`1<0x66572768> _currentHandLandmarkLists; // 0x40
        public System.Collections.Generic.IReadOnlyList`1<0x66571E78> _currentHandedness; // 0x48

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536FC130
        public void DrawLater(){} // RVA: 0x7FFD536FC250 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD536FC2B0
        public void .ctor(){} // RVA: 0x7FFD536FC440
    }

    public class MultiPoseLandmarkListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _leftLandmarkColor; // 0x40
        public UnityEngine.Color _rightLandmarkColor; // 0x50
        public float _landmarkRadius; // 0x60
        public UnityEngine.Color _connectionColor; // 0x64
        public float _connectionWidth; // 0x74

        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD536FC4B0
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD536FC4E0
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536FC510
        public void SetConnectionColor(){} // RVA: 0x7FFD536FC520
        public void SetConnectionWidth(){} // RVA: 0x7FFD536FC550
        public void Draw(){} // RVA: 0x7FFD536FC670 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFD536FC780
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFD536FC880
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFD536FCAC0
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFD536FCD00
        public void ApplyConnectionColor(){} // RVA: 0x7FFD536FCF30
        public void ApplyConnectionWidth(){} // RVA: 0x7FFD536FD180
        public void .ctor(){} // RVA: 0x7FFD536FD3B0
    }

    public class MultiPoseLandmarkListWithMaskAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _leftLandmarkColor; // 0x40
        public UnityEngine.Color _rightLandmarkColor; // 0x50
        public float _landmarkRadius; // 0x60
        public UnityEngine.Color _connectionColor; // 0x64
        public float _connectionWidth; // 0x74
        public UnityEngine.UI.RawImage _screen; // 0x78
        public UnityEngine.Texture2D _maskTexture; // 0x80
        public UnityEngine.Color _color; // 0x88
        public float _maskThreshold; // 0x98
        public int _maskWidth; // 0x9C
        public int _maskHeight; // 0xA0

        // ── Methods ──
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD536FD6D0
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD536FD700
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536FD730
        public void SetConnectionColor(){} // RVA: 0x7FFD536FD740
        public void SetConnectionWidth(){} // RVA: 0x7FFD536FD770
        public void InitMask(){} // RVA: 0x7FFD536FD780
        public void SetMaskTexture(){} // RVA: 0x7FFD536FD790
        public void SetMaskThreshold(){} // RVA: 0x7FFD536FD820
        public void ReadMask(){} // RVA: 0x7FFD536FD830
        public void Draw(){} // RVA: 0x7FFD536FD910
        public void InstantiateChild(){} // RVA: 0x7FFD536FDA20
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFD536FDC30
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFD536FDE80
        public void ApplyLandmarkRadius(){} // RVA: 0x7FFD536FE0D0
        public void ApplyConnectionColor(){} // RVA: 0x7FFD536FE310
        public void ApplyConnectionWidth(){} // RVA: 0x7FFD536FE570
        public void ApplyMaskTexture(){} // RVA: 0x7FFD536FE7B0
        public void ApplyMaskThreshold(){} // RVA: 0x7FFD536FE9F0
        public void .ctor(){} // RVA: 0x7FFD536FEC20
    }

    public class NormalizedLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536FEF50 | overloaded x3
        public void DrawLater(){} // RVA: 0x7FFD536FF050 | overloaded x3
        public void SyncNow(){} // RVA: 0x7FFD536FF0B0
        public void FlattenNormalizedLandmarkLists(){} // RVA: 0x7FFD536FF0E0
        public void .ctor(){} // RVA: 0x7FFD536FF440
    }

    public class NormalizedRectAnnotationController : AnnotationController`1
    {
        public 0x66573000 _currentTarget; // 0x38

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536FF550
        public void DrawLater(){} // RVA: 0x7FFD536FF5C0
        public void SyncNow(){} // RVA: 0x7FFD536FF620
        public void .ctor(){} // RVA: 0x7FFD536FF650
    }

    public class NormalizedRectListAnnotationController : AnnotationController`1
    {
        public System.Collections.Generic.IReadOnlyList`1<0x66573000> _currentTarget; // 0x38

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536FF550
        public void DrawLater(){} // RVA: 0x7FFD536FF6C0
        public void SyncNow(){} // RVA: 0x7FFD536FF720
        public void .ctor(){} // RVA: 0x7FFD536FF8E0
    }

    public class OutputStream`1 : Object
    {
        public int outputPacket;
        public Mediapipe.GlobalInstanceTable`2<int,Mediapipe.Unity.OutputStream`1<T>> referencePacket;
        public Mediapipe.CalculatorGraph _calculatorGraph;
        public int _id;
        public string streamName;
        public bool observeTimestampBounds;
        public Mediapipe.OutputStreamPoller`1<T> _poller;
        public Mediapipe.Packet`1<T> _outputPacket;
        public 0x66559068 _waitTaskLock;
        public System.Threading.Tasks.Task`1<NextResult<T>> _waitTask;
        public System.EventHandler`1<OutputEventArgs<T>> OnReceived;
        public long _lastTimestampMicrosec;
        public Mediapipe.Packet`1<T> _referencePacket;
        public int _disposeSignaled;
        public bool _isDisposed;

        // ── Methods ──
        public void get_outputPacket(){} // RVA: 0x7FFD4E078E90
        public void add_OnReceived(){} // RVA: 0x7FFD4E090A40
        public void remove_OnReceived(){} // RVA: 0x7FFD4E090A40
        public void get_referencePacket(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void DisposeManaged(){} // RVA: 0x7FFD4E090980
        public void DisposeUnmanaged(){} // RVA: 0x7FFD4E090980
        public void Finalize(){} // RVA: 0x7FFD4E090980
        public void StartPolling(){} // RVA: 0x7FFD4E090980
        public void AddListener(){} // RVA: 0x7FFD4E0961B0
        public void RemoveListener(){} // RVA: 0x7FFD4E090A40
        public void WaitNextAsync(){} // RVA: 0x7FFD4E078E90
        public void WaitNextInternal(){} // RVA: 0x7FFD4E078E90
        public void StartWaitNextTask(){} // RVA: 0x7FFD4E078E90
        public void Next(){} // RVA: 0x7FFD4E079F60
        public void ClearWaitTask(){} // RVA: 0x7FFD4E090980
        public void InvokeOnReceived(){} // RVA: 0x7FFD4E090A40
        public void ThrowIfDisposed(){} // RVA: 0x7FFD4E090980
        public void InvokeIfOutputStreamFound(){} // RVA: 0x7FFD4E08F1A0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class PointAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.Color _color; // 0x30
        public float _radius; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD536FF950
        public void OnDisable(){} // RVA: 0x7FFD536FF990
        public void SetColor(){} // RVA: 0x7FFD536FF9A0
        public void SetRadius(){} // RVA: 0x7FFD536FF9D0
        public void Draw(){} // RVA: 0x7FFD53700350 | overloaded x6
        public void ApplyColor(){} // RVA: 0x7FFD537005A0
        public void ApplyRadius(){} // RVA: 0x7FFD53700660
        public void GetColor(){} // RVA: 0x7FFD53700780
        public void .ctor(){} // RVA: 0x7FFD53700800
    }

    public class PointListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _color; // 0x40
        public float _radius; // 0x50

        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFD53700860
        public void SetRadius(){} // RVA: 0x7FFD53700890
        public void Draw(){} // RVA: 0x7FFD53700F20 | overloaded x9
        public void InstantiateChild(){} // RVA: 0x7FFD53701030
        public void ApplyColor(){} // RVA: 0x7FFD537010D0
        public void ApplyRadius(){} // RVA: 0x7FFD53701310
        public void .ctor(){} // RVA: 0x7FFD53701530
    }

    public class PoseLandmarkListAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PointListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.ConnectionListAnnotation rotationAngle; // 0x38
        public UnityEngine.Color Item; // 0x40
        public UnityEngine.Color _rightLandmarkColor; // 0x50
        public int _LandmarkCount;
        public int[] _LeftLandmarks;
        public int[] _RightLandmarks; // 0x8
        public System.Collections.Generic.List`1<System.ValueTuple`2<int,int>> _Connections; // 0x10

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536EF360
        public void set_rotationAngle(){} // RVA: 0x7FFD536EF3D0
        public void get_Item(){} // RVA: 0x7FFD537026F0
        public void Start(){} // RVA: 0x7FFD53702790
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD53702880
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD537028B0
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536EF4E0
        public void SetConnectionColor(){} // RVA: 0x7FFD536EF510
        public void SetConnectionWidth(){} // RVA: 0x7FFD536EF550
        public void Draw(){} // RVA: 0x7FFD53702F90 | overloaded x10
        public void ApplyLeftLandmarkColor(){} // RVA: 0x7FFD53703040
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFD53703270
        public void ApplyMask(){} // RVA: 0x7FFD537034A0
        public void .ctor(){} // RVA: 0x7FFD53703A40
        public void .cctor(){} // RVA: 0x7FFD53703AA0
    }

    public class PoseLandmarkListAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public System.Collections.Generic.IReadOnlyList`1<0x665726B8> _currentTarget; // 0x40

        // ── Methods ──
        public void DrawNow(){} // RVA: 0x7FFD536F10A0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFD53704B40 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD53704BB0
        public void .ctor(){} // RVA: 0x7FFD53704C80
    }

    public class PoseLandmarkListWithMaskAnnotation : HierarchicalAnnotation
    {
        public Mediapipe.Unity.PoseLandmarkListAnnotation isMirrored; // 0x30
        public Mediapipe.Unity.MaskOverlayAnnotation rotationAngle; // 0x38

        // ── Methods ──
        public void set_isMirrored(){} // RVA: 0x7FFD536EF360
        public void set_rotationAngle(){} // RVA: 0x7FFD536EF3D0
        public void InitMask(){} // RVA: 0x7FFD53704CF0
        public void SetLeftLandmarkColor(){} // RVA: 0x7FFD53704D20
        public void SetRightLandmarkColor(){} // RVA: 0x7FFD53704D60
        public void SetLandmarkRadius(){} // RVA: 0x7FFD536F1380
        public void SetConnectionColor(){} // RVA: 0x7FFD536F1420
        public void SetConnectionWidth(){} // RVA: 0x7FFD536F1460
        public void SetMaskTexture(){} // RVA: 0x7FFD53704DA0
        public void SetMaskThreshold(){} // RVA: 0x7FFD53704E30
        public void ReadMask(){} // RVA: 0x7FFD53704E60
        public void Draw(){} // RVA: 0x7FFD53704EB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PoseLandmarkerResultAnnotationController : AnnotationController`1
    {
        public bool _visualizeZ; // 0x38
        public object _currentTargetLock; // 0x40
        public Mediapipe.Tasks.Vision.PoseLandmarker.PoseLandmarkerResult _currentTarget; // 0x48

        // ── Methods ──
        public void InitScreen(){} // RVA: 0x7FFD53701DE0
        public void DrawNow(){} // RVA: 0x7FFD53701E10
        public void DrawLater(){} // RVA: 0x7FFD53701E50
        public void ReadMask(){} // RVA: 0x7FFD53701E80
        public void UpdateCurrentTarget(){} // RVA: 0x7FFD53701FA0
        public void SyncNow(){} // RVA: 0x7FFD537020F0
        public void .ctor(){} // RVA: 0x7FFD53702610
    }

    public class PoseWorldLandmarkListAnnotationController : AnnotationController`1
    {
        public float _hipHeightMeter; // 0x38
        public UnityEngine.Vector3 _scale; // 0x3C
        public bool _visualizeZ; // 0x48
        public System.Collections.Generic.IReadOnlyList`1<Mediapipe.Landmark> _currentTarget; // 0x50

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD53704F60
        public void DrawNow(){} // RVA: 0x7FFD537050D0 | overloaded x2
        public void DrawLater(){} // RVA: 0x7FFD537051C0 | overloaded x2
        public void SyncNow(){} // RVA: 0x7FFD53705230
        public void .ctor(){} // RVA: 0x7FFD53705310
    }

    public class RectangleAnnotation : HierarchicalAnnotation
    {
        public UnityEngine.LineRenderer _lineRenderer; // 0x30
        public UnityEngine.Color _color; // 0x38
        public float _lineWidth; // 0x48
        public UnityEngine.Vector3[] _EmptyPositions;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD537053A0
        public void OnDisable(){} // RVA: 0x7FFD537053E0
        public void SetColor(){} // RVA: 0x7FFD537054B0
        public void SetLineWidth(){} // RVA: 0x7FFD537054E0
        public void Draw(){} // RVA: 0x7FFD53705BB0 | overloaded x5
        public void ApplyColor(){} // RVA: 0x7FFD53705D50
        public void ApplyLineWidth(){} // RVA: 0x7FFD53705EF0
        public void .ctor(){} // RVA: 0x7FFD53706000
        public void .cctor(){} // RVA: 0x7FFD53706060
    }

    public class RectangleListAnnotation : ListAnnotation`1
    {
        public UnityEngine.Color _color; // 0x40
        public float _lineWidth; // 0x50

        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFD53706250
        public void SetLineWidth(){} // RVA: 0x7FFD53706280
        public void Draw(){} // RVA: 0x7FFD537063A0 | overloaded x2
        public void InstantiateChild(){} // RVA: 0x7FFD53706550
        public void ApplyColor(){} // RVA: 0x7FFD537065F0
        public void ApplyLineWidth(){} // RVA: 0x7FFD53706830
        public void .ctor(){} // RVA: 0x7FFD53706A50
    }

    public class RotationAngleExtension : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD5370A510
        public void Reverse(){} // RVA: 0x7FFD5370A540
        public void GetEulerAngles(){} // RVA: 0x7FFD5370A570
    }

    public class StreamingAssetsResourceManager : ResourceManager
    {
        public string _TAG;
        public string _RelativePath; // 0x8
        public string _AssetPathRoot; // 0x10
        public string _CachePathRoot; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53709A60 | overloaded x2
        public void PrepareAssetAsync(){} // RVA: 0x7FFD53709AB0
        public void PathToResourceAsFile(){} // RVA: 0x7FFD53709C20
        public void GetResourceContents(){} // RVA: 0x7FFD53709CB0
        public void CreateCacheFile(){} // RVA: 0x7FFD53709D80
        public void GetAssetPathFor(){} // RVA: 0x7FFD53709E20
        public void GetCachePathFor(){} // RVA: 0x7FFD53709EC0
        public void .cctor(){} // RVA: 0x7FFD5370A010
    }

}