// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 68
// Methods: 316

public class AIUpdate : ValueType
{
}

public class AIUpdatePostScript : ValueType
{
}

public class AOTEmittedFormatter`1 : EasyBaseFormatter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ARCoreUpdate : ValueType
{
}

public class Action : Object
{
    public object enabled;

    // ── Methods ──
    public void Enable(){} // RVA: 0x7FFD4E091060
    public void set_enabled(){} // RVA: 0x7FFD53863A50
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ActionEventPtr : ValueType
{
    public object action;
    public object phase;
    public object control;
    public object interaction;
    public object time;
    public object startTime;
    public object duration;
    public object valueSizeInBytes;

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFD54982A60
    public void get_phase(){} // RVA: 0x7FFD54982A90
    public void get_control(){} // RVA: 0x7FFD54982AA0
    public void get_interaction(){} // RVA: 0x7FFD54982AE0
    public void get_time(){} // RVA: 0x7FFD54982B30
    public void get_startTime(){} // RVA: 0x7FFD54982B90
    public void get_duration(){} // RVA: 0x7FFD54982BA0
    public void get_valueSizeInBytes(){} // RVA: 0x7FFD54982C10
    public void ReadValueAsObject(){} // RVA: 0x7FFD54982C20
    public void ReadValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void ToString(){} // RVA: 0x7FFD54982F70
}

public class ActionQueryMatcher : UQueryMatcher
{
    public object callBack;

    // ── Methods ──
    public void get_callBack(){} // RVA: 0x7FFD4E078E90
    public void OnRuleMatchedElement(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ActionSettings : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC738D0
    public void Invoke(){} // RVA: 0x7FFD4FC73A40
}

public class Action`1 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Enable(){} // RVA: 0x7FFD4E091060
}

public class Action`2 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Enable(){} // RVA: 0x7FFD4E091060
}

public class Action`3 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Enable(){} // RVA: 0x7FFD4E091060
}

public class Action`4 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class Action`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
    public void EndInvoke(){} // RVA: 0x7FFD4E090A40
}

public class ActivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD57492800
    public void Invoke(){} // RVA: 0x7FFD51080E20
    public void BeginInvoke(){} // RVA: 0x7FFD574928D0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class ActivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD574924A0
    public void Invoke(){} // RVA: 0x7FFD57492620
    public void BeginInvoke(){} // RVA: 0x7FFD57492640
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class Activity : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFD4FD95A90
    public void Drop(){} // RVA: 0x7FFD4FD95B10
    public void SetState(){} // RVA: 0x7FFD4FD95B90
    public void Assets(){} // RVA: 0x7FFD4FD95C20
    public void SetAssets(){} // RVA: 0x7FFD4FD95CB0
    public void Timestamps(){} // RVA: 0x7FFD4FD95D40
    public void SetTimestamps(){} // RVA: 0x7FFD4FD95DD0
    public void Party(){} // RVA: 0x7FFD4FD95E60
    public void SetParty(){} // RVA: 0x7FFD4FD95EF0
    public void Secrets(){} // RVA: 0x7FFD4FD95F80
    public void SetSecrets(){} // RVA: 0x7FFD4FD96010
}

public class ActivityBaggageLogScopeWrapper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetEnumerator(){} // RVA: 0x7FFD5376AE70
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5376AF40
    public void ToString(){} // RVA: 0x7FFD5376B010
}

public class ActivityLogScope : Object
{
    public object Count;
    public object Item;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5376A210
    public void get_Count(){} // RVA: 0x7FFD4E4FBBE0
    public void get_Item(){} // RVA: 0x7FFD5376A950
    public void ToString(){} // RVA: 0x7FFD5376A9E0
    public void GetEnumerator(){} // RVA: 0x7FFD5376AC70
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5376AC70
}

public class AddEventAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F9D91D0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class AdjustmentRule : Object
{
    public object DateStart;
    public object DateEnd;
    public object DaylightDelta;
    public object DaylightTransitionStart;
    public object DaylightTransitionEnd;
    public object BaseUtcOffsetDelta;
    public object NoDaylightTransitions;
    public object HasDaylightSaving;

    // ── Methods ──
    public void get_DateStart(){} // RVA: 0x7FFD4E35C380
    public void get_DateEnd(){} // RVA: 0x7FFD4E3447C0
    public void get_DaylightDelta(){} // RVA: 0x7FFD4E36F0C0
    public void get_DaylightTransitionStart(){} // RVA: 0x7FFD4FF91360
    public void get_DaylightTransitionEnd(){} // RVA: 0x7FFD4E34AE10
    public void get_BaseUtcOffsetDelta(){} // RVA: 0x7FFD4E409500
    public void get_NoDaylightTransitions(){} // RVA: 0x7FFD4E36A020
    public void get_HasDaylightSaving(){} // RVA: 0x7FFD539232A0
    public void Equals(){} // RVA: 0x7FFD53923480
    public void GetHashCode(){} // RVA: 0x7FFD539235F0
    public void .ctor(){} // RVA: 0x7FFD53924A30 | overloaded x3
    public void CreateAdjustmentRule(){} // RVA: 0x7FFD53923790
    public void IsStartDateMarkerForBeginningOfYear(){} // RVA: 0x7FFD539238D0
    public void IsEndDateMarkerForEndOfYear(){} // RVA: 0x7FFD53923A20
    public void ValidateAdjustmentRule(){} // RVA: 0x7FFD53923B70
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD539242E0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD539243C0
}

public class AlignOfHelper`1 : ValueType
{
}

public class AllocatorHandle : ValueType
{
    public object TableEntry;
    public object Value;
    public object Handle;
    public object ToAllocator;
    public object IsAutoDispose;

    // ── Methods ──
    public void get_TableEntry(){} // RVA: 0x7FFD5492F030
    public void Rewind(){} // RVA: 0x7FFD4E341310
    public void op_Implicit(){} // RVA: 0x7FFD5492F100
    public void get_Value(){} // RVA: 0x7FFD4FEE85D0
    public void Try(){} // RVA: 0x7FFD5492F120
    public void get_Handle(){} // RVA: 0x7FFD4F840210
    public void get_ToAllocator(){} // RVA: 0x7FFD5492F180
    public void get_IsAutoDispose(){} // RVA: 0x7FFD5492F190
    public void Dispose(){} // RVA: 0x7FFD5492F260
    public void Equals(){} // RVA: 0x7FFD5392EF20 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFD4FEE85D0
    public void CompareTo(){} // RVA: 0x7FFD5392F000
}

public class AllowedAsciiCodePoints : ValueType
{
    // ── Methods ──
    public void PopulateAllowedCodePoints(){} // RVA: 0x7FFD53EA5D40
}

public class AlphaButtonClickMask : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x7FFD4E341330
    public void IsRaycastLocationValid(){} // RVA: 0x7FFD4E341780
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class AnalyticsCoreStatsUpdate : ValueType
{
}

public class Anchors : ValueType
{
}

public class AnimatedButton : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class AnimationDataSet`2 : ValueType
{
    public object capacity;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x7FFD4E079960
    public void set_capacity(){} // RVA: 0x7FFD4E090ED0
    public void LocalInit(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void IndexOf(){}
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void Remove(){} // RVA: 0x7FFD4E090ED0
    public void Replace(){} // RVA: 0x7FFD4E2ADC40
    public void RemoveAll(){} // RVA: 0x7FFD4E090980 | overloaded x2
    public void GetActivePropertiesForElement(){} // RVA: 0x7FFD4E099B30
}

public class AnonymousProgress`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Report(){} // RVA: 0x7FFD4E2ADC40
}

public class AnyKeyObj : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFD53740EF0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ApiBundleDropNotificationDetails : ApiModel
{
    public object title;
    public object body;
    public object imageUrl;

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFD4E3BCD50
    public void set_title(){} // RVA: 0x7FFD4E3BCD60
    public void get_body(){} // RVA: 0x7FFD4E409590
    public void set_body(){} // RVA: 0x7FFD4E4095A0
    public void get_imageUrl(){} // RVA: 0x7FFD4E505600
    public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
    public void .ctor(){} // RVA: 0x7FFD5729A030
}

public class ApiRequestData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5727FFC0 | overloaded x3
    public void op_Implicit(){} // RVA: 0x7FFD57280130 | overloaded x3
}

public class ApiVRChatProductStore : ApiModel
{
    public object planId;

    // ── Methods ──
    public void get_planId(){} // RVA: 0x7FFD4E3BCD50
    public void set_planId(){} // RVA: 0x7FFD4E3BCD60
    public void .ctor(){} // RVA: 0x7FFD57311270
}

public class Appearance : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC659F0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5106D540
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class Array : ValueType
{
    // ── Methods ──
    public void IsCustom(){} // RVA: 0x7FFD5492EDC0
    public void CustomResize(){} // RVA: 0x7FFD54931140
    public void Resize(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
}

public class Array16`1 : ValueType
{
}

public class Array256`1 : ValueType
{
}

public class Array32768`1 : ValueType
{
    public object Length;

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFD4E079960
    public void ElementAt(){} // RVA: 0x7FFD4E087DE0
}

public class Array4096`1 : ValueType
{
}

public class ArrayEnumerator : Object
{
    public object Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A864A0
    public void MoveNext(){} // RVA: 0x7FFD53A86520
    public void Reset(){} // RVA: 0x7FFD4FC0DC40
    public void Clone(){} // RVA: 0x7FFD53932B10
    public void get_Current(){} // RVA: 0x7FFD53A86540
}

public class ArrayPoolImpl`1 : Object
{
    public object ObjectType;
    public object CountInactive;

    // ── Methods ──
    public void get_ObjectType(){} // RVA: 0x7FFD4E078E90
    public void get_CountInactive(){} // RVA: 0x7FFD4E079960
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Get(){} // RVA: 0x7FFD4E2ADC40
    public void Contains(){} // RVA: 0x7FFD4E079F60
    public void Release(){} // RVA: 0x7FFD4E090A40
    public void Cleanup(){} // RVA: 0x7FFD4E079960
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ArraySurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749D000
    public void SetObjectData(){} // RVA: 0x7FFD5749D9D0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class AsciiPreescapedData : ValueType
{
    // ── Methods ──
    public void PopulatePreescapedData(){} // RVA: 0x7FFD543ED960
    public void TryGetPreescapedData(){} // RVA: 0x7FFD53EA60A0
}

public class AspectStretcher : ValueType
{
    public object Aspect;

    // ── Methods ──
    public void get_Aspect(){} // RVA: 0x7FFD4FC6C150
    public void .ctor(){} // RVA: 0x7FFD4FC6C160
    public void Stretch(){} // RVA: 0x7FFD4FC6C180
    public void Unstretch(){} // RVA: 0x7FFD4FC6C1B0
}

public class AssetBundleRequestAwaiter : ValueType
{
    public object IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F2140
    public void OnCompleted(){} // RVA: 0x7FFD548F3490
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F34A0
}

public class AssetPreloader : Object
{
    public object _name;
    public object _hideFlags;
    public object f_4F2;

    // ── Methods ──
    public void Finalize(){} // RVA: 0x7FFD4F043300
    public void Equals(){} // RVA: 0x7FFD4F043520
    public void GetHashCode(){} // RVA: 0x7FFD4F0436B0
    public void op_Implicit(){} // RVA: 0x7FFD4F043830
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F043D80
    public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
    public void GetCachedPtr(){} // RVA: 0x7FFD4F043E80
    public void get_name(){} // RVA: 0x7FFD4F043FB0
    public void Initialize(){} // RVA: 0x7FFD4F044180
    public void Instantiate(){} // RVA: 0x7FFD4F0441F0
    public void ToString(){} // RVA: 0x7FFD4F0446B0
    public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
    public void InitializePreloadData(){} // RVA: 0x7FFD4F0447E0
    public void BuildPreloadManifest(){} // RVA: 0x7FFD4F044D30
    public void IsSetup(){} // RVA: 0x7FFD4F044D50
    public void HandlePreloaderDataInitialization(){} // RVA: 0x7FFD4F044E10
    public void set_Color(){} // RVA: 0x7FFD4F044F40
    public void GetPreloadedAssetData(){} // RVA: 0x7FFD4E919180
    public void ConfigureAssetPreloader(){} // RVA: 0x7FFD4F044F50
    public void Destroy(){} // RVA: 0x7FFD4F045140
    public void Cleanup(){} // RVA: 0x7FFD4F045280
    public void DestroyImmediate(){} // RVA: 0x7FFD4F045380
    public void DestroyImmediate_23F188AB430E(){} // RVA: 0x7FFD4F045540
    public void FindObjectsOfType(){} // RVA: 0x7FFD4F0456E0
    public void FindObjectsOfType_B0FED4068939(){} // RVA: 0x7FFD4E516BA0
    public void FindObjectsByType(){} // RVA: 0x7FFD4F045820
    public void .ctor(){} // RVA: 0x7FFD4F045A20
    public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F046300
    public void CompositionMethod(){} // RVA: 0x7FFD4E433AF0
    public void set_hideFlags(){} // RVA: 0x7FFD4F0463C0
    public void Initialize_C7F63F0380B4(){} // RVA: 0x7FFD4F046910
    public void FindObjectOfType(){} // RVA: 0x7FFD4F046D80
    public void Dispose(){} // RVA: 0x7FFD4F046FE0
    public void FindFirstObjectByType(){} // RVA: 0x7FFD4F0470B0
    public void CheckNullArgument(){} // RVA: 0x7FFD4F047290
}

public class AsyncInstantiateOperationConfiguredSource`1 : Object
{
    public object NextNode;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E088E00
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
    public void Continuation(){} // RVA: 0x7FFD4E090A40
}

public class AsyncOperationAwaiter : ValueType
{
    public object IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F0E30
    public void OnCompleted(){} // RVA: 0x7FFD548F0F80
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F0F90
}

public class AsyncTriggerEnumerator : MoveNextSource
{
    public object Current;
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFD4E090BF0
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFD4E090A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFD4E090A40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class AsyncUnitSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetResult(){} // RVA: 0x7FFD548AB5F0
    public void GetStatus(){} // RVA: 0x7FFD548AB690
    public void OnCompleted(){} // RVA: 0x7FFD548AB6F0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548AB780
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD548AB7D0
}

public class AsyncUploadTimeSlicedUpdate : ValueType
{
}

public class AsyncWriter : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void YieldAsync(){} // RVA: 0x7FFD4E2ADC40
    public void SignalWriter(){} // RVA: 0x7FFD4E090980
}

public class AttachExternalCancellationSource`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void RunTask(){} // RVA: 0x7FFD4E2ADC40
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class AttributeInfo : Object
{
    public object Usage;
    public object InheritanceLevel;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FCAC310
    public void get_Usage(){} // RVA: 0x7FFD4E35C380
    public void get_InheritanceLevel(){} // RVA: 0x7FFD4E577800
}

public class AudioConfigurationChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F4DEC20
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class AudioFixedUpdate : ValueType
{
}

public class AutoDolly : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC53600
}

public class AutoScope : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C6F2D0
    public void Dispose(){} // RVA: 0x7FFD4E510DB0
}

public class AvailableDevice : ValueType
{
}

public class AvatarCullingMonitor : Object
{
    public object AvatarScreenSizeAboveTriggerThreshold;
    public object AvatarKindValidForExecution;
    public object AvatarCullableShouldRun;

    // ── Methods ──
    public void get_AvatarCullableShouldRun(){} // RVA: 0x7FFD4EF76C40
    public void set_AvatarCullableShouldRun(){} // RVA: 0x7FFD4EF76CB0
    public void set_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFD4EF76CE0
    public void op_Implicit(){} // RVA: 0x7FFD4EF76DE0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EF76EE0
    public void .ctor(){} // RVA: 0x7FFD4EF76FE0
    public void get_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFD4EF76FF0
    public void get_AvatarKindValidForExecution(){} // RVA: 0x7FFD4EF77000
    public void set_AvatarKindValidForExecution(){} // RVA: 0x7FFD4EF77070
    public void Instantiate(){} // RVA: 0x7FFD4EF770D0
    public void Equals(){} // RVA: 0x7FFD4EF771D0
    public void Dispose(){} // RVA: 0x7FFD4EF772D0
    public void Cleanup(){} // RVA: 0x7FFD4EF77350
    public void GetHashCode(){} // RVA: 0x7FFD4EF774D0
    public void ToString(){} // RVA: 0x7FFD4EF775B0
    public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7FFD4EF77610
    public void RefreshAvatarCullingState(){} // RVA: 0x7FFD4EF77710
}

public class AvatarOscConfig : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFDF1A0 | overloaded x2
    public void GetByName(){} // RVA: 0x7FFD4EFDF080
}

public class Avx : Object
{
    // ── Methods ──
    public void mm256_load_ps(){} // RVA: 0x7FFD4FFDB8D0
    public void mm256_store_ps(){} // RVA: 0x7FFD5492D0C0
    public void mm256_loadu_si256(){} // RVA: 0x7FFD4FFDB8D0
    public void mm256_storeu_si256(){} // RVA: 0x7FFD5492D0C0
    public void mm256_set1_epi32(){} // RVA: 0x7FFD5492D0D0
}

public class Avx2 : Object
{
    public object IsAvx2Supported;

    // ── Methods ──
    public void get_IsAvx2Supported(){} // RVA: 0x7FFD4E341320
    public void mm256_xor_si256(){} // RVA: 0x7FFD5492D0F0
    public void mm256_add_epi64(){} // RVA: 0x7FFD5492D150
    public void mm256_mul_epu32(){} // RVA: 0x7FFD5492D1C0
    public void mm256_slli_epi64(){} // RVA: 0x7FFD5492D230
    public void mm256_srli_epi64(){} // RVA: 0x7FFD5492D360
    public void mm256_shuffle_epi32(){} // RVA: 0x7FFD5492D4C0
}

public class Awaiter : ValueType
{
    public object IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void OnCompleted(){} // RVA: 0x7FFD4E090A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
    public void SourceOnCompleted(){} // RVA: 0x7FFD4E099B30
}

public class AwakeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class AwakeMonitor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
}

public class AxisInputDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC635C0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4F454000
}
