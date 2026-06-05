// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 482

namespace ThirdParty.Unity.UnityEngine
{
    public class ScalableBufferManager
    {
        // ── Methods ──
        public void get_widthScaleFactor(){} // RVA: 0x7FFAF9B89270
        public void get_heightScaleFactor(){} // RVA: 0x7FFAF9B892C0
    }

    public class Screen
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x7FFAF9B83800
        public void get_height(){} // RVA: 0x7FFAF9B83850
        public void get_dpi(){} // RVA: 0x7FFAF9B838A0
        public void RequestOrientation(){} // RVA: 0x7FFAF9B838F0
        public void GetScreenOrientation(){} // RVA: 0x7FFAF9996A90
        public void get_orientation(){} // RVA: 0x7FFAF9996A90
        public void set_orientation(){} // RVA: 0x7FFAF9B83940
        public void set_sleepTimeout(){} // RVA: 0x7FFAF9B839F0
        public void SetOrientationEnabled(){} // RVA: 0x7FFAF9B83A40
        public void set_autorotateToPortrait(){} // RVA: 0x7FFAF9B83AA0
        public void set_autorotateToPortraitUpsideDown(){} // RVA: 0x7FFAF9B83B00
        public void set_autorotateToLandscapeLeft(){} // RVA: 0x7FFAF9B83B60
        public void set_autorotateToLandscapeRight(){} // RVA: 0x7FFAF9B83BC0
        public void get_currentResolution(){} // RVA: 0x7FFAF9B83C20
        public void get_fullScreen(){} // RVA: 0x7FFAF3857990
        public void set_fullScreen(){} // RVA: 0x7FFAF9B83C80
        public void get_fullScreenMode(){} // RVA: 0x7FFAF9B83CD0
        public void get_safeArea(){} // RVA: 0x7FFAF9B83D20
        public void SetResolution(){} // RVA: 0x7FFAF9B83EA0 | overloaded x3
        public void get_resolutions(){} // RVA: 0x7FFAF9B83F40
        public void get_currentResolution_Injected(){} // RVA: 0x7FFAF9B83F90
        public void get_safeArea_Injected(){} // RVA: 0x7FFAF9B83FE0
        public void SetResolution_Injected(){} // RVA: 0x7FFAF9B84030
    }

    public class ScreenCapture
    {
        // ── Methods ──
        public void CaptureScreenshotIntoRenderTexture(){} // RVA: 0x7FFAF9D062E0
    }

    public class ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BDAD10
        public void CreateInstance(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void CreateScriptableObject(){} // RVA: 0x7FFAF9BDAE00
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAF9BDAE50
    }

    public class ScriptingRuntime
    {
        // ── Methods ──
        public void GetAllUserAssemblies(){} // RVA: 0x7FFAF9BDAEB0
    }

    public class ScriptingUtility
    {
        // ── Methods ──
        public void IsManagedCodeWorking(){} // RVA: 0x7FFAF4B868C0
    }

    public class ScrollViewState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SecondarySpriteTexture
    {
    }

    public class SelectionBaseAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SendMouseEvents
    {
        // ── Methods ──
        public void UpdateMouse(){} // RVA: 0x7FFAF9C59350
        public void SetMouseMoved(){} // RVA: 0x7FFAF9C59650
        public void DoSendMouseEvents(){} // RVA: 0x7FFAF9C596B0
        public void SendEvents(){} // RVA: 0x7FFAF9C5A3F0
        public void .cctor(){} // RVA: 0x7FFAF9C5AAE0
    }

    public class SerializeField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SerializeReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SetupCoroutine
    {
        // ── Methods ──
        public void InvokeMoveNext(){} // RVA: 0x7FFAF9BD4560
        public void InvokeMember(){} // RVA: 0x7FFAF9BD4620
    }

    public class Shader
    {
        // ── Methods ──
        public void Find(){} // RVA: 0x7FFAF9B97830
        public void get_maximumChunksOverride(){} // RVA: 0x7FFAF9B978A0
        public void set_maximumChunksOverride(){} // RVA: 0x7FFAF9B978F0
        public void set_maximumLOD(){} // RVA: 0x7FFAF9B97940
        public void get_isSupported(){} // RVA: 0x7FFAF9B979A0
        public void EnableKeyword(){} // RVA: 0x7FFAF9B979F0
        public void DisableKeyword(){} // RVA: 0x7FFAF9B97A40
        public void get_renderQueue(){} // RVA: 0x7FFAF9B97A90
        public void WarmupAllShaders(){} // RVA: 0x7FFAF9B97AE0
        public void TagToID(){} // RVA: 0x7FFAF9B97B30
        public void PropertyToID(){} // RVA: 0x7FFAF9B97B80
        public void SetGlobalIntImpl(){} // RVA: 0x7FFAF9B97BD0
        public void SetGlobalFloatImpl(){} // RVA: 0x7FFAF9B97C30
        public void SetGlobalVectorImpl(){} // RVA: 0x7FFAF9B97C90
        public void SetGlobalMatrixImpl(){} // RVA: 0x7FFAF9B97CF0
        public void SetGlobalTextureImpl(){} // RVA: 0x7FFAF9B97D50
        public void SetGlobalFloatArrayImpl(){} // RVA: 0x7FFAF9B97DB0
        public void SetGlobalVectorArrayImpl(){} // RVA: 0x7FFAF9B97E20
        public void SetGlobalMatrixArrayImpl(){} // RVA: 0x7FFAF9B97E90
        public void SetGlobalFloatArray(){} // RVA: 0x7FFAF9B98810 | overloaded x3
        public void SetGlobalVectorArray(){} // RVA: 0x7FFAF9B988A0 | overloaded x3
        public void SetGlobalMatrixArray(){} // RVA: 0x7FFAF9B98930 | overloaded x3
        public void SetGlobalInt(){} // RVA: 0x7FFAF9B983D0 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFAF9B97C30 | overloaded x2
        public void SetGlobalInteger(){} // RVA: 0x7FFAF9B97BD0
        public void SetGlobalVector(){} // RVA: 0x7FFAF9B98580 | overloaded x2
        public void SetGlobalColor(){} // RVA: 0x7FFAF9B985E0
        public void SetGlobalMatrix(){} // RVA: 0x7FFAF9B98680
        public void SetGlobalTexture(){} // RVA: 0x7FFAF9B97D50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF9B98950
        public void GetPropertyName(){} // RVA: 0x7FFAF9B98B70 | overloaded x2
        public void GetPropertyType(){} // RVA: 0x7FFAF9B98BE0 | overloaded x2
        public void CheckPropertyIndex(){} // RVA: 0x7FFAF9B98A60
        public void GetPropertyCount(){} // RVA: 0x7FFAF9B98B20
        public void SetGlobalVectorImpl_Injected(){} // RVA: 0x7FFAF9B98C50
        public void SetGlobalMatrixImpl_Injected(){} // RVA: 0x7FFAF9B98CB0
    }

    public class SharedBetweenAnimatorsAttribute
    {
    }

    public class SkeletonBone
    {
    }

    public class SkinnedMeshRenderer
    {
        public object shouldSupportTiling;
        public object sprite;
        public object drawMode;
        public object size;
        public object adaptiveModeThreshold;
        public object tileMode;
        public object color;
        public object maskInteraction;

        // ── Methods ──
        public void get_quality(){} // RVA: 0x7FFAF9BA3B70
        public void set_quality(){} // RVA: 0x7FFAF9BA3BC0
        public void get_updateWhenOffscreen(){} // RVA: 0x7FFAF9BA3C20
        public void set_updateWhenOffscreen(){} // RVA: 0x7FFAF9BA3C70
        public void get_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFAF9BA3CD0
        public void set_forceMatrixRecalculationPerRender(){} // RVA: 0x7FFAF9BA3D20
        public void get_rootBone(){} // RVA: 0x7FFAF9BA3D80
        public void set_rootBone(){} // RVA: 0x7FFAF9BA3DD0
        public void get_bones(){} // RVA: 0x7FFAF9BA3E30
        public void set_bones(){} // RVA: 0x7FFAF9BA3E80
        public void get_sharedMesh(){} // RVA: 0x7FFAF9BA3EE0
        public void set_sharedMesh(){} // RVA: 0x7FFAF9BA3F30
        public void get_skinnedMotionVectors(){} // RVA: 0x7FFAF9BA3F90
        public void set_skinnedMotionVectors(){} // RVA: 0x7FFAF9BA3FE0
        public void GetBlendShapeWeight(){} // RVA: 0x7FFAF9BA4040
        public void SetBlendShapeWeight(){} // RVA: 0x7FFAF9BA40A0
        public void BakeMesh(){} // RVA: 0x7FFAF9BA4180 | overloaded x2
        public void GetVertexBuffer(){} // RVA: 0x7FFAF9BA41F0
        public void GetPreviousVertexBuffer(){} // RVA: 0x7FFAF9BA4330
        public void GetVertexBufferImpl(){} // RVA: 0x7FFAF9BA4470
        public void GetPreviousVertexBufferImpl(){} // RVA: 0x7FFAF9BA44C0
        public void get_vertexBufferTarget(){} // RVA: 0x7FFAF9BA4510
        public void set_vertexBufferTarget(){} // RVA: 0x7FFAF9BA4560
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Skybox
    {
        public object invalidSortingGroupID;

        // ── Methods ──
        public void get_material(){} // RVA: 0x7FFAF9BA2D80
        public void set_material(){} // RVA: 0x7FFAF9BA2DD0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SliderHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9C46A40
        public void Handle(){} // RVA: 0x7FFAF9C46B90
        public void OnMouseDown(){} // RVA: 0x7FFAF9C46C20
        public void OnMouseDrag(){} // RVA: 0x7FFAF9C47300
        public void OnMouseUp(){} // RVA: 0x7FFAF9C474B0
        public void OnRepaint(){} // RVA: 0x7FFAF9C47570
        public void CurrentEventType(){} // RVA: 0x7FFAF9C47D10
        public void CurrentScrollTroughSide(){} // RVA: 0x7FFAF9C47DB0
        public void IsEmptySlider(){} // RVA: 0x7FFAF9C47EB0
        public void SupportsPageMovements(){} // RVA: 0x7FFAF9C47ED0
        public void PageMovementValue(){} // RVA: 0x7FFAF9C47F80
        public void PageUpMovementBound(){} // RVA: 0x7FFAF9C48030
        public void CurrentEvent(){} // RVA: 0x7FFAF9C1E9D0
        public void ValueForCurrentMousePosition(){} // RVA: 0x7FFAF9C480B0
        public void Clamp(){} // RVA: 0x7FFAF9C48180
        public void ThumbSelectionRect(){} // RVA: 0x7FFAF9C481B0
        public void StartDraggingWithValue(){} // RVA: 0x7FFAF9C48200
        public void SliderState(){} // RVA: 0x7FFAF9C48260
        public void ThumbExtRect(){} // RVA: 0x7FFAF9C483B0
        public void ThumbRect(){} // RVA: 0x7FFAF9C481B0
        public void VerticalThumbRect(){} // RVA: 0x7FFAF9C48520
        public void HorizontalThumbRect(){} // RVA: 0x7FFAF9C48800
        public void ClampedCurrentValue(){} // RVA: 0x7FFAF9C48AE0
        public void MousePosition(){} // RVA: 0x7FFAF9C48B10
        public void ValuesPerPixel(){} // RVA: 0x7FFAF9C48BE0
        public void ThumbSize(){} // RVA: 0x7FFAF9C48D20
        public void MaxValue(){} // RVA: 0x7FFAF9C48F80
        public void MinValue(){} // RVA: 0x7FFAF9C48FA0
    }

    public class SliderJoint2D
    {
        public object suspension;
        public object useMotor;
        public object motor;
        public object jointTranslation;
        public object jointLinearSpeed;
        public object jointSpeed;
        public object jointAngle;

        // ── Methods ──
        public void get_autoConfigureAngle(){} // RVA: 0x7FFAF9C9CCD0
        public void set_autoConfigureAngle(){} // RVA: 0x7FFAF9C9CD20
        public void get_angle(){} // RVA: 0x7FFAF9C9CD80
        public void set_angle(){} // RVA: 0x7FFAF9C9CDD0
        public void get_useMotor(){} // RVA: 0x7FFAF9C9CE30
        public void set_useMotor(){} // RVA: 0x7FFAF9C9CE80
        public void get_useLimits(){} // RVA: 0x7FFAF9C9CEE0
        public void set_useLimits(){} // RVA: 0x7FFAF9C9CF30
        public void get_motor(){} // RVA: 0x7FFAF9C9CF90
        public void set_motor(){} // RVA: 0x7FFAF9C9CFF0
        public void get_limits(){} // RVA: 0x7FFAF9C9D050
        public void set_limits(){} // RVA: 0x7FFAF9C9D0B0
        public void get_limitState(){} // RVA: 0x7FFAF9C9D110
        public void get_referenceAngle(){} // RVA: 0x7FFAF9C9D160
        public void get_jointTranslation(){} // RVA: 0x7FFAF9C9D1B0
        public void get_jointSpeed(){} // RVA: 0x7FFAF9C9D200
        public void GetMotorForce(){} // RVA: 0x7FFAF9C9D250
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_motor_Injected(){} // RVA: 0x7FFAF9C9D2B0
        public void set_motor_Injected(){} // RVA: 0x7FFAF9C9D310
        public void get_limits_Injected(){} // RVA: 0x7FFAF9C9D370
        public void set_limits_Injected(){} // RVA: 0x7FFAF9C9D3D0
    }

    public class SliderState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Snapping
    {
        // ── Methods ──
        public void Snap(){} // RVA: 0x7FFAF81C0DC0
    }

    public class SoftJointLimit
    {
        public object spring;
        public object damper;

        // ── Methods ──
        public void get_limit(){} // RVA: 0x7FFAF2DB0D20
        public void set_limit(){} // RVA: 0x7FFAF4A28330
        public void get_bounciness(){} // RVA: 0x7FFAF2DB0D30
        public void set_bounciness(){} // RVA: 0x7FFAF4A28350
        public void get_contactDistance(){} // RVA: 0x7FFAF2DB0CF0
        public void set_contactDistance(){} // RVA: 0x7FFAF4A28340
    }

    public class SoftJointLimitSpring
    {
        public object targetVelocity;
        public object force;

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFAF2DB0D20
        public void set_spring(){} // RVA: 0x7FFAF4A28330
        public void get_damper(){} // RVA: 0x7FFAF2DB0D30
        public void set_damper(){} // RVA: 0x7FFAF4A28350
    }

    public class SortingLayer
    {
        // ── Methods ──
        public void GetLayerValueFromID(){} // RVA: 0x7FFAF9B691B0
        public void NameToID(){} // RVA: 0x7FFAF9B69200
    }

    public class SpaceAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2EB7330 | overloaded x2
    }

    public class SphereCollider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAF9CB2CC0
        public void set_center(){} // RVA: 0x7FFAF9CB2D30
        public void get_radius(){} // RVA: 0x7FFAF9CB2D90
        public void set_radius(){} // RVA: 0x7FFAF9CB2DE0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_center_Injected(){} // RVA: 0x7FFAF9CB2E40
        public void set_center_Injected(){} // RVA: 0x7FFAF9CB2EA0
    }

    public class SpringJoint
    {
        public object localReferencePoint;
        public object size;
        public object lodCount;
        public object lastLODBillboard;
        public object fadeMode;

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7FFAF9CB4B70
        public void set_spring(){} // RVA: 0x7FFAF9CB4BC0
        public void get_damper(){} // RVA: 0x7FFAF9CB4C20
        public void set_damper(){} // RVA: 0x7FFAF9CB4C70
        public void get_minDistance(){} // RVA: 0x7FFAF9CB4CD0
        public void set_minDistance(){} // RVA: 0x7FFAF9CB4D20
        public void get_maxDistance(){} // RVA: 0x7FFAF9CB4D80
        public void set_maxDistance(){} // RVA: 0x7FFAF9CB4DD0
        public void get_tolerance(){} // RVA: 0x7FFAF9CB4E30
        public void set_tolerance(){} // RVA: 0x7FFAF9CB4E80
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Sprite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BEFDC0
        public void GetPackingMode(){} // RVA: 0x7FFAF9BEFE10
        public void GetPackingRotation(){} // RVA: 0x7FFAF9BEFE60
        public void GetPacked(){} // RVA: 0x7FFAF9BEFEB0
        public void GetTextureRect(){} // RVA: 0x7FFAF9BEFF00
        public void GetTextureRectOffset(){} // RVA: 0x7FFAF9BEFF70
        public void GetInnerUVs(){} // RVA: 0x7FFAF9BEFFD0
        public void GetOuterUVs(){} // RVA: 0x7FFAF9BF0040
        public void GetPadding(){} // RVA: 0x7FFAF9BF00B0
        public void CreateSprite(){} // RVA: 0x7FFAF9BF0120
        public void get_bounds(){} // RVA: 0x7FFAF9BF01E0
        public void get_rect(){} // RVA: 0x7FFAF9BF0250
        public void get_border(){} // RVA: 0x7FFAF9BF02C0
        public void get_texture(){} // RVA: 0x7FFAF9BF0330
        public void GetSecondaryTextureCount(){} // RVA: 0x7FFAF9BF0380
        public void GetSecondaryTextures(){} // RVA: 0x7FFAF9BF03D0
        public void get_pixelsPerUnit(){} // RVA: 0x7FFAF9BF0430
        public void get_spriteAtlasTextureScale(){} // RVA: 0x7FFAF9BF0480
        public void get_associatedAlphaSplitTexture(){} // RVA: 0x7FFAF9BF04D0
        public void get_pivot(){} // RVA: 0x7FFAF9BF0520
        public void get_packed(){} // RVA: 0x7FFAF9BF0580
        public void get_packingMode(){} // RVA: 0x7FFAF9BEFE10
        public void get_packingRotation(){} // RVA: 0x7FFAF9BEFE60
        public void get_textureRect(){} // RVA: 0x7FFAF9BF05E0
        public void get_textureRectOffset(){} // RVA: 0x7FFAF9BEFF70
        public void get_vertices(){} // RVA: 0x7FFAF9BF0660
        public void get_triangles(){} // RVA: 0x7FFAF9BF06B0
        public void get_uv(){} // RVA: 0x7FFAF9BF0700
        public void GetPhysicsShapeCount(){} // RVA: 0x7FFAF9BF0750
        public void GetPhysicsShapePointCount(){} // RVA: 0x7FFAF9BF07A0
        public void Internal_GetPhysicsShapePointCount(){} // RVA: 0x7FFAF9BF0910
        public void GetPhysicsShape(){} // RVA: 0x7FFAF9BF0970
        public void GetPhysicsShapeImpl(){} // RVA: 0x7FFAF9BF0B20
        public void OverridePhysicsShape(){} // RVA: 0x7FFAF9BF0FD0 | overloaded x2
        public void OverridePhysicsShapeCount(){} // RVA: 0x7FFAF9BF0F70
        public void OverrideGeometry(){} // RVA: 0x7FFAF9BF1040
        public void Create(){} // RVA: 0x7FFAF9BF1920 | overloaded x7
        public void GetTextureRect_Injected(){} // RVA: 0x7FFAF9BF1960
        public void GetTextureRectOffset_Injected(){} // RVA: 0x7FFAF9BF19C0
        public void GetInnerUVs_Injected(){} // RVA: 0x7FFAF9BF1A20
        public void GetOuterUVs_Injected(){} // RVA: 0x7FFAF9BF1A80
        public void GetPadding_Injected(){} // RVA: 0x7FFAF9BF1AE0
        public void CreateSprite_Injected(){} // RVA: 0x7FFAF9BF1B40
        public void get_bounds_Injected(){} // RVA: 0x7FFAF9BF1BD0
        public void get_rect_Injected(){} // RVA: 0x7FFAF9BF1C30
        public void get_border_Injected(){} // RVA: 0x7FFAF9BF1C90
        public void get_pivot_Injected(){} // RVA: 0x7FFAF9BF1CF0
    }

    public class SpriteMask
    {
        // ── Methods ──
        public void get_frontSortingLayerID(){} // RVA: 0x7FFAF9D09240
        public void set_frontSortingLayerID(){} // RVA: 0x7FFAF9D09290
        public void get_frontSortingOrder(){} // RVA: 0x7FFAF9D092F0
        public void set_frontSortingOrder(){} // RVA: 0x7FFAF9D09340
        public void get_backSortingLayerID(){} // RVA: 0x7FFAF9D093A0
        public void set_backSortingLayerID(){} // RVA: 0x7FFAF9D093F0
        public void get_backSortingOrder(){} // RVA: 0x7FFAF9D09450
        public void set_backSortingOrder(){} // RVA: 0x7FFAF9D094A0
        public void get_alphaCutoff(){} // RVA: 0x7FFAF9D09500
        public void set_alphaCutoff(){} // RVA: 0x7FFAF9D09550
        public void get_sprite(){} // RVA: 0x7FFAF9D095B0
        public void set_sprite(){} // RVA: 0x7FFAF9D09600
        public void get_isCustomRangeActive(){} // RVA: 0x7FFAF9D09660
        public void set_isCustomRangeActive(){} // RVA: 0x7FFAF9D096B0
        public void get_spriteSortPoint(){} // RVA: 0x7FFAF9D09710
        public void set_spriteSortPoint(){} // RVA: 0x7FFAF9D09760
        public void GetSpriteBounds(){} // RVA: 0x7FFAF9D097C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void GetSpriteBounds_Injected(){} // RVA: 0x7FFAF9D09830
    }

    public class SpriteRenderer
    {
        // ── Methods ──
        public void RegisterSpriteChangeCallback(){} // RVA: 0x7FFAF9BEEF20
        public void UnregisterSpriteChangeCallback(){} // RVA: 0x7FFAF9BEF090
        public void InvokeSpriteChanged(){} // RVA: 0x7FFAF9BEF120
        public void get_shouldSupportTiling(){} // RVA: 0x7FFAF9BEF1B0
        public void get_sprite(){} // RVA: 0x7FFAF9BEF200
        public void set_sprite(){} // RVA: 0x7FFAF9BEF250
        public void get_drawMode(){} // RVA: 0x7FFAF9BEF2B0
        public void set_drawMode(){} // RVA: 0x7FFAF9BEF300
        public void get_size(){} // RVA: 0x7FFAF9BEF360
        public void set_size(){} // RVA: 0x7FFAF9BEF3C0
        public void get_adaptiveModeThreshold(){} // RVA: 0x7FFAF9BEF420
        public void set_adaptiveModeThreshold(){} // RVA: 0x7FFAF9BEF470
        public void get_tileMode(){} // RVA: 0x7FFAF9BEF4D0
        public void set_tileMode(){} // RVA: 0x7FFAF9BEF520
        public void get_color(){} // RVA: 0x7FFAF9BEF580
        public void set_color(){} // RVA: 0x7FFAF9BEF5F0
        public void get_maskInteraction(){} // RVA: 0x7FFAF9BEF650
        public void set_maskInteraction(){} // RVA: 0x7FFAF9BEF6A0
        public void get_flipX(){} // RVA: 0x7FFAF9BEF700
        public void set_flipX(){} // RVA: 0x7FFAF9BEF750
        public void get_flipY(){} // RVA: 0x7FFAF9BEF7B0
        public void set_flipY(){} // RVA: 0x7FFAF9BEF800
        public void get_spriteSortPoint(){} // RVA: 0x7FFAF9BEF860
        public void set_spriteSortPoint(){} // RVA: 0x7FFAF9BEF8B0
        public void GetCurrentMeshDataPtr(){} // RVA: 0x7FFAF9BEF910
        public void GetCurrentMeshData(){} // RVA: 0x7FFAF9BEF960
        public void Internal_GetSpriteBounds(){} // RVA: 0x7FFAF9BEFA10
        public void GetSecondaryTextureProperties(){} // RVA: 0x7FFAF9BEFA90
        public void GetSpriteBounds(){} // RVA: 0x7FFAF9BEFAF0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_size_Injected(){} // RVA: 0x7FFAF9BEFBD0
        public void set_size_Injected(){} // RVA: 0x7FFAF9BEFC30
        public void get_color_Injected(){} // RVA: 0x7FFAF9BEFC90
        public void set_color_Injected(){} // RVA: 0x7FFAF9BEFCF0
        public void Internal_GetSpriteBounds_Injected(){} // RVA: 0x7FFAF9BEFD50
    }

    public class StackTraceUtility
    {
        // ── Methods ──
        public void SetProjectFolder(){} // RVA: 0x7FFAF9BDAF00
        public void ExtractStackTrace(){} // RVA: 0x7FFAF9BDB0C0
        public void ExtractStringFromExceptionInternal(){} // RVA: 0x7FFAF9BDB240
        public void ExtractFormattedStackTrace(){} // RVA: 0x7FFAF9BDB700
        public void .cctor(){} // RVA: 0x7FFAF9BDC0C0
    }

    public class StateMachineBehaviour
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateUpdate(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateExit(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateMove(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateIK(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateMachineEnter(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void OnStateMachineExit(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class Subsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF2AD4A50
        public void Stop(){} // RVA: 0x7FFAF2AD4A50
        public void Destroy(){} // RVA: 0x7FFAF9D09DD0
        public void OnDestroy(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SubsystemBindings
    {
        // ── Methods ──
        public void DestroySubsystem(){} // RVA: 0x7FFAF9D09C90
    }

    public class SubsystemDescriptor
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAF2DA8380
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFAF91CBFB0
        public void CreateImpl(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SubsystemDescriptorBindings
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9D09D30
        public void GetId(){} // RVA: 0x7FFAF9D09D80
    }

    public class SubsystemManager
    {
        // ── Methods ──
        public void ReloadSubsystemsStarted(){} // RVA: 0x7FFAF9D09F60
        public void ReloadSubsystemsCompleted(){} // RVA: 0x7FFAF9D0A050
        public void InitializeIntegratedSubsystem(){} // RVA: 0x7FFAF9D0A140
        public void ClearSubsystems(){} // RVA: 0x7FFAF9D0A270
        public void StaticConstructScriptingClassMap(){} // RVA: 0x7FFAF9D0A4F0
        public void .cctor(){} // RVA: 0x7FFAF9D0A540
        public void GetSubsystemDescriptors(){} // RVA: 0x7FFAF2AD4AE0
        public void GetSubsystems(){} // RVA: 0x7FFAF2AD4AE0
        public void AddSubsystemSubset(){} // RVA: 0x7FFAF2AD4D50
        public void GetIntegratedSubsystemByPtr(){} // RVA: 0x7FFAF9D0A7E0
        public void RemoveIntegratedSubsystemByPtr(){} // RVA: 0x7FFAF9D0A960
        public void RemoveStandaloneSubsystem(){} // RVA: 0x7FFAF9D0AAF0
        public void RemoveDeprecatedSubsystem(){} // RVA: 0x7FFAF9D0AB80
    }

    public class SurfaceEffector2D
    {
        // ── Methods ──
        public void get_speed(){} // RVA: 0x7FFAF9C9F180
        public void set_speed(){} // RVA: 0x7FFAF9C9F1D0
        public void get_speedVariation(){} // RVA: 0x7FFAF9C9F230
        public void set_speedVariation(){} // RVA: 0x7FFAF9C9F280
        public void get_forceScale(){} // RVA: 0x7FFAF9C9F2E0
        public void set_forceScale(){} // RVA: 0x7FFAF9C9F330
        public void get_useContactForce(){} // RVA: 0x7FFAF9C9F390
        public void set_useContactForce(){} // RVA: 0x7FFAF9C9F3E0
        public void get_useFriction(){} // RVA: 0x7FFAF9C9F440
        public void set_useFriction(){} // RVA: 0x7FFAF9C9F490
        public void get_useBounce(){} // RVA: 0x7FFAF9C9F4F0
        public void set_useBounce(){} // RVA: 0x7FFAF9C9F540
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SystemClock
    {
        public object time;

        // ── Methods ──
        public void get_now(){} // RVA: 0x7FFAF9BE3350
        public void .cctor(){} // RVA: 0x7FFAF9BE33A0
    }

    public class SystemInfo
    {
        public object now;
        public object get_time;
        public object UkM;
        public object get_fixedTimeAsDouble;
        public object ;[Y;
        public object get_fixedUnscaledDeltaTime;
        public object set_timeScale;
        public object 4\Y;

        // ── Methods ──
        public void get_batteryLevel(){} // RVA: 0x7FFAF9BE21B0
        public void get_batteryStatus(){} // RVA: 0x7FFAF9BE2200
        public void get_operatingSystem(){} // RVA: 0x7FFAF8E2E8D0
        public void get_operatingSystemFamily(){} // RVA: 0x7FFAF9BE2250
        public void get_processorType(){} // RVA: 0x7FFAF8E2EBC0
        public void get_processorFrequency(){} // RVA: 0x7FFAF9BE22A0
        public void get_processorCount(){} // RVA: 0x7FFAF9BE22F0
        public void get_systemMemorySize(){} // RVA: 0x7FFAF9BE2340
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFAF8E30700
        public void get_deviceName(){} // RVA: 0x7FFAF9BE2390
        public void get_deviceModel(){} // RVA: 0x7FFAF8E30750
        public void get_supportsVibration(){} // RVA: 0x7FFAF9BE23E0
        public void get_supportsAudio(){} // RVA: 0x7FFAF9BE2430
        public void get_deviceType(){} // RVA: 0x7FFAF9BE2480
        public void get_graphicsMemorySize(){} // RVA: 0x7FFAF9BE24D0
        public void get_graphicsDeviceName(){} // RVA: 0x7FFAF8E2F2B0
        public void get_graphicsDeviceVendor(){} // RVA: 0x7FFAF8E2F4A0
        public void get_graphicsDeviceID(){} // RVA: 0x7FFAF9BE2520
        public void get_graphicsDeviceVendorID(){} // RVA: 0x7FFAF9BE2570
        public void get_graphicsDeviceType(){} // RVA: 0x7FFAF9BE25C0
        public void get_graphicsUVStartsAtTop(){} // RVA: 0x7FFAF9BE2610
        public void get_graphicsDeviceVersion(){} // RVA: 0x7FFAF8E2F790
        public void get_graphicsShaderLevel(){} // RVA: 0x7FFAF9BE2660
        public void get_graphicsMultiThreaded(){} // RVA: 0x7FFAF8E30880
        public void get_renderingThreadingMode(){} // RVA: 0x7FFAF9BE26B0
        public void get_supportsMotionVectors(){} // RVA: 0x7FFAF9BE2700
        public void get_supports3DRenderTextures(){} // RVA: 0x7FFAF9BE2750
        public void get_copyTextureSupport(){} // RVA: 0x7FFAF9BE27A0
        public void get_supportsComputeShaders(){} // RVA: 0x7FFAF9BE27F0
        public void get_supportsGeometryShaders(){} // RVA: 0x7FFAF9BE2840
        public void get_supportsInstancing(){} // RVA: 0x7FFAF9BE2890
        public void get_supportedRenderTargetCount(){} // RVA: 0x7FFAF9BE28E0
        public void get_supportedRandomWriteTargetCount(){} // RVA: 0x7FFAF9BE2930
        public void get_usesReversedZBuffer(){} // RVA: 0x7FFAF9BE2980
        public void IsValidEnumValue(){} // RVA: 0x7FFAF9BE29D0
        public void SupportsRenderTextureFormat(){} // RVA: 0x7FFAF9BE2AE0
        public void SupportsTextureFormat(){} // RVA: 0x7FFAF9BE2BC0
        public void get_npotSupport(){} // RVA: 0x7FFAF9BE2CA0
        public void get_maxTextureSize(){} // RVA: 0x7FFAF9BE2CF0
        public void get_maxCubemapSize(){} // RVA: 0x7FFAF9BE2D40
        public void get_maxRenderTextureSize(){} // RVA: 0x7FFAF9BE2D90
        public void get_maxComputeBufferInputsVertex(){} // RVA: 0x7FFAF9BE2DE0
        public void get_maxComputeBufferInputsCompute(){} // RVA: 0x7FFAF9BE2E30
        public void get_maxComputeWorkGroupSize(){} // RVA: 0x7FFAF9BE2E80
        public void get_maxComputeWorkGroupSizeX(){} // RVA: 0x7FFAF9BE2ED0
        public void get_maxComputeWorkGroupSizeY(){} // RVA: 0x7FFAF9BE2F20
        public void get_maxComputeWorkGroupSizeZ(){} // RVA: 0x7FFAF9BE2F70
        public void get_supportsGraphicsFence(){} // RVA: 0x7FFAF9BE2FC0
        public void get_supportsAsyncGPUReadback(){} // RVA: 0x7FFAF9BE3010
        public void get_supportsRayTracing(){} // RVA: 0x7FFAF9BE3060
        public void get_maxGraphicsBufferSize(){} // RVA: 0x7FFAF9BE30B0
        public void get_usesLoadStoreActions(){} // RVA: 0x7FFAF9BE3100
        public void get_supportsIndirectArgumentsBuffer(){} // RVA: 0x7FFAF9BE3150
        public void GetBatteryLevel(){} // RVA: 0x7FFAF9BE21B0
        public void GetBatteryStatus(){} // RVA: 0x7FFAF9BE2200
        public void GetOperatingSystem(){} // RVA: 0x7FFAF8E2E8D0
        public void GetOperatingSystemFamily(){} // RVA: 0x7FFAF9BE2250
        public void GetProcessorType(){} // RVA: 0x7FFAF8E2EBC0
        public void GetProcessorFrequencyMHz(){} // RVA: 0x7FFAF9BE22A0
        public void GetProcessorCount(){} // RVA: 0x7FFAF9BE22F0
        public void GetPhysicalMemoryMB(){} // RVA: 0x7FFAF9BE2340
        public void GetDeviceUniqueIdentifier(){} // RVA: 0x7FFAF8E30700
        public void GetDeviceName(){} // RVA: 0x7FFAF9BE2390
        public void GetDeviceModel(){} // RVA: 0x7FFAF8E30750
        public void SupportsVibration(){} // RVA: 0x7FFAF9BE23E0
        public void SupportsAudio(){} // RVA: 0x7FFAF9BE2430
        public void GetDeviceType(){} // RVA: 0x7FFAF9BE2480
        public void GetGraphicsMemorySize(){} // RVA: 0x7FFAF9BE24D0
        public void GetGraphicsDeviceName(){} // RVA: 0x7FFAF8E2F2B0
        public void GetGraphicsDeviceVendor(){} // RVA: 0x7FFAF8E2F4A0
        public void GetGraphicsDeviceID(){} // RVA: 0x7FFAF9BE2520
        public void GetGraphicsDeviceVendorID(){} // RVA: 0x7FFAF9BE2570
        public void GetGraphicsDeviceType(){} // RVA: 0x7FFAF9BE25C0
        public void GetGraphicsUVStartsAtTop(){} // RVA: 0x7FFAF9BE2610
        public void GetGraphicsDeviceVersion(){} // RVA: 0x7FFAF8E2F790
        public void GetGraphicsShaderLevel(){} // RVA: 0x7FFAF9BE2660
        public void GetGraphicsMultiThreaded(){} // RVA: 0x7FFAF8E30880
        public void GetRenderingThreadingMode(){} // RVA: 0x7FFAF9BE26B0
        public void SupportsMotionVectors(){} // RVA: 0x7FFAF9BE2700
        public void Supports3DRenderTextures(){} // RVA: 0x7FFAF9BE2750
        public void GetCopyTextureSupport(){} // RVA: 0x7FFAF9BE27A0
        public void SupportsComputeShaders(){} // RVA: 0x7FFAF9BE27F0
        public void SupportsGeometryShaders(){} // RVA: 0x7FFAF9BE2840
        public void SupportsInstancing(){} // RVA: 0x7FFAF9BE2890
        public void SupportedRenderTargetCount(){} // RVA: 0x7FFAF9BE28E0
        public void SupportedRandomWriteTargetCount(){} // RVA: 0x7FFAF9BE2930
        public void MaxComputeBufferInputsVertex(){} // RVA: 0x7FFAF9BE2DE0
        public void MaxComputeBufferInputsCompute(){} // RVA: 0x7FFAF9BE2E30
        public void UsesReversedZBuffer(){} // RVA: 0x7FFAF9BE2980
        public void HasRenderTextureNative(){} // RVA: 0x7FFAF9BE31A0
        public void SupportsTextureFormatNative(){} // RVA: 0x7FFAF9BE31F0
        public void GetNPOTSupport(){} // RVA: 0x7FFAF9BE2CA0
        public void GetMaxTextureSize(){} // RVA: 0x7FFAF9BE2CF0
        public void GetMaxCubemapSize(){} // RVA: 0x7FFAF9BE2D40
        public void GetMaxRenderTextureSize(){} // RVA: 0x7FFAF9BE2D90
        public void GetMaxComputeWorkGroupSize(){} // RVA: 0x7FFAF9BE2E80
        public void GetMaxComputeWorkGroupSizeX(){} // RVA: 0x7FFAF9BE2ED0
        public void GetMaxComputeWorkGroupSizeY(){} // RVA: 0x7FFAF9BE2F20
        public void GetMaxComputeWorkGroupSizeZ(){} // RVA: 0x7FFAF9BE2F70
        public void SupportsGPUFence(){} // RVA: 0x7FFAF9BE2FC0
        public void SupportsAsyncGPUReadback(){} // RVA: 0x7FFAF9BE3010
        public void SupportsRayTracing(){} // RVA: 0x7FFAF9BE3060
        public void MaxGraphicsBufferSize(){} // RVA: 0x7FFAF9BE30B0
        public void IsFormatSupported(){} // RVA: 0x7FFAF9BE3240
        public void GetCompatibleFormat(){} // RVA: 0x7FFAF9BE32A0
        public void GetGraphicsFormat(){} // RVA: 0x7FFAF9BE3300
        public void UsesLoadStoreActions(){} // RVA: 0x7FFAF9BE3100
        public void SupportsIndirectArgumentsBuffer(){} // RVA: 0x7FFAF9BE3150
    }

}