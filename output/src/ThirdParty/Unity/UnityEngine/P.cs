// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 30
// Methods: 1086

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent
    {
        public UnityEngine.Vector3 m_Intersection; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x70983A0
        public void get_colliderComponent(){} // RVA: 0x71C8A20
        public void InstanceIDToColliderComponent(){} // RVA: 0x71C8A70
    }

    public class ParticlePhysicsExtensions
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x71C5760
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
        public void Emit(){} // RVA: 0x71AF1D0 | overloaded x4
        public void get_startDelay(){} // RVA: 0x71AC260
        public void set_startDelay(){} // RVA: 0x71AC310
        public void get_loop(){} // RVA: 0x71AC3C0
        public void set_loop(){} // RVA: 0x71AC470
        public void get_playOnAwake(){} // RVA: 0x71AC520
        public void set_playOnAwake(){} // RVA: 0x71AC5D0
        public void get_duration(){} // RVA: 0x71AC680
        public void get_playbackSpeed(){} // RVA: 0x71AC730
        public void set_playbackSpeed(){} // RVA: 0x71AC7E0
        public void get_enableEmission(){} // RVA: 0x71AC890
        public void set_enableEmission(){} // RVA: 0x71AC940
        public void get_emissionRate(){} // RVA: 0x71AC9F0
        public void set_emissionRate(){} // RVA: 0x71ACAA0
        public void get_startSpeed(){} // RVA: 0x71ACB80
        public void set_startSpeed(){} // RVA: 0x71ACC30
        public void get_startSize(){} // RVA: 0x71ACCE0
        public void set_startSize(){} // RVA: 0x71ACD90
        public void get_startColor(){} // RVA: 0x71ACE40
        public void set_startColor(){} // RVA: 0x71ACF20
        public void get_startRotation(){} // RVA: 0x71AD030
        public void set_startRotation(){} // RVA: 0x71AD0E0
        public void get_startRotation3D(){} // RVA: 0x71AD190
        public void set_startRotation3D(){} // RVA: 0x71AD3C0
        public void get_startLifetime(){} // RVA: 0x71AD500
        public void set_startLifetime(){} // RVA: 0x71AD5B0
        public void get_gravityModifier(){} // RVA: 0x71AD660
        public void set_gravityModifier(){} // RVA: 0x71AD710
        public void get_maxParticles(){} // RVA: 0x71AD7C0
        public void set_maxParticles(){} // RVA: 0x71AD870
        public void get_simulationSpace(){} // RVA: 0x71AD920
        public void set_simulationSpace(){} // RVA: 0x71AD9D0
        public void get_scalingMode(){} // RVA: 0x71ADA80
        public void set_scalingMode(){} // RVA: 0x71ADB30
        public void get_automaticCullingEnabled(){} // RVA: 0x71ADBE0
        public void get_isPlaying(){} // RVA: 0x71ADC30
        public void get_isEmitting(){} // RVA: 0x71ADC80
        public void get_isStopped(){} // RVA: 0x71ADCD0
        public void get_isPaused(){} // RVA: 0x71ADD20
        public void get_particleCount(){} // RVA: 0x71ADD70
        public void get_time(){} // RVA: 0x71ADDC0
        public void set_time(){} // RVA: 0x71ADE10
        public void get_totalTime(){} // RVA: 0x71ADE70
        public void get_randomSeed(){} // RVA: 0x71ADEC0
        public void set_randomSeed(){} // RVA: 0x71ADF10
        public void get_useAutoRandomSeed(){} // RVA: 0x71ADF70
        public void set_useAutoRandomSeed(){} // RVA: 0x71ADFC0
        public void get_proceduralSimulationSupported(){} // RVA: 0x71ADBE0
        public void GetParticleCurrentSize(){} // RVA: 0x71AE020
        public void GetParticleCurrentSize3D(){} // RVA: 0x71AE080
        public void GetParticleCurrentColor(){} // RVA: 0x71AE100
        public void GetParticleMeshIndex(){} // RVA: 0x71AE170
        public void SetParticles(){} // RVA: 0x71AE480 | overloaded x6
        public void SetParticlesWithNativeArray(){} // RVA: 0x71AE290
        public void GetParticles(){} // RVA: 0x71AE7D0 | overloaded x6
        public void GetParticlesWithNativeArray(){} // RVA: 0x71AE5E0
        public void SetCustomParticleData(){} // RVA: 0x71AE870
        public void GetCustomParticleData(){} // RVA: 0x71AE8E0
        public void GetPlaybackState(){} // RVA: 0x71AE950
        public void SetPlaybackState(){} // RVA: 0x71AE9C0
        public void GetTrailDataInternal(){} // RVA: 0x71AEA20
        public void GetTrails(){} // RVA: 0x71AEB30 | overloaded x2
        public void SetTrails(){} // RVA: 0x71AEBD0
        public void Simulate(){} // RVA: 0x71AED00 | overloaded x4
        public void Play(){} // RVA: 0x71AED90 | overloaded x2
        public void Pause(){} // RVA: 0x71AEE50 | overloaded x2
        public void Stop(){} // RVA: 0x71AEF90 | overloaded x3
        public void Clear(){} // RVA: 0x71AF050 | overloaded x2
        public void IsAlive(){} // RVA: 0x71AF110 | overloaded x2
        public void Emit_Internal(){} // RVA: 0x71AF170
        public void EmitOld_Internal(){} // RVA: 0x71AF240
        public void TriggerSubEmitter(){} // RVA: 0x71AF440 | overloaded x3
        public void TriggerSubEmitterForParticle(){} // RVA: 0x71AF3D0
        public void ResetPreMappedBufferMemory(){} // RVA: 0x71AF4B0
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x71AF500
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x71AF560
        public void AllocateMeshIndexAttribute(){} // RVA: 0x71AF5B0
        public void AllocateCustomDataAttribute(){} // RVA: 0x71AF600
        public void get_has3DParticleRotations(){} // RVA: 0x71AF660
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x71AF6B0
        public void GetManagedJobData(){} // RVA: 0x71AF700
        public void GetManagedJobHandle(){} // RVA: 0x71AF750
        public void SetManagedJobHandle(){} // RVA: 0x71AF7C0
        public void ScheduleManagedJob(){} // RVA: 0x71AF820
        public void CopyManagedJobData(){} // RVA: 0x71AF8A0
        public void get_main(){} // RVA: 0x10073D0
        public void get_emission(){} // RVA: 0x10073D0
        public void get_shape(){} // RVA: 0x10073D0
        public void get_velocityOverLifetime(){} // RVA: 0x10073D0
        public void get_limitVelocityOverLifetime(){} // RVA: 0x10073D0
        public void get_inheritVelocity(){} // RVA: 0x10073D0
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x10073D0
        public void get_forceOverLifetime(){} // RVA: 0x10073D0
        public void get_colorOverLifetime(){} // RVA: 0x10073D0
        public void get_colorBySpeed(){} // RVA: 0x10073D0
        public void get_sizeOverLifetime(){} // RVA: 0x10073D0
        public void get_sizeBySpeed(){} // RVA: 0x10073D0
        public void get_rotationOverLifetime(){} // RVA: 0x10073D0
        public void get_rotationBySpeed(){} // RVA: 0x10073D0
        public void get_externalForces(){} // RVA: 0x10073D0
        public void get_noise(){} // RVA: 0x10073D0
        public void get_collision(){} // RVA: 0x10073D0
        public void get_trigger(){} // RVA: 0x10073D0
        public void get_subEmitters(){} // RVA: 0x10073D0
        public void get_textureSheetAnimation(){} // RVA: 0x10073D0
        public void get_lights(){} // RVA: 0x10073D0
        public void get_trails(){} // RVA: 0x10073D0
        public void get_customData(){} // RVA: 0x10073D0
        public void .ctor(){} // RVA: 0x2DDD50
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x71AF900
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x71AF970
        public void GetPlaybackState_Injected(){} // RVA: 0x71AF9E0
        public void SetPlaybackState_Injected(){} // RVA: 0x71AFA40
        public void SetTrails_Injected(){} // RVA: 0x71AFAA0
        public void Emit_Injected(){} // RVA: 0x71AFB00
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x71AFB70
        public void GetManagedJobHandle_Injected(){} // RVA: 0x71AFBE0
        public void SetManagedJobHandle_Injected(){} // RVA: 0x71AFC40
        public void ScheduleManagedJob_Injected(){} // RVA: 0x71AFCA0
    }

    public class ParticleSystemExtensionsImpl
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x71C5760
    }

    public class ParticleSystemForceField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ParticleSystemRenderer
    {
        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x71C57D0
        public void DisableVertexStreams(){} // RVA: 0x71C57E0
        public void AreVertexStreamsEnabled(){} // RVA: 0x71C57F0
        public void GetEnabledVertexStreams(){} // RVA: 0x71C5810
        public void Internal_SetVertexStreams(){} // RVA: 0x71C5820
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x71C5F00
        public void BakeMesh(){} // RVA: 0x71C7840 | overloaded x4
        public void BakeTrailsMesh(){} // RVA: 0x71C7940 | overloaded x4
        public void get_alignment(){} // RVA: 0x71C6680
        public void set_alignment(){} // RVA: 0x71C66D0
        public void get_renderMode(){} // RVA: 0x71C6730
        public void set_renderMode(){} // RVA: 0x71C6780
        public void get_meshDistribution(){} // RVA: 0x71C67E0
        public void set_meshDistribution(){} // RVA: 0x71C6830
        public void get_sortMode(){} // RVA: 0x71C6890
        public void set_sortMode(){} // RVA: 0x71C68E0
        public void get_lengthScale(){} // RVA: 0x71C6940
        public void set_lengthScale(){} // RVA: 0x71C6990
        public void get_velocityScale(){} // RVA: 0x71C69F0
        public void set_velocityScale(){} // RVA: 0x71C6A40
        public void get_cameraVelocityScale(){} // RVA: 0x71C6AA0
        public void set_cameraVelocityScale(){} // RVA: 0x71C6AF0
        public void get_normalDirection(){} // RVA: 0x71C6B50
        public void set_normalDirection(){} // RVA: 0x71C6BA0
        public void get_shadowBias(){} // RVA: 0x71C6C00
        public void set_shadowBias(){} // RVA: 0x71C6C50
        public void get_sortingFudge(){} // RVA: 0x71C6CB0
        public void set_sortingFudge(){} // RVA: 0x71C6D00
        public void get_minParticleSize(){} // RVA: 0x71C6D60
        public void set_minParticleSize(){} // RVA: 0x71C6DB0
        public void get_maxParticleSize(){} // RVA: 0x71C6E10
        public void set_maxParticleSize(){} // RVA: 0x71C6E60
        public void get_pivot(){} // RVA: 0x71C6EC0
        public void set_pivot(){} // RVA: 0x71C6F30
        public void get_flip(){} // RVA: 0x71C6F90
        public void set_flip(){} // RVA: 0x71C7000
        public void get_maskInteraction(){} // RVA: 0x71C7060
        public void set_maskInteraction(){} // RVA: 0x71C70B0
        public void get_trailMaterial(){} // RVA: 0x71C7110
        public void set_trailMaterial(){} // RVA: 0x71C7160
        public void set_oldTrailMaterial(){} // RVA: 0x71C71C0
        public void get_enableGPUInstancing(){} // RVA: 0x71C7220
        public void set_enableGPUInstancing(){} // RVA: 0x71C7270
        public void get_allowRoll(){} // RVA: 0x71C72D0
        public void set_allowRoll(){} // RVA: 0x71C7320
        public void get_freeformStretching(){} // RVA: 0x71C7380
        public void set_freeformStretching(){} // RVA: 0x71C73D0
        public void get_rotateWithStretchDirection(){} // RVA: 0x71C7430
        public void set_rotateWithStretchDirection(){} // RVA: 0x71C7480
        public void get_mesh(){} // RVA: 0x71C74E0
        public void set_mesh(){} // RVA: 0x71C7530
        public void GetMeshes(){} // RVA: 0x71C7590
        public void SetMeshes(){} // RVA: 0x71C7660 | overloaded x2
        public void GetMeshWeightings(){} // RVA: 0x71C7680
        public void SetMeshWeightings(){} // RVA: 0x71C7750 | overloaded x2
        public void get_meshCount(){} // RVA: 0x71C7770
        public void BakeTexture(){} // RVA: 0x71C7F60 | overloaded x4
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x71C7D10
        public void BakeTextureInternal(){} // RVA: 0x71C80D0
        public void BakeTrailsTexture(){} // RVA: 0x71C8340 | overloaded x2
        public void BakeTrailsTextureInternal(){} // RVA: 0x71C84B0
        public void get_activeVertexStreamsCount(){} // RVA: 0x71C8560
        public void SetActiveVertexStreams(){} // RVA: 0x71C85B0
        public void GetActiveVertexStreams(){} // RVA: 0x71C8610
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x71C8670
        public void SetActiveTrailVertexStreams(){} // RVA: 0x71C86C0
        public void GetActiveTrailVertexStreams(){} // RVA: 0x71C8720
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_pivot_Injected(){} // RVA: 0x71C8780
        public void set_pivot_Injected(){} // RVA: 0x71C87E0
        public void get_flip_Injected(){} // RVA: 0x71C8840
        public void set_flip_Injected(){} // RVA: 0x71C88A0
        public void BakeTextureInternal_Injected(){} // RVA: 0x71C8900
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x71C8990
    }

    public class PenData
    {
    }

    public class PhysicMaterial
    {
        public object bounciness;
        public object friction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71FBFD0 | overloaded x2
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x71FC070
        public void get_bounciness(){} // RVA: 0x71FC0D0
        public void set_bounciness(){} // RVA: 0x71FC120
        public void get_dynamicFriction(){} // RVA: 0x71FC180
        public void set_dynamicFriction(){} // RVA: 0x71FC1D0
        public void get_staticFriction(){} // RVA: 0x71FC230
        public void set_staticFriction(){} // RVA: 0x71FC280
        public void get_frictionCombine(){} // RVA: 0x71FC2E0
        public void set_frictionCombine(){} // RVA: 0x71FC330
        public void get_bounceCombine(){} // RVA: 0x71FC390
        public void set_bounceCombine(){} // RVA: 0x71FC3E0
    }

    public class Physics
    {
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD; // 0x8
        public ContactEventDelegate ContactEvent; // 0x10
        public UnityEngine.Collision s_ReusableCollision; // 0x18

        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x71F0AA0
        public void get_gravity(){} // RVA: 0x71F0B90
        public void set_gravity(){} // RVA: 0x71F0C20
        public void get_bounceThreshold(){} // RVA: 0x71F0CB0
        public void set_bounceThreshold(){} // RVA: 0x71F0D00
        public void get_simulationMode(){} // RVA: 0x71F0D60
        public void set_simulationMode(){} // RVA: 0x71F0DB0
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x71F0E00
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x71F0E50
        public void get_invokeCollisionCallbacks(){} // RVA: 0x71F0EB0
        public void get_defaultPhysicsScene(){} // RVA: 0x71F0F00
        public void IgnoreCollision(){} // RVA: 0x71F1000 | overloaded x2
        public void IgnoreLayerCollision(){} // RVA: 0x71F1110 | overloaded x2
        public void GetIgnoreLayerCollision(){} // RVA: 0x71F11B0
        public void GetIgnoreCollision(){} // RVA: 0x71F1210
        public void Raycast(){} // RVA: 0x71F1E90 | overloaded x16
        public void Linecast(){} // RVA: 0x71F2390 | overloaded x6
        public void CapsuleCast(){} // RVA: 0x71F2C70 | overloaded x8
        public void SphereCast(){} // RVA: 0x71F3750 | overloaded x12
        public void BoxCast(){} // RVA: 0x71F4290 | overloaded x10
        public void Internal_RaycastAll(){} // RVA: 0x71F43C0
        public void RaycastAll(){} // RVA: 0x71F4AF0 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x71F5150 | overloaded x8
        public void Query_CapsuleCastAll(){} // RVA: 0x71F5220
        public void CapsuleCastAll(){} // RVA: 0x71F56F0 | overloaded x4
        public void Query_SphereCastAll(){} // RVA: 0x71F57D0
        public void SphereCastAll(){} // RVA: 0x71F5F50 | overloaded x8
        public void OverlapCapsule_Internal(){} // RVA: 0x71F6060
        public void OverlapCapsule(){} // RVA: 0x71F6320 | overloaded x3
        public void OverlapSphere_Internal(){} // RVA: 0x71F63D0
        public void OverlapSphere(){} // RVA: 0x71F6630 | overloaded x3
        public void Simulate_Internal(){} // RVA: 0x71F66C0
        public void Simulate(){} // RVA: 0x71F6760
        public void InterpolateBodies_Internal(){} // RVA: 0x71F6870
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x71F6900
        public void SyncTransforms(){} // RVA: 0x71F6990
        public void get_reuseCollisionCallbacks(){} // RVA: 0x71F69E0
        public void Query_ComputePenetration(){} // RVA: 0x71F6A30
        public void ComputePenetration(){} // RVA: 0x71F6B20
        public void Query_ClosestPoint(){} // RVA: 0x71F6CE0
        public void ClosestPoint(){} // RVA: 0x71F6DB0
        public void OverlapSphereNonAlloc(){} // RVA: 0x71F70A0 | overloaded x3
        public void CheckSphere_Internal(){} // RVA: 0x71F7130
        public void CheckSphere(){} // RVA: 0x71F7390 | overloaded x3
        public void CapsuleCastNonAlloc(){} // RVA: 0x71F7790 | overloaded x4
        public void SphereCastNonAlloc(){} // RVA: 0x71F7E90 | overloaded x8
        public void CheckCapsule_Internal(){} // RVA: 0x71F7F30
        public void CheckCapsule(){} // RVA: 0x71F81F0 | overloaded x3
        public void CheckBox_Internal(){} // RVA: 0x71F82A0
        public void CheckBox(){} // RVA: 0x71F86F0 | overloaded x4
        public void OverlapBox_Internal(){} // RVA: 0x71F8890
        public void OverlapBox(){} // RVA: 0x71F8CE0 | overloaded x4
        public void OverlapBoxNonAlloc(){} // RVA: 0x71F9240 | overloaded x4
        public void BoxCastNonAlloc(){} // RVA: 0x71F9A90 | overloaded x5
        public void Internal_BoxCastAll(){} // RVA: 0x71F9C80
        public void BoxCastAll(){} // RVA: 0x71FA240 | overloaded x5
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x71FA530 | overloaded x3
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x71FA5F0
        public void RebuildBroadphaseRegions(){} // RVA: 0x71FA690
        public void BakeMesh(){} // RVA: 0x71FA8D0 | overloaded x2
        public void GetColliderByInstanceID(){} // RVA: 0x71FA970
        public void GetBodyByInstanceID(){} // RVA: 0x71FA9C0
        public void SendOnCollisionEnter(){} // RVA: 0x71FAA10
        public void SendOnCollisionStay(){} // RVA: 0x71FAA70
        public void SendOnCollisionExit(){} // RVA: 0x71FAAD0
        public void OnSceneContact(){} // RVA: 0x71FAB30
        public void ReportContacts(){} // RVA: 0x71FAD60
        public void GetCollisionToReport(){} // RVA: 0x71FB230
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x71FB540
        public void get_gravity_Injected(){} // RVA: 0x71FB610
        public void set_gravity_Injected(){} // RVA: 0x71FB660
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x71FB6B0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x71FB700
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x71FB790
        public void Query_SphereCastAll_Injected(){} // RVA: 0x71FB820
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x71FB8B0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x71FB940
        public void Simulate_Internal_Injected(){} // RVA: 0x71FB9D0
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x71FBA30
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x71FBA80
        public void Query_ComputePenetration_Injected(){} // RVA: 0x71FBAD0
        public void Query_ClosestPoint_Injected(){} // RVA: 0x71FBB60
        public void CheckSphere_Internal_Injected(){} // RVA: 0x71FBBF0
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x71FBC80
        public void CheckBox_Internal_Injected(){} // RVA: 0x71FBD10
        public void OverlapBox_Internal_Injected(){} // RVA: 0x71FBDA0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x71FBE30
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x71FBEC0
    }

    public class Physics2D
    {
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x3E0F620
        public void get_velocityIterations(){} // RVA: 0x71CE860
        public void set_velocityIterations(){} // RVA: 0x71CE8B0
        public void get_positionIterations(){} // RVA: 0x71CE900
        public void set_positionIterations(){} // RVA: 0x71CE950
        public void get_gravity(){} // RVA: 0x71CE9A0
        public void set_gravity(){} // RVA: 0x71CEA30
        public void get_queriesHitTriggers(){} // RVA: 0x71CEAC0
        public void get_queriesStartInColliders(){} // RVA: 0x71CEB10
        public void set_queriesStartInColliders(){} // RVA: 0x71CEB60
        public void get_callbacksOnDisable(){} // RVA: 0x71CEBB0
        public void set_callbacksOnDisable(){} // RVA: 0x71CEC00
        public void get_reuseCollisionCallbacks(){} // RVA: 0x71CEC50
        public void set_reuseCollisionCallbacks(){} // RVA: 0x71CECA0
        public void get_velocityThreshold(){} // RVA: 0x71CECF0
        public void set_velocityThreshold(){} // RVA: 0x71CED40
        public void get_maxLinearCorrection(){} // RVA: 0x71CEDA0
        public void set_maxLinearCorrection(){} // RVA: 0x71CEDF0
        public void get_maxAngularCorrection(){} // RVA: 0x71CEE50
        public void set_maxAngularCorrection(){} // RVA: 0x71CEEA0
        public void get_maxTranslationSpeed(){} // RVA: 0x71CEF00
        public void set_maxTranslationSpeed(){} // RVA: 0x71CEF50
        public void get_maxRotationSpeed(){} // RVA: 0x71CEFB0
        public void set_maxRotationSpeed(){} // RVA: 0x71CF000
        public void get_baumgarteScale(){} // RVA: 0x71CF060
        public void set_baumgarteScale(){} // RVA: 0x71CF0B0
        public void get_baumgarteTOIScale(){} // RVA: 0x71CF110
        public void set_baumgarteTOIScale(){} // RVA: 0x71CF160
        public void get_timeToSleep(){} // RVA: 0x71CF1C0
        public void set_timeToSleep(){} // RVA: 0x71CF210
        public void get_linearSleepTolerance(){} // RVA: 0x71CF270
        public void set_linearSleepTolerance(){} // RVA: 0x71CF2C0
        public void get_angularSleepTolerance(){} // RVA: 0x71CF320
        public void set_angularSleepTolerance(){} // RVA: 0x71CF370
        public void Simulate(){} // RVA: 0x71CF3D0
        public void Simulate_Internal(){} // RVA: 0x71CF430
        public void SyncTransforms(){} // RVA: 0x71CF4D0
        public void IgnoreCollision(){} // RVA: 0x71CF5C0 | overloaded x2
        public void GetIgnoreCollision(){} // RVA: 0x71CF630
        public void GetIgnoreLayerCollision(){} // RVA: 0x71CF690
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x71CF7D0
        public void SetLayerCollisionMask(){} // RVA: 0x71CF830
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x71CF920
        public void GetLayerCollisionMask(){} // RVA: 0x71CF980
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x71CFA60
        public void IsTouching(){} // RVA: 0x71CFCC0 | overloaded x3
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x71CFC10
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x71CFDB0
        public void IsTouchingLayers(){} // RVA: 0x71CFEE0 | overloaded x2
        public void Distance(){} // RVA: 0x71CFF40
        public void Distance_Internal(){} // RVA: 0x71D02E0
        public void ClosestPoint(){} // RVA: 0x71D0580 | overloaded x2
        public void ClosestPoint_Collider(){} // RVA: 0x71D0760
        public void ClosestPoint_Rigidbody(){} // RVA: 0x71D0800
        public void Linecast(){} // RVA: 0x71D0F50 | overloaded x6
        public void LinecastAll(){} // RVA: 0x71D14B0 | overloaded x4
        public void LinecastAll_Internal(){} // RVA: 0x71D1620
        public void LinecastNonAlloc(){} // RVA: 0x71D1A00 | overloaded x4
        public void Raycast(){} // RVA: 0x71D2490 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x71D29C0 | overloaded x5
        public void RaycastAll(){} // RVA: 0x71D2F20 | overloaded x5
        public void RaycastAll_Internal(){} // RVA: 0x71D3020
        public void CircleCast(){} // RVA: 0x71D3AB0 | overloaded x8
        public void CircleCastAll(){} // RVA: 0x71D4030 | overloaded x5
        public void CircleCastAll_Internal(){} // RVA: 0x71D4140
        public void CircleCastNonAlloc(){} // RVA: 0x71D4670 | overloaded x5
        public void BoxCast(){} // RVA: 0x71D5270 | overloaded x8
        public void BoxCastAll(){} // RVA: 0x71D5860 | overloaded x5
        public void BoxCastAll_Internal(){} // RVA: 0x71D5980
        public void BoxCastNonAlloc(){} // RVA: 0x71D5F40 | overloaded x5
        public void CapsuleCast(){} // RVA: 0x71D6B90 | overloaded x8
        public void CapsuleCastAll(){} // RVA: 0x71D7290 | overloaded x5
        public void CapsuleCastAll_Internal(){} // RVA: 0x71D6F50
        public void CapsuleCastNonAlloc(){} // RVA: 0x71D78C0 | overloaded x5
        public void GetRayIntersection(){} // RVA: 0x71D7D20 | overloaded x3
        public void GetRayIntersectionAll(){} // RVA: 0x71D80A0 | overloaded x3
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x71D81C0
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x71D8490 | overloaded x3
        public void OverlapPoint(){} // RVA: 0x71D8A30 | overloaded x6
        public void OverlapPointAll(){} // RVA: 0x71D8F20 | overloaded x4
        public void OverlapPointAll_Internal(){} // RVA: 0x71D9070
        public void OverlapPointNonAlloc(){} // RVA: 0x71D93F0 | overloaded x4
        public void OverlapCircle(){} // RVA: 0x71D9A30 | overloaded x6
        public void OverlapCircleAll(){} // RVA: 0x71D9F60 | overloaded x4
        public void OverlapCircleAll_Internal(){} // RVA: 0x71DA0C0
        public void OverlapCircleNonAlloc(){} // RVA: 0x71DA480 | overloaded x4
        public void OverlapBox(){} // RVA: 0x71DAB80 | overloaded x6
        public void OverlapBoxAll(){} // RVA: 0x71DAFB0 | overloaded x4
        public void OverlapBoxAll_Internal(){} // RVA: 0x71DB0B0
        public void OverlapBoxNonAlloc(){} // RVA: 0x71DB4E0 | overloaded x4
        public void OverlapArea(){} // RVA: 0x71DBAE0 | overloaded x6
        public void OverlapAreaAll(){} // RVA: 0x71DBD80 | overloaded x4
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x71DBE20
        public void OverlapAreaNonAlloc(){} // RVA: 0x71DC280 | overloaded x4
        public void OverlapCapsule(){} // RVA: 0x71DC9A0 | overloaded x6
        public void OverlapCapsuleAll(){} // RVA: 0x71DCF90 | overloaded x4
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x71DD130
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x71DD590 | overloaded x4
        public void OverlapCollider(){} // RVA: 0x71CD5F0 | overloaded x2
        public void GetContacts(){} // RVA: 0x71DEDA0 | overloaded x18
        public void GetColliderContactsArray(){} // RVA: 0x71DE110
        public void GetColliderColliderContactsArray(){} // RVA: 0x71DE1C0
        public void GetRigidbodyContactsArray(){} // RVA: 0x71DE280
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x71DE330
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x71DE3E0
        public void GetColliderContactsList(){} // RVA: 0x71DEEA0
        public void GetColliderColliderContactsList(){} // RVA: 0x71DEF50
        public void GetRigidbodyContactsList(){} // RVA: 0x71DF010
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x71DF0C0
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x71DF170
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x71DF220
        public void get_gravity_Injected(){} // RVA: 0x71DF300
        public void set_gravity_Injected(){} // RVA: 0x71DF350
        public void Simulate_Internal_Injected(){} // RVA: 0x71DF3A0
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x71DF400
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x71DF470
        public void Distance_Internal_Injected(){} // RVA: 0x71DF4D0
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x71DF540
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x71DF5B0
        public void LinecastAll_Internal_Injected(){} // RVA: 0x71DF620
        public void RaycastAll_Internal_Injected(){} // RVA: 0x71DF6A0
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x71DF730
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x71DF7C0
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x71DF850
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x71DF8E0
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x71DF970
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x71DF9E0
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x71DFA60
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x71DFAF0
        public void GetColliderContactsArray_Injected(){} // RVA: 0x71DFB80
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x71DFBF0
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x71DFC70
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x71DFCE0
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x71DFD50
        public void GetColliderContactsList_Injected(){} // RVA: 0x71DFDC0
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x71DFE30
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x71DFEB0
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x71DFF20
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x71DFF90
    }

    public class PhysicsMaterial2D
    {
        public object maximumChunksOverride;
        public object maximumLOD;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71EF950
        public void Create_Internal(){} // RVA: 0x71EF9E0
        public void get_bounciness(){} // RVA: 0x71EFA40
        public void set_bounciness(){} // RVA: 0x71EFA90
        public void get_friction(){} // RVA: 0x71EFAF0
        public void set_friction(){} // RVA: 0x71EFB40
    }

    public class PhysicsScene
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x72082F0
        public void op_Equality(){} // RVA: 0x711FA10
        public void op_Inequality(){} // RVA: 0x7149740
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void IsValid(){} // RVA: 0x7208460
        public void IsValid_Internal(){} // RVA: 0x72084C0
        public void IsEmpty(){} // RVA: 0x7208510
        public void IsEmpty_Internal(){} // RVA: 0x7208600
        public void Simulate(){} // RVA: 0x7208650
        public void InterpolateBodies(){} // RVA: 0x7208830
        public void ResetInterpolationPoses(){} // RVA: 0x7208A20
        public void Raycast(){} // RVA: 0x7209130 | overloaded x3
        public void Internal_RaycastTest(){} // RVA: 0x7208E00
        public void Internal_Raycast(){} // RVA: 0x72090A0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7209300
        public void Query_CapsuleCast(){} // RVA: 0x7209390
        public void Internal_CapsuleCast(){} // RVA: 0x7209450
        public void CapsuleCast(){} // RVA: 0x7209810 | overloaded x2
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7209750
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7209950
        public void OverlapCapsule(){} // RVA: 0x72099F0
        public void Query_SphereCast(){} // RVA: 0x7209AB0
        public void Internal_SphereCast(){} // RVA: 0x7209B60
        public void SphereCast(){} // RVA: 0x7209EB0 | overloaded x2
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7209E00
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7209FC0
        public void OverlapSphere(){} // RVA: 0x720A050
        public void Query_BoxCast(){} // RVA: 0x720A0F0
        public void Internal_BoxCast(){} // RVA: 0x720A1B0
        public void BoxCast(){} // RVA: 0x720AB00 | overloaded x4
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x720A680
        public void OverlapBox(){} // RVA: 0x720A7F0 | overloaded x2
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x720A900
        public void IsValid_Internal_Injected(){} // RVA: 0x720AC80
        public void IsEmpty_Internal_Injected(){} // RVA: 0x720ACD0
        public void Internal_RaycastTest_Injected(){} // RVA: 0x720AD20
        public void Internal_Raycast_Injected(){} // RVA: 0x720ADB0
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x720AE40
        public void Query_CapsuleCast_Injected(){} // RVA: 0x720AED0
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x720AF60
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x720AFF0
        public void Query_SphereCast_Injected(){} // RVA: 0x720B080
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x720B110
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x720B1A0
        public void Query_BoxCast_Injected(){} // RVA: 0x720B230
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x720B2C0
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x720B350
    }

    public class PhysicsScene2D
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x71C8AC0
        public void op_Equality(){} // RVA: 0x711FA10
        public void op_Inequality(){} // RVA: 0x7149740
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void IsValid(){} // RVA: 0x71C8C30
        public void IsValid_Internal(){} // RVA: 0x71C8C90
        public void IsEmpty(){} // RVA: 0x71C8CE0
        public void IsEmpty_Internal(){} // RVA: 0x71C8DD0
        public void Simulate(){} // RVA: 0x71C8E20
        public void Linecast(){} // RVA: 0x71C9420 | overloaded x5
        public void Linecast_Internal(){} // RVA: 0x71C9160
        public void LinecastArray_Internal(){} // RVA: 0x71C93A0
        public void LinecastNonAllocList_Internal(){} // RVA: 0x71C94C0
        public void Raycast(){} // RVA: 0x71C9AC0 | overloaded x5
        public void Raycast_Internal(){} // RVA: 0x71C97A0
        public void RaycastArray_Internal(){} // RVA: 0x71C9A20
        public void RaycastList_Internal(){} // RVA: 0x71C9B80
        public void CircleCast(){} // RVA: 0x71CA200 | overloaded x5
        public void CircleCast_Internal(){} // RVA: 0x71C9EC0
        public void CircleCastArray_Internal(){} // RVA: 0x71CA160
        public void CircleCastList_Internal(){} // RVA: 0x71CA2D0
        public void BoxCast(){} // RVA: 0x71CA9E0 | overloaded x5
        public void BoxCast_Internal(){} // RVA: 0x71CA640
        public void BoxCastArray_Internal(){} // RVA: 0x71CA930
        public void BoxCastList_Internal(){} // RVA: 0x71CAAD0
        public void CapsuleCast(){} // RVA: 0x71CB240 | overloaded x5
        public void CapsuleCast_Internal(){} // RVA: 0x71CAE70
        public void CapsuleCastArray_Internal(){} // RVA: 0x71CB180
        public void CapsuleCastList_Internal(){} // RVA: 0x71CB330
        public void GetRayIntersection(){} // RVA: 0x71CB590 | overloaded x2
        public void GetRayIntersection_Internal(){} // RVA: 0x71CB4F0
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x71CB640
        public void OverlapPoint(){} // RVA: 0x71CBA80 | overloaded x5
        public void OverlapPoint_Internal(){} // RVA: 0x71CB820
        public void OverlapPointArray_Internal(){} // RVA: 0x71CBA00
        public void OverlapPointList_Internal(){} // RVA: 0x71CBB10
        public void OverlapCircle(){} // RVA: 0x71CBFC0 | overloaded x5
        public void OverlapCircle_Internal(){} // RVA: 0x71CBD00
        public void OverlapCircleArray_Internal(){} // RVA: 0x71CBF30
        public void OverlapCircleList_Internal(){} // RVA: 0x71CC070
        public void OverlapBox(){} // RVA: 0x71CC5C0 | overloaded x5
        public void OverlapBox_Internal(){} // RVA: 0x71CC2B0
        public void OverlapBoxArray_Internal(){} // RVA: 0x71CC520
        public void OverlapBoxList_Internal(){} // RVA: 0x71CC680
        public void OverlapArea(){} // RVA: 0x71CCC30 | overloaded x5
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x71CCA90 | overloaded x2
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x71CCC80
        public void OverlapCapsule(){} // RVA: 0x71CD2F0 | overloaded x5
        public void OverlapCapsule_Internal(){} // RVA: 0x71CCFE0
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x71CD250
        public void OverlapCapsuleList_Internal(){} // RVA: 0x71CD3B0
        public void OverlapCollider(){} // RVA: 0x71CD5F0 | overloaded x3
        public void OverlapColliderArray_Internal(){} // RVA: 0x71CD580
        public void OverlapColliderList_Internal(){} // RVA: 0x71CD670
        public void IsValid_Internal_Injected(){} // RVA: 0x71CD6E0
        public void IsEmpty_Internal_Injected(){} // RVA: 0x71CD730
        public void Linecast_Internal_Injected(){} // RVA: 0x71CD780
        public void LinecastArray_Internal_Injected(){} // RVA: 0x71CD810
        public void LinecastNonAllocList_Internal_Injected(){} // RVA: 0x71CD8A0
        public void Raycast_Internal_Injected(){} // RVA: 0x71CD930
        public void RaycastArray_Internal_Injected(){} // RVA: 0x71CD9C0
        public void RaycastList_Internal_Injected(){} // RVA: 0x71CDA50
        public void CircleCast_Internal_Injected(){} // RVA: 0x71CDAE0
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x71CDB70
        public void CircleCastList_Internal_Injected(){} // RVA: 0x71CDC00
        public void BoxCast_Internal_Injected(){} // RVA: 0x71CDC90
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x71CDD20
        public void BoxCastList_Internal_Injected(){} // RVA: 0x71CDDB0
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x71CDE40
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x71CDED0
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x71CDF60
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x71CDFF0
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x71CE080
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x71CE110
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x71CE180
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x71CE200
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x71CE280
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x71CE300
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x71CE390
        public void OverlapBox_Internal_Injected(){} // RVA: 0x71CE420
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x71CE4B0
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x71CE540
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x71CE5D0
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x71CE660
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x71CE6F0
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x71CE780
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x71CE7F0
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
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Plane
    {
        public int size;
        public UnityEngine.Vector3 m_Normal; // 0x10
        public float m_Distance; // 0x1C

        // ── Methods ──
        public void get_normal(){} // RVA: 0x7079450
        public void set_normal(){} // RVA: 0x210E450
        public void get_distance(){} // RVA: 0x300D00
        public void set_distance(){} // RVA: 0x1F78380
        public void .ctor(){} // RVA: 0x61C3A00 | overloaded x3
        public void SetNormalAndPosition(){} // RVA: 0x481C20
        public void Set3Points(){} // RVA: 0x61C3A00
        public void Flip(){} // RVA: 0x70CD360
        public void get_flipped(){} // RVA: 0x70CD3B0
        public void Translate(){} // RVA: 0x70CD520 | overloaded x2
        public void ClosestPointOnPlane(){} // RVA: 0x70CD630
        public void GetDistanceToPoint(){} // RVA: 0x70CD6C0
        public void GetSide(){} // RVA: 0x70CD710
        public void SameSide(){} // RVA: 0x70CD760
        public void Raycast(){} // RVA: 0x98A560
        public void ToString(){} // RVA: 0x70CD820 | overloaded x3
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
        public void get_useOneWay(){} // RVA: 0x71EECB0
        public void set_useOneWay(){} // RVA: 0x71EED00
        public void get_useOneWayGrouping(){} // RVA: 0x71EED60
        public void set_useOneWayGrouping(){} // RVA: 0x71EEDB0
        public void get_useSideFriction(){} // RVA: 0x71EEE10
        public void set_useSideFriction(){} // RVA: 0x71EEE60
        public void get_useSideBounce(){} // RVA: 0x71EEEC0
        public void set_useSideBounce(){} // RVA: 0x71EEF10
        public void get_surfaceArc(){} // RVA: 0x71EEF70
        public void set_surfaceArc(){} // RVA: 0x71EEFC0
        public void get_sideArc(){} // RVA: 0x71EF020
        public void set_sideArc(){} // RVA: 0x71EF070
        public void get_rotationalOffset(){} // RVA: 0x71EF0D0
        public void set_rotationalOffset(){} // RVA: 0x71EF120
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PlayerConnectionInternal
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x711EB10
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x711EC70
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x711EDD0
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x711EE20
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x711EEB0
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x711EF40
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x711EF90
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x711EFE0
        public void IsConnected(){} // RVA: 0x711EF90
        public void Initialize(){} // RVA: 0x711EF40
        public void RegisterInternal(){} // RVA: 0x711F030
        public void UnregisterInternal(){} // RVA: 0x711F080
        public void SendMessage(){} // RVA: 0x711F0D0
        public void TrySendMessage(){} // RVA: 0x711F140
        public void PollInternal(){} // RVA: 0x711EDD0
        public void DisconnectAll(){} // RVA: 0x711EFE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PlayerPrefs
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x711F210
        public void TrySetFloat(){} // RVA: 0x711F270
        public void TrySetSetString(){} // RVA: 0x711F2D0
        public void SetInt(){} // RVA: 0x711F330
        public void GetInt(){} // RVA: 0x711F440 | overloaded x2
        public void SetFloat(){} // RVA: 0x711F4A0
        public void GetFloat(){} // RVA: 0x711F5B0 | overloaded x2
        public void SetString(){} // RVA: 0x711F610
        public void GetString(){} // RVA: 0x711F720 | overloaded x2
        public void HasKey(){} // RVA: 0x145EC40
        public void DeleteKey(){} // RVA: 0x711F7B0
        public void DeleteAll(){} // RVA: 0x711F800
        public void Save(){} // RVA: 0x145EB90
    }

    public class PlayerPrefsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x711F1B0
    }

    public class PointEffector2D
    {
        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x71EE730
        public void set_forceMagnitude(){} // RVA: 0x71EE780
        public void get_forceVariation(){} // RVA: 0x71EE7E0
        public void set_forceVariation(){} // RVA: 0x71EE830
        public void get_distanceScale(){} // RVA: 0x71EE890
        public void set_distanceScale(){} // RVA: 0x71EE8E0
        public void get_drag(){} // RVA: 0x71EE940
        public void set_drag(){} // RVA: 0x71EE990
        public void get_angularDrag(){} // RVA: 0x71EE9F0
        public void set_angularDrag(){} // RVA: 0x71EEA40
        public void get_forceSource(){} // RVA: 0x71EEAA0
        public void set_forceSource(){} // RVA: 0x71EEAF0
        public void get_forceTarget(){} // RVA: 0x71EEB50
        public void set_forceTarget(){} // RVA: 0x71EEBA0
        public void get_forceMode(){} // RVA: 0x71EEC00
        public void set_forceMode(){} // RVA: 0x71EEC50
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PolygonCollider2D
    {
        public object force;
        public object relativeForce;
        public object torque;
        public object relativeTorque;

        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x71E9E70
        public void set_useDelaunayMesh(){} // RVA: 0x71E9EC0
        public void get_autoTiling(){} // RVA: 0x71E9F20
        public void set_autoTiling(){} // RVA: 0x71E9F70
        public void GetTotalPointCount(){} // RVA: 0x71E9FD0
        public void get_points(){} // RVA: 0x71EA020
        public void set_points(){} // RVA: 0x71EA070
        public void get_pathCount(){} // RVA: 0x71EA0D0
        public void set_pathCount(){} // RVA: 0x71EA120
        public void GetPath(){} // RVA: 0x71EA4F0 | overloaded x2
        public void GetPath_Internal(){} // RVA: 0x71EA330
        public void SetPath(){} // RVA: 0x71EA730 | overloaded x2
        public void SetPath_Internal(){} // RVA: 0x71EA480
        public void GetPathList_Internal(){} // RVA: 0x71EA6C0
        public void SetPathList_Internal(){} // RVA: 0x71EA820
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Pose
    {
        public UnityEngine.Vector3 position; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49C5490
        public void ToString(){} // RVA: 0x7135680
        public void GetTransformedBy(){} // RVA: 0x71357A0
        public void get_identity(){} // RVA: 0x7135AA0
        public void Equals(){} // RVA: 0x7135BE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7135C90
        public void .cctor(){} // RVA: 0x7135D70
    }

    public class PreferBinarySerialization
    {
    }

    public class PreloadData
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x2DD310
    }

    public class Projector
    {
        public object material;

        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x70F0A60
        public void set_nearClipPlane(){} // RVA: 0x70F0AB0
        public void get_farClipPlane(){} // RVA: 0x70F0B10
        public void set_farClipPlane(){} // RVA: 0x70F0B60
        public void get_fieldOfView(){} // RVA: 0x70F0BC0
        public void set_fieldOfView(){} // RVA: 0x70F0C10
        public void get_aspectRatio(){} // RVA: 0x70F0C70
        public void set_aspectRatio(){} // RVA: 0x70F0CC0
        public void get_orthographic(){} // RVA: 0x70F0D20
        public void set_orthographic(){} // RVA: 0x70F0D70
        public void get_orthographicSize(){} // RVA: 0x70F0DD0
        public void set_orthographicSize(){} // RVA: 0x70F0E20
        public void get_ignoreLayers(){} // RVA: 0x70F0E80
        public void set_ignoreLayers(){} // RVA: 0x70F0ED0
        public void get_material(){} // RVA: 0x70F0F30
        public void set_material(){} // RVA: 0x70F0F80
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PropertyName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x711FA00
        public void op_Equality(){} // RVA: 0x711FA10
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x711F8D0
        public void ToString(){} // RVA: 0x711FAA0
    }

    public class PropertyNameUtils
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x711F8D0
        public void PropertyNameFromString_Injected(){} // RVA: 0x711F930
    }

}