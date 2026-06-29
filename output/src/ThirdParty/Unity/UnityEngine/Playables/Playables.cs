// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Playables
// Classes: 32
// Methods: 477

namespace ThirdParty.Unity.UnityEngine.Playables
{
    public class FrameData : ValueType
    {
        // ── Methods ──
        public void HasFlags(){} // RVA: 0x7A7EE3280
        public void get_deltaTime(){} // RVA: 0x7A7EE3290
        public void get_effectiveSpeed(){} // RVA: 0x7A7ED43D0
        public void get_evaluationType(){} // RVA: 0x7A7EE32A0
        public void get_seekOccurred(){} // RVA: 0x7A7EE32B0
        public void get_timeLooped(){} // RVA: 0x7A7EE32C0
        public void get_timeHeld(){} // RVA: 0x7A7EE32D0
        public void get_output(){} // RVA: 0x7A7EE32E0
        public void get_effectivePlayState(){} // RVA: 0x7A7EE32F0
    }

    public class FrameRate : ValueType
    {
        // ── Methods ──
        public void get_dropFrame(){} // RVA: 0x7A7E3B470
        public void get_rate(){} // RVA: 0x7A7EE3310
        public void .ctor(){} // RVA: 0x7A7EE3320
        public void IsValid(){} // RVA: 0x7A7ED6410
        public void Equals(){} // RVA: 0x7A7EE3330
        public void op_Equality(){} // RVA: 0x7AEF3EA90
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void ToString(){} // RVA: 0x7A7EE3430
        public void DoubleToFrameRate(){} // RVA: 0x7AEF3ED60
        public void .cctor(){} // RVA: 0x7AEF3EEC0
    }

    public class FrameRate[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class INotification
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7A8051B10
    }

    public class INotificationReceiver
    {
        // ── Methods ──
        public void OnNotify(){} // RVA: 0x7A8051B10
    }

    public class IPlayable
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7A8051B10
    }

    public class IPlayableAsset
    {
        // ── Methods ──
        public void CreatePlayable(){} // RVA: 0x7A7E00C90
        public void get_duration(){} // RVA: 0x7A7E06760
    }

    public class IPlayableBehaviour
    {
        // ── Methods ──
        public void OnGraphStart(){} // RVA: 0x7A7E18800
        public void OnGraphStop(){} // RVA: 0x7A7E18800
        public void OnPlayableCreate(){} // RVA: 0x7A7E18800
        public void OnPlayableDestroy(){} // RVA: 0x7A7E18800
        public void OnBehaviourPlay(){} // RVA: 0x7A8051B10
        public void OnBehaviourPause(){} // RVA: 0x7A8051B10
        public void PrepareFrame(){} // RVA: 0x7A8051B10
        public void ProcessFrame(){} // RVA: 0x7A8051B10
    }

    public class IPlayableOutput
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7A8051B10
    }

    public class Playable : ValueType
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7AEF3EFA0
        public void Create(){} // RVA: 0x7AEF3F010
        public void .ctor(){} // RVA: 0x7A7662BD0
        public void GetHandle(){} // RVA: 0x7A79E7410
        public void IsPlayableOfType(){} // RVA: 0x7A7E01900
        public void GetPlayableType(){} // RVA: 0x7A7EE3440
        public void Equals(){} // RVA: 0x7A7EE3450
        public void .cctor(){} // RVA: 0x7AEF3F2F0
    }

    public class PlayableAsset : ScriptableObject
    {
        // ── Methods ──
        public void CreatePlayable(){} // RVA: 0x7A7E00C90
        public void get_duration(){} // RVA: 0x7AEF3F3A0
        public void get_outputs(){} // RVA: 0x7AEF3F400
        public void Internal_CreatePlayable(){} // RVA: 0x7AEF3F460
        public void Internal_GetPlayableAssetDuration(){} // RVA: 0x7AEF3F5F0
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class PlayableAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableBehaviour : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void OnGraphStart(){} // RVA: 0x7A80D7310
        public void OnGraphStop(){} // RVA: 0x7A80D7310
        public void OnPlayableCreate(){} // RVA: 0x7A80D7310
        public void OnPlayableDestroy(){} // RVA: 0x7A80D7310
        public void OnBehaviourPlay(){} // RVA: 0x7A80D7310
        public void OnBehaviourPause(){} // RVA: 0x7A80D7310
        public void PrepareFrame(){} // RVA: 0x7A80D7310
        public void ProcessFrame(){} // RVA: 0x7A80D7310
        public void Clone(){} // RVA: 0x7AEF3F630
    }

    public class PlayableBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableBinding : ValueType
    {
        // ── Methods ──
        public void get_sourceObject(){} // RVA: 0x7A7E42C20
        public void CreateOutput(){} // RVA: 0x7A7EE3490
        public void CreateInternal(){} // RVA: 0x7AEF3F740
        public void .cctor(){} // RVA: 0x7AEF3F8E0
    }

    public class PlayableDirector : Behaviour
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7AEF49830
        public void set_extrapolationMode(){} // RVA: 0x7AEF49880
        public void get_extrapolationMode(){} // RVA: 0x7AEF498E0
        public void get_playableAsset(){} // RVA: 0x7AEF49930
        public void set_playableAsset(){} // RVA: 0x7AEF499F0
        public void get_playableGraph(){} // RVA: 0x7AEF49A50
        public void get_playOnAwake(){} // RVA: 0x7AEF49AD0
        public void set_playOnAwake(){} // RVA: 0x7AEF49B20
        public void DeferredEvaluate(){} // RVA: 0x7AEF49B80
        public void Play(){} // RVA: 0x7AEF4A320
        public void SetGenericBinding(){} // RVA: 0x7AEF49FA0
        public void set_timeUpdateMode(){} // RVA: 0x7AEF4A010
        public void get_timeUpdateMode(){} // RVA: 0x7AEF4A070
        public void set_time(){} // RVA: 0x7AEF4A0C0
        public void get_time(){} // RVA: 0x7AEF4A120
        public void set_initialTime(){} // RVA: 0x7AEF4A170
        public void get_initialTime(){} // RVA: 0x7AEF4A1D0
        public void get_duration(){} // RVA: 0x7AEF4A220
        public void Evaluate(){} // RVA: 0x7AEF4A270
        public void PlayOnFrame(){} // RVA: 0x7AEF4A2C0
        public void Stop(){} // RVA: 0x7AEF4A370
        public void Pause(){} // RVA: 0x7AEF4A3C0
        public void Resume(){} // RVA: 0x7AEF4A410
        public void RebuildGraph(){} // RVA: 0x7AEF4A460
        public void ClearReferenceValue(){} // RVA: 0x7AEF4A4B0
        public void SetReferenceValue(){} // RVA: 0x7AEF4A510
        public void GetReferenceValue(){} // RVA: 0x7AEF4A580
        public void GetGenericBinding(){} // RVA: 0x7AEF4A5F0
        public void ClearGenericBinding(){} // RVA: 0x7AEF4A650
        public void RebindPlayableGraphOutputs(){} // RVA: 0x7AEF4A6B0
        public void ProcessPendingGraphChanges(){} // RVA: 0x7AEF4A700
        public void HasGenericBinding(){} // RVA: 0x7AEF4A750
        public void GetPlayState(){} // RVA: 0x7AEF49830
        public void SetWrapMode(){} // RVA: 0x7AEF49880
        public void GetWrapMode(){} // RVA: 0x7AEF498E0
        public void EvaluateNextFrame(){} // RVA: 0x7AEF49B80
        public void GetGraphHandle(){} // RVA: 0x7AEF4A7B0
        public void SetPlayOnAwake(){} // RVA: 0x7AEF49B20
        public void GetPlayOnAwake(){} // RVA: 0x7AEF49AD0
        public void Internal_SetGenericBinding(){} // RVA: 0x7AEF49FA0
        public void SetPlayableAsset(){} // RVA: 0x7AEF499F0
        public void Internal_GetPlayableAsset(){} // RVA: 0x7AEF4A820
        public void add_played(){} // RVA: 0x7AEF4A870
        public void remove_played(){} // RVA: 0x7AEF4A980
        public void add_paused(){} // RVA: 0x7AEF4AA90
        public void remove_paused(){} // RVA: 0x7AEF4ABA0
        public void add_stopped(){} // RVA: 0x7AEF4ACB0
        public void remove_stopped(){} // RVA: 0x7AEF4ADC0
        public void ResetFrameTiming(){} // RVA: 0x7AEF4AED0
        public void SendOnPlayableDirectorPlay(){} // RVA: 0x7AEF4AF20
        public void SendOnPlayableDirectorPause(){} // RVA: 0x7AEF4AF40
        public void SendOnPlayableDirectorStop(){} // RVA: 0x7AEF4AF60
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void PlayOnFrame_Injected(){} // RVA: 0x7AEF4AF80
        public void ClearReferenceValue_Injected(){} // RVA: 0x7AEF4AFE0
        public void SetReferenceValue_Injected(){} // RVA: 0x7AEF4B040
        public void GetReferenceValue_Injected(){} // RVA: 0x7AEF4B0B0
        public void GetGraphHandle_Injected(){} // RVA: 0x7AEF4B120
    }

    public class PlayableDirector[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableExtensions : Object
    {
        // ── Methods ──
        public void IsNull(){} // RVA: 0x7AA560190
        public void IsValid(){} // RVA: 0x7AA560960
        public void Destroy(){} // RVA: 0x7AA55DB20
        public void GetGraph(){} // RVA: 0x7A8051B10
        public void GetPlayState(){} // RVA: 0x7A8051B10
        public void Play(){} // RVA: 0x7A8051B10
        public void Pause(){} // RVA: 0x7AA560F20
        public void SetSpeed(){} // RVA: 0x7A8051B10
        public void SetDuration(){} // RVA: 0x7A8051B10
        public void GetDuration(){} // RVA: 0x7A8051B10
        public void SetTime(){} // RVA: 0x7A8051B10
        public void GetTime(){} // RVA: 0x7A8051B10
        public void GetPreviousTime(){} // RVA: 0x7A8051B10
        public void IsDone(){} // RVA: 0x7A8051B10
        public void SetPropagateSetTime(){} // RVA: 0x7A8051B10
        public void SetInputCount(){} // RVA: 0x7A8051B10
        public void GetInputCount(){} // RVA: 0x7AA55EB10
        public void GetOutputCount(){} // RVA: 0x7AA55F130
        public void GetInput(){} // RVA: 0x7AA55E830
        public void SetInputWeight(){} // RVA: 0x7AA561DC0
        public void GetInputWeight(){} // RVA: 0x7AA55EEB0
        public void DisconnectInput(){} // RVA: 0x7AA55DD80
        public void SetTraversalMode(){} // RVA: 0x7A8051B10
        public void GetTimeWrapMode(){} // RVA: 0x7A8051B10
        public void SetTimeWrapMode(){} // RVA: 0x7A8051B10
    }

    public class PlayableGraph : ValueType
    {
        // ── Methods ──
        public void GetRootPlayable(){} // RVA: 0x7A7EE3620
        public void Connect(){} // RVA: 0x7A77B4C10
        public void Disconnect(){} // RVA: 0x7A8051B10
        public void DestroyPlayable(){} // RVA: 0x7A77B4E00
        public void GetOutputCountByType(){} // RVA: 0x7A7E00710
        public void GetOutputByType(){} // RVA: 0x7A8051B10
        public void Evaluate(){} // RVA: 0x7A7EE38A0
        public void Create(){} // RVA: 0x7AEF3FB70
        public void Destroy(){} // RVA: 0x7A7EE3710
        public void IsValid(){} // RVA: 0x7A7EE3760
        public void IsPlaying(){} // RVA: 0x7A7EE37B0
        public void Play(){} // RVA: 0x7A7EE3800
        public void Stop(){} // RVA: 0x7A7EE3850
        public void GetResolver(){} // RVA: 0x7A7EE38B0
        public void GetPlayableCount(){} // RVA: 0x7A7EE3900
        public void GetRootPlayableCount(){} // RVA: 0x7A7EE3950
        public void SynchronizeEvaluation(){} // RVA: 0x7A7EE39A0
        public void CreatePlayableHandle(){} // RVA: 0x7A7EE3A00
        public void CreateScriptOutputInternal(){} // RVA: 0x7A7EE3A80
        public void GetRootPlayableInternal(){} // RVA: 0x7A7EE3620
        public void IsMatchFrameRateEnabled(){} // RVA: 0x7A7EE3A90
        public void GetFrameRate(){} // RVA: 0x7A7EE3AE0
        public void GetOutputCountByTypeInternal(){} // RVA: 0x7A7EE3AF0
        public void GetOutputByTypeInternal(){} // RVA: 0x7A7EE3B00
        public void ConnectInternal(){} // RVA: 0x7A7EE3B10
        public void DisconnectInternal(){} // RVA: 0x7A7EE3BA0
        public void DestroyPlayableInternal(){} // RVA: 0x7A7EE3C10
        public void Create_Injected(){} // RVA: 0x7AEF40370
        public void Destroy_Injected(){} // RVA: 0x7AEF3FBE0
        public void IsValid_Injected(){} // RVA: 0x7AEF3FC30
        public void IsPlaying_Injected(){} // RVA: 0x7AEF3FC80
        public void Play_Injected(){} // RVA: 0x7AEF3FCD0
        public void Stop_Injected(){} // RVA: 0x7AEF3FD20
        public void Evaluate_Injected(){} // RVA: 0x7AEF3FD70
        public void GetResolver_Injected(){} // RVA: 0x7AEF3FDD0
        public void GetPlayableCount_Injected(){} // RVA: 0x7AEF3FE20
        public void GetRootPlayableCount_Injected(){} // RVA: 0x7AEF3FE70
        public void SynchronizeEvaluation_Injected(){} // RVA: 0x7AEF403D0
        public void CreatePlayableHandle_Injected(){} // RVA: 0x7AEF40430
        public void CreateScriptOutputInternal_Injected(){} // RVA: 0x7AEF3FF90
        public void GetRootPlayableInternal_Injected(){} // RVA: 0x7AEF40490
        public void IsMatchFrameRateEnabled_Injected(){} // RVA: 0x7AEF40080
        public void GetFrameRate_Injected(){} // RVA: 0x7AEF40500
        public void GetOutputCountByTypeInternal_Injected(){} // RVA: 0x7AEF40130
        public void GetOutputByTypeInternal_Injected(){} // RVA: 0x7AEF40190
        public void ConnectInternal_Injected(){} // RVA: 0x7AEF40560
        public void DisconnectInternal_Injected(){} // RVA: 0x7AEF405F0
        public void DestroyPlayableInternal_Injected(){} // RVA: 0x7AEF40660
    }

    public class PlayableGraph[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A7E18800
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableHandle : ValueType
    {
        // ── Methods ──
        public void GetObject(){} // RVA: 0x7A8051B10
        public void IsPlayableOfType(){} // RVA: 0x7A77B5150
        public void get_Null(){} // RVA: 0x7AEF406C0
        public void GetInput(){} // RVA: 0x7A7EE3C70
        public void SetInputWeight(){} // RVA: 0x7A7EE3F80
        public void GetInputWeight(){} // RVA: 0x7A7EE3CB0
        public void Destroy(){} // RVA: 0x7A7EE3CC0
        public void op_Equality(){} // RVA: 0x7AEF40B80
        public void Equals(){} // RVA: 0x7A7EE3CE0
        public void GetHashCode(){} // RVA: 0x7A7EE3D70
        public void CompareVersion(){} // RVA: 0x7ABA3DB30
        public void CheckInputBounds(){} // RVA: 0x7A7EE3D90
        public void IsNull(){} // RVA: 0x7A7EE3DA0
        public void IsValid(){} // RVA: 0x7A7EE3DB0
        public void GetPlayableType(){} // RVA: 0x7A7EE3DC0
        public void GetJobType(){} // RVA: 0x7A7EE3DD0
        public void SetScriptInstance(){} // RVA: 0x7A7EE3DE0
        public void GetPlayState(){} // RVA: 0x7A7EE3DF0
        public void Play(){} // RVA: 0x7A7EE3E00
        public void Pause(){} // RVA: 0x7A7EE3E10
        public void SetSpeed(){} // RVA: 0x7A7EE3E20
        public void GetTime(){} // RVA: 0x7A7EE3E30
        public void SetTime(){} // RVA: 0x7A7EE3E40
        public void IsDone(){} // RVA: 0x7A7EE3E50
        public void SetDone(){} // RVA: 0x7A7EE3E60
        public void GetDuration(){} // RVA: 0x7A7EE3E70
        public void SetDuration(){} // RVA: 0x7A7EE3E80
        public void SetPropagateSetTime(){} // RVA: 0x7A7EE3E90
        public void GetGraph(){} // RVA: 0x7A7EE3EA0
        public void GetInputCount(){} // RVA: 0x7A7EE3F50
        public void SetInputCount(){} // RVA: 0x7A7EE3F60
        public void GetOutputCount(){} // RVA: 0x7A7EE3F70
        public void GetPreviousTime(){} // RVA: 0x7A7EE4030
        public void SetTraversalMode(){} // RVA: 0x7A7EE4040
        public void GetJobData(){} // RVA: 0x7A7EE4050
        public void GetTimeWrapMode(){} // RVA: 0x7A7EE4060
        public void SetTimeWrapMode(){} // RVA: 0x7A7EE4070
        public void GetScriptInstance(){} // RVA: 0x7A7EE4080
        public void GetInputHandle(){} // RVA: 0x7A7EE4090
        public void SetInputWeightFromIndex(){} // RVA: 0x7A7EE40C0
        public void GetInputWeightFromIndex(){} // RVA: 0x7A7EE40D0
        public void .cctor(){} // RVA: 0x7AEF42230
        public void IsNull_Injected(){} // RVA: 0x7AEF42270
        public void IsValid_Injected(){} // RVA: 0x7AEF422C0
        public void GetPlayableType_Injected(){} // RVA: 0x7AEF42310
        public void GetJobType_Injected(){} // RVA: 0x7AEF42360
        public void SetScriptInstance_Injected(){} // RVA: 0x7AEF423B0
        public void GetPlayState_Injected(){} // RVA: 0x7AEF42410
        public void Play_Injected(){} // RVA: 0x7AEF42460
        public void Pause_Injected(){} // RVA: 0x7AEF424B0
        public void SetSpeed_Injected(){} // RVA: 0x7AEF42500
        public void GetTime_Injected(){} // RVA: 0x7AEF42560
        public void SetTime_Injected(){} // RVA: 0x7AEF425B0
        public void IsDone_Injected(){} // RVA: 0x7AEF42610
        public void SetDone_Injected(){} // RVA: 0x7AEF42660
        public void GetDuration_Injected(){} // RVA: 0x7AEF426C0
        public void SetDuration_Injected(){} // RVA: 0x7AEF42710
        public void SetPropagateSetTime_Injected(){} // RVA: 0x7AEF42770
        public void GetGraph_Injected(){} // RVA: 0x7AEF427D0
        public void GetInputCount_Injected(){} // RVA: 0x7AEF42830
        public void SetInputCount_Injected(){} // RVA: 0x7AEF42880
        public void GetOutputCount_Injected(){} // RVA: 0x7AEF428E0
        public void SetInputWeight_Injected(){} // RVA: 0x7AEF42930
        public void GetPreviousTime_Injected(){} // RVA: 0x7AEF429A0
        public void SetTraversalMode_Injected(){} // RVA: 0x7AEF429F0
        public void GetJobData_Injected(){} // RVA: 0x7AEF42A50
        public void GetTimeWrapMode_Injected(){} // RVA: 0x7AEF42AA0
        public void SetTimeWrapMode_Injected(){} // RVA: 0x7AEF42AF0
        public void GetScriptInstance_Injected(){} // RVA: 0x7AEF42B50
        public void GetInputHandle_Injected(){} // RVA: 0x7AEF42BA0
        public void SetInputWeightFromIndex_Injected(){} // RVA: 0x7AEF42C10
        public void GetInputWeightFromIndex_Injected(){} // RVA: 0x7AEF42C80
    }

    public class PlayableHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableOutput : ValueType
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7AEF42CE0
        public void .ctor(){} // RVA: 0x7A7662BD0
        public void GetHandle(){} // RVA: 0x7A79E7410
        public void IsPlayableOutputOfType(){} // RVA: 0x7A7E01900
        public void Equals(){} // RVA: 0x7A7EE40E0
        public void .cctor(){} // RVA: 0x7AEF42E40
    }

    public class PlayableOutputExtensions : Object
    {
        // ── Methods ──
        public void IsOutputValid(){} // RVA: 0x7A8051B10
        public void SetReferenceObject(){} // RVA: 0x7A8051B10
        public void SetUserData(){} // RVA: 0x7A8051B10
        public void GetSourcePlayable(){} // RVA: 0x7A8051B10
        public void SetSourcePlayable(){} // RVA: 0x7AA565E40
        public void GetSourceOutputPort(){} // RVA: 0x7AA5650E0
        public void SetWeight(){} // RVA: 0x7A8051B10
        public void PushNotification(){} // RVA: 0x7A8051B10
        public void AddNotificationReceiver(){} // RVA: 0x7A8051B10
    }

    public class PlayableOutputHandle : ValueType
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7AEF42EF0
        public void IsPlayableOutputOfType(){} // RVA: 0x7A77B5320
        public void GetHashCode(){} // RVA: 0x7A7EE3D70
        public void op_Equality(){} // RVA: 0x7AEF42F60
        public void Equals(){} // RVA: 0x7A7EE42F0
        public void CompareVersion(){} // RVA: 0x7ABA3DB30
        public void IsValid(){} // RVA: 0x7A7EE4380
        public void GetPlayableOutputType(){} // RVA: 0x7A7EE4390
        public void SetReferenceObject(){} // RVA: 0x7A7EE43A0
        public void SetUserData(){} // RVA: 0x7A7EE43B0
        public void GetSourcePlayable(){} // RVA: 0x7A7EE43C0
        public void SetSourcePlayable(){} // RVA: 0x7A7EE4470
        public void GetSourceOutputPort(){} // RVA: 0x7A7EE4520
        public void SetWeight(){} // RVA: 0x7A7EE4530
        public void PushNotification(){} // RVA: 0x7A7EE4540
        public void AddNotificationReceiver(){} // RVA: 0x7A7EE4570
        public void .cctor(){} // RVA: 0x7AEF437D0
        public void IsValid_Injected(){} // RVA: 0x7AEF43810
        public void GetPlayableOutputType_Injected(){} // RVA: 0x7AEF43860
        public void SetReferenceObject_Injected(){} // RVA: 0x7AEF438B0
        public void SetUserData_Injected(){} // RVA: 0x7AEF43910
        public void GetSourcePlayable_Injected(){} // RVA: 0x7AEF43970
        public void SetSourcePlayable_Injected(){} // RVA: 0x7AEF439D0
        public void GetSourceOutputPort_Injected(){} // RVA: 0x7AEF43A40
        public void SetWeight_Injected(){} // RVA: 0x7AEF43A90
        public void PushNotification_Injected(){} // RVA: 0x7AEF43AF0
        public void AddNotificationReceiver_Injected(){} // RVA: 0x7AEF43B70
    }

    public class PlayableOutputHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PlayableOutput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Playable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ScriptPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEF43BD0
        public void CreateScriptOutput(){} // RVA: 0x7AEF43CD0
    }

    public class ScriptPlayableOutput : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AEF43E20
        public void .ctor(){} // RVA: 0x7A7EE4580
        public void get_Null(){} // RVA: 0x7AEF44060
        public void GetHandle(){} // RVA: 0x7A79E7410
        public void op_Implicit(){} // RVA: 0x7AEE7B080
    }

    public class ScriptPlayableOutput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ScriptPlayable`1 : ValueType
    {
        // ── Methods ──
        public void get_Null(){} // RVA: 0x7A8051B10
        public void Create(){} // RVA: 0x7A8051B10
        public void CreateHandle(){} // RVA: 0x7A8051B10
        public void CreateScriptInstance(){} // RVA: 0x7A7E006B0
        public void CloneScriptInstance(){} // RVA: 0x7A7E00BA0
        public void CloneScriptInstanceFromEngineObject(){} // RVA: 0x7A7E00BA0
        public void CloneScriptInstanceFromIClonable(){} // RVA: 0x7A7E00BA0
        public void .ctor(){} // RVA: 0x7A8051B10
        public void GetHandle(){} // RVA: 0x7A8051B10
        public void GetBehaviour(){} // RVA: 0x7A8051B10
        public void op_Implicit(){} // RVA: 0x7A8051B10
        public void op_Explicit(){} // RVA: 0x7A8051B10
        public void Equals(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

}