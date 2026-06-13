// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 482

namespace ThirdParty.Unity.UnityEngine
{
    public class ScalableBufferManager
    {
        // ── Methods ──
        public void get_widthScaleFactor(){} // RVA: 0x70D9270
        public void get_heightScaleFactor(){} // RVA: 0x70D92C0
    }

    public class Screen
    {
        // ── Methods ──
        public void get_width(){} // RVA: 0x70D3800
        public void get_height(){} // RVA: 0x70D3850
        public void get_dpi(){} // RVA: 0x70D38A0
        public void RequestOrientation(){} // RVA: 0x70D38F0
        public void GetScreenOrientation(){} // RVA: 0x6EE6A90
        public void get_orientation(){} // RVA: 0x6EE6A90
        public void set_orientation(){} // RVA: 0x70D3940
        public void set_sleepTimeout(){} // RVA: 0x70D39F0
        public void SetOrientationEnabled(){} // RVA: 0x70D3A40
        public void set_autorotateToPortrait(){} // RVA: 0x70D3AA0
        public void set_autorotateToPortraitUpsideDown(){} // RVA: 0x70D3B00
        public void set_autorotateToLandscapeLeft(){} // RVA: 0x70D3B60
        public void set_autorotateToLandscapeRight(){} // RVA: 0x70D3BC0
        public void get_currentResolution(){} // RVA: 0x70D3C20
        public void get_fullScreen(){} // RVA: 0xDA7990
        public void set_fullScreen(){} // RVA: 0x70D3C80
        public void get_fullScreenMode(){} // RVA: 0x70D3CD0
        public void get_safeArea(){} // RVA: 0x70D3D20
        public void SetResolution(){} // RVA: 0x70D3EA0 | overloaded x3
        public void get_resolutions(){} // RVA: 0x70D3F40
        public void get_currentResolution_Injected(){} // RVA: 0x70D3F90
        public void get_safeArea_Injected(){} // RVA: 0x70D3FE0
        public void SetResolution_Injected(){} // RVA: 0x70D4030
    }

    public class ScreenCapture
    {
        // ── Methods ──
        public void CaptureScreenshotIntoRenderTexture(){} // RVA: 0x72562E0
    }

    public class ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x712AD10
        public void CreateInstance(){} // RVA: 0x283FA0 | overloaded x2
        public void CreateScriptableObject(){} // RVA: 0x712AE00
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x712AE50
    }

    public class ScriptingRuntime
    {
        // ── Methods ──
        public void GetAllUserAssemblies(){} // RVA: 0x712AEB0
    }

    public class ScriptingUtility
    {
        // ── Methods ──
        public void IsManagedCodeWorking(){} // RVA: 0x20D68C0
    }

    public class ScrollViewState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecondarySpriteTexture
    {
    }

    public class SelectionBaseAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SendMouseEvents
    {
        // ── Methods ──
        public void UpdateMouse(){} // RVA: 0x71A9350
        public void SetMouseMoved(){} // RVA: 0x71A9650
        public void DoSendMouseEvents(){} // RVA: 0x71A96B0
        public void SendEvents(){} // RVA: 0x71AA3F0
        public void .cctor(){} // RVA: 0x71AAAE0
    }

    public class SerializeField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SerializeReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SetupCoroutine
    {
        // ── Methods ──
        public void InvokeMoveNext(){} // RVA: 0x7124560
        public void InvokeMember(){} // RVA: 0x7124620
    }

    public class Shader
    {
        // ── Methods ──
        public void Find(){} // RVA: 0x70E7830
        public void get_maximumChunksOverride(){} // RVA: 0x70E78A0
        public void set_maximumChunksOverride(){} // RVA: 0x70E78F0
        public void set_maximumLOD(){} // RVA: 0x70E7940
        public void get_isSupported(){} // RVA: 0x70E79A0
        public void EnableKeyword(){} // RVA: 0x70E79F0
        public void DisableKeyword(){} // RVA: 0x70E7A40
        public void get_renderQueue(){} // RVA: 0x70E7A90
        public void WarmupAllShaders(){} // RVA: 0x70E7AE0
        public void TagToID(){} // RVA: 0x70E7B30
        public void PropertyToID(){} // RVA: 0x70E7B80
        public void SetGlobalIntImpl(){} // RVA: 0x70E7BD0
        public void SetGlobalFloatImpl(){} // RVA: 0x70E7C30
        public void SetGlobalVectorImpl(){} // RVA: 0x70E7C90
        public void SetGlobalMatrixImpl(){} // RVA: 0x70E7CF0
        public void SetGlobalTextureImpl(){} // RVA: 0x70E7D50
        public void SetGlobalFloatArrayImpl(){} // RVA: 0x70E7DB0
        public void SetGlobalVectorArrayImpl(){} // RVA: 0x70E7E20
        public void SetGlobalMatrixArrayImpl(){} // RVA: 0x70E7E90
        public void SetGlobalFloatArray(){} // RVA: 0x70E8810 | overloaded x3
        public void SetGlobalVectorArray(){} // RVA: 0x70E88A0 | overloaded x3
        public void SetGlobalMatrixArray(){} // RVA: 0x70E8930 | overloaded x3
        public void SetGlobalInt(){} // RVA: 0x70E83D0 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x70E7C30 | overloaded x2
        public void SetGlobalInteger(){} // RVA: 0x70E7BD0
        public void SetGlobalVector(){} // RVA: 0x70E8580 | overloaded x2
        public void SetGlobalColor(){} // RVA: 0x70E85E0
        public void SetGlobalMatrix(){} // RVA: 0x70E8680
        public void SetGlobalTexture(){} // RVA: 0x70E7D50 | overloaded x2
        public void .ctor(){} // RVA: 0x70E8950
        public void GetPropertyName(){} // RVA: 0x70E8B70 | overloaded x2
        public void GetPropertyType(){} // RVA: 0x70E8BE0 | overloaded x2
        public void CheckPropertyIndex(){} // RVA: 0x70E8A60
        public void GetPropertyCount(){} // RVA: 0x70E8B20
        public void SetGlobalVectorImpl_Injected(){} // RVA: 0x70E8C50
        public void SetGlobalMatrixImpl_Injected(){} // RVA: 0x70E8CB0
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
        public void get_quality(){} // RVA: 0x70F3B70
        public void set_quality(){} // RVA: 0x70F3BC0
        public void get_updateWhenOffscreen(){} // RVA: 0x70F3C20
        public void set_updateWhenOffscreen(){} // RVA: 0x70F3C70
        public void get_forceMatrixRecalculationPerRender(){} // RVA: 0x70F3CD0
        public void set_forceMatrixRecalculationPerRender(){} // RVA: 0x70F3D20
        public void get_rootBone(){} // RVA: 0x70F3D80
        public void set_rootBone(){} // RVA: 0x70F3DD0
        public void get_bones(){} // RVA: 0x70F3E30
        public void set_bones(){} // RVA: 0x70F3E80
        public void get_sharedMesh(){} // RVA: 0x70F3EE0
        public void set_sharedMesh(){} // RVA: 0x70F3F30
        public void get_skinnedMotionVectors(){} // RVA: 0x70F3F90
        public void set_skinnedMotionVectors(){} // RVA: 0x70F3FE0
        public void GetBlendShapeWeight(){} // RVA: 0x70F4040
        public void SetBlendShapeWeight(){} // RVA: 0x70F40A0
        public void BakeMesh(){} // RVA: 0x70F4180 | overloaded x2
        public void GetVertexBuffer(){} // RVA: 0x70F41F0
        public void GetPreviousVertexBuffer(){} // RVA: 0x70F4330
        public void GetVertexBufferImpl(){} // RVA: 0x70F4470
        public void GetPreviousVertexBufferImpl(){} // RVA: 0x70F44C0
        public void get_vertexBufferTarget(){} // RVA: 0x70F4510
        public void set_vertexBufferTarget(){} // RVA: 0x70F4560
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Skybox
    {
        public object invalidSortingGroupID;

        // ── Methods ──
        public void get_material(){} // RVA: 0x70F2D80
        public void set_material(){} // RVA: 0x70F2DD0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SliderHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7196A40
        public void Handle(){} // RVA: 0x7196B90
        public void OnMouseDown(){} // RVA: 0x7196C20
        public void OnMouseDrag(){} // RVA: 0x7197300
        public void OnMouseUp(){} // RVA: 0x71974B0
        public void OnRepaint(){} // RVA: 0x7197570
        public void CurrentEventType(){} // RVA: 0x7197D10
        public void CurrentScrollTroughSide(){} // RVA: 0x7197DB0
        public void IsEmptySlider(){} // RVA: 0x7197EB0
        public void SupportsPageMovements(){} // RVA: 0x7197ED0
        public void PageMovementValue(){} // RVA: 0x7197F80
        public void PageUpMovementBound(){} // RVA: 0x7198030
        public void CurrentEvent(){} // RVA: 0x716E9D0
        public void ValueForCurrentMousePosition(){} // RVA: 0x71980B0
        public void Clamp(){} // RVA: 0x7198180
        public void ThumbSelectionRect(){} // RVA: 0x71981B0
        public void StartDraggingWithValue(){} // RVA: 0x7198200
        public void SliderState(){} // RVA: 0x7198260
        public void ThumbExtRect(){} // RVA: 0x71983B0
        public void ThumbRect(){} // RVA: 0x71981B0
        public void VerticalThumbRect(){} // RVA: 0x7198520
        public void HorizontalThumbRect(){} // RVA: 0x7198800
        public void ClampedCurrentValue(){} // RVA: 0x7198AE0
        public void MousePosition(){} // RVA: 0x7198B10
        public void ValuesPerPixel(){} // RVA: 0x7198BE0
        public void ThumbSize(){} // RVA: 0x7198D20
        public void MaxValue(){} // RVA: 0x7198F80
        public void MinValue(){} // RVA: 0x7198FA0
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
        public void get_autoConfigureAngle(){} // RVA: 0x71ECCD0
        public void set_autoConfigureAngle(){} // RVA: 0x71ECD20
        public void get_angle(){} // RVA: 0x71ECD80
        public void set_angle(){} // RVA: 0x71ECDD0
        public void get_useMotor(){} // RVA: 0x71ECE30
        public void set_useMotor(){} // RVA: 0x71ECE80
        public void get_useLimits(){} // RVA: 0x71ECEE0
        public void set_useLimits(){} // RVA: 0x71ECF30
        public void get_motor(){} // RVA: 0x71ECF90
        public void set_motor(){} // RVA: 0x71ECFF0
        public void get_limits(){} // RVA: 0x71ED050
        public void set_limits(){} // RVA: 0x71ED0B0
        public void get_limitState(){} // RVA: 0x71ED110
        public void get_referenceAngle(){} // RVA: 0x71ED160
        public void get_jointTranslation(){} // RVA: 0x71ED1B0
        public void get_jointSpeed(){} // RVA: 0x71ED200
        public void GetMotorForce(){} // RVA: 0x71ED250
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_motor_Injected(){} // RVA: 0x71ED2B0
        public void set_motor_Injected(){} // RVA: 0x71ED310
        public void get_limits_Injected(){} // RVA: 0x71ED370
        public void set_limits_Injected(){} // RVA: 0x71ED3D0
    }

    public class SliderState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Snapping
    {
        // ── Methods ──
        public void Snap(){} // RVA: 0x5710DC0
    }

    public class SoftJointLimit
    {
        public float spring; // 0x10
        public float damper; // 0x14
        public float m_ContactDistance; // 0x18

        // ── Methods ──
        public void get_limit(){} // RVA: 0x300D20
        public void set_limit(){} // RVA: 0x1F78330
        public void get_bounciness(){} // RVA: 0x300D30
        public void set_bounciness(){} // RVA: 0x1F78350
        public void get_contactDistance(){} // RVA: 0x300CF0
        public void set_contactDistance(){} // RVA: 0x1F78340
    }

    public class SoftJointLimitSpring
    {
        public float targetVelocity; // 0x10
        public float force; // 0x14

        // ── Methods ──
        public void get_spring(){} // RVA: 0x300D20
        public void set_spring(){} // RVA: 0x1F78330
        public void get_damper(){} // RVA: 0x300D30
        public void set_damper(){} // RVA: 0x1F78350
    }

    public class SortingLayer
    {
        // ── Methods ──
        public void GetLayerValueFromID(){} // RVA: 0x70B91B0
        public void NameToID(){} // RVA: 0x70B9200
    }

    public class SpaceAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330 | overloaded x2
    }

    public class SphereCollider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7202CC0
        public void set_center(){} // RVA: 0x7202D30
        public void get_radius(){} // RVA: 0x7202D90
        public void set_radius(){} // RVA: 0x7202DE0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_center_Injected(){} // RVA: 0x7202E40
        public void set_center_Injected(){} // RVA: 0x7202EA0
    }

    public class SpringJoint
    {
        public object localReferencePoint;
        public object size;
        public object lodCount;
        public object lastLODBillboard;
        public object fadeMode;

        // ── Methods ──
        public void get_spring(){} // RVA: 0x7204B70
        public void set_spring(){} // RVA: 0x7204BC0
        public void get_damper(){} // RVA: 0x7204C20
        public void set_damper(){} // RVA: 0x7204C70
        public void get_minDistance(){} // RVA: 0x7204CD0
        public void set_minDistance(){} // RVA: 0x7204D20
        public void get_maxDistance(){} // RVA: 0x7204D80
        public void set_maxDistance(){} // RVA: 0x7204DD0
        public void get_tolerance(){} // RVA: 0x7204E30
        public void set_tolerance(){} // RVA: 0x7204E80
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Sprite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x713FDC0
        public void GetPackingMode(){} // RVA: 0x713FE10
        public void GetPackingRotation(){} // RVA: 0x713FE60
        public void GetPacked(){} // RVA: 0x713FEB0
        public void GetTextureRect(){} // RVA: 0x713FF00
        public void GetTextureRectOffset(){} // RVA: 0x713FF70
        public void GetInnerUVs(){} // RVA: 0x713FFD0
        public void GetOuterUVs(){} // RVA: 0x7140040
        public void GetPadding(){} // RVA: 0x71400B0
        public void CreateSprite(){} // RVA: 0x7140120
        public void get_bounds(){} // RVA: 0x71401E0
        public void get_rect(){} // RVA: 0x7140250
        public void get_border(){} // RVA: 0x71402C0
        public void get_texture(){} // RVA: 0x7140330
        public void GetSecondaryTextureCount(){} // RVA: 0x7140380
        public void GetSecondaryTextures(){} // RVA: 0x71403D0
        public void get_pixelsPerUnit(){} // RVA: 0x7140430
        public void get_spriteAtlasTextureScale(){} // RVA: 0x7140480
        public void get_associatedAlphaSplitTexture(){} // RVA: 0x71404D0
        public void get_pivot(){} // RVA: 0x7140520
        public void get_packed(){} // RVA: 0x7140580
        public void get_packingMode(){} // RVA: 0x713FE10
        public void get_packingRotation(){} // RVA: 0x713FE60
        public void get_textureRect(){} // RVA: 0x71405E0
        public void get_textureRectOffset(){} // RVA: 0x713FF70
        public void get_vertices(){} // RVA: 0x7140660
        public void get_triangles(){} // RVA: 0x71406B0
        public void get_uv(){} // RVA: 0x7140700
        public void GetPhysicsShapeCount(){} // RVA: 0x7140750
        public void GetPhysicsShapePointCount(){} // RVA: 0x71407A0
        public void Internal_GetPhysicsShapePointCount(){} // RVA: 0x7140910
        public void GetPhysicsShape(){} // RVA: 0x7140970
        public void GetPhysicsShapeImpl(){} // RVA: 0x7140B20
        public void OverridePhysicsShape(){} // RVA: 0x7140FD0 | overloaded x2
        public void OverridePhysicsShapeCount(){} // RVA: 0x7140F70
        public void OverrideGeometry(){} // RVA: 0x7141040
        public void Create(){} // RVA: 0x7141920 | overloaded x7
        public void GetTextureRect_Injected(){} // RVA: 0x7141960
        public void GetTextureRectOffset_Injected(){} // RVA: 0x71419C0
        public void GetInnerUVs_Injected(){} // RVA: 0x7141A20
        public void GetOuterUVs_Injected(){} // RVA: 0x7141A80
        public void GetPadding_Injected(){} // RVA: 0x7141AE0
        public void CreateSprite_Injected(){} // RVA: 0x7141B40
        public void get_bounds_Injected(){} // RVA: 0x7141BD0
        public void get_rect_Injected(){} // RVA: 0x7141C30
        public void get_border_Injected(){} // RVA: 0x7141C90
        public void get_pivot_Injected(){} // RVA: 0x7141CF0
    }

    public class SpriteMask
    {
        // ── Methods ──
        public void get_frontSortingLayerID(){} // RVA: 0x7259240
        public void set_frontSortingLayerID(){} // RVA: 0x7259290
        public void get_frontSortingOrder(){} // RVA: 0x72592F0
        public void set_frontSortingOrder(){} // RVA: 0x7259340
        public void get_backSortingLayerID(){} // RVA: 0x72593A0
        public void set_backSortingLayerID(){} // RVA: 0x72593F0
        public void get_backSortingOrder(){} // RVA: 0x7259450
        public void set_backSortingOrder(){} // RVA: 0x72594A0
        public void get_alphaCutoff(){} // RVA: 0x7259500
        public void set_alphaCutoff(){} // RVA: 0x7259550
        public void get_sprite(){} // RVA: 0x72595B0
        public void set_sprite(){} // RVA: 0x7259600
        public void get_isCustomRangeActive(){} // RVA: 0x7259660
        public void set_isCustomRangeActive(){} // RVA: 0x72596B0
        public void get_spriteSortPoint(){} // RVA: 0x7259710
        public void set_spriteSortPoint(){} // RVA: 0x7259760
        public void GetSpriteBounds(){} // RVA: 0x72597C0
        public void .ctor(){} // RVA: 0x2DDD50
        public void GetSpriteBounds_Injected(){} // RVA: 0x7259830
    }

    public class SpriteRenderer
    {
        public UnityEngine.Events.UnityEvent`1<UnityEngine.SpriteRenderer> m_SpriteChangeEvent; // 0x18

        // ── Methods ──
        public void RegisterSpriteChangeCallback(){} // RVA: 0x713EF20
        public void UnregisterSpriteChangeCallback(){} // RVA: 0x713F090
        public void InvokeSpriteChanged(){} // RVA: 0x713F120
        public void get_shouldSupportTiling(){} // RVA: 0x713F1B0
        public void get_sprite(){} // RVA: 0x713F200
        public void set_sprite(){} // RVA: 0x713F250
        public void get_drawMode(){} // RVA: 0x713F2B0
        public void set_drawMode(){} // RVA: 0x713F300
        public void get_size(){} // RVA: 0x713F360
        public void set_size(){} // RVA: 0x713F3C0
        public void get_adaptiveModeThreshold(){} // RVA: 0x713F420
        public void set_adaptiveModeThreshold(){} // RVA: 0x713F470
        public void get_tileMode(){} // RVA: 0x713F4D0
        public void set_tileMode(){} // RVA: 0x713F520
        public void get_color(){} // RVA: 0x713F580
        public void set_color(){} // RVA: 0x713F5F0
        public void get_maskInteraction(){} // RVA: 0x713F650
        public void set_maskInteraction(){} // RVA: 0x713F6A0
        public void get_flipX(){} // RVA: 0x713F700
        public void set_flipX(){} // RVA: 0x713F750
        public void get_flipY(){} // RVA: 0x713F7B0
        public void set_flipY(){} // RVA: 0x713F800
        public void get_spriteSortPoint(){} // RVA: 0x713F860
        public void set_spriteSortPoint(){} // RVA: 0x713F8B0
        public void GetCurrentMeshDataPtr(){} // RVA: 0x713F910
        public void GetCurrentMeshData(){} // RVA: 0x713F960
        public void Internal_GetSpriteBounds(){} // RVA: 0x713FA10
        public void GetSecondaryTextureProperties(){} // RVA: 0x713FA90
        public void GetSpriteBounds(){} // RVA: 0x713FAF0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_size_Injected(){} // RVA: 0x713FBD0
        public void set_size_Injected(){} // RVA: 0x713FC30
        public void get_color_Injected(){} // RVA: 0x713FC90
        public void set_color_Injected(){} // RVA: 0x713FCF0
        public void Internal_GetSpriteBounds_Injected(){} // RVA: 0x713FD50
    }

    public class StackTraceUtility
    {
        // ── Methods ──
        public void SetProjectFolder(){} // RVA: 0x712AF00
        public void ExtractStackTrace(){} // RVA: 0x712B0C0
        public void ExtractStringFromExceptionInternal(){} // RVA: 0x712B240
        public void ExtractFormattedStackTrace(){} // RVA: 0x712B700
        public void .cctor(){} // RVA: 0x712C0C0
    }

    public class StateMachineBehaviour
    {
        // ── Methods ──
        public void OnStateEnter(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateUpdate(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateExit(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateMove(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateIK(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateMachineEnter(){} // RVA: 0x2DD310 | overloaded x2
        public void OnStateMachineExit(){} // RVA: 0x2DD310 | overloaded x2
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class Subsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void Destroy(){} // RVA: 0x7259DD0
        public void OnDestroy(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubsystemBindings
    {
        // ── Methods ──
        public void DestroySubsystem(){} // RVA: 0x7259C90
    }

    public class SubsystemDescriptor
    {
        public string <id>k__BackingField; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x2F8380
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x671BFB0
        public void CreateImpl(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubsystemDescriptorBindings
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7259D30
        public void GetId(){} // RVA: 0x7259D80
    }

    public class SubsystemManager
    {
        // ── Methods ──
        public void ReloadSubsystemsStarted(){} // RVA: 0x7259F60
        public void ReloadSubsystemsCompleted(){} // RVA: 0x725A050
        public void InitializeIntegratedSubsystem(){} // RVA: 0x725A140
        public void ClearSubsystems(){} // RVA: 0x725A270
        public void StaticConstructScriptingClassMap(){} // RVA: 0x725A4F0
        public void .cctor(){} // RVA: 0x725A540
        public void GetSubsystemDescriptors(){} // RVA: 0x24AE0
        public void GetSubsystems(){} // RVA: 0x24AE0
        public void AddSubsystemSubset(){} // RVA: 0x24D50
        public void GetIntegratedSubsystemByPtr(){} // RVA: 0x725A7E0
        public void RemoveIntegratedSubsystemByPtr(){} // RVA: 0x725A960
        public void RemoveStandaloneSubsystem(){} // RVA: 0x725AAF0
        public void RemoveDeprecatedSubsystem(){} // RVA: 0x725AB80
    }

    public class SurfaceEffector2D
    {
        // ── Methods ──
        public void get_speed(){} // RVA: 0x71EF180
        public void set_speed(){} // RVA: 0x71EF1D0
        public void get_speedVariation(){} // RVA: 0x71EF230
        public void set_speedVariation(){} // RVA: 0x71EF280
        public void get_forceScale(){} // RVA: 0x71EF2E0
        public void set_forceScale(){} // RVA: 0x71EF330
        public void get_useContactForce(){} // RVA: 0x71EF390
        public void set_useContactForce(){} // RVA: 0x71EF3E0
        public void get_useFriction(){} // RVA: 0x71EF440
        public void set_useFriction(){} // RVA: 0x71EF490
        public void get_useBounce(){} // RVA: 0x71EF4F0
        public void set_useBounce(){} // RVA: 0x71EF540
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SystemClock
    {
        public System.DateTime time;

        // ── Methods ──
        public void get_now(){} // RVA: 0x7133350
        public void .cctor(){} // RVA: 0x71333A0
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
        public void get_batteryLevel(){} // RVA: 0x71321B0
        public void get_batteryStatus(){} // RVA: 0x7132200
        public void get_operatingSystem(){} // RVA: 0x637E8D0
        public void get_operatingSystemFamily(){} // RVA: 0x7132250
        public void get_processorType(){} // RVA: 0x637EBC0
        public void get_processorFrequency(){} // RVA: 0x71322A0
        public void get_processorCount(){} // RVA: 0x71322F0
        public void get_systemMemorySize(){} // RVA: 0x7132340
        public void get_deviceUniqueIdentifier(){} // RVA: 0x6380700
        public void get_deviceName(){} // RVA: 0x7132390
        public void get_deviceModel(){} // RVA: 0x6380750
        public void get_supportsVibration(){} // RVA: 0x71323E0
        public void get_supportsAudio(){} // RVA: 0x7132430
        public void get_deviceType(){} // RVA: 0x7132480
        public void get_graphicsMemorySize(){} // RVA: 0x71324D0
        public void get_graphicsDeviceName(){} // RVA: 0x637F2B0
        public void get_graphicsDeviceVendor(){} // RVA: 0x637F4A0
        public void get_graphicsDeviceID(){} // RVA: 0x7132520
        public void get_graphicsDeviceVendorID(){} // RVA: 0x7132570
        public void get_graphicsDeviceType(){} // RVA: 0x71325C0
        public void get_graphicsUVStartsAtTop(){} // RVA: 0x7132610
        public void get_graphicsDeviceVersion(){} // RVA: 0x637F790
        public void get_graphicsShaderLevel(){} // RVA: 0x7132660
        public void get_graphicsMultiThreaded(){} // RVA: 0x6380880
        public void get_renderingThreadingMode(){} // RVA: 0x71326B0
        public void get_supportsMotionVectors(){} // RVA: 0x7132700
        public void get_supports3DRenderTextures(){} // RVA: 0x7132750
        public void get_copyTextureSupport(){} // RVA: 0x71327A0
        public void get_supportsComputeShaders(){} // RVA: 0x71327F0
        public void get_supportsGeometryShaders(){} // RVA: 0x7132840
        public void get_supportsInstancing(){} // RVA: 0x7132890
        public void get_supportedRenderTargetCount(){} // RVA: 0x71328E0
        public void get_supportedRandomWriteTargetCount(){} // RVA: 0x7132930
        public void get_usesReversedZBuffer(){} // RVA: 0x7132980
        public void IsValidEnumValue(){} // RVA: 0x71329D0
        public void SupportsRenderTextureFormat(){} // RVA: 0x7132AE0
        public void SupportsTextureFormat(){} // RVA: 0x7132BC0
        public void get_npotSupport(){} // RVA: 0x7132CA0
        public void get_maxTextureSize(){} // RVA: 0x7132CF0
        public void get_maxCubemapSize(){} // RVA: 0x7132D40
        public void get_maxRenderTextureSize(){} // RVA: 0x7132D90
        public void get_maxComputeBufferInputsVertex(){} // RVA: 0x7132DE0
        public void get_maxComputeBufferInputsCompute(){} // RVA: 0x7132E30
        public void get_maxComputeWorkGroupSize(){} // RVA: 0x7132E80
        public void get_maxComputeWorkGroupSizeX(){} // RVA: 0x7132ED0
        public void get_maxComputeWorkGroupSizeY(){} // RVA: 0x7132F20
        public void get_maxComputeWorkGroupSizeZ(){} // RVA: 0x7132F70
        public void get_supportsGraphicsFence(){} // RVA: 0x7132FC0
        public void get_supportsAsyncGPUReadback(){} // RVA: 0x7133010
        public void get_supportsRayTracing(){} // RVA: 0x7133060
        public void get_maxGraphicsBufferSize(){} // RVA: 0x71330B0
        public void get_usesLoadStoreActions(){} // RVA: 0x7133100
        public void get_supportsIndirectArgumentsBuffer(){} // RVA: 0x7133150
        public void GetBatteryLevel(){} // RVA: 0x71321B0
        public void GetBatteryStatus(){} // RVA: 0x7132200
        public void GetOperatingSystem(){} // RVA: 0x637E8D0
        public void GetOperatingSystemFamily(){} // RVA: 0x7132250
        public void GetProcessorType(){} // RVA: 0x637EBC0
        public void GetProcessorFrequencyMHz(){} // RVA: 0x71322A0
        public void GetProcessorCount(){} // RVA: 0x71322F0
        public void GetPhysicalMemoryMB(){} // RVA: 0x7132340
        public void GetDeviceUniqueIdentifier(){} // RVA: 0x6380700
        public void GetDeviceName(){} // RVA: 0x7132390
        public void GetDeviceModel(){} // RVA: 0x6380750
        public void SupportsVibration(){} // RVA: 0x71323E0
        public void SupportsAudio(){} // RVA: 0x7132430
        public void GetDeviceType(){} // RVA: 0x7132480
        public void GetGraphicsMemorySize(){} // RVA: 0x71324D0
        public void GetGraphicsDeviceName(){} // RVA: 0x637F2B0
        public void GetGraphicsDeviceVendor(){} // RVA: 0x637F4A0
        public void GetGraphicsDeviceID(){} // RVA: 0x7132520
        public void GetGraphicsDeviceVendorID(){} // RVA: 0x7132570
        public void GetGraphicsDeviceType(){} // RVA: 0x71325C0
        public void GetGraphicsUVStartsAtTop(){} // RVA: 0x7132610
        public void GetGraphicsDeviceVersion(){} // RVA: 0x637F790
        public void GetGraphicsShaderLevel(){} // RVA: 0x7132660
        public void GetGraphicsMultiThreaded(){} // RVA: 0x6380880
        public void GetRenderingThreadingMode(){} // RVA: 0x71326B0
        public void SupportsMotionVectors(){} // RVA: 0x7132700
        public void Supports3DRenderTextures(){} // RVA: 0x7132750
        public void GetCopyTextureSupport(){} // RVA: 0x71327A0
        public void SupportsComputeShaders(){} // RVA: 0x71327F0
        public void SupportsGeometryShaders(){} // RVA: 0x7132840
        public void SupportsInstancing(){} // RVA: 0x7132890
        public void SupportedRenderTargetCount(){} // RVA: 0x71328E0
        public void SupportedRandomWriteTargetCount(){} // RVA: 0x7132930
        public void MaxComputeBufferInputsVertex(){} // RVA: 0x7132DE0
        public void MaxComputeBufferInputsCompute(){} // RVA: 0x7132E30
        public void UsesReversedZBuffer(){} // RVA: 0x7132980
        public void HasRenderTextureNative(){} // RVA: 0x71331A0
        public void SupportsTextureFormatNative(){} // RVA: 0x71331F0
        public void GetNPOTSupport(){} // RVA: 0x7132CA0
        public void GetMaxTextureSize(){} // RVA: 0x7132CF0
        public void GetMaxCubemapSize(){} // RVA: 0x7132D40
        public void GetMaxRenderTextureSize(){} // RVA: 0x7132D90
        public void GetMaxComputeWorkGroupSize(){} // RVA: 0x7132E80
        public void GetMaxComputeWorkGroupSizeX(){} // RVA: 0x7132ED0
        public void GetMaxComputeWorkGroupSizeY(){} // RVA: 0x7132F20
        public void GetMaxComputeWorkGroupSizeZ(){} // RVA: 0x7132F70
        public void SupportsGPUFence(){} // RVA: 0x7132FC0
        public void SupportsAsyncGPUReadback(){} // RVA: 0x7133010
        public void SupportsRayTracing(){} // RVA: 0x7133060
        public void MaxGraphicsBufferSize(){} // RVA: 0x71330B0
        public void IsFormatSupported(){} // RVA: 0x7133240
        public void GetCompatibleFormat(){} // RVA: 0x71332A0
        public void GetGraphicsFormat(){} // RVA: 0x7133300
        public void UsesLoadStoreActions(){} // RVA: 0x7133100
        public void SupportsIndirectArgumentsBuffer(){} // RVA: 0x7133150
    }

}