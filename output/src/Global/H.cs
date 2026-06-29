// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 416

public class HIDDeviceDescriptor : ValueType
{
    // ── Methods ──
    public void ToJson(){} // RVA: 0x9387B0
    public void FromJson(){} // RVA: 0x79163E0
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9388B0
    public void StartReport(){} // RVA: 0x9388E0
    public void AddElement(){} // RVA: 0x938980
    public void WithPhysicalMinMax(){} // RVA: 0x9389E0
    public void WithLogicalMinMax(){} // RVA: 0x938BA0
    public void Finish(){} // RVA: 0x938D60
}

public class HIDElementDescriptor : ValueType
{
    // ── Methods ──
    public void get_hasNullState(){} // RVA: 0x9384F0
    public void get_hasPreferredState(){} // RVA: 0x938500
    public void get_isArray(){} // RVA: 0x938510
    public void get_isNonLinear(){} // RVA: 0x938520
    public void get_isRelative(){} // RVA: 0x938530
    public void get_isConstant(){} // RVA: 0x938540
    public void get_isWrapping(){} // RVA: 0x938550
    public void get_isSigned(){} // RVA: 0x938560
    public void get_minFloatValue(){} // RVA: 0x938570
    public void get_maxFloatValue(){} // RVA: 0x938580
    public void Is(){} // RVA: 0x938590
    public void DetermineName(){} // RVA: 0x9385A0
    public void DetermineDisplayName(){} // RVA: 0x9385B0
    public void IsUsableElement(){} // RVA: 0x9385C0
    public void DetermineLayout(){} // RVA: 0x938600
    public void DetermineFormat(){} // RVA: 0x938610
    public void DetermineUsages(){} // RVA: 0x938620
    public void DetermineParameters(){} // RVA: 0x938630
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x938640
    public void DetermineProcessors(){} // RVA: 0x938650
    public void DetermineDefaultState(){} // RVA: 0x9386B0
    public void AddChildControls(){} // RVA: 0x9386E0
}

public class HIDElementDescriptor[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E81090
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B6D0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5C40
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E36A40
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B6D0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class HIDItemStateGlobal : ValueType
{
    // ── Methods ──
    public void GetUsagePage(){} // RVA: 0x939090
    public void GetPhysicalMin(){} // RVA: 0x9390A0
    public void GetPhysicalMax(){} // RVA: 0x9390B0
}

public class HIDItemStateLocal : ValueType
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x791A6D0
    public void SetUsage(){} // RVA: 0x938FB0
    public void GetUsage(){} // RVA: 0x938FC0
}

public class HIDLayoutBuilder : Object
{
    // ── Methods ──
    public void Build(){} // RVA: 0x7912B50
    public void .ctor(){} // RVA: 0xB43310
}

public class HIDPageUsage : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9390C0
}

public class HIDPageUsage[] : Array
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

public class HIDReportData : ValueType
{
    // ── Methods ──
    public void FindOrAddReport(){} // RVA: 0x791A4C0
}

public class HMacDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x75A8840
    public void Get(){} // RVA: 0xA21F610
}

public class HTTP : Object
{
    // ── Methods ──
    public void SetHttpTransferUpdateCallback(){} // RVA: 0x6B4F4D0
}

public class HTTP_REQUEST_HEADER_ID : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x75A7860
    public void .cctor(){} // RVA: 0x75A78E0
}

public class HandInputData : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x68210
    public void InternalEquals(){} // RVA: 0x68270
    public void DefaultEquals(){} // RVA: 0x682D0
    public void GetHashCode(){} // RVA: 0x68320
    public void InternalGetHashCode(){} // RVA: 0x68380
    public void ToString(){} // RVA: 0x683E0
    public void GetHashCodeOfPtr(){} // RVA: 0x68440
    public void x(){} // RVA: 0x684F0
    // ── Unresolved (hash) ──
    public void m_253(){} // RVA: 0x68490
}

public class Handler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Handlers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB8AE10
}

public class HandshakeHashUpdateStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA1C37F0
    public void Write(){} // RVA: 0xA1D4BD0
}

public class HandshakeMessage : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA1F1E10
    public void Write(){} // RVA: 0xA1F1EF0
    public void WriteToRecordStream(){} // RVA: 0xA1F1F30
}

public class HapticEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA728AE0
    public void Invoke(){} // RVA: 0x40E53F0
    public void BeginInvoke(){} // RVA: 0xA728C50
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class HapticInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class Hash128Input : TextInputBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FE8A20
    public void get_allowedCharacters(){} // RVA: 0x7FE8B20
    public void AcceptCharacter(){} // RVA: 0x7FE8B60
    public void StringToValue(){} // RVA: 0x7FE8460
    public void Parse(){} // RVA: 0x7FE8C60
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_IsEmpty(){} // RVA: 0x87D280
    public void Equals(){} // RVA: 0x87D350
    public void GetHashCode(){} // RVA: 0x87C130
    public void EqualsByRef(){} // RVA: 0xA94080
    public void EqualsByValue(){} // RVA: 0xA94080
    public void Add(){} // RVA: 0xA94080
    public void Contains(){} // RVA: 0xA94080
    public void Freeze(){} // RVA: 0x894290
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x310880
    public void get_IsEmpty(){} // RVA: 0x310890
    public void Equals(){} // RVA: 0x3108A0
    public void GetHashCode(){} // RVA: 0x22E8C0
    public void EqualsByRef(){} // RVA: 0x3108B0
    public void EqualsByValue(){} // RVA: 0x3108D0
    public void Add(){} // RVA: 0x310970
    public void Contains(){} // RVA: 0x3109B0
    public void Freeze(){} // RVA: 0x3109C0
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x87D280
    public void get_FirstValue(){} // RVA: 0xA94080
    public void get_AdditionalElements(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void Equals(){} // RVA: 0x87D350
    public void GetHashCode(){} // RVA: 0x87C130
    public void TryGetValue(){} // RVA: 0xA94080
    public void Freeze(){} // RVA: 0x894290
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x87C0D0
    public void .ctor(){} // RVA: 0x894290
    public void Equals(){} // RVA: 0xA94080
    public void GetHashCode(){} // RVA: 0xA94080
    public void .cctor(){} // RVA: 0x8942F0
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Methods ──
    public void T(){} // RVA: 0xBC21F60
    public void get_DefaultInstance(){} // RVA: 0x3DB7BD0
    public void .ctor(){} // RVA: 0xB43310
    public void Equals(){} // RVA: 0x3F15A30
    public void GetHashCode(){} // RVA: 0x3F2CC40
    public void .cctor(){} // RVA: 0x31C0C90
}

public class HashBucketByValueEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x87C0D0
    public void .ctor(){} // RVA: 0x894320
    public void Equals(){} // RVA: 0xA94080
    public void GetHashCode(){} // RVA: 0xA94080
    public void .cctor(){} // RVA: 0x8942F0
}

public class HashBucketByValueEqualityComparer : Object
{
    // ── Methods ──
    public void T(){} // RVA: 0xBC21AE0
    public void get_DefaultInstance(){} // RVA: 0x3DB7BD0
    public void .ctor(){} // RVA: 0x3F38C50
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x3F392E0
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x747AB40
    public void Invoke(){} // RVA: 0xCA8D60
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x747AB40
    public void Invoke(){} // RVA: 0xCA8D60
}

public class HashDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x75A8840
    public void Get(){} // RVA: 0xA21F570
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x35CF860
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class HashsetIterator`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void GetEnumerator(){} // RVA: 0xA94080
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Dispose(){} // RVA: 0x894290
}

public class HashtableEnumerator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6887B30
    public void Clone(){} // RVA: 0x67F43E0
    public void get_Key(){} // RVA: 0x6887BC0
    public void MoveNext(){} // RVA: 0x6887C30
    public void get_Entry(){} // RVA: 0x6887D60
    public void get_Current(){} // RVA: 0x6887DE0
    public void get_Value(){} // RVA: 0x6887EC0
    public void Reset(){} // RVA: 0x6887F30
}

public class HeadChopBone : Object
{
    // ── Methods ──
    public void get_Transform(){} // RVA: 0xB5DBF0
    public void CanApply(){} // RVA: 0xA6D0F10
    public void GetDesiredScaleFactor(){} // RVA: 0xA6D0F30
    public void .ctor(){} // RVA: 0xB43310
}

public class HeadChopBone[] : Array
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

public class Heading : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x86FD0
}

public class HebrewValue : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D5D0
}

public class HeightProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7D61610
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7D61650
    public void SetValue(){} // RVA: 0x7D605F0
    public void .ctor(){} // RVA: 0x7D61660
}

public class HeightProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7D61990
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x426C4D0
    public void SetValue(){} // RVA: 0x426C4E0
    public void .ctor(){} // RVA: 0x7D619D0
}

public class HeightProperty : InlineStyleLengthProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA0380
    public void get_ussName(){} // RVA: 0x7EA03C0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA0400
    public void SetValue(){} // RVA: 0x7EA0480
    public void .ctor(){} // RVA: 0x7E9E610
}

public class HeightProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECB240
    public void get_ussName(){} // RVA: 0x7ECB280
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECB2C0
    public void SetValue(){} // RVA: 0x7ECB310
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7DB5C00
    public void Invoke(){} // RVA: 0x6A64F30
}

public class HierarchicalBindingsSorter : HierarchyTraversal
{
    // ── Methods ──
    public void get_boundElements(){} // RVA: 0xB5DBF0
    public void set_boundElements(){} // RVA: 0xB44D60
    public void get_results(){} // RVA: 0xB465B0
    public void set_results(){} // RVA: 0xBA9BA0
    public void TraverseRecursive(){} // RVA: 0x7E72B50
    public void .ctor(){} // RVA: 0xB43310
}

public class Hierarchy : ValueType
{
    // ── Methods ──
    public void get_parent(){} // RVA: 0x995B50
    public void get_children(){} // RVA: 0x995B70
    public void .ctor(){} // RVA: 0x47F10
    public void Add(){} // RVA: 0x995B90
    public void Insert(){} // RVA: 0x995C50
    public void Remove(){} // RVA: 0x995C60
    public void RemoveAt(){} // RVA: 0x995C70
    public void Clear(){} // RVA: 0x995C80
    public void BringToFront(){} // RVA: 0x995C90
    public void SendToBack(){} // RVA: 0x995CA0
    public void PlaceBehind(){} // RVA: 0x995CB0
    public void MoveChildElement(){} // RVA: 0x995CC0
    public void get_childCount(){} // RVA: 0x995CD0
    public void get_Item(){} // RVA: 0x995D20
    public void IndexOf(){} // RVA: 0x995D30
    public void ElementAt(){} // RVA: 0x995D40
    public void Children(){} // RVA: 0x995B70
    public void SetParent(){} // RVA: 0x995D50
    public void PutChildAtIndex(){} // RVA: 0x995D60
    public void RemoveChildAtIndex(){} // RVA: 0x995D70
    public void ReleaseChildList(){} // RVA: 0x995D80
    public void Equals(){} // RVA: 0x995DA0
    public void GetHashCode(){} // RVA: 0x995E30
    public void op_Equality(){} // RVA: 0x7C4C240
}

public class HierarchyBindingTracker : Object
{
    // ── Methods ──
    public void GetTrackedElementsCount(){} // RVA: 0x7E71430
    public void GetBoundElements(){} // RVA: 0x7E71480
    public void .ctor(){} // RVA: 0x7E71620
    public void SetDirty(){} // RVA: 0x1A9DEA0
    public void TryGetBindingCollection(){} // RVA: 0x7E719E0
    public void IsTrackingElement(){} // RVA: 0x7E71A50
    public void StartTrackingBinding(){} // RVA: 0x7E71AB0
    public void OnPropertyChanged(){} // RVA: 0x7E71CE0
    public void StopTrackingBinding(){} // RVA: 0x7E723E0
    public void StopTrackingElement(){} // RVA: 0x7E72680
    public void Dispose(){} // RVA: 0x7E72750
    public void OrderBindings(){} // RVA: 0x7E729F0
}

public class HierarchyDataSourceTracker : Object
{
    // ── Methods ──
    public void GetPooledSourceInfo(){} // RVA: 0x7E72C30
    public void ReleasePooledSourceInfo(){} // RVA: 0x7E72D20
    public void .ctor(){} // RVA: 0x7E72E00
    public void IncreaseBindingRefCount(){} // RVA: 0x7E73590
    public void DecreaseBindingRefCount(){} // RVA: 0x7E73730
    public void IncreaseRefCount(){} // RVA: 0x7E73900
    public void OnVisualElementPropertyChanged(){} // RVA: 0x7E73BA0
    public void DecreaseRefCount(){} // RVA: 0x7E73D30
    public void GetTrackedDataSourcesCount(){} // RVA: 0x7E73FD0
    public void GetChangesFromSource(){} // RVA: 0x7E74020
    public void ClearChangesFromSource(){} // RVA: 0x7E740B0
    public void InvalidateCachedDataSource(){} // RVA: 0x7E74150
    public void GetResolvedDataSourceContext(){} // RVA: 0x7E74470
    public void TrackPropertyChanges(){} // RVA: 0x7E752E0
    public void TryGetLastVersion(){} // RVA: 0x7E75570
    public void UpdateVersion(){} // RVA: 0x7E75610
    public void GetHierarchicalDataSourceContext(){} // RVA: 0x7E756D0
    public void RemoveHierarchyDataSourceContextFromElement(){} // RVA: 0x7E75ED0
    public void Dispose(){} // RVA: 0x7E75F30
    public void ClearSourceCache(){} // RVA: 0x7E760C0
}

public class HitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA10F0
    public void Invoke(){} // RVA: 0xBA11C0
    public void BeginInvoke(){} // RVA: 0xBA11F0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class HitInfo : ValueType
{
    // ── Methods ──
    public void SendMessage(){} // RVA: 0x9720C0
    public void op_Implicit(){} // RVA: 0x7CABDB0
    public void Compare(){} // RVA: 0x7CABF30
}

public class HitInfo[] : Array
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

public class HitPoint : Object
{
    // ── Methods ──
    public void get_inProgress(){} // RVA: 0xCBAD80
    public void get_crossFader(){} // RVA: 0xCBAD90
    public void set_crossFader(){} // RVA: 0xCBADA0
    public void get_timer(){} // RVA: 0xC27360
    public void set_timer(){} // RVA: 0xC27370
    public void get_force(){} // RVA: 0xBA9C30
    public void set_force(){} // RVA: 0xBA9C50
    public void get_point(){} // RVA: 0xBA9C60
    public void set_point(){} // RVA: 0xBA9C80
    public void Hit(){} // RVA: 0xCBADB0
    public void Apply(){} // RVA: 0xCBAEE0
    public void GetLength(){} // RVA: 0x890F90
    public void CrossFadeStart(){} // RVA: 0x894290
    public void OnApply(){} // RVA: 0x899A40
    public void .ctor(){} // RVA: 0xCBB030
}

public class HitPointBone : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0xCBB7B0
    public void CrossFadeStart(){} // RVA: 0xCBB890
    public void OnApply(){} // RVA: 0xCBB8E0
    public void .ctor(){} // RVA: 0xCBB030
}

public class HitPointBone[] : Array
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

public class HitPointEffector : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0xCBB100
    public void CrossFadeStart(){} // RVA: 0xCBB2D0
    public void OnApply(){} // RVA: 0xCBB330
    public void .ctor(){} // RVA: 0xCBB030
}

public class HitPointEffector[] : Array
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

public class HotspotProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x803E180
    public void SetValue(){} // RVA: 0x7EDDE00
    public void .ctor(){} // RVA: 0x803E1A0
}

public class HttpApi : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x75A7340
}

public class HudLayout : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class HumanoidMuscle : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class HumanoidMuscle[] : Array
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
