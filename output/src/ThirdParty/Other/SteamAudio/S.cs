// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 28
// Methods: 251

namespace ThirdParty.Other.SteamAudio
{
    public class SOFAFile : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB8200
    }

    public class Scene : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB6810 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFE86FB6900
        public void Release(){} // RVA: 0x7FFE86FB6940
        public void Get(){} // RVA: 0x7FFE810FE7C0
        public void Save(){} // RVA: 0x7FFE86FB6A10
        public void SaveOBJ(){} // RVA: 0x7FFE86FB6B20
        public void NotifyAddObject(){} // RVA: 0x7FFE86FB6BD0
        public void NotifyRemoveObject(){} // RVA: 0x7FFE86FB6BE0
        public void GetNumObjects(){} // RVA: 0x7FFE8151D690
        public void Commit(){} // RVA: 0x7FFE86FB6BF0
    }

    public class SceneSettings : ValueType
    {
    }

    public class SerializedData : ScriptableObject
    {
        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SerializedObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB6EC0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFE86FB6F60
        public void Release(){} // RVA: 0x7FFE86FB6FA0
        public void Get(){} // RVA: 0x7FFE81116380
        public void GetSize(){} // RVA: 0x7FFE86FB7080
        public void GetData(){} // RVA: 0x7FFE86FB7100
        public void WriteToFile(){} // RVA: 0x7FFE86FB7180
        public void FlushWrite(){} // RVA: 0x7FFE810FB310
        public void FlushAllWrites(){} // RVA: 0x7FFE86FB7470
    }

    public class SerializedObjectSettings : ValueType
    {
    }

    public class SimulationInputs : ValueType
    {
    }

    public class SimulationOutputs : ValueType
    {
    }

    public class SimulationSettings : ValueType
    {
    }

    public class SimulationSharedInputs : ValueType
    {
    }

    public class Simulator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB7740 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE86FB77E0
        public void Release(){} // RVA: 0x7FFE86FB7820
        public void Get(){} // RVA: 0x7FFE81116380
        public void SetScene(){} // RVA: 0x7FFE86FB78A0
        public void AddProbeBatch(){} // RVA: 0x7FFE86FB7940
        public void RemoveProbeBatch(){} // RVA: 0x7FFE86FB79E0
        public void SetSharedInputs(){} // RVA: 0x7FFE86FB7A80
        public void Commit(){} // RVA: 0x7FFE86FB7AA0
        public void RunDirect(){} // RVA: 0x7FFE86FB7B20
        public void RunReflections(){} // RVA: 0x7FFE86FB7BA0
        public void RunPathing(){} // RVA: 0x7FFE86FB7C20
    }

    public class Source : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB7E00 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE86FB7EA0
        public void Release(){} // RVA: 0x7FFE86FB7EE0
        public void Get(){} // RVA: 0x7FFE81116380
        public void AddToSimulator(){} // RVA: 0x7FFE86FB7F60
        public void RemoveFromSimulator(){} // RVA: 0x7FFE86FB8000
        public void SetInputs(){} // RVA: 0x7FFE86FB80A0
        public void GetOutputs(){} // RVA: 0x7FFE86FB80C0
    }

    public class SourceSettings : ValueType
    {
    }

    public class Sphere : ValueType
    {
    }

    public class SteamAudioAmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE86FC0280
        public void Start(){} // RVA: 0x7FFE86FC03C0
        public void OnDestroy(){} // RVA: 0x7FFE86FC03F0
        public void OnEnable(){} // RVA: 0x7FFE86FC03C0
        public void Update(){} // RVA: 0x7FFE86FC03C0
        public void .ctor(){} // RVA: 0x7FFE81155060
    }

    public class SteamAudioBakedListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFE81156CD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFE8143BA80
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFE86FC0410
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFE86FC0440
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFE86FC0470
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE86FC0590
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFE86FC0B60
        public void BeginBake(){} // RVA: 0x7FFE86FC0CC0
        public void CacheIdentifier(){} // RVA: 0x7FFE86FC1390
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFE86FC13C0
        public void .ctor(){} // RVA: 0x7FFE86FC1480
    }

    public class SteamAudioBakedSource : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFE81156CD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFE8143BA80
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFE86FC0410
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFE86FC14F0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFE86FC1520
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE86FC1640
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFE86FC1C10
        public void BeginBake(){} // RVA: 0x7FFE86FC1D70
        public void CacheIdentifier(){} // RVA: 0x7FFE86FC2440
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFE86FC2470
        public void .ctor(){} // RVA: 0x7FFE86FC1480
    }

    public class SteamAudioDynamicObject : MonoBehaviour
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFE86FC2530
        public void OnEnable(){} // RVA: 0x7FFE86FC2560
        public void OnDisable(){} // RVA: 0x7FFE86FC2610
        public void Update(){} // RVA: 0x7FFE86FC2730
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamAudioGeometry : MonoBehaviour
    {
        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x7FFE86FC2C30
        public void GetNumTriangles(){} // RVA: 0x7FFE86FC2E30
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamAudioListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFE8119C080
        public void GetProbeDataSizes(){} // RVA: 0x7FFE81176730
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFE86FC3030
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFE86FC3060
        public void Awake(){} // RVA: 0x7FFE86FC3090
        public void Reinitialize(){} // RVA: 0x7FFE86FC30A0
        public void OnDestroy(){} // RVA: 0x7FFE86FC3340
        public void Start(){} // RVA: 0x7FFE86FC3360
        public void OnEnable(){} // RVA: 0x7FFE86FC33D0
        public void OnDisable(){} // RVA: 0x7FFE86FC3570
        public void Update(){} // RVA: 0x7FFE86FC3360
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFE86FC3700
        public void SetInputs(){} // RVA: 0x7FFE86FC3730
        public void UpdateOutputs(){} // RVA: 0x7FFE810FB310
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE86FC3BD0
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFE86FC4040
        public void BeginBake(){} // RVA: 0x7FFE86FC41A0
        public void CacheIdentifier(){} // RVA: 0x7FFE86FC4850
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFE86FC4860
        public void .ctor(){} // RVA: 0x7FFE86FC4920
    }

    public class SteamAudioManager : MonoBehaviour
    {
        public int currentHRTF; // 0x20
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
        public void get_Singleton(){} // RVA: 0x7FFE86FC4980
        public void get_Context(){} // RVA: 0x7FFE86FC49C0
        public void get_CurrentHRTF(){} // RVA: 0x7FFE86FC4A10
        public void get_EmbreeDevice(){} // RVA: 0x7FFE86FC4A80
        public void get_OpenCLDevice(){} // RVA: 0x7FFE86FC4AE0
        public void get_RadeonRaysDevice(){} // RVA: 0x7FFE86FC4B40
        public void get_TrueAudioNextDevice(){} // RVA: 0x7FFE86FC4BA0
        public void get_CurrentScene(){} // RVA: 0x7FFE86FC4C00
        public void get_Simulator(){} // RVA: 0x7FFE86FC4C50
        public void get_AudioSettings(){} // RVA: 0x7FFE86FC4CA0
        public void GetAudioEngineState(){} // RVA: 0x7FFE86FC4CF0
        public void GetSteamAudioListener(){} // RVA: 0x7FFE86FC4D40
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x7FFE86FC4E60
        public void GetSceneType(){} // RVA: 0x7FFE86FC4E90
        public void GetReflectionEffectType(){} // RVA: 0x7FFE86FC4F30
        public void GetPerspectiveCorrection(){} // RVA: 0x7FFE86FC4FA0
        public void GetMainCamera(){} // RVA: 0x7FFE8181E3D0
        public void GetSimulationSettings(){} // RVA: 0x7FFE86FC54D0
        public void OnApplicationStart(){} // RVA: 0x7FFE86FC5900
        public void LoadHRTFFromFile(){} // RVA: 0x7FFE86FC6720
        public void UnloadHRTFByName(){} // RVA: 0x7FFE86FC68F0
        public void SetHRTFAtIndex(){} // RVA: 0x7FFE86FC6C10
        public void OnApplicationQuit(){} // RVA: 0x7FFE86FC6CF0
        public void OnSceneLoaded(){} // RVA: 0x7FFE86FC6D40
        public void OnSceneUnloaded(){} // RVA: 0x7FFE86FC6EA0
        public void NotifyAudioListenerChanged(){} // RVA: 0x7FFE86FC6EB0
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x7FFE86FC6F00
        public void NotifyMainCameraChanged(){} // RVA: 0x7FFE86FC7120
        public void ScheduleCommitScene(){} // RVA: 0x7FFE86FC71C0
        public void LateUpdate(){} // RVA: 0x7FFE86FC7210
        public void RunSimulationInternal(){} // RVA: 0x7FFE86FC82A0
        public void RunSimulation(){} // RVA: 0x7FFE86FC83C0
        public void Initialize(){} // RVA: 0x7FFE86FC8420
        public void ShutDown(){} // RVA: 0x7FFE86FC85C0
        public void Reinitialize(){} // RVA: 0x7FFE86FC8CF0
        public void AddSource(){} // RVA: 0x7FFE86FC9DF0
        public void RemoveSource(){} // RVA: 0x7FFE86FC9E80
        public void AddListener(){} // RVA: 0x7FFE86FC9F00
        public void RemoveListener(){} // RVA: 0x7FFE86FC9F90
        public void ExportDynamicObject(){} // RVA: 0x7FFE86FCA010
        public void ExportDynamicObjectsInArray(){} // RVA: 0x7FFE86FCA2F0
        public void GetDynamicObjectsInScene(){} // RVA: 0x7FFE86FCA5C0
        public void LoadScene(){} // RVA: 0x7FFE86FCA720
        public void LoadDynamicObject(){} // RVA: 0x7FFE86FCA7E0
        public void UnloadDynamicObject(){} // RVA: 0x7FFE86FCADB0
        public void GetGameObjectsForExport(){} // RVA: 0x7FFE86FCAFC0
        public void GetNumVertices(){} // RVA: 0x7FFE86FCB7B0
        public void GetNumTriangles(){} // RVA: 0x7FFE86FCBCE0
        public void ClosestHit(){} // RVA: 0x7FFE86FCC220
        public void AnyHit(){} // RVA: 0x7FFE86FCC590
        public void AutoInitialize(){} // RVA: 0x7FFE86FCC7B0
        public void FirstAutoInitialize(){} // RVA: 0x7FFE86FCC800
        public void ExportScene(){} // RVA: 0x7FFE86FCC860
        public void Export(){} // RVA: 0x7FFE86FCCC10
        public void CreateScene(){} // RVA: 0x7FFE86FCD0E0
        public void Load(){} // RVA: 0x7FFE86FCD500
        public void RemoveAllDynamicObjects(){} // RVA: 0x7FFE86FCD580
        public void RemoveAllAdditiveScenes(){} // RVA: 0x7FFE86FCDB10
        public void GetMaterialBufferForTransform(){} // RVA: 0x7FFE86FCDC40
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFE86FCDFA0
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x7FFE86FCE0C0
        public void IsDynamicSubObject(){} // RVA: 0x7FFE86FCE160
        public void IsActiveInHierarchy(){} // RVA: 0x7FFE86FCE320
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x7FFE86FCE4F0
        public void GetDynamicObjectInParent(){} // RVA: 0x7FFE86FCEB00
        public void GetVertices(){} // RVA: 0x7FFE86FCED40
        public void GetTriangles(){} // RVA: 0x7FFE86FCFBA0
        public void FixupTriangleIndices(){} // RVA: 0x7FFE86FD0260
        public void GetTerrainSimplificationLevel(){} // RVA: 0x7FFE86FD02D0
        public void GetMaterialMapping(){} // RVA: 0x7FFE86FD0330
        public void GetMaterialForGameObject(){} // RVA: 0x7FFE86FD0B90
        public void GetOBJFileName(){} // RVA: 0x7FFE86FD1010 | overloaded x2
        public void GetDataAsset(){} // RVA: 0x7FFE86FD14E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86FD1500
    }

    public class SteamAudioMaterial : ScriptableObject
    {
        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x7FFE86FD1840
        public void .ctor(){} // RVA: 0x7FFE86FD1880
    }

    public class SteamAudioProbeBatch : MonoBehaviour
    {
        // ── Methods ──
        public void GetAsset(){} // RVA: 0x7FFE86FD18C0
        public void GetNumProbes(){} // RVA: 0x7FFE86FD1AC0
        public void GetNumLayers(){} // RVA: 0x7FFE86FD1AE0
        public void GetProbeBatch(){} // RVA: 0x7FFE86FD1B30
        public void Awake(){} // RVA: 0x7FFE86FD1B50
        public void OnDestroy(){} // RVA: 0x7FFE86FD1D10
        public void OnEnable(){} // RVA: 0x7FFE86FD1D30
        public void OnDisable(){} // RVA: 0x7FFE86FD1E20
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE86FD1F50
        public void GenerateProbes(){} // RVA: 0x7FFE86FD2430
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x7FFE86FD31D0
        public void GetSizeForLayer(){} // RVA: 0x7FFE86FD3670
        public void GetInfoForLayer(){} // RVA: 0x7FFE86FD3820
        public void ResetLayers(){} // RVA: 0x7FFE86FD38C0
        public void AddLayer(){} // RVA: 0x7FFE86FD3930
        public void RemoveLayer(){} // RVA: 0x7FFE86FD3A60
        public void AddOrUpdateLayer(){} // RVA: 0x7FFE86FD3C90
        public void UpdateGameObjectStatistics(){} // RVA: 0x7FFE86FD3F70
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFE86FD4060
        public void BeginBake(){} // RVA: 0x7FFE86FD40A0
        public void .ctor(){} // RVA: 0x7FFE86FD4630
    }

    public class SteamAudioReverbData : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE86FD4730
        public void GetImpulseResponseSize(){} // RVA: 0x7FFE86FD4890
        public void GetEnergyFieldData(){} // RVA: 0x7FFE86FD48B0
        public void GetEnergyFieldSize(){} // RVA: 0x7FFE86FD48F0
        public void GetImpulseResponseData(){} // RVA: 0x7FFE86FD4910
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SteamAudioReverbDataPoint : MonoBehaviour
    {
        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x7FFE810FB310
        public void GetAssetFolderPath(){} // RVA: 0x7FFE86FD4950
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFE86FC3700
        public void EnsureValidData(){} // RVA: 0x7FFE810FB310
        public void BeginBake(){} // RVA: 0x7FFE86FD4990
        public void UpdateEnergyField(){} // RVA: 0x7FFE86FD5100
        public void UpdateImpulseResponse(){} // RVA: 0x7FFE86FD54E0
        public void WriteReverbDataToFile(){} // RVA: 0x7FFE86FD5880
        public void FlushWrite(){} // RVA: 0x7FFE810FB310
        public void FlushAllWrites(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE86FD5A10
    }

    public class SteamAudioSettings : ScriptableObject
    {
        public 0x6669443C audioEngine; // 0x18

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFE86FD5AB0
        public void .ctor(){} // RVA: 0x7FFE86FD5DB0
    }

    public class SteamAudioSource : MonoBehaviour
    {
        public bool directBinaural; // 0x20

        // ── Methods ──
        public void get_interpolation(){} // RVA: 0x7FFE811EDAF0
        public void Awake(){} // RVA: 0x7FFE86FD5ED0
        public void LazyInitSource(){} // RVA: 0x7FFE86FD61A0
        public void AssignHandle(){} // RVA: 0x7FFE86FD6460
        public void SetAttenuationModel(){} // RVA: 0x7FFE86FD66F0
        public void UpdateParameters(){} // RVA: 0x7FFE86FD6B10
        public void Start(){} // RVA: 0x7FFE86FD6B40
        public void OnDestroy(){} // RVA: 0x7FFE86FD6B70
        public void OnEnable(){} // RVA: 0x7FFE86FD6D40
        public void OnDisable(){} // RVA: 0x7FFE86FD6E30
        public void LateUpdate(){} // RVA: 0x7FFE86FD6B10
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE86FD6F60
        public void SetInputs(){} // RVA: 0x7FFE86FD7680
        public void GetOutputs(){} // RVA: 0x7FFE86FD84C0
        public void GetSource(){} // RVA: 0x7FFE81823850
        public void UpdateOutputs(){} // RVA: 0x7FFE86FD8610
        public void InitializeDeformedSphereMesh(){} // RVA: 0x7FFE86FD87D0
        public void DeformSphereMesh(){} // RVA: 0x7FFE86FD9060
        public void DeformedVertex(){} // RVA: 0x7FFE86FD94C0
        public void EvaluateDistanceCurve(){} // RVA: 0x7FFE86FD9540
        public void .ctor(){} // RVA: 0x7FFE86FD96A0
        public void .cctor(){} // RVA: 0x7FFE86FD99D0
    }

    public class SteamAudioStaticMesh : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86FD9B60
        public void OnDestroy(){} // RVA: 0x7FFE86FD9D90
        public void OnEnable(){} // RVA: 0x7FFE86FD9F50
        public void OnDisable(){} // RVA: 0x7FFE86FDA000
        public void Update(){} // RVA: 0x7FFE86FDA120
        public void .ctor(){} // RVA: 0x7FFE86FDA360
        public void <Update>b__8_0(){} // RVA: 0x7FFE86FDA430
    }

}