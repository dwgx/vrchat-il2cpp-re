// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 37
// Methods: 497

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class DataPlayableOutput : ValueType
    {
        public object m_Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96D9C0
        public void GetHandle(){} // RVA: 0x4513B0
        public void Internal_CallOnPlayerChanged(){} // RVA: 0x7C520C0
    }

    public class DataPlayableOutput[] : Array
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
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FrameData : ValueType
    {
        public object m_FrameID;
        public object m_DeltaTime;
        public object m_Weight;
        public object m_EffectiveWeight;
        public object m_EffectiveParentDelay;
        public object m_EffectiveParentSpeed;
        public object m_EffectiveSpeed;
        public object m_Flags;
        public object m_Output;

        // ── Methods ──
        public void HasFlags(){} // RVA: 0x9675E0
        public void get_deltaTime(){} // RVA: 0x9675F0
        public void get_effectiveSpeed(){} // RVA: 0x9589B0
        public void get_evaluationType(){} // RVA: 0x967600
        public void get_seekOccurred(){} // RVA: 0x967610
        public void get_timeLooped(){} // RVA: 0x967620
        public void get_timeHeld(){} // RVA: 0x967630
        public void get_output(){} // RVA: 0x967640
        public void get_effectivePlayState(){} // RVA: 0x967650
    }

    public class FrameRate : ValueType
    {
        public object k_24Fps;
        public object k_23_976Fps;
        public object k_25Fps;
        public object k_30Fps;
        public object k_29_97Fps;
        public object k_50Fps;
        public object k_60Fps;
        public object k_59_94Fps;
        public object m_Rate;

        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x8B93C0
        public void get_rate(){} // RVA: 0x967670
        public void .ctor(){} // RVA: 0x967680
        public void IsValid(){} // RVA: 0x95B3A0
        public void Equals(){} // RVA: 0x967690
        public void op_Equality(){} // RVA: 0x7C2E4D0
        public void GetHashCode(){} // RVA: 0x454FE0
        public void ToString(){} // RVA: 0x967790
        public void DoubleToFrameRate(){} // RVA: 0x7C2E7A0
        public void .cctor(){} // RVA: 0x7C2E900
    }

    public class FrameRate[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IDataPlayer
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x894320
        public void Release(){} // RVA: 0x894320
    }

    public class INotification
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0xA94080
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0xA94080
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0xA94080
    }

    public class IPlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){} // RVA: 0x87C6B0
        public void get_duration(){} // RVA: 0x8820E0
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){} // RVA: 0x894320
        public void OnGraphStop(){} // RVA: 0x894320
        public void OnPlayableCreate(){} // RVA: 0x894320
        public void OnPlayableDestroy(){} // RVA: 0x894320
        public void OnBehaviourPlay(){} // RVA: 0xA94080
        public void OnBehaviourPause(){} // RVA: 0xA94080
        public void PrepareFrame(){} // RVA: 0xA94080
        public void ProcessFrame(){} // RVA: 0xA94080
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0xA94080
    }

    public class Playable : ValueType
    {
        public object m_Handle;
        public object m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7C2E9E0
        public void Create(){} // RVA: 0x7C2EA50
        public void .ctor(){} // RVA: 0x7BE90
        public void GetHandle(){} // RVA: 0x4513B0
        public void IsPlayableOfType(){} // RVA: 0x87D280
        public void GetPlayableType(){} // RVA: 0x9677A0
        public void Equals(){} // RVA: 0x9677B0
        public void .cctor(){} // RVA: 0x7C2ECF0
    }

    public class PlayableAsset : ScriptableObject
    {
        // ── Methods ──
        public void CreatePlayable(){} // RVA: 0x87C6B0
        public void get_duration(){} // RVA: 0x7C2EDA0
        public void get_outputs(){} // RVA: 0x7C2EE00
        public void Internal_CreatePlayable(){} // RVA: 0x7C2EE60
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7C2EFF0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class PlayableAsset[] : Array
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

    public class PlayableBehaviour : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void OnGraphStart(){} // RVA: 0xB43310
        public void OnGraphStop(){} // RVA: 0xB43310
        public void OnPlayableCreate(){} // RVA: 0xB43310
        public void OnPlayableDestroy(){} // RVA: 0xB43310
        public void OnBehaviourPlay(){} // RVA: 0xB43310
        public void OnBehaviourPause(){} // RVA: 0xB43310
        public void PrepareFrame(){} // RVA: 0xB43310
        public void ProcessFrame(){} // RVA: 0xB43310
        public void Clone(){} // RVA: 0x7C2F030
    }

    public class PlayableBehaviour[] : Array
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

    public class PlayableBinding : ValueType
    {
        public object m_StreamName;
        public object m_SourceObject;
        public object m_SourceBindingType;
        public object m_CreateOutputMethod;
        public object None;
        public object DefaultDuration;

        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x8C0C50
        public void CreateOutput(){} // RVA: 0x967890
        public void CreateInternal(){} // RVA: 0x7C2F140
        public void .cctor(){} // RVA: 0x7C2F2E0
    }

    public class PlayableDirector : Behaviour
    {
        public object played;
        public object paused;
        public object stopped;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7C52190
        public void set_extrapolationMode(){} // RVA: 0x7C52230
        public void get_extrapolationMode(){} // RVA: 0x7C522E0
        public void get_playableAsset(){} // RVA: 0x7C52380
        public void set_playableAsset(){} // RVA: 0x7C524B0
        public void get_playableGraph(){} // RVA: 0x7C52590
        public void get_playOnAwake(){} // RVA: 0x7C52660
        public void set_playOnAwake(){} // RVA: 0x7C52700
        public void DeferredEvaluate(){} // RVA: 0x7C527B0
        public void Play(){} // RVA: 0x7C53320
        public void SetGenericBinding(){} // RVA: 0x7C52C30
        public void set_timeUpdateMode(){} // RVA: 0x7C52D40
        public void get_timeUpdateMode(){} // RVA: 0x7C52DF0
        public void set_time(){} // RVA: 0x7C52E90
        public void get_time(){} // RVA: 0x7C52F40
        public void set_initialTime(){} // RVA: 0x7C52FE0
        public void get_initialTime(){} // RVA: 0x7C53090
        public void get_duration(){} // RVA: 0x7C53130
        public void Evaluate(){} // RVA: 0x7C531D0
        public void PlayOnFrame(){} // RVA: 0x7C53270
        public void Stop(){} // RVA: 0x7C533C0
        public void Pause(){} // RVA: 0x7C53460
        public void Resume(){} // RVA: 0x7C53500
        public void RebuildGraph(){} // RVA: 0x7C535A0
        public void ClearReferenceValue(){} // RVA: 0x7C53640
        public void SetReferenceValue(){} // RVA: 0x7C536F0
        public void GetReferenceValue(){} // RVA: 0x7C537E0
        public void GetGenericBinding(){} // RVA: 0x7C538C0
        public void ClearGenericBinding(){} // RVA: 0x7C539C0
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7C53AA0
        public void ProcessPendingGraphChanges(){} // RVA: 0x7C53B40
        public void HasGenericBinding(){} // RVA: 0x7C53BE0
        public void GetPlayState(){} // RVA: 0x7C52190
        public void SetWrapMode(){} // RVA: 0x7C52230
        public void GetWrapMode(){} // RVA: 0x7C522E0
        public void EvaluateNextFrame(){} // RVA: 0x7C527B0
        public void GetGraphHandle(){} // RVA: 0x7C53CC0
        public void SetPlayOnAwake(){} // RVA: 0x7C52700
        public void GetPlayOnAwake(){} // RVA: 0x7C52660
        public void Internal_SetGenericBinding(){} // RVA: 0x7C52C30
        public void SetPlayableAsset(){} // RVA: 0x7C524B0
        public void Internal_GetPlayableAsset(){} // RVA: 0x7C53D80
        public void add_played(){} // RVA: 0x7C53E40
        public void remove_played(){} // RVA: 0x7C53F50
        public void add_paused(){} // RVA: 0x7C54060
        public void remove_paused(){} // RVA: 0x7C54170
        public void add_stopped(){} // RVA: 0x7C54280
        public void remove_stopped(){} // RVA: 0x7C54390
        public void ResetFrameTiming(){} // RVA: 0x7C544A0
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7C544F0
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7C54510
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7C54530
        public void .ctor(){} // RVA: 0xB43D60
        public void set_timeUpdateMode_Injected(){} // RVA: 0x7C54550
        public void get_timeUpdateMode_Injected(){} // RVA: 0x7C545B0
        public void set_time_Injected(){} // RVA: 0x7C54600
        public void get_time_Injected(){} // RVA: 0x7C54660
        public void set_initialTime_Injected(){} // RVA: 0x7C546B0
        public void get_initialTime_Injected(){} // RVA: 0x7C54710
        public void get_duration_Injected(){} // RVA: 0x7C54760
        public void Evaluate_Injected(){} // RVA: 0x7C547B0
        public void PlayOnFrame_Injected(){} // RVA: 0x7C54800
        public void Play_Injected(){} // RVA: 0x7C54860
        public void Stop_Injected(){} // RVA: 0x7C548B0
        public void Pause_Injected(){} // RVA: 0x7C54900
        public void Resume_Injected(){} // RVA: 0x7C54950
        public void RebuildGraph_Injected(){} // RVA: 0x7C549A0
        public void ClearReferenceValue_Injected(){} // RVA: 0x7C549F0
        public void SetReferenceValue_Injected(){} // RVA: 0x7C54A50
        public void GetReferenceValue_Injected(){} // RVA: 0x7C54AC0
        public void GetGenericBinding_Injected(){} // RVA: 0x7C54B30
        public void ClearGenericBinding_Injected(){} // RVA: 0x7C54B90
        public void RebindPlayableGraphOutputs_Injected(){} // RVA: 0x7C54BF0
        public void ProcessPendingGraphChanges_Injected(){} // RVA: 0x7C54C40
        public void HasGenericBinding_Injected(){} // RVA: 0x7C54C90
        public void GetPlayState_Injected(){} // RVA: 0x7C54CF0
        public void SetWrapMode_Injected(){} // RVA: 0x7C54D40
        public void GetWrapMode_Injected(){} // RVA: 0x7C54DA0
        public void EvaluateNextFrame_Injected(){} // RVA: 0x7C54DF0
        public void GetGraphHandle_Injected(){} // RVA: 0x7C54E40
        public void SetPlayOnAwake_Injected(){} // RVA: 0x7C54EA0
        public void GetPlayOnAwake_Injected(){} // RVA: 0x7C54F00
        public void Internal_SetGenericBinding_Injected(){} // RVA: 0x7C54F50
        public void SetPlayableAsset_Injected(){} // RVA: 0x7C54FC0
        public void Internal_GetPlayableAsset_Injected(){} // RVA: 0x7C55020
    }

    public class PlayableDirector[] : Array
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

    public class PlayableExtensions : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0xA94080
        public void DisconnectInput(){} // RVA: 0xA94080
        public void GetInputCount(){} // RVA: 0xA94080
        public void GetInput(){} // RVA: 0xA94080
        public void IsNull(){} // RVA: 0xA94080
        public void IsValid(){} // RVA: 0xA94080
        public void Pause(){} // RVA: 0xA94080
        public void GetInputWeight(){} // RVA: 0xA94080
        public void SetInputWeight(){} // RVA: 0xA94080
        public void GetOutputCount(){} // RVA: 0xA94080
        public void GetGraph(){} // RVA: 0xA94080
        public void GetPlayState(){} // RVA: 0xA94080
        public void Play(){} // RVA: 0xA94080
        public void SetSpeed(){} // RVA: 0xA94080
        public void SetDuration(){} // RVA: 0xA94080
        public void GetDuration(){} // RVA: 0xA94080
        public void SetTime(){} // RVA: 0xA94080
        public void GetTime(){} // RVA: 0xA94080
        public void GetPreviousTime(){} // RVA: 0xA94080
        public void IsDone(){} // RVA: 0xA94080
        public void SetPropagateSetTime(){} // RVA: 0xA94080
        public void SetInputCount(){} // RVA: 0xA94080
        public void SetTraversalMode(){} // RVA: 0xA94080
        public void GetTimeWrapMode(){} // RVA: 0xA94080
        public void SetTimeWrapMode(){} // RVA: 0xA94080
    }

    public class PlayableGraph : ValueType
    {
        public object m_Handle;
        public object m_Version;

        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x967A20
        public void Connect(){} // RVA: 0x1FF280
        public void Disconnect(){} // RVA: 0xA94080
        public void DestroyPlayable(){} // RVA: 0x1FF470
        public void GetOutputCountByType(){} // RVA: 0x87C130
        public void GetOutputByType(){} // RVA: 0xA94080
        public void Evaluate(){} // RVA: 0x967CA0
        public void Create(){} // RVA: 0x7C2F570
        public void Destroy(){} // RVA: 0x967B10
        public void IsValid(){} // RVA: 0x967B60
        public void IsPlaying(){} // RVA: 0x967BB0
        public void Play(){} // RVA: 0x967C00
        public void Stop(){} // RVA: 0x967C50
        public void GetResolver(){} // RVA: 0x967CB0
        public void GetPlayableCount(){} // RVA: 0x967D00
        public void GetRootPlayableCount(){} // RVA: 0x967D50
        public void SynchronizeEvaluation(){} // RVA: 0x967DA0
        public void CreatePlayableHandle(){} // RVA: 0x967E00
        public void CreateScriptOutputInternal(){} // RVA: 0x967E80
        public void GetRootPlayableInternal(){} // RVA: 0x967A20
        public void IsMatchFrameRateEnabled(){} // RVA: 0x967E90
        public void GetFrameRate(){} // RVA: 0x967EE0
        public void GetOutputCountByTypeInternal(){} // RVA: 0x967EF0
        public void GetOutputByTypeInternal(){} // RVA: 0x967F00
        public void ConnectInternal(){} // RVA: 0x967F10
        public void DisconnectInternal(){} // RVA: 0x967FA0
        public void DestroyPlayableInternal(){} // RVA: 0x968010
        public void Create_Injected(){} // RVA: 0x7C2FF80
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7C2FFE0
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7C30040
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7C300A0
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7C30110
        public void GetFrameRate_Injected(){} // RVA: 0x7C30180
        public void ConnectInternal_Injected(){} // RVA: 0x7C301E0
        public void DisconnectInternal_Injected(){} // RVA: 0x7C30270
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7C302E0
    }

    public class PlayableGraph[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x894320
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlayableHandle : ValueType
    {
        public object m_Handle;
        public object m_Version;
        public object m_Null;

        // ── Methods ──
        public void GetObject(){} // RVA: 0xA94080
        public void IsPlayableOfType(){} // RVA: 0x1FF750
        public void get_Null(){} // RVA: 0x7C30340
        public void GetInput(){} // RVA: 0x968070
        public void SetInputWeight(){} // RVA: 0x9686D0
        public void GetInputWeight(){} // RVA: 0x9680B0
        public void Destroy(){} // RVA: 0x9680C0
        public void op_Equality(){} // RVA: 0x7C30830
        public void Equals(){} // RVA: 0x9680E0
        public void GetHashCode(){} // RVA: 0x968170
        public void CompareVersion(){} // RVA: 0x3F8D7B0
        public void CheckInputBounds(){} // RVA: 0x968190
        public void IsNull(){} // RVA: 0x9681A0
        public void IsValid(){} // RVA: 0x9681F0
        public void GetPlayableType(){} // RVA: 0x968240
        public void GetJobType(){} // RVA: 0x968290
        public void SetScriptInstance(){} // RVA: 0x9682E0
        public void GetPlayState(){} // RVA: 0x9682F0
        public void Play(){} // RVA: 0x968340
        public void Pause(){} // RVA: 0x968390
        public void SetSpeed(){} // RVA: 0x9683E0
        public void GetTime(){} // RVA: 0x9683F0
        public void SetTime(){} // RVA: 0x968440
        public void IsDone(){} // RVA: 0x968450
        public void SetDone(){} // RVA: 0x9684A0
        public void GetDuration(){} // RVA: 0x9684B0
        public void SetDuration(){} // RVA: 0x968500
        public void SetPropagateSetTime(){} // RVA: 0x968510
        public void GetGraph(){} // RVA: 0x968520
        public void GetInputCount(){} // RVA: 0x9685D0
        public void SetInputCount(){} // RVA: 0x968620
        public void GetOutputCount(){} // RVA: 0x968680
        public void GetPreviousTime(){} // RVA: 0x968780
        public void SetTraversalMode(){} // RVA: 0x9687D0
        public void GetJobData(){} // RVA: 0x968830
        public void GetTimeWrapMode(){} // RVA: 0x968880
        public void SetTimeWrapMode(){} // RVA: 0x9688D0
        public void GetScriptInstance(){} // RVA: 0x968930
        public void GetInputHandle(){} // RVA: 0x968980
        public void SetInputWeightFromIndex(){} // RVA: 0x9689B0
        public void GetInputWeightFromIndex(){} // RVA: 0x9689C0
        public void .cctor(){} // RVA: 0x7C31850
        public void GetGraph_Injected(){} // RVA: 0x7C31890
        public void SetInputWeight_Injected(){} // RVA: 0x7C318F0
        public void GetInputHandle_Injected(){} // RVA: 0x7C31960
    }

    public class PlayableHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlayableOutput : ValueType
    {
        public object m_Handle;
        public object m_NullPlayableOutput;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7C319D0
        public void .ctor(){} // RVA: 0x7BE90
        public void GetHandle(){} // RVA: 0x4513B0
        public void IsPlayableOutputOfType(){} // RVA: 0x87D280
        public void Equals(){} // RVA: 0x968A20
        public void .cctor(){} // RVA: 0x7C31B30
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Methods ──
        public void SetSourcePlayable(){} // RVA: 0xA94080
        public void GetSourceOutputPort(){} // RVA: 0xA94080
        public void IsOutputValid(){} // RVA: 0xA94080
        public void SetReferenceObject(){} // RVA: 0xA94080
        public void SetUserData(){} // RVA: 0xA94080
        public void GetSourcePlayable(){} // RVA: 0xA94080
        public void SetWeight(){} // RVA: 0xA94080
        public void PushNotification(){} // RVA: 0xA94080
        public void AddNotificationReceiver(){} // RVA: 0xA94080
    }

    public class PlayableOutputHandle : ValueType
    {
        public object m_Handle;
        public object m_Version;
        public object m_Null;

        // ── Methods ──
        public void get_Null(){} // RVA: 0x7C31BE0
        public void IsPlayableOutputOfType(){} // RVA: 0x1FF920
        public void GetHashCode(){} // RVA: 0x968170
        public void op_Equality(){} // RVA: 0x7C31C50
        public void Equals(){} // RVA: 0x968C30
        public void CompareVersion(){} // RVA: 0x3F8D7B0
        public void IsValid(){} // RVA: 0x968CC0
        public void GetPlayableOutputType(){} // RVA: 0x968D10
        public void SetReferenceObject(){} // RVA: 0x968D60
        public void SetUserData(){} // RVA: 0x968D70
        public void GetSourcePlayable(){} // RVA: 0x968D80
        public void SetSourcePlayable(){} // RVA: 0x968E30
        public void GetSourceOutputPort(){} // RVA: 0x968EE0
        public void SetWeight(){} // RVA: 0x968F30
        public void PushNotification(){} // RVA: 0x968F40
        public void AddNotificationReceiver(){} // RVA: 0x968F70
        public void .cctor(){} // RVA: 0x7C32370
        public void SetReferenceObject_Injected(){} // RVA: 0x7C323B0
        public void GetSourcePlayable_Injected(){} // RVA: 0x7C32410
        public void SetSourcePlayable_Injected(){} // RVA: 0x7C32470
        public void PushNotification_Injected(){} // RVA: 0x7C324E0
    }

    public class PlayableOutputHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlayableOutput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PlayableSystems : Object
    {
        public object s_SystemTypes;
        public object s_Delegates;
        public object s_RWLock;

        // ── Methods ──
        public void CombineTypeAndIndex(){} // RVA: 0x7C55070
        public void Internal_CallSystemDelegate(){} // RVA: 0x7C55080
        public void .cctor(){} // RVA: 0x7C55280
    }

    public class PlayableSystems[] : Array
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

    public class Playable[] : Array
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
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ScriptPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7C32560
        public void CreateScriptOutput(){} // RVA: 0x7C32660
    }

    public class ScriptPlayableOutput : ValueType
    {
        public object m_Handle;

        // ── Methods ──
        public void Create(){} // RVA: 0x7C32760
        public void .ctor(){} // RVA: 0x968F80
        public void get_Null(){} // RVA: 0x7C32980
        public void GetHandle(){} // RVA: 0x4513B0
        public void op_Implicit(){} // RVA: 0x7B1AFB0
    }

    public class ScriptPlayableOutput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ScriptPlayable`1 : ValueType
    {
        public object m_Handle;
        public object m_NullPlayable;

        // ── Methods ──
        public void get_Null(){} // RVA: 0xA94080
        public void Create(){} // RVA: 0xA94080
        public void CreateHandle(){} // RVA: 0xA94080
        public void CreateScriptInstance(){} // RVA: 0x87C0D0
        public void CloneScriptInstance(){} // RVA: 0x87C5C0
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x87C5C0
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x87C5C0
        public void .ctor(){} // RVA: 0xA94080
        public void GetHandle(){} // RVA: 0xA94080
        public void GetBehaviour(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0xA94080
        public void op_Explicit(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

}