// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 24
// Methods: 281

namespace ThirdParty.Unity.UnityEngine
{
    public class ScriptableObject : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2e5200
        public void CreateInstance(){} // RVA: 0x7ffaa887e5c0
        public void CreateInstance(){} // RVA: 0x7ffaa887e5c0
        public void CreateScriptableObject(){} // RVA: 0x7ffaaf2e52f0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7ffaaf2e5340
    }

    public class ScriptingUtility : Object
    {
        // ── Original Methods ──
        public void IsManagedCodeWorking(){} // RVA: 0x7ffaaa5f9770
    }

    public class ScrollViewState : Object
    {
        public object viewRect; // 0x32E70030
        public object isDuringTouchScroll; // 0x32E70030
        public object velocity; // 0x32E70030
        public object p00; // 0x32E65F08

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SelectionBaseAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SendMouseEvents : Object
    {
        public object m_MouseDownHit; // 0x32D10AD0
        public object s_GetMouseState; // 0x32D10AD0
        public object s_MouseButtonIsPressed; // 0x32D10AD0
        public object 00; // 0x32CE8420

        // ── Original Methods ──
        public void UpdateMouse(){} // RVA: 0x7ffaaf362bb0
        public void SendEvents(){} // RVA: 0x7ffaaf363c50
        public void .cctor(){} // RVA: 0x7ffaaf364340
        // ── Binary Analysis Named ──
        public void SetMouseMoved(){} // RVA: 0x7ffaaf362eb0
        public void DoSendMouseEvents(){} // RVA: 0x7ffaaf362f10
    }

    public class SerializeField : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SerializeReference : Attribute
    {
    }

    public class SetupCoroutine : Object
    {
        // ── Original Methods ──
        public void InvokeMoveNext(){} // RVA: 0x7ffaaf2dea50
        public void InvokeMember(){} // RVA: 0x7ffaaf2deb10
    }

    public class Shader : Object
    {
        // ── Original Methods ──
        public void Find(){} // RVA: 0x7ffaaf2a1de0
        public void get_maximumChunksOverride(){} // RVA: 0x7ffaaf2a1e50
        public void set_maximumChunksOverride(){} // RVA: 0x7ffaaf2a1ea0
        public void set_maximumLOD(){} // RVA: 0x7ffaaf2a1ef0
        public void get_isSupported(){} // RVA: 0x7ffaaf2a1f50
        public void EnableKeyword(){} // RVA: 0x7ffaaf2a1fa0
        public void DisableKeyword(){} // RVA: 0x7ffaaf2a1ff0
        public void get_renderQueue(){} // RVA: 0x7ffaaf2a2040
        public void WarmupAllShaders(){} // RVA: 0x7ffaaf2a2090
        public void TagToID(){} // RVA: 0x7ffaaf2a20e0
        public void PropertyToID(){} // RVA: 0x7ffaaf2a2130
        public void .ctor(){} // RVA: 0x7ffaaf2a2f00
        // ── Binary Analysis Named ──
        public void SetGlobalIntImpl(){} // RVA: 0x7ffaaf2a2180
        public void SetGlobalFloatImpl(){} // RVA: 0x7ffaaf2a21e0
        public void SetGlobalVectorImpl(){} // RVA: 0x7ffaaf2a2240
        public void SetGlobalMatrixImpl(){} // RVA: 0x7ffaaf2a22a0
        public void SetGlobalTextureImpl(){} // RVA: 0x7ffaaf2a2300
        public void SetGlobalFloatArrayImpl(){} // RVA: 0x7ffaaf2a2360
        public void SetGlobalVectorArrayImpl(){} // RVA: 0x7ffaaf2a23d0
        public void SetGlobalMatrixArrayImpl(){} // RVA: 0x7ffaaf2a2440
        public void SetGlobalFloatArray(){} // RVA: 0x7ffaaf2a2dc0
        public void SetGlobalVectorArray(){} // RVA: 0x7ffaaf2a2e50
        public void SetGlobalMatrixArray(){} // RVA: 0x7ffaaf2a2ee0
        public void SetGlobalInt(){} // RVA: 0x7ffaaf2a2980
        public void SetGlobalInt(){} // RVA: 0x7ffaaf2a2980
        public void SetGlobalFloat(){} // RVA: 0x7ffaaf2a21e0
        public void SetGlobalFloat(){} // RVA: 0x7ffaaf2a21e0
        public void SetGlobalInteger(){} // RVA: 0x7ffaaf2a2180
        public void SetGlobalVector(){} // RVA: 0x7ffaaf2a2b30
        public void SetGlobalVector(){} // RVA: 0x7ffaaf2a2b30
        public void SetGlobalColor(){} // RVA: 0x7ffaaf2a2b90
        public void SetGlobalMatrix(){} // RVA: 0x7ffaaf2a2c30
        public void SetGlobalTexture(){} // RVA: 0x7ffaaf2a2300
        public void SetGlobalTexture(){} // RVA: 0x7ffaaf2a2300
        public void SetGlobalFloatArray(){} // RVA: 0x7ffaaf2a2dc0
        public void SetGlobalFloatArray(){} // RVA: 0x7ffaaf2a2dc0
        public void SetGlobalVectorArray(){} // RVA: 0x7ffaaf2a2e50
        public void SetGlobalVectorArray(){} // RVA: 0x7ffaaf2a2e50
        public void SetGlobalMatrixArray(){} // RVA: 0x7ffaaf2a2ee0
        public void SetGlobalMatrixArray(){} // RVA: 0x7ffaaf2a2ee0
        public void SetGlobalVectorImpl_Injected(){} // RVA: 0x7ffaaf2a2f50
        public void SetGlobalMatrixImpl_Injected(){} // RVA: 0x7ffaaf2a2fb0
    }

    public class SharedBetweenAnimatorsAttribute : Attribute
    {
    }

    public class SkeletonBone : ValueType
    {
        public object position; // 0x32EE2F30
    }

    public class SkinnedMeshRenderer : Renderer
    {
        // ── Original Methods ──
        public void get_quality(){} // RVA: 0x7ffaaf2ade20
        public void set_quality(){} // RVA: 0x7ffaaf2ade70
        public void get_updateWhenOffscreen(){} // RVA: 0x7ffaaf2aded0
        public void set_updateWhenOffscreen(){} // RVA: 0x7ffaaf2adf20
        public void get_forceMatrixRecalculationPerRender(){} // RVA: 0x7ffaaf2adf80
        public void set_forceMatrixRecalculationPerRender(){} // RVA: 0x7ffaaf2adfd0
        public void get_rootBone(){} // RVA: 0x7ffaaf2ae030
        public void set_rootBone(){} // RVA: 0x7ffaaf2ae080
        public void get_bones(){} // RVA: 0x7ffaaf2ae0e0
        public void set_bones(){} // RVA: 0x7ffaaf2ae130
        public void get_sharedMesh(){} // RVA: 0x7ffaaf2ae190
        public void set_sharedMesh(){} // RVA: 0x7ffaaf2ae1e0
        public void get_skinnedMotionVectors(){} // RVA: 0x7ffaaf2ae240
        public void set_skinnedMotionVectors(){} // RVA: 0x7ffaaf2ae290
        public void BakeMesh(){} // RVA: 0x7ffaaf2ae430
        public void BakeMesh(){} // RVA: 0x7ffaaf2ae430
        public void get_vertexBufferTarget(){} // RVA: 0x7ffaaf2ae7c0
        public void set_vertexBufferTarget(){} // RVA: 0x7ffaaf2ae810
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetBlendShapeWeight(){} // RVA: 0x7ffaaf2ae2f0
        public void SetBlendShapeWeight(){} // RVA: 0x7ffaaf2ae350
        public void GetVertexBuffer(){} // RVA: 0x7ffaaf2ae4a0
        public void GetPreviousVertexBuffer(){} // RVA: 0x7ffaaf2ae5e0
        public void GetVertexBufferImpl(){} // RVA: 0x7ffaaf2ae720
        public void GetPreviousVertexBufferImpl(){} // RVA: 0x7ffaaf2ae770
    }

    public class Skybox : Behaviour
    {
        // ── Original Methods ──
        public void get_material(){} // RVA: 0x7ffaaf2ad030
        public void set_material(){} // RVA: 0x7ffaaf2ad080
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SliderJoint2D : AnchoredJoint2D
    {
        // ── Original Methods ──
        public void get_autoConfigureAngle(){} // RVA: 0x7ffaaf3a6530
        public void set_autoConfigureAngle(){} // RVA: 0x7ffaaf3a6580
        public void get_angle(){} // RVA: 0x7ffaaf3a65e0
        public void set_angle(){} // RVA: 0x7ffaaf3a6630
        public void get_useMotor(){} // RVA: 0x7ffaaf3a6690
        public void set_useMotor(){} // RVA: 0x7ffaaf3a66e0
        public void get_useLimits(){} // RVA: 0x7ffaaf3a6740
        public void set_useLimits(){} // RVA: 0x7ffaaf3a6790
        public void get_motor(){} // RVA: 0x7ffaaf3a67f0
        public void set_motor(){} // RVA: 0x7ffaaf3a6850
        public void get_limits(){} // RVA: 0x7ffaaf3a68b0
        public void set_limits(){} // RVA: 0x7ffaaf3a6910
        public void get_limitState(){} // RVA: 0x7ffaaf3a6970
        public void get_referenceAngle(){} // RVA: 0x7ffaaf3a69c0
        public void get_jointTranslation(){} // RVA: 0x7ffaaf3a6a10
        public void get_jointSpeed(){} // RVA: 0x7ffaaf3a6a60
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_motor_Injected(){} // RVA: 0x7ffaaf3a6b10
        public void set_motor_Injected(){} // RVA: 0x7ffaaf3a6b70
        public void get_limits_Injected(){} // RVA: 0x7ffaaf3a6bd0
        public void set_limits_Injected(){} // RVA: 0x7ffaaf3a6c30
        // ── Binary Analysis Named ──
        public void GetMotorForce(){} // RVA: 0x7ffaaf3a6ab0
    }

    public class SliderState : Object
    {
        public object isDragging; // 0x32E701B0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SphereCollider : Collider
    {
        // ── Original Methods ──
        public void get_center(){} // RVA: 0x7ffaaf3bc520
        public void set_center(){} // RVA: 0x7ffaaf3bc590
        public void get_radius(){} // RVA: 0x7ffaaf3bc5f0
        public void set_radius(){} // RVA: 0x7ffaaf3bc640
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_center_Injected(){} // RVA: 0x7ffaaf3bc6a0
        public void set_center_Injected(){} // RVA: 0x7ffaaf3bc700
    }

    public class SpringJoint : Joint
    {
        // ── Original Methods ──
        public void get_spring(){} // RVA: 0x7ffaaf3be3d0
        public void set_spring(){} // RVA: 0x7ffaaf3be420
        public void get_damper(){} // RVA: 0x7ffaaf3be480
        public void set_damper(){} // RVA: 0x7ffaaf3be4d0
        public void get_minDistance(){} // RVA: 0x7ffaaf3be530
        public void set_minDistance(){} // RVA: 0x7ffaaf3be580
        public void get_maxDistance(){} // RVA: 0x7ffaaf3be5e0
        public void set_maxDistance(){} // RVA: 0x7ffaaf3be630
        public void get_tolerance(){} // RVA: 0x7ffaaf3be690
        public void set_tolerance(){} // RVA: 0x7ffaaf3be6e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Sprite : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2fa260
        public void CreateSprite(){} // RVA: 0x7ffaaf2fa5c0
        public void get_bounds(){} // RVA: 0x7ffaaf2fa680
        public void get_rect(){} // RVA: 0x7ffaaf2fa6f0
        public void get_border(){} // RVA: 0x7ffaaf2fa760
        public void get_texture(){} // RVA: 0x7ffaaf2fa7d0
        public void get_pixelsPerUnit(){} // RVA: 0x7ffaaf2fa8d0
        public void get_spriteAtlasTextureScale(){} // RVA: 0x7ffaaf2fa920
        public void get_associatedAlphaSplitTexture(){} // RVA: 0x7ffaaf2fa970
        public void get_pivot(){} // RVA: 0x7ffaaf2fa9c0
        public void get_packed(){} // RVA: 0x7ffaaf2faa20
        public void get_packingMode(){} // RVA: 0x7ffaaf2fa2b0
        public void get_packingRotation(){} // RVA: 0x7ffaaf2fa300
        public void get_textureRect(){} // RVA: 0x7ffaaf2faa80
        public void get_textureRectOffset(){} // RVA: 0x7ffaaf2fa410
        public void get_vertices(){} // RVA: 0x7ffaaf2fab00
        public void get_triangles(){} // RVA: 0x7ffaaf2fab50
        public void get_uv(){} // RVA: 0x7ffaaf2faba0
        public void Internal_GetPhysicsShapePointCount(){} // RVA: 0x7ffaaf2fadb0
        public void OverridePhysicsShape(){} // RVA: 0x7ffaaf2fb470
        public void OverridePhysicsShapeCount(){} // RVA: 0x7ffaaf2fb410
        public void OverridePhysicsShape(){} // RVA: 0x7ffaaf2fb470
        public void OverrideGeometry(){} // RVA: 0x7ffaaf2fb4e0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void Create(){} // RVA: 0x7ffaaf2fbdc0
        public void CreateSprite_Injected(){} // RVA: 0x7ffaaf2fbfe0
        public void get_bounds_Injected(){} // RVA: 0x7ffaaf2fc070
        public void get_rect_Injected(){} // RVA: 0x7ffaaf2fc0d0
        public void get_border_Injected(){} // RVA: 0x7ffaaf2fc130
        public void get_pivot_Injected(){} // RVA: 0x7ffaaf2fc190
        // ── Binary Analysis Named ──
        public void GetPackingMode(){} // RVA: 0x7ffaaf2fa2b0
        public void GetPackingRotation(){} // RVA: 0x7ffaaf2fa300
        public void GetPacked(){} // RVA: 0x7ffaaf2fa350
        public void GetTextureRect(){} // RVA: 0x7ffaaf2fa3a0
        public void GetTextureRectOffset(){} // RVA: 0x7ffaaf2fa410
        public void GetInnerUVs(){} // RVA: 0x7ffaaf2fa470
        public void GetOuterUVs(){} // RVA: 0x7ffaaf2fa4e0
        public void GetPadding(){} // RVA: 0x7ffaaf2fa550
        public void GetSecondaryTextureCount(){} // RVA: 0x7ffaaf2fa820
        public void GetSecondaryTextures(){} // RVA: 0x7ffaaf2fa870
        public void GetPhysicsShapeCount(){} // RVA: 0x7ffaaf2fabf0
        public void GetPhysicsShapePointCount(){} // RVA: 0x7ffaaf2fac40
        public void GetPhysicsShape(){} // RVA: 0x7ffaaf2fae10
        public void GetPhysicsShapeImpl(){} // RVA: 0x7ffaaf2fafc0
        public void GetTextureRect_Injected(){} // RVA: 0x7ffaaf2fbe00
        public void GetTextureRectOffset_Injected(){} // RVA: 0x7ffaaf2fbe60
        public void GetInnerUVs_Injected(){} // RVA: 0x7ffaaf2fbec0
        public void GetOuterUVs_Injected(){} // RVA: 0x7ffaaf2fbf20
        public void GetPadding_Injected(){} // RVA: 0x7ffaaf2fbf80
    }

    public class SpriteMask : Renderer
    {
        // ── Original Methods ──
        public void get_frontSortingLayerID(){} // RVA: 0x7ffaaf412aa0
        public void set_frontSortingLayerID(){} // RVA: 0x7ffaaf412af0
        public void get_frontSortingOrder(){} // RVA: 0x7ffaaf412b50
        public void set_frontSortingOrder(){} // RVA: 0x7ffaaf412ba0
        public void get_backSortingLayerID(){} // RVA: 0x7ffaaf412c00
        public void set_backSortingLayerID(){} // RVA: 0x7ffaaf412c50
        public void get_backSortingOrder(){} // RVA: 0x7ffaaf412cb0
        public void set_backSortingOrder(){} // RVA: 0x7ffaaf412d00
        public void get_alphaCutoff(){} // RVA: 0x7ffaaf412d60
        public void set_alphaCutoff(){} // RVA: 0x7ffaaf412db0
        public void get_sprite(){} // RVA: 0x7ffaaf412e10
        public void set_sprite(){} // RVA: 0x7ffaaf412e60
        public void get_isCustomRangeActive(){} // RVA: 0x7ffaaf412ec0
        public void set_isCustomRangeActive(){} // RVA: 0x7ffaaf412f10
        public void get_spriteSortPoint(){} // RVA: 0x7ffaaf412f70
        public void set_spriteSortPoint(){} // RVA: 0x7ffaaf412fc0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetSpriteBounds(){} // RVA: 0x7ffaaf413020
        public void GetSpriteBounds_Injected(){} // RVA: 0x7ffaaf413090
    }

    public class SpriteRenderer : Renderer
    {
        // ── Original Methods ──
        public void RegisterSpriteChangeCallback(){} // RVA: 0x7ffaaf2f93c0
        public void UnregisterSpriteChangeCallback(){} // RVA: 0x7ffaaf2f9530
        public void InvokeSpriteChanged(){} // RVA: 0x7ffaaf2f95c0
        public void get_shouldSupportTiling(){} // RVA: 0x7ffaaf2f9650
        public void get_sprite(){} // RVA: 0x7ffaaf2f96a0
        public void set_sprite(){} // RVA: 0x7ffaaf2f96f0
        public void get_drawMode(){} // RVA: 0x7ffaaf2f9750
        public void set_drawMode(){} // RVA: 0x7ffaaf2f97a0
        public void get_size(){} // RVA: 0x7ffaaf2f9800
        public void set_size(){} // RVA: 0x7ffaaf2f9860
        public void get_adaptiveModeThreshold(){} // RVA: 0x7ffaaf2f98c0
        public void set_adaptiveModeThreshold(){} // RVA: 0x7ffaaf2f9910
        public void get_tileMode(){} // RVA: 0x7ffaaf2f9970
        public void set_tileMode(){} // RVA: 0x7ffaaf2f99c0
        public void get_color(){} // RVA: 0x7ffaaf2f9a20
        public void set_color(){} // RVA: 0x7ffaaf2f9a90
        public void get_maskInteraction(){} // RVA: 0x7ffaaf2f9af0
        public void set_maskInteraction(){} // RVA: 0x7ffaaf2f9b40
        public void get_flipX(){} // RVA: 0x7ffaaf2f9ba0
        public void set_flipX(){} // RVA: 0x7ffaaf2f9bf0
        public void get_flipY(){} // RVA: 0x7ffaaf2f9c50
        public void set_flipY(){} // RVA: 0x7ffaaf2f9ca0
        public void get_spriteSortPoint(){} // RVA: 0x7ffaaf2f9d00
        public void set_spriteSortPoint(){} // RVA: 0x7ffaaf2f9d50
        public void Internal_GetSpriteBounds(){} // RVA: 0x7ffaaf2f9eb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_size_Injected(){} // RVA: 0x7ffaaf2fa070
        public void set_size_Injected(){} // RVA: 0x7ffaaf2fa0d0
        public void get_color_Injected(){} // RVA: 0x7ffaaf2fa130
        public void set_color_Injected(){} // RVA: 0x7ffaaf2fa190
        public void Internal_GetSpriteBounds_Injected(){} // RVA: 0x7ffaaf2fa1f0
        // ── Binary Analysis Named ──
        public void GetCurrentMeshDataPtr(){} // RVA: 0x7ffaaf2f9db0
        public void GetCurrentMeshData(){} // RVA: 0x7ffaaf2f9e00
        public void GetSecondaryTextureProperties(){} // RVA: 0x7ffaaf2f9f30
        public void GetSpriteBounds(){} // RVA: 0x7ffaaf2f9f90
    }

    public class StackTraceUtility : Object
    {
        // ── Original Methods ──
        public void ExtractStackTrace(){} // RVA: 0x7ffaaf2e55b0
        public void ExtractStringFromExceptionInternal(){} // RVA: 0x7ffaaf2e5730
        public void ExtractFormattedStackTrace(){} // RVA: 0x7ffaaf2e5bf0
        public void .cctor(){} // RVA: 0x7ffaaf2e65b0
        // ── Binary Analysis Named ──
        public void SetProjectFolder(){} // RVA: 0x7ffaaf2e53f0
    }

    public class StateMachineBehaviour : ScriptableObject
    {
        // ── Original Methods ──
        public void OnStateEnter(){} // RVA: 0x7ffaa8932310
        public void OnStateUpdate(){} // RVA: 0x7ffaa8932310
        public void OnStateExit(){} // RVA: 0x7ffaa8932310
        public void OnStateMove(){} // RVA: 0x7ffaa8932310
        public void OnStateIK(){} // RVA: 0x7ffaa8932310
        public void OnStateMachineEnter(){} // RVA: 0x7ffaa8932310
        public void OnStateMachineExit(){} // RVA: 0x7ffaa8932310
        public void OnStateEnter(){} // RVA: 0x7ffaa8932310
        public void OnStateUpdate(){} // RVA: 0x7ffaa8932310
        public void OnStateExit(){} // RVA: 0x7ffaa8932310
        public void OnStateMove(){} // RVA: 0x7ffaa8932310
        public void OnStateIK(){} // RVA: 0x7ffaa8932310
        public void OnStateMachineEnter(){} // RVA: 0x7ffaa8932310
        public void OnStateMachineExit(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SubsystemManager : Object
    {
        public object s_IntegratedSubsystems; // 0x318AB630
        public object reloadSubsytemsStarted; // 0x318AB630

        // ── Original Methods ──
        public void ReloadSubsystemsStarted(){} // RVA: 0x7ffaaf4137c0
        public void ReloadSubsystemsCompleted(){} // RVA: 0x7ffaaf4138b0
        public void InitializeIntegratedSubsystem(){} // RVA: 0x7ffaaf4139a0
        public void ClearSubsystems(){} // RVA: 0x7ffaaf413ad0
        public void StaticConstructScriptingClassMap(){} // RVA: 0x7ffaaf413d50
        public void .cctor(){} // RVA: 0x7ffaaf413da0
        public void AddSubsystemSubset(){} // RVA: 0x7ffaa8660fc0
        public void RemoveIntegratedSubsystemByPtr(){} // RVA: 0x7ffaaf4141c0
        public void RemoveStandaloneSubsystem(){} // RVA: 0x7ffaaf414350
        public void RemoveDeprecatedSubsystem(){} // RVA: 0x7ffaaf4143e0
        // ── Binary Analysis Named ──
        public void GetSubsystemDescriptors(){} // RVA: 0x7ffaa8660d50
        public void GetSubsystems(){} // RVA: 0x7ffaa8660d50
        public void GetIntegratedSubsystemByPtr(){} // RVA: 0x7ffaaf414040
    }

    public class SurfaceEffector2D : Effector2D
    {
        // ── Original Methods ──
        public void get_speed(){} // RVA: 0x7ffaaf3a89e0
        public void set_speed(){} // RVA: 0x7ffaaf3a8a30
        public void get_speedVariation(){} // RVA: 0x7ffaaf3a8a90
        public void set_speedVariation(){} // RVA: 0x7ffaaf3a8ae0
        public void get_forceScale(){} // RVA: 0x7ffaaf3a8b40
        public void set_forceScale(){} // RVA: 0x7ffaaf3a8b90
        public void get_useContactForce(){} // RVA: 0x7ffaaf3a8bf0
        public void set_useContactForce(){} // RVA: 0x7ffaaf3a8c40
        public void get_useFriction(){} // RVA: 0x7ffaaf3a8ca0
        public void set_useFriction(){} // RVA: 0x7ffaaf3a8cf0
        public void get_useBounce(){} // RVA: 0x7ffaaf3a8d50
        public void set_useBounce(){} // RVA: 0x7ffaaf3a8da0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}