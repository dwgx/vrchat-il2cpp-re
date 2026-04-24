// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 44
// Methods: 501

namespace ThirdParty.Other.SteamAudio
{
    public class API : Object
    {
        // ── Original Methods ──
        public void iplContextCreate(){} // RVA: 0x7ffaae633ef0
        public void iplContextRetain(){} // RVA: 0x7ffaae634050
        public void iplContextRelease(){} // RVA: 0x7ffaae6340d0
        public void iplCalculateRelativeDirection(){} // RVA: 0x7ffaae634150
        public void iplSerializedObjectCreate(){} // RVA: 0x7ffaae634280
        public void iplSerializedObjectRetain(){} // RVA: 0x7ffaae634320
        public void iplSerializedObjectRelease(){} // RVA: 0x7ffaae6343a0
        public void iplSerializedObjectGetSize(){} // RVA: 0x7ffaae634420
        public void iplSerializedObjectGetData(){} // RVA: 0x7ffaae6344a0
        public void iplEmbreeDeviceCreate(){} // RVA: 0x7ffaae634520
        public void iplEmbreeDeviceRetain(){} // RVA: 0x7ffaae6345c0
        public void iplEmbreeDeviceRelease(){} // RVA: 0x7ffaae634640
        public void iplOpenCLDeviceListCreate(){} // RVA: 0x7ffaae6346c0
        public void iplOpenCLDeviceListRetain(){} // RVA: 0x7ffaae634760
        public void iplOpenCLDeviceListRelease(){} // RVA: 0x7ffaae6347e0
        public void iplOpenCLDeviceListGetNumDevices(){} // RVA: 0x7ffaae634860
        public void iplOpenCLDeviceListGetDeviceDesc(){} // RVA: 0x7ffaae6348e0
        public void iplOpenCLDeviceCreate(){} // RVA: 0x7ffaae634ad0
        public void iplOpenCLDeviceRetain(){} // RVA: 0x7ffaae634b80
        public void iplOpenCLDeviceRelease(){} // RVA: 0x7ffaae634c00
        public void iplRadeonRaysDeviceCreate(){} // RVA: 0x7ffaae634c80
        public void iplRadeonRaysDeviceRetain(){} // RVA: 0x7ffaae634d20
        public void iplRadeonRaysDeviceRelease(){} // RVA: 0x7ffaae634da0
        public void iplTrueAudioNextDeviceCreate(){} // RVA: 0x7ffaae634e20
        public void iplTrueAudioNextDeviceRetain(){} // RVA: 0x7ffaae634ec0
        public void iplTrueAudioNextDeviceRelease(){} // RVA: 0x7ffaae634f40
        public void iplSceneCreate(){} // RVA: 0x7ffaae634fc0
        public void iplSceneRetain(){} // RVA: 0x7ffaae635150
        public void iplSceneRelease(){} // RVA: 0x7ffaae6351d0
        public void iplSceneLoad(){} // RVA: 0x7ffaae635250
        public void iplSceneSave(){} // RVA: 0x7ffaae635400
        public void iplSceneSaveOBJ(){} // RVA: 0x7ffaae635490
        public void iplSceneCommit(){} // RVA: 0x7ffaae635540
        public void iplStaticMeshCreate(){} // RVA: 0x7ffaae6355c0
        public void iplStaticMeshRetain(){} // RVA: 0x7ffaae635660
        public void iplStaticMeshRelease(){} // RVA: 0x7ffaae6356e0
        public void iplStaticMeshLoad(){} // RVA: 0x7ffaae635760
        public void iplStaticMeshSave(){} // RVA: 0x7ffaae635820
        public void iplStaticMeshAdd(){} // RVA: 0x7ffaae6358b0
        public void iplStaticMeshRemove(){} // RVA: 0x7ffaae635940
        public void iplInstancedMeshCreate(){} // RVA: 0x7ffaae6359d0
        public void iplInstancedMeshRetain(){} // RVA: 0x7ffaae635a70
        public void iplInstancedMeshRelease(){} // RVA: 0x7ffaae635af0
        public void iplInstancedMeshAdd(){} // RVA: 0x7ffaae635b70
        public void iplInstancedMeshRemove(){} // RVA: 0x7ffaae635c00
        public void iplInstancedMeshUpdateTransform(){} // RVA: 0x7ffaae635c90
        public void iplHRTFCreate(){} // RVA: 0x7ffaae635d50
        public void iplHRTFRetain(){} // RVA: 0x7ffaae635fd0
        public void iplHRTFRelease(){} // RVA: 0x7ffaae636050
        public void iplProbeArrayCreate(){} // RVA: 0x7ffaae6360d0
        public void iplProbeArrayRetain(){} // RVA: 0x7ffaae636160
        public void iplProbeArrayRelease(){} // RVA: 0x7ffaae6361e0
        public void iplProbeArrayGenerateProbes(){} // RVA: 0x7ffaae636260
        public void iplProbeArrayGetNumProbes(){} // RVA: 0x7ffaae636300
        public void iplProbeArrayGetProbe(){} // RVA: 0x7ffaae636380
        public void iplProbeBatchCreate(){} // RVA: 0x7ffaae636420
        public void iplProbeBatchRetain(){} // RVA: 0x7ffaae6364b0
        public void iplProbeBatchRelease(){} // RVA: 0x7ffaae636530
        public void iplProbeBatchLoad(){} // RVA: 0x7ffaae6365b0
        public void iplProbeBatchSave(){} // RVA: 0x7ffaae636650
        public void iplProbeBatchGetNumProbes(){} // RVA: 0x7ffaae6366e0
        public void iplProbeBatchAddProbe(){} // RVA: 0x7ffaae636760
        public void iplProbeBatchAddProbeArray(){} // RVA: 0x7ffaae636800
        public void iplProbeBatchRemoveProbe(){} // RVA: 0x7ffaae636890
        public void iplProbeBatchCommit(){} // RVA: 0x7ffaae636920
        public void iplProbeBatchRemoveData(){} // RVA: 0x7ffaae6369a0
        public void iplProbeBatchGetDataSize(){} // RVA: 0x7ffaae636a30
        public void iplProbeBatchGetEnergyField(){} // RVA: 0x7ffaae636ac0
        public void iplProbeBatchGetReverb(){} // RVA: 0x7ffaae636b70
        public void iplReflectionsBakerBake(){} // RVA: 0x7ffaae636c30
        public void iplReflectionsBakerCancelBake(){} // RVA: 0x7ffaae636ce0
        public void iplPathBakerBake(){} // RVA: 0x7ffaae636d60
        public void iplPathBakerCancelBake(){} // RVA: 0x7ffaae636e10
        public void iplSimulatorCreate(){} // RVA: 0x7ffaae636e90
        public void iplSimulatorRetain(){} // RVA: 0x7ffaae636f30
        public void iplSimulatorRelease(){} // RVA: 0x7ffaae636fb0
        public void iplSimulatorSetScene(){} // RVA: 0x7ffaae637030
        public void iplSimulatorAddProbeBatch(){} // RVA: 0x7ffaae6370c0
        public void iplSimulatorRemoveProbeBatch(){} // RVA: 0x7ffaae637150
        public void iplSimulatorSetSharedInputs(){} // RVA: 0x7ffaae6371e0
        public void iplSimulatorCommit(){} // RVA: 0x7ffaae637480
        public void iplSimulatorRunDirect(){} // RVA: 0x7ffaae637500
        public void iplSimulatorRunReflections(){} // RVA: 0x7ffaae637580
        public void iplSimulatorRunPathing(){} // RVA: 0x7ffaae637600
        public void iplSourceCreate(){} // RVA: 0x7ffaae637680
        public void iplSourceRetain(){} // RVA: 0x7ffaae637720
        public void iplSourceRelease(){} // RVA: 0x7ffaae6377a0
        public void iplSourceAdd(){} // RVA: 0x7ffaae637820
        public void iplSourceRemove(){} // RVA: 0x7ffaae6378b0
        public void iplSourceSetInputs(){} // RVA: 0x7ffaae637940
        public void iplSourceGetOutputs(){} // RVA: 0x7ffaae637c60
        public void iplDistanceAttenuationCalculate(){} // RVA: 0x7ffaae637d00
        public void iplAirAbsorptionCalculate(){} // RVA: 0x7ffaae637e80
        public void iplDirectivityCalculate(){} // RVA: 0x7ffaae638030
        public void iplEnergyFieldCreate(){} // RVA: 0x7ffaae6381d0
        public void iplEnergyFieldRetain(){} // RVA: 0x7ffaae638270
        public void iplEnergyFieldRelease(){} // RVA: 0x7ffaae6382f0
        public void iplEnergyFieldGetNumChannels(){} // RVA: 0x7ffaae638370
        public void iplEnergyFieldGetNumBins(){} // RVA: 0x7ffaae6383f0
        public void iplEnergyFieldGetData(){} // RVA: 0x7ffaae638470
        public void iplEnergyFieldGetChannel(){} // RVA: 0x7ffaae6384f0
        public void iplEnergyFieldGetBand(){} // RVA: 0x7ffaae638580
        public void iplEnergyFieldReset(){} // RVA: 0x7ffaae638620
        public void iplEnergyFieldCopy(){} // RVA: 0x7ffaae6386a0
        public void iplEnergyFieldSwap(){} // RVA: 0x7ffaae638730
        public void iplEnergyFieldAdd(){} // RVA: 0x7ffaae6387c0
        public void iplEnergyFieldScale(){} // RVA: 0x7ffaae638860
        public void iplEnergyFieldScaleAccum(){} // RVA: 0x7ffaae638900
        public void iplImpulseResponseCreate(){} // RVA: 0x7ffaae6389a0
        public void iplImpulseResponseRetain(){} // RVA: 0x7ffaae638a40
        public void iplImpulseResponseRelease(){} // RVA: 0x7ffaae638ac0
        public void iplImpulseResponseGetNumChannels(){} // RVA: 0x7ffaae638b40
        public void iplImpulseResponseGetNumSamples(){} // RVA: 0x7ffaae638bc0
        public void iplImpulseResponseGetData(){} // RVA: 0x7ffaae638c40
        public void iplImpulseResponseGetChannel(){} // RVA: 0x7ffaae638cc0
        public void iplImpulseResponseReset(){} // RVA: 0x7ffaae638d50
        public void iplImpulseResponseCopy(){} // RVA: 0x7ffaae638dd0
        public void iplImpulseResponseSwap(){} // RVA: 0x7ffaae638e60
        public void iplImpulseResponseAdd(){} // RVA: 0x7ffaae638ef0
        public void iplImpulseResponseScale(){} // RVA: 0x7ffaae638f90
        public void iplImpulseResponseScaleAccum(){} // RVA: 0x7ffaae639030
        public void iplReconstructorCreate(){} // RVA: 0x7ffaae6390d0
        public void iplReconstructorRetain(){} // RVA: 0x7ffaae639170
        public void iplReconstructorRelease(){} // RVA: 0x7ffaae6391f0
        public void iplReconstructorReconstruct(){} // RVA: 0x7ffaae639270
        public void iplUnityInitialize(){} // RVA: 0x7ffaae639320
        public void iplUnitySetPerspectiveCorrection(){} // RVA: 0x7ffaae6393a0
        public void iplUnitySetHRTF(){} // RVA: 0x7ffaae639450
        public void iplUnitySetSimulationSettings(){} // RVA: 0x7ffaae6394d0
        public void iplUnitySetReverbSource(){} // RVA: 0x7ffaae639580
        public void iplUnityAddSource(){} // RVA: 0x7ffaae639600
        public void iplUnityRemoveSource(){} // RVA: 0x7ffaae639680
        public void iplUnityTerminate(){} // RVA: 0x7ffaae639700
        public void iplUnitySetHRTFDisabled(){} // RVA: 0x7ffaae639770
        public void iplUnitySetListenerNearFieldScale(){} // RVA: 0x7ffaae6397f0
        public void iplUnitySetPerEarDirectionalityOptions(){} // RVA: 0x7ffaae639870
        public void iplUnitySetDirectivityFadeoutRadius(){} // RVA: 0x7ffaae639900
        public void iplUnitySetDebugLogFunction(){} // RVA: 0x7ffaae639980
        public void iplPreloadHRTF(){} // RVA: 0x7ffaae639a10
        public void iplUnitySetNearFieldILDNudgeData(){} // RVA: 0x7ffaae639ac0
        public void iplApplyGainNudge(){} // RVA: 0x7ffaae639b40
    }

    public class AudioEngineAmbisonicSource : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void Destroy(){} // RVA: 0x7ffaa8932310
        public void UpdateParameters(){} // RVA: 0x7ffaa8932310
        public void Create(){} // RVA: 0x7ffaae629230
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetParameters(){} // RVA: 0x7ffaa8932310
    }

    public class AudioEngineSource : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void Destroy(){} // RVA: 0x7ffaa8932310
        public void UpdateParameters(){} // RVA: 0x7ffaa8932310
        public void Create(){} // RVA: 0x7ffaae629280
        public void CreateFMODStudioAudioEngineSource(){} // RVA: 0x7ffaae6294c0
        public void CreateWwiseAudioEngineSource(){} // RVA: 0x7ffaae6295b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetParameters(){} // RVA: 0x7ffaa8932310
    }

    public class AudioEngineState : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void Destroy(){} // RVA: 0x7ffaa8932310
        public void Create(){} // RVA: 0x7ffaae6296a0
        public void CreateFMODStudioAudioEngineState(){} // RVA: 0x7ffaae6298e0
        public void CreateWwiseAudioEngineState(){} // RVA: 0x7ffaae6299d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetHRTF(){} // RVA: 0x7ffaa8932310
        public void SetPerspectiveCorrection(){} // RVA: 0x7ffaa8932310
        public void SetReverbSource(){} // RVA: 0x7ffaa8932310
        public void SetHRTFDisabled(){} // RVA: 0x7ffaa8932310
    }

    public class AudioSettings : ValueType
    {
    }

    public class AudioSourceAttenuationData : ValueType
    {
        public object maxDistance; // 0x373B2850
        public object minDistance; // 0x373B29D0
    }

    public class BakedDataIdentifier : ValueType
    {
        public object endpointInfluence; // 0x373B33A0
    }

    public class Baker : Object
    {
        public object sProgressCallbackPointer; // 0x3383D2F0
        public object sNumSubTasks; // 0x3383D2F0
        public object sTasks; // 0x3383D2F0

        // ── Original Methods ──
        public void EndBake(){} // RVA: 0x7ffaae62a750
        public void IsBakeActive(){} // RVA: 0x7ffaae62a950
        public void DrawProgressBar(){} // RVA: 0x7ffaa8a17850
        public void UpdateBakeProgress(){} // RVA: 0x7ffaa8932310
        public void CancelBake(){} // RVA: 0x7ffaae62a9b0
        public void AdvanceProgress(){} // RVA: 0x7ffaa8932310
        public void InEditorUpdate(){} // RVA: 0x7ffaa8932310
        public void BakeThread(){} // RVA: 0x7ffaae62aaf0
        public void .cctor(){} // RVA: 0x7ffaae62c700
        // ── Binary Analysis Named ──
        public void BeginBake(){} // RVA: 0x7ffaae629ee0
    }

    public class Common : Object
    {
        // ── Original Methods ──
        public void ConvertVector(){} // RVA: 0x7ffaa95135f0
        public void ConvertVector(){} // RVA: 0x7ffaa95135f0
        public void ConvertTransform(){} // RVA: 0x7ffaae62c860
        public void TransposeMatrix(){} // RVA: 0x7ffaae62caf0
        public void TransformMatrix(){} // RVA: 0x7ffaae62caf0
        public void ConvertString(){} // RVA: 0x7ffaae62cba0
        public void HumanReadableDataSize(){} // RVA: 0x7ffaae62ccf0
        // ── Binary Analysis Named ──
        public void GetStreamingAssetsFileName(){} // RVA: 0x7ffaae62cc20
    }

    public class Constants : Object
    {
        public object kVersionPatch; // 0x33CD3C80
    }

    public class Context : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62d290
        public void .ctor(){} // RVA: 0x7ffaae62d290
        public void Finalize(){} // RVA: 0x7ffaae62d330
        public void Release(){} // RVA: 0x7ffaae62d370
        public void LogMessage(){} // RVA: 0x7ffaae62d3f0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class DistanceAttenuationModel : ValueType
    {
        public object callback; // 0x373B29D0
    }

    public class EmbreeDevice : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62d5e0
        public void .ctor(){} // RVA: 0x7ffaae62d5e0
        public void Finalize(){} // RVA: 0x7ffaae62d680
        public void Release(){} // RVA: 0x7ffaae62d6c0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class HRTF : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62dca0
        public void .ctor(){} // RVA: 0x7ffaae62dca0
        public void .ctor(){} // RVA: 0x7ffaae62dca0
        public void Finalize(){} // RVA: 0x7ffaae62dd40
        public void Release(){} // RVA: 0x7ffaae62dd80
        public void dBToGain(){} // RVA: 0x7ffaae62de00
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class InstancedMesh : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62e060
        public void .ctor(){} // RVA: 0x7ffaae62e060
        public void Finalize(){} // RVA: 0x7ffaae62e100
        public void Release(){} // RVA: 0x7ffaae62e140
        public void AddToScene(){} // RVA: 0x7ffaae62e1c0
        public void RemoveFromScene(){} // RVA: 0x7ffaae62e270
        public void UpdateTransform(){} // RVA: 0x7ffaae62e320
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class OpenCLDevice : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62e9a0
        public void .ctor(){} // RVA: 0x7ffaae62e9a0
        public void Finalize(){} // RVA: 0x7ffaae62ea40
        public void Release(){} // RVA: 0x7ffaae62ea80
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class ProbeBatch : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62f200
        public void .ctor(){} // RVA: 0x7ffaae62f200
        public void .ctor(){} // RVA: 0x7ffaae62f200
        public void Finalize(){} // RVA: 0x7ffaae62f2f0
        public void Release(){} // RVA: 0x7ffaae62f330
        public void Save(){} // RVA: 0x7ffaae62f400
        public void AddProbeArray(){} // RVA: 0x7ffaae62f530
        public void AddProbe(){} // RVA: 0x7ffaae62f5d0
        public void Commit(){} // RVA: 0x7ffaae62f670
        public void RemoveData(){} // RVA: 0x7ffaae62f6f0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa89357c0
        public void GetDataSize(){} // RVA: 0x7ffaae62f780
    }

    public class RadeonRaysDevice : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae62f940
        public void .ctor(){} // RVA: 0x7ffaae62f940
        public void Finalize(){} // RVA: 0x7ffaae62f9e0
        public void Release(){} // RVA: 0x7ffaae62fa20
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class SOFAFile : ScriptableObject
    {
        public object volume; // 0x33AAC030

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae631b50
    }

    public class Scene : Object
    {
        public object mNumObjects; // 0x33C9ECE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae630160
        public void .ctor(){} // RVA: 0x7ffaae630160
        public void .ctor(){} // RVA: 0x7ffaae630160
        public void Finalize(){} // RVA: 0x7ffaae630250
        public void Release(){} // RVA: 0x7ffaae630290
        public void Save(){} // RVA: 0x7ffaae630360
        public void SaveOBJ(){} // RVA: 0x7ffaae630470
        public void NotifyAddObject(){} // RVA: 0x7ffaae630520
        public void NotifyRemoveObject(){} // RVA: 0x7ffaae630530
        public void Commit(){} // RVA: 0x7ffaae630540
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa89357c0
        public void GetNumObjects(){} // RVA: 0x7ffaa8aeced0
    }

    public class SerializedData : ScriptableObject
    {
        // ── Original Methods ──
        public void PromptForNewAsset(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SerializedObject : Object
    {
        public object sAssetsToFlush; // 0x3389CB40

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae630810
        public void .ctor(){} // RVA: 0x7ffaae630810
        public void .ctor(){} // RVA: 0x7ffaae630810
        public void Finalize(){} // RVA: 0x7ffaae6308b0
        public void Release(){} // RVA: 0x7ffaae6308f0
        public void WriteToFile(){} // RVA: 0x7ffaae630ad0
        public void FlushWrite(){} // RVA: 0x7ffaa8932310
        public void FlushAllWrites(){} // RVA: 0x7ffaae630dc0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
        public void GetSize(){} // RVA: 0x7ffaae6309d0
        public void GetData(){} // RVA: 0x7ffaae630a50
    }

    public class Simulator : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae631090
        public void .ctor(){} // RVA: 0x7ffaae631090
        public void Finalize(){} // RVA: 0x7ffaae631130
        public void Release(){} // RVA: 0x7ffaae631170
        public void AddProbeBatch(){} // RVA: 0x7ffaae631290
        public void RemoveProbeBatch(){} // RVA: 0x7ffaae631330
        public void Commit(){} // RVA: 0x7ffaae6313f0
        public void RunDirect(){} // RVA: 0x7ffaae631470
        public void RunReflections(){} // RVA: 0x7ffaae6314f0
        public void RunPathing(){} // RVA: 0x7ffaae631570
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
        public void SetScene(){} // RVA: 0x7ffaae6311f0
        public void SetSharedInputs(){} // RVA: 0x7ffaae6313d0
    }

    public class Sphere : ValueType
    {
        public object x; // 0x373B3C00
    }

    public class StaticMesh : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae6329b0
        public void .ctor(){} // RVA: 0x7ffaae6329b0
        public void .ctor(){} // RVA: 0x7ffaae6329b0
        public void Finalize(){} // RVA: 0x7ffaae632aa0
        public void Release(){} // RVA: 0x7ffaae632ae0
        public void Save(){} // RVA: 0x7ffaae632bb0
        public void AddToScene(){} // RVA: 0x7ffaae632cc0
        public void RemoveFromScene(){} // RVA: 0x7ffaae632d70
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa89357c0
    }

    public class SteamAudioAmbisonicSource : MonoBehaviour
    {
        public object influenceRadius; // 0x33632AD0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae639bf0
        public void Start(){} // RVA: 0x7ffaae639d30
        public void OnDestroy(){} // RVA: 0x7ffaae639d60
        public void OnEnable(){} // RVA: 0x7ffaae639d30
        public void Update(){} // RVA: 0x7ffaae639d30
        public void .ctor(){} // RVA: 0x7ffaa898c060
    }

    public class SteamAudioBakedListener : MonoBehaviour
    {
        public object probeBatches; // 0x33632AD0
        public object mIdentifier; // 0x33632AD0

        // ── Original Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae639f00
        public void UpdateBakedDataStatistics(){} // RVA: 0x7ffaae63a4d0
        public void CacheIdentifier(){} // RVA: 0x7ffaae63ad00
        public void CacheProbeBatchesUsed(){} // RVA: 0x7ffaae63ad30
        public void .ctor(){} // RVA: 0x7ffaae63adf0
        // ── Binary Analysis Named ──
        public void GetTotalDataSize(){} // RVA: 0x7ffaa898dcd0
        public void GetProbeDataSizes(){} // RVA: 0x7ffaa8bf45b0
        public void GetSizeForProbeBatch(){} // RVA: 0x7ffaae639d80
        public void GetProbeBatchesUsed(){} // RVA: 0x7ffaae639db0
        public void GetBakedDataIdentifier(){} // RVA: 0x7ffaae639de0
        public void BeginBake(){} // RVA: 0x7ffaae63a630
    }

    public class SteamAudioBakedSource : MonoBehaviour
    {
        public object probeBatches; // 0x33659480
        public object mIdentifier; // 0x33659480
        public object mInstancedMesh; // 0x3357F780

        // ── Original Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae63afb0
        public void UpdateBakedDataStatistics(){} // RVA: 0x7ffaae63b580
        public void CacheIdentifier(){} // RVA: 0x7ffaae63bdb0
        public void CacheProbeBatchesUsed(){} // RVA: 0x7ffaae63bde0
        public void .ctor(){} // RVA: 0x7ffaae63adf0
        // ── Binary Analysis Named ──
        public void GetTotalDataSize(){} // RVA: 0x7ffaa898dcd0
        public void GetProbeDataSizes(){} // RVA: 0x7ffaa8bf45b0
        public void GetSizeForProbeBatch(){} // RVA: 0x7ffaae639d80
        public void GetProbeBatchesUsed(){} // RVA: 0x7ffaae63ae60
        public void GetBakedDataIdentifier(){} // RVA: 0x7ffaae63ae90
        public void BeginBake(){} // RVA: 0x7ffaae63b6e0
    }

    public class SteamAudioDynamicObject : MonoBehaviour
    {
        public object material; // 0x33C46340

        // ── Original Methods ──
        public void OnDestroy(){} // RVA: 0x7ffaae63bea0
        public void OnEnable(){} // RVA: 0x7ffaae63bed0
        public void OnDisable(){} // RVA: 0x7ffaae63bf80
        public void Update(){} // RVA: 0x7ffaae63c0a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SteamAudioGeometry : MonoBehaviour
    {
        public object terrainSimplificationLevel; // 0x33C46340

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetNumVertices(){} // RVA: 0x7ffaae63c5a0
        public void GetNumTriangles(){} // RVA: 0x7ffaae63c7a0
    }

    public class SteamAudioListener : MonoBehaviour
    {
        public object reverbType; // 0x3381DFC0
        public object mTotalDataSize; // 0x3381DFC0
        public object mProbeBatchesUsed; // 0x3381DFC0
        public object type; // 0x373B33A0
        public object center; // 0x373B3A80

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae63ca00
        public void Reinitialize(){} // RVA: 0x7ffaae63ca10
        public void OnDestroy(){} // RVA: 0x7ffaae63ccb0
        public void Start(){} // RVA: 0x7ffaae63ccd0
        public void OnEnable(){} // RVA: 0x7ffaae63cd40
        public void OnDisable(){} // RVA: 0x7ffaae63cee0
        public void Update(){} // RVA: 0x7ffaae63ccd0
        public void UpdateOutputs(){} // RVA: 0x7ffaa8932310
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae63d540
        public void UpdateBakedDataStatistics(){} // RVA: 0x7ffaae63d9b0
        public void CacheIdentifier(){} // RVA: 0x7ffaae63e1c0
        public void CacheProbeBatchesUsed(){} // RVA: 0x7ffaae63e1d0
        public void .ctor(){} // RVA: 0x7ffaae63e290
        // ── Binary Analysis Named ──
        public void GetTotalDataSize(){} // RVA: 0x7ffaa89d3080
        public void GetProbeDataSizes(){} // RVA: 0x7ffaa89ad730
        public void GetSizeForProbeBatch(){} // RVA: 0x7ffaae63c9a0
        public void GetProbeBatchesUsed(){} // RVA: 0x7ffaae63c9d0
        public void GetBakedDataIdentifier(){} // RVA: 0x7ffaae63d070
        public void SetInputs(){} // RVA: 0x7ffaae63d0a0
        public void BeginBake(){} // RVA: 0x7ffaae63db10
    }

    public class SteamAudioManager : MonoBehaviour
    {
        public object mNumCPUCores; // 0x33A4CF40
        public object mHRTFs; // 0x33A4CF40
        public object mOpenCLDevice; // 0x33A4CF40
        public object mRadeonRaysInitFailed; // 0x33A4CF40
        public object mCurrentScene; // 0x33A4CF40
        public object mSimulator; // 0x33A4CF40
        public object mListenerComponent; // 0x33A4CF40
        public object mRayHits; // 0x33A4CF40
        public object mSimulationThreadWaitHandle; // 0x33A4CF40
        public object mSimulationUpdateTimeElapsed; // 0x33A4CF40
        public object hasGeometryComponentsInScene; // 0x33A4CF40
        public object firstLoadComplete; // 0x33A4CF40

        // ── Original Methods ──
        public void get_Singleton(){} // RVA: 0x7ffaae63e2f0
        public void get_Context(){} // RVA: 0x7ffaae63e330
        public void get_CurrentHRTF(){} // RVA: 0x7ffaae63e380
        public void get_EmbreeDevice(){} // RVA: 0x7ffaae63e3f0
        public void get_OpenCLDevice(){} // RVA: 0x7ffaae63e450
        public void get_RadeonRaysDevice(){} // RVA: 0x7ffaae63e4b0
        public void get_TrueAudioNextDevice(){} // RVA: 0x7ffaae63e510
        public void get_CurrentScene(){} // RVA: 0x7ffaae63e570
        public void get_Simulator(){} // RVA: 0x7ffaae63e5c0
        public void get_AudioSettings(){} // RVA: 0x7ffaae63e610
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x7ffaae63e7d0
        public void OnApplicationStart(){} // RVA: 0x7ffaae63f270
        public void LoadHRTFFromFile(){} // RVA: 0x7ffaae640090
        public void UnloadHRTFByName(){} // RVA: 0x7ffaae640260
        public void OnApplicationQuit(){} // RVA: 0x7ffaae640660
        public void OnSceneLoaded(){} // RVA: 0x7ffaae6406b0
        public void OnSceneUnloaded(){} // RVA: 0x7ffaae640810
        public void NotifyAudioListenerChanged(){} // RVA: 0x7ffaae640820
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x7ffaae640870
        public void NotifyMainCameraChanged(){} // RVA: 0x7ffaae640a90
        public void ScheduleCommitScene(){} // RVA: 0x7ffaae640b30
        public void LateUpdate(){} // RVA: 0x7ffaae640b80
        public void RunSimulationInternal(){} // RVA: 0x7ffaae641c10
        public void RunSimulation(){} // RVA: 0x7ffaae641d30
        public void Initialize(){} // RVA: 0x7ffaae641d90
        public void ShutDown(){} // RVA: 0x7ffaae641f30
        public void Reinitialize(){} // RVA: 0x7ffaae642730
        public void AddSource(){} // RVA: 0x7ffaae643830
        public void RemoveSource(){} // RVA: 0x7ffaae6438c0
        public void AddListener(){} // RVA: 0x7ffaae643940
        public void RemoveListener(){} // RVA: 0x7ffaae6439d0
        public void ExportDynamicObject(){} // RVA: 0x7ffaae643a50
        public void ExportDynamicObjectsInArray(){} // RVA: 0x7ffaae643d30
        public void LoadScene(){} // RVA: 0x7ffaae644160
        public void LoadDynamicObject(){} // RVA: 0x7ffaae644220
        public void UnloadDynamicObject(){} // RVA: 0x7ffaae6447f0
        public void ClosestHit(){} // RVA: 0x7ffaae645c60
        public void AnyHit(){} // RVA: 0x7ffaae645fd0
        public void AutoInitialize(){} // RVA: 0x7ffaae6461f0
        public void FirstAutoInitialize(){} // RVA: 0x7ffaae646240
        public void ExportScene(){} // RVA: 0x7ffaae6462a0
        public void Export(){} // RVA: 0x7ffaae646650
        public void CreateScene(){} // RVA: 0x7ffaae646b20
        public void Load(){} // RVA: 0x7ffaae646f40
        public void RemoveAllDynamicObjects(){} // RVA: 0x7ffaae646fc0
        public void RemoveAllAdditiveScenes(){} // RVA: 0x7ffaae647550
        public void IsDynamicSubObject(){} // RVA: 0x7ffaae647ba0
        public void IsActiveInHierarchy(){} // RVA: 0x7ffaae647d60
        public void FixupTriangleIndices(){} // RVA: 0x7ffaae649ca0
        public void .ctor(){} // RVA: 0x7ffaae64af40
        // ── Binary Analysis Named ──
        public void GetAudioEngineState(){} // RVA: 0x7ffaae63e660
        public void GetSteamAudioListener(){} // RVA: 0x7ffaae63e6b0
        public void GetSceneType(){} // RVA: 0x7ffaae63e800
        public void GetReflectionEffectType(){} // RVA: 0x7ffaae63e8a0
        public void GetPerspectiveCorrection(){} // RVA: 0x7ffaae63e910
        public void GetMainCamera(){} // RVA: 0x7ffaa9102670
        public void GetSimulationSettings(){} // RVA: 0x7ffaae63ee40
        public void SetHRTFAtIndex(){} // RVA: 0x7ffaae640580
        public void GetDynamicObjectsInScene(){} // RVA: 0x7ffaae644000
        public void GetGameObjectsForExport(){} // RVA: 0x7ffaae644a00
        public void GetNumVertices(){} // RVA: 0x7ffaae6451f0
        public void GetNumTriangles(){} // RVA: 0x7ffaae645720
        public void GetMaterialBufferForTransform(){} // RVA: 0x7ffaae647680
        public void GetStaticGameObjectsForExport(){} // RVA: 0x7ffaae6479e0
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x7ffaae647b00
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x7ffaae647f30
        public void GetDynamicObjectInParent(){} // RVA: 0x7ffaae648540
        public void GetVertices(){} // RVA: 0x7ffaae648780
        public void GetTriangles(){} // RVA: 0x7ffaae6495e0
        public void GetTerrainSimplificationLevel(){} // RVA: 0x7ffaae649d10
        public void GetMaterialMapping(){} // RVA: 0x7ffaae649d70
        public void GetMaterialForGameObject(){} // RVA: 0x7ffaae64a5d0
        public void GetOBJFileName(){} // RVA: 0x7ffaae64aa50
        public void GetOBJFileName(){} // RVA: 0x7ffaae64aa50
        public void GetDataAsset(){} // RVA: 0x7ffaae64af20
        public void GetDataAsset(){} // RVA: 0x7ffaae64af20
    }

    public class SteamAudioMaterial : ScriptableObject
    {
        public object highFreqAbsorption; // 0x334ADCA0
        public object midFreqTransmission; // 0x334ADCA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae64b2c0
        // ── Binary Analysis Named ──
        public void GetMaterial(){} // RVA: 0x7ffaae64b280
    }

    public class SteamAudioProbeBatch : MonoBehaviour
    {
        public object heightAboveFloor; // 0x33522C80
        public object mProbeSpheres; // 0x33522C80
        public object kProbeDrawSize; // 0x33522C80
        public object IList`1; // 0x844E8550

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae64b590
        public void OnDestroy(){} // RVA: 0x7ffaae64b750
        public void OnEnable(){} // RVA: 0x7ffaae64b770
        public void OnDisable(){} // RVA: 0x7ffaae64b860
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae64b990
        public void GenerateProbes(){} // RVA: 0x7ffaae64be70
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x7ffaae64cc10
        public void ResetLayers(){} // RVA: 0x7ffaae64d300
        public void AddLayer(){} // RVA: 0x7ffaae64d370
        public void RemoveLayer(){} // RVA: 0x7ffaae64d4a0
        public void AddOrUpdateLayer(){} // RVA: 0x7ffaae64d6d0
        public void UpdateGameObjectStatistics(){} // RVA: 0x7ffaae64d9b0
        public void .ctor(){} // RVA: 0x7ffaae64e070
        // ── Binary Analysis Named ──
        public void GetAsset(){} // RVA: 0x7ffaae64b300
        public void GetNumProbes(){} // RVA: 0x7ffaae64b500
        public void GetNumLayers(){} // RVA: 0x7ffaae64b520
        public void GetProbeBatch(){} // RVA: 0x7ffaae64b570
        public void GetSizeForLayer(){} // RVA: 0x7ffaae64d0b0
        public void GetInfoForLayer(){} // RVA: 0x7ffaae64d260
        public void GetBakedDataIdentifier(){} // RVA: 0x7ffaae64daa0
        public void BeginBake(){} // RVA: 0x7ffaae64dae0
    }

    public class SteamAudioReverbData : ScriptableObject
    {
        public object reverbEnergyFieldNumChannels; // 0x33BEC660
        public object reverbIR; // 0x33BEC660
        public object sampleRate; // 0x337DF2A0
        public object storeEnergyField; // 0x337DF2A0

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaae64e170
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetImpulseResponseSize(){} // RVA: 0x7ffaae64e2d0
        public void GetEnergyFieldData(){} // RVA: 0x7ffaae64e2f0
        public void GetEnergyFieldSize(){} // RVA: 0x7ffaae64e330
        public void GetImpulseResponseData(){} // RVA: 0x7ffaae64e350
    }

    public class SteamAudioReverbDataPoint : MonoBehaviour
    {
        public object reverbDuration; // 0x337DF2A0
        public object reverbData; // 0x337DF2A0
        public object Unity; // 0x81A3D050

        // ── Original Methods ──
        public void CreateFolderRecursively(){} // RVA: 0x7ffaa8932310
        public void EnsureValidData(){} // RVA: 0x7ffaa8932310
        public void UpdateEnergyField(){} // RVA: 0x7ffaae64eb40
        public void UpdateImpulseResponse(){} // RVA: 0x7ffaae64ef20
        public void WriteReverbDataToFile(){} // RVA: 0x7ffaae64f2c0
        public void FlushWrite(){} // RVA: 0x7ffaa8932310
        public void FlushAllWrites(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaae64f450
        // ── Binary Analysis Named ──
        public void GetAssetFolderPath(){} // RVA: 0x7ffaae64e390
        public void GetBakedDataIdentifier(){} // RVA: 0x7ffaae63d070
        public void BeginBake(){} // RVA: 0x7ffaae64e3d0
    }

    public class SteamAudioSettings : ScriptableObject
    {
        public object perspectiveCorrection; // 0x33C9F8F0
        public object hrtfNormalizationType; // 0x33C9F8F0
        public object sceneType; // 0x33C9F8F0
        public object realTimeRays; // 0x33C9F8F0
        public object realTimeAmbisonicOrder; // 0x33C9F8F0
        public object realTimeIrradianceMinDistance; // 0x33C9F8F0
        public object bakingRays; // 0x33C9F8F0
        public object bakingAmbisonicOrder; // 0x33C9F8F0
        public object bakingVisibilitySamples; // 0x33C9F8F0
        public object bakingVisibilityRange; // 0x33C9F8F0
        public object simulationUpdateInterval; // 0x33C9F8F0
        public object hybridReverbOverlapPercent; // 0x33C9F8F0
        public object fractionComputeUnitsForIRUpdate; // 0x33C9F8F0
        public object TANAmbisonicOrder; // 0x33C9F8F0
        public object sSingleton; // 0x33C9F8F0
        public object Singleton; // 0x1700000B

        // ── Original Methods ──
        public void get_Singleton(){} // RVA: 0x7ffaae64f4f0
        public void .ctor(){} // RVA: 0x7ffaae64f7f0
    }

    public class SteamAudioSource : MonoBehaviour
    {
        public object distanceAttenuation; // 0x3372F9F0
        public object airAbsorption; // 0x3372F9F0
        public object airAbsorptionMid; // 0x3372F9F0
        public object preGainRaw; // 0x3372F9F0
        public object directivity; // 0x3372F9F0
        public object dipoleWeightMid; // 0x3372F9F0
        public object dipolePowerMid; // 0x3372F9F0
        public object directivityValueMid; // 0x3372F9F0
        public object occlusionInput; // 0x3372F9F0
        public object occlusionSamples; // 0x3372F9F0
        public object transmissionType; // 0x3372F9F0
        public object transmissionMid; // 0x3372F9F0
        public object directMixLevel; // 0x3372F9F0
        public object useDistanceCurveForReflections; // 0x3372F9F0
        public object reverbTimeLow; // 0x3372F9F0
        public object hybridReverbEQLow; // 0x3372F9F0
        public object hybridReverbDelay; // 0x3372F9F0
        public object pathing; // 0x3372F9F0
        public object findAlternatePaths; // 0x3372F9F0
        public object applyHRTFToPathing; // 0x3372F9F0
        public object mSimulator; // 0x3372F9F0
        public object mSphereVertices; // 0x3372F9F0
        public object mDeformedSphereMeshMid; // 0x3372F9F0
        public object mAttenuationData; // 0x3372F9F0
        public object mThisHandle; // 0x3372F9F0
        public object initializedSource; // 0x3372F9F0
        public object minDistance; // 0x373B2850
        public object type; // 0x373B29D0
        public object userData; // 0x373B29D0
        public object 1; // 0x600357B

        // ── Original Methods ──
        public void get_interpolation(){} // RVA: 0x7ffaa8a24af0
        public void Awake(){} // RVA: 0x7ffaae64f910
        public void LazyInitSource(){} // RVA: 0x7ffaae64fbe0
        public void AssignHandle(){} // RVA: 0x7ffaae64fea0
        public void UpdateParameters(){} // RVA: 0x7ffaae650550
        public void Start(){} // RVA: 0x7ffaae650580
        public void OnDestroy(){} // RVA: 0x7ffaae6505b0
        public void OnEnable(){} // RVA: 0x7ffaae650780
        public void OnDisable(){} // RVA: 0x7ffaae650870
        public void LateUpdate(){} // RVA: 0x7ffaae650550
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae6509a0
        public void UpdateOutputs(){} // RVA: 0x7ffaae652050
        public void InitializeDeformedSphereMesh(){} // RVA: 0x7ffaae652210
        public void DeformSphereMesh(){} // RVA: 0x7ffaae652aa0
        public void DeformedVertex(){} // RVA: 0x7ffaae652f00
        public void EvaluateDistanceCurve(){} // RVA: 0x7ffaae652f80
        public void .ctor(){} // RVA: 0x7ffaae6530e0
        public void .cctor(){} // RVA: 0x7ffaae653410
        // ── Binary Analysis Named ──
        public void SetAttenuationModel(){} // RVA: 0x7ffaae650130
        public void SetInputs(){} // RVA: 0x7ffaae6510c0
        public void GetOutputs(){} // RVA: 0x7ffaae651f00
        public void GetSource(){} // RVA: 0x7ffaa8f7aa40
    }

    public class SteamAudioStaticMesh : MonoBehaviour
    {
        public object mStaticMesh; // 0x338B52A0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6535a0
        public void OnDestroy(){} // RVA: 0x7ffaae6537d0
        public void OnEnable(){} // RVA: 0x7ffaae653990
        public void OnDisable(){} // RVA: 0x7ffaae653a40
        public void Update(){} // RVA: 0x7ffaae653b60
        public void .ctor(){} // RVA: 0x7ffaae653da0
        public void <Update>b__8_0(){} // RVA: 0x7ffaae653e70
    }

    public class TrueAudioNextDevice : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae6541e0
        public void .ctor(){} // RVA: 0x7ffaae6541e0
        public void Finalize(){} // RVA: 0x7ffaae654280
        public void Release(){} // RVA: 0x7ffaae6542c0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa894d380
    }

    public class UnityAudioEngineAmbisonicSource : AudioEngineAmbisonicSource
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaae654340
        public void UpdateParameters(){} // RVA: 0x7ffaae6543f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnityAudioEngineSource : AudioEngineSource
    {
        public object mHandle; // 0x3395C9C0

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaae654500
        public void Destroy(){} // RVA: 0x7ffaae654770
        public void UpdateParameters(){} // RVA: 0x7ffaae6548b0
        public void .ctor(){} // RVA: 0x7ffaab27fc10
    }

    public class UnityAudioEngineState : AudioEngineState
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaae655820
        public void Destroy(){} // RVA: 0x7ffaae639700
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetHRTF(){} // RVA: 0x7ffaae655990
        public void SetPerspectiveCorrection(){} // RVA: 0x7ffaae6559a0
        public void SetReverbSource(){} // RVA: 0x7ffaae6559f0
        public void SetHRTFDisabled(){} // RVA: 0x7ffaae655a80
    }

    public class Vector3 : ValueType
    {
        public object z; // 0x373B3C00
    }

}