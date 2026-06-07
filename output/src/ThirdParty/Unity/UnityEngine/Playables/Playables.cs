// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 22
// Methods: 340

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData
    {
        // ── Methods ──
        public void HasFlags(){} // RVA: 0x715F800
        public void get_deltaTime(){} // RVA: 0x715F810
        public void get_effectiveSpeed(){} // RVA: 0x707C4C0
        public void get_evaluationType(){} // RVA: 0x715F820
        public void get_seekOccurred(){} // RVA: 0x715F830
        public void get_timeLooped(){} // RVA: 0x715F840
        public void get_timeHeld(){} // RVA: 0x715F850
        public void get_output(){} // RVA: 0x715F860
        public void get_effectivePlayState(){} // RVA: 0x715F870
    }

    public class FrameRate
    {
        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x5E97530
        public void get_rate(){} // RVA: 0x715F890
        public void .ctor(){} // RVA: 0x715F900
        public void IsValid(){} // RVA: 0x70A02D0
        public void Equals(){} // RVA: 0x715F920 | overloaded x2
        public void op_Equality(){} // RVA: 0x715F9C0
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void ToString(){} // RVA: 0x715FA80 | overloaded x2
        public void DoubleToFrameRate(){} // RVA: 0x715FC90
        public void .cctor(){} // RVA: 0x715FDF0
    }

    public class INotification
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x283FA0
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x283FA0
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x283FA0
    }

    public class IPlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x12A40
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x283FA0
        public void OnBehaviourPause(){} // RVA: 0x283FA0
        public void PrepareFrame(){} // RVA: 0x283FA0
        public void ProcessFrame(){} // RVA: 0x283FA0
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x283FA0
    }

    public class Playable
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x715FED0
        public void Create(){} // RVA: 0x715FF40
        public void .ctor(){} // RVA: 0x1A53740
        public void GetHandle(){} // RVA: 0x3FC7D30
        public void IsPlayableOfType(){} // RVA: 0xDBE0
        public void GetPlayableType(){} // RVA: 0x7160030
        public void Equals(){} // RVA: 0x7160130
        public void .cctor(){} // RVA: 0x7160220
    }

    public class PlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x71602D0
        public void get_outputs(){} // RVA: 0x7160330
        public void Internal_CreatePlayable(){} // RVA: 0x7160390
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7160520
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class PlayableBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void OnGraphStart(){} // RVA: 0x2DD310
        public void OnGraphStop(){} // RVA: 0x2DD310
        public void OnPlayableCreate(){} // RVA: 0x2DD310
        public void OnPlayableDestroy(){} // RVA: 0x2DD310
        public void OnBehaviourPlay(){} // RVA: 0x2DD310
        public void OnBehaviourPause(){} // RVA: 0x2DD310
        public void PrepareFrame(){} // RVA: 0x2DD310
        public void ProcessFrame(){} // RVA: 0x2DD310
        public void Clone(){} // RVA: 0x7160560
    }

    public class PlayableBinding
    {
        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x5F1D510
        public void CreateOutput(){} // RVA: 0x7160570
        public void CreateInternal(){} // RVA: 0x7160670
        public void .cctor(){} // RVA: 0x7160810
    }

    public class PlayableDirector
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x716A730
        public void set_extrapolationMode(){} // RVA: 0x716A780
        public void get_extrapolationMode(){} // RVA: 0x716A7E0
        public void get_playableAsset(){} // RVA: 0x716A830
        public void set_playableAsset(){} // RVA: 0x716A900
        public void get_playableGraph(){} // RVA: 0x716A960
        public void get_playOnAwake(){} // RVA: 0x716A9E0
        public void set_playOnAwake(){} // RVA: 0x716AA30
        public void DeferredEvaluate(){} // RVA: 0x716AA90
        public void Play(){} // RVA: 0x716B230 | overloaded x4
        public void SetGenericBinding(){} // RVA: 0x716AEB0
        public void set_timeUpdateMode(){} // RVA: 0x716AF20
        public void get_timeUpdateMode(){} // RVA: 0x716AF80
        public void set_time(){} // RVA: 0x716AFD0
        public void get_time(){} // RVA: 0x716B030
        public void set_initialTime(){} // RVA: 0x716B080
        public void get_initialTime(){} // RVA: 0x716B0E0
        public void get_duration(){} // RVA: 0x716B130
        public void Evaluate(){} // RVA: 0x716B180
        public void PlayOnFrame(){} // RVA: 0x716B1D0
        public void Stop(){} // RVA: 0x716B280
        public void Pause(){} // RVA: 0x716B2D0
        public void Resume(){} // RVA: 0x716B320
        public void RebuildGraph(){} // RVA: 0x716B370
        public void ClearReferenceValue(){} // RVA: 0x716B3C0
        public void SetReferenceValue(){} // RVA: 0x716B420
        public void GetReferenceValue(){} // RVA: 0x716B490
        public void GetGenericBinding(){} // RVA: 0x716B500
        public void ClearGenericBinding(){} // RVA: 0x716B560
        public void RebindPlayableGraphOutputs(){} // RVA: 0x716B5C0
        public void ProcessPendingGraphChanges(){} // RVA: 0x716B610
        public void HasGenericBinding(){} // RVA: 0x716B660
        public void GetPlayState(){} // RVA: 0x716A730
        public void SetWrapMode(){} // RVA: 0x716A780
        public void GetWrapMode(){} // RVA: 0x716A7E0
        public void EvaluateNextFrame(){} // RVA: 0x716AA90
        public void GetGraphHandle(){} // RVA: 0x716B6C0
        public void SetPlayOnAwake(){} // RVA: 0x716AA30
        public void GetPlayOnAwake(){} // RVA: 0x716A9E0
        public void Internal_SetGenericBinding(){} // RVA: 0x716AEB0
        public void SetPlayableAsset(){} // RVA: 0x716A900
        public void Internal_GetPlayableAsset(){} // RVA: 0x716B730
        public void add_played(){} // RVA: 0x716B780
        public void remove_played(){} // RVA: 0x716B880
        public void add_paused(){} // RVA: 0x716B980
        public void remove_paused(){} // RVA: 0x716BA80
        public void add_stopped(){} // RVA: 0x716BB80
        public void remove_stopped(){} // RVA: 0x716BC80
        public void ResetFrameTiming(){} // RVA: 0x716BD80
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x716BDD0
        public void SendOnPlayableDirectorPause(){} // RVA: 0x716BDF0
        public void SendOnPlayableDirectorStop(){} // RVA: 0x716BE10
        public void .ctor(){} // RVA: 0x2DDD50
        public void PlayOnFrame_Injected(){} // RVA: 0x716BE30
        public void ClearReferenceValue_Injected(){} // RVA: 0x716BE90
        public void SetReferenceValue_Injected(){} // RVA: 0x716BEF0
        public void GetReferenceValue_Injected(){} // RVA: 0x716BF60
        public void GetGraphHandle_Injected(){} // RVA: 0x716BFD0
    }

    public class PlayableExtensions
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x283FA0
        public void IsValid(){} // RVA: 0x283FA0
        public void Destroy(){} // RVA: 0x283FA0
        public void GetGraph(){} // RVA: 0x283FA0
        public void GetPlayState(){} // RVA: 0x283FA0
        public void Play(){} // RVA: 0x283FA0
        public void Pause(){} // RVA: 0x283FA0
        public void SetSpeed(){} // RVA: 0x283FA0
        public void SetDuration(){} // RVA: 0x283FA0
        public void GetDuration(){} // RVA: 0x283FA0
        public void SetTime(){} // RVA: 0x283FA0
        public void GetTime(){} // RVA: 0x283FA0
        public void GetPreviousTime(){} // RVA: 0x283FA0
        public void IsDone(){} // RVA: 0x283FA0
        public void SetPropagateSetTime(){} // RVA: 0x283FA0
        public void SetInputCount(){} // RVA: 0x283FA0
        public void GetInputCount(){} // RVA: 0x283FA0
        public void GetOutputCount(){} // RVA: 0x283FA0
        public void GetInput(){} // RVA: 0x283FA0
        public void SetInputWeight(){} // RVA: 0x283FA0 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x283FA0
        public void DisconnectInput(){} // RVA: 0x283FA0
        public void SetTraversalMode(){} // RVA: 0x283FA0
        public void GetTimeWrapMode(){} // RVA: 0x283FA0
        public void SetTimeWrapMode(){} // RVA: 0x283FA0
    }

    public class PlayableGraph
    {
        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x71609B0
        public void Connect(){} // RVA: 0x283FA0
        public void Disconnect(){} // RVA: 0x283FA0
        public void DestroyPlayable(){} // RVA: 0x283FA0
        public void GetOutputCountByType(){} // RVA: 0xD840
        public void GetOutputByType(){} // RVA: 0x283FA0
        public void Evaluate(){} // RVA: 0x7160CA0 | overloaded x2
        public void Create(){} // RVA: 0x7160AA0
        public void Destroy(){} // RVA: 0x7160B10
        public void IsValid(){} // RVA: 0x7160B60
        public void IsPlaying(){} // RVA: 0x7160BB0
        public void Play(){} // RVA: 0x7160C00
        public void Stop(){} // RVA: 0x7160C50
        public void GetResolver(){} // RVA: 0x7160D00
        public void GetPlayableCount(){} // RVA: 0x7160D50
        public void GetRootPlayableCount(){} // RVA: 0x7160DA0
        public void SynchronizeEvaluation(){} // RVA: 0x7160DF0
        public void CreatePlayableHandle(){} // RVA: 0x7160E50
        public void CreateScriptOutputInternal(){} // RVA: 0x7160EC0
        public void GetRootPlayableInternal(){} // RVA: 0x7160F30
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7160FB0
        public void GetFrameRate(){} // RVA: 0x7161000
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7161060
        public void GetOutputByTypeInternal(){} // RVA: 0x71610C0
        public void ConnectInternal(){} // RVA: 0x7161140
        public void DisconnectInternal(){} // RVA: 0x71611D0
        public void DestroyPlayableInternal(){} // RVA: 0x7161240
        public void Create_Injected(){} // RVA: 0x71612A0
        public void Destroy_Injected(){} // RVA: 0x7160B10
        public void IsValid_Injected(){} // RVA: 0x7160B60
        public void IsPlaying_Injected(){} // RVA: 0x7160BB0
        public void Play_Injected(){} // RVA: 0x7160C00
        public void Stop_Injected(){} // RVA: 0x7160C50
        public void Evaluate_Injected(){} // RVA: 0x7160CA0
        public void GetResolver_Injected(){} // RVA: 0x7160D00
        public void GetPlayableCount_Injected(){} // RVA: 0x7160D50
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7160DA0
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7161300
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7161360
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7160EC0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x71613C0
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7160FB0
        public void GetFrameRate_Injected(){} // RVA: 0x7161430
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7161060
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x71610C0
        public void ConnectInternal_Injected(){} // RVA: 0x7161490
        public void DisconnectInternal_Injected(){} // RVA: 0x7161520
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7161590
    }

    public class PlayableHandle
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x283FA0
        public void IsPlayableOfType(){} // RVA: 0xDBE0
        public void get_Null(){} // RVA: 0x71615F0
        public void GetInput(){} // RVA: 0x7161660
        public void SetInputWeight(){} // RVA: 0x7162B20 | overloaded x2
        public void GetInputWeight(){} // RVA: 0x7161840
        public void Destroy(){} // RVA: 0x7161910
        public void op_Equality(){} // RVA: 0x7161AA0
        public void Equals(){} // RVA: 0x7161C40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7161CD0
        public void CompareVersion(){} // RVA: 0x3C4E6B0
        public void CheckInputBounds(){} // RVA: 0x7161D40 | overloaded x2
        public void IsNull(){} // RVA: 0x7161F60
        public void IsValid(){} // RVA: 0x7161FF0
        public void GetPlayableType(){} // RVA: 0x7162080
        public void GetJobType(){} // RVA: 0x7162110
        public void SetScriptInstance(){} // RVA: 0x71621A0
        public void GetPlayState(){} // RVA: 0x7162240
        public void Play(){} // RVA: 0x71622D0
        public void Pause(){} // RVA: 0x7162360
        public void SetSpeed(){} // RVA: 0x71623F0
        public void GetTime(){} // RVA: 0x7162490
        public void SetTime(){} // RVA: 0x7162520
        public void IsDone(){} // RVA: 0x71625C0
        public void SetDone(){} // RVA: 0x7162650
        public void GetDuration(){} // RVA: 0x71626F0
        public void SetDuration(){} // RVA: 0x7162780
        public void SetPropagateSetTime(){} // RVA: 0x7162820
        public void GetGraph(){} // RVA: 0x71628C0
        public void GetInputCount(){} // RVA: 0x7162960
        public void SetInputCount(){} // RVA: 0x71629F0
        public void GetOutputCount(){} // RVA: 0x7162A90
        public void GetPreviousTime(){} // RVA: 0x7162BD0
        public void SetTraversalMode(){} // RVA: 0x7162C60
        public void GetJobData(){} // RVA: 0x7162D00
        public void GetTimeWrapMode(){} // RVA: 0x7162D90
        public void SetTimeWrapMode(){} // RVA: 0x7162E20
        public void GetScriptInstance(){} // RVA: 0x7162EC0
        public void GetInputHandle(){} // RVA: 0x7162F50
        public void SetInputWeightFromIndex(){} // RVA: 0x7163000
        public void GetInputWeightFromIndex(){} // RVA: 0x71630B0
        public void .cctor(){} // RVA: 0x7163150
        public void IsNull_Injected(){} // RVA: 0x7163190
        public void IsValid_Injected(){} // RVA: 0x71631E0
        public void GetPlayableType_Injected(){} // RVA: 0x7163230
        public void GetJobType_Injected(){} // RVA: 0x7163280
        public void SetScriptInstance_Injected(){} // RVA: 0x71632D0
        public void GetPlayState_Injected(){} // RVA: 0x7163330
        public void Play_Injected(){} // RVA: 0x7163380
        public void Pause_Injected(){} // RVA: 0x71633D0
        public void SetSpeed_Injected(){} // RVA: 0x7163420
        public void GetTime_Injected(){} // RVA: 0x7163480
        public void SetTime_Injected(){} // RVA: 0x71634D0
        public void IsDone_Injected(){} // RVA: 0x7163530
        public void SetDone_Injected(){} // RVA: 0x7163580
        public void GetDuration_Injected(){} // RVA: 0x71635E0
        public void SetDuration_Injected(){} // RVA: 0x7163630
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7163690
        public void GetGraph_Injected(){} // RVA: 0x71636F0
        public void GetInputCount_Injected(){} // RVA: 0x7163750
        public void SetInputCount_Injected(){} // RVA: 0x71637A0
        public void GetOutputCount_Injected(){} // RVA: 0x7163800
        public void SetInputWeight_Injected(){} // RVA: 0x7163850
        public void GetPreviousTime_Injected(){} // RVA: 0x71638C0
        public void SetTraversalMode_Injected(){} // RVA: 0x7163910
        public void GetJobData_Injected(){} // RVA: 0x7163970
        public void GetTimeWrapMode_Injected(){} // RVA: 0x71639C0
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7163A10
        public void GetScriptInstance_Injected(){} // RVA: 0x7163A70
        public void GetInputHandle_Injected(){} // RVA: 0x7163AC0
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7163B30
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7163BA0
    }

    public class PlayableOutput
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7163C00
        public void .ctor(){} // RVA: 0x1A53740
        public void GetHandle(){} // RVA: 0x3FC7D30
        public void IsPlayableOutputOfType(){} // RVA: 0xDBE0
        public void Equals(){} // RVA: 0x7163C70
        public void .cctor(){} // RVA: 0x7163D60
    }

    public class PlayableOutputExtensions
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x283FA0
        public void SetReferenceObject(){} // RVA: 0x283FA0
        public void SetUserData(){} // RVA: 0x283FA0
        public void GetSourcePlayable(){} // RVA: 0x283FA0
        public void SetSourcePlayable(){} // RVA: 0x283FA0 | overloaded x2
        public void GetSourceOutputPort(){} // RVA: 0x283FA0
        public void SetWeight(){} // RVA: 0x283FA0
        public void PushNotification(){} // RVA: 0x283FA0
        public void AddNotificationReceiver(){} // RVA: 0x283FA0
    }

    public class PlayableOutputHandle
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7163E10
        public void IsPlayableOutputOfType(){} // RVA: 0xDBE0
        public void GetHashCode(){} // RVA: 0x7161CD0
        public void op_Equality(){} // RVA: 0x7163E80
        public void Equals(){} // RVA: 0x7164020 | overloaded x2
        public void CompareVersion(){} // RVA: 0x3C4E6B0
        public void IsValid(){} // RVA: 0x71640B0
        public void GetPlayableOutputType(){} // RVA: 0x7164140
        public void SetReferenceObject(){} // RVA: 0x71641D0
        public void SetUserData(){} // RVA: 0x7164270
        public void GetSourcePlayable(){} // RVA: 0x7164310
        public void SetSourcePlayable(){} // RVA: 0x71643B0
        public void GetSourceOutputPort(){} // RVA: 0x7164460
        public void SetWeight(){} // RVA: 0x71644F0
        public void PushNotification(){} // RVA: 0x7164590
        public void AddNotificationReceiver(){} // RVA: 0x7164650
        public void .cctor(){} // RVA: 0x71646F0
        public void IsValid_Injected(){} // RVA: 0x7164730
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7164780
        public void SetReferenceObject_Injected(){} // RVA: 0x71647D0
        public void SetUserData_Injected(){} // RVA: 0x7164830
        public void GetSourcePlayable_Injected(){} // RVA: 0x7164890
        public void SetSourcePlayable_Injected(){} // RVA: 0x71648F0
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7164960
        public void SetWeight_Injected(){} // RVA: 0x71649B0
        public void PushNotification_Injected(){} // RVA: 0x7164A10
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7164A90
    }

    public class ScriptPlayableBinding
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7164AF0
        public void CreateScriptOutput(){} // RVA: 0x7164BF0
    }

    public class ScriptPlayableOutput
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7164D40
        public void .ctor(){} // RVA: 0x7164E90
        public void get_Null(){} // RVA: 0x7164F80
        public void GetHandle(){} // RVA: 0x3FC7D30
        public void op_Implicit(){} // RVA: 0x709C110
    }

    public class ScriptPlayable`1
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x283FA0
        public void Create(){} // RVA: 0x283FA0 | overloaded x2
        public void CreateHandle(){} // RVA: 0x283FA0
        public void CreateScriptInstance(){} // RVA: 0xC960
        public void CloneScriptInstance(){} // RVA: 0xCE50
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0xCE50
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0xCE50
        public void .ctor(){} // RVA: 0x283FA0
        public void GetHandle(){} // RVA: 0x283FA0
        public void GetBehaviour(){} // RVA: 0x283FA0
        public void op_Implicit(){} // RVA: 0x283FA0
        public void op_Explicit(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x24A80
    }

}