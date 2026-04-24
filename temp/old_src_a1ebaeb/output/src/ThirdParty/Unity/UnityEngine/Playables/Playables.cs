// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 20
// Methods: 334

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData : ValueType
    {
        public object m_Weight; // 0x32CBBB00
        public object m_EffectiveParentSpeed; // 0x32CBBB00
        public object m_Output; // 0x32CBBB00
        public object deltaTime; // 0x1700045E
        public object effectiveSpeed; // 0x1700045F
        public object evaluationType; // 0x17000460

        // ── Original Methods ──
        public void HasFlags(){} // RVA: 0x7ffaaf319140
        public void get_deltaTime(){} // RVA: 0x7ffaaf319150
        public void get_effectiveSpeed(){} // RVA: 0x7ffaaf236d70
        public void get_evaluationType(){} // RVA: 0x7ffaaf319160
        public void get_seekOccurred(){} // RVA: 0x7ffaaf319170
        public void get_timeLooped(){} // RVA: 0x7ffaaf319180
        public void get_timeHeld(){} // RVA: 0x7ffaaf319190
        public void get_output(){} // RVA: 0x7ffaaf3191a0
        public void get_effectivePlayState(){} // RVA: 0x7ffaaf3191b0
    }

    public class FrameRate : ValueType
    {
        public object k_25Fps; // 0x32CBB6F0
        public object k_50Fps; // 0x32CBB6F0
        public object m_Rate; // 0x32CBB6F0
        public object System; // 0xB40D34A0

        // ── Original Methods ──
        public void get_dropFrame(){} // RVA: 0x7ffaae04fdb0
        public void get_rate(){} // RVA: 0x7ffaaf3191d0
        public void .ctor(){} // RVA: 0x7ffaaf319240
        public void IsValid(){} // RVA: 0x7ffaaf25aba0
        public void Equals(){} // RVA: 0x7ffaaf319260
        public void Equals(){} // RVA: 0x7ffaaf319260
        public void op_Equality(){} // RVA: 0x7ffaaf319300
        public void ToString(){} // RVA: 0x7ffaaf3193c0
        public void ToString(){} // RVA: 0x7ffaaf3193c0
        public void .cctor(){} // RVA: 0x7ffaaf319730
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
        public void DoubleToFrameRate(){} // RVA: 0x7ffaaf3195d0
    }

    public class INotification
    {
        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa887e5c0
    }

    public class INotificationReceiver
    {
        // ── Original Methods ──
        public void OnNotify(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPlayable
    {
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPlayableAsset
    {
        // ── Original Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7ffaa864eea0
    }

    public class IPlayableBehaviour
    {
        // ── Original Methods ──
        public void OnGraphStart(){}
        public void OnGraphStop(){}
        public void OnPlayableCreate(){}
        public void OnPlayableDestroy(){}
        public void OnBehaviourPlay(){} // RVA: 0x7ffaa887e5c0
        public void OnBehaviourPause(){} // RVA: 0x7ffaa887e5c0
        public void PrepareFrame(){} // RVA: 0x7ffaa887e5c0
        public void ProcessFrame(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPlayableOutput
    {
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaa887e5c0
    }

    public class Playable : ValueType
    {
        // ── Original Methods ──
        public void get_Null(){} // RVA: 0x7ffaaf319810
        public void Create(){} // RVA: 0x7ffaaf319880
        public void .ctor(){} // RVA: 0x7ffaa9f2b600
        public void IsPlayableOfType(){} // RVA: 0x7ffaa864a040
        public void Equals(){} // RVA: 0x7ffaaf319a70
        public void .cctor(){} // RVA: 0x7ffaaf319b60
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
        public void GetPlayableType(){} // RVA: 0x7ffaaf319970
    }

    public class PlayableAsset : ScriptableObject
    {
        // ── Original Methods ──
        public void CreatePlayable(){}
        public void get_duration(){} // RVA: 0x7ffaaf319c10
        public void get_outputs(){} // RVA: 0x7ffaaf319c70
        public void Internal_CreatePlayable(){} // RVA: 0x7ffaaf319cd0
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7ffaaf319e60
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class PlayableBehaviour : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void OnGraphStart(){} // RVA: 0x7ffaa8932310
        public void OnGraphStop(){} // RVA: 0x7ffaa8932310
        public void OnPlayableCreate(){} // RVA: 0x7ffaa8932310
        public void OnPlayableDestroy(){} // RVA: 0x7ffaa8932310
        public void OnBehaviourPlay(){} // RVA: 0x7ffaa8932310
        public void OnBehaviourPause(){} // RVA: 0x7ffaa8932310
        public void PrepareFrame(){} // RVA: 0x7ffaa8932310
        public void ProcessFrame(){} // RVA: 0x7ffaa8932310
        public void Clone(){} // RVA: 0x7ffaaf319ea0
    }

    public class PlayableDirector : Behaviour
    {
        public object stopped; // 0x32D98030

        // ── Original Methods ──
        public void get_state(){} // RVA: 0x7ffaaf323f90
        public void set_extrapolationMode(){} // RVA: 0x7ffaaf323fe0
        public void get_extrapolationMode(){} // RVA: 0x7ffaaf324040
        public void get_playableAsset(){} // RVA: 0x7ffaaf324090
        public void set_playableAsset(){} // RVA: 0x7ffaaf324160
        public void get_playableGraph(){} // RVA: 0x7ffaaf3241c0
        public void get_playOnAwake(){} // RVA: 0x7ffaaf324240
        public void set_playOnAwake(){} // RVA: 0x7ffaaf324290
        public void DeferredEvaluate(){} // RVA: 0x7ffaaf3242f0
        public void Play(){} // RVA: 0x7ffaaf324a90
        public void Play(){} // RVA: 0x7ffaaf324a90
        public void Play(){} // RVA: 0x7ffaaf324a90
        public void set_timeUpdateMode(){} // RVA: 0x7ffaaf324780
        public void get_timeUpdateMode(){} // RVA: 0x7ffaaf3247e0
        public void set_time(){} // RVA: 0x7ffaaf324830
        public void get_time(){} // RVA: 0x7ffaaf324890
        public void set_initialTime(){} // RVA: 0x7ffaaf3248e0
        public void get_initialTime(){} // RVA: 0x7ffaaf324940
        public void get_duration(){} // RVA: 0x7ffaaf324990
        public void Evaluate(){} // RVA: 0x7ffaaf3249e0
        public void PlayOnFrame(){} // RVA: 0x7ffaaf324a30
        public void Play(){} // RVA: 0x7ffaaf324a90
        public void Stop(){} // RVA: 0x7ffaaf324ae0
        public void Pause(){} // RVA: 0x7ffaaf324b30
        public void Resume(){} // RVA: 0x7ffaaf324b80
        public void RebuildGraph(){} // RVA: 0x7ffaaf324bd0
        public void ClearReferenceValue(){} // RVA: 0x7ffaaf324c20
        public void ClearGenericBinding(){} // RVA: 0x7ffaaf324dc0
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7ffaaf324e20
        public void ProcessPendingGraphChanges(){} // RVA: 0x7ffaaf324e70
        public void HasGenericBinding(){} // RVA: 0x7ffaaf324ec0
        public void EvaluateNextFrame(){} // RVA: 0x7ffaaf3242f0
        public void Internal_SetGenericBinding(){} // RVA: 0x7ffaaf324710
        public void Internal_GetPlayableAsset(){} // RVA: 0x7ffaaf324f90
        public void add_played(){} // RVA: 0x7ffaaf324fe0
        public void remove_played(){} // RVA: 0x7ffaaf3250e0
        public void add_paused(){} // RVA: 0x7ffaaf3251e0
        public void remove_paused(){} // RVA: 0x7ffaaf3252e0
        public void add_stopped(){} // RVA: 0x7ffaaf3253e0
        public void remove_stopped(){} // RVA: 0x7ffaaf3254e0
        public void ResetFrameTiming(){} // RVA: 0x7ffaaf3255e0
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7ffaaf325630
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7ffaaf325650
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7ffaaf325670
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void PlayOnFrame_Injected(){} // RVA: 0x7ffaaf325690
        public void ClearReferenceValue_Injected(){} // RVA: 0x7ffaaf3256f0
        // ── Binary Analysis Named ──
        public void SetGenericBinding(){} // RVA: 0x7ffaaf324710
        public void SetReferenceValue(){} // RVA: 0x7ffaaf324c80
        public void GetReferenceValue(){} // RVA: 0x7ffaaf324cf0
        public void GetGenericBinding(){} // RVA: 0x7ffaaf324d60
        public void GetPlayState(){} // RVA: 0x7ffaaf323f90
        public void SetWrapMode(){} // RVA: 0x7ffaaf323fe0
        public void GetWrapMode(){} // RVA: 0x7ffaaf324040
        public void GetGraphHandle(){} // RVA: 0x7ffaaf324f20
        public void SetPlayOnAwake(){} // RVA: 0x7ffaaf324290
        public void GetPlayOnAwake(){} // RVA: 0x7ffaaf324240
        public void SetPlayableAsset(){} // RVA: 0x7ffaaf324160
        public void SetReferenceValue_Injected(){} // RVA: 0x7ffaaf325750
        public void GetReferenceValue_Injected(){} // RVA: 0x7ffaaf3257c0
        public void GetGraphHandle_Injected(){} // RVA: 0x7ffaaf325830
    }

    public class PlayableExtensions : Object
    {
        // ── Original Methods ──
        public void IsNull(){} // RVA: 0x7ffaa887e5c0
        public void IsValid(){} // RVA: 0x7ffaa887e5c0
        public void Destroy(){} // RVA: 0x7ffaa887e5c0
        public void Play(){} // RVA: 0x7ffaa887e5c0
        public void Pause(){} // RVA: 0x7ffaa887e5c0
        public void IsDone(){} // RVA: 0x7ffaa887e5c0
        public void DisconnectInput(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetGraph(){} // RVA: 0x7ffaa887e5c0
        public void GetPlayState(){} // RVA: 0x7ffaa887e5c0
        public void SetSpeed(){} // RVA: 0x7ffaa887e5c0
        public void SetDuration(){} // RVA: 0x7ffaa887e5c0
        public void GetDuration(){} // RVA: 0x7ffaa887e5c0
        public void SetTime(){} // RVA: 0x7ffaa887e5c0
        public void GetTime(){} // RVA: 0x7ffaa887e5c0
        public void GetPreviousTime(){} // RVA: 0x7ffaa887e5c0
        public void SetPropagateSetTime(){} // RVA: 0x7ffaa887e5c0
        public void SetInputCount(){} // RVA: 0x7ffaa887e5c0
        public void GetInputCount(){} // RVA: 0x7ffaa887e5c0
        public void GetOutputCount(){} // RVA: 0x7ffaa887e5c0
        public void GetInput(){} // RVA: 0x7ffaa887e5c0
        public void SetInputWeight(){} // RVA: 0x7ffaa887e5c0
        public void SetInputWeight(){} // RVA: 0x7ffaa887e5c0
        public void GetInputWeight(){} // RVA: 0x7ffaa887e5c0
        public void SetTraversalMode(){} // RVA: 0x7ffaa887e5c0
        public void GetTimeWrapMode(){} // RVA: 0x7ffaa887e5c0
        public void SetTimeWrapMode(){} // RVA: 0x7ffaa887e5c0
    }

    public class PlayableGraph : ValueType
    {
        // ── Original Methods ──
        public void Connect(){} // RVA: 0x7ffaa887e5c0
        public void Disconnect(){} // RVA: 0x7ffaa887e5c0
        public void DestroyPlayable(){} // RVA: 0x7ffaa887e5c0
        public void Evaluate(){} // RVA: 0x7ffaaf31a5e0
        public void Create(){} // RVA: 0x7ffaaf31a3e0
        public void Destroy(){} // RVA: 0x7ffaaf31a450
        public void IsValid(){} // RVA: 0x7ffaaf31a4a0
        public void IsPlaying(){} // RVA: 0x7ffaaf31a4f0
        public void Play(){} // RVA: 0x7ffaaf31a540
        public void Stop(){} // RVA: 0x7ffaaf31a590
        public void Evaluate(){} // RVA: 0x7ffaaf31a5e0
        public void SynchronizeEvaluation(){} // RVA: 0x7ffaaf31a730
        public void CreatePlayableHandle(){} // RVA: 0x7ffaaf31a790
        public void CreateScriptOutputInternal(){} // RVA: 0x7ffaaf31a800
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7ffaaf31a8f0
        public void ConnectInternal(){} // RVA: 0x7ffaaf31aa80
        public void DisconnectInternal(){} // RVA: 0x7ffaaf31ab10
        public void DestroyPlayableInternal(){} // RVA: 0x7ffaaf31ab80
        public void Create_Injected(){} // RVA: 0x7ffaaf31abe0
        public void Destroy_Injected(){} // RVA: 0x7ffaaf31a450
        public void IsValid_Injected(){} // RVA: 0x7ffaaf31a4a0
        public void IsPlaying_Injected(){} // RVA: 0x7ffaaf31a4f0
        public void Play_Injected(){} // RVA: 0x7ffaaf31a540
        public void Stop_Injected(){} // RVA: 0x7ffaaf31a590
        public void Evaluate_Injected(){} // RVA: 0x7ffaaf31a5e0
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7ffaaf31ac40
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7ffaaf31aca0
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7ffaaf31a800
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7ffaaf31a8f0
        public void ConnectInternal_Injected(){} // RVA: 0x7ffaaf31add0
        public void DisconnectInternal_Injected(){} // RVA: 0x7ffaaf31ae60
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7ffaaf31aed0
        // ── Binary Analysis Named ──
        public void GetRootPlayable(){} // RVA: 0x7ffaaf31a2f0
        public void GetOutputCountByType(){} // RVA: 0x7ffaa8649ca0
        public void GetOutputByType(){} // RVA: 0x7ffaa887e5c0
        public void GetResolver(){} // RVA: 0x7ffaaf31a640
        public void GetPlayableCount(){} // RVA: 0x7ffaaf31a690
        public void GetRootPlayableCount(){} // RVA: 0x7ffaaf31a6e0
        public void GetRootPlayableInternal(){} // RVA: 0x7ffaaf31a870
        public void GetFrameRate(){} // RVA: 0x7ffaaf31a940
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7ffaaf31a9a0
        public void GetOutputByTypeInternal(){} // RVA: 0x7ffaaf31aa00
        public void GetResolver_Injected(){} // RVA: 0x7ffaaf31a640
        public void GetPlayableCount_Injected(){} // RVA: 0x7ffaaf31a690
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7ffaaf31a6e0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7ffaaf31ad00
        public void GetFrameRate_Injected(){} // RVA: 0x7ffaaf31ad70
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7ffaaf31a9a0
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7ffaaf31aa00
    }

    public class PlayableHandle : ValueType
    {
        public object m_Null; // 0x31363DE0

        // ── Original Methods ──
        public void IsPlayableOfType(){} // RVA: 0x7ffaa864a040
        public void get_Null(){} // RVA: 0x7ffaaf31af30
        public void Destroy(){} // RVA: 0x7ffaaf31b250
        public void op_Equality(){} // RVA: 0x7ffaaf31b3e0
        public void Equals(){} // RVA: 0x7ffaaf31b580
        public void Equals(){} // RVA: 0x7ffaaf31b580
        public void CompareVersion(){} // RVA: 0x7ffaabf4b4d0
        public void IsNull(){} // RVA: 0x7ffaaf31b8a0
        public void IsValid(){} // RVA: 0x7ffaaf31b930
        public void Play(){} // RVA: 0x7ffaaf31bc10
        public void Pause(){} // RVA: 0x7ffaaf31bca0
        public void IsDone(){} // RVA: 0x7ffaaf31bf00
        public void .cctor(){} // RVA: 0x7ffaaf31ca90
        public void IsNull_Injected(){} // RVA: 0x7ffaaf31cad0
        public void IsValid_Injected(){} // RVA: 0x7ffaaf31cb20
        public void Play_Injected(){} // RVA: 0x7ffaaf31ccc0
        public void Pause_Injected(){} // RVA: 0x7ffaaf31cd10
        public void IsDone_Injected(){} // RVA: 0x7ffaaf31ce70
        // ── Binary Analysis Named ──
        public void GetObject(){} // RVA: 0x7ffaa887e5c0
        public void GetInput(){} // RVA: 0x7ffaaf31afa0
        public void SetInputWeight(){} // RVA: 0x7ffaaf31c460
        public void GetInputWeight(){} // RVA: 0x7ffaaf31b180
        public void GetHashCode(){} // RVA: 0x7ffaaf31b610
        public void CheckInputBounds(){} // RVA: 0x7ffaaf31b680
        public void CheckInputBounds(){} // RVA: 0x7ffaaf31b680
        public void GetPlayableType(){} // RVA: 0x7ffaaf31b9c0
        public void GetJobType(){} // RVA: 0x7ffaaf31ba50
        public void SetScriptInstance(){} // RVA: 0x7ffaaf31bae0
        public void GetPlayState(){} // RVA: 0x7ffaaf31bb80
        public void SetSpeed(){} // RVA: 0x7ffaaf31bd30
        public void GetTime(){} // RVA: 0x7ffaaf31bdd0
        public void SetTime(){} // RVA: 0x7ffaaf31be60
        public void SetDone(){} // RVA: 0x7ffaaf31bf90
        public void GetDuration(){} // RVA: 0x7ffaaf31c030
        public void SetDuration(){} // RVA: 0x7ffaaf31c0c0
        public void SetPropagateSetTime(){} // RVA: 0x7ffaaf31c160
        public void GetGraph(){} // RVA: 0x7ffaaf31c200
        public void GetInputCount(){} // RVA: 0x7ffaaf31c2a0
        public void SetInputCount(){} // RVA: 0x7ffaaf31c330
        public void GetOutputCount(){} // RVA: 0x7ffaaf31c3d0
        public void SetInputWeight(){} // RVA: 0x7ffaaf31c460
        public void GetPreviousTime(){} // RVA: 0x7ffaaf31c510
        public void SetTraversalMode(){} // RVA: 0x7ffaaf31c5a0
        public void GetJobData(){} // RVA: 0x7ffaaf31c640
        public void GetTimeWrapMode(){} // RVA: 0x7ffaaf31c6d0
        public void SetTimeWrapMode(){} // RVA: 0x7ffaaf31c760
        public void GetScriptInstance(){} // RVA: 0x7ffaaf31c800
        public void GetInputHandle(){} // RVA: 0x7ffaaf31c890
        public void SetInputWeightFromIndex(){} // RVA: 0x7ffaaf31c940
        public void GetInputWeightFromIndex(){} // RVA: 0x7ffaaf31c9f0
        public void GetPlayableType_Injected(){} // RVA: 0x7ffaaf31cb70
        public void GetJobType_Injected(){} // RVA: 0x7ffaaf31cbc0
        public void SetScriptInstance_Injected(){} // RVA: 0x7ffaaf31cc10
        public void GetPlayState_Injected(){} // RVA: 0x7ffaaf31cc70
        public void SetSpeed_Injected(){} // RVA: 0x7ffaaf31cd60
        public void GetTime_Injected(){} // RVA: 0x7ffaaf31cdc0
        public void SetTime_Injected(){} // RVA: 0x7ffaaf31ce10
        public void SetDone_Injected(){} // RVA: 0x7ffaaf31cec0
        public void GetDuration_Injected(){} // RVA: 0x7ffaaf31cf20
        public void SetDuration_Injected(){} // RVA: 0x7ffaaf31cf70
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7ffaaf31cfd0
        public void GetGraph_Injected(){} // RVA: 0x7ffaaf31d030
        public void GetInputCount_Injected(){} // RVA: 0x7ffaaf31d090
        public void SetInputCount_Injected(){} // RVA: 0x7ffaaf31d0e0
        public void GetOutputCount_Injected(){} // RVA: 0x7ffaaf31d140
        public void SetInputWeight_Injected(){} // RVA: 0x7ffaaf31d190
        public void GetPreviousTime_Injected(){} // RVA: 0x7ffaaf31d200
        public void SetTraversalMode_Injected(){} // RVA: 0x7ffaaf31d250
        public void GetJobData_Injected(){} // RVA: 0x7ffaaf31d2b0
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7ffaaf31d300
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7ffaaf31d350
        public void GetScriptInstance_Injected(){} // RVA: 0x7ffaaf31d3b0
        public void GetInputHandle_Injected(){} // RVA: 0x7ffaaf31d400
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7ffaaf31d470
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7ffaaf31d4e0
    }

    public class PlayableOutput : ValueType
    {
        // ── Original Methods ──
        public void get_Null(){} // RVA: 0x7ffaaf31d540
        public void .ctor(){} // RVA: 0x7ffaa9f2b600
        public void IsPlayableOutputOfType(){} // RVA: 0x7ffaa864a040
        public void Equals(){} // RVA: 0x7ffaaf31d5b0
        public void .cctor(){} // RVA: 0x7ffaaf31d6a0
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Original Methods ──
        public void IsOutputValid(){} // RVA: 0x7ffaa887e5c0
        public void PushNotification(){} // RVA: 0x7ffaa887e5c0
        public void AddNotificationReceiver(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetReferenceObject(){} // RVA: 0x7ffaa887e5c0
        public void SetUserData(){} // RVA: 0x7ffaa887e5c0
        public void GetSourcePlayable(){} // RVA: 0x7ffaa887e5c0
        public void SetSourcePlayable(){} // RVA: 0x7ffaa887e5c0
        public void SetSourcePlayable(){} // RVA: 0x7ffaa887e5c0
        public void GetSourceOutputPort(){} // RVA: 0x7ffaa887e5c0
        public void SetWeight(){} // RVA: 0x7ffaa887e5c0
    }

    public class PlayableOutputHandle : ValueType
    {
        public object m_Null; // 0x3185ACF0

        // ── Original Methods ──
        public void get_Null(){} // RVA: 0x7ffaaf31d750
        public void IsPlayableOutputOfType(){} // RVA: 0x7ffaa864a040
        public void op_Equality(){} // RVA: 0x7ffaaf31d7c0
        public void Equals(){} // RVA: 0x7ffaaf31d960
        public void Equals(){} // RVA: 0x7ffaaf31d960
        public void CompareVersion(){} // RVA: 0x7ffaabf4b4d0
        public void IsValid(){} // RVA: 0x7ffaaf31d9f0
        public void PushNotification(){} // RVA: 0x7ffaaf31ded0
        public void AddNotificationReceiver(){} // RVA: 0x7ffaaf31df90
        public void .cctor(){} // RVA: 0x7ffaaf31e030
        public void IsValid_Injected(){} // RVA: 0x7ffaaf31e070
        public void PushNotification_Injected(){} // RVA: 0x7ffaaf31e350
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7ffaaf31e3d0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf31b610
        public void GetPlayableOutputType(){} // RVA: 0x7ffaaf31da80
        public void SetReferenceObject(){} // RVA: 0x7ffaaf31db10
        public void SetUserData(){} // RVA: 0x7ffaaf31dbb0
        public void GetSourcePlayable(){} // RVA: 0x7ffaaf31dc50
        public void SetSourcePlayable(){} // RVA: 0x7ffaaf31dcf0
        public void GetSourceOutputPort(){} // RVA: 0x7ffaaf31dda0
        public void SetWeight(){} // RVA: 0x7ffaaf31de30
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7ffaaf31e0c0
        public void SetReferenceObject_Injected(){} // RVA: 0x7ffaaf31e110
        public void SetUserData_Injected(){} // RVA: 0x7ffaaf31e170
        public void GetSourcePlayable_Injected(){} // RVA: 0x7ffaaf31e1d0
        public void SetSourcePlayable_Injected(){} // RVA: 0x7ffaaf31e230
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7ffaaf31e2a0
        public void SetWeight_Injected(){} // RVA: 0x7ffaaf31e2f0
    }

    public class ScriptPlayableOutput : ValueType
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf31e680
        public void .ctor(){} // RVA: 0x7ffaaf31e7d0
        public void get_Null(){} // RVA: 0x7ffaaf31e8c0
        public void op_Implicit(){} // RVA: 0x7ffaaf2569e0
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
    }

    public class ScriptPlayable`1 : ValueType
    {
        // ── Original Methods ──
        public void get_Null(){} // RVA: 0x7ffaa887e5c0
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void CreateHandle(){} // RVA: 0x7ffaa887e5c0
        public void CreateScriptInstance(){} // RVA: 0x7ffaa8648dd0
        public void CloneScriptInstance(){} // RVA: 0x7ffaa86492c0
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7ffaa86492c0
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7ffaa86492c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void op_Implicit(){} // RVA: 0x7ffaa887e5c0
        public void op_Explicit(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaa887e5c0
        public void GetBehaviour(){} // RVA: 0x7ffaa887e5c0
    }

}