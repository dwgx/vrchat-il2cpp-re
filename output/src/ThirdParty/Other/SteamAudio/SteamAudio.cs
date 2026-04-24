// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 45
// Methods: 505

namespace ThirdParty.Other.SteamAudio
{
    public class API : Object
    {
        // ── Methods ──
        public void iplContextCreate(){} // RVA: 0x7FFD54032060
        public void iplContextRetain(){} // RVA: 0x7FFD540321C0
        public void iplContextRelease(){} // RVA: 0x7FFD54032240
        public void iplCalculateRelativeDirection(){} // RVA: 0x7FFD540322C0
        public void iplSerializedObjectCreate(){} // RVA: 0x7FFD540323F0
        public void iplSerializedObjectRetain(){} // RVA: 0x7FFD54032490
        public void iplSerializedObjectRelease(){} // RVA: 0x7FFD54032510
        public void iplSerializedObjectGetSize(){} // RVA: 0x7FFD54032590
        public void iplSerializedObjectGetData(){} // RVA: 0x7FFD54032610
        public void iplEmbreeDeviceCreate(){} // RVA: 0x7FFD54032690
        public void iplEmbreeDeviceRetain(){} // RVA: 0x7FFD54032730
        public void iplEmbreeDeviceRelease(){} // RVA: 0x7FFD540327B0
        public void iplOpenCLDeviceListCreate(){} // RVA: 0x7FFD54032830
        public void iplOpenCLDeviceListRetain(){} // RVA: 0x7FFD540328D0
        public void iplOpenCLDeviceListRelease(){} // RVA: 0x7FFD54032950
        public void iplOpenCLDeviceListGetNumDevices(){} // RVA: 0x7FFD540329D0
        public void iplOpenCLDeviceListGetDeviceDesc(){} // RVA: 0x7FFD54032A50
        public void iplOpenCLDeviceCreate(){} // RVA: 0x7FFD54032C40
        public void iplOpenCLDeviceRetain(){} // RVA: 0x7FFD54032CF0
        public void iplOpenCLDeviceRelease(){} // RVA: 0x7FFD54032D70
        public void iplRadeonRaysDeviceCreate(){} // RVA: 0x7FFD54032DF0
        public void iplRadeonRaysDeviceRetain(){} // RVA: 0x7FFD54032E90
        public void iplRadeonRaysDeviceRelease(){} // RVA: 0x7FFD54032F10
        public void iplTrueAudioNextDeviceCreate(){} // RVA: 0x7FFD54032F90
        public void iplTrueAudioNextDeviceRetain(){} // RVA: 0x7FFD54033030
        public void iplTrueAudioNextDeviceRelease(){} // RVA: 0x7FFD540330B0
        public void iplSceneCreate(){} // RVA: 0x7FFD54033130
        public void iplSceneRetain(){} // RVA: 0x7FFD540332C0
        public void iplSceneRelease(){} // RVA: 0x7FFD54033340
        public void iplSceneLoad(){} // RVA: 0x7FFD540333C0
        public void iplSceneSave(){} // RVA: 0x7FFD54033570
        public void iplSceneSaveOBJ(){} // RVA: 0x7FFD54033600
        public void iplSceneCommit(){} // RVA: 0x7FFD540336B0
        public void iplStaticMeshCreate(){} // RVA: 0x7FFD54033730
        public void iplStaticMeshRetain(){} // RVA: 0x7FFD540337D0
        public void iplStaticMeshRelease(){} // RVA: 0x7FFD54033850
        public void iplStaticMeshLoad(){} // RVA: 0x7FFD540338D0
        public void iplStaticMeshSave(){} // RVA: 0x7FFD54033990
        public void iplStaticMeshAdd(){} // RVA: 0x7FFD54033A20
        public void iplStaticMeshRemove(){} // RVA: 0x7FFD54033AB0
        public void iplInstancedMeshCreate(){} // RVA: 0x7FFD54033B40
        public void iplInstancedMeshRetain(){} // RVA: 0x7FFD54033BE0
        public void iplInstancedMeshRelease(){} // RVA: 0x7FFD54033C60
        public void iplInstancedMeshAdd(){} // RVA: 0x7FFD54033CE0
        public void iplInstancedMeshRemove(){} // RVA: 0x7FFD54033D70
        public void iplInstancedMeshUpdateTransform(){} // RVA: 0x7FFD54033E00
        public void iplHRTFCreate(){} // RVA: 0x7FFD54033EC0
        public void iplHRTFRetain(){} // RVA: 0x7FFD54034140
        public void iplHRTFRelease(){} // RVA: 0x7FFD540341C0
        public void iplProbeArrayCreate(){} // RVA: 0x7FFD54034240
        public void iplProbeArrayRetain(){} // RVA: 0x7FFD540342D0
        public void iplProbeArrayRelease(){} // RVA: 0x7FFD54034350
        public void iplProbeArrayGenerateProbes(){} // RVA: 0x7FFD540343D0
        public void iplProbeArrayGetNumProbes(){} // RVA: 0x7FFD54034470
        public void iplProbeArrayGetProbe(){} // RVA: 0x7FFD540344F0
        public void iplProbeBatchCreate(){} // RVA: 0x7FFD54034590
        public void iplProbeBatchRetain(){} // RVA: 0x7FFD54034620
        public void iplProbeBatchRelease(){} // RVA: 0x7FFD540346A0
        public void iplProbeBatchLoad(){} // RVA: 0x7FFD54034720
        public void iplProbeBatchSave(){} // RVA: 0x7FFD540347C0
        public void iplProbeBatchGetNumProbes(){} // RVA: 0x7FFD54034850
        public void iplProbeBatchAddProbe(){} // RVA: 0x7FFD540348D0
        public void iplProbeBatchAddProbeArray(){} // RVA: 0x7FFD54034970
        public void iplProbeBatchRemoveProbe(){} // RVA: 0x7FFD54034A00
        public void iplProbeBatchCommit(){} // RVA: 0x7FFD54034A90
        public void iplProbeBatchRemoveData(){} // RVA: 0x7FFD54034B10
        public void iplProbeBatchGetDataSize(){} // RVA: 0x7FFD54034BA0
        public void iplProbeBatchGetEnergyField(){} // RVA: 0x7FFD54034C30
        public void iplProbeBatchGetReverb(){} // RVA: 0x7FFD54034CE0
        public void iplReflectionsBakerBake(){} // RVA: 0x7FFD54034DA0
        public void iplReflectionsBakerCancelBake(){} // RVA: 0x7FFD54034E50
        public void iplPathBakerBake(){} // RVA: 0x7FFD54034ED0
        public void iplPathBakerCancelBake(){} // RVA: 0x7FFD54034F80
        public void iplSimulatorCreate(){} // RVA: 0x7FFD54035000
        public void iplSimulatorRetain(){} // RVA: 0x7FFD540350A0
        public void iplSimulatorRelease(){} // RVA: 0x7FFD54035120
        public void iplSimulatorSetScene(){} // RVA: 0x7FFD540351A0
        public void iplSimulatorAddProbeBatch(){} // RVA: 0x7FFD54035230
        public void iplSimulatorRemoveProbeBatch(){} // RVA: 0x7FFD540352C0
        public void iplSimulatorSetSharedInputs(){} // RVA: 0x7FFD54035350
        public void iplSimulatorCommit(){} // RVA: 0x7FFD540355F0
        public void iplSimulatorRunDirect(){} // RVA: 0x7FFD54035670
        public void iplSimulatorRunReflections(){} // RVA: 0x7FFD540356F0
        public void iplSimulatorRunPathing(){} // RVA: 0x7FFD54035770
        public void iplSourceCreate(){} // RVA: 0x7FFD540357F0
        public void iplSourceRetain(){} // RVA: 0x7FFD54035890
        public void iplSourceRelease(){} // RVA: 0x7FFD54035910
        public void iplSourceAdd(){} // RVA: 0x7FFD54035990
        public void iplSourceRemove(){} // RVA: 0x7FFD54035A20
        public void iplSourceSetInputs(){} // RVA: 0x7FFD54035AB0
        public void iplSourceGetOutputs(){} // RVA: 0x7FFD54035DD0
        public void iplDistanceAttenuationCalculate(){} // RVA: 0x7FFD54035E70
        public void iplAirAbsorptionCalculate(){} // RVA: 0x7FFD54035FF0
        public void iplDirectivityCalculate(){} // RVA: 0x7FFD540361A0
        public void iplEnergyFieldCreate(){} // RVA: 0x7FFD54036340
        public void iplEnergyFieldRetain(){} // RVA: 0x7FFD540363E0
        public void iplEnergyFieldRelease(){} // RVA: 0x7FFD54036460
        public void iplEnergyFieldGetNumChannels(){} // RVA: 0x7FFD540364E0
        public void iplEnergyFieldGetNumBins(){} // RVA: 0x7FFD54036560
        public void iplEnergyFieldGetData(){} // RVA: 0x7FFD540365E0
        public void iplEnergyFieldGetChannel(){} // RVA: 0x7FFD54036660
        public void iplEnergyFieldGetBand(){} // RVA: 0x7FFD540366F0
        public void iplEnergyFieldReset(){} // RVA: 0x7FFD54036790
        public void iplEnergyFieldCopy(){} // RVA: 0x7FFD54036810
        public void iplEnergyFieldSwap(){} // RVA: 0x7FFD540368A0
        public void iplEnergyFieldAdd(){} // RVA: 0x7FFD54036930
        public void iplEnergyFieldScale(){} // RVA: 0x7FFD540369D0
        public void iplEnergyFieldScaleAccum(){} // RVA: 0x7FFD54036A70
        public void iplImpulseResponseCreate(){} // RVA: 0x7FFD54036B10
        public void iplImpulseResponseRetain(){} // RVA: 0x7FFD54036BB0
        public void iplImpulseResponseRelease(){} // RVA: 0x7FFD54036C30
        public void iplImpulseResponseGetNumChannels(){} // RVA: 0x7FFD54036CB0
        public void iplImpulseResponseGetNumSamples(){} // RVA: 0x7FFD54036D30
        public void iplImpulseResponseGetData(){} // RVA: 0x7FFD54036DB0
        public void iplImpulseResponseGetChannel(){} // RVA: 0x7FFD54036E30
        public void iplImpulseResponseReset(){} // RVA: 0x7FFD54036EC0
        public void iplImpulseResponseCopy(){} // RVA: 0x7FFD54036F40
        public void iplImpulseResponseSwap(){} // RVA: 0x7FFD54036FD0
        public void iplImpulseResponseAdd(){} // RVA: 0x7FFD54037060
        public void iplImpulseResponseScale(){} // RVA: 0x7FFD54037100
        public void iplImpulseResponseScaleAccum(){} // RVA: 0x7FFD540371A0
        public void iplReconstructorCreate(){} // RVA: 0x7FFD54037240
        public void iplReconstructorRetain(){} // RVA: 0x7FFD540372E0
        public void iplReconstructorRelease(){} // RVA: 0x7FFD54037360
        public void iplReconstructorReconstruct(){} // RVA: 0x7FFD540373E0
        public void iplUnityInitialize(){} // RVA: 0x7FFD54037490
        public void iplUnitySetPerspectiveCorrection(){} // RVA: 0x7FFD54037510
        public void iplUnitySetHRTF(){} // RVA: 0x7FFD540375C0
        public void iplUnitySetSimulationSettings(){} // RVA: 0x7FFD54037640
        public void iplUnitySetReverbSource(){} // RVA: 0x7FFD540376F0
        public void iplUnityAddSource(){} // RVA: 0x7FFD54037770
        public void iplUnityRemoveSource(){} // RVA: 0x7FFD540377F0
        public void iplUnityTerminate(){} // RVA: 0x7FFD54037870
        public void iplUnitySetHRTFDisabled(){} // RVA: 0x7FFD540378E0
        public void iplUnitySetListenerNearFieldScale(){} // RVA: 0x7FFD54037960
        public void iplUnitySetPerEarDirectionalityOptions(){} // RVA: 0x7FFD540379E0
        public void iplUnitySetDirectivityFadeoutRadius(){} // RVA: 0x7FFD54037A70
        public void iplUnitySetDebugLogFunction(){} // RVA: 0x7FFD54037AF0
        public void iplPreloadHRTF(){} // RVA: 0x7FFD54037B80
        public void iplUnitySetNearFieldILDNudgeData(){} // RVA: 0x7FFD54037C30
        public void iplApplyGainNudge(){} // RVA: 0x7FFD54037CB0
    }

    public class AudioEngineAmbisonicSource : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void Destroy(){} // RVA: 0x7FFD4E341310
        public void UpdateParameters(){} // RVA: 0x7FFD4E341310
        public void GetParameters(){} // RVA: 0x7FFD4E341310
        public void Create(){} // RVA: 0x7FFD540273A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AudioEngineSource : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void Destroy(){} // RVA: 0x7FFD4E341310
        public void UpdateParameters(){} // RVA: 0x7FFD4E341310
        public void GetParameters(){} // RVA: 0x7FFD4E341310
        public void Create(){} // RVA: 0x7FFD540273F0
        public void CreateFMODStudioAudioEngineSource(){} // RVA: 0x7FFD54027630
        public void CreateWwiseAudioEngineSource(){} // RVA: 0x7FFD54027720
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AudioEngineState : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void Destroy(){} // RVA: 0x7FFD4E341310
        public void SetHRTF(){} // RVA: 0x7FFD4E341310
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFD4E341310
        public void SetReverbSource(){} // RVA: 0x7FFD4E341310
        public void Create(){} // RVA: 0x7FFD54027810
        public void CreateFMODStudioAudioEngineState(){} // RVA: 0x7FFD54027A50
        public void CreateWwiseAudioEngineState(){} // RVA: 0x7FFD54027B40
        public void SetHRTFDisabled(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AudioSettings : ValueType
    {
    }

    public class AudioSourceAttenuationData : ValueType
    {
    }

    public class BakedDataIdentifier : ValueType
    {
    }

    public class Baker : Object
    {
        // ── Methods ──
        public void BeginBake(){} // RVA: 0x7FFD54028050
        public void EndBake(){} // RVA: 0x7FFD540288C0
        public void IsBakeActive(){} // RVA: 0x7FFD54028AC0
        public void DrawProgressBar(){} // RVA: 0x7FFD4E426850
        public void UpdateBakeProgress(){} // RVA: 0x7FFD4E341310
        public void CancelBake(){} // RVA: 0x7FFD54028B20
        public void AdvanceProgress(){} // RVA: 0x7FFD4E341310
        public void InEditorUpdate(){} // RVA: 0x7FFD4E341310
        public void BakeThread(){} // RVA: 0x7FFD54028C60
        public void .cctor(){} // RVA: 0x7FFD5402A870
    }

    public class Common : Object
    {
        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7FFD4EEA9B70 | overloaded x2
        public void ConvertTransform(){} // RVA: 0x7FFD5402A9D0
        public void TransposeMatrix(){} // RVA: 0x7FFD5402AC60
        public void TransformMatrix(){} // RVA: 0x7FFD5402AC60
        public void ConvertString(){} // RVA: 0x7FFD5402AD10
        public void GetStreamingAssetsFileName(){} // RVA: 0x7FFD5402AD90
        public void HumanReadableDataSize(){} // RVA: 0x7FFD5402AE60
    }

    public class Constants : Object
    {
    }

    public class Context : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402B400 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402B4A0
        public void Release(){} // RVA: 0x7FFD5402B4E0
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void LogMessage(){} // RVA: 0x7FFD5402B560
    }

    public class DistanceAttenuationModel : ValueType
    {
    }

    public class EmbreeDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402B750 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402B7F0
        public void Release(){} // RVA: 0x7FFD5402B830
        public void Get(){} // RVA: 0x7FFD4E35C380
    }

    public class HRTF : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402BE10 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD5402BEB0
        public void Release(){} // RVA: 0x7FFD5402BEF0
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void dBToGain(){} // RVA: 0x7FFD5402BF70
    }

    public class InstancedMesh : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402C1D0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402C270
        public void Release(){} // RVA: 0x7FFD5402C2B0
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void AddToScene(){} // RVA: 0x7FFD5402C330
        public void RemoveFromScene(){} // RVA: 0x7FFD5402C3E0
        public void UpdateTransform(){} // RVA: 0x7FFD5402C490
    }

    public class LogCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E49D2A0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
        public void BeginInvoke(){} // RVA: 0x7FFD54031110
        public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
    }

    public class OpenCLDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402CB10 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402CBB0
        public void Release(){} // RVA: 0x7FFD5402CBF0
        public void Get(){} // RVA: 0x7FFD4E35C380
    }

    public class ProbeBatch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402D370 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD5402D460
        public void Release(){} // RVA: 0x7FFD5402D4A0
        public void Get(){} // RVA: 0x7FFD4E3447C0
        public void Save(){} // RVA: 0x7FFD5402D570
        public void AddProbeArray(){} // RVA: 0x7FFD5402D6A0
        public void AddProbe(){} // RVA: 0x7FFD5402D740
        public void Commit(){} // RVA: 0x7FFD5402D7E0
        public void RemoveData(){} // RVA: 0x7FFD5402D860
        public void GetDataSize(){} // RVA: 0x7FFD5402D8F0
    }

    public class RadeonRaysDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402DAB0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402DB50
        public void Release(){} // RVA: 0x7FFD5402DB90
        public void Get(){} // RVA: 0x7FFD4E35C380
    }

    public class SOFAFile : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402FCC0
    }

    public class Scene : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402E2D0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD5402E3C0
        public void Release(){} // RVA: 0x7FFD5402E400
        public void Get(){} // RVA: 0x7FFD4E3447C0
        public void Save(){} // RVA: 0x7FFD5402E4D0
        public void SaveOBJ(){} // RVA: 0x7FFD5402E5E0
        public void NotifyAddObject(){} // RVA: 0x7FFD5402E690
        public void NotifyRemoveObject(){} // RVA: 0x7FFD5402E6A0
        public void GetNumObjects(){} // RVA: 0x7FFD4E4FBBE0
        public void Commit(){} // RVA: 0x7FFD5402E6B0
    }

    public class SerializedData : ScriptableObject
    {
        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SerializedObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402E980 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD5402EA20
        public void Release(){} // RVA: 0x7FFD5402EA60
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void GetSize(){} // RVA: 0x7FFD5402EB40
        public void GetData(){} // RVA: 0x7FFD5402EBC0
        public void WriteToFile(){} // RVA: 0x7FFD5402EC40
        public void FlushWrite(){} // RVA: 0x7FFD4E341310
        public void FlushAllWrites(){} // RVA: 0x7FFD5402EF30
    }

    public class Simulator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5402F200 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD5402F2A0
        public void Release(){} // RVA: 0x7FFD5402F2E0
        public void Get(){} // RVA: 0x7FFD4E35C380
        public void SetScene(){} // RVA: 0x7FFD5402F360
        public void AddProbeBatch(){} // RVA: 0x7FFD5402F400
        public void RemoveProbeBatch(){} // RVA: 0x7FFD5402F4A0
        public void SetSharedInputs(){} // RVA: 0x7FFD5402F540
        public void Commit(){} // RVA: 0x7FFD5402F560
        public void RunDirect(){} // RVA: 0x7FFD5402F5E0
        public void RunReflections(){} // RVA: 0x7FFD5402F660
        public void RunPathing(){} // RVA: 0x7FFD5402F6E0
    }

    public class Sphere : ValueType
    {
    }

    public class StaticMesh : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54030B20 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFD54030C10
        public void Release(){} // RVA: 0x7FFD54030C50
        public void Get(){} // RVA: 0x7FFD4E3447C0
        public void Save(){} // RVA: 0x7FFD54030D20
        public void AddToScene(){} // RVA: 0x7FFD54030E30
        public void RemoveFromScene(){} // RVA: 0x7FFD54030EE0
    }

    public class SteamAudioAmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54037D60
        public void Start(){} // RVA: 0x7FFD54037EA0
        public void OnDestroy(){} // RVA: 0x7FFD54037ED0
        public void OnEnable(){} // RVA: 0x7FFD54037EA0
        public void Update(){} // RVA: 0x7FFD54037EA0
        public void .ctor(){} // RVA: 0x7FFD4E39B060
    }

    public class SteamAudioBakedListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFD4E39CCD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFD4E5F0140
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFD54037EF0
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFD54037F20
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFD54037F50
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD54038070
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFD54038640
        public void BeginBake(){} // RVA: 0x7FFD540387A0
        public void CacheIdentifier(){} // RVA: 0x7FFD54038E70
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFD54038EA0
        public void .ctor(){} // RVA: 0x7FFD54038F60
    }

    public class SteamAudioBakedSource : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFD4E39CCD0
        public void GetProbeDataSizes(){} // RVA: 0x7FFD4E5F0140
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFD54037EF0
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFD54038FD0
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFD54039000
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD54039120
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFD540396F0
        public void BeginBake(){} // RVA: 0x7FFD54039850
        public void CacheIdentifier(){} // RVA: 0x7FFD54039F20
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFD54039F50
        public void .ctor(){} // RVA: 0x7FFD54038F60
    }

    public class SteamAudioDynamicObject : MonoBehaviour
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFD5403A010
        public void OnEnable(){} // RVA: 0x7FFD5403A040
        public void OnDisable(){} // RVA: 0x7FFD5403A0F0
        public void Update(){} // RVA: 0x7FFD5403A210
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamAudioGeometry : MonoBehaviour
    {
        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x7FFD5403A710
        public void GetNumTriangles(){} // RVA: 0x7FFD5403A910
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamAudioListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0x7FFD4E3E2080
        public void GetProbeDataSizes(){} // RVA: 0x7FFD4E3BC730
        public void GetSizeForProbeBatch(){} // RVA: 0x7FFD5403AB10
        public void GetProbeBatchesUsed(){} // RVA: 0x7FFD5403AB40
        public void Awake(){} // RVA: 0x7FFD5403AB70
        public void Reinitialize(){} // RVA: 0x7FFD5403AB80
        public void OnDestroy(){} // RVA: 0x7FFD5403AE20
        public void Start(){} // RVA: 0x7FFD5403AE40
        public void OnEnable(){} // RVA: 0x7FFD5403AEB0
        public void OnDisable(){} // RVA: 0x7FFD5403B050
        public void Update(){} // RVA: 0x7FFD5403AE40
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFD5403B1E0
        public void SetInputs(){} // RVA: 0x7FFD5403B210
        public void UpdateOutputs(){} // RVA: 0x7FFD4E341310
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD5403B6B0
        public void UpdateBakedDataStatistics(){} // RVA: 0x7FFD5403BB20
        public void BeginBake(){} // RVA: 0x7FFD5403BC80
        public void CacheIdentifier(){} // RVA: 0x7FFD5403C330
        public void CacheProbeBatchesUsed(){} // RVA: 0x7FFD5403C340
        public void .ctor(){} // RVA: 0x7FFD5403C400
    }

    public class SteamAudioManager : MonoBehaviour
    {
        public object Singleton;
        public object Context;
        public object CurrentHRTF;
        public object EmbreeDevice;
        public object OpenCLDevice;
        public object RadeonRaysDevice;
        public object TrueAudioNextDevice;
        public object CurrentScene;
        public object Simulator;
        public object AudioSettings;

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFD5403C460
        public void get_Context(){} // RVA: 0x7FFD5403C4A0
        public void get_CurrentHRTF(){} // RVA: 0x7FFD5403C4F0
        public void get_EmbreeDevice(){} // RVA: 0x7FFD5403C560
        public void get_OpenCLDevice(){} // RVA: 0x7FFD5403C5C0
        public void get_RadeonRaysDevice(){} // RVA: 0x7FFD5403C620
        public void get_TrueAudioNextDevice(){} // RVA: 0x7FFD5403C680
        public void get_CurrentScene(){} // RVA: 0x7FFD5403C6E0
        public void get_Simulator(){} // RVA: 0x7FFD5403C730
        public void get_AudioSettings(){} // RVA: 0x7FFD5403C780
        public void GetAudioEngineState(){} // RVA: 0x7FFD5403C7D0
        public void GetSteamAudioListener(){} // RVA: 0x7FFD5403C820
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x7FFD5403C940
        public void GetSceneType(){} // RVA: 0x7FFD5403C970
        public void GetReflectionEffectType(){} // RVA: 0x7FFD5403CA10
        public void GetPerspectiveCorrection(){} // RVA: 0x7FFD5403CA80
        public void GetMainCamera(){} // RVA: 0x7FFD4EAF1F40
        public void GetSimulationSettings(){} // RVA: 0x7FFD5403CFB0
        public void OnApplicationStart(){} // RVA: 0x7FFD5403D3E0
        public void LoadHRTFFromFile(){} // RVA: 0x7FFD5403E200
        public void UnloadHRTFByName(){} // RVA: 0x7FFD5403E3D0
        public void SetHRTFAtIndex(){} // RVA: 0x7FFD5403E6F0
        public void OnApplicationQuit(){} // RVA: 0x7FFD5403E7D0
        public void OnSceneLoaded(){} // RVA: 0x7FFD5403E820
        public void OnSceneUnloaded(){} // RVA: 0x7FFD5403E980
        public void NotifyAudioListenerChanged(){} // RVA: 0x7FFD5403E990
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x7FFD5403E9E0
        public void NotifyMainCameraChanged(){} // RVA: 0x7FFD5403EC00
        public void ScheduleCommitScene(){} // RVA: 0x7FFD5403ECA0
        public void LateUpdate(){} // RVA: 0x7FFD5403ECF0
        public void RunSimulationInternal(){} // RVA: 0x7FFD5403FD80
        public void RunSimulation(){} // RVA: 0x7FFD5403FEA0
        public void Initialize(){} // RVA: 0x7FFD5403FF00
        public void ShutDown(){} // RVA: 0x7FFD540400A0
        public void Reinitialize(){} // RVA: 0x7FFD540407D0
        public void AddSource(){} // RVA: 0x7FFD540418D0
        public void RemoveSource(){} // RVA: 0x7FFD54041960
        public void AddListener(){} // RVA: 0x7FFD540419E0
        public void RemoveListener(){} // RVA: 0x7FFD54041A70
        public void ExportDynamicObject(){} // RVA: 0x7FFD54041AF0
        public void ExportDynamicObjectsInArray(){} // RVA: 0x7FFD54041DD0
        public void GetDynamicObjectsInScene(){} // RVA: 0x7FFD540420A0
        public void LoadScene(){} // RVA: 0x7FFD54042200
        public void LoadDynamicObject(){} // RVA: 0x7FFD540422C0
        public void UnloadDynamicObject(){} // RVA: 0x7FFD54042890
        public void GetGameObjectsForExport(){} // RVA: 0x7FFD54042AA0
        public void GetNumVertices(){} // RVA: 0x7FFD54043290
        public void GetNumTriangles(){} // RVA: 0x7FFD540437C0
        public void ClosestHit(){} // RVA: 0x7FFD54043D00
        public void AnyHit(){} // RVA: 0x7FFD54044070
        public void AutoInitialize(){} // RVA: 0x7FFD54044290
        public void FirstAutoInitialize(){} // RVA: 0x7FFD540442E0
        public void ExportScene(){} // RVA: 0x7FFD54044340
        public void Export(){} // RVA: 0x7FFD540446F0
        public void CreateScene(){} // RVA: 0x7FFD54044BC0
        public void Load(){} // RVA: 0x7FFD54044FE0
        public void RemoveAllDynamicObjects(){} // RVA: 0x7FFD54045060
        public void RemoveAllAdditiveScenes(){} // RVA: 0x7FFD540455F0
        public void GetMaterialBufferForTransform(){} // RVA: 0x7FFD54045720
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7FFD54045A80
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x7FFD54045BA0
        public void IsDynamicSubObject(){} // RVA: 0x7FFD54045C40
        public void IsActiveInHierarchy(){} // RVA: 0x7FFD54045E00
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x7FFD54045FD0
        public void GetDynamicObjectInParent(){} // RVA: 0x7FFD540465E0
        public void GetVertices(){} // RVA: 0x7FFD54046820
        public void GetTriangles(){} // RVA: 0x7FFD54047680
        public void FixupTriangleIndices(){} // RVA: 0x7FFD54047D40
        public void GetTerrainSimplificationLevel(){} // RVA: 0x7FFD54047DB0
        public void GetMaterialMapping(){} // RVA: 0x7FFD54047E10
        public void GetMaterialForGameObject(){} // RVA: 0x7FFD54048670
        public void GetOBJFileName(){} // RVA: 0x7FFD54048AF0 | overloaded x2
        public void GetDataAsset(){} // RVA: 0x7FFD54048FC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54048FE0
    }

    public class SteamAudioMaterial : ScriptableObject
    {
        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x7FFD54049320
        public void .ctor(){} // RVA: 0x7FFD54049360
    }

    public class SteamAudioProbeBatch : MonoBehaviour
    {
        // ── Methods ──
        public void GetAsset(){} // RVA: 0x7FFD540493A0
        public void GetNumProbes(){} // RVA: 0x7FFD540495A0
        public void GetNumLayers(){} // RVA: 0x7FFD540495C0
        public void GetProbeBatch(){} // RVA: 0x7FFD54049610
        public void Awake(){} // RVA: 0x7FFD54049630
        public void OnDestroy(){} // RVA: 0x7FFD540497F0
        public void OnEnable(){} // RVA: 0x7FFD54049810
        public void OnDisable(){} // RVA: 0x7FFD54049900
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD54049A30
        public void GenerateProbes(){} // RVA: 0x7FFD54049F10
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x7FFD5404ACB0
        public void GetSizeForLayer(){} // RVA: 0x7FFD5404B150
        public void GetInfoForLayer(){} // RVA: 0x7FFD5404B300
        public void ResetLayers(){} // RVA: 0x7FFD5404B3A0
        public void AddLayer(){} // RVA: 0x7FFD5404B410
        public void RemoveLayer(){} // RVA: 0x7FFD5404B540
        public void AddOrUpdateLayer(){} // RVA: 0x7FFD5404B770
        public void UpdateGameObjectStatistics(){} // RVA: 0x7FFD5404BA50
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFD5404BB40
        public void BeginBake(){} // RVA: 0x7FFD5404BB80
        public void .ctor(){} // RVA: 0x7FFD5404C110
    }

    public class SteamAudioReverbData : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD5404C210
        public void GetImpulseResponseSize(){} // RVA: 0x7FFD5404C370
        public void GetEnergyFieldData(){} // RVA: 0x7FFD5404C390
        public void GetEnergyFieldSize(){} // RVA: 0x7FFD5404C3D0
        public void GetImpulseResponseData(){} // RVA: 0x7FFD5404C3F0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SteamAudioReverbDataPoint : MonoBehaviour
    {
        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x7FFD4E341310
        public void GetAssetFolderPath(){} // RVA: 0x7FFD5404C430
        public void GetBakedDataIdentifier(){} // RVA: 0x7FFD5403B1E0
        public void EnsureValidData(){} // RVA: 0x7FFD4E341310
        public void BeginBake(){} // RVA: 0x7FFD5404C470
        public void UpdateEnergyField(){} // RVA: 0x7FFD5404CBE0
        public void UpdateImpulseResponse(){} // RVA: 0x7FFD5404CFC0
        public void WriteReverbDataToFile(){} // RVA: 0x7FFD5404D360
        public void FlushWrite(){} // RVA: 0x7FFD4E341310
        public void FlushAllWrites(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD5404D4F0
    }

    public class SteamAudioSettings : ScriptableObject
    {
        public object Singleton;

        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x7FFD5404D590
        public void .ctor(){} // RVA: 0x7FFD5404D890
    }

    public class SteamAudioSource : MonoBehaviour
    {
        public URA.DateTime<string,ector> interpolation;

        // ── Methods ──
        public void get_interpolation(){} // RVA: 0x7FFD4E433AF0
        public void Awake(){} // RVA: 0x7FFD5404D9B0
        public void LazyInitSource(){} // RVA: 0x7FFD5404DC80
        public void AssignHandle(){} // RVA: 0x7FFD5404DF40
        public void SetAttenuationModel(){} // RVA: 0x7FFD5404E1D0
        public void UpdateParameters(){} // RVA: 0x7FFD5404E5F0
        public void Start(){} // RVA: 0x7FFD5404E620
        public void OnDestroy(){} // RVA: 0x7FFD5404E650
        public void OnEnable(){} // RVA: 0x7FFD5404E820
        public void OnDisable(){} // RVA: 0x7FFD5404E910
        public void LateUpdate(){} // RVA: 0x7FFD5404E5F0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD5404EA40
        public void SetInputs(){} // RVA: 0x7FFD5404F160
        public void GetOutputs(){} // RVA: 0x7FFD5404FFA0
        public void GetSource(){} // RVA: 0x7FFD4E964340
        public void UpdateOutputs(){} // RVA: 0x7FFD540500F0
        public void InitializeDeformedSphereMesh(){} // RVA: 0x7FFD540502B0
        public void DeformSphereMesh(){} // RVA: 0x7FFD54050B40
        public void DeformedVertex(){} // RVA: 0x7FFD54050FA0
        public void EvaluateDistanceCurve(){} // RVA: 0x7FFD54051020
        public void .ctor(){} // RVA: 0x7FFD54051180
        public void .cctor(){} // RVA: 0x7FFD540514B0
    }

    public class SteamAudioStaticMesh : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54051640
        public void OnDestroy(){} // RVA: 0x7FFD54051870
        public void OnEnable(){} // RVA: 0x7FFD54051A30
        public void OnDisable(){} // RVA: 0x7FFD54051AE0
        public void Update(){} // RVA: 0x7FFD54051C00
        public void .ctor(){} // RVA: 0x7FFD54051E40
        public void <Update>b__8_0(){} // RVA: 0x7FFD54051F10
    }

    public class TrueAudioNextDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54052280 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD54052320
        public void Release(){} // RVA: 0x7FFD54052360
        public void Get(){} // RVA: 0x7FFD4E35C380
    }

    public class UnityAudioEngineAmbisonicSource : AudioEngineAmbisonicSource
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD540523E0
        public void UpdateParameters(){} // RVA: 0x7FFD54052490
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityAudioEngineSource : AudioEngineSource
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD540525A0
        public void Destroy(){} // RVA: 0x7FFD54052810
        public void UpdateParameters(){} // RVA: 0x7FFD54052950
        public void .ctor(){} // RVA: 0x7FFD50C95C30
    }

    public class UnityAudioEngineState : AudioEngineState
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD540538C0
        public void Destroy(){} // RVA: 0x7FFD54037870
        public void SetHRTF(){} // RVA: 0x7FFD54053A30
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFD54053A40
        public void SetReverbSource(){} // RVA: 0x7FFD54053A90
        public void SetHRTFDisabled(){} // RVA: 0x7FFD54053B20
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Vector3 : ValueType
    {
    }

}