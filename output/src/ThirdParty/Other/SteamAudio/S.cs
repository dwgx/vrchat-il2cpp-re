// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 28
// Methods: 251

namespace ThirdParty.Other.SteamAudio
{
    public class SOFAFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8F29130
    }

    public class Scene
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8F27740 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAF8F27830
        public void Release(){} // RVA: 0x7FFAF8F27870
        public void Get(){} // RVA: 0x7FFAF2D907C0
        public void Save(){} // RVA: 0x7FFAF8F27940
        public void SaveOBJ(){} // RVA: 0x7FFAF8F27A50
        public void NotifyAddObject(){} // RVA: 0x7FFAF8F27B00
        public void NotifyRemoveObject(){} // RVA: 0x7FFAF8F27B10
        public void GetNumObjects(){} // RVA: 0x7FFAF3210030
        public void Commit(){} // RVA: 0x7FFAF8F27B20
    }

    public class SceneSettings
    {
    }

    public class SerializedData
    {
        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0x7FFAF2FC9240
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SerializedObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8F27DF0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAF8F27E90
        public void Release(){} // RVA: 0x7FFAF8F27ED0
        public void Get(){} // RVA: 0x7FFAF2DA8380
        public void GetSize(){} // RVA: 0x7FFAF8F27FB0
        public void GetData(){} // RVA: 0x7FFAF8F28030
        public void WriteToFile(){} // RVA: 0x7FFAF8F280B0
        public void FlushWrite(){} // RVA: 0x7FFAF2D8D310
        public void FlushAllWrites(){} // RVA: 0x7FFAF8F283A0
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
        public void .ctor(){} // RVA: 0x7FFAF8F28670 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8F28710
        public void Release(){} // RVA: 0x7FFAF8F28750
        public void Get(){} // RVA: 0x7FFAF2DA8380
        public void SetScene(){} // RVA: 0x7FFAF8F287D0
        public void AddProbeBatch(){} // RVA: 0x7FFAF8F28870
        public void RemoveProbeBatch(){} // RVA: 0x7FFAF8F28910
        public void SetSharedInputs(){} // RVA: 0x7FFAF8F289B0
        public void Commit(){} // RVA: 0x7FFAF8F289D0
        public void RunDirect(){} // RVA: 0x7FFAF8F28A50
        public void RunReflections(){} // RVA: 0x7FFAF8F28AD0
        public void RunPathing(){} // RVA: 0x7FFAF8F28B50
    }

    public class Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8F28D30 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8F28DD0
        public void Release(){} // RVA: 0x7FFAF8F28E10
        public void Get(){} // RVA: 0x7FFAF2DA8380
        public void AddToSimulator(){} // RVA: 0x7FFAF8F28E90
        public void RemoveFromSimulator(){} // RVA: 0x7FFAF8F28F30
        public void SetInputs(){} // RVA: 0x7FFAF8F28FD0
        public void GetOutputs(){} // RVA: 0x7FFAF8F28FF0
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
        public void Awake(){} // RVA: 0x7FFAF8F311D0
        public void Start(){} // RVA: 0x7FFAF8F31310
        public void OnDestroy(){} // RVA: 0x7FFAF8F31340
        public void OnEnable(){} // RVA: 0x7FFAF8F31310
        public void Update(){} // RVA: 0x7FFAF8F31310
        public void .ctor(){} // RVA: 0x7FFAF2DE7060
    }

    public class SteamAudioBakedListener
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAF2DE8CD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFAF2F476A0
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAF8F31360
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAF8F31390
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAF8F313C0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8F314E0
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAF8F31AB0
        public void BeginBake(){} // RVA: 0x7FFAF8F31C10
        public void CacheIdentifier(){} // RVA: 0x7FFAF8F322E0
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAF8F32310
        public void .ctor(){} // RVA: 0x7FFAF8F323D0
    }

    public class SteamAudioBakedSource
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAF2DE8CD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFAF2F476A0
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAF8F31360
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAF8F32440
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAF8F32470
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8F32590
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAF8F32B60
        public void BeginBake(){} // RVA: 0x7FFAF8F32CC0
        public void CacheIdentifier(){} // RVA: 0x7FFAF8F33390
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAF8F333C0
        public void .ctor(){} // RVA: 0x7FFAF8F323D0
    }

    public class SteamAudioDynamicObject
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFAF8F33480
        public void OnEnable(){} // RVA: 0x7FFAF8F334B0
        public void OnDisable(){} // RVA: 0x7FFAF8F33560
        public void Update(){} // RVA: 0x7FFAF8F33680
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamAudioGeometry
    {
        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x7FFAF8F33B80
        public void GetNumTriangles(){} // RVA: 0x7FFAF8F33D80
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamAudioListener
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFAF2E2E080
        public void GetProbeDataSizes(){} // RVA: 0x7FFAF2E08730
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFAF8F33F80
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFAF8F33FB0
        public void Awake(){} // RVA: 0x7FFAF8F33FE0
        public void Reinitialize(){} // RVA: 0x7FFAF8F33FF0
        public void OnDestroy(){} // RVA: 0x7FFAF8F34290
        public void Start(){} // RVA: 0x7FFAF8F342B0
        public void OnEnable(){} // RVA: 0x7FFAF8F34320
        public void OnDisable(){} // RVA: 0x7FFAF8F344C0
        public void Update(){} // RVA: 0x7FFAF8F342B0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAF8F34650
        public void SetInputs(){} // RVA: 0x7FFAF8F34680
        public void UpdateOutputs(){} // RVA: 0x7FFAF2D8D310
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8F34B20
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFAF8F34F90
        public void BeginBake(){} // RVA: 0x7FFAF8F350F0
        public void CacheIdentifier(){} // RVA: 0x7FFAF8F357A0
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFAF8F357B0
        public void .ctor(){} // RVA: 0x7FFAF8F35870
    }

    public class SteamAudioManager
    {
        public object _singleton;

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFAF8F358D0
        public void get_Context(){} // RVA: 0x7FFAF8F35910
        public void get_CurrentHRTF(){} // RVA: 0x7FFAF8F35960
        public void get_EmbreeDevice(){} // RVA: 0x7FFAF8F359D0
        public void get_OpenCLDevice(){} // RVA: 0x7FFAF8F35A30
        public void get_RadeonRaysDevice(){} // RVA: 0x7FFAF8F35A90
        public void get_TrueAudioNextDevice(){} // RVA: 0x7FFAF8F35AF0
        public void get_CurrentScene(){} // RVA: 0x7FFAF8F35B50
        public void get_Simulator(){} // RVA: 0x7FFAF8F35BA0
        public void get_AudioSettings(){} // RVA: 0x7FFAF8F35BF0
        public void GetAudioEngineState(){} // RVA: 0x7FFAF8F35C40
        public void GetSteamAudioListener(){} // RVA: 0x7FFAF8F35C90
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x7FFAF8F35DB0
        public void GetSceneType(){} // RVA: 0x7FFAF8F35DE0
        public void GetReflectionEffectType(){} // RVA: 0x7FFAF8F35E80
        public void GetPerspectiveCorrection(){} // RVA: 0x7FFAF8F35EF0
        public void GetMainCamera(){} // RVA: 0x7FFAF35402E0
        public void GetSimulationSettings(){} // RVA: 0x7FFAF8F36420
        public void OnApplicationStart(){} // RVA: 0x7FFAF8F36850
        public void LoadHRTFFromFile(){} // RVA: 0x7FFAF8F37670
        public void UnloadHRTFByName(){} // RVA: 0x7FFAF8F37840
        public void SetHRTFAtIndex(){} // RVA: 0x7FFAF8F37B60
        public void OnApplicationQuit(){} // RVA: 0x7FFAF8F37C40
        public void OnSceneLoaded(){} // RVA: 0x7FFAF8F37C90
        public void OnSceneUnloaded(){} // RVA: 0x7FFAF8F37DF0
        public void NotifyAudioListenerChanged(){} // RVA: 0x7FFAF8F37E00
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x7FFAF8F37E50
        public void NotifyMainCameraChanged(){} // RVA: 0x7FFAF8F38070
        public void ScheduleCommitScene(){} // RVA: 0x7FFAF8F38110
        public void LateUpdate(){} // RVA: 0x7FFAF8F38160
        public void RunSimulationInternal(){} // RVA: 0x7FFAF8F391F0
        public void RunSimulation(){} // RVA: 0x7FFAF8F39310
        public void Initialize(){} // RVA: 0x7FFAF8F39370
        public void ShutDown(){} // RVA: 0x7FFAF8F39510
        public void Reinitialize(){} // RVA: 0x7FFAF8F39C40
        public void AddSource(){} // RVA: 0x7FFAF8F3AD40
        public void RemoveSource(){} // RVA: 0x7FFAF8F3ADD0
        public void AddListener(){} // RVA: 0x7FFAF8F3AE50
        public void RemoveListener(){} // RVA: 0x7FFAF8F3AEE0
        public void ExportDynamicObject(){} // RVA: 0x7FFAF8F3AF60
        public void ExportDynamicObjectsInArray(){} // RVA: 0x7FFAF8F3B240
        public void GetDynamicObjectsInScene(){} // RVA: 0x7FFAF8F3B510
        public void LoadScene(){} // RVA: 0x7FFAF8F3B670
        public void LoadDynamicObject(){} // RVA: 0x7FFAF8F3B730
        public void UnloadDynamicObject(){} // RVA: 0x7FFAF8F3BD00
        public void GetGameObjectsForExport(){} // RVA: 0x7FFAF8F3BF10
        public void GetNumVertices(){} // RVA: 0x7FFAF8F3C700
        public void GetNumTriangles(){} // RVA: 0x7FFAF8F3CC30
        public void ClosestHit(){} // RVA: 0x7FFAF8F3D170
        public void AnyHit(){} // RVA: 0x7FFAF8F3D4E0
        public void AutoInitialize(){} // RVA: 0x7FFAF8F3D700
        public void FirstAutoInitialize(){} // RVA: 0x7FFAF8F3D750
        public void ExportScene(){} // RVA: 0x7FFAF8F3D7B0
        public void Export(){} // RVA: 0x7FFAF8F3DB60
        public void CreateScene(){} // RVA: 0x7FFAF8F3E030
        public void Load(){} // RVA: 0x7FFAF8F3E450
        public void RemoveAllDynamicObjects(){} // RVA: 0x7FFAF8F3E4D0
        public void RemoveAllAdditiveScenes(){} // RVA: 0x7FFAF8F3EA60
        public void GetMaterialBufferForTransform(){} // RVA: 0x7FFAF8F3EB90
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFAF8F3EEF0
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x7FFAF8F3F010
        public void IsDynamicSubObject(){} // RVA: 0x7FFAF8F3F0B0
        public void IsActiveInHierarchy(){} // RVA: 0x7FFAF8F3F270
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x7FFAF8F3F440
        public void GetDynamicObjectInParent(){} // RVA: 0x7FFAF8F3FA50
        public void GetVertices(){} // RVA: 0x7FFAF8F3FC90
        public void GetTriangles(){} // RVA: 0x7FFAF8F40AF0
        public void FixupTriangleIndices(){} // RVA: 0x7FFAF8F411B0
        public void GetTerrainSimplificationLevel(){} // RVA: 0x7FFAF8F41220
        public void GetMaterialMapping(){} // RVA: 0x7FFAF8F41280
        public void GetMaterialForGameObject(){} // RVA: 0x7FFAF8F41AE0
        public void GetOBJFileName(){} // RVA: 0x7FFAF8F41F60 | overloaded x2
        public void GetDataAsset(){} // RVA: 0x7FFAF8F42430 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF8F42450
    }

    public class SteamAudioMaterial
    {
        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x7FFAF8F42790
        public void .ctor(){} // RVA: 0x7FFAF8F427D0
    }

    public class SteamAudioProbeBatch
    {
        // ── Methods ──
        public void GetAsset(){} // RVA: 0x7FFAF8F42810
        public void GetNumProbes(){} // RVA: 0x7FFAF8F42A10
        public void GetNumLayers(){} // RVA: 0x7FFAF8F42A30
        public void GetProbeBatch(){} // RVA: 0x7FFAF8F42A80
        public void Awake(){} // RVA: 0x7FFAF8F42AA0
        public void OnDestroy(){} // RVA: 0x7FFAF8F42C60
        public void OnEnable(){} // RVA: 0x7FFAF8F42C80
        public void OnDisable(){} // RVA: 0x7FFAF8F42D70
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8F42EA0
        public void GenerateProbes(){} // RVA: 0x7FFAF8F43380
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x7FFAF8F44120
        public void GetSizeForLayer(){} // RVA: 0x7FFAF8F445C0
        public void GetInfoForLayer(){} // RVA: 0x7FFAF8F44770
        public void ResetLayers(){} // RVA: 0x7FFAF8F44810
        public void AddLayer(){} // RVA: 0x7FFAF8F44880
        public void RemoveLayer(){} // RVA: 0x7FFAF8F449B0
        public void AddOrUpdateLayer(){} // RVA: 0x7FFAF8F44BE0
        public void UpdateGameObjectStatistics(){} // RVA: 0x7FFAF8F44EC0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAF8F44FB0
        public void BeginBake(){} // RVA: 0x7FFAF8F44FF0
        public void .ctor(){} // RVA: 0x7FFAF8F45580
    }

    public class SteamAudioReverbData
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF8F45680
        public void GetImpulseResponseSize(){} // RVA: 0x7FFAF8F457E0
        public void GetEnergyFieldData(){} // RVA: 0x7FFAF8F45800
        public void GetEnergyFieldSize(){} // RVA: 0x7FFAF8F45840
        public void GetImpulseResponseData(){} // RVA: 0x7FFAF8F45860
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SteamAudioReverbDataPoint
    {
        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x7FFAF2D8D310
        public void GetAssetFolderPath(){} // RVA: 0x7FFAF8F458A0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFAF8F34650
        public void EnsureValidData(){} // RVA: 0x7FFAF2D8D310
        public void BeginBake(){} // RVA: 0x7FFAF8F458E0
        public void UpdateEnergyField(){} // RVA: 0x7FFAF8F46050
        public void UpdateImpulseResponse(){} // RVA: 0x7FFAF8F46430
        public void WriteReverbDataToFile(){} // RVA: 0x7FFAF8F467D0
        public void FlushWrite(){} // RVA: 0x7FFAF2D8D310
        public void FlushAllWrites(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF8F46960
    }

    public class SteamAudioSettings
    {
        public object CameraSelector;

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFAF8F46A00
        public void .ctor(){} // RVA: 0x7FFAF8F46D00
    }

    public class SteamAudioSource
    {
        // ── Methods ──
        public void get_interpolation(){} // RVA: 0x7FFAF2E7FAF0
        public void Awake(){} // RVA: 0x7FFAF8F46E20
        public void LazyInitSource(){} // RVA: 0x7FFAF8F470F0
        public void AssignHandle(){} // RVA: 0x7FFAF8F473B0
        public void SetAttenuationModel(){} // RVA: 0x7FFAF8F47640
        public void UpdateParameters(){} // RVA: 0x7FFAF8F47A60
        public void Start(){} // RVA: 0x7FFAF8F47A90
        public void OnDestroy(){} // RVA: 0x7FFAF8F47AC0
        public void OnEnable(){} // RVA: 0x7FFAF8F47C90
        public void OnDisable(){} // RVA: 0x7FFAF8F47D80
        public void LateUpdate(){} // RVA: 0x7FFAF8F47A60
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8F47EB0
        public void SetInputs(){} // RVA: 0x7FFAF8F485D0
        public void GetOutputs(){} // RVA: 0x7FFAF8F49410
        public void GetSource(){} // RVA: 0x7FFAF353E870
        public void UpdateOutputs(){} // RVA: 0x7FFAF8F49560
        public void InitializeDeformedSphereMesh(){} // RVA: 0x7FFAF8F49720
        public void DeformSphereMesh(){} // RVA: 0x7FFAF8F49FB0
        public void DeformedVertex(){} // RVA: 0x7FFAF8F4A410
        public void EvaluateDistanceCurve(){} // RVA: 0x7FFAF8F4A490
        public void .ctor(){} // RVA: 0x7FFAF8F4A5F0
        public void .cctor(){} // RVA: 0x7FFAF8F4A920
    }

    public class SteamAudioStaticMesh
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8F4AAB0
        public void OnDestroy(){} // RVA: 0x7FFAF8F4ACE0
        public void OnEnable(){} // RVA: 0x7FFAF8F4AEA0
        public void OnDisable(){} // RVA: 0x7FFAF8F4AF50
        public void Update(){} // RVA: 0x7FFAF8F4B070
        public void .ctor(){} // RVA: 0x7FFAF8F4B2B0
        public void <Update>b__8_0(){} // RVA: 0x7FFAF8F4B380
    }

}