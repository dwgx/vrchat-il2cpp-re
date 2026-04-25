// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 30
// Methods: 1086

namespace ThirdParty.Unity.UnityEngine
{
    public class ParticleCollisionEvent : ValueType
    {
        public UnityEngine.Vector3 velocity; // 0x10
        public UnityEngine.Vector3 colliderComponent; // 0x1C
        public UnityEngine.Vector3 m_Velocity; // 0x28
        public int m_ColliderInstanceID; // 0x34

        // ── Methods ──
        public void get_velocity(){} // RVA: 0x7FFAC9830D10
        public void get_colliderComponent(){} // RVA: 0x7FFAC9960320
        public void InstanceIDToColliderComponent(){} // RVA: 0x7FFAC9960370
    }

    public class ParticlePhysicsExtensions : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFAC995D060
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
        public void Emit(){} // RVA: 0x7FFAC9946AD0 | overloaded x4
        public void get_startDelay(){} // RVA: 0x7FFAC9943B60
        public void set_startDelay(){} // RVA: 0x7FFAC9943C10
        public void get_loop(){} // RVA: 0x7FFAC9943CC0
        public void set_loop(){} // RVA: 0x7FFAC9943D70
        public void get_playOnAwake(){} // RVA: 0x7FFAC9943E20
        public void set_playOnAwake(){} // RVA: 0x7FFAC9943ED0
        public void get_duration(){} // RVA: 0x7FFAC9943F80
        public void get_playbackSpeed(){} // RVA: 0x7FFAC9944030
        public void set_playbackSpeed(){} // RVA: 0x7FFAC99440E0
        public void get_enableEmission(){} // RVA: 0x7FFAC9944190
        public void set_enableEmission(){} // RVA: 0x7FFAC9944240
        public void get_emissionRate(){} // RVA: 0x7FFAC99442F0
        public void set_emissionRate(){} // RVA: 0x7FFAC99443A0
        public void get_startSpeed(){} // RVA: 0x7FFAC9944480
        public void set_startSpeed(){} // RVA: 0x7FFAC9944530
        public void get_startSize(){} // RVA: 0x7FFAC99445E0
        public void set_startSize(){} // RVA: 0x7FFAC9944690
        public void get_startColor(){} // RVA: 0x7FFAC9944740
        public void set_startColor(){} // RVA: 0x7FFAC9944820
        public void get_startRotation(){} // RVA: 0x7FFAC9944930
        public void set_startRotation(){} // RVA: 0x7FFAC99449E0
        public void get_startRotation3D(){} // RVA: 0x7FFAC9944A90
        public void set_startRotation3D(){} // RVA: 0x7FFAC9944CC0
        public void get_startLifetime(){} // RVA: 0x7FFAC9944E00
        public void set_startLifetime(){} // RVA: 0x7FFAC9944EB0
        public void get_gravityModifier(){} // RVA: 0x7FFAC9944F60
        public void set_gravityModifier(){} // RVA: 0x7FFAC9945010
        public void get_maxParticles(){} // RVA: 0x7FFAC99450C0
        public void set_maxParticles(){} // RVA: 0x7FFAC9945170
        public void get_simulationSpace(){} // RVA: 0x7FFAC9945220
        public void set_simulationSpace(){} // RVA: 0x7FFAC99452D0
        public void get_scalingMode(){} // RVA: 0x7FFAC9945380
        public void set_scalingMode(){} // RVA: 0x7FFAC9945430
        public void get_automaticCullingEnabled(){} // RVA: 0x7FFAC99454E0
        public void get_isPlaying(){} // RVA: 0x7FFAC9945530
        public void get_isEmitting(){} // RVA: 0x7FFAC9945580
        public void get_isStopped(){} // RVA: 0x7FFAC99455D0
        public void get_isPaused(){} // RVA: 0x7FFAC9945620
        public void get_particleCount(){} // RVA: 0x7FFAC9945670
        public void get_time(){} // RVA: 0x7FFAC99456C0
        public void set_time(){} // RVA: 0x7FFAC9945710
        public void get_totalTime(){} // RVA: 0x7FFAC9945770
        public void get_randomSeed(){} // RVA: 0x7FFAC99457C0
        public void set_randomSeed(){} // RVA: 0x7FFAC9945810
        public void get_useAutoRandomSeed(){} // RVA: 0x7FFAC9945870
        public void set_useAutoRandomSeed(){} // RVA: 0x7FFAC99458C0
        public void get_proceduralSimulationSupported(){} // RVA: 0x7FFAC99454E0
        public void GetParticleCurrentSize(){} // RVA: 0x7FFAC9945920
        public void GetParticleCurrentSize3D(){} // RVA: 0x7FFAC9945980
        public void GetParticleCurrentColor(){} // RVA: 0x7FFAC9945A00
        public void GetParticleMeshIndex(){} // RVA: 0x7FFAC9945A70
        public void SetParticles(){} // RVA: 0x7FFAC9945D80 | overloaded x6
        public void SetParticlesWithNativeArray(){} // RVA: 0x7FFAC9945B90
        public void GetParticles(){} // RVA: 0x7FFAC99460D0 | overloaded x6
        public void GetParticlesWithNativeArray(){} // RVA: 0x7FFAC9945EE0
        public void SetCustomParticleData(){} // RVA: 0x7FFAC9946170
        public void GetCustomParticleData(){} // RVA: 0x7FFAC99461E0
        public void GetPlaybackState(){} // RVA: 0x7FFAC9946250
        public void SetPlaybackState(){} // RVA: 0x7FFAC99462C0
        public void GetTrailDataInternal(){} // RVA: 0x7FFAC9946320
        public void GetTrails(){} // RVA: 0x7FFAC9946430 | overloaded x2
        public void SetTrails(){} // RVA: 0x7FFAC99464D0
        public void Simulate(){} // RVA: 0x7FFAC9946600 | overloaded x4
        public void Play(){} // RVA: 0x7FFAC9946690 | overloaded x2
        public void Pause(){} // RVA: 0x7FFAC9946750 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAC9946890 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAC9946950 | overloaded x2
        public void IsAlive(){} // RVA: 0x7FFAC9946A10 | overloaded x2
        public void Emit_Internal(){} // RVA: 0x7FFAC9946A70
        public void EmitOld_Internal(){} // RVA: 0x7FFAC9946B40
        public void TriggerSubEmitter(){} // RVA: 0x7FFAC9946D40 | overloaded x3
        public void TriggerSubEmitterForParticle(){} // RVA: 0x7FFAC9946CD0
        public void ResetPreMappedBufferMemory(){} // RVA: 0x7FFAC9946DB0
        public void SetMaximumPreMappedBufferCounts(){} // RVA: 0x7FFAC9946E00
        public void AllocateAxisOfRotationAttribute(){} // RVA: 0x7FFAC9946E60
        public void AllocateMeshIndexAttribute(){} // RVA: 0x7FFAC9946EB0
        public void AllocateCustomDataAttribute(){} // RVA: 0x7FFAC9946F00
        public void get_has3DParticleRotations(){} // RVA: 0x7FFAC9946F60
        public void get_hasNonUniformParticleSizes(){} // RVA: 0x7FFAC9946FB0
        public void GetManagedJobData(){} // RVA: 0x7FFAC9947000
        public void GetManagedJobHandle(){} // RVA: 0x7FFAC9947050
        public void SetManagedJobHandle(){} // RVA: 0x7FFAC99470C0
        public void ScheduleManagedJob(){} // RVA: 0x7FFAC9947120
        public void CopyManagedJobData(){} // RVA: 0x7FFAC99471A0
        public void get_main(){} // RVA: 0x7FFAC38D6FB0
        public void get_emission(){} // RVA: 0x7FFAC38D6FB0
        public void get_shape(){} // RVA: 0x7FFAC38D6FB0
        public void get_velocityOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_limitVelocityOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_inheritVelocity(){} // RVA: 0x7FFAC38D6FB0
        public void get_lifetimeByEmitterSpeed(){} // RVA: 0x7FFAC38D6FB0
        public void get_forceOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_colorOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_colorBySpeed(){} // RVA: 0x7FFAC38D6FB0
        public void get_sizeOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_sizeBySpeed(){} // RVA: 0x7FFAC38D6FB0
        public void get_rotationOverLifetime(){} // RVA: 0x7FFAC38D6FB0
        public void get_rotationBySpeed(){} // RVA: 0x7FFAC38D6FB0
        public void get_externalForces(){} // RVA: 0x7FFAC38D6FB0
        public void get_noise(){} // RVA: 0x7FFAC38D6FB0
        public void get_collision(){} // RVA: 0x7FFAC38D6FB0
        public void get_trigger(){} // RVA: 0x7FFAC38D6FB0
        public void get_subEmitters(){} // RVA: 0x7FFAC38D6FB0
        public void get_textureSheetAnimation(){} // RVA: 0x7FFAC38D6FB0
        public void get_lights(){} // RVA: 0x7FFAC38D6FB0
        public void get_trails(){} // RVA: 0x7FFAC38D6FB0
        public void get_customData(){} // RVA: 0x7FFAC38D6FB0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void GetParticleCurrentSize3D_Injected(){} // RVA: 0x7FFAC9947200
        public void GetParticleCurrentColor_Injected(){} // RVA: 0x7FFAC9947270
        public void GetPlaybackState_Injected(){} // RVA: 0x7FFAC99472E0
        public void SetPlaybackState_Injected(){} // RVA: 0x7FFAC9947340
        public void SetTrails_Injected(){} // RVA: 0x7FFAC99473A0
        public void Emit_Injected(){} // RVA: 0x7FFAC9947400
        public void TriggerSubEmitterForParticle_Injected(){} // RVA: 0x7FFAC9947470
        public void GetManagedJobHandle_Injected(){} // RVA: 0x7FFAC99474E0
        public void SetManagedJobHandle_Injected(){} // RVA: 0x7FFAC9947540
        public void ScheduleManagedJob_Injected(){} // RVA: 0x7FFAC99475A0
    }

    public class ParticleSystemExtensionsImpl : Object
    {
        // ── Methods ──
        public void GetCollisionEvents(){} // RVA: 0x7FFAC995D060
    }

    public class ParticleSystemForceField : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
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
        public void EnableVertexStreams(){} // RVA: 0x7FFAC995D0D0
        public void DisableVertexStreams(){} // RVA: 0x7FFAC995D0E0
        public void AreVertexStreamsEnabled(){} // RVA: 0x7FFAC995D0F0
        public void GetEnabledVertexStreams(){} // RVA: 0x7FFAC995D110
        public void Internal_SetVertexStreams(){} // RVA: 0x7FFAC995D120
        public void Internal_GetEnabledVertexStreams(){} // RVA: 0x7FFAC995D800
        public void BakeMesh(){} // RVA: 0x7FFAC995F140 | overloaded x4
        public void BakeTrailsMesh(){} // RVA: 0x7FFAC995F240 | overloaded x4
        public void get_alignment(){} // RVA: 0x7FFAC995DF80
        public void set_alignment(){} // RVA: 0x7FFAC995DFD0
        public void get_renderMode(){} // RVA: 0x7FFAC995E030
        public void set_renderMode(){} // RVA: 0x7FFAC995E080
        public void get_meshDistribution(){} // RVA: 0x7FFAC995E0E0
        public void set_meshDistribution(){} // RVA: 0x7FFAC995E130
        public void get_sortMode(){} // RVA: 0x7FFAC995E190
        public void set_sortMode(){} // RVA: 0x7FFAC995E1E0
        public void get_lengthScale(){} // RVA: 0x7FFAC995E240
        public void set_lengthScale(){} // RVA: 0x7FFAC995E290
        public void get_velocityScale(){} // RVA: 0x7FFAC995E2F0
        public void set_velocityScale(){} // RVA: 0x7FFAC995E340
        public void get_cameraVelocityScale(){} // RVA: 0x7FFAC995E3A0
        public void set_cameraVelocityScale(){} // RVA: 0x7FFAC995E3F0
        public void get_normalDirection(){} // RVA: 0x7FFAC995E450
        public void set_normalDirection(){} // RVA: 0x7FFAC995E4A0
        public void get_shadowBias(){} // RVA: 0x7FFAC995E500
        public void set_shadowBias(){} // RVA: 0x7FFAC995E550
        public void get_sortingFudge(){} // RVA: 0x7FFAC995E5B0
        public void set_sortingFudge(){} // RVA: 0x7FFAC995E600
        public void get_minParticleSize(){} // RVA: 0x7FFAC995E660
        public void set_minParticleSize(){} // RVA: 0x7FFAC995E6B0
        public void get_maxParticleSize(){} // RVA: 0x7FFAC995E710
        public void set_maxParticleSize(){} // RVA: 0x7FFAC995E760
        public void get_pivot(){} // RVA: 0x7FFAC995E7C0
        public void set_pivot(){} // RVA: 0x7FFAC995E830
        public void get_flip(){} // RVA: 0x7FFAC995E890
        public void set_flip(){} // RVA: 0x7FFAC995E900
        public void get_maskInteraction(){} // RVA: 0x7FFAC995E960
        public void set_maskInteraction(){} // RVA: 0x7FFAC995E9B0
        public void get_trailMaterial(){} // RVA: 0x7FFAC995EA10
        public void set_trailMaterial(){} // RVA: 0x7FFAC995EA60
        public void set_oldTrailMaterial(){} // RVA: 0x7FFAC995EAC0
        public void get_enableGPUInstancing(){} // RVA: 0x7FFAC995EB20
        public void set_enableGPUInstancing(){} // RVA: 0x7FFAC995EB70
        public void get_allowRoll(){} // RVA: 0x7FFAC995EBD0
        public void set_allowRoll(){} // RVA: 0x7FFAC995EC20
        public void get_freeformStretching(){} // RVA: 0x7FFAC995EC80
        public void set_freeformStretching(){} // RVA: 0x7FFAC995ECD0
        public void get_rotateWithStretchDirection(){} // RVA: 0x7FFAC995ED30
        public void set_rotateWithStretchDirection(){} // RVA: 0x7FFAC995ED80
        public void get_mesh(){} // RVA: 0x7FFAC995EDE0
        public void set_mesh(){} // RVA: 0x7FFAC995EE30
        public void GetMeshes(){} // RVA: 0x7FFAC995EE90
        public void SetMeshes(){} // RVA: 0x7FFAC995EF60 | overloaded x2
        public void GetMeshWeightings(){} // RVA: 0x7FFAC995EF80
        public void SetMeshWeightings(){} // RVA: 0x7FFAC995F050 | overloaded x2
        public void get_meshCount(){} // RVA: 0x7FFAC995F070
        public void BakeTexture(){} // RVA: 0x7FFAC995F860 | overloaded x4
        public void BakeTextureNoIndicesInternal(){} // RVA: 0x7FFAC995F610
        public void BakeTextureInternal(){} // RVA: 0x7FFAC995F9D0
        public void BakeTrailsTexture(){} // RVA: 0x7FFAC995FC40 | overloaded x2
        public void BakeTrailsTextureInternal(){} // RVA: 0x7FFAC995FDB0
        public void get_activeVertexStreamsCount(){} // RVA: 0x7FFAC995FE60
        public void SetActiveVertexStreams(){} // RVA: 0x7FFAC995FEB0
        public void GetActiveVertexStreams(){} // RVA: 0x7FFAC995FF10
        public void get_activeTrailVertexStreamsCount(){} // RVA: 0x7FFAC995FF70
        public void SetActiveTrailVertexStreams(){} // RVA: 0x7FFAC995FFC0
        public void GetActiveTrailVertexStreams(){} // RVA: 0x7FFAC9960020
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_pivot_Injected(){} // RVA: 0x7FFAC9960080
        public void set_pivot_Injected(){} // RVA: 0x7FFAC99600E0
        public void get_flip_Injected(){} // RVA: 0x7FFAC9960140
        public void set_flip_Injected(){} // RVA: 0x7FFAC99601A0
        public void BakeTextureInternal_Injected(){} // RVA: 0x7FFAC9960200
        public void BakeTrailsTextureInternal_Injected(){} // RVA: 0x7FFAC9960290
    }

    public class PenData : ValueType
    {
        public UnityEngine.Vector2 position; // 0x10
        public UnityEngine.Vector2 tilt; // 0x18
        public 0x6B2D9160 penStatus; // 0x20
        public float twist; // 0x24
        public float pressure; // 0x28
        public 0x6B2D91B8 contactType; // 0x2C
        public UnityEngine.Vector2 deltaPos; // 0x30
    }

    public class PhysicMaterial : Object
    {
        public object bounciness;
        public object dynamicFriction;
        public object staticFriction;
        public object frictionCombine;
        public object bounceCombine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99938D0 | overloaded x2
        public void Internal_CreateDynamicsMaterial(){} // RVA: 0x7FFAC9993970
        public void get_bounciness(){} // RVA: 0x7FFAC99939D0
        public void set_bounciness(){} // RVA: 0x7FFAC9993A20
        public void get_dynamicFriction(){} // RVA: 0x7FFAC9993A80
        public void set_dynamicFriction(){} // RVA: 0x7FFAC9993AD0
        public void get_staticFriction(){} // RVA: 0x7FFAC9993B30
        public void set_staticFriction(){} // RVA: 0x7FFAC9993B80
        public void get_frictionCombine(){} // RVA: 0x7FFAC9993BE0
        public void set_frictionCombine(){} // RVA: 0x7FFAC9993C30
        public void get_bounceCombine(){} // RVA: 0x7FFAC9993C90
        public void set_bounceCombine(){} // RVA: 0x7FFAC9993CE0
    }

    public class Physics : Object
    {
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> gravity;
        public System.Action`2<UnityEngine.PhysicsScene,Unity.Collections.NativeArray`1<UnityEngine.ModifiableContactPair>> bounceThreshold; // 0x8
        public ContactEventDelegate simulationMode; // 0x10
        public UnityEngine.Collision defaultMaxAngularSpeed; // 0x18

        // ── Methods ──
        public void OnSceneContactModify(){} // RVA: 0x7FFAC99883A0
        public void get_gravity(){} // RVA: 0x7FFAC9988490
        public void set_gravity(){} // RVA: 0x7FFAC9988520
        public void get_bounceThreshold(){} // RVA: 0x7FFAC99885B0
        public void set_bounceThreshold(){} // RVA: 0x7FFAC9988600
        public void get_simulationMode(){} // RVA: 0x7FFAC9988660
        public void set_simulationMode(){} // RVA: 0x7FFAC99886B0
        public void get_defaultMaxAngularSpeed(){} // RVA: 0x7FFAC9988700
        public void set_defaultMaxAngularSpeed(){} // RVA: 0x7FFAC9988750
        public void get_invokeCollisionCallbacks(){} // RVA: 0x7FFAC99887B0
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFAC9988800
        public void IgnoreCollision(){} // RVA: 0x7FFAC9988900 | overloaded x2
        public void IgnoreLayerCollision(){} // RVA: 0x7FFAC9988A10 | overloaded x2
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFAC9988AB0
        public void GetIgnoreCollision(){} // RVA: 0x7FFAC9988B10
        public void Raycast(){} // RVA: 0x7FFAC9989790 | overloaded x16
        public void Linecast(){} // RVA: 0x7FFAC9989C90 | overloaded x6
        public void CapsuleCast(){} // RVA: 0x7FFAC998A570 | overloaded x8
        public void SphereCast(){} // RVA: 0x7FFAC998B050 | overloaded x12
        public void BoxCast(){} // RVA: 0x7FFAC998BB90 | overloaded x10
        public void Internal_RaycastAll(){} // RVA: 0x7FFAC998BCC0
        public void RaycastAll(){} // RVA: 0x7FFAC998C3F0 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFAC998CA50 | overloaded x8
        public void Query_CapsuleCastAll(){} // RVA: 0x7FFAC998CB20
        public void CapsuleCastAll(){} // RVA: 0x7FFAC998CFF0 | overloaded x4
        public void Query_SphereCastAll(){} // RVA: 0x7FFAC998D0D0
        public void SphereCastAll(){} // RVA: 0x7FFAC998D850 | overloaded x8
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFAC998D960
        public void OverlapCapsule(){} // RVA: 0x7FFAC998DC20 | overloaded x3
        public void OverlapSphere_Internal(){} // RVA: 0x7FFAC998DCD0
        public void OverlapSphere(){} // RVA: 0x7FFAC998DF30 | overloaded x3
        public void Simulate_Internal(){} // RVA: 0x7FFAC998DFC0
        public void Simulate(){} // RVA: 0x7FFAC998E060
        public void InterpolateBodies_Internal(){} // RVA: 0x7FFAC998E170
        public void ResetInterpolationPoses_Internal(){} // RVA: 0x7FFAC998E200
        public void SyncTransforms(){} // RVA: 0x7FFAC998E290
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFAC998E2E0
        public void Query_ComputePenetration(){} // RVA: 0x7FFAC998E330
        public void ComputePenetration(){} // RVA: 0x7FFAC998E420
        public void Query_ClosestPoint(){} // RVA: 0x7FFAC998E5E0
        public void ClosestPoint(){} // RVA: 0x7FFAC998E6B0
        public void OverlapSphereNonAlloc(){} // RVA: 0x7FFAC998E9A0 | overloaded x3
        public void CheckSphere_Internal(){} // RVA: 0x7FFAC998EA30
        public void CheckSphere(){} // RVA: 0x7FFAC998EC90 | overloaded x3
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFAC998F090 | overloaded x4
        public void SphereCastNonAlloc(){} // RVA: 0x7FFAC998F790 | overloaded x8
        public void CheckCapsule_Internal(){} // RVA: 0x7FFAC998F830
        public void CheckCapsule(){} // RVA: 0x7FFAC998FAF0 | overloaded x3
        public void CheckBox_Internal(){} // RVA: 0x7FFAC998FBA0
        public void CheckBox(){} // RVA: 0x7FFAC998FFF0 | overloaded x4
        public void OverlapBox_Internal(){} // RVA: 0x7FFAC9990190
        public void OverlapBox(){} // RVA: 0x7FFAC99905E0 | overloaded x4
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFAC9990B40 | overloaded x4
        public void BoxCastNonAlloc(){} // RVA: 0x7FFAC9991390 | overloaded x5
        public void Internal_BoxCastAll(){} // RVA: 0x7FFAC9991580
        public void BoxCastAll(){} // RVA: 0x7FFAC9991B40 | overloaded x5
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFAC9991E30 | overloaded x3
        public void Internal_RebuildBroadphaseRegions(){} // RVA: 0x7FFAC9991EF0
        public void RebuildBroadphaseRegions(){} // RVA: 0x7FFAC9991F90
        public void BakeMesh(){} // RVA: 0x7FFAC99921D0 | overloaded x2
        public void GetColliderByInstanceID(){} // RVA: 0x7FFAC9992270
        public void GetBodyByInstanceID(){} // RVA: 0x7FFAC99922C0
        public void SendOnCollisionEnter(){} // RVA: 0x7FFAC9992310
        public void SendOnCollisionStay(){} // RVA: 0x7FFAC9992370
        public void SendOnCollisionExit(){} // RVA: 0x7FFAC99923D0
        public void OnSceneContact(){} // RVA: 0x7FFAC9992430
        public void ReportContacts(){} // RVA: 0x7FFAC9992660
        public void GetCollisionToReport(){} // RVA: 0x7FFAC9992B30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9992E40
        public void get_gravity_Injected(){} // RVA: 0x7FFAC9992F10
        public void set_gravity_Injected(){} // RVA: 0x7FFAC9992F60
        public void get_defaultPhysicsScene_Injected(){} // RVA: 0x7FFAC9992FB0
        public void Internal_RaycastAll_Injected(){} // RVA: 0x7FFAC9993000
        public void Query_CapsuleCastAll_Injected(){} // RVA: 0x7FFAC9993090
        public void Query_SphereCastAll_Injected(){} // RVA: 0x7FFAC9993120
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFAC99931B0
        public void OverlapSphere_Internal_Injected(){} // RVA: 0x7FFAC9993240
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFAC99932D0
        public void InterpolateBodies_Internal_Injected(){} // RVA: 0x7FFAC9993330
        public void ResetInterpolationPoses_Internal_Injected(){} // RVA: 0x7FFAC9993380
        public void Query_ComputePenetration_Injected(){} // RVA: 0x7FFAC99933D0
        public void Query_ClosestPoint_Injected(){} // RVA: 0x7FFAC9993460
        public void CheckSphere_Internal_Injected(){} // RVA: 0x7FFAC99934F0
        public void CheckCapsule_Internal_Injected(){} // RVA: 0x7FFAC9993580
        public void CheckBox_Internal_Injected(){} // RVA: 0x7FFAC9993610
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFAC99936A0
        public void Internal_BoxCastAll_Injected(){} // RVA: 0x7FFAC9993730
        public void Internal_RebuildBroadphaseRegions_Injected(){} // RVA: 0x7FFAC99937C0
    }

    public class Physics2D : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody2D> defaultPhysicsScene;

        // ── Methods ──
        public void get_defaultPhysicsScene(){} // RVA: 0x7FFAC67332B0
        public void get_velocityIterations(){} // RVA: 0x7FFAC9966160
        public void set_velocityIterations(){} // RVA: 0x7FFAC99661B0
        public void get_positionIterations(){} // RVA: 0x7FFAC9966200
        public void set_positionIterations(){} // RVA: 0x7FFAC9966250
        public void get_gravity(){} // RVA: 0x7FFAC99662A0
        public void set_gravity(){} // RVA: 0x7FFAC9966330
        public void get_queriesHitTriggers(){} // RVA: 0x7FFAC99663C0
        public void get_queriesStartInColliders(){} // RVA: 0x7FFAC9966410
        public void set_queriesStartInColliders(){} // RVA: 0x7FFAC9966460
        public void get_callbacksOnDisable(){} // RVA: 0x7FFAC99664B0
        public void set_callbacksOnDisable(){} // RVA: 0x7FFAC9966500
        public void get_reuseCollisionCallbacks(){} // RVA: 0x7FFAC9966550
        public void set_reuseCollisionCallbacks(){} // RVA: 0x7FFAC99665A0
        public void get_velocityThreshold(){} // RVA: 0x7FFAC99665F0
        public void set_velocityThreshold(){} // RVA: 0x7FFAC9966640
        public void get_maxLinearCorrection(){} // RVA: 0x7FFAC99666A0
        public void set_maxLinearCorrection(){} // RVA: 0x7FFAC99666F0
        public void get_maxAngularCorrection(){} // RVA: 0x7FFAC9966750
        public void set_maxAngularCorrection(){} // RVA: 0x7FFAC99667A0
        public void get_maxTranslationSpeed(){} // RVA: 0x7FFAC9966800
        public void set_maxTranslationSpeed(){} // RVA: 0x7FFAC9966850
        public void get_maxRotationSpeed(){} // RVA: 0x7FFAC99668B0
        public void set_maxRotationSpeed(){} // RVA: 0x7FFAC9966900
        public void get_baumgarteScale(){} // RVA: 0x7FFAC9966960
        public void set_baumgarteScale(){} // RVA: 0x7FFAC99669B0
        public void get_baumgarteTOIScale(){} // RVA: 0x7FFAC9966A10
        public void set_baumgarteTOIScale(){} // RVA: 0x7FFAC9966A60
        public void get_timeToSleep(){} // RVA: 0x7FFAC9966AC0
        public void set_timeToSleep(){} // RVA: 0x7FFAC9966B10
        public void get_linearSleepTolerance(){} // RVA: 0x7FFAC9966B70
        public void set_linearSleepTolerance(){} // RVA: 0x7FFAC9966BC0
        public void get_angularSleepTolerance(){} // RVA: 0x7FFAC9966C20
        public void set_angularSleepTolerance(){} // RVA: 0x7FFAC9966C70
        public void Simulate(){} // RVA: 0x7FFAC9966CD0
        public void Simulate_Internal(){} // RVA: 0x7FFAC9966D30
        public void SyncTransforms(){} // RVA: 0x7FFAC9966DD0
        public void IgnoreCollision(){} // RVA: 0x7FFAC9966EC0 | overloaded x2
        public void GetIgnoreCollision(){} // RVA: 0x7FFAC9966F30
        public void GetIgnoreLayerCollision(){} // RVA: 0x7FFAC9966F90
        public void GetIgnoreLayerCollision_Internal(){} // RVA: 0x7FFAC99670D0
        public void SetLayerCollisionMask(){} // RVA: 0x7FFAC9967130
        public void SetLayerCollisionMask_Internal(){} // RVA: 0x7FFAC9967220
        public void GetLayerCollisionMask(){} // RVA: 0x7FFAC9967280
        public void GetLayerCollisionMask_Internal(){} // RVA: 0x7FFAC9967360
        public void IsTouching(){} // RVA: 0x7FFAC99675C0 | overloaded x3
        public void IsTouching_TwoCollidersWithFilter(){} // RVA: 0x7FFAC9967510
        public void IsTouching_SingleColliderWithFilter(){} // RVA: 0x7FFAC99676B0
        public void IsTouchingLayers(){} // RVA: 0x7FFAC99677E0 | overloaded x2
        public void Distance(){} // RVA: 0x7FFAC9967840
        public void Distance_Internal(){} // RVA: 0x7FFAC9967BE0
        public void ClosestPoint(){} // RVA: 0x7FFAC9967E80 | overloaded x2
        public void ClosestPoint_Collider(){} // RVA: 0x7FFAC9968060
        public void ClosestPoint_Rigidbody(){} // RVA: 0x7FFAC9968100
        public void Linecast(){} // RVA: 0x7FFAC9968850 | overloaded x6
        public void LinecastAll(){} // RVA: 0x7FFAC9968DB0 | overloaded x4
        public void LinecastAll_Internal(){} // RVA: 0x7FFAC9968F20
        public void LinecastNonAlloc(){} // RVA: 0x7FFAC9969300 | overloaded x4
        public void Raycast(){} // RVA: 0x7FFAC9969D90 | overloaded x8
        public void RaycastNonAlloc(){} // RVA: 0x7FFAC996A2C0 | overloaded x5
        public void RaycastAll(){} // RVA: 0x7FFAC996A820 | overloaded x5
        public void RaycastAll_Internal(){} // RVA: 0x7FFAC996A920
        public void CircleCast(){} // RVA: 0x7FFAC996B3B0 | overloaded x8
        public void CircleCastAll(){} // RVA: 0x7FFAC996B930 | overloaded x5
        public void CircleCastAll_Internal(){} // RVA: 0x7FFAC996BA40
        public void CircleCastNonAlloc(){} // RVA: 0x7FFAC996BF70 | overloaded x5
        public void BoxCast(){} // RVA: 0x7FFAC996CB70 | overloaded x8
        public void BoxCastAll(){} // RVA: 0x7FFAC996D160 | overloaded x5
        public void BoxCastAll_Internal(){} // RVA: 0x7FFAC996D280
        public void BoxCastNonAlloc(){} // RVA: 0x7FFAC996D840 | overloaded x5
        public void CapsuleCast(){} // RVA: 0x7FFAC996E490 | overloaded x8
        public void CapsuleCastAll(){} // RVA: 0x7FFAC996EB90 | overloaded x5
        public void CapsuleCastAll_Internal(){} // RVA: 0x7FFAC996E850
        public void CapsuleCastNonAlloc(){} // RVA: 0x7FFAC996F1C0 | overloaded x5
        public void GetRayIntersection(){} // RVA: 0x7FFAC996F620 | overloaded x3
        public void GetRayIntersectionAll(){} // RVA: 0x7FFAC996F9A0 | overloaded x3
        public void GetRayIntersectionAll_Internal(){} // RVA: 0x7FFAC996FAC0
        public void GetRayIntersectionNonAlloc(){} // RVA: 0x7FFAC996FD90 | overloaded x3
        public void OverlapPoint(){} // RVA: 0x7FFAC9970330 | overloaded x6
        public void OverlapPointAll(){} // RVA: 0x7FFAC9970820 | overloaded x4
        public void OverlapPointAll_Internal(){} // RVA: 0x7FFAC9970970
        public void OverlapPointNonAlloc(){} // RVA: 0x7FFAC9970CF0 | overloaded x4
        public void OverlapCircle(){} // RVA: 0x7FFAC9971330 | overloaded x6
        public void OverlapCircleAll(){} // RVA: 0x7FFAC9971860 | overloaded x4
        public void OverlapCircleAll_Internal(){} // RVA: 0x7FFAC99719C0
        public void OverlapCircleNonAlloc(){} // RVA: 0x7FFAC9971D80 | overloaded x4
        public void OverlapBox(){} // RVA: 0x7FFAC9972480 | overloaded x6
        public void OverlapBoxAll(){} // RVA: 0x7FFAC99728B0 | overloaded x4
        public void OverlapBoxAll_Internal(){} // RVA: 0x7FFAC99729B0
        public void OverlapBoxNonAlloc(){} // RVA: 0x7FFAC9972DE0 | overloaded x4
        public void OverlapArea(){} // RVA: 0x7FFAC99733E0 | overloaded x6
        public void OverlapAreaAll(){} // RVA: 0x7FFAC9973680 | overloaded x4
        public void OverlapAreaAllToBox_Internal(){} // RVA: 0x7FFAC9973720
        public void OverlapAreaNonAlloc(){} // RVA: 0x7FFAC9973B80 | overloaded x4
        public void OverlapCapsule(){} // RVA: 0x7FFAC99742A0 | overloaded x6
        public void OverlapCapsuleAll(){} // RVA: 0x7FFAC9974890 | overloaded x4
        public void OverlapCapsuleAll_Internal(){} // RVA: 0x7FFAC9974A30
        public void OverlapCapsuleNonAlloc(){} // RVA: 0x7FFAC9974E90 | overloaded x4
        public void OverlapCollider(){} // RVA: 0x7FFAC9964EF0 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFAC99766A0 | overloaded x18
        public void GetColliderContactsArray(){} // RVA: 0x7FFAC9975A10
        public void GetColliderColliderContactsArray(){} // RVA: 0x7FFAC9975AC0
        public void GetRigidbodyContactsArray(){} // RVA: 0x7FFAC9975B80
        public void GetColliderContactsCollidersOnlyArray(){} // RVA: 0x7FFAC9975C30
        public void GetRigidbodyContactsCollidersOnlyArray(){} // RVA: 0x7FFAC9975CE0
        public void GetColliderContactsList(){} // RVA: 0x7FFAC99767A0
        public void GetColliderColliderContactsList(){} // RVA: 0x7FFAC9976850
        public void GetRigidbodyContactsList(){} // RVA: 0x7FFAC9976910
        public void GetColliderContactsCollidersOnlyList(){} // RVA: 0x7FFAC99769C0
        public void GetRigidbodyContactsCollidersOnlyList(){} // RVA: 0x7FFAC9976A70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9976B20
        public void get_gravity_Injected(){} // RVA: 0x7FFAC9976C00
        public void set_gravity_Injected(){} // RVA: 0x7FFAC9976C50
        public void Simulate_Internal_Injected(){} // RVA: 0x7FFAC9976CA0
        public void IsTouching_TwoCollidersWithFilter_Injected(){} // RVA: 0x7FFAC9976D00
        public void IsTouching_SingleColliderWithFilter_Injected(){} // RVA: 0x7FFAC9976D70
        public void Distance_Internal_Injected(){} // RVA: 0x7FFAC9976DD0
        public void ClosestPoint_Collider_Injected(){} // RVA: 0x7FFAC9976E40
        public void ClosestPoint_Rigidbody_Injected(){} // RVA: 0x7FFAC9976EB0
        public void LinecastAll_Internal_Injected(){} // RVA: 0x7FFAC9976F20
        public void RaycastAll_Internal_Injected(){} // RVA: 0x7FFAC9976FA0
        public void CircleCastAll_Internal_Injected(){} // RVA: 0x7FFAC9977030
        public void BoxCastAll_Internal_Injected(){} // RVA: 0x7FFAC99770C0
        public void CapsuleCastAll_Internal_Injected(){} // RVA: 0x7FFAC9977150
        public void GetRayIntersectionAll_Internal_Injected(){} // RVA: 0x7FFAC99771E0
        public void OverlapPointAll_Internal_Injected(){} // RVA: 0x7FFAC9977270
        public void OverlapCircleAll_Internal_Injected(){} // RVA: 0x7FFAC99772E0
        public void OverlapBoxAll_Internal_Injected(){} // RVA: 0x7FFAC9977360
        public void OverlapCapsuleAll_Internal_Injected(){} // RVA: 0x7FFAC99773F0
        public void GetColliderContactsArray_Injected(){} // RVA: 0x7FFAC9977480
        public void GetColliderColliderContactsArray_Injected(){} // RVA: 0x7FFAC99774F0
        public void GetRigidbodyContactsArray_Injected(){} // RVA: 0x7FFAC9977570
        public void GetColliderContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFAC99775E0
        public void GetRigidbodyContactsCollidersOnlyArray_Injected(){} // RVA: 0x7FFAC9977650
        public void GetColliderContactsList_Injected(){} // RVA: 0x7FFAC99776C0
        public void GetColliderColliderContactsList_Injected(){} // RVA: 0x7FFAC9977730
        public void GetRigidbodyContactsList_Injected(){} // RVA: 0x7FFAC99777B0
        public void GetColliderContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFAC9977820
        public void GetRigidbodyContactsCollidersOnlyList_Injected(){} // RVA: 0x7FFAC9977890
    }

    public class PhysicsMaterial2D : Object
    {
        public object bounciness;
        public object friction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9987250
        public void Create_Internal(){} // RVA: 0x7FFAC99872E0
        public void get_bounciness(){} // RVA: 0x7FFAC9987340
        public void set_bounciness(){} // RVA: 0x7FFAC9987390
        public void get_friction(){} // RVA: 0x7FFAC99873F0
        public void set_friction(){} // RVA: 0x7FFAC9987440
    }

    public class PhysicsScene : ValueType
    {
        public int m_Handle; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC999FBF0
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void op_Inequality(){} // RVA: 0x7FFAC98E1C80
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC999FD60
        public void IsValid_Internal(){} // RVA: 0x7FFAC999FDC0
        public void IsEmpty(){} // RVA: 0x7FFAC999FE10
        public void IsEmpty_Internal(){} // RVA: 0x7FFAC999FF00
        public void Simulate(){} // RVA: 0x7FFAC999FF50
        public void InterpolateBodies(){} // RVA: 0x7FFAC99A0130
        public void ResetInterpolationPoses(){} // RVA: 0x7FFAC99A0320
        public void Raycast(){} // RVA: 0x7FFAC99A0A30 | overloaded x3
        public void Internal_RaycastTest(){} // RVA: 0x7FFAC99A0700
        public void Internal_Raycast(){} // RVA: 0x7FFAC99A09A0
        public void Internal_RaycastNonAlloc(){} // RVA: 0x7FFAC99A0C00
        public void Query_CapsuleCast(){} // RVA: 0x7FFAC99A0C90
        public void Internal_CapsuleCast(){} // RVA: 0x7FFAC99A0D50
        public void CapsuleCast(){} // RVA: 0x7FFAC99A1110 | overloaded x2
        public void Internal_CapsuleCastNonAlloc(){} // RVA: 0x7FFAC99A1050
        public void OverlapCapsuleNonAlloc_Internal(){} // RVA: 0x7FFAC99A1250
        public void OverlapCapsule(){} // RVA: 0x7FFAC99A12F0
        public void Query_SphereCast(){} // RVA: 0x7FFAC99A13B0
        public void Internal_SphereCast(){} // RVA: 0x7FFAC99A1460
        public void SphereCast(){} // RVA: 0x7FFAC99A17B0 | overloaded x2
        public void Internal_SphereCastNonAlloc(){} // RVA: 0x7FFAC99A1700
        public void OverlapSphereNonAlloc_Internal(){} // RVA: 0x7FFAC99A18C0
        public void OverlapSphere(){} // RVA: 0x7FFAC99A1950
        public void Query_BoxCast(){} // RVA: 0x7FFAC99A19F0
        public void Internal_BoxCast(){} // RVA: 0x7FFAC99A1AB0
        public void BoxCast(){} // RVA: 0x7FFAC99A2400 | overloaded x4
        public void OverlapBoxNonAlloc_Internal(){} // RVA: 0x7FFAC99A1F80
        public void OverlapBox(){} // RVA: 0x7FFAC99A20F0 | overloaded x2
        public void Internal_BoxCastNonAlloc(){} // RVA: 0x7FFAC99A2200
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFAC99A2580
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFAC99A25D0
        public void Internal_RaycastTest_Injected(){} // RVA: 0x7FFAC99A2620
        public void Internal_Raycast_Injected(){} // RVA: 0x7FFAC99A26B0
        public void Internal_RaycastNonAlloc_Injected(){} // RVA: 0x7FFAC99A2740
        public void Query_CapsuleCast_Injected(){} // RVA: 0x7FFAC99A27D0
        public void Internal_CapsuleCastNonAlloc_Injected(){} // RVA: 0x7FFAC99A2860
        public void OverlapCapsuleNonAlloc_Internal_Injected(){} // RVA: 0x7FFAC99A28F0
        public void Query_SphereCast_Injected(){} // RVA: 0x7FFAC99A2980
        public void Internal_SphereCastNonAlloc_Injected(){} // RVA: 0x7FFAC99A2A10
        public void OverlapSphereNonAlloc_Internal_Injected(){} // RVA: 0x7FFAC99A2AA0
        public void Query_BoxCast_Injected(){} // RVA: 0x7FFAC99A2B30
        public void OverlapBoxNonAlloc_Internal_Injected(){} // RVA: 0x7FFAC99A2BC0
        public void Internal_BoxCastNonAlloc_Injected(){} // RVA: 0x7FFAC99A2C50
    }

    public class PhysicsScene2D : ValueType
    {
        public int m_Handle; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC99603C0
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void op_Inequality(){} // RVA: 0x7FFAC98E1C80
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC9960530
        public void IsValid_Internal(){} // RVA: 0x7FFAC9960590
        public void IsEmpty(){} // RVA: 0x7FFAC99605E0
        public void IsEmpty_Internal(){} // RVA: 0x7FFAC99606D0
        public void Simulate(){} // RVA: 0x7FFAC9960720
        public void Linecast(){} // RVA: 0x7FFAC9960D20 | overloaded x5
        public void Linecast_Internal(){} // RVA: 0x7FFAC9960A60
        public void LinecastArray_Internal(){} // RVA: 0x7FFAC9960CA0
        public void LinecastNonAllocList_Internal(){} // RVA: 0x7FFAC9960DC0
        public void Raycast(){} // RVA: 0x7FFAC99613C0 | overloaded x5
        public void Raycast_Internal(){} // RVA: 0x7FFAC99610A0
        public void RaycastArray_Internal(){} // RVA: 0x7FFAC9961320
        public void RaycastList_Internal(){} // RVA: 0x7FFAC9961480
        public void CircleCast(){} // RVA: 0x7FFAC9961B00 | overloaded x5
        public void CircleCast_Internal(){} // RVA: 0x7FFAC99617C0
        public void CircleCastArray_Internal(){} // RVA: 0x7FFAC9961A60
        public void CircleCastList_Internal(){} // RVA: 0x7FFAC9961BD0
        public void BoxCast(){} // RVA: 0x7FFAC99622E0 | overloaded x5
        public void BoxCast_Internal(){} // RVA: 0x7FFAC9961F40
        public void BoxCastArray_Internal(){} // RVA: 0x7FFAC9962230
        public void BoxCastList_Internal(){} // RVA: 0x7FFAC99623D0
        public void CapsuleCast(){} // RVA: 0x7FFAC9962B40 | overloaded x5
        public void CapsuleCast_Internal(){} // RVA: 0x7FFAC9962770
        public void CapsuleCastArray_Internal(){} // RVA: 0x7FFAC9962A80
        public void CapsuleCastList_Internal(){} // RVA: 0x7FFAC9962C30
        public void GetRayIntersection(){} // RVA: 0x7FFAC9962E90 | overloaded x2
        public void GetRayIntersection_Internal(){} // RVA: 0x7FFAC9962DF0
        public void GetRayIntersectionArray_Internal(){} // RVA: 0x7FFAC9962F40
        public void OverlapPoint(){} // RVA: 0x7FFAC9963380 | overloaded x5
        public void OverlapPoint_Internal(){} // RVA: 0x7FFAC9963120
        public void OverlapPointArray_Internal(){} // RVA: 0x7FFAC9963300
        public void OverlapPointList_Internal(){} // RVA: 0x7FFAC9963410
        public void OverlapCircle(){} // RVA: 0x7FFAC99638C0 | overloaded x5
        public void OverlapCircle_Internal(){} // RVA: 0x7FFAC9963600
        public void OverlapCircleArray_Internal(){} // RVA: 0x7FFAC9963830
        public void OverlapCircleList_Internal(){} // RVA: 0x7FFAC9963970
        public void OverlapBox(){} // RVA: 0x7FFAC9963EC0 | overloaded x5
        public void OverlapBox_Internal(){} // RVA: 0x7FFAC9963BB0
        public void OverlapBoxArray_Internal(){} // RVA: 0x7FFAC9963E20
        public void OverlapBoxList_Internal(){} // RVA: 0x7FFAC9963F80
        public void OverlapArea(){} // RVA: 0x7FFAC9964530 | overloaded x5
        public void OverlapAreaToBoxArray_Internal(){} // RVA: 0x7FFAC9964390 | overloaded x2
        public void OverlapAreaToBoxList_Internal(){} // RVA: 0x7FFAC9964580
        public void OverlapCapsule(){} // RVA: 0x7FFAC9964BF0 | overloaded x5
        public void OverlapCapsule_Internal(){} // RVA: 0x7FFAC99648E0
        public void OverlapCapsuleArray_Internal(){} // RVA: 0x7FFAC9964B50
        public void OverlapCapsuleList_Internal(){} // RVA: 0x7FFAC9964CB0
        public void OverlapCollider(){} // RVA: 0x7FFAC9964EF0 | overloaded x3
        public void OverlapColliderArray_Internal(){} // RVA: 0x7FFAC9964E80
        public void OverlapColliderList_Internal(){} // RVA: 0x7FFAC9964F70
        public void IsValid_Internal_Injected(){} // RVA: 0x7FFAC9964FE0
        public void IsEmpty_Internal_Injected(){} // RVA: 0x7FFAC9965030
        public void Linecast_Internal_Injected(){} // RVA: 0x7FFAC9965080
        public void LinecastArray_Internal_Injected(){} // RVA: 0x7FFAC9965110
        public void LinecastNonAllocList_Internal_Injected(){} // RVA: 0x7FFAC99651A0
        public void Raycast_Internal_Injected(){} // RVA: 0x7FFAC9965230
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFAC99652C0
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFAC9965350
        public void CircleCast_Internal_Injected(){} // RVA: 0x7FFAC99653E0
        public void CircleCastArray_Internal_Injected(){} // RVA: 0x7FFAC9965470
        public void CircleCastList_Internal_Injected(){} // RVA: 0x7FFAC9965500
        public void BoxCast_Internal_Injected(){} // RVA: 0x7FFAC9965590
        public void BoxCastArray_Internal_Injected(){} // RVA: 0x7FFAC9965620
        public void BoxCastList_Internal_Injected(){} // RVA: 0x7FFAC99656B0
        public void CapsuleCast_Internal_Injected(){} // RVA: 0x7FFAC9965740
        public void CapsuleCastArray_Internal_Injected(){} // RVA: 0x7FFAC99657D0
        public void CapsuleCastList_Internal_Injected(){} // RVA: 0x7FFAC9965860
        public void GetRayIntersection_Internal_Injected(){} // RVA: 0x7FFAC99658F0
        public void GetRayIntersectionArray_Internal_Injected(){} // RVA: 0x7FFAC9965980
        public void OverlapPoint_Internal_Injected(){} // RVA: 0x7FFAC9965A10
        public void OverlapPointArray_Internal_Injected(){} // RVA: 0x7FFAC9965A80
        public void OverlapPointList_Internal_Injected(){} // RVA: 0x7FFAC9965B00
        public void OverlapCircle_Internal_Injected(){} // RVA: 0x7FFAC9965B80
        public void OverlapCircleArray_Internal_Injected(){} // RVA: 0x7FFAC9965C00
        public void OverlapCircleList_Internal_Injected(){} // RVA: 0x7FFAC9965C90
        public void OverlapBox_Internal_Injected(){} // RVA: 0x7FFAC9965D20
        public void OverlapBoxArray_Internal_Injected(){} // RVA: 0x7FFAC9965DB0
        public void OverlapBoxList_Internal_Injected(){} // RVA: 0x7FFAC9965E40
        public void OverlapCapsule_Internal_Injected(){} // RVA: 0x7FFAC9965ED0
        public void OverlapCapsuleArray_Internal_Injected(){} // RVA: 0x7FFAC9965F60
        public void OverlapCapsuleList_Internal_Injected(){} // RVA: 0x7FFAC9965FF0
        public void OverlapColliderArray_Internal_Injected(){} // RVA: 0x7FFAC9966080
        public void OverlapColliderList_Internal_Injected(){} // RVA: 0x7FFAC99660F0
    }

    public class PhysicsShape2D : ValueType
    {
        public 0x6B29B308 m_ShapeType; // 0x10
        public float m_Radius; // 0x14
        public int m_VertexStartIndex; // 0x18
        public int m_VertexCount; // 0x1C
        public int m_UseAdjacentStart; // 0x20
        public int m_UseAdjacentEnd; // 0x24
        public UnityEngine.Vector2 m_AdjacentStart; // 0x28
        public UnityEngine.Vector2 m_AdjacentEnd; // 0x30
    }

    public class PhysicsShapeGroup2D : Object
    {
        public GroupState m_GroupState; // 0x10
    }

    public class PhysicsUpdateBehaviour2D : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Plane : ValueType
    {
        public int normal;
        public UnityEngine.Vector3 distance; // 0x10
        public float flipped; // 0x1C

        // ── Methods ──
        public void get_normal(){} // RVA: 0x7FFAC9811DA0
        public void set_normal(){} // RVA: 0x7FFAC530B6C0
        public void get_distance(){} // RVA: 0x7FFAC2F44D00
        public void set_distance(){} // RVA: 0x7FFAC4A9B8C0
        public void .ctor(){} // RVA: 0x7FFAC895B140 | overloaded x3
        public void SetNormalAndPosition(){} // RVA: 0x7FFAC30C6C20
        public void Set3Points(){} // RVA: 0x7FFAC895B140
        public void Flip(){} // RVA: 0x7FFAC9865D30
        public void get_flipped(){} // RVA: 0x7FFAC9865D80
        public void Translate(){} // RVA: 0x7FFAC9865EF0 | overloaded x2
        public void ClosestPointOnPlane(){} // RVA: 0x7FFAC9866000
        public void GetDistanceToPoint(){} // RVA: 0x7FFAC9866090
        public void GetSide(){} // RVA: 0x7FFAC98660E0
        public void SameSide(){} // RVA: 0x7FFAC9866130
        public void Raycast(){} // RVA: 0x7FFAC35E1A10
        public void ToString(){} // RVA: 0x7FFAC98661F0 | overloaded x3
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
        public void get_useOneWay(){} // RVA: 0x7FFAC99865B0
        public void set_useOneWay(){} // RVA: 0x7FFAC9986600
        public void get_useOneWayGrouping(){} // RVA: 0x7FFAC9986660
        public void set_useOneWayGrouping(){} // RVA: 0x7FFAC99866B0
        public void get_useSideFriction(){} // RVA: 0x7FFAC9986710
        public void set_useSideFriction(){} // RVA: 0x7FFAC9986760
        public void get_useSideBounce(){} // RVA: 0x7FFAC99867C0
        public void set_useSideBounce(){} // RVA: 0x7FFAC9986810
        public void get_surfaceArc(){} // RVA: 0x7FFAC9986870
        public void set_surfaceArc(){} // RVA: 0x7FFAC99868C0
        public void get_sideArc(){} // RVA: 0x7FFAC9986920
        public void set_sideArc(){} // RVA: 0x7FFAC9986970
        public void get_rotationalOffset(){} // RVA: 0x7FFAC99869D0
        public void set_rotationalOffset(){} // RVA: 0x7FFAC9986A20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PlayerConnectionInternal : Object
    {
        // ── Methods ──
        public void UnityEngine.IPlayerEditorConnectionNative.SendMessage(){} // RVA: 0x7FFAC98B70A0
        public void UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(){} // RVA: 0x7FFAC98B7200
        public void UnityEngine.IPlayerEditorConnectionNative.Poll(){} // RVA: 0x7FFAC98B7360
        public void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(){} // RVA: 0x7FFAC98B73B0
        public void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(){} // RVA: 0x7FFAC98B7440
        public void UnityEngine.IPlayerEditorConnectionNative.Initialize(){} // RVA: 0x7FFAC98B74D0
        public void UnityEngine.IPlayerEditorConnectionNative.IsConnected(){} // RVA: 0x7FFAC98B7520
        public void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll(){} // RVA: 0x7FFAC98B7570
        public void IsConnected(){} // RVA: 0x7FFAC98B7520
        public void Initialize(){} // RVA: 0x7FFAC98B74D0
        public void RegisterInternal(){} // RVA: 0x7FFAC98B75C0
        public void UnregisterInternal(){} // RVA: 0x7FFAC98B7610
        public void SendMessage(){} // RVA: 0x7FFAC98B7660
        public void TrySendMessage(){} // RVA: 0x7FFAC98B76D0
        public void PollInternal(){} // RVA: 0x7FFAC98B7360
        public void DisconnectAll(){} // RVA: 0x7FFAC98B7570
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PlayerPrefs : Object
    {
        // ── Methods ──
        public void TrySetInt(){} // RVA: 0x7FFAC98B77A0
        public void TrySetFloat(){} // RVA: 0x7FFAC98B7800
        public void TrySetSetString(){} // RVA: 0x7FFAC98B7860
        public void SetInt(){} // RVA: 0x7FFAC98B78C0
        public void GetInt(){} // RVA: 0x7FFAC98B79D0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAC98B7A30
        public void GetFloat(){} // RVA: 0x7FFAC98B7B40 | overloaded x2
        public void SetString(){} // RVA: 0x7FFAC98B7BA0
        public void GetString(){} // RVA: 0x7FFAC98B7CB0 | overloaded x2
        public void HasKey(){} // RVA: 0x7FFAC3F0ED20
        public void DeleteKey(){} // RVA: 0x7FFAC98B7D40
        public void DeleteAll(){} // RVA: 0x7FFAC98B7D90
        public void Save(){} // RVA: 0x7FFAC3F0EA70
    }

    public class PlayerPrefsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98B7740
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
        public void get_forceMagnitude(){} // RVA: 0x7FFAC9986030
        public void set_forceMagnitude(){} // RVA: 0x7FFAC9986080
        public void get_forceVariation(){} // RVA: 0x7FFAC99860E0
        public void set_forceVariation(){} // RVA: 0x7FFAC9986130
        public void get_distanceScale(){} // RVA: 0x7FFAC9986190
        public void set_distanceScale(){} // RVA: 0x7FFAC99861E0
        public void get_drag(){} // RVA: 0x7FFAC9986240
        public void set_drag(){} // RVA: 0x7FFAC9986290
        public void get_angularDrag(){} // RVA: 0x7FFAC99862F0
        public void set_angularDrag(){} // RVA: 0x7FFAC9986340
        public void get_forceSource(){} // RVA: 0x7FFAC99863A0
        public void set_forceSource(){} // RVA: 0x7FFAC99863F0
        public void get_forceTarget(){} // RVA: 0x7FFAC9986450
        public void set_forceTarget(){} // RVA: 0x7FFAC99864A0
        public void get_forceMode(){} // RVA: 0x7FFAC9986500
        public void set_forceMode(){} // RVA: 0x7FFAC9986550
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PolygonCollider2D : Collider2D
    {
        public object useDelaunayMesh;
        public object autoTiling;
        public object points;
        public object pathCount;

        // ── Methods ──
        public void get_useDelaunayMesh(){} // RVA: 0x7FFAC9981770
        public void set_useDelaunayMesh(){} // RVA: 0x7FFAC99817C0
        public void get_autoTiling(){} // RVA: 0x7FFAC9981820
        public void set_autoTiling(){} // RVA: 0x7FFAC9981870
        public void GetTotalPointCount(){} // RVA: 0x7FFAC99818D0
        public void get_points(){} // RVA: 0x7FFAC9981920
        public void set_points(){} // RVA: 0x7FFAC9981970
        public void get_pathCount(){} // RVA: 0x7FFAC99819D0
        public void set_pathCount(){} // RVA: 0x7FFAC9981A20
        public void GetPath(){} // RVA: 0x7FFAC9981DF0 | overloaded x2
        public void GetPath_Internal(){} // RVA: 0x7FFAC9981C30
        public void SetPath(){} // RVA: 0x7FFAC9982030 | overloaded x2
        public void SetPath_Internal(){} // RVA: 0x7FFAC9981D80
        public void GetPathList_Internal(){} // RVA: 0x7FFAC9981FC0
        public void SetPathList_Internal(){} // RVA: 0x7FFAC9982120
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Pose : ValueType
    {
        public UnityEngine.Vector3 identity; // 0x10
        public UnityEngine.Quaternion rotation; // 0x1C
        public UnityEngine.Pose k_Identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7206E60
        public void ToString(){} // RVA: 0x7FFAC98CDBC0
        public void GetTransformedBy(){} // RVA: 0x7FFAC98CDCE0
        public void get_identity(){} // RVA: 0x7FFAC98CDFE0
        public void Equals(){} // RVA: 0x7FFAC98CE120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98CE1D0
        public void .cctor(){} // RVA: 0x7FFAC98CE2B0
    }

    public class PreferBinarySerialization : Attribute
    {
    }

    public class PreloadData : Object
    {
        // ── Methods ──
        public void PreloadDataDontStripMe(){} // RVA: 0x7FFAC2F21310
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
        public void get_nearClipPlane(){} // RVA: 0x7FFAC9888DB0
        public void set_nearClipPlane(){} // RVA: 0x7FFAC9888E00
        public void get_farClipPlane(){} // RVA: 0x7FFAC9888E60
        public void set_farClipPlane(){} // RVA: 0x7FFAC9888EB0
        public void get_fieldOfView(){} // RVA: 0x7FFAC9888F10
        public void set_fieldOfView(){} // RVA: 0x7FFAC9888F60
        public void get_aspectRatio(){} // RVA: 0x7FFAC9888FC0
        public void set_aspectRatio(){} // RVA: 0x7FFAC9889010
        public void get_orthographic(){} // RVA: 0x7FFAC9889070
        public void set_orthographic(){} // RVA: 0x7FFAC98890C0
        public void get_orthographicSize(){} // RVA: 0x7FFAC9889120
        public void set_orthographicSize(){} // RVA: 0x7FFAC9889170
        public void get_ignoreLayers(){} // RVA: 0x7FFAC98891D0
        public void set_ignoreLayers(){} // RVA: 0x7FFAC9889220
        public void get_material(){} // RVA: 0x7FFAC9889280
        public void set_material(){} // RVA: 0x7FFAC98892D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PropertyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PropertyName : ValueType
    {
        public int id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x7FFAC98B7F90
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC98B7E60
        public void ToString(){} // RVA: 0x7FFAC98B8030
    }

    public class PropertyNameUtils : Object
    {
        // ── Methods ──
        public void PropertyNameFromString(){} // RVA: 0x7FFAC98B7E60
        public void PropertyNameFromString_Injected(){} // RVA: 0x7FFAC98B7EC0
    }

}