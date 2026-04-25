// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 22
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData : ValueType
    {
        public ulong deltaTime; // 0x10
        public double effectiveSpeed; // 0x18
        public float evaluationType; // 0x20
        public float seekOccurred; // 0x24
        public double timeLooped; // 0x28
        public float timeHeld; // 0x30
        public float output; // 0x34
        public 0x6B188258 effectivePlayState; // 0x38
        public UnityEngine.Playables.PlayableOutput m_Output; // 0x40

        // ── Methods ──
        public void HasFlags(){} // RVA: 0x7FFAC98F71E0
        public void get_deltaTime(){} // RVA: 0x7FFAC98F71F0
        public void get_effectiveSpeed(){} // RVA: 0x7FFAC9814E10
        public void get_evaluationType(){} // RVA: 0x7FFAC98F7200
        public void get_seekOccurred(){} // RVA: 0x7FFAC98F7210
        public void get_timeLooped(){} // RVA: 0x7FFAC98F7220
        public void get_timeHeld(){} // RVA: 0x7FFAC98F7230
        public void get_output(){} // RVA: 0x7FFAC98F7240
        public void get_effectivePlayState(){} // RVA: 0x7FFAC98F7250
    }

    public class FrameRate : ValueType
    {
        public UnityEngine.Playables.FrameRate dropFrame;
        public UnityEngine.Playables.FrameRate rate; // 0x4
        public UnityEngine.Playables.FrameRate k_25Fps; // 0x8
        public UnityEngine.Playables.FrameRate k_30Fps; // 0xC
        public UnityEngine.Playables.FrameRate k_29_97Fps; // 0x10
        public UnityEngine.Playables.FrameRate k_50Fps; // 0x14
        public UnityEngine.Playables.FrameRate k_60Fps; // 0x18
        public UnityEngine.Playables.FrameRate k_59_94Fps; // 0x1C
        public int m_Rate; // 0x10

        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x7FFAC862EBA0
        public void get_rate(){} // RVA: 0x7FFAC98F7270
        public void .ctor(){} // RVA: 0x7FFAC98F72E0
        public void IsValid(){} // RVA: 0x7FFAC9838C40
        public void Equals(){} // RVA: 0x7FFAC98F7300 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC98F73A0
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void ToString(){} // RVA: 0x7FFAC98F7460 | overloaded x2
        public void DoubleToFrameRate(){} // RVA: 0x7FFAC98F7670
        public void .cctor(){} // RVA: 0x7FFAC98F77D0
    }

    public class INotification
    {
        public object id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2E8DC40
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPlayableAsset
    {
        public object duration;

        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFAC2C5EB60
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC2E8DC40
        public void OnBehaviourPause(){} // RVA: 0x7FFAC2E8DC40
        public void PrepareFrame(){} // RVA: 0x7FFAC2E8DC40
        public void ProcessFrame(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Playable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle Null; // 0x10
        public UnityEngine.Playables.Playable m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAC98F78B0
        public void Create(){} // RVA: 0x7FFAC98F7920
        public void .ctor(){} // RVA: 0x7FFAC450BA60
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void IsPlayableOfType(){} // RVA: 0x7FFAC2C59D00
        public void GetPlayableType(){} // RVA: 0x7FFAC98F7A10
        public void Equals(){} // RVA: 0x7FFAC98F7B10
        public void .cctor(){} // RVA: 0x7FFAC98F7C00
    }

    public class PlayableAsset : ScriptableObject
    {
        public object duration;
        public object outputs;

        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFAC98F7CB0
        public void get_outputs(){} // RVA: 0x7FFAC98F7D10
        public void Internal_CreatePlayable(){} // RVA: 0x7FFAC98F7D70
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7FFAC98F7F00
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class PlayableBehaviour : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void OnGraphStart(){} // RVA: 0x7FFAC2F21310
        public void OnGraphStop(){} // RVA: 0x7FFAC2F21310
        public void OnPlayableCreate(){} // RVA: 0x7FFAC2F21310
        public void OnPlayableDestroy(){} // RVA: 0x7FFAC2F21310
        public void OnBehaviourPlay(){} // RVA: 0x7FFAC2F21310
        public void OnBehaviourPause(){} // RVA: 0x7FFAC2F21310
        public void PrepareFrame(){} // RVA: 0x7FFAC2F21310
        public void ProcessFrame(){} // RVA: 0x7FFAC2F21310
        public void Clone(){} // RVA: 0x7FFAC98F7F40
    }

    public class PlayableBinding : ValueType
    {
        public string sourceObject; // 0x10
        public UnityEngine.Object m_SourceObject; // 0x18
        public System.Type m_SourceBindingType; // 0x20
        public CreateOutputMethod m_CreateOutputMethod; // 0x28
        public UnityEngine.Playables.PlayableBinding[] None;
        public double DefaultDuration; // 0x8

        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x7FFAC86B4B80
        public void CreateOutput(){} // RVA: 0x7FFAC98F7F50
        public void CreateInternal(){} // RVA: 0x7FFAC98F8050
        public void .cctor(){} // RVA: 0x7FFAC98F81F0
    }

    public class PlayableDirector : Behaviour
    {
        public System.Action`1<UnityEngine.Playables.PlayableDirector> state; // 0x18
        public System.Action`1<UnityEngine.Playables.PlayableDirector> extrapolationMode; // 0x20
        public System.Action`1<UnityEngine.Playables.PlayableDirector> playableAsset; // 0x28

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAC9902030
        public void set_extrapolationMode(){} // RVA: 0x7FFAC9902080
        public void get_extrapolationMode(){} // RVA: 0x7FFAC99020E0
        public void get_playableAsset(){} // RVA: 0x7FFAC9902130
        public void set_playableAsset(){} // RVA: 0x7FFAC9902200
        public void get_playableGraph(){} // RVA: 0x7FFAC9902260
        public void get_playOnAwake(){} // RVA: 0x7FFAC99022E0
        public void set_playOnAwake(){} // RVA: 0x7FFAC9902330
        public void DeferredEvaluate(){} // RVA: 0x7FFAC9902390
        public void Play(){} // RVA: 0x7FFAC9902B30 | overloaded x4
        public void SetGenericBinding(){} // RVA: 0x7FFAC99027B0
        public void set_timeUpdateMode(){} // RVA: 0x7FFAC9902820
        public void get_timeUpdateMode(){} // RVA: 0x7FFAC9902880
        public void set_time(){} // RVA: 0x7FFAC99028D0
        public void get_time(){} // RVA: 0x7FFAC9902930
        public void set_initialTime(){} // RVA: 0x7FFAC9902980
        public void get_initialTime(){} // RVA: 0x7FFAC99029E0
        public void get_duration(){} // RVA: 0x7FFAC9902A30
        public void Evaluate(){} // RVA: 0x7FFAC9902A80
        public void PlayOnFrame(){} // RVA: 0x7FFAC9902AD0
        public void Stop(){} // RVA: 0x7FFAC9902B80
        public void Pause(){} // RVA: 0x7FFAC9902BD0
        public void Resume(){} // RVA: 0x7FFAC9902C20
        public void RebuildGraph(){} // RVA: 0x7FFAC9902C70
        public void ClearReferenceValue(){} // RVA: 0x7FFAC9902CC0
        public void SetReferenceValue(){} // RVA: 0x7FFAC9902D20
        public void GetReferenceValue(){} // RVA: 0x7FFAC9902D90
        public void GetGenericBinding(){} // RVA: 0x7FFAC9902E00
        public void ClearGenericBinding(){} // RVA: 0x7FFAC9902E60
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7FFAC9902EC0
        public void ProcessPendingGraphChanges(){} // RVA: 0x7FFAC9902F10
        public void HasGenericBinding(){} // RVA: 0x7FFAC9902F60
        public void GetPlayState(){} // RVA: 0x7FFAC9902030
        public void SetWrapMode(){} // RVA: 0x7FFAC9902080
        public void GetWrapMode(){} // RVA: 0x7FFAC99020E0
        public void EvaluateNextFrame(){} // RVA: 0x7FFAC9902390
        public void GetGraphHandle(){} // RVA: 0x7FFAC9902FC0
        public void SetPlayOnAwake(){} // RVA: 0x7FFAC9902330
        public void GetPlayOnAwake(){} // RVA: 0x7FFAC99022E0
        public void Internal_SetGenericBinding(){} // RVA: 0x7FFAC99027B0
        public void SetPlayableAsset(){} // RVA: 0x7FFAC9902200
        public void Internal_GetPlayableAsset(){} // RVA: 0x7FFAC9903030
        public void add_played(){} // RVA: 0x7FFAC9903080
        public void remove_played(){} // RVA: 0x7FFAC9903180
        public void add_paused(){} // RVA: 0x7FFAC9903280
        public void remove_paused(){} // RVA: 0x7FFAC9903380
        public void add_stopped(){} // RVA: 0x7FFAC9903480
        public void remove_stopped(){} // RVA: 0x7FFAC9903580
        public void ResetFrameTiming(){} // RVA: 0x7FFAC9903680
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7FFAC99036D0
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7FFAC99036F0
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7FFAC9903710
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void PlayOnFrame_Injected(){} // RVA: 0x7FFAC9903730
        public void ClearReferenceValue_Injected(){} // RVA: 0x7FFAC9903790
        public void SetReferenceValue_Injected(){} // RVA: 0x7FFAC99037F0
        public void GetReferenceValue_Injected(){} // RVA: 0x7FFAC9903860
        public void GetGraphHandle_Injected(){} // RVA: 0x7FFAC99038D0
    }

    public class PlayableExtensions : Object
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFAC2E8DC40
        public void IsValid(){} // RVA: 0x7FFAC2E8DC40
        public void Destroy(){} // RVA: 0x7FFAC2E8DC40
        public void GetGraph(){} // RVA: 0x7FFAC2E8DC40
        public void GetPlayState(){} // RVA: 0x7FFAC2E8DC40
        public void Play(){} // RVA: 0x7FFAC2E8DC40
        public void Pause(){} // RVA: 0x7FFAC2E8DC40
        public void SetSpeed(){} // RVA: 0x7FFAC2E8DC40
        public void SetDuration(){} // RVA: 0x7FFAC2E8DC40
        public void GetDuration(){} // RVA: 0x7FFAC2E8DC40
        public void SetTime(){} // RVA: 0x7FFAC2E8DC40
        public void GetTime(){} // RVA: 0x7FFAC2E8DC40
        public void GetPreviousTime(){} // RVA: 0x7FFAC2E8DC40
        public void IsDone(){} // RVA: 0x7FFAC2E8DC40
        public void SetPropagateSetTime(){} // RVA: 0x7FFAC2E8DC40
        public void SetInputCount(){} // RVA: 0x7FFAC2E8DC40
        public void GetInputCount(){} // RVA: 0x7FFAC2E8DC40
        public void GetOutputCount(){} // RVA: 0x7FFAC2E8DC40
        public void GetInput(){} // RVA: 0x7FFAC2E8DC40
        public void SetInputWeight(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFAC2E8DC40
        public void DisconnectInput(){} // RVA: 0x7FFAC2E8DC40
        public void SetTraversalMode(){} // RVA: 0x7FFAC2E8DC40
        public void GetTimeWrapMode(){} // RVA: 0x7FFAC2E8DC40
        public void SetTimeWrapMode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PlayableGraph : ValueType
    {
        public UIntPtr m_Handle; // 0x10
        public uint m_Version; // 0x18

        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x7FFAC98F8390
        public void Connect(){} // RVA: 0x7FFAC2E8DC40
        public void Disconnect(){} // RVA: 0x7FFAC2E8DC40
        public void DestroyPlayable(){} // RVA: 0x7FFAC2E8DC40
        public void GetOutputCountByType(){} // RVA: 0x7FFAC2C59960
        public void GetOutputByType(){} // RVA: 0x7FFAC2E8DC40
        public void Evaluate(){} // RVA: 0x7FFAC98F8680 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC98F8480
        public void Destroy(){} // RVA: 0x7FFAC98F84F0
        public void IsValid(){} // RVA: 0x7FFAC98F8540
        public void IsPlaying(){} // RVA: 0x7FFAC98F8590
        public void Play(){} // RVA: 0x7FFAC98F85E0
        public void Stop(){} // RVA: 0x7FFAC98F8630
        public void GetResolver(){} // RVA: 0x7FFAC98F86E0
        public void GetPlayableCount(){} // RVA: 0x7FFAC98F8730
        public void GetRootPlayableCount(){} // RVA: 0x7FFAC98F8780
        public void SynchronizeEvaluation(){} // RVA: 0x7FFAC98F87D0
        public void CreatePlayableHandle(){} // RVA: 0x7FFAC98F8830
        public void CreateScriptOutputInternal(){} // RVA: 0x7FFAC98F88A0
        public void GetRootPlayableInternal(){} // RVA: 0x7FFAC98F8910
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7FFAC98F8990
        public void GetFrameRate(){} // RVA: 0x7FFAC98F89E0
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7FFAC98F8A40
        public void GetOutputByTypeInternal(){} // RVA: 0x7FFAC98F8AA0
        public void ConnectInternal(){} // RVA: 0x7FFAC98F8B20
        public void DisconnectInternal(){} // RVA: 0x7FFAC98F8BB0
        public void DestroyPlayableInternal(){} // RVA: 0x7FFAC98F8C20
        public void Create_Injected(){} // RVA: 0x7FFAC98F8C80
        public void Destroy_Injected(){} // RVA: 0x7FFAC98F84F0
        public void IsValid_Injected(){} // RVA: 0x7FFAC98F8540
        public void IsPlaying_Injected(){} // RVA: 0x7FFAC98F8590
        public void Play_Injected(){} // RVA: 0x7FFAC98F85E0
        public void Stop_Injected(){} // RVA: 0x7FFAC98F8630
        public void Evaluate_Injected(){} // RVA: 0x7FFAC98F8680
        public void GetResolver_Injected(){} // RVA: 0x7FFAC98F86E0
        public void GetPlayableCount_Injected(){} // RVA: 0x7FFAC98F8730
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7FFAC98F8780
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7FFAC98F8CE0
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7FFAC98F8D40
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7FFAC98F88A0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7FFAC98F8DA0
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7FFAC98F8990
        public void GetFrameRate_Injected(){} // RVA: 0x7FFAC98F8E10
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7FFAC98F8A40
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7FFAC98F8AA0
        public void ConnectInternal_Injected(){} // RVA: 0x7FFAC98F8E70
        public void DisconnectInternal_Injected(){} // RVA: 0x7FFAC98F8F00
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7FFAC98F8F70
    }

    public class PlayableHandle : ValueType
    {
        public UIntPtr Null; // 0x10
        public uint m_Version; // 0x18
        public UnityEngine.Playables.PlayableHandle m_Null;

        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFAC2E8DC40
        public void IsPlayableOfType(){} // RVA: 0x7FFAC2C59D00
        public void get_Null(){} // RVA: 0x7FFAC98F8FD0
        public void GetInput(){} // RVA: 0x7FFAC98F9040
        public void SetInputWeight(){} // RVA: 0x7FFAC98FA500 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFAC98F9220
        public void Destroy(){} // RVA: 0x7FFAC98F92F0
        public void op_Equality(){} // RVA: 0x7FFAC98F9480
        public void Equals(){} // RVA: 0x7FFAC98F9620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F96B0
        public void CompareVersion(){} // RVA: 0x7FFAC653E020
        public void CheckInputBounds(){} // RVA: 0x7FFAC98F9720 | overloaded x2
        public void IsNull(){} // RVA: 0x7FFAC98F9940
        public void IsValid(){} // RVA: 0x7FFAC98F99D0
        public void GetPlayableType(){} // RVA: 0x7FFAC98F9A60
        public void GetJobType(){} // RVA: 0x7FFAC98F9AF0
        public void SetScriptInstance(){} // RVA: 0x7FFAC98F9B80
        public void GetPlayState(){} // RVA: 0x7FFAC98F9C20
        public void Play(){} // RVA: 0x7FFAC98F9CB0
        public void Pause(){} // RVA: 0x7FFAC98F9D40
        public void SetSpeed(){} // RVA: 0x7FFAC98F9DD0
        public void GetTime(){} // RVA: 0x7FFAC98F9E70
        public void SetTime(){} // RVA: 0x7FFAC98F9F00
        public void IsDone(){} // RVA: 0x7FFAC98F9FA0
        public void SetDone(){} // RVA: 0x7FFAC98FA030
        public void GetDuration(){} // RVA: 0x7FFAC98FA0D0
        public void SetDuration(){} // RVA: 0x7FFAC98FA160
        public void SetPropagateSetTime(){} // RVA: 0x7FFAC98FA200
        public void GetGraph(){} // RVA: 0x7FFAC98FA2A0
        public void GetInputCount(){} // RVA: 0x7FFAC98FA340
        public void SetInputCount(){} // RVA: 0x7FFAC98FA3D0
        public void GetOutputCount(){} // RVA: 0x7FFAC98FA470
        public void GetPreviousTime(){} // RVA: 0x7FFAC98FA5B0
        public void SetTraversalMode(){} // RVA: 0x7FFAC98FA640
        public void GetJobData(){} // RVA: 0x7FFAC98FA6E0
        public void GetTimeWrapMode(){} // RVA: 0x7FFAC98FA770
        public void SetTimeWrapMode(){} // RVA: 0x7FFAC98FA800
        public void GetScriptInstance(){} // RVA: 0x7FFAC98FA8A0
        public void GetInputHandle(){} // RVA: 0x7FFAC98FA930
        public void SetInputWeightFromIndex(){} // RVA: 0x7FFAC98FA9E0
        public void GetInputWeightFromIndex(){} // RVA: 0x7FFAC98FAA90
        public void .cctor(){} // RVA: 0x7FFAC98FAB30
        public void IsNull_Injected(){} // RVA: 0x7FFAC98FAB70
        public void IsValid_Injected(){} // RVA: 0x7FFAC98FABC0
        public void GetPlayableType_Injected(){} // RVA: 0x7FFAC98FAC10
        public void GetJobType_Injected(){} // RVA: 0x7FFAC98FAC60
        public void SetScriptInstance_Injected(){} // RVA: 0x7FFAC98FACB0
        public void GetPlayState_Injected(){} // RVA: 0x7FFAC98FAD10
        public void Play_Injected(){} // RVA: 0x7FFAC98FAD60
        public void Pause_Injected(){} // RVA: 0x7FFAC98FADB0
        public void SetSpeed_Injected(){} // RVA: 0x7FFAC98FAE00
        public void GetTime_Injected(){} // RVA: 0x7FFAC98FAE60
        public void SetTime_Injected(){} // RVA: 0x7FFAC98FAEB0
        public void IsDone_Injected(){} // RVA: 0x7FFAC98FAF10
        public void SetDone_Injected(){} // RVA: 0x7FFAC98FAF60
        public void GetDuration_Injected(){} // RVA: 0x7FFAC98FAFC0
        public void SetDuration_Injected(){} // RVA: 0x7FFAC98FB010
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7FFAC98FB070
        public void GetGraph_Injected(){} // RVA: 0x7FFAC98FB0D0
        public void GetInputCount_Injected(){} // RVA: 0x7FFAC98FB130
        public void SetInputCount_Injected(){} // RVA: 0x7FFAC98FB180
        public void GetOutputCount_Injected(){} // RVA: 0x7FFAC98FB1E0
        public void SetInputWeight_Injected(){} // RVA: 0x7FFAC98FB230
        public void GetPreviousTime_Injected(){} // RVA: 0x7FFAC98FB2A0
        public void SetTraversalMode_Injected(){} // RVA: 0x7FFAC98FB2F0
        public void GetJobData_Injected(){} // RVA: 0x7FFAC98FB350
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7FFAC98FB3A0
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7FFAC98FB3F0
        public void GetScriptInstance_Injected(){} // RVA: 0x7FFAC98FB450
        public void GetInputHandle_Injected(){} // RVA: 0x7FFAC98FB4A0
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7FFAC98FB510
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7FFAC98FB580
    }

    public class PlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle Null; // 0x10
        public UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAC98FB5E0
        public void .ctor(){} // RVA: 0x7FFAC450BA60
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFAC2C59D00
        public void Equals(){} // RVA: 0x7FFAC98FB650
        public void .cctor(){} // RVA: 0x7FFAC98FB740
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x7FFAC2E8DC40
        public void SetReferenceObject(){} // RVA: 0x7FFAC2E8DC40
        public void SetUserData(){} // RVA: 0x7FFAC2E8DC40
        public void GetSourcePlayable(){} // RVA: 0x7FFAC2E8DC40
        public void SetSourcePlayable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetSourceOutputPort(){} // RVA: 0x7FFAC2E8DC40
        public void SetWeight(){} // RVA: 0x7FFAC2E8DC40
        public void PushNotification(){} // RVA: 0x7FFAC2E8DC40
        public void AddNotificationReceiver(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PlayableOutputHandle : ValueType
    {
        public UIntPtr Null; // 0x10
        public uint m_Version; // 0x18
        public UnityEngine.Playables.PlayableOutputHandle m_Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAC98FB7F0
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFAC2C59D00
        public void GetHashCode(){} // RVA: 0x7FFAC98F96B0
        public void op_Equality(){} // RVA: 0x7FFAC98FB860
        public void Equals(){} // RVA: 0x7FFAC98FBA00 | overloaded x2
        public void CompareVersion(){} // RVA: 0x7FFAC653E020
        public void IsValid(){} // RVA: 0x7FFAC98FBA90
        public void GetPlayableOutputType(){} // RVA: 0x7FFAC98FBB20
        public void SetReferenceObject(){} // RVA: 0x7FFAC98FBBB0
        public void SetUserData(){} // RVA: 0x7FFAC98FBC50
        public void GetSourcePlayable(){} // RVA: 0x7FFAC98FBCF0
        public void SetSourcePlayable(){} // RVA: 0x7FFAC98FBD90
        public void GetSourceOutputPort(){} // RVA: 0x7FFAC98FBE40
        public void SetWeight(){} // RVA: 0x7FFAC98FBED0
        public void PushNotification(){} // RVA: 0x7FFAC98FBF70
        public void AddNotificationReceiver(){} // RVA: 0x7FFAC98FC030
        public void .cctor(){} // RVA: 0x7FFAC98FC0D0
        public void IsValid_Injected(){} // RVA: 0x7FFAC98FC110
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7FFAC98FC160
        public void SetReferenceObject_Injected(){} // RVA: 0x7FFAC98FC1B0
        public void SetUserData_Injected(){} // RVA: 0x7FFAC98FC210
        public void GetSourcePlayable_Injected(){} // RVA: 0x7FFAC98FC270
        public void SetSourcePlayable_Injected(){} // RVA: 0x7FFAC98FC2D0
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7FFAC98FC340
        public void SetWeight_Injected(){} // RVA: 0x7FFAC98FC390
        public void PushNotification_Injected(){} // RVA: 0x7FFAC98FC3F0
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7FFAC98FC470
    }

    public class ScriptPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC98FC4D0
        public void CreateScriptOutput(){} // RVA: 0x7FFAC98FC5D0
    }

    public class ScriptPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle Null; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC98FC720
        public void .ctor(){} // RVA: 0x7FFAC98FC870
        public void get_Null(){} // RVA: 0x7FFAC98FC960
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
    }

    public class ScriptPlayable`1 : ValueType
    {
        public UnityEngine.Playables.PlayableHandle Null;
        public UnityEngine.Playables.ScriptPlayable`1<T> m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAC2E8DC40
        public void Create(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFAC2E8DC40
        public void CreateScriptInstance(){} // RVA: 0x7FFAC2C58A90
        public void CloneScriptInstance(){} // RVA: 0x7FFAC2C58F80
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7FFAC2C58F80
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7FFAC2C58F80
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetHandle(){} // RVA: 0x7FFAC2E8DC40
        public void GetBehaviour(){} // RVA: 0x7FFAC2E8DC40
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void op_Explicit(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}