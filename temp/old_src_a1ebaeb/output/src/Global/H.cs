// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 71
// Methods: 201

public class HIDCollectionDescriptor : ValueType
{
    public object usagePage; // 0x34C9E140
    public object firstChild; // 0x34C9E140
}

public class HIDDeviceDescriptor : ValueType
{
    public object usage; // 0x34C27E40
    public object outputReportSize; // 0x34C27E40
    public object collections; // 0x34C27E40
    public object touchpadButton; // 0x17000411
    public object optionsButton; // 0x17000412
    public object shareButton; // 0x17000413

    // ── Original Methods ──
    public void ToJson(){} // RVA: 0x7ffaaf084680
    public void FromJson(){} // RVA: 0x7ffaaf0846f0
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    public object m_CurrentReportId; // 0x34C9E2C0
    public object m_Elements; // 0x34C9E2C0
    public object m_OutputReportSize; // 0x34C9E2C0
    public object value__; // 0x34C9E6F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf086ab0
    public void .ctor(){} // RVA: 0x7ffaaf086ab0
    public void StartReport(){} // RVA: 0x7ffaaf086ae0
    public void AddElement(){} // RVA: 0x7ffaaf086fa0
    public void AddElement(){} // RVA: 0x7ffaaf086fa0
    public void WithPhysicalMinMax(){} // RVA: 0x7ffaaf087000
    public void WithLogicalMinMax(){} // RVA: 0x7ffaaf0871c0
    public void Finish(){} // RVA: 0x7ffaaf087380
}

public class HIDElementDescriptor : ValueType
{
    public object unit; // 0x34C9DFC0
    public object logicalMax; // 0x34C9DFC0
    public object reportType; // 0x34C9DFC0
    public object reportSizeInBits; // 0x34C9DFC0
    public object usageMin; // 0x34C9DFC0

    // ── Original Methods ──
    public void get_hasNullState(){} // RVA: 0x7ffaaf082cc0
    public void get_hasPreferredState(){} // RVA: 0x7ffaaf082cd0
    public void get_isArray(){} // RVA: 0x7ffaaf082ce0
    public void get_isNonLinear(){} // RVA: 0x7ffaaf082cf0
    public void get_isRelative(){} // RVA: 0x7ffaaf082d00
    public void get_isConstant(){} // RVA: 0x7ffaaf082d10
    public void get_isWrapping(){} // RVA: 0x7ffaaf082d20
    public void get_isSigned(){} // RVA: 0x7ffaaf082d30
    public void get_minFloatValue(){} // RVA: 0x7ffaaf082d40
    public void get_maxFloatValue(){} // RVA: 0x7ffaaf082e20
    public void Is(){} // RVA: 0x7ffaaf082f00
    public void DetermineName(){} // RVA: 0x7ffaaf082f10
    public void DetermineDisplayName(){} // RVA: 0x7ffaaf0831d0
    public void IsUsableElement(){} // RVA: 0x7ffaaf0832b0
    public void DetermineLayout(){} // RVA: 0x7ffaaf0832e0
    public void DetermineFormat(){} // RVA: 0x7ffaaf0833e0
    public void DetermineUsages(){} // RVA: 0x7ffaaf083560
    public void DetermineParameters(){} // RVA: 0x7ffaaf0838e0
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x7ffaaf083a20
    public void DetermineProcessors(){} // RVA: 0x7ffaaf083bd0
    public void DetermineDefaultState(){} // RVA: 0x7ffaaf083c30
    public void AddChildControls(){} // RVA: 0x7ffaaf083d70
}

public class HIDLayoutBuilder : Object
{
    public object parentLayout; // 0x34C9D630
    public object WithCapability; // 0xB3FA1D70

    // ── Original Methods ──
    public void Build(){} // RVA: 0x7ffaaf080d40
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class HIDPageUsage : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf0892f0
    public void .ctor(){} // RVA: 0x7ffaaf0892f0
}

public class HandInputData : ValueType
{
    public object FingerExtended; // 0x33F07340
    public object PreviousWristPositionPlayspace; // 0x33F07340

    // ── Binary Analysis Named ──
    public void GetGameObject_558(){} // RVA: 0x7ffaa9a3f9c0
    public void GetGameObject_002(){} // RVA: 0x7ffaa9a40090
    public void SetEnabled_05B(){} // RVA: 0x7ffaa9a40760
    public void GetGameObject_594(){} // RVA: 0x7ffaa9a40ad0
    public void DoGetSceneByName_Injected_69D(){} // RVA: 0x7ffaa9a41170
    public void DoGetIsLoadedInternal_3EF(){} // RVA: 0x7ffaa9a414e0
    public void DoGetIsLoadedInternal_CEE(){} // RVA: 0x7ffaa9a419d0
    public void DoInverseTransform(){} // RVA: 0x7ffaa9a41d40
    public void DoTransformPoint_Injected(){} // RVA: 0x7ffaa9a42230
    public void DoGetIsLoadedInternal_4CA(){} // RVA: 0x7ffaa9a425a0
    public void DoGetIsLoadedInternal_00D(){} // RVA: 0x7ffaa9a42c70
}

public class HandTrackingData : ValueType
{
    public object IsPersisting; // 0x33F071C0
    public object WristPose; // 0x33F071C0
}

public class Handlers : Object
{
    public object Utf8StringWriter; // 0x35E5A7F0
    public object ǳ_; // 0x20120000
    public object _buckets; // 0x36820A40

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa897aa50
}

public class HashBucket : ValueType
{
    // ── Original Methods ──
    public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
    public void get_FirstValue(){} // RVA: 0x7ffaa887e5c0
    public void get_AdditionalElements(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void Equals(){} // RVA: 0x7ffaa864a2a0
    public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
    public void Freeze(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
    public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
}

public class HashBucket : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
    public void get_FirstValue(){} // RVA: 0x7ffaa887e5c0
    public void get_AdditionalElements(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void Equals(){} // RVA: 0x7ffaa864a2a0
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
    public void Freeze(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
    public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
}

public class HashBucket : ValueType
{
    public object _firstValue; // 0x36A166D8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
    public void Equals(){} // RVA: 0x7ffaa864a2a0
    public void EqualsByRef(){} // RVA: 0x7ffaa887e5c0
    public void EqualsByValue(){} // RVA: 0x7ffaa887e5c0
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void Contains(){} // RVA: 0x7ffaa887e5c0
    public void Freeze(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
}

public class HashBucket : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab7c3e20
    public void get_IsEmpty(){} // RVA: 0x7ffaab7c3f70
    public void Equals(){} // RVA: 0x7ffaab7beda0
    public void EqualsByRef(){} // RVA: 0x7ffaaa264940
    public void EqualsByValue(){} // RVA: 0x7ffaab7c3f80
    public void Add(){} // RVA: 0x7ffaab7c4030
    public void Contains(){} // RVA: 0x7ffaab7c4230
    public void Freeze(){} // RVA: 0x7ffaab7c4350
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaaad85520
}

public class HashBucket : ValueType
{
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Original Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7ffaa8648dd0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Equals(){} // RVA: 0x7ffaa887e5c0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa887e5c0
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Original Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7ffaab654a40
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Equals(){} // RVA: 0x7ffaab7ab920
    public void .cctor(){} // RVA: 0x7ffaaad6ba60
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaab7beda0
}

public class HashBucketByValueEqualityComparer : Object
{
    public object s_defaultInstance; // 0x36A20DB8

    // ── Original Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7ffaa8648dd0
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void Equals(){} // RVA: 0x7ffaa887e5c0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa887e5c0
}

public class HashBucketByValueEqualityComparer : Object
{
}

public class HashCode : ValueType
{
    // ── Original Methods ──
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void ToHashCode(){} // RVA: 0x7ffaa9e47550
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ccb10
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cb850
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cb9e0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cbb70
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cbd00
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cbe90
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc020
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd2e0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd150
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc1b0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc340
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc980
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc4d0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc660
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cc7f0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd790
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd600
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd470
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cf220
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cf090
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cdc40
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ccca0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cdab0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cddd0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ccfc0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cdf60
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cce30
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cebe0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ce0f0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cea50
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cd920
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ce280
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ce8c0
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7ced70
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cef00
}

public class HashCode64`1 : ValueType
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaab7cb6c0
}

public class HashPair : ValueType
{
}

public class HashSetPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class HashSetPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaaaf9ae40
}

public class HashSetPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaaaf9ae40
}

public class HashSetPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaaaf9ae40
}

public class HashsetIterator`1 : ValueType
{
    public object enumerator; // 0x310248D0
    public object Current; // 0x17000068

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void get_Current(){} // RVA: 0x7ffaa887e5c0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
}

public class HashtableDebugView : Object
{
}

public class HashtableEnumerator : Object
{
    public object _version; // 0x34CA6C80
    public object _currentKey; // 0x34CA6C80

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadfc6af0
    public void Clone(){} // RVA: 0x7ffaadf33d60
    public void get_Key(){} // RVA: 0x7ffaadfc6b80
    public void MoveNext(){} // RVA: 0x7ffaadfc6bf0
    public void get_Entry(){} // RVA: 0x7ffaadfc6d20
    public void get_Current(){} // RVA: 0x7ffaadfc6da0
    public void get_Value(){} // RVA: 0x7ffaadfc6e80
    public void Reset(){} // RVA: 0x7ffaadfc6ef0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab84db00
    public void AddToCollection(){} // RVA: 0x7ffaab84dbc0
    public void CreateCollection(){} // RVA: 0x7ffaab84dd60
    public void ToStringCollection(){} // RVA: 0x7ffaab84f670
    public void TryParse(){} // RVA: 0x7ffaab84fa40
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    // ── Original Methods ──
    public void .ctor(){}
    public void AddToCollection(){} // RVA: 0x7ffaa8669e70
    public void CreateCollection(){} // RVA: 0x7ffaa865aa30
    public void ToStringCollection(){} // RVA: 0x7ffaa8649280
    public void TryParse(){} // RVA: 0x7ffaa864d540
}

public class Heading : ValueType
{
    public object m_Bias; // 0x34B3F490
    public object RigsAreCreated; // 0x17000023

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa236d70
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf417990
    public void Invoke(){} // RVA: 0x7ffaae1a9270
}

public class Hierarchy : ValueType
{
    public object m_OnGUIHandler; // 0x35BC04D0

    // ── Original Methods ──
    public void get_parent(){} // RVA: 0x7ffaaf614260
    public void get_children(){} // RVA: 0x7ffaaf614280
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void Add(){} // RVA: 0x7ffaaf6142a0
    public void Insert(){} // RVA: 0x7ffaaf614360
    public void Remove(){} // RVA: 0x7ffaaf614780
    public void RemoveAt(){} // RVA: 0x7ffaaf6148e0
    public void Clear(){} // RVA: 0x7ffaaf614c10
    public void BringToFront(){} // RVA: 0x7ffaaf615160
    public void SendToBack(){} // RVA: 0x7ffaaf6152c0
    public void PlaceBehind(){} // RVA: 0x7ffaaf615390
    public void MoveChildElement(){} // RVA: 0x7ffaaf6154e0
    public void get_childCount(){} // RVA: 0x7ffaaf615650
    public void get_Item(){} // RVA: 0x7ffaaf6156a0
    public void IndexOf(){} // RVA: 0x7ffaaf615720
    public void ElementAt(){} // RVA: 0x7ffaaf6157b0
    public void Children(){} // RVA: 0x7ffaaf614280
    public void PutChildAtIndex(){} // RVA: 0x7ffaaf615960
    public void RemoveChildAtIndex(){} // RVA: 0x7ffaaf615ac0
    public void ReleaseChildList(){} // RVA: 0x7ffaaf615b40
    public void Equals(){} // RVA: 0x7ffaaf615c90
    public void Equals(){} // RVA: 0x7ffaaf615c90
    public void op_Equality(){} // RVA: 0x7ffaaf318c40
    // ── Binary Analysis Named ──
    public void SetParent(){} // RVA: 0x7ffaaf6157c0
    public void GetHashCode(){} // RVA: 0x7ffaaf4e4040
}

public class HitInfo : ValueType
{
    // ── Original Methods ──
    public void SendMessage(){} // RVA: 0x7ffaaf364510
    public void op_Implicit(){} // RVA: 0x7ffaaf364540
    public void Compare(){} // RVA: 0x7ffaaf3646b0
}

public class HudLayout : Object
{
    public object LeftLayout; // 0x335A9B00

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}
