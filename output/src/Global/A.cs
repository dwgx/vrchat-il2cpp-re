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
    public UnityEngine.InputSystem.InputActionState action; // 0x10
    public UnityEngine.InputSystem.LowLevel.ActionEvent* phase; // 0x18

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
    public System.Action`1<T> callBack;

    // ── Methods ──
    public void get_callBack(){} // RVA: 0x7FFD4E078E90
    public void OnRuleMatchedElement(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ActionSettings : ValueType
{
    public 0x6658B940 m_Action; // 0x10
    public UnityEngine.Object m_Target; // 0x18
    public int m_BoostAmount; // 0x20
    public float m_StartTime; // 0x24
    public 0x6658B9F0 m_Mode; // 0x28
    public TriggerEvent m_Event; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC738D0
    public void Invoke(){} // RVA: 0x7FFD4FC73A40
}

public class Action`1 : Action
{
    public Event`1<Valve.VR.TrackedDevicePose_t[]> _event; // 0x10
    public UnityEngine.Events.UnityAction`1<Valve.VR.TrackedDevicePose_t[]> action; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Enable(){} // RVA: 0x7FFD4E091060
}

public class Action`2 : Action
{
    public Event`2<int,bool> _event; // 0x10
    public UnityEngine.Events.UnityAction`2<int,bool> action; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Enable(){} // RVA: 0x7FFD4E091060
}

public class Action`3 : Action
{
    public Event`3<U,V,T> _event;
    public UnityEngine.Events.UnityAction`3<U,V,T> action;

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
    public UIntPtr Handle; // 0x10

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
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,string>> _items; // 0x10
    public System.Text.StringBuilder _stringBuilder; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetEnumerator(){} // RVA: 0x7FFD5376AE70
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5376AF40
    public void ToString(){} // RVA: 0x7FFD5376B010
}

public class ActivityLogScope : Object
{
    public string Count; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,object>[] Item; // 0x18
    public int <Count>k__BackingField; // 0x20

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
    public System.DateTime DateStart; // 0x10
    public System.DateTime DateEnd; // 0x18
    public System.TimeSpan DaylightDelta; // 0x20
    public TransitionTime DaylightTransitionStart; // 0x28
    public TransitionTime DaylightTransitionEnd; // 0x40
    public System.TimeSpan BaseUtcOffsetDelta; // 0x58
    public bool NoDaylightTransitions; // 0x60

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
    public ushort TableEntry; // 0x10
    public ushort Value; // 0x12

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
    public <AsBytes>e__FixedBuffer AsBytes; // 0x10

    // ── Methods ──
    public void PopulateAllowedCodePoints(){} // RVA: 0x7FFD53EA5D40
}

public class AlphaButtonClickMask : MonoBehaviour
{
    public UnityEngine.UI.Image _image; // 0x20

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
    public UnityEngine.Transform friendIcon; // 0x10
    public UnityEngine.Transform friendCapsule; // 0x18
    public UnityEngine.Transform friendStats; // 0x20
}

public class AnimatedButton : Object
{
    public ÏÎÎÍÎÏÍÏÍÌÏÍÎÌÌÏÏÎÍÏÍÌÍ Button; // 0x10
    public float InAnimationDuration; // 0x18
    public float OutAnimationDuration; // 0x1C
    public float ScaleAnimationDuration; // 0x20
    public UnityEngine.RectTransform OutPosition; // 0x28
    public UnityEngine.RectTransform InPosition; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class AnimationDataSet`2 : ValueType
{
    public UnityEngine.UIElements.VisualElement[] capacity;
    public 0x66489770[] properties;
    public U[] timing;
    public T[] style;
    public int count;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,int> indices;

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
    public System.Action`1<T> action;

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
    public string title; // 0x68
    public string body; // 0x70
    public string imageUrl; // 0x78

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
    public string RawJson; // 0x10
    public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> RequestParams; // 0x18
    public 0x66409B80 FormData; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5727FFC0 | overloaded x3
    public void op_Implicit(){} // RVA: 0x7FFD57280130 | overloaded x3
}

public class ApiVRChatProductStore : ApiModel
{
    public string planId; // 0x68

    // ── Methods ──
    public void get_planId(){} // RVA: 0x7FFD4E3BCD50
    public void set_planId(){} // RVA: 0x7FFD4E3BCD60
    public void .ctor(){} // RVA: 0x7FFD57311270
}

public class Appearance : Object
{
    public UnityEngine.Color pathColor; // 0x10
    public UnityEngine.Color inactivePathColor; // 0x20
    public float width; // 0x30

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
    public T f0;
    public T f1;
    public T f2;
    public T f3;
    public T f4;
    public T f5;
    public T f6;
    public T f7;
    public T f8;
    public T f9;
    public T f10;
    public T f11;
    public T f12;
    public T f13;
    public T f14;
    public T f15;
}

public class Array256`1 : ValueType
{
    public Array16`1<T> f0;
    public Array16`1<T> f1;
    public Array16`1<T> f2;
    public Array16`1<T> f3;
    public Array16`1<T> f4;
    public Array16`1<T> f5;
    public Array16`1<T> f6;
    public Array16`1<T> f7;
    public Array16`1<T> f8;
    public Array16`1<T> f9;
    public Array16`1<T> f10;
    public Array16`1<T> f11;
    public Array16`1<T> f12;
    public Array16`1<T> f13;
    public Array16`1<T> f14;
    public Array16`1<T> f15;
}

public class Array32768`1 : ValueType
{
    public Array4096`1<T> Length;
    public Array4096`1<T> f1;
    public Array4096`1<T> f2;
    public Array4096`1<T> f3;
    public Array4096`1<T> f4;
    public Array4096`1<T> f5;
    public Array4096`1<T> f6;
    public Array4096`1<T> f7;

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFD4E079960
    public void ElementAt(){} // RVA: 0x7FFD4E087DE0
}

public class Array4096`1 : ValueType
{
    public Array256`1<T> f0;
    public Array256`1<T> f1;
    public Array256`1<T> f2;
    public Array256`1<T> f3;
    public Array256`1<T> f4;
    public Array256`1<T> f5;
    public Array256`1<T> f6;
    public Array256`1<T> f7;
    public Array256`1<T> f8;
    public Array256`1<T> f9;
    public Array256`1<T> f10;
    public Array256`1<T> f11;
    public Array256`1<T> f12;
    public Array256`1<T> f13;
    public Array256`1<T> f14;
    public Array256`1<T> f15;
}

public class ArrayEnumerator : Object
{
    public System.Array Current; // 0x10
    public int _index; // 0x18
    public int _endIndex; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A864A0
    public void MoveNext(){} // RVA: 0x7FFD53A86520
    public void Reset(){} // RVA: 0x7FFD4FC0DC40
    public void Clone(){} // RVA: 0x7FFD53932B10
    public void get_Current(){} // RVA: 0x7FFD53A86540
}

public class ArrayPoolImpl`1 : Object
{
    public object ObjectType; // 0x10
    public System.Collections.Generic.Dictionary`2<int,SizeGroup<int>> CountInactive; // 0x18
    public ArrayPoolImpl`1<int> Instance;

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
    public <Data>e__FixedBuffer Data; // 0x10

    // ── Methods ──
    public void PopulatePreescapedData(){} // RVA: 0x7FFD543ED960
    public void TryGetPreescapedData(){} // RVA: 0x7FFD53EA60A0
}

public class AspectStretcher : ValueType
{
    public float Aspect; // 0x10
    public float m_InverseAspect; // 0x14
    public float m_CenterX; // 0x18

    // ── Methods ──
    public void get_Aspect(){} // RVA: 0x7FFD4FC6C150
    public void .ctor(){} // RVA: 0x7FFD4FC6C160
    public void Stretch(){} // RVA: 0x7FFD4FC6C180
    public void Unstretch(){} // RVA: 0x7FFD4FC6C1B0
}

public class AssetBundleRequestAwaiter : ValueType
{
    public UnityEngine.AssetBundleRequest IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F2140
    public void OnCompleted(){} // RVA: 0x7FFD548F3490
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F34A0
}

public class AssetPreloader : Object
{
    public 0x66594B00 _name; // 0x10
    public System.Collections.Generic.List`1<string> _hideFlags; // 0x18
    public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiWorld> f_4F2; // 0x20
    public bool <ÏÏÎÎÎÎÍÎÎÌÏÎÌÍÍÌÏÏÌÍÍÎÏ>k__BackingField; // 0x28
    public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> <ÏÌÎÌÍÎÍÏÎÌÏÍÍÎÏÍÍÍÌÍÍÌÌ>k__BackingField; // 0x30
    public System.Collections.Generic.List`1<VRC.Core.ApiWorld> ÍÍÏÌÍÌÍÎÏÎÏÏÏÌÏÎÏÍÎÏÍÎÎ; // 0x38
    public string ÎÍÏÎÌÏÎÎÌÏÌÎÏÌÌÍÎÏÌÏÌÏÍ;
    public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.IReadOnlyList`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ>> <ÌÍÍÍÌÍÏÍÎÌÏÍÏÎÌÏÏÎÎÍÌÍÌ>k__BackingField; // 0x40
    public System.Collections.Generic.List`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ> ÎÌÌÎÍÎÍÏÌÌÎÎÎÏÍÍÌÏÌÍÎÍÏ; // 0x48
    public System.Collections.Generic.HashSet`1<string> ÍÏÏÍÏÏÏÌÏÍÏÏÌÌÌÌÎÏÎÌÏÎÌ; // 0x50
    public System.Collections.Generic.Dictionary`2<string,System.Threading.CancellationTokenSource> ÍÏÍÌÍÏÌÏÌÌÏÌÎÌÏÏÎÍÌÌÎÎÏ; // 0x58
    public int ÏÎÌÏÌÍÏÏÍÏÎÍÎÎÏÎÌÌÌÏÍÎÏ;

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
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncInstantiateOperationConfiguredSource`1<T>> NextNode;
    public AsyncInstantiateOperationConfiguredSource`1<T> nextNode;
    public UnityEngine.AsyncInstantiateOperation`1<T> asyncOperation;
    public System.IProgress`1<float> progress;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public bool completed;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T[]> core;
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction;

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
    public UnityEngine.AsyncOperation IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F0E30
    public void OnCompleted(){} // RVA: 0x7FFD548F0F80
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F0F90
}

public class AsyncTriggerEnumerator : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase`1<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public System.Threading.CancellationToken Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;
    public System.Threading.CancellationTokenRegistration registration;
    public bool called;
    public bool isDisposed;
    public T <Current>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

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
    public Cysharp.Threading.Tasks.IUniTaskSource source; // 0x10

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
    public _Create<T> enumerator;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core;

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
    public System.Action`1<object> cancellationCallbackDelegate;
    public System.Threading.CancellationToken cancellationToken; // 0x10
    public System.Threading.CancellationTokenRegistration tokenRegistration; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<int> core; // 0x30

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
    public System.AttributeUsageAttribute Usage; // 0x10
    public int InheritanceLevel; // 0x18

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
    public bool m_Enabled; // 0x10
    public float m_PositionOffset; // 0x14
    public int m_SearchRadius; // 0x18
    public int m_SearchResolution; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC53600
}

public class AutoScope : ValueType
{
    public UIntPtr m_Ptr; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C6F2D0
    public void Dispose(){} // RVA: 0x7FFD4E510DB0
}

public class AvailableDevice : ValueType
{
    public UnityEngine.InputSystem.Layouts.InputDeviceDescription description; // 0x10
    public int deviceId; // 0x48
    public bool isNative; // 0x4C
    public bool isRemoved; // 0x4D
}

public class AvatarCullingMonitor : Object
{
    public float AvatarScreenSizeAboveTriggerThreshold; // 0x10
    public float AvatarKindValidForExecution; // 0x14
    public 0x66362030[] AvatarCullableShouldRun; // 0x18
    public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ _owningPlayer; // 0x20
    public bool _hasOwningPlayer; // 0x28
    public bool _isBoundToAvatarKind; // 0x29
    public System.Nullable`1<bool> _hasValidAvatarKind; // 0x2A
    public bool _isBoundToAvatarScreenSize; // 0x2C
    public bool _aboveTriggerThreshold; // 0x2D
    public System.Action _cullingChangedCallback; // 0x30

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
    public string id; // 0x10
    public string name; // 0x18
    public int hash; // 0x20
    public System.Collections.Generic.List`1<ParameterConfig> parameters; // 0x28
    public System.Collections.Generic.HashSet`1<N> _supportedTypes; // 0x30

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
    public Cysharp.Threading.Tasks.UniTask`1<System.Collections.Generic.IList`1<ÌÏÌÏÏÏÎÌÍÌÍÍÌÌÌÍÌÌÌÎÍÍÍ>> IsCompleted; // 0x10

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
    public Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase`1<T> trigger;

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
