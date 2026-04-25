// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 25
// Methods: 119

public class HIDCollectionDescriptor : ValueType
{
}

public class HIDDeviceDescriptor : ValueType
{
    // ── Methods ──
    public void ToJson(){} // RVA: 0x7FFD54A826A0
    public void FromJson(){} // RVA: 0x7FFD54A82710
}

public class HIDDeviceDescriptorBuilder : ValueType
{
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
    public object hasNullState;
    public object hasPreferredState;
    public object isArray;
    public object isNonLinear;
    public object isRelative;
    public object isConstant;
    public object isWrapping;
    public object isSigned;
    public object minFloatValue;
    public object maxFloatValue;

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
    // ── Methods ──
    public void Build(){} // RVA: 0x7FFD54A7ED60
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class HIDPageUsage : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54A87310 | overloaded x2
}

public class HandInputData : ValueType
{
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
}

public class Handlers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E389A50
}

public class HashBucket : ValueType
{
    public object IsEmpty;
    public object FirstValue;
    public object AdditionalElements;

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
    public object DefaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFD4E078A90
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Equals(){} // RVA: 0x7FFD4E2ADC40
    public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashBucketByValueEqualityComparer : Object
{
    public object DefaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFD4E078A90
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Equals(){} // RVA: 0x7FFD4E2ADC40
    public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashCode : ValueType
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void ToHashCode(){} // RVA: 0x7FFD4F840210
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashPair : ValueType
{
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class HashsetIterator`1 : ValueType
{
    public object Current;

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
    public object Key;
    public object Entry;
    public object Current;
    public object Value;

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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5126A7D0
    public void AddToCollection(){} // RVA: 0x7FFD5126A890
    public void CreateCollection(){} // RVA: 0x7FFD5126AA30
    public void ToStringCollection(){} // RVA: 0x7FFD5126C340
    public void TryParse(){} // RVA: 0x7FFD5126C710
}

public class Heading : ValueType
{
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
    public object parent;
    public object children;
    public object childCount;
    public object Item;

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
    // ── Methods ──
    public void SendMessage(){} // RVA: 0x7FFD54D625B0
    public void op_Implicit(){} // RVA: 0x7FFD54D625E0
    public void Compare(){} // RVA: 0x7FFD54D62750
}

public class HudLayout : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}
