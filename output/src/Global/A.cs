// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 344

public class AABB : ValueType
{
    public Unity.Mathematics.float3 pos0; // 0x10
    public Unity.Mathematics.float3 pos1; // 0x1C

    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFAC9DFE750
}

public class AIUpdate : ValueType
{
}

public class AIUpdatePostScript : ValueType
{
}

public class AOTEmittedFormatter`1 : EasyBaseFormatter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class ARCoreUpdate : ValueType
{
}

public class ASCIIEncodingSealed : ASCIIEncoding
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83CF110
}

public class ATypeName : Object
{
    public object DisplayName;

    // ── Methods ──
    public void get_DisplayName(){} // RVA: 0x7FFAC2C58E90
    public void Equals(){} // RVA: 0x7FFAC86AC9F0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC86AC9B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Action : Object
{
    public object enabled;

    // ── Methods ──
    public void Enable(){} // RVA: 0x7FFAC2C71060
    public void set_enabled(){} // RVA: 0x7FFAC8443A50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ActionEvent : UnityEvent`1
{
    public string actionId; // 0x30
    public string actionName; // 0x38

    // ── Methods ──
    public void get_actionId(){} // RVA: 0x7FFAC31D95E0
    public void get_actionName(){} // RVA: 0x7FFAC31D0140
    public void .ctor(){} // RVA: 0x7FFAC962F3F0 | overloaded x3
}

public class ActionEventPtr : ValueType
{
    public UnityEngine.InputSystem.InputActionState action; // 0x10
    public UnityEngine.InputSystem.LowLevel.ActionEvent* phase; // 0x18

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFAC9562A60
    public void get_phase(){} // RVA: 0x7FFAC9562A90
    public void get_control(){} // RVA: 0x7FFAC9562AA0
    public void get_interaction(){} // RVA: 0x7FFAC9562AE0
    public void get_time(){} // RVA: 0x7FFAC9562B30
    public void get_startTime(){} // RVA: 0x7FFAC9562B90
    public void get_duration(){} // RVA: 0x7FFAC9562BA0
    public void get_valueSizeInBytes(){} // RVA: 0x7FFAC9562C10
    public void ReadValueAsObject(){} // RVA: 0x7FFAC9562C20
    public void ReadValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void ToString(){} // RVA: 0x7FFAC9562F70
}

public class ActionHintInfo : Object
{
    public string componentName; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> renderers; // 0x18
    public UnityEngine.Transform localTransform; // 0x20
    public UnityEngine.GameObject textHintObject; // 0x28
    public UnityEngine.Transform textStartAnchor; // 0x30
    public UnityEngine.Transform textEndAnchor; // 0x38
    public UnityEngine.Vector3 textEndOffsetDir; // 0x40
    public UnityEngine.Transform canvasOffset; // 0x50
    public UnityEngine.UI.Text text; // 0x58
    public UnityEngine.TextMesh textMesh; // 0x60
    public UnityEngine.Canvas textCanvas; // 0x68
    public UnityEngine.LineRenderer line; // 0x70
    public float distanceFromCenter; // 0x78
    public bool textHintActive; // 0x7C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ActionMapIndices : ValueType
{
    public int actionStartIndex; // 0x10
    public int actionCount; // 0x14
    public int controlStartIndex; // 0x18
    public int controlCount; // 0x1C
    public int bindingStartIndex; // 0x20
    public int bindingCount; // 0x24
    public int interactionStartIndex; // 0x28
    public int interactionCount; // 0x2C
    public int processorStartIndex; // 0x30
    public int processorCount; // 0x34
    public int compositeStartIndex; // 0x38
    public int compositeCount; // 0x3C
}

public class ActionNoArgs : Action
{
    public Event _event; // 0x10
    public UnityEngine.Events.UnityAction action; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void Enable(){} // RVA: 0x7FFAC8C9CB50
}

public class ActionQueryMatcher : UQueryMatcher
{
    public System.Action`1<T> callBack;

    // ── Methods ──
    public void get_callBack(){} // RVA: 0x7FFAC2C58E90
    public void OnRuleMatchedElement(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class ActionSettings : ValueType
{
    public 0x6B22B940 m_Action; // 0x10
    public UnityEngine.Object m_Target; // 0x18
    public int m_BoostAmount; // 0x20
    public float m_StartTime; // 0x24
    public 0x6B22B9F0 m_Mode; // 0x28
    public TriggerEvent m_Event; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC48538D0
    public void Invoke(){} // RVA: 0x7FFAC4853A40
}

public class Action`1 : Action
{
    public Event`1<T> _event;
    public UnityEngine.Events.UnityAction`1<T> action;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Enable(){} // RVA: 0x7FFAC2C71060
}

public class Action`2 : Action
{
    public Event`2<U,T> _event;
    public UnityEngine.Events.UnityAction`2<U,T> action;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Enable(){} // RVA: 0x7FFAC2C71060
}

public class Action`3 : Action
{
    public Event`3<U,V,T> _event;
    public UnityEngine.Events.UnityAction`3<U,V,T> action;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Enable(){} // RVA: 0x7FFAC2C71060
}

public class Action`4 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class Action`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
    public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
}

public class ActivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC072800
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFACC0728D0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ActivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC0724A0
    public void Invoke(){} // RVA: 0x7FFACC072620
    public void BeginInvoke(){} // RVA: 0x7FFACC072640
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ActiveChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6058800
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8C791E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Activity : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC4975A90
    public void Drop(){} // RVA: 0x7FFAC4975B10
    public void SetState(){} // RVA: 0x7FFAC4975B90
    public void Assets(){} // RVA: 0x7FFAC4975C20
    public void SetAssets(){} // RVA: 0x7FFAC4975CB0
    public void Timestamps(){} // RVA: 0x7FFAC4975D40
    public void SetTimestamps(){} // RVA: 0x7FFAC4975DD0
    public void Party(){} // RVA: 0x7FFAC4975E60
    public void SetParty(){} // RVA: 0x7FFAC4975EF0
    public void Secrets(){} // RVA: 0x7FFAC4975F80
    public void SetSecrets(){} // RVA: 0x7FFAC4976010
}

public class ActivityAssets : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC4975160
    public void Drop(){} // RVA: 0x7FFAC49751E0
    public void SetLargeImage(){} // RVA: 0x7FFAC4975260
    public void SetLargeText(){} // RVA: 0x7FFAC49752F0
    public void SetSmallImage(){} // RVA: 0x7FFAC4975380
    public void SetSmallText(){} // RVA: 0x7FFAC4975410
}

public class ActivityBaggageLogScopeWrapper : Object
{
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,string>> _items; // 0x10
    public System.Text.StringBuilder _stringBuilder; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void GetEnumerator(){} // RVA: 0x7FFAC834AE70
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC834AF40
    public void ToString(){} // RVA: 0x7FFAC834B010
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class ActivityLogScope : Object
{
    public string Count; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,object>[] Item; // 0x18
    public int <Count>k__BackingField; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC834A210
    public void get_Count(){} // RVA: 0x7FFAC30DBBE0
    public void get_Item(){} // RVA: 0x7FFAC834A950
    public void ToString(){} // RVA: 0x7FFAC834A9E0
    public void GetEnumerator(){} // RVA: 0x7FFAC834AC70
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC834AC70
}

public class ActivityParty : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC4975630
    public void Drop(){} // RVA: 0x7FFAC49756B0
    public void SetId(){} // RVA: 0x7FFAC4975730
    public void SetCurrentSize(){} // RVA: 0x7FFAC49757D0
    public void SetMaxSize(){} // RVA: 0x7FFAC4975860
}

public class ActivitySecrets : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC49758F0
    public void Drop(){} // RVA: 0x7FFAC4975970
    public void SetJoin(){} // RVA: 0x7FFAC49759F0
}

public class ActivityTimestamps : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC49754A0
    public void Drop(){} // RVA: 0x7FFAC4975520
    public void SetStart(){} // RVA: 0x7FFAC49755A0
}

public class AddDouble : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA2010
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddEventAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45B91D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class AddInt16 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA16E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddInt32 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1830
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddInt64 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1970
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfInt16 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA25B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfInt32 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA27D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfInt64 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA2970
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfUInt16 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA2B60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfUInt32 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA2D30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddOvfUInt64 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA2F00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddSingle : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1EB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddUInt16 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1AC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddUInt32 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1C10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AddUInt64 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA1D60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
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
    public void get_DateStart(){} // RVA: 0x7FFAC2F3C380
    public void get_DateEnd(){} // RVA: 0x7FFAC2F247C0
    public void get_DaylightDelta(){} // RVA: 0x7FFAC2F4F0C0
    public void get_DaylightTransitionStart(){} // RVA: 0x7FFAC4B71360
    public void get_DaylightTransitionEnd(){} // RVA: 0x7FFAC2F2AE10
    public void get_BaseUtcOffsetDelta(){} // RVA: 0x7FFAC2FE9500
    public void get_NoDaylightTransitions(){} // RVA: 0x7FFAC2F4A020
    public void get_HasDaylightSaving(){} // RVA: 0x7FFAC85032A0
    public void Equals(){} // RVA: 0x7FFAC8503480
    public void GetHashCode(){} // RVA: 0x7FFAC85035F0
    public void .ctor(){} // RVA: 0x7FFAC8504A30 | overloaded x3
    public void CreateAdjustmentRule(){} // RVA: 0x7FFAC8503790
    public void IsStartDateMarkerForBeginningOfYear(){} // RVA: 0x7FFAC85038D0
    public void IsEndDateMarkerForEndOfYear(){} // RVA: 0x7FFAC8503A20
    public void ValidateAdjustmentRule(){} // RVA: 0x7FFAC8503B70
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC85042E0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC85043C0
}

public class AdvancedPerspectiveSettings : Object
{
    public bool perspectiveColorEnabled; // 0x10
    public bool enablePerspectiveGeometry; // 0x11
    public float colorWeightContribution; // 0x14
    public bool overrideRadialBias; // 0x18
    public float depthBiasCompensation; // 0x1C
    public bool overrideWeightUnknown; // 0x20
    public float weightUnknown; // 0x24

    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFAC9E72130
}

public class AdvancedSettings : Object
{
    public float groundCheckDistance; // 0x10
    public float stickToGroundHelperDistance; // 0x14
    public float slowDownRate; // 0x18
    public bool airControl; // 0x1C
    public float shellOffset; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F57E00
}

public class AdvancedSetttings : Object
{
    public float engineMinDistance; // 0x10
    public float engineMaxDistance; // 0x14
    public float engineDopplerLevel; // 0x18
    public float engineMasterVolume; // 0x1C
    public float windMinDistance; // 0x20
    public float windMaxDistance; // 0x24
    public float windDopplerLevel; // 0x28
    public float windMasterVolume; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F49FA0
}

public class Advapi32 : Object
{
    // ── Methods ──
    public void RegCloseKey(){} // RVA: 0x7FFAC838AB80
    public void RegEnumKeyEx(){} // RVA: 0x7FFAC838AC00
    public void RegEnumValue(){} // RVA: 0x7FFAC838ADF0
    public void RegOpenKeyEx(){} // RVA: 0x7FFAC838AF50
    public void RegQueryInfoKey(){} // RVA: 0x7FFAC838B120
    public void RegQueryValueEx(){} // RVA: 0x7FFAC838B770 | overloaded x4
}

public class AlgorithmIdentifier : ValueType
{
    public string AlgorithmId; // 0x10
    public byte[] Parameters; // 0x18
}

public class AlignOfHelper`1 : ValueType
{
    public byte dummy;
    public T data;
}

public class Alloc2D : ValueType
{
    public UnityEngine.RectInt rect; // 0x10
    public Row row; // 0x20
    public UnityEngine.UIElements.UIR.Alloc alloc; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9ACD390
}

public class AllocMeshData : ValueType
{
    public Allocator alloc; // 0x10
    public UnityEngine.Texture texture; // 0x18
    public UnityEngine.UIElements.TextureId svgTexture; // 0x20
    public UnityEngine.Material material; // 0x28
    public 0x6B120AD8 flags; // 0x30
    public UnityEngine.UIElements.UIR.BMPAlloc colorAlloc; // 0x34

    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFAC9ADE450
}

public class AllocToFree : ValueType
{
    public UnityEngine.UIElements.UIR.Alloc alloc; // 0x10
    public UnityEngine.UIElements.UIR.Page page; // 0x28
    public bool vertices; // 0x30
}

public class AllocToUpdate : ValueType
{
    public uint id; // 0x10
    public uint allocTime; // 0x14
    public UnityEngine.UIElements.UIR.MeshHandle meshHandle; // 0x18
    public UnityEngine.UIElements.UIR.Alloc permAllocVerts; // 0x20
    public UnityEngine.UIElements.UIR.Alloc permAllocIndices; // 0x38
    public UnityEngine.UIElements.UIR.Page permPage; // 0x50
    public bool copyBackIndices; // 0x58
}

public class Allocator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89702F0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class AllocatorHandle : ValueType
{
    public ushort TableEntry; // 0x10
    public ushort Value; // 0x12

    // ── Methods ──
    public void get_TableEntry(){} // RVA: 0x7FFAC950F030
    public void Rewind(){} // RVA: 0x7FFAC2F21310
    public void op_Implicit(){} // RVA: 0x7FFAC950F100
    public void get_Value(){} // RVA: 0x7FFAC4AC85D0
    public void Try(){} // RVA: 0x7FFAC950F120
    public void get_Handle(){} // RVA: 0x7FFAC4420210
    public void get_ToAllocator(){} // RVA: 0x7FFAC950F180
    public void get_IsAutoDispose(){} // RVA: 0x7FFAC950F190
    public void Dispose(){} // RVA: 0x7FFAC950F260
    public void Equals(){} // RVA: 0x7FFAC850EF20 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC4AC85D0
    public void CompareTo(){} // RVA: 0x7FFAC850F000
}

public class AllowedAsciiCodePoints : ValueType
{
    public <AsBytes>e__FixedBuffer AsBytes; // 0x10

    // ── Methods ──
    public void PopulateAllowedCodePoints(){} // RVA: 0x7FFAC8A85D40
}

public class AlphaButtonClickMask : MonoBehaviour
{
    public UnityEngine.UI.Image _image; // 0x20

    // ── Methods ──
    public void Start(){} // RVA: 0x7FFAC2F21330
    public void IsRaycastLocationValid(){} // RVA: 0x7FFAC2F21780
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
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

public class AndBoolean : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA4050
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndByte : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3B10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndInt16 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3760
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndInt32 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3870
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndInt64 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3980
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndNode : ValueType
{
    public int Depth; // 0x10
    public System.Linq.Expressions.Expression Node; // 0x18
}

public class AndSByte : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3650
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndUInt16 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3C20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndUInt32 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3D30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AndUInt64 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DA3EC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
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
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AnimationDataSet`2 : ValueType
{
    public UnityEngine.UIElements.VisualElement[] capacity;
    public 0x6B129770[] properties;
    public U[] timing;
    public T[] style;
    public int count;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,int> indices;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x7FFAC2C59960
    public void set_capacity(){} // RVA: 0x7FFAC2C70ED0
    public void LocalInit(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void IndexOf(){}
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void Remove(){} // RVA: 0x7FFAC2C70ED0
    public void Replace(){} // RVA: 0x7FFAC2E8DC40
    public void RemoveAll(){} // RVA: 0x7FFAC2C70980 | overloaded x2
    public void GetActivePropertiesForElement(){} // RVA: 0x7FFAC2C79B30
}

public class AnimationPlayableAssetUpgrade : Object
{
    // ── Methods ──
    public void ConvertRotationToEuler(){} // RVA: 0x7FFAC97AEE20
}

public class AnimationTrackUpgrade : Object
{
    // ── Methods ──
    public void ConvertRotationsToEuler(){} // RVA: 0x7FFAC97B4C00
    public void ConvertRootMotion(){} // RVA: 0x7FFAC97B4C70
    public void ConvertInfiniteTrack(){} // RVA: 0x7FFAC97B4D30
}

public class AnimatorEvent : Object
{
    public string animationState; // 0x10
    public float crossfadeTime; // 0x18
    public int layer; // 0x1C
    public bool resetNormalizedTime; // 0x20
    public string empty;

    // ── Methods ──
    public void Activate(){} // RVA: 0x7FFAC2F80630 | overloaded x3
    public void .ctor(){} // RVA: 0x7FFAC2F807B0
}

public class Annotation : Object
{
    public Google.Protobuf.MessageParser`1<Annotation> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public Google.Protobuf.FieldCodec`1<int> Path; // 0x8
    public Google.Protobuf.Collections.RepeatedField`1<int> SourceFile; // 0x20
    public string HasSourceFile; // 0x10
    public string Begin; // 0x28
    public int HasBegin; // 0x18
    public int End; // 0x30
    public int HasEnd; // 0x1C
    public int end_; // 0x34

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC8213520
    public void get_Descriptor(){} // RVA: 0x7FFAC8213580
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8213600
    public void .ctor(){} // RVA: 0x7FFAC8213770 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC8213980
    public void get_Path(){} // RVA: 0x7FFAC2F4F0C0
    public void get_SourceFile(){} // RVA: 0x7FFAC82139E0
    public void set_SourceFile(){} // RVA: 0x7FFAC8213A50
    public void get_HasSourceFile(){} // RVA: 0x7FFAC81FF390
    public void ClearSourceFile(){} // RVA: 0x7FFAC53F2F70
    public void get_Begin(){} // RVA: 0x7FFAC8213B50
    public void set_Begin(){} // RVA: 0x7FFAC8213BC0
    public void get_HasBegin(){} // RVA: 0x7FFAC81F3770
    public void ClearBegin(){} // RVA: 0x7FFAC81F3780
    public void get_End(){} // RVA: 0x7FFAC8213BD0
    public void set_End(){} // RVA: 0x7FFAC8213C40
    public void get_HasEnd(){} // RVA: 0x7FFAC81F3810
    public void ClearEnd(){} // RVA: 0x7FFAC81F3820
    public void Equals(){} // RVA: 0x7FFAC8213DF0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC8213F50
    public void ToString(){} // RVA: 0x7FFAC8214010
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8214060
    public void CalculateSize(){} // RVA: 0x7FFAC82141A0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8214490
    public void .cctor(){} // RVA: 0x7FFAC8214610
}

public class AnonymousProgress`1 : Object
{
    public System.Action`1<T> action;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Report(){} // RVA: 0x7FFAC2E8DC40
}

public class AnyKeyObj : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC8320EF0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AotTester : Object
{
    // ── Methods ──
    public void Test(){} // RVA: 0x7FFAC2F21310
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ApiBundleDropNotificationDetails : ApiModel
{
    public string title; // 0x68
    public string body; // 0x70
    public string imageUrl; // 0x78

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFAC2F9CD50
    public void set_title(){} // RVA: 0x7FFAC2F9CD60
    public void get_body(){} // RVA: 0x7FFAC2FE9590
    public void set_body(){} // RVA: 0x7FFAC2FE95A0
    public void get_imageUrl(){} // RVA: 0x7FFAC30E5600
    public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
    public void .ctor(){} // RVA: 0x7FFACBE7A030
}

public class ApiGalleryImageContainer : ApiModel
{
    public int totalCount; // 0x68
    public System.Collections.Generic.List`1<VRC.Core.ApiGroupGalleryImage> results; // 0x70

    // ── Methods ──
    public void get_totalCount(){} // RVA: 0x7FFAC47BAB50
    public void set_totalCount(){} // RVA: 0x7FFAC47BAB60
    public void get_results(){} // RVA: 0x7FFAC2FE9590
    public void set_results(){} // RVA: 0x7FFAC2FE95A0
    public void .ctor(){} // RVA: 0x7FFACBF1CF70
}

public class ApiPopupBuilderData : ApiModel
{
    public string key; // 0x68
    public VRC.Core.ApiLocalizableString title; // 0x70
    public float spacing; // 0x78
    public System.Collections.Generic.List`1<ContentBlock> content; // 0x80

    // ── Methods ──
    public void get_key(){} // RVA: 0x7FFAC2F9CD50
    public void set_key(){} // RVA: 0x7FFAC2F9CD60
    public void get_title(){} // RVA: 0x7FFAC2FE9590
    public void set_title(){} // RVA: 0x7FFAC2FE95A0
    public void get_spacing(){} // RVA: 0x7FFAC2F4A0E0
    public void set_spacing(){} // RVA: 0x7FFAC2F4A0F0
    public void get_content(){} // RVA: 0x7FFAC32EF410
    public void set_content(){} // RVA: 0x7FFAC34D4AA0
    public void .ctor(){} // RVA: 0x7FFACBE79810
}

public class ApiPopupBuilderRecipe : ApiModel
{
    public System.Collections.Generic.List`1<ApiPopupBuilderData> pages; // 0x68

    // ── Methods ──
    public void get_pages(){} // RVA: 0x7FFAC2F9CD50
    public void set_pages(){} // RVA: 0x7FFAC2F9CD60
    public void .ctor(){} // RVA: 0x7FFACBE797C0
}

public class ApiPromotionNotification : ApiModel
{
    public string title; // 0x68
    public string body; // 0x70
    public string imageUrl; // 0x78
    public string command; // 0x80
    public string parameter; // 0x88

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFAC2F9CD50
    public void set_title(){} // RVA: 0x7FFAC2F9CD60
    public void get_body(){} // RVA: 0x7FFAC2FE9590
    public void set_body(){} // RVA: 0x7FFAC2FE95A0
    public void get_imageUrl(){} // RVA: 0x7FFAC30E5600
    public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
    public void get_command(){} // RVA: 0x7FFAC32EF410
    public void set_command(){} // RVA: 0x7FFAC34D4AA0
    public void get_parameter(){} // RVA: 0x7FFAC2F60010
    public void set_parameter(){} // RVA: 0x7FFAC354E300
    public void .ctor(){} // RVA: 0x7FFACBE79770
}

public class ApiRequestData : ValueType
{
    public string RawJson; // 0x10
    public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> RequestParams; // 0x18
    public BestHTTP.Forms.HTTPFormBase FormData; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBE5FFC0 | overloaded x3
    public void op_Implicit(){} // RVA: 0x7FFACBE60130 | overloaded x3
}

public class ApiVRChatProductStore : ApiModel
{
    public string planId; // 0x68

    // ── Methods ──
    public void get_planId(){} // RVA: 0x7FFAC2F9CD50
    public void set_planId(){} // RVA: 0x7FFAC2F9CD60
    public void .ctor(){} // RVA: 0x7FFACBEF1270
}

public class AppPerfFrameStats : ValueType
{
    public int HmdVsyncIndex; // 0x10
    public int AppFrameIndex; // 0x14
    public int AppDroppedFrameCount; // 0x18
    public float AppMotionToPhotonLatency; // 0x1C
    public float AppQueueAheadTime; // 0x20
    public float AppCpuElapsedTime; // 0x24
    public float AppGpuElapsedTime; // 0x28
    public int CompositorFrameIndex; // 0x2C
    public int CompositorDroppedFrameCount; // 0x30
    public float CompositorLatency; // 0x34
    public float CompositorCpuElapsedTime; // 0x38
    public float CompositorGpuElapsedTime; // 0x3C
    public float CompositorCpuStartToGpuEndElapsedTime; // 0x40
    public float CompositorGpuEndToVsyncElapsedTime; // 0x44
}

public class AppPerfStats : ValueType
{
    public AppPerfFrameStats[] FrameStats; // 0x10
    public int FrameStatsCount; // 0x18
    public 0x6B1A5C08 AnyFrameStatsDropped; // 0x1C
    public float AdaptiveGpuPerformanceScale; // 0x20
}

public class Appearance : Object
{
    public UnityEngine.Color pathColor; // 0x10
    public UnityEngine.Color inactivePathColor; // 0x20
    public float width; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC48459F0
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Area : Object
{
    public UnityEngine.RectInt rect; // 0x10
    public UnityEngine.UIElements.UIR.BestFitAllocator allocator; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9ACCF80
}

public class AreaNode : Object
{
    public UnityEngine.UIElements.ObjectPool`1<AreaNode> s_Pool;
    public UnityEngine.RectInt rect; // 0x10
    public AreaNode previous; // 0x20
    public AreaNode next; // 0x28

    // ── Methods ──
    public void Acquire(){} // RVA: 0x7FFAC9BC70A0
    public void Release(){} // RVA: 0x7FFAC9BC7240
    public void RemoveFromChain(){} // RVA: 0x7FFAC9BC72D0
    public void AddAfter(){} // RVA: 0x7FFAC9BC7440
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9BC7630
}

public class ArgsBufferPrep : Object
{
    public string s_prepareArgsComputeName;
    public UnityEngine.ComputeShader s_prepareArgsCompute; // 0x8
    public int s_prepareDrawIndirectArgsKernelId; // 0x10
    public int s_prepareDispatchIndirectArgsKernelId; // 0x14

    // ── Methods ──
    public void Setup(){} // RVA: 0x7FFAC4964D00
    public void PrepareDispatchArgs(){} // RVA: 0x7FFAC49651C0
    public void PrepareDrawArgs(){} // RVA: 0x7FFAC49654F0
    public void .cctor(){} // RVA: 0x7FFAC49657E0
}

public class Arm : BodyPart
{
    public UnityEngine.Transform position; // 0x48
    public UnityEngine.Transform rotation; // 0x50
    public float shoulder; // 0x58
    public float upperArm; // 0x5C
    public 0x6B1C0750 forearm; // 0x60
    public bool hand; // 0x64
    public bool vrcAvoidElbowClipping; // 0x65
    public bool vrcIsForcedElbowDirection; // 0x66
    public UnityEngine.Vector3 vrcForcedElbowDirection; // 0x68
    public bool vrcElbowTracking; // 0x74
    public bool vrcShoulderTracking; // 0x75
    public bool vrcShoulderWidthCompensation; // 0x76
    public bool vrcInVRMode; // 0x77
    public float vrcShoulderWidthToArmRatio; // 0x78
    public float vrcShoulderHeightAboveChest; // 0x7C
    public System.Nullable`1<UnityEngine.Vector3> postSpineStretchRootPos; // 0x80
    public System.Nullable`1<UnityEngine.Quaternion> postSpineStretchRootRot; // 0x90
    public UnityEngine.Vector3 _vrcPoseElbowBendDir; // 0xA4
    public float oldBendGoalWeight; // 0xB0
    public UnityEngine.Quaternion _vrcPoseWristRot; // 0xB4
    public UnityEngine.Quaternion _finalHandRot; // 0xC4
    public UnityEngine.Quaternion LeftWristAlign; // 0xD4
    public UnityEngine.Quaternion RightWristAlign; // 0xE4
    public UnityEngine.Vector3 _vrcCharacterSpaceBendOffsetLeft; // 0xF4
    public UnityEngine.Vector3 _vrcCharacterSpaceBendOffsetRight; // 0x100
    public bool _vrcIsFrontSide; // 0x10C
    public float _vrcHandNearOppositeShoulder; // 0x110
    public UnityEngine.Transform shoulderTarget; // 0x118
    public float torsoAddScale;
    public float pushingFactor;
    public float crossFrontElbowForwardFactor;
    public float shiftChestForward;
    public int elbowClipIterations;
    public float shoulderRotationWeight; // 0x120
    public float shoulderTwistWeight; // 0x124
    public float bendGoalWeight; // 0x128
    public float swivelOffset; // 0x12C
    public UnityEngine.Vector3 wristToPalmAxis; // 0x130
    public UnityEngine.Vector3 palmToThumbAxis; // 0x13C
    public float armLengthMlp; // 0x148
    public UnityEngine.AnimationCurve stretchCurve; // 0x150
    public UnityEngine.Vector3 IKPosition; // 0x158
    public UnityEngine.Quaternion IKRotation; // 0x164
    public UnityEngine.Vector3 bendDirection; // 0x174
    public UnityEngine.Vector3 handPositionOffset; // 0x180
    public UnityEngine.Vector3 <position>k__BackingField; // 0x18C
    public UnityEngine.Quaternion <rotation>k__BackingField; // 0x198
    public bool hasShoulder; // 0x1A8
    public UnityEngine.Vector3 chestForwardAxis; // 0x1AC
    public UnityEngine.Vector3 chestUpAxis; // 0x1B8
    public UnityEngine.Quaternion chestRotation; // 0x1C4
    public UnityEngine.Vector3 chestForward; // 0x1D4
    public UnityEngine.Vector3 chestUp; // 0x1E0
    public UnityEngine.Quaternion forearmRelToUpperArm; // 0x1EC
    public UnityEngine.Vector3 upperArmBendAxis; // 0x1FC
    public float yawOffsetAngle;
    public float pitchOffsetAngle;

    // ── Methods ──
    public void get_position(){} // RVA: 0x7FFAC303F590
    public void set_position(){} // RVA: 0x7FFAC303F5B0
    public void get_rotation(){} // RVA: 0x7FFAC303F5D0
    public void set_rotation(){} // RVA: 0x7FFAC303F5E0
    public void get_shoulder(){} // RVA: 0x7FFAC303F5F0
    public void get_upperArm(){} // RVA: 0x7FFAC303F620
    public void get_forearm(){} // RVA: 0x7FFAC303F670
    public void get_hand(){} // RVA: 0x7FFAC303F6C0
    public void OnRead(){} // RVA: 0x7FFAC303F710
    public void PreSolve(){} // RVA: 0x7FFAC30409A0
    public void ApplyOffsets(){} // RVA: 0x7FFAC3040FF0
    public void Stretching(){} // RVA: 0x7FFAC3041050
    public void VrcGetZeroWeightElbowDir(){} // RVA: 0x7FFAC3041790
    public void VrcAdjustBendFromTargetRot(){} // RVA: 0x7FFAC30427E0
    public void VrcAvoidElbowClipping(){} // RVA: 0x7FFAC3043AA0
    public void Solve(){} // RVA: 0x7FFAC30456A0
    public void ResetOffsets(){} // RVA: 0x7FFAC3049280
    public void Write(){} // RVA: 0x7FFAC30492E0
    public void VrcSetPoseBend(){} // RVA: 0x7FFAC3049670
    public void VrcSetPoseWristRot(){} // RVA: 0x7FFAC3049690
    public void DamperValue(){} // RVA: 0x7FFAC30496A0
    public void GetBendNormal(){} // RVA: 0x7FFAC3049770
    public void Visualize(){} // RVA: 0x7FFAC304AC70
    public void .ctor(){} // RVA: 0x7FFAC304AF30
}

public class Array : ValueType
{
    // ── Methods ──
    public void IsCustom(){} // RVA: 0x7FFAC950EDC0
    public void CustomResize(){} // RVA: 0x7FFAC9511140
    public void Resize(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
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
