// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 371

public class HIDDeviceDescriptor : ValueType
{
    // ── Methods ──
    public void ToJson(){} // RVA: 0x7A7EB6630
    public void FromJson(){} // RVA: 0x7AECA8690
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EB6690
    public void StartReport(){} // RVA: 0x7A7EB66C0
    public void AddElement(){} // RVA: 0x7A7EB6760
    public void WithPhysicalMinMax(){} // RVA: 0x7A7EB67C0
    public void WithLogicalMinMax(){} // RVA: 0x7A7EB6980
    public void Finish(){} // RVA: 0x7A7EB6B40
}

public class HIDElementDescriptor : ValueType
{
    // ── Methods ──
    public void get_hasNullState(){} // RVA: 0x7A7EB6410
    public void get_hasPreferredState(){} // RVA: 0x7A7EB6420
    public void get_isArray(){} // RVA: 0x7A7EB6430
    public void get_isNonLinear(){} // RVA: 0x7A7EB6440
    public void get_isRelative(){} // RVA: 0x7A7EB6450
    public void get_isConstant(){} // RVA: 0x7A7EB6460
    public void get_isWrapping(){} // RVA: 0x7A7EB6470
    public void get_isSigned(){} // RVA: 0x7A7EB6480
    public void get_minFloatValue(){} // RVA: 0x7A7EB6490
    public void get_maxFloatValue(){} // RVA: 0x7A7EB64A0
    public void Is(){} // RVA: 0x7A7EB64B0
    public void DetermineName(){} // RVA: 0x7A7EB64C0
    public void DetermineDisplayName(){} // RVA: 0x7A7EB64D0
    public void IsUsableElement(){} // RVA: 0x7A7EB64E0
    public void DetermineLayout(){} // RVA: 0x7A7EB6520
    public void DetermineFormat(){} // RVA: 0x7A7EB6530
    public void DetermineUsages(){} // RVA: 0x7A7EB6540
    public void DetermineParameters(){} // RVA: 0x7A7EB6550
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x7A7EB6560
    public void DetermineProcessors(){} // RVA: 0x7A7EB6570
    public void DetermineDefaultState(){} // RVA: 0x7A7EB65D0
    public void AddChildControls(){} // RVA: 0x7A7EB6600
}

public class HIDElementDescriptor[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A3E80
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EC90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4530
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25D950
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EC90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class HIDItemStateGlobal : ValueType
{
    // ── Methods ──
    public void GetUsagePage(){} // RVA: 0x7A7EB6D30
    public void GetPhysicalMin(){} // RVA: 0x7A7EB6D40
    public void GetPhysicalMax(){} // RVA: 0x7A7EB6D50
}

public class HIDItemStateLocal : ValueType
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x7AECAC8E0
    public void SetUsage(){} // RVA: 0x7A7EB6CF0
    public void GetUsage(){} // RVA: 0x7A7EB6D00
}

public class HIDLayoutBuilder : Object
{
    // ── Methods ──
    public void Build(){} // RVA: 0x7AECA4D30
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class HIDPageUsage : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EB6D60
}

public class HIDPageUsage[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A0FB0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2501E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class HIDReportData : ValueType
{
    // ── Methods ──
    public void FindOrAddReport(){} // RVA: 0x7AECAC6D0
}

public class HMacDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE935760
    public void Get(){} // RVA: 0x7B13B3F10
}

public class HTTP : Object
{
    // ── Methods ──
    public void SetHttpTransferUpdateCallback(){} // RVA: 0x7ADEC82D0
}

public class HTTP_REQUEST_HEADER_ID : Object
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7AE934770
    public void .cctor(){} // RVA: 0x7AE9347F0
}

public class HandInputData : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7A764FFD0
    public void InternalEquals(){} // RVA: 0x7A7650030
    public void DefaultEquals(){} // RVA: 0x7A7650080
    public void GetHashCode(){} // RVA: 0x7A76500E0
    public void InternalGetHashCode(){} // RVA: 0x7A7650130
    public void ToString(){} // RVA: 0x7A7650180
    public void GetHashCodeOfPtr(){} // RVA: 0x7A76501D0
    // ── Unresolved (hash) ──
    public void m_238(){} // RVA: 0x7A7650230
    public void m_E1D(){} // RVA: 0x7A7650290
    public void m_DBA(){} // RVA: 0x7A76502F0
}

public class Handler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81577F0
    public void Invoke(){} // RVA: 0x7A8133090
    public void BeginInvoke(){} // RVA: 0x7A81330A0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class Handlers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A811FE30
}

public class HandshakeHashUpdateStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B1357EA0
    public void Write(){} // RVA: 0x7B13692E0
}

public class HandshakeMessage : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B1386670
    public void Write(){} // RVA: 0x7B1386750
    public void WriteToRecordStream(){} // RVA: 0x7B1386790
}

public class HapticEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B18BA820
    public void Invoke(){} // RVA: 0x7AB4CD960
    public void BeginInvoke(){} // RVA: 0x7B18BA990
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class HapticInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class HasValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7AE4463E0
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class Hash128Input : TextInputBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF0FFEB0
    public void get_allowedCharacters(){} // RVA: 0x7AF0FFFB0
    public void AcceptCharacter(){} // RVA: 0x7AF0FFFF0
    public void StringToValue(){} // RVA: 0x7AF0FF920
    public void Parse(){} // RVA: 0x7AF1000F0
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8051B10
    public void get_IsEmpty(){} // RVA: 0x7A7E01900
    public void Equals(){} // RVA: 0x7A7E019D0
    public void GetHashCode(){} // RVA: 0x7A7E00710
    public void EqualsByRef(){} // RVA: 0x7A8051B10
    public void EqualsByValue(){} // RVA: 0x7A8051B10
    public void Add(){} // RVA: 0x7A8051B10
    public void Contains(){} // RVA: 0x7A8051B10
    public void Freeze(){} // RVA: 0x7A7E18770
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7A7E01900
    public void get_FirstValue(){} // RVA: 0x7A8051B10
    public void get_AdditionalElements(){} // RVA: 0x7A7E00680
    public void GetEnumerator(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7A7E00680
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
    public void Equals(){} // RVA: 0x7A7E019D0
    public void GetHashCode(){} // RVA: 0x7A7E00710
    public void TryGetValue(){} // RVA: 0x7A8051B10
    public void Freeze(){} // RVA: 0x7A7E18770
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8051B10
    public void get_IsEmpty(){} // RVA: 0x7A7E01900
    public void get_FirstValue(){} // RVA: 0x7A8051B10
    public void get_AdditionalElements(){} // RVA: 0x7A7E00680
    public void GetEnumerator(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7A7E00680
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
    public void Equals(){} // RVA: 0x7A7E019D0
    public void GetHashCode(){} // RVA: 0x7A7E00710
    public void Add(){} // RVA: 0x7A8051B10
    public void TryGetValue(){} // RVA: 0x7A8051B10
    public void Freeze(){} // RVA: 0x7A7E18770
}

public class HashBucket : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A78CE450
    public void get_IsEmpty(){} // RVA: 0x7A78CE460
    public void Equals(){} // RVA: 0x7A78CE470
    public void GetHashCode(){} // RVA: 0x7A77F3D30
    public void EqualsByRef(){} // RVA: 0x7A78CE480
    public void EqualsByValue(){} // RVA: 0x7A78CE4A0
    public void Add(){} // RVA: 0x7A78CE540
    public void Contains(){} // RVA: 0x7A78CE580
    public void Freeze(){} // RVA: 0x7A78CE590
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7A7E006B0
    public void .ctor(){} // RVA: 0x7A7E18770
    public void Equals(){} // RVA: 0x7A8051B10
    public void GetHashCode(){} // RVA: 0x7A8051B10
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class HashBucketByRefEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7AB0FDD00
    public void .ctor(){} // RVA: 0x7A80D7310
    public void Equals(){} // RVA: 0x7AB265F10
    public void GetHashCode(){} // RVA: 0x7AB2A6110
    public void .cctor(){} // RVA: 0x7AA68D330
}

public class HashBucketByValueEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7A7E006B0
    public void .ctor(){} // RVA: 0x7A7E18800
    public void Equals(){} // RVA: 0x7A8051B10
    public void GetHashCode(){} // RVA: 0x7A8051B10
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class HashBucketByValueEqualityComparer : Object
{
    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7AB0FDD00
    public void .ctor(){} // RVA: 0x7AB2B2410
}

public class HashCode : ValueType
{
    // ── Methods ──
    public void Add(){} // RVA: 0x7A8051B10
    public void ToHashCode(){} // RVA: 0x7A765F070
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3EF0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B2C30
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B2DC0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B2F50
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B30E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3270
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3400
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B46C0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4530
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3590
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3720
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3D60
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B38B0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3A40
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B3BD0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4B70
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B49E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4850
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B6600
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B6470
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5020
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4080
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4E90
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B51B0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B43A0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5340
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4210
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5FC0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B54D0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5E30
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B4D00
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5660
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B5CA0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B6150
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B62E0
}

public class HashCode64`1 : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AB2B2AA0
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE805430
    public void Invoke(){} // RVA: 0x7A8234660
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE805430
    public void Invoke(){} // RVA: 0x7A8234660
}

public class HashDrbgProvider : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE935760
    public void Get(){} // RVA: 0x7B13B3E70
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AA9D5D30
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AA9D5D30
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AA9D5D30
}

public class HashSetPoolImpl`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AA9D5D30
}

public class HashsetIterator`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18800
    public void GetEnumerator(){} // RVA: 0x7A8051B10
    public void get_Current(){} // RVA: 0x7A8051B10
    public void MoveNext(){} // RVA: 0x7A7E01900
    public void Dispose(){} // RVA: 0x7A7E18770
}

public class HashtableEnumerator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADBFC8C0
    public void Clone(){} // RVA: 0x7ADB694F0
    public void get_Key(){} // RVA: 0x7ADBFC950
    public void MoveNext(){} // RVA: 0x7ADBFC9C0
    public void get_Entry(){} // RVA: 0x7ADBFCAF0
    public void get_Current(){} // RVA: 0x7ADBFCB70
    public void get_Value(){} // RVA: 0x7ADBFCC50
    public void Reset(){} // RVA: 0x7ADBFCCC0
}

public class HeadChopBone : Object
{
    // ── Methods ──
    public void get_Transform(){} // RVA: 0x7A80F2570
    public void CanApply(){} // RVA: 0x7B18640E0
    public void GetDesiredScaleFactor(){} // RVA: 0x7B1864100
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class HeadChopBone[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class HeaderBucket : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE247030
    public void get_HasStringValues(){} // RVA: 0x7AE602180
    public void get_Values(){} // RVA: 0x7AE6021D0
    public void set_Values(){} // RVA: 0x7A813E420
    public void ParsedToString(){} // RVA: 0x7AE602290
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1A470
    public void AddToCollection(){} // RVA: 0x7A7E18890
    public void CreateCollection(){} // RVA: 0x7A7E00BD0
    public void ToStringCollection(){} // RVA: 0x7A7E00B20
    public void TryParse(){} // RVA: 0x7A7E01A40
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB306430
    public void AddToCollection(){} // RVA: 0x7AB3064F0
    public void CreateCollection(){} // RVA: 0x7AB306680
    public void ToStringCollection(){} // RVA: 0x7AB307F80
    public void TryParse(){} // RVA: 0x7AB308350
}

public class Heading : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A76721E0
}

public class HebrewValue : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7908E50
}

public class HeightProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7AEFEE3B0
    public void .ctor(){} // RVA: 0x7AEFEE3F0
}

public class HeightProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7AEFEE720
    public void .ctor(){} // RVA: 0x7AEFEE760
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF03DC90
    public void Invoke(){} // RVA: 0x7ADDDD3C0
}

public class Hierarchy : ValueType
{
    // ── Methods ──
    public void get_parent(){} // RVA: 0x7A7F07040
    public void get_children(){} // RVA: 0x7A7F07060
    public void .ctor(){} // RVA: 0x7A7637E60
    public void Add(){} // RVA: 0x7A7F07080
    public void Insert(){} // RVA: 0x7A7F07140
    public void Remove(){} // RVA: 0x7A7F07150
    public void RemoveAt(){} // RVA: 0x7A7F07160
    public void Clear(){} // RVA: 0x7A7F07170
    public void BringToFront(){} // RVA: 0x7A7F07180
    public void SendToBack(){} // RVA: 0x7A7F07190
    public void PlaceBehind(){} // RVA: 0x7A7F071A0
    public void MoveChildElement(){} // RVA: 0x7A7F071B0
    public void get_childCount(){} // RVA: 0x7A7F071C0
    public void get_Item(){} // RVA: 0x7A7F07210
    public void IndexOf(){} // RVA: 0x7A7F07220
    public void ElementAt(){} // RVA: 0x7A7F07230
    public void Children(){} // RVA: 0x7A7F07060
    public void SetParent(){} // RVA: 0x7A7F07240
    public void PutChildAtIndex(){} // RVA: 0x7A7F07250
    public void RemoveChildAtIndex(){} // RVA: 0x7A7F07260
    public void ReleaseChildList(){} // RVA: 0x7A7F07270
    public void Equals(){} // RVA: 0x7A7F07290
    public void GetHashCode(){} // RVA: 0x7A7EFE5B0
    public void op_Equality(){} // RVA: 0x7AEF3E3D0
}

public class HitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8135F10
    public void Invoke(){} // RVA: 0x7A8135FE0
    public void BeginInvoke(){} // RVA: 0x7A8136010
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class HitInfo : ValueType
{
    // ── Methods ──
    public void SendMessage(){} // RVA: 0x7A7EE5580
    public void op_Implicit(){} // RVA: 0x7AEF8A0B0
    public void Compare(){} // RVA: 0x7AEF8A230
}

public class HitPoint : Object
{
    // ── Methods ──
    public void get_inProgress(){} // RVA: 0x7A82461B0
    public void get_crossFader(){} // RVA: 0x7A82461C0
    public void set_crossFader(){} // RVA: 0x7A82461D0
    public void get_timer(){} // RVA: 0x7A81B7060
    public void set_timer(){} // RVA: 0x7A81B7070
    public void get_force(){} // RVA: 0x7A813E4B0
    public void set_force(){} // RVA: 0x7A813E4D0
    public void get_point(){} // RVA: 0x7A813E4E0
    public void set_point(){} // RVA: 0x7A813E500
    public void Hit(){} // RVA: 0x7A82461E0
    public void Apply(){} // RVA: 0x7A8246310
    public void GetLength(){} // RVA: 0x7A7E155B0
    public void CrossFadeStart(){} // RVA: 0x7A7E18770
    public void OnApply(){} // RVA: 0x7A7E1DD40
    public void .ctor(){} // RVA: 0x7A8246460
}

public class HitPointBone : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7A8246C90
    public void CrossFadeStart(){} // RVA: 0x7A8246DE0
    public void OnApply(){} // RVA: 0x7A8246E30
    public void .ctor(){} // RVA: 0x7A8246460
}

public class HitPointBone[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class HitPointEffector : HitPoint
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7A8246530
    public void CrossFadeStart(){} // RVA: 0x7A82467E0
    public void OnApply(){} // RVA: 0x7A8246840
    public void .ctor(){} // RVA: 0x7A8246460
}

public class HitPointEffector[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class HttpApi : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AE934250
}

public class HudLayout : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class HumanoidMuscle : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class HumanoidMuscle[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}
