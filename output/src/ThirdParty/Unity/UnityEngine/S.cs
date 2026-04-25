// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 473

namespace ThirdParty.Unity.UnityEngine
{
    public class ScalableBufferManager : Object
    {
        public object widthScaleFactor;
        public object heightScaleFactor;

        // ── Methods ──
        public void get_widthScaleFactor(){} // RVA: 0x7FFAC98719B0
        public void get_heightScaleFactor(){} // RVA: 0x7FFAC9871A00
    }

    public class Screen : Object
    {
        public object width;
        public object height;
        public object dpi;
        public object orientation;
        public object sleepTimeout;
        public object autorotateToPortrait;
        public object autorotateToPortraitUpsideDown;
        public object autorotateToLandscapeLeft;
        public object autorotateToLandscapeRight;
        public object currentResolution;
        public object fullScreen;
        public object fullScreenMode;
        public object safeArea;
        public object resolutions;

        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAC986C180
        public void get_height(){} // RVA: 0x7FFAC986C1D0
        public void get_dpi(){} // RVA: 0x7FFAC986C220
        public void RequestOrientation(){} // RVA: 0x7FFAC986C270
        public void GetScreenOrientation(){} // RVA: 0x7FFAC967F1C0
        public void get_orientation(){} // RVA: 0x7FFAC967F1C0
        public void set_orientation(){} // RVA: 0x7FFAC986C2C0
        public void set_sleepTimeout(){} // RVA: 0x7FFAC986C370
        public void SetOrientationEnabled(){} // RVA: 0x7FFAC986C3C0
        public void set_autorotateToPortrait(){} // RVA: 0x7FFAC986C420
        public void set_autorotateToPortraitUpsideDown(){} // RVA: 0x7FFAC986C480
        public void set_autorotateToLandscapeLeft(){} // RVA: 0x7FFAC986C4E0
        public void set_autorotateToLandscapeRight(){} // RVA: 0x7FFAC986C540
        public void get_currentResolution(){} // RVA: 0x7FFAC986C5A0
        public void get_fullScreen(){} // RVA: 0x7FFAC39A9AD0
        public void set_fullScreen(){} // RVA: 0x7FFAC986C600
        public void get_fullScreenMode(){} // RVA: 0x7FFAC986C650
        public void get_safeArea(){} // RVA: 0x7FFAC986C6A0
        public void SetResolution(){} // RVA: 0x7FFAC986C820 | overloaded x3
        public void get_resolutions(){} // RVA: 0x7FFAC986C8C0
        public void get_currentResolution_Injected(){} // RVA: 0x7FFAC986C910
        public void get_safeArea_Injected(){} // RVA: 0x7FFAC986C960
        public void SetResolution_Injected(){} // RVA: 0x7FFAC986C9B0
    }

    public class ScreenCapture : Object
    {
        // ── Methods ──
        public void CaptureScreenshotIntoRenderTexture(){} // RVA: 0x7FFAC99EDBE0
    }

    public class ScriptableObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C32A0
        public void CreateInstance(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CreateScriptableObject(){} // RVA: 0x7FFAC98C3390
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC98C33E0
    }

    public class ScriptingRuntime : Object
    {
        // ── Methods ──
        public void GetAllUserAssemblies(){} // RVA: 0x7FFAC98C3440
    }

    public class ScriptingUtility : Object
    {
        // ── Methods ──
        public void IsManagedCodeWorking(){} // RVA: 0x7FFAC4BF82C0
    }

    public class ScrollViewState : Object
    {
        public UnityEngine.Rect position; // 0x10
        public UnityEngine.Rect visibleRect; // 0x20
        public UnityEngine.Rect viewRect; // 0x30
        public UnityEngine.Vector2 scrollPosition; // 0x40
        public bool apply; // 0x48
        public bool isDuringTouchScroll; // 0x49
        public UnityEngine.Vector2 touchScrollStartMousePosition; // 0x4C
        public UnityEngine.Vector2 touchScrollStartPosition; // 0x54
        public UnityEngine.Vector2 velocity; // 0x5C
        public float previousTimeSinceStartup; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecondarySpriteTexture : ValueType
    {
        public string name; // 0x10
        public UnityEngine.Texture2D texture; // 0x18
    }

    public class SelectionBaseAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SendMouseEvents : Object
    {
        public bool s_MouseUsed;
        public HitInfo[] m_LastHit; // 0x8
        public HitInfo[] m_MouseDownHit; // 0x10
        public HitInfo[] m_CurrentHit; // 0x18
        public UnityEngine.Camera[] m_Cameras; // 0x20
        public System.Func`1<System.Collections.Generic.KeyValuePair`2<int,UnityEngine.Vector2>> s_GetMouseState; // 0x28
        public UnityEngine.Vector2 s_MousePosition; // 0x30
        public bool s_MouseButtonPressedThisFrame; // 0x38
        public bool s_MouseButtonIsPressed; // 0x39

        // ── Methods ──
        public void UpdateMouse(){} // RVA: 0x7FFAC9940C50
        public void SetMouseMoved(){} // RVA: 0x7FFAC9940F50
        public void DoSendMouseEvents(){} // RVA: 0x7FFAC9940FB0
        public void SendEvents(){} // RVA: 0x7FFAC9941CF0
        public void .cctor(){} // RVA: 0x7FFAC99423E0
    }

    public class SerializeField : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SerializeReference : Attribute
    {
    }

    public class SetupCoroutine : Object
    {
        // ── Methods ──
        public void InvokeMoveNext(){} // RVA: 0x7FFAC98BCAF0
        public void InvokeMember(){} // RVA: 0x7FFAC98BCBB0
    }

    public class Shader : Object
    {
        public object maximumChunksOverride;
        public object maximumLOD;
        public object isSupported;
        public object renderQueue;

        // ── Methods ──
        public void Find(){} // RVA: 0x7FFAC987FE80
        public void get_maximumChunksOverride(){} // RVA: 0x7FFAC987FEF0
        public void set_maximumChunksOverride(){} // RVA: 0x7FFAC987FF40
        public void set_maximumLOD(){} // RVA: 0x7FFAC987FF90
        public void get_isSupported(){} // RVA: 0x7FFAC987FFF0
        public void EnableKeyword(){} // RVA: 0x7FFAC9880040
        public void DisableKeyword(){} // RVA: 0x7FFAC9880090
        public void get_renderQueue(){} // RVA: 0x7FFAC98800E0
        public void WarmupAllShaders(){} // RVA: 0x7FFAC9880130
        public void TagToID(){} // RVA: 0x7FFAC9880180
        public void PropertyToID(){} // RVA: 0x7FFAC98801D0
        public void SetGlobalIntImpl(){} // RVA: 0x7FFAC9880220
        public void SetGlobalFloatImpl(){} // RVA: 0x7FFAC9880280
        public void SetGlobalVectorImpl(){} // RVA: 0x7FFAC98802E0
        public void SetGlobalMatrixImpl(){} // RVA: 0x7FFAC9880340
        public void SetGlobalTextureImpl(){} // RVA: 0x7FFAC98803A0
        public void SetGlobalFloatArrayImpl(){} // RVA: 0x7FFAC9880400
        public void SetGlobalVectorArrayImpl(){} // RVA: 0x7FFAC9880470
        public void SetGlobalMatrixArrayImpl(){} // RVA: 0x7FFAC98804E0
        public void SetGlobalFloatArray(){} // RVA: 0x7FFAC9880E60 | overloaded x3
        public void SetGlobalVectorArray(){} // RVA: 0x7FFAC9880EF0 | overloaded x3
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFAC9880F80 | overloaded x3
        public void SetGlobalInt(){} // RVA: 0x7FFAC9880A20 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFAC9880280 | overloaded x2
        public void SetGlobalInteger(){} // RVA: 0x7FFAC9880220
        public void SetGlobalVector(){} // RVA: 0x7FFAC9880BD0 | overloaded x2
        public void SetGlobalColor(){} // RVA: 0x7FFAC9880C30
        public void SetGlobalMatrix(){} // RVA: 0x7FFAC9880CD0
        public void SetGlobalTexture(){} // RVA: 0x7FFAC98803A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9880FA0
        public void SetGlobalVectorImpl_Injected(){} // RVA: 0x7FFAC9880FF0
        public void SetGlobalMatrixImpl_Injected(){} // RVA: 0x7FFAC9881050
    }

    public class SharedBetweenAnimatorsAttribute : Attribute
    {
    }

    public class SkeletonBone : ValueType
    {
        public string name; // 0x10
        public string parentName; // 0x18
        public UnityEngine.Vector3 position; // 0x20
        public UnityEngine.Quaternion rotation; // 0x2C
        public UnityEngine.Vector3 scale; // 0x3C
    }

    public class SkinnedMeshRenderer : Renderer
    {
        public object quality;
        public object updateWhenOffscreen;
        public object forceMatrixRecalculationPerRender;
        public object rootBone;
        public object bones;
        public object sharedMesh;
        public object skinnedMotionVectors;
        public object vertexBufferTarget;

        // ── Methods ──
        public void get_quality(){} // RVA: 0x7FFAC988BEC0
        public void set_quality(){} // RVA: 0x7FFAC988BF10
        public void get_updateWhenOffscreen(){} // RVA: 0x7FFAC988BF70
        public void set_updateWhenOffscreen(){} // RVA: 0x7FFAC988BFC0
        public void get_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFAC988C020
        public void set_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFAC988C070
        public void get_rootBone(){} // RVA: 0x7FFAC988C0D0
        public void set_rootBone(){} // RVA: 0x7FFAC988C120
        public void get_bones(){} // RVA: 0x7FFAC988C180
        public void set_bones(){} // RVA: 0x7FFAC988C1D0
        public void get_sharedMesh(){} // RVA: 0x7FFAC988C230
        public void set_sharedMesh(){} // RVA: 0x7FFAC988C280
        public void get_skinnedMotionVectors(){} // RVA: 0x7FFAC988C2E0
        public void set_skinnedMotionVectors(){} // RVA: 0x7FFAC988C330
        public void GetBlendShapeWeight(){} // RVA: 0x7FFAC988C390
        public void SetBlendShapeWeight(){} // RVA: 0x7FFAC988C3F0
        public void BakeMesh(){} // RVA: 0x7FFAC988C4D0 | overloaded x2
        public void GetVertexBuffer(){} // RVA: 0x7FFAC988C540
        public void GetPreviousVertexBuffer(){} // RVA: 0x7FFAC988C680
        public void GetVertexBufferImpl(){} // RVA: 0x7FFAC988C7C0
        public void GetPreviousVertexBufferImpl(){} // RVA: 0x7FFAC988C810
        public void get_vertexBufferTarget(){} // RVA: 0x7FFAC988C860
        public void set_vertexBufferTarget(){} // RVA: 0x7FFAC988C8B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Skybox : Behaviour
    {
        public object material;

        // ── Methods ──
        public void get_material(){} // RVA: 0x7FFAC988B0D0
        public void set_material(){} // RVA: 0x7FFAC988B120
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SliderHandler : ValueType
    {
        public UnityEngine.Rect position; // 0x10
        public float currentValue; // 0x20
        public float size; // 0x24
        public float start; // 0x28
        public float end; // 0x2C
        public UnityEngine.GUIStyle slider; // 0x30
        public UnityEngine.GUIStyle thumb; // 0x38
        public UnityEngine.GUIStyle thumbExtent; // 0x40
        public bool horiz; // 0x48
        public int id; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC992E340
        public void Handle(){} // RVA: 0x7FFAC992E490
        public void OnMouseDown(){} // RVA: 0x7FFAC992E520
        public void OnMouseDrag(){} // RVA: 0x7FFAC992EC00
        public void OnMouseUp(){} // RVA: 0x7FFAC992EDB0
        public void OnRepaint(){} // RVA: 0x7FFAC992EE70
        public void CurrentEventType(){} // RVA: 0x7FFAC992F610
        public void CurrentScrollTroughSide(){} // RVA: 0x7FFAC992F6B0
        public void IsEmptySlider(){} // RVA: 0x7FFAC992F7B0
        public void SupportsPageMovements(){} // RVA: 0x7FFAC992F7D0
        public void PageMovementValue(){} // RVA: 0x7FFAC992F880
        public void PageUpMovementBound(){} // RVA: 0x7FFAC992F930
        public void CurrentEvent(){} // RVA: 0x7FFAC99062D0
        public void ValueForCurrentMousePosition(){} // RVA: 0x7FFAC992F9B0
        public void Clamp(){} // RVA: 0x7FFAC992FA80
        public void ThumbSelectionRect(){} // RVA: 0x7FFAC992FAB0
        public void StartDraggingWithValue(){} // RVA: 0x7FFAC992FB00
        public void SliderState(){} // RVA: 0x7FFAC992FB60
        public void ThumbExtRect(){} // RVA: 0x7FFAC992FCB0
        public void ThumbRect(){} // RVA: 0x7FFAC992FAB0
        public void VerticalThumbRect(){} // RVA: 0x7FFAC992FE20
        public void HorizontalThumbRect(){} // RVA: 0x7FFAC9930100
        public void ClampedCurrentValue(){} // RVA: 0x7FFAC99303E0
        public void MousePosition(){} // RVA: 0x7FFAC9930410
        public void ValuesPerPixel(){} // RVA: 0x7FFAC99304E0
        public void ThumbSize(){} // RVA: 0x7FFAC9930620
        public void MaxValue(){} // RVA: 0x7FFAC9930880
        public void MinValue(){} // RVA: 0x7FFAC99308A0
    }

    public class SliderJoint2D : AnchoredJoint2D
    {
        public object autoConfigureAngle;
        public object angle;
        public object useMotor;
        public object useLimits;
        public object motor;
        public object limits;
        public object limitState;
        public object referenceAngle;
        public object jointTranslation;
        public object jointSpeed;

        // ── Methods ──
        public void get_autoConfigureAngle(){} // RVA: 0x7FFAC99845D0
        public void set_autoConfigureAngle(){} // RVA: 0x7FFAC9984620
        public void get_angle(){} // RVA: 0x7FFAC9984680
        public void set_angle(){} // RVA: 0x7FFAC99846D0
        public void get_useMotor(){} // RVA: 0x7FFAC9984730
        public void set_useMotor(){} // RVA: 0x7FFAC9984780
        public void get_useLimits(){} // RVA: 0x7FFAC99847E0
        public void set_useLimits(){} // RVA: 0x7FFAC9984830
        public void get_motor(){} // RVA: 0x7FFAC9984890
        public void set_motor(){} // RVA: 0x7FFAC99848F0
        public void get_limits(){} // RVA: 0x7FFAC9984950
        public void set_limits(){} // RVA: 0x7FFAC99849B0
        public void get_limitState(){} // RVA: 0x7FFAC9984A10
        public void get_referenceAngle(){} // RVA: 0x7FFAC9984A60
        public void get_jointTranslation(){} // RVA: 0x7FFAC9984AB0
        public void get_jointSpeed(){} // RVA: 0x7FFAC9984B00
        public void GetMotorForce(){} // RVA: 0x7FFAC9984B50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_motor_Injected(){} // RVA: 0x7FFAC9984BB0
        public void set_motor_Injected(){} // RVA: 0x7FFAC9984C10
        public void get_limits_Injected(){} // RVA: 0x7FFAC9984C70
        public void set_limits_Injected(){} // RVA: 0x7FFAC9984CD0
    }

    public class SliderState : Object
    {
        public float dragStartPos; // 0x10
        public float dragStartValue; // 0x14
        public bool isDragging; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Snapping : Object
    {
        // ── Methods ──
        public void Snap(){} // RVA: 0x7FFAC7D9EEA0
    }

    public class SoftJointLimit : ValueType
    {
        public float limit; // 0x10
        public float bounciness; // 0x14
        public float contactDistance; // 0x18

        // ── Methods ──
        public void get_limit(){} // RVA: 0x7FFAC2F44D20
        public void set_limit(){} // RVA: 0x7FFAC4A9B910
        public void get_bounciness(){} // RVA: 0x7FFAC2F44D30
        public void set_bounciness(){} // RVA: 0x7FFAC4A9B8F0
        public void get_contactDistance(){} // RVA: 0x7FFAC2F44CF0
        public void set_contactDistance(){} // RVA: 0x7FFAC4A9B920
    }

    public class SoftJointLimitSpring : ValueType
    {
        public float spring; // 0x10
        public float damper; // 0x14

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFAC2F44D20
        public void set_spring(){} // RVA: 0x7FFAC4A9B910
        public void get_damper(){} // RVA: 0x7FFAC2F44D30
        public void set_damper(){} // RVA: 0x7FFAC4A9B8F0
    }

    public class SortingLayer : ValueType
    {
        public int m_Id; // 0x10

        // ── Methods ──
        public void GetLayerValueFromID(){} // RVA: 0x7FFAC9851BF0
        public void NameToID(){} // RVA: 0x7FFAC9851C40
    }

    public class SpaceAttribute : PropertyAttribute
    {
        public float height; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC304B330 | overloaded x2
    }

    public class SphereCollider : Collider
    {
        public object center;
        public object radius;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAC999A5C0
        public void set_center(){} // RVA: 0x7FFAC999A630
        public void get_radius(){} // RVA: 0x7FFAC999A690
        public void set_radius(){} // RVA: 0x7FFAC999A6E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_center_Injected(){} // RVA: 0x7FFAC999A740
        public void set_center_Injected(){} // RVA: 0x7FFAC999A7A0
    }

    public class SpringJoint : Joint
    {
        public object spring;
        public object damper;
        public object minDistance;
        public object maxDistance;
        public object tolerance;

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFAC999C470
        public void set_spring(){} // RVA: 0x7FFAC999C4C0
        public void get_damper(){} // RVA: 0x7FFAC999C520
        public void set_damper(){} // RVA: 0x7FFAC999C570
        public void get_minDistance(){} // RVA: 0x7FFAC999C5D0
        public void set_minDistance(){} // RVA: 0x7FFAC999C620
        public void get_maxDistance(){} // RVA: 0x7FFAC999C680
        public void set_maxDistance(){} // RVA: 0x7FFAC999C6D0
        public void get_tolerance(){} // RVA: 0x7FFAC999C730
        public void set_tolerance(){} // RVA: 0x7FFAC999C780
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Sprite : Object
    {
        public object bounds;
        public object rect;
        public object border;
        public object texture;
        public object pixelsPerUnit;
        public object spriteAtlasTextureScale;
        public object associatedAlphaSplitTexture;
        public object pivot;
        public object packed;
        public object packingMode;
        public object packingRotation;
        public object textureRect;
        public object textureRectOffset;
        public object vertices;
        public object triangles;
        public object uv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98D8300
        public void GetPackingMode(){} // RVA: 0x7FFAC98D8350
        public void GetPackingRotation(){} // RVA: 0x7FFAC98D83A0
        public void GetPacked(){} // RVA: 0x7FFAC98D83F0
        public void GetTextureRect(){} // RVA: 0x7FFAC98D8440
        public void GetTextureRectOffset(){} // RVA: 0x7FFAC98D84B0
        public void GetInnerUVs(){} // RVA: 0x7FFAC98D8510
        public void GetOuterUVs(){} // RVA: 0x7FFAC98D8580
        public void GetPadding(){} // RVA: 0x7FFAC98D85F0
        public void CreateSprite(){} // RVA: 0x7FFAC98D8660
        public void get_bounds(){} // RVA: 0x7FFAC98D8720
        public void get_rect(){} // RVA: 0x7FFAC98D8790
        public void get_border(){} // RVA: 0x7FFAC98D8800
        public void get_texture(){} // RVA: 0x7FFAC98D8870
        public void GetSecondaryTextureCount(){} // RVA: 0x7FFAC98D88C0
        public void GetSecondaryTextures(){} // RVA: 0x7FFAC98D8910
        public void get_pixelsPerUnit(){} // RVA: 0x7FFAC98D8970
        public void get_spriteAtlasTextureScale(){} // RVA: 0x7FFAC98D89C0
        public void get_associatedAlphaSplitTexture(){} // RVA: 0x7FFAC98D8A10
        public void get_pivot(){} // RVA: 0x7FFAC98D8A60
        public void get_packed(){} // RVA: 0x7FFAC98D8AC0
        public void get_packingMode(){} // RVA: 0x7FFAC98D8350
        public void get_packingRotation(){} // RVA: 0x7FFAC98D83A0
        public void get_textureRect(){} // RVA: 0x7FFAC98D8B20
        public void get_textureRectOffset(){} // RVA: 0x7FFAC98D84B0
        public void get_vertices(){} // RVA: 0x7FFAC98D8BA0
        public void get_triangles(){} // RVA: 0x7FFAC98D8BF0
        public void get_uv(){} // RVA: 0x7FFAC98D8C40
        public void GetPhysicsShapeCount(){} // RVA: 0x7FFAC98D8C90
        public void GetPhysicsShapePointCount(){} // RVA: 0x7FFAC98D8CE0
        public void Internal_GetPhysicsShapePointCount(){} // RVA: 0x7FFAC98D8E50
        public void GetPhysicsShape(){} // RVA: 0x7FFAC98D8EB0
        public void GetPhysicsShapeImpl(){} // RVA: 0x7FFAC98D9060
        public void OverridePhysicsShape(){} // RVA: 0x7FFAC98D9510 | overloaded x2
        public void OverridePhysicsShapeCount(){} // RVA: 0x7FFAC98D94B0
        public void OverrideGeometry(){} // RVA: 0x7FFAC98D9580
        public void Create(){} // RVA: 0x7FFAC98D9E60 | overloaded x7
        public void GetTextureRect_Injected(){} // RVA: 0x7FFAC98D9EA0
        public void GetTextureRectOffset_Injected(){} // RVA: 0x7FFAC98D9F00
        public void GetInnerUVs_Injected(){} // RVA: 0x7FFAC98D9F60
        public void GetOuterUVs_Injected(){} // RVA: 0x7FFAC98D9FC0
        public void GetPadding_Injected(){} // RVA: 0x7FFAC98DA020
        public void CreateSprite_Injected(){} // RVA: 0x7FFAC98DA080
        public void get_bounds_Injected(){} // RVA: 0x7FFAC98DA110
        public void get_rect_Injected(){} // RVA: 0x7FFAC98DA170
        public void get_border_Injected(){} // RVA: 0x7FFAC98DA1D0
        public void get_pivot_Injected(){} // RVA: 0x7FFAC98DA230
    }

    public class SpriteMask : Renderer
    {
        public object frontSortingLayerID;
        public object frontSortingOrder;
        public object backSortingLayerID;
        public object backSortingOrder;
        public object alphaCutoff;
        public object sprite;
        public object isCustomRangeActive;
        public object spriteSortPoint;

        // ── Methods ──
        public void get_frontSortingLayerID(){} // RVA: 0x7FFAC99F0B40
        public void set_frontSortingLayerID(){} // RVA: 0x7FFAC99F0B90
        public void get_frontSortingOrder(){} // RVA: 0x7FFAC99F0BF0
        public void set_frontSortingOrder(){} // RVA: 0x7FFAC99F0C40
        public void get_backSortingLayerID(){} // RVA: 0x7FFAC99F0CA0
        public void set_backSortingLayerID(){} // RVA: 0x7FFAC99F0CF0
        public void get_backSortingOrder(){} // RVA: 0x7FFAC99F0D50
        public void set_backSortingOrder(){} // RVA: 0x7FFAC99F0DA0
        public void get_alphaCutoff(){} // RVA: 0x7FFAC99F0E00
        public void set_alphaCutoff(){} // RVA: 0x7FFAC99F0E50
        public void get_sprite(){} // RVA: 0x7FFAC99F0EB0
        public void set_sprite(){} // RVA: 0x7FFAC99F0F00
        public void get_isCustomRangeActive(){} // RVA: 0x7FFAC99F0F60
        public void set_isCustomRangeActive(){} // RVA: 0x7FFAC99F0FB0
        public void get_spriteSortPoint(){} // RVA: 0x7FFAC99F1010
        public void set_spriteSortPoint(){} // RVA: 0x7FFAC99F1060
        public void GetSpriteBounds(){} // RVA: 0x7FFAC99F10C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void GetSpriteBounds_Injected(){} // RVA: 0x7FFAC99F1130
    }

    public class SpriteRenderer : Renderer
    {
        public UnityEngine.Events.UnityEvent`1<UnityEngine.SpriteRenderer> shouldSupportTiling; // 0x18

        // ── Methods ──
        public void RegisterSpriteChangeCallback(){} // RVA: 0x7FFAC98D7460
        public void UnregisterSpriteChangeCallback(){} // RVA: 0x7FFAC98D75D0
        public void InvokeSpriteChanged(){} // RVA: 0x7FFAC98D7660
        public void get_shouldSupportTiling(){} // RVA: 0x7FFAC98D76F0
        public void get_sprite(){} // RVA: 0x7FFAC98D7740
        public void set_sprite(){} // RVA: 0x7FFAC98D7790
        public void get_drawMode(){} // RVA: 0x7FFAC98D77F0
        public void set_drawMode(){} // RVA: 0x7FFAC98D7840
        public void get_size(){} // RVA: 0x7FFAC98D78A0
        public void set_size(){} // RVA: 0x7FFAC98D7900
        public void get_adaptiveModeThreshold(){} // RVA: 0x7FFAC98D7960
        public void set_adaptiveModeThreshold(){} // RVA: 0x7FFAC98D79B0
        public void get_tileMode(){} // RVA: 0x7FFAC98D7A10
        public void set_tileMode(){} // RVA: 0x7FFAC98D7A60
        public void get_color(){} // RVA: 0x7FFAC98D7AC0
        public void set_color(){} // RVA: 0x7FFAC98D7B30
        public void get_maskInteraction(){} // RVA: 0x7FFAC98D7B90
        public void set_maskInteraction(){} // RVA: 0x7FFAC98D7BE0
        public void get_flipX(){} // RVA: 0x7FFAC98D7C40
        public void set_flipX(){} // RVA: 0x7FFAC98D7C90
        public void get_flipY(){} // RVA: 0x7FFAC98D7CF0
        public void set_flipY(){} // RVA: 0x7FFAC98D7D40
        public void get_spriteSortPoint(){} // RVA: 0x7FFAC98D7DA0
        public void set_spriteSortPoint(){} // RVA: 0x7FFAC98D7DF0
        public void GetCurrentMeshDataPtr(){} // RVA: 0x7FFAC98D7E50
        public void GetCurrentMeshData(){} // RVA: 0x7FFAC98D7EA0
        public void Internal_GetSpriteBounds(){} // RVA: 0x7FFAC98D7F50
        public void GetSecondaryTextureProperties(){} // RVA: 0x7FFAC98D7FD0
        public void GetSpriteBounds(){} // RVA: 0x7FFAC98D8030
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_size_Injected(){} // RVA: 0x7FFAC98D8110
        public void set_size_Injected(){} // RVA: 0x7FFAC98D8170
        public void get_color_Injected(){} // RVA: 0x7FFAC98D81D0
        public void set_color_Injected(){} // RVA: 0x7FFAC98D8230
        public void Internal_GetSpriteBounds_Injected(){} // RVA: 0x7FFAC98D8290
    }

    public class StackTraceUtility : Object
    {
        public string projectFolder;

        // ── Methods ──
        public void SetProjectFolder(){} // RVA: 0x7FFAC98C3490
        public void ExtractStackTrace(){} // RVA: 0x7FFAC98C3650
        public void ExtractStringFromExceptionInternal(){} // RVA: 0x7FFAC98C37D0
        public void ExtractFormattedStackTrace(){} // RVA: 0x7FFAC98C3C90
        public void .cctor(){} // RVA: 0x7FFAC98C4650
    }

    public class StateMachineBehaviour : ScriptableObject
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateUpdate(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateExit(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateMove(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateIK(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateMachineEnter(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void OnStateMachineExit(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class Subsystem : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Destroy(){} // RVA: 0x7FFAC99F16D0
        public void OnDestroy(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubsystemBindings : Object
    {
        // ── Methods ──
        public void DestroySubsystem(){} // RVA: 0x7FFAC99F1590
    }

    public class SubsystemDescriptor : Object
    {
        public string id; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFAC3EEA090
        public void CreateImpl(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubsystemDescriptorBindings : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC99F1630
        public void GetId(){} // RVA: 0x7FFAC99F1680
    }

    public class SubsystemManager : Object
    {
        public System.Action beforeReloadSubsystems;
        public System.Action afterReloadSubsystems; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Subsystem> s_DeprecatedSubsystems; // 0x20
        public System.Action reloadSubsytemsStarted; // 0x28
        public System.Action reloadSubsytemsCompleted; // 0x30

        // ── Methods ──
        public void ReloadSubsystemsStarted(){} // RVA: 0x7FFAC99F1860
        public void ReloadSubsystemsCompleted(){} // RVA: 0x7FFAC99F1950
        public void InitializeIntegratedSubsystem(){} // RVA: 0x7FFAC99F1A40
        public void ClearSubsystems(){} // RVA: 0x7FFAC99F1B70
        public void StaticConstructScriptingClassMap(){} // RVA: 0x7FFAC99F1DF0
        public void .cctor(){} // RVA: 0x7FFAC99F1E40
        public void GetSubsystemDescriptors(){} // RVA: 0x7FFAC2C70A10
        public void GetSubsystems(){} // RVA: 0x7FFAC2C70A10
        public void AddSubsystemSubset(){} // RVA: 0x7FFAC2C70C80
        public void GetIntegratedSubsystemByPtr(){} // RVA: 0x7FFAC99F20E0
        public void RemoveIntegratedSubsystemByPtr(){} // RVA: 0x7FFAC99F2260
        public void RemoveStandaloneSubsystem(){} // RVA: 0x7FFAC99F23F0
        public void RemoveDeprecatedSubsystem(){} // RVA: 0x7FFAC99F2480
    }

    public class SurfaceEffector2D : Effector2D
    {
        public object speed;
        public object speedVariation;
        public object forceScale;
        public object useContactForce;
        public object useFriction;
        public object useBounce;

        // ── Methods ──
        public void get_speed(){} // RVA: 0x7FFAC9986A80
        public void set_speed(){} // RVA: 0x7FFAC9986AD0
        public void get_speedVariation(){} // RVA: 0x7FFAC9986B30
        public void set_speedVariation(){} // RVA: 0x7FFAC9986B80
        public void get_forceScale(){} // RVA: 0x7FFAC9986BE0
        public void set_forceScale(){} // RVA: 0x7FFAC9986C30
        public void get_useContactForce(){} // RVA: 0x7FFAC9986C90
        public void set_useContactForce(){} // RVA: 0x7FFAC9986CE0
        public void get_useFriction(){} // RVA: 0x7FFAC9986D40
        public void set_useFriction(){} // RVA: 0x7FFAC9986D90
        public void get_useBounce(){} // RVA: 0x7FFAC9986DF0
        public void set_useBounce(){} // RVA: 0x7FFAC9986E40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SystemClock : Object
    {
        public System.DateTime now;

        // ── Methods ──
        public void get_now(){} // RVA: 0x7FFAC98CB890
        public void .cctor(){} // RVA: 0x7FFAC98CB8E0
    }

    public class SystemInfo : Object
    {
        public object batteryLevel;
        public object batteryStatus;
        public object operatingSystem;
        public object operatingSystemFamily;
        public object processorType;
        public object processorFrequency;
        public object processorCount;
        public object systemMemorySize;
        public object deviceUniqueIdentifier;
        public object deviceName;
        public object deviceModel;
        public object supportsVibration;
        public object supportsAudio;
        public object deviceType;
        public object graphicsMemorySize;
        public object graphicsDeviceName;
        public object graphicsDeviceVendor;
        public object graphicsDeviceID;
        public object graphicsDeviceVendorID;
        public object graphicsDeviceType;
        public object graphicsUVStartsAtTop;
        public object graphicsDeviceVersion;
        public object graphicsShaderLevel;
        public object graphicsMultiThreaded;
        public object renderingThreadingMode;
        public object supportsMotionVectors;
        public object supports3DRenderTextures;
        public object copyTextureSupport;
        public object supportsComputeShaders;
        public object supportsGeometryShaders;
        public object supportsInstancing;
        public object supportedRenderTargetCount;
        public object supportedRandomWriteTargetCount;
        public object usesReversedZBuffer;
        public object npotSupport;
        public object maxTextureSize;
        public object maxCubemapSize;
        public object maxRenderTextureSize;
        public object maxComputeBufferInputsVertex;
        public object maxComputeBufferInputsCompute;
        public object maxComputeWorkGroupSize;
        public object maxComputeWorkGroupSizeX;
        public object maxComputeWorkGroupSizeY;
        public object maxComputeWorkGroupSizeZ;
        public object supportsAsyncGPUReadback;
        public object supportsRayTracing;
        public object maxGraphicsBufferSize;
        public object usesLoadStoreActions;
        public object supportsIndirectArgumentsBuffer;

        // ── Methods ──
        public void get_batteryLevel(){} // RVA: 0x7FFAC98CA740
        public void get_batteryStatus(){} // RVA: 0x7FFAC98CA790
        public void get_operatingSystem(){} // RVA: 0x7FFAC8B15C80
        public void get_operatingSystemFamily(){} // RVA: 0x7FFAC98CA7E0
        public void get_processorType(){} // RVA: 0x7FFAC8B15F70
        public void get_processorFrequency(){} // RVA: 0x7FFAC98CA830
        public void get_processorCount(){} // RVA: 0x7FFAC98CA880
        public void get_systemMemorySize(){} // RVA: 0x7FFAC98CA8D0
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFAC8B17AB0
        public void get_deviceName(){} // RVA: 0x7FFAC98CA920
        public void get_deviceModel(){} // RVA: 0x7FFAC8B17B00
        public void get_supportsVibration(){} // RVA: 0x7FFAC98CA970
        public void get_supportsAudio(){} // RVA: 0x7FFAC98CA9C0
        public void get_deviceType(){} // RVA: 0x7FFAC98CAA10
        public void get_graphicsMemorySize(){} // RVA: 0x7FFAC98CAA60
        public void get_graphicsDeviceName(){} // RVA: 0x7FFAC8B16660
        public void get_graphicsDeviceVendor(){} // RVA: 0x7FFAC8B16850
        public void get_graphicsDeviceID(){} // RVA: 0x7FFAC98CAAB0
        public void get_graphicsDeviceVendorID(){} // RVA: 0x7FFAC98CAB00
        public void get_graphicsDeviceType(){} // RVA: 0x7FFAC98CAB50
        public void get_graphicsUVStartsAtTop(){} // RVA: 0x7FFAC98CABA0
        public void get_graphicsDeviceVersion(){} // RVA: 0x7FFAC8B16B40
        public void get_graphicsShaderLevel(){} // RVA: 0x7FFAC98CABF0
        public void get_graphicsMultiThreaded(){} // RVA: 0x7FFAC8B17C30
        public void get_renderingThreadingMode(){} // RVA: 0x7FFAC98CAC40
        public void get_supportsMotionVectors(){} // RVA: 0x7FFAC98CAC90
        public void get_supports3DRenderTextures(){} // RVA: 0x7FFAC98CACE0
        public void get_copyTextureSupport(){} // RVA: 0x7FFAC98CAD30
        public void get_supportsComputeShaders(){} // RVA: 0x7FFAC98CAD80
        public void get_supportsGeometryShaders(){} // RVA: 0x7FFAC98CADD0
        public void get_supportsInstancing(){} // RVA: 0x7FFAC98CAE20
        public void get_supportedRenderTargetCount(){} // RVA: 0x7FFAC98CAE70
        public void get_supportedRandomWriteTargetCount(){} // RVA: 0x7FFAC98CAEC0
        public void get_usesReversedZBuffer(){} // RVA: 0x7FFAC98CAF10
        public void IsValidEnumValue(){} // RVA: 0x7FFAC98CAF60
        public void SupportsRenderTextureFormat(){} // RVA: 0x7FFAC98CB070
        public void SupportsTextureFormat(){} // RVA: 0x7FFAC98CB150
        public void get_npotSupport(){} // RVA: 0x7FFAC98CB230
        public void get_maxTextureSize(){} // RVA: 0x7FFAC98CB280
        public void get_maxCubemapSize(){} // RVA: 0x7FFAC98CB2D0
        public void get_maxRenderTextureSize(){} // RVA: 0x7FFAC98CB320
        public void get_maxComputeBufferInputsVertex(){} // RVA: 0x7FFAC98CB370
        public void get_maxComputeBufferInputsCompute(){} // RVA: 0x7FFAC98CB3C0
        public void get_maxComputeWorkGroupSize(){} // RVA: 0x7FFAC98CB410
        public void get_maxComputeWorkGroupSizeX(){} // RVA: 0x7FFAC98CB460
        public void get_maxComputeWorkGroupSizeY(){} // RVA: 0x7FFAC98CB4B0
        public void get_maxComputeWorkGroupSizeZ(){} // RVA: 0x7FFAC98CB500
        public void get_supportsAsyncGPUReadback(){} // RVA: 0x7FFAC98CB550
        public void get_supportsRayTracing(){} // RVA: 0x7FFAC98CB5A0
        public void get_maxGraphicsBufferSize(){} // RVA: 0x7FFAC98CB5F0
        public void get_usesLoadStoreActions(){} // RVA: 0x7FFAC98CB640
        public void get_supportsIndirectArgumentsBuffer(){} // RVA: 0x7FFAC98CB690
        public void GetBatteryLevel(){} // RVA: 0x7FFAC98CA740
        public void GetBatteryStatus(){} // RVA: 0x7FFAC98CA790
        public void GetOperatingSystem(){} // RVA: 0x7FFAC8B15C80
        public void GetOperatingSystemFamily(){} // RVA: 0x7FFAC98CA7E0
        public void GetProcessorType(){} // RVA: 0x7FFAC8B15F70
        public void GetProcessorFrequencyMHz(){} // RVA: 0x7FFAC98CA830
        public void GetProcessorCount(){} // RVA: 0x7FFAC98CA880
        public void GetPhysicalMemoryMB(){} // RVA: 0x7FFAC98CA8D0
        public void GetDeviceUniqueIdentifier(){} // RVA: 0x7FFAC8B17AB0
        public void GetDeviceName(){} // RVA: 0x7FFAC98CA920
        public void GetDeviceModel(){} // RVA: 0x7FFAC8B17B00
        public void SupportsVibration(){} // RVA: 0x7FFAC98CA970
        public void SupportsAudio(){} // RVA: 0x7FFAC98CA9C0
        public void GetDeviceType(){} // RVA: 0x7FFAC98CAA10
        public void GetGraphicsMemorySize(){} // RVA: 0x7FFAC98CAA60
        public void GetGraphicsDeviceName(){} // RVA: 0x7FFAC8B16660
        public void GetGraphicsDeviceVendor(){} // RVA: 0x7FFAC8B16850
        public void GetGraphicsDeviceID(){} // RVA: 0x7FFAC98CAAB0
        public void GetGraphicsDeviceVendorID(){} // RVA: 0x7FFAC98CAB00
        public void GetGraphicsDeviceType(){} // RVA: 0x7FFAC98CAB50
        public void GetGraphicsUVStartsAtTop(){} // RVA: 0x7FFAC98CABA0
        public void GetGraphicsDeviceVersion(){} // RVA: 0x7FFAC8B16B40
        public void GetGraphicsShaderLevel(){} // RVA: 0x7FFAC98CABF0
        public void GetGraphicsMultiThreaded(){} // RVA: 0x7FFAC8B17C30
        public void GetRenderingThreadingMode(){} // RVA: 0x7FFAC98CAC40
        public void SupportsMotionVectors(){} // RVA: 0x7FFAC98CAC90
        public void Supports3DRenderTextures(){} // RVA: 0x7FFAC98CACE0
        public void GetCopyTextureSupport(){} // RVA: 0x7FFAC98CAD30
        public void SupportsComputeShaders(){} // RVA: 0x7FFAC98CAD80
        public void SupportsGeometryShaders(){} // RVA: 0x7FFAC98CADD0
        public void SupportsInstancing(){} // RVA: 0x7FFAC98CAE20
        public void SupportedRenderTargetCount(){} // RVA: 0x7FFAC98CAE70
        public void SupportedRandomWriteTargetCount(){} // RVA: 0x7FFAC98CAEC0
        public void MaxComputeBufferInputsVertex(){} // RVA: 0x7FFAC98CB370
        public void MaxComputeBufferInputsCompute(){} // RVA: 0x7FFAC98CB3C0
        public void UsesReversedZBuffer(){} // RVA: 0x7FFAC98CAF10
        public void HasRenderTextureNative(){} // RVA: 0x7FFAC98CB6E0
        public void SupportsTextureFormatNative(){} // RVA: 0x7FFAC98CB730
        public void GetNPOTSupport(){} // RVA: 0x7FFAC98CB230
        public void GetMaxTextureSize(){} // RVA: 0x7FFAC98CB280
        public void GetMaxCubemapSize(){} // RVA: 0x7FFAC98CB2D0
        public void GetMaxRenderTextureSize(){} // RVA: 0x7FFAC98CB320
        public void GetMaxComputeWorkGroupSize(){} // RVA: 0x7FFAC98CB410
        public void GetMaxComputeWorkGroupSizeX(){} // RVA: 0x7FFAC98CB460
        public void GetMaxComputeWorkGroupSizeY(){} // RVA: 0x7FFAC98CB4B0
        public void GetMaxComputeWorkGroupSizeZ(){} // RVA: 0x7FFAC98CB500
        public void SupportsAsyncGPUReadback(){} // RVA: 0x7FFAC98CB550
        public void SupportsRayTracing(){} // RVA: 0x7FFAC98CB5A0
        public void MaxGraphicsBufferSize(){} // RVA: 0x7FFAC98CB5F0
        public void IsFormatSupported(){} // RVA: 0x7FFAC98CB780
        public void GetCompatibleFormat(){} // RVA: 0x7FFAC98CB7E0
        public void GetGraphicsFormat(){} // RVA: 0x7FFAC98CB840
        public void UsesLoadStoreActions(){} // RVA: 0x7FFAC98CB640
        public void SupportsIndirectArgumentsBuffer(){} // RVA: 0x7FFAC98CB690
    }

}