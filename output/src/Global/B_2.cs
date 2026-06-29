// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 497

public class Background : ApiModel
{
    public object _type;
    public object _gradientTop;
    public object _gradientBottom;

    // ── Methods ──
    public void get_type(){} // RVA: 0xBBFF90
    public void set_type(){} // RVA: 0xBBFFA0
    public void get_gradientTop(){} // RVA: 0xC10050
    public void set_gradientTop(){} // RVA: 0xC10060
    public void get_gradientBottom(){} // RVA: 0xCD3320
    public void set_gradientBottom(){} // RVA: 0xCD4740
    public void .ctor(){} // RVA: 0xA59A850
}

public class BaggageEnumerator : ValueType
{
    public object _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_Current(){} // RVA: 0x8AA640
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x8AA670
    public void Dispose(){} // RVA: 0x8AA6D0
    public void MoveNext(){} // RVA: 0x8AA720
    public void Reset(){} // RVA: 0x8AA770
}

public class Banner : ApiModel
{
    public object _type;
    public object _color;
    public object _imageUrl;

    // ── Methods ──
    public void get_type(){} // RVA: 0xBBFF90
    public void set_type(){} // RVA: 0xBBFFA0
    public void get_color(){} // RVA: 0xC10050
    public void set_color(){} // RVA: 0xC10060
    public void get_imageUrl(){} // RVA: 0xCD3320
    public void set_imageUrl(){} // RVA: 0xCD4740
    public void .ctor(){} // RVA: 0xA59A800
}

public class Base64TextureResource : BaseTextureResource
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26500E0
    public void Unload(){} // RVA: 0x2650110
}

public class BaseVisualElementScheduledItem : ScheduledItem
{
    public object _element;
    public object scheduler;
    public object _isActive;
    public object _isDetaching;
    public object m_OnAttachToPanelCallback;
    public object m_OnDetachFromPanelCallback;

    // ── Methods ──
    public void get_element(){} // RVA: 0xD05CA0
    public void set_element(){} // RVA: 0xD09D70
    public void get_isScheduled(){} // RVA: 0x5BC22C0
    public void get_isActive(){} // RVA: 0xBFDA40
    public void set_isActive(){} // RVA: 0xBFDA50
    public void get_isDetaching(){} // RVA: 0x1C58C80
    public void set_isDetaching(){} // RVA: 0x1C58C90
    public void .ctor(){} // RVA: 0x7EC4860
    public void SetActive(){} // RVA: 0x7EC4B70
    public void SendActivation(){} // RVA: 0x7EC4E50
    public void SendDeactivation(){} // RVA: 0x7EC4FB0
    public void OnElementAttachToPanelCallback(){} // RVA: 0x7EC5010
    public void OnElementDetachFromPanelCallback(){} // RVA: 0x7EC5090
    public void StartingIn(){} // RVA: 0x7EC5140
    public void Until(){} // RVA: 0x7EC5150
    public void Every(){} // RVA: 0x7EC5210
    public void OnItemUnscheduled(){} // RVA: 0x7EC5320
    public void Resume(){} // RVA: 0x7EC5390
    public void Pause(){} // RVA: 0x7EC53A0
    public void ExecuteLater(){} // RVA: 0x7EC53B0
    public void OnPanelActivate(){} // RVA: 0x7EC5430
    public void OnPanelDeactivate(){} // RVA: 0x7EC5550
    public void CanBeActivated(){} // RVA: 0x7EC55F0
}

public class BehaviourDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class BinderWrapper : Object
{
    public object CSharpAssemblyName;
    public object BinderTypeName;
    public object CSharpArgumentInfoTypeName;
    public object CSharpArgumentInfoFlagsTypeName;
    public object CSharpBinderFlagsTypeName;
    public object _getCSharpArgumentInfoArray;
    public object _setCSharpArgumentInfoArray;
    public object _getMemberCall;
    public object _setMemberCall;
    public object _init;

    // ── Methods ──
    public void Init(){} // RVA: 0x6A3FE20
    public void CreateSharpArgumentInfoArray(){} // RVA: 0x6A400D0
    public void CreateMemberCalls(){} // RVA: 0x6A405D0
    public void GetMember(){} // RVA: 0x6A40CB0
    public void SetMember(){} // RVA: 0x6A40F60
}

public class BindingData : Object
{
    public object version;
    public object target;
    public object binding;
    public object m_LastContext;
    public object _localDataSource;
    public object m_SourceToUILastUpdate;
    public object m_UIToSourceLastUpdate;

    // ── Methods ──
    public void get_localDataSource(){} // RVA: 0x1661250
    public void set_localDataSource(){} // RVA: 0x166A5F0
    public void Reset(){} // RVA: 0x7E70E50
    public void set_context(){} // RVA: 0x7E70FA0
    public void .ctor(){} // RVA: 0xB43310
}

public class BindingDataCollection : ValueType
{
    public object m_BindingPerId;
    public object m_Bindings;

    // ── Methods ──
    public void Create(){} // RVA: 0x7E70500
    public void AddBindingData(){} // RVA: 0x9911B0
    public void TryGetBindingData(){} // RVA: 0x9911C0
    public void RemoveBindingData(){} // RVA: 0x9911D0
    public void GetBindings(){} // RVA: 0x8C0C50
    public void GetBindingCount(){} // RVA: 0x9911E0
    public void Dispose(){} // RVA: 0x991230
}

public class BindingData[] : Array
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

public class BindingOverrideJson : ValueType
{
    public object action;
    public object id;
    public object path;
    public object interactions;
    public object processors;

    // ── Methods ──
    public void FromBinding(){} // RVA: 0x77E67E0
    public void ToBinding(){} // RVA: 0x77E6860
}

public class BindingRequest : ValueType
{
    public object bindingId;
    public object binding;
    public object shouldProcess;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x991050
    public void CancelRequest(){} // RVA: 0x991060
}

public class BindingSyntax : ValueType
{
    public object m_ActionMap;
    public object m_Action;
    public object m_BindingIndexInMap;

    // ── Methods ──
    public void get_valid(){} // RVA: 0x929F40
    public void get_bindingIndex(){} // RVA: 0x929F50
    public void get_binding(){} // RVA: 0x929FD0
    public void .ctor(){} // RVA: 0x92A030
    public void WithName(){} // RVA: 0x92A040
    public void WithPath(){} // RVA: 0x92A1B0
    public void WithGroup(){} // RVA: 0x92A330
    public void WithGroups(){} // RVA: 0x92A360
    public void WithInteraction(){} // RVA: 0xA94080
    public void WithInteractions(){} // RVA: 0x92A3C0
    public void WithProcessor(){} // RVA: 0xA94080
    public void WithProcessors(){} // RVA: 0x92A420
    public void Triggering(){} // RVA: 0x92A450
    public void To(){} // RVA: 0x92A480
    public void NextBinding(){} // RVA: 0x92A620
    public void PreviousBinding(){} // RVA: 0x92A660
    public void NextPartBinding(){} // RVA: 0x92A6A0
    public void PreviousPartBinding(){} // RVA: 0x92A740
    public void NextCompositeBinding(){} // RVA: 0x92A7E0
    public void PreviousCompositeBinding(){} // RVA: 0x92A820
    public void Iterate(){} // RVA: 0x92A860
    public void IterateCompositeBinding(){} // RVA: 0x92A890
    public void IteratePartBinding(){} // RVA: 0x92A8D0
    public void Erase(){} // RVA: 0x92A910
    public void InsertPartBinding(){} // RVA: 0x92A920
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToManaged(){} // RVA: 0x7B53400
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToManaged(){} // RVA: 0x7BA8490
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
    public void ConvertToManaged(){} // RVA: 0x7BE3AA0
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToManaged(){} // RVA: 0x7BF30D0
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToManaged(){} // RVA: 0x7BF4CE0
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToManaged(){} // RVA: 0x812D1C0
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BindingsMarshaller : Object
{
    // ── Methods ──
    public void ConvertToNative(){} // RVA: 0x2C8D450
}

public class BitwiseDoubleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x6508840
    public void GetHashCode(){} // RVA: 0x6508860
    public void .ctor(){} // RVA: 0x6508870
}

public class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x6508910
    public void GetHashCode(){} // RVA: 0x65089F0
    public void .ctor(){} // RVA: 0x6508AA0
}

public class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x6508AD0
    public void GetHashCode(){} // RVA: 0x6508BC0
    public void .ctor(){} // RVA: 0x6508C70
}

public class BitwiseSingleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x65088A0
    public void GetHashCode(){} // RVA: 0x65088C0
    public void .ctor(){} // RVA: 0x65088E0
}

public class Block : LinkedPoolItem`1
{
    public object start;
    public object end;
    public object prev;
    public object next;
    public object prevAvailable;
    public object nextAvailable;
    public object allocated;

    // ── Methods ──
    public void get_size(){} // RVA: 0x7F4D760
    public void .ctor(){} // RVA: 0x7F4D770
}

public class Block : ValueType
{
    public object Range;
    public object BytesPerItem;
    public object AllocatedItems;
    public object Log2Alignment;
    public object Padding0;
    public object Padding1;
    public object Padding2;

    // ── Methods ──
    public void get_Bytes(){} // RVA: 0x9241A0
    public void get_AllocatedBytes(){} // RVA: 0x9241B0
    public void get_Alignment(){} // RVA: 0x9241C0
    public void set_Alignment(){} // RVA: 0x9241D0
    public void Dispose(){} // RVA: 0x924220
    public void TryFree(){} // RVA: 0x924220
}

public class BlockPool : LinkedPool`1
{
    // ── Methods ──
    public void CreateBlock(){} // RVA: 0x7F4D610
    public void ResetBlock(){} // RVA: 0xB43310
    public void .ctor(){} // RVA: 0x7F4D670
}

public class BlurShaderIds : Object
{
    public object _MainTex;
    public object _PingData;
    public object _PongData;
    public object _PingSizeTS;
    public object _PongSize;
    public object _PowerAmount;
    public object _KernelSize;
    public object _GaussianExponential;
    public object _GaussianNormalization;
    public object _Axis;
    public object _Slice;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x26C2340
}

public class Body : Object
{
    public object transform;
    public object relativeTo;
    public object effectorLinks;
    public object verticalWeight;
    public object horizontalWeight;
    public object speed;
    public object lastRelativePos;
    public object smoothDelta;
    public object firstUpdate;

    // ── Methods ──
    public void Update(){} // RVA: 0xCB9970
    public void Multiply(){} // RVA: 0xCBA0B0
    public void .ctor(){} // RVA: 0xCBA0F0
}

public class Body : Object
{
    public object transform;
    public object effectorLinks;
    public object speed;
    public object acceleration;
    public object matchVelocity;
    public object gravity;
    public object delta;
    public object lazyPoint;
    public object direction;
    public object lastPosition;
    public object firstUpdate;

    // ── Methods ──
    public void Reset(){} // RVA: 0xCBDD40
    public void Update(){} // RVA: 0xCBDFC0
    public void .ctor(){} // RVA: 0xCBE610
}

public class BodyJointLocation : ValueType
{
    public object LocationFlags;
    public object Pose;

    // ── Methods ──
    public void get_OrientationValid(){} // RVA: 0x8CDA00
    public void get_PositionValid(){} // RVA: 0x8CDA10
    public void get_OrientationTracked(){} // RVA: 0x8CDA20
    public void get_PositionTracked(){} // RVA: 0x8CDA30
}

public class BodyJointLocation[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Body[] : Array
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

public class Body[] : Array
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

public class Bone : ValueType
{
    public object childIndex;
    public object parentIndex;
    public object isEndBone;
    public object simulatedType;
    public object boneChainIndex;
    public object localPoseRotation;
    public object localBoneVector;
    public object localPoseBoneVector;
    public object originalLocalPosition;
    public object originalLocalRotation;
    public object originalLocalVector;
    public object originalLocalBoneLength;
    public object globalRestLength;
    public object originalRootEndpoint;
    public object originalLocalGravityNormal;
    public object beginPoint;
    public object endPoint;
    public object prevVelocity;
    public object immobileEndpoint;
    public object prevEndPoint;
    public object prevVector;
    public object prevLocalRotation;
    public object totalRestLength;
    public object totalLength;
    public object totalMinRestLength;
    public object totalMaxRestLength;
    public object grabStatus;
    public object pull;
    public object spring;
    public object stiffness;
    public object gravity;
    public object gravityFalloff;
    public object immobile;
    public object radiusBegin;
    public object radiusEnd;
    public object globalRadiusBegin;
    public object globalRadiusEnd;
    public object maxAngle;
    public object limitAxisX;
    public object limitAxisY;
    public object limitRotation;
    public object stretchMotion;
    public object stretch;
    public object squish;

    // ── Methods ──
    public void get_isSimulated(){} // RVA: 0x9C9BB0
}

public class Bone : ValueType
{
    public object transform;
    public object parentIndex;
    public object childIndex;
    public object boneChainIndex;
    public object childCount;
    public object averageChildPos;
    public object restPosition;
    public object restRotation;
    public object restScale;
    public object localGravityDirection;
    public object sphereCollision;

    // ── Methods ──
    public void get_isEndBone(){} // RVA: 0x9CA8D0
}

public class BoneLink : Object
{
    public object bone;
    public object weight;
    public object lastValue;
    public object current;

    // ── Methods ──
    public void Apply(){} // RVA: 0xCBBDB0
    public void CrossFadeStart(){} // RVA: 0xCBC190
    public void .ctor(){} // RVA: 0xCBC1A0
}

public class BoneVisualization : Object
{
    public object BoneGO;
    public object BoneBegin;
    public object BoneEnd;
    public object Line;
    public object RenderMaterial;
    public object SystemGestureMaterial;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C38140
    public void Update(){} // RVA: 0x6C38830
}

public class BoneVisualization[] : Array
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

public class Bone[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F930
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B050
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4EE0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35750
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B050
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class BoolGenerator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DFF2E0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0x2404860
}

public class BoolGenerator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DFF2E0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0x2404860
}

public class BoolMonitor : Object
{
    public object m_name;
    public object m_generator;
    public object m_prevValue;
    public object m_currentValue;
    public object m_currentValueRecentlyChanged;
    public object m_displayTimeout;
    public object m_displayTimer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C0DF00
    public void Update(){} // RVA: 0x6C0E060
    public void AppendToStringBuilder(){} // RVA: 0x6C0E130
}

public class BoolMonitor : Object
{
    public object m_name;
    public object m_generator;
    public object m_prevValue;
    public object m_currentValue;
    public object m_currentValueRecentlyChanged;
    public object m_displayTimeout;
    public object m_displayTimer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C1D990
    public void Update(){} // RVA: 0x6C0E060
    public void AppendToStringBuilder(){} // RVA: 0x6C1DAF0
}

public class BoolMonitor[] : Array
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

public class BoolMonitor[] : Array
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

public class BorderParams : ValueType
{
    public object rect;
    public object playmodeTintColor;
    public object leftColor;
    public object topColor;
    public object rightColor;
    public object bottomColor;
    public object leftWidth;
    public object topWidth;
    public object rightWidth;
    public object bottomWidth;
    public object topLeftRadius;
    public object topRightRadius;
    public object bottomRightRadius;
    public object bottomLeftRadius;
    public object leftColorPage;
    public object topColorPage;
    public object rightColorPage;
    public object bottomColorPage;

    // ── Methods ──
    public void ToNativeParams(){} // RVA: 0x99D500
}

public class BoundsEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x77C07D0
    public void GetHashCode(){} // RVA: 0x77C0860
    public void .ctor(){} // RVA: 0xB43310
}

public class BoundsIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x77C0B40
    public void GetHashCode(){} // RVA: 0x77C0C60
    public void .ctor(){} // RVA: 0xB43310
}

public class Box : ValueType
{
    public object position;
    public object rotation;
    public object extents;
    public object axes;

    // ── Methods ──
    public void PointToLocal(){} // RVA: 0x9C6A20
    public void PointToWorld(){} // RVA: 0x9C6A70
    public void ClosestPoint(){} // RVA: 0x9C6AC0
    public void ClosestPointToLineSegment(){} // RVA: 0x9C6B20
    public void SignedDistanceToPoint(){} // RVA: 0x9C6B90
    public void DeepestPointOnSurfaceInOtherBox(){} // RVA: 0x9C6C00
    public void SearchFaceRegion(){} // RVA: 0x82A78D0
}

public class BoxAvoidance : Object
{
    public object _wrapper;

    // ── Methods ──
    public void ToInt(){} // RVA: 0xA94080
    public void .cctor(){} // RVA: 0x8942F0
}

public class BoxBoundariesIndices : Object
{
    public object _parser;
    public object _unknownFields;
    public object _hasBits0;
    public object YminDefaultValue;
    public object ymin_;
    public object XminDefaultValue;
    public object xmin_;
    public object YmaxDefaultValue;
    public object ymax_;
    public object XmaxDefaultValue;
    public object xmax_;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x656A520
    public void get_Descriptor(){} // RVA: 0x656A580
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x656A600
    public void .ctor(){} // RVA: 0x656A6B0
    public void Clone(){} // RVA: 0x656A7B0
    public void get_Ymin(){} // RVA: 0x656A8E0
    public void set_Ymin(){} // RVA: 0x64D65C0
    public void get_HasYmin(){} // RVA: 0x64D65D0
    public void ClearYmin(){} // RVA: 0x64D65E0
    public void get_Xmin(){} // RVA: 0x656A950
    public void set_Xmin(){} // RVA: 0x64D6660
    public void get_HasXmin(){} // RVA: 0x64D6670
    public void ClearXmin(){} // RVA: 0x64D6680
    public void get_Ymax(){} // RVA: 0x656A9C0
    public void set_Ymax(){} // RVA: 0x6566740
    public void get_HasYmax(){} // RVA: 0x64D9870
    public void ClearYmax(){} // RVA: 0x64D9880
    public void get_Xmax(){} // RVA: 0x656AA30
    public void set_Xmax(){} // RVA: 0x6569990
    public void get_HasXmax(){} // RVA: 0x64D9E30
    public void ClearXmax(){} // RVA: 0x64D9E40
    public void Equals(){} // RVA: 0x656ABD0
    public void GetHashCode(){} // RVA: 0x656ACD0
    public void ToString(){} // RVA: 0x656AD70
    public void WriteTo(){} // RVA: 0x64B3910
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x656ADC0
    public void CalculateSize(){} // RVA: 0x656AEA0
    public void MergeFrom(){} // RVA: 0x64B3C50
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x656B120
    public void .cctor(){} // RVA: 0x656B210
}

public class BrainFrame[] : Array
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

public class BrainpoolP224r1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA405260
    public void .cctor(){} // RVA: 0xA4054B0
}

public class BrainpoolP224t1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA405550
    public void .cctor(){} // RVA: 0xA4057A0
}

public class BrainpoolP256r1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA405840
    public void .cctor(){} // RVA: 0xA405A90
}

public class BrainpoolP256t1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA405B30
    public void .cctor(){} // RVA: 0xA405D80
}

public class BrainpoolP320r1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA405E20
    public void .cctor(){} // RVA: 0xA406070
}

public class BrainpoolP320t1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA406110
    public void .cctor(){} // RVA: 0xA406360
}

public class BrainpoolP384r1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA406400
    public void .cctor(){} // RVA: 0xA406650
}

public class BrainpoolP384t1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA4066F0
    public void .cctor(){} // RVA: 0xA406940
}

public class BrainpoolP512r1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA4069E0
    public void .cctor(){} // RVA: 0xA406C30
}

public class BrainpoolP512t1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA406CD0
    public void .cctor(){} // RVA: 0xA406F20
}

public class BufferedAsyncEnumerable : Object
{
    public object _buffer;

    // ── Methods ──
    public void GetAsyncEnumerator(){} // RVA: 0x881D60
    public void .ctor(){} // RVA: 0x894290
}

public class BufferedAudioStream : Object
{
    public object VerboseLogging;
    public object audio;
    public object audioBuffer;
    public object writePos;
    public object bufferLengthSeconds;
    public object sampleRate;
    public object bufferSize;
    public object playbackDelayTimeSeconds;
    public object playbackDelayRemaining;
    public object remainingBufferTime;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6AF43A0
    public void Update(){} // RVA: 0x6AF4510
    public void Stop(){} // RVA: 0x6AF4630
    public void AddData(){} // RVA: 0x6AF4700
}

public class BufferedStreamContent : StreamContent
{
    public object _contentLength;

    // ── Methods ──
    public void get_ContentLength(){} // RVA: 0xC0FFC0
    public void .ctor(){} // RVA: 0x6E98EE0
    public void TryComputeLength(){} // RVA: 0x6E99250
}

public class Builder : Object
{
    public object _name;
    public object _displayName;
    public object _type;
    public object _stateFormat;
    public object _stateSizeInBytes;
    public object m_ExtendsLayout;
    public object _updateBeforeRender;
    public object m_ControlCount;
    public object m_Controls;

    // ── Methods ──
    public void get_name(){} // RVA: 0xB5DBF0
    public void set_name(){} // RVA: 0xB44D60
    public void get_displayName(){} // RVA: 0xB465B0
    public void set_displayName(){} // RVA: 0xBA9BA0
    public void get_type(){} // RVA: 0xB700F0
    public void set_type(){} // RVA: 0xB70100
    public void get_stateFormat(){} // RVA: 0x1065D50
    public void set_stateFormat(){} // RVA: 0x13233D0
    public void get_stateSizeInBytes(){} // RVA: 0x1AE5AC0
    public void set_stateSizeInBytes(){} // RVA: 0x23E55F0
    public void get_extendsLayout(){} // RVA: 0xD33E60
    public void set_extendsLayout(){} // RVA: 0x7943300
    public void get_updateBeforeRender(){} // RVA: 0x4FF64C0
    public void set_updateBeforeRender(){} // RVA: 0x6E48CC0
    public void get_controls(){} // RVA: 0x79433D0
    public void AddControl(){} // RVA: 0x7943480
    public void WithName(){} // RVA: 0x26FE8D0
    public void WithDisplayName(){} // RVA: 0xD33F30
    public void WithType(){} // RVA: 0x87C0A0
    public void WithFormat(){} // RVA: 0x7943920
    public void WithSizeInBytes(){} // RVA: 0x7943950
    public void Extend(){} // RVA: 0x7943960
    public void Build(){} // RVA: 0x7943980
    public void .ctor(){} // RVA: 0xB43310
}

public class Builder : Object
{
    public object _elements;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8944F0
    public void get_Capacity(){} // RVA: 0x87C130
    public void get_Count(){} // RVA: 0x87C130
    public void set_Count(){} // RVA: 0x8944F0
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x8942F0
    public void get_Item(){} // RVA: 0xA94080
    public void set_Item(){} // RVA: 0xA94080
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x87D280
    public void MoveToImmutable(){} // RVA: 0xA94080
    public void Clear(){} // RVA: 0x894290
    public void Insert(){} // RVA: 0xA94080
    public void Add(){} // RVA: 0xA94080
    public void Remove(){} // RVA: 0xA94080
    public void RemoveAt(){} // RVA: 0x8944F0
    public void Contains(){} // RVA: 0xA94080
    public void CopyTo(){} // RVA: 0x899290
    public void EnsureCapacity(){} // RVA: 0x8944F0
    public void IndexOf(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
}

public class Builder : Object
{
    public object _version;

    // ── Methods ──
    public void get_Version(){} // RVA: 0x87C130
}

public class Builder : Object
{
    public object _version;

    // ── Methods ──
    public void get_Version(){} // RVA: 0x87C130
}

public class Builder : Object
{
    public object _root;
    public object _keyComparer;
    public object _valueComparer;
    public object _count;
    public object _immutable;
    public object _version;

    // ── Methods ──
    public void get_Version(){} // RVA: 0x87C130
    public void get_Root(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void ToImmutable(){} // RVA: 0x87C0A0
}

public class BuiltInUriParser : UriParser
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7659F00
}

public class BunchesInformation : Object
{
    public object code;
    public object sender;
    public object currentBunchesTime;
    public object receivedBunches;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8291150
}

public class Burst : ValueType
{
    public object m_Time;
    public object m_Count;
    public object m_RepeatCount;
    public object m_RepeatInterval;
    public object m_InvProbability;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x978E20
    public void get_time(){} // RVA: 0x459690
    public void set_time(){} // RVA: 0xD1B20
    public void get_count(){} // RVA: 0x978E70
    public void set_count(){} // RVA: 0x978EB0
    public void get_minCount(){} // RVA: 0x978FA0
    public void set_minCount(){} // RVA: 0x978FB0
    public void get_maxCount(){} // RVA: 0x978FC0
    public void set_maxCount(){} // RVA: 0x978FD0
    public void get_cycleCount(){} // RVA: 0x978FE0
    public void set_cycleCount(){} // RVA: 0x978FF0
    public void get_repeatInterval(){} // RVA: 0x971FA0
    public void set_repeatInterval(){} // RVA: 0x979000
    public void get_probability(){} // RVA: 0x979010
    public void set_probability(){} // RVA: 0x979020
}

public class BurstCompilerHelper : Object
{
    public object IsBurstEnabledImpl;
    public object IsBurstGenerated;

    // ── Methods ──
    public void IsBurstEnabled(){} // RVA: 0x77CADB0
    public void DiscardedMethod(){} // RVA: 0x27217F0
    public void IsCompiledByBurst(){} // RVA: 0x77CADC0
    public void .cctor(){} // RVA: 0x77CAE30
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x77CB050
}

public class ButtonClickStatus : Object
{
    public object m_Target;
    public object m_PointerDownPosition;
    public object m_LastPointerDownTime;
    public object m_ClickCount;

    // ── Methods ──
    public void Reset(){} // RVA: 0x7E81680
    public void .ctor(){} // RVA: 0xB43310
}

public class ButtonEventsIterator : ValueType
{
    public object _mask;
    public object _bit;

    // ── Methods ──
    public void get_Current(){} // RVA: 0x9718A0
    public void MoveNext(){} // RVA: 0x9718B0
    public void Reset(){} // RVA: 0x9718F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x971900
    public void FromState(){} // RVA: 0x7CA7D10
}

public class ButtonsState : ValueType
{
    public object buttons;

    // ── Methods ──
    public void ShouldBeProcessed(){} // RVA: 0x7C9FEF0
    public void GetUnchecked(){} // RVA: 0x971100
    public void SetUnchecked(){} // RVA: 0x93AA90
    public void ClearUnchecked(){} // RVA: 0x971120
    public void IsPressed(){} // RVA: 0x971140
    public void GetAllPressed(){} // RVA: 0x971170
    public void SetPressed(){} // RVA: 0x971180
    public void Reset(){} // RVA: 0x9711B0
    public void ToString(){} // RVA: 0x9711D0
}

public class ButtonsState : ValueType
{
    public object _state;

    // ── Methods ──
    public void Set(){} // RVA: 0x91F160
    public void Get(){} // RVA: 0x971490
    public void Reset(){} // RVA: 0x96220
    public void ToString(){} // RVA: 0x9714A0
}
