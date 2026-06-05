// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 30
// Methods: 1086

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent
    {
        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFAF9B483A0
        public void get_colliderComponent(){} // RVA: 0x7FFAF9C78A20
        public void InstanceIDToColliderComponent(){} // RVA: 0x7FFAF9C78A70
    }

    public class ParticlePhysicsExtensions
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFAF9C75760
    }

    public class ParticleSystem
    {
        public object emitterVelocity;
        public object duration;
        public object loop;
        public object prewarm;
        public object startDelay;
        public object startDelayMultiplier;
        public object startLifetime;
        public object startLifetimeMultiplier;
        public object startSpeed;
        public object startSpeedMultiplier;
        public object startSize3D;
        public object startSize;
        public object startSizeMultiplier;
        public object startSizeX;
        public object startSizeXMultiplier;
        public object startSizeY;
        public object startSizeYMultiplier;
        public object startSizeZ;
        public object startSizeZMultiplier;
        public object startRotation3D;
        public object startRotation;
        public object startRotationMultiplier;
        public object startRotationX;
        public object startRotationXMultiplier;
        public object startRotationY;
        public object startRotationYMultiplier;
        public object startRotationZ;
        public object startRotationZMultiplier;
        public object flipRotation;
        public object startColor;
        public object gravitySource;
        public object gravityModifier;
        public object gravityModifierMultiplier;
        public object simulationSpace;
        public object customSimulationSpace;
        public object simulationSpeed;
        public object useUnscaledTime;
        public object scalingMode;
        public object playOnAwake;
        public object maxParticles;
        public object emitterVelocityMode;
        public object stopAction;
        public object ringBufferMode;
        public object ringBufferLoopRange;
        public object cullingMode;

        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFAF9C5F1D0 | overloaded x4
        public void get_startDelay(){} // RVA: 0x7FFAF9C5C260
        public void set_startDelay(){} // RVA: 0x7FFAF9C5C310
        public void get_loop(){} // RVA: 0x7FFAF9C5C3C0
        public void set_loop(){} // RVA: 0x7FFAF9C5C470
        public void get_playOnAwake(){} // RVA: 0x7FFAF9C5C520
        public void set_playOnAwake(){} // RVA: 0x7FFAF9C5C5D0
        public void get_duration(){} // RVA: 0x7FFAF9C5C680
        public void get_playbackSpeed(){} // RVA: 0x7FFAF9C5C730
        public void set_playbackSpeed(){} // RVA: 0x7FFAF9C5C7E0
        public void get_enableEmission(){} // RVA: 0x7FFAF9C5C890
        public void set_enableEmission(){} // RVA: 0x7FFAF9C5C940
        public void get_emissionRate(){} // RVA: 0x7FFAF9C5C9F0
        public void set_emissionRate(){} // RVA: 0x7FFAF9C5CAA0
        public void get_startSpeed(){} // RVA: 0x7FFAF9C5CB80
        public void set_startSpeed(){} // RVA: 0x7FFAF9C5CC30
        public void get_startSize(){} // RVA: 0x7FFAF9C5CCE0
        public void set_startSize(){} // RVA: 0x7FFAF9C5CD90
        public void get_startColor(){} // RVA: 0x7FFAF9C5CE40
        public void set_startColor(){} // RVA: 0x7FFAF9C5CF20
        public void get_startRotation(){} // RVA: 0x7FFAF9C5D030
        public void set_startRotation(){} // RVA: 0x7FFAF9C5D0E0
        public void get_startRotation3D(){} // RVA: 0x7FFAF9C5D190
        public void set_startRotation3D(){} // RVA: 0x7FFAF9C5D3C0
        public void get_startLifetime(){} // RVA: 0x7FFAF9C5D500
        public void set_startLifetime(){} // RVA: 0x7FFAF9C5D5B0
        public void get_gravityModifier(){} // RVA: 0x7FFAF9C5D660
        public void set_gravityModifier(){} // RVA: 0x7FFAF9C5D710
        public void get_maxParticles(){} // RVA: 0x7FFAF9C5D7C0
        public void set_maxParticles(){} // RVA: 0x7FFAF9C5D870
        public void get_simulationSpace(){} // RVA: 0x7FFAF9C5D920
        public void set_simulationSpace(){} // RVA: 0x7FFAF9C5D9D0
        public void get_scalingMode(){} // RVA: 0x7FFAF9C5DA80
        public void set_scalingMode(){} // RVA: 0x7FFAF9C5DB30
        public void get_automaticCullingEnabled(){} // RVA: 0x7FFAF9C5DBE0
        public void get_isPlaying(){} // RVA: 0x7FFAF9C5DC30
        public void get_isEmitting(){} // RVA: 0x7FFAF9C5DC80
        public void get_isStopped(){} // RVA: 0x7FFAF9C5DCD0
        public void get_isPaused(){} // RVA: 0x7FFAF9C5DD20
        public void get_particleCount(){} // RVA: 0x7FFAF9C5DD70
        public void get_time(){} // RVA: 0x7FFAF9C5DDC0
        public void set_time(){} // RVA: 0x7FFAF9C5DE10
        public void get_totalTime(){} // RVA: 0x7FFAF9C5DE70
        public void get_randomSeed(){} // RVA: 0x7FFAF9C5DEC0
        public void set_randomSeed(){} // RVA: 0x7FFAF9C5DF10
        public void get_useAutoRandomSeed(){} // RVA: 0x7FFAF9C5DF70
        public void set_useAutoRandomSeed(){} // RVA: 0x7FFAF9C5DFC0
        public void get_proceduralSimulationSupported(){} // RVA: 0x7FFAF9C5DBE0
        public void GetParticleCurrentSize(){} // RVA: 0x7FFAF9C5E020
        public void GetParticleCurrentSize3D(){} // RVA: 0x7FFAF9C5E080
        public void GetParticleCurrentColor(){} // RVA: 0x7FFAF9C5E100
        public void GetParticleMeshIndex(){} // RVA: 0x7FFAF9C5E170
        public void SetParticles(){} // RVA: 0x7FFAF9C5E480 | overloaded x6
        public void SetParticlesWithNativeArray(){} // RVA: 0x7FFAF9C5E290
        public void GetParticles(){} // RVA: 0x7FFAF9C5E7D0 | overloaded x6
        public void GetParticlesWithNativeArray(){} // RVA: 0x7FFAF9C5E5E0
        public void SetCustomParticleData(){} // RVA: 0x7FFAF9C5E870
        public void GetCustomParticleData(){} // RVA: 0x7FFAF9C5E8E0
        public void GetPlaybackState(){} // RVA: 0x7FFAF9C5E950
        public void SetPlaybackState(){} // RVA: 0x7FFAF9C5E9C0
        public void GetTrailDataInternal(){} // RVA: 0x7FFAF9C5EA20
        public void GetTrails(){} // RVA: 0x7FFAF9C5EB30 | overloaded x2
        public void SetTrails(){} // RVA: 0x7FFAF9C5EBD0
        public void Simulate(){} // RVA: 0x7FFAF9C5ED00 | overloaded x4
        public void Play(){} // RVA: 0x7FFAF9C5ED90 | overloaded x2
        public void Pause(){} // RVA: 0x7FFAF9C5EE50 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAF9C5EF90 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAF9C5F050 | overloaded x2
        public void IsAlive(){} // RVA: 0x7FFAF9C5F110 | overloaded x2
        public void Emit_Internal(){} // RVA: 0x7FFAF9C5F170
        public void EmitOld_Internal(){} // RVA: 0x7FFAF9C5F240
        public void TriggerSubEmitter(){} // RVA: 0x7FFAF9C5F440 | overloaded x3
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7FFAF9C5F3D0
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7FFAF9C5F4B0
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7FFAF9C5F500
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7FFAF9C5F560
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7FFAF9C5F5B0
        public void AllocateCustomDataAttribute(){} // RVA: 0x7FFAF9C5F600
        public void get_has3DParticleRotations(){} // RVA: 0x7FFAF9C5F660
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7FFAF9C5F6B0
        public void GetManagedJobData(){} // RVA: 0x7FFAF9C5F700
        public void GetManagedJobHandle(){} // RVA: 0x7FFAF9C5F750
        public void SetManagedJobHandle(){} // RVA: 0x7FFAF9C5F7C0
        public void ScheduleManagedJob(){} // RVA: 0x7FFAF9C5F820
        public void CopyManagedJobData(){} // RVA: 0x7FFAF9C5F8A0
        public void get_main(){} // RVA: 0x7FFAF3AB73D0
        public void get_emission(){} // RVA: 0x7FFAF3AB73D0
        public void get_shape(){} // RVA: 0x7FFAF3AB73D0
        public void get_velocityOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_limitVelocityOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_inheritVelocity(){} // RVA: 0x7FFAF3AB73D0
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x7FFAF3AB73D0
        public void get_forceOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_colorOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_colorBySpeed(){} // RVA: 0x7FFAF3AB73D0
        public void get_sizeOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_sizeBySpeed(){} // RVA: 0x7FFAF3AB73D0
        public void get_rotationOverLifetime(){} // RVA: 0x7FFAF3AB73D0
        public void get_rotationBySpeed(){} // RVA: 0x7FFAF3AB73D0
        public void get_externalForces(){} // RVA: 0x7FFAF3AB73D0
        public void get_noise(){} // RVA: 0x7FFAF3AB73D0
        public void get_collision(){} // RVA: 0x7FFAF3AB73D0
        public void get_trigger(){} // RVA: 0x7FFAF3AB73D0
        public void get_subEmitters(){} // RVA: 0x7FFAF3AB73D0
        public void get_textureSheetAnimation(){} // RVA: 0x7FFAF3AB73D0
        public void get_lights(){} // RVA: 0x7FFAF3AB73D0
        public void get_trails(){} // RVA: 0x7FFAF3AB73D0
        public void get_customData(){} // RVA: 0x7FFAF3AB73D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7FFAF9C5F900
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7FFAF9C5F970
        public void GetPlaybackState_Injected(){} // RVA: 0x7FFAF9C5F9E0
        public void SetPlaybackState_Injected(){} // RVA: 0x7FFAF9C5FA40
        public void SetTrails_Injected(){} // RVA: 0x7FFAF9C5FAA0
        public void Emit_Injected(){} // RVA: 0x7FFAF9C5FB00
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7FFAF9C5FB70
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7FFAF9C5FBE0
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7FFAF9C5FC40
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7FFAF9C5FCA0
    }

    public class ParticleSystemExtensionsImpl
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFAF9C75760
    }

    public class ParticleSystemForceField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ParticleSystemRenderer
    {
        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x7FFAF9C757D0
        public void DisableVertexStreams(){} // RVA: 0x7FFAF9C757E0
        public void AreVertexStreamsEnabled(){} // RVA: 0x7FFAF9C757F0
        public void GetEnabledVertexStreams(){} // RVA: 0x7FFAF9C75810
        public void Internal_SetVertexStreams(){} // RVA: 0x7FFAF9C75820
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7FFAF9C75F00
        public void BakeMesh(){} // RVA: 0x7FFAF9C77840 | overloaded x4
        public void BakeTrailsMesh(){} // RVA: 0x7FFAF9C77940 | overloaded x4
        public void get_alignment(){} // RVA: 0x7FFAF9C76680
        public void set_alignment(){} // RVA: 0x7FFAF9C766D0
        public void get_renderMode(){} // RVA: 0x7FFAF9C76730
        public void set_renderMode(){} // RVA: 0x7FFAF9C76780
        public void get_meshDistribution(){} // RVA: 0x7FFAF9C767E0
        public void set_meshDistribution(){} // RVA: 0x7FFAF9C76830
        public void get_sortMode(){} // RVA: 0x7FFAF9C76890
        public void set_sortMode(){} // RVA: 0x7FFAF9C768E0
        public void get_lengthScale(){} // RVA: 0x7FFAF9C76940
        public void set_lengthScale(){} // RVA: 0x7FFAF9C76990
        public void get_velocityScale(){} // RVA: 0x7FFAF9C769F0
        public void set_velocityScale(){} // RVA: 0x7FFAF9C76A40
        public void get_cameraVelocityScale(){} // RVA: 0x7FFAF9C76AA0
        public void set_cameraVelocityScale(){} // RVA: 0x7FFAF9C76AF0
        public void get_normalDirection(){} // RVA: 0x7FFAF9C76B50
        public void set_normalDirection(){} // RVA: 0x7FFAF9C76BA0
        public void get_shadowBias(){} // RVA: 0x7FFAF9C76C00
        public void set_shadowBias(){} // RVA: 0x7FFAF9C76C50
        public void get_sortingFudge(){} // RVA: 0x7FFAF9C76CB0
        public void set_sortingFudge(){} // RVA: 0x7FFAF9C76D00
        public void get_minParticleSize(){} // RVA: 0x7FFAF9C76D60
        public void set_minParticleSize(){} // RVA: 0x7FFAF9C76DB0
        public void get_maxParticleSize(){} // RVA: 0x7FFAF9C76E10
        public void set_maxParticleSize(){} // RVA: 0x7FFAF9C76E60
        public void get_pivot(){} // RVA: 0x7FFAF9C76EC0
        public void set_pivot(){} // RVA: 0x7FFAF9C76F30
        public void get_flip(){} // RVA: 0x7FFAF9C76F90
        public void set_flip(){} // RVA: 0x7FFAF9C77000
        public void get_maskInteraction(){} // RVA: 0x7FFAF9C77060
        public void set_maskInteraction(){} // RVA: 0x7FFAF9C770B0
        public void get_trailMaterial(){} // RVA: 0x7FFAF9C77110
        public void set_trailMaterial(){} // RVA: 0x7FFAF9C77160
        public void set_oldTrailMaterial(){} // RVA: 0x7FFAF9C771C0
        public void get_enableGPUInstancing(){} // RVA: 0x7FFAF9C77220
        public void set_enableGPUInstancing(){} // RVA: 0x7FFAF9C77270
        public void get_allowRoll(){} // RVA: 0x7FFAF9C772D0
        public void set_allowRoll(){} // RVA: 0x7FFAF9C77320
        public void get_freeformStretching(){} // RVA: 0x7FFAF9C77380
        public void set_freeformStretching(){} // RVA: 0x7FFAF9C773D0
        public void get_rotateWithStretchDirection(){} // RVA: 0x7FFAF9C77430
        public void set_rotateWithStretchDirection(){} // RVA: 0x7FFAF9C77480
        public void get_mesh(){} // RVA: 0x7FFAF9C774E0
        public void set_mesh(){} // RVA: 0x7FFAF9C77530
        public void GetMeshes(){} // RVA: 0x7FFAF9C77590
        public void SetMeshes(){} // RVA: 0x7FFAF9C77660 | overloaded x2
        public void GetMeshWeightings(){} // RVA: 0x7FFAF9C77680
        public void SetMeshWeightings(){} // RVA: 0x7FFAF9C77750 | overloaded x2
        public void get_meshCount(){} // RVA: 0x7FFAF9C77770
        public void BakeTexture(){} // RVA: 0x7FFAF9C77F60 | overloaded x4
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7FFAF9C77D10
        public void BakeTextureInternal(){} // RVA: 0x7FFAF9C780D0
        public void BakeTrailsTexture(){} // RVA: 0x7FFAF9C78340 | overloaded x2
        public void BakeTrailsTextureInternal(){} // RVA: 0x7FFAF9C784B0
        public void get_activeVertexStreamsCount(){} // RVA: 0x7FFAF9C78560
        public void SetActiveVertexStreams(){} // RVA: 0x7FFAF9C785B0
        public void GetActiveVertexStreams(){} // RVA: 0x7FFAF9C78610
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7FFAF9C78670
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7FFAF9C786C0
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7FFAF9C78720
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_pivot_Injected(){} // RVA: 0x7FFAF9C78780
        public void set_pivot_Injected(){} // RVA: 0x7FFAF9C787E0
        public void get_flip_Injected(){} // RVA: 0x7FFAF9C78840
        public void set_flip_Injected(){} // RVA: 0x7FFAF9C788A0
        public void BakeTextureInternal_Injected(){} // RVA: 0x7FFAF9C78900
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7FFAF9C78990
    }

    public class PenData
    {
    }

    public class PhysicMaterial
    {
        public object bounciness;
        public object friction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CABFD0 | overloaded x2
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7FFAF9CAC070
        public void get_bounciness(){} // RVA: 0x7FFAF9CAC0D0
        public void set_bounciness(){} // RVA: 0x7FFAF9CAC120
        public void get_dynamicFriction(){} // RVA: 0x7FFAF9CAC180
        public void set_dynamicFriction(){} // RVA: 0x7FFAF9CAC1D0
        public void get_staticFriction(){} // RVA: 0x7FFAF9CAC230
        public void set_staticFriction(){} // RVA: 0x7FFAF9CAC280
        public void get_frictionCombine(){} // RVA: 0x7FFAF9CAC2E0
        public void set_frictionCombine(){} // RVA: 0x7FFAF9CAC330
        public void get_bounceCombine(){} // RVA: 0x7FFAF9CAC390
        public void set_bounceCombine(){} // RVA: 0x7FFAF9CAC3E0
    }

    public class Physics
    {
        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7FFAF9CA0AA0
        public void get_gravity(){} // RVA: 0x7FFAF9CA0B90
        public void set_gravity(){} // RVA: 0x7FFAF9CA0C20
        public void get_bounceThreshold(){} // RVA: 0x7FFAF9CA0CB0
        public void set_bounceThreshold(){} // RVA: 0x7FFAF9CA0D00
        public void get_simulationMode(){} // RVA: 0x7FFAF9CA0D60
        public void set_simulationMode(){} // RVA: 0x7FFAF9CA0DB0
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7FFAF9CA0E00
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7FFAF9CA0E50
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7FFAF9CA0EB0
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFAF9CA0F00
        public void IgnoreCollision(){} // RVA: 0x7FFAF9CA1000 | overloaded x2
        public void IgnoreLayerCollision(){} // RVA: 0x7FFAF9CA1110 | overloaded x2
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFAF9CA11B0
        public void GetIgnoreCollision(){} // RVA: 0x7FFAF9CA1210
        public void Raycast(){} // RVA: 0x7FFAF9CA1E90 | overloaded x16
        public void Linecast(){} // RVA: 0x7FFAF9CA2390 | overloaded x6
        public void CapsuleCast(){} // RVA: 0x7FFAF9CA2C70 | overloaded x8
        public void SphereCast(){} // RVA: 0x7FFAF9CA3750 | overloaded x12
        public void BoxCast(){} // RVA: 0x7FFAF9CA4290 | overloaded x10
        public void Internal_RaycastAll(){} // RVA: 0x7FFAF9CA43C0
        public void RaycastAll(){} // RVA: 0x7FFAF9CA4AF0 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFAF9CA5150 | overloaded x8
        public void Query_CapsuleCastAll(){} // RVA: 0x7FFAF9CA5220
        public void CapsuleCastAll(){} // RVA: 0x7FFAF9CA56F0 | overloaded x4
        public void Query_SphereCastAll(){} // RVA: 0x7FFAF9CA57D0
        public void SphereCastAll(){} // RVA: 0x7FFAF9CA5F50 | overloaded x8
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFAF9CA6060
        public void OverlapCapsule(){} // RVA: 0x7FFAF9CA6320 | overloaded x3
        public void OverlapSphere_Internal(){} // RVA: 0x7FFAF9CA63D0
        public void OverlapSphere(){} // RVA: 0x7FFAF9CA6630 | overloaded x3
        public void Simulate_Internal(){} // RVA: 0x7FFAF9CA66C0
        public void Simulate(){} // RVA: 0x7FFAF9CA6760
        public void InterpolateBodies_Internal(){} // RVA: 0x7FFAF9CA6870
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7FFAF9CA6900
        public void SyncTransforms(){} // RVA: 0x7FFAF9CA6990
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFAF9CA69E0
        public void Query_ComputePenetration(){} // RVA: 0x7FFAF9CA6A30
        public void ComputePenetration(){} // RVA: 0x7FFAF9CA6B20
        public void Query_ClosestPoint(){} // RVA: 0x7FFAF9CA6CE0
        public void ClosestPoint(){} // RVA: 0x7FFAF9CA6DB0
        public void OverlapSphereNonAlloc(){} // RVA: 0x7FFAF9CA70A0 | overloaded x3
        public void CheckSphere_Internal(){} // RVA: 0x7FFAF9CA7130
        public void CheckSphere(){} // RVA: 0x7FFAF9CA7390 | overloaded x3
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFAF9CA7790 | overloaded x4
        public void SphereCastNonAlloc(){} // RVA: 0x7FFAF9CA7E90 | overloaded x8
        public void CheckCapsule_Internal(){} // RVA: 0x7FFAF9CA7F30
        public void CheckCapsule(){} // RVA: 0x7FFAF9CA81F0 | overloaded x3
        public void CheckBox_Internal(){} // RVA: 0x7FFAF9CA82A0
        public void CheckBox(){} // RVA: 0x7FFAF9CA86F0 | overloaded x4
        public void OverlapBox_Internal(){} // RVA: 0x7FFAF9CA8890
        public void OverlapBox(){} // RVA: 0x7FFAF9CA8CE0 | overloaded x4
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFAF9CA9240 | overloaded x4
        public void BoxCastNonAlloc(){} // RVA: 0x7FFAF9CA9A90 | overloaded x5
        public void Internal_BoxCastAll(){} // RVA: 0x7FFAF9CA9C80
        public void BoxCastAll(){} // RVA: 0x7FFAF9CAA240 | overloaded x5
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFAF9CAA530 | overloaded x3
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x7FFAF9CAA5F0
        public void RebuildBroadphaseRegions(){} // RVA: 0x7FFAF9CAA690
        public void BakeMesh(){} // RVA: 0x7FFAF9CAA8D0 | overloaded x2
        public void GetColliderByInstanceID(){} // RVA: 0x7FFAF9CAA970
        public void GetBodyByInstanceID(){} // RVA: 0x7FFAF9CAA9C0
        public void SendOnCollisionEnter(){} // RVA: 0x7FFAF9CAAA10
        public void SendOnCollisionStay(){} // RVA: 0x7FFAF9CAAA70
        public void SendOnCollisionExit(){} // RVA: 0x7FFAF9CAAAD0
        public void OnSceneContact(){} // RVA: 0x7FFAF9CAAB30
        public void ReportContacts(){} // RVA: 0x7FFAF9CAAD60
        public void GetCollisionToReport(){} // RVA: 0x7FFAF9CAB230
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9CAB540
        public void get_gravity_Injected(){} // RVA: 0x7FFAF9CAB610
        public void set_gravity_Injected(){} // RVA: 0x7FFAF9CAB660
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x7FFAF9CAB6B0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7FFAF9CAB700
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7FFAF9CAB790
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7FFAF9CAB820
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFAF9CAB8B0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7FFAF9CAB940
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFAF9CAB9D0
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7FFAF9CABA30
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7FFAF9CABA80
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7FFAF9CABAD0
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7FFAF9CABB60
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7FFAF9CABBF0
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7FFAF9CABC80
        public void CheckBox_Internal_Injected(){} // RVA: 0x7FFAF9CABD10
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFAF9CABDA0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7FFAF9CABE30
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x7FFAF9CABEC0
    }

    public class Physics2D
    {
        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFAF68BF620
        public void get_velocityIterations(){} // RVA: 0x7FFAF9C7E860
        public void set_velocityIterations(){} // RVA: 0x7FFAF9C7E8B0
        public void get_positionIterations(){} // RVA: 0x7FFAF9C7E900
        public void set_positionIterations(){} // RVA: 0x7FFAF9C7E950
        public void get_gravity(){} // RVA: 0x7FFAF9C7E9A0
        public void set_gravity(){} // RVA: 0x7FFAF9C7EA30
        public void get_queriesHitTriggers(){} // RVA: 0x7FFAF9C7EAC0
        public void get_queriesStartInColliders(){} // RVA: 0x7FFAF9C7EB10
        public void set_queriesStartInColliders(){} // RVA: 0x7FFAF9C7EB60
        public void get_callbacksOnDisable(){} // RVA: 0x7FFAF9C7EBB0
        public void set_callbacksOnDisable(){} // RVA: 0x7FFAF9C7EC00
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFAF9C7EC50
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7FFAF9C7ECA0
        public void get_velocityThreshold(){} // RVA: 0x7FFAF9C7ECF0
        public void set_velocityThreshold(){} // RVA: 0x7FFAF9C7ED40
        public void get_maxLinearCorrection(){} // RVA: 0x7FFAF9C7EDA0
        public void set_maxLinearCorrection(){} // RVA: 0x7FFAF9C7EDF0
        public void get_maxAngularCorrection(){} // RVA: 0x7FFAF9C7EE50
        public void set_maxAngularCorrection(){} // RVA: 0x7FFAF9C7EEA0
        public void get_maxTranslationSpeed(){} // RVA: 0x7FFAF9C7EF00
        public void set_maxTranslationSpeed(){} // RVA: 0x7FFAF9C7EF50
        public void get_maxRotationSpeed(){} // RVA: 0x7FFAF9C7EFB0
        public void set_maxRotationSpeed(){} // RVA: 0x7FFAF9C7F000
        public void get_baumgarteScale(){} // RVA: 0x7FFAF9C7F060
        public void set_baumgarteScale(){} // RVA: 0x7FFAF9C7F0B0
        public void get_baumgarteTOIScale(){} // RVA: 0x7FFAF9C7F110
        public void set_baumgarteTOIScale(){} // RVA: 0x7FFAF9C7F160
        public void get_timeToSleep(){} // RVA: 0x7FFAF9C7F1C0
        public void set_timeToSleep(){} // RVA: 0x7FFAF9C7F210
        public void get_linearSleepTolerance(){} // RVA: 0x7FFAF9C7F270
        public void set_linearSleepTolerance(){} // RVA: 0x7FFAF9C7F2C0
        public void get_angularSleepTolerance(){} // RVA: 0x7FFAF9C7F320
        public void set_angularSleepTolerance(){} // RVA: 0x7FFAF9C7F370
        public void Simulate(){} // RVA: 0x7FFAF9C7F3D0
        public void Simulate_Internal(){} // RVA: 0x7FFAF9C7F430
        public void SyncTransforms(){} // RVA: 0x7FFAF9C7F4D0
        public void IgnoreCollision(){} // RVA: 0x7FFAF9C7F5C0 | overloaded x2
        public void GetIgnoreCollision(){} // RVA: 0x7FFAF9C7F630
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFAF9C7F690
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7FFAF9C7F7D0
        public void SetLayerCollisionMask(){} // RVA: 0x7FFAF9C7F830
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7FFAF9C7F920
        public void GetLayerCollisionMask(){} // RVA: 0x7FFAF9C7F980
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7FFAF9C7FA60
        public void IsTouching(){} // RVA: 0x7FFAF9C7FCC0 | overloaded x3
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7FFAF9C7FC10
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7FFAF9C7FDB0
        public void IsTouchingLayers(){} // RVA: 0x7FFAF9C7FEE0 | overloaded x2
        public void Distance(){} // RVA: 0x7FFAF9C7FF40
        public void Distance_Internal(){} // RVA: 0x7FFAF9C802E0
        public void ClosestPoint(){} // RVA: 0x7FFAF9C80580 | overloaded x2
        public void ClosestPoint_Collider(){} // RVA: 0x7FFAF9C80760
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7FFAF9C80800
        public void Linecast(){} // RVA: 0x7FFAF9C80F50 | overloaded x6
        public void LinecastAll(){} // RVA: 0x7FFAF9C814B0 | overloaded x4
        public void LinecastAll_Internal(){} // RVA: 0x7FFAF9C81620
        public void LinecastNonAlloc(){} // RVA: 0x7FFAF9C81A00 | overloaded x4
        public void Raycast(){} // RVA: 0x7FFAF9C82490 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFAF9C829C0 | overloaded x5
        public void RaycastAll(){} // RVA: 0x7FFAF9C82F20 | overloaded x5
        public void RaycastAll_Internal(){} // RVA: 0x7FFAF9C83020
        public void CircleCast(){} // RVA: 0x7FFAF9C83AB0 | overloaded x8
        public void CircleCastAll(){} // RVA: 0x7FFAF9C84030 | overloaded x5
        public void CircleCastAll_Internal(){} // RVA: 0x7FFAF9C84140
        public void CircleCastNonAlloc(){} // RVA: 0x7FFAF9C84670 | overloaded x5
        public void BoxCast(){} // RVA: 0x7FFAF9C85270 | overloaded x8
        public void BoxCastAll(){} // RVA: 0x7FFAF9C85860 | overloaded x5
        public void BoxCastAll_Internal(){} // RVA: 0x7FFAF9C85980
        public void BoxCastNonAlloc(){} // RVA: 0x7FFAF9C85F40 | overloaded x5
        public void CapsuleCast(){} // RVA: 0x7FFAF9C86B90 | overloaded x8
        public void CapsuleCastAll(){} // RVA: 0x7FFAF9C87290 | overloaded x5
        public void CapsuleCastAll_Internal(){} // RVA: 0x7FFAF9C86F50
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFAF9C878C0 | overloaded x5
        public void GetRayIntersection(){} // RVA: 0x7FFAF9C87D20 | overloaded x3
        public void GetRayIntersectionAll(){} // RVA: 0x7FFAF9C880A0 | overloaded x3
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7FFAF9C881C0
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7FFAF9C88490 | overloaded x3
        public void OverlapPoint(){} // RVA: 0x7FFAF9C88A30 | overloaded x6
        public void OverlapPointAll(){} // RVA: 0x7FFAF9C88F20 | overloaded x4
        public void OverlapPointAll_Internal(){} // RVA: 0x7FFAF9C89070
        public void OverlapPointNonAlloc(){} // RVA: 0x7FFAF9C893F0 | overloaded x4
        public void OverlapCircle(){} // RVA: 0x7FFAF9C89A30 | overloaded x6
        public void OverlapCircleAll(){} // RVA: 0x7FFAF9C89F60 | overloaded x4
        public void OverlapCircleAll_Internal(){} // RVA: 0x7FFAF9C8A0C0
        public void OverlapCircleNonAlloc(){} // RVA: 0x7FFAF9C8A480 | overloaded x4
        public void OverlapBox(){} // RVA: 0x7FFAF9C8AB80 | overloaded x6
        public void OverlapBoxAll(){} // RVA: 0x7FFAF9C8AFB0 | overloaded x4
        public void OverlapBoxAll_Internal(){} // RVA: 0x7FFAF9C8B0B0
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFAF9C8B4E0 | overloaded x4
        public void OverlapArea(){} // RVA: 0x7FFAF9C8BAE0 | overloaded x6
        public void OverlapAreaAll(){} // RVA: 0x7FFAF9C8BD80 | overloaded x4
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7FFAF9C8BE20
        public void OverlapAreaNonAlloc(){} // RVA: 0x7FFAF9C8C280 | overloaded x4
        public void OverlapCapsule(){} // RVA: 0x7FFAF9C8C9A0 | overloaded x6
        public void OverlapCapsuleAll(){} // RVA: 0x7FFAF9C8CF90 | overloaded x4
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7FFAF9C8D130
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFAF9C8D590 | overloaded x4
        public void OverlapCollider(){} // RVA: 0x7FFAF9C7D5F0 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFAF9C8EDA0 | overloaded x18
        public void GetColliderContactsArray(){} // RVA: 0x7FFAF9C8E110
        public void GetColliderColliderContactsArray(){} // RVA: 0x7FFAF9C8E1C0
        public void GetRigidbodyContactsArray(){} // RVA: 0x7FFAF9C8E280
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7FFAF9C8E330
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7FFAF9C8E3E0
        public void GetColliderContactsList(){} // RVA: 0x7FFAF9C8EEA0
        public void GetColliderColliderContactsList(){} // RVA: 0x7FFAF9C8EF50
        public void GetRigidbodyContactsList(){} // RVA: 0x7FFAF9C8F010
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7FFAF9C8F0C0
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7FFAF9C8F170
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9C8F220
        public void get_gravity_Injected(){} // RVA: 0x7FFAF9C8F300
        public void set_gravity_Injected(){} // RVA: 0x7FFAF9C8F350
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFAF9C8F3A0
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7FFAF9C8F400
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7FFAF9C8F470
        public void Distance_Internal_Injected(){} // RVA: 0x7FFAF9C8F4D0
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7FFAF9C8F540
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7FFAF9C8F5B0
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F620
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F6A0
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F730
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F7C0
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F850
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F8E0
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F970
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7FFAF9C8F9E0
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7FFAF9C8FA60
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7FFAF9C8FAF0
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7FFAF9C8FB80
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7FFAF9C8FBF0
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7FFAF9C8FC70
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFAF9C8FCE0
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFAF9C8FD50
        public void GetColliderContactsList_Injected(){} // RVA: 0x7FFAF9C8FDC0
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7FFAF9C8FE30
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7FFAF9C8FEB0
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFAF9C8FF20
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFAF9C8FF90
    }

    public class PhysicsMaterial2D
    {
        public object maximumChunksOverride;
        public object maximumLOD;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9C9F950
        public void Create_Internal(){} // RVA: 0x7FFAF9C9F9E0
        public void get_bounciness(){} // RVA: 0x7FFAF9C9FA40
        public void set_bounciness(){} // RVA: 0x7FFAF9C9FA90
        public void get_friction(){} // RVA: 0x7FFAF9C9FAF0
        public void set_friction(){} // RVA: 0x7FFAF9C9FB40
    }

    public class PhysicsScene
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF9CB82F0
        public void op_Equality(){} // RVA: 0x7FFAF9BCFA10
        public void op_Inequality(){} // RVA: 0x7FFAF9BF9740
        public void GetHashCode(){} // RVA: 0x7FFAF92AD0D0
        public void Equals(){} // RVA: 0x7FFAF9B6C7E0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAF9CB8460
        public void IsValid_Internal(){} // RVA: 0x7FFAF9CB84C0
        public void IsEmpty(){} // RVA: 0x7FFAF9CB8510
        public void IsEmpty_Internal(){} // RVA: 0x7FFAF9CB8600
        public void Simulate(){} // RVA: 0x7FFAF9CB8650
        public void InterpolateBodies(){} // RVA: 0x7FFAF9CB8830
        public void ResetInterpolationPoses(){} // RVA: 0x7FFAF9CB8A20
        public void Raycast(){} // RVA: 0x7FFAF9CB9130 | overloaded x3
        public void Internal_RaycastTest(){} // RVA: 0x7FFAF9CB8E00
        public void Internal_Raycast(){} // RVA: 0x7FFAF9CB90A0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7FFAF9CB9300
        public void Query_CapsuleCast(){} // RVA: 0x7FFAF9CB9390
        public void Internal_CapsuleCast(){} // RVA: 0x7FFAF9CB9450
        public void CapsuleCast(){} // RVA: 0x7FFAF9CB9810 | overloaded x2
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7FFAF9CB9750
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7FFAF9CB9950
        public void OverlapCapsule(){} // RVA: 0x7FFAF9CB99F0
        public void Query_SphereCast(){} // RVA: 0x7FFAF9CB9AB0
        public void Internal_SphereCast(){} // RVA: 0x7FFAF9CB9B60
        public void SphereCast(){} // RVA: 0x7FFAF9CB9EB0 | overloaded x2
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7FFAF9CB9E00
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7FFAF9CB9FC0
        public void OverlapSphere(){} // RVA: 0x7FFAF9CBA050
        public void Query_BoxCast(){} // RVA: 0x7FFAF9CBA0F0
        public void Internal_BoxCast(){} // RVA: 0x7FFAF9CBA1B0
        public void BoxCast(){} // RVA: 0x7FFAF9CBAB00 | overloaded x4
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7FFAF9CBA680
        public void OverlapBox(){} // RVA: 0x7FFAF9CBA7F0 | overloaded x2
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7FFAF9CBA900
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFAF9CBAC80
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFAF9CBACD0
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7FFAF9CBAD20
        public void Internal_Raycast_Injected(){} // RVA: 0x7FFAF9CBADB0
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7FFAF9CBAE40
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7FFAF9CBAED0
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7FFAF9CBAF60
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7FFAF9CBAFF0
        public void Query_SphereCast_Injected(){} // RVA: 0x7FFAF9CBB080
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7FFAF9CBB110
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7FFAF9CBB1A0
        public void Query_BoxCast_Injected(){} // RVA: 0x7FFAF9CBB230
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7FFAF9CBB2C0
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7FFAF9CBB350
    }

    public class PhysicsScene2D
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF9C78AC0
        public void op_Equality(){} // RVA: 0x7FFAF9BCFA10
        public void op_Inequality(){} // RVA: 0x7FFAF9BF9740
        public void GetHashCode(){} // RVA: 0x7FFAF92AD0D0
        public void Equals(){} // RVA: 0x7FFAF9B6C7E0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAF9C78C30
        public void IsValid_Internal(){} // RVA: 0x7FFAF9C78C90
        public void IsEmpty(){} // RVA: 0x7FFAF9C78CE0
        public void IsEmpty_Internal(){} // RVA: 0x7FFAF9C78DD0
        public void Simulate(){} // RVA: 0x7FFAF9C78E20
        public void Linecast(){} // RVA: 0x7FFAF9C79420 | overloaded x5
        public void Linecast_Internal(){} // RVA: 0x7FFAF9C79160
        public void LinecastArray_Internal(){} // RVA: 0x7FFAF9C793A0
        public void LinecastNonAllocList_Internal(){} // RVA: 0x7FFAF9C794C0
        public void Raycast(){} // RVA: 0x7FFAF9C79AC0 | overloaded x5
        public void Raycast_Internal(){} // RVA: 0x7FFAF9C797A0
        public void RaycastArray_Internal(){} // RVA: 0x7FFAF9C79A20
        public void RaycastList_Internal(){} // RVA: 0x7FFAF9C79B80
        public void CircleCast(){} // RVA: 0x7FFAF9C7A200 | overloaded x5
        public void CircleCast_Internal(){} // RVA: 0x7FFAF9C79EC0
        public void CircleCastArray_Internal(){} // RVA: 0x7FFAF9C7A160
        public void CircleCastList_Internal(){} // RVA: 0x7FFAF9C7A2D0
        public void BoxCast(){} // RVA: 0x7FFAF9C7A9E0 | overloaded x5
        public void BoxCast_Internal(){} // RVA: 0x7FFAF9C7A640
        public void BoxCastArray_Internal(){} // RVA: 0x7FFAF9C7A930
        public void BoxCastList_Internal(){} // RVA: 0x7FFAF9C7AAD0
        public void CapsuleCast(){} // RVA: 0x7FFAF9C7B240 | overloaded x5
        public void CapsuleCast_Internal(){} // RVA: 0x7FFAF9C7AE70
        public void CapsuleCastArray_Internal(){} // RVA: 0x7FFAF9C7B180
        public void CapsuleCastList_Internal(){} // RVA: 0x7FFAF9C7B330
        public void GetRayIntersection(){} // RVA: 0x7FFAF9C7B590 | overloaded x2
        public void GetRayIntersection_Internal(){} // RVA: 0x7FFAF9C7B4F0
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x7FFAF9C7B640
        public void OverlapPoint(){} // RVA: 0x7FFAF9C7BA80 | overloaded x5
        public void OverlapPoint_Internal(){} // RVA: 0x7FFAF9C7B820
        public void OverlapPointArray_Internal(){} // RVA: 0x7FFAF9C7BA00
        public void OverlapPointList_Internal(){} // RVA: 0x7FFAF9C7BB10
        public void OverlapCircle(){} // RVA: 0x7FFAF9C7BFC0 | overloaded x5
        public void OverlapCircle_Internal(){} // RVA: 0x7FFAF9C7BD00
        public void OverlapCircleArray_Internal(){} // RVA: 0x7FFAF9C7BF30
        public void OverlapCircleList_Internal(){} // RVA: 0x7FFAF9C7C070
        public void OverlapBox(){} // RVA: 0x7FFAF9C7C5C0 | overloaded x5
        public void OverlapBox_Internal(){} // RVA: 0x7FFAF9C7C2B0
        public void OverlapBoxArray_Internal(){} // RVA: 0x7FFAF9C7C520
        public void OverlapBoxList_Internal(){} // RVA: 0x7FFAF9C7C680
        public void OverlapArea(){} // RVA: 0x7FFAF9C7CC30 | overloaded x5
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x7FFAF9C7CA90 | overloaded x2
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x7FFAF9C7CC80
        public void OverlapCapsule(){} // RVA: 0x7FFAF9C7D2F0 | overloaded x5
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFAF9C7CFE0
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x7FFAF9C7D250
        public void OverlapCapsuleList_Internal(){} // RVA: 0x7FFAF9C7D3B0
        public void OverlapCollider(){} // RVA: 0x7FFAF9C7D5F0 | overloaded x3
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFAF9C7D580
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFAF9C7D670
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFAF9C7D6E0
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFAF9C7D730
        public void Linecast_Internal_Injected(){} // RVA: 0x7FFAF9C7D780
        public void LinecastArray_Internal_Injected(){} // RVA: 0x7FFAF9C7D810
        public void LinecastNonAllocList_Internal_Injected(){} // RVA: 0x7FFAF9C7D8A0
        public void Raycast_Internal_Injected(){} // RVA: 0x7FFAF9C7D930
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFAF9C7D9C0
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFAF9C7DA50
        public void CircleCast_Internal_Injected(){} // RVA: 0x7FFAF9C7DAE0
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x7FFAF9C7DB70
        public void CircleCastList_Internal_Injected(){} // RVA: 0x7FFAF9C7DC00
        public void BoxCast_Internal_Injected(){} // RVA: 0x7FFAF9C7DC90
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x7FFAF9C7DD20
        public void BoxCastList_Internal_Injected(){} // RVA: 0x7FFAF9C7DDB0
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x7FFAF9C7DE40
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x7FFAF9C7DED0
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x7FFAF9C7DF60
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x7FFAF9C7DFF0
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E080
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x7FFAF9C7E110
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E180
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x7FFAF9C7E200
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x7FFAF9C7E280
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E300
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x7FFAF9C7E390
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFAF9C7E420
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E4B0
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x7FFAF9C7E540
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFAF9C7E5D0
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E660
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x7FFAF9C7E6F0
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFAF9C7E780
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFAF9C7E7F0
    }

    public class PhysicsShape2D
    {
    }

    public class PhysicsShapeGroup2D
    {
    }

    public class PhysicsUpdateBehaviour2D
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Plane
    {
        // ── Methods ──
        public void get_normal(){} // RVA: 0x7FFAF9B29450
        public void set_normal(){} // RVA: 0x7FFAF4BBE450
        public void get_distance(){} // RVA: 0x7FFAF2DB0D00
        public void set_distance(){} // RVA: 0x7FFAF4A28380
        public void .ctor(){} // RVA: 0x7FFAF8C73A00 | overloaded x3
        public void SetNormalAndPosition(){} // RVA: 0x7FFAF2F31C20
        public void Set3Points(){} // RVA: 0x7FFAF8C73A00
        public void Flip(){} // RVA: 0x7FFAF9B7D360
        public void get_flipped(){} // RVA: 0x7FFAF9B7D3B0
        public void Translate(){} // RVA: 0x7FFAF9B7D520 | overloaded x2
        public void ClosestPointOnPlane(){} // RVA: 0x7FFAF9B7D630
        public void GetDistanceToPoint(){} // RVA: 0x7FFAF9B7D6C0
        public void GetSide(){} // RVA: 0x7FFAF9B7D710
        public void SameSide(){} // RVA: 0x7FFAF9B7D760
        public void Raycast(){} // RVA: 0x7FFAF343A560
        public void ToString(){} // RVA: 0x7FFAF9B7D820 | overloaded x3
    }

    public class PlatformEffector2D
    {
        public object forceMagnitude;
        public object forceVariation;
        public object distanceScale;
        public object drag;
        public object angularDrag;
        public object forceSource;
        public object forceTarget;

        // ── Methods ──
        public void get_useOneWay(){} // RVA: 0x7FFAF9C9ECB0
        public void set_useOneWay(){} // RVA: 0x7FFAF9C9ED00
        public void get_useOneWayGrouping(){} // RVA: 0x7FFAF9C9ED60
        public void set_useOneWayGrouping(){} // RVA: 0x7FFAF9C9EDB0
        public void get_useSideFriction(){} // RVA: 0x7FFAF9C9EE10
        public void set_useSideFriction(){} // RVA: 0x7FFAF9C9EE60
        public void get_useSideBounce(){} // RVA: 0x7FFAF9C9EEC0
        public void set_useSideBounce(){} // RVA: 0x7FFAF9C9EF10
        public void get_surfaceArc(){} // RVA: 0x7FFAF9C9EF70
        public void set_surfaceArc(){} // RVA: 0x7FFAF9C9EFC0
        public void get_sideArc(){} // RVA: 0x7FFAF9C9F020
        public void set_sideArc(){} // RVA: 0x7FFAF9C9F070
        public void get_rotationalOffset(){} // RVA: 0x7FFAF9C9F0D0
        public void set_rotationalOffset(){} // RVA: 0x7FFAF9C9F120
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class PlayerConnectionInternal
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x7FFAF9BCEB10
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x7FFAF9BCEC70
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x7FFAF9BCEDD0
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x7FFAF9BCEE20
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x7FFAF9BCEEB0
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x7FFAF9BCEF40
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x7FFAF9BCEF90
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x7FFAF9BCEFE0
        public void IsConnected(){} // RVA: 0x7FFAF9BCEF90
        public void Initialize(){} // RVA: 0x7FFAF9BCEF40
        public void RegisterInternal(){} // RVA: 0x7FFAF9BCF030
        public void UnregisterInternal(){} // RVA: 0x7FFAF9BCF080
        public void SendMessage(){} // RVA: 0x7FFAF9BCF0D0
        public void TrySendMessage(){} // RVA: 0x7FFAF9BCF140
        public void PollInternal(){} // RVA: 0x7FFAF9BCEDD0
        public void DisconnectAll(){} // RVA: 0x7FFAF9BCEFE0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PlayerPrefs
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x7FFAF9BCF210
        public void TrySetFloat(){} // RVA: 0x7FFAF9BCF270
        public void TrySetSetString(){} // RVA: 0x7FFAF9BCF2D0
        public void SetInt(){} // RVA: 0x7FFAF9BCF330
        public void GetInt(){} // RVA: 0x7FFAF9BCF440 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAF9BCF4A0
        public void GetFloat(){} // RVA: 0x7FFAF9BCF5B0 | overloaded x2
        public void SetString(){} // RVA: 0x7FFAF9BCF610
        public void GetString(){} // RVA: 0x7FFAF9BCF720 | overloaded x2
        public void HasKey(){} // RVA: 0x7FFAF3F0EC40
        public void DeleteKey(){} // RVA: 0x7FFAF9BCF7B0
        public void DeleteAll(){} // RVA: 0x7FFAF9BCF800
        public void Save(){} // RVA: 0x7FFAF3F0EB90
    }

    public class PlayerPrefsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BCF1B0
    }

    public class PointEffector2D
    {
        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x7FFAF9C9E730
        public void set_forceMagnitude(){} // RVA: 0x7FFAF9C9E780
        public void get_forceVariation(){} // RVA: 0x7FFAF9C9E7E0
        public void set_forceVariation(){} // RVA: 0x7FFAF9C9E830
        public void get_distanceScale(){} // RVA: 0x7FFAF9C9E890
        public void set_distanceScale(){} // RVA: 0x7FFAF9C9E8E0
        public void get_drag(){} // RVA: 0x7FFAF9C9E940
        public void set_drag(){} // RVA: 0x7FFAF9C9E990
        public void get_angularDrag(){} // RVA: 0x7FFAF9C9E9F0
        public void set_angularDrag(){} // RVA: 0x7FFAF9C9EA40
        public void get_forceSource(){} // RVA: 0x7FFAF9C9EAA0
        public void set_forceSource(){} // RVA: 0x7FFAF9C9EAF0
        public void get_forceTarget(){} // RVA: 0x7FFAF9C9EB50
        public void set_forceTarget(){} // RVA: 0x7FFAF9C9EBA0
        public void get_forceMode(){} // RVA: 0x7FFAF9C9EC00
        public void set_forceMode(){} // RVA: 0x7FFAF9C9EC50
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class PolygonCollider2D
    {
        public object force;
        public object relativeForce;
        public object torque;
        public object relativeTorque;

        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7FFAF9C99E70
        public void set_useDelaunayMesh(){} // RVA: 0x7FFAF9C99EC0
        public void get_autoTiling(){} // RVA: 0x7FFAF9C99F20
        public void set_autoTiling(){} // RVA: 0x7FFAF9C99F70
        public void GetTotalPointCount(){} // RVA: 0x7FFAF9C99FD0
        public void get_points(){} // RVA: 0x7FFAF9C9A020
        public void set_points(){} // RVA: 0x7FFAF9C9A070
        public void get_pathCount(){} // RVA: 0x7FFAF9C9A0D0
        public void set_pathCount(){} // RVA: 0x7FFAF9C9A120
        public void GetPath(){} // RVA: 0x7FFAF9C9A4F0 | overloaded x2
        public void GetPath_Internal(){} // RVA: 0x7FFAF9C9A330
        public void SetPath(){} // RVA: 0x7FFAF9C9A730 | overloaded x2
        public void SetPath_Internal(){} // RVA: 0x7FFAF9C9A480
        public void GetPathList_Internal(){} // RVA: 0x7FFAF9C9A6C0
        public void SetPathList_Internal(){} // RVA: 0x7FFAF9C9A820
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class Pose
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF7475490
        public void ToString(){} // RVA: 0x7FFAF9BE5680
        public void GetTransformedBy(){} // RVA: 0x7FFAF9BE57A0
        public void get_identity(){} // RVA: 0x7FFAF9BE5AA0
        public void Equals(){} // RVA: 0x7FFAF9BE5BE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9BE5C90
        public void .cctor(){} // RVA: 0x7FFAF9BE5D70
    }

    public class PreferBinarySerialization
    {
    }

    public class PreloadData
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x7FFAF2D8D310
    }

    public class Projector
    {
        public object material;

        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x7FFAF9BA0A60
        public void set_nearClipPlane(){} // RVA: 0x7FFAF9BA0AB0
        public void get_farClipPlane(){} // RVA: 0x7FFAF9BA0B10
        public void set_farClipPlane(){} // RVA: 0x7FFAF9BA0B60
        public void get_fieldOfView(){} // RVA: 0x7FFAF9BA0BC0
        public void set_fieldOfView(){} // RVA: 0x7FFAF9BA0C10
        public void get_aspectRatio(){} // RVA: 0x7FFAF9BA0C70
        public void set_aspectRatio(){} // RVA: 0x7FFAF9BA0CC0
        public void get_orthographic(){} // RVA: 0x7FFAF9BA0D20
        public void set_orthographic(){} // RVA: 0x7FFAF9BA0D70
        public void get_orthographicSize(){} // RVA: 0x7FFAF9BA0DD0
        public void set_orthographicSize(){} // RVA: 0x7FFAF9BA0E20
        public void get_ignoreLayers(){} // RVA: 0x7FFAF9BA0E80
        public void set_ignoreLayers(){} // RVA: 0x7FFAF9BA0ED0
        public void get_material(){} // RVA: 0x7FFAF9BA0F30
        public void set_material(){} // RVA: 0x7FFAF9BA0F80
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PropertyName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x7FFAF9BCFA00
        public void op_Equality(){} // RVA: 0x7FFAF9BCFA10
        public void GetHashCode(){} // RVA: 0x7FFAF92AD0D0
        public void Equals(){} // RVA: 0x7FFAF9B6C7E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF9BCF8D0
        public void ToString(){} // RVA: 0x7FFAF9BCFAA0
    }

    public class PropertyNameUtils
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x7FFAF9BCF8D0
        public void PropertyNameFromString_Injected(){} // RVA: 0x7FFAF9BCF930
    }

}