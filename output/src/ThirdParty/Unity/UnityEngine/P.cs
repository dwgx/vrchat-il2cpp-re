// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 41
// Methods: 938

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent : ValueType
    {
        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7A7ED4BD0
        public void get_colliderComponent(){} // RVA: 0x7A7EF3100
        public void InstanceIDToColliderComponent(){} // RVA: 0x7AEFA8000
    }

    public class ParticleCollisionEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1D50
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E31C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250C50
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ParticlePhysicsExtensions : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7AEFA4CF0
    }

    public class ParticleSystem : Component
    {
        // ── Methods ──
        public void Emit(){} // RVA: 0x7AEF8E720
        public void get_startDelay(){} // RVA: 0x7AEF8B650
        public void set_startDelay(){} // RVA: 0x7AEF8B700
        public void get_loop(){} // RVA: 0x7AEF8B7C0
        public void set_loop(){} // RVA: 0x7AEF8B880
        public void get_playOnAwake(){} // RVA: 0x7AEF8B940
        public void set_playOnAwake(){} // RVA: 0x7AEF8BA00
        public void get_duration(){} // RVA: 0x7AEF8BAC0
        public void get_playbackSpeed(){} // RVA: 0x7AEF8BB70
        public void set_playbackSpeed(){} // RVA: 0x7AEF8BC20
        public void get_enableEmission(){} // RVA: 0x7AEF8BCE0
        public void set_enableEmission(){} // RVA: 0x7AEF8BDA0
        public void get_emissionRate(){} // RVA: 0x7AEF8BE60
        public void set_emissionRate(){} // RVA: 0x7AEF8BF10
        public void get_startSpeed(){} // RVA: 0x7AEF8C000
        public void set_startSpeed(){} // RVA: 0x7AEF8C0B0
        public void get_startSize(){} // RVA: 0x7AEF8C170
        public void set_startSize(){} // RVA: 0x7AEF8C220
        public void get_startColor(){} // RVA: 0x7AEF8C2E0
        public void set_startColor(){} // RVA: 0x7AEF8C3C0
        public void get_startRotation(){} // RVA: 0x7AEF8C4D0
        public void set_startRotation(){} // RVA: 0x7AEF8C580
        public void get_startRotation3D(){} // RVA: 0x7AEF8C640
        public void set_startRotation3D(){} // RVA: 0x7AEF8C880
        public void get_startLifetime(){} // RVA: 0x7AEF8C9D0
        public void set_startLifetime(){} // RVA: 0x7AEF8CA80
        public void get_gravityModifier(){} // RVA: 0x7AEF8CB40
        public void set_gravityModifier(){} // RVA: 0x7AEF8CBF0
        public void get_maxParticles(){} // RVA: 0x7AEF8CCB0
        public void set_maxParticles(){} // RVA: 0x7AEF8CD70
        public void get_simulationSpace(){} // RVA: 0x7AEF8CE30
        public void set_simulationSpace(){} // RVA: 0x7AEF8CEF0
        public void get_scalingMode(){} // RVA: 0x7AEF8CFB0
        public void set_scalingMode(){} // RVA: 0x7AEF8D070
        public void get_automaticCullingEnabled(){} // RVA: 0x7AEF8D130
        public void get_isPlaying(){} // RVA: 0x7AEF8D180
        public void get_isEmitting(){} // RVA: 0x7AEF8D1D0
        public void get_isStopped(){} // RVA: 0x7AEF8D220
        public void get_isPaused(){} // RVA: 0x7AEF8D270
        public void get_particleCount(){} // RVA: 0x7AEF8D2C0
        public void get_time(){} // RVA: 0x7AEF8D310
        public void set_time(){} // RVA: 0x7AEF8D360
        public void get_totalTime(){} // RVA: 0x7AEF8D3C0
        public void get_randomSeed(){} // RVA: 0x7AEF8D410
        public void set_randomSeed(){} // RVA: 0x7AEF8D460
        public void get_useAutoRandomSeed(){} // RVA: 0x7AEF8D4C0
        public void set_useAutoRandomSeed(){} // RVA: 0x7AEF8D510
        public void get_proceduralSimulationSupported(){} // RVA: 0x7AEF8D130
        public void GetParticleCurrentSize(){} // RVA: 0x7AEF8D570
        public void GetParticleCurrentSize3D(){} // RVA: 0x7AEF8D5D0
        public void GetParticleCurrentColor(){} // RVA: 0x7AEF8D650
        public void GetParticleMeshIndex(){} // RVA: 0x7AEF8D6C0
        public void SetParticles(){} // RVA: 0x7AEF8D9D0
        public void SetParticlesWithNativeArray(){} // RVA: 0x7AEF8D7E0
        public void GetParticles(){} // RVA: 0x7AEF8DD20
        public void GetParticlesWithNativeArray(){} // RVA: 0x7AEF8DB30
        public void SetCustomParticleData(){} // RVA: 0x7AEF8DDC0
        public void GetCustomParticleData(){} // RVA: 0x7AEF8DE30
        public void GetPlaybackState(){} // RVA: 0x7AEF8DEA0
        public void SetPlaybackState(){} // RVA: 0x7AEF8DF10
        public void GetTrailDataInternal(){} // RVA: 0x7AEF8DF70
        public void GetTrails(){} // RVA: 0x7AEF8E080
        public void SetTrails(){} // RVA: 0x7AEF8E120
        public void Simulate(){} // RVA: 0x7AEF8E250
        public void Play(){} // RVA: 0x7AEF8E2E0
        public void Pause(){} // RVA: 0x7AEF8E3A0
        public void Stop(){} // RVA: 0x7AEF8E4E0
        public void Clear(){} // RVA: 0x7AEF8E5A0
        public void IsAlive(){} // RVA: 0x7AEF8E660
        public void Emit_Internal(){} // RVA: 0x7AEF8E6C0
        public void EmitOld_Internal(){} // RVA: 0x7AEF8E790
        public void TriggerSubEmitter(){} // RVA: 0x7AEF8E990
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7AEF8E920
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7AEF8EA00
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7AEF8EA50
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7AEF8EAB0
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7AEF8EB00
        public void AllocateCustomDataAttribute(){} // RVA: 0x7AEF8EB50
        public void get_has3DParticleRotations(){} // RVA: 0x7AEF8EBB0
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7AEF8EC00
        public void GetManagedJobData(){} // RVA: 0x7AEF8EC50
        public void GetManagedJobHandle(){} // RVA: 0x7AEF8ECA0
        public void SetManagedJobHandle(){} // RVA: 0x7AEF8ED10
        public void ScheduleManagedJob(){} // RVA: 0x7AEF8ED70
        public void CopyManagedJobData(){} // RVA: 0x7AEF8EDF0
        public void get_main(){} // RVA: 0x7A8DBD970
        public void get_emission(){} // RVA: 0x7A8DBD970
        public void get_shape(){} // RVA: 0x7A8DBD970
        public void get_velocityOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_limitVelocityOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_inheritVelocity(){} // RVA: 0x7A8DBD970
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x7A8DBD970
        public void get_forceOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_colorOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_colorBySpeed(){} // RVA: 0x7A8DBD970
        public void get_sizeOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_sizeBySpeed(){} // RVA: 0x7A8DBD970
        public void get_rotationOverLifetime(){} // RVA: 0x7A8DBD970
        public void get_rotationBySpeed(){} // RVA: 0x7A8DBD970
        public void get_externalForces(){} // RVA: 0x7A8DBD970
        public void get_noise(){} // RVA: 0x7A8DBD970
        public void get_collision(){} // RVA: 0x7A8DBD970
        public void get_trigger(){} // RVA: 0x7A8DBD970
        public void get_subEmitters(){} // RVA: 0x7A8DBD970
        public void get_textureSheetAnimation(){} // RVA: 0x7A8DBD970
        public void get_lights(){} // RVA: 0x7A8DBD970
        public void get_trails(){} // RVA: 0x7A8DBD970
        public void get_customData(){} // RVA: 0x7A8DBD970
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7AEF8EE50
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7AEF8EEC0
        public void GetPlaybackState_Injected(){} // RVA: 0x7AEF8EF30
        public void SetPlaybackState_Injected(){} // RVA: 0x7AEF8EF90
        public void SetTrails_Injected(){} // RVA: 0x7AEF8EFF0
        public void Emit_Injected(){} // RVA: 0x7AEF8F050
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7AEF8F0C0
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7AEF8F130
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7AEF8F190
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7AEF8F1F0
    }

    public class ParticleSystemExtensionsImpl : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7AEFA4CF0
    }

    public class ParticleSystemForceField : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class ParticleSystemRenderer : Renderer
    {
        // ── Methods ──
        public void EnableVertexStreams(){} // RVA: 0x7AEFA4D60
        public void DisableVertexStreams(){} // RVA: 0x7AEFA4D70
        public void AreVertexStreamsEnabled(){} // RVA: 0x7AEFA4D80
        public void GetEnabledVertexStreams(){} // RVA: 0x7AEFA4DA0
        public void Internal_SetVertexStreams(){} // RVA: 0x7AEFA4DB0
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7AEFA5490
        public void BakeMesh(){} // RVA: 0x7AEFA6DD0
        public void BakeTrailsMesh(){} // RVA: 0x7AEFA6ED0
        public void get_alignment(){} // RVA: 0x7AEFA5C10
        public void set_alignment(){} // RVA: 0x7AEFA5C60
        public void get_renderMode(){} // RVA: 0x7AEFA5CC0
        public void set_renderMode(){} // RVA: 0x7AEFA5D10
        public void get_meshDistribution(){} // RVA: 0x7AEFA5D70
        public void set_meshDistribution(){} // RVA: 0x7AEFA5DC0
        public void get_sortMode(){} // RVA: 0x7AEFA5E20
        public void set_sortMode(){} // RVA: 0x7AEFA5E70
        public void get_lengthScale(){} // RVA: 0x7AEFA5ED0
        public void set_lengthScale(){} // RVA: 0x7AEFA5F20
        public void get_velocityScale(){} // RVA: 0x7AEFA5F80
        public void set_velocityScale(){} // RVA: 0x7AEFA5FD0
        public void get_cameraVelocityScale(){} // RVA: 0x7AEFA6030
        public void set_cameraVelocityScale(){} // RVA: 0x7AEFA6080
        public void get_normalDirection(){} // RVA: 0x7AEFA60E0
        public void set_normalDirection(){} // RVA: 0x7AEFA6130
        public void get_shadowBias(){} // RVA: 0x7AEFA6190
        public void set_shadowBias(){} // RVA: 0x7AEFA61E0
        public void get_sortingFudge(){} // RVA: 0x7AEFA6240
        public void set_sortingFudge(){} // RVA: 0x7AEFA6290
        public void get_minParticleSize(){} // RVA: 0x7AEFA62F0
        public void set_minParticleSize(){} // RVA: 0x7AEFA6340
        public void get_maxParticleSize(){} // RVA: 0x7AEFA63A0
        public void set_maxParticleSize(){} // RVA: 0x7AEFA63F0
        public void get_pivot(){} // RVA: 0x7AEFA6450
        public void set_pivot(){} // RVA: 0x7AEFA64C0
        public void get_flip(){} // RVA: 0x7AEFA6520
        public void set_flip(){} // RVA: 0x7AEFA6590
        public void get_maskInteraction(){} // RVA: 0x7AEFA65F0
        public void set_maskInteraction(){} // RVA: 0x7AEFA6640
        public void get_trailMaterial(){} // RVA: 0x7AEFA66A0
        public void set_trailMaterial(){} // RVA: 0x7AEFA66F0
        public void set_oldTrailMaterial(){} // RVA: 0x7AEFA6750
        public void get_enableGPUInstancing(){} // RVA: 0x7AEFA67B0
        public void set_enableGPUInstancing(){} // RVA: 0x7AEFA6800
        public void get_allowRoll(){} // RVA: 0x7AEFA6860
        public void set_allowRoll(){} // RVA: 0x7AEFA68B0
        public void get_freeformStretching(){} // RVA: 0x7AEFA6910
        public void set_freeformStretching(){} // RVA: 0x7AEFA6960
        public void get_rotateWithStretchDirection(){} // RVA: 0x7AEFA69C0
        public void set_rotateWithStretchDirection(){} // RVA: 0x7AEFA6A10
        public void get_mesh(){} // RVA: 0x7AEFA6A70
        public void set_mesh(){} // RVA: 0x7AEFA6AC0
        public void GetMeshes(){} // RVA: 0x7AEFA6B20
        public void SetMeshes(){} // RVA: 0x7AEFA6BF0
        public void GetMeshWeightings(){} // RVA: 0x7AEFA6C10
        public void SetMeshWeightings(){} // RVA: 0x7AEFA6CE0
        public void get_meshCount(){} // RVA: 0x7AEFA6D00
        public void BakeTexture(){} // RVA: 0x7AEFA74F0
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7AEFA72A0
        public void BakeTextureInternal(){} // RVA: 0x7AEFA7660
        public void BakeTrailsTexture(){} // RVA: 0x7AEFA78D0
        public void BakeTrailsTextureInternal(){} // RVA: 0x7AEFA7A40
        public void get_activeVertexStreamsCount(){} // RVA: 0x7AEFA7AF0
        public void SetActiveVertexStreams(){} // RVA: 0x7AEFA7B40
        public void GetActiveVertexStreams(){} // RVA: 0x7AEFA7BA0
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7AEFA7C00
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7AEFA7C50
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7AEFA7CB0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_pivot_Injected(){} // RVA: 0x7AEFA7D10
        public void set_pivot_Injected(){} // RVA: 0x7AEFA7D70
        public void get_flip_Injected(){} // RVA: 0x7AEFA7DD0
        public void set_flip_Injected(){} // RVA: 0x7AEFA7E30
        public void BakeTextureInternal_Injected(){} // RVA: 0x7AEFA7E90
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7AEFA7F20
    }

    public class ParticleSystemRenderer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ParticleSystemVertexStream[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ParticleSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PhysicMaterial : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFDB500
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7AEFDB5A0
        public void get_bounciness(){} // RVA: 0x7AEFDB600
        public void set_bounciness(){} // RVA: 0x7AEFDB650
        public void get_dynamicFriction(){} // RVA: 0x7AEFDB6B0
        public void set_dynamicFriction(){} // RVA: 0x7AEFDB700
        public void get_staticFriction(){} // RVA: 0x7AEFDB760
        public void set_staticFriction(){} // RVA: 0x7AEFDB7B0
        public void get_frictionCombine(){} // RVA: 0x7AEFDB810
        public void set_frictionCombine(){} // RVA: 0x7AEFDB860
        public void get_bounceCombine(){} // RVA: 0x7AEFDB8C0
        public void set_bounceCombine(){} // RVA: 0x7AEFDB910
    }

    public class PhysicMaterialCombine[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PhysicMaterial[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Physics : Object
    {
        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7AEFD0030
        public void get_gravity(){} // RVA: 0x7AEFD0120
        public void set_gravity(){} // RVA: 0x7AEFD01B0
        public void get_bounceThreshold(){} // RVA: 0x7AEFD0240
        public void set_bounceThreshold(){} // RVA: 0x7AEFD0290
        public void get_simulationMode(){} // RVA: 0x7AEFD02F0
        public void set_simulationMode(){} // RVA: 0x7AEFD0340
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7AEFD0390
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7AEFD03E0
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7AEFD0440
        public void get_defaultPhysicsScene(){} // RVA: 0x7AEFD0490
        public void IgnoreCollision(){} // RVA: 0x7AEFD0590
        public void IgnoreLayerCollision(){} // RVA: 0x7AEFD06A0
        public void GetIgnoreLayerCollision(){} // RVA: 0x7AEFD0740
        public void GetIgnoreCollision(){} // RVA: 0x7AEFD07A0
        public void Raycast(){} // RVA: 0x7AEFD1420
        public void Linecast(){} // RVA: 0x7AEFD1920
        public void CapsuleCast(){} // RVA: 0x7AEFD21E0
        public void SphereCast(){} // RVA: 0x7AEFD2CC0
        public void BoxCast(){} // RVA: 0x7AEFD37E0
        public void Internal_RaycastAll(){} // RVA: 0x7AEFD3910
        public void RaycastAll(){} // RVA: 0x7AEFD4040
        public void RaycastNonAlloc(){} // RVA: 0x7AEFD46A0
        public void Query_CapsuleCastAll(){} // RVA: 0x7AEFD4770
        public void CapsuleCastAll(){} // RVA: 0x7AEFD4C30
        public void Query_SphereCastAll(){} // RVA: 0x7AEFD4D10
        public void SphereCastAll(){} // RVA: 0x7AEFD5490
        public void OverlapCapsule_Internal(){} // RVA: 0x7AEFD55A0
        public void OverlapCapsule(){} // RVA: 0x7AEFD5860
        public void OverlapSphere_Internal(){} // RVA: 0x7AEFD5910
        public void OverlapSphere(){} // RVA: 0x7AEFD5B70
        public void Simulate_Internal(){} // RVA: 0x7AEFD5C00
        public void Simulate(){} // RVA: 0x7AEFD5CA0
        public void InterpolateBodies_Internal(){} // RVA: 0x7AEFD5DB0
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7AEFD5E40
        public void SyncTransforms(){} // RVA: 0x7AEFD5ED0
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7AEFD5F20
        public void Query_ComputePenetration(){} // RVA: 0x7AEFD5F70
        public void ComputePenetration(){} // RVA: 0x7AEFD6060
        public void Query_ClosestPoint(){} // RVA: 0x7AEFD6220
        public void ClosestPoint(){} // RVA: 0x7AEFD62F0
        public void OverlapSphereNonAlloc(){} // RVA: 0x7AEFD65E0
        public void CheckSphere_Internal(){} // RVA: 0x7AEFD6670
        public void CheckSphere(){} // RVA: 0x7AEFD68D0
        public void CapsuleCastNonAlloc(){} // RVA: 0x7AEFD6CD0
        public void SphereCastNonAlloc(){} // RVA: 0x7AEFD73D0
        public void CheckCapsule_Internal(){} // RVA: 0x7AEFD7470
        public void CheckCapsule(){} // RVA: 0x7AEFD7730
        public void CheckBox_Internal(){} // RVA: 0x7AEFD77E0
        public void CheckBox(){} // RVA: 0x7AEFD7C30
        public void OverlapBox_Internal(){} // RVA: 0x7AEFD7DD0
        public void OverlapBox(){} // RVA: 0x7AEFD8220
        public void OverlapBoxNonAlloc(){} // RVA: 0x7AEFD8780
        public void BoxCastNonAlloc(){} // RVA: 0x7AEFD8FD0
        public void Internal_BoxCastAll(){} // RVA: 0x7AEFD91C0
        public void BoxCastAll(){} // RVA: 0x7AEFD9780
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7AEFD9A70
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x7AEFD9B30
        public void RebuildBroadphaseRegions(){} // RVA: 0x7AEFD9BD0
        public void BakeMesh(){} // RVA: 0x7AEFD9E10
        public void GetColliderByInstanceID(){} // RVA: 0x7AEFD9EB0
        public void GetBodyByInstanceID(){} // RVA: 0x7AEFD9F00
        public void SendOnCollisionEnter(){} // RVA: 0x7AEFD9F50
        public void SendOnCollisionStay(){} // RVA: 0x7AEFD9FB0
        public void SendOnCollisionExit(){} // RVA: 0x7AEFDA010
        public void OnSceneContact(){} // RVA: 0x7AEFDA070
        public void ReportContacts(){} // RVA: 0x7AEFDA2A0
        public void GetCollisionToReport(){} // RVA: 0x7AEFDA760
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEFDAA70
        public void get_gravity_Injected(){} // RVA: 0x7AEFDAB40
        public void set_gravity_Injected(){} // RVA: 0x7AEFDAB90
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x7AEFDABE0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7AEFDAC30
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7AEFDACC0
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7AEFDAD50
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7AEFDADE0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7AEFDAE70
        public void Simulate_Internal_Injected(){} // RVA: 0x7AEFDAF00
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7AEFDAF60
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7AEFDAFB0
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7AEFDB000
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7AEFDB090
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7AEFDB120
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7AEFDB1B0
        public void CheckBox_Internal_Injected(){} // RVA: 0x7AEFDB240
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7AEFDB2D0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7AEFDB360
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x7AEFDB3F0
    }

    public class Physics2D : Object
    {
        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x7ABC0A600
        public void get_velocityIterations(){} // RVA: 0x7AEFADDF0
        public void set_velocityIterations(){} // RVA: 0x7AEFADE40
        public void get_positionIterations(){} // RVA: 0x7AEFADE90
        public void set_positionIterations(){} // RVA: 0x7AEFADEE0
        public void get_gravity(){} // RVA: 0x7AEFADF30
        public void set_gravity(){} // RVA: 0x7AEFADFC0
        public void get_queriesHitTriggers(){} // RVA: 0x7AEFAE050
        public void get_queriesStartInColliders(){} // RVA: 0x7AEFAE0A0
        public void set_queriesStartInColliders(){} // RVA: 0x7AEFAE0F0
        public void get_callbacksOnDisable(){} // RVA: 0x7AEFAE140
        public void set_callbacksOnDisable(){} // RVA: 0x7AEFAE190
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7AEFAE1E0
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7AEFAE230
        public void get_velocityThreshold(){} // RVA: 0x7AEFAE280
        public void set_velocityThreshold(){} // RVA: 0x7AEFAE2D0
        public void get_maxLinearCorrection(){} // RVA: 0x7AEFAE330
        public void set_maxLinearCorrection(){} // RVA: 0x7AEFAE380
        public void get_maxAngularCorrection(){} // RVA: 0x7AEFAE3E0
        public void set_maxAngularCorrection(){} // RVA: 0x7AEFAE430
        public void get_maxTranslationSpeed(){} // RVA: 0x7AEFAE490
        public void set_maxTranslationSpeed(){} // RVA: 0x7AEFAE4E0
        public void get_maxRotationSpeed(){} // RVA: 0x7AEFAE540
        public void set_maxRotationSpeed(){} // RVA: 0x7AEFAE590
        public void get_baumgarteScale(){} // RVA: 0x7AEFAE5F0
        public void set_baumgarteScale(){} // RVA: 0x7AEFAE640
        public void get_baumgarteTOIScale(){} // RVA: 0x7AEFAE6A0
        public void set_baumgarteTOIScale(){} // RVA: 0x7AEFAE6F0
        public void get_timeToSleep(){} // RVA: 0x7AEFAE750
        public void set_timeToSleep(){} // RVA: 0x7AEFAE7A0
        public void get_linearSleepTolerance(){} // RVA: 0x7AEFAE800
        public void set_linearSleepTolerance(){} // RVA: 0x7AEFAE850
        public void get_angularSleepTolerance(){} // RVA: 0x7AEFAE8B0
        public void set_angularSleepTolerance(){} // RVA: 0x7AEFAE900
        public void Simulate(){} // RVA: 0x7AEFAE960
        public void Simulate_Internal(){} // RVA: 0x7AEFAE9C0
        public void SyncTransforms(){} // RVA: 0x7AEFAEA60
        public void IgnoreCollision(){} // RVA: 0x7AEFAEB50
        public void GetIgnoreCollision(){} // RVA: 0x7AEFAEBC0
        public void GetIgnoreLayerCollision(){} // RVA: 0x7AEFAEC20
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7AEFAED60
        public void SetLayerCollisionMask(){} // RVA: 0x7AEFAEDC0
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7AEFAEEB0
        public void GetLayerCollisionMask(){} // RVA: 0x7AEFAEF10
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7AEFAEFF0
        public void IsTouching(){} // RVA: 0x7AEFAF250
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7AEFAF1A0
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7AEFAF340
        public void IsTouchingLayers(){} // RVA: 0x7AEFAF470
        public void Distance(){} // RVA: 0x7AEFAF4D0
        public void Distance_Internal(){} // RVA: 0x7AEFAF870
        public void ClosestPoint(){} // RVA: 0x7AEFAFB10
        public void ClosestPoint_Collider(){} // RVA: 0x7AEFAFCF0
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7AEFAFD90
        public void Linecast(){} // RVA: 0x7AEFB04E0
        public void LinecastAll(){} // RVA: 0x7AEFB0A40
        public void LinecastAll_Internal(){} // RVA: 0x7AEFB0BB0
        public void LinecastNonAlloc(){} // RVA: 0x7AEFB0F90
        public void Raycast(){} // RVA: 0x7AEFB1A20
        public void RaycastNonAlloc(){} // RVA: 0x7AEFB1F50
        public void RaycastAll(){} // RVA: 0x7AEFB24B0
        public void RaycastAll_Internal(){} // RVA: 0x7AEFB25B0
        public void CircleCast(){} // RVA: 0x7AEFB3040
        public void CircleCastAll(){} // RVA: 0x7AEFB35C0
        public void CircleCastAll_Internal(){} // RVA: 0x7AEFB36D0
        public void CircleCastNonAlloc(){} // RVA: 0x7AEFB3C00
        public void BoxCast(){} // RVA: 0x7AEFB4800
        public void BoxCastAll(){} // RVA: 0x7AEFB4DF0
        public void BoxCastAll_Internal(){} // RVA: 0x7AEFB4F10
        public void BoxCastNonAlloc(){} // RVA: 0x7AEFB54D0
        public void CapsuleCast(){} // RVA: 0x7AEFB6120
        public void CapsuleCastAll(){} // RVA: 0x7AEFB6820
        public void CapsuleCastAll_Internal(){} // RVA: 0x7AEFB64E0
        public void CapsuleCastNonAlloc(){} // RVA: 0x7AEFB6E50
        public void GetRayIntersection(){} // RVA: 0x7AEFB72B0
        public void GetRayIntersectionAll(){} // RVA: 0x7AEFB7630
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7AEFB7750
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7AEFB7A20
        public void OverlapPoint(){} // RVA: 0x7AEFB7FC0
        public void OverlapPointAll(){} // RVA: 0x7AEFB84B0
        public void OverlapPointAll_Internal(){} // RVA: 0x7AEFB8600
        public void OverlapPointNonAlloc(){} // RVA: 0x7AEFB8980
        public void OverlapCircle(){} // RVA: 0x7AEFB8FC0
        public void OverlapCircleAll(){} // RVA: 0x7AEFB94F0
        public void OverlapCircleAll_Internal(){} // RVA: 0x7AEFB9650
        public void OverlapCircleNonAlloc(){} // RVA: 0x7AEFB9A10
        public void OverlapBox(){} // RVA: 0x7AEFBA110
        public void OverlapBoxAll(){} // RVA: 0x7AEFBA540
        public void OverlapBoxAll_Internal(){} // RVA: 0x7AEFBA640
        public void OverlapBoxNonAlloc(){} // RVA: 0x7AEFBAA70
        public void OverlapArea(){} // RVA: 0x7AEFBB070
        public void OverlapAreaAll(){} // RVA: 0x7AEFBB310
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7AEFBB3B0
        public void OverlapAreaNonAlloc(){} // RVA: 0x7AEFBB810
        public void OverlapCapsule(){} // RVA: 0x7AEFBBF30
        public void OverlapCapsuleAll(){} // RVA: 0x7AEFBC520
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7AEFBC6C0
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7AEFBCB20
        public void OverlapCollider(){} // RVA: 0x7AEFACB80
        public void GetContacts(){} // RVA: 0x7AEFBE330
        public void GetColliderContactsArray(){} // RVA: 0x7AEFBD6A0
        public void GetColliderColliderContactsArray(){} // RVA: 0x7AEFBD750
        public void GetRigidbodyContactsArray(){} // RVA: 0x7AEFBD810
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7AEFBD8C0
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7AEFBD970
        public void GetColliderContactsList(){} // RVA: 0x7AEFBE430
        public void GetColliderColliderContactsList(){} // RVA: 0x7AEFBE4E0
        public void GetRigidbodyContactsList(){} // RVA: 0x7AEFBE5A0
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7AEFBE650
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7AEFBE700
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEFBE7B0
        public void get_gravity_Injected(){} // RVA: 0x7AEFBE890
        public void set_gravity_Injected(){} // RVA: 0x7AEFBE8E0
        public void Simulate_Internal_Injected(){} // RVA: 0x7AEFBE930
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7AEFBE990
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7AEFBEA00
        public void Distance_Internal_Injected(){} // RVA: 0x7AEFBEA60
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7AEFBEAD0
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7AEFBEB40
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7AEFBEBB0
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7AEFBEC30
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7AEFBECC0
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7AEFBED50
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7AEFBEDE0
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7AEFBEE70
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7AEFBEF00
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7AEFBEF70
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7AEFBEFF0
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7AEFBF080
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7AEFBF110
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7AEFBF180
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7AEFBF200
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7AEFBF270
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7AEFBF2E0
        public void GetColliderContactsList_Injected(){} // RVA: 0x7AEFBF350
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7AEFBF3C0
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7AEFBF440
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7AEFBF4B0
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7AEFBF520
    }

    public class Physics2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PhysicsMaterial2D : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFCEEE0
        public void Create_Internal(){} // RVA: 0x7AEFCEF70
        public void get_bounciness(){} // RVA: 0x7AEFCEFD0
        public void set_bounciness(){} // RVA: 0x7AEFCF020
        public void get_friction(){} // RVA: 0x7AEFCF080
        public void set_friction(){} // RVA: 0x7AEFCF0D0
    }

    public class PhysicsScene : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7EF5190
        public void op_Equality(){} // RVA: 0x7AEEFE800
        public void op_Inequality(){} // RVA: 0x7AEF28690
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void IsValid(){} // RVA: 0x7A7EF5230
        public void IsValid_Internal(){} // RVA: 0x7AEFE7A00
        public void IsEmpty(){} // RVA: 0x7A7EF5290
        public void IsEmpty_Internal(){} // RVA: 0x7AEFE7B40
        public void Simulate(){} // RVA: 0x7A7EF52A0
        public void InterpolateBodies(){} // RVA: 0x7A7EF52B0
        public void ResetInterpolationPoses(){} // RVA: 0x7A7EF52C0
        public void Raycast(){} // RVA: 0x7A7EF53C0
        public void Internal_RaycastTest(){} // RVA: 0x7AEFE8340
        public void Internal_Raycast(){} // RVA: 0x7AEFE85E0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7AEFE8840
        public void Query_CapsuleCast(){} // RVA: 0x7AEFE88D0
        public void Internal_CapsuleCast(){} // RVA: 0x7AEFE8990
        public void CapsuleCast(){} // RVA: 0x7A7EF54F0
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7AEFE8C90
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7AEFE8E90
        public void OverlapCapsule(){} // RVA: 0x7A7EF5640
        public void Query_SphereCast(){} // RVA: 0x7AEFE8FF0
        public void Internal_SphereCast(){} // RVA: 0x7AEFE90A0
        public void SphereCast(){} // RVA: 0x7A7EF5780
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7AEFE9340
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7AEFE9500
        public void OverlapSphere(){} // RVA: 0x7A7EF58A0
        public void Query_BoxCast(){} // RVA: 0x7AEFE9630
        public void Internal_BoxCast(){} // RVA: 0x7AEFE96F0
        public void BoxCast(){} // RVA: 0x7A7EF5CF0
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7AEFE9BC0
        public void OverlapBox(){} // RVA: 0x7A7EF5B50
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7AEFE9E40
        public void IsValid_Internal_Injected(){} // RVA: 0x7AEFEA1C0
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7AEFEA210
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7AEFEA260
        public void Internal_Raycast_Injected(){} // RVA: 0x7AEFEA2F0
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7AEFEA380
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7AEFEA410
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7AEFEA4A0
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7AEFEA530
        public void Query_SphereCast_Injected(){} // RVA: 0x7AEFEA5C0
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7AEFEA650
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7AEFEA6E0
        public void Query_BoxCast_Injected(){} // RVA: 0x7AEFEA770
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7AEFEA800
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7AEFEA890
    }

    public class PhysicsScene2D : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7EF3150
        public void op_Equality(){} // RVA: 0x7AEEFE800
        public void op_Inequality(){} // RVA: 0x7AEF28690
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void IsValid(){} // RVA: 0x7A7EF31F0
        public void IsValid_Internal(){} // RVA: 0x7AEFA8220
        public void IsEmpty(){} // RVA: 0x7A7EF3250
        public void IsEmpty_Internal(){} // RVA: 0x7AEFA8360
        public void Simulate(){} // RVA: 0x7A7EF3260
        public void Linecast(){} // RVA: 0x7A7EF3450
        public void Linecast_Internal(){} // RVA: 0x7AEFA86F0
        public void LinecastArray_Internal(){} // RVA: 0x7AEFA8930
        public void LinecastNonAllocList_Internal(){} // RVA: 0x7AEFA8A50
        public void Raycast(){} // RVA: 0x7A7EF3650
        public void Raycast_Internal(){} // RVA: 0x7AEFA8D30
        public void RaycastArray_Internal(){} // RVA: 0x7AEFA8FB0
        public void RaycastList_Internal(){} // RVA: 0x7AEFA9110
        public void CircleCast(){} // RVA: 0x7A7EF3840
        public void CircleCast_Internal(){} // RVA: 0x7AEFA9450
        public void CircleCastArray_Internal(){} // RVA: 0x7AEFA96F0
        public void CircleCastList_Internal(){} // RVA: 0x7AEFA9860
        public void BoxCast(){} // RVA: 0x7A7EF3A70
        public void BoxCast_Internal(){} // RVA: 0x7AEFA9BD0
        public void BoxCastArray_Internal(){} // RVA: 0x7AEFA9EC0
        public void BoxCastList_Internal(){} // RVA: 0x7AEFAA060
        public void CapsuleCast(){} // RVA: 0x7A7EF3CE0
        public void CapsuleCast_Internal(){} // RVA: 0x7AEFAA400
        public void CapsuleCastArray_Internal(){} // RVA: 0x7AEFAA710
        public void CapsuleCastList_Internal(){} // RVA: 0x7AEFAA8C0
        public void GetRayIntersection(){} // RVA: 0x7A7EF3DE0
        public void GetRayIntersection_Internal(){} // RVA: 0x7AEFAAA80
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x7AEFAABD0
        public void OverlapPoint(){} // RVA: 0x7A7EF3F60
        public void OverlapPoint_Internal(){} // RVA: 0x7AEFAADB0
        public void OverlapPointArray_Internal(){} // RVA: 0x7AEFAAF90
        public void OverlapPointList_Internal(){} // RVA: 0x7AEFAB0A0
        public void OverlapCircle(){} // RVA: 0x7A7EF4150
        public void OverlapCircle_Internal(){} // RVA: 0x7AEFAB290
        public void OverlapCircleArray_Internal(){} // RVA: 0x7AEFAB4C0
        public void OverlapCircleList_Internal(){} // RVA: 0x7AEFAB600
        public void OverlapBox(){} // RVA: 0x7A7EF4330
        public void OverlapBox_Internal(){} // RVA: 0x7AEFAB840
        public void OverlapBoxArray_Internal(){} // RVA: 0x7AEFABAB0
        public void OverlapBoxList_Internal(){} // RVA: 0x7AEFABC10
        public void OverlapArea(){} // RVA: 0x7A7EF44E0
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x7A7EF4490
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x7A7EF4530
        public void OverlapCapsule(){} // RVA: 0x7A7EF46C0
        public void OverlapCapsule_Internal(){} // RVA: 0x7AEFAC570
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x7AEFAC7E0
        public void OverlapCapsuleList_Internal(){} // RVA: 0x7AEFAC940
        public void OverlapCollider(){} // RVA: 0x7AEFACB80
        public void OverlapColliderArray_Internal(){} // RVA: 0x7AEFACB10
        public void OverlapColliderList_Internal(){} // RVA: 0x7AEFACC00
        public void IsValid_Internal_Injected(){} // RVA: 0x7AEFACC70
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7AEFACCC0
        public void Linecast_Internal_Injected(){} // RVA: 0x7AEFACD10
        public void LinecastArray_Internal_Injected(){} // RVA: 0x7AEFACDA0
        public void LinecastNonAllocList_Internal_Injected(){} // RVA: 0x7AEFACE30
        public void Raycast_Internal_Injected(){} // RVA: 0x7AEFACEC0
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7AEFACF50
        public void RaycastList_Internal_Injected(){} // RVA: 0x7AEFACFE0
        public void CircleCast_Internal_Injected(){} // RVA: 0x7AEFAD070
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x7AEFAD100
        public void CircleCastList_Internal_Injected(){} // RVA: 0x7AEFAD190
        public void BoxCast_Internal_Injected(){} // RVA: 0x7AEFAD220
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x7AEFAD2B0
        public void BoxCastList_Internal_Injected(){} // RVA: 0x7AEFAD340
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x7AEFAD3D0
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x7AEFAD460
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x7AEFAD4F0
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x7AEFAD580
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x7AEFAD610
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x7AEFAD6A0
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x7AEFAD710
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x7AEFAD790
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x7AEFAD810
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x7AEFAD890
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x7AEFAD920
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7AEFAD9B0
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x7AEFADA40
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x7AEFADAD0
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7AEFADB60
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x7AEFADBF0
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x7AEFADC80
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7AEFADD10
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7AEFADD80
    }

    public class PhysicsShape2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1D50
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E31C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250C50
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PhysicsUpdateBehaviour2D : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class Physics[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Plane : ValueType
    {
        // ── Methods ──
        public void get_normal(){} // RVA: 0x7A79F03C0
        public void set_normal(){} // RVA: 0x7A79F03B0
        public void get_distance(){} // RVA: 0x7A7ED43A0
        public void set_distance(){} // RVA: 0x7A76B8970
        public void .ctor(){} // RVA: 0x7A7EDB410
        public void SetNormalAndPosition(){} // RVA: 0x7A7EDB470
        public void Set3Points(){} // RVA: 0x7A7EDB410
        public void Flip(){} // RVA: 0x7A7EDB4B0
        public void get_flipped(){} // RVA: 0x7A7EDB500
        public void Translate(){} // RVA: 0x7AEEAC3D0
        public void ClosestPointOnPlane(){} // RVA: 0x7A7EDB580
        public void GetDistanceToPoint(){} // RVA: 0x7A7EDB620
        public void GetSide(){} // RVA: 0x7A7EDB670
        public void SameSide(){} // RVA: 0x7A7EDB6C0
        public void Raycast(){} // RVA: 0x7A7EDB760
        public void ToString(){} // RVA: 0x7A7EDB7B0
    }

    public class Plane[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2602D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlatformEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_useOneWay(){} // RVA: 0x7AEFCE240
        public void set_useOneWay(){} // RVA: 0x7AEFCE290
        public void get_useOneWayGrouping(){} // RVA: 0x7AEFCE2F0
        public void set_useOneWayGrouping(){} // RVA: 0x7AEFCE340
        public void get_useSideFriction(){} // RVA: 0x7AEFCE3A0
        public void set_useSideFriction(){} // RVA: 0x7AEFCE3F0
        public void get_useSideBounce(){} // RVA: 0x7AEFCE450
        public void set_useSideBounce(){} // RVA: 0x7AEFCE4A0
        public void get_surfaceArc(){} // RVA: 0x7AEFCE500
        public void set_surfaceArc(){} // RVA: 0x7AEFCE550
        public void get_sideArc(){} // RVA: 0x7AEFCE5B0
        public void set_sideArc(){} // RVA: 0x7AEFCE600
        public void get_rotationalOffset(){} // RVA: 0x7AEFCE660
        public void set_rotationalOffset(){} // RVA: 0x7AEFCE6B0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class PlayerConnectionInternal : Object
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x7AEEFD900
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x7AEEFDA60
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x7AEEFDBC0
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x7AEEFDC10
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x7AEEFDCA0
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x7AEEFDD30
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x7AEEFDD80
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x7AEEFDDD0
        public void IsConnected(){} // RVA: 0x7AEEFDD80
        public void Initialize(){} // RVA: 0x7AEEFDD30
        public void RegisterInternal(){} // RVA: 0x7AEEFDE20
        public void UnregisterInternal(){} // RVA: 0x7AEEFDE70
        public void SendMessage(){} // RVA: 0x7AEEFDEC0
        public void TrySendMessage(){} // RVA: 0x7AEEFDF30
        public void PollInternal(){} // RVA: 0x7AEEFDBC0
        public void DisconnectAll(){} // RVA: 0x7AEEFDDD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PlayerPrefs : Object
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x7AEEFE000
        public void TrySetFloat(){} // RVA: 0x7AEEFE060
        public void TrySetSetString(){} // RVA: 0x7AEEFE0C0
        public void SetInt(){} // RVA: 0x7AEEFE120
        public void GetInt(){} // RVA: 0x7AEEFE230
        public void SetFloat(){} // RVA: 0x7AEEFE290
        public void GetFloat(){} // RVA: 0x7AEEFE3A0
        public void SetString(){} // RVA: 0x7AEEFE400
        public void GetString(){} // RVA: 0x7AEEFE510
        public void HasKey(){} // RVA: 0x7A92172C0
        public void DeleteKey(){} // RVA: 0x7AEEFE5A0
        public void DeleteAll(){} // RVA: 0x7AEEFE5F0
        public void Save(){} // RVA: 0x7A9217210
    }

    public class PlayerPrefsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEEFDFA0
    }

    public class PointEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_forceMagnitude(){} // RVA: 0x7AEFCDCC0
        public void set_forceMagnitude(){} // RVA: 0x7AEFCDD10
        public void get_forceVariation(){} // RVA: 0x7AEFCDD70
        public void set_forceVariation(){} // RVA: 0x7AEFCDDC0
        public void get_distanceScale(){} // RVA: 0x7AEFCDE20
        public void set_distanceScale(){} // RVA: 0x7AEFCDE70
        public void get_drag(){} // RVA: 0x7AEFCDED0
        public void set_drag(){} // RVA: 0x7AEFCDF20
        public void get_angularDrag(){} // RVA: 0x7AEFCDF80
        public void set_angularDrag(){} // RVA: 0x7AEFCDFD0
        public void get_forceSource(){} // RVA: 0x7AEFCE030
        public void set_forceSource(){} // RVA: 0x7AEFCE080
        public void get_forceTarget(){} // RVA: 0x7AEFCE0E0
        public void set_forceTarget(){} // RVA: 0x7AEFCE130
        public void get_forceMode(){} // RVA: 0x7AEFCE190
        public void set_forceMode(){} // RVA: 0x7AEFCE1E0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class PolygonCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7AEFC9400
        public void set_useDelaunayMesh(){} // RVA: 0x7AEFC9450
        public void get_autoTiling(){} // RVA: 0x7AEFC94B0
        public void set_autoTiling(){} // RVA: 0x7AEFC9500
        public void GetTotalPointCount(){} // RVA: 0x7AEFC9560
        public void get_points(){} // RVA: 0x7AEFC95B0
        public void set_points(){} // RVA: 0x7AEFC9600
        public void get_pathCount(){} // RVA: 0x7AEFC9660
        public void set_pathCount(){} // RVA: 0x7AEFC96B0
        public void GetPath(){} // RVA: 0x7AEFC9A80
        public void GetPath_Internal(){} // RVA: 0x7AEFC98C0
        public void SetPath(){} // RVA: 0x7AEFC9CC0
        public void SetPath_Internal(){} // RVA: 0x7AEFC9A10
        public void GetPathList_Internal(){} // RVA: 0x7AEFC9C50
        public void SetPathList_Internal(){} // RVA: 0x7AEFC9DB0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class Pose : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7C6BE10
        public void ToString(){} // RVA: 0x7A7EDF9C0
        public void GetTransformedBy(){} // RVA: 0x7A7EDF9D0
        public void get_identity(){} // RVA: 0x7AEF149B0
        public void Equals(){} // RVA: 0x7A7EDFA40
        public void GetHashCode(){} // RVA: 0x7A7EDFA80
        public void .cctor(){} // RVA: 0x7AEF14C80
    }

    public class PreferBinarySerialization[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PreloadData : Object
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x7A80D7310
    }

    public class PreloadData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PrimitiveType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Projector : Behaviour
    {
        // ── Methods ──
        public void get_nearClipPlane(){} // RVA: 0x7AEECF920
        public void set_nearClipPlane(){} // RVA: 0x7AEECF970
        public void get_farClipPlane(){} // RVA: 0x7AEECF9D0
        public void set_farClipPlane(){} // RVA: 0x7AEECFA20
        public void get_fieldOfView(){} // RVA: 0x7AEECFA80
        public void set_fieldOfView(){} // RVA: 0x7AEECFAD0
        public void get_aspectRatio(){} // RVA: 0x7AEECFB30
        public void set_aspectRatio(){} // RVA: 0x7AEECFB80
        public void get_orthographic(){} // RVA: 0x7AEECFBE0
        public void set_orthographic(){} // RVA: 0x7AEECFC30
        public void get_orthographicSize(){} // RVA: 0x7AEECFC90
        public void set_orthographicSize(){} // RVA: 0x7AEECFCE0
        public void get_ignoreLayers(){} // RVA: 0x7AEECFD40
        public void set_ignoreLayers(){} // RVA: 0x7AEECFD90
        public void get_material(){} // RVA: 0x7AEECFDF0
        public void set_material(){} // RVA: 0x7AEECFE40
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class PropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PropertyAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PropertyName : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
        public void IsNullOrEmpty(){} // RVA: 0x7AEEFE7F0
        public void op_Equality(){} // RVA: 0x7AEEFE800
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void op_Implicit(){} // RVA: 0x7AEEFE6C0
        public void ToString(){} // RVA: 0x7A7EDF080
    }

    public class PropertyNameUtils : Object
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x7AEEFE6C0
        public void PropertyNameFromString_Injected(){} // RVA: 0x7AEEFE720
    }

    public class PropertyName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}