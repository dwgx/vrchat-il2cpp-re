// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 645

public class PackageEntry : ValueType
{
    public object _packageId;
    public object _packageVersion;

    // ── Methods ──
    public void get_packageId(){} // RVA: 0x77900
    public void set_packageId(){} // RVA: 0x47F10
    public void get_packageVersion(){} // RVA: 0x77ED0
    public void set_packageVersion(){} // RVA: 0x77E70
    public void ToJObject(){} // RVA: 0xA743F0
}

public class PacketsCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
}

public class PagedGroupResult : Object
{
    public object Groups;
    public object NextCursor;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Painter2DJob : ValueType
{
    public object painterHandle;
    public object allocator;
    public object jobParameters;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9A9E00
}

public class Pair : ValueType
{
    public object shapeA;
    public object isReceiverA;
    public object shapeB;
    public object isReceiverB;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9C5EC0
    public void Equals(){} // RVA: 0x9C5F00
    public void GetHashCode(){} // RVA: 0x9C5F20
}

public class PanicFunction_ : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class PanoSpec[] : Array
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

public class ParallelWriter : ValueType
{
    public object unsafeWriter;

    // ── Methods ──
    public void Enqueue(){} // RVA: 0xA94080
}

public class Parameter : Object
{
    public object name;
    public object valueType;
    public object saved;
    public object defaultValue;
    public object networkSynced;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA6C83B0
}

public class Parameter : Object
{
    public object Value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Parameter : Object
{
    public object type;
    public object value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2574280
    public void get_Type(){} // RVA: 0xB8F8F0
    public void get_Value(){} // RVA: 0xB465B0
}

public class ParameterConfig[] : Array
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

public class ParameterEnumerable : ValueType
{
    public object m_State;
    public object m_Parameter;
    public object m_MapIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x928F90
    public void GetEnumerator(){} // RVA: 0x929010
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(){} // RVA: 0x9290A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x929170
}

public class ParameterEnumerator : ValueType
{
    public object m_State;
    public object m_MapIndex;
    public object m_BindingCurrentIndex;
    public object m_BindingEndIndex;
    public object m_InteractionCurrentIndex;
    public object m_InteractionEndIndex;
    public object m_ProcessorCurrentIndex;
    public object m_ProcessorEndIndex;
    public object m_BindingMask;
    public object m_ObjectType;
    public object m_ParameterName;
    public object m_MayBeInteraction;
    public object m_MayBeProcessor;
    public object m_MayBeComposite;
    public object m_CurrentBindingIsComposite;
    public object m_CurrentObject;
    public object m_CurrentParameter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x929300
    public void MoveToNextBinding(){} // RVA: 0x929380
    public void MoveToNextInteraction(){} // RVA: 0x929390
    public void MoveToNextProcessor(){} // RVA: 0x9293A0
    public void FindParameter(){} // RVA: 0x9293B0
    public void MoveNext(){} // RVA: 0x9293C0
    public void Reset(){} // RVA: 0x9293D0
    public void get_Current(){} // RVA: 0x9293E0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x929410
    public void Dispose(){} // RVA: 0x3FC0
}

public class ParameterLookupKey : Object
{
    public object _name;
    public object _type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_Name(){} // RVA: 0xB5DBF0
    public void get_Type(){} // RVA: 0xB465B0
    public void GetHashCode(){} // RVA: 0x6DCDA80
    public void Equals(){} // RVA: 0x6DCDB30
}

public class ParameterLookupValue : Object
{
    public object _duplicateName;
    public object _jsonPropertyInfo;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA9BA0
    public void get_DuplicateName(){} // RVA: 0xB5DBF0
    public void set_DuplicateName(){} // RVA: 0xB44D60
    public void get_JsonPropertyInfo(){} // RVA: 0xB465B0
}

public class ParameterOverride : ValueType
{
    public object objectRegistrationName;
    public object parameter;
    public object bindingMask;
    public object value;

    // ── Methods ──
    public void get_objectType(){} // RVA: 0x9298E0
    public void .ctor(){} // RVA: 0x929970
    public void Find(){} // RVA: 0x77F2760
    public void PickMoreSpecificOne(){} // RVA: 0x77F2C50
}

public class ParameterOverride[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E803B0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B340
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5540
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E36000
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B340
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Parameter[] : Array
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

public class Parameter[] : Array
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

public class ParameterizedConstructorDelegate`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class ParentHash[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class ParseError : Object
{
    public object position;
    public object message;

    // ── Methods ──
    public void get_EqualityContract(){} // RVA: 0x7DC8BC0
    public void .ctor(){} // RVA: 0x6CB6BA0
    public void ToString(){} // RVA: 0x7DC8C40
    public void PrintMembers(){} // RVA: 0x7DC8D80
    public void GetHashCode(){} // RVA: 0x7DC8E50
    public void Equals(){} // RVA: 0x7DC9010
}

public class ParsedPathComponent : ValueType
{
    public object m_Layout;
    public object m_Usages;
    public object m_Name;
    public object m_DisplayName;

    // ── Methods ──
    public void get_layout(){} // RVA: 0x92FB70
    public void get_usages(){} // RVA: 0x932930
    public void get_name(){} // RVA: 0x932AE0
    public void get_displayName(){} // RVA: 0x932B10
    public void get_isWildcard(){} // RVA: 0x932B40
    public void get_isDoubleWildcard(){} // RVA: 0x932B50
    public void ToHumanReadableString(){} // RVA: 0x7853A80
    public void Matches(){} // RVA: 0x932C80
    public void ComparePathElementToString(){} // RVA: 0x7853FD0
}

public class PartialStateForRollback : ValueType
{
    public object _prevTotalConsumed;
    public object _prevBytePositionInLine;
    public object _prevConsumed;
    public object _prevCurrentPosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8F1370
    public void GetStartPosition(){} // RVA: 0x8F13E0
}

public class PassthroughCapabilities : Object
{
    public object _supportsPassthrough;
    public object _supportsColorPassthrough;

    // ── Methods ──
    public void get_SupportsPassthrough(){} // RVA: 0xC120A0
    public void get_SupportsColorPassthrough(){} // RVA: 0xDD5C50
    public void .ctor(){} // RVA: 0x6672F10
}

public class PathParser : ValueType
{
    public object path;
    public object length;
    public object leftIndexInPath;
    public object rightIndexInPath;
    public object current;

    // ── Methods ──
    public void get_isAtEnd(){} // RVA: 0x932D50
    public void .ctor(){} // RVA: 0x932D60
    public void MoveToNextComponent(){} // RVA: 0x932DF0
    public void ParseComponentPart(){} // RVA: 0x932E00
}

public class PathResolver : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F6ECE0
    public void Invoke(){} // RVA: 0xB9E010
}

public class PayloadBuffer : MemoryStream
{
    // ── Methods ──
    public void ToTruncatedByteArray(){} // RVA: 0xA1D0840
    public void .ctor(){} // RVA: 0xA1C37E0
}

public class PcgRandom : ValueType
{
    public object increment;
    public object state;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x95FEE0
    public void GetUInt(){} // RVA: 0x95FF10
    public void RotateRight(){} // RVA: 0x67114B0
    public void XshRr(){} // RVA: 0x7B6FDE0
    public void Step(){} // RVA: 0x95FF60
}

public class Pelvis : Object
{
    public object _iKOffset;
    public object _heightOffset;
    public object grounding;
    public object lastRootPosition;
    public object damperF;
    public object initiated;
    public object lastTime;

    // ── Methods ──
    public void get_IKOffset(){} // RVA: 0xB60220
    public void set_IKOffset(){} // RVA: 0xB60240
    public void get_heightOffset(){} // RVA: 0xC152D0
    public void set_heightOffset(){} // RVA: 0xC152E0
    public void Initiate(){} // RVA: 0xC152F0
    public void Reset(){} // RVA: 0xC15480
    public void OnEnable(){} // RVA: 0xC15600
    public void Process(){} // RVA: 0xC15740
    public void .ctor(){} // RVA: 0xB43310
}

public class PerTypeValues`1 : Object
{
    public object IsReferenceOrContainsReferences;
    public object EmptyArray;
    public object ArrayAdjustment;

    // ── Methods ──
    public void MeasureArrayAdjustment(){} // RVA: 0x87C0D0
    public void .cctor(){} // RVA: 0x8942F0
}

public class PerfMetrics : Object
{
    public object frameCount;
    public object frameTime;
    public object deltaFrameTime;
    public object appCpuTime_IsValid;
    public object appCpuTime;
    public object appGpuTime_IsValid;
    public object appGpuTime;
    public object compositorCpuTime_IsValid;
    public object compositorCpuTime;
    public object compositorGpuTime_IsValid;
    public object compositorGpuTime;
    public object compositorDroppedFrameCount_IsValid;
    public object compositorDroppedFrameCount;
    public object compositorSpaceWarpMode_IsValid;
    public object compositorSpaceWarpMode;
    public object systemGpuUtilPercentage_IsValid;
    public object systemGpuUtilPercentage;
    public object systemCpuUtilAveragePercentage_IsValid;
    public object systemCpuUtilAveragePercentage;
    public object systemCpuUtilWorstPercentage_IsValid;
    public object systemCpuUtilWorstPercentage;
    public object deviceCpuClockFrequencyInMHz_IsValid;
    public object deviceCpuClockFrequencyInMHz;
    public object deviceGpuClockFrequencyInMHz_IsValid;
    public object deviceGpuClockFrequencyInMHz;
    public object deviceCpuClockLevel_IsValid;
    public object deviceCpuClockLevel;
    public object deviceGpuClockLevel_IsValid;
    public object deviceGpuClockLevel;
    public object deviceCpuCoreUtilPercentage_IsValid;
    public object deviceCpuCoreUtilPercentage;

    // ── Methods ──
    public void ToJSON(){} // RVA: 0x6C3AB10
    public void LoadFromJSON(){} // RVA: 0x6C3B1E0
    public void .ctor(){} // RVA: 0x6C3BD50
}

public class Perspective : Object
{
    public object depthImageSize;
    public object depthPrincipalPoint;
    public object depthFocalLength;
    public object farClip;
    public object nearClip;
    public object extrinsics;
    public object extrinsicsInv;
    public object crop;
    public object clipEpsilon;
    public object cameraNormal;
    public object cameraCenter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PerspectiveDataBuffer : SyncedStructuredBuffer`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26B1650
}

public class Perspective[] : Array
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

public class PhraseRecognizedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3EFA3D0
    public void Invoke(){} // RVA: 0x3E013D0
}

public class Physics : Object
{
    // ── Methods ──
    public void SetOrientationOnPath(){} // RVA: 0x27145C0
    public void HasRigidbody2D(){} // RVA: 0x27147D0
    public void HasRigidbody(){} // RVA: 0x27148D0
    public void CreateDOTweenPathTween(){} // RVA: 0x27149D0
}

public class Pico : ApiModel
{
    public object _sku;
    public object _user_id;
    public object _subscription_start_time;
    public object _subscription_end_time;
    public object _subscription_type;
    public object _status;
    public object _free_trial;
    public object _next_period;

    // ── Methods ──
    public void get_sku(){} // RVA: 0xBBFF90
    public void set_sku(){} // RVA: 0xBBFFA0
    public void get_user_id(){} // RVA: 0xC10050
    public void set_user_id(){} // RVA: 0xC10060
    public void get_subscription_start_time(){} // RVA: 0xCD3320
    public void set_subscription_start_time(){} // RVA: 0xCD4740
    public void get_subscription_end_time(){} // RVA: 0xD34760
    public void set_subscription_end_time(){} // RVA: 0xD34750
    public void get_subscription_type(){} // RVA: 0xD34730
    public void set_subscription_type(){} // RVA: 0xD34790
    public void get_status(){} // RVA: 0x14780B0
    public void set_status(){} // RVA: 0x147EE80
    public void get_free_trial(){} // RVA: 0xBAB4F0
    public void set_free_trial(){} // RVA: 0xBAB500
    public void get_next_period(){} // RVA: 0x1069350
    public void set_next_period(){} // RVA: 0xD5CC10
    public void .ctor(){} // RVA: 0xA59A9E0
}

public class PinchData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E520
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A9B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC42A0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34760
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A9B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class PinnedArray`1 : ValueType
{
    public object _handle;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void Dispose(){} // RVA: 0x894290
    public void op_Implicit(){} // RVA: 0xA94080
}

public class PinnedBlob : ValueType
{
    public object Handle;
    public object Length;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x856B0
    public void GetMemoryBlock(){} // RVA: 0x8E9DD0
}

public class PipelineSaver : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43D60
}

public class Plane : ValueType
{
    public object position;
    public object normal;

    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x9C6C80
}

public class PlatformOptions : Object
{
    public object httpHeaders;
    public object keyAuth;

    // ── Methods ──
    public void IsModified(){} // RVA: 0x25477F0
    public void HasChanged(){} // RVA: 0xB43320
    public void ClearChanges(){} // RVA: 0xB43310
    public void GetKeyServerAuthToken(){} // RVA: 0x1853320
    public void GetOverrideDecryptionKey(){} // RVA: 0x2547880
    public void StartWithHighestBandwidth(){} // RVA: 0xB43320
    public void get_IsUsingAudioCapture(){} // RVA: 0xB43320
    public void .ctor(){} // RVA: 0x25478A0
}

public class PlayerActions : ValueType
{
    public object m_Wrapper;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_Move(){} // RVA: 0x4F850
    public void get_Look(){} // RVA: 0x4FAC0
    public void get_Fire(){} // RVA: 0x4F830
    public void Get(){} // RVA: 0x4FA80
    public void Enable(){} // RVA: 0x935120
    public void Disable(){} // RVA: 0x4F700
    public void get_enabled(){} // RVA: 0x4F8A0
    public void op_Implicit(){} // RVA: 0x18E1A10
    public void SetCallbacks(){} // RVA: 0x9351A0
}

public class PlayerBucketRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x828CE10
    public void Invoke(){} // RVA: 0x14CC9D0
    public void BeginInvoke(){} // RVA: 0x828CEE0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class PlayerInstance : Object
{
    public object outputs;
    public object pcmData;
    public object isPcmDataReady;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PlayerJoinedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x78E6090
}

public class PlayerLeftEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x78E60D0
}

public class PlayerStorageIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3E2D8E0
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xC3B3A0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Point : Object
{
    public object transform;
    public object weight;
    public object solverPosition;
    public object solverRotation;
    public object defaultLocalPosition;
    public object defaultLocalRotation;

    // ── Methods ──
    public void StoreDefaultLocalState(){} // RVA: 0xC38BB0
    public void FixTransform(){} // RVA: 0xC38D20
    public void UpdateSolverPosition(){} // RVA: 0xC39080
    public void UpdateSolverLocalPosition(){} // RVA: 0xC39150
    public void UpdateSolverState(){} // RVA: 0xC39220
    public void UpdateSolverLocalState(){} // RVA: 0xC39390
    public void .ctor(){} // RVA: 0xC39500
}

public class PointAccum : Object
{
    public object x;
    public object y;
    public object z;
    public object u;
    public object v;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA686F60
}

public class PointExt : Object
{
    public object x;
    public object y;
    public object z;
    public object t;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA687240
}

public class PointExt : Object
{
    public object x;
    public object y;
    public object z;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA68E5D0
}

public class PointPrecomp : Object
{
    public object ypx_h;
    public object ymx_h;
    public object xyd;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA6874A0
}

public class PointPrecomp : Object
{
    public object x;
    public object y;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA68E780
}

public class Point[] : Array
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

public class PointerEvent : Object
{
    public object _pointerId;
    public object _pointerType;
    public object _isPrimary;
    public object _button;
    public object _pressedButtons;
    public object _position;
    public object _localPosition;
    public object _deltaPosition;
    public object _deltaTime;
    public object _clickCount;
    public object _pressure;
    public object _tangentialPressure;
    public object _altitudeAngle;
    public object _azimuthAngle;
    public object _twist;
    public object _tilt;
    public object _penStatus;
    public object _radius;
    public object _radiusVariance;
    public object _modifiers;

    // ── Methods ──
    public void get_pointerId(){} // RVA: 0xB8F8F0
    public void set_pointerId(){} // RVA: 0xB460A0
    public void get_pointerType(){} // RVA: 0xB465B0
    public void set_pointerType(){} // RVA: 0xBA9BA0
    public void get_isPrimary(){} // RVA: 0xC38360
    public void set_isPrimary(){} // RVA: 0xC38370
    public void get_button(){} // RVA: 0x15AF000
    public void set_button(){} // RVA: 0x1FAA840
    public void get_pressedButtons(){} // RVA: 0x1065D50
    public void set_pressedButtons(){} // RVA: 0x13233D0
    public void get_position(){} // RVA: 0xBA9C30
    public void set_position(){} // RVA: 0xBA9C50
    public void get_localPosition(){} // RVA: 0xBA9C60
    public void set_localPosition(){} // RVA: 0xBA9C80
    public void get_deltaPosition(){} // RVA: 0xBA9C90
    public void set_deltaPosition(){} // RVA: 0xBA9CB0
    public void get_deltaTime(){} // RVA: 0xBAB430
    public void set_deltaTime(){} // RVA: 0xBAB440
    public void get_clickCount(){} // RVA: 0x15443F0
    public void set_clickCount(){} // RVA: 0x15443E0
    public void get_pressure(){} // RVA: 0xB6B160
    public void set_pressure(){} // RVA: 0xB6B170
    public void get_tangentialPressure(){} // RVA: 0xB6B180
    public void set_tangentialPressure(){} // RVA: 0xB6B190
    public void get_altitudeAngle(){} // RVA: 0xC5C4A0
    public void set_altitudeAngle(){} // RVA: 0x18AD0F0
    public void get_azimuthAngle(){} // RVA: 0xB6B1C0
    public void set_azimuthAngle(){} // RVA: 0xB6B1D0
    public void get_twist(){} // RVA: 0xB6B1E0
    public void set_twist(){} // RVA: 0xB6B1F0
    public void get_tilt(){} // RVA: 0xD34770
    public void set_tilt(){} // RVA: 0xD346C0
    public void get_penStatus(){} // RVA: 0x21EA4F0
    public void set_penStatus(){} // RVA: 0x26432E0
    public void get_radius(){} // RVA: 0x810E9A0
    public void set_radius(){} // RVA: 0x6529A50
    public void get_radiusVariance(){} // RVA: 0x810E9C0
    public void set_radiusVariance(){} // RVA: 0x278E9B0
    public void get_modifiers(){} // RVA: 0x14780B0
    public void set_modifiers(){} // RVA: 0x147EE80
    public void get_shiftKey(){} // RVA: 0x810E9E0
    public void get_ctrlKey(){} // RVA: 0x810E9F0
    public void get_commandKey(){} // RVA: 0x810EA00
    public void get_altKey(){} // RVA: 0x810EA10
    public void get_actionKey(){} // RVA: 0x810EA20
    public void Read(){} // RVA: 0x810EB20
    public void SetPosition(){} // RVA: 0x810F170
    public void .ctor(){} // RVA: 0xB43310
    public void <Read>g__InRange|90_0(){} // RVA: 0x810F1A0
}

public class PointerLocation : ValueType
{
    public object _position;
    public object _panel;
    public object _flags;

    // ── Methods ──
    public void get_Position(){} // RVA: 0x45E460
    public void set_Position(){} // RVA: 0x93050
    public void get_Panel(){} // RVA: 0x77ED0
    public void set_Panel(){} // RVA: 0x77E70
    public void get_Flags(){} // RVA: 0x8C7E0
    public void set_Flags(){} // RVA: 0x8C7F0
    public void SetLocation(){} // RVA: 0x9A5510
}

public class PolarCoord : ValueType
{
    public object azimuth;
    public object elevation;

    // ── Methods ──
    public void FromCart(){} // RVA: 0x8E5A00
}

public class PolyNode[] : Array
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

public class PolyfillExtensions : Object
{
    public object parameterCache;
    public object propertyCache;
    public object eventCache;
    public object fieldCache;
    public object TicksPerMicrosecond;

    // ── Methods ──
    public void GetNullabilityInfo(){} // RVA: 0x6CFE7B0
    public void GetNullability(){} // RVA: 0x6CFE960
    public void IsNullable(){} // RVA: 0x6CFECD0
    public void GetReadOrWriteState(){} // RVA: 0x6CFEAA0
    public void GetKnownState(){} // RVA: 0x6CFEAD0
    public void CancelAsync(){} // RVA: 0x6CFED40
    public void GetStreamAsync(){} // RVA: 0x6CFF080
    public void GetByteArrayAsync(){} // RVA: 0x6CFF370
    public void GetStringAsync(){} // RVA: 0x6CFF660
    public void ReadAsStreamAsync(){} // RVA: 0x6CFF700
    public void ReadAsByteArrayAsync(){} // RVA: 0x6CFF7D0
    public void ReadAsStringAsync(){} // RVA: 0x6CFFA20
    public void MaxBy(){} // RVA: 0xA94080
    public void MinBy(){} // RVA: 0xA94080
    public void SkipLast(){} // RVA: 0x88B6E0
    public void GetValueOrDefault(){} // RVA: 0xA94080
    public void Deconstruct(){} // RVA: 0xA94080
    public void Contains(){} // RVA: 0x6D018D0
    public void SequenceEqual(){} // RVA: 0x6CFFBA0
    public void StartsWith(){} // RVA: 0x6D01690
    public void EndsWith(){} // RVA: 0x6D016D0
    public void Nanoseconds(){} // RVA: 0x6D002E0
    public void Nanosecond(){} // RVA: 0x6D003E0
    public void Microseconds(){} // RVA: 0x6D00470
    public void Microsecond(){} // RVA: 0x6D00570
    public void AddMicroseconds(){} // RVA: 0x6D006B0
    public void TicksComponent(){} // RVA: 0x6D00B60
    public void ReadAsync(){} // RVA: 0x6D02020
    public void WriteAsync(){} // RVA: 0x6D02410
    public void CopyToAsync(){} // RVA: 0x6D011D0
    public void CopyTo(){} // RVA: 0x6D01900
    public void TryCopyTo(){} // RVA: 0x6D012F0
    public void GetHashCode(){} // RVA: 0x6D013A0
    public void FromComparison(){} // RVA: 0x6D01520
    public void Split(){} // RVA: 0x6D01830
    public void Append(){} // RVA: 0x6D019D0
    public void Equals(){} // RVA: 0x6D01A70
    public void WaitAsync(){} // RVA: 0xA94080
    public void ReadToEndAsync(){} // RVA: 0x6D02330
    public void WriteLineAsync(){} // RVA: 0x6D02700
    public void Write(){} // RVA: 0x6D029F0
    public void WriteLine(){} // RVA: 0x6D02C30
    public void TryFormat(){} // RVA: 0x6D03FC0
    public void CopyToSpan(){} // RVA: 0x6D04150
    public void HasSameMetadataDefinitionAs(){} // RVA: 0x6D04280
    public void IsGenericMethodParameter(){} // RVA: 0x6D04350
    public void GetMemberWithSameMetadataDefinitionAs(){} // RVA: 0x6D043E0
    public void ReadAsStream(){} // RVA: 0x6D045E0
    public void WriteRawValue(){} // RVA: 0x6D04780
    public void .cctor(){} // RVA: 0x6D04A60
}

public class PolygonSolution[] : Array
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

public class PopupButtonData : ApiModel
{
    public object _text;
    public object _capture;
    public object _requiredCaptures;
    public object _completePromotionOnPress;
    public object _analyticsEventTag;
    public object _onPressed;

    // ── Methods ──
    public void get_text(){} // RVA: 0xBBFF90
    public void set_text(){} // RVA: 0xBBFFA0
    public void get_capture(){} // RVA: 0xC10050
    public void set_capture(){} // RVA: 0xC10060
    public void get_requiredCaptures(){} // RVA: 0xCD3320
    public void set_requiredCaptures(){} // RVA: 0xCD4740
    public void get_completePromotionOnPress(){} // RVA: 0xE3F400
    public void set_completePromotionOnPress(){} // RVA: 0xE3CFC0
    public void get_analyticsEventTag(){} // RVA: 0xB813B0
    public void set_analyticsEventTag(){} // RVA: 0xD5CBB0
    public void get_onPressed(){} // RVA: 0x1069350
    public void set_onPressed(){} // RVA: 0xD5CC10
    public void .ctor(){} // RVA: 0xA51C3E0
}

public class PopupTextElement : TextElement
{
    // ── Methods ──
    public void DoMeasure(){} // RVA: 0x894130
    public void .ctor(){} // RVA: 0x894290
}

public class PopupTextElement : TextElement
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4873800
}

public class Pose : Object
{
    public object visualize;
    public object name;
    public object direction;
    public object yaw;
    public object pitch;
    public object angleBuffer;

    // ── Methods ──
    public void IsInDirection(){} // RVA: 0xCB9460
    public void SetAngleBuffer(){} // RVA: 0xC12100
    public void .ctor(){} // RVA: 0xCB97B0
}

public class PoseBlendingBehaviour : Object
{
    public object name;
    public object enabled;
    public object influence;
    public object pose;
    public object value;
    public object action_single;
    public object action_bool;
    public object smoothingSpeed;
    public object type;
    public object useMask;
    public object mask;
    public object previewEnabled;

    // ── Methods ──
    public void Update(){} // RVA: 0x6F64FF0
    public void ApplyBlending(){} // RVA: 0x6F65150
    public void .ctor(){} // RVA: 0x6F655D0
}

public class PoseBlendingBehaviour[] : Array
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

public class PoseData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F0B0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AD50
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC49A0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E350A0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AD50
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class PoseStatef : ValueType
{
    public object Pose;
    public object Velocity;
    public object Acceleration;
    public object AngularVelocity;
    public object AngularAcceleration;
    public object Time;
    public object identity;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x6BE34F0
}

public class Pose[] : Array
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

public class Posef : ValueType
{
    public object Orientation;
    public object Position;
    public object identity;

    // ── Methods ──
    public void ToString(){} // RVA: 0x8CA6B0
    public void .cctor(){} // RVA: 0x6BE30F0
}

public class PosesUpdatedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1ED7FE0
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0x1ED80B0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class PositionOffset : Offset
{
    public object forceDirCurveIndex;
    public object upDirCurveIndex;
    public object offsetLinks;

    // ── Methods ──
    public void GetLength(){} // RVA: 0xCBC9E0
    public void CrossFadeStart(){} // RVA: 0xCBCC20
    public void OnApply(){} // RVA: 0xCBCC80
    public void .ctor(){} // RVA: 0xCBCFF0
}

public class PositionOffsetLink : Object
{
    public object positionOffset;
    public object weight;
    public object lastValue;
    public object current;

    // ── Methods ──
    public void Apply(){} // RVA: 0xCBD000
    public void CrossFadeStart(){} // RVA: 0xCBB790
    public void .ctor(){} // RVA: 0xB43310
}

public class PositionOffset[] : Array
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

public class PrecomputeCallback : Object
{
    public object m_p;
    public object m_minWidth;
    public object m_includeNegated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6956580
    public void Precompute(){} // RVA: 0xA116200
    public void CheckExisting(){} // RVA: 0xA116DF0
    public void CheckTable(){} // RVA: 0xA116F20
}

public class PrecomputeWithPointMapCallback : Object
{
    public object m_point;
    public object m_pointMap;
    public object m_fromWNaf;
    public object m_includeNegated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA116F30
    public void Precompute(){} // RVA: 0xA117040
    public void CheckExisting(){} // RVA: 0xA1175F0
    public void CheckTable(){} // RVA: 0xA116F20
}

public class PrepareTextJobData : ValueType
{
    public object managedJobDataHandle;

    // ── Methods ──
    public void Execute(){} // RVA: 0x99A1F0
}

public class Prime192v1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BAB90
    public void .cctor(){} // RVA: 0xA3BAE10
}

public class Prime192v2Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BAEB0
    public void .cctor(){} // RVA: 0xA3BB130
}

public class Prime192v3Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BB1D0
    public void .cctor(){} // RVA: 0xA3BB450
}

public class Prime239v1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BB4F0
    public void .cctor(){} // RVA: 0xA3BB770
}

public class Prime239v2Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BB810
    public void .cctor(){} // RVA: 0xA3BBA90
}

public class Prime239v3Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BBB30
    public void .cctor(){} // RVA: 0xA3BBDB0
}

public class Prime256v1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA3BBE50
    public void .cctor(){} // RVA: 0xA3BC0D0
}

public class PrimitiveConverters : Object
{
    // ── Methods ──
    public void Register(){} // RVA: 0x7D44A00
    public void RegisterInt8Converters(){} // RVA: 0x7D44D90
    public void RegisterInt16Converters(){} // RVA: 0x7D464C0
    public void RegisterInt32Converters(){} // RVA: 0x7D47C00
    public void RegisterInt64Converters(){} // RVA: 0x7D49350
    public void RegisterUInt8Converters(){} // RVA: 0x7D4AAA0
    public void RegisterUInt16Converters(){} // RVA: 0x7D4C1F0
    public void RegisterUInt32Converters(){} // RVA: 0x7D4D940
    public void RegisterUInt64Converters(){} // RVA: 0x7D4F090
    public void RegisterFloat32Converters(){} // RVA: 0x7D507E0
    public void RegisterFloat64Converters(){} // RVA: 0x7D51F30
    public void RegisterBooleanConverters(){} // RVA: 0x7D53680
    public void RegisterCharConverters(){} // RVA: 0x7D54DD0
    public void RegisterStringConverters(){} // RVA: 0x7D568F0
    public void RegisterObjectConverters(){} // RVA: 0x7D59250
}

public class PrintFile : ApiModel
{
    public object _fileId;
    public object _image;

    // ── Methods ──
    public void get_fileId(){} // RVA: 0xBBFF90
    public void set_fileId(){} // RVA: 0xBBFFA0
    public void get_image(){} // RVA: 0xC10050
    public void set_image(){} // RVA: 0xC10060
    public void .ctor(){} // RVA: 0xA567860
}

public class PrivateKeyInfo : Object
{
    public object _version;
    public object _algorithm;
    public object _key;
    public object _list;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6658C70
    public void get_Algorithm(){} // RVA: 0xB465B0
    public void set_Algorithm(){} // RVA: 0xBA9BA0
    public void get_PrivateKey(){} // RVA: 0x6658CA0
    public void set_PrivateKey(){} // RVA: 0x6658D20
    public void Decode(){} // RVA: 0x6658E60
    public void GetBytes(){} // RVA: 0x6659190
    public void RemoveLeadingZero(){} // RVA: 0x6659800
    public void Normalize(){} // RVA: 0x66598B0
    public void DecodeRSA(){} // RVA: 0x6659960
    public void Encode(){} // RVA: 0x665A5A0
    public void DecodeDSA(){} // RVA: 0x665A380
}

public class ProcessExtractedFrame : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Promotion : ApiModel
{
    public object _type;
    public object _imageUrl;
    public object _position;
    public object _displayDelay;
    public object _impressions;
    public object _hoursBetweenImpressions;
    public object _fallback;
    public object _fallbackPosition;
    public object _popupId;
    public object _onPressed;
    public object _popupCommand;
    public object _recipes;
    public object _notification;

    // ── Methods ──
    public void get_type(){} // RVA: 0xBBFF90
    public void set_type(){} // RVA: 0xBBFFA0
    public void get_imageUrl(){} // RVA: 0xC10050
    public void set_imageUrl(){} // RVA: 0xC10060
    public void get_position(){} // RVA: 0x23ADD10
    public void set_position(){} // RVA: 0x23B2A80
    public void get_displayDelay(){} // RVA: 0x23A4270
    public void set_displayDelay(){} // RVA: 0x6CB6340
    public void get_impressions(){} // RVA: 0xD34760
    public void set_impressions(){} // RVA: 0xD34750
    public void get_hoursBetweenImpressions(){} // RVA: 0xD34730
    public void set_hoursBetweenImpressions(){} // RVA: 0xD34790
    public void get_fallback(){} // RVA: 0xB813B0
    public void set_fallback(){} // RVA: 0xD5CBB0
    public void get_fallbackPosition(){} // RVA: 0xF3A950
    public void set_fallbackPosition(){} // RVA: 0x17AFA20
    public void get_popupId(){} // RVA: 0x106A7D0
    public void set_popupId(){} // RVA: 0xD5CC70
    public void get_onPressed(){} // RVA: 0x106A050
    public void set_onPressed(){} // RVA: 0xD5CCD0
    public void get_popupCommand(){} // RVA: 0x12EB090
    public void set_popupCommand(){} // RVA: 0x13B1040
    public void get_recipes(){} // RVA: 0xBAE340
    public void set_recipes(){} // RVA: 0xBAE350
    public void get_notification(){} // RVA: 0xBAE3B0
    public void set_notification(){} // RVA: 0xBAE3C0
    public void .ctor(){} // RVA: 0xA51C220
}

public class PropBuilderSessionData : Object
{
    public object PropName;
    public object PropID;
    public object PropDesc;
    public object PropTags;
    public object PropThumbPath;
    public object PropReleaseStatus;
    public object PropSpawnType;
    public object PropWorldPlacementMask;
    public object PropKind;
    public object PropScaleWithAvatar;
    public object PropVisibilityType;
    public object PropAbilities;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class PropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class PropertyScope : ValueType
{
    public object m_Visitor;
    public object m_Property;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x989B00
    public void Dispose(){} // RVA: 0x989B10
}

public class Props : Object
{
    public object group;
    public object mappingWeight;
    public object pinWeight;
    public object muscleWeight;
    public object muscleDamper;
    public object mapPosition;
    public object internalCollisionIgnores;
    public object animatedTargetChildren;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xBBA560
    public void Clamp(){} // RVA: 0xBBA700
}

public class PseudoStateData : ValueType
{
    public object state;
    public object negate;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x295B0
}

public class PuppetEvent : ValueType
{
    public object switchToBehaviour;
    public object animations;
    public object unityEvent;
    public object empty;

    // ── Methods ──
    public void get_switchBehaviour(){} // RVA: 0x4390
    public void Trigger(){} // RVA: 0x43A0
}

public class PuppetUpdateLimit : Object
{
    public object puppetsPerFrame;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xBE5FA0
    public void Step(){} // RVA: 0xBE5FB0
    public void Update(){} // RVA: 0xBE5FD0
}
