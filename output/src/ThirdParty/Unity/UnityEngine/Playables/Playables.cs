// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 20
// Methods: 334

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData : ValueType
    {
        public object deltaTime;
        public object effectiveSpeed;
        public object evaluationType;
        public object seekOccurred;
        public object timeLooped;
        public object timeHeld;
        public object output;
        public object effectivePlayState;

        // ── Methods ──
        public void HasFlags(){} // RVA: 0x7FFD54D171E0
        public void get_deltaTime(){} // RVA: 0x7FFD54D171F0
        public void get_effectiveSpeed(){} // RVA: 0x7FFD54C34E10
        public void get_evaluationType(){} // RVA: 0x7FFD54D17200
        public void get_seekOccurred(){} // RVA: 0x7FFD54D17210
        public void get_timeLooped(){} // RVA: 0x7FFD54D17220
        public void get_timeHeld(){} // RVA: 0x7FFD54D17230
        public void get_output(){} // RVA: 0x7FFD54D17240
        public void get_effectivePlayState(){} // RVA: 0x7FFD54D17250
    }

    public class FrameRate : ValueType
    {
        public object dropFrame;
        public object rate;

        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x7FFD53A4EBA0
        public void get_rate(){} // RVA: 0x7FFD54D17270
        public void .ctor(){} // RVA: 0x7FFD54D172E0
        public void IsValid(){} // RVA: 0x7FFD54C58C40
        public void Equals(){} // RVA: 0x7FFD54D17300 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54D173A0
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void ToString(){} // RVA: 0x7FFD54D17460 | overloaded x2
        public void DoubleToFrameRate(){} // RVA: 0x7FFD54D17670
        public void .cctor(){} // RVA: 0x7FFD54D177D0
    }

    public class INotification
    {
        public object id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E2ADC40
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPlayableAsset
    {
        public object duration;

        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFD4E07EB60
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x7FFD4E2ADC40
        public void OnBehaviourPause(){} // RVA: 0x7FFD4E2ADC40
        public void PrepareFrame(){} // RVA: 0x7FFD4E2ADC40
        public void ProcessFrame(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Playable : ValueType
    {
        public object Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFD54D178B0
        public void Create(){} // RVA: 0x7FFD54D17920
        public void .ctor(){} // RVA: 0x7FFD4F92BA60
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void IsPlayableOfType(){} // RVA: 0x7FFD4E079D00
        public void GetPlayableType(){} // RVA: 0x7FFD54D17A10
        public void Equals(){} // RVA: 0x7FFD54D17B10
        public void .cctor(){} // RVA: 0x7FFD54D17C00
    }

    public class PlayableAsset : ScriptableObject
    {
        public object duration;
        public object outputs;

        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7FFD54D17CB0
        public void get_outputs(){} // RVA: 0x7FFD54D17D10
        public void Internal_CreatePlayable(){} // RVA: 0x7FFD54D17D70
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7FFD54D17F00
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class PlayableBehaviour : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void OnGraphStart(){} // RVA: 0x7FFD4E341310
        public void OnGraphStop(){} // RVA: 0x7FFD4E341310
        public void OnPlayableCreate(){} // RVA: 0x7FFD4E341310
        public void OnPlayableDestroy(){} // RVA: 0x7FFD4E341310
        public void OnBehaviourPlay(){} // RVA: 0x7FFD4E341310
        public void OnBehaviourPause(){} // RVA: 0x7FFD4E341310
        public void PrepareFrame(){} // RVA: 0x7FFD4E341310
        public void ProcessFrame(){} // RVA: 0x7FFD4E341310
        public void Clone(){} // RVA: 0x7FFD54D17F40
    }

    public class PlayableDirector : Behaviour
    {
        public object state;
        public object extrapolationMode;
        public object playableAsset;
        public object playableGraph;
        public object playOnAwake;
        public object timeUpdateMode;
        public object time;
        public object initialTime;
        public object duration;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFD54D22030
        public void set_extrapolationMode(){} // RVA: 0x7FFD54D22080
        public void get_extrapolationMode(){} // RVA: 0x7FFD54D220E0
        public void get_playableAsset(){} // RVA: 0x7FFD54D22130
        public void set_playableAsset(){} // RVA: 0x7FFD54D22200
        public void get_playableGraph(){} // RVA: 0x7FFD54D22260
        public void get_playOnAwake(){} // RVA: 0x7FFD54D222E0
        public void set_playOnAwake(){} // RVA: 0x7FFD54D22330
        public void DeferredEvaluate(){} // RVA: 0x7FFD54D22390
        public void Play(){} // RVA: 0x7FFD54D22B30 | overloaded x4
        public void SetGenericBinding(){} // RVA: 0x7FFD54D227B0
        public void set_timeUpdateMode(){} // RVA: 0x7FFD54D22820
        public void get_timeUpdateMode(){} // RVA: 0x7FFD54D22880
        public void set_time(){} // RVA: 0x7FFD54D228D0
        public void get_time(){} // RVA: 0x7FFD54D22930
        public void set_initialTime(){} // RVA: 0x7FFD54D22980
        public void get_initialTime(){} // RVA: 0x7FFD54D229E0
        public void get_duration(){} // RVA: 0x7FFD54D22A30
        public void Evaluate(){} // RVA: 0x7FFD54D22A80
        public void PlayOnFrame(){} // RVA: 0x7FFD54D22AD0
        public void Stop(){} // RVA: 0x7FFD54D22B80
        public void Pause(){} // RVA: 0x7FFD54D22BD0
        public void Resume(){} // RVA: 0x7FFD54D22C20
        public void RebuildGraph(){} // RVA: 0x7FFD54D22C70
        public void ClearReferenceValue(){} // RVA: 0x7FFD54D22CC0
        public void SetReferenceValue(){} // RVA: 0x7FFD54D22D20
        public void GetReferenceValue(){} // RVA: 0x7FFD54D22D90
        public void GetGenericBinding(){} // RVA: 0x7FFD54D22E00
        public void ClearGenericBinding(){} // RVA: 0x7FFD54D22E60
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7FFD54D22EC0
        public void ProcessPendingGraphChanges(){} // RVA: 0x7FFD54D22F10
        public void HasGenericBinding(){} // RVA: 0x7FFD54D22F60
        public void GetPlayState(){} // RVA: 0x7FFD54D22030
        public void SetWrapMode(){} // RVA: 0x7FFD54D22080
        public void GetWrapMode(){} // RVA: 0x7FFD54D220E0
        public void EvaluateNextFrame(){} // RVA: 0x7FFD54D22390
        public void GetGraphHandle(){} // RVA: 0x7FFD54D22FC0
        public void SetPlayOnAwake(){} // RVA: 0x7FFD54D22330
        public void GetPlayOnAwake(){} // RVA: 0x7FFD54D222E0
        public void Internal_SetGenericBinding(){} // RVA: 0x7FFD54D227B0
        public void SetPlayableAsset(){} // RVA: 0x7FFD54D22200
        public void Internal_GetPlayableAsset(){} // RVA: 0x7FFD54D23030
        public void add_played(){} // RVA: 0x7FFD54D23080
        public void remove_played(){} // RVA: 0x7FFD54D23180
        public void add_paused(){} // RVA: 0x7FFD54D23280
        public void remove_paused(){} // RVA: 0x7FFD54D23380
        public void add_stopped(){} // RVA: 0x7FFD54D23480
        public void remove_stopped(){} // RVA: 0x7FFD54D23580
        public void ResetFrameTiming(){} // RVA: 0x7FFD54D23680
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7FFD54D236D0
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7FFD54D236F0
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7FFD54D23710
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void PlayOnFrame_Injected(){} // RVA: 0x7FFD54D23730
        public void ClearReferenceValue_Injected(){} // RVA: 0x7FFD54D23790
        public void SetReferenceValue_Injected(){} // RVA: 0x7FFD54D237F0
        public void GetReferenceValue_Injected(){} // RVA: 0x7FFD54D23860
        public void GetGraphHandle_Injected(){} // RVA: 0x7FFD54D238D0
    }

    public class PlayableExtensions : Object
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7FFD4E2ADC40
        public void IsValid(){} // RVA: 0x7FFD4E2ADC40
        public void Destroy(){} // RVA: 0x7FFD4E2ADC40
        public void GetGraph(){} // RVA: 0x7FFD4E2ADC40
        public void GetPlayState(){} // RVA: 0x7FFD4E2ADC40
        public void Play(){} // RVA: 0x7FFD4E2ADC40
        public void Pause(){} // RVA: 0x7FFD4E2ADC40
        public void SetSpeed(){} // RVA: 0x7FFD4E2ADC40
        public void SetDuration(){} // RVA: 0x7FFD4E2ADC40
        public void GetDuration(){} // RVA: 0x7FFD4E2ADC40
        public void SetTime(){} // RVA: 0x7FFD4E2ADC40
        public void GetTime(){} // RVA: 0x7FFD4E2ADC40
        public void GetPreviousTime(){} // RVA: 0x7FFD4E2ADC40
        public void IsDone(){} // RVA: 0x7FFD4E2ADC40
        public void SetPropagateSetTime(){} // RVA: 0x7FFD4E2ADC40
        public void SetInputCount(){} // RVA: 0x7FFD4E2ADC40
        public void GetInputCount(){} // RVA: 0x7FFD4E2ADC40
        public void GetOutputCount(){} // RVA: 0x7FFD4E2ADC40
        public void GetInput(){} // RVA: 0x7FFD4E2ADC40
        public void SetInputWeight(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFD4E2ADC40
        public void DisconnectInput(){} // RVA: 0x7FFD4E2ADC40
        public void SetTraversalMode(){} // RVA: 0x7FFD4E2ADC40
        public void GetTimeWrapMode(){} // RVA: 0x7FFD4E2ADC40
        public void SetTimeWrapMode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PlayableGraph : ValueType
    {
        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x7FFD54D18390
        public void Connect(){} // RVA: 0x7FFD4E2ADC40
        public void Disconnect(){} // RVA: 0x7FFD4E2ADC40
        public void DestroyPlayable(){} // RVA: 0x7FFD4E2ADC40
        public void GetOutputCountByType(){} // RVA: 0x7FFD4E079960
        public void GetOutputByType(){} // RVA: 0x7FFD4E2ADC40
        public void Evaluate(){} // RVA: 0x7FFD54D18680 | overloaded x2
        public void Create(){} // RVA: 0x7FFD54D18480
        public void Destroy(){} // RVA: 0x7FFD54D184F0
        public void IsValid(){} // RVA: 0x7FFD54D18540
        public void IsPlaying(){} // RVA: 0x7FFD54D18590
        public void Play(){} // RVA: 0x7FFD54D185E0
        public void Stop(){} // RVA: 0x7FFD54D18630
        public void GetResolver(){} // RVA: 0x7FFD54D186E0
        public void GetPlayableCount(){} // RVA: 0x7FFD54D18730
        public void GetRootPlayableCount(){} // RVA: 0x7FFD54D18780
        public void SynchronizeEvaluation(){} // RVA: 0x7FFD54D187D0
        public void CreatePlayableHandle(){} // RVA: 0x7FFD54D18830
        public void CreateScriptOutputInternal(){} // RVA: 0x7FFD54D188A0
        public void GetRootPlayableInternal(){} // RVA: 0x7FFD54D18910
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7FFD54D18990
        public void GetFrameRate(){} // RVA: 0x7FFD54D189E0
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7FFD54D18A40
        public void GetOutputByTypeInternal(){} // RVA: 0x7FFD54D18AA0
        public void ConnectInternal(){} // RVA: 0x7FFD54D18B20
        public void DisconnectInternal(){} // RVA: 0x7FFD54D18BB0
        public void DestroyPlayableInternal(){} // RVA: 0x7FFD54D18C20
        public void Create_Injected(){} // RVA: 0x7FFD54D18C80
        public void Destroy_Injected(){} // RVA: 0x7FFD54D184F0
        public void IsValid_Injected(){} // RVA: 0x7FFD54D18540
        public void IsPlaying_Injected(){} // RVA: 0x7FFD54D18590
        public void Play_Injected(){} // RVA: 0x7FFD54D185E0
        public void Stop_Injected(){} // RVA: 0x7FFD54D18630
        public void Evaluate_Injected(){} // RVA: 0x7FFD54D18680
        public void GetResolver_Injected(){} // RVA: 0x7FFD54D186E0
        public void GetPlayableCount_Injected(){} // RVA: 0x7FFD54D18730
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7FFD54D18780
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7FFD54D18CE0
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7FFD54D18D40
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7FFD54D188A0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7FFD54D18DA0
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7FFD54D18990
        public void GetFrameRate_Injected(){} // RVA: 0x7FFD54D18E10
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7FFD54D18A40
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7FFD54D18AA0
        public void ConnectInternal_Injected(){} // RVA: 0x7FFD54D18E70
        public void DisconnectInternal_Injected(){} // RVA: 0x7FFD54D18F00
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7FFD54D18F70
    }

    public class PlayableHandle : ValueType
    {
        public object Null;

        // ── Methods ──
        public void GetObject(){} // RVA: 0x7FFD4E2ADC40
        public void IsPlayableOfType(){} // RVA: 0x7FFD4E079D00
        public void get_Null(){} // RVA: 0x7FFD54D18FD0
        public void GetInput(){} // RVA: 0x7FFD54D19040
        public void SetInputWeight(){} // RVA: 0x7FFD54D1A500 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7FFD54D19220
        public void Destroy(){} // RVA: 0x7FFD54D192F0
        public void op_Equality(){} // RVA: 0x7FFD54D19480
        public void Equals(){} // RVA: 0x7FFD54D19620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D196B0
        public void CompareVersion(){} // RVA: 0x7FFD5195E020
        public void CheckInputBounds(){} // RVA: 0x7FFD54D19720 | overloaded x2
        public void IsNull(){} // RVA: 0x7FFD54D19940
        public void IsValid(){} // RVA: 0x7FFD54D199D0
        public void GetPlayableType(){} // RVA: 0x7FFD54D19A60
        public void GetJobType(){} // RVA: 0x7FFD54D19AF0
        public void SetScriptInstance(){} // RVA: 0x7FFD54D19B80
        public void GetPlayState(){} // RVA: 0x7FFD54D19C20
        public void Play(){} // RVA: 0x7FFD54D19CB0
        public void Pause(){} // RVA: 0x7FFD54D19D40
        public void SetSpeed(){} // RVA: 0x7FFD54D19DD0
        public void GetTime(){} // RVA: 0x7FFD54D19E70
        public void SetTime(){} // RVA: 0x7FFD54D19F00
        public void IsDone(){} // RVA: 0x7FFD54D19FA0
        public void SetDone(){} // RVA: 0x7FFD54D1A030
        public void GetDuration(){} // RVA: 0x7FFD54D1A0D0
        public void SetDuration(){} // RVA: 0x7FFD54D1A160
        public void SetPropagateSetTime(){} // RVA: 0x7FFD54D1A200
        public void GetGraph(){} // RVA: 0x7FFD54D1A2A0
        public void GetInputCount(){} // RVA: 0x7FFD54D1A340
        public void SetInputCount(){} // RVA: 0x7FFD54D1A3D0
        public void GetOutputCount(){} // RVA: 0x7FFD54D1A470
        public void GetPreviousTime(){} // RVA: 0x7FFD54D1A5B0
        public void SetTraversalMode(){} // RVA: 0x7FFD54D1A640
        public void GetJobData(){} // RVA: 0x7FFD54D1A6E0
        public void GetTimeWrapMode(){} // RVA: 0x7FFD54D1A770
        public void SetTimeWrapMode(){} // RVA: 0x7FFD54D1A800
        public void GetScriptInstance(){} // RVA: 0x7FFD54D1A8A0
        public void GetInputHandle(){} // RVA: 0x7FFD54D1A930
        public void SetInputWeightFromIndex(){} // RVA: 0x7FFD54D1A9E0
        public void GetInputWeightFromIndex(){} // RVA: 0x7FFD54D1AA90
        public void .cctor(){} // RVA: 0x7FFD54D1AB30
        public void IsNull_Injected(){} // RVA: 0x7FFD54D1AB70
        public void IsValid_Injected(){} // RVA: 0x7FFD54D1ABC0
        public void GetPlayableType_Injected(){} // RVA: 0x7FFD54D1AC10
        public void GetJobType_Injected(){} // RVA: 0x7FFD54D1AC60
        public void SetScriptInstance_Injected(){} // RVA: 0x7FFD54D1ACB0
        public void GetPlayState_Injected(){} // RVA: 0x7FFD54D1AD10
        public void Play_Injected(){} // RVA: 0x7FFD54D1AD60
        public void Pause_Injected(){} // RVA: 0x7FFD54D1ADB0
        public void SetSpeed_Injected(){} // RVA: 0x7FFD54D1AE00
        public void GetTime_Injected(){} // RVA: 0x7FFD54D1AE60
        public void SetTime_Injected(){} // RVA: 0x7FFD54D1AEB0
        public void IsDone_Injected(){} // RVA: 0x7FFD54D1AF10
        public void SetDone_Injected(){} // RVA: 0x7FFD54D1AF60
        public void GetDuration_Injected(){} // RVA: 0x7FFD54D1AFC0
        public void SetDuration_Injected(){} // RVA: 0x7FFD54D1B010
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7FFD54D1B070
        public void GetGraph_Injected(){} // RVA: 0x7FFD54D1B0D0
        public void GetInputCount_Injected(){} // RVA: 0x7FFD54D1B130
        public void SetInputCount_Injected(){} // RVA: 0x7FFD54D1B180
        public void GetOutputCount_Injected(){} // RVA: 0x7FFD54D1B1E0
        public void SetInputWeight_Injected(){} // RVA: 0x7FFD54D1B230
        public void GetPreviousTime_Injected(){} // RVA: 0x7FFD54D1B2A0
        public void SetTraversalMode_Injected(){} // RVA: 0x7FFD54D1B2F0
        public void GetJobData_Injected(){} // RVA: 0x7FFD54D1B350
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7FFD54D1B3A0
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7FFD54D1B3F0
        public void GetScriptInstance_Injected(){} // RVA: 0x7FFD54D1B450
        public void GetInputHandle_Injected(){} // RVA: 0x7FFD54D1B4A0
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7FFD54D1B510
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7FFD54D1B580
    }

    public class PlayableOutput : ValueType
    {
        public object Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFD54D1B5E0
        public void .ctor(){} // RVA: 0x7FFD4F92BA60
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFD4E079D00
        public void Equals(){} // RVA: 0x7FFD54D1B650
        public void .cctor(){} // RVA: 0x7FFD54D1B740
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x7FFD4E2ADC40
        public void SetReferenceObject(){} // RVA: 0x7FFD4E2ADC40
        public void SetUserData(){} // RVA: 0x7FFD4E2ADC40
        public void GetSourcePlayable(){} // RVA: 0x7FFD4E2ADC40
        public void SetSourcePlayable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetSourceOutputPort(){} // RVA: 0x7FFD4E2ADC40
        public void SetWeight(){} // RVA: 0x7FFD4E2ADC40
        public void PushNotification(){} // RVA: 0x7FFD4E2ADC40
        public void AddNotificationReceiver(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PlayableOutputHandle : ValueType
    {
        public object Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFD54D1B7F0
        public void IsPlayableOutputOfType(){} // RVA: 0x7FFD4E079D00
        public void GetHashCode(){} // RVA: 0x7FFD54D196B0
        public void op_Equality(){} // RVA: 0x7FFD54D1B860
        public void Equals(){} // RVA: 0x7FFD54D1BA00 | overloaded x2
        public void CompareVersion(){} // RVA: 0x7FFD5195E020
        public void IsValid(){} // RVA: 0x7FFD54D1BA90
        public void GetPlayableOutputType(){} // RVA: 0x7FFD54D1BB20
        public void SetReferenceObject(){} // RVA: 0x7FFD54D1BBB0
        public void SetUserData(){} // RVA: 0x7FFD54D1BC50
        public void GetSourcePlayable(){} // RVA: 0x7FFD54D1BCF0
        public void SetSourcePlayable(){} // RVA: 0x7FFD54D1BD90
        public void GetSourceOutputPort(){} // RVA: 0x7FFD54D1BE40
        public void SetWeight(){} // RVA: 0x7FFD54D1BED0
        public void PushNotification(){} // RVA: 0x7FFD54D1BF70
        public void AddNotificationReceiver(){} // RVA: 0x7FFD54D1C030
        public void .cctor(){} // RVA: 0x7FFD54D1C0D0
        public void IsValid_Injected(){} // RVA: 0x7FFD54D1C110
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7FFD54D1C160
        public void SetReferenceObject_Injected(){} // RVA: 0x7FFD54D1C1B0
        public void SetUserData_Injected(){} // RVA: 0x7FFD54D1C210
        public void GetSourcePlayable_Injected(){} // RVA: 0x7FFD54D1C270
        public void SetSourcePlayable_Injected(){} // RVA: 0x7FFD54D1C2D0
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7FFD54D1C340
        public void SetWeight_Injected(){} // RVA: 0x7FFD54D1C390
        public void PushNotification_Injected(){} // RVA: 0x7FFD54D1C3F0
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7FFD54D1C470
    }

    public class ScriptPlayableOutput : ValueType
    {
        public object Null;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54D1C720
        public void .ctor(){} // RVA: 0x7FFD54D1C870
        public void get_Null(){} // RVA: 0x7FFD54D1C960
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
    }

    public class ScriptPlayable`1 : ValueType
    {
        public object Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7FFD4E2ADC40
        public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CreateHandle(){} // RVA: 0x7FFD4E2ADC40
        public void CreateScriptInstance(){} // RVA: 0x7FFD4E078A90
        public void CloneScriptInstance(){} // RVA: 0x7FFD4E078F80
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7FFD4E078F80
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7FFD4E078F80
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetHandle(){} // RVA: 0x7FFD4E2ADC40
        public void GetBehaviour(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void op_Explicit(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}