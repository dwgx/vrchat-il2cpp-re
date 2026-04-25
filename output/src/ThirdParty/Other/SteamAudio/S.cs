// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 30
// Methods: 260

namespace ThirdParty.Other.SteamAudio
{
    public class SOFAFile : ScriptableObject
    {
        public string sofaName; // 0x18
        public byte[] data; // 0x20
        public float volume; // 0x28
        public 0x6B298708 normType; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0FCC0
    }

    public class Scene : Object
    {
        public SteamAudio.Context mContext; // 0x10
        public UIntPtr mScene; // 0x18
        public int mNumObjects; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0E2D0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC8C0E3C0
        public void Release(){} // RVA: 0x7FFAC8C0E400
        public void Get(){} // RVA: 0x7FFAC2F247C0
        public void Save(){} // RVA: 0x7FFAC8C0E4D0
        public void SaveOBJ(){} // RVA: 0x7FFAC8C0E5E0
        public void NotifyAddObject(){} // RVA: 0x7FFAC8C0E690
        public void NotifyRemoveObject(){} // RVA: 0x7FFAC8C0E6A0
        public void GetNumObjects(){} // RVA: 0x7FFAC30DBBE0
        public void Commit(){} // RVA: 0x7FFAC8C0E6B0
    }

    public class SceneSettings : ValueType
    {
        public 0x6B298658 type; // 0x10
        public SteamAudio.ClosestHitCallback closestHitCallback; // 0x18
        public SteamAudio.AnyHitCallback anyHitCallback; // 0x20
        public SteamAudio.BatchedClosestHitCallback batchedClosestHitCallback; // 0x28
        public SteamAudio.BatchedAnyHitCallback batchedAnyHitCallback; // 0x30
        public UIntPtr userData; // 0x38
        public UIntPtr embreeDevice; // 0x40
        public UIntPtr radeonRaysDevice; // 0x48
    }

    public class SerializedData : ScriptableObject
    {
        public byte[] data; // 0x18

        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SerializedObject : Object
    {
        public UIntPtr mSerializedObject; // 0x10
        public UIntPtr mDataBuffer; // 0x18
        public System.Collections.Generic.List`1<SteamAudio.SerializedData> sAssetsToFlush;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0E980 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC8C0EA20
        public void Release(){} // RVA: 0x7FFAC8C0EA60
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void GetSize(){} // RVA: 0x7FFAC8C0EB40
        public void GetData(){} // RVA: 0x7FFAC8C0EBC0
        public void WriteToFile(){} // RVA: 0x7FFAC8C0EC40
        public void FlushWrite(){} // RVA: 0x7FFAC2F21310
        public void FlushAllWrites(){} // RVA: 0x7FFAC8C0EF30
    }

    public class SerializedObjectSettings : ValueType
    {
        public UIntPtr data; // 0x10
        public object size; // 0x18
    }

    public class SimulationInputs : ValueType
    {
        public 0x6B298868 flags; // 0x10
        public 0x6B2988C0 directFlags; // 0x14
        public SteamAudio.CoordinateSpace3 source; // 0x18
        public SteamAudio.DistanceAttenuationModel distanceAttenuationModel; // 0x48
        public SteamAudio.AirAbsorptionModel airAbsorptionModel; // 0x68
        public SteamAudio.Directivity directivity; // 0x90
        public 0x6B298A78 occlusionType; // 0xB8
        public float occlusionRadius; // 0xBC
        public int numOcclusionSamples; // 0xC0
        public float reverbScaleLow; // 0xC4
        public float reverbScaleMid; // 0xC8
        public float reverbScaleHigh; // 0xCC
        public float hybridReverbTransitionTime; // 0xD0
        public float hybridReverbOverlapPercent; // 0xD4
        public 0x6B298448 baked; // 0xD8
        public SteamAudio.BakedDataIdentifier bakedDataIdentifier; // 0xDC
        public UIntPtr pathingProbes; // 0xF8
        public float visRadius; // 0x100
        public float visThreshold; // 0x104
        public float visRange; // 0x108
        public int pathingOrder; // 0x10C
        public 0x6B298448 enableValidation; // 0x110
        public 0x6B298448 findAlternatePaths; // 0x114
        public int numTransmissionRays; // 0x118
        public UIntPtr deviationModel; // 0x120
    }

    public class SimulationOutputs : ValueType
    {
        public SteamAudio.DirectEffectParams direct; // 0x10
        public SteamAudio.ReflectionEffectParams reflections; // 0x48
        public SteamAudio.PathEffectParams pathing; // 0x90
    }

    public class SimulationSettings : ValueType
    {
        public 0x6B298868 flags; // 0x10
        public 0x6B298658 sceneType; // 0x14
        public 0x6B298B80 reflectionType; // 0x18
        public int maxNumOcclusionSamples; // 0x1C
        public int maxNumRays; // 0x20
        public int numDiffuseSamples; // 0x24
        public float maxDuration; // 0x28
        public int maxOrder; // 0x2C
        public int maxNumSources; // 0x30
        public int numThreads; // 0x34
        public int rayBatchSize; // 0x38
        public int numVisSamples; // 0x3C
        public int samplingRate; // 0x40
        public int frameSize; // 0x44
        public UIntPtr openCLDevice; // 0x48
        public UIntPtr radeonRaysDevice; // 0x50
        public UIntPtr tanDevice; // 0x58
    }

    public class SimulationSharedInputs : ValueType
    {
        public SteamAudio.CoordinateSpace3 listener; // 0x10
        public int numRays; // 0x40
        public int numBounces; // 0x44
        public float duration; // 0x48
        public int order; // 0x4C
        public float irradianceMinDistance; // 0x50
        public SteamAudio.PathingVisualizationCallback pathingVisualizationCallback; // 0x58
        public UIntPtr pathingUserData; // 0x60
    }

    public class Simulator : Object
    {
        public UIntPtr mSimulator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0F200 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0F2A0
        public void Release(){} // RVA: 0x7FFAC8C0F2E0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void SetScene(){} // RVA: 0x7FFAC8C0F360
        public void AddProbeBatch(){} // RVA: 0x7FFAC8C0F400
        public void RemoveProbeBatch(){} // RVA: 0x7FFAC8C0F4A0
        public void SetSharedInputs(){} // RVA: 0x7FFAC8C0F540
        public void Commit(){} // RVA: 0x7FFAC8C0F560
        public void RunDirect(){} // RVA: 0x7FFAC8C0F5E0
        public void RunReflections(){} // RVA: 0x7FFAC8C0F660
        public void RunPathing(){} // RVA: 0x7FFAC8C0F6E0
    }

    public class Source : Object
    {
        public UIntPtr mSource; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0F8C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0F960
        public void Release(){} // RVA: 0x7FFAC8C0F9A0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void AddToSimulator(){} // RVA: 0x7FFAC8C0FA20
        public void RemoveFromSimulator(){} // RVA: 0x7FFAC8C0FAC0
        public void SetInputs(){} // RVA: 0x7FFAC8C0FB60
        public void GetOutputs(){} // RVA: 0x7FFAC8C0FB80
    }

    public class SourceSettings : ValueType
    {
        public 0x6B298868 flags; // 0x10
    }

    public class Sphere : ValueType
    {
        public SteamAudio.Vector3 center; // 0x10
        public float radius; // 0x1C
    }

    public class StaticMesh : Object
    {
        public SteamAudio.Context mContext; // 0x10
        public UIntPtr mStaticMesh; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C10B20 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC8C10C10
        public void Release(){} // RVA: 0x7FFAC8C10C50
        public void Get(){} // RVA: 0x7FFAC2F247C0
        public void Save(){} // RVA: 0x7FFAC8C10D20
        public void AddToScene(){} // RVA: 0x7FFAC8C10E30
        public void RemoveFromScene(){} // RVA: 0x7FFAC8C10EE0
    }

    public class StaticMeshSettings : ValueType
    {
        public int numVertices; // 0x10
        public int numTriangles; // 0x14
        public int numMaterials; // 0x18
        public UIntPtr vertices; // 0x20
        public UIntPtr triangles; // 0x28
        public UIntPtr materialIndices; // 0x30
        public UIntPtr materials; // 0x38
    }

    public class SteamAudioAmbisonicSource : MonoBehaviour
    {
        public bool applyHRTF; // 0x20
        public SteamAudio.AudioEngineAmbisonicSource mAudioEngineAmbisonicSource; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8C17D60
        public void Start(){} // RVA: 0x7FFAC8C17EA0
        public void OnDestroy(){} // RVA: 0x7FFAC8C17ED0
        public void OnEnable(){} // RVA: 0x7FFAC8C17EA0
        public void Update(){} // RVA: 0x7FFAC8C17EA0
        public void .ctor(){} // RVA: 0x7FFAC2F7B060
    }

    public class SteamAudioBakedListener : MonoBehaviour
    {
        public float influenceRadius; // 0x20
        public bool useAllProbeBatches; // 0x24
        public SteamAudio.SteamAudioProbeBatch[] probeBatches; // 0x28
        public int mTotalDataSize; // 0x30
        public int[] mProbeDataSizes; // 0x38
        public SteamAudio.BakedDataIdentifier mIdentifier; // 0x40
        public SteamAudio.SteamAudioProbeBatch[] mProbeBatchesUsed; // 0x58

        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAC2F7CCD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFAC31D0140
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAC8C17EF0
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAC8C17F20
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAC8C17F50
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8C18070
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAC8C18640
        public void BeginBake(){} // RVA: 0x7FFAC8C187A0
        public void CacheIdentifier(){} // RVA: 0x7FFAC8C18E70
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAC8C18EA0
        public void .ctor(){} // RVA: 0x7FFAC8C18F60
    }

    public class SteamAudioBakedSource : MonoBehaviour
    {
        public float influenceRadius; // 0x20
        public bool useAllProbeBatches; // 0x24
        public SteamAudio.SteamAudioProbeBatch[] probeBatches; // 0x28
        public int mTotalDataSize; // 0x30
        public int[] mProbeDataSizes; // 0x38
        public SteamAudio.BakedDataIdentifier mIdentifier; // 0x40
        public SteamAudio.SteamAudioProbeBatch[] mProbeBatchesUsed; // 0x58

        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAC2F7CCD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFAC31D0140
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAC8C17EF0
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAC8C18FD0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAC8C19000
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8C19120
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAC8C196F0
        public void BeginBake(){} // RVA: 0x7FFAC8C19850
        public void CacheIdentifier(){} // RVA: 0x7FFAC8C19F20
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAC8C19F50
        public void .ctor(){} // RVA: 0x7FFAC8C18F60
    }

    public class SteamAudioDynamicObject : MonoBehaviour
    {
        public SteamAudio.SerializedData asset; // 0x20
        public SteamAudio.InstancedMesh mInstancedMesh; // 0x28

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFAC8C1A010
        public void OnEnable(){} // RVA: 0x7FFAC8C1A040
        public void OnDisable(){} // RVA: 0x7FFAC8C1A0F0
        public void Update(){} // RVA: 0x7FFAC8C1A210
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamAudioGeometry : MonoBehaviour
    {
        public SteamAudio.SteamAudioMaterial material; // 0x20
        public bool exportAllChildren; // 0x28
        public int terrainSimplificationLevel; // 0x2C

        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x7FFAC8C1A710
        public void GetNumTriangles(){} // RVA: 0x7FFAC8C1A910
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamAudioListener : MonoBehaviour
    {
        public SteamAudio.SteamAudioBakedListener currentBakedListener; // 0x20
        public bool applyReverb; // 0x28
        public 0x6B29A338 reverbType; // 0x2C
        public bool useAllProbeBatches; // 0x30
        public SteamAudio.SteamAudioProbeBatch[] probeBatches; // 0x38
        public int mTotalDataSize; // 0x40
        public int[] mProbeDataSizes; // 0x48
        public SteamAudio.BakedDataIdentifier mIdentifier; // 0x50
        public SteamAudio.SteamAudioProbeBatch[] mProbeBatchesUsed; // 0x68
        public SteamAudio.Simulator mSimulator; // 0x70
        public SteamAudio.Source mSource; // 0x78

        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAC2FC2080
        public void GetProbeDataSizes(){} // RVA: 0x7FFAC2F9C730
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAC8C1AB10
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAC8C1AB40
        public void Awake(){} // RVA: 0x7FFAC8C1AB70
        public void Reinitialize(){} // RVA: 0x7FFAC8C1AB80
        public void OnDestroy(){} // RVA: 0x7FFAC8C1AE20
        public void Start(){} // RVA: 0x7FFAC8C1AE40
        public void OnEnable(){} // RVA: 0x7FFAC8C1AEB0
        public void OnDisable(){} // RVA: 0x7FFAC8C1B050
        public void Update(){} // RVA: 0x7FFAC8C1AE40
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAC8C1B1E0
        public void SetInputs(){} // RVA: 0x7FFAC8C1B210
        public void UpdateOutputs(){} // RVA: 0x7FFAC2F21310
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8C1B6B0
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAC8C1BB20
        public void BeginBake(){} // RVA: 0x7FFAC8C1BC80
        public void CacheIdentifier(){} // RVA: 0x7FFAC8C1C330
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAC8C1C340
        public void .ctor(){} // RVA: 0x7FFAC8C1C400
    }

    public class SteamAudioManager : MonoBehaviour
    {
        public int Singleton; // 0x20
        public string[] Context; // 0x28
        public int CurrentHRTF; // 0x30
        public SteamAudio.AudioSettings EmbreeDevice; // 0x34
        public SteamAudio.Context OpenCLDevice; // 0x40
        public SteamAudio.HRTF[] RadeonRaysDevice; // 0x48
        public SteamAudio.EmbreeDevice TrueAudioNextDevice; // 0x50
        public bool CurrentScene; // 0x58
        public SteamAudio.OpenCLDevice Simulator; // 0x60
        public bool AudioSettings; // 0x68
        public SteamAudio.RadeonRaysDevice mRadeonRaysDevice; // 0x70
        public bool mRadeonRaysInitFailed; // 0x78
        public SteamAudio.TrueAudioNextDevice mTrueAudioNextDevice; // 0x80
        public bool mTrueAudioNextInitFailed; // 0x88
        public SteamAudio.Scene mCurrentScene; // 0x90
        public System.Collections.Generic.Dictionary`2<string,int> mDynamicObjectRefCounts; // 0x98
        public System.Collections.Generic.Dictionary`2<string,SteamAudio.Scene> mDynamicObjects; // 0xA0
        public SteamAudio.Simulator mSimulator; // 0xA8
        public SteamAudio.AudioEngineState mAudioEngineState; // 0xB0
        public UnityEngine.Transform mListener; // 0xB8
        public SteamAudio.SteamAudioListener mListenerComponent; // 0xC0
        public System.Collections.Generic.HashSet`1<SteamAudio.SteamAudioSource> mSources; // 0xC8
        public System.Collections.Generic.HashSet`1<SteamAudio.SteamAudioListener> mListeners; // 0xD0
        public UnityEngine.RaycastHit[] mRayHits; // 0xD8
        public UIntPtr mMaterialBuffer; // 0xE0
        public System.Threading.Thread mSimulationThread; // 0xE8
        public System.Threading.EventWaitHandle mSimulationThreadWaitHandle; // 0xF0
        public bool mStopSimulationThread; // 0xF8
        public bool mSimulationCompleted; // 0xF9
        public float mSimulationUpdateTimeElapsed; // 0xFC
        public bool mSceneCommitRequired; // 0x100
        public UnityEngine.Camera mMainCamera; // 0x108
        public bool hasGeometryComponentsInScene; // 0x110
        public SteamAudio.SteamAudioManager sSingleton;
        public bool isShuttingDown; // 0x8
        public bool firstLoadComplete; // 0x9

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFAC8C1C460
        public void get_Context(){} // RVA: 0x7FFAC8C1C4A0
        public void get_CurrentHRTF(){} // RVA: 0x7FFAC8C1C4F0
        public void get_EmbreeDevice(){} // RVA: 0x7FFAC8C1C560
        public void get_OpenCLDevice(){} // RVA: 0x7FFAC8C1C5C0
        public void get_RadeonRaysDevice(){} // RVA: 0x7FFAC8C1C620
        public void get_TrueAudioNextDevice(){} // RVA: 0x7FFAC8C1C680
        public void get_CurrentScene(){} // RVA: 0x7FFAC8C1C6E0
        public void get_Simulator(){} // RVA: 0x7FFAC8C1C730
        public void get_AudioSettings(){} // RVA: 0x7FFAC8C1C780
        public void GetAudioEngineState(){} // RVA: 0x7FFAC8C1C7D0
        public void GetSteamAudioListener(){} // RVA: 0x7FFAC8C1C820
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x7FFAC8C1C940
        public void GetSceneType(){} // RVA: 0x7FFAC8C1C970
        public void GetReflectionEffectType(){} // RVA: 0x7FFAC8C1CA10
        public void GetPerspectiveCorrection(){} // RVA: 0x7FFAC8C1CA80
        public void GetMainCamera(){} // RVA: 0x7FFAC36D1F40
        public void GetSimulationSettings(){} // RVA: 0x7FFAC8C1CFB0
        public void OnApplicationStart(){} // RVA: 0x7FFAC8C1D3E0
        public void LoadHRTFFromFile(){} // RVA: 0x7FFAC8C1E200
        public void UnloadHRTFByName(){} // RVA: 0x7FFAC8C1E3D0
        public void SetHRTFAtIndex(){} // RVA: 0x7FFAC8C1E6F0
        public void OnApplicationQuit(){} // RVA: 0x7FFAC8C1E7D0
        public void OnSceneLoaded(){} // RVA: 0x7FFAC8C1E820
        public void OnSceneUnloaded(){} // RVA: 0x7FFAC8C1E980
        public void NotifyAudioListenerChanged(){} // RVA: 0x7FFAC8C1E990
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x7FFAC8C1E9E0
        public void NotifyMainCameraChanged(){} // RVA: 0x7FFAC8C1EC00
        public void ScheduleCommitScene(){} // RVA: 0x7FFAC8C1ECA0
        public void LateUpdate(){} // RVA: 0x7FFAC8C1ECF0
        public void RunSimulationInternal(){} // RVA: 0x7FFAC8C1FD80
        public void RunSimulation(){} // RVA: 0x7FFAC8C1FEA0
        public void Initialize(){} // RVA: 0x7FFAC8C1FF00
        public void ShutDown(){} // RVA: 0x7FFAC8C200A0
        public void Reinitialize(){} // RVA: 0x7FFAC8C207D0
        public void AddSource(){} // RVA: 0x7FFAC8C218D0
        public void RemoveSource(){} // RVA: 0x7FFAC8C21960
        public void AddListener(){} // RVA: 0x7FFAC8C219E0
        public void RemoveListener(){} // RVA: 0x7FFAC8C21A70
        public void ExportDynamicObject(){} // RVA: 0x7FFAC8C21AF0
        public void ExportDynamicObjectsInArray(){} // RVA: 0x7FFAC8C21DD0
        public void GetDynamicObjectsInScene(){} // RVA: 0x7FFAC8C220A0
        public void LoadScene(){} // RVA: 0x7FFAC8C22200
        public void LoadDynamicObject(){} // RVA: 0x7FFAC8C222C0
        public void UnloadDynamicObject(){} // RVA: 0x7FFAC8C22890
        public void GetGameObjectsForExport(){} // RVA: 0x7FFAC8C22AA0
        public void GetNumVertices(){} // RVA: 0x7FFAC8C23290
        public void GetNumTriangles(){} // RVA: 0x7FFAC8C237C0
        public void ClosestHit(){} // RVA: 0x7FFAC8C23D00
        public void AnyHit(){} // RVA: 0x7FFAC8C24070
        public void AutoInitialize(){} // RVA: 0x7FFAC8C24290
        public void FirstAutoInitialize(){} // RVA: 0x7FFAC8C242E0
        public void ExportScene(){} // RVA: 0x7FFAC8C24340
        public void Export(){} // RVA: 0x7FFAC8C246F0
        public void CreateScene(){} // RVA: 0x7FFAC8C24BC0
        public void Load(){} // RVA: 0x7FFAC8C24FE0
        public void RemoveAllDynamicObjects(){} // RVA: 0x7FFAC8C25060
        public void RemoveAllAdditiveScenes(){} // RVA: 0x7FFAC8C255F0
        public void GetMaterialBufferForTransform(){} // RVA: 0x7FFAC8C25720
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFAC8C25A80
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x7FFAC8C25BA0
        public void IsDynamicSubObject(){} // RVA: 0x7FFAC8C25C40
        public void IsActiveInHierarchy(){} // RVA: 0x7FFAC8C25E00
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x7FFAC8C25FD0
        public void GetDynamicObjectInParent(){} // RVA: 0x7FFAC8C265E0
        public void GetVertices(){} // RVA: 0x7FFAC8C26820
        public void GetTriangles(){} // RVA: 0x7FFAC8C27680
        public void FixupTriangleIndices(){} // RVA: 0x7FFAC8C27D40
        public void GetTerrainSimplificationLevel(){} // RVA: 0x7FFAC8C27DB0
        public void GetMaterialMapping(){} // RVA: 0x7FFAC8C27E10
        public void GetMaterialForGameObject(){} // RVA: 0x7FFAC8C28670
        public void GetOBJFileName(){} // RVA: 0x7FFAC8C28AF0 | overloaded x2
        public void GetDataAsset(){} // RVA: 0x7FFAC8C28FC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8C28FE0
    }

    public class SteamAudioMaterial : ScriptableObject
    {
        public float lowFreqAbsorption; // 0x18
        public float midFreqAbsorption; // 0x1C
        public float highFreqAbsorption; // 0x20
        public float scattering; // 0x24
        public float lowFreqTransmission; // 0x28
        public float midFreqTransmission; // 0x2C
        public float highFreqTransmission; // 0x30

        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x7FFAC8C29320
        public void .ctor(){} // RVA: 0x7FFAC8C29360
    }

    public class SteamAudioProbeBatch : MonoBehaviour
    {
        public 0x6B298760 placementStrategy; // 0x20
        public float horizontalSpacing; // 0x24
        public float heightAboveFloor; // 0x28
        public SteamAudio.SerializedData asset; // 0x30
        public int probeDataSize; // 0x38
        public SteamAudio.Sphere[] mProbeSpheres; // 0x40
        public System.Collections.Generic.List`1<SteamAudio.BakedDataLayerInfo> mBakedDataLayerInfo; // 0x48
        public SteamAudio.ProbeBatch mProbeBatch; // 0x50
        public float kProbeDrawSize;

        // ── Methods ──
        public void GetAsset(){} // RVA: 0x7FFAC8C293A0
        public void GetNumProbes(){} // RVA: 0x7FFAC8C295A0
        public void GetNumLayers(){} // RVA: 0x7FFAC8C295C0
        public void GetProbeBatch(){} // RVA: 0x7FFAC8C29610
        public void Awake(){} // RVA: 0x7FFAC8C29630
        public void OnDestroy(){} // RVA: 0x7FFAC8C297F0
        public void OnEnable(){} // RVA: 0x7FFAC8C29810
        public void OnDisable(){} // RVA: 0x7FFAC8C29900
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8C29A30
        public void GenerateProbes(){} // RVA: 0x7FFAC8C29F10
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x7FFAC8C2ACB0
        public void GetSizeForLayer(){} // RVA: 0x7FFAC8C2B150
        public void GetInfoForLayer(){} // RVA: 0x7FFAC8C2B300
        public void ResetLayers(){} // RVA: 0x7FFAC8C2B3A0
        public void AddLayer(){} // RVA: 0x7FFAC8C2B410
        public void RemoveLayer(){} // RVA: 0x7FFAC8C2B540
        public void AddOrUpdateLayer(){} // RVA: 0x7FFAC8C2B770
        public void UpdateGameObjectStatistics(){} // RVA: 0x7FFAC8C2BA50
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAC8C2BB40
        public void BeginBake(){} // RVA: 0x7FFAC8C2BB80
        public void .ctor(){} // RVA: 0x7FFAC8C2C110
    }

    public class SteamAudioReverbData : ScriptableObject
    {
        public float[] reverbTimes; // 0x18
        public float[] reverbEnergyField; // 0x20
        public int reverbEnergyFieldNumChannels; // 0x28
        public int reverbEnergyFieldNumBands; // 0x2C
        public int reverbEnergyFieldNumBins; // 0x30
        public float[] reverbIR; // 0x38
        public int reverbIRNumChannels; // 0x40
        public int reverbIRNumSamples; // 0x44

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC8C2C210
        public void GetImpulseResponseSize(){} // RVA: 0x7FFAC8C2C370
        public void GetEnergyFieldData(){} // RVA: 0x7FFAC8C2C390
        public void GetEnergyFieldSize(){} // RVA: 0x7FFAC8C2C3D0
        public void GetImpulseResponseData(){} // RVA: 0x7FFAC8C2C3F0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SteamAudioReverbDataPoint : MonoBehaviour
    {
        public int sampleRate; // 0x20
        public int ambisonicOrder; // 0x24
        public float reverbDuration; // 0x28
        public bool storeEnergyField; // 0x2C
        public bool storeImpulseResponse; // 0x2D
        public SteamAudio.SteamAudioReverbData reverbData; // 0x30
        public System.Collections.Generic.List`1<SteamAudio.SteamAudioReverbData> sAssetsToFlush;

        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x7FFAC2F21310
        public void GetAssetFolderPath(){} // RVA: 0x7FFAC8C2C430
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAC8C1B1E0
        public void EnsureValidData(){} // RVA: 0x7FFAC2F21310
        public void BeginBake(){} // RVA: 0x7FFAC8C2C470
        public void UpdateEnergyField(){} // RVA: 0x7FFAC8C2CBE0
        public void UpdateImpulseResponse(){} // RVA: 0x7FFAC8C2CFC0
        public void WriteReverbDataToFile(){} // RVA: 0x7FFAC8C2D360
        public void FlushWrite(){} // RVA: 0x7FFAC2F21310
        public void FlushAllWrites(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC8C2D4F0
    }

    public class SteamAudioSettings : ScriptableObject
    {
        public 0x6B29A650 Singleton; // 0x18
        public bool hrtfDisabled; // 0x1C
        public bool perspectiveCorrection; // 0x1D
        public float perspectiveCorrectionFactor; // 0x20
        public float hrtfVolumeGainDB; // 0x24
        public 0x6B298708 hrtfNormalizationType; // 0x28
        public SteamAudio.SOFAFile[] SOFAFiles; // 0x30
        public SteamAudio.SteamAudioMaterial defaultMaterial; // 0x38
        public 0x6B298658 sceneType; // 0x40
        public UnityEngine.LayerMask layerMask; // 0x44
        public int maxOcclusionSamples; // 0x48
        public int realTimeRays; // 0x4C
        public int realTimeBounces; // 0x50
        public float realTimeDuration; // 0x54
        public int realTimeAmbisonicOrder; // 0x58
        public int realTimeMaxSources; // 0x5C
        public int realTimeCPUCoresPercentage; // 0x60
        public float realTimeIrradianceMinDistance; // 0x64
        public bool bakeConvolution; // 0x68
        public bool bakeParametric; // 0x69
        public int bakingRays; // 0x6C
        public int bakingBounces; // 0x70
        public float bakingDuration; // 0x74
        public int bakingAmbisonicOrder; // 0x78
        public int bakingCPUCoresPercentage; // 0x7C
        public float bakingIrradianceMinDistance; // 0x80
        public int bakingVisibilitySamples; // 0x84
        public float bakingVisibilityRadius; // 0x88
        public float bakingVisibilityThreshold; // 0x8C
        public float bakingVisibilityRange; // 0x90
        public float bakingPathRange; // 0x94
        public int bakedPathingCPUCoresPercentage; // 0x98
        public float simulationUpdateInterval; // 0x9C
        public 0x6B298B80 reflectionEffectType; // 0xA0
        public float hybridReverbTransitionTime; // 0xA4
        public int hybridReverbOverlapPercent; // 0xA8
        public 0x6B298600 deviceType; // 0xAC
        public int maxReservedComputeUnits; // 0xB0
        public float fractionComputeUnitsForIRUpdate; // 0xB4
        public int bakingBatchSize; // 0xB8
        public float TANDuration; // 0xBC
        public int TANAmbisonicOrder; // 0xC0
        public int TANMaxSources; // 0xC4
        public bool EnableValidation; // 0xC8
        public SteamAudio.SteamAudioSettings sSingleton;

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFAC8C2D590
        public void .ctor(){} // RVA: 0x7FFAC8C2D890
    }

    public class SteamAudioSource : MonoBehaviour
    {
        public bool interpolation; // 0x20
        public bool perspectiveCorrection; // 0x21
        public bool distanceAttenuation; // 0x22
        public 0x6B29A700 distanceAttenuationInput; // 0x24
        public float distanceAttenuationValue; // 0x28
        public bool airAbsorption; // 0x2C
        public 0x6B29A758 airAbsorptionInput; // 0x30
        public float airAbsorptionLow; // 0x34
        public float airAbsorptionMid; // 0x38
        public float airAbsorptionHigh; // 0x3C
        public bool distanceAttenuationIgnoreBlend; // 0x40
        public float preGainRaw; // 0x44
        public float preGainSpatial; // 0x48
        public float volumetricRadius; // 0x4C
        public bool directivity; // 0x50
        public 0x6B29A7B0 directivityInput; // 0x54
        public float dipoleWeightLow; // 0x58
        public float dipoleWeightMid; // 0x5C
        public float dipoleWeightHigh; // 0x60
        public float dipolePowerLow; // 0x64
        public float dipolePowerMid; // 0x68
        public float dipolePowerHigh; // 0x6C
        public float directivityValueLow; // 0x70
        public float directivityValueMid; // 0x74
        public float directivityValueHigh; // 0x78
        public bool occlusion; // 0x7C
        public 0x6B29A808 occlusionInput; // 0x80
        public 0x6B298A78 occlusionType; // 0x84
        public float occlusionRadius; // 0x88
        public int occlusionSamples; // 0x8C
        public float occlusionValue; // 0x90
        public bool transmission; // 0x94
        public 0x6B298B28 transmissionType; // 0x98
        public 0x6B29A860 transmissionInput; // 0x9C
        public float transmissionLow; // 0xA0
        public float transmissionMid; // 0xA4
        public float transmissionHigh; // 0xA8
        public int maxTransmissionSurfaces; // 0xAC
        public float directMixLevel; // 0xB0
        public bool reflections; // 0xB4
        public 0x6B29A8B8 reflectionsType; // 0xB8
        public bool useDistanceCurveForReflections; // 0xBC
        public SteamAudio.SteamAudioBakedSource currentBakedSource; // 0xC0
        public UIntPtr reflectionsIR; // 0xC8
        public float reverbTimeLow; // 0xD0
        public float reverbTimeMid; // 0xD4
        public float reverbTimeHigh; // 0xD8
        public float hybridReverbEQLow; // 0xDC
        public float hybridReverbEQMid; // 0xE0
        public float hybridReverbEQHigh; // 0xE4
        public int hybridReverbDelay; // 0xE8
        public bool applyHRTFToReflections; // 0xEC
        public float reflectionsMixLevel; // 0xF0
        public bool pathing; // 0xF4
        public SteamAudio.SteamAudioProbeBatch pathingProbeBatch; // 0xF8
        public bool pathValidation; // 0x100
        public bool findAlternatePaths; // 0x101
        public float[] pathingEQ; // 0x108
        public float[] pathingSH; // 0x110
        public bool applyHRTFToPathing; // 0x118
        public float pathingMixLevel; // 0x11C
        public bool normalizePathingEQ; // 0x120
        public SteamAudio.Simulator mSimulator; // 0x128
        public SteamAudio.Source mSource; // 0x130
        public SteamAudio.AudioEngineSource mAudioEngineSource; // 0x138
        public UnityEngine.Vector3[] mSphereVertices; // 0x140
        public UnityEngine.Vector3[] mDeformedSphereVertices; // 0x148
        public UnityEngine.Mesh mDeformedSphereMeshLow; // 0x150
        public UnityEngine.Mesh mDeformedSphereMeshMid; // 0x158
        public UnityEngine.Mesh mDeformedSphereMeshHigh; // 0x160
        public UnityEngine.AudioSource mAudioSource; // 0x168
        public SteamAudio.AudioSourceAttenuationData mAttenuationData; // 0x170
        public SteamAudio.DistanceAttenuationModel mCurveAttenuationModel; // 0x188
        public SteamAudio.SteamAudioSettings mSettings; // 0x1A8
        public UIntPtr mThisHandle; // 0x1B0
        public System.Collections.Concurrent.ConcurrentDictionary`2<UIntPtr,SteamAudio.SteamAudioSource> sSourceMap;
        public UIntPtr sNextSourceID; // 0x8
        public bool initializedSource; // 0x1B8
        public bool sourceAddedToSimulator; // 0x1B9

        // ── Methods ──
        public void get_interpolation(){} // RVA: 0x7FFAC3013AF0
        public void Awake(){} // RVA: 0x7FFAC8C2D9B0
        public void LazyInitSource(){} // RVA: 0x7FFAC8C2DC80
        public void AssignHandle(){} // RVA: 0x7FFAC8C2DF40
        public void SetAttenuationModel(){} // RVA: 0x7FFAC8C2E1D0
        public void UpdateParameters(){} // RVA: 0x7FFAC8C2E5F0
        public void Start(){} // RVA: 0x7FFAC8C2E620
        public void OnDestroy(){} // RVA: 0x7FFAC8C2E650
        public void OnEnable(){} // RVA: 0x7FFAC8C2E820
        public void OnDisable(){} // RVA: 0x7FFAC8C2E910
        public void LateUpdate(){} // RVA: 0x7FFAC8C2E5F0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8C2EA40
        public void SetInputs(){} // RVA: 0x7FFAC8C2F160
        public void GetOutputs(){} // RVA: 0x7FFAC8C2FFA0
        public void GetSource(){} // RVA: 0x7FFAC3544340
        public void UpdateOutputs(){} // RVA: 0x7FFAC8C300F0
        public void InitializeDeformedSphereMesh(){} // RVA: 0x7FFAC8C302B0
        public void DeformSphereMesh(){} // RVA: 0x7FFAC8C30B40
        public void DeformedVertex(){} // RVA: 0x7FFAC8C30FA0
        public void EvaluateDistanceCurve(){} // RVA: 0x7FFAC8C31020
        public void .ctor(){} // RVA: 0x7FFAC8C31180
        public void .cctor(){} // RVA: 0x7FFAC8C314B0
    }

    public class SteamAudioStaticMesh : MonoBehaviour
    {
        public SteamAudio.SerializedData asset; // 0x20
        public string sceneNameWhenExported; // 0x28
        public SteamAudio.StaticMesh mStaticMesh; // 0x30
        public System.Threading.Tasks.Task`1<SteamAudio.StaticMesh> mTask; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8C31640
        public void OnDestroy(){} // RVA: 0x7FFAC8C31870
        public void OnEnable(){} // RVA: 0x7FFAC8C31A30
        public void OnDisable(){} // RVA: 0x7FFAC8C31AE0
        public void Update(){} // RVA: 0x7FFAC8C31C00
        public void .ctor(){} // RVA: 0x7FFAC8C31E40
        public void <Update>b__8_0(){} // RVA: 0x7FFAC8C31F10
    }

}