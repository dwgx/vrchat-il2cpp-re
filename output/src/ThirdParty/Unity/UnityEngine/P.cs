// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 22
// Methods: 915

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent : ValueType
    {
        public object velocity;
        public object colliderComponent;

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFD54C50D10
        public void get_colliderComponent(){} // RVA: 0x7FFD54D80320
        public void InstanceIDToColliderComponent(){} // RVA: 0x7FFD54D80370
    }

    public class ParticleSystem : Component
    {
        public object startDelay;
        public object loop;
        public object playOnAwake;
        public object duration;
        public object playbackSpeed;
        public object enableEmission;
        public object emissionRate;
        public object startSpeed;
        public object startSize;
        public object startColor;
        public object startRotation;
        public object startRotation3D;
        public object startLifetime;
        public object gravityModifier;
        public object maxParticles;
        public object simulationSpace;
        public object scalingMode;
        public object automaticCullingEnabled;
        public object isPlaying;
        public object isEmitting;
        public object isStopped;
        public object isPaused;
        public object particleCount;
        public object time;
        public object totalTime;
        public object randomSeed;
        public object useAutoRandomSeed;
        public object proceduralSimulationSupported;
        public object has3DParticleRotations;
        public object hasNonUniformParticleSizes;
        public object main;
        public object emission;
        public object shape;
        public object velocityOverLifetime;
        public object limitVelocityOverLifetime;
        public object inheritVelocity;
        public object lifetimeByEmitterSpeed;
        public object forceOverLifetime;
        public object colorOverLifetime;
        public object colorBySpeed;
        public object sizeOverLifetime;
        public object sizeBySpeed;
        public object rotationOverLifetime;
        public object rotationBySpeed;
        public object externalForces;
        public object noise;
        public object collision;
        public object trigger;
        public object subEmitters;
        public object textureSheetAnimation;
        public object lights;
        public object trails;
        public object customData;

        // ── Methods ──
        public void Emit(){} // RVA: 0x7FFD54D66AD0 | overloaded x4
        public void get_startDelay(){} // RVA: 0x7FFD54D63B60
        public void set_startDelay(){} // RVA: 0x7FFD54D63C10
        public void get_loop(){} // RVA: 0x7FFD54D63CC0
        public void set_loop(){} // RVA: 0x7FFD54D63D70
        public void get_playOnAwake(){} // RVA: 0x7FFD54D63E20
        public void set_playOnAwake(){} // RVA: 0x7FFD54D63ED0
        public void get_duration(){} // RVA: 0x7FFD54D63F80
        public void get_playbackSpeed(){} // RVA: 0x7FFD54D64030
        public void set_playbackSpeed(){} // RVA: 0x7FFD54D640E0
        public void get_enableEmission(){} // RVA: 0x7FFD54D64190
        public void set_enableEmission(){} // RVA: 0x7FFD54D64240
        public void get_emissionRate(){} // RVA: 0x7FFD54D642F0
        public void set_emissionRate(){} // RVA: 0x7FFD54D643A0
        public void get_startSpeed(){} // RVA: 0x7FFD54D64480
        public void set_startSpeed(){} // RVA: 0x7FFD54D64530
        public void get_startSize(){} // RVA: 0x7FFD54D645E0
        public void set_startSize(){} // RVA: 0x7FFD54D64690
        public void get_startColor(){} // RVA: 0x7FFD54D64740
        public void set_startColor(){} // RVA: 0x7FFD54D64820
        public void get_startRotation(){} // RVA: 0x7FFD54D64930
        public void set_startRotation(){} // RVA: 0x7FFD54D649E0
        public void get_startRotation3D(){} // RVA: 0x7FFD54D64A90
        public void set_startRotation3D(){} // RVA: 0x7FFD54D64CC0
        public void get_startLifetime(){} // RVA: 0x7FFD54D64E00
        public void set_startLifetime(){} // RVA: 0x7FFD54D64EB0
        public void get_gravityModifier(){} // RVA: 0x7FFD54D64F60
        public void set_gravityModifier(){} // RVA: 0x7FFD54D65010
        public void get_maxParticles(){} // RVA: 0x7FFD54D650C0
        public void set_maxParticles(){} // RVA: 0x7FFD54D65170
        public void get_simulationSpace(){} // RVA: 0x7FFD54D65220
        public void set_simulationSpace(){} // RVA: 0x7FFD54D652D0
        public void get_scalingMode(){} // RVA: 0x7FFD54D65380
        public void set_scalingMode(){} // RVA: 0x7FFD54D65430
        public void get_automaticCullingEnabled(){} // RVA: 0x7FFD54D654E0
        public void get_isPlaying(){} // RVA: 0x7FFD54D65530
        public void get_isEmitting(){} // RVA: 0x7FFD54D65580
        public void get_isStopped(){} // RVA: 0x7FFD54D655D0
        public void get_isPaused(){} // RVA: 0x7FFD54D65620
        public void get_particleCount(){} // RVA: 0x7FFD54D65670
        public void get_time(){} // RVA: 0x7FFD54D656C0
        public void set_time(){} // RVA: 0x7FFD54D65710
        public void get_totalTime(){} // RVA: 0x7FFD54D65770
        public void get_randomSeed(){} // RVA: 0x7FFD54D657C0
        public void set_randomSeed(){} // RVA: 0x7FFD54D65810
        public void get_useAutoRandomSeed(){} // RVA: 0x7FFD54D65870
        public void set_useAutoRandomSeed(){} // RVA: 0x7FFD54D658C0
        public void get_proceduralSimulationSupported(){} // RVA: 0x7FFD54D654E0
        public void GetParticleCurrentSize(){} // RVA: 0x7FFD54D65920
        public void GetParticleCurrentSize3D(){} // RVA: 0x7FFD54D65980
        public void GetParticleCurrentColor(){} // RVA: 0x7FFD54D65A00
        public void GetParticleMeshIndex(){} // RVA: 0x7FFD54D65A70
        public void SetParticles(){} // RVA: 0x7FFD54D65D80 | overloaded x6
        public void SetParticlesWithNativeArray(){} // RVA: 0x7FFD54D65B90
        public void GetParticles(){} // RVA: 0x7FFD54D660D0 | overloaded x6
        public void GetParticlesWithNativeArray(){} // RVA: 0x7FFD54D65EE0
        public void SetCustomParticleData(){} // RVA: 0x7FFD54D66170
        public void GetCustomParticleData(){} // RVA: 0x7FFD54D661E0
        public void GetPlaybackState(){} // RVA: 0x7FFD54D66250
        public void SetPlaybackState(){} // RVA: 0x7FFD54D662C0
        public void GetTrailDataInternal(){} // RVA: 0x7FFD54D66320
        public void GetTrails(){} // RVA: 0x7FFD54D66430 | overloaded x2
        public void SetTrails(){} // RVA: 0x7FFD54D664D0
        public void Simulate(){} // RVA: 0x7FFD54D66600 | overloaded x4
        public void Play(){} // RVA: 0x7FFD54D66690 | overloaded x2
        public void Pause(){} // RVA: 0x7FFD54D66750 | overloaded x2
        public void Stop(){} // RVA: 0x7FFD54D66890 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD54D66950 | overloaded x2
        public void IsAlive(){} // RVA: 0x7FFD54D66A10 | overloaded x2
        public void Emit_Internal(){} // RVA: 0x7FFD54D66A70
        public void EmitOld_Internal(){} // RVA: 0x7FFD54D66B40
        public void TriggerSubEmitter(){} // RVA: 0x7FFD54D66D40 | overloaded x3
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7FFD54D66CD0
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7FFD54D66DB0
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7FFD54D66E00
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7FFD54D66E60
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7FFD54D66EB0
        public void AllocateCustomDataAttribute(){} // RVA: 0x7FFD54D66F00
        public void get_has3DParticleRotations(){} // RVA: 0x7FFD54D66F60
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7FFD54D66FB0
        public void GetManagedJobData(){} // RVA: 0x7FFD54D67000
        public void GetManagedJobHandle(){} // RVA: 0x7FFD54D67050
        public void SetManagedJobHandle(){} // RVA: 0x7FFD54D670C0
        public void ScheduleManagedJob(){} // RVA: 0x7FFD54D67120
        public void CopyManagedJobData(){} // RVA: 0x7FFD54D671A0
        public void get_main(){} // RVA: 0x7FFD4ECF6FB0
        public void get_emission(){} // RVA: 0x7FFD4ECF6FB0
        public void get_shape(){} // RVA: 0x7FFD4ECF6FB0
        public void get_velocityOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_limitVelocityOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_inheritVelocity(){} // RVA: 0x7FFD4ECF6FB0
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x7FFD4ECF6FB0
        public void get_forceOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_colorOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_colorBySpeed(){} // RVA: 0x7FFD4ECF6FB0
        public void get_sizeOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_sizeBySpeed(){} // RVA: 0x7FFD4ECF6FB0
        public void get_rotationOverLifetime(){} // RVA: 0x7FFD4ECF6FB0
        public void get_rotationBySpeed(){} // RVA: 0x7FFD4ECF6FB0
        public void get_externalForces(){} // RVA: 0x7FFD4ECF6FB0
        public void get_noise(){} // RVA: 0x7FFD4ECF6FB0
        public void get_collision(){} // RVA: 0x7FFD4ECF6FB0
        public void get_trigger(){} // RVA: 0x7FFD4ECF6FB0
        public void get_subEmitters(){} // RVA: 0x7FFD4ECF6FB0
        public void get_textureSheetAnimation(){} // RVA: 0x7FFD4ECF6FB0
        public void get_lights(){} // RVA: 0x7FFD4ECF6FB0
        public void get_trails(){} // RVA: 0x7FFD4ECF6FB0
        public void get_customData(){} // RVA: 0x7FFD4ECF6FB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7FFD54D67200
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7FFD54D67270
        public void GetPlaybackState_Injected(){} // RVA: 0x7FFD54D672E0
        public void SetPlaybackState_Injected(){} // RVA: 0x7FFD54D67340
        public void SetTrails_Injected(){} // RVA: 0x7FFD54D673A0
        public void Emit_Injected(){} // RVA: 0x7FFD54D67400
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7FFD54D67470
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7FFD54D674E0
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7FFD54D67540
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7FFD54D675A0
    }

    public class ParticleSystemForceField : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ParticleSystemRenderer : Renderer
    {
        public object alignment;
        public object renderMode;
        public object meshDistribution;
        public object sortMode;
        public object lengthScale;
        public object velocityScale;
        public object cameraVelocityScale;
        public object normalDirection;
        public object shadowBias;
        public object sortingFudge;
        public object minParticleSize;
        public object maxParticleSize;
        public object pivot;
        public object flip;
        public object maskInteraction;
        public object trailMaterial;
        public object oldTrailMaterial;
        public object enableGPUInstancing;
        public object allowRoll;
        public object freeformStretching;
        public object rotateWithStretchDirection;
        public object mesh;
        public object meshCount;
        public object activeVertexStreamsCount;
        public object activeTrailVertexStreamsCount;

        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x7FFD54D7D0D0
        public void DisableVertexStreams(){} // RVA: 0x7FFD54D7D0E0
        public void AreVertexStreamsEnabled(){} // RVA: 0x7FFD54D7D0F0
        public void GetEnabledVertexStreams(){} // RVA: 0x7FFD54D7D110
        public void Internal_SetVertexStreams(){} // RVA: 0x7FFD54D7D120
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7FFD54D7D800
        public void BakeMesh(){} // RVA: 0x7FFD54D7F140 | overloaded x4
        public void BakeTrailsMesh(){} // RVA: 0x7FFD54D7F240 | overloaded x4
        public void get_alignment(){} // RVA: 0x7FFD54D7DF80
        public void set_alignment(){} // RVA: 0x7FFD54D7DFD0
        public void get_renderMode(){} // RVA: 0x7FFD54D7E030
        public void set_renderMode(){} // RVA: 0x7FFD54D7E080
        public void get_meshDistribution(){} // RVA: 0x7FFD54D7E0E0
        public void set_meshDistribution(){} // RVA: 0x7FFD54D7E130
        public void get_sortMode(){} // RVA: 0x7FFD54D7E190
        public void set_sortMode(){} // RVA: 0x7FFD54D7E1E0
        public void get_lengthScale(){} // RVA: 0x7FFD54D7E240
        public void set_lengthScale(){} // RVA: 0x7FFD54D7E290
        public void get_velocityScale(){} // RVA: 0x7FFD54D7E2F0
        public void set_velocityScale(){} // RVA: 0x7FFD54D7E340
        public void get_cameraVelocityScale(){} // RVA: 0x7FFD54D7E3A0
        public void set_cameraVelocityScale(){} // RVA: 0x7FFD54D7E3F0
        public void get_normalDirection(){} // RVA: 0x7FFD54D7E450
        public void set_normalDirection(){} // RVA: 0x7FFD54D7E4A0
        public void get_shadowBias(){} // RVA: 0x7FFD54D7E500
        public void set_shadowBias(){} // RVA: 0x7FFD54D7E550
        public void get_sortingFudge(){} // RVA: 0x7FFD54D7E5B0
        public void set_sortingFudge(){} // RVA: 0x7FFD54D7E600
        public void get_minParticleSize(){} // RVA: 0x7FFD54D7E660
        public void set_minParticleSize(){} // RVA: 0x7FFD54D7E6B0
        public void get_maxParticleSize(){} // RVA: 0x7FFD54D7E710
        public void set_maxParticleSize(){} // RVA: 0x7FFD54D7E760
        public void get_pivot(){} // RVA: 0x7FFD54D7E7C0
        public void set_pivot(){} // RVA: 0x7FFD54D7E830
        public void get_flip(){} // RVA: 0x7FFD54D7E890
        public void set_flip(){} // RVA: 0x7FFD54D7E900
        public void get_maskInteraction(){} // RVA: 0x7FFD54D7E960
        public void set_maskInteraction(){} // RVA: 0x7FFD54D7E9B0
        public void get_trailMaterial(){} // RVA: 0x7FFD54D7EA10
        public void set_trailMaterial(){} // RVA: 0x7FFD54D7EA60
        public void set_oldTrailMaterial(){} // RVA: 0x7FFD54D7EAC0
        public void get_enableGPUInstancing(){} // RVA: 0x7FFD54D7EB20
        public void set_enableGPUInstancing(){} // RVA: 0x7FFD54D7EB70
        public void get_allowRoll(){} // RVA: 0x7FFD54D7EBD0
        public void set_allowRoll(){} // RVA: 0x7FFD54D7EC20
        public void get_freeformStretching(){} // RVA: 0x7FFD54D7EC80
        public void set_freeformStretching(){} // RVA: 0x7FFD54D7ECD0
        public void get_rotateWithStretchDirection(){} // RVA: 0x7FFD54D7ED30
        public void set_rotateWithStretchDirection(){} // RVA: 0x7FFD54D7ED80
        public void get_mesh(){} // RVA: 0x7FFD54D7EDE0
        public void set_mesh(){} // RVA: 0x7FFD54D7EE30
        public void GetMeshes(){} // RVA: 0x7FFD54D7EE90
        public void SetMeshes(){} // RVA: 0x7FFD54D7EF60 | overloaded x2
        public void GetMeshWeightings(){} // RVA: 0x7FFD54D7EF80
        public void SetMeshWeightings(){} // RVA: 0x7FFD54D7F050 | overloaded x2
        public void get_meshCount(){} // RVA: 0x7FFD54D7F070
        public void BakeTexture(){} // RVA: 0x7FFD54D7F860 | overloaded x4
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7FFD54D7F610
        public void BakeTextureInternal(){} // RVA: 0x7FFD54D7F9D0
        public void BakeTrailsTexture(){} // RVA: 0x7FFD54D7FC40 | overloaded x2
        public void BakeTrailsTextureInternal(){} // RVA: 0x7FFD54D7FDB0
        public void get_activeVertexStreamsCount(){} // RVA: 0x7FFD54D7FE60
        public void SetActiveVertexStreams(){} // RVA: 0x7FFD54D7FEB0
        public void GetActiveVertexStreams(){} // RVA: 0x7FFD54D7FF10
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7FFD54D7FF70
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7FFD54D7FFC0
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7FFD54D80020
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_pivot_Injected(){} // RVA: 0x7FFD54D80080
        public void set_pivot_Injected(){} // RVA: 0x7FFD54D800E0
        public void get_flip_Injected(){} // RVA: 0x7FFD54D80140
        public void set_flip_Injected(){} // RVA: 0x7FFD54D801A0
        public void BakeTextureInternal_Injected(){} // RVA: 0x7FFD54D80200
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7FFD54D80290
    }

    public class PenData : ValueType
    {
    }

    public class PhysicMaterial : Object
    {
        public object bounciness;
        public object dynamicFriction;
        public object staticFriction;
        public object frictionCombine;
        public object bounceCombine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DB38D0 | overloaded x2
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7FFD54DB3970
        public void get_bounciness(){} // RVA: 0x7FFD54DB39D0
        public void set_bounciness(){} // RVA: 0x7FFD54DB3A20
        public void get_dynamicFriction(){} // RVA: 0x7FFD54DB3A80
        public void set_dynamicFriction(){} // RVA: 0x7FFD54DB3AD0
        public void get_staticFriction(){} // RVA: 0x7FFD54DB3B30
        public void set_staticFriction(){} // RVA: 0x7FFD54DB3B80
        public void get_frictionCombine(){} // RVA: 0x7FFD54DB3BE0
        public void set_frictionCombine(){} // RVA: 0x7FFD54DB3C30
        public void get_bounceCombine(){} // RVA: 0x7FFD54DB3C90
        public void set_bounceCombine(){} // RVA: 0x7FFD54DB3CE0
    }

    public class Physics : Object
    {
        public object gravity;
        public object bounceThreshold;
        public object simulationMode;
        public object defaultMaxAngularSpeed;
        public object invokeCollisionCallbacks;
        public object defaultPhysicsScene;
        public object reuseCollisionCallbacks;

        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7FFD54DA83A0
        public void get_gravity(){} // RVA: 0x7FFD54DA8490
        public void set_gravity(){} // RVA: 0x7FFD54DA8520
        public void get_bounceThreshold(){} // RVA: 0x7FFD54DA85B0
        public void set_bounceThreshold(){} // RVA: 0x7FFD54DA8600
        public void get_simulationMode(){} // RVA: 0x7FFD54DA8660
        public void set_simulationMode(){} // RVA: 0x7FFD54DA86B0
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7FFD54DA8700
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7FFD54DA8750
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7FFD54DA87B0
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFD54DA8800
        public void IgnoreCollision(){} // RVA: 0x7FFD54DA8900 | overloaded x2
        public void IgnoreLayerCollision(){} // RVA: 0x7FFD54DA8A10 | overloaded x2
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFD54DA8AB0
        public void GetIgnoreCollision(){} // RVA: 0x7FFD54DA8B10
        public void Raycast(){} // RVA: 0x7FFD54DA9790 | overloaded x16
        public void Linecast(){} // RVA: 0x7FFD54DA9C90 | overloaded x6
        public void CapsuleCast(){} // RVA: 0x7FFD54DAA570 | overloaded x8
        public void SphereCast(){} // RVA: 0x7FFD54DAB050 | overloaded x12
        public void BoxCast(){} // RVA: 0x7FFD54DABB90 | overloaded x10
        public void Internal_RaycastAll(){} // RVA: 0x7FFD54DABCC0
        public void RaycastAll(){} // RVA: 0x7FFD54DAC3F0 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFD54DACA50 | overloaded x8
        public void Query_CapsuleCastAll(){} // RVA: 0x7FFD54DACB20
        public void CapsuleCastAll(){} // RVA: 0x7FFD54DACFF0 | overloaded x4
        public void Query_SphereCastAll(){} // RVA: 0x7FFD54DAD0D0
        public void SphereCastAll(){} // RVA: 0x7FFD54DAD850 | overloaded x8
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFD54DAD960
        public void OverlapCapsule(){} // RVA: 0x7FFD54DADC20 | overloaded x3
        public void OverlapSphere_Internal(){} // RVA: 0x7FFD54DADCD0
        public void OverlapSphere(){} // RVA: 0x7FFD54DADF30 | overloaded x3
        public void Simulate_Internal(){} // RVA: 0x7FFD54DADFC0
        public void Simulate(){} // RVA: 0x7FFD54DAE060
        public void InterpolateBodies_Internal(){} // RVA: 0x7FFD54DAE170
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7FFD54DAE200
        public void SyncTransforms(){} // RVA: 0x7FFD54DAE290
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFD54DAE2E0
        public void Query_ComputePenetration(){} // RVA: 0x7FFD54DAE330
        public void ComputePenetration(){} // RVA: 0x7FFD54DAE420
        public void Query_ClosestPoint(){} // RVA: 0x7FFD54DAE5E0
        public void ClosestPoint(){} // RVA: 0x7FFD54DAE6B0
        public void OverlapSphereNonAlloc(){} // RVA: 0x7FFD54DAE9A0 | overloaded x3
        public void CheckSphere_Internal(){} // RVA: 0x7FFD54DAEA30
        public void CheckSphere(){} // RVA: 0x7FFD54DAEC90 | overloaded x3
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFD54DAF090 | overloaded x4
        public void SphereCastNonAlloc(){} // RVA: 0x7FFD54DAF790 | overloaded x8
        public void CheckCapsule_Internal(){} // RVA: 0x7FFD54DAF830
        public void CheckCapsule(){} // RVA: 0x7FFD54DAFAF0 | overloaded x3
        public void CheckBox_Internal(){} // RVA: 0x7FFD54DAFBA0
        public void CheckBox(){} // RVA: 0x7FFD54DAFFF0 | overloaded x4
        public void OverlapBox_Internal(){} // RVA: 0x7FFD54DB0190
        public void OverlapBox(){} // RVA: 0x7FFD54DB05E0 | overloaded x4
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFD54DB0B40 | overloaded x4
        public void BoxCastNonAlloc(){} // RVA: 0x7FFD54DB1390 | overloaded x5
        public void Internal_BoxCastAll(){} // RVA: 0x7FFD54DB1580
        public void BoxCastAll(){} // RVA: 0x7FFD54DB1B40 | overloaded x5
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFD54DB1E30 | overloaded x3
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x7FFD54DB1EF0
        public void RebuildBroadphaseRegions(){} // RVA: 0x7FFD54DB1F90
        public void BakeMesh(){} // RVA: 0x7FFD54DB21D0 | overloaded x2
        public void GetColliderByInstanceID(){} // RVA: 0x7FFD54DB2270
        public void GetBodyByInstanceID(){} // RVA: 0x7FFD54DB22C0
        public void SendOnCollisionEnter(){} // RVA: 0x7FFD54DB2310
        public void SendOnCollisionStay(){} // RVA: 0x7FFD54DB2370
        public void SendOnCollisionExit(){} // RVA: 0x7FFD54DB23D0
        public void OnSceneContact(){} // RVA: 0x7FFD54DB2430
        public void ReportContacts(){} // RVA: 0x7FFD54DB2660
        public void GetCollisionToReport(){} // RVA: 0x7FFD54DB2B30
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54DB2E40
        public void get_gravity_Injected(){} // RVA: 0x7FFD54DB2F10
        public void set_gravity_Injected(){} // RVA: 0x7FFD54DB2F60
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x7FFD54DB2FB0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7FFD54DB3000
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7FFD54DB3090
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7FFD54DB3120
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFD54DB31B0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7FFD54DB3240
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFD54DB32D0
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7FFD54DB3330
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7FFD54DB3380
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7FFD54DB33D0
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7FFD54DB3460
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7FFD54DB34F0
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7FFD54DB3580
        public void CheckBox_Internal_Injected(){} // RVA: 0x7FFD54DB3610
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFD54DB36A0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7FFD54DB3730
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x7FFD54DB37C0
    }

    public class Physics2D : Object
    {
        public object defaultPhysicsScene;
        public object velocityIterations;
        public object positionIterations;
        public object gravity;
        public object queriesHitTriggers;
        public object queriesStartInColliders;
        public object callbacksOnDisable;
        public object reuseCollisionCallbacks;
        public object velocityThreshold;
        public object maxLinearCorrection;
        public object maxAngularCorrection;
        public object maxTranslationSpeed;
        public object maxRotationSpeed;
        public object baumgarteScale;
        public object baumgarteTOIScale;
        public object timeToSleep;
        public object linearSleepTolerance;
        public object angularSleepTolerance;

        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFD51B532B0
        public void get_velocityIterations(){} // RVA: 0x7FFD54D86160
        public void set_velocityIterations(){} // RVA: 0x7FFD54D861B0
        public void get_positionIterations(){} // RVA: 0x7FFD54D86200
        public void set_positionIterations(){} // RVA: 0x7FFD54D86250
        public void get_gravity(){} // RVA: 0x7FFD54D862A0
        public void set_gravity(){} // RVA: 0x7FFD54D86330
        public void get_queriesHitTriggers(){} // RVA: 0x7FFD54D863C0
        public void get_queriesStartInColliders(){} // RVA: 0x7FFD54D86410
        public void set_queriesStartInColliders(){} // RVA: 0x7FFD54D86460
        public void get_callbacksOnDisable(){} // RVA: 0x7FFD54D864B0
        public void set_callbacksOnDisable(){} // RVA: 0x7FFD54D86500
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFD54D86550
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7FFD54D865A0
        public void get_velocityThreshold(){} // RVA: 0x7FFD54D865F0
        public void set_velocityThreshold(){} // RVA: 0x7FFD54D86640
        public void get_maxLinearCorrection(){} // RVA: 0x7FFD54D866A0
        public void set_maxLinearCorrection(){} // RVA: 0x7FFD54D866F0
        public void get_maxAngularCorrection(){} // RVA: 0x7FFD54D86750
        public void set_maxAngularCorrection(){} // RVA: 0x7FFD54D867A0
        public void get_maxTranslationSpeed(){} // RVA: 0x7FFD54D86800
        public void set_maxTranslationSpeed(){} // RVA: 0x7FFD54D86850
        public void get_maxRotationSpeed(){} // RVA: 0x7FFD54D868B0
        public void set_maxRotationSpeed(){} // RVA: 0x7FFD54D86900
        public void get_baumgarteScale(){} // RVA: 0x7FFD54D86960
        public void set_baumgarteScale(){} // RVA: 0x7FFD54D869B0
        public void get_baumgarteTOIScale(){} // RVA: 0x7FFD54D86A10
        public void set_baumgarteTOIScale(){} // RVA: 0x7FFD54D86A60
        public void get_timeToSleep(){} // RVA: 0x7FFD54D86AC0
        public void set_timeToSleep(){} // RVA: 0x7FFD54D86B10
        public void get_linearSleepTolerance(){} // RVA: 0x7FFD54D86B70
        public void set_linearSleepTolerance(){} // RVA: 0x7FFD54D86BC0
        public void get_angularSleepTolerance(){} // RVA: 0x7FFD54D86C20
        public void set_angularSleepTolerance(){} // RVA: 0x7FFD54D86C70
        public void Simulate(){} // RVA: 0x7FFD54D86CD0
        public void Simulate_Internal(){} // RVA: 0x7FFD54D86D30
        public void SyncTransforms(){} // RVA: 0x7FFD54D86DD0
        public void IgnoreCollision(){} // RVA: 0x7FFD54D86EC0 | overloaded x2
        public void GetIgnoreCollision(){} // RVA: 0x7FFD54D86F30
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFD54D86F90
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7FFD54D870D0
        public void SetLayerCollisionMask(){} // RVA: 0x7FFD54D87130
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7FFD54D87220
        public void GetLayerCollisionMask(){} // RVA: 0x7FFD54D87280
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7FFD54D87360
        public void IsTouching(){} // RVA: 0x7FFD54D875C0 | overloaded x3
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7FFD54D87510
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7FFD54D876B0
        public void IsTouchingLayers(){} // RVA: 0x7FFD54D877E0 | overloaded x2
        public void Distance(){} // RVA: 0x7FFD54D87840
        public void Distance_Internal(){} // RVA: 0x7FFD54D87BE0
        public void ClosestPoint(){} // RVA: 0x7FFD54D87E80 | overloaded x2
        public void ClosestPoint_Collider(){} // RVA: 0x7FFD54D88060
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7FFD54D88100
        public void Linecast(){} // RVA: 0x7FFD54D88850 | overloaded x6
        public void LinecastAll(){} // RVA: 0x7FFD54D88DB0 | overloaded x4
        public void LinecastAll_Internal(){} // RVA: 0x7FFD54D88F20
        public void LinecastNonAlloc(){} // RVA: 0x7FFD54D89300 | overloaded x4
        public void Raycast(){} // RVA: 0x7FFD54D89D90 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFD54D8A2C0 | overloaded x5
        public void RaycastAll(){} // RVA: 0x7FFD54D8A820 | overloaded x5
        public void RaycastAll_Internal(){} // RVA: 0x7FFD54D8A920
        public void CircleCast(){} // RVA: 0x7FFD54D8B3B0 | overloaded x8
        public void CircleCastAll(){} // RVA: 0x7FFD54D8B930 | overloaded x5
        public void CircleCastAll_Internal(){} // RVA: 0x7FFD54D8BA40
        public void CircleCastNonAlloc(){} // RVA: 0x7FFD54D8BF70 | overloaded x5
        public void BoxCast(){} // RVA: 0x7FFD54D8CB70 | overloaded x8
        public void BoxCastAll(){} // RVA: 0x7FFD54D8D160 | overloaded x5
        public void BoxCastAll_Internal(){} // RVA: 0x7FFD54D8D280
        public void BoxCastNonAlloc(){} // RVA: 0x7FFD54D8D840 | overloaded x5
        public void CapsuleCast(){} // RVA: 0x7FFD54D8E490 | overloaded x8
        public void CapsuleCastAll(){} // RVA: 0x7FFD54D8EB90 | overloaded x5
        public void CapsuleCastAll_Internal(){} // RVA: 0x7FFD54D8E850
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFD54D8F1C0 | overloaded x5
        public void GetRayIntersection(){} // RVA: 0x7FFD54D8F620 | overloaded x3
        public void GetRayIntersectionAll(){} // RVA: 0x7FFD54D8F9A0 | overloaded x3
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7FFD54D8FAC0
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7FFD54D8FD90 | overloaded x3
        public void OverlapPoint(){} // RVA: 0x7FFD54D90330 | overloaded x6
        public void OverlapPointAll(){} // RVA: 0x7FFD54D90820 | overloaded x4
        public void OverlapPointAll_Internal(){} // RVA: 0x7FFD54D90970
        public void OverlapPointNonAlloc(){} // RVA: 0x7FFD54D90CF0 | overloaded x4
        public void OverlapCircle(){} // RVA: 0x7FFD54D91330 | overloaded x6
        public void OverlapCircleAll(){} // RVA: 0x7FFD54D91860 | overloaded x4
        public void OverlapCircleAll_Internal(){} // RVA: 0x7FFD54D919C0
        public void OverlapCircleNonAlloc(){} // RVA: 0x7FFD54D91D80 | overloaded x4
        public void OverlapBox(){} // RVA: 0x7FFD54D92480 | overloaded x6
        public void OverlapBoxAll(){} // RVA: 0x7FFD54D928B0 | overloaded x4
        public void OverlapBoxAll_Internal(){} // RVA: 0x7FFD54D929B0
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFD54D92DE0 | overloaded x4
        public void OverlapArea(){} // RVA: 0x7FFD54D933E0 | overloaded x6
        public void OverlapAreaAll(){} // RVA: 0x7FFD54D93680 | overloaded x4
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7FFD54D93720
        public void OverlapAreaNonAlloc(){} // RVA: 0x7FFD54D93B80 | overloaded x4
        public void OverlapCapsule(){} // RVA: 0x7FFD54D942A0 | overloaded x6
        public void OverlapCapsuleAll(){} // RVA: 0x7FFD54D94890 | overloaded x4
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7FFD54D94A30
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFD54D94E90 | overloaded x4
        public void OverlapCollider(){} // RVA: 0x7FFD54D84EF0 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFD54D966A0 | overloaded x18
        public void GetColliderContactsArray(){} // RVA: 0x7FFD54D95A10
        public void GetColliderColliderContactsArray(){} // RVA: 0x7FFD54D95AC0
        public void GetRigidbodyContactsArray(){} // RVA: 0x7FFD54D95B80
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7FFD54D95C30
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7FFD54D95CE0
        public void GetColliderContactsList(){} // RVA: 0x7FFD54D967A0
        public void GetColliderColliderContactsList(){} // RVA: 0x7FFD54D96850
        public void GetRigidbodyContactsList(){} // RVA: 0x7FFD54D96910
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7FFD54D969C0
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7FFD54D96A70
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54D96B20
        public void get_gravity_Injected(){} // RVA: 0x7FFD54D96C00
        public void set_gravity_Injected(){} // RVA: 0x7FFD54D96C50
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFD54D96CA0
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7FFD54D96D00
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7FFD54D96D70
        public void Distance_Internal_Injected(){} // RVA: 0x7FFD54D96DD0
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7FFD54D96E40
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7FFD54D96EB0
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7FFD54D96F20
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7FFD54D96FA0
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7FFD54D97030
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7FFD54D970C0
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7FFD54D97150
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7FFD54D971E0
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7FFD54D97270
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7FFD54D972E0
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7FFD54D97360
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7FFD54D973F0
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7FFD54D97480
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7FFD54D974F0
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7FFD54D97570
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFD54D975E0
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFD54D97650
        public void GetColliderContactsList_Injected(){} // RVA: 0x7FFD54D976C0
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7FFD54D97730
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7FFD54D977B0
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFD54D97820
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFD54D97890
    }

    public class PhysicsMaterial2D : Object
    {
        public object bounciness;
        public object friction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DA7250
        public void Create_Internal(){} // RVA: 0x7FFD54DA72E0
        public void get_bounciness(){} // RVA: 0x7FFD54DA7340
        public void set_bounciness(){} // RVA: 0x7FFD54DA7390
        public void get_friction(){} // RVA: 0x7FFD54DA73F0
        public void set_friction(){} // RVA: 0x7FFD54DA7440
    }

    public class PhysicsScene : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD54DBFBF0
        public void op_Equality(){} // RVA: 0x7FFD54CD7FA0
        public void op_Inequality(){} // RVA: 0x7FFD54D01C80
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFD54DBFD60
        public void IsValid_Internal(){} // RVA: 0x7FFD54DBFDC0
        public void IsEmpty(){} // RVA: 0x7FFD54DBFE10
        public void IsEmpty_Internal(){} // RVA: 0x7FFD54DBFF00
        public void Simulate(){} // RVA: 0x7FFD54DBFF50
        public void InterpolateBodies(){} // RVA: 0x7FFD54DC0130
        public void ResetInterpolationPoses(){} // RVA: 0x7FFD54DC0320
        public void Raycast(){} // RVA: 0x7FFD54DC0A30 | overloaded x3
        public void Internal_RaycastTest(){} // RVA: 0x7FFD54DC0700
        public void Internal_Raycast(){} // RVA: 0x7FFD54DC09A0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7FFD54DC0C00
        public void Query_CapsuleCast(){} // RVA: 0x7FFD54DC0C90
        public void Internal_CapsuleCast(){} // RVA: 0x7FFD54DC0D50
        public void CapsuleCast(){} // RVA: 0x7FFD54DC1110 | overloaded x2
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7FFD54DC1050
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7FFD54DC1250
        public void OverlapCapsule(){} // RVA: 0x7FFD54DC12F0
        public void Query_SphereCast(){} // RVA: 0x7FFD54DC13B0
        public void Internal_SphereCast(){} // RVA: 0x7FFD54DC1460
        public void SphereCast(){} // RVA: 0x7FFD54DC17B0 | overloaded x2
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7FFD54DC1700
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7FFD54DC18C0
        public void OverlapSphere(){} // RVA: 0x7FFD54DC1950
        public void Query_BoxCast(){} // RVA: 0x7FFD54DC19F0
        public void Internal_BoxCast(){} // RVA: 0x7FFD54DC1AB0
        public void BoxCast(){} // RVA: 0x7FFD54DC2400 | overloaded x4
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7FFD54DC1F80
        public void OverlapBox(){} // RVA: 0x7FFD54DC20F0 | overloaded x2
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7FFD54DC2200
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFD54DC2580
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFD54DC25D0
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7FFD54DC2620
        public void Internal_Raycast_Injected(){} // RVA: 0x7FFD54DC26B0
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7FFD54DC2740
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7FFD54DC27D0
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7FFD54DC2860
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7FFD54DC28F0
        public void Query_SphereCast_Injected(){} // RVA: 0x7FFD54DC2980
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7FFD54DC2A10
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7FFD54DC2AA0
        public void Query_BoxCast_Injected(){} // RVA: 0x7FFD54DC2B30
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7FFD54DC2BC0
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7FFD54DC2C50
    }

    public class PhysicsShape2D : ValueType
    {
    }

    public class PhysicsUpdateBehaviour2D : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Plane : ValueType
    {
        public object normal;
        public object distance;
        public object flipped;

        // ── Methods ──
        public void get_normal(){} // RVA: 0x7FFD54C31DA0
        public void set_normal(){} // RVA: 0x7FFD5072B6C0
        public void get_distance(){} // RVA: 0x7FFD4E364D00
        public void set_distance(){} // RVA: 0x7FFD4FEBB8C0
        public void .ctor(){} // RVA: 0x7FFD53D7B140 | overloaded x3
        public void SetNormalAndPosition(){} // RVA: 0x7FFD4E4E6C20
        public void Set3Points(){} // RVA: 0x7FFD53D7B140
        public void Flip(){} // RVA: 0x7FFD54C85D30
        public void get_flipped(){} // RVA: 0x7FFD54C85D80
        public void Translate(){} // RVA: 0x7FFD54C85EF0 | overloaded x2
        public void ClosestPointOnPlane(){} // RVA: 0x7FFD54C86000
        public void GetDistanceToPoint(){} // RVA: 0x7FFD54C86090
        public void GetSide(){} // RVA: 0x7FFD54C860E0
        public void SameSide(){} // RVA: 0x7FFD54C86130
        public void Raycast(){} // RVA: 0x7FFD4EA01A10
        public void ToString(){} // RVA: 0x7FFD54C861F0 | overloaded x3
    }

    public class PlatformEffector2D : Effector2D
    {
        public object useOneWay;
        public object useOneWayGrouping;
        public object useSideFriction;
        public object useSideBounce;
        public object surfaceArc;
        public object sideArc;
        public object rotationalOffset;

        // ── Methods ──
        public void get_useOneWay(){} // RVA: 0x7FFD54DA65B0
        public void set_useOneWay(){} // RVA: 0x7FFD54DA6600
        public void get_useOneWayGrouping(){} // RVA: 0x7FFD54DA6660
        public void set_useOneWayGrouping(){} // RVA: 0x7FFD54DA66B0
        public void get_useSideFriction(){} // RVA: 0x7FFD54DA6710
        public void set_useSideFriction(){} // RVA: 0x7FFD54DA6760
        public void get_useSideBounce(){} // RVA: 0x7FFD54DA67C0
        public void set_useSideBounce(){} // RVA: 0x7FFD54DA6810
        public void get_surfaceArc(){} // RVA: 0x7FFD54DA6870
        public void set_surfaceArc(){} // RVA: 0x7FFD54DA68C0
        public void get_sideArc(){} // RVA: 0x7FFD54DA6920
        public void set_sideArc(){} // RVA: 0x7FFD54DA6970
        public void get_rotationalOffset(){} // RVA: 0x7FFD54DA69D0
        public void set_rotationalOffset(){} // RVA: 0x7FFD54DA6A20
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PointEffector2D : Effector2D
    {
        public object forceMagnitude;
        public object forceVariation;
        public object distanceScale;
        public object drag;
        public object angularDrag;
        public object forceSource;
        public object forceTarget;
        public object forceMode;

        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x7FFD54DA6030
        public void set_forceMagnitude(){} // RVA: 0x7FFD54DA6080
        public void get_forceVariation(){} // RVA: 0x7FFD54DA60E0
        public void set_forceVariation(){} // RVA: 0x7FFD54DA6130
        public void get_distanceScale(){} // RVA: 0x7FFD54DA6190
        public void set_distanceScale(){} // RVA: 0x7FFD54DA61E0
        public void get_drag(){} // RVA: 0x7FFD54DA6240
        public void set_drag(){} // RVA: 0x7FFD54DA6290
        public void get_angularDrag(){} // RVA: 0x7FFD54DA62F0
        public void set_angularDrag(){} // RVA: 0x7FFD54DA6340
        public void get_forceSource(){} // RVA: 0x7FFD54DA63A0
        public void set_forceSource(){} // RVA: 0x7FFD54DA63F0
        public void get_forceTarget(){} // RVA: 0x7FFD54DA6450
        public void set_forceTarget(){} // RVA: 0x7FFD54DA64A0
        public void get_forceMode(){} // RVA: 0x7FFD54DA6500
        public void set_forceMode(){} // RVA: 0x7FFD54DA6550
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PolygonCollider2D : Collider2D
    {
        public object useDelaunayMesh;
        public object autoTiling;
        public object points;
        public object pathCount;

        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7FFD54DA1770
        public void set_useDelaunayMesh(){} // RVA: 0x7FFD54DA17C0
        public void get_autoTiling(){} // RVA: 0x7FFD54DA1820
        public void set_autoTiling(){} // RVA: 0x7FFD54DA1870
        public void GetTotalPointCount(){} // RVA: 0x7FFD54DA18D0
        public void get_points(){} // RVA: 0x7FFD54DA1920
        public void set_points(){} // RVA: 0x7FFD54DA1970
        public void get_pathCount(){} // RVA: 0x7FFD54DA19D0
        public void set_pathCount(){} // RVA: 0x7FFD54DA1A20
        public void GetPath(){} // RVA: 0x7FFD54DA1DF0 | overloaded x2
        public void GetPath_Internal(){} // RVA: 0x7FFD54DA1C30
        public void SetPath(){} // RVA: 0x7FFD54DA2030 | overloaded x2
        public void SetPath_Internal(){} // RVA: 0x7FFD54DA1D80
        public void GetPathList_Internal(){} // RVA: 0x7FFD54DA1FC0
        public void SetPathList_Internal(){} // RVA: 0x7FFD54DA2120
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Pose : ValueType
    {
        public object identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD52626E60
        public void ToString(){} // RVA: 0x7FFD54CEDBC0
        public void GetTransformedBy(){} // RVA: 0x7FFD54CEDCE0
        public void get_identity(){} // RVA: 0x7FFD54CEDFE0
        public void Equals(){} // RVA: 0x7FFD54CEE120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54CEE1D0
        public void .cctor(){} // RVA: 0x7FFD54CEE2B0
    }

    public class PreferBinarySerialization : Attribute
    {
    }

    public class PreloadData : Object
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x7FFD4E341310
    }

    public class Projector : Behaviour
    {
        public object nearClipPlane;
        public object farClipPlane;
        public object fieldOfView;
        public object aspectRatio;
        public object orthographic;
        public object orthographicSize;
        public object ignoreLayers;
        public object material;

        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x7FFD54CA8DB0
        public void set_nearClipPlane(){} // RVA: 0x7FFD54CA8E00
        public void get_farClipPlane(){} // RVA: 0x7FFD54CA8E60
        public void set_farClipPlane(){} // RVA: 0x7FFD54CA8EB0
        public void get_fieldOfView(){} // RVA: 0x7FFD54CA8F10
        public void set_fieldOfView(){} // RVA: 0x7FFD54CA8F60
        public void get_aspectRatio(){} // RVA: 0x7FFD54CA8FC0
        public void set_aspectRatio(){} // RVA: 0x7FFD54CA9010
        public void get_orthographic(){} // RVA: 0x7FFD54CA9070
        public void set_orthographic(){} // RVA: 0x7FFD54CA90C0
        public void get_orthographicSize(){} // RVA: 0x7FFD54CA9120
        public void set_orthographicSize(){} // RVA: 0x7FFD54CA9170
        public void get_ignoreLayers(){} // RVA: 0x7FFD54CA91D0
        public void set_ignoreLayers(){} // RVA: 0x7FFD54CA9220
        public void get_material(){} // RVA: 0x7FFD54CA9280
        public void set_material(){} // RVA: 0x7FFD54CA92D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PropertyName : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E78D8B0 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x7FFD54CD7F90
        public void op_Equality(){} // RVA: 0x7FFD54CD7FA0
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD54CD7E60
        public void ToString(){} // RVA: 0x7FFD54CD8030
    }

}