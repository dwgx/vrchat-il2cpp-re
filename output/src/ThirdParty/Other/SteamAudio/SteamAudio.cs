// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 60
// Methods: 647

namespace ThirdParty.Other.SteamAudio
{
    public class API : Object
    {
        // ── Methods ──
        public void iplContextCreate(){} // RVA: 0x6EE8F40
        public void iplContextRetain(){} // RVA: 0x6EE9260
        public void iplContextRelease(){} // RVA: 0x6EE92E0
        public void iplCalculateRelativeDirection(){} // RVA: 0x6EE9360
        public void iplSerializedObjectCreate(){} // RVA: 0x6EE9490
        public void iplSerializedObjectRetain(){} // RVA: 0x6EE9530
        public void iplSerializedObjectRelease(){} // RVA: 0x6EE95B0
        public void iplSerializedObjectGetSize(){} // RVA: 0x6EE9630
        public void iplSerializedObjectGetData(){} // RVA: 0x6EE96B0
        public void iplEmbreeDeviceCreate(){} // RVA: 0x6EE9730
        public void iplEmbreeDeviceRetain(){} // RVA: 0x6EE97D0
        public void iplEmbreeDeviceRelease(){} // RVA: 0x6EE9850
        public void iplOpenCLDeviceListCreate(){} // RVA: 0x6EE98D0
        public void iplOpenCLDeviceListRetain(){} // RVA: 0x6EE9970
        public void iplOpenCLDeviceListRelease(){} // RVA: 0x6EE99F0
        public void iplOpenCLDeviceListGetNumDevices(){} // RVA: 0x6EE9A70
        public void iplOpenCLDeviceListGetDeviceDesc(){} // RVA: 0x6EE9AF0
        public void iplOpenCLDeviceCreate(){} // RVA: 0x6EE9CE0
        public void iplOpenCLDeviceRetain(){} // RVA: 0x6EE9D90
        public void iplOpenCLDeviceRelease(){} // RVA: 0x6EE9E10
        public void iplRadeonRaysDeviceCreate(){} // RVA: 0x6EE9E90
        public void iplRadeonRaysDeviceRetain(){} // RVA: 0x6EE9F30
        public void iplRadeonRaysDeviceRelease(){} // RVA: 0x6EE9FB0
        public void iplTrueAudioNextDeviceCreate(){} // RVA: 0x6EEA030
        public void iplTrueAudioNextDeviceRetain(){} // RVA: 0x6EEA0D0
        public void iplTrueAudioNextDeviceRelease(){} // RVA: 0x6EEA150
        public void iplSceneCreate(){} // RVA: 0x6EEA1D0
        public void iplSceneRetain(){} // RVA: 0x6EEA370
        public void iplSceneRelease(){} // RVA: 0x6EEA3F0
        public void iplSceneLoad(){} // RVA: 0x6EEA470
        public void iplSceneSave(){} // RVA: 0x6EEA640
        public void iplSceneSaveOBJ(){} // RVA: 0x6EEA6D0
        public void iplSceneCommit(){} // RVA: 0x6EEA780
        public void iplStaticMeshCreate(){} // RVA: 0x6EEA800
        public void iplStaticMeshRetain(){} // RVA: 0x6EEA8A0
        public void iplStaticMeshRelease(){} // RVA: 0x6EEA920
        public void iplStaticMeshLoad(){} // RVA: 0x6EEA9A0
        public void iplStaticMeshSave(){} // RVA: 0x6EEAA60
        public void iplStaticMeshAdd(){} // RVA: 0x6EEAAF0
        public void iplStaticMeshRemove(){} // RVA: 0x6EEAB80
        public void iplInstancedMeshCreate(){} // RVA: 0x6EEAC10
        public void iplInstancedMeshRetain(){} // RVA: 0x6EEACB0
        public void iplInstancedMeshRelease(){} // RVA: 0x6EEAD30
        public void iplInstancedMeshAdd(){} // RVA: 0x6EEADB0
        public void iplInstancedMeshRemove(){} // RVA: 0x6EEAE40
        public void iplInstancedMeshUpdateTransform(){} // RVA: 0x6EEAED0
        public void iplHRTFCreate(){} // RVA: 0x6EEAF90
        public void iplHRTFRetain(){} // RVA: 0x6EEB210
        public void iplHRTFRelease(){} // RVA: 0x6EEB290
        public void iplProbeArrayCreate(){} // RVA: 0x6EEB310
        public void iplProbeArrayRetain(){} // RVA: 0x6EEB3A0
        public void iplProbeArrayRelease(){} // RVA: 0x6EEB420
        public void iplProbeArrayGenerateProbes(){} // RVA: 0x6EEB4A0
        public void iplProbeArrayGetNumProbes(){} // RVA: 0x6EEB540
        public void iplProbeArrayGetProbe(){} // RVA: 0x6EEB5C0
        public void iplProbeBatchCreate(){} // RVA: 0x6EEB660
        public void iplProbeBatchRetain(){} // RVA: 0x6EEB6F0
        public void iplProbeBatchRelease(){} // RVA: 0x6EEB770
        public void iplProbeBatchLoad(){} // RVA: 0x6EEB7F0
        public void iplProbeBatchSave(){} // RVA: 0x6EEB890
        public void iplProbeBatchGetNumProbes(){} // RVA: 0x6EEB920
        public void iplProbeBatchAddProbe(){} // RVA: 0x6EEB9A0
        public void iplProbeBatchAddProbeArray(){} // RVA: 0x6EEBA40
        public void iplProbeBatchRemoveProbe(){} // RVA: 0x6EEBAD0
        public void iplProbeBatchCommit(){} // RVA: 0x6EEBB60
        public void iplProbeBatchRemoveData(){} // RVA: 0x6EEBBE0
        public void iplProbeBatchGetDataSize(){} // RVA: 0x6EEBC70
        public void iplProbeBatchGetEnergyField(){} // RVA: 0x6EEBD00
        public void iplProbeBatchGetReverb(){} // RVA: 0x6EEBDB0
        public void iplReflectionsBakerBake(){} // RVA: 0x6EEBE70
        public void iplReflectionsBakerCancelBake(){} // RVA: 0x6EEBF20
        public void iplPathBakerBake(){} // RVA: 0x6EEBFA0
        public void iplPathBakerCancelBake(){} // RVA: 0x6EEC050
        public void iplSimulatorCreate(){} // RVA: 0x6EEC0D0
        public void iplSimulatorRetain(){} // RVA: 0x6EEC170
        public void iplSimulatorRelease(){} // RVA: 0x6EEC1F0
        public void iplSimulatorSetScene(){} // RVA: 0x6EEC270
        public void iplSimulatorAddProbeBatch(){} // RVA: 0x6EEC300
        public void iplSimulatorRemoveProbeBatch(){} // RVA: 0x6EEC390
        public void iplSimulatorSetSharedInputs(){} // RVA: 0x6EEC420
        public void iplSimulatorCommit(){} // RVA: 0x6EEC6D0
        public void iplSimulatorRunDirect(){} // RVA: 0x6EEC750
        public void iplSimulatorRunReflections(){} // RVA: 0x6EEC7D0
        public void iplSimulatorRunPathing(){} // RVA: 0x6EEC850
        public void iplSourceCreate(){} // RVA: 0x6EEC8D0
        public void iplSourceRetain(){} // RVA: 0x6EEC970
        public void iplSourceRelease(){} // RVA: 0x6EEC9F0
        public void iplSourceAdd(){} // RVA: 0x6EECA70
        public void iplSourceRemove(){} // RVA: 0x6EECB00
        public void iplSourceSetInputs(){} // RVA: 0x6EECB90
        public void iplSourceGetOutputs(){} // RVA: 0x6EECEC0
        public void iplDistanceAttenuationCalculate(){} // RVA: 0x6EECF60
        public void iplAirAbsorptionCalculate(){} // RVA: 0x6EED0F0
        public void iplDirectivityCalculate(){} // RVA: 0x6EED2A0
        public void iplEnergyFieldCreate(){} // RVA: 0x6EED450
        public void iplEnergyFieldRetain(){} // RVA: 0x6EED4F0
        public void iplEnergyFieldRelease(){} // RVA: 0x6EED570
        public void iplEnergyFieldGetNumChannels(){} // RVA: 0x6EED5F0
        public void iplEnergyFieldGetNumBins(){} // RVA: 0x6EED670
        public void iplEnergyFieldGetData(){} // RVA: 0x6EED6F0
        public void iplEnergyFieldGetChannel(){} // RVA: 0x6EED770
        public void iplEnergyFieldGetBand(){} // RVA: 0x6EED800
        public void iplEnergyFieldReset(){} // RVA: 0x6EED8A0
        public void iplEnergyFieldCopy(){} // RVA: 0x6EED920
        public void iplEnergyFieldSwap(){} // RVA: 0x6EED9B0
        public void iplEnergyFieldAdd(){} // RVA: 0x6EEDA40
        public void iplEnergyFieldScale(){} // RVA: 0x6EEDAE0
        public void iplEnergyFieldScaleAccum(){} // RVA: 0x6EEDB80
        public void iplImpulseResponseCreate(){} // RVA: 0x6EEDC20
        public void iplImpulseResponseRetain(){} // RVA: 0x6EEDCC0
        public void iplImpulseResponseRelease(){} // RVA: 0x6EEDD40
        public void iplImpulseResponseGetNumChannels(){} // RVA: 0x6EEDDC0
        public void iplImpulseResponseGetNumSamples(){} // RVA: 0x6EEDE40
        public void iplImpulseResponseGetData(){} // RVA: 0x6EEDEC0
        public void iplImpulseResponseGetChannel(){} // RVA: 0x6EEDF40
        public void iplImpulseResponseReset(){} // RVA: 0x6EEDFD0
        public void iplImpulseResponseCopy(){} // RVA: 0x6EEE050
        public void iplImpulseResponseSwap(){} // RVA: 0x6EEE0E0
        public void iplImpulseResponseAdd(){} // RVA: 0x6EEE170
        public void iplImpulseResponseScale(){} // RVA: 0x6EEE210
        public void iplImpulseResponseScaleAccum(){} // RVA: 0x6EEE2B0
        public void iplReconstructorCreate(){} // RVA: 0x6EEE350
        public void iplReconstructorRetain(){} // RVA: 0x6EEE3F0
        public void iplReconstructorRelease(){} // RVA: 0x6EEE470
        public void iplReconstructorReconstruct(){} // RVA: 0x6EEE4F0
        public void iplUnityInitialize(){} // RVA: 0x6EEE5A0
        public void iplUnitySetPerspectiveCorrection(){} // RVA: 0x6EEE620
        public void iplUnitySetHRTF(){} // RVA: 0x6EEE6D0
        public void iplUnitySetSimulationSettings(){} // RVA: 0x6EEE750
        public void iplUnitySetReverbSource(){} // RVA: 0x6EEE800
        public void iplUnityAddSource(){} // RVA: 0x6EEE880
        public void iplUnityRemoveSource(){} // RVA: 0x6EEE900
        public void iplUnityTerminate(){} // RVA: 0x6EEE980
        public void iplUnitySetHRTFDisabled(){} // RVA: 0x6EEE9F0
        public void iplUnitySetListenerNearFieldScale(){} // RVA: 0x6EEEA70
        public void iplUnitySetPerEarDirectionalityOptions(){} // RVA: 0x6EEEAF0
        public void iplUnitySetDirectivityFadeoutRadius(){} // RVA: 0x6EEEB80
        public void iplUnitySetDebugLogFunction(){} // RVA: 0x6EEEC00
        public void iplPreloadHRTF(){} // RVA: 0x6EEEC90
        public void iplUnitySetNearFieldILDNudgeData(){} // RVA: 0x6EEED40
        public void iplApplyGainNudge(){} // RVA: 0x6EEEDC0
    }

    public class AirAbsorptionCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8A20
        public void Invoke(){} // RVA: 0x6EE8AF0
        public void BeginInvoke(){} // RVA: 0x6EE8B10
        public void EndInvoke(){} // RVA: 0x25B7E60
    }

    public class AllocateCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x28BB490
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x28BB560
        public void EndInvoke(){} // RVA: 0x28BB5D0
    }

    public class AnyHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE84E0
        public void Invoke(){} // RVA: 0x6EE85D0
        public void BeginInvoke(){} // RVA: 0x6EE86F0
        public void EndInvoke(){} // RVA: 0x192AC80
    }

    public class AudioEngineAmbisonicSource : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xB43310
        public void Destroy(){} // RVA: 0xB43310
        public void UpdateParameters(){} // RVA: 0xB43310
        public void GetParameters(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x6EDE9F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AudioEngineSource : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xB43310
        public void Destroy(){} // RVA: 0xB43310
        public void UpdateParameters(){} // RVA: 0xB43310
        public void GetParameters(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x6EDEA40
        public void CreateFMODStudioAudioEngineSource(){} // RVA: 0x6EDEC60
        public void CreateWwiseAudioEngineSource(){} // RVA: 0x6EDED40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AudioEngineState : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xB43310
        public void Destroy(){} // RVA: 0xB43310
        public void SetHRTF(){} // RVA: 0xB43310
        public void SetPerspectiveCorrection(){} // RVA: 0xB43310
        public void SetReverbSource(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x6EDEE20
        public void CreateFMODStudioAudioEngineState(){} // RVA: 0x6EDF040
        public void CreateWwiseAudioEngineState(){} // RVA: 0x6EDF120
        public void SetHRTFDisabled(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AudioEngineStateHelpers : Object
    {
        // ── Methods ──
        public void GetListenerTransform(){} // RVA: 0x87C0A0
        public void GetAudioSettings(){} // RVA: 0x87C0A0
        public void Create(){} // RVA: 0x6EDF200
        public void CreateFMODStudioAudioEngineStateHelpers(){} // RVA: 0x6EDF420
        public void CreateWwiseAudioEngineStateHelpers(){} // RVA: 0x6EDF500
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BakedDataLayerInfo[] : Array
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

    public class Baker : Object
    {
        // ── Methods ──
        public void BeginBake(){} // RVA: 0x6EDF5E0
        public void EndBake(){} // RVA: 0x6EDFE10
        public void IsBakeActive(){} // RVA: 0x6EE0000
        public void DrawProgressBar(){} // RVA: 0xC2E4C0
        public void UpdateBakeProgress(){} // RVA: 0xB43310
        public void CancelBake(){} // RVA: 0x6EE0060
        public void AdvanceProgress(){} // RVA: 0xB43310
        public void InEditorUpdate(){} // RVA: 0xB43310
        public void BakeThread(){} // RVA: 0x6EE01A0
        public void .cctor(){} // RVA: 0x6EE1D90
    }

    public class BatchedAnyHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE87D0
        public void Invoke(){} // RVA: 0x3E3F4B0
        public void BeginInvoke(){} // RVA: 0x6EE88A0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class BatchedClosestHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE87D0
        public void Invoke(){} // RVA: 0x3E3F4B0
        public void BeginInvoke(){} // RVA: 0x6EE88A0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class ClosestHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE84E0
        public void Invoke(){} // RVA: 0x6EE85D0
        public void BeginInvoke(){} // RVA: 0x6EE85F0
        public void EndInvoke(){} // RVA: 0x192AC80
    }

    public class Common : Object
    {
        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x1924B40
        public void ConvertTransform(){} // RVA: 0x6EE1EF0
        public void TransposeMatrix(){} // RVA: 0x6EE21D0
        public void TransformMatrix(){} // RVA: 0x6EE21D0
        public void ConvertString(){} // RVA: 0x6EE2280
        public void GetStreamingAssetsFileName(){} // RVA: 0x6EE2300
        public void HumanReadableDataSize(){} // RVA: 0x6EE2390
    }

    public class Context : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE2820
        public void Finalize(){} // RVA: 0x6EE28C0
        public void Release(){} // RVA: 0x6EE2900
        public void Get(){} // RVA: 0xB5DBF0
        public void LogMessage(){} // RVA: 0x6EE2980
    }

    public class DeviationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8A20
        public void Invoke(){} // RVA: 0x6EE8AF0
        public void BeginInvoke(){} // RVA: 0x6EE8B10
        public void EndInvoke(){} // RVA: 0x25B7E60
    }

    public class DirectivityCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8B90
        public void Invoke(){} // RVA: 0x6EE8C60
        public void BeginInvoke(){} // RVA: 0x6EE8C90
        public void EndInvoke(){} // RVA: 0x25B7E60
    }

    public class DistanceAttenuationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8950
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x6EE83E0
        public void EndInvoke(){} // RVA: 0x25B7E60
    }

    public class EmbreeDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE2B70
        public void Finalize(){} // RVA: 0x6EE2C10
        public void Release(){} // RVA: 0x6EE2C50
        public void Get(){} // RVA: 0xB5DBF0
    }

    public class FreeCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26E1500
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0x22335C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class HRTF : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE3230
        public void Finalize(){} // RVA: 0x6EE32D0
        public void Release(){} // RVA: 0x6EE3310
        public void Get(){} // RVA: 0xB5DBF0
        public void dBToGain(){} // RVA: 0x6EE3390
    }

    public class HRTF[] : Array
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

    public class InstancedMesh : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE35F0
        public void Finalize(){} // RVA: 0x6EE3690
        public void Release(){} // RVA: 0x6EE36D0
        public void Get(){} // RVA: 0xB5DBF0
        public void AddToScene(){} // RVA: 0x6EE3750
        public void RemoveFromScene(){} // RVA: 0x6EE3800
        public void UpdateTransform(){} // RVA: 0x6EE38B0
    }

    public class LogCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCA8B20
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x6EE8450
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class OpenCLDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE3F30
        public void Finalize(){} // RVA: 0x6EE3FD0
        public void Release(){} // RVA: 0x6EE4010
        public void Get(){} // RVA: 0xB5DBF0
    }

    public class PanicFunction_ : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE7EA0
        public void Finalize(){} // RVA: 0x6EE7F90
        public void Release(){} // RVA: 0x6EE7FD0
        public void Get(){} // RVA: 0xB465B0
        public void Save(){} // RVA: 0x6EE80A0
        public void AddToScene(){} // RVA: 0x6EE81B0
        public void RemoveFromScene(){} // RVA: 0x6EE8260
    }

    public class PathingVisualizationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8D30
        public void Invoke(){} // RVA: 0x6EE8E00
        public void BeginInvoke(){} // RVA: 0x6EE8E60
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class ProbeArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE4130
        public void Finalize(){} // RVA: 0x6EE41D0
        public void Release(){} // RVA: 0x6EE4210
        public void Get(){} // RVA: 0xB5DBF0
        public void GenerateProbes(){} // RVA: 0x6EE4290
        public void GetNumProbes(){} // RVA: 0x6EE4340
        public void GetProbe(){} // RVA: 0x6EE43C0
    }

    public class ProbeBatch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE4790
        public void Finalize(){} // RVA: 0x6EE4880
        public void Release(){} // RVA: 0x6EE48C0
        public void Get(){} // RVA: 0xB465B0
        public void Save(){} // RVA: 0x6EE4990
        public void AddProbeArray(){} // RVA: 0x6EE4AC0
        public void AddProbe(){} // RVA: 0x6EE4B60
        public void Commit(){} // RVA: 0x6EE4C00
        public void RemoveData(){} // RVA: 0x6EE4C80
        public void GetDataSize(){} // RVA: 0x6EE4D10
    }

    public class ProgressCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE8310
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x6EE83E0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class RadeonRaysDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE4ED0
        public void Finalize(){} // RVA: 0x6EE4F70
        public void Release(){} // RVA: 0x6EE4FB0
        public void Get(){} // RVA: 0xB5DBF0
    }

    public class SOFAFile : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE7140
    }

    public class SOFAFile[] : Array
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

    public class Scene : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE5750
        public void Finalize(){} // RVA: 0x6EE5840
        public void Release(){} // RVA: 0x6EE5880
        public void Get(){} // RVA: 0xB465B0
        public void Save(){} // RVA: 0x6EE5950
        public void SaveOBJ(){} // RVA: 0x6EE5A60
        public void NotifyAddObject(){} // RVA: 0x6EE5B10
        public void NotifyRemoveObject(){} // RVA: 0x6EE5B20
        public void GetNumObjects(){} // RVA: 0xFEAE90
        public void Commit(){} // RVA: 0x6EE5B30
    }

    public class SerializedData : ScriptableObject
    {
        // ── Methods ──
        public void PromptForNewAsset(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SerializedObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE5E00
        public void Finalize(){} // RVA: 0x6EE5EA0
        public void Release(){} // RVA: 0x6EE5EE0
        public void Get(){} // RVA: 0xB5DBF0
        public void GetSize(){} // RVA: 0x6EE5FC0
        public void GetData(){} // RVA: 0x6EE6040
        public void WriteToFile(){} // RVA: 0x6EE60C0
        public void FlushWrite(){} // RVA: 0xB43310
        public void FlushAllWrites(){} // RVA: 0x6EE63B0
    }

    public class Simulator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE6680
        public void Finalize(){} // RVA: 0x6EE6720
        public void Release(){} // RVA: 0x6EE6760
        public void Get(){} // RVA: 0xB5DBF0
        public void SetScene(){} // RVA: 0x6EE67E0
        public void AddProbeBatch(){} // RVA: 0x6EE6880
        public void RemoveProbeBatch(){} // RVA: 0x6EE6920
        public void SetSharedInputs(){} // RVA: 0x6EE69C0
        public void Commit(){} // RVA: 0x6EE69E0
        public void RunDirect(){} // RVA: 0x6EE6A60
        public void RunReflections(){} // RVA: 0x6EE6AE0
        public void RunPathing(){} // RVA: 0x6EE6B60
    }

    public class Source : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EE6D40
        public void Finalize(){} // RVA: 0x6EE6DE0
        public void Release(){} // RVA: 0x6EE6E20
        public void Get(){} // RVA: 0xB5DBF0
        public void AddToSimulator(){} // RVA: 0x6EE6EA0
        public void RemoveFromSimulator(){} // RVA: 0x6EE6F40
        public void SetInputs(){} // RVA: 0x6EE6FE0
        public void GetOutputs(){} // RVA: 0x6EE7000
    }

    public class Sphere[] : Array
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

    public class SteamAudioAmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6EEEE70
        public void Start(){} // RVA: 0x6EEEF70
        public void OnDestroy(){} // RVA: 0x6EEEFA0
        public void OnEnable(){} // RVA: 0x6EEEF70
        public void Update(){} // RVA: 0x6EEEF70
        public void .ctor(){} // RVA: 0xB9C2F0
    }

    public class SteamAudioBakedListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0xB9E080
        public void GetProbeDataSizes(){} // RVA: 0xD05CA0
        public void GetSizeForProbeBatch(){} // RVA: 0x6EEEFC0
        public void GetProbeBatchesUsed(){} // RVA: 0x6EEEFF0
        public void GetBakedDataIdentifier(){} // RVA: 0x6EEF020
        public void OnDrawGizmosSelected(){} // RVA: 0x6EEF150
        public void UpdateBakedDataStatistics(){} // RVA: 0x6EEF6E0
        public void BeginBake(){} // RVA: 0x6EEF860
        public void CacheIdentifier(){} // RVA: 0x6EEFEB0
        public void CacheProbeBatchesUsed(){} // RVA: 0x6EEFEE0
        public void .ctor(){} // RVA: 0x6EEFFA0
    }

    public class SteamAudioBakedSource : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0xB9E080
        public void GetProbeDataSizes(){} // RVA: 0xD05CA0
        public void GetSizeForProbeBatch(){} // RVA: 0x6EEEFC0
        public void GetProbeBatchesUsed(){} // RVA: 0x6EF0010
        public void GetBakedDataIdentifier(){} // RVA: 0x6EF0040
        public void OnDrawGizmosSelected(){} // RVA: 0x6EF0170
        public void UpdateBakedDataStatistics(){} // RVA: 0x6EF0700
        public void BeginBake(){} // RVA: 0x6EF0880
        public void CacheIdentifier(){} // RVA: 0x6EF0ED0
        public void CacheProbeBatchesUsed(){} // RVA: 0x6EF0F00
        public void .ctor(){} // RVA: 0x6EEFFA0
    }

    public class SteamAudioDynamicObject : MonoBehaviour
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x6EF0FC0
        public void OnEnable(){} // RVA: 0x6EF0FF0
        public void OnDisable(){} // RVA: 0x6EF10A0
        public void Update(){} // RVA: 0x6EF11C0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamAudioGeometry : MonoBehaviour
    {
        // ── Methods ──
        public void GetNumVertices(){} // RVA: 0x6EF15E0
        public void GetNumTriangles(){} // RVA: 0x6EF1770
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamAudioGeometry[] : Array
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

    public class SteamAudioListener : MonoBehaviour
    {
        // ── Methods ──
        public void GetTotalDataSize(){} // RVA: 0xBE5850
        public void GetProbeDataSizes(){} // RVA: 0xBBF8F0
        public void GetSizeForProbeBatch(){} // RVA: 0x6EF1900
        public void GetProbeBatchesUsed(){} // RVA: 0x6EF1930
        public void Awake(){} // RVA: 0x6EF1960
        public void Reinitialize(){} // RVA: 0x6EF1970
        public void OnDestroy(){} // RVA: 0x6EF1C10
        public void Start(){} // RVA: 0x6EF1C30
        public void OnEnable(){} // RVA: 0x6EF1CA0
        public void OnDisable(){} // RVA: 0x6EF1E40
        public void Update(){} // RVA: 0x6EF1C30
        public void GetBakedDataIdentifier(){} // RVA: 0x6EF1FD0
        public void SetInputs(){} // RVA: 0x6EF2000
        public void UpdateOutputs(){} // RVA: 0xB43310
        public void OnDrawGizmosSelected(){} // RVA: 0x6EF23E0
        public void UpdateBakedDataStatistics(){} // RVA: 0x6EF2810
        public void BeginBake(){} // RVA: 0x6EF2990
        public void CacheIdentifier(){} // RVA: 0x6EF2FB0
        public void CacheProbeBatchesUsed(){} // RVA: 0x6EF2FC0
        public void .ctor(){} // RVA: 0x6EF3080
    }

    public class SteamAudioManager : MonoBehaviour
    {
        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x6EF30E0
        public void get_Context(){} // RVA: 0x6EF3120
        public void get_CurrentHRTF(){} // RVA: 0x6EF3170
        public void get_EmbreeDevice(){} // RVA: 0x6EF31E0
        public void get_OpenCLDevice(){} // RVA: 0x6EF3240
        public void get_RadeonRaysDevice(){} // RVA: 0x6EF32A0
        public void get_TrueAudioNextDevice(){} // RVA: 0x6EF3300
        public void get_CurrentScene(){} // RVA: 0x6EF3360
        public void get_Simulator(){} // RVA: 0x6EF33B0
        public void get_AudioSettings(){} // RVA: 0x6EF3400
        public void GetAudioEngineState(){} // RVA: 0x6EF3450
        public void GetSteamAudioListener(){} // RVA: 0x6EF34A0
        public void NumThreadsForCPUCorePercentage(){} // RVA: 0x6EF35C0
        public void GetSceneType(){} // RVA: 0x6EF35F0
        public void GetReflectionEffectType(){} // RVA: 0x6EF3690
        public void GetPerspectiveCorrection(){} // RVA: 0x6EF3700
        public void GetMainCamera(){} // RVA: 0x10B9D50
        public void GetSimulationSettings(){} // RVA: 0x6EF3B70
        public void OnApplicationStart(){} // RVA: 0x6EF3FA0
        public void LoadHRTFFromFile(){} // RVA: 0x6EF4DC0
        public void UnloadHRTFByName(){} // RVA: 0x6EF4F90
        public void SetHRTFAtIndex(){} // RVA: 0x6EF52B0
        public void OnApplicationQuit(){} // RVA: 0x6EF5390
        public void OnSceneLoaded(){} // RVA: 0x6EF53E0
        public void OnSceneUnloaded(){} // RVA: 0x6EF5540
        public void NotifyAudioListenerChanged(){} // RVA: 0x6EF5550
        public void NotifyAudioListenerChangedTo(){} // RVA: 0x6EF55A0
        public void NotifyMainCameraChanged(){} // RVA: 0x6EF57C0
        public void ScheduleCommitScene(){} // RVA: 0x6EF5860
        public void LateUpdate(){} // RVA: 0x6EF58B0
        public void RunSimulationInternal(){} // RVA: 0x6EF6970
        public void RunSimulation(){} // RVA: 0x6EF6A90
        public void Initialize(){} // RVA: 0x6EF6AF0
        public void ShutDown(){} // RVA: 0x6EF6C90
        public void Reinitialize(){} // RVA: 0x6EF73C0
        public void AddSource(){} // RVA: 0x6EF8530
        public void RemoveSource(){} // RVA: 0x6EF85C0
        public void AddListener(){} // RVA: 0x6EF8640
        public void RemoveListener(){} // RVA: 0x6EF86D0
        public void ExportDynamicObject(){} // RVA: 0x6EF8750
        public void ExportDynamicObjectsInArray(){} // RVA: 0x6EF89F0
        public void GetDynamicObjectsInScene(){} // RVA: 0x6EF8C90
        public void LoadScene(){} // RVA: 0x6EF8E00
        public void LoadDynamicObject(){} // RVA: 0x6EF8EC0
        public void UnloadDynamicObject(){} // RVA: 0x6EF9450
        public void GetGameObjectsForExport(){} // RVA: 0x6EF9660
        public void GetNumVertices(){} // RVA: 0x6EF9E50
        public void GetNumTriangles(){} // RVA: 0x6EFA1D0
        public void ClosestHit(){} // RVA: 0x6EFA570
        public void AnyHit(){} // RVA: 0x6EFA8C0
        public void AutoInitialize(){} // RVA: 0x6EFAB00
        public void FirstAutoInitialize(){} // RVA: 0x6EFAB50
        public void ExportScene(){} // RVA: 0x6EFABB0
        public void Export(){} // RVA: 0x6EFAF00
        public void CreateScene(){} // RVA: 0x6EFB3E0
        public void Load(){} // RVA: 0x6EFB7E0
        public void RemoveAllDynamicObjects(){} // RVA: 0x6EFB860
        public void RemoveAllAdditiveScenes(){} // RVA: 0x6EFBE00
        public void GetMaterialBufferForTransform(){} // RVA: 0x6EFBF30
        public void GetStaticGameObjectsForExport(){} // RVA: 0x6EFC290
        public void GetDynamicGameObjectsForExport(){} // RVA: 0x6EFC3C0
        public void IsDynamicSubObject(){} // RVA: 0x6EFC430
        public void IsActiveInHierarchy(){} // RVA: 0x6EFC600
        public void GetGeometryAndMaterialBuffers(){} // RVA: 0x6EFC710
        public void GetDynamicObjectInParent(){} // RVA: 0x6EFCE30
        public void GetVertices(){} // RVA: 0x6EFD000
        public void GetTriangles(){} // RVA: 0x6EFDBE0
        public void FixupTriangleIndices(){} // RVA: 0x6EFE170
        public void GetTerrainSimplificationLevel(){} // RVA: 0x6EFE1E0
        public void GetMaterialMapping(){} // RVA: 0x6EFE240
        public void GetMaterialForGameObject(){} // RVA: 0x6EFEA90
        public void GetOBJFileName(){} // RVA: 0x6EFEEA0
        public void GetDataAsset(){} // RVA: 0x6EFF310
        public void .ctor(){} // RVA: 0x6EFF330
    }

    public class SteamAudioMaterial : ScriptableObject
    {
        // ── Methods ──
        public void GetMaterial(){} // RVA: 0x6EFF670
        public void .ctor(){} // RVA: 0x6EFF6B0
    }

    public class SteamAudioProbeBatch : MonoBehaviour
    {
        // ── Methods ──
        public void GetAsset(){} // RVA: 0x6EFF6F0
        public void GetNumProbes(){} // RVA: 0x6EFF880
        public void GetNumLayers(){} // RVA: 0x6EFF8A0
        public void GetProbeBatch(){} // RVA: 0x16D8710
        public void Awake(){} // RVA: 0x6EFF8F0
        public void OnDestroy(){} // RVA: 0x6EFFAB0
        public void OnEnable(){} // RVA: 0x6EFFAD0
        public void OnDisable(){} // RVA: 0x6EFFBC0
        public void OnDrawGizmosSelected(){} // RVA: 0x6EFFCF0
        public void GenerateProbes(){} // RVA: 0x6F001E0
        public void DeleteBakedDataForIdentifier(){} // RVA: 0x6F00F40
        public void GetSizeForLayer(){} // RVA: 0x6F013D0
        public void GetInfoForLayer(){} // RVA: 0x6F01590
        public void ResetLayers(){} // RVA: 0x6F01630
        public void AddLayer(){} // RVA: 0x6F016A0
        public void RemoveLayer(){} // RVA: 0x6F017D0
        public void AddOrUpdateLayer(){} // RVA: 0x6F01A10
        public void UpdateGameObjectStatistics(){} // RVA: 0x6F01D00
        public void GetBakedDataIdentifier(){} // RVA: 0x6F01DF0
        public void BeginBake(){} // RVA: 0x6F01E30
        public void .ctor(){} // RVA: 0x6F02320
    }

    public class SteamAudioProbeBatch[] : Array
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

    public class SteamAudioReverbData : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6F02420
        public void GetImpulseResponseSize(){} // RVA: 0x6F02580
        public void GetEnergyFieldData(){} // RVA: 0x6F025A0
        public void GetEnergyFieldSize(){} // RVA: 0x6F025E0
        public void GetImpulseResponseData(){} // RVA: 0x6F02600
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SteamAudioReverbDataPoint : MonoBehaviour
    {
        // ── Methods ──
        public void CreateFolderRecursively(){} // RVA: 0xB43310
        public void GetAssetFolderPath(){} // RVA: 0x6F02640
        public void GetBakedDataIdentifier(){} // RVA: 0x6EF1FD0
        public void EnsureValidData(){} // RVA: 0xB43310
        public void BeginBake(){} // RVA: 0x6F02680
        public void UpdateEnergyField(){} // RVA: 0x6F02EC0
        public void UpdateImpulseResponse(){} // RVA: 0x6F032A0
        public void WriteReverbDataToFile(){} // RVA: 0x6F03640
        public void FlushWrite(){} // RVA: 0xB43310
        public void FlushAllWrites(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x6F037D0
    }

    public class SteamAudioSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_Singleton(){} // RVA: 0x6F03870
        public void .ctor(){} // RVA: 0x6F03B70
    }

    public class SteamAudioSource : MonoBehaviour
    {
        // ── Methods ──
        public void get_interpolation(){} // RVA: 0xC3CCE0
        public void Awake(){} // RVA: 0x6F03C90
        public void LazyInitSource(){} // RVA: 0x6F03F30
        public void AssignHandle(){} // RVA: 0x6F04170
        public void SetAttenuationModel(){} // RVA: 0x6F043B0
        public void UpdateParameters(){} // RVA: 0x6F04700
        public void Start(){} // RVA: 0x6F04730
        public void OnDestroy(){} // RVA: 0x6F04760
        public void OnEnable(){} // RVA: 0x6F04930
        public void OnDisable(){} // RVA: 0x6F04A20
        public void LateUpdate(){} // RVA: 0x6F04700
        public void OnDrawGizmosSelected(){} // RVA: 0x6F04B50
        public void SetInputs(){} // RVA: 0x6F053D0
        public void GetOutputs(){} // RVA: 0x6F06180
        public void GetSource(){} // RVA: 0x135EDB0
        public void UpdateOutputs(){} // RVA: 0x6F06280
        public void InitializeDeformedSphereMesh(){} // RVA: 0x6F06440
        public void DeformSphereMesh(){} // RVA: 0x6F06D40
        public void DeformedVertex(){} // RVA: 0x6F07190
        public void EvaluateDistanceCurve(){} // RVA: 0x6F07210
        public void .ctor(){} // RVA: 0x6F07370
        public void .cctor(){} // RVA: 0x6F076A0
    }

    public class SteamAudioStaticMesh : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6F07830
        public void OnDestroy(){} // RVA: 0x6F079E0
        public void OnEnable(){} // RVA: 0x6F07BA0
        public void OnDisable(){} // RVA: 0x6F07C50
        public void Update(){} // RVA: 0x6F07D70
        public void .ctor(){} // RVA: 0x6F07FB0
        public void <Update>b__8_0(){} // RVA: 0x6F08080
    }

    public class TrueAudioNextDevice : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F083F0
        public void Finalize(){} // RVA: 0x6F08490
        public void Release(){} // RVA: 0x6F084D0
        public void Get(){} // RVA: 0xB5DBF0
    }

    public class UnityAudioEngineAmbisonicSource : AudioEngineAmbisonicSource
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6F08550
        public void UpdateParameters(){} // RVA: 0x6F08600
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityAudioEngineSource : AudioEngineSource
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6F08710
        public void Destroy(){} // RVA: 0x6F08980
        public void UpdateParameters(){} // RVA: 0x6F08AC0
        public void .ctor(){} // RVA: 0x3928BD0
    }

    public class UnityAudioEngineState : AudioEngineState
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6F09310
        public void Destroy(){} // RVA: 0x6EEE980
        public void SetHRTF(){} // RVA: 0x6F09480
        public void SetPerspectiveCorrection(){} // RVA: 0x6F09490
        public void SetReverbSource(){} // RVA: 0x6F094E0
        public void SetHRTFDisabled(){} // RVA: 0x6F09570
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityAudioEngineStateHelpers : AudioEngineStateHelpers
    {
        // ── Methods ──
        public void GetListenerTransform(){} // RVA: 0x6F095F0
        public void GetAudioSettings(){} // RVA: 0x6F096E0
        public void .ctor(){} // RVA: 0xB43310
    }

}