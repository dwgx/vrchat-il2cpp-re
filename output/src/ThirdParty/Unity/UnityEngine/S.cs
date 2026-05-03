// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 480

namespace ThirdParty.Unity.UnityEngine
{
    public class ScalableBufferManager : Object
    {
        // ── Methods ──
        public void get_widthScaleFactor(){} // RVA: 0x7FFE87C1A000
        public void get_heightScaleFactor(){} // RVA: 0x7FFE87C1A050
    }

    public class Screen : Object
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFE87C146D0
        public void get_height(){} // RVA: 0x7FFE87C14720
        public void get_dpi(){} // RVA: 0x7FFE87C14770
        public void RequestOrientation(){} // RVA: 0x7FFE87C147C0
        public void GetScreenOrientation(){} // RVA: 0x7FFE87A27920
        public void get_orientation(){} // RVA: 0x7FFE87A27920
        public void set_orientation(){} // RVA: 0x7FFE87C14810
        public void set_sleepTimeout(){} // RVA: 0x7FFE87C148C0
        public void SetOrientationEnabled(){} // RVA: 0x7FFE87C14910
        public void set_autorotateToPortrait(){} // RVA: 0x7FFE87C14970
        public void set_autorotateToPortraitUpsideDown(){} // RVA: 0x7FFE87C149D0
        public void set_autorotateToLandscapeLeft(){} // RVA: 0x7FFE87C14A30
        public void set_autorotateToLandscapeRight(){} // RVA: 0x7FFE87C14A90
        public void get_currentResolution(){} // RVA: 0x7FFE87C14AF0
        public void get_fullScreen(){} // RVA: 0x7FFE81B16500
        public void set_fullScreen(){} // RVA: 0x7FFE87C14B50
        public void get_fullScreenMode(){} // RVA: 0x7FFE87C14BA0
        public void get_safeArea(){} // RVA: 0x7FFE87C14BF0
        public void SetResolution(){} // RVA: 0x7FFE87C14D70 | overloaded x3
        public void get_resolutions(){} // RVA: 0x7FFE87C14E10
        public void get_currentResolution_Injected(){} // RVA: 0x7FFE87C14E60
        public void get_safeArea_Injected(){} // RVA: 0x7FFE87C14EB0
        public void SetResolution_Injected(){} // RVA: 0x7FFE87C14F00
    }

    public class ScreenCapture : Object
    {
        // ── Methods ──
        public void CaptureScreenshotIntoRenderTexture(){} // RVA: 0x7FFE87D96480
    }

    public class ScriptableObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C6B9D0
        public void CreateInstance(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CreateScriptableObject(){} // RVA: 0x7FFE87C6BAC0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFE87C6BB10
    }

    public class ScriptingRuntime : Object
    {
        // ── Methods ──
        public void GetAllUserAssemblies(){} // RVA: 0x7FFE87C6BB70
    }

    public class ScriptingUtility : Object
    {
        // ── Methods ──
        public void IsManagedCodeWorking(){} // RVA: 0x7FFE82E64CC0
    }

    public class ScrollViewState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecondarySpriteTexture : ValueType
    {
    }

    public class SelectionBaseAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SendMouseEvents : Object
    {
        // ── Methods ──
        public void UpdateMouse(){} // RVA: 0x7FFE87CE94F0
        public void SetMouseMoved(){} // RVA: 0x7FFE87CE97F0
        public void DoSendMouseEvents(){} // RVA: 0x7FFE87CE9850
        public void SendEvents(){} // RVA: 0x7FFE87CEA590
        public void .cctor(){} // RVA: 0x7FFE87CEAC80
    }

    public class SerializeField : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SerializeReference : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SetupCoroutine : Object
    {
        // ── Methods ──
        public void InvokeMoveNext(){} // RVA: 0x7FFE87C65220
        public void InvokeMember(){} // RVA: 0x7FFE87C652E0
    }

    public class Shader : Object
    {
        // ── Methods ──
        public void Find(){} // RVA: 0x7FFE87C284D0
        public void get_maximumChunksOverride(){} // RVA: 0x7FFE87C28540
        public void set_maximumChunksOverride(){} // RVA: 0x7FFE87C28590
        public void set_maximumLOD(){} // RVA: 0x7FFE87C285E0
        public void get_isSupported(){} // RVA: 0x7FFE87C28640
        public void EnableKeyword(){} // RVA: 0x7FFE87C28690
        public void DisableKeyword(){} // RVA: 0x7FFE87C286E0
        public void get_renderQueue(){} // RVA: 0x7FFE87C28730
        public void WarmupAllShaders(){} // RVA: 0x7FFE87C28780
        public void TagToID(){} // RVA: 0x7FFE87C287D0
        public void PropertyToID(){} // RVA: 0x7FFE87C28820
        public void SetGlobalIntImpl(){} // RVA: 0x7FFE87C28870
        public void SetGlobalFloatImpl(){} // RVA: 0x7FFE87C288D0
        public void SetGlobalVectorImpl(){} // RVA: 0x7FFE87C28930
        public void SetGlobalMatrixImpl(){} // RVA: 0x7FFE87C28990
        public void SetGlobalTextureImpl(){} // RVA: 0x7FFE87C289F0
        public void SetGlobalFloatArrayImpl(){} // RVA: 0x7FFE87C28A50
        public void SetGlobalVectorArrayImpl(){} // RVA: 0x7FFE87C28AC0
        public void SetGlobalMatrixArrayImpl(){} // RVA: 0x7FFE87C28B30
        public void SetGlobalFloatArray(){} // RVA: 0x7FFE87C294B0 | overloaded x3
        public void SetGlobalVectorArray(){} // RVA: 0x7FFE87C29540 | overloaded x3
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFE87C295D0 | overloaded x3
        public void SetGlobalInt(){} // RVA: 0x7FFE87C29070 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFE87C288D0 | overloaded x2
        public void SetGlobalInteger(){} // RVA: 0x7FFE87C28870
        public void SetGlobalVector(){} // RVA: 0x7FFE87C29220 | overloaded x2
        public void SetGlobalColor(){} // RVA: 0x7FFE87C29280
        public void SetGlobalMatrix(){} // RVA: 0x7FFE87C29320
        public void SetGlobalTexture(){} // RVA: 0x7FFE87C289F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87C295F0
        public void GetPropertyName(){} // RVA: 0x7FFE87C29810 | overloaded x2
        public void GetPropertyType(){} // RVA: 0x7FFE87C29880 | overloaded x2
        public void CheckPropertyIndex(){} // RVA: 0x7FFE87C29700
        public void GetPropertyCount(){} // RVA: 0x7FFE87C297C0
        public void SetGlobalVectorImpl_Injected(){} // RVA: 0x7FFE87C298F0
        public void SetGlobalMatrixImpl_Injected(){} // RVA: 0x7FFE87C29950
    }

    public class SharedBetweenAnimatorsAttribute : Attribute
    {
    }

    public class SkeletonBone : ValueType
    {
    }

    public class SkinnedMeshRenderer : Renderer
    {
        // ── Methods ──
        public void get_quality(){} // RVA: 0x7FFE87C347C0
        public void set_quality(){} // RVA: 0x7FFE87C34810
        public void get_updateWhenOffscreen(){} // RVA: 0x7FFE87C34870
        public void set_updateWhenOffscreen(){} // RVA: 0x7FFE87C348C0
        public void get_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFE87C34920
        public void set_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFE87C34970
        public void get_rootBone(){} // RVA: 0x7FFE87C349D0
        public void set_rootBone(){} // RVA: 0x7FFE87C34A20
        public void get_bones(){} // RVA: 0x7FFE87C34A80
        public void set_bones(){} // RVA: 0x7FFE87C34AD0
        public void get_sharedMesh(){} // RVA: 0x7FFE87C34B30
        public void set_sharedMesh(){} // RVA: 0x7FFE87C34B80
        public void get_skinnedMotionVectors(){} // RVA: 0x7FFE87C34BE0
        public void set_skinnedMotionVectors(){} // RVA: 0x7FFE87C34C30
        public void GetBlendShapeWeight(){} // RVA: 0x7FFE87C34C90
        public void SetBlendShapeWeight(){} // RVA: 0x7FFE87C34CF0
        public void BakeMesh(){} // RVA: 0x7FFE87C34DD0 | overloaded x2
        public void GetVertexBuffer(){} // RVA: 0x7FFE87C34E40
        public void GetPreviousVertexBuffer(){} // RVA: 0x7FFE87C34F80
        public void GetVertexBufferImpl(){} // RVA: 0x7FFE87C350C0
        public void GetPreviousVertexBufferImpl(){} // RVA: 0x7FFE87C35110
        public void get_vertexBufferTarget(){} // RVA: 0x7FFE87C35160
        public void set_vertexBufferTarget(){} // RVA: 0x7FFE87C351B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Skybox : Behaviour
    {
        // ── Methods ──
        public void get_material(){} // RVA: 0x7FFE87C339D0
        public void set_material(){} // RVA: 0x7FFE87C33A20
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SliderHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87CD6BE0
        public void Handle(){} // RVA: 0x7FFE87CD6D30
        public void OnMouseDown(){} // RVA: 0x7FFE87CD6DC0
        public void OnMouseDrag(){} // RVA: 0x7FFE87CD74A0
        public void OnMouseUp(){} // RVA: 0x7FFE87CD7650
        public void OnRepaint(){} // RVA: 0x7FFE87CD7710
        public void CurrentEventType(){} // RVA: 0x7FFE87CD7EB0
        public void CurrentScrollTroughSide(){} // RVA: 0x7FFE87CD7F50
        public void IsEmptySlider(){} // RVA: 0x7FFE87CD8050
        public void SupportsPageMovements(){} // RVA: 0x7FFE87CD8070
        public void PageMovementValue(){} // RVA: 0x7FFE87CD8120
        public void PageUpMovementBound(){} // RVA: 0x7FFE87CD81D0
        public void CurrentEvent(){} // RVA: 0x7FFE87CAEB70
        public void ValueForCurrentMousePosition(){} // RVA: 0x7FFE87CD8250
        public void Clamp(){} // RVA: 0x7FFE87CD8320
        public void ThumbSelectionRect(){} // RVA: 0x7FFE87CD8350
        public void StartDraggingWithValue(){} // RVA: 0x7FFE87CD83A0
        public void SliderState(){} // RVA: 0x7FFE87CD8400
        public void ThumbExtRect(){} // RVA: 0x7FFE87CD8550
        public void ThumbRect(){} // RVA: 0x7FFE87CD8350
        public void VerticalThumbRect(){} // RVA: 0x7FFE87CD86C0
        public void HorizontalThumbRect(){} // RVA: 0x7FFE87CD89A0
        public void ClampedCurrentValue(){} // RVA: 0x7FFE87CD8C80
        public void MousePosition(){} // RVA: 0x7FFE87CD8CB0
        public void ValuesPerPixel(){} // RVA: 0x7FFE87CD8D80
        public void ThumbSize(){} // RVA: 0x7FFE87CD8EC0
        public void MaxValue(){} // RVA: 0x7FFE87CD9120
        public void MinValue(){} // RVA: 0x7FFE87CD9140
    }

    public class SliderJoint2D : AnchoredJoint2D
    {
        // ── Methods ──
        public void get_autoConfigureAngle(){} // RVA: 0x7FFE87D2CE70
        public void set_autoConfigureAngle(){} // RVA: 0x7FFE87D2CEC0
        public void get_angle(){} // RVA: 0x7FFE87D2CF20
        public void set_angle(){} // RVA: 0x7FFE87D2CF70
        public void get_useMotor(){} // RVA: 0x7FFE87D2CFD0
        public void set_useMotor(){} // RVA: 0x7FFE87D2D020
        public void get_useLimits(){} // RVA: 0x7FFE87D2D080
        public void set_useLimits(){} // RVA: 0x7FFE87D2D0D0
        public void get_motor(){} // RVA: 0x7FFE87D2D130
        public void set_motor(){} // RVA: 0x7FFE87D2D190
        public void get_limits(){} // RVA: 0x7FFE87D2D1F0
        public void set_limits(){} // RVA: 0x7FFE87D2D250
        public void get_limitState(){} // RVA: 0x7FFE87D2D2B0
        public void get_referenceAngle(){} // RVA: 0x7FFE87D2D300
        public void get_jointTranslation(){} // RVA: 0x7FFE87D2D350
        public void get_jointSpeed(){} // RVA: 0x7FFE87D2D3A0
        public void GetMotorForce(){} // RVA: 0x7FFE87D2D3F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_motor_Injected(){} // RVA: 0x7FFE87D2D450
        public void set_motor_Injected(){} // RVA: 0x7FFE87D2D4B0
        public void get_limits_Injected(){} // RVA: 0x7FFE87D2D510
        public void set_limits_Injected(){} // RVA: 0x7FFE87D2D570
    }

    public class SliderState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Snapping : Object
    {
        // ── Methods ──
        public void Snap(){} // RVA: 0x7FFE861C16F0
    }

    public class SoftJointLimit : ValueType
    {
        public float m_Limit; // 0x10
        public float m_Bounciness; // 0x14
        public float m_ContactDistance; // 0x18

        // ── Methods ──
        public void get_limit(){} // RVA: 0x7FFE8111ED20
        public void set_limit(){} // RVA: 0x7FFE82D03BB0
        public void get_bounciness(){} // RVA: 0x7FFE8111ED30
        public void set_bounciness(){} // RVA: 0x7FFE82D03BD0
        public void get_contactDistance(){} // RVA: 0x7FFE8111ECF0
        public void set_contactDistance(){} // RVA: 0x7FFE82D03BC0
    }

    public class SoftJointLimitSpring : ValueType
    {
        public float m_Spring; // 0x10
        public float m_Damper; // 0x14

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFE8111ED20
        public void set_spring(){} // RVA: 0x7FFE82D03BB0
        public void get_damper(){} // RVA: 0x7FFE8111ED30
        public void set_damper(){} // RVA: 0x7FFE82D03BD0
    }

    public class SortingLayer : ValueType
    {
        // ── Methods ──
        public void GetLayerValueFromID(){} // RVA: 0x7FFE87BFA190
        public void NameToID(){} // RVA: 0x7FFE87BFA1E0
    }

    public class SpaceAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81225330 | overloaded x2
    }

    public class SphereCollider : Collider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFE87D42E60
        public void set_center(){} // RVA: 0x7FFE87D42ED0
        public void get_radius(){} // RVA: 0x7FFE87D42F30
        public void set_radius(){} // RVA: 0x7FFE87D42F80
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_center_Injected(){} // RVA: 0x7FFE87D42FE0
        public void set_center_Injected(){} // RVA: 0x7FFE87D43040
    }

    public class SpringJoint : Joint
    {
        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFE87D44D10
        public void set_spring(){} // RVA: 0x7FFE87D44D60
        public void get_damper(){} // RVA: 0x7FFE87D44DC0
        public void set_damper(){} // RVA: 0x7FFE87D44E10
        public void get_minDistance(){} // RVA: 0x7FFE87D44E70
        public void set_minDistance(){} // RVA: 0x7FFE87D44EC0
        public void get_maxDistance(){} // RVA: 0x7FFE87D44F20
        public void set_maxDistance(){} // RVA: 0x7FFE87D44F70
        public void get_tolerance(){} // RVA: 0x7FFE87D44FD0
        public void set_tolerance(){} // RVA: 0x7FFE87D45020
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Sprite : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C80A30
        public void GetPackingMode(){} // RVA: 0x7FFE87C80A80
        public void GetPackingRotation(){} // RVA: 0x7FFE87C80AD0
        public void GetPacked(){} // RVA: 0x7FFE87C80B20
        public void GetTextureRect(){} // RVA: 0x7FFE87C80B70
        public void GetTextureRectOffset(){} // RVA: 0x7FFE87C80BE0
        public void GetInnerUVs(){} // RVA: 0x7FFE87C80C40
        public void GetOuterUVs(){} // RVA: 0x7FFE87C80CB0
        public void GetPadding(){} // RVA: 0x7FFE87C80D20
        public void CreateSprite(){} // RVA: 0x7FFE87C80D90
        public void get_bounds(){} // RVA: 0x7FFE87C80E50
        public void get_rect(){} // RVA: 0x7FFE87C80EC0
        public void get_border(){} // RVA: 0x7FFE87C80F30
        public void get_texture(){} // RVA: 0x7FFE87C80FA0
        public void GetSecondaryTextureCount(){} // RVA: 0x7FFE87C80FF0
        public void GetSecondaryTextures(){} // RVA: 0x7FFE87C81040
        public void get_pixelsPerUnit(){} // RVA: 0x7FFE87C810A0
        public void get_spriteAtlasTextureScale(){} // RVA: 0x7FFE87C810F0
        public void get_associatedAlphaSplitTexture(){} // RVA: 0x7FFE87C81140
        public void get_pivot(){} // RVA: 0x7FFE87C81190
        public void get_packed(){} // RVA: 0x7FFE87C811F0
        public void get_packingMode(){} // RVA: 0x7FFE87C80A80
        public void get_packingRotation(){} // RVA: 0x7FFE87C80AD0
        public void get_textureRect(){} // RVA: 0x7FFE87C81250
        public void get_textureRectOffset(){} // RVA: 0x7FFE87C80BE0
        public void get_vertices(){} // RVA: 0x7FFE87C812D0
        public void get_triangles(){} // RVA: 0x7FFE87C81320
        public void get_uv(){} // RVA: 0x7FFE87C81370
        public void GetPhysicsShapeCount(){} // RVA: 0x7FFE87C813C0
        public void GetPhysicsShapePointCount(){} // RVA: 0x7FFE87C81410
        public void Internal_GetPhysicsShapePointCount(){} // RVA: 0x7FFE87C81580
        public void GetPhysicsShape(){} // RVA: 0x7FFE87C815E0
        public void GetPhysicsShapeImpl(){} // RVA: 0x7FFE87C81790
        public void OverridePhysicsShape(){} // RVA: 0x7FFE87C81C40 | overloaded x2
        public void OverridePhysicsShapeCount(){} // RVA: 0x7FFE87C81BE0
        public void OverrideGeometry(){} // RVA: 0x7FFE87C81CB0
        public void Create(){} // RVA: 0x7FFE87C82590 | overloaded x7
        public void GetTextureRect_Injected(){} // RVA: 0x7FFE87C825D0
        public void GetTextureRectOffset_Injected(){} // RVA: 0x7FFE87C82630
        public void GetInnerUVs_Injected(){} // RVA: 0x7FFE87C82690
        public void GetOuterUVs_Injected(){} // RVA: 0x7FFE87C826F0
        public void GetPadding_Injected(){} // RVA: 0x7FFE87C82750
        public void CreateSprite_Injected(){} // RVA: 0x7FFE87C827B0
        public void get_bounds_Injected(){} // RVA: 0x7FFE87C82840
        public void get_rect_Injected(){} // RVA: 0x7FFE87C828A0
        public void get_border_Injected(){} // RVA: 0x7FFE87C82900
        public void get_pivot_Injected(){} // RVA: 0x7FFE87C82960
    }

    public class SpriteMask : Renderer
    {
        // ── Methods ──
        public void get_frontSortingLayerID(){} // RVA: 0x7FFE87D993E0
        public void set_frontSortingLayerID(){} // RVA: 0x7FFE87D99430
        public void get_frontSortingOrder(){} // RVA: 0x7FFE87D99490
        public void set_frontSortingOrder(){} // RVA: 0x7FFE87D994E0
        public void get_backSortingLayerID(){} // RVA: 0x7FFE87D99540
        public void set_backSortingLayerID(){} // RVA: 0x7FFE87D99590
        public void get_backSortingOrder(){} // RVA: 0x7FFE87D995F0
        public void set_backSortingOrder(){} // RVA: 0x7FFE87D99640
        public void get_alphaCutoff(){} // RVA: 0x7FFE87D996A0
        public void set_alphaCutoff(){} // RVA: 0x7FFE87D996F0
        public void get_sprite(){} // RVA: 0x7FFE87D99750
        public void set_sprite(){} // RVA: 0x7FFE87D997A0
        public void get_isCustomRangeActive(){} // RVA: 0x7FFE87D99800
        public void set_isCustomRangeActive(){} // RVA: 0x7FFE87D99850
        public void get_spriteSortPoint(){} // RVA: 0x7FFE87D998B0
        public void set_spriteSortPoint(){} // RVA: 0x7FFE87D99900
        public void GetSpriteBounds(){} // RVA: 0x7FFE87D99960
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void GetSpriteBounds_Injected(){} // RVA: 0x7FFE87D999D0
    }

    public class SpriteRenderer : Renderer
    {
        public UnityEngine.Events.UnityEvent`1<UnityEngine.SpriteRenderer> m_SpriteChangeEvent; // 0x18
        public object field_1; // 0x3330
        public object field_2; // 0x3C5
        public object field_3; // 0x3C6
        public object field_4; // 0x3C7
        public object field_5; // 0x3C8
        public object field_6; // 0x3C9
        public object field_7; // 0x3CA
        public object field_8; // 0x3CB
        public object field_9; // 0x3CC
        public object field_10; // 0x3CD

        // ── Methods ──
        public void RegisterSpriteChangeCallback(){} // RVA: 0x7FFE87C7FB90
        public void UnregisterSpriteChangeCallback(){} // RVA: 0x7FFE87C7FD00
        public void InvokeSpriteChanged(){} // RVA: 0x7FFE87C7FD90
        public void get_shouldSupportTiling(){} // RVA: 0x7FFE87C7FE20
        public void get_sprite(){} // RVA: 0x7FFE87C7FE70
        public void set_sprite(){} // RVA: 0x7FFE87C7FEC0
        public void get_drawMode(){} // RVA: 0x7FFE87C7FF20
        public void set_drawMode(){} // RVA: 0x7FFE87C7FF70
        public void get_size(){} // RVA: 0x7FFE87C7FFD0
        public void set_size(){} // RVA: 0x7FFE87C80030
        public void get_adaptiveModeThreshold(){} // RVA: 0x7FFE87C80090
        public void set_adaptiveModeThreshold(){} // RVA: 0x7FFE87C800E0
        public void get_tileMode(){} // RVA: 0x7FFE87C80140
        public void set_tileMode(){} // RVA: 0x7FFE87C80190
        public void get_color(){} // RVA: 0x7FFE87C801F0
        public void set_color(){} // RVA: 0x7FFE87C80260
        public void get_maskInteraction(){} // RVA: 0x7FFE87C802C0
        public void set_maskInteraction(){} // RVA: 0x7FFE87C80310
        public void get_flipX(){} // RVA: 0x7FFE87C80370
        public void set_flipX(){} // RVA: 0x7FFE87C803C0
        public void get_flipY(){} // RVA: 0x7FFE87C80420
        public void set_flipY(){} // RVA: 0x7FFE87C80470
        public void get_spriteSortPoint(){} // RVA: 0x7FFE87C804D0
        public void set_spriteSortPoint(){} // RVA: 0x7FFE87C80520
        public void GetCurrentMeshDataPtr(){} // RVA: 0x7FFE87C80580
        public void GetCurrentMeshData(){} // RVA: 0x7FFE87C805D0
        public void Internal_GetSpriteBounds(){} // RVA: 0x7FFE87C80680
        public void GetSecondaryTextureProperties(){} // RVA: 0x7FFE87C80700
        public void GetSpriteBounds(){} // RVA: 0x7FFE87C80760
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_size_Injected(){} // RVA: 0x7FFE87C80840
        public void set_size_Injected(){} // RVA: 0x7FFE87C808A0
        public void get_color_Injected(){} // RVA: 0x7FFE87C80900
        public void set_color_Injected(){} // RVA: 0x7FFE87C80960
        public void Internal_GetSpriteBounds_Injected(){} // RVA: 0x7FFE87C809C0
    }

    public class StackTraceUtility : Object
    {
        // ── Methods ──
        public void SetProjectFolder(){} // RVA: 0x7FFE87C6BBC0
        public void ExtractStackTrace(){} // RVA: 0x7FFE87C6BD80
        public void ExtractStringFromExceptionInternal(){} // RVA: 0x7FFE87C6BF00
        public void ExtractFormattedStackTrace(){} // RVA: 0x7FFE87C6C3C0
        public void .cctor(){} // RVA: 0x7FFE87C6CD80
    }

    public class StateMachineBehaviour : ScriptableObject
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateUpdate(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateExit(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateMove(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateIK(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateMachineEnter(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void OnStateMachineExit(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class Subsystem : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void Destroy(){} // RVA: 0x7FFE87D99F70
        public void OnDestroy(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubsystemBindings : Object
    {
        // ── Methods ──
        public void DestroySubsystem(){} // RVA: 0x7FFE87D99E30
    }

    public class SubsystemDescriptor : Object
    {
        public string _id; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE81116380
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFE8725AEB0
        public void CreateImpl(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubsystemDescriptorBindings : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87D99ED0
        public void GetId(){} // RVA: 0x7FFE87D99F20
    }

    public class SubsystemManager : Object
    {
        // ── Methods ──
        public void ReloadSubsystemsStarted(){} // RVA: 0x7FFE87D9A100
        public void ReloadSubsystemsCompleted(){} // RVA: 0x7FFE87D9A1F0
        public void InitializeIntegratedSubsystem(){} // RVA: 0x7FFE87D9A2E0
        public void ClearSubsystems(){} // RVA: 0x7FFE87D9A410
        public void StaticConstructScriptingClassMap(){} // RVA: 0x7FFE87D9A690
        public void .cctor(){} // RVA: 0x7FFE87D9A6E0
        public void GetSubsystemDescriptors(){} // RVA: 0x7FFE80E46070
        public void GetSubsystems(){} // RVA: 0x7FFE80E46070
        public void AddSubsystemSubset(){} // RVA: 0x7FFE80E462E0
        public void GetIntegratedSubsystemByPtr(){} // RVA: 0x7FFE87D9A980
        public void RemoveIntegratedSubsystemByPtr(){} // RVA: 0x7FFE87D9AB00
        public void RemoveStandaloneSubsystem(){} // RVA: 0x7FFE87D9AC90
        public void RemoveDeprecatedSubsystem(){} // RVA: 0x7FFE87D9AD20
    }

    public class SurfaceEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_speed(){} // RVA: 0x7FFE87D2F320
        public void set_speed(){} // RVA: 0x7FFE87D2F370
        public void get_speedVariation(){} // RVA: 0x7FFE87D2F3D0
        public void set_speedVariation(){} // RVA: 0x7FFE87D2F420
        public void get_forceScale(){} // RVA: 0x7FFE87D2F480
        public void set_forceScale(){} // RVA: 0x7FFE87D2F4D0
        public void get_useContactForce(){} // RVA: 0x7FFE87D2F530
        public void set_useContactForce(){} // RVA: 0x7FFE87D2F580
        public void get_useFriction(){} // RVA: 0x7FFE87D2F5E0
        public void set_useFriction(){} // RVA: 0x7FFE87D2F630
        public void get_useBounce(){} // RVA: 0x7FFE87D2F690
        public void set_useBounce(){} // RVA: 0x7FFE87D2F6E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SystemClock : Object
    {
        public System.DateTime s_Epoch;

        // ── Methods ──
        public void get_now(){} // RVA: 0x7FFE87C73FC0
        public void .cctor(){} // RVA: 0x7FFE87C74010
    }

    public class SystemInfo : Object
    {
        // ── Methods ──
        public void get_batteryLevel(){} // RVA: 0x7FFE87C72E70
        public void get_batteryStatus(){} // RVA: 0x7FFE87C72EC0
        public void get_operatingSystem(){} // RVA: 0x7FFE86EBF2F0
        public void get_operatingSystemFamily(){} // RVA: 0x7FFE87C72F10
        public void get_processorType(){} // RVA: 0x7FFE86EBF5E0
        public void get_processorFrequency(){} // RVA: 0x7FFE87C72F60
        public void get_processorCount(){} // RVA: 0x7FFE87C72FB0
        public void get_systemMemorySize(){} // RVA: 0x7FFE87C73000
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFE86EC1120
        public void get_deviceName(){} // RVA: 0x7FFE87C73050
        public void get_deviceModel(){} // RVA: 0x7FFE86EC1170
        public void get_supportsVibration(){} // RVA: 0x7FFE87C730A0
        public void get_supportsAudio(){} // RVA: 0x7FFE87C730F0
        public void get_deviceType(){} // RVA: 0x7FFE87C73140
        public void get_graphicsMemorySize(){} // RVA: 0x7FFE87C73190
        public void get_graphicsDeviceName(){} // RVA: 0x7FFE86EBFCD0
        public void get_graphicsDeviceVendor(){} // RVA: 0x7FFE86EBFEC0
        public void get_graphicsDeviceID(){} // RVA: 0x7FFE87C731E0
        public void get_graphicsDeviceVendorID(){} // RVA: 0x7FFE87C73230
        public void get_graphicsDeviceType(){} // RVA: 0x7FFE87C73280
        public void get_graphicsUVStartsAtTop(){} // RVA: 0x7FFE87C732D0
        public void get_graphicsDeviceVersion(){} // RVA: 0x7FFE86EC01B0
        public void get_graphicsShaderLevel(){} // RVA: 0x7FFE87C73320
        public void get_graphicsMultiThreaded(){} // RVA: 0x7FFE86EC12A0
        public void get_renderingThreadingMode(){} // RVA: 0x7FFE87C73370
        public void get_supportsMotionVectors(){} // RVA: 0x7FFE87C733C0
        public void get_supports3DRenderTextures(){} // RVA: 0x7FFE87C73410
        public void get_copyTextureSupport(){} // RVA: 0x7FFE87C73460
        public void get_supportsComputeShaders(){} // RVA: 0x7FFE87C734B0
        public void get_supportsGeometryShaders(){} // RVA: 0x7FFE87C73500
        public void get_supportsInstancing(){} // RVA: 0x7FFE87C73550
        public void get_supportedRenderTargetCount(){} // RVA: 0x7FFE87C735A0
        public void get_supportedRandomWriteTargetCount(){} // RVA: 0x7FFE87C735F0
        public void get_usesReversedZBuffer(){} // RVA: 0x7FFE87C73640
        public void IsValidEnumValue(){} // RVA: 0x7FFE87C73690
        public void SupportsRenderTextureFormat(){} // RVA: 0x7FFE87C737A0
        public void SupportsTextureFormat(){} // RVA: 0x7FFE87C73880
        public void get_npotSupport(){} // RVA: 0x7FFE87C73960
        public void get_maxTextureSize(){} // RVA: 0x7FFE87C739B0
        public void get_maxCubemapSize(){} // RVA: 0x7FFE87C73A00
        public void get_maxRenderTextureSize(){} // RVA: 0x7FFE87C73A50
        public void get_maxComputeBufferInputsVertex(){} // RVA: 0x7FFE87C73AA0
        public void get_maxComputeBufferInputsCompute(){} // RVA: 0x7FFE87C73AF0
        public void get_maxComputeWorkGroupSize(){} // RVA: 0x7FFE87C73B40
        public void get_maxComputeWorkGroupSizeX(){} // RVA: 0x7FFE87C73B90
        public void get_maxComputeWorkGroupSizeY(){} // RVA: 0x7FFE87C73BE0
        public void get_maxComputeWorkGroupSizeZ(){} // RVA: 0x7FFE87C73C30
        public void get_supportsAsyncGPUReadback(){} // RVA: 0x7FFE87C73C80
        public void get_supportsRayTracing(){} // RVA: 0x7FFE87C73CD0
        public void get_maxGraphicsBufferSize(){} // RVA: 0x7FFE87C73D20
        public void get_usesLoadStoreActions(){} // RVA: 0x7FFE87C73D70
        public void get_supportsIndirectArgumentsBuffer(){} // RVA: 0x7FFE87C73DC0
        public void GetBatteryLevel(){} // RVA: 0x7FFE87C72E70
        public void GetBatteryStatus(){} // RVA: 0x7FFE87C72EC0
        public void GetOperatingSystem(){} // RVA: 0x7FFE86EBF2F0
        public void GetOperatingSystemFamily(){} // RVA: 0x7FFE87C72F10
        public void GetProcessorType(){} // RVA: 0x7FFE86EBF5E0
        public void GetProcessorFrequencyMHz(){} // RVA: 0x7FFE87C72F60
        public void GetProcessorCount(){} // RVA: 0x7FFE87C72FB0
        public void GetPhysicalMemoryMB(){} // RVA: 0x7FFE87C73000
        public void GetDeviceUniqueIdentifier(){} // RVA: 0x7FFE86EC1120
        public void GetDeviceName(){} // RVA: 0x7FFE87C73050
        public void GetDeviceModel(){} // RVA: 0x7FFE86EC1170
        public void SupportsVibration(){} // RVA: 0x7FFE87C730A0
        public void SupportsAudio(){} // RVA: 0x7FFE87C730F0
        public void GetDeviceType(){} // RVA: 0x7FFE87C73140
        public void GetGraphicsMemorySize(){} // RVA: 0x7FFE87C73190
        public void GetGraphicsDeviceName(){} // RVA: 0x7FFE86EBFCD0
        public void GetGraphicsDeviceVendor(){} // RVA: 0x7FFE86EBFEC0
        public void GetGraphicsDeviceID(){} // RVA: 0x7FFE87C731E0
        public void GetGraphicsDeviceVendorID(){} // RVA: 0x7FFE87C73230
        public void GetGraphicsDeviceType(){} // RVA: 0x7FFE87C73280
        public void GetGraphicsUVStartsAtTop(){} // RVA: 0x7FFE87C732D0
        public void GetGraphicsDeviceVersion(){} // RVA: 0x7FFE86EC01B0
        public void GetGraphicsShaderLevel(){} // RVA: 0x7FFE87C73320
        public void GetGraphicsMultiThreaded(){} // RVA: 0x7FFE86EC12A0
        public void GetRenderingThreadingMode(){} // RVA: 0x7FFE87C73370
        public void SupportsMotionVectors(){} // RVA: 0x7FFE87C733C0
        public void Supports3DRenderTextures(){} // RVA: 0x7FFE87C73410
        public void GetCopyTextureSupport(){} // RVA: 0x7FFE87C73460
        public void SupportsComputeShaders(){} // RVA: 0x7FFE87C734B0
        public void SupportsGeometryShaders(){} // RVA: 0x7FFE87C73500
        public void SupportsInstancing(){} // RVA: 0x7FFE87C73550
        public void SupportedRenderTargetCount(){} // RVA: 0x7FFE87C735A0
        public void SupportedRandomWriteTargetCount(){} // RVA: 0x7FFE87C735F0
        public void MaxComputeBufferInputsVertex(){} // RVA: 0x7FFE87C73AA0
        public void MaxComputeBufferInputsCompute(){} // RVA: 0x7FFE87C73AF0
        public void UsesReversedZBuffer(){} // RVA: 0x7FFE87C73640
        public void HasRenderTextureNative(){} // RVA: 0x7FFE87C73E10
        public void SupportsTextureFormatNative(){} // RVA: 0x7FFE87C73E60
        public void GetNPOTSupport(){} // RVA: 0x7FFE87C73960
        public void GetMaxTextureSize(){} // RVA: 0x7FFE87C739B0
        public void GetMaxCubemapSize(){} // RVA: 0x7FFE87C73A00
        public void GetMaxRenderTextureSize(){} // RVA: 0x7FFE87C73A50
        public void GetMaxComputeWorkGroupSize(){} // RVA: 0x7FFE87C73B40
        public void GetMaxComputeWorkGroupSizeX(){} // RVA: 0x7FFE87C73B90
        public void GetMaxComputeWorkGroupSizeY(){} // RVA: 0x7FFE87C73BE0
        public void GetMaxComputeWorkGroupSizeZ(){} // RVA: 0x7FFE87C73C30
        public void SupportsAsyncGPUReadback(){} // RVA: 0x7FFE87C73C80
        public void SupportsRayTracing(){} // RVA: 0x7FFE87C73CD0
        public void MaxGraphicsBufferSize(){} // RVA: 0x7FFE87C73D20
        public void IsFormatSupported(){} // RVA: 0x7FFE87C73EB0
        public void GetCompatibleFormat(){} // RVA: 0x7FFE87C73F10
        public void GetGraphicsFormat(){} // RVA: 0x7FFE87C73F70
        public void UsesLoadStoreActions(){} // RVA: 0x7FFE87C73D70
        public void SupportsIndirectArgumentsBuffer(){} // RVA: 0x7FFE87C73DC0
    }

}