// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 22
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData
    {
        // ── Methods ──
        public void HasFlags(){} // RVA: 0x7FFAF9C0F800
        public void get_deltaTime(){} // RVA: 0x7FFAF9C0F810
        public void get_effectiveSpeed(){} // RVA: 0x7FFAF9B2C4C0
        public void get_evaluationType(){} // RVA: 0x7FFAF9C0F820
        public void get_seekOccurred(){} // RVA: 0x7FFAF9C0F830
        public void get_timeLooped(){} // RVA: 0x7FFAF9C0F840
        public void get_timeHeld(){} // RVA: 0x7FFAF9C0F850
        public void get_output(){} // RVA: 0x7FFAF9C0F860
        public void get_effectivePlayState(){} // RVA: 0x7FFAF9C0F870
    }

    public class FrameRate
    {
        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x7FFAF8947530
        public void get_rate(){} // RVA: 0x7FFAF9C0F890
        public void .ctor(){} // RVA: 0x7FFAF9C0F900
        public void IsValid(){} // RVA: 0x7FFAF9B502D0
        public void Equals(){} // RVA: 0x7FFAF9C0F920 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF9C0F9C0
        public void GetHashCode(){} // RVA: 0x7FFAF92AD0D0
        public void ToString(){} // RVA: 0x7FFAF9C0FA80 | overloaded x2
        public void DoubleToFrameRate(){} // RVA: 0x7FFAF9C0FC90
        public void .cctor(){} // RVA: 0x7FFAF9C0FDF0
    }

    public class INotification
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAF2D33FA0
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IPlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFAF2AC2A40
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF2D33FA0
        public void OnBehaviourPause(){} // RVA: 0x7FFAF2D33FA0
        public void PrepareFrame(){} // RVA: 0x7FFAF2D33FA0
        public void ProcessFrame(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Playable
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAF9C0FED0
        public void Create(){} // RVA: 0x7FFAF9C0FF40
        public void .ctor(){} // RVA: 0x7FFAF4503740
        public void GetHandle(){} // RVA: 0x7FFAF6A77D30
        public void IsPlayableOfType(){} // RVA: 0x7FFAF2ABDBE0
        public void GetPlayableType(){} // RVA: 0x7FFAF9C10030
        public void Equals(){} // RVA: 0x7FFAF9C10130
        public void .cctor(){} // RVA: 0x7FFAF9C10220
    }

    public class PlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFAF9C102D0
        public void get_outputs(){} // RVA: 0x7FFAF9C10330
        public void Internal_CreatePlayable(){} // RVA: 0x7FFAF9C10390
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7FFAF9C10520
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class PlayableBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void OnGraphStart(){} // RVA: 0x7FFAF2D8D310
        public void OnGraphStop(){} // RVA: 0x7FFAF2D8D310
        public void OnPlayableCreate(){} // RVA: 0x7FFAF2D8D310
        public void OnPlayableDestroy(){} // RVA: 0x7FFAF2D8D310
        public void OnBehaviourPlay(){} // RVA: 0x7FFAF2D8D310
        public void OnBehaviourPause(){} // RVA: 0x7FFAF2D8D310
        public void PrepareFrame(){} // RVA: 0x7FFAF2D8D310
        public void ProcessFrame(){} // RVA: 0x7FFAF2D8D310
        public void Clone(){} // RVA: 0x7FFAF9C10560
    }

    public class PlayableBinding
    {
        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x7FFAF89CD510
        public void CreateOutput(){} // RVA: 0x7FFAF9C10570
        public void CreateInternal(){} // RVA: 0x7FFAF9C10670
        public void .cctor(){} // RVA: 0x7FFAF9C10810
    }

    public class PlayableDirector
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAF9C1A730
        public void set_extrapolationMode(){} // RVA: 0x7FFAF9C1A780
        public void get_extrapolationMode(){} // RVA: 0x7FFAF9C1A7E0
        public void get_playableAsset(){} // RVA: 0x7FFAF9C1A830
        public void set_playableAsset(){} // RVA: 0x7FFAF9C1A900
        public void get_playableGraph(){} // RVA: 0x7FFAF9C1A960
        public void get_playOnAwake(){} // RVA: 0x7FFAF9C1A9E0
        public void set_playOnAwake(){} // RVA: 0x7FFAF9C1AA30
        public void DeferredEvaluate(){} // RVA: 0x7FFAF9C1AA90
        public void Play(){} // RVA: 0x7FFAF9C1B230 | overloaded x4
        public void SetGenericBinding(){} // RVA: 0x7FFAF9C1AEB0
        public void set_timeUpdateMode(){} // RVA: 0x7FFAF9C1AF20
        public void get_timeUpdateMode(){} // RVA: 0x7FFAF9C1AF80
        public void set_time(){} // RVA: 0x7FFAF9C1AFD0
        public void get_time(){} // RVA: 0x7FFAF9C1B030
        public void set_initialTime(){} // RVA: 0x7FFAF9C1B080
        public void get_initialTime(){} // RVA: 0x7FFAF9C1B0E0
        public void get_duration(){} // RVA: 0x7FFAF9C1B130
        public void Evaluate(){} // RVA: 0x7FFAF9C1B180
        public void PlayOnFrame(){} // RVA: 0x7FFAF9C1B1D0
        public void Stop(){} // RVA: 0x7FFAF9C1B280
        public void Pause(){} // RVA: 0x7FFAF9C1B2D0
        public void Resume(){} // RVA: 0x7FFAF9C1B320
        public void RebuildGraph(){} // RVA: 0x7FFAF9C1B370
        public void ClearReferenceValue(){} // RVA: 0x7FFAF9C1B3C0
        public void SetReferenceValue(){} // RVA: 0x7FFAF9C1B420
        public void GetReferenceValue(){} // RVA: 0x7FFAF9C1B490
        public void GetGenericBinding(){} // RVA: 0x7FFAF9C1B500
        public void ClearGenericBinding(){} // RVA: 0x7FFAF9C1B560
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7FFAF9C1B5C0
        public void ProcessPendingGraphChanges(){} // RVA: 0x7FFAF9C1B610
        public void HasGenericBinding(){} // RVA: 0x7FFAF9C1B660
        public void GetPlayState(){} // RVA: 0x7FFAF9C1A730
        public void SetWrapMode(){} // RVA: 0x7FFAF9C1A780
        public void GetWrapMode(){} // RVA: 0x7FFAF9C1A7E0
        public void EvaluateNextFrame(){} // RVA: 0x7FFAF9C1AA90
        public void GetGraphHandle(){} // RVA: 0x7FFAF9C1B6C0
        public void SetPlayOnAwake(){} // RVA: 0x7FFAF9C1AA30
        public void GetPlayOnAwake(){} // RVA: 0x7FFAF9C1A9E0
        public void Internal_SetGenericBinding(){} // RVA: 0x7FFAF9C1AEB0
        public void SetPlayableAsset(){} // RVA: 0x7FFAF9C1A900
        public void Internal_GetPlayableAsset(){} // RVA: 0x7FFAF9C1B730
        public void add_played(){} // RVA: 0x7FFAF9C1B780
        public void remove_played(){} // RVA: 0x7FFAF9C1B880
        public void add_paused(){} // RVA: 0x7FFAF9C1B980
        public void remove_paused(){} // RVA: 0x7FFAF9C1BA80
        public void add_stopped(){} // RVA: 0x7FFAF9C1BB80
        public void remove_stopped(){} // RVA: 0x7FFAF9C1BC80
        public void ResetFrameTiming(){} // RVA: 0x7FFAF9C1BD80
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7FFAF9C1BDD0
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7FFAF9C1BDF0
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7FFAF9C1BE10
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void PlayOnFrame_Injected(){} // RVA: 0x7FFAF9C1BE30
        public void ClearReferenceValue_Injected(){} // RVA: 0x7FFAF9C1BE90
        public void SetReferenceValue_Injected(){} // RVA: 0x7FFAF9C1BEF0
        public void GetReferenceValue_Injected(){} // RVA: 0x7FFAF9C1BF60
        public void GetGraphHandle_Injected(){} // RVA: 0x7FFAF9C1BFD0
    }

    public class PlayableExtensions
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFAF2D33FA0
        public void IsValid(){} // RVA: 0x7FFAF2D33FA0
        public void Destroy(){} // RVA: 0x7FFAF2D33FA0
        public void GetGraph(){} // RVA: 0x7FFAF2D33FA0
        public void GetPlayState(){} // RVA: 0x7FFAF2D33FA0
        public void Play(){} // RVA: 0x7FFAF2D33FA0
        public void Pause(){} // RVA: 0x7FFAF2D33FA0
        public void SetSpeed(){} // RVA: 0x7FFAF2D33FA0
        public void SetDuration(){} // RVA: 0x7FFAF2D33FA0
        public void GetDuration(){} // RVA: 0x7FFAF2D33FA0
        public void SetTime(){} // RVA: 0x7FFAF2D33FA0
        public void GetTime(){} // RVA: 0x7FFAF2D33FA0
        public void GetPreviousTime(){} // RVA: 0x7FFAF2D33FA0
        public void IsDone(){} // RVA: 0x7FFAF2D33FA0
        public void SetPropagateSetTime(){} // RVA: 0x7FFAF2D33FA0
        public void SetInputCount(){} // RVA: 0x7FFAF2D33FA0
        public void GetInputCount(){} // RVA: 0x7FFAF2D33FA0
        public void GetOutputCount(){} // RVA: 0x7FFAF2D33FA0
        public void GetInput(){} // RVA: 0x7FFAF2D33FA0
        public void SetInputWeight(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFAF2D33FA0
        public void DisconnectInput(){} // RVA: 0x7FFAF2D33FA0
        public void SetTraversalMode(){} // RVA: 0x7FFAF2D33FA0
        public void GetTimeWrapMode(){} // RVA: 0x7FFAF2D33FA0
        public void SetTimeWrapMode(){} // RVA: 0x7FFAF2D33FA0
    }

    public class PlayableGraph
    {
        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x7FFAF9C109B0
        public void Connect(){} // RVA: 0x7FFAF2D33FA0
        public void Disconnect(){} // RVA: 0x7FFAF2D33FA0
        public void DestroyPlayable(){} // RVA: 0x7FFAF2D33FA0
        public void GetOutputCountByType(){} // RVA: 0x7FFAF2ABD840
        public void GetOutputByType(){} // RVA: 0x7FFAF2D33FA0
        public void Evaluate(){} // RVA: 0x7FFAF9C10CA0 | overloaded x2
        public void Create(){} // RVA: 0x7FFAF9C10AA0
        public void Destroy(){} // RVA: 0x7FFAF9C10B10
        public void IsValid(){} // RVA: 0x7FFAF9C10B60
        public void IsPlaying(){} // RVA: 0x7FFAF9C10BB0
        public void Play(){} // RVA: 0x7FFAF9C10C00
        public void Stop(){} // RVA: 0x7FFAF9C10C50
        public void GetResolver(){} // RVA: 0x7FFAF9C10D00
        public void GetPlayableCount(){} // RVA: 0x7FFAF9C10D50
        public void GetRootPlayableCount(){} // RVA: 0x7FFAF9C10DA0
        public void SynchronizeEvaluation(){} // RVA: 0x7FFAF9C10DF0
        public void CreatePlayableHandle(){} // RVA: 0x7FFAF9C10E50
        public void CreateScriptOutputInternal(){} // RVA: 0x7FFAF9C10EC0
        public void GetRootPlayableInternal(){} // RVA: 0x7FFAF9C10F30
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7FFAF9C10FB0
        public void GetFrameRate(){} // RVA: 0x7FFAF9C11000
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7FFAF9C11060
        public void GetOutputByTypeInternal(){} // RVA: 0x7FFAF9C110C0
        public void ConnectInternal(){} // RVA: 0x7FFAF9C11140
        public void DisconnectInternal(){} // RVA: 0x7FFAF9C111D0
        public void DestroyPlayableInternal(){} // RVA: 0x7FFAF9C11240
        public void Create_Injected(){} // RVA: 0x7FFAF9C112A0
        public void Destroy_Injected(){} // RVA: 0x7FFAF9C10B10
        public void IsValid_Injected(){} // RVA: 0x7FFAF9C10B60
        public void IsPlaying_Injected(){} // RVA: 0x7FFAF9C10BB0
        public void Play_Injected(){} // RVA: 0x7FFAF9C10C00
        public void Stop_Injected(){} // RVA: 0x7FFAF9C10C50
        public void Evaluate_Injected(){} // RVA: 0x7FFAF9C10CA0
        public void GetResolver_Injected(){} // RVA: 0x7FFAF9C10D00
        public void GetPlayableCount_Injected(){} // RVA: 0x7FFAF9C10D50
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7FFAF9C10DA0
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7FFAF9C11300
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7FFAF9C11360
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7FFAF9C10EC0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7FFAF9C113C0
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7FFAF9C10FB0
        public void GetFrameRate_Injected(){} // RVA: 0x7FFAF9C11430
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7FFAF9C11060
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7FFAF9C110C0
        public void ConnectInternal_Injected(){} // RVA: 0x7FFAF9C11490
        public void DisconnectInternal_Injected(){} // RVA: 0x7FFAF9C11520
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7FFAF9C11590
    }

    public class PlayableHandle
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFAF2D33FA0
        public void IsPlayableOfType(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Null(){} // RVA: 0x7FFAF9C115F0
        public void GetInput(){} // RVA: 0x7FFAF9C11660
        public void SetInputWeight(){} // RVA: 0x7FFAF9C12B20 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFAF9C11840
        public void Destroy(){} // RVA: 0x7FFAF9C11910
        public void op_Equality(){} // RVA: 0x7FFAF9C11AA0
        public void Equals(){} // RVA: 0x7FFAF9C11C40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9C11CD0
        public void CompareVersion(){} // RVA: 0x7FFAF66FE6B0
        public void CheckInputBounds(){} // RVA: 0x7FFAF9C11D40 | overloaded x2
        public void IsNull(){} // RVA: 0x7FFAF9C11F60
        public void IsValid(){} // RVA: 0x7FFAF9C11FF0
        public void GetPlayableType(){} // RVA: 0x7FFAF9C12080
        public void GetJobType(){} // RVA: 0x7FFAF9C12110
        public void SetScriptInstance(){} // RVA: 0x7FFAF9C121A0
        public void GetPlayState(){} // RVA: 0x7FFAF9C12240
        public void Play(){} // RVA: 0x7FFAF9C122D0
        public void Pause(){} // RVA: 0x7FFAF9C12360
        public void SetSpeed(){} // RVA: 0x7FFAF9C123F0
        public void GetTime(){} // RVA: 0x7FFAF9C12490
        public void SetTime(){} // RVA: 0x7FFAF9C12520
        public void IsDone(){} // RVA: 0x7FFAF9C125C0
        public void SetDone(){} // RVA: 0x7FFAF9C12650
        public void GetDuration(){} // RVA: 0x7FFAF9C126F0
        public void SetDuration(){} // RVA: 0x7FFAF9C12780
        public void SetPropagateSetTime(){} // RVA: 0x7FFAF9C12820
        public void GetGraph(){} // RVA: 0x7FFAF9C128C0
        public void GetInputCount(){} // RVA: 0x7FFAF9C12960
        public void SetInputCount(){} // RVA: 0x7FFAF9C129F0
        public void GetOutputCount(){} // RVA: 0x7FFAF9C12A90
        public void GetPreviousTime(){} // RVA: 0x7FFAF9C12BD0
        public void SetTraversalMode(){} // RVA: 0x7FFAF9C12C60
        public void GetJobData(){} // RVA: 0x7FFAF9C12D00
        public void GetTimeWrapMode(){} // RVA: 0x7FFAF9C12D90
        public void SetTimeWrapMode(){} // RVA: 0x7FFAF9C12E20
        public void GetScriptInstance(){} // RVA: 0x7FFAF9C12EC0
        public void GetInputHandle(){} // RVA: 0x7FFAF9C12F50
        public void SetInputWeightFromIndex(){} // RVA: 0x7FFAF9C13000
        public void GetInputWeightFromIndex(){} // RVA: 0x7FFAF9C130B0
        public void .cctor(){} // RVA: 0x7FFAF9C13150
        public void IsNull_Injected(){} // RVA: 0x7FFAF9C13190
        public void IsValid_Injected(){} // RVA: 0x7FFAF9C131E0
        public void GetPlayableType_Injected(){} // RVA: 0x7FFAF9C13230
        public void GetJobType_Injected(){} // RVA: 0x7FFAF9C13280
        public void SetScriptInstance_Injected(){} // RVA: 0x7FFAF9C132D0
        public void GetPlayState_Injected(){} // RVA: 0x7FFAF9C13330
        public void Play_Injected(){} // RVA: 0x7FFAF9C13380
        public void Pause_Injected(){} // RVA: 0x7FFAF9C133D0
        public void SetSpeed_Injected(){} // RVA: 0x7FFAF9C13420
        public void GetTime_Injected(){} // RVA: 0x7FFAF9C13480
        public void SetTime_Injected(){} // RVA: 0x7FFAF9C134D0
        public void IsDone_Injected(){} // RVA: 0x7FFAF9C13530
        public void SetDone_Injected(){} // RVA: 0x7FFAF9C13580
        public void GetDuration_Injected(){} // RVA: 0x7FFAF9C135E0
        public void SetDuration_Injected(){} // RVA: 0x7FFAF9C13630
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7FFAF9C13690
        public void GetGraph_Injected(){} // RVA: 0x7FFAF9C136F0
        public void GetInputCount_Injected(){} // RVA: 0x7FFAF9C13750
        public void SetInputCount_Injected(){} // RVA: 0x7FFAF9C137A0
        public void GetOutputCount_Injected(){} // RVA: 0x7FFAF9C13800
        public void SetInputWeight_Injected(){} // RVA: 0x7FFAF9C13850
        public void GetPreviousTime_Injected(){} // RVA: 0x7FFAF9C138C0
        public void SetTraversalMode_Injected(){} // RVA: 0x7FFAF9C13910
        public void GetJobData_Injected(){} // RVA: 0x7FFAF9C13970
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7FFAF9C139C0
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7FFAF9C13A10
        public void GetScriptInstance_Injected(){} // RVA: 0x7FFAF9C13A70
        public void GetInputHandle_Injected(){} // RVA: 0x7FFAF9C13AC0
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7FFAF9C13B30
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7FFAF9C13BA0
    }

    public class PlayableOutput
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAF9C13C00
        public void .ctor(){} // RVA: 0x7FFAF4503740
        public void GetHandle(){} // RVA: 0x7FFAF6A77D30
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFAF2ABDBE0
        public void Equals(){} // RVA: 0x7FFAF9C13C70
        public void .cctor(){} // RVA: 0x7FFAF9C13D60
    }

    public class PlayableOutputExtensions
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x7FFAF2D33FA0
        public void SetReferenceObject(){} // RVA: 0x7FFAF2D33FA0
        public void SetUserData(){} // RVA: 0x7FFAF2D33FA0
        public void GetSourcePlayable(){} // RVA: 0x7FFAF2D33FA0
        public void SetSourcePlayable(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetSourceOutputPort(){} // RVA: 0x7FFAF2D33FA0
        public void SetWeight(){} // RVA: 0x7FFAF2D33FA0
        public void PushNotification(){} // RVA: 0x7FFAF2D33FA0
        public void AddNotificationReceiver(){} // RVA: 0x7FFAF2D33FA0
    }

    public class PlayableOutputHandle
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAF9C13E10
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFAF2ABDBE0
        public void GetHashCode(){} // RVA: 0x7FFAF9C11CD0
        public void op_Equality(){} // RVA: 0x7FFAF9C13E80
        public void Equals(){} // RVA: 0x7FFAF9C14020 | overloaded x2
        public void CompareVersion(){} // RVA: 0x7FFAF66FE6B0
        public void IsValid(){} // RVA: 0x7FFAF9C140B0
        public void GetPlayableOutputType(){} // RVA: 0x7FFAF9C14140
        public void SetReferenceObject(){} // RVA: 0x7FFAF9C141D0
        public void SetUserData(){} // RVA: 0x7FFAF9C14270
        public void GetSourcePlayable(){} // RVA: 0x7FFAF9C14310
        public void SetSourcePlayable(){} // RVA: 0x7FFAF9C143B0
        public void GetSourceOutputPort(){} // RVA: 0x7FFAF9C14460
        public void SetWeight(){} // RVA: 0x7FFAF9C144F0
        public void PushNotification(){} // RVA: 0x7FFAF9C14590
        public void AddNotificationReceiver(){} // RVA: 0x7FFAF9C14650
        public void .cctor(){} // RVA: 0x7FFAF9C146F0
        public void IsValid_Injected(){} // RVA: 0x7FFAF9C14730
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7FFAF9C14780
        public void SetReferenceObject_Injected(){} // RVA: 0x7FFAF9C147D0
        public void SetUserData_Injected(){} // RVA: 0x7FFAF9C14830
        public void GetSourcePlayable_Injected(){} // RVA: 0x7FFAF9C14890
        public void SetSourcePlayable_Injected(){} // RVA: 0x7FFAF9C148F0
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7FFAF9C14960
        public void SetWeight_Injected(){} // RVA: 0x7FFAF9C149B0
        public void PushNotification_Injected(){} // RVA: 0x7FFAF9C14A10
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7FFAF9C14A90
    }

    public class ScriptPlayableBinding
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9C14AF0
        public void CreateScriptOutput(){} // RVA: 0x7FFAF9C14BF0
    }

    public class ScriptPlayableOutput
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9C14D40
        public void .ctor(){} // RVA: 0x7FFAF9C14E90
        public void get_Null(){} // RVA: 0x7FFAF9C14F80
        public void GetHandle(){} // RVA: 0x7FFAF6A77D30
        public void op_Implicit(){} // RVA: 0x7FFAF9B4C110
    }

    public class ScriptPlayable`1
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFAF2D33FA0
        public void Create(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFAF2D33FA0
        public void CreateScriptInstance(){} // RVA: 0x7FFAF2ABC960
        public void CloneScriptInstance(){} // RVA: 0x7FFAF2ABCE50
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7FFAF2ABCE50
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7FFAF2ABCE50
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void GetHandle(){} // RVA: 0x7FFAF2D33FA0
        public void GetBehaviour(){} // RVA: 0x7FFAF2D33FA0
        public void op_Implicit(){} // RVA: 0x7FFAF2D33FA0
        public void op_Explicit(){} // RVA: 0x7FFAF2D33FA0
        public void Equals(){} // RVA: 0x7FFAF2D33FA0
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

}