// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 1164

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent : ValueType
    {
        public object m_Intersection;
        public object m_Normal;
        public object m_Velocity;
        public object m_ColliderInstanceID;

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x959BB0
        public void get_colliderComponent(){} // RVA: 0x9828C0
        public void InstanceIDToColliderComponent(){} // RVA: 0x7CDBCD0
        public void InstanceIDToColliderComponent_Injected(){} // RVA: 0x7CDBD50
    }

    public class ParticleCollisionEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ParticlePhysicsExtensions : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7CD5A30
    }

    public class ParticleSystem : Component
    {
        // ── Methods ──
        public void Emit(){} // RVA: 0x7CB21D0
        public void get_startDelay(){} // RVA: 0x7CAE340
        public void set_startDelay(){} // RVA: 0x7CAE3F0
        public void get_loop(){} // RVA: 0x7CAE4B0
        public void set_loop(){} // RVA: 0x7CAE570
        public void get_playOnAwake(){} // RVA: 0x7CAE630
        public void set_playOnAwake(){} // RVA: 0x7CAE6F0
        public void get_duration(){} // RVA: 0x7CAE7B0
        public void get_playbackSpeed(){} // RVA: 0x7CAE860
        public void set_playbackSpeed(){} // RVA: 0x7CAE910
        public void get_enableEmission(){} // RVA: 0x7CAE9D0
        public void set_enableEmission(){} // RVA: 0x7CAEA90
        public void get_emissionRate(){} // RVA: 0x7CAEB50
        public void set_emissionRate(){} // RVA: 0x7CAEC00
        public void get_startSpeed(){} // RVA: 0x7CAECB0
        public void set_startSpeed(){} // RVA: 0x7CAED60
        public void get_startSize(){} // RVA: 0x7CAEE20
        public void set_startSize(){} // RVA: 0x7CAEED0
        public void get_startColor(){} // RVA: 0x7CAEF90
        public void set_startColor(){} // RVA: 0x7CAF040
        public void get_startRotation(){} // RVA: 0x7CAF110
        public void set_startRotation(){} // RVA: 0x7CAF1C0
        public void get_startRotation3D(){} // RVA: 0x7CAF280
        public void set_startRotation3D(){} // RVA: 0x7CAF4C0
        public void get_startLifetime(){} // RVA: 0x7CAF610
        public void set_startLifetime(){} // RVA: 0x7CAF6C0
        public void get_gravityModifier(){} // RVA: 0x7CAF780
        public void set_gravityModifier(){} // RVA: 0x7CAF830
        public void get_maxParticles(){} // RVA: 0x7CAF8F0
        public void set_maxParticles(){} // RVA: 0x7CAF9B0
        public void get_simulationSpace(){} // RVA: 0x7CAFA70
        public void set_simulationSpace(){} // RVA: 0x7CAFB30
        public void get_scalingMode(){} // RVA: 0x7CAFBF0
        public void set_scalingMode(){} // RVA: 0x7CAFCB0
        public void get_automaticCullingEnabled(){} // RVA: 0x7CAFD70
        public void get_isPlaying(){} // RVA: 0x7CAFE10
        public void get_isEmitting(){} // RVA: 0x7CAFEB0
        public void get_isStopped(){} // RVA: 0x7CAFF50
        public void get_isPaused(){} // RVA: 0x7CAFFF0
        public void get_particleCount(){} // RVA: 0x7CB0090
        public void get_time(){} // RVA: 0x7CB0130
        public void set_time(){} // RVA: 0x7CB01D0
        public void get_totalTime(){} // RVA: 0x7CB0280
        public void get_randomSeed(){} // RVA: 0x7CB0320
        public void set_randomSeed(){} // RVA: 0x7CB03C0
        public void get_useAutoRandomSeed(){} // RVA: 0x7CB0470
        public void set_useAutoRandomSeed(){} // RVA: 0x7CB0510
        public void get_proceduralSimulationSupported(){} // RVA: 0x7CAFD70
        public void GetParticleCurrentSize(){} // RVA: 0x7CB05C0
        public void GetParticleCurrentSize3D(){} // RVA: 0x7CB0670
        public void GetParticleCurrentColor(){} // RVA: 0x7CB0740
        public void GetParticleMeshIndex(){} // RVA: 0x7CB0800
        public void SetParticles(){} // RVA: 0x7CB0D10
        public void SetParticlesWithNativeArray(){} // RVA: 0x7CB0A60
        public void GetParticles(){} // RVA: 0x7CB1290
        public void GetParticlesWithNativeArray(){} // RVA: 0x7CB0FE0
        public void SetCustomParticleData(){} // RVA: 0x7CB1370
        public void GetCustomParticleData(){} // RVA: 0x7CB1590
        public void GetPlaybackState(){} // RVA: 0x7CB17B0
        public void SetPlaybackState(){} // RVA: 0x7CB1870
        public void GetTrailDataInternal(){} // RVA: 0x7CB1920
        public void GetTrails(){} // RVA: 0x7CB1AC0
        public void SetTrails(){} // RVA: 0x7CB1B30
        public void Simulate(){} // RVA: 0x7CB1D00
        public void Play(){} // RVA: 0x7CB1DE0
        public void Pause(){} // RVA: 0x7CB1EA0
        public void Stop(){} // RVA: 0x7CB1F80
        public void Clear(){} // RVA: 0x7CB2050
        public void IsAlive(){} // RVA: 0x7CB2110
        public void Emit_Internal(){} // RVA: 0x7CB2120
        public void EmitOld_Internal(){} // RVA: 0x7CB2290
        public void TriggerSubEmitter(){} // RVA: 0x7CB2470
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7CB2490
        public void TriggerSubEmitterForParticles(){} // RVA: 0x7CB2550
        public void TriggerSubEmitterForAllParticles(){} // RVA: 0x7CB2880
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7CB2930
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7CB2980
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7CB29E0
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7CB2A80
        public void AllocateCustomDataAttribute(){} // RVA: 0x7CB2B20
        public void get_has3DParticleRotations(){} // RVA: 0x7CB2BD0
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7CB2C70
        public void GetManagedJobData(){} // RVA: 0x7CB2D10
        public void GetManagedJobHandle(){} // RVA: 0x7CB2DB0
        public void SetManagedJobHandle(){} // RVA: 0x7CB2E70
        public void ScheduleManagedJob(){} // RVA: 0x7CB2F20
        public void CopyManagedJobData(){} // RVA: 0x7CB2FA0
        public void UserJobCanBeScheduled(){} // RVA: 0x7CB3000
        public void get_main(){} // RVA: 0x18D7680
        public void get_emission(){} // RVA: 0x18D7680
        public void get_shape(){} // RVA: 0x18D7680
        public void get_velocityOverLifetime(){} // RVA: 0x18D7680
        public void get_limitVelocityOverLifetime(){} // RVA: 0x18D7680
        public void get_inheritVelocity(){} // RVA: 0x18D7680
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x18D7680
        public void get_forceOverLifetime(){} // RVA: 0x18D7680
        public void get_colorOverLifetime(){} // RVA: 0x18D7680
        public void get_colorBySpeed(){} // RVA: 0x18D7680
        public void get_sizeOverLifetime(){} // RVA: 0x18D7680
        public void get_sizeBySpeed(){} // RVA: 0x18D7680
        public void get_rotationOverLifetime(){} // RVA: 0x18D7680
        public void get_rotationBySpeed(){} // RVA: 0x18D7680
        public void get_externalForces(){} // RVA: 0x18D7680
        public void get_noise(){} // RVA: 0x18D7680
        public void get_collision(){} // RVA: 0x18D7680
        public void get_trigger(){} // RVA: 0x18D7680
        public void get_subEmitters(){} // RVA: 0x18D7680
        public void get_textureSheetAnimation(){} // RVA: 0x18D7680
        public void get_lights(){} // RVA: 0x18D7680
        public void get_trails(){} // RVA: 0x18D7680
        public void get_customData(){} // RVA: 0x18D7680
        public void .ctor(){} // RVA: 0xB43D60
        public void get_isPlaying_Injected(){} // RVA: 0x7CB3050
        public void get_isEmitting_Injected(){} // RVA: 0x7CB30A0
        public void get_isStopped_Injected(){} // RVA: 0x7CB30F0
        public void get_isPaused_Injected(){} // RVA: 0x7CB3140
        public void get_particleCount_Injected(){} // RVA: 0x7CB3190
        public void get_time_Injected(){} // RVA: 0x7CB31E0
        public void set_time_Injected(){} // RVA: 0x7CB3230
        public void get_totalTime_Injected(){} // RVA: 0x7CB3290
        public void get_randomSeed_Injected(){} // RVA: 0x7CB32E0
        public void set_randomSeed_Injected(){} // RVA: 0x7CB3330
        public void get_useAutoRandomSeed_Injected(){} // RVA: 0x7CB3390
        public void set_useAutoRandomSeed_Injected(){} // RVA: 0x7CB33E0
        public void get_proceduralSimulationSupported_Injected(){} // RVA: 0x7CB3440
        public void GetParticleCurrentSize_Injected(){} // RVA: 0x7CB3490
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7CB34F0
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7CB3560
        public void GetParticleMeshIndex_Injected(){} // RVA: 0x7CB35D0
        public void SetParticles_Injected(){} // RVA: 0x7CB3630
        public void SetParticlesWithNativeArray_Injected(){} // RVA: 0x7CB36B0
        public void GetParticles_Injected(){} // RVA: 0x7CB3740
        public void GetParticlesWithNativeArray_Injected(){} // RVA: 0x7CB37C0
        public void SetCustomParticleData_Injected(){} // RVA: 0x7CB3850
        public void GetCustomParticleData_Injected(){} // RVA: 0x7CB38C0
        public void GetPlaybackState_Injected(){} // RVA: 0x7CB3930
        public void SetPlaybackState_Injected(){} // RVA: 0x7CB3990
        public void GetTrailDataInternal_Injected(){} // RVA: 0x7CB39F0
        public void SetTrails_Injected(){} // RVA: 0x7CB3A50
        public void Simulate_Injected(){} // RVA: 0x7CB3AB0
        public void Play_Injected(){} // RVA: 0x7CB3B40
        public void Pause_Injected(){} // RVA: 0x7CB3BA0
        public void Stop_Injected(){} // RVA: 0x7CB3C00
        public void Clear_Injected(){} // RVA: 0x7CB3C70
        public void IsAlive_Injected(){} // RVA: 0x7CB3CD0
        public void Emit_Internal_Injected(){} // RVA: 0x7CB3D30
        public void Emit_Injected(){} // RVA: 0x7CB3D90
        public void EmitOld_Internal_Injected(){} // RVA: 0x7CB3E00
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7CB3E60
        public void TriggerSubEmitterForParticles_Injected(){} // RVA: 0x7CB3ED0
        public void TriggerSubEmitterForAllParticles_Injected(){} // RVA: 0x7CB3F40
        public void AllocateAxisOfRotationAttribute_Injected(){} // RVA: 0x7CB3FA0
        public void AllocateMeshIndexAttribute_Injected(){} // RVA: 0x7CB3FF0
        public void AllocateCustomDataAttribute_Injected(){} // RVA: 0x7CB4040
        public void get_has3DParticleRotations_Injected(){} // RVA: 0x7CB40A0
        public void get_hasNonUniformParticleSizes_Injected(){} // RVA: 0x7CB40F0
        public void GetManagedJobData_Injected(){} // RVA: 0x7CB4140
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7CB4190
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7CB41F0
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7CB4250
    }

    public class ParticleSystemExtensionsImpl : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7CDBDA0
        public void GetCollisionEvents_Injected(){} // RVA: 0x7CDC190
    }

    public class ParticleSystemForceField : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ParticleSystemRenderer : Renderer
    {
        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x7CD5A40
        public void DisableVertexStreams(){} // RVA: 0x7CD5A50
        public void AreVertexStreamsEnabled(){} // RVA: 0x7CD5A60
        public void GetEnabledVertexStreams(){} // RVA: 0x7CD5A80
        public void Internal_SetVertexStreams(){} // RVA: 0x7CD5A90
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7CD6120
        public void BakeMesh(){} // RVA: 0x7CD8C10
        public void BakeTrailsMesh(){} // RVA: 0x7CD8DF0
        public void get_alignment(){} // RVA: 0x7CD6840
        public void set_alignment(){} // RVA: 0x7CD68E0
        public void get_renderMode(){} // RVA: 0x7CD6990
        public void set_renderMode(){} // RVA: 0x7CD6A30
        public void get_meshDistribution(){} // RVA: 0x7CD6AE0
        public void set_meshDistribution(){} // RVA: 0x7CD6B80
        public void get_sortMode(){} // RVA: 0x7CD6C30
        public void set_sortMode(){} // RVA: 0x7CD6CD0
        public void get_lengthScale(){} // RVA: 0x7CD6D80
        public void set_lengthScale(){} // RVA: 0x7CD6E20
        public void get_velocityScale(){} // RVA: 0x7CD6ED0
        public void set_velocityScale(){} // RVA: 0x7CD6F70
        public void get_cameraVelocityScale(){} // RVA: 0x7CD7020
        public void set_cameraVelocityScale(){} // RVA: 0x7CD70C0
        public void get_normalDirection(){} // RVA: 0x7CD7170
        public void set_normalDirection(){} // RVA: 0x7CD7210
        public void get_shadowBias(){} // RVA: 0x7CD72C0
        public void set_shadowBias(){} // RVA: 0x7CD7360
        public void get_sortingFudge(){} // RVA: 0x7CD7410
        public void set_sortingFudge(){} // RVA: 0x7CD74B0
        public void get_minParticleSize(){} // RVA: 0x7CD7560
        public void set_minParticleSize(){} // RVA: 0x7CD7600
        public void get_maxParticleSize(){} // RVA: 0x7CD76B0
        public void set_maxParticleSize(){} // RVA: 0x7CD7750
        public void get_pivot(){} // RVA: 0x7CD7800
        public void set_pivot(){} // RVA: 0x7CD78C0
        public void get_flip(){} // RVA: 0x7CD7970
        public void set_flip(){} // RVA: 0x7CD7A30
        public void get_maskInteraction(){} // RVA: 0x7CD7AE0
        public void set_maskInteraction(){} // RVA: 0x7CD7B80
        public void get_trailMaterial(){} // RVA: 0x7CD7C30
        public void set_trailMaterial(){} // RVA: 0x7CD7CF0
        public void set_oldTrailMaterial(){} // RVA: 0x7CD7DD0
        public void get_enableGPUInstancing(){} // RVA: 0x7CD7EB0
        public void set_enableGPUInstancing(){} // RVA: 0x7CD7F50
        public void get_allowRoll(){} // RVA: 0x7CD8000
        public void set_allowRoll(){} // RVA: 0x7CD80A0
        public void get_freeformStretching(){} // RVA: 0x7CD8150
        public void set_freeformStretching(){} // RVA: 0x7CD81F0
        public void get_rotateWithStretchDirection(){} // RVA: 0x7CD82A0
        public void set_rotateWithStretchDirection(){} // RVA: 0x7CD8340
        public void get_mesh(){} // RVA: 0x7CD83F0
        public void set_mesh(){} // RVA: 0x7CD84B0
        public void GetMeshes(){} // RVA: 0x7CD8590
        public void SetMeshes(){} // RVA: 0x7CD8750
        public void GetMeshWeightings(){} // RVA: 0x7CD8830
        public void SetMeshWeightings(){} // RVA: 0x7CD8B00
        public void get_meshCount(){} // RVA: 0x7CD8B20
        public void BakeTexture(){} // RVA: 0x7CD9460
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7CD9270
        public void BakeTextureInternal(){} // RVA: 0x7CD96D0
        public void BakeTrailsTexture(){} // RVA: 0x7CD98F0
        public void BakeTrailsTextureInternal(){} // RVA: 0x7CD9B60
        public void get_activeVertexStreamsCount(){} // RVA: 0x7CD9D20
        public void SetActiveVertexStreams(){} // RVA: 0x7CD9DC0
        public void GetActiveVertexStreams(){} // RVA: 0x7CD9FD0
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7CDA1E0
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7CDA280
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7CDA490
        public void .ctor(){} // RVA: 0xB43D60
        public void get_alignment_Injected(){} // RVA: 0x7CDA6A0
        public void set_alignment_Injected(){} // RVA: 0x7CDA6F0
        public void get_renderMode_Injected(){} // RVA: 0x7CDA750
        public void set_renderMode_Injected(){} // RVA: 0x7CDA7A0
        public void get_meshDistribution_Injected(){} // RVA: 0x7CDA800
        public void set_meshDistribution_Injected(){} // RVA: 0x7CDA850
        public void get_sortMode_Injected(){} // RVA: 0x7CDA8B0
        public void set_sortMode_Injected(){} // RVA: 0x7CDA900
        public void get_lengthScale_Injected(){} // RVA: 0x7CDA960
        public void set_lengthScale_Injected(){} // RVA: 0x7CDA9B0
        public void get_velocityScale_Injected(){} // RVA: 0x7CDAA10
        public void set_velocityScale_Injected(){} // RVA: 0x7CDAA60
        public void get_cameraVelocityScale_Injected(){} // RVA: 0x7CDAAC0
        public void set_cameraVelocityScale_Injected(){} // RVA: 0x7CDAB10
        public void get_normalDirection_Injected(){} // RVA: 0x7CDAB70
        public void set_normalDirection_Injected(){} // RVA: 0x7CDABC0
        public void get_shadowBias_Injected(){} // RVA: 0x7CDAC20
        public void set_shadowBias_Injected(){} // RVA: 0x7CDAC70
        public void get_sortingFudge_Injected(){} // RVA: 0x7CDACD0
        public void set_sortingFudge_Injected(){} // RVA: 0x7CDAD20
        public void get_minParticleSize_Injected(){} // RVA: 0x7CDAD80
        public void set_minParticleSize_Injected(){} // RVA: 0x7CDADD0
        public void get_maxParticleSize_Injected(){} // RVA: 0x7CDAE30
        public void set_maxParticleSize_Injected(){} // RVA: 0x7CDAE80
        public void get_pivot_Injected(){} // RVA: 0x7CDAEE0
        public void set_pivot_Injected(){} // RVA: 0x7CDAF40
        public void get_flip_Injected(){} // RVA: 0x7CDAFA0
        public void set_flip_Injected(){} // RVA: 0x7CDB000
        public void get_maskInteraction_Injected(){} // RVA: 0x7CDB060
        public void set_maskInteraction_Injected(){} // RVA: 0x7CDB0B0
        public void get_trailMaterial_Injected(){} // RVA: 0x7CDB110
        public void set_trailMaterial_Injected(){} // RVA: 0x7CDB160
        public void set_oldTrailMaterial_Injected(){} // RVA: 0x7CDB1C0
        public void get_enableGPUInstancing_Injected(){} // RVA: 0x7CDB220
        public void set_enableGPUInstancing_Injected(){} // RVA: 0x7CDB270
        public void get_allowRoll_Injected(){} // RVA: 0x7CDB2D0
        public void set_allowRoll_Injected(){} // RVA: 0x7CDB320
        public void get_freeformStretching_Injected(){} // RVA: 0x7CDB380
        public void set_freeformStretching_Injected(){} // RVA: 0x7CDB3D0
        public void get_rotateWithStretchDirection_Injected(){} // RVA: 0x7CDB430
        public void set_rotateWithStretchDirection_Injected(){} // RVA: 0x7CDB480
        public void get_mesh_Injected(){} // RVA: 0x7CDB4E0
        public void set_mesh_Injected(){} // RVA: 0x7CDB530
        public void GetMeshes_Injected(){} // RVA: 0x7CDB590
        public void SetMeshes_Injected(){} // RVA: 0x7CDB5F0
        public void GetMeshWeightings_Injected(){} // RVA: 0x7CDB660
        public void SetMeshWeightings_Injected(){} // RVA: 0x7CDB6C0
        public void get_meshCount_Injected(){} // RVA: 0x7CDB730
        public void BakeMesh_Injected(){} // RVA: 0x7CDB780
        public void BakeTrailsMesh_Injected(){} // RVA: 0x7CDB800
        public void BakeTextureNoIndicesInternal_Injected(){} // RVA: 0x7CDB880
        public void BakeTextureInternal_Injected(){} // RVA: 0x7CDB910
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7CDB9A0
        public void get_activeVertexStreamsCount_Injected(){} // RVA: 0x7CDBA30
        public void SetActiveVertexStreams_Injected(){} // RVA: 0x7CDBA80
        public void GetActiveVertexStreams_Injected(){} // RVA: 0x7CDBAE0
        public void get_activeTrailVertexStreamsCount_Injected(){} // RVA: 0x7CDBB40
        public void SetActiveTrailVertexStreams_Injected(){} // RVA: 0x7CDBB90
        public void GetActiveTrailVertexStreams_Injected(){} // RVA: 0x7CDBBF0
    }

    public class ParticleSystemRenderer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ParticleSystemVertexStream[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ParticleSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Physics : Object
    {
        public object ContactModifyEvent;
        public object ContactModifyEventCCD;
        public object GenericContactModifyEvent;
        public object ContactEvent;
        public object s_ReusableCollision;

        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7D22300
        public void PhysXOnSceneContactModify(){} // RVA: 0x7D223B0
        public void GetCurrentIntegrationInfo(){} // RVA: 0x7D22500
        public void get_gravity(){} // RVA: 0x7D22610
        public void set_gravity(){} // RVA: 0x7D226A0
        public void get_bounceThreshold(){} // RVA: 0x7D22730
        public void set_bounceThreshold(){} // RVA: 0x7D22780
        public void get_simulationMode(){} // RVA: 0x7D227E0
        public void set_simulationMode(){} // RVA: 0x7D22830
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7D22880
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7D228D0
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7D22930
        public void get_defaultPhysicsScene(){} // RVA: 0x7D22980
        public void IgnoreCollision(){} // RVA: 0x7D22B00
        public void IgnoreLayerCollision(){} // RVA: 0x7D22BE0
        public void GetIgnoreLayerCollision(){} // RVA: 0x7D22C80
        public void GetIgnoreCollision(){} // RVA: 0x7D22CE0
        public void Raycast(){} // RVA: 0x7D23B60
        public void Linecast(){} // RVA: 0x7D240B0
        public void CapsuleCast(){} // RVA: 0x7D24980
        public void SphereCast(){} // RVA: 0x7D254E0
        public void BoxCast(){} // RVA: 0x7D26000
        public void Internal_RaycastAll(){} // RVA: 0x7D26130
        public void RaycastAll(){} // RVA: 0x7D268B0
        public void RaycastNonAlloc(){} // RVA: 0x7D26FA0
        public void Query_CapsuleCastAll(){} // RVA: 0x7D27080
        public void CapsuleCastAll(){} // RVA: 0x7D275A0
        public void Query_SphereCastAll(){} // RVA: 0x7D27680
        public void SphereCastAll(){} // RVA: 0x7D27E50
        public void OverlapCapsule_Internal(){} // RVA: 0x7D27F60
        public void OverlapCapsule(){} // RVA: 0x7D28230
        public void OverlapSphere_Internal(){} // RVA: 0x7D282E0
        public void OverlapSphere(){} // RVA: 0x7D28550
        public void Simulate_Internal(){} // RVA: 0x7D285E0
        public void Simulate(){} // RVA: 0x7D286A0
        public void InterpolateBodies_Internal(){} // RVA: 0x7D287D0
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7D28860
        public void SyncTransforms(){} // RVA: 0x7D288F0
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7D28940
        public void Query_ComputePenetration(){} // RVA: 0x7D28990
        public void ComputePenetration(){} // RVA: 0x7D28B30
        public void Query_ClosestPoint(){} // RVA: 0x7D28D90
        public void ClosestPoint(){} // RVA: 0x7D28EC0
        public void OverlapSphereNonAlloc(){} // RVA: 0x7D29210
        public void CheckSphere_Internal(){} // RVA: 0x7D292A0
        public void CheckSphere(){} // RVA: 0x7D29510
        public void CapsuleCastNonAlloc(){} // RVA: 0x7D299B0
        public void SphereCastNonAlloc(){} // RVA: 0x7D2A140
        public void CheckCapsule_Internal(){} // RVA: 0x7D2A1E0
        public void CheckCapsule(){} // RVA: 0x7D2A4B0
        public void CheckBox_Internal(){} // RVA: 0x7D2A560
        public void CheckBox(){} // RVA: 0x7D2A8F0
        public void OverlapBox_Internal(){} // RVA: 0x7D2A9D0
        public void OverlapBox(){} // RVA: 0x7D2AD60
        public void OverlapBoxNonAlloc(){} // RVA: 0x7D2B250
        public void BoxCastNonAlloc(){} // RVA: 0x7D2B930
        public void Internal_BoxCastAll(){} // RVA: 0x7D2BA60
        public void BoxCastAll(){} // RVA: 0x7D2C080
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7D2C390
        public void RebuildBroadphaseRegions(){} // RVA: 0x7D2C450
        public void BakeMesh(){} // RVA: 0x7D2C560
        public void GetColliderByInstanceID(){} // RVA: 0x7D2C600
        public void GetBodyByInstanceID(){} // RVA: 0x7D2C6B0
        public void SendOnCollisionEnter(){} // RVA: 0x7D2C760
        public void SendOnCollisionStay(){} // RVA: 0x7D2C830
        public void SendOnCollisionExit(){} // RVA: 0x7D2C900
        public void OnSceneContact(){} // RVA: 0x7D2C9D0
        public void ReportContacts(){} // RVA: 0x7D2CC00
        public void GetCollisionToReport(){} // RVA: 0x7D2D170
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7D2D360
        public void get_gravity_Injected(){} // RVA: 0x7D2D5A0
        public void set_gravity_Injected(){} // RVA: 0x7D2D5F0
        public void IgnoreCollision_Injected(){} // RVA: 0x7D2D640
        public void GetIgnoreCollision_Injected(){} // RVA: 0x7D2D6B0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7D2D710
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7D2D7A0
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7D2D830
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7D2D8C0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7D2D950
        public void Simulate_Internal_Injected(){} // RVA: 0x7D2D9E0
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7D2DA70
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7D2DAC0
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7D2DB10
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7D2DBA0
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7D2DC30
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7D2DCC0
        public void CheckBox_Internal_Injected(){} // RVA: 0x7D2DD50
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7D2DDE0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7D2DE70
        public void RebuildBroadphaseRegions_Injected(){} // RVA: 0x7D2DF00
        public void GetColliderByInstanceID_Injected(){} // RVA: 0x7D2DF60
        public void GetBodyByInstanceID_Injected(){} // RVA: 0x7D2DFB0
        public void SendOnCollisionEnter_Injected(){} // RVA: 0x7D2E000
        public void SendOnCollisionStay_Injected(){} // RVA: 0x7D2E060
        public void SendOnCollisionExit_Injected(){} // RVA: 0x7D2E0C0
    }

    public class Physics2D : Object
    {
        public object m_LastDisabledRigidbody2D;

        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x4005650
        public void get_velocityIterations(){} // RVA: 0x7CE3D50
        public void set_velocityIterations(){} // RVA: 0x7CE3DA0
        public void get_positionIterations(){} // RVA: 0x7CE3DF0
        public void set_positionIterations(){} // RVA: 0x7CE3E40
        public void get_gravity(){} // RVA: 0x7CE3E90
        public void set_gravity(){} // RVA: 0x7CE3F20
        public void get_queriesHitTriggers(){} // RVA: 0x7CE3FB0
        public void get_queriesStartInColliders(){} // RVA: 0x7CE4000
        public void set_queriesStartInColliders(){} // RVA: 0x7CE4050
        public void get_callbacksOnDisable(){} // RVA: 0x7CE40A0
        public void set_callbacksOnDisable(){} // RVA: 0x7CE40F0
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7CE4140
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7CE4190
        public void get_simulationLayers(){} // RVA: 0x7CE41E0
        public void set_simulationLayers(){} // RVA: 0x7CE4270
        public void get_useSubStepping(){} // RVA: 0x7CE4300
        public void set_useSubStepping(){} // RVA: 0x7CE4350
        public void get_useSubStepContacts(){} // RVA: 0x7CE43A0
        public void set_useSubStepContacts(){} // RVA: 0x7CE43F0
        public void get_minSubStepFPS(){} // RVA: 0x7CE4440
        public void set_minSubStepFPS(){} // RVA: 0x7CE4490
        public void get_maxSubStepCount(){} // RVA: 0x7CE44F0
        public void set_maxSubStepCount(){} // RVA: 0x7CE4540
        public void get_bounceThreshold(){} // RVA: 0x7CE4590
        public void set_bounceThreshold(){} // RVA: 0x7CE45E0
        public void get_contactThreshold(){} // RVA: 0x7CE4640
        public void set_contactThreshold(){} // RVA: 0x7CE4690
        public void get_maxLinearCorrection(){} // RVA: 0x7CE46F0
        public void set_maxLinearCorrection(){} // RVA: 0x7CE4740
        public void get_maxAngularCorrection(){} // RVA: 0x7CE47A0
        public void set_maxAngularCorrection(){} // RVA: 0x7CE47F0
        public void get_maxTranslationSpeed(){} // RVA: 0x7CE4850
        public void set_maxTranslationSpeed(){} // RVA: 0x7CE48A0
        public void get_maxRotationSpeed(){} // RVA: 0x7CE4900
        public void set_maxRotationSpeed(){} // RVA: 0x7CE4950
        public void get_baumgarteScale(){} // RVA: 0x7CE49B0
        public void set_baumgarteScale(){} // RVA: 0x7CE4A00
        public void get_baumgarteTOIScale(){} // RVA: 0x7CE4A60
        public void set_baumgarteTOIScale(){} // RVA: 0x7CE4AB0
        public void get_timeToSleep(){} // RVA: 0x7CE4B10
        public void set_timeToSleep(){} // RVA: 0x7CE4B60
        public void get_linearSleepTolerance(){} // RVA: 0x7CE4BC0
        public void set_linearSleepTolerance(){} // RVA: 0x7CE4C10
        public void get_angularSleepTolerance(){} // RVA: 0x7CE4C70
        public void set_angularSleepTolerance(){} // RVA: 0x7CE4CC0
        public void Simulate(){} // RVA: 0x7CE4D80
        public void Simulate_Internal(){} // RVA: 0x7CE4DE0
        public void SyncTransforms(){} // RVA: 0x7CE4E80
        public void IgnoreCollision(){} // RVA: 0x7CE4F40
        public void GetIgnoreCollision(){} // RVA: 0x7CE50A0
        public void GetIgnoreLayerCollision(){} // RVA: 0x7CE51E0
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7CE5320
        public void SetLayerCollisionMask(){} // RVA: 0x7CE5380
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7CE5470
        public void GetLayerCollisionMask(){} // RVA: 0x7CE54D0
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7CE55B0
        public void IsTouching(){} // RVA: 0x7CE5A40
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7CE58E0
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7CE5B80
        public void IsTouchingLayers(){} // RVA: 0x7CE5CE0
        public void Distance(){} // RVA: 0x7CE60E0
        public void Distance_Internal(){} // RVA: 0x7CE6550
        public void DistanceFrom_Internal(){} // RVA: 0x7CE66C0
        public void ClosestPoint(){} // RVA: 0x7CE6A80
        public void ClosestPoint_Collider(){} // RVA: 0x7CE6CA0
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7CE6DB0
        public void Linecast(){} // RVA: 0x7CE7510
        public void LinecastAll(){} // RVA: 0x7CE7890
        public void LinecastAll_Internal(){} // RVA: 0x7CE7980
        public void RaycastNonAlloc(){} // RVA: 0x7CE7AD0
        public void Raycast(){} // RVA: 0x7CE8480
        public void RaycastAll(){} // RVA: 0x7CE8950
        public void RaycastAll_Internal(){} // RVA: 0x7CE8A50
        public void CircleCast(){} // RVA: 0x7CE94D0
        public void CircleCastAll(){} // RVA: 0x7CE99F0
        public void CircleCastAll_Internal(){} // RVA: 0x7CE9B00
        public void BoxCast(){} // RVA: 0x7CEA630
        public void BoxCastAll(){} // RVA: 0x7CEABB0
        public void BoxCastAll_Internal(){} // RVA: 0x7CEACD0
        public void CapsuleCast(){} // RVA: 0x7CEB860
        public void CapsuleCastAll(){} // RVA: 0x7CEBFB0
        public void CapsuleCastAll_Internal(){} // RVA: 0x7CEBBC0
        public void GetRayIntersection(){} // RVA: 0x7CEC4F0
        public void GetRayIntersectionAll(){} // RVA: 0x7CEC710
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7CEC7C0
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7CF30E0
        public void OverlapPoint(){} // RVA: 0x7CED020
        public void OverlapPointAll(){} // RVA: 0x7CED540
        public void OverlapPointAll_Internal(){} // RVA: 0x7CED690
        public void OverlapCircle(){} // RVA: 0x7CEDD00
        public void OverlapCircleAll(){} // RVA: 0x7CEE260
        public void OverlapCircleAll_Internal(){} // RVA: 0x7CEE3C0
        public void OverlapBox(){} // RVA: 0x7CEEAF0
        public void OverlapBoxAll(){} // RVA: 0x7CEEF50
        public void OverlapBoxAll_Internal(){} // RVA: 0x7CEF050
        public void OverlapArea(){} // RVA: 0x7CEF5B0
        public void OverlapAreaAll(){} // RVA: 0x7CEF850
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7CEF8F0
        public void OverlapCapsule(){} // RVA: 0x7CF0110
        public void OverlapCapsuleAll(){} // RVA: 0x7CF0730
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7CF08D0
        public void OverlapCollider(){} // RVA: 0x7CF0990
        public void GetContacts(){} // RVA: 0x7CF23B0
        public void GetColliderContactsArray(){} // RVA: 0x7CF13B0
        public void GetColliderColliderContactsArray(){} // RVA: 0x7CF1540
        public void GetRigidbodyContactsArray(){} // RVA: 0x7CF1730
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7CF18C0
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7CF1A00
        public void GetColliderContactsList(){} // RVA: 0x7CF2530
        public void GetColliderColliderContactsList(){} // RVA: 0x7CF27A0
        public void GetRigidbodyContactsList(){} // RVA: 0x7CF2A60
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7CF2CD0
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7CF2E10
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7CF3270
        public void get_gravity_Injected(){} // RVA: 0x7CF3350
        public void set_gravity_Injected(){} // RVA: 0x7CF33A0
        public void get_simulationLayers_Injected(){} // RVA: 0x7CF33F0
        public void set_simulationLayers_Injected(){} // RVA: 0x7CF3440
        public void Simulate_Internal_Injected(){} // RVA: 0x7CF3490
        public void IgnoreCollision_Injected(){} // RVA: 0x7CF3500
        public void GetIgnoreCollision_Injected(){} // RVA: 0x7CF3570
        public void IsTouching_Injected(){} // RVA: 0x7CF35D0
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7CF3630
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7CF36A0
        public void IsTouchingLayers_Injected(){} // RVA: 0x7CF3700
        public void Distance_Internal_Injected(){} // RVA: 0x7CF3760
        public void DistanceFrom_Internal_Injected(){} // RVA: 0x7CF37D0
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7CF3860
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7CF38D0
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7CF3940
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7CF39D0
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7CF3A60
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7CF3AF0
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7CF3B80
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7CF3C10
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7CF3CA0
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7CF3D10
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7CF3D90
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7CF3E20
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7CF3EB0
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7CF3F20
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7CF3FA0
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7CF4010
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7CF4080
        public void GetColliderContactsList_Injected(){} // RVA: 0x7CF40F0
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7CF4160
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7CF41E0
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7CF4250
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7CF42C0
    }

    public class Physics2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PhysicsMaterial : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D31E30
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7D31E90
        public void get_bounciness(){} // RVA: 0x7D31FE0
        public void set_bounciness(){} // RVA: 0x7D32080
        public void get_dynamicFriction(){} // RVA: 0x7D32130
        public void set_dynamicFriction(){} // RVA: 0x7D321D0
        public void get_staticFriction(){} // RVA: 0x7D32280
        public void set_staticFriction(){} // RVA: 0x7D32320
        public void get_frictionCombine(){} // RVA: 0x7D323D0
        public void set_frictionCombine(){} // RVA: 0x7D32470
        public void get_bounceCombine(){} // RVA: 0x7D32520
        public void set_bounceCombine(){} // RVA: 0x7D325C0
        public void Internal_CreateDynamicsMaterial_Injected(){} // RVA: 0x7D32670
        public void get_bounciness_Injected(){} // RVA: 0x7D326D0
        public void set_bounciness_Injected(){} // RVA: 0x7D32720
        public void get_dynamicFriction_Injected(){} // RVA: 0x7D32780
        public void set_dynamicFriction_Injected(){} // RVA: 0x7D327D0
        public void get_staticFriction_Injected(){} // RVA: 0x7D32830
        public void set_staticFriction_Injected(){} // RVA: 0x7D32880
        public void get_frictionCombine_Injected(){} // RVA: 0x7D328E0
        public void set_frictionCombine_Injected(){} // RVA: 0x7D32930
        public void get_bounceCombine_Injected(){} // RVA: 0x7D32990
        public void set_bounceCombine_Injected(){} // RVA: 0x7D329E0
    }

    public class PhysicsMaterial2D : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D162D0
        public void GetCombinedValues(){} // RVA: 0x7D16330
        public void Create_Internal(){} // RVA: 0x7D163B0
        public void get_bounciness(){} // RVA: 0x7D16500
        public void set_bounciness(){} // RVA: 0x7D165A0
        public void get_friction(){} // RVA: 0x7D16650
        public void set_friction(){} // RVA: 0x7D166F0
        public void get_frictionCombine(){} // RVA: 0x7D167A0
        public void set_frictionCombine(){} // RVA: 0x7D16840
        public void get_bounceCombine(){} // RVA: 0x7D168F0
        public void set_bounceCombine(){} // RVA: 0x7D16990
        public void Create_Internal_Injected(){} // RVA: 0x7D16A40
        public void get_bounciness_Injected(){} // RVA: 0x7D16AA0
        public void set_bounciness_Injected(){} // RVA: 0x7D16AF0
        public void get_friction_Injected(){} // RVA: 0x7D16B50
        public void set_friction_Injected(){} // RVA: 0x7D16BA0
        public void get_frictionCombine_Injected(){} // RVA: 0x7D16C00
        public void set_frictionCombine_Injected(){} // RVA: 0x7D16C50
        public void get_bounceCombine_Injected(){} // RVA: 0x7D16CB0
        public void set_bounceCombine_Injected(){} // RVA: 0x7D16D00
    }

    public class PhysicsMaterialCombine[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PhysicsMaterial[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PhysicsScene : ValueType
    {
        public object m_index;
        public object m_version;

        // ── Methods ──
        public void ToString(){} // RVA: 0x985960
        public void op_Equality(){} // RVA: 0x7D32B00
        public void op_Inequality(){} // RVA: 0x7D32B20
        public void GetHashCode(){} // RVA: 0x985970
        public void Equals(){} // RVA: 0x985990
        public void IsValid(){} // RVA: 0x9859B0
        public void IsValid_Internal(){} // RVA: 0x7D32CD0
        public void GetDefaultScene(){} // RVA: 0x7D22980
        public void IsEmpty(){} // RVA: 0x985A10
        public void IsEmpty_Internal(){} // RVA: 0x7D32E10
        public void Simulate(){} // RVA: 0x985A20
        public void RunSimulationStages(){} // RVA: 0x985A30
        public void InterpolateBodies(){} // RVA: 0x985A40
        public void ResetInterpolationPoses(){} // RVA: 0x985A50
        public void Raycast(){} // RVA: 0x985B50
        public void Internal_RaycastTest(){} // RVA: 0x7D33850
        public void Internal_Raycast(){} // RVA: 0x7D33AF0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7D33D90
        public void Query_CapsuleCast(){} // RVA: 0x7D33EA0
        public void Internal_CapsuleCast(){} // RVA: 0x7D33F60
        public void CapsuleCast(){} // RVA: 0x985C80
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7D34270
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7D345A0
        public void OverlapCapsule(){} // RVA: 0x985D30
        public void Query_SphereCast(){} // RVA: 0x7D34700
        public void Internal_SphereCast(){} // RVA: 0x7D347B0
        public void SphereCast(){} // RVA: 0x985E70
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7D34A60
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7D34D40
        public void OverlapSphere(){} // RVA: 0x985EF0
        public void Query_BoxCast(){} // RVA: 0x7D34E70
        public void Internal_BoxCast(){} // RVA: 0x7D34F30
        public void BoxCast(){} // RVA: 0x9863E0
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7D35410
        public void OverlapBox(){} // RVA: 0x9861A0
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7D35690
        public void IsValid_Internal_Injected(){} // RVA: 0x7D35BD0
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7D35C20
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7D35C70
        public void Internal_Raycast_Injected(){} // RVA: 0x7D35D00
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7D35D90
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7D35E20
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7D35EB0
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7D35F40
        public void Query_SphereCast_Injected(){} // RVA: 0x7D35FD0
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7D36060
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7D360F0
        public void Query_BoxCast_Injected(){} // RVA: 0x7D36180
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7D36210
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7D362A0
    }

    public class PhysicsScene2D : ValueType
    {
        public object m_Handle;

        // ── Methods ──
        public void ToString(){} // RVA: 0x982F00
        public void op_Equality(){} // RVA: 0x7BF2630
        public void op_Inequality(){} // RVA: 0x7C28B80
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95FA90
        public void IsValid(){} // RVA: 0x982FA0
        public void IsValid_Internal(){} // RVA: 0x7CDC3C0
        public void IsEmpty(){} // RVA: 0x983000
        public void IsEmpty_Internal(){} // RVA: 0x7CDC500
        public void get_subStepCount(){} // RVA: 0x983010
        public void SubStepCount_Internal(){} // RVA: 0x7CDC5B0
        public void get_subStepLostTime(){} // RVA: 0x983070
        public void SubStepLostTime_Internal(){} // RVA: 0x7CDC660
        public void Simulate(){} // RVA: 0x9830F0
        public void Linecast(){} // RVA: 0x983290
        public void Linecast_Internal(){} // RVA: 0x7CDCB60
        public void LinecastArray_Internal(){} // RVA: 0x7CDCBF0
        public void LinecastList_Internal(){} // RVA: 0x7CDCD00
        public void Raycast(){} // RVA: 0x983440
        public void Raycast_Internal(){} // RVA: 0x7CDD2E0
        public void RaycastArray_Internal(){} // RVA: 0x7CDD380
        public void RaycastList_Internal(){} // RVA: 0x7CDD4A0
        public void CircleCast(){} // RVA: 0x983630
        public void CircleCast_Internal(){} // RVA: 0x7CDDB00
        public void CircleCastArray_Internal(){} // RVA: 0x7CDDBB0
        public void CircleCastList_Internal(){} // RVA: 0x7CDDCF0
        public void BoxCast(){} // RVA: 0x983860
        public void BoxCast_Internal(){} // RVA: 0x7CDE3A0
        public void BoxCastArray_Internal(){} // RVA: 0x7CDE460
        public void BoxCastList_Internal(){} // RVA: 0x7CDE5A0
        public void CapsuleCast(){} // RVA: 0x983AC0
        public void CapsuleCast_Internal(){} // RVA: 0x7CDECB0
        public void CapsuleCastArray_Internal(){} // RVA: 0x7CDED80
        public void CapsuleCastList_Internal(){} // RVA: 0x7CDEED0
        public void GetRayIntersection(){} // RVA: 0x983C00
        public void GetRayIntersection_Internal(){} // RVA: 0x7CDF3C0
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x7CDF460
        public void GetRayIntersectionList_Internal(){} // RVA: 0x7CDF580
        public void OverlapPoint(){} // RVA: 0x983D90
        public void OverlapPoint_Internal(){} // RVA: 0x7CDFBE0
        public void OverlapPointArray_Internal(){} // RVA: 0x7CDFC80
        public void OverlapPointList_Internal(){} // RVA: 0x7CDFD30
        public void OverlapCircle(){} // RVA: 0x983FA0
        public void OverlapCircle_Internal(){} // RVA: 0x7CE02A0
        public void OverlapCircleArray_Internal(){} // RVA: 0x7CE0350
        public void OverlapCircleList_Internal(){} // RVA: 0x7CE0410
        public void OverlapBox(){} // RVA: 0x9841E0
        public void OverlapBox_Internal(){} // RVA: 0x7CE0A10
        public void OverlapBoxArray_Internal(){} // RVA: 0x7CE0AD0
        public void OverlapBoxList_Internal(){} // RVA: 0x7CE0BA0
        public void OverlapArea(){} // RVA: 0x984420
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x9843D0
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x984470
        public void OverlapCapsule(){} // RVA: 0x984640
        public void OverlapCapsule_Internal(){} // RVA: 0x7CE1920
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x7CE19E0
        public void OverlapCapsuleList_Internal(){} // RVA: 0x7CE1AC0
        public void OverlapCollider(){} // RVA: 0x7CE2260
        public void OverlapColliderFilteredArray_Internal(){} // RVA: 0x7CE24C0
        public void OverlapColliderList_Internal(){} // RVA: 0x7CE1E10
        public void OverlapColliderFilteredList_Internal(){} // RVA: 0x7CE25D0
        public void OverlapColliderFromList_Internal(){} // RVA: 0x7CE26E0
        public void OverlapColliderFromFilteredList_Internal(){} // RVA: 0x7CE2800
        public void IsValid_Internal_Injected(){} // RVA: 0x7CE2930
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7CE2980
        public void SubStepCount_Internal_Injected(){} // RVA: 0x7CE29D0
        public void SubStepLostTime_Internal_Injected(){} // RVA: 0x7CE2A20
        public void Linecast_Internal_Injected(){} // RVA: 0x7CE2A70
        public void LinecastArray_Internal_Injected(){} // RVA: 0x7CE2B00
        public void LinecastList_Internal_Injected(){} // RVA: 0x7CE2B90
        public void Raycast_Internal_Injected(){} // RVA: 0x7CE2C20
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7CE2CB0
        public void RaycastList_Internal_Injected(){} // RVA: 0x7CE2D40
        public void CircleCast_Internal_Injected(){} // RVA: 0x7CE2DD0
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x7CE2E60
        public void CircleCastList_Internal_Injected(){} // RVA: 0x7CE2EF0
        public void BoxCast_Internal_Injected(){} // RVA: 0x7CE2F80
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x7CE3010
        public void BoxCastList_Internal_Injected(){} // RVA: 0x7CE30A0
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x7CE3130
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x7CE31C0
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x7CE3250
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x7CE32E0
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x7CE3370
        public void GetRayIntersectionList_Internal_Injected(){} // RVA: 0x7CE3400
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x7CE3490
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x7CE3500
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x7CE3580
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x7CE3600
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x7CE3680
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x7CE3710
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7CE37A0
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x7CE3830
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x7CE38C0
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7CE3950
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x7CE39E0
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x7CE3A70
        public void OverlapColliderFilteredArray_Internal_Injected(){} // RVA: 0x7CE3B00
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7CE3B70
        public void OverlapColliderFilteredList_Internal_Injected(){} // RVA: 0x7CE3BD0
        public void OverlapColliderFromList_Internal_Injected(){} // RVA: 0x7CE3C40
        public void OverlapColliderFromFilteredList_Internal_Injected(){} // RVA: 0x7CE3CC0
    }

    public class PhysicsShape2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PhysicsUpdateBehaviour2D : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Physics[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Plane : ValueType
    {
        public object size;
        public object m_Normal;
        public object m_Distance;

        // ── Methods ──
        public void get_normal(){} // RVA: 0x45A590
        public void set_normal(){} // RVA: 0x45A580
        public void get_distance(){} // RVA: 0x958960
        public void set_distance(){} // RVA: 0xD1B10
        public void .ctor(){} // RVA: 0x961470
        public void SetNormalAndPosition(){} // RVA: 0x9614D0
        public void Set3Points(){} // RVA: 0x961470
        public void Flip(){} // RVA: 0x961510
        public void get_flipped(){} // RVA: 0x961560
        public void Translate(){} // RVA: 0x7B72DC0
        public void ClosestPointOnPlane(){} // RVA: 0x9615E0
        public void GetDistanceToPoint(){} // RVA: 0x961680
        public void GetSide(){} // RVA: 0x9616D0
        public void SameSide(){} // RVA: 0x961720
        public void Raycast(){} // RVA: 0x9617C0
        public void ToString(){} // RVA: 0x961810
    }

    public class Plane[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E395D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlatformEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_useOneWay(){} // RVA: 0x7D14290
        public void set_useOneWay(){} // RVA: 0x7D14330
        public void get_useOneWayGrouping(){} // RVA: 0x7D143E0
        public void set_useOneWayGrouping(){} // RVA: 0x7D14480
        public void get_useSideFriction(){} // RVA: 0x7D14530
        public void set_useSideFriction(){} // RVA: 0x7D145D0
        public void get_useSideBounce(){} // RVA: 0x7D14680
        public void set_useSideBounce(){} // RVA: 0x7D14720
        public void get_surfaceArc(){} // RVA: 0x7D147D0
        public void set_surfaceArc(){} // RVA: 0x7D14870
        public void get_sideArc(){} // RVA: 0x7D14920
        public void set_sideArc(){} // RVA: 0x7D149C0
        public void get_rotationalOffset(){} // RVA: 0x7D14A70
        public void set_rotationalOffset(){} // RVA: 0x7D14B10
        public void .ctor(){} // RVA: 0xB43D60
        public void get_useOneWay_Injected(){} // RVA: 0x7D14BC0
        public void set_useOneWay_Injected(){} // RVA: 0x7D14C10
        public void get_useOneWayGrouping_Injected(){} // RVA: 0x7D14C70
        public void set_useOneWayGrouping_Injected(){} // RVA: 0x7D14CC0
        public void get_useSideFriction_Injected(){} // RVA: 0x7D14D20
        public void set_useSideFriction_Injected(){} // RVA: 0x7D14D70
        public void get_useSideBounce_Injected(){} // RVA: 0x7D14DD0
        public void set_useSideBounce_Injected(){} // RVA: 0x7D14E20
        public void get_surfaceArc_Injected(){} // RVA: 0x7D14E80
        public void set_surfaceArc_Injected(){} // RVA: 0x7D14ED0
        public void get_sideArc_Injected(){} // RVA: 0x7D14F30
        public void set_sideArc_Injected(){} // RVA: 0x7D14F80
        public void get_rotationalOffset_Injected(){} // RVA: 0x7D14FE0
        public void set_rotationalOffset_Injected(){} // RVA: 0x7D15030
    }

    public class PlayerConnectionInternal : Object
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x7BF0520
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x7BF0640
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x7BF0760
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x7BF07B0
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x7BF0800
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x7BF0850
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x7BF08A0
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x7BF08F0
        public void IsConnected(){} // RVA: 0x7BF08A0
        public void Initialize(){} // RVA: 0x7BF0850
        public void RegisterInternal(){} // RVA: 0x7BF0940
        public void UnregisterInternal(){} // RVA: 0x7BF0A80
        public void SendMessage(){} // RVA: 0x7BF0BC0
        public void TrySendMessage(){} // RVA: 0x7BF0DC0
        public void PollInternal(){} // RVA: 0x7BF0760
        public void DisconnectAll(){} // RVA: 0x7BF08F0
        public void .ctor(){} // RVA: 0xB43310
        public void RegisterInternal_Injected(){} // RVA: 0x7BF0FC0
        public void UnregisterInternal_Injected(){} // RVA: 0x7BF1010
        public void SendMessage_Injected(){} // RVA: 0x7BF1060
        public void TrySendMessage_Injected(){} // RVA: 0x7BF10D0
    }

    public class PlayerPrefs : Object
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x7BF11A0
        public void TrySetFloat(){} // RVA: 0x7BF12F0
        public void TrySetSetString(){} // RVA: 0x7BF1450
        public void SetInt(){} // RVA: 0x7BF1650
        public void GetInt(){} // RVA: 0x7BF1810
        public void SetFloat(){} // RVA: 0x7BF1820
        public void GetFloat(){} // RVA: 0x7BF19F0
        public void SetString(){} // RVA: 0x7BF1A00
        public void GetString(){} // RVA: 0x7BF1CB0
        public void HasKey(){} // RVA: 0x7BF1D00
        public void DeleteKey(){} // RVA: 0x7BF1E40
        public void DeleteAll(){} // RVA: 0x7BF1F80
        public void Save(){} // RVA: 0x1D2CA40
        public void TrySetInt_Injected(){} // RVA: 0x7BF1FD0
        public void TrySetFloat_Injected(){} // RVA: 0x7BF2030
        public void TrySetSetString_Injected(){} // RVA: 0x7BF2090
        public void GetInt_Injected(){} // RVA: 0x7BF20F0
        public void GetFloat_Injected(){} // RVA: 0x7BF2150
        public void GetString_Injected(){} // RVA: 0x7BF21B0
        public void HasKey_Injected(){} // RVA: 0x7BF2220
        public void DeleteKey_Injected(){} // RVA: 0x7BF2270
    }

    public class PlayerPrefsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BF1140
    }

    public class PointEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x7D13290
        public void set_forceMagnitude(){} // RVA: 0x7D13330
        public void get_forceVariation(){} // RVA: 0x7D133E0
        public void set_forceVariation(){} // RVA: 0x7D13480
        public void get_distanceScale(){} // RVA: 0x7D13530
        public void set_distanceScale(){} // RVA: 0x7D135D0
        public void get_drag(){} // RVA: 0x7D13680
        public void set_drag(){} // RVA: 0x7D13720
        public void get_angularDrag(){} // RVA: 0x7D137D0
        public void set_angularDrag(){} // RVA: 0x7D13870
        public void get_forceSource(){} // RVA: 0x7D13920
        public void set_forceSource(){} // RVA: 0x7D139C0
        public void get_forceTarget(){} // RVA: 0x7D13A70
        public void set_forceTarget(){} // RVA: 0x7D13B10
        public void get_forceMode(){} // RVA: 0x7D13BC0
        public void set_forceMode(){} // RVA: 0x7D13C60
        public void .ctor(){} // RVA: 0xB43D60
        public void get_forceMagnitude_Injected(){} // RVA: 0x7D13D10
        public void set_forceMagnitude_Injected(){} // RVA: 0x7D13D60
        public void get_forceVariation_Injected(){} // RVA: 0x7D13DC0
        public void set_forceVariation_Injected(){} // RVA: 0x7D13E10
        public void get_distanceScale_Injected(){} // RVA: 0x7D13E70
        public void set_distanceScale_Injected(){} // RVA: 0x7D13EC0
        public void get_drag_Injected(){} // RVA: 0x7D13F20
        public void set_drag_Injected(){} // RVA: 0x7D13F70
        public void get_angularDrag_Injected(){} // RVA: 0x7D13FD0
        public void set_angularDrag_Injected(){} // RVA: 0x7D14020
        public void get_forceSource_Injected(){} // RVA: 0x7D14080
        public void set_forceSource_Injected(){} // RVA: 0x7D140D0
        public void get_forceTarget_Injected(){} // RVA: 0x7D14130
        public void set_forceTarget_Injected(){} // RVA: 0x7D14180
        public void get_forceMode_Injected(){} // RVA: 0x7D141E0
        public void set_forceMode_Injected(){} // RVA: 0x7D14230
    }

    public class PolygonCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7D08460
        public void set_useDelaunayMesh(){} // RVA: 0x7D08500
        public void get_autoTiling(){} // RVA: 0x7D085B0
        public void set_autoTiling(){} // RVA: 0x7D08650
        public void GetTotalPointCount(){} // RVA: 0x7D08700
        public void get_points(){} // RVA: 0x7D087A0
        public void set_points(){} // RVA: 0x7D088E0
        public void get_pathCount(){} // RVA: 0x7D08A00
        public void set_pathCount(){} // RVA: 0x7D08AA0
        public void GetPath(){} // RVA: 0x7D09150
        public void GetPath_Internal(){} // RVA: 0x7D08D00
        public void SetPath(){} // RVA: 0x7D094C0
        public void SetPath_Internal(){} // RVA: 0x7D09010
        public void GetPathList_Internal(){} // RVA: 0x7D092A0
        public void SetPathList_Internal(){} // RVA: 0x7D09560
        public void .ctor(){} // RVA: 0xB43D60
        public void get_useDelaunayMesh_Injected(){} // RVA: 0x7D09780
        public void set_useDelaunayMesh_Injected(){} // RVA: 0x7D097D0
        public void get_autoTiling_Injected(){} // RVA: 0x7D09830
        public void set_autoTiling_Injected(){} // RVA: 0x7D09880
        public void GetTotalPointCount_Injected(){} // RVA: 0x7D098E0
        public void get_points_Injected(){} // RVA: 0x7D09930
        public void set_points_Injected(){} // RVA: 0x7D09990
        public void get_pathCount_Injected(){} // RVA: 0x7D099F0
        public void set_pathCount_Injected(){} // RVA: 0x7D09A40
        public void GetPath_Internal_Injected(){} // RVA: 0x7D09AA0
        public void SetPath_Internal_Injected(){} // RVA: 0x7D09B10
        public void GetPathList_Internal_Injected(){} // RVA: 0x7D09B80
        public void SetPathList_Internal_Injected(){} // RVA: 0x7D09BF0
    }

    public class Pose : ValueType
    {
        public object position;
        public object rotation;
        public object k_Identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DE760
        public void ToString(){} // RVA: 0x9666C0
        public void GetTransformedBy(){} // RVA: 0x9666D0
        public void get_identity(){} // RVA: 0x7C14A00
        public void Equals(){} // RVA: 0x966740
        public void GetHashCode(){} // RVA: 0x9667D0
        public void .cctor(){} // RVA: 0x7C14D10
    }

    public class PreferBinarySerialization[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PreloadData : Object
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0xB43310
    }

    public class PreloadData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PrimitiveType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Projector : Behaviour
    {
        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x7BA9490
        public void set_nearClipPlane(){} // RVA: 0x7BA9530
        public void get_farClipPlane(){} // RVA: 0x7BA95E0
        public void set_farClipPlane(){} // RVA: 0x7BA9680
        public void get_fieldOfView(){} // RVA: 0x7BA9730
        public void set_fieldOfView(){} // RVA: 0x7BA97D0
        public void get_aspectRatio(){} // RVA: 0x7BA9880
        public void set_aspectRatio(){} // RVA: 0x7BA9920
        public void get_orthographic(){} // RVA: 0x7BA99D0
        public void set_orthographic(){} // RVA: 0x7BA9A70
        public void get_orthographicSize(){} // RVA: 0x7BA9B20
        public void set_orthographicSize(){} // RVA: 0x7BA9BC0
        public void get_ignoreLayers(){} // RVA: 0x7BA9C70
        public void set_ignoreLayers(){} // RVA: 0x7BA9D10
        public void get_material(){} // RVA: 0x7BA9DC0
        public void set_material(){} // RVA: 0x7BA9E80
        public void .ctor(){} // RVA: 0xB43D60
        public void get_nearClipPlane_Injected(){} // RVA: 0x7BA9F60
        public void set_nearClipPlane_Injected(){} // RVA: 0x7BA9FB0
        public void get_farClipPlane_Injected(){} // RVA: 0x7BAA010
        public void set_farClipPlane_Injected(){} // RVA: 0x7BAA060
        public void get_fieldOfView_Injected(){} // RVA: 0x7BAA0C0
        public void set_fieldOfView_Injected(){} // RVA: 0x7BAA110
        public void get_aspectRatio_Injected(){} // RVA: 0x7BAA170
        public void set_aspectRatio_Injected(){} // RVA: 0x7BAA1C0
        public void get_orthographic_Injected(){} // RVA: 0x7BAA220
        public void set_orthographic_Injected(){} // RVA: 0x7BAA270
        public void get_orthographicSize_Injected(){} // RVA: 0x7BAA2D0
        public void set_orthographicSize_Injected(){} // RVA: 0x7BAA320
        public void get_ignoreLayers_Injected(){} // RVA: 0x7BAA380
        public void set_ignoreLayers_Injected(){} // RVA: 0x7BAA3D0
        public void get_material_Injected(){} // RVA: 0x7BAA430
        public void set_material_Injected(){} // RVA: 0x7BAA480
    }

    public class PropertyAttribute : Attribute
    {
        public object _applyToCollection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
    }

    public class PropertyAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PropertyName : ValueType
    {
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
        public void IsNullOrEmpty(){} // RVA: 0x7BF2620
        public void op_Equality(){} // RVA: 0x7BF2630
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95FA90
        public void op_Implicit(){} // RVA: 0x7BF26C0
        public void ToString(){} // RVA: 0x9658A0
    }

    public class PropertyNameUtils : Object
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x7BF2420
        public void PropertyNameFromString_Injected(){} // RVA: 0x7BF25A0
    }

    public class PropertyName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5C20
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6FC60
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}