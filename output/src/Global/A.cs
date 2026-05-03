// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 345

public class AABB : ValueType
{
    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFE881AA0C0
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
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class ARCoreUpdate : ValueType
{
}

public class ASCIIEncodingSealed : ASCIIEncoding
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86778A10
}

public class ATypeName : Object
{
    // ── Methods ──
    public void get_DisplayName(){} // RVA: 0x7FFE80E2E2E0
    public void Equals(){} // RVA: 0x7FFE86A561A0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE86A56160
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Action : Object
{
    // ── Methods ──
    public void Enable(){} // RVA: 0x7FFE80E466C0
    public void set_enabled(){} // RVA: 0x7FFE867ED360
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ActionEvent : UnityEvent`1
{
    public string m_ActionId; // 0x30
    public string m_ActionName; // 0x38

    // ── Methods ──
    public void get_actionId(){} // RVA: 0x7FFE8144E200
    public void get_actionName(){} // RVA: 0x7FFE8143BA80
    public void .ctor(){} // RVA: 0x7FFE879D7B30 | overloaded x3
}

public class ActionEventPtr : ValueType
{
    public UnityEngine.InputSystem.InputActionState m_State; // 0x10
    public UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr; // 0x18
    public object field_2; // 0x5E0
    public object field_3; // 0x5E1
    public object field_4; // 0x5E2
    public object field_5; // 0x5E3
    public object field_6; // 0x5E4
    public object field_7; // 0x5E5

    // ── Methods ──
    public void get_action(){} // RVA: 0x7FFE8790B1A0
    public void get_phase(){} // RVA: 0x7FFE8790B1D0
    public void get_control(){} // RVA: 0x7FFE8790B1E0
    public void get_interaction(){} // RVA: 0x7FFE8790B220
    public void get_time(){} // RVA: 0x7FFE8790B270
    public void get_startTime(){} // RVA: 0x7FFE8790B2D0
    public void get_duration(){} // RVA: 0x7FFE8790B2E0
    public void get_valueSizeInBytes(){} // RVA: 0x7FFE8790B350
    public void ReadValueAsObject(){} // RVA: 0x7FFE8790B360
    public void ReadValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void ToString(){} // RVA: 0x7FFE8790B6B0
}

public class ActionHintInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ActionMapIndices : ValueType
{
}

public class ActionNoArgs : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void Enable(){} // RVA: 0x7FFE87045040
}

public class ActionQueryMatcher : UQueryMatcher
{
    public System.Action`1<T> _callBack;

    // ── Methods ──
    public void get_callBack(){} // RVA: 0x7FFE80E2E2E0
    public void OnRuleMatchedElement(){}
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class ActionSettings : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82ABBC70
    public void Invoke(){} // RVA: 0x7FFE82ABBDE0
}

public class Action`1 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Enable(){} // RVA: 0x7FFE80E466C0
}

public class Action`2 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Enable(){} // RVA: 0x7FFE80E466C0
}

public class Action`3 : Action
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Enable(){} // RVA: 0x7FFE80E466C0
}

public class Action`4 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class Action`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
    public void BeginInvoke(){} // RVA: 0x7FFE810A1420
    public void EndInvoke(){} // RVA: 0x7FFE80E460A0
}

public class ActivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4D87D0
    public void Invoke(){} // RVA: 0x7FFE83F99C10
    public void BeginInvoke(){} // RVA: 0x7FFE8A4D88A0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ActivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4D8470
    public void Invoke(){} // RVA: 0x7FFE8A4D85F0
    public void BeginInvoke(){} // RVA: 0x7FFE8A4D8610
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ActiveChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE844218E0
    public void Invoke(){} // RVA: 0x7FFE812574E0
    public void BeginInvoke(){} // RVA: 0x7FFE870216D0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Activity : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE1590
    public void Drop(){} // RVA: 0x7FFE82BE1610
    public void SetState(){} // RVA: 0x7FFE82BE1690
    public void Assets(){} // RVA: 0x7FFE82BE1720
    public void SetAssets(){} // RVA: 0x7FFE82BE17B0
    public void Timestamps(){} // RVA: 0x7FFE82BE1840
    public void SetTimestamps(){} // RVA: 0x7FFE82BE18D0
    public void Party(){} // RVA: 0x7FFE82BE1960
    public void SetParty(){} // RVA: 0x7FFE82BE19F0
    public void Secrets(){} // RVA: 0x7FFE82BE1A80
    public void SetSecrets(){} // RVA: 0x7FFE82BE1B10
}

public class ActivityAssets : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE0C60
    public void Drop(){} // RVA: 0x7FFE82BE0CE0
    public void SetLargeImage(){} // RVA: 0x7FFE82BE0D60
    public void SetLargeText(){} // RVA: 0x7FFE82BE0DF0
    public void SetSmallImage(){} // RVA: 0x7FFE82BE0E80
    public void SetSmallText(){} // RVA: 0x7FFE82BE0F10
}

public class ActivityBaggageLogScopeWrapper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void GetEnumerator(){} // RVA: 0x7FFE866F4770
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE866F4840
    public void ToString(){} // RVA: 0x7FFE866F4910
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class ActivityLogScope : Object
{
    public string _cachedToString; // 0x10
    public System.Collections.Generic.KeyValuePair`2<string,object>[] _items; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866F3B10
    public void get_Count(){} // RVA: 0x7FFE8151D690
    public void get_Item(){} // RVA: 0x7FFE866F4250
    public void ToString(){} // RVA: 0x7FFE866F42E0
    public void GetEnumerator(){} // RVA: 0x7FFE866F4570
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE866F4570
}

public class ActivityParty : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE1130
    public void Drop(){} // RVA: 0x7FFE82BE11B0
    public void SetId(){} // RVA: 0x7FFE82BE1230
    public void SetCurrentSize(){} // RVA: 0x7FFE82BE12D0
    public void SetMaxSize(){} // RVA: 0x7FFE82BE1360
}

public class ActivitySecrets : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE13F0
    public void Drop(){} // RVA: 0x7FFE82BE1470
    public void SetJoin(){} // RVA: 0x7FFE82BE14F0
}

public class ActivityTimestamps : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE0FA0
    public void Drop(){} // RVA: 0x7FFE82BE1020
    public void SetStart(){} // RVA: 0x7FFE82BE10A0
}

public class AddDouble : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714A440
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddEventAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828867F0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class AddInt16 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87149B10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddInt32 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87149C60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddInt64 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87149DA0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfInt16 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714A9E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfInt32 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714AC00
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfInt64 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714ADA0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfUInt16 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714AF90
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfUInt32 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714B160
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddOvfUInt64 : AddOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714B330
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddSingle : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714A2E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddUInt16 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87149EF0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddUInt32 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714A040
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AddUInt64 : AddInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714A190
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AdjustmentRule : Object
{
    public System.DateTime _dateStart; // 0x10
    public System.DateTime _dateEnd; // 0x18
    public System.TimeSpan _daylightDelta; // 0x20
    public TransitionTime _daylightTransitionStart; // 0x28
    public TransitionTime _daylightTransitionEnd; // 0x40
    public System.TimeSpan _baseUtcOffsetDelta; // 0x58
    public bool _noDaylightTransitions; // 0x60
    public System.DateTime _timeOfDay; // 0x10

    // ── Methods ──
    public void get_DateStart(){} // RVA: 0x7FFE81116380
    public void get_DateEnd(){} // RVA: 0x7FFE810FE7C0
    public void get_DaylightDelta(){} // RVA: 0x7FFE811290C0
    public void get_DaylightTransitionStart(){} // RVA: 0x7FFE82DDC4A0
    public void get_DaylightTransitionEnd(){} // RVA: 0x7FFE81104E10
    public void get_BaseUtcOffsetDelta(){} // RVA: 0x7FFE811C3500
    public void get_NoDaylightTransitions(){} // RVA: 0x7FFE81124020
    public void get_HasDaylightSaving(){} // RVA: 0x7FFE868ACAA0
    public void Equals(){} // RVA: 0x7FFE868ACC80
    public void GetHashCode(){} // RVA: 0x7FFE868ACDF0
    public void .ctor(){} // RVA: 0x7FFE868AE230 | overloaded x3
    public void CreateAdjustmentRule(){} // RVA: 0x7FFE868ACF90
    public void IsStartDateMarkerForBeginningOfYear(){} // RVA: 0x7FFE868AD0D0
    public void IsEndDateMarkerForEndOfYear(){} // RVA: 0x7FFE868AD220
    public void ValidateAdjustmentRule(){} // RVA: 0x7FFE868AD370
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE868ADAE0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868ADBC0
}

public class AdvancedPerspectiveSettings : Object
{
    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFE88224AA0
}

public class AdvancedSettings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81131E00
}

public class AdvancedSetttings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81123FA0
}

public class Advapi32 : Object
{
    // ── Methods ──
    public void RegCloseKey(){} // RVA: 0x7FFE86734480
    public void RegEnumKeyEx(){} // RVA: 0x7FFE86734500
    public void RegEnumValue(){} // RVA: 0x7FFE867346F0
    public void RegOpenKeyEx(){} // RVA: 0x7FFE86734850
    public void RegQueryInfoKey(){} // RVA: 0x7FFE86734A20
    public void RegQueryValueEx(){} // RVA: 0x7FFE86735070 | overloaded x4
}

public class AlgorithmIdentifier : ValueType
{
}

public class AlignOfHelper`1 : ValueType
{
}

public class Alloc2D : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87E75C30
}

public class AllocMeshData : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFE87E86CF0
}

public class AllocToFree : ValueType
{
}

public class AllocToUpdate : ValueType
{
}

public class Allocator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D19980
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class AllocatorHandle : ValueType
{
    public ushort Index; // 0x10
    public ushort Version; // 0x12
    public object field_2; // 0x2F80
    public object field_3; // 0x5600
    public object field_4; // 0xC6A0

    // ── Methods ──
    public void get_TableEntry(){} // RVA: 0x7FFE878B7770
    public void Rewind(){} // RVA: 0x7FFE810FB310
    public void op_Implicit(){} // RVA: 0x7FFE878B7840
    public void get_Value(){} // RVA: 0x7FFE82D33010
    public void Try(){} // RVA: 0x7FFE878B7860
    public void get_Handle(){} // RVA: 0x7FFE826F4220
    public void get_ToAllocator(){} // RVA: 0x7FFE878B78C0
    public void get_IsAutoDispose(){} // RVA: 0x7FFE878B78D0
    public void Dispose(){} // RVA: 0x7FFE878B79A0
    public void Equals(){} // RVA: 0x7FFE868B8720 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE82D33010
    public void CompareTo(){} // RVA: 0x7FFE868B8800
}

public class AllowedAsciiCodePoints : ValueType
{
    // ── Methods ──
    public void PopulateAllowedCodePoints(){} // RVA: 0x7FFE86E2F3D0
}

public class AlphaButtonClickMask : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x7FFE810FB330
    public void IsRaycastLocationValid(){} // RVA: 0x7FFE810FB780
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class AnalyticsCoreStatsUpdate : ValueType
{
}

public class AnalyticsExperiment : ApiModel
{
    public string _key; // 0x68
    public string _variant; // 0x70

    // ── Methods ──
    public void get_key(){} // RVA: 0x7FFE81176D50
    public void set_key(){} // RVA: 0x7FFE81176D60
    public void get_variant(){} // RVA: 0x7FFE811C3590
    public void set_variant(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A2D8000
}

public class Anchors : ValueType
{
}

public class AndBoolean : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714C480
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndByte : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714BF40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndInt16 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714BB90
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndInt32 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714BCA0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndInt64 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714BDB0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndNode : ValueType
{
}

public class AndSByte : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714BA80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndUInt16 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714C050
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndUInt32 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714C160
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AndUInt64 : AndInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8714C2F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AnimatedButton : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AnimationBinding : ValueType
{
}

public class AnimationDataSet`2 : ValueType
{
    public UnityEngine.UIElements.VisualElement[] elements;

    // ── Methods ──
    public void get_capacity(){} // RVA: 0x7FFE80E2EDB0
    public void set_capacity(){} // RVA: 0x7FFE80E46530
    public void LocalInit(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void IndexOf(){}
    public void Add(){} // RVA: 0x7FFE810A1420
    public void Remove(){} // RVA: 0x7FFE80E46530
    public void Replace(){} // RVA: 0x7FFE810A1420
    public void RemoveAll(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
    public void GetActivePropertiesForElement(){} // RVA: 0x7FFE80E4F230
}

public class AnimationPlayableAssetUpgrade : Object
{
    // ── Methods ──
    public void ConvertRotationToEuler(){} // RVA: 0x7FFE87B573A0
}

public class AnimationProperties : ValueType
{
}

public class AnimationTrackUpgrade : Object
{
    // ── Methods ──
    public void ConvertRotationsToEuler(){} // RVA: 0x7FFE87B5D180
    public void ConvertRootMotion(){} // RVA: 0x7FFE87B5D1F0
    public void ConvertInfiniteTrack(){} // RVA: 0x7FFE87B5D2B0
}

public class AnimatorEvent : Object
{
    // ── Methods ──
    public void Activate(){} // RVA: 0x7FFE8115A630 | overloaded x3
    public void .ctor(){} // RVA: 0x7FFE8115A7B0
}

public class Annotation : Object
{
    public Google.Protobuf.MessageParser`1<Annotation> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public Google.Protobuf.FieldCodec`1<int> _repeated_path_codec; // 0x8
    public Google.Protobuf.Collections.RepeatedField`1<int> path_; // 0x20
    public string SourceFileDefaultValue; // 0x10
    public string sourceFile_; // 0x28
    public int BeginDefaultValue; // 0x18
    public int begin_; // 0x30
    public int EndDefaultValue; // 0x1C

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE865BCE60
    public void get_Descriptor(){} // RVA: 0x7FFE865BCEC0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865BCF40
    public void .ctor(){} // RVA: 0x7FFE865BD0B0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE865BD2C0
    public void get_Path(){} // RVA: 0x7FFE811290C0
    public void get_SourceFile(){} // RVA: 0x7FFE865BD320
    public void set_SourceFile(){} // RVA: 0x7FFE865BD390
    public void get_HasSourceFile(){} // RVA: 0x7FFE865A8CD0
    public void ClearSourceFile(){} // RVA: 0x7FFE836E7F30
    public void get_Begin(){} // RVA: 0x7FFE865BD490
    public void set_Begin(){} // RVA: 0x7FFE865BD500
    public void get_HasBegin(){} // RVA: 0x7FFE8659D0B0
    public void ClearBegin(){} // RVA: 0x7FFE8659D0C0
    public void get_End(){} // RVA: 0x7FFE865BD510
    public void set_End(){} // RVA: 0x7FFE865BD580
    public void get_HasEnd(){} // RVA: 0x7FFE8659D150
    public void ClearEnd(){} // RVA: 0x7FFE8659D160
    public void Equals(){} // RVA: 0x7FFE865BD730 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE865BD890
    public void ToString(){} // RVA: 0x7FFE865BD950
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865BD9A0
    public void CalculateSize(){} // RVA: 0x7FFE865BDAE0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865BDDD0
    public void .cctor(){} // RVA: 0x7FFE865BDF50
}

public class AnonymousProgress`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Report(){} // RVA: 0x7FFE810A1420
}

public class AnyKeyObj : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE866CA7F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AotTester : Object
{
    // ── Methods ──
    public void Test(){} // RVA: 0x7FFE810FB310
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ApiBundleDropNotificationDetails : ApiModel
{
    public string _title; // 0x68
    public string _body; // 0x70
    public string _imageUrl; // 0x78

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFE81176D50
    public void set_title(){} // RVA: 0x7FFE81176D60
    public void get_body(){} // RVA: 0x7FFE811C3590
    public void set_body(){} // RVA: 0x7FFE811C35A0
    public void get_imageUrl(){} // RVA: 0x7FFE81463AE0
    public void set_imageUrl(){} // RVA: 0x7FFE81464570
    public void .ctor(){} // RVA: 0x7FFE8A2D8E80
}

public class ApiGalleryImageContainer : ApiModel
{
    public int _totalCount; // 0x68
    public System.Collections.Generic.List`1<VRC.Core.ApiGroupGalleryImage> _results; // 0x70

    // ── Methods ──
    public void get_totalCount(){} // RVA: 0x7FFE82A22EF0
    public void set_totalCount(){} // RVA: 0x7FFE82A22F00
    public void get_results(){} // RVA: 0x7FFE811C3590
    public void set_results(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A37D650
}

public class ApiPopupBuilderData : ApiModel
{
    public string _key; // 0x68
    public VRC.Core.ApiLocalizableString _title; // 0x70
    public float _spacing; // 0x78
    public System.Collections.Generic.List`1<ContentBlock> _content; // 0x80

    // ── Methods ──
    public void get_key(){} // RVA: 0x7FFE81176D50
    public void set_key(){} // RVA: 0x7FFE81176D60
    public void get_title(){} // RVA: 0x7FFE811C3590
    public void set_title(){} // RVA: 0x7FFE811C35A0
    public void get_spacing(){} // RVA: 0x7FFE811240E0
    public void set_spacing(){} // RVA: 0x7FFE811240F0
    public void get_content(){} // RVA: 0x7FFE81280C30
    public void set_content(){} // RVA: 0x7FFE81282380
    public void .ctor(){} // RVA: 0x7FFE8A2D8660
}

public class ApiPopupBuilderRecipe : ApiModel
{
    public System.Collections.Generic.List`1<ApiPopupBuilderData> _pages; // 0x68

    // ── Methods ──
    public void get_pages(){} // RVA: 0x7FFE81176D50
    public void set_pages(){} // RVA: 0x7FFE81176D60
    public void .ctor(){} // RVA: 0x7FFE8A2D8610
}

public class ApiPromotionNotification : ApiModel
{
    public string _title; // 0x68
    public string _body; // 0x70
    public string _imageUrl; // 0x78
    public string _command; // 0x80
    public string _parameter; // 0x88

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFE81176D50
    public void set_title(){} // RVA: 0x7FFE81176D60
    public void get_body(){} // RVA: 0x7FFE811C3590
    public void set_body(){} // RVA: 0x7FFE811C35A0
    public void get_imageUrl(){} // RVA: 0x7FFE81463AE0
    public void set_imageUrl(){} // RVA: 0x7FFE81464570
    public void get_command(){} // RVA: 0x7FFE81280C30
    public void set_command(){} // RVA: 0x7FFE81282380
    public void get_parameter(){} // RVA: 0x7FFE8113A010
    public void set_parameter(){} // RVA: 0x7FFE81280F90
    public void .ctor(){} // RVA: 0x7FFE8A2D85C0
}

public class ApiRequestData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A2B9640 | overloaded x3
    public void op_Implicit(){} // RVA: 0x7FFE8A2B97B0 | overloaded x3
}

public class ApiVRChatProductStore : ApiModel
{
    public string _planId; // 0x68

    // ── Methods ──
    public void get_planId(){} // RVA: 0x7FFE81176D50
    public void set_planId(){} // RVA: 0x7FFE81176D60
    public void .ctor(){} // RVA: 0x7FFE8A3503E0
}

public class AppPerfFrameStats : ValueType
{
}

public class AppPerfStats : ValueType
{
}

public class Appearance : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AADD90
}

public class ApplySettingsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83F84C40
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Area : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87E75820
}

public class AreaNode : Object
{
    // ── Methods ──
    public void Acquire(){} // RVA: 0x7FFE87F6F950
    public void Release(){} // RVA: 0x7FFE87F6FAF0
    public void RemoveFromChain(){} // RVA: 0x7FFE87F6FB80
    public void AddAfter(){} // RVA: 0x7FFE87F6FCF0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE87F6FEE0
}

public class ArgsBufferPrep : Object
{
    // ── Methods ──
    public void Setup(){} // RVA: 0x7FFE82BD0830
    public void PrepareDispatchArgs(){} // RVA: 0x7FFE82BD0CF0
    public void PrepareDrawArgs(){} // RVA: 0x7FFE82BD1020
    public void .cctor(){} // RVA: 0x7FFE82BD1310
}

public class Arm : BodyPart
{
    public UnityEngine.Transform target; // 0x48
    public UnityEngine.Transform bendGoal; // 0x50
    public float positionWeight; // 0x58
    public float rotationWeight; // 0x5C
    public 0x665BA014 shoulderRotationMode; // 0x60
    public bool vrcExtraShoulderReach; // 0x64

    // ── Methods ──
    public void get_position(){} // RVA: 0x7FFE81219590
    public void set_position(){} // RVA: 0x7FFE812195B0
    public void get_rotation(){} // RVA: 0x7FFE812195D0
    public void set_rotation(){} // RVA: 0x7FFE812195E0
    public void get_shoulder(){} // RVA: 0x7FFE812195F0
    public void get_upperArm(){} // RVA: 0x7FFE81219620
    public void get_forearm(){} // RVA: 0x7FFE81219670
    public void get_hand(){} // RVA: 0x7FFE812196C0
    public void OnRead(){} // RVA: 0x7FFE81219710
    public void PreSolve(){} // RVA: 0x7FFE8121A9A0
    public void ApplyOffsets(){} // RVA: 0x7FFE8121AFF0
    public void Stretching(){} // RVA: 0x7FFE8121B050
    public void VrcGetZeroWeightElbowDir(){} // RVA: 0x7FFE8121B790
    public void VrcAdjustBendFromTargetRot(){} // RVA: 0x7FFE8121C7E0
    public void VrcAvoidElbowClipping(){} // RVA: 0x7FFE8121DAA0
    public void Solve(){} // RVA: 0x7FFE8121F6A0
    public void ResetOffsets(){} // RVA: 0x7FFE81223280
    public void Write(){} // RVA: 0x7FFE812232E0
    public void VrcSetPoseBend(){} // RVA: 0x7FFE81223670
    public void VrcSetPoseWristRot(){} // RVA: 0x7FFE81223690
    public void DamperValue(){} // RVA: 0x7FFE812236A0
    public void GetBendNormal(){} // RVA: 0x7FFE81223770
    public void Visualize(){} // RVA: 0x7FFE81224C70
    public void .ctor(){} // RVA: 0x7FFE81224F30
}
