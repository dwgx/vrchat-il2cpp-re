// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 25
// Methods: 119

public class HIDCollectionDescriptor : ValueType
{
    public 0x664AB848 type; // 0x10
    public int usage; // 0x14
    public 0x664ABA58 usagePage; // 0x18
    public int parent; // 0x1C
    public int childCount; // 0x20
    public int firstChild; // 0x24
}

public class HIDDeviceDescriptor : ValueType
{
    public int vendorId; // 0x10
    public int productId; // 0x14
    public int usage; // 0x18
    public 0x664ABA58 usagePage; // 0x1C
    public int inputReportSize; // 0x20
    public int outputReportSize; // 0x24
    public int featureReportSize; // 0x28
    public HIDElementDescriptor[] elements; // 0x30
    public HIDCollectionDescriptor[] collections; // 0x38

    // ── Methods ──
    public void ToJson(){} // RVA: 0x7FFD54A826A0
    public void FromJson(){} // RVA: 0x7FFD54A82710
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    public 0x664ABA58 usagePage; // 0x10
    public int usage; // 0x14
    public int m_CurrentReportId; // 0x18
    public 0x664AB7F0 m_CurrentReportType; // 0x1C
    public int m_CurrentReportOffsetInBits; // 0x20
    public System.Collections.Generic.List`1<HIDElementDescriptor> m_Elements; // 0x28
    public System.Collections.Generic.List`1<HIDCollectionDescriptor> m_Collections; // 0x30
    public int m_InputReportSize; // 0x38
    public int m_OutputReportSize; // 0x3C
    public int m_FeatureReportSize; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54A84AD0 | overloaded x2
    public void StartReport(){} // RVA: 0x7FFD54A84B00
    public void AddElement(){} // RVA: 0x7FFD54A84FC0 | overloaded x2
    public void WithPhysicalMinMax(){} // RVA: 0x7FFD54A85020
    public void WithLogicalMinMax(){} // RVA: 0x7FFD54A851E0
    public void Finish(){} // RVA: 0x7FFD54A853A0
}

public class HIDElementDescriptor : ValueType
{
    public int hasNullState; // 0x10
    public 0x664ABA58 hasPreferredState; // 0x14
    public int isArray; // 0x18
    public int isNonLinear; // 0x1C
    public int isRelative; // 0x20
    public int isConstant; // 0x24
    public int isWrapping; // 0x28
    public int isSigned; // 0x2C
    public 0x664AB7F0 minFloatValue; // 0x30
    public int maxFloatValue; // 0x34
    public int reportId; // 0x38
    public int reportSizeInBits; // 0x3C
    public int reportOffsetInBits; // 0x40
    public 0x664AB8A0 flags; // 0x44
    public System.Nullable`1<int> usageMin; // 0x48
    public System.Nullable`1<int> usageMax; // 0x50

    // ── Methods ──
    public void get_hasNullState(){} // RVA: 0x7FFD54A80CE0
    public void get_hasPreferredState(){} // RVA: 0x7FFD54A80CF0
    public void get_isArray(){} // RVA: 0x7FFD54A80D00
    public void get_isNonLinear(){} // RVA: 0x7FFD54A80D10
    public void get_isRelative(){} // RVA: 0x7FFD54A80D20
    public void get_isConstant(){} // RVA: 0x7FFD54A80D30
    public void get_isWrapping(){} // RVA: 0x7FFD54A80D40
    public void get_isSigned(){} // RVA: 0x7FFD54A80D50
    public void get_minFloatValue(){} // RVA: 0x7FFD54A80D60
    public void get_maxFloatValue(){} // RVA: 0x7FFD54A80E40
    public void Is(){} // RVA: 0x7FFD54A80F20
    public void DetermineName(){} // RVA: 0x7FFD54A80F30
    public void DetermineDisplayName(){} // RVA: 0x7FFD54A811F0
    public void IsUsableElement(){} // RVA: 0x7FFD54A812D0
    public void DetermineLayout(){} // RVA: 0x7FFD54A81300
    public void DetermineFormat(){} // RVA: 0x7FFD54A81400
    public void DetermineUsages(){} // RVA: 0x7FFD54A81580
    public void DetermineParameters(){} // RVA: 0x7FFD54A81900
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x7FFD54A81A40
    public void DetermineProcessors(){} // RVA: 0x7FFD54A81BF0
    public void DetermineDefaultState(){} // RVA: 0x7FFD54A81C50
    public void AddChildControls(){} // RVA: 0x7FFD54A81D90
}

public class HIDLayoutBuilder : Object
{
    public string displayName; // 0x10
    public HIDDeviceDescriptor hidDescriptor; // 0x18
    public string parentLayout; // 0x48
    public System.Type deviceType; // 0x50

    // ── Methods ──
    public void Build(){} // RVA: 0x7FFD54A7ED60
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class HIDPageUsage : ValueType
{
    public 0x664ABA58 page; // 0x10
    public int usage; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54A87310 | overloaded x2
}

public class HandInputData : ValueType
{
    public float TrackedDuration; // 0x10
    public PinchData[] Pinches; // 0x18
    public bool[] FingerExtended; // 0x20
    public float[] FingerCurls; // 0x28
    public float[] FingerCurlVelocities; // 0x30
    public UnityEngine.Vector3 PreviousWristPositionPlayspace; // 0x38
    public UnityEngine.Vector3 WristVelocity; // 0x44
    public UnityEngine.Vector3 WristVelocityPlayspace; // 0x50

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFD4F410AD0
    public void InternalEquals(){} // RVA: 0x7FFD4F410FB0
    public void DefaultEquals(){} // RVA: 0x7FFD4F411320
    public void GetHashCode(){} // RVA: 0x7FFD4F4117D0
    public void InternalGetHashCode(){} // RVA: 0x7FFD4F411CD0
    public void ToString(){} // RVA: 0x7FFD4F412040
    public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F4126E0
    public void HasValidInternalValue(){} // RVA: 0x7FFD4F412DB0
}

public class HandTrackingData : ValueType
{
    public bool IsLeft; // 0x10
    public bool IsTracking; // 0x11
    public bool IsPersisting; // 0x12
    public 0x66360820 FidelityLevel; // 0x14
    public FingerData[] Fingers; // 0x18
    public TrackedPose WristPose; // 0x20
    public TrackedPose PalmPose; // 0x3C
}

public class Handlers : Object
{
    public UIntPtr Utf8JsonWriter; // 0x10
    public UIntPtr StringHandler; // 0x18
    public UIntPtr Utf8StringWriter; // 0x20
    public UIntPtr ReadBoxed; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E389A50
}

public class HashBucket : ValueType
{
    public string IsEmpty; // 0x10
    public Node<string> FirstValue; // 0x18

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
    public void get_FirstValue(){} // RVA: 0x7FFD4E2ADC40
    public void get_AdditionalElements(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void Equals(){} // RVA: 0x7FFD4E079F60
    public void GetHashCode(){} // RVA: 0x7FFD4E079960
    public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
    public void Freeze(){} // RVA: 0x7FFD4E090980
}

public class HashBucketByRefEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<string>> DefaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFD4E078A90
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Equals(){} // RVA: 0x7FFD4E2ADC40
    public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashBucketByValueEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<string>> DefaultInstance;
    public System.Collections.Generic.IEqualityComparer`1<string> _valueComparer; // 0x10

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFD4E078A90
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Equals(){} // RVA: 0x7FFD4E2ADC40
    public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashCode : ValueType
{
    public int _hashCode; // 0x10

    // ── Methods ──
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void ToHashCode(){} // RVA: 0x7FFD4F840210
}

public class HashCode64`1 : ValueType
{
    public long Value;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashPair : ValueType
{
    public int parentHash; // 0x10
    public int hash; // 0x14
}

public class HashSetPoolImpl`1 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.HashSet`1<int>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashsetIterator`1 : ValueType
{
    public bool Current;
    public System.Collections.Generic.HashSet`1<T> hashset;
    public Enumerator<T> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class HashtableDebugView : Object
{
}

public class HashtableEnumerator : Object
{
    public System.Collections.Hashtable Key; // 0x10
    public int Entry; // 0x18
    public int Current; // 0x1C
    public bool Value; // 0x20
    public int _getObjectRetType; // 0x24
    public object _currentKey; // 0x28
    public object _currentValue; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539C58D0
    public void Clone(){} // RVA: 0x7FFD53932B10
    public void get_Key(){} // RVA: 0x7FFD539C5960
    public void MoveNext(){} // RVA: 0x7FFD539C59D0
    public void get_Entry(){} // RVA: 0x7FFD539C5B00
    public void get_Current(){} // RVA: 0x7FFD539C5B80
    public void get_Value(){} // RVA: 0x7FFD539C5C60
    public void Reset(){} // RVA: 0x7FFD539C5CD0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    public System.Net.Http.Headers.TryParseDelegate`1<T> parser;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5126A7D0
    public void AddToCollection(){} // RVA: 0x7FFD5126A890
    public void CreateCollection(){} // RVA: 0x7FFD5126AA30
    public void ToStringCollection(){} // RVA: 0x7FFD5126C340
    public void TryParse(){} // RVA: 0x7FFD5126C710
}

public class Heading : ValueType
{
    public 0x66589B00 m_Definition; // 0x10
    public int m_VelocityFilterStrength; // 0x14
    public float m_Bias; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC4EE60
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54E15A30
    public void Invoke(){} // RVA: 0x7FFD53BA8060
}

public class Hierarchy : ValueType
{
    public string parent;
    public UnityEngine.UIElements.VisualElement children; // 0x10

    // ── Methods ──
    public void get_parent(){} // RVA: 0x7FFD550122F0
    public void get_children(){} // RVA: 0x7FFD55012310
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void Add(){} // RVA: 0x7FFD55012330
    public void Insert(){} // RVA: 0x7FFD550123F0
    public void Remove(){} // RVA: 0x7FFD55012810
    public void RemoveAt(){} // RVA: 0x7FFD55012970
    public void Clear(){} // RVA: 0x7FFD55012CA0
    public void BringToFront(){} // RVA: 0x7FFD550131F0
    public void SendToBack(){} // RVA: 0x7FFD55013350
    public void PlaceBehind(){} // RVA: 0x7FFD55013420
    public void MoveChildElement(){} // RVA: 0x7FFD55013570
    public void get_childCount(){} // RVA: 0x7FFD550136E0
    public void get_Item(){} // RVA: 0x7FFD55013730
    public void IndexOf(){} // RVA: 0x7FFD550137B0
    public void ElementAt(){} // RVA: 0x7FFD55013840
    public void Children(){} // RVA: 0x7FFD55012310
    public void SetParent(){} // RVA: 0x7FFD55013850
    public void PutChildAtIndex(){} // RVA: 0x7FFD550139F0
    public void RemoveChildAtIndex(){} // RVA: 0x7FFD55013B50
    public void ReleaseChildList(){} // RVA: 0x7FFD55013BD0
    public void Equals(){} // RVA: 0x7FFD55013D20 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFD54EE20E0
    public void op_Equality(){} // RVA: 0x7FFD54D16CE0
}

public class HitInfo : ValueType
{
    public UnityEngine.GameObject target; // 0x10
    public UnityEngine.Camera camera; // 0x18

    // ── Methods ──
    public void SendMessage(){} // RVA: 0x7FFD54D625B0
    public void op_Implicit(){} // RVA: 0x7FFD54D625E0
    public void Compare(){} // RVA: 0x7FFD54D62750
}

public class HudLayout : Object
{
    public UnityEngine.RectTransform PopupTransform; // 0x10
    public UnityEngine.RectTransform UserEventTransform; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}
