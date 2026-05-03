// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 57
// Methods: 201

public class HIDCollectionDescriptor : ValueType
{
}

public class HIDDeviceDescriptor : ValueType
{
    // ── Methods ──
    public void ToJson(){} // RVA: 0x7FFE87A0AE00
    public void FromJson(){} // RVA: 0x7FFE87A0AE70
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87A0D230 | overloaded x2
    public void StartReport(){} // RVA: 0x7FFE87A0D260
    public void AddElement(){} // RVA: 0x7FFE87A0D720 | overloaded x2
    public void WithPhysicalMinMax(){} // RVA: 0x7FFE87A0D780
    public void WithLogicalMinMax(){} // RVA: 0x7FFE87A0D940
    public void Finish(){} // RVA: 0x7FFE87A0DB00
}

public class HIDElementDescriptor : ValueType
{
    public int usage; // 0x10
    public 0x6654497C usagePage; // 0x14
    public int unit; // 0x18
    public int unitExponent; // 0x1C
    public int logicalMin; // 0x20
    public int logicalMax; // 0x24
    public int physicalMin; // 0x28
    public int physicalMax; // 0x2C
    public 0x66544714 reportType; // 0x30
    public int collectionIndex; // 0x34

    // ── Methods ──
    public void get_hasNullState(){} // RVA: 0x7FFE87A09440
    public void get_hasPreferredState(){} // RVA: 0x7FFE87A09450
    public void get_isArray(){} // RVA: 0x7FFE87A09460
    public void get_isNonLinear(){} // RVA: 0x7FFE87A09470
    public void get_isRelative(){} // RVA: 0x7FFE87A09480
    public void get_isConstant(){} // RVA: 0x7FFE87A09490
    public void get_isWrapping(){} // RVA: 0x7FFE87A094A0
    public void get_isSigned(){} // RVA: 0x7FFE87A094B0
    public void get_minFloatValue(){} // RVA: 0x7FFE87A094C0
    public void get_maxFloatValue(){} // RVA: 0x7FFE87A095A0
    public void Is(){} // RVA: 0x7FFE87A09680
    public void DetermineName(){} // RVA: 0x7FFE87A09690
    public void DetermineDisplayName(){} // RVA: 0x7FFE87A09950
    public void IsUsableElement(){} // RVA: 0x7FFE87A09A30
    public void DetermineLayout(){} // RVA: 0x7FFE87A09A60
    public void DetermineFormat(){} // RVA: 0x7FFE87A09B60
    public void DetermineUsages(){} // RVA: 0x7FFE87A09CE0
    public void DetermineParameters(){} // RVA: 0x7FFE87A0A060
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x7FFE87A0A1A0
    public void DetermineProcessors(){} // RVA: 0x7FFE87A0A350
    public void DetermineDefaultState(){} // RVA: 0x7FFE87A0A3B0
    public void AddChildControls(){} // RVA: 0x7FFE87A0A4F0
}

public class HIDItemStateGlobal : ValueType
{
    // ── Methods ──
    public void GetUsagePage(){} // RVA: 0x7FFE87A0F250
    public void GetPhysicalMin(){} // RVA: 0x7FFE87A0F2E0
    public void GetPhysicalMax(){} // RVA: 0x7FFE87A0F370
}

public class HIDItemStateLocal : ValueType
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFE87A0EF00
    public void SetUsage(){} // RVA: 0x7FFE87A0EFB0
    public void GetUsage(){} // RVA: 0x7FFE87A0F150
}

public class HIDLayoutBuilder : Object
{
    // ── Methods ──
    public void Build(){} // RVA: 0x7FFE87A074C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class HIDPageUsage : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87A0FA70 | overloaded x2
}

public class HIDReportData : ValueType
{
    // ── Methods ──
    public void FindOrAddReport(){} // RVA: 0x7FFE87A0ECE0
}

public class HMacDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87684800
    public void Get(){} // RVA: 0x7FFE89FDFAA0
}

public class HTTP : Object
{
    // ── Methods ──
    public void SetHttpTransferUpdateCallback(){} // RVA: 0x7FFE86C1CDB0
}

public class HTTP_REQUEST_HEADER_ID : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE87683810
    public void .cctor(){} // RVA: 0x7FFE87683890
}

public class HandInputData : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE822CFF20
    public void InternalEquals(){} // RVA: 0x7FFE822D0290
    public void DefaultEquals(){} // RVA: 0x7FFE822D0960
    public void GetHashCode(){} // RVA: 0x7FFE822D0E40
    public void InternalGetHashCode(){} // RVA: 0x7FFE822D1320
    public void ToString(){} // RVA: 0x7FFE822D19C0
    public void GetHashCodeOfPtr(){} // RVA: 0x7FFE822D1EA0
    public void ValidateStructPointers(){} // RVA: 0x7FFE822D2A70
    // ── Unresolved (hash) ──
    public void m_5F0(){} // RVA: 0x7FFE822D2570
    public void m_7B4(){} // RVA: 0x7FFE822D2EF0
}

public class HandState : ValueType
{
}

public class HandStateInternal : ValueType
{
}

public class HandTrackingData : ValueType
{
}

public class Handler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Handlers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81143A50
}

public class HandshakeHashUpdateStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89F83F60
    public void Write(){} // RVA: 0x7FFE89F95380
}

public class HandshakeMessage : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89FB2600 | overloaded x2
    public void Write(){} // RVA: 0x7FFE89FB26E0
    public void WriteToRecordStream(){} // RVA: 0x7FFE89FB2720
}

public class HapticEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4BC020
    public void Invoke(){} // RVA: 0x7FFE84424610
    public void BeginInvoke(){} // RVA: 0x7FFE8A4BC1A0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class HapticInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class HapticsBuffer : ValueType
{
}

public class HapticsDesc : ValueType
{
}

public class HapticsState : ValueType
{
}

public class HasValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87196840
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Hash128Input : TextInputBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87E5FE40
    public void get_allowedCharacters(){} // RVA: 0x7FFE87E5FF40
    public void AcceptCharacter(){} // RVA: 0x7FFE87E5FF80
    public void StringToValue(){} // RVA: 0x7FFE87E5F8B0
    public void Parse(){} // RVA: 0x7FFE87E60080
}

public class HashBucket : ValueType
{
    public System.Collections.Generic.KeyValuePair`2<U,T> _firstValue;
    public Node<System.Collections.Generic.KeyValuePair`2<U,T>> _additionalElements;
    public object field_2; // 0x41

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
    public void get_FirstValue(){} // RVA: 0x7FFE810A1420
    public void get_AdditionalElements(){} // RVA: 0x7FFE80E2E2E0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void Equals(){} // RVA: 0x7FFE80E2F3B0
    public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    public void TryGetValue(){} // RVA: 0x7FFE810A1420
    public void Freeze(){} // RVA: 0x7FFE80E45FE0
}

public class HashBucketByRefEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<T>> s_defaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFE80E2DEE0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Equals(){} // RVA: 0x7FFE810A1420
    public void GetHashCode(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class HashBucketByValueEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<T>> s_defaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFE80E2DEE0
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Equals(){} // RVA: 0x7FFE810A1420
    public void GetHashCode(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class HashCode : ValueType
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFE810A1420
    public void ToHashCode(){} // RVA: 0x7FFE826F4220
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87554570
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class HashDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87684800
    public void Get(){} // RVA: 0x7FFE89FDFA00
}

public class HashPair : ValueType
{
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class HashsetIterator`1 : ValueType
{
    public bool isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class HashtableDebugView : Object
{
}

public class HashtableEnumerator : Object
{
    public System.Collections.Hashtable _hashtable; // 0x10
    public int _bucket; // 0x18
    public int _version; // 0x1C
    public bool _current; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8694F0B0
    public void Clone(){} // RVA: 0x7FFE868BC310
    public void get_Key(){} // RVA: 0x7FFE8694F140
    public void MoveNext(){} // RVA: 0x7FFE8694F1B0
    public void get_Entry(){} // RVA: 0x7FFE8694F2E0
    public void get_Current(){} // RVA: 0x7FFE8694F360
    public void get_Value(){} // RVA: 0x7FFE8694F440
    public void Reset(){} // RVA: 0x7FFE8694F4B0
}

public class HeadChopBone : Object
{
    public UnityEngine.Transform transform; // 0x10

    // ── Methods ──
    public void get_Transform(){} // RVA: 0x7FFE81116380
    public void CanApply(){} // RVA: 0x7FFE8A482570
    public void GetDesiredScaleFactor(){} // RVA: 0x7FFE8A482590
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class HeadChopData : ValueType
{
}

public class HeaderBucket : Object
{
    public object Parsed; // 0x10
    public System.Collections.Generic.List`1<string> values; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F99960
    public void get_HasStringValues(){} // RVA: 0x7FFE873528B0
    public void get_Values(){} // RVA: 0x7FFE87352900
    public void set_Values(){} // RVA: 0x7FFE81161E80
    public void ParsedToString(){} // RVA: 0x7FFE873529C0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8417F9E0
    public void AddToCollection(){} // RVA: 0x7FFE8417FAA0
    public void CreateCollection(){} // RVA: 0x7FFE8417FC40
    public void ToStringCollection(){} // RVA: 0x7FFE84181540
    public void TryParse(){} // RVA: 0x7FFE84181910
}

public class Heading : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A97200
}

public class HebrewValue : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84455D80
}

public class HeightProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4F090
    public void .ctor(){} // RVA: 0x7FFE87D4F0D0
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87D9E2D0
    public void Invoke(){} // RVA: 0x7FFE86B317D0
}

public class Hierarchy : ValueType
{
    public string k_InvalidHierarchyChangeMsg;
    public UnityEngine.UIElements.VisualElement m_Owner; // 0x10
    public System.Action m_OnGUIHandler; // 0x3C8
    public UnityEngine.ObjectGUIState m_ObjectGUIState; // 0x3D0

    // ── Methods ──
    public void get_parent(){} // RVA: 0x7FFE87F9AB40
    public void get_children(){} // RVA: 0x7FFE87F9AB60
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void Add(){} // RVA: 0x7FFE87F9AB80
    public void Insert(){} // RVA: 0x7FFE87F9AC40
    public void Remove(){} // RVA: 0x7FFE87F9B060
    public void RemoveAt(){} // RVA: 0x7FFE87F9B1C0
    public void Clear(){} // RVA: 0x7FFE87F9B4F0
    public void BringToFront(){} // RVA: 0x7FFE87F9BA40
    public void SendToBack(){} // RVA: 0x7FFE87F9BBA0
    public void PlaceBehind(){} // RVA: 0x7FFE87F9BC70
    public void MoveChildElement(){} // RVA: 0x7FFE87F9BDC0
    public void get_childCount(){} // RVA: 0x7FFE87F9BF30
    public void get_Item(){} // RVA: 0x7FFE87F9BF80
    public void IndexOf(){} // RVA: 0x7FFE87F9C000
    public void ElementAt(){} // RVA: 0x7FFE87F9C090
    public void Children(){} // RVA: 0x7FFE87F9AB60
    public void SetParent(){} // RVA: 0x7FFE87F9C0A0
    public void PutChildAtIndex(){} // RVA: 0x7FFE87F9C240
    public void RemoveChildAtIndex(){} // RVA: 0x7FFE87F9C3A0
    public void ReleaseChildList(){} // RVA: 0x7FFE87F9C420
    public void Equals(){} // RVA: 0x7FFE87F9C570 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE87E6A980
    public void op_Equality(){} // RVA: 0x7FFE87C9F580
}

public class HitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159A90
    public void Invoke(){} // RVA: 0x7FFE81159B60
    public void BeginInvoke(){} // RVA: 0x7FFE81159B90
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class HitInfo : ValueType
{
    // ── Methods ──
    public void SendMessage(){} // RVA: 0x7FFE87CEAE50
    public void op_Implicit(){} // RVA: 0x7FFE87CEAE80
    public void Compare(){} // RVA: 0x7FFE87CEAFF0
}

public class HitPoint : Object
{
    public string name; // 0x10
    public UnityEngine.Collider collider; // 0x18
    public float crossFadeTime; // 0x20
    public float _crossFader; // 0x24
    public float _timer; // 0x28

    // ── Methods ──
    public void get_inProgress(){} // RVA: 0x7FFE81268F40
    public void get_crossFader(){} // RVA: 0x7FFE81268F50
    public void set_crossFader(){} // RVA: 0x7FFE81268F60
    public void get_timer(){} // RVA: 0x7FFE811DA210
    public void set_timer(){} // RVA: 0x7FFE811DA220
    public void get_force(){} // RVA: 0x7FFE81161F10
    public void set_force(){} // RVA: 0x7FFE81161F30
    public void get_point(){} // RVA: 0x7FFE81161F40
    public void set_point(){} // RVA: 0x7FFE81161F60
    public void Hit(){} // RVA: 0x7FFE81268F70
    public void Apply(){} // RVA: 0x7FFE812690A0
    public void GetLength(){} // RVA: 0x7FFE80E42E10
    public void CrossFadeStart(){} // RVA: 0x7FFE80E45FE0
    public void OnApply(){} // RVA: 0x7FFE80E52EB0
    public void .ctor(){} // RVA: 0x7FFE812691F0
}

public class HitPointBone : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFE81269A20
    public void CrossFadeStart(){} // RVA: 0x7FFE81269B70
    public void OnApply(){} // RVA: 0x7FFE81269BC0
    public void .ctor(){} // RVA: 0x7FFE812691F0
}

public class HitPointEffector : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFE812692C0
    public void CrossFadeStart(){} // RVA: 0x7FFE81269570
    public void OnApply(){} // RVA: 0x7FFE812695D0
    public void .ctor(){} // RVA: 0x7FFE812691F0
}

public class Host : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFE87359000
}

public class HttpApi : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE876832F0
}

public class HudLayout : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class HumanoidMuscle : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}
