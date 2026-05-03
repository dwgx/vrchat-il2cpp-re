// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 22
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData : ValueType
    {
        public ulong m_FrameID; // 0x10
        public double m_DeltaTime; // 0x18
        public float m_Weight; // 0x20
        public float m_EffectiveWeight; // 0x24
        public double m_EffectiveParentDelay; // 0x28
        public float m_EffectiveParentSpeed; // 0x30
        public float m_EffectiveSpeed; // 0x34
        public 0x66581B1C m_Flags; // 0x38

        // ── Methods ──
        public void HasFlags(){} // RVA: 0x7FFE87C9FA80
        public void get_deltaTime(){} // RVA: 0x7FFE87C9FA90
        public void get_effectiveSpeed(){} // RVA: 0x7FFE87BBD380
        public void get_evaluationType(){} // RVA: 0x7FFE87C9FAA0
        public void get_seekOccurred(){} // RVA: 0x7FFE87C9FAB0
        public void get_timeLooped(){} // RVA: 0x7FFE87C9FAC0
        public void get_timeHeld(){} // RVA: 0x7FFE87C9FAD0
        public void get_output(){} // RVA: 0x7FFE87C9FAE0
        public void get_effectivePlayState(){} // RVA: 0x7FFE87C9FAF0
    }

    public class FrameRate : ValueType
    {
        public UnityEngine.Playables.FrameRate k_24Fps;
        public UnityEngine.Playables.FrameRate k_23_976Fps; // 0x4

        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x7FFE869D8370
        public void get_rate(){} // RVA: 0x7FFE87C9FB10
        public void .ctor(){} // RVA: 0x7FFE87C9FB80
        public void IsValid(){} // RVA: 0x7FFE87BE1190
        public void Equals(){} // RVA: 0x7FFE87C9FBA0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87C9FC40
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void ToString(){} // RVA: 0x7FFE87C9FD00 | overloaded x2
        public void DoubleToFrameRate(){} // RVA: 0x7FFE87C9FF10
        public void .cctor(){} // RVA: 0x7FFE87CA0070
    }

    public class INotification
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE810A1420
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFE810A1420
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFE810A1420
    }

    public class IPlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFE80E33FB0
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x7FFE810A1420
        public void OnBehaviourPause(){} // RVA: 0x7FFE810A1420
        public void PrepareFrame(){} // RVA: 0x7FFE810A1420
        public void ProcessFrame(){} // RVA: 0x7FFE810A1420
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFE810A1420
    }

    public class Playable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFE87CA0150
        public void Create(){} // RVA: 0x7FFE87CA01C0
        public void .ctor(){} // RVA: 0x7FFE827D9C10
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void IsPlayableOfType(){} // RVA: 0x7FFE80E2F150
        public void GetPlayableType(){} // RVA: 0x7FFE87CA02B0
        public void Equals(){} // RVA: 0x7FFE87CA03B0
        public void .cctor(){} // RVA: 0x7FFE87CA04A0
    }

    public class PlayableAsset : ScriptableObject
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFE87CA0550
        public void get_outputs(){} // RVA: 0x7FFE87CA05B0
        public void Internal_CreatePlayable(){} // RVA: 0x7FFE87CA0610
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7FFE87CA07A0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class PlayableBehaviour : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void OnGraphStart(){} // RVA: 0x7FFE810FB310
        public void OnGraphStop(){} // RVA: 0x7FFE810FB310
        public void OnPlayableCreate(){} // RVA: 0x7FFE810FB310
        public void OnPlayableDestroy(){} // RVA: 0x7FFE810FB310
        public void OnBehaviourPlay(){} // RVA: 0x7FFE810FB310
        public void OnBehaviourPause(){} // RVA: 0x7FFE810FB310
        public void PrepareFrame(){} // RVA: 0x7FFE810FB310
        public void ProcessFrame(){} // RVA: 0x7FFE810FB310
        public void Clone(){} // RVA: 0x7FFE87CA07E0
    }

    public class PlayableBinding : ValueType
    {
        public string m_StreamName; // 0x10

        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x7FFE86A5E330
        public void CreateOutput(){} // RVA: 0x7FFE87CA07F0
        public void CreateInternal(){} // RVA: 0x7FFE87CA08F0
        public void .cctor(){} // RVA: 0x7FFE87CA0A90
    }

    public class PlayableDirector : Behaviour
    {
        public System.Action`1<UnityEngine.Playables.PlayableDirector> played; // 0x18
        public System.Action`1<UnityEngine.Playables.PlayableDirector> paused; // 0x20
        public System.Action`1<UnityEngine.Playables.PlayableDirector> stopped; // 0x28
        public object field_3; // 0xA110
        public object field_4; // 0xA2C8
        public object field_5; // 0xA480
        public object field_6; // 0xA638
        public object field_7; // 0xA7F0
        public object field_8; // 0xA9A8

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFE87CAA8D0
        public void set_extrapolationMode(){} // RVA: 0x7FFE87CAA920
        public void get_extrapolationMode(){} // RVA: 0x7FFE87CAA980
        public void get_playableAsset(){} // RVA: 0x7FFE87CAA9D0
        public void set_playableAsset(){} // RVA: 0x7FFE87CAAAA0
        public void get_playableGraph(){} // RVA: 0x7FFE87CAAB00
        public void get_playOnAwake(){} // RVA: 0x7FFE87CAAB80
        public void set_playOnAwake(){} // RVA: 0x7FFE87CAABD0
        public void DeferredEvaluate(){} // RVA: 0x7FFE87CAAC30
        public void Play(){} // RVA: 0x7FFE87CAB3D0 | overloaded x4
        public void SetGenericBinding(){} // RVA: 0x7FFE87CAB050
        public void set_timeUpdateMode(){} // RVA: 0x7FFE87CAB0C0
        public void get_timeUpdateMode(){} // RVA: 0x7FFE87CAB120
        public void set_time(){} // RVA: 0x7FFE87CAB170
        public void get_time(){} // RVA: 0x7FFE87CAB1D0
        public void set_initialTime(){} // RVA: 0x7FFE87CAB220
        public void get_initialTime(){} // RVA: 0x7FFE87CAB280
        public void get_duration(){} // RVA: 0x7FFE87CAB2D0
        public void Evaluate(){} // RVA: 0x7FFE87CAB320
        public void PlayOnFrame(){} // RVA: 0x7FFE87CAB370
        public void Stop(){} // RVA: 0x7FFE87CAB420
        public void Pause(){} // RVA: 0x7FFE87CAB470
        public void Resume(){} // RVA: 0x7FFE87CAB4C0
        public void RebuildGraph(){} // RVA: 0x7FFE87CAB510
        public void ClearReferenceValue(){} // RVA: 0x7FFE87CAB560
        public void SetReferenceValue(){} // RVA: 0x7FFE87CAB5C0
        public void GetReferenceValue(){} // RVA: 0x7FFE87CAB630
        public void GetGenericBinding(){} // RVA: 0x7FFE87CAB6A0
        public void ClearGenericBinding(){} // RVA: 0x7FFE87CAB700
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7FFE87CAB760
        public void ProcessPendingGraphChanges(){} // RVA: 0x7FFE87CAB7B0
        public void HasGenericBinding(){} // RVA: 0x7FFE87CAB800
        public void GetPlayState(){} // RVA: 0x7FFE87CAA8D0
        public void SetWrapMode(){} // RVA: 0x7FFE87CAA920
        public void GetWrapMode(){} // RVA: 0x7FFE87CAA980
        public void EvaluateNextFrame(){} // RVA: 0x7FFE87CAAC30
        public void GetGraphHandle(){} // RVA: 0x7FFE87CAB860
        public void SetPlayOnAwake(){} // RVA: 0x7FFE87CAABD0
        public void GetPlayOnAwake(){} // RVA: 0x7FFE87CAAB80
        public void Internal_SetGenericBinding(){} // RVA: 0x7FFE87CAB050
        public void SetPlayableAsset(){} // RVA: 0x7FFE87CAAAA0
        public void Internal_GetPlayableAsset(){} // RVA: 0x7FFE87CAB8D0
        public void add_played(){} // RVA: 0x7FFE87CAB920
        public void remove_played(){} // RVA: 0x7FFE87CABA20
        public void add_paused(){} // RVA: 0x7FFE87CABB20
        public void remove_paused(){} // RVA: 0x7FFE87CABC20
        public void add_stopped(){} // RVA: 0x7FFE87CABD20
        public void remove_stopped(){} // RVA: 0x7FFE87CABE20
        public void ResetFrameTiming(){} // RVA: 0x7FFE87CABF20
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7FFE87CABF70
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7FFE87CABF90
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7FFE87CABFB0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void PlayOnFrame_Injected(){} // RVA: 0x7FFE87CABFD0
        public void ClearReferenceValue_Injected(){} // RVA: 0x7FFE87CAC030
        public void SetReferenceValue_Injected(){} // RVA: 0x7FFE87CAC090
        public void GetReferenceValue_Injected(){} // RVA: 0x7FFE87CAC100
        public void GetGraphHandle_Injected(){} // RVA: 0x7FFE87CAC170
    }

    public class PlayableExtensions : Object
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFE810A1420
        public void IsValid(){} // RVA: 0x7FFE810A1420
        public void Destroy(){} // RVA: 0x7FFE810A1420
        public void GetGraph(){} // RVA: 0x7FFE810A1420
        public void GetPlayState(){} // RVA: 0x7FFE810A1420
        public void Play(){} // RVA: 0x7FFE810A1420
        public void Pause(){} // RVA: 0x7FFE810A1420
        public void SetSpeed(){} // RVA: 0x7FFE810A1420
        public void SetDuration(){} // RVA: 0x7FFE810A1420
        public void GetDuration(){} // RVA: 0x7FFE810A1420
        public void SetTime(){} // RVA: 0x7FFE810A1420
        public void GetTime(){} // RVA: 0x7FFE810A1420
        public void GetPreviousTime(){} // RVA: 0x7FFE810A1420
        public void IsDone(){} // RVA: 0x7FFE810A1420
        public void SetPropagateSetTime(){} // RVA: 0x7FFE810A1420
        public void SetInputCount(){} // RVA: 0x7FFE810A1420
        public void GetInputCount(){} // RVA: 0x7FFE810A1420
        public void GetOutputCount(){} // RVA: 0x7FFE810A1420
        public void GetInput(){} // RVA: 0x7FFE810A1420
        public void SetInputWeight(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFE810A1420
        public void DisconnectInput(){} // RVA: 0x7FFE810A1420
        public void SetTraversalMode(){} // RVA: 0x7FFE810A1420
        public void GetTimeWrapMode(){} // RVA: 0x7FFE810A1420
        public void SetTimeWrapMode(){} // RVA: 0x7FFE810A1420
    }

    public class PlayableGraph : ValueType
    {
        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x7FFE87CA0C30
        public void Connect(){} // RVA: 0x7FFE810A1420
        public void Disconnect(){} // RVA: 0x7FFE810A1420
        public void DestroyPlayable(){} // RVA: 0x7FFE810A1420
        public void GetOutputCountByType(){} // RVA: 0x7FFE80E2EDB0
        public void GetOutputByType(){} // RVA: 0x7FFE810A1420
        public void Evaluate(){} // RVA: 0x7FFE87CA0F20 | overloaded x2
        public void Create(){} // RVA: 0x7FFE87CA0D20
        public void Destroy(){} // RVA: 0x7FFE87CA0D90
        public void IsValid(){} // RVA: 0x7FFE87CA0DE0
        public void IsPlaying(){} // RVA: 0x7FFE87CA0E30
        public void Play(){} // RVA: 0x7FFE87CA0E80
        public void Stop(){} // RVA: 0x7FFE87CA0ED0
        public void GetResolver(){} // RVA: 0x7FFE87CA0F80
        public void GetPlayableCount(){} // RVA: 0x7FFE87CA0FD0
        public void GetRootPlayableCount(){} // RVA: 0x7FFE87CA1020
        public void SynchronizeEvaluation(){} // RVA: 0x7FFE87CA1070
        public void CreatePlayableHandle(){} // RVA: 0x7FFE87CA10D0
        public void CreateScriptOutputInternal(){} // RVA: 0x7FFE87CA1140
        public void GetRootPlayableInternal(){} // RVA: 0x7FFE87CA11B0
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7FFE87CA1230
        public void GetFrameRate(){} // RVA: 0x7FFE87CA1280
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7FFE87CA12E0
        public void GetOutputByTypeInternal(){} // RVA: 0x7FFE87CA1340
        public void ConnectInternal(){} // RVA: 0x7FFE87CA13C0
        public void DisconnectInternal(){} // RVA: 0x7FFE87CA1450
        public void DestroyPlayableInternal(){} // RVA: 0x7FFE87CA14C0
        public void Create_Injected(){} // RVA: 0x7FFE87CA1520
        public void Destroy_Injected(){} // RVA: 0x7FFE87CA0D90
        public void IsValid_Injected(){} // RVA: 0x7FFE87CA0DE0
        public void IsPlaying_Injected(){} // RVA: 0x7FFE87CA0E30
        public void Play_Injected(){} // RVA: 0x7FFE87CA0E80
        public void Stop_Injected(){} // RVA: 0x7FFE87CA0ED0
        public void Evaluate_Injected(){} // RVA: 0x7FFE87CA0F20
        public void GetResolver_Injected(){} // RVA: 0x7FFE87CA0F80
        public void GetPlayableCount_Injected(){} // RVA: 0x7FFE87CA0FD0
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7FFE87CA1020
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7FFE87CA1580
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7FFE87CA15E0
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7FFE87CA1140
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7FFE87CA1640
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7FFE87CA1230
        public void GetFrameRate_Injected(){} // RVA: 0x7FFE87CA16B0
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7FFE87CA12E0
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7FFE87CA1340
        public void ConnectInternal_Injected(){} // RVA: 0x7FFE87CA1710
        public void DisconnectInternal_Injected(){} // RVA: 0x7FFE87CA17A0
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7FFE87CA1810
    }

    public class PlayableHandle : ValueType
    {
        public UIntPtr m_Handle; // 0x10

        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFE810A1420
        public void IsPlayableOfType(){} // RVA: 0x7FFE80E2F150
        public void get_Null(){} // RVA: 0x7FFE87CA1870
        public void GetInput(){} // RVA: 0x7FFE87CA18E0
        public void SetInputWeight(){} // RVA: 0x7FFE87CA2DA0 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFE87CA1AC0
        public void Destroy(){} // RVA: 0x7FFE87CA1B90
        public void op_Equality(){} // RVA: 0x7FFE87CA1D20
        public void Equals(){} // RVA: 0x7FFE87CA1EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87CA1F50
        public void CompareVersion(){} // RVA: 0x7FFE848C3A80
        public void CheckInputBounds(){} // RVA: 0x7FFE87CA1FC0 | overloaded x2
        public void IsNull(){} // RVA: 0x7FFE87CA21E0
        public void IsValid(){} // RVA: 0x7FFE87CA2270
        public void GetPlayableType(){} // RVA: 0x7FFE87CA2300
        public void GetJobType(){} // RVA: 0x7FFE87CA2390
        public void SetScriptInstance(){} // RVA: 0x7FFE87CA2420
        public void GetPlayState(){} // RVA: 0x7FFE87CA24C0
        public void Play(){} // RVA: 0x7FFE87CA2550
        public void Pause(){} // RVA: 0x7FFE87CA25E0
        public void SetSpeed(){} // RVA: 0x7FFE87CA2670
        public void GetTime(){} // RVA: 0x7FFE87CA2710
        public void SetTime(){} // RVA: 0x7FFE87CA27A0
        public void IsDone(){} // RVA: 0x7FFE87CA2840
        public void SetDone(){} // RVA: 0x7FFE87CA28D0
        public void GetDuration(){} // RVA: 0x7FFE87CA2970
        public void SetDuration(){} // RVA: 0x7FFE87CA2A00
        public void SetPropagateSetTime(){} // RVA: 0x7FFE87CA2AA0
        public void GetGraph(){} // RVA: 0x7FFE87CA2B40
        public void GetInputCount(){} // RVA: 0x7FFE87CA2BE0
        public void SetInputCount(){} // RVA: 0x7FFE87CA2C70
        public void GetOutputCount(){} // RVA: 0x7FFE87CA2D10
        public void GetPreviousTime(){} // RVA: 0x7FFE87CA2E50
        public void SetTraversalMode(){} // RVA: 0x7FFE87CA2EE0
        public void GetJobData(){} // RVA: 0x7FFE87CA2F80
        public void GetTimeWrapMode(){} // RVA: 0x7FFE87CA3010
        public void SetTimeWrapMode(){} // RVA: 0x7FFE87CA30A0
        public void GetScriptInstance(){} // RVA: 0x7FFE87CA3140
        public void GetInputHandle(){} // RVA: 0x7FFE87CA31D0
        public void SetInputWeightFromIndex(){} // RVA: 0x7FFE87CA3280
        public void GetInputWeightFromIndex(){} // RVA: 0x7FFE87CA3330
        public void .cctor(){} // RVA: 0x7FFE87CA33D0
        public void IsNull_Injected(){} // RVA: 0x7FFE87CA3410
        public void IsValid_Injected(){} // RVA: 0x7FFE87CA3460
        public void GetPlayableType_Injected(){} // RVA: 0x7FFE87CA34B0
        public void GetJobType_Injected(){} // RVA: 0x7FFE87CA3500
        public void SetScriptInstance_Injected(){} // RVA: 0x7FFE87CA3550
        public void GetPlayState_Injected(){} // RVA: 0x7FFE87CA35B0
        public void Play_Injected(){} // RVA: 0x7FFE87CA3600
        public void Pause_Injected(){} // RVA: 0x7FFE87CA3650
        public void SetSpeed_Injected(){} // RVA: 0x7FFE87CA36A0
        public void GetTime_Injected(){} // RVA: 0x7FFE87CA3700
        public void SetTime_Injected(){} // RVA: 0x7FFE87CA3750
        public void IsDone_Injected(){} // RVA: 0x7FFE87CA37B0
        public void SetDone_Injected(){} // RVA: 0x7FFE87CA3800
        public void GetDuration_Injected(){} // RVA: 0x7FFE87CA3860
        public void SetDuration_Injected(){} // RVA: 0x7FFE87CA38B0
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7FFE87CA3910
        public void GetGraph_Injected(){} // RVA: 0x7FFE87CA3970
        public void GetInputCount_Injected(){} // RVA: 0x7FFE87CA39D0
        public void SetInputCount_Injected(){} // RVA: 0x7FFE87CA3A20
        public void GetOutputCount_Injected(){} // RVA: 0x7FFE87CA3A80
        public void SetInputWeight_Injected(){} // RVA: 0x7FFE87CA3AD0
        public void GetPreviousTime_Injected(){} // RVA: 0x7FFE87CA3B40
        public void SetTraversalMode_Injected(){} // RVA: 0x7FFE87CA3B90
        public void GetJobData_Injected(){} // RVA: 0x7FFE87CA3BF0
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7FFE87CA3C40
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7FFE87CA3C90
        public void GetScriptInstance_Injected(){} // RVA: 0x7FFE87CA3CF0
        public void GetInputHandle_Injected(){} // RVA: 0x7FFE87CA3D40
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7FFE87CA3DB0
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7FFE87CA3E20
    }

    public class PlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle m_Handle; // 0x10

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFE87CA3E80
        public void .ctor(){} // RVA: 0x7FFE827D9C10
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFE80E2F150
        public void Equals(){} // RVA: 0x7FFE87CA3EF0
        public void .cctor(){} // RVA: 0x7FFE87CA3FE0
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x7FFE810A1420
        public void SetReferenceObject(){} // RVA: 0x7FFE810A1420
        public void SetUserData(){} // RVA: 0x7FFE810A1420
        public void GetSourcePlayable(){} // RVA: 0x7FFE810A1420
        public void SetSourcePlayable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetSourceOutputPort(){} // RVA: 0x7FFE810A1420
        public void SetWeight(){} // RVA: 0x7FFE810A1420
        public void PushNotification(){} // RVA: 0x7FFE810A1420
        public void AddNotificationReceiver(){} // RVA: 0x7FFE810A1420
    }

    public class PlayableOutputHandle : ValueType
    {
        public UIntPtr m_Handle; // 0x10

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFE87CA4090
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFE80E2F150
        public void GetHashCode(){} // RVA: 0x7FFE87CA1F50
        public void op_Equality(){} // RVA: 0x7FFE87CA4100
        public void Equals(){} // RVA: 0x7FFE87CA42A0 | overloaded x2
        public void CompareVersion(){} // RVA: 0x7FFE848C3A80
        public void IsValid(){} // RVA: 0x7FFE87CA4330
        public void GetPlayableOutputType(){} // RVA: 0x7FFE87CA43C0
        public void SetReferenceObject(){} // RVA: 0x7FFE87CA4450
        public void SetUserData(){} // RVA: 0x7FFE87CA44F0
        public void GetSourcePlayable(){} // RVA: 0x7FFE87CA4590
        public void SetSourcePlayable(){} // RVA: 0x7FFE87CA4630
        public void GetSourceOutputPort(){} // RVA: 0x7FFE87CA46E0
        public void SetWeight(){} // RVA: 0x7FFE87CA4770
        public void PushNotification(){} // RVA: 0x7FFE87CA4810
        public void AddNotificationReceiver(){} // RVA: 0x7FFE87CA48D0
        public void .cctor(){} // RVA: 0x7FFE87CA4970
        public void IsValid_Injected(){} // RVA: 0x7FFE87CA49B0
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7FFE87CA4A00
        public void SetReferenceObject_Injected(){} // RVA: 0x7FFE87CA4A50
        public void SetUserData_Injected(){} // RVA: 0x7FFE87CA4AB0
        public void GetSourcePlayable_Injected(){} // RVA: 0x7FFE87CA4B10
        public void SetSourcePlayable_Injected(){} // RVA: 0x7FFE87CA4B70
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7FFE87CA4BE0
        public void SetWeight_Injected(){} // RVA: 0x7FFE87CA4C30
        public void PushNotification_Injected(){} // RVA: 0x7FFE87CA4C90
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7FFE87CA4D10
    }

    public class ScriptPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87CA4D70
        public void CreateScriptOutput(){} // RVA: 0x7FFE87CA4E70
    }

    public class ScriptPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87CA4FC0
        public void .ctor(){} // RVA: 0x7FFE87CA5110
        public void get_Null(){} // RVA: 0x7FFE87CA5200
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
    }

    public class ScriptPlayable`1 : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFE810A1420
        public void Create(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFE810A1420
        public void CreateScriptInstance(){} // RVA: 0x7FFE80E2DEE0
        public void CloneScriptInstance(){} // RVA: 0x7FFE80E2E3D0
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7FFE80E2E3D0
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7FFE80E2E3D0
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetHandle(){} // RVA: 0x7FFE810A1420
        public void GetBehaviour(){} // RVA: 0x7FFE810A1420
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void op_Explicit(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}