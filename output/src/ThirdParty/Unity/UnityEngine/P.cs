// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 30
// Methods: 1086

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent : ValueType
    {
        public UnityEngine.Vector3 m_Intersection; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFE87BD9260
        public void get_colliderComponent(){} // RVA: 0x7FFE87D08BC0
        public void InstanceIDToColliderComponent(){} // RVA: 0x7FFE87D08C10
    }

    public class ParticlePhysicsExtensions : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFE87D05900
    }

    public class ParticleSystem : Component
    {
        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFE87CEF370 | overloaded x4
        public void get_startDelay(){} // RVA: 0x7FFE87CEC400
        public void set_startDelay(){} // RVA: 0x7FFE87CEC4B0
        public void get_loop(){} // RVA: 0x7FFE87CEC560
        public void set_loop(){} // RVA: 0x7FFE87CEC610
        public void get_playOnAwake(){} // RVA: 0x7FFE87CEC6C0
        public void set_playOnAwake(){} // RVA: 0x7FFE87CEC770
        public void get_duration(){} // RVA: 0x7FFE87CEC820
        public void get_playbackSpeed(){} // RVA: 0x7FFE87CEC8D0
        public void set_playbackSpeed(){} // RVA: 0x7FFE87CEC980
        public void get_enableEmission(){} // RVA: 0x7FFE87CECA30
        public void set_enableEmission(){} // RVA: 0x7FFE87CECAE0
        public void get_emissionRate(){} // RVA: 0x7FFE87CECB90
        public void set_emissionRate(){} // RVA: 0x7FFE87CECC40
        public void get_startSpeed(){} // RVA: 0x7FFE87CECD20
        public void set_startSpeed(){} // RVA: 0x7FFE87CECDD0
        public void get_startSize(){} // RVA: 0x7FFE87CECE80
        public void set_startSize(){} // RVA: 0x7FFE87CECF30
        public void get_startColor(){} // RVA: 0x7FFE87CECFE0
        public void set_startColor(){} // RVA: 0x7FFE87CED0C0
        public void get_startRotation(){} // RVA: 0x7FFE87CED1D0
        public void set_startRotation(){} // RVA: 0x7FFE87CED280
        public void get_startRotation3D(){} // RVA: 0x7FFE87CED330
        public void set_startRotation3D(){} // RVA: 0x7FFE87CED560
        public void get_startLifetime(){} // RVA: 0x7FFE87CED6A0
        public void set_startLifetime(){} // RVA: 0x7FFE87CED750
        public void get_gravityModifier(){} // RVA: 0x7FFE87CED800
        public void set_gravityModifier(){} // RVA: 0x7FFE87CED8B0
        public void get_maxParticles(){} // RVA: 0x7FFE87CED960
        public void set_maxParticles(){} // RVA: 0x7FFE87CEDA10
        public void get_simulationSpace(){} // RVA: 0x7FFE87CEDAC0
        public void set_simulationSpace(){} // RVA: 0x7FFE87CEDB70
        public void get_scalingMode(){} // RVA: 0x7FFE87CEDC20
        public void set_scalingMode(){} // RVA: 0x7FFE87CEDCD0
        public void get_automaticCullingEnabled(){} // RVA: 0x7FFE87CEDD80
        public void get_isPlaying(){} // RVA: 0x7FFE87CEDDD0
        public void get_isEmitting(){} // RVA: 0x7FFE87CEDE20
        public void get_isStopped(){} // RVA: 0x7FFE87CEDE70
        public void get_isPaused(){} // RVA: 0x7FFE87CEDEC0
        public void get_particleCount(){} // RVA: 0x7FFE87CEDF10
        public void get_time(){} // RVA: 0x7FFE87CEDF60
        public void set_time(){} // RVA: 0x7FFE87CEDFB0
        public void get_totalTime(){} // RVA: 0x7FFE87CEE010
        public void get_randomSeed(){} // RVA: 0x7FFE87CEE060
        public void set_randomSeed(){} // RVA: 0x7FFE87CEE0B0
        public void get_useAutoRandomSeed(){} // RVA: 0x7FFE87CEE110
        public void set_useAutoRandomSeed(){} // RVA: 0x7FFE87CEE160
        public void get_proceduralSimulationSupported(){} // RVA: 0x7FFE87CEDD80
        public void GetParticleCurrentSize(){} // RVA: 0x7FFE87CEE1C0
        public void GetParticleCurrentSize3D(){} // RVA: 0x7FFE87CEE220
        public void GetParticleCurrentColor(){} // RVA: 0x7FFE87CEE2A0
        public void GetParticleMeshIndex(){} // RVA: 0x7FFE87CEE310
        public void SetParticles(){} // RVA: 0x7FFE87CEE620 | overloaded x6
        public void SetParticlesWithNativeArray(){} // RVA: 0x7FFE87CEE430
        public void GetParticles(){} // RVA: 0x7FFE87CEE970 | overloaded x6
        public void GetParticlesWithNativeArray(){} // RVA: 0x7FFE87CEE780
        public void SetCustomParticleData(){} // RVA: 0x7FFE87CEEA10
        public void GetCustomParticleData(){} // RVA: 0x7FFE87CEEA80
        public void GetPlaybackState(){} // RVA: 0x7FFE87CEEAF0
        public void SetPlaybackState(){} // RVA: 0x7FFE87CEEB60
        public void GetTrailDataInternal(){} // RVA: 0x7FFE87CEEBC0
        public void GetTrails(){} // RVA: 0x7FFE87CEECD0 | overloaded x2
        public void SetTrails(){} // RVA: 0x7FFE87CEED70
        public void Simulate(){} // RVA: 0x7FFE87CEEEA0 | overloaded x4
        public void Play(){} // RVA: 0x7FFE87CEEF30 | overloaded x2
        public void Pause(){} // RVA: 0x7FFE87CEEFF0 | overloaded x2
        public void Stop(){} // RVA: 0x7FFE87CEF130 | overloaded x3
        public void Clear(){} // RVA: 0x7FFE87CEF1F0 | overloaded x2
        public void IsAlive(){} // RVA: 0x7FFE87CEF2B0 | overloaded x2
        public void Emit_Internal(){} // RVA: 0x7FFE87CEF310
        public void EmitOld_Internal(){} // RVA: 0x7FFE87CEF3E0
        public void TriggerSubEmitter(){} // RVA: 0x7FFE87CEF5E0 | overloaded x3
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7FFE87CEF570
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7FFE87CEF650
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7FFE87CEF6A0
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7FFE87CEF700
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7FFE87CEF750
        public void AllocateCustomDataAttribute(){} // RVA: 0x7FFE87CEF7A0
        public void get_has3DParticleRotations(){} // RVA: 0x7FFE87CEF800
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7FFE87CEF850
        public void GetManagedJobData(){} // RVA: 0x7FFE87CEF8A0
        public void GetManagedJobHandle(){} // RVA: 0x7FFE87CEF8F0
        public void SetManagedJobHandle(){} // RVA: 0x7FFE87CEF960
        public void ScheduleManagedJob(){} // RVA: 0x7FFE87CEF9C0
        public void CopyManagedJobData(){} // RVA: 0x7FFE87CEFA40
        public void get_main(){} // RVA: 0x7FFE81D7BAB0
        public void get_emission(){} // RVA: 0x7FFE81D7BAB0
        public void get_shape(){} // RVA: 0x7FFE81D7BAB0
        public void get_velocityOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_limitVelocityOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_inheritVelocity(){} // RVA: 0x7FFE81D7BAB0
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x7FFE81D7BAB0
        public void get_forceOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_colorOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_colorBySpeed(){} // RVA: 0x7FFE81D7BAB0
        public void get_sizeOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_sizeBySpeed(){} // RVA: 0x7FFE81D7BAB0
        public void get_rotationOverLifetime(){} // RVA: 0x7FFE81D7BAB0
        public void get_rotationBySpeed(){} // RVA: 0x7FFE81D7BAB0
        public void get_externalForces(){} // RVA: 0x7FFE81D7BAB0
        public void get_noise(){} // RVA: 0x7FFE81D7BAB0
        public void get_collision(){} // RVA: 0x7FFE81D7BAB0
        public void get_trigger(){} // RVA: 0x7FFE81D7BAB0
        public void get_subEmitters(){} // RVA: 0x7FFE81D7BAB0
        public void get_textureSheetAnimation(){} // RVA: 0x7FFE81D7BAB0
        public void get_lights(){} // RVA: 0x7FFE81D7BAB0
        public void get_trails(){} // RVA: 0x7FFE81D7BAB0
        public void get_customData(){} // RVA: 0x7FFE81D7BAB0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7FFE87CEFAA0
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7FFE87CEFB10
        public void GetPlaybackState_Injected(){} // RVA: 0x7FFE87CEFB80
        public void SetPlaybackState_Injected(){} // RVA: 0x7FFE87CEFBE0
        public void SetTrails_Injected(){} // RVA: 0x7FFE87CEFC40
        public void Emit_Injected(){} // RVA: 0x7FFE87CEFCA0
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7FFE87CEFD10
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7FFE87CEFD80
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7FFE87CEFDE0
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7FFE87CEFE40
    }

    public class ParticleSystemExtensionsImpl : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFE87D05900
    }

    public class ParticleSystemForceField : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ParticleSystemRenderer : Renderer
    {
        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x7FFE87D05970
        public void DisableVertexStreams(){} // RVA: 0x7FFE87D05980
        public void AreVertexStreamsEnabled(){} // RVA: 0x7FFE87D05990
        public void GetEnabledVertexStreams(){} // RVA: 0x7FFE87D059B0
        public void Internal_SetVertexStreams(){} // RVA: 0x7FFE87D059C0
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7FFE87D060A0
        public void BakeMesh(){} // RVA: 0x7FFE87D079E0 | overloaded x4
        public void BakeTrailsMesh(){} // RVA: 0x7FFE87D07AE0 | overloaded x4
        public void get_alignment(){} // RVA: 0x7FFE87D06820
        public void set_alignment(){} // RVA: 0x7FFE87D06870
        public void get_renderMode(){} // RVA: 0x7FFE87D068D0
        public void set_renderMode(){} // RVA: 0x7FFE87D06920
        public void get_meshDistribution(){} // RVA: 0x7FFE87D06980
        public void set_meshDistribution(){} // RVA: 0x7FFE87D069D0
        public void get_sortMode(){} // RVA: 0x7FFE87D06A30
        public void set_sortMode(){} // RVA: 0x7FFE87D06A80
        public void get_lengthScale(){} // RVA: 0x7FFE87D06AE0
        public void set_lengthScale(){} // RVA: 0x7FFE87D06B30
        public void get_velocityScale(){} // RVA: 0x7FFE87D06B90
        public void set_velocityScale(){} // RVA: 0x7FFE87D06BE0
        public void get_cameraVelocityScale(){} // RVA: 0x7FFE87D06C40
        public void set_cameraVelocityScale(){} // RVA: 0x7FFE87D06C90
        public void get_normalDirection(){} // RVA: 0x7FFE87D06CF0
        public void set_normalDirection(){} // RVA: 0x7FFE87D06D40
        public void get_shadowBias(){} // RVA: 0x7FFE87D06DA0
        public void set_shadowBias(){} // RVA: 0x7FFE87D06DF0
        public void get_sortingFudge(){} // RVA: 0x7FFE87D06E50
        public void set_sortingFudge(){} // RVA: 0x7FFE87D06EA0
        public void get_minParticleSize(){} // RVA: 0x7FFE87D06F00
        public void set_minParticleSize(){} // RVA: 0x7FFE87D06F50
        public void get_maxParticleSize(){} // RVA: 0x7FFE87D06FB0
        public void set_maxParticleSize(){} // RVA: 0x7FFE87D07000
        public void get_pivot(){} // RVA: 0x7FFE87D07060
        public void set_pivot(){} // RVA: 0x7FFE87D070D0
        public void get_flip(){} // RVA: 0x7FFE87D07130
        public void set_flip(){} // RVA: 0x7FFE87D071A0
        public void get_maskInteraction(){} // RVA: 0x7FFE87D07200
        public void set_maskInteraction(){} // RVA: 0x7FFE87D07250
        public void get_trailMaterial(){} // RVA: 0x7FFE87D072B0
        public void set_trailMaterial(){} // RVA: 0x7FFE87D07300
        public void set_oldTrailMaterial(){} // RVA: 0x7FFE87D07360
        public void get_enableGPUInstancing(){} // RVA: 0x7FFE87D073C0
        public void set_enableGPUInstancing(){} // RVA: 0x7FFE87D07410
        public void get_allowRoll(){} // RVA: 0x7FFE87D07470
        public void set_allowRoll(){} // RVA: 0x7FFE87D074C0
        public void get_freeformStretching(){} // RVA: 0x7FFE87D07520
        public void set_freeformStretching(){} // RVA: 0x7FFE87D07570
        public void get_rotateWithStretchDirection(){} // RVA: 0x7FFE87D075D0
        public void set_rotateWithStretchDirection(){} // RVA: 0x7FFE87D07620
        public void get_mesh(){} // RVA: 0x7FFE87D07680
        public void set_mesh(){} // RVA: 0x7FFE87D076D0
        public void GetMeshes(){} // RVA: 0x7FFE87D07730
        public void SetMeshes(){} // RVA: 0x7FFE87D07800 | overloaded x2
        public void GetMeshWeightings(){} // RVA: 0x7FFE87D07820
        public void SetMeshWeightings(){} // RVA: 0x7FFE87D078F0 | overloaded x2
        public void get_meshCount(){} // RVA: 0x7FFE87D07910
        public void BakeTexture(){} // RVA: 0x7FFE87D08100 | overloaded x4
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7FFE87D07EB0
        public void BakeTextureInternal(){} // RVA: 0x7FFE87D08270
        public void BakeTrailsTexture(){} // RVA: 0x7FFE87D084E0 | overloaded x2
        public void BakeTrailsTextureInternal(){} // RVA: 0x7FFE87D08650
        public void get_activeVertexStreamsCount(){} // RVA: 0x7FFE87D08700
        public void SetActiveVertexStreams(){} // RVA: 0x7FFE87D08750
        public void GetActiveVertexStreams(){} // RVA: 0x7FFE87D087B0
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7FFE87D08810
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7FFE87D08860
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7FFE87D088C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_pivot_Injected(){} // RVA: 0x7FFE87D08920
        public void set_pivot_Injected(){} // RVA: 0x7FFE87D08980
        public void get_flip_Injected(){} // RVA: 0x7FFE87D089E0
        public void set_flip_Injected(){} // RVA: 0x7FFE87D08A40
        public void BakeTextureInternal_Injected(){} // RVA: 0x7FFE87D08AA0
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7FFE87D08B30
    }

    public class PenData : ValueType
    {
    }

    public class PhysicMaterial : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D3C170 | overloaded x2
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7FFE87D3C210
        public void get_bounciness(){} // RVA: 0x7FFE87D3C270
        public void set_bounciness(){} // RVA: 0x7FFE87D3C2C0
        public void get_dynamicFriction(){} // RVA: 0x7FFE87D3C320
        public void set_dynamicFriction(){} // RVA: 0x7FFE87D3C370
        public void get_staticFriction(){} // RVA: 0x7FFE87D3C3D0
        public void set_staticFriction(){} // RVA: 0x7FFE87D3C420
        public void get_frictionCombine(){} // RVA: 0x7FFE87D3C480
        public void set_frictionCombine(){} // RVA: 0x7FFE87D3C4D0
        public void get_bounceCombine(){} // RVA: 0x7FFE87D3C530
        public void set_bounceCombine(){} // RVA: 0x7FFE87D3C580
    }

    public class Physics : Object
    {
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD; // 0x8
        public ContactEventDelegate ContactEvent; // 0x10
        public UnityEngine.Collision s_ReusableCollision; // 0x18
        public object field_4; // 0x52C0
        public object field_5; // 0x5478
        public object field_6; // 0x5630

        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7FFE87D30C40
        public void get_gravity(){} // RVA: 0x7FFE87D30D30
        public void set_gravity(){} // RVA: 0x7FFE87D30DC0
        public void get_bounceThreshold(){} // RVA: 0x7FFE87D30E50
        public void set_bounceThreshold(){} // RVA: 0x7FFE87D30EA0
        public void get_simulationMode(){} // RVA: 0x7FFE87D30F00
        public void set_simulationMode(){} // RVA: 0x7FFE87D30F50
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7FFE87D30FA0
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7FFE87D30FF0
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7FFE87D31050
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFE87D310A0
        public void IgnoreCollision(){} // RVA: 0x7FFE87D311A0 | overloaded x2
        public void IgnoreLayerCollision(){} // RVA: 0x7FFE87D312B0 | overloaded x2
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFE87D31350
        public void GetIgnoreCollision(){} // RVA: 0x7FFE87D313B0
        public void Raycast(){} // RVA: 0x7FFE87D32030 | overloaded x16
        public void Linecast(){} // RVA: 0x7FFE87D32530 | overloaded x6
        public void CapsuleCast(){} // RVA: 0x7FFE87D32E10 | overloaded x8
        public void SphereCast(){} // RVA: 0x7FFE87D338F0 | overloaded x12
        public void BoxCast(){} // RVA: 0x7FFE87D34430 | overloaded x10
        public void Internal_RaycastAll(){} // RVA: 0x7FFE87D34560
        public void RaycastAll(){} // RVA: 0x7FFE87D34C90 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFE87D352F0 | overloaded x8
        public void Query_CapsuleCastAll(){} // RVA: 0x7FFE87D353C0
        public void CapsuleCastAll(){} // RVA: 0x7FFE87D35890 | overloaded x4
        public void Query_SphereCastAll(){} // RVA: 0x7FFE87D35970
        public void SphereCastAll(){} // RVA: 0x7FFE87D360F0 | overloaded x8
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFE87D36200
        public void OverlapCapsule(){} // RVA: 0x7FFE87D364C0 | overloaded x3
        public void OverlapSphere_Internal(){} // RVA: 0x7FFE87D36570
        public void OverlapSphere(){} // RVA: 0x7FFE87D367D0 | overloaded x3
        public void Simulate_Internal(){} // RVA: 0x7FFE87D36860
        public void Simulate(){} // RVA: 0x7FFE87D36900
        public void InterpolateBodies_Internal(){} // RVA: 0x7FFE87D36A10
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7FFE87D36AA0
        public void SyncTransforms(){} // RVA: 0x7FFE87D36B30
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFE87D36B80
        public void Query_ComputePenetration(){} // RVA: 0x7FFE87D36BD0
        public void ComputePenetration(){} // RVA: 0x7FFE87D36CC0
        public void Query_ClosestPoint(){} // RVA: 0x7FFE87D36E80
        public void ClosestPoint(){} // RVA: 0x7FFE87D36F50
        public void OverlapSphereNonAlloc(){} // RVA: 0x7FFE87D37240 | overloaded x3
        public void CheckSphere_Internal(){} // RVA: 0x7FFE87D372D0
        public void CheckSphere(){} // RVA: 0x7FFE87D37530 | overloaded x3
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFE87D37930 | overloaded x4
        public void SphereCastNonAlloc(){} // RVA: 0x7FFE87D38030 | overloaded x8
        public void CheckCapsule_Internal(){} // RVA: 0x7FFE87D380D0
        public void CheckCapsule(){} // RVA: 0x7FFE87D38390 | overloaded x3
        public void CheckBox_Internal(){} // RVA: 0x7FFE87D38440
        public void CheckBox(){} // RVA: 0x7FFE87D38890 | overloaded x4
        public void OverlapBox_Internal(){} // RVA: 0x7FFE87D38A30
        public void OverlapBox(){} // RVA: 0x7FFE87D38E80 | overloaded x4
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFE87D393E0 | overloaded x4
        public void BoxCastNonAlloc(){} // RVA: 0x7FFE87D39C30 | overloaded x5
        public void Internal_BoxCastAll(){} // RVA: 0x7FFE87D39E20
        public void BoxCastAll(){} // RVA: 0x7FFE87D3A3E0 | overloaded x5
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFE87D3A6D0 | overloaded x3
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x7FFE87D3A790
        public void RebuildBroadphaseRegions(){} // RVA: 0x7FFE87D3A830
        public void BakeMesh(){} // RVA: 0x7FFE87D3AA70 | overloaded x2
        public void GetColliderByInstanceID(){} // RVA: 0x7FFE87D3AB10
        public void GetBodyByInstanceID(){} // RVA: 0x7FFE87D3AB60
        public void SendOnCollisionEnter(){} // RVA: 0x7FFE87D3ABB0
        public void SendOnCollisionStay(){} // RVA: 0x7FFE87D3AC10
        public void SendOnCollisionExit(){} // RVA: 0x7FFE87D3AC70
        public void OnSceneContact(){} // RVA: 0x7FFE87D3ACD0
        public void ReportContacts(){} // RVA: 0x7FFE87D3AF00
        public void GetCollisionToReport(){} // RVA: 0x7FFE87D3B3D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87D3B6E0
        public void get_gravity_Injected(){} // RVA: 0x7FFE87D3B7B0
        public void set_gravity_Injected(){} // RVA: 0x7FFE87D3B800
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x7FFE87D3B850
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7FFE87D3B8A0
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7FFE87D3B930
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7FFE87D3B9C0
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFE87D3BA50
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7FFE87D3BAE0
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFE87D3BB70
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7FFE87D3BBD0
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7FFE87D3BC20
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7FFE87D3BC70
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7FFE87D3BD00
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7FFE87D3BD90
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7FFE87D3BE20
        public void CheckBox_Internal_Injected(){} // RVA: 0x7FFE87D3BEB0
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFE87D3BF40
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7FFE87D3BFD0
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x7FFE87D3C060
    }

    public class Physics2D : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;
        public object field_1; // 0xC9D0
        public object field_2; // 0xCB88
        public object field_3; // 0xCD40
        public object field_4; // 0xCEF8
        public object field_5; // 0xD0B0
        public object field_6; // 0xD268
        public object field_7; // 0xD420
        public object field_8; // 0xD5D8
        public object field_9; // 0xD790
        public object field_10; // 0xD948
        public object field_11; // 0xDB00
        public object field_12; // 0xDCB8
        public object field_13; // 0xDE70
        public object field_14; // 0xE028
        public object field_15; // 0xE1E0
        public object field_16; // 0xE398
        public object field_17; // 0xE550

        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFE84A912C0
        public void get_velocityIterations(){} // RVA: 0x7FFE87D0EA00
        public void set_velocityIterations(){} // RVA: 0x7FFE87D0EA50
        public void get_positionIterations(){} // RVA: 0x7FFE87D0EAA0
        public void set_positionIterations(){} // RVA: 0x7FFE87D0EAF0
        public void get_gravity(){} // RVA: 0x7FFE87D0EB40
        public void set_gravity(){} // RVA: 0x7FFE87D0EBD0
        public void get_queriesHitTriggers(){} // RVA: 0x7FFE87D0EC60
        public void get_queriesStartInColliders(){} // RVA: 0x7FFE87D0ECB0
        public void set_queriesStartInColliders(){} // RVA: 0x7FFE87D0ED00
        public void get_callbacksOnDisable(){} // RVA: 0x7FFE87D0ED50
        public void set_callbacksOnDisable(){} // RVA: 0x7FFE87D0EDA0
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFE87D0EDF0
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7FFE87D0EE40
        public void get_velocityThreshold(){} // RVA: 0x7FFE87D0EE90
        public void set_velocityThreshold(){} // RVA: 0x7FFE87D0EEE0
        public void get_maxLinearCorrection(){} // RVA: 0x7FFE87D0EF40
        public void set_maxLinearCorrection(){} // RVA: 0x7FFE87D0EF90
        public void get_maxAngularCorrection(){} // RVA: 0x7FFE87D0EFF0
        public void set_maxAngularCorrection(){} // RVA: 0x7FFE87D0F040
        public void get_maxTranslationSpeed(){} // RVA: 0x7FFE87D0F0A0
        public void set_maxTranslationSpeed(){} // RVA: 0x7FFE87D0F0F0
        public void get_maxRotationSpeed(){} // RVA: 0x7FFE87D0F150
        public void set_maxRotationSpeed(){} // RVA: 0x7FFE87D0F1A0
        public void get_baumgarteScale(){} // RVA: 0x7FFE87D0F200
        public void set_baumgarteScale(){} // RVA: 0x7FFE87D0F250
        public void get_baumgarteTOIScale(){} // RVA: 0x7FFE87D0F2B0
        public void set_baumgarteTOIScale(){} // RVA: 0x7FFE87D0F300
        public void get_timeToSleep(){} // RVA: 0x7FFE87D0F360
        public void set_timeToSleep(){} // RVA: 0x7FFE87D0F3B0
        public void get_linearSleepTolerance(){} // RVA: 0x7FFE87D0F410
        public void set_linearSleepTolerance(){} // RVA: 0x7FFE87D0F460
        public void get_angularSleepTolerance(){} // RVA: 0x7FFE87D0F4C0
        public void set_angularSleepTolerance(){} // RVA: 0x7FFE87D0F510
        public void Simulate(){} // RVA: 0x7FFE87D0F570
        public void Simulate_Internal(){} // RVA: 0x7FFE87D0F5D0
        public void SyncTransforms(){} // RVA: 0x7FFE87D0F670
        public void IgnoreCollision(){} // RVA: 0x7FFE87D0F760 | overloaded x2
        public void GetIgnoreCollision(){} // RVA: 0x7FFE87D0F7D0
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFE87D0F830
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7FFE87D0F970
        public void SetLayerCollisionMask(){} // RVA: 0x7FFE87D0F9D0
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7FFE87D0FAC0
        public void GetLayerCollisionMask(){} // RVA: 0x7FFE87D0FB20
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7FFE87D0FC00
        public void IsTouching(){} // RVA: 0x7FFE87D0FE60 | overloaded x3
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7FFE87D0FDB0
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7FFE87D0FF50
        public void IsTouchingLayers(){} // RVA: 0x7FFE87D10080 | overloaded x2
        public void Distance(){} // RVA: 0x7FFE87D100E0
        public void Distance_Internal(){} // RVA: 0x7FFE87D10480
        public void ClosestPoint(){} // RVA: 0x7FFE87D10720 | overloaded x2
        public void ClosestPoint_Collider(){} // RVA: 0x7FFE87D10900
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7FFE87D109A0
        public void Linecast(){} // RVA: 0x7FFE87D110F0 | overloaded x6
        public void LinecastAll(){} // RVA: 0x7FFE87D11650 | overloaded x4
        public void LinecastAll_Internal(){} // RVA: 0x7FFE87D117C0
        public void LinecastNonAlloc(){} // RVA: 0x7FFE87D11BA0 | overloaded x4
        public void Raycast(){} // RVA: 0x7FFE87D12630 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFE87D12B60 | overloaded x5
        public void RaycastAll(){} // RVA: 0x7FFE87D130C0 | overloaded x5
        public void RaycastAll_Internal(){} // RVA: 0x7FFE87D131C0
        public void CircleCast(){} // RVA: 0x7FFE87D13C50 | overloaded x8
        public void CircleCastAll(){} // RVA: 0x7FFE87D141D0 | overloaded x5
        public void CircleCastAll_Internal(){} // RVA: 0x7FFE87D142E0
        public void CircleCastNonAlloc(){} // RVA: 0x7FFE87D14810 | overloaded x5
        public void BoxCast(){} // RVA: 0x7FFE87D15410 | overloaded x8
        public void BoxCastAll(){} // RVA: 0x7FFE87D15A00 | overloaded x5
        public void BoxCastAll_Internal(){} // RVA: 0x7FFE87D15B20
        public void BoxCastNonAlloc(){} // RVA: 0x7FFE87D160E0 | overloaded x5
        public void CapsuleCast(){} // RVA: 0x7FFE87D16D30 | overloaded x8
        public void CapsuleCastAll(){} // RVA: 0x7FFE87D17430 | overloaded x5
        public void CapsuleCastAll_Internal(){} // RVA: 0x7FFE87D170F0
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFE87D17A60 | overloaded x5
        public void GetRayIntersection(){} // RVA: 0x7FFE87D17EC0 | overloaded x3
        public void GetRayIntersectionAll(){} // RVA: 0x7FFE87D18240 | overloaded x3
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7FFE87D18360
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7FFE87D18630 | overloaded x3
        public void OverlapPoint(){} // RVA: 0x7FFE87D18BD0 | overloaded x6
        public void OverlapPointAll(){} // RVA: 0x7FFE87D190C0 | overloaded x4
        public void OverlapPointAll_Internal(){} // RVA: 0x7FFE87D19210
        public void OverlapPointNonAlloc(){} // RVA: 0x7FFE87D19590 | overloaded x4
        public void OverlapCircle(){} // RVA: 0x7FFE87D19BD0 | overloaded x6
        public void OverlapCircleAll(){} // RVA: 0x7FFE87D1A100 | overloaded x4
        public void OverlapCircleAll_Internal(){} // RVA: 0x7FFE87D1A260
        public void OverlapCircleNonAlloc(){} // RVA: 0x7FFE87D1A620 | overloaded x4
        public void OverlapBox(){} // RVA: 0x7FFE87D1AD20 | overloaded x6
        public void OverlapBoxAll(){} // RVA: 0x7FFE87D1B150 | overloaded x4
        public void OverlapBoxAll_Internal(){} // RVA: 0x7FFE87D1B250
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFE87D1B680 | overloaded x4
        public void OverlapArea(){} // RVA: 0x7FFE87D1BC80 | overloaded x6
        public void OverlapAreaAll(){} // RVA: 0x7FFE87D1BF20 | overloaded x4
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7FFE87D1BFC0
        public void OverlapAreaNonAlloc(){} // RVA: 0x7FFE87D1C420 | overloaded x4
        public void OverlapCapsule(){} // RVA: 0x7FFE87D1CB40 | overloaded x6
        public void OverlapCapsuleAll(){} // RVA: 0x7FFE87D1D130 | overloaded x4
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7FFE87D1D2D0
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFE87D1D730 | overloaded x4
        public void OverlapCollider(){} // RVA: 0x7FFE87D0D790 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFE87D1EF40 | overloaded x18
        public void GetColliderContactsArray(){} // RVA: 0x7FFE87D1E2B0
        public void GetColliderColliderContactsArray(){} // RVA: 0x7FFE87D1E360
        public void GetRigidbodyContactsArray(){} // RVA: 0x7FFE87D1E420
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7FFE87D1E4D0
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7FFE87D1E580
        public void GetColliderContactsList(){} // RVA: 0x7FFE87D1F040
        public void GetColliderColliderContactsList(){} // RVA: 0x7FFE87D1F0F0
        public void GetRigidbodyContactsList(){} // RVA: 0x7FFE87D1F1B0
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7FFE87D1F260
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7FFE87D1F310
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87D1F3C0
        public void get_gravity_Injected(){} // RVA: 0x7FFE87D1F4A0
        public void set_gravity_Injected(){} // RVA: 0x7FFE87D1F4F0
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFE87D1F540
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7FFE87D1F5A0
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7FFE87D1F610
        public void Distance_Internal_Injected(){} // RVA: 0x7FFE87D1F670
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7FFE87D1F6E0
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7FFE87D1F750
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7FFE87D1F7C0
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7FFE87D1F840
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7FFE87D1F8D0
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7FFE87D1F960
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7FFE87D1F9F0
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7FFE87D1FA80
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7FFE87D1FB10
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7FFE87D1FB80
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7FFE87D1FC00
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7FFE87D1FC90
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7FFE87D1FD20
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7FFE87D1FD90
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7FFE87D1FE10
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFE87D1FE80
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFE87D1FEF0
        public void GetColliderContactsList_Injected(){} // RVA: 0x7FFE87D1FF60
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7FFE87D1FFD0
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7FFE87D20050
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFE87D200C0
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFE87D20130
    }

    public class PhysicsMaterial2D : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D2FAF0
        public void Create_Internal(){} // RVA: 0x7FFE87D2FB80
        public void get_bounciness(){} // RVA: 0x7FFE87D2FBE0
        public void set_bounciness(){} // RVA: 0x7FFE87D2FC30
        public void get_friction(){} // RVA: 0x7FFE87D2FC90
        public void set_friction(){} // RVA: 0x7FFE87D2FCE0
    }

    public class PhysicsScene : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87D48490
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void op_Inequality(){} // RVA: 0x7FFE87C8A3B0
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE87D48600
        public void IsValid_Internal(){} // RVA: 0x7FFE87D48660
        public void IsEmpty(){} // RVA: 0x7FFE87D486B0
        public void IsEmpty_Internal(){} // RVA: 0x7FFE87D487A0
        public void Simulate(){} // RVA: 0x7FFE87D487F0
        public void InterpolateBodies(){} // RVA: 0x7FFE87D489D0
        public void ResetInterpolationPoses(){} // RVA: 0x7FFE87D48BC0
        public void Raycast(){} // RVA: 0x7FFE87D492D0 | overloaded x3
        public void Internal_RaycastTest(){} // RVA: 0x7FFE87D48FA0
        public void Internal_Raycast(){} // RVA: 0x7FFE87D49240
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7FFE87D494A0
        public void Query_CapsuleCast(){} // RVA: 0x7FFE87D49530
        public void Internal_CapsuleCast(){} // RVA: 0x7FFE87D495F0
        public void CapsuleCast(){} // RVA: 0x7FFE87D499B0 | overloaded x2
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7FFE87D498F0
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7FFE87D49AF0
        public void OverlapCapsule(){} // RVA: 0x7FFE87D49B90
        public void Query_SphereCast(){} // RVA: 0x7FFE87D49C50
        public void Internal_SphereCast(){} // RVA: 0x7FFE87D49D00
        public void SphereCast(){} // RVA: 0x7FFE87D4A050 | overloaded x2
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7FFE87D49FA0
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7FFE87D4A160
        public void OverlapSphere(){} // RVA: 0x7FFE87D4A1F0
        public void Query_BoxCast(){} // RVA: 0x7FFE87D4A290
        public void Internal_BoxCast(){} // RVA: 0x7FFE87D4A350
        public void BoxCast(){} // RVA: 0x7FFE87D4ACA0 | overloaded x4
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7FFE87D4A820
        public void OverlapBox(){} // RVA: 0x7FFE87D4A990 | overloaded x2
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7FFE87D4AAA0
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFE87D4AE20
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFE87D4AE70
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7FFE87D4AEC0
        public void Internal_Raycast_Injected(){} // RVA: 0x7FFE87D4AF50
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7FFE87D4AFE0
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7FFE87D4B070
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7FFE87D4B100
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7FFE87D4B190
        public void Query_SphereCast_Injected(){} // RVA: 0x7FFE87D4B220
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7FFE87D4B2B0
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7FFE87D4B340
        public void Query_BoxCast_Injected(){} // RVA: 0x7FFE87D4B3D0
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7FFE87D4B460
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7FFE87D4B4F0
    }

    public class PhysicsScene2D : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87D08C60
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void op_Inequality(){} // RVA: 0x7FFE87C8A3B0
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE87D08DD0
        public void IsValid_Internal(){} // RVA: 0x7FFE87D08E30
        public void IsEmpty(){} // RVA: 0x7FFE87D08E80
        public void IsEmpty_Internal(){} // RVA: 0x7FFE87D08F70
        public void Simulate(){} // RVA: 0x7FFE87D08FC0
        public void Linecast(){} // RVA: 0x7FFE87D095C0 | overloaded x5
        public void Linecast_Internal(){} // RVA: 0x7FFE87D09300
        public void LinecastArray_Internal(){} // RVA: 0x7FFE87D09540
        public void LinecastNonAllocList_Internal(){} // RVA: 0x7FFE87D09660
        public void Raycast(){} // RVA: 0x7FFE87D09C60 | overloaded x5
        public void Raycast_Internal(){} // RVA: 0x7FFE87D09940
        public void RaycastArray_Internal(){} // RVA: 0x7FFE87D09BC0
        public void RaycastList_Internal(){} // RVA: 0x7FFE87D09D20
        public void CircleCast(){} // RVA: 0x7FFE87D0A3A0 | overloaded x5
        public void CircleCast_Internal(){} // RVA: 0x7FFE87D0A060
        public void CircleCastArray_Internal(){} // RVA: 0x7FFE87D0A300
        public void CircleCastList_Internal(){} // RVA: 0x7FFE87D0A470
        public void BoxCast(){} // RVA: 0x7FFE87D0AB80 | overloaded x5
        public void BoxCast_Internal(){} // RVA: 0x7FFE87D0A7E0
        public void BoxCastArray_Internal(){} // RVA: 0x7FFE87D0AAD0
        public void BoxCastList_Internal(){} // RVA: 0x7FFE87D0AC70
        public void CapsuleCast(){} // RVA: 0x7FFE87D0B3E0 | overloaded x5
        public void CapsuleCast_Internal(){} // RVA: 0x7FFE87D0B010
        public void CapsuleCastArray_Internal(){} // RVA: 0x7FFE87D0B320
        public void CapsuleCastList_Internal(){} // RVA: 0x7FFE87D0B4D0
        public void GetRayIntersection(){} // RVA: 0x7FFE87D0B730 | overloaded x2
        public void GetRayIntersection_Internal(){} // RVA: 0x7FFE87D0B690
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x7FFE87D0B7E0
        public void OverlapPoint(){} // RVA: 0x7FFE87D0BC20 | overloaded x5
        public void OverlapPoint_Internal(){} // RVA: 0x7FFE87D0B9C0
        public void OverlapPointArray_Internal(){} // RVA: 0x7FFE87D0BBA0
        public void OverlapPointList_Internal(){} // RVA: 0x7FFE87D0BCB0
        public void OverlapCircle(){} // RVA: 0x7FFE87D0C160 | overloaded x5
        public void OverlapCircle_Internal(){} // RVA: 0x7FFE87D0BEA0
        public void OverlapCircleArray_Internal(){} // RVA: 0x7FFE87D0C0D0
        public void OverlapCircleList_Internal(){} // RVA: 0x7FFE87D0C210
        public void OverlapBox(){} // RVA: 0x7FFE87D0C760 | overloaded x5
        public void OverlapBox_Internal(){} // RVA: 0x7FFE87D0C450
        public void OverlapBoxArray_Internal(){} // RVA: 0x7FFE87D0C6C0
        public void OverlapBoxList_Internal(){} // RVA: 0x7FFE87D0C820
        public void OverlapArea(){} // RVA: 0x7FFE87D0CDD0 | overloaded x5
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x7FFE87D0CC30 | overloaded x2
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x7FFE87D0CE20
        public void OverlapCapsule(){} // RVA: 0x7FFE87D0D490 | overloaded x5
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFE87D0D180
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x7FFE87D0D3F0
        public void OverlapCapsuleList_Internal(){} // RVA: 0x7FFE87D0D550
        public void OverlapCollider(){} // RVA: 0x7FFE87D0D790 | overloaded x3
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFE87D0D720
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFE87D0D810
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFE87D0D880
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFE87D0D8D0
        public void Linecast_Internal_Injected(){} // RVA: 0x7FFE87D0D920
        public void LinecastArray_Internal_Injected(){} // RVA: 0x7FFE87D0D9B0
        public void LinecastNonAllocList_Internal_Injected(){} // RVA: 0x7FFE87D0DA40
        public void Raycast_Internal_Injected(){} // RVA: 0x7FFE87D0DAD0
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFE87D0DB60
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFE87D0DBF0
        public void CircleCast_Internal_Injected(){} // RVA: 0x7FFE87D0DC80
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x7FFE87D0DD10
        public void CircleCastList_Internal_Injected(){} // RVA: 0x7FFE87D0DDA0
        public void BoxCast_Internal_Injected(){} // RVA: 0x7FFE87D0DE30
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x7FFE87D0DEC0
        public void BoxCastList_Internal_Injected(){} // RVA: 0x7FFE87D0DF50
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x7FFE87D0DFE0
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x7FFE87D0E070
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x7FFE87D0E100
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x7FFE87D0E190
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x7FFE87D0E220
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x7FFE87D0E2B0
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x7FFE87D0E320
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x7FFE87D0E3A0
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x7FFE87D0E420
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x7FFE87D0E4A0
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x7FFE87D0E530
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFE87D0E5C0
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x7FFE87D0E650
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x7FFE87D0E6E0
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFE87D0E770
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x7FFE87D0E800
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x7FFE87D0E890
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFE87D0E920
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFE87D0E990
    }

    public class PhysicsShape2D : ValueType
    {
    }

    public class PhysicsShapeGroup2D : Object
    {
    }

    public class PhysicsUpdateBehaviour2D : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Plane : ValueType
    {
        public int size;
        public UnityEngine.Vector3 m_Normal; // 0x10
        public float m_Distance; // 0x1C

        // ── Methods ──
        public void get_normal(){} // RVA: 0x7FFE87BBA310
        public void set_normal(){} // RVA: 0x7FFE835C1F00
        public void get_distance(){} // RVA: 0x7FFE8111ED00
        public void set_distance(){} // RVA: 0x7FFE82D03B80
        public void .ctor(){} // RVA: 0x7FFE86D047D0 | overloaded x3
        public void SetNormalAndPosition(){} // RVA: 0x7FFE812A0940
        public void Set3Points(){} // RVA: 0x7FFE86D047D0
        public void Flip(){} // RVA: 0x7FFE87C0E280
        public void get_flipped(){} // RVA: 0x7FFE87C0E2D0
        public void Translate(){} // RVA: 0x7FFE87C0E440 | overloaded x2
        public void ClosestPointOnPlane(){} // RVA: 0x7FFE87C0E550
        public void GetDistanceToPoint(){} // RVA: 0x7FFE87C0E5E0
        public void GetSide(){} // RVA: 0x7FFE87C0E630
        public void SameSide(){} // RVA: 0x7FFE87C0E680
        public void Raycast(){} // RVA: 0x7FFE816F8350
        public void ToString(){} // RVA: 0x7FFE87C0E740 | overloaded x3
    }

    public class PlatformEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_useOneWay(){} // RVA: 0x7FFE87D2EE50
        public void set_useOneWay(){} // RVA: 0x7FFE87D2EEA0
        public void get_useOneWayGrouping(){} // RVA: 0x7FFE87D2EF00
        public void set_useOneWayGrouping(){} // RVA: 0x7FFE87D2EF50
        public void get_useSideFriction(){} // RVA: 0x7FFE87D2EFB0
        public void set_useSideFriction(){} // RVA: 0x7FFE87D2F000
        public void get_useSideBounce(){} // RVA: 0x7FFE87D2F060
        public void set_useSideBounce(){} // RVA: 0x7FFE87D2F0B0
        public void get_surfaceArc(){} // RVA: 0x7FFE87D2F110
        public void set_surfaceArc(){} // RVA: 0x7FFE87D2F160
        public void get_sideArc(){} // RVA: 0x7FFE87D2F1C0
        public void set_sideArc(){} // RVA: 0x7FFE87D2F210
        public void get_rotationalOffset(){} // RVA: 0x7FFE87D2F270
        public void set_rotationalOffset(){} // RVA: 0x7FFE87D2F2C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PlayerConnectionInternal : Object
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x7FFE87C5F7D0
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x7FFE87C5F930
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x7FFE87C5FA90
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x7FFE87C5FAE0
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x7FFE87C5FB70
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x7FFE87C5FC00
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x7FFE87C5FC50
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x7FFE87C5FCA0
        public void IsConnected(){} // RVA: 0x7FFE87C5FC50
        public void Initialize(){} // RVA: 0x7FFE87C5FC00
        public void RegisterInternal(){} // RVA: 0x7FFE87C5FCF0
        public void UnregisterInternal(){} // RVA: 0x7FFE87C5FD40
        public void SendMessage(){} // RVA: 0x7FFE87C5FD90
        public void TrySendMessage(){} // RVA: 0x7FFE87C5FE00
        public void PollInternal(){} // RVA: 0x7FFE87C5FA90
        public void DisconnectAll(){} // RVA: 0x7FFE87C5FCA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PlayerPrefs : Object
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x7FFE87C5FED0
        public void TrySetFloat(){} // RVA: 0x7FFE87C5FF30
        public void TrySetSetString(){} // RVA: 0x7FFE87C5FF90
        public void SetInt(){} // RVA: 0x7FFE87C5FFF0
        public void GetInt(){} // RVA: 0x7FFE87C60100 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFE87C60160
        public void GetFloat(){} // RVA: 0x7FFE87C60270 | overloaded x2
        public void SetString(){} // RVA: 0x7FFE87C602D0
        public void GetString(){} // RVA: 0x7FFE87C603E0 | overloaded x2
        public void HasKey(){} // RVA: 0x7FFE821C8070
        public void DeleteKey(){} // RVA: 0x7FFE87C60470
        public void DeleteAll(){} // RVA: 0x7FFE87C604C0
        public void Save(){} // RVA: 0x7FFE821C8880
    }

    public class PlayerPrefsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C5FE70
    }

    public class PointEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x7FFE87D2E8D0
        public void set_forceMagnitude(){} // RVA: 0x7FFE87D2E920
        public void get_forceVariation(){} // RVA: 0x7FFE87D2E980
        public void set_forceVariation(){} // RVA: 0x7FFE87D2E9D0
        public void get_distanceScale(){} // RVA: 0x7FFE87D2EA30
        public void set_distanceScale(){} // RVA: 0x7FFE87D2EA80
        public void get_drag(){} // RVA: 0x7FFE87D2EAE0
        public void set_drag(){} // RVA: 0x7FFE87D2EB30
        public void get_angularDrag(){} // RVA: 0x7FFE87D2EB90
        public void set_angularDrag(){} // RVA: 0x7FFE87D2EBE0
        public void get_forceSource(){} // RVA: 0x7FFE87D2EC40
        public void set_forceSource(){} // RVA: 0x7FFE87D2EC90
        public void get_forceTarget(){} // RVA: 0x7FFE87D2ECF0
        public void set_forceTarget(){} // RVA: 0x7FFE87D2ED40
        public void get_forceMode(){} // RVA: 0x7FFE87D2EDA0
        public void set_forceMode(){} // RVA: 0x7FFE87D2EDF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PolygonCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7FFE87D2A010
        public void set_useDelaunayMesh(){} // RVA: 0x7FFE87D2A060
        public void get_autoTiling(){} // RVA: 0x7FFE87D2A0C0
        public void set_autoTiling(){} // RVA: 0x7FFE87D2A110
        public void GetTotalPointCount(){} // RVA: 0x7FFE87D2A170
        public void get_points(){} // RVA: 0x7FFE87D2A1C0
        public void set_points(){} // RVA: 0x7FFE87D2A210
        public void get_pathCount(){} // RVA: 0x7FFE87D2A270
        public void set_pathCount(){} // RVA: 0x7FFE87D2A2C0
        public void GetPath(){} // RVA: 0x7FFE87D2A690 | overloaded x2
        public void GetPath_Internal(){} // RVA: 0x7FFE87D2A4D0
        public void SetPath(){} // RVA: 0x7FFE87D2A8D0 | overloaded x2
        public void SetPath_Internal(){} // RVA: 0x7FFE87D2A620
        public void GetPathList_Internal(){} // RVA: 0x7FFE87D2A860
        public void SetPathList_Internal(){} // RVA: 0x7FFE87D2A9C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Pose : ValueType
    {
        public UnityEngine.Vector3 position; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE855C0A70
        public void ToString(){} // RVA: 0x7FFE87C762F0
        public void GetTransformedBy(){} // RVA: 0x7FFE87C76410
        public void get_identity(){} // RVA: 0x7FFE87C76710
        public void Equals(){} // RVA: 0x7FFE87C76850 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C76900
        public void .cctor(){} // RVA: 0x7FFE87C769E0
    }

    public class PreferBinarySerialization : Attribute
    {
    }

    public class PreloadData : Object
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x7FFE810FB310
    }

    public class Projector : Behaviour
    {
        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x7FFE87C316B0
        public void set_nearClipPlane(){} // RVA: 0x7FFE87C31700
        public void get_farClipPlane(){} // RVA: 0x7FFE87C31760
        public void set_farClipPlane(){} // RVA: 0x7FFE87C317B0
        public void get_fieldOfView(){} // RVA: 0x7FFE87C31810
        public void set_fieldOfView(){} // RVA: 0x7FFE87C31860
        public void get_aspectRatio(){} // RVA: 0x7FFE87C318C0
        public void set_aspectRatio(){} // RVA: 0x7FFE87C31910
        public void get_orthographic(){} // RVA: 0x7FFE87C31970
        public void set_orthographic(){} // RVA: 0x7FFE87C319C0
        public void get_orthographicSize(){} // RVA: 0x7FFE87C31A20
        public void set_orthographicSize(){} // RVA: 0x7FFE87C31A70
        public void get_ignoreLayers(){} // RVA: 0x7FFE87C31AD0
        public void set_ignoreLayers(){} // RVA: 0x7FFE87C31B20
        public void get_material(){} // RVA: 0x7FFE87C31B80
        public void set_material(){} // RVA: 0x7FFE87C31BD0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PropertyName : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BF990 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x7FFE87C606C0
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE87C60590
        public void ToString(){} // RVA: 0x7FFE87C60760
    }

    public class PropertyNameUtils : Object
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x7FFE87C60590
        public void PropertyNameFromString_Injected(){} // RVA: 0x7FFE87C605F0
    }

}