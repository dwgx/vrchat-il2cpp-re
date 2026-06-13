// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 28
// Methods: 251

namespace ThirdParty.Other.SteamAudio
{
    public class SOFAFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6479130
    }

    public class Scene
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6477740 | overloaded x3
        public void Finalize(){} // RVA: 0x6477830
        public void Release(){} // RVA: 0x6477870
        public void Get(){} // RVA: 0x2E07C0
        public void Save(){} // RVA: 0x6477940
        public void SaveOBJ(){} // RVA: 0x6477A50
        public void NotifyAddObject(){} // RVA: 0x6477B00
        public void NotifyRemoveObject(){} // RVA: 0x6477B10
        public void GetNumObjects(){} // RVA: 0x760030
        public void Commit(){} // RVA: 0x6477B20
    }

    public class SceneSettings
    {
    }

    public class SerializedData
    {
        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SerializedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6477DF0 | overloaded x3
        public void Finalize(){} // RVA: 0x6477E90
        public void Release(){} // RVA: 0x6477ED0
        public void Get(){} // RVA: 0x2F8380
        public void GetSize(){} // RVA: 0x6477FB0
        public void GetData(){} // RVA: 0x6478030
        public void WriteToFile(){} // RVA: 0x64780B0
        public void FlushWrite(){} // RVA: 0x2DD310
        public void FlushAllWrites(){} // RVA: 0x64783A0
    }

    public class SerializedObjectSettings
    {
    }

    public class SimulationInputs
    {
    }

    public class SimulationOutputs
    {
    }

    public class SimulationSettings
    {
    }

    public class SimulationSharedInputs
    {
    }

    public class Simulator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6478670 | overloaded x2
        public void Finalize(){} // RVA: 0x6478710
        public void Release(){} // RVA: 0x6478750
        public void Get(){} // RVA: 0x2F8380
        public void SetScene(){} // RVA: 0x64787D0
        public void AddProbeBatch(){} // RVA: 0x6478870
        public void RemoveProbeBatch(){} // RVA: 0x6478910
        public void SetSharedInputs(){} // RVA: 0x64789B0
        public void Commit(){} // RVA: 0x64789D0
        public void RunDirect(){} // RVA: 0x6478A50
        public void RunReflections(){} // RVA: 0x6478AD0
        public void RunPathing(){} // RVA: 0x6478B50
    }

    public class Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6478D30 | overloaded x2
        public void Finalize(){} // RVA: 0x6478DD0
        public void Release(){} // RVA: 0x6478E10
        public void Get(){} // RVA: 0x2F8380
        public void AddToSimulator(){} // RVA: 0x6478E90
        public void RemoveFromSimulator(){} // RVA: 0x6478F30
        public void SetInputs(){} // RVA: 0x6478FD0
        public void GetOutputs(){} // RVA: 0x6478FF0
    }

    public class SourceSettings
    {
    }

    public class Sphere
    {
    }

    public class SteamAudioAmbisonicSource
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x64811D0
        public void Start(){} // RVA: 0x6481310
        public void OnDestroy(){} // RVA: 0x6481340
        public void OnEnable(){} // RVA: 0x6481310
        public void Update(){} // RVA: 0x6481310
        public void .ctor(){} // RVA: 0x337060
    }

    public class SteamAudioBakedListener
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x338CD0
        public void GetProbeDataSizes(){} // RVA: 0x4976A0
        public void GetSizeForProbeBatch(){} // RVA: 0x6481360
        public void GetProbeBatchesUsed(){} // RVA: 0x6481390
        public void GetBakedDataIdentifier(){} // RVA: 0x64813C0
        public void OnDrawGizmosSelected(){} // RVA: 0x64814E0
        public void UpdateBakedDataStatistics(){} // RVA: 0x6481AB0
        public void BeginBake(){} // RVA: 0x6481C10
        public void CacheIdentifier(){} // RVA: 0x64822E0
        public void CacheProbeBatchesUsed(){} // RVA: 0x6482310
        public void .ctor(){} // RVA: 0x64823D0
    }

    public class SteamAudioBakedSource
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x338CD0
        public void GetProbeDataSizes(){} // RVA: 0x4976A0
        public void GetSizeForProbeBatch(){} // RVA: 0x6481360
        public void GetProbeBatchesUsed(){} // RVA: 0x6482440
        public void GetBakedDataIdentifier(){} // RVA: 0x6482470
        public void OnDrawGizmosSelected(){} // RVA: 0x6482590
        public void UpdateBakedDataStatistics(){} // RVA: 0x6482B60
        public void BeginBake(){} // RVA: 0x6482CC0
        public void CacheIdentifier(){} // RVA: 0x6483390
        public void CacheProbeBatchesUsed(){} // RVA: 0x64833C0
        public void .ctor(){} // RVA: 0x64823D0
    }

    public class SteamAudioDynamicObject
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x6483480
        public void OnEnable(){} // RVA: 0x64834B0
        public void OnDisable(){} // RVA: 0x6483560
        public void Update(){} // RVA: 0x6483680
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamAudioGeometry
    {
        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x6483B80
        public void GetNumTriangles(){} // RVA: 0x6483D80
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamAudioListener
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x37E080
        public void GetProbeDataSizes(){} // RVA: 0x358730
        public void GetSizeForProbeBatch(){} // RVA: 0x6483F80
        public void GetProbeBatchesUsed(){} // RVA: 0x6483FB0
        public void Awake(){} // RVA: 0x6483FE0
        public void Reinitialize(){} // RVA: 0x6483FF0
        public void OnDestroy(){} // RVA: 0x6484290
        public void Start(){} // RVA: 0x64842B0
        public void OnEnable(){} // RVA: 0x6484320
        public void OnDisable(){} // RVA: 0x64844C0
        public void Update(){} // RVA: 0x64842B0
        public void GetBakedDataIdentifier(){} // RVA: 0x6484650
        public void SetInputs(){} // RVA: 0x6484680
        public void UpdateOutputs(){} // RVA: 0x2DD310
        public void OnDrawGizmosSelected(){} // RVA: 0x6484B20
        public void UpdateBakedDataStatistics(){} // RVA: 0x6484F90
        public void BeginBake(){} // RVA: 0x64850F0
        public void CacheIdentifier(){} // RVA: 0x64857A0
        public void CacheProbeBatchesUsed(){} // RVA: 0x64857B0
        public void .ctor(){} // RVA: 0x6485870
    }

    public class SteamAudioManager
    {
        public int _singleton; // 0x20
        public string[] hrtfNames; // 0x28
        public int mNumCPUCores; // 0x30
        public SteamAudio.AudioSettings mAudioSettings; // 0x34
        public SteamAudio.Context mContext; // 0x40
        public SteamAudio.HRTF[] mHRTFs; // 0x48
        public SteamAudio.EmbreeDevice mEmbreeDevice; // 0x50
        public bool mEmbreeInitFailed; // 0x58
        public SteamAudio.OpenCLDevice mOpenCLDevice; // 0x60
        public bool mOpenCLInitFailed; // 0x68

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x64858D0
        public void get_Context(){} // RVA: 0x6485910
        public void get_CurrentHRTF(){} // RVA: 0x6485960
        public void get_EmbreeDevice(){} // RVA: 0x64859D0
        public void get_OpenCLDevice(){} // RVA: 0x6485A30
        public void get_RadeonRaysDevice(){} // RVA: 0x6485A90
        public void get_TrueAudioNextDevice(){} // RVA: 0x6485AF0
        public void get_CurrentScene(){} // RVA: 0x6485B50
        public void get_Simulator(){} // RVA: 0x6485BA0
        public void get_AudioSettings(){} // RVA: 0x6485BF0
        public void GetAudioEngineState(){} // RVA: 0x6485C40
        public void GetSteamAudioListener(){} // RVA: 0x6485C90
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x6485DB0
        public void GetSceneType(){} // RVA: 0x6485DE0
        public void GetReflectionEffectType(){} // RVA: 0x6485E80
        public void GetPerspectiveCorrection(){} // RVA: 0x6485EF0
        public void GetMainCamera(){} // RVA: 0xA902E0
        public void GetSimulationSettings(){} // RVA: 0x6486420
        public void OnApplicationStart(){} // RVA: 0x6486850
        public void LoadHRTFFromFile(){} // RVA: 0x6487670
        public void UnloadHRTFByName(){} // RVA: 0x6487840
        public void SetHRTFAtIndex(){} // RVA: 0x6487B60
        public void OnApplicationQuit(){} // RVA: 0x6487C40
        public void OnSceneLoaded(){} // RVA: 0x6487C90
        public void OnSceneUnloaded(){} // RVA: 0x6487DF0
        public void NotifyAudioListenerChanged(){} // RVA: 0x6487E00
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x6487E50
        public void NotifyMainCameraChanged(){} // RVA: 0x6488070
        public void ScheduleCommitScene(){} // RVA: 0x6488110
        public void LateUpdate(){} // RVA: 0x6488160
        public void RunSimulationInternal(){} // RVA: 0x64891F0
        public void RunSimulation(){} // RVA: 0x6489310
        public void Initialize(){} // RVA: 0x6489370
        public void ShutDown(){} // RVA: 0x6489510
        public void Reinitialize(){} // RVA: 0x6489C40
        public void AddSource(){} // RVA: 0x648AD40
        public void RemoveSource(){} // RVA: 0x648ADD0
        public void AddListener(){} // RVA: 0x648AE50
        public void RemoveListener(){} // RVA: 0x648AEE0
        public void ExportDynamicObject(){} // RVA: 0x648AF60
        public void ExportDynamicObjectsInArray(){} // RVA: 0x648B240
        public void GetDynamicObjectsInScene(){} // RVA: 0x648B510
        public void LoadScene(){} // RVA: 0x648B670
        public void LoadDynamicObject(){} // RVA: 0x648B730
        public void UnloadDynamicObject(){} // RVA: 0x648BD00
        public void GetGameObjectsForExport(){} // RVA: 0x648BF10
        public void GetNumVertices(){} // RVA: 0x648C700
        public void GetNumTriangles(){} // RVA: 0x648CC30
        public void ClosestHit(){} // RVA: 0x648D170
        public void AnyHit(){} // RVA: 0x648D4E0
        public void AutoInitialize(){} // RVA: 0x648D700
        public void FirstAutoInitialize(){} // RVA: 0x648D750
        public void ExportScene(){} // RVA: 0x648D7B0
        public void Export(){} // RVA: 0x648DB60
        public void CreateScene(){} // RVA: 0x648E030
        public void Load(){} // RVA: 0x648E450
        public void RemoveAllDynamicObjects(){} // RVA: 0x648E4D0
        public void RemoveAllAdditiveScenes(){} // RVA: 0x648EA60
        public void GetMaterialBufferForTransform(){} // RVA: 0x648EB90
        public void GetStaticGameObjectsForExport(){} // RVA: 0x648EEF0
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x648F010
        public void IsDynamicSubObject(){} // RVA: 0x648F0B0
        public void IsActiveInHierarchy(){} // RVA: 0x648F270
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x648F440
        public void GetDynamicObjectInParent(){} // RVA: 0x648FA50
        public void GetVertices(){} // RVA: 0x648FC90
        public void GetTriangles(){} // RVA: 0x6490AF0
        public void FixupTriangleIndices(){} // RVA: 0x64911B0
        public void GetTerrainSimplificationLevel(){} // RVA: 0x6491220
        public void GetMaterialMapping(){} // RVA: 0x6491280
        public void GetMaterialForGameObject(){} // RVA: 0x6491AE0
        public void GetOBJFileName(){} // RVA: 0x6491F60 | overloaded x2
        public void GetDataAsset(){} // RVA: 0x6492430 | overloaded x2
        public void .ctor(){} // RVA: 0x6492450
    }

    public class SteamAudioMaterial
    {
        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x6492790
        public void .ctor(){} // RVA: 0x64927D0
    }

    public class SteamAudioProbeBatch
    {
        // ── Methods ──
        public void GetAsset(){} // RVA: 0x6492810
        public void GetNumProbes(){} // RVA: 0x6492A10
        public void GetNumLayers(){} // RVA: 0x6492A30
        public void GetProbeBatch(){} // RVA: 0x6492A80
        public void Awake(){} // RVA: 0x6492AA0
        public void OnDestroy(){} // RVA: 0x6492C60
        public void OnEnable(){} // RVA: 0x6492C80
        public void OnDisable(){} // RVA: 0x6492D70
        public void OnDrawGizmosSelected(){} // RVA: 0x6492EA0
        public void GenerateProbes(){} // RVA: 0x6493380
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x6494120
        public void GetSizeForLayer(){} // RVA: 0x64945C0
        public void GetInfoForLayer(){} // RVA: 0x6494770
        public void ResetLayers(){} // RVA: 0x6494810
        public void AddLayer(){} // RVA: 0x6494880
        public void RemoveLayer(){} // RVA: 0x64949B0
        public void AddOrUpdateLayer(){} // RVA: 0x6494BE0
        public void UpdateGameObjectStatistics(){} // RVA: 0x6494EC0
        public void GetBakedDataIdentifier(){} // RVA: 0x6494FB0
        public void BeginBake(){} // RVA: 0x6494FF0
        public void .ctor(){} // RVA: 0x6495580
    }

    public class SteamAudioReverbData
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6495680
        public void GetImpulseResponseSize(){} // RVA: 0x64957E0
        public void GetEnergyFieldData(){} // RVA: 0x6495800
        public void GetEnergyFieldSize(){} // RVA: 0x6495840
        public void GetImpulseResponseData(){} // RVA: 0x6495860
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SteamAudioReverbDataPoint
    {
        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x2DD310
        public void GetAssetFolderPath(){} // RVA: 0x64958A0
        public void GetBakedDataIdentifier(){} // RVA: 0x6484650
        public void EnsureValidData(){} // RVA: 0x2DD310
        public void BeginBake(){} // RVA: 0x64958E0
        public void UpdateEnergyField(){} // RVA: 0x6496050
        public void UpdateImpulseResponse(){} // RVA: 0x6496430
        public void WriteReverbDataToFile(){} // RVA: 0x64967D0
        public void FlushWrite(){} // RVA: 0x2DD310
        public void FlushAllWrites(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6496960
    }

    public class SteamAudioSettings
    {
        public 0x659BE580 CameraSelector; // 0x18

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x6496A00
        public void .ctor(){} // RVA: 0x6496D00
    }

    public class SteamAudioSource
    {
        public bool directBinaural; // 0x20

        // ── Methods ──
        public void get_interpolation(){} // RVA: 0x3CFAF0
        public void Awake(){} // RVA: 0x6496E20
        public void LazyInitSource(){} // RVA: 0x64970F0
        public void AssignHandle(){} // RVA: 0x64973B0
        public void SetAttenuationModel(){} // RVA: 0x6497640
        public void UpdateParameters(){} // RVA: 0x6497A60
        public void Start(){} // RVA: 0x6497A90
        public void OnDestroy(){} // RVA: 0x6497AC0
        public void OnEnable(){} // RVA: 0x6497C90
        public void OnDisable(){} // RVA: 0x6497D80
        public void LateUpdate(){} // RVA: 0x6497A60
        public void OnDrawGizmosSelected(){} // RVA: 0x6497EB0
        public void SetInputs(){} // RVA: 0x64985D0
        public void GetOutputs(){} // RVA: 0x6499410
        public void GetSource(){} // RVA: 0xA8E870
        public void UpdateOutputs(){} // RVA: 0x6499560
        public void InitializeDeformedSphereMesh(){} // RVA: 0x6499720
        public void DeformSphereMesh(){} // RVA: 0x6499FB0
        public void DeformedVertex(){} // RVA: 0x649A410
        public void EvaluateDistanceCurve(){} // RVA: 0x649A490
        public void .ctor(){} // RVA: 0x649A5F0
        public void .cctor(){} // RVA: 0x649A920
    }

    public class SteamAudioStaticMesh
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x649AAB0
        public void OnDestroy(){} // RVA: 0x649ACE0
        public void OnEnable(){} // RVA: 0x649AEA0
        public void OnDisable(){} // RVA: 0x649AF50
        public void Update(){} // RVA: 0x649B070
        public void .ctor(){} // RVA: 0x649B2B0
        public void <Update>b__8_0(){} // RVA: 0x649B380
    }

}